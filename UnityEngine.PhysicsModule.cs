/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using Unity.Collections;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine.HyperGryph.ECS;

// Image 60: UnityEngine.PhysicsModule.dll - Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59017-59051

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 59018
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 59019
	{
		// Constructors
		public IsReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine
{
	public enum RigidbodyConstraints // TypeDefIndex: 59020
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

	public enum ForceMode // TypeDefIndex: 59021
	{
		Force = 0,
		Impulse = 1,
		VelocityChange = 2,
		Acceleration = 5
	}

	public enum MeshColliderCookingOptions // TypeDefIndex: 59022
	{
		None = 0,
		InflateConvexMesh = 1,
		CookForFasterSimulation = 2,
		EnableMeshCleaning = 4,
		WeldColocatedVertices = 8,
		UseFastMidphase = 16
	}

	public enum ColliderSurfaceType // TypeDefIndex: 59023
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

	public enum RigidbodyInterpolation // TypeDefIndex: 59024
	{
		None = 0,
		Interpolate = 1,
		Extrapolate = 2
	}

	public class ControllerColliderHit // TypeDefIndex: 59025
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
		public GameObject gameObject { get => default; } // 0x000000018BF34928-0x000000018BF34948 
		public Vector3 point { get => default; } // 0x0000000185FE8DE0-0x0000000185FE8E00 
	
		// Constructors
		public ControllerColliderHit() {} // Dummy constructor
	}

	public class Collision // TypeDefIndex: 59026
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
		public Vector3 relativeVelocity { get => default; } // 0x0000000185FE6610-0x0000000185FE6630 
		public Collider collider { get => default; } // 0x0000000185FE7B40-0x0000000185FE7B50 
		public GameObject gameObject { get => default; } // 0x000000018BF34868-0x000000018BF348DC 
		public ContactPoint[] contacts { get => default; } // 0x000000018BF34800-0x000000018BF34868 
		public Vector3 impulse { get => default; } // 0x0000000185FE6660-0x0000000185FE6680 
	
		// Constructors
		public Collision() {} // Dummy constructor
	}

	public enum QueryTriggerInteraction // TypeDefIndex: 59027
	{
		UseGlobal = 0,
		Ignore = 1,
		Collide = 2
	}

	public enum CollisionDetectionMode // TypeDefIndex: 59028
	{
		Discrete = 0,
		Continuous = 1,
		ContinuousDynamic = 2,
		ContinuousSpeculative = 3
	}

	public class ArticulationBody : Behaviour // TypeDefIndex: 59029
	{
		// Constructors
		public ArticulationBody() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class Physics // TypeDefIndex: 59030
	{
		// Fields
		private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent; // 0x00
		private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD; // 0x08
		internal const float k_MaxFloatMinusEpsilon = 3.4028233E+38f; // Metadata: 0x02080390
		public const int IgnoreRaycastLayer = 4; // Metadata: 0x02080394
		public const int DefaultRaycastLayers = -5; // Metadata: 0x02080395
		public const int AllLayers = -1; // Metadata: 0x02080396
		public const int kIgnoreRaycastLayer = 4; // Metadata: 0x02080397
		public const int kDefaultRaycastLayers = -5; // Metadata: 0x02080398
		public const int kAllLayers = -1; // Metadata: 0x02080399
	
		// Properties
		public static Vector3 gravity { get => default; set {} } // 0x0000000184501880-0x00000001845018B0 0x000000018BF3E610-0x000000018BF3E620
		public static float defaultContactOffset { get => default; set {} } // 0x00000001847FA380-0x00000001847FA3C0 0x000000018BF3E4C0-0x000000018BF3E4FC
		public static float sleepThreshold { get => default; set {} } // 0x000000018BF3E280-0x000000018BF3E2AC 0x000000018BF3E79C-0x000000018BF3E7D8
		public static bool queriesHitTriggers { get => default; set {} } // 0x000000018BF3E228-0x000000018BF3E254 0x000000018BF3E734-0x000000018BF3E768
		public static bool queriesHitBackfaces { get => default; set {} } // 0x000000018BF3E1FC-0x000000018BF3E228 0x000000018BF3E700-0x000000018BF3E734
		public static float bounceThreshold { get => default; set {} } // 0x000000018BF3DFE0-0x000000018BF3E00C 0x000000018BF3E438-0x000000018BF3E474
		public static float defaultMaxDepenetrationVelocity { get => default; set {} } // 0x000000018BF3E09C-0x000000018BF3E0C8 0x000000018BF3E538-0x000000018BF3E574
		public static int defaultSolverIterations { get => default; set {} } // 0x000000018BF3E0C8-0x000000018BF3E0F4 0x000000018BF3E574-0x000000018BF3E5A8
		public static int defaultSolverVelocityIterations { get => default; set {} } // 0x000000018BF3E0F4-0x000000018BF3E120 0x000000018BF3E5A8-0x000000018BF3E5DC
		public static float defaultMaxAngularSpeed { get => default; set {} } // 0x000000018BF3E070-0x000000018BF3E09C 0x000000018BF3E4FC-0x000000018BF3E538
		public static bool improvedPatchFriction { get => default; set {} } // 0x000000018BF3E120-0x000000018BF3E14C 0x000000018BF3E620-0x000000018BF3E654
		public static PhysicsScene defaultPhysicsScene { get => default; } // 0x00000001842927B0-0x0000000184292800 
		public static bool logPhysXCheckError { get => default; set {} } // 0x000000018BF3E1D0-0x000000018BF3E1FC 0x00000001850E1870-0x00000001850E18B0
		public static bool autoSimulation { get => default; set {} } // 0x0000000184D332A0-0x0000000184D332E0 0x00000001850E18B0-0x00000001850E18F0
		public static bool autoSyncTransforms { get => default; set {} } // 0x000000018BF3DFB4-0x000000018BF3DFE0 0x000000018BF3E404-0x000000018BF3E438
		public static bool reuseCollisionCallbacks { get => default; set {} } // 0x000000018BF3E254-0x000000018BF3E280 0x000000018BF3E768-0x000000018BF3E79C
		public static float interCollisionDistance { get => default; set {} } // 0x000000018BF3E14C-0x000000018BF3E178 0x000000018BF3E654-0x000000018BF3E690
		public static float interCollisionStiffness { get => default; set {} } // 0x000000018BF3E1A4-0x000000018BF3E1D0 0x000000018BF3E6C4-0x000000018BF3E700
		public static bool interCollisionSettingsToggle { get => default; set {} } // 0x000000018BF3E178-0x000000018BF3E1A4 0x000000018BF3E690-0x000000018BF3E6C4
		public static Vector3 clothGravity { get => default; set {} } // 0x000000018BF3E04C-0x000000018BF3E070 0x000000018BF3E4B0-0x000000018BF3E4C0
		public static float minPenetrationForPenalty { get => default; set {} } // 0x0000000185FE6C30-0x0000000185FE6C40 0x0000000185492010-0x0000000185492020
		public static float bounceTreshold { get => default; set {} } // 0x000000018BF3E00C-0x000000018BF3E018 0x000000018BF3E474-0x000000018BF3E47C
		public static float sleepVelocity { get => default; set {} } // 0x0000000185FE6C30-0x0000000185FE6C40 0x0000000185492010-0x0000000185492020
		public static float sleepAngularVelocity { get => default; set {} } // 0x0000000185FE6C30-0x0000000185FE6C40 0x0000000185492010-0x0000000185492020
		public static float maxAngularVelocity { get => default; set {} } // 0x0000000185FE6C30-0x0000000185FE6C40 0x0000000185492010-0x0000000185492020
		public static int solverIterationCount { get => default; set {} } // 0x000000018BF3E2AC-0x000000018BF3E2B8 0x000000018BF3E7D8-0x000000018BF3E7E0
		public static int solverVelocityIterationCount { get => default; set {} } // 0x000000018BF3E2B8-0x000000018BF3E2C4 0x000000018BF3E7E0-0x000000018BF3E7E8
		public static float penetrationPenaltyForce { get => default; set {} } // 0x0000000185FE6C30-0x0000000185FE6C40 0x0000000185492010-0x0000000185492020
	
		// Events
		public static event Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent;
		public static event Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD;
	
		// Constructors
		public Physics() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) {} // 0x000000018BF3A4E0-0x000000018BF3A59C
		public static void ClearUnusedMemory() {} // 0x0000000185FA7300-0x0000000185FA7340
		public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore) {} // 0x000000018BF39EAC-0x000000018BF39F00
		public static void IgnoreCollision(Collider collider1, Collider collider2) {} // 0x000000018BF39F00-0x000000018BF39F0C
		public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore) {} // 0x000000018BF39F18-0x000000018BF39F68
		public static void ForceRebuildDynamicTree(bool rebuildStatic, bool rebuildDynamic) {} // 0x000000018BF39DE4-0x000000018BF39E28
		public static void IgnoreLayerCollision(int layer1, int layer2) {} // 0x000000018BF39F0C-0x000000018BF39F18
		public static bool GetIgnoreLayerCollision(int layer1, int layer2) => default; // 0x000000018BF39E6C-0x000000018BF39EAC
		public static bool GetIgnoreCollision(Collider collider1, Collider collider2) => default; // 0x000000018BF39E28-0x000000018BF39E6C
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3CEE8-0x000000018BF3CF80
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) => default; // 0x000000018BF3CDC8-0x000000018BF3CE58
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) => default; // 0x000000018BF3D2A0-0x000000018BF3D328
		public static bool Raycast(Vector3 origin, Vector3 direction) => default; // 0x000000018BF3D1A4-0x000000018BF3D21C
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000184738690-0x0000000184738950
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x00000001847F94F0-0x00000001847F9590
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x0000000184C9D0C0-0x0000000184C9D370
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3CE58-0x000000018BF3CEE8
		public static bool RaycastV2(ECSColliderResultProxy proxy, Ray ray, float maxDistance, out RaycastHit hit) {
			hit = default;
			return default;
		} // 0x000000018BF3CCA0-0x000000018BF3CD34
		public static bool RaycastV2(ECSColliderResultProxy proxy, Ray ray, float maxDistance, bool hitHoles, out RaycastHit hit) {
			hit = default;
			return default;
		} // 0x000000018BF3CD34-0x000000018BF3CDC8
		private static RaycastHit Internal_RaycastTestV2(ECSColliderResultProxy collider, Ray ray, float maxDistance, bool hitHoles, ref bool hasHit) => default; // 0x000000018BF3A110-0x000000018BF3A184
		public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3D114-0x000000018BF3D1A4
		public static bool Raycast(Ray ray, float maxDistance, int layerMask) => default; // 0x000000018BF3CF80-0x000000018BF3D008
		public static bool Raycast(Ray ray, float maxDistance) => default; // 0x000000018BF3D008-0x000000018BF3D084
		public static bool Raycast(Ray ray) => default; // 0x000000018BF3D328-0x000000018BF3D394
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x0000000184CEA330-0x0000000184CEA3D0
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x0000000184B49250-0x0000000184B492B0
		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3D084-0x000000018BF3D114
		public static bool Raycast(Ray ray, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3D21C-0x000000018BF3D2A0
		public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3A380-0x000000018BF3A450
		public static bool Linecast(Vector3 start, Vector3 end, int layerMask) => default; // 0x000000018BF3A450-0x000000018BF3A498
		public static bool Linecast(Vector3 start, Vector3 end) => default; // 0x000000018BF3A334-0x000000018BF3A380
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3A210-0x000000018BF3A2E8
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3A498-0x000000018BF3A4E0
		public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3A2E8-0x000000018BF3A334
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF39038-0x000000018BF3910C
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask) => default; // 0x000000018BF392E0-0x000000018BF39358
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance) => default; // 0x000000018BF39190-0x000000018BF39204
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction) => default; // 0x000000018BF38F3C-0x000000018BF38FB0
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x000000018BF39204-0x000000018BF392E0
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x000000018BF38FB0-0x000000018BF39038
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x000000018BF38EB4-0x000000018BF38F3C
		public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3910C-0x000000018BF39190
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x00000001847FAC00-0x00000001847FACB0
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3DA4C-0x000000018BF3DAB0
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3DCA0-0x000000018BF3DD00
		public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3DB24-0x000000018BF3DB84
		public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3DB84-0x000000018BF3DC28
		public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask) => default; // 0x000000018BF3DC6C-0x000000018BF3DCA0
		public static bool SphereCast(Ray ray, float radius, float maxDistance) => default; // 0x000000018BF3DAEC-0x000000018BF3DB24
		public static bool SphereCast(Ray ray, float radius) => default; // 0x000000018BF3DD60-0x000000018BF3DDA0
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3DD00-0x000000018BF3DD60
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3DDA0-0x000000018BF3DDDC
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3DAB0-0x000000018BF3DAEC
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3DC28-0x000000018BF3DC6C
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF381A0-0x000000018BF38274
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask) => default; // 0x000000018BF384F0-0x000000018BF3857C
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance) => default; // 0x000000018BF383A4-0x000000018BF3842C
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation) => default; // 0x000000018BF38610-0x000000018BF38698
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction) => default; // 0x000000018BF38110-0x000000018BF381A0
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3842C-0x000000018BF384F0
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask) {
			hitInfo = default;
			return default;
		} // 0x000000018BF38274-0x000000018BF3830C
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x000000018BF38698-0x000000018BF3872C
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3857C-0x000000018BF38610
		public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3830C-0x000000018BF383A4
		private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3A084-0x000000018BF3A0AC
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3C748-0x000000018BF3C86C
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) => default; // 0x000000018BF3C700-0x000000018BF3C748
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) => default; // 0x000000018BF3C8B8-0x000000018BF3C904
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) => default; // 0x000000018BF3C904-0x000000018BF3C958
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3C86C-0x000000018BF3C8B8
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) => default; // 0x000000018BF3C6B4-0x000000018BF3C700
		public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) => default; // 0x000000018BF3C664-0x000000018BF3C6B4
		public static RaycastHit[] RaycastAll(Ray ray) => default; // 0x000000018BF3C958-0x000000018BF3C9AC
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000185045750-0x00000001850458B0
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) => default; // 0x000000018BF3CA3C-0x000000018BF3CAD4
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) => default; // 0x000000018BF3C9AC-0x000000018BF3CA3C
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) => default; // 0x0000000184B47C70-0x0000000184B47D00
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000184292400-0x00000001842927B0
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) => default; // 0x000000018BF3CB70-0x000000018BF3CC10
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) => default; // 0x000000018BF3CAD4-0x000000018BF3CB70
		public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) => default; // 0x000000018BF3CC10-0x000000018BF3CCA0
		private static RaycastHit[] Query_CapsuleCastAll(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3C010-0x000000018BF3C064
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3872C-0x000000018BF3886C
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask) => default; // 0x000000018BF388E0-0x000000018BF38958
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance) => default; // 0x000000018BF3886C-0x000000018BF388E0
		public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction) => default; // 0x000000018BF38958-0x000000018BF389CC
		private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3C56C-0x000000018BF3C5AC
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3D6E0-0x000000018BF3D80C
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask) => default; // 0x000000018BF3D518-0x000000018BF3D56C
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance) => default; // 0x000000018BF3D658-0x000000018BF3D6A8
		public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction) => default; // 0x000000018BF3D600-0x000000018BF3D658
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3D5AC-0x000000018BF3D600
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask) => default; // 0x000000018BF3D4E4-0x000000018BF3D518
		public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance) => default; // 0x000000018BF3D6A8-0x000000018BF3D6E0
		public static RaycastHit[] SphereCastAll(Ray ray, float radius) => default; // 0x000000018BF3D56C-0x000000018BF3D5AC
		private static Collider[] OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3B640-0x000000018BF3B670
		public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3B734-0x000000018BF3B80C
		public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask) => default; // 0x000000018BF3B670-0x000000018BF3B734
		public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius) => default; // 0x000000018BF3B80C-0x000000018BF3B8C4
		private static ECSColliderResultProxy[] OverlapCapsuleV2_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3B48C-0x000000018BF3B4BC
		public static ECSColliderResultProxy[] OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3B550-0x000000018BF3B5DC
		public static ECSColliderResultProxy[] OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius, int layerMask) => default; // 0x000000018BF3B508-0x000000018BF3B550
		public static ECSColliderResultProxy[] OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius) => default; // 0x000000018BF3B4BC-0x000000018BF3B508
		private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3BD98-0x000000018BF3BDC0
		public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3BE60-0x000000018BF3BF18
		public static ECSColliderResultProxy CreateECSProxy(Collider collider) => default; // 0x000000018435B040-0x000000018435B1D0
		public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask) => default; // 0x000000018BF3BDC0-0x000000018BF3BE60
		public static Collider[] OverlapSphere(Vector3 position, float radius) => default; // 0x000000018BF3BF18-0x000000018BF3BFAC
		private static ECSColliderResultProxy[] OverlapSphereV2_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3BC38-0x000000018BF3BC60
		public static ECSColliderResultProxy[] OverlapSphereV2(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3BC98-0x000000018BF3BD04
		public static ECSColliderResultProxy[] OverlapSphereV2(Vector3 position, float radius, int layerMask) => default; // 0x000000018BF3BD04-0x000000018BF3BD34
		public static ECSColliderResultProxy[] OverlapSphereV2(Vector3 position, float radius) => default; // 0x000000018BF3BC60-0x000000018BF3BC98
		internal static void Simulate_Internal(PhysicsScene physicsScene, float step) {} // 0x0000000186472624-0x0000000186472640
		public static void Simulate(float step) {} // 0x0000000184D33210-0x0000000184D332A0
		public static void SyncTransforms() {} // 0x0000000184A53C60-0x0000000184A53D90
		private static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x000000018BF3C420-0x000000018BF3C46C
		public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) {
			direction = default;
			distance = default;
			return default;
		} // 0x000000018BF39BFC-0x000000018BF39D34
		private static bool Query_ComputePenetrationV2(ECSColliderResultProxy colliderA, Vector3 positionA, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x000000018646E8DC-0x000000018646E928
		public static bool ComputePenetrationV2(ECSColliderResultProxy colliderA, Vector3 positionA, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) {
			direction = default;
			distance = default;
			return default;
		} // 0x000000018435A190-0x000000018435A2B0
		private static bool Query_ComputeCapsulePenetration(Vector3 point1, Vector3 point2, float radius, Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x000000018BF3C370-0x000000018BF3C3BC
		public static bool ComputeCapsulePenetration(Vector3 point1, Vector3 point2, float radius, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) {
			direction = default;
			distance = default;
			return default;
		} // 0x000000018BF39AD0-0x000000018BF39BFC
		private static bool Query_ComputeCapsulePenetrationV2(Vector3 point1, Vector3 point2, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x000000018BF3C2C0-0x000000018BF3C30C
		public static bool ComputeCapsulePenetrationV2(Vector3 point1, Vector3 point2, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) {
			direction = default;
			distance = default;
			return default;
		} // 0x000000018BF39A04-0x000000018BF39AD0
		private static bool Query_ComputeSpherePenetrationV2(Vector3 center, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x000000018BF3C4D0-0x000000018BF3C508
		public static bool ComputeSpherePenetrationV2(Vector3 center, float radius, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) {
			direction = default;
			distance = default;
			return default;
		} // 0x000000018BF39D34-0x000000018BF39DE4
		private static bool Query_ComputeBoxPenetrationV2(Vector3 center, Vector3 halfExtent, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x000000018BF3C210-0x000000018BF3C25C
		public static bool ComputeBoxPenetrationV2(Vector3 center, Vector3 halfExtent, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) {
			direction = default;
			distance = default;
			return default;
		} // 0x000000018BF39928-0x000000018BF39A04
		private static bool IsSimulatedThisFrame_Internal() => default; // 0x000000018BF3A1D8-0x000000018BF3A204
		public static bool IsSimulatedThisFrame() => default; // 0x000000018BF3A204-0x000000018BF3A210
		private static void SetForceSimulateThisFrame_Internal(bool force) {} // 0x000000018BF3D4A8-0x000000018BF3D4DC
		public static void SetForceSimulateThisFrame(bool force) {} // 0x000000018BF3D4DC-0x000000018BF3D4E4
		private static void SetFastSimulate_Internal(bool fast) {} // 0x0000000185F7DCF0-0x0000000185F7DD30
		public static void SetFastSimulate(bool fast) {} // 0x00000001864733C4-0x00000001864733CC
		private static Vector3 Query_ClosestPoint(Collider collider, Vector3 position, Quaternion rotation, Vector3 point) => default; // 0x000000018BF3C16C-0x000000018BF3C1AC
		public static Vector3 ClosestPoint(Vector3 point, Collider collider, Vector3 position, Quaternion rotation) => default; // 0x000000018BF39830-0x000000018BF39928
		private static Vector3 Query_ClosestPointV2(ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation, Vector3 point) => default; // 0x000000018BF3C0C8-0x000000018BF3C108
		public static Vector3 ClosestPointV2(Vector3 point, ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation) => default; // 0x000000018BF3978C-0x000000018BF39830
		private static Vector3 Query_TryGetClosestPoint(ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation, Vector3 point, ref bool resultIsValid) => default; // 0x000000018BF3C610-0x000000018BF3C664
		public static bool TryGetClosestPoint(ECSColliderResultProxy colliderProxy, Vector3 position, Quaternion rotation, Vector3 point, out Vector3 result) {
			result = default;
			return default;
		} // 0x000000018BF3DDDC-0x000000018BF3DE74
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3BB08-0x000000018BF3BBD4
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask) => default; // 0x000000018BF3BA54-0x000000018BF3BB08
		public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results) => default; // 0x000000018BF3B9AC-0x000000018BF3BA54
		public static int OverlapSphereNonAllocV2(Vector3 position, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3B8C4-0x000000018BF3B944
		public static int OverlapSphereNonAllocV2(Vector3 position, float radius, ECSColliderResultProxy[] results, int layerMask) => default; // 0x000000018BF3B97C-0x000000018BF3B9AC
		public static int OverlapSphereNonAllocV2(Vector3 position, float radius, ECSColliderResultProxy[] results) => default; // 0x000000018BF3B944-0x000000018BF3B97C
		private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF39690-0x000000018BF396B8
		public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF396F0-0x000000018BF3975C
		public static bool CheckSphere(Vector3 position, float radius, int layerMask) => default; // 0x000000018BF3975C-0x000000018BF3978C
		public static bool CheckSphere(Vector3 position, float radius) => default; // 0x000000018BF396B8-0x000000018BF396F0
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000184380CB0-0x0000000184380DF0
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF38B70-0x000000018BF38C4C
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) => default; // 0x000000018BF38D20-0x000000018BF38DA8
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results, float maxDistance, int layerMask) => default; // 0x000000018BF38C4C-0x000000018BF38D20
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance) => default; // 0x000000018BF38E2C-0x000000018BF38EB4
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results, float maxDistance) => default; // 0x000000018BF38A9C-0x000000018BF38B70
		public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results) => default; // 0x000000018BF38DA8-0x000000018BF38E2C
		public static int CapsuleCastNonAllocV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] results) => default; // 0x000000018BF389CC-0x000000018BF38A9C
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x00000001847FD460-0x00000001847FD5F0
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) => default; // 0x000000018BF3D988-0x000000018BF3D9EC
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance) => default; // 0x000000018BF3D8C8-0x000000018BF3D928
		public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results) => default; // 0x000000018BF3D9EC-0x000000018BF3DA4C
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3D928-0x000000018BF3D988
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask) => default; // 0x000000018BF3D850-0x000000018BF3D88C
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance) => default; // 0x000000018BF3D88C-0x000000018BF3D8C8
		public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results) => default; // 0x000000018BF3D80C-0x000000018BF3D850
		private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000186470238-0x0000000186470268
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x00000001847F9D60-0x00000001847F9E00
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask) => default; // 0x000000018BF39598-0x000000018BF395E0
		public static bool CheckCapsule(Vector3 start, Vector3 end, float radius) => default; // 0x000000018BF395E0-0x000000018BF3962C
		private static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF393BC-0x000000018BF393EC
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF394B0-0x000000018BF39544
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) => default; // 0x000000018BF39544-0x000000018BF39598
		public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation) => default; // 0x000000018BF393EC-0x000000018BF39448
		public static bool CheckBox(Vector3 center, Vector3 halfExtents) => default; // 0x000000018BF39448-0x000000018BF394B0
		private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3AD90-0x000000018BF3ADC0
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3AF44-0x000000018BF3B028
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) => default; // 0x000000018BF3B028-0x000000018BF3B0FC
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation) => default; // 0x000000018BF3ADC0-0x000000018BF3AE84
		public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents) => default; // 0x000000018BF3AE84-0x000000018BF3AF44
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3A76C-0x000000018BF3A868
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask) => default; // 0x000000018BF3A868-0x000000018BF3A944
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation) => default; // 0x000000018BF3A944-0x000000018BF3AA1C
		public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results) => default; // 0x000000018BF3AA1C-0x000000018BF3AAF0
		private static ECSColliderResultProxy[] OverlapBoxV2_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3AB54-0x000000018BF3AB84
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3AC98-0x000000018BF3AD2C
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) => default; // 0x000000018BF3AC44-0x000000018BF3AC98
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents, Quaternion orientation) => default; // 0x000000018BF3AB84-0x000000018BF3ABDC
		public static ECSColliderResultProxy[] OverlapBoxV2(Vector3 center, Vector3 halfExtents) => default; // 0x000000018BF3ABDC-0x000000018BF3AC44
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3A6BC-0x000000018BF3A76C
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, Quaternion orientation, int mask) => default; // 0x000000018BF3A604-0x000000018BF3A664
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, Quaternion orientation) => default; // 0x000000018BF3A664-0x000000018BF3A6BC
		public static int OverlapBoxNonAllocV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results) => default; // 0x000000018BF3A59C-0x000000018BF3A604
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x00000001840B9380-0x00000001840B94D0
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation) => default; // 0x000000018BF37FE8-0x000000018BF3807C
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance) => default; // 0x000000018BF3807C-0x000000018BF38110
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layerMask) => default; // 0x000000018BF37EB8-0x000000018BF37F50
		public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results) => default; // 0x000000018BF37F50-0x000000018BF37FE8
		private static RaycastHit[] Internal_BoxCastAll(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF39FCC-0x000000018BF3A020
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF37B44-0x000000018BF37C8C
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask) => default; // 0x000000018BF37D9C-0x000000018BF37E28
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance) => default; // 0x000000018BF37C8C-0x000000018BF37D14
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation) => default; // 0x000000018BF37D14-0x000000018BF37D9C
		public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction) => default; // 0x000000018BF37E28-0x000000018BF37EB8
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3B338-0x000000018BF3B428
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask) => default; // 0x000000018BF3B198-0x000000018BF3B26C
		public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results) => default; // 0x000000018BF3B26C-0x000000018BF3B338
		public static int OverlapCapsuleNonAllocV2(Vector3 point0, Vector3 point1, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x00000001847FCDE0-0x00000001847FCE90
		public static int OverlapCapsuleNonAllocV2(Vector3 point0, Vector3 point1, float radius, ECSColliderResultProxy[] results, int layerMask) => default; // 0x000000018BF3B148-0x000000018BF3B198
		public static int OverlapCapsuleNonAllocV2(Vector3 point0, Vector3 point1, float radius, ECSColliderResultProxy[] results) => default; // 0x000000018BF3B0FC-0x000000018BF3B148
		private static void Internal_RebuildBroadphaseRegions(Bounds bounds, int subdivisions) {} // 0x000000018BF3A1C4-0x000000018BF3A1D8
		public static void RebuildBroadphaseRegions(Bounds worldBounds, int subdivisions) {} // 0x000000018BF3D394-0x000000018BF3D4A8
		public static void BakeMesh(int meshID, bool convex) {} // 0x000000018BF37B04-0x000000018BF37B44
		private static void get_gravity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x00000001845018B0-0x00000001845018F0
		private static void set_gravity_Injected(ref Vector3 value) {} // 0x000000018BF3E5DC-0x000000018BF3E610
		private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) {
			ret = default;
		} // 0x0000000184292800-0x0000000184292840
		private static void Internal_RaycastTestV2_Injected(ref ECSColliderResultProxy collider, ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x000000018BF3A0AC-0x000000018BF3A110
		private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3A020-0x000000018BF3A084
		private static RaycastHit[] Query_CapsuleCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3BFAC-0x000000018BF3C010
		private static RaycastHit[] Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3C508-0x000000018BF3C56C
		private static Collider[] OverlapCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3B5DC-0x000000018BF3B640
		private static ECSColliderResultProxy[] OverlapCapsuleV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3B428-0x000000018BF3B48C
		private static Collider[] OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3BD34-0x000000018BF3BD98
		private static ECSColliderResultProxy[] OverlapSphereV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3BBD4-0x000000018BF3BC38
		private static void Simulate_Internal_Injected(ref PhysicsScene physicsScene, float step) {} // 0x0000000184D332E0-0x0000000184D33330
		private static bool Query_ComputePenetration_Injected(Collider colliderA, ref Vector3 positionA, ref Quaternion rotationA, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x000000018BF3C3BC-0x000000018BF3C420
		private static bool Query_ComputePenetrationV2_Injected(ref ECSColliderResultProxy colliderA, ref Vector3 positionA, ref Quaternion rotationA, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x000000018580E580-0x000000018580E5F0
		private static bool Query_ComputeCapsulePenetration_Injected(ref Vector3 point1, ref Vector3 point2, float radius, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x000000018BF3C30C-0x000000018BF3C370
		private static bool Query_ComputeCapsulePenetrationV2_Injected(ref Vector3 point1, ref Vector3 point2, float radius, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x000000018BF3C25C-0x000000018BF3C2C0
		private static bool Query_ComputeSpherePenetrationV2_Injected(ref Vector3 center, float radius, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x000000018BF3C46C-0x000000018BF3C4D0
		private static bool Query_ComputeBoxPenetrationV2_Injected(ref Vector3 center, ref Vector3 halfExtent, ref Quaternion rotationA, ref ECSColliderResultProxy colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) => default; // 0x000000018BF3C1AC-0x000000018BF3C210
		private static void Query_ClosestPoint_Injected(Collider collider, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, out Vector3 ret) {
			ret = default;
		} // 0x000000018BF3C108-0x000000018BF3C16C
		private static void Query_ClosestPointV2_Injected(ref ECSColliderResultProxy colliderProxy, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, out Vector3 ret) {
			ret = default;
		} // 0x000000018BF3C064-0x000000018BF3C0C8
		private static void Query_TryGetClosestPoint_Injected(ref ECSColliderResultProxy colliderProxy, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, ref bool resultIsValid, out Vector3 ret) {
			ret = default;
		} // 0x000000018BF3C5AC-0x000000018BF3C610
		private static void get_clothGravity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BF3E018-0x000000018BF3E04C
		private static void set_clothGravity_Injected(ref Vector3 value) {} // 0x000000018BF3E47C-0x000000018BF3E4B0
		private static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3962C-0x000000018BF39690
		private static bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018552A840-0x000000018552A8B0
		private static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF39358-0x000000018BF393BC
		private static Collider[] OverlapBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3AD2C-0x000000018BF3AD90
		private static ECSColliderResultProxy[] OverlapBoxV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3AAF0-0x000000018BF3AB54
		private static RaycastHit[] Internal_BoxCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF39F68-0x000000018BF39FCC
		private static void Internal_RebuildBroadphaseRegions_Injected(ref Bounds bounds, int subdivisions) {} // 0x000000018BF3A184-0x000000018BF3A1C4
	}

	public struct ModifiableContactPair // TypeDefIndex: 59031
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

	public class PhysicMaterial : Object // TypeDefIndex: 59032
	{
		// Constructors
		public PhysicMaterial() {} // 0x000000018BF36ADC-0x000000018BF36B30
	
		// Methods
		private static void Internal_CreateDynamicsMaterial(PhysicMaterial mat, string name) {} // 0x000000018BF36A98-0x000000018BF36ADC
	}

	public struct ECSColliderResultProxy : IEquatable<UnityEngine.ECSColliderResultProxy> // TypeDefIndex: 59033
	{
		// Fields
		internal IntPtr m_Actor; // 0x00
		internal int m_EcsId; // 0x08
		internal uint m_EcsVersion; // 0x0C
		internal int m_Collider; // 0x10
		internal int m_ComponentIndex; // 0x14
		private static readonly ECSColliderResultProxy INVALID_PROXY; // 0x00
	
		// Properties
		public int componentIndex { get => default; } // 0x0000000185FB1090-0x0000000185FB10A0 
		public Entity colliderEntity { get => default; } // 0x0000000185A38CA0-0x0000000185A38CB0 
		public int ecsId { get => default; } // 0x00000001835DC780-0x00000001835DC790 
		public uint ecsVersion { get => default; } // 0x0000000185FC9070-0x0000000185FC9080 
		public static ECSColliderResultProxy invalid { get => default; } // 0x000000018BF35130-0x000000018BF35194 
		public Collider collider { get => default; } // 0x0000000184294BE0-0x0000000184294C80 
		public int colliderInstanceId { get => default; } // 0x0000000185FE6790-0x0000000185FE67A0 
		public bool bIsECS { get => default; } // 0x0000000184295720-0x0000000184295740 
		public int tagConfig { get => default; } // 0x0000000184297A70-0x0000000184297B40 
		public bool isTrigger { get => default; } // 0x000000018BF35194-0x000000018BF352B4 
		public int layer { get => default; } // 0x00000001847FB970-0x00000001847FBAB0 
		public Transform transform { get => default; } // 0x00000001847FC5F0-0x00000001847FC7F0 
		public Vector3 transformPosition { get => default; } // 0x000000018435A5A0-0x000000018435A710 
		public Quaternion transformRotation { get => default; } // 0x000000018435A430-0x000000018435A5A0 
		public Vector3 transformLossyScale { get => default; } // 0x000000018BF352B4-0x000000018BF353BC 
		public Vector3 shapePosition { get => default; } // 0x0000000184289A80-0x0000000184289C10 
		public Bounds bounds { get => default; } // 0x00000001851D2110-0x00000001851D2200 
		public int colliderOptions { get => default; } // 0x00000001842959E0-0x0000000184295B50 
		public ColliderSurfaceType surfaceType { get => default; } // 0x00000001847F9950-0x00000001847F99E0 
		public ECSColliderType colliderType { get => default; } // 0x000000018BF34FD4-0x000000018BF35130 
		public GameObject gameObject { get => default; } // 0x0000000185291A10-0x0000000185291AE0 
		public bool hasComplexMesh { get => default; } // 0x0000000184295BB0-0x0000000184295C60 
	
		// Constructors
		static ECSColliderResultProxy() {
			INVALID_PROXY = default;
		} // 0x0000000185F8C400-0x0000000185F8C440
	
		// Methods
		public void SetColliderAndSetIndex(int colliderInstanceID) {} // 0x0000000184294ED0-0x0000000184295090
		public void SetComponentIndex(int index) {} // 0x0000000185FBB0B0-0x0000000185FBB0C0
		public void SetActor(IntPtr actor) {} // 0x0000000185FB2BB0-0x0000000185FB2BC0
		public void SetEcsId(int id) {} // 0x0000000185FB2B90-0x0000000185FB2BA0
		public void SetEcsVersion(uint version) {} // 0x0000000185FB6960-0x0000000185FB6970
		public bool IsValid() => default; // 0x0000000184295740-0x0000000184295980
		public string GetColliderGoName() => default; // 0x000000018BF34C9C-0x000000018BF34D5C
		public int GetFactoryBuildingIdentifier() => default; // 0x000000018437D130-0x000000018437D1B0
		public bool TryGetClosestPoint(Vector3 point, out Vector3 result) {
			result = default;
			return default;
		} // 0x000000018BF34EBC-0x000000018BF34FD4
		public Vector3 ClosestPoint(Vector3 position) => default; // 0x000000018BF34948-0x000000018BF34A94
		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x000000018BF34D5C-0x000000018BF34EBC
		public static bool operator ==(ECSColliderResultProxy left, ECSColliderResultProxy right) => default; // 0x000000018BF353BC-0x000000018BF3544C
		public static bool operator !=(ECSColliderResultProxy left, ECSColliderResultProxy right) => default; // 0x00000001848E1740-0x00000001848E1920
		public bool Equals(ECSColliderResultProxy other) => default; // 0x00000001855A62A0-0x00000001855A6340
		public override bool Equals(object obj) => default; // 0x000000018BF34BF8-0x000000018BF34C9C
		public override int GetHashCode() => default; // 0x0000000185262D70-0x0000000185262E50
		public bool CompareTag(int tagValue) => default; // 0x000000018BF34A94-0x000000018BF34BF8
		public bool IsSameCollider(Collider otherCollider) => default; // 0x00000001847FC7F0-0x00000001847FC8B0
	}

	public struct RaycastHit // TypeDefIndex: 59034
	{
		// Fields
		internal Vector3 m_Point; // 0x00
		internal Vector3 m_Normal; // 0x0C
		internal uint m_FaceID; // 0x18
		internal float m_Distance; // 0x1C
		internal Vector2 m_UV; // 0x20
		internal int m_Collider; // 0x28
		internal int m_Index; // 0x2C
		internal int m_EcsId; // 0x30
		internal uint m_EcsVersion; // 0x34
		internal IntPtr m_Actor; // 0x38
	
		// Properties
		public int ecsId { get => default; } // 0x0000000185FE6710-0x0000000185FE6720 
		public uint ecsVersion { get => default; } // 0x0000000185FE66A0-0x0000000185FE66B0 
		public bool IsECSCollider { get => default; } // 0x000000018437D110-0x000000018437D130 
		public Collider collider { get => default; } // 0x000000018524C0D0-0x000000018524C140 
		public int colliderInstanceID { get => default; } // 0x0000000185FE7B60-0x0000000185FE7B70 
		public Collider editorCollider { get => default; } // 0x000000018BF3E924-0x000000018BF3E9B4 
		public ECSColliderResultProxy colliderProxy { get => default; } // 0x0000000184294C80-0x0000000184294ED0 
		public Vector3 point { get => default; set {} } // 0x0000000185FE65B0-0x0000000185FE65D0 0x0000000185FB7BD0-0x0000000185FB7BE0
		public Vector3 normal { get => default; set {} } // 0x0000000185FE6590-0x0000000185FE65B0 0x0000000185FB7BE0-0x0000000185FB7BF0
		public Vector3 barycentricCoordinate { get => default; set {} } // 0x0000000185FE8E20-0x0000000185FE8E50 0x000000018BF3EED0-0x000000018BF3EEF0
		public float distance { get => default; set {} } // 0x0000000185FE8CF0-0x0000000185FE8D00 0x0000000183B7E5A0-0x0000000183B7E5B0
		public int triangleIndex { get => default; } // 0x0000000185FC9940-0x0000000185FC9950 
		public int componentIndex { get => default; } // 0x0000000185FE8E50-0x0000000185FE8E60 
		public Vector2 textureCoord { get => default; } // 0x000000018BF3EDB0-0x000000018BF3EE0C 
		public Vector2 textureCoord2 { get => default; } // 0x000000018BF3ED50-0x000000018BF3EDB0 
		public Transform transform { get => default; } // 0x000000018BF3EE0C-0x000000018BF3EED0 
		public Vector3 shapePosition { get => default; } // 0x000000018BF3ECC8-0x000000018BF3ED08 
		public Quaternion shapeRotation { get => default; } // 0x000000018BF3ED08-0x000000018BF3ED40 
		public Vector3 position { get => default; } // 0x000000018BF3EB20-0x000000018BF3EB54 
		public Quaternion rotation { get => default; } // 0x000000018BF3EBE4-0x000000018BF3EC10 
		public Vector3 scale { get => default; } // 0x000000018BF3EC10-0x000000018BF3ECC8 
		public Rigidbody rigidbody { get => default; } // 0x000000018BF3EB54-0x000000018BF3EBE4 
		public ArticulationBody articulationBody { get => default; } // 0x000000018BF3E894-0x000000018BF3E924 
		public Vector2 lightmapCoord { get => default; } // 0x000000018BF3E9B4-0x000000018BF3EB20 
		public Vector2 textureCoord1 { get => default; } // 0x000000018BF3ED40-0x000000018BF3ED50 
	
		// Methods
		private static Vector2 CalculateRaycastTexCoord(Collider collider, int m_Index, Vector2 uv, Vector3 pos, uint face, int textcoord) => default; // 0x000000018BF3E848-0x000000018BF3E894
		private static void CalculateRaycastTexCoord_Injected(Collider collider, int m_Index, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret) {
			ret = default;
		} // 0x000000018BF3E7E8-0x000000018BF3E848
	}

	public class Rigidbody : Component // TypeDefIndex: 59035
	{
		// Properties
		public Vector3 velocity { get => default; set {} } // 0x00000001845029D0-0x0000000184502A00 0x000000018BF40750-0x000000018BF40764
		public Vector3 angularVelocity { get => default; set {} } // 0x0000000184501CF0-0x0000000184501D20 0x000000018BF40228-0x000000018BF4023C
		public float drag { get => default; set {} } // 0x0000000184502A50-0x0000000184502A90 0x000000018BF40358-0x000000018BF4039C
		public float angularDrag { get => default; set {} } // 0x000000018BF3FC10-0x000000018BF3FC44 0x000000018BF401A0-0x000000018BF401E4
		public float mass { get => default; set {} } // 0x000000018BF3FECC-0x000000018BF3FF00 0x000000018BF404D0-0x000000018BF40514
		public bool useGravity { get => default; set {} } // 0x000000018BF400FC-0x000000018BF40130 0x000000018BF406C8-0x000000018BF4070C
		public float maxDepenetrationVelocity { get => default; set {} } // 0x000000018BF3FF34-0x000000018BF3FF68 0x000000018BF40558-0x000000018BF4059C
		public bool isKinematic { get => default; set {} } // 0x000000018BF3FE98-0x000000018BF3FECC 0x0000000184501B00-0x0000000184501B50
		public bool freezeRotation { get => default; set {} } // 0x000000018BF3FD50-0x000000018BF3FD84 0x000000018BF4039C-0x000000018BF403E0
		public RigidbodyConstraints constraints { get => default; set {} } // 0x000000018BF3FCE8-0x000000018BF3FD1C 0x000000018BF402D4-0x000000018BF40314
		public CollisionDetectionMode collisionDetectionMode { get => default; set {} } // 0x000000018BF3FCB4-0x000000018BF3FCE8 0x000000018BF40294-0x000000018BF402D4
		public Vector3 centerOfMass { get => default; set {} } // 0x000000018BF3FC88-0x000000018BF3FCB4 0x000000018BF40280-0x000000018BF40294
		public Vector3 worldCenterOfMass { get => default; } // 0x000000018BF40174-0x000000018BF401A0 
		public Quaternion inertiaTensorRotation { get => default; set {} } // 0x000000018BF3FDC8-0x000000018BF3FDF4 0x000000018BF40424-0x000000018BF40438
		public Vector3 inertiaTensor { get => default; set {} } // 0x000000018BF3FE38-0x000000018BF3FE64 0x000000018BF4047C-0x000000018BF40490
		public bool detectCollisions { get => default; set {} } // 0x000000018BF3FD1C-0x000000018BF3FD50 0x000000018BF40314-0x000000018BF40358
		public Vector3 position { get => default; set {} } // 0x000000018BF3FFAC-0x000000018BF3FFD8 0x000000018646E5BC-0x000000018646E5D0
		public Quaternion rotation { get => default; set {} } // 0x000000018BF4001C-0x000000018BF40048 0x000000018BF405E0-0x000000018BF405F4
		public RigidbodyInterpolation interpolation { get => default; set {} } // 0x000000018BF3FE64-0x000000018BF3FE98 0x000000018BF40490-0x000000018BF404D0
		public int solverIterations { get => default; set {} } // 0x000000018BF40088-0x000000018BF400BC 0x000000018BF40640-0x000000018BF40680
		public float sleepThreshold { get => default; set {} } // 0x000000018BF40048-0x000000018BF4007C 0x000000018BF405F4-0x000000018BF40638
		public float maxAngularVelocity { get => default; set {} } // 0x000000018BF3FF00-0x000000018BF3FF34 0x000000018BF40514-0x000000018BF40558
		public int solverVelocityIterations { get => default; set {} } // 0x000000018BF400C8-0x000000018BF400FC 0x000000018BF40688-0x000000018BF406C8
		public float sleepVelocity { get => default; set {} } // 0x0000000185FE6C30-0x0000000185FE6C40 0x0000000185492010-0x0000000185492020
		public float sleepAngularVelocity { get => default; set {} } // 0x0000000185FE6C30-0x0000000185FE6C40 0x0000000185492010-0x0000000185492020
		public bool useConeFriction { get => default; set {} } // 0x0000000185FAFEF0-0x0000000185FAFF00 0x0000000185492010-0x0000000185492020
		public int solverIterationCount { get => default; set {} } // 0x000000018BF4007C-0x000000018BF40088 0x000000018BF40638-0x000000018BF40640
		public int solverVelocityIterationCount { get => default; set {} } // 0x000000018BF400BC-0x000000018BF400C8 0x000000018BF40680-0x000000018BF40688
	
		// Constructors
		public Rigidbody() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void SetDensity(float density) {} // 0x000000018BF3F7FC-0x000000018BF3F840
		public void MovePosition(Vector3 position) {} // 0x000000018BF3F728-0x000000018BF3F73C
		public void MoveRotation(Quaternion rot) {} // 0x000000018BF3F780-0x000000018BF3F794
		public void Sleep() {} // 0x000000018BF3F848-0x000000018BF3F87C
		public bool IsSleeping() => default; // 0x00000001845021E0-0x0000000184502220
		public void WakeUp() {} // 0x000000018BF3FBDC-0x000000018BF3FC10
		public void ResetCenterOfMass() {} // 0x000000018BF3F794-0x000000018BF3F7C8
		public void ResetInertiaTensor() {} // 0x000000018BF3F7C8-0x000000018BF3F7FC
		public Vector3 GetRelativePointVelocity(Vector3 relativePoint) => default; // 0x000000018BF3F5B8-0x000000018BF3F5EC
		public Vector3 GetPointVelocity(Vector3 worldPoint) => default; // 0x000000018BF3F530-0x000000018BF3F564
		public void AddForce(Vector3 force, ForceMode mode) {} // 0x000000018BF3F16C-0x000000018BF3F180
		public void AddForce(Vector3 force) {} // 0x000000018BF3F140-0x000000018BF3F16C
		public void AddForce(float x, float y, float z, ForceMode mode) {} // 0x000000018BF3F114-0x000000018BF3F140
		public void AddForce(float x, float y, float z) {} // 0x000000018BF3F180-0x000000018BF3F1A8
		public void AddRelativeForce(Vector3 force, ForceMode mode) {} // 0x000000018BF3F250-0x000000018BF3F264
		public void AddRelativeForce(Vector3 force) {} // 0x000000018BF3F1FC-0x000000018BF3F228
		public void AddRelativeForce(float x, float y, float z, ForceMode mode) {} // 0x000000018BF3F264-0x000000018BF3F290
		public void AddRelativeForce(float x, float y, float z) {} // 0x000000018BF3F228-0x000000018BF3F250
		public void AddTorque(Vector3 torque, ForceMode mode) {} // 0x000000018BF3F3EC-0x000000018BF3F400
		public void AddTorque(Vector3 torque) {} // 0x000000018BF3F3C0-0x000000018BF3F3EC
		public void AddTorque(float x, float y, float z, ForceMode mode) {} // 0x000000018BF3F428-0x000000018BF3F454
		public void AddTorque(float x, float y, float z) {} // 0x000000018BF3F400-0x000000018BF3F428
		public void AddRelativeTorque(Vector3 torque, ForceMode mode) {} // 0x000000018BF3F33C-0x000000018BF3F350
		public void AddRelativeTorque(Vector3 torque) {} // 0x000000018BF3F310-0x000000018BF3F33C
		public void AddRelativeTorque(float x, float y, float z, ForceMode mode) {} // 0x000000018BF3F2E4-0x000000018BF3F310
		public void AddRelativeTorque(float x, float y, float z) {} // 0x000000018BF3F350-0x000000018BF3F36C
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) {} // 0x000000018BF3F060-0x000000018BF3F078
		public void AddForceAtPosition(Vector3 force, Vector3 position) {} // 0x000000018BF3F078-0x000000018BF3F0C0
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) {} // 0x000000018BF3EFD0-0x000000018BF3EFFC
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier) {} // 0x000000018BF3EF90-0x000000018BF3EFD0
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius) {} // 0x000000018BF3EF54-0x000000018BF3EF90
		private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) {} // 0x000000018BF3F650-0x000000018BF3F668
		public Vector3 ClosestPointOnBounds(Vector3 position) => default; // 0x000000018BF3F454-0x000000018BF3F4DC
		private RaycastHit SweepTest(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit) => default; // 0x000000018BF3FA3C-0x000000018BF3FAB0
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3FAE8-0x000000018BF3FBDC
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3FA0C-0x000000018BF3FA3C
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x000000018BF3FAB0-0x000000018BF3FAE8
		private RaycastHit[] Internal_SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3F6CC-0x000000018BF3F6E4
		public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3F8AC-0x000000018BF3F970
		public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance) => default; // 0x000000018BF3F87C-0x000000018BF3F8AC
		public RaycastHit[] SweepTestAll(Vector3 direction) => default; // 0x000000018BF3F970-0x000000018BF3F9A8
		public void SetMaxAngularVelocity(float a) {} // 0x000000018BF3F840-0x000000018BF3F848
		private void get_velocity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000184502A00-0x0000000184502A50
		private void set_velocity_Injected(ref Vector3 value) {} // 0x000000018BF4070C-0x000000018BF40750
		private void get_angularVelocity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000184501AB0-0x0000000184501B00
		private void set_angularVelocity_Injected(ref Vector3 value) {} // 0x000000018BF401E4-0x000000018BF40228
		private void get_centerOfMass_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BF3FC44-0x000000018BF3FC88
		private void set_centerOfMass_Injected(ref Vector3 value) {} // 0x000000018BF4023C-0x000000018BF40280
		private void get_worldCenterOfMass_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BF40130-0x000000018BF40174
		private void get_inertiaTensorRotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x000000018BF3FD84-0x000000018BF3FDC8
		private void set_inertiaTensorRotation_Injected(ref Quaternion value) {} // 0x000000018BF403E0-0x000000018BF40424
		private void get_inertiaTensor_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BF3FDF4-0x000000018BF3FE38
		private void set_inertiaTensor_Injected(ref Vector3 value) {} // 0x000000018BF40438-0x000000018BF4047C
		private void get_position_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BF3FF68-0x000000018BF3FFAC
		private void set_position_Injected(ref Vector3 value) {} // 0x0000000185523490-0x00000001855235A0
		private void get_rotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x000000018BF3FFD8-0x000000018BF4001C
		private void set_rotation_Injected(ref Quaternion value) {} // 0x000000018BF4059C-0x000000018BF405E0
		private void MovePosition_Injected(ref Vector3 position) {} // 0x000000018BF3F6E4-0x000000018BF3F728
		private void MoveRotation_Injected(ref Quaternion rot) {} // 0x000000018BF3F73C-0x000000018BF3F780
		private void GetRelativePointVelocity_Injected(ref Vector3 relativePoint, out Vector3 ret) {
			ret = default;
		} // 0x000000018BF3F564-0x000000018BF3F5B8
		private void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret) {
			ret = default;
		} // 0x000000018BF3F4DC-0x000000018BF3F530
		private void AddForce_Injected(ref Vector3 force, ForceMode mode) {} // 0x000000018BF3F0C0-0x000000018BF3F114
		private void AddRelativeForce_Injected(ref Vector3 force, ForceMode mode) {} // 0x000000018BF3F1A8-0x000000018BF3F1FC
		private void AddTorque_Injected(ref Vector3 torque, ForceMode mode) {} // 0x000000018BF3F36C-0x000000018BF3F3C0
		private void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) {} // 0x000000018BF3F290-0x000000018BF3F2E4
		private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) {} // 0x000000018BF3EFFC-0x000000018BF3F060
		private void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) {} // 0x000000018BF3EEF0-0x000000018BF3EF54
		private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) {} // 0x000000018BF3F5EC-0x000000018BF3F650
		private void SweepTest_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x000000018BF3F9A8-0x000000018BF3FA0C
		private RaycastHit[] Internal_SweepTestAll_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3F668-0x000000018BF3F6CC
	}

	public enum ECSColliderType // TypeDefIndex: 59036
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

	public class Collider : Component // TypeDefIndex: 59037
	{
		// Properties
		public bool enabled { get => default; set {} } // 0x000000018435A3F0-0x000000018435A430 0x00000001848C1EF0-0x00000001848C1F40
		public Rigidbody attachedRigidbody { get => default; } // 0x000000018BF3438C-0x000000018BF343C0 
		public ArticulationBody attachedArticulationBody { get => default; } // 0x000000018BF34358-0x000000018BF3438C 
		public bool isTrigger { get => default; set {} } // 0x00000001845014F0-0x00000001845015D0 0x00000001846BDCA0-0x00000001846BDCF0
		public bool enableDither { get => default; } // 0x000000018BF34468-0x000000018BF3449C 
		public float contactOffset { get => default; set {} } // 0x000000018BF34434-0x000000018BF34468 0x000000018BF345A0-0x000000018BF345E4
		public Bounds bounds { get => default; } // 0x000000018BF34404-0x000000018BF34434 
		public bool hasModifiableContacts { get => default; set {} } // 0x000000018BF3449C-0x000000018BF344D0 0x000000018BF345E4-0x000000018BF34628
		public ColliderSurfaceType surfaceType { get => default; set {} } // 0x000000018BF34538-0x000000018BF3456C 0x000000018BF3466C-0x000000018BF346AC
		public int tagConfig { get => default; set {} } // 0x000000018BF3456C-0x000000018BF345A0 0x000000018BF346AC-0x000000018BF346EC
		public int colliderOptions { get => default; set {} } // 0x00000001848CC7A0-0x00000001848CC7E0 0x00000001848CC920-0x00000001848CC970
		public PhysicMaterial sharedMaterial { get => default; set {} } // 0x000000018BF34504-0x000000018BF34538 0x000000018BF34628-0x000000018BF3466C
		public PhysicMaterial material { get => default; set {} } // 0x000000018BF344D0-0x000000018BF34504 0x000000018435ACD0-0x000000018435AD20
	
		// Constructors
		public Collider() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public Vector3 ClosestPoint(Vector3 position) => default; // 0x000000018BF34004-0x000000018BF34038
		public IntPtr GetActor() => default; // 0x000000018435B1D0-0x000000018435B210
		public int GetComponentIndex() => default; // 0x0000000185261D20-0x0000000185261D60
		public int GetFactoryBuildingIdentifier() => default; // 0x000000018BF34038-0x000000018BF3406C
		public void SetFactoryBuildingIdentifier(int value) {} // 0x000000018BF34224-0x000000018BF34264
		private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) => default; // 0x000000018BF3414C-0x000000018BF341B0
		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x000000018BF341B0-0x000000018BF34224
		private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) {} // 0x000000018BF340D0-0x000000018BF340E8
		public Vector3 ClosestPointOnBounds(Vector3 position) => default; // 0x000000018BF33F28-0x000000018BF33FB0
		public bool CanColliderComputeClosestPoint() => default; // 0x000000018BF33EF4-0x000000018BF33F28
		private Vector3 TryGetClosestPoint_Internal(Vector3 point, ref bool resultIsValid) => default; // 0x000000018BF342C8-0x000000018BF34304
		public bool TryGetClosestPoint(Vector3 point, out Vector3 result) {
			result = default;
			return default;
		} // 0x000000018BF34304-0x000000018BF34358
		private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) {
			ret = default;
		} // 0x000000018BF33FB0-0x000000018BF34004
		private void get_bounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x000000018BF343C0-0x000000018BF34404
		private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x000000018BF340E8-0x000000018BF3414C
		private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) {} // 0x000000018BF3406C-0x000000018BF340D0
		private void TryGetClosestPoint_Internal_Injected(ref Vector3 point, ref bool resultIsValid, out Vector3 ret) {
			ret = default;
		} // 0x000000018BF34264-0x000000018BF342C8
	}

	public class ECSCollider // TypeDefIndex: 59039
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
		public delegate void CollisionCallback(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider); // TypeDefIndex: 59038; 0x000000018BF35878-0x000000018BF358B8
	
		// Constructors
		public ECSCollider() {} // Dummy constructor
	
		// Methods
		public static IntPtr CreateActor(Vector3 position, Quaternion rotation, uint layer, int tagInt, bool movable) => default; // 0x0000000184094E70-0x0000000184094EE0
		public static void DestroyActor(int id, uint version) {} // 0x0000000184094DD0-0x0000000184094E70
		public static IntPtr Decode(IntPtr data, int length, IntPtr meshes, int meshesCount, Texture2D heightmaps) => default; // 0x000000018646D974-0x000000018646D9CC
		public static IntPtr Decode(IntPtr data, int length, NativeArray<int> meshInstanceIds, Texture2D heightmap) => default; // 0x0000000184094210-0x0000000184094250
		public static void RecordEntity(IntPtr actor, Entity entity) {} // 0x00000001840941D0-0x0000000184094210
		public static int GetId(IntPtr actor) => default; // 0x0000000184295980-0x00000001842959E0
		public static uint GetVersion(IntPtr actor) => default; // 0x0000000185A38CB0-0x0000000185A38D10
		public static bool IsValid(int id, uint version, IntPtr actor) => default; // 0x0000000185D65E60-0x0000000185D65E90
		public static Entity GetEntity(int id, uint version) => default; // 0x00000001842894A0-0x0000000184289670
		public static Vector3 GetPosition(int ecsId, uint ecsVersion) => default; // 0x000000018646F560-0x000000018646F574
		public static Vector3 GetShapePosition(int ecsId, uint ecsVersion, int index) => default; // 0x000000018BF35968-0x000000018BF359A4
		public static void SetPosition(int ecsId, uint ecsVersion, Vector3 position) {} // 0x0000000185D6B470-0x0000000185D6B4A0
		public static Quaternion GetShapeRotation(int ecsId, uint ecsVersion, int index) => default; // 0x000000018646F574-0x000000018646F588
		public static Quaternion GetRotation(int ecsId, uint ecsVersion) => default; // 0x000000018BF354AC-0x000000018BF3550C
		public static void SetRotation(int ecsId, uint ecsVersion, Quaternion rotation) {} // 0x0000000184295C60-0x0000000184295CB0
		public static void AttachBox(int id, uint version, Vector3 halfExtent, Vector3 localPosition, Quaternion localRotation, int surfaceType, int colliderOption, int tag, bool isTrigger, bool isPrimitive) {} // 0x000000018BF35EC4-0x000000018BF35F38
		public static bool HasComplexMesh(int id, uint version) => default; // 0x000000018BF35F38-0x000000018BF35FC4
		private static RaycastHit Raycast_Internal(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, ref bool hasHit) => default; // 0x000000018BF35D64-0x000000018BF35DD8
		public static bool Raycast(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x000000018BF35DD8-0x000000018BF35E64
		private static RaycastHit RaycastComplexMesh_Internal(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, ref bool hasHit) => default; // 0x000000018BF355AC-0x000000018BF35648
		public static bool RaycastComplexMesh(int ecsId, uint ecsVersion, Ray ray, float maxDistance, bool hitHoles, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x000000018BF35648-0x000000018BF35708
		private static RaycastHit CapsuleCastComplexMesh_Internal(int ecsId, uint ecsVersion, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, ref bool hasHit) => default; // 0x000000018BF36024-0x000000018BF360B0
		public static bool CapsuleCastComplexMesh(int ecsId, uint ecsVersion, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x000000018BF360B0-0x000000018BF36160
		private static RaycastHit SphereCastComplexMesh_Internal(int ecsId, uint ecsVersion, Vector3 center, float radius, Vector3 direction, float maxDistance, ref bool hasHit) => default; // 0x000000018BF3550C-0x000000018BF3554C
		public static bool SphereCastComplexMesh(int ecsId, uint ecsVersion, Vector3 center, float radius, Vector3 direction, float maxDistance, out RaycastHit hitInfo) {
			hitInfo = default;
			return default;
		} // 0x00000001847F99E0-0x00000001847F9A40
		public static bool CanColliderComputeClosestPoint(int ecsId, uint ecsVersion) => default; // 0x0000000184295B50-0x0000000184295BB0
		public static ColliderSurfaceType GetSurfaceTypeAt(int ecsId, uint ecsVersion, int index) => default; // 0x0000000184297B40-0x0000000184297BA0
		public static int GetColliderOptionAt(int ecsId, uint ecsVersion, int index) => default; // 0x000000018BF358B8-0x000000018BF35908
		public static int GetTagConfigAt(int ecsId, uint ecsVersion, int index) => default; // 0x00000001851D2200-0x00000001851D2240
		public static bool GetIsTrigger(int ecsId, uint ecsVersion, int index) => default; // 0x000000018BF361C0-0x000000018BF36200
		public static Bounds GetBounds(int ecsId, uint ecsVersion) => default; // 0x000000018BF36200-0x000000018BF3625C
		private static Vector3 TryGetClosestPoint_Internal(int ecsId, uint ecsVersion, Vector3 point, ref bool resultIsValid) => default; // 0x000000018BF35768-0x000000018BF357A4
		public static bool TryGetClosestPoint(int ecsId, uint ecsVersion, Vector3 point, out Vector3 result) {
			result = default;
			return default;
		} // 0x000000018BF357A4-0x000000018BF357F4
		public static Vector3 ClosestPoint(int ecsId, uint ecsVersion, Vector3 position) => default; // 0x00000001847FBAB0-0x00000001847FBB00
		public static bool CompareTag(int ecsId, uint ecsVersion, int tagValue) => default; // 0x000000018437D1B0-0x000000018437D200
		public static int GetLayer(int ecsId, uint ecsVersion) => default; // 0x0000000184092D70-0x0000000184092DD0
		public static int GetFactoryBuildingIdentifier(int ecsId, uint ecsVersion) => default; // 0x000000018BF359A4-0x000000018BF35A34
		public static void SetFactoryBuildingIdentifier(int ecsId, uint ecsVersion, int identifier) {} // 0x000000018BF35AC4-0x000000018BF35B54
		private static void OnCollisionEnterV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider) {} // 0x000000018BF35A34-0x000000018BF35AC4
		private static void OnCollisionStayV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider) {} // 0x000000018BF35B54-0x000000018BF35BE4
		private static void OnCollisionExitV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider) {} // 0x000000018BF35C74-0x000000018BF35D04
		private static void OnTriggerEnterV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider) {} // 0x000000018BF35BE4-0x000000018BF35C74
		private static void OnTriggerStayV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider) {} // 0x0000000184FF6F00-0x0000000184FF6F60
		private static void OnTriggerExitV2(ECSColliderResultProxy thisCollider, ECSColliderResultProxy otherCollider) {} // 0x000000018BF357F4-0x000000018BF35858
		public static void ToggleCollision(int id, uint version, bool enableCollision) {} // 0x00000001852A4110-0x00000001852A4160
		private static IntPtr CreateActor_Injected(ref Vector3 position, ref Quaternion rotation, uint layer, int tagInt, bool movable) => default; // 0x0000000185A38D10-0x0000000185A38D70
		private static void RecordEntity_Injected(IntPtr actor, ref Entity entity) {} // 0x0000000185D65E90-0x0000000185D65EF0
		private static void GetEntity_Injected(int id, uint version, out Entity ret) {
			ret = default;
		} // 0x0000000184289430-0x00000001842894A0
		private static void GetPosition_Injected(int ecsId, uint ecsVersion, out Vector3 ret) {
			ret = default;
		} // 0x000000018515D2B0-0x000000018515D310
		private static void GetShapePosition_Injected(int ecsId, uint ecsVersion, int index, out Vector3 ret) {
			ret = default;
		} // 0x000000018BF35908-0x000000018BF35968
		private static void SetPosition_Injected(int ecsId, uint ecsVersion, ref Vector3 position) {} // 0x0000000185D6B4A0-0x0000000185D6B500
		private static void GetShapeRotation_Injected(int ecsId, uint ecsVersion, int index, out Quaternion ret) {
			ret = default;
		} // 0x000000018515D250-0x000000018515D2B0
		private static void GetRotation_Injected(int ecsId, uint ecsVersion, out Quaternion ret) {
			ret = default;
		} // 0x000000018BF3544C-0x000000018BF354AC
		private static void SetRotation_Injected(int ecsId, uint ecsVersion, ref Quaternion rotation) {} // 0x000000018BF35E64-0x000000018BF35EC4
		private static void AttachBox_Injected(int id, uint version, ref Vector3 halfExtent, ref Vector3 localPosition, ref Quaternion localRotation, int surfaceType, int colliderOption, int tag, bool isTrigger, bool isPrimitive) {} // 0x000000018BF35D04-0x000000018BF35D64
		private static void Raycast_Internal_Injected(int ecsId, uint ecsVersion, ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x000000018BF3554C-0x000000018BF355AC
		private static void RaycastComplexMesh_Internal_Injected(int ecsId, uint ecsVersion, ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x000000018BF35FC4-0x000000018BF36024
		private static void CapsuleCastComplexMesh_Internal_Injected(int ecsId, uint ecsVersion, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x00000001851D2240-0x00000001851D22A0
		private static void SphereCastComplexMesh_Internal_Injected(int ecsId, uint ecsVersion, ref Vector3 center, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x000000018BF36160-0x000000018BF361C0
		private static void GetBounds_Injected(int ecsId, uint ecsVersion, out Bounds ret) {
			ret = default;
		} // 0x000000018BF35708-0x000000018BF35768
		private static void TryGetClosestPoint_Internal_Injected(int ecsId, uint ecsVersion, ref Vector3 point, ref bool resultIsValid, out Vector3 ret) {
			ret = default;
		} // 0x000000018BF34738-0x000000018BF34800
		private static void ClosestPoint_Injected(int ecsId, uint ecsVersion, ref Vector3 position, out Vector3 ret) {
			ret = default;
		} // 0x000000018BF346EC-0x000000018BF34738
	}

	public class CharacterController : Collider // TypeDefIndex: 59040
	{
		// Properties
		public bool isGrounded { get => default; } // 0x000000018BF33EC0-0x000000018BF33EF4 
	
		// Constructors
		public CharacterController() {} // Dummy constructor
	}

	public class MultiCollider : Collider // TypeDefIndex: 59041
	{
		// Properties
		public Mesh ComplexMesh { get => default; } // 0x000000018BF36A64-0x000000018BF36A98 
	
		// Constructors
		public MultiCollider() {} // Dummy constructor
	
		// Methods
		public void AppendBoxCollider(BoxCollider boxCollider) {} // 0x000000018BF3643C-0x000000018BF36480
		public void AppendCapsuleCollider(CapsuleCollider collider) {} // 0x000000018BF36480-0x000000018BF364C4
		public void AppendSphereCollider(SphereCollider collider) {} // 0x000000018BF364C4-0x000000018BF36508
		public ColliderSurfaceType GetSurfaceTypeAt(int index) => default; // 0x000000018BF36794-0x000000018BF367D4
		public int GetTagConfigAt(int index) => default; // 0x000000018BF367D4-0x000000018BF36814
		public int GetGameplayOptionAt(int index) => default; // 0x000000018BF36714-0x000000018BF36754
		public bool GetIsTriggerAt(int index) => default; // 0x000000018BF36754-0x000000018BF36794
		public void SetGameplayOptionAt(int index, int value) {} // 0x000000018BF36890-0x000000018BF368E0
		public void Flush() {} // 0x000000018BF366AC-0x000000018BF366E0
		public bool RaycastComplexMesh(Ray ray, float maxDistance, ref RaycastHit hit) => default; // 0x000000018BF36878-0x000000018BF36890
		private RaycastHit CapsuleCastComplexMesh_Internal(Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, ref bool hasHit) => default; // 0x000000018BF3656C-0x000000018BF365FC
		public bool CapsuleCastComplexMesh(Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, out RaycastHit hit) {
			hit = default;
			return default;
		} // 0x000000018BF365FC-0x000000018BF366AC
		private RaycastHit SphereCastComplexMesh_Internal(Vector3 center, float radius, Vector3 direction, float maxDistance, ref bool hasHit) => default; // 0x000000018BF36944-0x000000018BF369C4
		public bool SphereCastComplexMesh(Vector3 center, float radius, Vector3 direction, float maxDistance, out RaycastHit hit) {
			hit = default;
			return default;
		} // 0x000000018BF369C4-0x000000018BF36A64
		public int GetCountWithoutComplexMesh() => default; // 0x000000018BF366E0-0x000000018BF36714
		private bool RaycastComplexMesh_Injected(ref Ray ray, float maxDistance, ref RaycastHit hit) => default; // 0x000000018BF36814-0x000000018BF36878
		private void CapsuleCastComplexMesh_Internal_Injected(ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x000000018BF36508-0x000000018BF3656C
		private void SphereCastComplexMesh_Internal_Injected(ref Vector3 center, float radius, ref Vector3 direction, float maxDistance, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x000000018BF368E0-0x000000018BF36944
	}

	public class MeshCollider : Collider // TypeDefIndex: 59042
	{
		// Properties
		public Mesh sharedMesh { get => default; set {} } // 0x000000018BF36384-0x000000018BF363B8 0x0000000185AD1FB0-0x0000000185AD2050
		public bool convex { get => default; set {} } // 0x000000018BF3631C-0x000000018BF36350 0x000000018BF363B8-0x000000018BF363FC
		public MeshColliderCookingOptions cookingOptions { get => default; set {} } // 0x000000018BF36350-0x000000018BF36384 0x000000018BF363FC-0x000000018BF3643C
		public bool smoothSphereCollisions { get => default; set {} } // 0x0000000185FC71B0-0x0000000185FC71C0 0x0000000185492010-0x0000000185492020
		public float skinWidth { get => default; set {} } // 0x0000000185FE6C30-0x0000000185FE6C40 0x0000000185492010-0x0000000185492020
		public bool inflateMesh { get => default; set {} } // 0x0000000185FAFEF0-0x0000000185FAFF00 0x0000000185492010-0x0000000185492020
	
		// Constructors
		public MeshCollider() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public bool NeedsReadWriteEnabled() => default; // 0x000000018BF362E8-0x000000018BF3631C
	}

	public class CapsuleCollider : Collider // TypeDefIndex: 59043
	{
		// Properties
		public Vector3 center { get => default; set {} } // 0x00000001841EFB80-0x00000001841EFBE0 0x000000018646E928-0x000000018646E93C
		public float radius { get => default; set {} } // 0x00000001842D9760-0x00000001842D97A0 0x000000018435ABE0-0x000000018435AC30
		public float height { get => default; set {} } // 0x00000001842D97A0-0x00000001842D97E0 0x000000018435AC30-0x000000018435AC80
		public int direction { get => default; set {} } // 0x00000001841EFC30-0x00000001841EFC70 0x000000018435AC80-0x000000018435ACD0
	
		// Constructors
		public CapsuleCollider() {} // Dummy constructor
	
		// Methods
		private void get_center_Injected(out Vector3 ret) {
			ret = default;
		} // 0x00000001841EFBE0-0x00000001841EFC30
		private void set_center_Injected(ref Vector3 value) {} // 0x00000001856982A0-0x00000001856982F0
	}

	public class BoxCollider : Collider // TypeDefIndex: 59044
	{
		// Properties
		public Vector3 center { get => default; set {} } // 0x000000018BF33B4C-0x000000018BF33B78 0x000000018646FC2C-0x000000018646FC40
		public Vector3 size { get => default; set {} } // 0x00000001846BCF60-0x00000001846BCF90 0x000000018646FC18-0x000000018646FC2C
	
		// Constructors
		public BoxCollider() {} // Dummy constructor
	
		// Methods
		private void get_center_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BF33B08-0x000000018BF33B4C
		private void set_center_Injected(ref Vector3 value) {} // 0x0000000184D86730-0x0000000184D86780
		private void get_size_Injected(out Vector3 ret) {
			ret = default;
		} // 0x00000001846BCF90-0x00000001846BCFE0
		private void set_size_Injected(ref Vector3 value) {} // 0x0000000184D866E0-0x0000000184D86730
	}

	public class SphereCollider : Collider // TypeDefIndex: 59045
	{
		// Properties
		public Vector3 center { get => default; set {} } // 0x000000018BF407A8-0x000000018BF407D4 0x000000018BF4084C-0x000000018BF40860
		public float radius { get => default; set {} } // 0x000000018BF407D4-0x000000018BF40808 0x00000001848CC880-0x00000001848CC8D0
	
		// Constructors
		public SphereCollider() {} // Dummy constructor
	
		// Methods
		private void get_center_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BF40764-0x000000018BF407A8
		private void set_center_Injected(ref Vector3 value) {} // 0x000000018BF40808-0x000000018BF4084C
	}

	public class Joint : Component // TypeDefIndex: 59046
	{
		// Properties
		public Rigidbody connectedBody { get => default; } // 0x000000018BF3625C-0x000000018BF36290 
		public Vector3 connectedAnchor { set {} } // 0x000000018BF362D4-0x000000018BF362E8
	
		// Constructors
		public Joint() {} // Dummy constructor
	
		// Methods
		private void set_connectedAnchor_Injected(ref Vector3 value) {} // 0x000000018BF36290-0x000000018BF362D4
	}

	public struct ContactPoint // TypeDefIndex: 59047
	{
		// Fields
		internal Vector3 m_Point; // 0x00
		internal Vector3 m_Normal; // 0x0C
		internal int m_ThisColliderInstanceID; // 0x18
		internal int m_OtherColliderInstanceID; // 0x1C
		internal float m_Separation; // 0x20
	
		// Properties
		public Vector3 point { get => default; } // 0x0000000185FE65B0-0x0000000185FE65D0 
		public Vector3 normal { get => default; } // 0x0000000185FE6590-0x0000000185FE65B0 
		public Collider thisCollider { get => default; } // 0x000000018BF3491C-0x000000018BF34928 
		public Collider otherCollider { get => default; } // 0x000000018BF34910-0x000000018BF3491C 
	
		// Methods
		private static Collider GetColliderByInstanceID(int instanceID) => default; // 0x000000018BF348DC-0x000000018BF34910
	}

	public struct PhysicsScene : IEquatable<UnityEngine.PhysicsScene> // TypeDefIndex: 59048
	{
		// Fields
		private int m_Handle; // 0x00
	
		// Methods
		public override string ToString() => default; // 0x000000018BF37A54-0x000000018BF37B04
		public override int GetHashCode() => default; // 0x0000000185FE64F0-0x0000000185FE6500
		public override bool Equals(object other) => default; // 0x000000018BF36D6C-0x000000018BF36DD0
		public bool Equals(PhysicsScene other) => default; // 0x0000000183FAA6E0-0x0000000183FAA6F0
		public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = 1F / 0F /* Metadata: 0x020803A3 */, int layerMask = -5 /* Metadata: 0x020803A7 */, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x020803A8 */) => default; // 0x000000018BF3795C-0x000000018BF37A54
		private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF37140-0x000000018BF37168
		public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = 1F / 0F /* Metadata: 0x020803A9 */, int layerMask = -5 /* Metadata: 0x020803AD */, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x020803AE */) {
			hitInfo = default;
			return default;
		} // 0x0000000184291CF0-0x0000000184291F80
		private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018646E510-0x000000018646E540
		public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = 1F / 0F /* Metadata: 0x020803AF */, int layerMask = -5 /* Metadata: 0x020803B3 */, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x020803B4 */) => default; // 0x0000000184291990-0x0000000184291CF0
		private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018646E4A4-0x000000018646E4D4
		private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF378FC-0x000000018BF3795C
		private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x000000018BF36FBC-0x000000018BF370DC
		public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = 1F / 0F /* Metadata: 0x020803B5 */, int layerMask = -5 /* Metadata: 0x020803B9 */, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x020803BA */) {
			hitInfo = default;
			return default;
		} // 0x000000018BF36CD0-0x000000018BF36D6C
		private static int Internal_CapsuleCastNonAlloc(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018646E9E8-0x000000018646EA48
		public int CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = 1F / 0F /* Metadata: 0x020803BB */, int layerMask = -5 /* Metadata: 0x020803BF */, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x020803C0 */) => default; // 0x0000000184380DF0-0x0000000184380F20
		private static int Internal_CapsuleCastNonAllocV2(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 diretion, ECSColliderResultProxy[] proxies, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF36F5C-0x000000018BF36FBC
		public int CapsuleCastV2(Vector3 point1, Vector3 point2, float radius, Vector3 direction, ECSColliderResultProxy[] proxies, float maxDistance = 1F / 0F /* Metadata: 0x020803C1 */, int layerMask = -5 /* Metadata: 0x020803C5 */, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x020803C6 */) => default; // 0x000000018BF36BDC-0x000000018BF36CD0
		private static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3747C-0x000000018BF374BC
		public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask = -1 /* Metadata: 0x020803C7 */, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x020803C8 */) => default; // 0x000000018BF374BC-0x000000018BF375A0
		private static int OverlapCapsuleNonAlloc_InternalV2(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x00000001864702BC-0x00000001864702FC
		public int OverlapCapsuleV2(Vector3 point0, Vector3 point1, float radius, ECSColliderResultProxy[] results, int layerMask = -1 /* Metadata: 0x020803C9 */, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x020803CA */) => default; // 0x00000001847FCE90-0x00000001847FCF40
		private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000186470268-0x00000001864702BC
		private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x00000001847FAD30-0x00000001847FAE70
		public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = 1F / 0F /* Metadata: 0x020803CB */, int layerMask = -5 /* Metadata: 0x020803CF */, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x020803D0 */) {
			hitInfo = default;
			return default;
		} // 0x00000001847FACB0-0x00000001847FAD30
		private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x00000001864702FC-0x0000000186470350
		public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = 1F / 0F /* Metadata: 0x020803D1 */, int layerMask = -5 /* Metadata: 0x020803D5 */, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x020803D6 */) => default; // 0x00000001847FD5F0-0x00000001847FD6F0
		private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF37698-0x000000018BF376C8
		public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF37710-0x000000018BF377D4
		private static int OverlapSphereNonAllocV2_Internal(PhysicsScene physicsScene, Vector3 position, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF37604-0x000000018BF37634
		public int OverlapSphereV2(Vector3 position, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF376C8-0x000000018BF37710
		private static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF37838-0x000000018BF37898
		private static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) {
			hitInfo = default;
			return default;
		} // 0x000000018BF36DD0-0x000000018BF36EF8
		public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance = 1F / 0F /* Metadata: 0x020803D7 */, int layerMask = -5 /* Metadata: 0x020803DB */, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x020803DC */) {
			hitInfo = default;
			return default;
		} // 0x000000018BF36B30-0x000000018BF36BDC
		private static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF37270-0x000000018BF372B0
		public int OverlapBox(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int layerMask = -5 /* Metadata: 0x020803DD */, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x020803DE */) => default; // 0x000000018BF37324-0x000000018BF37418
		private static int OverlapBoxNonAllocV2_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF371CC-0x000000018BF3720C
		public int OverlapBoxV2(Vector3 center, Vector3 halfExtents, ECSColliderResultProxy[] results, Quaternion orientation, int layerMask = -5 /* Metadata: 0x020803DF */, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x020803E0 */) => default; // 0x000000018BF372B0-0x000000018BF37324
		private static int Internal_BoxCastNonAlloc(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] raycastHits, Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018646DA60-0x000000018646DAC0
		public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance = 1F / 0F /* Metadata: 0x020803E1 */, int layerMask = -5 /* Metadata: 0x020803E5 */, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x020803E6 */) => default; // 0x00000001840B94D0-0x00000001840B9610
		private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF370DC-0x000000018BF37140
		private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000184C9D370-0x0000000184C9D3E0
		private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000184D81EB0-0x0000000184D81F20
		private static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF37898-0x000000018BF378FC
		private static int Internal_CapsuleCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000185315F40-0x0000000185315FB0
		private static int Internal_CapsuleCastNonAllocV2_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 diretion, ECSColliderResultProxy[] proxies, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF36EF8-0x000000018BF36F5C
		private static int OverlapCapsuleNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF37418-0x000000018BF3747C
		private static int OverlapCapsuleNonAlloc_InternalV2_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000184FC4190-0x0000000184FC4200
		private static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018531B430-0x000000018531B4A0
		private static int Internal_SphereCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x0000000184EE4090-0x0000000184EE4100
		private static int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF37634-0x000000018BF37698
		private static int OverlapSphereNonAllocV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF375A0-0x000000018BF37604
		private static bool Query_BoxCast_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF377D4-0x000000018BF37838
		private static int OverlapBoxNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, Collider[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF3720C-0x000000018BF37270
		private static int OverlapBoxNonAllocV2_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ECSColliderResultProxy[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018BF37168-0x000000018BF371CC
		private static int Internal_BoxCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, RaycastHit[] raycastHits, ref Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) => default; // 0x000000018502BD00-0x000000018502BD70
	}

	public struct QueryParameters // TypeDefIndex: 59049
	{
		// Fields
		public int layerMask; // 0x00
		public bool hitMultipleFaces; // 0x04
		public bool hitBackfaces; // 0x05
		public QueryTriggerInteraction hitTriggers; // 0x08
	
		// Constructors
		public QueryParameters(int layerMask = -5 /* Metadata: 0x020803E7 */, bool hitMultipleFaces = false /* Metadata: 0x020803E8 */, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal /* Metadata: 0x020803E9 */, bool hitBackfaces = false /* Metadata: 0x020803EA */) {
			this.layerMask = default;
			this.hitMultipleFaces = default;
			this.hitBackfaces = default;
			this.hitTriggers = default;
		} // 0x0000000185FE8E00-0x0000000185FE8E20
	}

	public struct RaycastCommand // TypeDefIndex: 59050
	{
		// Fields
		private Vector3 _from_k__BackingField; // 0x00
		private Vector3 _direction_k__BackingField; // 0x0C
		private float _distance_k__BackingField; // 0x18
		private PhysicsScene _physicsScene_k__BackingField; // 0x1C
		public QueryParameters queryParameters; // 0x20
	
		// Properties
		public Vector3 from { get; set; } // 0x0000000185FB7B80-0x0000000185FB7BA0 0x0000000185FB7BD0-0x0000000185FB7BE0
		public Vector3 direction { get; set; } // 0x0000000185FB7BA0-0x0000000185FB7BC0 0x0000000185FB7BE0-0x0000000185FB7BF0
		public float distance { get; set; } // 0x0000000181C9AC50-0x0000000181C9AC60 0x0000000181C9A5A0-0x0000000181C9A5B0
		public PhysicsScene physicsScene { get; set; } // 0x00000001813AE9D0-0x00000001813AE9E0
	
		// Constructors
		public RaycastCommand(Vector3 from, Vector3 direction, QueryParameters queryParameters, float distance = 3.4028235E+38f /* Metadata: 0x020803EB */) : this() {
			<from>k__BackingField = default;
			<direction>k__BackingField = default;
			<distance>k__BackingField = default;
			<physicsScene>k__BackingField = default;
			this.queryParameters = default;
		} // 0x00000001847C5D60-0x00000001847C5DC0
	
		// Methods
		public static JobHandle ScheduleBatch(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, int maxHits, JobHandle dependsOn = default) => default; // 0x000000018502D600-0x000000018502D7C0
		public static JobHandle ScheduleBatch(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn = default) => default; // 0x000000018502D580-0x000000018502D600
		private static unsafe JobHandle ScheduleRaycastBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits) => default; // 0x000000018502D7C0-0x000000018502D860
		private static unsafe void ScheduleRaycastBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out JobHandle ret) {
			ret = default;
		} // 0x000000018502D860-0x000000018502D8D0
	}

	public struct BoxcastCommand // TypeDefIndex: 59051
	{
		// Fields
		private Vector3 _center_k__BackingField; // 0x00
		private Vector3 _halfExtents_k__BackingField; // 0x0C
		private Quaternion _orientation_k__BackingField; // 0x18
		private Vector3 _direction_k__BackingField; // 0x28
		private float _distance_k__BackingField; // 0x34
		private PhysicsScene _physicsScene_k__BackingField; // 0x38
		public QueryParameters queryParameters; // 0x3C
	
		// Properties
		public Vector3 center { get; set; } // 0x0000000185FB7BD0-0x0000000185FB7BE0
		public Vector3 halfExtents { get; set; } // 0x0000000185FB7BE0-0x0000000185FB7BF0
		public Quaternion orientation { get; set; } // 0x0000000185FB30E0-0x0000000185FB30F0
		public Vector3 direction { get; set; } // 0x0000000185FB2400-0x0000000185FB2410
		public float distance { get; set; } // 0x0000000185FB8A50-0x0000000185FB8A60
		public PhysicsScene physicsScene { get; set; } // 0x00000001813E6F50-0x00000001813E6F60
	
		// Constructors
		public BoxcastCommand(Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, QueryParameters queryParameters, float distance = 3.4028235E+38f /* Metadata: 0x020803EF */) : this() {
			<center>k__BackingField = default;
			<halfExtents>k__BackingField = default;
			<orientation>k__BackingField = default;
			<direction>k__BackingField = default;
			<distance>k__BackingField = default;
			<physicsScene>k__BackingField = default;
			this.queryParameters = default;
		} // 0x000000018BF33E4C-0x000000018BF33EC0
	
		// Methods
		public static JobHandle ScheduleBatch(NativeArray<BoxcastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, int maxHits, JobHandle dependsOn = default) => default; // 0x000000018BF33BEC-0x000000018BF33D7C
		public static JobHandle ScheduleBatch(NativeArray<BoxcastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn = default) => default; // 0x000000018BF33B78-0x000000018BF33BEC
		private static unsafe JobHandle ScheduleBoxcastBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits) => default; // 0x000000018BF33DE0-0x000000018BF33E4C
		private static unsafe void ScheduleBoxcastBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out JobHandle ret) {
			ret = default;
		} // 0x000000018BF33D7C-0x000000018BF33DE0
	}
}
