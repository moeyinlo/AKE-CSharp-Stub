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

// Image 73: UnityEngine.ParticleSystemModule.dll - Assembly: UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58727-58791
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
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
	[RequireComponent(typeof(Transform))]
	[UsedByNativeCode]
	public sealed class ParticleSystem : Component // TypeDefIndex: 58767
	{
		// Properties
		[Obsolete("startDelay property is deprecated. Use main.startDelay or main.startDelayMultiplier instead.", false)]
		public float startDelay { get => default; set {} } // 0x0000000189E18FE0-0x0000000189E19010 0x0000000189E194A0-0x0000000189E194D0
		[Obsolete("loop property is deprecated. Use main.loop instead.", false)]
		public bool loop { get => default; set {} } // 0x0000000189E18DBC-0x0000000189E18DEC 0x0000000189E1929C-0x0000000189E192D4
		[Obsolete("playOnAwake property is deprecated. Use main.playOnAwake instead.", false)]
		public bool playOnAwake { get => default; set {} } // 0x0000000189E18E50-0x0000000189E18E80 0x0000000189E1930C-0x0000000189E19344
		[Obsolete("duration property is deprecated. Use main.duration instead.", false)]
		public float duration { get => default; } // 0x0000000189E18C2C-0x0000000189E18C5C 
		[Obsolete("playbackSpeed property is deprecated. Use main.simulationSpeed instead.", false)]
		public float playbackSpeed { get => default; set {} } // 0x0000000189E18E80-0x0000000189E18EB0 0x0000000189E19344-0x0000000189E19374
		[Obsolete("enableEmission property is deprecated. Use emission.enabled instead.", false)]
		public bool enableEmission { get => default; set {} } // 0x0000000189E18C8C-0x0000000189E18CBC 0x0000000189E19234-0x0000000189E1926C
		[Obsolete("emissionRate property is deprecated. Use emission.rateOverTime, emission.rateOverDistance, emission.rateOverTimeMultiplier or emission.rateOverDistanceMultiplier instead.", false)]
		public float emissionRate { get => default; set {} } // 0x0000000189E18C5C-0x0000000189E18C8C 0x0000000189E191D8-0x0000000189E19234
		[Obsolete("startSpeed property is deprecated. Use main.startSpeed or main.startSpeedMultiplier instead.", false)]
		public float startSpeed { get => default; set {} } // 0x0000000189E19140-0x0000000189E19170 0x0000000189E195B0-0x0000000189E195E0
		[Obsolete("startSize property is deprecated. Use main.startSize or main.startSizeMultiplier instead.", false)]
		public float startSize { get => default; set {} } // 0x0000000189E19110-0x0000000189E19140 0x0000000189E19580-0x0000000189E195B0
		[Obsolete("startColor property is deprecated. Use main.startColor instead.", false)]
		public UnityEngine.Color startColor { get => default; set {} } // 0x0000000189E18F78-0x0000000189E18FE0 0x0000000189E19424-0x0000000189E194A0
		[Obsolete("startRotation property is deprecated. Use main.startRotation or main.startRotationMultiplier instead.", false)]
		public float startRotation { get => default; set {} } // 0x0000000189E190E0-0x0000000189E19110 0x0000000189E19550-0x0000000189E19580
		[Obsolete("startRotation3D property is deprecated. Use main.startRotationX, main.startRotationY and main.startRotationZ instead. (Or main.startRotationXMultiplier, main.startRotationYMultiplier and main.startRotationZMultiplier).", false)]
		public Vector3 startRotation3D { get => default; set {} } // 0x0000000189E19040-0x0000000189E190E0 0x0000000189E19500-0x0000000189E19550
		[Obsolete("startLifetime property is deprecated. Use main.startLifetime or main.startLifetimeMultiplier instead.", false)]
		public float startLifetime { get => default; set {} } // 0x0000000189E19010-0x0000000189E19040 0x0000000189E194D0-0x0000000189E19500
		[Obsolete("gravityModifier property is deprecated. Use main.gravityModifier or main.gravityModifierMultiplier instead.", false)]
		public float gravityModifier { get => default; set {} } // 0x0000000189E18CBC-0x0000000189E18CEC 0x0000000189E1926C-0x0000000189E1929C
		[Obsolete("maxParticles property is deprecated. Use main.maxParticles instead.", false)]
		public int maxParticles { get => default; set {} } // 0x0000000189E18DEC-0x0000000189E18E1C 0x0000000189E192D4-0x0000000189E1930C
		[Obsolete("simulationSpace property is deprecated. Use main.simulationSpace instead.", false)]
		public ParticleSystemSimulationSpace simulationSpace { get => default; set {} } // 0x0000000189E18F48-0x0000000189E18F78 0x0000000189E193EC-0x0000000189E19424
		[Obsolete("scalingMode property is deprecated. Use main.scalingMode instead.", false)]
		public ParticleSystemScalingMode scalingMode { get => default; set {} } // 0x0000000189E18F18-0x0000000189E18F48 0x0000000189E193B4-0x0000000189E193EC
		[Obsolete("automaticCullingEnabled property is deprecated. Use proceduralSimulationSupported instead (UnityUpgradable) -> proceduralSimulationSupported", true)]
		public bool automaticCullingEnabled { get => default; } // 0x0000000189E18C20-0x0000000189E18C2C 
		public bool isPlaying { [NativeName("SyncJobs(false)->IsPlaying")] get => default; } // 0x0000000189E18D54-0x0000000189E18D88 
		public bool isEmitting { [NativeName("SyncJobs(false)->IsEmitting")] get => default; } // 0x0000000189E18CEC-0x0000000189E18D20 
		public bool isStopped { [NativeName("SyncJobs(false)->IsStopped")] get => default; } // 0x0000000189E18D88-0x0000000189E18DBC 
		public bool isPaused { [NativeName("SyncJobs(false)->IsPaused")] get => default; } // 0x0000000189E18D20-0x0000000189E18D54 
		public int particleCount { [NativeName("SyncJobs(false)->GetParticleCount")] get => default; } // 0x0000000189E18E1C-0x0000000189E18E50 
		public float time { [NativeName("SyncJobs(false)->GetSecPosition")] get => default; [NativeName("SyncJobs(false)->SetSecPosition")] set {} } // 0x0000000189E19170-0x0000000189E191A4 0x0000000189E195E0-0x0000000189E19624
		public uint randomSeed { [NativeName("GetRandomSeed")] get => default; [NativeName("SyncJobs(false)->SetRandomSeed")] set {} } // 0x0000000189E18EE4-0x0000000189E18F18 0x0000000189E19374-0x0000000189E193B4
		public bool useAutoRandomSeed { [NativeName("GetAutoRandomSeed")] get => default; [NativeName("SyncJobs(false)->SetAutoRandomSeed")] set {} } // 0x0000000189E191A4-0x0000000189E191D8 0x0000000189E19624-0x0000000189E19668
		public bool proceduralSimulationSupported { get => default; } // 0x0000000189E18EB0-0x0000000189E18EE4 
		public MainModule main { get => default; } // 0x0000000182712100-0x0000000182712120 
		public EmissionModule emission { get => default; } // 0x0000000182712100-0x0000000182712120 
		public ShapeModule shape { get => default; } // 0x0000000182712100-0x0000000182712120 
		public VelocityOverLifetimeModule velocityOverLifetime { get => default; } // 0x0000000182712100-0x0000000182712120 
		public LimitVelocityOverLifetimeModule limitVelocityOverLifetime { get => default; } // 0x0000000182712100-0x0000000182712120 
		public InheritVelocityModule inheritVelocity { get => default; } // 0x0000000182712100-0x0000000182712120 
		public LifetimeByEmitterSpeedModule lifetimeByEmitterSpeed { get => default; } // 0x0000000182712100-0x0000000182712120 
		public ForceOverLifetimeModule forceOverLifetime { get => default; } // 0x0000000182712100-0x0000000182712120 
		public ColorOverLifetimeModule colorOverLifetime { get => default; } // 0x0000000182712100-0x0000000182712120 
		public ColorBySpeedModule colorBySpeed { get => default; } // 0x0000000182712100-0x0000000182712120 
		public SizeOverLifetimeModule sizeOverLifetime { get => default; } // 0x0000000182712100-0x0000000182712120 
		public SizeBySpeedModule sizeBySpeed { get => default; } // 0x0000000182712100-0x0000000182712120 
		public RotationOverLifetimeModule rotationOverLifetime { get => default; } // 0x0000000182712100-0x0000000182712120 
		public RotationBySpeedModule rotationBySpeed { get => default; } // 0x0000000182712100-0x0000000182712120 
		public ExternalForcesModule externalForces { get => default; } // 0x0000000182712100-0x0000000182712120 
		public NoiseModule noise { get => default; } // 0x0000000182712100-0x0000000182712120 
		public CollisionModule collision { get => default; } // 0x0000000182712100-0x0000000182712120 
		public TriggerModule trigger { get => default; } // 0x0000000182712100-0x0000000182712120 
		public SubEmittersModule subEmitters { get => default; } // 0x0000000182712100-0x0000000182712120 
		public TextureSheetAnimationModule textureSheetAnimation { get => default; } // 0x0000000182712100-0x0000000182712120 
		public LightsModule lights { get => default; } // 0x0000000182712100-0x0000000182712120 
		public TrailModule trails { get => default; } // 0x0000000182712100-0x0000000182712120 
		public CustomDataModule customData { get => default; } // 0x0000000182712100-0x0000000182712120 
	
		// Nested types
		public struct MainModule // TypeDefIndex: 58728
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public float duration { get => default; [NativeThrows] set {} } // 0x0000000184274AF0-0x0000000184274AF8 0x0000000184274AF8-0x0000000184274B00
			public bool loop { get => default; [NativeThrows] set {} } // 0x0000000189E14FA4-0x0000000189E14FAC 0x0000000189E1543C-0x0000000189E15444
			public float startDelayMultiplier { get => default; [NativeThrows] set {} } // 0x0000000189E15118-0x0000000189E15120 0x0000000189E15574-0x0000000189E1557C
			public MinMaxCurve startLifetime { get => default; [NativeThrows] set {} } // 0x0000000189E151A0-0x0000000189E151D0 0x0000000189E1560C-0x0000000189E15620
			public float startLifetimeMultiplier { get => default; [NativeThrows] set {} } // 0x0000000189E15154-0x0000000189E1515C 0x0000000189E155C0-0x0000000189E155C8
			public MinMaxCurve startSpeed { get => default; } // 0x0000000189E1537C-0x0000000189E153AC 
			public float startSpeedMultiplier { get => default; [NativeThrows] set {} } // 0x0000000189E15330-0x0000000189E15338 0x0000000189E157E0-0x0000000189E157E8
			[NativeName("StartSizeXMultiplier")]
			public float startSizeMultiplier { get => default; [NativeThrows] set {} } // 0x0000000189E152F4-0x0000000189E152FC 0x0000000189E15794-0x0000000189E1579C
			[NativeName("StartRotationZMultiplier")]
			public float startRotationMultiplier { get => default; [NativeThrows] set {} } // 0x0000000189E15204-0x0000000189E1520C 0x0000000189E15664-0x0000000189E1566C
			public float startRotationXMultiplier { get => default; [NativeThrows] set {} } // 0x0000000189E15240-0x0000000189E15248 0x0000000189E156B0-0x0000000189E156B8
			public float startRotationYMultiplier { get => default; [NativeThrows] set {} } // 0x0000000189E1527C-0x0000000189E15284 0x0000000189E156FC-0x0000000189E15704
			public float startRotationZMultiplier { get => default; [NativeThrows] set {} } // 0x0000000189E152B8-0x0000000189E152C0 0x0000000189E15748-0x0000000189E15750
			public MinMaxGradient startColor { get => default; [NativeThrows] set {} } // 0x0000000189E150AC-0x0000000189E150E4 0x0000000189E1551C-0x0000000189E15530
			public float gravityModifierMultiplier { get => default; [NativeThrows] set {} } // 0x0000000189E14F68-0x0000000189E14F70 0x0000000189E153F0-0x0000000189E153F8
			public ParticleSystemSimulationSpace simulationSpace { get => default; [NativeThrows] set {} } // 0x0000000189E15058-0x0000000189E15060 0x0000000189E154D0-0x0000000189E154D8
			public float simulationSpeed { get => default; [NativeThrows] set {} } // 0x0000000189E15060-0x0000000189E15068 0x0000000184271598-0x00000001842715A0
			public ParticleSystemScalingMode scalingMode { get => default; [NativeThrows] set {} } // 0x0000000189E1501C-0x0000000189E15024 0x0000000184274AB8-0x0000000184274AC0
			public bool playOnAwake { get => default; [NativeThrows] set {} } // 0x0000000189E14FE0-0x0000000189E14FE8 0x0000000189E15488-0x0000000189E15490
			public int maxParticles { get => default; [NativeThrows] set {} } // 0x0000000184274AB0-0x0000000184274AB8 0x0000000184274AC0-0x0000000184274AC8
	
			// Constructors
			internal MainModule(ParticleSystem particleSystem) : this() {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
	
			// Methods
			private static float get_duration_Injected(ref MainModule _unity_self) => default; // 0x0000000183CFA570-0x0000000183CFA5B0
			private static void set_duration_Injected(ref MainModule _unity_self, float value) {} // 0x0000000183CDDB50-0x0000000183CDDBA0
			private static bool get_loop_Injected(ref MainModule _unity_self) => default; // 0x0000000189E14F70-0x0000000189E14FA4
			private static void set_loop_Injected(ref MainModule _unity_self, bool value) {} // 0x0000000189E153F8-0x0000000189E1543C
			private static float get_startDelayMultiplier_Injected(ref MainModule _unity_self) => default; // 0x0000000189E150E4-0x0000000189E15118
			private static void set_startDelayMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x0000000189E15530-0x0000000189E15574
			private static void get_startLifetime_Injected(ref MainModule _unity_self, out MinMaxCurve ret) {
				ret = default;
			} // 0x0000000189E1515C-0x0000000189E151A0
			private static void set_startLifetime_Injected(ref MainModule _unity_self, ref MinMaxCurve value) {} // 0x0000000189E155C8-0x0000000189E1560C
			private static float get_startLifetimeMultiplier_Injected(ref MainModule _unity_self) => default; // 0x0000000189E15120-0x0000000189E15154
			private static void set_startLifetimeMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x0000000189E1557C-0x0000000189E155C0
			private static void get_startSpeed_Injected(ref MainModule _unity_self, out MinMaxCurve ret) {
				ret = default;
			} // 0x0000000189E15338-0x0000000189E1537C
			private static float get_startSpeedMultiplier_Injected(ref MainModule _unity_self) => default; // 0x0000000189E152FC-0x0000000189E15330
			private static void set_startSpeedMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x0000000189E1579C-0x0000000189E157E0
			private static float get_startSizeMultiplier_Injected(ref MainModule _unity_self) => default; // 0x0000000189E152C0-0x0000000189E152F4
			private static void set_startSizeMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x0000000189E15750-0x0000000189E15794
			private static float get_startRotationMultiplier_Injected(ref MainModule _unity_self) => default; // 0x0000000189E151D0-0x0000000189E15204
			private static void set_startRotationMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x0000000189E15620-0x0000000189E15664
			private static float get_startRotationXMultiplier_Injected(ref MainModule _unity_self) => default; // 0x0000000189E1520C-0x0000000189E15240
			private static void set_startRotationXMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x0000000189E1566C-0x0000000189E156B0
			private static float get_startRotationYMultiplier_Injected(ref MainModule _unity_self) => default; // 0x0000000189E15248-0x0000000189E1527C
			private static void set_startRotationYMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x0000000189E156B8-0x0000000189E156FC
			private static float get_startRotationZMultiplier_Injected(ref MainModule _unity_self) => default; // 0x0000000189E15284-0x0000000189E152B8
			private static void set_startRotationZMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x0000000189E15704-0x0000000189E15748
			private static void get_startColor_Injected(ref MainModule _unity_self, out MinMaxGradient ret) {
				ret = default;
			} // 0x0000000189E15068-0x0000000189E150AC
			private static void set_startColor_Injected(ref MainModule _unity_self, ref MinMaxGradient value) {} // 0x0000000189E154D8-0x0000000189E1551C
			private static float get_gravityModifierMultiplier_Injected(ref MainModule _unity_self) => default; // 0x0000000189E14F34-0x0000000189E14F68
			private static void set_gravityModifierMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x0000000189E153AC-0x0000000189E153F0
			private static ParticleSystemSimulationSpace get_simulationSpace_Injected(ref MainModule _unity_self) => default; // 0x0000000189E15024-0x0000000189E15058
			private static void set_simulationSpace_Injected(ref MainModule _unity_self, ParticleSystemSimulationSpace value) {} // 0x0000000189E15490-0x0000000189E154D0
			private static float get_simulationSpeed_Injected(ref MainModule _unity_self) => default; // 0x0000000183288220-0x0000000183288260
			private static void set_simulationSpeed_Injected(ref MainModule _unity_self, float value) {} // 0x0000000183294C20-0x0000000183294C70
			private static ParticleSystemScalingMode get_scalingMode_Injected(ref MainModule _unity_self) => default; // 0x0000000189E14FE8-0x0000000189E1501C
			private static void set_scalingMode_Injected(ref MainModule _unity_self, ParticleSystemScalingMode value) {} // 0x000000018304C6D0-0x000000018304C720
			private static bool get_playOnAwake_Injected(ref MainModule _unity_self) => default; // 0x0000000189E14FAC-0x0000000189E14FE0
			private static void set_playOnAwake_Injected(ref MainModule _unity_self, bool value) {} // 0x0000000189E15444-0x0000000189E15488
			private static int get_maxParticles_Injected(ref MainModule _unity_self) => default; // 0x000000018304C640-0x000000018304C680
			private static void set_maxParticles_Injected(ref MainModule _unity_self, int value) {} // 0x000000018304C680-0x000000018304C6D0
		}
	
		public struct EmissionModule // TypeDefIndex: 58729
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public bool enabled { get => default; [NativeThrows] set {} } // 0x0000000189E14EA4-0x0000000189E14EAC 0x0000000189E14F2C-0x0000000189E14F34
			public MinMaxCurve rateOverTime { get => default; [NativeThrows] set {} } // 0x000000018304BFF0-0x000000018304C050 0x0000000184274AC8-0x0000000184274ADC
			public float rateOverTimeMultiplier { get => default; } // 0x0000000189E14EE0-0x0000000189E14EE8 
	
			// Constructors
			internal EmissionModule(ParticleSystem particleSystem) : this() {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
	
			// Methods
			private static bool get_enabled_Injected(ref EmissionModule _unity_self) => default; // 0x0000000189E14E70-0x0000000189E14EA4
			private static void set_enabled_Injected(ref EmissionModule _unity_self, bool value) {} // 0x0000000189E14EE8-0x0000000189E14F2C
			private static void get_rateOverTime_Injected(ref EmissionModule _unity_self, out MinMaxCurve ret) {
				ret = default;
			} // 0x000000018304C050-0x000000018304C0A0
			private static void set_rateOverTime_Injected(ref EmissionModule _unity_self, ref MinMaxCurve value) {} // 0x000000018304C770-0x000000018304C7C0
			private static float get_rateOverTimeMultiplier_Injected(ref EmissionModule _unity_self) => default; // 0x0000000189E14EAC-0x0000000189E14EE0
		}
	
		public struct ShapeModule // TypeDefIndex: 58730
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public bool enabled { [NativeThrows] set {} } // 0x0000000189E1974C-0x0000000189E19754
			public ParticleSystemShapeType shapeType { [NativeThrows] set {} } // 0x0000000189E19878-0x0000000189E19880
			public float radius { [NativeThrows] set {} } // 0x0000000189E19830-0x0000000189E19838
			public Mesh mesh { [NativeThrows] set {} } // 0x0000000189E197E4-0x0000000189E197EC
			public MeshRenderer meshRenderer { [NativeThrows] set {} } // 0x0000000189E19798-0x0000000189E197A0
			public SkinnedMeshRenderer skinnedMeshRenderer { [NativeThrows] set {} } // 0x0000000189E198C4-0x0000000189E198CC
			public float textureClipThreshold { [NativeThrows] set {} } // 0x0000000189E1995C-0x0000000189E19964
			public float textureClipThresholdUpper { [NativeThrows] set {} } // 0x0000000189E19910-0x0000000189E19918
	
			// Constructors
			internal ShapeModule(ParticleSystem particleSystem) : this() {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
	
			// Methods
			private static void set_enabled_Injected(ref ShapeModule _unity_self, bool value) {} // 0x0000000189E19708-0x0000000189E1974C
			private static void set_shapeType_Injected(ref ShapeModule _unity_self, ParticleSystemShapeType value) {} // 0x0000000189E19838-0x0000000189E19878
			private static void set_radius_Injected(ref ShapeModule _unity_self, float value) {} // 0x0000000189E197EC-0x0000000189E19830
			private static void set_mesh_Injected(ref ShapeModule _unity_self, Mesh value) {} // 0x0000000189E197A0-0x0000000189E197E4
			private static void set_meshRenderer_Injected(ref ShapeModule _unity_self, MeshRenderer value) {} // 0x0000000189E19754-0x0000000189E19798
			private static void set_skinnedMeshRenderer_Injected(ref ShapeModule _unity_self, SkinnedMeshRenderer value) {} // 0x0000000189E19880-0x0000000189E198C4
			private static void set_textureClipThreshold_Injected(ref ShapeModule _unity_self, float value) {} // 0x0000000189E19918-0x0000000189E1995C
			private static void set_textureClipThresholdUpper_Injected(ref ShapeModule _unity_self, float value) {} // 0x0000000189E198CC-0x0000000189E19910
		}
	
		public struct CollisionModule // TypeDefIndex: 58731
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public bool enabled { get => default; } // 0x0000000189E14E68-0x0000000189E14E70 
	
			// Constructors
			internal CollisionModule(ParticleSystem particleSystem) : this() {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
	
			// Methods
			private static bool get_enabled_Injected(ref CollisionModule _unity_self) => default; // 0x0000000189E14E34-0x0000000189E14E68
		}
	
		public struct TriggerModule // TypeDefIndex: 58732
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal TriggerModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct SubEmittersModule // TypeDefIndex: 58733
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public int subEmittersCount { get => default; } // 0x0000000189E199E0-0x0000000189E199E8 
	
			// Constructors
			internal SubEmittersModule(ParticleSystem particleSystem) : this() {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
	
			// Methods
			[NativeThrows]
			public ParticleSystem GetSubEmitterSystem(int index) => default; // 0x0000000189E199A4-0x0000000189E199AC
			private static int get_subEmittersCount_Injected(ref SubEmittersModule _unity_self) => default; // 0x0000000189E199AC-0x0000000189E199E0
			private static ParticleSystem GetSubEmitterSystem_Injected(ref SubEmittersModule _unity_self, int index) => default; // 0x0000000189E19964-0x0000000189E199A4
		}
	
		public struct TextureSheetAnimationModule // TypeDefIndex: 58734
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal TextureSheetAnimationModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		[RequiredByNativeCode("particleSystemParticle", Optional = true)]
		public struct Particle // TypeDefIndex: 58735
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
			public float lifetime { set {} } // 0x0000000183D5B680-0x0000000183D5B690
			public Vector3 position { set {} } // 0x0000000183D56570-0x0000000183D56580
			public Vector3 velocity { set {} } // 0x0000000183D56580-0x0000000183D56590
			public float remainingLifetime { set {} } // 0x0000000183D5B680-0x0000000183D5B690
			public float startLifetime { set {} } // 0x0000000183D5BD20-0x0000000183D5BD30
			public Color32 startColor { set {} } // 0x0000000183D4F5A0-0x0000000183D4F5B0
			public uint randomSeed { set {} } // 0x0000000183D50B40-0x0000000183D50B50
			public float startSize { set {} } // 0x0000000183D87F30-0x0000000183D87F50
			public Vector3 rotation3D { set {} } // 0x0000000189E196B8-0x0000000189E19708
			public Vector3 angularVelocity3D { set {} } // 0x0000000189E19668-0x0000000189E196B8
		}
	
		[Serializable]
		[NativeType(CodegenOptions.Custom, "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
		public struct MinMaxCurve // TypeDefIndex: 58736
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
			public ParticleSystemCurveMode mode { get => default; } // 0x0000000183D85860-0x0000000183D85870 
			public AnimationCurve curveMax { get => default; } // 0x0000000183D66B80-0x0000000183D66B90 
			public AnimationCurve curveMin { get => default; } // 0x0000000183D85A90-0x0000000183D85AA0 
			public float constantMax { get => default; } // 0x0000000183D87EB0-0x0000000183D87EC0 
			public float constantMin { get => default; } // 0x0000000183D85C60-0x0000000183D85C70 
			public float constant { get => default; set {} } // 0x0000000183D87EB0-0x0000000183D87EC0 0x0000000183D4F120-0x0000000183D4F130
			public AnimationCurve curve { get => default; } // 0x0000000183D66B80-0x0000000183D66B90 
	
			// Constructors
			public MinMaxCurve(float constant) : this() {
				m_Mode = default;
				m_CurveMultiplier = default;
				m_CurveMin = default;
				m_CurveMax = default;
				m_ConstantMin = default;
				m_ConstantMax = default;
			} // 0x000000018304C110-0x000000018304C150
	
			// Methods
			public static implicit operator MinMaxCurve(float constant) => default; // 0x000000018304C0A0-0x000000018304C110
		}
	
		[Serializable]
		[NativeType(CodegenOptions.Custom, "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
		public struct MinMaxGradient // TypeDefIndex: 58737
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
			public UnityEngine.Color colorMax { set {} } // 0x0000000183D59E30-0x0000000183D59E40
			public UnityEngine.Color colorMin { set {} } // 0x0000000183D51D90-0x0000000183D51DA0
			public UnityEngine.Color color { get => default; set {} } // 0x0000000183D87CE0-0x0000000183D87CF0 0x0000000183D59E30-0x0000000183D59E40
	
			// Constructors
			public MinMaxGradient(UnityEngine.Color color) : this() {
				m_Mode = default;
				m_GradientMin = default;
				m_GradientMax = default;
				m_ColorMin = default;
				m_ColorMax = default;
			} // 0x0000000189E157E8-0x0000000189E15838
	
			// Methods
			public static implicit operator MinMaxGradient(UnityEngine.Color color) => default; // 0x0000000189E15838-0x0000000189E158B4
		}
	
		public struct EmitParams // TypeDefIndex: 58738
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
	
		public struct PlaybackState // TypeDefIndex: 58749
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
			internal struct Seed // TypeDefIndex: 58739
			{
				// Fields
				public uint x; // 0x00
				public uint y; // 0x04
				public uint z; // 0x08
				public uint w; // 0x0C
			}
	
			internal struct Seed4 // TypeDefIndex: 58740
			{
				// Fields
				public Seed x; // 0x00
				public Seed y; // 0x10
				public Seed z; // 0x20
				public Seed w; // 0x30
			}
	
			internal struct Emission // TypeDefIndex: 58741
			{
				// Fields
				public float m_ParticleSpacing; // 0x00
				public float m_ToEmitAccumulator; // 0x04
				public Seed m_Random; // 0x08
			}
	
			internal struct Initial // TypeDefIndex: 58742
			{
				// Fields
				public Seed4 m_Random; // 0x00
			}
	
			internal struct Shape // TypeDefIndex: 58743
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
	
			internal struct Force // TypeDefIndex: 58744
			{
				// Fields
				public Seed4 m_Random; // 0x00
			}
	
			internal struct Collision // TypeDefIndex: 58745
			{
				// Fields
				public Seed4 m_Random; // 0x00
			}
	
			internal struct Noise // TypeDefIndex: 58746
			{
				// Fields
				public float m_ScrollOffset; // 0x00
			}
	
			internal struct Lights // TypeDefIndex: 58747
			{
				// Fields
				public Seed m_Random; // 0x00
				public float m_ParticleEmissionCounter; // 0x10
			}
	
			internal struct Trail // TypeDefIndex: 58748
			{
				// Fields
				public float m_Timer; // 0x00
			}
		}
	
		[NativeType(CodegenOptions.Custom, "MonoParticleTrails")]
		public struct Trails // TypeDefIndex: 58750
		{
			// Fields
			internal List<Vector4> positions; // 0x00
			internal List<int> frontPositions; // 0x08
			internal List<int> backPositions; // 0x10
			internal List<int> positionCounts; // 0x18
			internal int maxTrailCount; // 0x20
			internal int maxPositionsPerTrailCount; // 0x24
	
			// Methods
			internal void Allocate() {} // 0x0000000189E199E8-0x0000000189E19B24
		}
	
		public struct VelocityOverLifetimeModule // TypeDefIndex: 58751
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal VelocityOverLifetimeModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct LimitVelocityOverLifetimeModule // TypeDefIndex: 58752
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal LimitVelocityOverLifetimeModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct InheritVelocityModule // TypeDefIndex: 58753
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal InheritVelocityModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct LifetimeByEmitterSpeedModule // TypeDefIndex: 58754
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal LifetimeByEmitterSpeedModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct ForceOverLifetimeModule // TypeDefIndex: 58755
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ForceOverLifetimeModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct ColorOverLifetimeModule // TypeDefIndex: 58756
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ColorOverLifetimeModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct ColorBySpeedModule // TypeDefIndex: 58757
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ColorBySpeedModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct SizeOverLifetimeModule // TypeDefIndex: 58758
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal SizeOverLifetimeModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct SizeBySpeedModule // TypeDefIndex: 58759
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal SizeBySpeedModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct RotationOverLifetimeModule // TypeDefIndex: 58760
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal RotationOverLifetimeModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct RotationBySpeedModule // TypeDefIndex: 58761
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal RotationBySpeedModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct ExternalForcesModule // TypeDefIndex: 58762
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ExternalForcesModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct NoiseModule // TypeDefIndex: 58763
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal NoiseModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct LightsModule // TypeDefIndex: 58764
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal LightsModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct TrailModule // TypeDefIndex: 58765
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal TrailModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		public struct CustomDataModule // TypeDefIndex: 58766
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal CustomDataModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001842715A0-0x00000001842715A8
		}
	
		// Constructors
		public ParticleSystem() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
		public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) {} // 0x0000000189E17E88-0x0000000189E17F90
		[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
		public void Emit(Particle particle) {} // 0x0000000189E17F90-0x0000000189E17FA4
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize", HasExplicitThis = true)]
		internal float GetParticleCurrentSize(ref Particle particle) => default; // 0x0000000189E181B8-0x0000000189E181FC
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize3D", HasExplicitThis = true)]
		internal Vector3 GetParticleCurrentSize3D(ref Particle particle) => default; // 0x0000000189E18184-0x0000000189E181B8
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentColor", HasExplicitThis = true)]
		internal Color32 GetParticleCurrentColor(ref Particle particle) => default; // 0x0000000189E1810C-0x0000000189E18130
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleMeshIndex", HasExplicitThis = true)]
		internal int GetParticleMeshIndex(ref Particle particle) => default; // 0x0000000189E181FC-0x0000000189E18240
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", HasExplicitThis = true, ThrowsException = true)]
		public void SetParticles(out Particle[] particles, int size, int offset) {
			particles = default;
		} // 0x0000000189E188A4-0x0000000189E18908
		public void SetParticles(out Particle[] particles, int size) {
			particles = default;
		} // 0x0000000189E18888-0x0000000189E188A4
		public void SetParticles(out Particle[] particles) {
			particles = default;
		} // 0x0000000189E1882C-0x0000000189E1883C
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticlesWithNativeArray", HasExplicitThis = true, ThrowsException = true)]
		private void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) {} // 0x0000000189E187C8-0x0000000189E1882C
		public void SetParticles(out NativeArray<Particle> particles, int size, int offset) {
			particles = default;
		} // 0x0000000189E18908-0x0000000189E18978
		public void SetParticles(out NativeArray<Particle> particles, int size) {
			particles = default;
		} // 0x0000000189E18860-0x0000000189E18888
		public void SetParticles(out NativeArray<Particle> particles) {
			particles = default;
		} // 0x0000000189E1883C-0x0000000189E18860
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = true, ThrowsException = true)]
		public int GetParticles([NotNull("ArgumentNullException")] out Particle[] particles, int size, int offset) {
			particles = default;
			return default;
		} // 0x0000000189E18370-0x0000000189E183D4
		public int GetParticles(out Particle[] particles, int size) {
			particles = default;
			return default;
		} // 0x0000000189E183D4-0x0000000189E183F0
		public int GetParticles(out Particle[] particles) {
			particles = default;
			return default;
		} // 0x0000000189E182A4-0x0000000189E182B4
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticlesWithNativeArray", HasExplicitThis = true, ThrowsException = true)]
		private int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) => default; // 0x0000000189E18240-0x0000000189E182A4
		public int GetParticles(out NativeArray<Particle> particles, int size, int offset) {
			particles = default;
			return default;
		} // 0x0000000189E18300-0x0000000189E18370
		public int GetParticles(out NativeArray<Particle> particles, int size) {
			particles = default;
			return default;
		} // 0x0000000189E182D8-0x0000000189E18300
		public int GetParticles(out NativeArray<Particle> particles) {
			particles = default;
			return default;
		} // 0x0000000189E182B4-0x0000000189E182D8
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetCustomParticleData", HasExplicitThis = true, ThrowsException = true)]
		public void SetCustomParticleData([NotNull("ArgumentNullException")] List<Vector4> customData, ParticleSystemCustomData streamIndex) {} // 0x0000000189E186DC-0x0000000189E18730
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetCustomParticleData", HasExplicitThis = true, ThrowsException = true)]
		public int GetCustomParticleData([NotNull("ArgumentNullException")] List<Vector4> customData, ParticleSystemCustomData streamIndex) => default; // 0x0000000189E17FC0-0x0000000189E18014
		public PlaybackState GetPlaybackState() => default; // 0x0000000189E18434-0x0000000189E18470
		public void SetPlaybackState(PlaybackState playbackState) {} // 0x0000000189E189BC-0x0000000189E189D0
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetTrailData", HasExplicitThis = true)]
		private void GetTrailDataInternal(ref Trails trailData) {} // 0x0000000189E18470-0x0000000189E184B4
		public Trails GetTrails() => default; // 0x0000000189E184B4-0x0000000189E1852C
		public int GetTrails(ref Trails trailData) => default; // 0x0000000189E1852C-0x0000000189E1858C
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetTrailData", HasExplicitThis = true)]
		public void SetTrails(Trails trailData) {} // 0x0000000189E18A14-0x0000000189E18A28
		[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = true)]
		public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart, [DefaultValue("true")] bool fixedTimeStep) {} // 0x0000000189E18A28-0x0000000189E18A8C
		public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart) {} // 0x0000000189E18AB4-0x0000000189E18AD0
		public void Simulate(float t, [DefaultValue("true")] bool withChildren) {} // 0x0000000189E18A98-0x0000000189E18AB4
		public void Simulate(float t) {} // 0x0000000189E18A8C-0x0000000189E18A98
		[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = true)]
		public void Play([DefaultValue("true")] bool withChildren) {} // 0x00000001835A5250-0x00000001835A52A0
		public void Play() {} // 0x0000000184274AA4-0x0000000184274AB0
		[FreeFunction(Name = "ParticleSystemScriptBindings::Pause", HasExplicitThis = true)]
		public void Pause([DefaultValue("true")] bool withChildren) {} // 0x0000000189E185E8-0x0000000189E1862C
		public void Pause() {} // 0x0000000189E185DC-0x0000000189E185E8
		[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = true)]
		public void Stop([DefaultValue("true")] bool withChildren, [DefaultValue("ParticleSystemStopBehavior.StopEmitting")] ParticleSystemStopBehavior stopBehavior) {} // 0x0000000183242240-0x00000001832422A0
		public void Stop([DefaultValue("true")] bool withChildren) {} // 0x0000000189E18AD0-0x0000000189E18AE0
		public void Stop() {} // 0x0000000184271578-0x000000018427158C
		[FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = true)]
		public void Clear([DefaultValue("true")] bool withChildren) {} // 0x000000018329C870-0x000000018329C8C0
		public void Clear() {} // 0x000000018427158C-0x0000000184271598
		[FreeFunction(Name = "ParticleSystemScriptBindings::IsAlive", HasExplicitThis = true)]
		public bool IsAlive([DefaultValue("true")] bool withChildren) => default; // 0x0000000189E1858C-0x0000000189E185D0
		public bool IsAlive() => default; // 0x0000000189E185D0-0x0000000189E185DC
		[RequiredByNativeCode]
		public void Emit(int count) {} // 0x0000000189E17FA4-0x0000000189E17FAC
		[NativeName("SyncJobs()->Emit")]
		private void Emit_Internal(int count) {} // 0x0000000189E17E48-0x0000000189E17E88
		[NativeName("SyncJobs()->EmitParticlesExternal")]
		public void Emit(EmitParams emitParams, int count) {} // 0x0000000189E17FAC-0x0000000189E17FC0
		[NativeName("SyncJobs()->EmitParticleExternal")]
		private void EmitOld_Internal(ref Particle particle) {} // 0x0000000189E17DB0-0x0000000189E17DF4
		public void TriggerSubEmitter(int subEmitterIndex) {} // 0x0000000189E18B44-0x0000000189E18B50
		public void TriggerSubEmitter(int subEmitterIndex, ref Particle particle) {} // 0x0000000189E18BA0-0x0000000189E18C20
		[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitterForParticle", HasExplicitThis = true)]
		internal void TriggerSubEmitterForParticle(int subEmitterIndex, Particle particle) {} // 0x0000000189E18B30-0x0000000189E18B44
		[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitter", HasExplicitThis = true)]
		public void TriggerSubEmitter(int subEmitterIndex, List<Particle> particles) {} // 0x0000000189E18B50-0x0000000189E18BA0
		[FreeFunction(Name = "ParticleSystemGeometryJob::ResetPreMappedBufferMemory")]
		public static void ResetPreMappedBufferMemory() {} // 0x0000000189E1862C-0x0000000189E18658
		[FreeFunction(Name = "ParticleSystemGeometryJob::SetMaximumPreMappedBufferCounts")]
		public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount) {} // 0x0000000189E18788-0x0000000189E187C8
		[NativeName("SetUsesAxisOfRotation")]
		public void AllocateAxisOfRotationAttribute() {} // 0x0000000189E17CC4-0x0000000189E17CF8
		[NativeName("SetUsesMeshIndex")]
		public void AllocateMeshIndexAttribute() {} // 0x0000000189E17D38-0x0000000189E17D6C
		[NativeName("SetUsesCustomData")]
		public void AllocateCustomDataAttribute(ParticleSystemCustomData stream) {} // 0x0000000189E17CF8-0x0000000189E17D38
		internal unsafe void* GetManagedJobData() => default; // 0x0000000189E18014-0x0000000189E18048
		internal JobHandle GetManagedJobHandle() => default; // 0x0000000189E1808C-0x0000000189E180B8
		internal void SetManagedJobHandle(JobHandle handle) {} // 0x0000000189E18774-0x0000000189E18788
		[FreeFunction("ScheduleManagedJob", ThrowsException = true)]
		internal static unsafe JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData) => default; // 0x0000000189E186AC-0x0000000189E186DC
		[ThreadSafe]
		internal static unsafe void CopyManagedJobData(void* systemPtr, out NativeParticleData particleData) {
			particleData = default;
		} // 0x0000000189E17D6C-0x0000000189E17DB0
		private void GetParticleCurrentSize3D_Injected(ref Particle particle, out Vector3 ret) {
			ret = default;
		} // 0x0000000189E18130-0x0000000189E18184
		private void GetParticleCurrentColor_Injected(ref Particle particle, out Color32 ret) {
			ret = default;
		} // 0x0000000189E180B8-0x0000000189E1810C
		private void GetPlaybackState_Injected(out PlaybackState ret) {
			ret = default;
		} // 0x0000000189E183F0-0x0000000189E18434
		private void SetPlaybackState_Injected(ref PlaybackState playbackState) {} // 0x0000000189E18978-0x0000000189E189BC
		private void SetTrails_Injected(ref Trails trailData) {} // 0x0000000189E189D0-0x0000000189E18A14
		private void Emit_Injected(ref EmitParams emitParams, int count) {} // 0x0000000189E17DF4-0x0000000189E17E48
		private void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref Particle particle) {} // 0x0000000189E18AE0-0x0000000189E18B30
		private void GetManagedJobHandle_Injected(out JobHandle ret) {
			ret = default;
		} // 0x0000000189E18048-0x0000000189E1808C
		private void SetManagedJobHandle_Injected(ref JobHandle handle) {} // 0x0000000189E18730-0x0000000189E18774
		private static unsafe void ScheduleManagedJob_Injected(ref JobsUtility.JobScheduleParameters parameters, void* additionalData, out JobHandle ret) {
			ret = default;
		} // 0x0000000189E18658-0x0000000189E186AC
	}

	public static class ParticlePhysicsExtensions // TypeDefIndex: 58768
	{
		// Extension methods
		public static int GetSafeCollisionEventSize(this ParticleSystem ps) => default; // 0x0000000189E15900-0x0000000189E1590C
		public static int GetCollisionEvents(this ParticleSystem ps, GameObject go, List<ParticleCollisionEvent> collisionEvents) => default; // 0x0000000189E158F4-0x0000000189E15900
	}

	public enum ParticleSystemRenderMode // TypeDefIndex: 58769
	{
		Billboard = 0,
		Stretch = 1,
		HorizontalBillboard = 2,
		VerticalBillboard = 3,
		Mesh = 4,
		None = 5
	}

	public enum ParticleSystemMeshDistribution // TypeDefIndex: 58770
	{
		UniformRandom = 0,
		NonUniformRandom = 1
	}

	public enum ParticleSystemSortMode // TypeDefIndex: 58771
	{
		None = 0,
		Distance = 1,
		OldestInFront = 2,
		YoungestInFront = 3,
		Depth = 4
	}

	public enum ParticleSystemRenderSpace // TypeDefIndex: 58772
	{
		View = 0,
		World = 1,
		Local = 2,
		Facing = 3,
		Velocity = 4
	}

	public enum ParticleSystemCurveMode // TypeDefIndex: 58773
	{
		Constant = 0,
		Curve = 1,
		TwoCurves = 2,
		TwoConstants = 3
	}

	public enum ParticleSystemGradientMode // TypeDefIndex: 58774
	{
		Color = 0,
		Gradient = 1,
		TwoColors = 2,
		TwoGradients = 3,
		RandomColor = 4
	}

	public enum ParticleSystemShapeType // TypeDefIndex: 58775
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

	public enum ParticleSystemSimulationSpace // TypeDefIndex: 58776
	{
		Local = 0,
		World = 1,
		Custom = 2
	}

	public enum ParticleSystemStopBehavior // TypeDefIndex: 58777
	{
		StopEmittingAndClear = 0,
		StopEmitting = 1
	}

	public enum ParticleSystemScalingMode // TypeDefIndex: 58778
	{
		Hierarchy = 0,
		Local = 1,
		Shape = 2
	}

	[UsedByNativeCode]
	public enum ParticleSystemVertexStream // TypeDefIndex: 58779
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

	public enum ParticleSystemCustomData // TypeDefIndex: 58780
	{
		Custom1 = 0,
		Custom2 = 1
	}

	public enum ParticleSystemTrailTextureMode // TypeDefIndex: 58781
	{
		Stretch = 0,
		Tile = 1,
		DistributePerSegment = 2,
		RepeatPerSegment = 3
	}

	public enum ParticleSystemForceFieldShape // TypeDefIndex: 58782
	{
		Sphere = 0,
		Hemisphere = 1,
		Cylinder = 2,
		Box = 3
	}

	[Flags]
	[Obsolete("ParticleSystemVertexStreams is deprecated. Please use ParticleSystemVertexStream instead.", false)]
	public enum ParticleSystemVertexStreams // TypeDefIndex: 58783
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
	public sealed class ParticleSystemRenderer : Renderer // TypeDefIndex: 58784
	{
		// Properties
		[NativeName("RenderAlignment")]
		public ParticleSystemRenderSpace alignment { get => default; set {} } // 0x0000000189E171E8-0x0000000189E1721C 0x0000000189E176D8-0x0000000189E17718
		public ParticleSystemRenderMode renderMode { get => default; set {} } // 0x0000000189E175A0-0x0000000189E175D4 0x0000000189E17B34-0x0000000189E17B74
		public ParticleSystemMeshDistribution meshDistribution { get => default; set {} } // 0x0000000189E17460-0x0000000189E17494 0x0000000189E1798C-0x0000000189E179CC
		public ParticleSystemSortMode sortMode { get => default; set {} } // 0x0000000189E1763C-0x0000000189E17670 0x0000000189E17BFC-0x0000000189E17C3C
		public float lengthScale { get => default; set {} } // 0x0000000189E17390-0x0000000189E173C4 0x0000000189E178C4-0x0000000189E17908
		public float velocityScale { get => default; set {} } // 0x0000000189E176A4-0x0000000189E176D8 0x0000000189E17C80-0x0000000189E17CC4
		public float cameraVelocityScale { get => default; set {} } // 0x0000000189E17250-0x0000000189E17284 0x0000000189E1775C-0x0000000189E177A0
		public float normalDirection { get => default; set {} } // 0x0000000189E174FC-0x0000000189E17530 0x0000000189E17A54-0x0000000189E17A98
		public float shadowBias { get => default; set {} } // 0x0000000189E17608-0x0000000189E1763C 0x0000000189E17BB8-0x0000000189E17BFC
		public float minParticleSize { get => default; set {} } // 0x0000000189E174C8-0x0000000189E174FC 0x0000000189E17A10-0x0000000189E17A54
		public float maxParticleSize { get => default; set {} } // 0x0000000189E173F8-0x0000000189E1742C 0x0000000189E17948-0x0000000189E1798C
		public Vector3 pivot { get => default; set {} } // 0x0000000189E17574-0x0000000189E175A0 0x0000000189E17B20-0x0000000189E17B34
		public Vector3 flip { get => default; set {} } // 0x0000000189E17330-0x0000000189E1735C 0x0000000189E1786C-0x0000000189E17880
		public SpriteMaskInteraction maskInteraction { get => default; set {} } // 0x0000000189E173C4-0x0000000189E173F8 0x0000000189E17908-0x0000000189E17948
		public Material trailMaterial { get => default; set {} } // 0x0000000189E17670-0x0000000189E176A4 0x0000000189E17C3C-0x0000000189E17C80
		internal Material oldTrailMaterial { set {} } // 0x0000000189E17A98-0x0000000189E17ADC
		public bool enableGPUInstancing { get => default; set {} } // 0x0000000189E17284-0x0000000189E172B8 0x0000000189E177A0-0x0000000189E177E4
		public bool allowRoll { get => default; set {} } // 0x0000000189E1721C-0x0000000189E17250 0x0000000189E17718-0x0000000189E1775C
		public bool freeformStretching { get => default; set {} } // 0x0000000189E1735C-0x0000000189E17390 0x0000000189E17880-0x0000000189E178C4
		public bool rotateWithStretchDirection { get => default; set {} } // 0x0000000189E175D4-0x0000000189E17608 0x0000000189E17B74-0x0000000189E17BB8
		public bool enableHGGPUInstancing { get => default; set {} } // 0x0000000189E172B8-0x0000000189E172EC 0x0000000189E177E4-0x0000000189E17828
		public Mesh mesh { [FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMesh", HasExplicitThis = true)] get => default; [FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMesh", HasExplicitThis = true)] set {} } // 0x0000000189E17494-0x0000000189E174C8 0x0000000189E179CC-0x0000000189E17A10
		public int meshCount { get => default; } // 0x0000000189E1742C-0x0000000189E17460 
		public int activeVertexStreamsCount { get => default; } // 0x0000000189E171B4-0x0000000189E171E8 
		public bool DisableCutOutAnimation { get => default; } // 0x0000000189E17180-0x0000000189E171B4 
		public int CutOutMode { get => default; } // 0x0000000189E1714C-0x0000000189E17180 
		public int CutOutDataSize { get => default; } // 0x0000000189E17118-0x0000000189E1714C 
	
		// Constructors
		public ParticleSystemRenderer() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		[Obsolete("EnableVertexStreams is deprecated.Use SetActiveVertexStreams instead.", false)]
		public void EnableVertexStreams(ParticleSystemVertexStreams streams) {} // 0x0000000189E166CC-0x0000000189E166D8
		[Obsolete("DisableVertexStreams is deprecated.Use SetActiveVertexStreams instead.", false)]
		public void DisableVertexStreams(ParticleSystemVertexStreams streams) {} // 0x0000000189E166C0-0x0000000189E166CC
		[Obsolete("AreVertexStreamsEnabled is deprecated.Use GetActiveVertexStreams instead.", false)]
		public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams) => default; // 0x0000000189E16544-0x0000000189E16560
		[Obsolete("GetEnabledVertexStreams is deprecated.Use GetActiveVertexStreams instead.", false)]
		public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams) => default; // 0x0000000189E1671C-0x0000000189E16728
		[Obsolete("Internal_SetVertexStreams is deprecated.Use SetActiveVertexStreams instead.", false)]
		internal void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled) {} // 0x0000000189E16A08-0x0000000189E16FEC
		[Obsolete("Internal_GetVertexStreams is deprecated.Use GetActiveVertexStreams instead.", false)]
		internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams) => default; // 0x0000000189E167B0-0x0000000189E16A08
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = true)]
		[RequiredByNativeCode]
		public int GetMeshes([NotNull("ArgumentNullException")] out Mesh[] meshes) {
			meshes = default;
			return default;
		} // 0x0000000189E1676C-0x0000000189E167B0
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshes", HasExplicitThis = true)]
		public void SetMeshes([NotNull("ArgumentNullException")] Mesh[] meshes, int size) {} // 0x0000000189E170A4-0x0000000189E170F8
		public void SetMeshes(Mesh[] meshes) {} // 0x0000000189E170F8-0x0000000189E17118
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshWeightings", HasExplicitThis = true)]
		public int GetMeshWeightings([NotNull("ArgumentNullException")] out float[] weightings) {
			weightings = default;
			return default;
		} // 0x0000000189E16728-0x0000000189E1676C
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshWeightings", HasExplicitThis = true)]
		public void SetMeshWeightings([NotNull("ArgumentNullException")] float[] weightings, int size) {} // 0x0000000189E17030-0x0000000189E17084
		public void SetMeshWeightings(float[] weightings) {} // 0x0000000189E17084-0x0000000189E170A4
		public void BakeMesh(Mesh mesh, bool useTransform = false /* Metadata: 0x01FDC690 */) {} // 0x0000000189E165C4-0x0000000189E16610
		public void BakeMesh([NotNull("ArgumentNullException")] Mesh mesh, [NotNull("ArgumentNullException")] Camera camera, bool useTransform = false /* Metadata: 0x01FDC691 */) {} // 0x0000000189E16560-0x0000000189E165C4
		public void BakeTrailsMesh(Mesh mesh, bool useTransform = false /* Metadata: 0x01FDC692 */) {} // 0x0000000189E16610-0x0000000189E1665C
		public void BakeTrailsMesh([NotNull("ArgumentNullException")] Mesh mesh, [NotNull("ArgumentNullException")] Camera camera, bool useTransform = false /* Metadata: 0x01FDC693 */) {} // 0x0000000189E1665C-0x0000000189E166C0
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetActiveVertexStreams", HasExplicitThis = true)]
		public void SetActiveVertexStreams([NotNull("ArgumentNullException")] List<ParticleSystemVertexStream> streams) {} // 0x0000000189E16FEC-0x0000000189E17030
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetActiveVertexStreams", HasExplicitThis = true)]
		public void GetActiveVertexStreams([NotNull("ArgumentNullException")] List<ParticleSystemVertexStream> streams) {} // 0x0000000189E166D8-0x0000000189E1671C
		private void get_pivot_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189E17530-0x0000000189E17574
		private void set_pivot_Injected(ref Vector3 value) {} // 0x0000000189E17ADC-0x0000000189E17B20
		private void get_flip_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189E172EC-0x0000000189E17330
		private void set_flip_Injected(ref Vector3 value) {} // 0x0000000189E17828-0x0000000189E1786C
	}

	[RequiredByNativeCode(Optional = true)]
	public struct ParticleCollisionEvent // TypeDefIndex: 58785
	{
		// Fields
		internal Vector3 m_Intersection; // 0x00
		internal Vector3 m_Normal; // 0x0C
		internal Vector3 m_Velocity; // 0x18
		internal int m_ColliderInstanceID; // 0x24
	
		// Properties
		public Vector3 intersection { get => default; } // 0x0000000183D85920-0x0000000183D85940 
		public Vector3 normal { get => default; } // 0x0000000183D85900-0x0000000183D85920 
		public Vector3 velocity { get => default; } // 0x0000000183D85CF0-0x0000000183D85D10 
		public Component colliderComponent { get => default; } // 0x0000000189E158E8-0x0000000189E158F4 
	
		// Methods
		[FreeFunction(Name = "ParticleSystemScriptBindings::InstanceIDToColliderComponent")]
		private static Component InstanceIDToColliderComponent(int instanceID) => default; // 0x0000000189E158B4-0x0000000189E158E8
	}

	internal class ParticleSystemExtensionsImpl // TypeDefIndex: 58786
	{
		// Constructors
		public ParticleSystemExtensionsImpl() {} // Dummy constructor
	
		// Methods
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetSafeCollisionEventSize")]
		internal static int GetSafeCollisionEventSize([NotNull("ArgumentNullException")] ParticleSystem ps) => default; // 0x0000000189E15960-0x0000000189E15994
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetCollisionEvents")]
		internal static int GetCollisionEvents([NotNull("ArgumentNullException")] ParticleSystem ps, [NotNull("ArgumentNullException")] GameObject go, [NotNull("ArgumentNullException")] List<ParticleCollisionEvent> collisionEvents) => default; // 0x0000000189E1590C-0x0000000189E15960
	}

	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystemForceField.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystemForceFieldManager.h")]
	[RequireComponent(typeof(Transform))]
	public class ParticleSystemForceField : UnityEngine.Behaviour // TypeDefIndex: 58787
	{
		// Properties
		[NativeName("ForceShape")]
		public ParticleSystemForceFieldShape shape { get => default; set {} } // 0x0000000189E15E2C-0x0000000189E15E60 0x0000000189E163CC-0x0000000189E1640C
		public float startRange { get => default; set {} } // 0x0000000189E15E60-0x0000000189E15E94 0x0000000189E1640C-0x0000000189E16450
		public float endRange { get => default; set {} } // 0x0000000189E15B64-0x0000000189E15B98 0x0000000189E16110-0x0000000189E16154
		public float length { get => default; set {} } // 0x0000000189E15C40-0x0000000189E15C74 0x0000000189E161F0-0x0000000189E16234
		public float gravityFocus { get => default; set {} } // 0x0000000189E15B98-0x0000000189E15BCC 0x0000000189E16154-0x0000000189E16198
		public Vector2 rotationRandomness { get => default; set {} } // 0x0000000189E15D94-0x0000000189E15DB8 0x0000000189E16358-0x0000000189E16374
		public bool multiplyDragByParticleSize { get => default; set {} } // 0x0000000189E15C74-0x0000000189E15CA8 0x0000000189E16234-0x0000000189E16278
		public bool multiplyDragByParticleVelocity { get => default; set {} } // 0x0000000189E15CA8-0x0000000189E15CDC 0x0000000189E16278-0x0000000189E162BC
		public Texture3D vectorField { get => default; set {} } // 0x0000000189E15F7C-0x0000000189E15FB0 0x0000000189E16500-0x0000000189E16544
		public ParticleSystem.MinMaxCurve directionX { get => default; set {} } // 0x0000000189E159D8-0x0000000189E15A08 0x0000000189E15FF4-0x0000000189E16008
		public ParticleSystem.MinMaxCurve directionY { get => default; set {} } // 0x0000000189E15A4C-0x0000000189E15A7C 0x0000000189E1604C-0x0000000189E16060
		public ParticleSystem.MinMaxCurve directionZ { get => default; set {} } // 0x0000000189E15AC0-0x0000000189E15AF0 0x0000000189E160A4-0x0000000189E160B8
		public ParticleSystem.MinMaxCurve gravity { get => default; set {} } // 0x0000000189E15C10-0x0000000189E15C40 0x0000000189E161DC-0x0000000189E161F0
		public ParticleSystem.MinMaxCurve rotationSpeed { get => default; set {} } // 0x0000000189E15DFC-0x0000000189E15E2C 0x0000000189E163B8-0x0000000189E163CC
		public ParticleSystem.MinMaxCurve rotationAttraction { get => default; set {} } // 0x0000000189E15D20-0x0000000189E15D50 0x0000000189E16300-0x0000000189E16314
		public ParticleSystem.MinMaxCurve drag { get => default; set {} } // 0x0000000189E15B34-0x0000000189E15B64 0x0000000189E160FC-0x0000000189E16110
		public ParticleSystem.MinMaxCurve vectorFieldSpeed { get => default; set {} } // 0x0000000189E15F4C-0x0000000189E15F7C 0x0000000189E164EC-0x0000000189E16500
		public ParticleSystem.MinMaxCurve vectorFieldAttraction { get => default; set {} } // 0x0000000189E15ED8-0x0000000189E15F08 0x0000000189E16494-0x0000000189E164A8
	
		// Constructors
		public ParticleSystemForceField() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void get_rotationRandomness_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000189E15D50-0x0000000189E15D94
		private void set_rotationRandomness_Injected(ref Vector2 value) {} // 0x0000000189E16314-0x0000000189E16358
		private void get_directionX_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x0000000189E15994-0x0000000189E159D8
		private void set_directionX_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x0000000189E15FB0-0x0000000189E15FF4
		private void get_directionY_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x0000000189E15A08-0x0000000189E15A4C
		private void set_directionY_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x0000000189E16008-0x0000000189E1604C
		private void get_directionZ_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x0000000189E15A7C-0x0000000189E15AC0
		private void set_directionZ_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x0000000189E16060-0x0000000189E160A4
		private void get_gravity_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x0000000189E15BCC-0x0000000189E15C10
		private void set_gravity_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x0000000189E16198-0x0000000189E161DC
		private void get_rotationSpeed_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x0000000189E15DB8-0x0000000189E15DFC
		private void set_rotationSpeed_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x0000000189E16374-0x0000000189E163B8
		private void get_rotationAttraction_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x0000000189E15CDC-0x0000000189E15D20
		private void set_rotationAttraction_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x0000000189E162BC-0x0000000189E16300
		private void get_drag_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x0000000189E15AF0-0x0000000189E15B34
		private void set_drag_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x0000000189E160B8-0x0000000189E160FC
		private void get_vectorFieldSpeed_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x0000000189E15F08-0x0000000189E15F4C
		private void set_vectorFieldSpeed_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x0000000189E164A8-0x0000000189E164EC
		private void get_vectorFieldAttraction_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x0000000189E15E94-0x0000000189E15ED8
		private void set_vectorFieldAttraction_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x0000000189E16450-0x0000000189E16494
	}

	[NativeHeader("Modules/ParticleSystem/HGParticle/HGParticleMeshInstanceRenderer.h")]
	[RequireComponent(typeof(ParticleSystemRenderer))]
	[RequiredByNativeCode]
	internal sealed class HGParticleMeshInstanceRenderer : Renderer // TypeDefIndex: 58788
	{
		// Constructors
		public HGParticleMeshInstanceRenderer() {} // Dummy constructor
	}
}

namespace UnityEngine.ParticleSystemJobs
{
	internal struct NativeParticleData // TypeDefIndex: 58791
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
		internal struct Array3 // TypeDefIndex: 58789
		{
			// Fields
			internal unsafe float* x; // 0x00
			internal unsafe float* y; // 0x08
			internal unsafe float* z; // 0x10
		}
	
		internal struct Array4 // TypeDefIndex: 58790
		{
			// Fields
			internal unsafe float* x; // 0x00
			internal unsafe float* y; // 0x08
			internal unsafe float* z; // 0x10
			internal unsafe float* w; // 0x18
		}
	}
}
