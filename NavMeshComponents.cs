/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// Image 112: NavMeshComponents.dll - Assembly: NavMeshComponents, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60899-60907

public class NavMeshPrefabInstance : MonoBehaviour // TypeDefIndex: 60900
{
	// Fields
	private NavMeshData m_NavMesh; // 0x18
	private bool m_FollowTransform; // 0x20
	private NavMeshDataInstance m_Instance; // 0x24
	private static readonly List<NavMeshPrefabInstance> s_TrackedInstances; // 0x00
	private Vector3 m_Position; // 0x28
	private Quaternion m_Rotation; // 0x34

	// Properties
	public NavMeshData navMeshData { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	public bool followTransform { get => default; set {} } // 0x00000001813ECBF0-0x00000001813ECC00 0x000000018B3C6758-0x000000018B3C6760
	public static List<NavMeshPrefabInstance> trackedInstances { get => default; } // 0x000000018B3C6708-0x000000018B3C6758 

	// Constructors
	public NavMeshPrefabInstance() {} // 0x000000018646DB20-0x000000018646DB28
	static NavMeshPrefabInstance() {} // 0x000000018B3C667C-0x000000018B3C6708

	// Methods
	private void OnEnable() {} // 0x000000018B3C6324-0x000000018B3C6360
	private void OnDisable() {} // 0x000000018B3C6300-0x000000018B3C6324
	public void UpdateInstance() {} // 0x000000018B3C6508-0x000000018B3C652C
	private void AddInstance() {} // 0x000000018B3C5F38-0x000000018B3C6078
	private void AddTracking() {} // 0x000000018B3C6078-0x000000018B3C620C
	private void RemoveTracking() {} // 0x000000018B3C6360-0x000000018B3C64DC
	private void SetFollowTransform(bool value) {} // 0x000000018B3C64DC-0x000000018B3C6508
	private bool HasMoved() => default; // 0x000000018B3C620C-0x000000018B3C6300
	private static void UpdateTrackedInstances() {} // 0x000000018B3C652C-0x000000018B3C667C
}

namespace UnityEngine.AI
{
	public class NavMeshLink : MonoBehaviour // TypeDefIndex: 60901
	{
		// Fields
		private int m_AgentTypeID; // 0x18
		private Vector3 m_StartRight; // 0x1C
		private Vector3 m_StartLeft; // 0x28
		private Vector3 m_EndRight; // 0x34
		private Vector3 m_EndLeft; // 0x40
		private bool m_IsExt; // 0x4C
		private float m_CostModifier; // 0x50
		private bool m_Bidirectional; // 0x54
		private bool m_AutoUpdatePosition; // 0x55
		private int m_Area; // 0x58
		public bool autoSnapExtent; // 0x5C
		public Vector3 snapExtent; // 0x60
		private NavMeshLinkInstance m_LinkInstance; // 0x6C
		private Vector3 m_LastPosition; // 0x70
		private Quaternion m_LastRotation; // 0x7C
		private static readonly List<NavMeshLink> s_Tracked; // 0x00
	
		// Properties
		public int agentTypeID { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x000000018B3C55FC-0x000000018B3C560C
		public Vector3 startRight { get => default; set {} } // 0x0000000185FBE120-0x0000000185FBE140 0x000000018B3C57CC-0x000000018B3C5840
		public Vector3 startLeft { get => default; set {} } // 0x0000000185FB2340-0x0000000185FB2360 0x000000018B3C5758-0x000000018B3C57CC
		public Vector3 startMid { get => default; } // 0x000000018B3C557C-0x000000018B3C55FC 
		public Vector3 endRight { get => default; set {} } // 0x0000000185FB3600-0x0000000185FB3620 0x000000018B3C56D4-0x000000018B3C5748
		public Vector3 endLeft { get => default; set {} } // 0x0000000185FB3620-0x0000000185FB3640 0x000000018B3C5660-0x000000018B3C56D4
		public Vector3 endMid { get => default; } // 0x000000018B3C54FC-0x000000018B3C557C 
		public bool isExt { get => default; set {} } // 0x0000000185FB0B40-0x0000000185FB0B50 0x000000018B3C5748-0x000000018B3C5758
		public float costModifier { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x000000018B3C5634-0x000000018B3C5660
		public bool bidirectional { get => default; set {} } // 0x0000000185FB0A80-0x0000000185FB0A90 0x000000018B3C5624-0x000000018B3C5634
		public bool autoUpdate { get => default; set {} } // 0x0000000185FB0A70-0x0000000185FB0A80 0x000000018B3C561C-0x000000018B3C5624
		public int area { get => default; set {} } // 0x0000000183F80450-0x0000000183F80460 0x000000018B3C560C-0x000000018B3C561C
	
		// Constructors
		public NavMeshLink() {} // 0x000000018B3C5438-0x000000018B3C54FC
		static NavMeshLink() {} // 0x000000018B3C53AC-0x000000018B3C5438
	
		// Methods
		private void OnEnable() {} // 0x000000018B3C4F94-0x000000018B3C4FF4
		private void OnDisable() {} // 0x000000018B3C4F48-0x000000018B3C4F94
		public void UpdateLink() {} // 0x000000018B3C5238-0x000000018B3C525C
		private static void AddTracking(NavMeshLink link) {} // 0x000000018B3C4CB8-0x000000018B3C4E4C
		private static void RemoveTracking(NavMeshLink link) {} // 0x000000018B3C4FF4-0x000000018B3C5170
		private void SetAutoUpdate(bool value) {} // 0x000000018B3C5170-0x000000018B3C51D4
		private void AddLink() {} // 0x000000018B3C4AF4-0x000000018B3C4CB8
		public void SetByLinkData(NavMeshLinkData data) {} // 0x000000018B3C51D4-0x000000018B3C5238
		private bool HasTransformChanged() => default; // 0x000000018B3C4E4C-0x000000018B3C4F40
		private void OnDidApplyAnimationProperties() {} // 0x000000018B3C4F40-0x000000018B3C4F48
		private static void UpdateTrackedInstances() {} // 0x000000018B3C525C-0x000000018B3C53AC
	}

	public class NavMeshModifier : MonoBehaviour // TypeDefIndex: 60902
	{
		// Fields
		private bool m_OverrideArea; // 0x18
		private int m_Area; // 0x1C
		private bool m_IgnoreFromBuild; // 0x20
		private List<int> m_AffectedAgents; // 0x28
		private static readonly List<NavMeshModifier> s_NavMeshModifiers; // 0x00
	
		// Properties
		public bool overrideArea { get => default; set {} } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public int area { get => default; set {} } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
		public bool ignoreFromBuild { get => default; set {} } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
		public static List<NavMeshModifier> activeModifiers { get => default; } // 0x000000018B3C5EE8-0x000000018B3C5F38 
	
		// Constructors
		public NavMeshModifier() {} // 0x000000018B3C5E24-0x000000018B3C5EE8
		static NavMeshModifier() {} // 0x000000018B3C5D98-0x000000018B3C5E24
	
		// Methods
		private void OnEnable() {} // 0x000000018B3C5CE8-0x000000018B3C5D98
		private void OnDisable() {} // 0x000000018B3C5C78-0x000000018B3C5CE8
		public bool AffectsAgentType(int agentTypeID) => default; // 0x000000018B3C5BD8-0x000000018B3C5C78
	}

	public class NavMeshModifierVolume : MonoBehaviour // TypeDefIndex: 60903
	{
		// Fields
		private Vector3 m_Size; // 0x18
		private Vector3 m_Center; // 0x24
		private int m_Area; // 0x30
		private List<int> m_AffectedAgents; // 0x38
		private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers; // 0x00
	
		// Properties
		public Vector3 size { get => default; set {} } // 0x0000000185FB3830-0x0000000185FB3850 0x0000000185FB3850-0x0000000185FB3860
		public Vector3 center { get => default; set {} } // 0x0000000185FB8980-0x0000000185FB89A0 0x0000000185FBC070-0x0000000185FBC080
		public int area { get => default; set {} } // 0x00000001813CFF60-0x00000001813CFF70 0x00000001813D0A90-0x00000001813D0AA0
		public static List<NavMeshModifierVolume> activeModifiers { get => default; } // 0x000000018B3C5B88-0x000000018B3C5BD8 
	
		// Constructors
		public NavMeshModifierVolume() {} // 0x000000018B3C5A8C-0x000000018B3C5B88
		static NavMeshModifierVolume() {} // 0x000000018B3C5A00-0x000000018B3C5A8C
	
		// Methods
		private void OnEnable() {} // 0x000000018B3C5950-0x000000018B3C5A00
		private void OnDisable() {} // 0x000000018B3C58E0-0x000000018B3C5950
		public bool AffectsAgentType(int agentTypeID) => default; // 0x000000018B3C5840-0x000000018B3C58E0
	}

	public enum CollectObjects // TypeDefIndex: 60904
	{
		All = 0,
		Volume = 1,
		Children = 2
	}

	public enum PartitioningMethod // TypeDefIndex: 60905
	{
		Layers = 0,
		Monotone = 1,
		Watershed = 2
	}

	public class NavMeshSurface : MonoBehaviour // TypeDefIndex: 60907
	{
		// Fields
		private int m_AgentTypeID; // 0x18
		private CollectObjects m_CollectObjects; // 0x1C
		private Vector3 m_Size; // 0x20
		private Vector3 m_Center; // 0x2C
		private LayerMask m_LayerMask; // 0x38
		private string m_BlockTag; // 0x40
		private PartitioningMethod m_PartitioningMethod; // 0x48
		private bool m_FilterLowHangingObstacles; // 0x4C
		private bool m_FilterLedgeSpans; // 0x4D
		private bool m_FilterWalkableLowHeightSpans; // 0x4E
		private bool m_OverrideMinRegionArea; // 0x4F
		private float m_MinRegionArea; // 0x50
		private NavMeshCollectGeometry m_UseGeometry; // 0x54
		private int m_DefaultArea; // 0x58
		private bool m_IgnoreNavMeshAgent; // 0x5C
		private bool m_IgnoreNavMeshObstacle; // 0x5D
		private bool m_OverrideTileSize; // 0x5E
		private int m_TileSize; // 0x60
		private bool m_OverrideVoxelSize; // 0x64
		private float m_VoxelSize; // 0x68
		private bool m_BuildHeightMesh; // 0x6C
		private NavMeshData m_NavMeshData; // 0x70
		private NavMeshDataInstance m_NavMeshDataInstance; // 0x78
		private Vector3 m_LastPosition; // 0x7C
		private Quaternion m_LastRotation; // 0x88
		private static readonly List<NavMeshSurface> s_NavMeshSurfaces; // 0x00
	
		// Properties
		public int agentTypeID { get => default; set {} } // 0x0000000185FBAA80-0x0000000185FBAAA0 0x0000000185FBCE10-0x0000000185FBCE20
		public CollectObjects collectObjects { get => default; set {} } // 0x00000001813E5E30-0x00000001813E5E40 0x00000001813E6F50-0x00000001813E6F60
		public Vector3 size { get => default; set {} } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public Vector3 center { get => default; set {} } // 0x0000000185FB0570-0x0000000185FB0580 0x0000000185FB05D0-0x0000000185FB05E0
		public LayerMask layerMask { get => default; set {} } // 0x0000000185FB0B40-0x0000000185FB0B50 0x0000000185FB0B70-0x0000000185FB0B80
		public string BlockTag { get => default; set {} } // 0x0000000185FBE3E0-0x0000000185FBE3F0 0x0000000185FBE3F0-0x0000000185FBE400
		public PartitioningMethod partitioningMethod { get => default; set {} } // 0x0000000185FD1F90-0x0000000185FD1FA0 0x0000000185FD1FD0-0x0000000185FD1FE0
		public bool filterLowHangingObstacles { get => default; set {} } // 0x0000000185FD1FB0-0x0000000185FD1FC0 0x0000000185FD1FF0-0x0000000185FD2000
		public bool filterLedgeSpans { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
		public bool filterWalkableLowHeightSpans { get => default; set {} } // 0x0000000185FB0670-0x0000000185FB0680 0x0000000185FB06A0-0x0000000185FB06B0
		public bool overrideMinRegionArea { get => default; set {} } // 0x0000000183F80450-0x0000000183F80460 0x0000000183F804E0-0x0000000183F804F0
		public float minRegionArea { get => default; set {} } // 0x0000000185FB0C10-0x0000000185FB0C20 0x0000000185FB0C30-0x0000000185FB0C40
		public NavMeshCollectGeometry useGeometry { get => default; set {} } // 0x0000000185FD1FA0-0x0000000185FD1FB0 0x0000000185FD1FE0-0x0000000185FD1FF0
		public int defaultArea { get => default; set {} } // 0x0000000185FD1FC0-0x0000000185FD1FD0 0x0000000185FD2000-0x0000000185FD2010
		public bool ignoreNavMeshAgent { get => default; set {} } // 0x000000018143E3B0-0x000000018143E3C0 0x000000018143E3C0-0x000000018143E3D0
		public bool ignoreNavMeshObstacle { get => default; set {} } // 0x0000000185FBA670-0x0000000185FBA680 0x0000000185FBA680-0x0000000185FBA690
		public bool overrideTileSize { get => default; set {} } // 0x0000000185FB8230-0x0000000185FB8240 0x0000000185FBA690-0x0000000185FBA6A0
		public int tileSize { get => default; set {} } // 0x0000000185FBA660-0x0000000185FBA670 0x0000000185FB1E80-0x0000000185FB1E90
		public bool overrideVoxelSize { get => default; set {} } // 0x0000000181460F70-0x0000000181460F80 0x00000001874BE90C-0x00000001874BE91C
		public float voxelSize { get => default; set {} } // 0x000000018B3C9484-0x000000018B3C94D4 0x000000018B3C8B34-0x000000018B3C8B80
		public bool buildHeightMesh { get => default; set {} } // 0x000000018B3C8AE8-0x000000018B3C8B34 0x000000018B3C6760-0x000000018B3C68D0
		public NavMeshData navMeshData { get => default; set {} } // 0x000000018B3C8D54-0x000000018B3C8D74 0x000000018B3C85B0-0x000000018B3C8710
		public static List<NavMeshSurface> activeSurfaces { get => default; } // 0x000000018B3C6E84-0x000000018B3C717C 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 60906
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<NavMeshModifierVolume> __9__105_0; // 0x08
			public static Predicate<NavMeshModifier> __9__106_0; // 0x10
			public static Predicate<NavMeshBuildSource> __9__106_1; // 0x18
			public static Predicate<NavMeshBuildSource> __9__106_2; // 0x20
	
			// Constructors
			static __c() {} // 0x00000001813AE560-0x00000001813AE570
			public __c() {} // 0x00000001813AE9C0-0x00000001813AE9D0
	
			// Methods
			internal bool _AppendModifierVolumes_b__105_0(NavMeshModifierVolume x) => default; // 0x00000001813AE570-0x00000001813AE580
			internal bool _CollectSources_b__106_0(NavMeshModifier x) => default; // 0x00000001813AE9D0-0x00000001813AE9E0
			internal bool _CollectSources_b__106_1(NavMeshBuildSource x) => default; // 0x0000000185FBAAA0-0x0000000185FBAAC0
			internal bool _CollectSources_b__106_2(NavMeshBuildSource x) => default; // 0x0000000185FBC570-0x0000000185FBC580
		}
	
		// Constructors
		public NavMeshSurface() {} // 0x000000018B3C94F8-0x000000018B3C95B4
		static NavMeshSurface() {} // 0x000000018B3C95B4-0x000000018B3C9670
	
		// Methods
		private void OnEnable() {} // 0x000000018B3C9180-0x000000018B3C9330
		private void OnDisable() {} // 0x000000018B3C8FD0-0x000000018B3C9180
		public void AddData() {} // 0x000000018B3C8B80-0x000000018B3C8D54
		public void RemoveData() {} // 0x000000018B3C8D74-0x000000018B3C8EF0
		public NavMeshBuildSettings GetBuildSettings() => default; // 0x000000018B3C8EF0-0x000000018B3C8F9C
		public void BuildNavMesh() {} // 0x000000018B3C68D0-0x000000018B3C6E84
		public AsyncOperation UpdateNavMesh(NavMeshData data) => default; // 0x000000018B3C7A4C-0x000000018B3C85B0
		public bool UpdateNavMeshSync(NavMeshData data) => default; // 0x0000000185FBEF80-0x0000000185FBEFC0
		private static void Register(NavMeshSurface surface) {} // 0x000000018B3C8710-0x000000018B3C89EC
		private static void Unregister(NavMeshSurface surface) {} // 0x000000018B3C717C-0x000000018B3C7A4C
		private static void UpdateActive() {} // 0x000000018B3C89EC-0x000000018B3C8AE8
		private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources) {} // 0x000000018B3C8F9C-0x000000018B3C8FD0
		private List<NavMeshBuildSource> CollectSources() => default; // 0x000000018B3C93BC-0x000000018B3C9484
		private static Vector3 Abs(Vector3 v) => default; // 0x000000018B3C9330-0x000000018B3C93BC
		private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds) => default; // 0x000000018B3C9670-0x000000018B3C96D4
		private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources) => default; // 0x0000000185492010-0x0000000185492020
		private bool HasTransformChanged() => default; // 0x000000018B3C94D4-0x000000018B3C94F8
		private void UpdateDataIfTransformChanged() {} // 0x000000018B3C94D4-0x000000018B3C94F8
	}
}
