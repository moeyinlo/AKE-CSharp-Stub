/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.U2D;

// Image 112: UnityEngine.TilemapModule.dll - Assembly: UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59825-59836

namespace UnityEngine.Tilemaps
{
	[RequiredByNativeCode]
	public class ITilemap // TypeDefIndex: 59826
	{
		// Fields
		internal static ITilemap s_Instance; // 0x00
		internal Tilemap m_Tilemap; // 0x10
		internal bool m_AddToList; // 0x18
		internal int m_RefreshCount; // 0x1C
		internal NativeArray<Vector3Int> m_RefreshPos; // 0x20
	
		// Constructors
		internal ITilemap() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void RefreshTile(Vector3Int position) {} // 0x0000000189E5B80C-0x0000000189E5B970
		[RequiredByNativeCode]
		private static ITilemap CreateInstance() => default; // 0x0000000189E5B2E4-0x0000000189E5B358
		[RequiredByNativeCode]
		private static void FindAllRefreshPositions(ITilemap tilemap, int count, IntPtr oldTilesIntPtr, IntPtr newTilesIntPtr, IntPtr positionsIntPtr) {} // 0x0000000189E5B358-0x0000000189E5B5F4
		[RequiredByNativeCode]
		private static void GetAllTileData(ITilemap tilemap, int count, IntPtr tilesIntPtr, IntPtr positionsIntPtr, IntPtr outTileDataIntPtr) {} // 0x0000000189E5B5F4-0x0000000189E5B80C
	}

	[Serializable]
	[HelpURL("https://docs.unity3d.com/Manual/Tilemap-TileAsset.html")]
	[RequiredByNativeCode]
	public class Tile : TileBase // TypeDefIndex: 59828
	{
		// Fields
		[SerializeField]
		private Sprite m_Sprite; // 0x18
		[SerializeField]
		private UnityEngine.Color m_Color; // 0x20
		[SerializeField]
		private Matrix4x4 m_Transform; // 0x30
		[SerializeField]
		private GameObject m_InstancedGameObject; // 0x70
		[SerializeField]
		private TileFlags m_Flags; // 0x78
		[SerializeField]
		private ColliderType m_ColliderType; // 0x7C
	
		// Properties
		public Sprite sprite { get => default; set {} } // 0x0000000183D61D00-0x0000000183D61D10 0x00000001822C3A90-0x00000001822C3AA0
		public UnityEngine.Color color { get => default; set {} } // 0x0000000183D88020-0x0000000183D88030 0x0000000183D54E10-0x0000000183D54E20
		public Matrix4x4 transform { get => default; set {} } // 0x0000000183D883F0-0x0000000183D88420 0x0000000183D88420-0x0000000183D88440
		public GameObject gameObject { get => default; set {} } // 0x0000000183D87E20-0x0000000183D87E30 0x000000018519C3C8-0x000000018519C3D8
		public TileFlags flags { get => default; set {} } // 0x0000000183D87E70-0x0000000183D87E80 0x0000000183D4ECC0-0x0000000183D4ECD0
		public ColliderType colliderType { get => default; set {} } // 0x0000000183D883E0-0x0000000183D883F0 0x0000000183D4ED10-0x0000000183D4ED20
	
		// Nested types
		public enum ColliderType // TypeDefIndex: 59827
		{
			None = 0,
			Sprite = 1,
			Grid = 2
		}
	
		// Constructors
		public Tile() {} // 0x0000000189E5BD60-0x0000000189E5BDC0
	
		// Methods
		public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) {} // 0x0000000189E5BCBC-0x0000000189E5BD60
	}

	[RequiredByNativeCode]
	public abstract class TileBase : ScriptableObject // TypeDefIndex: 59829
	{
		// Constructors
		protected TileBase() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		[RequiredByNativeCode]
		public virtual void RefreshTile(Vector3Int position, ITilemap tilemap) {} // 0x0000000189E5BA34-0x0000000189E5BA6C
		[RequiredByNativeCode]
		public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) {} // 0x000000018350B670-0x000000018350B680
		private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) => default; // 0x0000000189E5B970-0x0000000189E5BA34
		[RequiredByNativeCode]
		public virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) => default; // 0x0000000183D4E3A0-0x0000000183D4E3B0
		private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) => default; // 0x0000000183D86200-0x0000000183D86210
		[RequiredByNativeCode]
		private void GetTileAnimationDataRef(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData, ref bool hasAnimation) {} // 0x0000000183D883B0-0x0000000183D883C0
		[RequiredByNativeCode]
		public virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) => default; // 0x0000000183D4E3A0-0x0000000183D4E3B0
		[RequiredByNativeCode]
		private void StartUpRef(Vector3Int position, ITilemap tilemap, GameObject go, ref bool startUpInvokedByUser) {} // 0x0000000183D883B0-0x0000000183D883C0
	}

	[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
	[NativeHeader("Modules/Grid/Public/Grid.h")]
	[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
	[NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
	[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
	[NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
	[RequireComponent(typeof(Transform))]
	public sealed class Tilemap : GridLayout // TypeDefIndex: 59830
	{
		// Properties
		public UnityEngine.Grid layoutGrid { [NativeMethod(Name = "GetAttachedGrid")] get => default; } // 0x0000000189E5C318-0x0000000189E5C34C 
		public BoundsInt cellBounds { get => default; } // 0x0000000189E5C284-0x0000000189E5C318 
		public Vector3Int origin { get => default; } // 0x0000000189E5C40C-0x0000000189E5C438 
		public Vector3Int size { get => default; } // 0x0000000189E5C47C-0x0000000189E5C4A8 
		[NativeProperty(Name = "TileAnchorScripting")]
		public Vector3 tileAnchor { get => default; } // 0x0000000189E5C4EC-0x0000000189E5C6A8 
		public Matrix4x4 orientationMatrix { [NativeMethod(Name = "GetTileOrientationMatrix")] get => default; } // 0x0000000189E5C390-0x0000000189E5C3C8 
	
		// Constructors
		public Tilemap() {} // Dummy constructor
	
		// Methods
		internal UnityEngine.Object GetTileAsset(Vector3Int position) => default; // 0x0000000189E5BF38-0x0000000189E5BF4C
		public T GetTile<T>(Vector3Int position)
			where T : TileBase => default;
		internal UnityEngine.Object[] GetTileAssetsBlock(Vector3Int position, Vector3Int blockDimensions) => default; // 0x0000000189E5BFA0-0x0000000189E5BFB4
		public TileBase[] GetTilesBlock(BoundsInt bounds) => default; // 0x0000000189E5BFB4-0x0000000189E5C0E0
		public bool HasTile(Vector3Int position) => default; // 0x0000000189E5C120-0x0000000189E5C194
		[NativeMethod(Name = "RefreshTileAsset")]
		public void RefreshTile(Vector3Int position) {} // 0x0000000189E5C21C-0x0000000189E5C230
		[FreeFunction(Name = "TilemapBindings::RefreshTileAssetsNative", HasExplicitThis = true)]
		internal unsafe void RefreshTilesNative(void* positions, int count) {} // 0x0000000189E5C230-0x0000000189E5C284
		public int GetUsedTilesCount() => default; // 0x0000000189E5C0E0-0x0000000189E5C114
		public int GetUsedTilesNonAlloc(TileBase[] usedTiles) => default; // 0x0000000189E5C114-0x0000000189E5C120
		[FreeFunction(Name = "TilemapBindings::GetUsedTilesNonAlloc", HasExplicitThis = true)]
		internal int Internal_GetUsedTilesNonAlloc([Unmarshalled] UnityEngine.Object[] usedTiles) => default; // 0x0000000189E5C194-0x0000000189E5C1D8
		private void get_origin_Injected(out Vector3Int ret) {
			ret = default;
		} // 0x0000000189E5C3C8-0x0000000189E5C40C
		private void get_size_Injected(out Vector3Int ret) {
			ret = default;
		} // 0x0000000189E5C438-0x0000000189E5C47C
		private void get_tileAnchor_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189E5C4A8-0x0000000189E5C4EC
		private void get_orientationMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000189E5C34C-0x0000000189E5C390
		private UnityEngine.Object GetTileAsset_Injected(ref Vector3Int position) => default; // 0x0000000189E5BEF4-0x0000000189E5BF38
		private UnityEngine.Object[] GetTileAssetsBlock_Injected(ref Vector3Int position, ref Vector3Int blockDimensions) => default; // 0x0000000189E5BF4C-0x0000000189E5BFA0
		private void RefreshTile_Injected(ref Vector3Int position) {} // 0x0000000189E5C1D8-0x0000000189E5C21C
	}

	[Flags]
	public enum TileFlags // TypeDefIndex: 59831
	{
		None = 0,
		LockColor = 1,
		LockTransform = 2,
		LockAll = 3,
		InstantiateGameObjectRuntimeOnly = 4,
		KeepGameObjectRuntimeOnly = 8
	}

	[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
	[NativeHeader("Modules/Tilemap/TilemapRendererJobs.h")]
	[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
	[NativeType(Header = "Modules/Tilemap/Public/TilemapRenderer.h")]
	[RequireComponent(typeof(Tilemap))]
	public sealed class TilemapRenderer : Renderer // TypeDefIndex: 59832
	{
		// Constructors
		public TilemapRenderer() {} // Dummy constructor
	
		// Methods
		[RequiredByNativeCode]
		internal void RegisterSpriteAtlasRegistered() {} // 0x0000000189E5BE04-0x0000000189E5BE7C
		[RequiredByNativeCode]
		internal void UnregisterSpriteAtlasRegistered() {} // 0x0000000189E5BE7C-0x0000000189E5BEF4
		internal void OnSpriteAtlasRegistered(SpriteAtlas atlas) {} // 0x0000000189E5BDC0-0x0000000189E5BE04
	}

	[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
	[RequiredByNativeCode]
	public struct TileData // TypeDefIndex: 59833
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
		public Sprite sprite { set {} } // 0x0000000189E5BC44-0x0000000189E5BCBC
		public UnityEngine.Color color { set {} } // 0x0000000183D84E00-0x0000000183D84E10
		public Matrix4x4 transform { set {} } // 0x0000000183D883C0-0x0000000183D883E0
		public GameObject gameObject { set {} } // 0x0000000189E5BBC8-0x0000000189E5BC44
		public TileFlags flags { set {} } // 0x0000000183D4EF50-0x0000000183D4EF60
		public Tile.ColliderType colliderType { set {} } // 0x0000000183D4EF40-0x0000000183D4EF50
	
		// Constructors
		static TileData() {
			Default = default;
		} // 0x0000000189E5BB54-0x0000000189E5BBC8
	
		// Methods
		private static TileData CreateDefault() => default; // 0x0000000189E5BA6C-0x0000000189E5BB54
	}

	[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
	[RequiredByNativeCode]
	internal struct TileDataNative // TypeDefIndex: 59834
	{
		// Fields
		private int m_Sprite; // 0x00
		private UnityEngine.Color m_Color; // 0x04
		private Matrix4x4 m_Transform; // 0x14
		private int m_GameObject; // 0x54
		private TileFlags m_Flags; // 0x58
		private Tile.ColliderType m_ColliderType; // 0x5C
	}

	[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
	[RequiredByNativeCode]
	public struct TileChangeData // TypeDefIndex: 59835
	{
		// Fields
		private Vector3Int m_Position; // 0x00
		private UnityEngine.Object m_TileAsset; // 0x10
		private UnityEngine.Color m_Color; // 0x18
		private Matrix4x4 m_Transform; // 0x28
	}

	[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
	[RequiredByNativeCode]
	public struct TileAnimationData // TypeDefIndex: 59836
	{
		// Fields
		private Sprite[] m_AnimatedSprites; // 0x00
		private float m_AnimationSpeed; // 0x08
		private float m_AnimationStartTime; // 0x0C
	}
}
