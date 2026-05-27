/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.Internal;
using UnityEngine.Scripting;

// Image 59: UnityEngine.PhysicsModule.dll - Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57929-57963
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

namespace UnityEngine
{
	public enum RigidbodyConstraints // TypeDefIndex: 57932
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

	public enum ForceMode // TypeDefIndex: 57933
	{
		Force = 0,
		Impulse = 1,
		VelocityChange = 2,
		Acceleration = 5
	}

	[Flags]
	public enum MeshColliderCookingOptions // TypeDefIndex: 57934
	{
		None = 0,
		InflateConvexMesh = 1,
		CookForFasterSimulation = 2,
		EnableMeshCleaning = 4,
		WeldColocatedVertices = 8,
		UseFastMidphase = 16
	}

	public enum ColliderSurfaceType // TypeDefIndex: 57935
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

	public enum RigidbodyInterpolation // TypeDefIndex: 57936
	{
		None = 0,
		Interpolate = 1,
		Extrapolate = 2
	}

	[RequiredByNativeCode]
	public class ControllerColliderHit // TypeDefIndex: 57937
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
		public GameObject gameObject { get => default; } // 0x0000000189E1CBF4-0x0000000189E1CC14 
		public Vector3 point { get => default; } // 0x0000000183D87FA0-0x0000000183D87FC0 
	
		// Constructors
		public ControllerColliderHit() {} // Dummy constructor
	}

	[RequiredByNativeCode]
	public class Collision // TypeDefIndex: 57938
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
		public Vector3 relativeVelocity { get => default; } // 0x0000000183D85980-0x0000000183D859A0 
		public Collider collider { get => default; } // 0x0000000183D86D10-0x0000000183D86D20 
		public GameObject gameObject { get => default; } // 0x0000000189E1CB34-0x0000000189E1CBA8 
		public ContactPoint[] contacts { get => default; } // 0x0000000189E1CACC-0x0000000189E1CB34 
		public Vector3 impulse { get => default; } // 0x0000000183D859D0-0x0000000183D859F0 
	
		// Constructors
		public Collision() {} // Dummy constructor
	}

	public enum QueryTriggerInteraction // TypeDefIndex: 57939
	{
		UseGlobal = 0,
		Ignore = 1,
		Collide = 2
	}

	public enum CollisionDetectionMode // TypeDefIndex: 57940
	{
		Discrete = 0,
		Continuous = 1,
		ContinuousDynamic = 2,
		ContinuousSpeculative = 3
	}

	[NativeClass("Unity::ArticulationBody")]
	[NativeHeader("Modules/Physics/ArticulationBody.h")]
	public class ArticulationBody : UnityEngine.Behaviour // TypeDefIndex: 57941
	{
		// Constructors
		public ArticulationBody() {} // 0x000000018426FE60-0x000000018426FE68
	}

	[NativeHeader("Modules/Physics/PhysicsManager.h")]
	[StaticAccessor("GetPhysicsManager()", StaticAccessorType.Dot)]
	public class Physics // TypeDefIndex: 57942
	{
		// Fields
		internal const float k_MaxFloatMinusEpsilon = 3.4028233E+38f; // Metadata: 0x01FDA6F0
		public const int IgnoreRaycastLayer = 4; // Metadata: 0x01FDA6F4
		public const int DefaultRaycastLayers = -5; // Metadata: 0x01FDA6F5
		public const int AllLayers = -1; // Metadata: 0x01FDA6F6
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use Physics.IgnoreRaycastLayer instead. (UnityUpgradable) -> IgnoreRaycastLayer", true)]
		public const int kIgnoreRaycastLayer = 4; // Metadata: 0x01FDA6F7
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use Physics.DefaultRaycastLayers instead. (UnityUpgradable) -> DefaultRaycastLayers", true)]
		public const int kDefaultRaycastLayers = -5; // Metadata: 0x01FDA6F8
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use Physics.AllLayers instead. (UnityUpgradable) -> AllLayers", true)]
		public const int kAllLayers = -1; // Metadata: 0x01FDA6F9
	
		// Properties
		public static Vector3 gravity { [ThreadSafe] get => default; set {} } // 0x000000018282FAC0-0x000000018282FB90 0x0000000189E26928-0x0000000189E26938
		public static float defaultContactOffset { get => default; set {} } // 0x00000001827E7190-0x00000001827E71D0 0x0000000189E267D8-0x0000000189E26814
		public static float sleepThreshold { get => default; set {} } // 0x0000000189E26598-0x0000000189E265C4 0x0000000189E26AB4-0x0000000189E26AF0
		public static bool queriesHitTriggers { get => default; set {} } // 0x0000000189E26540-0x0000000189E2656C 0x0000000189E26A4C-0x0000000189E26A80
		public static bool queriesHitBackfaces { get => default; set {} } // 0x0000000189E26514-0x0000000189E26540 0x0000000189E26A18-0x0000000189E26A4C
		public static float bounceThreshold { get => default; set {} } // 0x0000000189E262F8-0x0000000189E26324 0x0000000189E26750-0x0000000189E2678C
		public static float defaultMaxDepenetrationVelocity { get => default; set {} } // 0x0000000189E263B4-0x0000000189E263E0 0x0000000189E26850-0x0000000189E2688C
		public static int defaultSolverIterations { get => default; set {} } // 0x0000000189E263E0-0x0000000189E2640C 0x0000000189E2688C-0x0000000189E268C0
		public static int defaultSolverVelocityIterations { get => default; set {} } // 0x0000000189E2640C-0x0000000189E26438 0x0000000189E268C0-0x0000000189E268F4
		public static float defaultMaxAngularSpeed { get => default; set {} } // 0x0000000189E26388-0x0000000189E263B4 0x0000000189E26814-0x0000000189E26850
		public static bool improvedPatchFriction { get => default; set {} } // 0x0000000189E26438-0x0000000189E26464 0x0000000189E26938-0x0000000189E2696C
		[NativeProperty("DefaultPhysicsSceneHandle", true, UnityEngine.Bindings.TargetType.Function, true)]
		public static PhysicsScene defaultPhysicsScene { get => default; } // 0x00000001827EDC40-0x00000001827EDC90 
		public static bool logPhysXCheckError { get => default; set {} } // 0x0000000189E264E8-0x0000000189E26514 0x0000000182F2EB90-0x0000000182F2EBD0
		public static bool autoSimulation { get => default; set {} } // 0x0000000182F50A90-0x0000000182F50AD0 0x0000000182F2EBD0-0x0000000182F2EC10
		public static bool autoSyncTransforms { get => default; set {} } // 0x0000000189E262CC-0x0000000189E262F8 0x0000000189E2671C-0x0000000189E26750
		public static bool reuseCollisionCallbacks { get => default; set {} } // 0x0000000189E2656C-0x0000000189E26598 0x0000000189E26A80-0x0000000189E26AB4
		[StaticAccessor("GetPhysicsManager()")]
		public static float interCollisionDistance { [NativeName("GetClothInterCollisionDistance")] get => default; [NativeName("SetClothInterCollisionDistance")] set {} } // 0x0000000189E26464-0x0000000189E26490 0x0000000189E2696C-0x0000000189E269A8
		[StaticAccessor("GetPhysicsManager()")]
		public static float interCollisionStiffness { [NativeName("GetClothInterCollisionStiffness")] get => default; [NativeName("SetClothInterCollisionStiffness")] set {} } // 0x0000000189E264BC-0x0000000189E264E8 0x0000000189E269DC-0x0000000189E26A18
		[StaticAccessor("GetPhysicsManager()")]
		public static bool interCollisionSettingsToggle { [NativeName("GetClothInterCollisionSettingsToggle")] get => default; [NativeName("SetClothInterCollisionSettingsToggle")] set {} } // 0x0000000189E26490-0x0000000189E264BC 0x0000000189E269A8-0x0000000189E269DC
		public static Vector3 clothGravity { [ThreadSafe] get => default; set {} } // 0x0000000189E26364-0x0000000189E26388 0x0000000189E267C8-0x0000000189E267D8
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Physics.defaultContactOffset or Collider.contactOffset instead.", true)]
		public static float minPenetrationForPenalty { get => default; set {} } // 0x0000000183D85FA0-0x0000000183D85FB0 0x000000018350B670-0x000000018350B680
		[Obsolete("Please use bounceThreshold instead. (UnityUpgradable) -> bounceThreshold")]
		public static float bounceTreshold { get => default; set {} } // 0x0000000189E26324-0x0000000189E26330 0x0000000189E2678C-0x0000000189E26794
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", true)]
		public static float sleepVelocity { get => default; set {} } // 0x0000000183D85FA0-0x0000000183D85FB0 0x000000018350B670-0x000000018350B680
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("The sleepAngularVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", true)]
		public static float sleepAngularVelocity { get => default; set {} } // 0x0000000183D85FA0-0x0000000183D85FB0 0x000000018350B670-0x000000018350B680
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Rigidbody.maxAngularVelocity instead.", true)]
		public static float maxAngularVelocity { get => default; set {} } // 0x0000000183D85FA0-0x0000000183D85FB0 0x000000018350B670-0x000000018350B680
		[Obsolete("Please use Physics.defaultSolverIterations instead. (UnityUpgradable) -> defaultSolverIterations")]
		public static int solverIterationCount { get => default; set {} } // 0x0000000189E265C4-0x0000000189E265D0 0x0000000189E26AF0-0x0000000189E26AF8
		[Obsolete("Please use Physics.defaultSolverVelocityIterations instead. (UnityUpgradable) -> defaultSolverVelocityIterations")]
		public static int solverVelocityIterationCount { get => default; set {} } // 0x0000000189E265D0-0x0000000189E265DC 0x0000000189E26AF8-0x0000000189E26B00
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("penetrationPenaltyForce has no effect.", true)]
		public static float penetrationPenaltyForce { get => default; set {} } // 0x0000000183D85FA0-0x0000000183D85FB0 0x000000018350B670-0x000000018350B680
	
		// Events
		public static event Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent;
		public static event Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD;
	
		// Constructors
		public Physics() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[RequiredByNativeCode]
		private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) {} // 0x0000000189E227F8-0x0000000189E228B4
		public static void ClearUnusedMemory() {} // 0x0000000183D46E90-0x0000000183D46ED0
		public static void IgnoreCollision([NotNull("NullExceptionObject")] Collider collider1, [NotNull("NullExceptionObject")] Collider collider2, [UnityEngine.Internal.DefaultValue("true")] bool ignore) {} // 0x0000000189E221C4-0x0000000189E22218
		[ExcludeFromDocs]
		public static void IgnoreCollision(Collider collider1, Collider collider2) {} // 0x0000000189E22218-0x0000000189E22224
		[NativeName("IgnoreCollision")]
		public static void IgnoreLayerCollision(int layer1, int layer2, [UnityEngine.Internal.DefaultValue("true")] bool ignore) {} // 0x0000000189E22230-0x0000000189E22280
		[NativeName("ForceRebuildDynamicTree")]
		public static void ForceRebuildDynamicTree(bool rebuildStatic, bool rebuildDynamic) {} // 0x0000000189E220FC-0x0000000189E22140
		[ExcludeFromDocs]
		public static void IgnoreLayerCollision(int layer1, int layer2) {} // 0x0000000189E22224-0x0000000189E22230
		public static bool GetIgnoreLayerCollision(int layer1, int layer2) => default; // 0x0000000189E22184-0x0000000189E221C4
		public static bool GetIgnoreCollision([NotNull("NullExceptionObject")] Collider collider1, [NotNull("NullExceptionObject")] Collider collider2) => default; // 0x0000000189E22140-0x0000000189E22184
		public static bool Raycast(Vector3 origin, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E25200-0x0000000189E25298
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) => default; // 0x0000000189E250E0-0x0000000189E25170
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) => default; // 0x0000000189E255B8-0x0000000189E25640
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction) => default; // 0x0000000189E254BC-0x0000000189E25534
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x00000001827EE8C0-0x00000001827EEB80
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x0000000182FA35E0-0x0000000182FA3680
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x0000000182EC0080-0x0000000182EC0330
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000189E25170-0x0000000189E25200
		public static bool RaycastV2(ECSColliderResultProxy proxy, Ray ray, float maxDistance, out RaycastHit hit) {
			hit = default;
			return default;
		} // 0x0000000189E24FB8-0x0000000189E2504C
		public static bool RaycastV2(ECSColliderResultProxy proxy, Ray ray, float maxDistance, bool hitHoles, out RaycastHit hit) {
			hit = default;
			return default;
		} // 0x0000000189E2504C-0x0000000189E250E0
		[NativeName("RaycastTestV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static RaycastHit Internal_RaycastTestV2(ECSColliderResultProxy collider, Ray ray, float maxDistance, bool hitHoles, ref bool hasHit) => default; // 0x0000000189E22428-0x0000000189E2249C
		public static bool Raycast(Ray ray, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E2542C-0x0000000189E254BC
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, float maxDistance, int layerMask) => default; // 0x0000000189E25298-0x0000000189E25320
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, float maxDistance) => default; // 0x0000000189E25320-0x0000000189E2539C
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray) => default; // 0x0000000189E25640-0x0000000189E256AC
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000182DDC180-0x0000000182DDC220
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x00000001829119B0-0x0000000182911A10
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x0000000189E2539C-0x0000000189E2542C
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000189E25534-0x0000000189E255B8
		public static bool Linecast(Vector3 start, Vector3 end, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E22698-0x0000000189E22768
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end, int layerMask) => default; // 0x0000000189E22768-0x0000000189E227B0
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end) => default; // 0x0000000189E2264C-0x0000000189E22698
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000189E22528-0x0000000189E22600
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x0000000189E227B0-0x0000000189E227F8
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000189E22600-0x0000000189E2264C
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E21350-0x0000000189E21424
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask) => default; // 0x0000000189E215F8-0x0000000189E21670
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance) => default; // 0x0000000189E214A8-0x0000000189E2151C
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction) => default; // 0x0000000189E21254-0x0000000189E212C8
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000189E2151C-0x0000000189E215F8
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x0000000189E212C8-0x0000000189E21350
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x0000000189E211CC-0x0000000189E21254
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000189E21424-0x0000000189E214A8
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x00000001827E7EB0-0x00000001827E7F60
		[ExcludeFromDocs]
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x0000000189E25D64-0x0000000189E25DC8
		[ExcludeFromDocs]
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x0000000189E25FB8-0x0000000189E26018
		[ExcludeFromDocs]
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000189E25E3C-0x0000000189E25E9C
		public static bool SphereCast(Ray ray, float radius, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E25E9C-0x0000000189E25F40
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask) => default; // 0x0000000189E25F84-0x0000000189E25FB8
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, float maxDistance) => default; // 0x0000000189E25E04-0x0000000189E25E3C
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius) => default; // 0x0000000189E26078-0x0000000189E260B8
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000189E26018-0x0000000189E26078
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x0000000189E260B8-0x0000000189E260F4
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x0000000189E25DC8-0x0000000189E25E04
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000189E25F40-0x0000000189E25F84
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E204B8-0x0000000189E2058C
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask) => default; // 0x0000000189E20808-0x0000000189E20894
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance) => default; // 0x0000000189E206BC-0x0000000189E20744
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation) => default; // 0x0000000189E20928-0x0000000189E209B0
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction) => default; // 0x0000000189E20428-0x0000000189E204B8
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000189E20744-0x0000000189E20808
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x0000000189E2058C-0x0000000189E20624
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x0000000189E209B0-0x0000000189E20A44
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation) {
			hitInfo = default;
			return default;
		} // 0x0000000189E20894-0x0000000189E20928
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000189E20624-0x0000000189E206BC
		[NativeName("RaycastAll")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E2239C-0x0000000189E223C4
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E24A60-0x0000000189E24B84
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) => default; // 0x0000000189E24A18-0x0000000189E24A60
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) => default; // 0x0000000189E24BD0-0x0000000189E24C1C
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) => default; // 0x0000000189E24C1C-0x0000000189E24C70
		public static RaycastHit[] RaycastAll(Ray ray, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E24B84-0x0000000189E24BD0
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) => default; // 0x0000000189E249CC-0x0000000189E24A18
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) => default; // 0x0000000189E2497C-0x0000000189E249CC
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray) => default; // 0x0000000189E24C70-0x0000000189E24CC4
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000183115370-0x0000000183115500
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) => default; // 0x0000000189E24D54-0x0000000189E24DEC
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) => default; // 0x0000000189E24CC4-0x0000000189E24D54
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) => default; // 0x0000000183559320-0x00000001835593B0
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x00000001827ED890-0x00000001827EDC40
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) => default; // 0x0000000189E24E88-0x0000000189E24F28
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) => default; // 0x0000000189E24DEC-0x0000000189E24E88
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) => default; // 0x0000000189E24F28-0x0000000189E24FB8
		[NativeName("CapsuleCastAll")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static RaycastHit[] Query_CapsuleCastAll(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E24328-0x0000000189E2437C
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E20A44-0x0000000189E20B84
		[ExcludeFromDocs]
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask) => default; // 0x0000000189E20BF8-0x0000000189E20C70
		[ExcludeFromDocs]
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance) => default; // 0x0000000189E20B84-0x0000000189E20BF8
		[ExcludeFromDocs]
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction) => default; // 0x0000000189E20C70-0x0000000189E20CE4
		[NativeName("SphereCastAll")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E24884-0x0000000189E248C4
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E259F8-0x0000000189E25B24
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask) => default; // 0x0000000189E25830-0x0000000189E25884
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance) => default; // 0x0000000189E25970-0x0000000189E259C0
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction) => default; // 0x0000000189E25918-0x0000000189E25970
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E258C4-0x0000000189E25918
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask) => default; // 0x0000000189E257FC-0x0000000189E25830
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance) => default; // 0x0000000189E259C0-0x0000000189E259F8
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Ray ray, float radius) => default; // 0x0000000189E25884-0x0000000189E258C4
		[NativeName("OverlapCapsule")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static Collider[] OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E23958-0x0000000189E23988
		public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E23A4C-0x0000000189E23B24
		[ExcludeFromDocs]
		public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask) => default; // 0x0000000189E23988-0x0000000189E23A4C
		[ExcludeFromDocs]
		public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius) => default; // 0x0000000189E23B24-0x0000000189E23BDC
		[NativeName("OverlapCapsuleV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static ECSColliderResultProxy[] OverlapCapsuleV2_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E237A4-0x0000000189E237D4
		public static ECSColliderResultProxy[] OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E23868-0x0000000189E238F4
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius, int layerMask) => default; // 0x0000000189E23820-0x0000000189E23868
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius) => default; // 0x0000000189E237D4-0x0000000189E23820
		[NativeName("OverlapSphere")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E240B0-0x0000000189E240D8
		public static Collider[] OverlapSphere(Vector3 position, float radius, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E24178-0x0000000189E24230
		public static ECSColliderResultProxy CreateECSProxy(Collider collider) => default; // 0x000000018270A7C0-0x000000018270A950
		[ExcludeFromDocs]
		public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask) => default; // 0x0000000189E240D8-0x0000000189E24178
		[ExcludeFromDocs]
		public static Collider[] OverlapSphere(Vector3 position, float radius) => default; // 0x0000000189E24230-0x0000000189E242C4
		[NativeName("OverlapSphereV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static ECSColliderResultProxy[] OverlapSphereV2_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E23F50-0x0000000189E23F78
		public static ECSColliderResultProxy[] OverlapSphereV2(Vector3 position, float radius, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E23FB0-0x0000000189E2401C
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapSphereV2(Vector3 position, float radius, int layerMask) => default; // 0x0000000189E2401C-0x0000000189E2404C
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapSphereV2(Vector3 position, float radius) => default; // 0x0000000189E23F78-0x0000000189E23FB0
		[NativeName("Simulate")]
		internal static void Simulate_Internal(PhysicsScene physicsScene, float step) {} // 0x00000001842747DC-0x00000001842747F8
		public static void Simulate(float step) {} // 0x0000000182F50A00-0x0000000182F50A90
		public static void SyncTransforms() {} // 0x0000000182722980-0x0000000182722AB0
		[NativeName("ComputePenetration")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputePenetration([NotNull("ArgumentNullException")] Collider colliderA, Vector3 positionA, Quaternion rotationA, [NotNull("ArgumentNullException")] Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x0000000189E24738-0x0000000189E24784
		public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) {
			direction = default;
			distance = default;
			return default;
		} // 0x0000000189E21F14-0x0000000189E2204C
		[NativeName("ComputePenetrationV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputePenetrationV2(ECSColliderResultProxy colliderA, Vector3 positionA, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x0000000184272A3C-0x0000000184272A88
		public static bool ComputePenetrationV2(ECSColliderResultProxy colliderA, Vector3 positionA, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) {
			direction = default;
			distance = default;
			return default;
		} // 0x0000000182B2F270-0x0000000182B2F390
		[NativeName("ComputeCapsulePenetration")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputeCapsulePenetration(Vector3 point1, Vector3 point2, float radius, [NotNull("ArgumentNullException")] Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x0000000189E24688-0x0000000189E246D4
		public static bool ComputeCapsulePenetration(Vector3 point1, Vector3 point2, float radius, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) {
			direction = default;
			distance = default;
			return default;
		} // 0x0000000189E21DE8-0x0000000189E21F14
		[NativeName("ComputeCapsulePenetrationV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputeCapsulePenetrationV2(Vector3 point1, Vector3 point2, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x0000000189E245D8-0x0000000189E24624
		public static bool ComputeCapsulePenetrationV2(Vector3 point1, Vector3 point2, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) {
			direction = default;
			distance = default;
			return default;
		} // 0x0000000189E21D1C-0x0000000189E21DE8
		[NativeName("ComputeSpherePenetrationV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputeSpherePenetrationV2(Vector3 center, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x0000000189E247E8-0x0000000189E24820
		public static bool ComputeSpherePenetrationV2(Vector3 center, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) {
			direction = default;
			distance = default;
			return default;
		} // 0x0000000189E2204C-0x0000000189E220FC
		[NativeName("ComputeBoxPenetrationV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputeBoxPenetrationV2(Vector3 center, Vector3 halfExtent, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x0000000189E24528-0x0000000189E24574
		public static bool ComputeBoxPenetrationV2(Vector3 center, Vector3 halfExtent, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) {
			direction = default;
			distance = default;
			return default;
		} // 0x0000000189E21C40-0x0000000189E21D1C
		[NativeName("IsSimulatedThisFrame")]
		[StaticAccessor("GetPhysicsManager()")]
		private static bool IsSimulatedThisFrame_Internal() => default; // 0x0000000189E224F0-0x0000000189E2251C
		public static bool IsSimulatedThisFrame() => default; // 0x0000000189E2251C-0x0000000189E22528
		[NativeName("SetForceSimulateThisFrame")]
		[StaticAccessor("GetPhysicsManager()")]
		private static void SetForceSimulateThisFrame_Internal(bool force) {} // 0x0000000189E257C0-0x0000000189E257F4
		public static void SetForceSimulateThisFrame(bool force) {} // 0x0000000189E257F4-0x0000000189E257FC
		[NativeName("SetFastSimulate")]
		[StaticAccessor("GetPhysicsManager()")]
		private static void SetFastSimulate_Internal(bool fast) {} // 0x0000000183D1EE20-0x0000000183D1EE60
		public static void SetFastSimulate(bool fast) {} // 0x00000001842746E4-0x00000001842746EC
		[NativeName("ClosestPoint")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static Vector3 Query_ClosestPoint([NotNull("ArgumentNullException")] Collider collider, Vector3 position, Quaternion rotation, Vector3 point) => default; // 0x0000000189E24484-0x0000000189E244C4
		public static Vector3 ClosestPoint(Vector3 point, Collider collider, Vector3 position, Quaternion rotation) => default; // 0x0000000189E21B48-0x0000000189E21C40
		[NativeName("ClosestPointV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static Vector3 Query_ClosestPointV2(ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation, Vector3 point) => default; // 0x0000000189E243E0-0x0000000189E24420
		public static Vector3 ClosestPointV2(Vector3 point, ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation) => default; // 0x0000000189E21AA4-0x0000000189E21B48
		[NativeName("TryGetClosestPoint")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static Vector3 Query_TryGetClosestPoint(ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation, Vector3 point, ref bool resultIsValid) => default; // 0x0000000189E24928-0x0000000189E2497C
		public static bool TryGetClosestPoint(ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation, Vector3 point, out Vector3 result) {
			result = default;
			return default;
		} // 0x0000000189E260F4-0x0000000189E2618C
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E23E20-0x0000000189E23EEC
		[ExcludeFromDocs]
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask) => default; // 0x0000000189E23D6C-0x0000000189E23E20
		[ExcludeFromDocs]
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results) => default; // 0x0000000189E23CC4-0x0000000189E23D6C
		public static int OverlapSphereNonAllocV2(Vector3 position, float radius, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E23BDC-0x0000000189E23C5C
		[ExcludeFromDocs]
		public static int OverlapSphereNonAllocV2(Vector3 position, float radius, ECSColliderResultProxy[] results, int layerMask) => default; // 0x0000000189E23C94-0x0000000189E23CC4
		[ExcludeFromDocs]
		public static int OverlapSphereNonAllocV2(Vector3 position, float radius, ECSColliderResultProxy[] results) => default; // 0x0000000189E23C5C-0x0000000189E23C94
		[NativeName("SphereTest")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E219A8-0x0000000189E219D0
		public static bool CheckSphere(Vector3 position, float radius, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E21A08-0x0000000189E21A74
		[ExcludeFromDocs]
		public static bool CheckSphere(Vector3 position, float radius, int layerMask) => default; // 0x0000000189E21A74-0x0000000189E21AA4
		[ExcludeFromDocs]
		public static bool CheckSphere(Vector3 position, float radius) => default; // 0x0000000189E219D0-0x0000000189E21A08
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000182B30890-0x0000000182B309D0
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E20E88-0x0000000189E20F64
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) => default; // 0x0000000189E21038-0x0000000189E210C0
		[ExcludeFromDocs]
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask) => default; // 0x0000000189E20F64-0x0000000189E21038
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance) => default; // 0x0000000189E21144-0x0000000189E211CC
		[ExcludeFromDocs]
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance) => default; // 0x0000000189E20DB4-0x0000000189E20E88
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results) => default; // 0x0000000189E210C0-0x0000000189E21144
		[ExcludeFromDocs]
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results) => default; // 0x0000000189E20CE4-0x0000000189E20DB4
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000182B32740-0x0000000182B328D0
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) => default; // 0x0000000189E25CA0-0x0000000189E25D04
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance) => default; // 0x0000000189E25BE0-0x0000000189E25C40
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results) => default; // 0x0000000189E25D04-0x0000000189E25D64
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E25C40-0x0000000189E25CA0
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask) => default; // 0x0000000189E25B68-0x0000000189E25BA4
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance) => default; // 0x0000000189E25BA4-0x0000000189E25BE0
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results) => default; // 0x0000000189E25B24-0x0000000189E25B68
		[NativeName("CapsuleTest")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000184271A08-0x0000000184271A38
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x00000001827E6B50-0x00000001827E6BF0
		[ExcludeFromDocs]
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask) => default; // 0x0000000189E218B0-0x0000000189E218F8
		[ExcludeFromDocs]
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius) => default; // 0x0000000189E218F8-0x0000000189E21944
		[NativeName("BoxTest")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E216D4-0x0000000189E21704
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layermask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E217C8-0x0000000189E2185C
		[ExcludeFromDocs]
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) => default; // 0x0000000189E2185C-0x0000000189E218B0
		[ExcludeFromDocs]
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation) => default; // 0x0000000189E21704-0x0000000189E21760
		[ExcludeFromDocs]
		public static bool CheckBox(Vector3 center, Vector3 halfExtents) => default; // 0x0000000189E21760-0x0000000189E217C8
		[NativeName("OverlapBox")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E230A8-0x0000000189E230D8
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E2325C-0x0000000189E23340
		[ExcludeFromDocs]
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) => default; // 0x0000000189E23340-0x0000000189E23414
		[ExcludeFromDocs]
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation) => default; // 0x0000000189E230D8-0x0000000189E2319C
		[ExcludeFromDocs]
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents) => default; // 0x0000000189E2319C-0x0000000189E2325C
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("AllLayers")] int mask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E22A84-0x0000000189E22B80
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask) => default; // 0x0000000189E22B80-0x0000000189E22C5C
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation) => default; // 0x0000000189E22C5C-0x0000000189E22D34
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results) => default; // 0x0000000189E22D34-0x0000000189E22E08
		[NativeName("OverlapBoxV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static ECSColliderResultProxy[] OverlapBoxV2_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E22E6C-0x0000000189E22E9C
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E22FB0-0x0000000189E23044
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) => default; // 0x0000000189E22F5C-0x0000000189E22FB0
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents, Quaternion orientation) => default; // 0x0000000189E22E9C-0x0000000189E22EF4
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents) => default; // 0x0000000189E22EF4-0x0000000189E22F5C
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("AllLayers")] int mask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E229D4-0x0000000189E22A84
		[ExcludeFromDocs]
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, Quaternion orientation, int mask) => default; // 0x0000000189E2291C-0x0000000189E2297C
		[ExcludeFromDocs]
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, Quaternion orientation) => default; // 0x0000000189E2297C-0x0000000189E229D4
		[ExcludeFromDocs]
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results) => default; // 0x0000000189E228B4-0x0000000189E2291C
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000182423710-0x0000000182423860
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation) => default; // 0x0000000189E20300-0x0000000189E20394
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance) => default; // 0x0000000189E20394-0x0000000189E20428
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layerMask) => default; // 0x0000000189E201D0-0x0000000189E20268
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results) => default; // 0x0000000189E20268-0x0000000189E20300
		[NativeName("BoxCastAll")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static RaycastHit[] Internal_BoxCastAll(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E222E4-0x0000000189E22338
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1FE5C-0x0000000189E1FFA4
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask) => default; // 0x0000000189E200B4-0x0000000189E20140
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance) => default; // 0x0000000189E1FFA4-0x0000000189E2002C
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation) => default; // 0x0000000189E2002C-0x0000000189E200B4
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction) => default; // 0x0000000189E20140-0x0000000189E201D0
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E23650-0x0000000189E23740
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask) => default; // 0x0000000189E234B0-0x0000000189E23584
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results) => default; // 0x0000000189E23584-0x0000000189E23650
		public static int OverlapCapsuleNonAllocV2(Vector3 point0, Vector3 point1, float radius, [Unmarshalled] ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000182B34920-0x0000000182B349D0
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAllocV2(Vector3 point0, Vector3 point1, float radius, [Unmarshalled] ECSColliderResultProxy[] results, int layerMask) => default; // 0x0000000189E23460-0x0000000189E234B0
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAllocV2(Vector3 point0, Vector3 point1, float radius, [Unmarshalled] ECSColliderResultProxy[] results) => default; // 0x0000000189E23414-0x0000000189E23460
		[NativeName("RebuildBroadphaseRegions")]
		[StaticAccessor("GetPhysicsManager()")]
		private static void Internal_RebuildBroadphaseRegions(Bounds bounds, int subdivisions) {} // 0x0000000189E224DC-0x0000000189E224F0
		public static void RebuildBroadphaseRegions(Bounds worldBounds, int subdivisions) {} // 0x0000000189E256AC-0x0000000189E257C0
		[StaticAccessor("GetPhysicsManager()")]
		[ThreadSafe]
		public static void BakeMesh(int meshID, bool convex) {} // 0x0000000189E1FE1C-0x0000000189E1FE5C
		private static void get_gravity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018282FA80-0x000000018282FAC0
		private static void set_gravity_Injected(ref Vector3 value) {} // 0x0000000189E268F4-0x0000000189E26928
		private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) {
			ret = default;
		} // 0x00000001827EDC90-0x00000001827EDCD0
		private static void Internal_RaycastTestV2_Injected(ref ECSColliderResultProxy collider, ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x0000000189E223C4-0x0000000189E22428
		private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E22338-0x0000000189E2239C
		private static RaycastHit[] Query_CapsuleCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E242C4-0x0000000189E24328
		private static RaycastHit[] Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E24820-0x0000000189E24884
		private static Collider[] OverlapCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E238F4-0x0000000189E23958
		private static ECSColliderResultProxy[] OverlapCapsuleV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E23740-0x0000000189E237A4
		private static Collider[] OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E2404C-0x0000000189E240B0
		private static ECSColliderResultProxy[] OverlapSphereV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E23EEC-0x0000000189E23F50
		private static void Simulate_Internal_Injected(ref PhysicsScene physicsScene, float step) {} // 0x0000000182F50AD0-0x0000000182F50B20
		private static bool Query_ComputePenetration_Injected(Collider colliderA, ref Vector3 positionA, ref Quaternion rotationA, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x0000000189E246D4-0x0000000189E24738
		private static bool Query_ComputePenetrationV2_Injected(ref ECSColliderResultProxy colliderA, ref Vector3 positionA, ref Quaternion rotationA, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x0000000182B2D850-0x0000000182B2D8C0
		private static bool Query_ComputeCapsulePenetration_Injected(ref Vector3 point1, ref Vector3 point2, float radius, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x0000000189E24624-0x0000000189E24688
		private static bool Query_ComputeCapsulePenetrationV2_Injected(ref Vector3 point1, ref Vector3 point2, float radius, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x0000000189E24574-0x0000000189E245D8
		private static bool Query_ComputeSpherePenetrationV2_Injected(ref Vector3 center, float radius, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x0000000189E24784-0x0000000189E247E8
		private static bool Query_ComputeBoxPenetrationV2_Injected(ref Vector3 center, ref Vector3 halfExtent, ref Quaternion rotationA, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x0000000189E244C4-0x0000000189E24528
		private static void Query_ClosestPoint_Injected(Collider collider, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, out Vector3 ret) {
			ret = default;
		} // 0x0000000189E24420-0x0000000189E24484
		private static void Query_ClosestPointV2_Injected(ref ECSColliderResultProxy colliderProxy, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, out Vector3 ret) {
			ret = default;
		} // 0x0000000189E2437C-0x0000000189E243E0
		private static void Query_TryGetClosestPoint_Injected(ref ECSColliderResultProxy colliderProxy, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, ref bool resultIsValid, out Vector3 ret) {
			ret = default;
		} // 0x0000000189E248C4-0x0000000189E24928
		private static void get_clothGravity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189E26330-0x0000000189E26364
		private static void set_clothGravity_Injected(ref Vector3 value) {} // 0x0000000189E26794-0x0000000189E267C8
		private static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E21944-0x0000000189E219A8
		private static bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x00000001834F0100-0x00000001834F0170
		private static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E21670-0x0000000189E216D4
		private static Collider[] OverlapBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E23044-0x0000000189E230A8
		private static ECSColliderResultProxy[] OverlapBoxV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E22E08-0x0000000189E22E6C
		private static RaycastHit[] Internal_BoxCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E22280-0x0000000189E222E4
		private static void Internal_RebuildBroadphaseRegions_Injected(ref Bounds bounds, int subdivisions) {} // 0x0000000189E2249C-0x0000000189E224DC
	}

	public struct ModifiableContactPair // TypeDefIndex: 57943
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
	public class PhysicMaterial : UnityEngine.Object // TypeDefIndex: 57944
	{
		// Constructors
		public PhysicMaterial() {} // 0x0000000189E1EDC4-0x0000000189E1EE18
	
		// Methods
		private static void Internal_CreateDynamicsMaterial([Writable] PhysicMaterial mat, string name) {} // 0x0000000189E1ED80-0x0000000189E1EDC4
	}

	[NativeHeader("Modules/Physics/RaycastHit.h")]
	[NativeHeader("PhysicsScriptingClasses.h")]
	[NativeHeader("Runtime/Interfaces/IRaycast.h")]
	[UsedByNativeCode]
	public struct ECSColliderResultProxy : IEquatable<ECSColliderResultProxy> // TypeDefIndex: 57945
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
		public int componentIndex { get => default; } // 0x0000000183D4FB00-0x0000000183D4FB10 
		public Entity colliderEntity { get => default; } // 0x00000001838A92F0-0x00000001838A9300 
		public int ecsId { get => default; } // 0x0000000183D68070-0x0000000183D68080 
		public uint ecsVersion { get => default; } // 0x0000000183D682F0-0x0000000183D68300 
		public static ECSColliderResultProxy invalid { get => default; } // 0x0000000189E1D3FC-0x0000000189E1D460 
		public Collider collider { get => default; } // 0x00000001827EBAB0-0x00000001827EBB50 
		public int colliderInstanceId { get => default; } // 0x0000000183D85B00-0x0000000183D85B10 
		public bool bIsECS { get => default; } // 0x00000001827EC5F0-0x00000001827EC610 
		public int tagConfig { get => default; } // 0x0000000182351D80-0x0000000182351E50 
		public bool isTrigger { get => default; } // 0x0000000189E1D460-0x0000000189E1D580 
		public int layer { get => default; } // 0x0000000182B334B0-0x0000000182B335F0 
		public Transform transform { get => default; } // 0x0000000182B34130-0x0000000182B34330 
		public Vector3 transformPosition { get => default; } // 0x0000000182B2EB30-0x0000000182B2ECA0 
		public Quaternion transformRotation { get => default; } // 0x0000000182B2ECA0-0x0000000182B2EE10 
		public Vector3 transformLossyScale { get => default; } // 0x0000000189E1D580-0x0000000189E1D688 
		public Vector3 shapePosition { get => default; } // 0x000000018301EFB0-0x000000018301F140 
		public Bounds bounds { get => default; } // 0x0000000183271780-0x0000000183271870 
		public int colliderOptions { get => default; } // 0x00000001827EC8B0-0x00000001827ECA20 
		public ColliderSurfaceType surfaceType { get => default; } // 0x0000000182FA3070-0x0000000182FA3100 
		public ECSColliderType colliderType { get => default; } // 0x0000000189E1D2A0-0x0000000189E1D3FC 
		public GameObject gameObject { get => default; } // 0x0000000182B2FBB0-0x0000000182B2FC80 
		public bool hasComplexMesh { get => default; } // 0x00000001827EAB90-0x00000001827EAC40 
	
		// Constructors
		static ECSColliderResultProxy() {
			INVALID_PROXY = default;
		} // 0x0000000183D2D040-0x0000000183D2D080
	
		// Methods
		public void SetColliderAndSetIndex(int colliderInstanceID) {} // 0x00000001827EBDA0-0x00000001827EBF60
		public void SetComponentIndex(int index) {} // 0x0000000183D595B0-0x0000000183D595C0
		public void SetActor(IntPtr actor) {} // 0x0000000183D51730-0x0000000183D51740
		public void SetEcsId(int id) {} // 0x0000000183D51710-0x0000000183D51720
		public void SetEcsVersion(uint version) {} // 0x0000000183D55690-0x0000000183D556A0
		public bool IsValid() => default; // 0x00000001827EC610-0x00000001827EC850
		public string GetColliderGoName() => default; // 0x0000000189E1CF68-0x0000000189E1D028
		public int GetFactoryBuildingIdentifier() => default; // 0x00000001827E5B60-0x00000001827E5BE0
		public bool TryGetClosestPoint(Vector3 point, out Vector3 result) {
			result = default;
			return default;
		} // 0x0000000189E1D188-0x0000000189E1D2A0
		public Vector3 ClosestPoint(Vector3 position) => default; // 0x0000000189E1CC14-0x0000000189E1CD60
		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x0000000189E1D028-0x0000000189E1D188
		public static bool operator ==(ECSColliderResultProxy left, ECSColliderResultProxy right) => default; // 0x0000000189E1D688-0x0000000189E1D718
		public static bool operator !=(ECSColliderResultProxy left, ECSColliderResultProxy right) => default; // 0x000000018240A950-0x000000018240A9F0
		public bool Equals(ECSColliderResultProxy other) => default; // 0x000000018354DDA0-0x000000018354DE40
		public override bool Equals(object obj) => default; // 0x0000000189E1CEC4-0x0000000189E1CF68
		public override int GetHashCode() => default; // 0x00000001833018D0-0x00000001833019B0
		public bool CompareTag(int tagValue) => default; // 0x0000000189E1CD60-0x0000000189E1CEC4
		public bool IsSameCollider(Collider otherCollider) => default; // 0x0000000182B34330-0x0000000182B343F0
	}

	[NativeHeader("Runtime/Interfaces/IRaycast.h")]
	[NativeHeader("Modules/Physics/RaycastHit.h")]
	[NativeHeader("PhysicsScriptingClasses.h")]
	[UsedByNativeCode]
	public struct RaycastHit // TypeDefIndex: 57946
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
		public int ecsId { get => default; } // 0x0000000183D85A80-0x0000000183D85A90 
		public uint ecsVersion { get => default; } // 0x0000000183D85A10-0x0000000183D85A20 
		public bool IsECSCollider { get => default; } // 0x00000001827E5B40-0x00000001827E5B60 
		public Collider collider { get => default; } // 0x00000001832E3150-0x00000001832E31C0 
		public int colliderInstanceID { get => default; } // 0x0000000183D86D30-0x0000000183D86D40 
		public Collider editorCollider { get => default; } // 0x0000000189E26C3C-0x0000000189E26CCC 
		public ECSColliderResultProxy colliderProxy { get => default; } // 0x00000001827EBB50-0x00000001827EBDA0 
		public Vector3 point { get => default; set {} } // 0x0000000183D85920-0x0000000183D85940 0x0000000183D56570-0x0000000183D56580
		public Vector3 normal { get => default; set {} } // 0x0000000183D85900-0x0000000183D85920 0x0000000183D56580-0x0000000183D56590
		public Vector3 barycentricCoordinate { get => default; set {} } // 0x0000000183D87FE0-0x0000000183D88010 0x0000000189E271E8-0x0000000189E27208
		public float distance { get => default; set {} } // 0x0000000183D87EB0-0x0000000183D87EC0 0x0000000183D4F120-0x0000000183D4F130
		public int triangleIndex { get => default; } // 0x0000000183D68AE0-0x0000000183D68AF0 
		public int componentIndex { get => default; } // 0x0000000183D88010-0x0000000183D88020 
		public Vector2 textureCoord { get => default; } // 0x0000000189E270C8-0x0000000189E27124 
		public Vector2 textureCoord2 { get => default; } // 0x0000000189E27068-0x0000000189E270C8 
		public Transform transform { get => default; } // 0x0000000189E27124-0x0000000189E271E8 
		public Vector3 shapePosition { get => default; } // 0x0000000189E26FE0-0x0000000189E27020 
		public Quaternion shapeRotation { get => default; } // 0x0000000189E27020-0x0000000189E27058 
		public Vector3 position { get => default; } // 0x0000000189E26E38-0x0000000189E26E6C 
		public Quaternion rotation { get => default; } // 0x0000000189E26EFC-0x0000000189E26F28 
		public Vector3 scale { get => default; } // 0x0000000189E26F28-0x0000000189E26FE0 
		public Rigidbody rigidbody { get => default; } // 0x0000000189E26E6C-0x0000000189E26EFC 
		public ArticulationBody articulationBody { get => default; } // 0x0000000189E26BAC-0x0000000189E26C3C 
		public Vector2 lightmapCoord { get => default; } // 0x0000000189E26CCC-0x0000000189E26E38 
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use textureCoord2 instead. (UnityUpgradable) -> textureCoord2")]
		public Vector2 textureCoord1 { get => default; } // 0x0000000189E27058-0x0000000189E27068 
	
		// Methods
		[FreeFunction]
		private static Vector2 CalculateRaycastTexCoord(Collider collider, int m_Index, Vector2 uv, Vector3 pos, uint face, int textcoord) => default; // 0x0000000189E26B60-0x0000000189E26BAC
		private static void CalculateRaycastTexCoord_Injected(Collider collider, int m_Index, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret) {
			ret = default;
		} // 0x0000000189E26B00-0x0000000189E26B60
	}

	[NativeHeader("Modules/Physics/Rigidbody.h")]
	[RequireComponent(typeof(Transform))]
	public class Rigidbody : UnityEngine.Component // TypeDefIndex: 57947
	{
		// Properties
		public Vector3 velocity { get => default; set {} } // 0x000000018282DAF0-0x000000018282DB20 0x0000000189E28A68-0x0000000189E28A7C
		public Vector3 angularVelocity { get => default; set {} } // 0x000000018282CFE0-0x000000018282D010 0x0000000189E28540-0x0000000189E28554
		public float drag { get => default; set {} } // 0x000000018282DB70-0x000000018282DBB0 0x0000000189E28670-0x0000000189E286B4
		public float angularDrag { get => default; set {} } // 0x0000000189E27F28-0x0000000189E27F5C 0x0000000189E284B8-0x0000000189E284FC
		public float mass { get => default; set {} } // 0x0000000189E281E4-0x0000000189E28218 0x0000000189E287E8-0x0000000189E2882C
		public bool useGravity { get => default; set {} } // 0x0000000189E28414-0x0000000189E28448 0x0000000189E289E0-0x0000000189E28A24
		public float maxDepenetrationVelocity { get => default; set {} } // 0x0000000189E2824C-0x0000000189E28280 0x0000000189E28870-0x0000000189E288B4
		public bool isKinematic { get => default; set {} } // 0x0000000189E281B0-0x0000000189E281E4 0x000000018282CDF0-0x000000018282CE40
		public bool freezeRotation { get => default; set {} } // 0x0000000189E28068-0x0000000189E2809C 0x0000000189E286B4-0x0000000189E286F8
		public RigidbodyConstraints constraints { get => default; set {} } // 0x0000000189E28000-0x0000000189E28034 0x0000000189E285EC-0x0000000189E2862C
		public CollisionDetectionMode collisionDetectionMode { get => default; set {} } // 0x0000000189E27FCC-0x0000000189E28000 0x0000000189E285AC-0x0000000189E285EC
		public Vector3 centerOfMass { get => default; set {} } // 0x0000000189E27FA0-0x0000000189E27FCC 0x0000000189E28598-0x0000000189E285AC
		public Vector3 worldCenterOfMass { get => default; } // 0x0000000189E2848C-0x0000000189E284B8 
		public Quaternion inertiaTensorRotation { get => default; set {} } // 0x0000000189E280E0-0x0000000189E2810C 0x0000000189E2873C-0x0000000189E28750
		public Vector3 inertiaTensor { get => default; set {} } // 0x0000000189E28150-0x0000000189E2817C 0x0000000189E28794-0x0000000189E287A8
		public bool detectCollisions { get => default; set {} } // 0x0000000189E28034-0x0000000189E28068 0x0000000189E2862C-0x0000000189E28670
		public Vector3 position { get => default; set {} } // 0x0000000189E282C4-0x0000000189E282F0 0x0000000184273A90-0x0000000184273AA4
		public Quaternion rotation { get => default; set {} } // 0x0000000189E28334-0x0000000189E28360 0x0000000189E288F8-0x0000000189E2890C
		public RigidbodyInterpolation interpolation { get => default; set {} } // 0x0000000189E2817C-0x0000000189E281B0 0x0000000189E287A8-0x0000000189E287E8
		public int solverIterations { get => default; set {} } // 0x0000000189E283A0-0x0000000189E283D4 0x0000000189E28958-0x0000000189E28998
		public float sleepThreshold { get => default; set {} } // 0x0000000189E28360-0x0000000189E28394 0x0000000189E2890C-0x0000000189E28950
		public float maxAngularVelocity { get => default; set {} } // 0x0000000189E28218-0x0000000189E2824C 0x0000000189E2882C-0x0000000189E28870
		public int solverVelocityIterations { get => default; set {} } // 0x0000000189E283E0-0x0000000189E28414 0x0000000189E289A0-0x0000000189E289E0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", true)]
		public float sleepVelocity { get => default; set {} } // 0x0000000183D85FA0-0x0000000183D85FB0 0x000000018350B670-0x000000018350B680
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("The sleepAngularVelocity is no longer supported. Use sleepThreshold to specify energy.", true)]
		public float sleepAngularVelocity { get => default; set {} } // 0x0000000183D85FA0-0x0000000183D85FB0 0x000000018350B670-0x000000018350B680
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Cone friction is no longer supported.", true)]
		public bool useConeFriction { get => default; set {} } // 0x0000000183D4E3A0-0x0000000183D4E3B0 0x000000018350B670-0x000000018350B680
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use Rigidbody.solverIterations instead. (UnityUpgradable) -> solverIterations")]
		public int solverIterationCount { get => default; set {} } // 0x0000000189E28394-0x0000000189E283A0 0x0000000189E28950-0x0000000189E28958
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use Rigidbody.solverVelocityIterations instead. (UnityUpgradable) -> solverVelocityIterations")]
		public int solverVelocityIterationCount { get => default; set {} } // 0x0000000189E283D4-0x0000000189E283E0 0x0000000189E28998-0x0000000189E289A0
	
		// Constructors
		public Rigidbody() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void SetDensity(float density) {} // 0x0000000189E27B14-0x0000000189E27B58
		public void MovePosition(Vector3 position) {} // 0x0000000189E27A40-0x0000000189E27A54
		public void MoveRotation(Quaternion rot) {} // 0x0000000189E27A98-0x0000000189E27AAC
		public void Sleep() {} // 0x0000000189E27B60-0x0000000189E27B94
		public bool IsSleeping() => default; // 0x000000018282D4D0-0x000000018282D510
		public void WakeUp() {} // 0x0000000189E27EF4-0x0000000189E27F28
		public void ResetCenterOfMass() {} // 0x0000000189E27AAC-0x0000000189E27AE0
		public void ResetInertiaTensor() {} // 0x0000000189E27AE0-0x0000000189E27B14
		public Vector3 GetRelativePointVelocity(Vector3 relativePoint) => default; // 0x0000000189E278D0-0x0000000189E27904
		public Vector3 GetPointVelocity(Vector3 worldPoint) => default; // 0x0000000189E27848-0x0000000189E2787C
		public void AddForce(Vector3 force, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode) {} // 0x0000000189E27484-0x0000000189E27498
		[ExcludeFromDocs]
		public void AddForce(Vector3 force) {} // 0x0000000189E27458-0x0000000189E27484
		public void AddForce(float x, float y, float z, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode) {} // 0x0000000189E2742C-0x0000000189E27458
		[ExcludeFromDocs]
		public void AddForce(float x, float y, float z) {} // 0x0000000189E27498-0x0000000189E274C0
		public void AddRelativeForce(Vector3 force, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode) {} // 0x0000000189E27568-0x0000000189E2757C
		[ExcludeFromDocs]
		public void AddRelativeForce(Vector3 force) {} // 0x0000000189E27514-0x0000000189E27540
		public void AddRelativeForce(float x, float y, float z, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode) {} // 0x0000000189E2757C-0x0000000189E275A8
		[ExcludeFromDocs]
		public void AddRelativeForce(float x, float y, float z) {} // 0x0000000189E27540-0x0000000189E27568
		public void AddTorque(Vector3 torque, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode) {} // 0x0000000189E27704-0x0000000189E27718
		[ExcludeFromDocs]
		public void AddTorque(Vector3 torque) {} // 0x0000000189E276D8-0x0000000189E27704
		public void AddTorque(float x, float y, float z, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode) {} // 0x0000000189E27740-0x0000000189E2776C
		[ExcludeFromDocs]
		public void AddTorque(float x, float y, float z) {} // 0x0000000189E27718-0x0000000189E27740
		public void AddRelativeTorque(Vector3 torque, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode) {} // 0x0000000189E27654-0x0000000189E27668
		[ExcludeFromDocs]
		public void AddRelativeTorque(Vector3 torque) {} // 0x0000000189E27628-0x0000000189E27654
		public void AddRelativeTorque(float x, float y, float z, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode) {} // 0x0000000189E275FC-0x0000000189E27628
		[ExcludeFromDocs]
		public void AddRelativeTorque(float x, float y, float z) {} // 0x0000000189E27668-0x0000000189E27684
		public void AddForceAtPosition(Vector3 force, Vector3 position, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode) {} // 0x0000000189E27378-0x0000000189E27390
		[ExcludeFromDocs]
		public void AddForceAtPosition(Vector3 force, Vector3 position) {} // 0x0000000189E27390-0x0000000189E273D8
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, [UnityEngine.Internal.DefaultValue("0.0f")] float upwardsModifier, [UnityEngine.Internal.DefaultValue("ForceMode.Force)")] UnityEngine.ForceMode mode) {} // 0x0000000189E272E8-0x0000000189E27314
		[ExcludeFromDocs]
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier) {} // 0x0000000189E272A8-0x0000000189E272E8
		[ExcludeFromDocs]
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius) {} // 0x0000000189E2726C-0x0000000189E272A8
		[NativeName("ClosestPointOnBounds")]
		private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) {} // 0x0000000189E27968-0x0000000189E27980
		public Vector3 ClosestPointOnBounds(Vector3 position) => default; // 0x0000000189E2776C-0x0000000189E277F4
		private RaycastHit SweepTest(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit) => default; // 0x0000000189E27D54-0x0000000189E27DC8
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000189E27E00-0x0000000189E27EF4
		[ExcludeFromDocs]
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x0000000189E27D24-0x0000000189E27D54
		[ExcludeFromDocs]
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000189E27DC8-0x0000000189E27E00
		[NativeName("SweepTestAll")]
		private RaycastHit[] Internal_SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E279E4-0x0000000189E279FC
		public RaycastHit[] SweepTestAll(Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E27BC4-0x0000000189E27C88
		[ExcludeFromDocs]
		public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance) => default; // 0x0000000189E27B94-0x0000000189E27BC4
		[ExcludeFromDocs]
		public RaycastHit[] SweepTestAll(Vector3 direction) => default; // 0x0000000189E27C88-0x0000000189E27CC0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Rigidbody.maxAngularVelocity instead.")]
		public void SetMaxAngularVelocity(float a) {} // 0x0000000189E27B58-0x0000000189E27B60
		private void get_velocity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018282DB20-0x000000018282DB70
		private void set_velocity_Injected(ref Vector3 value) {} // 0x0000000189E28A24-0x0000000189E28A68
		private void get_angularVelocity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018282CDA0-0x000000018282CDF0
		private void set_angularVelocity_Injected(ref Vector3 value) {} // 0x0000000189E284FC-0x0000000189E28540
		private void get_centerOfMass_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189E27F5C-0x0000000189E27FA0
		private void set_centerOfMass_Injected(ref Vector3 value) {} // 0x0000000189E28554-0x0000000189E28598
		private void get_worldCenterOfMass_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189E28448-0x0000000189E2848C
		private void get_inertiaTensorRotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x0000000189E2809C-0x0000000189E280E0
		private void set_inertiaTensorRotation_Injected(ref Quaternion value) {} // 0x0000000189E286F8-0x0000000189E2873C
		private void get_inertiaTensor_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189E2810C-0x0000000189E28150
		private void set_inertiaTensor_Injected(ref Vector3 value) {} // 0x0000000189E28750-0x0000000189E28794
		private void get_position_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189E28280-0x0000000189E282C4
		private void set_position_Injected(ref Vector3 value) {} // 0x00000001834E5160-0x00000001834E51B0
		private void get_rotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x0000000189E282F0-0x0000000189E28334
		private void set_rotation_Injected(ref Quaternion value) {} // 0x0000000189E288B4-0x0000000189E288F8
		private void MovePosition_Injected(ref Vector3 position) {} // 0x0000000189E279FC-0x0000000189E27A40
		private void MoveRotation_Injected(ref Quaternion rot) {} // 0x0000000189E27A54-0x0000000189E27A98
		private void GetRelativePointVelocity_Injected(ref Vector3 relativePoint, out Vector3 ret) {
			ret = default;
		} // 0x0000000189E2787C-0x0000000189E278D0
		private void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret) {
			ret = default;
		} // 0x0000000189E277F4-0x0000000189E27848
		private void AddForce_Injected(ref Vector3 force, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode) {} // 0x0000000189E273D8-0x0000000189E2742C
		private void AddRelativeForce_Injected(ref Vector3 force, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode) {} // 0x0000000189E274C0-0x0000000189E27514
		private void AddTorque_Injected(ref Vector3 torque, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode) {} // 0x0000000189E27684-0x0000000189E276D8
		private void AddRelativeTorque_Injected(ref Vector3 torque, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode) {} // 0x0000000189E275A8-0x0000000189E275FC
		private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] UnityEngine.ForceMode mode) {} // 0x0000000189E27314-0x0000000189E27378
		private void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, [UnityEngine.Internal.DefaultValue("0.0f")] float upwardsModifier, [UnityEngine.Internal.DefaultValue("ForceMode.Force)")] UnityEngine.ForceMode mode) {} // 0x0000000189E27208-0x0000000189E2726C
		private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) {} // 0x0000000189E27904-0x0000000189E27968
		private void SweepTest_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x0000000189E27CC0-0x0000000189E27D24
		private RaycastHit[] Internal_SweepTestAll_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E27980-0x0000000189E279E4
	}

	public enum ECSColliderType // TypeDefIndex: 57948
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
	public class Collider : UnityEngine.Component // TypeDefIndex: 57949
	{
		// Properties
		public bool enabled { get => default; set {} } // 0x0000000182B2EE10-0x0000000182B2EE50 0x0000000182833E20-0x0000000182833E70
		public Rigidbody attachedRigidbody { [NativeMethod("GetRigidbody")] get => default; } // 0x0000000189E1C658-0x0000000189E1C68C 
		public ArticulationBody attachedArticulationBody { [NativeMethod("GetArticulationBody")] get => default; } // 0x0000000189E1C624-0x0000000189E1C658 
		public bool isTrigger { get => default; set {} } // 0x000000018282CBA0-0x000000018282CBE0 0x0000000182B94E10-0x0000000182B94E60
		public bool enableDither { get => default; } // 0x0000000189E1C734-0x0000000189E1C768 
		public float contactOffset { get => default; set {} } // 0x0000000189E1C700-0x0000000189E1C734 0x0000000189E1C86C-0x0000000189E1C8B0
		public Bounds bounds { get => default; } // 0x0000000189E1C6D0-0x0000000189E1C700 
		public bool hasModifiableContacts { get => default; set {} } // 0x0000000189E1C768-0x0000000189E1C79C 0x0000000189E1C8B0-0x0000000189E1C8F4
		public ColliderSurfaceType surfaceType { get => default; set {} } // 0x0000000189E1C804-0x0000000189E1C838 0x0000000189E1C938-0x0000000189E1C978
		public int tagConfig { get => default; set {} } // 0x0000000189E1C838-0x0000000189E1C86C 0x0000000189E1C978-0x0000000189E1C9B8
		public int colliderOptions { get => default; set {} } // 0x0000000182B93D40-0x0000000182B93D80 0x0000000182B952A0-0x0000000182B952F0
		[NativeMethod("Material")]
		public PhysicMaterial sharedMaterial { get => default; set {} } // 0x0000000189E1C7D0-0x0000000189E1C804 0x0000000189E1C8F4-0x0000000189E1C938
		public PhysicMaterial material { [NativeMethod("GetClonedMaterial")] get => default; [NativeMethod("SetMaterial")] set {} } // 0x0000000189E1C79C-0x0000000189E1C7D0 0x0000000182B40D20-0x0000000182B40D70
	
		// Constructors
		public Collider() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public Vector3 ClosestPoint(Vector3 position) => default; // 0x0000000189E1C2D0-0x0000000189E1C304
		[NativeName("GetActor")]
		public IntPtr GetActor() => default; // 0x000000018270A950-0x000000018270A990
		[NativeName("GetComponentIndex")]
		public int GetComponentIndex() => default; // 0x0000000183300880-0x00000001833008C0
		[NativeName("GetFactoryBuildingIdentifier")]
		public int GetFactoryBuildingIdentifier() => default; // 0x0000000189E1C304-0x0000000189E1C338
		[NativeName("SetFactoryBuildingIdentifier")]
		public void SetFactoryBuildingIdentifier(int value) {} // 0x0000000189E1C4F0-0x0000000189E1C530
		private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) => default; // 0x0000000189E1C418-0x0000000189E1C47C
		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x0000000189E1C47C-0x0000000189E1C4F0
		[NativeName("ClosestPointOnBounds")]
		private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) {} // 0x0000000189E1C39C-0x0000000189E1C3B4
		public Vector3 ClosestPointOnBounds(Vector3 position) => default; // 0x0000000189E1C1F4-0x0000000189E1C27C
		public bool CanColliderComputeClosestPoint() => default; // 0x0000000189E1C1C0-0x0000000189E1C1F4
		[NativeName("TryGetClosestPoint")]
		private Vector3 TryGetClosestPoint_Internal(Vector3 point, ref bool resultIsValid) => default; // 0x0000000189E1C594-0x0000000189E1C5D0
		public bool TryGetClosestPoint(Vector3 point, out Vector3 result) {
			result = default;
			return default;
		} // 0x0000000189E1C5D0-0x0000000189E1C624
		private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) {
			ret = default;
		} // 0x0000000189E1C27C-0x0000000189E1C2D0
		private void get_bounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x0000000189E1C68C-0x0000000189E1C6D0
		private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x0000000189E1C3B4-0x0000000189E1C418
		private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) {} // 0x0000000189E1C338-0x0000000189E1C39C
		private void TryGetClosestPoint_Internal_Injected(ref Vector3 point, ref bool resultIsValid, out Vector3 ret) {
			ret = default;
		} // 0x0000000189E1C530-0x0000000189E1C594
	}

	[NativeHeader("Modules/Physics/ECSCollider.h")]
	[RequiredByNativeCode]
	public class ECSCollider // TypeDefIndex: 57951
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
		public delegate void CollisionCallback(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // TypeDefIndex: 57950; 0x0000000189E1C9B8-0x0000000189E1CA04
	
		// Constructors
		public ECSCollider() {} // Dummy constructor
	
		// Methods
		public static IntPtr CreateActor(Vector3 position, Quaternion rotation, uint layer, int tagInt, bool movable) => default; // 0x0000000189E1DB24-0x0000000189E1DB44
		[NativeName("DestroyActor")]
		public static void DestroyActor(int id, uint version) {} // 0x0000000189E1DB44-0x0000000189E1DB84
		[NativeName("Decode")]
		public static IntPtr Decode(IntPtr data, int length, IntPtr meshes, int meshesCount, Texture2D heightmaps) => default; // 0x0000000182769F70-0x0000000182769FE0
		public static IntPtr Decode(IntPtr data, int length, NativeArray<int> meshInstanceIds, Texture2D heightmap) => default; // 0x0000000182769ED0-0x0000000182769F70
		[NativeName("RecordEntity")]
		public static void RecordEntity(IntPtr actor, Entity entity) {} // 0x0000000189E1E290-0x0000000189E1E2AC
		[NativeName("GetId")]
		public static int GetId(IntPtr actor) => default; // 0x000000018276A110-0x000000018276A150
		[NativeName("GetVersion")]
		public static uint GetVersion(IntPtr actor) => default; // 0x000000018276A150-0x000000018276A190
		[NativeName("IsValid")]
		public static bool IsValid(int id, uint version, IntPtr actor) => default; // 0x00000001827EC850-0x00000001827EC8B0
		[NativeName("GetEntity")]
		public static Entity GetEntity(int id, uint version) => default; // 0x00000001838A9300-0x00000001838A9360
		[NativeName("GetPosition")]
		[ThreadSafe]
		public static Vector3 GetPosition(int ecsId, uint ecsVersion) => default; // 0x0000000182B2E180-0x0000000182B2E1B0
		[NativeName("GetShapePosition")]
		[ThreadSafe]
		public static Vector3 GetShapePosition(int ecsId, uint ecsVersion, int index) => default; // 0x000000018301F140-0x000000018301F180
		[NativeName("SetPosition")]
		public static void SetPosition(int ecsId, uint ecsVersion, Vector3 position) {} // 0x0000000184272040-0x0000000184272054
		[NativeName("GetShapeRotation")]
		[ThreadSafe]
		public static Quaternion GetShapeRotation(int ecsId, uint ecsVersion, int index) => default; // 0x0000000189E1DC34-0x0000000189E1DC70
		[NativeName("GetRotation")]
		[ThreadSafe]
		public static Quaternion GetRotation(int ecsId, uint ecsVersion) => default; // 0x0000000182B2E150-0x0000000182B2E180
		[NativeName("SetRotation")]
		public static void SetRotation(int ecsId, uint ecsVersion, Quaternion rotation) {} // 0x0000000184272054-0x0000000184272068
		[NativeName("AttachBox")]
		public static void AttachBox(int id, uint version, Vector3 halfExtent, Vector3 localPosition, Quaternion localRotation, int surfaceType, int colliderOption, int tag, bool isTrigger, bool isPrimitive) {} // 0x0000000189E1D778-0x0000000189E1D7D8
		[NativeName("HasComplexMesh")]
		public static bool HasComplexMesh(int id, uint version) => default; // 0x00000001827EAC40-0x00000001827EAC90
		[NativeName("Raycast")]
		private static RaycastHit Raycast_Internal(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, ref bool hasHit) => default; // 0x0000000189E1E190-0x0000000189E1E204
		public static bool Raycast(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000189E1E204-0x0000000189E1E290
		[NativeName("RaycastComplexMesh")]
		private static RaycastHit RaycastComplexMesh_Internal(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, ref bool hasHit) => default; // 0x0000000189E1E030-0x0000000189E1E0A4
		public static bool RaycastComplexMesh(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000189E1E0A4-0x0000000189E1E130
		[NativeName("CapsuleCastComplexMesh")]
		private static RaycastHit CapsuleCastComplexMesh_Internal(int ecsId, uint ecsVersion, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, ref bool hasHit) => default; // 0x0000000189E1D878-0x0000000189E1D914
		public static bool CapsuleCastComplexMesh(int ecsId, uint ecsVersion, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000189E1D914-0x0000000189E1D9D4
		[NativeName("SphereCastComplexMesh")]
		private static RaycastHit SphereCastComplexMesh_Internal(int ecsId, uint ecsVersion, Vector3 center, float radius, Vector3 direction, float maxDistance, ref bool hasHit) => default; // 0x0000000189E1E30C-0x0000000189E1E398
		public static bool SphereCastComplexMesh(int ecsId, uint ecsVersion, Vector3 center, float radius, Vector3 direction, float maxDistance, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x0000000189E1E398-0x0000000189E1E448
		public static bool CanColliderComputeClosestPoint(int ecsId, uint ecsVersion) => default; // 0x0000000189E1D7D8-0x0000000189E1D818
		[NativeName("GetSurfaceAt")]
		public static ColliderSurfaceType GetSurfaceTypeAt(int ecsId, uint ecsVersion, int index) => default; // 0x0000000182FA3100-0x0000000182FA3160
		[NativeName("GetColliderOptionAt")]
		public static int GetColliderOptionAt(int ecsId, uint ecsVersion, int index) => default; // 0x00000001827ECA20-0x00000001827ECA80
		[NativeName("GetTagConfigAt")]
		public static int GetTagConfigAt(int ecsId, uint ecsVersion, int index) => default; // 0x0000000182351E50-0x0000000182351EB0
		[NativeName("GetIsTrigger")]
		public static bool GetIsTrigger(int ecsId, uint ecsVersion, int index) => default; // 0x0000000189E1DB84-0x0000000189E1DBD4
		public static Bounds GetBounds(int ecsId, uint ecsVersion) => default; // 0x0000000183271870-0x00000001832718B0
		[NativeName("TryGetClosestPoint")]
		private static Vector3 TryGetClosestPoint_Internal(int ecsId, uint ecsVersion, Vector3 point, ref bool resultIsValid) => default; // 0x0000000189E1E4A8-0x0000000189E1E4E8
		public static bool TryGetClosestPoint(int ecsId, uint ecsVersion, Vector3 point, out Vector3 result) {
			result = default;
			return default;
		} // 0x0000000189E1E4E8-0x0000000189E1E544
		public static Vector3 ClosestPoint(int ecsId, uint ecsVersion, Vector3 position) => default; // 0x0000000189E1DA34-0x0000000189E1DA70
		[NativeName("CompareTag")]
		public static bool CompareTag(int ecsId, uint ecsVersion, int tagValue) => default; // 0x0000000189E1DA70-0x0000000189E1DAC0
		[NativeName("GetLayer")]
		public static int GetLayer(int ecsId, uint ecsVersion) => default; // 0x0000000182B335F0-0x0000000182B33640
		[NativeName("GetFactoryBuildingIdentifier")]
		public static int GetFactoryBuildingIdentifier(int ecsId, uint ecsVersion) => default; // 0x00000001827E5BE0-0x00000001827E5C30
		[NativeName("SetFactoryBuildingIdentifier")]
		public static void SetFactoryBuildingIdentifier(int ecsId, uint ecsVersion, int identifier) {} // 0x00000001832F4ED0-0x00000001832F4F30
		[RequiredByNativeCode]
		private static void OnCollisionEnterV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider) {} // 0x0000000189E1DC70-0x0000000189E1DD00
		[RequiredByNativeCode]
		private static void OnCollisionStayV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider) {} // 0x0000000189E1DD90-0x0000000189E1DE20
		[RequiredByNativeCode]
		private static void OnCollisionExitV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider) {} // 0x0000000189E1DD00-0x0000000189E1DD90
		[RequiredByNativeCode]
		private static void OnTriggerEnterV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider) {} // 0x0000000189E1DE20-0x0000000189E1DEB0
		[RequiredByNativeCode]
		private static void OnTriggerStayV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider) {} // 0x0000000189E1DF40-0x0000000189E1DFD0
		[RequiredByNativeCode]
		private static void OnTriggerExitV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider) {} // 0x0000000189E1DEB0-0x0000000189E1DF40
		public static void ToggleCollision(int id, uint version, bool enableCollision) {} // 0x000000018294A580-0x000000018294A5E0
		private static IntPtr CreateActor_Injected(ref Vector3 position, ref Quaternion rotation, uint layer, int tagInt, bool movable) => default; // 0x0000000189E1DAC0-0x0000000189E1DB24
		private static void RecordEntity_Injected(IntPtr actor, ref Entity entity) {} // 0x0000000183334210-0x0000000183334260
		private static void GetEntity_Injected(int id, uint version, out Entity ret) {
			ret = default;
		} // 0x00000001838A9360-0x00000001838A93C0
		private static void GetPosition_Injected(int ecsId, uint ecsVersion, out Vector3 ret) {
			ret = default;
		} // 0x0000000182B2E090-0x0000000182B2E0F0
		private static void GetShapePosition_Injected(int ecsId, uint ecsVersion, int index, out Vector3 ret) {
			ret = default;
		} // 0x000000018301F180-0x000000018301F1F0
		private static void SetPosition_Injected(int ecsId, uint ecsVersion, ref Vector3 position) {} // 0x00000001831E7090-0x00000001831E70F0
		private static void GetShapeRotation_Injected(int ecsId, uint ecsVersion, int index, out Quaternion ret) {
			ret = default;
		} // 0x0000000189E1DBD4-0x0000000189E1DC34
		private static void GetRotation_Injected(int ecsId, uint ecsVersion, out Quaternion ret) {
			ret = default;
		} // 0x0000000182B2E0F0-0x0000000182B2E150
		private static void SetRotation_Injected(int ecsId, uint ecsVersion, ref Quaternion rotation) {} // 0x00000001831E7030-0x00000001831E7090
		private static void AttachBox_Injected(int id, uint version, ref Vector3 halfExtent, ref Vector3 localPosition, ref Quaternion localRotation, int surfaceType, int colliderOption, int tag, bool isTrigger, bool isPrimitive) {} // 0x0000000189E1D718-0x0000000189E1D778
		private static void Raycast_Internal_Injected(int ecsId, uint ecsVersion, ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x0000000189E1E130-0x0000000189E1E190
		private static void RaycastComplexMesh_Internal_Injected(int ecsId, uint ecsVersion, ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x0000000189E1DFD0-0x0000000189E1E030
		private static void CapsuleCastComplexMesh_Internal_Injected(int ecsId, uint ecsVersion, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x0000000189E1D818-0x0000000189E1D878
		private static void SphereCastComplexMesh_Internal_Injected(int ecsId, uint ecsVersion, ref Vector3 center, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x0000000189E1E2AC-0x0000000189E1E30C
		private static void GetBounds_Injected(int ecsId, uint ecsVersion, out Bounds ret) {
			ret = default;
		} // 0x00000001832718B0-0x0000000183271910
		private static void TryGetClosestPoint_Internal_Injected(int ecsId, uint ecsVersion, ref Vector3 point, ref bool resultIsValid, out Vector3 ret) {
			ret = default;
		} // 0x0000000189E1E448-0x0000000189E1E4A8
		private static void ClosestPoint_Injected(int ecsId, uint ecsVersion, ref Vector3 position, out Vector3 ret) {
			ret = default;
		} // 0x0000000189E1D9D4-0x0000000189E1DA34
	}

	[NativeHeader("Modules/Physics/CharacterController.h")]
	public class CharacterController : Collider // TypeDefIndex: 57952
	{
		// Properties
		public bool isGrounded { [NativeName("IsGrounded")] get => default; } // 0x0000000189E1C18C-0x0000000189E1C1C0 
	
		// Constructors
		public CharacterController() {} // Dummy constructor
	}

	[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
	[NativeHeader("Modules/Physics/MultiCollider.h")]
	[RequiredByNativeCode]
	public class MultiCollider : Collider // TypeDefIndex: 57953
	{
		// Properties
		public Mesh ComplexMesh { get => default; } // 0x0000000189E1ED4C-0x0000000189E1ED80 
	
		// Constructors
		public MultiCollider() {} // Dummy constructor
	
		// Methods
		[NativeName("AppendBoxCollider")]
		public void AppendBoxCollider(BoxCollider boxCollider) {} // 0x0000000189E1E724-0x0000000189E1E768
		[NativeName("AppendCapsuleCollider")]
		public void AppendCapsuleCollider(CapsuleCollider collider) {} // 0x0000000189E1E768-0x0000000189E1E7AC
		[NativeName("AppendSphereCollider")]
		public void AppendSphereCollider(SphereCollider collider) {} // 0x0000000189E1E7AC-0x0000000189E1E7F0
		[NativeName("GetSurfaceTypeAt")]
		public ColliderSurfaceType GetSurfaceTypeAt(int index) => default; // 0x0000000189E1EA7C-0x0000000189E1EABC
		[NativeName("GetTagConfigAt")]
		public int GetTagConfigAt(int index) => default; // 0x0000000189E1EABC-0x0000000189E1EAFC
		[NativeName("GetGameplayOptionAt")]
		public int GetGameplayOptionAt(int index) => default; // 0x0000000189E1E9FC-0x0000000189E1EA3C
		[NativeName("GetIsTriggerAt")]
		public bool GetIsTriggerAt(int index) => default; // 0x0000000189E1EA3C-0x0000000189E1EA7C
		[NativeName("SetGameplayOptionAt")]
		public void SetGameplayOptionAt(int index, int value) {} // 0x0000000189E1EB78-0x0000000189E1EBC8
		[NativeName("Flush")]
		public void Flush() {} // 0x0000000189E1E994-0x0000000189E1E9C8
		[NativeName("RaycastComplexMesh")]
		public bool RaycastComplexMesh(Ray ray, float maxDistance, ref RaycastHit hit) => default; // 0x0000000189E1EB60-0x0000000189E1EB78
		[NativeName("CapsuleCastComplexMesh")]
		private RaycastHit CapsuleCastComplexMesh_Internal(Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, ref bool hasHit) => default; // 0x0000000189E1E854-0x0000000189E1E8E4
		public bool CapsuleCastComplexMesh(Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, out RaycastHit hit) {
			hit = default;
			return default;
		} // 0x0000000189E1E8E4-0x0000000189E1E994
		[NativeName("SphereCastComplexMesh")]
		private RaycastHit SphereCastComplexMesh_Internal(Vector3 center, float radius, Vector3 direction, float maxDistance, ref bool hasHit) => default; // 0x0000000189E1EC2C-0x0000000189E1ECAC
		public bool SphereCastComplexMesh(Vector3 center, float radius, Vector3 direction, float maxDistance, out RaycastHit hit) {
			hit = default;
			return default;
		} // 0x0000000189E1ECAC-0x0000000189E1ED4C
		[NativeName("GetShapesCount")]
		public int GetCountWithoutComplexMesh() => default; // 0x0000000189E1E9C8-0x0000000189E1E9FC
		private bool RaycastComplexMesh_Injected(ref Ray ray, float maxDistance, ref RaycastHit hit) => default; // 0x0000000189E1EAFC-0x0000000189E1EB60
		private void CapsuleCastComplexMesh_Internal_Injected(ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x0000000189E1E7F0-0x0000000189E1E854
		private void SphereCastComplexMesh_Internal_Injected(ref Vector3 center, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x0000000189E1EBC8-0x0000000189E1EC2C
	}

	[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
	[NativeHeader("Modules/Physics/MeshCollider.h")]
	[RequiredByNativeCode]
	public class MeshCollider : Collider // TypeDefIndex: 57954
	{
		// Properties
		public Mesh sharedMesh { get => default; set {} } // 0x0000000189E1E66C-0x0000000189E1E6A0 0x0000000183012920-0x0000000183012970
		public bool convex { get => default; set {} } // 0x0000000189E1E604-0x0000000189E1E638 0x0000000189E1E6A0-0x0000000189E1E6E4
		public MeshColliderCookingOptions cookingOptions { get => default; set {} } // 0x0000000189E1E638-0x0000000189E1E66C 0x0000000189E1E6E4-0x0000000189E1E724
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Configuring smooth sphere collisions is no longer needed.", true)]
		public bool smoothSphereCollisions { get => default; set {} } // 0x0000000183D663A0-0x0000000183D663B0 0x000000018350B670-0x000000018350B680
		[Obsolete("MeshCollider.skinWidth is no longer used.")]
		public float skinWidth { get => default; set {} } // 0x0000000183D85FA0-0x0000000183D85FB0 0x000000018350B670-0x000000018350B680
		[Obsolete("MeshCollider.inflateMesh is no longer supported. The new cooking algorithm doesn\'t need inflation to be used.")]
		public bool inflateMesh { get => default; set {} } // 0x0000000183D4E3A0-0x0000000183D4E3B0 0x000000018350B670-0x000000018350B680
	
		// Constructors
		public MeshCollider() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		[NativeName("NeedsReadWriteEnabled")]
		public bool NeedsReadWriteEnabled() => default; // 0x0000000189E1E5D0-0x0000000189E1E604
	}

	[NativeHeader("Modules/Physics/CapsuleCollider.h")]
	[RequiredByNativeCode]
	public class CapsuleCollider : Collider // TypeDefIndex: 57955
	{
		// Properties
		public Vector3 center { get => default; set {} } // 0x0000000182A126C0-0x0000000182A12720 0x0000000184272BA4-0x0000000184272BB8
		public float radius { get => default; set {} } // 0x0000000182A12F70-0x0000000182A12FB0 0x0000000182B40C30-0x0000000182B40C80
		public float height { get => default; set {} } // 0x0000000182A12FB0-0x0000000182A12FF0 0x0000000182B40C80-0x0000000182B40CD0
		public int direction { get => default; set {} } // 0x0000000182A12F30-0x0000000182A12F70 0x0000000182B40CD0-0x0000000182B40D20
	
		// Constructors
		public CapsuleCollider() {} // Dummy constructor
	
		// Methods
		private void get_center_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000182A12720-0x0000000182A12770
		private void set_center_Injected(ref Vector3 value) {} // 0x00000001835F5DC0-0x00000001835F5E10
	}

	[NativeHeader("Modules/Physics/BoxCollider.h")]
	[RequiredByNativeCode]
	public class BoxCollider : Collider // TypeDefIndex: 57956
	{
		// Properties
		public Vector3 center { get => default; set {} } // 0x0000000189E1BE18-0x0000000189E1BE44 0x0000000184272C44-0x0000000184272C58
		public Vector3 size { get => default; set {} } // 0x0000000182B951A0-0x0000000182B951D0 0x0000000184272C30-0x0000000184272C44
	
		// Constructors
		public BoxCollider() {} // Dummy constructor
	
		// Methods
		private void get_center_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189E1BDD4-0x0000000189E1BE18
		private void set_center_Injected(ref Vector3 value) {} // 0x0000000182F67710-0x0000000182F67760
		private void get_size_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000182B951D0-0x0000000182B95220
		private void set_size_Injected(ref Vector3 value) {} // 0x0000000182F676C0-0x0000000182F67710
	}

	[NativeHeader("Modules/Physics/SphereCollider.h")]
	[RequiredByNativeCode]
	public class SphereCollider : Collider // TypeDefIndex: 57957
	{
		// Properties
		public Vector3 center { get => default; set {} } // 0x0000000189E28AC0-0x0000000189E28AEC 0x0000000189E28B64-0x0000000189E28B78
		public float radius { get => default; set {} } // 0x0000000189E28AEC-0x0000000189E28B20 0x0000000182B93E20-0x0000000182B93E70
	
		// Constructors
		public SphereCollider() {} // Dummy constructor
	
		// Methods
		private void get_center_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189E28A7C-0x0000000189E28AC0
		private void set_center_Injected(ref Vector3 value) {} // 0x0000000189E28B20-0x0000000189E28B64
	}

	[NativeClass("Unity::Joint")]
	[NativeHeader("Modules/Physics/Joint.h")]
	[RequireComponent(typeof(Rigidbody))]
	public class Joint : UnityEngine.Component // TypeDefIndex: 57958
	{
		// Properties
		public Rigidbody connectedBody { get => default; } // 0x0000000189E1E544-0x0000000189E1E578 
		public Vector3 connectedAnchor { set {} } // 0x0000000189E1E5BC-0x0000000189E1E5D0
	
		// Constructors
		public Joint() {} // Dummy constructor
	
		// Methods
		private void set_connectedAnchor_Injected(ref Vector3 value) {} // 0x0000000189E1E578-0x0000000189E1E5BC
	}

	[NativeHeader("Modules/Physics/MessageParameters.h")]
	[UsedByNativeCode]
	public struct ContactPoint // TypeDefIndex: 57959
	{
		// Fields
		internal Vector3 m_Point; // 0x00
		internal Vector3 m_Normal; // 0x0C
		internal int m_ThisColliderInstanceID; // 0x18
		internal int m_OtherColliderInstanceID; // 0x1C
		internal float m_Separation; // 0x20
	
		// Properties
		public Vector3 point { get => default; } // 0x0000000183D85920-0x0000000183D85940 
		public Vector3 normal { get => default; } // 0x0000000183D85900-0x0000000183D85920 
		public Collider thisCollider { get => default; } // 0x0000000189E1CBE8-0x0000000189E1CBF4 
		public Collider otherCollider { get => default; } // 0x0000000189E1CBDC-0x0000000189E1CBE8 
	
		// Methods
		[FreeFunction]
		private static Collider GetColliderByInstanceID(int instanceID) => default; // 0x0000000189E1CBA8-0x0000000189E1CBDC
	}

	[NativeHeader("Modules/Physics/Public/PhysicsSceneHandle.h")]
	public struct PhysicsScene : IEquatable<PhysicsScene> // TypeDefIndex: 57960
	{
		// Fields
		private int m_Handle; // 0x00
	
		// Methods
		public override string ToString() => default; // 0x0000000189E1FD6C-0x0000000189E1FE1C
		public override int GetHashCode() => default; // 0x0000000183D85860-0x0000000183D85870
		public override bool Equals(object other) => default; // 0x0000000189E1F054-0x0000000189E1F0B8
		public bool Equals(PhysicsScene other) => default; // 0x00000001822A9C10-0x00000001822A9C20
		public bool Raycast(Vector3 origin, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x01FDA703 */, [UnityEngine.Internal.DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x01FDA707 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDA708 */) => default; // 0x0000000189E1FC74-0x0000000189E1FD6C
		[NativeName("RaycastTest")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F428-0x0000000189E1F450
		public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x01FDA709 */, [UnityEngine.Internal.DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x01FDA70D */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDA70E */) {
			hitInfo = default;
			return default;
		} // 0x000000018238CFE0-0x000000018238D270
		[NativeName("Raycast")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F450-0x0000000189E1F480
		public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x01FDA70F */, [UnityEngine.Internal.DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x01FDA713 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDA714 */) => default; // 0x000000018238CC80-0x000000018238CFE0
		[NativeName("RaycastNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, [Unmarshalled] RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018426FAB8-0x000000018426FAE8
		[NativeName("CapsuleCast")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1FC14-0x0000000189E1FC74
		private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000189E1F2A4-0x0000000189E1F3C4
		public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x01FDA715 */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x01FDA719 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDA71A */) {
			hitInfo = default;
			return default;
		} // 0x0000000189E1EFB8-0x0000000189E1F054
		[NativeName("CapsuleCastNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int Internal_CapsuleCastNonAlloc(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, [Unmarshalled] RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000184272A88-0x0000000184272AE8
		public int CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x01FDA71B */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x01FDA71F */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDA720 */) => default; // 0x0000000182B309D0-0x0000000182B30B00
		[NativeName("CapsuleCastNonAllocV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int Internal_CapsuleCastNonAllocV2(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 diretion, [Unmarshalled] ECSColliderResultProxy[] proxies, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F244-0x0000000189E1F2A4
		public int CapsuleCastV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] proxies, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x01FDA721 */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x01FDA725 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDA726 */) => default; // 0x0000000189E1EEC4-0x0000000189E1EFB8
		[NativeName("OverlapCapsuleNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, [Unmarshalled] Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F794-0x0000000189E1F7D4
		public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask = -1 /* Metadata: 0x01FDA727 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDA728 */) => default; // 0x0000000189E1F7D4-0x0000000189E1F8B8
		[NativeName("OverlapCapsuleNonAllocV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapCapsuleNonAlloc_InternalV2(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, [Unmarshalled] ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000184272B3C-0x0000000184272B7C
		public int OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius, [Unmarshalled] ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask = -1 /* Metadata: 0x01FDA729 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDA72A */) => default; // 0x0000000182B349D0-0x0000000182B34A80
		[NativeName("SphereCast")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000184271A38-0x0000000184271A8C
		private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x00000001827E7FE0-0x00000001827E8120
		public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x01FDA72B */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x01FDA72F */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDA730 */) {
			hitInfo = default;
			return default;
		} // 0x00000001827E7F60-0x00000001827E7FE0
		[NativeName("SphereCastNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, [Unmarshalled] RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000184272AE8-0x0000000184272B3C
		public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x01FDA731 */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x01FDA735 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDA736 */) => default; // 0x0000000182B328D0-0x0000000182B329D0
		[NativeName("OverlapSphereNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, [Unmarshalled] Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F9B0-0x0000000189E1F9E0
		public int OverlapSphere(Vector3 position, float radius, Collider[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1FA28-0x0000000189E1FAEC
		[NativeName("OverlapSphereNonAllocV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapSphereNonAllocV2_Internal(PhysicsScene physicsScene, Vector3 position, float radius, [Unmarshalled] ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F91C-0x0000000189E1F94C
		public int OverlapSphereV2(Vector3 position, float radius, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F9E0-0x0000000189E1FA28
		[NativeName("BoxCast")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1FB50-0x0000000189E1FBB0
		private static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000189E1F0B8-0x0000000189E1F1E0
		public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x01FDA737 */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x01FDA73B */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDA73C */) {
			hitInfo = default;
			return default;
		} // 0x0000000189E1EE18-0x0000000189E1EEC4
		[NativeName("OverlapBoxNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, [Unmarshalled] Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F588-0x0000000189E1F5C8
		public int OverlapBox(Vector3 center, Vector3 halfExtents, Collider[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x01FDA73D */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDA73E */) => default; // 0x0000000189E1F63C-0x0000000189E1F730
		[NativeName("OverlapBoxNonAllocV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapBoxNonAllocV2_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, [Unmarshalled] ECSColliderResultProxy[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F4E4-0x0000000189E1F524
		public int OverlapBoxV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x01FDA73F */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDA740 */) => default; // 0x0000000189E1F5C8-0x0000000189E1F63C
		[NativeName("BoxCastNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int Internal_BoxCastNonAlloc(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, [Unmarshalled] RaycastHit[] raycastHits, Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018426FD8C-0x000000018426FDEC
		public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x01FDA741 */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x01FDA745 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDA746 */) => default; // 0x0000000182423860-0x00000001824239A0
		private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F3C4-0x0000000189E1F428
		private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000182EC0330-0x0000000182EC0440
		private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000182F62F10-0x0000000182F62F80
		private static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1FBB0-0x0000000189E1FC14
		private static int Internal_CapsuleCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018335D620-0x000000018335D690
		private static int Internal_CapsuleCastNonAllocV2_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 diretion, ECSColliderResultProxy[] proxies, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F1E0-0x0000000189E1F244
		private static int OverlapCapsuleNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F730-0x0000000189E1F794
		private static int OverlapCapsuleNonAlloc_InternalV2_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x00000001830CB690-0x00000001830CB700
		private static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018335DAB0-0x000000018335DB20
		private static int Internal_SphereCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000182741E00-0x0000000182741E70
		private static int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F94C-0x0000000189E1F9B0
		private static int OverlapSphereNonAllocV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F8B8-0x0000000189E1F91C
		private static bool Query_BoxCast_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1FAEC-0x0000000189E1FB50
		private static int OverlapBoxNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, Collider[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F524-0x0000000189E1F588
		private static int OverlapBoxNonAllocV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ECSColliderResultProxy[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000189E1F480-0x0000000189E1F4E4
		private static int Internal_BoxCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, RaycastHit[] raycastHits, ref Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x00000001830FE4F0-0x00000001830FE560
	}

	public struct QueryParameters // TypeDefIndex: 57961
	{
		// Fields
		public int layerMask; // 0x00
		public bool hitMultipleFaces; // 0x04
		public bool hitBackfaces; // 0x05
		public QueryTriggerInteraction hitTriggers; // 0x08
	
		// Constructors
		public QueryParameters(int layerMask = -5 /* Metadata: 0x01FDA747 */, bool hitMultipleFaces = false /* Metadata: 0x01FDA748 */, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDA749 */, bool hitBackfaces = false /* Metadata: 0x01FDA74A */) {
			this.layerMask = default;
			this.hitMultipleFaces = default;
			this.hitBackfaces = default;
			this.hitTriggers = default;
		} // 0x0000000183D87FC0-0x0000000183D87FE0
	}

	[NativeHeader("Runtime/Jobs/ScriptBindings/JobsBindingsTypes.h")]
	[NativeHeader("Modules/Physics/BatchCommands/RaycastCommand.h")]
	public struct RaycastCommand // TypeDefIndex: 57962
	{
		// Fields
		public QueryParameters queryParameters; // 0x20
	
		// Properties
		public Vector3 from { [IsReadOnly] get; set; } // 0x0000000183D56520-0x0000000183D56540 0x0000000183D56570-0x0000000183D56580
		public Vector3 direction { [IsReadOnly] get; set; } // 0x0000000183D56540-0x0000000183D56560 0x0000000183D56580-0x0000000183D56590
		public float distance { [IsReadOnly] get; set; } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
		public PhysicsScene physicsScene { get; set; } // 0x0000000183D4EBC0-0x0000000183D4EBD0
	
		// Constructors
		public RaycastCommand(Vector3 from, Vector3 direction, QueryParameters queryParameters, float distance = 3.4028235E+38f /* Metadata: 0x01FDA74B */) : this() {
			this.queryParameters = default;
		} // 0x0000000183199660-0x00000001831996C0
	
		// Methods
		public static JobHandle ScheduleBatch(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, int maxHits, JobHandle dependsOn = default) => default; // 0x00000001830FF560-0x00000001830FF720
		public static JobHandle ScheduleBatch(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn = default) => default; // 0x00000001830FF4E0-0x00000001830FF560
		[FreeFunction("ScheduleRaycastCommandBatch", ThrowsException = true)]
		private static unsafe JobHandle ScheduleRaycastBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits) => default; // 0x00000001830FF720-0x00000001830FF7C0
		private static unsafe void ScheduleRaycastBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out JobHandle ret) {
			ret = default;
		} // 0x00000001830FF7C0-0x00000001830FF830
	}

	[NativeHeader("Modules/Physics/BatchCommands/BoxcastCommand.h")]
	[NativeHeader("Runtime/Jobs/ScriptBindings/JobsBindingsTypes.h")]
	public struct BoxcastCommand // TypeDefIndex: 57963
	{
		// Fields
		public QueryParameters queryParameters; // 0x3C
	
		// Properties
		public Vector3 center { get; set; } // 0x0000000183D56570-0x0000000183D56580
		public Vector3 halfExtents { get; set; } // 0x0000000183D56580-0x0000000183D56590
		public Quaternion orientation { get; set; } // 0x0000000183D51D90-0x0000000183D51DA0
		public Vector3 direction { get; set; } // 0x0000000183D50F50-0x0000000183D50F60
		public float distance { get; set; } // 0x0000000183D56CB0-0x0000000183D56CC0
		public PhysicsScene physicsScene { get; set; } // 0x0000000183D4ECB0-0x0000000183D4ECC0
	
		// Constructors
		public BoxcastCommand(Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, QueryParameters queryParameters, float distance = 3.4028235E+38f /* Metadata: 0x01FDA74F */) : this() {
			this.queryParameters = default;
		} // 0x0000000189E1C118-0x0000000189E1C18C
	
		// Methods
		public static JobHandle ScheduleBatch(NativeArray<BoxcastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, int maxHits, JobHandle dependsOn = default) => default; // 0x0000000189E1BEB8-0x0000000189E1C048
		public static JobHandle ScheduleBatch(NativeArray<BoxcastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn = default) => default; // 0x0000000189E1BE44-0x0000000189E1BEB8
		[FreeFunction("ScheduleBoxcastCommandBatch", ThrowsException = true)]
		private static unsafe JobHandle ScheduleBoxcastBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits) => default; // 0x0000000189E1C0AC-0x0000000189E1C118
		private static unsafe void ScheduleBoxcastBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out JobHandle ret) {
			ret = default;
		} // 0x0000000189E1C048-0x0000000189E1C0AC
	}
}
