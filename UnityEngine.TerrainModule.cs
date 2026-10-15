/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

// Image 90: UnityEngine.TerrainModule.dll - Assembly: UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90213-90233

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 90214
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 90215
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine
{
	[NativeHeader("Modules/Terrain/Public/Terrain.h")]
	[NativeHeader("TerrainScriptingClasses.h")]
	[NativeHeader("Runtime/Interfaces/ITerrainManager.h")]
	[StaticAccessor("GetITerrainManager()", StaticAccessorType.Arrow)]
	[UsedByNativeCode]
	public sealed class Terrain : UnityEngine.Behaviour // TypeDefIndex: 90216
	{
		// Properties
		public TerrainData terrainData { get; set; } // 0x000000018D55A288-0x000000018D55A2BC 0x000000018D55A4A8-0x000000018D55A4EC
		public float detailObjectDistance { set; } // 0x000000018D55A344-0x000000018D55A388
		public float detailObjectDensity { set; } // 0x000000018D55A300-0x000000018D55A344
		[NativeProperty("StaticLightmapIndexInt")]
		public int lightmapIndex { set; } // 0x000000018D55A3CC-0x000000018D55A40C
		[NativeProperty("StaticLightmapST")]
		public Vector4 lightmapScaleOffset { set; } // 0x000000018D55A450-0x000000018D55A464
		public Material materialTemplate { get; set; } // 0x000000018D55A254-0x000000018D55A288 0x000000018D55A464-0x000000018D55A4A8
		public bool allowAutoConnect { get; set; } // 0x000000018D55A1EC-0x000000018D55A220 0x000000018D55A2BC-0x000000018D55A300
		public int groupingID { get; } // 0x000000018D55A220-0x000000018D55A254 
		public bool drawInstanced { set; } // 0x000000018D55A388-0x000000018D55A3CC
		[NativeProperty("ActiveTerrainsScriptingArray")]
		public static Terrain[] activeTerrains { get; } // 0x000000018D55A1C0-0x000000018D55A1EC 
	
		// Constructors
		public Terrain(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom); // 0x000000018D55A15C-0x000000018D55A1C0
		public void Flush(); // 0x000000018D55A120-0x000000018D55A154
		public static void GetActiveTerrains(List<Terrain> terrainList); // 0x000000018D55A154-0x000000018D55A15C
		private static void Internal_FillActiveTerrainList([NotNull("ArgumentNullException")] object terrainList); // 0x00000001862458D0-0x0000000186245910
		private void set_lightmapScaleOffset_Injected(ref Vector4 value); // 0x000000018D55A40C-0x000000018D55A450
	}

	[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
	public static class TerrainCallbacks // TypeDefIndex: 90219
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static HeightmapChangedCallback heightmapChanged; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static TextureChangedCallback textureChanged; // 0x08
	
		// Nested types
		public delegate void HeightmapChangedCallback(Terrain terrain, RectInt heightRegion, bool synched); // TypeDefIndex: 90217; 0x0000000181256E30-0x0000000181256E60
	
		public delegate void TextureChangedCallback(Terrain terrain, string textureName, RectInt texelRegion, bool synched); // TypeDefIndex: 90218; 0x00000001812674E0-0x0000000181267520
	
		// Methods
		[RequiredByNativeCode]
		internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched); // 0x000000018D5564B0-0x000000018D556594
		[RequiredByNativeCode]
		internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched); // 0x000000018D556594-0x000000018D556680
	}

	[UsedByNativeCode]
	public sealed class TreePrototype // TypeDefIndex: 90220
	{
		// Fields
		internal GameObject m_Prefab; // 0x10
		internal float m_BendFactor; // 0x18
		internal int m_NavMeshLod; // 0x1C
	
		// Properties
		public GameObject prefab { get; set; } // 0x0000000187249840-0x0000000187249850 0x0000000184FD2410-0x0000000184FD2420
		public float bendFactor { get; set; } // 0x0000000184F6C3E0-0x0000000184F6C650 0x0000000187233060-0x0000000187233070
		public int navMeshLod { get; } // 0x0000000187249850-0x0000000187249860 
	
		// Constructors
		public TreePrototype(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D55A5AC-0x000000018D55A610
		public override int GetHashCode(); // 0x00000001872613A0-0x00000001872613B0
		private bool Equals(TreePrototype other); // 0x000000018D55A610-0x000000018D55A6D8
	}

	public enum DetailRenderMode // TypeDefIndex: 90221
	{
		GrassBillboard = 0,
		VertexLit = 1,
		Grass = 2
	}

	[NativeHeader("TerrainScriptingClasses.h")]
	[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
	[UsedByNativeCode]
	public sealed class DetailPrototype // TypeDefIndex: 90222
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
		public GameObject prototype { get; set; } // 0x0000000187249840-0x0000000187249850 0x0000000184FD2410-0x0000000184FD2420
		public Texture2D prototypeTexture { get; set; } // 0x0000000187244530-0x0000000187244540 0x0000000187835500-0x0000000187835510
		public float minWidth { get; set; } // 0x0000000187837380-0x0000000187837390 0x0000000187233120-0x0000000187233130
		public float maxWidth { get; set; } // 0x0000000187837370-0x0000000187837380 0x0000000187233130-0x0000000187233140
		public float minHeight { get; set; } // 0x0000000187837360-0x0000000187837370 0x000000018723F470-0x000000018723F480
		public float maxHeight { get; set; } // 0x00000001872621D0-0x00000001872621E0 0x000000018723F3C0-0x000000018723F3D0
		public float noiseSpread { get; set; } // 0x00000001872621E0-0x00000001872621F0 0x00000001872335A0-0x00000001872335B0
		public UnityEngine.Color healthyColor { get; set; } // 0x00000001872621C0-0x00000001872621D0 0x0000000187238F70-0x0000000187238F80
		public UnityEngine.Color dryColor { get; set; } // 0x0000000187261A00-0x0000000187261A10 0x0000000187234020-0x0000000187234030
		public DetailRenderMode renderMode { get; set; } // 0x00000001872621F0-0x0000000187262200 0x0000000187233630-0x0000000187233640
		public bool usePrototypeMesh { get; set; } // 0x000000018D5563B0-0x000000018D5563B8 0x000000018D5563D4-0x000000018D5563F0
		public bool useInstancing { set; } // 0x000000018D5563B8-0x000000018D5563D4
	
		// Constructors
		public DetailPrototype(); // 0x000000018D5561B8-0x000000018D556270
		public DetailPrototype(DetailPrototype other); // 0x000000018D556270-0x000000018D5563B0
		static DetailPrototype(); // 0x000000018D556160-0x000000018D5561B8
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D555F50-0x000000018D555FB4
		public override int GetHashCode(); // 0x00000001872613A0-0x00000001872613B0
		private bool Equals(DetailPrototype other); // 0x000000018D555FB4-0x000000018D556160
	}

	[UsedByNativeCode]
	public struct TreeInstance // TypeDefIndex: 90223
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

	[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
	[NativeHeader("TerrainScriptingClasses.h")]
	[UsedByNativeCode]
	public sealed class TerrainData : UnityEngine.Object // TypeDefIndex: 90225
	{
		// Fields
		private const string k_ScriptingInterfaceName = "TerrainDataScriptingInterface"; // Metadata: 0x0264ACB4
		private const string k_ScriptingInterfacePrefix = "TerrainDataScriptingInterface::"; // Metadata: 0x0264ACD2
		private const string k_HeightmapPrefix = "GetHeightmap()."; // Metadata: 0x0264ACF2
		private const string k_DetailDatabasePrefix = "GetDetailDatabase()."; // Metadata: 0x0264AD02
		private const string k_TreeDatabasePrefix = "GetTreeDatabase()."; // Metadata: 0x0264AD17
		private const string k_SplatDatabasePrefix = "GetSplatDatabase()."; // Metadata: 0x0264AD2A
		internal static readonly int k_MaximumResolution; // 0x00
		internal static readonly int k_MinimumDetailResolutionPerPatch; // 0x04
		internal static readonly int k_MaximumDetailResolutionPerPatch; // 0x08
		internal static readonly int k_MaximumDetailPatchCount; // 0x0C
		internal static readonly int k_MaximumDetailsPerRes; // 0x10
		internal static readonly int k_MinimumAlphamapResolution; // 0x14
		internal static readonly int k_MaximumAlphamapResolution; // 0x18
		internal static readonly int k_MinimumCliffIndexMapResolution; // 0x1C
		internal static readonly int k_MaximumCliffIndexMapResolution; // 0x20
		internal static readonly int k_MinimumBaseMapResolution; // 0x24
		internal static readonly int k_MaximumBaseMapResolution; // 0x28
	
		// Properties
		public RenderTexture heightmapTexture { [NativeName("GetHeightmap().GetHeightmapTexture")] get; } // 0x000000018D557AF8-0x000000018D557B2C 
		public int heightmapResolution { get; set; } // 0x000000018D557AEC-0x000000018D557AF8 0x000000018D557F74-0x000000018D55809C
		private int internalHeightmapResolution { [NativeName("GetHeightmap().GetResolution")] get; [NativeName("GetHeightmap().SetResolution")] set; } // 0x000000018D557B70-0x000000018D557BA4 0x000000018D55809C-0x000000018D5580DC
		public Texture holesTexture { get; } // 0x000000018D557B40-0x000000018D557B70 
		public bool enableHolesTextureCompression { [NativeName("GetHeightmap().GetEnableHolesTextureCompression")] get; [NativeName("GetHeightmap().SetEnableHolesTextureCompression")] set; } // 0x000000018D557AB8-0x000000018D557AEC 0x000000018D557F30-0x000000018D557F74
		public int holesResolution { get; } // 0x000000018D557B2C-0x000000018D557B40 
		public Vector3 size { [NativeName("GetHeightmap().GetSize")] get; [NativeName("GetHeightmap().SetSize")] set; } // 0x000000018D557BE8-0x000000018D557C14 0x000000018D558120-0x000000018D558134
		public int detailWidth { [NativeName("GetDetailDatabase().GetWidth")] get; } // 0x000000018D557A84-0x000000018D557AB8 
		public int detailHeight { [NativeName("GetDetailDatabase().GetHeight")] get; } // 0x000000018D5579B4-0x000000018D5579E8 
		public int detailResolution { [NativeName("GetDetailDatabase().GetResolution")] get; } // 0x000000018D557A50-0x000000018D557A84 
		public int detailResolutionPerPatch { [NativeName("GetDetailDatabase().GetResolutionPerPatch")] get; } // 0x000000018D557A1C-0x000000018D557A50 
		public DetailPrototype[] detailPrototypes { [FreeFunction("TerrainDataScriptingInterface::GetDetailPrototypes", HasExplicitThis = true)] get; [FreeFunction("TerrainDataScriptingInterface::SetDetailPrototypes", HasExplicitThis = true, ThrowsException = true)] set; } // 0x000000018D5579E8-0x000000018D557A1C 0x000000018D557EEC-0x000000018D557F30
		public TreeInstance[] treeInstances { get; } // 0x000000018D557C48-0x000000018D557C54 
		public TreePrototype[] treePrototypes { [FreeFunction("TerrainDataScriptingInterface::GetTreePrototypes", HasExplicitThis = true)] get; [FreeFunction("TerrainDataScriptingInterface::SetTreePrototypes", HasExplicitThis = true, ThrowsException = true)] set; } // 0x000000018D557C54-0x000000018D557C88 0x000000018D558178-0x000000018D5581BC
		public int alphamapLayers { [NativeName("GetSplatDatabase().GetSplatCount")] get; } // 0x000000018D5578B4-0x000000018D5578E8 
		public int alphamapResolution { get; set; } // 0x000000018D5578A8-0x000000018D5578B4 0x000000018D557CFC-0x000000018D557EEC
		private int Internal_alphamapResolution { [NativeName("GetSplatDatabase().GetAlphamapResolution")] get; [NativeName("GetSplatDatabase().SetAlphamapResolution")] set; } // 0x000000018D557840-0x000000018D557874 0x000000018D557CBC-0x000000018D557CFC
		public int alphamapWidth { get; } // 0x000000018D5578A8-0x000000018D5578B4 
		public int alphamapHeight { get; } // 0x000000018D5578A8-0x000000018D5578B4 
		public int baseMapResolution { get; } // 0x000000018D5579A8-0x000000018D5579B4 
		private int Internal_baseMapResolution { [NativeName("GetSplatDatabase().GetBaseMapResolution")] get; } // 0x000000018D557874-0x000000018D5578A8 
		public int alphamapTextureCount { [NativeName("GetSplatDatabase().GetAlphaTextureCount")] get; } // 0x000000018D5578E8-0x000000018D55791C 
		public Texture2D[] alphamapTextures { get; } // 0x000000018D55791C-0x000000018D5579A8 
		public TerrainLayer[] terrainLayers { [FreeFunction("TerrainDataScriptingInterface::GetTerrainLayers", HasExplicitThis = true)] get; [FreeFunction("TerrainDataScriptingInterface::SetTerrainLayers", HasExplicitThis = true)] set; } // 0x000000018D557C14-0x000000018D557C48 0x000000018D558134-0x000000018D558178
		internal Terrain[] users { get; } // 0x000000018D557C88-0x000000018D557CBC 
	
		// Nested types
		private enum BoundaryValueType // TypeDefIndex: 90224
		{
			MaxHeightmapRes = 0,
			MinDetailResPerPatch = 1,
			MaxDetailResPerPatch = 2,
			MaxDetailPatchCount = 3,
			MaxDetailsPerRes = 4,
			MinAlphamapRes = 5,
			MaxAlphamapRes = 6,
			MinCliffIndexMapRes = 7,
			MaxCliffIndexMapRes = 8,
			MinBaseMapRes = 9,
			MaxBaseMapRes = 10
		}
	
		// Constructors
		public TerrainData(); // 0x000000018D5577E8-0x000000018D557840
		static TerrainData(); // 0x000000018D557698-0x000000018D5577E8
	
		// Methods
		[StaticAccessor("TerrainDataScriptingInterface", StaticAccessorType.DoubleColon)]
		[ThreadSafe]
		private static int GetBoundaryValue(BoundaryValueType type); // 0x000000018D556778-0x000000018D5567AC
		[FreeFunction("TerrainDataScriptingInterface::Create")]
		private static void Internal_Create([Writable] TerrainData terrainData); // 0x000000018D556B88-0x000000018D556BBC
		[NativeName("GetHeightmap().IsHolesTextureCompressed")]
		internal bool IsHolesTextureCompressed(); // 0x000000018D556E80-0x000000018D556EB4
		[NativeName("GetHeightmap().GetHolesTexture")]
		internal RenderTexture GetHolesTexture(); // 0x000000018D556928-0x000000018D55695C
		[NativeName("GetHeightmap().GetCompressedHolesTexture")]
		internal Texture2D GetCompressedHolesTexture(); // 0x000000018D5567AC-0x000000018D5567E0
		[NativeName("GetHeightmap().GetInterpolatedHeight")]
		public float GetInterpolatedHeight(float x, float y); // 0x000000018D556A40-0x000000018D556A94
		public float[,] GetHeights(int xBase, int yBase, int width, int height); // 0x000000018D556840-0x000000018D556928
		[FreeFunction("TerrainDataScriptingInterface::GetHeights", HasExplicitThis = true)]
		private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height); // 0x000000018D556C1C-0x000000018D556C7C
		public void SetHeights(int xBase, int yBase, float[,] heights); // 0x000000018D5573B8-0x000000018D557644
		[FreeFunction("TerrainDataScriptingInterface::SetHeights", HasExplicitThis = true)]
		private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights); // 0x000000018D556E20-0x000000018D556E80
		public bool[,] GetHoles(int xBase, int yBase, int width, int height); // 0x000000018D55695C-0x000000018D556A40
		[FreeFunction("TerrainDataScriptingInterface::GetHoles", HasExplicitThis = true)]
		private bool[,] Internal_GetHoles(int xBase, int yBase, int width, int height); // 0x000000018D556C7C-0x000000018D556CDC
		[NativeName("GetHeightmap().GetInterpolatedNormal")]
		public Vector3 GetInterpolatedNormal(float x, float y); // 0x000000018D556AF8-0x000000018D556B28
		public void SetDetailResolution(int detailResolution, int resolutionPerPatch); // 0x000000018D5570D4-0x000000018D5573B8
		[NativeName("GetDetailDatabase().SetDetailResolution")]
		private void Internal_SetDetailResolution(int patchCount, int resolutionPerPatch); // 0x000000018D556DD0-0x000000018D556E20
		[FreeFunction("TerrainDataScriptingInterface::RefreshPrototypes", HasExplicitThis = true)]
		public void RefreshPrototypes(); // 0x000000018D556EB4-0x000000018D556EE8
		[FreeFunction("TerrainDataScriptingInterface::GetSupportedLayers", HasExplicitThis = true)]
		public int[] GetSupportedLayers(int xBase, int yBase, int totalWidth, int totalHeight); // 0x000000018D556B28-0x000000018D556B88
		[FreeFunction("TerrainDataScriptingInterface::GetDetailLayer", HasExplicitThis = true)]
		public int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer); // 0x000000018D5567E0-0x000000018D556840
		public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details); // 0x000000018D557044-0x000000018D5570D4
		[FreeFunction("TerrainDataScriptingInterface::SetDetailLayer", HasExplicitThis = true)]
		private void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data); // 0x000000018D556D70-0x000000018D556DD0
		[NativeName("GetTreeDatabase().GetInstances")]
		private TreeInstance[] Internal_GetTreeInstances(); // 0x000000018D556CDC-0x000000018D556D10
		[FreeFunction("TerrainDataScriptingInterface::SetTreeInstances", HasExplicitThis = true)]
		public void SetTreeInstances([NotNull("ArgumentNullException")] TreeInstance[] instances, bool snapToHeightmap); // 0x000000018D557644-0x000000018D557698
		public float[,,] GetAlphamaps(int x, int y, int width, int height); // 0x000000018D5566F4-0x000000018D556778
		[FreeFunction("TerrainDataScriptingInterface::GetAlphamaps", HasExplicitThis = true)]
		private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height); // 0x000000018D556BBC-0x000000018D556C1C
		[NativeName("GetSplatDatabase().GetAlphamapResolution")]
		[RequiredByNativeCode]
		internal float GetAlphamapResolutionInternal(); // 0x000000018D556680-0x000000018D5566B4
		public void SetAlphamaps(int x, int y, float[,,] map); // 0x000000018D556EE8-0x000000018D557044
		[FreeFunction("TerrainDataScriptingInterface::SetAlphamaps", HasExplicitThis = true)]
		private void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map); // 0x000000018D556D10-0x000000018D556D70
		[NativeName("GetSplatDatabase().GetAlphaTexture")]
		public Texture2D GetAlphamapTexture(int index); // 0x000000018D5566B4-0x000000018D5566F4
		private void get_size_Injected(out Vector3 ret); // 0x000000018D557BA4-0x000000018D557BE8
		private void set_size_Injected(ref Vector3 value); // 0x000000018D5580DC-0x000000018D558120
		private void GetInterpolatedNormal_Injected(float x, float y, out Vector3 ret); // 0x000000018D556A94-0x000000018D556AF8
	}

	[NativeHeader("Modules/Terrain/Public/TerrainLayerScriptingInterface.h")]
	[NativeHeader("TerrainScriptingClasses.h")]
	[UsedByNativeCode]
	public sealed class TerrainLayer : UnityEngine.Object // TypeDefIndex: 90226
	{
		// Properties
		public Texture2D diffuseTexture { get; set; } // 0x000000018D55831C-0x000000018D558350 0x000000018D558724-0x000000018D558768
		public Texture2D normalMapTexture { get; set; } // 0x000000018D558498-0x000000018D5584CC 0x000000018D5588A0-0x000000018D5588E4
		public Texture2D maskMapTexture { get; set; } // 0x000000018D558430-0x000000018D558464 0x000000018D558818-0x000000018D55885C
		public Vector2 tileSize { get; set; } // 0x000000018D558650-0x000000018D558674 0x000000018D558A68-0x000000018D558A84
		public Vector2 tileOffset { get; set; } // 0x000000018D5585E8-0x000000018D55860C 0x000000018D558A08-0x000000018D558A24
		[NativeProperty("SpecularColor")]
		public UnityEngine.Color specular { get; set; } // 0x000000018D558578-0x000000018D5585A4 0x000000018D5589B0-0x000000018D5589C4
		public float metallic { get; set; } // 0x000000018D558464-0x000000018D558498 0x000000018D55885C-0x000000018D5588A0
		public float smoothness { get; set; } // 0x000000018D558500-0x000000018D558534 0x000000018D558928-0x000000018D55896C
		public float normalScale { get; set; } // 0x000000018D5584CC-0x000000018D558500 0x000000018D5588E4-0x000000018D558928
		public Vector4 diffuseRemapMin { get; set; } // 0x000000018D5582F0-0x000000018D55831C 0x000000018D558710-0x000000018D558724
		public Vector4 diffuseRemapMax { get; set; } // 0x000000018D558280-0x000000018D5582AC 0x000000018D5586B8-0x000000018D5586CC
		public Vector4 maskMapRemapMin { get; set; } // 0x000000018D558404-0x000000018D558430 0x000000018D558804-0x000000018D558818
		public Vector4 maskMapRemapMax { get; set; } // 0x000000018D558394-0x000000018D5583C0 0x000000018D5587AC-0x000000018D5587C0
	
		// Constructors
		public TerrainLayer(); // 0x000000018D5581F0-0x000000018D55823C
	
		// Methods
		[FreeFunction("TerrainLayerScriptingInterface::Create")]
		private static void Internal_Create([Writable] TerrainLayer layer); // 0x000000018D5581BC-0x000000018D5581F0
		private void get_tileSize_Injected(out Vector2 ret); // 0x000000018D55860C-0x000000018D558650
		private void set_tileSize_Injected(ref Vector2 value); // 0x000000018D558A24-0x000000018D558A68
		private void get_tileOffset_Injected(out Vector2 ret); // 0x000000018D5585A4-0x000000018D5585E8
		private void set_tileOffset_Injected(ref Vector2 value); // 0x000000018D5589C4-0x000000018D558A08
		private void get_specular_Injected(out UnityEngine.Color ret); // 0x000000018D558534-0x000000018D558578
		private void set_specular_Injected(ref UnityEngine.Color value); // 0x000000018D55896C-0x000000018D5589B0
		private void get_diffuseRemapMin_Injected(out Vector4 ret); // 0x000000018D5582AC-0x000000018D5582F0
		private void set_diffuseRemapMin_Injected(ref Vector4 value); // 0x000000018D5586CC-0x000000018D558710
		private void get_diffuseRemapMax_Injected(out Vector4 ret); // 0x000000018D55823C-0x000000018D558280
		private void set_diffuseRemapMax_Injected(ref Vector4 value); // 0x000000018D558674-0x000000018D5586B8
		private void get_maskMapRemapMin_Injected(out Vector4 ret); // 0x000000018D5583C0-0x000000018D558404
		private void set_maskMapRemapMin_Injected(ref Vector4 value); // 0x000000018D5587C0-0x000000018D558804
		private void get_maskMapRemapMax_Injected(out Vector4 ret); // 0x000000018D558350-0x000000018D558394
		private void set_maskMapRemapMax_Injected(ref Vector4 value); // 0x000000018D558768-0x000000018D5587AC
	}
}

namespace UnityEngine.TerrainUtils
{
	internal enum TerrainMapStatusCode // TypeDefIndex: 90227
	{
		OK = 0,
		Overlapping = 1,
		SizeMismatch = 4,
		EdgeAlignmentMismatch = 8
	}

	[IsReadOnly]
	public struct TerrainTileCoord // TypeDefIndex: 90228
	{
		// Fields
		public readonly int tileX; // 0x00
		public readonly int tileZ; // 0x04
	
		// Constructors
		public TerrainTileCoord(int tileX, int tileZ); // 0x00000001827241A0-0x00000001827241B0
	}

	public class TerrainMap // TypeDefIndex: 90230
	{
		// Fields
		private Vector3 m_patchSize; // 0x10
		private TerrainMapStatusCode m_errorCode; // 0x1C
		private Dictionary<TerrainTileCoord, Terrain> m_terrainTiles; // 0x20
	
		// Properties
		public Dictionary<TerrainTileCoord, Terrain> terrainTiles { get; } // 0x000000018225E800-0x000000018225E810 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 90229
		{
			// Fields
			public int groupID; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _CreateFromPlacement_b__0(Terrain x); // 0x000000018D55A754-0x000000018D55A784
		}
	
		// Constructors
		public TerrainMap(); // 0x000000018D559A1C-0x000000018D559A98
	
		// Methods
		public Terrain GetTerrain(int tileX, int tileZ); // 0x000000018D55904C-0x000000018D5590CC
		public static TerrainMap CreateFromPlacement(Terrain originTerrain, Predicate<Terrain> filter = null, bool fullValidation = true /* Metadata: 0x0264AD4D */); // 0x000000018D558E00-0x000000018D55904C
		public static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, Predicate<Terrain> filter = null, bool fullValidation = true /* Metadata: 0x0264AD4E */); // 0x000000018D558BE0-0x000000018D558E00
		private void AddTerrainInternal(int x, int z, Terrain terrain); // 0x000000018D558A84-0x000000018D558BE0
		private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain); // 0x000000018D5590CC-0x000000018D5591B4
		private void ValidateTerrain(int tileX, int tileZ); // 0x000000018D5591B4-0x000000018D5598B8
		private TerrainMapStatusCode Validate(); // 0x000000018D5598B8-0x000000018D559A1C
	}

	[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
	public static class TerrainUtility // TypeDefIndex: 90233
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 90231
		{
			// Fields
			public bool onlyAutoConnectedTerrains; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_1 // TypeDefIndex: 90232
		{
			// Fields
			public Terrain t; // 0x10
			public __c__DisplayClass2_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass2_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _CollectTerrains_b__0(Terrain x); // 0x000000018D55A6D8-0x000000018D55A754
		}
	
		// Methods
		internal static bool ValidTerrainsExist(); // 0x000000018D55A0EC-0x000000018D55A120
		internal static void ClearConnectivity(); // 0x000000018D559DF4-0x000000018D559E88
		internal static Dictionary<int, TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains = true /* Metadata: 0x0264AD4F */); // 0x000000018D559E88-0x000000018D55A0EC
		[RequiredByNativeCode]
		public static void AutoConnect(); // 0x000000018D559A98-0x000000018D559DF4
	}
}
