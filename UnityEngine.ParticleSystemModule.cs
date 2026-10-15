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

// Image 73: UnityEngine.ParticleSystemModule.dll - Assembly: UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89610-89674

namespace UnityEngine
{
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
	[RequireComponent(typeof(Transform))]
	[UsedByNativeCode]
	public sealed class ParticleSystem : Component // TypeDefIndex: 89650
	{
		// Properties
		[Obsolete("startDelay property is deprecated. Use main.startDelay or main.startDelayMultiplier instead.", false)]
		public float startDelay { get; set; } // 0x000000018D546F3C-0x000000018D546F68 0x000000018D547410-0x000000018D54744C
		[Obsolete("loop property is deprecated. Use main.loop instead.", false)]
		public bool loop { get; set; } // 0x000000018D546D28-0x000000018D546D54 0x000000018D54720C-0x000000018D547240
		[Obsolete("playOnAwake property is deprecated. Use main.playOnAwake instead.", false)]
		public bool playOnAwake { get; set; } // 0x000000018D546DB4-0x000000018D546DE0 0x000000018D547274-0x000000018D5472A8
		[Obsolete("duration property is deprecated. Use main.duration instead.", false)]
		public float duration { get; } // 0x000000018D546B90-0x000000018D546BBC 
		[Obsolete("playbackSpeed property is deprecated. Use main.simulationSpeed instead.", false)]
		public float playbackSpeed { get; set; } // 0x000000018D546DE0-0x000000018D546E0C 0x000000018D5472A8-0x000000018D5472E4
		[Obsolete("enableEmission property is deprecated. Use emission.enabled instead.", false)]
		public bool enableEmission { get; set; } // 0x000000018D546BF4-0x000000018D546C2C 0x000000018D547190-0x000000018D5471D0
		[Obsolete("emissionRate property is deprecated. Use emission.rateOverTime, emission.rateOverDistance, emission.rateOverTimeMultiplier or emission.rateOverDistanceMultiplier instead.", false)]
		public float emissionRate { get; set; } // 0x000000018D546BBC-0x000000018D546BF4 0x000000018D547128-0x000000018D547190
		[Obsolete("startSpeed property is deprecated. Use main.startSpeed or main.startSpeedMultiplier instead.", false)]
		public float startSpeed { get; set; } // 0x000000018D547094-0x000000018D5470C0 0x000000018D54755C-0x000000018D547598
		[Obsolete("startSize property is deprecated. Use main.startSize or main.startSizeMultiplier instead.", false)]
		public float startSize { get; set; } // 0x000000018D547068-0x000000018D547094 0x000000018D547520-0x000000018D54755C
		[Obsolete("startColor property is deprecated. Use main.startColor instead.", false)]
		public Color startColor { get; set; } // 0x000000018D546ECC-0x000000018D546F3C 0x000000018D54738C-0x000000018D547410
		[Obsolete("startRotation property is deprecated. Use main.startRotation or main.startRotationMultiplier instead.", false)]
		public float startRotation { get; set; } // 0x000000018D54703C-0x000000018D547068 0x000000018D5474E4-0x000000018D547520
		[Obsolete("startRotation3D property is deprecated. Use main.startRotationX, main.startRotationY and main.startRotationZ instead. (Or main.startRotationXMultiplier, main.startRotationYMultiplier and main.startRotationZMultiplier).", false)]
		public Vector3 startRotation3D { get; set; } // 0x000000018D546F94-0x000000018D54703C 0x000000018D547488-0x000000018D5474E4
		[Obsolete("startLifetime property is deprecated. Use main.startLifetime or main.startLifetimeMultiplier instead.", false)]
		public float startLifetime { get; set; } // 0x000000018D546F68-0x000000018D546F94 0x000000018D54744C-0x000000018D547488
		[Obsolete("gravityModifier property is deprecated. Use main.gravityModifier or main.gravityModifierMultiplier instead.", false)]
		public float gravityModifier { get; set; } // 0x000000018D546C2C-0x000000018D546C58 0x000000018D5471D0-0x000000018D54720C
		[Obsolete("maxParticles property is deprecated. Use main.maxParticles instead.", false)]
		public int maxParticles { get; set; } // 0x000000018D546D54-0x000000018D546D80 0x000000018D547240-0x000000018D547274
		[Obsolete("simulationSpace property is deprecated. Use main.simulationSpace instead.", false)]
		public ParticleSystemSimulationSpace simulationSpace { get; set; } // 0x000000018D546EA0-0x000000018D546ECC 0x000000018D547358-0x000000018D54738C
		[Obsolete("scalingMode property is deprecated. Use main.scalingMode instead.", false)]
		public ParticleSystemScalingMode scalingMode { get; set; } // 0x000000018D546E74-0x000000018D546EA0 0x000000018D547324-0x000000018D547358
		[Obsolete("automaticCullingEnabled property is deprecated. Use proceduralSimulationSupported instead (UnityUpgradable) -> proceduralSimulationSupported", true)]
		public bool automaticCullingEnabled { get; } // 0x000000018D546B84-0x000000018D546B90 
		public bool isPlaying { [NativeName("SyncJobs(false)->IsPlaying")] get; } // 0x000000018D546CC0-0x000000018D546CF4 
		public bool isEmitting { [NativeName("SyncJobs(false)->IsEmitting")] get; } // 0x000000018D546C58-0x000000018D546C8C 
		public bool isStopped { [NativeName("SyncJobs(false)->IsStopped")] get; } // 0x000000018D546CF4-0x000000018D546D28 
		public bool isPaused { [NativeName("SyncJobs(false)->IsPaused")] get; } // 0x000000018D546C8C-0x000000018D546CC0 
		public int particleCount { [NativeName("SyncJobs(false)->GetParticleCount")] get; } // 0x000000018D546D80-0x000000018D546DB4 
		public float time { [NativeName("SyncJobs(false)->GetSecPosition")] get; [NativeName("SyncJobs(false)->SetSecPosition")] set; } // 0x000000018D5470C0-0x000000018D5470F4 0x000000018D547598-0x000000018D5475DC
		public uint randomSeed { [NativeName("GetRandomSeed")] get; [NativeName("SyncJobs(false)->SetRandomSeed")] set; } // 0x000000018D546E40-0x000000018D546E74 0x000000018D5472E4-0x000000018D547324
		public bool useAutoRandomSeed { [NativeName("GetAutoRandomSeed")] get; [NativeName("SyncJobs(false)->SetAutoRandomSeed")] set; } // 0x000000018D5470F4-0x000000018D547128 0x000000018D5475DC-0x000000018D547620
		public bool proceduralSimulationSupported { get; } // 0x000000018D546E0C-0x000000018D546E40 
		public MainModule main { get; } // 0x0000000185901070-0x00000001859010D0 
		public EmissionModule emission { get; } // 0x0000000186067390-0x00000001860673B0 
		public ShapeModule shape { get; } // 0x0000000186067390-0x00000001860673B0 
		public VelocityOverLifetimeModule velocityOverLifetime { get; } // 0x0000000186067390-0x00000001860673B0 
		public LimitVelocityOverLifetimeModule limitVelocityOverLifetime { get; } // 0x0000000186067390-0x00000001860673B0 
		public InheritVelocityModule inheritVelocity { get; } // 0x0000000186067390-0x00000001860673B0 
		public LifetimeByEmitterSpeedModule lifetimeByEmitterSpeed { get; } // 0x0000000186067390-0x00000001860673B0 
		public ForceOverLifetimeModule forceOverLifetime { get; } // 0x0000000186067390-0x00000001860673B0 
		public ColorOverLifetimeModule colorOverLifetime { get; } // 0x0000000186067390-0x00000001860673B0 
		public ColorBySpeedModule colorBySpeed { get; } // 0x0000000186067390-0x00000001860673B0 
		public SizeOverLifetimeModule sizeOverLifetime { get; } // 0x0000000186067390-0x00000001860673B0 
		public SizeBySpeedModule sizeBySpeed { get; } // 0x0000000186067390-0x00000001860673B0 
		public RotationOverLifetimeModule rotationOverLifetime { get; } // 0x0000000186067390-0x00000001860673B0 
		public RotationBySpeedModule rotationBySpeed { get; } // 0x0000000186067390-0x00000001860673B0 
		public ExternalForcesModule externalForces { get; } // 0x0000000186067390-0x00000001860673B0 
		public NoiseModule noise { get; } // 0x0000000186067390-0x00000001860673B0 
		public CollisionModule collision { get; } // 0x0000000186067390-0x00000001860673B0 
		public TriggerModule trigger { get; } // 0x0000000186067390-0x00000001860673B0 
		public SubEmittersModule subEmitters { get; } // 0x0000000186067390-0x00000001860673B0 
		public TextureSheetAnimationModule textureSheetAnimation { get; } // 0x0000000186067390-0x00000001860673B0 
		public LightsModule lights { get; } // 0x0000000186067390-0x00000001860673B0 
		public TrailModule trails { get; } // 0x0000000186067390-0x00000001860673B0 
		public CustomDataModule customData { get; } // 0x0000000186067390-0x00000001860673B0 
	
		// Nested types
		public struct MainModule // TypeDefIndex: 89611
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public float duration { get; [NativeThrows] set; } // 0x000000018D542F74-0x000000018D542F7C 0x000000018D5432D4-0x000000018D5432DC
			public bool loop { get; [NativeThrows] set; } // 0x000000018D542FEC-0x000000018D542FF4 0x000000018D54336C-0x000000018D543374
			public float startDelayMultiplier { get; [NativeThrows] set; } // 0x000000018D5430E4-0x000000018D5430EC 0x000000018D543460-0x000000018D543468
			public MinMaxCurve startLifetime { get; [NativeThrows] set; } // 0x00000001859DC500-0x00000001859DC530 0x0000000187838D48-0x0000000187838D5C
			public float startLifetimeMultiplier { get; [NativeThrows] set; } // 0x000000018D543120-0x000000018D543128 0x000000018D5434AC-0x000000018D5434B4
			public MinMaxCurve startSpeed { get; } // 0x00000001859DC530-0x00000001859DC560 
			public float startSpeedMultiplier { get; [NativeThrows] set; } // 0x000000018D543288-0x000000018D543290 0x000000018D5436CC-0x000000018D5436D4
			[NativeName("StartSizeX")]
			public MinMaxCurve startSize { [NativeThrows] set; } // 0x000000018D543674-0x000000018D543688
			[NativeName("StartSizeXMultiplier")]
			public float startSizeMultiplier { get; [NativeThrows] set; } // 0x000000018D54324C-0x000000018D543254 0x000000018D543628-0x000000018D543630
			[NativeName("StartRotationZMultiplier")]
			public float startRotationMultiplier { get; [NativeThrows] set; } // 0x000000018D54315C-0x000000018D543164 0x000000018D5434F8-0x000000018D543500
			public float startRotationXMultiplier { get; [NativeThrows] set; } // 0x000000018D543198-0x000000018D5431A0 0x000000018D543544-0x000000018D54354C
			public float startRotationYMultiplier { get; [NativeThrows] set; } // 0x000000018D5431D4-0x000000018D5431DC 0x000000018D543590-0x000000018D543598
			public float startRotationZMultiplier { get; [NativeThrows] set; } // 0x000000018D543210-0x000000018D543218 0x000000018D5435DC-0x000000018D5435E4
			public MinMaxGradient startColor { get; [NativeThrows] set; } // 0x0000000186CD6FD0-0x0000000186CD7010 0x000000018D543408-0x000000018D54341C
			public float gravityModifierMultiplier { get; [NativeThrows] set; } // 0x000000018D542FB0-0x000000018D542FB8 0x000000018D543320-0x000000018D543328
			public ParticleSystemSimulationSpace simulationSpace { get; [NativeThrows] set; } // 0x000000018D5430A0-0x000000018D5430A8 0x000000018D543400-0x000000018D543408
			public float simulationSpeed { get; [NativeThrows] set; } // 0x000000018D5430A8-0x000000018D5430B0 0x00000001878380F4-0x00000001878380FC
			public ParticleSystemScalingMode scalingMode { get; [NativeThrows] set; } // 0x000000018D543064-0x000000018D54306C 0x000000018783B67C-0x000000018783B684
			public bool playOnAwake { get; [NativeThrows] set; } // 0x000000018D543028-0x000000018D543030 0x000000018D5433B8-0x000000018D5433C0
			public int maxParticles { get; [NativeThrows] set; } // 0x000000018783B674-0x000000018783B67C 0x000000018783B684-0x000000018783B68C
	
			// Constructors
			internal MainModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
	
			// Methods
			private static float get_duration_Injected(ref MainModule _unity_self); // 0x000000018D542F40-0x000000018D542F74
			private static void set_duration_Injected(ref MainModule _unity_self, float value); // 0x000000018D543290-0x000000018D5432D4
			private static bool get_loop_Injected(ref MainModule _unity_self); // 0x000000018D542FB8-0x000000018D542FEC
			private static void set_loop_Injected(ref MainModule _unity_self, bool value); // 0x000000018D543328-0x000000018D54336C
			private static float get_startDelayMultiplier_Injected(ref MainModule _unity_self); // 0x000000018D5430B0-0x000000018D5430E4
			private static void set_startDelayMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018D54341C-0x000000018D543460
			private static void get_startLifetime_Injected(ref MainModule _unity_self, out MinMaxCurve ret); // 0x00000001859DC560-0x00000001859DC5B0
			private static void set_startLifetime_Injected(ref MainModule _unity_self, ref MinMaxCurve value); // 0x0000000186B24D60-0x0000000186B24DB0
			private static float get_startLifetimeMultiplier_Injected(ref MainModule _unity_self); // 0x000000018D5430EC-0x000000018D543120
			private static void set_startLifetimeMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018D543468-0x000000018D5434AC
			private static void get_startSpeed_Injected(ref MainModule _unity_self, out MinMaxCurve ret); // 0x00000001859DC5B0-0x00000001859DC600
			private static float get_startSpeedMultiplier_Injected(ref MainModule _unity_self); // 0x000000018D543254-0x000000018D543288
			private static void set_startSpeedMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018D543688-0x000000018D5436CC
			private static void set_startSize_Injected(ref MainModule _unity_self, ref MinMaxCurve value); // 0x000000018D543630-0x000000018D543674
			private static float get_startSizeMultiplier_Injected(ref MainModule _unity_self); // 0x000000018D543218-0x000000018D54324C
			private static void set_startSizeMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018D5435E4-0x000000018D543628
			private static float get_startRotationMultiplier_Injected(ref MainModule _unity_self); // 0x000000018D543128-0x000000018D54315C
			private static void set_startRotationMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018D5434B4-0x000000018D5434F8
			private static float get_startRotationXMultiplier_Injected(ref MainModule _unity_self); // 0x000000018D543164-0x000000018D543198
			private static void set_startRotationXMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018D543500-0x000000018D543544
			private static float get_startRotationYMultiplier_Injected(ref MainModule _unity_self); // 0x000000018D5431A0-0x000000018D5431D4
			private static void set_startRotationYMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018D54354C-0x000000018D543590
			private static float get_startRotationZMultiplier_Injected(ref MainModule _unity_self); // 0x000000018D5431DC-0x000000018D543210
			private static void set_startRotationZMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018D543598-0x000000018D5435DC
			private static void get_startColor_Injected(ref MainModule _unity_self, out MinMaxGradient ret); // 0x0000000186CD7010-0x0000000186CD7060
			private static void set_startColor_Injected(ref MainModule _unity_self, ref MinMaxGradient value); // 0x0000000186ED8800-0x0000000186ED8850
			private static float get_gravityModifierMultiplier_Injected(ref MainModule _unity_self); // 0x000000018D542F7C-0x000000018D542FB0
			private static void set_gravityModifierMultiplier_Injected(ref MainModule _unity_self, float value); // 0x000000018D5432DC-0x000000018D543320
			private static ParticleSystemSimulationSpace get_simulationSpace_Injected(ref MainModule _unity_self); // 0x000000018D54306C-0x000000018D5430A0
			private static void set_simulationSpace_Injected(ref MainModule _unity_self, ParticleSystemSimulationSpace value); // 0x000000018D5433C0-0x000000018D543400
			private static float get_simulationSpeed_Injected(ref MainModule _unity_self); // 0x00000001862DA5B0-0x00000001862DA5F0
			private static void set_simulationSpeed_Injected(ref MainModule _unity_self, float value); // 0x00000001860FC3A0-0x00000001860FC3F0
			private static ParticleSystemScalingMode get_scalingMode_Injected(ref MainModule _unity_self); // 0x000000018D543030-0x000000018D543064
			private static void set_scalingMode_Injected(ref MainModule _unity_self, ParticleSystemScalingMode value); // 0x00000001860674F0-0x0000000186067540
			private static bool get_playOnAwake_Injected(ref MainModule _unity_self); // 0x000000018D542FF4-0x000000018D543028
			private static void set_playOnAwake_Injected(ref MainModule _unity_self, bool value); // 0x000000018D543374-0x000000018D5433B8
			private static int get_maxParticles_Injected(ref MainModule _unity_self); // 0x0000000186067460-0x00000001860674A0
			private static void set_maxParticles_Injected(ref MainModule _unity_self, int value); // 0x00000001860674A0-0x00000001860674F0
		}
	
		public struct EmissionModule // TypeDefIndex: 89612
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public bool enabled { get; [NativeThrows] set; } // 0x000000018D542EB0-0x000000018D542EB8 0x000000018D542F38-0x000000018D542F40
			public MinMaxCurve rateOverTime { get; [NativeThrows] set; } // 0x00000001860673B0-0x0000000186067410 0x000000018783B68C-0x000000018783B6A0
			public float rateOverTimeMultiplier { get; } // 0x000000018D542EEC-0x000000018D542EF4 
	
			// Constructors
			internal EmissionModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
	
			// Methods
			private static bool get_enabled_Injected(ref EmissionModule _unity_self); // 0x000000018D542E7C-0x000000018D542EB0
			private static void set_enabled_Injected(ref EmissionModule _unity_self, bool value); // 0x000000018D542EF4-0x000000018D542F38
			private static void get_rateOverTime_Injected(ref EmissionModule _unity_self, out MinMaxCurve ret); // 0x0000000186067410-0x0000000186067460
			private static void set_rateOverTime_Injected(ref EmissionModule _unity_self, ref MinMaxCurve value); // 0x0000000186067540-0x0000000186067590
			private static float get_rateOverTimeMultiplier_Injected(ref EmissionModule _unity_self); // 0x000000018D542EB8-0x000000018D542EEC
		}
	
		public struct ShapeModule // TypeDefIndex: 89613
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public bool enabled { [NativeThrows] set; } // 0x000000018D547704-0x000000018D54770C
			public ParticleSystemShapeType shapeType { [NativeThrows] set; } // 0x000000018D5477AC-0x000000018D5477B4
			public float radius { [NativeThrows] set; } // 0x000000018D5477A4-0x000000018D5477AC
			public Mesh mesh { [NativeThrows] set; } // 0x000000018D547758-0x000000018D547760
			public MeshRenderer meshRenderer { [NativeThrows] set; } // 0x000000018D54770C-0x000000018D547714
			public SkinnedMeshRenderer skinnedMeshRenderer { [NativeThrows] set; } // 0x000000018D5477B4-0x000000018D5477BC
			public float textureClipThreshold { [NativeThrows] set; } // 0x000000018D54784C-0x000000018D547854
			public float textureClipThresholdUpper { [NativeThrows] set; } // 0x000000018D547800-0x000000018D547808
	
			// Constructors
			internal ShapeModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
	
			// Methods
			private static void set_enabled_Injected(ref ShapeModule _unity_self, bool value); // 0x000000018D5476C0-0x000000018D547704
			private static void set_shapeType_Injected(ref ShapeModule _unity_self, ParticleSystemShapeType value); // 0x0000000186C611C0-0x0000000186C61210
			private static void set_radius_Injected(ref ShapeModule _unity_self, float value); // 0x000000018D547760-0x000000018D5477A4
			private static void set_mesh_Injected(ref ShapeModule _unity_self, Mesh value); // 0x000000018D547714-0x000000018D547758
			private static void set_meshRenderer_Injected(ref ShapeModule _unity_self, MeshRenderer value); // 0x0000000186DD88D0-0x0000000186DD8920
			private static void set_skinnedMeshRenderer_Injected(ref ShapeModule _unity_self, SkinnedMeshRenderer value); // 0x0000000186E151F0-0x0000000186E15240
			private static void set_textureClipThreshold_Injected(ref ShapeModule _unity_self, float value); // 0x000000018D547808-0x000000018D54784C
			private static void set_textureClipThresholdUpper_Injected(ref ShapeModule _unity_self, float value); // 0x000000018D5477BC-0x000000018D547800
		}
	
		public struct CollisionModule // TypeDefIndex: 89614
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public bool enabled { get; } // 0x000000018D542E74-0x000000018D542E7C 
	
			// Constructors
			internal CollisionModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
	
			// Methods
			private static bool get_enabled_Injected(ref CollisionModule _unity_self); // 0x000000018D542E40-0x000000018D542E74
		}
	
		public struct TriggerModule // TypeDefIndex: 89615
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal TriggerModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct SubEmittersModule // TypeDefIndex: 89616
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public int subEmittersCount { get; } // 0x000000018D5478D0-0x000000018D5478D8 
	
			// Constructors
			internal SubEmittersModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
	
			// Methods
			[NativeThrows]
			public ParticleSystem GetSubEmitterSystem(int index); // 0x000000018D547894-0x000000018D54789C
			private static int get_subEmittersCount_Injected(ref SubEmittersModule _unity_self); // 0x000000018D54789C-0x000000018D5478D0
			private static ParticleSystem GetSubEmitterSystem_Injected(ref SubEmittersModule _unity_self, int index); // 0x000000018D547854-0x000000018D547894
		}
	
		public struct TextureSheetAnimationModule // TypeDefIndex: 89617
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal TextureSheetAnimationModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		[RequiredByNativeCode("particleSystemParticle", Optional = true)]
		public struct Particle // TypeDefIndex: 89618
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
			public float lifetime { set; } // 0x0000000187250F20-0x0000000187250F30
			public Vector3 position { set; } // 0x000000018723AEB0-0x000000018723AEC0
			public Vector3 velocity { set; } // 0x000000018723AEC0-0x000000018723AED0
			public float remainingLifetime { set; } // 0x0000000187250F20-0x0000000187250F30
			public float startLifetime { set; } // 0x000000018723E540-0x000000018723E550
			public Color32 startColor { set; } // 0x0000000185FF5E70-0x0000000185FF5F30
			public uint randomSeed { set; } // 0x0000000187233690-0x00000001872336A0
			public float startSize { set; } // 0x00000001872620D0-0x00000001872620F0
			public Vector3 rotation3D { set; } // 0x000000018D547670-0x000000018D5476C0
			public Vector3 angularVelocity3D { set; } // 0x000000018D547620-0x000000018D547670
		}
	
		[Serializable]
		[NativeType(CodegenOptions.Custom, "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
		public struct MinMaxCurve // TypeDefIndex: 89619
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
			public ParticleSystemCurveMode mode { get; } // 0x000000018725FD00-0x000000018725FD10 
			public AnimationCurve curveMax { get; } // 0x0000000187249840-0x0000000187249850 
			public AnimationCurve curveMin { get; } // 0x000000018725FF40-0x000000018725FF50 
			public float constantMax { get; } // 0x0000000187262050-0x0000000187262060 
			public float constantMin { get; } // 0x0000000184F6C3E0-0x0000000184F6C650 
			public float constant { get; set; } // 0x0000000187262050-0x0000000187262060 0x0000000187233420-0x0000000187233430
			public AnimationCurve curve { get; } // 0x0000000187249840-0x0000000187249850 
	
			// Constructors
			public MinMaxCurve(float constant); // 0x000000018563BB90-0x000000018563BBD0
	
			// Methods
			public static implicit operator MinMaxCurve(float constant); // 0x000000018563BB20-0x000000018563BB90
		}
	
		[Serializable]
		[NativeType(CodegenOptions.Custom, "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
		public struct MinMaxGradient // TypeDefIndex: 89620
		{
			// Fields
			[SerializeField]
			private ParticleSystemGradientMode m_Mode; // 0x00
			[SerializeField]
			private Gradient m_GradientMin; // 0x08
			[SerializeField]
			private Gradient m_GradientMax; // 0x10
			[SerializeField]
			private Color m_ColorMin; // 0x18
			[SerializeField]
			private Color m_ColorMax; // 0x28
	
			// Properties
			public Color colorMax { set; } // 0x000000018723D780-0x000000018723D790
			public Color colorMin { set; } // 0x0000000187235FF0-0x0000000187236000
			public Color color { get; set; } // 0x0000000187261E80-0x0000000187261E90 0x000000018723D780-0x000000018723D790
	
			// Constructors
			public MinMaxGradient(Color color); // 0x000000018D5436D4-0x000000018D543724
	
			// Methods
			public static implicit operator MinMaxGradient(Color color); // 0x000000018D543724-0x000000018D5437A0
		}
	
		public struct EmitParams // TypeDefIndex: 89621
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
	
		public struct PlaybackState // TypeDefIndex: 89632
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
			internal struct Seed // TypeDefIndex: 89622
			{
				// Fields
				public uint x; // 0x00
				public uint y; // 0x04
				public uint z; // 0x08
				public uint w; // 0x0C
			}
	
			internal struct Seed4 // TypeDefIndex: 89623
			{
				// Fields
				public Seed x; // 0x00
				public Seed y; // 0x10
				public Seed z; // 0x20
				public Seed w; // 0x30
			}
	
			internal struct Emission // TypeDefIndex: 89624
			{
				// Fields
				public float m_ParticleSpacing; // 0x00
				public float m_ToEmitAccumulator; // 0x04
				public Seed m_Random; // 0x08
			}
	
			internal struct Initial // TypeDefIndex: 89625
			{
				// Fields
				public Seed4 m_Random; // 0x00
			}
	
			internal struct Shape // TypeDefIndex: 89626
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
	
			internal struct Force // TypeDefIndex: 89627
			{
				// Fields
				public Seed4 m_Random; // 0x00
			}
	
			internal struct Collision // TypeDefIndex: 89628
			{
				// Fields
				public Seed4 m_Random; // 0x00
			}
	
			internal struct Noise // TypeDefIndex: 89629
			{
				// Fields
				public float m_ScrollOffset; // 0x00
			}
	
			internal struct Lights // TypeDefIndex: 89630
			{
				// Fields
				public Seed m_Random; // 0x00
				public float m_ParticleEmissionCounter; // 0x10
			}
	
			internal struct Trail // TypeDefIndex: 89631
			{
				// Fields
				public float m_Timer; // 0x00
			}
		}
	
		[NativeType(CodegenOptions.Custom, "MonoParticleTrails")]
		public struct Trails // TypeDefIndex: 89633
		{
			// Fields
			internal List<Vector4> positions; // 0x00
			internal List<int> frontPositions; // 0x08
			internal List<int> backPositions; // 0x10
			internal List<int> positionCounts; // 0x18
			internal int maxTrailCount; // 0x20
			internal int maxPositionsPerTrailCount; // 0x24
	
			// Methods
			internal void Allocate(); // 0x000000018D5478D8-0x000000018D547A14
		}
	
		public struct VelocityOverLifetimeModule // TypeDefIndex: 89634
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal VelocityOverLifetimeModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct LimitVelocityOverLifetimeModule // TypeDefIndex: 89635
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal LimitVelocityOverLifetimeModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct InheritVelocityModule // TypeDefIndex: 89636
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal InheritVelocityModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct LifetimeByEmitterSpeedModule // TypeDefIndex: 89637
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal LifetimeByEmitterSpeedModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct ForceOverLifetimeModule // TypeDefIndex: 89638
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ForceOverLifetimeModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct ColorOverLifetimeModule // TypeDefIndex: 89639
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ColorOverLifetimeModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct ColorBySpeedModule // TypeDefIndex: 89640
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ColorBySpeedModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct SizeOverLifetimeModule // TypeDefIndex: 89641
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal SizeOverLifetimeModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct SizeBySpeedModule // TypeDefIndex: 89642
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal SizeBySpeedModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct RotationOverLifetimeModule // TypeDefIndex: 89643
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal RotationOverLifetimeModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct RotationBySpeedModule // TypeDefIndex: 89644
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal RotationBySpeedModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct ExternalForcesModule // TypeDefIndex: 89645
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ExternalForcesModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct NoiseModule // TypeDefIndex: 89646
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal NoiseModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct LightsModule // TypeDefIndex: 89647
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal LightsModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct TrailModule // TypeDefIndex: 89648
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal TrailModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		public struct CustomDataModule // TypeDefIndex: 89649
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal CustomDataModule(ParticleSystem particleSystem); // 0x00000001878380EC-0x00000001878380F4
		}
	
		// Constructors
		public ParticleSystem(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
		public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color); // 0x000000018D545DEC-0x000000018D545EF4
		[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
		public void Emit(Particle particle); // 0x000000018D545EF4-0x000000018D545F08
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize", HasExplicitThis = true)]
		internal float GetParticleCurrentSize(ref Particle particle); // 0x000000018D54611C-0x000000018D546160
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize3D", HasExplicitThis = true)]
		internal Vector3 GetParticleCurrentSize3D(ref Particle particle); // 0x000000018D5460E8-0x000000018D54611C
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentColor", HasExplicitThis = true)]
		internal Color32 GetParticleCurrentColor(ref Particle particle); // 0x000000018D546070-0x000000018D546094
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleMeshIndex", HasExplicitThis = true)]
		internal int GetParticleMeshIndex(ref Particle particle); // 0x000000018D546160-0x000000018D5461A4
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", HasExplicitThis = true, ThrowsException = true)]
		public void SetParticles(out Particle[] particles, int size, int offset); // 0x000000018D546808-0x000000018D54686C
		public void SetParticles(out Particle[] particles, int size); // 0x000000018D5467EC-0x000000018D546808
		public void SetParticles(out Particle[] particles); // 0x000000018D546790-0x000000018D5467A0
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticlesWithNativeArray", HasExplicitThis = true, ThrowsException = true)]
		private void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset); // 0x000000018D54672C-0x000000018D546790
		public void SetParticles(out NativeArray<Particle> particles, int size, int offset); // 0x000000018D54686C-0x000000018D5468DC
		public void SetParticles(out NativeArray<Particle> particles, int size); // 0x000000018D5467C4-0x000000018D5467EC
		public void SetParticles(out NativeArray<Particle> particles); // 0x000000018D5467A0-0x000000018D5467C4
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = true, ThrowsException = true)]
		public int GetParticles([NotNull("ArgumentNullException")] out Particle[] particles, int size, int offset); // 0x000000018D5462D4-0x000000018D546338
		public int GetParticles(out Particle[] particles, int size); // 0x000000018D546338-0x000000018D546354
		public int GetParticles(out Particle[] particles); // 0x000000018D546208-0x000000018D546218
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticlesWithNativeArray", HasExplicitThis = true, ThrowsException = true)]
		private int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset); // 0x000000018D5461A4-0x000000018D546208
		public int GetParticles(out NativeArray<Particle> particles, int size, int offset); // 0x000000018D546264-0x000000018D5462D4
		public int GetParticles(out NativeArray<Particle> particles, int size); // 0x000000018D54623C-0x000000018D546264
		public int GetParticles(out NativeArray<Particle> particles); // 0x000000018D546218-0x000000018D54623C
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetCustomParticleData", HasExplicitThis = true, ThrowsException = true)]
		public void SetCustomParticleData([NotNull("ArgumentNullException")] List<Vector4> customData, ParticleSystemCustomData streamIndex); // 0x000000018D546640-0x000000018D546694
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetCustomParticleData", HasExplicitThis = true, ThrowsException = true)]
		public int GetCustomParticleData([NotNull("ArgumentNullException")] List<Vector4> customData, ParticleSystemCustomData streamIndex); // 0x000000018D545F24-0x000000018D545F78
		public PlaybackState GetPlaybackState(); // 0x000000018D546398-0x000000018D5463D4
		public void SetPlaybackState(PlaybackState playbackState); // 0x000000018D546920-0x000000018D546934
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetTrailData", HasExplicitThis = true)]
		private void GetTrailDataInternal(ref Trails trailData); // 0x000000018D5463D4-0x000000018D546418
		public Trails GetTrails(); // 0x000000018D546418-0x000000018D546490
		public int GetTrails(ref Trails trailData); // 0x000000018D546490-0x000000018D5464F0
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetTrailData", HasExplicitThis = true)]
		public void SetTrails(Trails trailData); // 0x000000018D546978-0x000000018D54698C
		[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = true)]
		public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart, [DefaultValue("true")] bool fixedTimeStep); // 0x000000018D54698C-0x000000018D5469F0
		public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart); // 0x000000018D546A18-0x000000018D546A34
		public void Simulate(float t, [DefaultValue("true")] bool withChildren); // 0x000000018D5469FC-0x000000018D546A18
		public void Simulate(float t); // 0x000000018D5469F0-0x000000018D5469FC
		[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = true)]
		public void Play([DefaultValue("true")] bool withChildren); // 0x0000000185E6E820-0x0000000185E6E870
		public void Play(); // 0x000000018783B070-0x000000018783B07C
		[FreeFunction(Name = "ParticleSystemScriptBindings::Pause", HasExplicitThis = true)]
		public void Pause([DefaultValue("true")] bool withChildren); // 0x000000018D54654C-0x000000018D546590
		public void Pause(); // 0x000000018D546540-0x000000018D54654C
		[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = true)]
		public void Stop([DefaultValue("true")] bool withChildren, [DefaultValue("ParticleSystemStopBehavior.StopEmitting")] ParticleSystemStopBehavior stopBehavior); // 0x0000000186198770-0x00000001861987D0
		public void Stop([DefaultValue("true")] bool withChildren); // 0x000000018D546A34-0x000000018D546A44
		public void Stop(); // 0x0000000187838108-0x000000018783811C
		[FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = true)]
		public void Clear([DefaultValue("true")] bool withChildren); // 0x00000001861DD220-0x00000001861DD270
		public void Clear(); // 0x00000001878380FC-0x0000000187838108
		[FreeFunction(Name = "ParticleSystemScriptBindings::IsAlive", HasExplicitThis = true)]
		public bool IsAlive([DefaultValue("true")] bool withChildren); // 0x000000018D5464F0-0x000000018D546534
		public bool IsAlive(); // 0x000000018D546534-0x000000018D546540
		[RequiredByNativeCode]
		public void Emit(int count); // 0x000000018D545F08-0x000000018D545F10
		[NativeName("SyncJobs()->Emit")]
		private void Emit_Internal(int count); // 0x000000018D545DAC-0x000000018D545DEC
		[NativeName("SyncJobs()->EmitParticlesExternal")]
		public void Emit(EmitParams emitParams, int count); // 0x000000018D545F10-0x000000018D545F24
		[NativeName("SyncJobs()->EmitParticleExternal")]
		private void EmitOld_Internal(ref Particle particle); // 0x000000018D545D14-0x000000018D545D58
		public void TriggerSubEmitter(int subEmitterIndex); // 0x000000018D546AA8-0x000000018D546AB4
		public void TriggerSubEmitter(int subEmitterIndex, ref Particle particle); // 0x000000018D546B04-0x000000018D546B84
		[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitterForParticle", HasExplicitThis = true)]
		internal void TriggerSubEmitterForParticle(int subEmitterIndex, Particle particle); // 0x000000018D546A94-0x000000018D546AA8
		[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitter", HasExplicitThis = true)]
		public void TriggerSubEmitter(int subEmitterIndex, List<Particle> particles); // 0x000000018D546AB4-0x000000018D546B04
		[FreeFunction(Name = "ParticleSystemGeometryJob::ResetPreMappedBufferMemory")]
		public static void ResetPreMappedBufferMemory(); // 0x000000018D546590-0x000000018D5465BC
		[FreeFunction(Name = "ParticleSystemGeometryJob::SetMaximumPreMappedBufferCounts")]
		public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount); // 0x000000018D5466EC-0x000000018D54672C
		[NativeName("SetUsesAxisOfRotation")]
		public void AllocateAxisOfRotationAttribute(); // 0x000000018D545C28-0x000000018D545C5C
		[NativeName("SetUsesMeshIndex")]
		public void AllocateMeshIndexAttribute(); // 0x000000018D545C9C-0x000000018D545CD0
		[NativeName("SetUsesCustomData")]
		public void AllocateCustomDataAttribute(ParticleSystemCustomData stream); // 0x000000018D545C5C-0x000000018D545C9C
		internal unsafe void* GetManagedJobData(); // 0x000000018D545F78-0x000000018D545FAC
		internal JobHandle GetManagedJobHandle(); // 0x000000018D545FF0-0x000000018D54601C
		internal void SetManagedJobHandle(JobHandle handle); // 0x000000018D5466D8-0x000000018D5466EC
		[FreeFunction("ScheduleManagedJob", ThrowsException = true)]
		internal static unsafe JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData); // 0x000000018D546610-0x000000018D546640
		[ThreadSafe]
		internal static unsafe void CopyManagedJobData(void* systemPtr, out NativeParticleData particleData); // 0x000000018D545CD0-0x000000018D545D14
		private void GetParticleCurrentSize3D_Injected(ref Particle particle, out Vector3 ret); // 0x000000018D546094-0x000000018D5460E8
		private void GetParticleCurrentColor_Injected(ref Particle particle, out Color32 ret); // 0x000000018D54601C-0x000000018D546070
		private void GetPlaybackState_Injected(out PlaybackState ret); // 0x000000018D546354-0x000000018D546398
		private void SetPlaybackState_Injected(ref PlaybackState playbackState); // 0x000000018D5468DC-0x000000018D546920
		private void SetTrails_Injected(ref Trails trailData); // 0x000000018D546934-0x000000018D546978
		private void Emit_Injected(ref EmitParams emitParams, int count); // 0x000000018D545D58-0x000000018D545DAC
		private void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref Particle particle); // 0x000000018D546A44-0x000000018D546A94
		private void GetManagedJobHandle_Injected(out JobHandle ret); // 0x000000018D545FAC-0x000000018D545FF0
		private void SetManagedJobHandle_Injected(ref JobHandle handle); // 0x000000018D546694-0x000000018D5466D8
		private static unsafe void ScheduleManagedJob_Injected(ref JobsUtility.JobScheduleParameters parameters, void* additionalData, out JobHandle ret); // 0x000000018D5465BC-0x000000018D546610
	}

	public static class ParticlePhysicsExtensions // TypeDefIndex: 89651
	{
		// Extension methods
		public static int GetSafeCollisionEventSize(this ParticleSystem ps); // 0x000000018D5437EC-0x000000018D5437F8
		public static int GetCollisionEvents(this ParticleSystem ps, GameObject go, List<ParticleCollisionEvent> collisionEvents); // 0x000000018D5437E0-0x000000018D5437EC
	}

	public enum ParticleSystemRenderMode // TypeDefIndex: 89652
	{
		Billboard = 0,
		Stretch = 1,
		HorizontalBillboard = 2,
		VerticalBillboard = 3,
		Mesh = 4,
		None = 5
	}

	public enum ParticleSystemMeshDistribution // TypeDefIndex: 89653
	{
		UniformRandom = 0,
		NonUniformRandom = 1
	}

	public enum ParticleSystemSortMode // TypeDefIndex: 89654
	{
		None = 0,
		Distance = 1,
		OldestInFront = 2,
		YoungestInFront = 3,
		Depth = 4
	}

	public enum ParticleSystemRenderSpace // TypeDefIndex: 89655
	{
		View = 0,
		World = 1,
		Local = 2,
		Facing = 3,
		Velocity = 4
	}

	public enum ParticleSystemCurveMode // TypeDefIndex: 89656
	{
		Constant = 0,
		Curve = 1,
		TwoCurves = 2,
		TwoConstants = 3
	}

	public enum ParticleSystemGradientMode // TypeDefIndex: 89657
	{
		Color = 0,
		Gradient = 1,
		TwoColors = 2,
		TwoGradients = 3,
		RandomColor = 4
	}

	public enum ParticleSystemShapeType // TypeDefIndex: 89658
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

	public enum ParticleSystemSimulationSpace // TypeDefIndex: 89659
	{
		Local = 0,
		World = 1,
		Custom = 2
	}

	public enum ParticleSystemStopBehavior // TypeDefIndex: 89660
	{
		StopEmittingAndClear = 0,
		StopEmitting = 1
	}

	public enum ParticleSystemScalingMode // TypeDefIndex: 89661
	{
		Hierarchy = 0,
		Local = 1,
		Shape = 2
	}

	[UsedByNativeCode]
	public enum ParticleSystemVertexStream // TypeDefIndex: 89662
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

	public enum ParticleSystemCustomData // TypeDefIndex: 89663
	{
		Custom1 = 0,
		Custom2 = 1
	}

	public enum ParticleSystemTrailTextureMode // TypeDefIndex: 89664
	{
		Stretch = 0,
		Tile = 1,
		DistributePerSegment = 2,
		RepeatPerSegment = 3
	}

	public enum ParticleSystemForceFieldShape // TypeDefIndex: 89665
	{
		Sphere = 0,
		Hemisphere = 1,
		Cylinder = 2,
		Box = 3
	}

	[Flags]
	[Obsolete("ParticleSystemVertexStreams is deprecated. Please use ParticleSystemVertexStream instead.", false)]
	public enum ParticleSystemVertexStreams // TypeDefIndex: 89666
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

	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
	[RequireComponent(typeof(Transform))]
	public sealed class ParticleSystemRenderer : Renderer // TypeDefIndex: 89667
	{
		// Properties
		[NativeName("RenderAlignment")]
		public ParticleSystemRenderSpace alignment { get; set; } // 0x000000018D5450D4-0x000000018D545108 0x000000018D5455F8-0x000000018D545638
		public ParticleSystemRenderMode renderMode { get; set; } // 0x000000018D54548C-0x000000018D5454C0 0x000000018D545A98-0x000000018D545AD8
		public ParticleSystemMeshDistribution meshDistribution { get; set; } // 0x000000018D54534C-0x000000018D545380 0x000000018D5458AC-0x000000018D5458EC
		public ParticleSystemSortMode sortMode { get; set; } // 0x000000018D545528-0x000000018D54555C 0x000000018D545B60-0x000000018D545BA0
		public float lengthScale { get; set; } // 0x000000018D54527C-0x000000018D5452B0 0x000000018D5457E4-0x000000018D545828
		public float velocityScale { get; set; } // 0x000000018D5455C4-0x000000018D5455F8 0x000000018D545BE4-0x000000018D545C28
		public float cameraVelocityScale { get; set; } // 0x000000018D54513C-0x000000018D545170 0x000000018D54567C-0x000000018D5456C0
		public float normalDirection { get; set; } // 0x000000018D5453E8-0x000000018D54541C 0x000000018D545974-0x000000018D5459B8
		public float shadowBias { get; set; } // 0x000000018D5454F4-0x000000018D545528 0x000000018D545B1C-0x000000018D545B60
		public float minParticleSize { get; set; } // 0x000000018D5453B4-0x000000018D5453E8 0x000000018D545930-0x000000018D545974
		public float maxParticleSize { get; set; } // 0x000000018D5452E4-0x000000018D545318 0x000000018D545868-0x000000018D5458AC
		public Vector3 pivot { get; set; } // 0x000000018D545460-0x000000018D54548C 0x000000018D545A40-0x000000018D545A54
		public Vector3 flip { get; set; } // 0x000000018D54521C-0x000000018D545248 0x000000018D54578C-0x000000018D5457A0
		public SpriteMaskInteraction maskInteraction { get; set; } // 0x000000018D5452B0-0x000000018D5452E4 0x000000018D545828-0x000000018D545868
		public Material trailMaterial { get; set; } // 0x000000018D54555C-0x000000018D545590 0x000000018D545BA0-0x000000018D545BE4
		internal Material oldTrailMaterial { set; } // 0x000000018D5459B8-0x000000018D5459FC
		public bool enableGPUInstancing { get; set; } // 0x000000018D545170-0x000000018D5451A4 0x000000018D5456C0-0x000000018D545704
		public bool allowRoll { get; set; } // 0x000000018D545108-0x000000018D54513C 0x000000018D545638-0x000000018D54567C
		public bool freeformStretching { get; set; } // 0x000000018D545248-0x000000018D54527C 0x000000018D5457A0-0x000000018D5457E4
		public bool rotateWithStretchDirection { get; set; } // 0x000000018D5454C0-0x000000018D5454F4 0x000000018D545AD8-0x000000018D545B1C
		public bool enableHGGPUInstancing { get; set; } // 0x000000018D5451A4-0x000000018D5451D8 0x000000018D545704-0x000000018D545748
		public bool renderInUI { [NativeName("GetRenderInUI")] get; [NativeName("SetRenderInUI")] set; } // 0x000000018531C720-0x000000018531C760 0x000000018D545A54-0x000000018D545A98
		public int uiSortingOrder { [NativeName("GetUISortingOrder")] get; [NativeName("SetUISortingOrder")] set; } // 0x000000018D545590-0x000000018D5455C4 0x000000018531C6D0-0x000000018531C720
		public Mesh mesh { [FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMesh", HasExplicitThis = true)] get; [FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMesh", HasExplicitThis = true)] set; } // 0x000000018D545380-0x000000018D5453B4 0x000000018D5458EC-0x000000018D545930
		public int meshCount { get; } // 0x000000018D545318-0x000000018D54534C 
		public int activeVertexStreamsCount { get; } // 0x000000018D5450A0-0x000000018D5450D4 
		public bool DisableCutOutAnimation { get; } // 0x000000018D54506C-0x000000018D5450A0 
		public int CutOutMode { get; } // 0x000000018D545038-0x000000018D54506C 
		public int CutOutDataSize { get; } // 0x000000018D545004-0x000000018D545038 
	
		// Constructors
		public ParticleSystemRenderer(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		[Obsolete("EnableVertexStreams is deprecated.Use SetActiveVertexStreams instead.", false)]
		public void EnableVertexStreams(ParticleSystemVertexStreams streams); // 0x000000018D5445B8-0x000000018D5445C4
		[Obsolete("DisableVertexStreams is deprecated.Use SetActiveVertexStreams instead.", false)]
		public void DisableVertexStreams(ParticleSystemVertexStreams streams); // 0x000000018D5445AC-0x000000018D5445B8
		[Obsolete("AreVertexStreamsEnabled is deprecated.Use GetActiveVertexStreams instead.", false)]
		public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams); // 0x000000018D544430-0x000000018D54444C
		[Obsolete("GetEnabledVertexStreams is deprecated.Use GetActiveVertexStreams instead.", false)]
		public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams); // 0x000000018D544608-0x000000018D544614
		[Obsolete("Internal_SetVertexStreams is deprecated.Use SetActiveVertexStreams instead.", false)]
		internal void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled); // 0x000000018D5448F4-0x000000018D544ED8
		[Obsolete("Internal_GetVertexStreams is deprecated.Use GetActiveVertexStreams instead.", false)]
		internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams); // 0x000000018D54469C-0x000000018D5448F4
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = true)]
		[RequiredByNativeCode]
		public int GetMeshes([NotNull("ArgumentNullException")] out Mesh[] meshes); // 0x000000018D544658-0x000000018D54469C
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshes", HasExplicitThis = true)]
		public void SetMeshes([NotNull("ArgumentNullException")] Mesh[] meshes, int size); // 0x000000018D544F90-0x000000018D544FE4
		public void SetMeshes(Mesh[] meshes); // 0x000000018D544FE4-0x000000018D545004
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshWeightings", HasExplicitThis = true)]
		public int GetMeshWeightings([NotNull("ArgumentNullException")] out float[] weightings); // 0x000000018D544614-0x000000018D544658
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshWeightings", HasExplicitThis = true)]
		public void SetMeshWeightings([NotNull("ArgumentNullException")] float[] weightings, int size); // 0x000000018D544F1C-0x000000018D544F70
		public void SetMeshWeightings(float[] weightings); // 0x000000018D544F70-0x000000018D544F90
		public void BakeMesh(Mesh mesh, bool useTransform = false /* Metadata: 0x0264A2D6 */); // 0x000000018D5444B0-0x000000018D5444FC
		public void BakeMesh([NotNull("ArgumentNullException")] Mesh mesh, [NotNull("ArgumentNullException")] Camera camera, bool useTransform = false /* Metadata: 0x0264A2D7 */); // 0x000000018D54444C-0x000000018D5444B0
		public void BakeTrailsMesh(Mesh mesh, bool useTransform = false /* Metadata: 0x0264A2D8 */); // 0x000000018D5444FC-0x000000018D544548
		public void BakeTrailsMesh([NotNull("ArgumentNullException")] Mesh mesh, [NotNull("ArgumentNullException")] Camera camera, bool useTransform = false /* Metadata: 0x0264A2D9 */); // 0x000000018D544548-0x000000018D5445AC
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetActiveVertexStreams", HasExplicitThis = true)]
		public void SetActiveVertexStreams([NotNull("ArgumentNullException")] List<ParticleSystemVertexStream> streams); // 0x000000018D544ED8-0x000000018D544F1C
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetActiveVertexStreams", HasExplicitThis = true)]
		public void GetActiveVertexStreams([NotNull("ArgumentNullException")] List<ParticleSystemVertexStream> streams); // 0x000000018D5445C4-0x000000018D544608
		private void get_pivot_Injected(out Vector3 ret); // 0x000000018D54541C-0x000000018D545460
		private void set_pivot_Injected(ref Vector3 value); // 0x000000018D5459FC-0x000000018D545A40
		private void get_flip_Injected(out Vector3 ret); // 0x000000018D5451D8-0x000000018D54521C
		private void set_flip_Injected(ref Vector3 value); // 0x000000018D545748-0x000000018D54578C
	}

	[RequiredByNativeCode(Optional = true)]
	public struct ParticleCollisionEvent // TypeDefIndex: 89668
	{
		// Fields
		internal Vector3 m_Intersection; // 0x00
		internal Vector3 m_Normal; // 0x0C
		internal Vector3 m_Velocity; // 0x18
		internal int m_ColliderInstanceID; // 0x24
	
		// Properties
		public Vector3 intersection { get; } // 0x000000018725FDC0-0x000000018725FDE0 
		public Vector3 normal { get; } // 0x000000018725FDA0-0x000000018725FDC0 
		public Vector3 velocity { get; } // 0x00000001872601B0-0x00000001872601D0 
		public Component colliderComponent { get; } // 0x000000018D5437D4-0x000000018D5437E0 
	
		// Methods
		[FreeFunction(Name = "ParticleSystemScriptBindings::InstanceIDToColliderComponent")]
		private static Component InstanceIDToColliderComponent(int instanceID); // 0x000000018D5437A0-0x000000018D5437D4
	}

	internal class ParticleSystemExtensionsImpl // TypeDefIndex: 89669
	{
		// Methods
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetSafeCollisionEventSize")]
		internal static int GetSafeCollisionEventSize([NotNull("ArgumentNullException")] ParticleSystem ps); // 0x000000018D54384C-0x000000018D543880
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetCollisionEvents")]
		internal static int GetCollisionEvents([NotNull("ArgumentNullException")] ParticleSystem ps, [NotNull("ArgumentNullException")] GameObject go, [NotNull("ArgumentNullException")] List<ParticleCollisionEvent> collisionEvents); // 0x000000018D5437F8-0x000000018D54384C
	}

	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystemForceField.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystemForceFieldManager.h")]
	[RequireComponent(typeof(Transform))]
	public class ParticleSystemForceField : Behaviour // TypeDefIndex: 89670
	{
		// Properties
		[NativeName("ForceShape")]
		public ParticleSystemForceFieldShape shape { get; set; } // 0x000000018D543D18-0x000000018D543D4C 0x000000018D5442B8-0x000000018D5442F8
		public float startRange { get; set; } // 0x000000018D543D4C-0x000000018D543D80 0x000000018D5442F8-0x000000018D54433C
		public float endRange { get; set; } // 0x000000018D543A50-0x000000018D543A84 0x000000018D543FFC-0x000000018D544040
		public float length { get; set; } // 0x000000018D543B2C-0x000000018D543B60 0x000000018D5440DC-0x000000018D544120
		public float gravityFocus { get; set; } // 0x000000018D543A84-0x000000018D543AB8 0x000000018D544040-0x000000018D544084
		public Vector2 rotationRandomness { get; set; } // 0x000000018D543C80-0x000000018D543CA4 0x000000018D544244-0x000000018D544260
		public bool multiplyDragByParticleSize { get; set; } // 0x000000018D543B60-0x000000018D543B94 0x000000018D544120-0x000000018D544164
		public bool multiplyDragByParticleVelocity { get; set; } // 0x000000018D543B94-0x000000018D543BC8 0x000000018D544164-0x000000018D5441A8
		public Texture3D vectorField { get; set; } // 0x000000018D543E68-0x000000018D543E9C 0x000000018D5443EC-0x000000018D544430
		public ParticleSystem.MinMaxCurve directionX { get; set; } // 0x000000018D5438C4-0x000000018D5438F4 0x000000018D543EE0-0x000000018D543EF4
		public ParticleSystem.MinMaxCurve directionY { get; set; } // 0x000000018D543938-0x000000018D543968 0x000000018D543F38-0x000000018D543F4C
		public ParticleSystem.MinMaxCurve directionZ { get; set; } // 0x000000018D5439AC-0x000000018D5439DC 0x000000018D543F90-0x000000018D543FA4
		public ParticleSystem.MinMaxCurve gravity { get; set; } // 0x000000018D543AFC-0x000000018D543B2C 0x000000018D5440C8-0x000000018D5440DC
		public ParticleSystem.MinMaxCurve rotationSpeed { get; set; } // 0x000000018D543CE8-0x000000018D543D18 0x000000018D5442A4-0x000000018D5442B8
		public ParticleSystem.MinMaxCurve rotationAttraction { get; set; } // 0x000000018D543C0C-0x000000018D543C3C 0x000000018D5441EC-0x000000018D544200
		public ParticleSystem.MinMaxCurve drag { get; set; } // 0x000000018D543A20-0x000000018D543A50 0x000000018D543FE8-0x000000018D543FFC
		public ParticleSystem.MinMaxCurve vectorFieldSpeed { get; set; } // 0x000000018D543E38-0x000000018D543E68 0x000000018D5443D8-0x000000018D5443EC
		public ParticleSystem.MinMaxCurve vectorFieldAttraction { get; set; } // 0x000000018D543DC4-0x000000018D543DF4 0x000000018D544380-0x000000018D544394
	
		// Constructors
		public ParticleSystemForceField(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void get_rotationRandomness_Injected(out Vector2 ret); // 0x000000018D543C3C-0x000000018D543C80
		private void set_rotationRandomness_Injected(ref Vector2 value); // 0x000000018D544200-0x000000018D544244
		private void get_directionX_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018D543880-0x000000018D5438C4
		private void set_directionX_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018D543E9C-0x000000018D543EE0
		private void get_directionY_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018D5438F4-0x000000018D543938
		private void set_directionY_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018D543EF4-0x000000018D543F38
		private void get_directionZ_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018D543968-0x000000018D5439AC
		private void set_directionZ_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018D543F4C-0x000000018D543F90
		private void get_gravity_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018D543AB8-0x000000018D543AFC
		private void set_gravity_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018D544084-0x000000018D5440C8
		private void get_rotationSpeed_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018D543CA4-0x000000018D543CE8
		private void set_rotationSpeed_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018D544260-0x000000018D5442A4
		private void get_rotationAttraction_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018D543BC8-0x000000018D543C0C
		private void set_rotationAttraction_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018D5441A8-0x000000018D5441EC
		private void get_drag_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018D5439DC-0x000000018D543A20
		private void set_drag_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018D543FA4-0x000000018D543FE8
		private void get_vectorFieldSpeed_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018D543DF4-0x000000018D543E38
		private void set_vectorFieldSpeed_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018D544394-0x000000018D5443D8
		private void get_vectorFieldAttraction_Injected(out ParticleSystem.MinMaxCurve ret); // 0x000000018D543D80-0x000000018D543DC4
		private void set_vectorFieldAttraction_Injected(ref ParticleSystem.MinMaxCurve value); // 0x000000018D54433C-0x000000018D544380
	}

	[NativeHeader("Modules/ParticleSystem/HGParticle/HGParticleMeshInstanceRenderer.h")]
	[RequireComponent(typeof(ParticleSystemRenderer))]
	[RequiredByNativeCode]
	internal sealed class HGParticleMeshInstanceRenderer : Renderer // TypeDefIndex: 89671
	{
	}
}

namespace UnityEngine.ParticleSystemJobs
{
	internal struct NativeParticleData // TypeDefIndex: 89674
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
		internal struct Array3 // TypeDefIndex: 89672
		{
			// Fields
			internal unsafe float* x; // 0x00
			internal unsafe float* y; // 0x08
			internal unsafe float* z; // 0x10
		}
	
		internal struct Array4 // TypeDefIndex: 89673
		{
			// Fields
			internal unsafe float* x; // 0x00
			internal unsafe float* y; // 0x08
			internal unsafe float* z; // 0x10
			internal unsafe float* w; // 0x18
		}
	}
}
