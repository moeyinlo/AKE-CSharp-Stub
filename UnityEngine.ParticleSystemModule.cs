/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.ParticleSystemJobs;
using UnityEngine.Scripting;

// Image 74: UnityEngine.ParticleSystemModule.dll - Assembly: UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62317-62381
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: InternalsVisibleTo("UnityEngine.ARModule")]
[assembly: InternalsVisibleTo("UnityEngine.AIModule")]
[assembly: InternalsVisibleTo("UnityEngine")]
[assembly: InternalsVisibleTo("UnityEngine.SharedInternalsModule")]
[assembly: InternalsVisibleTo("UnityEngine.CoreModule")]
[assembly: InternalsVisibleTo("UnityEngine.AndroidJNIModule")]
[assembly: InternalsVisibleTo("UnityEngine.InputModule")]
[assembly: InternalsVisibleTo("UnityEngine.AnimationModule")]
[assembly: InternalsVisibleTo("UnityEngine.AntiSDKModule")]
[assembly: InternalsVisibleTo("UnityEngine.TerrainModule")]
[assembly: InternalsVisibleTo("UnityEngine.ParticleSystemModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGGraphicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.AccessibilityModule")]
[assembly: InternalsVisibleTo("UnityEngine.HotReloadModule")]
[assembly: InternalsVisibleTo("UnityEngine.AssetBundleModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGGraphicsCPPModule")]
[assembly: InternalsVisibleTo("UnityEngine.AudioModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClothModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClusterInputModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClusterRendererModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityConnectModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsCommonModule")]
[assembly: InternalsVisibleTo("UnityEngine.TLSModule")]
[assembly: InternalsVisibleTo("UnityEngine.PhysicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestModule")]
[assembly: InternalsVisibleTo("UnityEngine.CrashReportingModule")]
[assembly: InternalsVisibleTo("UnityEngine.DirectorModule")]
[assembly: InternalsVisibleTo("UnityEngine.DSPGraphModule")]
[assembly: InternalsVisibleTo("UnityEngine.ImageConversionModule")]
[assembly: InternalsVisibleTo("UnityEngine.GameCenterModule")]
[assembly: InternalsVisibleTo("UnityEngine.GIModule")]
[assembly: InternalsVisibleTo("UnityEngine.GridModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsModule")]
[assembly: InternalsVisibleTo("UnityEngine.PS5Module")]
[assembly: InternalsVisibleTo("UnityEngine.JSONSerializeModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextRenderingModule")]
[assembly: InternalsVisibleTo("UnityEngine.TilemapModule")]
[assembly: InternalsVisibleTo("UnityEngine.SpriteMaskModule")]
[assembly: InternalsVisibleTo("UnityEngine.LiteSSLModule")]
[assembly: InternalsVisibleTo("UnityEngine.LocalizationModule")]
[assembly: InternalsVisibleTo("UnityEngine.PerformanceReportingModule")]
[assembly: InternalsVisibleTo("UnityEngine.Physics2DModule")]
[assembly: InternalsVisibleTo("UnityEngine.ProfilerModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIModule")]
[assembly: InternalsVisibleTo("UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule")]
[assembly: InternalsVisibleTo("UnityEngine.SpriteShapeModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextCoreTextEngineModule")]
[assembly: InternalsVisibleTo("UnityEngine.StreamingModule")]
[assembly: InternalsVisibleTo("UnityEngine.StreamLineModule")]
[assembly: InternalsVisibleTo("UnityEngine.SubstanceModule")]
[assembly: InternalsVisibleTo("UnityEngine.SubsystemsModule")]
[assembly: InternalsVisibleTo("UnityEngine.TerrainPhysicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.ScreenCaptureModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGOcclusionCullingModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsNativeModule")]
[assembly: InternalsVisibleTo("UnityEngine.VRModule")]
[assembly: InternalsVisibleTo("UnityEngine.InputLegacyModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestTextureModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsModule")]
[assembly: InternalsVisibleTo("UnityEngine.UmbraModule")]
[assembly: InternalsVisibleTo("UnityEngine.UNETModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityCurlModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityTestProtocolModule")]
[assembly: InternalsVisibleTo("UnityEngine.WindModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestAssetBundleModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestWWWModule")]
[assembly: InternalsVisibleTo("UnityEngine.IMGUIModule")]
[assembly: InternalsVisibleTo("UnityEngine.VehiclesModule")]
[assembly: InternalsVisibleTo("UnityEngine.VFXModule")]
[assembly: InternalsVisibleTo("UnityEngine.VideoModule")]
[assembly: InternalsVisibleTo("UnityEngine.VirtualTexturingModule")]
[assembly: InternalsVisibleTo("UnityEngine.XRModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestAudioModule")]
[assembly: InternalsVisibleTo("UnityEngine.PS5VRModule")]
[assembly: InternalsVisibleTo("UnityEngine.Networking")]
[assembly: InternalsVisibleTo("UnityEngine.Cloud")]
[assembly: InternalsVisibleTo("UnityEngine.Cloud.Service")]
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
[assembly: InternalsVisibleTo("UnityEngine.UI")]
[assembly: InternalsVisibleTo("Unity.Networking.Transport")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.AllIn1Runner")]
[assembly: InternalsVisibleTo("Unity.Timeline")]
[assembly: InternalsVisibleTo("Assembly-CSharp-testable")]
[assembly: InternalsVisibleTo("Assembly-CSharp-firstpass-testable")]
[assembly: InternalsVisibleTo("UnityEngine.SpatialTracking")]
[assembly: InternalsVisibleTo("GoogleAR.UnityNative")]
[assembly: InternalsVisibleTo("Unity.WindowsMRAutomation")]
[assembly: InternalsVisibleTo("Unity.2D.Sprite.Editor")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.Framework.Tests")]
[assembly: InternalsVisibleTo("Unity.UI.Builder.Editor")]
[assembly: InternalsVisibleTo("UnityEditor.UIBuilderModule")]
[assembly: InternalsVisibleTo("Unity.UI.Builder.EditorTests")]
[assembly: InternalsVisibleTo("Unity.UIElements")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsGameObjectsModule")]
[assembly: InternalsVisibleTo("Unity.UIElements.Editor")]
[assembly: InternalsVisibleTo("Unity.UIElements.PlayModeTests")]
[assembly: InternalsVisibleTo("Unity.UIElements.EditorTests")]
[assembly: InternalsVisibleTo("Unity.PerformanceTests.RuntimeTestRunner.Tests")]
[assembly: InternalsVisibleTo("UnityEngine.TextCoreFontEngineModule")]
[assembly: InternalsVisibleTo("Unity.ucg.QoS")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.022")]
[assembly: InternalsVisibleTo("Unity.Logging")]
[assembly: InternalsVisibleTo("Unity.Entities")]
[assembly: InternalsVisibleTo("Unity.Entities.Tests")]
[assembly: InternalsVisibleTo("Unity.Collections")]
[assembly: InternalsVisibleTo("Unity.Runtime")]
[assembly: InternalsVisibleTo("Unity.Core")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.001")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.002")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.003")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.004")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.005")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.006")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.007")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.008")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.009")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.010")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.011")]
[assembly: InternalsVisibleTo("Unity.Services.QoS")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.014")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.015")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.016")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.017")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.018")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.019")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.020")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.021")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.012")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.023")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.024")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.001")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.002")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.003")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.004")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.005")]
[assembly: InternalsVisibleTo("Unity.Subsystem.Registration")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.013")]
[assembly: InternalsVisibleTo("Unity.2D.Sprite.EditorTests")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: UnityEngineModuleAssembly]

namespace UnityEngine
{
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[RequireComponent(typeof(Transform))]
	[UsedByNativeCode]
	public sealed class ParticleSystem : Component // TypeDefIndex: 62357
	{
		// Properties
		[Obsolete("startDelay property is deprecated. Use main.startDelay or main.startDelayMultiplier instead.", false)]
		public float startDelay { get; set; } // 0x000000018B41C678-0x000000018B41C6A8 0x000000018B41CB38-0x000000018B41CB68
		[Obsolete("loop property is deprecated. Use main.loop instead.", false)]
		public bool loop { get; set; } // 0x000000018B41C488-0x000000018B41C4B8 0x000000018B41C934-0x000000018B41C96C
		[Obsolete("playOnAwake property is deprecated. Use main.playOnAwake instead.", false)]
		public bool playOnAwake { get; set; } // 0x000000018B41C4E8-0x000000018B41C518 0x000000018B41C9A4-0x000000018B41C9DC
		[Obsolete("duration property is deprecated. Use main.duration instead.", false)]
		public float duration { get; } // 0x000000018B41C2F8-0x000000018B41C328 
		[Obsolete("playbackSpeed property is deprecated. Use main.simulationSpeed instead.", false)]
		public float playbackSpeed { get; set; } // 0x000000018B41C518-0x000000018B41C548 0x000000018B41C9DC-0x000000018B41CA0C
		[Obsolete("enableEmission property is deprecated. Use emission.enabled instead.", false)]
		public bool enableEmission { get; set; } // 0x000000018B41C358-0x000000018B41C388 0x000000018B41C8CC-0x000000018B41C904
		[Obsolete("emissionRate property is deprecated. Use emission.rateOverTime, emission.rateOverDistance, emission.rateOverTimeMultiplier or emission.rateOverDistanceMultiplier instead.", false)]
		public float emissionRate { get; set; } // 0x000000018B41C328-0x000000018B41C358 0x000000018B41C870-0x000000018B41C8CC
		[Obsolete("startSpeed property is deprecated. Use main.startSpeed or main.startSpeedMultiplier instead.", false)]
		public float startSpeed { get; set; } // 0x000000018B41C7D8-0x000000018B41C808 0x000000018B41CC48-0x000000018B41CC78
		[Obsolete("startSize property is deprecated. Use main.startSize or main.startSizeMultiplier instead.", false)]
		public float startSize { get; set; } // 0x000000018B41C7A8-0x000000018B41C7D8 0x000000018B41CC18-0x000000018B41CC48
		[Obsolete("startColor property is deprecated. Use main.startColor instead.", false)]
		public UnityEngine.Color startColor { get; set; } // 0x000000018B41C610-0x000000018B41C678 0x000000018B41CABC-0x000000018B41CB38
		[Obsolete("startRotation property is deprecated. Use main.startRotation or main.startRotationMultiplier instead.", false)]
		public float startRotation { get; set; } // 0x000000018B41C778-0x000000018B41C7A8 0x000000018B41CBE8-0x000000018B41CC18
		[Obsolete("startRotation3D property is deprecated. Use main.startRotationX, main.startRotationY and main.startRotationZ instead. (Or main.startRotationXMultiplier, main.startRotationYMultiplier and main.startRotationZMultiplier).", false)]
		public Vector3 startRotation3D { get; set; } // 0x000000018B41C6D8-0x000000018B41C778 0x000000018B41CB98-0x000000018B41CBE8
		[Obsolete("startLifetime property is deprecated. Use main.startLifetime or main.startLifetimeMultiplier instead.", false)]
		public float startLifetime { get; set; } // 0x000000018B41C6A8-0x000000018B41C6D8 0x000000018B41CB68-0x000000018B41CB98
		[Obsolete("gravityModifier property is deprecated. Use main.gravityModifier or main.gravityModifierMultiplier instead.", false)]
		public float gravityModifier { get; set; } // 0x000000018B41C388-0x000000018B41C3B8 0x000000018B41C904-0x000000018B41C934
		[Obsolete("maxParticles property is deprecated. Use main.maxParticles instead.", false)]
		public int maxParticles { get; set; } // 0x000000018B41C4B8-0x000000018B41C4E8 0x000000018B41C96C-0x000000018B41C9A4
		[Obsolete("simulationSpace property is deprecated. Use main.simulationSpace instead.", false)]
		public ParticleSystemSimulationSpace simulationSpace { get; set; } // 0x000000018B41C5E0-0x000000018B41C610 0x000000018B41CA84-0x000000018B41CABC
		[Obsolete("scalingMode property is deprecated. Use main.scalingMode instead.", false)]
		public ParticleSystemScalingMode scalingMode { get; set; } // 0x000000018B41C5B0-0x000000018B41C5E0 0x000000018B41CA4C-0x000000018B41CA84
		[Obsolete("automaticCullingEnabled property is deprecated. Use proceduralSimulationSupported instead (UnityUpgradable) -> proceduralSimulationSupported", true)]
		public bool automaticCullingEnabled { get; } // 0x000000018B41C2EC-0x000000018B41C2F8 
		public bool isPlaying { [NativeName("SyncJobs(false)->IsPlaying")] get; } // 0x000000018B41C420-0x000000018B41C454 
		public bool isEmitting { [NativeName("SyncJobs(false)->IsEmitting")] get; } // 0x000000018B41C3B8-0x000000018B41C3EC 
		public bool isStopped { [NativeName("SyncJobs(false)->IsStopped")] get; } // 0x000000018B41C454-0x000000018B41C488 
		public bool isPaused { [NativeName("SyncJobs(false)->IsPaused")] get; } // 0x000000018B41C3EC-0x000000018B41C420 
		public int particleCount { [NativeName("SyncJobs(false)->GetParticleCount")] get; } // 0x000000018330C8B0-0x000000018330C8F0 
		public float time { [NativeName("SyncJobs(false)->GetSecPosition")] get; [NativeName("SyncJobs(false)->SetSecPosition")] set; } // 0x000000018B41C808-0x000000018B41C83C 0x000000018B41CC78-0x000000018B41CCBC
		public uint randomSeed { [NativeName("GetRandomSeed")] get; [NativeName("SyncJobs(false)->SetRandomSeed")] set; } // 0x000000018B41C57C-0x000000018B41C5B0 0x000000018B41CA0C-0x000000018B41CA4C
		public bool useAutoRandomSeed { [NativeName("GetAutoRandomSeed")] get; [NativeName("SyncJobs(false)->SetAutoRandomSeed")] set; } // 0x000000018B41C83C-0x000000018B41C870 0x000000018B41CCBC-0x000000018B41CD00
		public bool proceduralSimulationSupported { get; } // 0x000000018B41C548-0x000000018B41C57C 
		public MainModule main { get; } // 0x000000018339B870-0x000000018339B890 
		public EmissionModule emission { get; } // 0x000000018339B870-0x000000018339B890 
		public ShapeModule shape { get; } // 0x000000018339B870-0x000000018339B890 
		public VelocityOverLifetimeModule velocityOverLifetime { get; } // 0x000000018339B870-0x000000018339B890 
		public LimitVelocityOverLifetimeModule limitVelocityOverLifetime { get; } // 0x000000018339B870-0x000000018339B890 
		public InheritVelocityModule inheritVelocity { get; } // 0x000000018339B870-0x000000018339B890 
		public LifetimeByEmitterSpeedModule lifetimeByEmitterSpeed { get; } // 0x000000018339B870-0x000000018339B890 
		public ForceOverLifetimeModule forceOverLifetime { get; } // 0x000000018339B870-0x000000018339B890 
		public ColorOverLifetimeModule colorOverLifetime { get; } // 0x000000018339B870-0x000000018339B890 
		public ColorBySpeedModule colorBySpeed { get; } // 0x000000018339B870-0x000000018339B890 
		public SizeOverLifetimeModule sizeOverLifetime { get; } // 0x000000018339B870-0x000000018339B890 
		public SizeBySpeedModule sizeBySpeed { get; } // 0x000000018339B870-0x000000018339B890 
		public RotationOverLifetimeModule rotationOverLifetime { get; } // 0x000000018339B870-0x000000018339B890 
		public RotationBySpeedModule rotationBySpeed { get; } // 0x000000018339B870-0x000000018339B890 
		public ExternalForcesModule externalForces { get; } // 0x000000018339B870-0x000000018339B890 
		public NoiseModule noise { get; } // 0x000000018339B870-0x000000018339B890 
		public CollisionModule collision { get; } // 0x000000018339B870-0x000000018339B890 
		public TriggerModule trigger { get; } // 0x000000018339B870-0x000000018339B890 
		public SubEmittersModule subEmitters { get; } // 0x000000018339B870-0x000000018339B890 
		public TextureSheetAnimationModule textureSheetAnimation { get; } // 0x000000018339B870-0x000000018339B890 
		public LightsModule lights { get; } // 0x000000018339B870-0x000000018339B890 
		public TrailModule trails { get; } // 0x000000018339B870-0x000000018339B890 
		public CustomDataModule customData { get; } // 0x000000018339B870-0x000000018339B890 
	
		// Nested types
		public struct MainModule // TypeDefIndex: 62318
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public float duration { get; [NativeThrows] set; } // 0x000000018B41851C-0x000000018B418524 0x000000018B418964-0x000000018B41896C
			public bool loop { get; [NativeThrows] set; } // 0x000000018B418594-0x000000018B41859C 0x000000018B4189FC-0x000000018B418A04
			public float startDelayMultiplier { get; [NativeThrows] set; } // 0x000000018B41868C-0x000000018B418694 0x000000018B418ADC-0x000000018B418AE4
			public MinMaxCurve startLifetime { get; [NativeThrows] set; } // 0x000000018B418714-0x000000018B418744 0x000000018B418B74-0x000000018B418B88
			public float startLifetimeMultiplier { get; [NativeThrows] set; } // 0x000000018B4186C8-0x000000018B4186D0 0x000000018B418B28-0x000000018B418B30
			public MinMaxCurve startSpeed { get; } // 0x000000018B4188F0-0x000000018B418920 
			public float startSpeedMultiplier { get; [NativeThrows] set; } // 0x000000018B4188A4-0x000000018B4188AC 0x000000018B418DA0-0x000000018B418DA8
			[NativeName("StartSizeX")]
			public MinMaxCurve startSize { [NativeThrows] set; } // 0x000000018B418D48-0x000000018B418D5C
			[NativeName("StartSizeXMultiplier")]
			public float startSizeMultiplier { get; [NativeThrows] set; } // 0x000000018B418868-0x000000018B418870 0x000000018B418CFC-0x000000018B418D04
			[NativeName("StartRotationZMultiplier")]
			public float startRotationMultiplier { get; [NativeThrows] set; } // 0x000000018B418778-0x000000018B418780 0x000000018B418BCC-0x000000018B418BD4
			public float startRotationXMultiplier { get; [NativeThrows] set; } // 0x000000018B4187B4-0x000000018B4187BC 0x000000018B418C18-0x000000018B418C20
			public float startRotationYMultiplier { get; [NativeThrows] set; } // 0x000000018B4187F0-0x000000018B4187F8 0x000000018B418C64-0x000000018B418C6C
			public float startRotationZMultiplier { get; [NativeThrows] set; } // 0x000000018B41882C-0x000000018B418834 0x000000018B418CB0-0x000000018B418CB8
			public MinMaxGradient startColor { get; [NativeThrows] set; } // 0x0000000183820C70-0x0000000183820CB0 0x0000000185393AA4-0x0000000185393AB8
			public float gravityModifierMultiplier { get; [NativeThrows] set; } // 0x000000018B418558-0x000000018B418560 0x000000018B4189B0-0x000000018B4189B8
			public ParticleSystemSimulationSpace simulationSpace { get; [NativeThrows] set; } // 0x000000018B418648-0x000000018B418650 0x000000018B418A90-0x000000018B418A98
			public float simulationSpeed { get; [NativeThrows] set; } // 0x000000018B418650-0x000000018B418658 0x0000000185392318-0x0000000185392320
			public ParticleSystemScalingMode scalingMode { get; [NativeThrows] set; } // 0x000000018B41860C-0x000000018B418614 0x0000000185395D88-0x0000000185395D90
			public bool playOnAwake { get; [NativeThrows] set; } // 0x000000018B4185D0-0x000000018B4185D8 0x000000018B418A48-0x000000018B418A50
			public int maxParticles { get; [NativeThrows] set; } // 0x0000000185395D80-0x0000000185395D88 0x0000000185395D90-0x0000000185395D98
	
			// Constructors
			internal MainModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
	
			// Methods
			private static float get_duration_Injected(ref MainModule _unity_self); // 0x000000018B4184E8-0x000000018B41851C
			private static void set_duration_Injected(ref MainModule _unity_self, float value); // 0x000000018B418920-0x000000018B418964
			private static bool get_loop_Injected(ref MainModule _unity_self); // 0x000000018B418560-0x000000018B418594
			private static void set_loop_Injected(ref MainModule _unity_self, bool value); // 0x000000018B4189B8-0x000000018B4189FC
			private static float get_startDelayMultiplier_Injected(ref MainModule _unity_self); // 0x000000018B418658-0x000000018B41868C
			private static void set_startDelayMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018B418A98-0x000000018B418ADC
			private static void get_startLifetime_Injected(ref MainModule _unity_self, out MinMaxCurve ret); // 0x000000018B4186D0-0x000000018B418714
			private static void set_startLifetime_Injected(ref MainModule _unity_self, ref MinMaxCurve value); // 0x000000018B418B30-0x000000018B418B74
			private static float get_startLifetimeMultiplier_Injected(ref MainModule _unity_self); // 0x000000018B418694-0x000000018B4186C8
			private static void set_startLifetimeMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018B418AE4-0x000000018B418B28
			private static void get_startSpeed_Injected(ref MainModule _unity_self, out MinMaxCurve ret); // 0x000000018B4188AC-0x000000018B4188F0
			private static float get_startSpeedMultiplier_Injected(ref MainModule _unity_self); // 0x000000018B418870-0x000000018B4188A4
			private static void set_startSpeedMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018B418D5C-0x000000018B418DA0
			private static void set_startSize_Injected(ref MainModule _unity_self, ref MinMaxCurve value); // 0x000000018B418D04-0x000000018B418D48
			private static float get_startSizeMultiplier_Injected(ref MainModule _unity_self); // 0x000000018B418834-0x000000018B418868
			private static void set_startSizeMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018B418CB8-0x000000018B418CFC
			private static float get_startRotationMultiplier_Injected(ref MainModule _unity_self); // 0x000000018B418744-0x000000018B418778
			private static void set_startRotationMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018B418B88-0x000000018B418BCC
			private static float get_startRotationXMultiplier_Injected(ref MainModule _unity_self); // 0x000000018B418780-0x000000018B4187B4
			private static void set_startRotationXMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018B418BD4-0x000000018B418C18
			private static float get_startRotationYMultiplier_Injected(ref MainModule _unity_self); // 0x000000018B4187BC-0x000000018B4187F0
			private static void set_startRotationYMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018B418C20-0x000000018B418C64
			private static float get_startRotationZMultiplier_Injected(ref MainModule _unity_self); // 0x000000018B4187F8-0x000000018B41882C
			private static void set_startRotationZMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018B418C6C-0x000000018B418CB0
			private static void get_startColor_Injected(ref MainModule _unity_self, out MinMaxGradient ret); // 0x0000000183820CB0-0x0000000183820D00
			private static void set_startColor_Injected(ref MainModule _unity_self, ref MinMaxGradient value); // 0x0000000184B37B00-0x0000000184B37B50
			private static float get_gravityModifierMultiplier_Injected(ref MainModule _unity_self); // 0x000000018B418524-0x000000018B418558
			private static void set_gravityModifierMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018B41896C-0x000000018B4189B0
			private static ParticleSystemSimulationSpace get_simulationSpace_Injected(ref MainModule _unity_self); // 0x000000018B418614-0x000000018B418648
			private static void set_simulationSpace_Injected(ref MainModule _unity_self, ParticleSystemSimulationSpace value); // 0x000000018B418A50-0x000000018B418A90
			private static float get_simulationSpeed_Injected(ref MainModule _unity_self); // 0x0000000184048780-0x00000001840487C0
			private static void set_simulationSpeed_Injected(ref MainModule _unity_self, float value); // 0x0000000183FAA510-0x0000000183FAA560
			private static ParticleSystemScalingMode get_scalingMode_Injected(ref MainModule _unity_self); // 0x000000018B4185D8-0x000000018B41860C
			private static void set_scalingMode_Injected(ref MainModule _unity_self, ParticleSystemScalingMode value); // 0x0000000183E042A0-0x0000000183E042F0
			private static bool get_playOnAwake_Injected(ref MainModule _unity_self); // 0x000000018B41859C-0x000000018B4185D0
			private static void set_playOnAwake_Injected(ref MainModule _unity_self, bool value); // 0x000000018B418A04-0x000000018B418A48
			private static int get_maxParticles_Injected(ref MainModule _unity_self); // 0x0000000183E04210-0x0000000183E04250
			private static void set_maxParticles_Injected(ref MainModule _unity_self, int value); // 0x0000000183E04250-0x0000000183E042A0
		}
	
		public struct EmissionModule // TypeDefIndex: 62319
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public bool enabled { get; [NativeThrows] set; } // 0x000000018B418458-0x000000018B418460 0x000000018B4184E0-0x000000018B4184E8
			public MinMaxCurve rateOverTime { get; [NativeThrows] set; } // 0x0000000183E04160-0x0000000183E041C0 0x0000000185395D98-0x0000000185395DAC
			public float rateOverTimeMultiplier { get; } // 0x000000018B418494-0x000000018B41849C 
	
			// Constructors
			internal EmissionModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
	
			// Methods
			private static bool get_enabled_Injected(ref EmissionModule _unity_self); // 0x000000018B418424-0x000000018B418458
			private static void set_enabled_Injected(ref EmissionModule _unity_self, bool value); // 0x000000018B41849C-0x000000018B4184E0
			private static void get_rateOverTime_Injected(ref EmissionModule _unity_self, out MinMaxCurve ret); // 0x0000000183E041C0-0x0000000183E04210
			private static void set_rateOverTime_Injected(ref EmissionModule _unity_self, ref MinMaxCurve value); // 0x0000000183E042F0-0x0000000183E04340
			private static float get_rateOverTimeMultiplier_Injected(ref EmissionModule _unity_self); // 0x000000018B418460-0x000000018B418494
		}
	
		public struct ShapeModule // TypeDefIndex: 62320
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public bool enabled { [NativeThrows] set; } // 0x000000018B41CDE4-0x000000018B41CDEC
			public ParticleSystemShapeType shapeType { [NativeThrows] set; } // 0x0000000185393370-0x0000000185393378
			public float radius { [NativeThrows] set; } // 0x000000018B41CEC8-0x000000018B41CED0
			public Mesh mesh { [NativeThrows] set; } // 0x000000018B41CE7C-0x000000018B41CE84
			public MeshRenderer meshRenderer { [NativeThrows] set; } // 0x000000018B41CE30-0x000000018B41CE38
			public SkinnedMeshRenderer skinnedMeshRenderer { [NativeThrows] set; } // 0x0000000185393378-0x0000000185393380
			public float textureClipThreshold { [NativeThrows] set; } // 0x000000018B41CF60-0x000000018B41CF68
			public float textureClipThresholdUpper { [NativeThrows] set; } // 0x000000018B41CF14-0x000000018B41CF1C
	
			// Constructors
			internal ShapeModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
	
			// Methods
			private static void set_enabled_Injected(ref ShapeModule _unity_self, bool value); // 0x000000018B41CDA0-0x000000018B41CDE4
			private static void set_shapeType_Injected(ref ShapeModule _unity_self, ParticleSystemShapeType value); // 0x0000000184CD8D60-0x0000000184CD8DB0
			private static void set_radius_Injected(ref ShapeModule _unity_self, float value); // 0x000000018B41CE84-0x000000018B41CEC8
			private static void set_mesh_Injected(ref ShapeModule _unity_self, Mesh value); // 0x000000018B41CE38-0x000000018B41CE7C
			private static void set_meshRenderer_Injected(ref ShapeModule _unity_self, MeshRenderer value); // 0x000000018B41CDEC-0x000000018B41CE30
			private static void set_skinnedMeshRenderer_Injected(ref ShapeModule _unity_self, SkinnedMeshRenderer value); // 0x0000000184CD8D10-0x0000000184CD8D60
			private static void set_textureClipThreshold_Injected(ref ShapeModule _unity_self, float value); // 0x000000018B41CF1C-0x000000018B41CF60
			private static void set_textureClipThresholdUpper_Injected(ref ShapeModule _unity_self, float value); // 0x000000018B41CED0-0x000000018B41CF14
		}
	
		public struct CollisionModule // TypeDefIndex: 62321
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public bool enabled { get; } // 0x000000018B41841C-0x000000018B418424 
	
			// Constructors
			internal CollisionModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
	
			// Methods
			private static bool get_enabled_Injected(ref CollisionModule _unity_self); // 0x000000018B4183E8-0x000000018B41841C
		}
	
		public struct TriggerModule // TypeDefIndex: 62322
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal TriggerModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct SubEmittersModule // TypeDefIndex: 62323
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public int subEmittersCount { get; } // 0x000000018B41CFE4-0x000000018B41CFEC 
	
			// Constructors
			internal SubEmittersModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
	
			// Methods
			[NativeThrows]
			public ParticleSystem GetSubEmitterSystem(int index); // 0x000000018B41CFA8-0x000000018B41CFB0
			private static int get_subEmittersCount_Injected(ref SubEmittersModule _unity_self); // 0x000000018B41CFB0-0x000000018B41CFE4
			private static ParticleSystem GetSubEmitterSystem_Injected(ref SubEmittersModule _unity_self, int index); // 0x000000018B41CF68-0x000000018B41CFA8
		}
	
		public struct TextureSheetAnimationModule // TypeDefIndex: 62324
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal TextureSheetAnimationModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		[RequiredByNativeCode("particleSystemParticle", Optional = true)]
		public struct Particle // TypeDefIndex: 62325
		{
			// Fields
			private Vector3 m_Position; // 0x00
			private Vector3 m_Velocity; // 0x0C
			private Vector3 m_AnimatedVelocity; // 0x18
			private Vector3 m_InitialVelocity; // 0x24
			private Vector3 m_AxisOfRotation; // 0x30
			private Vector3 m_Rotation; // 0x3C
			private Vector3 m_AngularVelocity; // 0x48
			private Vector3 m_StartSize; // 0x54
			private Color32 m_StartColor; // 0x60
			private uint m_RandomSeed; // 0x64
			private uint m_ParentRandomSeed; // 0x68
			private float m_Lifetime; // 0x6C
			private float m_StartLifetime; // 0x70
			private int m_MeshIndex; // 0x74
			private float m_EmitAccumulator0; // 0x78
			private float m_EmitAccumulator1; // 0x7C
			private uint m_Flags; // 0x80
	
			// Properties
			[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", false)]
			public float lifetime { set; } // 0x0000000184DA3330-0x0000000184DA3340
			public Vector3 position { set; } // 0x0000000184DABF80-0x0000000184DABF90
			public Vector3 velocity { set; } // 0x0000000184DBAA60-0x0000000184DBAA70
			public float remainingLifetime { set; } // 0x0000000184DA3330-0x0000000184DA3340
			public float startLifetime { set; } // 0x0000000184D90600-0x0000000184D90610
			public Color32 startColor { set; } // 0x0000000184D86D50-0x0000000184D86D60
			public uint randomSeed { set; } // 0x0000000184D88120-0x0000000184D88130
			public float startSize { set; } // 0x0000000184DBD210-0x0000000184DBD230
			public Vector3 rotation3D { set; } // 0x000000018B41CD50-0x000000018B41CDA0
			public Vector3 angularVelocity3D { set; } // 0x000000018B41CD00-0x000000018B41CD50
		}
	
		[Serializable]
		[NativeType(CodegenOptions.Custom, "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
		public struct MinMaxCurve // TypeDefIndex: 62326
		{
			// Fields
			[SerializeField]
			private ParticleSystemCurveMode m_Mode; // 0x00
			[SerializeField]
			private float m_CurveMultiplier; // 0x04
			[SerializeField]
			private AnimationCurve m_CurveMin; // 0x08
			[SerializeField]
			private AnimationCurve m_CurveMax; // 0x10
			[SerializeField]
			private float m_ConstantMin; // 0x18
			[SerializeField]
			private float m_ConstantMax; // 0x1C
	
			// Properties
			public ParticleSystemCurveMode mode { get; } // 0x0000000184DBA750-0x0000000184DBA760 
			public AnimationCurve curveMax { get; } // 0x0000000184D9B600-0x0000000184D9B610 
			public AnimationCurve curveMin { get; } // 0x0000000184DBA980-0x0000000184DBA990 
			public float constantMax { get; } // 0x0000000184DBD180-0x0000000184DBD190 
			public float constantMin { get; } // 0x0000000184DBAB50-0x0000000184DBAB60 
			public float constant { get; set; } // 0x0000000184DBD180-0x0000000184DBD190 0x0000000184D86900-0x0000000184D86910
			public AnimationCurve curve { get; } // 0x0000000184D9B600-0x0000000184D9B610 
	
			// Constructors
			public MinMaxCurve(float constant); // 0x00000001847A9B90-0x00000001847A9BD0
	
			// Methods
			public static implicit operator MinMaxCurve(float constant); // 0x00000001847A9B20-0x00000001847A9B90
		}
	
		[Serializable]
		[NativeType(CodegenOptions.Custom, "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
		public struct MinMaxGradient // TypeDefIndex: 62327
		{
			// Fields
			[SerializeField]
			private ParticleSystemGradientMode m_Mode; // 0x00
			[SerializeField]
			private Gradient m_GradientMin; // 0x08
			[SerializeField]
			private Gradient m_GradientMax; // 0x10
			[SerializeField]
			private UnityEngine.Color m_ColorMin; // 0x18
			[SerializeField]
			private UnityEngine.Color m_ColorMax; // 0x28
	
			// Properties
			public UnityEngine.Color colorMax { set; } // 0x0000000184D8FAE0-0x0000000184D8FAF0
			public UnityEngine.Color colorMin { set; } // 0x0000000184D890D0-0x0000000184D890E0
			public UnityEngine.Color color { get; set; } // 0x0000000184DBCFB0-0x0000000184DBCFC0 0x0000000184D8FAE0-0x0000000184D8FAF0
	
			// Constructors
			public MinMaxGradient(UnityEngine.Color color); // 0x000000018B418DA8-0x000000018B418DF8
	
			// Methods
			public static implicit operator MinMaxGradient(UnityEngine.Color color); // 0x000000018B418DF8-0x000000018B418E74
		}
	
		public struct EmitParams // TypeDefIndex: 62328
		{
			// Fields
			[NativeName("particle")]
			private Particle m_Particle; // 0x00
			[NativeName("positionSet")]
			private bool m_PositionSet; // 0x84
			[NativeName("velocitySet")]
			private bool m_VelocitySet; // 0x85
			[NativeName("axisOfRotationSet")]
			private bool m_AxisOfRotationSet; // 0x86
			[NativeName("rotationSet")]
			private bool m_RotationSet; // 0x87
			[NativeName("rotationalSpeedSet")]
			private bool m_AngularVelocitySet; // 0x88
			[NativeName("startSizeSet")]
			private bool m_StartSizeSet; // 0x89
			[NativeName("startColorSet")]
			private bool m_StartColorSet; // 0x8A
			[NativeName("randomSeedSet")]
			private bool m_RandomSeedSet; // 0x8B
			[NativeName("startLifetimeSet")]
			private bool m_StartLifetimeSet; // 0x8C
			[NativeName("meshIndexSet")]
			private bool m_MeshIndexSet; // 0x8D
			[NativeName("applyShapeToPosition")]
			private bool m_ApplyShapeToPosition; // 0x8E
		}
	
		public struct PlaybackState // TypeDefIndex: 62339
		{
			// Fields
			internal float m_AccumulatedDt; // 0x00
			internal float m_StartDelay; // 0x04
			internal float m_PlaybackTime; // 0x08
			internal int m_RingBufferIndex; // 0x0C
			internal Emission m_Emission; // 0x10
			internal Initial m_Initial; // 0x28
			internal Shape m_Shape; // 0x68
			internal Force m_Force; // 0xC4
			internal Collision m_Collision; // 0x104
			internal Noise m_Noise; // 0x144
			internal Lights m_Lights; // 0x148
			internal Trail m_Trail; // 0x15C
	
			// Nested types
			internal struct Seed // TypeDefIndex: 62329
			{
				// Fields
				public uint x; // 0x00
				public uint y; // 0x04
				public uint z; // 0x08
				public uint w; // 0x0C
			}
	
			internal struct Seed4 // TypeDefIndex: 62330
			{
				// Fields
				public Seed x; // 0x00
				public Seed y; // 0x10
				public Seed z; // 0x20
				public Seed w; // 0x30
			}
	
			internal struct Emission // TypeDefIndex: 62331
			{
				// Fields
				public float m_ParticleSpacing; // 0x00
				public float m_ToEmitAccumulator; // 0x04
				public Seed m_Random; // 0x08
			}
	
			internal struct Initial // TypeDefIndex: 62332
			{
				// Fields
				public Seed4 m_Random; // 0x00
			}
	
			internal struct Shape // TypeDefIndex: 62333
			{
				// Fields
				public Seed4 m_Random; // 0x00
				public float m_RadiusTimer; // 0x40
				public float m_RadiusTimerPrev; // 0x44
				public float m_ArcTimer; // 0x48
				public float m_ArcTimerPrev; // 0x4C
				public float m_MeshSpawnTimer; // 0x50
				public float m_MeshSpawnTimerPrev; // 0x54
				public int m_OrderedMeshVertexIndex; // 0x58
			}
	
			internal struct Force // TypeDefIndex: 62334
			{
				// Fields
				public Seed4 m_Random; // 0x00
			}
	
			internal struct Collision // TypeDefIndex: 62335
			{
				// Fields
				public Seed4 m_Random; // 0x00
			}
	
			internal struct Noise // TypeDefIndex: 62336
			{
				// Fields
				public float m_ScrollOffset; // 0x00
			}
	
			internal struct Lights // TypeDefIndex: 62337
			{
				// Fields
				public Seed m_Random; // 0x00
				public float m_ParticleEmissionCounter; // 0x10
			}
	
			internal struct Trail // TypeDefIndex: 62338
			{
				// Fields
				public float m_Timer; // 0x00
			}
		}
	
		[NativeType(CodegenOptions.Custom, "MonoParticleTrails")]
		public struct Trails // TypeDefIndex: 62340
		{
			// Fields
			internal List<Vector4> positions; // 0x00
			internal List<int> frontPositions; // 0x08
			internal List<int> backPositions; // 0x10
			internal List<int> positionCounts; // 0x18
			internal int maxTrailCount; // 0x20
			internal int maxPositionsPerTrailCount; // 0x24
	
			// Methods
			internal void Allocate(); // 0x000000018B41CFEC-0x000000018B41D128
		}
	
		public struct VelocityOverLifetimeModule // TypeDefIndex: 62341
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal VelocityOverLifetimeModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct LimitVelocityOverLifetimeModule // TypeDefIndex: 62342
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal LimitVelocityOverLifetimeModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct InheritVelocityModule // TypeDefIndex: 62343
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal InheritVelocityModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct LifetimeByEmitterSpeedModule // TypeDefIndex: 62344
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal LifetimeByEmitterSpeedModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct ForceOverLifetimeModule // TypeDefIndex: 62345
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ForceOverLifetimeModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct ColorOverLifetimeModule // TypeDefIndex: 62346
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ColorOverLifetimeModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct ColorBySpeedModule // TypeDefIndex: 62347
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ColorBySpeedModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct SizeOverLifetimeModule // TypeDefIndex: 62348
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal SizeOverLifetimeModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct SizeBySpeedModule // TypeDefIndex: 62349
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal SizeBySpeedModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct RotationOverLifetimeModule // TypeDefIndex: 62350
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal RotationOverLifetimeModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct RotationBySpeedModule // TypeDefIndex: 62351
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal RotationBySpeedModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct ExternalForcesModule // TypeDefIndex: 62352
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ExternalForcesModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct NoiseModule // TypeDefIndex: 62353
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal NoiseModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct LightsModule // TypeDefIndex: 62354
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal LightsModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct TrailModule // TypeDefIndex: 62355
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal TrailModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		public struct CustomDataModule // TypeDefIndex: 62356
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal CustomDataModule(ParticleSystem particleSystem); // 0x0000000185392320-0x0000000185392328
		}
	
		// Constructors
		public ParticleSystem(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
		public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color); // 0x000000018B41B540-0x000000018B41B648
		[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
		public void Emit(Particle particle); // 0x000000018B41B648-0x000000018B41B65C
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize", HasExplicitThis = true)]
		internal float GetParticleCurrentSize(ref Particle particle); // 0x000000018B41B870-0x000000018B41B8B4
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize3D", HasExplicitThis = true)]
		internal Vector3 GetParticleCurrentSize3D(ref Particle particle); // 0x000000018B41B83C-0x000000018B41B870
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentColor", HasExplicitThis = true)]
		internal Color32 GetParticleCurrentColor(ref Particle particle); // 0x000000018B41B7C4-0x000000018B41B7E8
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleMeshIndex", HasExplicitThis = true)]
		internal int GetParticleMeshIndex(ref Particle particle); // 0x000000018B41B8B4-0x000000018B41B8F8
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", HasExplicitThis = true, ThrowsException = true)]
		public void SetParticles(out Particle[] particles, int size, int offset); // 0x000000018B41BF5C-0x000000018B41BFC0
		public void SetParticles(out Particle[] particles, int size); // 0x000000018B41BF40-0x000000018B41BF5C
		public void SetParticles(out Particle[] particles); // 0x000000018B41BEE4-0x000000018B41BEF4
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticlesWithNativeArray", HasExplicitThis = true, ThrowsException = true)]
		private void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset); // 0x000000018B41BE80-0x000000018B41BEE4
		public void SetParticles(out NativeArray<Particle> particles, int size, int offset); // 0x000000018B41BFC0-0x000000018B41C030
		public void SetParticles(out NativeArray<Particle> particles, int size); // 0x000000018B41BF18-0x000000018B41BF40
		public void SetParticles(out NativeArray<Particle> particles); // 0x000000018B41BEF4-0x000000018B41BF18
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = true, ThrowsException = true)]
		public int GetParticles([NotNull("ArgumentNullException")] out Particle[] particles, int size, int offset); // 0x000000018B41BA28-0x000000018B41BA8C
		public int GetParticles(out Particle[] particles, int size); // 0x000000018B41BA8C-0x000000018B41BAA8
		public int GetParticles(out Particle[] particles); // 0x000000018B41B95C-0x000000018B41B96C
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticlesWithNativeArray", HasExplicitThis = true, ThrowsException = true)]
		private int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset); // 0x000000018B41B8F8-0x000000018B41B95C
		public int GetParticles(out NativeArray<Particle> particles, int size, int offset); // 0x000000018B41B9B8-0x000000018B41BA28
		public int GetParticles(out NativeArray<Particle> particles, int size); // 0x000000018B41B990-0x000000018B41B9B8
		public int GetParticles(out NativeArray<Particle> particles); // 0x000000018B41B96C-0x000000018B41B990
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetCustomParticleData", HasExplicitThis = true, ThrowsException = true)]
		public void SetCustomParticleData([NotNull("ArgumentNullException")] List<Vector4> customData, ParticleSystemCustomData streamIndex); // 0x000000018B41BD94-0x000000018B41BDE8
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetCustomParticleData", HasExplicitThis = true, ThrowsException = true)]
		public int GetCustomParticleData([NotNull("ArgumentNullException")] List<Vector4> customData, ParticleSystemCustomData streamIndex); // 0x000000018B41B678-0x000000018B41B6CC
		public PlaybackState GetPlaybackState(); // 0x000000018B41BAEC-0x000000018B41BB28
		public void SetPlaybackState(PlaybackState playbackState); // 0x000000018B41C074-0x000000018B41C088
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetTrailData", HasExplicitThis = true)]
		private void GetTrailDataInternal(ref Trails trailData); // 0x000000018B41BB28-0x000000018B41BB6C
		public Trails GetTrails(); // 0x000000018B41BB6C-0x000000018B41BBE4
		public int GetTrails(ref Trails trailData); // 0x000000018B41BBE4-0x000000018B41BC44
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetTrailData", HasExplicitThis = true)]
		public void SetTrails(Trails trailData); // 0x000000018B41C0CC-0x000000018B41C0E0
		[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = true)]
		public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart, [DefaultValue("true")] bool fixedTimeStep); // 0x000000018B41C0E0-0x000000018B41C144
		public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart); // 0x000000018B41C16C-0x000000018B41C188
		public void Simulate(float t, [DefaultValue("true")] bool withChildren); // 0x000000018B41C150-0x000000018B41C16C
		public void Simulate(float t); // 0x000000018B41C144-0x000000018B41C150
		[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = true)]
		public void Play([DefaultValue("true")] bool withChildren); // 0x0000000184279190-0x00000001842791E0
		public void Play(); // 0x0000000185392D00-0x0000000185392D0C
		[FreeFunction(Name = "ParticleSystemScriptBindings::Pause", HasExplicitThis = true)]
		public void Pause([DefaultValue("true")] bool withChildren); // 0x000000018B41BCA0-0x000000018B41BCE4
		public void Pause(); // 0x000000018B41BC94-0x000000018B41BCA0
		[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = true)]
		public void Stop([DefaultValue("true")] bool withChildren, [DefaultValue("ParticleSystemStopBehavior.StopEmitting")] ParticleSystemStopBehavior stopBehavior); // 0x0000000183FDE640-0x0000000183FDE6A0
		public void Stop([DefaultValue("true")] bool withChildren); // 0x000000018B41C19C-0x000000018B41C1AC
		public void Stop(); // 0x000000018B41C188-0x000000018B41C19C
		[FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = true)]
		public void Clear([DefaultValue("true")] bool withChildren); // 0x0000000184046500-0x0000000184046550
		public void Clear(); // 0x000000018B41B418-0x000000018B41B424
		[FreeFunction(Name = "ParticleSystemScriptBindings::IsAlive", HasExplicitThis = true)]
		public bool IsAlive([DefaultValue("true")] bool withChildren); // 0x000000018B41BC44-0x000000018B41BC88
		public bool IsAlive(); // 0x000000018B41BC88-0x000000018B41BC94
		[RequiredByNativeCode]
		public void Emit(int count); // 0x000000018B41B65C-0x000000018B41B664
		[NativeName("SyncJobs()->Emit")]
		private void Emit_Internal(int count); // 0x000000018B41B500-0x000000018B41B540
		[NativeName("SyncJobs()->EmitParticlesExternal")]
		public void Emit(EmitParams emitParams, int count); // 0x000000018B41B664-0x000000018B41B678
		[NativeName("SyncJobs()->EmitParticleExternal")]
		private void EmitOld_Internal(ref Particle particle); // 0x000000018B41B468-0x000000018B41B4AC
		public void TriggerSubEmitter(int subEmitterIndex); // 0x000000018B41C210-0x000000018B41C21C
		public void TriggerSubEmitter(int subEmitterIndex, ref Particle particle); // 0x000000018B41C26C-0x000000018B41C2EC
		[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitterForParticle", HasExplicitThis = true)]
		internal void TriggerSubEmitterForParticle(int subEmitterIndex, Particle particle); // 0x000000018B41C1FC-0x000000018B41C210
		[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitter", HasExplicitThis = true)]
		public void TriggerSubEmitter(int subEmitterIndex, List<Particle> particles); // 0x000000018B41C21C-0x000000018B41C26C
		[FreeFunction(Name = "ParticleSystemGeometryJob::ResetPreMappedBufferMemory")]
		public static void ResetPreMappedBufferMemory(); // 0x000000018B41BCE4-0x000000018B41BD10
		[FreeFunction(Name = "ParticleSystemGeometryJob::SetMaximumPreMappedBufferCounts")]
		public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount); // 0x000000018B41BE40-0x000000018B41BE80
		[NativeName("SetUsesAxisOfRotation")]
		public void AllocateAxisOfRotationAttribute(); // 0x000000018B41B370-0x000000018B41B3A4
		[NativeName("SetUsesMeshIndex")]
		public void AllocateMeshIndexAttribute(); // 0x000000018B41B3E4-0x000000018B41B418
		[NativeName("SetUsesCustomData")]
		public void AllocateCustomDataAttribute(ParticleSystemCustomData stream); // 0x000000018B41B3A4-0x000000018B41B3E4
		internal unsafe void* GetManagedJobData(); // 0x000000018B41B6CC-0x000000018B41B700
		internal JobHandle GetManagedJobHandle(); // 0x000000018B41B744-0x000000018B41B770
		internal void SetManagedJobHandle(JobHandle handle); // 0x000000018B41BE2C-0x000000018B41BE40
		[FreeFunction("ScheduleManagedJob", ThrowsException = true)]
		internal static unsafe JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData); // 0x000000018B41BD64-0x000000018B41BD94
		[ThreadSafe]
		internal static unsafe void CopyManagedJobData(void* systemPtr, out NativeParticleData particleData); // 0x000000018B41B424-0x000000018B41B468
		private void GetParticleCurrentSize3D_Injected(ref Particle particle, out Vector3 ret); // 0x000000018B41B7E8-0x000000018B41B83C
		private void GetParticleCurrentColor_Injected(ref Particle particle, out Color32 ret); // 0x000000018B41B770-0x000000018B41B7C4
		private void GetPlaybackState_Injected(out PlaybackState ret); // 0x000000018B41BAA8-0x000000018B41BAEC
		private void SetPlaybackState_Injected(ref PlaybackState playbackState); // 0x000000018B41C030-0x000000018B41C074
		private void SetTrails_Injected(ref Trails trailData); // 0x000000018B41C088-0x000000018B41C0CC
		private void Emit_Injected(ref EmitParams emitParams, int count); // 0x000000018B41B4AC-0x000000018B41B500
		private void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref Particle particle); // 0x000000018B41C1AC-0x000000018B41C1FC
		private void GetManagedJobHandle_Injected(out JobHandle ret); // 0x000000018B41B700-0x000000018B41B744
		private void SetManagedJobHandle_Injected(ref JobHandle handle); // 0x000000018B41BDE8-0x000000018B41BE2C
		private static unsafe void ScheduleManagedJob_Injected(ref JobsUtility.JobScheduleParameters parameters, void* additionalData, out JobHandle ret); // 0x000000018B41BD10-0x000000018B41BD64
	}

	public static class ParticlePhysicsExtensions // TypeDefIndex: 62358
	{
		// Extension methods
		public static int GetSafeCollisionEventSize(this ParticleSystem ps); // 0x000000018B418EC0-0x000000018B418ECC
		public static int GetCollisionEvents(this ParticleSystem ps, GameObject go, List<ParticleCollisionEvent> collisionEvents); // 0x000000018B418EB4-0x000000018B418EC0
	}

	public enum ParticleSystemRenderMode // TypeDefIndex: 62359
	{
		Billboard = 0,
		Stretch = 1,
		HorizontalBillboard = 2,
		VerticalBillboard = 3,
		Mesh = 4,
		None = 5
	}

	public enum ParticleSystemMeshDistribution // TypeDefIndex: 62360
	{
		UniformRandom = 0,
		NonUniformRandom = 1
	}

	public enum ParticleSystemSortMode // TypeDefIndex: 62361
	{
		None = 0,
		Distance = 1,
		OldestInFront = 2,
		YoungestInFront = 3,
		Depth = 4
	}

	public enum ParticleSystemRenderSpace // TypeDefIndex: 62362
	{
		View = 0,
		World = 1,
		Local = 2,
		Facing = 3,
		Velocity = 4
	}

	public enum ParticleSystemCurveMode // TypeDefIndex: 62363
	{
		Constant = 0,
		Curve = 1,
		TwoCurves = 2,
		TwoConstants = 3
	}

	public enum ParticleSystemGradientMode // TypeDefIndex: 62364
	{
		Color = 0,
		Gradient = 1,
		TwoColors = 2,
		TwoGradients = 3,
		RandomColor = 4
	}

	public enum ParticleSystemShapeType // TypeDefIndex: 62365
	{
		Sphere = 0,
		SphereShell = 1,
		Hemisphere = 2,
		HemisphereShell = 3,
		Cone = 4,
		Box = 5,
		Mesh = 6,
		ConeShell = 7,
		ConeVolume = 8,
		ConeVolumeShell = 9,
		Circle = 10,
		CircleEdge = 11,
		SingleSidedEdge = 12,
		MeshRenderer = 13,
		SkinnedMeshRenderer = 14,
		BoxShell = 15,
		BoxEdge = 16,
		Donut = 17,
		Rectangle = 18,
		Sprite = 19,
		SpriteRenderer = 20
	}

	public enum ParticleSystemSimulationSpace // TypeDefIndex: 62366
	{
		Local = 0,
		World = 1,
		Custom = 2
	}

	public enum ParticleSystemStopBehavior // TypeDefIndex: 62367
	{
		StopEmittingAndClear = 0,
		StopEmitting = 1
	}

	public enum ParticleSystemScalingMode // TypeDefIndex: 62368
	{
		Hierarchy = 0,
		Local = 1,
		Shape = 2
	}

	[UsedByNativeCode]
	public enum ParticleSystemVertexStream // TypeDefIndex: 62369
	{
		Position = 0,
		Normal = 1,
		Tangent = 2,
		Color = 3,
		UV = 4,
		UV2 = 5,
		UV3 = 6,
		UV4 = 7,
		AnimBlend = 8,
		AnimFrame = 9,
		Center = 10,
		VertexID = 11,
		SizeX = 12,
		SizeXY = 13,
		SizeXYZ = 14,
		Rotation = 15,
		Rotation3D = 16,
		RotationSpeed = 17,
		RotationSpeed3D = 18,
		Velocity = 19,
		Speed = 20,
		AgePercent = 21,
		InvStartLifetime = 22,
		StableRandomX = 23,
		StableRandomXY = 24,
		StableRandomXYZ = 25,
		StableRandomXYZW = 26,
		VaryingRandomX = 27,
		VaryingRandomXY = 28,
		VaryingRandomXYZ = 29,
		VaryingRandomXYZW = 30,
		Custom1X = 31,
		Custom1XY = 32,
		Custom1XYZ = 33,
		Custom1XYZW = 34,
		Custom2X = 35,
		Custom2XY = 36,
		Custom2XYZ = 37,
		Custom2XYZW = 38,
		NoiseSumX = 39,
		NoiseSumXY = 40,
		NoiseSumXYZ = 41,
		NoiseImpulseX = 42,
		NoiseImpulseXY = 43,
		NoiseImpulseXYZ = 44,
		MeshIndex = 45
	}

	public enum ParticleSystemCustomData // TypeDefIndex: 62370
	{
		Custom1 = 0,
		Custom2 = 1
	}

	public enum ParticleSystemTrailTextureMode // TypeDefIndex: 62371
	{
		Stretch = 0,
		Tile = 1,
		DistributePerSegment = 2,
		RepeatPerSegment = 3
	}

	public enum ParticleSystemForceFieldShape // TypeDefIndex: 62372
	{
		Sphere = 0,
		Hemisphere = 1,
		Cylinder = 2,
		Box = 3
	}

	[Flags]
	[Obsolete("ParticleSystemVertexStreams is deprecated. Please use ParticleSystemVertexStream instead.", false)]
	public enum ParticleSystemVertexStreams // TypeDefIndex: 62373
	{
		None = 0,
		Position = 1,
		Normal = 2,
		Tangent = 4,
		Color = 8,
		UV = 16,
		UV2BlendAndFrame = 32,
		CenterAndVertexID = 64,
		Size = 128,
		Rotation = 256,
		Velocity = 512,
		Lifetime = 1024,
		Custom1 = 2048,
		Custom2 = 4096,
		Random = 8192,
		All = 2147483647
	}

	[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[RequireComponent(typeof(Transform))]
	public sealed class ParticleSystemRenderer : Renderer // TypeDefIndex: 62374
	{
		// Properties
		[NativeName("RenderAlignment")]
		public ParticleSystemRenderSpace alignment { get; set; } // 0x000000018B41A7A8-0x000000018B41A7DC 0x000000018B41AD00-0x000000018B41AD40
		public ParticleSystemRenderMode renderMode { get; set; } // 0x000000018B41AB94-0x000000018B41ABC8 0x000000018B41B1A0-0x000000018B41B1E0
		public ParticleSystemMeshDistribution meshDistribution { get; set; } // 0x000000018B41AA20-0x000000018B41AA54 0x000000018B41AFB4-0x000000018B41AFF4
		public ParticleSystemSortMode sortMode { get; set; } // 0x000000018B41AC30-0x000000018B41AC64 0x000000018B41B268-0x000000018B41B2A8
		public float lengthScale { get; set; } // 0x000000018B41A950-0x000000018B41A984 0x000000018B41AEEC-0x000000018B41AF30
		public float velocityScale { get; set; } // 0x000000018B41ACCC-0x000000018B41AD00 0x000000018B41B32C-0x000000018B41B370
		public float cameraVelocityScale { get; set; } // 0x000000018B41A810-0x000000018B41A844 0x000000018B41AD84-0x000000018B41ADC8
		public float normalDirection { get; set; } // 0x000000018B41AABC-0x000000018B41AAF0 0x000000018B41B07C-0x000000018B41B0C0
		public float shadowBias { get; set; } // 0x000000018B41ABFC-0x000000018B41AC30 0x000000018B41B224-0x000000018B41B268
		public float minParticleSize { get; set; } // 0x000000018B41AA88-0x000000018B41AABC 0x000000018B41B038-0x000000018B41B07C
		public float maxParticleSize { get; set; } // 0x000000018B41A9B8-0x000000018B41A9EC 0x000000018B41AF70-0x000000018B41AFB4
		public Vector3 pivot { get; set; } // 0x000000018B41AB34-0x000000018B41AB60 0x000000018B41B148-0x000000018B41B15C
		public Vector3 flip { get; set; } // 0x000000018B41A8F0-0x000000018B41A91C 0x000000018B41AE94-0x000000018B41AEA8
		public SpriteMaskInteraction maskInteraction { get; set; } // 0x000000018B41A984-0x000000018B41A9B8 0x000000018B41AF30-0x000000018B41AF70
		public Material trailMaterial { get; set; } // 0x000000018B41AC64-0x000000018B41AC98 0x000000018B41B2A8-0x000000018B41B2EC
		internal Material oldTrailMaterial { set; } // 0x000000018B41B0C0-0x000000018B41B104
		public bool enableGPUInstancing { get; set; } // 0x000000018B41A844-0x000000018B41A878 0x000000018B41ADC8-0x000000018B41AE0C
		public bool allowRoll { get; set; } // 0x000000018B41A7DC-0x000000018B41A810 0x000000018B41AD40-0x000000018B41AD84
		public bool freeformStretching { get; set; } // 0x000000018B41A91C-0x000000018B41A950 0x000000018B41AEA8-0x000000018B41AEEC
		public bool rotateWithStretchDirection { get; set; } // 0x000000018B41ABC8-0x000000018B41ABFC 0x000000018B41B1E0-0x000000018B41B224
		public bool enableHGGPUInstancing { get; set; } // 0x000000018B41A878-0x000000018B41A8AC 0x000000018B41AE0C-0x000000018B41AE50
		public bool renderInUI { [NativeName("GetRenderInUI")] get; [NativeName("SetRenderInUI")] set; } // 0x000000018B41AB60-0x000000018B41AB94 0x000000018B41B15C-0x000000018B41B1A0
		public int uiSortingOrder { [NativeName("GetUISortingOrder")] get; [NativeName("SetUISortingOrder")] set; } // 0x000000018B41AC98-0x000000018B41ACCC 0x000000018B41B2EC-0x000000018B41B32C
		public Mesh mesh { [FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMesh", HasExplicitThis = true)] get; [FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMesh", HasExplicitThis = true)] set; } // 0x000000018B41AA54-0x000000018B41AA88 0x000000018B41AFF4-0x000000018B41B038
		public int meshCount { get; } // 0x000000018B41A9EC-0x000000018B41AA20 
		public int activeVertexStreamsCount { get; } // 0x000000018B41A774-0x000000018B41A7A8 
		public bool DisableCutOutAnimation { get; } // 0x000000018B41A740-0x000000018B41A774 
		public int CutOutMode { get; } // 0x000000018B41A70C-0x000000018B41A740 
		public int CutOutDataSize { get; } // 0x000000018B41A6D8-0x000000018B41A70C 
	
		// Constructors
		public ParticleSystemRenderer(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		[Obsolete("EnableVertexStreams is deprecated.Use SetActiveVertexStreams instead.", false)]
		public void EnableVertexStreams(ParticleSystemVertexStreams streams); // 0x000000018B419C8C-0x000000018B419C98
		[Obsolete("DisableVertexStreams is deprecated.Use SetActiveVertexStreams instead.", false)]
		public void DisableVertexStreams(ParticleSystemVertexStreams streams); // 0x000000018B419C80-0x000000018B419C8C
		[Obsolete("AreVertexStreamsEnabled is deprecated.Use GetActiveVertexStreams instead.", false)]
		public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams); // 0x000000018B419B04-0x000000018B419B20
		[Obsolete("GetEnabledVertexStreams is deprecated.Use GetActiveVertexStreams instead.", false)]
		public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams); // 0x000000018B419CDC-0x000000018B419CE8
		[Obsolete("Internal_SetVertexStreams is deprecated.Use SetActiveVertexStreams instead.", false)]
		internal void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled); // 0x000000018B419FC8-0x000000018B41A5AC
		[Obsolete("Internal_GetVertexStreams is deprecated.Use GetActiveVertexStreams instead.", false)]
		internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams); // 0x000000018B419D70-0x000000018B419FC8
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = true)]
		[RequiredByNativeCode]
		public int GetMeshes([NotNull("ArgumentNullException")] out Mesh[] meshes); // 0x000000018B419D2C-0x000000018B419D70
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshes", HasExplicitThis = true)]
		public void SetMeshes([NotNull("ArgumentNullException")] Mesh[] meshes, int size); // 0x000000018B41A664-0x000000018B41A6B8
		public void SetMeshes(Mesh[] meshes); // 0x000000018B41A6B8-0x000000018B41A6D8
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshWeightings", HasExplicitThis = true)]
		public int GetMeshWeightings([NotNull("ArgumentNullException")] out float[] weightings); // 0x000000018B419CE8-0x000000018B419D2C
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshWeightings", HasExplicitThis = true)]
		public void SetMeshWeightings([NotNull("ArgumentNullException")] float[] weightings, int size); // 0x000000018B41A5F0-0x000000018B41A644
		public void SetMeshWeightings(float[] weightings); // 0x000000018B41A644-0x000000018B41A664
		public void BakeMesh(Mesh mesh, bool useTransform = false /* Metadata: 0x02351992 */); // 0x000000018B419B84-0x000000018B419BD0
		public void BakeMesh([NotNull("ArgumentNullException")] Mesh mesh, [NotNull("ArgumentNullException")] Camera camera, bool useTransform = false /* Metadata: 0x02351993 */); // 0x000000018B419B20-0x000000018B419B84
		public void BakeTrailsMesh(Mesh mesh, bool useTransform = false /* Metadata: 0x02351994 */); // 0x000000018B419BD0-0x000000018B419C1C
		public void BakeTrailsMesh([NotNull("ArgumentNullException")] Mesh mesh, [NotNull("ArgumentNullException")] Camera camera, bool useTransform = false /* Metadata: 0x02351995 */); // 0x000000018B419C1C-0x000000018B419C80
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetActiveVertexStreams", HasExplicitThis = true)]
		public void SetActiveVertexStreams([NotNull("ArgumentNullException")] List<ParticleSystemVertexStream> streams); // 0x000000018B41A5AC-0x000000018B41A5F0
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetActiveVertexStreams", HasExplicitThis = true)]
		public void GetActiveVertexStreams([NotNull("ArgumentNullException")] List<ParticleSystemVertexStream> streams); // 0x000000018B419C98-0x000000018B419CDC
		private void get_pivot_Injected(out Vector3 ret); // 0x000000018B41AAF0-0x000000018B41AB34
		private void set_pivot_Injected(ref Vector3 value); // 0x000000018B41B104-0x000000018B41B148
		private void get_flip_Injected(out Vector3 ret); // 0x000000018B41A8AC-0x000000018B41A8F0
		private void set_flip_Injected(ref Vector3 value); // 0x000000018B41AE50-0x000000018B41AE94
	}

	[RequiredByNativeCode(Optional = true)]
	public struct ParticleCollisionEvent // TypeDefIndex: 62375
	{
		// Fields
		internal Vector3 m_Intersection; // 0x00
		internal Vector3 m_Normal; // 0x0C
		internal Vector3 m_Velocity; // 0x18
		internal int m_ColliderInstanceID; // 0x24
	
		// Properties
		public Vector3 intersection { get; } // 0x0000000184DBA810-0x0000000184DBA830 
		public Vector3 normal { get; } // 0x0000000184DBA7F0-0x0000000184DBA810 
		public Vector3 velocity { get; } // 0x0000000184DBAC00-0x0000000184DBAC20 
		public Component colliderComponent { get; } // 0x000000018B418EA8-0x000000018B418EB4 
	
		// Methods
		[FreeFunction(Name = "ParticleSystemScriptBindings::InstanceIDToColliderComponent")]
		private static Component InstanceIDToColliderComponent(int instanceID); // 0x000000018B418E74-0x000000018B418EA8
	}

	internal class ParticleSystemExtensionsImpl // TypeDefIndex: 62376
	{
		// Methods
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetSafeCollisionEventSize")]
		internal static int GetSafeCollisionEventSize([NotNull("ArgumentNullException")] ParticleSystem ps); // 0x000000018B418F20-0x000000018B418F54
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetCollisionEvents")]
		internal static int GetCollisionEvents([NotNull("ArgumentNullException")] ParticleSystem ps, [NotNull("ArgumentNullException")] GameObject go, [NotNull("ArgumentNullException")] List<ParticleCollisionEvent> collisionEvents); // 0x000000018B418ECC-0x000000018B418F20
	}

	[NativeHeader("Modules/ParticleSystem/ParticleSystemForceFieldManager.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystemForceField.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[RequireComponent(typeof(Transform))]
	public class ParticleSystemForceField : UnityEngine.Behaviour // TypeDefIndex: 62377
	{
		// Properties
		[NativeName("ForceShape")]
		public ParticleSystemForceFieldShape shape { get; set; } // 0x000000018B4193EC-0x000000018B419420 0x000000018B41998C-0x000000018B4199CC
		public float startRange { get; set; } // 0x000000018B419420-0x000000018B419454 0x000000018B4199CC-0x000000018B419A10
		public float endRange { get; set; } // 0x000000018B419124-0x000000018B419158 0x000000018B4196D0-0x000000018B419714
		public float length { get; set; } // 0x000000018B419200-0x000000018B419234 0x000000018B4197B0-0x000000018B4197F4
		public float gravityFocus { get; set; } // 0x000000018B419158-0x000000018B41918C 0x000000018B419714-0x000000018B419758
		public Vector2 rotationRandomness { get; set; } // 0x000000018B419354-0x000000018B419378 0x000000018B419918-0x000000018B419934
		public bool multiplyDragByParticleSize { get; set; } // 0x000000018B419234-0x000000018B419268 0x000000018B4197F4-0x000000018B419838
		public bool multiplyDragByParticleVelocity { get; set; } // 0x000000018B419268-0x000000018B41929C 0x000000018B419838-0x000000018B41987C
		public Texture3D vectorField { get; set; } // 0x000000018B41953C-0x000000018B419570 0x000000018B419AC0-0x000000018B419B04
		public ParticleSystem.MinMaxCurve directionX { get; set; } // 0x000000018B418F98-0x000000018B418FC8 0x000000018B4195B4-0x000000018B4195C8
		public ParticleSystem.MinMaxCurve directionY { get; set; } // 0x000000018B41900C-0x000000018B41903C 0x000000018B41960C-0x000000018B419620
		public ParticleSystem.MinMaxCurve directionZ { get; set; } // 0x000000018B419080-0x000000018B4190B0 0x000000018B419664-0x000000018B419678
		public ParticleSystem.MinMaxCurve gravity { get; set; } // 0x000000018B4191D0-0x000000018B419200 0x000000018B41979C-0x000000018B4197B0
		public ParticleSystem.MinMaxCurve rotationSpeed { get; set; } // 0x000000018B4193BC-0x000000018B4193EC 0x000000018B419978-0x000000018B41998C
		public ParticleSystem.MinMaxCurve rotationAttraction { get; set; } // 0x000000018B4192E0-0x000000018B419310 0x000000018B4198C0-0x000000018B4198D4
		public ParticleSystem.MinMaxCurve drag { get; set; } // 0x000000018B4190F4-0x000000018B419124 0x000000018B4196BC-0x000000018B4196D0
		public ParticleSystem.MinMaxCurve vectorFieldSpeed { get; set; } // 0x000000018B41950C-0x000000018B41953C 0x000000018B419AAC-0x000000018B419AC0
		public ParticleSystem.MinMaxCurve vectorFieldAttraction { get; set; } // 0x000000018B419498-0x000000018B4194C8 0x000000018B419A54-0x000000018B419A68
	
		// Constructors
		public ParticleSystemForceField(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void get_rotationRandomness_Injected(out Vector2 ret); // 0x000000018B419310-0x000000018B419354
		private void set_rotationRandomness_Injected(ref Vector2 value); // 0x000000018B4198D4-0x000000018B419918
		private void get_directionX_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018B418F54-0x000000018B418F98
		private void set_directionX_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018B419570-0x000000018B4195B4
		private void get_directionY_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018B418FC8-0x000000018B41900C
		private void set_directionY_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018B4195C8-0x000000018B41960C
		private void get_directionZ_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018B41903C-0x000000018B419080
		private void set_directionZ_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018B419620-0x000000018B419664
		private void get_gravity_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018B41918C-0x000000018B4191D0
		private void set_gravity_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018B419758-0x000000018B41979C
		private void get_rotationSpeed_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018B419378-0x000000018B4193BC
		private void set_rotationSpeed_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018B419934-0x000000018B419978
		private void get_rotationAttraction_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018B41929C-0x000000018B4192E0
		private void set_rotationAttraction_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018B41987C-0x000000018B4198C0
		private void get_drag_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018B4190B0-0x000000018B4190F4
		private void set_drag_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018B419678-0x000000018B4196BC
		private void get_vectorFieldSpeed_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018B4194C8-0x000000018B41950C
		private void set_vectorFieldSpeed_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018B419A68-0x000000018B419AAC
		private void get_vectorFieldAttraction_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018B419454-0x000000018B419498
		private void set_vectorFieldAttraction_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018B419A10-0x000000018B419A54
	}

	[NativeHeader("Modules/ParticleSystem/HGParticle/HGParticleMeshInstanceRenderer.h")]
	[RequireComponent(typeof(ParticleSystemRenderer))]
	[RequiredByNativeCode]
	internal sealed class HGParticleMeshInstanceRenderer : Renderer // TypeDefIndex: 62378
	{
	}
}

namespace UnityEngine.ParticleSystemJobs
{
	internal struct NativeParticleData // TypeDefIndex: 62381
	{
		// Fields
		internal int count; // 0x00
		internal Array3 positions; // 0x08
		internal Array3 velocities; // 0x20
		internal Array3 axisOfRotations; // 0x38
		internal Array3 rotations; // 0x50
		internal Array3 rotationalSpeeds; // 0x68
		internal Array3 sizes; // 0x80
		internal unsafe void* startColors; // 0x98
		internal unsafe void* aliveTimePercent; // 0xA0
		internal unsafe void* inverseStartLifetimes; // 0xA8
		internal unsafe void* randomSeeds; // 0xB0
		internal Array4 customData1; // 0xB8
		internal Array4 customData2; // 0xD8
		internal unsafe void* meshIndices; // 0xF8
	
		// Nested types
		internal struct Array3 // TypeDefIndex: 62379
		{
			// Fields
			internal unsafe float* x; // 0x00
			internal unsafe float* y; // 0x08
			internal unsafe float* z; // 0x10
		}
	
		internal struct Array4 // TypeDefIndex: 62380
		{
			// Fields
			internal unsafe float* x; // 0x00
			internal unsafe float* y; // 0x08
			internal unsafe float* z; // 0x10
			internal unsafe float* w; // 0x18
		}
	}
}
