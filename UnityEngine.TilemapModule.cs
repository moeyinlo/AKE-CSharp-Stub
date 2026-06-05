/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using Unity.Collections;
using UnityEngine;
using UnityEngine.U2D;

// Image 116: UnityEngine.TilemapModule.dll - Assembly: UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60946-60957

namespace UnityEngine.Tilemaps
{
	public class ITilemap // TypeDefIndex: 60947
	{
		// Fields
		internal static ITilemap s_Instance; // 0x00
		internal Tilemap m_Tilemap; // 0x10
		internal bool m_AddToList; // 0x18
		internal int m_RefreshCount; // 0x1C
		internal NativeArray<Vector3Int> m_RefreshPos; // 0x20
	
		// Constructors
		internal ITilemap() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void RefreshTile(Vector3Int position) {} // 0x000000018BF734F4-0x000000018BF73658
		private static ITilemap CreateInstance() => default; // 0x000000018BF72FCC-0x000000018BF73040
		private static void FindAllRefreshPositions(ITilemap tilemap, int count, IntPtr oldTilesIntPtr, IntPtr newTilesIntPtr, IntPtr positionsIntPtr) {} // 0x000000018BF73040-0x000000018BF732DC
		private static void GetAllTileData(ITilemap tilemap, int count, IntPtr tilesIntPtr, IntPtr positionsIntPtr, IntPtr outTileDataIntPtr) {} // 0x000000018BF732DC-0x000000018BF734F4
	}

	[Serializable]
	public class Tile : TileBase // TypeDefIndex: 60949
	{
		// Fields
		private Sprite m_Sprite; // 0x18
		private UnityEngine.Color m_Color; // 0x20
		private Matrix4x4 m_Transform; // 0x30
		private GameObject m_InstancedGameObject; // 0x70
		private TileFlags m_Flags; // 0x78
		private ColliderType m_ColliderType; // 0x7C
	
		// Properties
		public Sprite sprite { get => default; set {} } // 0x0000000185FC2A70-0x0000000185FC2A80 0x0000000184088E70-0x0000000184088E80
		public UnityEngine.Color color { get => default; set {} } // 0x0000000185FE8E60-0x0000000185FE8E70 0x0000000185FB6130-0x0000000185FB6140
		public Matrix4x4 transform { get => default; set {} } // 0x0000000185FE9250-0x0000000185FE9280 0x0000000185FE9280-0x0000000185FE92A0
		public GameObject gameObject { get => default; set {} } // 0x0000000185FE8C60-0x0000000185FE8C70 0x00000001874BE90C-0x00000001874BE91C
		public TileFlags flags { get => default; set {} } // 0x0000000185FE8CB0-0x0000000185FE8CC0 0x0000000185FB05C0-0x0000000185FB05D0
		public ColliderType colliderType { get => default; set {} } // 0x0000000185FE9240-0x0000000185FE9250 0x0000000185FB0610-0x0000000185FB0620
	
		// Nested types
		public enum ColliderType // TypeDefIndex: 60948
		{
			None = 0,
			Sprite = 1,
			Grid = 2
		}
	
		// Constructors
		public Tile() {} // 0x000000018BF73A48-0x000000018BF73AA8
	
		// Methods
		public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) {} // 0x000000018BF739A4-0x000000018BF73A48
	}

	public abstract class TileBase : ScriptableObject // TypeDefIndex: 60950
	{
		// Constructors
		protected TileBase() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public virtual void RefreshTile(Vector3Int position, ITilemap tilemap) {} // 0x000000018BF7371C-0x000000018BF73754
		public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) {} // 0x0000000185492010-0x0000000185492020
		private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) => default; // 0x000000018BF73658-0x000000018BF7371C
		public virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) => default; // 0x0000000185FAFEF0-0x0000000185FAFF00
		private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) => default; // 0x0000000185FE6E80-0x0000000185FE6E90
		private void GetTileAnimationDataRef(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData, ref bool hasAnimation) {} // 0x0000000185FE9210-0x0000000185FE9220
		public virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) => default; // 0x0000000185FAFEF0-0x0000000185FAFF00
		private void StartUpRef(Vector3Int position, ITilemap tilemap, GameObject go, ref bool startUpInvokedByUser) {} // 0x0000000185FE9210-0x0000000185FE9220
	}

	public sealed class Tilemap : GridLayout // TypeDefIndex: 60951
	{
		// Properties
		public UnityEngine.Grid layoutGrid { get => default; } // 0x000000018BF74000-0x000000018BF74034 
		public BoundsInt cellBounds { get => default; } // 0x000000018BF73F6C-0x000000018BF74000 
		public Vector3Int origin { get => default; } // 0x000000018BF740F4-0x000000018BF74120 
		public Vector3Int size { get => default; } // 0x000000018BF74164-0x000000018BF74190 
		public Vector3 tileAnchor { get => default; } // 0x000000018BF741D4-0x000000018BF74390 
		public Matrix4x4 orientationMatrix { get => default; } // 0x000000018BF74078-0x000000018BF740B0 
	
		// Constructors
		public Tilemap() {} // Dummy constructor
	
		// Methods
		internal UnityEngine.Object GetTileAsset(Vector3Int position) => default; // 0x000000018BF73C20-0x000000018BF73C34
		public T GetTile<T>(Vector3Int position)
			where T : TileBase => default;
		internal UnityEngine.Object[] GetTileAssetsBlock(Vector3Int position, Vector3Int blockDimensions) => default; // 0x000000018BF73C88-0x000000018BF73C9C
		public TileBase[] GetTilesBlock(BoundsInt bounds) => default; // 0x000000018BF73C9C-0x000000018BF73DC8
		public bool HasTile(Vector3Int position) => default; // 0x000000018BF73E08-0x000000018BF73E7C
		public void RefreshTile(Vector3Int position) {} // 0x000000018BF73F04-0x000000018BF73F18
		internal unsafe void RefreshTilesNative(void* positions, int count) {} // 0x000000018BF73F18-0x000000018BF73F6C
		public int GetUsedTilesCount() => default; // 0x000000018BF73DC8-0x000000018BF73DFC
		public int GetUsedTilesNonAlloc(TileBase[] usedTiles) => default; // 0x000000018BF73DFC-0x000000018BF73E08
		internal int Internal_GetUsedTilesNonAlloc(UnityEngine.Object[] usedTiles) => default; // 0x000000018BF73E7C-0x000000018BF73EC0
		private void get_origin_Injected(out Vector3Int ret) {
			ret = default;
		} // 0x000000018BF740B0-0x000000018BF740F4
		private void get_size_Injected(out Vector3Int ret) {
			ret = default;
		} // 0x000000018BF74120-0x000000018BF74164
		private void get_tileAnchor_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BF74190-0x000000018BF741D4
		private void get_orientationMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BF74034-0x000000018BF74078
		private UnityEngine.Object GetTileAsset_Injected(ref Vector3Int position) => default; // 0x000000018BF73BDC-0x000000018BF73C20
		private UnityEngine.Object[] GetTileAssetsBlock_Injected(ref Vector3Int position, ref Vector3Int blockDimensions) => default; // 0x000000018BF73C34-0x000000018BF73C88
		private void RefreshTile_Injected(ref Vector3Int position) {} // 0x000000018BF73EC0-0x000000018BF73F04
	}

	public enum TileFlags // TypeDefIndex: 60952
	{
		None = 0,
		LockColor = 1,
		LockTransform = 2,
		LockAll = 3,
		InstantiateGameObjectRuntimeOnly = 4,
		KeepGameObjectRuntimeOnly = 8
	}

	public sealed class TilemapRenderer : Renderer // TypeDefIndex: 60953
	{
		// Constructors
		public TilemapRenderer() {} // Dummy constructor
	
		// Methods
		internal void RegisterSpriteAtlasRegistered() {} // 0x000000018BF73AEC-0x000000018BF73B64
		internal void UnregisterSpriteAtlasRegistered() {} // 0x000000018BF73B64-0x000000018BF73BDC
		internal void OnSpriteAtlasRegistered(SpriteAtlas atlas) {} // 0x000000018BF73AA8-0x000000018BF73AEC
	}

	public struct TileData // TypeDefIndex: 60954
	{
		// Fields
		private int m_Sprite; // 0x00
		private UnityEngine.Color m_Color; // 0x04
		private Matrix4x4 m_Transform; // 0x14
		private int m_GameObject; // 0x54
		private TileFlags m_Flags; // 0x58
		private Tile.ColliderType m_ColliderType; // 0x5C
		internal static readonly TileData Default; // 0x00
	
		// Properties
		public Sprite sprite { set {} } // 0x000000018BF7392C-0x000000018BF739A4
		public UnityEngine.Color color { set {} } // 0x0000000185FE5A80-0x0000000185FE5A90
		public Matrix4x4 transform { set {} } // 0x0000000185FE9220-0x0000000185FE9240
		public GameObject gameObject { set {} } // 0x000000018BF738B0-0x000000018BF7392C
		public TileFlags flags { set {} } // 0x0000000183F804E0-0x0000000183F804F0
		public Tile.ColliderType colliderType { set {} } // 0x0000000183F804F0-0x0000000183F80500
	
		// Constructors
		static TileData() {
			Default = default;
		} // 0x000000018BF7383C-0x000000018BF738B0
	
		// Methods
		private static TileData CreateDefault() => default; // 0x000000018BF73754-0x000000018BF7383C
	}

	internal struct TileDataNative // TypeDefIndex: 60955
	{
		// Fields
		private int m_Sprite; // 0x00
		private UnityEngine.Color m_Color; // 0x04
		private Matrix4x4 m_Transform; // 0x14
		private int m_GameObject; // 0x54
		private TileFlags m_Flags; // 0x58
		private Tile.ColliderType m_ColliderType; // 0x5C
	}

	public struct TileChangeData // TypeDefIndex: 60956
	{
		// Fields
		private Vector3Int m_Position; // 0x00
		private UnityEngine.Object m_TileAsset; // 0x10
		private UnityEngine.Color m_Color; // 0x18
		private Matrix4x4 m_Transform; // 0x28
	}

	public struct TileAnimationData // TypeDefIndex: 60957
	{
		// Fields
		private Sprite[] m_AnimatedSprites; // 0x00
		private float m_AnimationSpeed; // 0x08
		private float m_AnimationStartTime; // 0x0C
	}
}
