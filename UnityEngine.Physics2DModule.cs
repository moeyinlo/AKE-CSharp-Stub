/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

// Image 106: UnityEngine.Physics2DModule.dll - Assembly: UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90740-90755

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/Public/PhysicsSceneHandle2D.h")]
	public struct PhysicsScene2D : IEquatable<UnityEngine.PhysicsScene2D> // TypeDefIndex: 90741
	{
		// Fields
		private int m_Handle; // 0x00
	
		// Methods
		public override string ToString(); // 0x000000018D549948-0x000000018D5499F8
		public override int GetHashCode(); // 0x000000018725FD00-0x000000018725FD10
		public override bool Equals(object other); // 0x000000018D54914C-0x000000018D5491B0
		public bool Equals(PhysicsScene2D other); // 0x0000000184FF20D0-0x0000000184FF20E0
		public RaycastHit2D Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter); // 0x000000018D549494-0x000000018D549510
		[NativeMethod("Linecast_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static RaycastHit2D Linecast_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter); // 0x000000018D549444-0x000000018D549494
		public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, [UnityEngine.Internal.DefaultValue("Physics2D.DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0264B11C */); // 0x000000018D5497DC-0x000000018D5498BC
		public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter); // 0x000000018D5498BC-0x000000018D549948
		[NativeMethod("Raycast_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter); // 0x000000018D5496D4-0x000000018D549734
		public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results); // 0x000000018D549734-0x000000018D549788
		[NativeMethod("RaycastArray_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, [NotNull("ArgumentNullException")] [Unmarshalled] RaycastHit2D[] results); // 0x000000018D549574-0x000000018D5495C0
		public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results); // 0x000000018D549788-0x000000018D5497DC
		[NativeMethod("RaycastList_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, [NotNull("ArgumentNullException")] List<RaycastHit2D> results); // 0x000000018D549624-0x000000018D549670
		public RaycastHit2D GetRayIntersection(Ray ray, float distance, [UnityEngine.Internal.DefaultValue("Physics2D.DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0264B11D */); // 0x000000018D5492F8-0x000000018D549388
		[NativeMethod("GetRayIntersection_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static RaycastHit2D GetRayIntersection_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask); // 0x000000018D5492AC-0x000000018D5492F8
		public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, [UnityEngine.Internal.DefaultValue("Physics2D.DefaultRaycastLayers")] int layerMask = -5 /* Metadata: 0x0264B11E */); // 0x000000018D549388-0x000000018D5493E0
		[NativeMethod("GetRayIntersectionArray_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, [NotNull("ArgumentNullException")] [Unmarshalled] RaycastHit2D[] results); // 0x000000018D549214-0x000000018D549248
		private static void Linecast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter, out RaycastHit2D ret); // 0x000000018D5493E0-0x000000018D549444
		private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret); // 0x000000018D549670-0x000000018D5496D4
		private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results); // 0x000000018D549510-0x000000018D549574
		private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results); // 0x000000018D5495C0-0x000000018D549624
		private static void GetRayIntersection_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, out RaycastHit2D ret); // 0x000000018D549248-0x000000018D5492AC
		private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results); // 0x000000018D5491B0-0x000000018D549214
	}

	[NativeHeader("Physics2DScriptingClasses.h")]
	[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
	[NativeHeader("Physics2DScriptingClasses.h")]
	[StaticAccessor("GetPhysicsManager2D()", StaticAccessorType.Arrow)]
	public class Physics2D // TypeDefIndex: 90742
	{
		// Fields
		private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x00
	
		// Properties
		public static PhysicsScene2D defaultPhysicsScene { get; } // 0x000000018724EFC0-0x000000018724EFD0 
		[StaticAccessor("GetPhysics2DSettings()")]
		public static Vector2 gravity { set; } // 0x000000018D549100-0x000000018D54914C
		[StaticAccessor("GetPhysics2DSettings()")]
		public static bool queriesHitTriggers { get; } // 0x000000018D5490A0-0x000000018D5490CC 
	
		// Constructors
		static Physics2D(); // 0x000000018D549014-0x000000018D5490A0
	
		// Methods
		[ExcludeFromDocs]
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask); // 0x000000018D54876C-0x000000018D548888
		[ExcludeFromDocs]
		public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, int layerMask); // 0x000000018D548698-0x000000018D54876C
		[NativeMethod("LinecastAll_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static RaycastHit2D[] LinecastAll_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter); // 0x000000018D548634-0x000000018D548698
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction); // 0x000000018D548F48-0x000000018D549014
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance); // 0x000000018D548C7C-0x000000018D548D4C
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask); // 0x000000018D548A84-0x000000018D548BB4
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth); // 0x000000018D548E14-0x000000018D548F48
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float distance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [UnityEngine.Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float maxDepth); // 0x000000018D548888-0x000000018D5489BC
		[ExcludeFromDocs]
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results); // 0x000000018D5489BC-0x000000018D548A84
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float distance); // 0x000000018D548BB4-0x000000018D548C7C
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float distance = 1F / 0F /* Metadata: 0x0264B11F */); // 0x000000018D548D4C-0x000000018D548E14
		public static RaycastHit2D GetRayIntersection(Ray ray, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float distance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask); // 0x000000018D548500-0x000000018D5485D0
		[ExcludeFromDocs]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray); // 0x000000018D5482B8-0x000000018D54833C
		[ExcludeFromDocs]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance); // 0x000000018D54822C-0x000000018D5482B8
		[RequiredByNativeCode]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float distance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask); // 0x000000018D548198-0x000000018D54822C
		[NativeMethod("GetRayIntersectionAll_Binding")]
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask); // 0x000000018D548120-0x000000018D548198
		[ExcludeFromDocs]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results); // 0x000000018D548474-0x000000018D548500
		[ExcludeFromDocs]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance); // 0x000000018D54833C-0x000000018D5483D4
		[RequiredByNativeCode]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, [UnityEngine.Internal.DefaultValue("Mathf.Infinity")] float distance, [UnityEngine.Internal.DefaultValue("DefaultRaycastLayers")] int layerMask); // 0x000000018D5483D4-0x000000018D548474
		private static void set_gravity_Injected(ref Vector2 value); // 0x000000018D5490CC-0x000000018D549100
		private static RaycastHit2D[] LinecastAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter); // 0x000000018D5485D0-0x000000018D548634
		private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask); // 0x000000018D5480BC-0x000000018D548120
	}

	public enum RigidbodyInterpolation2D // TypeDefIndex: 90743
	{
		None = 0,
		Interpolate = 1,
		Extrapolate = 2
	}

	public enum RigidbodySleepMode2D // TypeDefIndex: 90744
	{
		NeverSleep = 0,
		StartAwake = 1,
		StartAsleep = 2
	}

	public enum CollisionDetectionMode2D // TypeDefIndex: 90745
	{
		None = 0,
		Discrete = 0,
		Continuous = 1
	}

	[Serializable]
	[NativeClass("ContactFilter", "struct ContactFilter;")]
	[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	public struct ContactFilter2D // TypeDefIndex: 90746
	{
		// Fields
		[NativeName("m_UseTriggers")]
		public bool useTriggers; // 0x00
		[NativeName("m_UseLayerMask")]
		public bool useLayerMask; // 0x01
		[NativeName("m_UseDepth")]
		public bool useDepth; // 0x02
		[NativeName("m_UseOutsideDepth")]
		public bool useOutsideDepth; // 0x03
		[NativeName("m_UseNormalAngle")]
		public bool useNormalAngle; // 0x04
		[NativeName("m_UseOutsideNormalAngle")]
		public bool useOutsideNormalAngle; // 0x05
		[NativeName("m_LayerMask")]
		public LayerMask layerMask; // 0x08
		[NativeName("m_MinDepth")]
		public float minDepth; // 0x0C
		[NativeName("m_MaxDepth")]
		public float maxDepth; // 0x10
		[NativeName("m_MinNormalAngle")]
		public float minNormalAngle; // 0x14
		[NativeName("m_MaxNormalAngle")]
		public float maxNormalAngle; // 0x18
	
		// Methods
		private void CheckConsistency(); // 0x000000018D547F1C-0x000000018D547F24
		public void SetLayerMask(LayerMask layerMask); // 0x0000000187262110-0x0000000187262120
		public void SetDepth(float minDepth, float maxDepth); // 0x000000018D547FE4-0x000000018D547FFC
		internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth); // 0x000000018D547F24-0x000000018D547FE4
		private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self); // 0x000000018D547EE8-0x000000018D547F1C
	}

	[RequiredByNativeCode]
	public class Collision2D // TypeDefIndex: 90747
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
		public Collider2D collider { get; } // 0x000000018D547B10-0x000000018D547B70 
		public Rigidbody2D rigidbody { get; } // 0x000000018D547C5C-0x000000018D547CCC 
		public GameObject gameObject { get; } // 0x000000018D547BD8-0x000000018D547C5C 
		public Vector2 relativeVelocity { get; } // 0x00000001872620F0-0x0000000187262110 
		public ContactPoint2D[] contacts { get; } // 0x000000018D547B70-0x000000018D547BD8 
	}

	[NativeClass("ScriptingContactPoint2D", "struct ScriptingContactPoint2D;")]
	[NativeHeader("Modules/Physics2D/Public/PhysicsScripting2D.h")]
	[RequiredByNativeCode(Optional = false, GenerateProxy = true)]
	public struct ContactPoint2D // TypeDefIndex: 90748
	{
		// Fields
		[NativeName("point")]
		private Vector2 m_Point; // 0x00
		[NativeName("normal")]
		private Vector2 m_Normal; // 0x08
		[NativeName("relativeVelocity")]
		private Vector2 m_RelativeVelocity; // 0x10
		[NativeName("separation")]
		private float m_Separation; // 0x18
		[NativeName("normalImpulse")]
		private float m_NormalImpulse; // 0x1C
		[NativeName("tangentImpulse")]
		private float m_TangentImpulse; // 0x20
		[NativeName("collider")]
		private int m_Collider; // 0x24
		[NativeName("otherCollider")]
		private int m_OtherCollider; // 0x28
		[NativeName("rigidbody")]
		private int m_Rigidbody; // 0x2C
		[NativeName("otherRigidbody")]
		private int m_OtherRigidbody; // 0x30
		[NativeName("enabled")]
		private int m_Enabled; // 0x34
	
		// Properties
		public Vector2 point { get; } // 0x0000000187260200-0x0000000187260220 
		public Vector2 normal { get; } // 0x00000001872601E0-0x0000000187260200 
		public Collider2D collider { get; } // 0x000000018D547FFC-0x000000018D54805C 
		public Collider2D otherCollider { get; } // 0x000000018D54805C-0x000000018D5480BC 
	}

	[NativeClass("RaycastHit2D", "struct RaycastHit2D;")]
	[NativeHeader("Runtime/Interfaces/IPhysics2D.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	public struct RaycastHit2D // TypeDefIndex: 90749
	{
		// Fields
		[NativeName("centroid")]
		private Vector2 m_Centroid; // 0x00
		[NativeName("point")]
		private Vector2 m_Point; // 0x08
		[NativeName("normal")]
		private Vector2 m_Normal; // 0x10
		[NativeName("distance")]
		private float m_Distance; // 0x18
		[NativeName("fraction")]
		private float m_Fraction; // 0x1C
		[NativeName("collider")]
		private int m_Collider; // 0x20
	
		// Properties
		public Vector2 point { get; } // 0x00000001872601E0-0x0000000187260200 
		public Vector2 normal { get; } // 0x0000000187262120-0x0000000187262140 
		public float distance { get; } // 0x0000000184F6C3E0-0x0000000184F6C650 
		public float fraction { get; } // 0x0000000187262050-0x0000000187262060 
		public Collider2D collider { get; } // 0x000000018D549BE0-0x000000018D549C40 
	}

	[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
	[RequireComponent(typeof(Transform))]
	public sealed class Rigidbody2D : Component // TypeDefIndex: 90750
	{
		// Properties
		public Vector2 velocity { get; } // 0x000000018D549CB8-0x000000018D549D28 
		public float mass { get; } // 0x000000018D549C40-0x000000018D549C74 
	
		// Constructors
		public Rigidbody2D(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void get_velocity_Injected(out Vector2 ret); // 0x000000018D549C74-0x000000018D549CB8
	}

	[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
	[RequireComponent(typeof(Transform))]
	[RequiredByNativeCode(Optional = true)]
	public class Collider2D : Behaviour // TypeDefIndex: 90751
	{
		// Properties
		public Vector2 offset { get; } // 0x000000018D547AEC-0x000000018D547B10 
		public Rigidbody2D attachedRigidbody { [NativeMethod("GetAttachedRigidbody_Binding")] get; } // 0x000000018D547A74-0x000000018D547AA8 
	
		// Methods
		public bool OverlapPoint(Vector2 point); // 0x000000018D547A58-0x000000018D547A74
		private void get_offset_Injected(out Vector2 ret); // 0x000000018D547AA8-0x000000018D547AEC
		private bool OverlapPoint_Injected(ref Vector2 point); // 0x000000018D547A14-0x000000018D547A58
	}

	[NativeHeader("Modules/Physics2D/Public/CircleCollider2D.h")]
	public sealed class CircleCollider2D : Collider2D // TypeDefIndex: 90752
	{
	}

	[NativeHeader("Modules/Physics2D/Public/PolygonCollider2D.h")]
	public sealed class PolygonCollider2D : Collider2D // TypeDefIndex: 90753
	{
		// Properties
		public int pathCount { get; } // 0x000000018D549BAC-0x000000018D549BE0 
	
		// Methods
		[NativeMethod("GetPointCount")]
		public int GetTotalPointCount(); // 0x000000018D549B78-0x000000018D549BAC
		public Vector2[] GetPath(int index); // 0x000000018D549A38-0x000000018D549B78
		[NativeMethod("GetPath_Binding")]
		private Vector2[] GetPath_Internal(int index); // 0x000000018D5499F8-0x000000018D549A38
	}

	[NativeHeader("Modules/Physics2D/Public/CompositeCollider2D.h")]
	[RequireComponent(typeof(Rigidbody2D))]
	public sealed class CompositeCollider2D : Collider2D // TypeDefIndex: 90754
	{
		// Properties
		public int pathCount { get; } // 0x000000018D547E80-0x000000018D547EB4 
		public int pointCount { get; } // 0x000000018D547EB4-0x000000018D547EE8 
	
		// Methods
		public int GetPath(int index, Vector2[] points); // 0x000000018D547D1C-0x000000018D547E80
		[NativeMethod("GetPathArray_Binding")]
		private int GetPathArray_Internal(int index, [NotNull("ArgumentNullException")] [Unmarshalled] Vector2[] points); // 0x000000018D547CCC-0x000000018D547D1C
	}

	[NativeHeader("Modules/Physics2D/Public/PhysicsMaterial2D.h")]
	public sealed class PhysicsMaterial2D : Object // TypeDefIndex: 90755
	{
	}
}
