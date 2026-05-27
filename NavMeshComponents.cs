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

// Image 109: NavMeshComponents.dll - Assembly: NavMeshComponents, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59795-59803
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[DefaultExecutionOrder(-102)]
[ExecuteInEditMode]
public class NavMeshPrefabInstance : MonoBehaviour // TypeDefIndex: 59796
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
	public NavMeshData navMeshData { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	public bool followTransform { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x000000018929C3A0-0x000000018929C3A8
	public static List<NavMeshPrefabInstance> trackedInstances { get => default; } // 0x000000018929C350-0x000000018929C3A0 

	// Constructors
	public NavMeshPrefabInstance() {} // 0x000000018426FE60-0x000000018426FE68
	static NavMeshPrefabInstance() {} // 0x000000018929C2C4-0x000000018929C350

	// Methods
	private void OnEnable() {} // 0x000000018929BF6C-0x000000018929BFA8
	private void OnDisable() {} // 0x000000018929BF48-0x000000018929BF6C
	public void UpdateInstance() {} // 0x000000018929C150-0x000000018929C174
	private void AddInstance() {} // 0x000000018929BB80-0x000000018929BCC0
	private void AddTracking() {} // 0x000000018929BCC0-0x000000018929BE54
	private void RemoveTracking() {} // 0x000000018929BFA8-0x000000018929C124
	private void SetFollowTransform(bool value) {} // 0x000000018929C124-0x000000018929C150
	private bool HasMoved() => default; // 0x000000018929BE54-0x000000018929BF48
	private static void UpdateTrackedInstances() {} // 0x000000018929C174-0x000000018929C2C4
}

namespace UnityEngine.AI
{
	[AddComponentMenu("Navigation/NavMeshLink", 33)]
	[DefaultExecutionOrder(-101)]
	[ExecuteInEditMode]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshLink : MonoBehaviour // TypeDefIndex: 59797
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
		public int agentTypeID { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x000000018929B244-0x000000018929B254
		public Vector3 startRight { get => default; set {} } // 0x0000000183D568F0-0x0000000183D56910 0x000000018929B414-0x000000018929B488
		public Vector3 startLeft { get => default; set {} } // 0x0000000183D50E80-0x0000000183D50EA0 0x000000018929B3A0-0x000000018929B414
		public Vector3 startMid { get => default; } // 0x000000018929B1C4-0x000000018929B244 
		public Vector3 endRight { get => default; set {} } // 0x0000000183D522E0-0x0000000183D52300 0x000000018929B31C-0x000000018929B390
		public Vector3 endLeft { get => default; set {} } // 0x0000000183D52300-0x0000000183D52320 0x000000018929B2A8-0x000000018929B31C
		public Vector3 endMid { get => default; } // 0x000000018929B144-0x000000018929B1C4 
		public bool isExt { get => default; set {} } // 0x0000000183D4F520-0x0000000183D4F530 0x000000018929B390-0x000000018929B3A0
		public float costModifier { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x000000018929B27C-0x000000018929B2A8
		public bool bidirectional { get => default; set {} } // 0x0000000183D4F320-0x0000000183D4F330 0x000000018929B26C-0x000000018929B27C
		public bool autoUpdate { get => default; set {} } // 0x0000000183D4F310-0x0000000183D4F320 0x000000018929B264-0x000000018929B26C
		public int area { get => default; set {} } // 0x0000000183D4EF00-0x0000000183D4EF10 0x000000018929B254-0x000000018929B264
	
		// Constructors
		public NavMeshLink() {} // 0x000000018929B080-0x000000018929B144
		static NavMeshLink() {} // 0x000000018929AFF4-0x000000018929B080
	
		// Methods
		private void OnEnable() {} // 0x000000018929ABDC-0x000000018929AC3C
		private void OnDisable() {} // 0x000000018929AB90-0x000000018929ABDC
		public void UpdateLink() {} // 0x000000018929AE80-0x000000018929AEA4
		private static void AddTracking(NavMeshLink link) {} // 0x000000018929A900-0x000000018929AA94
		private static void RemoveTracking(NavMeshLink link) {} // 0x000000018929AC3C-0x000000018929ADB8
		private void SetAutoUpdate(bool value) {} // 0x000000018929ADB8-0x000000018929AE1C
		private void AddLink() {} // 0x000000018929A73C-0x000000018929A900
		public void SetByLinkData(NavMeshLinkData data) {} // 0x000000018929AE1C-0x000000018929AE80
		private bool HasTransformChanged() => default; // 0x000000018929AA94-0x000000018929AB88
		private void OnDidApplyAnimationProperties() {} // 0x000000018929AB88-0x000000018929AB90
		private static void UpdateTrackedInstances() {} // 0x000000018929AEA4-0x000000018929AFF4
	}

	[AddComponentMenu("Navigation/NavMeshModifier", 32)]
	[ExecuteInEditMode]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshModifier : MonoBehaviour // TypeDefIndex: 59798
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
		public bool overrideArea { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public int area { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		public bool ignoreFromBuild { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
		public static List<NavMeshModifier> activeModifiers { get => default; } // 0x000000018929BB30-0x000000018929BB80 
	
		// Constructors
		public NavMeshModifier() {} // 0x000000018929BA6C-0x000000018929BB30
		static NavMeshModifier() {} // 0x000000018929B9E0-0x000000018929BA6C
	
		// Methods
		private void OnEnable() {} // 0x000000018929B930-0x000000018929B9E0
		private void OnDisable() {} // 0x000000018929B8C0-0x000000018929B930
		public bool AffectsAgentType(int agentTypeID) => default; // 0x000000018929B820-0x000000018929B8C0
	}

	[AddComponentMenu("Navigation/NavMeshModifierVolume", 31)]
	[ExecuteInEditMode]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshModifierVolume : MonoBehaviour // TypeDefIndex: 59799
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
		public Vector3 size { get => default; set {} } // 0x0000000183D52510-0x0000000183D52530 0x0000000183D52530-0x0000000183D52540
		public Vector3 center { get => default; set {} } // 0x0000000183D59780-0x0000000183D597A0 0x0000000183D5A9E0-0x0000000183D5A9F0
		public int area { get => default; set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		public static List<NavMeshModifierVolume> activeModifiers { get => default; } // 0x000000018929B7D0-0x000000018929B820 
	
		// Constructors
		public NavMeshModifierVolume() {} // 0x000000018929B6D4-0x000000018929B7D0
		static NavMeshModifierVolume() {} // 0x000000018929B648-0x000000018929B6D4
	
		// Methods
		private void OnEnable() {} // 0x000000018929B598-0x000000018929B648
		private void OnDisable() {} // 0x000000018929B528-0x000000018929B598
		public bool AffectsAgentType(int agentTypeID) => default; // 0x000000018929B488-0x000000018929B528
	}

	public enum CollectObjects // TypeDefIndex: 59800
	{
		All = 0,
		Volume = 1,
		Children = 2
	}

	public enum PartitioningMethod // TypeDefIndex: 59801
	{
		Layers = 0,
		Monotone = 1,
		Watershed = 2
	}

	[AddComponentMenu("Navigation/NavMeshSurface", 30)]
	[DefaultExecutionOrder(-102)]
	[ExecuteAlways]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshSurface : MonoBehaviour // TypeDefIndex: 59803
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
		public int agentTypeID { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public CollectObjects collectObjects { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		public Vector3 size { get => default; set {} } // 0x0000000183D59660-0x0000000183D59680 0x0000000183D5AE00-0x0000000183D5AE10
		public Vector3 center { get => default; set {} } // 0x0000000183D59800-0x0000000183D59820 0x0000000183D5BF30-0x0000000183D5BF40
		public LayerMask layerMask { get => default; set {} } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		public string BlockTag { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public PartitioningMethod partitioningMethod { get => default; set {} } // 0x0000000183D4EC50-0x0000000183D4EC60 0x0000000183D4ECD0-0x0000000183D4ECE0
		public bool filterLowHangingObstacles { get => default; set {} } // 0x0000000183D4F520-0x0000000183D4F530 0x0000000183D4F550-0x0000000183D4F560
		public bool filterLedgeSpans { get => default; set {} } // 0x0000000183D5CEB0-0x0000000183D5CEC0 0x0000000183D5CEC0-0x0000000183D5CED0
		public bool filterWalkableLowHeightSpans { get => default; set {} } // 0x0000000183D71340-0x0000000183D71350 0x0000000183D71380-0x0000000183D71390
		public bool overrideMinRegionArea { get => default; set {} } // 0x0000000183D71360-0x0000000183D71370 0x0000000183D713A0-0x0000000183D713B0
		public float minRegionArea { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
		public NavMeshCollectGeometry useGeometry { get => default; set {} } // 0x0000000183D4EEC0-0x0000000183D4EED0 0x0000000183D4EF10-0x0000000183D4EF20
		public int defaultArea { get => default; set {} } // 0x0000000183D4EF00-0x0000000183D4EF10 0x0000000183D4EF50-0x0000000183D4EF60
		public bool ignoreNavMeshAgent { get => default; set {} } // 0x0000000183D4F600-0x0000000183D4F610 0x0000000183D4F620-0x0000000183D4F630
		public bool ignoreNavMeshObstacle { get => default; set {} } // 0x0000000183D71350-0x0000000183D71360 0x0000000183D71390-0x0000000183D713A0
		public bool overrideTileSize { get => default; set {} } // 0x0000000183D71370-0x0000000183D71380 0x0000000183D713B0-0x0000000183D713C0
		public int tileSize { get => default; set {} } // 0x0000000183D4F050-0x0000000183D4F060 0x0000000183D4F5A0-0x0000000183D4F5B0
		public bool overrideVoxelSize { get => default; set {} } // 0x0000000183D590F0-0x0000000183D59100 0x0000000183D59100-0x0000000183D59110
		public float voxelSize { get => default; set {} } // 0x0000000183D56A40-0x0000000183D56A50 0x0000000183D59110-0x0000000183D59120
		public bool buildHeightMesh { get => default; set {} } // 0x0000000183D590E0-0x0000000183D590F0 0x0000000183D50950-0x0000000183D50960
		public NavMeshData navMeshData { get => default; set {} } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		public static List<NavMeshSurface> activeSurfaces { get => default; } // 0x000000018929F0CC-0x000000018929F11C 
	
		// Constructors
		public NavMeshSurface() {} // 0x000000018929F004-0x000000018929F0CC
		static NavMeshSurface() {} // 0x000000018929EF78-0x000000018929F004
	
		// Methods
		private void OnEnable() {} // 0x000000018929E77C-0x000000018929E7C8
		private void OnDisable() {} // 0x000000018929E730-0x000000018929E77C
		public void AddData() {} // 0x000000018929C3A8-0x000000018929C518
		public void RemoveData() {} // 0x000000018929E99C-0x000000018929E9BC
		public NavMeshBuildSettings GetBuildSettings() => default; // 0x000000018929E1F8-0x000000018929E358
		public void BuildNavMesh() {} // 0x000000018929CACC-0x000000018929CDC4
		public AsyncOperation UpdateNavMesh(NavMeshData data) => default; // 0x000000018929EDC8-0x000000018929EF78
		public bool UpdateNavMeshSync(NavMeshData data) => default; // 0x000000018929EC18-0x000000018929EDC8
		private static void Register(NavMeshSurface surface) {} // 0x000000018929E7C8-0x000000018929E99C
		private static void Unregister(NavMeshSurface surface) {} // 0x000000018929E9BC-0x000000018929EB38
		private static void UpdateActive() {} // 0x000000018929EB38-0x000000018929EBE4
		private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources) {} // 0x000000018929C518-0x000000018929CACC
		private List<NavMeshBuildSource> CollectSources() => default; // 0x000000018929D694-0x000000018929E1F8
		private static Vector3 Abs(Vector3 v) => default; // 0x0000000183D5DA60-0x0000000183D5DAA0
		private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds) => default; // 0x000000018929E358-0x000000018929E634
		private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources) => default; // 0x000000018929CDC4-0x000000018929D694
		private bool HasTransformChanged() => default; // 0x000000018929E634-0x000000018929E730
		private void UpdateDataIfTransformChanged() {} // 0x000000018929EBE4-0x000000018929EC18
	}
}
