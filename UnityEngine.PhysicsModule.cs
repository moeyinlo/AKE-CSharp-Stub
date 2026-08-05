/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Unity.Collections;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.Internal;
using UnityEngine.Scripting;

// Image 60: UnityEngine.PhysicsModule.dll - Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61538-61573
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
[assembly: InternalsVisibleTo("UnityEngine.AIModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGOcclusionCullingModule")]
[assembly: InternalsVisibleTo("UnityEngine.ARModule")]
[assembly: InternalsVisibleTo("UnityEngine.AssetBundleModule")]
[assembly: InternalsVisibleTo("UnityEngine.AudioModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClothModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClusterInputModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClusterRendererModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityConnectModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsCommonModule")]
[assembly: InternalsVisibleTo("UnityEngine.TLSModule")]
[assembly: InternalsVisibleTo("UnityEngine.JSONSerializeModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsModule")]
[assembly: InternalsVisibleTo("UnityEngine.CrashReportingModule")]
[assembly: InternalsVisibleTo("UnityEngine.DirectorModule")]
[assembly: InternalsVisibleTo("UnityEngine.DSPGraphModule")]
[assembly: InternalsVisibleTo("UnityEngine.ImageConversionModule")]
[assembly: InternalsVisibleTo("UnityEngine.GameCenterModule")]
[assembly: InternalsVisibleTo("UnityEngine.GIModule")]
[assembly: InternalsVisibleTo("UnityEngine.GridModule")]
[assembly: InternalsVisibleTo("UnityEngine.HotReloadModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGGraphicsCPPModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextRenderingModule")]
[assembly: InternalsVisibleTo("UnityEngine.PS5Module")]
[assembly: InternalsVisibleTo("UnityEngine.ScreenCaptureModule")]
[assembly: InternalsVisibleTo("UnityEngine.IMGUIModule")]
[assembly: InternalsVisibleTo("UnityEngine.LiteSSLModule")]
[assembly: InternalsVisibleTo("UnityEngine.LocalizationModule")]
[assembly: InternalsVisibleTo("UnityEngine.PerformanceReportingModule")]
[assembly: InternalsVisibleTo("UnityEngine.Physics2DModule")]
[assembly: InternalsVisibleTo("UnityEngine.ProfilerModule")]
[assembly: InternalsVisibleTo("UnityEngine.InputLegacyModule")]
[assembly: InternalsVisibleTo("UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextCoreTextEngineModule")]
[assembly: InternalsVisibleTo("UnityEngine.SpriteShapeModule")]
[assembly: InternalsVisibleTo("UnityEngine.StreamingModule")]
[assembly: InternalsVisibleTo("UnityEngine.StreamLineModule")]
[assembly: InternalsVisibleTo("UnityEngine.SubstanceModule")]
[assembly: InternalsVisibleTo("UnityEngine.SubsystemsModule")]
[assembly: InternalsVisibleTo("UnityEngine.TerrainPhysicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.SpriteMaskModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestModule")]
[assembly: InternalsVisibleTo("UnityEngine.TilemapModule")]
[assembly: InternalsVisibleTo("UnityEngine.WindModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestTextureModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsModule")]
[assembly: InternalsVisibleTo("UnityEngine.UmbraModule")]
[assembly: InternalsVisibleTo("UnityEngine.UNETModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityCurlModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityTestProtocolModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestAssetBundleModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsNativeModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestAudioModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIModule")]
[assembly: InternalsVisibleTo("UnityEngine.VehiclesModule")]
[assembly: InternalsVisibleTo("UnityEngine.VFXModule")]
[assembly: InternalsVisibleTo("UnityEngine.VideoModule")]
[assembly: InternalsVisibleTo("UnityEngine.VirtualTexturingModule")]
[assembly: InternalsVisibleTo("UnityEngine.XRModule")]
[assembly: InternalsVisibleTo("UnityEngine.VRModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestWWWModule")]
[assembly: InternalsVisibleTo("UnityEngine.PS5VRModule")]
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
[assembly: InternalsVisibleTo("UnityEngine.Networking")]
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

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 61539
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 61540
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace UnityEngine
{
	public enum RigidbodyConstraints // TypeDefIndex: 61541
	{
		None = 0,
		FreezePositionX = 2,
		FreezePositionY = 4,
		FreezePositionZ = 8,
		FreezePosition = 14,
		FreezeRotationX = 16,
		FreezeRotationY = 32,
		FreezeRotationZ = 64,
		FreezeRotation = 112,
		FreezeAll = 126
	}

	public enum ForceMode // TypeDefIndex: 61542
	{
		Force = 0,
		Impulse = 1,
		VelocityChange = 2,
		Acceleration = 5
	}

	[Flags]
	public enum MeshColliderCookingOptions // TypeDefIndex: 61543
	{
		None = 0,
		InflateConvexMesh = 1,
		CookForFasterSimulation = 2,
		EnableMeshCleaning = 4,
		WeldColocatedVertices = 8,
		UseFastMidphase = 16
	}

	public enum ColliderSurfaceType // TypeDefIndex: 61544
	{
		Default = 0,
		Concrete = 1,
		Wood = 2,
		Dirt = 3,
		Grass = 4,
		Stone = 5,
		Water = 6,
		Flesh = 7,
		Metal = 8,
		Crystal = 9,
		Rubber = 10,
		Sand = 11,
		Gravel = 12,
		Moss = 13,
		Custom = 14,
		Snow = 15,
		Mud = 16,
		Cardboard = 17,
		Plastic = 18,
		Ice = 19,
		Wet = 20,
		WaterV2 = 128
	}

	public enum RigidbodyInterpolation // TypeDefIndex: 61545
	{
		None = 0,
		Interpolate = 1,
		Extrapolate = 2
	}

	[RequiredByNativeCode]
	public class ControllerColliderHit // TypeDefIndex: 61546
	{
		// Fields
		internal CharacterController m_Controller; // 0x10
		internal Collider m_Collider; // 0x18
		internal Vector3 m_Point; // 0x20
		internal Vector3 m_Normal; // 0x2C
		internal Vector3 m_MoveDirection; // 0x38
		internal float m_MoveLength; // 0x44
		internal int m_Push; // 0x48
	
		// Properties
		public GameObject gameObject { get; } // 0x000000018B4200FC-0x000000018B42011C 
		public Vector3 point { get; } // 0x0000000184DBD280-0x0000000184DBD2A0 
	}

	[RequiredByNativeCode]
	public class Collision // TypeDefIndex: 61547
	{
		// Fields
		internal Vector3 m_Impulse; // 0x10
		internal Vector3 m_RelativeVelocity; // 0x1C
		internal UnityEngine.Component m_Body; // 0x28
		internal Collider m_Collider; // 0x30
		internal int m_ContactCount; // 0x38
		internal ContactPoint[] m_ReusedContacts; // 0x40
		internal ContactPoint[] m_LegacyContacts; // 0x48
	
		// Properties
		public Vector3 relativeVelocity { get; } // 0x0000000184DBA870-0x0000000184DBA890 
		public Collider collider { get; } // 0x0000000184DBBEB0-0x0000000184DBBEC0 
		public GameObject gameObject { get; } // 0x000000018B42003C-0x000000018B4200B0 
		public ContactPoint[] contacts { get; } // 0x000000018B41FFD4-0x000000018B42003C 
		public Vector3 impulse { get; } // 0x0000000184DBA8C0-0x0000000184DBA8E0 
	}

	public enum QueryTriggerInteraction // TypeDefIndex: 61548
	{
		UseGlobal = 0,
		Ignore = 1,
		Collide = 2
	}

	public enum CollisionDetectionMode // TypeDefIndex: 61549
	{
		Discrete = 0,
		Continuous = 1,
		ContinuousDynamic = 2,
		ContinuousSpeculative = 3
	}

	[NativeClass("Unity::ArticulationBody")]
	[NativeHeader("Modules/Physics/ArticulationBody.h")]
	public class ArticulationBody : UnityEngine.Behaviour // TypeDefIndex: 61550
	{
		// Constructors
		public ArticulationBody(); // 0x0000000185393520-0x0000000185393538
	}

	[NativeHeader("Modules/Physics/PhysicsManager.h")]
	[StaticAccessor("GetPhysicsManager()", StaticAccessorType.Dot)]
	public class Physics // TypeDefIndex: 61551
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD; // 0x08
		internal const float k_MaxFloatMinusEpsilon = 3.4028233E+38f; // Metadata: 0x0234FCBC
		public const int IgnoreRaycastLayer = 4; // Metadata: 0x0234FCC0
		public const int DefaultRaycastLayers = -5; // Metadata: 0x0234FCC1
		public const int AllLayers = -1; // Metadata: 0x0234FCC2
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use Physics.IgnoreRaycastLayer instead. (UnityUpgradable) -> IgnoreRaycastLayer", true)]
		public const int kIgnoreRaycastLayer = 4; // Metadata: 0x0234FCC3
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use Physics.DefaultRaycastLayers instead. (UnityUpgradable) -> DefaultRaycastLayers", true)]
		public const int kDefaultRaycastLayers = -5; // Metadata: 0x0234FCC4
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use Physics.AllLayers instead. (UnityUpgradable) -> AllLayers", true)]
		public const int kAllLayers = -1; // Metadata: 0x0234FCC5
	
		// Properties
		public static Vector3 gravity { [ThreadSafe] get; set; } // 0x00000001845B55E0-0x00000001845B5610 0x000000018B428FB0-0x000000018B428FC0
		public static float defaultContactOffset { get; set; } // 0x0000000182F62830-0x0000000182F62870 0x000000018B428E60-0x000000018B428E9C
		public static float sleepThreshold { get; set; } // 0x000000018B428C20-0x000000018B428C4C 0x000000018B42913C-0x000000018B429178
		public static bool queriesHitTriggers { get; set; } // 0x000000018B428BC8-0x000000018B428BF4 0x000000018B4290D4-0x000000018B429108
		public static bool queriesHitBackfaces { get; set; } // 0x000000018B428B9C-0x000000018B428BC8 0x000000018B4290A0-0x000000018B4290D4
		public static float bounceThreshold { get; set; } // 0x000000018B428980-0x000000018B4289AC 0x000000018B428DD8-0x000000018B428E14
		public static float defaultMaxDepenetrationVelocity { get; set; } // 0x000000018B428A3C-0x000000018B428A68 0x000000018B428ED8-0x000000018B428F14
		public static int defaultSolverIterations { get; set; } // 0x000000018B428A68-0x000000018B428A94 0x000000018B428F14-0x000000018B428F48
		public static int defaultSolverVelocityIterations { get; set; } // 0x000000018B428A94-0x000000018B428AC0 0x000000018B428F48-0x000000018B428F7C
		public static float defaultMaxAngularSpeed { get; set; } // 0x000000018B428A10-0x000000018B428A3C 0x000000018B428E9C-0x000000018B428ED8
		public static bool improvedPatchFriction { get; set; } // 0x000000018B428AC0-0x000000018B428AEC 0x000000018B428FC0-0x000000018B428FF4
		[NativeProperty("DefaultPhysicsSceneHandle", true, UnityEngine.Bindings.TargetType.Function, true)]
		public static PhysicsScene defaultPhysicsScene { get; } // 0x0000000183207570-0x00000001832075C0 
		public static bool logPhysXCheckError { get; set; } // 0x000000018B428B70-0x000000018B428B9C 0x00000001840E4B70-0x00000001840E4BB0
		public static bool autoSimulation { get; set; } // 0x0000000183C330B0-0x0000000183C330F0 0x00000001840E4BB0-0x00000001840E4BF0
		public static bool autoSyncTransforms { get; set; } // 0x000000018B428954-0x000000018B428980 0x000000018B428DA4-0x000000018B428DD8
		public static bool reuseCollisionCallbacks { get; set; } // 0x000000018B428BF4-0x000000018B428C20 0x000000018B429108-0x000000018B42913C
		[StaticAccessor("GetPhysicsManager()")]
		public static float interCollisionDistance { [NativeName("GetClothInterCollisionDistance")] get; [NativeName("SetClothInterCollisionDistance")] set; } // 0x000000018B428AEC-0x000000018B428B18 0x000000018B428FF4-0x000000018B429030
		[StaticAccessor("GetPhysicsManager()")]
		public static float interCollisionStiffness { [NativeName("GetClothInterCollisionStiffness")] get; [NativeName("SetClothInterCollisionStiffness")] set; } // 0x000000018B428B44-0x000000018B428B70 0x000000018B429064-0x000000018B4290A0
		[StaticAccessor("GetPhysicsManager()")]
		public static bool interCollisionSettingsToggle { [NativeName("GetClothInterCollisionSettingsToggle")] get; [NativeName("SetClothInterCollisionSettingsToggle")] set; } // 0x000000018B428B18-0x000000018B428B44 0x000000018B429030-0x000000018B429064
		public static Vector3 clothGravity { [ThreadSafe] get; set; } // 0x000000018B4289EC-0x000000018B428A10 0x000000018B428E50-0x000000018B428E60
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Physics.defaultContactOffset or Collider.contactOffset instead.", true)]
		public static float minPenetrationForPenalty { get; set; } // 0x0000000184DBAEC0-0x0000000184DBAED0 0x00000001841E1670-0x00000001841E1680
		[Obsolete("Please use bounceThreshold instead. (UnityUpgradable) -> bounceThreshold")]
		public static float bounceTreshold { get; set; } // 0x000000018B4289AC-0x000000018B4289B8 0x000000018B428E14-0x000000018B428E1C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", true)]
		public static float sleepVelocity { get; set; } // 0x0000000184DBAEC0-0x0000000184DBAED0 0x00000001841E1670-0x00000001841E1680
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("The sleepAngularVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", true)]
		public static float sleepAngularVelocity { get; set; } // 0x0000000184DBAEC0-0x0000000184DBAED0 0x00000001841E1670-0x00000001841E1680
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Rigidbody.maxAngularVelocity instead.", true)]
		public static float maxAngularVelocity { get; set; } // 0x0000000184DBAEC0-0x0000000184DBAED0 0x00000001841E1670-0x00000001841E1680
		[Obsolete("Please use Physics.defaultSolverIterations instead. (UnityUpgradable) -> defaultSolverIterations")]
		public static int solverIterationCount { get; set; } // 0x000000018B428C4C-0x000000018B428C58 0x000000018B429178-0x000000018B429180
		[Obsolete("Please use Physics.defaultSolverVelocityIterations instead. (UnityUpgradable) -> defaultSolverVelocityIterations")]
		public static int solverVelocityIterationCount { get; set; } // 0x000000018B428C58-0x000000018B428C64 0x000000018B429180-0x000000018B429188
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("penetrationPenaltyForce has no effect.", true)]
		public static float penetrationPenaltyForce { get; set; } // 0x0000000184DBAEC0-0x0000000184DBAED0 0x00000001841E1670-0x00000001841E1680
	
		// Events
		public static event Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent {
			add; // 0x000000018B4288B8-0x000000018B428954
			remove; // 0x000000018B428D08-0x000000018B428DA4
		}
		public static event Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD {
			add; // 0x000000018B428814-0x000000018B4288B8
			remove; // 0x000000018B428C64-0x000000018B428D08
		}
	
		// Constructors
		public Physics(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[RequiredByNativeCode]
		private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD); // 0x000000018B424F74-0x000000018B425030
		public static void ClearUnusedMemory(); // 0x000000018427A2A0-0x000000018427A2E0
		public static void IgnoreCollision([NotNull("NullExceptionObject")] Collider collider1, [NotNull("NullExceptionObject")] Collider collider2, [UnityEngine.Internal.DefaultValue("true")] bool ignore); // 0x000000018B424940-0x000000018B424994
		[ExcludeFromDocs]
		public static void IgnoreCollision(Collider collider1, Collider collider2); // 0x000000018B424994-0x000000018B4249A0
		[NativeName("IgnoreCollision")]
		public static void IgnoreLayerCollision(int layer1, int layer2, [UnityEngine.Internal.DefaultValue("true")] bool ignore); // 0x000000018B4249AC-0x000000018B4249FC
		[NativeName("ForceRebuildDynamicTree")]
		public static void ForceRebuildDynamicTree(bool rebuildStatic, bool rebuildDynamic); // 0x000000018B424878-0x000000018B4248BC
		[ExcludeFromDocs]
		public static void IgnoreLayerCollision(int layer1, int layer2); // 0x000000018B4249A0-0x000000018B4249AC
		public static bool GetIgnoreLayerCollision(int layer1, int layer2); // 0x000000018B424900-0x000000018B424940
		public static bool GetIgnoreCollision([NotNull("NullExceptionObject")] Collider collider1, [NotNull("NullExceptionObject")] Collider collider2); // 0x000000018B4248BC-0x000000018B424900
		public static bool Raycast(Vector3 origin, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B427888-0x000000018B427920
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask); // 0x000000018B427718-0x000000018B4277A8
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance); // 0x000000018B427C40-0x000000018B427CC8
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction); // 0x000000018B427B44-0x000000018B427BBC
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000182F61D50-0x0000000182F61FD0
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask); // 0x00000001846D9BD0-0x00000001846D9C70
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance); // 0x0000000183CF1320-0x0000000183CF1580
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo); // 0x000000018B4277A8-0x000000018B427838
		public static bool RaycastV2(ECSColliderResultProxy proxy, Ray ray, float maxDistance, out RaycastHit hit); // 0x000000018B4275F0-0x000000018B427684
		public static bool RaycastV2(ECSColliderResultProxy proxy, Ray ray, float maxDistance, bool hitHoles, out RaycastHit hit); // 0x000000018B427684-0x000000018B427718
		[NativeName("RaycastTestV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static RaycastHit Internal_RaycastTestV2(ECSColliderResultProxy collider, Ray ray, float maxDistance, bool hitHoles, ref bool hasHit); // 0x000000018B424BA4-0x000000018B424C18
		public static bool Raycast(Ray ray, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B427AB4-0x000000018B427B44
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, float maxDistance, int layerMask); // 0x000000018B427920-0x000000018B4279A8
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, float maxDistance); // 0x000000018B4279A8-0x000000018B427A24
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray); // 0x000000018B427CC8-0x000000018B427D34
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x0000000183028220-0x0000000183028360
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask); // 0x000000018B427838-0x000000018B427888
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance); // 0x000000018B427A24-0x000000018B427AB4
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo); // 0x000000018B427BBC-0x000000018B427C40
		public static bool Linecast(Vector3 start, Vector3 end, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B424E14-0x000000018B424EE4
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end, int layerMask); // 0x000000018B424EE4-0x000000018B424F2C
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end); // 0x000000018B424DC8-0x000000018B424E14
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B424CA4-0x000000018B424D7C
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask); // 0x000000018B424F2C-0x000000018B424F74
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo); // 0x000000018B424D7C-0x000000018B424DC8
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B423ACC-0x000000018B423BA0
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask); // 0x000000018B423D74-0x000000018B423DEC
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance); // 0x000000018B423C24-0x000000018B423C98
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction); // 0x000000018B4239D0-0x000000018B423A44
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B423C98-0x000000018B423D74
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask); // 0x000000018B423A44-0x000000018B423ACC
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance); // 0x000000018B423948-0x000000018B4239D0
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo); // 0x000000018B423BA0-0x000000018B423C24
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x0000000183730420-0x00000001837305E0
		[ExcludeFromDocs]
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask); // 0x000000018B4283EC-0x000000018B428450
		[ExcludeFromDocs]
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance); // 0x000000018B428640-0x000000018B4286A0
		[ExcludeFromDocs]
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo); // 0x000000018B4284C4-0x000000018B428524
		public static bool SphereCast(Ray ray, float radius, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B428524-0x000000018B4285C8
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask); // 0x000000018B42860C-0x000000018B428640
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, float maxDistance); // 0x000000018B42848C-0x000000018B4284C4
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius); // 0x000000018B428700-0x000000018B428740
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B4286A0-0x000000018B428700
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask); // 0x000000018B428740-0x000000018B42877C
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance); // 0x000000018B428450-0x000000018B42848C
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo); // 0x000000018B4285C8-0x000000018B42860C
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B422C34-0x000000018B422D08
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask); // 0x000000018B422F84-0x000000018B423010
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance); // 0x000000018B422E38-0x000000018B422EC0
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation); // 0x000000018B4230A4-0x000000018B42312C
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction); // 0x000000018B422BA4-0x000000018B422C34
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B422EC0-0x000000018B422F84
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask); // 0x000000018B422D08-0x000000018B422DA0
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance); // 0x000000018B42312C-0x000000018B4231C0
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation); // 0x000000018B423010-0x000000018B4230A4
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo); // 0x000000018B422DA0-0x000000018B422E38
		[NativeName("RaycastAll")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B424B18-0x000000018B424B40
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B4270AC-0x000000018B4271D0
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask); // 0x000000018B427064-0x000000018B4270AC
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance); // 0x000000018B42721C-0x000000018B427268
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction); // 0x000000018B427268-0x000000018B4272BC
		public static RaycastHit[] RaycastAll(Ray ray, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B4271D0-0x000000018B42721C
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask); // 0x000000018B427018-0x000000018B427064
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance); // 0x000000018B426FC8-0x000000018B427018
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray); // 0x000000018B4272BC-0x000000018B427310
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x0000000183B1D970-0x0000000183B1DA10
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask); // 0x0000000183906800-0x00000001839068A0
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance); // 0x000000018B427310-0x000000018B4273A0
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results); // 0x000000018B4273A0-0x000000018B427424
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x0000000183206500-0x0000000183206830
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask); // 0x000000018B4274C0-0x000000018B427560
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance); // 0x000000018B427424-0x000000018B4274C0
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results); // 0x000000018B427560-0x000000018B4275F0
		[NativeName("CapsuleCastAll")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static RaycastHit[] Query_CapsuleCastAll(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B426974-0x000000018B4269C8
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B4231C0-0x000000018B423300
		[ExcludeFromDocs]
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask); // 0x000000018B423374-0x000000018B4233EC
		[ExcludeFromDocs]
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance); // 0x000000018B423300-0x000000018B423374
		[ExcludeFromDocs]
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction); // 0x000000018B4233EC-0x000000018B423460
		[NativeName("SphereCastAll")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B426ED0-0x000000018B426F10
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B428080-0x000000018B4281AC
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask); // 0x000000018B427EB8-0x000000018B427F0C
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance); // 0x000000018B427FF8-0x000000018B428048
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction); // 0x000000018B427FA0-0x000000018B427FF8
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B427F4C-0x000000018B427FA0
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask); // 0x000000018B427E84-0x000000018B427EB8
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance); // 0x000000018B428048-0x000000018B428080
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Ray ray, float radius); // 0x000000018B427F0C-0x000000018B427F4C
		[NativeName("OverlapCapsule")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static Collider[] OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B426024-0x000000018B426054
		public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B426118-0x000000018B4261F0
		[ExcludeFromDocs]
		public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask); // 0x000000018B426054-0x000000018B426118
		[ExcludeFromDocs]
		public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius); // 0x000000018B4261F0-0x000000018B4262A8
		[NativeName("OverlapCapsuleV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static ECSColliderResultProxy[] OverlapCapsuleV2_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B425E70-0x000000018B425EA0
		public static ECSColliderResultProxy[] OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B425F34-0x000000018B425FC0
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius, int layerMask); // 0x000000018B425EEC-0x000000018B425F34
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius); // 0x000000018B425EA0-0x000000018B425EEC
		[NativeName("OverlapSphere")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B4266FC-0x000000018B426724
		public static Collider[] OverlapSphere(Vector3 position, float radius, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B4267C4-0x000000018B42687C
		public static ECSColliderResultProxy CreateECSProxy(Collider collider); // 0x0000000183679460-0x0000000183679620
		[ExcludeFromDocs]
		public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask); // 0x000000018B426724-0x000000018B4267C4
		[ExcludeFromDocs]
		public static Collider[] OverlapSphere(Vector3 position, float radius); // 0x000000018B42687C-0x000000018B426910
		[NativeName("OverlapSphereV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static ECSColliderResultProxy[] OverlapSphereV2_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B42659C-0x000000018B4265C4
		public static ECSColliderResultProxy[] OverlapSphereV2(Vector3 position, float radius, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B4265FC-0x000000018B426668
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapSphereV2(Vector3 position, float radius, int layerMask); // 0x000000018B426668-0x000000018B426698
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapSphereV2(Vector3 position, float radius); // 0x000000018B4265C4-0x000000018B4265FC
		[NativeName("Simulate")]
		internal static void Simulate_Internal(PhysicsScene physicsScene, float step); // 0x0000000185395788-0x00000001853957A4
		public static void Simulate(float step); // 0x0000000183C33040-0x0000000183C330B0
		public static void SyncTransforms(); // 0x00000001832CA830-0x00000001832CA960
		[NativeName("ComputePenetration")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputePenetration([NotNull("ArgumentNullException")] Collider colliderA, Vector3 positionA, Quaternion rotationA, [NotNull("ArgumentNullException")] Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018B426D84-0x000000018B426DD0
		public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // 0x000000018B424690-0x000000018B4247C8
		[NativeName("ComputePenetrationV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputePenetrationV2(ECSColliderResultProxy colliderA, Vector3 positionA, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x0000000185393470-0x00000001853934BC
		public static bool ComputePenetrationV2(ECSColliderResultProxy colliderA, Vector3 positionA, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // 0x0000000183679BB0-0x0000000183679CD0
		[NativeName("ComputeCapsulePenetration")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputeCapsulePenetration(Vector3 point1, Vector3 point2, float radius, [NotNull("ArgumentNullException")] Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018B426CD4-0x000000018B426D20
		public static bool ComputeCapsulePenetration(Vector3 point1, Vector3 point2, float radius, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // 0x000000018B424564-0x000000018B424690
		[NativeName("ComputeCapsulePenetrationV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputeCapsulePenetrationV2(Vector3 point1, Vector3 point2, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018B426C24-0x000000018B426C70
		public static bool ComputeCapsulePenetrationV2(Vector3 point1, Vector3 point2, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // 0x000000018B424498-0x000000018B424564
		[NativeName("ComputeSpherePenetrationV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputeSpherePenetrationV2(Vector3 center, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018B426E34-0x000000018B426E6C
		public static bool ComputeSpherePenetrationV2(Vector3 center, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // 0x000000018B4247C8-0x000000018B424878
		[NativeName("ComputeBoxPenetrationV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputeBoxPenetrationV2(Vector3 center, Vector3 halfExtent, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018B426B74-0x000000018B426BC0
		public static bool ComputeBoxPenetrationV2(Vector3 center, Vector3 halfExtent, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // 0x000000018B4243BC-0x000000018B424498
		[NativeName("IsSimulatedThisFrame")]
		[StaticAccessor("GetPhysicsManager()")]
		private static bool IsSimulatedThisFrame_Internal(); // 0x000000018B424C6C-0x000000018B424C98
		public static bool IsSimulatedThisFrame(); // 0x000000018B424C98-0x000000018B424CA4
		[NativeName("SetForceSimulateThisFrame")]
		[StaticAccessor("GetPhysicsManager()")]
		private static void SetForceSimulateThisFrame_Internal(bool force); // 0x000000018B427E48-0x000000018B427E7C
		public static void SetForceSimulateThisFrame(bool force); // 0x000000018B427E7C-0x000000018B427E84
		[NativeName("SetFastSimulate")]
		[StaticAccessor("GetPhysicsManager()")]
		private static void SetFastSimulate_Internal(bool fast); // 0x0000000184D51170-0x0000000184D511B0
		public static void SetFastSimulate(bool fast); // 0x0000000185396EC0-0x0000000185396EC8
		[NativeName("ClosestPoint")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static Vector3 Query_ClosestPoint([NotNull("ArgumentNullException")] Collider collider, Vector3 position, Quaternion rotation, Vector3 point); // 0x000000018B426AD0-0x000000018B426B10
		public static Vector3 ClosestPoint(Vector3 point, Collider collider, Vector3 position, Quaternion rotation); // 0x000000018B4242C4-0x000000018B4243BC
		[NativeName("ClosestPointV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static Vector3 Query_ClosestPointV2(ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation, Vector3 point); // 0x000000018B426A2C-0x000000018B426A6C
		public static Vector3 ClosestPointV2(Vector3 point, ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation); // 0x000000018B424220-0x000000018B4242C4
		[NativeName("TryGetClosestPoint")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static Vector3 Query_TryGetClosestPoint(ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation, Vector3 point, ref bool resultIsValid); // 0x000000018B426F74-0x000000018B426FC8
		public static bool TryGetClosestPoint(ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation, Vector3 point, out Vector3 result); // 0x000000018B42877C-0x000000018B428814
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B42646C-0x000000018B426538
		[ExcludeFromDocs]
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask); // 0x000000018B4263B8-0x000000018B42646C
		[ExcludeFromDocs]
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results); // 0x000000018B426310-0x000000018B4263B8
		public static int OverlapSphereNonAllocV2(Vector3 position, float radius, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x0000000183D7C060-0x0000000183D7C100
		[ExcludeFromDocs]
		public static int OverlapSphereNonAllocV2(Vector3 position, float radius, ECSColliderResultProxy[] results, int layerMask); // 0x000000018B4262E0-0x000000018B426310
		[ExcludeFromDocs]
		public static int OverlapSphereNonAllocV2(Vector3 position, float radius, ECSColliderResultProxy[] results); // 0x000000018B4262A8-0x000000018B4262E0
		[NativeName("SphereTest")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B424124-0x000000018B42414C
		public static bool CheckSphere(Vector3 position, float radius, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B424184-0x000000018B4241F0
		[ExcludeFromDocs]
		public static bool CheckSphere(Vector3 position, float radius, int layerMask); // 0x000000018B4241F0-0x000000018B424220
		[ExcludeFromDocs]
		public static bool CheckSphere(Vector3 position, float radius); // 0x000000018B42414C-0x000000018B424184
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x00000001830F1F60-0x00000001830F20F0
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B423604-0x000000018B4236E0
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask); // 0x000000018B4237B4-0x000000018B42383C
		[ExcludeFromDocs]
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask); // 0x000000018B4236E0-0x000000018B4237B4
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance); // 0x000000018B4238C0-0x000000018B423948
		[ExcludeFromDocs]
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance); // 0x000000018B423530-0x000000018B423604
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results); // 0x000000018B42383C-0x000000018B4238C0
		[ExcludeFromDocs]
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results); // 0x000000018B423460-0x000000018B423530
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x00000001830F58C0-0x00000001830F5A30
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask); // 0x000000018B428328-0x000000018B42838C
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance); // 0x000000018B428268-0x000000018B4282C8
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results); // 0x000000018B42838C-0x000000018B4283EC
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B4282C8-0x000000018B428328
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask); // 0x000000018B4281F0-0x000000018B42822C
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance); // 0x000000018B42822C-0x000000018B428268
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results); // 0x000000018B4281AC-0x000000018B4281F0
		[NativeName("CapsuleTest")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x00000001853909E0-0x0000000185390A10
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x0000000182F65310-0x0000000182F653B0
		[ExcludeFromDocs]
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask); // 0x000000018B42402C-0x000000018B424074
		[ExcludeFromDocs]
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius); // 0x000000018B424074-0x000000018B4240C0
		[NativeName("BoxTest")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B423E50-0x000000018B423E80
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layermask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B423F44-0x000000018B423FD8
		[ExcludeFromDocs]
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask); // 0x000000018B423FD8-0x000000018B42402C
		[ExcludeFromDocs]
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation); // 0x000000018B423E80-0x000000018B423EDC
		[ExcludeFromDocs]
		public static bool CheckBox(Vector3 center, Vector3 halfExtents); // 0x000000018B423EDC-0x000000018B423F44
		[NativeName("OverlapBox")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B425774-0x000000018B4257A4
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B425928-0x000000018B425A0C
		[ExcludeFromDocs]
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask); // 0x000000018B425A0C-0x000000018B425AE0
		[ExcludeFromDocs]
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation); // 0x000000018B4257A4-0x000000018B425868
		[ExcludeFromDocs]
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents); // 0x000000018B425868-0x000000018B425928
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("AllLayers")] int mask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B425150-0x000000018B42524C
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask); // 0x000000018B42524C-0x000000018B425328
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation); // 0x000000018B425328-0x000000018B425400
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results); // 0x000000018B425400-0x000000018B4254D4
		[NativeName("OverlapBoxV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static ECSColliderResultProxy[] OverlapBoxV2_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B425538-0x000000018B425568
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B42567C-0x000000018B425710
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask); // 0x000000018B425628-0x000000018B42567C
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents, Quaternion orientation); // 0x000000018B425568-0x000000018B4255C0
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents); // 0x000000018B4255C0-0x000000018B425628
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("AllLayers")] int mask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x00000001845ADD40-0x00000001845ADDF0
		[ExcludeFromDocs]
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, Quaternion orientation, int mask); // 0x000000018B425098-0x000000018B4250F8
		[ExcludeFromDocs]
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, Quaternion orientation); // 0x000000018B4250F8-0x000000018B425150
		[ExcludeFromDocs]
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results); // 0x000000018B425030-0x000000018B425098
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x0000000183027790-0x0000000183027940
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation); // 0x000000018B422A7C-0x000000018B422B10
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance); // 0x000000018B422B10-0x000000018B422BA4
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layerMask); // 0x000000018B42294C-0x000000018B4229E4
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results); // 0x000000018B4229E4-0x000000018B422A7C
		[NativeName("BoxCastAll")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static RaycastHit[] Internal_BoxCastAll(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B424A60-0x000000018B424AB4
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B4225D8-0x000000018B422720
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask); // 0x000000018B422830-0x000000018B4228BC
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance); // 0x000000018B422720-0x000000018B4227A8
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation); // 0x000000018B4227A8-0x000000018B422830
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction); // 0x000000018B4228BC-0x000000018B42294C
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B425D1C-0x000000018B425E0C
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask); // 0x000000018B425B7C-0x000000018B425C50
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results); // 0x000000018B425C50-0x000000018B425D1C
		public static int OverlapCapsuleNonAllocV2(Vector3 point0, Vector3 point1, float radius, [Unmarshalled] ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x00000001831FFA70-0x00000001831FFB20
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAllocV2(Vector3 point0, Vector3 point1, float radius, [Unmarshalled] ECSColliderResultProxy[] results, int layerMask); // 0x000000018B425B2C-0x000000018B425B7C
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAllocV2(Vector3 point0, Vector3 point1, float radius, [Unmarshalled] ECSColliderResultProxy[] results); // 0x000000018B425AE0-0x000000018B425B2C
		[NativeName("RebuildBroadphaseRegions")]
		[StaticAccessor("GetPhysicsManager()")]
		private static void Internal_RebuildBroadphaseRegions(Bounds bounds, int subdivisions); // 0x000000018B424C58-0x000000018B424C6C
		public static void RebuildBroadphaseRegions(Bounds worldBounds, int subdivisions); // 0x000000018B427D34-0x000000018B427E48
		[StaticAccessor("GetPhysicsManager()")]
		[ThreadSafe]
		public static void BakeMesh(int meshID, bool convex); // 0x000000018B422598-0x000000018B4225D8
		private static void get_gravity_Injected(out Vector3 ret); // 0x00000001845B5610-0x00000001845B5650
		private static void set_gravity_Injected(ref Vector3 value); // 0x000000018B428F7C-0x000000018B428FB0
		private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret); // 0x00000001832075C0-0x0000000183207600
		private static void Internal_RaycastTestV2_Injected(ref ECSColliderResultProxy collider, ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret); // 0x000000018B424B40-0x000000018B424BA4
		private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B424AB4-0x000000018B424B18
		private static RaycastHit[] Query_CapsuleCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B426910-0x000000018B426974
		private static RaycastHit[] Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B426E6C-0x000000018B426ED0
		private static Collider[] OverlapCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B425FC0-0x000000018B426024
		private static ECSColliderResultProxy[] OverlapCapsuleV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B425E0C-0x000000018B425E70
		private static Collider[] OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B426698-0x000000018B4266FC
		private static ECSColliderResultProxy[] OverlapSphereV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B426538-0x000000018B42659C
		private static void Simulate_Internal_Injected(ref PhysicsScene physicsScene, float step); // 0x0000000183C32E90-0x0000000183C32EE0
		private static bool Query_ComputePenetration_Injected(Collider colliderA, ref Vector3 positionA, ref Quaternion rotationA, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018B426D20-0x000000018B426D84
		private static bool Query_ComputePenetrationV2_Injected(ref ECSColliderResultProxy colliderA, ref Vector3 positionA, ref Quaternion rotationA, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x0000000184500B90-0x0000000184500C00
		private static bool Query_ComputeCapsulePenetration_Injected(ref Vector3 point1, ref Vector3 point2, float radius, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018B426C70-0x000000018B426CD4
		private static bool Query_ComputeCapsulePenetrationV2_Injected(ref Vector3 point1, ref Vector3 point2, float radius, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018B426BC0-0x000000018B426C24
		private static bool Query_ComputeSpherePenetrationV2_Injected(ref Vector3 center, float radius, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018B426DD0-0x000000018B426E34
		private static bool Query_ComputeBoxPenetrationV2_Injected(ref Vector3 center, ref Vector3 halfExtent, ref Quaternion rotationA, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018B426B10-0x000000018B426B74
		private static void Query_ClosestPoint_Injected(Collider collider, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, out Vector3 ret); // 0x000000018B426A6C-0x000000018B426AD0
		private static void Query_ClosestPointV2_Injected(ref ECSColliderResultProxy colliderProxy, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, out Vector3 ret); // 0x000000018B4269C8-0x000000018B426A2C
		private static void Query_TryGetClosestPoint_Injected(ref ECSColliderResultProxy colliderProxy, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, ref bool resultIsValid, out Vector3 ret); // 0x000000018B426F10-0x000000018B426F74
		private static void get_clothGravity_Injected(out Vector3 ret); // 0x000000018B4289B8-0x000000018B4289EC
		private static void set_clothGravity_Injected(ref Vector3 value); // 0x000000018B428E1C-0x000000018B428E50
		private static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B4240C0-0x000000018B424124
		private static bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000182F653B0-0x0000000182F65420
		private static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B423DEC-0x000000018B423E50
		private static Collider[] OverlapBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B425710-0x000000018B425774
		private static ECSColliderResultProxy[] OverlapBoxV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B4254D4-0x000000018B425538
		private static RaycastHit[] Internal_BoxCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B4249FC-0x000000018B424A60
		private static void Internal_RebuildBroadphaseRegions_Injected(ref Bounds bounds, int subdivisions); // 0x000000018B424C18-0x000000018B424C58
	}

	public struct ModifiableContactPair // TypeDefIndex: 61552
	{
		// Fields
		private IntPtr actor; // 0x00
		private IntPtr otherActor; // 0x08
		private IntPtr shape; // 0x10
		private IntPtr otherShape; // 0x18
		public Quaternion rotation; // 0x20
		public Vector3 position; // 0x30
		public Quaternion otherRotation; // 0x3C
		public Vector3 otherPosition; // 0x4C
		private int numContacts; // 0x58
		private IntPtr contacts; // 0x60
	}

	[NativeHeader("Modules/Physics/PhysicMaterial.h")]
	public class PhysicMaterial : UnityEngine.Object // TypeDefIndex: 61553
	{
		// Constructors
		public PhysicMaterial(); // 0x000000018B421764-0x000000018B4217B8
	
		// Methods
		private static void Internal_CreateDynamicsMaterial([Writable] PhysicMaterial mat, string name); // 0x000000018B421720-0x000000018B421764
	}

	[NativeHeader("Runtime/Interfaces/IRaycast.h")]
	[NativeHeader("PhysicsScriptingClasses.h")]
	[NativeHeader("Modules/Physics/RaycastHit.h")]
	[UsedByNativeCode]
	public struct ECSColliderResultProxy : IEquatable<ECSColliderResultProxy> // TypeDefIndex: 61554
	{
		// Fields
		[NativeName("actor")]
		internal IntPtr m_Actor; // 0x00
		[NativeName("ecsId")]
		internal int m_EcsId; // 0x08
		[NativeName("ecsVersion")]
		internal uint m_EcsVersion; // 0x0C
		[NativeName("collider")]
		internal int m_Collider; // 0x10
		[NativeName("componentIndex")]
		internal int m_ComponentIndex; // 0x14
		private static readonly ECSColliderResultProxy INVALID_PROXY; // 0x00
	
		// Properties
		public int componentIndex { get; } // 0x0000000184D872D0-0x0000000184D872E0 
		public Entity colliderEntity { get; } // 0x000000018444B190-0x000000018444B1A0 
		public int ecsId { get; } // 0x0000000184D9CF30-0x0000000184D9CF40 
		public uint ecsVersion { get; } // 0x0000000184D9D1B0-0x0000000184D9D1C0 
		public static ECSColliderResultProxy invalid { get; } // 0x000000018B420590-0x000000018B4205F4 
		public Collider collider { get; } // 0x0000000183204840-0x00000001832048B0 
		public int colliderInstanceId { get; } // 0x0000000184DBA9F0-0x0000000184DBAA00 
		public bool bIsECS { get; } // 0x0000000183205320-0x0000000183205340 
		public int tagConfig { get; } // 0x00000001834E7180-0x00000001834E7200 
		public bool isTrigger { get; } // 0x0000000183731A40-0x0000000183731BE0 
		public int layer { get; } // 0x00000001830F5140-0x00000001830F5240 
		public Transform transform { get; } // 0x00000001832023B0-0x00000001832024D0 
		public Vector3 transformPosition { get; } // 0x0000000183677460-0x00000001836775D0 
		public Quaternion transformRotation { get; } // 0x0000000183679660-0x00000001836797D0 
		public Vector3 transformLossyScale { get; } // 0x000000018B4205F4-0x000000018B4206FC 
		public Vector3 shapePosition { get; } // 0x00000001831FA240-0x00000001831FA3B0 
		public Bounds bounds { get; } // 0x0000000183678230-0x00000001836783C0 
		public int colliderOptions { get; } // 0x0000000183205340-0x0000000183205480 
		public ColliderSurfaceType surfaceType { get; } // 0x00000001832884F0-0x0000000183288530 
		public ECSColliderType colliderType { get; } // 0x000000018B420434-0x000000018B420590 
		public GameObject gameObject { get; } // 0x0000000183F1E2A0-0x0000000183F1E340 
		public bool hasComplexMesh { get; } // 0x0000000183203C00-0x0000000183203C80 
	
		// Constructors
		static ECSColliderResultProxy(); // 0x0000000184D5EB60-0x0000000184D5EBA0
	
		// Methods
		public void SetColliderAndSetIndex(int colliderInstanceID); // 0x0000000183204A70-0x0000000183204BB0
		public void SetComponentIndex(int index); // 0x0000000184D8F540-0x0000000184D8F550
		public void SetActor(IntPtr actor); // 0x0000000184D88B60-0x0000000184D88B70
		public void SetEcsId(int id); // 0x0000000184D88B40-0x0000000184D88B50
		public void SetEcsVersion(uint version); // 0x0000000184D8CAE0-0x0000000184D8CAF0
		public bool IsValid(); // 0x0000000183205140-0x00000001832052C0
		public string GetColliderGoName(); // 0x0000000183676B00-0x0000000183676BB0
		public int GetFactoryBuildingIdentifier(); // 0x000000018406A3A0-0x000000018406A3E0
		public bool TryGetClosestPoint(Vector3 point, out Vector3 result); // 0x000000018B420320-0x000000018B420434
		public Vector3 ClosestPoint(Vector3 position); // 0x0000000183677BC0-0x0000000183677D00
		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance); // 0x000000018B4201C0-0x000000018B420320
		public static bool operator ==(ECSColliderResultProxy left, ECSColliderResultProxy right); // 0x000000018B4206FC-0x000000018B42078C
		public static bool operator !=(ECSColliderResultProxy left, ECSColliderResultProxy right); // 0x0000000182F5B750-0x0000000182F5B7D0
		public bool Equals(ECSColliderResultProxy other); // 0x00000001843285A0-0x0000000184328620
		public override bool Equals(object obj); // 0x000000018B42011C-0x000000018B4201C0
		public override int GetHashCode(); // 0x0000000183F70140-0x0000000183F70200
		public bool CompareTag(int tagValue); // 0x00000001836778A0-0x00000001836779D0
		public bool IsSameCollider(Collider otherCollider); // 0x0000000183202310-0x00000001832023B0
	}

	[NativeHeader("Modules/Physics/RaycastHit.h")]
	[NativeHeader("Runtime/Interfaces/IRaycast.h")]
	[NativeHeader("PhysicsScriptingClasses.h")]
	[UsedByNativeCode]
	public struct RaycastHit // TypeDefIndex: 61555
	{
		// Fields
		[NativeName("point")]
		internal Vector3 m_Point; // 0x00
		[NativeName("normal")]
		internal Vector3 m_Normal; // 0x0C
		[NativeName("faceID")]
		internal uint m_FaceID; // 0x18
		[NativeName("distance")]
		internal float m_Distance; // 0x1C
		[NativeName("uv")]
		internal Vector2 m_UV; // 0x20
		[NativeName("collider")]
		internal int m_Collider; // 0x28
		[NativeName("index")]
		internal int m_Index; // 0x2C
		[NativeName("ecsColliderId")]
		internal int m_EcsId; // 0x30
		[NativeName("ecsColliderVersion")]
		internal uint m_EcsVersion; // 0x34
		[NativeName("actor")]
		internal IntPtr m_Actor; // 0x38
	
		// Properties
		public int ecsId { get; } // 0x0000000184DBA970-0x0000000184DBA980 
		public uint ecsVersion { get; } // 0x0000000184DBA8F0-0x0000000184DBA900 
		public bool IsECSCollider { get; } // 0x000000018406A430-0x000000018406A450 
		public Collider collider { get; } // 0x0000000183BF0940-0x0000000183BF09B0 
		public int colliderInstanceID { get; } // 0x0000000184DBBEC0-0x0000000184DBBED0 
		public Collider editorCollider { get; } // 0x000000018B4292C4-0x000000018B429354 
		public ECSColliderResultProxy colliderProxy { get; } // 0x00000001832048B0-0x0000000183204A70 
		public Vector3 point { get; set; } // 0x0000000184DBA810-0x0000000184DBA830 0x0000000184DABF80-0x0000000184DABF90
		public Vector3 normal { get; set; } // 0x0000000184DBA7F0-0x0000000184DBA810 0x0000000184DBAA60-0x0000000184DBAA70
		public Vector3 barycentricCoordinate { get; set; } // 0x0000000184DBD2E0-0x0000000184DBD310 0x000000018B42971C-0x000000018B42973C
		public float distance { get; set; } // 0x0000000184DBD180-0x0000000184DBD190 0x0000000184D86900-0x0000000184D86910
		public int triangleIndex { get; } // 0x0000000184D9D860-0x0000000184D9D870 
		public int componentIndex { get; } // 0x0000000184DBD310-0x0000000184DBD320 
		public Vector2 textureCoord { get; } // 0x000000018B4296C0-0x000000018B42971C 
		public Vector2 textureCoord2 { get; } // 0x000000018B429660-0x000000018B4296C0 
		public Transform transform { get; } // 0x0000000183BF06A0-0x0000000183BF07A0 
		public Vector3 shapePosition { get; } // 0x000000018B4295D8-0x000000018B429618 
		public Quaternion shapeRotation { get; } // 0x000000018B429618-0x000000018B429650 
		public Vector3 position { get; } // 0x000000018B4294C0-0x000000018B4294F4 
		public Quaternion rotation { get; } // 0x000000018B4294F4-0x000000018B429520 
		public Vector3 scale { get; } // 0x000000018B429520-0x000000018B4295D8 
		public Rigidbody rigidbody { get; } // 0x0000000183BF0600-0x0000000183BF06A0 
		public ArticulationBody articulationBody { get; } // 0x000000018B429234-0x000000018B4292C4 
		public Vector2 lightmapCoord { get; } // 0x000000018B429354-0x000000018B4294C0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use textureCoord2 instead. (UnityUpgradable) -> textureCoord2")]
		public Vector2 textureCoord1 { get; } // 0x000000018B429650-0x000000018B429660 
	
		// Methods
		[FreeFunction]
		private static Vector2 CalculateRaycastTexCoord(Collider collider, int m_Index, Vector2 uv, Vector3 pos, uint face, int textcoord); // 0x000000018B4291E8-0x000000018B429234
		private static void CalculateRaycastTexCoord_Injected(Collider collider, int m_Index, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret); // 0x000000018B429188-0x000000018B4291E8
	}

	[NativeHeader("Modules/Physics/Rigidbody.h")]
	[RequireComponent(typeof(Transform))]
	public class Rigidbody : UnityEngine.Component // TypeDefIndex: 61556
	{
		// Properties
		public Vector3 velocity { get; set; } // 0x000000018319C6B0-0x000000018319C6E0 0x000000018B42AF9C-0x000000018B42AFB0
		public Vector3 angularVelocity { get; set; } // 0x000000018319D840-0x000000018319D870 0x000000018B42AA74-0x000000018B42AA88
		public float drag { get; set; } // 0x000000018319C730-0x000000018319C770 0x000000018B42ABA4-0x000000018B42ABE8
		public float angularDrag { get; set; } // 0x000000018B42A45C-0x000000018B42A490 0x000000018B42A9EC-0x000000018B42AA30
		public float mass { get; set; } // 0x000000018B42A718-0x000000018B42A74C 0x000000018B42AD1C-0x000000018B42AD60
		public bool useGravity { get; set; } // 0x000000018B42A948-0x000000018B42A97C 0x000000018B42AF14-0x000000018B42AF58
		public float maxDepenetrationVelocity { get; set; } // 0x000000018B42A780-0x000000018B42A7B4 0x000000018B42ADA4-0x000000018B42ADE8
		public bool isKinematic { get; set; } // 0x000000018B42A6E4-0x000000018B42A718 0x000000018319DBB0-0x000000018319DC00
		public bool freezeRotation { get; set; } // 0x000000018B42A59C-0x000000018B42A5D0 0x000000018B42ABE8-0x000000018B42AC2C
		public RigidbodyConstraints constraints { get; set; } // 0x000000018B42A534-0x000000018B42A568 0x000000018B42AB20-0x000000018B42AB60
		public CollisionDetectionMode collisionDetectionMode { get; set; } // 0x000000018B42A500-0x000000018B42A534 0x000000018B42AAE0-0x000000018B42AB20
		public Vector3 centerOfMass { get; set; } // 0x000000018B42A4D4-0x000000018B42A500 0x000000018B42AACC-0x000000018B42AAE0
		public Vector3 worldCenterOfMass { get; } // 0x000000018B42A9C0-0x000000018B42A9EC 
		public Quaternion inertiaTensorRotation { get; set; } // 0x000000018B42A614-0x000000018B42A640 0x000000018B42AC70-0x000000018B42AC84
		public Vector3 inertiaTensor { get; set; } // 0x000000018B42A684-0x000000018B42A6B0 0x000000018B42ACC8-0x000000018B42ACDC
		public bool detectCollisions { get; set; } // 0x000000018B42A568-0x000000018B42A59C 0x000000018B42AB60-0x000000018B42ABA4
		public Vector3 position { get; set; } // 0x000000018B42A7F8-0x000000018B42A824 0x000000018539183C-0x0000000185391850
		public Quaternion rotation { get; set; } // 0x000000018B42A868-0x000000018B42A894 0x000000018B42AE2C-0x000000018B42AE40
		public RigidbodyInterpolation interpolation { get; set; } // 0x000000018B42A6B0-0x000000018B42A6E4 0x000000018B42ACDC-0x000000018B42AD1C
		public int solverIterations { get; set; } // 0x000000018B42A8D4-0x000000018B42A908 0x000000018B42AE8C-0x000000018B42AECC
		public float sleepThreshold { get; set; } // 0x000000018B42A894-0x000000018B42A8C8 0x000000018B42AE40-0x000000018B42AE84
		public float maxAngularVelocity { get; set; } // 0x000000018B42A74C-0x000000018B42A780 0x000000018B42AD60-0x000000018B42ADA4
		public int solverVelocityIterations { get; set; } // 0x000000018B42A914-0x000000018B42A948 0x000000018B42AED4-0x000000018B42AF14
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", true)]
		public float sleepVelocity { get; set; } // 0x0000000184DBAEC0-0x0000000184DBAED0 0x00000001841E1670-0x00000001841E1680
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("The sleepAngularVelocity is no longer supported. Use sleepThreshold to specify energy.", true)]
		public float sleepAngularVelocity { get; set; } // 0x0000000184DBAEC0-0x0000000184DBAED0 0x00000001841E1670-0x00000001841E1680
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Cone friction is no longer supported.", true)]
		public bool useConeFriction { get; set; } // 0x0000000184D85B20-0x0000000184D85B30 0x00000001841E1670-0x00000001841E1680
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use Rigidbody.solverIterations instead. (UnityUpgradable) -> solverIterations")]
		public int solverIterationCount { get; set; } // 0x000000018B42A8C8-0x000000018B42A8D4 0x000000018B42AE84-0x000000018B42AE8C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use Rigidbody.solverVelocityIterations instead. (UnityUpgradable) -> solverVelocityIterations")]
		public int solverVelocityIterationCount { get; set; } // 0x000000018B42A908-0x000000018B42A914 0x000000018B42AECC-0x000000018B42AED4
	
		// Constructors
		public Rigidbody(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void SetDensity(float density); // 0x000000018B42A048-0x000000018B42A08C
		public void MovePosition(Vector3 position); // 0x000000018B429F74-0x000000018B429F88
		public void MoveRotation(Quaternion rot); // 0x000000018B429FCC-0x000000018B429FE0
		public void Sleep(); // 0x000000018B42A094-0x000000018B42A0C8
		public bool IsSleeping(); // 0x000000018319BF90-0x000000018319BFD0
		public void WakeUp(); // 0x000000018B42A428-0x000000018B42A45C
		public void ResetCenterOfMass(); // 0x000000018B429FE0-0x000000018B42A014
		public void ResetInertiaTensor(); // 0x000000018B42A014-0x000000018B42A048
		public Vector3 GetRelativePointVelocity(Vector3 relativePoint); // 0x000000018B429E04-0x000000018B429E38
		public Vector3 GetPointVelocity(Vector3 worldPoint); // 0x000000018B429D7C-0x000000018B429DB0
		public void AddForce(Vector3 force, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode); // 0x000000018B4299B8-0x000000018B4299CC
		[ExcludeFromDocs]
		public void AddForce(Vector3 force); // 0x000000018B42998C-0x000000018B4299B8
		public void AddForce(float x, float y, float z, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode); // 0x000000018B429960-0x000000018B42998C
		[ExcludeFromDocs]
		public void AddForce(float x, float y, float z); // 0x000000018B4299CC-0x000000018B4299F4
		public void AddRelativeForce(Vector3 force, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode); // 0x000000018B429A9C-0x000000018B429AB0
		[ExcludeFromDocs]
		public void AddRelativeForce(Vector3 force); // 0x000000018B429A48-0x000000018B429A74
		public void AddRelativeForce(float x, float y, float z, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode); // 0x000000018B429AB0-0x000000018B429ADC
		[ExcludeFromDocs]
		public void AddRelativeForce(float x, float y, float z); // 0x000000018B429A74-0x000000018B429A9C
		public void AddTorque(Vector3 torque, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode); // 0x000000018B429C38-0x000000018B429C4C
		[ExcludeFromDocs]
		public void AddTorque(Vector3 torque); // 0x000000018B429C0C-0x000000018B429C38
		public void AddTorque(float x, float y, float z, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode); // 0x000000018B429C74-0x000000018B429CA0
		[ExcludeFromDocs]
		public void AddTorque(float x, float y, float z); // 0x000000018B429C4C-0x000000018B429C74
		public void AddRelativeTorque(Vector3 torque, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode); // 0x000000018B429B88-0x000000018B429B9C
		[ExcludeFromDocs]
		public void AddRelativeTorque(Vector3 torque); // 0x000000018B429B5C-0x000000018B429B88
		public void AddRelativeTorque(float x, float y, float z, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode); // 0x000000018B429B30-0x000000018B429B5C
		[ExcludeFromDocs]
		public void AddRelativeTorque(float x, float y, float z); // 0x000000018B429B9C-0x000000018B429BB8
		public void AddForceAtPosition(Vector3 force, Vector3 position, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode); // 0x000000018B4298AC-0x000000018B4298C4
		[ExcludeFromDocs]
		public void AddForceAtPosition(Vector3 force, Vector3 position); // 0x000000018B4298C4-0x000000018B42990C
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, [UnityEngine.Internal.DefaultValue("0.0f")] float upwardsModifier, [UnityEngine.Internal.DefaultValue("ForceMode.Force)")] UnityEngine.ForceMode mode); // 0x000000018B42981C-0x000000018B429848
		[ExcludeFromDocs]
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier); // 0x000000018B4297DC-0x000000018B42981C
		[ExcludeFromDocs]
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius); // 0x000000018B4297A0-0x000000018B4297DC
		[NativeName("ClosestPointOnBounds")]
		private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance); // 0x000000018B429E9C-0x000000018B429EB4
		public Vector3 ClosestPointOnBounds(Vector3 position); // 0x000000018B429CA0-0x000000018B429D28
		private RaycastHit SweepTest(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit); // 0x000000018B42A288-0x000000018B42A2FC
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B42A334-0x000000018B42A428
		[ExcludeFromDocs]
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance); // 0x000000018B42A258-0x000000018B42A288
		[ExcludeFromDocs]
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo); // 0x000000018B42A2FC-0x000000018B42A334
		[NativeName("SweepTestAll")]
		private RaycastHit[] Internal_SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B429F18-0x000000018B429F30
		public RaycastHit[] SweepTestAll(Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B42A0F8-0x000000018B42A1BC
		[ExcludeFromDocs]
		public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance); // 0x000000018B42A0C8-0x000000018B42A0F8
		[ExcludeFromDocs]
		public RaycastHit[] SweepTestAll(Vector3 direction); // 0x000000018B42A1BC-0x000000018B42A1F4
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Rigidbody.maxAngularVelocity instead.")]
		public void SetMaxAngularVelocity(float a); // 0x000000018B42A08C-0x000000018B42A094
		private void get_velocity_Injected(out Vector3 ret); // 0x000000018319C6E0-0x000000018319C730
		private void set_velocity_Injected(ref Vector3 value); // 0x000000018B42AF58-0x000000018B42AF9C
		private void get_angularVelocity_Injected(out Vector3 ret); // 0x000000018319DC00-0x000000018319DC50
		private void set_angularVelocity_Injected(ref Vector3 value); // 0x000000018B42AA30-0x000000018B42AA74
		private void get_centerOfMass_Injected(out Vector3 ret); // 0x000000018B42A490-0x000000018B42A4D4
		private void set_centerOfMass_Injected(ref Vector3 value); // 0x000000018B42AA88-0x000000018B42AACC
		private void get_worldCenterOfMass_Injected(out Vector3 ret); // 0x000000018B42A97C-0x000000018B42A9C0
		private void get_inertiaTensorRotation_Injected(out Quaternion ret); // 0x000000018B42A5D0-0x000000018B42A614
		private void set_inertiaTensorRotation_Injected(ref Quaternion value); // 0x000000018B42AC2C-0x000000018B42AC70
		private void get_inertiaTensor_Injected(out Vector3 ret); // 0x000000018B42A640-0x000000018B42A684
		private void set_inertiaTensor_Injected(ref Vector3 value); // 0x000000018B42AC84-0x000000018B42ACC8
		private void get_position_Injected(out Vector3 ret); // 0x000000018B42A7B4-0x000000018B42A7F8
		private void set_position_Injected(ref Vector3 value); // 0x00000001840487C0-0x0000000184048810
		private void get_rotation_Injected(out Quaternion ret); // 0x000000018B42A824-0x000000018B42A868
		private void set_rotation_Injected(ref Quaternion value); // 0x000000018B42ADE8-0x000000018B42AE2C
		private void MovePosition_Injected(ref Vector3 position); // 0x000000018B429F30-0x000000018B429F74
		private void MoveRotation_Injected(ref Quaternion rot); // 0x000000018B429F88-0x000000018B429FCC
		private void GetRelativePointVelocity_Injected(ref Vector3 relativePoint, out Vector3 ret); // 0x000000018B429DB0-0x000000018B429E04
		private void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret); // 0x000000018B429D28-0x000000018B429D7C
		private void AddForce_Injected(ref Vector3 force, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode); // 0x000000018B42990C-0x000000018B429960
		private void AddRelativeForce_Injected(ref Vector3 force, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode); // 0x000000018B4299F4-0x000000018B429A48
		private void AddTorque_Injected(ref Vector3 torque, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode); // 0x000000018B429BB8-0x000000018B429C0C
		private void AddRelativeTorque_Injected(ref Vector3 torque, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode); // 0x000000018B429ADC-0x000000018B429B30
		private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode); // 0x000000018B429848-0x000000018B4298AC
		private void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, [UnityEngine.Internal.DefaultValue("0.0f")] float upwardsModifier, [UnityEngine.Internal.DefaultValue("ForceMode.Force)")] UnityEngine.ForceMode mode); // 0x000000018B42973C-0x000000018B4297A0
		private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance); // 0x000000018B429E38-0x000000018B429E9C
		private void SweepTest_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit, out RaycastHit ret); // 0x000000018B42A1F4-0x000000018B42A258
		private RaycastHit[] Internal_SweepTestAll_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B429EB4-0x000000018B429F18
	}

	public enum ECSColliderType // TypeDefIndex: 61557
	{
		Default = 0,
		BoxCollider = 1,
		CapsuleCollider = 2,
		SphereCollider = 3,
		MeshCollider = 4,
		MultiCollider = 5,
		TerrainCollider = 6,
		ECSCollider = 7,
		Invalid = 8
	}

	[NativeHeader("Modules/Physics/Collider.h")]
	[RequireComponent(typeof(Transform))]
	[RequiredByNativeCode]
	public class Collider : UnityEngine.Component // TypeDefIndex: 61558
	{
		// Properties
		public bool enabled { get; set; } // 0x00000001836797D0-0x0000000183679810 0x00000001834361B0-0x0000000183436200
		public Rigidbody attachedRigidbody { [NativeMethod("GetRigidbody")] get; } // 0x000000018B41FBD4-0x000000018B41FC08 
		public ArticulationBody attachedArticulationBody { [NativeMethod("GetArticulationBody")] get; } // 0x000000018B41FBA0-0x000000018B41FBD4 
		public bool isTrigger { get; set; } // 0x00000001837318A0-0x00000001837318E0 0x000000018375FD00-0x000000018375FD50
		public bool enableDither { get; } // 0x000000018B41FC3C-0x000000018B41FC70 
		public float contactOffset { get; set; } // 0x000000018B41FC08-0x000000018B41FC3C 0x000000018B41FD74-0x000000018B41FDB8
		public Bounds bounds { get; } // 0x00000001836783C0-0x00000001836783F0 
		public bool hasModifiableContacts { get; set; } // 0x000000018B41FC70-0x000000018B41FCA4 0x000000018B41FDB8-0x000000018B41FDFC
		public ColliderSurfaceType surfaceType { get; set; } // 0x000000018B41FD0C-0x000000018B41FD40 0x000000018B41FE40-0x000000018B41FE80
		public int tagConfig { get; set; } // 0x000000018B41FD40-0x000000018B41FD74 0x000000018B41FE80-0x000000018B41FEC0
		public int colliderOptions { get; set; } // 0x000000018375FD90-0x000000018375FDD0 0x000000018375FEE0-0x000000018375FF30
		[NativeMethod("Material")]
		public PhysicMaterial sharedMaterial { get; set; } // 0x000000018B41FCD8-0x000000018B41FD0C 0x000000018B41FDFC-0x000000018B41FE40
		public PhysicMaterial material { [NativeMethod("GetClonedMaterial")] get; [NativeMethod("SetMaterial")] set; } // 0x000000018B41FCA4-0x000000018B41FCD8 0x0000000183679410-0x0000000183679460
	
		// Constructors
		public Collider(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public Vector3 ClosestPoint(Vector3 position); // 0x0000000183677D00-0x0000000183677D40
		[NativeName("GetActor")]
		public IntPtr GetActor(); // 0x0000000183679620-0x0000000183679660
		[NativeName("GetComponentIndex")]
		public int GetComponentIndex(); // 0x0000000183F51100-0x0000000183F51140
		[NativeName("GetFactoryBuildingIdentifier")]
		public int GetFactoryBuildingIdentifier(); // 0x000000018B41F880-0x000000018B41F8B4
		[NativeName("SetFactoryBuildingIdentifier")]
		public void SetFactoryBuildingIdentifier(int value); // 0x000000018B41FA6C-0x000000018B41FAAC
		private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit); // 0x000000018B41F994-0x000000018B41F9F8
		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance); // 0x000000018B41F9F8-0x000000018B41FA6C
		[NativeName("ClosestPointOnBounds")]
		private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance); // 0x000000018B41F918-0x000000018B41F930
		public Vector3 ClosestPointOnBounds(Vector3 position); // 0x000000018B41F7F8-0x000000018B41F880
		public bool CanColliderComputeClosestPoint(); // 0x000000018B41F7C4-0x000000018B41F7F8
		[NativeName("TryGetClosestPoint")]
		private Vector3 TryGetClosestPoint_Internal(Vector3 point, ref bool resultIsValid); // 0x000000018B41FB10-0x000000018B41FB4C
		public bool TryGetClosestPoint(Vector3 point, out Vector3 result); // 0x000000018B41FB4C-0x000000018B41FBA0
		private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret); // 0x0000000183677D40-0x0000000183677DA0
		private void get_bounds_Injected(out Bounds ret); // 0x00000001836783F0-0x0000000183678440
		private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret); // 0x000000018B41F930-0x000000018B41F994
		private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance); // 0x000000018B41F8B4-0x000000018B41F918
		private void TryGetClosestPoint_Internal_Injected(ref Vector3 point, ref bool resultIsValid, out Vector3 ret); // 0x000000018B41FAAC-0x000000018B41FB10
	}

	[NativeHeader("Modules/Physics/ECSCollider.h")]
	[RequiredByNativeCode]
	public class ECSCollider // TypeDefIndex: 61560
	{
		// Fields
		internal IntPtr self; // 0x10
		public static CollisionCallback collisionEnterCallback; // 0x00
		public static CollisionCallback collisionStayCallback; // 0x08
		public static CollisionCallback collisionExitCallback; // 0x10
		public static CollisionCallback triggerEnterCallback; // 0x18
		public static CollisionCallback triggerStayCallback; // 0x20
		public static CollisionCallback triggerExitCallback; // 0x28
	
		// Nested types
		public delegate void CollisionCallback(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // TypeDefIndex: 61559; 0x000000018B41FEC0-0x000000018B41FF0C
	
		// Methods
		public static IntPtr CreateActor(Vector3 position, Quaternion rotation, uint layer, int tagInt, bool movable); // 0x000000018B42098C-0x000000018B4209AC
		[NativeName("DestroyActor")]
		public static void DestroyActor(int id, uint version); // 0x000000018B4209AC-0x000000018B4209EC
		[NativeName("Decode")]
		public static IntPtr Decode(IntPtr data, int length, IntPtr meshes, int meshesCount, Texture2D heightmaps); // 0x00000001834C79D0-0x00000001834C7A40
		public static IntPtr Decode(IntPtr data, int length, NativeArray<int> meshInstanceIds, Texture2D heightmap); // 0x00000001834C7940-0x00000001834C79D0
		[NativeName("RecordEntity")]
		public static void RecordEntity(IntPtr actor, Entity entity); // 0x0000000185392C94-0x0000000185392CB0
		[NativeName("GetId")]
		public static int GetId(IntPtr actor); // 0x00000001834C7A40-0x00000001834C7A80
		[NativeName("GetVersion")]
		public static uint GetVersion(IntPtr actor); // 0x00000001834C7A80-0x00000001834C7AC0
		[NativeName("IsValid")]
		public static bool IsValid(int id, uint version, IntPtr actor); // 0x00000001832052C0-0x0000000183205320
		[NativeName("GetEntity")]
		public static Entity GetEntity(int id, uint version); // 0x000000018444B1A0-0x000000018444B200
		[NativeName("GetPosition")]
		[ThreadSafe]
		public static Vector3 GetPosition(int ecsId, uint ecsVersion); // 0x0000000183678E80-0x0000000183678EB0
		[NativeName("GetShapePosition")]
		[ThreadSafe]
		public static Vector3 GetShapePosition(int ecsId, uint ecsVersion, int index); // 0x00000001844C6EF0-0x00000001844C6F30
		[NativeName("SetPosition")]
		public static void SetPosition(int ecsId, uint ecsVersion, Vector3 position); // 0x0000000185392CB0-0x0000000185392CC4
		[NativeName("GetShapeRotation")]
		[ThreadSafe]
		public static Quaternion GetShapeRotation(int ecsId, uint ecsVersion, int index); // 0x000000018B420A4C-0x000000018B420A88
		[NativeName("GetRotation")]
		[ThreadSafe]
		public static Quaternion GetRotation(int ecsId, uint ecsVersion); // 0x00000001848150F0-0x0000000184815120
		[NativeName("SetRotation")]
		public static void SetRotation(int ecsId, uint ecsVersion, Quaternion rotation); // 0x0000000185392CC4-0x0000000185392CD8
		[NativeName("AttachBox")]
		public static void AttachBox(int id, uint version, Vector3 halfExtent, Vector3 localPosition, Quaternion localRotation, int surfaceType, int colliderOption, int tag, bool isTrigger, bool isPrimitive); // 0x000000018B4207EC-0x000000018B42084C
		[NativeName("HasComplexMesh")]
		public static bool HasComplexMesh(int id, uint version); // 0x0000000183203C80-0x0000000183203CD0
		[NativeName("Raycast")]
		private static RaycastHit Raycast_Internal(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, ref bool hasHit); // 0x000000018B420D28-0x000000018B420D9C
		public static bool Raycast(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, out RaycastHit hitInfo); // 0x000000018B420D9C-0x000000018B420E28
		[NativeName("RaycastComplexMesh")]
		private static RaycastHit RaycastComplexMesh_Internal(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, ref bool hasHit); // 0x00000001841183B0-0x0000000184118420
		public static bool RaycastComplexMesh(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, out RaycastHit hitInfo); // 0x00000001841182B0-0x00000001841183B0
		[NativeName("CapsuleCastComplexMesh")]
		private static RaycastHit CapsuleCastComplexMesh_Internal(int ecsId, uint ecsVersion, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, ref bool hasHit); // 0x00000001830F0360-0x00000001830F03F0
		public static bool CapsuleCastComplexMesh(int ecsId, uint ecsVersion, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, out RaycastHit hitInfo); // 0x00000001830F0210-0x00000001830F0360
		[NativeName("SphereCastComplexMesh")]
		private static RaycastHit SphereCastComplexMesh_Internal(int ecsId, uint ecsVersion, Vector3 center, float radius, Vector3 direction, float maxDistance, ref bool hasHit); // 0x00000001830EF280-0x00000001830EF300
		public static bool SphereCastComplexMesh(int ecsId, uint ecsVersion, Vector3 center, float radius, Vector3 direction, float maxDistance, out RaycastHit hitInfo); // 0x00000001830EF160-0x00000001830EF280
		public static bool CanColliderComputeClosestPoint(int ecsId, uint ecsVersion); // 0x000000018B42084C-0x000000018B42088C
		[NativeName("GetSurfaceAt")]
		public static ColliderSurfaceType GetSurfaceTypeAt(int ecsId, uint ecsVersion, int index); // 0x0000000183288490-0x00000001832884F0
		[NativeName("GetColliderOptionAt")]
		public static int GetColliderOptionAt(int ecsId, uint ecsVersion, int index); // 0x0000000183205480-0x00000001832054E0
		[NativeName("GetTagConfigAt")]
		public static int GetTagConfigAt(int ecsId, uint ecsVersion, int index); // 0x00000001834E7200-0x00000001834E7260
		[NativeName("GetIsTrigger")]
		public static bool GetIsTrigger(int ecsId, uint ecsVersion, int index); // 0x00000001843F3060-0x00000001843F30C0
		public static Bounds GetBounds(int ecsId, uint ecsVersion); // 0x0000000183678440-0x0000000183678480
		[NativeName("TryGetClosestPoint")]
		private static Vector3 TryGetClosestPoint_Internal(int ecsId, uint ecsVersion, Vector3 point, ref bool resultIsValid); // 0x000000018B420E88-0x000000018B420EC8
		public static bool TryGetClosestPoint(int ecsId, uint ecsVersion, Vector3 point, out Vector3 result); // 0x000000018B420EC8-0x000000018B420F24
		public static Vector3 ClosestPoint(int ecsId, uint ecsVersion, Vector3 position); // 0x000000018B4208EC-0x000000018B420928
		[NativeName("CompareTag")]
		public static bool CompareTag(int ecsId, uint ecsVersion, int tagValue); // 0x0000000183675AF0-0x0000000183675B50
		[NativeName("GetLayer")]
		public static int GetLayer(int ecsId, uint ecsVersion); // 0x00000001830F5240-0x00000001830F5290
		[NativeName("GetFactoryBuildingIdentifier")]
		public static int GetFactoryBuildingIdentifier(int ecsId, uint ecsVersion); // 0x000000018406A3E0-0x000000018406A430
		[NativeName("SetFactoryBuildingIdentifier")]
		public static void SetFactoryBuildingIdentifier(int ecsId, uint ecsVersion, int identifier); // 0x00000001834C4BF0-0x00000001834C4C50
		[RequiredByNativeCode]
		private static void OnCollisionEnterV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // 0x000000018B420A88-0x000000018B420B18
		[RequiredByNativeCode]
		private static void OnCollisionStayV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // 0x000000018B420BA8-0x000000018B420C38
		[RequiredByNativeCode]
		private static void OnCollisionExitV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // 0x000000018B420B18-0x000000018B420BA8
		[RequiredByNativeCode]
		private static void OnTriggerEnterV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // 0x000000018484F800-0x000000018484F830
		[RequiredByNativeCode]
		private static void OnTriggerStayV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // 0x000000018B420C38-0x000000018B420CC8
		[RequiredByNativeCode]
		private static void OnTriggerExitV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // 0x0000000184CA3010-0x0000000184CA3040
		public static void ToggleCollision(int id, uint version, bool enableCollision); // 0x00000001834A2210-0x00000001834A2270
		private static IntPtr CreateActor_Injected(ref Vector3 position, ref Quaternion rotation, uint layer, int tagInt, bool movable); // 0x000000018B420928-0x000000018B42098C
		private static void RecordEntity_Injected(IntPtr actor, ref Entity entity); // 0x0000000184258D10-0x0000000184258D60
		private static void GetEntity_Injected(int id, uint version, out Entity ret); // 0x000000018444B200-0x000000018444B260
		private static void GetPosition_Injected(int ecsId, uint ecsVersion, out Vector3 ret); // 0x0000000183678EB0-0x0000000183678F10
		private static void GetShapePosition_Injected(int ecsId, uint ecsVersion, int index, out Vector3 ret); // 0x00000001844C6F30-0x00000001844C6FA0
		private static void SetPosition_Injected(int ecsId, uint ecsVersion, ref Vector3 position); // 0x0000000184191270-0x00000001841912D0
		private static void GetShapeRotation_Injected(int ecsId, uint ecsVersion, int index, out Quaternion ret); // 0x000000018B4209EC-0x000000018B420A4C
		private static void GetRotation_Injected(int ecsId, uint ecsVersion, out Quaternion ret); // 0x0000000184815120-0x0000000184815180
		private static void SetRotation_Injected(int ecsId, uint ecsVersion, ref Quaternion rotation); // 0x0000000184191210-0x0000000184191270
		private static void AttachBox_Injected(int id, uint version, ref Vector3 halfExtent, ref Vector3 localPosition, ref Quaternion localRotation, int surfaceType, int colliderOption, int tag, bool isTrigger, bool isPrimitive); // 0x000000018B42078C-0x000000018B4207EC
		private static void Raycast_Internal_Injected(int ecsId, uint ecsVersion, ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret); // 0x000000018B420CC8-0x000000018B420D28
		private static void RaycastComplexMesh_Internal_Injected(int ecsId, uint ecsVersion, ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret); // 0x0000000184118420-0x00000001841184A0
		private static void CapsuleCastComplexMesh_Internal_Injected(int ecsId, uint ecsVersion, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret); // 0x00000001830F03F0-0x00000001830F0460
		private static void SphereCastComplexMesh_Internal_Injected(int ecsId, uint ecsVersion, ref Vector3 center, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret); // 0x00000001830EF300-0x00000001830EF370
		private static void GetBounds_Injected(int ecsId, uint ecsVersion, out Bounds ret); // 0x0000000183678480-0x00000001836784E0
		private static void TryGetClosestPoint_Internal_Injected(int ecsId, uint ecsVersion, ref Vector3 point, ref bool resultIsValid, out Vector3 ret); // 0x000000018B420E28-0x000000018B420E88
		private static void ClosestPoint_Injected(int ecsId, uint ecsVersion, ref Vector3 position, out Vector3 ret); // 0x000000018B42088C-0x000000018B4208EC
	}

	[NativeHeader("Modules/Physics/CharacterController.h")]
	public class CharacterController : Collider // TypeDefIndex: 61561
	{
		// Properties
		public bool isGrounded { [NativeName("IsGrounded")] get; } // 0x000000018B41F790-0x000000018B41F7C4 
	}

	[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
	[NativeHeader("Modules/Physics/MultiCollider.h")]
	[RequiredByNativeCode]
	public class MultiCollider : Collider // TypeDefIndex: 61562
	{
		// Properties
		public Mesh ComplexMesh { get; } // 0x000000018B4216EC-0x000000018B421720 
	
		// Methods
		[NativeName("AppendBoxCollider")]
		public void AppendBoxCollider(BoxCollider boxCollider); // 0x000000018B421104-0x000000018B421148
		[NativeName("AppendCapsuleCollider")]
		public void AppendCapsuleCollider(CapsuleCollider collider); // 0x000000018B421148-0x000000018B42118C
		[NativeName("AppendSphereCollider")]
		public void AppendSphereCollider(SphereCollider collider); // 0x000000018B42118C-0x000000018B4211D0
		[NativeName("GetSurfaceTypeAt")]
		public ColliderSurfaceType GetSurfaceTypeAt(int index); // 0x000000018B42141C-0x000000018B42145C
		[NativeName("GetTagConfigAt")]
		public int GetTagConfigAt(int index); // 0x000000018B42145C-0x000000018B42149C
		[NativeName("GetGameplayOptionAt")]
		public int GetGameplayOptionAt(int index); // 0x0000000183C828D0-0x0000000183C82920
		[NativeName("GetIsTriggerAt")]
		public bool GetIsTriggerAt(int index); // 0x000000018B4213DC-0x000000018B42141C
		[NativeName("SetGameplayOptionAt")]
		public void SetGameplayOptionAt(int index, int value); // 0x000000018B421518-0x000000018B421568
		[NativeName("Flush")]
		public void Flush(); // 0x000000018B421374-0x000000018B4213A8
		[NativeName("RaycastComplexMesh")]
		public bool RaycastComplexMesh(Ray ray, float maxDistance, ref RaycastHit hit); // 0x000000018B421500-0x000000018B421518
		[NativeName("CapsuleCastComplexMesh")]
		private RaycastHit CapsuleCastComplexMesh_Internal(Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, ref bool hasHit); // 0x000000018B421234-0x000000018B4212C4
		public bool CapsuleCastComplexMesh(Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, out RaycastHit hit); // 0x000000018B4212C4-0x000000018B421374
		[NativeName("SphereCastComplexMesh")]
		private RaycastHit SphereCastComplexMesh_Internal(Vector3 center, float radius, Vector3 direction, float maxDistance, ref bool hasHit); // 0x000000018B4215CC-0x000000018B42164C
		public bool SphereCastComplexMesh(Vector3 center, float radius, Vector3 direction, float maxDistance, out RaycastHit hit); // 0x000000018B42164C-0x000000018B4216EC
		[NativeName("GetShapesCount")]
		public int GetCountWithoutComplexMesh(); // 0x000000018B4213A8-0x000000018B4213DC
		private bool RaycastComplexMesh_Injected(ref Ray ray, float maxDistance, ref RaycastHit hit); // 0x000000018B42149C-0x000000018B421500
		private void CapsuleCastComplexMesh_Internal_Injected(ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret); // 0x000000018B4211D0-0x000000018B421234
		private void SphereCastComplexMesh_Internal_Injected(ref Vector3 center, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret); // 0x000000018B421568-0x000000018B4215CC
	}

	[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
	[NativeHeader("Modules/Physics/MeshCollider.h")]
	[RequiredByNativeCode]
	public class MeshCollider : Collider // TypeDefIndex: 61563
	{
		// Properties
		public Mesh sharedMesh { get; set; } // 0x000000018B42104C-0x000000018B421080 0x0000000183C57D60-0x0000000183C57DB0
		public bool convex { get; set; } // 0x000000018B420FE4-0x000000018B421018 0x000000018B421080-0x000000018B4210C4
		public MeshColliderCookingOptions cookingOptions { get; set; } // 0x000000018B421018-0x000000018B42104C 0x000000018B4210C4-0x000000018B421104
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Configuring smooth sphere collisions is no longer needed.", true)]
		public bool smoothSphereCollisions { get; set; } // 0x0000000184D9AE10-0x0000000184D9AE20 0x00000001841E1670-0x00000001841E1680
		[Obsolete("MeshCollider.skinWidth is no longer used.")]
		public float skinWidth { get; set; } // 0x0000000184DBAEC0-0x0000000184DBAED0 0x00000001841E1670-0x00000001841E1680
		[Obsolete("MeshCollider.inflateMesh is no longer supported. The new cooking algorithm doesn\'t need inflation to be used.")]
		public bool inflateMesh { get; set; } // 0x0000000184D85B20-0x0000000184D85B30 0x00000001841E1670-0x00000001841E1680
	
		// Constructors
		public MeshCollider(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		[NativeName("NeedsReadWriteEnabled")]
		public bool NeedsReadWriteEnabled(); // 0x000000018B420FB0-0x000000018B420FE4
	}

	[NativeHeader("Modules/Physics/CapsuleCollider.h")]
	[RequiredByNativeCode]
	public class CapsuleCollider : Collider // TypeDefIndex: 61564
	{
		// Properties
		public Vector3 center { get; set; } // 0x00000001831FC060-0x00000001831FC0C0 0x0000000185393430-0x0000000185393444
		public float radius { get; set; } // 0x00000001831FC020-0x00000001831FC060 0x0000000183679320-0x0000000183679370
		public float height { get; set; } // 0x00000001831FBFE0-0x00000001831FC020 0x0000000183679370-0x00000001836793C0
		public int direction { get; set; } // 0x00000001831FBFA0-0x00000001831FBFE0 0x00000001836793C0-0x0000000183679410
	
		// Methods
		private void get_center_Injected(out Vector3 ret); // 0x00000001831FC0C0-0x00000001831FC110
		private void set_center_Injected(ref Vector3 value); // 0x0000000184486C50-0x0000000184486CA0
	}

	[NativeHeader("Modules/Physics/BoxCollider.h")]
	[RequiredByNativeCode]
	public class BoxCollider : Collider // TypeDefIndex: 61565
	{
		// Properties
		public Vector3 center { get; set; } // 0x000000018B41F41C-0x000000018B41F448 0x0000000185396B24-0x0000000185396B38
		public Vector3 size { get; set; } // 0x0000000183FB9410-0x0000000183FB9440 0x0000000185396B10-0x0000000185396B24
	
		// Methods
		private void get_center_Injected(out Vector3 ret); // 0x000000018B41F3D8-0x000000018B41F41C
		private void set_center_Injected(ref Vector3 value); // 0x00000001836CCA20-0x00000001836CCA70
		private void get_size_Injected(out Vector3 ret); // 0x0000000183FB9440-0x0000000183FB9A60
		private void set_size_Injected(ref Vector3 value); // 0x00000001836CC9D0-0x00000001836CCA20
	}

	[NativeHeader("Modules/Physics/SphereCollider.h")]
	[RequiredByNativeCode]
	public class SphereCollider : Collider // TypeDefIndex: 61566
	{
		// Properties
		public Vector3 center { get; set; } // 0x000000018B42AFF4-0x000000018B42B020 0x000000018B42B054-0x000000018B42B068
		public float radius { get; set; } // 0x000000018B42B020-0x000000018B42B054 0x000000018375FE40-0x000000018375FE90
	
		// Methods
		private void get_center_Injected(out Vector3 ret); // 0x000000018B42AFB0-0x000000018B42AFF4
		private void set_center_Injected(ref Vector3 value); // 0x0000000184D30C40-0x0000000184D30C90
	}

	[NativeClass("Unity::Joint")]
	[NativeHeader("Modules/Physics/Joint.h")]
	[RequireComponent(typeof(Rigidbody))]
	public class Joint : UnityEngine.Component // TypeDefIndex: 61567
	{
		// Properties
		public Rigidbody connectedBody { get; } // 0x000000018B420F24-0x000000018B420F58 
		public Vector3 connectedAnchor { set; } // 0x000000018B420F9C-0x000000018B420FB0
	
		// Methods
		private void set_connectedAnchor_Injected(ref Vector3 value); // 0x000000018B420F58-0x000000018B420F9C
	}

	[NativeHeader("Modules/Physics/MessageParameters.h")]
	[UsedByNativeCode]
	public struct ContactPoint // TypeDefIndex: 61568
	{
		// Fields
		internal Vector3 m_Point; // 0x00
		internal Vector3 m_Normal; // 0x0C
		internal int m_ThisColliderInstanceID; // 0x18
		internal int m_OtherColliderInstanceID; // 0x1C
		internal float m_Separation; // 0x20
	
		// Properties
		public Vector3 point { get; } // 0x0000000184DBA810-0x0000000184DBA830 
		public Vector3 normal { get; } // 0x0000000184DBA7F0-0x0000000184DBA810 
		public Collider thisCollider { get; } // 0x000000018B4200F0-0x000000018B4200FC 
		public Collider otherCollider { get; } // 0x000000018B4200E4-0x000000018B4200F0 
	
		// Methods
		[FreeFunction]
		private static Collider GetColliderByInstanceID(int instanceID); // 0x000000018B4200B0-0x000000018B4200E4
	}

	[NativeHeader("Modules/Physics/Public/PhysicsSceneHandle.h")]
	public struct PhysicsScene : IEquatable<PhysicsScene> // TypeDefIndex: 61569
	{
		// Fields
		private int m_Handle; // 0x00
	
		// Methods
		public override string ToString(); // 0x000000018B4224E8-0x000000018B422598
		public override int GetHashCode(); // 0x0000000184DBA750-0x0000000184DBA760
		public override bool Equals(object other); // 0x000000018B4219F4-0x000000018B421A58
		public bool Equals(PhysicsScene other); // 0x0000000182EED260-0x0000000182EED270
		public bool Raycast(Vector3 origin, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x0234FCCF */, [UnityEngine.Internal.DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0234FCD3 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0234FCD4 */); // 0x000000018B4223F0-0x000000018B4224E8
		[NativeName("RaycastTest")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B421DC8-0x000000018B421DF0
		public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x0234FCD5 */, [UnityEngine.Internal.DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0234FCD9 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0234FCDA */); // 0x0000000183206EF0-0x0000000183207140
		[NativeName("Raycast")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x00000001853918B8-0x00000001853918E8
		public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x0234FCDB */, [UnityEngine.Internal.DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0234FCDF */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0234FCE0 */); // 0x0000000183206BF0-0x0000000183206EF0
		[NativeName("RaycastNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, [Unmarshalled] RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185391924-0x0000000185391954
		[NativeName("CapsuleCast")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B422390-0x000000018B4223F0
		private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B421C44-0x000000018B421D64
		public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x0234FCE1 */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0234FCE5 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0234FCE6 */); // 0x000000018B421958-0x000000018B4219F4
		[NativeName("CapsuleCastNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int Internal_CapsuleCastNonAlloc(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, [Unmarshalled] RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x00000001853910C8-0x0000000185391128
		public int CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x0234FCE7 */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0234FCEB */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0234FCEC */); // 0x00000001830F20F0-0x00000001830F2210
		[NativeName("CapsuleCastNonAllocV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int Internal_CapsuleCastNonAllocV2(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 diretion, [Unmarshalled] ECSColliderResultProxy[] proxies, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B421BE4-0x000000018B421C44
		public int CapsuleCastV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] proxies, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x0234FCED */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0234FCF1 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0234FCF2 */); // 0x000000018B421864-0x000000018B421958
		[NativeName("OverlapCapsuleNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, [Unmarshalled] Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B421FEC-0x000000018B42202C
		public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask = -1 /* Metadata: 0x0234FCF3 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0234FCF4 */); // 0x000000018B42202C-0x000000018B422110
		[NativeName("OverlapCapsuleNonAllocV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapCapsuleNonAlloc_InternalV2(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, [Unmarshalled] ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185391870-0x00000001853918B0
		public int OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius, [Unmarshalled] ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask = -1 /* Metadata: 0x0234FCF5 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0234FCF6 */); // 0x00000001831FFB20-0x00000001831FFBD0
		[NativeName("SphereCast")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x00000001853936F0-0x0000000185393744
		private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000183730780-0x00000001837308C0
		public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x0234FCF7 */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0234FCFB */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0234FCFC */); // 0x00000001837305E0-0x0000000183730780
		[NativeName("SphereCastNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, [Unmarshalled] RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185391128-0x000000018539117C
		public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x0234FCFD */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0234FD01 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0234FD02 */); // 0x00000001830F5A30-0x00000001830F5BB0
		[NativeName("OverlapSphereNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, [Unmarshalled] Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B422174-0x000000018B4221A4
		public int OverlapSphere(Vector3 position, float radius, Collider[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B4221A4-0x000000018B422268
		[NativeName("OverlapSphereNonAllocV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapSphereNonAllocV2_Internal(PhysicsScene physicsScene, Vector3 position, float radius, [Unmarshalled] ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185395C38-0x0000000185395C68
		public int OverlapSphereV2(Vector3 position, float radius, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x0000000183D7C100-0x0000000183D7C190
		[NativeName("BoxCast")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B4222CC-0x000000018B42232C
		private static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B421A58-0x000000018B421B80
		public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x0234FD03 */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0234FD07 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0234FD08 */); // 0x000000018B4217B8-0x000000018B421864
		[NativeName("OverlapBoxNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, [Unmarshalled] Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B421E54-0x000000018B421E94
		public int OverlapBox(Vector3 center, Vector3 halfExtents, Collider[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0234FD09 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0234FD0A */); // 0x000000018B421E94-0x000000018B421F88
		[NativeName("OverlapBoxNonAllocV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapBoxNonAllocV2_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, [Unmarshalled] ECSColliderResultProxy[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185397930-0x0000000185397970
		public int OverlapBoxV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0234FD0B */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0234FD0C */); // 0x00000001845ADDF0-0x00000001845ADEA0
		[NativeName("BoxCastNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int Internal_BoxCastNonAlloc(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, [Unmarshalled] RaycastHit[] raycastHits, Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185390DC0-0x0000000185390E20
		public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x0234FD0D */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0234FD11 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0234FD12 */); // 0x0000000183027940-0x0000000183027B00
		private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B421D64-0x000000018B421DC8
		private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000183C5DB50-0x0000000183C5DBC0
		private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000183C6CD70-0x0000000183C6CDE0
		private static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B42232C-0x000000018B422390
		private static int Internal_CapsuleCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000183EE4C10-0x0000000183EE4C80
		private static int Internal_CapsuleCastNonAllocV2_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 diretion, ECSColliderResultProxy[] proxies, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B421B80-0x000000018B421BE4
		private static int OverlapCapsuleNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B421F88-0x000000018B421FEC
		private static int OverlapCapsuleNonAlloc_InternalV2_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000183DEFB30-0x0000000183DEFBA0
		private static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000183F08EB0-0x0000000183F08F20
		private static int Internal_SphereCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000183D6D910-0x0000000183D6D980
		private static int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B422110-0x000000018B422174
		private static int OverlapSphereNonAllocV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018438EDE0-0x000000018438EE50
		private static bool Query_BoxCast_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B422268-0x000000018B4222CC
		private static int OverlapBoxNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, Collider[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018B421DF0-0x000000018B421E54
		private static int OverlapBoxNonAllocV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ECSColliderResultProxy[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x00000001845ADEA0-0x00000001845ADF10
		private static int Internal_BoxCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, RaycastHit[] raycastHits, ref Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000183CE61C0-0x0000000183CE6230
	}

	public struct QueryParameters // TypeDefIndex: 61570
	{
		// Fields
		public int layerMask; // 0x00
		public bool hitMultipleFaces; // 0x04
		public bool hitBackfaces; // 0x05
		public QueryTriggerInteraction hitTriggers; // 0x08
	
		// Constructors
		public QueryParameters(int layerMask = -5 /* Metadata: 0x0234FD13 */, bool hitMultipleFaces = false /* Metadata: 0x0234FD14 */, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0234FD15 */, bool hitBackfaces = false /* Metadata: 0x0234FD16 */); // 0x0000000184DBD2A0-0x0000000184DBD2C0
	}

	[NativeHeader("Runtime/Jobs/ScriptBindings/JobsBindingsTypes.h")]
	[NativeHeader("Modules/Physics/BatchCommands/RaycastCommand.h")]
	public struct RaycastCommand // TypeDefIndex: 61571
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector3 _from_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector3 _direction_k__BackingField; // 0x0C
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private float _distance_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PhysicsScene _physicsScene_k__BackingField; // 0x1C
		public QueryParameters queryParameters; // 0x20
	
		// Properties
		public Vector3 from { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184D93250-0x0000000184D93270 0x0000000184DABF80-0x0000000184DABF90
		public Vector3 direction { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184DBD2C0-0x0000000184DBD2E0 0x0000000184DBAA60-0x0000000184DBAA70
		public float distance { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
		public PhysicsScene physicsScene { [CompilerGenerated] set; } // 0x0000000184D86320-0x0000000184D86330
	
		// Constructors
		public RaycastCommand(Vector3 from, Vector3 direction, QueryParameters queryParameters, float distance = 3.4028235E+38f /* Metadata: 0x0234FD17 */); // 0x000000018309E080-0x000000018309E0E0
	
		// Methods
		public static JobHandle ScheduleBatch(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, int maxHits, JobHandle dependsOn = default); // 0x000000018309DDB0-0x000000018309DEF0
		public static JobHandle ScheduleBatch(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn = default); // 0x000000018309DF90-0x000000018309E080
		[FreeFunction("ScheduleRaycastCommandBatch", ThrowsException = true)]
		private static unsafe JobHandle ScheduleRaycastBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits); // 0x000000018309DEF0-0x000000018309DF90
		private static unsafe void ScheduleRaycastBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out JobHandle ret); // 0x000000018309DD40-0x000000018309DDB0
	}

	[NativeHeader("Modules/Physics/BatchCommands/SpherecastCommand.h")]
	[NativeHeader("Runtime/Jobs/ScriptBindings/JobsBindingsTypes.h")]
	public struct SpherecastCommand // TypeDefIndex: 61572
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector3 _origin_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private float _radius_k__BackingField; // 0x0C
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector3 _direction_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private float _distance_k__BackingField; // 0x1C
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PhysicsScene _physicsScene_k__BackingField; // 0x20
		public QueryParameters queryParameters; // 0x24
	
		// Properties
		public Vector3 origin { [CompilerGenerated] set; } // 0x0000000184DABF80-0x0000000184DABF90
		public float radius { [CompilerGenerated] set; } // 0x0000000184DACD70-0x0000000184DACD80
		public Vector3 direction { [CompilerGenerated] set; } // 0x0000000184D8C970-0x0000000184D8C980
		public float distance { [CompilerGenerated] set; } // 0x0000000184D86900-0x0000000184D86910
		public PhysicsScene physicsScene { [CompilerGenerated] set; } // 0x0000000184D86330-0x0000000184D86340
	
		// Constructors
		public SpherecastCommand(Vector3 origin, float radius, Vector3 direction, QueryParameters queryParameters, float distance = 3.4028235E+38f /* Metadata: 0x0234FD1B */); // 0x000000018B42B33C-0x000000018B42B398
	
		// Methods
		public static JobHandle ScheduleBatch(NativeArray<SpherecastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, int maxHits, JobHandle dependsOn = default); // 0x000000018B42B0DC-0x000000018B42B26C
		public static JobHandle ScheduleBatch(NativeArray<SpherecastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn = default); // 0x000000018B42B068-0x000000018B42B0DC
		[FreeFunction("ScheduleSpherecastCommandBatch", ThrowsException = true)]
		private static unsafe JobHandle ScheduleSpherecastBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits); // 0x000000018B42B2D0-0x000000018B42B33C
		private static unsafe void ScheduleSpherecastBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out JobHandle ret); // 0x000000018B42B26C-0x000000018B42B2D0
	}

	[NativeHeader("Runtime/Jobs/ScriptBindings/JobsBindingsTypes.h")]
	[NativeHeader("Modules/Physics/BatchCommands/BoxcastCommand.h")]
	public struct BoxcastCommand // TypeDefIndex: 61573
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector3 _center_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector3 _halfExtents_k__BackingField; // 0x0C
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Quaternion _orientation_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector3 _direction_k__BackingField; // 0x28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private float _distance_k__BackingField; // 0x34
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PhysicsScene _physicsScene_k__BackingField; // 0x38
		public QueryParameters queryParameters; // 0x3C
	
		// Properties
		public Vector3 center { [CompilerGenerated] set; } // 0x0000000184DABF80-0x0000000184DABF90
		public Vector3 halfExtents { [CompilerGenerated] set; } // 0x0000000184DBAA60-0x0000000184DBAA70
		public Quaternion orientation { [CompilerGenerated] set; } // 0x0000000184D890D0-0x0000000184D890E0
		public Vector3 direction { [CompilerGenerated] set; } // 0x0000000184D90C20-0x0000000184D90C30
		public float distance { [CompilerGenerated] set; } // 0x0000000184D8E060-0x0000000184D8E070
		public PhysicsScene physicsScene { [CompilerGenerated] set; } // 0x0000000184D86430-0x0000000184D86440
	
		// Constructors
		public BoxcastCommand(Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, QueryParameters queryParameters, float distance = 3.4028235E+38f /* Metadata: 0x0234FD1F */); // 0x000000018B41F71C-0x000000018B41F790
	
		// Methods
		public static JobHandle ScheduleBatch(NativeArray<BoxcastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, int maxHits, JobHandle dependsOn = default); // 0x000000018B41F4BC-0x000000018B41F64C
		public static JobHandle ScheduleBatch(NativeArray<BoxcastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn = default); // 0x000000018B41F448-0x000000018B41F4BC
		[FreeFunction("ScheduleBoxcastCommandBatch", ThrowsException = true)]
		private static unsafe JobHandle ScheduleBoxcastBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits); // 0x000000018B41F6B0-0x000000018B41F71C
		private static unsafe void ScheduleBoxcastBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out JobHandle ret); // 0x000000018B41F64C-0x000000018B41F6B0
	}
}
