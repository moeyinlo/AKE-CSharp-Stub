/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

// Image 115: NavMeshComponents.dll - Assembly: NavMeshComponents, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90994-91002

[DefaultExecutionOrder(-102)]
[ExecuteInEditMode]
public class NavMeshPrefabInstance : MonoBehaviour // TypeDefIndex: 90995
{
	// Fields
	[SerializeField]
	private NavMeshData m_NavMesh; // 0x18
	[SerializeField]
	private bool m_FollowTransform; // 0x20
	private NavMeshDataInstance m_Instance; // 0x24
	private static readonly List<NavMeshPrefabInstance> s_TrackedInstances; // 0x00
	private Vector3 m_Position; // 0x28
	private Quaternion m_Rotation; // 0x34

	// Properties
	public NavMeshData navMeshData { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	public bool followTransform { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x000000018CA498EC-0x000000018CA498F4
	public static List<NavMeshPrefabInstance> trackedInstances { get; } // 0x000000018CA4989C-0x000000018CA498EC 

	// Constructors
	public NavMeshPrefabInstance(); // 0x00000001878364A0-0x00000001878364B8
	static NavMeshPrefabInstance(); // 0x000000018CA49810-0x000000018CA4989C

	// Methods
	private void OnEnable(); // 0x000000018CA494B0-0x000000018CA494EC
	private void OnDisable(); // 0x000000018CA4948C-0x000000018CA494B0
	public void UpdateInstance(); // 0x000000018CA49694-0x000000018CA496B8
	private void AddInstance(); // 0x000000018CA490C4-0x000000018CA49204
	private void AddTracking(); // 0x000000018CA49204-0x000000018CA49398
	private void RemoveTracking(); // 0x000000018CA494EC-0x000000018CA49668
	private void SetFollowTransform(bool value); // 0x000000018CA49668-0x000000018CA49694
	private bool HasMoved(); // 0x000000018CA49398-0x000000018CA4948C
	private static void UpdateTrackedInstances(); // 0x000000018CA496B8-0x000000018CA49810
}

namespace UnityEngine.AI
{
	[AddComponentMenu("Navigation/NavMeshLink", 33)]
	[DefaultExecutionOrder(-101)]
	[ExecuteInEditMode]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshLink : MonoBehaviour // TypeDefIndex: 90996
	{
		// Fields
		[SerializeField]
		private int m_AgentTypeID; // 0x18
		[SerializeField]
		private Vector3 m_StartRight; // 0x1C
		[SerializeField]
		private Vector3 m_StartLeft; // 0x28
		[SerializeField]
		private Vector3 m_EndRight; // 0x34
		[SerializeField]
		private Vector3 m_EndLeft; // 0x40
		[SerializeField]
		private bool m_IsExt; // 0x4C
		[SerializeField]
		private float m_CostModifier; // 0x50
		[SerializeField]
		private bool m_Bidirectional; // 0x54
		[SerializeField]
		private bool m_AutoUpdatePosition; // 0x55
		[SerializeField]
		private int m_Area; // 0x58
		public bool autoSnapExtent; // 0x5C
		public Vector3 snapExtent; // 0x60
		private NavMeshLinkInstance m_LinkInstance; // 0x6C
		private Vector3 m_LastPosition; // 0x70
		private Quaternion m_LastRotation; // 0x7C
		private static readonly List<NavMeshLink> s_Tracked; // 0x00
	
		// Properties
		public int agentTypeID { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018CA48784-0x000000018CA48794
		public Vector3 startRight { get; set; } // 0x000000018723E2B0-0x000000018723E2D0 0x000000018CA48954-0x000000018CA489C8
		public Vector3 startLeft { get; set; } // 0x000000018723EAD0-0x000000018723EAF0 0x000000018CA488E0-0x000000018CA48954
		public Vector3 startMid { get; } // 0x000000018CA48704-0x000000018CA48784 
		public Vector3 endRight { get; set; } // 0x0000000187236500-0x0000000187236520 0x000000018CA4885C-0x000000018CA488D0
		public Vector3 endLeft { get; set; } // 0x0000000187236520-0x0000000187236540 0x000000018CA487E8-0x000000018CA4885C
		public Vector3 endMid { get; } // 0x000000018CA48684-0x000000018CA48704 
		public bool isExt { get; set; } // 0x000000018226EC80-0x000000018226EC90 0x000000018CA488D0-0x000000018CA488E0
		public float costModifier { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018CA487BC-0x000000018CA487E8
		public bool bidirectional { get; set; } // 0x0000000182271C80-0x0000000182271C90 0x000000018CA487AC-0x000000018CA487BC
		public bool autoUpdate { get; set; } // 0x00000001872335B0-0x00000001872335C0 0x000000018CA487A4-0x000000018CA487AC
		public int area { get; set; } // 0x00000001872331A0-0x00000001872331B0 0x000000018CA48794-0x000000018CA487A4
	
		// Constructors
		public NavMeshLink(); // 0x000000018CA485C0-0x000000018CA48684
		static NavMeshLink(); // 0x000000018CA48534-0x000000018CA485C0
	
		// Methods
		private void OnEnable(); // 0x000000018CA48114-0x000000018CA48174
		private void OnDisable(); // 0x000000018CA480C8-0x000000018CA48114
		public void UpdateLink(); // 0x000000018CA483B8-0x000000018CA483DC
		private static void AddTracking(NavMeshLink link); // 0x000000018CA47E38-0x000000018CA47FCC
		private static void RemoveTracking(NavMeshLink link); // 0x000000018CA48174-0x000000018CA482F0
		private void SetAutoUpdate(bool value); // 0x000000018CA482F0-0x000000018CA48354
		private void AddLink(); // 0x000000018CA47C74-0x000000018CA47E38
		public void SetByLinkData(NavMeshLinkData data); // 0x000000018CA48354-0x000000018CA483B8
		private bool HasTransformChanged(); // 0x000000018CA47FCC-0x000000018CA480C0
		private void OnDidApplyAnimationProperties(); // 0x000000018CA480C0-0x000000018CA480C8
		private static void UpdateTrackedInstances(); // 0x000000018CA483DC-0x000000018CA48534
	}

	[AddComponentMenu("Navigation/NavMeshModifier", 32)]
	[ExecuteInEditMode]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshModifier : MonoBehaviour // TypeDefIndex: 90997
	{
		// Fields
		[SerializeField]
		private bool m_OverrideArea; // 0x18
		[SerializeField]
		private int m_Area; // 0x1C
		[SerializeField]
		private bool m_IgnoreFromBuild; // 0x20
		[SerializeField]
		private List<int> m_AffectedAgents; // 0x28
		private static readonly List<NavMeshModifier> s_NavMeshModifiers; // 0x00
	
		// Properties
		public bool overrideArea { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public int area { get; set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
		public bool ignoreFromBuild { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
		public static List<NavMeshModifier> activeModifiers { get; } // 0x000000018CA49074-0x000000018CA490C4 
	
		// Constructors
		public NavMeshModifier(); // 0x000000018CA48FB0-0x000000018CA49074
		static NavMeshModifier(); // 0x000000018CA48F24-0x000000018CA48FB0
	
		// Methods
		private void OnEnable(); // 0x000000018CA48E74-0x000000018CA48F24
		private void OnDisable(); // 0x000000018CA48E04-0x000000018CA48E74
		public bool AffectsAgentType(int agentTypeID); // 0x000000018CA48D64-0x000000018CA48E04
	}

	[AddComponentMenu("Navigation/NavMeshModifierVolume", 31)]
	[ExecuteInEditMode]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshModifierVolume : MonoBehaviour // TypeDefIndex: 90998
	{
		// Fields
		[SerializeField]
		private Vector3 m_Size; // 0x18
		[SerializeField]
		private Vector3 m_Center; // 0x24
		[SerializeField]
		private int m_Area; // 0x30
		[SerializeField]
		private List<int> m_AffectedAgents; // 0x38
		private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers; // 0x00
	
		// Properties
		public Vector3 size { get; set; } // 0x0000000187236730-0x0000000187236750 0x0000000187236750-0x0000000187236760
		public Vector3 center { get; set; } // 0x000000018723E4F0-0x000000018723E510 0x000000018723E4E0-0x000000018723E4F0
		public int area { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public static List<NavMeshModifierVolume> activeModifiers { get; } // 0x000000018CA48D14-0x000000018CA48D64 
	
		// Constructors
		public NavMeshModifierVolume(); // 0x000000018CA48C14-0x000000018CA48D14
		static NavMeshModifierVolume(); // 0x000000018CA48B88-0x000000018CA48C14
	
		// Methods
		private void OnEnable(); // 0x000000018CA48AD8-0x000000018CA48B88
		private void OnDisable(); // 0x000000018CA48A68-0x000000018CA48AD8
		public bool AffectsAgentType(int agentTypeID); // 0x000000018CA489C8-0x000000018CA48A68
	}

	public enum CollectObjects // TypeDefIndex: 90999
	{
		All = 0,
		Volume = 1,
		Children = 2
	}

	public enum PartitioningMethod // TypeDefIndex: 91000
	{
		Layers = 0,
		Monotone = 1,
		Watershed = 2
	}

	[AddComponentMenu("Navigation/NavMeshSurface", 30)]
	[DefaultExecutionOrder(-102)]
	[ExecuteAlways]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshSurface : MonoBehaviour // TypeDefIndex: 91002
	{
		// Fields
		[SerializeField]
		private int m_AgentTypeID; // 0x18
		[SerializeField]
		private CollectObjects m_CollectObjects; // 0x1C
		[SerializeField]
		private Vector3 m_Size; // 0x20
		[SerializeField]
		private Vector3 m_Center; // 0x2C
		[SerializeField]
		private LayerMask m_LayerMask; // 0x38
		[SerializeField]
		private string m_BlockTag; // 0x40
		[SerializeField]
		private PartitioningMethod m_PartitioningMethod; // 0x48
		[SerializeField]
		private bool m_FilterLowHangingObstacles; // 0x4C
		[SerializeField]
		private bool m_FilterLedgeSpans; // 0x4D
		[SerializeField]
		private bool m_FilterWalkableLowHeightSpans; // 0x4E
		[SerializeField]
		private bool m_OverrideMinRegionArea; // 0x4F
		[SerializeField]
		private float m_MinRegionArea; // 0x50
		[SerializeField]
		private NavMeshCollectGeometry m_UseGeometry; // 0x54
		[SerializeField]
		private int m_DefaultArea; // 0x58
		[SerializeField]
		private bool m_IgnoreNavMeshAgent; // 0x5C
		[SerializeField]
		private bool m_IgnoreNavMeshObstacle; // 0x5D
		[SerializeField]
		private bool m_OverrideTileSize; // 0x5E
		[SerializeField]
		private int m_TileSize; // 0x60
		[SerializeField]
		private bool m_OverrideVoxelSize; // 0x64
		[SerializeField]
		private float m_VoxelSize; // 0x68
		[SerializeField]
		private bool m_BuildHeightMesh; // 0x6C
		[FormerlySerializedAs("m_BakedNavMeshData")]
		[SerializeField]
		private NavMeshData m_NavMeshData; // 0x70
		private NavMeshDataInstance m_NavMeshDataInstance; // 0x78
		private Vector3 m_LastPosition; // 0x7C
		private Quaternion m_LastRotation; // 0x88
		private static readonly List<NavMeshSurface> s_NavMeshSurfaces; // 0x00
	
		// Properties
		public int agentTypeID { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public CollectObjects collectObjects { get; set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
		public Vector3 size { get; set; } // 0x000000018723E710-0x000000018723E730 0x000000018723E700-0x000000018723E710
		public Vector3 center { get; set; } // 0x0000000187233AD0-0x0000000187233AF0 0x0000000187233B00-0x0000000187233B10
		public LayerMask layerMask { get; set; } // 0x00000001829600C0-0x00000001829600D0 0x0000000185E3C070-0x0000000185E3C080
		public string BlockTag { get; set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public PartitioningMethod partitioningMethod { get; set; } // 0x00000001872330A0-0x00000001872330B0 0x0000000185E120B0-0x0000000185E120C0
		public bool filterLowHangingObstacles { get; set; } // 0x000000018226EC80-0x000000018226EC90 0x000000018226EC90-0x000000018226ECA0
		public bool filterLedgeSpans { get; set; } // 0x0000000182308F10-0x0000000182308F20 0x0000000182308F20-0x0000000182308F30
		public bool filterWalkableLowHeightSpans { get; set; } // 0x00000001872537F0-0x0000000187253800 0x0000000187253830-0x0000000187253840
		public bool overrideMinRegionArea { get; set; } // 0x0000000187253810-0x0000000187253820 0x0000000187253850-0x0000000187253860
		public float minRegionArea { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
		public NavMeshCollectGeometry useGeometry { get; set; } // 0x00000001872336F0-0x0000000187233700 0x0000000187233700-0x0000000187233710
		public int defaultArea { get; set; } // 0x00000001872331A0-0x00000001872331B0 0x0000000185B8E8A0-0x0000000185B8EB10
		public bool ignoreNavMeshAgent { get; set; } // 0x000000018225DF90-0x000000018225DFA0 0x000000018225DFA0-0x000000018225DFB0
		public bool ignoreNavMeshObstacle { get; set; } // 0x0000000187253800-0x0000000187253810 0x0000000187253840-0x0000000187253850
		public bool overrideTileSize { get; set; } // 0x0000000187253820-0x0000000187253830 0x0000000187253860-0x0000000187253870
		public int tileSize { get; set; } // 0x00000001872332A0-0x00000001872332B0 0x0000000185FF5E70-0x0000000185FF5F30
		public bool overrideVoxelSize { get; set; } // 0x000000018225E030-0x000000018225E040 0x000000018225E040-0x000000018225E050
		public float voxelSize { get; set; } // 0x000000018723CA40-0x000000018723CA50 0x000000018723CA70-0x000000018723CA80
		public bool buildHeightMesh { get; set; } // 0x000000018723CA20-0x000000018723CA30 0x0000000187234ED0-0x0000000187234EE0
		public NavMeshData navMeshData { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
		public static List<NavMeshSurface> activeSurfaces { get; } // 0x000000018CA4C3D4-0x000000018CA4C424 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 91001
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<NavMeshModifierVolume> __9__105_0; // 0x08
			public static Predicate<NavMeshModifier> __9__106_0; // 0x10
			public static Predicate<NavMeshBuildSource> __9__106_1; // 0x18
			public static Predicate<NavMeshBuildSource> __9__106_2; // 0x20
	
			// Constructors
			static __c(); // 0x000000018CA4C5C0-0x000000018CA4C6F0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _AppendModifierVolumes_b__105_0(NavMeshModifierVolume x); // 0x000000018CA4C424-0x000000018CA4C448
			internal bool _CollectSources_b__106_0(NavMeshModifier x); // 0x000000018CA4C424-0x000000018CA4C448
			internal bool _CollectSources_b__106_1(NavMeshBuildSource x); // 0x000000018CA4C448-0x000000018CA4C504
			internal bool _CollectSources_b__106_2(NavMeshBuildSource x); // 0x000000018CA4C504-0x000000018CA4C5C0
		}
	
		// Constructors
		public NavMeshSurface(); // 0x000000018CA4C308-0x000000018CA4C3D4
		static NavMeshSurface(); // 0x000000018CA4C27C-0x000000018CA4C308
	
		// Methods
		private void OnEnable(); // 0x000000018CA4BA78-0x000000018CA4BAC4
		private void OnDisable(); // 0x000000018CA4BA2C-0x000000018CA4BA78
		public void AddData(); // 0x000000018CA498F4-0x000000018CA49A64
		public void RemoveData(); // 0x000000018CA4BC98-0x000000018CA4BCB8
		public NavMeshBuildSettings GetBuildSettings(); // 0x000000018CA4B4F4-0x000000018CA4B654
		public void BuildNavMesh(); // 0x000000018CA4A014-0x000000018CA4A30C
		public AsyncOperation UpdateNavMesh(NavMeshData data); // 0x000000018CA4C0C8-0x000000018CA4C27C
		public bool UpdateNavMeshSync(NavMeshData data); // 0x000000018CA4BF14-0x000000018CA4C0C8
		private static void Register(NavMeshSurface surface); // 0x000000018CA4BAC4-0x000000018CA4BC98
		private static void Unregister(NavMeshSurface surface); // 0x000000018CA4BCB8-0x000000018CA4BE34
		private static void UpdateActive(); // 0x000000018CA4BE34-0x000000018CA4BEE0
		private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources); // 0x000000018CA49A64-0x000000018CA4A014
		private List<NavMeshBuildSource> CollectSources(); // 0x000000018CA4ABFC-0x000000018CA4B4F4
		private static Vector3 Abs(Vector3 v); // 0x00000001872409C0-0x0000000187240A00
		private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds); // 0x000000018CA4B654-0x000000018CA4B930
		private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources); // 0x000000018CA4A30C-0x000000018CA4ABFC
		private bool HasTransformChanged(); // 0x000000018CA4B930-0x000000018CA4BA2C
		private void UpdateDataIfTransformChanged(); // 0x000000018CA4BEE0-0x000000018CA4BF14
	}
}
