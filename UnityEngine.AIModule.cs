/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

// Image 89: UnityEngine.AIModule.dll - Assembly: UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59301-59329

namespace UnityEngine.AI
{
	[MovedFrom("UnityEngine")]
	public enum NavMeshPathStatus // TypeDefIndex: 59304
	{
		PathComplete = 0,
		PathPartial = 1,
		PathInvalid = 2,
		PathProcessing = 3
	}

	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/NavMeshPath.bindings.h")]
	public sealed class NavMeshPath // TypeDefIndex: 59305
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
		internal Vector3[] m_Corners; // 0x18
		internal int[] m_Areas; // 0x20
		internal Vector3[] m_DividingPos; // 0x28
	
		// Properties
		public Vector3[] corners { get => default; } // 0x000000018427050C-0x0000000184270528 
		public NavMeshPathStatus status { get => default; } // 0x0000000182549C30-0x0000000182549C70 
		public bool needRepath { get => default; set {} } // 0x0000000182792AE0-0x0000000182792B20 0x000000018353BA50-0x000000018353BAA0
		public bool calcAutoRepath { set {} } // 0x000000018353BA00-0x000000018353BA50
	
		// Constructors
		public NavMeshPath() {} // 0x0000000182A810E0-0x0000000182A81100
	
		// Methods
		~NavMeshPath() {} // 0x0000000183B29410-0x0000000183B294A0
		[FreeFunction("NavMeshPathScriptBindings::InitializeNavMeshPath")]
		private static IntPtr InitializeNavMeshPath() => default; // 0x0000000182A81100-0x0000000182A81140
		[FreeFunction("NavMeshPathScriptBindings::DestroyNavMeshPath", IsThreadSafe = true)]
		private static void DestroyNavMeshPath(IntPtr ptr) {} // 0x0000000183B294A0-0x0000000183B294E0
		[FreeFunction("NavMeshPathScriptBindings::GetCornersNonAlloc", HasExplicitThis = true)]
		public int GetCornersNonAlloc(out Vector3[] corners, out int[] areas = null, out Vector3[] dividingPos = null) {
			corners = default;
			areas = default;
			dividingPos = default;
			return default;
		} // 0x00000001839CB050-0x00000001839CB0C0
		[FreeFunction("NavMeshPathScriptBindings::GetPolyCount", HasExplicitThis = true)]
		public int GetPolyCount() => default; // 0x0000000183B41FD0-0x0000000183B42010
		[FreeFunction("NavMeshPathScriptBindings::CalculateCornersInternal", HasExplicitThis = true)]
		private Vector3[] CalculateCornersInternal() => default; // 0x0000000183C9C4B0-0x0000000183C9C4F0
		[FreeFunction("NavMeshPathScriptBindings::ClearCornersInternal", HasExplicitThis = true)]
		private void ClearCornersInternal() {} // 0x000000018278F2A0-0x000000018278F2E0
		public void ClearCorners() {} // 0x000000018278F270-0x000000018278F2A0
		private void CalculateCorners() {} // 0x0000000183C9C480-0x0000000183C9C4B0
	}

	[NativeHeader("Modules/AI/Builder/NavMeshBuilder.bindings.h")]
	[StaticAccessor("NavMeshBuilderBindings", StaticAccessorType.DoubleColon)]
	public static class NavMeshBuilder // TypeDefIndex: 59306
	{
		// Methods
		public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) {} // 0x0000000189D7E590-0x0000000189D7E79C
		public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) {} // 0x0000000189D7E3E0-0x0000000189D7E590
		private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) => default; // 0x0000000189D7E3AC-0x0000000189D7E3E0
		public static void CollectSourcesV2(Bounds includedWorldBounds, int includedLayerMask, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) {} // 0x0000000183B74A70-0x0000000183B74BD0
		private static NavMeshBuildSource[] CollectSourcesV2Internal(int includedLayerMask, Bounds includedWorldBounds, int defaultArea, NavMeshBuildMarkup[] markups) => default; // 0x0000000184276F7C-0x0000000184276F94
		public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation, bool useSubJob = false /* Metadata: 0x01FDCFB4 */) => default; // 0x0000000189D7E1BC-0x0000000189D7E34C
		public static bool UpdateNavMeshData(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, bool useSubJob = false /* Metadata: 0x01FDCFB5 */) => default; // 0x0000000189D7E820-0x0000000189D7E9C8
		private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds, bool useSubJob) => default; // 0x0000000189D7E800-0x0000000189D7E820
		public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, bool useSubJob = false /* Metadata: 0x01FDCFB6 */) => default; // 0x0000000183CA7E70-0x0000000183CA7FB0
		private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds, bool useSubJob) => default; // 0x0000000184277004-0x0000000184277024
		private static NavMeshBuildSource[] CollectSourcesInternal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) => default; // 0x0000000189D7E34C-0x0000000189D7E3AC
		private static NavMeshBuildSource[] CollectSourcesV2Internal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, int defaultArea, NavMeshBuildMarkup[] markups) => default; // 0x0000000183D460F0-0x0000000183D46160
		private static bool UpdateNavMeshDataListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds, bool useSubJob) => default; // 0x0000000189D7E79C-0x0000000189D7E800
		private static AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds, bool useSubJob) => default; // 0x0000000183CA7FB0-0x0000000183CA8030
	}

	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/Components/HGNavMeshAgent.bindings.h")]
	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	public sealed class HGNavMeshAgent : UnityEngine.Behaviour // TypeDefIndex: 59307
	{
		// Constructors
		public HGNavMeshAgent() {} // Dummy constructor
	}

	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	[NativeHeader("Modules/AI/Components/NavMeshAgent.bindings.h")]
	public sealed class NavMeshAgent : UnityEngine.Behaviour // TypeDefIndex: 59308
	{
		// Constructors
		public NavMeshAgent() {} // Dummy constructor
	}

	[MovedFrom("UnityEngine")]
	public enum NavMeshObstacleShape // TypeDefIndex: 59309
	{
		Capsule = 0,
		Box = 1,
		Polygon = 2
	}

	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/Components/NavMeshObstacle.bindings.h")]
	public sealed class NavMeshObstacle : UnityEngine.Behaviour // TypeDefIndex: 59310
	{
		// Properties
		public float height { get => default; set {} } // 0x0000000189D7EBF4-0x0000000189D7EC28 0x0000000189D7EC5C-0x0000000189D7ECA0
		public float radius { get => default; set {} } // 0x0000000189D7EC28-0x0000000189D7EC5C 0x0000000189D7ECA0-0x0000000189D7ECE4
		public bool carving { set {} } // 0x00000001833913A0-0x00000001833913F0
		public bool carveOnlyStationary { set {} } // 0x00000001833912B0-0x0000000183391300
		public NavMeshObstacleShape shape { set {} } // 0x0000000183391260-0x00000001833912B0
		public Vector3 center { get => default; set {} } // 0x0000000189D7EBC8-0x0000000189D7EBF4 0x00000001842761A4-0x00000001842761B8
		public Vector3 size { [FreeFunction("NavMeshObstacleScriptBindings::GetSize", HasExplicitThis = true)] get => default; [FreeFunction("NavMeshObstacleScriptBindings::SetSize", HasExplicitThis = true)] set {} } // 0x00000001836A9CD0-0x00000001836A9D00 0x00000001842761B8-0x00000001842761CC
		public int ignoredSurfaceID { set {} } // 0x0000000183391300-0x0000000183391350
		public int carveArea { set {} } // 0x0000000183391350-0x00000001833913A0
	
		// Constructors
		public NavMeshObstacle() {} // Dummy constructor
	
		// Methods
		private void get_center_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189D7EB84-0x0000000189D7EBC8
		private void set_center_Injected(ref Vector3 value) {} // 0x0000000183391440-0x0000000183391560
		private void get_size_Injected(out Vector3 ret) {
			ret = default;
		} // 0x00000001836A9C80-0x00000001836A9CD0
		private void set_size_Injected(ref Vector3 value) {} // 0x00000001833913F0-0x0000000183391440
	}

	[MovedFrom("UnityEngine")]
	public struct NavMeshHit // TypeDefIndex: 59311
	{
		// Fields
		private Vector3 m_Position; // 0x00
		private Vector3 m_Normal; // 0x0C
		private float m_Distance; // 0x18
		private int m_Mask; // 0x1C
		private int m_Hit; // 0x20
	
		// Properties
		public Vector3 position { get => default; } // 0x0000000183D85920-0x0000000183D85940 
		public Vector3 normal { get => default; } // 0x0000000183D85900-0x0000000183D85920 
		public bool hit { get => default; } // 0x0000000189D7EAAC-0x0000000189D7EAB4 
	}

	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	public sealed class NavMeshData : UnityEngine.Object // TypeDefIndex: 59312
	{
		// Properties
		public Bounds sourceBounds { get => default; } // 0x0000000182CBB140-0x0000000182CBB170 
		public Vector3 position { get => default; set {} } // 0x0000000183D2D9D0-0x0000000183D2DA00 0x0000000189D7EA84-0x0000000189D7EA98
		public Quaternion rotation { get => default; set {} } // 0x0000000183D36230-0x0000000183D36260 0x0000000189D7EA98-0x0000000189D7EAAC
	
		// Constructors
		public NavMeshData() {} // Dummy constructor
		public NavMeshData(int agentTypeID) {} // 0x0000000183D28AF0-0x0000000183D28B50
	
		// Methods
		[StaticAccessor("NavMeshDataBindings", StaticAccessorType.DoubleColon)]
		private static void Internal_Create([Writable] NavMeshData mono, int agentTypeID) {} // 0x0000000183D28B50-0x0000000183D28BA0
		public void AppendExtOffMeshLink(Vector3 start, Vector3 end, float width, bool bidirectional, int area, float costModifier) {} // 0x000000018359F320-0x000000018359F600
		[NativeMethod("AppendExtOffMeshLink")]
		internal void Internal_AppendExtOffMeshLink(Vector3 startLeft, Vector3 startRight, Vector3 endRight, Vector3 endLeft, bool bidirectional, int area, float costModifier) {} // 0x00000001842766E8-0x0000000184276734
		private void get_sourceBounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x0000000182CBB170-0x0000000182CBB1C0
		private void get_position_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000183D2DA00-0x0000000183D2DA50
		private void set_position_Injected(ref Vector3 value) {} // 0x0000000183D49200-0x0000000183D49250
		private void get_rotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x0000000183D36260-0x0000000183D362B0
		private void set_rotation_Injected(ref Quaternion value) {} // 0x0000000183D491B0-0x0000000183D49200
		private void Internal_AppendExtOffMeshLink_Injected(ref Vector3 startLeft, ref Vector3 startRight, ref Vector3 endRight, ref Vector3 endLeft, bool bidirectional, int area, float costModifier) {} // 0x000000018359F600-0x000000018359F680
	}

	public struct NavMeshDataInstance // TypeDefIndex: 59313
	{
		// Properties
		public bool valid { get => default; } // 0x00000001825532C0-0x00000001825532E0 
		internal int id { [IsReadOnly] get; set; } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int handleId { get => default; set {} } // 0x0000000183D85860-0x0000000183D85870 0x0000000183D4E970-0x0000000183D4E980
		public UnityEngine.Object owner { set {} } // 0x0000000189D7E9D4-0x0000000189D7EA84
	
		// Methods
		public void Remove() {} // 0x0000000189D7E9C8-0x0000000189D7E9D4
	}

	public struct NavMeshLinkData // TypeDefIndex: 59314
	{
		// Fields
		private bool m_IsExt; // 0x00
		private Vector3 m_StartLeft; // 0x04
		private Vector3 m_StartRight; // 0x10
		private Vector3 m_EndRight; // 0x1C
		private Vector3 m_EndLeft; // 0x28
		private float m_CostModifier; // 0x34
		private int m_Bidirectional; // 0x38
		private int m_Area; // 0x3C
		private int m_AgentTypeID; // 0x40
	
		// Properties
		public bool isExt { get => default; set {} } // 0x0000000183D859A0-0x0000000183D859B0 0x0000000183D4F9D0-0x0000000183D4F9E0
		public Vector3 startLeft { get => default; set {} } // 0x0000000183D859B0-0x0000000183D859D0 0x0000000183D77290-0x0000000183D772A0
		public Vector3 startRight { get => default; set {} } // 0x0000000183D859D0-0x0000000183D859F0 0x0000000183D55570-0x0000000183D55580
		public Vector3 endRight { get => default; set {} } // 0x0000000183D85980-0x0000000183D859A0 0x0000000183D5CBC0-0x0000000183D5CBD0
		public Vector3 endLeft { get => default; set {} } // 0x0000000183D85960-0x0000000183D85980 0x0000000183D50F50-0x0000000183D50F60
		public float costModifier { get => default; set {} } // 0x00000001842743D0-0x00000001842743D8 0x0000000183D56CB0-0x0000000183D56CC0
		public bool bidirectional { get => default; set {} } // 0x0000000185F42DD8-0x0000000185F42DE0 0x000000018300B960-0x000000018300B980
		public int area { get => default; set {} } // 0x0000000183D85950-0x0000000183D85960 0x0000000183D4EDC0-0x0000000183D4EDD0
		public int agentTypeID { get => default; set {} } // 0x0000000183D85940-0x0000000183D85950 0x0000000183D4EDB0-0x0000000183D4EDC0
	}

	public struct NavMeshLinkInstance // TypeDefIndex: 59315
	{
		// Properties
		public bool valid { get => default; } // 0x0000000189D7EAC0-0x0000000189D7EAD4 
		internal int id { [IsReadOnly] get; set; } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public UnityEngine.Object owner { set {} } // 0x0000000189D7EAD4-0x0000000189D7EB84
	
		// Methods
		public void Remove() {} // 0x0000000189D7EAB4-0x0000000189D7EAC0
	}

	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/NavMeshManager.h")]
	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	[StaticAccessor("NavMeshBindings", StaticAccessorType.DoubleColon)]
	public static class NavMesh // TypeDefIndex: 59318
	{
		// Fields
		public static OnNavMeshPreUpdate onPreUpdate; // 0x00
		public static OnUnloadFinishDelegate onUnloadFinish; // 0x08
	
		// Nested types
		public delegate void OnNavMeshPreUpdate(); // TypeDefIndex: 59316; 0x00000001842729A4-0x00000001842729BC
	
		public delegate void OnUnloadFinishDelegate(ulong surfTileID); // TypeDefIndex: 59317; 0x00000001842704D4-0x000000018427050C
	
		// Methods
		[RequiredByNativeCode]
		private static void Internal_CallOnNavMeshPreUpdate() {} // 0x0000000189D7EEDC-0x0000000189D7EEF0
		public static bool Raycast(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, int areaMask) {
			hit = default;
			return default;
		} // 0x00000001842729BC-0x00000001842729D4
		public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd = true /* Metadata: 0x01FDCFBA */, int agentTypeID = -1 /* Metadata: 0x01FDCFBB */, float radius = -1f /* Metadata: 0x01FDCFBC */) => default; // 0x000000018384AD30-0x000000018384AD70
		private static bool CalculatePathInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius) => default; // 0x000000018307EDA0-0x000000018307EE00
		public static bool FindClosestEdge(Vector3 sourcePosition, out NavMeshHit hit, int areaMask) {
			hit = default;
			return default;
		} // 0x0000000182CBB080-0x0000000182CBB140
		public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask) {
			hit = default;
			return default;
		} // 0x0000000189D7F21C-0x0000000189D7F30C
		[NativeName("GetAreaFromName")]
		[StaticAccessor("GetNavMeshProjectSettings()")]
		public static int GetAreaFromName(string areaName) => default; // 0x0000000189D7F1A0-0x0000000189D7F1A8
		public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData) => default; // 0x00000001825532E0-0x0000000182553320
		public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation) => default; // 0x0000000189D7F074-0x0000000189D7F0A8
		public static void UpdateSurfaceTransform(NavMeshDataInstance handle, Vector3 position, Quaternion rotation) {} // 0x0000000189D7EF38-0x0000000189D7EF78
		public static void RemoveNavMeshData(NavMeshDataInstance handle) {} // 0x0000000189D7EEF8-0x0000000189D7EF38
		[NativeName("IsValidSurfaceID")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool IsValidNavMeshDataHandle(int handle) => default; // 0x000000018307EE00-0x000000018307EE40
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool IsValidLinkHandle(int handle) => default; // 0x00000001842730B8-0x00000001842730CC
		[NativeName("SetSurfaceUserID")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool InternalSetOwner(int dataID, int ownerID) => default; // 0x0000000189D7F16C-0x0000000189D7F1A0
		[NativeName("SetLinkUserID")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool InternalSetLinkOwner(int linkID, int ownerID) => default; // 0x000000018300B8D0-0x000000018300B960
		[NativeName("LoadData")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static int AddNavMeshDataInternal(NavMeshData navMeshData) => default; // 0x0000000189D7F164-0x0000000189D7F16C
		[NativeName("LoadData")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation) => default; // 0x00000001842749B0-0x00000001842749C4
		[NativeName("UnloadData")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void RemoveNavMeshDataInternal(int handle) {} // 0x0000000189D7F130-0x0000000189D7F164
		public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation) => default; // 0x000000018307F1C0-0x000000018307F200
		public static void RemoveLink(NavMeshLinkInstance handle) {} // 0x00000001837BD250-0x00000001837BD290
		[NativeName("AddLink")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation) => default; // 0x0000000189D7F208-0x0000000189D7F21C
		[NativeName("RemoveLink")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void RemoveLinkInternal(int handle) {} // 0x00000001834E3FF0-0x00000001834E4000
		public static NavMeshBuildSettings GetSettingsByID(int agentTypeID) => default; // 0x000000018307F250-0x000000018307F260
		public static NavMeshBuildSettings GetSettingsByIndex(int index) => default; // 0x00000001834E4000-0x00000001834E4070
		[NativeName("UpdateSurfaceTransform")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void UpdateSurfaceTransformInternal(int surfaceID, Vector3 position, Quaternion rotation) {} // 0x000000018307F420-0x000000018307F490
		public static bool DetachFromSurface(int chunkSurfaceId, int builderSurfaceId, int indexX, int indexZ) => default; // 0x0000000189D7F0A8-0x0000000189D7F0B4
		public static bool SetBuilderSurfaceParams(int surfID, float chunkSize, float tileSize, float centerX, float centerZ, float sizeX, float sizeZ) => default; // 0x0000000189D7F1A8-0x0000000189D7F1B0
		[NativeName("DetachFromSurface")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool Internal_DetachFromSurface(int chunkSurfaceId, int builderSurfaceId, int indexX, int indexZ) => default; // 0x0000000189D7EFD8-0x0000000189D7F00C
		[NativeName("SetBuilderSurfaceParams")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool Internal_SetBuilderSurfaceParams(int surfID, float chunkSize, float tileSize, float centerX, float centerZ, float sizeX, float sizeZ) => default; // 0x0000000189D7F00C-0x0000000189D7F040
		public static int LoadDynamicBakeTile(NavMeshData navMeshData) => default; // 0x0000000189D7F120-0x0000000189D7F130
		public static void UnloadDynamicBakeTile(int dynamicTileID) {} // 0x0000000189D7F0BC-0x0000000189D7F120
		[NativeName("LoadDynamicBakeTile")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static int Internal_LoadDynamicBakeTile(NavMeshData navMeshData) => default; // 0x0000000183B46B00-0x0000000183B46B10
		[NativeName("UnloadDynamicBakeTile")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_UnloadDynamicBakeTile(int dynamicTileID) {} // 0x0000000183B46B10-0x0000000183B46B80
		public static int ModifyVolumeArea(List<Vector3> center, List<Vector3> ext, List<Quaternion> rotation, int area) => default; // 0x0000000189D7F0B4-0x0000000189D7F0BC
		private static int ModifyBoxAreaInternal(List<Vector3> center, List<Vector3> ext, List<Quaternion> rotation, int area) => default; // 0x0000000183D4BEE0-0x0000000183D4BF20
		public static int ModifyVolumeArea(List<Vector3> verts, float hMin, float hMax, int area) => default; // 0x0000000182553320-0x00000001825533B0
		private static int ModifyPolygonAreaInternal(List<Vector3> verts, float hMin, float hMax, int area) => default; // 0x00000001825533B0-0x0000000182553410
		public static void LoadExtOffMeshLinks(int surfaceID) {} // 0x0000000189D7EE80-0x0000000189D7EE88
		[NativeName("LoadExtOffMeshLinks")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_LoadExtOffMeshLinks(int surfaceID) {} // 0x0000000189D7EF78-0x0000000189D7EFAC
		public static AsyncOperation AddNavMeshDataAsync(ref int surfaceID, NavMeshData navMeshData, ulong surfTileID) => default; // 0x0000000184276458-0x0000000184276460
		private static AsyncOperation AddNavMeshDataAsyncInternal(ref int surfaceID, NavMeshData navMeshData, ulong surfTileID) => default; // 0x000000018399FA60-0x000000018399FAB0
		public static void CancelAsyncAdd(ulong surfTileID) {} // 0x00000001834E4070-0x00000001834E40D0
		[NativeName("PurgeAsyncOperations")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_CancelAsyncAdd(ulong surfaceID) {} // 0x0000000184270534-0x0000000184270540
		public static void UnloadDataAsync(int surfaceID, ulong surfTileID) {} // 0x0000000183828330-0x0000000183828370
		[NativeName("UnloadDataAsync")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_UnloadDataAsync(int surfaceID, ulong surfTileID) {} // 0x0000000189D7EEF0-0x0000000189D7EEF8
		[RequiredByNativeCode]
		private static void Internal_InvokeOnUnloadFinish(ulong surfTileID) {} // 0x0000000189D7EFAC-0x0000000189D7EFD8
		public static bool IsSurfaceUnloading(ulong surfTileID) => default; // 0x000000018278F190-0x000000018278F270
		[NativeName("IsSurfaceUnloading")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool Internal_IsSurfaceUnloading(ulong surfTileID) => default; // 0x000000018427183C-0x0000000184271874
		public static void ForceClearUnloadDataRequest() {} // 0x0000000184274DB4-0x0000000184274DBC
		[NativeName("ForceClearUnloadDataRequest")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_ForceClearUnloadDataRequest() {} // 0x0000000183D3D720-0x0000000183D3D760
		public static void CalculatePathAsync(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd = true /* Metadata: 0x01FDCFC0 */, int agentTypeID = -1 /* Metadata: 0x01FDCFC1 */, float radius = -1f /* Metadata: 0x01FDCFC2 */) {} // 0x0000000184276598-0x00000001842765A0
		private static void CalculatePathAsyncInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius) {} // 0x0000000183B31E70-0x0000000183B31EB0
		public static void SetFindPathMaxIterPerFrame(int maxIterPerFrame) {} // 0x0000000184276590-0x0000000184276598
		[NativeName("SetFindPathMaxIterPerFrame")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_SetFindPathMaxIterPerFrame(int maxIterPerFrame) {} // 0x0000000183CDDD00-0x0000000183CDDD40
		public static void CancelAsyncCalculatePath(NavMeshPath path) {} // 0x0000000189D7F1B0-0x0000000189D7F1B8
		[NativeName("PurgeAsyncFindPath")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_CancelAsyncCalculatePath(NavMeshPath path) {} // 0x0000000189D7F040-0x0000000189D7F074
		public static void RegisterAutoRepath(NavMeshPath path) {} // 0x0000000184271874-0x000000018427188C
		[NativeName("RegisterAutoRepath")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_RegisterAutoRepath(NavMeshPath path) {} // 0x000000018311BA10-0x000000018311BA80
		public static void UnregisterAutoRepath(NavMeshPath path) {} // 0x0000000182549BB0-0x0000000182549C30
		[NativeName("UnregisterAutoRepath")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_UnregisterAutoRepath(NavMeshPath path) {} // 0x0000000189D7EE88-0x0000000189D7EEDC
		public static bool RaycastNearestPoint(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, int areaMask) {
			hit = default;
			return default;
		} // 0x0000000182E53550-0x0000000182E535C0
		private static bool Raycast_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, out NavMeshHit hit, int areaMask) {
			hit = default;
			return default;
		} // 0x0000000182CBADE0-0x0000000182CBAE40
		private static bool CalculatePathInternal_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius) => default; // 0x000000018300B980-0x000000018300B9E0
		private static bool FindClosestEdge_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, int areaMask) {
			hit = default;
			return default;
		} // 0x000000018307F200-0x000000018307F250
		private static bool SamplePosition_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask) {
			hit = default;
			return default;
		} // 0x00000001837BD290-0x00000001837BD2E0
		private static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation) => default; // 0x0000000189D7F1B8-0x0000000189D7F208
		private static int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation) => default; // 0x000000018389F660-0x000000018389F6E0
		private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret) {
			ret = default;
		} // 0x0000000183645130-0x00000001836451A0
		private static void GetSettingsByIndex_Injected(int index, out NavMeshBuildSettings ret) {
			ret = default;
		} // 0x00000001842BE04C-0x00000001842BE110
		private static void UpdateSurfaceTransformInternal_Injected(int surfaceID, ref Vector3 position, ref Quaternion rotation) {} // 0x00000001842BE03C-0x00000001842BE04C
		private static void CalculatePathAsyncInternal_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius) {} // 0x00000001834E42D0-0x00000001834E4340
		private static bool RaycastNearestPoint_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, out NavMeshHit hit, int areaMask) {
			hit = default;
			return default;
		} // 0x0000000182149960-0x0000000182149970
	}

	public enum NavMeshBuildSourceShape // TypeDefIndex: 59319
	{
		Mesh = 0,
		Terrain = 1,
		Box = 2,
		Sphere = 3,
		Capsule = 4,
		ModifierBox = 5,
		PhysicsTriangleMesh = 6,
		PhysicsConvexMesh = 7,
		PhysicsTerrain = 8,
		ModifierPoly = 20
	}

	public enum NavMeshCollectGeometry // TypeDefIndex: 59320
	{
		RenderMeshes = 0,
		PhysicsColliders = 1
	}

	[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
	[UsedByNativeCode]
	public struct NavMeshBuildSource // TypeDefIndex: 59321
	{
		// Fields
		[NativeName("transform")]
		private Matrix4x4 m_Transform; // 0x00
		[NativeName("size")]
		private Vector3 m_Size; // 0x40
		[NativeName("shape")]
		private NavMeshBuildSourceShape m_Shape; // 0x4C
		[NativeName("areaType")]
		private int m_Area; // 0x50
		[NativeName("instanceID")]
		private int m_InstanceID; // 0x54
		[NativeName("componentID")]
		private int m_ComponentID; // 0x58
		[NativeName("isConvex")]
		internal bool m_IsConvex; // 0x5C
		[NativeName("ecsShape")]
		internal IntPtr m_EcsShape; // 0x60
		[NativeName("convexVerts")]
		public List<Vector3> convexVerts; // 0x68
		[NativeName("convexHmin")]
		public float convexHmin; // 0x70
		[NativeName("convexHmax")]
		public float convexHmax; // 0x74
	
		// Properties
		public Matrix4x4 transform { get => default; set {} } // 0x0000000183D858B0-0x0000000183D858E0 0x0000000183D858E0-0x0000000183D85900
		public Vector3 size { get => default; set {} } // 0x0000000183D85890-0x0000000183D858B0 0x0000000183D52330-0x0000000183D52340
		public NavMeshBuildSourceShape shape { get => default; set {} } // 0x0000000183D85880-0x0000000183D85890 0x0000000183D4EE30-0x0000000183D4EE40
		public int area { get => default; set {} } // 0x0000000183D85870-0x0000000183D85880 0x0000000183D4EF20-0x0000000183D4EF30
		public UnityEngine.Object sourceObject { get => default; } // 0x0000000189D7E1B0-0x0000000189D7E1BC 
		public Component component { get => default; } // 0x0000000189D7E1A4-0x0000000189D7E1B0 
	
		// Methods
		[StaticAccessor("NavMeshBuildSource", StaticAccessorType.DoubleColon)]
		private static Component InternalGetComponent(int instanceID) => default; // 0x0000000189D7E13C-0x0000000189D7E170
		[StaticAccessor("NavMeshBuildSource", StaticAccessorType.DoubleColon)]
		private static UnityEngine.Object InternalGetObject(int instanceID) => default; // 0x0000000189D7E170-0x0000000189D7E1A4
	}

	[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
	public struct NavMeshBuildMarkup // TypeDefIndex: 59322
	{
		// Fields
		private int m_OverrideArea; // 0x00
		private int m_Area; // 0x04
		private int m_IgnoreFromBuild; // 0x08
		private int m_InstanceID; // 0x0C
	
		// Properties
		public bool overrideArea { set {} } // 0x0000000189D7E0B8-0x0000000189D7E0C0
		public int area { set {} } // 0x0000000183D51720-0x0000000183D51730
		public bool ignoreFromBuild { set {} } // 0x000000018237ACC0-0x000000018237ACD0
		public Transform root { set {} } // 0x0000000189D7E0C0-0x0000000189D7E13C
	}

	[NativeHeader("Modules/AI/Public/NavMeshBuildSettings.h")]
	public struct NavMeshBuildSettings // TypeDefIndex: 59323
	{
		// Fields
		private int m_AgentTypeID; // 0x00
		private float m_AgentRadius; // 0x04
		private float m_AgentHeight; // 0x08
		private float m_AgentSlope; // 0x0C
		private float m_AgentClimb; // 0x10
		private float m_LedgeDropHeight; // 0x14
		private float m_MaxJumpAcrossDistance; // 0x18
		private float m_MinRegionArea; // 0x1C
		private int m_OverrideVoxelSize; // 0x20
		private float m_VoxelSize; // 0x24
		private int m_OverrideTileSize; // 0x28
		private int m_TileSize; // 0x2C
		private int m_AccuratePlacement; // 0x30
		private uint m_MaxJobWorkers; // 0x34
		private int m_PreserveTilesOutsideBounds; // 0x38
		private int m_PartitioningMethod; // 0x3C
		private int m_FilterLowHangingObstacles; // 0x40
		private int m_FilterLedgeSpans; // 0x44
		private int m_FilterWalkableLowHeightSpans; // 0x48
		private int m_erodeAgainstWallSpans; // 0x4C
		private int m_cliffIndent; // 0x50
		private int m_DynamicNavmeshSurfaceType; // 0x54
		private NavMeshBuildDebugSettings m_Debug; // 0x58
	
		// Properties
		public int agentTypeID { get => default; set {} } // 0x0000000183D85860-0x0000000183D85870 0x0000000183D4E970-0x0000000183D4E980
		public float agentRadius { get => default; } // 0x0000000183D85850-0x0000000183D85860 
		public float agentHeight { get => default; } // 0x0000000183D85840-0x0000000183D85850 
		public float agentClimb { get => default; } // 0x0000000183D85830-0x0000000183D85840 
		public float minRegionArea { set {} } // 0x0000000183D4F120-0x0000000183D4F130
		public bool overrideVoxelSize { set {} } // 0x000000018307F300-0x000000018307F320
		public float voxelSize { set {} } // 0x0000000183D52500-0x0000000183D52510
		public bool overrideTileSize { set {} } // 0x000000018307F2E0-0x000000018307F300
		public int tileSize { set {} } // 0x0000000183D4EDE0-0x0000000183D4EDF0
		public int partitioningMethod { set {} } // 0x0000000183D4EDC0-0x0000000183D4EDD0
		public bool filterLowHangingObstacles { set {} } // 0x000000018307F260-0x000000018307F280
		public bool filterLedgeSpans { set {} } // 0x000000018307F280-0x000000018307F2A0
		public bool filterWalkableLowHeightSpans { set {} } // 0x000000018307F2A0-0x000000018307F2C0
		public bool erodeAgainstWallSpans { set {} } // 0x000000018307F2C0-0x000000018307F2E0
		public int cliffIndent { set {} } // 0x0000000183D4EF20-0x0000000183D4EF30
	}

	[NativeHeader("Modules/AI/Public/NavMeshBuildDebugSettings.h")]
	public struct NavMeshBuildDebugSettings // TypeDefIndex: 59324
	{
		// Fields
		private byte m_Flags; // 0x00
	}
}

namespace UnityEngine.Experimental.AI
{
	public struct PolygonId : IEquatable<PolygonId> // TypeDefIndex: 59325
	{
		// Fields
		internal ulong polyRef; // 0x00
	
		// Methods
		public bool IsNull() => default; // 0x0000000182361C20-0x0000000182361C30
		public static bool operator ==(PolygonId x, PolygonId y) => default; // 0x000000018232CE30-0x000000018232CE40
		public static bool operator !=(PolygonId x, PolygonId y) => default; // 0x0000000183CFE7D0-0x0000000183CFE7E0
		public override int GetHashCode() => default; // 0x0000000183D859F0-0x0000000183D85A00
		public bool Equals(PolygonId rhs) => default; // 0x0000000189D7F378-0x0000000189D7F380
		public override bool Equals(object obj) => default; // 0x0000000189D7F30C-0x0000000189D7F378
	}

	public struct NavMeshLocation // TypeDefIndex: 59326
	{
		// Properties
		public PolygonId polygon { [IsReadOnly] get; } // 0x00000001820C61B0-0x00000001820C61C0 
		public Vector3 position { [IsReadOnly] get; } // 0x0000000183D5E630-0x0000000183D5E650 
	}

	[Flags]
	public enum PathQueryStatus // TypeDefIndex: 59327
	{
		WrongMagic = 1,
		WrongVersion = 2,
		OutOfMemory = 4,
		InvalidParam = 8,
		BufferTooSmall = 16,
		OutOfNodes = 32,
		PartialResult = 64,
		StatusDetailMask = 16777215,
		InProgress = 536870912,
		Success = 1073741824,
		Failure = 2147483647
	}

	[StaticAccessor("NavMeshWorldBindings", StaticAccessorType.DoubleColon)]
	public struct NavMeshWorld // TypeDefIndex: 59328
	{
		// Fields
		internal IntPtr world; // 0x00
	
		// Methods
		public static NavMeshWorld GetDefaultWorld() => default; // 0x0000000182A7A840-0x0000000182A7A890
		private static void GetDefaultWorld_Injected(out NavMeshWorld ret) {
			ret = default;
		} // 0x0000000182A7A890-0x0000000182A7A8D0
	}

	[NativeContainer]
	[NativeHeader("Runtime/Math/Matrix4x4.h")]
	[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
	[NativeHeader("Modules/AI/NavMeshExperimental.bindings.h")]
	[StaticAccessor("NavMeshQueryBindings", StaticAccessorType.DoubleColon)]
	public struct NavMeshQuery : IDisposable // TypeDefIndex: 59329
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr m_NavMeshQuery; // 0x00
	
		// Constructors
		public NavMeshQuery(NavMeshWorld world, Unity.Collections.Allocator allocator, int pathNodePoolSize = 0 /* Metadata: 0x01FDCFE9 */) {
			m_NavMeshQuery = default;
		} // 0x000000018307F380-0x000000018307F3C0
	
		// Methods
		public void Dispose() {} // 0x0000000183334BD0-0x0000000183334C00
		private static IntPtr Create(NavMeshWorld world, int nodePoolSize) => default; // 0x0000000184274DBC-0x0000000184274DD8
		private static void Destroy(IntPtr navMeshQuery) {} // 0x0000000183334C50-0x0000000183334C90
		[ThreadSafe]
		private static NavMeshLocation MapLocation(IntPtr navMeshQuery, Vector3 position, Vector3 extents, int agentTypeID, int areaMask = -1 /* Metadata: 0x01FDCFEA */) => default; // 0x0000000182792F30-0x0000000182792FC0
		public NavMeshLocation MapLocation(Vector3 position, Vector3 extents, int agentTypeID, int areaMask = -1 /* Metadata: 0x01FDCFEB */) => default; // 0x0000000182792E60-0x0000000182792F30
		[ThreadSafe]
		private static NavMeshLocation MoveLocation(IntPtr navMeshQuery, NavMeshLocation location, Vector3 target, int areaMask) => default; // 0x0000000182790920-0x0000000182790970
		public NavMeshLocation MoveLocation(NavMeshLocation location, Vector3 target, int areaMask = -1 /* Metadata: 0x01FDCFEC */) => default; // 0x0000000182790850-0x0000000182790920
		[ThreadSafe]
		private static unsafe PathQueryStatus Raycast(IntPtr navMeshQuery, NavMeshLocation start, Vector3 targetPosition, int areaMask, void* costs, out NavMeshHit hit, void* path, out int pathCount, int maxPath) {
			hit = default;
			pathCount = default;
			return default;
		} // 0x0000000189D7ED48-0x0000000189D7EDA0
		public PathQueryStatus Raycast(out NavMeshHit hit, NavMeshLocation start, Vector3 targetPosition, int areaMask = -1 /* Metadata: 0x01FDCFED */, NativeArray<float> costs = default) {
			hit = default;
			return default;
		} // 0x0000000189D7EDA0-0x0000000189D7EE80
		private static IntPtr Create_Injected(ref NavMeshWorld world, int nodePoolSize) => default; // 0x0000000183477910-0x0000000183477960
		private static void MapLocation_Injected(IntPtr navMeshQuery, ref Vector3 position, ref Vector3 extents, int agentTypeID, int areaMask = -1 /* Metadata: 0x01FDCFEE */, out NavMeshLocation ret) {
			ret = default;
		} // 0x0000000182792FC0-0x0000000182793030
		private static void MoveLocation_Injected(IntPtr navMeshQuery, ref NavMeshLocation location, ref Vector3 target, int areaMask, out NavMeshLocation ret) {
			ret = default;
		} // 0x0000000182790670-0x00000001827906E0
		private static unsafe PathQueryStatus Raycast_Injected(IntPtr navMeshQuery, ref NavMeshLocation start, ref Vector3 targetPosition, int areaMask, void* costs, out NavMeshHit hit, void* path, out int pathCount, int maxPath) {
			hit = default;
			pathCount = default;
			return default;
		} // 0x0000000189D7ECE4-0x0000000189D7ED48
	}
}
