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

// Image 119: UnityEngine.TilemapModule.dll - Assembly: UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91033-91044

namespace UnityEngine.Tilemaps
{
	[RequiredByNativeCode]
	public class ITilemap // TypeDefIndex: 91034
	{
		// Fields
		internal static ITilemap s_Instance; // 0x00
		internal Tilemap m_Tilemap; // 0x10
		internal bool m_AddToList; // 0x18
		internal int m_RefreshCount; // 0x1C
		internal NativeArray<Vector3Int> m_RefreshPos; // 0x20
	
		// Constructors
		internal ITilemap(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void RefreshTile(Vector3Int position); // 0x000000018D588F90-0x000000018D5890F4
		[RequiredByNativeCode]
		private static ITilemap CreateInstance(); // 0x000000018D588A64-0x000000018D588AD8
		[RequiredByNativeCode]
		private static void FindAllRefreshPositions(ITilemap tilemap, int count, IntPtr oldTilesIntPtr, IntPtr newTilesIntPtr, IntPtr positionsIntPtr); // 0x000000018D588AD8-0x000000018D588D78
		[RequiredByNativeCode]
		private static void GetAllTileData(ITilemap tilemap, int count, IntPtr tilesIntPtr, IntPtr positionsIntPtr, IntPtr outTileDataIntPtr); // 0x000000018D588D78-0x000000018D588F90
	}

	[Serializable]
	[HelpURL("https://docs.unity3d.com/Manual/Tilemap-TileAsset.html")]
	[RequiredByNativeCode]
	public class Tile : TileBase // TypeDefIndex: 91036
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
		public Sprite sprite { get; set; } // 0x0000000187244530-0x0000000187244540 0x0000000187835500-0x0000000187835510
		public UnityEngine.Color color { get; set; } // 0x00000001872621C0-0x00000001872621D0 0x0000000187238F70-0x0000000187238F80
		public Matrix4x4 transform { get; set; } // 0x00000001872625D0-0x0000000187262600 0x0000000187262600-0x0000000187262620
		public GameObject gameObject { get; set; } // 0x0000000187261FC0-0x0000000187261FD0 0x0000000188800CD0-0x0000000188800CE0
		public TileFlags flags { get; set; } // 0x0000000187262010-0x0000000187262020 0x0000000187233100-0x0000000187233110
		public ColliderType colliderType { get; set; } // 0x00000001872625C0-0x00000001872625D0 0x0000000187233140-0x0000000187233150
	
		// Nested types
		public enum ColliderType // TypeDefIndex: 91035
		{
			None = 0,
			Sprite = 1,
			Grid = 2
		}
	
		// Constructors
		public Tile(); // 0x000000018D5894EC-0x000000018D589554
	
		// Methods
		public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData); // 0x000000018D589448-0x000000018D5894EC
	}

	[RequiredByNativeCode]
	public abstract class TileBase : ScriptableObject // TypeDefIndex: 91037
	{
		// Constructors
		protected TileBase(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		[RequiredByNativeCode]
		public virtual void RefreshTile(Vector3Int position, ITilemap tilemap); // 0x000000018D5891B8-0x000000018D5891F0
		[RequiredByNativeCode]
		public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData); // 0x0000000186805BA0-0x0000000186805BB0
		private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap); // 0x000000018D5890F4-0x000000018D5891B8
		[RequiredByNativeCode]
		public virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData); // 0x0000000187232850-0x0000000187232860
		private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap); // 0x00000001872606B0-0x00000001872606C0
		[RequiredByNativeCode]
		private void GetTileAnimationDataRef(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData, ref bool hasAnimation); // 0x0000000187262590-0x00000001872625A0
		[RequiredByNativeCode]
		public virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go); // 0x0000000187232850-0x0000000187232860
		[RequiredByNativeCode]
		private void StartUpRef(Vector3Int position, ITilemap tilemap, GameObject go, ref bool startUpInvokedByUser); // 0x0000000187262590-0x00000001872625A0
	}

	[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
	[NativeHeader("Modules/Grid/Public/Grid.h")]
	[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
	[NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
	[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
	[NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
	[RequireComponent(typeof(Transform))]
	public sealed class Tilemap : GridLayout // TypeDefIndex: 91038
	{
		// Properties
		public UnityEngine.Grid layoutGrid { [NativeMethod(Name = "GetAttachedGrid")] get; } // 0x000000018D589AD0-0x000000018D589B04 
		public BoundsInt cellBounds { get; } // 0x000000018D589A2C-0x000000018D589AD0 
		public Vector3Int origin { get; } // 0x000000018D589BC4-0x000000018D589BF0 
		public Vector3Int size { get; } // 0x000000018D589C34-0x000000018D589C60 
		[NativeProperty(Name = "TileAnchorScripting")]
		public Vector3 tileAnchor { get; } // 0x000000018D589CA4-0x000000018D589E10 
		public Matrix4x4 orientationMatrix { [NativeMethod(Name = "GetTileOrientationMatrix")] get; } // 0x000000018D589B48-0x000000018D589B80 
	
		// Methods
		internal UnityEngine.Object GetTileAsset(Vector3Int position); // 0x000000018D5896CC-0x000000018D5896E0
		public T GetTile<T>(Vector3Int position)
			where T : TileBase;
		internal UnityEngine.Object[] GetTileAssetsBlock(Vector3Int position, Vector3Int blockDimensions); // 0x000000018D589734-0x000000018D589748
		public TileBase[] GetTilesBlock(BoundsInt bounds); // 0x000000018D589748-0x000000018D589888
		public bool HasTile(Vector3Int position); // 0x000000018D5898C8-0x000000018D58993C
		[NativeMethod(Name = "RefreshTileAsset")]
		public void RefreshTile(Vector3Int position); // 0x000000018D5899C4-0x000000018D5899D8
		[FreeFunction(Name = "TilemapBindings::RefreshTileAssetsNative", HasExplicitThis = true)]
		internal unsafe void RefreshTilesNative(void* positions, int count); // 0x000000018D5899D8-0x000000018D589A2C
		public int GetUsedTilesCount(); // 0x000000018D589888-0x000000018D5898BC
		public int GetUsedTilesNonAlloc(TileBase[] usedTiles); // 0x000000018D5898BC-0x000000018D5898C8
		[FreeFunction(Name = "TilemapBindings::GetUsedTilesNonAlloc", HasExplicitThis = true)]
		internal int Internal_GetUsedTilesNonAlloc([Unmarshalled] UnityEngine.Object[] usedTiles); // 0x000000018D58993C-0x000000018D589980
		private void get_origin_Injected(out Vector3Int ret); // 0x000000018D589B80-0x000000018D589BC4
		private void get_size_Injected(out Vector3Int ret); // 0x000000018D589BF0-0x000000018D589C34
		private void get_tileAnchor_Injected(out Vector3 ret); // 0x000000018D589C60-0x000000018D589CA4
		private void get_orientationMatrix_Injected(out Matrix4x4 ret); // 0x000000018D589B04-0x000000018D589B48
		private UnityEngine.Object GetTileAsset_Injected(ref Vector3Int position); // 0x000000018D589688-0x000000018D5896CC
		private UnityEngine.Object[] GetTileAssetsBlock_Injected(ref Vector3Int position, ref Vector3Int blockDimensions); // 0x000000018D5896E0-0x000000018D589734
		private void RefreshTile_Injected(ref Vector3Int position); // 0x000000018D589980-0x000000018D5899C4
	}

	[Flags]
	public enum TileFlags // TypeDefIndex: 91039
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
	public sealed class TilemapRenderer : Renderer // TypeDefIndex: 91040
	{
		// Methods
		[RequiredByNativeCode]
		internal void RegisterSpriteAtlasRegistered(); // 0x000000018D589598-0x000000018D589610
		[RequiredByNativeCode]
		internal void UnregisterSpriteAtlasRegistered(); // 0x000000018D589610-0x000000018D589688
		internal void OnSpriteAtlasRegistered(SpriteAtlas atlas); // 0x000000018D589554-0x000000018D589598
	}

	[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
	[RequiredByNativeCode]
	public struct TileData // TypeDefIndex: 91041
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
		public Sprite sprite { set; } // 0x000000018D5893D0-0x000000018D589448
		public UnityEngine.Color color { set; } // 0x000000018723A660-0x000000018723A670
		public Matrix4x4 transform { set; } // 0x00000001872625A0-0x00000001872625C0
		public GameObject gameObject { set; } // 0x000000018D589354-0x000000018D5893D0
		public TileFlags flags { set; } // 0x0000000185B8E8A0-0x0000000185B8EB10
		public Tile.ColliderType colliderType { set; } // 0x0000000187233630-0x0000000187233640
	
		// Constructors
		static TileData(); // 0x000000018D5892E0-0x000000018D589354
	
		// Methods
		private static TileData CreateDefault(); // 0x000000018D5891F0-0x000000018D5892E0
	}

	[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
	[RequiredByNativeCode]
	internal struct TileDataNative // TypeDefIndex: 91042
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
	public struct TileChangeData // TypeDefIndex: 91043
	{
		// Fields
		private Vector3Int m_Position; // 0x00
		private UnityEngine.Object m_TileAsset; // 0x10
		private UnityEngine.Color m_Color; // 0x18
		private Matrix4x4 m_Transform; // 0x28
	}

	[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
	[RequiredByNativeCode]
	public struct TileAnimationData // TypeDefIndex: 91044
	{
		// Fields
		private Sprite[] m_AnimatedSprites; // 0x00
		private float m_AnimationSpeed; // 0x08
		private float m_AnimationStartTime; // 0x0C
	}
}
