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

// Image 115: NavMeshComponents.dll - Assembly: NavMeshComponents, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63550-63558
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[DefaultExecutionOrder(-102)]
[ExecuteInEditMode]
public class NavMeshPrefabInstance : MonoBehaviour // TypeDefIndex: 63551
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
	public NavMeshData navMeshData { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	public bool followTransform { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x000000018A8904B4-0x000000018A8904BC
	public static List<NavMeshPrefabInstance> trackedInstances { get; } // 0x000000018A890464-0x000000018A8904B4 

	// Constructors
	public NavMeshPrefabInstance(); // 0x0000000185393520-0x0000000185393538
	static NavMeshPrefabInstance(); // 0x000000018A8903D8-0x000000018A890464

	// Methods
	private void OnEnable(); // 0x000000018A890080-0x000000018A8900BC
	private void OnDisable(); // 0x000000018A89005C-0x000000018A890080
	public void UpdateInstance(); // 0x000000018A890264-0x000000018A890288
	private void AddInstance(); // 0x000000018A88FC94-0x000000018A88FDD4
	private void AddTracking(); // 0x000000018A88FDD4-0x000000018A88FF68
	private void RemoveTracking(); // 0x000000018A8900BC-0x000000018A890238
	private void SetFollowTransform(bool value); // 0x000000018A890238-0x000000018A890264
	private bool HasMoved(); // 0x000000018A88FF68-0x000000018A89005C
	private static void UpdateTrackedInstances(); // 0x000000018A890288-0x000000018A8903D8
}

namespace UnityEngine.AI
{
	[AddComponentMenu("Navigation/NavMeshLink", 33)]
	[DefaultExecutionOrder(-101)]
	[ExecuteInEditMode]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshLink : MonoBehaviour // TypeDefIndex: 63552
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
		public int agentTypeID { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x000000018A88F358-0x000000018A88F368
		public Vector3 startRight { get; set; } // 0x0000000184D90520-0x0000000184D90540 0x000000018A88F528-0x000000018A88F59C
		public Vector3 startLeft { get; set; } // 0x0000000184D90C00-0x0000000184D90C20 0x000000018A88F4B4-0x000000018A88F528
		public Vector3 startMid { get; } // 0x000000018A88F2D8-0x000000018A88F358 
		public Vector3 endRight { get; set; } // 0x0000000184D89640-0x0000000184D89660 0x000000018A88F430-0x000000018A88F4A4
		public Vector3 endLeft { get; set; } // 0x0000000184D89660-0x0000000184D89680 0x000000018A88F3BC-0x000000018A88F430
		public Vector3 endMid { get; } // 0x000000018A88F258-0x000000018A88F2D8 
		public bool isExt { get; set; } // 0x0000000184D86910-0x0000000184D86920 0x000000018A88F4A4-0x000000018A88F4B4
		public float costModifier { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x000000018A88F390-0x000000018A88F3BC
		public bool bidirectional { get; set; } // 0x0000000184D86C20-0x0000000184D86C30 0x000000018A88F380-0x000000018A88F390
		public bool autoUpdate { get; set; } // 0x0000000184D86C10-0x0000000184D86C20 0x000000018A88F378-0x000000018A88F380
		public int area { get; set; } // 0x0000000184D86570-0x0000000184D86580 0x000000018A88F368-0x000000018A88F378
	
		// Constructors
		public NavMeshLink(); // 0x000000018A88F194-0x000000018A88F258
		static NavMeshLink(); // 0x000000018A88F108-0x000000018A88F194
	
		// Methods
		private void OnEnable(); // 0x000000018A88ECF0-0x000000018A88ED50
		private void OnDisable(); // 0x000000018A88ECA4-0x000000018A88ECF0
		public void UpdateLink(); // 0x000000018A88EF94-0x000000018A88EFB8
		private static void AddTracking(NavMeshLink link); // 0x000000018A88EA14-0x000000018A88EBA8
		private static void RemoveTracking(NavMeshLink link); // 0x000000018A88ED50-0x000000018A88EECC
		private void SetAutoUpdate(bool value); // 0x000000018A88EECC-0x000000018A88EF30
		private void AddLink(); // 0x000000018A88E850-0x000000018A88EA14
		public void SetByLinkData(NavMeshLinkData data); // 0x000000018A88EF30-0x000000018A88EF94
		private bool HasTransformChanged(); // 0x000000018A88EBA8-0x000000018A88EC9C
		private void OnDidApplyAnimationProperties(); // 0x000000018A88EC9C-0x000000018A88ECA4
		private static void UpdateTrackedInstances(); // 0x000000018A88EFB8-0x000000018A88F108
	}

	[AddComponentMenu("Navigation/NavMeshModifier", 32)]
	[ExecuteInEditMode]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshModifier : MonoBehaviour // TypeDefIndex: 63553
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
		public bool overrideArea { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public int area { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
		public bool ignoreFromBuild { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
		public static List<NavMeshModifier> activeModifiers { get; } // 0x000000018A88FC44-0x000000018A88FC94 
	
		// Constructors
		public NavMeshModifier(); // 0x000000018A88FB80-0x000000018A88FC44
		static NavMeshModifier(); // 0x000000018A88FAF4-0x000000018A88FB80
	
		// Methods
		private void OnEnable(); // 0x000000018A88FA44-0x000000018A88FAF4
		private void OnDisable(); // 0x000000018A88F9D4-0x000000018A88FA44
		public bool AffectsAgentType(int agentTypeID); // 0x000000018A88F934-0x000000018A88F9D4
	}

	[AddComponentMenu("Navigation/NavMeshModifierVolume", 31)]
	[ExecuteInEditMode]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshModifierVolume : MonoBehaviour // TypeDefIndex: 63554
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
		public Vector3 size { get; set; } // 0x0000000184D89870-0x0000000184D89890 0x0000000184D89890-0x0000000184D898A0
		public Vector3 center { get; set; } // 0x0000000184D905E0-0x0000000184D90600 0x0000000184D905D0-0x0000000184D905E0
		public int area { get; set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		public static List<NavMeshModifierVolume> activeModifiers { get; } // 0x000000018A88F8E4-0x000000018A88F934 
	
		// Constructors
		public NavMeshModifierVolume(); // 0x000000018A88F7E8-0x000000018A88F8E4
		static NavMeshModifierVolume(); // 0x000000018A88F75C-0x000000018A88F7E8
	
		// Methods
		private void OnEnable(); // 0x000000018A88F6AC-0x000000018A88F75C
		private void OnDisable(); // 0x000000018A88F63C-0x000000018A88F6AC
		public bool AffectsAgentType(int agentTypeID); // 0x000000018A88F59C-0x000000018A88F63C
	}

	public enum CollectObjects // TypeDefIndex: 63555
	{
		All = 0,
		Volume = 1,
		Children = 2
	}

	public enum PartitioningMethod // TypeDefIndex: 63556
	{
		Layers = 0,
		Monotone = 1,
		Watershed = 2
	}

	[AddComponentMenu("Navigation/NavMeshSurface", 30)]
	[DefaultExecutionOrder(-102)]
	[ExecuteAlways]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshSurface : MonoBehaviour // TypeDefIndex: 63558
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
		public int agentTypeID { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public CollectObjects collectObjects { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
		public Vector3 size { get; set; } // 0x0000000184D90830-0x0000000184D90850 0x0000000184D90820-0x0000000184D90830
		public Vector3 center { get; set; } // 0x0000000184D90540-0x0000000184D90560 0x0000000184D90510-0x0000000184D90520
		public LayerMask layerMask { get; set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
		public string BlockTag { get; set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public PartitioningMethod partitioningMethod { get; set; } // 0x0000000184D863D0-0x0000000184D863E0 0x0000000184D86450-0x0000000184D86460
		public bool filterLowHangingObstacles { get; set; } // 0x0000000184D86910-0x0000000184D86920 0x0000000184D86920-0x0000000184D86930
		public bool filterLedgeSpans { get; set; } // 0x0000000184D926B0-0x0000000184D926C0 0x0000000184D926C0-0x0000000184D926D0
		public bool filterWalkableLowHeightSpans { get; set; } // 0x0000000184DA5B30-0x0000000184DA5B40 0x0000000184DA5B70-0x0000000184DA5B80
		public bool overrideMinRegionArea { get; set; } // 0x0000000184DA5B50-0x0000000184DA5B60 0x0000000184DA5B90-0x0000000184DA5BA0
		public float minRegionArea { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
		public NavMeshCollectGeometry useGeometry { get; set; } // 0x0000000184D86540-0x0000000184D86550 0x0000000184D86590-0x0000000184D865A0
		public int defaultArea { get; set; } // 0x0000000184D86570-0x0000000184D86580 0x0000000184D865D0-0x0000000184D865E0
		public bool ignoreNavMeshAgent { get; set; } // 0x0000000184D86D90-0x0000000184D86DA0 0x0000000184D86DB0-0x0000000184D86DC0
		public bool ignoreNavMeshObstacle { get; set; } // 0x0000000184DA5B40-0x0000000184DA5B50 0x0000000184DA5B80-0x0000000184DA5B90
		public bool overrideTileSize { get; set; } // 0x0000000184DA5B60-0x0000000184DA5B70 0x0000000184DA5BA0-0x0000000184DA5BB0
		public int tileSize { get; set; } // 0x0000000184D86790-0x0000000184D867A0 0x0000000184D86D50-0x0000000184D86D60
		public bool overrideVoxelSize { get; set; } // 0x0000000184D8F050-0x0000000184D8F060 0x0000000184D8F080-0x0000000184D8F090
		public float voxelSize { get; set; } // 0x0000000184D8F060-0x0000000184D8F070 0x0000000184D8F090-0x0000000184D8F0A0
		public bool buildHeightMesh { get; set; } // 0x0000000184D8F040-0x0000000184D8F050 0x0000000184D87F30-0x0000000184D87F40
		public NavMeshData navMeshData { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
		public static List<NavMeshSurface> activeSurfaces { get; } // 0x000000018A892F6C-0x000000018A892FBC 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 63557
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<NavMeshModifierVolume> __9__105_0; // 0x08
			public static Predicate<NavMeshModifier> __9__106_0; // 0x10
			public static Predicate<NavMeshBuildSource> __9__106_1; // 0x18
			public static Predicate<NavMeshBuildSource> __9__106_2; // 0x20
	
			// Constructors
			static __c(); // 0x000000018A893158-0x000000018A893240
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _AppendModifierVolumes_b__105_0(NavMeshModifierVolume x); // 0x000000018A892FBC-0x000000018A892FE0
			internal bool _CollectSources_b__106_0(NavMeshModifier x); // 0x000000018A892FBC-0x000000018A892FE0
			internal bool _CollectSources_b__106_1(NavMeshBuildSource x); // 0x000000018A892FE0-0x000000018A89309C
			internal bool _CollectSources_b__106_2(NavMeshBuildSource x); // 0x000000018A89309C-0x000000018A893158
		}
	
		// Constructors
		public NavMeshSurface(); // 0x000000018A892EA4-0x000000018A892F6C
		static NavMeshSurface(); // 0x000000018A892E18-0x000000018A892EA4
	
		// Methods
		private void OnEnable(); // 0x000000018A89261C-0x000000018A892668
		private void OnDisable(); // 0x000000018A8925D0-0x000000018A89261C
		public void AddData(); // 0x000000018A8904BC-0x000000018A89062C
		public void RemoveData(); // 0x000000018A89283C-0x000000018A89285C
		public NavMeshBuildSettings GetBuildSettings(); // 0x000000018A892098-0x000000018A8921F8
		public void BuildNavMesh(); // 0x000000018A890BE0-0x000000018A890ED8
		public AsyncOperation UpdateNavMesh(NavMeshData data); // 0x000000018A892C68-0x000000018A892E18
		public bool UpdateNavMeshSync(NavMeshData data); // 0x000000018A892AB8-0x000000018A892C68
		private static void Register(NavMeshSurface surface); // 0x000000018A892668-0x000000018A89283C
		private static void Unregister(NavMeshSurface surface); // 0x000000018A89285C-0x000000018A8929D8
		private static void UpdateActive(); // 0x000000018A8929D8-0x000000018A892A84
		private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources); // 0x000000018A89062C-0x000000018A890BE0
		private List<NavMeshBuildSource> CollectSources(); // 0x000000018A8917A8-0x000000018A892098
		private static Vector3 Abs(Vector3 v); // 0x0000000184D92AA0-0x0000000184D92AE0
		private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds); // 0x000000018A8921F8-0x000000018A8924D4
		private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources); // 0x000000018A890ED8-0x000000018A8917A8
		private bool HasTransformChanged(); // 0x000000018A8924D4-0x000000018A8925D0
		private void UpdateDataIfTransformChanged(); // 0x000000018A892A84-0x000000018A892AB8
	}
}
