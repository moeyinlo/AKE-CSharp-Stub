/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering;
using UnityEngine.InputSystem;
using UnityEngine.Jobs;
using UnityEngine.Profiling;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;
using UnityEngine.Rendering.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 30: Unity.RenderPipelines.Core.Runtime.dll - Assembly: Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 53285-53695
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.RenderPipelines.Core.Editor.Tests")]
[assembly: InternalsVisibleTo("Unity.RenderPipelines.Core.Editor")]
[assembly: InternalsVisibleTo("Unity.RenderPipelines.HighDefinition.Runtime")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[ExecuteAlways]
public class SceneRenderPipeline : MonoBehaviour // TypeDefIndex: 53288
{
	// Fields
	public RenderPipelineAsset renderPipelineAsset; // 0x18

	// Constructors
	public SceneRenderPipeline() {} // 0x000000018426FE60-0x000000018426FE68

	// Methods
	private void OnEnable() {} // 0x0000000189C98974-0x0000000189C98980
	private void OnValidate() {} // 0x0000000189C98974-0x0000000189C98980
}

namespace Beyond.Rendering
{
	public static class HGShaderQualitySettings // TypeDefIndex: 53290
	{
		// Fields
		public static ShaderQuality HgShaderLod; // 0x00
	
		// Nested types
		public enum ShaderQuality // TypeDefIndex: 53289
		{
			Low = 0,
			High = 1
		}
	
		// Constructors
		static HGShaderQualitySettings() {} // 0x0000000189C82120-0x0000000189C8215C
	}
}

namespace UnityEngine
{
	[AddComponentMenu("Rendering/Light Anchor")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class LightAnchor : MonoBehaviour // TypeDefIndex: 53293
	{
		// Fields
		private const float k_ArcRadius = 5f; // Metadata: 0x01FD4497
		private const float k_AxisLength = 10f; // Metadata: 0x01FD449B
		internal const float k_MaxDistance = 10000f; // Metadata: 0x01FD449F
		[Min(0f)]
		[SerializeField]
		private float m_Distance; // 0x18
		[SerializeField]
		private UpDirection m_FrameSpace; // 0x1C
		[SerializeField]
		private Transform m_AnchorPositionOverride; // 0x20
		[SerializeField]
		private Vector3 m_AnchorPositionOffset; // 0x28
		[SerializeField]
		private float m_Yaw; // 0x34
		[SerializeField]
		private float m_Pitch; // 0x38
		[SerializeField]
		private float m_Roll; // 0x3C
	
		// Properties
		public float yaw { get => default; set {} } // 0x0000000183D56CA0-0x0000000183D56CB0 0x0000000189C8364C-0x0000000189C8369C
		public float pitch { get => default; set {} } // 0x0000000183D51000-0x0000000183D51010 0x0000000189C835AC-0x0000000189C835FC
		public float roll { get => default; set {} } // 0x0000000183D4EC60-0x0000000183D4EC70 0x0000000189C835FC-0x0000000189C8364C
		public float distance { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000189C83588-0x0000000189C835AC
		public UpDirection frameSpace { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		public Vector3 anchorPosition { get => default; } // 0x0000000189C8340C-0x0000000189C83588 
		public Transform anchorPositionOverride { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public Vector3 anchorPositionOffset { get => default; set {} } // 0x0000000183D50E80-0x0000000183D50EA0 0x0000000183D50F50-0x0000000183D50F60
	
		// Nested types
		public enum UpDirection // TypeDefIndex: 53291
		{
			World = 0,
			Local = 1
		}
	
		private struct Axes // TypeDefIndex: 53292
		{
			// Fields
			public Vector3 up; // 0x00
			public Vector3 right; // 0x0C
			public Vector3 forward; // 0x18
		}
	
		// Constructors
		public LightAnchor() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public static float NormalizeAngleDegree(float angle) => default; // 0x0000000189C82A24-0x0000000189C82A6C
		public void SynchronizeOnTransform(Camera camera) {} // 0x0000000189C82BB4-0x0000000189C82FB0
		public void UpdateTransform(Camera camera, Vector3 anchor) {} // 0x0000000189C82FB0-0x0000000189C8308C
		private Axes GetWorldSpaceAxes(Camera camera, Vector3 anchor) => default; // 0x0000000189C822E8-0x0000000189C82A24
		private void Update() {} // 0x0000000189C83310-0x0000000189C8340C
		private void OnDrawGizmosSelected() {} // 0x0000000189C82A6C-0x0000000189C82BB4
		private void UpdateTransform(Vector3 up, Vector3 right, Vector3 forward, Vector3 anchor) {} // 0x0000000189C8308C-0x0000000189C83310
	}
}

namespace UnityEngine.Experimental.Rendering
{
	internal class ProbeBrickIndex // TypeDefIndex: 53301
	{
		// Fields
		internal const int kMaxSubdivisionLevels = 7; // Metadata: 0x01FD44A5
		internal const int kIndexChunkSize = 243; // Metadata: 0x01FD44A6
		private BitArray m_IndexChunks; // 0x10
		private int m_IndexInChunks; // 0x18
		private int m_NextFreeChunk; // 0x1C
		private ComputeBuffer m_PhysicalIndexBuffer; // 0x20
		private int[] m_PhysicalIndexBufferData; // 0x28
		private Vector3Int m_CenterRS; // 0x34
		private Dictionary<Vector3Int, List<VoxelMeta>> m_VoxelToBricks; // 0x40
		private Dictionary<ProbeReferenceVolume.RegId, BrickMeta> m_BricksToVoxels; // 0x48
		private bool m_NeedUpdateIndexComputeBuffer; // 0x50
	
		// Properties
		internal int estimatedVMemCost { get; private set; } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
	
		// Nested types
		[Serializable]
		[DebuggerDisplay("Brick [{position}, {subdivisionLevel}]")]
		public struct Brick : IEquatable<Brick> // TypeDefIndex: 53294
		{
			// Fields
			public Vector3Int position; // 0x00
			public int subdivisionLevel; // 0x0C
	
			// Constructors
			internal Brick(Vector3Int position, int subdivisionLevel) {
				this.position = default;
				this.subdivisionLevel = default;
			} // 0x0000000183D5DE00-0x0000000183D5DE20
	
			// Methods
			public bool Equals(Brick other) => default; // 0x0000000189C81F5C-0x0000000189C81FB0
		}
	
		[DebuggerDisplay("Brick [{brick.position}, {brick.subdivisionLevel}], {flattenedIdx}")]
		private struct ReservedBrick // TypeDefIndex: 53295
		{
			// Fields
			public Brick brick; // 0x00
			public int flattenedIdx; // 0x10
		}
	
		private struct VoxelMeta // TypeDefIndex: 53296
		{
			// Fields
			public ProbeReferenceVolume.RegId id; // 0x00
			public List<ushort> brickIndices; // 0x08
		}
	
		private struct BrickMeta // TypeDefIndex: 53297
		{
			// Fields
			public HashSet<Vector3Int> voxels; // 0x00
			public List<ReservedBrick> bricks; // 0x08
		}
	
		public struct CellIndexUpdateInfo // TypeDefIndex: 53298
		{
			// Fields
			public int firstChunkIndex; // 0x00
			public int numberOfChunks; // 0x04
			public int minSubdivInCell; // 0x08
			public Vector3Int minValidBrickIndexForCellAtMaxRes; // 0x0C
			public Vector3Int maxValidBrickIndexForCellAtMaxResPlusOne; // 0x18
			public Vector3Int cellPositionInBricksAtMaxRes; // 0x24
		}
	
		// Constructors
		public ProbeBrickIndex() {} // Dummy constructor
		internal ProbeBrickIndex(ProbeVolumeTextureMemoryBudget memoryBudget) {} // 0x0000000189C857A0-0x0000000189C8599C
	
		// Methods
		private int GetVoxelSubdivLevel() => default; // 0x0000000189C84694-0x0000000189C846E4
		private int SizeOfPhysicalIndexFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget) => default; // 0x0000000189C84D58-0x0000000189C84D84
		internal void UploadIndexData() {} // 0x0000000189C85770-0x0000000189C857A0
		internal void Clear() {} // 0x0000000189C843A8-0x0000000189C84450
		private void MapBrickToVoxels(Brick brick, HashSet<Vector3Int> voxels) {} // 0x0000000189C846E4-0x0000000189C848D4
		private void ClearVoxel(Vector3Int pos, CellIndexUpdateInfo cellInfo) {} // 0x0000000189C842A8-0x0000000189C843A8
		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr) {} // 0x0000000189C8465C-0x0000000189C84694
		internal void Cleanup() {} // 0x0000000189C84248-0x0000000189C842A8
		private int MergeIndex(int index, int size) => default; // 0x0000000183D83C90-0x0000000183D83CB0
		internal bool AssignIndexChunksToCell(ProbeReferenceVolume.Cell cell, int bricksCount, ref CellIndexUpdateInfo cellUpdateInfo) => default; // 0x0000000189C8412C-0x0000000189C84248
		public void AddBricks(ProbeReferenceVolume.RegId id, List<Brick> bricks, List<ProbeBrickPool.BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight, CellIndexUpdateInfo cellInfo) {} // 0x0000000189C8369C-0x0000000189C8412C
		public void RemoveBricks(ProbeReferenceVolume.RegId id, CellIndexUpdateInfo cellInfo) {} // 0x0000000189C848D4-0x0000000189C84D58
		private void UpdateIndexForVoxel(Vector3Int voxel, CellIndexUpdateInfo cellInfo) {} // 0x0000000189C84D84-0x0000000189C84FE4
		private void UpdatePhysicalIndex(Vector3Int brickMin, Vector3Int brickMax, int value, CellIndexUpdateInfo cellInfo) {} // 0x0000000189C85374-0x0000000189C85770
		private void ClipToIndexSpace(Vector3Int pos, int subdiv, out Vector3Int outMinpos, out Vector3Int outMaxpos, CellIndexUpdateInfo cellInfo) {
			outMinpos = default;
			outMaxpos = default;
		} // 0x0000000189C84450-0x0000000189C8465C
		private void UpdateIndexForVoxel(Vector3Int voxel, List<ReservedBrick> bricks, List<ushort> indices, CellIndexUpdateInfo cellInfo) {} // 0x0000000189C84FE4-0x0000000189C85374
	}

	internal class ProbeBrickPool // TypeDefIndex: 53304
	{
		// Fields
		internal const int kBrickCellCount = 3; // Metadata: 0x01FD44A8
		internal const int kBrickProbeCountPerDim = 4; // Metadata: 0x01FD44A9
		internal const int kBrickProbeCountTotal = 64; // Metadata: 0x01FD44AA
		private const int kMaxPoolWidth = 2048; // Metadata: 0x01FD44AC
		private int m_AllocationSize; // 0x14
		private ProbeVolumeTextureMemoryBudget m_MemoryBudget; // 0x18
		private DataLocation m_Pool; // 0x20
		private BrickChunkAlloc m_NextFreeChunk; // 0x68
		private Stack<BrickChunkAlloc> m_FreeList; // 0x78
		private ProbeVolumeSHBands m_SHBands; // 0x80
	
		// Properties
		internal int estimatedVMemCost { get; private set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
	
		// Nested types
		[DebuggerDisplay("Chunk ({x}, {y}, {z})")]
		public struct BrickChunkAlloc // TypeDefIndex: 53302
		{
			// Fields
			public int x; // 0x00
			public int y; // 0x04
			public int z; // 0x08
	
			// Methods
			internal int flattenIndex(int sx, int sy) => default; // 0x0000000183D83C70-0x0000000183D83C90
		}
	
		public struct DataLocation // TypeDefIndex: 53303
		{
			// Fields
			internal Texture3D TexL0_L1rx; // 0x00
			internal Texture3D TexL1_G_ry; // 0x08
			internal Texture3D TexL1_B_rz; // 0x10
			internal Texture3D TexL2_0; // 0x18
			internal Texture3D TexL2_1; // 0x20
			internal Texture3D TexL2_2; // 0x28
			internal Texture3D TexL2_3; // 0x30
			internal int width; // 0x38
			internal int height; // 0x3C
			internal int depth; // 0x40
	
			// Methods
			internal void Cleanup() {} // 0x0000000189C82030-0x0000000189C82120
		}
	
		// Constructors
		public ProbeBrickPool() {} // Dummy constructor
		internal ProbeBrickPool(int allocationSize, ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands) {} // 0x0000000189C86EEC-0x0000000189C87014
	
		// Methods
		internal void EnsureTextureValidity() {} // 0x0000000189C8606C-0x0000000189C86154
		internal int GetChunkSize() => default; // 0x0000000183D50CC0-0x0000000183D50CD0
		internal int GetChunkSizeInProbeCount() => default; // 0x0000000183D83CD0-0x0000000183D83CE0
		internal int GetPoolWidth() => default; // 0x0000000183D4EF00-0x0000000183D4EF10
		internal int GetPoolHeight() => default; // 0x0000000183D4EEF0-0x0000000183D4EF00
		internal Vector3Int GetPoolDimensions() => default; // 0x0000000183D83CE0-0x0000000183D83D00
		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr) {} // 0x0000000189C86A28-0x0000000189C86AB0
		internal void Clear() {} // 0x0000000189C85AE4-0x0000000189C85B34
		internal void Allocate(int numberOfBrickChunks, List<BrickChunkAlloc> outAllocations) {} // 0x0000000189C8599C-0x0000000189C85AD8
		internal void Deallocate(List<BrickChunkAlloc> allocations) {} // 0x0000000189C85F20-0x0000000189C8606C
		internal void Update(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, ProbeVolumeSHBands bands) {} // 0x0000000189C86B54-0x0000000189C86EEC
		private static Vector3Int ProbeCountToDataLocSize(int numProbes) => default; // 0x0000000189C86AB0-0x0000000189C86B10
		public static DataLocation CreateDataLocation(int numProbes, bool compressed, ProbeVolumeSHBands bands, out int allocatedBytes) {
			allocatedBytes = default;
			return default;
		} // 0x0000000189C85B34-0x0000000189C85F20
		private static void SetPixel(ref UnityEngine.Color[] data, int x, int y, int z, int dataLocWidth, int dataLocHeight, UnityEngine.Color value) {} // 0x0000000189C86B10-0x0000000189C86B54
		public static void FillDataLocation(ref DataLocation loc, SphericalHarmonicsL2[] shl2, ProbeVolumeSHBands bands) {} // 0x0000000189C86154-0x0000000189C86A28
		private void DerivePoolSizeFromBudget(int allocationSize, ProbeVolumeTextureMemoryBudget memoryBudget, out int width, out int height, out int depth) {
			width = default;
			height = default;
			depth = default;
		} // 0x0000000183D83CB0-0x0000000183D83CD0
		internal void Cleanup() {} // 0x0000000189C85AD8-0x0000000189C85AE4
	}

	internal class ProbeCellIndices // TypeDefIndex: 53306
	{
		// Fields
		private const int kUintPerEntry = 3; // Metadata: 0x01FD44AE
		private ComputeBuffer m_IndexOfIndicesBuffer; // 0x18
		private uint[] m_IndexOfIndicesData; // 0x20
		private Vector3Int m_CellCount; // 0x28
		private Vector3Int m_CellMin; // 0x34
		private int m_CellSizeInMinBricks; // 0x40
		private bool m_NeedUpdateComputeBuffer; // 0x44
	
		// Properties
		internal int estimatedVMemCost { get; private set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
	
		// Nested types
		internal struct IndexMetaData // TypeDefIndex: 53305
		{
			// Fields
			internal Vector3Int minLocalIdx; // 0x00
			internal Vector3Int maxLocalIdx; // 0x0C
			internal int firstChunkIndex; // 0x18
			internal int minSubdiv; // 0x1C
	
			// Methods
			internal void Pack(out uint[] vals) {
				vals = default;
			} // 0x0000000189C8215C-0x0000000189C822E8
		}
	
		// Constructors
		public ProbeCellIndices() {} // Dummy constructor
		internal ProbeCellIndices(Vector3Int cellMin, Vector3Int cellMax, int cellSizeInMinBricks) {} // 0x0000000189C872F8-0x0000000189C87438
	
		// Methods
		internal Vector3Int GetCellIndexDimension() => default; // 0x0000000183D50E80-0x0000000183D50EA0
		internal Vector3Int GetCellMinPosition() => default; // 0x0000000183D522E0-0x0000000183D52300
		private int GetFlatIndex(Vector3Int normalizedPos) => default; // 0x0000000183D83D00-0x0000000183D83D20
		internal int GetFlatIdxForCell(Vector3Int cellPosition) => default; // 0x0000000189C871E4-0x0000000189C87248
		internal void AddCell(int cellFlatIdx, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo) {} // 0x0000000189C87014-0x0000000189C87184
		internal void MarkCellAsUnloaded(int cellFlatIdx) {} // 0x0000000189C87280-0x0000000189C872C8
		internal void PushComputeData() {} // 0x0000000189C872C8-0x0000000189C872F8
		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr) {} // 0x0000000189C87248-0x0000000189C87280
		internal void Cleanup() {} // 0x0000000189C87184-0x0000000189C871E4
	}

	public struct ProbeVolumeSystemParameters // TypeDefIndex: 53307
	{
		// Fields
		public ProbeVolumeTextureMemoryBudget memoryBudget; // 0x00
		public Mesh probeDebugMesh; // 0x08
		public Shader probeDebugShader; // 0x10
		public ProbeVolumeSceneData sceneData; // 0x18
		public ProbeVolumeSHBands shBands; // 0x20
	}

	public struct ProbeVolumeShadingParameters // TypeDefIndex: 53308
	{
		// Fields
		public float normalBias; // 0x00
		public float viewBias; // 0x04
		public bool scaleBiasByMinDistanceBetweenProbes; // 0x08
		public float samplingNoise; // 0x0C
	}

	[Serializable]
	public enum ProbeVolumeTextureMemoryBudget // TypeDefIndex: 53309
	{
		MemoryBudgetLow = 512,
		MemoryBudgetMedium = 1024,
		MemoryBudgetHigh = 2048
	}

	[Serializable]
	public enum ProbeVolumeSHBands // TypeDefIndex: 53310
	{
		SphericalHarmonicsL1 = 1,
		SphericalHarmonicsL2 = 2
	}

	public class ProbeReferenceVolume // TypeDefIndex: 53322
	{
		// Fields
		private const int kProbeIndexPoolAllocationSize = 128; // Metadata: 0x01FD44B9
		private bool m_IsInitialized; // 0x10
		private int m_ID; // 0x14
		private RefVolTransform m_Transform; // 0x18
		private int m_MaxSubdivision; // 0x78
		private ProbeBrickPool m_Pool; // 0x80
		private ProbeBrickIndex m_Index; // 0x88
		private ProbeCellIndices m_CellIndices; // 0x90
		private List<ProbeBrickPool.BrickChunkAlloc> m_TmpSrcChunks; // 0x98
		private float[] m_PositionOffsets; // 0xA0
		private Dictionary<RegId, List<ProbeBrickPool.BrickChunkAlloc>> m_Registry; // 0xA8
		private Bounds m_CurrGlobalBounds; // 0xB0
		internal Dictionary<int, Cell> cells; // 0xC8
		private Dictionary<int, CellChunkInfo> m_ChunkInfo; // 0xD0
		internal ProbeVolumeSceneData sceneData; // 0xD8
		public Action<ExtraDataActionInput> retrieveExtraDataAction; // 0xE0
		private bool m_BricksLoaded; // 0xE8
		private Dictionary<Cell, RegId> m_CellToBricks; // 0xF0
		private Dictionary<RegId, ProbeBrickIndex.CellIndexUpdateInfo> m_BricksToCellUpdateInfo; // 0xF8
		private Dictionary<string, ProbeVolumeAsset> m_PendingAssetsToBeLoaded; // 0x100
		private Dictionary<string, ProbeVolumeAsset> m_PendingAssetsToBeUnloaded; // 0x108
		private Dictionary<string, ProbeVolumeAsset> m_ActiveAssets; // 0x110
		private List<CellSortInfo> m_CellsToBeLoaded; // 0x118
		private Dictionary<int, int> m_CellRefCounting; // 0x120
		private bool m_NeedLoadAsset; // 0x128
		private bool m_ProbeReferenceVolumeInit; // 0x129
		private bool m_EnabledBySRP; // 0x12A
		private InitInfo m_PendingInitInfo; // 0x12C
		private bool m_NeedsIndexRebuild; // 0x144
		private bool m_HasChangedIndex; // 0x145
		private int m_CBShaderID; // 0x148
		private int m_NumberOfCellsLoadedPerFrame; // 0x14C
		private ProbeVolumeTextureMemoryBudget m_MemoryBudget; // 0x150
		private ProbeVolumeSHBands m_SHBands; // 0x154
		internal bool clearAssetsOnVolumeClear; // 0x158
		private static ProbeReferenceVolume _instance; // 0x00
		private const int kProbesPerBatch = 1023; // Metadata: 0x01FD44BB
		private DebugUI.Widget[] m_DebugItems; // 0x170
		private Mesh m_DebugMesh; // 0x178
		private Material m_DebugMaterial; // 0x180
		private List<CellInstancedDebugProbes> m_CellDebugData; // 0x188
		private Plane[] m_DebugFrustumPlanes; // 0x190
		internal float dilationValidtyThreshold; // 0x198
		internal Dictionary<Volume, List<ProbeBrickIndex.Brick>> realtimeSubdivisionInfo; // 0x1A0
	
		// Properties
		internal bool isInitialized { get => default; } // 0x0000000183D83DB0-0x0000000183D83DC0 
		internal bool enabledBySRP { get => default; } // 0x0000000183D83DA0-0x0000000183D83DB0 
		public ProbeVolumeSHBands shBands { get => default; } // 0x0000000183D58C90-0x0000000183D58CA0 
		public ProbeVolumeTextureMemoryBudget memoryBudget { get => default; } // 0x0000000183D6D1F0-0x0000000183D6D200 
		public static ProbeReferenceVolume instance { get => default; } // 0x0000000189C8D440-0x0000000189C8D490 
		internal ProbeVolumeDebug debugDisplay { get; } // 0x0000000183D570E0-0x0000000183D570F0 
		public UnityEngine.Color[] subdivisionDebugColors { get; } // 0x0000000183D570F0-0x0000000183D57100 
	
		// Nested types
		[Serializable]
		internal class Cell // TypeDefIndex: 53311
		{
			// Fields
			public int index; // 0x10
			public Vector3Int position; // 0x14
			public List<ProbeBrickIndex.Brick> bricks; // 0x20
			public Vector3[] probePositions; // 0x28
			public SphericalHarmonicsL2[] sh; // 0x30
			public float[] validity; // 0x38
			public int minSubdiv; // 0x40
			[NonSerialized]
			public int flatIdxInCellIndices; // 0x44
			[NonSerialized]
			public bool loaded; // 0x48
	
			// Constructors
			public Cell() {} // 0x0000000183D58930-0x0000000183D58940
		}
	
		private class CellChunkInfo // TypeDefIndex: 53312
		{
			// Fields
			public List<ProbeBrickPool.BrickChunkAlloc> chunks; // 0x10
	
			// Constructors
			public CellChunkInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private class CellSortInfo : IComparable // TypeDefIndex: 53313
		{
			// Fields
			internal string sourceAsset; // 0x10
			internal Cell cell; // 0x18
			internal float distanceToCamera; // 0x20
			internal Vector3 position; // 0x24
	
			// Constructors
			public CellSortInfo() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public int CompareTo(object obj) => default; // 0x0000000189C81FB0-0x0000000189C82030
		}
	
		internal struct Volume : IEquatable<Volume> // TypeDefIndex: 53314
		{
			// Fields
			internal Vector3 corner; // 0x00
			internal Vector3 X; // 0x0C
			internal Vector3 Y; // 0x18
			internal Vector3 Z; // 0x24
			internal float maxSubdivisionMultiplier; // 0x30
			internal float minSubdivisionMultiplier; // 0x34
	
			// Constructors
			public Volume(Matrix4x4 trs, float maxSubdivision, float minSubdivision) {
				corner = default;
				X = default;
				Y = default;
				Z = default;
				maxSubdivisionMultiplier = default;
				minSubdivisionMultiplier = default;
			} // 0x0000000189C99660-0x0000000189C99A68
			public Volume(Vector3 corner, Vector3 X, Vector3 Y, Vector3 Z, float maxSubdivision = 1f /* Metadata: 0x01FD44BD */, float minSubdivision = 0f /* Metadata: 0x01FD44C1 */) {
				this.corner = default;
				this.X = default;
				this.Y = default;
				this.Z = default;
				maxSubdivisionMultiplier = default;
				minSubdivisionMultiplier = default;
			} // 0x0000000183D83E60-0x0000000183D83EC0
			public Volume(Volume copy) {
				corner = default;
				X = default;
				Y = default;
				Z = default;
				maxSubdivisionMultiplier = default;
				minSubdivisionMultiplier = default;
			} // 0x0000000183D83E10-0x0000000183D83E60
	
			// Methods
			public Bounds CalculateAABB() => default; // 0x0000000189C98D74-0x0000000189C99084
			public void CalculateCenterAndSize(out Vector3 center, out Vector3 size) {
				center = default;
				size = default;
			} // 0x0000000189C99084-0x0000000189C99204
			public void Transform(Matrix4x4 trs) {} // 0x0000000189C99574-0x0000000189C99660
			public override string ToString() => default; // 0x0000000189C993A8-0x0000000189C99574
			public bool Equals(Volume other) => default; // 0x0000000189C99204-0x0000000189C993A8
		}
	
		internal struct RefVolTransform // TypeDefIndex: 53315
		{
			// Fields
			public Matrix4x4 refSpaceToWS; // 0x00
			public Vector3 posWS; // 0x40
			public Quaternion rot; // 0x4C
			public float scale; // 0x5C
		}
	
		public struct RuntimeResources // TypeDefIndex: 53316
		{
			// Fields
			public ComputeBuffer index; // 0x00
			public ComputeBuffer cellIndices; // 0x08
			public Texture3D L0_L1rx; // 0x10
			public Texture3D L1_G_ry; // 0x18
			public Texture3D L1_B_rz; // 0x20
			public Texture3D L2_0; // 0x28
			public Texture3D L2_1; // 0x30
			public Texture3D L2_2; // 0x38
			public Texture3D L2_3; // 0x40
		}
	
		internal struct RegId // TypeDefIndex: 53317
		{
			// Fields
			internal int id; // 0x00
	
			// Methods
			public bool IsValid() => default; // 0x000000018426F724-0x000000018426F72C
			public void Invalidate() {} // 0x0000000183D5BBD0-0x0000000183D5BBE0
			public static bool operator ==(RegId lhs, RegId rhs) => default; // 0x0000000186505FF4-0x0000000186505FFC
			public static bool operator !=(RegId lhs, RegId rhs) => default; // 0x000000018950C868-0x000000018950C870
			public override bool Equals(object obj) => default; // 0x0000000189C90018-0x0000000189C900C4
			public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
		}
	
		public struct ExtraDataActionInput // TypeDefIndex: 53318
		{
		}
	
		private struct InitInfo // TypeDefIndex: 53319
		{
			// Fields
			public Vector3Int pendingMinCellPosition; // 0x00
			public Vector3Int pendingMaxCellPosition; // 0x0C
		}
	
		private class CellInstancedDebugProbes // TypeDefIndex: 53320
		{
			// Fields
			public List<Matrix4x4[]> probeBuffers; // 0x10
			public List<MaterialPropertyBlock> props; // 0x18
			public Hash128 cellHash; // 0x20
			public Vector3 cellPosition; // 0x30
	
			// Constructors
			public CellInstancedDebugProbes() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		private ProbeReferenceVolume() {} // 0x00000001837BA1B0-0x00000001837BA750
		static ProbeReferenceVolume() {} // 0x00000001837BA140-0x00000001837BA1B0
	
		// Methods
		private void InvalidateAllCellRefs() {} // 0x0000000189C8A520-0x0000000189C8A568
		public void SetNumberOfCellsLoadedPerFrame(int numberOfCells) {} // 0x0000000189C8CA90-0x0000000189C8CAA4
		public void Initialize([IsReadOnly] in ProbeVolumeSystemParameters parameters) {} // 0x0000000189C8A44C-0x0000000189C8A520
		public void SetEnableStateFromSRP(bool srpEnablesPV) {} // 0x0000000183D83D90-0x0000000183D83DA0
		internal void ForceSHBand(ProbeVolumeSHBands shBands) {} // 0x0000000189C898C4-0x0000000189C8991C
		public void Cleanup() {} // 0x0000000189C88628-0x0000000189C886A8
		public int GetVideoMemoryCost() => default; // 0x0000000189C89FE0-0x0000000189C8A030
		private void RemoveCell(Cell cell) {} // 0x0000000189C8C4F4-0x0000000189C8C75C
		private void AddCell(Cell cell, List<ProbeBrickPool.BrickChunkAlloc> chunks) {} // 0x0000000189C87948-0x0000000189C87AD8
		private bool CheckCompatibilityWithCollection(ProbeVolumeAsset asset, Dictionary<string, ProbeVolumeAsset> collection) => default; // 0x0000000189C883A8-0x0000000189C88560
		internal void AddPendingAssetLoading(ProbeVolumeAsset asset) {} // 0x0000000189C87AD8-0x0000000189C88274
		internal void AddPendingAssetRemoval(ProbeVolumeAsset asset) {} // 0x0000000189C88274-0x0000000189C88334
		internal void RemovePendingAsset(ProbeVolumeAsset asset) {} // 0x0000000189C8C75C-0x0000000189C8C9D0
		private void PerformPendingIndexChangeAndInit() {} // 0x0000000189C8ADDC-0x0000000189C8AE38
		internal void SetMinBrickAndMaxSubdiv(float minBrickSize, int maxSubdiv) {} // 0x0000000189C8CA20-0x0000000189C8CA90
		private void LoadAsset(ProbeVolumeAsset asset) {} // 0x0000000189C8A568-0x0000000189C8A7D0
		private void PerformPendingLoading() {} // 0x0000000189C8AE38-0x0000000189C8B1A4
		private void PerformPendingDeletion() {} // 0x0000000189C8AC34-0x0000000189C8ADDC
		private int GetNumberOfBricksAtSubdiv(Cell cell, out Vector3Int minValidLocalIdxAtMaxRes, out Vector3Int sizeOfValidIndicesAtMaxRes) {
			minValidLocalIdxAtMaxRes = default;
			sizeOfValidIndicesAtMaxRes = default;
			return default;
		} // 0x0000000189C89AD0-0x0000000189C89F18
		private bool GetCellIndexUpdate(Cell cell, out ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo) {
			cellUpdateInfo = default;
			return default;
		} // 0x0000000189C8991C-0x0000000189C89AA0
		private void LoadPendingCells(bool loadAll = false /* Metadata: 0x01FD44B7 */) {} // 0x0000000189C8A7D0-0x0000000189C8AC18
		public void PerformPendingOperations(bool loadAllCells = false /* Metadata: 0x01FD44B8 */) {} // 0x0000000189C8B1A4-0x0000000189C8B1E8
		private void InitProbeReferenceVolume(int allocationSize, ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands) {} // 0x0000000189C8A030-0x0000000189C8A27C
		public void SortPendingCells(Vector3 cameraPosition) {} // 0x0000000189C8CDC0-0x0000000189C8CEE4
		public RuntimeResources GetRuntimeResources() => default; // 0x0000000189C89F18-0x0000000189C89FE0
		internal void SetTRS(Vector3 position, Quaternion rotation, float minBrickSize) {} // 0x0000000189C8CAA4-0x0000000189C8CB74
		internal void SetMaxSubdivision(int maxSubdivision) {} // 0x0000000189C8C9D0-0x0000000189C8CA20
		internal static int CellSize(int subdivisionLevel) => default; // 0x0000000183D83D60-0x0000000183D83D90
		internal float BrickSize(int subdivisionLevel) => default; // 0x0000000189C88334-0x0000000189C883A8
		internal float MinBrickSize() => default; // 0x0000000183D56C30-0x0000000183D56C40
		internal float MaxBrickSize() => default; // 0x0000000189C8AC18-0x0000000189C8AC28
		internal Matrix4x4 GetRefSpaceToWS() => default; // 0x0000000183D58F00-0x0000000183D58F30
		internal RefVolTransform GetTransform() => default; // 0x0000000183D626A0-0x0000000183D626E0
		internal int GetMaxSubdivision() => default; // 0x0000000183D4EC40-0x0000000183D4EC50
		internal int GetMaxSubdivision(float multiplier) => default; // 0x0000000189C89ABC-0x0000000189C89AD0
		internal float GetDistanceBetweenProbes(int subdivisionLevel) => default; // 0x0000000189C89AA0-0x0000000189C89ABC
		internal float MinDistanceBetweenProbes() => default; // 0x0000000189C8AC28-0x0000000189C8AC34
		public bool DataHasBeenLoaded() => default; // 0x0000000183D554A0-0x0000000183D554B0
		internal void Clear() {} // 0x0000000189C88714-0x0000000189C887FC
		private RegId AddBricks(List<ProbeBrickIndex.Brick> bricks, ProbeBrickPool.DataLocation dataloc, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, out List<ProbeBrickPool.BrickChunkAlloc> ch_list) {
			ch_list = default;
			return default;
		} // 0x0000000189C875C8-0x0000000189C87948
		private void ReleaseBricks(RegId id) {} // 0x0000000189C8C340-0x0000000189C8C4F4
		public void UpdateConstantBuffer(CommandBuffer cmd, ProbeVolumeShadingParameters parameters) {} // 0x0000000189C8D23C-0x0000000189C8D440
		private void CleanupLoadedData() {} // 0x0000000189C885B4-0x0000000189C88628
		public void RenderDebug(Camera camera) {} // 0x00000001825B1100-0x00000001825B1170
		private void InitializeDebug(Mesh debugProbeMesh, Shader debugProbeShader) {} // 0x0000000189C8A27C-0x0000000189C8A44C
		private void CleanupDebug() {} // 0x0000000189C88560-0x0000000189C885B4
		private void RefreshDebug<T>(DebugUI.Field<T> field, T value) {}
		private void DebugCellIndexChanged<T>(DebugUI.Field<T> field, T value) {}
		private void RegisterDebug() {} // 0x0000000189C8B1E8-0x0000000189C8C340
		private void UnregisterDebug(bool destroyPanel) {} // 0x0000000189C8D170-0x0000000189C8D23C
		private bool ShouldCullCell(Vector3 cellPosition, Transform cameraTransform, Plane[] frustumPlanes) => default; // 0x0000000189C8CB74-0x0000000189C8CDC0
		private void DrawProbeDebug(Camera camera) {} // 0x0000000189C8938C-0x0000000189C898C4
		private void ClearDebugData() {} // 0x0000000189C886A8-0x0000000189C88714
		private void CreateInstancedProbes() {} // 0x0000000189C887FC-0x0000000189C8938C
		private void OnClearLightingdata() {} // 0x000000018645F904-0x000000018645F90C
	}

	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "F:\\Build\\Release_v1d2\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\Lighting\\ProbeVolume\\ProbeReferenceVolume.Debug.cs")]
	public enum DebugProbeShadingMode // TypeDefIndex: 53323
	{
		SH = 0,
		Validity = 1,
		ValidityOverDilationThreshold = 2,
		Size = 3
	}

	internal class ProbeVolumeDebug // TypeDefIndex: 53324
	{
		// Fields
		public bool drawProbes; // 0x10
		public bool drawBricks; // 0x11
		public bool drawCells; // 0x12
		public bool realtimeSubdivision; // 0x13
		public int subdivisionCellUpdatePerFrame; // 0x14
		public float subdivisionDelayInSeconds; // 0x18
		public DebugProbeShadingMode probeShading; // 0x1C
		public float probeSize; // 0x20
		public float subdivisionViewCullingDistance; // 0x24
		public float probeCullingDistance; // 0x28
		public int maxSubdivToVisualize; // 0x2C
		public float exposureCompensation; // 0x30
	
		// Constructors
		public ProbeVolumeDebug() {} // 0x0000000183D83DD0-0x0000000183D83E00
	}

	public sealed class ProbeReferenceVolumeProfile : ScriptableObject // TypeDefIndex: 53326
	{
		// Fields
		[SerializeField]
		private Version version; // 0x18
		[Range(2f, 5f)]
		public int simplificationLevels; // 0x1C
		[Min(0.1f)]
		public float minDistanceBetweenProbes; // 0x20
	
		// Properties
		public int cellSizeInBricks { get => default; } // 0x0000000183D83D20-0x0000000183D83D50 
		public int maxSubdivision { get => default; } // 0x0000000183D83D50-0x0000000183D83D60 
		public float minBrickSize { get => default; } // 0x0000000189C875AC-0x0000000189C875C8 
		public float cellSizeInMeters { get => default; } // 0x0000000189C87560-0x0000000189C875AC 
	
		// Nested types
		internal enum Version // TypeDefIndex: 53325
		{
			Initial = 0
		}
	
		// Constructors
		public ProbeReferenceVolumeProfile() {} // 0x0000000189C874F4-0x0000000189C87560
	
		// Methods
		private void OnEnable() {} // 0x0000000189C874A0-0x0000000189C874F4
		public bool IsEquivalent(ProbeReferenceVolumeProfile otherProfile) => default; // 0x0000000189C87438-0x0000000189C874A0
	}

	[AddComponentMenu("Light/Probe Volume (Experimental)")]
	[ExecuteAlways]
	public class ProbeVolume : MonoBehaviour // TypeDefIndex: 53327
	{
		// Fields
		public bool globalVolume; // 0x18
		public Vector3 size; // 0x1C
		[HideInInspector]
		[Range(0f, 2f)]
		public float geometryDistanceOffset; // 0x28
		public LayerMask objectLayerMask; // 0x2C
		[HideInInspector]
		public int lowestSubdivLevelOverride; // 0x30
		[HideInInspector]
		public int highestSubdivLevelOverride; // 0x34
		[HideInInspector]
		public bool overridesSubdivLevels; // 0x38
		[SerializeField]
		internal bool mightNeedRebaking; // 0x39
		[SerializeField]
		internal Matrix4x4 cachedTransform; // 0x3C
		[SerializeField]
		internal int cachedHashCode; // 0x7C
	
		// Constructors
		public ProbeVolume() {} // 0x0000000189C8FFE4-0x0000000189C90018
	}

	[PreferBinarySerialization]
	internal class ProbeVolumeAsset : ScriptableObject // TypeDefIndex: 53329
	{
		// Fields
		[SerializeField]
		protected internal int m_Version; // 0x18
		[SerializeField]
		internal List<ProbeReferenceVolume.Cell> cells; // 0x20
		[SerializeField]
		internal Vector3Int maxCellPosition; // 0x28
		[SerializeField]
		internal Vector3Int minCellPosition; // 0x34
		[SerializeField]
		internal Bounds globalBounds; // 0x40
		[SerializeField]
		internal ProbeVolumeSHBands bands; // 0x58
		[SerializeField]
		private string m_AssetFullPath; // 0x60
		[SerializeField]
		internal int cellSizeInBricks; // 0x68
		[SerializeField]
		internal float minDistanceBetweenProbes; // 0x6C
		[SerializeField]
		internal int simplificationLevels; // 0x70
	
		// Properties
		[SerializeField]
		public int Version { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		internal int maxSubdivision { get => default; } // 0x0000000183D83DC0-0x0000000183D83DD0 
		internal float minBrickSize { get => default; } // 0x0000000189C8D598-0x0000000189C8D5B4 
	
		// Nested types
		[Serializable]
		internal enum AssetVersion // TypeDefIndex: 53328
		{
			First = 0,
			AddProbeVolumesAtlasEncodingModes = 1,
			PV2 = 2,
			ChunkBasedIndex = 3,
			Current = 3,
			Max = 4
		}
	
		// Constructors
		public ProbeVolumeAsset() {} // 0x0000000189C8D4F0-0x0000000189C8D598
	
		// Methods
		internal bool CompatibleWith(ProbeVolumeAsset otherAsset) => default; // 0x0000000189C8D490-0x0000000189C8D4F0
		public string GetSerializedFullPath() => default; // 0x0000000183D4EB00-0x0000000183D4EB10
	}

	[Serializable]
	internal struct ProbeDilationSettings // TypeDefIndex: 53330
	{
		// Fields
		public bool enableDilation; // 0x00
		public float dilationDistance; // 0x04
		public float dilationValidityThreshold; // 0x08
		public int dilationIterations; // 0x0C
		public bool squaredDistWeighting; // 0x10
	}

	[Serializable]
	internal struct VirtualOffsetSettings // TypeDefIndex: 53331
	{
		// Fields
		public bool useVirtualOffset; // 0x00
		public float outOfGeoOffset; // 0x04
		public float searchMultiplier; // 0x08
	}

	[Serializable]
	internal struct ProbeVolumeBakingProcessSettings // TypeDefIndex: 53332
	{
		// Fields
		public ProbeDilationSettings dilationSettings; // 0x00
		public VirtualOffsetSettings virtualOffsetSettings; // 0x14
	}

	internal enum ProbeVolumeState // TypeDefIndex: 53333
	{
		Default = 0,
		Invalid = 999
	}

	[AddComponentMenu("")]
	[ExecuteAlways]
	internal class ProbeVolumePerSceneData : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 53335
	{
		// Fields
		internal Dictionary<ProbeVolumeState, ProbeVolumeAsset> assets; // 0x18
		[SerializeField]
		private List<SerializableAssetItem> serializedAssets; // 0x20
		private ProbeVolumeState m_CurrentState; // 0x28
		private ProbeVolumeState m_PreviousState; // 0x2C
	
		// Nested types
		[Serializable]
		private struct SerializableAssetItem // TypeDefIndex: 53334
		{
			// Fields
			[SerializeField]
			public ProbeVolumeState state; // 0x00
			[SerializeField]
			public ProbeVolumeAsset asset; // 0x08
		}
	
		// Constructors
		public ProbeVolumePerSceneData() {} // 0x0000000189C8DF3C-0x0000000189C8DFC4
	
		// Methods
		public void OnAfterDeserialize() {} // 0x0000000189C8D7F0-0x0000000189C8D984
		public void OnBeforeSerialize() {} // 0x0000000189C8D984-0x0000000189C8DBB4
		internal void StoreAssetForState(ProbeVolumeState state, ProbeVolumeAsset asset) {} // 0x0000000189C8DDC4-0x0000000189C8DE28
		internal void InvalidateAllAssets() {} // 0x0000000189C8D62C-0x0000000189C8D7F0
		internal ProbeVolumeAsset GetCurrentStateAsset() => default; // 0x0000000189C8D5B4-0x0000000189C8D62C
		internal void QueueAssetLoading() {} // 0x0000000189C8DBC4-0x0000000189C8DCCC
		internal void QueueAssetRemoval() {} // 0x0000000189C8DCCC-0x0000000189C8DDC4
		private void OnEnable() {} // 0x0000000189C8DBBC-0x0000000189C8DBC4
		private void OnDisable() {} // 0x0000000189C8DBB4-0x0000000189C8DBBC
		private void OnDestroy() {} // 0x0000000189C8DBB4-0x0000000189C8DBBC
		private void Update() {} // 0x0000000189C8DE28-0x0000000189C8DF3C
	}

	[Serializable]
	public class ProbeVolumeSceneData : ISerializationCallbackReceiver // TypeDefIndex: 53342
	{
		// Fields
		private static PropertyInfo s_SceneGUID; // 0x00
		[SerializeField]
		private List<SerializableBoundItem> serializedBounds; // 0x10
		[SerializeField]
		private List<SerializableHasPVItem> serializedHasVolumes; // 0x18
		[SerializeField]
		private List<SerializablePVProfile> serializedProfiles; // 0x20
		[SerializeField]
		private List<SerializablePVBakeSettings> serializedBakeSettings; // 0x28
		[SerializeField]
		private List<BakingSet> serializedBakingSets; // 0x30
		internal UnityEngine.Object parentAsset; // 0x38
		internal string parentSceneDataPropertyName; // 0x40
		public Dictionary<string, Bounds> sceneBounds; // 0x48
		internal Dictionary<string, bool> hasProbeVolumes; // 0x50
		internal Dictionary<string, ProbeReferenceVolumeProfile> sceneProfiles; // 0x58
		internal Dictionary<string, ProbeVolumeBakingProcessSettings> sceneBakingSettings; // 0x60
		internal List<BakingSet> bakingSets; // 0x68
	
		// Nested types
		[Serializable]
		private struct SerializableBoundItem // TypeDefIndex: 53336
		{
			// Fields
			[SerializeField]
			public string sceneGUID; // 0x00
			[SerializeField]
			public Bounds bounds; // 0x08
		}
	
		[Serializable]
		private struct SerializableHasPVItem // TypeDefIndex: 53337
		{
			// Fields
			[SerializeField]
			public string sceneGUID; // 0x00
			[SerializeField]
			public bool hasProbeVolumes; // 0x08
		}
	
		[Serializable]
		private struct SerializablePVProfile // TypeDefIndex: 53338
		{
			// Fields
			[SerializeField]
			public string sceneGUID; // 0x00
			[SerializeField]
			public ProbeReferenceVolumeProfile profile; // 0x08
		}
	
		[Serializable]
		private struct SerializablePVBakeSettings // TypeDefIndex: 53339
		{
			// Fields
			[SerializeField]
			public string sceneGUID; // 0x00
			[SerializeField]
			public ProbeVolumeBakingProcessSettings settings; // 0x08
		}
	
		[Serializable]
		internal class BakingSet // TypeDefIndex: 53340
		{
			// Fields
			public string name; // 0x10
			public List<string> sceneGUIDs; // 0x18
			public ProbeVolumeBakingProcessSettings settings; // 0x20
			public ProbeReferenceVolumeProfile profile; // 0x40
	
			// Constructors
			public BakingSet() {} // 0x0000000189C81EE4-0x0000000189C81F5C
		}
	
		// Constructors
		public ProbeVolumeSceneData() {} // Dummy constructor
		public ProbeVolumeSceneData(UnityEngine.Object parentAsset, string parentSceneDataPropertyName) {} // 0x0000000189C8FCD8-0x0000000189C8FFE4
		static ProbeVolumeSceneData() {} // 0x0000000189C8FC28-0x0000000189C8FCD8
	
		// Methods
		private string GetSceneGUID(Scene scene) => default; // 0x0000000189C8E064-0x0000000189C8E128
		public void SetParentObject(UnityEngine.Object parent, string parentSceneDataPropertyName) {} // 0x0000000189C8F5BC-0x0000000189C8F5F0
		public void OnAfterDeserialize() {} // 0x0000000189C8E204-0x0000000189C8EA60
		private void UpdateBakingSets() {} // 0x0000000189C8F8AC-0x0000000189C8FC28
		public void OnBeforeSerialize() {} // 0x0000000189C8EA60-0x0000000189C8F5BC
		internal BakingSet CreateNewBakingSet(string name) => default; // 0x0000000189C8DFC4-0x0000000189C8E064
		private void InitializeBakingSet(BakingSet set, string name) {} // 0x0000000189C8E128-0x0000000189C8E204
		internal void SyncBakingSetSettings() {} // 0x0000000189C8F5F0-0x0000000189C8F8AC
	}

	[Obsolete("Use the updated RendererList API which is defined in the UnityEngine.Rendering.RendererUtils namespace.")]
	public struct RendererList // TypeDefIndex: 53343
	{
		// Fields
		private static readonly ShaderTagId s_EmptyName; // 0x00
		public static readonly RendererList nullRendererList; // 0x08
		public CullingResults cullingResult; // 0x08
		public DrawingSettings drawSettings; // 0x18
		public FilteringSettings filteringSettings; // 0x164
		public RenderStateBlock? stateBlock; // 0x184
	
		// Properties
		public bool isValid { [IsReadOnly] get; private set; } // 0x0000000183D51020-0x0000000183D51030 0x0000000183D4F9D0-0x0000000183D4F9E0
	
		// Constructors
		static RendererList() {
			s_EmptyName = default;
			nullRendererList = default;
		} // 0x0000000189C988F8-0x0000000189C98974
	
		// Methods
		public static RendererList Create([IsReadOnly] in UnityEngine.Experimental.Rendering.RendererListDesc desc) => default; // 0x0000000189C9835C-0x0000000189C988F8
	}

	[Obsolete("Use the updated RendererList API which is defined in the UnityEngine.Rendering.RendererUtils namespace.")]
	public struct RendererListDesc // TypeDefIndex: 53344
	{
		// Fields
		public SortingCriteria sortingCriteria; // 0x00
		public PerObjectData rendererConfiguration; // 0x04
		public RenderQueueRange renderQueueRange; // 0x08
		public RenderStateBlock? stateBlock; // 0x10
		public Material overrideMaterial; // 0x80
		public bool excludeObjectMotionVectors; // 0x88
		public int layerMask; // 0x8C
		public int overrideMaterialPassIndex; // 0x90
	
		// Properties
		internal CullingResults cullingResult { [IsReadOnly] get; private set; } // 0x0000000183D58680-0x0000000183D58690 0x0000000183D83E00-0x0000000183D83E10
		internal Camera camera { [IsReadOnly] get; set; } // 0x0000000183D4EB10-0x0000000183D4EB20 0x000000018554A7F4-0x000000018554A808
		internal ShaderTagId passName { [IsReadOnly] get; private set; } // 0x0000000183D59C80-0x0000000183D59C90 0x0000000183D59C90-0x0000000183D59CA0
		internal ShaderTagId[] passNames { [IsReadOnly] get; private set; } // 0x0000000183D4E750-0x0000000183D4E760 0x00000001858AAF64-0x00000001858AAF78
	
		// Constructors
		public RendererListDesc(ShaderTagId passName, CullingResults cullingResult, Camera camera) : this() {
			sortingCriteria = default;
			rendererConfiguration = default;
			renderQueueRange = default;
			stateBlock = default;
			overrideMaterial = default;
			excludeObjectMotionVectors = default;
			layerMask = default;
			overrideMaterialPassIndex = default;
		} // 0x0000000189C982DC-0x0000000189C9835C
		public RendererListDesc(ShaderTagId[] passNames, CullingResults cullingResult, Camera camera) : this() {
			sortingCriteria = default;
			rendererConfiguration = default;
			renderQueueRange = default;
			stateBlock = default;
			overrideMaterial = default;
			excludeObjectMotionVectors = default;
			layerMask = default;
			overrideMaterialPassIndex = default;
		} // 0x0000000189C98224-0x0000000189C982DC
	
		// Methods
		public bool IsValid() => default; // 0x0000000189C98184-0x0000000189C98224
	}
}

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	[Flags]
	public enum DepthAccess // TypeDefIndex: 53345
	{
		Read = 1,
		Write = 2,
		ReadWrite = 3
	}

	public class RenderGraphContext // TypeDefIndex: 53346
	{
		// Fields
		public ScriptableRenderContext renderContext; // 0x10
		public CommandBuffer cmd; // 0x18
		public RenderGraphObjectPool renderGraphPool; // 0x20
		public RenderGraphDefaultResources defaultResources; // 0x28
	
		// Constructors
		public RenderGraphContext() {} // 0x000000018350B670-0x000000018350B680
	}

	public struct RenderGraphParameters // TypeDefIndex: 53347
	{
		// Fields
		public string executionName; // 0x00
		public int currentFrameIndex; // 0x08
		public bool rendererListCulling; // 0x0C
		public ScriptableRenderContext scriptableRenderContext; // 0x10
		public CommandBuffer commandBuffer; // 0x18
	}

	public struct RenderGraphExecution : IDisposable // TypeDefIndex: 53348
	{
		// Fields
		private RenderGraph renderGraph; // 0x00
	
		// Constructors
		internal RenderGraphExecution(RenderGraph renderGraph) {
			this.renderGraph = default;
		} // 0x00000001842715A0-0x00000001842715A8
	
		// Methods
		public void Dispose() {} // 0x0000000189C90B38-0x0000000189C90B58
	}

	internal class RenderGraphDebugParams // TypeDefIndex: 53350
	{
		// Fields
		private DebugUI.Widget[] m_DebugItems; // 0x10
		private DebugUI.Panel m_DebugPanel; // 0x18
		public bool clearRenderTargetsAtCreation; // 0x20
		public bool clearRenderTargetsAtRelease; // 0x21
		public bool disablePassCulling; // 0x22
		public bool immediateMode; // 0x23
		public bool enableLogging; // 0x24
		public bool logFrameInformation; // 0x25
		public bool logResources; // 0x26
	
		// Nested types
		private static class Strings // TypeDefIndex: 53349
		{
			// Fields
			public static readonly DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtCreation; // 0x00
			public static readonly DebugUI.Widget.NameAndTooltip DisablePassCulling; // 0x10
			public static readonly DebugUI.Widget.NameAndTooltip ImmediateMode; // 0x20
			public static readonly DebugUI.Widget.NameAndTooltip EnableLogging; // 0x30
			public static readonly DebugUI.Widget.NameAndTooltip LogFrameInformation; // 0x40
			public static readonly DebugUI.Widget.NameAndTooltip LogResources; // 0x50
	
			// Constructors
			static Strings() {} // 0x0000000189C98980-0x0000000189C98C5C
		}
	
		// Constructors
		public RenderGraphDebugParams() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void RegisterDebug(string name, DebugUI.Panel debugPanel = null) {} // 0x0000000189C902A4-0x0000000189C90A10
		public void UnRegisterDebug(string name) {} // 0x0000000189C90AC8-0x0000000189C90B38
	}

	public delegate void RenderFunc<PassData>(PassData data, RenderGraphContext renderGraphContext); // TypeDefIndex: 53351; 0x00000000-0x00000000

	internal class RenderGraphDebugData // TypeDefIndex: 53354
	{
		// Fields
		public List<PassDebugData> passList; // 0x10
		public List<ResourceDebugData>[] resourceLists; // 0x18
	
		// Nested types
		[DebuggerDisplay("PassDebug: {name}")]
		public struct PassDebugData // TypeDefIndex: 53352
		{
			// Fields
			public string name; // 0x00
			public List<int>[] resourceReadLists; // 0x08
			public List<int>[] resourceWriteLists; // 0x10
			public bool culled; // 0x18
			public bool generateDebugData; // 0x19
		}
	
		[DebuggerDisplay("ResourceDebug: {name} [{creationPassIndex}:{releasePassIndex}]")]
		public struct ResourceDebugData // TypeDefIndex: 53353
		{
			// Fields
			public string name; // 0x00
			public bool imported; // 0x08
			public int creationPassIndex; // 0x0C
			public int releasePassIndex; // 0x10
			public List<int> consumerList; // 0x18
			public List<int> producerList; // 0x20
		}
	
		// Constructors
		public RenderGraphDebugData() {} // 0x0000000189C90204-0x0000000189C902A4
	
		// Methods
		public void Clear() {} // 0x0000000189C900C4-0x0000000189C90204
	}

	public class RenderGraph // TypeDefIndex: 53361
	{
		// Fields
		public static readonly int kMaxMRTCount; // 0x00
		private RenderGraphResourceRegistry m_Resources; // 0x10
		private RenderGraphObjectPool m_RenderGraphPool; // 0x18
		private List<RenderGraphPass> m_RenderPasses; // 0x20
		private List<RendererListHandle> m_RendererLists; // 0x28
		private RenderGraphDebugParams m_DebugParameters; // 0x30
		private RenderGraphLogger m_FrameInformationLogger; // 0x38
		private RenderGraphDefaultResources m_DefaultResources; // 0x40
		private Dictionary<int, ProfilingSampler> m_DefaultProfilingSamplers; // 0x48
		private bool m_ExecutionExceptionWasRaised; // 0x50
		private RenderGraphContext m_RenderGraphContext; // 0x58
		private CommandBuffer m_PreviousCommandBuffer; // 0x60
		private int m_CurrentImmediatePassIndex; // 0x68
		private List<int>[] m_ImmediateModeResourceList; // 0x70
		private DynamicArray<CompiledResourceInfo>[] m_CompiledResourcesInfos; // 0x78
		private DynamicArray<CompiledPassInfo> m_CompiledPassInfos; // 0x80
		private Stack<int> m_CullingStack; // 0x88
		private int m_ExecutionCount; // 0x90
		private int m_CurrentFrameIndex; // 0x94
		private bool m_HasRenderGraphBegun; // 0x98
		private string m_CurrentExecutionName; // 0xA0
		private bool m_RendererListCulling; // 0xA8
		private Dictionary<string, RenderGraphDebugData> m_DebugData; // 0xB0
		private static List<RenderGraph> s_RegisteredGraphs; // 0x08
	
		// Properties
		public string name { get; private set; } // 0x0000000183D4E750-0x0000000183D4E760 0x00000001858AAF64-0x00000001858AAF78
		internal static bool requireDebugData { get; set; } // 0x0000000189C97D90-0x0000000189C97DE0 0x0000000189C98130-0x0000000189C98184
		public RenderGraphDefaultResources defaultResources { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
	
		// Events
		internal static event OnGraphRegisteredDelegate onGraphRegistered;
		internal static event OnGraphRegisteredDelegate onGraphUnregistered;
		internal static event OnExecutionRegisteredDelegate onExecutionRegistered;
		internal static event OnExecutionRegisteredDelegate onExecutionUnregistered;
	
		// Nested types
		internal struct CompiledResourceInfo // TypeDefIndex: 53355
		{
			// Fields
			public List<int> producers; // 0x00
			public List<int> consumers; // 0x08
			public int refCount; // 0x10
			public bool imported; // 0x14
	
			// Methods
			public void Reset() {} // 0x0000000189C9A690-0x0000000189C9A778
		}
	
		[DebuggerDisplay("RenderPass: {pass.name} (Index:{pass.index} Async:{enableAsyncCompute})")]
		internal struct CompiledPassInfo // TypeDefIndex: 53356
		{
			// Fields
			public RenderGraphPass pass; // 0x00
			public List<int>[] resourceCreateList; // 0x08
			public List<int>[] resourceReleaseList; // 0x10
			public int refCount; // 0x18
			public bool culled; // 0x1C
			public bool hasSideEffect; // 0x1D
			public int syncToPassIndex; // 0x20
			public int syncFromPassIndex; // 0x24
			public bool needGraphicsFence; // 0x28
			public GraphicsFence fence; // 0x30
			public bool enableAsyncCompute; // 0x40
	
			// Properties
			public bool allowPassCulling { get => default; } // 0x0000000189C9A674-0x0000000189C9A690 
	
			// Methods
			public void Reset(RenderGraphPass pass) {} // 0x0000000189C9A48C-0x0000000189C9A674
		}
	
		private class ProfilingScopePassData // TypeDefIndex: 53357
		{
			// Fields
			public ProfilingSampler sampler; // 0x10
	
			// Constructors
			public ProfilingScopePassData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		internal delegate void OnGraphRegisteredDelegate(RenderGraph graph); // TypeDefIndex: 53358; 0x0000000182149960-0x0000000182149970
	
		internal delegate void OnExecutionRegisteredDelegate(RenderGraph graph, string executionName); // TypeDefIndex: 53359; 0x0000000182065C10-0x0000000182065C20
	
		// Constructors
		public RenderGraph() {} // Dummy constructor
		public RenderGraph(string name = "RenderGraph" /* Metadata: 0x01FD44D6 */) {} // 0x0000000189C9753C-0x0000000189C97A40
		static RenderGraph() {} // 0x0000000189C97484-0x0000000189C9753C
	
		// Methods
		public void Cleanup() {} // 0x0000000189C9116C-0x0000000189C91234
		public void RegisterDebug(DebugUI.Panel panel = null) {} // 0x0000000189C9656C-0x0000000189C9659C
		public void UnRegisterDebug() {} // 0x0000000189C968C4-0x0000000189C968F0
		public static List<RenderGraph> GetRegisteredRenderGraphs() => default; // 0x0000000189C94CE8-0x0000000189C94D38
		internal RenderGraphDebugData GetDebugData(string executionName) => default; // 0x0000000189C947E4-0x0000000189C94854
		public void EndFrame() {} // 0x0000000189C92DC0-0x0000000189C92E80
		public TextureHandle ImportTexture(RTHandle rt) => default; // 0x0000000189C94E18-0x0000000189C94E4C
		public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt) => default; // 0x0000000189C94D9C-0x0000000189C94DF8
		public TextureHandle CreateTexture([IsReadOnly] in TextureDesc desc) => default; // 0x0000000189C92644-0x0000000189C92684
		public TextureHandle CreateSharedTexture([IsReadOnly] in TextureDesc desc, bool explicitRelease = false /* Metadata: 0x01FD44E2 */) => default; // 0x0000000189C92528-0x0000000189C925B8
		public void ReleaseSharedTexture(TextureHandle texture) {} // 0x0000000189C96738-0x0000000189C967C0
		public TextureHandle CreateTexture(TextureHandle texture) => default; // 0x0000000189C92684-0x0000000189C92728
		public void CreateTextureIfInvalid([IsReadOnly] in TextureDesc desc, ref TextureHandle texture) {} // 0x0000000189C925B8-0x0000000189C92644
		public TextureDesc GetTextureDesc(TextureHandle texture) => default; // 0x0000000189C94D38-0x0000000189C94D9C
		public RendererListHandle CreateRendererList([IsReadOnly] in UnityEngine.Rendering.RendererUtils.RendererListDesc desc) => default; // 0x0000000189C92438-0x0000000189C92458
		public ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer) => default; // 0x0000000189C94DF8-0x0000000189C94E18
		public ComputeBufferHandle CreateComputeBuffer([IsReadOnly] in ComputeBufferDesc desc) => default; // 0x0000000189C92410-0x0000000189C92438
		public ComputeBufferHandle CreateComputeBuffer([IsReadOnly] in ComputeBufferHandle computeBuffer) => default; // 0x0000000189C923B8-0x0000000189C92410
		public ComputeBufferDesc GetComputeBufferDesc([IsReadOnly] in ComputeBufferHandle computeBuffer) => default; // 0x0000000189C947A4-0x0000000189C947E4
		public RenderGraphBuilder AddRenderPass<PassData>(string passName, out ref PassData passData, ProfilingSampler sampler)
			where PassData : class, new() {
			passData = default;
			return default;
		}
		public RenderGraphBuilder AddRenderPass<PassData>(string passName, out ref PassData passData)
			where PassData : class, new() {
			passData = default;
			return default;
		}
		public RenderGraphExecution RecordAndExecute([IsReadOnly] in RenderGraphParameters parameters) => default; // 0x0000000189C962B0-0x0000000189C9656C
		internal void Execute() {} // 0x0000000189C935BC-0x0000000189C937E4
		public void BeginProfilingSampler(ProfilingSampler sampler) {} // 0x0000000189C90D24-0x0000000189C90FB8
		public void EndProfilingSampler(ProfilingSampler sampler) {} // 0x0000000189C92E80-0x0000000189C93114
		internal DynamicArray<CompiledPassInfo> GetCompiledPassInfos() => default; // 0x0000000183D4EAE0-0x0000000183D4EAF0
		internal void ClearCompiledGraph() {} // 0x0000000189C91234-0x0000000189C91304
		private void InvalidateContext() {} // 0x0000000189C95060-0x0000000189C950B8
		internal void OnPassAdded(RenderGraphPass pass) {} // 0x0000000189C9589C-0x0000000189C958C8
		private void InitResourceInfosData(DynamicArray<CompiledResourceInfo> resourceInfos, int count) {} // 0x0000000189C94E4C-0x0000000189C94EEC
		private void InitializeCompilationData() {} // 0x0000000189C94EEC-0x0000000189C95060
		private void CountReferences() {} // 0x0000000189C91D64-0x0000000189C923B8
		private void CullUnusedPasses() {} // 0x0000000189C92820-0x0000000189C92DC0
		private void UpdatePassSynchronization(ref CompiledPassInfo currentPassInfo, ref CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex) {} // 0x0000000189C96A50-0x0000000189C96A70
		private void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, [IsReadOnly] in CompiledResourceInfo resource) {} // 0x0000000189C97364-0x0000000189C97484
		private int GetLatestProducerIndex(int passIndex, [IsReadOnly] in CompiledResourceInfo info) => default; // 0x0000000189C94A14-0x0000000189C94B48
		private int GetLatestValidReadIndex([IsReadOnly] in CompiledResourceInfo info) => default; // 0x0000000189C94B48-0x0000000189C94C18
		private int GetFirstValidWriteIndex([IsReadOnly] in CompiledResourceInfo info) => default; // 0x0000000189C94944-0x0000000189C94A14
		private int GetLatestValidWriteIndex([IsReadOnly] in CompiledResourceInfo info) => default; // 0x0000000189C94C18-0x0000000189C94CE8
		private void CreateRendererLists() {} // 0x0000000189C92458-0x0000000189C92528
		private void UpdateResourceAllocationAndSynchronization() {} // 0x0000000189C96A70-0x0000000189C97364
		private bool AreRendererListsEmpty(List<RendererListHandle> rendererLists) => default; // 0x0000000189C90B58-0x0000000189C90D24
		private void TryCullPassAtIndex(int passIndex) {} // 0x0000000189C967C0-0x0000000189C968C4
		private void CullRendererLists() {} // 0x0000000189C92728-0x0000000189C92820
		internal void CompileRenderGraph() {} // 0x0000000189C91C6C-0x0000000189C91D64
		private ref CompiledPassInfo CompilePassImmediatly(RenderGraphPass pass) => ref _refReturnTypeForCompilePassImmediatly; // 0x0000000189C9147C-0x0000000189C91C6C
		private ref CompiledPassInfo _refReturnTypeForCompilePassImmediatly; // Dummy field
		private void ExecutePassImmediatly(RenderGraphPass pass) {} // 0x0000000189C93488-0x0000000189C934B4
		private void ExecuteCompiledPass(ref CompiledPassInfo passInfo, int passIndex) {} // 0x0000000189C93114-0x0000000189C93488
		private void ExecuteRenderGraph() {} // 0x0000000189C934B4-0x0000000189C935BC
		private void PreRenderPassSetRenderTargets([IsReadOnly] in CompiledPassInfo passInfo, RenderGraphContext rgContext) {} // 0x0000000189C95EAC-0x0000000189C962B0
		private void PreRenderPassExecute([IsReadOnly] in CompiledPassInfo passInfo, RenderGraphContext rgContext) {} // 0x0000000189C95B6C-0x0000000189C95EAC
		private void PostRenderPassExecute(ref CompiledPassInfo passInfo, RenderGraphContext rgContext) {} // 0x0000000189C958C8-0x0000000189C95B6C
		private void ClearRenderPasses() {} // 0x0000000189C91304-0x0000000189C9147C
		private void ReleaseImmediateModeResources() {} // 0x0000000189C9659C-0x0000000189C96738
		private void LogFrameInformation() {} // 0x0000000189C9537C-0x0000000189C954F0
		private void LogRendererListsCreation() {} // 0x0000000189C957AC-0x0000000189C9589C
		private void LogRenderPassBegin([IsReadOnly] in CompiledPassInfo passInfo) {} // 0x0000000189C954F0-0x0000000189C957AC
		private void LogCulledPasses() {} // 0x0000000189C950B8-0x0000000189C9537C
		private ProfilingSampler GetDefaultProfilingSampler(string name) => default; // 0x0000000189C94854-0x0000000189C94944
		private void UpdateImportedResourceLifeTime(ref RenderGraphDebugData.ResourceDebugData data, List<int> passList) {} // 0x0000000189C968F0-0x0000000189C96A50
		private void GenerateDebugData() {} // 0x0000000189C937E4-0x0000000189C947A4
		private void CleanupDebugData() {} // 0x0000000189C90FB8-0x0000000189C9116C
	}

	public struct RenderGraphProfilingScope : IDisposable // TypeDefIndex: 53362
	{
		// Fields
		private bool m_Disposed; // 0x00
		private ProfilingSampler m_Sampler; // 0x08
		private RenderGraph m_RenderGraph; // 0x10
	
		// Constructors
		public RenderGraphProfilingScope(RenderGraph renderGraph, ProfilingSampler sampler) {
			m_Disposed = default;
			m_Sampler = default;
			m_RenderGraph = default;
		} // 0x0000000189CA5C68-0x0000000189CA5CB0
	
		// Methods
		public void Dispose() {} // 0x0000000189CA5C5C-0x0000000189CA5C68
		private void Dispose(bool disposing) {} // 0x0000000189CA5C24-0x0000000189CA5C5C
	}

	public struct RenderGraphBuilder : IDisposable // TypeDefIndex: 53363
	{
		// Fields
		private RenderGraphPass m_RenderPass; // 0x00
		private RenderGraphResourceRegistry m_Resources; // 0x08
		private RenderGraph m_RenderGraph; // 0x10
		private bool m_Disposed; // 0x18
	
		// Constructors
		internal RenderGraphBuilder(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph) {
			m_RenderPass = default;
			m_Resources = default;
			m_RenderGraph = default;
			m_Disposed = default;
		} // 0x00000001885AAC24-0x00000001885AAC5C
	
		// Methods
		public TextureHandle UseColorBuffer([IsReadOnly] in TextureHandle input, int index) => default; // 0x0000000189CA43F0-0x0000000189CA446C
		public TextureHandle UseDepthBuffer([IsReadOnly] in TextureHandle input, DepthAccess flags) => default; // 0x0000000189CA446C-0x0000000189CA4538
		public TextureHandle ReadTexture([IsReadOnly] in TextureHandle input) => default; // 0x0000000189CA41B0-0x0000000189CA437C
		public TextureHandle WriteTexture([IsReadOnly] in TextureHandle input) => default; // 0x0000000189CA4580-0x0000000189CA45E0
		public TextureHandle ReadWriteTexture([IsReadOnly] in TextureHandle input) => default; // 0x0000000189CA437C-0x0000000189CA43F0
		public TextureHandle CreateTransientTexture([IsReadOnly] in TextureDesc desc) => default; // 0x0000000189CA3FA8-0x0000000189CA4014
		public TextureHandle CreateTransientTexture([IsReadOnly] in TextureHandle texture) => default; // 0x0000000189CA4014-0x0000000189CA40E4
		public RendererListHandle UseRendererList([IsReadOnly] in RendererListHandle input) => default; // 0x0000000189CA40E4-0x0000000189CA4110
		public ComputeBufferHandle ReadComputeBuffer([IsReadOnly] in ComputeBufferHandle input) => default; // 0x0000000189CA4188-0x0000000189CA41B0
		public ComputeBufferHandle WriteComputeBuffer([IsReadOnly] in ComputeBufferHandle input) => default; // 0x0000000189CA4538-0x0000000189CA4580
		public ComputeBufferHandle CreateTransientComputeBuffer([IsReadOnly] in ComputeBufferDesc desc) => default; // 0x0000000189CA3F54-0x0000000189CA3FA8
		public ComputeBufferHandle CreateTransientComputeBuffer([IsReadOnly] in ComputeBufferHandle computebuffer) => default; // 0x0000000189CA3ED0-0x0000000189CA3F54
		public void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc)
			where PassData : class, new() {}
		public void EnableAsyncCompute(bool value) {} // 0x0000000189CA4150-0x0000000189CA416C
		public void AllowPassCulling(bool value) {} // 0x0000000189CA3E98-0x0000000189CA3EB4
		public void Dispose() {} // 0x0000000189CA4144-0x0000000189CA4150
		public void AllowRendererListCulling(bool value) {} // 0x0000000189CA3EB4-0x0000000189CA3ED0
		public RendererListHandle DependsOn([IsReadOnly] in RendererListHandle input) => default; // 0x0000000189CA40E4-0x0000000189CA4110
		private void Dispose(bool disposing) {} // 0x0000000189CA4110-0x0000000189CA4144
		private void CheckResource([IsReadOnly] in ResourceHandle res, bool dontCheckTransientReadWrite = false /* Metadata: 0x01FD44E3 */) {} // 0x000000018350B670-0x000000018350B680
		internal void GenerateDebugData(bool value) {} // 0x0000000189CA416C-0x0000000189CA4188
	}

	public class RenderGraphDefaultResources // TypeDefIndex: 53364
	{
		// Fields
		private bool m_IsValid; // 0x10
		private RTHandle m_BlackTexture2D; // 0x18
		private RTHandle m_WhiteTexture2D; // 0x20
		private RTHandle m_ShadowTexture2D; // 0x28
	
		// Properties
		public TextureHandle blackTexture { get; private set; } // 0x0000000183D4FD30-0x0000000183D4FD40 0x0000000183D4FD40-0x0000000183D4FD50
		public TextureHandle whiteTexture { get; private set; } // 0x0000000183D5A160-0x0000000183D5A170 0x0000000183D5D610-0x0000000183D5D620
		public TextureHandle clearTextureXR { get; private set; } // 0x0000000183D55950-0x0000000183D55960 0x0000000183D5A610-0x0000000183D5A620
		public TextureHandle magentaTextureXR { get; private set; } // 0x0000000183D5A130-0x0000000183D5A140 0x0000000183D6C120-0x0000000183D6C130
		public TextureHandle blackTextureXR { get; private set; } // 0x0000000183D5AAE0-0x0000000183D5AAF0 0x0000000183D6C100-0x0000000183D6C110
		public TextureHandle blackTextureArrayXR { get; private set; } // 0x0000000183D5AAF0-0x0000000183D5AB00 0x0000000183D68EB0-0x0000000183D68EC0
		public TextureHandle blackUIntTextureXR { get; private set; } // 0x0000000183D68BC0-0x0000000183D68BD0 0x0000000183D6C0C0-0x0000000183D6C0D0
		public TextureHandle blackTexture3DXR { get; private set; } // 0x0000000183D6C070-0x0000000183D6C080 0x0000000183D6C0F0-0x0000000183D6C100
		public TextureHandle whiteTextureXR { get; private set; } // 0x0000000183D6C040-0x0000000183D6C050 0x0000000183D6C0B0-0x0000000183D6C0C0
		public TextureHandle defaultShadowTexture { get; private set; } // 0x0000000183D6C030-0x0000000183D6C040 0x0000000183D6C0A0-0x0000000183D6C0B0
	
		// Constructors
		internal RenderGraphDefaultResources() {} // 0x0000000189CA47C0-0x0000000189CA48E4
	
		// Methods
		internal void Cleanup() {} // 0x0000000189CA45E0-0x0000000189CA4624
		internal void InitializeForRendering(RenderGraph renderGraph) {} // 0x0000000189CA4624-0x0000000189CA47C0
	}

	internal struct RenderGraphLogIndent : IDisposable // TypeDefIndex: 53365
	{
		// Fields
		private int m_Indentation; // 0x00
		private RenderGraphLogger m_Logger; // 0x08
		private bool m_Disposed; // 0x10
	
		// Constructors
		public RenderGraphLogIndent(RenderGraphLogger logger, int indentation = 1 /* Metadata: 0x01FD44E4 */) {
			m_Indentation = default;
			m_Logger = default;
			m_Disposed = default;
		} // 0x0000000189CA4924-0x0000000189CA4960
	
		// Methods
		public void Dispose() {} // 0x0000000189CA48E4-0x0000000189CA48F0
		private void Dispose(bool disposing) {} // 0x0000000189CA48F0-0x0000000189CA4924
	}

	internal class RenderGraphLogger // TypeDefIndex: 53366
	{
		// Fields
		private Dictionary<string, StringBuilder> m_LogMap; // 0x10
		private StringBuilder m_CurrentBuilder; // 0x18
		private int m_CurrentIndentation; // 0x20
	
		// Constructors
		public RenderGraphLogger() {} // 0x0000000189CA4DC4-0x0000000189CA4E3C
	
		// Methods
		public void Initialize(string logName) {} // 0x0000000189CA4C50-0x0000000189CA4D40
		public void IncrementIndentation(int value) {} // 0x0000000189CA4BF4-0x0000000189CA4C50
		public void DecrementIndentation(int value) {} // 0x0000000189CA4960-0x0000000189CA49CC
		public void LogLine(string format, params object[] args) {} // 0x0000000189CA4D40-0x0000000189CA4DC4
		public string GetLog(string logName) => default; // 0x0000000189CA4B64-0x0000000189CA4BF4
		public string GetAllLogs() => default; // 0x0000000189CA49CC-0x0000000189CA4B64
	}

	public sealed class RenderGraphObjectPool // TypeDefIndex: 53369
	{
		// Fields
		private Dictionary<ValueTuple<System.Type, int>, Stack<object>> m_ArrayPool; // 0x10
		private List<ValueTuple<object, ValueTuple<System.Type, int>>> m_AllocatedArrays; // 0x18
		private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks; // 0x20
	
		// Nested types
		private abstract class SharedObjectPoolBase // TypeDefIndex: 53367
		{
			// Fields
			protected static List<SharedObjectPoolBase> s_AllocatedPools; // 0x00
	
			// Constructors
			protected SharedObjectPoolBase() {} // 0x000000018350B670-0x000000018350B680
			static SharedObjectPoolBase() {} // 0x0000000189CA91B0-0x0000000189CA923C
	
			// Methods
			protected abstract void Clear();
			public static void ClearAll() {} // 0x0000000189CA907C-0x0000000189CA91B0
		}
	
		private class SharedObjectPool<T> : SharedObjectPoolBase // TypeDefIndex: 53368
			where T : new()
		{
			// Fields
			private Stack<T> m_Pool;
			private static readonly Lazy<SharedObjectPool<T>> s_Instance;
	
			// Properties
			public static SharedObjectPool<T> sharedPool { get => default; }
	
			// Constructors
			public SharedObjectPool() {}
			static SharedObjectPool() {}
	
			// Methods
			public T Get() => default;
			public void Release(T value) {}
			private static SharedObjectPool<T> AllocatePool() => default;
			protected override void Clear() {}
		}
	
		// Constructors
		internal RenderGraphObjectPool() {} // 0x0000000189CA531C-0x0000000189CA5428
	
		// Methods
		public T[] GetTempArray<T>(int size) => default;
		public MaterialPropertyBlock GetTempMaterialPropertyBlock() => default; // 0x0000000189CA4EE4-0x0000000189CA4FA0
		internal void ReleaseAllTempAlloc() {} // 0x0000000189CA4FA0-0x0000000189CA531C
		internal T Get<T>()
			where T : new() => default;
		internal void Release<T>(T value)
			where T : new() {}
		internal void Cleanup() {} // 0x0000000189CA4E3C-0x0000000189CA4EE4
	}

	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal abstract class RenderGraphPass // TypeDefIndex: 53370
	{
		// Fields
		public List<ResourceHandle>[] resourceReadLists; // 0x58
		public List<ResourceHandle>[] resourceWriteLists; // 0x60
		public List<ResourceHandle>[] transientResourceList; // 0x68
		public List<RendererListHandle> usedRendererListList; // 0x70
		public List<RendererListHandle> dependsOnRendererListList; // 0x78
	
		// Properties
		public string name { get; protected set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public int index { get; protected set; } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public ProfilingSampler customSampler { get; protected set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public bool enableAsyncCompute { get; protected set; } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
		public bool allowPassCulling { get; protected set; } // 0x0000000183D4F2A0-0x0000000183D4F2B0 0x0000000183D4F2B0-0x0000000183D4F2C0
		public TextureHandle depthBuffer { get; protected set; } // 0x0000000183D56F70-0x0000000183D56F80 0x0000000183D56F80-0x0000000183D56F90
		public TextureHandle[] colorBuffers { get; protected set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public int colorBufferMaxIndex { get; protected set; } // 0x0000000183D4EC50-0x0000000183D4EC60 0x0000000183D4ECD0-0x0000000183D4ECE0
		public int refCount { get; protected set; } // 0x0000000183D4EDF0-0x0000000183D4EE00 0x0000000183D4EE30-0x0000000183D4EE40
		public bool generateDebugData { get; protected set; } // 0x0000000183D4F000-0x0000000183D4F010 0x0000000183D4F030-0x0000000183D4F040
		public bool allowRendererListCulling { get; protected set; } // 0x0000000183D518F0-0x0000000183D51900 0x0000000183D51900-0x0000000183D51910
	
		// Constructors
		public RenderGraphPass() {} // 0x0000000189CA599C-0x0000000189CA5C24
	
		// Methods
		public RenderFunc<PassData> GetExecuteDelegate<PassData>()
			where PassData : class, new() => default;
		public abstract void Execute(RenderGraphContext renderGraphContext);
		public abstract void Release(RenderGraphObjectPool pool);
		public abstract bool HasRenderFunc();
		public void Clear() {} // 0x0000000189CA55F0-0x0000000189CA5804
		public void AddResourceWrite([IsReadOnly] in ResourceHandle res) {} // 0x0000000189CA54C0-0x0000000189CA5558
		public void AddResourceRead([IsReadOnly] in ResourceHandle res) {} // 0x0000000189CA5428-0x0000000189CA54C0
		public void AddTransientResource([IsReadOnly] in ResourceHandle res) {} // 0x0000000189CA5558-0x0000000189CA55F0
		public void UseRendererList(RendererListHandle rendererList) {} // 0x0000000189CA5948-0x0000000189CA599C
		public void DependsOnRendererList(RendererListHandle rendererList) {} // 0x0000000189CA5804-0x0000000189CA5858
		public void EnableAsyncCompute(bool value) {} // 0x0000000183D4ED60-0x0000000183D4ED70
		public void AllowPassCulling(bool value) {} // 0x0000000183D4F2B0-0x0000000183D4F2C0
		public void AllowRendererListCulling(bool value) {} // 0x0000000183D51900-0x0000000183D51910
		public void GenerateDebugData(bool value) {} // 0x0000000183D4F030-0x0000000183D4F040
		public void SetColorBuffer(TextureHandle resource, int index) {} // 0x0000000189CA5858-0x0000000189CA58F4
		public void SetDepthBuffer(TextureHandle resource, DepthAccess flags) {} // 0x0000000189CA58F4-0x0000000189CA5948
	}

	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal sealed class RenderGraphPass<PassData> : RenderGraphPass // TypeDefIndex: 53371
		where PassData : class, new()
	{
		// Fields
		internal PassData data;
		internal RenderFunc<PassData> renderFunc;
	
		// Constructors
		public RenderGraphPass() {}
	
		// Methods
		public override void Execute(RenderGraphContext renderGraphContext) {}
		public void Initialize(int passIndex, PassData passData, string passName, ProfilingSampler sampler) {}
		public override void Release(RenderGraphObjectPool pool) {}
		public override bool HasRenderFunc() => default;
	}

	internal enum RenderGraphProfileId // TypeDefIndex: 53372
	{
		CompileRenderGraph = 0,
		ExecuteRenderGraph = 1,
		RenderGraphClear = 2,
		RenderGraphClearDebug = 3
	}

	[DebuggerDisplay("ComputeBuffer ({handle.index})")]
	public struct ComputeBufferHandle // TypeDefIndex: 53373
	{
		// Fields
		private static ComputeBufferHandle s_NullHandle; // 0x00
		internal ResourceHandle handle; // 0x00
	
		// Properties
		public static ComputeBufferHandle nullHandle { get => default; } // 0x0000000189C9A7FC-0x0000000189C9A84C 
	
		// Constructors
		internal ComputeBufferHandle(int handle, bool shared = false /* Metadata: 0x01FD44E9 */) : this() {
			this.handle = default;
		} // 0x0000000189C9A7C4-0x0000000189C9A7FC
		static ComputeBufferHandle() {
			s_NullHandle = default;
		} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static implicit operator ComputeBuffer(ComputeBufferHandle buffer) => default; // 0x0000000189C9A84C-0x0000000189C9A8B8
		public bool IsValid() => default; // 0x0000000189C9A778-0x0000000189C9A7C4
	}

	public struct ComputeBufferDesc // TypeDefIndex: 53374
	{
		// Fields
		public int count; // 0x00
		public int stride; // 0x04
		public ComputeBufferType type; // 0x08
		public string name; // 0x10
	
		// Constructors
		public ComputeBufferDesc(int count, int stride) {
			this.count = default;
			this.stride = default;
			type = default;
			name = default;
		} // 0x0000000183D6C010-0x0000000183D6C030
		public ComputeBufferDesc(int count, int stride, ComputeBufferType type) {
			this.count = default;
			this.stride = default;
			this.type = default;
			name = default;
		} // 0x0000000183D6BFF0-0x0000000183D6C010
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000183D83EC0-0x0000000183D83EE0
	}

	[DebuggerDisplay("ComputeBufferResource ({desc.name})")]
	internal class ComputeBufferResource : RenderGraphResource<ComputeBufferDesc, ComputeBuffer> // TypeDefIndex: 53375
	{
		// Constructors
		public ComputeBufferResource() {} // 0x0000000189C9B338-0x0000000189C9B360
	
		// Methods
		public override string GetName() => default; // 0x0000000189C9B078-0x0000000189C9B0B8
		public override void CreatePooledGraphicsResource() {} // 0x0000000189C9AF24-0x0000000189C9B078
		public override void ReleasePooledGraphicsResource(int frameIndex) {} // 0x0000000189C9B1FC-0x0000000189C9B338
		public override void CreateGraphicsResource(string name = "" /* Metadata: 0x01FD44EA */) {} // 0x0000000189C9ADBC-0x0000000189C9AF24
		public override void ReleaseGraphicsResource() {} // 0x0000000189C9B1B8-0x0000000189C9B1FC
		public override void LogCreation(RenderGraphLogger logger) {} // 0x0000000189C9B0B8-0x0000000189C9B138
		public override void LogRelease(RenderGraphLogger logger) {} // 0x0000000189C9B138-0x0000000189C9B1B8
	}

	internal class ComputeBufferPool : RenderGraphResourcePool<ComputeBuffer> // TypeDefIndex: 53376
	{
		// Constructors
		public ComputeBufferPool() {} // 0x0000000189C9AD80-0x0000000189C9ADBC
	
		// Methods
		protected override void ReleaseInternalResource(ComputeBuffer res) {} // 0x0000000189C9AD60-0x0000000189C9AD80
		protected override string GetResourceName(ComputeBuffer res) => default; // 0x0000000189C9A8B8-0x0000000189C9A8E4
		protected override long GetResourceSize(ComputeBuffer res) => default; // 0x0000000189C9A8E4-0x0000000189C9A924
		protected override string GetResourceTypeName() => default; // 0x0000000189C9A924-0x0000000189C9A950
		protected override int GetSortIndex(ComputeBuffer res) => default; // 0x00000001882953C4-0x00000001882953E4
		public override void PurgeUnusedResources(int currentFrameIndex) {} // 0x0000000189C9A950-0x0000000189C9AD60
	}

	internal abstract class IRenderGraphResourcePool // TypeDefIndex: 53377
	{
		// Constructors
		protected IRenderGraphResourcePool() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract void PurgeUnusedResources(int currentFrameIndex);
		public abstract void Cleanup();
		public abstract void CheckFrameAllocation(bool onException, int frameIndex);
		public abstract void LogResources(RenderGraphLogger logger);
	}

	internal abstract class RenderGraphResourcePool<Type> : IRenderGraphResourcePool // TypeDefIndex: 53380
		where Type : class
	{
		// Fields
		[TupleElementNames(new string[2] {"resource", "frameIndex" })]
		protected Dictionary<int, SortedList<int, ValueTuple<Type, int>>> m_ResourcePool;
		protected List<int> m_RemoveList;
		private List<ValueTuple<int, Type>> m_FrameAllocatedResources;
		protected static int s_CurrentFrameIndex;
		private const int kStaleResourceLifetime = 10; // Metadata: 0x01FD44EB
	
		// Nested types
		private struct ResourceLogInfo // TypeDefIndex: 53378
		{
			// Fields
			public string name;
			public long size;
		}
	
		// Constructors
		protected RenderGraphResourcePool() {}
	
		// Methods
		protected abstract void ReleaseInternalResource(Type res);
		protected abstract string GetResourceName(Type res);
		protected abstract long GetResourceSize(Type res);
		protected abstract string GetResourceTypeName();
		protected abstract int GetSortIndex(Type res);
		public void ReleaseResource(int hash, Type resource, int currentFrameIndex) {}
		public bool TryGetResource(int hashCode, out ref Type resource) {
			resource = default;
			return default;
		}
		public override void Cleanup() {}
		public void RegisterFrameAllocation(int hash, Type value) {}
		public void UnregisterFrameAllocation(int hash, Type value) {}
		public override void CheckFrameAllocation(bool onException, int frameIndex) {}
		public override void LogResources(RenderGraphLogger logger) {}
		protected static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex) => default;
	}

	internal class RenderGraphResourceRegistry // TypeDefIndex: 53383
	{
		// Fields
		private const int kSharedResourceLifetime = 30; // Metadata: 0x01FD44EF
		private static RenderGraphResourceRegistry m_CurrentRegistry; // 0x00
		private RenderGraphResourcesData[] m_RenderGraphResources; // 0x10
		private DynamicArray<RendererListResource> m_RendererListResources; // 0x18
		private RenderGraphDebugParams m_RenderGraphDebug; // 0x20
		private RenderGraphLogger m_ResourceLogger; // 0x28
		private RenderGraphLogger m_FrameInformationLogger; // 0x30
		private int m_CurrentFrameIndex; // 0x38
		private int m_ExecutionCount; // 0x3C
		private RTHandle m_CurrentBackbuffer; // 0x40
		private const int kInitialRendererListCount = 256; // Metadata: 0x01FD44F0
		private List<UnityEngine.Rendering.RendererUtils.RendererList> m_ActiveRendererLists; // 0x48
	
		// Properties
		internal static RenderGraphResourceRegistry current { get => default; set {} } // 0x0000000189CA897C-0x0000000189CA89B4 0x0000000189CA89B4-0x0000000189CA8A04
	
		// Nested types
		private delegate void ResourceCallback(RenderGraphContext rgContext, IRenderGraphResource res); // TypeDefIndex: 53381; 0x0000000182065C10-0x0000000182065C20
	
		private class RenderGraphResourcesData // TypeDefIndex: 53382
		{
			// Fields
			public DynamicArray<IRenderGraphResource> resourceArray; // 0x10
			public int sharedResourcesCount; // 0x18
			public IRenderGraphResourcePool pool; // 0x20
			public ResourceCallback createResourceCallback; // 0x28
			public ResourceCallback releaseResourceCallback; // 0x30
	
			// Constructors
			public RenderGraphResourcesData() {} // 0x0000000189CA8B2C-0x0000000189CA8BA4
	
			// Methods
			public void Clear(bool onException, int frameIndex) {} // 0x0000000189CA8A88-0x0000000189CA8B08
			public void Cleanup() {} // 0x0000000189CA8A04-0x0000000189CA8A88
			public void PurgeUnusedGraphicsResources(int frameIndex) {} // 0x0000000189CA8B08-0x0000000189CA8B2C
			public int AddNewRenderGraphResource<ResType>(out ref ResType outRes, bool pooledResource = true /* Metadata: 0x01FD44F2 */)
				where ResType : IRenderGraphResource, new() {
				outRes = default;
				return default;
			}
		}
	
		// Constructors
		private RenderGraphResourceRegistry() {} // 0x0000000189CA8854-0x0000000189CA897C
		internal RenderGraphResourceRegistry(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger frameInformationLogger) {} // 0x0000000189CA84F0-0x0000000189CA8854
	
		// Methods
		internal RTHandle GetTexture([IsReadOnly] in TextureHandle handle) => default; // 0x0000000189CA74EC-0x0000000189CA7698
		internal bool TextureNeedsFallback([IsReadOnly] in TextureHandle handle) => default; // 0x0000000189CA83DC-0x0000000189CA8460
		internal UnityEngine.Rendering.RendererUtils.RendererList GetRendererList([IsReadOnly] in RendererListHandle handle) => default; // 0x0000000189CA71DC-0x0000000189CA72A8
		internal ComputeBuffer GetComputeBuffer([IsReadOnly] in ComputeBufferHandle handle) => default; // 0x0000000189CA6EF0-0x0000000189CA6FC0
		internal void BeginRenderGraph(int executionCount) {} // 0x0000000189CA5CD0-0x0000000189CA5D58
		internal void BeginExecute(int currentFrameIndex) {} // 0x0000000189CA5CB0-0x0000000189CA5CD0
		internal void EndExecute() {} // 0x0000000189CA6C0C-0x0000000189CA6C14
		private void CheckHandleValidity([IsReadOnly] in ResourceHandle res) {} // 0x0000000189CA5D58-0x0000000189CA5DAC
		private void CheckHandleValidity(RenderGraphResourceType type, int index) {} // 0x0000000189CA5DAC-0x0000000189CA5ED4
		internal void IncrementWriteCount([IsReadOnly] in ResourceHandle res) {} // 0x0000000189CA7998-0x0000000189CA7A54
		internal string GetRenderGraphResourceName([IsReadOnly] in ResourceHandle res) => default; // 0x0000000189CA6FC0-0x0000000189CA7080
		internal string GetRenderGraphResourceName(RenderGraphResourceType type, int index) => default; // 0x0000000189CA7080-0x0000000189CA7120
		internal bool IsRenderGraphResourceImported([IsReadOnly] in ResourceHandle res) => default; // 0x0000000189CA7BB0-0x0000000189CA7C6C
		internal bool IsRenderGraphResourceShared(RenderGraphResourceType type, int index) => default; // 0x0000000189CA7C6C-0x0000000189CA7CC8
		internal bool IsGraphicsResourceCreated([IsReadOnly] in ResourceHandle res) => default; // 0x0000000189CA7A54-0x0000000189CA7B14
		internal bool IsRendererListCreated([IsReadOnly] in RendererListHandle res) => default; // 0x0000000189CA7CC8-0x0000000189CA7D50
		internal bool IsRenderGraphResourceImported(RenderGraphResourceType type, int index) => default; // 0x0000000189CA7B14-0x0000000189CA7BB0
		internal int GetRenderGraphResourceTransientIndex([IsReadOnly] in ResourceHandle res) => default; // 0x0000000189CA7120-0x0000000189CA71DC
		internal TextureHandle ImportTexture(RTHandle rt) => default; // 0x0000000189CA78C8-0x0000000189CA7998
		internal TextureHandle CreateSharedTexture([IsReadOnly] in TextureDesc desc, bool explicitRelease) => default; // 0x0000000189CA6648-0x0000000189CA6850
		internal void ReleaseSharedTexture(TextureHandle texture) {} // 0x0000000189CA8110-0x0000000189CA8238
		internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt) => default; // 0x0000000189CA7698-0x0000000189CA780C
		internal TextureHandle CreateTexture([IsReadOnly] in TextureDesc desc, int transientPassIndex = -1 /* Metadata: 0x01FD44EC */) => default; // 0x0000000189CA6AF4-0x0000000189CA6C0C
		internal int GetTextureResourceCount() => default; // 0x0000000189CA72A8-0x0000000189CA7304
		private TextureResource GetTextureResource([IsReadOnly] in ResourceHandle handle) => default; // 0x0000000189CA742C-0x0000000189CA74EC
		internal TextureDesc GetTextureResourceDesc([IsReadOnly] in ResourceHandle handle) => default; // 0x0000000189CA7304-0x0000000189CA742C
		internal void ForceTextureClear([IsReadOnly] in ResourceHandle handle, UnityEngine.Color clearColor) {} // 0x0000000189CA6C70-0x0000000189CA6CD0
		internal RendererListHandle CreateRendererList([IsReadOnly] in UnityEngine.Rendering.RendererUtils.RendererListDesc desc) => default; // 0x0000000189CA61DC-0x0000000189CA6310
		internal ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer) => default; // 0x0000000189CA780C-0x0000000189CA78C8
		internal ComputeBufferHandle CreateComputeBuffer([IsReadOnly] in ComputeBufferDesc desc, int transientPassIndex = -1 /* Metadata: 0x01FD44ED */) => default; // 0x0000000189CA5FF0-0x0000000189CA60CC
		internal ComputeBufferDesc GetComputeBufferResourceDesc([IsReadOnly] in ResourceHandle handle) => default; // 0x0000000189CA6D2C-0x0000000189CA6E30
		internal int GetComputeBufferResourceCount() => default; // 0x0000000189CA6CD0-0x0000000189CA6D2C
		private ComputeBufferResource GetComputeBufferResource([IsReadOnly] in ResourceHandle handle) => default; // 0x0000000189CA6E30-0x0000000189CA6EF0
		internal void UpdateSharedResourceLastFrameIndex(int type, int index) {} // 0x0000000189CA8460-0x0000000189CA84F0
		private void ManageSharedRenderGraphResources() {} // 0x0000000189CA7E5C-0x0000000189CA7FA8
		internal void CreatePooledResource(RenderGraphContext rgContext, int type, int index) {} // 0x0000000189CA60CC-0x0000000189CA61DC
		private void CreateTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res) {} // 0x0000000189CA6850-0x0000000189CA6AF4
		internal void ReleasePooledResource(RenderGraphContext rgContext, int type, int index) {} // 0x0000000189CA7FFC-0x0000000189CA8110
		private void ReleaseTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res) {} // 0x0000000189CA8238-0x0000000189CA83DC
		private void ValidateTextureDesc([IsReadOnly] in TextureDesc desc) {} // 0x000000018350B670-0x000000018350B680
		private void ValidateRendererListDesc([IsReadOnly] in UnityEngine.Rendering.RendererUtils.RendererListDesc desc) {} // 0x000000018350B670-0x000000018350B680
		private void ValidateComputeBufferDesc([IsReadOnly] in ComputeBufferDesc desc) {} // 0x000000018350B670-0x000000018350B680
		internal void CreateRendererLists(List<RendererListHandle> rendererLists, ScriptableRenderContext context, bool manualDispatch = false /* Metadata: 0x01FD44EE */) {} // 0x0000000189CA6310-0x0000000189CA6648
		internal void Clear(bool onException) {} // 0x0000000189CA5F34-0x0000000189CA5FF0
		internal void PurgeUnusedGraphicsResources() {} // 0x0000000189CA7FA8-0x0000000189CA7FFC
		internal void Cleanup() {} // 0x0000000189CA5ED4-0x0000000189CA5F34
		internal void FlushLogs() {} // 0x0000000189CA6C14-0x0000000189CA6C70
		private void LogResources() {} // 0x0000000189CA7D50-0x0000000189CA7E5C
	}

	[DebuggerDisplay("RendererList ({handle})")]
	public struct RendererListHandle // TypeDefIndex: 53384
	{
		// Fields
		private bool m_IsValid; // 0x00
	
		// Properties
		internal int handle { [IsReadOnly] get; private set; } // 0x0000000183D4E990-0x0000000183D4E9A0 0x0000000183D51720-0x0000000183D51730
	
		// Constructors
		internal RendererListHandle(int handle) : this() {
			m_IsValid = default;
		} // 0x0000000183D68530-0x0000000183D68540
	
		// Methods
		public static implicit operator int(RendererListHandle handle) => default; // 0x0000000183D68B20-0x0000000183D68B30
		public static implicit operator UnityEngine.Rendering.RendererUtils.RendererList(RendererListHandle rendererList) => default; // 0x0000000189CA8BA4-0x0000000189CA8C34
		public bool IsValid() => default; // 0x0000000183D51020-0x0000000183D51030
	}

	internal struct RendererListResource // TypeDefIndex: 53385
	{
		// Fields
		public UnityEngine.Rendering.RendererUtils.RendererListDesc desc; // 0x00
		public UnityEngine.Rendering.RendererUtils.RendererList rendererList; // 0xE0
	
		// Constructors
		internal RendererListResource([IsReadOnly] in UnityEngine.Rendering.RendererUtils.RendererListDesc desc) {
			this.desc = default;
			rendererList = default;
		} // 0x00000001885B4914-0x00000001885B4A34
	}

	internal enum RenderGraphResourceType // TypeDefIndex: 53386
	{
		Texture = 0,
		ComputeBuffer = 1,
		Count = 2
	}

	internal struct ResourceHandle // TypeDefIndex: 53387
	{
		// Fields
		private const uint kValidityMask = 4294901760; // Metadata: 0x01FD44F6
		private const uint kIndexMask = 65535; // Metadata: 0x01FD44FB
		private uint m_Value; // 0x00
		private static uint s_CurrentValidBit; // 0x00
		private static uint s_SharedResourceValidBit; // 0x04
	
		// Properties
		public int index { get => default; } // 0x0000000183D4F990-0x0000000183D4F9A0 
		public RenderGraphResourceType type { [IsReadOnly] get; private set; } // 0x0000000183D4E990-0x0000000183D4E9A0 0x0000000183D51720-0x0000000183D51730
		public int iType { get => default; } // 0x0000000189CA8E4C-0x0000000189CA8E90 
	
		// Constructors
		internal ResourceHandle(int value, RenderGraphResourceType type, bool shared) : this() {
			m_Value = default;
		} // 0x0000000189CA8DC0-0x0000000189CA8E4C
		static ResourceHandle() {
			s_CurrentValidBit = default;
			s_SharedResourceValidBit = default;
		} // 0x0000000189CA8D70-0x0000000189CA8DC0
	
		// Methods
		public static implicit operator int(ResourceHandle handle) => default; // 0x0000000189CA8E90-0x0000000189CA8ED4
		public bool IsValid() => default; // 0x0000000189CA8C34-0x0000000189CA8CAC
		public static void NewFrame(int executionIndex) {} // 0x0000000189CA8CAC-0x0000000189CA8D70
	}

	internal class IRenderGraphResource // TypeDefIndex: 53388
	{
		// Fields
		public bool imported; // 0x10
		public bool shared; // 0x11
		public bool sharedExplicitRelease; // 0x12
		public bool requestFallBack; // 0x13
		public uint writeCount; // 0x14
		public int cachedHash; // 0x18
		public int transientPassIndex; // 0x1C
		public int sharedResourceLastFrameUsed; // 0x20
		protected IRenderGraphResourcePool m_Pool; // 0x28
	
		// Constructors
		public IRenderGraphResource() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual void Reset(IRenderGraphResourcePool pool) {} // 0x0000000189CA3DD8-0x0000000189CA3DFC
		public virtual string GetName() => default; // 0x0000000189CA3D98-0x0000000189CA3DC4
		public virtual bool IsCreated() => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual void IncrementWriteCount() {} // 0x0000000183D83F50-0x0000000183D83F60
		public virtual bool NeedsFallBack() => default; // 0x0000000189CA3DC4-0x0000000189CA3DD8
		public virtual void CreatePooledGraphicsResource() {} // 0x000000018350B670-0x000000018350B680
		public virtual void CreateGraphicsResource(string name = "" /* Metadata: 0x01FD44FF */) {} // 0x000000018350B670-0x000000018350B680
		public virtual void ReleasePooledGraphicsResource(int frameIndex) {} // 0x000000018350B670-0x000000018350B680
		public virtual void ReleaseGraphicsResource() {} // 0x000000018350B670-0x000000018350B680
		public virtual void LogCreation(RenderGraphLogger logger) {} // 0x000000018350B670-0x000000018350B680
		public virtual void LogRelease(RenderGraphLogger logger) {} // 0x000000018350B670-0x000000018350B680
		public virtual int GetSortIndex() => default; // 0x0000000181002730-0x0000000181002740
	}

	[DebuggerDisplay("Resource ({GetType().Name}:{GetName()})")]
	internal abstract class RenderGraphResource<DescType, ResType> : IRenderGraphResource // TypeDefIndex: 53389
		where DescType : struct
		where ResType : class
	{
		// Fields
		public DescType desc;
		public ResType graphicsResource;
	
		// Constructors
		protected RenderGraphResource() {}
	
		// Methods
		public override void Reset(IRenderGraphResourcePool pool) {}
		public override bool IsCreated() => default;
		public override void ReleaseGraphicsResource() {}
	}

	[DebuggerDisplay("Texture ({handle.index})")]
	public struct TextureHandle // TypeDefIndex: 53390
	{
		// Fields
		private static TextureHandle s_NullHandle; // 0x00
		internal ResourceHandle handle; // 0x00
		internal ResourceHandle fallBackResource; // 0x08
	
		// Properties
		public static TextureHandle nullHandle { get => default; } // 0x0000000189CA97D8-0x0000000189CA9834 
	
		// Constructors
		internal TextureHandle(int handle, bool shared = false /* Metadata: 0x01FD4500 */) : this() {
			this.handle = default;
			fallBackResource = default;
		} // 0x0000000189CA974C-0x0000000189CA97D8
		static TextureHandle() {
			s_NullHandle = default;
		} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static implicit operator RenderTargetIdentifier(TextureHandle texture) => default; // 0x0000000189CA9994-0x0000000189CA9A48
		public static implicit operator Texture(TextureHandle texture) => default; // 0x0000000189CA9834-0x0000000189CA98B0
		public static implicit operator RenderTexture(TextureHandle texture) => default; // 0x0000000189CA9918-0x0000000189CA9994
		public static implicit operator RTHandle(TextureHandle texture) => default; // 0x0000000189CA98B0-0x0000000189CA9918
		public bool IsValid() => default; // 0x0000000189CA9700-0x0000000189CA974C
		public void SetFallBackResource(TextureHandle texture) {} // 0x0000000183D83F60-0x0000000183D83F70
	}

	public enum TextureSizeMode // TypeDefIndex: 53391
	{
		Explicit = 0,
		Scale = 1,
		Functor = 2
	}

	public struct FastMemoryDesc // TypeDefIndex: 53392
	{
		// Fields
		public bool inFastMemory; // 0x00
		public FastMemoryFlags flags; // 0x04
		public float residencyFraction; // 0x08
	}

	public struct TextureDesc // TypeDefIndex: 53393
	{
		// Fields
		public int width; // 0x00
		public int height; // 0x04
		public int slices; // 0x08
		public DepthBits depthBufferBits; // 0x0C
		public GraphicsFormat colorFormat; // 0x10
		public UnityEngine.FilterMode filterMode; // 0x14
		public TextureWrapMode wrapMode; // 0x18
		public TextureDimension dimension; // 0x1C
		public bool enableRandomWrite; // 0x20
		public bool useMipMap; // 0x21
		public bool autoGenerateMips; // 0x22
		public bool isShadowMap; // 0x23
		public int anisoLevel; // 0x24
		public float mipMapBias; // 0x28
		public MSAASamples msaaSamples; // 0x2C
		public bool bindTextureMS; // 0x30
		public RenderTextureMemoryless memoryless; // 0x34
		public string name; // 0x38
		public FastMemoryDesc fastMemoryDesc; // 0x40
		public bool fallBackToBlackTexture; // 0x4C
		public bool clearBuffer; // 0x4D
		public UnityEngine.Color clearColor; // 0x50
	
		// Constructors
		public TextureDesc(int width, int height, bool xrReady = false /* Metadata: 0x01FD4504 */) {
			this.width = default;
			this.height = default;
			slices = default;
			depthBufferBits = default;
			colorFormat = default;
			filterMode = default;
			wrapMode = default;
			dimension = default;
			enableRandomWrite = default;
			useMipMap = default;
			autoGenerateMips = default;
			isShadowMap = default;
			anisoLevel = default;
			mipMapBias = default;
			msaaSamples = default;
			bindTextureMS = default;
			memoryless = default;
			name = default;
			fastMemoryDesc = default;
			fallBackToBlackTexture = default;
			clearBuffer = default;
			clearColor = default;
		} // 0x0000000189CA96CC-0x0000000189CA9700
		public TextureDesc(TextureDesc input) {
			width = default;
			height = default;
			slices = default;
			depthBufferBits = default;
			colorFormat = default;
			filterMode = default;
			wrapMode = default;
			dimension = default;
			enableRandomWrite = default;
			useMipMap = default;
			autoGenerateMips = default;
			isShadowMap = default;
			anisoLevel = default;
			mipMapBias = default;
			msaaSamples = default;
			bindTextureMS = default;
			memoryless = default;
			name = default;
			fastMemoryDesc = default;
			fallBackToBlackTexture = default;
			clearBuffer = default;
			clearColor = default;
		} // 0x00000001885B7F4C-0x00000001885B7F84
	
		// Methods
		private void InitDefaultValues(bool xrReady) {} // 0x0000000189CA9664-0x0000000189CA96CC
		public override int GetHashCode() => default; // 0x0000000189CA9568-0x0000000189CA9664
	}

	[DebuggerDisplay("TextureResource ({desc.name})")]
	internal class TextureResource : RenderGraphResource<TextureDesc, RTHandle> // TypeDefIndex: 53394
	{
		// Fields
		private static int m_TextureCreationIndex; // 0x00
	
		// Constructors
		public TextureResource() {} // 0x0000000189CAA5E8-0x0000000189CAA610
	
		// Methods
		public override string GetName() => default; // 0x0000000189CAA2C4-0x0000000189CAA320
		public override void CreatePooledGraphicsResource() {} // 0x0000000189CAA170-0x0000000189CAA2C4
		public override void ReleasePooledGraphicsResource(int frameIndex) {} // 0x0000000189CAA4A0-0x0000000189CAA5E8
		public override void CreateGraphicsResource(string name = "" /* Metadata: 0x01FD4505 */) {} // 0x0000000189CA9F48-0x0000000189CAA170
		public override void ReleaseGraphicsResource() {} // 0x0000000189CAA454-0x0000000189CAA4A0
		public override void LogCreation(RenderGraphLogger logger) {} // 0x0000000189CAA320-0x0000000189CAA3D4
		public override void LogRelease(RenderGraphLogger logger) {} // 0x0000000189CAA3D4-0x0000000189CAA454
	}

	internal class TexturePool : RenderGraphResourcePool<RTHandle> // TypeDefIndex: 53395
	{
		// Constructors
		public TexturePool() {} // 0x0000000189CA9F0C-0x0000000189CA9F48
	
		// Methods
		protected override void ReleaseInternalResource(RTHandle res) {} // 0x0000000189CA9EEC-0x0000000189CA9F0C
		protected override string GetResourceName(RTHandle res) => default; // 0x0000000189CA9A48-0x0000000189CA9A6C
		protected override long GetResourceSize(RTHandle res) => default; // 0x0000000189CA9A6C-0x0000000189CA9A90
		protected override string GetResourceTypeName() => default; // 0x0000000189CA9A90-0x0000000189CA9ABC
		protected override int GetSortIndex(RTHandle res) => default; // 0x0000000189CA9ABC-0x0000000189CA9ADC
		public override void PurgeUnusedResources(int currentFrameIndex) {} // 0x0000000189CA9ADC-0x0000000189CA9EEC
	}
}

namespace UnityEngine.Rendering
{
	public class CameraSwitcher : MonoBehaviour // TypeDefIndex: 53396
	{
		// Fields
		public Camera[] m_Cameras; // 0x18
		private int m_CurrentCameraIndex; // 0x20
		private Camera m_OriginalCamera; // 0x28
		private Vector3 m_OriginalCameraPosition; // 0x30
		private Quaternion m_OriginalCameraRotation; // 0x3C
		private Camera m_CurrentCamera; // 0x50
		private GUIContent[] m_CameraNames; // 0x58
		private int[] m_CameraIndices; // 0x60
		private DebugUI.EnumField m_DebugEntry; // 0x68
		private int m_DebugEntryEnumIndex; // 0x70
	
		// Constructors
		public CameraSwitcher() {} // 0x0000000189C9A3D8-0x0000000189C9A3E8
	
		// Methods
		private void OnEnable() {} // 0x0000000189C99BE4-0x0000000189C9A138
		private void OnDisable() {} // 0x0000000189C99B70-0x0000000189C99BE4
		private int GetCameraCount() => default; // 0x0000000189C99B10-0x0000000189C99B30
		private Camera GetNextCamera() => default; // 0x0000000189C99B30-0x0000000189C99B70
		private void SetCameraIndex(int index) {} // 0x0000000189C9A138-0x0000000189C9A3D0
	}

	public class FreeCamera : MonoBehaviour // TypeDefIndex: 53397
	{
		// Fields
		private const float k_MouseSensitivityMultiplier = 0.01f; // Metadata: 0x01FD4506
		public float m_LookSpeedController; // 0x18
		public float m_LookSpeedMouse; // 0x1C
		public float m_MoveSpeed; // 0x20
		public float m_MoveSpeedIncrement; // 0x24
		public float m_Turbo; // 0x28
		private InputAction lookAction; // 0x30
		private InputAction moveAction; // 0x38
		private InputAction speedAction; // 0x40
		private InputAction yMoveAction; // 0x48
		private float inputRotateAxisX; // 0x50
		private float inputRotateAxisY; // 0x54
		private float inputChangeSpeed; // 0x58
		private float inputVertical; // 0x5C
		private float inputHorizontal; // 0x60
		private float inputYAxis; // 0x64
		private bool leftShiftBoost; // 0x68
		private bool leftShift; // 0x69
		private bool fire1; // 0x6A
	
		// Constructors
		public FreeCamera() {} // 0x0000000189CA3C7C-0x0000000189CA3CA8
	
		// Methods
		private void OnEnable() {} // 0x0000000189CA2E04-0x0000000189CA2E0C
		private void RegisterInputs() {} // 0x0000000189CA2E0C-0x0000000189CA35A0
		private void UpdateInputs() {} // 0x0000000189CA35A0-0x0000000189CA37B8
		private void Update() {} // 0x0000000189CA37B8-0x0000000189CA3C7C
	}

	public static class CommandBufferPool // TypeDefIndex: 53399
	{
		// Fields
		private static ObjectPool<CommandBuffer> s_BufferPool; // 0x00
	
		// Constructors
		static CommandBufferPool() {} // 0x0000000183B0D970-0x0000000183B0DAE0
	
		// Methods
		public static CommandBuffer Get() => default; // 0x000000018263D260-0x000000018263D310
		public static CommandBuffer Get(string name) => default; // 0x000000018263CC60-0x000000018263CD30
		public static void Release(CommandBuffer buffer) {} // 0x000000018263CFB0-0x000000018263D140
	}

	[Flags]
	public enum ClearFlag // TypeDefIndex: 53400
	{
		None = 0,
		Color = 1,
		Depth = 2,
		Stencil = 4,
		ColorStencil = 5,
		DepthStencil = 6,
		All = 7
	}

	public static class ComponentSingleton<TType> // TypeDefIndex: 53401
		where TType : Component
	{
		// Fields
		private static TType s_Instance;
	
		// Properties
		public static TType instance { get; }
	
		// Methods
		public static void Release() {}
	}

	public class ConstantBuffer // TypeDefIndex: 53402
	{
		// Fields
		private static List<ConstantBufferBase> m_RegisteredConstantBuffers; // 0x00
	
		// Constructors
		public ConstantBuffer() {} // 0x000000018350B670-0x000000018350B680
		static ConstantBuffer() {} // 0x0000000183CE4E10-0x0000000183CE4EA0
	
		// Methods
		public static void PushGlobal<CBType>(CommandBuffer cmd, [IsReadOnly] in ref CBType data, int shaderId)
			where CBType : struct {}
		public static void PushGlobal<CBType>([IsReadOnly] in ref CBType data, int shaderId)
			where CBType : struct {}
		public static void Push<CBType>(CommandBuffer cmd, [IsReadOnly] in ref CBType data, ComputeShader cs, int shaderId)
			where CBType : struct {}
		public static void Push<CBType>([IsReadOnly] in ref CBType data, ComputeShader cs, int shaderId)
			where CBType : struct {}
		public static void Push<CBType>(CommandBuffer cmd, [IsReadOnly] in ref CBType data, Material mat, int shaderId)
			where CBType : struct {}
		public static void Push<CBType>([IsReadOnly] in ref CBType data, Material mat, int shaderId)
			where CBType : struct {}
		public static void UpdateData<CBType>(CommandBuffer cmd, [IsReadOnly] in ref CBType data)
			where CBType : struct {}
		public static void UpdateData<CBType>([IsReadOnly] in ref CBType data)
			where CBType : struct {}
		public static void SetGlobal<CBType>(CommandBuffer cmd, int shaderId)
			where CBType : struct {}
		public static void SetGlobal<CBType>(int shaderId)
			where CBType : struct {}
		public static void Set<CBType>(CommandBuffer cmd, ComputeShader cs, int shaderId)
			where CBType : struct {}
		public static void Set<CBType>(ComputeShader cs, int shaderId)
			where CBType : struct {}
		public static void Set<CBType>(Material mat, int shaderId)
			where CBType : struct {}
		public static void ReleaseAll() {} // 0x0000000183A594E0-0x0000000183A59660
		internal static void Register(ConstantBufferBase cb) {} // 0x0000000189C9B360-0x0000000189C9B3D0
	}

	public abstract class ConstantBufferBase // TypeDefIndex: 53403
	{
		// Constructors
		protected ConstantBufferBase() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract void Release();
	}

	public class ConstantBuffer<CBType> : ConstantBufferBase // TypeDefIndex: 53404
		where CBType : struct
	{
		// Fields
		private HashSet<int> m_GlobalBindings;
		private CBType[] m_Data;
		private ComputeBuffer m_GPUConstantBuffer;
	
		// Constructors
		public ConstantBuffer() {}
	
		// Methods
		public void UpdateData(CommandBuffer cmd, [IsReadOnly] in ref CBType data) {}
		public void UpdateData([IsReadOnly] in ref CBType data) {}
		public void SetGlobal(CommandBuffer cmd, int shaderId) {}
		public void SetGlobal(int shaderId) {}
		public void Set(CommandBuffer cmd, ComputeShader cs, int shaderId) {}
		public void Set(ComputeShader cs, int shaderId) {}
		public void Set(Material mat, int shaderId) {}
		public void PushGlobal(CommandBuffer cmd, [IsReadOnly] in ref CBType data, int shaderId) {}
		public void PushGlobal([IsReadOnly] in ref CBType data, int shaderId) {}
		public override void Release() {}
	}

	internal class ConstantBufferSingleton<CBType> : ConstantBuffer<CBType> // TypeDefIndex: 53405
		where CBType : struct
	{
		// Fields
		private static ConstantBufferSingleton<CBType> s_Instance;
	
		// Properties
		internal static ConstantBufferSingleton<CBType> instance { get => default; set {} }
	
		// Constructors
		public ConstantBufferSingleton() {}
	
		// Methods
		public override void Release() {}
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class DisplayInfoAttribute : Attribute // TypeDefIndex: 53406
	{
		// Fields
		public string name; // 0x10
		public int order; // 0x18
	
		// Constructors
		public DisplayInfoAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class AdditionalPropertyAttribute : Attribute // TypeDefIndex: 53407
	{
		// Constructors
		public AdditionalPropertyAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal enum CoreProfileId // TypeDefIndex: 53408
	{
		BlitTextureInPotAtlas = 0
	}

	public static class CoreUnsafeUtils // TypeDefIndex: 53413
	{
		// Nested types
		public struct FixedBufferStringQueue // TypeDefIndex: 53409
		{
			// Fields
			private unsafe byte* m_ReadCursor; // 0x00
			private unsafe byte* m_WriteCursor; // 0x08
			private readonly unsafe byte* m_BufferEnd; // 0x10
			private readonly unsafe byte* m_BufferStart; // 0x18
			private readonly int m_BufferLength; // 0x20
	
			// Properties
			public int Count { [IsReadOnly] get; private set; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
	
			// Constructors
			public unsafe FixedBufferStringQueue(byte* ptr, int length) : this() {
				m_ReadCursor = default;
				m_WriteCursor = default;
				m_BufferEnd = default;
				m_BufferStart = default;
				m_BufferLength = default;
			} // 0x0000000189CA2C74-0x0000000189CA2C9C
	
			// Methods
			public bool TryPush(string v) => default; // 0x0000000189CA2BD4-0x0000000189CA2C74
			public bool TryPop(out string v) {
				v = default;
				return default;
			} // 0x0000000189CA2B64-0x0000000189CA2BD4
			public void Clear() {} // 0x0000000189CA2B40-0x0000000189CA2B64
		}
	
		public interface IKeyGetter<TValue, TKey> // TypeDefIndex: 53410
		{
			// Methods
			TKey Get(ref ref TValue v);
		}
	
		internal struct DefaultKeyGetter<T> : IKeyGetter<T, T> // TypeDefIndex: 53411
		{
			// Methods
			public T Get(ref ref T v) => default;
		}
	
		internal struct UintKeyGetter : IKeyGetter<uint, uint> // TypeDefIndex: 53412
		{
			// Methods
			public uint Get(ref uint v) => default; // 0x0000000183D60740-0x0000000183D60750
		}
	
		// Methods
		private static void CalculateRadixParams(int radixBits, out int bitStates) {
			bitStates = default;
		} // 0x0000000189C9BAD4-0x0000000189C9BB50
		private static int CalculateRadixSupportSize(int bitStates, int arrayLength) => default; // 0x0000000183D83F20-0x0000000183D83F30
		private static unsafe void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, uint* supportArray, out uint* bucketIndices, out uint* bucketSizes, out uint* bucketPrefix, out uint* arrayOutput) {
			bucketIndices = default;
			bucketSizes = default;
			bucketPrefix = default;
			arrayOutput = default;
		} // 0x0000000183D83EE0-0x0000000183D83F20
		private static unsafe void MergeSort(uint* array, uint* support, int length) {} // 0x0000000189C9BE74-0x0000000189C9C020
		public static void MergeSort(uint[] arr, int sortSize, ref uint[] supportArray) {} // 0x0000000189C9C020-0x0000000189C9C114
		public static void MergeSort(NativeArray<uint> arr, Unity.Collections.Allocator arrAllocator, int sortSize, ref NativeArray<uint> supportArray) {} // 0x0000000189C9C114-0x0000000189C9C1E4
		private static unsafe void InsertionSort(uint* arr, int length) {} // 0x0000000189C9BDB0-0x0000000189C9BDF0
		public static void InsertionSort(uint[] arr, int sortSize) {} // 0x0000000189C9BDF0-0x0000000189C9BE74
		public static void InsertionSort(NativeArray<uint> arr, int sortSize) {} // 0x0000000189C9BD38-0x0000000189C9BDB0
		private static unsafe void RadixSort(uint* array, uint* support, int radixBits, int bitStates, int length) {} // 0x0000000189C9C25C-0x0000000189C9C420
		public static void RadixSort(uint[] arr, int sortSize, ref uint[] supportArray, int radixBits = 8 /* Metadata: 0x01FD4512 */) {} // 0x0000000189C9C50C-0x0000000189C9C61C
		public static void RadixSort(NativeArray<uint> array, int sortSize, ref NativeArray<uint> supportArray, Unity.Collections.Allocator supportArrayAllocator, int radixBits = 8 /* Metadata: 0x01FD4513 */) {} // 0x0000000189C9C420-0x0000000189C9C50C
		public static void QuickSort(uint[] arr, int left, int right) {} // 0x0000000189C9C1E4-0x0000000189C9C25C
		public static unsafe void QuickSort<T>(int count, void* data)
			where T : struct, IComparable<T> {}
		public static unsafe void QuickSort<TValue, TKey, TGetter>(int count, void* data)
			where TValue : struct
			where TKey : struct, IComparable<TKey>
			where TGetter : struct, IKeyGetter<TValue, TKey> {}
		public static unsafe void QuickSort<TValue, TKey, TGetter>(void* data, int left, int right)
			where TValue : struct
			where TKey : struct, IComparable<TKey>
			where TGetter : struct, IKeyGetter<TValue, TKey> {}
		public static unsafe int IndexOf<T>(void* data, int count, T v)
			where T : struct, IEquatable<T> => default;
		public static unsafe int CompareHashes<TOldValue, TOldGetter, TNewValue, TNewGetter>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount)
			where TOldValue : struct
			where TOldGetter : struct, IKeyGetter<TOldValue, Hash128>
			where TNewValue : struct
			where TNewGetter : struct, IKeyGetter<TNewValue, Hash128> {
			addCount = default;
			remCount = default;
			return default;
		}
		public static unsafe int CompareHashes(int oldHashCount, Hash128* oldHashes, int newHashCount, Hash128* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount) {
			addCount = default;
			remCount = default;
			return default;
		} // 0x0000000189C9BBA8-0x0000000189C9BC18
		public static unsafe void CombineHashes<TValue, TGetter>(int count, void* hashes, Hash128* outHash)
			where TValue : struct
			where TGetter : struct, IKeyGetter<TValue, Hash128> {}
		public static unsafe void CombineHashes(int count, Hash128* hashes, Hash128* outHash) {} // 0x0000000189C9BB50-0x0000000189C9BBA8
		private static unsafe int Partition<TValue, TKey, TGetter>(void* data, int left, int right)
			where TValue : struct
			where TKey : struct, IComparable<TKey>
			where TGetter : struct, IKeyGetter<TValue, TKey> => default;
		public static bool HaveDuplicates(int[] arr) => default; // 0x0000000189C9BC18-0x0000000189C9BD38
	
		// Extension methods
		public static unsafe void CopyTo<T>(this List<T> list, void* dest, int count)
			where T : struct {}
		public static unsafe void CopyTo<T>(this T[] list, void* dest, int count)
			where T : struct {}
	}

	public class DynamicArray<T> // TypeDefIndex: 53414
		where T : new()
	{
		// Fields
		private T[] m_Array;
	
		// Properties
		public int size { get; private set; }
		public int capacity { get => default; }
		public ref T this[int index] { get => default; }
	
		// Constructors
		public DynamicArray() {}
		public DynamicArray(int size) {}
	
		// Methods
		public void Clear() {}
		public bool Contains(T item) => default;
		public int Add([IsReadOnly] in ref T value) => default;
		public void AddRange(DynamicArray<T> array) {}
		public bool Remove(T item) => default;
		public void RemoveAt(int index) {}
		public void RemoveRange(int index, int count) {}
		public int FindIndex(int startIndex, int count, Predicate<T> match) => default;
		public int IndexOf(T item, int index, int count) => default;
		public int IndexOf(T item, int index) => default;
		public int IndexOf(T item) => default;
		public void Resize(int newSize, bool keepContent = false /* Metadata: 0x01FD4514 */) {}
		public void Reserve(int newCapacity, bool keepContent = false /* Metadata: 0x01FD4515 */) {}
		public static implicit operator T[](DynamicArray<T> array) => default;
	}

	public static class DynamicArrayExtensions // TypeDefIndex: 53415
	{
		// Methods
		private static int Partition<T>(T[] data, int left, int right)
			where T : IComparable<T>, new() => default;
		private static void QuickSort<T>(T[] data, int left, int right)
			where T : IComparable<T>, new() {}
	
		// Extension methods
		public static void QuickSort<T>(this DynamicArray<T> array)
			where T : IComparable<T>, new() {}
	}

	public delegate float PerformDynamicRes(); // TypeDefIndex: 53416; 0x0000000186F0A8DC-0x0000000186F0A8EC

	public enum DynamicResScalePolicyType // TypeDefIndex: 53417
	{
		ReturnsPercentage = 0,
		ReturnsMinMaxLerpFactor = 1
	}

	public enum DynamicResScalerSlot // TypeDefIndex: 53418
	{
		User = 0,
		System = 1,
		Count = 2
	}

	public class DynamicResolutionHandler // TypeDefIndex: 53421
	{
		// Fields
		private bool m_Enabled; // 0x10
		private bool m_UseMipBias; // 0x11
		private float m_MinScreenFraction; // 0x14
		private float m_MaxScreenFraction; // 0x18
		private float m_CurrentFraction; // 0x1C
		private bool m_ForcingRes; // 0x20
		private bool m_CurrentCameraRequest; // 0x21
		private float m_PrevFraction; // 0x24
		private bool m_ForceSoftwareFallback; // 0x28
		private bool m_RunUpscalerFilterOnFullResolution; // 0x29
		private float m_PrevHWScaleWidth; // 0x2C
		private float m_PrevHWScaleHeight; // 0x30
		private Vector2Int m_LastScaledSize; // 0x34
		private static DynamicResScalerSlot s_ActiveScalerSlot; // 0x00
		private static ScalerContainer[] s_ScalerContainers; // 0x08
		private Vector2Int cachedOriginalSize; // 0x3C
		private static Dictionary<int, DynamicResUpscaleFilter> s_CameraUpscaleFilters; // 0x10
		private DynamicResolutionType type; // 0x50
		private GlobalDynamicResolutionSettings m_CachedSettings; // 0x54
		private const int CameraDictionaryMaxcCapacity = 32; // Metadata: 0x01FD451E
		private WeakReference m_OwnerCameraWeakRef; // 0x80
		private static Dictionary<int, DynamicResolutionHandler> s_CameraInstances; // 0x18
		private static DynamicResolutionHandler s_DefaultInstance; // 0x20
		private static int s_ActiveCameraId; // 0x28
		private static DynamicResolutionHandler s_ActiveInstance; // 0x30
		private static bool s_ActiveInstanceDirty; // 0x38
		private static float s_GlobalHwFraction; // 0x3C
		private static bool s_GlobalHwUpresActive; // 0x40
		private UpsamplerScheduleType m_UpsamplerSchedule; // 0x88
	
		// Properties
		public DynamicResUpscaleFilter filter { get; private set; } // 0x0000000183D4F170-0x0000000183D4F180 0x0000000183D4F180-0x0000000183D4F190
		public Vector2Int finalViewport { get; set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000183D4EDA0-0x0000000183D4EDB0
		public bool runUpscalerFilterOnFullResolution { get => default; set {} } // 0x0000000189CA2574-0x0000000189CA2588 0x0000000183D4F2B0-0x0000000183D4F2C0
		public UpsamplerScheduleType upsamplerSchedule { get => default; set {} } // 0x0000000183D4F0B0-0x0000000183D4F0C0 0x0000000183D4F0E0-0x0000000183D4F0F0
		public static DynamicResolutionHandler instance { get => default; } // 0x0000000189CA2524-0x0000000189CA2574 
	
		// Nested types
		private struct ScalerContainer // TypeDefIndex: 53419
		{
			// Fields
			public DynamicResScalePolicyType type; // 0x00
			public PerformDynamicRes method; // 0x08
		}
	
		public enum UpsamplerScheduleType // TypeDefIndex: 53420
		{
			BeforePost = 0,
			AfterPost = 1
		}
	
		// Constructors
		private DynamicResolutionHandler() {} // 0x00000001837242C0-0x0000000183724310
		static DynamicResolutionHandler() {} // 0x0000000183723F10-0x0000000183724230
	
		// Methods
		private void Reset() {} // 0x00000001837244F0-0x0000000183724540
		private bool FlushScalableBufferManagerState() => default; // 0x0000000189CA15BC-0x0000000189CA16C8
		private static DynamicResolutionHandler GetOrCreateDrsInstanceHandler(Camera camera) => default; // 0x0000000189CA16E4-0x0000000189CA1BB0
		private static float DefaultDynamicResMethod() => default; // 0x0000000183D51A60-0x0000000183D51A70
		private void ProcessSettings(GlobalDynamicResolutionSettings settings) {} // 0x0000000189CA1C10-0x0000000189CA1DD8
		public Vector2 GetResolvedScale() => default; // 0x0000000189CA1BB0-0x0000000189CA1C10
		public float CalculateMipBias(Vector2Int inputResolution, Vector2Int outputResolution, bool forceApply = false /* Metadata: 0x01FD451B */) => default; // 0x00000001830FEC10-0x00000001830FEC80
		public static void SetDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor /* Metadata: 0x01FD451C */) {} // 0x0000000189CA1E40-0x0000000189CA1ED4
		public static void SetSystemDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor /* Metadata: 0x01FD451D */) {} // 0x0000000189CA1ED4-0x0000000189CA1F68
		public static void SetActiveDynamicScalerSlot(DynamicResScalerSlot slot) {} // 0x0000000189CA1DEC-0x0000000189CA1E40
		public static void ClearSelectedCamera() {} // 0x00000001830A9260-0x00000001830A9300
		public static void SetUpscaleFilter(Camera camera, DynamicResUpscaleFilter filter) {} // 0x0000000189CA1F68-0x0000000189CA207C
		public void SetCurrentCameraRequest(bool cameraRequest) {} // 0x0000000183D4F080-0x0000000183D4F090
		public static void UpdateAndUseCamera(Camera camera, GlobalDynamicResolutionSettings? settings = default, Action OnResolutionChange = null) {} // 0x0000000189CA20C8-0x0000000189CA22A0
		public void Update(GlobalDynamicResolutionSettings settings, Action OnResolutionChange = null) {} // 0x0000000189CA22A0-0x0000000189CA2524
		public bool SoftwareDynamicResIsEnabled() => default; // 0x0000000189CA207C-0x0000000189CA20C8
		public bool HardwareDynamicResIsEnabled() => default; // 0x0000000183CFE790-0x0000000183CFE7B0
		public bool RequestsHardwareDynamicResolution() => default; // 0x0000000189CA1DD8-0x0000000189CA1DEC
		public bool DynamicResolutionEnabled() => default; // 0x0000000189CA1588-0x0000000189CA15BC
		public void ForceSoftwareFallback() {} // 0x0000000183D75F20-0x0000000183D75F30
		public Vector2Int GetScaledSize(Vector2Int size) => default; // 0x00000001831EBE00-0x00000001831EBE20
		public Vector2Int ApplyScalesOnSize(Vector2Int size) => default; // 0x0000000189CA14A0-0x0000000189CA14D4
		internal Vector2Int ApplyScalesOnSize(Vector2Int size, Vector2 scales) => default; // 0x0000000189CA14D4-0x0000000189CA1588
		public float GetCurrentScale() => default; // 0x0000000189CA16C8-0x0000000189CA16E4
		public Vector2Int GetLastScaledSize() => default; // 0x0000000183D83F40-0x0000000183D83F50
		public float GetLowResMultiplier(float targetLowRes) => default; // 0x0000000183184D30-0x0000000183184D80
	}

	public enum DynamicResolutionType : byte // TypeDefIndex: 53422
	{
		Software = 0,
		Hardware = 1
	}

	public enum DynamicResUpscaleFilter : byte // TypeDefIndex: 53423
	{
		Bilinear = 0,
		CatmullRom = 1,
		Lanczos = 2,
		ContrastAdaptiveSharpen = 3,
		EdgeAdaptiveScalingUpres = 4,
		TAAU = 5
	}

	[Serializable]
	public struct GlobalDynamicResolutionSettings // TypeDefIndex: 53424
	{
		// Fields
		public bool enabled; // 0x00
		public bool useMipBias; // 0x01
		public bool enableDLSS; // 0x02
		public uint DLSSPerfQualitySetting; // 0x04
		public bool DLSSUseOptimalSettings; // 0x08
		[Range(0f, 1f)]
		public float DLSSSharpness; // 0x0C
		public float maxPercentage; // 0x10
		public float minPercentage; // 0x14
		public DynamicResolutionType dynResType; // 0x18
		public DynamicResUpscaleFilter upsampleFilter; // 0x19
		public bool forceResolution; // 0x1A
		public float forcedPercentage; // 0x1C
		public float lowResTransparencyMinimumThreshold; // 0x20
		public float rayTracingHalfResThreshold; // 0x24
	
		// Methods
		public static GlobalDynamicResolutionSettings NewDefault() => default; // 0x00000001837244A0-0x00000001837244F0
	}

	public interface IAdditionalData // TypeDefIndex: 53425
	{
	}

	public interface IVirtualTexturingEnabledRenderPipeline // TypeDefIndex: 53426
	{
		// Properties
		bool virtualTexturingEnabled { get; }
	}

	public struct ListBuffer<T> // TypeDefIndex: 53427
		where T : struct
	{
		// Fields
		private unsafe T* m_BufferPtr;
		private int m_Capacity;
		private unsafe int* m_CountPtr;
	
		// Properties
		internal unsafe T* BufferPtr { get => default; }
		public int Count { get => default; }
		public int Capacity { get => default; }
		public ref T this[[IsReadOnly] in int index] { get => default; }
	
		// Constructors
		public unsafe ListBuffer(T* bufferPtr, int* countPtr, int capacity) : this() {
			m_BufferPtr = default;
			m_Capacity = default;
			m_CountPtr = default;
		}
	
		// Methods
		public ref ref T GetUnchecked([IsReadOnly] in int index) => ref _refReturnTypeForGetUnchecked;
		private ref T _refReturnTypeForGetUnchecked; // Dummy field
		public bool TryAdd([IsReadOnly] in ref T value) => default;
		public unsafe void CopyTo(T* dstBuffer, int startDstIndex, int copyCount) {}
		public bool TryCopyTo(ListBuffer<T> other) => default;
		public unsafe bool TryCopyFrom(T* srcPtr, int count) => default;
	}

	public static class ListBufferExtensions // TypeDefIndex: 53428
	{
		// Extension methods
		public static void QuickSort<T>(this ListBuffer<T> self)
			where T : struct, IComparable<T> {}
	}

	public class ObjectPool<T> // TypeDefIndex: 53430
		where T : new()
	{
		// Fields
		private readonly Stack<T> m_Stack;
		private readonly UnityAction<T> m_ActionOnGet;
		private readonly UnityAction<T> m_ActionOnRelease;
		private readonly bool m_CollectionCheck;
	
		// Properties
		public int countAll { get; private set; }
		public int countActive { get => default; }
		public int countInactive { get => default; }
	
		// Nested types
		public struct PooledObject : IDisposable // TypeDefIndex: 53429
		{
			// Fields
			private readonly T m_ToReturn;
			private readonly ObjectPool<T> m_Pool;
	
			// Constructors
			internal PooledObject(T value, ObjectPool<T> pool) {
				m_ToReturn = default;
				m_Pool = default;
			}
	
			// Methods
			void IDisposable.Dispose() {}
		}
	
		// Constructors
		public ObjectPool() {} // Dummy constructor
		public ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease, bool collectionCheck = true /* Metadata: 0x01FD4529 */) {}
	
		// Methods
		public T Get() => default;
		public PooledObject Get(out ref T v) {
			v = default;
			return default;
		}
		public void Release(T element) {}
	}

	public static class GenericPool<T> // TypeDefIndex: 53431
		where T : new()
	{
		// Fields
		private static readonly ObjectPool<T> s_Pool;
	
		// Constructors
		static GenericPool() {}
	
		// Methods
		public static T Get() => default;
		public static ObjectPool<T> Get(out ref T value) {
			value = default;
			return default;
		}
		public static void Release(T toRelease) {}
	}

	public static class UnsafeGenericPool<T> // TypeDefIndex: 53432
		where T : new()
	{
		// Fields
		private static readonly ObjectPool<T> s_Pool;
	
		// Constructors
		static UnsafeGenericPool() {}
	
		// Methods
		public static T Get() => default;
		public static ObjectPool<T> Get(out ref T value) {
			value = default;
			return default;
		}
		public static void Release(T toRelease) {}
	}

	public static class ListPool<T> // TypeDefIndex: 53434
	{
		// Fields
		private static readonly ObjectPool<List<T>> s_Pool;
	
		// Constructors
		static ListPool() {}
	
		// Methods
		public static List<T> Get() => default;
		public static ObjectPool<List<T>> Get(out List<T> value) {
			value = default;
			return default;
		}
		public static void Release(List<T> toRelease) {}
	}

	public static class HashSetPool<T> // TypeDefIndex: 53436
	{
		// Fields
		private static readonly ObjectPool<HashSet<T>> s_Pool;
	
		// Constructors
		static HashSetPool() {}
	
		// Methods
		public static HashSet<T> Get() => default;
		public static ObjectPool<HashSet<T>> Get(out HashSet<T> value) {
			value = default;
			return default;
		}
		public static void Release(HashSet<T> toRelease) {}
	}

	public static class DictionaryPool<TKey, TValue> // TypeDefIndex: 53438
	{
		// Fields
		private static readonly ObjectPool<Dictionary<TKey, TValue>> s_Pool;
	
		// Constructors
		static DictionaryPool() {}
	
		// Methods
		public static Dictionary<TKey, TValue> Get() => default;
		public static ObjectPool<Dictionary<TKey, TValue>> Get(out Dictionary<TKey, TValue> value) {
			value = default;
			return default;
		}
		public static void Release(Dictionary<TKey, TValue> toRelease) {}
	}

	public sealed class ListChangedEventArgs<T> : EventArgs // TypeDefIndex: 53439
	{
		// Fields
		public readonly int index;
		public readonly T item;
	
		// Constructors
		public ListChangedEventArgs() {} // Dummy constructor
		public ListChangedEventArgs(int index, T item) {}
	}

	public delegate void ListChangedEventHandler<T>(ObservableList<T> sender, ListChangedEventArgs<T> e); // TypeDefIndex: 53440; 0x00000000-0x00000000

	public class ObservableList<T> : IList<T> // TypeDefIndex: 53441
	{
		// Fields
		private IList<T> m_List;
	
		// Properties
		public T this[int index] { get => default; set {} }
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
	
		// Events
		public event ListChangedEventHandler<T> ItemAdded;
		public event ListChangedEventHandler<T> ItemRemoved;
	
		// Constructors
		public ObservableList() {}
		public ObservableList(int capacity) {}
		public ObservableList(IEnumerable<T> collection) {}
	
		// Methods
		private void OnEvent(ListChangedEventHandler<T> e, int index, T item) {}
		public bool Contains(T item) => default;
		public int IndexOf(T item) => default;
		public void Add(T item) {}
		public void Add(params T[] items) {}
		public void Insert(int index, T item) {}
		public bool Remove(T item) => default;
		public int Remove(params T[] items) => default;
		public void RemoveAt(int index) {}
		public void Clear() {}
		public void CopyTo(T[] array, int arrayIndex) {}
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	[Serializable]
	public class SerializableEnum // TypeDefIndex: 53442
	{
		// Fields
		[SerializeField]
		private string m_EnumValueAsString; // 0x10
		[SerializeField]
		private System.Type m_EnumType; // 0x18
	
		// Properties
		public Enum value { get => default; set {} } // 0x0000000189CA8FA0-0x0000000189CA904C 0x0000000189CA904C-0x0000000189CA907C
	
		// Constructors
		public SerializableEnum() {} // Dummy constructor
		public SerializableEnum(System.Type enumType) {} // 0x0000000189CA8F1C-0x0000000189CA8FA0
	}

	[Serializable]
	public class SerializedDictionary<K, V> : SerializedDictionary<K, V, K, V> // TypeDefIndex: 53443
	{
		// Constructors
		public SerializedDictionary() {}
	
		// Methods
		public override K SerializeKey(K key) => default;
		public override V SerializeValue(V val) => default;
		public override K DeserializeKey(K key) => default;
		public override V DeserializeValue(V val) => default;
	}

	[Serializable]
	public abstract class SerializedDictionary<K, V, SK, SV> : Dictionary<K, V>, ISerializationCallbackReceiver // TypeDefIndex: 53444
	{
		// Fields
		[SerializeField]
		private List<SK> m_Keys;
		[SerializeField]
		private List<SV> m_Values;
	
		// Constructors
		protected SerializedDictionary() {}
	
		// Methods
		public abstract SK SerializeKey(K key);
		public abstract SV SerializeValue(V value);
		public abstract K DeserializeKey(SK serializedKey);
		public abstract V DeserializeValue(SV serializedValue);
		public void OnBeforeSerialize() {}
		public void OnAfterDeserialize() {}
	}

	[Serializable]
	public class XRGraphics // TypeDefIndex: 53446
	{
		// Properties
		public static float eyeTextureResolutionScale { get => default; set {} } // 0x0000000189CAAC84-0x0000000189CAACB0 0x0000000189CAADDC-0x0000000189CAADE4
		public static float renderViewportScale { get => default; } // 0x0000000189CAAD3C-0x0000000189CAAD68 
		public static bool enabled { get => default; } // 0x0000000189CAABEC-0x0000000189CAABF4 
		public static bool isDeviceActive { get => default; } // 0x0000000189CAACD4-0x0000000189CAACF8 
		public static string loadedDeviceName { get => default; } // 0x0000000189CAACF8-0x0000000189CAAD3C 
		public static string[] supportedDevices { get => default; } // 0x0000000189CAAD90-0x0000000189CAADDC 
		public static StereoRenderingMode stereoRenderingMode { get => default; } // 0x0000000189CAAD68-0x0000000189CAAD90 
		public static RenderTextureDescriptor eyeTextureDesc { get => default; } // 0x0000000189CAABF4-0x0000000189CAAC60 
		public static int eyeTextureWidth { get => default; } // 0x0000000189CAACB0-0x0000000189CAACD4 
		public static int eyeTextureHeight { get => default; } // 0x0000000189CAAC60-0x0000000189CAAC84 
	
		// Nested types
		public enum StereoRenderingMode // TypeDefIndex: 53445
		{
			MultiPass = 0,
			SinglePass = 1,
			SinglePassInstanced = 2,
			SinglePassMultiView = 3
		}
	
		// Constructors
		public XRGraphics() {} // 0x000000018350B670-0x000000018350B680
	}

	internal enum DebugAction // TypeDefIndex: 53447
	{
		EnableDebugMenu = 0,
		PreviousDebugPanel = 1,
		NextDebugPanel = 2,
		Action = 3,
		MakePersistent = 4,
		MoveVertical = 5,
		MoveHorizontal = 6,
		Multiplier = 7,
		ResetAll = 8,
		DebugActionCount = 9
	}

	internal enum DebugActionRepeatMode // TypeDefIndex: 53448
	{
		Never = 0,
		Delay = 1
	}

	public sealed class DebugManager // TypeDefIndex: 53450
	{
		// Fields
		private const string kEnableDebugBtn1 = "Enable Debug Button 1"; // Metadata: 0x01FD453D
		private const string kEnableDebugBtn2 = "Enable Debug Button 2"; // Metadata: 0x01FD4553
		private const string kDebugPreviousBtn = "Debug Previous"; // Metadata: 0x01FD4569
		private const string kDebugNextBtn = "Debug Next"; // Metadata: 0x01FD4578
		private const string kValidateBtn = "Debug Validate"; // Metadata: 0x01FD4583
		private const string kPersistentBtn = "Debug Persistent"; // Metadata: 0x01FD4592
		private const string kDPadVertical = "Debug Vertical"; // Metadata: 0x01FD45A3
		private const string kDPadHorizontal = "Debug Horizontal"; // Metadata: 0x01FD45B2
		private const string kMultiplierBtn = "Debug Multiplier"; // Metadata: 0x01FD45C3
		private const string kResetBtn = "Debug Reset"; // Metadata: 0x01FD45D4
		private const string kEnableDebug = "Enable Debug"; // Metadata: 0x01FD45E0
		private DebugActionDesc[] m_DebugActions; // 0x10
		private DebugActionState[] m_DebugActionStates; // 0x18
		private InputActionMap debugActionMap; // 0x20
		private static readonly Lazy<DebugManager> s_Instance; // 0x00
		private ReadOnlyCollection<DebugUI.Panel> m_ReadOnlyPanels; // 0x28
		private readonly List<DebugUI.Panel> m_Panels; // 0x30
		public bool refreshEditorRequested; // 0x50
		private int? m_RequestedPanelIndex; // 0x54
		private GameObject m_Root; // 0x60
		private DebugUIHandlerCanvas m_RootUICanvas; // 0x68
		private GameObject m_PersistentRoot; // 0x70
		private DebugUIHandlerPersistentCanvas m_RootUIPersistentCanvas; // 0x78
		private bool m_EditorOpen; // 0x80
		private bool m_EnableRuntimeUI; // 0x81
	
		// Properties
		public static DebugManager instance { get => default; } // 0x0000000182D17800-0x0000000182D17880 
		public ReadOnlyCollection<DebugUI.Panel> panels { get => default; } // 0x0000000189C9ED88-0x0000000189C9EDB0 
		public bool displayEditorUI { get => default; } // 0x0000000183D4F360-0x0000000183D4F370 
		public bool enableRuntimeUI { get => default; set {} } // 0x0000000183D5A210-0x0000000183D5A220 0x0000000182D17500-0x0000000182D17530
		public bool displayRuntimeUI { get => default; set {} } // 0x0000000182D17880-0x0000000182D17960 0x0000000183924CA0-0x0000000183924DA0
		public bool displayPersistentRuntimeUI { get => default; set {} } // 0x0000000189C9ED18-0x0000000189C9ED88 0x0000000183924C20-0x0000000183924CA0
	
		// Events
		public event Action<bool> onDisplayRuntimeUIChanged;
		public event Action onSetDirty;
		private event Action resetData;
	
		// Constructors
		private DebugManager() {} // 0x00000001838953C0-0x0000000183895640
		static DebugManager() {} // 0x0000000183B69000-0x0000000183B69110
	
		// Methods
		private void RegisterActions() {} // 0x0000000189C9D738-0x0000000189C9DB78
		internal void EnableInputActions() {} // 0x0000000189C9C96C-0x0000000189C9CA78
		private void AddAction(DebugAction action, DebugActionDesc desc) {} // 0x0000000189C9C87C-0x0000000189C9C94C
		private void SampleAction(int actionIndex) {} // 0x0000000189C9E828-0x0000000189C9E8F4
		private void UpdateAction(int actionIndex) {} // 0x0000000189C9EA4C-0x0000000189C9EAA4
		internal void UpdateActions() {} // 0x0000000189C9EAA4-0x0000000189C9EAF0
		internal float GetAction(DebugAction action) => default; // 0x0000000189C9CED0-0x0000000189C9CF08
		internal bool GetActionToggleDebugMenuWithTouch() => default; // 0x0000000189C9CD14-0x0000000189C9CED0
		internal bool GetActionReleaseScrollTarget() => default; // 0x0000000189C9CC48-0x0000000189C9CD14
		private void RegisterInputs() {} // 0x0000000189C9DBA8-0x0000000189C9E52C
		private void UpdateReadOnlyCollection() {} // 0x0000000189C9EAF0-0x0000000189C9EB64
		public void ToggleEditorUI(bool open) {} // 0x0000000183D4F380-0x0000000183D4F390
		public void RefreshEditor() {} // 0x0000000183D75180-0x0000000183D75190
		public void Reset() {} // 0x0000000189C9E800-0x0000000189C9E828
		public void ReDrawOnScreenDebug() {} // 0x0000000189C9D70C-0x0000000189C9D738
		public void RegisterData(IDebugData data) {} // 0x0000000189C9DB78-0x0000000189C9DBA8
		public void UnregisterData(IDebugData data) {} // 0x0000000189C9EA1C-0x0000000189C9EA4C
		public int GetState() => default; // 0x0000000189C9D5B8-0x0000000189C9D6F0
		internal void RegisterRootCanvas(DebugUIHandlerCanvas root) {} // 0x0000000189C9E52C-0x0000000189C9E578
		internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext) {} // 0x0000000189C9C94C-0x0000000189C9C96C
		internal void SetScrollTarget(DebugUIHandlerWidget widget) {} // 0x0000000189C9E8F4-0x0000000189C9E970
		private void EnsurePersistentCanvas() {} // 0x0000000189C9CA78-0x0000000189C9CC48
		internal void TogglePersistent(DebugUI.Widget widget) {} // 0x0000000189C9E970-0x0000000189C9EA1C
		private void OnPanelDirty(DebugUI.Panel panel) {} // 0x0000000189C9D6F0-0x0000000189C9D70C
		public void RequestEditorWindowPanelIndex(int index) {} // 0x0000000189C9E7AC-0x0000000189C9E800
		internal int? GetRequestedEditorWindowPanelIndex() => default; // 0x0000000183D83F30-0x0000000183D83F40
		public DebugUI.Panel GetPanel(string displayName, bool createIfNull = false /* Metadata: 0x01FD453A */, int groupIndex = 0 /* Metadata: 0x01FD453B */, bool overrideIfExist = false /* Metadata: 0x01FD453C */) => default; // 0x0000000189C9D1EC-0x0000000189C9D5B8
		public void RemovePanel(string displayName) {} // 0x0000000189C9E578-0x0000000189C9E748
		public void RemovePanel(DebugUI.Panel panel) {} // 0x0000000189C9E748-0x0000000189C9E7AC
		public DebugUI.Widget GetItem(string queryPath) => default; // 0x0000000189C9D0C0-0x0000000189C9D1EC
		private DebugUI.Widget GetItem(string queryPath, DebugUI.IContainer container) => default; // 0x0000000189C9CF08-0x0000000189C9D0C0
	}

	internal class DebugActionDesc // TypeDefIndex: 53451
	{
		// Fields
		public InputAction buttonAction; // 0x10
		public DebugActionRepeatMode repeatMode; // 0x18
		public float repeatDelay; // 0x1C
	
		// Constructors
		public DebugActionDesc() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class DebugActionState // TypeDefIndex: 53453
	{
		// Fields
		private DebugActionKeyType m_Type; // 0x10
		private InputAction inputAction; // 0x18
		private bool[] m_TriggerPressedUp; // 0x20
		private float m_Timer; // 0x28
	
		// Properties
		internal bool runningAction { get; private set; } // 0x0000000183D4F1A0-0x0000000183D4F1B0 0x0000000183D4F1B0-0x0000000183D4F1C0
		internal float actionState { get; private set; } // 0x0000000183D4F5D0-0x0000000183D4F5E0 0x0000000183D4F5E0-0x0000000183D4F5F0
	
		// Nested types
		private enum DebugActionKeyType // TypeDefIndex: 53452
		{
			Button = 0,
			Axis = 1,
			Key = 2
		}
	
		// Constructors
		public DebugActionState() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private void Trigger(int triggerCount, float state) {} // 0x0000000189C9C6B8-0x0000000189C9C754
		public void TriggerWithButton(InputAction action, float state) {} // 0x0000000189C9C634-0x0000000189C9C6B8
		private void Reset() {} // 0x0000000189C9C61C-0x0000000189C9C634
		public void Update(DebugActionDesc desc) {} // 0x0000000189C9C754-0x0000000189C9C87C
	}

	public interface IDebugData // TypeDefIndex: 53454
	{
		// Methods
		Action GetReset();
	}

	public class DebugShapes // TypeDefIndex: 53455
	{
		// Fields
		private static DebugShapes s_Instance; // 0x00
		private Mesh m_sphereMesh; // 0x10
		private Mesh m_boxMesh; // 0x18
		private Mesh m_coneMesh; // 0x20
		private Mesh m_pyramidMesh; // 0x28
	
		// Properties
		public static DebugShapes instance { get => default; } // 0x0000000189CA141C-0x0000000189CA14A0 
	
		// Constructors
		public DebugShapes() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private void BuildSphere(ref Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv) {} // 0x0000000189CA0C88-0x0000000189CA12E8
		private void BuildBox(ref Mesh outputMesh, float length, float width, float height) {} // 0x0000000189C9EF64-0x0000000189C9FBA4
		private void BuildCone(ref Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides) {} // 0x0000000189C9FBA4-0x0000000189CA05EC
		private void BuildPyramid(ref Mesh outputMesh, float width, float height, float depth) {} // 0x0000000189CA05EC-0x0000000189CA0AFC
		private void BuildShapes() {} // 0x0000000189CA0AFC-0x0000000189CA0C88
		private void RebuildResources() {} // 0x0000000189CA12E8-0x0000000189CA13AC
		public Mesh RequestSphereMesh() => default; // 0x0000000189CA1400-0x0000000189CA141C
		public Mesh RequestBoxMesh() => default; // 0x0000000189CA13AC-0x0000000189CA13C8
		public Mesh RequestConeMesh() => default; // 0x0000000189CA13C8-0x0000000189CA13E4
		public Mesh RequestPyramidMesh() => default; // 0x0000000189CA13E4-0x0000000189CA1400
	}

	public class DebugUI // TypeDefIndex: 53490
	{
		// Nested types
		public class Container : Widget, IContainer // TypeDefIndex: 53456
		{
			// Properties
			public ObservableList<Widget> children { get; private set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
			public override Panel panel { get => default; internal set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x0000000189C9B998-0x0000000189C9BAD4
	
			// Constructors
			public Container() {} // 0x0000000189C9B724-0x0000000189C9B88C
			public Container(string displayName, ObservableList<Widget> children) {} // 0x0000000189C9B88C-0x0000000189C9B998
	
			// Methods
			internal override void GenerateQueryPath() {} // 0x0000000189C9B3D0-0x0000000189C9B4F8
			protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) {} // 0x0000000189C9B65C-0x0000000189C9B6C0
			protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) {} // 0x0000000189C9B6C0-0x0000000189C9B724
			public override int GetHashCode() => default; // 0x0000000189C9B4F8-0x0000000189C9B65C
		}
	
		public class Foldout : Container, IValueField // TypeDefIndex: 53458
		{
			// Fields
			public bool opened; // 0x50
			public bool isHeader; // 0x51
			public List<ContextMenuItem> contextMenuItems; // 0x58
	
			// Properties
			public bool isReadOnly { get => default; } // 0x000000018115F4C0-0x000000018115F530 
			public string[] columnLabels { get; set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
			public string[] columnTooltips { get; set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
	
			// Nested types
			public struct ContextMenuItem // TypeDefIndex: 53457
			{
				// Fields
				public string displayName; // 0x00
				public Action action; // 0x08
			}
	
			// Constructors
			public Foldout() {} // 0x0000000189CA2DB8-0x0000000189CA2DC0
			public Foldout(string displayName, ObservableList<Widget> children, string[] columnLabels = null, string[] columnTooltips = null) {} // 0x0000000189CA2DC0-0x0000000189CA2E04
	
			// Methods
			public bool GetValue() => default; // 0x0000000183D4F000-0x0000000183D4F010
			object UnityEngine.Rendering.DebugUI.IValueField.GetValue() => default; // 0x0000000189CA2D74-0x0000000189CA2DB8
			public void SetValue(object value) {} // 0x0000000189CA2D28-0x0000000189CA2D74
			public object ValidateValue(object value) => default; // 0x0000000183D51810-0x0000000183D51820
			public void SetValue(bool value) {} // 0x0000000183D4F030-0x0000000183D4F040
		}
	
		public class HBox : Container // TypeDefIndex: 53459
		{
			// Constructors
			public HBox() {} // 0x0000000189CA3CA8-0x0000000189CA3CF0
		}
	
		public class VBox : Container // TypeDefIndex: 53460
		{
			// Constructors
			public VBox() {} // 0x0000000189CAA9BC-0x0000000189CAAA04
		}
	
		public class Table : Container // TypeDefIndex: 53462
		{
			// Fields
			public bool isReadOnly; // 0x50
			private bool[] m_Header; // 0x58
	
			// Properties
			public bool[] VisibleColumns { get => default; } // 0x0000000189CA9358-0x0000000189CA9568 
	
			// Nested types
			public class Row : Foldout // TypeDefIndex: 53461
			{
				// Constructors
				public Row() {} // 0x0000000189CA8ED4-0x0000000189CA8F1C
			}
	
			// Constructors
			public Table() {} // 0x0000000189CA9310-0x0000000189CA9358
	
			// Methods
			public void SetColumnVisibility(int index, bool visible) {} // 0x0000000189CA92CC-0x0000000189CA9310
			public bool GetColumnVisibility(int index) => default; // 0x0000000189CA923C-0x0000000189CA927C
			protected override void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) {} // 0x0000000189CA927C-0x0000000189CA92A4
			protected override void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) {} // 0x0000000189CA92A4-0x0000000189CA92CC
		}
	
		[Flags]
		public enum Flags // TypeDefIndex: 53463
		{
			None = 0,
			EditorOnly = 2,
			RuntimeOnly = 4,
			EditorForceUpdate = 8
		}
	
		public abstract class Widget // TypeDefIndex: 53465
		{
			// Fields
			protected Panel m_Panel; // 0x10
			protected IContainer m_Parent; // 0x18
			public Func<bool> isHiddenCallback; // 0x40
	
			// Properties
			public virtual Panel panel { get; internal set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
			public virtual IContainer parent { get; internal set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
			public Flags flags { get; set; } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
			public string displayName { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
			public string tooltip { get; set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
			public string queryPath { get; private set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
			public bool isEditorOnly { get; } // 0x0000000189CAAB70-0x0000000189CAAB78 
			public bool isRuntimeOnly { get; } // 0x0000000189CAABB4-0x0000000189CAABC0 
			public bool isInactiveInEditor { get; } // 0x0000000189CAAB98-0x0000000189CAABB4 
			public bool isHidden { get; } // 0x0000000189CAAB78-0x0000000189CAAB98 
			public NameAndTooltip nameAndTooltip { get; set; } // 0x0000000189CAABC0-0x0000000189CAABEC
	
			// Nested types
			public struct NameAndTooltip // TypeDefIndex: 53464
			{
				// Fields
				public string name; // 0x00
				public string tooltip; // 0x08
			}
	
			// Constructors
			protected Widget() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			internal virtual void GenerateQueryPath() {} // 0x0000000189CAAA6C-0x0000000189CAAB4C
			public override int GetHashCode() => default; // 0x0000000189CAAB4C-0x0000000189CAAB70
		}
	
		public interface IContainer // TypeDefIndex: 53466
		{
			// Properties
			ObservableList<Widget> children { get; }
			string displayName { get; set; }
			string queryPath { get; }
		}
	
		public interface IValueField // TypeDefIndex: 53467
		{
			// Methods
			object GetValue();
			void SetValue(object value);
			object ValidateValue(object value);
		}
	
		public class Button : Widget // TypeDefIndex: 53468
		{
			// Properties
			public Action action { get; set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
	
			// Constructors
			public Button() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class Value : Widget // TypeDefIndex: 53469
		{
			// Fields
			public float refreshRate; // 0x50
	
			// Properties
			public Func<object> getter { get; set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
	
			// Constructors
			public Value() {} // 0x0000000189CAAA24-0x0000000189CAAA6C
	
			// Methods
			public object GetValue() => default; // 0x0000000189CAAA04-0x0000000189CAAA24
		}
	
		public abstract class Field<T> : Widget, IValueField // TypeDefIndex: 53470
		{
			// Fields
			public Action<Field<T>, T> onValueChanged;
	
			// Properties
			public Func<T> getter { get; set; }
			public Action<T> setter { get; set; }
	
			// Constructors
			protected Field() {}
	
			// Methods
			object UnityEngine.Rendering.DebugUI.IValueField.ValidateValue(object value) => default;
			public virtual T ValidateValue(T value) => default;
			object UnityEngine.Rendering.DebugUI.IValueField.GetValue() => default;
			public T GetValue() => default;
			public void SetValue(object value) {}
			public void SetValue(T value) {}
		}
	
		public class BoolField : Field<bool> // TypeDefIndex: 53471
		{
			// Constructors
			public BoolField() {} // 0x0000000189C99AE8-0x0000000189C99B10
		}
	
		public class HistoryBoolField : BoolField // TypeDefIndex: 53472
		{
			// Properties
			public Func<bool>[] historyGetter { get; set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
			public int historyDepth { get => default; } // 0x0000000189CA3D30-0x0000000189CA3D40 
	
			// Constructors
			public HistoryBoolField() {} // 0x0000000189CA3D28-0x0000000189CA3D30
	
			// Methods
			public bool GetHistoryValue(int historyIndex) => default; // 0x0000000189CA3CF0-0x0000000189CA3D28
		}
	
		public class IntField : Field<int> // TypeDefIndex: 53473
		{
			// Fields
			public Func<int> min; // 0x60
			public Func<int> max; // 0x68
			public int incStep; // 0x70
			public int intStepMult; // 0x74
	
			// Constructors
			public IntField() {} // 0x0000000189CA3E4C-0x0000000189CA3E98
	
			// Methods
			public override int ValidateValue(int value) => default; // 0x0000000189CA3DFC-0x0000000189CA3E4C
		}
	
		public class UIntField : Field<uint> // TypeDefIndex: 53474
		{
			// Fields
			public Func<uint> min; // 0x60
			public Func<uint> max; // 0x68
			public uint incStep; // 0x70
			public uint intStepMult; // 0x74
	
			// Constructors
			public UIntField() {} // 0x0000000189CAA970-0x0000000189CAA9BC
	
			// Methods
			public override uint ValidateValue(uint value) => default; // 0x0000000189CAA920-0x0000000189CAA970
		}
	
		public class FloatField : Field<float> // TypeDefIndex: 53475
		{
			// Fields
			public Func<float> min; // 0x60
			public Func<float> max; // 0x68
			public float incStep; // 0x70
			public float incStepMult; // 0x74
			public int decimals; // 0x78
	
			// Constructors
			public FloatField() {} // 0x0000000189CA2CE8-0x0000000189CA2D28
	
			// Methods
			public override float ValidateValue(float value) => default; // 0x0000000189CA2C9C-0x0000000189CA2CE8
		}
	
		private static class EnumUtility // TypeDefIndex: 53477
		{
			// Methods
			internal static GUIContent[] MakeEnumNames(System.Type enumType) => default; // 0x0000000189CA2920-0x0000000189CA2A5C
			internal static int[] MakeEnumValues(System.Type enumType) => default; // 0x0000000189CA2A5C-0x0000000189CA2B40
		}
	
		public class EnumField : Field<int> // TypeDefIndex: 53479
		{
			// Fields
			public GUIContent[] enumNames; // 0x60
			public int[] enumValues; // 0x68
			internal int[] quickSeparators; // 0x70
			internal int[] indexes; // 0x78
	
			// Properties
			public Func<int> getIndex { get; set; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x00000001851DFC94-0x00000001851DFCA4
			public Action<int> setIndex { get; set; } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000184274DA0-0x0000000184274DB4
			public int currentIndex { get => default; set {} } // 0x0000000189CA287C-0x0000000189CA28A0 0x0000000189CA28FC-0x0000000189CA2920
			public System.Type autoEnum { set {} } // 0x0000000189CA28A0-0x0000000189CA28FC
	
			// Constructors
			public EnumField() {} // 0x0000000189CA2854-0x0000000189CA287C
	
			// Methods
			internal void InitQuickSeparators() {} // 0x0000000189CA2640-0x0000000189CA2854
			internal void InitIndexes() {} // 0x0000000189CA2588-0x0000000189CA2640
		}
	
		public class HistoryEnumField : EnumField // TypeDefIndex: 53480
		{
			// Properties
			public Func<int>[] historyIndexGetter { get; set; } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x00000001851DFCB4-0x00000001851DFCC8
			public int historyDepth { get => default; } // 0x0000000189CA3D84-0x0000000189CA3D98 
	
			// Constructors
			public HistoryEnumField() {} // 0x0000000189CA3D7C-0x0000000189CA3D84
	
			// Methods
			public int GetHistoryValue(int historyIndex) => default; // 0x0000000189CA3D40-0x0000000189CA3D7C
		}
	
		public class BitField : Field<Enum> // TypeDefIndex: 53481
		{
			// Fields
			private System.Type m_EnumType; // 0x70
	
			// Properties
			public GUIContent[] enumNames { get; private set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
			public int[] enumValues { get; private set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
			public System.Type enumType { get => default; set {} } // 0x0000000183D4EB30-0x0000000183D4EB40 0x0000000189C99A90-0x0000000189C99AE8
	
			// Constructors
			public BitField() {} // 0x0000000189C99A68-0x0000000189C99A90
		}
	
		public class ColorField : Field<UnityEngine.Color> // TypeDefIndex: 53482
		{
			// Fields
			public bool hdr; // 0x60
			public bool showAlpha; // 0x61
			public bool showPicker; // 0x62
			public float incStep; // 0x64
			public float incStepMult; // 0x68
			public int decimals; // 0x6C
	
			// Constructors
			public ColorField() {} // 0x0000000189C9A444-0x0000000189C9A48C
	
			// Methods
			public override UnityEngine.Color ValidateValue(UnityEngine.Color value) => default; // 0x0000000189C9A3E8-0x0000000189C9A444
		}
	
		public class Vector2Field : Field<Vector2> // TypeDefIndex: 53483
		{
			// Fields
			public float incStep; // 0x60
			public float incStepMult; // 0x64
			public int decimals; // 0x68
	
			// Constructors
			public Vector2Field() {} // 0x0000000189CBB880-0x0000000189CBB8C0
		}
	
		public class Vector3Field : Field<Vector3> // TypeDefIndex: 53484
		{
			// Fields
			public float incStep; // 0x60
			public float incStepMult; // 0x64
			public int decimals; // 0x68
	
			// Constructors
			public Vector3Field() {} // 0x0000000189CBB8C0-0x0000000189CBB900
		}
	
		public class Vector4Field : Field<Vector4> // TypeDefIndex: 53485
		{
			// Fields
			public float incStep; // 0x60
			public float incStepMult; // 0x64
			public int decimals; // 0x68
	
			// Constructors
			public Vector4Field() {} // 0x0000000189CBB900-0x0000000189CBB940
		}
	
		public class MessageBox : Widget // TypeDefIndex: 53487
		{
			// Fields
			public Style style; // 0x48
	
			// Nested types
			public enum Style // TypeDefIndex: 53486
			{
				Info = 0,
				Warning = 1,
				Error = 2
			}
	
			// Constructors
			public MessageBox() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class Panel : IContainer, IComparable<Panel> // TypeDefIndex: 53489
		{
			// Properties
			public Flags flags { get; set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
			public string displayName { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
			public int groupIndex { get; set; } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
			public string queryPath { get => default; } // 0x0000000181041090-0x00000001810410A0 
			public bool isEditorOnly { get => default; } // 0x000000018286E960-0x000000018286E970 
			public bool isRuntimeOnly { get => default; } // 0x0000000189CB47D4-0x0000000189CB47DC 
			public bool isInactiveInEditor { get => default; } // 0x0000000189CB47B8-0x0000000189CB47D4 
			public bool editorForceUpdate { get => default; } // 0x0000000189CB47B0-0x0000000189CB47B8 
			public ObservableList<Widget> children { get; private set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
	
			// Events
			public event Action<Panel> onSetDirty;
	
			// Constructors
			public Panel() {} // 0x0000000189CB4514-0x0000000189CB4724
	
			// Methods
			protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) {} // 0x0000000189CB42E0-0x0000000189CB4338
			protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) {} // 0x0000000189CB4338-0x0000000189CB4394
			public void SetDirty() {} // 0x0000000189CB4394-0x0000000189CB44E8
			public override int GetHashCode() => default; // 0x0000000189CB417C-0x0000000189CB42E0
			int System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(Panel other) => default; // 0x0000000189CB44E8-0x0000000189CB4514
		}
	
		// Constructors
		public DebugUI() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class DebugUpdater : MonoBehaviour // TypeDefIndex: 53493
	{
		// Fields
		private static DebugUpdater s_Instance; // 0x00
		private ScreenOrientation m_Orientation; // 0x18
		private bool m_RuntimeUiWasVisibleLastFrame; // 0x1C
	
		// Constructors
		public DebugUpdater() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void RuntimeInit() {} // 0x000000018350B670-0x000000018350B680
		internal static void SetEnabled(bool enabled) {} // 0x0000000183924B30-0x0000000183924B50
		private static void EnableRuntime() {} // 0x0000000189CAD5F4-0x0000000189CAD760
		private static void DisableRuntime() {} // 0x0000000183924B50-0x0000000183924C20
		internal static void HandleInternalEventSystemComponents(bool uiEnabled) {} // 0x0000000183924DA0-0x0000000183924E20
		private void EnsureExactlyOneEventSystem() {} // 0x0000000189CAD760-0x0000000189CAD8EC
		[IteratorStateMachine(typeof(_DoAfterInputModuleUpdated_d__9))]
		private IEnumerator DoAfterInputModuleUpdated(Action action) => default; // 0x0000000189CAD598-0x0000000189CAD5F4
		private void CheckInputModuleExists() {} // 0x0000000189CAD2B0-0x0000000189CAD388
		private void AssignDefaultActions() {} // 0x0000000189CAD190-0x0000000189CAD2B0
		private void CreateDebugEventSystem() {} // 0x0000000189CAD388-0x0000000189CAD468
		private void DestroyDebugEventSystem() {} // 0x0000000189CAD468-0x0000000189CAD598
		private void Update() {} // 0x0000000189CAD930-0x0000000189CADA84
		[IteratorStateMachine(typeof(_RefreshRuntimeUINextFrame_d__15))]
		private static IEnumerator RefreshRuntimeUINextFrame() => default; // 0x0000000189CAD8EC-0x0000000189CAD930
	}

	public class MousePositionDebug // TypeDefIndex: 53494
	{
		// Fields
		private static MousePositionDebug s_Instance; // 0x00
	
		// Properties
		public static MousePositionDebug instance { get => default; } // 0x0000000182D15F20-0x0000000182D15FB0 
	
		// Constructors
		public MousePositionDebug() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Build() {} // 0x000000018350B670-0x000000018350B680
		public void Cleanup() {} // 0x000000018350B670-0x000000018350B680
		public Vector2 GetMousePosition(float ScreenHeight, bool sceneView) => default; // 0x0000000189CB3F70-0x0000000189CB3F78
		private Vector2 GetInputMousePosition() => default; // 0x0000000189CB3F00-0x0000000189CB3F70
		public Vector2 GetMouseClickPosition(float ScreenHeight) => default; // 0x0000000183D5DE90-0x0000000183D5DEA0
	}

	internal class TProfilingSampler<TEnum> : ProfilingSampler // TypeDefIndex: 53495
		where TEnum : Enum
	{
		// Fields
		internal static Dictionary<TEnum, TProfilingSampler<TEnum>> samples;
	
		// Constructors
		public TProfilingSampler() {} // Dummy constructor
		static TProfilingSampler() {}
		public TProfilingSampler(string name) {}
	}

	public class ProfilingSampler // TypeDefIndex: 53496
	{
		// Fields
		private Recorder m_Recorder; // 0x28
		private Recorder m_InlineRecorder; // 0x30
	
		// Properties
		internal CustomSampler sampler { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		internal CustomSampler inlineSampler { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public string name { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public bool enableRecording { set {} } // 0x0000000189CB609C-0x0000000189CB60E0
		public float gpuElapsedTime { get => default; } // 0x0000000189CB5F7C-0x0000000189CB5FCC 
		public int gpuSampleCount { get => default; } // 0x0000000189CB5FCC-0x0000000189CB600C 
		public float cpuElapsedTime { get => default; } // 0x0000000189CB5EEC-0x0000000189CB5F3C 
		public int cpuSampleCount { get => default; } // 0x0000000189CB5F3C-0x0000000189CB5F7C 
		public float inlineCpuElapsedTime { get => default; } // 0x0000000189CB600C-0x0000000189CB605C 
		public int inlineCpuSampleCount { get => default; } // 0x0000000189CB605C-0x0000000189CB609C 
	
		// Constructors
		public ProfilingSampler(string name) {} // 0x0000000182E13740-0x0000000182E13870
		private ProfilingSampler() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static ProfilingSampler Get<TEnum>(TEnum marker)
			where TEnum : Enum => default;
		public void Begin(CommandBuffer cmd) {} // 0x0000000189CB5E64-0x0000000189CB5EA8
		public void End(CommandBuffer cmd) {} // 0x0000000189CB5EA8-0x0000000189CB5EEC
		internal bool IsValid() => default; // 0x00000001895ABC40-0x00000001895ABC54
	}

	public struct ProfilingScope : IDisposable // TypeDefIndex: 53497
	{
		// Constructors
		public ProfilingScope(CommandBuffer cmd, ProfilingSampler sampler) {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Dispose() {} // 0x000000018350B670-0x000000018350B680
	}

	[Obsolete("Please use ProfilingScope")]
	public struct ProfilingSample : IDisposable // TypeDefIndex: 53498
	{
		// Fields
		private readonly CommandBuffer m_Cmd; // 0x00
		private readonly string m_Name; // 0x08
		private bool m_Disposed; // 0x10
		private CustomSampler m_Sampler; // 0x18
	
		// Constructors
		public ProfilingSample(CommandBuffer cmd, string name, CustomSampler sampler = null) {
			m_Cmd = default;
			m_Name = default;
			m_Disposed = default;
			m_Sampler = default;
		} // 0x0000000189CB5D30-0x0000000189CB5DD4
		public ProfilingSample(CommandBuffer cmd, string format, object arg) {
			m_Cmd = default;
			m_Name = default;
			m_Disposed = default;
			m_Sampler = default;
		} // 0x0000000189CB5DD4-0x0000000189CB5E1C
		public ProfilingSample(CommandBuffer cmd, string format, params object[] args) {
			m_Cmd = default;
			m_Name = default;
			m_Disposed = default;
			m_Sampler = default;
		} // 0x0000000189CB5E1C-0x0000000189CB5E64
	
		// Methods
		public void Dispose() {} // 0x0000000189CB5D24-0x0000000189CB5D30
		private void Dispose(bool disposing) {} // 0x0000000189CB5CA4-0x0000000189CB5D24
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, AllowMultiple = false)]
	[Conditional("UNITY_EDITOR")]
	public class CoreRPHelpURLAttribute : HelpURLAttribute // TypeDefIndex: 53499
	{
		// Constructors
		public CoreRPHelpURLAttribute() {} // Dummy constructor
		public CoreRPHelpURLAttribute(string pageName, string packageName = "com.unity.render-pipelines.core" /* Metadata: 0x01FD45F7 */) {} // 0x0000000189CAD164-0x0000000189CAD190
	}

	public class DocumentationInfo // TypeDefIndex: 53500
	{
		// Fields
		private const string fallbackVersion = "12.1"; // Metadata: 0x01FD4617
		private const string url = "https://docs.unity3d.com/Packages/{0}@{1}/manual/{2}.html"; // Metadata: 0x01FD461C
	
		// Properties
		public static string version { get => default; } // 0x0000000189CADAE0-0x0000000189CADB0C 
	
		// Constructors
		public DocumentationInfo() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static string GetPageLink(string packageName, string pageName) => default; // 0x0000000189CADA84-0x0000000189CADAE0
	}

	public static class DocumentationUtils // TypeDefIndex: 53501
	{
		// Methods
		public static string GetHelpURL<TEnum>(TEnum mask = default)
			where TEnum : struct, IConvertible => default;
	}

	public enum APVConstantBufferRegister // TypeDefIndex: 53502
	{
		GlobalRegister = 5
	}

	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "F:\\Build\\Release_v1d2\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\Lighting\\ProbeVolume\\ShaderVariablesProbeVolumes.cs", needAccessors = false, generateCBuffer = true, constantRegister = 5)]
	internal struct ShaderVariablesProbeVolumes // TypeDefIndex: 53503
	{
		// Fields
		public Vector3 _PoolDim; // 0x00
		public float _ViewBias; // 0x0C
		public Vector3 _MinCellPosition; // 0x10
		public float _PVSamplingNoise; // 0x1C
		public Vector3 _CellIndicesDim; // 0x20
		public float _CellInMeters; // 0x2C
		public float _CellInMinBricks; // 0x30
		public float _MinBrickSize; // 0x34
		public int _IndexChunkSize; // 0x38
		public float _NormalBias; // 0x3C
	}

	[Serializable]
	public struct SphericalHarmonicsL1 // TypeDefIndex: 53504
	{
		// Fields
		public Vector4 shAr; // 0x00
		public Vector4 shAg; // 0x10
		public Vector4 shAb; // 0x20
		public static readonly SphericalHarmonicsL1 zero; // 0x00
	
		// Constructors
		static SphericalHarmonicsL1() {
			zero = default;
		} // 0x0000000189CB6D80-0x0000000189CB6DE8
	
		// Methods
		public static SphericalHarmonicsL1 operator +(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) => default; // 0x0000000189CB6DE8-0x0000000189CB6EA0
		public static SphericalHarmonicsL1 operator -(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) => default; // 0x0000000189CB71EC-0x0000000189CB72A4
		public static SphericalHarmonicsL1 operator *(SphericalHarmonicsL1 lhs, float rhs) => default; // 0x0000000189CB7160-0x0000000189CB71EC
		public static SphericalHarmonicsL1 operator /(SphericalHarmonicsL1 lhs, float rhs) => default; // 0x0000000189CB6EA0-0x0000000189CB6F88
		public static bool operator ==(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) => default; // 0x0000000189CB6F88-0x0000000189CB70CC
		public static bool operator !=(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) => default; // 0x0000000189CB70CC-0x0000000189CB7160
		public override bool Equals(object other) => default; // 0x0000000189CB6C4C-0x0000000189CB6D30
		public override int GetHashCode() => default; // 0x0000000189CB6D30-0x0000000189CB6D80
	}

	public class SphericalHarmonicsL2Utils // TypeDefIndex: 53505
	{
		// Constructors
		public SphericalHarmonicsL2Utils() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void GetL1(SphericalHarmonicsL2 sh, out Vector3 L1_R, out Vector3 L1_G, out Vector3 L1_B) {
			L1_R = default;
			L1_G = default;
			L1_B = default;
		} // 0x0000000189CB7328-0x0000000189CB744C
		public static void GetL2(SphericalHarmonicsL2 sh, out Vector3 L2_0, out Vector3 L2_1, out Vector3 L2_2, out Vector3 L2_3, out Vector3 L2_4) {
			L2_0 = default;
			L2_1 = default;
			L2_2 = default;
			L2_3 = default;
			L2_4 = default;
		} // 0x0000000189CB744C-0x0000000189CB7618
		public static void SetL0(ref SphericalHarmonicsL2 sh, Vector3 L0) {} // 0x0000000189CB768C-0x0000000189CB76F0
		public static void SetL1R(ref SphericalHarmonicsL2 sh, Vector3 L1_R) {} // 0x0000000189CB77C8-0x0000000189CB782C
		public static void SetL1G(ref SphericalHarmonicsL2 sh, Vector3 L1_G) {} // 0x0000000189CB775C-0x0000000189CB77C8
		public static void SetL1B(ref SphericalHarmonicsL2 sh, Vector3 L1_B) {} // 0x0000000189CB76F0-0x0000000189CB775C
		public static void SetL1(ref SphericalHarmonicsL2 sh, Vector3 L1_R, Vector3 L1_G, Vector3 L1_B) {} // 0x0000000189CB782C-0x0000000189CB78B4
		public static void SetCoefficient(ref SphericalHarmonicsL2 sh, int index, Vector3 coefficient) {} // 0x0000000189CB7618-0x0000000189CB768C
		public static Vector3 GetCoefficient(SphericalHarmonicsL2 sh, int index) => default; // 0x0000000189CB72A4-0x0000000189CB7328
	}

	public sealed class LensFlareCommonSRP // TypeDefIndex: 53511
	{
		// Fields
		private static LensFlareCommonSRP m_Instance; // 0x00
		private static readonly object m_Padlock; // 0x08
		private static List<LensFlareComponentSRP> m_Data; // 0x10
		public static int maxLensFlareWithOcclusion; // 0x18
		public static int maxLensFlareWithOcclusionTemporalSample; // 0x1C
		public static int mergeNeeded; // 0x20
		public static RTHandle occlusionRT; // 0x28
		private static int frameIdx; // 0x30
	
		// Properties
		public static LensFlareCommonSRP Instance { get => default; } // 0x0000000182DC6F70-0x0000000182DC7480 
		private List<LensFlareComponentSRP> Data { get => default; } // 0x0000000189CB3D18-0x0000000189CB3D68 
	
		// Nested types
		public struct SunSourceDirLightOverrideLensFlareData // TypeDefIndex: 53506
		{
			// Fields
			public bool enable; // 0x00
			public LensFlareDataSRP lensFlareData; // 0x08
			public float intensity; // 0x10
			public float scale; // 0x14
			public bool useOcclusion; // 0x18
			public float occlusionRadius; // 0x1C
			public uint sampleCount; // 0x20
			public float occlusionOffset; // 0x24
			public bool allowOffScreen; // 0x28
		}
	
		public struct SunSourceDirLightOverrideLightData // TypeDefIndex: 53507
		{
			// Fields
			public Quaternion rotationLensFlare; // 0x00
			public Vector3 dirLightFoward; // 0x10
			public UnityEngine.Color color; // 0x1C
		}
	
		public struct SunSourceDirLightOverrideInfo // TypeDefIndex: 53508
		{
			// Fields
			public GameObject dirLightGameObject; // 0x00
			public SunSourceDirLightOverrideLensFlareData flareData; // 0x08
			public SunSourceDirLightOverrideLightData lightData; // 0x38
		}
	
		// Constructors
		private LensFlareCommonSRP() {} // 0x000000018350B670-0x000000018350B680
		static LensFlareCommonSRP() {} // 0x0000000183B1D0F0-0x0000000183B1D280
	
		// Methods
		public static void Initialize() {} // 0x0000000189CB2970-0x0000000189CB2B04
		public static void Dispose() {} // 0x0000000189CAF3C0-0x0000000189CAF45C
		public List<LensFlareComponentSRP> GetData() => default; // 0x0000000184273B00-0x0000000184273B08
		public bool IsEmpty() => default; // 0x0000000182DC6C40-0x0000000182DC6CF0
		public void AddData(LensFlareComponentSRP newData) {} // 0x0000000189CAE1C0-0x0000000189CAE274
		public static float ShapeAttenuationPointLight() => default; // 0x0000000183D51A60-0x0000000183D51A70
		public static float ShapeAttenuationDirLight(Vector3 forward, Vector3 wo) => default; // 0x0000000189CB3090-0x0000000189CB30D4
		public static float ShapeAttenuationSpotConeLight(Vector3 forward, Vector3 wo, float spotAngle, float innerSpotPercent01) => default; // 0x0000000189CB311C-0x0000000189CB3210
		public static float ShapeAttenuationSpotBoxLight(Vector3 forward, Vector3 wo) => default; // 0x0000000189CB30D4-0x0000000189CB311C
		public static float ShapeAttenuationSpotPyramidLight(Vector3 forward, Vector3 wo) => default; // 0x0000000189CB3210-0x0000000189CB3294
		public static float ShapeAttenuationAreaTubeLight(Vector3 lightPositionWS, Vector3 lightSide, float lightWidth, Camera cam) => default; // 0x0000000189CB2C78-0x0000000189CB3090
		public static float ShapeAttenuationAreaRectangleLight(Vector3 forward, Vector3 wo) => default; // 0x0000000189CB2BFC-0x0000000189CB2C78
		public static float ShapeAttenuationAreaDiscLight(Vector3 forward, Vector3 wo) => default; // 0x0000000189CB2B80-0x0000000189CB2BFC
		public static Vector4 GetFlareData0(Vector2 screenPos, Vector2 translationScale, Vector2 rayOff0, Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, Vector2 positionOffset, bool autoRotate) => default; // 0x0000000189CB26A8-0x0000000189CB28E8
		public static Vector2 GetLensFlareRayOffset(Vector2 screenPos, float position, float globalCos0, float globalSin0) => default; // 0x0000000189CB28E8-0x0000000189CB2970
		public static Vector3 WorldToViewport(Camera camera, bool isLocalLight, bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 positionWS) => default; // 0x0000000189CB3BC0-0x0000000189CB3D18
		private static Vector3 WorldToViewportLocal(bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 cameraPosWS, Vector3 positionWS) => default; // 0x0000000189CB3A64-0x0000000189CB3BC0
		private static Vector3 WorldToViewportDistance(Camera cam, Vector3 positionWS) => default; // 0x0000000189CB38D8-0x0000000189CB3A64
		public static void ComputeOcclusion(Material lensFlareShader, LensFlareCommonSRP lensFlares, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4) {} // 0x0000000189CAE3A8-0x0000000189CAF3C0
		public static void DoLensFlareDataDrivenCommon(Material lensFlareShader, LensFlareCommonSRP lensFlares, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, RenderTargetIdentifier colorBuffer, Func<Light, Camera, Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugFullScreen, ComputeBuffer debugFullscreenBuffer, SunSourceDirLightOverrideInfo dirLightOverrideInfo) {} // 0x0000000189CAF45C-0x0000000189CB24EC
		public void RemoveData(LensFlareComponentSRP data) {} // 0x0000000182DC6AA0-0x0000000182DC6B40
		private static Vector2 DoPaniniProjection(Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance) => default; // 0x0000000189CB24EC-0x0000000189CB26A8
		private static Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView) => default; // 0x0000000189CAE35C-0x0000000189CAE3A8
		private static Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d) => default; // 0x0000000189CAE274-0x0000000189CAE35C
		private static Vector2 Panini_Generic_Inv(Vector2 projPos, float d) => default; // 0x0000000189CB2B04-0x0000000189CB2B80
	}

	[AddComponentMenu("Rendering/Lens Flare (SRP)")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public sealed class LensFlareComponentSRP : MonoBehaviour // TypeDefIndex: 53512
	{
		// Fields
		[SerializeField]
		private LensFlareDataSRP m_LensFlareData; // 0x18
		[Min(0f)]
		public float intensity; // 0x20
		[Min(1E-05f)]
		public float maxAttenuationDistance; // 0x24
		[Min(1E-05f)]
		public float maxAttenuationScale; // 0x28
		public AnimationCurve distanceAttenuationCurve; // 0x30
		public AnimationCurve scaleByDistanceCurve; // 0x38
		public bool attenuationByLightShape; // 0x40
		public AnimationCurve radialScreenAttenuationCurve; // 0x48
		public bool useOcclusion; // 0x50
		[Min(0f)]
		public float occlusionRadius; // 0x54
		[Range(1f, 64f)]
		public uint sampleCount; // 0x58
		public float occlusionOffset; // 0x5C
		[Min(0f)]
		public float scale; // 0x60
		public bool allowOffScreen; // 0x64
		public bool useCustomForward; // 0x65
		public Vector3 customForward; // 0x68
		private static float sCelestialAngularRadius; // 0x00
	
		// Properties
		public LensFlareDataSRP lensFlareData { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000189CB3EDC-0x0000000189CB3F00
	
		// Constructors
		public LensFlareComponentSRP() {} // 0x00000001838D1170-0x00000001838D1420
		static LensFlareComponentSRP() {} // 0x0000000183D443E0-0x0000000183D44420
	
		// Methods
		public float celestialProjectedOcclusionRadius(Camera mainCam) => default; // 0x0000000189CB3E2C-0x0000000189CB3EDC
		private void OnEnable() {} // 0x0000000182DC6B40-0x0000000182DC6BE0
		private void OnDisable() {} // 0x0000000182DC6BE0-0x0000000182DC6C40
		private void OnValidate() {} // 0x0000000189CB3D68-0x0000000189CB3E2C
	}

	[Serializable]
	public enum SRPLensFlareBlendMode // TypeDefIndex: 53513
	{
		Additive = 0,
		Screen = 1,
		Premultiply = 2,
		Lerp = 3
	}

	[Serializable]
	public enum SRPLensFlareDistribution // TypeDefIndex: 53514
	{
		Uniform = 0,
		Curve = 1,
		Random = 2
	}

	[Serializable]
	public enum SRPLensFlareType // TypeDefIndex: 53515
	{
		Image = 0,
		Circle = 1,
		Polygon = 2
	}

	[Serializable]
	public sealed class LensFlareDataElementSRP // TypeDefIndex: 53516
	{
		// Fields
		public bool visible; // 0x10
		public float position; // 0x14
		public Vector2 positionOffset; // 0x18
		public float angularOffset; // 0x20
		public Vector2 translationScale; // 0x24
		[FormerlySerializedAs("localIntensity")]
		[Min(0f)]
		[SerializeField]
		private float m_LocalIntensity; // 0x2C
		public Texture lensFlareTexture; // 0x30
		public float uniformScale; // 0x38
		public Vector2 sizeXY; // 0x3C
		public bool allowMultipleElement; // 0x44
		[FormerlySerializedAs("count")]
		[Min(1f)]
		[SerializeField]
		private int m_Count; // 0x48
		public bool preserveAspectRatio; // 0x4C
		public float rotation; // 0x50
		public UnityEngine.Color tint; // 0x54
		public SRPLensFlareBlendMode blendMode; // 0x64
		public bool autoRotate; // 0x68
		public SRPLensFlareType flareType; // 0x6C
		public bool modulateByLightColor; // 0x70
		[SerializeField]
		private bool isFoldOpened; // 0x71
		public SRPLensFlareDistribution distribution; // 0x74
		public float lengthSpread; // 0x78
		public AnimationCurve positionCurve; // 0x80
		public AnimationCurve scaleCurve; // 0x88
		public int seed; // 0x90
		public Gradient colorGradient; // 0x98
		[FormerlySerializedAs("intensityVariation")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_IntensityVariation; // 0xA0
		public Vector2 positionVariation; // 0xA4
		public float scaleVariation; // 0xAC
		public float rotationVariation; // 0xB0
		public bool enableRadialDistortion; // 0xB4
		public Vector2 targetSizeDistortion; // 0xB8
		public AnimationCurve distortionCurve; // 0xC0
		public bool distortionRelativeToCenter; // 0xC8
		[FormerlySerializedAs("fallOff")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_FallOff; // 0xCC
		[FormerlySerializedAs("edgeOffset")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_EdgeOffset; // 0xD0
		[FormerlySerializedAs("sideCount")]
		[Min(3f)]
		[SerializeField]
		private int m_SideCount; // 0xD4
		[FormerlySerializedAs("sdfRoundness")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_SdfRoundness; // 0xD8
		public bool inverseSDF; // 0xDC
		public float uniformAngle; // 0xE0
		public AnimationCurve uniformAngleCurve; // 0xE8
	
		// Properties
		public float localIntensity { get => default; set {} } // 0x0000000183D4F3A0-0x0000000183D4F3B0 0x000000018427151C-0x000000018427152C
		public int count { get => default; set {} } // 0x0000000183D4EC50-0x0000000183D4EC60 0x000000018427152C-0x000000018427153C
		public float intensityVariation { get => default; set {} } // 0x0000000183D58340-0x0000000183D58350 0x00000001842714A0-0x00000001842714B4
		public float fallOff { get => default; set {} } // 0x0000000183D58310-0x0000000183D58320 0x00000001842714B4-0x00000001842714D0
		public float edgeOffset { get => default; set {} } // 0x0000000183D57560-0x0000000183D57570 0x00000001842714D0-0x00000001842714EC
		public int sideCount { get => default; set {} } // 0x0000000183D50EB0-0x0000000183D50EC0 0x00000001842714EC-0x0000000184271500
		public float sdfRoundness { get => default; set {} } // 0x0000000183D598B0-0x0000000183D598C0 0x0000000184271500-0x000000018427151C
	
		// Constructors
		public LensFlareDataElementSRP() {} // 0x0000000182700110-0x0000000182700690
	}

	[Serializable]
	public sealed class LensFlareDataSRP : ScriptableObject // TypeDefIndex: 53517
	{
		// Fields
		public LensFlareDataElementSRP[] elements; // 0x18
	
		// Constructors
		public LensFlareDataSRP() {} // 0x0000000183D4A460-0x0000000183D4A490
	}

	public abstract class RenderPipelineResources : ScriptableObject // TypeDefIndex: 53518
	{
		// Properties
		protected virtual string packagePath { get; } // 0x0000000181002730-0x0000000181002740 
		internal string packagePath_Internal { get; } // 0x0000000184273A44-0x0000000184273A54 
	
		// Constructors
		protected RenderPipelineResources() {} // 0x000000018286F540-0x000000018286F550
	}

	public enum PackingRules // TypeDefIndex: 53519
	{
		Exact = 0,
		Aggressive = 1
	}

	public enum FieldPacking // TypeDefIndex: 53520
	{
		NoPacking = 0,
		R11G11B10 = 1,
		PackedFloat = 2,
		PackedUint = 3
	}

	public enum FieldPrecision // TypeDefIndex: 53521
	{
		Half = 0,
		Real = 1,
		Default = 2
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
	public class GenerateHLSL : Attribute // TypeDefIndex: 53522
	{
		// Fields
		public PackingRules packingRules; // 0x10
		public bool containsPackedFields; // 0x14
		public bool needAccessors; // 0x15
		public bool needSetters; // 0x16
		public bool needParamDebug; // 0x17
		public int paramDefinesStart; // 0x18
		public bool omitStructDeclaration; // 0x1C
		public bool generateCBuffer; // 0x1D
		public int constantRegister; // 0x20
		public string sourcePath; // 0x28
	
		// Constructors
		public GenerateHLSL() {} // Dummy constructor
		public GenerateHLSL(PackingRules rules = PackingRules.Exact /* Metadata: 0x01FD466A */, bool needAccessors = true /* Metadata: 0x01FD466B */, bool needSetters = false /* Metadata: 0x01FD466C */, bool needParamDebug = false /* Metadata: 0x01FD466D */, int paramDefinesStart = 1 /* Metadata: 0x01FD466E */, bool omitStructDeclaration = false /* Metadata: 0x01FD466F */, bool containsPackedFields = false /* Metadata: 0x01FD4670 */, bool generateCBuffer = false /* Metadata: 0x01FD4671 */, int constantRegister = -1 /* Metadata: 0x01FD4672 */, [CallerFilePath] string sourcePath = null) {} // 0x0000000189CADB0C-0x0000000189CADB6C
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class SurfaceDataAttributes : Attribute // TypeDefIndex: 53523
	{
		// Fields
		public string[] displayNames; // 0x10
		public bool isDirection; // 0x18
		public bool sRGBDisplay; // 0x19
		public FieldPrecision precision; // 0x1C
		public bool checkIsNormalized; // 0x20
		public string preprocessor; // 0x28
	
		// Constructors
		public SurfaceDataAttributes() {} // Dummy constructor
		public SurfaceDataAttributes(string displayName = "" /* Metadata: 0x01FD4673 */, bool isDirection = false /* Metadata: 0x01FD4674 */, bool sRGBDisplay = false /* Metadata: 0x01FD4675 */, FieldPrecision precision = FieldPrecision.Default /* Metadata: 0x01FD4676 */, bool checkIsNormalized = false /* Metadata: 0x01FD4677 */, string preprocessor = "" /* Metadata: 0x01FD4678 */) {} // 0x0000000189CB78B4-0x0000000189CB7964
		public SurfaceDataAttributes(string[] displayNames, bool isDirection = false /* Metadata: 0x01FD4679 */, bool sRGBDisplay = false /* Metadata: 0x01FD467A */, FieldPrecision precision = FieldPrecision.Default /* Metadata: 0x01FD467B */, bool checkIsNormalized = false /* Metadata: 0x01FD467C */, string preprocessor = "" /* Metadata: 0x01FD467D */) {} // 0x0000000189CB7964-0x0000000189CB79AC
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class HLSLArray : Attribute // TypeDefIndex: 53524
	{
		// Fields
		public int arraySize; // 0x10
		public System.Type elementType; // 0x18
	
		// Constructors
		public HLSLArray() {} // Dummy constructor
		public HLSLArray(int arraySize, System.Type elementType) {} // 0x0000000184270E40-0x0000000184270E50
	}

	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
	public class PackingAttribute : Attribute // TypeDefIndex: 53525
	{
		// Fields
		public string[] displayNames; // 0x10
		public float[] range; // 0x18
		public FieldPacking packingScheme; // 0x20
		public int offsetInSource; // 0x24
		public int sizeInBits; // 0x28
		public bool isDirection; // 0x2C
		public bool sRGBDisplay; // 0x2D
		public bool checkIsNormalized; // 0x2E
		public string preprocessor; // 0x30
	
		// Constructors
		public PackingAttribute() {} // Dummy constructor
		public PackingAttribute(string[] displayNames, FieldPacking packingScheme = FieldPacking.NoPacking /* Metadata: 0x01FD467E */, int bitSize = 32 /* Metadata: 0x01FD467F */, int offsetInSource = 0 /* Metadata: 0x01FD4680 */, float minValue = 0f /* Metadata: 0x01FD4681 */, float maxValue = 1f /* Metadata: 0x01FD4685 */, bool isDirection = false /* Metadata: 0x01FD4689 */, bool sRGBDisplay = false /* Metadata: 0x01FD468A */, bool checkIsNormalized = false /* Metadata: 0x01FD468B */, string preprocessor = "" /* Metadata: 0x01FD468C */) {} // 0x0000000189CB3F78-0x0000000189CB4060
		public PackingAttribute(string displayName = "" /* Metadata: 0x01FD468D */, FieldPacking packingScheme = FieldPacking.NoPacking /* Metadata: 0x01FD468E */, int bitSize = 0 /* Metadata: 0x01FD468F */, int offsetInSource = 0 /* Metadata: 0x01FD4690 */, float minValue = 0f /* Metadata: 0x01FD4691 */, float maxValue = 1f /* Metadata: 0x01FD4695 */, bool isDirection = false /* Metadata: 0x01FD4699 */, bool sRGBDisplay = false /* Metadata: 0x01FD469A */, bool checkIsNormalized = false /* Metadata: 0x01FD469B */, string preprocessor = "" /* Metadata: 0x01FD469C */) {} // 0x0000000189CB4060-0x0000000189CB417C
	}

	public struct ShaderGenUInt4 // TypeDefIndex: 53526
	{
	}

	internal static class Hammersley // TypeDefIndex: 53535
	{
		// Fields
		private static float[] k_Hammersley2dSeq16; // 0x00
		private static float[] k_Hammersley2dSeq32; // 0x08
		private static float[] k_Hammersley2dSeq64; // 0x10
		private static float[] k_Hammersley2dSeq256; // 0x18
		private static readonly int s_hammersley2DSeq16Id; // 0x20
		private static readonly int s_hammersley2DSeq32Id; // 0x24
		private static readonly int s_hammersley2DSeq64Id; // 0x28
		private static readonly int s_hammersley2DSeq256Id; // 0x2C
	
		// Nested types
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "F:\\Build\\Release_v1d2\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq16 // TypeDefIndex: 53528
		{
			// Fields
			[HLSLArray(16, typeof(Vector4))]
			public unsafe fixed /* 0x00000000-0x00000000 */ float hammersley2dSeq16[0]; // 0x00
		}
	
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "F:\\Build\\Release_v1d2\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq32 // TypeDefIndex: 53530
		{
			// Fields
			[HLSLArray(32, typeof(Vector4))]
			public unsafe fixed /* 0x00000000-0x00000000 */ float hammersley2dSeq32[0]; // 0x00
		}
	
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "F:\\Build\\Release_v1d2\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq64 // TypeDefIndex: 53532
		{
			// Fields
			[HLSLArray(64, typeof(Vector4))]
			public unsafe fixed /* 0x00000000-0x00000000 */ float hammersley2dSeq64[0]; // 0x00
		}
	
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "F:\\Build\\Release_v1d2\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq256 // TypeDefIndex: 53534
		{
			// Fields
			[HLSLArray(256, typeof(Vector4))]
			public unsafe fixed /* 0x00000000-0x00000000 */ float hammersley2dSeq256[0]; // 0x00
		}
	
		// Constructors
		static Hammersley() {} // 0x0000000189CADF78-0x0000000189CAE1C0
	
		// Methods
		public static void Initialize() {} // 0x0000000189CADC94-0x0000000189CADF78
		public static void BindConstants(CommandBuffer cmd, ComputeShader cs) {} // 0x0000000189CADB6C-0x0000000189CADC94
	}

	public class BufferedRTHandleSystem : IDisposable // TypeDefIndex: 53536
	{
		// Fields
		private Dictionary<int, RTHandle[]> m_RTHandles; // 0x10
		private bool m_DisposedValue; // 0x18
	
		// Constructors
		public BufferedRTHandleSystem() {} // 0x0000000183A4E400-0x0000000183A4E480
	
		// Methods
		public RTHandle GetFrameRT(int bufferId, int frameIndex) => default; // 0x0000000189CACD64-0x0000000189CACE04
		public void AllocBuffer(int bufferId, Func<int, RTHandle> allocator, int bufferCount) {} // 0x0000000189CACC3C-0x0000000189CACD58
		public void ReleaseBuffer(int bufferId) {} // 0x0000000189CACE8C-0x0000000189CACF60
		public int GetNumFramesAllocated(int bufferId) => default; // 0x0000000189CACE04-0x0000000189CACE8C
		private void Swap() {} // 0x0000000189CACF60-0x0000000189CAD164
		private void Dispose(bool disposing) {} // 0x000000018376FB60-0x000000018376FB90
		public void Dispose() {} // 0x0000000189CACD58-0x0000000189CACD64
		public void ReleaseAll() {} // 0x000000018376FB90-0x000000018376FD40
	}

	public enum DepthBits // TypeDefIndex: 53537
	{
		None = 0,
		Depth8 = 8,
		Depth16 = 16,
		Depth24 = 24,
		Depth32 = 32
	}

	public enum MSAASamples // TypeDefIndex: 53538
	{
		None = 1,
		MSAA2x = 2,
		MSAA4x = 4,
		MSAA8x = 8
	}

	public class PowerOfTwoTextureAtlas : Texture2DAtlas // TypeDefIndex: 53541
	{
		// Fields
		private readonly int m_MipPadding; // 0x48
		private const float k_MipmapFactorApprox = 1.33f; // Metadata: 0x01FD46B2
		private Dictionary<int, Vector2Int> m_RequestedTextures; // 0x50
	
		// Properties
		public int mipPadding { get => default; } // 0x0000000183D4EC50-0x0000000183D4EC60 
	
		// Nested types
		private enum BlitType // TypeDefIndex: 53539
		{
			Padding = 0,
			PaddingMultiply = 1,
			OctahedralPadding = 2,
			OctahedralPaddingMultiply = 3
		}
	
		// Constructors
		public PowerOfTwoTextureAtlas() {} // Dummy constructor
		public PowerOfTwoTextureAtlas(int size, int mipPadding, GraphicsFormat format, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x01FD46A6 */, string name = "" /* Metadata: 0x01FD46A7 */, bool useMipMap = true /* Metadata: 0x01FD46A8 */) {} // 0x0000000189CB5BAC-0x0000000189CB5CA4
	
		// Methods
		private int GetTexturePadding() => default; // 0x0000000183D84030-0x0000000183D84060
		public Vector4 GetPayloadScaleOffset(Texture texture, [IsReadOnly] in Vector4 scaleOffset) => default; // 0x0000000189CB53B0-0x0000000189CB545C
		public static Vector4 GetPayloadScaleOffset([IsReadOnly] in Vector2 textureSize, [IsReadOnly] in Vector2 paddingSize, [IsReadOnly] in Vector4 scaleOffset) => default; // 0x0000000189CB5298-0x0000000189CB53B0
		private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, BlitType blitType) {} // 0x0000000189CB4A00-0x0000000189CB4DD8
		public override void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x01FD46A9 */, int overrideInstanceID = -1 /* Metadata: 0x01FD46AA */) {} // 0x0000000189CB5054-0x0000000189CB5120
		public void BlitTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x01FD46AB */, int overrideInstanceID = -1 /* Metadata: 0x01FD46AC */) {} // 0x0000000189CB4F80-0x0000000189CB5054
		public override void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x01FD46AD */, int overrideInstanceID = -1 /* Metadata: 0x01FD46AE */) {} // 0x0000000189CB4EAC-0x0000000189CB4F80
		public void BlitOctahedralTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x01FD46AF */, int overrideInstanceID = -1 /* Metadata: 0x01FD46B0 */) {} // 0x0000000189CB4DD8-0x0000000189CB4EAC
		private void TextureSizeToPowerOfTwo(Texture texture, ref int width, ref int height) {} // 0x0000000189CB5B78-0x0000000189CB5BAC
		private Vector2 GetPowerOfTwoTextureSize(Texture texture) => default; // 0x0000000189CB545C-0x0000000189CB54D8
		public override bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1 /* Metadata: 0x01FD46B1 */) => default; // 0x0000000189CB4868-0x0000000189CB4A00
		public void ResetRequestedTexture() {} // 0x0000000189CB5B30-0x0000000189CB5B78
		public bool ReserveSpace(Texture texture) => default; // 0x0000000189CB5954-0x0000000189CB59B4
		public bool ReserveSpace(Texture texture, int width, int height) => default; // 0x0000000189CB5AE8-0x0000000189CB5B30
		public bool ReserveSpace(Texture textureA, Texture textureB, int width, int height) => default; // 0x0000000189CB5AA8-0x0000000189CB5AE8
		private bool ReserveSpace(int id, int width, int height) => default; // 0x0000000189CB59B4-0x0000000189CB5AA8
		public bool RelayoutEntries() => default; // 0x0000000189CB54D8-0x0000000189CB5954
		public static long GetApproxCacheSizeInByte(int nbElement, int resolution, bool hasMipmap, GraphicsFormat format) => default; // 0x0000000189CB5120-0x0000000189CB51D0
		public static int GetMaxCacheSizeForWeightInByte(int weight, bool hasMipmap, GraphicsFormat format) => default; // 0x0000000189CB51D0-0x0000000189CB5298
	}

	public class RTHandle // TypeDefIndex: 53542
	{
		// Fields
		internal RenderTexture m_RT; // 0x10
		internal Texture m_ExternalTexture; // 0x18
		internal RenderTargetIdentifier m_NameID; // 0x20
		internal bool m_EnableMSAA; // 0x48
		internal bool m_EnableRandomWrite; // 0x49
		internal string m_Name; // 0x50
	
		// Properties
		public RenderTexture rt { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public RenderTargetIdentifier nameID { get => default; } // 0x0000000183D581B0-0x0000000183D581D0 
		public string name { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000189CB6A00-0x0000000189CB6AB8
		public bool isMSAAEnabled { get => default; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 
	
		// Constructors
		public RTHandle() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static implicit operator RenderTargetIdentifier(RTHandle handle) => default; // 0x0000000189CB6954-0x0000000189CB6998
		public static implicit operator Texture(RTHandle handle) => default; // 0x0000000189CB6998-0x0000000189CB6A00
		public static implicit operator RenderTexture(RTHandle handle) => default; // 0x0000000182524410-0x0000000182524420
		public void SetRenderTexture(RenderTexture rt) {} // 0x00000001825252E0-0x0000000182525360
		public void SetTexture(Texture tex) {} // 0x00000001825253F0-0x0000000182525470
		public void SetTexture(RenderTargetIdentifier tex) {} // 0x0000000189CB6818-0x0000000189CB6864
		public int GetInstanceID() => default; // 0x0000000189CB6774-0x0000000189CB6818
		public void Release() {} // 0x0000000182E7E2A0-0x0000000182E7E350
		public void SwitchToFastMemory(CommandBuffer cmd, float residencyFraction = 1f /* Metadata: 0x01FD46BA */, FastMemoryFlags flags = FastMemoryFlags.None | FastMemoryFlags.SpillTop /* Metadata: 0x01FD46BE */, bool copyContents = false /* Metadata: 0x01FD46BF */) {} // 0x0000000189CB68C8-0x0000000189CB6954
		public void CopyToFastMemory(CommandBuffer cmd, float residencyFraction = 1f /* Metadata: 0x01FD46C0 */, FastMemoryFlags flags = FastMemoryFlags.None | FastMemoryFlags.SpillTop /* Metadata: 0x01FD46C4 */) {} // 0x0000000189CB6758-0x0000000189CB6774
		public void SwitchOutFastMemory(CommandBuffer cmd, bool copyContents = true /* Metadata: 0x01FD46C5 */) {} // 0x0000000189CB6864-0x0000000189CB68C8
	}

	public static class RTHandles // TypeDefIndex: 53543
	{
		// Fields
		private static RTHandleSystem s_DefaultInstance; // 0x00
	
		// Constructors
		static RTHandles() {} // 0x0000000183CFFE00-0x0000000183CFFE70
	
		// Methods
		public static RTHandle Alloc(int width, int height, int slices = 1 /* Metadata: 0x01FD46C6 */, DepthBits depthBufferBits = DepthBits.None /* Metadata: 0x01FD46C7 */, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB /* Metadata: 0x01FD46C8 */, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x01FD46C9 */, TextureWrapMode wrapMode = TextureWrapMode.Repeat /* Metadata: 0x01FD46CA */, TextureDimension dimension = TextureDimension.Tex2D /* Metadata: 0x01FD46CB */, bool enableRandomWrite = false /* Metadata: 0x01FD46CC */, bool useMipMap = false /* Metadata: 0x01FD46CD */, bool autoGenerateMips = true /* Metadata: 0x01FD46CE */, bool isShadowMap = false /* Metadata: 0x01FD46CF */, int anisoLevel = 1 /* Metadata: 0x01FD46D0 */, float mipMapBias = 0f /* Metadata: 0x01FD46D1 */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x01FD46D5 */, bool bindTextureMS = false /* Metadata: 0x01FD46D6 */, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None /* Metadata: 0x01FD46D7 */, string name = "" /* Metadata: 0x01FD46D8 */) => default; // 0x0000000182524790-0x0000000182524860
		public static RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = TextureWrapMode.Repeat /* Metadata: 0x01FD46D9 */, int slices = 1 /* Metadata: 0x01FD46DA */, DepthBits depthBufferBits = DepthBits.None /* Metadata: 0x01FD46DB */, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB /* Metadata: 0x01FD46DC */, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x01FD46DD */, TextureDimension dimension = TextureDimension.Tex2D /* Metadata: 0x01FD46DE */, bool enableRandomWrite = false /* Metadata: 0x01FD46DF */, bool useMipMap = false /* Metadata: 0x01FD46E0 */, bool autoGenerateMips = true /* Metadata: 0x01FD46E1 */, bool isShadowMap = false /* Metadata: 0x01FD46E2 */, int anisoLevel = 1 /* Metadata: 0x01FD46E3 */, float mipMapBias = 0f /* Metadata: 0x01FD46E4 */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x01FD46E8 */, bool bindTextureMS = false /* Metadata: 0x01FD46E9 */, bool useDynamicScale = false /* Metadata: 0x01FD46EA */, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None /* Metadata: 0x01FD46EB */, string name = "" /* Metadata: 0x01FD46EC */) => default; // 0x0000000189CB6AB8-0x0000000189CB6B8C
		public static RTHandle Alloc(Texture tex) => default; // 0x00000001842703D8-0x00000001842703E0
		public static RTHandle Alloc(RenderTexture tex) => default; // 0x0000000189CB6C44-0x0000000189CB6C4C
		public static RTHandle Alloc(RenderTargetIdentifier tex) => default; // 0x0000000189CB6B8C-0x0000000189CB6BC0
		public static RTHandle Alloc(RenderTargetIdentifier tex, string name) => default; // 0x0000000189CB6C10-0x0000000189CB6C44
		private static RTHandle Alloc(RTHandle tex) => default; // 0x0000000189CB6BC0-0x0000000189CB6C10
	}

	public class RTHandleSystem // TypeDefIndex: 53544
	{
		// Constructors
		public RTHandleSystem() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Initialize() {} // 0x000000018350B670-0x000000018350B680
		public static RTHandle Alloc(int width, int height, int slices = 1 /* Metadata: 0x01FD46ED */, DepthBits depthBufferBits = DepthBits.None /* Metadata: 0x01FD46EE */, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB /* Metadata: 0x01FD46EF */, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x01FD46F0 */, TextureWrapMode wrapMode = TextureWrapMode.Repeat /* Metadata: 0x01FD46F1 */, TextureDimension dimension = TextureDimension.Tex2D /* Metadata: 0x01FD46F2 */, bool enableRandomWrite = false /* Metadata: 0x01FD46F3 */, bool useMipMap = false /* Metadata: 0x01FD46F4 */, bool autoGenerateMips = true /* Metadata: 0x01FD46F5 */, bool isShadowMap = false /* Metadata: 0x01FD46F6 */, int anisoLevel = 1 /* Metadata: 0x01FD46F7 */, float mipMapBias = 0f /* Metadata: 0x01FD46F8 */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x01FD46FC */, bool bindTextureMS = false /* Metadata: 0x01FD46FD */, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None /* Metadata: 0x01FD46FE */, string name = "" /* Metadata: 0x01FD46FF */) => default; // 0x0000000182524860-0x0000000182524940
		public static RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = TextureWrapMode.Repeat /* Metadata: 0x01FD4700 */, int slices = 1 /* Metadata: 0x01FD4701 */, DepthBits depthBufferBits = DepthBits.None /* Metadata: 0x01FD4702 */, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB /* Metadata: 0x01FD4703 */, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x01FD4704 */, TextureDimension dimension = TextureDimension.Tex2D /* Metadata: 0x01FD4705 */, bool enableRandomWrite = false /* Metadata: 0x01FD4706 */, bool useMipMap = false /* Metadata: 0x01FD4707 */, bool autoGenerateMips = true /* Metadata: 0x01FD4708 */, bool isShadowMap = false /* Metadata: 0x01FD4709 */, int anisoLevel = 1 /* Metadata: 0x01FD470A */, float mipMapBias = 0f /* Metadata: 0x01FD470B */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x01FD470F */, bool bindTextureMS = false /* Metadata: 0x01FD4710 */, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None /* Metadata: 0x01FD4711 */, string name = "" /* Metadata: 0x01FD4712 */) => default; // 0x0000000182524940-0x0000000182524E40
		private static RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, DepthBits depthBufferBits, GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, TextureWrapMode wrapMode, TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, MSAASamples msaaSamples, bool bindTextureMS, RenderTextureMemoryless memoryless, string name) => default; // 0x0000000189CB60E0-0x0000000189CB6590
		public static RTHandle Alloc(RenderTexture texture) => default; // 0x0000000189CB65EC-0x0000000189CB666C
		public static RTHandle Alloc(Texture texture) => default; // 0x0000000182525360-0x00000001825253F0
		public static RTHandle Alloc(RenderTargetIdentifier texture) => default; // 0x0000000189CB6590-0x0000000189CB65EC
		public static RTHandle Alloc(RenderTargetIdentifier texture, string name) => default; // 0x0000000189CB666C-0x0000000189CB6708
		private static RTHandle Alloc(RTHandle tex) => default; // 0x0000000189CB6708-0x0000000189CB6758
	}

	internal class AtlasAllocator // TypeDefIndex: 53547
	{
		// Fields
		private AtlasNode m_Root; // 0x10
		private int m_Width; // 0x18
		private int m_Height; // 0x1C
		private bool powerOfTwoPadding; // 0x20
		private ObjectPool<AtlasNode> m_NodePool; // 0x28
	
		// Nested types
		private class AtlasNode // TypeDefIndex: 53545
		{
			// Fields
			public AtlasNode m_RightChild; // 0x10
			public AtlasNode m_BottomChild; // 0x18
			public Vector4 m_Rect; // 0x20
	
			// Constructors
			public AtlasNode() {} // 0x0000000183D83FA0-0x0000000183D83FB0
	
			// Methods
			public AtlasNode Allocate(ref ObjectPool<AtlasNode> pool, int width, int height, bool powerOfTwoPadding) => default; // 0x0000000189CABBB4-0x0000000189CABF14
			public void Release(ref ObjectPool<AtlasNode> pool) {} // 0x0000000189CAC50C-0x0000000189CAC5D4
		}
	
		// Constructors
		public AtlasAllocator() {} // Dummy constructor
		public AtlasAllocator(int width, int height, bool potPadding) {} // 0x0000000189CAB778-0x0000000189CAB9E8
	
		// Methods
		public bool Allocate(ref Vector4 result, int width, int height) => default; // 0x0000000189CAB6C4-0x0000000189CAB720
		public void Reset() {} // 0x0000000189CAB720-0x0000000189CAB778
	}

	public class Texture2DAtlas // TypeDefIndex: 53549
	{
		// Fields
		private protected const int kGPUTexInvalid = 0; // Metadata: 0x01FD4725
		private protected const int kGPUTexValidMip0 = 1; // Metadata: 0x01FD4726
		private protected const int kGPUTexValidMipAll = 2; // Metadata: 0x01FD4727
		private protected RTHandle m_AtlasTexture; // 0x10
		private protected int m_Width; // 0x18
		private protected int m_Height; // 0x1C
		private protected GraphicsFormat m_Format; // 0x20
		private protected bool m_UseMipMaps; // 0x24
		private bool m_IsAtlasTextureOwner; // 0x25
		private AtlasAllocator m_AtlasAllocator; // 0x28
		[TupleElementNames(new string[2] {"scaleOffset", "size" })]
		private Dictionary<int, ValueTuple<Vector4, Vector2Int>> m_AllocationCache; // 0x30
		private Dictionary<int, int> m_IsGPUTextureUpToDate; // 0x38
		private Dictionary<int, int> m_TextureHashes; // 0x40
		private static readonly Vector4 fullScaleOffset; // 0x00
		private static readonly int s_MaxMipLevelPadding; // 0x10
	
		// Properties
		public static int maxMipLevelPadding { get => default; } // 0x0000000189CB9ED8-0x0000000189CB9F28 
		public RTHandle AtlasTexture { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Nested types
		private enum BlitType // TypeDefIndex: 53548
		{
			Default = 0,
			CubeTo2DOctahedral = 1,
			SingleChannel = 2,
			CubeTo2DOctahedralSingleChannel = 3
		}
	
		// Constructors
		public Texture2DAtlas() {} // Dummy constructor
		public Texture2DAtlas(int width, int height, GraphicsFormat format, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x01FD4713 */, bool powerOfTwoPadding = false /* Metadata: 0x01FD4714 */, string name = "" /* Metadata: 0x01FD4715 */, bool useMipMap = true /* Metadata: 0x01FD4716 */) {} // 0x0000000189CB9C10-0x0000000189CB9ED8
		static Texture2DAtlas() {} // 0x0000000189CB9BBC-0x0000000189CB9C10
	
		// Methods
		public void Release() {} // 0x0000000189CB98EC-0x0000000189CB9924
		public void ResetAllocator() {} // 0x0000000189CB9924-0x0000000189CB999C
		public void ClearTarget(CommandBuffer cmd) {} // 0x0000000189CB8B10-0x0000000189CB8C9C
		private protected int GetTextureMipmapCount(int width, int height) => default; // 0x0000000189CB8F68-0x0000000189CB8FA0
		private protected bool Is2D(Texture texture) => default; // 0x0000000189CB8FA0-0x0000000189CB9014
		private protected bool IsSingleChannelBlit(Texture source, Texture destination) => default; // 0x0000000189CB9110-0x0000000189CB92E4
		private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, BlitType blitType) {} // 0x0000000189CB85EC-0x0000000189CB8800
		private protected void MarkGPUTextureValid(int instanceId, bool mipAreValid = false /* Metadata: 0x01FD4717 */) {} // 0x0000000189CB933C-0x0000000189CB93A0
		private protected void MarkGPUTextureInvalid(int instanceId) {} // 0x0000000189CB92E4-0x0000000189CB933C
		public virtual void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x01FD4718 */, int overrideInstanceID = -1 /* Metadata: 0x01FD4719 */) {} // 0x0000000189CB89B8-0x0000000189CB8B10
		public virtual void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x01FD471A */, int overrideInstanceID = -1 /* Metadata: 0x01FD471B */) {} // 0x0000000189CB8960-0x0000000189CB89B8
		public virtual void BlitCubeTexture2D(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, bool blitMips = true /* Metadata: 0x01FD471C */, int overrideInstanceID = -1 /* Metadata: 0x01FD471D */) {} // 0x0000000189CB8800-0x0000000189CB8960
		public virtual bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1 /* Metadata: 0x01FD471E */) => default; // 0x0000000189CB8434-0x0000000189CB85EC
		public bool AllocateTextureWithoutBlit(Texture texture, int width, int height, ref Vector4 scaleOffset) => default; // 0x0000000189CB83D4-0x0000000189CB8434
		public virtual bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref Vector4 scaleOffset) => default; // 0x0000000189CB8248-0x0000000189CB83D4
		private protected int GetTextureHash(Texture textureA, Texture textureB) => default; // 0x0000000189CB8EA4-0x0000000189CB8F04
		public int GetTextureID(Texture texture) => default; // 0x0000000189CB8F48-0x0000000189CB8F68
		public int GetTextureID(Texture textureA, Texture textureB) => default; // 0x0000000189CB8F04-0x0000000189CB8F48
		public bool IsCached(out Vector4 scaleOffset, Texture textureA, Texture textureB) {
			scaleOffset = default;
			return default;
		} // 0x0000000189CB9014-0x0000000189CB9054
		public bool IsCached(out Vector4 scaleOffset, Texture texture) {
			scaleOffset = default;
			return default;
		} // 0x0000000189CB90D4-0x0000000189CB9110
		public bool IsCached(out Vector4 scaleOffset, int id) {
			scaleOffset = default;
			return default;
		} // 0x0000000189CB9054-0x0000000189CB90D4
		internal Vector2Int GetCachedTextureSize(int id) => default; // 0x0000000189CB8E38-0x0000000189CB8EA4
		public virtual bool NeedsUpdate(Texture texture, bool needMips = false /* Metadata: 0x01FD471F */) => default; // 0x0000000189CB96F4-0x0000000189CB98EC
		public virtual bool NeedsUpdate(Texture textureA, Texture textureB, bool needMips = false /* Metadata: 0x01FD4720 */) => default; // 0x0000000189CB93A0-0x0000000189CB96F4
		public virtual bool AddTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture) => default; // 0x0000000189CB81B0-0x0000000189CB8248
		public virtual bool UpdateTexture(CommandBuffer cmd, Texture oldTexture, Texture newTexture, ref Vector4 scaleOffset, Vector4 sourceScaleOffset, bool updateIfNeeded = true /* Metadata: 0x01FD4721 */, bool blitMips = true /* Metadata: 0x01FD4722 */) => default; // 0x0000000189CB999C-0x0000000189CB9B08
		public virtual bool UpdateTexture(CommandBuffer cmd, Texture texture, ref Vector4 scaleOffset, bool updateIfNeeded = true /* Metadata: 0x01FD4723 */, bool blitMips = true /* Metadata: 0x01FD4724 */) => default; // 0x0000000189CB9B08-0x0000000189CB9BBC
		internal bool EnsureTextureSlot(out bool isUploadNeeded, ref Vector4 scaleBias, int key, int width, int height) {
			isUploadNeeded = default;
			return default;
		} // 0x0000000189CB8C9C-0x0000000189CB8E38
	}

	internal class AtlasAllocatorDynamic // TypeDefIndex: 53553
	{
		// Fields
		private int m_Width; // 0x10
		private int m_Height; // 0x14
		private AtlasNodePool m_Pool; // 0x18
		private short m_Root; // 0x20
		private Dictionary<int, short> m_NodeFromID; // 0x28
	
		// Nested types
		private class AtlasNodePool // TypeDefIndex: 53550
		{
			// Fields
			internal AtlasNode[] m_Nodes; // 0x10
			private short m_Next; // 0x18
			private short m_FreelistHead; // 0x1A
	
			// Constructors
			public AtlasNodePool() {} // Dummy constructor
			public AtlasNodePool(short capacity) {} // 0x0000000189CABB4C-0x0000000189CABBB4
	
			// Methods
			public void Dispose() {} // 0x0000000189CABB34-0x0000000189CABB4C
			public void Clear() {} // 0x0000000183D83F70-0x0000000183D83F80
			public short AtlasNodeCreate(short parent) => default; // 0x0000000189CAB9E8-0x0000000189CABAE8
			public void AtlasNodeFree(short index) {} // 0x0000000189CABAE8-0x0000000189CABB34
		}
	
		private struct AtlasNode // TypeDefIndex: 53552
		{
			// Fields
			public short m_Self; // 0x00
			public short m_Parent; // 0x02
			public short m_LeftChild; // 0x04
			public short m_RightChild; // 0x06
			public short m_FreelistNext; // 0x08
			public ushort m_Flags; // 0x0A
			public Vector4 m_Rect; // 0x10
	
			// Nested types
			private enum AtlasNodeFlags : uint // TypeDefIndex: 53551
			{
				IsOccupied = 1
			}
	
			// Constructors
			public AtlasNode(short self, short parent) {
				m_Self = default;
				m_Parent = default;
				m_LeftChild = default;
				m_RightChild = default;
				m_FreelistNext = default;
				m_Flags = default;
				m_Rect = default;
			} // 0x0000000189CAC5D4-0x0000000189CAC608
	
			// Methods
			public bool IsOccupied() => default; // 0x0000000189CAC3AC-0x0000000189CAC3B4
			public void SetIsOccupied() {} // 0x0000000183D83F90-0x0000000183D83FA0
			public void ClearIsOccupied() {} // 0x0000000183D83F80-0x0000000183D83F90
			public bool IsLeafNode() => default; // 0x0000000189CAC30C-0x0000000189CAC318
			public short Allocate(AtlasNodePool pool, int width, int height) => default; // 0x0000000189CABF14-0x0000000189CAC30C
			public void ReleaseChildren(AtlasNodePool pool) {} // 0x0000000189CAC468-0x0000000189CAC50C
			public void ReleaseAndMerge(AtlasNodePool pool) {} // 0x0000000189CAC3B4-0x0000000189CAC468
			public bool IsMergeNeeded(AtlasNodePool pool) => default; // 0x0000000189CAC318-0x0000000189CAC3AC
		}
	
		// Constructors
		public AtlasAllocatorDynamic() {} // Dummy constructor
		public AtlasAllocatorDynamic(int width, int height, int capacityAllocations) {} // 0x0000000189CAB580-0x0000000189CAB6C4
	
		// Methods
		public bool Allocate(out Vector4 result, int key, int width, int height) {
			result = default;
			return default;
		} // 0x0000000189CAAE98-0x0000000189CAAF9C
		public void Release(int key) {} // 0x0000000189CAB404-0x0000000189CAB4CC
		public void Release() {} // 0x0000000189CAB4CC-0x0000000189CAB580
		public string DebugStringFromRoot(int depthMax = -1 /* Metadata: 0x01FD472C */) => default; // 0x0000000189CAB39C-0x0000000189CAB404
		private void DebugStringFromNode(ref string res, short n, int depthCurrent = 0 /* Metadata: 0x01FD472D */, int depthMax = -1 /* Metadata: 0x01FD472E */) {} // 0x0000000189CAAF9C-0x0000000189CAB39C
	}

	internal class Texture2DAtlasDynamic // TypeDefIndex: 53554
	{
		// Fields
		private RTHandle m_AtlasTexture; // 0x10
		private bool isAtlasTextureOwner; // 0x18
		private int m_Width; // 0x1C
		private int m_Height; // 0x20
		private GraphicsFormat m_Format; // 0x24
		private AtlasAllocatorDynamic m_AtlasAllocator; // 0x28
		private Dictionary<int, Vector4> m_AllocationCache; // 0x30
	
		// Properties
		public RTHandle AtlasTexture { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public Texture2DAtlasDynamic() {} // Dummy constructor
		public Texture2DAtlasDynamic(int width, int height, int capacity, GraphicsFormat format) {} // 0x0000000189CB8004-0x0000000189CB81B0
		public Texture2DAtlasDynamic(int width, int height, int capacity, RTHandle atlasTexture) {} // 0x0000000189CB7EE4-0x0000000189CB8004
	
		// Methods
		public void Release() {} // 0x0000000189CB7E54-0x0000000189CB7E8C
		public void ResetAllocator() {} // 0x0000000189CB7E8C-0x0000000189CB7EE4
		public bool AddTexture(CommandBuffer cmd, out Vector4 scaleOffset, Texture texture) {
			scaleOffset = default;
			return default;
		} // 0x0000000189CB79AC-0x0000000189CB7C24
		public bool IsCached(out Vector4 scaleOffset, int key) {
			scaleOffset = default;
			return default;
		} // 0x0000000189CB7D88-0x0000000189CB7DEC
		public bool EnsureTextureSlot(out bool isUploadNeeded, out Vector4 scaleOffset, int key, int width, int height) {
			isUploadNeeded = default;
			scaleOffset = default;
			return default;
		} // 0x0000000189CB7C24-0x0000000189CB7D88
		public void ReleaseTextureSlot(int key) {} // 0x0000000189CB7DEC-0x0000000189CB7E54
	}

	public static class TextureXR // TypeDefIndex: 53555
	{
		// Fields
		private static int m_MaxViews; // 0x00
		private static Texture m_BlackUIntTexture2DArray; // 0x08
		private static Texture m_BlackUIntTexture; // 0x10
		private static RTHandle m_BlackUIntTexture2DArrayRTH; // 0x18
		private static RTHandle m_BlackUIntTextureRTH; // 0x20
		private static Texture2DArray m_ClearTexture2DArray; // 0x28
		private static Texture2D m_ClearTexture; // 0x30
		private static RTHandle m_ClearTexture2DArrayRTH; // 0x38
		private static RTHandle m_ClearTextureRTH; // 0x40
		private static Texture2DArray m_MagentaTexture2DArray; // 0x48
		private static Texture2D m_MagentaTexture; // 0x50
		private static RTHandle m_MagentaTexture2DArrayRTH; // 0x58
		private static RTHandle m_MagentaTextureRTH; // 0x60
		private static Texture2D m_BlackTexture; // 0x68
		private static Texture3D m_BlackTexture3D; // 0x70
		private static Texture2DArray m_BlackTexture2DArray; // 0x78
		private static RTHandle m_BlackTexture2DArrayRTH; // 0x80
		private static RTHandle m_BlackTextureRTH; // 0x88
		private static RTHandle m_BlackTexture3DRTH; // 0x90
		private static Texture2DArray m_WhiteTexture2DArray; // 0x98
		private static RTHandle m_WhiteTexture2DArrayRTH; // 0xA0
		private static RTHandle m_WhiteTextureRTH; // 0xA8
	
		// Properties
		public static int maxViews { get; set; } // 0x0000000189CBB4FC-0x0000000189CBB550
		public static int slices { get; } // 0x0000000189CBB4AC-0x0000000189CBB4FC 
		public static bool useTexArray { get; } // 0x0000000183D079A0-0x0000000183D079D0 
		public static TextureDimension dimension { get; } // 0x0000000189CBB458-0x0000000189CBB4AC 
	
		// Constructors
		static TextureXR() {} // 0x0000000183D43A60-0x0000000183D43AA0
	
		// Methods
		public static RTHandle GetBlackUIntTexture() => default; // 0x0000000189CBA63C-0x0000000189CBA6B0
		public static RTHandle GetClearTexture() => default; // 0x0000000189CBA6B0-0x0000000189CBA724
		public static RTHandle GetMagentaTexture() => default; // 0x0000000189CBA724-0x0000000189CBA798
		public static RTHandle GetBlackTexture() => default; // 0x0000000189CBA5C0-0x0000000189CBA63C
		public static RTHandle GetBlackTextureArray() => default; // 0x0000000189CBA56C-0x0000000189CBA5C0
		public static RTHandle GetBlackTexture3D() => default; // 0x0000000189CBA518-0x0000000189CBA56C
		public static RTHandle GetWhiteTexture() => default; // 0x0000000189CBA798-0x0000000189CBA814
		public static void Initialize(CommandBuffer cmd, ComputeShader clearR32_UIntShader) {} // 0x0000000189CBA814-0x0000000189CBB458
		private static Texture2DArray CreateTexture2DArrayFromTexture2D(Texture2D source, string name) => default; // 0x0000000189CBA3B0-0x0000000189CBA518
		private static Texture CreateBlackUIntTextureArray(CommandBuffer cmd, ComputeShader clearR32_UIntShader) => default; // 0x0000000189CB9FF8-0x0000000189CBA1D4
		private static Texture CreateBlackUintTexture(CommandBuffer cmd, ComputeShader clearR32_UIntShader) => default; // 0x0000000189CBA1D4-0x0000000189CBA3B0
		private static Texture3D CreateBlackTexture3D(string name) => default; // 0x0000000189CB9F28-0x0000000189CB9FF8
	}

	public static class ArrayExtensions // TypeDefIndex: 53556
	{
		// Methods
		public static void ResizeArray<T>(ref ref T[] array, int capacity) {}
		public static void Grow<T>(ref ref T[] array, int targetSize) {}
		public static void GrowToNearestPowerOf2<T>(ref ref T[] array, int targetSize) {}
		public static uint RoundUpToPowerOf2(uint n) => default; // 0x0000000189CAAE70-0x0000000189CAAE98
	
		// Extension methods
		public static void ResizeArray<T>(this ref NativeArray<T> array, int capacity, Unity.Collections.Allocator allocator)
			where T : struct {}
		public static void ResizeArray(this ref TransformAccessArray array, int capacity) {} // 0x0000000189CAADE4-0x0000000189CAAE70
	}

	public interface IBitArray // TypeDefIndex: 53557
	{
		// Properties
		uint capacity { get; }
		bool allFalse { get; }
		bool allTrue { get; }
		bool this[uint index] { get => default; set {} }
		string humanizedData { get; }
	
		// Methods
		IBitArray BitAnd(IBitArray other);
		IBitArray BitOr(IBitArray other);
		IBitArray BitNot();
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray8 : IBitArray // TypeDefIndex: 53558
	{
		// Fields
		[SerializeField]
		private byte data; // 0x00
	
		// Properties
		public uint capacity { get => default; } // 0x0000000183D55800-0x0000000183D55810 
		public bool allFalse { get => default; } // 0x00000001880712C4-0x00000001880712CC 
		public bool allTrue { get => default; } // 0x0000000189CACB60-0x0000000189CACB68 
		public string humanizedData { get => default; } // 0x0000000189CACB68-0x0000000189CACC2C 
		public bool this[uint index] { get => default; set {} } // 0x0000000189CACB44-0x0000000189CACB60 0x0000000189CACC2C-0x0000000189CACC3C
	
		// Constructors
		public BitArray8(byte initValue) : this() {
			data = default;
		} // 0x0000000183D4F9D0-0x0000000183D4F9E0
		public BitArray8(IEnumerable<uint> bitIndexTrue) : this() {
			data = default;
		} // 0x0000000189CACAB4-0x0000000189CACB44
	
		// Methods
		public static BitArray8 operator ~(BitArray8 a) => default; // 0x0000000183D84020-0x0000000183D84030
		public static BitArray8 operator |(BitArray8 a, BitArray8 b) => default; // 0x0000000183D84010-0x0000000183D84020
		public static BitArray8 operator &(BitArray8 a, BitArray8 b) => default; // 0x0000000183D84000-0x0000000183D84010
		public IBitArray BitAnd(IBitArray other) => default; // 0x0000000189CAC94C-0x0000000189CAC9B0
		public IBitArray BitOr(IBitArray other) => default; // 0x0000000189CAC9F8-0x0000000189CACA58
		public IBitArray BitNot() => default; // 0x0000000189CAC9B0-0x0000000189CAC9F8
		public static bool operator ==(BitArray8 a, BitArray8 b) => default; // 0x00000001854B3B60-0x00000001854B3B68
		public static bool operator !=(BitArray8 a, BitArray8 b) => default; // 0x00000001854B3B68-0x00000001854B3B70
		public override bool Equals(object obj) => default; // 0x0000000189CACA58-0x0000000189CACAB4
		public override int GetHashCode() => default; // 0x0000000183D83FF0-0x0000000183D84000
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray16 : IBitArray // TypeDefIndex: 53559
	{
		// Fields
		[SerializeField]
		private ushort data; // 0x00
	
		// Properties
		public uint capacity { get => default; } // 0x0000000183D55B10-0x0000000183D55B20 
		public bool allFalse { get => default; } // 0x0000000189B64878-0x0000000189B64880 
		public bool allTrue { get => default; } // 0x0000000189CAC810-0x0000000189CAC81C 
		public string humanizedData { get => default; } // 0x0000000189CAC81C-0x0000000189CAC944 
		public bool this[uint index] { get => default; set {} } // 0x000000018426FFF4-0x0000000184270004 0x00000001842743A4-0x00000001842743B4
	
		// Constructors
		public BitArray16(ushort initValue) : this() {
			data = default;
		} // 0x0000000183D4F9B0-0x0000000183D4F9C0
		public BitArray16(IEnumerable<uint> bitIndexTrue) : this() {
			data = default;
		} // 0x0000000189CAC77C-0x0000000189CAC810
	
		// Methods
		public static BitArray16 operator ~(BitArray16 a) => default; // 0x0000000183D83FE0-0x0000000183D83FF0
		public static BitArray16 operator |(BitArray16 a, BitArray16 b) => default; // 0x0000000183D83FD0-0x0000000183D83FE0
		public static BitArray16 operator &(BitArray16 a, BitArray16 b) => default; // 0x0000000183D83FC0-0x0000000183D83FD0
		public IBitArray BitAnd(IBitArray other) => default; // 0x0000000189CAC608-0x0000000189CAC670
		public IBitArray BitOr(IBitArray other) => default; // 0x0000000189CAC6B8-0x0000000189CAC71C
		public IBitArray BitNot() => default; // 0x0000000189CAC670-0x0000000189CAC6B8
		public static bool operator ==(BitArray16 a, BitArray16 b) => default; // 0x0000000189C72524-0x0000000189C7252C
		public static bool operator !=(BitArray16 a, BitArray16 b) => default; // 0x0000000189CAC944-0x0000000189CAC94C
		public override bool Equals(object obj) => default; // 0x0000000189CAC71C-0x0000000189CAC77C
		public override int GetHashCode() => default; // 0x0000000183D83FB0-0x0000000183D83FC0
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray32 : IBitArray // TypeDefIndex: 53560
	{
		// Fields
		[SerializeField]
		private uint data; // 0x00
	
		// Properties
		public uint capacity { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		public bool allFalse { get => default; } // 0x00000001822FBAA0-0x00000001822FBAB0 
		public bool allTrue { get => default; } // 0x0000000189CBC6AC-0x0000000189CBC6B4 
		private string humanizedVersion { get => default; } // 0x0000000189CBC7DC-0x0000000189CBC830 
		public string humanizedData { get => default; } // 0x0000000189CBC6B4-0x0000000189CBC7DC 
		public bool this[uint index] { get => default; set {} } // 0x0000000189CBC694-0x0000000189CBC6AC 0x0000000189CBC830-0x0000000189CBC840
	
		// Constructors
		public BitArray32(uint initValue) : this() {
			data = default;
		} // 0x0000000183D4E970-0x0000000183D4E980
		public BitArray32(IEnumerable<uint> bitIndexTrue) : this() {
			data = default;
		} // 0x0000000189CBC604-0x0000000189CBC694
	
		// Methods
		public IBitArray BitAnd(IBitArray other) => default; // 0x0000000189CBC4A0-0x0000000189CBC504
		public IBitArray BitOr(IBitArray other) => default; // 0x0000000189CBC548-0x0000000189CBC5A8
		public IBitArray BitNot() => default; // 0x0000000189CBC504-0x0000000189CBC548
		public static BitArray32 operator ~(BitArray32 a) => default; // 0x0000000183D84210-0x0000000183D84220
		public static BitArray32 operator |(BitArray32 a, BitArray32 b) => default; // 0x0000000183D84200-0x0000000183D84210
		public static BitArray32 operator &(BitArray32 a, BitArray32 b) => default; // 0x0000000183D71180-0x0000000183D71190
		public static bool operator ==(BitArray32 a, BitArray32 b) => default; // 0x0000000186505FF4-0x0000000186505FFC
		public static bool operator !=(BitArray32 a, BitArray32 b) => default; // 0x000000018950C868-0x000000018950C870
		public override bool Equals(object obj) => default; // 0x0000000189CBC5A8-0x0000000189CBC604
		public override int GetHashCode() => default; // 0x0000000183D841F0-0x0000000183D84200
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray64 : IBitArray // TypeDefIndex: 53561
	{
		// Fields
		[SerializeField]
		private ulong data; // 0x00
	
		// Properties
		public uint capacity { get => default; } // 0x0000000183D55C70-0x0000000183D55C80 
		public bool allFalse { get => default; } // 0x0000000182361C20-0x0000000182361C30 
		public bool allTrue { get => default; } // 0x0000000189CBCA60-0x0000000189CBCA68 
		public string humanizedData { get => default; } // 0x0000000189CBCA68-0x0000000189CBCB90 
		public bool this[uint index] { get => default; set {} } // 0x0000000189CBCA48-0x0000000189CBCA60 0x0000000189CBCB90-0x0000000189CBCBA0
	
		// Constructors
		public BitArray64(ulong initValue) : this() {
			data = default;
		} // 0x0000000183D51730-0x0000000183D51740
		public BitArray64(IEnumerable<uint> bitIndexTrue) : this() {
			data = default;
		} // 0x0000000189CBC9B4-0x0000000189CBCA48
	
		// Methods
		public static BitArray64 operator ~(BitArray64 a) => default; // 0x0000000183D84250-0x0000000183D84260
		public static BitArray64 operator |(BitArray64 a, BitArray64 b) => default; // 0x0000000183D84240-0x0000000183D84250
		public static BitArray64 operator &(BitArray64 a, BitArray64 b) => default; // 0x0000000183D84230-0x0000000183D84240
		public IBitArray BitAnd(IBitArray other) => default; // 0x0000000189CBC840-0x0000000189CBC8A8
		public IBitArray BitOr(IBitArray other) => default; // 0x0000000189CBC8F0-0x0000000189CBC954
		public IBitArray BitNot() => default; // 0x0000000189CBC8A8-0x0000000189CBC8F0
		public static bool operator ==(BitArray64 a, BitArray64 b) => default; // 0x000000018232CE30-0x000000018232CE40
		public static bool operator !=(BitArray64 a, BitArray64 b) => default; // 0x00000001822E54C0-0x00000001822E54D0
		public override bool Equals(object obj) => default; // 0x0000000189CBC954-0x0000000189CBC9B4
		public override int GetHashCode() => default; // 0x0000000183D84220-0x0000000183D84230
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray128 : IBitArray // TypeDefIndex: 53562
	{
		// Fields
		[SerializeField]
		private ulong data1; // 0x00
		[SerializeField]
		private ulong data2; // 0x08
	
		// Properties
		public ulong Data1 { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
		public ulong Data2 { get => default; } // 0x0000000183D50DE0-0x0000000183D50DF0 
		public uint capacity { get => default; } // 0x0000000183D567A0-0x0000000183D567B0 
		public bool allFalse { get => default; } // 0x0000000189CBBB40-0x0000000189CBBB54 
		public bool allTrue { get => default; } // 0x0000000189CBBB54-0x0000000189CBBB68 
		public string humanizedData { get => default; } // 0x0000000189CBBB68-0x0000000189CBBD28 
		public bool this[uint index] { get => default; set {} } // 0x00000001842708B0-0x00000001842708C4 0x00000001842708C4-0x00000001842708EC
	
		// Constructors
		public BitArray128(ulong initValue1, ulong initValue2) : this() {
			data1 = default;
			data2 = default;
		} // 0x0000000183D4EA10-0x0000000183D4EA20
		public BitArray128(IEnumerable<uint> bitIndexTrue) : this() {
			data1 = default;
			data2 = default;
		} // 0x00000001825645A0-0x0000000182564660
	
		// Methods
		public static BitArray128 operator ~(BitArray128 a) => default; // 0x0000000183D840D0-0x0000000183D840F0
		public static BitArray128 operator |(BitArray128 a, BitArray128 b) => default; // 0x0000000183D840B0-0x0000000183D840D0
		public static BitArray128 operator &(BitArray128 a, BitArray128 b) => default; // 0x0000000183D84090-0x0000000183D840B0
		public IBitArray BitAnd(IBitArray other) => default; // 0x0000000189CBB940-0x0000000189CBB9D4
		public IBitArray BitOr(IBitArray other) => default; // 0x0000000189CBBA34-0x0000000189CBBAC8
		public IBitArray BitNot() => default; // 0x0000000189CBB9D4-0x0000000189CBBA34
		public static bool operator ==(BitArray128 a, BitArray128 b) => default; // 0x000000018558249C-0x00000001855824B4
		public static bool operator !=(BitArray128 a, BitArray128 b) => default; // 0x00000001855824B4-0x00000001855824CC
		public override bool Equals(object obj) => default; // 0x0000000189CBBAC8-0x0000000189CBBB40
		public override int GetHashCode() => default; // 0x0000000183D84060-0x0000000183D84090
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray256 : IBitArray // TypeDefIndex: 53563
	{
		// Fields
		[SerializeField]
		private ulong data1; // 0x00
		[SerializeField]
		private ulong data2; // 0x08
		[SerializeField]
		private ulong data3; // 0x10
		[SerializeField]
		private ulong data4; // 0x18
	
		// Properties
		public uint capacity { get => default; } // 0x0000000183D4EA40-0x0000000183D4EA50 
		public bool allFalse { get => default; } // 0x0000000189CBC0E8-0x0000000189CBC108 
		public bool allTrue { get => default; } // 0x0000000189CBC108-0x0000000189CBC128 
		public string humanizedData { get => default; } // 0x0000000189CBC128-0x0000000189CBC3F4 
		public bool this[uint index] { get => default; set {} } // 0x0000000189CBC0B4-0x0000000189CBC0E8 0x0000000189CBC464-0x0000000189CBC4A0
	
		// Constructors
		public BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4) : this() {
			data1 = default;
			data2 = default;
			data3 = default;
			data4 = default;
		} // 0x0000000183D4EA20-0x0000000183D4EA40
		public BitArray256(IEnumerable<uint> bitIndexTrue) : this() {
			data1 = default;
			data2 = default;
			data3 = default;
			data4 = default;
		} // 0x0000000189CBBFC0-0x0000000189CBC0B4
	
		// Methods
		public static BitArray256 operator ~(BitArray256 a) => default; // 0x0000000183D841C0-0x0000000183D841F0
		public static BitArray256 operator |(BitArray256 a, BitArray256 b) => default; // 0x0000000183D84180-0x0000000183D841C0
		public static BitArray256 operator &(BitArray256 a, BitArray256 b) => default; // 0x0000000183D84140-0x0000000183D84180
		public IBitArray BitAnd(IBitArray other) => default; // 0x0000000189CBBD28-0x0000000189CBBDE8
		public IBitArray BitOr(IBitArray other) => default; // 0x0000000189CBBE58-0x0000000189CBBF18
		public IBitArray BitNot() => default; // 0x0000000189CBBDE8-0x0000000189CBBE58
		public static bool operator ==(BitArray256 a, BitArray256 b) => default; // 0x0000000189CBC3F4-0x0000000189CBC42C
		public static bool operator !=(BitArray256 a, BitArray256 b) => default; // 0x0000000189CBC42C-0x0000000189CBC464
		public override bool Equals(object obj) => default; // 0x0000000189CBBF18-0x0000000189CBBFC0
		public override int GetHashCode() => default; // 0x0000000183D840F0-0x0000000183D84140
	}

	public static class BitArrayUtilities // TypeDefIndex: 53564
	{
		// Methods
		public static bool Get8(uint index, byte data) => default; // 0x0000000189CBCBF4-0x0000000189CBCC0C
		public static bool Get16(uint index, ushort data) => default; // 0x0000000183B45E60-0x0000000183B45E80
		public static bool Get32(uint index, uint data) => default; // 0x00000001856F0EC8-0x00000001856F0ED8
		public static bool Get64(uint index, ulong data) => default; // 0x0000000189CBCBE0-0x0000000189CBCBF4
		public static bool Get128(uint index, ulong data1, ulong data2) => default; // 0x0000000182D74A40-0x0000000182D74A70
		public static bool Get256(uint index, ulong data1, ulong data2, ulong data3, ulong data4) => default; // 0x0000000189CBCBA0-0x0000000189CBCBE0
		public static void Set8(uint index, ref byte data, bool value) {} // 0x0000000189CBCCA8-0x0000000189CBCCC0
		public static void Set16(uint index, ref ushort data, bool value) {} // 0x0000000183627C60-0x0000000183627C80
		public static void Set32(uint index, ref uint data, bool value) {} // 0x0000000189CBCC74-0x0000000189CBCC8C
		public static void Set64(uint index, ref ulong data, bool value) {} // 0x0000000189CBCC8C-0x0000000189CBCCA8
		public static void Set128(uint index, ref ulong data1, ref ulong data2, bool value) {} // 0x0000000182E52820-0x0000000182E52850
		public static void Set256(uint index, ref ulong data1, ref ulong data2, ref ulong data3, ref ulong data4, bool value) {} // 0x0000000189CBCC0C-0x0000000189CBCC74
	}

	public static class Blitter // TypeDefIndex: 53566
	{
		// Fields
		private static Material s_Blit; // 0x00
		private static Material s_BlitTexArray; // 0x08
		private static Material s_BlitTexArraySingleSlice; // 0x10
		private static Material s_BlitMotionVector; // 0x18
		private static Material s_BlitColorAndDepth; // 0x20
		private static Material s_LowResBlit; // 0x28
		private static MaterialPropertyBlock s_PropertyBlock; // 0x30
		private static Mesh s_TriangleMesh; // 0x38
		private static Mesh s_QuadMesh; // 0x40
	
		// Nested types
		private static class BlitShaderIDs // TypeDefIndex: 53565
		{
			// Fields
			public static readonly int _BlitTexture; // 0x00
			public static readonly int _BlitCubeTexture; // 0x04
			public static readonly int _BlitScaleBias; // 0x08
			public static readonly int _BlitScaleBiasRt; // 0x0C
			public static readonly int _BlitMipLevel; // 0x10
			public static readonly int _BlitTextureSize; // 0x14
			public static readonly int _BlitPaddingSize; // 0x18
			public static readonly int _InputDepth; // 0x1C
	
			// Constructors
			static BlitShaderIDs() {} // 0x0000000189CBCCC0-0x0000000189CBCE3C
		}
	
		// Constructors
		static Blitter() {} // 0x0000000183CF1CB0-0x0000000183CF1D40
	
		// Methods
		public static void Initialize(Shader blitPS, Shader blitColorAndDepthPS, Shader blitMotionVectorPS, Shader lowResBlitPS) {} // 0x0000000182E80590-0x0000000182E80910
		public static void Cleanup() {} // 0x0000000182E7E030-0x0000000182E7E2A0
		public static Material GetBlitMaterial(bool isFP32Output, TextureDimension dimension, bool singleSlice = false /* Metadata: 0x01FD4730 */) => default; // 0x0000000183008FD0-0x0000000183009120
		public static Material GetBlitColorAndDepth(bool isFP32Output) => default; // 0x0000000189CBEE6C-0x0000000189CBEEBC
		public static Material GetBlitMotionVectorMaterial() => default; // 0x0000000189CBEEBC-0x0000000189CBEF0C
		public static Material GetLowResBlitMaterial() => default; // 0x0000000189CBEF0C-0x0000000189CBEF5C
		private static void DrawTriangle(CommandBuffer cmd, Material material, int shaderPass) {} // 0x0000000189CBECC0-0x0000000189CBEE6C
		internal static void DrawQuad(CommandBuffer cmd, Material material, int shaderPass) {} // 0x0000000189CBEB14-0x0000000189CBECC0
		public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear) {} // 0x0000000189CBE9EC-0x0000000189CBEB14
		public static void BlitTexture2D(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear) {} // 0x0000000189CBE7C4-0x0000000189CBE8CC
		public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass) {} // 0x0000000189CBE8CC-0x0000000189CBE9EC
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f /* Metadata: 0x01FD4731 */, bool bilinear = false /* Metadata: 0x01FD4735 */) {} // 0x0000000189CBCFE0-0x0000000189CBD184
		public static void BlitCameraTexture2D(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f /* Metadata: 0x01FD4736 */, bool bilinear = false /* Metadata: 0x01FD473A */) {} // 0x0000000189CBCE3C-0x0000000189CBCFE0
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material, int pass) {} // 0x0000000189CBD408-0x0000000189CBD598
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Vector4 scaleBias, float mipLevel = 0f /* Metadata: 0x01FD473B */, bool bilinear = false /* Metadata: 0x01FD473F */) {} // 0x0000000189CBD33C-0x0000000189CBD408
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect destViewport, float mipLevel = 0f /* Metadata: 0x01FD4740 */, bool bilinear = false /* Metadata: 0x01FD4744 */) {} // 0x0000000189CBD184-0x0000000189CBD33C
		public static void BlitQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear) {} // 0x0000000189CBE600-0x0000000189CBE7C4
		public static void BlitQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) {} // 0x0000000189CBE338-0x0000000189CBE600
		public static void BlitQuadWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) {} // 0x0000000189CBE070-0x0000000189CBE338
		public static void BlitOctahedralWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) {} // 0x0000000189CBDBE0-0x0000000189CBDE2C
		public static void BlitOctahedralWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) {} // 0x0000000189CBD994-0x0000000189CBDBE0
		public static void BlitCubeToOctahedral2DQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex) {} // 0x0000000189CBD7E0-0x0000000189CBD994
		public static void BlitCubeToOctahedral2DQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex) {} // 0x0000000189CBD598-0x0000000189CBD7E0
		public static void BlitQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex) {} // 0x0000000189CBDE2C-0x0000000189CBE070
	}

	public static class CameraCaptureBridge // TypeDefIndex: 53567
	{
		// Fields
		private static Dictionary<Camera, HashSet<Action<RenderTargetIdentifier, CommandBuffer>>> actionDict; // 0x00
		private static bool _enabled; // 0x08
	
		// Properties
		public static bool enabled { get; set; } // 0x0000000189CBF4C4-0x0000000189CBF514 0x0000000189CBF514-0x0000000189CBF568
	
		// Constructors
		static CameraCaptureBridge() {} // 0x0000000183CE50E0-0x0000000183CE5170
	
		// Methods
		public static IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> GetCaptureActions(Camera camera) => default; // 0x00000001825B41E0-0x00000001825B4300
		public static void AddCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action) {} // 0x0000000189CBF2A8-0x0000000189CBF3EC
		public static void RemoveCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action) {} // 0x0000000189CBF3EC-0x0000000189CBF4C4
	}

	public static class ColorUtils // TypeDefIndex: 53568
	{
		// Fields
		public static float s_LightMeterCalibrationConstant; // 0x00
		public static float s_LensAttenuation; // 0x04
	
		// Properties
		public static float lensImperfectionExposureScale { get; } // 0x0000000189CC0090-0x0000000189CC00F4 
	
		// Constructors
		static ColorUtils() {} // 0x0000000183D2C620-0x0000000183D2C670
	
		// Methods
		public static float StandardIlluminantY(float x) => default; // 0x0000000183D84300-0x0000000183D84330
		public static Vector3 CIExyToLMS(float x, float y) => default; // 0x0000000189CBF5D4-0x0000000189CBF664
		public static Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint) => default; // 0x0000000189CBF664-0x0000000189CBF778
		public static ValueTuple<Vector4, Vector4, Vector4> PrepareShadowsMidtonesHighlights([IsReadOnly] in Vector4 inShadows, [IsReadOnly] in Vector4 inMidtones, [IsReadOnly] in Vector4 inHighlights) => default; // 0x0000000189CBFCAC-0x0000000189CBFF0C
		public static ValueTuple<Vector4, Vector4, Vector4> PrepareLiftGammaGain([IsReadOnly] in Vector4 inLift, [IsReadOnly] in Vector4 inGamma, [IsReadOnly] in Vector4 inGain) => default; // 0x0000000189CBF928-0x0000000189CBFCAC
		public static ValueTuple<Vector4, Vector4> PrepareSplitToning([IsReadOnly] in Vector4 inShadows, [IsReadOnly] in Vector4 inHighlights, float balance) => default; // 0x0000000189CBFF0C-0x0000000189CBFF98
		public static float Luminance([IsReadOnly] in UnityEngine.Color color) => default; // 0x0000000183D842D0-0x0000000183D84300
		public static float ComputeEV100(float aperture, float shutterSpeed, float ISO) => default; // 0x0000000189CBF7E0-0x0000000189CBF804
		public static float ConvertEV100ToExposure(float EV100) => default; // 0x0000000189CBF850-0x0000000189CBF8C4
		public static float ConvertExposureToEV100(float exposure) => default; // 0x0000000189CBF8C4-0x0000000189CBF928
		public static float ComputeEV100FromAvgLuminance(float avgLuminance) => default; // 0x0000000189CBF778-0x0000000189CBF7E0
		public static float ComputeISO(float aperture, float shutterSpeed, float targetEV100) => default; // 0x0000000189CBF804-0x0000000189CBF850
		public static uint ToHex(UnityEngine.Color c) => default; // 0x0000000189CBFF98-0x0000000189CC0018
		public static UnityEngine.Color ToRGBA(uint hex) => default; // 0x0000000189CC0018-0x0000000189CC0090
	}

	public static class CoreMatrixUtils // TypeDefIndex: 53569
	{
		// Methods
		public static void MatrixTimesTranslation(ref Matrix4x4 inOutMatrix, Vector3 translation) {} // 0x0000000183D84330-0x0000000183D843C0
		public static void TranslationTimesMatrix(ref Matrix4x4 inOutMatrix, Vector3 translation) {} // 0x0000000183D84800-0x0000000183D848F0
		public static Matrix4x4 MultiplyPerspectiveMatrix(Matrix4x4 perspective, Matrix4x4 rhs) => default; // 0x0000000183D846B0-0x0000000183D84800
		private static Matrix4x4 MultiplyOrthoMatrixCentered(Matrix4x4 ortho, Matrix4x4 rhs) => default; // 0x0000000183D84570-0x0000000183D846B0
		private static Matrix4x4 MultiplyGenericOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs) => default; // 0x0000000183D843C0-0x0000000183D84570
		public static Matrix4x4 MultiplyOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs, bool centered) => default; // 0x0000000189CC00F4-0x0000000189CC01E4
		public static Matrix4x4 MultiplyProjectionMatrix(Matrix4x4 projMatrix, Matrix4x4 rhs, bool orthoCentered) => default; // 0x0000000189CC01E4-0x0000000189CC02D4
	}

	public static class CoreUtils // TypeDefIndex: 53574
	{
		// Fields
		public static readonly Vector3[] lookAtList; // 0x00
		public static readonly Vector3[] upVectorList; // 0x08
		private const string obsoletePriorityMessage = "Use CoreUtils.Priorities instead"; // Metadata: 0x01FD4784
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority1 = 320; // Metadata: 0x01FD47A5
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority2 = 331; // Metadata: 0x01FD47A7
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority3 = 342; // Metadata: 0x01FD47A9
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority4 = 353; // Metadata: 0x01FD47AB
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int assetCreateMenuPriority1 = 230; // Metadata: 0x01FD47AD
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int assetCreateMenuPriority2 = 241; // Metadata: 0x01FD47AF
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int assetCreateMenuPriority3 = 300; // Metadata: 0x01FD47B1
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int gameObjectMenuPriority = 10; // Metadata: 0x01FD47B3
		private static Cubemap m_BlackCubeTexture; // 0x10
		private static Cubemap m_MagentaCubeTexture; // 0x18
		private static CubemapArray m_MagentaCubeTextureArray; // 0x20
		private static Cubemap m_WhiteCubeTexture; // 0x28
		private static RenderTexture m_EmptyUAV; // 0x30
		private static Texture3D m_BlackVolumeTexture; // 0x38
		private static IEnumerable<System.Type> m_AssemblyTypes; // 0x40
	
		// Properties
		public static Cubemap blackCubeTexture { get; } // 0x0000000189CC2F44-0x0000000189CC30D8 
		public static Cubemap magentaCubeTexture { get; } // 0x0000000189CC35A0-0x0000000189CC3734 
		public static CubemapArray magentaCubeTextureArray { get; } // 0x0000000189CC33D0-0x0000000189CC35A0 
		public static Cubemap whiteCubeTexture { get; } // 0x0000000189CC3734-0x0000000189CC38C8 
		public static RenderTexture emptyUAV { get; } // 0x0000000189CC3288-0x0000000189CC33D0 
		public static Texture3D blackVolumeTexture { get; } // 0x0000000189CC30D8-0x0000000189CC3288 
	
		// Nested types
		public static class Sections // TypeDefIndex: 53570
		{
			// Fields
			public const int section1 = 10000; // Metadata: 0x01FD47B4
			public const int section2 = 20000; // Metadata: 0x01FD47B8
			public const int section3 = 30000; // Metadata: 0x01FD47BC
			public const int section4 = 40000; // Metadata: 0x01FD47C0
			public const int section5 = 50000; // Metadata: 0x01FD47C4
			public const int section6 = 60000; // Metadata: 0x01FD47C8
			public const int section7 = 70000; // Metadata: 0x01FD47CC
			public const int section8 = 80000; // Metadata: 0x01FD47D0
		}
	
		public static class Priorities // TypeDefIndex: 53571
		{
			// Fields
			public const int assetsCreateShaderMenuPriority = 83; // Metadata: 0x01FD47D4
			public const int assetsCreateRenderingMenuPriority = 308; // Metadata: 0x01FD47D6
			public const int editMenuPriority = 320; // Metadata: 0x01FD47D8
			public const int gameObjectMenuPriority = 10; // Metadata: 0x01FD47DA
			public const int srpLensFlareMenuPriority = 303; // Metadata: 0x01FD47DB
		}
	
		// Constructors
		static CoreUtils() {} // 0x00000001838E50D0-0x00000001838E5300
	
		// Methods
		public static void ClearRenderTarget(CommandBuffer cmd, ClearFlag clearFlag, UnityEngine.Color clearColor) {} // 0x0000000189CC0424-0x0000000189CC0464
		private static int FixupDepthSlice(int depthSlice, RTHandle buffer) => default; // 0x0000000189CC11E0-0x0000000189CC1224
		private static int FixupDepthSlice(int depthSlice, CubemapFace cubemapFace) => default; // 0x0000000189CC11D0-0x0000000189CC11E0
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel = 0 /* Metadata: 0x01FD4745 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x01FD4746 */, int depthSlice = -1 /* Metadata: 0x01FD4747 */) {} // 0x0000000189CC1CE0-0x0000000189CC1DC0
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag = ClearFlag.None /* Metadata: 0x01FD4748 */, int miplevel = 0 /* Metadata: 0x01FD4749 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x01FD474A */, int depthSlice = -1 /* Metadata: 0x01FD474B */) {} // 0x0000000189CC1ED0-0x0000000189CC1FA4
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, int miplevel = 0 /* Metadata: 0x01FD474C */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x01FD474D */, int depthSlice = -1 /* Metadata: 0x01FD474E */) {} // 0x0000000189CC2B60-0x0000000189CC2C68
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, int miplevel = 0 /* Metadata: 0x01FD474F */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x01FD4750 */, int depthSlice = -1 /* Metadata: 0x01FD4751 */) {} // 0x0000000189CC1DC0-0x0000000189CC1ED0
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel = 0 /* Metadata: 0x01FD4752 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x01FD4753 */, int depthSlice = -1 /* Metadata: 0x01FD4754 */) {} // 0x0000000189CC259C-0x0000000189CC26B4
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer) {} // 0x0000000189CC1C28-0x0000000189CC1CE0
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag = ClearFlag.None /* Metadata: 0x01FD4755 */) {} // 0x0000000189CC1B68-0x0000000189CC1C28
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, UnityEngine.Color clearColor) {} // 0x0000000189CC26B4-0x0000000189CC2788
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, UnityEngine.Color clearColor) {} // 0x0000000189CC2C68-0x0000000189CC2D30
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag) {} // 0x0000000189CC288C-0x0000000189CC2958
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, UnityEngine.Color clearColor) {} // 0x0000000189CC2A44-0x0000000189CC2B60
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, UnityEngine.Color clearColor) {} // 0x0000000189CC1FA4-0x0000000189CC2088
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag) {} // 0x0000000189CC22B0-0x0000000189CC23D0
		private static void SetViewportAndClear(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, UnityEngine.Color clearColor) {} // 0x0000000189CC2DE0-0x0000000189CC2E68
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel = 0 /* Metadata: 0x01FD4756 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x01FD4757 */, int depthSlice = -1 /* Metadata: 0x01FD4758 */) {} // 0x0000000189CC2788-0x0000000189CC288C
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag = ClearFlag.None /* Metadata: 0x01FD4759 */, int miplevel = 0 /* Metadata: 0x01FD475A */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x01FD475B */, int depthSlice = -1 /* Metadata: 0x01FD475C */) {} // 0x0000000189CC2D30-0x0000000189CC2DE0
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, int miplevel = 0 /* Metadata: 0x01FD475D */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x01FD475E */, int depthSlice = -1 /* Metadata: 0x01FD475F */) {} // 0x0000000189CC2184-0x0000000189CC22B0
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, int miplevel = 0 /* Metadata: 0x01FD4760 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x01FD4761 */, int depthSlice = -1 /* Metadata: 0x01FD4762 */) {} // 0x0000000189CC1934-0x0000000189CC1A68
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel = 0 /* Metadata: 0x01FD4763 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x01FD4764 */, int depthSlice = -1 /* Metadata: 0x01FD4765 */) {} // 0x0000000189CC23D0-0x0000000189CC259C
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer) {} // 0x0000000189CC1A68-0x0000000189CC1B68
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag = ClearFlag.None /* Metadata: 0x01FD4766 */) {} // 0x0000000189CC2088-0x0000000189CC2184
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag, UnityEngine.Color clearColor) {} // 0x0000000189CC2958-0x0000000189CC2A44
		public static void SetViewport(CommandBuffer cmd, RTHandle target) {} // 0x0000000189CC2E68-0x0000000189CC2F44
		public static string GetRenderTargetAutoName(int width, int height, int depth, RenderTextureFormat format, string name, bool mips = false /* Metadata: 0x01FD4767 */, bool enableMSAA = false /* Metadata: 0x01FD4768 */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x01FD4769 */) => default; // 0x0000000182526050-0x0000000182526150
		public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, string name, bool mips = false /* Metadata: 0x01FD476A */, bool enableMSAA = false /* Metadata: 0x01FD476B */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x01FD476C */) => default; // 0x0000000189CC1250-0x0000000189CC1330
		public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, TextureDimension dim, string name, bool mips = false /* Metadata: 0x01FD476D */, bool enableMSAA = false /* Metadata: 0x01FD476E */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x01FD476F */, bool dynamicRes = false /* Metadata: 0x01FD4770 */) => default; // 0x0000000182524420-0x0000000182524530
		private static string GetRenderTargetAutoName(int width, int height, int depth, string format, TextureDimension dim, string name, bool mips, bool enableMSAA, MSAASamples msaaSamples, bool dynamicRes) => default; // 0x0000000182526150-0x0000000182526310
		public static string GetTextureAutoName(int width, int height, TextureFormat format, TextureDimension dim = TextureDimension.None /* Metadata: 0x01FD4771 */, string name = "" /* Metadata: 0x01FD4772 */, bool mips = false /* Metadata: 0x01FD4773 */, int depth = 0 /* Metadata: 0x01FD4774 */) => default; // 0x0000000189CC13F8-0x0000000189CC14C0
		public static string GetTextureAutoName(int width, int height, GraphicsFormat format, TextureDimension dim = TextureDimension.None /* Metadata: 0x01FD4775 */, string name = "" /* Metadata: 0x01FD4776 */, bool mips = false /* Metadata: 0x01FD4777 */, int depth = 0 /* Metadata: 0x01FD4778 */) => default; // 0x0000000189CC1330-0x0000000189CC13F8
		private static string GetTextureAutoName(int width, int height, string format, TextureDimension dim = TextureDimension.None /* Metadata: 0x01FD4779 */, string name = "" /* Metadata: 0x01FD477A */, bool mips = false /* Metadata: 0x01FD477B */, int depth = 0 /* Metadata: 0x01FD477C */) => default; // 0x0000000189CC14C0-0x0000000189CC17BC
		public static void ClearCubemap(CommandBuffer cmd, RenderTexture renderTexture, UnityEngine.Color clearColor, bool clearMips = false /* Metadata: 0x01FD477D */) {} // 0x0000000189CC02D4-0x0000000189CC0424
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x01FD477E */) {} // 0x0000000189CC0C0C-0x0000000189CC0CB8
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x01FD477F */) {} // 0x0000000189CC0CB8-0x0000000189CC0D9C
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x01FD4780 */) {} // 0x0000000189CC0D9C-0x0000000189CC0E94
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x01FD4781 */) {} // 0x0000000189CC0A58-0x0000000189CC0B40
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x01FD4782 */) {} // 0x0000000189CC0B40-0x0000000189CC0C0C
		public static UnityEngine.Color ConvertSRGBToActiveColorSpace(UnityEngine.Color color) => default; // 0x0000000189CC04A8-0x0000000189CC04EC
		public static UnityEngine.Color ConvertLinearToActiveColorSpace(UnityEngine.Color color) => default; // 0x0000000189CC0464-0x0000000189CC04A8
		public static Material CreateEngineMaterial(string shaderPath) => default; // 0x0000000189CC0958-0x0000000189CC0A58
		public static Material CreateEngineMaterial(Shader shader, bool enableInstancing = false /* Metadata: 0x01FD4783 */) => default; // 0x0000000182E80300-0x0000000182E803F0
		public static bool HasFlag<T>(T mask, T flag)
			where T : IConvertible => default;
		public static void Swap<T>(ref ref T a, ref ref T b) {}
		public static void SetKeyword(CommandBuffer cmd, string keyword, bool state) {} // 0x0000000189CC1900-0x0000000189CC1934
		public static void SetKeyword(Material material, string keyword, bool state) {} // 0x00000001856EC558-0x00000001856EC58C
		public static void SetKeyword(ComputeShader cs, string keyword, bool state) {} // 0x0000000189CC18CC-0x0000000189CC1900
		public static void Destroy(UnityEngine.Object obj) {} // 0x0000000182E7FD30-0x0000000182E7FDB0
		public static IEnumerable<System.Type> GetAllAssemblyTypes() => default; // 0x000000018267CE90-0x000000018267D070
		public static IEnumerable<System.Type> GetAllTypesDerivedFrom<T>() => default;
		public static void SafeRelease(ComputeBuffer buffer) {} // 0x0000000189CC18BC-0x0000000189CC18CC
		public static Mesh CreateCubeMesh(Vector3 min, Vector3 max) => default; // 0x0000000189CC04EC-0x0000000189CC0958
		public static bool ArePostProcessesEnabled(Camera camera) => default; // 0x000000018232EB60-0x000000018232EB70
		public static bool AreAnimatedMaterialsEnabled(Camera camera) => default; // 0x000000018232EB60-0x000000018232EB70
		public static bool IsSceneLightingDisabled(Camera camera) => default; // 0x000000018115F4C0-0x000000018115F530
		public static bool IsLightOverlapDebugEnabled(Camera camera) => default; // 0x000000018115F4C0-0x000000018115F530
		public static bool IsSceneViewFogEnabled(Camera camera) => default; // 0x000000018232EB60-0x000000018232EB70
		public static bool IsSceneFilteringEnabled() => default; // 0x000000018115F4C0-0x000000018115F530
		public static bool IsSceneViewPrefabStageContextHidden() => default; // 0x000000018115F4C0-0x000000018115F530
		[Obsolete("Use the updated RendererList API in the UnityEngine.Rendering.RendererUtils namespace.")]
		public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, UnityEngine.Experimental.Rendering.RendererList rendererList) {} // 0x0000000189CC0E94-0x0000000189CC1158
		public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, UnityEngine.Rendering.RendererUtils.RendererList rendererList) {} // 0x0000000189CC1158-0x0000000189CC11D0
		public static int GetTextureHash(Texture texture) => default; // 0x0000000189CC17BC-0x0000000189CC1888
		public static int PreviousPowerOfTwo(int size) => default; // 0x0000000189CC1888-0x0000000189CC18BC
		public static T GetLastEnumValue<T>()
			where T : Enum => default;
		internal static string GetCorePath() => default; // 0x0000000189CC1224-0x0000000189CC1250
	}

	public static class DelegateUtility // TypeDefIndex: 53575
	{
		// Methods
		public static Delegate Cast(Delegate source, System.Type type) => default; // 0x0000000189CC5D84-0x0000000189CC5EC4
	}

	public static class FSRUtils // TypeDefIndex: 53577
	{
		// Fields
		internal const float kMaxSharpnessStops = 2.5f; // Metadata: 0x01FD47E5
		public const float kDefaultSharpnessStops = 0.2f; // Metadata: 0x01FD47E9
		public const float kDefaultSharpnessLinear = 0.92f; // Metadata: 0x01FD47ED
	
		// Nested types
		private static class ShaderConstants // TypeDefIndex: 53576
		{
			// Fields
			public static readonly int _FsrEasuConstants0; // 0x00
			public static readonly int _FsrEasuConstants1; // 0x04
			public static readonly int _FsrEasuConstants2; // 0x08
			public static readonly int _FsrEasuConstants3; // 0x0C
			public static readonly int _FsrRcasConstants; // 0x10
	
			// Constructors
			static ShaderConstants() {} // 0x0000000189CC8CD0-0x0000000189CC8DCC
		}
	
		// Methods
		public static void SetEasuConstants(CommandBuffer cmd, Vector2 inputViewportSizeInPixels, Vector2 inputImageSizeInPixels, Vector2 outputImageSizeInPixels) {} // 0x0000000189CC5EDC-0x0000000189CC60C8
		public static void SetRcasConstants(CommandBuffer cmd, float sharpnessStops = 0.2f /* Metadata: 0x01FD47DD */) {} // 0x0000000189CC60E8-0x0000000189CC61C4
		public static void SetRcasConstantsLinear(CommandBuffer cmd, float sharpnessLinear = 0.92f /* Metadata: 0x01FD47E1 */) {} // 0x0000000189CC60C8-0x0000000189CC60E8
		public static bool IsSupported() => default; // 0x0000000189CC5EC4-0x0000000189CC5EDC
	}

	public class HableCurve // TypeDefIndex: 53581
	{
		// Fields
		public readonly Segment[] segments; // 0x20
		public readonly Uniforms uniforms; // 0x28
	
		// Properties
		public float whitePoint { get; private set; } // 0x0000000183D4E7A0-0x0000000183D4E7B0 0x0000000183D50CA0-0x0000000183D50CB0
		public float inverseWhitePoint { get; private set; } // 0x0000000183D51930-0x0000000183D51940 0x0000000183D51940-0x0000000183D51950
		public float x0 { get; private set; } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
		public float x1 { get; private set; } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
	
		// Nested types
		public class Segment // TypeDefIndex: 53578
		{
			// Fields
			public float offsetX; // 0x10
			public float offsetY; // 0x14
			public float scaleX; // 0x18
			public float scaleY; // 0x1C
			public float lnA; // 0x20
			public float B; // 0x24
	
			// Constructors
			public Segment() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public float Eval(float x) => default; // 0x0000000189CC8C8C-0x0000000189CC8CD0
		}
	
		private struct DirectParams // TypeDefIndex: 53579
		{
			// Fields
			internal float x0; // 0x00
			internal float y0; // 0x04
			internal float x1; // 0x08
			internal float y1; // 0x0C
			internal float W; // 0x10
			internal float overshootX; // 0x14
			internal float overshootY; // 0x18
			internal float gamma; // 0x1C
		}
	
		public class Uniforms // TypeDefIndex: 53580
		{
			// Fields
			private HableCurve parent; // 0x10
	
			// Properties
			public Vector4 curve { get => default; } // 0x0000000189CC9468-0x0000000189CC94A0 
			public Vector4 toeSegmentA { get => default; } // 0x0000000189CC9688-0x0000000189CC9714 
			public Vector4 toeSegmentB { get => default; } // 0x0000000189CC9714-0x0000000189CC977C 
			public Vector4 midSegmentA { get => default; } // 0x0000000189CC94A0-0x0000000189CC952C 
			public Vector4 midSegmentB { get => default; } // 0x0000000189CC952C-0x0000000189CC9594 
			public Vector4 shoSegmentA { get => default; } // 0x0000000189CC9594-0x0000000189CC9620 
			public Vector4 shoSegmentB { get => default; } // 0x0000000189CC9620-0x0000000189CC9688 
	
			// Constructors
			public Uniforms() {} // Dummy constructor
			internal Uniforms(HableCurve parent) {} // 0x000000018426FEE0-0x000000018426FEF0
		}
	
		// Constructors
		public HableCurve() {} // 0x0000000189CC6998-0x0000000189CC6A9C
	
		// Methods
		public float Eval(float x) => default; // 0x0000000189CC6234-0x0000000189CC629C
		public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma) {} // 0x0000000189CC6784-0x0000000189CC6928
		private void InitSegments(DirectParams srcParams) {} // 0x0000000189CC629C-0x0000000189CC6784
		private void SolveAB(out float lnA, out float B, float x0, float y0, float m) {
			lnA = default;
			B = default;
		} // 0x0000000189CC6928-0x0000000189CC6998
		private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1) {
			m = default;
			b = default;
		} // 0x0000000189CC61EC-0x0000000189CC6234
		private float EvalDerivativeLinearGamma(float m, float b, float g, float x) => default; // 0x0000000183D84960-0x0000000183D849B0
	}

	public static class HaltonSequence // TypeDefIndex: 53582
	{
		// Methods
		public static float Get(int index, int radix) => default; // 0x000000018272BF50-0x000000018272BFA0
	}

	[Flags]
	[MovedFrom("Utilities")]
	public enum MaterialQuality // TypeDefIndex: 53583
	{
		Low = 1,
		Medium = 2,
		High = 4
	}

	[MovedFrom("Utilities")]
	public static class MaterialQualityUtilities // TypeDefIndex: 53584
	{
		// Fields
		public static string[] KeywordNames; // 0x00
		public static string[] EnumNames; // 0x08
		public static ShaderKeyword[] Keywords; // 0x10
	
		// Constructors
		static MaterialQualityUtilities() {} // 0x0000000189CC6EC4-0x0000000189CC7178
	
		// Methods
		public static MaterialQuality FromIndex(int index) => default; // 0x0000000183D516D0-0x0000000183D516E0
	
		// Extension methods
		public static MaterialQuality GetHighestQuality(this MaterialQuality levels) => default; // 0x0000000189CC6BF8-0x0000000189CC6C6C
		public static MaterialQuality GetClosestQuality(this MaterialQuality availableLevels, MaterialQuality requestedLevel) => default; // 0x0000000189CC6AF0-0x0000000189CC6BF8
		public static void SetGlobalShaderKeywords(this MaterialQuality level) {} // 0x0000000189CC6C6C-0x0000000189CC6D48
		public static void SetGlobalShaderKeywords(this MaterialQuality level, CommandBuffer cmd) {} // 0x0000000189CC6D48-0x0000000189CC6E48
		public static int ToFirstIndex(this MaterialQuality level) => default; // 0x0000000189CC6E48-0x0000000189CC6EC4
	}

	internal class MeshGizmo : IDisposable // TypeDefIndex: 53586
	{
		// Fields
		public static readonly int vertexCountPerCube; // 0x00
		public Mesh mesh; // 0x10
		private List<Vector3> vertices; // 0x18
		private List<int> indices; // 0x20
		private List<UnityEngine.Color> colors; // 0x28
		private Material wireMaterial; // 0x30
		private Material dottedWireMaterial; // 0x38
		private Material solidMaterial; // 0x40
	
		// Constructors
		public MeshGizmo() {} // Dummy constructor
		public MeshGizmo(int capacity = 0 /* Metadata: 0x01FD47F4 */) {} // 0x0000000189CC7F84-0x0000000189CC80F8
		static MeshGizmo() {} // 0x0000000189CC7F48-0x0000000189CC7F84
	
		// Methods
		public void Clear() {} // 0x0000000189CC7B08-0x0000000189CC7B84
		public void AddWireCube(Vector3 center, Vector3 size, UnityEngine.Color color) {} // 0x0000000189CC71C4-0x0000000189CC7B08
		private void DrawMesh(Matrix4x4 trs, Material mat, MeshTopology topology, CompareFunction depthTest, string gizmoName) {} // 0x0000000189CC7BD4-0x0000000189CC7D94
		public void RenderWireframe(Matrix4x4 trs, CompareFunction depthTest = CompareFunction.LessEqual /* Metadata: 0x01FD47F5 */, string gizmoName = null) {} // 0x0000000189CC7D94-0x0000000189CC7DE8
		public void Dispose() {} // 0x0000000189CC7B84-0x0000000189CC7BD4
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class ReloadAttribute : Attribute // TypeDefIndex: 53588
	{
		// Nested types
		public enum Package // TypeDefIndex: 53587
		{
			Builtin = 0,
			Root = 1
		}
	
		// Constructors
		public ReloadAttribute() {} // Dummy constructor
		public ReloadAttribute(string[] paths, Package package = Package.Root /* Metadata: 0x01FD47F6 */) {} // 0x000000018350B670-0x000000018350B680
		public ReloadAttribute(string path, Package package = Package.Root /* Metadata: 0x01FD47F7 */) {} // 0x0000000189CC8B28-0x0000000189CC8B7C
		public ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, Package package = Package.Root /* Metadata: 0x01FD47F8 */) {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ReloadGroupAttribute : Attribute // TypeDefIndex: 53589
	{
		// Constructors
		public ReloadGroupAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class TextureCurve : IDisposable // TypeDefIndex: 53590
	{
		// Fields
		private const int k_Precision = 128; // Metadata: 0x01FD47FB
		private const float k_Step = 0.0078125f; // Metadata: 0x01FD47FD
		[SerializeField]
		private bool m_Loop; // 0x14
		[SerializeField]
		private float m_ZeroValue; // 0x18
		[SerializeField]
		private float m_Range; // 0x1C
		[SerializeField]
		private AnimationCurve m_Curve; // 0x20
		private AnimationCurve m_LoopingCurve; // 0x28
		private Texture2D m_Texture; // 0x30
		private bool m_IsCurveDirty; // 0x38
		private bool m_IsTextureDirty; // 0x39
		private int m_LastUpdatedFrame; // 0x3C
	
		// Properties
		public int length { get; private set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public Keyframe this[int index] { get => default; } // 0x0000000189CC90F0-0x0000000189CC9134 
	
		// Constructors
		public TextureCurve() {} // Dummy constructor
		public TextureCurve(AnimationCurve baseCurve, float zeroValue, bool loop, [IsReadOnly] in Vector2 bounds) {} // 0x0000000189CC908C-0x0000000189CC90F0
		public TextureCurve(Keyframe[] keys, float zeroValue, bool loop, [IsReadOnly] in Vector2 bounds) {} // 0x0000000182700EA0-0x0000000182700F80
	
		// Methods
		public bool IsTextureCurveDirty() => default; // 0x0000000182508660-0x0000000182508690
		~TextureCurve() {} // 0x0000000183529690-0x00000001835296B0
		[Obsolete("Please use Release() instead.")]
		public void Dispose() {} // 0x000000018350B670-0x000000018350B680
		public void Release() {} // 0x0000000182E7EB60-0x0000000182E7EBD0
		public void SetDirty() {} // 0x0000000183D849E0-0x0000000183D849F0
		private static GraphicsFormat GetTextureFormat() => default; // 0x0000000182527560-0x0000000182527590
		public Texture2D GetTexture() => default; // 0x0000000182508690-0x0000000182508940
		public float Evaluate(float time) => default; // 0x0000000182A3BE50-0x0000000182A3BF40
		public int AddKey(float time, float value) => default; // 0x0000000189CC8FB0-0x0000000189CC8FE4
		public int MoveKey(int index, [IsReadOnly] in Keyframe key) => default; // 0x0000000189CC8FE4-0x0000000189CC9034
		public void RemoveKey(int index) {} // 0x0000000189CC9034-0x0000000189CC9060
		public void SmoothTangents(int index, float weight) {} // 0x0000000189CC9060-0x0000000189CC908C
	}

	[Serializable]
	public class TextureCurveParameter : VolumeParameter<TextureCurve> // TypeDefIndex: 53591
	{
		// Constructors
		public TextureCurveParameter() {} // Dummy constructor
		public TextureCurveParameter(TextureCurve value, bool overrideState = false /* Metadata: 0x01FD4801 */) {} // 0x0000000182700E40-0x0000000182700EA0
	
		// Methods
		public override void Release() {} // 0x0000000182E7EB40-0x0000000182E7EB60
	}

	public static class TileLayoutUtils // TypeDefIndex: 53592
	{
		// Methods
		public static bool TryLayoutByTiles(RectInt src, uint tileSize, out RectInt main, out RectInt topRow, out RectInt rightCol, out RectInt topRight) {
			main = default;
			topRow = default;
			rightCol = default;
			topRight = default;
			return default;
		} // 0x0000000189CC92D8-0x0000000189CC93D4
		public static bool TryLayoutByRow(RectInt src, uint tileSize, out RectInt main, out RectInt other) {
			main = default;
			other = default;
			return default;
		} // 0x0000000189CC9264-0x0000000189CC92D8
		public static bool TryLayoutByCol(RectInt src, uint tileSize, out RectInt main, out RectInt other) {
			main = default;
			other = default;
			return default;
		} // 0x0000000189CC91F4-0x0000000189CC9264
	}

	public static class XRUtils // TypeDefIndex: 53593
	{
		// Methods
		public static void DrawOcclusionMesh(CommandBuffer cmd, Camera camera, bool stereoEnabled = true /* Metadata: 0x01FD4802 */) {} // 0x0000000189CCA584-0x0000000189CCA61C
	}

	public interface IVolume // TypeDefIndex: 53594
	{
		// Properties
		bool isGlobal { get; set; }
		List<Collider> colliders { get; }
	}

	[AddComponentMenu("Miscellaneous/Volume")]
	[ExecuteAlways]
	public class Volume : MonoBehaviour, IVolume // TypeDefIndex: 53595
	{
		// Fields
		[FormerlySerializedAs("isGlobal")]
		[SerializeField]
		private bool m_IsGlobal; // 0x18
		[HideInInspector]
		public bool isLunaPlatform; // 0x19
		public Action<VolumeProfile> LunaCreateVolumeProfile; // 0x20
		[Tooltip("When multiple Volumes affect the same settings, Unity uses this value to determine which Volume to use. A Volume with the highest Priority value takes precedence.")]
		public float priority; // 0x28
		[Tooltip("Sets the outer distance to start blending from. A value of 0 means no blending and Unity applies the Volume overrides immediately upon entry.")]
		public float blendDistance; // 0x2C
		[Range(0f, 1f)]
		[Tooltip("Sets the total weight of this Volume in the Scene. 0 means no effect and 1 means full effect.")]
		public float weight; // 0x30
		public VolumeProfile sharedProfile; // 0x38
		internal List<Collider> m_Colliders; // 0x40
		private int m_PreviousLayer; // 0x48
		private float m_PreviousPriority; // 0x4C
		private VolumeProfile m_InternalProfile; // 0x50
	
		// Properties
		[Tooltip("When enabled, the Volume is applied to the entire Scene.")]
		public bool isGlobal { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public List<Collider> colliders { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		internal VolumeProfile profileRef { get => default; } // 0x0000000182520010-0x0000000182520120 
	
		// Constructors
		public Volume() {} // 0x00000001832B4B40-0x00000001832B4BD0
	
		// Methods
		public VolumeProfile GetInstantiatedProfile() => default; // 0x0000000189CCA248-0x0000000189CCA49C
		public void SetInstantiatedProfile(VolumeProfile profile) {} // 0x0000000182C926C0-0x0000000182C926D0
		public bool HasInstantiatedProfile() => default; // 0x0000000189CCA49C-0x0000000189CCA4EC
		private void OnEnable() {} // 0x00000001827AE1C0-0x00000001827AE270
		private void OnDisable() {} // 0x00000001827AD700-0x00000001827AD790
		private void Update() {} // 0x0000000182393C90-0x0000000182393DD0
		internal void UpdateLayer() {} // 0x0000000182393DD0-0x0000000182393E70
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class VolumeComponentMenu : Attribute // TypeDefIndex: 53596
	{
		// Fields
		public readonly string menu; // 0x10
	
		// Constructors
		public VolumeComponentMenu() {} // Dummy constructor
		public VolumeComponentMenu(string menu) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public class VolumeComponentMenuForRenderPipeline : VolumeComponentMenu // TypeDefIndex: 53597
	{
		// Properties
		public System.Type[] pipelineTypes { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public VolumeComponentMenuForRenderPipeline() {} // Dummy constructor
		public VolumeComponentMenuForRenderPipeline(string menu, params System.Type[] pipelineTypes) {} // 0x0000000189CC977C-0x0000000189CC9948
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Obsolete("VolumeComponentDeprecated has been deprecated (UnityUpgradable) -> [UnityEngine] UnityEngine.HideInInspector", false)]
	public sealed class VolumeComponentDeprecated : Attribute // TypeDefIndex: 53598
	{
		// Constructors
		public VolumeComponentDeprecated() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class MigratingVolumeComponent : Attribute // TypeDefIndex: 53599
	{
		// Constructors
		public MigratingVolumeComponent() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class VolumeComponent : ScriptableObject // TypeDefIndex: 53602
	{
		// Fields
		public bool active; // 0x18
	
		// Properties
		public string displayName { get; protected set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public VolumeParameter[] parameters { get; private set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
	
		// Nested types
		public sealed class Indent : PropertyAttribute // TypeDefIndex: 53600
		{
			// Fields
			public readonly int relativeAmount; // 0x10
	
			// Constructors
			public Indent() {} // Dummy constructor
			public Indent(int relativeAmount = 1 /* Metadata: 0x01FD4803 */) {} // 0x00000001810410F0-0x0000000181041100
		}
	
		// Constructors
		public VolumeComponent() {} // 0x000000018286F2A0-0x000000018286F2F0
	
		// Methods
		internal static void FindParameters(object o, List<VolumeParameter> parameters, Func<System.Reflection.FieldInfo, bool> filter = null) {} // 0x00000001824D89D0-0x00000001824D8EA0
		protected virtual void OnEnable() {} // 0x00000001824D88B0-0x00000001824D89D0
		protected virtual void OnDisable() {} // 0x00000001832F4FF0-0x00000001832F5020
		public virtual void Override(VolumeComponent state, float interpFactor) {} // 0x0000000182520410-0x0000000182520EE0
		public void SetAllOverridesTo(bool state) {} // 0x0000000183709CC0-0x0000000183709CD0
		internal void SetOverridesTo(IEnumerable<VolumeParameter> enumerable, bool state) {} // 0x0000000183709CD0-0x0000000183709F00
		public override int GetHashCode() => default; // 0x0000000189CC9948-0x0000000189CC99B4
		protected virtual void OnDestroy() {} // 0x00000001832B9480-0x00000001832B9490
		public void Release() {} // 0x00000001832B9490-0x00000001832B9500
	}

	public sealed class VolumeManager // TypeDefIndex: 53604
	{
		// Fields
		private static readonly Lazy<VolumeManager> s_Instance; // 0x00
		private const int k_MaxLayerCount = 32; // Metadata: 0x01FD4804
		private readonly Dictionary<int, List<UnityEngine.Rendering.Volume>> m_SortedVolumes; // 0x20
		private readonly List<UnityEngine.Rendering.Volume> m_Volumes; // 0x28
		private readonly Dictionary<int, bool> m_SortNeeded; // 0x30
		private readonly List<VolumeComponent> m_ComponentsDefaultState; // 0x38
		private readonly List<Collider> m_TempColliders; // 0x40
		private VolumeStack m_DefaultStack; // 0x48
	
		// Properties
		public static VolumeManager instance { get => default; } // 0x00000001825AFBA0-0x00000001825AFC20 
		public VolumeStack stack { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		[Obsolete("Please use baseComponentTypeArray instead.")]
		public IEnumerable<System.Type> baseComponentTypes { get => default; private set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000189CC9DC8-0x0000000189CC9E1C
		public System.Type[] baseComponentTypeArray { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		private VolumeManager() {} // 0x00000001827ABBE0-0x00000001827ABDC0
		static VolumeManager() {} // 0x0000000183B5DB60-0x0000000183B5DC70
	
		// Methods
		public VolumeStack CreateStack() => default; // 0x0000000182522A90-0x0000000182522B00
		public void ResetMainStack() {} // 0x0000000189CC9D50-0x0000000189CC9D64
		public void DestroyStack(VolumeStack stack) {} // 0x0000000183D07B20-0x0000000183D07B40
		private void ReloadBaseTypes() {} // 0x0000000182522270-0x00000001825224E0
		public void Register(UnityEngine.Rendering.Volume volume, int layer) {} // 0x00000001827AE3F0-0x00000001827AE5E0
		public void Unregister(UnityEngine.Rendering.Volume volume, int layer) {} // 0x00000001827AE270-0x00000001827AE3F0
		public bool IsComponentActiveInMask<T>(LayerMask layerMask)
			where T : VolumeComponent => default;
		internal void SetLayerDirty(int layer) {} // 0x00000001827AE5E0-0x00000001827AE790
		internal void UpdateVolumeLayer(UnityEngine.Rendering.Volume volume, int prevLayer, int newLayer) {} // 0x0000000189CC9D64-0x0000000189CC9DA4
		private void OverrideData(VolumeStack stack, List<VolumeComponent> components, float interpFactor) {} // 0x0000000182520120-0x00000001825202D0
		private void ReplaceData(VolumeStack stack) {} // 0x0000000182521410-0x0000000182521790
		[Conditional("UNITY_EDITOR")]
		public void CheckBaseTypes() {} // 0x0000000189CC99B4-0x0000000189CC9A4C
		[Conditional("UNITY_EDITOR")]
		public void CheckStack(VolumeStack stack) {} // 0x0000000189CC9A4C-0x0000000189CC9C14
		private bool CheckUpdateRequired(VolumeStack stack) => default; // 0x000000018302D600-0x000000018302D660
		public void Update(Transform trigger, LayerMask layerMask) {} // 0x0000000189CC9DA4-0x0000000189CC9DC8
		public void Update(VolumeStack stack, Transform trigger, LayerMask layerMask) {} // 0x000000018251EE60-0x0000000182520010
		public UnityEngine.Rendering.Volume[] GetVolumes(LayerMask layerMask) => default; // 0x0000000189CC9C14-0x0000000189CC9D50
		private List<UnityEngine.Rendering.Volume> GrabVolumes(LayerMask mask) => default; // 0x00000001827AD790-0x00000001827AE1C0
		private static void SortByPriority(List<UnityEngine.Rendering.Volume> volumes) {} // 0x00000001827AE790-0x00000001827AE8B0
		private static bool IsVolumeRenderedByCamera(UnityEngine.Rendering.Volume volume, Camera camera) => default; // 0x000000018232EB60-0x000000018232EB70
	}

	[Obsolete("VolumeIsolationScope is deprecated, it does not have any effect anymore.")]
	public struct VolumeIsolationScope : IDisposable // TypeDefIndex: 53605
	{
		// Constructors
		public VolumeIsolationScope(bool unused) {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		void IDisposable.Dispose() {} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class VolumeParameter // TypeDefIndex: 53606
	{
		// Fields
		public const string k_DebuggerDisplay = "{m_Value} ({overrideState})"; // Metadata: 0x01FD4805
		[FormerlySerializedAs("m_OverrideState")]
		[SerializeField]
		public bool overrideState; // 0x10
	
		// Constructors
		protected VolumeParameter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal abstract void Interp(VolumeParameter from, VolumeParameter to, float t);
		public T GetValue<T>() => default;
		public abstract void SetValue(VolumeParameter parameter);
		protected internal virtual void OnEnable() {} // 0x000000018350B670-0x000000018350B680
		protected internal virtual void OnDisable() {} // 0x000000018350B670-0x000000018350B680
		public virtual void Release() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class VolumeParameter<T> : VolumeParameter, IEquatable<VolumeParameter<T>> // TypeDefIndex: 53607
	{
		// Fields
		[SerializeField]
		protected T m_Value;
	
		// Properties
		public virtual T value { get => default; set {} }
	
		// Constructors
		public VolumeParameter() {}
		protected VolumeParameter(T value, bool overrideState) {}
	
		// Methods
		internal override void Interp(VolumeParameter from, VolumeParameter to, float t) {}
		public virtual void Interp(T from, T to, float t) {}
		public void Override(T x) {}
		public override void SetValue(VolumeParameter parameter) {}
		public override int GetHashCode() => default;
		public override string ToString() => default;
		public static bool operator ==(VolumeParameter<T> lhs, T rhs) => default;
		public static bool operator !=(VolumeParameter<T> lhs, T rhs) => default;
		public bool Equals(VolumeParameter<T> other) => default;
		public override bool Equals(object obj) => default;
		public static explicit operator T(VolumeParameter<T> prop) => default;
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class BoolParameter : VolumeParameter<bool> // TypeDefIndex: 53608
	{
		// Constructors
		public BoolParameter() {} // Dummy constructor
		public BoolParameter(bool value, bool overrideState = false /* Metadata: 0x01FD4821 */) {} // 0x0000000182C62DD0-0x0000000182C62E40
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class LayerMaskParameter : VolumeParameter<LayerMask> // TypeDefIndex: 53609
	{
		// Constructors
		public LayerMaskParameter() {} // Dummy constructor
		public LayerMaskParameter(LayerMask value, bool overrideState = false /* Metadata: 0x01FD4822 */) {} // 0x0000000189CC6A9C-0x0000000189CC6AF0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class IntParameter : VolumeParameter<int> // TypeDefIndex: 53610
	{
		// Constructors
		public IntParameter() {} // Dummy constructor
		public IntParameter(int value, bool overrideState = false /* Metadata: 0x01FD4823 */) {} // 0x0000000183807430-0x00000001838074A0
	
		// Methods
		public sealed override void Interp(int from, int to, float t) {} // 0x0000000183D849B0-0x0000000183D849E0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpIntParameter : VolumeParameter<int> // TypeDefIndex: 53611
	{
		// Constructors
		public NoInterpIntParameter() {} // Dummy constructor
		public NoInterpIntParameter(int value, bool overrideState = false /* Metadata: 0x01FD4824 */) {} // 0x0000000189CC8538-0x0000000189CC858C
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class MinIntParameter : IntParameter // TypeDefIndex: 53612
	{
		// Fields
		[NonSerialized]
		public int min; // 0x20
	
		// Properties
		public override int value { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000189CC8108-0x0000000189CC8114
	
		// Constructors
		public MinIntParameter() {} // Dummy constructor
		public MinIntParameter(int value, int min, bool overrideState = false /* Metadata: 0x01FD4825 */) {} // 0x0000000189CC7188-0x0000000189CC71B8
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpMinIntParameter : VolumeParameter<int> // TypeDefIndex: 53613
	{
		// Fields
		[NonSerialized]
		public int min; // 0x20
	
		// Properties
		public override int value { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000189CC8108-0x0000000189CC8114
	
		// Constructors
		public NoInterpMinIntParameter() {} // Dummy constructor
		public NoInterpMinIntParameter(int value, int min, bool overrideState = false /* Metadata: 0x01FD4826 */) {} // 0x0000000189CC86A8-0x0000000189CC8704
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class MaxIntParameter : IntParameter // TypeDefIndex: 53614
	{
		// Fields
		[NonSerialized]
		public int max; // 0x20
	
		// Properties
		public override int value { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000189CC71B8-0x0000000189CC71C4
	
		// Constructors
		public MaxIntParameter() {} // Dummy constructor
		public MaxIntParameter(int value, int max, bool overrideState = false /* Metadata: 0x01FD4827 */) {} // 0x0000000189CC7188-0x0000000189CC71B8
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpMaxIntParameter : VolumeParameter<int> // TypeDefIndex: 53615
	{
		// Fields
		[NonSerialized]
		public int max; // 0x20
	
		// Properties
		public override int value { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000189CC71B8-0x0000000189CC71C4
	
		// Constructors
		public NoInterpMaxIntParameter() {} // Dummy constructor
		public NoInterpMaxIntParameter(int value, int max, bool overrideState = false /* Metadata: 0x01FD4828 */) {} // 0x0000000189CC85EC-0x0000000189CC8648
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class ClampedIntParameter : IntParameter // TypeDefIndex: 53616
	{
		// Fields
		[NonSerialized]
		public int min; // 0x20
		[NonSerialized]
		public int max; // 0x24
	
		// Properties
		public override int value { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000189CBF5B4-0x0000000189CBF5D4
	
		// Constructors
		public ClampedIntParameter() {} // Dummy constructor
		public ClampedIntParameter(int value, int min, int max, bool overrideState = false /* Metadata: 0x01FD4829 */) {} // 0x0000000184272F24-0x0000000184272F60
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpClampedIntParameter : VolumeParameter<int> // TypeDefIndex: 53617
	{
		// Fields
		[NonSerialized]
		public int min; // 0x20
		[NonSerialized]
		public int max; // 0x24
	
		// Properties
		public override int value { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000189CBF5B4-0x0000000189CBF5D4
	
		// Constructors
		public NoInterpClampedIntParameter() {} // Dummy constructor
		public NoInterpClampedIntParameter(int value, int min, int max, bool overrideState = false /* Metadata: 0x01FD482A */) {} // 0x0000000189CC8234-0x0000000189CC8294
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class FloatParameter : VolumeParameter<float> // TypeDefIndex: 53618
	{
		// Constructors
		public FloatParameter() {} // Dummy constructor
		public FloatParameter(float value, bool overrideState = false /* Metadata: 0x01FD482B */) {} // 0x0000000182C63E10-0x0000000182C63E80
	
		// Methods
		public sealed override void Interp(float from, float to, float t) {} // 0x0000000183D848F0-0x0000000183D84910
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpFloatParameter : VolumeParameter<float> // TypeDefIndex: 53619
	{
		// Constructors
		public NoInterpFloatParameter() {} // Dummy constructor
		public NoInterpFloatParameter(float value, bool overrideState = false /* Metadata: 0x01FD482C */) {} // 0x0000000189CC846C-0x0000000189CC84C8
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class MinFloatParameter : FloatParameter // TypeDefIndex: 53620
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
	
		// Properties
		public override float value { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000189CC80F8-0x0000000189CC8108
	
		// Constructors
		public MinFloatParameter() {} // Dummy constructor
		public MinFloatParameter(float value, float min, bool overrideState = false /* Metadata: 0x01FD482D */) {} // 0x0000000184272F60-0x0000000184272F90
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpMinFloatParameter : VolumeParameter<float> // TypeDefIndex: 53621
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
	
		// Properties
		public override float value { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000189CC80F8-0x0000000189CC8108
	
		// Constructors
		public NoInterpMinFloatParameter() {} // Dummy constructor
		public NoInterpMinFloatParameter(float value, float min, bool overrideState = false /* Metadata: 0x01FD482E */) {} // 0x0000000189CC8648-0x0000000189CC86A8
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class MaxFloatParameter : FloatParameter // TypeDefIndex: 53622
	{
		// Fields
		[NonSerialized]
		public float max; // 0x20
	
		// Properties
		public override float value { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000189CC7178-0x0000000189CC7188
	
		// Constructors
		public MaxFloatParameter() {} // Dummy constructor
		public MaxFloatParameter(float value, float max, bool overrideState = false /* Metadata: 0x01FD482F */) {} // 0x0000000184272F60-0x0000000184272F90
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpMaxFloatParameter : VolumeParameter<float> // TypeDefIndex: 53623
	{
		// Fields
		[NonSerialized]
		public float max; // 0x20
	
		// Properties
		public override float value { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000189CC7178-0x0000000189CC7188
	
		// Constructors
		public NoInterpMaxFloatParameter() {} // Dummy constructor
		public NoInterpMaxFloatParameter(float value, float max, bool overrideState = false /* Metadata: 0x01FD4830 */) {} // 0x0000000189CC858C-0x0000000189CC85EC
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class ClampedFloatParameter : FloatParameter // TypeDefIndex: 53624
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
		[NonSerialized]
		public float sliderExponent; // 0x28
	
		// Properties
		public override float value { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183196950-0x0000000183196980
	
		// Constructors
		public ClampedFloatParameter() {} // Dummy constructor
		public ClampedFloatParameter(float value, float min, float max, float sliderExponent, bool overrideState = false /* Metadata: 0x01FD4831 */) {} // 0x0000000189CBF568-0x0000000189CBF5B4
		public ClampedFloatParameter(float value, float min, float max, bool overrideState = false /* Metadata: 0x01FD4832 */) {} // 0x0000000182C63D90-0x0000000182C63E10
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpClampedFloatParameter : VolumeParameter<float> // TypeDefIndex: 53625
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
		[NonSerialized]
		public float sliderExponent; // 0x28
	
		// Properties
		public override float value { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000189CC820C-0x0000000189CC8234
	
		// Constructors
		public NoInterpClampedFloatParameter() {} // Dummy constructor
		public NoInterpClampedFloatParameter(float value, float min, float max, float sliderExponent, bool overrideState = false /* Metadata: 0x01FD4833 */) {} // 0x0000000189CC818C-0x0000000189CC820C
		public NoInterpClampedFloatParameter(float value, float min, float max, bool overrideState = false /* Metadata: 0x01FD4834 */) {} // 0x0000000189CC8114-0x0000000189CC818C
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class UnclampedFloatParameter : FloatParameter // TypeDefIndex: 53626
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
		[NonSerialized]
		public float sliderExponent; // 0x28
	
		// Properties
		public override float value { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
	
		// Constructors
		public UnclampedFloatParameter() {} // Dummy constructor
		public UnclampedFloatParameter(float value, float min, float max, float sliderExponent, bool overrideState = false /* Metadata: 0x01FD4835 */) {} // 0x0000000189CBF568-0x0000000189CBF5B4
		public UnclampedFloatParameter(float value, float min, float max, bool overrideState = false /* Metadata: 0x01FD4836 */) {} // 0x0000000189CC9420-0x0000000189CC9468
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpUnclampedFloatParameter : VolumeParameter<float> // TypeDefIndex: 53627
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
		[NonSerialized]
		public float sliderExponent; // 0x28
	
		// Properties
		public override float value { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
	
		// Constructors
		public NoInterpUnclampedFloatParameter() {} // Dummy constructor
		public NoInterpUnclampedFloatParameter(float value, float min, float max, float sliderExponent, bool overrideState = false /* Metadata: 0x01FD4837 */) {} // 0x0000000189CC892C-0x0000000189CC89AC
		public NoInterpUnclampedFloatParameter(float value, float min, float max, bool overrideState = false /* Metadata: 0x01FD4838 */) {} // 0x0000000189CC89AC-0x0000000189CC8A24
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class FloatRangeParameter : VolumeParameter<Vector2> // TypeDefIndex: 53628
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
	
		// Properties
		public override Vector2 value { get => default; set {} } // 0x0000000183D5CC20-0x0000000183D5CC40 0x0000000189CC61C4-0x0000000189CC61EC
	
		// Constructors
		public FloatRangeParameter() {} // Dummy constructor
		public FloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false /* Metadata: 0x01FD4839 */) {} // 0x0000000182C666E0-0x0000000182C66760
	
		// Methods
		public override void Interp(Vector2 from, Vector2 to, float t) {} // 0x0000000183D84910-0x0000000183D84960
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpFloatRangeParameter : VolumeParameter<Vector2> // TypeDefIndex: 53629
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
	
		// Properties
		public override Vector2 value { get => default; set {} } // 0x0000000183D5CC20-0x0000000183D5CC40 0x0000000189CC61C4-0x0000000189CC61EC
	
		// Constructors
		public NoInterpFloatRangeParameter() {} // Dummy constructor
		public NoInterpFloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false /* Metadata: 0x01FD483A */) {} // 0x0000000189CC84C8-0x0000000189CC8538
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class ColorParameter : VolumeParameter<UnityEngine.Color> // TypeDefIndex: 53630
	{
		// Fields
		[NonSerialized]
		public bool hdr; // 0x28
		[NonSerialized]
		public bool showAlpha; // 0x29
		[NonSerialized]
		public bool showEyeDropper; // 0x2A
	
		// Constructors
		public ColorParameter() {} // Dummy constructor
		public ColorParameter(UnityEngine.Color value, bool overrideState = false /* Metadata: 0x01FD483B */) {} // 0x0000000182C62710-0x0000000182C62770
		public ColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false /* Metadata: 0x01FD483C */) {} // 0x0000000182C60520-0x0000000182C605A0
	
		// Methods
		public override void Interp(UnityEngine.Color from, UnityEngine.Color to, float t) {} // 0x0000000183D84260-0x0000000183D842D0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpColorParameter : VolumeParameter<UnityEngine.Color> // TypeDefIndex: 53631
	{
		// Fields
		public bool hdr; // 0x28
		[NonSerialized]
		public bool showAlpha; // 0x29
		[NonSerialized]
		public bool showEyeDropper; // 0x2A
	
		// Constructors
		public NoInterpColorParameter() {} // Dummy constructor
		public NoInterpColorParameter(UnityEngine.Color value, bool overrideState = false /* Metadata: 0x01FD483D */) {} // 0x0000000189CC8294-0x0000000189CC82EC
		public NoInterpColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false /* Metadata: 0x01FD483E */) {} // 0x0000000189CC82EC-0x0000000189CC835C
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class Vector2Parameter : VolumeParameter<Vector2> // TypeDefIndex: 53632
	{
		// Constructors
		public Vector2Parameter() {} // Dummy constructor
		public Vector2Parameter(Vector2 value, bool overrideState = false /* Metadata: 0x01FD483F */) {} // 0x0000000182C617D0-0x0000000182C61840
	
		// Methods
		public override void Interp(Vector2 from, Vector2 to, float t) {} // 0x0000000183D84910-0x0000000183D84960
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpVector2Parameter : VolumeParameter<Vector2> // TypeDefIndex: 53633
	{
		// Constructors
		public NoInterpVector2Parameter() {} // Dummy constructor
		public NoInterpVector2Parameter(Vector2 value, bool overrideState = false /* Metadata: 0x01FD4840 */) {} // 0x0000000189CC8A24-0x0000000189CC8A80
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class Vector3Parameter : VolumeParameter<Vector3> // TypeDefIndex: 53634
	{
		// Constructors
		public Vector3Parameter() {} // Dummy constructor
		public Vector3Parameter(Vector3 value, bool overrideState = false /* Metadata: 0x01FD4841 */) {} // 0x0000000183511690-0x00000001835116F0
	
		// Methods
		public override void Interp(Vector3 from, Vector3 to, float t) {} // 0x0000000183D849F0-0x0000000183D84A40
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpVector3Parameter : VolumeParameter<Vector3> // TypeDefIndex: 53635
	{
		// Constructors
		public NoInterpVector3Parameter() {} // Dummy constructor
		public NoInterpVector3Parameter(Vector3 value, bool overrideState = false /* Metadata: 0x01FD4842 */) {} // 0x0000000189CC8A80-0x0000000189CC8AD8
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class Vector4Parameter : VolumeParameter<Vector4> // TypeDefIndex: 53636
	{
		// Constructors
		public Vector4Parameter() {} // Dummy constructor
		public Vector4Parameter(Vector4 value, bool overrideState = false /* Metadata: 0x01FD4843 */) {} // 0x0000000182C60AD0-0x0000000182C60B30
	
		// Methods
		public override void Interp(Vector4 from, Vector4 to, float t) {} // 0x0000000183D84260-0x0000000183D842D0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpVector4Parameter : VolumeParameter<Vector4> // TypeDefIndex: 53637
	{
		// Constructors
		public NoInterpVector4Parameter() {} // Dummy constructor
		public NoInterpVector4Parameter(Vector4 value, bool overrideState = false /* Metadata: 0x01FD4844 */) {} // 0x0000000189CC8AD8-0x0000000189CC8B28
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class TextureParameter : VolumeParameter<Texture> // TypeDefIndex: 53638
	{
		// Fields
		public TextureDimension dimension; // 0x20
	
		// Constructors
		public TextureParameter() {} // Dummy constructor
		public TextureParameter(Texture value, bool overrideState = false /* Metadata: 0x01FD4845 */) {} // 0x0000000184276B6C-0x0000000184276B90
		public TextureParameter(Texture value, TextureDimension dimension, bool overrideState = false /* Metadata: 0x01FD4846 */) {} // 0x0000000182C66A30-0x0000000182C66AA0
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000189CC9134-0x0000000189CC91F4
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpTextureParameter : VolumeParameter<Texture> // TypeDefIndex: 53639
	{
		// Constructors
		public NoInterpTextureParameter() {} // Dummy constructor
		public NoInterpTextureParameter(Texture value, bool overrideState = false /* Metadata: 0x01FD4847 */) {} // 0x0000000189CC88D4-0x0000000189CC892C
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000189CC8814-0x0000000189CC88D4
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class Texture2DParameter : VolumeParameter<Texture> // TypeDefIndex: 53640
	{
		// Constructors
		public Texture2DParameter() {} // Dummy constructor
		public Texture2DParameter(Texture value, bool overrideState = false /* Metadata: 0x01FD4848 */) {} // 0x0000000182C66760-0x0000000182C667C0
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000189CC8E30-0x0000000189CC8EF0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class Texture3DParameter : VolumeParameter<Texture> // TypeDefIndex: 53641
	{
		// Constructors
		public Texture3DParameter() {} // Dummy constructor
		public Texture3DParameter(Texture value, bool overrideState = false /* Metadata: 0x01FD4849 */) {} // 0x0000000182C66890-0x0000000182C668F0
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000189CC8EF0-0x0000000189CC8FB0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class RenderTextureParameter : VolumeParameter<RenderTexture> // TypeDefIndex: 53642
	{
		// Constructors
		public RenderTextureParameter() {} // Dummy constructor
		public RenderTextureParameter(RenderTexture value, bool overrideState = false /* Metadata: 0x01FD484A */) {} // 0x0000000189CC8C34-0x0000000189CC8C8C
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000189CC8B7C-0x0000000189CC8C34
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpRenderTextureParameter : VolumeParameter<RenderTexture> // TypeDefIndex: 53643
	{
		// Constructors
		public NoInterpRenderTextureParameter() {} // Dummy constructor
		public NoInterpRenderTextureParameter(RenderTexture value, bool overrideState = false /* Metadata: 0x01FD484B */) {} // 0x0000000189CC87BC-0x0000000189CC8814
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000189CC8704-0x0000000189CC87BC
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class CubemapParameter : VolumeParameter<Texture> // TypeDefIndex: 53644
	{
		// Constructors
		public CubemapParameter() {} // Dummy constructor
		public CubemapParameter(Texture value, bool overrideState = false /* Metadata: 0x01FD484C */) {} // 0x0000000182C66830-0x0000000182C66890
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000189CC38C8-0x0000000189CC3988
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpCubemapParameter : VolumeParameter<Cubemap> // TypeDefIndex: 53645
	{
		// Constructors
		public NoInterpCubemapParameter() {} // Dummy constructor
		public NoInterpCubemapParameter(Cubemap value, bool overrideState = false /* Metadata: 0x01FD484D */) {} // 0x0000000189CC8414-0x0000000189CC846C
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000189CC835C-0x0000000189CC8414
	}

	[Serializable]
	public class AnimationCurveParameter : VolumeParameter<AnimationCurve> // TypeDefIndex: 53646
	{
		// Constructors
		public AnimationCurveParameter() {} // Dummy constructor
		public AnimationCurveParameter(AnimationCurve value, bool overrideState = false /* Metadata: 0x01FD484E */) {} // 0x0000000182C668F0-0x0000000182C66950
	}

	public sealed class VolumeProfile : ScriptableObject // TypeDefIndex: 53648
	{
		// Fields
		public List<VolumeComponent> components; // 0x18
		[NonSerialized]
		public bool isDirty; // 0x20
	
		// Constructors
		public VolumeProfile() {} // 0x00000001827ABDC0-0x00000001827ABE50
	
		// Methods
		private void OnEnable() {} // 0x000000018381C070-0x000000018381C1B0
		internal void OnDisable() {} // 0x00000001832B93A0-0x00000001832B9480
		public void Reset() {} // 0x0000000183D59690-0x0000000183D596A0
		public T Add<T>(bool overrides = false /* Metadata: 0x01FD484F */)
			where T : VolumeComponent => default;
		public VolumeComponent Add(System.Type type, bool overrides = false /* Metadata: 0x01FD4850 */) => default; // 0x0000000183709BF0-0x0000000183709CC0
		public void Remove<T>()
			where T : VolumeComponent {}
		public void Remove(System.Type type) {} // 0x0000000189CCA0A0-0x0000000189CCA17C
		public bool Has<T>()
			where T : VolumeComponent => default;
		public bool Has(System.Type type) => default; // 0x0000000182522090-0x00000001825221F0
		public bool HasSubclassOf(System.Type type) => default; // 0x0000000189CC9F54-0x0000000189CCA0A0
		public bool TryGet<T>(out ref T component)
			where T : VolumeComponent {
			component = default;
			return default;
		}
		public bool TryGet<T>(System.Type type, out ref T component)
			where T : VolumeComponent {
			component = default;
			return default;
		}
		public bool TryGetSubclassOf<T>(System.Type type, out ref T component)
			where T : VolumeComponent {
			component = default;
			return default;
		}
		public bool TryGetAllSubclassOf<T>(System.Type type, List<T> result)
			where T : VolumeComponent => default;
		public override int GetHashCode() => default; // 0x0000000189CC9EC0-0x0000000189CC9F54
		internal int GetComponentListHashCode() => default; // 0x0000000189CC9E1C-0x0000000189CC9EC0
		internal void Sanitize() {} // 0x0000000189CCA17C-0x0000000189CCA248
	}

	public sealed class VolumeStack : IDisposable // TypeDefIndex: 53649
	{
		// Fields
		internal readonly Dictionary<System.Type, VolumeComponent> components; // 0x10
		[TupleElementNames(new string[2] {"parameter", "defaultValue" })]
		public ValueTuple<VolumeParameter, VolumeParameter>[] defaultParameters; // 0x18
		internal bool requiresReset; // 0x20
	
		// Constructors
		internal VolumeStack() {} // 0x0000000182522B00-0x0000000182522B80
	
		// Methods
		internal void Reload(List<VolumeComponent> componentDefaultStates) {} // 0x00000001825224E0-0x0000000182522A00
		public T GetComponent<T>()
			where T : VolumeComponent => default;
		public VolumeComponent GetComponent(System.Type type) => default; // 0x00000001825202D0-0x0000000182520410
		public void Dispose() {} // 0x0000000182E7F2F0-0x0000000182E7FC10
	}

	public static class XRGraphicsAutomatedTests // TypeDefIndex: 53650
	{
		// Fields
		public static bool running; // 0x01
	
		// Properties
		private static bool activatedFromCommandLine { get; } // 0x000000018115F4C0-0x000000018115F530 
		public static bool enabled { get; } // 0x0000000189CCA534-0x0000000189CCA584 
	
		// Constructors
		static XRGraphicsAutomatedTests() {} // 0x0000000189CCA4EC-0x0000000189CCA534
	}
}

namespace UnityEngine.Rendering.LookDev
{
	public interface IDataProvider // TypeDefIndex: 53651
	{
		// Properties
		IEnumerable<string> supportedDebugModes { get; }
	
		// Methods
		void FirstInitScene(StageRuntimeInterface stage);
		void UpdateSky(Camera camera, Sky sky, StageRuntimeInterface stage);
		void UpdateDebugMode(int debugIndex);
		void GetShadowMask(ref RenderTexture output, StageRuntimeInterface stage);
		void OnBeginRendering(StageRuntimeInterface stage);
		void OnEndRendering(StageRuntimeInterface stage);
		void Cleanup(StageRuntimeInterface SRI);
	}

	public struct Sky // TypeDefIndex: 53652
	{
		// Fields
		public Cubemap cubemap; // 0x00
		public float longitudeOffset; // 0x08
		public float exposure; // 0x0C
	}

	public class StageRuntimeInterface // TypeDefIndex: 53653
	{
		// Fields
		private Func<bool, GameObject> m_AddGameObject; // 0x10
		private Func<Camera> m_GetCamera; // 0x18
		private Func<Light> m_GetSunLight; // 0x20
		public object SRPData; // 0x28
	
		// Properties
		public Camera camera { get => default; } // 0x0000000189CC8DF0-0x0000000189CC8E10 
		public Light sunLight { get => default; } // 0x0000000189CC8E10-0x0000000189CC8E30 
	
		// Constructors
		public StageRuntimeInterface() {} // Dummy constructor
		public StageRuntimeInterface(Func<bool, GameObject> AddGameObject, Func<Camera> GetCamera, Func<Light> GetSunLight) {} // 0x000000018285BDC0-0x000000018285BE00
	
		// Methods
		public GameObject AddGameObject(bool persistent = false /* Metadata: 0x01FD4851 */) => default; // 0x0000000189CC8DCC-0x0000000189CC8DF0
	}
}

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerBitField : DebugUIHandlerWidget // TypeDefIndex: 53654
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UIFoldout valueToggle; // 0x60
		public List<DebugUIHandlerIndirectToggle> toggles; // 0x68
		private DebugUI.BitField m_Field; // 0x70
		private DebugUIHandlerContainer m_Container; // 0x78
	
		// Constructors
		public DebugUIHandlerBitField() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CC3F28-0x0000000189CC4274
		private bool GetValue(int index) => default; // 0x0000000189CC3988-0x0000000189CC3A24
		private void SetValue(int index, bool value) {} // 0x0000000189CC3C58-0x0000000189CC3F28
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CC3B7C-0x0000000189CC3C58
		public override void OnDeselection() {} // 0x0000000189CC3B24-0x0000000189CC3B54
		public override void OnIncrement(bool fast) {} // 0x0000000189CC3B54-0x0000000189CC3B7C
		public override void OnDecrement(bool fast) {} // 0x0000000189CC3B00-0x0000000189CC3B24
		public override void OnAction() {} // 0x0000000189CC3AD0-0x0000000189CC3B00
		public override DebugUIHandlerWidget Next() => default; // 0x0000000189CC3A24-0x0000000189CC3AD0
	}

	public class DebugUIHandlerButton : DebugUIHandlerWidget // TypeDefIndex: 53655
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		private DebugUI.Button m_Field; // 0x60
	
		// Constructors
		public DebugUIHandlerButton() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CC42DC-0x0000000189CC4360
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CC42A8-0x0000000189CC42DC
		public override void OnDeselection() {} // 0x0000000189CC3B24-0x0000000189CC3B54
		public override void OnAction() {} // 0x0000000189CC427C-0x0000000189CC42A8
	}

	[Serializable]
	public class DebugUIPrefabBundle // TypeDefIndex: 53656
	{
		// Fields
		public string type; // 0x10
		public RectTransform prefab; // 0x18
	
		// Constructors
		public DebugUIPrefabBundle() {} // 0x000000018350B670-0x000000018350B680
	}

	public class DebugUIHandlerCanvas : MonoBehaviour // TypeDefIndex: 53659
	{
		// Fields
		private int m_DebugTreeState; // 0x18
		private Dictionary<System.Type, Transform> m_PrefabsMap; // 0x20
		public Transform panelPrefab; // 0x28
		public List<DebugUIPrefabBundle> prefabs; // 0x30
		private List<DebugUIHandlerPanel> m_UIPanels; // 0x38
		private int m_SelectedPanel; // 0x40
		private DebugUIHandlerWidget m_SelectedWidget; // 0x48
		private string m_CurrentQueryPath; // 0x50
	
		// Constructors
		public DebugUIHandlerCanvas() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnEnable() {} // 0x0000000189CC4B88-0x0000000189CC4CD8
		private void Update() {} // 0x0000000189CC5C7C-0x0000000189CC5D84
		internal void RequestHierarchyReset() {} // 0x0000000183D50330-0x0000000183D50340
		private void ResetAllHierarchy() {} // 0x0000000189CC53F4-0x0000000189CC55AC
		private void Rebuild() {} // 0x0000000189CC4CD8-0x0000000189CC53F4
		private void Traverse(DebugUI.IContainer container, Transform parentTransform, DebugUIHandlerWidget parentUIHandler, ref DebugUIHandlerWidget selectedHandler) {} // 0x0000000189CC58A8-0x0000000189CC5C7C
		private DebugUIHandlerWidget GetWidgetFromPath(string queryPath) => default; // 0x0000000189CC4848-0x0000000189CC4974
		private void ActivatePanel(int index, DebugUIHandlerWidget selectedWidget = null) {} // 0x0000000189CC4360-0x0000000189CC4568
		internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext) {} // 0x0000000189CC46BC-0x0000000189CC4848
		internal void SelectPreviousItem() {} // 0x0000000189CC56CC-0x0000000189CC5768
		internal void SelectNextPanel() {} // 0x0000000189CC5660-0x0000000189CC56CC
		internal void SelectPreviousPanel() {} // 0x0000000189CC5768-0x0000000189CC57D8
		internal void SelectNextItem() {} // 0x0000000189CC55AC-0x0000000189CC5660
		private void ChangeSelectionValue(float multiplier) {} // 0x0000000189CC45D8-0x0000000189CC46BC
		private void ActivateSelection() {} // 0x0000000189CC4568-0x0000000189CC45D8
		private void HandleInput() {} // 0x0000000189CC4974-0x0000000189CC4B88
		internal void SetScrollTarget(DebugUIHandlerWidget widget) {} // 0x0000000189CC57D8-0x0000000189CC58A8
	}

	public class DebugUIHandlerColor : DebugUIHandlerWidget // TypeDefIndex: 53660
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UIFoldout valueToggle; // 0x60
		public Image colorImage; // 0x68
		public DebugUIHandlerIndirectFloatField fieldR; // 0x70
		public DebugUIHandlerIndirectFloatField fieldG; // 0x78
		public DebugUIHandlerIndirectFloatField fieldB; // 0x80
		public DebugUIHandlerIndirectFloatField fieldA; // 0x88
		private DebugUI.ColorField m_Field; // 0x90
		private DebugUIHandlerContainer m_Container; // 0x98
	
		// Constructors
		public DebugUIHandlerColor() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCA8C8-0x0000000189CCADB4
		private void SetValue(float x, bool r = false /* Metadata: 0x01FD4852 */, bool g = false /* Metadata: 0x01FD4853 */, bool b = false /* Metadata: 0x01FD4854 */, bool a = false /* Metadata: 0x01FD4855 */) {} // 0x0000000189CCA7B4-0x0000000189CCA8C8
		private void SetupSettings(DebugUIHandlerIndirectFloatField field) {} // 0x0000000189CCADB4-0x0000000189CCAEF0
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CCA6D0-0x0000000189CCA7B4
		public override void OnDeselection() {} // 0x0000000189CC3B24-0x0000000189CC3B54
		public override void OnIncrement(bool fast) {} // 0x0000000189CC3B54-0x0000000189CC3B7C
		public override void OnDecrement(bool fast) {} // 0x0000000189CC3B00-0x0000000189CC3B24
		public override void OnAction() {} // 0x0000000189CC3AD0-0x0000000189CC3B00
		internal void UpdateColor() {} // 0x0000000189CCB144-0x0000000189CCB1F0
		public override DebugUIHandlerWidget Next() => default; // 0x0000000189CCA61C-0x0000000189CCA6D0
	}

	public class DebugUIHandlerContainer : MonoBehaviour // TypeDefIndex: 53662
	{
		// Fields
		[SerializeField]
		public RectTransform contentHolder; // 0x18
	
		// Constructors
		public DebugUIHandlerContainer() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		internal DebugUIHandlerWidget GetFirstItem() => default; // 0x0000000189CCB444-0x0000000189CCB4C4
		internal DebugUIHandlerWidget GetLastItem() => default; // 0x0000000189CCB4C4-0x0000000189CCB548
		internal bool IsDirectChild(DebugUIHandlerWidget widget) => default; // 0x0000000189CCB548-0x0000000189CCB640
		private List<DebugUIHandlerWidget> GetActiveChildren() => default; // 0x0000000189CCB1F0-0x0000000189CCB444
	}

	public class DebugUIHandlerEnumField : DebugUIHandlerWidget // TypeDefIndex: 53663
	{
		// Fields
		public UI.Text nextButtonText; // 0x58
		public UI.Text previousButtonText; // 0x60
		public UI.Text nameLabel; // 0x68
		public UI.Text valueLabel; // 0x70
		protected internal DebugUI.EnumField m_Field; // 0x78
	
		// Constructors
		public DebugUIHandlerEnumField() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCBB4C-0x0000000189CCBBDC
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CCBA40-0x0000000189CCBB4C
		public override void OnDeselection() {} // 0x0000000189CCB7EC-0x0000000189CCB8F4
		public override void OnAction() {} // 0x0000000189CCB640-0x0000000189CCB650
		public override void OnIncrement(bool fast) {} // 0x0000000189CCB8F4-0x0000000189CCBA40
		public override void OnDecrement(bool fast) {} // 0x0000000189CCB650-0x0000000189CCB7EC
		protected virtual void UpdateValueLabel() {} // 0x0000000189CCBBDC-0x0000000189CCBC98
	}

	public class DebugUIHandlerEnumHistory : DebugUIHandlerEnumField // TypeDefIndex: 53665
	{
		// Fields
		private UI.Text[] historyValues; // 0x80
		private const float xDecal = 60f; // Metadata: 0x01FD4856
	
		// Constructors
		public DebugUIHandlerEnumHistory() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCBCF4-0x0000000189CCBF28
		protected override void UpdateValueLabel() {} // 0x0000000189CCBF28-0x0000000189CCC100
		[IteratorStateMachine(typeof(_RefreshAfterSanitization_d__4))]
		private IEnumerator RefreshAfterSanitization() => default; // 0x0000000189CCBC98-0x0000000189CCBCF4
	}

	public class DebugUIHandlerFloatField : DebugUIHandlerWidget // TypeDefIndex: 53666
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UI.Text valueLabel; // 0x60
		private DebugUI.FloatField m_Field; // 0x68
	
		// Constructors
		public DebugUIHandlerFloatField() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCC28C-0x0000000189CCC31C
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CCC230-0x0000000189CCC28C
		public override void OnDeselection() {} // 0x0000000189CCC1C4-0x0000000189CCC220
		public override void OnIncrement(bool fast) {} // 0x0000000189CCC220-0x0000000189CCC230
		public override void OnDecrement(bool fast) {} // 0x0000000189CCC1B4-0x0000000189CCC1C4
		private void ChangeValue(bool fast, float multiplier) {} // 0x0000000189CCC100-0x0000000189CCC1B4
		private void UpdateValueLabel() {} // 0x0000000189CCC31C-0x0000000189CCC3CC
	}

	public class DebugUIHandlerFoldout : DebugUIHandlerWidget // TypeDefIndex: 53667
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UIFoldout valueToggle; // 0x60
		private DebugUI.Foldout m_Field; // 0x68
		private DebugUIHandlerContainer m_Container; // 0x70
		private const float xDecal = 60f; // Metadata: 0x01FD485A
		private const float xDecalInit = 230f; // Metadata: 0x01FD485E
	
		// Constructors
		public DebugUIHandlerFoldout() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCC5C8-0x0000000189CCC9A4
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CCC4EC-0x0000000189CCC5C8
		public override void OnDeselection() {} // 0x0000000189CC3B24-0x0000000189CC3B54
		public override void OnIncrement(bool fast) {} // 0x0000000189CCC4C8-0x0000000189CCC4EC
		public override void OnDecrement(bool fast) {} // 0x0000000189CCC4A4-0x0000000189CCC4C8
		public override void OnAction() {} // 0x0000000189CCC478-0x0000000189CCC4A4
		private void UpdateValue() {} // 0x0000000189CCC9A4-0x0000000189CCC9D8
		public override DebugUIHandlerWidget Next() => default; // 0x0000000189CCC3CC-0x0000000189CCC478
	}

	public class DebugUIHandlerGroup : DebugUIHandlerWidget // TypeDefIndex: 53668
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public Transform header; // 0x60
		private DebugUI.Container m_Field; // 0x68
		private DebugUIHandlerContainer m_Container; // 0x70
	
		// Constructors
		public DebugUIHandlerGroup() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCCB20-0x0000000189CCCC04
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CCCA74-0x0000000189CCCB20
		public override DebugUIHandlerWidget Next() => default; // 0x0000000189CCC9D8-0x0000000189CCCA74
	}

	public class DebugUIHandlerHBox : DebugUIHandlerWidget // TypeDefIndex: 53669
	{
		// Fields
		private DebugUIHandlerContainer m_Container; // 0x58
	
		// Constructors
		public DebugUIHandlerHBox() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCCD4C-0x0000000189CCCDAC
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CCCCA0-0x0000000189CCCD4C
		public override DebugUIHandlerWidget Next() => default; // 0x0000000189CCCC04-0x0000000189CCCCA0
	}

	public class DebugUIHandlerIndirectFloatField : DebugUIHandlerWidget // TypeDefIndex: 53670
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UI.Text valueLabel; // 0x60
		public Func<float> getter; // 0x68
		public Action<float> setter; // 0x70
		public Func<float> incStepGetter; // 0x78
		public Func<float> incStepMultGetter; // 0x80
		public Func<float> decimalsGetter; // 0x88
	
		// Constructors
		public DebugUIHandlerIndirectFloatField() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		public void Init() {} // 0x0000000189CCCE68-0x0000000189CCCE70
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CCC230-0x0000000189CCC28C
		public override void OnDeselection() {} // 0x0000000189CCC1C4-0x0000000189CCC220
		public override void OnIncrement(bool fast) {} // 0x0000000189CCCE80-0x0000000189CCCE90
		public override void OnDecrement(bool fast) {} // 0x0000000189CCCE70-0x0000000189CCCE80
		private void ChangeValue(bool fast, float multiplier) {} // 0x0000000189CCCDAC-0x0000000189CCCE68
		private void UpdateValueLabel() {} // 0x0000000189CCCE90-0x0000000189CCCF6C
	}

	public class DebugUIHandlerIndirectToggle : DebugUIHandlerWidget // TypeDefIndex: 53671
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public Toggle valueToggle; // 0x60
		public Image checkmarkImage; // 0x68
		public Func<int, bool> getter; // 0x70
		public Action<int, bool> setter; // 0x78
		internal int index; // 0x80
	
		// Constructors
		public DebugUIHandlerIndirectToggle() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		public void Init() {} // 0x0000000189CCCF6C-0x0000000189CCD024
		private void OnToggleValueChanged(bool value) {} // 0x0000000189CCD130-0x0000000189CCD160
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CCD0D4-0x0000000189CCD130
		public override void OnDeselection() {} // 0x0000000189CCD078-0x0000000189CCD0D4
		public override void OnAction() {} // 0x0000000189CCD024-0x0000000189CCD078
		internal void UpdateValueLabel() {} // 0x0000000189CCD160-0x0000000189CCD1EC
	}

	public class DebugUIHandlerIntField : DebugUIHandlerWidget // TypeDefIndex: 53672
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UI.Text valueLabel; // 0x60
		private DebugUI.IntField m_Field; // 0x68
	
		// Constructors
		public DebugUIHandlerIntField() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCD2C0-0x0000000189CCD350
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CCC230-0x0000000189CCC28C
		public override void OnDeselection() {} // 0x0000000189CCC1C4-0x0000000189CCC220
		public override void OnIncrement(bool fast) {} // 0x0000000189CCD2B0-0x0000000189CCD2C0
		public override void OnDecrement(bool fast) {} // 0x0000000189CCD2A0-0x0000000189CCD2B0
		private void ChangeValue(bool fast, int multiplier) {} // 0x0000000189CCD1EC-0x0000000189CCD2A0
		private void UpdateValueLabel() {} // 0x0000000189CCD350-0x0000000189CCD408
	}

	public class DebugUIHandlerMessageBox : DebugUIHandlerWidget // TypeDefIndex: 53673
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		private DebugUI.MessageBox m_Field; // 0x60
		private static Color32 k_WarningBackgroundColor; // 0x00
		private static Color32 k_WarningTextColor; // 0x04
		private static Color32 k_ErrorBackgroundColor; // 0x08
		private static Color32 k_ErrorTextColor; // 0x0C
	
		// Constructors
		public DebugUIHandlerMessageBox() {} // 0x0000000189CC4274-0x0000000189CC427C
		static DebugUIHandlerMessageBox() {} // 0x0000000189CCD538-0x0000000189CCD5D0
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCD408-0x0000000189CCD538
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x000000018115F4C0-0x000000018115F530
	}

	public class DebugUIHandlerPanel : MonoBehaviour // TypeDefIndex: 53674
	{
		// Fields
		public UI.Text nameLabel; // 0x18
		public ScrollRect scrollRect; // 0x20
		public RectTransform viewport; // 0x28
		public DebugUIHandlerCanvas Canvas; // 0x30
		private RectTransform m_ScrollTransform; // 0x38
		private RectTransform m_ContentTransform; // 0x40
		private RectTransform m_MaskTransform; // 0x48
		private DebugUIHandlerWidget m_ScrollTarget; // 0x50
		protected internal DebugUI.Panel m_Panel; // 0x58
	
		// Constructors
		public DebugUIHandlerPanel() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnEnable() {} // 0x0000000189CCD784-0x0000000189CCD840
		internal void SetPanel(DebugUI.Panel panel) {} // 0x0000000189CCD91C-0x0000000189CCD958
		internal DebugUI.Panel GetPanel() => default; // 0x0000000183D4EAA0-0x0000000183D4EAB0
		public void SelectNextItem() {} // 0x0000000189CCD8DC-0x0000000189CCD8FC
		public void SelectPreviousItem() {} // 0x0000000189CCD8FC-0x0000000189CCD91C
		public void OnScrollbarClicked() {} // 0x0000000189CCD840-0x0000000189CCD890
		internal void SetScrollTarget(DebugUIHandlerWidget target) {} // 0x0000000182C926C0-0x0000000182C926D0
		internal void UpdateScroll() {} // 0x0000000189CCD958-0x0000000189CCDB08
		private float GetYPosInScroll(RectTransform target) => default; // 0x0000000189CCD620-0x0000000189CCD784
		internal DebugUIHandlerWidget GetFirstItem() => default; // 0x0000000189CCD5D0-0x0000000189CCD620
		public void ResetDebugManager() {} // 0x0000000189CCD890-0x0000000189CCD8DC
	}

	internal class DebugUIHandlerPersistentCanvas : MonoBehaviour // TypeDefIndex: 53676
	{
		// Fields
		public RectTransform panel; // 0x18
		public RectTransform valuePrefab; // 0x20
		private List<DebugUIHandlerValue> m_Items; // 0x28
	
		// Constructors
		public DebugUIHandlerPersistentCanvas() {} // 0x0000000189CCDEB8-0x0000000189CCDF38
	
		// Methods
		internal void Toggle(DebugUI.Value widget) {} // 0x0000000189CCDC74-0x0000000189CCDEB8
		internal void Clear() {} // 0x0000000189CCDB08-0x0000000189CCDC74
	}

	public class DebugUIHandlerRow : DebugUIHandlerFoldout // TypeDefIndex: 53677
	{
		// Fields
		private float m_Timer; // 0x78
	
		// Constructors
		public DebugUIHandlerRow() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		protected override void OnEnable() {} // 0x0000000183D84A40-0x0000000183D84A50
		protected void Update() {} // 0x0000000189CCDF38-0x0000000189CCE2F8
	}

	public class DebugUIHandlerToggle : DebugUIHandlerWidget // TypeDefIndex: 53678
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public Toggle valueToggle; // 0x60
		public Image checkmarkImage; // 0x68
		protected internal DebugUI.BoolField m_Field; // 0x70
	
		// Constructors
		public DebugUIHandlerToggle() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCE8A0-0x0000000189CCE9B0
		private void OnToggleValueChanged(bool value) {} // 0x0000000189CCE84C-0x0000000189CCE8A0
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CCD0D4-0x0000000189CCD130
		public override void OnDeselection() {} // 0x0000000189CCD078-0x0000000189CCD0D4
		public override void OnAction() {} // 0x0000000189CCE7D4-0x0000000189CCE84C
		protected internal virtual void UpdateValueLabel() {} // 0x0000000189CCE9B0-0x0000000189CCEA48
	}

	public class DebugUIHandlerToggleHistory : DebugUIHandlerToggle // TypeDefIndex: 53680
	{
		// Fields
		private Toggle[] historyToggles; // 0x78
		private const float xDecal = 60f; // Metadata: 0x01FD4862
	
		// Constructors
		public DebugUIHandlerToggleHistory() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCE354-0x0000000189CCE68C
		protected internal override void UpdateValueLabel() {} // 0x0000000189CCE68C-0x0000000189CCE7D4
		[IteratorStateMachine(typeof(_RefreshAfterSanitization_d__4))]
		private IEnumerator RefreshAfterSanitization() => default; // 0x0000000189CCE2F8-0x0000000189CCE354
	}

	public class DebugUIHandlerUIntField : DebugUIHandlerWidget // TypeDefIndex: 53681
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UI.Text valueLabel; // 0x60
		private DebugUI.UIntField m_Field; // 0x68
	
		// Constructors
		public DebugUIHandlerUIntField() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCEB28-0x0000000189CCEBB8
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CCC230-0x0000000189CCC28C
		public override void OnDeselection() {} // 0x0000000189CCC1C4-0x0000000189CCC220
		public override void OnIncrement(bool fast) {} // 0x0000000189CCEB18-0x0000000189CCEB28
		public override void OnDecrement(bool fast) {} // 0x0000000189CCEB08-0x0000000189CCEB18
		private void ChangeValue(bool fast, int multiplier) {} // 0x0000000189CCEA48-0x0000000189CCEB08
		private void UpdateValueLabel() {} // 0x0000000189CCEBB8-0x0000000189CCEC70
	}

	public class DebugUIHandlerValue : DebugUIHandlerWidget // TypeDefIndex: 53682
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UI.Text valueLabel; // 0x60
		private DebugUI.Value m_Field; // 0x68
		private float m_Timer; // 0x70
	
		// Constructors
		public DebugUIHandlerValue() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		protected override void OnEnable() {} // 0x0000000183D84A50-0x0000000183D84A60
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCEE18-0x0000000189CCEE9C
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CCC230-0x0000000189CCC28C
		public override void OnDeselection() {} // 0x0000000189CCC1C4-0x0000000189CCC220
		private void Update() {} // 0x0000000189CCEE9C-0x0000000189CCEF38
	}

	public class DebugUIHandlerVBox : DebugUIHandlerWidget // TypeDefIndex: 53683
	{
		// Fields
		private DebugUIHandlerContainer m_Container; // 0x58
	
		// Constructors
		public DebugUIHandlerVBox() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCEDB8-0x0000000189CCEE18
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CCED0C-0x0000000189CCEDB8
		public override DebugUIHandlerWidget Next() => default; // 0x0000000189CCEC70-0x0000000189CCED0C
	}

	public class DebugUIHandlerVector2 : DebugUIHandlerWidget // TypeDefIndex: 53684
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UIFoldout valueToggle; // 0x60
		public DebugUIHandlerIndirectFloatField fieldX; // 0x68
		public DebugUIHandlerIndirectFloatField fieldY; // 0x70
		private DebugUI.Vector2Field m_Field; // 0x78
		private DebugUIHandlerContainer m_Container; // 0x80
	
		// Constructors
		public DebugUIHandlerVector2() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCF188-0x0000000189CCF400
		private void SetValue(float v, bool x = false /* Metadata: 0x01FD4866 */, bool y = false /* Metadata: 0x01FD4867 */) {} // 0x0000000189CCF0D0-0x0000000189CCF188
		private void SetupSettings(DebugUIHandlerIndirectFloatField field) {} // 0x0000000189CCF400-0x0000000189CCF53C
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CCEFEC-0x0000000189CCF0D0
		public override void OnDeselection() {} // 0x0000000189CC3B24-0x0000000189CC3B54
		public override void OnIncrement(bool fast) {} // 0x0000000189CC3B54-0x0000000189CC3B7C
		public override void OnDecrement(bool fast) {} // 0x0000000189CC3B00-0x0000000189CC3B24
		public override void OnAction() {} // 0x0000000189CC3AD0-0x0000000189CC3B00
		public override DebugUIHandlerWidget Next() => default; // 0x0000000189CCEF38-0x0000000189CCEFEC
	}

	public class DebugUIHandlerVector3 : DebugUIHandlerWidget // TypeDefIndex: 53685
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UIFoldout valueToggle; // 0x60
		public DebugUIHandlerIndirectFloatField fieldX; // 0x68
		public DebugUIHandlerIndirectFloatField fieldY; // 0x70
		public DebugUIHandlerIndirectFloatField fieldZ; // 0x78
		private DebugUI.Vector3Field m_Field; // 0x80
		private DebugUIHandlerContainer m_Container; // 0x88
	
		// Constructors
		public DebugUIHandlerVector3() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CCF8F4-0x0000000189CCFC64
		private void SetValue(float v, bool x = false /* Metadata: 0x01FD4868 */, bool y = false /* Metadata: 0x01FD4869 */, bool z = false /* Metadata: 0x01FD486A */) {} // 0x0000000189CCF81C-0x0000000189CCF8F4
		private void SetupSettings(DebugUIHandlerIndirectFloatField field) {} // 0x0000000189CCFC64-0x0000000189CCFDA0
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CCF738-0x0000000189CCF81C
		public override void OnDeselection() {} // 0x0000000189CC3B24-0x0000000189CC3B54
		public override void OnIncrement(bool fast) {} // 0x0000000189CC3B54-0x0000000189CC3B7C
		public override void OnDecrement(bool fast) {} // 0x0000000189CC3B00-0x0000000189CC3B24
		public override void OnAction() {} // 0x0000000189CC3AD0-0x0000000189CC3B00
		public override DebugUIHandlerWidget Next() => default; // 0x0000000189CCF684-0x0000000189CCF738
	}

	public class DebugUIHandlerVector4 : DebugUIHandlerWidget // TypeDefIndex: 53686
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UIFoldout valueToggle; // 0x60
		public DebugUIHandlerIndirectFloatField fieldX; // 0x68
		public DebugUIHandlerIndirectFloatField fieldY; // 0x70
		public DebugUIHandlerIndirectFloatField fieldZ; // 0x78
		public DebugUIHandlerIndirectFloatField fieldW; // 0x80
		private DebugUI.Vector4Field m_Field; // 0x88
		private DebugUIHandlerContainer m_Container; // 0x90
	
		// Constructors
		public DebugUIHandlerVector4() {} // 0x0000000189CC4274-0x0000000189CC427C
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget) {} // 0x0000000189CD020C-0x0000000189CD0680
		private void SetValue(float v, bool x = false /* Metadata: 0x01FD486B */, bool y = false /* Metadata: 0x01FD486C */, bool z = false /* Metadata: 0x01FD486D */, bool w = false /* Metadata: 0x01FD486E */) {} // 0x0000000189CD0104-0x0000000189CD020C
		private void SetupSettings(DebugUIHandlerIndirectFloatField field) {} // 0x0000000189CD0680-0x0000000189CD07BC
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x0000000189CD0020-0x0000000189CD0104
		public override void OnDeselection() {} // 0x0000000189CC3B24-0x0000000189CC3B54
		public override void OnIncrement(bool fast) {} // 0x0000000189CC3B54-0x0000000189CC3B7C
		public override void OnDecrement(bool fast) {} // 0x0000000189CC3B00-0x0000000189CC3B24
		public override void OnAction() {} // 0x0000000189CC3AD0-0x0000000189CC3B00
		public override DebugUIHandlerWidget Next() => default; // 0x0000000189CCFF6C-0x0000000189CD0020
	}

	public class DebugUIHandlerWidget : MonoBehaviour // TypeDefIndex: 53687
	{
		// Fields
		[HideInInspector]
		public UnityEngine.Color colorDefault; // 0x18
		[HideInInspector]
		public UnityEngine.Color colorSelected; // 0x28
		protected DebugUI.Widget m_Widget; // 0x50
	
		// Properties
		public DebugUIHandlerWidget parentUIHandler { get; set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public DebugUIHandlerWidget previousUIHandler { get; set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public DebugUIHandlerWidget nextUIHandler { get; set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
	
		// Constructors
		public DebugUIHandlerWidget() {} // 0x0000000189CD0B6C-0x0000000189CD0B8C
	
		// Methods
		protected virtual void OnEnable() {} // 0x000000018350B670-0x000000018350B680
		internal virtual void SetWidget(DebugUI.Widget widget) {} // 0x0000000182C926C0-0x0000000182C926D0
		internal DebugUI.Widget GetWidget() => default; // 0x0000000183D4EAF0-0x0000000183D4EB00
		protected T CastWidget<T>()
			where T : DebugUI.Widget => default;
		public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) => default; // 0x000000018232EB60-0x000000018232EB70
		public virtual void OnDeselection() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnAction() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnIncrement(bool fast) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnDecrement(bool fast) {} // 0x000000018350B670-0x000000018350B680
		public virtual DebugUIHandlerWidget Previous() => default; // 0x0000000189CD0AE8-0x0000000189CD0B6C
		public virtual DebugUIHandlerWidget Next() => default; // 0x0000000189CD0A10-0x0000000189CD0AE8
	}

	[ExecuteAlways]
	public class UIFoldout : Toggle // TypeDefIndex: 53688
	{
		// Fields
		public GameObject content; // 0x1A8
		public GameObject arrowOpened; // 0x1B0
		public GameObject arrowClosed; // 0x1B8
	
		// Constructors
		public UIFoldout() {} // 0x0000000189CD11D4-0x0000000189CD11DC
	
		// Methods
		protected override void Start() {} // 0x0000000189CD1110-0x0000000189CD11D4
		private void OnValidate() {} // 0x0000000189CD0F10-0x0000000189CD0F24
		public void SetState(bool state) {} // 0x0000000189CD0F24-0x0000000189CD0F30
		public void SetState(bool state, bool rebuildLayout) {} // 0x0000000189CD0F30-0x0000000189CD1110
	}
}
