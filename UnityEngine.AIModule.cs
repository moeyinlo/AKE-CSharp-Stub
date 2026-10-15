/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

// Image 92: UnityEngine.AIModule.dll - Assembly: UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90257-90285

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 90258
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 90259
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine.AI
{
	[MovedFrom("UnityEngine")]
	public enum NavMeshPathStatus // TypeDefIndex: 90260
	{
		PathComplete = 0,
		PathPartial = 1,
		PathInvalid = 2,
		PathProcessing = 3
	}

	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/NavMeshPath.bindings.h")]
	public sealed class NavMeshPath // TypeDefIndex: 90261
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
		internal Vector3[] m_Corners; // 0x18
		internal int[] m_Areas; // 0x20
		internal Vector3[] m_DividingPos; // 0x28
	
		// Properties
		public Vector3[] corners { get; } // 0x0000000187837B40-0x0000000187837B5C 
		public NavMeshPathStatus status { get; } // 0x0000000185817DA0-0x0000000185817DE0 
		public bool needRepath { get; set; } // 0x0000000185543E40-0x0000000185543E80 0x0000000185583AF0-0x0000000185583B40
		public bool calcAutoRepath { set; } // 0x0000000185583AA0-0x0000000185583AF0
	
		// Constructors
		public NavMeshPath(); // 0x00000001855DFC50-0x00000001855DFC70
	
		// Methods
		~NavMeshPath(); // 0x0000000186A55DD0-0x0000000186A55E60
		[FreeFunction("NavMeshPathScriptBindings::InitializeNavMeshPath")]
		private static IntPtr InitializeNavMeshPath(); // 0x00000001855DFC70-0x00000001855DFCB0
		[FreeFunction("NavMeshPathScriptBindings::DestroyNavMeshPath", IsThreadSafe = true)]
		private static void DestroyNavMeshPath(IntPtr ptr); // 0x0000000186A55E60-0x0000000186A55EA0
		[FreeFunction("NavMeshPathScriptBindings::GetCornersNonAlloc", HasExplicitThis = true)]
		public int GetCornersNonAlloc(out Vector3[] corners, out int[] areas = null, out Vector3[] dividingPos = null); // 0x00000001868F12B0-0x00000001868F1320
		[FreeFunction("NavMeshPathScriptBindings::GetPolyCount", HasExplicitThis = true)]
		public int GetPolyCount(); // 0x0000000186A255E0-0x0000000186A25620
		[FreeFunction("NavMeshPathScriptBindings::CalculateCornersInternal", HasExplicitThis = true)]
		private Vector3[] CalculateCornersInternal(); // 0x0000000186C576C0-0x0000000186C57700
		[FreeFunction("NavMeshPathScriptBindings::ClearCornersInternal", HasExplicitThis = true)]
		private void ClearCornersInternal(); // 0x0000000185815920-0x0000000185815960
		public void ClearCorners(); // 0x00000001858158F0-0x0000000185815920
		private void CalculateCorners(); // 0x0000000186C57690-0x0000000186C576C0
	}

	[NativeHeader("Modules/AI/Builder/NavMeshBuilder.bindings.h")]
	[StaticAccessor("NavMeshBuilderBindings", StaticAccessorType.DoubleColon)]
	public static class NavMeshBuilder // TypeDefIndex: 90262
	{
		// Methods
		public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results); // 0x000000018D4B0F50-0x000000018D4B1160
		public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results); // 0x000000018D4B0DA0-0x000000018D4B0F50
		private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups); // 0x000000018D4B0D6C-0x000000018D4B0DA0
		public static void CollectSourcesV2(Bounds includedWorldBounds, int includedLayerMask, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results); // 0x0000000185B35160-0x0000000185B352C0
		private static NavMeshBuildSource[] CollectSourcesV2Internal(int includedLayerMask, Bounds includedWorldBounds, int defaultArea, NavMeshBuildMarkup[] markups); // 0x00000001878398A0-0x00000001878398B8
		public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation, bool useSubJob = false /* Metadata: 0x0264AD6E */); // 0x000000018D4B0B78-0x000000018D4B0D0C
		public static bool UpdateNavMeshData(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, bool useSubJob = false /* Metadata: 0x0264AD6F */); // 0x000000018D4B11E4-0x000000018D4B1390
		private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds, bool useSubJob); // 0x000000018D4B11C4-0x000000018D4B11E4
		public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, bool useSubJob = false /* Metadata: 0x0264AD70 */); // 0x0000000186C59B70-0x0000000186C59D00
		[NativeHeader("Modules/AI/NavMeshManager.h")]
		[NativeMethod("Purge")]
		[StaticAccessor("GetNavMeshManager().GetNavMeshBuildManager()", StaticAccessorType.Arrow)]
		public static void Cancel(NavMeshData data); // 0x0000000184F6C390-0x0000000184F6C3E0
		private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds, bool useSubJob); // 0x000000018783D3FC-0x000000018783D41C
		private static NavMeshBuildSource[] CollectSourcesInternal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups); // 0x000000018D4B0D0C-0x000000018D4B0D6C
		private static NavMeshBuildSource[] CollectSourcesV2Internal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, int defaultArea, NavMeshBuildMarkup[] markups); // 0x000000018702C630-0x000000018702C6A0
		private static bool UpdateNavMeshDataListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds, bool useSubJob); // 0x000000018D4B1160-0x000000018D4B11C4
		private static AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds, bool useSubJob); // 0x0000000186C59D00-0x0000000186C59D80
	}

	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	[NativeHeader("Modules/AI/Components/HGNavMeshAgent.bindings.h")]
	public sealed class HGNavMeshAgent : UnityEngine.Behaviour // TypeDefIndex: 90263
	{
	}

	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	[NativeHeader("Modules/AI/Components/NavMeshAgent.bindings.h")]
	public sealed class NavMeshAgent : UnityEngine.Behaviour // TypeDefIndex: 90264
	{
	}

	[MovedFrom("UnityEngine")]
	public enum NavMeshObstacleShape // TypeDefIndex: 90265
	{
		Capsule = 0,
		Box = 1,
		Polygon = 2
	}

	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/Components/NavMeshObstacle.bindings.h")]
	public sealed class NavMeshObstacle : UnityEngine.Behaviour // TypeDefIndex: 90266
	{
		// Properties
		public float height { get; set; } // 0x000000018D4B15B0-0x000000018D4B15E4 0x000000018D4B1688-0x000000018D4B16CC
		public float radius { get; set; } // 0x000000018D4B15E4-0x000000018D4B1618 0x000000018D4B16CC-0x000000018D4B1710
		public bool carving { set; } // 0x0000000185766150-0x00000001857661A0
		public bool carveOnlyStationary { set; } // 0x0000000185766060-0x00000001857660B0
		public NavMeshObstacleShape shape { set; } // 0x0000000185766010-0x0000000185766060
		public Vector3 center { get; set; } // 0x000000018D4B1584-0x000000018D4B15B0 0x0000000187837790-0x00000001878377A4
		public Vector3 size { [FreeFunction("NavMeshObstacleScriptBindings::GetSize", HasExplicitThis = true)] get; [FreeFunction("NavMeshObstacleScriptBindings::SetSize", HasExplicitThis = true)] set; } // 0x000000018D4B165C-0x000000018D4B1688 0x00000001878377A4-0x00000001878377B8
		public int ignoredSurfaceID { set; } // 0x00000001857660B0-0x0000000185766100
		public int carveArea { set; } // 0x0000000185766100-0x0000000185766150
	
		// Methods
		private void get_center_Injected(out Vector3 ret); // 0x000000018D4B1540-0x000000018D4B1584
		private void set_center_Injected(ref Vector3 value); // 0x0000000185765140-0x0000000185765190
		private void get_size_Injected(out Vector3 ret); // 0x000000018D4B1618-0x000000018D4B165C
		private void set_size_Injected(ref Vector3 value); // 0x0000000185765190-0x00000001857651E0
	}

	[MovedFrom("UnityEngine")]
	public struct NavMeshHit // TypeDefIndex: 90267
	{
		// Fields
		private Vector3 m_Position; // 0x00
		private Vector3 m_Normal; // 0x0C
		private float m_Distance; // 0x18
		private int m_Mask; // 0x1C
		private int m_Hit; // 0x20
	
		// Properties
		public Vector3 position { get; set; } // 0x000000018725FDC0-0x000000018725FDE0 0x000000018723AEB0-0x000000018723AEC0
		public Vector3 normal { get; } // 0x000000018725FDA0-0x000000018725FDC0 
		public float distance { get; } // 0x0000000184F6C3E0-0x0000000184F6C650 
		public bool hit { get; } // 0x000000018D4B1468-0x000000018D4B1470 
	}

	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	public sealed class NavMeshData : UnityEngine.Object // TypeDefIndex: 90268
	{
		// Properties
		public Bounds sourceBounds { get; } // 0x00000001861698C0-0x00000001861698F0 
		public Vector3 position { get; set; } // 0x0000000186169940-0x0000000186169970 0x000000018D4B1440-0x000000018D4B1454
		public Quaternion rotation { get; set; } // 0x0000000186169970-0x00000001861699A0 0x000000018D4B1454-0x000000018D4B1468
	
		// Constructors
		public NavMeshData(int agentTypeID); // 0x0000000186EC9B20-0x0000000186EC9B80
	
		// Methods
		[StaticAccessor("NavMeshDataBindings", StaticAccessorType.DoubleColon)]
		private static void Internal_Create([Writable] NavMeshData mono, int agentTypeID); // 0x0000000186EC9B80-0x0000000186EC9BD0
		public void AppendExtOffMeshLink(Vector3 start, Vector3 end, float width, bool bidirectional, int area, float costModifier); // 0x00000001861695E0-0x00000001861698C0
		[NativeMethod("AppendExtOffMeshLink")]
		internal void Internal_AppendExtOffMeshLink(Vector3 startLeft, Vector3 startRight, Vector3 endRight, Vector3 endLeft, bool bidirectional, int area, float costModifier); // 0x000000018783B920-0x000000018783B96C
		private void get_sourceBounds_Injected(out Bounds ret); // 0x00000001861698F0-0x0000000186169940
		private void get_position_Injected(out Vector3 ret); // 0x00000001861699A0-0x00000001861699F0
		private void set_position_Injected(ref Vector3 value); // 0x00000001870E9E20-0x00000001870E9E70
		private void get_rotation_Injected(out Quaternion ret); // 0x00000001861699F0-0x0000000186169A40
		private void set_rotation_Injected(ref Quaternion value); // 0x00000001870E9DD0-0x00000001870E9E20
		private void Internal_AppendExtOffMeshLink_Injected(ref Vector3 startLeft, ref Vector3 startRight, ref Vector3 endRight, ref Vector3 endLeft, bool bidirectional, int area, float costModifier); // 0x00000001861678D0-0x0000000186167950
	}

	public struct NavMeshDataInstance // TypeDefIndex: 90269
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _id_k__BackingField; // 0x00
	
		// Properties
		public bool valid { get; } // 0x00000001858F0DA0-0x00000001858F0DC0 
		internal int id { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int handleId { get; set; } // 0x000000018725FD00-0x000000018725FD10 0x0000000184547F40-0x0000000184547F50
		public UnityEngine.Object owner { set; } // 0x000000018D4B1390-0x000000018D4B1440
	
		// Methods
		public void Remove(); // 0x0000000186167C30-0x0000000186167C40
	}

	public struct NavMeshLinkData // TypeDefIndex: 90270
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
		public bool isExt { get; set; } // 0x000000018725FE40-0x000000018725FE50 0x0000000187233BE0-0x0000000187233BF0
		public Vector3 startLeft { get; set; } // 0x000000018725FE50-0x000000018725FE70 0x0000000187259ED0-0x0000000187259EE0
		public Vector3 startRight { get; set; } // 0x000000018725FE70-0x000000018725FE90 0x0000000187239670-0x0000000187239680
		public Vector3 endRight { get; set; } // 0x000000018725FE20-0x000000018725FE40 0x000000018723E2A0-0x000000018723E2B0
		public Vector3 endLeft { get; set; } // 0x000000018725FE00-0x000000018725FE20 0x000000018723EAF0-0x000000018723EB00
		public float costModifier { get; set; } // 0x000000018783AB70-0x000000018783AB78 0x0000000187233AF0-0x0000000187233B00
		public bool bidirectional { get; set; } // 0x000000018C91BC10-0x000000018C91BC18 0x000000018688BDF0-0x000000018688BE10
		public int area { get; set; } // 0x000000018725FDF0-0x000000018725FE00 0x000000018226F010-0x000000018226F020
		public int agentTypeID { get; set; } // 0x000000018725FDE0-0x000000018725FDF0 0x0000000182271C70-0x0000000182271C80
	}

	public struct NavMeshLinkInstance // TypeDefIndex: 90271
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _id_k__BackingField; // 0x00
	
		// Properties
		public bool valid { get; } // 0x000000018D4B147C-0x000000018D4B1490 
		internal int id { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public UnityEngine.Object owner { set; } // 0x000000018D4B1490-0x000000018D4B1540
	
		// Methods
		public void Remove(); // 0x000000018D4B1470-0x000000018D4B147C
	}

	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	[NativeHeader("Modules/AI/NavMeshManager.h")]
	[StaticAccessor("NavMeshBindings", StaticAccessorType.DoubleColon)]
	public static class NavMesh // TypeDefIndex: 90274
	{
		// Fields
		public static OnNavMeshPreUpdate onPreUpdate; // 0x00
		public static OnUnloadFinishDelegate onUnloadFinish; // 0x08
	
		// Nested types
		public delegate void OnNavMeshPreUpdate(); // TypeDefIndex: 90272; 0x0000000185B44B70-0x0000000185B44B80
	
		public delegate void OnUnloadFinishDelegate(ulong surfTileID); // TypeDefIndex: 90273; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Methods
		[RequiredByNativeCode]
		private static void Internal_CallOnNavMeshPreUpdate(); // 0x0000000186242710-0x0000000186242740
		public static bool Raycast(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, int areaMask); // 0x0000000187836894-0x00000001878368AC
		public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd = true /* Metadata: 0x0264AD74 */, int agentTypeID = -1 /* Metadata: 0x0264AD75 */, float radius = -1f /* Metadata: 0x0264AD76 */); // 0x0000000185815730-0x0000000185815810
		private static bool CalculatePathInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius); // 0x0000000187837B94-0x0000000187837BCC
		public static bool FindClosestEdge(Vector3 sourcePosition, out NavMeshHit hit, int areaMask); // 0x000000018D4B1AA8-0x000000018D4B1ABC
		public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask); // 0x0000000187835B1C-0x0000000187835B34
		[NativeName("GetAreaFromName")]
		[StaticAccessor("GetNavMeshProjectSettings()")]
		public static int GetAreaFromName(string areaName); // 0x0000000186C53210-0x0000000186C53250
		public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData); // 0x0000000186167D70-0x0000000186167E10
		public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation); // 0x000000018616A5F0-0x000000018616A700
		public static void UpdateSurfaceTransform(NavMeshDataInstance handle, Vector3 position, Quaternion rotation); // 0x000000018D4B1D74-0x000000018D4B1E64
		public static void RemoveNavMeshData(NavMeshDataInstance handle); // 0x00000001861668D0-0x00000001861668E0
		[NativeName("IsValidSurfaceID")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool IsValidNavMeshDataHandle(int handle); // 0x00000001858F0DC0-0x00000001858F0E00
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool IsValidLinkHandle(int handle); // 0x000000018D4B1C18-0x000000018D4B1C4C
		[NativeName("SetSurfaceUserID")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool InternalSetOwner(int dataID, int ownerID); // 0x000000018D4B1B04-0x000000018D4B1B44
		[NativeName("SetLinkUserID")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool InternalSetLinkOwner(int linkID, int ownerID); // 0x000000018D4B1AC4-0x000000018D4B1B04
		[NativeName("LoadData")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static int AddNavMeshDataInternal(NavMeshData navMeshData); // 0x0000000186167E10-0x0000000186167E50
		[NativeName("LoadData")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation); // 0x000000018783B974-0x000000018783B988
		[NativeName("UnloadData")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void RemoveNavMeshDataInternal(int handle); // 0x0000000186167BF0-0x0000000186167C30
		public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation); // 0x000000018688BD60-0x000000018688BDF0
		public static void RemoveLink(NavMeshLinkInstance handle); // 0x000000018D4B1D00-0x000000018D4B1D08
		[NativeName("AddLink")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation); // 0x000000018783C970-0x000000018783C984
		[NativeName("RemoveLink")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void RemoveLinkInternal(int handle); // 0x000000018D4B1CCC-0x000000018D4B1D00
		public static NavMeshBuildSettings GetSettingsByID(int agentTypeID); // 0x00000001861673E0-0x0000000186167420
		public static NavMeshBuildSettings GetSettingsByIndex(int index); // 0x0000000186A2F740-0x0000000186A2F780
		[NativeName("UpdateSurfaceTransform")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void UpdateSurfaceTransformInternal(int surfaceID, Vector3 position, Quaternion rotation); // 0x000000018D4B1D60-0x000000018D4B1D74
		public static bool DetachFromSurface(int chunkSurfaceId, int builderSurfaceId, int indexX, int indexZ); // 0x00000001858F17C0-0x00000001858F17D0
		public static bool SetBuilderSurfaceParams(int surfID, float chunkSize, float tileSize, float centerX, float centerZ, float sizeX, float sizeZ); // 0x0000000186166BB0-0x0000000186166BC0
		[NativeName("DetachFromSurface")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool Internal_DetachFromSurface(int chunkSurfaceId, int builderSurfaceId, int indexX, int indexZ); // 0x00000001858F17D0-0x00000001858F1840
		[NativeName("SetBuilderSurfaceParams")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool Internal_SetBuilderSurfaceParams(int surfID, float chunkSize, float tileSize, float centerX, float centerZ, float sizeX, float sizeZ); // 0x0000000186166580-0x00000001861665F0
		public static int LoadDynamicBakeTile(NavMeshData navMeshData); // 0x000000018D4B1C4C-0x000000018D4B1C58
		public static void UnloadDynamicBakeTile(int dynamicTileID); // 0x000000018D4B1D08-0x000000018D4B1D10
		[NativeName("LoadDynamicBakeTile")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static int Internal_LoadDynamicBakeTile(NavMeshData navMeshData); // 0x000000018D4B1BA4-0x000000018D4B1BD8
		[NativeName("UnloadDynamicBakeTile")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_UnloadDynamicBakeTile(int dynamicTileID); // 0x000000018D4B1BD8-0x000000018D4B1C0C
		public static int ModifyVolumeArea(List<Vector3> center, List<Vector3> ext, List<Quaternion> rotation, int area); // 0x000000018D4B1CBC-0x000000018D4B1CCC
		private static int ModifyBoxAreaInternal(List<Vector3> center, List<Vector3> ext, List<Quaternion> rotation, int area); // 0x000000018D4B1C58-0x000000018D4B1CBC
		public static int ModifyVolumeArea(List<Vector3> verts, float hMin, float hMax, int area); // 0x0000000186D2F440-0x0000000186D2F450
		private static int ModifyPolygonAreaInternal(List<Vector3> verts, float hMin, float hMax, int area); // 0x0000000186D2F450-0x0000000186D2F4C0
		public static void LoadExtOffMeshLinks(int surfaceID); // 0x000000018783B96C-0x000000018783B974
		[NativeName("LoadExtOffMeshLinks")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_LoadExtOffMeshLinks(int surfaceID); // 0x000000018716D5B0-0x000000018716D5F0
		[NativeName("BeginLoadingBatch")]
		[StaticAccessor("GetNavMeshManager()")]
		public static void BeginLoadingBatch(); // 0x0000000185ACAC80-0x0000000185ACACC0
		[NativeName("EndLoadingBatch")]
		[StaticAccessor("GetNavMeshManager()")]
		public static void EndLoadingBatch(); // 0x0000000185ACAD60-0x0000000185ACADA0
		[NativeName("IsLoadingBatch")]
		[StaticAccessor("GetNavMeshManager()")]
		public static bool IsLoadingBatch(); // 0x0000000185ACAD20-0x0000000185ACAD60
		public static AsyncOperation AddNavMeshDataAsync(ref int surfaceID, NavMeshData navMeshData, ulong surfTileID); // 0x00000001867FFEB0-0x00000001867FFF50
		private static AsyncOperation AddNavMeshDataAsyncInternal(ref int surfaceID, NavMeshData navMeshData, ulong surfTileID); // 0x00000001867FFF50-0x00000001867FFFB0
		public static void CancelAsyncAdd(ulong surfTileID); // 0x000000018D4B1A4C-0x000000018D4B1A54
		[NativeName("PurgeAsyncOperations")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_CancelAsyncAdd(ulong surfaceID); // 0x000000018D4B1B44-0x000000018D4B1B78
		public static void UnloadDataAsync(int surfaceID, ulong surfTileID); // 0x00000001878380C4-0x00000001878380CC
		[NativeName("UnloadDataAsync")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_UnloadDataAsync(int surfaceID, ulong surfTileID); // 0x0000000186ABEE10-0x0000000186ABEE60
		[RequiredByNativeCode]
		private static void Internal_InvokeOnUnloadFinish(ulong surfTileID); // 0x000000018695EB30-0x000000018695ED10
		public static bool IsSurfaceUnloading(ulong surfTileID); // 0x000000018D4B1C0C-0x000000018D4B1C18
		[NativeName("IsSurfaceUnloading")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool Internal_IsSurfaceUnloading(ulong surfTileID); // 0x0000000186ACCA70-0x0000000186ACCAB0
		public static void ForceClearUnloadDataRequest(); // 0x000000018D4B1ABC-0x000000018D4B1AC4
		[NativeName("ForceClearUnloadDataRequest")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_ForceClearUnloadDataRequest(); // 0x000000018D4B1B78-0x000000018D4B1BA4
		public static void CalculatePathAsync(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd = true /* Metadata: 0x0264AD7A */, int agentTypeID = -1 /* Metadata: 0x0264AD7B */, float radius = -1f /* Metadata: 0x0264AD7C */); // 0x0000000185815810-0x00000001858158F0
		private static void CalculatePathAsyncInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius); // 0x0000000187837B5C-0x0000000187837B94
		public static void SetFindPathMaxIterPerFrame(int maxIterPerFrame); // 0x000000018783B918-0x000000018783B920
		[NativeName("SetFindPathMaxIterPerFrame")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_SetFindPathMaxIterPerFrame(int maxIterPerFrame); // 0x00000001872167A0-0x00000001872167E0
		public static void CancelAsyncCalculatePath(NavMeshPath path); // 0x0000000187836A00-0x0000000187836A08
		[NativeName("PurgeAsyncFindPath")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_CancelAsyncCalculatePath(NavMeshPath path); // 0x000000018694FDE0-0x000000018694FE20
		public static void RegisterAutoRepath(NavMeshPath path); // 0x000000018783C518-0x000000018783C520
		[NativeName("RegisterAutoRepath")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_RegisterAutoRepath(NavMeshPath path); // 0x0000000186D358F0-0x0000000186D35930
		public static void UnregisterAutoRepath(NavMeshPath path); // 0x000000018783CCB8-0x000000018783CCC0
		[NativeName("UnregisterAutoRepath")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_UnregisterAutoRepath(NavMeshPath path); // 0x0000000186DDD1C0-0x0000000186DDD200
		public static bool RaycastNearestPoint(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, int areaMask); // 0x0000000187835B34-0x0000000187835B4C
		private static bool Raycast_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, out NavMeshHit hit, int areaMask); // 0x000000018633D6A0-0x000000018633D710
		private static bool CalculatePathInternal_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius); // 0x0000000186CB9440-0x0000000186CB94C0
		private static bool FindClosestEdge_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, int areaMask); // 0x000000018D4B1A54-0x000000018D4B1AA8
		private static bool SamplePosition_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask); // 0x0000000185E10660-0x0000000185E106D0
		private static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation); // 0x00000001870F0310-0x00000001870F03D0
		private static int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation); // 0x000000018688BE10-0x000000018688BE70
		private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret); // 0x0000000186167420-0x0000000186167470
		private static void GetSettingsByIndex_Injected(int index, out NavMeshBuildSettings ret); // 0x0000000186A2F780-0x0000000186A2F7D0
		private static void UpdateSurfaceTransformInternal_Injected(int surfaceID, ref Vector3 position, ref Quaternion rotation); // 0x000000018D4B1D10-0x000000018D4B1D60
		private static void CalculatePathAsyncInternal_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius); // 0x0000000186743AE0-0x0000000186743B60
		private static bool RaycastNearestPoint_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, out NavMeshHit hit, int areaMask); // 0x0000000185EDD4B0-0x0000000185EDD520
	}

	public enum NavMeshBuildSourceShape // TypeDefIndex: 90275
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

	public enum NavMeshCollectGeometry // TypeDefIndex: 90276
	{
		RenderMeshes = 0,
		PhysicsColliders = 1
	}

	[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
	[UsedByNativeCode]
	public struct NavMeshBuildSource // TypeDefIndex: 90277
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
		public Matrix4x4 transform { get; set; } // 0x000000018725FD50-0x000000018725FD80 0x000000018725FD80-0x000000018725FDA0
		public Vector3 size { get; set; } // 0x000000018725FD30-0x000000018725FD50 0x0000000187236550-0x0000000187236560
		public NavMeshBuildSourceShape shape { get; set; } // 0x000000018725FD20-0x000000018725FD30 0x0000000187233740-0x0000000187233750
		public int area { get; set; } // 0x000000018725FD10-0x000000018725FD20 0x00000001854CCF30-0x00000001854CCF40
		public UnityEngine.Object sourceObject { get; } // 0x000000018D4B0B6C-0x000000018D4B0B78 
		public Component component { get; } // 0x000000018D4B0B60-0x000000018D4B0B6C 
	
		// Methods
		[StaticAccessor("NavMeshBuildSource", StaticAccessorType.DoubleColon)]
		private static Component InternalGetComponent(int instanceID); // 0x000000018D4B0AF8-0x000000018D4B0B2C
		[StaticAccessor("NavMeshBuildSource", StaticAccessorType.DoubleColon)]
		private static UnityEngine.Object InternalGetObject(int instanceID); // 0x000000018D4B0B2C-0x000000018D4B0B60
	}

	[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
	public struct NavMeshBuildMarkup // TypeDefIndex: 90278
	{
		// Fields
		private int m_OverrideArea; // 0x00
		private int m_Area; // 0x04
		private int m_IgnoreFromBuild; // 0x08
		private int m_InstanceID; // 0x0C
	
		// Properties
		public bool overrideArea { set; } // 0x000000018D4B0A74-0x000000018D4B0A7C
		public int area { set; } // 0x0000000187235AB0-0x0000000187235AC0
		public bool ignoreFromBuild { set; } // 0x00000001850BFBA0-0x00000001850BFBB0
		public Transform root { set; } // 0x000000018D4B0A7C-0x000000018D4B0AF8
	}

	[NativeHeader("Modules/AI/Public/NavMeshBuildSettings.h")]
	public struct NavMeshBuildSettings // TypeDefIndex: 90279
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
		public int agentTypeID { get; set; } // 0x000000018725FD00-0x000000018725FD10 0x0000000184547F40-0x0000000184547F50
		public float agentRadius { get; } // 0x000000018725FCF0-0x000000018725FD00 
		public float agentHeight { get; } // 0x000000018725FCE0-0x000000018725FCF0 
		public float agentClimb { get; } // 0x000000018725FCD0-0x000000018725FCE0 
		public float minRegionArea { set; } // 0x0000000187233420-0x0000000187233430
		public bool overrideVoxelSize { set; } // 0x00000001861669A0-0x00000001861669C0
		public float voxelSize { set; } // 0x0000000187236720-0x0000000187236730
		public bool overrideTileSize { set; } // 0x00000001861669C0-0x00000001861669E0
		public int tileSize { set; } // 0x0000000182271AB0-0x0000000182271AC0
		public int partitioningMethod { set; } // 0x000000018226F010-0x000000018226F020
		public bool filterLowHangingObstacles { set; } // 0x0000000186166A40-0x0000000186166A60
		public bool filterLedgeSpans { set; } // 0x0000000186166A20-0x0000000186166A40
		public bool filterWalkableLowHeightSpans { set; } // 0x0000000186166A00-0x0000000186166A20
		public bool erodeAgainstWallSpans { set; } // 0x00000001861669E0-0x0000000186166A00
		public int cliffIndent { set; } // 0x00000001854CCF30-0x00000001854CCF40
	}

	[NativeHeader("Modules/AI/Public/NavMeshBuildDebugSettings.h")]
	public struct NavMeshBuildDebugSettings // TypeDefIndex: 90280
	{
		// Fields
		private byte m_Flags; // 0x00
	}
}

namespace UnityEngine.Experimental.AI
{
	public struct PolygonId : IEquatable<PolygonId> // TypeDefIndex: 90281
	{
		// Fields
		internal ulong polyRef; // 0x00
	
		// Methods
		public bool IsNull(); // 0x00000001850BC1F0-0x00000001850BC200
		public static bool operator ==(PolygonId x, PolygonId y); // 0x0000000184F9DDF0-0x0000000184F9DE00
		public static bool operator !=(PolygonId x, PolygonId y); // 0x0000000184F9E9E0-0x0000000184F9E9F0
		public override int GetHashCode(); // 0x000000018725FE90-0x000000018725FEA0
		public bool Equals(PolygonId rhs); // 0x000000018D4B1ED0-0x000000018D4B1ED8
		public override bool Equals(object obj); // 0x000000018D4B1E64-0x000000018D4B1ED0
	}

	public struct NavMeshLocation // TypeDefIndex: 90282
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly PolygonId _polygon_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Vector3 _position_k__BackingField; // 0x08
	
		// Properties
		public PolygonId polygon { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000184431970-0x0000000184431980 
		public Vector3 position { [IsReadOnly] [CompilerGenerated] get; } // 0x000000018724A620-0x000000018724A640 
	}

	[Flags]
	public enum PathQueryStatus // TypeDefIndex: 90283
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
	public struct NavMeshWorld // TypeDefIndex: 90284
	{
		// Fields
		internal IntPtr world; // 0x00
	
		// Methods
		public static NavMeshWorld GetDefaultWorld(); // 0x0000000186167350-0x00000001861673A0
		private static void GetDefaultWorld_Injected(out NavMeshWorld ret); // 0x00000001861673A0-0x00000001861673E0
	}

	[NativeContainer]
	[NativeHeader("Runtime/Math/Matrix4x4.h")]
	[NativeHeader("Modules/AI/NavMeshExperimental.bindings.h")]
	[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
	[StaticAccessor("NavMeshQueryBindings", StaticAccessorType.DoubleColon)]
	public struct NavMeshQuery : IDisposable // TypeDefIndex: 90285
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr m_NavMeshQuery; // 0x00
	
		// Constructors
		public NavMeshQuery(NavMeshWorld world, Unity.Collections.Allocator allocator, int pathNodePoolSize = 0 /* Metadata: 0x0264ADA3 */); // 0x00000001861665F0-0x0000000186166630
	
		// Methods
		public void Dispose(); // 0x000000018D4B1744-0x000000018D4B1774
		private static IntPtr Create(NavMeshWorld world, int nodePoolSize); // 0x000000018783B8FC-0x000000018783B918
		private static void Destroy(IntPtr navMeshQuery); // 0x000000018D4B1710-0x000000018D4B1744
		[ThreadSafe]
		private static NavMeshLocation MapLocation(IntPtr navMeshQuery, Vector3 position, Vector3 extents, int agentTypeID, int areaMask = -1 /* Metadata: 0x0264ADA4 */); // 0x0000000185544140-0x00000001855441D0
		public NavMeshLocation MapLocation(Vector3 position, Vector3 extents, int agentTypeID, int areaMask = -1 /* Metadata: 0x0264ADA5 */); // 0x0000000185544070-0x0000000185544140
		[ThreadSafe]
		private static NavMeshLocation MoveLocation(IntPtr navMeshQuery, NavMeshLocation location, Vector3 target, int areaMask); // 0x000000018D4B17D8-0x000000018D4B181C
		public NavMeshLocation MoveLocation(NavMeshLocation location, Vector3 target, int areaMask = -1 /* Metadata: 0x0264ADA6 */); // 0x000000018D4B181C-0x000000018D4B18A4
		[ThreadSafe]
		private static unsafe PathQueryStatus Raycast(IntPtr navMeshQuery, NavMeshLocation start, Vector3 targetPosition, int areaMask, void* costs, out NavMeshHit hit, void* path, out int pathCount, int maxPath); // 0x000000018D4B1908-0x000000018D4B1960
		public PathQueryStatus Raycast(out NavMeshHit hit, NavMeshLocation start, Vector3 targetPosition, int areaMask = -1 /* Metadata: 0x0264ADA7 */, NativeArray<float> costs = default); // 0x000000018D4B1960-0x000000018D4B1A4C
		private static IntPtr Create_Injected(ref NavMeshWorld world, int nodePoolSize); // 0x00000001871CB190-0x00000001871CB1E0
		private static void MapLocation_Injected(IntPtr navMeshQuery, ref Vector3 position, ref Vector3 extents, int agentTypeID, int areaMask = -1 /* Metadata: 0x0264ADA8 */, out NavMeshLocation ret); // 0x00000001855441D0-0x0000000185544240
		private static void MoveLocation_Injected(IntPtr navMeshQuery, ref NavMeshLocation location, ref Vector3 target, int areaMask, out NavMeshLocation ret); // 0x000000018D4B1774-0x000000018D4B17D8
		private static unsafe PathQueryStatus Raycast_Injected(IntPtr navMeshQuery, ref NavMeshLocation start, ref Vector3 targetPosition, int areaMask, void* costs, out NavMeshHit hit, void* path, out int pathCount, int maxPath); // 0x000000018D4B18A4-0x000000018D4B1908
	}
}
