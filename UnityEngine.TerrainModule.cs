/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using UnityEngine;

// Image 88: UnityEngine.TerrainModule.dll - Assembly: UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60313-60333

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 60314
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 60315
	{
		// Constructors
		public IsReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine
{
	public sealed class Terrain : UnityEngine.Behaviour // TypeDefIndex: 60316
	{
		// Properties
		public TerrainData terrainData { get => default; set {} } // 0x000000018BF456E8-0x000000018BF4571C 0x000000018BF45908-0x000000018BF4594C
		public float detailObjectDistance { set {} } // 0x000000018BF457A4-0x000000018BF457E8
		public float detailObjectDensity { set {} } // 0x000000018BF45760-0x000000018BF457A4
		public int lightmapIndex { set {} } // 0x000000018BF4582C-0x000000018BF4586C
		public Vector4 lightmapScaleOffset { set {} } // 0x000000018BF458B0-0x000000018BF458C4
		public Material materialTemplate { get => default; set {} } // 0x000000018BF456B4-0x000000018BF456E8 0x000000018BF458C4-0x000000018BF45908
		public bool allowAutoConnect { get => default; set {} } // 0x000000018BF4564C-0x000000018BF45680 0x000000018BF4571C-0x000000018BF45760
		public int groupingID { get => default; } // 0x000000018BF45680-0x000000018BF456B4 
		public bool drawInstanced { set {} } // 0x000000018BF457E8-0x000000018BF4582C
		public static Terrain[] activeTerrains { get => default; } // 0x000000018BF45620-0x000000018BF4564C 
	
		// Constructors
		public Terrain() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) {} // 0x000000018BF455BC-0x000000018BF45620
		public void Flush() {} // 0x000000018BF45580-0x000000018BF455B4
		public static void GetActiveTerrains(List<Terrain> terrainList) {} // 0x000000018BF455B4-0x000000018BF455BC
		private static void Internal_FillActiveTerrainList(object terrainList) {} // 0x000000018512D7D0-0x000000018512D810
		private void set_lightmapScaleOffset_Injected(ref Vector4 value) {} // 0x000000018BF4586C-0x000000018BF458B0
	}

	public static class TerrainCallbacks // TypeDefIndex: 60319
	{
		// Fields
		private static HeightmapChangedCallback heightmapChanged; // 0x00
		private static TextureChangedCallback textureChanged; // 0x08
	
		// Nested types
		public delegate void HeightmapChangedCallback(Terrain terrain, RectInt heightRegion, bool synched); // TypeDefIndex: 60317; 0x000000018BF41C40-0x000000018BF41D28
	
		public delegate void TextureChangedCallback(Terrain terrain, string textureName, RectInt texelRegion, bool synched); // TypeDefIndex: 60318; 0x000000018720FD6C-0x000000018720FD98
	
		// Methods
		internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) {} // 0x000000018BF4594C-0x000000018BF45A20
		internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched) {} // 0x0000000187220038-0x000000018722006C
	}

	public sealed class TreePrototype // TypeDefIndex: 60320
	{
		// Fields
		internal GameObject m_Prefab; // 0x10
		internal float m_BendFactor; // 0x18
		internal int m_NavMeshLod; // 0x1C
	
		// Properties
		public GameObject prefab { get => default; set {} } // 0x0000000185FC7990-0x0000000185FC79A0 0x0000000184096E30-0x0000000184096EF0
		public float bendFactor { get => default; set {} } // 0x0000000185FE68F0-0x0000000185FE6900 0x0000000181C9A5A0-0x0000000181C9A5B0
		public int navMeshLod { get => default; } // 0x0000000185FC79A0-0x0000000185FC79B0 
	
		// Constructors
		public TreePrototype() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018BF45A20-0x000000018BF45A84
		public override int GetHashCode() => default; // 0x0000000185FE7B30-0x0000000185FE7B40
		private bool Equals(TreePrototype other) => default; // 0x000000018BF45A84-0x000000018BF45B4C
	}

	public enum DetailRenderMode // TypeDefIndex: 60321
	{
		GrassBillboard = 0,
		VertexLit = 1,
		Grass = 2
	}

	public sealed class DetailPrototype // TypeDefIndex: 60322
	{
		// Fields
		internal static readonly UnityEngine.Color DefaultHealthColor; // 0x00
		internal static readonly UnityEngine.Color DefaultDryColor; // 0x10
		internal GameObject m_Prototype; // 0x10
		internal Texture2D m_PrototypeTexture; // 0x18
		internal UnityEngine.Color m_HealthyColor; // 0x20
		internal UnityEngine.Color m_DryColor; // 0x30
		internal float m_MinWidth; // 0x40
		internal float m_MaxWidth; // 0x44
		internal float m_MinHeight; // 0x48
		internal float m_MaxHeight; // 0x4C
		internal int m_NoiseSeed; // 0x50
		internal float m_NoiseSpread; // 0x54
		internal float m_HoleEdgePadding; // 0x58
		internal int m_RenderMode; // 0x5C
		internal int m_UsePrototypeMesh; // 0x60
		internal int m_UseInstancing; // 0x64
	
		// Properties
		public GameObject prototype { get => default; set {} } // 0x0000000185FC7990-0x0000000185FC79A0 0x0000000184096E30-0x0000000184096EF0
		public Texture2D prototypeTexture { get => default; set {} } // 0x0000000185FC2A70-0x0000000185FC2A80 0x0000000184088E70-0x0000000184088E80
		public float minWidth { get => default; set {} } // 0x000000018646D1F0-0x000000018646D200 0x0000000185FB05F0-0x0000000185FB0600
		public float maxWidth { get => default; set {} } // 0x000000018646D200-0x000000018646D210 0x0000000185FB0600-0x0000000185FB0610
		public float minHeight { get => default; set {} } // 0x000000018646D210-0x000000018646D218 0x0000000185FBCE20-0x0000000185FBCE30
		public float maxHeight { get => default; set {} } // 0x0000000185FE8E70-0x0000000185FE8E80 0x0000000185FBFAC0-0x0000000185FBFAD0
		public float noiseSpread { get => default; set {} } // 0x0000000185FE8E80-0x0000000185FE8E90 0x0000000183F804D0-0x0000000183F804E0
		public UnityEngine.Color healthyColor { get => default; set {} } // 0x0000000185FE8E60-0x0000000185FE8E70 0x0000000185FB6130-0x0000000185FB6140
		public UnityEngine.Color dryColor { get => default; set {} } // 0x0000000185FE8740-0x0000000185FE8750 0x0000000185FB12A0-0x0000000185FB12B0
		public DetailRenderMode renderMode { get => default; set {} } // 0x0000000185FE8E90-0x0000000185FE8EA0 0x0000000183F804F0-0x0000000183F80500
		public bool usePrototypeMesh { get => default; set {} } // 0x0000000183F87ED0-0x0000000183F87EE0 0x000000018BF41A7C-0x000000018BF41A98
		public bool useInstancing { set {} } // 0x0000000183F87EE0-0x0000000183F8B330
	
		// Constructors
		public DetailPrototype() {} // 0x000000018BF41884-0x000000018BF4193C
		public DetailPrototype(DetailPrototype other) {} // 0x000000018BF4193C-0x000000018BF41A7C
		static DetailPrototype() {} // 0x000000018BF4182C-0x000000018BF41884
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018BF4161C-0x000000018BF41680
		public override int GetHashCode() => default; // 0x0000000185FE7B30-0x0000000185FE7B40
		private bool Equals(DetailPrototype other) => default; // 0x000000018BF41680-0x000000018BF4182C
	}

	public struct TreeInstance // TypeDefIndex: 60323
	{
		// Fields
		public Vector3 position; // 0x00
		public float widthScale; // 0x0C
		public float heightScale; // 0x10
		public float rotation; // 0x14
		public Color32 color; // 0x18
		public Color32 lightmapColor; // 0x1C
		public int prototypeIndex; // 0x20
		internal float temporaryDistance; // 0x24
	}

	public sealed class TerrainData : UnityEngine.Object // TypeDefIndex: 60325
	{
		// Fields
		private const string k_ScriptingInterfaceName = "TerrainDataScriptingInterface"; // Metadata: 0x020827EB
		private const string k_ScriptingInterfacePrefix = "TerrainDataScriptingInterface::"; // Metadata: 0x02082809
		private const string k_HeightmapPrefix = "GetHeightmap()."; // Metadata: 0x02082829
		private const string k_DetailDatabasePrefix = "GetDetailDatabase()."; // Metadata: 0x02082839
		private const string k_TreeDatabasePrefix = "GetTreeDatabase()."; // Metadata: 0x0208284E
		private const string k_SplatDatabasePrefix = "GetSplatDatabase()."; // Metadata: 0x02082861
		internal static readonly int k_MaximumResolution; // 0x00
		internal static readonly int k_MinimumDetailResolutionPerPatch; // 0x04
		internal static readonly int k_MaximumDetailResolutionPerPatch; // 0x08
		internal static readonly int k_MaximumDetailPatchCount; // 0x0C
		internal static readonly int k_MaximumDetailsPerRes; // 0x10
		internal static readonly int k_MinimumAlphamapResolution; // 0x14
		internal static readonly int k_MaximumAlphamapResolution; // 0x18
		internal static readonly int k_MinimumBaseMapResolution; // 0x1C
		internal static readonly int k_MaximumBaseMapResolution; // 0x20
	
		// Properties
		public RenderTexture heightmapTexture { get => default; } // 0x000000018BF4316C-0x000000018BF431A0 
		public int heightmapResolution { get => default; set {} } // 0x000000018BF43160-0x000000018BF4316C 0x000000018BF435E8-0x000000018BF43710
		private int internalHeightmapResolution { get => default; set {} } // 0x000000018BF431E4-0x000000018BF43218 0x000000018BF43710-0x000000018BF43750
		public Texture holesTexture { get => default; } // 0x000000018BF431B4-0x000000018BF431E4 
		public bool enableHolesTextureCompression { get => default; set {} } // 0x000000018BF4312C-0x000000018BF43160 0x000000018BF435A4-0x000000018BF435E8
		public int holesResolution { get => default; } // 0x000000018BF431A0-0x000000018BF431B4 
		public Vector3 size { get => default; set {} } // 0x000000018BF4325C-0x000000018BF43288 0x000000018BF43794-0x000000018BF437A8
		public int detailWidth { get => default; } // 0x000000018BF430F8-0x000000018BF4312C 
		public int detailHeight { get => default; } // 0x000000018BF43028-0x000000018BF4305C 
		public int detailResolution { get => default; } // 0x000000018BF430C4-0x000000018BF430F8 
		public int detailResolutionPerPatch { get => default; } // 0x000000018BF43090-0x000000018BF430C4 
		public DetailPrototype[] detailPrototypes { get => default; set {} } // 0x000000018BF4305C-0x000000018BF43090 0x000000018BF43560-0x000000018BF435A4
		public TreeInstance[] treeInstances { get => default; } // 0x000000018BF432BC-0x000000018BF432C8 
		public TreePrototype[] treePrototypes { get => default; set {} } // 0x000000018BF432C8-0x000000018BF432FC 0x000000018BF437EC-0x000000018BF43830
		public int alphamapLayers { get => default; } // 0x000000018BF42F28-0x000000018BF42F5C 
		public int alphamapResolution { get => default; set {} } // 0x000000018BF42F1C-0x000000018BF42F28 0x000000018BF43370-0x000000018BF43560
		private int Internal_alphamapResolution { get => default; set {} } // 0x000000018BF42EB4-0x000000018BF42EE8 0x000000018BF43330-0x000000018BF43370
		public int alphamapWidth { get => default; } // 0x000000018BF42F1C-0x000000018BF42F28 
		public int alphamapHeight { get => default; } // 0x000000018BF42F1C-0x000000018BF42F28 
		public int baseMapResolution { get => default; } // 0x000000018BF4301C-0x000000018BF43028 
		private int Internal_baseMapResolution { get => default; } // 0x000000018BF42EE8-0x000000018BF42F1C 
		public int alphamapTextureCount { get => default; } // 0x000000018BF42F5C-0x000000018BF42F90 
		public Texture2D[] alphamapTextures { get => default; } // 0x000000018BF42F90-0x000000018BF4301C 
		public TerrainLayer[] terrainLayers { get => default; set {} } // 0x000000018BF43288-0x000000018BF432BC 0x000000018BF437A8-0x000000018BF437EC
		internal Terrain[] users { get => default; } // 0x000000018BF432FC-0x000000018BF43330 
	
		// Nested types
		private enum BoundaryValueType // TypeDefIndex: 60324
		{
			MaxHeightmapRes = 0,
			MinDetailResPerPatch = 1,
			MaxDetailResPerPatch = 2,
			MaxDetailPatchCount = 3,
			MaxDetailsPerRes = 4,
			MinAlphamapRes = 5,
			MaxAlphamapRes = 6,
			MinBaseMapRes = 7,
			MaxBaseMapRes = 8
		}
	
		// Constructors
		public TerrainData() {} // 0x000000018BF42E5C-0x000000018BF42EB4
		static TerrainData() {} // 0x000000018BF42D44-0x000000018BF42E5C
	
		// Methods
		private static int GetBoundaryValue(BoundaryValueType type) => default; // 0x000000018BF41E24-0x000000018BF41E58
		private static void Internal_Create(TerrainData terrainData) {} // 0x000000018BF42238-0x000000018BF4226C
		internal bool IsHolesTextureCompressed() => default; // 0x000000018BF42530-0x000000018BF42564
		internal RenderTexture GetHolesTexture() => default; // 0x000000018BF41FD4-0x000000018BF42008
		internal Texture2D GetCompressedHolesTexture() => default; // 0x000000018BF41E58-0x000000018BF41E8C
		public float GetInterpolatedHeight(float x, float y) => default; // 0x000000018BF420F0-0x000000018BF42144
		public float[,] GetHeights(int xBase, int yBase, int width, int height) => default; // 0x000000018BF41EEC-0x000000018BF41FD4
		private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height) => default; // 0x000000018BF422CC-0x000000018BF4232C
		public void SetHeights(int xBase, int yBase, float[,] heights) {} // 0x000000018BF42A64-0x000000018BF42CF0
		private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights) {} // 0x000000018BF424D0-0x000000018BF42530
		public bool[,] GetHoles(int xBase, int yBase, int width, int height) => default; // 0x000000018BF42008-0x000000018BF420F0
		private bool[,] Internal_GetHoles(int xBase, int yBase, int width, int height) => default; // 0x000000018BF4232C-0x000000018BF4238C
		public Vector3 GetInterpolatedNormal(float x, float y) => default; // 0x000000018BF421A8-0x000000018BF421D8
		public void SetDetailResolution(int detailResolution, int resolutionPerPatch) {} // 0x000000018BF42780-0x000000018BF42A64
		private void Internal_SetDetailResolution(int patchCount, int resolutionPerPatch) {} // 0x000000018BF42480-0x000000018BF424D0
		public void RefreshPrototypes() {} // 0x000000018BF42564-0x000000018BF42598
		public int[] GetSupportedLayers(int xBase, int yBase, int totalWidth, int totalHeight) => default; // 0x000000018BF421D8-0x000000018BF42238
		public int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer) => default; // 0x000000018BF41E8C-0x000000018BF41EEC
		public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details) {} // 0x000000018BF426F0-0x000000018BF42780
		private void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data) {} // 0x000000018BF42420-0x000000018BF42480
		private TreeInstance[] Internal_GetTreeInstances() => default; // 0x000000018BF4238C-0x000000018BF423C0
		public void SetTreeInstances(TreeInstance[] instances, bool snapToHeightmap) {} // 0x000000018BF42CF0-0x000000018BF42D44
		public float[,,] GetAlphamaps(int x, int y, int width, int height) => default; // 0x000000018BF41D9C-0x000000018BF41E24
		private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height) => default; // 0x000000018BF4226C-0x000000018BF422CC
		internal float GetAlphamapResolutionInternal() => default; // 0x000000018BF41D28-0x000000018BF41D5C
		public void SetAlphamaps(int x, int y, float[,,] map) {} // 0x000000018BF42598-0x000000018BF426F0
		private void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map) {} // 0x000000018BF423C0-0x000000018BF42420
		public Texture2D GetAlphamapTexture(int index) => default; // 0x000000018BF41D5C-0x000000018BF41D9C
		private void get_size_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BF43218-0x000000018BF4325C
		private void set_size_Injected(ref Vector3 value) {} // 0x000000018BF43750-0x000000018BF43794
		private void GetInterpolatedNormal_Injected(float x, float y, out Vector3 ret) {
			ret = default;
		} // 0x000000018BF42144-0x000000018BF421A8
	}

	public sealed class TerrainLayer : UnityEngine.Object // TypeDefIndex: 60326
	{
		// Properties
		public Texture2D diffuseTexture { get => default; set {} } // 0x000000018BF43990-0x000000018BF439C4 0x000000018BF43D98-0x000000018BF43DDC
		public Texture2D normalMapTexture { get => default; set {} } // 0x000000018BF43B0C-0x000000018BF43B40 0x000000018BF43F14-0x000000018BF43F58
		public Texture2D maskMapTexture { get => default; set {} } // 0x000000018BF43AA4-0x000000018BF43AD8 0x000000018BF43E8C-0x000000018BF43ED0
		public Vector2 tileSize { get => default; set {} } // 0x000000018BF43CC4-0x000000018BF43CE8 0x000000018BF440DC-0x000000018BF440F8
		public Vector2 tileOffset { get => default; set {} } // 0x000000018BF43C5C-0x000000018BF43C80 0x000000018BF4407C-0x000000018BF44098
		public UnityEngine.Color specular { get => default; set {} } // 0x000000018BF43BEC-0x000000018BF43C18 0x000000018BF44024-0x000000018BF44038
		public float metallic { get => default; set {} } // 0x000000018BF43AD8-0x000000018BF43B0C 0x000000018BF43ED0-0x000000018BF43F14
		public float smoothness { get => default; set {} } // 0x000000018BF43B74-0x000000018BF43BA8 0x000000018BF43F9C-0x000000018BF43FE0
		public float normalScale { get => default; set {} } // 0x000000018BF43B40-0x000000018BF43B74 0x000000018BF43F58-0x000000018BF43F9C
		public Vector4 diffuseRemapMin { get => default; set {} } // 0x000000018BF43964-0x000000018BF43990 0x000000018BF43D84-0x000000018BF43D98
		public Vector4 diffuseRemapMax { get => default; set {} } // 0x000000018BF438F4-0x000000018BF43920 0x000000018BF43D2C-0x000000018BF43D40
		public Vector4 maskMapRemapMin { get => default; set {} } // 0x000000018BF43A78-0x000000018BF43AA4 0x000000018BF43E78-0x000000018BF43E8C
		public Vector4 maskMapRemapMax { get => default; set {} } // 0x000000018BF43A08-0x000000018BF43A34 0x000000018BF43E20-0x000000018BF43E34
	
		// Constructors
		public TerrainLayer() {} // 0x000000018BF43864-0x000000018BF438B0
	
		// Methods
		private static void Internal_Create(TerrainLayer layer) {} // 0x000000018BF43830-0x000000018BF43864
		private void get_tileSize_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BF43C80-0x000000018BF43CC4
		private void set_tileSize_Injected(ref Vector2 value) {} // 0x000000018BF44098-0x000000018BF440DC
		private void get_tileOffset_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BF43C18-0x000000018BF43C5C
		private void set_tileOffset_Injected(ref Vector2 value) {} // 0x000000018BF44038-0x000000018BF4407C
		private void get_specular_Injected(out UnityEngine.Color ret) {
			ret = default;
		} // 0x000000018BF43BA8-0x000000018BF43BEC
		private void set_specular_Injected(ref UnityEngine.Color value) {} // 0x000000018BF43FE0-0x000000018BF44024
		private void get_diffuseRemapMin_Injected(out Vector4 ret) {
			ret = default;
		} // 0x000000018BF43920-0x000000018BF43964
		private void set_diffuseRemapMin_Injected(ref Vector4 value) {} // 0x000000018BF43D40-0x000000018BF43D84
		private void get_diffuseRemapMax_Injected(out Vector4 ret) {
			ret = default;
		} // 0x000000018BF438B0-0x000000018BF438F4
		private void set_diffuseRemapMax_Injected(ref Vector4 value) {} // 0x000000018BF43CE8-0x000000018BF43D2C
		private void get_maskMapRemapMin_Injected(out Vector4 ret) {
			ret = default;
		} // 0x000000018BF43A34-0x000000018BF43A78
		private void set_maskMapRemapMin_Injected(ref Vector4 value) {} // 0x000000018BF43E34-0x000000018BF43E78
		private void get_maskMapRemapMax_Injected(out Vector4 ret) {
			ret = default;
		} // 0x000000018BF439C4-0x000000018BF43A08
		private void set_maskMapRemapMax_Injected(ref Vector4 value) {} // 0x000000018BF43DDC-0x000000018BF43E20
	}
}

namespace UnityEngine.TerrainUtils
{
	internal enum TerrainMapStatusCode // TypeDefIndex: 60327
	{
		OK = 0,
		Overlapping = 1,
		SizeMismatch = 4,
		EdgeAlignmentMismatch = 8
	}

	public struct TerrainTileCoord // TypeDefIndex: 60328
	{
		// Fields
		public readonly int tileX; // 0x00
		public readonly int tileZ; // 0x04
	
		// Constructors
		public TerrainTileCoord(int tileX, int tileZ) {
			this.tileX = default;
			this.tileZ = default;
		} // 0x000000018357CB90-0x000000018357CBA0
	}

	public class TerrainMap // TypeDefIndex: 60330
	{
		// Fields
		private Vector3 m_patchSize; // 0x10
		private TerrainMapStatusCode m_errorCode; // 0x1C
		private Dictionary<TerrainTileCoord, Terrain> m_terrainTiles; // 0x20
	
		// Properties
		public Dictionary<TerrainTileCoord, Terrain> terrainTiles { get => default; } // 0x000000018BF440F8-0x000000018BF44254 
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 60329
		{
			// Fields
			public int groupID; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x000000018BF446BC-0x000000018BF44738
	
			// Methods
			internal bool _CreateFromPlacement_b__0(Terrain x) => default; // 0x000000018BF44470-0x000000018BF446BC
		}
	
		// Constructors
		public TerrainMap() {} // 0x000000018BF44738-0x000000018BF44820
	
		// Methods
		public Terrain GetTerrain(int tileX, int tileZ) => default; // 0x000000018BF44254-0x000000018BF44470
		public static TerrainMap CreateFromPlacement(Terrain originTerrain, Predicate<Terrain> filter = null, bool fullValidation = true /* Metadata: 0x02082882 */) => default; // 0x00000001813B31A0-0x00000001813B31B0
		public static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, Predicate<Terrain> filter = null, bool fullValidation = true /* Metadata: 0x02082883 */) => default; // 0x000000018BF44EB4-0x000000018BF44F30
		private void AddTerrainInternal(int x, int z, Terrain terrain) {} // 0x000000018BF44820-0x000000018BF44D60
		private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) => default; // 0x000000018BF44D60-0x000000018BF44EB4
		private void ValidateTerrain(int tileX, int tileZ) {} // 0x0000000185492010-0x0000000185492020
		private TerrainMapStatusCode Validate() => default; // 0x000000018BF45BC8-0x000000018BF45BF8
	}

	public static class TerrainUtility // TypeDefIndex: 60333
	{
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 60331
		{
			// Fields
			public bool onlyAutoConnectedTerrains; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x000000018BF4554C-0x000000018BF45580
		}
	
		private sealed class __c__DisplayClass2_1 // TypeDefIndex: 60332
		{
			// Fields
			public Terrain t; // 0x10
			public __c__DisplayClass2_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass2_1() {} // 0x000000018BF45274-0x000000018BF452F4
	
			// Methods
			internal bool _CollectTerrains_b__0(Terrain x) => default; // 0x000000018BF452F4-0x000000018BF4554C
		}
	
		// Methods
		internal static bool ValidTerrainsExist() => default; // 0x000000018BF44F30-0x000000018BF45274
		internal static void ClearConnectivity() {} // 0x0000000185492010-0x0000000185492020
		internal static Dictionary<int, TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains = true /* Metadata: 0x02082884 */) => default; // 0x0000000185492010-0x0000000185492020
		public static void AutoConnect() {} // 0x000000018BF45B4C-0x000000018BF45BC8
	}
}
