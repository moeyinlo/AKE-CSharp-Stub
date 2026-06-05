/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.AI;

// Image 90: UnityEngine.AIModule.dll - Assembly: UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60357-60385

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 60358
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 60359
	{
		// Constructors
		public IsReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine.AI
{
	public enum NavMeshPathStatus // TypeDefIndex: 60360
	{
		PathComplete = 0,
		PathPartial = 1,
		PathInvalid = 2,
		PathProcessing = 3
	}

	public sealed class NavMeshPath // TypeDefIndex: 60361
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
		internal Vector3[] m_Corners; // 0x18
		internal int[] m_Areas; // 0x20
		internal Vector3[] m_DividingPos; // 0x28
	
		// Properties
		public Vector3[] corners { get => default; } // 0x00000001864746B4-0x00000001864746D0 
		public NavMeshPathStatus status { get => default; } // 0x0000000184AB00C0-0x0000000184AB0100 
		public bool needRepath { get => default; set {} } // 0x0000000184326950-0x0000000184326990 0x00000001850DB2B0-0x00000001850DB300
		public bool calcAutoRepath { set {} } // 0x00000001850DB260-0x00000001850DB2B0
	
		// Constructors
		public NavMeshPath() {} // 0x00000001846E89C0-0x00000001846E89E0
	
		// Methods
		~NavMeshPath() {} // 0x0000000185D532A0-0x0000000185D53330
		private static IntPtr InitializeNavMeshPath() => default; // 0x00000001846E89E0-0x00000001846E8A20
		private static void DestroyNavMeshPath(IntPtr ptr) {} // 0x0000000185D53330-0x0000000185D53370
		public int GetCornersNonAlloc(out Vector3[] corners, out int[] areas = null, out Vector3[] dividingPos = null) {
			corners = default;
			areas = default;
			dividingPos = default;
			return default;
		} // 0x0000000185BB1370-0x0000000185BB13E0
		public int GetPolyCount() => default; // 0x0000000185D74D60-0x0000000185D74DA0
		private Vector3[] CalculateCornersInternal() => default; // 0x0000000185EEAB20-0x0000000185EEAB60
		private void ClearCornersInternal() {} // 0x0000000184AAF6F0-0x0000000184AAF730
		public void ClearCorners() {} // 0x0000000184AAF6C0-0x0000000184AAF6F0
		private void CalculateCorners() {} // 0x0000000185EEAAF0-0x0000000185EEAB20
	}

	public static class NavMeshBuilder // TypeDefIndex: 60362
	{
		// Methods
		public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) {} // 0x000000018BE963A0-0x000000018BE965AC
		public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) {} // 0x000000018BE961F0-0x000000018BE963A0
		private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) => default; // 0x000000018BE961BC-0x000000018BE961F0
		public static void CollectSourcesV2(Bounds includedWorldBounds, int includedLayerMask, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) {} // 0x0000000185845FD0-0x0000000185846130
		private static NavMeshBuildSource[] CollectSourcesV2Internal(int includedLayerMask, Bounds includedWorldBounds, int defaultArea, NavMeshBuildMarkup[] markups) => default; // 0x000000018647469C-0x00000001864746B4
		public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation, bool useSubJob = false /* Metadata: 0x020828A3 */) => default; // 0x000000018BE95FCC-0x000000018BE9615C
		public static bool UpdateNavMeshData(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, bool useSubJob = false /* Metadata: 0x020828A4 */) => default; // 0x000000018BE96630-0x000000018BE967D8
		private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds, bool useSubJob) => default; // 0x000000018BE96610-0x000000018BE96630
		public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, bool useSubJob = false /* Metadata: 0x020828A5 */) => default; // 0x0000000185EF9000-0x0000000185EF9140
		private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds, bool useSubJob) => default; // 0x00000001864752FC-0x000000018647531C
		private static NavMeshBuildSource[] CollectSourcesInternal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) => default; // 0x000000018BE9615C-0x000000018BE961BC
		private static NavMeshBuildSource[] CollectSourcesV2Internal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, int defaultArea, NavMeshBuildMarkup[] markups) => default; // 0x0000000185FA65A0-0x0000000185FA6610
		private static bool UpdateNavMeshDataListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds, bool useSubJob) => default; // 0x000000018BE965AC-0x000000018BE96610
		private static AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds, bool useSubJob) => default; // 0x0000000185EF9140-0x0000000185EF91C0
	}

	public sealed class HGNavMeshAgent : UnityEngine.Behaviour // TypeDefIndex: 60363
	{
		// Constructors
		public HGNavMeshAgent() {} // Dummy constructor
	}

	public sealed class NavMeshAgent : UnityEngine.Behaviour // TypeDefIndex: 60364
	{
		// Constructors
		public NavMeshAgent() {} // Dummy constructor
	}

	public enum NavMeshObstacleShape // TypeDefIndex: 60365
	{
		Capsule = 0,
		Box = 1,
		Polygon = 2
	}

	public sealed class NavMeshObstacle : UnityEngine.Behaviour // TypeDefIndex: 60366
	{
		// Properties
		public float height { get => default; set {} } // 0x000000018BE969DC-0x000000018BE96A10 0x000000018BE96A44-0x000000018BE96A88
		public float radius { get => default; set {} } // 0x000000018BE96A10-0x000000018BE96A44 0x000000018BE96A88-0x000000018BE96ACC
		public bool carving { set {} } // 0x0000000184CDE8D0-0x0000000184CDE920
		public bool carveOnlyStationary { set {} } // 0x0000000184CDE7E0-0x0000000184CDE830
		public NavMeshObstacleShape shape { set {} } // 0x0000000184CDE790-0x0000000184CDE7E0
		public Vector3 center { get => default; set {} } // 0x000000018BE969B0-0x000000018BE969DC 0x0000000186472544-0x0000000186472558
		public Vector3 size { get => default; set {} } // 0x0000000185F8CE10-0x0000000185F8CE40 0x0000000186472558-0x000000018647256C
		public int ignoredSurfaceID { set {} } // 0x0000000184CDE830-0x0000000184CDE880
		public int carveArea { set {} } // 0x0000000184CDE880-0x0000000184CDE8D0
	
		// Constructors
		public NavMeshObstacle() {} // Dummy constructor
	
		// Methods
		private void get_center_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BE9696C-0x000000018BE969B0
		private void set_center_Injected(ref Vector3 value) {} // 0x0000000185993C20-0x0000000185993C70
		private void get_size_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000185F8CE40-0x0000000185F8CE90
		private void set_size_Injected(ref Vector3 value) {} // 0x0000000185F4C6C0-0x0000000185F4C710
	}

	public struct NavMeshHit // TypeDefIndex: 60367
	{
		// Fields
		private Vector3 m_Position; // 0x00
		private Vector3 m_Normal; // 0x0C
		private float m_Distance; // 0x18
		private int m_Mask; // 0x1C
		private int m_Hit; // 0x20
	
		// Properties
		public Vector3 position { get => default; } // 0x0000000185FE65B0-0x0000000185FE65D0 
		public Vector3 normal { get => default; } // 0x0000000185FE6590-0x0000000185FE65B0 
		public bool hit { get => default; } // 0x000000018BE96894-0x000000018BE9689C 
	}

	public sealed class NavMeshData : UnityEngine.Object // TypeDefIndex: 60368
	{
		// Properties
		public Bounds sourceBounds { get => default; } // 0x00000001849E8CF0-0x00000001849E8D20 
		public Vector3 position { get => default; set {} } // 0x0000000185F8CE90-0x0000000185F8CEC0 0x0000000186471150-0x0000000186471164
		public Quaternion rotation { get => default; set {} } // 0x0000000185F96150-0x0000000185F96180 0x000000018647113C-0x0000000186471150
	
		// Constructors
		public NavMeshData() {} // Dummy constructor
		public NavMeshData(int agentTypeID) {} // 0x00000001849EDDA0-0x00000001849EDE00
	
		// Methods
		private static void Internal_Create(NavMeshData mono, int agentTypeID) {} // 0x00000001849EDE00-0x00000001849EDE50
		public void AppendExtOffMeshLink(Vector3 start, Vector3 end, float width, bool bidirectional, int area, float costModifier) {} // 0x0000000185621CB0-0x0000000185621F90
		internal void Internal_AppendExtOffMeshLink(Vector3 startLeft, Vector3 startRight, Vector3 endRight, Vector3 endLeft, bool bidirectional, int area, float costModifier) {} // 0x0000000186474194-0x00000001864741E0
		private void get_sourceBounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x00000001849E8D20-0x00000001849E8D70
		private void get_position_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000185F8CEC0-0x0000000185F8CF10
		private void set_position_Injected(ref Vector3 value) {} // 0x0000000185FAAA30-0x0000000185FAAA80
		private void get_rotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x0000000185F96180-0x0000000185F961D0
		private void set_rotation_Injected(ref Quaternion value) {} // 0x0000000185FAA9E0-0x0000000185FAAA30
		private void Internal_AppendExtOffMeshLink_Injected(ref Vector3 startLeft, ref Vector3 startRight, ref Vector3 endRight, ref Vector3 endLeft, bool bidirectional, int area, float costModifier) {} // 0x0000000185621F90-0x0000000185622010
	}

	public struct NavMeshDataInstance // TypeDefIndex: 60369
	{
		// Fields
		private int _id_k__BackingField; // 0x00
	
		// Properties
		public bool valid { get => default; } // 0x0000000184E9AEE0-0x0000000184E9AF00 
		internal int id { get; set; } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int handleId { get => default; set {} } // 0x0000000185FE64F0-0x0000000185FE6500 0x00000001818AA390-0x00000001818AA3A0
		public UnityEngine.Object owner { set {} } // 0x000000018BE967E4-0x000000018BE96894
	
		// Methods
		public void Remove() {} // 0x000000018BE967D8-0x000000018BE967E4
	}

	public struct NavMeshLinkData // TypeDefIndex: 60370
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
		public bool isExt { get => default; set {} } // 0x0000000185FE6630-0x0000000185FE6640 0x0000000185FB0F60-0x0000000185FB0F70
		public Vector3 startLeft { get => default; set {} } // 0x0000000185FE6640-0x0000000185FE6660 0x0000000185FD7F00-0x0000000185FD7F10
		public Vector3 startRight { get => default; set {} } // 0x0000000185FE6660-0x0000000185FE6680 0x0000000185FB6850-0x0000000185FB6860
		public Vector3 endRight { get => default; set {} } // 0x0000000185FE6610-0x0000000185FE6630 0x0000000185FBE140-0x0000000185FBE150
		public Vector3 endLeft { get => default; set {} } // 0x0000000185FE65F0-0x0000000185FE6610 0x0000000185FB2400-0x0000000185FB2410
		public float costModifier { get => default; set {} } // 0x0000000186472350-0x0000000186472358 0x0000000185FB8A50-0x0000000185FB8A60
		public bool bidirectional { get => default; set {} } // 0x00000001880C0108-0x00000001880C0110 0x0000000185880CA0-0x0000000185880CC0
		public int area { get => default; set {} } // 0x0000000185FE65E0-0x0000000185FE65F0 0x0000000185FB07A0-0x0000000185FB07B0
		public int agentTypeID { get => default; set {} } // 0x0000000185FE65D0-0x0000000185FE65E0 0x00000001813EE9C0-0x00000001813EE9D0
	}

	public struct NavMeshLinkInstance // TypeDefIndex: 60371
	{
		// Fields
		private int _id_k__BackingField; // 0x00
	
		// Properties
		public bool valid { get => default; } // 0x000000018BE968A8-0x000000018BE968BC 
		internal int id { get; set; } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public UnityEngine.Object owner { set {} } // 0x000000018BE968BC-0x000000018BE9696C
	
		// Methods
		public void Remove() {} // 0x000000018BE9689C-0x000000018BE968A8
	}

	public static class NavMesh // TypeDefIndex: 60374
	{
		// Fields
		public static OnNavMeshPreUpdate onPreUpdate; // 0x00
		public static OnUnloadFinishDelegate onUnloadFinish; // 0x08
	
		// Nested types
		public delegate void OnNavMeshPreUpdate(); // TypeDefIndex: 60372; 0x000000018646FDE8-0x000000018646FE00
	
		public delegate void OnUnloadFinishDelegate(ulong surfTileID); // TypeDefIndex: 60373; 0x00000001864719BC-0x00000001864719F4
	
		// Methods
		private static void Internal_CallOnNavMeshPreUpdate() {} // 0x000000018BE96CC4-0x000000018BE96CD8
		public static bool Raycast(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, int areaMask) {
			hit = default;
			return default;
		} // 0x000000018646FE00-0x000000018646FE18
		public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd = true /* Metadata: 0x020828A9 */, int agentTypeID = -1 /* Metadata: 0x020828AA */, float radius = -1f /* Metadata: 0x020828AB */) => default; // 0x00000001859B5D70-0x00000001859B5DB0
		private static bool CalculatePathInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius) => default; // 0x0000000184E998A0-0x0000000184E99900
		public static bool FindClosestEdge(Vector3 sourcePosition, out NavMeshHit hit, int areaMask) {
			hit = default;
			return default;
		} // 0x0000000184E9ABC0-0x0000000184E9AC80
		public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask) {
			hit = default;
			return default;
		} // 0x000000018BE97004-0x000000018BE970F4
		public static int GetAreaFromName(string areaName) => default; // 0x000000018BE96F88-0x000000018BE96F90
		public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData) => default; // 0x0000000184E9AF00-0x0000000184E9AF40
		public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation) => default; // 0x000000018BE96E5C-0x000000018BE96E90
		public static void UpdateSurfaceTransform(NavMeshDataInstance handle, Vector3 position, Quaternion rotation) {} // 0x000000018BE96D20-0x000000018BE96D60
		public static void RemoveNavMeshData(NavMeshDataInstance handle) {} // 0x000000018BE96CE0-0x000000018BE96D20
		internal static bool IsValidNavMeshDataHandle(int handle) => default; // 0x0000000184E99900-0x0000000184E99940
		internal static bool IsValidLinkHandle(int handle) => default; // 0x0000000186472940-0x0000000186472954
		internal static bool InternalSetOwner(int dataID, int ownerID) => default; // 0x000000018BE96F54-0x000000018BE96F88
		internal static bool InternalSetLinkOwner(int linkID, int ownerID) => default; // 0x0000000185880C10-0x0000000185880CA0
		internal static int AddNavMeshDataInternal(NavMeshData navMeshData) => default; // 0x000000018BE96F4C-0x000000018BE96F54
		internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation) => default; // 0x00000001864746D0-0x00000001864746E4
		internal static void RemoveNavMeshDataInternal(int handle) {} // 0x000000018BE96F18-0x000000018BE96F4C
		public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation) => default; // 0x0000000184E99560-0x0000000184E995A0
		public static void RemoveLink(NavMeshLinkInstance handle) {} // 0x00000001858F29E0-0x00000001858F2A20
		internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation) => default; // 0x000000018BE96FF0-0x000000018BE97004
		internal static void RemoveLinkInternal(int handle) {} // 0x0000000184BD1D80-0x0000000184BD1D90
		public static NavMeshBuildSettings GetSettingsByID(int agentTypeID) => default; // 0x0000000184E992B0-0x0000000184E992C0
		public static NavMeshBuildSettings GetSettingsByIndex(int index) => default; // 0x0000000184BD1D10-0x0000000184BD1D80
		internal static void UpdateSurfaceTransformInternal(int surfaceID, Vector3 position, Quaternion rotation) {} // 0x0000000184E99080-0x0000000184E990F0
		public static bool DetachFromSurface(int chunkSurfaceId, int builderSurfaceId, int indexX, int indexZ) => default; // 0x000000018BE96E90-0x000000018BE96E9C
		public static bool SetBuilderSurfaceParams(int surfID, float chunkSize, float tileSize, float centerX, float centerZ, float sizeX, float sizeZ) => default; // 0x000000018BE96F90-0x000000018BE96F98
		internal static bool Internal_DetachFromSurface(int chunkSurfaceId, int builderSurfaceId, int indexX, int indexZ) => default; // 0x000000018BE96DC0-0x000000018BE96DF4
		internal static bool Internal_SetBuilderSurfaceParams(int surfID, float chunkSize, float tileSize, float centerX, float centerZ, float sizeX, float sizeZ) => default; // 0x000000018BE96DF4-0x000000018BE96E28
		public static int LoadDynamicBakeTile(NavMeshData navMeshData) => default; // 0x000000018BE96F08-0x000000018BE96F18
		public static void UnloadDynamicBakeTile(int dynamicTileID) {} // 0x000000018BE96EA4-0x000000018BE96F08
		internal static int Internal_LoadDynamicBakeTile(NavMeshData navMeshData) => default; // 0x0000000185D7A4A0-0x0000000185D7A4B0
		internal static void Internal_UnloadDynamicBakeTile(int dynamicTileID) {} // 0x0000000185D7A4B0-0x0000000185D7A520
		public static int ModifyVolumeArea(List<Vector3> center, List<Vector3> ext, List<Quaternion> rotation, int area) => default; // 0x000000018BE96E9C-0x000000018BE96EA4
		private static int ModifyBoxAreaInternal(List<Vector3> center, List<Vector3> ext, List<Quaternion> rotation, int area) => default; // 0x0000000185FAD710-0x0000000185FAD750
		public static int ModifyVolumeArea(List<Vector3> verts, float hMin, float hMax, int area) => default; // 0x0000000184E9AF40-0x0000000184E9AFD0
		private static int ModifyPolygonAreaInternal(List<Vector3> verts, float hMin, float hMax, int area) => default; // 0x0000000184E9AFD0-0x0000000184E9B030
		public static void LoadExtOffMeshLinks(int surfaceID) {} // 0x000000018BE96C68-0x000000018BE96C70
		internal static void Internal_LoadExtOffMeshLinks(int surfaceID) {} // 0x000000018BE96D60-0x000000018BE96D94
		public static AsyncOperation AddNavMeshDataAsync(ref int surfaceID, NavMeshData navMeshData, ulong surfTileID) => default; // 0x0000000186472024-0x000000018647202C
		private static AsyncOperation AddNavMeshDataAsyncInternal(ref int surfaceID, NavMeshData navMeshData, ulong surfTileID) => default; // 0x0000000185B6E7E0-0x0000000185B6E830
		public static void CancelAsyncAdd(ulong surfTileID) {} // 0x0000000184E9AC80-0x0000000184E9ACE0
		internal static void Internal_CancelAsyncAdd(ulong surfaceID) {} // 0x0000000186472954-0x0000000186472960
		public static void UnloadDataAsync(int surfaceID, ulong surfTileID) {} // 0x000000018599B520-0x000000018599B560
		internal static void Internal_UnloadDataAsync(int surfaceID, ulong surfTileID) {} // 0x000000018BE96CD8-0x000000018BE96CE0
		private static void Internal_InvokeOnUnloadFinish(ulong surfTileID) {} // 0x000000018BE96D94-0x000000018BE96DC0
		public static bool IsSurfaceUnloading(ulong surfTileID) => default; // 0x0000000184AAF5E0-0x0000000184AAF6C0
		internal static bool Internal_IsSurfaceUnloading(ulong surfTileID) => default; // 0x0000000186471984-0x00000001864719BC
		public static void ForceClearUnloadDataRequest() {} // 0x0000000186472938-0x0000000186472940
		internal static void Internal_ForceClearUnloadDataRequest() {} // 0x0000000185F9D5B0-0x0000000185F9D5F0
		public static void CalculatePathAsync(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd = true /* Metadata: 0x020828AF */, int agentTypeID = -1 /* Metadata: 0x020828B0 */, float radius = -1f /* Metadata: 0x020828B1 */) {} // 0x00000001864733BC-0x00000001864733C4
		private static void CalculatePathAsyncInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius) {} // 0x0000000185D639B0-0x0000000185D63A40
		public static void SetFindPathMaxIterPerFrame(int maxIterPerFrame) {} // 0x00000001864733B4-0x00000001864733BC
		internal static void Internal_SetFindPathMaxIterPerFrame(int maxIterPerFrame) {} // 0x0000000185F375C0-0x0000000185F37600
		public static void CancelAsyncCalculatePath(NavMeshPath path) {} // 0x000000018BE96F98-0x000000018BE96FA0
		internal static void Internal_CancelAsyncCalculatePath(NavMeshPath path) {} // 0x000000018BE96E28-0x000000018BE96E5C
		public static void RegisterAutoRepath(NavMeshPath path) {} // 0x000000018647196C-0x0000000186471984
		internal static void Internal_RegisterAutoRepath(NavMeshPath path) {} // 0x0000000185050700-0x0000000185050770
		public static void UnregisterAutoRepath(NavMeshPath path) {} // 0x0000000184AAFFC0-0x0000000184AB0040
		internal static void Internal_UnregisterAutoRepath(NavMeshPath path) {} // 0x000000018BE96C70-0x000000018BE96CC4
		public static bool RaycastNearestPoint(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, int areaMask) {
			hit = default;
			return default;
		} // 0x0000000184C55A50-0x0000000184C55AC0
		private static bool Raycast_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, out NavMeshHit hit, int areaMask) {
			hit = default;
			return default;
		} // 0x0000000184E99940-0x0000000184E999A0
		private static bool CalculatePathInternal_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius) => default; // 0x0000000185880CC0-0x0000000185880D20
		private static bool FindClosestEdge_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, int areaMask) {
			hit = default;
			return default;
		} // 0x0000000184E995A0-0x0000000184E995F0
		private static bool SamplePosition_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask) {
			hit = default;
			return default;
		} // 0x00000001858F2A20-0x00000001858F2A70
		private static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation) => default; // 0x000000018BE96FA0-0x000000018BE96FF0
		private static int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation) => default; // 0x0000000184AB0040-0x0000000184AB00C0
		private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret) {
			ret = default;
		} // 0x0000000184AACA10-0x0000000184AACA80
		private static void GetSettingsByIndex_Injected(int index, out NavMeshBuildSettings ret) {
			ret = default;
		} // 0x00000001864BC330-0x00000001864BC3F4
		private static void UpdateSurfaceTransformInternal_Injected(int surfaceID, ref Vector3 position, ref Quaternion rotation) {} // 0x00000001864BC320-0x00000001864BC330
		private static void CalculatePathAsyncInternal_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius) {} // 0x0000000184BD1CA0-0x0000000184BD1D10
		private static bool RaycastNearestPoint_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, out NavMeshHit hit, int areaMask) {
			hit = default;
			return default;
		} // 0x00000001833EEC70-0x00000001833EEC80
	}

	public enum NavMeshBuildSourceShape // TypeDefIndex: 60375
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

	public enum NavMeshCollectGeometry // TypeDefIndex: 60376
	{
		RenderMeshes = 0,
		PhysicsColliders = 1
	}

	public struct NavMeshBuildSource // TypeDefIndex: 60377
	{
		// Fields
		private Matrix4x4 m_Transform; // 0x00
		private Vector3 m_Size; // 0x40
		private NavMeshBuildSourceShape m_Shape; // 0x4C
		private int m_Area; // 0x50
		private int m_InstanceID; // 0x54
		private int m_ComponentID; // 0x58
		internal bool m_IsConvex; // 0x5C
		internal IntPtr m_EcsShape; // 0x60
		public List<Vector3> convexVerts; // 0x68
		public float convexHmin; // 0x70
		public float convexHmax; // 0x74
	
		// Properties
		public Matrix4x4 transform { get => default; set {} } // 0x0000000185FE6540-0x0000000185FE6570 0x0000000185FE6570-0x0000000185FE6590
		public Vector3 size { get => default; set {} } // 0x0000000185FE6520-0x0000000185FE6540 0x0000000185FB3650-0x0000000185FB3660
		public NavMeshBuildSourceShape shape { get => default; set {} } // 0x0000000185FE6510-0x0000000185FE6520 0x0000000185FB06F0-0x0000000185FB0700
		public int area { get => default; set {} } // 0x0000000185FE6500-0x0000000185FE6510 0x0000000185FB06B0-0x0000000185FB06C0
		public UnityEngine.Object sourceObject { get => default; } // 0x000000018BE95FC0-0x000000018BE95FCC 
		public Component component { get => default; } // 0x000000018BE95FB4-0x000000018BE95FC0 
	
		// Methods
		private static Component InternalGetComponent(int instanceID) => default; // 0x000000018BE95F4C-0x000000018BE95F80
		private static UnityEngine.Object InternalGetObject(int instanceID) => default; // 0x000000018BE95F80-0x000000018BE95FB4
	}

	public struct NavMeshBuildMarkup // TypeDefIndex: 60378
	{
		// Fields
		private int m_OverrideArea; // 0x00
		private int m_Area; // 0x04
		private int m_IgnoreFromBuild; // 0x08
		private int m_InstanceID; // 0x0C
	
		// Properties
		public bool overrideArea { set {} } // 0x000000018BE95EC8-0x000000018BE95ED0
		public int area { set {} } // 0x0000000185FB2BA0-0x0000000185FB2BB0
		public bool ignoreFromBuild { set {} } // 0x0000000184032CC0-0x0000000184032CD0
		public Transform root { set {} } // 0x000000018BE95ED0-0x000000018BE95F4C
	}

	public struct NavMeshBuildSettings // TypeDefIndex: 60379
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
		public int agentTypeID { get => default; set {} } // 0x0000000185FE64F0-0x0000000185FE6500 0x00000001818AA390-0x00000001818AA3A0
		public float agentRadius { get => default; } // 0x0000000185FE64E0-0x0000000185FE64F0 
		public float agentHeight { get => default; } // 0x0000000185FE64D0-0x0000000185FE64E0 
		public float agentClimb { get => default; } // 0x0000000185FE64C0-0x0000000185FE64D0 
		public float minRegionArea { set {} } // 0x0000000183B7E5A0-0x0000000183B7E5B0
		public bool overrideVoxelSize { set {} } // 0x0000000184E991F0-0x0000000184E99210
		public float voxelSize { set {} } // 0x0000000185FB3820-0x0000000185FB3830
		public bool overrideTileSize { set {} } // 0x0000000184E99210-0x0000000184E99230
		public int tileSize { set {} } // 0x0000000185FB0640-0x0000000185FB0650
		public int partitioningMethod { set {} } // 0x0000000185FB07A0-0x0000000185FB07B0
		public bool filterLowHangingObstacles { set {} } // 0x0000000184E99290-0x0000000184E992B0
		public bool filterLedgeSpans { set {} } // 0x0000000184E99270-0x0000000184E99290
		public bool filterWalkableLowHeightSpans { set {} } // 0x0000000184E99250-0x0000000184E99270
		public bool erodeAgainstWallSpans { set {} } // 0x0000000184E99230-0x0000000184E99250
		public int cliffIndent { set {} } // 0x0000000185FB06B0-0x0000000185FB06C0
	}

	public struct NavMeshBuildDebugSettings // TypeDefIndex: 60380
	{
		// Fields
		private byte m_Flags; // 0x00
	}
}

namespace UnityEngine.Experimental.AI
{
	public struct PolygonId : IEquatable<PolygonId> // TypeDefIndex: 60381
	{
		// Fields
		internal ulong polyRef; // 0x00
	
		// Methods
		public bool IsNull() => default; // 0x000000018402E460-0x000000018402E470
		public static bool operator ==(PolygonId x, PolygonId y) => default; // 0x000000018406FBE0-0x000000018406FBF0
		public static bool operator !=(PolygonId x, PolygonId y) => default; // 0x0000000185F5A980-0x0000000185F5A990
		public override int GetHashCode() => default; // 0x0000000185FE6680-0x0000000185FE6690
		public bool Equals(PolygonId rhs) => default; // 0x000000018BE97160-0x000000018BE97168
		public override bool Equals(object obj) => default; // 0x000000018BE970F4-0x000000018BE97160
	}

	public struct NavMeshLocation // TypeDefIndex: 60382
	{
		// Fields
		private readonly PolygonId _polygon_k__BackingField; // 0x00
		private readonly Vector3 _position_k__BackingField; // 0x08
	
		// Properties
		public PolygonId polygon { get; } // 0x00000001834AFB60-0x00000001834AFB70 
		public Vector3 position { get; } // 0x0000000185FBFA70-0x0000000185FBFA90 
	}

	public enum PathQueryStatus // TypeDefIndex: 60383
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

	public struct NavMeshWorld // TypeDefIndex: 60384
	{
		// Fields
		internal IntPtr world; // 0x00
	
		// Methods
		public static NavMeshWorld GetDefaultWorld() => default; // 0x00000001846E2140-0x00000001846E2190
		private static void GetDefaultWorld_Injected(out NavMeshWorld ret) {
			ret = default;
		} // 0x00000001846E2190-0x00000001846E21D0
	}

	public struct NavMeshQuery : IDisposable // TypeDefIndex: 60385
	{
		// Fields
		internal IntPtr m_NavMeshQuery; // 0x00
	
		// Constructors
		public NavMeshQuery(NavMeshWorld world, Unity.Collections.Allocator allocator, int pathNodePoolSize = 0 /* Metadata: 0x020828D8 */) {
			m_NavMeshQuery = default;
		} // 0x0000000184E990F0-0x0000000184E99130
	
		// Methods
		public void Dispose() {} // 0x00000001852A50B0-0x00000001852A50E0
		private static IntPtr Create(NavMeshWorld world, int nodePoolSize) => default; // 0x000000018647291C-0x0000000186472938
		private static void Destroy(IntPtr navMeshQuery) {} // 0x00000001852A5130-0x00000001852A5170
		private static NavMeshLocation MapLocation(IntPtr navMeshQuery, Vector3 position, Vector3 extents, int agentTypeID, int areaMask = -1 /* Metadata: 0x020828D9 */) => default; // 0x0000000184326DA0-0x0000000184326E30
		public NavMeshLocation MapLocation(Vector3 position, Vector3 extents, int agentTypeID, int areaMask = -1 /* Metadata: 0x020828DA */) => default; // 0x0000000184326CD0-0x0000000184326DA0
		private static NavMeshLocation MoveLocation(IntPtr navMeshQuery, NavMeshLocation location, Vector3 target, int areaMask) => default; // 0x00000001853A2760-0x00000001853A27B0
		public NavMeshLocation MoveLocation(NavMeshLocation location, Vector3 target, int areaMask = -1 /* Metadata: 0x020828DB */) => default; // 0x00000001853A2690-0x00000001853A2760
		private static unsafe PathQueryStatus Raycast(IntPtr navMeshQuery, NavMeshLocation start, Vector3 targetPosition, int areaMask, void* costs, out NavMeshHit hit, void* path, out int pathCount, int maxPath) {
			hit = default;
			pathCount = default;
			return default;
		} // 0x000000018BE96B30-0x000000018BE96B88
		public PathQueryStatus Raycast(out NavMeshHit hit, NavMeshLocation start, Vector3 targetPosition, int areaMask = -1 /* Metadata: 0x020828DC */, NativeArray<float> costs = default) {
			hit = default;
			return default;
		} // 0x000000018BE96B88-0x000000018BE96C68
		private static IntPtr Create_Injected(ref NavMeshWorld world, int nodePoolSize) => default; // 0x000000018546BD30-0x000000018546BD80
		private static void MapLocation_Injected(IntPtr navMeshQuery, ref Vector3 position, ref Vector3 extents, int agentTypeID, int areaMask = -1 /* Metadata: 0x020828DD */, out NavMeshLocation ret) {
			ret = default;
		} // 0x0000000184326E30-0x0000000184326EA0
		private static void MoveLocation_Injected(IntPtr navMeshQuery, ref NavMeshLocation location, ref Vector3 target, int areaMask, out NavMeshLocation ret) {
			ret = default;
		} // 0x00000001853A27B0-0x00000001853A2820
		private static unsafe PathQueryStatus Raycast_Injected(IntPtr navMeshQuery, ref NavMeshLocation start, ref Vector3 targetPosition, int areaMask, void* costs, out NavMeshHit hit, void* path, out int pathCount, int maxPath) {
			hit = default;
			pathCount = default;
			return default;
		} // 0x000000018BE96ACC-0x000000018BE96B30
	}
}
