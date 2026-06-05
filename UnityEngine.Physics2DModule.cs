/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;

// Image 103: UnityEngine.Physics2DModule.dll - Assembly: UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60654-60669

namespace UnityEngine
{
	public struct PhysicsScene2D : IEquatable<UnityEngine.PhysicsScene2D> // TypeDefIndex: 60655
	{
		// Fields
		private int m_Handle; // 0x00
	
		// Methods
		public override string ToString() => default; // 0x000000018BF33728-0x000000018BF337D8
		public override int GetHashCode() => default; // 0x0000000185FE64F0-0x0000000185FE6500
		public override bool Equals(object other) => default; // 0x000000018BF32F3C-0x000000018BF32FA0
		public bool Equals(PhysicsScene2D other) => default; // 0x0000000183FAA6E0-0x0000000183FAA6F0
		public RaycastHit2D Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter) => default; // 0x000000018BF33284-0x000000018BF332FC
		private static RaycastHit2D Linecast_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter) => default; // 0x000000018BF33234-0x000000018BF33284
		public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5 /* Metadata: 0x02082AAE */) => default; // 0x000000018BF335C0-0x000000018BF336A0
		public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) => default; // 0x000000018BF336A0-0x000000018BF33728
		private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) => default; // 0x000000018BF334C0-0x000000018BF33520
		public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) => default; // 0x000000018BF33520-0x000000018BF33570
		private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) => default; // 0x000000018BF33360-0x000000018BF333AC
		public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) => default; // 0x000000018BF33570-0x000000018BF335C0
		private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) => default; // 0x000000018BF33410-0x000000018BF3345C
		public RaycastHit2D GetRayIntersection(Ray ray, float distance, int layerMask = -5 /* Metadata: 0x02082AAF */) => default; // 0x000000018BF330E8-0x000000018BF33178
		private static RaycastHit2D GetRayIntersection_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) => default; // 0x000000018BF3309C-0x000000018BF330E8
		public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5 /* Metadata: 0x02082AB0 */) => default; // 0x000000018BF33178-0x000000018BF331D0
		private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) => default; // 0x000000018BF33004-0x000000018BF33038
		private static void Linecast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter, out RaycastHit2D ret) {
			ret = default;
		} // 0x000000018BF331D0-0x000000018BF33234
		private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) {
			ret = default;
		} // 0x000000018BF3345C-0x000000018BF334C0
		private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) => default; // 0x000000018BF332FC-0x000000018BF33360
		private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) => default; // 0x000000018BF333AC-0x000000018BF33410
		private static void GetRayIntersection_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, out RaycastHit2D ret) {
			ret = default;
		} // 0x000000018BF33038-0x000000018BF3309C
		private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) => default; // 0x000000018BF32FA0-0x000000018BF33004
	}

	public class Physics2D // TypeDefIndex: 60656
	{
		// Fields
		private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x00
	
		// Properties
		public static PhysicsScene2D defaultPhysicsScene { get => default; } // 0x0000000185FE67B0-0x0000000185FE67C0 
		public static Vector2 gravity { set {} } // 0x000000018BF32EF0-0x000000018BF32F3C
		public static bool queriesHitTriggers { get => default; } // 0x000000018BF32E90-0x000000018BF32EBC 
	
		// Constructors
		public Physics2D() {} // Dummy constructor
		static Physics2D() {} // 0x000000018BF32E04-0x000000018BF32E90
	
		// Methods
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask) => default; // 0x000000018BF32594-0x000000018BF326A8
		public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, int layerMask) => default; // 0x000000018BF324C8-0x000000018BF32594
		private static RaycastHit2D[] LinecastAll_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter) => default; // 0x000000018BF32464-0x000000018BF324C8
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) => default; // 0x000000018BF32D40-0x000000018BF32E04
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) => default; // 0x000000018BF32A84-0x000000018BF32B50
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) => default; // 0x000000018BF32894-0x000000018BF329C0
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) => default; // 0x000000018BF32C14-0x000000018BF32D40
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) => default; // 0x000000018BF326A8-0x000000018BF327D4
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) => default; // 0x000000018BF327D4-0x000000018BF32894
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) => default; // 0x000000018BF329C0-0x000000018BF32A84
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = 1F / 0F /* Metadata: 0x02082AB1 */) => default; // 0x000000018BF32B50-0x000000018BF32C14
		public static RaycastHit2D GetRayIntersection(Ray ray, float distance, int layerMask) => default; // 0x000000018BF32334-0x000000018BF32400
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) => default; // 0x000000018BF320FC-0x000000018BF32180
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) => default; // 0x000000018BF32070-0x000000018BF320FC
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) => default; // 0x000000018BF31FDC-0x000000018BF32070
		private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) => default; // 0x000000018BF31F64-0x000000018BF31FDC
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) => default; // 0x000000018BF322B0-0x000000018BF32334
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) => default; // 0x000000018BF32180-0x000000018BF32214
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) => default; // 0x000000018BF32214-0x000000018BF322B0
		private static void set_gravity_Injected(ref Vector2 value) {} // 0x000000018BF32EBC-0x000000018BF32EF0
		private static RaycastHit2D[] LinecastAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter) => default; // 0x000000018BF32400-0x000000018BF32464
		private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) => default; // 0x000000018BF31F00-0x000000018BF31F64
	}

	public enum RigidbodyInterpolation2D // TypeDefIndex: 60657
	{
		None = 0,
		Interpolate = 1,
		Extrapolate = 2
	}

	public enum RigidbodySleepMode2D // TypeDefIndex: 60658
	{
		NeverSleep = 0,
		StartAwake = 1,
		StartAsleep = 2
	}

	public enum CollisionDetectionMode2D // TypeDefIndex: 60659
	{
		None = 0,
		Discrete = 0,
		Continuous = 1
	}

	[Serializable]
	public struct ContactFilter2D // TypeDefIndex: 60660
	{
		// Fields
		public bool useTriggers; // 0x00
		public bool useLayerMask; // 0x01
		public bool useDepth; // 0x02
		public bool useOutsideDepth; // 0x03
		public bool useNormalAngle; // 0x04
		public bool useOutsideNormalAngle; // 0x05
		public LayerMask layerMask; // 0x08
		public float minDepth; // 0x0C
		public float maxDepth; // 0x10
		public float minNormalAngle; // 0x14
		public float maxNormalAngle; // 0x18
	
		// Methods
		private void CheckConsistency() {} // 0x000000018BF31D60-0x000000018BF31D68
		public void SetLayerMask(LayerMask layerMask) {} // 0x0000000185FE8DB0-0x0000000185FE8DC0
		public void SetDepth(float minDepth, float maxDepth) {} // 0x000000018BF31E28-0x000000018BF31E40
		internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) => default; // 0x000000018BF31D68-0x000000018BF31E28
		private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self) {} // 0x000000018BF31D2C-0x000000018BF31D60
	}

	public class Collision2D // TypeDefIndex: 60661
	{
		// Fields
		internal int m_Collider; // 0x10
		internal int m_OtherCollider; // 0x14
		internal int m_Rigidbody; // 0x18
		internal int m_OtherRigidbody; // 0x1C
		internal Vector2 m_RelativeVelocity; // 0x20
		internal int m_Enabled; // 0x28
		internal int m_ContactCount; // 0x2C
		internal ContactPoint2D[] m_ReusedContacts; // 0x30
		internal ContactPoint2D[] m_LegacyContacts; // 0x38
	
		// Properties
		public Collider2D collider { get => default; } // 0x000000018BF31954-0x000000018BF319B4 
		public Rigidbody2D rigidbody { get => default; } // 0x000000018BF31AA0-0x000000018BF31B10 
		public GameObject gameObject { get => default; } // 0x000000018BF31A1C-0x000000018BF31AA0 
		public Vector2 relativeVelocity { get => default; } // 0x0000000185FE8D90-0x0000000185FE8DB0 
		public ContactPoint2D[] contacts { get => default; } // 0x000000018BF319B4-0x000000018BF31A1C 
	
		// Constructors
		public Collision2D() {} // Dummy constructor
	}

	public struct ContactPoint2D // TypeDefIndex: 60662
	{
		// Fields
		private Vector2 m_Point; // 0x00
		private Vector2 m_Normal; // 0x08
		private Vector2 m_RelativeVelocity; // 0x10
		private float m_Separation; // 0x18
		private float m_NormalImpulse; // 0x1C
		private float m_TangentImpulse; // 0x20
		private int m_Collider; // 0x24
		private int m_OtherCollider; // 0x28
		private int m_Rigidbody; // 0x2C
		private int m_OtherRigidbody; // 0x30
		private int m_Enabled; // 0x34
	
		// Properties
		public Vector2 point { get => default; } // 0x0000000184142CB0-0x0000000184142CC0 
		public Vector2 normal { get => default; } // 0x0000000185FE69B0-0x0000000185FE69D0 
		public Collider2D collider { get => default; } // 0x000000018BF31E40-0x000000018BF31EA0 
		public Collider2D otherCollider { get => default; } // 0x000000018BF31EA0-0x000000018BF31F00 
	}

	public struct RaycastHit2D // TypeDefIndex: 60663
	{
		// Fields
		private Vector2 m_Centroid; // 0x00
		private Vector2 m_Point; // 0x08
		private Vector2 m_Normal; // 0x10
		private float m_Distance; // 0x18
		private float m_Fraction; // 0x1C
		private int m_Collider; // 0x20
	
		// Properties
		public Vector2 point { get => default; } // 0x0000000185FE69B0-0x0000000185FE69D0 
		public Vector2 normal { get => default; } // 0x0000000185FE8DC0-0x0000000185FE8DE0 
		public float distance { get => default; } // 0x0000000185FE68F0-0x0000000185FE6900 
		public float fraction { get => default; } // 0x0000000185FE8CF0-0x0000000185FE8D00 
		public Collider2D collider { get => default; } // 0x000000018BF339C0-0x000000018BF33A20 
	}

	public sealed class Rigidbody2D : Component // TypeDefIndex: 60664
	{
		// Properties
		public Vector2 velocity { get => default; } // 0x000000018BF33A98-0x000000018BF33B08 
		public float mass { get => default; } // 0x000000018BF33A20-0x000000018BF33A54 
	
		// Constructors
		public Rigidbody2D() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void get_velocity_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BF33A54-0x000000018BF33A98
	}

	public class Collider2D : Behaviour // TypeDefIndex: 60665
	{
		// Properties
		public Vector2 offset { get => default; } // 0x000000018BF31930-0x000000018BF31954 
		public Rigidbody2D attachedRigidbody { get => default; } // 0x000000018BF318B8-0x000000018BF318EC 
	
		// Constructors
		public Collider2D() {} // Dummy constructor
	
		// Methods
		public bool OverlapPoint(Vector2 point) => default; // 0x000000018BF3189C-0x000000018BF318B8
		private void get_offset_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BF318EC-0x000000018BF31930
		private bool OverlapPoint_Injected(ref Vector2 point) => default; // 0x000000018BF31858-0x000000018BF3189C
	}

	public sealed class CircleCollider2D : Collider2D // TypeDefIndex: 60666
	{
		// Constructors
		public CircleCollider2D() {} // Dummy constructor
	}

	public sealed class PolygonCollider2D : Collider2D // TypeDefIndex: 60667
	{
		// Properties
		public int pathCount { get => default; } // 0x000000018BF3398C-0x000000018BF339C0 
	
		// Constructors
		public PolygonCollider2D() {} // Dummy constructor
	
		// Methods
		public int GetTotalPointCount() => default; // 0x000000018BF33958-0x000000018BF3398C
		public Vector2[] GetPath(int index) => default; // 0x000000018BF33818-0x000000018BF33958
		private Vector2[] GetPath_Internal(int index) => default; // 0x000000018BF337D8-0x000000018BF33818
	}

	public sealed class CompositeCollider2D : Collider2D // TypeDefIndex: 60668
	{
		// Properties
		public int pathCount { get => default; } // 0x000000018BF31CC4-0x000000018BF31CF8 
		public int pointCount { get => default; } // 0x000000018BF31CF8-0x000000018BF31D2C 
	
		// Constructors
		public CompositeCollider2D() {} // Dummy constructor
	
		// Methods
		public int GetPath(int index, Vector2[] points) => default; // 0x000000018BF31B60-0x000000018BF31CC4
		private int GetPathArray_Internal(int index, Vector2[] points) => default; // 0x000000018BF31B10-0x000000018BF31B60
	}

	public sealed class PhysicsMaterial2D : Object // TypeDefIndex: 60669
	{
		// Constructors
		public PhysicsMaterial2D() {} // Dummy constructor
	}
}
