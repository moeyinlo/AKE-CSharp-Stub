/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine.ParticleSystemJobs;

// Image 73: UnityEngine.ParticleSystemModule.dll - Assembly: UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59752-59816

namespace UnityEngine
{
	public sealed class ParticleSystem : Component // TypeDefIndex: 59792
	{
		// Properties
		public float startDelay { get => default; set {} } // 0x000000018BF2D398-0x000000018BF2D3A0 0x000000018BF2CF74-0x000000018BF2CF7C
		public bool loop { get => default; set {} } // 0x000000018BF2D3E4-0x000000018BF2D3EC 0x000000018BF2CFB0-0x000000018BF2CFB8
		public bool playOnAwake { get => default; set {} } // 0x000000018BF2D430-0x000000018BF2D438 0x000000018BF2CFEC-0x000000018BF2CFF4
		public float duration { get => default; } // 0x000000018BF2D47C-0x000000018BF2D484 
		public float playbackSpeed { get => default; set {} } // 0x000000018BF2CDE0-0x000000018BF2CE18 0x000000018BF2D250-0x000000018BF2D264
		public bool enableEmission { get => default; set {} } // 0x000000018BF2CCA4-0x000000018BF2CCAC 0x000000018BF2D124-0x000000018BF2D12C
		public float emissionRate { get => default; set {} } // 0x000000018BF2CD94-0x000000018BF2CD9C 0x000000018BF2D204-0x000000018BF2D20C
		public float startSpeed { get => default; set {} } // 0x000000018646FE34-0x000000018646FE3C 0x000000018646FE18-0x000000018646FE20
		public float startSize { get => default; set {} } // 0x000000018BF2CD58-0x000000018BF2CD60 0x000000018646FE4C-0x000000018646FE54
		public Color startColor { get => default; set {} } // 0x000000018BF2CD1C-0x000000018BF2CD24 0x000000018BF2D1BC-0x000000018BF2D1C4
		public float startRotation { get => default; set {} } // 0x000000018646FE44-0x000000018646FE4C 0x000000018646FE54-0x000000018646FE5C
		public Vector3 startRotation3D { get => default; set {} } // 0x0000000185F569E0-0x0000000185F56A20 0x0000000185F37410-0x0000000185F37460
		public float startLifetime { get => default; set {} } // 0x000000018BF2CCAC-0x000000018BF2CCE0 0x000000018BF2D12C-0x000000018BF2D170
		public float gravityModifier { get => default; set {} } // 0x000000018BF2CE18-0x000000018BF2CE4C 0x000000018BF2D264-0x000000018BF2D2A8
		public int maxParticles { get => default; set {} } // 0x000000018BF2CE90-0x000000018BF2CED4 0x000000018BF2D2FC-0x000000018BF2D340
		public ParticleSystemSimulationSpace simulationSpace { get => default; set {} } // 0x000000018BF2CE54-0x000000018BF2CE88 0x000000018BF2D2B0-0x000000018BF2D2F4
		public ParticleSystemScalingMode scalingMode { get => default; set {} } // 0x000000018BF2D06C-0x000000018BF2D0B0 0x000000018BF2D030-0x000000018BF2D064
		public bool automaticCullingEnabled { get => default; } // 0x000000018BF2D4D0-0x000000018BF2D514 
		public bool isPlaying { get => default; } // 0x000000018BF2CFF4-0x000000018BF2D028 
		public bool isEmitting { get => default; } // 0x000000018BF2D484-0x000000018BF2D4C8 
		public bool isStopped { get => default; } // 0x000000018BF2CF04-0x000000018BF2CF38 
		public bool isPaused { get => default; } // 0x000000018BF2D354-0x000000018BF2D398 
		public int particleCount { get => default; } // 0x000000018BF2CF40-0x000000018BF2CF74 
		public float time { get => default; set {} } // 0x000000018BF2D3A0-0x000000018BF2D3E4 0x000000018BF2CF7C-0x000000018BF2CFB0
		public uint randomSeed { get => default; set {} } // 0x000000018BF2D3EC-0x000000018BF2D430 0x000000018BF2CFB8-0x000000018BF2CFEC
		public bool useAutoRandomSeed { get => default; set {} } // 0x000000018BF2D438-0x000000018BF2D47C 0x000000018BF2CD9C-0x000000018BF2CDE0
		public bool proceduralSimulationSupported { get => default; } // 0x000000018BF2D20C-0x000000018BF2D250 
		public MainModule main { get => default; } // 0x000000018BF3139C-0x000000018BF313EC 
		public EmissionModule emission { get => default; } // 0x0000000185149440-0x0000000185149480 
		public ShapeModule shape { get => default; } // 0x0000000185FE64F0-0x0000000185FE6500 
		public VelocityOverLifetimeModule velocityOverLifetime { get => default; } // 0x0000000185FC7990-0x0000000185FC79A0 
		public LimitVelocityOverLifetimeModule limitVelocityOverLifetime { get => default; } // 0x0000000185FE6720-0x0000000185FE6730 
		public InheritVelocityModule inheritVelocity { get => default; } // 0x0000000185FE8CF0-0x0000000185FE8D00 
		public LifetimeByEmitterSpeedModule lifetimeByEmitterSpeed { get => default; } // 0x0000000185FE68F0-0x0000000185FE6900 
		public ForceOverLifetimeModule forceOverLifetime { get => default; } // 0x0000000185FE8CF0-0x0000000185FE8D00 
		public ColorOverLifetimeModule colorOverLifetime { get => default; } // 0x0000000183B7E5A0-0x0000000183B7E5B0 
		public ColorBySpeedModule colorBySpeed { get => default; } // 0x0000000185FC7990-0x0000000185FC79A0 
		public SizeOverLifetimeModule sizeOverLifetime { get => default; } // 0x00000001851493D0-0x0000000185149440 
		public SizeBySpeedModule sizeBySpeed { get => default; } // 0x000000018BF2D51C-0x000000018BF2D56C 
		public RotationOverLifetimeModule rotationOverLifetime { get => default; } // 0x0000000185FBB620-0x0000000185FBB630 
		public RotationBySpeedModule rotationBySpeed { get => default; } // 0x0000000185FB30E0-0x0000000185FB30F0 
		public ExternalForcesModule externalForces { get => default; } // 0x0000000185FE8B20-0x0000000185FE8B30 
		public NoiseModule noise { get => default; } // 0x0000000185FBB620-0x0000000185FBB630 
		public CollisionModule collision { get => default; } // 0x000000018BF2D56C-0x000000018BF2D5E8 
		public TriggerModule trigger { get => default; } // 0x000000018BF3171C-0x000000018BF31858 
		public SubEmittersModule subEmitters { get => default; } // 0x000000018646FE2C-0x000000018646FE34 
		public TextureSheetAnimationModule textureSheetAnimation { get => default; } // 0x000000018646FE2C-0x000000018646FE34 
		public LightsModule lights { get => default; } // 0x000000018646FE2C-0x000000018646FE34 
		public TrailModule trails { get => default; } // 0x000000018646FE2C-0x000000018646FE34 
		public CustomDataModule customData { get => default; } // 0x000000018646FE2C-0x000000018646FE34 
	
		// Nested types
		public struct MainModule // TypeDefIndex: 59753
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public float duration { get => default; set {} } // 0x000000018BF2FCC4-0x000000018BF2FCD8 0x000000018BF30D14-0x000000018BF30D44
			public bool loop { get => default; set {} } // 0x000000018BF311D4-0x000000018BF31204 0x000000018BF30AF0-0x000000018BF30B20
			public float startDelayMultiplier { get => default; set {} } // 0x000000018BF30FD0-0x000000018BF31008 0x000000018BF30B84-0x000000018BF30BB4
			public MinMaxCurve startLifetime { get => default; set {} } // 0x000000018BF31040-0x000000018BF31078 0x000000018BF30960-0x000000018BF30990
			public float startLifetimeMultiplier { get => default; set {} } // 0x000000018BF30BB4-0x000000018BF30BE4 0x000000018BF31078-0x000000018BF310A8
			public MinMaxCurve startSpeed { get => default; } // 0x000000018BF309C0-0x000000018BF309F0 
			public float startSpeedMultiplier { get => default; set {} } // 0x000000018BF30F68-0x000000018BF30FA0 0x000000018BF30990-0x000000018BF309C0
			public float startSizeMultiplier { get => default; set {} } // 0x000000018BF30F0C-0x000000018BF30F68 0x000000018BF30E74-0x000000018BF30EA4
			public float startRotationMultiplier { get => default; set {} } // 0x000000018BF312E4-0x000000018BF31314 0x000000018BF30E44-0x000000018BF30E74
			public float startRotationXMultiplier { get => default; set {} } // 0x000000018BF312B4-0x000000018BF312E4 0x000000018BF30CAC-0x000000018BF30D14
			public float startRotationYMultiplier { get => default; set {} } // 0x000000018BF31158-0x000000018BF311D4 0x000000018BF30E14-0x000000018BF30E44
			public float startRotationZMultiplier { get => default; set {} } // 0x000000018BF31284-0x000000018BF312B4 0x000000018BF30D74-0x000000018BF30E14
			public MinMaxGradient startColor { get => default; set {} } // 0x000000018BF31234-0x000000018BF31284 0x000000018BF30D44-0x000000018BF30D74
			public float gravityModifierMultiplier { get => default; set {} } // 0x000000018BF31204-0x000000018BF31234 0x000000018BF309F0-0x000000018BF30A20
			public ParticleSystemSimulationSpace simulationSpace { get => default; set {} } // 0x000000018BF30FA0-0x000000018BF30FD0 0x000000018BF30B20-0x000000018BF30B50
			public float simulationSpeed { get => default; set {} } // 0x000000018BF31008-0x000000018BF31040 0x000000018BF30C7C-0x000000018BF30CAC
			public ParticleSystemScalingMode scalingMode { get => default; set {} } // 0x000000018BF31120-0x000000018BF31158 0x000000018BF30C4C-0x000000018BF30C7C
			public bool playOnAwake { get => default; set {} } // 0x000000018BF310E8-0x000000018BF31120 0x000000018BF30954-0x000000018BF30960
			public int maxParticles { get => default; set {} } // 0x000000018BF30A88-0x000000018BF30ABC 0x000000018BF30A20-0x000000018BF30A54
	
			// Constructors
			internal MainModule(ParticleSystem particleSystem) : this() {
				m_ParticleSystem = default;
			} // 0x000000018BF2FBBC-0x000000018BF2FCC4
	
			// Methods
			private static float get_duration_Injected(ref MainModule _unity_self) => default; // 0x000000018BF30ABC-0x000000018BF30AF0
			private static void set_duration_Injected(ref MainModule _unity_self, float value) {} // 0x000000018BF30A54-0x000000018BF30A88
			private static bool get_loop_Injected(ref MainModule _unity_self) => default; // 0x000000018BF30B50-0x000000018BF30B84
			private static void set_loop_Injected(ref MainModule _unity_self, bool value) {} // 0x000000018BF30EA4-0x000000018BF30ED8
			private static float get_startDelayMultiplier_Injected(ref MainModule _unity_self) => default; // 0x000000018BF31314-0x000000018BF31358
			private static void set_startDelayMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x000000018BF30C18-0x000000018BF30C4C
			private static void get_startLifetime_Injected(ref MainModule _unity_self, out MinMaxCurve ret) {
				ret = default;
			} // 0x000000018BF310A8-0x000000018BF310E8
			private static void set_startLifetime_Injected(ref MainModule _unity_self, ref MinMaxCurve value) {} // 0x000000018BF30ED8-0x000000018BF30F0C
			private static float get_startLifetimeMultiplier_Injected(ref MainModule _unity_self) => default; // 0x000000018BF31358-0x000000018BF3139C
			private static void set_startLifetimeMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x000000018BF30BE4-0x000000018BF30C18
			private static void get_startSpeed_Injected(ref MainModule _unity_self, out MinMaxCurve ret) {
				ret = default;
			} // 0x000000018BF2FEEC-0x000000018BF2FF30
			private static float get_startSpeedMultiplier_Injected(ref MainModule _unity_self) => default; // 0x000000018BF2FEB8-0x000000018BF2FEEC
			private static void set_startSpeedMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x000000018BF2FE40-0x000000018BF2FE64
			private static float get_startSizeMultiplier_Injected(ref MainModule _unity_self) => default; // 0x000000018BF2FF30-0x000000018BF2FF74
			private static void set_startSizeMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x000000018BF305D8-0x000000018BF3063C
			private static float get_startRotationMultiplier_Injected(ref MainModule _unity_self) => default; // 0x000000018BF305BC-0x000000018BF305D8
			private static void set_startRotationMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x000000018BF30560-0x000000018BF30570
			private static float get_startRotationXMultiplier_Injected(ref MainModule _unity_self) => default; // 0x000000018BF304FC-0x000000018BF30560
			private static void set_startRotationXMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x000000018BF3063C-0x000000018BF306AC
			private static float get_startRotationYMultiplier_Injected(ref MainModule _unity_self) => default; // 0x000000018BF30594-0x000000018BF305BC
			private static void set_startRotationYMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x000000018BF30570-0x000000018BF30594
			private static float get_startRotationZMultiplier_Injected(ref MainModule _unity_self) => default; // 0x000000018BF300A4-0x000000018BF30108
			private static void set_startRotationZMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x000000018BF30108-0x000000018BF30124
			private static void get_startColor_Injected(ref MainModule _unity_self, out MinMaxGradient ret) {
				ret = default;
			} // 0x000000018BF2FFD8-0x000000018BF2FFE8
			private static void set_startColor_Injected(ref MainModule _unity_self, ref MinMaxGradient value) {} // 0x000000018BF2FF74-0x000000018BF2FFD8
			private static float get_gravityModifierMultiplier_Injected(ref MainModule _unity_self) => default; // 0x000000018BF30034-0x000000018BF300A4
			private static void set_gravityModifierMultiplier_Injected(ref MainModule _unity_self, float value) {} // 0x000000018BF3000C-0x000000018BF30034
			private static ParticleSystemSimulationSpace get_simulationSpace_Injected(ref MainModule _unity_self) => default; // 0x000000018BF2FFE8-0x000000018BF3000C
			private static void set_simulationSpace_Injected(ref MainModule _unity_self, ParticleSystemSimulationSpace value) {} // 0x000000018BF30410-0x000000018BF30464
			private static float get_simulationSpeed_Injected(ref MainModule _unity_self) => default; // 0x000000018BF2FCF4-0x000000018BF2FD48
			private static void set_simulationSpeed_Injected(ref MainModule _unity_self, float value) {} // 0x000000018BF30168-0x000000018BF301A4
			private static ParticleSystemScalingMode get_scalingMode_Injected(ref MainModule _unity_self) => default; // 0x000000018BF306F0-0x000000018BF30704
			private static void set_scalingMode_Injected(ref MainModule _unity_self, ParticleSystemScalingMode value) {} // 0x000000018BF301A4-0x000000018BF301E8
			private static bool get_playOnAwake_Injected(ref MainModule _unity_self) => default; // 0x000000018BF301E8-0x000000018BF30260
			private static void set_playOnAwake_Injected(ref MainModule _unity_self, bool value) {} // 0x000000018BF30260-0x000000018BF302C0
			private static int get_maxParticles_Injected(ref MainModule _unity_self) => default; // 0x000000018BF30748-0x000000018BF3075C
			private static void set_maxParticles_Injected(ref MainModule _unity_self, int value) {} // 0x000000018BF3075C-0x000000018BF307C0
		}
	
		public struct EmissionModule // TypeDefIndex: 59754
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public bool enabled { get => default; set {} } // 0x000000018BF307CC-0x000000018BF307E8 0x000000018BF307C0-0x000000018BF307CC
			public MinMaxCurve rateOverTime { get => default; set {} } // 0x0000000185628CE0-0x0000000185628D30 0x00000001864736BC-0x00000001864736C8
			public float rateOverTimeMultiplier { get => default; } // 0x000000018BF3031C-0x000000018BF30360 
	
			// Constructors
			internal EmissionModule(ParticleSystem particleSystem) : this() {
				m_ParticleSystem = default;
			} // 0x000000018BF307E8-0x000000018BF30804
	
			// Methods
			private static bool get_enabled_Injected(ref EmissionModule _unity_self) => default; // 0x000000018BF30310-0x000000018BF3031C
			private static void set_enabled_Injected(ref EmissionModule _unity_self, bool value) {} // 0x000000018519C870-0x000000018519C8D0
			private static void get_rateOverTime_Injected(ref EmissionModule _unity_self, out MinMaxCurve ret) {
				ret = default;
			} // 0x000000018BF30804-0x000000018BF30814
			private static void set_rateOverTime_Injected(ref EmissionModule _unity_self, ref MinMaxCurve value) {} // 0x0000000186471914-0x0000000186471928
			private static float get_rateOverTimeMultiplier_Injected(ref EmissionModule _unity_self) => default; // 0x000000018521D300-0x000000018521D350
		}
	
		public struct ShapeModule // TypeDefIndex: 59755
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public bool enabled { set {} } // 0x000000018BF302C0-0x000000018BF30304
			public ParticleSystemShapeType shapeType { set {} } // 0x000000018BF30304-0x000000018BF30310
			public float radius { set {} } // 0x000000018BF2FCD8-0x000000018BF2FCE0
			public Mesh mesh { set {} } // 0x000000018BF2FB7C-0x000000018BF2FBBC
			public MeshRenderer meshRenderer { set {} } // 0x000000018BF2FCE0-0x000000018BF2FCF4
			public SkinnedMeshRenderer skinnedMeshRenderer { set {} } // 0x000000018BF2FAE4-0x000000018BF2FB28
			public float textureClipThreshold { set {} } // 0x000000018BF30878-0x000000018BF30884
			public float textureClipThresholdUpper { set {} } // 0x000000018BF308D4-0x000000018BF30954
	
			// Constructors
			internal ShapeModule(ParticleSystem particleSystem) : this() {
				m_ParticleSystem = default;
			} // 0x0000000186471908-0x0000000186471914
	
			// Methods
			private static void set_enabled_Injected(ref ShapeModule _unity_self, bool value) {} // 0x000000018BF30864-0x000000018BF30878
			private static void set_shapeType_Injected(ref ShapeModule _unity_self, ParticleSystemShapeType value) {} // 0x000000018BF30884-0x000000018BF308D4
			private static void set_radius_Injected(ref ShapeModule _unity_self, float value) {} // 0x000000018BF30360-0x000000018BF3038C
			private static void set_mesh_Injected(ref ShapeModule _unity_self, Mesh value) {} // 0x000000018BF304BC-0x000000018BF304FC
			private static void set_meshRenderer_Injected(ref ShapeModule _unity_self, MeshRenderer value) {} // 0x000000018BF2F9F8-0x000000018BF2FA2C
			private static void set_skinnedMeshRenderer_Injected(ref ShapeModule _unity_self, SkinnedMeshRenderer value) {} // 0x000000018BF2FA6C-0x000000018BF2FAA0
			private static void set_textureClipThreshold_Injected(ref ShapeModule _unity_self, float value) {} // 0x000000018BF2FA2C-0x000000018BF2FA6C
			private static void set_textureClipThresholdUpper_Injected(ref ShapeModule _unity_self, float value) {} // 0x000000018BF2FD48-0x000000018BF2FD7C
		}
	
		public struct CollisionModule // TypeDefIndex: 59756
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public bool enabled { get => default; } // 0x000000018BF304A8-0x000000018BF304BC 
	
			// Constructors
			internal CollisionModule(ParticleSystem particleSystem) : this() {
				m_ParticleSystem = default;
			} // 0x000000018BF2FDC0-0x000000018BF2FDEC
	
			// Methods
			private static bool get_enabled_Injected(ref CollisionModule _unity_self) => default; // 0x000000018BF303E0-0x000000018BF30410
		}
	
		public struct TriggerModule // TypeDefIndex: 59757
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal TriggerModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x000000018BF2FAA0-0x000000018BF2FAE4
		}
	
		public struct SubEmittersModule // TypeDefIndex: 59758
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Properties
			public int subEmittersCount { get => default; } // 0x0000000184759830-0x0000000184759850 
	
			// Constructors
			internal SubEmittersModule(ParticleSystem particleSystem) : this() {
				m_ParticleSystem = default;
			} // 0x0000000184759830-0x0000000184759850
	
			// Methods
			public ParticleSystem GetSubEmitterSystem(int index) => default; // 0x0000000184759830-0x0000000184759850
			private static int get_subEmittersCount_Injected(ref SubEmittersModule _unity_self) => default; // 0x0000000184759830-0x0000000184759850
			private static ParticleSystem GetSubEmitterSystem_Injected(ref SubEmittersModule _unity_self, int index) => default; // 0x0000000184759830-0x0000000184759850
		}
	
		public struct TextureSheetAnimationModule // TypeDefIndex: 59759
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal TextureSheetAnimationModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x0000000184759830-0x0000000184759850
		}
	
		public struct Particle // TypeDefIndex: 59760
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
			public float lifetime { set {} } // 0x0000000184759830-0x0000000184759850
			public Vector3 position { set {} } // 0x0000000184759830-0x0000000184759850
			public Vector3 velocity { set {} } // 0x0000000184759830-0x0000000184759850
			public float remainingLifetime { set {} } // 0x0000000184759830-0x0000000184759850
			public float startLifetime { set {} } // 0x0000000184759830-0x0000000184759850
			public Color32 startColor { set {} } // 0x0000000184759830-0x0000000184759850
			public uint randomSeed { set {} } // 0x0000000184759830-0x0000000184759850
			public float startSize { set {} } // 0x0000000184759830-0x0000000184759850
			public Vector3 rotation3D { set {} } // 0x0000000184759830-0x0000000184759850
			public Vector3 angularVelocity3D { set {} } // 0x0000000184759830-0x0000000184759850
		}
	
		[Serializable]
		public struct MinMaxCurve // TypeDefIndex: 59761
		{
			// Fields
			private ParticleSystemCurveMode m_Mode; // 0x00
			private float m_CurveMultiplier; // 0x04
			private AnimationCurve m_CurveMin; // 0x08
			private AnimationCurve m_CurveMax; // 0x10
			private float m_ConstantMin; // 0x18
			private float m_ConstantMax; // 0x1C
	
			// Properties
			public ParticleSystemCurveMode mode { get => default; } // 0x0000000184759830-0x0000000184759850 
			public AnimationCurve curveMax { get => default; } // 0x0000000184759830-0x0000000184759850 
			public AnimationCurve curveMin { get => default; } // 0x0000000184759830-0x0000000184759850 
			public float constantMax { get => default; } // 0x0000000184759830-0x0000000184759850 
			public float constantMin { get => default; } // 0x0000000184759830-0x0000000184759850 
			public float constant { get => default; set {} } // 0x0000000184759830-0x0000000184759850 0x000000018646DB20-0x000000018646DB28
			public AnimationCurve curve { get => default; } // 0x000000018BF2FE64-0x000000018BF2FEB8 
	
			// Constructors
			public MinMaxCurve(float constant) : this() {
				m_Mode = default;
				m_CurveMultiplier = default;
				m_CurveMin = default;
				m_CurveMax = default;
				m_ConstantMin = default;
				m_ConstantMax = default;
			} // 0x0000000184759830-0x0000000184759850
	
			// Methods
			public static implicit operator MinMaxCurve(float constant) => default; // 0x000000018BF2FDEC-0x000000018BF2FE40
		}
	
		[Serializable]
		public struct MinMaxGradient // TypeDefIndex: 59762
		{
			// Fields
			private ParticleSystemGradientMode m_Mode; // 0x00
			private Gradient m_GradientMin; // 0x08
			private Gradient m_GradientMax; // 0x10
			private Color m_ColorMin; // 0x18
			private Color m_ColorMax; // 0x28
	
			// Properties
			public Color colorMax { set {} } // 0x000000018BF306AC-0x000000018BF306F0
			public Color colorMin { set {} } // 0x000000018BF30704-0x000000018BF30748
			public Color color { get => default; set {} } // 0x000000018BF2FB28-0x000000018BF2FB7C 0x000000018BF30814-0x000000018BF30864
	
			// Constructors
			public MinMaxGradient(Color color) : this() {
				m_Mode = default;
				m_GradientMin = default;
				m_GradientMax = default;
				m_ColorMin = default;
				m_ColorMax = default;
			} // 0x000000018BF30124-0x000000018BF30168
	
			// Methods
			public static implicit operator MinMaxGradient(Color color) => default; // 0x000000018BF2FD7C-0x000000018BF2FDC0
		}
	
		public struct EmitParams // TypeDefIndex: 59763
		{
			// Fields
			private Particle m_Particle; // 0x00
			private bool m_PositionSet; // 0x84
			private bool m_VelocitySet; // 0x85
			private bool m_AxisOfRotationSet; // 0x86
			private bool m_RotationSet; // 0x87
			private bool m_AngularVelocitySet; // 0x88
			private bool m_StartSizeSet; // 0x89
			private bool m_StartColorSet; // 0x8A
			private bool m_RandomSeedSet; // 0x8B
			private bool m_StartLifetimeSet; // 0x8C
			private bool m_MeshIndexSet; // 0x8D
			private bool m_ApplyShapeToPosition; // 0x8E
		}
	
		public struct PlaybackState // TypeDefIndex: 59774
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
			internal struct Seed // TypeDefIndex: 59764
			{
				// Fields
				public uint x; // 0x00
				public uint y; // 0x04
				public uint z; // 0x08
				public uint w; // 0x0C
			}
	
			internal struct Seed4 // TypeDefIndex: 59765
			{
				// Fields
				public Seed x; // 0x00
				public Seed y; // 0x10
				public Seed z; // 0x20
				public Seed w; // 0x30
			}
	
			internal struct Emission // TypeDefIndex: 59766
			{
				// Fields
				public float m_ParticleSpacing; // 0x00
				public float m_ToEmitAccumulator; // 0x04
				public Seed m_Random; // 0x08
			}
	
			internal struct Initial // TypeDefIndex: 59767
			{
				// Fields
				public Seed4 m_Random; // 0x00
			}
	
			internal struct Shape // TypeDefIndex: 59768
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
	
			internal struct Force // TypeDefIndex: 59769
			{
				// Fields
				public Seed4 m_Random; // 0x00
			}
	
			internal struct Collision // TypeDefIndex: 59770
			{
				// Fields
				public Seed4 m_Random; // 0x00
			}
	
			internal struct Noise // TypeDefIndex: 59771
			{
				// Fields
				public float m_ScrollOffset; // 0x00
			}
	
			internal struct Lights // TypeDefIndex: 59772
			{
				// Fields
				public Seed m_Random; // 0x00
				public float m_ParticleEmissionCounter; // 0x10
			}
	
			internal struct Trail // TypeDefIndex: 59773
			{
				// Fields
				public float m_Timer; // 0x00
			}
		}
	
		public struct Trails // TypeDefIndex: 59775
		{
			// Fields
			internal List<Vector4> positions; // 0x00
			internal List<int> frontPositions; // 0x08
			internal List<int> backPositions; // 0x10
			internal List<int> positionCounts; // 0x18
			internal int maxTrailCount; // 0x20
			internal int maxPositionsPerTrailCount; // 0x24
	
			// Methods
			internal void Allocate() {} // 0x000000018BF30464-0x000000018BF304A8
		}
	
		public struct VelocityOverLifetimeModule // TypeDefIndex: 59776
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal VelocityOverLifetimeModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x000000018BF3038C-0x000000018BF303E0
		}
	
		public struct LimitVelocityOverLifetimeModule // TypeDefIndex: 59777
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal LimitVelocityOverLifetimeModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x000000018646FE2C-0x000000018646FE34
		}
	
		public struct InheritVelocityModule // TypeDefIndex: 59778
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal InheritVelocityModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001864736C8-0x00000001864736D0
		}
	
		public struct LifetimeByEmitterSpeedModule // TypeDefIndex: 59779
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal LifetimeByEmitterSpeedModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x00000001864736D0-0x00000001864736D8
		}
	
		public struct ForceOverLifetimeModule // TypeDefIndex: 59780
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ForceOverLifetimeModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x000000018BF2CCE0-0x000000018BF2CCE8
		}
	
		public struct ColorOverLifetimeModule // TypeDefIndex: 59781
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ColorOverLifetimeModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x000000018BF2D170-0x000000018BF2D178
		}
	
		public struct ColorBySpeedModule // TypeDefIndex: 59782
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ColorBySpeedModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x000000018BF2CE4C-0x000000018BF2CE54
		}
	
		public struct SizeOverLifetimeModule // TypeDefIndex: 59783
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal SizeOverLifetimeModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x000000018BF2D2A8-0x000000018BF2D2B0
		}
	
		public struct SizeBySpeedModule // TypeDefIndex: 59784
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal SizeBySpeedModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x000000018BF2CED4-0x000000018BF2CF04
		}
	
		public struct RotationOverLifetimeModule // TypeDefIndex: 59785
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal RotationOverLifetimeModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x000000018BF2D340-0x000000018BF2D354
		}
	
		public struct RotationBySpeedModule // TypeDefIndex: 59786
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal RotationBySpeedModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x000000018BF2CE88-0x000000018BF2CE90
		}
	
		public struct ExternalForcesModule // TypeDefIndex: 59787
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal ExternalForcesModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x000000018BF2D2F4-0x000000018BF2D2FC
		}
	
		public struct NoiseModule // TypeDefIndex: 59788
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal NoiseModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x000000018BF2D0B0-0x000000018BF2D0E0
		}
	
		public struct LightsModule // TypeDefIndex: 59789
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal LightsModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x000000018BF2D064-0x000000018BF2D06C
		}
	
		public struct TrailModule // TypeDefIndex: 59790
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal TrailModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x000000018BF2D514-0x000000018BF2D51C
		}
	
		public struct CustomDataModule // TypeDefIndex: 59791
		{
			// Fields
			internal ParticleSystem m_ParticleSystem; // 0x00
	
			// Constructors
			internal CustomDataModule(ParticleSystem particleSystem) {
				m_ParticleSystem = default;
			} // 0x000000018BF2D028-0x000000018BF2D030
		}
	
		// Constructors
		public ParticleSystem() {} // 0x000000018646FE2C-0x000000018646FE34
	
		// Methods
		public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) {} // 0x000000018BF2D4C8-0x000000018BF2D4D0
		public void Emit(Particle particle) {} // 0x000000018BF2CF38-0x000000018BF2CF40
		internal float GetParticleCurrentSize(ref Particle particle) => default; // 0x000000018BF2CC70-0x000000018BF2CCA4
		internal Vector3 GetParticleCurrentSize3D(ref Particle particle) => default; // 0x000000018BF2D0E0-0x000000018BF2D124
		internal Color32 GetParticleCurrentColor(ref Particle particle) => default; // 0x000000018BF2CD60-0x000000018BF2CD94
		internal int GetParticleMeshIndex(ref Particle particle) => default; // 0x000000018BF2D1C4-0x000000018BF2D204
		public void SetParticles(out Particle[] particles, int size, int offset) {
			particles = default;
		} // 0x00000001851EA100-0x00000001851EA140
		public void SetParticles(out Particle[] particles, int size) {
			particles = default;
		} // 0x000000018521A2C0-0x000000018521A310
		public void SetParticles(out Particle[] particles) {
			particles = default;
		} // 0x000000018BF2CD24-0x000000018BF2CD58
		private void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) {} // 0x00000001855D45D0-0x00000001855D4620
		public void SetParticles(out NativeArray<Particle> particles, int size, int offset) {
			particles = default;
		} // 0x000000018BF2CCE8-0x000000018BF2CD1C
		public void SetParticles(out NativeArray<Particle> particles, int size) {
			particles = default;
		} // 0x000000018BF2D178-0x000000018BF2D1BC
		public void SetParticles(out NativeArray<Particle> particles) {
			particles = default;
		} // 0x00000001856434A0-0x00000001856434E0
		public int GetParticles(out Particle[] particles, int size, int offset) {
			particles = default;
			return default;
		} // 0x00000001855D4620-0x00000001855D4750
		public int GetParticles(out Particle[] particles, int size) {
			particles = default;
			return default;
		} // 0x000000018646FE2C-0x000000018646FE34
		public int GetParticles(out Particle[] particles) {
			particles = default;
			return default;
		} // 0x000000018BF2CBE0-0x000000018BF2CBE8
		private int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) => default; // 0x000000018BF2CC68-0x000000018BF2CC70
		public int GetParticles(out NativeArray<Particle> particles, int size, int offset) {
			particles = default;
			return default;
		} // 0x0000000184759850-0x00000001847598B0
		public int GetParticles(out NativeArray<Particle> particles, int size) {
			particles = default;
			return default;
		} // 0x000000018646FE5C-0x000000018646FE70
		public int GetParticles(out NativeArray<Particle> particles) {
			particles = default;
			return default;
		} // 0x000000018BF2CC1C-0x000000018BF2CC24
		public void SetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) {} // 0x000000018BF2CBAC-0x000000018BF2CBE0
		public int GetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) => default; // 0x000000018BF2CC24-0x000000018BF2CC68
		public PlaybackState GetPlaybackState() => default; // 0x00000001847598B0-0x0000000184759900
		public void SetPlaybackState(PlaybackState playbackState) {} // 0x00000001855CAA80-0x00000001855CAAD0
		private void GetTrailDataInternal(ref Trails trailData) {} // 0x000000018BF2CBE8-0x000000018BF2CC1C
		public Trails GetTrails() => default; // 0x000000018646FE2C-0x000000018646FE34
		public int GetTrails(ref Trails trailData) => default; // 0x000000018BF31480-0x000000018BF31488
		public void SetTrails(Trails trailData) {} // 0x000000018BF315AC-0x000000018BF315B4
		public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) {} // 0x000000018BF31564-0x000000018BF3156C
		public void Simulate(float t, bool withChildren, bool restart) {} // 0x000000018BF31518-0x000000018BF31520
		public void Simulate(float t, bool withChildren) {} // 0x000000018BF314CC-0x000000018BF314D4
		public void Simulate(float t) {} // 0x000000018BF315F8-0x000000018BF31600
		public void Play(bool withChildren) {} // 0x000000018BF31690-0x000000018BF31698
		public void Play() {} // 0x000000018BF31644-0x000000018BF3164C
		public void Pause(bool withChildren) {} // 0x000000018BF3143C-0x000000018BF31480
		public void Pause() {} // 0x000000018BF3156C-0x000000018BF315AC
		public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) {} // 0x000000018BF31520-0x000000018BF31564
		public void Stop(bool withChildren) {} // 0x000000018BF314D4-0x000000018BF31518
		public void Stop() {} // 0x000000018BF31488-0x000000018BF314CC
		public void Clear(bool withChildren) {} // 0x000000018BF315B4-0x000000018BF315F8
		public void Clear() {} // 0x000000018BF3164C-0x000000018BF31690
		public bool IsAlive(bool withChildren) => default; // 0x000000018BF31600-0x000000018BF31644
		public bool IsAlive() => default; // 0x000000018646FE2C-0x000000018646FE34
		public void Emit(int count) {} // 0x000000018BF2CBA4-0x000000018BF2CBAC
		private void Emit_Internal(int count) {} // 0x000000018BF2CB70-0x000000018BF2CBA4
		public void Emit(EmitParams emitParams, int count) {} // 0x000000018646FE2C-0x000000018646FE34
		private void EmitOld_Internal(ref Particle particle) {} // 0x000000018646FE2C-0x000000018646FE34
		public void TriggerSubEmitter(int subEmitterIndex) {} // 0x000000018BF31714-0x000000018BF3171C
		public void TriggerSubEmitter(int subEmitterIndex, ref Particle particle) {} // 0x000000018BF316D8-0x000000018BF316E0
		internal void TriggerSubEmitterForParticle(int subEmitterIndex, Particle particle) {} // 0x000000018BF316E0-0x000000018BF31714
		public void TriggerSubEmitter(int subEmitterIndex, List<Particle> particles) {} // 0x000000018BF31698-0x000000018BF316D8
		public static void ResetPreMappedBufferMemory() {} // 0x000000018646FE2C-0x000000018646FE34
		public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount) {} // 0x0000000185FBCAD0-0x0000000185FBCAE0
		public void AllocateAxisOfRotationAttribute() {} // 0x0000000185FB7BD0-0x0000000185FB7BE0
		public void AllocateMeshIndexAttribute() {} // 0x0000000185FB7BE0-0x0000000185FB7BF0
		public void AllocateCustomDataAttribute(ParticleSystemCustomData stream) {} // 0x0000000185FBCAD0-0x0000000185FBCAE0
		internal unsafe void* GetManagedJobData() => default; // 0x0000000185FBD310-0x0000000185FBD320
		internal JobHandle GetManagedJobHandle() => default; // 0x000000018143E3C0-0x000000018143E3D0
		internal void SetManagedJobHandle(JobHandle handle) {} // 0x0000000185FB2030-0x0000000185FB2040
		internal static unsafe JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData) => default; // 0x0000000185FE8D70-0x0000000185FE8D90
		internal static unsafe void CopyManagedJobData(void* systemPtr, out NativeParticleData particleData) {
			particleData = default;
		} // 0x000000018BF313EC-0x000000018BF3143C
		private void GetParticleCurrentSize3D_Injected(ref Particle particle, out Vector3 ret) {
			ret = default;
		} // 0x000000018646FE2C-0x000000018646FE34
		private void GetParticleCurrentColor_Injected(ref Particle particle, out Color32 ret) {
			ret = default;
		} // 0x000000018646FE2C-0x000000018646FE34
		private void GetPlaybackState_Injected(out PlaybackState ret) {
			ret = default;
		} // 0x000000018646FE2C-0x000000018646FE34
		private void SetPlaybackState_Injected(ref PlaybackState playbackState) {} // 0x000000018646FE2C-0x000000018646FE34
		private void SetTrails_Injected(ref Trails trailData) {} // 0x000000018646FE2C-0x000000018646FE34
		private void Emit_Injected(ref EmitParams emitParams, int count) {} // 0x000000018646FE2C-0x000000018646FE34
		private void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref Particle particle) {} // 0x000000018646FE2C-0x000000018646FE34
		private void GetManagedJobHandle_Injected(out JobHandle ret) {
			ret = default;
		} // 0x000000018646FE2C-0x000000018646FE34
		private void SetManagedJobHandle_Injected(ref JobHandle handle) {} // 0x000000018646FE2C-0x000000018646FE34
		private static unsafe void ScheduleManagedJob_Injected(ref JobsUtility.JobScheduleParameters parameters, void* additionalData, out JobHandle ret) {
			ret = default;
		} // 0x000000018646FE2C-0x000000018646FE34
	}

	public static class ParticlePhysicsExtensions // TypeDefIndex: 59793
	{
		// Methods
		public static int GetSafeCollisionEventSize(ParticleSystem ps) => default; // 0x000000018BF2D634-0x000000018BF2D640
		public static int GetCollisionEvents(ParticleSystem ps, GameObject go, List<ParticleCollisionEvent> collisionEvents) => default; // 0x000000018BF2D628-0x000000018BF2D634
	}

	public enum ParticleSystemRenderMode // TypeDefIndex: 59794
	{
		Billboard = 0,
		Stretch = 1,
		HorizontalBillboard = 2,
		VerticalBillboard = 3,
		Mesh = 4,
		None = 5
	}

	public enum ParticleSystemMeshDistribution // TypeDefIndex: 59795
	{
		UniformRandom = 0,
		NonUniformRandom = 1
	}

	public enum ParticleSystemSortMode // TypeDefIndex: 59796
	{
		None = 0,
		Distance = 1,
		OldestInFront = 2,
		YoungestInFront = 3,
		Depth = 4
	}

	public enum ParticleSystemRenderSpace // TypeDefIndex: 59797
	{
		View = 0,
		World = 1,
		Local = 2,
		Facing = 3,
		Velocity = 4
	}

	public enum ParticleSystemCurveMode // TypeDefIndex: 59798
	{
		Constant = 0,
		Curve = 1,
		TwoCurves = 2,
		TwoConstants = 3
	}

	public enum ParticleSystemGradientMode // TypeDefIndex: 59799
	{
		Color = 0,
		Gradient = 1,
		TwoColors = 2,
		TwoGradients = 3,
		RandomColor = 4
	}

	public enum ParticleSystemShapeType // TypeDefIndex: 59800
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

	public enum ParticleSystemSimulationSpace // TypeDefIndex: 59801
	{
		Local = 0,
		World = 1,
		Custom = 2
	}

	public enum ParticleSystemStopBehavior // TypeDefIndex: 59802
	{
		StopEmittingAndClear = 0,
		StopEmitting = 1
	}

	public enum ParticleSystemScalingMode // TypeDefIndex: 59803
	{
		Hierarchy = 0,
		Local = 1,
		Shape = 2
	}

	public enum ParticleSystemVertexStream // TypeDefIndex: 59804
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

	public enum ParticleSystemCustomData // TypeDefIndex: 59805
	{
		Custom1 = 0,
		Custom2 = 1
	}

	public enum ParticleSystemTrailTextureMode // TypeDefIndex: 59806
	{
		Stretch = 0,
		Tile = 1,
		DistributePerSegment = 2,
		RepeatPerSegment = 3
	}

	public enum ParticleSystemForceFieldShape // TypeDefIndex: 59807
	{
		Sphere = 0,
		Hemisphere = 1,
		Cylinder = 2,
		Box = 3
	}

	public enum ParticleSystemVertexStreams // TypeDefIndex: 59808
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

	public sealed class ParticleSystemRenderer : Renderer // TypeDefIndex: 59809
	{
		// Properties
		public ParticleSystemRenderSpace alignment { get => default; set {} } // 0x000000018BF2EF1C-0x000000018BF2EF50 0x000000018BF2F40C-0x000000018BF2F44C
		public ParticleSystemRenderMode renderMode { get => default; set {} } // 0x000000018BF2F2D4-0x000000018BF2F308 0x000000018BF2F868-0x000000018BF2F8A8
		public ParticleSystemMeshDistribution meshDistribution { get => default; set {} } // 0x000000018BF2F194-0x000000018BF2F1C8 0x000000018BF2F6C0-0x000000018BF2F700
		public ParticleSystemSortMode sortMode { get => default; set {} } // 0x000000018BF2F370-0x000000018BF2F3A4 0x000000018BF2F930-0x000000018BF2F970
		public float lengthScale { get => default; set {} } // 0x000000018BF2F0C4-0x000000018BF2F0F8 0x000000018BF2F5F8-0x000000018BF2F63C
		public float velocityScale { get => default; set {} } // 0x000000018BF2F3D8-0x000000018BF2F40C 0x000000018BF2F9B4-0x000000018BF2F9F8
		public float cameraVelocityScale { get => default; set {} } // 0x000000018BF2EF84-0x000000018BF2EFB8 0x000000018BF2F490-0x000000018BF2F4D4
		public float normalDirection { get => default; set {} } // 0x000000018BF2F230-0x000000018BF2F264 0x000000018BF2F788-0x000000018BF2F7CC
		public float shadowBias { get => default; set {} } // 0x000000018BF2F33C-0x000000018BF2F370 0x000000018BF2F8EC-0x000000018BF2F930
		public float minParticleSize { get => default; set {} } // 0x000000018BF2F1FC-0x000000018BF2F230 0x000000018BF2F744-0x000000018BF2F788
		public float maxParticleSize { get => default; set {} } // 0x000000018BF2F12C-0x000000018BF2F160 0x000000018BF2F67C-0x000000018BF2F6C0
		public Vector3 pivot { get => default; set {} } // 0x000000018BF2F2A8-0x000000018BF2F2D4 0x000000018BF2F854-0x000000018BF2F868
		public Vector3 flip { get => default; set {} } // 0x000000018BF2F064-0x000000018BF2F090 0x000000018BF2F5A0-0x000000018BF2F5B4
		public SpriteMaskInteraction maskInteraction { get => default; set {} } // 0x000000018BF2F0F8-0x000000018BF2F12C 0x000000018BF2F63C-0x000000018BF2F67C
		public Material trailMaterial { get => default; set {} } // 0x000000018BF2F3A4-0x000000018BF2F3D8 0x000000018BF2F970-0x000000018BF2F9B4
		internal Material oldTrailMaterial { set {} } // 0x000000018BF2F7CC-0x000000018BF2F810
		public bool enableGPUInstancing { get => default; set {} } // 0x000000018BF2EFB8-0x000000018BF2EFEC 0x000000018BF2F4D4-0x000000018BF2F518
		public bool allowRoll { get => default; set {} } // 0x000000018BF2EF50-0x000000018BF2EF84 0x000000018BF2F44C-0x000000018BF2F490
		public bool freeformStretching { get => default; set {} } // 0x000000018BF2F090-0x000000018BF2F0C4 0x000000018BF2F5B4-0x000000018BF2F5F8
		public bool rotateWithStretchDirection { get => default; set {} } // 0x000000018BF2F308-0x000000018BF2F33C 0x000000018BF2F8A8-0x000000018BF2F8EC
		public bool enableHGGPUInstancing { get => default; set {} } // 0x000000018BF2EFEC-0x000000018BF2F020 0x000000018BF2F518-0x000000018BF2F55C
		public Mesh mesh { get => default; set {} } // 0x000000018BF2F1C8-0x000000018BF2F1FC 0x000000018BF2F700-0x000000018BF2F744
		public int meshCount { get => default; } // 0x000000018BF2F160-0x000000018BF2F194 
		public int activeVertexStreamsCount { get => default; } // 0x000000018BF2EEE8-0x000000018BF2EF1C 
		public bool DisableCutOutAnimation { get => default; } // 0x000000018BF2EEB4-0x000000018BF2EEE8 
		public int CutOutMode { get => default; } // 0x000000018BF2EE80-0x000000018BF2EEB4 
		public int CutOutDataSize { get => default; } // 0x000000018BF2EE4C-0x000000018BF2EE80 
	
		// Constructors
		public ParticleSystemRenderer() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void EnableVertexStreams(ParticleSystemVertexStreams streams) {} // 0x000000018BF2E400-0x000000018BF2E40C
		public void DisableVertexStreams(ParticleSystemVertexStreams streams) {} // 0x000000018BF2E3F4-0x000000018BF2E400
		public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams) => default; // 0x000000018BF2E278-0x000000018BF2E294
		public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams) => default; // 0x000000018BF2E450-0x000000018BF2E45C
		internal void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled) {} // 0x000000018BF2E73C-0x000000018BF2ED20
		internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams) => default; // 0x000000018BF2E4E4-0x000000018BF2E73C
		public int GetMeshes(out Mesh[] meshes) {
			meshes = default;
			return default;
		} // 0x000000018BF2E4A0-0x000000018BF2E4E4
		public void SetMeshes(Mesh[] meshes, int size) {} // 0x000000018BF2EDD8-0x000000018BF2EE2C
		public void SetMeshes(Mesh[] meshes) {} // 0x000000018BF2EE2C-0x000000018BF2EE4C
		public int GetMeshWeightings(out float[] weightings) {
			weightings = default;
			return default;
		} // 0x000000018BF2E45C-0x000000018BF2E4A0
		public void SetMeshWeightings(float[] weightings, int size) {} // 0x000000018BF2ED64-0x000000018BF2EDB8
		public void SetMeshWeightings(float[] weightings) {} // 0x000000018BF2EDB8-0x000000018BF2EDD8
		public void BakeMesh(Mesh mesh, bool useTransform = false /* Metadata: 0x02081F74 */) {} // 0x000000018BF2E2F8-0x000000018BF2E344
		public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = false /* Metadata: 0x02081F75 */) {} // 0x000000018BF2E294-0x000000018BF2E2F8
		public void BakeTrailsMesh(Mesh mesh, bool useTransform = false /* Metadata: 0x02081F76 */) {} // 0x000000018BF2E344-0x000000018BF2E390
		public void BakeTrailsMesh(Mesh mesh, Camera camera, bool useTransform = false /* Metadata: 0x02081F77 */) {} // 0x000000018BF2E390-0x000000018BF2E3F4
		public void SetActiveVertexStreams(List<ParticleSystemVertexStream> streams) {} // 0x000000018BF2ED20-0x000000018BF2ED64
		public void GetActiveVertexStreams(List<ParticleSystemVertexStream> streams) {} // 0x000000018BF2E40C-0x000000018BF2E450
		private void get_pivot_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BF2F264-0x000000018BF2F2A8
		private void set_pivot_Injected(ref Vector3 value) {} // 0x000000018BF2F810-0x000000018BF2F854
		private void get_flip_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BF2F020-0x000000018BF2F064
		private void set_flip_Injected(ref Vector3 value) {} // 0x000000018BF2F55C-0x000000018BF2F5A0
	}

	public struct ParticleCollisionEvent // TypeDefIndex: 59810
	{
		// Fields
		internal Vector3 m_Intersection; // 0x00
		internal Vector3 m_Normal; // 0x0C
		internal Vector3 m_Velocity; // 0x18
		internal int m_ColliderInstanceID; // 0x24
	
		// Properties
		public Vector3 intersection { get => default; } // 0x0000000185FE65B0-0x0000000185FE65D0 
		public Vector3 normal { get => default; } // 0x0000000185FE6590-0x0000000185FE65B0 
		public Vector3 velocity { get => default; } // 0x0000000185FE6980-0x0000000185FE69A0 
		public Component colliderComponent { get => default; } // 0x000000018BF2D61C-0x000000018BF2D628 
	
		// Methods
		private static Component InstanceIDToColliderComponent(int instanceID) => default; // 0x000000018BF2D5E8-0x000000018BF2D61C
	}

	internal class ParticleSystemExtensionsImpl // TypeDefIndex: 59811
	{
		// Constructors
		public ParticleSystemExtensionsImpl() {} // Dummy constructor
	
		// Methods
		internal static int GetSafeCollisionEventSize(ParticleSystem ps) => default; // 0x000000018BF2D694-0x000000018BF2D6C8
		internal static int GetCollisionEvents(ParticleSystem ps, GameObject go, List<ParticleCollisionEvent> collisionEvents) => default; // 0x000000018BF2D640-0x000000018BF2D694
	}

	public class ParticleSystemForceField : Behaviour // TypeDefIndex: 59812
	{
		// Properties
		public ParticleSystemForceFieldShape shape { get => default; set {} } // 0x000000018BF2DB60-0x000000018BF2DB94 0x000000018BF2E100-0x000000018BF2E140
		public float startRange { get => default; set {} } // 0x000000018BF2DB94-0x000000018BF2DBC8 0x000000018BF2E140-0x000000018BF2E184
		public float endRange { get => default; set {} } // 0x000000018BF2D898-0x000000018BF2D8CC 0x000000018BF2DE44-0x000000018BF2DE88
		public float length { get => default; set {} } // 0x000000018BF2D974-0x000000018BF2D9A8 0x000000018BF2DF24-0x000000018BF2DF68
		public float gravityFocus { get => default; set {} } // 0x000000018BF2D8CC-0x000000018BF2D900 0x000000018BF2DE88-0x000000018BF2DECC
		public Vector2 rotationRandomness { get => default; set {} } // 0x000000018BF2DAC8-0x000000018BF2DAEC 0x000000018BF2E08C-0x000000018BF2E0A8
		public bool multiplyDragByParticleSize { get => default; set {} } // 0x000000018BF2D9A8-0x000000018BF2D9DC 0x000000018BF2DF68-0x000000018BF2DFAC
		public bool multiplyDragByParticleVelocity { get => default; set {} } // 0x000000018BF2D9DC-0x000000018BF2DA10 0x000000018BF2DFAC-0x000000018BF2DFF0
		public Texture3D vectorField { get => default; set {} } // 0x000000018BF2DCB0-0x000000018BF2DCE4 0x000000018BF2E234-0x000000018BF2E278
		public ParticleSystem.MinMaxCurve directionX { get => default; set {} } // 0x000000018BF2D70C-0x000000018BF2D73C 0x000000018BF2DD28-0x000000018BF2DD3C
		public ParticleSystem.MinMaxCurve directionY { get => default; set {} } // 0x000000018BF2D780-0x000000018BF2D7B0 0x000000018BF2DD80-0x000000018BF2DD94
		public ParticleSystem.MinMaxCurve directionZ { get => default; set {} } // 0x000000018BF2D7F4-0x000000018BF2D824 0x000000018BF2DDD8-0x000000018BF2DDEC
		public ParticleSystem.MinMaxCurve gravity { get => default; set {} } // 0x000000018BF2D944-0x000000018BF2D974 0x000000018BF2DF10-0x000000018BF2DF24
		public ParticleSystem.MinMaxCurve rotationSpeed { get => default; set {} } // 0x000000018BF2DB30-0x000000018BF2DB60 0x000000018BF2E0EC-0x000000018BF2E100
		public ParticleSystem.MinMaxCurve rotationAttraction { get => default; set {} } // 0x000000018BF2DA54-0x000000018BF2DA84 0x000000018BF2E034-0x000000018BF2E048
		public ParticleSystem.MinMaxCurve drag { get => default; set {} } // 0x000000018BF2D868-0x000000018BF2D898 0x000000018BF2DE30-0x000000018BF2DE44
		public ParticleSystem.MinMaxCurve vectorFieldSpeed { get => default; set {} } // 0x000000018BF2DC80-0x000000018BF2DCB0 0x000000018BF2E220-0x000000018BF2E234
		public ParticleSystem.MinMaxCurve vectorFieldAttraction { get => default; set {} } // 0x000000018BF2DC0C-0x000000018BF2DC3C 0x000000018BF2E1C8-0x000000018BF2E1DC
	
		// Constructors
		public ParticleSystemForceField() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void get_rotationRandomness_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BF2DA84-0x000000018BF2DAC8
		private void set_rotationRandomness_Injected(ref Vector2 value) {} // 0x000000018BF2E048-0x000000018BF2E08C
		private void get_directionX_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x000000018BF2D6C8-0x000000018BF2D70C
		private void set_directionX_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x000000018BF2DCE4-0x000000018BF2DD28
		private void get_directionY_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x000000018BF2D73C-0x000000018BF2D780
		private void set_directionY_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x000000018BF2DD3C-0x000000018BF2DD80
		private void get_directionZ_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x000000018BF2D7B0-0x000000018BF2D7F4
		private void set_directionZ_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x000000018BF2DD94-0x000000018BF2DDD8
		private void get_gravity_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x000000018BF2D900-0x000000018BF2D944
		private void set_gravity_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x000000018BF2DECC-0x000000018BF2DF10
		private void get_rotationSpeed_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x000000018BF2DAEC-0x000000018BF2DB30
		private void set_rotationSpeed_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x000000018BF2E0A8-0x000000018BF2E0EC
		private void get_rotationAttraction_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x000000018BF2DA10-0x000000018BF2DA54
		private void set_rotationAttraction_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x000000018BF2DFF0-0x000000018BF2E034
		private void get_drag_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x000000018BF2D824-0x000000018BF2D868
		private void set_drag_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x000000018BF2DDEC-0x000000018BF2DE30
		private void get_vectorFieldSpeed_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x000000018BF2DC3C-0x000000018BF2DC80
		private void set_vectorFieldSpeed_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x000000018BF2E1DC-0x000000018BF2E220
		private void get_vectorFieldAttraction_Injected(out ParticleSystem.MinMaxCurve ret) {
			ret = default;
		} // 0x000000018BF2DBC8-0x000000018BF2DC0C
		private void set_vectorFieldAttraction_Injected(ref ParticleSystem.MinMaxCurve value) {} // 0x000000018BF2E184-0x000000018BF2E1C8
	}

	internal sealed class HGParticleMeshInstanceRenderer : Renderer // TypeDefIndex: 59813
	{
		// Constructors
		public HGParticleMeshInstanceRenderer() {} // Dummy constructor
	}
}

namespace UnityEngine.ParticleSystemJobs
{
	internal struct NativeParticleData // TypeDefIndex: 59816
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
		internal struct Array3 // TypeDefIndex: 59814
		{
			// Fields
			internal unsafe float* x; // 0x00
			internal unsafe float* y; // 0x08
			internal unsafe float* z; // 0x10
		}
	
		internal struct Array4 // TypeDefIndex: 59815
		{
			// Fields
			internal unsafe float* x; // 0x00
			internal unsafe float* y; // 0x08
			internal unsafe float* z; // 0x10
			internal unsafe float* w; // 0x18
		}
	}
}
