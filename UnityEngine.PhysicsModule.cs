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

// Image 58: UnityEngine.PhysicsModule.dll - Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 88644-88679

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 88645
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 88646
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine
{
	public enum RigidbodyConstraints // TypeDefIndex: 88647
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

	public enum ForceMode // TypeDefIndex: 88648
	{
		Force = 0,
		Impulse = 1,
		VelocityChange = 2,
		Acceleration = 5
	}

	[Flags]
	public enum MeshColliderCookingOptions // TypeDefIndex: 88649
	{
		None = 0,
		InflateConvexMesh = 1,
		CookForFasterSimulation = 2,
		EnableMeshCleaning = 4,
		WeldColocatedVertices = 8,
		UseFastMidphase = 16
	}

	public enum ColliderSurfaceType // TypeDefIndex: 88650
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

	public enum RigidbodyInterpolation // TypeDefIndex: 88651
	{
		None = 0,
		Interpolate = 1,
		Extrapolate = 2
	}

	[RequiredByNativeCode]
	public class ControllerColliderHit // TypeDefIndex: 88652
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
		public GameObject gameObject { get; } // 0x000000018D54A9C8-0x000000018D54A9E8 
		public Vector3 point { get; } // 0x0000000187262140-0x0000000187262160 
	}

	[RequiredByNativeCode]
	public class Collision // TypeDefIndex: 88653
	{
		// Fields
		internal Vector3 m_Impulse; // 0x10
		internal Vector3 m_RelativeVelocity; // 0x1C
		internal Component m_Body; // 0x28
		internal Collider m_Collider; // 0x30
		internal int m_ContactCount; // 0x38
		internal ContactPoint[] m_ReusedContacts; // 0x40
		internal ContactPoint[] m_LegacyContacts; // 0x48
	
		// Properties
		public Vector3 relativeVelocity { get; } // 0x000000018725FE20-0x000000018725FE40 
		public Collider collider { get; } // 0x00000001872613B0-0x00000001872613C0 
		public GameObject gameObject { get; } // 0x000000018D54A908-0x000000018D54A97C 
		public ContactPoint[] contacts { get; } // 0x000000018D54A8A0-0x000000018D54A908 
		public Vector3 impulse { get; } // 0x000000018725FE70-0x000000018725FE90 
	}

	public enum QueryTriggerInteraction // TypeDefIndex: 88654
	{
		UseGlobal = 0,
		Ignore = 1,
		Collide = 2
	}

	public enum CollisionDetectionMode // TypeDefIndex: 88655
	{
		Discrete = 0,
		Continuous = 1,
		ContinuousDynamic = 2,
		ContinuousSpeculative = 3
	}

	[NativeClass("Unity::ArticulationBody")]
	[NativeHeader("Modules/Physics/ArticulationBody.h")]
	public class ArticulationBody : Behaviour // TypeDefIndex: 88656
	{
		// Constructors
		public ArticulationBody(); // 0x00000001878364A0-0x00000001878364B8
	}

	[NativeHeader("Modules/Physics/PhysicsManager.h")]
	[StaticAccessor("GetPhysicsManager()", StaticAccessorType.Dot)]
	public class Physics // TypeDefIndex: 88657
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD; // 0x08
		internal const float k_MaxFloatMinusEpsilon = 3.4028233E+38f; // Metadata: 0x0264865E
		public const int IgnoreRaycastLayer = 4; // Metadata: 0x02648662
		public const int DefaultRaycastLayers = -5; // Metadata: 0x02648663
		public const int AllLayers = -1; // Metadata: 0x02648664
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use Physics.IgnoreRaycastLayer instead. (UnityUpgradable) -> IgnoreRaycastLayer", true)]
		public const int kIgnoreRaycastLayer = 4; // Metadata: 0x02648665
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use Physics.DefaultRaycastLayers instead. (UnityUpgradable) -> DefaultRaycastLayers", true)]
		public const int kDefaultRaycastLayers = -5; // Metadata: 0x02648666
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use Physics.AllLayers instead. (UnityUpgradable) -> AllLayers", true)]
		public const int kAllLayers = -1; // Metadata: 0x02648667
	
		// Properties
		public static Vector3 gravity { [ThreadSafe] get; set; } // 0x0000000185773BC0-0x0000000185773BF0 0x000000018D5530D0-0x000000018D5530E0
		public static float defaultContactOffset { get; set; } // 0x000000018551E650-0x000000018551E690 0x000000018D552F80-0x000000018D552FBC
		public static float sleepThreshold { get; set; } // 0x000000018D552D40-0x000000018D552D6C 0x000000018D55325C-0x000000018D553298
		public static bool queriesHitTriggers { get; set; } // 0x000000018D552CE8-0x000000018D552D14 0x000000018D5531F4-0x000000018D553228
		public static bool queriesHitBackfaces { get; set; } // 0x000000018D552CBC-0x000000018D552CE8 0x000000018D5531C0-0x000000018D5531F4
		public static float bounceThreshold { get; set; } // 0x000000018D552AA0-0x000000018D552ACC 0x000000018D552EF8-0x000000018D552F34
		public static float defaultMaxDepenetrationVelocity { get; set; } // 0x000000018D552B5C-0x000000018D552B88 0x000000018D552FF8-0x000000018D553034
		public static int defaultSolverIterations { get; set; } // 0x000000018D552B88-0x000000018D552BB4 0x000000018D553034-0x000000018D553068
		public static int defaultSolverVelocityIterations { get; set; } // 0x000000018D552BB4-0x000000018D552BE0 0x000000018D553068-0x000000018D55309C
		public static float defaultMaxAngularSpeed { get; set; } // 0x000000018D552B30-0x000000018D552B5C 0x000000018D552FBC-0x000000018D552FF8
		public static bool improvedPatchFriction { get; set; } // 0x000000018D552BE0-0x000000018D552C0C 0x000000018D5530E0-0x000000018D553114
		[NativeProperty("DefaultPhysicsSceneHandle", true, UnityEngine.Bindings.TargetType.Function, true)]
		public static PhysicsScene defaultPhysicsScene { get; } // 0x00000001851795A0-0x00000001851795F0 
		public static bool logPhysXCheckError { get; set; } // 0x000000018D552C90-0x000000018D552CBC 0x000000018649C710-0x000000018649C750
		public static bool autoSimulation { get; set; } // 0x0000000185F01B30-0x0000000185F01B70 0x000000018649C750-0x000000018649C790
		public static bool autoSyncTransforms { get; set; } // 0x000000018D552A74-0x000000018D552AA0 0x000000018D552EC4-0x000000018D552EF8
		public static bool reuseCollisionCallbacks { get; set; } // 0x000000018D552D14-0x000000018D552D40 0x000000018D553228-0x000000018D55325C
		[StaticAccessor("GetPhysicsManager()")]
		public static float interCollisionDistance { [NativeName("GetClothInterCollisionDistance")] get; [NativeName("SetClothInterCollisionDistance")] set; } // 0x000000018D552C0C-0x000000018D552C38 0x000000018D553114-0x000000018D553150
		[StaticAccessor("GetPhysicsManager()")]
		public static float interCollisionStiffness { [NativeName("GetClothInterCollisionStiffness")] get; [NativeName("SetClothInterCollisionStiffness")] set; } // 0x000000018D552C64-0x000000018D552C90 0x000000018D553184-0x000000018D5531C0
		[StaticAccessor("GetPhysicsManager()")]
		public static bool interCollisionSettingsToggle { [NativeName("GetClothInterCollisionSettingsToggle")] get; [NativeName("SetClothInterCollisionSettingsToggle")] set; } // 0x000000018D552C38-0x000000018D552C64 0x000000018D553150-0x000000018D553184
		public static Vector3 clothGravity { [ThreadSafe] get; set; } // 0x000000018D552B0C-0x000000018D552B30 0x000000018D552F70-0x000000018D552F80
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Physics.defaultContactOffset or Collider.contactOffset instead.", true)]
		public static float minPenetrationForPenalty { get; set; } // 0x0000000187260470-0x0000000187260480 0x0000000186805BA0-0x0000000186805BB0
		[Obsolete("Please use bounceThreshold instead. (UnityUpgradable) -> bounceThreshold")]
		public static float bounceTreshold { get; set; } // 0x000000018D552ACC-0x000000018D552AD8 0x000000018D552F34-0x000000018D552F3C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", true)]
		public static float sleepVelocity { get; set; } // 0x0000000187260470-0x0000000187260480 0x0000000186805BA0-0x0000000186805BB0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("The sleepAngularVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", true)]
		public static float sleepAngularVelocity { get; set; } // 0x0000000187260470-0x0000000187260480 0x0000000186805BA0-0x0000000186805BB0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Rigidbody.maxAngularVelocity instead.", true)]
		public static float maxAngularVelocity { get; set; } // 0x0000000187260470-0x0000000187260480 0x0000000186805BA0-0x0000000186805BB0
		[Obsolete("Please use Physics.defaultSolverIterations instead. (UnityUpgradable) -> defaultSolverIterations")]
		public static int solverIterationCount { get; set; } // 0x000000018D552D6C-0x000000018D552D78 0x000000018D553298-0x000000018D5532A0
		[Obsolete("Please use Physics.defaultSolverVelocityIterations instead. (UnityUpgradable) -> defaultSolverVelocityIterations")]
		public static int solverVelocityIterationCount { get; set; } // 0x000000018D552D78-0x000000018D552D84 0x000000018D5532A0-0x000000018D5532A8
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("penetrationPenaltyForce has no effect.", true)]
		public static float penetrationPenaltyForce { get; set; } // 0x0000000187260470-0x0000000187260480 0x0000000186805BA0-0x0000000186805BB0
	
		// Events
		public static event Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent {
			add; // 0x000000018D5529D8-0x000000018D552A74
			remove; // 0x000000018D552E28-0x000000018D552EC4
		}
		public static event Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD {
			add; // 0x000000018D552934-0x000000018D5529D8
			remove; // 0x000000018D552D84-0x000000018D552E28
		}
	
		// Constructors
		public Physics(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[RequiredByNativeCode]
		private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD); // 0x000000018D54F064-0x000000018D54F120
		public static void ClearUnusedMemory(); // 0x0000000187221E70-0x0000000187221EB0
		public static void IgnoreCollision([NotNull("NullExceptionObject")] Collider collider1, [NotNull("NullExceptionObject")] Collider collider2, [UnityEngine.Internal.DefaultValue("true")] bool ignore); // 0x000000018D54EA20-0x000000018D54EA74
		[ExcludeFromDocs]
		public static void IgnoreCollision(Collider collider1, Collider collider2); // 0x000000018D54EA74-0x000000018D54EA80
		[NativeName("IgnoreCollision")]
		public static void IgnoreLayerCollision(int layer1, int layer2, [UnityEngine.Internal.DefaultValue("true")] bool ignore); // 0x000000018D54EA8C-0x000000018D54EADC
		[NativeName("ForceRebuildDynamicTree")]
		public static void ForceRebuildDynamicTree(bool rebuildStatic, bool rebuildDynamic); // 0x000000018D54E958-0x000000018D54E99C
		[ExcludeFromDocs]
		public static void IgnoreLayerCollision(int layer1, int layer2); // 0x000000018D54EA80-0x000000018D54EA8C
		public static bool GetIgnoreLayerCollision(int layer1, int layer2); // 0x000000018D54E9E0-0x000000018D54EA20
		public static bool GetIgnoreCollision([NotNull("NullExceptionObject")] Collider collider1, [NotNull("NullExceptionObject")] Collider collider2); // 0x000000018D54E99C-0x000000018D54E9E0
		public static bool Raycast(Vector3 origin, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185131ED0-0x0000000185131F70
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask); // 0x000000018D551880-0x000000018D551918
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance); // 0x000000018D551D48-0x000000018D551DD8
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction); // 0x000000018D551C40-0x000000018D551CC0
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018517CA50-0x000000018517CCE0
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask); // 0x0000000185A7E0B0-0x0000000185A7E150
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance); // 0x000000018517CF90-0x000000018517D210
		[ExcludeFromDocs]
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo); // 0x000000018D551918-0x000000018D5519B0
		public static bool RaycastV2(ECSColliderResultProxy proxy, Ray ray, float maxDistance, out RaycastHit hit); // 0x000000018D551754-0x000000018D5517E8
		public static bool RaycastV2(ECSColliderResultProxy proxy, Ray ray, float maxDistance, bool hitHoles, out RaycastHit hit); // 0x000000018D5517E8-0x000000018D551880
		[NativeName("RaycastTestV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static RaycastHit Internal_RaycastTestV2(ECSColliderResultProxy collider, Ray ray, float maxDistance, bool hitHoles, ref bool hasHit); // 0x000000018D54EC84-0x000000018D54ECF8
		public static bool Raycast(Ray ray, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D551BAC-0x000000018D551C40
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, float maxDistance, int layerMask); // 0x000000018D551A08-0x000000018D551A94
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, float maxDistance); // 0x000000018D551A94-0x000000018D551B14
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray); // 0x000000018D551DD8-0x000000018D551E4C
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018586EC40-0x000000018586ECE0
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask); // 0x000000018D5519B0-0x000000018D551A08
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance); // 0x000000018D551B14-0x000000018D551BAC
		[ExcludeFromDocs]
		public static bool Raycast(Ray ray, out RaycastHit hitInfo); // 0x000000018D551CC0-0x000000018D551D48
		public static bool Linecast(Vector3 start, Vector3 end, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54EF00-0x000000018D54EFD4
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end, int layerMask); // 0x000000018D54EFD4-0x000000018D54F01C
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end); // 0x000000018D54EEB4-0x000000018D54EF00
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54ED84-0x000000018D54EE60
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask); // 0x000000018D54F01C-0x000000018D54F064
		[ExcludeFromDocs]
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo); // 0x000000018D54EE60-0x000000018D54EEB4
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54DC2C-0x000000018D54DD04
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask); // 0x000000018D54DE0C-0x000000018D54DE88
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance); // 0x000000018D54DD90-0x000000018D54DE0C
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction); // 0x000000018D54DB24-0x000000018D54DB9C
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x00000001869B54D0-0x00000001869B55B0
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask); // 0x000000018D54DB9C-0x000000018D54DC2C
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance); // 0x000000018D54DA98-0x000000018D54DB24
		[ExcludeFromDocs]
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo); // 0x000000018D54DD04-0x000000018D54DD90
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018551D860-0x000000018551DA20
		[ExcludeFromDocs]
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask); // 0x000000018D5524F4-0x000000018D55255C
		[ExcludeFromDocs]
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance); // 0x000000018D552754-0x000000018D5527B8
		[ExcludeFromDocs]
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo); // 0x000000018D5525D0-0x000000018D552634
		public static bool SphereCast(Ray ray, float radius, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D552634-0x000000018D5526DC
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask); // 0x000000018D552720-0x000000018D552754
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, float maxDistance); // 0x000000018D552598-0x000000018D5525D0
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius); // 0x000000018D55281C-0x000000018D55285C
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D5527B8-0x000000018D55281C
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask); // 0x000000018D55285C-0x000000018D552898
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance); // 0x000000018D55255C-0x000000018D552598
		[ExcludeFromDocs]
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo); // 0x000000018D5526DC-0x000000018D552720
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54CD18-0x000000018D54CDF0
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask); // 0x000000018D54D084-0x000000018D54D114
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance); // 0x000000018D54CF2C-0x000000018D54CFBC
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation); // 0x000000018D54D1AC-0x000000018D54D238
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction); // 0x000000018D54CC80-0x000000018D54CD18
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54CFBC-0x000000018D54D084
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask); // 0x000000018D54CDF0-0x000000018D54CE8C
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance); // 0x000000018D54D238-0x000000018D54D2D0
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation); // 0x000000018D54D114-0x000000018D54D1AC
		[ExcludeFromDocs]
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo); // 0x000000018D54CE8C-0x000000018D54CF2C
		[NativeName("RaycastAll")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54EBF8-0x000000018D54EC20
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D55125C-0x000000018D551384
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask); // 0x000000018D551214-0x000000018D55125C
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance); // 0x000000018D5513D4-0x000000018D551428
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction); // 0x000000018D551428-0x000000018D551484
		public static RaycastHit[] RaycastAll(Ray ray, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D551384-0x000000018D5513D4
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask); // 0x000000018D5511C0-0x000000018D551214
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance); // 0x000000018D551168-0x000000018D5511C0
		[ExcludeFromDocs]
		public static RaycastHit[] RaycastAll(Ray ray); // 0x000000018D551484-0x000000018D5514E0
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185E15A40-0x0000000185E15D10
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask); // 0x0000000185BF54A0-0x0000000185BF5540
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance); // 0x000000018D5514E0-0x000000018D551578
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results); // 0x00000001865F1000-0x00000001865F1090
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185179270-0x00000001851795A0
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask); // 0x000000018D551618-0x000000018D5516BC
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance); // 0x000000018D551578-0x000000018D551618
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results); // 0x000000018D5516BC-0x000000018D551754
		[NativeName("CapsuleCastAll")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static RaycastHit[] Query_CapsuleCastAll(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D550B14-0x000000018D550B68
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54D2D0-0x000000018D54D414
		[ExcludeFromDocs]
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask); // 0x000000018D54D490-0x000000018D54D50C
		[ExcludeFromDocs]
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance); // 0x000000018D54D414-0x000000018D54D490
		[ExcludeFromDocs]
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction); // 0x000000018D54D50C-0x000000018D54D584
		[NativeName("SphereCastAll")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D551070-0x000000018D5510B0
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D552174-0x000000018D5522A4
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask); // 0x000000018D551F94-0x000000018D551FEC
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance); // 0x000000018D5520E4-0x000000018D55213C
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction); // 0x000000018D552084-0x000000018D5520E4
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D55202C-0x000000018D552084
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask); // 0x000000018D551F60-0x000000018D551F94
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance); // 0x000000018D55213C-0x000000018D552174
		[ExcludeFromDocs]
		public static RaycastHit[] SphereCastAll(Ray ray, float radius); // 0x000000018D551FEC-0x000000018D55202C
		[NativeName("OverlapCapsule")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static Collider[] OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D550198-0x000000018D5501C8
		public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D550294-0x000000018D550370
		[ExcludeFromDocs]
		public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask); // 0x000000018D5501C8-0x000000018D550294
		[ExcludeFromDocs]
		public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius); // 0x000000018D550370-0x000000018D550430
		[NativeName("OverlapCapsuleV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static ECSColliderResultProxy[] OverlapCapsuleV2_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54FFE0-0x000000018D550010
		public static ECSColliderResultProxy[] OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D5500A8-0x000000018D550134
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius, int layerMask); // 0x000000018D550060-0x000000018D5500A8
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius); // 0x000000018D550010-0x000000018D550060
		[NativeName("OverlapSphere")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D550890-0x000000018D5508B8
		public static Collider[] OverlapSphere(Vector3 position, float radius, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D55095C-0x000000018D550A18
		public static ECSColliderResultProxy CreateECSProxy(Collider collider); // 0x0000000185556100-0x00000001855562E0
		[ExcludeFromDocs]
		public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask); // 0x000000018D5508B8-0x000000018D55095C
		[ExcludeFromDocs]
		public static Collider[] OverlapSphere(Vector3 position, float radius); // 0x000000018D550A18-0x000000018D550AB0
		[NativeName("OverlapSphereV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static ECSColliderResultProxy[] OverlapSphereV2_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D550730-0x000000018D550758
		public static ECSColliderResultProxy[] OverlapSphereV2(Vector3 position, float radius, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D550790-0x000000018D5507FC
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapSphereV2(Vector3 position, float radius, int layerMask); // 0x000000018D5507FC-0x000000018D55082C
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapSphereV2(Vector3 position, float radius); // 0x000000018D550758-0x000000018D550790
		[NativeName("Simulate")]
		internal static void Simulate_Internal(PhysicsScene physicsScene, float step); // 0x000000018783B210-0x000000018783B22C
		public static void Simulate(float step); // 0x0000000185F01AA0-0x0000000185F01B30
		public static void SyncTransforms(); // 0x00000001857EF630-0x00000001857EF760
		[NativeName("ComputePenetration")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputePenetration([NotNull("ArgumentNullException")] Collider colliderA, Vector3 positionA, Quaternion rotationA, [NotNull("ArgumentNullException")] Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018D550F24-0x000000018D550F70
		public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // 0x000000018D54E760-0x000000018D54E8A0
		[NativeName("ComputePenetrationV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputePenetrationV2(ECSColliderResultProxy colliderA, Vector3 positionA, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x0000000187836924-0x0000000187836970
		public static bool ComputePenetrationV2(ECSColliderResultProxy colliderA, Vector3 positionA, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // 0x00000001855568B0-0x00000001855569D0
		[NativeName("ComputeCapsulePenetration")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputeCapsulePenetration(Vector3 point1, Vector3 point2, float radius, [NotNull("ArgumentNullException")] Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018D550E74-0x000000018D550EC0
		public static bool ComputeCapsulePenetration(Vector3 point1, Vector3 point2, float radius, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // 0x000000018D54E630-0x000000018D54E760
		[NativeName("ComputeCapsulePenetrationV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputeCapsulePenetrationV2(Vector3 point1, Vector3 point2, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018D550DC4-0x000000018D550E10
		public static bool ComputeCapsulePenetrationV2(Vector3 point1, Vector3 point2, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // 0x000000018D54E560-0x000000018D54E630
		[NativeName("ComputeSpherePenetrationV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputeSpherePenetrationV2(Vector3 center, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018D550FD4-0x000000018D55100C
		public static bool ComputeSpherePenetrationV2(Vector3 center, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // 0x000000018D54E8A0-0x000000018D54E958
		[NativeName("ComputeBoxPenetrationV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool Query_ComputeBoxPenetrationV2(Vector3 center, Vector3 halfExtent, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018D550D14-0x000000018D550D60
		public static bool ComputeBoxPenetrationV2(Vector3 center, Vector3 halfExtent, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // 0x000000018D54E47C-0x000000018D54E560
		[NativeName("IsSimulatedThisFrame")]
		[StaticAccessor("GetPhysicsManager()")]
		private static bool IsSimulatedThisFrame_Internal(); // 0x000000018D54ED4C-0x000000018D54ED78
		public static bool IsSimulatedThisFrame(); // 0x000000018D54ED78-0x000000018D54ED84
		[NativeName("SetForceSimulateThisFrame")]
		[StaticAccessor("GetPhysicsManager()")]
		private static void SetForceSimulateThisFrame_Internal(bool force); // 0x0000000186D2D9C0-0x0000000186D2DA00
		public static void SetForceSimulateThisFrame(bool force); // 0x000000018783C4CC-0x000000018783C4D4
		[NativeName("SetFastSimulate")]
		[StaticAccessor("GetPhysicsManager()")]
		private static void SetFastSimulate_Internal(bool fast); // 0x00000001871EBF60-0x00000001871EBFA0
		public static void SetFastSimulate(bool fast); // 0x000000018783C1B4-0x000000018783C1BC
		[NativeName("ClosestPoint")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static Vector3 Query_ClosestPoint([NotNull("ArgumentNullException")] Collider collider, Vector3 position, Quaternion rotation, Vector3 point); // 0x000000018D550C70-0x000000018D550CB0
		public static Vector3 ClosestPoint(Vector3 point, Collider collider, Vector3 position, Quaternion rotation); // 0x000000018D54E380-0x000000018D54E47C
		[NativeName("ClosestPointV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static Vector3 Query_ClosestPointV2(ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation, Vector3 point); // 0x000000018D550BCC-0x000000018D550C0C
		public static Vector3 ClosestPointV2(Vector3 point, ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation); // 0x000000018D54E2DC-0x000000018D54E380
		[NativeName("TryGetClosestPoint")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static Vector3 Query_TryGetClosestPoint(ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation, Vector3 point, ref bool resultIsValid); // 0x000000018D551114-0x000000018D551168
		public static bool TryGetClosestPoint(ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation, Vector3 point, out Vector3 result); // 0x000000018D552898-0x000000018D552934
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D5505FC-0x000000018D5506CC
		[ExcludeFromDocs]
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask); // 0x000000018D550544-0x000000018D5505FC
		[ExcludeFromDocs]
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results); // 0x000000018D550498-0x000000018D550544
		public static int OverlapSphereNonAllocV2(Vector3 position, float radius, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185537130-0x00000001855371D0
		[ExcludeFromDocs]
		public static int OverlapSphereNonAllocV2(Vector3 position, float radius, ECSColliderResultProxy[] results, int layerMask); // 0x000000018D550468-0x000000018D550498
		[ExcludeFromDocs]
		public static int OverlapSphereNonAllocV2(Vector3 position, float radius, ECSColliderResultProxy[] results); // 0x000000018D550430-0x000000018D550468
		[NativeName("SphereTest")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54E1E0-0x000000018D54E208
		public static bool CheckSphere(Vector3 position, float radius, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54E240-0x000000018D54E2AC
		[ExcludeFromDocs]
		public static bool CheckSphere(Vector3 position, float radius, int layerMask); // 0x000000018D54E2AC-0x000000018D54E2DC
		[ExcludeFromDocs]
		public static bool CheckSphere(Vector3 position, float radius); // 0x000000018D54E208-0x000000018D54E240
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185592730-0x00000001855928D0
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54D734-0x000000018D54D814
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask); // 0x000000018D54D8F0-0x000000018D54D980
		[ExcludeFromDocs]
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask); // 0x000000018D54D814-0x000000018D54D8F0
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance); // 0x000000018D54DA0C-0x000000018D54DA98
		[ExcludeFromDocs]
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance); // 0x000000018D54D65C-0x000000018D54D734
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results); // 0x000000018D54D980-0x000000018D54DA0C
		[ExcludeFromDocs]
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results); // 0x000000018D54D584-0x000000018D54D65C
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185615650-0x00000001856157D0
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask); // 0x000000018D552428-0x000000018D552490
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance); // 0x000000018D552360-0x000000018D5523C4
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results); // 0x000000018D552490-0x000000018D5524F4
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D5523C4-0x000000018D552428
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask); // 0x000000018D5522E8-0x000000018D552324
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance); // 0x000000018D552324-0x000000018D552360
		[ExcludeFromDocs]
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results); // 0x000000018D5522A4-0x000000018D5522E8
		[NativeName("CapsuleTest")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x00000001878367A0-0x00000001878367D0
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018551D030-0x000000018551D0D0
		[ExcludeFromDocs]
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask); // 0x000000018D54E0E0-0x000000018D54E128
		[ExcludeFromDocs]
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius); // 0x000000018D54E128-0x000000018D54E17C
		[NativeName("BoxTest")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54DEEC-0x000000018D54DF1C
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layermask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54DFEC-0x000000018D54E084
		[ExcludeFromDocs]
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask); // 0x000000018D54E084-0x000000018D54E0E0
		[ExcludeFromDocs]
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation); // 0x000000018D54DF1C-0x000000018D54DF7C
		[ExcludeFromDocs]
		public static bool CheckBox(Vector3 center, Vector3 halfExtents); // 0x000000018D54DF7C-0x000000018D54DFEC
		[NativeName("OverlapBox")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54F8B0-0x000000018D54F8E0
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54FA74-0x000000018D54FB58
		[ExcludeFromDocs]
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask); // 0x000000018D54FB58-0x000000018D54FC30
		[ExcludeFromDocs]
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation); // 0x000000018D54F8E0-0x000000018D54F9AC
		[ExcludeFromDocs]
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents); // 0x000000018D54F9AC-0x000000018D54FA74
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("AllLayers")] int mask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54F258-0x000000018D54F358
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask); // 0x000000018D54F358-0x000000018D54F43C
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation); // 0x000000018D54F43C-0x000000018D54F51C
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results); // 0x000000018D54F51C-0x000000018D54F5F8
		[NativeName("OverlapBoxV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static ECSColliderResultProxy[] OverlapBoxV2_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54F65C-0x000000018D54F68C
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54F7B4-0x000000018D54F84C
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask); // 0x000000018D54F758-0x000000018D54F7B4
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents, Quaternion orientation); // 0x000000018D54F68C-0x000000018D54F6EC
		[ExcludeFromDocs]
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents); // 0x000000018D54F6EC-0x000000018D54F758
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("AllLayers")] int mask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018552F0D0-0x000000018552F180
		[ExcludeFromDocs]
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, Quaternion orientation, int mask); // 0x000000018D54F190-0x000000018D54F1F4
		[ExcludeFromDocs]
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, Quaternion orientation); // 0x000000018D54F1F4-0x000000018D54F258
		[ExcludeFromDocs]
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results); // 0x000000018D54F120-0x000000018D54F190
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018586E5A0-0x000000018586E6F0
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation); // 0x000000018D54CB50-0x000000018D54CBE8
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance); // 0x000000018D54CBE8-0x000000018D54CC80
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layerMask); // 0x000000018D54CA14-0x000000018D54CAB0
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results); // 0x000000018D54CAB0-0x000000018D54CB50
		[NativeName("BoxCastAll")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static RaycastHit[] Internal_BoxCastAll(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54EB40-0x000000018D54EB94
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54C688-0x000000018D54C7D0
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask); // 0x000000018D54C8EC-0x000000018D54C97C
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance); // 0x000000018D54C7D0-0x000000018D54C860
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation); // 0x000000018D54C860-0x000000018D54C8EC
		[ExcludeFromDocs]
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction); // 0x000000018D54C97C-0x000000018D54CA14
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54FE88-0x000000018D54FF7C
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask); // 0x000000018D54FCDC-0x000000018D54FDB4
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results); // 0x000000018D54FDB4-0x000000018D54FE88
		public static int OverlapCapsuleNonAllocV2(Vector3 point0, Vector3 point1, float radius, [Unmarshalled] ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185597550-0x0000000185597640
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAllocV2(Vector3 point0, Vector3 point1, float radius, [Unmarshalled] ECSColliderResultProxy[] results, int layerMask); // 0x000000018D54FC84-0x000000018D54FCDC
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAllocV2(Vector3 point0, Vector3 point1, float radius, [Unmarshalled] ECSColliderResultProxy[] results); // 0x000000018D54FC30-0x000000018D54FC84
		[NativeName("RebuildBroadphaseRegions")]
		[StaticAccessor("GetPhysicsManager()")]
		private static void Internal_RebuildBroadphaseRegions(Bounds bounds, int subdivisions); // 0x000000018D54ED38-0x000000018D54ED4C
		public static void RebuildBroadphaseRegions(Bounds worldBounds, int subdivisions); // 0x000000018D551E4C-0x000000018D551F60
		[StaticAccessor("GetPhysicsManager()")]
		[ThreadSafe]
		public static void BakeMesh(int meshID, bool convex); // 0x000000018D54C648-0x000000018D54C688
		private static void get_gravity_Injected(out Vector3 ret); // 0x0000000185773BF0-0x0000000185773C30
		private static void set_gravity_Injected(ref Vector3 value); // 0x000000018D55309C-0x000000018D5530D0
		private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret); // 0x00000001851795F0-0x0000000185179630
		private static void Internal_RaycastTestV2_Injected(ref ECSColliderResultProxy collider, ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret); // 0x000000018D54EC20-0x000000018D54EC84
		private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54EB94-0x000000018D54EBF8
		private static RaycastHit[] Query_CapsuleCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D550AB0-0x000000018D550B14
		private static RaycastHit[] Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D55100C-0x000000018D551070
		private static Collider[] OverlapCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D550134-0x000000018D550198
		private static ECSColliderResultProxy[] OverlapCapsuleV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54FF7C-0x000000018D54FFE0
		private static Collider[] OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D55082C-0x000000018D550890
		private static ECSColliderResultProxy[] OverlapSphereV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D5506CC-0x000000018D550730
		private static void Simulate_Internal_Injected(ref PhysicsScene physicsScene, float step); // 0x0000000185F01B70-0x0000000185F01C40
		private static bool Query_ComputePenetration_Injected(Collider colliderA, ref Vector3 positionA, ref Quaternion rotationA, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018D550EC0-0x000000018D550F24
		private static bool Query_ComputePenetrationV2_Injected(ref ECSColliderResultProxy colliderA, ref Vector3 positionA, ref Quaternion rotationA, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x00000001865D5420-0x00000001865D5490
		private static bool Query_ComputeCapsulePenetration_Injected(ref Vector3 point1, ref Vector3 point2, float radius, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018D550E10-0x000000018D550E74
		private static bool Query_ComputeCapsulePenetrationV2_Injected(ref Vector3 point1, ref Vector3 point2, float radius, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018D550D60-0x000000018D550DC4
		private static bool Query_ComputeSpherePenetrationV2_Injected(ref Vector3 center, float radius, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018D550F70-0x000000018D550FD4
		private static bool Query_ComputeBoxPenetrationV2_Injected(ref Vector3 center, ref Vector3 halfExtent, ref Quaternion rotationA, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance); // 0x000000018D550CB0-0x000000018D550D14
		private static void Query_ClosestPoint_Injected(Collider collider, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, out Vector3 ret); // 0x000000018D550C0C-0x000000018D550C70
		private static void Query_ClosestPointV2_Injected(ref ECSColliderResultProxy colliderProxy, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, out Vector3 ret); // 0x000000018D550B68-0x000000018D550BCC
		private static void Query_TryGetClosestPoint_Injected(ref ECSColliderResultProxy colliderProxy, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, ref bool resultIsValid, out Vector3 ret); // 0x000000018D5510B0-0x000000018D551114
		private static void get_clothGravity_Injected(out Vector3 ret); // 0x000000018D552AD8-0x000000018D552B0C
		private static void set_clothGravity_Injected(ref Vector3 value); // 0x000000018D552F3C-0x000000018D552F70
		private static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54E17C-0x000000018D54E1E0
		private static bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018628ABE0-0x000000018628AC50
		private static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54DE88-0x000000018D54DEEC
		private static Collider[] OverlapBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54F84C-0x000000018D54F8B0
		private static ECSColliderResultProxy[] OverlapBoxV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54F5F8-0x000000018D54F65C
		private static RaycastHit[] Internal_BoxCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54EADC-0x000000018D54EB40
		private static void Internal_RebuildBroadphaseRegions_Injected(ref Bounds bounds, int subdivisions); // 0x000000018D54ECF8-0x000000018D54ED38
	}

	public struct ModifiableContactPair // TypeDefIndex: 88658
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
	public class PhysicMaterial : Object // TypeDefIndex: 88659
	{
		// Constructors
		public PhysicMaterial(); // 0x000000018D54BC0C-0x000000018D54BC60
	
		// Methods
		private static void Internal_CreateDynamicsMaterial([Writable] PhysicMaterial mat, string name); // 0x000000018D54BBC8-0x000000018D54BC0C
	}

	[NativeHeader("Modules/Physics/RaycastHit.h")]
	[NativeHeader("Runtime/Interfaces/IRaycast.h")]
	[NativeHeader("PhysicsScriptingClasses.h")]
	[UsedByNativeCode]
	public struct ECSColliderResultProxy : IEquatable<UnityEngine.ECSColliderResultProxy> // TypeDefIndex: 88660
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
		public int componentIndex { get; } // 0x0000000187233B60-0x0000000187233B70 
		public Entity colliderEntity { get; } // 0x000000018D54ABEC-0x000000018D54ABFC 
		public int ecsId { get; } // 0x000000018453A050-0x000000018453A060 
		public uint ecsVersion { get; } // 0x000000018724B3B0-0x000000018724B3C0 
		public static ECSColliderResultProxy invalid { get; } // 0x000000018D54AD58-0x000000018D54ADBC 
		public Collider collider { get; } // 0x0000000185179E50-0x0000000185179EC0 
		public int colliderInstanceId { get; } // 0x000000018725FFC0-0x000000018725FFD0 
		public bool bIsECS { get; } // 0x000000018517AA70-0x000000018517AA90 
		public int tagConfig { get; } // 0x0000000185779810-0x0000000185779890 
		public bool isTrigger { get; } // 0x00000001856162B0-0x0000000185616480 
		public int layer { get; } // 0x000000018517D210-0x000000018517D3F0 
		public Transform transform { get; } // 0x0000000185596FE0-0x0000000185597100 
		public Vector3 transformPosition { get; } // 0x0000000185535750-0x0000000185535910 
		public Quaternion transformRotation { get; } // 0x0000000185556320-0x00000001855564C0 
		public Vector3 transformLossyScale { get; } // 0x000000018D54ADBC-0x000000018D54AEC4 
		public Vector3 shapePosition { get; } // 0x0000000184FBD000-0x0000000184FBD220 
		public Bounds bounds { get; } // 0x0000000184FBD220-0x0000000184FBD400 
		public int colliderOptions { get; } // 0x000000018517AA90-0x000000018517AC70 
		public ColliderSurfaceType surfaceType { get; } // 0x00000001864A7540-0x00000001864A7580 
		public ECSColliderType colliderType { get; } // 0x000000018D54ABFC-0x000000018D54AD58 
		public GameObject gameObject { get; } // 0x0000000185321FD0-0x0000000185322080 
		public bool hasComplexMesh { get; } // 0x000000018517B1F0-0x000000018517B390 
	
		// Constructors
		static ECSColliderResultProxy(); // 0x00000001871FD140-0x00000001871FD180
	
		// Methods
		public void SetColliderAndSetIndex(int colliderInstanceID); // 0x000000018517A080-0x000000018517A1C0
		public void SetComponentIndex(int index); // 0x000000018275FD70-0x000000018275FD80
		public void SetActor(IntPtr actor); // 0x000000018561B5B0-0x000000018561B5C0
		public void SetEcsId(int id); // 0x0000000187235AA0-0x0000000187235AB0
		public void SetEcsVersion(uint version); // 0x00000001872397D0-0x00000001872397E0
		public bool IsValid(); // 0x000000018517A890-0x000000018517AA10
		public string GetColliderGoName(); // 0x0000000185533EA0-0x0000000185533FF0
		public int GetFactoryBuildingIdentifier(); // 0x0000000186260140-0x00000001862601B0
		public bool TryGetClosestPoint(Vector3 point, out Vector3 result); // 0x000000018552F230-0x000000018552F2F0
		public Vector3 ClosestPoint(Vector3 position); // 0x00000001855341F0-0x00000001855343A0
		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance); // 0x000000018D54AA8C-0x000000018D54ABEC
		public static bool operator ==(ECSColliderResultProxy left, ECSColliderResultProxy right); // 0x000000018D54AEC4-0x000000018D54AF54
		public static bool operator !=(ECSColliderResultProxy left, ECSColliderResultProxy right); // 0x00000001857601A0-0x0000000185760220
		public bool Equals(ECSColliderResultProxy other); // 0x000000018644A5C0-0x000000018644A640
		public override bool Equals(object obj); // 0x000000018D54A9E8-0x000000018D54AA8C
		public override int GetHashCode(); // 0x0000000186078FD0-0x0000000186079090
		public bool CompareTag(int tagValue); // 0x0000000185615C30-0x0000000185615E00
		public bool IsSameCollider(Collider otherCollider); // 0x0000000185597100-0x00000001855971A0
	}

	[NativeHeader("Modules/Physics/RaycastHit.h")]
	[NativeHeader("Runtime/Interfaces/IRaycast.h")]
	[NativeHeader("PhysicsScriptingClasses.h")]
	[UsedByNativeCode]
	public struct RaycastHit // TypeDefIndex: 88661
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
		public int ecsId { get; } // 0x000000018725FF30-0x000000018725FF40 
		public uint ecsVersion { get; } // 0x000000018725FEB0-0x000000018725FEC0 
		public bool IsECSCollider { get; } // 0x0000000185580010-0x0000000185580030 
		public Collider collider { get; } // 0x000000018622BF10-0x000000018622BF80 
		public int colliderInstanceID { get; } // 0x00000001872613C0-0x00000001872613D0 
		public Collider editorCollider { get; } // 0x000000018D5533E4-0x000000018D553474 
		public ECSColliderResultProxy colliderProxy { get; } // 0x0000000185179EC0-0x000000018517A080 
		public Vector3 point { get; set; } // 0x000000018725FDC0-0x000000018725FDE0 0x000000018723AEB0-0x000000018723AEC0
		public Vector3 normal { get; set; } // 0x000000018725FDA0-0x000000018725FDC0 0x000000018723AEC0-0x000000018723AED0
		public Vector3 barycentricCoordinate { get; set; } // 0x0000000187262180-0x00000001872621B0 0x000000018D55384C-0x000000018D55386C
		public float distance { get; set; } // 0x0000000187262050-0x0000000187262060 0x0000000187233420-0x0000000187233430
		public int triangleIndex { get; } // 0x000000018724B960-0x000000018724B970 
		public int componentIndex { get; } // 0x00000001872621B0-0x00000001872621C0 
		public Vector2 textureCoord { get; } // 0x000000018D5537E8-0x000000018D55384C 
		public Vector2 textureCoord2 { get; } // 0x000000018D553784-0x000000018D5537E8 
		public Transform transform { get; } // 0x000000018622BB60-0x000000018622BC90 
		public Vector3 shapePosition { get; } // 0x000000018D5536FC-0x000000018D55373C 
		public Quaternion shapeRotation { get; } // 0x000000018D55373C-0x000000018D553774 
		public Vector3 position { get; } // 0x000000018D5535E4-0x000000018D553618 
		public Quaternion rotation { get; } // 0x000000018D553618-0x000000018D553644 
		public Vector3 scale { get; } // 0x000000018D553644-0x000000018D5536FC 
		public Rigidbody rigidbody { get; } // 0x000000018622BAC0-0x000000018622BB60 
		public ArticulationBody articulationBody { get; } // 0x000000018D553354-0x000000018D5533E4 
		public Vector2 lightmapCoord { get; } // 0x000000018D553474-0x000000018D5535E4 
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use textureCoord2 instead. (UnityUpgradable) -> textureCoord2")]
		public Vector2 textureCoord1 { get; } // 0x000000018D553774-0x000000018D553784 
	
		// Methods
		[FreeFunction]
		private static Vector2 CalculateRaycastTexCoord(Collider collider, int m_Index, Vector2 uv, Vector3 pos, uint face, int textcoord); // 0x000000018D553308-0x000000018D553354
		private static void CalculateRaycastTexCoord_Injected(Collider collider, int m_Index, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret); // 0x000000018D5532A8-0x000000018D553308
	}

	[NativeHeader("Modules/Physics/Rigidbody.h")]
	[RequireComponent(typeof(Transform))]
	public class Rigidbody : Component // TypeDefIndex: 88662
	{
		// Properties
		public Vector3 velocity { get; set; } // 0x0000000185776030-0x0000000185776090 0x000000018D554ECC-0x000000018D554EE0
		public Vector3 angularVelocity { get; set; } // 0x0000000185774980-0x00000001857749B0 0x000000018D554A6C-0x000000018D554A80
		public float drag { get; set; } // 0x00000001857760E0-0x0000000185776120 0x00000001866CD620-0x00000001866CD670
		public float angularDrag { get; set; } // 0x000000018D554508-0x000000018D55453C 0x00000001866CD670-0x00000001866CD6C0
		public float mass { get; set; } // 0x000000018D554754-0x000000018D554788 0x00000001866CD6C0-0x00000001866CD710
		public bool useGravity { get; set; } // 0x000000018D554984-0x000000018D5549B8 0x000000018D554E44-0x000000018D554E88
		public float maxDepenetrationVelocity { get; set; } // 0x000000018D5547BC-0x000000018D5547F0 0x000000018D554CD4-0x000000018D554D18
		public bool isKinematic { get; set; } // 0x000000018D554720-0x000000018D554754 0x00000001857745B0-0x0000000185774600
		public bool freezeRotation { get; set; } // 0x000000018D5545D8-0x000000018D55460C 0x000000018D554B5C-0x000000018D554BA0
		public RigidbodyConstraints constraints { get; set; } // 0x000000018D554570-0x000000018D5545A4 0x000000018D554AD8-0x000000018D554B18
		public CollisionDetectionMode collisionDetectionMode { get; set; } // 0x000000018D55453C-0x000000018D554570 0x00000001866CDE50-0x00000001866CDEA0
		public Vector3 centerOfMass { get; set; } // 0x00000001866CDE20-0x00000001866CDE50 0x000000018D554AC4-0x000000018D554AD8
		public Vector3 worldCenterOfMass { get; } // 0x000000018D5549FC-0x000000018D554A28 
		public Quaternion inertiaTensorRotation { get; set; } // 0x000000018D554650-0x000000018D55467C 0x000000018D554BE4-0x000000018D554BF8
		public Vector3 inertiaTensor { get; set; } // 0x000000018D5546C0-0x000000018D5546EC 0x000000018D554C3C-0x000000018D554C50
		public bool detectCollisions { get; set; } // 0x000000018D5545A4-0x000000018D5545D8 0x000000018D554B18-0x000000018D554B5C
		public Vector3 position { get; set; } // 0x000000018D554834-0x000000018D554860 0x0000000187836A08-0x0000000187836A1C
		public Quaternion rotation { get; set; } // 0x000000018D5548A4-0x000000018D5548D0 0x000000018D554D5C-0x000000018D554D70
		public RigidbodyInterpolation interpolation { get; set; } // 0x000000018D5546EC-0x000000018D554720 0x000000018D554C50-0x000000018D554C90
		public int solverIterations { get; set; } // 0x000000018D554910-0x000000018D554944 0x000000018D554DBC-0x000000018D554DFC
		public float sleepThreshold { get; set; } // 0x000000018D5548D0-0x000000018D554904 0x000000018D554D70-0x000000018D554DB4
		public float maxAngularVelocity { get; set; } // 0x000000018D554788-0x000000018D5547BC 0x000000018D554C90-0x000000018D554CD4
		public int solverVelocityIterations { get; set; } // 0x000000018D554950-0x000000018D554984 0x000000018D554E04-0x000000018D554E44
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", true)]
		public float sleepVelocity { get; set; } // 0x0000000187260470-0x0000000187260480 0x0000000186805BA0-0x0000000186805BB0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("The sleepAngularVelocity is no longer supported. Use sleepThreshold to specify energy.", true)]
		public float sleepAngularVelocity { get; set; } // 0x0000000187260470-0x0000000187260480 0x0000000186805BA0-0x0000000186805BB0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Cone friction is no longer supported.", true)]
		public bool useConeFriction { get; set; } // 0x0000000187232850-0x0000000187232860 0x0000000186805BA0-0x0000000186805BB0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use Rigidbody.solverIterations instead. (UnityUpgradable) -> solverIterations")]
		public int solverIterationCount { get; set; } // 0x000000018D554904-0x000000018D554910 0x000000018D554DB4-0x000000018D554DBC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use Rigidbody.solverVelocityIterations instead. (UnityUpgradable) -> solverVelocityIterations")]
		public int solverVelocityIterationCount { get; set; } // 0x000000018D554944-0x000000018D554950 0x000000018D554DFC-0x000000018D554E04
	
		// Constructors
		public Rigidbody(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void SetDensity(float density); // 0x000000018D5540E4-0x000000018D554128
		public void MovePosition(Vector3 position); // 0x000000018D554010-0x000000018D554024
		public void MoveRotation(Quaternion rot); // 0x000000018D554068-0x000000018D55407C
		public void Sleep(); // 0x000000018D554130-0x000000018D554164
		public bool IsSleeping(); // 0x0000000185775740-0x0000000185775780
		public void WakeUp(); // 0x000000018D5544D4-0x000000018D554508
		public void ResetCenterOfMass(); // 0x000000018D55407C-0x000000018D5540B0
		public void ResetInertiaTensor(); // 0x000000018D5540B0-0x000000018D5540E4
		public Vector3 GetRelativePointVelocity(Vector3 relativePoint); // 0x000000018D553EA0-0x000000018D553ED4
		public Vector3 GetPointVelocity(Vector3 worldPoint); // 0x000000018D553E18-0x000000018D553E4C
		public void AddForce(Vector3 force, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] ForceMode mode); // 0x000000018783C604-0x000000018783C618
		[ExcludeFromDocs]
		public void AddForce(Vector3 force); // 0x000000018783C618-0x000000018783C644
		public void AddForce(float x, float y, float z, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] ForceMode mode); // 0x000000018D553A3C-0x000000018D553A68
		[ExcludeFromDocs]
		public void AddForce(float x, float y, float z); // 0x000000018D553A68-0x000000018D553A90
		public void AddRelativeForce(Vector3 force, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] ForceMode mode); // 0x000000018D553B38-0x000000018D553B4C
		[ExcludeFromDocs]
		public void AddRelativeForce(Vector3 force); // 0x000000018D553AE4-0x000000018D553B10
		public void AddRelativeForce(float x, float y, float z, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] ForceMode mode); // 0x000000018D553B4C-0x000000018D553B78
		[ExcludeFromDocs]
		public void AddRelativeForce(float x, float y, float z); // 0x000000018D553B10-0x000000018D553B38
		public void AddTorque(Vector3 torque, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] ForceMode mode); // 0x000000018D553CD4-0x000000018D553CE8
		[ExcludeFromDocs]
		public void AddTorque(Vector3 torque); // 0x000000018D553CA8-0x000000018D553CD4
		public void AddTorque(float x, float y, float z, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] ForceMode mode); // 0x000000018D553D10-0x000000018D553D3C
		[ExcludeFromDocs]
		public void AddTorque(float x, float y, float z); // 0x000000018D553CE8-0x000000018D553D10
		public void AddRelativeTorque(Vector3 torque, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] ForceMode mode); // 0x000000018D553C24-0x000000018D553C38
		[ExcludeFromDocs]
		public void AddRelativeTorque(Vector3 torque); // 0x000000018D553BF8-0x000000018D553C24
		public void AddRelativeTorque(float x, float y, float z, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] ForceMode mode); // 0x000000018D553BCC-0x000000018D553BF8
		[ExcludeFromDocs]
		public void AddRelativeTorque(float x, float y, float z); // 0x000000018D553C38-0x000000018D553C54
		public void AddForceAtPosition(Vector3 force, Vector3 position, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] ForceMode mode); // 0x000000018D5539DC-0x000000018D5539F4
		[ExcludeFromDocs]
		public void AddForceAtPosition(Vector3 force, Vector3 position); // 0x000000018D5539F4-0x000000018D553A3C
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, [UnityEngine.Internal.DefaultValue("0.0f")] float upwardsModifier, [UnityEngine.Internal.DefaultValue("ForceMode.Force)")] ForceMode mode); // 0x000000018D55394C-0x000000018D553978
		[ExcludeFromDocs]
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier); // 0x000000018D55390C-0x000000018D55394C
		[ExcludeFromDocs]
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius); // 0x000000018D5538D0-0x000000018D55390C
		[NativeName("ClosestPointOnBounds")]
		private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance); // 0x000000018D553F38-0x000000018D553F50
		public Vector3 ClosestPointOnBounds(Vector3 position); // 0x000000018D553D3C-0x000000018D553DC4
		private RaycastHit SweepTest(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit); // 0x000000018D554328-0x000000018D55439C
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D5543D4-0x000000018D5544D4
		[ExcludeFromDocs]
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance); // 0x000000018D5542F8-0x000000018D554328
		[ExcludeFromDocs]
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo); // 0x000000018D55439C-0x000000018D5543D4
		[NativeName("SweepTestAll")]
		private RaycastHit[] Internal_SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D553FB4-0x000000018D553FCC
		public RaycastHit[] SweepTestAll(Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D554194-0x000000018D55425C
		[ExcludeFromDocs]
		public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance); // 0x000000018D554164-0x000000018D554194
		[ExcludeFromDocs]
		public RaycastHit[] SweepTestAll(Vector3 direction); // 0x000000018D55425C-0x000000018D554294
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Rigidbody.maxAngularVelocity instead.")]
		public void SetMaxAngularVelocity(float a); // 0x000000018D554128-0x000000018D554130
		private void get_velocity_Injected(out Vector3 ret); // 0x0000000185776090-0x00000001857760E0
		private void set_velocity_Injected(ref Vector3 value); // 0x000000018D554E88-0x000000018D554ECC
		private void get_angularVelocity_Injected(out Vector3 ret); // 0x0000000185773C30-0x0000000185773C80
		private void set_angularVelocity_Injected(ref Vector3 value); // 0x000000018D554A28-0x000000018D554A6C
		private void get_centerOfMass_Injected(out Vector3 ret); // 0x00000001866CDEA0-0x00000001866CDEF0
		private void set_centerOfMass_Injected(ref Vector3 value); // 0x000000018D554A80-0x000000018D554AC4
		private void get_worldCenterOfMass_Injected(out Vector3 ret); // 0x000000018D5549B8-0x000000018D5549FC
		private void get_inertiaTensorRotation_Injected(out Quaternion ret); // 0x000000018D55460C-0x000000018D554650
		private void set_inertiaTensorRotation_Injected(ref Quaternion value); // 0x000000018D554BA0-0x000000018D554BE4
		private void get_inertiaTensor_Injected(out Vector3 ret); // 0x000000018D55467C-0x000000018D5546C0
		private void set_inertiaTensor_Injected(ref Vector3 value); // 0x000000018D554BF8-0x000000018D554C3C
		private void get_position_Injected(out Vector3 ret); // 0x000000018D5547F0-0x000000018D554834
		private void set_position_Injected(ref Vector3 value); // 0x0000000186289D40-0x0000000186289D90
		private void get_rotation_Injected(out Quaternion ret); // 0x000000018D554860-0x000000018D5548A4
		private void set_rotation_Injected(ref Quaternion value); // 0x000000018D554D18-0x000000018D554D5C
		private void MovePosition_Injected(ref Vector3 position); // 0x000000018D553FCC-0x000000018D554010
		private void MoveRotation_Injected(ref Quaternion rot); // 0x000000018D554024-0x000000018D554068
		private void GetRelativePointVelocity_Injected(ref Vector3 relativePoint, out Vector3 ret); // 0x000000018D553E4C-0x000000018D553EA0
		private void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret); // 0x000000018D553DC4-0x000000018D553E18
		private void AddForce_Injected(ref Vector3 force, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] ForceMode mode); // 0x0000000186EBF1B0-0x0000000186EBF210
		private void AddRelativeForce_Injected(ref Vector3 force, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] ForceMode mode); // 0x000000018D553A90-0x000000018D553AE4
		private void AddTorque_Injected(ref Vector3 torque, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] ForceMode mode); // 0x000000018D553C54-0x000000018D553CA8
		private void AddRelativeTorque_Injected(ref Vector3 torque, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] ForceMode mode); // 0x000000018D553B78-0x000000018D553BCC
		private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, [UnityEngine.Internal.DefaultValue("ForceMode.Force")] ForceMode mode); // 0x000000018D553978-0x000000018D5539DC
		private void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, [UnityEngine.Internal.DefaultValue("0.0f")] float upwardsModifier, [UnityEngine.Internal.DefaultValue("ForceMode.Force)")] ForceMode mode); // 0x000000018D55386C-0x000000018D5538D0
		private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance); // 0x000000018D553ED4-0x000000018D553F38
		private void SweepTest_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit, out RaycastHit ret); // 0x000000018D554294-0x000000018D5542F8
		private RaycastHit[] Internal_SweepTestAll_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D553F50-0x000000018D553FB4
	}

	public enum ECSColliderType // TypeDefIndex: 88663
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
	public class Collider : Component // TypeDefIndex: 88664
	{
		// Properties
		public bool enabled { get; set; } // 0x00000001855564C0-0x0000000185556500 0x0000000185285DE0-0x0000000185285E30
		public Rigidbody attachedRigidbody { [NativeMethod("GetRigidbody")] get; } // 0x00000001871EC1A0-0x00000001871EC1E0 
		public ArticulationBody attachedArticulationBody { [NativeMethod("GetArticulationBody")] get; } // 0x000000018D54A504-0x000000018D54A538 
		public bool isTrigger { get; set; } // 0x0000000185616150-0x0000000185616190 0x00000001855551B0-0x0000000185555200
		public bool enableDither { get; } // 0x000000018D54A56C-0x000000018D54A5A0 
		public float contactOffset { get; set; } // 0x000000018D54A538-0x000000018D54A56C 0x000000018D54A6A4-0x000000018D54A6E8
		public Bounds bounds { get; } // 0x0000000184FBD400-0x0000000184FBD460 
		public bool hasModifiableContacts { get; set; } // 0x000000018D54A5A0-0x000000018D54A5D4 0x000000018D54A6E8-0x000000018D54A72C
		public ColliderSurfaceType surfaceType { get; set; } // 0x000000018D54A63C-0x000000018D54A670 0x000000018D54A770-0x000000018D54A7B0
		public int tagConfig { get; set; } // 0x000000018D54A670-0x000000018D54A6A4 0x000000018D54A7B0-0x000000018D54A7F0
		public int colliderOptions { get; set; } // 0x0000000185AD3200-0x0000000185AD3240 0x0000000185AD2580-0x0000000185AD25D0
		[NativeMethod("Material")]
		public PhysicMaterial sharedMaterial { get; set; } // 0x000000018D54A608-0x000000018D54A63C 0x000000018D54A72C-0x000000018D54A770
		public PhysicMaterial material { [NativeMethod("GetClonedMaterial")] get; [NativeMethod("SetMaterial")] set; } // 0x000000018D54A5D4-0x000000018D54A608 0x0000000185556A60-0x0000000185556AB0
	
		// Constructors
		public Collider(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public Vector3 ClosestPoint(Vector3 position); // 0x00000001855343A0-0x0000000185534410
		[NativeName("GetActor")]
		public IntPtr GetActor(); // 0x00000001855562E0-0x0000000185556320
		[NativeName("GetComponentIndex")]
		public int GetComponentIndex(); // 0x0000000186049D70-0x0000000186049DB0
		[NativeName("GetFactoryBuildingIdentifier")]
		public int GetFactoryBuildingIdentifier(); // 0x000000018D54A1D8-0x000000018D54A20C
		[NativeName("SetFactoryBuildingIdentifier")]
		public void SetFactoryBuildingIdentifier(int value); // 0x000000018D54A3C4-0x000000018D54A404
		private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit); // 0x000000018D54A2EC-0x000000018D54A350
		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance); // 0x000000018D54A350-0x000000018D54A3C4
		[NativeName("ClosestPointOnBounds")]
		private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance); // 0x000000018D54A270-0x000000018D54A288
		public Vector3 ClosestPointOnBounds(Vector3 position); // 0x000000018D54A150-0x000000018D54A1D8
		public bool CanColliderComputeClosestPoint(); // 0x000000018D54A11C-0x000000018D54A150
		[NativeName("TryGetClosestPoint")]
		private Vector3 TryGetClosestPoint_Internal(int componentIndex, Vector3 point, ref bool resultIsValid); // 0x000000018D54A464-0x000000018D54A4A4
		public bool TryGetClosestPoint(int componentIndex, Vector3 point, out Vector3 result); // 0x000000018D54A4A4-0x000000018D54A504
		private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret); // 0x0000000185534410-0x0000000185534470
		private void get_bounds_Injected(out Bounds ret); // 0x0000000184FBD460-0x0000000184FBD4B0
		private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret); // 0x000000018D54A288-0x000000018D54A2EC
		private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance); // 0x000000018D54A20C-0x000000018D54A270
		private void TryGetClosestPoint_Internal_Injected(int componentIndex, ref Vector3 point, ref bool resultIsValid, out Vector3 ret); // 0x000000018D54A404-0x000000018D54A464
	}

	[NativeHeader("Modules/Physics/ECSCollider.h")]
	[RequiredByNativeCode]
	public class ECSCollider // TypeDefIndex: 88666
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
		public delegate void CollisionCallback(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // TypeDefIndex: 88665; 0x00000001812B1B20-0x00000001812B1B70
	
		// Methods
		public static IntPtr CreateActor(Vector3 position, Quaternion rotation, uint layer, int tagInt, bool movable); // 0x0000000187837710-0x0000000187837730
		[NativeName("DestroyActor")]
		public static void DestroyActor(int id, uint version); // 0x0000000186B6D770-0x0000000186B6D7C0
		[NativeName("Decode")]
		public static IntPtr Decode(IntPtr data, int length, IntPtr meshes, int meshesCount, Texture2D heightmaps); // 0x0000000185737620-0x0000000185737690
		public static IntPtr Decode(IntPtr data, int length, NativeArray<int> meshInstanceIds, Texture2D heightmap); // 0x0000000185737590-0x0000000185737620
		[NativeName("RecordEntity")]
		public static void RecordEntity(IntPtr actor, Entity entity); // 0x000000018D54B2F4-0x000000018D54B310
		[NativeName("GetId")]
		public static int GetId(IntPtr actor); // 0x0000000185737690-0x00000001857376D0
		[NativeName("GetVersion")]
		public static uint GetVersion(IntPtr actor); // 0x00000001857376D0-0x0000000185737710
		[NativeName("IsValid")]
		public static bool IsValid(int id, uint version, IntPtr actor); // 0x000000018517AA10-0x000000018517AA70
		[NativeName("GetEntity")]
		public static Entity GetEntity(int id, uint version); // 0x000000018D54B040-0x000000018D54B064
		[NativeName("GetPosition")]
		[ThreadSafe]
		public static Vector3 GetPosition(int ecsId, uint ecsVersion); // 0x0000000185535BB0-0x0000000185535BE0
		[NativeName("GetShapePosition")]
		[ThreadSafe]
		public static Vector3 GetShapePosition(int ecsId, uint ecsVersion, int index); // 0x0000000186409890-0x00000001864098D0
		[NativeName("SetPosition")]
		public static void SetPosition(int ecsId, uint ecsVersion, Vector3 position); // 0x0000000187838C7C-0x0000000187838C90
		[NativeName("GetShapeRotation")]
		[ThreadSafe]
		public static Quaternion GetShapeRotation(int ecsId, uint ecsVersion, int index); // 0x000000018D54B0C4-0x000000018D54B100
		[NativeName("GetRotation")]
		[ThreadSafe]
		public static Quaternion GetRotation(int ecsId, uint ecsVersion); // 0x00000001855569D0-0x0000000185556A00
		[NativeName("SetRotation")]
		public static void SetRotation(int ecsId, uint ecsVersion, Quaternion rotation); // 0x0000000187838C90-0x0000000187838CA4
		[NativeName("AttachBox")]
		public static void AttachBox(int id, uint version, Vector3 halfExtent, Vector3 localPosition, Quaternion localRotation, int surfaceType, int colliderOption, int tag, bool isTrigger, bool isPrimitive); // 0x0000000187837730-0x0000000187837790
		[NativeName("HasComplexMesh")]
		public static bool HasComplexMesh(int id, uint version); // 0x000000018517B390-0x000000018517B3E0
		[NativeName("Raycast")]
		private static RaycastHit Raycast_Internal(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, ref bool hasHit); // 0x000000018D54B1F0-0x000000018D54B268
		public static bool Raycast(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, out RaycastHit hitInfo); // 0x000000018D54B268-0x000000018D54B2F4
		[NativeName("RaycastComplexMesh")]
		private static RaycastHit RaycastComplexMesh_Internal(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, ref bool hasHit); // 0x0000000186A6BF00-0x0000000186A6BF70
		public static bool RaycastComplexMesh(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, out RaycastHit hitInfo); // 0x0000000186A6BE00-0x0000000186A6BF00
		[NativeName("CapsuleCastComplexMesh")]
		private static RaycastHit CapsuleCastComplexMesh_Internal(int ecsId, uint ecsVersion, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, ref bool hasHit); // 0x0000000185D65E80-0x0000000185D65F10
		public static bool CapsuleCastComplexMesh(int ecsId, uint ecsVersion, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, out RaycastHit hitInfo); // 0x0000000185D65D30-0x0000000185D65E80
		[NativeName("SphereCastComplexMesh")]
		private static RaycastHit SphereCastComplexMesh_Internal(int ecsId, uint ecsVersion, Vector3 center, float radius, Vector3 direction, float maxDistance, ref bool hasHit); // 0x000000018D54B370-0x000000018D54B400
		public static bool SphereCastComplexMesh(int ecsId, uint ecsVersion, Vector3 center, float radius, Vector3 direction, float maxDistance, out RaycastHit hitInfo); // 0x000000018D54B400-0x000000018D54B4B0
		[NativeName("GetSurfaceAt")]
		public static ColliderSurfaceType GetSurfaceTypeAt(int ecsId, uint ecsVersion, int index); // 0x00000001864A7580-0x00000001864A75E0
		[NativeName("GetColliderOptionAt")]
		public static int GetColliderOptionAt(int ecsId, uint ecsVersion, int index); // 0x000000018517AC70-0x000000018517ACD0
		[NativeName("GetTagConfigAt")]
		public static int GetTagConfigAt(int ecsId, uint ecsVersion, int index); // 0x0000000185779890-0x00000001857798F0
		[NativeName("GetIsTrigger")]
		public static bool GetIsTrigger(int ecsId, uint ecsVersion, int index); // 0x0000000186451C30-0x0000000186451C90
		public static Bounds GetBounds(int ecsId, uint ecsVersion); // 0x000000018643DB90-0x000000018643DBD0
		[NativeName("TryGetClosestPoint")]
		private static Vector3 TryGetClosestPoint_Internal(int ecsId, uint ecsVersion, int componentIndex, Vector3 point, ref bool resultIsValid); // 0x000000018552F3B0-0x000000018552F410
		public static bool TryGetClosestPoint(int ecsId, uint ecsVersion, int componentIndex, Vector3 point, out Vector3 result); // 0x000000018552F2F0-0x000000018552F3B0
		public static Vector3 ClosestPoint(int ecsId, uint ecsVersion, Vector3 position); // 0x000000018D54AFB4-0x000000018D54AFF0
		[NativeName("CompareTag")]
		public static bool CompareTag(int ecsId, uint ecsVersion, int tagValue); // 0x000000018661E870-0x000000018661E8D0
		[NativeName("GetLayer")]
		public static int GetLayer(int ecsId, uint ecsVersion); // 0x000000018517D3F0-0x000000018517D440
		[NativeName("GetFactoryBuildingIdentifier")]
		public static int GetFactoryBuildingIdentifier(int ecsId, uint ecsVersion); // 0x00000001862601B0-0x0000000186260200
		[NativeName("SetFactoryBuildingIdentifier")]
		public static void SetFactoryBuildingIdentifier(int ecsId, uint ecsVersion, int identifier); // 0x00000001864EE600-0x00000001864EE660
		[RequiredByNativeCode]
		private static void OnCollisionEnterV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // 0x0000000186604460-0x00000001866044C0
		[RequiredByNativeCode]
		private static void OnCollisionStayV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // 0x0000000186778C20-0x0000000186778C80
		[RequiredByNativeCode]
		private static void OnCollisionExitV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // 0x00000001866044C0-0x0000000186604520
		[RequiredByNativeCode]
		private static void OnTriggerEnterV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // 0x0000000186B214E0-0x0000000186B21510
		[RequiredByNativeCode]
		private static void OnTriggerStayV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // 0x000000018D54B100-0x000000018D54B190
		[RequiredByNativeCode]
		private static void OnTriggerExitV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // 0x0000000186C0EDB0-0x0000000186C0EDE0
		public static void ToggleCollision(int id, uint version, bool enableCollision); // 0x00000001863636E0-0x0000000186363740
		private static IntPtr CreateActor_Injected(ref Vector3 position, ref Quaternion rotation, uint layer, int tagInt, bool movable); // 0x0000000186BF91C0-0x0000000186BF9240
		private static void RecordEntity_Injected(IntPtr actor, ref Entity entity); // 0x0000000186557A80-0x0000000186557AD0
		private static void GetEntity_Injected(int id, uint version, out Entity ret); // 0x000000018D54AFF0-0x000000018D54B040
		private static void GetPosition_Injected(int ecsId, uint ecsVersion, out Vector3 ret); // 0x0000000185535BE0-0x0000000185535C40
		private static void GetShapePosition_Injected(int ecsId, uint ecsVersion, int index, out Vector3 ret); // 0x00000001864098D0-0x0000000186409940
		private static void SetPosition_Injected(int ecsId, uint ecsVersion, ref Vector3 position); // 0x0000000186436A70-0x0000000186436AD0
		private static void GetShapeRotation_Injected(int ecsId, uint ecsVersion, int index, out Quaternion ret); // 0x000000018D54B064-0x000000018D54B0C4
		private static void GetRotation_Injected(int ecsId, uint ecsVersion, out Quaternion ret); // 0x0000000185556A00-0x0000000185556A60
		private static void SetRotation_Injected(int ecsId, uint ecsVersion, ref Quaternion rotation); // 0x0000000186436A10-0x0000000186436A70
		private static void AttachBox_Injected(int id, uint version, ref Vector3 halfExtent, ref Vector3 localPosition, ref Quaternion localRotation, int surfaceType, int colliderOption, int tag, bool isTrigger, bool isPrimitive); // 0x0000000186B17A00-0x0000000186B17A90
		private static void Raycast_Internal_Injected(int ecsId, uint ecsVersion, ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret); // 0x000000018D54B190-0x000000018D54B1F0
		private static void RaycastComplexMesh_Internal_Injected(int ecsId, uint ecsVersion, ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret); // 0x0000000186A6BF70-0x0000000186A6BFF0
		private static void CapsuleCastComplexMesh_Internal_Injected(int ecsId, uint ecsVersion, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret); // 0x0000000185D65F10-0x0000000185D65FD0
		private static void SphereCastComplexMesh_Internal_Injected(int ecsId, uint ecsVersion, ref Vector3 center, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret); // 0x000000018D54B310-0x000000018D54B370
		private static void GetBounds_Injected(int ecsId, uint ecsVersion, out Bounds ret); // 0x000000018643DBD0-0x000000018643DC30
		private static void TryGetClosestPoint_Internal_Injected(int ecsId, uint ecsVersion, int componentIndex, ref Vector3 point, ref bool resultIsValid, out Vector3 ret); // 0x000000018552F410-0x000000018552F480
		private static void ClosestPoint_Injected(int ecsId, uint ecsVersion, ref Vector3 position, out Vector3 ret); // 0x000000018D54AF54-0x000000018D54AFB4
	}

	[NativeHeader("Modules/Physics/CharacterController.h")]
	public class CharacterController : Collider // TypeDefIndex: 88667
	{
		// Properties
		public bool isGrounded { [NativeName("IsGrounded")] get; } // 0x000000018D54A0E8-0x000000018D54A11C 
	}

	[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
	[NativeHeader("Modules/Physics/MultiCollider.h")]
	[RequiredByNativeCode]
	public class MultiCollider : Collider // TypeDefIndex: 88668
	{
		// Properties
		public Mesh ComplexMesh { get; } // 0x00000001869D9880-0x00000001869D98C0 
	
		// Methods
		[NativeName("AppendBoxCollider")]
		public void AppendBoxCollider(BoxCollider boxCollider); // 0x000000018D54B690-0x000000018D54B6D4
		[NativeName("AppendCapsuleCollider")]
		public void AppendCapsuleCollider(CapsuleCollider collider); // 0x000000018D54B6D4-0x000000018D54B718
		[NativeName("AppendSphereCollider")]
		public void AppendSphereCollider(SphereCollider collider); // 0x000000018D54B718-0x000000018D54B75C
		[NativeName("GetSurfaceTypeAt")]
		public ColliderSurfaceType GetSurfaceTypeAt(int index); // 0x000000018709C790-0x000000018709C7E0
		[NativeName("GetTagConfigAt")]
		public int GetTagConfigAt(int index); // 0x0000000186E5C380-0x0000000186E5C3D0
		[NativeName("GetGameplayOptionAt")]
		public int GetGameplayOptionAt(int index); // 0x00000001865367A0-0x00000001865367F0
		[NativeName("GetIsTriggerAt")]
		public bool GetIsTriggerAt(int index); // 0x0000000186DD8970-0x0000000186DD89C0
		[NativeName("SetGameplayOptionAt")]
		public void SetGameplayOptionAt(int index, int value); // 0x000000018D54B9EC-0x000000018D54BA3C
		[NativeName("Flush")]
		public void Flush(); // 0x000000018D54B908-0x000000018D54B93C
		[NativeName("RaycastComplexMesh")]
		public bool RaycastComplexMesh(Ray ray, float maxDistance, ref RaycastHit hit); // 0x000000018D54B9D4-0x000000018D54B9EC
		[NativeName("CapsuleCastComplexMesh")]
		private RaycastHit CapsuleCastComplexMesh_Internal(Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, ref bool hasHit); // 0x000000018D54B7C0-0x000000018D54B854
		public bool CapsuleCastComplexMesh(Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, out RaycastHit hit); // 0x000000018D54B854-0x000000018D54B908
		[NativeName("SphereCastComplexMesh")]
		private RaycastHit SphereCastComplexMesh_Internal(Vector3 center, float radius, Vector3 direction, float maxDistance, ref bool hasHit); // 0x000000018D54BAA0-0x000000018D54BB24
		public bool SphereCastComplexMesh(Vector3 center, float radius, Vector3 direction, float maxDistance, out RaycastHit hit); // 0x000000018D54BB24-0x000000018D54BBC8
		[NativeName("GetShapesCount")]
		public int GetCountWithoutComplexMesh(); // 0x000000018D54B93C-0x000000018D54B970
		private bool RaycastComplexMesh_Injected(ref Ray ray, float maxDistance, ref RaycastHit hit); // 0x000000018D54B970-0x000000018D54B9D4
		private void CapsuleCastComplexMesh_Internal_Injected(ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret); // 0x000000018D54B75C-0x000000018D54B7C0
		private void SphereCastComplexMesh_Internal_Injected(ref Vector3 center, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret); // 0x000000018D54BA3C-0x000000018D54BAA0
	}

	[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
	[NativeHeader("Modules/Physics/MeshCollider.h")]
	[RequiredByNativeCode]
	public class MeshCollider : Collider // TypeDefIndex: 88669
	{
		// Properties
		public Mesh sharedMesh { get; set; } // 0x000000018D54B5D8-0x000000018D54B60C 0x00000001852B9BA0-0x00000001852B9BF0
		public bool convex { get; set; } // 0x000000018D54B570-0x000000018D54B5A4 0x000000018D54B60C-0x000000018D54B650
		public MeshColliderCookingOptions cookingOptions { get; set; } // 0x000000018D54B5A4-0x000000018D54B5D8 0x000000018D54B650-0x000000018D54B690
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Configuring smooth sphere collisions is no longer needed.", true)]
		public bool smoothSphereCollisions { get; set; } // 0x0000000187249050-0x0000000187249060 0x0000000186805BA0-0x0000000186805BB0
		[Obsolete("MeshCollider.skinWidth is no longer used.")]
		public float skinWidth { get; set; } // 0x0000000187260470-0x0000000187260480 0x0000000186805BA0-0x0000000186805BB0
		[Obsolete("MeshCollider.inflateMesh is no longer supported. The new cooking algorithm doesn\'t need inflation to be used.")]
		public bool inflateMesh { get; set; } // 0x0000000187232850-0x0000000187232860 0x0000000186805BA0-0x0000000186805BB0
	
		// Constructors
		public MeshCollider(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		[NativeName("NeedsReadWriteEnabled")]
		public bool NeedsReadWriteEnabled(); // 0x000000018D54B53C-0x000000018D54B570
	}

	[NativeHeader("Modules/Physics/CapsuleCollider.h")]
	[RequiredByNativeCode]
	public class CapsuleCollider : Collider // TypeDefIndex: 88670
	{
		// Properties
		public Vector3 center { get; set; } // 0x000000018522CD30-0x000000018522CD90 0x00000001878368E4-0x00000001878368F8
		public float radius { get; set; } // 0x000000018522CCB0-0x000000018522CCF0 0x00000001855560B0-0x0000000185556100
		public float height { get; set; } // 0x000000018522CCF0-0x000000018522CD30 0x0000000185556060-0x00000001855560B0
		public int direction { get; set; } // 0x000000018522CC70-0x000000018522CCB0 0x0000000185555350-0x00000001855553A0
	
		// Methods
		private void get_center_Injected(out Vector3 ret); // 0x000000018522CD90-0x000000018522CDE0
		private void set_center_Injected(ref Vector3 value); // 0x000000018680BBE0-0x000000018680BC30
	}

	[NativeHeader("Modules/Physics/BoxCollider.h")]
	[RequiredByNativeCode]
	public class BoxCollider : Collider // TypeDefIndex: 88671
	{
		// Properties
		public Vector3 center { get; set; } // 0x000000018D549D6C-0x000000018D549D98 0x00000001878396F8-0x000000018783970C
		public Vector3 size { get; set; } // 0x0000000185AD3180-0x0000000185AD31B0 0x00000001878396E4-0x00000001878396F8
	
		// Methods
		private void get_center_Injected(out Vector3 ret); // 0x000000018D549D28-0x000000018D549D6C
		private void set_center_Injected(ref Vector3 value); // 0x0000000186DFC780-0x0000000186DFC7D0
		private void get_size_Injected(out Vector3 ret); // 0x0000000185AD31B0-0x0000000185AD3200
		private void set_size_Injected(ref Vector3 value); // 0x0000000186DFC730-0x0000000186DFC780
	}

	[NativeHeader("Modules/Physics/SphereCollider.h")]
	[RequiredByNativeCode]
	public class SphereCollider : Collider // TypeDefIndex: 88672
	{
		// Properties
		public Vector3 center { get; set; } // 0x000000018D554F24-0x000000018D554F50 0x000000018D554FC8-0x000000018D554FDC
		public float radius { get; set; } // 0x000000018D554F50-0x000000018D554F84 0x0000000185AD2530-0x0000000185AD2580
	
		// Methods
		private void get_center_Injected(out Vector3 ret); // 0x000000018D554EE0-0x000000018D554F24
		private void set_center_Injected(ref Vector3 value); // 0x000000018D554F84-0x000000018D554FC8
	}

	[NativeClass("Unity::Joint")]
	[NativeHeader("Modules/Physics/Joint.h")]
	[RequireComponent(typeof(Rigidbody))]
	public class Joint : Component // TypeDefIndex: 88673
	{
		// Properties
		public Rigidbody connectedBody { get; } // 0x000000018D54B4B0-0x000000018D54B4E4 
		public Vector3 connectedAnchor { set; } // 0x000000018D54B528-0x000000018D54B53C
	
		// Methods
		private void set_connectedAnchor_Injected(ref Vector3 value); // 0x000000018D54B4E4-0x000000018D54B528
	}

	[NativeHeader("Modules/Physics/MessageParameters.h")]
	[UsedByNativeCode]
	public struct ContactPoint // TypeDefIndex: 88674
	{
		// Fields
		internal Vector3 m_Point; // 0x00
		internal Vector3 m_Normal; // 0x0C
		internal int m_ThisColliderInstanceID; // 0x18
		internal int m_OtherColliderInstanceID; // 0x1C
		internal float m_Separation; // 0x20
	
		// Properties
		public Vector3 point { get; } // 0x000000018725FDC0-0x000000018725FDE0 
		public Vector3 normal { get; } // 0x000000018725FDA0-0x000000018725FDC0 
		public Collider thisCollider { get; } // 0x000000018D54A9BC-0x000000018D54A9C8 
		public Collider otherCollider { get; } // 0x000000018D54A9B0-0x000000018D54A9BC 
	
		// Methods
		[FreeFunction]
		private static Collider GetColliderByInstanceID(int instanceID); // 0x000000018D54A97C-0x000000018D54A9B0
	}

	[NativeHeader("Modules/Physics/Public/PhysicsSceneHandle.h")]
	public struct PhysicsScene : IEquatable<UnityEngine.PhysicsScene> // TypeDefIndex: 88675
	{
		// Fields
		private int m_Handle; // 0x00
	
		// Methods
		public override string ToString(); // 0x000000018D54C598-0x000000018D54C648
		public override int GetHashCode(); // 0x000000018725FD00-0x000000018725FD10
		public override bool Equals(object other); // 0x000000018D54BE04-0x000000018D54BE68
		public bool Equals(PhysicsScene other); // 0x0000000184FF20D0-0x0000000184FF20E0
		public bool Raycast(Vector3 origin, Vector3 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x02648671 */, [UnityEngine.Internal.DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x02648675 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x02648676 */); // 0x0000000185131F70-0x00000001851320D0
		[NativeName("RaycastTest")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000187834CD8-0x0000000187834D00
		public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x02648677 */, [UnityEngine.Internal.DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0264867B */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0264867C */); // 0x000000018517B750-0x000000018517B9A0
		[NativeName("Raycast")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000187834E7C-0x0000000187834EAC
		public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x0264867D */, [UnityEngine.Internal.DefaultValue("Physics.DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x02648681 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x02648682 */); // 0x0000000185179630-0x0000000185179930
		[NativeName("RaycastNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, [Unmarshalled] RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000187834E10-0x0000000187834E40
		[NativeName("CapsuleCast")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018783CD0C-0x000000018783CD6C
		private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x00000001869B5660-0x00000001869B57D0
		public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x02648683 */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x02648687 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x02648688 */); // 0x00000001869B55B0-0x00000001869B5660
		[NativeName("CapsuleCastNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int Internal_CapsuleCastNonAlloc(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, [Unmarshalled] RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000187836A1C-0x0000000187836A7C
		public int CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x02648689 */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0264868D */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0264868E */); // 0x00000001855928D0-0x0000000185592A70
		[NativeName("CapsuleCastNonAllocV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int Internal_CapsuleCastNonAllocV2(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 diretion, [Unmarshalled] ECSColliderResultProxy[] proxies, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54BFF4-0x000000018D54C054
		public int CapsuleCastV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] proxies, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x0264868F */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x02648693 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x02648694 */); // 0x000000018D54BD10-0x000000018D54BE04
		[NativeName("OverlapCapsuleNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, [Unmarshalled] Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54C254-0x000000018D54C294
		public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask = -1 /* Metadata: 0x02648695 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x02648696 */); // 0x000000018D54C294-0x000000018D54C37C
		[NativeName("OverlapCapsuleNonAllocV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapCapsuleNonAlloc_InternalV2(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, [Unmarshalled] ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000187836A7C-0x0000000187836ABC
		public int OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius, [Unmarshalled] ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask = -1 /* Metadata: 0x02648697 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x02648698 */); // 0x0000000185597640-0x00000001855976F0
		[NativeName("SphereCast")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x00000001878367D0-0x0000000187836824
		private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018551DBC0-0x000000018551DD80
		public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x02648699 */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0264869D */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0264869E */); // 0x000000018551DA20-0x000000018551DBC0
		[NativeName("SphereCastNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, [Unmarshalled] RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000187836F24-0x0000000187836F78
		public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x0264869F */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x026486A3 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x026486A4 */); // 0x00000001856157D0-0x0000000185615950
		[NativeName("OverlapSphereNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, [Unmarshalled] Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54C3E0-0x000000018D54C410
		public int OverlapSphere(Vector3 position, float radius, Collider[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54C410-0x000000018D54C4D4
		[NativeName("OverlapSphereNonAllocV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapSphereNonAllocV2_Internal(PhysicsScene physicsScene, Vector3 position, float radius, [Unmarshalled] ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000187836864-0x0000000187836894
		public int OverlapSphereV2(Vector3 position, float radius, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("AllLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction); // 0x00000001855371D0-0x0000000185537260
		[NativeName("BoxCast")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType.Dot)]
		private static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54C538-0x000000018D54C598
		private static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54BE68-0x000000018D54BF90
		public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x026486A5 */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x026486A9 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x026486AA */); // 0x000000018D54BC60-0x000000018D54BD10
		[NativeName("OverlapBoxNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, [Unmarshalled] Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54C0B8-0x000000018D54C0F8
		public int OverlapBox(Vector3 center, Vector3 halfExtents, Collider[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x026486AB */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x026486AC */); // 0x000000018D54C0F8-0x000000018D54C1F0
		[NativeName("OverlapBoxNonAllocV2")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int OverlapBoxNonAllocV2_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, [Unmarshalled] ECSColliderResultProxy[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000187836824-0x0000000187836864
		public int OverlapBoxV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x026486AD */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x026486AE */); // 0x000000018552F180-0x000000018552F230
		[NativeName("BoxCastNonAlloc")]
		[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
		private static int Internal_BoxCastNonAlloc(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, [Unmarshalled] RaycastHit[] raycastHits, Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000187837D24-0x0000000187837D84
		public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, [UnityEngine.Internal.DefaultValue("Quaternion.identity")] Quaternion orientation, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDistance = 1F / 0F /* Metadata: 0x026486AF */, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x026486B3 */, [UnityEngine.Internal.DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x026486B4 */); // 0x000000018586E6F0-0x000000018586E830
		private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000186740360-0x00000001867403D0
		private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185E0E000-0x0000000185E0E070
		private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185D6BDE0-0x0000000185D6BE50
		private static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x00000001869B57D0-0x00000001869B5840
		private static int Internal_CapsuleCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018604AB40-0x000000018604ABB0
		private static int Internal_CapsuleCastNonAllocV2_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 diretion, ECSColliderResultProxy[] proxies, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54BF90-0x000000018D54BFF4
		private static int OverlapCapsuleNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54C1F0-0x000000018D54C254
		private static int OverlapCapsuleNonAlloc_InternalV2_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185FC5280-0x0000000185FC52F0
		private static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x00000001860CBC50-0x00000001860CBD50
		private static int Internal_SphereCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000185F2B7A0-0x0000000185F2B810
		private static int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54C37C-0x000000018D54C3E0
		private static int OverlapSphereNonAllocV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000186566760-0x00000001865667D0
		private static bool Query_BoxCast_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54C4D4-0x000000018D54C538
		private static int OverlapBoxNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, Collider[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x000000018D54C054-0x000000018D54C0B8
		private static int OverlapBoxNonAllocV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ECSColliderResultProxy[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x00000001867E4780-0x00000001867E47F0
		private static int Internal_BoxCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, RaycastHit[] raycastHits, ref Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction); // 0x0000000186289FD0-0x000000018628A040
	}

	public struct QueryParameters // TypeDefIndex: 88676
	{
		// Fields
		public int layerMask; // 0x00
		public bool hitMultipleFaces; // 0x04
		public bool hitBackfaces; // 0x05
		public QueryTriggerInteraction hitTriggers; // 0x08
	
		// Constructors
		public QueryParameters(int layerMask = -5 /* Metadata: 0x026486B5 */, bool hitMultipleFaces = false /* Metadata: 0x026486B6 */, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal /* Metadata: 0x026486B7 */, bool hitBackfaces = false /* Metadata: 0x026486B8 */); // 0x0000000187262160-0x0000000187262180
	}

	[NativeHeader("Modules/Physics/BatchCommands/RaycastCommand.h")]
	[NativeHeader("Runtime/Jobs/ScriptBindings/JobsBindingsTypes.h")]
	public struct RaycastCommand // TypeDefIndex: 88677
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
		public Vector3 from { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x000000018723AE60-0x000000018723AE80 0x000000018723AEB0-0x000000018723AEC0
		public Vector3 direction { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723AE80-0x000000018723AEA0 0x000000018723AEC0-0x000000018723AED0
		public float distance { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233050-0x0000000187233060 0x0000000187233060-0x0000000187233070
		public PhysicsScene physicsScene { [CompilerGenerated] set; } // 0x0000000187233010-0x0000000187233020
	
		// Constructors
		public RaycastCommand(Vector3 from, Vector3 direction, QueryParameters queryParameters, float distance = 3.4028235E+38f /* Metadata: 0x026486B9 */); // 0x00000001859A2890-0x00000001859A28F0
	
		// Methods
		public static JobHandle ScheduleBatch(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, int maxHits, JobHandle dependsOn = default); // 0x00000001859A14A0-0x00000001859A15E0
		public static JobHandle ScheduleBatch(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn = default); // 0x00000001859A1680-0x00000001859A1700
		[FreeFunction("ScheduleRaycastCommandBatch", ThrowsException = true)]
		private static unsafe JobHandle ScheduleRaycastBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits); // 0x00000001859A15E0-0x00000001859A1680
		private static unsafe void ScheduleRaycastBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out JobHandle ret); // 0x00000001859A1430-0x00000001859A14A0
	}

	[NativeHeader("Runtime/Jobs/ScriptBindings/JobsBindingsTypes.h")]
	[NativeHeader("Modules/Physics/BatchCommands/SpherecastCommand.h")]
	public struct SpherecastCommand // TypeDefIndex: 88678
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
		public Vector3 origin { [CompilerGenerated] set; } // 0x000000018723AEB0-0x000000018723AEC0
		public float radius { [CompilerGenerated] set; } // 0x000000018725AC70-0x000000018725AC80
		public Vector3 direction { [CompilerGenerated] set; } // 0x0000000187239670-0x0000000187239680
		public float distance { [CompilerGenerated] set; } // 0x0000000187233420-0x0000000187233430
		public PhysicsScene physicsScene { [CompilerGenerated] set; } // 0x0000000186036460-0x0000000186036470
	
		// Constructors
		public SpherecastCommand(Vector3 origin, float radius, Vector3 direction, QueryParameters queryParameters, float distance = 3.4028235E+38f /* Metadata: 0x026486BD */); // 0x000000018D5552B8-0x000000018D555314
	
		// Methods
		public static JobHandle ScheduleBatch(NativeArray<SpherecastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, int maxHits, JobHandle dependsOn = default); // 0x000000018D555050-0x000000018D5551E4
		public static JobHandle ScheduleBatch(NativeArray<SpherecastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn = default); // 0x000000018D554FDC-0x000000018D555050
		[FreeFunction("ScheduleSpherecastCommandBatch", ThrowsException = true)]
		private static unsafe JobHandle ScheduleSpherecastBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits); // 0x000000018D555248-0x000000018D5552B8
		private static unsafe void ScheduleSpherecastBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out JobHandle ret); // 0x000000018D5551E4-0x000000018D555248
	}

	[NativeHeader("Runtime/Jobs/ScriptBindings/JobsBindingsTypes.h")]
	[NativeHeader("Modules/Physics/BatchCommands/BoxcastCommand.h")]
	public struct BoxcastCommand // TypeDefIndex: 88679
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
		public Vector3 center { [CompilerGenerated] set; } // 0x000000018723AEB0-0x000000018723AEC0
		public Vector3 halfExtents { [CompilerGenerated] set; } // 0x000000018723AEC0-0x000000018723AED0
		public Quaternion orientation { [CompilerGenerated] set; } // 0x0000000187235FF0-0x0000000187236000
		public Vector3 direction { [CompilerGenerated] set; } // 0x000000018723EAF0-0x000000018723EB00
		public float distance { [CompilerGenerated] set; } // 0x0000000187233AF0-0x0000000187233B00
		public PhysicsScene physicsScene { [CompilerGenerated] set; } // 0x0000000185E3C070-0x0000000185E3C080
	
		// Constructors
		public BoxcastCommand(Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, QueryParameters queryParameters, float distance = 3.4028235E+38f /* Metadata: 0x026486C1 */); // 0x000000018D54A074-0x000000018D54A0E8
	
		// Methods
		public static JobHandle ScheduleBatch(NativeArray<BoxcastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, int maxHits, JobHandle dependsOn = default); // 0x000000018D549E0C-0x000000018D549FA0
		public static JobHandle ScheduleBatch(NativeArray<BoxcastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn = default); // 0x000000018D549D98-0x000000018D549E0C
		[FreeFunction("ScheduleBoxcastCommandBatch", ThrowsException = true)]
		private static unsafe JobHandle ScheduleBoxcastBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits); // 0x000000018D54A004-0x000000018D54A074
		private static unsafe void ScheduleBoxcastBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out JobHandle ret); // 0x000000018D549FA0-0x000000018D54A004
	}
}
