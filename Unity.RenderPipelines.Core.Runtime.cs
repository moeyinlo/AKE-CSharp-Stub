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
using Microsoft.CodeAnalysis;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph.ECS;
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

// Image 30: Unity.RenderPipelines.Core.Runtime.dll - Assembly: Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 83208-83618

[ExecuteAlways]
public class SceneRenderPipeline : MonoBehaviour // TypeDefIndex: 83211
{
	// Fields
	public RenderPipelineAsset renderPipelineAsset; // 0x18

	// Constructors
	public SceneRenderPipeline(); // 0x00000001878364A0-0x00000001878364B8

	// Methods
	private void OnEnable(); // 0x000000018D3C6424-0x000000018D3C6430
	private void OnValidate(); // 0x000000018D3C6424-0x000000018D3C6430
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 83618
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_256 _45AC882BD91FEBD5A58E67471A0EF32BFC485447A8A18D61DBA335FDA5A2C097; // 0x00 // Static value (base64): AAAAAAAAAAAAAAAAAAAAAAAAgD0AAAA/AAAAAAAAAAAAAAA+AACAPgAAAAAAAAAAAABAPgAAQD8AAAAAAAAAAAAAgD4AAAA+AAAAAAAAAAAAAKA+AAAgPwAAAAAAAAAAAADAPgAAwD4AAAAAAAAAAAAA4D4AAGA/AAAAAAAAAAAAAAA/AACAPQAAAAAAAAAAAAAQPwAAED8AAAAAAAAAAAAAID8AAKA+AAAAAAAAAAAAADA/AABQPwAAAAAAAAAAAABAPwAAQD4AAAAAAAAAAAAAUD8AADA/AAAAAAAAAAAAAGA/AADgPgAAAAAAAAAAAABwPwAAcD8AAAAAAAAAAA== - Metadata: 0x02642330
	internal static readonly __StaticArrayInitTypeSize_512 _4A1D5C231BB4DDB64A57CFF5FC45592F845DB22D8DE0DCCA7BB59D822908C39A; // 0x100 // Static value (base64): AAAAAAAAAAAAAAAAAAAAAAAAAD0AAAA/AAAAAAAAAAAAAIA9AACAPgAAAAAAAAAAAADAPQAAQD8AAAAAAAAAAAAAAD4AAAA+AAAAAAAAAAAAACA+AAAgPwAAAAAAAAAAAABAPgAAwD4AAAAAAAAAAAAAYD4AAGA/AAAAAAAAAAAAAIA+AACAPQAAAAAAAAAAAACQPgAAED8AAAAAAAAAAAAAoD4AAKA+AAAAAAAAAAAAALA+AABQPwAAAAAAAAAAAADAPgAAQD4AAAAAAAAAAAAA0D4AADA/AAAAAAAAAAAAAOA+AADgPgAAAAAAAAAAAADwPgAAcD8AAAAAAAAAAAAAAD8AAAA9AAAAAAAAAAAAAAg/AAAIPwAAAAAAAAAAAAAQPwAAkD4AAAAAAAAAAAAAGD8AAEg/AAAAAAAAAAAAACA/AAAgPgAAAAAAAAAAAAAoPwAAKD8AAAAAAAAAAAAAMD8AANA+AAAAAAAAAAAAADg/AABoPwAAAAAAAAAAAABAPwAAwD0AAAAAAAAAAAAASD8AABg/AAAAAAAAAAAAAFA/AACwPgAAAAAAAAAAAABYPwAAWD8AAAAAAAAAAAAAYD8AAGA+AAAAAAAAAAAAAGg/AAA4PwAAAAAAAAAAAABwPwAA8D4AAAAAAAAAAAAAeD8AAHg/AAAAAAAAAAA= - Metadata: 0x02642438
	internal static readonly __StaticArrayInitTypeSize_1024 _90C2D148CDB931199C77ADD692B92324CDFC328EDD1D0AB7FA24830C177A4FF4; // 0x300 // Static value (base64): AAAAAAAAAAAAAAAAAAAAAAAAgDwAAAA/AAAAAAAAAAAAAAA9AACAPgAAAAAAAAAAAABAPQAAQD8AAAAAAAAAAAAAgD0AAAA+AAAAAAAAAAAAAKA9AAAgPwAAAAAAAAAAAADAPQAAwD4AAAAAAAAAAAAA4D0AAGA/AAAAAAAAAAAAAAA+AACAPQAAAAAAAAAAAAAQPgAAED8AAAAAAAAAAAAAID4AAKA+AAAAAAAAAAAAADA+AABQPwAAAAAAAAAAAABAPgAAQD4AAAAAAAAAAAAAUD4AADA/AAAAAAAAAAAAAGA+AADgPgAAAAAAAAAAAABwPgAAcD8AAAAAAAAAAAAAgD4AAAA9AAAAAAAAAAAAAIg+AAAIPwAAAAAAAAAAAACQPgAAkD4AAAAAAAAAAAAAmD4AAEg/AAAAAAAAAAAAAKA+AAAgPgAAAAAAAAAAAACoPgAAKD8AAAAAAAAAAAAAsD4AANA+AAAAAAAAAAAAALg+AABoPwAAAAAAAAAAAADAPgAAwD0AAAAAAAAAAAAAyD4AABg/AAAAAAAAAAAAANA+AACwPgAAAAAAAAAAAADYPgAAWD8AAAAAAAAAAAAA4D4AAGA+AAAAAAAAAAAAAOg+AAA4PwAAAAAAAAAAAADwPgAA8D4AAAAAAAAAAAAA+D4AAHg/AAAAAAAAAAAAAAA/AACAPAAAAAAAAAAAAAAEPwAABD8AAAAAAAAAAAAACD8AAIg+AAAAAAAAAAAAAAw/AABEPwAAAAAAAAAAAAAQPwAAED4AAAAAAAAAAAAAFD8AACQ/AAAAAAAAAAAAABg/AADIPgAAAAAAAAAAAAAcPwAAZD8AAAAAAAAAAAAAID8AAKA9AAAAAAAAAAAAACQ/AAAUPwAAAAAAAAAAAAAoPwAAqD4AAAAAAAAAAAAALD8AAFQ/AAAAAAAAAAAAADA/AABQPgAAAAAAAAAAAAA0PwAAND8AAAAAAAAAAAAAOD8AAOg+AAAAAAAAAAAAADw/AAB0PwAAAAAAAAAAAABAPwAAQD0AAAAAAAAAAAAARD8AAAw/AAAAAAAAAAAAAEg/AACYPgAAAAAAAAAAAABMPwAATD8AAAAAAAAAAAAAUD8AADA+AAAAAAAAAAAAAFQ/AAAsPwAAAAAAAAAAAABYPwAA2D4AAAAAAAAAAAAAXD8AAGw/AAAAAAAAAAAAAGA/AADgPQAAAAAAAAAAAABkPwAAHD8AAAAAAAAAAAAAaD8AALg+AAAAAAAAAAAAAGw/AABcPwAAAAAAAAAAAABwPwAAcD4AAAAAAAAAAAAAdD8AADw/AAAAAAAAAAAAAHg/AAD4PgAAAAAAAAAAAAB8PwAAfD8AAAAAAAAAAA== - Metadata: 0x02642640
	internal static readonly __StaticArrayInitTypeSize_144 BDFF4BF48DBC7214A392CF884F7F2A6073CCDB77CA3EB11BEBB93DA8ED8B2158; // 0x700 // Static value (base64): AwAAAAEAAAAAAAAAAwAAAAIAAAABAAAABwAAAAUAAAAEAAAABwAAAAYAAAAFAAAACwAAAAkAAAAIAAAACwAAAAoAAAAJAAAADwAAAA0AAAAMAAAADwAAAA4AAAANAAAAEwAAABEAAAAQAAAAEwAAABIAAAARAAAAFwAAABUAAAAUAAAAFwAAABYAAAAVAAAA - Metadata: 0x02642A48
	internal static readonly __StaticArrayInitTypeSize_4096 C606E03B5FE8EAD2ECA6BCB45AE684039D928B4EE7C4A03C63D0DF9F94F81DAF; // 0x790 // Static value (base64): AAAAAAAAAAAAAAAAAAAAAAAAgDsAAAA/AAAAAAAAAAAAAAA8AACAPgAAAAAAAAAAAABAPAAAQD8AAAAAAAAAAAAAgDwAAAA+AAAAAAAAAAAAAKA8AAAgPwAAAAAAAAAAAADAPAAAwD4AAAAAAAAAAAAA4DwAAGA/AAAAAAAAAAAAAAA9AACAPQAAAAAAAAAAAAAQPQAAED8AAAAAAAAAAAAAID0AAKA+AAAAAAAAAAAAADA9AABQPwAAAAAAAAAAAABAPQAAQD4AAAAAAAAAAAAAUD0AADA/AAAAAAAAAAAAAGA9AADgPgAAAAAAAAAAAABwPQAAcD8AAAAAAAAAAAAAgD0AAAA9AAAAAAAAAAAAAIg9AAAIPwAAAAAAAAAAAACQPQAAkD4AAAAAAAAAAAAAmD0AAEg/AAAAAAAAAAAAAKA9AAAgPgAAAAAAAAAAAACoPQAAKD8AAAAAAAAAAAAAsD0AANA+AAAAAAAAAAAAALg9AABoPwAAAAAAAAAAAADAPQAAwD0AAAAAAAAAAAAAyD0AABg/AAAAAAAAAAAAANA9AACwPgAAAAAAAAAAAADYPQAAWD8AAAAAAAAAAAAA4D0AAGA+AAAAAAAAAAAAAOg9AAA4PwAAAAAAAAAAAADwPQAA8D4AAAAAAAAAAAAA+D0AAHg/AAAAAAAAAAAAAAA+AACAPAAAAAAAAAAAAAAEPgAABD8AAAAAAAAAAAAACD4AAIg+AAAAAAAAAAAAAAw+AABEPwAAAAAAAAAAAAAQPgAAED4AAAAAAAAAAAAAFD4AACQ/AAAAAAAAAAAAABg+AADIPgAAAAAAAAAAAAAcPgAAZD8AAAAAAAAAAAAAID4AAKA9AAAAAAAAAAAAACQ+AAAUPwAAAAAAAAAAAAAoPgAAqD4AAAAAAAAAAAAALD4AAFQ/AAAAAAAAAAAAADA+AABQPgAAAAAAAAAAAAA0PgAAND8AAAAAAAAAAAAAOD4AAOg+AAAAAAAAAAAAADw+AAB0PwAAAAAAAAAAAABAPgAAQD0AAAAAAAAAAAAARD4AAAw/AAAAAAAAAAAAAEg+AACYPgAAAAAAAAAAAABMPgAATD8AAAAAAAAAAAAAUD4AADA+AAAAAAAAAAAAAFQ+AAAsPwAAAAAAAAAAAABYPgAA2D4AAAAAAAAAAAAAXD4AAGw/AAAAAAAAAAAAAGA+AADgPQAAAAAAAAAAAABkPgAAHD8AAAAAAAAAAAAAaD4AALg+AAAAAAAAAAAAAGw+AABcPwAAAAAAAAAAAABwPgAAcD4AAAAAAAAAAAAAdD4AADw/AAAAAAAAAAAAAHg+AAD4PgAAAAAAAAAAAAB8PgAAfD8AAAAAAAAAAAAAgD4AAAA8AAAAAAAAAAAAAII+AAACPwAAAAAAAAAAAACEPgAAhD4AAAAAAAAAAAAAhj4AAEI/AAAAAAAAAAAAAIg+AAAIPgAAAAAAAAAAAACKPgAAIj8AAAAAAAAAAAAAjD4AAMQ+AAAAAAAAAAAAAI4+AABiPwAAAAAAAAAAAACQPgAAkD0AAAAAAAAAAAAAkj4AABI/AAAAAAAAAAAAAJQ+AACkPgAAAAAAAAAAAACWPgAAUj8AAAAAAAAAAAAAmD4AAEg+AAAAAAAAAAAAAJo+AAAyPwAAAAAAAAAAAACcPgAA5D4AAAAAAAAAAAAAnj4AAHI/AAAAAAAAAAAAAKA+AAAgPQAAAAAAAAAAAACiPgAACj8AAAAAAAAAAAAApD4AAJQ+AAAAAAAAAAAAAKY+AABKPwAAAAAAAAAAAACoPgAAKD4AAAAAAAAAAAAAqj4AACo/AAAAAAAAAAAAAKw+AADUPgAAAAAAAAAAAACuPgAAaj8AAAAAAAAAAAAAsD4AANA9AAAAAAAAAAAAALI+AAAaPwAAAAAAAAAAAAC0PgAAtD4AAAAAAAAAAAAAtj4AAFo/AAAAAAAAAAAAALg+AABoPgAAAAAAAAAAAAC6PgAAOj8AAAAAAAAAAAAAvD4AAPQ+AAAAAAAAAAAAAL4+AAB6PwAAAAAAAAAAAADAPgAAwDwAAAAAAAAAAAAAwj4AAAY/AAAAAAAAAAAAAMQ+AACMPgAAAAAAAAAAAADGPgAARj8AAAAAAAAAAAAAyD4AABg+AAAAAAAAAAAAAMo+AAAmPwAAAAAAAAAAAADMPgAAzD4AAAAAAAAAAAAAzj4AAGY/AAAAAAAAAAAAANA+AACwPQAAAAAAAAAAAADSPgAAFj8AAAAAAAAAAAAA1D4AAKw+AAAAAAAAAAAAANY+AABWPwAAAAAAAAAAAADYPgAAWD4AAAAAAAAAAAAA2j4AADY/AAAAAAAAAAAAANw+AADsPgAAAAAAAAAAAADePgAAdj8AAAAAAAAAAAAA4D4AAGA9AAAAAAAAAAAAAOI+AAAOPwAAAAAAAAAAAADkPgAAnD4AAAAAAAAAAAAA5j4AAE4/AAAAAAAAAAAAAOg+AAA4PgAAAAAAAAAAAADqPgAALj8AAAAAAAAAAAAA7D4AANw+AAAAAAAAAAAAAO4+AABuPwAAAAAAAAAAAADwPgAA8D0AAAAAAAAAAAAA8j4AAB4/AAAAAAAAAAAAAPQ+AAC8PgAAAAAAAAAAAAD2PgAAXj8AAAAAAAAAAAAA+D4AAHg+AAAAAAAAAAAAAPo+AAA+PwAAAAAAAAAAAAD8PgAA/D4AAAAAAAAAAAAA/j4AAH4/AAAAAAAAAAAAAAA/AACAOwAAAAAAAAAAAAABPwAAAT8AAAAAAAAAAAAAAj8AAII+AAAAAAAAAAAAAAM/AABBPwAAAAAAAAAAAAAEPwAABD4AAAAAAAAAAAAABT8AACE/AAAAAAAAAAAAAAY/AADCPgAAAAAAAAAAAAAHPwAAYT8AAAAAAAAAAAAACD8AAIg9AAAAAAAAAAAAAAk/AAARPwAAAAAAAAAAAAAKPwAAoj4AAAAAAAAAAAAACz8AAFE/AAAAAAAAAAAAAAw/AABEPgAAAAAAAAAAAAANPwAAMT8AAAAAAAAAAAAADj8AAOI+AAAAAAAAAAAAAA8/AABxPwAAAAAAAAAAAAAQPwAAED0AAAAAAAAAAAAAET8AAAk/AAAAAAAAAAAAABI/AACSPgAAAAAAAAAAAAATPwAAST8AAAAAAAAAAAAAFD8AACQ+AAAAAAAAAAAAABU/AAApPwAAAAAAAAAAAAAWPwAA0j4AAAAAAAAAAAAAFz8AAGk/AAAAAAAAAAAAABg/AADIPQAAAAAAAAAAAAAZPwAAGT8AAAAAAAAAAAAAGj8AALI+AAAAAAAAAAAAABs/AABZPwAAAAAAAAAAAAAcPwAAZD4AAAAAAAAAAAAAHT8AADk/AAAAAAAAAAAAAB4/AADyPgAAAAAAAAAAAAAfPwAAeT8AAAAAAAAAAAAAID8AAKA8AAAAAAAAAAAAACE/AAAFPwAAAAAAAAAAAAAiPwAAij4AAAAAAAAAAAAAIz8AAEU/AAAAAAAAAAAAACQ/AAAUPgAAAAAAAAAAAAAlPwAAJT8AAAAAAAAAAAAAJj8AAMo+AAAAAAAAAAAAACc/AABlPwAAAAAAAAAAAAAoPwAAqD0AAAAAAAAAAAAAKT8AABU/AAAAAAAAAAAAACo/AACqPgAAAAAAAAAAAAArPwAAVT8AAAAAAAAAAAAALD8AAFQ+AAAAAAAAAAAAAC0/AAA1PwAAAAAAAAAAAAAuPwAA6j4AAAAAAAAAAAAALz8AAHU/AAAAAAAAAAAAADA/AABQPQAAAAAAAAAAAAAxPwAADT8AAAAAAAAAAAAAMj8AAJo+AAAAAAAAAAAAADM/AABNPwAAAAAAAAAAAAA0PwAAND4AAAAAAAAAAAAANT8AAC0/AAAAAAAAAAAAADY/AADaPgAAAAAAAAAAAAA3PwAAbT8AAAAAAAAAAAAAOD8AAOg9AAAAAAAAAAAAADk/AAAdPwAAAAAAAAAAAAA6PwAAuj4AAAAAAAAAAAAAOz8AAF0/AAAAAAAAAAAAADw/AAB0PgAAAAAAAAAAAAA9PwAAPT8AAAAAAAAAAAAAPj8AAPo+AAAAAAAAAAAAAD8/AAB9PwAAAAAAAAAAAABAPwAAQDwAAAAAAAAAAAAAQT8AAAM/AAAAAAAAAAAAAEI/AACGPgAAAAAAAAAAAABDPwAAQz8AAAAAAAAAAAAARD8AAAw+AAAAAAAAAAAAAEU/AAAjPwAAAAAAAAAAAABGPwAAxj4AAAAAAAAAAAAARz8AAGM/AAAAAAAAAAAAAEg/AACYPQAAAAAAAAAAAABJPwAAEz8AAAAAAAAAAAAASj8AAKY+AAAAAAAAAAAAAEs/AABTPwAAAAAAAAAAAABMPwAATD4AAAAAAAAAAAAATT8AADM/AAAAAAAAAAAAAE4/AADmPgAAAAAAAAAAAABPPwAAcz8AAAAAAAAAAAAAUD8AADA9AAAAAAAAAAAAAFE/AAALPwAAAAAAAAAAAABSPwAAlj4AAAAAAAAAAAAAUz8AAEs/AAAAAAAAAAAAAFQ/AAAsPgAAAAAAAAAAAABVPwAAKz8AAAAAAAAAAAAAVj8AANY+AAAAAAAAAAAAAFc/AABrPwAAAAAAAAAAAABYPwAA2D0AAAAAAAAAAAAAWT8AABs/AAAAAAAAAAAAAFo/AAC2PgAAAAAAAAAAAABbPwAAWz8AAAAAAAAAAAAAXD8AAGw+AAAAAAAAAAAAAF0/AAA7PwAAAAAAAAAAAABePwAA9j4AAAAAAAAAAAAAXz8AAHs/AAAAAAAAAAAAAGA/AADgPAAAAAAAAAAAAABhPwAABz8AAAAAAAAAAAAAYj8AAI4+AAAAAAAAAAAAAGM/AABHPwAAAAAAAAAAAABkPwAAHD4AAAAAAAAAAAAAZT8AACc/AAAAAAAAAAAAAGY/AADOPgAAAAAAAAAAAABnPwAAZz8AAAAAAAAAAAAAaD8AALg9AAAAAAAAAAAAAGk/AAAXPwAAAAAAAAAAAABqPwAArj4AAAAAAAAAAAAAaz8AAFc/AAAAAAAAAAAAAGw/AABcPgAAAAAAAAAAAABtPwAANz8AAAAAAAAAAAAAbj8AAO4+AAAAAAAAAAAAAG8/AAB3PwAAAAAAAAAAAABwPwAAcD0AAAAAAAAAAAAAcT8AAA8/AAAAAAAAAAAAAHI/AACePgAAAAAAAAAAAABzPwAATz8AAAAAAAAAAAAAdD8AADw+AAAAAAAAAAAAAHU/AAAvPwAAAAAAAAAAAAB2PwAA3j4AAAAAAAAAAAAAdz8AAG8/AAAAAAAAAAAAAHg/AAD4PQAAAAAAAAAAAAB5PwAAHz8AAAAAAAAAAAAAej8AAL4+AAAAAAAAAAAAAHs/AABfPwAAAAAAAAAAAAB8PwAAfD4AAAAAAAAAAAAAfT8AAD8/AAAAAAAAAAAAAH4/AAD+PgAAAAAAAAAAAAB/PwAAfz8AAAAAAAAAAA== - Metadata: 0x02642AE0
	internal static readonly __StaticArrayInitTypeSize_24 FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE; // 0x1790 // Static value (base64): AAAAAAEAAAACAAAAAAAAAAIAAAADAAAA - Metadata: 0x02643AE8

	// Nested types
	private struct __StaticArrayInitTypeSize_24 // TypeDefIndex: 83612
	{
	}

	private struct __StaticArrayInitTypeSize_144 // TypeDefIndex: 83613
	{
	}

	private struct __StaticArrayInitTypeSize_256 // TypeDefIndex: 83614
	{
	}

	private struct __StaticArrayInitTypeSize_512 // TypeDefIndex: 83615
	{
	}

	private struct __StaticArrayInitTypeSize_1024 // TypeDefIndex: 83616
	{
	}

	private struct __StaticArrayInitTypeSize_4096 // TypeDefIndex: 83617
	{
	}
}

namespace Beyond.Rendering
{
	public static class HGShaderQualitySettings // TypeDefIndex: 83213
	{
		// Fields
		public static ShaderQuality HgShaderLod; // 0x00
	
		// Nested types
		public enum ShaderQuality // TypeDefIndex: 83212
		{
			Low = 0,
			High = 1
		}
	
		// Constructors
		static HGShaderQualitySettings(); // 0x000000018D3AFB48-0x000000018D3AFB84
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 83209
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 83210
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine
{
	[AddComponentMenu("Rendering/Light Anchor")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class LightAnchor : MonoBehaviour // TypeDefIndex: 83216
	{
		// Fields
		private const float k_ArcRadius = 5f; // Metadata: 0x02641F55
		private const float k_AxisLength = 10f; // Metadata: 0x02641F59
		internal const float k_MaxDistance = 10000f; // Metadata: 0x02641F5D
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
		public float yaw { get; set; } // 0x000000018723CEF0-0x000000018723CF00 0x000000018D3B100C-0x000000018D3B105C
		public float pitch { get; set; } // 0x0000000187235380-0x0000000187235390 0x000000018D3B0F6C-0x000000018D3B0FBC
		public float roll { get; set; } // 0x00000001872330B0-0x00000001872330C0 0x000000018D3B0FBC-0x000000018D3B100C
		public float distance { get; set; } // 0x0000000187233050-0x0000000187233060 0x000000018D3B0F48-0x000000018D3B0F6C
		public UpDirection frameSpace { get; set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
		public Vector3 anchorPosition { get; } // 0x000000018D3B0DCC-0x000000018D3B0F48 
		public Transform anchorPositionOverride { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public Vector3 anchorPositionOffset { get; set; } // 0x000000018723EAD0-0x000000018723EAF0 0x000000018723EAF0-0x000000018723EB00
	
		// Nested types
		public enum UpDirection // TypeDefIndex: 83214
		{
			World = 0,
			Local = 1
		}
	
		private struct Axes // TypeDefIndex: 83215
		{
			// Fields
			public Vector3 up; // 0x00
			public Vector3 right; // 0x0C
			public Vector3 forward; // 0x18
		}
	
		// Constructors
		public LightAnchor(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public static float NormalizeAngleDegree(float angle); // 0x000000018D3B045C-0x000000018D3B04A4
		public void SynchronizeOnTransform(Camera camera); // 0x000000018D3B056C-0x000000018D3B096C
		public void UpdateTransform(Camera camera, Vector3 anchor); // 0x000000018D3B096C-0x000000018D3B0A4C
		private Axes GetWorldSpaceAxes(Camera camera, Vector3 anchor); // 0x000000018D3AFD18-0x000000018D3B045C
		private void Update(); // 0x000000018D3B0CD0-0x000000018D3B0DCC
		private void OnDrawGizmosSelected(); // 0x000000018D3B04A4-0x000000018D3B056C
		private void UpdateTransform(Vector3 up, Vector3 right, Vector3 forward, Vector3 anchor); // 0x000000018D3B0A4C-0x000000018D3B0CD0
	}
}

namespace UnityEngine.Experimental.Rendering
{
	internal class ProbeBrickIndex // TypeDefIndex: 83224
	{
		// Fields
		internal const int kMaxSubdivisionLevels = 7; // Metadata: 0x02641F63
		internal const int kIndexChunkSize = 243; // Metadata: 0x02641F64
		private BitArray m_IndexChunks; // 0x10
		private int m_IndexInChunks; // 0x18
		private int m_NextFreeChunk; // 0x1C
		private ComputeBuffer m_PhysicalIndexBuffer; // 0x20
		private int[] m_PhysicalIndexBufferData; // 0x28
		[CompilerGenerated]
		private int _estimatedVMemCost_k__BackingField; // 0x30
		private Vector3Int m_CenterRS; // 0x34
		private Dictionary<Vector3Int, List<VoxelMeta>> m_VoxelToBricks; // 0x40
		private Dictionary<ProbeReferenceVolume.RegId, BrickMeta> m_BricksToVoxels; // 0x48
		private bool m_NeedUpdateIndexComputeBuffer; // 0x50
	
		// Properties
		internal int estimatedVMemCost { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
	
		// Nested types
		[Serializable]
		[DebuggerDisplay("Brick [{position}, {subdivisionLevel}]")]
		public struct Brick : IEquatable<Brick> // TypeDefIndex: 83217
		{
			// Fields
			public Vector3Int position; // 0x00
			public int subdivisionLevel; // 0x0C
	
			// Constructors
			internal Brick(Vector3Int position, int subdivisionLevel); // 0x0000000187240BC0-0x0000000187240BE0
	
			// Methods
			public bool Equals(Brick other); // 0x000000018D3AF970-0x000000018D3AF9C4
		}
	
		[DebuggerDisplay("Brick [{brick.position}, {brick.subdivisionLevel}], {flattenedIdx}")]
		private struct ReservedBrick // TypeDefIndex: 83218
		{
			// Fields
			public Brick brick; // 0x00
			public int flattenedIdx; // 0x10
		}
	
		private struct VoxelMeta // TypeDefIndex: 83219
		{
			// Fields
			public ProbeReferenceVolume.RegId id; // 0x00
			public List<ushort> brickIndices; // 0x08
		}
	
		private struct BrickMeta // TypeDefIndex: 83220
		{
			// Fields
			public HashSet<Vector3Int> voxels; // 0x00
			public List<ReservedBrick> bricks; // 0x08
		}
	
		public struct CellIndexUpdateInfo // TypeDefIndex: 83221
		{
			// Fields
			public int firstChunkIndex; // 0x00
			public int numberOfChunks; // 0x04
			public int minSubdivInCell; // 0x08
			public Vector3Int minValidBrickIndexForCellAtMaxRes; // 0x0C
			public Vector3Int maxValidBrickIndexForCellAtMaxResPlusOne; // 0x18
			public Vector3Int cellPositionInBricksAtMaxRes; // 0x24
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 83222
		{
			// Fields
			public ProbeReferenceVolume.RegId id; // 0x10
			public Predicate<VoxelMeta> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass31_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _AddBricks_b__0(VoxelMeta lhs); // 0x0000000182A92250-0x0000000182A92270
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 83223
		{
			// Fields
			public ProbeReferenceVolume.RegId id; // 0x10
			public Predicate<VoxelMeta> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass32_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _RemoveBricks_b__0(VoxelMeta lhs); // 0x0000000182A92250-0x0000000182A92270
		}
	
		// Constructors
		internal ProbeBrickIndex(ProbeVolumeTextureMemoryBudget memoryBudget); // 0x000000018D3B30DC-0x000000018D3B32E0
	
		// Methods
		private int GetVoxelSubdivLevel(); // 0x000000018D3B1F58-0x000000018D3B1FA8
		private int SizeOfPhysicalIndexFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget); // 0x000000018D3B2634-0x000000018D3B2660
		internal void UploadIndexData(); // 0x000000018D3B30AC-0x000000018D3B30DC
		internal void Clear(); // 0x000000018D3B1C80-0x000000018D3B1D30
		private void MapBrickToVoxels(Brick brick, HashSet<Vector3Int> voxels); // 0x000000018D3B1FA8-0x000000018D3B2198
		private void ClearVoxel(Vector3Int pos, CellIndexUpdateInfo cellInfo); // 0x000000018D3B1B78-0x000000018D3B1C80
		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr); // 0x000000018D3B1F20-0x000000018D3B1F58
		internal void Cleanup(); // 0x000000018D3B1B14-0x000000018D3B1B78
		private int MergeIndex(int index, int size); // 0x000000018725DF90-0x000000018725DFB0
		internal bool AssignIndexChunksToCell(ProbeReferenceVolume.Cell cell, int bricksCount, ref CellIndexUpdateInfo cellUpdateInfo); // 0x000000018D3B19F8-0x000000018D3B1B14
		public void AddBricks(ProbeReferenceVolume.RegId id, List<Brick> bricks, List<ProbeBrickPool.BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight, CellIndexUpdateInfo cellInfo); // 0x000000018D3B105C-0x000000018D3B19F8
		public void RemoveBricks(ProbeReferenceVolume.RegId id, CellIndexUpdateInfo cellInfo); // 0x000000018D3B2198-0x000000018D3B2634
		private void UpdateIndexForVoxel(Vector3Int voxel, CellIndexUpdateInfo cellInfo); // 0x000000018D3B2660-0x000000018D3B28D0
		private void UpdatePhysicalIndex(Vector3Int brickMin, Vector3Int brickMax, int value, CellIndexUpdateInfo cellInfo); // 0x000000018D3B2CBC-0x000000018D3B30AC
		private void ClipToIndexSpace(Vector3Int pos, int subdiv, out Vector3Int outMinpos, out Vector3Int outMaxpos, CellIndexUpdateInfo cellInfo); // 0x000000018D3B1D30-0x000000018D3B1F20
		private void UpdateIndexForVoxel(Vector3Int voxel, List<ReservedBrick> bricks, List<ushort> indices, CellIndexUpdateInfo cellInfo); // 0x000000018D3B28D0-0x000000018D3B2CBC
	}

	internal class ProbeBrickPool // TypeDefIndex: 83227
	{
		// Fields
		internal const int kBrickCellCount = 3; // Metadata: 0x02641F66
		internal const int kBrickProbeCountPerDim = 4; // Metadata: 0x02641F67
		internal const int kBrickProbeCountTotal = 64; // Metadata: 0x02641F68
		[CompilerGenerated]
		private int _estimatedVMemCost_k__BackingField; // 0x10
		private const int kMaxPoolWidth = 2048; // Metadata: 0x02641F6A
		private int m_AllocationSize; // 0x14
		private ProbeVolumeTextureMemoryBudget m_MemoryBudget; // 0x18
		private DataLocation m_Pool; // 0x20
		private BrickChunkAlloc m_NextFreeChunk; // 0x68
		private Stack<BrickChunkAlloc> m_FreeList; // 0x78
		private ProbeVolumeSHBands m_SHBands; // 0x80
	
		// Properties
		internal int estimatedVMemCost { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
	
		// Nested types
		[DebuggerDisplay("Chunk ({x}, {y}, {z})")]
		public struct BrickChunkAlloc // TypeDefIndex: 83225
		{
			// Fields
			public int x; // 0x00
			public int y; // 0x04
			public int z; // 0x08
	
			// Methods
			internal int flattenIndex(int sx, int sy); // 0x000000018725DF70-0x000000018725DF90
		}
	
		public struct DataLocation // TypeDefIndex: 83226
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
			internal void Cleanup(); // 0x000000018D3AFA44-0x000000018D3AFB48
		}
	
		// Constructors
		internal ProbeBrickPool(int allocationSize, ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands); // 0x000000018D3B48C0-0x000000018D3B49FC
	
		// Methods
		internal void EnsureTextureValidity(); // 0x000000018D3B3A0C-0x000000018D3B3B04
		internal int GetChunkSize(); // 0x0000000182971EE0-0x0000000182971EF0
		internal int GetChunkSizeInProbeCount(); // 0x000000018725DFD0-0x000000018725DFE0
		internal int GetPoolWidth(); // 0x00000001872331A0-0x00000001872331B0
		internal int GetPoolHeight(); // 0x0000000187233600-0x0000000187233610
		internal Vector3Int GetPoolDimensions(); // 0x000000018725DFE0-0x000000018725E000
		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr); // 0x000000018D3B43DC-0x000000018D3B4464
		internal void Clear(); // 0x000000018D3B3430-0x000000018D3B3484
		internal void Allocate(int numberOfBrickChunks, List<BrickChunkAlloc> outAllocations); // 0x000000018D3B32E0-0x000000018D3B3424
		internal void Deallocate(List<BrickChunkAlloc> allocations); // 0x000000018D3B38B0-0x000000018D3B3A0C
		internal void Update(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, ProbeVolumeSHBands bands); // 0x000000018D3B4508-0x000000018D3B48C0
		private static Vector3Int ProbeCountToDataLocSize(int numProbes); // 0x000000018D3B4464-0x000000018D3B44C4
		public static DataLocation CreateDataLocation(int numProbes, bool compressed, ProbeVolumeSHBands bands, out int allocatedBytes); // 0x000000018D3B3484-0x000000018D3B38B0
		private static void SetPixel(ref UnityEngine.Color[] data, int x, int y, int z, int dataLocWidth, int dataLocHeight, UnityEngine.Color value); // 0x000000018D3B44C4-0x000000018D3B4508
		public static void FillDataLocation(ref DataLocation loc, SphericalHarmonicsL2[] shl2, ProbeVolumeSHBands bands); // 0x000000018D3B3B04-0x000000018D3B43DC
		private void DerivePoolSizeFromBudget(int allocationSize, ProbeVolumeTextureMemoryBudget memoryBudget, out int width, out int height, out int depth); // 0x000000018725DFB0-0x000000018725DFD0
		internal void Cleanup(); // 0x000000018D3B3424-0x000000018D3B3430
	}

	internal class ProbeCellIndices // TypeDefIndex: 83229
	{
		// Fields
		private const int kUintPerEntry = 3; // Metadata: 0x02641F6C
		[CompilerGenerated]
		private int _estimatedVMemCost_k__BackingField; // 0x10
		private ComputeBuffer m_IndexOfIndicesBuffer; // 0x18
		private uint[] m_IndexOfIndicesData; // 0x20
		private Vector3Int m_CellCount; // 0x28
		private Vector3Int m_CellMin; // 0x34
		private int m_CellSizeInMinBricks; // 0x40
		private bool m_NeedUpdateComputeBuffer; // 0x44
	
		// Properties
		internal int estimatedVMemCost { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
	
		// Nested types
		internal struct IndexMetaData // TypeDefIndex: 83228
		{
			// Fields
			internal Vector3Int minLocalIdx; // 0x00
			internal Vector3Int maxLocalIdx; // 0x0C
			internal int firstChunkIndex; // 0x18
			internal int minSubdiv; // 0x1C
	
			// Methods
			internal void Pack(out uint[] vals); // 0x000000018D3AFB84-0x000000018D3AFD18
		}
	
		// Constructors
		internal ProbeCellIndices(Vector3Int cellMin, Vector3Int cellMax, int cellSizeInMinBricks); // 0x000000018D3B4D04-0x000000018D3B4E44
	
		// Methods
		internal Vector3Int GetCellIndexDimension(); // 0x000000018723EAD0-0x000000018723EAF0
		internal Vector3Int GetCellMinPosition(); // 0x0000000187236500-0x0000000187236520
		private int GetFlatIndex(Vector3Int normalizedPos); // 0x000000018725E000-0x000000018725E020
		internal int GetFlatIdxForCell(Vector3Int cellPosition); // 0x000000018D3B4BDC-0x000000018D3B4C40
		internal void AddCell(int cellFlatIdx, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo); // 0x000000018D3B49FC-0x000000018D3B4B78
		internal void MarkCellAsUnloaded(int cellFlatIdx); // 0x000000018D3B4C78-0x000000018D3B4CD4
		internal void PushComputeData(); // 0x000000018D3B4CD4-0x000000018D3B4D04
		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr); // 0x000000018D3B4C40-0x000000018D3B4C78
		internal void Cleanup(); // 0x000000018D3B4B78-0x000000018D3B4BDC
	}

	public struct ProbeVolumeSystemParameters // TypeDefIndex: 83230
	{
		// Fields
		public ProbeVolumeTextureMemoryBudget memoryBudget; // 0x00
		public Mesh probeDebugMesh; // 0x08
		public Shader probeDebugShader; // 0x10
		public ProbeVolumeSceneData sceneData; // 0x18
		public ProbeVolumeSHBands shBands; // 0x20
	}

	public struct ProbeVolumeShadingParameters // TypeDefIndex: 83231
	{
		// Fields
		public float normalBias; // 0x00
		public float viewBias; // 0x04
		public bool scaleBiasByMinDistanceBetweenProbes; // 0x08
		public float samplingNoise; // 0x0C
	}

	[Serializable]
	public enum ProbeVolumeTextureMemoryBudget // TypeDefIndex: 83232
	{
		MemoryBudgetLow = 512,
		MemoryBudgetMedium = 1024,
		MemoryBudgetHigh = 2048
	}

	[Serializable]
	public enum ProbeVolumeSHBands // TypeDefIndex: 83233
	{
		SphericalHarmonicsL1 = 1,
		SphericalHarmonicsL2 = 2
	}

	public class ProbeReferenceVolume // TypeDefIndex: 83245
	{
		// Fields
		private const int kProbeIndexPoolAllocationSize = 128; // Metadata: 0x02641F77
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
		private const int kProbesPerBatch = 1023; // Metadata: 0x02641F79
		[CompilerGenerated]
		private readonly ProbeVolumeDebug _debugDisplay_k__BackingField; // 0x160
		[CompilerGenerated]
		private readonly UnityEngine.Color[] _subdivisionDebugColors_k__BackingField; // 0x168
		private DebugUI.Widget[] m_DebugItems; // 0x170
		private Mesh m_DebugMesh; // 0x178
		private Material m_DebugMaterial; // 0x180
		private List<CellInstancedDebugProbes> m_CellDebugData; // 0x188
		private Plane[] m_DebugFrustumPlanes; // 0x190
		internal float dilationValidtyThreshold; // 0x198
		internal Dictionary<Volume, List<ProbeBrickIndex.Brick>> realtimeSubdivisionInfo; // 0x1A0
	
		// Properties
		internal bool isInitialized { get; } // 0x000000018725E0B0-0x000000018725E0C0 
		internal bool enabledBySRP { get; } // 0x000000018725E0A0-0x000000018725E0B0 
		public ProbeVolumeSHBands shBands { get; } // 0x000000018725E0C0-0x000000018725E0D0 
		public ProbeVolumeTextureMemoryBudget memoryBudget { get; } // 0x00000001872501A0-0x00000001872501B0 
		public static ProbeReferenceVolume instance { get; } // 0x000000018D3BAD10-0x000000018D3BAD44 
		internal ProbeVolumeDebug debugDisplay { [CompilerGenerated] get; } // 0x000000018723BD40-0x000000018723BD50 
		public UnityEngine.Color[] subdivisionDebugColors { [CompilerGenerated] get; } // 0x000000018723C240-0x000000018723C250 
	
		// Nested types
		[Serializable]
		internal class Cell // TypeDefIndex: 83234
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
			public Cell(); // 0x000000018723CE60-0x000000018723CE70
		}
	
		private class CellChunkInfo // TypeDefIndex: 83235
		{
			// Fields
			public List<ProbeBrickPool.BrickChunkAlloc> chunks; // 0x10
	
			// Constructors
			public CellChunkInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private class CellSortInfo : IComparable // TypeDefIndex: 83236
		{
			// Fields
			internal string sourceAsset; // 0x10
			internal Cell cell; // 0x18
			internal float distanceToCamera; // 0x20
			internal Vector3 position; // 0x24
	
			// Constructors
			public CellSortInfo(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public int CompareTo(object obj); // 0x000000018D3AF9C4-0x000000018D3AFA44
		}
	
		internal struct Volume : IEquatable<Volume> // TypeDefIndex: 83237
		{
			// Fields
			internal Vector3 corner; // 0x00
			internal Vector3 X; // 0x0C
			internal Vector3 Y; // 0x18
			internal Vector3 Z; // 0x24
			internal float maxSubdivisionMultiplier; // 0x30
			internal float minSubdivisionMultiplier; // 0x34
	
			// Constructors
			public Volume(Matrix4x4 trs, float maxSubdivision, float minSubdivision); // 0x000000018D3C7118-0x000000018D3C74D8
			public Volume(Vector3 corner, Vector3 X, Vector3 Y, Vector3 Z, float maxSubdivision = 1f /* Metadata: 0x02641F7B */, float minSubdivision = 0f /* Metadata: 0x02641F7F */); // 0x000000018725E180-0x000000018725E1E0
			public Volume(Volume copy); // 0x000000018725E130-0x000000018725E180
	
			// Methods
			public Bounds CalculateAABB(); // 0x000000018D3C6838-0x000000018D3C6B3C
			public void CalculateCenterAndSize(out Vector3 center, out Vector3 size); // 0x000000018D3C6B3C-0x000000018D3C6CBC
			public void Transform(Matrix4x4 trs); // 0x000000018D3C702C-0x000000018D3C7118
			public override string ToString(); // 0x000000018D3C6E60-0x000000018D3C702C
			public bool Equals(Volume other); // 0x000000018D3C6CBC-0x000000018D3C6E60
		}
	
		internal struct RefVolTransform // TypeDefIndex: 83238
		{
			// Fields
			public Matrix4x4 refSpaceToWS; // 0x00
			public Vector3 posWS; // 0x40
			public Quaternion rot; // 0x4C
			public float scale; // 0x5C
		}
	
		public struct RuntimeResources // TypeDefIndex: 83239
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
	
		internal struct RegId // TypeDefIndex: 83240
		{
			// Fields
			internal int id; // 0x00
	
			// Methods
			public bool IsValid(); // 0x00000001889F343C-0x00000001889F3444
			public void Invalidate(); // 0x000000018723EDD0-0x000000018723EDE0
			public static bool operator ==(RegId lhs, RegId rhs); // 0x0000000189CCDE30-0x0000000189CCDE38
			public static bool operator !=(RegId lhs, RegId rhs); // 0x000000018CCE071C-0x000000018CCE0724
			public override bool Equals(object obj); // 0x000000018D3BD940-0x000000018D3BD9EC
			public override int GetHashCode(); // 0x00000001844AD290-0x00000001844AD2A0
		}
	
		public struct ExtraDataActionInput // TypeDefIndex: 83241
		{
		}
	
		private struct InitInfo // TypeDefIndex: 83242
		{
			// Fields
			public Vector3Int pendingMinCellPosition; // 0x00
			public Vector3Int pendingMaxCellPosition; // 0x0C
		}
	
		private class CellInstancedDebugProbes // TypeDefIndex: 83243
		{
			// Fields
			public List<Matrix4x4[]> probeBuffers; // 0x10
			public List<MaterialPropertyBlock> props; // 0x18
			public Hash128 cellHash; // 0x20
			public Vector3 cellPosition; // 0x30
	
			// Constructors
			public CellInstancedDebugProbes(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83244
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<float> __9__119_6; // 0x08
			public static Func<float> __9__119_15; // 0x10
			public static Func<float> __9__119_16; // 0x18
			public static Func<float> __9__119_21; // 0x20
			public static Func<int> __9__119_24; // 0x28
			public static Func<int> __9__119_25; // 0x30
	
			// Constructors
			static __c(); // 0x000000018D3C67D4-0x000000018D3C6838
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _RegisterDebug_b__119_6(); // 0x0000000187234CD0-0x0000000187234CE0
			internal float _RegisterDebug_b__119_15(); // 0x000000018725E120-0x000000018725E130
			internal float _RegisterDebug_b__119_16(); // 0x0000000187257CC0-0x0000000187257CD0
			internal float _RegisterDebug_b__119_21(); // 0x0000000187234CD0-0x0000000187234CE0
			internal int _RegisterDebug_b__119_24(); // 0x0000000185829EC0-0x0000000185829ED0
			internal int _RegisterDebug_b__119_25(); // 0x000000018D3C6720-0x000000018D3C6770
		}
	
		// Constructors
		private ProbeReferenceVolume(); // 0x0000000186BF6250-0x0000000186BF67F0
		static ProbeReferenceVolume(); // 0x0000000186BF61E0-0x0000000186BF6250
	
		// Methods
		private void InvalidateAllCellRefs(); // 0x000000018D3B7DB8-0x000000018D3B7E00
		public void SetNumberOfCellsLoadedPerFrame(int numberOfCells); // 0x000000018D3BA35C-0x000000018D3BA370
		public void Initialize([IsReadOnly] in ProbeVolumeSystemParameters parameters); // 0x000000018D3B7CE0-0x000000018D3B7DB8
		public void SetEnableStateFromSRP(bool srpEnablesPV); // 0x000000018725E090-0x000000018725E0A0
		internal void ForceSHBand(ProbeVolumeSHBands shBands); // 0x000000018D3B712C-0x000000018D3B7184
		public void Cleanup(); // 0x000000018D3B6018-0x000000018D3B6098
		public int GetVideoMemoryCost(); // 0x000000018D3B7850-0x000000018D3B78A0
		private void RemoveCell(Cell cell); // 0x000000018D3B9DA8-0x000000018D3BA010
		private void AddCell(Cell cell, List<ProbeBrickPool.BrickChunkAlloc> chunks); // 0x000000018D3B534C-0x000000018D3B54DC
		private bool CheckCompatibilityWithCollection(ProbeVolumeAsset asset, Dictionary<string, ProbeVolumeAsset> collection); // 0x000000018D3B5DA0-0x000000018D3B5F50
		internal void AddPendingAssetLoading(ProbeVolumeAsset asset); // 0x000000018D3B54DC-0x000000018D3B5C6C
		internal void AddPendingAssetRemoval(ProbeVolumeAsset asset); // 0x000000018D3B5C6C-0x000000018D3B5D2C
		internal void RemovePendingAsset(ProbeVolumeAsset asset); // 0x000000018D3BA010-0x000000018D3BA298
		private void PerformPendingIndexChangeAndInit(); // 0x000000018D3B8688-0x000000018D3B86E4
		internal void SetMinBrickAndMaxSubdiv(float minBrickSize, int maxSubdiv); // 0x000000018D3BA2E8-0x000000018D3BA35C
		private void LoadAsset(ProbeVolumeAsset asset); // 0x000000018D3B7E00-0x000000018D3B8068
		private void PerformPendingLoading(); // 0x000000018D3B86E4-0x000000018D3B8A58
		private void PerformPendingDeletion(); // 0x000000018D3B84DC-0x000000018D3B8688
		private int GetNumberOfBricksAtSubdiv(Cell cell, out Vector3Int minValidLocalIdxAtMaxRes, out Vector3Int sizeOfValidIndicesAtMaxRes); // 0x000000018D3B733C-0x000000018D3B7788
		private bool GetCellIndexUpdate(Cell cell, out ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo); // 0x000000018D3B7184-0x000000018D3B730C
		private void LoadPendingCells(bool loadAll = false /* Metadata: 0x02641F75 */); // 0x000000018D3B8068-0x000000018D3B84C0
		public void PerformPendingOperations(bool loadAllCells = false /* Metadata: 0x02641F76 */); // 0x000000018D3B8A58-0x000000018D3B8A9C
		private void InitProbeReferenceVolume(int allocationSize, ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands); // 0x000000018D3B78A0-0x000000018D3B7B10
		public void SortPendingCells(Vector3 cameraPosition); // 0x000000018D3BA694-0x000000018D3BA7B4
		public RuntimeResources GetRuntimeResources(); // 0x000000018D3B7788-0x000000018D3B7850
		internal void SetTRS(Vector3 position, Quaternion rotation, float minBrickSize); // 0x000000018D3BA370-0x000000018D3BA440
		internal void SetMaxSubdivision(int maxSubdivision); // 0x000000018D3BA298-0x000000018D3BA2E8
		internal static int CellSize(int subdivisionLevel); // 0x000000018725E060-0x000000018725E090
		internal float BrickSize(int subdivisionLevel); // 0x000000018D3B5D2C-0x000000018D3B5DA0
		internal float MinBrickSize(); // 0x0000000187253CF0-0x0000000187253D00
		internal float MaxBrickSize(); // 0x000000018D3B84C0-0x000000018D3B84D0
		internal Matrix4x4 GetRefSpaceToWS(); // 0x00000001872459D0-0x0000000187245A00
		internal RefVolTransform GetTransform(); // 0x0000000187244F20-0x0000000187244F60
		internal int GetMaxSubdivision(); // 0x0000000187233090-0x00000001872330A0
		internal int GetMaxSubdivision(float multiplier); // 0x000000018D3B7328-0x000000018D3B733C
		internal float GetDistanceBetweenProbes(int subdivisionLevel); // 0x000000018D3B730C-0x000000018D3B7328
		internal float MinDistanceBetweenProbes(); // 0x000000018D3B84D0-0x000000018D3B84DC
		public bool DataHasBeenLoaded(); // 0x000000018299E130-0x000000018299E140
		internal void Clear(); // 0x000000018D3B6104-0x000000018D3B61EC
		private RegId AddBricks(List<ProbeBrickIndex.Brick> bricks, ProbeBrickPool.DataLocation dataloc, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, out List<ProbeBrickPool.BrickChunkAlloc> ch_list); // 0x000000018D3B4FD4-0x000000018D3B534C
		private void ReleaseBricks(RegId id); // 0x000000018D3B9BF0-0x000000018D3B9DA8
		public void UpdateConstantBuffer(CommandBuffer cmd, ProbeVolumeShadingParameters parameters); // 0x000000018D3BAB0C-0x000000018D3BAD10
		private void CleanupLoadedData(); // 0x000000018D3B5FA4-0x000000018D3B6018
		public void RenderDebug(Camera camera); // 0x00000001850A3870-0x00000001850A38E0
		private void InitializeDebug(Mesh debugProbeMesh, Shader debugProbeShader); // 0x000000018D3B7B10-0x000000018D3B7CE0
		private void CleanupDebug(); // 0x000000018D3B5F50-0x000000018D3B5FA4
		private void RefreshDebug<T>(DebugUI.Field<T> field, T value);
		private void DebugCellIndexChanged<T>(DebugUI.Field<T> field, T value);
		private void RegisterDebug(); // 0x000000018D3B8A9C-0x000000018D3B9BF0
		private void UnregisterDebug(bool destroyPanel); // 0x000000018D3BAA40-0x000000018D3BAB0C
		private bool ShouldCullCell(Vector3 cellPosition, Transform cameraTransform, Plane[] frustumPlanes); // 0x000000018D3BA440-0x000000018D3BA694
		private void DrawProbeDebug(Camera camera); // 0x000000018D3B6BDC-0x000000018D3B712C
		private void ClearDebugData(); // 0x000000018D3B6098-0x000000018D3B6104
		private void CreateInstancedProbes(); // 0x000000018D3B61EC-0x000000018D3B6BDC
		private void OnClearLightingdata(); // 0x0000000189C54AB0-0x0000000189C54AB8
		[CompilerGenerated]
		private bool _RegisterDebug_b__119_0(); // 0x000000018D3BA7B4-0x000000018D3BA7D4
		[CompilerGenerated]
		private void _RegisterDebug_b__119_1(bool value); // 0x000000018D3BA8B4-0x000000018D3BA8D4
		[CompilerGenerated]
		private bool _RegisterDebug_b__119_2(); // 0x000000018D3BA980-0x000000018D3BA9A0
		[CompilerGenerated]
		private void _RegisterDebug_b__119_3(bool value); // 0x000000018D3BA9A0-0x000000018D3BA9C0
		[CompilerGenerated]
		private float _RegisterDebug_b__119_4(); // 0x000000018D3BA9C0-0x000000018D3BA9E0
		[CompilerGenerated]
		private void _RegisterDebug_b__119_5(float value); // 0x000000018D3BA9E0-0x000000018D3BAA00
		[CompilerGenerated]
		private bool _RegisterDebug_b__119_7(); // 0x000000018D3BAA00-0x000000018D3BAA20
		[CompilerGenerated]
		private void _RegisterDebug_b__119_8(bool value); // 0x000000018D3BAA20-0x000000018D3BAA40
		[CompilerGenerated]
		private int _RegisterDebug_b__119_9(); // 0x000000018D3BA7F4-0x000000018D3BA814
		[CompilerGenerated]
		private void _RegisterDebug_b__119_10(int value); // 0x000000018D3BA7D4-0x000000018D3BA7F4
		[CompilerGenerated]
		private int _RegisterDebug_b__119_11(); // 0x000000018D3BA7F4-0x000000018D3BA814
		[CompilerGenerated]
		private void _RegisterDebug_b__119_12(int value); // 0x000000018D3BA7D4-0x000000018D3BA7F4
		[CompilerGenerated]
		private float _RegisterDebug_b__119_13(); // 0x000000018D3BA814-0x000000018D3BA834
		[CompilerGenerated]
		private void _RegisterDebug_b__119_14(float value); // 0x000000018D3BA834-0x000000018D3BA854
		[CompilerGenerated]
		private float _RegisterDebug_b__119_17(); // 0x000000018D3BA854-0x000000018D3BA874
		[CompilerGenerated]
		private void _RegisterDebug_b__119_18(float value); // 0x000000018D3BA874-0x000000018D3BA894
		[CompilerGenerated]
		private float _RegisterDebug_b__119_19(); // 0x000000018D3BA894-0x000000018D3BA8B4
		[CompilerGenerated]
		private void _RegisterDebug_b__119_20(float value); // 0x000000018D3BA8D4-0x000000018D3BA8F4
		[CompilerGenerated]
		private int _RegisterDebug_b__119_22(); // 0x000000018D3BA8F4-0x000000018D3BA914
		[CompilerGenerated]
		private void _RegisterDebug_b__119_23(int v); // 0x000000018D3BA914-0x000000018D3BA980
	}

	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "F:\\Build\\Release_v1d6\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\Lighting\\ProbeVolume\\ProbeReferenceVolume.Debug.cs")]
	public enum DebugProbeShadingMode // TypeDefIndex: 83246
	{
		SH = 0,
		Validity = 1,
		ValidityOverDilationThreshold = 2,
		Size = 3
	}

	internal class ProbeVolumeDebug // TypeDefIndex: 83247
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
		public ProbeVolumeDebug(); // 0x000000018725E0E0-0x000000018725E110
	}

	public sealed class ProbeReferenceVolumeProfile : ScriptableObject // TypeDefIndex: 83249
	{
		// Fields
		[SerializeField]
		private Version version; // 0x18
		[Range(2f, 5f)]
		public int simplificationLevels; // 0x1C
		[Min(0.1f)]
		public float minDistanceBetweenProbes; // 0x20
	
		// Properties
		public int cellSizeInBricks { get; } // 0x000000018725E020-0x000000018725E050 
		public int maxSubdivision { get; } // 0x000000018725E050-0x000000018725E060 
		public float minBrickSize { get; } // 0x000000018D3B4FB8-0x000000018D3B4FD4 
		public float cellSizeInMeters { get; } // 0x000000018D3B4F6C-0x000000018D3B4FB8 
	
		// Nested types
		internal enum Version // TypeDefIndex: 83248
		{
			Initial = 0
		}
	
		// Constructors
		public ProbeReferenceVolumeProfile(); // 0x000000018D3B4F00-0x000000018D3B4F6C
	
		// Methods
		private void OnEnable(); // 0x000000018D3B4EAC-0x000000018D3B4F00
		public bool IsEquivalent(ProbeReferenceVolumeProfile otherProfile); // 0x000000018D3B4E44-0x000000018D3B4EAC
	}

	[AddComponentMenu("Light/Probe Volume (Experimental)")]
	[ExecuteAlways]
	public class ProbeVolume : MonoBehaviour // TypeDefIndex: 83250
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
		public ProbeVolume(); // 0x000000018D3BD8FC-0x000000018D3BD940
	}

	[PreferBinarySerialization]
	internal class ProbeVolumeAsset : ScriptableObject // TypeDefIndex: 83252
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
		public int Version { get; } // 0x00000001844AF510-0x00000001844AF520 
		internal int maxSubdivision { get; } // 0x000000018725E0D0-0x000000018725E0E0 
		internal float minBrickSize { get; } // 0x000000018D3BAE4C-0x000000018D3BAE68 
	
		// Nested types
		[Serializable]
		internal enum AssetVersion // TypeDefIndex: 83251
		{
			First = 0,
			AddProbeVolumesAtlasEncodingModes = 1,
			PV2 = 2,
			ChunkBasedIndex = 3,
			Current = 3,
			Max = 4
		}
	
		// Constructors
		public ProbeVolumeAsset(); // 0x000000018D3BADA4-0x000000018D3BAE4C
	
		// Methods
		internal bool CompatibleWith(ProbeVolumeAsset otherAsset); // 0x000000018D3BAD44-0x000000018D3BADA4
		public string GetSerializedFullPath(); // 0x0000000187232FA0-0x0000000187232FB0
	}

	[Serializable]
	internal struct ProbeDilationSettings // TypeDefIndex: 83253
	{
		// Fields
		public bool enableDilation; // 0x00
		public float dilationDistance; // 0x04
		public float dilationValidityThreshold; // 0x08
		public int dilationIterations; // 0x0C
		public bool squaredDistWeighting; // 0x10
	}

	[Serializable]
	internal struct VirtualOffsetSettings // TypeDefIndex: 83254
	{
		// Fields
		public bool useVirtualOffset; // 0x00
		public float outOfGeoOffset; // 0x04
		public float searchMultiplier; // 0x08
	}

	[Serializable]
	internal struct ProbeVolumeBakingProcessSettings // TypeDefIndex: 83255
	{
		// Fields
		public ProbeDilationSettings dilationSettings; // 0x00
		public VirtualOffsetSettings virtualOffsetSettings; // 0x14
	}

	internal enum ProbeVolumeState // TypeDefIndex: 83256
	{
		Default = 0,
		Invalid = 999
	}

	[AddComponentMenu("")]
	[ExecuteAlways]
	internal class ProbeVolumePerSceneData : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 83258
	{
		// Fields
		internal Dictionary<ProbeVolumeState, ProbeVolumeAsset> assets; // 0x18
		[SerializeField]
		private List<SerializableAssetItem> serializedAssets; // 0x20
		private ProbeVolumeState m_CurrentState; // 0x28
		private ProbeVolumeState m_PreviousState; // 0x2C
	
		// Nested types
		[Serializable]
		private struct SerializableAssetItem // TypeDefIndex: 83257
		{
			// Fields
			[SerializeField]
			public ProbeVolumeState state; // 0x00
			[SerializeField]
			public ProbeVolumeAsset asset; // 0x08
		}
	
		// Constructors
		public ProbeVolumePerSceneData(); // 0x000000018D3BB820-0x000000018D3BB8A8
	
		// Methods
		public void OnAfterDeserialize(); // 0x000000018D3BB0B4-0x000000018D3BB258
		public void OnBeforeSerialize(); // 0x000000018D3BB258-0x000000018D3BB498
		internal void StoreAssetForState(ProbeVolumeState state, ProbeVolumeAsset asset); // 0x000000018D3BB6A8-0x000000018D3BB70C
		internal void InvalidateAllAssets(); // 0x000000018D3BAEE0-0x000000018D3BB0B4
		internal ProbeVolumeAsset GetCurrentStateAsset(); // 0x000000018D3BAE68-0x000000018D3BAEE0
		internal void QueueAssetLoading(); // 0x000000018D3BB4A8-0x000000018D3BB5B0
		internal void QueueAssetRemoval(); // 0x000000018D3BB5B0-0x000000018D3BB6A8
		private void OnEnable(); // 0x000000018D3BB4A0-0x000000018D3BB4A8
		private void OnDisable(); // 0x000000018D3BB498-0x000000018D3BB4A0
		private void OnDestroy(); // 0x000000018D3BB498-0x000000018D3BB4A0
		private void Update(); // 0x000000018D3BB70C-0x000000018D3BB820
	}

	[Serializable]
	public class ProbeVolumeSceneData : ISerializationCallbackReceiver // TypeDefIndex: 83265
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
		private struct SerializableBoundItem // TypeDefIndex: 83259
		{
			// Fields
			[SerializeField]
			public string sceneGUID; // 0x00
			[SerializeField]
			public Bounds bounds; // 0x08
		}
	
		[Serializable]
		private struct SerializableHasPVItem // TypeDefIndex: 83260
		{
			// Fields
			[SerializeField]
			public string sceneGUID; // 0x00
			[SerializeField]
			public bool hasProbeVolumes; // 0x08
		}
	
		[Serializable]
		private struct SerializablePVProfile // TypeDefIndex: 83261
		{
			// Fields
			[SerializeField]
			public string sceneGUID; // 0x00
			[SerializeField]
			public ProbeReferenceVolumeProfile profile; // 0x08
		}
	
		[Serializable]
		private struct SerializablePVBakeSettings // TypeDefIndex: 83262
		{
			// Fields
			[SerializeField]
			public string sceneGUID; // 0x00
			[SerializeField]
			public ProbeVolumeBakingProcessSettings settings; // 0x08
		}
	
		[Serializable]
		internal class BakingSet // TypeDefIndex: 83263
		{
			// Fields
			public string name; // 0x10
			public List<string> sceneGUIDs; // 0x18
			public ProbeVolumeBakingProcessSettings settings; // 0x20
			public ProbeReferenceVolumeProfile profile; // 0x40
	
			// Constructors
			public BakingSet(); // 0x000000018D3AF8F8-0x000000018D3AF970
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83264
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<SerializablePVProfile, string> __9__22_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D3C6770-0x000000018D3C67D4
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _UpdateBakingSets_b__22_0(SerializablePVProfile s); // 0x00000001841B1140-0x00000001841B1150
		}
	
		// Constructors
		public ProbeVolumeSceneData(UnityEngine.Object parentAsset, string parentSceneDataPropertyName); // 0x000000018D3BD5F0-0x000000018D3BD8FC
		static ProbeVolumeSceneData(); // 0x000000018D3BD540-0x000000018D3BD5F0
	
		// Methods
		private string GetSceneGUID(Scene scene); // 0x000000018D3BB948-0x000000018D3BBA0C
		public void SetParentObject(UnityEngine.Object parent, string parentSceneDataPropertyName); // 0x000000018D3BCEE8-0x000000018D3BCF1C
		public void OnAfterDeserialize(); // 0x000000018D3BBAE8-0x000000018D3BC36C
		private void UpdateBakingSets(); // 0x000000018D3BD1D0-0x000000018D3BD540
		public void OnBeforeSerialize(); // 0x000000018D3BC36C-0x000000018D3BCEE8
		internal BakingSet CreateNewBakingSet(string name); // 0x000000018D3BB8A8-0x000000018D3BB948
		private void InitializeBakingSet(BakingSet set, string name); // 0x000000018D3BBA0C-0x000000018D3BBAE8
		internal void SyncBakingSetSettings(); // 0x000000018D3BCF1C-0x000000018D3BD1D0
	}

	[Obsolete("Use the updated RendererList API which is defined in the UnityEngine.Rendering.RendererUtils namespace.")]
	public struct RendererList // TypeDefIndex: 83266
	{
		// Fields
		private static readonly ShaderTagId s_EmptyName; // 0x00
		public static readonly RendererList nullRendererList; // 0x08
		[CompilerGenerated]
		private bool _isValid_k__BackingField; // 0x00
		public CullingResults cullingResult; // 0x08
		public DrawingSettings drawSettings; // 0x18
		public FilteringSettings filteringSettings; // 0x164
		public RenderStateBlock? stateBlock; // 0x184
	
		// Properties
		public bool isValid { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AD2A0-0x00000001844AD2B0 0x0000000187233BE0-0x0000000187233BF0
	
		// Constructors
		static RendererList(); // 0x000000018D3C63A4-0x000000018D3C6424
	
		// Methods
		public static RendererList Create([IsReadOnly] in UnityEngine.Experimental.Rendering.RendererListDesc desc); // 0x000000018D3C5DF8-0x000000018D3C63A4
	}

	[Obsolete("Use the updated RendererList API which is defined in the UnityEngine.Rendering.RendererUtils namespace.")]
	public struct RendererListDesc // TypeDefIndex: 83267
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
		[CompilerGenerated]
		private CullingResults _cullingResult_k__BackingField; // 0x98
		[CompilerGenerated]
		private Camera _camera_k__BackingField; // 0xA8
		[CompilerGenerated]
		private ShaderTagId _passName_k__BackingField; // 0xB0
		[CompilerGenerated]
		private ShaderTagId[] _passNames_k__BackingField; // 0xB8
	
		// Properties
		internal CullingResults cullingResult { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723C570-0x000000018723C580 0x000000018725E110-0x000000018725E120
		internal Camera camera { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232FB0-0x0000000187232FC0 0x0000000185017110-0x0000000185017130
		internal ShaderTagId passName { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723DAC0-0x000000018723DAD0 0x000000018723DB00-0x000000018723DB10
		internal ShaderTagId[] passNames { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232C80-0x0000000187232C90 0x0000000188D80C28-0x0000000188D80C3C
	
		// Constructors
		public RendererListDesc(ShaderTagId passName, CullingResults cullingResult, Camera camera); // 0x000000018D3C5D70-0x000000018D3C5DF8
		public RendererListDesc(ShaderTagId[] passNames, CullingResults cullingResult, Camera camera); // 0x000000018D3C5CB4-0x000000018D3C5D70
	
		// Methods
		public bool IsValid(); // 0x000000018D3C5C14-0x000000018D3C5CB4
	}
}

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	[Flags]
	public enum DepthAccess // TypeDefIndex: 83268
	{
		Read = 1,
		Write = 2,
		ReadWrite = 3
	}

	public class RenderGraphContext // TypeDefIndex: 83269
	{
		// Fields
		public ScriptableRenderContext renderContext; // 0x10
		public CommandBuffer cmd; // 0x18
		public RenderGraphObjectPool renderGraphPool; // 0x20
		public RenderGraphDefaultResources defaultResources; // 0x28
	
		// Constructors
		public RenderGraphContext(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public struct RenderGraphParameters // TypeDefIndex: 83270
	{
		// Fields
		public string executionName; // 0x00
		public int currentFrameIndex; // 0x08
		public bool rendererListCulling; // 0x0C
		public ScriptableRenderContext scriptableRenderContext; // 0x10
		public CommandBuffer commandBuffer; // 0x18
	}

	public struct RenderGraphExecution : IDisposable // TypeDefIndex: 83271
	{
		// Fields
		private RenderGraph renderGraph; // 0x00
	
		// Constructors
		internal RenderGraphExecution(RenderGraph renderGraph); // 0x00000001878380EC-0x00000001878380F4
	
		// Methods
		public void Dispose(); // 0x000000018D3BE46C-0x000000018D3BE48C
	}

	internal class RenderGraphDebugParams // TypeDefIndex: 83273
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
		private static class Strings // TypeDefIndex: 83272
		{
			// Fields
			public static readonly DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtCreation; // 0x00
			public static readonly DebugUI.Widget.NameAndTooltip DisablePassCulling; // 0x10
			public static readonly DebugUI.Widget.NameAndTooltip ImmediateMode; // 0x20
			public static readonly DebugUI.Widget.NameAndTooltip EnableLogging; // 0x30
			public static readonly DebugUI.Widget.NameAndTooltip LogFrameInformation; // 0x40
			public static readonly DebugUI.Widget.NameAndTooltip LogResources; // 0x50
	
			// Constructors
			static Strings(); // 0x000000018D3C6430-0x000000018D3C6720
		}
	
		// Constructors
		public RenderGraphDebugParams(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void RegisterDebug(string name, DebugUI.Panel debugPanel = null); // 0x000000018D3BDBE0-0x000000018D3BE340
		public void UnRegisterDebug(string name); // 0x000000018D3BE3F8-0x000000018D3BE46C
		[CompilerGenerated]
		private bool _RegisterDebug_b__10_0(); // 0x0000000182246E50-0x0000000182246E60
		[CompilerGenerated]
		private void _RegisterDebug_b__10_1(bool value); // 0x0000000182246E60-0x0000000182246E70
		[CompilerGenerated]
		private bool _RegisterDebug_b__10_2(); // 0x000000018226EDE0-0x000000018226EDF0
		[CompilerGenerated]
		private void _RegisterDebug_b__10_3(bool value); // 0x000000018226EDF0-0x000000018226EE00
		[CompilerGenerated]
		private bool _RegisterDebug_b__10_4(); // 0x000000018226EE40-0x000000018226EE50
		[CompilerGenerated]
		private void _RegisterDebug_b__10_5(bool value); // 0x000000018226EE50-0x000000018226EE60
		[CompilerGenerated]
		private bool _RegisterDebug_b__10_6(); // 0x000000018223FE80-0x000000018223FE90
		[CompilerGenerated]
		private void _RegisterDebug_b__10_7(bool value); // 0x000000018223FE90-0x000000018223FEA0
		[CompilerGenerated]
		private void _RegisterDebug_b__10_8(); // 0x000000018D3BE340-0x000000018D3BE39C
		[CompilerGenerated]
		private void _RegisterDebug_b__10_9(); // 0x000000018D3BE39C-0x000000018D3BE3F8
	}

	public delegate void RenderFunc<PassData>(PassData data, RenderGraphContext renderGraphContext); // TypeDefIndex: 83274; 0x00000000-0x00000000

	internal class RenderGraphDebugData // TypeDefIndex: 83277
	{
		// Fields
		public List<PassDebugData> passList; // 0x10
		public List<ResourceDebugData>[] resourceLists; // 0x18
	
		// Nested types
		[DebuggerDisplay("PassDebug: {name}")]
		public struct PassDebugData // TypeDefIndex: 83275
		{
			// Fields
			public string name; // 0x00
			public List<int>[] resourceReadLists; // 0x08
			public List<int>[] resourceWriteLists; // 0x10
			public bool culled; // 0x18
			public bool generateDebugData; // 0x19
		}
	
		[DebuggerDisplay("ResourceDebug: {name} [{creationPassIndex}:{releasePassIndex}]")]
		public struct ResourceDebugData // TypeDefIndex: 83276
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
		public RenderGraphDebugData(); // 0x000000018D3BDB40-0x000000018D3BDBE0
	
		// Methods
		public void Clear(); // 0x000000018D3BD9EC-0x000000018D3BDB40
	}

	public class RenderGraph // TypeDefIndex: 83284
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
		[CompilerGenerated]
		private string _name_k__BackingField; // 0xB8
		[CompilerGenerated]
		private static bool _requireDebugData_k__BackingField; // 0x10
		[CompilerGenerated]
		private static OnGraphRegisteredDelegate onGraphRegistered; // 0x18
		[CompilerGenerated]
		private static OnGraphRegisteredDelegate onGraphUnregistered; // 0x20
		[CompilerGenerated]
		private static OnExecutionRegisteredDelegate onExecutionRegistered; // 0x28
		[CompilerGenerated]
		private static OnExecutionRegisteredDelegate onExecutionUnregistered; // 0x30
	
		// Properties
		public string name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232C80-0x0000000187232C90 0x0000000188D80C28-0x0000000188D80C3C
		internal static bool requireDebugData { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D3C5820-0x000000018D3C5870 0x000000018D3C5BC0-0x000000018D3C5C14
		public RenderGraphDefaultResources defaultResources { get; } // 0x000000018226EEA0-0x000000018226EEB0 
	
		// Events
		internal static event OnGraphRegisteredDelegate onGraphRegistered {
			add; // 0x000000018D3C5678-0x000000018D3C574C
			remove; // 0x000000018D3C5A18-0x000000018D3C5AEC
		}
		internal static event OnGraphRegisteredDelegate onGraphUnregistered {
			add; // 0x000000018D3C574C-0x000000018D3C5820
			remove; // 0x000000018D3C5AEC-0x000000018D3C5BC0
		}
		internal static event OnExecutionRegisteredDelegate onExecutionRegistered {
			add; // 0x000000018D3C54D0-0x000000018D3C55A4
			remove; // 0x000000018D3C5870-0x000000018D3C5944
		}
		internal static event OnExecutionRegisteredDelegate onExecutionUnregistered {
			add; // 0x000000018D3C55A4-0x000000018D3C5678
			remove; // 0x000000018D3C5944-0x000000018D3C5A18
		}
	
		// Nested types
		internal struct CompiledResourceInfo // TypeDefIndex: 83278
		{
			// Fields
			public List<int> producers; // 0x00
			public List<int> consumers; // 0x08
			public int refCount; // 0x10
			public bool imported; // 0x14
	
			// Methods
			public void Reset(); // 0x000000018D3C81CC-0x000000018D3C82C0
		}
	
		[DebuggerDisplay("RenderPass: {pass.name} (Index:{pass.index} Async:{enableAsyncCompute})")]
		internal struct CompiledPassInfo // TypeDefIndex: 83279
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
			public bool allowPassCulling { get; } // 0x000000018D3C81B0-0x000000018D3C81CC 
	
			// Methods
			public void Reset(RenderGraphPass pass); // 0x000000018D3C7FB4-0x000000018D3C81B0
		}
	
		private class ProfilingScopePassData // TypeDefIndex: 83280
		{
			// Fields
			public ProfilingSampler sampler; // 0x10
	
			// Constructors
			public ProfilingScopePassData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		internal delegate void OnGraphRegisteredDelegate(RenderGraph graph); // TypeDefIndex: 83281; 0x0000000185B78EA0-0x0000000185B78EB0
	
		internal delegate void OnExecutionRegisteredDelegate(RenderGraph graph, string executionName); // TypeDefIndex: 83282; 0x00000001859B7730-0x00000001859B7740
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83283
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static RenderFunc<ProfilingScopePassData> __9__61_0; // 0x08
			public static RenderFunc<ProfilingScopePassData> __9__62_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D3D84F4-0x000000018D3D8558
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _BeginProfilingSampler_b__61_0(ProfilingScopePassData data, RenderGraphContext ctx); // 0x000000018BF9BE90-0x000000018BF9BEC0
			internal void _EndProfilingSampler_b__62_0(ProfilingScopePassData data, RenderGraphContext ctx); // 0x000000018BF9BEC0-0x000000018BF9BEF0
		}
	
		// Constructors
		public RenderGraph(string name = "RenderGraph" /* Metadata: 0x02641F94 */); // 0x000000018D3C4FB8-0x000000018D3C54D0
		static RenderGraph(); // 0x000000018D3C4F00-0x000000018D3C4FB8
	
		// Methods
		public void Cleanup(); // 0x000000018D3BEACC-0x000000018D3BEB98
		public void RegisterDebug(DebugUI.Panel panel = null); // 0x000000018D3C3FB0-0x000000018D3C3FE0
		public void UnRegisterDebug(); // 0x000000018D3C4310-0x000000018D3C433C
		public static List<RenderGraph> GetRegisteredRenderGraphs(); // 0x000000018D3C271C-0x000000018D3C276C
		internal RenderGraphDebugData GetDebugData(string executionName); // 0x000000018D3C2204-0x000000018D3C2274
		public void EndFrame(); // 0x000000018D3C079C-0x000000018D3C085C
		public TextureHandle ImportTexture(RTHandle rt); // 0x000000018D3C284C-0x000000018D3C2880
		public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt); // 0x000000018D3C27D0-0x000000018D3C282C
		public TextureHandle CreateTexture([IsReadOnly] in TextureDesc desc); // 0x000000018D3C0018-0x000000018D3C0058
		public TextureHandle CreateSharedTexture([IsReadOnly] in TextureDesc desc, bool explicitRelease = false /* Metadata: 0x02641FA0 */); // 0x000000018D3BFEF4-0x000000018D3BFF88
		public void ReleaseSharedTexture(TextureHandle texture); // 0x000000018D3C4184-0x000000018D3C420C
		public TextureHandle CreateTexture(TextureHandle texture); // 0x000000018D3C0058-0x000000018D3C0100
		public void CreateTextureIfInvalid([IsReadOnly] in TextureDesc desc, ref TextureHandle texture); // 0x000000018D3BFF88-0x000000018D3C0018
		public TextureDesc GetTextureDesc(TextureHandle texture); // 0x000000018D3C276C-0x000000018D3C27D0
		public RendererListHandle CreateRendererList([IsReadOnly] in UnityEngine.Rendering.RendererUtils.RendererListDesc desc); // 0x000000018D3BFE04-0x000000018D3BFE24
		public ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer); // 0x000000018D3C282C-0x000000018D3C284C
		public ComputeBufferHandle CreateComputeBuffer([IsReadOnly] in ComputeBufferDesc desc); // 0x000000018D3BFDDC-0x000000018D3BFE04
		public ComputeBufferHandle CreateComputeBuffer([IsReadOnly] in ComputeBufferHandle computeBuffer); // 0x000000018D3BFD84-0x000000018D3BFDDC
		public ComputeBufferDesc GetComputeBufferDesc([IsReadOnly] in ComputeBufferHandle computeBuffer); // 0x000000018D3C21C4-0x000000018D3C2204
		public RenderGraphBuilder AddRenderPass<PassData>(string passName, out ref PassData passData, ProfilingSampler sampler)
			where PassData : class, new();
		public RenderGraphBuilder AddRenderPass<PassData>(string passName, out ref PassData passData)
			where PassData : class, new();
		public RenderGraphExecution RecordAndExecute([IsReadOnly] in RenderGraphParameters parameters); // 0x000000018D3C3CF4-0x000000018D3C3FB0
		internal void Execute(); // 0x000000018D3C0FB4-0x000000018D3C11E0
		public void BeginProfilingSampler(ProfilingSampler sampler); // 0x000000018D3BE664-0x000000018D3BE900
		public void EndProfilingSampler(ProfilingSampler sampler); // 0x000000018D3C085C-0x000000018D3C0AF8
		internal DynamicArray<CompiledPassInfo> GetCompiledPassInfos(); // 0x00000001828D49D0-0x00000001828D49E0
		internal void ClearCompiledGraph(); // 0x000000018D3BEB98-0x000000018D3BEC78
		private void InvalidateContext(); // 0x000000018D3C2A94-0x000000018D3C2AEC
		internal void OnPassAdded(RenderGraphPass pass); // 0x000000018D3C32D4-0x000000018D3C3300
		private void InitResourceInfosData(DynamicArray<CompiledResourceInfo> resourceInfos, int count); // 0x000000018D3C2880-0x000000018D3C2920
		private void InitializeCompilationData(); // 0x000000018D3C2920-0x000000018D3C2A94
		private void CountReferences(); // 0x000000018D3BF700-0x000000018D3BFD84
		private void CullUnusedPasses(); // 0x000000018D3C01F8-0x000000018D3C079C
		private void UpdatePassSynchronization(ref CompiledPassInfo currentPassInfo, ref CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex); // 0x000000018D3C44C0-0x000000018D3C44E0
		private void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, [IsReadOnly] in CompiledResourceInfo resource); // 0x000000018D3C4DE0-0x000000018D3C4F00
		private int GetLatestProducerIndex(int passIndex, [IsReadOnly] in CompiledResourceInfo info); // 0x000000018D3C2434-0x000000018D3C257C
		private int GetLatestValidReadIndex([IsReadOnly] in CompiledResourceInfo info); // 0x000000018D3C257C-0x000000018D3C264C
		private int GetFirstValidWriteIndex([IsReadOnly] in CompiledResourceInfo info); // 0x000000018D3C2364-0x000000018D3C2434
		private int GetLatestValidWriteIndex([IsReadOnly] in CompiledResourceInfo info); // 0x000000018D3C264C-0x000000018D3C271C
		private void CreateRendererLists(); // 0x000000018D3BFE24-0x000000018D3BFEF4
		private void UpdateResourceAllocationAndSynchronization(); // 0x000000018D3C44E0-0x000000018D3C4DE0
		private bool AreRendererListsEmpty(List<RendererListHandle> rendererLists); // 0x000000018D3BE48C-0x000000018D3BE664
		private void TryCullPassAtIndex(int passIndex); // 0x000000018D3C420C-0x000000018D3C4310
		private void CullRendererLists(); // 0x000000018D3C0100-0x000000018D3C01F8
		internal void CompileRenderGraph(); // 0x000000018D3BF604-0x000000018D3BF700
		private ref CompiledPassInfo CompilePassImmediatly(RenderGraphPass pass); // 0x000000018D3BEE00-0x000000018D3BF604
		private void ExecutePassImmediatly(RenderGraphPass pass); // 0x000000018D3C0E80-0x000000018D3C0EAC
		private void ExecuteCompiledPass(ref CompiledPassInfo passInfo, int passIndex); // 0x000000018D3C0AF8-0x000000018D3C0E80
		private void ExecuteRenderGraph(); // 0x000000018D3C0EAC-0x000000018D3C0FB4
		private void PreRenderPassSetRenderTargets([IsReadOnly] in CompiledPassInfo passInfo, RenderGraphContext rgContext); // 0x000000018D3C38F0-0x000000018D3C3CF4
		private void PreRenderPassExecute([IsReadOnly] in CompiledPassInfo passInfo, RenderGraphContext rgContext); // 0x000000018D3C35A8-0x000000018D3C38F0
		private void PostRenderPassExecute(ref CompiledPassInfo passInfo, RenderGraphContext rgContext); // 0x000000018D3C3300-0x000000018D3C35A8
		private void ClearRenderPasses(); // 0x000000018D3BEC78-0x000000018D3BEE00
		private void ReleaseImmediateModeResources(); // 0x000000018D3C3FE0-0x000000018D3C4184
		private void LogFrameInformation(); // 0x000000018D3C2DB4-0x000000018D3C2F28
		private void LogRendererListsCreation(); // 0x000000018D3C31E4-0x000000018D3C32D4
		private void LogRenderPassBegin([IsReadOnly] in CompiledPassInfo passInfo); // 0x000000018D3C2F28-0x000000018D3C31E4
		private void LogCulledPasses(); // 0x000000018D3C2AEC-0x000000018D3C2DB4
		private ProfilingSampler GetDefaultProfilingSampler(string name); // 0x000000018D3C2274-0x000000018D3C2364
		private void UpdateImportedResourceLifeTime(ref RenderGraphDebugData.ResourceDebugData data, List<int> passList); // 0x000000018D3C433C-0x000000018D3C44C0
		private void GenerateDebugData(); // 0x000000018D3C11E0-0x000000018D3C21C4
		private void CleanupDebugData(); // 0x000000018D3BE900-0x000000018D3BEACC
	}

	public struct RenderGraphProfilingScope : IDisposable // TypeDefIndex: 83285
	{
		// Fields
		private bool m_Disposed; // 0x00
		private ProfilingSampler m_Sampler; // 0x08
		private RenderGraph m_RenderGraph; // 0x10
	
		// Constructors
		public RenderGraphProfilingScope(RenderGraph renderGraph, ProfilingSampler sampler); // 0x000000018D3D38E0-0x000000018D3D3928
	
		// Methods
		public void Dispose(); // 0x000000018D3D38D4-0x000000018D3D38E0
		private void Dispose(bool disposing); // 0x000000018D3D389C-0x000000018D3D38D4
	}

	public struct RenderGraphBuilder : IDisposable // TypeDefIndex: 83286
	{
		// Fields
		private RenderGraphPass m_RenderPass; // 0x00
		private RenderGraphResourceRegistry m_Resources; // 0x08
		private RenderGraph m_RenderGraph; // 0x10
		private bool m_Disposed; // 0x18
	
		// Constructors
		internal RenderGraphBuilder(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph); // 0x000000018BF906F4-0x000000018BF9072C
	
		// Methods
		public TextureHandle UseColorBuffer([IsReadOnly] in TextureHandle input, int index); // 0x000000018D3D2034-0x000000018D3D20B0
		public TextureHandle UseDepthBuffer([IsReadOnly] in TextureHandle input, DepthAccess flags); // 0x000000018D3D20B0-0x000000018D3D217C
		public TextureHandle ReadTexture([IsReadOnly] in TextureHandle input); // 0x000000018D3D1DFC-0x000000018D3D1FC0
		public TextureHandle WriteTexture([IsReadOnly] in TextureHandle input); // 0x000000018D3D21C4-0x000000018D3D2224
		public TextureHandle ReadWriteTexture([IsReadOnly] in TextureHandle input); // 0x000000018D3D1FC0-0x000000018D3D2034
		public TextureHandle CreateTransientTexture([IsReadOnly] in TextureDesc desc); // 0x000000018D3D1BF4-0x000000018D3D1C60
		public TextureHandle CreateTransientTexture([IsReadOnly] in TextureHandle texture); // 0x000000018D3D1C60-0x000000018D3D1D30
		public RendererListHandle UseRendererList([IsReadOnly] in RendererListHandle input); // 0x000000018D3D1D30-0x000000018D3D1D5C
		public ComputeBufferHandle ReadComputeBuffer([IsReadOnly] in ComputeBufferHandle input); // 0x000000018D3D1DD4-0x000000018D3D1DFC
		public ComputeBufferHandle WriteComputeBuffer([IsReadOnly] in ComputeBufferHandle input); // 0x000000018D3D217C-0x000000018D3D21C4
		public ComputeBufferHandle CreateTransientComputeBuffer([IsReadOnly] in ComputeBufferDesc desc); // 0x000000018D3D1BA0-0x000000018D3D1BF4
		public ComputeBufferHandle CreateTransientComputeBuffer([IsReadOnly] in ComputeBufferHandle computebuffer); // 0x000000018D3D1B1C-0x000000018D3D1BA0
		public void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc)
			where PassData : class, new();
		public void EnableAsyncCompute(bool value); // 0x000000018D3D1D9C-0x000000018D3D1DB8
		public void AllowPassCulling(bool value); // 0x000000018D3D1AE4-0x000000018D3D1B00
		public void Dispose(); // 0x000000018D3D1D90-0x000000018D3D1D9C
		public void AllowRendererListCulling(bool value); // 0x000000018D3D1B00-0x000000018D3D1B1C
		public RendererListHandle DependsOn([IsReadOnly] in RendererListHandle input); // 0x000000018D3D1D30-0x000000018D3D1D5C
		private void Dispose(bool disposing); // 0x000000018D3D1D5C-0x000000018D3D1D90
		private void CheckResource([IsReadOnly] in ResourceHandle res, bool dontCheckTransientReadWrite = false /* Metadata: 0x02641FA1 */); // 0x0000000186805BA0-0x0000000186805BB0
		internal void GenerateDebugData(bool value); // 0x000000018D3D1DB8-0x000000018D3D1DD4
	}

	public class RenderGraphDefaultResources // TypeDefIndex: 83287
	{
		// Fields
		private bool m_IsValid; // 0x10
		private RTHandle m_BlackTexture2D; // 0x18
		private RTHandle m_WhiteTexture2D; // 0x20
		private RTHandle m_ShadowTexture2D; // 0x28
		[CompilerGenerated]
		private TextureHandle _blackTexture_k__BackingField; // 0x30
		[CompilerGenerated]
		private TextureHandle _whiteTexture_k__BackingField; // 0x40
		[CompilerGenerated]
		private TextureHandle _clearTextureXR_k__BackingField; // 0x50
		[CompilerGenerated]
		private TextureHandle _magentaTextureXR_k__BackingField; // 0x60
		[CompilerGenerated]
		private TextureHandle _blackTextureXR_k__BackingField; // 0x70
		[CompilerGenerated]
		private TextureHandle _blackTextureArrayXR_k__BackingField; // 0x80
		[CompilerGenerated]
		private TextureHandle _blackUIntTextureXR_k__BackingField; // 0x90
		[CompilerGenerated]
		private TextureHandle _blackTexture3DXR_k__BackingField; // 0xA0
		[CompilerGenerated]
		private TextureHandle _whiteTextureXR_k__BackingField; // 0xB0
		[CompilerGenerated]
		private TextureHandle _defaultShadowTexture_k__BackingField; // 0xC0
	
		// Properties
		public TextureHandle blackTexture { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234010-0x0000000187234020 0x0000000187234020-0x0000000187234030
		public TextureHandle whiteTexture { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723E4C0-0x000000018723E4D0 0x0000000187234080-0x0000000187234090
		public TextureHandle clearTextureXR { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187239B00-0x0000000187239B10 0x0000000187233F10-0x0000000187233F20
		public TextureHandle magentaTextureXR { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018724F4E0-0x000000018724F4F0 0x0000000187233C80-0x0000000187233C90
		public TextureHandle blackTextureXR { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723DAE0-0x000000018723DAF0 0x0000000187233D60-0x0000000187233D70
		public TextureHandle blackTextureArrayXR { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723E560-0x000000018723E570 0x0000000187233E20-0x0000000187233E30
		public TextureHandle blackUIntTextureXR { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018724BCC0-0x000000018724BCD0 0x0000000187233B50-0x0000000187233B60
		public TextureHandle blackTexture3DXR { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018724F4C0-0x000000018724F4D0 0x0000000187233E60-0x0000000187233E70
		public TextureHandle whiteTextureXR { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018724F490-0x000000018724F4A0 0x000000018724F4F0-0x000000018724F500
		public TextureHandle defaultShadowTexture { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018724F480-0x000000018724F490 0x0000000187233B30-0x0000000187233B40
	
		// Constructors
		internal RenderGraphDefaultResources(); // 0x000000018D3D2404-0x000000018D3D2534
	
		// Methods
		internal void Cleanup(); // 0x000000018D3D2224-0x000000018D3D2268
		internal void InitializeForRendering(RenderGraph renderGraph); // 0x000000018D3D2268-0x000000018D3D2404
	}

	internal struct RenderGraphLogIndent : IDisposable // TypeDefIndex: 83288
	{
		// Fields
		private int m_Indentation; // 0x00
		private RenderGraphLogger m_Logger; // 0x08
		private bool m_Disposed; // 0x10
	
		// Constructors
		public RenderGraphLogIndent(RenderGraphLogger logger, int indentation = 1 /* Metadata: 0x02641FA2 */); // 0x000000018D3D2574-0x000000018D3D25B0
	
		// Methods
		public void Dispose(); // 0x000000018D3D2534-0x000000018D3D2540
		private void Dispose(bool disposing); // 0x000000018D3D2540-0x000000018D3D2574
	}

	internal class RenderGraphLogger // TypeDefIndex: 83289
	{
		// Fields
		private Dictionary<string, StringBuilder> m_LogMap; // 0x10
		private StringBuilder m_CurrentBuilder; // 0x18
		private int m_CurrentIndentation; // 0x20
	
		// Constructors
		public RenderGraphLogger(); // 0x000000018D3D2A24-0x000000018D3D2A9C
	
		// Methods
		public void Initialize(string logName); // 0x000000018D3D28AC-0x000000018D3D29A0
		public void IncrementIndentation(int value); // 0x000000018D3D2850-0x000000018D3D28AC
		public void DecrementIndentation(int value); // 0x000000018D3D25B0-0x000000018D3D261C
		public void LogLine(string format, params object[] args); // 0x000000018D3D29A0-0x000000018D3D2A24
		public string GetLog(string logName); // 0x000000018D3D27C0-0x000000018D3D2850
		public string GetAllLogs(); // 0x000000018D3D261C-0x000000018D3D27C0
	}

	public sealed class RenderGraphObjectPool // TypeDefIndex: 83292
	{
		// Fields
		private Dictionary<ValueTuple<System.Type, int>, Stack<object>> m_ArrayPool; // 0x10
		private List<ValueTuple<object, ValueTuple<System.Type, int>>> m_AllocatedArrays; // 0x18
		private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks; // 0x20
	
		// Nested types
		private abstract class SharedObjectPoolBase // TypeDefIndex: 83290
		{
			// Fields
			protected static List<SharedObjectPoolBase> s_AllocatedPools; // 0x00
	
			// Constructors
			protected SharedObjectPoolBase(); // 0x0000000186805BA0-0x0000000186805BB0
			static SharedObjectPoolBase(); // 0x000000018D3D6E90-0x000000018D3D6F1C
	
			// Methods
			protected abstract void Clear();
			public static void ClearAll(); // 0x000000018D3D6D4C-0x000000018D3D6E90
		}
	
		private class SharedObjectPool<T> : SharedObjectPoolBase // TypeDefIndex: 83291
			where T : new()
		{
			// Fields
			private Stack<T> m_Pool;
			private static readonly Lazy<SharedObjectPool<T>> s_Instance;
	
			// Properties
			public static SharedObjectPool<T> sharedPool { get; }
	
			// Constructors
			public SharedObjectPool();
			static SharedObjectPool();
	
			// Methods
			public T Get();
			public void Release(T value);
			private static SharedObjectPool<T> AllocatePool();
			protected override void Clear();
		}
	
		// Constructors
		internal RenderGraphObjectPool(); // 0x000000018D3D2F80-0x000000018D3D308C
	
		// Methods
		public T[] GetTempArray<T>(int size);
		public MaterialPropertyBlock GetTempMaterialPropertyBlock(); // 0x000000018D3D2B44-0x000000018D3D2C00
		internal void ReleaseAllTempAlloc(); // 0x000000018D3D2C00-0x000000018D3D2F80
		internal T Get<T>()
			where T : new();
		internal void Release<T>(T value)
			where T : new();
		internal void Cleanup(); // 0x000000018D3D2A9C-0x000000018D3D2B44
	}

	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal abstract class RenderGraphPass // TypeDefIndex: 83293
	{
		// Fields
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x10
		[CompilerGenerated]
		private int _index_k__BackingField; // 0x18
		[CompilerGenerated]
		private ProfilingSampler _customSampler_k__BackingField; // 0x20
		[CompilerGenerated]
		private bool _enableAsyncCompute_k__BackingField; // 0x28
		[CompilerGenerated]
		private bool _allowPassCulling_k__BackingField; // 0x29
		[CompilerGenerated]
		private TextureHandle _depthBuffer_k__BackingField; // 0x2C
		[CompilerGenerated]
		private TextureHandle[] _colorBuffers_k__BackingField; // 0x40
		[CompilerGenerated]
		private int _colorBufferMaxIndex_k__BackingField; // 0x48
		[CompilerGenerated]
		private int _refCount_k__BackingField; // 0x4C
		[CompilerGenerated]
		private bool _generateDebugData_k__BackingField; // 0x50
		[CompilerGenerated]
		private bool _allowRendererListCulling_k__BackingField; // 0x51
		public List<ResourceHandle>[] resourceReadLists; // 0x58
		public List<ResourceHandle>[] resourceWriteLists; // 0x60
		public List<ResourceHandle>[] transientResourceList; // 0x68
		public List<RendererListHandle> usedRendererListList; // 0x70
		public List<RendererListHandle> dependsOnRendererListList; // 0x78
	
		// Properties
		public string name { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public int index { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public ProfilingSampler customSampler { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public bool enableAsyncCompute { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
		public bool allowPassCulling { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018225E0D0-0x000000018225E0E0 0x000000018225E0E0-0x000000018225E0F0
		public TextureHandle depthBuffer { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018723B650-0x000000018723B660 0x000000018723B660-0x000000018723B670
		public TextureHandle[] colorBuffers { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public int colorBufferMaxIndex { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001872330A0-0x00000001872330B0 0x0000000185E120B0-0x0000000185E120C0
		public int refCount { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187233730-0x0000000187233740 0x0000000187233740-0x0000000187233750
		public bool generateDebugData { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018225DFF0-0x000000018225E000 0x000000018225E000-0x000000018225E010
		public bool allowRendererListCulling { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018226ECC0-0x000000018226ECD0 0x000000018226ECD0-0x000000018226ECE0
	
		// Constructors
		public RenderGraphPass(); // 0x000000018D3D3610-0x000000018D3D389C
	
		// Methods
		public RenderFunc<PassData> GetExecuteDelegate<PassData>()
			where PassData : class, new();
		public abstract void Execute(RenderGraphContext renderGraphContext);
		public abstract void Release(RenderGraphObjectPool pool);
		public abstract bool HasRenderFunc();
		public void Clear(); // 0x000000018D3D3254-0x000000018D3D3478
		public void AddResourceWrite([IsReadOnly] in ResourceHandle res); // 0x000000018D3D3124-0x000000018D3D31BC
		public void AddResourceRead([IsReadOnly] in ResourceHandle res); // 0x000000018D3D308C-0x000000018D3D3124
		public void AddTransientResource([IsReadOnly] in ResourceHandle res); // 0x000000018D3D31BC-0x000000018D3D3254
		public void UseRendererList(RendererListHandle rendererList); // 0x000000018D3D35BC-0x000000018D3D3610
		public void DependsOnRendererList(RendererListHandle rendererList); // 0x000000018D3D3478-0x000000018D3D34CC
		public void EnableAsyncCompute(bool value); // 0x000000018225DF80-0x000000018225DF90
		public void AllowPassCulling(bool value); // 0x000000018225E0E0-0x000000018225E0F0
		public void AllowRendererListCulling(bool value); // 0x000000018226ECD0-0x000000018226ECE0
		public void GenerateDebugData(bool value); // 0x000000018225E000-0x000000018225E010
		public void SetColorBuffer(TextureHandle resource, int index); // 0x000000018D3D34CC-0x000000018D3D3568
		public void SetDepthBuffer(TextureHandle resource, DepthAccess flags); // 0x000000018D3D3568-0x000000018D3D35BC
	}

	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal sealed class RenderGraphPass<PassData> : RenderGraphPass // TypeDefIndex: 83294
		where PassData : class, new()
	{
		// Fields
		internal PassData data;
		internal RenderFunc<PassData> renderFunc;
	
		// Constructors
		public RenderGraphPass();
	
		// Methods
		public override void Execute(RenderGraphContext renderGraphContext);
		public void Initialize(int passIndex, PassData passData, string passName, ProfilingSampler sampler);
		public override void Release(RenderGraphObjectPool pool);
		public override bool HasRenderFunc();
	}

	internal enum RenderGraphProfileId // TypeDefIndex: 83295
	{
		CompileRenderGraph = 0,
		ExecuteRenderGraph = 1,
		RenderGraphClear = 2,
		RenderGraphClearDebug = 3
	}

	[DebuggerDisplay("ComputeBuffer ({handle.index})")]
	public struct ComputeBufferHandle // TypeDefIndex: 83296
	{
		// Fields
		private static ComputeBufferHandle s_NullHandle; // 0x00
		internal ResourceHandle handle; // 0x00
	
		// Properties
		public static ComputeBufferHandle nullHandle { get; } // 0x000000018D3C8344-0x000000018D3C8394 
	
		// Constructors
		internal ComputeBufferHandle(int handle, bool shared = false /* Metadata: 0x02641FA7 */); // 0x000000018D3C830C-0x000000018D3C8344
		static ComputeBufferHandle(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static implicit operator ComputeBuffer(ComputeBufferHandle buffer); // 0x000000018D3C8394-0x000000018D3C8400
		public bool IsValid(); // 0x000000018D3C82C0-0x000000018D3C830C
	}

	public struct ComputeBufferDesc // TypeDefIndex: 83297
	{
		// Fields
		public int count; // 0x00
		public int stride; // 0x04
		public ComputeBufferType type; // 0x08
		public string name; // 0x10
	
		// Constructors
		public ComputeBufferDesc(int count, int stride); // 0x000000018724F440-0x000000018724F460
		public ComputeBufferDesc(int count, int stride, ComputeBufferType type); // 0x000000018724F420-0x000000018724F440
	
		// Methods
		public override int GetHashCode(); // 0x000000018725E1E0-0x000000018725E200
	}

	[DebuggerDisplay("ComputeBufferResource ({desc.name})")]
	internal class ComputeBufferResource : RenderGraphResource<ComputeBufferDesc, ComputeBuffer> // TypeDefIndex: 83298
	{
		// Constructors
		public ComputeBufferResource(); // 0x000000018D3C8E9C-0x000000018D3C8EC4
	
		// Methods
		public override string GetName(); // 0x000000018D3C8BDC-0x000000018D3C8C1C
		public override void CreatePooledGraphicsResource(); // 0x000000018D3C8A88-0x000000018D3C8BDC
		public override void ReleasePooledGraphicsResource(int frameIndex); // 0x000000018D3C8D60-0x000000018D3C8E9C
		public override void CreateGraphicsResource(string name = "" /* Metadata: 0x02641FA8 */); // 0x000000018D3C8918-0x000000018D3C8A88
		public override void ReleaseGraphicsResource(); // 0x000000018D3C8D1C-0x000000018D3C8D60
		public override void LogCreation(RenderGraphLogger logger); // 0x000000018D3C8C1C-0x000000018D3C8C9C
		public override void LogRelease(RenderGraphLogger logger); // 0x000000018D3C8C9C-0x000000018D3C8D1C
	}

	internal class ComputeBufferPool : RenderGraphResourcePool<ComputeBuffer> // TypeDefIndex: 83299
	{
		// Constructors
		public ComputeBufferPool(); // 0x000000018D3C88DC-0x000000018D3C8918
	
		// Methods
		protected override void ReleaseInternalResource(ComputeBuffer res); // 0x000000018D3C88BC-0x000000018D3C88DC
		protected override string GetResourceName(ComputeBuffer res); // 0x000000018D3C8400-0x000000018D3C842C
		protected override long GetResourceSize(ComputeBuffer res); // 0x000000018D3C842C-0x000000018D3C846C
		protected override string GetResourceTypeName(); // 0x000000018D3C846C-0x000000018D3C8498
		protected override int GetSortIndex(ComputeBuffer res); // 0x000000018BD9657C-0x000000018BD9659C
		public override void PurgeUnusedResources(int currentFrameIndex); // 0x000000018D3C8498-0x000000018D3C88BC
	}

	internal abstract class IRenderGraphResourcePool // TypeDefIndex: 83300
	{
		// Constructors
		protected IRenderGraphResourcePool(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract void PurgeUnusedResources(int currentFrameIndex);
		public abstract void Cleanup();
		public abstract void CheckFrameAllocation(bool onException, int frameIndex);
		public abstract void LogResources(RenderGraphLogger logger);
	}

	internal abstract class RenderGraphResourcePool<Type> : IRenderGraphResourcePool // TypeDefIndex: 83303
		where Type : class
	{
		// Fields
		[TupleElementNames(new string[2] {"resource", "frameIndex" })]
		protected Dictionary<int, SortedList<int, ValueTuple<Type, int>>> m_ResourcePool;
		protected List<int> m_RemoveList;
		private List<ValueTuple<int, Type>> m_FrameAllocatedResources;
		protected static int s_CurrentFrameIndex;
		private const int kStaleResourceLifetime = 10; // Metadata: 0x02641FA9
	
		// Nested types
		private struct ResourceLogInfo // TypeDefIndex: 83301
		{
			// Fields
			public string name;
			public long size;
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83302
		{
			// Fields
			public static readonly __c<Type> __9;
			public static Comparison<ResourceLogInfo<Type>> __9__17_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _LogResources_b__17_0(ResourceLogInfo<Type> a, ResourceLogInfo<Type> b);
		}
	
		// Constructors
		protected RenderGraphResourcePool();
	
		// Methods
		protected abstract void ReleaseInternalResource(Type res);
		protected abstract string GetResourceName(Type res);
		protected abstract long GetResourceSize(Type res);
		protected abstract string GetResourceTypeName();
		protected abstract int GetSortIndex(Type res);
		public void ReleaseResource(int hash, Type resource, int currentFrameIndex);
		public bool TryGetResource(int hashCode, out ref Type resource);
		public override void Cleanup();
		public void RegisterFrameAllocation(int hash, Type value);
		public void UnregisterFrameAllocation(int hash, Type value);
		public override void CheckFrameAllocation(bool onException, int frameIndex);
		public override void LogResources(RenderGraphLogger logger);
		protected static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex);
	}

	internal class RenderGraphResourceRegistry // TypeDefIndex: 83306
	{
		// Fields
		private const int kSharedResourceLifetime = 30; // Metadata: 0x02641FAD
		private static RenderGraphResourceRegistry m_CurrentRegistry; // 0x00
		private RenderGraphResourcesData[] m_RenderGraphResources; // 0x10
		private DynamicArray<RendererListResource> m_RendererListResources; // 0x18
		private RenderGraphDebugParams m_RenderGraphDebug; // 0x20
		private RenderGraphLogger m_ResourceLogger; // 0x28
		private RenderGraphLogger m_FrameInformationLogger; // 0x30
		private int m_CurrentFrameIndex; // 0x38
		private int m_ExecutionCount; // 0x3C
		private RTHandle m_CurrentBackbuffer; // 0x40
		private const int kInitialRendererListCount = 256; // Metadata: 0x02641FAE
		private List<UnityEngine.Rendering.RendererUtils.RendererList> m_ActiveRendererLists; // 0x48
	
		// Properties
		internal static RenderGraphResourceRegistry current { get; set; } // 0x000000018D3D664C-0x000000018D3D6684 0x000000018D3D6684-0x000000018D3D66D4
	
		// Nested types
		private delegate void ResourceCallback(RenderGraphContext rgContext, IRenderGraphResource res); // TypeDefIndex: 83304; 0x00000001859B7730-0x00000001859B7740
	
		private class RenderGraphResourcesData // TypeDefIndex: 83305
		{
			// Fields
			public DynamicArray<IRenderGraphResource> resourceArray; // 0x10
			public int sharedResourcesCount; // 0x18
			public IRenderGraphResourcePool pool; // 0x20
			public ResourceCallback createResourceCallback; // 0x28
			public ResourceCallback releaseResourceCallback; // 0x30
	
			// Constructors
			public RenderGraphResourcesData(); // 0x000000018D3D67FC-0x000000018D3D6874
	
			// Methods
			public void Clear(bool onException, int frameIndex); // 0x000000018D3D6758-0x000000018D3D67D8
			public void Cleanup(); // 0x000000018D3D66D4-0x000000018D3D6758
			public void PurgeUnusedGraphicsResources(int frameIndex); // 0x000000018D3D67D8-0x000000018D3D67FC
			public int AddNewRenderGraphResource<ResType>(out ref ResType outRes, bool pooledResource = true /* Metadata: 0x02641FB0 */)
				where ResType : IRenderGraphResource, new();
		}
	
		// Constructors
		private RenderGraphResourceRegistry(); // 0x000000018D3D6524-0x000000018D3D664C
		internal RenderGraphResourceRegistry(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger frameInformationLogger); // 0x000000018D3D61B0-0x000000018D3D6524
	
		// Methods
		internal RTHandle GetTexture([IsReadOnly] in TextureHandle handle); // 0x000000018D3D5174-0x000000018D3D5320
		internal bool TextureNeedsFallback([IsReadOnly] in TextureHandle handle); // 0x000000018D3D609C-0x000000018D3D6120
		internal UnityEngine.Rendering.RendererUtils.RendererList GetRendererList([IsReadOnly] in RendererListHandle handle); // 0x000000018D3D4E64-0x000000018D3D4F30
		internal ComputeBuffer GetComputeBuffer([IsReadOnly] in ComputeBufferHandle handle); // 0x000000018D3D4B78-0x000000018D3D4C48
		internal void BeginRenderGraph(int executionCount); // 0x000000018D3D3948-0x000000018D3D39D0
		internal void BeginExecute(int currentFrameIndex); // 0x000000018D3D3928-0x000000018D3D3948
		internal void EndExecute(); // 0x000000018D3D4894-0x000000018D3D489C
		private void CheckHandleValidity([IsReadOnly] in ResourceHandle res); // 0x000000018D3D39D0-0x000000018D3D3A24
		private void CheckHandleValidity(RenderGraphResourceType type, int index); // 0x000000018D3D3A24-0x000000018D3D3B4C
		internal void IncrementWriteCount([IsReadOnly] in ResourceHandle res); // 0x000000018D3D5630-0x000000018D3D56EC
		internal string GetRenderGraphResourceName([IsReadOnly] in ResourceHandle res); // 0x000000018D3D4C48-0x000000018D3D4D08
		internal string GetRenderGraphResourceName(RenderGraphResourceType type, int index); // 0x000000018D3D4D08-0x000000018D3D4DA8
		internal bool IsRenderGraphResourceImported([IsReadOnly] in ResourceHandle res); // 0x000000018D3D5848-0x000000018D3D5904
		internal bool IsRenderGraphResourceShared(RenderGraphResourceType type, int index); // 0x000000018D3D5904-0x000000018D3D5960
		internal bool IsGraphicsResourceCreated([IsReadOnly] in ResourceHandle res); // 0x000000018D3D56EC-0x000000018D3D57AC
		internal bool IsRendererListCreated([IsReadOnly] in RendererListHandle res); // 0x000000018D3D5960-0x000000018D3D59E8
		internal bool IsRenderGraphResourceImported(RenderGraphResourceType type, int index); // 0x000000018D3D57AC-0x000000018D3D5848
		internal int GetRenderGraphResourceTransientIndex([IsReadOnly] in ResourceHandle res); // 0x000000018D3D4DA8-0x000000018D3D4E64
		internal TextureHandle ImportTexture(RTHandle rt); // 0x000000018D3D555C-0x000000018D3D5630
		internal TextureHandle CreateSharedTexture([IsReadOnly] in TextureDesc desc, bool explicitRelease); // 0x000000018D3D42F4-0x000000018D3D4500
		internal void ReleaseSharedTexture(TextureHandle texture); // 0x000000018D3D5DC8-0x000000018D3D5EF0
		internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt); // 0x000000018D3D5320-0x000000018D3D5498
		internal TextureHandle CreateTexture([IsReadOnly] in TextureDesc desc, int transientPassIndex = -1 /* Metadata: 0x02641FAA */); // 0x000000018D3D4778-0x000000018D3D4894
		internal int GetTextureResourceCount(); // 0x000000018D3D4F30-0x000000018D3D4F8C
		private TextureResource GetTextureResource([IsReadOnly] in ResourceHandle handle); // 0x000000018D3D50B4-0x000000018D3D5174
		internal TextureDesc GetTextureResourceDesc([IsReadOnly] in ResourceHandle handle); // 0x000000018D3D4F8C-0x000000018D3D50B4
		internal void ForceTextureClear([IsReadOnly] in ResourceHandle handle, UnityEngine.Color clearColor); // 0x000000018D3D48F8-0x000000018D3D4958
		internal RendererListHandle CreateRendererList([IsReadOnly] in UnityEngine.Rendering.RendererUtils.RendererListDesc desc); // 0x000000018D3D3E74-0x000000018D3D3FAC
		internal ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer); // 0x000000018D3D5498-0x000000018D3D555C
		internal ComputeBufferHandle CreateComputeBuffer([IsReadOnly] in ComputeBufferDesc desc, int transientPassIndex = -1 /* Metadata: 0x02641FAB */); // 0x000000018D3D3C84-0x000000018D3D3D64
		internal ComputeBufferDesc GetComputeBufferResourceDesc([IsReadOnly] in ResourceHandle handle); // 0x000000018D3D49B4-0x000000018D3D4AB8
		internal int GetComputeBufferResourceCount(); // 0x000000018D3D4958-0x000000018D3D49B4
		private ComputeBufferResource GetComputeBufferResource([IsReadOnly] in ResourceHandle handle); // 0x000000018D3D4AB8-0x000000018D3D4B78
		internal void UpdateSharedResourceLastFrameIndex(int type, int index); // 0x000000018D3D6120-0x000000018D3D61B0
		private void ManageSharedRenderGraphResources(); // 0x000000018D3D5B04-0x000000018D3D5C50
		internal void CreatePooledResource(RenderGraphContext rgContext, int type, int index); // 0x000000018D3D3D64-0x000000018D3D3E74
		private void CreateTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res); // 0x000000018D3D4500-0x000000018D3D4778
		internal void ReleasePooledResource(RenderGraphContext rgContext, int type, int index); // 0x000000018D3D5CB4-0x000000018D3D5DC8
		private void ReleaseTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res); // 0x000000018D3D5EF0-0x000000018D3D609C
		private void ValidateTextureDesc([IsReadOnly] in TextureDesc desc); // 0x0000000186805BA0-0x0000000186805BB0
		private void ValidateRendererListDesc([IsReadOnly] in UnityEngine.Rendering.RendererUtils.RendererListDesc desc); // 0x0000000186805BA0-0x0000000186805BB0
		private void ValidateComputeBufferDesc([IsReadOnly] in ComputeBufferDesc desc); // 0x0000000186805BA0-0x0000000186805BB0
		internal void CreateRendererLists(List<RendererListHandle> rendererLists, ScriptableRenderContext context, bool manualDispatch = false /* Metadata: 0x02641FAC */); // 0x000000018D3D3FAC-0x000000018D3D42F4
		internal void Clear(bool onException); // 0x000000018D3D3BB8-0x000000018D3D3C84
		internal void PurgeUnusedGraphicsResources(); // 0x000000018D3D5C50-0x000000018D3D5CB4
		internal void Cleanup(); // 0x000000018D3D3B4C-0x000000018D3D3BB8
		internal void FlushLogs(); // 0x000000018D3D489C-0x000000018D3D48F8
		private void LogResources(); // 0x000000018D3D59E8-0x000000018D3D5B04
	}

	[DebuggerDisplay("RendererList ({handle})")]
	public struct RendererListHandle // TypeDefIndex: 83307
	{
		// Fields
		private bool m_IsValid; // 0x00
		[CompilerGenerated]
		private int _handle_k__BackingField; // 0x04
	
		// Properties
		internal int handle { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x00000001872342E0-0x00000001872342F0 0x0000000187235AB0-0x0000000187235AC0
	
		// Constructors
		internal RendererListHandle(int handle); // 0x000000018724B5C0-0x000000018724B5D0
	
		// Methods
		public static implicit operator int(RendererListHandle handle); // 0x000000018724B9A0-0x000000018724B9B0
		public static implicit operator UnityEngine.Rendering.RendererUtils.RendererList(RendererListHandle rendererList); // 0x000000018D3D6874-0x000000018D3D6904
		public bool IsValid(); // 0x00000001844AD2A0-0x00000001844AD2B0
	}

	internal struct RendererListResource // TypeDefIndex: 83308
	{
		// Fields
		public UnityEngine.Rendering.RendererUtils.RendererListDesc desc; // 0x00
		public UnityEngine.Rendering.RendererUtils.RendererList rendererList; // 0xE0
	
		// Constructors
		internal RendererListResource([IsReadOnly] in UnityEngine.Rendering.RendererUtils.RendererListDesc desc); // 0x000000018C045844-0x000000018C045964
	}

	internal enum RenderGraphResourceType // TypeDefIndex: 83309
	{
		Texture = 0,
		ComputeBuffer = 1,
		Count = 2
	}

	internal struct ResourceHandle // TypeDefIndex: 83310
	{
		// Fields
		private const uint kValidityMask = 4294901760; // Metadata: 0x02641FB4
		private const uint kIndexMask = 65535; // Metadata: 0x02641FB9
		private uint m_Value; // 0x00
		private static uint s_CurrentValidBit; // 0x00
		private static uint s_SharedResourceValidBit; // 0x04
		[CompilerGenerated]
		private RenderGraphResourceType _type_k__BackingField; // 0x04
	
		// Properties
		public int index { get; } // 0x000000018448B780-0x000000018448B790 
		public RenderGraphResourceType type { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872342E0-0x00000001872342F0 0x0000000187235AB0-0x0000000187235AC0
		public int iType { get; } // 0x000000018D3D6B1C-0x000000018D3D6B60 
	
		// Constructors
		internal ResourceHandle(int value, RenderGraphResourceType type, bool shared); // 0x000000018D3D6A90-0x000000018D3D6B1C
		static ResourceHandle(); // 0x000000018D3D6A40-0x000000018D3D6A90
	
		// Methods
		public static implicit operator int(ResourceHandle handle); // 0x000000018D3D6B60-0x000000018D3D6BA4
		public bool IsValid(); // 0x000000018D3D6904-0x000000018D3D697C
		public static void NewFrame(int executionIndex); // 0x000000018D3D697C-0x000000018D3D6A40
	}

	internal class IRenderGraphResource // TypeDefIndex: 83311
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
		public IRenderGraphResource(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public virtual void Reset(IRenderGraphResourcePool pool); // 0x000000018D3D1A24-0x000000018D3D1A48
		public virtual string GetName(); // 0x000000018D3D19E4-0x000000018D3D1A10
		public virtual bool IsCreated(); // 0x00000001843FFFF0-0x0000000184400000
		public virtual void IncrementWriteCount(); // 0x000000018725E270-0x000000018725E280
		public virtual bool NeedsFallBack(); // 0x000000018D3D1A10-0x000000018D3D1A24
		public virtual void CreatePooledGraphicsResource(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void CreateGraphicsResource(string name = "" /* Metadata: 0x02641FBD */); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void ReleasePooledGraphicsResource(int frameIndex); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void ReleaseGraphicsResource(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void LogCreation(RenderGraphLogger logger); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void LogRelease(RenderGraphLogger logger); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual int GetSortIndex(); // 0x0000000185829EC0-0x0000000185829ED0
	}

	[DebuggerDisplay("Resource ({GetType().Name}:{GetName()})")]
	internal abstract class RenderGraphResource<DescType, ResType> : IRenderGraphResource // TypeDefIndex: 83312
		where DescType : struct
		where ResType : class
	{
		// Fields
		public DescType desc;
		public ResType graphicsResource;
	
		// Constructors
		protected RenderGraphResource();
	
		// Methods
		public override void Reset(IRenderGraphResourcePool pool);
		public override bool IsCreated();
		public override void ReleaseGraphicsResource();
	}

	[DebuggerDisplay("Texture ({handle.index})")]
	public struct TextureHandle // TypeDefIndex: 83313
	{
		// Fields
		private static TextureHandle s_NullHandle; // 0x00
		internal ResourceHandle handle; // 0x00
		internal ResourceHandle fallBackResource; // 0x08
	
		// Properties
		public static TextureHandle nullHandle { get; } // 0x000000018D3D74C0-0x000000018D3D751C 
	
		// Constructors
		internal TextureHandle(int handle, bool shared = false /* Metadata: 0x02641FBE */); // 0x000000018D3D7430-0x000000018D3D74C0
		static TextureHandle(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static implicit operator RenderTargetIdentifier(TextureHandle texture); // 0x000000018D3D767C-0x000000018D3D7730
		public static implicit operator Texture(TextureHandle texture); // 0x000000018D3D751C-0x000000018D3D7598
		public static implicit operator RenderTexture(TextureHandle texture); // 0x000000018D3D7600-0x000000018D3D767C
		public static implicit operator RTHandle(TextureHandle texture); // 0x000000018D3D7598-0x000000018D3D7600
		public bool IsValid(); // 0x000000018D3D73E4-0x000000018D3D7430
		public void SetFallBackResource(TextureHandle texture); // 0x000000018725E280-0x000000018725E290
	}

	public enum TextureSizeMode // TypeDefIndex: 83314
	{
		Explicit = 0,
		Scale = 1,
		Functor = 2
	}

	public struct FastMemoryDesc // TypeDefIndex: 83315
	{
		// Fields
		public bool inFastMemory; // 0x00
		public FastMemoryFlags flags; // 0x04
		public float residencyFraction; // 0x08
	}

	public struct TextureDesc // TypeDefIndex: 83316
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
		public TextureDesc(int width, int height, bool xrReady = false /* Metadata: 0x02641FC2 */); // 0x000000018D3D73B0-0x000000018D3D73E4
		public TextureDesc(TextureDesc input); // 0x000000018C0489FC-0x000000018C048A34
	
		// Methods
		private void InitDefaultValues(bool xrReady); // 0x000000018D3D7348-0x000000018D3D73B0
		public override int GetHashCode(); // 0x000000018D3D7250-0x000000018D3D7348
	}

	[DebuggerDisplay("TextureResource ({desc.name})")]
	internal class TextureResource : RenderGraphResource<TextureDesc, RTHandle> // TypeDefIndex: 83317
	{
		// Fields
		private static int m_TextureCreationIndex; // 0x00
	
		// Constructors
		public TextureResource(); // 0x000000018D3D82E8-0x000000018D3D8310
	
		// Methods
		public override string GetName(); // 0x000000018D3D7FC4-0x000000018D3D8020
		public override void CreatePooledGraphicsResource(); // 0x000000018D3D7E70-0x000000018D3D7FC4
		public override void ReleasePooledGraphicsResource(int frameIndex); // 0x000000018D3D81A0-0x000000018D3D82E8
		public override void CreateGraphicsResource(string name = "" /* Metadata: 0x02641FC3 */); // 0x000000018D3D7C44-0x000000018D3D7E70
		public override void ReleaseGraphicsResource(); // 0x000000018D3D8154-0x000000018D3D81A0
		public override void LogCreation(RenderGraphLogger logger); // 0x000000018D3D8020-0x000000018D3D80D4
		public override void LogRelease(RenderGraphLogger logger); // 0x000000018D3D80D4-0x000000018D3D8154
	}

	internal class TexturePool : RenderGraphResourcePool<RTHandle> // TypeDefIndex: 83318
	{
		// Constructors
		public TexturePool(); // 0x000000018D3D7C08-0x000000018D3D7C44
	
		// Methods
		protected override void ReleaseInternalResource(RTHandle res); // 0x000000018D3D7BE8-0x000000018D3D7C08
		protected override string GetResourceName(RTHandle res); // 0x000000018D3D7730-0x000000018D3D7754
		protected override long GetResourceSize(RTHandle res); // 0x000000018D3D7754-0x000000018D3D7778
		protected override string GetResourceTypeName(); // 0x000000018D3D7778-0x000000018D3D77A4
		protected override int GetSortIndex(RTHandle res); // 0x000000018D3D77A4-0x000000018D3D77C4
		public override void PurgeUnusedResources(int currentFrameIndex); // 0x000000018D3D77C4-0x000000018D3D7BE8
	}
}

namespace UnityEngine.Rendering
{
	public class CameraSwitcher : MonoBehaviour // TypeDefIndex: 83319
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
		public CameraSwitcher(); // 0x000000018D3C7E58-0x000000018D3C7E74
	
		// Methods
		private void OnEnable(); // 0x000000018D3C7654-0x000000018D3C7BB8
		private void OnDisable(); // 0x000000018D3C75E0-0x000000018D3C7654
		private int GetCameraCount(); // 0x000000018D3C7580-0x000000018D3C75A0
		private Camera GetNextCamera(); // 0x000000018D3C75A0-0x000000018D3C75E0
		private void SetCameraIndex(int index); // 0x000000018D3C7BB8-0x000000018D3C7E50
		[CompilerGenerated]
		private int _OnEnable_b__10_0(); // 0x000000018226A850-0x000000018226A860
		[CompilerGenerated]
		private void _OnEnable_b__10_1(int value); // 0x000000018D3C7E50-0x000000018D3C7E58
		[CompilerGenerated]
		private int _OnEnable_b__10_2(); // 0x0000000187233370-0x0000000187233380
		[CompilerGenerated]
		private void _OnEnable_b__10_3(int value); // 0x00000001872333D0-0x00000001872333E0
	}

	public class FreeCamera : MonoBehaviour // TypeDefIndex: 83320
	{
		// Fields
		private const float k_MouseSensitivityMultiplier = 0.01f; // Metadata: 0x02641FC4
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
		public FreeCamera(); // 0x000000018D3D18BC-0x000000018D3D18F4
	
		// Methods
		private void OnEnable(); // 0x000000018D3D0A44-0x000000018D3D0A4C
		private void RegisterInputs(); // 0x000000018D3D0A4C-0x000000018D3D11E0
		private void UpdateInputs(); // 0x000000018D3D11E0-0x000000018D3D13F8
		private void Update(); // 0x000000018D3D13F8-0x000000018D3D18BC
	}

	public static class CommandBufferPool // TypeDefIndex: 83322
	{
		// Fields
		private static ObjectPool<CommandBuffer> s_BufferPool; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83321
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x00000001871E56C0-0x00000001871E5720
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _.cctor_b__4_0(CommandBuffer x); // 0x00000001856A5AC0-0x00000001856A5D80
			internal void _.cctor_b__4_1(CommandBuffer x); // 0x00000001856A5D80-0x00000001856A5DE0
		}
	
		// Constructors
		static CommandBufferPool(); // 0x0000000186F83870-0x0000000186F839E0
	
		// Methods
		public static CommandBuffer Get(); // 0x000000018D3C7F18-0x000000018D3C7FB4
		public static CommandBuffer Get(string name); // 0x0000000185EF0380-0x0000000185EF0660
		public static void Release(CommandBuffer buffer); // 0x000000018604E140-0x000000018604E1A0
	}

	[Flags]
	public enum ClearFlag // TypeDefIndex: 83323
	{
		None = 0,
		Color = 1,
		Depth = 2,
		Stencil = 4,
		ColorStencil = 5,
		DepthStencil = 6,
		All = 7
	}

	public static class ComponentSingleton<TType> // TypeDefIndex: 83324
		where TType : Component
	{
		// Fields
		private static TType s_Instance;
	
		// Properties
		public static TType instance { get; }
	
		// Methods
		public static void Release();
	}

	public class ConstantBuffer // TypeDefIndex: 83325
	{
		// Fields
		private static List<ConstantBufferBase> m_RegisteredConstantBuffers; // 0x00
	
		// Constructors
		public ConstantBuffer(); // 0x0000000186805BA0-0x0000000186805BB0
		static ConstantBuffer(); // 0x0000000187178E90-0x0000000187178F20
	
		// Methods
		public static void PushGlobal<CBType>(CommandBuffer cmd, [IsReadOnly] in ref CBType data, int shaderId)
			where CBType : struct;
		public static void PushGlobal<CBType>([IsReadOnly] in ref CBType data, int shaderId)
			where CBType : struct;
		public static void Push<CBType>(CommandBuffer cmd, [IsReadOnly] in ref CBType data, ComputeShader cs, int shaderId)
			where CBType : struct;
		public static void Push<CBType>([IsReadOnly] in ref CBType data, ComputeShader cs, int shaderId)
			where CBType : struct;
		public static void Push<CBType>(CommandBuffer cmd, [IsReadOnly] in ref CBType data, Material mat, int shaderId)
			where CBType : struct;
		public static void Push<CBType>([IsReadOnly] in ref CBType data, Material mat, int shaderId)
			where CBType : struct;
		public static void UpdateData<CBType>(CommandBuffer cmd, [IsReadOnly] in ref CBType data)
			where CBType : struct;
		public static void UpdateData<CBType>([IsReadOnly] in ref CBType data)
			where CBType : struct;
		public static void SetGlobal<CBType>(CommandBuffer cmd, int shaderId)
			where CBType : struct;
		public static void SetGlobal<CBType>(int shaderId)
			where CBType : struct;
		public static void Set<CBType>(CommandBuffer cmd, ComputeShader cs, int shaderId)
			where CBType : struct;
		public static void Set<CBType>(ComputeShader cs, int shaderId)
			where CBType : struct;
		public static void Set<CBType>(Material mat, int shaderId)
			where CBType : struct;
		public static void ReleaseAll(); // 0x0000000185B9D590-0x0000000185B9D720
		internal static void Register(ConstantBufferBase cb); // 0x000000018D3C8EC4-0x000000018D3C8F34
	}

	public abstract class ConstantBufferBase // TypeDefIndex: 83326
	{
		// Constructors
		protected ConstantBufferBase(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract void Release();
	}

	public class ConstantBuffer<CBType> : ConstantBufferBase // TypeDefIndex: 83327
		where CBType : struct
	{
		// Fields
		private HashSet<int> m_GlobalBindings;
		private CBType[] m_Data;
		private ComputeBuffer m_GPUConstantBuffer;
	
		// Constructors
		public ConstantBuffer();
	
		// Methods
		public void UpdateData(CommandBuffer cmd, [IsReadOnly] in ref CBType data);
		public void UpdateData([IsReadOnly] in ref CBType data);
		public void SetGlobal(CommandBuffer cmd, int shaderId);
		public void SetGlobal(int shaderId);
		public void Set(CommandBuffer cmd, ComputeShader cs, int shaderId);
		public void Set(ComputeShader cs, int shaderId);
		public void Set(Material mat, int shaderId);
		public void PushGlobal(CommandBuffer cmd, [IsReadOnly] in ref CBType data, int shaderId);
		public void PushGlobal([IsReadOnly] in ref CBType data, int shaderId);
		public override void Release();
	}

	internal class ConstantBufferSingleton<CBType> : ConstantBuffer<CBType> // TypeDefIndex: 83328
		where CBType : struct
	{
		// Fields
		private static ConstantBufferSingleton<CBType> s_Instance;
	
		// Properties
		internal static ConstantBufferSingleton<CBType> instance { get; set; }
	
		// Constructors
		public ConstantBufferSingleton();
	
		// Methods
		public override void Release();
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class DisplayInfoAttribute : Attribute // TypeDefIndex: 83329
	{
		// Fields
		public string name; // 0x10
		public int order; // 0x18
	
		// Constructors
		public DisplayInfoAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class AdditionalPropertyAttribute : Attribute // TypeDefIndex: 83330
	{
		// Constructors
		public AdditionalPropertyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal enum CoreProfileId // TypeDefIndex: 83331
	{
		BlitTextureInPotAtlas = 0
	}

	public static class CoreUnsafeUtils // TypeDefIndex: 83336
	{
		// Nested types
		public struct FixedBufferStringQueue // TypeDefIndex: 83332
		{
			// Fields
			private unsafe byte* m_ReadCursor; // 0x00
			private unsafe byte* m_WriteCursor; // 0x08
			private readonly unsafe byte* m_BufferEnd; // 0x10
			private readonly unsafe byte* m_BufferStart; // 0x18
			private readonly int m_BufferLength; // 0x20
			[CompilerGenerated]
			private int _Count_k__BackingField; // 0x24
	
			// Properties
			public int Count { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
	
			// Constructors
			public unsafe FixedBufferStringQueue(byte* ptr, int length); // 0x000000018D3D08B4-0x000000018D3D08DC
	
			// Methods
			public bool TryPush(string v); // 0x000000018D3D0814-0x000000018D3D08B4
			public bool TryPop(out string v); // 0x000000018D3D07A0-0x000000018D3D0814
			public void Clear(); // 0x000000018D3D077C-0x000000018D3D07A0
		}
	
		public interface IKeyGetter<TValue, TKey> // TypeDefIndex: 83333
		{
			// Methods
			TKey Get(ref ref TValue v);
		}
	
		internal struct DefaultKeyGetter<T> : IKeyGetter<T, T> // TypeDefIndex: 83334
		{
			// Methods
			public T Get(ref ref T v);
		}
	
		internal struct UintKeyGetter : IKeyGetter<uint, uint> // TypeDefIndex: 83335
		{
			// Methods
			public uint Get(ref uint v); // 0x000000018724EEA0-0x000000018724EEB0
		}
	
		// Methods
		private static void CalculateRadixParams(int radixBits, out int bitStates); // 0x000000018D3C9664-0x000000018D3C96DC
		private static int CalculateRadixSupportSize(int bitStates, int arrayLength); // 0x000000018725E240-0x000000018725E250
		private static unsafe void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, uint* supportArray, out uint* bucketIndices, out uint* bucketSizes, out uint* bucketPrefix, out uint* arrayOutput); // 0x000000018725E200-0x000000018725E240
		private static unsafe void MergeSort(uint* array, uint* support, int length); // 0x000000018D3C9A04-0x000000018D3C9BAC
		public static void MergeSort(uint[] arr, int sortSize, ref uint[] supportArray); // 0x000000018D3C9BAC-0x000000018D3C9C9C
		public static void MergeSort(NativeArray<uint> arr, Unity.Collections.Allocator arrAllocator, int sortSize, ref NativeArray<uint> supportArray); // 0x000000018D3C9C9C-0x000000018D3C9D6C
		private static unsafe void InsertionSort(uint* arr, int length); // 0x000000018D3C993C-0x000000018D3C9980
		public static void InsertionSort(uint[] arr, int sortSize); // 0x000000018D3C9980-0x000000018D3C9A04
		public static void InsertionSort(NativeArray<uint> arr, int sortSize); // 0x000000018D3C98C4-0x000000018D3C993C
		private static unsafe void RadixSort(uint* array, uint* support, int radixBits, int bitStates, int length); // 0x000000018D3C9DE4-0x000000018D3C9FA4
		public static void RadixSort(uint[] arr, int sortSize, ref uint[] supportArray, int radixBits = 8 /* Metadata: 0x02641FD0 */); // 0x000000018D3CA094-0x000000018D3CA1A8
		public static void RadixSort(NativeArray<uint> array, int sortSize, ref NativeArray<uint> supportArray, Unity.Collections.Allocator supportArrayAllocator, int radixBits = 8 /* Metadata: 0x02641FD1 */); // 0x000000018D3C9FA4-0x000000018D3CA094
		public static void QuickSort(uint[] arr, int left, int right); // 0x000000018D3C9D6C-0x000000018D3C9DE4
		public static unsafe void QuickSort<T>(int count, void* data)
			where T : struct, IComparable<T>;
		public static unsafe void QuickSort<TValue, TKey, TGetter>(int count, void* data)
			where TValue : struct
			where TKey : struct, IComparable<TKey>
			where TGetter : struct, IKeyGetter<TValue, TKey>;
		public static unsafe void QuickSort<TValue, TKey, TGetter>(void* data, int left, int right)
			where TValue : struct
			where TKey : struct, IComparable<TKey>
			where TGetter : struct, IKeyGetter<TValue, TKey>;
		public static unsafe int IndexOf<T>(void* data, int count, T v)
			where T : struct, IEquatable<T>;
		public static unsafe int CompareHashes<TOldValue, TOldGetter, TNewValue, TNewGetter>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount)
			where TOldValue : struct
			where TOldGetter : struct, IKeyGetter<TOldValue, Hash128>
			where TNewValue : struct
			where TNewGetter : struct, IKeyGetter<TNewValue, Hash128>;
		public static unsafe int CompareHashes(int oldHashCount, Hash128* oldHashes, int newHashCount, Hash128* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount); // 0x000000018D3C9734-0x000000018D3C97A4
		public static unsafe void CombineHashes<TValue, TGetter>(int count, void* hashes, Hash128* outHash)
			where TValue : struct
			where TGetter : struct, IKeyGetter<TValue, Hash128>;
		public static unsafe void CombineHashes(int count, Hash128* hashes, Hash128* outHash); // 0x000000018D3C96DC-0x000000018D3C9734
		private static unsafe int Partition<TValue, TKey, TGetter>(void* data, int left, int right)
			where TValue : struct
			where TKey : struct, IComparable<TKey>
			where TGetter : struct, IKeyGetter<TValue, TKey>;
		public static bool HaveDuplicates(int[] arr); // 0x000000018D3C97A4-0x000000018D3C98C4
	
		// Extension methods
		public static unsafe void CopyTo<T>(this List<T> list, void* dest, int count)
			where T : struct;
		public static unsafe void CopyTo<T>(this T[] list, void* dest, int count)
			where T : struct;
	}

	public class DynamicArray<T> // TypeDefIndex: 83337
		where T : new()
	{
		// Fields
		private T[] m_Array;
		[CompilerGenerated]
		private int _size_k__BackingField;
	
		// Properties
		public int size { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int capacity { get; }
		public ref T this[int index] { get => default; }
	
		// Constructors
		public DynamicArray();
		public DynamicArray(int size);
	
		// Methods
		public void Clear();
		public bool Contains(T item);
		public int Add([IsReadOnly] in ref T value);
		public void AddRange(DynamicArray<T> array);
		public bool Remove(T item);
		public void RemoveAt(int index);
		public void RemoveRange(int index, int count);
		public int FindIndex(int startIndex, int count, Predicate<T> match);
		public int IndexOf(T item, int index, int count);
		public int IndexOf(T item, int index);
		public int IndexOf(T item);
		public void Resize(int newSize, bool keepContent = false /* Metadata: 0x02641FD2 */);
		public void Reserve(int newCapacity, bool keepContent = false /* Metadata: 0x02641FD3 */);
		public static implicit operator T[](DynamicArray<T> array);
	}

	public static class DynamicArrayExtensions // TypeDefIndex: 83338
	{
		// Methods
		private static int Partition<T>(T[] data, int left, int right)
			where T : IComparable<T>, new();
		private static void QuickSort<T>(T[] data, int left, int right)
			where T : IComparable<T>, new();
	
		// Extension methods
		public static void QuickSort<T>(this DynamicArray<T> array)
			where T : IComparable<T>, new();
	}

	public delegate float PerformDynamicRes(); // TypeDefIndex: 83339; 0x0000000185B44B70-0x0000000185B44B80

	public enum DynamicResScalePolicyType // TypeDefIndex: 83340
	{
		ReturnsPercentage = 0,
		ReturnsMinMaxLerpFactor = 1
	}

	public enum DynamicResScalerSlot // TypeDefIndex: 83341
	{
		User = 0,
		System = 1,
		Count = 2
	}

	public class DynamicResolutionHandler // TypeDefIndex: 83344
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
		[CompilerGenerated]
		private DynamicResUpscaleFilter _filter_k__BackingField; // 0x44
		private static Dictionary<int, DynamicResUpscaleFilter> s_CameraUpscaleFilters; // 0x10
		[CompilerGenerated]
		private Vector2Int _finalViewport_k__BackingField; // 0x48
		private DynamicResolutionType type; // 0x50
		private GlobalDynamicResolutionSettings m_CachedSettings; // 0x54
		private const int CameraDictionaryMaxcCapacity = 32; // Metadata: 0x02641FDC
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
		public DynamicResUpscaleFilter filter { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226ED80-0x000000018226ED90 0x000000018226ED90-0x000000018226EDA0
		public Vector2Int finalViewport { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EE80-0x000000018226EE90 0x00000001857AFED0-0x00000001857AFEE0
		public bool runUpscalerFilterOnFullResolution { get; set; } // 0x000000018D3D0188-0x000000018D3D019C 0x000000018225E0E0-0x000000018225E0F0
		public UpsamplerScheduleType upsamplerSchedule { get; set; } // 0x0000000187233450-0x0000000187233460 0x0000000185B8E410-0x0000000185B8E660
		public static DynamicResolutionHandler instance { get; } // 0x000000018D3D0154-0x000000018D3D0188 
	
		// Nested types
		private struct ScalerContainer // TypeDefIndex: 83342
		{
			// Fields
			public DynamicResScalePolicyType type; // 0x00
			public PerformDynamicRes method; // 0x08
		}
	
		public enum UpsamplerScheduleType // TypeDefIndex: 83343
		{
			BeforePost = 0,
			AfterPost = 1
		}
	
		// Constructors
		private DynamicResolutionHandler(); // 0x0000000186B77300-0x0000000186B77350
		static DynamicResolutionHandler(); // 0x0000000186B76F40-0x0000000186B77270
	
		// Methods
		private void Reset(); // 0x0000000186B774D0-0x0000000186B77520
		private bool FlushScalableBufferManagerState(); // 0x000000018D3CF1BC-0x000000018D3CF2C8
		private static DynamicResolutionHandler GetOrCreateDrsInstanceHandler(Camera camera); // 0x000000018D3CF2E4-0x000000018D3CF7C8
		private static float DefaultDynamicResMethod(); // 0x0000000187235D20-0x0000000187235D30
		private void ProcessSettings(GlobalDynamicResolutionSettings settings); // 0x000000018D3CF828-0x000000018D3CF9F0
		public Vector2 GetResolvedScale(); // 0x000000018D3CF7C8-0x000000018D3CF828
		public float CalculateMipBias(Vector2Int inputResolution, Vector2Int outputResolution, bool forceApply = false /* Metadata: 0x02641FD9 */); // 0x00000001861D83D0-0x00000001861D8410
		public static void SetDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor /* Metadata: 0x02641FDA */); // 0x000000018D3CFA58-0x000000018D3CFAF4
		public static void SetSystemDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor /* Metadata: 0x02641FDB */); // 0x000000018D3CFAF4-0x000000018D3CFB94
		public static void SetActiveDynamicScalerSlot(DynamicResScalerSlot slot); // 0x000000018D3CFA04-0x000000018D3CFA58
		public static void ClearSelectedCamera(); // 0x00000001860F3FB0-0x00000001860F4030
		public static void SetUpscaleFilter(Camera camera, DynamicResUpscaleFilter filter); // 0x000000018D3CFB94-0x000000018D3CFCA8
		public void SetCurrentCameraRequest(bool cameraRequest); // 0x000000018225E0A0-0x000000018225E0B0
		public static void UpdateAndUseCamera(Camera camera, GlobalDynamicResolutionSettings? settings = default, Action OnResolutionChange = null); // 0x000000018D3CFCF4-0x000000018D3CFECC
		public void Update(GlobalDynamicResolutionSettings settings, Action OnResolutionChange = null); // 0x000000018D3CFECC-0x000000018D3D0154
		public bool SoftwareDynamicResIsEnabled(); // 0x000000018D3CFCA8-0x000000018D3CFCF4
		public bool HardwareDynamicResIsEnabled(); // 0x00000001871C7650-0x00000001871C7670
		public bool RequestsHardwareDynamicResolution(); // 0x000000018D3CF9F0-0x000000018D3CFA04
		public bool DynamicResolutionEnabled(); // 0x000000018D3CF188-0x000000018D3CF1BC
		public void ForceSoftwareFallback(); // 0x000000018723CE70-0x000000018723CE80
		public Vector2Int GetScaledSize(Vector2Int size); // 0x0000000186276070-0x0000000186276090
		public Vector2Int ApplyScalesOnSize(Vector2Int size); // 0x000000018D3CF09C-0x000000018D3CF0D0
		internal Vector2Int ApplyScalesOnSize(Vector2Int size, Vector2 scales); // 0x000000018D3CF0D0-0x000000018D3CF188
		public float GetCurrentScale(); // 0x000000018D3CF2C8-0x000000018D3CF2E4
		public Vector2Int GetLastScaledSize(); // 0x000000018725E260-0x000000018725E270
		public float GetLowResMultiplier(float targetLowRes); // 0x0000000186276040-0x0000000186276070
	}

	public enum DynamicResolutionType : byte // TypeDefIndex: 83345
	{
		Software = 0,
		Hardware = 1
	}

	public enum DynamicResUpscaleFilter : byte // TypeDefIndex: 83346
	{
		Bilinear = 0,
		CatmullRom = 1,
		Lanczos = 2,
		ContrastAdaptiveSharpen = 3,
		EdgeAdaptiveScalingUpres = 4,
		TAAU = 5
	}

	[Serializable]
	public struct GlobalDynamicResolutionSettings // TypeDefIndex: 83347
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
		public static GlobalDynamicResolutionSettings NewDefault(); // 0x0000000186B77480-0x0000000186B774D0
	}

	public interface IAdditionalData // TypeDefIndex: 83348
	{
	}

	public interface IVirtualTexturingEnabledRenderPipeline // TypeDefIndex: 83349
	{
		// Properties
		bool virtualTexturingEnabled { get; }
	}

	public struct ListBuffer<T> // TypeDefIndex: 83350
		where T : struct
	{
		// Fields
		private unsafe T* m_BufferPtr;
		private int m_Capacity;
		private unsafe int* m_CountPtr;
	
		// Properties
		internal unsafe T* BufferPtr { get; }
		public int Count { get; }
		public int Capacity { get; }
		public ref T this[[IsReadOnly] in int index] { get => default; }
	
		// Constructors
		public unsafe ListBuffer(T* bufferPtr, int* countPtr, int capacity);
	
		// Methods
		public ref ref T GetUnchecked([IsReadOnly] in int index);
		public bool TryAdd([IsReadOnly] in ref T value);
		public unsafe void CopyTo(T* dstBuffer, int startDstIndex, int copyCount);
		public bool TryCopyTo(ListBuffer<T> other);
		public unsafe bool TryCopyFrom(T* srcPtr, int count);
	}

	public static class ListBufferExtensions // TypeDefIndex: 83351
	{
		// Extension methods
		public static void QuickSort<T>(this ListBuffer<T> self)
			where T : struct, IComparable<T>;
	}

	public class ObjectPool<T> // TypeDefIndex: 83353
		where T : new()
	{
		// Fields
		private readonly Stack<T> m_Stack;
		private readonly UnityAction<T> m_ActionOnGet;
		private readonly UnityAction<T> m_ActionOnRelease;
		private readonly bool m_CollectionCheck;
		[CompilerGenerated]
		private int _countAll_k__BackingField;
	
		// Properties
		public int countAll { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int countActive { get; }
		public int countInactive { get; }
	
		// Nested types
		public struct PooledObject : IDisposable // TypeDefIndex: 83352
		{
			// Fields
			private readonly T m_ToReturn;
			private readonly ObjectPool<T> m_Pool;
	
			// Constructors
			internal PooledObject(T value, ObjectPool<T> pool);
	
			// Methods
			void IDisposable.Dispose();
		}
	
		// Constructors
		public ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease, bool collectionCheck = true /* Metadata: 0x02641FE7 */);
	
		// Methods
		public T Get();
		public PooledObject Get(out ref T v);
		public void Release(T element);
	}

	public static class GenericPool<T> // TypeDefIndex: 83354
		where T : new()
	{
		// Fields
		private static readonly ObjectPool<T> s_Pool;
	
		// Constructors
		static GenericPool();
	
		// Methods
		public static T Get();
		public static ObjectPool<T> Get(out ref T value);
		public static void Release(T toRelease);
	}

	public static class UnsafeGenericPool<T> // TypeDefIndex: 83355
		where T : new()
	{
		// Fields
		private static readonly ObjectPool<T> s_Pool;
	
		// Constructors
		static UnsafeGenericPool();
	
		// Methods
		public static T Get();
		public static ObjectPool<T> Get(out ref T value);
		public static void Release(T toRelease);
	}

	public static class ListPool<T> // TypeDefIndex: 83357
	{
		// Fields
		private static readonly ObjectPool<List<T>> s_Pool;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83356
		{
			// Fields
			public static readonly __c<T> __9;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _.cctor_b__4_0(List<T> l);
		}
	
		// Constructors
		static ListPool();
	
		// Methods
		public static List<T> Get();
		public static ObjectPool<List<T>> Get(out List<T> value);
		public static void Release(List<T> toRelease);
	}

	public static class HashSetPool<T> // TypeDefIndex: 83359
	{
		// Fields
		private static readonly ObjectPool<HashSet<T>> s_Pool;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83358
		{
			// Fields
			public static readonly __c<T> __9;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _.cctor_b__4_0(HashSet<T> l);
		}
	
		// Constructors
		static HashSetPool();
	
		// Methods
		public static HashSet<T> Get();
		public static ObjectPool<HashSet<T>> Get(out HashSet<T> value);
		public static void Release(HashSet<T> toRelease);
	}

	public static class DictionaryPool<TKey, TValue> // TypeDefIndex: 83361
	{
		// Fields
		private static readonly ObjectPool<Dictionary<TKey, TValue>> s_Pool;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83360
		{
			// Fields
			public static readonly __c<TKey, TValue> __9;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _.cctor_b__4_0(Dictionary<TKey, TValue> l);
		}
	
		// Constructors
		static DictionaryPool();
	
		// Methods
		public static Dictionary<TKey, TValue> Get();
		public static ObjectPool<Dictionary<TKey, TValue>> Get(out Dictionary<TKey, TValue> value);
		public static void Release(Dictionary<TKey, TValue> toRelease);
	}

	public sealed class ListChangedEventArgs<T> : EventArgs // TypeDefIndex: 83362
	{
		// Fields
		public readonly int index;
		public readonly T item;
	
		// Constructors
		public ListChangedEventArgs(int index, T item);
	}

	public delegate void ListChangedEventHandler<T>(ObservableList<T> sender, ListChangedEventArgs<T> e); // TypeDefIndex: 83363; 0x00000000-0x00000000

	public class ObservableList<T> : IList<T> // TypeDefIndex: 83364
	{
		// Fields
		private IList<T> m_List;
		[CompilerGenerated]
		private ListChangedEventHandler<T> ItemAdded;
		[CompilerGenerated]
		private ListChangedEventHandler<T> ItemRemoved;
	
		// Properties
		public T this[int index] { get => default; set {} }
		public int Count { get; }
		public bool IsReadOnly { get; }
	
		// Events
		public event ListChangedEventHandler<T> ItemAdded {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		public event ListChangedEventHandler<T> ItemRemoved {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Constructors
		public ObservableList();
		public ObservableList(int capacity);
		public ObservableList(IEnumerable<T> collection);
	
		// Methods
		private void OnEvent(ListChangedEventHandler<T> e, int index, T item);
		public bool Contains(T item);
		public int IndexOf(T item);
		public void Add(T item);
		public void Add(params T[] items);
		public void Insert(int index, T item);
		public bool Remove(T item);
		public int Remove(params T[] items);
		public void RemoveAt(int index);
		public void Clear();
		public void CopyTo(T[] array, int arrayIndex);
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	[Serializable]
	public class SerializableEnum // TypeDefIndex: 83365
	{
		// Fields
		[SerializeField]
		private string m_EnumValueAsString; // 0x10
		[SerializeField]
		private System.Type m_EnumType; // 0x18
	
		// Properties
		public Enum value { get; set; } // 0x000000018D3D6C70-0x000000018D3D6D1C 0x000000018D3D6D1C-0x000000018D3D6D4C
	
		// Constructors
		public SerializableEnum(System.Type enumType); // 0x000000018D3D6BEC-0x000000018D3D6C70
	}

	[Serializable]
	public class SerializedDictionary<K, V> : SerializedDictionary<K, V, K, V> // TypeDefIndex: 83366
	{
		// Constructors
		public SerializedDictionary();
	
		// Methods
		public override K SerializeKey(K key);
		public override V SerializeValue(V val);
		public override K DeserializeKey(K key);
		public override V DeserializeValue(V val);
	}

	[Serializable]
	public abstract class SerializedDictionary<K, V, SK, SV> : Dictionary<K, V>, ISerializationCallbackReceiver // TypeDefIndex: 83367
	{
		// Fields
		[SerializeField]
		private List<SK> m_Keys;
		[SerializeField]
		private List<SV> m_Values;
	
		// Constructors
		protected SerializedDictionary();
	
		// Methods
		public abstract SK SerializeKey(K key);
		public abstract SV SerializeValue(V value);
		public abstract K DeserializeKey(SK serializedKey);
		public abstract V DeserializeValue(SV serializedValue);
		public void OnBeforeSerialize();
		public void OnAfterDeserialize();
	}

	[Serializable]
	public class XRGraphics // TypeDefIndex: 83369
	{
		// Properties
		public static float eyeTextureResolutionScale { get; set; } // 0x000000018D3D8958-0x000000018D3D8984 0x000000018D3D8AB0-0x000000018D3D8AB8
		public static float renderViewportScale { get; } // 0x000000018D3D8A10-0x000000018D3D8A3C 
		public static bool enabled { get; } // 0x000000018D3D88C0-0x000000018D3D88C8 
		public static bool isDeviceActive { get; } // 0x000000018D3D89A8-0x000000018D3D89CC 
		public static string loadedDeviceName { get; } // 0x000000018D3D89CC-0x000000018D3D8A10 
		public static string[] supportedDevices { get; } // 0x000000018D3D8A64-0x000000018D3D8AB0 
		public static StereoRenderingMode stereoRenderingMode { get; } // 0x000000018D3D8A3C-0x000000018D3D8A64 
		public static RenderTextureDescriptor eyeTextureDesc { get; } // 0x000000018D3D88C8-0x000000018D3D8934 
		public static int eyeTextureWidth { get; } // 0x000000018D3D8984-0x000000018D3D89A8 
		public static int eyeTextureHeight { get; } // 0x000000018D3D8934-0x000000018D3D8958 
	
		// Nested types
		public enum StereoRenderingMode // TypeDefIndex: 83368
		{
			MultiPass = 0,
			SinglePass = 1,
			SinglePassInstanced = 2,
			SinglePassMultiView = 3
		}
	
		// Constructors
		public XRGraphics(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal enum DebugAction // TypeDefIndex: 83370
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

	internal enum DebugActionRepeatMode // TypeDefIndex: 83371
	{
		Never = 0,
		Delay = 1
	}

	public sealed class DebugManager // TypeDefIndex: 83373
	{
		// Fields
		private const string kEnableDebugBtn1 = "Enable Debug Button 1"; // Metadata: 0x02641FFB
		private const string kEnableDebugBtn2 = "Enable Debug Button 2"; // Metadata: 0x02642011
		private const string kDebugPreviousBtn = "Debug Previous"; // Metadata: 0x02642027
		private const string kDebugNextBtn = "Debug Next"; // Metadata: 0x02642036
		private const string kValidateBtn = "Debug Validate"; // Metadata: 0x02642041
		private const string kPersistentBtn = "Debug Persistent"; // Metadata: 0x02642050
		private const string kDPadVertical = "Debug Vertical"; // Metadata: 0x02642061
		private const string kDPadHorizontal = "Debug Horizontal"; // Metadata: 0x02642070
		private const string kMultiplierBtn = "Debug Multiplier"; // Metadata: 0x02642081
		private const string kResetBtn = "Debug Reset"; // Metadata: 0x02642092
		private const string kEnableDebug = "Enable Debug"; // Metadata: 0x0264209E
		private DebugActionDesc[] m_DebugActions; // 0x10
		private DebugActionState[] m_DebugActionStates; // 0x18
		private InputActionMap debugActionMap; // 0x20
		private static readonly Lazy<DebugManager> s_Instance; // 0x00
		private ReadOnlyCollection<DebugUI.Panel> m_ReadOnlyPanels; // 0x28
		private readonly List<DebugUI.Panel> m_Panels; // 0x30
		[CompilerGenerated]
		private Action<bool> onDisplayRuntimeUIChanged; // 0x38
		[CompilerGenerated]
		private Action onSetDirty; // 0x40
		[CompilerGenerated]
		private Action resetData; // 0x48
		public bool refreshEditorRequested; // 0x50
		private int? m_RequestedPanelIndex; // 0x54
		private GameObject m_Root; // 0x60
		private DebugUIHandlerCanvas m_RootUICanvas; // 0x68
		private GameObject m_PersistentRoot; // 0x70
		private DebugUIHandlerPersistentCanvas m_RootUIPersistentCanvas; // 0x78
		private bool m_EditorOpen; // 0x80
		private bool m_EnableRuntimeUI; // 0x81
	
		// Properties
		public static DebugManager instance { get; } // 0x0000000185BA21E0-0x0000000185BA2230 
		public ReadOnlyCollection<DebugUI.Panel> panels { get; } // 0x000000018D3CC928-0x000000018D3CC950 
		public bool displayEditorUI { get; } // 0x000000018226EFC0-0x000000018226EFD0 
		public bool enableRuntimeUI { get; set; } // 0x000000018723DD20-0x000000018723DD30 0x0000000185BA22B0-0x0000000185BA22E0
		public bool displayRuntimeUI { get; set; } // 0x0000000185BA2230-0x0000000185BA22B0 0x0000000185BA2480-0x0000000185BA2580
		public bool displayPersistentRuntimeUI { get; set; } // 0x000000018D3CC8B8-0x000000018D3CC928 0x0000000185BA2400-0x0000000185BA2480
	
		// Events
		public event Action<bool> onDisplayRuntimeUIChanged {
			add; // 0x000000018D3CC704-0x000000018D3CC790
			remove; // 0x000000018D3CC950-0x000000018D3CC9DC
		}
		public event Action onSetDirty {
			add; // 0x000000018D3CC790-0x000000018D3CC824
			remove; // 0x000000018D3CC9DC-0x000000018D3CCA70
		}
		private event Action resetData {
			add; // 0x000000018D3CC824-0x000000018D3CC8B8
			remove; // 0x000000018D3CCA70-0x000000018D3CCB04
		}
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83372
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<bool> __9__61_0; // 0x08
			public static Action __9__61_1; // 0x10
	
			// Constructors
			static __c(); // 0x00000001871E50C0-0x00000001871E5120
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _.ctor_b__61_0(bool _p0_); // 0x0000000186805BA0-0x0000000186805BB0
			internal void _.ctor_b__61_1(); // 0x0000000186805BA0-0x0000000186805BB0
			internal DebugManager _.cctor_b__81_0(); // 0x0000000186CD80E0-0x0000000186CD8130
		}
	
		// Constructors
		private DebugManager(); // 0x0000000186CD8130-0x0000000186CD83B0
		static DebugManager(); // 0x000000018702F450-0x000000018702F560
	
		// Methods
		private void RegisterActions(); // 0x000000018D3CB27C-0x000000018D3CB6D0
		internal void EnableInputActions(); // 0x000000018D3CA550-0x000000018D3CA668
		private void AddAction(DebugAction action, DebugActionDesc desc); // 0x000000018D3CA46C-0x000000018D3CA530
		private void SampleAction(int actionIndex); // 0x000000018D3CC378-0x000000018D3CC494
		private void UpdateAction(int actionIndex); // 0x000000018D3CC5EC-0x000000018D3CC644
		internal void UpdateActions(); // 0x000000018D3CC644-0x000000018D3CC690
		internal float GetAction(DebugAction action); // 0x000000018D3CAAD8-0x000000018D3CAB10
		internal bool GetActionToggleDebugMenuWithTouch(); // 0x000000018D3CA904-0x000000018D3CAAD8
		internal bool GetActionReleaseScrollTarget(); // 0x000000018D3CA838-0x000000018D3CA904
		private void RegisterInputs(); // 0x000000018D3CB700-0x000000018D3CC084
		private void UpdateReadOnlyCollection(); // 0x000000018D3CC690-0x000000018D3CC704
		public void ToggleEditorUI(bool open); // 0x000000018226EFD0-0x000000018226EFE0
		public void RefreshEditor(); // 0x0000000187259020-0x0000000187259030
		public void Reset(); // 0x000000018D3CC350-0x000000018D3CC378
		public void ReDrawOnScreenDebug(); // 0x000000018D3CB250-0x000000018D3CB27C
		public void RegisterData(IDebugData data); // 0x000000018D3CB6D0-0x000000018D3CB700
		public void UnregisterData(IDebugData data); // 0x000000018D3CC5BC-0x000000018D3CC5EC
		public int GetState(); // 0x000000018D3CB0F8-0x000000018D3CB234
		internal void RegisterRootCanvas(DebugUIHandlerCanvas root); // 0x000000018D3CC084-0x000000018D3CC0D0
		internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext); // 0x000000018D3CA530-0x000000018D3CA550
		internal void SetScrollTarget(DebugUIHandlerWidget widget); // 0x000000018D3CC494-0x000000018D3CC510
		private void EnsurePersistentCanvas(); // 0x000000018D3CA668-0x000000018D3CA838
		internal void TogglePersistent(DebugUI.Widget widget); // 0x000000018D3CC510-0x000000018D3CC5BC
		private void OnPanelDirty(DebugUI.Panel panel); // 0x000000018D3CB234-0x000000018D3CB250
		public void RequestEditorWindowPanelIndex(int index); // 0x000000018D3CC2FC-0x000000018D3CC350
		internal int? GetRequestedEditorWindowPanelIndex(); // 0x000000018725E250-0x000000018725E260
		public DebugUI.Panel GetPanel(string displayName, bool createIfNull = false /* Metadata: 0x02641FF8 */, int groupIndex = 0 /* Metadata: 0x02641FF9 */, bool overrideIfExist = false /* Metadata: 0x02641FFA */); // 0x000000018D3CAE08-0x000000018D3CB0F8
		public void RemovePanel(string displayName); // 0x000000018D3CC0D0-0x000000018D3CC298
		public void RemovePanel(DebugUI.Panel panel); // 0x000000018D3CC298-0x000000018D3CC2FC
		public DebugUI.Widget GetItem(string queryPath); // 0x000000018D3CACD4-0x000000018D3CAE08
		private DebugUI.Widget GetItem(string queryPath, DebugUI.IContainer container); // 0x000000018D3CAB10-0x000000018D3CACD4
	}

	internal class DebugActionDesc // TypeDefIndex: 83374
	{
		// Fields
		public InputAction buttonAction; // 0x10
		public DebugActionRepeatMode repeatMode; // 0x18
		public float repeatDelay; // 0x1C
	
		// Constructors
		public DebugActionDesc(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class DebugActionState // TypeDefIndex: 83376
	{
		// Fields
		private DebugActionKeyType m_Type; // 0x10
		private InputAction inputAction; // 0x18
		private bool[] m_TriggerPressedUp; // 0x20
		private float m_Timer; // 0x28
		[CompilerGenerated]
		private bool _runningAction_k__BackingField; // 0x2C
		[CompilerGenerated]
		private float _actionState_k__BackingField; // 0x30
	
		// Properties
		internal bool runningAction { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018224A5F0-0x000000018224A600 0x000000018224A600-0x000000018224A610
		internal float actionState { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233870-0x0000000187233880 0x0000000187233880-0x0000000187233890
	
		// Nested types
		private enum DebugActionKeyType // TypeDefIndex: 83375
		{
			Button = 0,
			Axis = 1,
			Key = 2
		}
	
		// Constructors
		public DebugActionState(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private void Trigger(int triggerCount, float state); // 0x000000018D3CA244-0x000000018D3CA2E4
		public void TriggerWithButton(InputAction action, float state); // 0x000000018D3CA1C0-0x000000018D3CA244
		private void Reset(); // 0x000000018D3CA1A8-0x000000018D3CA1C0
		public void Update(DebugActionDesc desc); // 0x000000018D3CA2E4-0x000000018D3CA46C
	}

	public interface IDebugData // TypeDefIndex: 83377
	{
		// Methods
		Action GetReset();
	}

	public class DebugShapes // TypeDefIndex: 83378
	{
		// Fields
		private static DebugShapes s_Instance; // 0x00
		private Mesh m_sphereMesh; // 0x10
		private Mesh m_boxMesh; // 0x18
		private Mesh m_coneMesh; // 0x20
		private Mesh m_pyramidMesh; // 0x28
	
		// Properties
		public static DebugShapes instance { get; } // 0x000000018D3CF018-0x000000018D3CF09C 
	
		// Constructors
		public DebugShapes(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private void BuildSphere(ref Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv); // 0x000000018D3CE7F8-0x000000018D3CEEE4
		private void BuildBox(ref Mesh outputMesh, float length, float width, float height); // 0x000000018D3CCB04-0x000000018D3CD744
		private void BuildCone(ref Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides); // 0x000000018D3CD744-0x000000018D3CE14C
		private void BuildPyramid(ref Mesh outputMesh, float width, float height, float depth); // 0x000000018D3CE14C-0x000000018D3CE660
		private void BuildShapes(); // 0x000000018D3CE660-0x000000018D3CE7F8
		private void RebuildResources(); // 0x000000018D3CEEE4-0x000000018D3CEFA8
		public Mesh RequestSphereMesh(); // 0x000000018D3CEFFC-0x000000018D3CF018
		public Mesh RequestBoxMesh(); // 0x000000018D3CEFA8-0x000000018D3CEFC4
		public Mesh RequestConeMesh(); // 0x000000018D3CEFC4-0x000000018D3CEFE0
		public Mesh RequestPyramidMesh(); // 0x000000018D3CEFE0-0x000000018D3CEFFC
	}

	public class DebugUI // TypeDefIndex: 83413
	{
		// Nested types
		public class Container : Widget, IContainer // TypeDefIndex: 83379
		{
			// Fields
			[CompilerGenerated]
			private ObservableList<Widget> _children_k__BackingField; // 0x48
	
			// Properties
			public ObservableList<Widget> children { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
			public override Panel panel { get; internal set; } // 0x00000001829260F0-0x0000000182926100 0x000000018D3C951C-0x000000018D3C9664
	
			// Constructors
			public Container(); // 0x000000018D3C92A8-0x000000018D3C9410
			public Container(string displayName, ObservableList<Widget> children); // 0x000000018D3C9410-0x000000018D3C951C
	
			// Methods
			internal override void GenerateQueryPath(); // 0x000000018D3C8F34-0x000000018D3C906C
			protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e); // 0x000000018D3C91DC-0x000000018D3C9240
			protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e); // 0x000000018D3C9240-0x000000018D3C92A8
			public override int GetHashCode(); // 0x000000018D3C906C-0x000000018D3C91DC
		}
	
		public class Foldout : Container, IValueField // TypeDefIndex: 83381
		{
			// Fields
			public bool opened; // 0x50
			public bool isHeader; // 0x51
			public List<ContextMenuItem> contextMenuItems; // 0x58
			[CompilerGenerated]
			private string[] _columnLabels_k__BackingField; // 0x60
			[CompilerGenerated]
			private string[] _columnTooltips_k__BackingField; // 0x68
	
			// Properties
			public bool isReadOnly { get; } // 0x00000001843FFFF0-0x0000000184400000 
			public string[] columnLabels { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
			public string[] columnTooltips { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
	
			// Nested types
			public struct ContextMenuItem // TypeDefIndex: 83380
			{
				// Fields
				public string displayName; // 0x00
				public Action action; // 0x08
			}
	
			// Constructors
			public Foldout(); // 0x000000018D3D09F8-0x000000018D3D0A00
			public Foldout(string displayName, ObservableList<Widget> children, string[] columnLabels = null, string[] columnTooltips = null); // 0x000000018D3D0A00-0x000000018D3D0A44
	
			// Methods
			public bool GetValue(); // 0x000000018225DFF0-0x000000018225E000
			object UnityEngine.Rendering.DebugUI.IValueField.GetValue(); // 0x000000018D3D09B4-0x000000018D3D09F8
			public void SetValue(object value); // 0x000000018D3D0968-0x000000018D3D09B4
			public object ValidateValue(object value); // 0x000000018459BB50-0x000000018459BB60
			public void SetValue(bool value); // 0x000000018225E000-0x000000018225E010
		}
	
		public class HBox : Container // TypeDefIndex: 83382
		{
			// Constructors
			public HBox(); // 0x000000018D3D18F4-0x000000018D3D193C
		}
	
		public class VBox : Container // TypeDefIndex: 83383
		{
			// Constructors
			public VBox(); // 0x000000018D3D86BC-0x000000018D3D8704
		}
	
		public class Table : Container // TypeDefIndex: 83385
		{
			// Fields
			public bool isReadOnly; // 0x50
			private bool[] m_Header; // 0x58
	
			// Properties
			public bool[] VisibleColumns { get; } // 0x000000018D3D7038-0x000000018D3D7250 
	
			// Nested types
			public class Row : Foldout // TypeDefIndex: 83384
			{
				// Constructors
				public Row(); // 0x000000018D3D6BA4-0x000000018D3D6BEC
			}
	
			// Constructors
			public Table(); // 0x000000018D3D6FF0-0x000000018D3D7038
	
			// Methods
			public void SetColumnVisibility(int index, bool visible); // 0x000000018D3D6FAC-0x000000018D3D6FF0
			public bool GetColumnVisibility(int index); // 0x000000018D3D6F1C-0x000000018D3D6F5C
			protected override void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e); // 0x000000018D3D6F5C-0x000000018D3D6F84
			protected override void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e); // 0x000000018D3D6F84-0x000000018D3D6FAC
		}
	
		[Flags]
		public enum Flags // TypeDefIndex: 83386
		{
			None = 0,
			EditorOnly = 2,
			RuntimeOnly = 4,
			EditorForceUpdate = 8
		}
	
		public abstract class Widget // TypeDefIndex: 83388
		{
			// Fields
			protected Panel m_Panel; // 0x10
			protected IContainer m_Parent; // 0x18
			[CompilerGenerated]
			private Flags _flags_k__BackingField; // 0x20
			[CompilerGenerated]
			private string _displayName_k__BackingField; // 0x28
			[CompilerGenerated]
			private string _tooltip_k__BackingField; // 0x30
			[CompilerGenerated]
			private string _queryPath_k__BackingField; // 0x38
			public Func<bool> isHiddenCallback; // 0x40
	
			// Properties
			public virtual Panel panel { get; internal set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
			public virtual IContainer parent { get; internal set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
			public Flags flags { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
			public string displayName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
			public string tooltip { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
			public string queryPath { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
			public bool isEditorOnly { get; } // 0x000000018D3D8844-0x000000018D3D884C 
			public bool isRuntimeOnly { get; } // 0x000000018D3D8888-0x000000018D3D8894 
			public bool isInactiveInEditor { get; } // 0x000000018D3D886C-0x000000018D3D8888 
			public bool isHidden { get; } // 0x000000018D3D884C-0x000000018D3D886C 
			public NameAndTooltip nameAndTooltip { set; } // 0x000000018D3D8894-0x000000018D3D88C0
	
			// Nested types
			public struct NameAndTooltip // TypeDefIndex: 83387
			{
				// Fields
				public string name; // 0x00
				public string tooltip; // 0x08
			}
	
			// Constructors
			protected Widget(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal virtual void GenerateQueryPath(); // 0x000000018D3D876C-0x000000018D3D8820
			public override int GetHashCode(); // 0x000000018D3D8820-0x000000018D3D8844
		}
	
		public interface IContainer // TypeDefIndex: 83389
		{
			// Properties
			ObservableList<Widget> children { get; }
			string displayName { get; set; }
			string queryPath { get; }
		}
	
		public interface IValueField // TypeDefIndex: 83390
		{
			// Methods
			object GetValue();
			void SetValue(object value);
			object ValidateValue(object value);
		}
	
		public class Button : Widget // TypeDefIndex: 83391
		{
			// Fields
			[CompilerGenerated]
			private Action _action_k__BackingField; // 0x48
	
			// Properties
			public Action action { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
	
			// Constructors
			public Button(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class Value : Widget // TypeDefIndex: 83392
		{
			// Fields
			[CompilerGenerated]
			private Func<object> _getter_k__BackingField; // 0x48
			public float refreshRate; // 0x50
	
			// Properties
			public Func<object> getter { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
	
			// Constructors
			public Value(); // 0x000000018D3D8724-0x000000018D3D876C
	
			// Methods
			public object GetValue(); // 0x000000018D3D8704-0x000000018D3D8724
		}
	
		public abstract class Field<T> : Widget, IValueField // TypeDefIndex: 83393
		{
			// Fields
			[CompilerGenerated]
			private Func<T> _getter_k__BackingField;
			[CompilerGenerated]
			private Action<T> _setter_k__BackingField;
			public Action<Field<T>, T> onValueChanged;
	
			// Properties
			public Func<T> getter { [CompilerGenerated] get; [CompilerGenerated] set; }
			public Action<T> setter { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			protected Field();
	
			// Methods
			object UnityEngine.Rendering.DebugUI.IValueField.ValidateValue(object value);
			public virtual T ValidateValue(T value);
			object UnityEngine.Rendering.DebugUI.IValueField.GetValue();
			public T GetValue();
			public void SetValue(object value);
			public void SetValue(T value);
		}
	
		public class BoolField : Field<bool> // TypeDefIndex: 83394
		{
			// Constructors
			public BoolField(); // 0x000000018D3C7558-0x000000018D3C7580
		}
	
		public class HistoryBoolField : BoolField // TypeDefIndex: 83395
		{
			// Fields
			[CompilerGenerated]
			private Func<bool>[] _historyGetter_k__BackingField; // 0x60
	
			// Properties
			public Func<bool>[] historyGetter { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
			public int historyDepth { get; } // 0x000000018D3D197C-0x000000018D3D198C 
	
			// Constructors
			public HistoryBoolField(); // 0x000000018D3D1974-0x000000018D3D197C
	
			// Methods
			public bool GetHistoryValue(int historyIndex); // 0x000000018D3D193C-0x000000018D3D1974
		}
	
		public class IntField : Field<int> // TypeDefIndex: 83396
		{
			// Fields
			public Func<int> min; // 0x60
			public Func<int> max; // 0x68
			public int incStep; // 0x70
			public int intStepMult; // 0x74
	
			// Constructors
			public IntField(); // 0x000000018D3D1A98-0x000000018D3D1AE4
	
			// Methods
			public override int ValidateValue(int value); // 0x000000018D3D1A48-0x000000018D3D1A98
		}
	
		public class UIntField : Field<uint> // TypeDefIndex: 83397
		{
			// Fields
			public Func<uint> min; // 0x60
			public Func<uint> max; // 0x68
			public uint incStep; // 0x70
			public uint intStepMult; // 0x74
	
			// Constructors
			public UIntField(); // 0x000000018D3D8670-0x000000018D3D86BC
	
			// Methods
			public override uint ValidateValue(uint value); // 0x000000018D3D8620-0x000000018D3D8670
		}
	
		public class FloatField : Field<float> // TypeDefIndex: 83398
		{
			// Fields
			public Func<float> min; // 0x60
			public Func<float> max; // 0x68
			public float incStep; // 0x70
			public float incStepMult; // 0x74
			public int decimals; // 0x78
	
			// Constructors
			public FloatField(); // 0x000000018D3D0928-0x000000018D3D0968
	
			// Methods
			public override float ValidateValue(float value); // 0x000000018D3D08DC-0x000000018D3D0928
		}
	
		private static class EnumUtility // TypeDefIndex: 83400
		{
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 83399
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<System.Reflection.FieldInfo, GUIContent> __9__0_0; // 0x08
	
				// Constructors
				static __c(); // 0x000000018D3D8558-0x000000018D3D85BC
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal GUIContent _MakeEnumNames_b__0_0(System.Reflection.FieldInfo fieldInfo); // 0x000000018D3D8384-0x000000018D3D84F4
			}
	
			// Methods
			internal static GUIContent[] MakeEnumNames(System.Type enumType); // 0x000000018D3D0548-0x000000018D3D0684
			internal static int[] MakeEnumValues(System.Type enumType); // 0x000000018D3D0684-0x000000018D3D077C
		}
	
		public class EnumField : Field<int> // TypeDefIndex: 83402
		{
			// Fields
			public GUIContent[] enumNames; // 0x60
			public int[] enumValues; // 0x68
			internal int[] quickSeparators; // 0x70
			internal int[] indexes; // 0x78
			[CompilerGenerated]
			private Func<int> _getIndex_k__BackingField; // 0x80
			[CompilerGenerated]
			private Action<int> _setIndex_k__BackingField; // 0x88
	
			// Properties
			public Func<int> getIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001828D49D0-0x00000001828D49E0 0x00000001870EAAE0-0x00000001870EAAF0
			public Action<int> setIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F50-0x0000000187232F60 0x0000000188800C74-0x0000000188800C88
			public int currentIndex { get; set; } // 0x000000018D3D04A4-0x000000018D3D04C8 0x000000018D3D0524-0x000000018D3D0548
			public System.Type autoEnum { set; } // 0x000000018D3D04C8-0x000000018D3D0524
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 83401
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<GUIContent, string> __9__17_0; // 0x08
	
				// Constructors
				static __c(); // 0x000000018D3D85BC-0x000000018D3D8620
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal string _InitQuickSeparators_b__17_0(GUIContent x); // 0x000000018D3D8310-0x000000018D3D8384
			}
	
			// Constructors
			public EnumField(); // 0x000000018D3D047C-0x000000018D3D04A4
	
			// Methods
			internal void InitQuickSeparators(); // 0x000000018D3D0258-0x000000018D3D047C
			internal void InitIndexes(); // 0x000000018D3D019C-0x000000018D3D0258
		}
	
		public class HistoryEnumField : EnumField // TypeDefIndex: 83403
		{
			// Fields
			[CompilerGenerated]
			private Func<int>[] _historyIndexGetter_k__BackingField; // 0x90
	
			// Properties
			public Func<int>[] historyIndexGetter { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271B70-0x0000000182271B80 0x0000000188800C9C-0x0000000188800CB0
			public int historyDepth { get; } // 0x000000018D3D19D0-0x000000018D3D19E4 
	
			// Constructors
			public HistoryEnumField(); // 0x000000018D3D19C8-0x000000018D3D19D0
	
			// Methods
			public int GetHistoryValue(int historyIndex); // 0x000000018D3D198C-0x000000018D3D19C8
		}
	
		public class BitField : Field<Enum> // TypeDefIndex: 83404
		{
			// Fields
			[CompilerGenerated]
			private GUIContent[] _enumNames_k__BackingField; // 0x60
			[CompilerGenerated]
			private int[] _enumValues_k__BackingField; // 0x68
			private System.Type m_EnumType; // 0x70
	
			// Properties
			public GUIContent[] enumNames { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
			public int[] enumValues { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
			public System.Type enumType { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x000000018D3C7500-0x000000018D3C7558
	
			// Constructors
			public BitField(); // 0x000000018D3C74D8-0x000000018D3C7500
		}
	
		public class ColorField : Field<UnityEngine.Color> // TypeDefIndex: 83405
		{
			// Fields
			public bool hdr; // 0x60
			public bool showAlpha; // 0x61
			public bool showPicker; // 0x62
			public float incStep; // 0x64
			public float incStepMult; // 0x68
			public int decimals; // 0x6C
	
			// Constructors
			public ColorField(); // 0x000000018D3C7ED0-0x000000018D3C7F18
	
			// Methods
			public override UnityEngine.Color ValidateValue(UnityEngine.Color value); // 0x000000018D3C7E74-0x000000018D3C7ED0
		}
	
		public class Vector2Field : Field<Vector2> // TypeDefIndex: 83406
		{
			// Fields
			public float incStep; // 0x60
			public float incStepMult; // 0x64
			public int decimals; // 0x68
	
			// Constructors
			public Vector2Field(); // 0x000000018D3E99D0-0x000000018D3E9A10
		}
	
		public class Vector3Field : Field<Vector3> // TypeDefIndex: 83407
		{
			// Fields
			public float incStep; // 0x60
			public float incStepMult; // 0x64
			public int decimals; // 0x68
	
			// Constructors
			public Vector3Field(); // 0x000000018D3E9A10-0x000000018D3E9A50
		}
	
		public class Vector4Field : Field<Vector4> // TypeDefIndex: 83408
		{
			// Fields
			public float incStep; // 0x60
			public float incStepMult; // 0x64
			public int decimals; // 0x68
	
			// Constructors
			public Vector4Field(); // 0x000000018D3E9A50-0x000000018D3E9A90
		}
	
		public class MessageBox : Widget // TypeDefIndex: 83410
		{
			// Fields
			public Style style; // 0x48
	
			// Nested types
			public enum Style // TypeDefIndex: 83409
			{
				Info = 0,
				Warning = 1,
				Error = 2
			}
	
			// Constructors
			public MessageBox(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class Panel : IContainer, IComparable<Panel> // TypeDefIndex: 83412
		{
			// Fields
			[CompilerGenerated]
			private Flags _flags_k__BackingField; // 0x10
			[CompilerGenerated]
			private string _displayName_k__BackingField; // 0x18
			[CompilerGenerated]
			private int _groupIndex_k__BackingField; // 0x20
			[CompilerGenerated]
			private ObservableList<Widget> _children_k__BackingField; // 0x28
			[CompilerGenerated]
			private Action<Panel> onSetDirty; // 0x30
	
			// Properties
			public Flags flags { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
			public string displayName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
			public int groupIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
			public string queryPath { get; } // 0x0000000182234E30-0x0000000182234E40 
			public bool isEditorOnly { get; } // 0x0000000185A370A0-0x0000000185A370B0 
			public bool isRuntimeOnly { get; } // 0x000000018D3E280C-0x000000018D3E2814 
			public bool isInactiveInEditor { get; } // 0x000000018D3E27F0-0x000000018D3E280C 
			public bool editorForceUpdate { get; } // 0x000000018D3E27E8-0x000000018D3E27F0 
			public ObservableList<Widget> children { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
	
			// Events
			public event Action<Panel> onSetDirty {
				add; // 0x000000018D3E275C-0x000000018D3E27E8
				remove; // 0x000000018D3E2814-0x000000018D3E28A0
			}
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 83411
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Action<Panel> __9__29_0; // 0x08
	
				// Constructors
				static __c(); // 0x000000018D3E9908-0x000000018D3E996C
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal void _.ctor_b__29_0(Panel _p0_); // 0x0000000186805BA0-0x0000000186805BB0
			}
	
			// Constructors
			public Panel(); // 0x000000018D3E254C-0x000000018D3E275C
	
			// Methods
			protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e); // 0x000000018D3E230C-0x000000018D3E2364
			protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e); // 0x000000018D3E2364-0x000000018D3E23C0
			public void SetDirty(); // 0x000000018D3E23C0-0x000000018D3E2520
			public override int GetHashCode(); // 0x000000018D3E219C-0x000000018D3E230C
			int System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(Panel other); // 0x000000018D3E2520-0x000000018D3E254C
		}
	
		// Constructors
		public DebugUI(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class DebugUpdater : MonoBehaviour // TypeDefIndex: 83416
	{
		// Fields
		private static DebugUpdater s_Instance; // 0x00
		private ScreenOrientation m_Orientation; // 0x18
		private bool m_RuntimeUiWasVisibleLastFrame; // 0x1C
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DoAfterInputModuleUpdated_d__9 : IEnumerator<object> // TypeDefIndex: 83414
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Action action; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _DoAfterInputModuleUpdated_d__9(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D3E968C-0x000000018D3E9748
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D3E9748-0x000000018D3E9794
		}
	
		[CompilerGenerated]
		private sealed class _RefreshRuntimeUINextFrame_d__15 : IEnumerator<object> // TypeDefIndex: 83415
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _RefreshRuntimeUINextFrame_d__15(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D3E9794-0x000000018D3E9820
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D3E9820-0x000000018D3E986C
		}
	
		// Constructors
		public DebugUpdater(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void RuntimeInit(); // 0x0000000186805BA0-0x0000000186805BB0
		internal static void SetEnabled(bool enabled); // 0x0000000185BA23E0-0x0000000185BA2400
		private static void EnableRuntime(); // 0x000000018D3DAF6C-0x000000018D3DB0D8
		private static void DisableRuntime(); // 0x0000000185BA22E0-0x0000000185BA23E0
		internal static void HandleInternalEventSystemComponents(bool uiEnabled); // 0x0000000185BA2580-0x0000000185BA2620
		private void EnsureExactlyOneEventSystem(); // 0x000000018D3DB0D8-0x000000018D3DB264
		[IteratorStateMachine(typeof(_DoAfterInputModuleUpdated_d__9))]
		private IEnumerator DoAfterInputModuleUpdated(Action action); // 0x000000018D3DAF10-0x000000018D3DAF6C
		private void CheckInputModuleExists(); // 0x000000018D3DAC28-0x000000018D3DAD00
		private void AssignDefaultActions(); // 0x000000018D3DAB08-0x000000018D3DAC28
		private void CreateDebugEventSystem(); // 0x000000018D3DAD00-0x000000018D3DADE0
		private void DestroyDebugEventSystem(); // 0x000000018D3DADE0-0x000000018D3DAF10
		private void Update(); // 0x000000018D3DB2A8-0x000000018D3DB3FC
		[IteratorStateMachine(typeof(_RefreshRuntimeUINextFrame_d__15))]
		private static IEnumerator RefreshRuntimeUINextFrame(); // 0x000000018D3DB264-0x000000018D3DB2A8
	}

	public class MousePositionDebug // TypeDefIndex: 83417
	{
		// Fields
		private static MousePositionDebug s_Instance; // 0x00
	
		// Properties
		public static MousePositionDebug instance { get; } // 0x0000000185B9EC10-0x0000000185B9ECA0 
	
		// Constructors
		public MousePositionDebug(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Build(); // 0x0000000186805BA0-0x0000000186805BB0
		public void Cleanup(); // 0x0000000186805BA0-0x0000000186805BB0
		public Vector2 GetMousePosition(float ScreenHeight, bool sceneView); // 0x000000018D3E1F90-0x000000018D3E1F98
		private Vector2 GetInputMousePosition(); // 0x000000018D3E1F20-0x000000018D3E1F90
		public Vector2 GetMouseClickPosition(float ScreenHeight); // 0x0000000185C8A5E0-0x0000000185C8A5F0
	}

	internal class TProfilingSampler<TEnum> : ProfilingSampler // TypeDefIndex: 83418
		where TEnum : Enum
	{
		// Fields
		internal static Dictionary<TEnum, TProfilingSampler<TEnum>> samples;
	
		// Constructors
		static TProfilingSampler();
		public TProfilingSampler(string name);
	}

	public class ProfilingSampler // TypeDefIndex: 83419
	{
		// Fields
		[CompilerGenerated]
		private CustomSampler _sampler_k__BackingField; // 0x10
		[CompilerGenerated]
		private CustomSampler _inlineSampler_k__BackingField; // 0x18
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x20
		private Recorder m_Recorder; // 0x28
		private Recorder m_InlineRecorder; // 0x30
	
		// Properties
		internal CustomSampler sampler { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		internal CustomSampler inlineSampler { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public string name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public bool enableRecording { set; } // 0x000000018D3E4100-0x000000018D3E4144
		public float gpuElapsedTime { get; } // 0x000000018D3E3FE0-0x000000018D3E4030 
		public int gpuSampleCount { get; } // 0x000000018D3E4030-0x000000018D3E4070 
		public float cpuElapsedTime { get; } // 0x000000018D3E3F50-0x000000018D3E3FA0 
		public int cpuSampleCount { get; } // 0x000000018D3E3FA0-0x000000018D3E3FE0 
		public float inlineCpuElapsedTime { get; } // 0x000000018D3E4070-0x000000018D3E40C0 
		public int inlineCpuSampleCount { get; } // 0x000000018D3E40C0-0x000000018D3E4100 
	
		// Constructors
		public ProfilingSampler(string name); // 0x0000000185D94C30-0x0000000185D94D30
		private ProfilingSampler(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static ProfilingSampler Get<TEnum>(TEnum marker)
			where TEnum : Enum;
		public void Begin(CommandBuffer cmd); // 0x000000018D3E3EC8-0x000000018D3E3F0C
		public void End(CommandBuffer cmd); // 0x000000018D3E3F0C-0x000000018D3E3F50
		internal bool IsValid(); // 0x000000018CD7FE94-0x000000018CD7FEA8
	}

	public struct ProfilingScope : IDisposable // TypeDefIndex: 83420
	{
		// Constructors
		public ProfilingScope(CommandBuffer cmd, ProfilingSampler sampler); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Obsolete("Please use ProfilingScope")]
	public struct ProfilingSample : IDisposable // TypeDefIndex: 83421
	{
		// Fields
		private readonly CommandBuffer m_Cmd; // 0x00
		private readonly string m_Name; // 0x08
		private bool m_Disposed; // 0x10
		private CustomSampler m_Sampler; // 0x18
	
		// Constructors
		public ProfilingSample(CommandBuffer cmd, string name, CustomSampler sampler = null); // 0x000000018D3E3D94-0x000000018D3E3E38
		public ProfilingSample(CommandBuffer cmd, string format, object arg); // 0x000000018D3E3E38-0x000000018D3E3E80
		public ProfilingSample(CommandBuffer cmd, string format, params object[] args); // 0x000000018D3E3E80-0x000000018D3E3EC8
	
		// Methods
		public void Dispose(); // 0x000000018D3E3D88-0x000000018D3E3D94
		private void Dispose(bool disposing); // 0x000000018D3E3D08-0x000000018D3E3D88
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, AllowMultiple = false)]
	[Conditional("UNITY_EDITOR")]
	public class CoreRPHelpURLAttribute : HelpURLAttribute // TypeDefIndex: 83422
	{
		// Constructors
		public CoreRPHelpURLAttribute(string pageName, string packageName = "com.unity.render-pipelines.core" /* Metadata: 0x026420B5 */); // 0x000000018D3DAADC-0x000000018D3DAB08
	}

	public class DocumentationInfo // TypeDefIndex: 83423
	{
		// Fields
		private const string fallbackVersion = "12.1"; // Metadata: 0x026420D5
		private const string url = "https://docs.unity3d.com/Packages/{0}@{1}/manual/{2}.html"; // Metadata: 0x026420DA
	
		// Properties
		public static string version { get; } // 0x000000018D3DB458-0x000000018D3DB484 
	
		// Constructors
		public DocumentationInfo(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static string GetPageLink(string packageName, string pageName); // 0x000000018D3DB3FC-0x000000018D3DB458
	}

	public static class DocumentationUtils // TypeDefIndex: 83424
	{
		// Methods
		public static string GetHelpURL<TEnum>(TEnum mask = default)
			where TEnum : struct, IConvertible;
	}

	public enum APVConstantBufferRegister // TypeDefIndex: 83425
	{
		GlobalRegister = 5
	}

	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "F:\\Build\\Release_v1d6\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\Lighting\\ProbeVolume\\ShaderVariablesProbeVolumes.cs", needAccessors = false, generateCBuffer = true, constantRegister = 5)]
	internal struct ShaderVariablesProbeVolumes // TypeDefIndex: 83426
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
	public struct SphericalHarmonicsL1 // TypeDefIndex: 83427
	{
		// Fields
		public Vector4 shAr; // 0x00
		public Vector4 shAg; // 0x10
		public Vector4 shAb; // 0x20
		public static readonly SphericalHarmonicsL1 zero; // 0x00
	
		// Constructors
		static SphericalHarmonicsL1(); // 0x000000018D3E4DF8-0x000000018D3E4E60
	
		// Methods
		public static SphericalHarmonicsL1 operator +(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs); // 0x000000018D3E4E60-0x000000018D3E4F18
		public static SphericalHarmonicsL1 operator -(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs); // 0x000000018D3E5264-0x000000018D3E531C
		public static SphericalHarmonicsL1 operator *(SphericalHarmonicsL1 lhs, float rhs); // 0x000000018D3E51D8-0x000000018D3E5264
		public static SphericalHarmonicsL1 operator /(SphericalHarmonicsL1 lhs, float rhs); // 0x000000018D3E4F18-0x000000018D3E5000
		public static bool operator ==(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs); // 0x000000018D3E5000-0x000000018D3E5144
		public static bool operator !=(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs); // 0x000000018D3E5144-0x000000018D3E51D8
		public override bool Equals(object other); // 0x000000018D3E4CC4-0x000000018D3E4DA8
		public override int GetHashCode(); // 0x000000018D3E4DA8-0x000000018D3E4DF8
	}

	public class SphericalHarmonicsL2Utils // TypeDefIndex: 83428
	{
		// Constructors
		public SphericalHarmonicsL2Utils(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void GetL1(SphericalHarmonicsL2 sh, out Vector3 L1_R, out Vector3 L1_G, out Vector3 L1_B); // 0x000000018D3E53A0-0x000000018D3E54C4
		public static void GetL2(SphericalHarmonicsL2 sh, out Vector3 L2_0, out Vector3 L2_1, out Vector3 L2_2, out Vector3 L2_3, out Vector3 L2_4); // 0x000000018D3E54C4-0x000000018D3E5690
		public static void SetL0(ref SphericalHarmonicsL2 sh, Vector3 L0); // 0x000000018D3E570C-0x000000018D3E5778
		public static void SetL1R(ref SphericalHarmonicsL2 sh, Vector3 L1_R); // 0x000000018D3E5860-0x000000018D3E58CC
		public static void SetL1G(ref SphericalHarmonicsL2 sh, Vector3 L1_G); // 0x000000018D3E57EC-0x000000018D3E5860
		public static void SetL1B(ref SphericalHarmonicsL2 sh, Vector3 L1_B); // 0x000000018D3E5778-0x000000018D3E57EC
		public static void SetL1(ref SphericalHarmonicsL2 sh, Vector3 L1_R, Vector3 L1_G, Vector3 L1_B); // 0x000000018D3E58CC-0x000000018D3E5954
		public static void SetCoefficient(ref SphericalHarmonicsL2 sh, int index, Vector3 coefficient); // 0x000000018D3E5690-0x000000018D3E570C
		public static Vector3 GetCoefficient(SphericalHarmonicsL2 sh, int index); // 0x000000018D3E531C-0x000000018D3E53A0
	}

	public sealed class LensFlareCommonSRP // TypeDefIndex: 83434
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
		public static LensFlareCommonSRP Instance { get; } // 0x00000001855E7D80-0x00000001855E7FA0 
		private List<LensFlareComponentSRP> Data { get; } // 0x000000018D3E1954-0x000000018D3E1988 
	
		// Nested types
		public struct SunSourceDirLightOverrideLensFlareData // TypeDefIndex: 83429
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
	
		public struct SunSourceDirLightOverrideLightData // TypeDefIndex: 83430
		{
			// Fields
			public Quaternion rotationLensFlare; // 0x00
			public Vector3 dirLightFoward; // 0x10
			public UnityEngine.Color color; // 0x1C
		}
	
		public struct SunSourceDirLightOverrideInfo // TypeDefIndex: 83431
		{
			// Fields
			public bool useOverrideLightData; // 0x00
			public Light dirLight; // 0x08
			public Entity dirLightEntity; // 0x10
			public SunSourceDirLightOverrideLensFlareData flareData; // 0x18
			public SunSourceDirLightOverrideLightData lightData; // 0x48
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass35_0 // TypeDefIndex: 83432
		{
			// Fields
			public LensFlareDataElementSRP element; // 0x00
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass35_1 // TypeDefIndex: 83433
		{
			// Fields
			public Vector2 screenPos; // 0x00
			public float position; // 0x08
			public float globalCos0; // 0x0C
			public float globalSin0; // 0x10
			public float combinedScale; // 0x14
			public float usedAspectRatio; // 0x18
		}
	
		// Constructors
		private LensFlareCommonSRP(); // 0x0000000186805BA0-0x0000000186805BB0
		static LensFlareCommonSRP(); // 0x0000000186F8DAC0-0x0000000186F8DC50
	
		// Methods
		public static void Initialize(); // 0x000000018D3E04D4-0x000000018D3E0674
		public static void Dispose(); // 0x000000018D3DCD4C-0x000000018D3DCDE8
		public List<LensFlareComponentSRP> GetData(); // 0x0000000187836F00-0x0000000187836F08
		public bool IsEmpty(); // 0x000000018D3E0674-0x000000018D3E0694
		public void AddData(LensFlareComponentSRP newData); // 0x000000018D3DBB7C-0x000000018D3DBBFC
		public static float ShapeAttenuationPointLight(); // 0x0000000187235D20-0x0000000187235D30
		public static float ShapeAttenuationDirLight(Vector3 forward, Vector3 wo); // 0x000000018D3E0CD4-0x000000018D3E0D18
		public static float ShapeAttenuationSpotConeLight(Vector3 forward, Vector3 wo, float spotAngle, float innerSpotPercent01); // 0x000000018D3E0D60-0x000000018D3E0E54
		public static float ShapeAttenuationSpotBoxLight(Vector3 forward, Vector3 wo); // 0x000000018D3E0D18-0x000000018D3E0D60
		public static float ShapeAttenuationSpotPyramidLight(Vector3 forward, Vector3 wo); // 0x000000018D3E0E54-0x000000018D3E0ED8
		public static float ShapeAttenuationAreaTubeLight(Vector3 lightPositionWS, Vector3 lightSide, float lightWidth, Camera cam); // 0x000000018D3E08BC-0x000000018D3E0CD4
		public static float ShapeAttenuationAreaRectangleLight(Vector3 forward, Vector3 wo); // 0x000000018D3E0840-0x000000018D3E08BC
		public static float ShapeAttenuationAreaDiscLight(Vector3 forward, Vector3 wo); // 0x000000018D3E07C4-0x000000018D3E0840
		public static Vector4 GetFlareData0(Vector2 screenPos, Vector2 translationScale, Vector2 rayOff0, Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, Vector2 positionOffset, bool autoRotate); // 0x000000018D3E01FC-0x000000018D3E043C
		public static Vector2 GetLensFlareRayOffset(Vector2 screenPos, float position, float globalCos0, float globalSin0); // 0x000000018D3E043C-0x000000018D3E04D4
		public static Vector3 WorldToViewport(Camera camera, bool isLocalLight, bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 positionWS); // 0x000000018D3E1818-0x000000018D3E1954
		private static Vector3 WorldToViewportLocal(bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 cameraPosWS, Vector3 positionWS); // 0x000000018D3E16B8-0x000000018D3E1818
		private static Vector3 WorldToViewportDistance(Camera cam, Vector3 positionWS); // 0x000000018D3E1528-0x000000018D3E16B8
		public static void ComputeOcclusion(Material lensFlareShader, LensFlareCommonSRP lensFlares, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4); // 0x000000018D3DBD30-0x000000018D3DCD4C
		public static void DoLensFlareDataDrivenCommon(Material lensFlareShader, LensFlareCommonSRP lensFlares, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, RenderTargetIdentifier colorBuffer, Func<Light, Camera, Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugFullScreen, ComputeBuffer debugFullscreenBuffer, SunSourceDirLightOverrideInfo dirLightOverrideInfo); // 0x000000018D3DCDE8-0x000000018D3E0044
		public void RemoveData(LensFlareComponentSRP data); // 0x000000018D3E0710-0x000000018D3E07C4
		private static Vector2 DoPaniniProjection(Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance); // 0x000000018D3E0044-0x000000018D3E01FC
		private static Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView); // 0x000000018D3DBCE4-0x000000018D3DBD30
		private static Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d); // 0x000000018D3DBBFC-0x000000018D3DBCE4
		private static Vector2 Panini_Generic_Inv(Vector2 projPos, float d); // 0x000000018D3E0694-0x000000018D3E0710
		[CompilerGenerated]
		internal static float _ShapeAttenuationAreaTubeLight_g__Fpo_26_0(float d, float l); // 0x000000018D3E14B4-0x000000018D3E150C
		[CompilerGenerated]
		internal static float _ShapeAttenuationAreaTubeLight_g__Fwt_26_1(float d, float l); // 0x000000018D3E150C-0x000000018D3E1528
		[CompilerGenerated]
		internal static float _ShapeAttenuationAreaTubeLight_g__DiffLineIntegral_26_2(Vector3 p1, Vector3 p2); // 0x000000018D3E10D8-0x000000018D3E14B4
		[CompilerGenerated]
		internal static Vector2 _DoLensFlareDataDrivenCommon_g__ComputeLocalSize_35_0(Vector2 rayOff, Vector2 rayOff0, Vector2 curSize, AnimationCurve distortionCurve, ref __c__DisplayClass35_0 param_000b2922, ref __c__DisplayClass35_1 param_000b2923); // 0x000000018D3E0ED8-0x000000018D3E10D8
		[CompilerGenerated]
		internal static float _DoLensFlareDataDrivenCommon_g__RandomRange_35_1(float min, float max); // 0x000000018BFFED4C-0x000000018BFFED54
	}

	[AddComponentMenu("Rendering/Lens Flare (SRP)")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public sealed class LensFlareComponentSRP : MonoBehaviour // TypeDefIndex: 83435
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
		public LensFlareDataSRP lensFlareData { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018D3E1EFC-0x000000018D3E1F20
	
		// Constructors
		public LensFlareComponentSRP(); // 0x000000018D3E1B60-0x000000018D3E1E48
		static LensFlareComponentSRP(); // 0x000000018D3E1B24-0x000000018D3E1B60
	
		// Methods
		public float celestialProjectedOcclusionRadius(Camera mainCam); // 0x000000018D3E1E48-0x000000018D3E1EFC
		private void OnEnable(); // 0x000000018D3E19E0-0x000000018D3E1A8C
		private void OnDisable(); // 0x000000018D3E1988-0x000000018D3E19E0
		private void OnValidate(); // 0x000000018D3E1A8C-0x000000018D3E1B24
	}

	[Serializable]
	public enum SRPLensFlareBlendMode // TypeDefIndex: 83436
	{
		Additive = 0,
		Screen = 1,
		Premultiply = 2,
		Lerp = 3
	}

	[Serializable]
	public enum SRPLensFlareDistribution // TypeDefIndex: 83437
	{
		Uniform = 0,
		Curve = 1,
		Random = 2
	}

	[Serializable]
	public enum SRPLensFlareType // TypeDefIndex: 83438
	{
		Image = 0,
		Circle = 1,
		Polygon = 2
	}

	[Serializable]
	public sealed class LensFlareDataElementSRP // TypeDefIndex: 83439
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
		public float localIntensity { get; set; } // 0x0000000187233330-0x0000000187233340 0x000000018783AA38-0x000000018783AA48
		public int count { get; set; } // 0x00000001872330A0-0x00000001872330B0 0x000000018783AA28-0x000000018783AA38
		public float intensityVariation { get; set; } // 0x0000000187253DD0-0x0000000187253DE0 0x000000018783AAB0-0x000000018783AAC4
		public float fallOff { get; set; } // 0x000000018724C020-0x000000018724C030 0x000000018783AA94-0x000000018783AAB0
		public float edgeOffset { get; set; } // 0x000000018723B6F0-0x000000018723B700 0x000000018783AA78-0x000000018783AA94
		public int sideCount { get; set; } // 0x000000018725E310-0x000000018725E320 0x000000018783AA64-0x000000018783AA78
		public float sdfRoundness { get; set; } // 0x000000018724C030-0x000000018724C040 0x000000018783AA48-0x000000018783AA64
	
		// Constructors
		public LensFlareDataElementSRP(); // 0x0000000185D90BA0-0x0000000185D91120
	}

	[Serializable]
	public sealed class LensFlareDataSRP : ScriptableObject // TypeDefIndex: 83440
	{
		// Fields
		public LensFlareDataElementSRP[] elements; // 0x18
	
		// Constructors
		public LensFlareDataSRP(); // 0x0000000187184FD0-0x0000000187185000
	}

	public abstract class RenderPipelineResources : ScriptableObject // TypeDefIndex: 83441
	{
		// Properties
		protected virtual string packagePath { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		internal string packagePath_Internal { get; } // 0x000000018783B1B4-0x000000018783B1C4 
	
		// Constructors
		protected RenderPipelineResources(); // 0x0000000185DD6260-0x0000000185DD6270
	}

	public enum PackingRules // TypeDefIndex: 83442
	{
		Exact = 0,
		Aggressive = 1
	}

	public enum FieldPacking // TypeDefIndex: 83443
	{
		NoPacking = 0,
		R11G11B10 = 1,
		PackedFloat = 2,
		PackedUint = 3
	}

	public enum FieldPrecision // TypeDefIndex: 83444
	{
		Half = 0,
		Real = 1,
		Default = 2
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
	public class GenerateHLSL : Attribute // TypeDefIndex: 83445
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
		public GenerateHLSL(PackingRules rules = PackingRules.Exact /* Metadata: 0x02642128 */, bool needAccessors = true /* Metadata: 0x02642129 */, bool needSetters = false /* Metadata: 0x0264212A */, bool needParamDebug = false /* Metadata: 0x0264212B */, int paramDefinesStart = 1 /* Metadata: 0x0264212C */, bool omitStructDeclaration = false /* Metadata: 0x0264212D */, bool containsPackedFields = false /* Metadata: 0x0264212E */, bool generateCBuffer = false /* Metadata: 0x0264212F */, int constantRegister = -1 /* Metadata: 0x02642130 */, [CallerFilePath] string sourcePath = null); // 0x000000018D3DB484-0x000000018D3DB4E4
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class SurfaceDataAttributes : Attribute // TypeDefIndex: 83446
	{
		// Fields
		public string[] displayNames; // 0x10
		public bool isDirection; // 0x18
		public bool sRGBDisplay; // 0x19
		public FieldPrecision precision; // 0x1C
		public bool checkIsNormalized; // 0x20
		public string preprocessor; // 0x28
	
		// Constructors
		public SurfaceDataAttributes(string displayName = "" /* Metadata: 0x02642131 */, bool isDirection = false /* Metadata: 0x02642132 */, bool sRGBDisplay = false /* Metadata: 0x02642133 */, FieldPrecision precision = FieldPrecision.Default /* Metadata: 0x02642134 */, bool checkIsNormalized = false /* Metadata: 0x02642135 */, string preprocessor = "" /* Metadata: 0x02642136 */); // 0x000000018D3E5954-0x000000018D3E5A04
		public SurfaceDataAttributes(string[] displayNames, bool isDirection = false /* Metadata: 0x02642137 */, bool sRGBDisplay = false /* Metadata: 0x02642138 */, FieldPrecision precision = FieldPrecision.Default /* Metadata: 0x02642139 */, bool checkIsNormalized = false /* Metadata: 0x0264213A */, string preprocessor = "" /* Metadata: 0x0264213B */); // 0x000000018D3E5A04-0x000000018D3E5A4C
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class HLSLArray : Attribute // TypeDefIndex: 83447
	{
		// Fields
		public int arraySize; // 0x10
		public System.Type elementType; // 0x18
	
		// Constructors
		public HLSLArray(int arraySize, System.Type elementType); // 0x0000000185CF10D0-0x0000000185CF1300
	}

	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
	public class PackingAttribute : Attribute // TypeDefIndex: 83448
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
		public PackingAttribute(string[] displayNames, FieldPacking packingScheme = FieldPacking.NoPacking /* Metadata: 0x0264213C */, int bitSize = 32 /* Metadata: 0x0264213D */, int offsetInSource = 0 /* Metadata: 0x0264213E */, float minValue = 0f /* Metadata: 0x0264213F */, float maxValue = 1f /* Metadata: 0x02642143 */, bool isDirection = false /* Metadata: 0x02642147 */, bool sRGBDisplay = false /* Metadata: 0x02642148 */, bool checkIsNormalized = false /* Metadata: 0x02642149 */, string preprocessor = "" /* Metadata: 0x0264214A */); // 0x000000018D3E1F98-0x000000018D3E2080
		public PackingAttribute(string displayName = "" /* Metadata: 0x0264214B */, FieldPacking packingScheme = FieldPacking.NoPacking /* Metadata: 0x0264214C */, int bitSize = 0 /* Metadata: 0x0264214D */, int offsetInSource = 0 /* Metadata: 0x0264214E */, float minValue = 0f /* Metadata: 0x0264214F */, float maxValue = 1f /* Metadata: 0x02642153 */, bool isDirection = false /* Metadata: 0x02642157 */, bool sRGBDisplay = false /* Metadata: 0x02642158 */, bool checkIsNormalized = false /* Metadata: 0x02642159 */, string preprocessor = "" /* Metadata: 0x0264215A */); // 0x000000018D3E2080-0x000000018D3E219C
	}

	public struct ShaderGenUInt4 // TypeDefIndex: 83449
	{
	}

	internal static class Hammersley // TypeDefIndex: 83458
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
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "F:\\Build\\Release_v1d6\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq16 // TypeDefIndex: 83451
		{
			// Fields
			[HLSLArray(16, typeof(Vector4))]
			public unsafe fixed /* 0x00000000-0x00000000 */ float hammersley2dSeq16[0]; // 0x00
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _hammersley2dSeq16_e__FixedBuffer // TypeDefIndex: 83450
			{
				// Fields
				public float FixedElementField; // 0x00
			}
		}
	
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "F:\\Build\\Release_v1d6\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq32 // TypeDefIndex: 83453
		{
			// Fields
			[HLSLArray(32, typeof(Vector4))]
			public unsafe fixed /* 0x00000000-0x00000000 */ float hammersley2dSeq32[0]; // 0x00
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _hammersley2dSeq32_e__FixedBuffer // TypeDefIndex: 83452
			{
				// Fields
				public float FixedElementField; // 0x00
			}
		}
	
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "F:\\Build\\Release_v1d6\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq64 // TypeDefIndex: 83455
		{
			// Fields
			[HLSLArray(64, typeof(Vector4))]
			public unsafe fixed /* 0x00000000-0x00000000 */ float hammersley2dSeq64[0]; // 0x00
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _hammersley2dSeq64_e__FixedBuffer // TypeDefIndex: 83454
			{
				// Fields
				public float FixedElementField; // 0x00
			}
		}
	
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "F:\\Build\\Release_v1d6\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq256 // TypeDefIndex: 83457
		{
			// Fields
			[HLSLArray(256, typeof(Vector4))]
			public unsafe fixed /* 0x00000000-0x00000000 */ float hammersley2dSeq256[0]; // 0x00
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _hammersley2dSeq256_e__FixedBuffer // TypeDefIndex: 83456
			{
				// Fields
				public float FixedElementField; // 0x00
			}
		}
	
		// Constructors
		static Hammersley(); // 0x000000018D3DB934-0x000000018D3DBB7C
	
		// Methods
		public static void Initialize(); // 0x000000018D3DB60C-0x000000018D3DB934
		public static void BindConstants(CommandBuffer cmd, ComputeShader cs); // 0x000000018D3DB4E4-0x000000018D3DB60C
	}

	public class BufferedRTHandleSystem : IDisposable // TypeDefIndex: 83459
	{
		// Fields
		private Dictionary<int, RTHandle[]> m_RTHandles; // 0x10
		private bool m_DisposedValue; // 0x18
	
		// Constructors
		public BufferedRTHandleSystem(); // 0x0000000186ED6F30-0x0000000186ED6FB0
	
		// Methods
		public RTHandle GetFrameRT(int bufferId, int frameIndex); // 0x000000018D3DA6CC-0x000000018D3DA76C
		public void AllocBuffer(int bufferId, Func<int, RTHandle> allocator, int bufferCount); // 0x000000018D3DA5B4-0x000000018D3DA6CC
		public void ReleaseBuffer(int bufferId); // 0x000000018D3DA7F4-0x000000018D3DA8C0
		public int GetNumFramesAllocated(int bufferId); // 0x000000018D3DA76C-0x000000018D3DA7F4
		private void Swap(); // 0x000000018D3DA8C0-0x000000018D3DAADC
		private void Dispose(bool disposing); // 0x0000000186BBDCF0-0x0000000186BBDD20
		public void Dispose(); // 0x0000000187838DFC-0x0000000187838E10
		public void ReleaseAll(); // 0x0000000186BBDD20-0x0000000186BBDEF0
	}

	public enum DepthBits // TypeDefIndex: 83460
	{
		None = 0,
		Depth8 = 8,
		Depth16 = 16,
		Depth24 = 24,
		Depth32 = 32
	}

	public enum MSAASamples // TypeDefIndex: 83461
	{
		None = 1,
		MSAA2x = 2,
		MSAA4x = 4,
		MSAA8x = 8
	}

	public class PowerOfTwoTextureAtlas : Texture2DAtlas // TypeDefIndex: 83464
	{
		// Fields
		private readonly int m_MipPadding; // 0x48
		private const float k_MipmapFactorApprox = 1.33f; // Metadata: 0x02642170
		private Dictionary<int, Vector2Int> m_RequestedTextures; // 0x50
	
		// Properties
		public int mipPadding { get; } // 0x00000001872330A0-0x00000001872330B0 
	
		// Nested types
		private enum BlitType // TypeDefIndex: 83462
		{
			Padding = 0,
			PaddingMultiply = 1,
			OctahedralPadding = 2,
			OctahedralPaddingMultiply = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83463
		{
			// Fields
			public static readonly __c __9; // 0x00
			[TupleElementNames(new string[2] {"instanceId", "size" })]
			public static Comparison<ValueTuple<int, Vector2Int>> __9__23_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D3E996C-0x000000018D3E99D0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _RelayoutEntries_b__23_0([TupleElementNames(new string[2] {"instanceId", "size" })] ValueTuple<int, Vector2Int> c1, [TupleElementNames(new string[2] {"instanceId", "size" })] ValueTuple<int, Vector2Int> c2); // 0x000000018D3E986C-0x000000018D3E98A4
		}
	
		// Constructors
		public PowerOfTwoTextureAtlas(int size, int mipPadding, GraphicsFormat format, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x02642164 */, string name = "" /* Metadata: 0x02642165 */, bool useMipMap = true /* Metadata: 0x02642166 */); // 0x000000018D3E3C0C-0x000000018D3E3D08
	
		// Methods
		private int GetTexturePadding(); // 0x000000018725E320-0x000000018725E350
		public Vector4 GetPayloadScaleOffset(Texture texture, [IsReadOnly] in Vector4 scaleOffset); // 0x000000018D3E33E4-0x000000018D3E3494
		public static Vector4 GetPayloadScaleOffset([IsReadOnly] in Vector2 textureSize, [IsReadOnly] in Vector2 paddingSize, [IsReadOnly] in Vector4 scaleOffset); // 0x000000018D3E32E8-0x000000018D3E33E4
		private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, BlitType blitType); // 0x000000018D3E2A44-0x000000018D3E2E2C
		public override void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x02642167 */, int overrideInstanceID = -1 /* Metadata: 0x02642168 */); // 0x000000018D3E30A8-0x000000018D3E317C
		public void BlitTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x02642169 */, int overrideInstanceID = -1 /* Metadata: 0x0264216A */); // 0x000000018D3E2FD4-0x000000018D3E30A8
		public override void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x0264216B */, int overrideInstanceID = -1 /* Metadata: 0x0264216C */); // 0x000000018D3E2F00-0x000000018D3E2FD4
		public void BlitOctahedralTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x0264216D */, int overrideInstanceID = -1 /* Metadata: 0x0264216E */); // 0x000000018D3E2E2C-0x000000018D3E2F00
		private void TextureSizeToPowerOfTwo(Texture texture, ref int width, ref int height); // 0x000000018D3E3BD8-0x000000018D3E3C0C
		private Vector2 GetPowerOfTwoTextureSize(Texture texture); // 0x000000018D3E3494-0x000000018D3E3514
		public override bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1 /* Metadata: 0x0264216F */); // 0x000000018D3E28A0-0x000000018D3E2A44
		public void ResetRequestedTexture(); // 0x000000018D3E3B90-0x000000018D3E3BD8
		public bool ReserveSpace(Texture texture); // 0x000000018D3E39AC-0x000000018D3E3A10
		public bool ReserveSpace(Texture texture, int width, int height); // 0x000000018D3E3B48-0x000000018D3E3B90
		public bool ReserveSpace(Texture textureA, Texture textureB, int width, int height); // 0x000000018D3E3B08-0x000000018D3E3B48
		private bool ReserveSpace(int id, int width, int height); // 0x000000018D3E3A10-0x000000018D3E3B08
		public bool RelayoutEntries(); // 0x000000018D3E3514-0x000000018D3E39AC
		public static long GetApproxCacheSizeInByte(int nbElement, int resolution, bool hasMipmap, GraphicsFormat format); // 0x000000018D3E317C-0x000000018D3E322C
		public static int GetMaxCacheSizeForWeightInByte(int weight, bool hasMipmap, GraphicsFormat format); // 0x000000018D3E322C-0x000000018D3E32E8
	}

	public class RTHandle // TypeDefIndex: 83465
	{
		// Fields
		internal RenderTexture m_RT; // 0x10
		internal Texture m_ExternalTexture; // 0x18
		internal RenderTargetIdentifier m_NameID; // 0x20
		internal bool m_EnableMSAA; // 0x48
		internal bool m_EnableRandomWrite; // 0x49
		internal string m_Name; // 0x50
	
		// Properties
		public RenderTexture rt { get; } // 0x00000001829260F0-0x0000000182926100 
		public RenderTargetIdentifier nameID { get; } // 0x000000018723C370-0x000000018723C390 
		public string name { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x000000018D3E4A78-0x000000018D3E4B30
		public bool isMSAAEnabled { get; } // 0x000000018223CB60-0x000000018223CB70 
	
		// Constructors
		public RTHandle(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static implicit operator RenderTargetIdentifier(RTHandle handle); // 0x000000018D3E49CC-0x000000018D3E4A10
		public static implicit operator Texture(RTHandle handle); // 0x000000018D3E4A10-0x000000018D3E4A78
		public static implicit operator RenderTexture(RTHandle handle); // 0x000000018566BC30-0x000000018566BC40
		public void SetRenderTexture(RenderTexture rt); // 0x00000001859F9D80-0x00000001859F9E00
		public void SetTexture(Texture tex); // 0x00000001859FB240-0x00000001859FB2C0
		public void SetTexture(RenderTargetIdentifier tex); // 0x000000018D3E488C-0x000000018D3E48D8
		public int GetInstanceID(); // 0x000000018D3E47E8-0x000000018D3E488C
		public void Release(); // 0x00000001859F7AA0-0x00000001859F7B50
		public void SwitchToFastMemory(CommandBuffer cmd, float residencyFraction = 1f /* Metadata: 0x02642178 */, FastMemoryFlags flags = FastMemoryFlags.None | FastMemoryFlags.SpillTop /* Metadata: 0x0264217C */, bool copyContents = false /* Metadata: 0x0264217D */); // 0x000000018D3E493C-0x000000018D3E49CC
		public void CopyToFastMemory(CommandBuffer cmd, float residencyFraction = 1f /* Metadata: 0x0264217E */, FastMemoryFlags flags = FastMemoryFlags.None | FastMemoryFlags.SpillTop /* Metadata: 0x02642182 */); // 0x000000018D3E47CC-0x000000018D3E47E8
		public void SwitchOutFastMemory(CommandBuffer cmd, bool copyContents = true /* Metadata: 0x02642183 */); // 0x000000018D3E48D8-0x000000018D3E493C
	}

	public static class RTHandles // TypeDefIndex: 83466
	{
		// Fields
		private static RTHandleSystem s_DefaultInstance; // 0x00
	
		// Constructors
		static RTHandles(); // 0x00000001871CA150-0x00000001871CA1C0
	
		// Methods
		public static RTHandle Alloc(int width, int height, int slices = 1 /* Metadata: 0x02642184 */, DepthBits depthBufferBits = DepthBits.None /* Metadata: 0x02642185 */, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB /* Metadata: 0x02642186 */, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x02642187 */, TextureWrapMode wrapMode = TextureWrapMode.Repeat /* Metadata: 0x02642188 */, TextureDimension dimension = TextureDimension.Tex2D /* Metadata: 0x02642189 */, bool enableRandomWrite = false /* Metadata: 0x0264218A */, bool useMipMap = false /* Metadata: 0x0264218B */, bool autoGenerateMips = true /* Metadata: 0x0264218C */, bool isShadowMap = false /* Metadata: 0x0264218D */, int anisoLevel = 1 /* Metadata: 0x0264218E */, float mipMapBias = 0f /* Metadata: 0x0264218F */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x02642193 */, bool bindTextureMS = false /* Metadata: 0x02642194 */, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None /* Metadata: 0x02642195 */, string name = "" /* Metadata: 0x02642196 */); // 0x00000001859F9220-0x00000001859F92F0
		public static RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = TextureWrapMode.Repeat /* Metadata: 0x02642197 */, int slices = 1 /* Metadata: 0x02642198 */, DepthBits depthBufferBits = DepthBits.None /* Metadata: 0x02642199 */, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB /* Metadata: 0x0264219A */, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x0264219B */, TextureDimension dimension = TextureDimension.Tex2D /* Metadata: 0x0264219C */, bool enableRandomWrite = false /* Metadata: 0x0264219D */, bool useMipMap = false /* Metadata: 0x0264219E */, bool autoGenerateMips = true /* Metadata: 0x0264219F */, bool isShadowMap = false /* Metadata: 0x026421A0 */, int anisoLevel = 1 /* Metadata: 0x026421A1 */, float mipMapBias = 0f /* Metadata: 0x026421A2 */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x026421A6 */, bool bindTextureMS = false /* Metadata: 0x026421A7 */, bool useDynamicScale = false /* Metadata: 0x026421A8 */, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None /* Metadata: 0x026421A9 */, string name = "" /* Metadata: 0x026421AA */); // 0x000000018D3E4B30-0x000000018D3E4C04
		public static RTHandle Alloc(Texture tex); // 0x0000000187838D1C-0x0000000187838D24
		public static RTHandle Alloc(RenderTexture tex); // 0x000000018D3E4CBC-0x000000018D3E4CC4
		public static RTHandle Alloc(RenderTargetIdentifier tex); // 0x000000018D3E4C04-0x000000018D3E4C38
		public static RTHandle Alloc(RenderTargetIdentifier tex, string name); // 0x000000018D3E4C88-0x000000018D3E4CBC
		private static RTHandle Alloc(RTHandle tex); // 0x000000018D3E4C38-0x000000018D3E4C88
	}

	public class RTHandleSystem // TypeDefIndex: 83467
	{
		// Constructors
		public RTHandleSystem(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
		public static RTHandle Alloc(int width, int height, int slices = 1 /* Metadata: 0x026421AB */, DepthBits depthBufferBits = DepthBits.None /* Metadata: 0x026421AC */, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB /* Metadata: 0x026421AD */, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x026421AE */, TextureWrapMode wrapMode = TextureWrapMode.Repeat /* Metadata: 0x026421AF */, TextureDimension dimension = TextureDimension.Tex2D /* Metadata: 0x026421B0 */, bool enableRandomWrite = false /* Metadata: 0x026421B1 */, bool useMipMap = false /* Metadata: 0x026421B2 */, bool autoGenerateMips = true /* Metadata: 0x026421B3 */, bool isShadowMap = false /* Metadata: 0x026421B4 */, int anisoLevel = 1 /* Metadata: 0x026421B5 */, float mipMapBias = 0f /* Metadata: 0x026421B6 */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x026421BA */, bool bindTextureMS = false /* Metadata: 0x026421BB */, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None /* Metadata: 0x026421BC */, string name = "" /* Metadata: 0x026421BD */); // 0x00000001859F92F0-0x00000001859F93D0
		public static RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = TextureWrapMode.Repeat /* Metadata: 0x026421BE */, int slices = 1 /* Metadata: 0x026421BF */, DepthBits depthBufferBits = DepthBits.None /* Metadata: 0x026421C0 */, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB /* Metadata: 0x026421C1 */, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x026421C2 */, TextureDimension dimension = TextureDimension.Tex2D /* Metadata: 0x026421C3 */, bool enableRandomWrite = false /* Metadata: 0x026421C4 */, bool useMipMap = false /* Metadata: 0x026421C5 */, bool autoGenerateMips = true /* Metadata: 0x026421C6 */, bool isShadowMap = false /* Metadata: 0x026421C7 */, int anisoLevel = 1 /* Metadata: 0x026421C8 */, float mipMapBias = 0f /* Metadata: 0x026421C9 */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x026421CD */, bool bindTextureMS = false /* Metadata: 0x026421CE */, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None /* Metadata: 0x026421CF */, string name = "" /* Metadata: 0x026421D0 */); // 0x00000001859F93D0-0x00000001859F98E0
		private static RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, DepthBits depthBufferBits, GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, TextureWrapMode wrapMode, TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, MSAASamples msaaSamples, bool bindTextureMS, RenderTextureMemoryless memoryless, string name); // 0x000000018D3E4144-0x000000018D3E45FC
		public static RTHandle Alloc(RenderTexture texture); // 0x000000018D3E4658-0x000000018D3E46DC
		public static RTHandle Alloc(Texture texture); // 0x00000001859FB1B0-0x00000001859FB240
		public static RTHandle Alloc(RenderTargetIdentifier texture); // 0x000000018D3E45FC-0x000000018D3E4658
		public static RTHandle Alloc(RenderTargetIdentifier texture, string name); // 0x000000018D3E46DC-0x000000018D3E477C
		private static RTHandle Alloc(RTHandle tex); // 0x000000018D3E477C-0x000000018D3E47CC
	}

	internal class AtlasAllocator // TypeDefIndex: 83470
	{
		// Fields
		private AtlasNode m_Root; // 0x10
		private int m_Width; // 0x18
		private int m_Height; // 0x1C
		private bool powerOfTwoPadding; // 0x20
		private ObjectPool<AtlasNode> m_NodePool; // 0x28
	
		// Nested types
		private class AtlasNode // TypeDefIndex: 83468
		{
			// Fields
			public AtlasNode m_RightChild; // 0x10
			public AtlasNode m_BottomChild; // 0x18
			public Vector4 m_Rect; // 0x20
	
			// Constructors
			public AtlasNode(); // 0x000000018725E2C0-0x000000018725E2D0
	
			// Methods
			public AtlasNode Allocate(ref ObjectPool<AtlasNode> pool, int width, int height, bool powerOfTwoPadding); // 0x000000018D3D9888-0x000000018D3D9BCC
			public void Release(ref ObjectPool<AtlasNode> pool); // 0x000000018D3DA1C4-0x000000018D3DA290
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83469
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static UnityAction<AtlasNode> __9__6_0; // 0x08
			public static UnityAction<AtlasNode> __9__6_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D3E98A4-0x000000018D3E9908
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _.ctor_b__6_0(AtlasNode _); // 0x0000000186805BA0-0x0000000186805BB0
			internal void _.ctor_b__6_1(AtlasNode _); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public AtlasAllocator(int width, int height, bool potPadding); // 0x000000018D3D9450-0x000000018D3D96BC
	
		// Methods
		public bool Allocate(ref Vector4 result, int width, int height); // 0x000000018D3D9398-0x000000018D3D93F8
		public void Reset(); // 0x000000018D3D93F8-0x000000018D3D9450
	}

	public class Texture2DAtlas // TypeDefIndex: 83472
	{
		// Fields
		private protected const int kGPUTexInvalid = 0; // Metadata: 0x026421E3
		private protected const int kGPUTexValidMip0 = 1; // Metadata: 0x026421E4
		private protected const int kGPUTexValidMipAll = 2; // Metadata: 0x026421E5
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
		public static int maxMipLevelPadding { get; } // 0x000000018D3E7FF0-0x000000018D3E8040 
		public RTHandle AtlasTexture { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Nested types
		private enum BlitType // TypeDefIndex: 83471
		{
			Default = 0,
			CubeTo2DOctahedral = 1,
			SingleChannel = 2,
			CubeTo2DOctahedralSingleChannel = 3
		}
	
		// Constructors
		public Texture2DAtlas(int width, int height, GraphicsFormat format, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x026421D1 */, bool powerOfTwoPadding = false /* Metadata: 0x026421D2 */, string name = "" /* Metadata: 0x026421D3 */, bool useMipMap = true /* Metadata: 0x026421D4 */); // 0x000000018D3E7D20-0x000000018D3E7FF0
		static Texture2DAtlas(); // 0x000000018D3E7CCC-0x000000018D3E7D20
	
		// Methods
		public void Release(); // 0x000000018D3E79F0-0x000000018D3E7A28
		public void ResetAllocator(); // 0x000000018D3E7A28-0x000000018D3E7AA0
		public void ClearTarget(CommandBuffer cmd); // 0x000000018D3E6BE8-0x000000018D3E6D78
		private protected int GetTextureMipmapCount(int width, int height); // 0x000000018D3E7058-0x000000018D3E7090
		private protected bool Is2D(Texture texture); // 0x000000018D3E7090-0x000000018D3E7104
		private protected bool IsSingleChannelBlit(Texture source, Texture destination); // 0x000000018D3E7200-0x000000018D3E73D4
		private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, BlitType blitType); // 0x000000018D3E66B0-0x000000018D3E68D4
		private protected void MarkGPUTextureValid(int instanceId, bool mipAreValid = false /* Metadata: 0x026421D5 */); // 0x000000018D3E742C-0x000000018D3E7490
		private protected void MarkGPUTextureInvalid(int instanceId); // 0x000000018D3E73D4-0x000000018D3E742C
		public virtual void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x026421D6 */, int overrideInstanceID = -1 /* Metadata: 0x026421D7 */); // 0x000000018D3E6A90-0x000000018D3E6BE8
		public virtual void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x026421D8 */, int overrideInstanceID = -1 /* Metadata: 0x026421D9 */); // 0x000000018D3E6A38-0x000000018D3E6A90
		public virtual void BlitCubeTexture2D(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, bool blitMips = true /* Metadata: 0x026421DA */, int overrideInstanceID = -1 /* Metadata: 0x026421DB */); // 0x000000018D3E68D4-0x000000018D3E6A38
		public virtual bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1 /* Metadata: 0x026421DC */); // 0x000000018D3E64F4-0x000000018D3E66B0
		public bool AllocateTextureWithoutBlit(Texture texture, int width, int height, ref Vector4 scaleOffset); // 0x000000018D3E649C-0x000000018D3E64F4
		public virtual bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref Vector4 scaleOffset); // 0x000000018D3E6300-0x000000018D3E649C
		private protected int GetTextureHash(Texture textureA, Texture textureB); // 0x000000018D3E6F94-0x000000018D3E6FF4
		public int GetTextureID(Texture texture); // 0x000000018D3E7038-0x000000018D3E7058
		public int GetTextureID(Texture textureA, Texture textureB); // 0x000000018D3E6FF4-0x000000018D3E7038
		public bool IsCached(out Vector4 scaleOffset, Texture textureA, Texture textureB); // 0x000000018D3E7104-0x000000018D3E7144
		public bool IsCached(out Vector4 scaleOffset, Texture texture); // 0x000000018D3E71C4-0x000000018D3E7200
		public bool IsCached(out Vector4 scaleOffset, int id); // 0x000000018D3E7144-0x000000018D3E71C4
		internal Vector2Int GetCachedTextureSize(int id); // 0x000000018D3E6F28-0x000000018D3E6F94
		public virtual bool NeedsUpdate(Texture texture, bool needMips = false /* Metadata: 0x026421DD */); // 0x000000018D3E77EC-0x000000018D3E79F0
		public virtual bool NeedsUpdate(Texture textureA, Texture textureB, bool needMips = false /* Metadata: 0x026421DE */); // 0x000000018D3E7490-0x000000018D3E77EC
		public virtual bool AddTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture); // 0x000000018D3E6268-0x000000018D3E6300
		public virtual bool UpdateTexture(CommandBuffer cmd, Texture oldTexture, Texture newTexture, ref Vector4 scaleOffset, Vector4 sourceScaleOffset, bool updateIfNeeded = true /* Metadata: 0x026421DF */, bool blitMips = true /* Metadata: 0x026421E0 */); // 0x000000018D3E7AA0-0x000000018D3E7C18
		public virtual bool UpdateTexture(CommandBuffer cmd, Texture texture, ref Vector4 scaleOffset, bool updateIfNeeded = true /* Metadata: 0x026421E1 */, bool blitMips = true /* Metadata: 0x026421E2 */); // 0x000000018D3E7C18-0x000000018D3E7CCC
		internal bool EnsureTextureSlot(out bool isUploadNeeded, ref Vector4 scaleBias, int key, int width, int height); // 0x000000018D3E6D78-0x000000018D3E6F28
	}

	internal class AtlasAllocatorDynamic // TypeDefIndex: 83476
	{
		// Fields
		private int m_Width; // 0x10
		private int m_Height; // 0x14
		private AtlasNodePool m_Pool; // 0x18
		private short m_Root; // 0x20
		private Dictionary<int, short> m_NodeFromID; // 0x28
	
		// Nested types
		private class AtlasNodePool // TypeDefIndex: 83473
		{
			// Fields
			internal AtlasNode[] m_Nodes; // 0x10
			private short m_Next; // 0x18
			private short m_FreelistHead; // 0x1A
	
			// Constructors
			public AtlasNodePool(short capacity); // 0x000000018D3D9820-0x000000018D3D9888
	
			// Methods
			public void Dispose(); // 0x000000018D3D9808-0x000000018D3D9820
			public void Clear(); // 0x000000018725E290-0x000000018725E2A0
			public short AtlasNodeCreate(short parent); // 0x000000018D3D96BC-0x000000018D3D97BC
			public void AtlasNodeFree(short index); // 0x000000018D3D97BC-0x000000018D3D9808
		}
	
		private struct AtlasNode // TypeDefIndex: 83475
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
			private enum AtlasNodeFlags : uint // TypeDefIndex: 83474
			{
				IsOccupied = 1
			}
	
			// Constructors
			public AtlasNode(short self, short parent); // 0x000000018D3DA290-0x000000018D3DA2C4
	
			// Methods
			public bool IsOccupied(); // 0x000000018D3DA064-0x000000018D3DA06C
			public void SetIsOccupied(); // 0x000000018725E2B0-0x000000018725E2C0
			public void ClearIsOccupied(); // 0x000000018725E2A0-0x000000018725E2B0
			public bool IsLeafNode(); // 0x000000018D3D9FC4-0x000000018D3D9FD0
			public short Allocate(AtlasNodePool pool, int width, int height); // 0x000000018D3D9BCC-0x000000018D3D9FC4
			public void ReleaseChildren(AtlasNodePool pool); // 0x000000018D3DA120-0x000000018D3DA1C4
			public void ReleaseAndMerge(AtlasNodePool pool); // 0x000000018D3DA06C-0x000000018D3DA120
			public bool IsMergeNeeded(AtlasNodePool pool); // 0x000000018D3D9FD0-0x000000018D3DA064
		}
	
		// Constructors
		public AtlasAllocatorDynamic(int width, int height, int capacityAllocations); // 0x000000018D3D9254-0x000000018D3D9398
	
		// Methods
		public bool Allocate(out Vector4 result, int key, int width, int height); // 0x000000018D3D8B68-0x000000018D3D8C6C
		public void Release(int key); // 0x000000018D3D90D8-0x000000018D3D91A0
		public void Release(); // 0x000000018D3D91A0-0x000000018D3D9254
		public string DebugStringFromRoot(int depthMax = -1 /* Metadata: 0x026421EA */); // 0x000000018D3D906C-0x000000018D3D90D8
		private void DebugStringFromNode(ref string res, short n, int depthCurrent = 0 /* Metadata: 0x026421EB */, int depthMax = -1 /* Metadata: 0x026421EC */); // 0x000000018D3D8C6C-0x000000018D3D906C
	}

	internal class Texture2DAtlasDynamic // TypeDefIndex: 83477
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
		public RTHandle AtlasTexture { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		public Texture2DAtlasDynamic(int width, int height, int capacity, GraphicsFormat format); // 0x000000018D3E60B0-0x000000018D3E6268
		public Texture2DAtlasDynamic(int width, int height, int capacity, RTHandle atlasTexture); // 0x000000018D3E5F8C-0x000000018D3E60B0
	
		// Methods
		public void Release(); // 0x000000018D3E5EFC-0x000000018D3E5F34
		public void ResetAllocator(); // 0x000000018D3E5F34-0x000000018D3E5F8C
		public bool AddTexture(CommandBuffer cmd, out Vector4 scaleOffset, Texture texture); // 0x000000018D3E5A4C-0x000000018D3E5CCC
		public bool IsCached(out Vector4 scaleOffset, int key); // 0x000000018D3E5E30-0x000000018D3E5E94
		public bool EnsureTextureSlot(out bool isUploadNeeded, out Vector4 scaleOffset, int key, int width, int height); // 0x000000018D3E5CCC-0x000000018D3E5E30
		public void ReleaseTextureSlot(int key); // 0x000000018D3E5E94-0x000000018D3E5EFC
	}

	public static class TextureXR // TypeDefIndex: 83478
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
		public static int maxViews { set; } // 0x000000018D3E9638-0x000000018D3E968C
		public static int slices { get; } // 0x000000018D3E95E8-0x000000018D3E9638 
		public static bool useTexArray { get; } // 0x0000000186C196F0-0x0000000186C19720 
		public static TextureDimension dimension { get; } // 0x000000018D3E9594-0x000000018D3E95E8 
	
		// Constructors
		static TextureXR(); // 0x000000018721F930-0x000000018721F970
	
		// Methods
		public static RTHandle GetBlackUIntTexture(); // 0x000000018D3E8778-0x000000018D3E87EC
		public static RTHandle GetClearTexture(); // 0x000000018D3E87EC-0x000000018D3E8860
		public static RTHandle GetMagentaTexture(); // 0x000000018D3E8860-0x000000018D3E88D4
		public static RTHandle GetBlackTexture(); // 0x000000018D3E86FC-0x000000018D3E8778
		public static RTHandle GetBlackTextureArray(); // 0x000000018D3E86A8-0x000000018D3E86FC
		public static RTHandle GetBlackTexture3D(); // 0x000000018D3E8654-0x000000018D3E86A8
		public static RTHandle GetWhiteTexture(); // 0x000000018D3E88D4-0x000000018D3E8950
		public static void Initialize(CommandBuffer cmd, ComputeShader clearR32_UIntShader); // 0x000000018D3E8950-0x000000018D3E9594
		private static Texture2DArray CreateTexture2DArrayFromTexture2D(Texture2D source, string name); // 0x000000018D3E84E4-0x000000018D3E8654
		private static Texture CreateBlackUIntTextureArray(CommandBuffer cmd, ComputeShader clearR32_UIntShader); // 0x000000018D3E811C-0x000000018D3E8300
		private static Texture CreateBlackUintTexture(CommandBuffer cmd, ComputeShader clearR32_UIntShader); // 0x000000018D3E8300-0x000000018D3E84E4
		private static Texture3D CreateBlackTexture3D(string name); // 0x000000018D3E8040-0x000000018D3E811C
	}

	public static class ArrayExtensions // TypeDefIndex: 83479
	{
		// Methods
		public static void ResizeArray<T>(ref ref T[] array, int capacity);
		public static void Grow<T>(ref ref T[] array, int targetSize);
		public static void GrowToNearestPowerOf2<T>(ref ref T[] array, int targetSize);
		public static uint RoundUpToPowerOf2(uint n); // 0x000000018D3D8B44-0x000000018D3D8B68
	
		// Extension methods
		public static void ResizeArray<T>(this ref NativeArray<T> array, int capacity, Unity.Collections.Allocator allocator)
			where T : struct;
		public static void ResizeArray(this ref TransformAccessArray array, int capacity); // 0x000000018D3D8AB8-0x000000018D3D8B44
	}

	public interface IBitArray // TypeDefIndex: 83480
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
	public struct BitArray8 : IBitArray // TypeDefIndex: 83481
	{
		// Fields
		[SerializeField]
		private byte data; // 0x00
	
		// Properties
		public uint capacity { get; } // 0x0000000187239CB0-0x0000000187239CC0 
		public bool allFalse { get; } // 0x00000001857A8050-0x00000001857A8060 
		public bool allTrue { get; } // 0x000000018D3DA4D8-0x000000018D3DA4E0 
		public string humanizedData { get; } // 0x000000018D3DA4E0-0x000000018D3DA5A4 
		public bool this[uint index] { get => default; set {} } // 0x000000018D3DA4BC-0x000000018D3DA4D8 0x000000018D3DA5A4-0x000000018D3DA5B4
	
		// Constructors
		public BitArray8(byte initValue); // 0x0000000187233BE0-0x0000000187233BF0
		public BitArray8(IEnumerable<uint> bitIndexTrue); // 0x000000018D3DA42C-0x000000018D3DA4BC
	
		// Methods
		public static BitArray8 operator ~(BitArray8 a); // 0x000000018725E300-0x000000018725E310
		public static BitArray8 operator |(BitArray8 a, BitArray8 b); // 0x000000018725E2F0-0x000000018725E300
		public static BitArray8 operator &(BitArray8 a, BitArray8 b); // 0x000000018725E2E0-0x000000018725E2F0
		public IBitArray BitAnd(IBitArray other); // 0x000000018D3DA2C4-0x000000018D3DA328
		public IBitArray BitOr(IBitArray other); // 0x000000018D3DA370-0x000000018D3DA3D0
		public IBitArray BitNot(); // 0x000000018D3DA328-0x000000018D3DA370
		public static bool operator ==(BitArray8 a, BitArray8 b); // 0x00000001889F30F0-0x00000001889F30F8
		public static bool operator !=(BitArray8 a, BitArray8 b); // 0x00000001889F30F8-0x00000001889F3100
		public override bool Equals(object obj); // 0x000000018D3DA3D0-0x000000018D3DA42C
		public override int GetHashCode(); // 0x000000018725E2D0-0x000000018725E2E0
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray16 : IBitArray // TypeDefIndex: 83482
	{
		// Fields
		[SerializeField]
		private ushort data; // 0x00
	
		// Properties
		public uint capacity { get; } // 0x0000000187239D50-0x0000000187239D60 
		public bool allFalse { get; } // 0x000000018D2AA648-0x000000018D2AA650 
		public bool allTrue { get; } // 0x000000018D3EA080-0x000000018D3EA08C 
		public string humanizedData { get; } // 0x000000018D3EA08C-0x000000018D3EA1B4 
		public bool this[uint index] { get => default; set {} } // 0x000000018783C848-0x000000018783C858 0x000000018783AB20-0x000000018783AB30
	
		// Constructors
		public BitArray16(ushort initValue); // 0x000000018448B8B0-0x000000018448B8C0
		public BitArray16(IEnumerable<uint> bitIndexTrue); // 0x000000018D3E9FEC-0x000000018D3EA080
	
		// Methods
		public static BitArray16 operator ~(BitArray16 a); // 0x000000018725E420-0x000000018725E430
		public static BitArray16 operator |(BitArray16 a, BitArray16 b); // 0x000000018725E410-0x000000018725E420
		public static BitArray16 operator &(BitArray16 a, BitArray16 b); // 0x000000018725E400-0x000000018725E410
		public IBitArray BitAnd(IBitArray other); // 0x000000018D3E9E78-0x000000018D3E9EE0
		public IBitArray BitOr(IBitArray other); // 0x000000018D3E9F28-0x000000018D3E9F8C
		public IBitArray BitNot(); // 0x000000018D3E9EE0-0x000000018D3E9F28
		public static bool operator ==(BitArray16 a, BitArray16 b); // 0x000000018D3ABADC-0x000000018D3ABAE4
		public static bool operator !=(BitArray16 a, BitArray16 b); // 0x000000018D3EA1B4-0x000000018D3EA1BC
		public override bool Equals(object obj); // 0x000000018D3E9F8C-0x000000018D3E9FEC
		public override int GetHashCode(); // 0x000000018725E3F0-0x000000018725E400
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray32 : IBitArray // TypeDefIndex: 83483
	{
		// Fields
		[SerializeField]
		private uint data; // 0x00
	
		// Properties
		public uint capacity { get; } // 0x0000000187239C60-0x0000000187239C70 
		public bool allFalse { get; } // 0x0000000186535F00-0x0000000186535F10 
		public bool allTrue { get; } // 0x000000018D3EAB44-0x000000018D3EAB4C 
		private string humanizedVersion { get; } // 0x000000018D3EAC74-0x000000018D3EACC8 
		public string humanizedData { get; } // 0x000000018D3EAB4C-0x000000018D3EAC74 
		public bool this[uint index] { get => default; set {} } // 0x000000018D3EAB2C-0x000000018D3EAB44 0x000000018D3EACC8-0x000000018D3EACD8
	
		// Constructors
		public BitArray32(uint initValue); // 0x0000000184547F40-0x0000000184547F50
		public BitArray32(IEnumerable<uint> bitIndexTrue); // 0x000000018D3EAA9C-0x000000018D3EAB2C
	
		// Methods
		public IBitArray BitAnd(IBitArray other); // 0x000000018D3EA938-0x000000018D3EA99C
		public IBitArray BitOr(IBitArray other); // 0x000000018D3EA9E0-0x000000018D3EAA40
		public IBitArray BitNot(); // 0x000000018D3EA99C-0x000000018D3EA9E0
		public static BitArray32 operator ~(BitArray32 a); // 0x000000018725E560-0x000000018725E570
		public static BitArray32 operator |(BitArray32 a, BitArray32 b); // 0x000000018725E550-0x000000018725E560
		public static BitArray32 operator &(BitArray32 a, BitArray32 b); // 0x0000000187253620-0x0000000187253630
		public static bool operator ==(BitArray32 a, BitArray32 b); // 0x0000000189CCDE30-0x0000000189CCDE38
		public static bool operator !=(BitArray32 a, BitArray32 b); // 0x000000018CCE071C-0x000000018CCE0724
		public override bool Equals(object obj); // 0x000000018D3EAA40-0x000000018D3EAA9C
		public override int GetHashCode(); // 0x000000018725E540-0x000000018725E550
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray64 : IBitArray // TypeDefIndex: 83484
	{
		// Fields
		[SerializeField]
		private ulong data; // 0x00
	
		// Properties
		public uint capacity { get; } // 0x000000018723A490-0x000000018723A4A0 
		public bool allFalse { get; } // 0x00000001850BC1F0-0x00000001850BC200 
		public bool allTrue { get; } // 0x000000018D3EAEFC-0x000000018D3EAF04 
		public string humanizedData { get; } // 0x000000018D3EAF04-0x000000018D3EB02C 
		public bool this[uint index] { get => default; set {} } // 0x000000018D3EAEE4-0x000000018D3EAEFC 0x000000018D3EB02C-0x000000018D3EB03C
	
		// Constructors
		public BitArray64(ulong initValue); // 0x000000018561B5B0-0x000000018561B5C0
		public BitArray64(IEnumerable<uint> bitIndexTrue); // 0x000000018D3EAE4C-0x000000018D3EAEE4
	
		// Methods
		public static BitArray64 operator ~(BitArray64 a); // 0x000000018725E5A0-0x000000018725E5B0
		public static BitArray64 operator |(BitArray64 a, BitArray64 b); // 0x000000018725E590-0x000000018725E5A0
		public static BitArray64 operator &(BitArray64 a, BitArray64 b); // 0x000000018725E580-0x000000018725E590
		public IBitArray BitAnd(IBitArray other); // 0x000000018D3EACD8-0x000000018D3EAD40
		public IBitArray BitOr(IBitArray other); // 0x000000018D3EAD88-0x000000018D3EADEC
		public IBitArray BitNot(); // 0x000000018D3EAD40-0x000000018D3EAD88
		public static bool operator ==(BitArray64 a, BitArray64 b); // 0x0000000184F9DDF0-0x0000000184F9DE00
		public static bool operator !=(BitArray64 a, BitArray64 b); // 0x0000000184F9E9E0-0x0000000184F9E9F0
		public override bool Equals(object obj); // 0x000000018D3EADEC-0x000000018D3EAE4C
		public override int GetHashCode(); // 0x000000018725E570-0x000000018725E580
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray128 : IBitArray // TypeDefIndex: 83485
	{
		// Fields
		[SerializeField]
		private ulong data1; // 0x00
		[SerializeField]
		private ulong data2; // 0x08
	
		// Properties
		public ulong Data1 { get; } // 0x0000000184431970-0x0000000184431980 
		public ulong Data2 { get; } // 0x00000001844AFA30-0x00000001844AFA40 
		public uint capacity { get; } // 0x000000018725E380-0x000000018725E390 
		public bool allFalse { get; } // 0x000000018D3E9C90-0x000000018D3E9CA4 
		public bool allTrue { get; } // 0x000000018D3E9CA4-0x000000018D3E9CB8 
		public string humanizedData { get; } // 0x000000018D3E9CB8-0x000000018D3E9E78 
		public bool this[uint index] { get => default; set {} } // 0x0000000187834A04-0x0000000187834A18 0x0000000187834A18-0x0000000187834A40
	
		// Constructors
		public BitArray128(ulong initValue1, ulong initValue2); // 0x0000000187232F10-0x0000000187232F20
		public BitArray128(IEnumerable<uint> bitIndexTrue); // 0x0000000185F6A6D0-0x0000000185F6A790
	
		// Methods
		public static BitArray128 operator ~(BitArray128 a); // 0x000000018725E3D0-0x000000018725E3F0
		public static BitArray128 operator |(BitArray128 a, BitArray128 b); // 0x000000018725E3B0-0x000000018725E3D0
		public static BitArray128 operator &(BitArray128 a, BitArray128 b); // 0x000000018725E390-0x000000018725E3B0
		public IBitArray BitAnd(IBitArray other); // 0x000000018D3E9A90-0x000000018D3E9B24
		public IBitArray BitOr(IBitArray other); // 0x000000018D3E9B84-0x000000018D3E9C18
		public IBitArray BitNot(); // 0x000000018D3E9B24-0x000000018D3E9B84
		public static bool operator ==(BitArray128 a, BitArray128 b); // 0x0000000188AAD4AC-0x0000000188AAD4C4
		public static bool operator !=(BitArray128 a, BitArray128 b); // 0x0000000188AAD4C4-0x0000000188AAD4DC
		public override bool Equals(object obj); // 0x000000018D3E9C18-0x000000018D3E9C90
		public override int GetHashCode(); // 0x000000018725E350-0x000000018725E380
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray256 : IBitArray // TypeDefIndex: 83486
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
		public uint capacity { get; } // 0x000000018725E480-0x000000018725E490 
		public bool allFalse { get; } // 0x000000018D3EA57C-0x000000018D3EA59C 
		public bool allTrue { get; } // 0x000000018D3EA59C-0x000000018D3EA5BC 
		public string humanizedData { get; } // 0x000000018D3EA5BC-0x000000018D3EA88C 
		public bool this[uint index] { get => default; set {} } // 0x000000018D3EA548-0x000000018D3EA57C 0x000000018D3EA8FC-0x000000018D3EA938
	
		// Constructors
		public BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4); // 0x0000000187232F20-0x0000000187232F40
		public BitArray256(IEnumerable<uint> bitIndexTrue); // 0x000000018D3EA454-0x000000018D3EA548
	
		// Methods
		public static BitArray256 operator ~(BitArray256 a); // 0x000000018725E510-0x000000018725E540
		public static BitArray256 operator |(BitArray256 a, BitArray256 b); // 0x000000018725E4D0-0x000000018725E510
		public static BitArray256 operator &(BitArray256 a, BitArray256 b); // 0x000000018725E490-0x000000018725E4D0
		public IBitArray BitAnd(IBitArray other); // 0x000000018D3EA1BC-0x000000018D3EA27C
		public IBitArray BitOr(IBitArray other); // 0x000000018D3EA2EC-0x000000018D3EA3AC
		public IBitArray BitNot(); // 0x000000018D3EA27C-0x000000018D3EA2EC
		public static bool operator ==(BitArray256 a, BitArray256 b); // 0x000000018D3EA88C-0x000000018D3EA8C4
		public static bool operator !=(BitArray256 a, BitArray256 b); // 0x000000018D3EA8C4-0x000000018D3EA8FC
		public override bool Equals(object obj); // 0x000000018D3EA3AC-0x000000018D3EA454
		public override int GetHashCode(); // 0x000000018725E430-0x000000018725E480
	}

	public static class BitArrayUtilities // TypeDefIndex: 83487
	{
		// Methods
		public static bool Get8(uint index, byte data); // 0x000000018D3EB084-0x000000018D3EB098
		public static bool Get16(uint index, ushort data); // 0x0000000186E39770-0x0000000186E40AC0
		public static bool Get32(uint index, uint data); // 0x0000000188C2C934-0x0000000188C2C944
		public static bool Get64(uint index, ulong data); // 0x000000018D3EB074-0x000000018D3EB084
		public static bool Get128(uint index, ulong data1, ulong data2); // 0x0000000185CA9D20-0x0000000185CA9D40
		public static bool Get256(uint index, ulong data1, ulong data2, ulong data3, ulong data4); // 0x000000018D3EB03C-0x000000018D3EB074
		public static void Set8(uint index, ref byte data, bool value); // 0x000000018D3EB134-0x000000018D3EB14C
		public static void Set16(uint index, ref ushort data, bool value); // 0x0000000186867820-0x0000000186867840
		public static void Set32(uint index, ref uint data, bool value); // 0x000000018D3EB100-0x000000018D3EB118
		public static void Set64(uint index, ref ulong data, bool value); // 0x000000018D3EB118-0x000000018D3EB134
		public static void Set128(uint index, ref ulong data1, ref ulong data2, bool value); // 0x0000000185DEAA90-0x0000000185DEAAC0
		public static void Set256(uint index, ref ulong data1, ref ulong data2, ref ulong data3, ref ulong data4, bool value); // 0x000000018D3EB098-0x000000018D3EB100
	}

	public static class Blitter // TypeDefIndex: 83489
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
		private static class BlitShaderIDs // TypeDefIndex: 83488
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
			static BlitShaderIDs(); // 0x000000018D3EB14C-0x000000018D3EB2C8
		}
	
		// Constructors
		static Blitter(); // 0x00000001871805D0-0x0000000187180810
	
		// Methods
		public static void Initialize(Shader blitPS, Shader blitColorAndDepthPS, Shader blitMotionVectorPS, Shader lowResBlitPS); // 0x0000000186C19380-0x0000000186C196F0
		public static void Cleanup(); // 0x0000000185B9D320-0x0000000185B9D590
		public static Material GetBlitMaterial(bool isFP32Output, TextureDimension dimension, bool singleSlice = false /* Metadata: 0x026421EE */); // 0x000000018604EE50-0x000000018604EE90
		public static Material GetBlitColorAndDepth(bool isFP32Output); // 0x000000018D3ED358-0x000000018D3ED3A8
		public static Material GetBlitMotionVectorMaterial(); // 0x000000018D3ED3A8-0x000000018D3ED3F8
		public static Material GetLowResBlitMaterial(); // 0x000000018D3ED3F8-0x000000018D3ED448
		private static void DrawTriangle(CommandBuffer cmd, Material material, int shaderPass); // 0x000000018D3ED184-0x000000018D3ED358
		internal static void DrawQuad(CommandBuffer cmd, Material material, int shaderPass); // 0x000000018D3ECFB0-0x000000018D3ED184
		public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear); // 0x000000018D3ECE88-0x000000018D3ECFB0
		public static void BlitTexture2D(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear); // 0x000000018D3ECC50-0x000000018D3ECD68
		public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass); // 0x000000018D3ECD68-0x000000018D3ECE88
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f /* Metadata: 0x026421EF */, bool bilinear = false /* Metadata: 0x026421F3 */); // 0x000000018D3EB464-0x000000018D3EB600
		public static void BlitCameraTexture2D(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f /* Metadata: 0x026421F4 */, bool bilinear = false /* Metadata: 0x026421F8 */); // 0x000000018D3EB2C8-0x000000018D3EB464
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material, int pass); // 0x000000018D3EB894-0x000000018D3EBA24
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Vector4 scaleBias, float mipLevel = 0f /* Metadata: 0x026421F9 */, bool bilinear = false /* Metadata: 0x026421FD */); // 0x000000018D3EB7C4-0x000000018D3EB894
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect destViewport, float mipLevel = 0f /* Metadata: 0x026421FE */, bool bilinear = false /* Metadata: 0x02642202 */); // 0x000000018D3EB600-0x000000018D3EB7C4
		public static void BlitQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear); // 0x000000018D3ECA8C-0x000000018D3ECC50
		public static void BlitQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels); // 0x000000018D3EC7C4-0x000000018D3ECA8C
		public static void BlitQuadWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels); // 0x000000018D3EC4FC-0x000000018D3EC7C4
		public static void BlitOctahedralWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels); // 0x000000018D3EC06C-0x000000018D3EC2B8
		public static void BlitOctahedralWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels); // 0x000000018D3EBE20-0x000000018D3EC06C
		public static void BlitCubeToOctahedral2DQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex); // 0x000000018D3EBC6C-0x000000018D3EBE20
		public static void BlitCubeToOctahedral2DQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex); // 0x000000018D3EBA24-0x000000018D3EBC6C
		public static void BlitQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex); // 0x000000018D3EC2B8-0x000000018D3EC4FC
		[CompilerGenerated]
		internal static Vector3[] _Initialize_g__GetFullScreenTriangleVertexPosition_10_0(float z); // 0x000000018D3ED54C-0x000000018D3ED618
		[CompilerGenerated]
		internal static Vector2[] _Initialize_g__GetFullScreenTriangleTexCoord_10_1(); // 0x000000018D3ED448-0x000000018D3ED54C
		[CompilerGenerated]
		internal static Vector3[] _Initialize_g__GetQuadVertexPosition_10_2(float z); // 0x000000018D3ED6E0-0x000000018D3ED7A0
		[CompilerGenerated]
		internal static Vector2[] _Initialize_g__GetQuadTexCoord_10_3(); // 0x000000018D3ED618-0x000000018D3ED6E0
	}

	public static class CameraCaptureBridge // TypeDefIndex: 83490
	{
		// Fields
		private static Dictionary<Camera, HashSet<Action<RenderTargetIdentifier, CommandBuffer>>> actionDict; // 0x00
		private static bool _enabled; // 0x08
	
		// Properties
		public static bool enabled { get; set; } // 0x000000018D3ED9C4-0x000000018D3EDA14 0x000000018D3EDA14-0x000000018D3EDA68
	
		// Constructors
		static CameraCaptureBridge(); // 0x00000001871791F0-0x0000000187179280
	
		// Methods
		public static IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> GetCaptureActions(Camera camera); // 0x00000001850F6B20-0x00000001850F6BF0
		public static void AddCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action); // 0x000000018D3ED7A0-0x000000018D3ED8E8
		public static void RemoveCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action); // 0x000000018D3ED8E8-0x000000018D3ED9C4
	}

	public static class ColorUtils // TypeDefIndex: 83491
	{
		// Fields
		public static float s_LightMeterCalibrationConstant; // 0x00
		public static float s_LensAttenuation; // 0x04
	
		// Properties
		public static float lensImperfectionExposureScale { get; } // 0x000000018D3EE55C-0x000000018D3EE5C0 
	
		// Constructors
		static ColorUtils(); // 0x00000001871FC930-0x00000001871FC980
	
		// Methods
		public static float StandardIlluminantY(float x); // 0x000000018725E6E0-0x000000018725E710
		public static Vector3 CIExyToLMS(float x, float y); // 0x000000018D3EDA88-0x000000018D3EDB18
		public static Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint); // 0x000000018D3EDB18-0x000000018D3EDC2C
		public static ValueTuple<Vector4, Vector4, Vector4> PrepareShadowsMidtonesHighlights([IsReadOnly] in Vector4 inShadows, [IsReadOnly] in Vector4 inMidtones, [IsReadOnly] in Vector4 inHighlights); // 0x000000018D3EE168-0x000000018D3EE3D4
		public static ValueTuple<Vector4, Vector4, Vector4> PrepareLiftGammaGain([IsReadOnly] in Vector4 inLift, [IsReadOnly] in Vector4 inGamma, [IsReadOnly] in Vector4 inGain); // 0x000000018D3EDDDC-0x000000018D3EE168
		public static ValueTuple<Vector4, Vector4> PrepareSplitToning([IsReadOnly] in Vector4 inShadows, [IsReadOnly] in Vector4 inHighlights, float balance); // 0x000000018D3EE3D4-0x000000018D3EE464
		public static float Luminance([IsReadOnly] in UnityEngine.Color color); // 0x000000018725E6B0-0x000000018725E6E0
		public static float ComputeEV100(float aperture, float shutterSpeed, float ISO); // 0x000000018D3EDC94-0x000000018D3EDCB8
		public static float ConvertEV100ToExposure(float EV100); // 0x000000018D3EDD04-0x000000018D3EDD78
		public static float ConvertExposureToEV100(float exposure); // 0x000000018D3EDD78-0x000000018D3EDDDC
		public static float ComputeEV100FromAvgLuminance(float avgLuminance); // 0x000000018D3EDC2C-0x000000018D3EDC94
		public static float ComputeISO(float aperture, float shutterSpeed, float targetEV100); // 0x000000018D3EDCB8-0x000000018D3EDD04
		public static uint ToHex(UnityEngine.Color c); // 0x000000018D3EE464-0x000000018D3EE4E4
		public static UnityEngine.Color ToRGBA(uint hex); // 0x000000018D3EE4E4-0x000000018D3EE55C
	}

	public static class CoreMatrixUtils // TypeDefIndex: 83492
	{
		// Methods
		public static void MatrixTimesTranslation(ref Matrix4x4 inOutMatrix, Vector3 translation); // 0x000000018725E710-0x000000018725E7A0
		public static void TranslationTimesMatrix(ref Matrix4x4 inOutMatrix, Vector3 translation); // 0x000000018725EBE0-0x000000018725ECD0
		public static Matrix4x4 MultiplyPerspectiveMatrix(Matrix4x4 perspective, Matrix4x4 rhs); // 0x000000018725EA90-0x000000018725EBE0
		private static Matrix4x4 MultiplyOrthoMatrixCentered(Matrix4x4 ortho, Matrix4x4 rhs); // 0x000000018725E950-0x000000018725EA90
		private static Matrix4x4 MultiplyGenericOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs); // 0x000000018725E7A0-0x000000018725E950
		public static Matrix4x4 MultiplyOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs, bool centered); // 0x000000018D3EE5C0-0x000000018D3EE6B0
		public static Matrix4x4 MultiplyProjectionMatrix(Matrix4x4 projMatrix, Matrix4x4 rhs, bool orthoCentered); // 0x000000018D3EE6B0-0x000000018D3EE7A0
	}

	public static class CoreUtils // TypeDefIndex: 83497
	{
		// Fields
		public static readonly Vector3[] lookAtList; // 0x00
		public static readonly Vector3[] upVectorList; // 0x08
		private const string obsoletePriorityMessage = "Use CoreUtils.Priorities instead"; // Metadata: 0x02642242
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority1 = 320; // Metadata: 0x02642263
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority2 = 331; // Metadata: 0x02642265
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority3 = 342; // Metadata: 0x02642267
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority4 = 353; // Metadata: 0x02642269
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int assetCreateMenuPriority1 = 230; // Metadata: 0x0264226B
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int assetCreateMenuPriority2 = 241; // Metadata: 0x0264226D
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int assetCreateMenuPriority3 = 300; // Metadata: 0x0264226F
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int gameObjectMenuPriority = 10; // Metadata: 0x02642271
		private static Cubemap m_BlackCubeTexture; // 0x10
		private static Cubemap m_MagentaCubeTexture; // 0x18
		private static CubemapArray m_MagentaCubeTextureArray; // 0x20
		private static Cubemap m_WhiteCubeTexture; // 0x28
		private static RenderTexture m_EmptyUAV; // 0x30
		private static Texture3D m_BlackVolumeTexture; // 0x38
		private static IEnumerable<System.Type> m_AssemblyTypes; // 0x40
	
		// Properties
		public static Cubemap blackCubeTexture { get; } // 0x000000018D3F1488-0x000000018D3F1624 
		public static Cubemap magentaCubeTexture { get; } // 0x000000018D3F1AFC-0x000000018D3F1C98 
		public static CubemapArray magentaCubeTextureArray { get; } // 0x000000018D3F1924-0x000000018D3F1AFC 
		public static Cubemap whiteCubeTexture { get; } // 0x000000018D3F1C98-0x000000018D3F1E34 
		public static RenderTexture emptyUAV { get; } // 0x000000018D3F17D8-0x000000018D3F1924 
		public static Texture3D blackVolumeTexture { get; } // 0x000000018D3F1624-0x000000018D3F17D8 
	
		// Nested types
		public static class Sections // TypeDefIndex: 83493
		{
			// Fields
			public const int section1 = 10000; // Metadata: 0x02642272
			public const int section2 = 20000; // Metadata: 0x02642276
			public const int section3 = 30000; // Metadata: 0x0264227A
			public const int section4 = 40000; // Metadata: 0x0264227E
			public const int section5 = 50000; // Metadata: 0x02642282
			public const int section6 = 60000; // Metadata: 0x02642286
			public const int section7 = 70000; // Metadata: 0x0264228A
			public const int section8 = 80000; // Metadata: 0x0264228E
		}
	
		public static class Priorities // TypeDefIndex: 83494
		{
			// Fields
			public const int assetsCreateShaderMenuPriority = 83; // Metadata: 0x02642292
			public const int assetsCreateRenderingMenuPriority = 308; // Metadata: 0x02642294
			public const int editMenuPriority = 320; // Metadata: 0x02642296
			public const int gameObjectMenuPriority = 10; // Metadata: 0x02642298
			public const int srpLensFlareMenuPriority = 303; // Metadata: 0x02642299
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83495
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Assembly, IEnumerable<System.Type>> __9__81_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E5960-0x00000001871E59C0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal IEnumerable<System.Type> _GetAllAssemblyTypes_b__81_0(Assembly t); // 0x0000000185B81280-0x0000000185B812D0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__82<T> // TypeDefIndex: 83496
		{
			// Fields
			public static readonly __c__82<T> __9;
			public static Func<System.Type, bool> __9__82_0;
	
			// Constructors
			static __c__82();
			public __c__82();
	
			// Methods
			internal bool _GetAllTypesDerivedFrom_b__82_0(System.Type t);
		}
	
		// Constructors
		static CoreUtils(); // 0x0000000186D363F0-0x0000000186D36620
	
		// Methods
		public static void ClearRenderTarget(CommandBuffer cmd, ClearFlag clearFlag, UnityEngine.Color clearColor); // 0x000000018D3EE8F4-0x000000018D3EE93C
		private static int FixupDepthSlice(int depthSlice, RTHandle buffer); // 0x000000018D3EF6DC-0x000000018D3EF720
		private static int FixupDepthSlice(int depthSlice, CubemapFace cubemapFace); // 0x000000018D3EF6CC-0x000000018D3EF6DC
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel = 0 /* Metadata: 0x02642203 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x02642204 */, int depthSlice = -1 /* Metadata: 0x02642205 */); // 0x000000018D3F01E0-0x000000018D3F02C0
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag = ClearFlag.None /* Metadata: 0x02642206 */, int miplevel = 0 /* Metadata: 0x02642207 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x02642208 */, int depthSlice = -1 /* Metadata: 0x02642209 */); // 0x000000018D3F03D4-0x000000018D3F04AC
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, int miplevel = 0 /* Metadata: 0x0264220A */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x0264220B */, int depthSlice = -1 /* Metadata: 0x0264220C */); // 0x000000018D3F1098-0x000000018D3F11A4
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, int miplevel = 0 /* Metadata: 0x0264220D */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x0264220E */, int depthSlice = -1 /* Metadata: 0x0264220F */); // 0x000000018D3F02C0-0x000000018D3F03D4
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel = 0 /* Metadata: 0x02642210 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x02642211 */, int depthSlice = -1 /* Metadata: 0x02642212 */); // 0x000000018D3F0AB4-0x000000018D3F0BD0
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer); // 0x000000018D3F0128-0x000000018D3F01E0
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag = ClearFlag.None /* Metadata: 0x02642213 */); // 0x000000018D3F0064-0x000000018D3F0128
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, UnityEngine.Color clearColor); // 0x000000018D3F0BD0-0x000000018D3F0CA8
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, UnityEngine.Color clearColor); // 0x000000018D3F11A4-0x000000018D3F1270
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag); // 0x000000018D3F0DB4-0x000000018D3F0E84
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, UnityEngine.Color clearColor); // 0x000000018D3F0F78-0x000000018D3F1098
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, UnityEngine.Color clearColor); // 0x000000018D3F04AC-0x000000018D3F0594
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag); // 0x000000018D3F07C0-0x000000018D3F08E4
		private static void SetViewportAndClear(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, UnityEngine.Color clearColor); // 0x000000018D3F1324-0x000000018D3F13AC
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel = 0 /* Metadata: 0x02642214 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x02642215 */, int depthSlice = -1 /* Metadata: 0x02642216 */); // 0x000000018D3F0CA8-0x000000018D3F0DB4
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag = ClearFlag.None /* Metadata: 0x02642217 */, int miplevel = 0 /* Metadata: 0x02642218 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x02642219 */, int depthSlice = -1 /* Metadata: 0x0264221A */); // 0x000000018D3F1270-0x000000018D3F1324
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, int miplevel = 0 /* Metadata: 0x0264221B */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x0264221C */, int depthSlice = -1 /* Metadata: 0x0264221D */); // 0x000000018D3F0690-0x000000018D3F07C0
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, int miplevel = 0 /* Metadata: 0x0264221E */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x0264221F */, int depthSlice = -1 /* Metadata: 0x02642220 */); // 0x000000018D3EFE2C-0x000000018D3EFF60
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel = 0 /* Metadata: 0x02642221 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x02642222 */, int depthSlice = -1 /* Metadata: 0x02642223 */); // 0x000000018D3F08E4-0x000000018D3F0AB4
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer); // 0x000000018D3EFF60-0x000000018D3F0064
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag = ClearFlag.None /* Metadata: 0x02642224 */); // 0x000000018D3F0594-0x000000018D3F0690
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag, UnityEngine.Color clearColor); // 0x000000018D3F0E84-0x000000018D3F0F78
		public static void SetViewport(CommandBuffer cmd, RTHandle target); // 0x000000018D3F13AC-0x000000018D3F1488
		public static string GetRenderTargetAutoName(int width, int height, int depth, RenderTextureFormat format, string name, bool mips = false /* Metadata: 0x02642225 */, bool enableMSAA = false /* Metadata: 0x02642226 */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x02642227 */); // 0x00000001859FBB90-0x00000001859FBC90
		public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, string name, bool mips = false /* Metadata: 0x02642228 */, bool enableMSAA = false /* Metadata: 0x02642229 */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x0264222A */); // 0x000000018D3EF74C-0x000000018D3EF838
		public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, TextureDimension dim, string name, bool mips = false /* Metadata: 0x0264222B */, bool enableMSAA = false /* Metadata: 0x0264222C */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x0264222D */, bool dynamicRes = false /* Metadata: 0x0264222E */); // 0x00000001859F9F30-0x00000001859FA040
		private static string GetRenderTargetAutoName(int width, int height, int depth, string format, TextureDimension dim, string name, bool mips, bool enableMSAA, MSAASamples msaaSamples, bool dynamicRes); // 0x00000001859FA040-0x00000001859FA200
		public static string GetTextureAutoName(int width, int height, TextureFormat format, TextureDimension dim = TextureDimension.None /* Metadata: 0x0264222F */, string name = "" /* Metadata: 0x02642230 */, bool mips = false /* Metadata: 0x02642231 */, int depth = 0 /* Metadata: 0x02642232 */); // 0x000000018D3EF8E4-0x000000018D3EF990
		public static string GetTextureAutoName(int width, int height, GraphicsFormat format, TextureDimension dim = TextureDimension.None /* Metadata: 0x02642233 */, string name = "" /* Metadata: 0x02642234 */, bool mips = false /* Metadata: 0x02642235 */, int depth = 0 /* Metadata: 0x02642236 */); // 0x000000018D3EF838-0x000000018D3EF8E4
		private static string GetTextureAutoName(int width, int height, string format, TextureDimension dim = TextureDimension.None /* Metadata: 0x02642237 */, string name = "" /* Metadata: 0x02642238 */, bool mips = false /* Metadata: 0x02642239 */, int depth = 0 /* Metadata: 0x0264223A */); // 0x000000018D3EF990-0x000000018D3EFC90
		public static void ClearCubemap(CommandBuffer cmd, RenderTexture renderTexture, UnityEngine.Color clearColor, bool clearMips = false /* Metadata: 0x0264223B */); // 0x000000018D3EE7A0-0x000000018D3EE8F4
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x0264223C */); // 0x000000018D3EF100-0x000000018D3EF188
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x0264223D */); // 0x000000018D3EF188-0x000000018D3EF274
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x0264223E */); // 0x000000018D3EF274-0x000000018D3EF378
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x0264223F */); // 0x000000018D3EEF3C-0x000000018D3EF030
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x02642240 */); // 0x000000018D3EF030-0x000000018D3EF100
		public static UnityEngine.Color ConvertSRGBToActiveColorSpace(UnityEngine.Color color); // 0x000000018D3EE980-0x000000018D3EE9C4
		public static UnityEngine.Color ConvertLinearToActiveColorSpace(UnityEngine.Color color); // 0x000000018D3EE93C-0x000000018D3EE980
		public static Material CreateEngineMaterial(string shaderPath); // 0x000000018D3EEE3C-0x000000018D3EEF3C
		public static Material CreateEngineMaterial(Shader shader, bool enableInstancing = false /* Metadata: 0x02642241 */); // 0x00000001852F2550-0x00000001852F2640
		public static bool HasFlag<T>(T mask, T flag)
			where T : IConvertible;
		public static void Swap<T>(ref ref T a, ref ref T b);
		public static void SetKeyword(CommandBuffer cmd, string keyword, bool state); // 0x000000018D3EFDF8-0x000000018D3EFE2C
		public static void SetKeyword(Material material, string keyword, bool state); // 0x000000018D3EFD90-0x000000018D3EFDC4
		public static void SetKeyword(ComputeShader cs, string keyword, bool state); // 0x000000018D3EFDC4-0x000000018D3EFDF8
		public static void Destroy(UnityEngine.Object obj); // 0x00000001859F8200-0x00000001859F82C0
		public static IEnumerable<System.Type> GetAllAssemblyTypes(); // 0x00000001862D1420-0x00000001862D1600
		public static IEnumerable<System.Type> GetAllTypesDerivedFrom<T>();
		public static void SafeRelease(ComputeBuffer buffer); // 0x000000018D3EFD80-0x000000018D3EFD90
		public static Mesh CreateCubeMesh(Vector3 min, Vector3 max); // 0x000000018D3EE9C4-0x000000018D3EEE3C
		public static bool ArePostProcessesEnabled(Camera camera); // 0x00000001851A4410-0x00000001851A4420
		public static bool AreAnimatedMaterialsEnabled(Camera camera); // 0x00000001851A4410-0x00000001851A4420
		public static bool IsSceneLightingDisabled(Camera camera); // 0x00000001843FFFF0-0x0000000184400000
		public static bool IsLightOverlapDebugEnabled(Camera camera); // 0x00000001843FFFF0-0x0000000184400000
		public static bool IsSceneViewFogEnabled(Camera camera); // 0x00000001851A4410-0x00000001851A4420
		public static bool IsSceneFilteringEnabled(); // 0x00000001843FFFF0-0x0000000184400000
		public static bool IsSceneViewPrefabStageContextHidden(); // 0x00000001843FFFF0-0x0000000184400000
		[Obsolete("Use the updated RendererList API in the UnityEngine.Rendering.RendererUtils namespace.")]
		public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, UnityEngine.Experimental.Rendering.RendererList rendererList); // 0x000000018D3EF378-0x000000018D3EF654
		public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, UnityEngine.Rendering.RendererUtils.RendererList rendererList); // 0x000000018D3EF654-0x000000018D3EF6CC
		public static int GetTextureHash(Texture texture); // 0x000000018D3EFC90-0x000000018D3EFD50
		public static int PreviousPowerOfTwo(int size); // 0x000000018D3EFD50-0x000000018D3EFD80
		public static T GetLastEnumValue<T>()
			where T : Enum;
		internal static string GetCorePath(); // 0x000000018D3EF720-0x000000018D3EF74C
	}

	public static class DelegateUtility // TypeDefIndex: 83498
	{
		// Methods
		public static Delegate Cast(Delegate source, System.Type type); // 0x000000018D3F42F4-0x000000018D3F4430
	}

	public static class FSRUtils // TypeDefIndex: 83500
	{
		// Fields
		internal const float kMaxSharpnessStops = 2.5f; // Metadata: 0x026422A3
		public const float kDefaultSharpnessStops = 0.2f; // Metadata: 0x026422A7
		public const float kDefaultSharpnessLinear = 0.92f; // Metadata: 0x026422AB
	
		// Nested types
		private static class ShaderConstants // TypeDefIndex: 83499
		{
			// Fields
			public static readonly int _FsrEasuConstants0; // 0x00
			public static readonly int _FsrEasuConstants1; // 0x04
			public static readonly int _FsrEasuConstants2; // 0x08
			public static readonly int _FsrEasuConstants3; // 0x0C
			public static readonly int _FsrRcasConstants; // 0x10
	
			// Constructors
			static ShaderConstants(); // 0x000000018D3F7294-0x000000018D3F7390
		}
	
		// Methods
		public static void SetEasuConstants(CommandBuffer cmd, Vector2 inputViewportSizeInPixels, Vector2 inputImageSizeInPixels, Vector2 outputImageSizeInPixels); // 0x000000018D3F4448-0x000000018D3F4634
		public static void SetRcasConstants(CommandBuffer cmd, float sharpnessStops = 0.2f /* Metadata: 0x0264229B */); // 0x000000018D3F4654-0x000000018D3F4730
		public static void SetRcasConstantsLinear(CommandBuffer cmd, float sharpnessLinear = 0.92f /* Metadata: 0x0264229F */); // 0x000000018D3F4634-0x000000018D3F4654
		public static bool IsSupported(); // 0x000000018D3F4430-0x000000018D3F4448
	}

	public class HableCurve // TypeDefIndex: 83504
	{
		// Fields
		[CompilerGenerated]
		private float _whitePoint_k__BackingField; // 0x10
		[CompilerGenerated]
		private float _inverseWhitePoint_k__BackingField; // 0x14
		[CompilerGenerated]
		private float _x0_k__BackingField; // 0x18
		[CompilerGenerated]
		private float _x1_k__BackingField; // 0x1C
		public readonly Segment[] segments; // 0x20
		public readonly Uniforms uniforms; // 0x28
	
		// Properties
		public float whitePoint { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232D00-0x0000000187232D10 0x0000000187235230-0x0000000187235240
		public float inverseWhitePoint { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187235C60-0x0000000187235C70 0x0000000187235C70-0x0000000187235C80
		public float x0 { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233050-0x0000000187233060 0x0000000187233060-0x0000000187233070
		public float x1 { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
	
		// Nested types
		public class Segment // TypeDefIndex: 83501
		{
			// Fields
			public float offsetX; // 0x10
			public float offsetY; // 0x14
			public float scaleX; // 0x18
			public float scaleY; // 0x1C
			public float lnA; // 0x20
			public float B; // 0x24
	
			// Constructors
			public Segment(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public float Eval(float x); // 0x000000018D3F7250-0x000000018D3F7294
		}
	
		private struct DirectParams // TypeDefIndex: 83502
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
	
		public class Uniforms // TypeDefIndex: 83503
		{
			// Fields
			private HableCurve parent; // 0x10
	
			// Properties
			public Vector4 curve { get; } // 0x000000018D3F79DC-0x000000018D3F7A18 
			public Vector4 toeSegmentA { get; } // 0x000000018D3F7C00-0x000000018D3F7C8C 
			public Vector4 toeSegmentB { get; } // 0x000000018D3F7C8C-0x000000018D3F7CF4 
			public Vector4 midSegmentA { get; } // 0x000000018D3F7A18-0x000000018D3F7AA4 
			public Vector4 midSegmentB { get; } // 0x000000018D3F7AA4-0x000000018D3F7B0C 
			public Vector4 shoSegmentA { get; } // 0x000000018D3F7B0C-0x000000018D3F7B98 
			public Vector4 shoSegmentB { get; } // 0x000000018D3F7B98-0x000000018D3F7C00 
	
			// Constructors
			internal Uniforms(HableCurve parent); // 0x0000000184FD2410-0x0000000184FD2420
		}
	
		// Constructors
		public HableCurve(); // 0x000000018D3F4F18-0x000000018D3F5034
	
		// Methods
		public float Eval(float x); // 0x000000018D3F47A0-0x000000018D3F4808
		public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma); // 0x000000018D3F4D04-0x000000018D3F4EA8
		private void InitSegments(DirectParams srcParams); // 0x000000018D3F4808-0x000000018D3F4D04
		private void SolveAB(out float lnA, out float B, float x0, float y0, float m); // 0x000000018D3F4EA8-0x000000018D3F4F18
		private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1); // 0x000000018D3F4758-0x000000018D3F47A0
		private float EvalDerivativeLinearGamma(float m, float b, float g, float x); // 0x000000018725ED40-0x000000018725ED90
	}

	public static class HaltonSequence // TypeDefIndex: 83505
	{
		// Methods
		public static float Get(int index, int radix); // 0x00000001850F72C0-0x00000001850F7310
	}

	[Flags]
	[MovedFrom("Utilities")]
	public enum MaterialQuality // TypeDefIndex: 83506
	{
		Low = 1,
		Medium = 2,
		High = 4
	}

	[MovedFrom("Utilities")]
	public static class MaterialQualityUtilities // TypeDefIndex: 83507
	{
		// Fields
		public static string[] KeywordNames; // 0x00
		public static string[] EnumNames; // 0x08
		public static ShaderKeyword[] Keywords; // 0x10
	
		// Constructors
		static MaterialQualityUtilities(); // 0x000000018D3F5464-0x000000018D3F5718
	
		// Methods
		public static MaterialQuality FromIndex(int index); // 0x00000001872359F0-0x0000000187235A00
	
		// Extension methods
		public static MaterialQuality GetHighestQuality(this MaterialQuality levels); // 0x000000018D3F5188-0x000000018D3F51F8
		public static MaterialQuality GetClosestQuality(this MaterialQuality availableLevels, MaterialQuality requestedLevel); // 0x000000018D3F5088-0x000000018D3F5188
		public static void SetGlobalShaderKeywords(this MaterialQuality level); // 0x000000018D3F51F8-0x000000018D3F52DC
		public static void SetGlobalShaderKeywords(this MaterialQuality level, CommandBuffer cmd); // 0x000000018D3F52DC-0x000000018D3F53E8
		public static int ToFirstIndex(this MaterialQuality level); // 0x000000018D3F53E8-0x000000018D3F5464
	}

	internal class MeshGizmo : IDisposable // TypeDefIndex: 83509
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
	
		// Nested types
		[CompilerGenerated]
		private struct __c__DisplayClass10_0 // TypeDefIndex: 83508
		{
			// Fields
			public MeshGizmo __4__this; // 0x00
			public UnityEngine.Color color; // 0x08
		}
	
		// Constructors
		public MeshGizmo(int capacity = 0 /* Metadata: 0x026422B2 */); // 0x000000018D3F6538-0x000000018D3F66AC
		static MeshGizmo(); // 0x000000018D3F64FC-0x000000018D3F6538
	
		// Methods
		public void Clear(); // 0x000000018D3F60A8-0x000000018D3F612C
		public void AddWireCube(Vector3 center, Vector3 size, UnityEngine.Color color); // 0x000000018D3F5764-0x000000018D3F60A8
		private void DrawMesh(Matrix4x4 trs, Material mat, MeshTopology topology, CompareFunction depthTest, string gizmoName); // 0x000000018D3F617C-0x000000018D3F6348
		public void RenderWireframe(Matrix4x4 trs, CompareFunction depthTest = CompareFunction.LessEqual /* Metadata: 0x026422B3 */, string gizmoName = null); // 0x000000018D3F6348-0x000000018D3F639C
		public void Dispose(); // 0x000000018D3F612C-0x000000018D3F617C
		[CompilerGenerated]
		private void _AddWireCube_g__AddEdge_10_0(Vector3 p1, Vector3 p2, ref __c__DisplayClass10_0 param_000b2d4a); // 0x000000018D3F639C-0x000000018D3F64FC
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class ReloadAttribute : Attribute // TypeDefIndex: 83511
	{
		// Nested types
		public enum Package // TypeDefIndex: 83510
		{
			Builtin = 0,
			Root = 1
		}
	
		// Constructors
		public ReloadAttribute(string[] paths, Package package = Package.Root /* Metadata: 0x026422B4 */); // 0x0000000186805BA0-0x0000000186805BB0
		public ReloadAttribute(string path, Package package = Package.Root /* Metadata: 0x026422B5 */); // 0x000000018D3F70E4-0x000000018D3F7138
		public ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, Package package = Package.Root /* Metadata: 0x026422B6 */); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ReloadGroupAttribute : Attribute // TypeDefIndex: 83512
	{
		// Constructors
		public ReloadGroupAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class TextureCurve : IDisposable // TypeDefIndex: 83513
	{
		// Fields
		private const int k_Precision = 128; // Metadata: 0x026422B9
		private const float k_Step = 0.0078125f; // Metadata: 0x026422BB
		[CompilerGenerated]
		[SerializeField]
		private int _length_k__BackingField; // 0x10
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
		public int length { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public Keyframe this[int index] { get => default; } // 0x000000018D3F76AC-0x000000018D3F76F0 
	
		// Constructors
		public TextureCurve(AnimationCurve baseCurve, float zeroValue, bool loop, [IsReadOnly] in Vector2 bounds); // 0x000000018D3F7650-0x000000018D3F76AC
		public TextureCurve(Keyframe[] keys, float zeroValue, bool loop, [IsReadOnly] in Vector2 bounds); // 0x0000000186649A50-0x0000000186649B30
	
		// Methods
		public bool IsTextureCurveDirty(); // 0x0000000185EDD520-0x0000000185EDD550
		~TextureCurve(); // 0x00000001863C83D0-0x00000001863C83F0
		[Obsolete("Please use Release() instead.")]
		public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		public void Release(); // 0x0000000186C16020-0x0000000186C16090
		public void SetDirty(); // 0x000000018725EDD0-0x000000018725EDE0
		private static GraphicsFormat GetTextureFormat(); // 0x00000001859FB860-0x00000001859FB890
		public Texture2D GetTexture(); // 0x00000001859FB5B0-0x00000001859FB7C0
		public float Evaluate(float time); // 0x00000001859FB7C0-0x00000001859FB860
		public int AddKey(float time, float value); // 0x000000018D3F7574-0x000000018D3F75A8
		public int MoveKey(int index, [IsReadOnly] in Keyframe key); // 0x000000018D3F75A8-0x000000018D3F75F8
		public void RemoveKey(int index); // 0x000000018D3F75F8-0x000000018D3F7624
		public void SmoothTangents(int index, float weight); // 0x000000018D3F7624-0x000000018D3F7650
	}

	[Serializable]
	public class TextureCurveParameter : VolumeParameter<TextureCurve> // TypeDefIndex: 83514
	{
		// Constructors
		public TextureCurveParameter(TextureCurve value, bool overrideState = false /* Metadata: 0x026422BF */); // 0x00000001866499F0-0x0000000186649A50
	
		// Methods
		public override void Release(); // 0x0000000186C16000-0x0000000186C16020
	}

	public static class TileLayoutUtils // TypeDefIndex: 83515
	{
		// Methods
		public static bool TryLayoutByTiles(RectInt src, uint tileSize, out RectInt main, out RectInt topRow, out RectInt rightCol, out RectInt topRight); // 0x000000018D3F7894-0x000000018D3F7990
		public static bool TryLayoutByRow(RectInt src, uint tileSize, out RectInt main, out RectInt other); // 0x000000018D3F7820-0x000000018D3F7894
		public static bool TryLayoutByCol(RectInt src, uint tileSize, out RectInt main, out RectInt other); // 0x000000018D3F77B0-0x000000018D3F7820
	}

	public static class XRUtils // TypeDefIndex: 83516
	{
		// Methods
		public static void DrawOcclusionMesh(CommandBuffer cmd, Camera camera, bool stereoEnabled = true /* Metadata: 0x026422C0 */); // 0x000000018D3F8890-0x000000018D3F8928
	}

	public interface IVolume // TypeDefIndex: 83517
	{
		// Properties
		bool isGlobal { get; set; }
		List<Collider> colliders { get; }
	
		// Methods
		void Play();
		void Stop();
	}

	[AddComponentMenu("Miscellaneous/Volume")]
	[ExecuteAlways]
	public class Volume : MonoBehaviour, IVolume // TypeDefIndex: 83518
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
		[NonSerialized]
		public bool vfxEnableState; // 0x58
	
		// Properties
		[Tooltip("When enabled, the Volume is applied to the entire Scene.")]
		public bool isGlobal { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public List<Collider> colliders { get; } // 0x000000018226EEA0-0x000000018226EEB0 
		internal VolumeProfile profileRef { get; } // 0x00000001850A7C40-0x00000001850A7CD0 
	
		// Constructors
		public Volume(); // 0x0000000185CEEB10-0x0000000185CEEBB0
	
		// Methods
		public VolumeProfile GetInstantiatedProfile(); // 0x0000000185C8A990-0x0000000185C8AC10
		public void SetInstantiatedProfile(VolumeProfile profile); // 0x00000001869E1E00-0x00000001869E1E10
		public bool HasInstantiatedProfile(); // 0x000000018D3F87A8-0x000000018D3F87F8
		private void OnEnable(); // 0x00000001858AE1C0-0x00000001858AE270
		private void OnDisable(); // 0x00000001858AE130-0x00000001858AE1C0
		private void Update(); // 0x00000001851C9CB0-0x00000001851C9DF0
		internal void UpdateLayer(); // 0x00000001851C9DF0-0x00000001851C9EB0
		public void Play(); // 0x00000001872554B0-0x00000001872554C0
		public void Stop(); // 0x000000018725EDE0-0x000000018725EDF0
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class VolumeComponentMenu : Attribute // TypeDefIndex: 83519
	{
		// Fields
		public readonly string menu; // 0x10
	
		// Constructors
		public VolumeComponentMenu(string menu); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public class VolumeComponentMenuForRenderPipeline : VolumeComponentMenu // TypeDefIndex: 83520
	{
		// Fields
		[CompilerGenerated]
		private readonly System.Type[] _pipelineTypes_k__BackingField; // 0x18
	
		// Properties
		public System.Type[] pipelineTypes { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
	
		// Constructors
		public VolumeComponentMenuForRenderPipeline(string menu, params System.Type[] pipelineTypes); // 0x000000018D3F7CF4-0x000000018D3F7EC0
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Obsolete("VolumeComponentDeprecated has been deprecated (UnityUpgradable) -> [UnityEngine] UnityEngine.HideInInspector", false)]
	public sealed class VolumeComponentDeprecated : Attribute // TypeDefIndex: 83521
	{
		// Constructors
		public VolumeComponentDeprecated(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class MigratingVolumeComponent : Attribute // TypeDefIndex: 83522
	{
		// Constructors
		public MigratingVolumeComponent(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class VolumeComponent : ScriptableObject // TypeDefIndex: 83525
	{
		// Fields
		public bool active; // 0x18
		[CompilerGenerated]
		private string _displayName_k__BackingField; // 0x20
		[CompilerGenerated]
		private VolumeParameter[] _parameters_k__BackingField; // 0x28
	
		// Properties
		public string displayName { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public VolumeParameter[] parameters { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
	
		// Nested types
		public sealed class Indent : PropertyAttribute // TypeDefIndex: 83523
		{
			// Fields
			public readonly int relativeAmount; // 0x10
	
			// Constructors
			public Indent(int relativeAmount = 1 /* Metadata: 0x026422C1 */); // 0x0000000182234E90-0x0000000182234EA0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83524
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Reflection.FieldInfo, int> __9__10_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E6E60-0x00000001871E6EC0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _FindParameters_b__10_0(System.Reflection.FieldInfo t); // 0x00000001860B50B0-0x00000001860B50D0
		}
	
		// Constructors
		public VolumeComponent(); // 0x0000000185DD5860-0x0000000185DD5890
	
		// Methods
		internal static void FindParameters(object o, List<VolumeParameter> parameters, Func<System.Reflection.FieldInfo, bool> filter = null); // 0x00000001854C1E40-0x00000001854C2270
		protected virtual void OnEnable(); // 0x00000001862895B0-0x0000000186289670
		protected virtual void OnDisable(); // 0x00000001864B8E70-0x00000001864B8EA0
		public virtual void Override(VolumeComponent state, float interpFactor); // 0x00000001850A7EA0-0x00000001850A8870
		public void SetAllOverridesTo(bool state); // 0x00000001850AA210-0x00000001850AA220
		internal void SetOverridesTo(IEnumerable<VolumeParameter> enumerable, bool state); // 0x00000001850AA220-0x00000001850AA460
		public override int GetHashCode(); // 0x000000018D3F7EC0-0x000000018D3F7F38
		protected virtual void OnDestroy(); // 0x000000018647CD60-0x000000018647CD70
		public void Release(); // 0x000000018647CD70-0x000000018647CDE0
	}

	public sealed class VolumeManager // TypeDefIndex: 83527
	{
		// Fields
		private static readonly Lazy<VolumeManager> s_Instance; // 0x00
		[CompilerGenerated]
		private VolumeStack _stack_k__BackingField; // 0x10
		[CompilerGenerated]
		private System.Type[] _baseComponentTypeArray_k__BackingField; // 0x18
		private const int k_MaxLayerCount = 32; // Metadata: 0x026422C2
		private readonly Dictionary<int, List<UnityEngine.Rendering.Volume>> m_SortedVolumes; // 0x20
		private readonly List<UnityEngine.Rendering.Volume> m_Volumes; // 0x28
		private readonly Dictionary<int, bool> m_SortNeeded; // 0x30
		private readonly List<VolumeComponent> m_ComponentsDefaultState; // 0x38
		private readonly List<Collider> m_TempColliders; // 0x40
		private VolumeStack m_DefaultStack; // 0x48
	
		// Properties
		public static VolumeManager instance { get; } // 0x00000001850A5C20-0x00000001850A5C70 
		public VolumeStack stack { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		[Obsolete("Please use baseComponentTypeArray instead.")]
		public IEnumerable<System.Type> baseComponentTypes { get; private set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018D3F8324-0x000000018D3F8378
		public System.Type[] baseComponentTypeArray { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83526
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, bool> __9__25_0; // 0x08
			public static Predicate<UnityEngine.Rendering.Volume> __9__38_0; // 0x10
	
			// Constructors
			static __c(); // 0x00000001871E7400-0x00000001871E7460
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _ReloadBaseTypes_b__25_0(System.Type t); // 0x0000000186BB48F0-0x0000000186BB4920
			internal bool _GetVolumes_b__38_0(UnityEngine.Rendering.Volume v); // 0x000000018D3F7990-0x000000018D3F79DC
			internal VolumeManager _.cctor_b__42_0(); // 0x0000000186B2E380-0x0000000186B2E3D0
		}
	
		// Constructors
		private VolumeManager(); // 0x0000000186B2E3D0-0x0000000186B2E5B0
		static VolumeManager(); // 0x000000018702F230-0x000000018702F340
	
		// Methods
		public VolumeStack CreateStack(); // 0x00000001859FC850-0x00000001859FC8C0
		public void ResetMainStack(); // 0x000000018D3F82EC-0x000000018D3F8300
		public void DestroyStack(VolumeStack stack); // 0x00000001859F5AE0-0x00000001859F5B00
		private void ReloadBaseTypes(); // 0x00000001859FD310-0x00000001859FD590
		public void Register(UnityEngine.Rendering.Volume volume, int layer); // 0x00000001858AE400-0x00000001858AE600
		public void Unregister(UnityEngine.Rendering.Volume volume, int layer); // 0x00000001858AE270-0x00000001858AE400
		public bool IsComponentActiveInMask<T>(LayerMask layerMask)
			where T : VolumeComponent;
		internal void SetLayerDirty(int layer); // 0x00000001858AE600-0x00000001858AE7C0
		internal void UpdateVolumeLayer(UnityEngine.Rendering.Volume volume, int prevLayer, int newLayer); // 0x00000001858AD6D0-0x00000001858AD740
		private void OverrideData(VolumeStack stack, List<VolumeComponent> components, float interpFactor); // 0x00000001850A7CD0-0x00000001850A7E60
		private void ReplaceData(VolumeStack stack); // 0x00000001850A8B00-0x00000001850A9190
		[Conditional("UNITY_EDITOR")]
		public void CheckBaseTypes(); // 0x000000018D3F7F38-0x000000018D3F7FD0
		[Conditional("UNITY_EDITOR")]
		public void CheckStack(VolumeStack stack); // 0x000000018D3F7FD0-0x000000018D3F81B0
		private bool CheckUpdateRequired(VolumeStack stack); // 0x00000001850A5C70-0x00000001850A5CA0
		public void Update(Transform trigger, LayerMask layerMask); // 0x000000018D3F8300-0x000000018D3F8324
		public void Update(VolumeStack stack, Transform trigger, LayerMask layerMask); // 0x00000001850A7340-0x00000001850A7C40
		public UnityEngine.Rendering.Volume[] GetVolumes(LayerMask layerMask); // 0x000000018D3F81B0-0x000000018D3F82EC
		private List<UnityEngine.Rendering.Volume> GrabVolumes(LayerMask mask); // 0x00000001850A6310-0x00000001850A6EB0
		private static void SortByPriority(List<UnityEngine.Rendering.Volume> volumes); // 0x00000001863578C0-0x00000001863579E0
		private static bool IsVolumeRenderedByCamera(UnityEngine.Rendering.Volume volume, Camera camera); // 0x00000001851A4410-0x00000001851A4420
	}

	[Obsolete("VolumeIsolationScope is deprecated, it does not have any effect anymore.")]
	public struct VolumeIsolationScope : IDisposable // TypeDefIndex: 83528
	{
		// Constructors
		public VolumeIsolationScope(bool unused); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public abstract class VolumeParameter // TypeDefIndex: 83529
	{
		// Fields
		public const string k_DebuggerDisplay = "{m_Value} ({overrideState})"; // Metadata: 0x026422C3
		[FormerlySerializedAs("m_OverrideState")]
		[SerializeField]
		public bool overrideState; // 0x10
	
		// Constructors
		protected VolumeParameter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		internal abstract void Interp(VolumeParameter from, VolumeParameter to, float t);
		public T GetValue<T>();
		public abstract void SetValue(VolumeParameter parameter);
		protected internal virtual void OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
		protected internal virtual void OnDisable(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void Release(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class VolumeParameter<T> : VolumeParameter, IEquatable<VolumeParameter<T>> // TypeDefIndex: 83530
	{
		// Fields
		[SerializeField]
		protected T m_Value;
	
		// Properties
		public virtual T value { get; set; }
	
		// Constructors
		public VolumeParameter();
		protected VolumeParameter(T value, bool overrideState);
	
		// Methods
		internal override void Interp(VolumeParameter from, VolumeParameter to, float t);
		public virtual void Interp(T from, T to, float t);
		public void Override(T x);
		public override void SetValue(VolumeParameter parameter);
		public override int GetHashCode();
		public override string ToString();
		public static bool operator ==(VolumeParameter<T> lhs, T rhs);
		public static bool operator !=(VolumeParameter<T> lhs, T rhs);
		public bool Equals(VolumeParameter<T> other);
		public override bool Equals(object obj);
		public static explicit operator T(VolumeParameter<T> prop);
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class BoolParameter : VolumeParameter<bool> // TypeDefIndex: 83531
	{
		// Constructors
		public BoolParameter(bool value, bool overrideState = false /* Metadata: 0x026422DF */); // 0x000000018724EBF0-0x000000018724EC00
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class LayerMaskParameter : VolumeParameter<LayerMask> // TypeDefIndex: 83532
	{
		// Constructors
		public LayerMaskParameter(LayerMask value, bool overrideState = false /* Metadata: 0x026422E0 */); // 0x000000018D3F5034-0x000000018D3F5088
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class IntParameter : VolumeParameter<int> // TypeDefIndex: 83533
	{
		// Constructors
		public IntParameter(int value, bool overrideState = false /* Metadata: 0x026422E1 */); // 0x0000000186BD3E00-0x0000000186BD3E70
	
		// Methods
		public sealed override void Interp(int from, int to, float t); // 0x000000018725ED90-0x000000018725EDC0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpIntParameter : VolumeParameter<int> // TypeDefIndex: 83534
	{
		// Constructors
		public NoInterpIntParameter(int value, bool overrideState = false /* Metadata: 0x026422E2 */); // 0x000000018D3F6AEC-0x000000018D3F6B40
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class MinIntParameter : IntParameter // TypeDefIndex: 83535
	{
		// Fields
		[NonSerialized]
		public int min; // 0x20
	
		// Properties
		public override int value { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018D3F66BC-0x000000018D3F66C8
	
		// Constructors
		public MinIntParameter(int value, int min, bool overrideState = false /* Metadata: 0x026422E3 */); // 0x000000018D3F5728-0x000000018D3F5758
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpMinIntParameter : VolumeParameter<int> // TypeDefIndex: 83536
	{
		// Fields
		[NonSerialized]
		public int min; // 0x20
	
		// Properties
		public override int value { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018D3F66BC-0x000000018D3F66C8
	
		// Constructors
		public NoInterpMinIntParameter(int value, int min, bool overrideState = false /* Metadata: 0x026422E4 */); // 0x000000018D3F6C5C-0x000000018D3F6CB8
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class MaxIntParameter : IntParameter // TypeDefIndex: 83537
	{
		// Fields
		[NonSerialized]
		public int max; // 0x20
	
		// Properties
		public override int value { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018D3F5758-0x000000018D3F5764
	
		// Constructors
		public MaxIntParameter(int value, int max, bool overrideState = false /* Metadata: 0x026422E5 */); // 0x000000018D3F5728-0x000000018D3F5758
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpMaxIntParameter : VolumeParameter<int> // TypeDefIndex: 83538
	{
		// Fields
		[NonSerialized]
		public int max; // 0x20
	
		// Properties
		public override int value { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018D3F5758-0x000000018D3F5764
	
		// Constructors
		public NoInterpMaxIntParameter(int value, int max, bool overrideState = false /* Metadata: 0x026422E6 */); // 0x000000018D3F6BA0-0x000000018D3F6BFC
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class ClampedIntParameter : IntParameter // TypeDefIndex: 83539
	{
		// Fields
		[NonSerialized]
		public int min; // 0x20
		[NonSerialized]
		public int max; // 0x24
	
		// Properties
		public override int value { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018D3EDA68-0x000000018D3EDA88
	
		// Constructors
		public ClampedIntParameter(int value, int min, int max, bool overrideState = false /* Metadata: 0x026422E7 */); // 0x000000018783C748-0x000000018783C784
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpClampedIntParameter : VolumeParameter<int> // TypeDefIndex: 83540
	{
		// Fields
		[NonSerialized]
		public int min; // 0x20
		[NonSerialized]
		public int max; // 0x24
	
		// Properties
		public override int value { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018D3EDA68-0x000000018D3EDA88
	
		// Constructors
		public NoInterpClampedIntParameter(int value, int min, int max, bool overrideState = false /* Metadata: 0x026422E8 */); // 0x000000018D3F67E8-0x000000018D3F6848
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class FloatParameter : VolumeParameter<float> // TypeDefIndex: 83541
	{
		// Constructors
		public FloatParameter(float value, bool overrideState = false /* Metadata: 0x026422E9 */); // 0x000000018724EC30-0x000000018724EC40
	
		// Methods
		public sealed override void Interp(float from, float to, float t); // 0x000000018725ECD0-0x000000018725ECF0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpFloatParameter : VolumeParameter<float> // TypeDefIndex: 83542
	{
		// Constructors
		public NoInterpFloatParameter(float value, bool overrideState = false /* Metadata: 0x026422EA */); // 0x000000018D3F6A20-0x000000018D3F6A7C
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class MinFloatParameter : FloatParameter // TypeDefIndex: 83543
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
	
		// Properties
		public override float value { get; set; } // 0x0000000187233050-0x0000000187233060 0x000000018D3F66AC-0x000000018D3F66BC
	
		// Constructors
		public MinFloatParameter(float value, float min, bool overrideState = false /* Metadata: 0x026422EB */); // 0x000000018725EDC0-0x000000018725EDD0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpMinFloatParameter : VolumeParameter<float> // TypeDefIndex: 83544
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
	
		// Properties
		public override float value { get; set; } // 0x0000000187233050-0x0000000187233060 0x000000018D3F66AC-0x000000018D3F66BC
	
		// Constructors
		public NoInterpMinFloatParameter(float value, float min, bool overrideState = false /* Metadata: 0x026422EC */); // 0x000000018D3F6BFC-0x000000018D3F6C5C
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class MaxFloatParameter : FloatParameter // TypeDefIndex: 83545
	{
		// Fields
		[NonSerialized]
		public float max; // 0x20
	
		// Properties
		public override float value { get; set; } // 0x0000000187233050-0x0000000187233060 0x000000018D3F5718-0x000000018D3F5728
	
		// Constructors
		public MaxFloatParameter(float value, float max, bool overrideState = false /* Metadata: 0x026422ED */); // 0x000000018725EDC0-0x000000018725EDD0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpMaxFloatParameter : VolumeParameter<float> // TypeDefIndex: 83546
	{
		// Fields
		[NonSerialized]
		public float max; // 0x20
	
		// Properties
		public override float value { get; set; } // 0x0000000187233050-0x0000000187233060 0x000000018D3F5718-0x000000018D3F5728
	
		// Constructors
		public NoInterpMaxFloatParameter(float value, float max, bool overrideState = false /* Metadata: 0x026422EE */); // 0x000000018D3F6B40-0x000000018D3F6BA0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class ClampedFloatParameter : FloatParameter // TypeDefIndex: 83547
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
		[NonSerialized]
		public float sliderExponent; // 0x28
	
		// Properties
		public override float value { get; set; } // 0x0000000187233050-0x0000000187233060 0x00000001862B74E0-0x00000001862B7510
	
		// Constructors
		public ClampedFloatParameter(float value, float min, float max, float sliderExponent, bool overrideState = false /* Metadata: 0x026422EF */); // 0x000000018725E5B0-0x000000018725E5E0
		public ClampedFloatParameter(float value, float min, float max, bool overrideState = false /* Metadata: 0x026422F0 */); // 0x000000018725E5E0-0x000000018725E600
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpClampedFloatParameter : VolumeParameter<float> // TypeDefIndex: 83548
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
		[NonSerialized]
		public float sliderExponent; // 0x28
	
		// Properties
		public override float value { get; set; } // 0x0000000187233050-0x0000000187233060 0x000000018D3F67C0-0x000000018D3F67E8
	
		// Constructors
		public NoInterpClampedFloatParameter(float value, float min, float max, float sliderExponent, bool overrideState = false /* Metadata: 0x026422F1 */); // 0x000000018D3F6740-0x000000018D3F67C0
		public NoInterpClampedFloatParameter(float value, float min, float max, bool overrideState = false /* Metadata: 0x026422F2 */); // 0x000000018D3F66C8-0x000000018D3F6740
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class UnclampedFloatParameter : FloatParameter // TypeDefIndex: 83549
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
		[NonSerialized]
		public float sliderExponent; // 0x28
	
		// Properties
		public override float value { get; set; } // 0x0000000187233050-0x0000000187233060 0x0000000187233060-0x0000000187233070
	
		// Constructors
		public UnclampedFloatParameter(float value, float min, float max, float sliderExponent, bool overrideState = false /* Metadata: 0x026422F3 */); // 0x000000018725E5B0-0x000000018725E5E0
		public UnclampedFloatParameter(float value, float min, float max, bool overrideState = false /* Metadata: 0x026422F4 */); // 0x000000018725E5E0-0x000000018725E600
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpUnclampedFloatParameter : VolumeParameter<float> // TypeDefIndex: 83550
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
		[NonSerialized]
		public float sliderExponent; // 0x28
	
		// Properties
		public override float value { get; set; } // 0x0000000187233050-0x0000000187233060 0x0000000187233060-0x0000000187233070
	
		// Constructors
		public NoInterpUnclampedFloatParameter(float value, float min, float max, float sliderExponent, bool overrideState = false /* Metadata: 0x026422F5 */); // 0x000000018D3F6EE8-0x000000018D3F6F68
		public NoInterpUnclampedFloatParameter(float value, float min, float max, bool overrideState = false /* Metadata: 0x026422F6 */); // 0x000000018D3F6F68-0x000000018D3F6FE0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class FloatRangeParameter : VolumeParameter<Vector2> // TypeDefIndex: 83551
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
	
		// Properties
		public override Vector2 value { get; set; } // 0x0000000187240350-0x0000000187240370 0x000000018D3F4730-0x000000018D3F4758
	
		// Constructors
		public FloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false /* Metadata: 0x026422F7 */); // 0x00000001857722B0-0x00000001857723C0
	
		// Methods
		public override void Interp(Vector2 from, Vector2 to, float t); // 0x000000018725ECF0-0x000000018725ED40
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpFloatRangeParameter : VolumeParameter<Vector2> // TypeDefIndex: 83552
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
	
		// Properties
		public override Vector2 value { get; set; } // 0x0000000187240350-0x0000000187240370 0x000000018D3F4730-0x000000018D3F4758
	
		// Constructors
		public NoInterpFloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false /* Metadata: 0x026422F8 */); // 0x000000018D3F6A7C-0x000000018D3F6AEC
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class ColorParameter : VolumeParameter<UnityEngine.Color> // TypeDefIndex: 83553
	{
		// Fields
		[NonSerialized]
		public bool hdr; // 0x28
		[NonSerialized]
		public bool showAlpha; // 0x29
		[NonSerialized]
		public bool showEyeDropper; // 0x2A
	
		// Constructors
		public ColorParameter(UnityEngine.Color value, bool overrideState = false /* Metadata: 0x026422F9 */); // 0x000000018725E690-0x000000018725E6B0
		public ColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false /* Metadata: 0x026422FA */); // 0x000000018725E670-0x000000018725E690
	
		// Methods
		public override void Interp(UnityEngine.Color from, UnityEngine.Color to, float t); // 0x000000018725E600-0x000000018725E670
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpColorParameter : VolumeParameter<UnityEngine.Color> // TypeDefIndex: 83554
	{
		// Fields
		public bool hdr; // 0x28
		[NonSerialized]
		public bool showAlpha; // 0x29
		[NonSerialized]
		public bool showEyeDropper; // 0x2A
	
		// Constructors
		public NoInterpColorParameter(UnityEngine.Color value, bool overrideState = false /* Metadata: 0x026422FB */); // 0x000000018D3F6848-0x000000018D3F68A0
		public NoInterpColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false /* Metadata: 0x026422FC */); // 0x000000018D3F68A0-0x000000018D3F6910
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class Vector2Parameter : VolumeParameter<Vector2> // TypeDefIndex: 83555
	{
		// Constructors
		public Vector2Parameter(Vector2 value, bool overrideState = false /* Metadata: 0x026422FD */); // 0x000000018724EC40-0x000000018724EC50
	
		// Methods
		public override void Interp(Vector2 from, Vector2 to, float t); // 0x000000018725ECF0-0x000000018725ED40
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpVector2Parameter : VolumeParameter<Vector2> // TypeDefIndex: 83556
	{
		// Constructors
		public NoInterpVector2Parameter(Vector2 value, bool overrideState = false /* Metadata: 0x026422FE */); // 0x000000018D3F6FE0-0x000000018D3F703C
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class Vector3Parameter : VolumeParameter<Vector3> // TypeDefIndex: 83557
	{
		// Constructors
		public Vector3Parameter(Vector3 value, bool overrideState = false /* Metadata: 0x026422FF */); // 0x00000001867FBD10-0x00000001867FBD70
	
		// Methods
		public override void Interp(Vector3 from, Vector3 to, float t); // 0x00000001866A63F0-0x00000001866A6440
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpVector3Parameter : VolumeParameter<Vector3> // TypeDefIndex: 83558
	{
		// Constructors
		public NoInterpVector3Parameter(Vector3 value, bool overrideState = false /* Metadata: 0x02642300 */); // 0x000000018D3F703C-0x000000018D3F7094
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class Vector4Parameter : VolumeParameter<Vector4> // TypeDefIndex: 83559
	{
		// Constructors
		public Vector4Parameter(Vector4 value, bool overrideState = false /* Metadata: 0x02642301 */); // 0x000000018724EC50-0x000000018724EC60
	
		// Methods
		public override void Interp(Vector4 from, Vector4 to, float t); // 0x000000018725E600-0x000000018725E670
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpVector4Parameter : VolumeParameter<Vector4> // TypeDefIndex: 83560
	{
		// Constructors
		public NoInterpVector4Parameter(Vector4 value, bool overrideState = false /* Metadata: 0x02642302 */); // 0x000000018D3F7094-0x000000018D3F70E4
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class TextureParameter : VolumeParameter<Texture> // TypeDefIndex: 83561
	{
		// Fields
		public TextureDimension dimension; // 0x20
	
		// Constructors
		public TextureParameter(Texture value, bool overrideState = false /* Metadata: 0x02642303 */); // 0x000000018783D25C-0x000000018783D280
		public TextureParameter(Texture value, TextureDimension dimension, bool overrideState = false /* Metadata: 0x02642304 */); // 0x0000000186D40F20-0x0000000186D40F90
	
		// Methods
		public override int GetHashCode(); // 0x000000018D3F76F0-0x000000018D3F77B0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpTextureParameter : VolumeParameter<Texture> // TypeDefIndex: 83562
	{
		// Constructors
		public NoInterpTextureParameter(Texture value, bool overrideState = false /* Metadata: 0x02642305 */); // 0x000000018D3F6E90-0x000000018D3F6EE8
	
		// Methods
		public override int GetHashCode(); // 0x000000018D3F6DD0-0x000000018D3F6E90
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class Texture2DParameter : VolumeParameter<Texture> // TypeDefIndex: 83563
	{
		// Constructors
		public Texture2DParameter(Texture value, bool overrideState = false /* Metadata: 0x02642306 */); // 0x0000000185DD3B70-0x0000000185DD3BD0
	
		// Methods
		public override int GetHashCode(); // 0x000000018D3F73F4-0x000000018D3F74B4
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class Texture3DParameter : VolumeParameter<Texture> // TypeDefIndex: 83564
	{
		// Constructors
		public Texture3DParameter(Texture value, bool overrideState = false /* Metadata: 0x02642307 */); // 0x0000000185DD1D00-0x0000000185DD1D60
	
		// Methods
		public override int GetHashCode(); // 0x000000018D3F74B4-0x000000018D3F7574
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class RenderTextureParameter : VolumeParameter<RenderTexture> // TypeDefIndex: 83565
	{
		// Constructors
		public RenderTextureParameter(RenderTexture value, bool overrideState = false /* Metadata: 0x02642308 */); // 0x000000018D3F71F8-0x000000018D3F7250
	
		// Methods
		public override int GetHashCode(); // 0x000000018D3F7138-0x000000018D3F71F8
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpRenderTextureParameter : VolumeParameter<RenderTexture> // TypeDefIndex: 83566
	{
		// Constructors
		public NoInterpRenderTextureParameter(RenderTexture value, bool overrideState = false /* Metadata: 0x02642309 */); // 0x000000018D3F6D78-0x000000018D3F6DD0
	
		// Methods
		public override int GetHashCode(); // 0x000000018D3F6CB8-0x000000018D3F6D78
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class CubemapParameter : VolumeParameter<Texture> // TypeDefIndex: 83567
	{
		// Constructors
		public CubemapParameter(Texture value, bool overrideState = false /* Metadata: 0x0264230A */); // 0x0000000185DD3B10-0x0000000185DD3B70
	
		// Methods
		public override int GetHashCode(); // 0x000000018D3F1E34-0x000000018D3F1EF4
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpCubemapParameter : VolumeParameter<Cubemap> // TypeDefIndex: 83568
	{
		// Constructors
		public NoInterpCubemapParameter(Cubemap value, bool overrideState = false /* Metadata: 0x0264230B */); // 0x000000018D3F69C8-0x000000018D3F6A20
	
		// Methods
		public override int GetHashCode(); // 0x000000018D3F6910-0x000000018D3F69C8
	}

	[Serializable]
	public class AnimationCurveParameter : VolumeParameter<AnimationCurve> // TypeDefIndex: 83569
	{
		// Constructors
		public AnimationCurveParameter(AnimationCurve value, bool overrideState = false /* Metadata: 0x0264230C */); // 0x0000000185771E30-0x0000000185771E90
	}

	public sealed class VolumeProfile : ScriptableObject // TypeDefIndex: 83571
	{
		// Fields
		public List<VolumeComponent> components; // 0x18
		[NonSerialized]
		public bool isDirty; // 0x20
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83570
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<VolumeComponent> __9__2_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E64A0-0x00000001871E6500
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _OnEnable_b__2_0(VolumeComponent x); // 0x0000000185625130-0x00000001856251C0
		}
	
		// Constructors
		public VolumeProfile(); // 0x0000000186B2E5B0-0x0000000186B2E640
	
		// Methods
		private void OnEnable(); // 0x0000000186B9F7A0-0x0000000186B9F8E0
		internal void OnDisable(); // 0x000000018647CC40-0x000000018647CD60
		public void Reset(); // 0x000000018723D2B0-0x000000018723D2C0
		public T Add<T>(bool overrides = false /* Metadata: 0x0264230D */)
			where T : VolumeComponent;
		public VolumeComponent Add(System.Type type, bool overrides = false /* Metadata: 0x0264230E */); // 0x00000001850AA140-0x00000001850AA210
		public void Remove<T>()
			where T : VolumeComponent;
		public void Remove(System.Type type); // 0x000000018D3F8600-0x000000018D3F86DC
		public bool Has<T>()
			where T : VolumeComponent;
		public bool Has(System.Type type); // 0x00000001850A9CB0-0x00000001850A9DC0
		public bool HasSubclassOf(System.Type type); // 0x000000018D3F84B0-0x000000018D3F8600
		public bool TryGet<T>(out ref T component)
			where T : VolumeComponent;
		public bool TryGet<T>(System.Type type, out ref T component)
			where T : VolumeComponent;
		public bool TryGetSubclassOf<T>(System.Type type, out ref T component)
			where T : VolumeComponent;
		public bool TryGetAllSubclassOf<T>(System.Type type, List<T> result)
			where T : VolumeComponent;
		public override int GetHashCode(); // 0x000000018D3F841C-0x000000018D3F84B0
		internal int GetComponentListHashCode(); // 0x000000018D3F8378-0x000000018D3F841C
		internal void Sanitize(); // 0x000000018D3F86DC-0x000000018D3F87A8
	}

	public sealed class VolumeStack : IDisposable // TypeDefIndex: 83572
	{
		// Fields
		internal readonly Dictionary<System.Type, VolumeComponent> components; // 0x10
		[TupleElementNames(new string[2] {"parameter", "defaultValue" })]
		public ValueTuple<VolumeParameter, VolumeParameter>[] defaultParameters; // 0x18
		internal bool requiresReset; // 0x20
	
		// Constructors
		internal VolumeStack(); // 0x00000001859FC8C0-0x00000001859FC940
	
		// Methods
		internal void Reload(List<VolumeComponent> componentDefaultStates); // 0x00000001859FD590-0x00000001859FDAB0
		public T GetComponent<T>()
			where T : VolumeComponent;
		public VolumeComponent GetComponent(System.Type type); // 0x00000001850A7E60-0x00000001850A7EA0
		public void Dispose(); // 0x00000001859F7CC0-0x00000001859F7F00
	}

	public static class XRGraphicsAutomatedTests // TypeDefIndex: 83573
	{
		// Fields
		[CompilerGenerated]
		private static readonly bool _enabled_k__BackingField; // 0x00
		public static bool running; // 0x01
	
		// Properties
		private static bool activatedFromCommandLine { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public static bool enabled { [CompilerGenerated] get; } // 0x000000018D3F8840-0x000000018D3F8890 
	
		// Constructors
		static XRGraphicsAutomatedTests(); // 0x000000018D3F87F8-0x000000018D3F8840
	}
}

namespace UnityEngine.Rendering.LookDev
{
	public interface IDataProvider // TypeDefIndex: 83574
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

	public struct Sky // TypeDefIndex: 83575
	{
		// Fields
		public Cubemap cubemap; // 0x00
		public float longitudeOffset; // 0x08
		public float exposure; // 0x0C
	}

	public class StageRuntimeInterface // TypeDefIndex: 83576
	{
		// Fields
		private Func<bool, GameObject> m_AddGameObject; // 0x10
		private Func<Camera> m_GetCamera; // 0x18
		private Func<Light> m_GetSunLight; // 0x20
		public object SRPData; // 0x28
	
		// Properties
		public Camera camera { get; } // 0x000000018D3F73B4-0x000000018D3F73D4 
		public Light sunLight { get; } // 0x000000018D3F73D4-0x000000018D3F73F4 
	
		// Constructors
		public StageRuntimeInterface(Func<bool, GameObject> AddGameObject, Func<Camera> GetCamera, Func<Light> GetSunLight); // 0x00000001854F5A50-0x00000001854F5A90
	
		// Methods
		public GameObject AddGameObject(bool persistent = false /* Metadata: 0x0264230F */); // 0x000000018D3F7390-0x000000018D3F73B4
	}
}

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerBitField : DebugUIHandlerWidget // TypeDefIndex: 83577
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UIFoldout valueToggle; // 0x60
		public List<DebugUIHandlerIndirectToggle> toggles; // 0x68
		private DebugUI.BitField m_Field; // 0x70
		private DebugUIHandlerContainer m_Container; // 0x78
	
		// Constructors
		public DebugUIHandlerBitField(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3F2498-0x000000018D3F27E4
		private bool GetValue(int index); // 0x000000018D3F1EF4-0x000000018D3F1F8C
		private void SetValue(int index, bool value); // 0x000000018D3F21C0-0x000000018D3F2498
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3F20E4-0x000000018D3F21C0
		public override void OnDeselection(); // 0x000000018D3F208C-0x000000018D3F20BC
		public override void OnIncrement(bool fast); // 0x000000018D3F20BC-0x000000018D3F20E4
		public override void OnDecrement(bool fast); // 0x000000018D3F2068-0x000000018D3F208C
		public override void OnAction(); // 0x000000018D3F2038-0x000000018D3F2068
		public override DebugUIHandlerWidget Next(); // 0x000000018D3F1F8C-0x000000018D3F2038
	}

	public class DebugUIHandlerButton : DebugUIHandlerWidget // TypeDefIndex: 83578
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		private DebugUI.Button m_Field; // 0x60
	
		// Constructors
		public DebugUIHandlerButton(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3F284C-0x000000018D3F28D0
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3F2818-0x000000018D3F284C
		public override void OnDeselection(); // 0x000000018D3F208C-0x000000018D3F20BC
		public override void OnAction(); // 0x000000018D3F27EC-0x000000018D3F2818
	}

	[Serializable]
	public class DebugUIPrefabBundle // TypeDefIndex: 83579
	{
		// Fields
		public string type; // 0x10
		public RectTransform prefab; // 0x18
	
		// Constructors
		public DebugUIPrefabBundle(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class DebugUIHandlerCanvas : MonoBehaviour // TypeDefIndex: 83582
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
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83580
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<DebugUI.Widget, bool> __9__12_0; // 0x08
			public static Action<DebugUIHandlerPanel> __9__15_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D3FF200-0x000000018D3FF264
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _Rebuild_b__12_0(DebugUI.Widget x); // 0x000000018D3FF12C-0x000000018D3FF15C
			internal void _ActivatePanel_b__15_0(DebugUIHandlerPanel p); // 0x000000018D3FF0F8-0x000000018D3FF12C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 83581
		{
			// Fields
			public string queryPath; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetWidgetFromPath_b__0(DebugUIHandlerWidget w); // 0x000000018D3FF15C-0x000000018D3FF18C
		}
	
		// Constructors
		public DebugUIHandlerCanvas(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void OnEnable(); // 0x000000018D3F30F0-0x000000018D3F3240
		private void Update(); // 0x000000018D3F41EC-0x000000018D3F42F4
		internal void RequestHierarchyReset(); // 0x0000000187234900-0x0000000187234910
		private void ResetAllHierarchy(); // 0x000000018D3F3960-0x000000018D3F3B1C
		private void Rebuild(); // 0x000000018D3F3240-0x000000018D3F3960
		private void Traverse(DebugUI.IContainer container, Transform parentTransform, DebugUIHandlerWidget parentUIHandler, ref DebugUIHandlerWidget selectedHandler); // 0x000000018D3F3E14-0x000000018D3F41EC
		private DebugUIHandlerWidget GetWidgetFromPath(string queryPath); // 0x000000018D3F2DB0-0x000000018D3F2EDC
		private void ActivatePanel(int index, DebugUIHandlerWidget selectedWidget = null); // 0x000000018D3F28D0-0x000000018D3F2AD8
		internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext); // 0x000000018D3F2C24-0x000000018D3F2DB0
		internal void SelectPreviousItem(); // 0x000000018D3F3C38-0x000000018D3F3CD4
		internal void SelectNextPanel(); // 0x000000018D3F3BD0-0x000000018D3F3C38
		internal void SelectPreviousPanel(); // 0x000000018D3F3CD4-0x000000018D3F3D44
		internal void SelectNextItem(); // 0x000000018D3F3B1C-0x000000018D3F3BD0
		private void ChangeSelectionValue(float multiplier); // 0x000000018D3F2B48-0x000000018D3F2C24
		private void ActivateSelection(); // 0x000000018D3F2AD8-0x000000018D3F2B48
		private void HandleInput(); // 0x000000018D3F2EDC-0x000000018D3F30F0
		internal void SetScrollTarget(DebugUIHandlerWidget widget); // 0x000000018D3F3D44-0x000000018D3F3E14
	}

	public class DebugUIHandlerColor : DebugUIHandlerWidget // TypeDefIndex: 83583
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
		public DebugUIHandlerColor(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3F8BD4-0x000000018D3F90C0
		private void SetValue(float x, bool r = false /* Metadata: 0x02642310 */, bool g = false /* Metadata: 0x02642311 */, bool b = false /* Metadata: 0x02642312 */, bool a = false /* Metadata: 0x02642313 */); // 0x000000018D3F8AC0-0x000000018D3F8BD4
		private void SetupSettings(DebugUIHandlerIndirectFloatField field); // 0x000000018D3F90C0-0x000000018D3F91FC
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3F89DC-0x000000018D3F8AC0
		public override void OnDeselection(); // 0x000000018D3F208C-0x000000018D3F20BC
		public override void OnIncrement(bool fast); // 0x000000018D3F20BC-0x000000018D3F20E4
		public override void OnDecrement(bool fast); // 0x000000018D3F2068-0x000000018D3F208C
		public override void OnAction(); // 0x000000018D3F2038-0x000000018D3F2068
		internal void UpdateColor(); // 0x000000018D3F9450-0x000000018D3F94FC
		public override DebugUIHandlerWidget Next(); // 0x000000018D3F8928-0x000000018D3F89DC
		[CompilerGenerated]
		private float _SetWidget_b__9_0(); // 0x000000018D3F91FC-0x000000018D3F9250
		[CompilerGenerated]
		private void _SetWidget_b__9_1(float x); // 0x000000018D3F9250-0x000000018D3F9278
		[CompilerGenerated]
		private float _SetWidget_b__9_2(); // 0x000000018D3F9278-0x000000018D3F92CC
		[CompilerGenerated]
		private void _SetWidget_b__9_3(float x); // 0x000000018D3F92CC-0x000000018D3F92F4
		[CompilerGenerated]
		private float _SetWidget_b__9_4(); // 0x000000018D3F92F4-0x000000018D3F9348
		[CompilerGenerated]
		private void _SetWidget_b__9_5(float x); // 0x000000018D3F9348-0x000000018D3F9370
		[CompilerGenerated]
		private float _SetWidget_b__9_6(); // 0x000000018D3F9370-0x000000018D3F93C4
		[CompilerGenerated]
		private void _SetWidget_b__9_7(float x); // 0x000000018D3F93C4-0x000000018D3F93EC
		[CompilerGenerated]
		private float _SetupSettings_b__11_0(); // 0x000000018D3F93EC-0x000000018D3F940C
		[CompilerGenerated]
		private float _SetupSettings_b__11_1(); // 0x000000018D3F940C-0x000000018D3F942C
		[CompilerGenerated]
		private float _SetupSettings_b__11_2(); // 0x000000018D3F942C-0x000000018D3F9450
	}

	public class DebugUIHandlerContainer : MonoBehaviour // TypeDefIndex: 83585
	{
		// Fields
		[SerializeField]
		public RectTransform contentHolder; // 0x18
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 83584
		{
			// Fields
			public DebugUIHandlerWidget widget; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _IsDirectChild_b__0(DebugUIHandlerWidget x); // 0x000000018D3FF18C-0x000000018D3FF1E0
		}
	
		// Constructors
		public DebugUIHandlerContainer(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		internal DebugUIHandlerWidget GetFirstItem(); // 0x000000018D3F9754-0x000000018D3F97D4
		internal DebugUIHandlerWidget GetLastItem(); // 0x000000018D3F97D4-0x000000018D3F9858
		internal bool IsDirectChild(DebugUIHandlerWidget widget); // 0x000000018D3F9858-0x000000018D3F9950
		private List<DebugUIHandlerWidget> GetActiveChildren(); // 0x000000018D3F94FC-0x000000018D3F9754
	}

	public class DebugUIHandlerEnumField : DebugUIHandlerWidget // TypeDefIndex: 83586
	{
		// Fields
		public UI.Text nextButtonText; // 0x58
		public UI.Text previousButtonText; // 0x60
		public UI.Text nameLabel; // 0x68
		public UI.Text valueLabel; // 0x70
		protected internal DebugUI.EnumField m_Field; // 0x78
	
		// Constructors
		public DebugUIHandlerEnumField(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3F9E7C-0x000000018D3F9F0C
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3F9D70-0x000000018D3F9E7C
		public override void OnDeselection(); // 0x000000018D3F9B18-0x000000018D3F9C20
		public override void OnAction(); // 0x000000018D3F9950-0x000000018D3F9960
		public override void OnIncrement(bool fast); // 0x000000018D3F9C20-0x000000018D3F9D70
		public override void OnDecrement(bool fast); // 0x000000018D3F9960-0x000000018D3F9B18
		protected virtual void UpdateValueLabel(); // 0x000000018D3F9F0C-0x000000018D3F9FC8
	}

	public class DebugUIHandlerEnumHistory : DebugUIHandlerEnumField // TypeDefIndex: 83588
	{
		// Fields
		private UI.Text[] historyValues; // 0x80
		private const float xDecal = 60f; // Metadata: 0x02642314
	
		// Nested types
		[CompilerGenerated]
		private sealed class _RefreshAfterSanitization_d__4 : IEnumerator<object> // TypeDefIndex: 83587
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DebugUIHandlerEnumHistory __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _RefreshAfterSanitization_d__4(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D3FEF74-0x000000018D3FF060
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D3FF0AC-0x000000018D3FF0F8
		}
	
		// Constructors
		public DebugUIHandlerEnumHistory(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3FA024-0x000000018D3FA264
		protected override void UpdateValueLabel(); // 0x000000018D3FA264-0x000000018D3FA44C
		[IteratorStateMachine(typeof(_RefreshAfterSanitization_d__4))]
		private IEnumerator RefreshAfterSanitization(); // 0x000000018D3F9FC8-0x000000018D3FA024
	}

	public class DebugUIHandlerFloatField : DebugUIHandlerWidget // TypeDefIndex: 83589
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UI.Text valueLabel; // 0x60
		private DebugUI.FloatField m_Field; // 0x68
	
		// Constructors
		public DebugUIHandlerFloatField(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3FA5D8-0x000000018D3FA668
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3FA57C-0x000000018D3FA5D8
		public override void OnDeselection(); // 0x000000018D3FA510-0x000000018D3FA56C
		public override void OnIncrement(bool fast); // 0x000000018D3FA56C-0x000000018D3FA57C
		public override void OnDecrement(bool fast); // 0x000000018D3FA500-0x000000018D3FA510
		private void ChangeValue(bool fast, float multiplier); // 0x000000018D3FA44C-0x000000018D3FA500
		private void UpdateValueLabel(); // 0x000000018D3FA668-0x000000018D3FA718
	}

	public class DebugUIHandlerFoldout : DebugUIHandlerWidget // TypeDefIndex: 83590
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UIFoldout valueToggle; // 0x60
		private DebugUI.Foldout m_Field; // 0x68
		private DebugUIHandlerContainer m_Container; // 0x70
		private const float xDecal = 60f; // Metadata: 0x02642318
		private const float xDecalInit = 230f; // Metadata: 0x0264231C
	
		// Constructors
		public DebugUIHandlerFoldout(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3FA914-0x000000018D3FACF8
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3FA838-0x000000018D3FA914
		public override void OnDeselection(); // 0x000000018D3F208C-0x000000018D3F20BC
		public override void OnIncrement(bool fast); // 0x000000018D3FA814-0x000000018D3FA838
		public override void OnDecrement(bool fast); // 0x000000018D3FA7F0-0x000000018D3FA814
		public override void OnAction(); // 0x000000018D3FA7C4-0x000000018D3FA7F0
		private void UpdateValue(); // 0x000000018D3FACF8-0x000000018D3FAD2C
		public override DebugUIHandlerWidget Next(); // 0x000000018D3FA718-0x000000018D3FA7C4
	}

	public class DebugUIHandlerGroup : DebugUIHandlerWidget // TypeDefIndex: 83591
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public Transform header; // 0x60
		private DebugUI.Container m_Field; // 0x68
		private DebugUIHandlerContainer m_Container; // 0x70
	
		// Constructors
		public DebugUIHandlerGroup(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3FAE74-0x000000018D3FAF58
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3FADC8-0x000000018D3FAE74
		public override DebugUIHandlerWidget Next(); // 0x000000018D3FAD2C-0x000000018D3FADC8
	}

	public class DebugUIHandlerHBox : DebugUIHandlerWidget // TypeDefIndex: 83592
	{
		// Fields
		private DebugUIHandlerContainer m_Container; // 0x58
	
		// Constructors
		public DebugUIHandlerHBox(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3FB0A0-0x000000018D3FB100
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3FAFF4-0x000000018D3FB0A0
		public override DebugUIHandlerWidget Next(); // 0x000000018D3FAF58-0x000000018D3FAFF4
	}

	public class DebugUIHandlerIndirectFloatField : DebugUIHandlerWidget // TypeDefIndex: 83593
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
		public DebugUIHandlerIndirectFloatField(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		public void Init(); // 0x000000018D3FB1BC-0x000000018D3FB1C4
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3FA57C-0x000000018D3FA5D8
		public override void OnDeselection(); // 0x000000018D3FA510-0x000000018D3FA56C
		public override void OnIncrement(bool fast); // 0x000000018D3FB1D4-0x000000018D3FB1E4
		public override void OnDecrement(bool fast); // 0x000000018D3FB1C4-0x000000018D3FB1D4
		private void ChangeValue(bool fast, float multiplier); // 0x000000018D3FB100-0x000000018D3FB1BC
		private void UpdateValueLabel(); // 0x000000018D3FB1E4-0x000000018D3FB2C0
	}

	public class DebugUIHandlerIndirectToggle : DebugUIHandlerWidget // TypeDefIndex: 83594
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public Toggle valueToggle; // 0x60
		public Image checkmarkImage; // 0x68
		public Func<int, bool> getter; // 0x70
		public Action<int, bool> setter; // 0x78
		internal int index; // 0x80
	
		// Constructors
		public DebugUIHandlerIndirectToggle(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		public void Init(); // 0x000000018D3FB2C0-0x000000018D3FB378
		private void OnToggleValueChanged(bool value); // 0x000000018D3FB484-0x000000018D3FB4B4
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3FB428-0x000000018D3FB484
		public override void OnDeselection(); // 0x000000018D3FB3CC-0x000000018D3FB428
		public override void OnAction(); // 0x000000018D3FB378-0x000000018D3FB3CC
		internal void UpdateValueLabel(); // 0x000000018D3FB4B4-0x000000018D3FB540
	}

	public class DebugUIHandlerIntField : DebugUIHandlerWidget // TypeDefIndex: 83595
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UI.Text valueLabel; // 0x60
		private DebugUI.IntField m_Field; // 0x68
	
		// Constructors
		public DebugUIHandlerIntField(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3FB614-0x000000018D3FB6A4
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3FA57C-0x000000018D3FA5D8
		public override void OnDeselection(); // 0x000000018D3FA510-0x000000018D3FA56C
		public override void OnIncrement(bool fast); // 0x000000018D3FB604-0x000000018D3FB614
		public override void OnDecrement(bool fast); // 0x000000018D3FB5F4-0x000000018D3FB604
		private void ChangeValue(bool fast, int multiplier); // 0x000000018D3FB540-0x000000018D3FB5F4
		private void UpdateValueLabel(); // 0x000000018D3FB6A4-0x000000018D3FB75C
	}

	public class DebugUIHandlerMessageBox : DebugUIHandlerWidget // TypeDefIndex: 83596
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		private DebugUI.MessageBox m_Field; // 0x60
		private static Color32 k_WarningBackgroundColor; // 0x00
		private static Color32 k_WarningTextColor; // 0x04
		private static Color32 k_ErrorBackgroundColor; // 0x08
		private static Color32 k_ErrorTextColor; // 0x0C
	
		// Constructors
		public DebugUIHandlerMessageBox(); // 0x000000018D3F27E4-0x000000018D3F27EC
		static DebugUIHandlerMessageBox(); // 0x000000018D3FB88C-0x000000018D3FB924
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3FB75C-0x000000018D3FB88C
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x00000001843FFFF0-0x0000000184400000
	}

	public class DebugUIHandlerPanel : MonoBehaviour // TypeDefIndex: 83597
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
		public DebugUIHandlerPanel(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void OnEnable(); // 0x000000018D3FBAAC-0x000000018D3FBB68
		internal void SetPanel(DebugUI.Panel panel); // 0x000000018D3FBC44-0x000000018D3FBC80
		internal DebugUI.Panel GetPanel(); // 0x0000000187232F70-0x0000000187232F80
		public void SelectNextItem(); // 0x000000018D3FBC04-0x000000018D3FBC24
		public void SelectPreviousItem(); // 0x000000018D3FBC24-0x000000018D3FBC44
		public void OnScrollbarClicked(); // 0x000000018D3FBB68-0x000000018D3FBBB8
		internal void SetScrollTarget(DebugUIHandlerWidget target); // 0x00000001869E1E00-0x00000001869E1E10
		internal void UpdateScroll(); // 0x000000018D3FBC80-0x000000018D3FBE08
		private float GetYPosInScroll(RectTransform target); // 0x000000018D3FB974-0x000000018D3FBAAC
		internal DebugUIHandlerWidget GetFirstItem(); // 0x000000018D3FB924-0x000000018D3FB974
		public void ResetDebugManager(); // 0x000000018D3FBBB8-0x000000018D3FBC04
	}

	internal class DebugUIHandlerPersistentCanvas : MonoBehaviour // TypeDefIndex: 83599
	{
		// Fields
		public RectTransform panel; // 0x18
		public RectTransform valuePrefab; // 0x20
		private List<DebugUIHandlerValue> m_Items; // 0x28
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 83598
		{
			// Fields
			public DebugUI.Value widget; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _Toggle_b__0(DebugUIHandlerValue x); // 0x000000018D3FF1E0-0x000000018D3FF200
		}
	
		// Constructors
		public DebugUIHandlerPersistentCanvas(); // 0x000000018D3FC1C8-0x000000018D3FC248
	
		// Methods
		internal void Toggle(DebugUI.Value widget); // 0x000000018D3FBF84-0x000000018D3FC1C8
		internal void Clear(); // 0x000000018D3FBE08-0x000000018D3FBF84
	}

	public class DebugUIHandlerRow : DebugUIHandlerFoldout // TypeDefIndex: 83600
	{
		// Fields
		private float m_Timer; // 0x78
	
		// Constructors
		public DebugUIHandlerRow(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		protected override void OnEnable(); // 0x000000018725EDF0-0x000000018725EE00
		protected void Update(); // 0x000000018D3FC248-0x000000018D3FC610
	}

	public class DebugUIHandlerToggle : DebugUIHandlerWidget // TypeDefIndex: 83601
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public Toggle valueToggle; // 0x60
		public Image checkmarkImage; // 0x68
		protected internal DebugUI.BoolField m_Field; // 0x70
	
		// Constructors
		public DebugUIHandlerToggle(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3FCBD4-0x000000018D3FCCE4
		private void OnToggleValueChanged(bool value); // 0x000000018D3FCB80-0x000000018D3FCBD4
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3FB428-0x000000018D3FB484
		public override void OnDeselection(); // 0x000000018D3FB3CC-0x000000018D3FB428
		public override void OnAction(); // 0x000000018D3FCB08-0x000000018D3FCB80
		protected internal virtual void UpdateValueLabel(); // 0x000000018D3FCCE4-0x000000018D3FCD7C
	}

	public class DebugUIHandlerToggleHistory : DebugUIHandlerToggle // TypeDefIndex: 83603
	{
		// Fields
		private Toggle[] historyToggles; // 0x78
		private const float xDecal = 60f; // Metadata: 0x02642320
	
		// Nested types
		[CompilerGenerated]
		private sealed class _RefreshAfterSanitization_d__4 : IEnumerator<object> // TypeDefIndex: 83602
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DebugUIHandlerToggleHistory __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _RefreshAfterSanitization_d__4(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D3FEED0-0x000000018D3FEF74
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D3FF060-0x000000018D3FF0AC
		}
	
		// Constructors
		public DebugUIHandlerToggleHistory(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3FC66C-0x000000018D3FC9AC
		protected internal override void UpdateValueLabel(); // 0x000000018D3FC9AC-0x000000018D3FCB08
		[IteratorStateMachine(typeof(_RefreshAfterSanitization_d__4))]
		private IEnumerator RefreshAfterSanitization(); // 0x000000018D3FC610-0x000000018D3FC66C
	}

	public class DebugUIHandlerUIntField : DebugUIHandlerWidget // TypeDefIndex: 83604
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UI.Text valueLabel; // 0x60
		private DebugUI.UIntField m_Field; // 0x68
	
		// Constructors
		public DebugUIHandlerUIntField(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3FCE5C-0x000000018D3FCEEC
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3FA57C-0x000000018D3FA5D8
		public override void OnDeselection(); // 0x000000018D3FA510-0x000000018D3FA56C
		public override void OnIncrement(bool fast); // 0x000000018D3FCE4C-0x000000018D3FCE5C
		public override void OnDecrement(bool fast); // 0x000000018D3FCE3C-0x000000018D3FCE4C
		private void ChangeValue(bool fast, int multiplier); // 0x000000018D3FCD7C-0x000000018D3FCE3C
		private void UpdateValueLabel(); // 0x000000018D3FCEEC-0x000000018D3FCFA4
	}

	public class DebugUIHandlerValue : DebugUIHandlerWidget // TypeDefIndex: 83605
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UI.Text valueLabel; // 0x60
		private DebugUI.Value m_Field; // 0x68
		private float m_Timer; // 0x70
	
		// Constructors
		public DebugUIHandlerValue(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		protected override void OnEnable(); // 0x000000018725EE00-0x000000018725EE10
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3FD14C-0x000000018D3FD1D0
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3FA57C-0x000000018D3FA5D8
		public override void OnDeselection(); // 0x000000018D3FA510-0x000000018D3FA56C
		private void Update(); // 0x000000018D3FD1D0-0x000000018D3FD26C
	}

	public class DebugUIHandlerVBox : DebugUIHandlerWidget // TypeDefIndex: 83606
	{
		// Fields
		private DebugUIHandlerContainer m_Container; // 0x58
	
		// Constructors
		public DebugUIHandlerVBox(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3FD0EC-0x000000018D3FD14C
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3FD040-0x000000018D3FD0EC
		public override DebugUIHandlerWidget Next(); // 0x000000018D3FCFA4-0x000000018D3FD040
	}

	public class DebugUIHandlerVector2 : DebugUIHandlerWidget // TypeDefIndex: 83607
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UIFoldout valueToggle; // 0x60
		public DebugUIHandlerIndirectFloatField fieldX; // 0x68
		public DebugUIHandlerIndirectFloatField fieldY; // 0x70
		private DebugUI.Vector2Field m_Field; // 0x78
		private DebugUIHandlerContainer m_Container; // 0x80
	
		// Constructors
		public DebugUIHandlerVector2(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3FD4BC-0x000000018D3FD734
		private void SetValue(float v, bool x = false /* Metadata: 0x02642324 */, bool y = false /* Metadata: 0x02642325 */); // 0x000000018D3FD404-0x000000018D3FD4BC
		private void SetupSettings(DebugUIHandlerIndirectFloatField field); // 0x000000018D3FD734-0x000000018D3FD870
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3FD320-0x000000018D3FD404
		public override void OnDeselection(); // 0x000000018D3F208C-0x000000018D3F20BC
		public override void OnIncrement(bool fast); // 0x000000018D3F20BC-0x000000018D3F20E4
		public override void OnDecrement(bool fast); // 0x000000018D3F2068-0x000000018D3F208C
		public override void OnAction(); // 0x000000018D3F2038-0x000000018D3F2068
		public override DebugUIHandlerWidget Next(); // 0x000000018D3FD26C-0x000000018D3FD320
		[CompilerGenerated]
		private float _SetWidget_b__6_0(); // 0x000000018D3FD870-0x000000018D3FD8C4
		[CompilerGenerated]
		private void _SetWidget_b__6_1(float x); // 0x000000018D3FD8C4-0x000000018D3FD8E4
		[CompilerGenerated]
		private float _SetWidget_b__6_2(); // 0x000000018D3FD8E4-0x000000018D3FD938
		[CompilerGenerated]
		private void _SetWidget_b__6_3(float x); // 0x000000018D3FD938-0x000000018D3FD958
		[CompilerGenerated]
		private float _SetupSettings_b__8_0(); // 0x000000018D3FD958-0x000000018D3FD978
		[CompilerGenerated]
		private float _SetupSettings_b__8_1(); // 0x000000018D3FD978-0x000000018D3FD998
		[CompilerGenerated]
		private float _SetupSettings_b__8_2(); // 0x000000018D3FD998-0x000000018D3FD9B8
	}

	public class DebugUIHandlerVector3 : DebugUIHandlerWidget // TypeDefIndex: 83608
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
		public DebugUIHandlerVector3(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3FDC28-0x000000018D3FDF98
		private void SetValue(float v, bool x = false /* Metadata: 0x02642326 */, bool y = false /* Metadata: 0x02642327 */, bool z = false /* Metadata: 0x02642328 */); // 0x000000018D3FDB50-0x000000018D3FDC28
		private void SetupSettings(DebugUIHandlerIndirectFloatField field); // 0x000000018D3FDF98-0x000000018D3FE0D4
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3FDA6C-0x000000018D3FDB50
		public override void OnDeselection(); // 0x000000018D3F208C-0x000000018D3F20BC
		public override void OnIncrement(bool fast); // 0x000000018D3F20BC-0x000000018D3F20E4
		public override void OnDecrement(bool fast); // 0x000000018D3F2068-0x000000018D3F208C
		public override void OnAction(); // 0x000000018D3F2038-0x000000018D3F2068
		public override DebugUIHandlerWidget Next(); // 0x000000018D3FD9B8-0x000000018D3FDA6C
		[CompilerGenerated]
		private float _SetWidget_b__7_0(); // 0x000000018D3FE0D4-0x000000018D3FE128
		[CompilerGenerated]
		private void _SetWidget_b__7_1(float v); // 0x000000018D3FE128-0x000000018D3FE14C
		[CompilerGenerated]
		private float _SetWidget_b__7_2(); // 0x000000018D3FE14C-0x000000018D3FE1A0
		[CompilerGenerated]
		private void _SetWidget_b__7_3(float v); // 0x000000018D3FE1A0-0x000000018D3FE1C4
		[CompilerGenerated]
		private float _SetWidget_b__7_4(); // 0x000000018D3FE1C4-0x000000018D3FE218
		[CompilerGenerated]
		private void _SetWidget_b__7_5(float v); // 0x000000018D3FE218-0x000000018D3FE23C
		[CompilerGenerated]
		private float _SetupSettings_b__9_0(); // 0x000000018D3FE23C-0x000000018D3FE25C
		[CompilerGenerated]
		private float _SetupSettings_b__9_1(); // 0x000000018D3FE25C-0x000000018D3FE27C
		[CompilerGenerated]
		private float _SetupSettings_b__9_2(); // 0x000000018D3FE27C-0x000000018D3FE2A0
	}

	public class DebugUIHandlerVector4 : DebugUIHandlerWidget // TypeDefIndex: 83609
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
		public DebugUIHandlerVector4(); // 0x000000018D3F27E4-0x000000018D3F27EC
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018D3FE540-0x000000018D3FE9B4
		private void SetValue(float v, bool x = false /* Metadata: 0x02642329 */, bool y = false /* Metadata: 0x0264232A */, bool z = false /* Metadata: 0x0264232B */, bool w = false /* Metadata: 0x0264232C */); // 0x000000018D3FE438-0x000000018D3FE540
		private void SetupSettings(DebugUIHandlerIndirectFloatField field); // 0x000000018D3FE9B4-0x000000018D3FEAF0
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018D3FE354-0x000000018D3FE438
		public override void OnDeselection(); // 0x000000018D3F208C-0x000000018D3F20BC
		public override void OnIncrement(bool fast); // 0x000000018D3F20BC-0x000000018D3F20E4
		public override void OnDecrement(bool fast); // 0x000000018D3F2068-0x000000018D3F208C
		public override void OnAction(); // 0x000000018D3F2038-0x000000018D3F2068
		public override DebugUIHandlerWidget Next(); // 0x000000018D3FE2A0-0x000000018D3FE354
		[CompilerGenerated]
		private float _SetWidget_b__8_0(); // 0x000000018D3FEAF0-0x000000018D3FEB44
		[CompilerGenerated]
		private void _SetWidget_b__8_1(float x); // 0x000000018D3FEB44-0x000000018D3FEB6C
		[CompilerGenerated]
		private float _SetWidget_b__8_2(); // 0x000000018D3FEB6C-0x000000018D3FEBC0
		[CompilerGenerated]
		private void _SetWidget_b__8_3(float x); // 0x000000018D3FEBC0-0x000000018D3FEBE8
		[CompilerGenerated]
		private float _SetWidget_b__8_4(); // 0x000000018D3FEBE8-0x000000018D3FEC3C
		[CompilerGenerated]
		private void _SetWidget_b__8_5(float x); // 0x000000018D3FEC3C-0x000000018D3FEC64
		[CompilerGenerated]
		private float _SetWidget_b__8_6(); // 0x000000018D3FEC64-0x000000018D3FECB8
		[CompilerGenerated]
		private void _SetWidget_b__8_7(float x); // 0x000000018D3FECB8-0x000000018D3FECE0
		[CompilerGenerated]
		private float _SetupSettings_b__10_0(); // 0x000000018D3FECE0-0x000000018D3FED00
		[CompilerGenerated]
		private float _SetupSettings_b__10_1(); // 0x000000018D3FED00-0x000000018D3FED20
		[CompilerGenerated]
		private float _SetupSettings_b__10_2(); // 0x000000018D3FED20-0x000000018D3FED44
	}

	public class DebugUIHandlerWidget : MonoBehaviour // TypeDefIndex: 83610
	{
		// Fields
		[HideInInspector]
		public UnityEngine.Color colorDefault; // 0x18
		[HideInInspector]
		public UnityEngine.Color colorSelected; // 0x28
		[CompilerGenerated]
		private DebugUIHandlerWidget _parentUIHandler_k__BackingField; // 0x38
		[CompilerGenerated]
		private DebugUIHandlerWidget _previousUIHandler_k__BackingField; // 0x40
		[CompilerGenerated]
		private DebugUIHandlerWidget _nextUIHandler_k__BackingField; // 0x48
		protected DebugUI.Widget m_Widget; // 0x50
	
		// Properties
		public DebugUIHandlerWidget parentUIHandler { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public DebugUIHandlerWidget previousUIHandler { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public DebugUIHandlerWidget nextUIHandler { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
	
		// Constructors
		public DebugUIHandlerWidget(); // 0x000000018D3FEEA0-0x000000018D3FEED0
	
		// Methods
		protected virtual void OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
		internal virtual void SetWidget(DebugUI.Widget widget); // 0x00000001869E1E00-0x00000001869E1E10
		internal DebugUI.Widget GetWidget(); // 0x000000018226EBD0-0x000000018226EBE0
		protected T CastWidget<T>()
			where T : DebugUI.Widget;
		public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x00000001851A4410-0x00000001851A4420
		public virtual void OnDeselection(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnAction(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnIncrement(bool fast); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnDecrement(bool fast); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual DebugUIHandlerWidget Previous(); // 0x000000018D3FEE1C-0x000000018D3FEEA0
		public virtual DebugUIHandlerWidget Next(); // 0x000000018D3FED44-0x000000018D3FEE1C
	}

	[ExecuteAlways]
	public class UIFoldout : Toggle // TypeDefIndex: 83611
	{
		// Fields
		public GameObject content; // 0x1B8
		public GameObject arrowOpened; // 0x1C0
		public GameObject arrowClosed; // 0x1C8
	
		// Constructors
		public UIFoldout(); // 0x000000018D3FF528-0x000000018D3FF530
	
		// Methods
		protected override void Start(); // 0x000000018D3FF464-0x000000018D3FF528
		private void OnValidate(); // 0x000000018D3FF264-0x000000018D3FF278
		public void SetState(bool state); // 0x000000018D3FF278-0x000000018D3FF284
		public void SetState(bool state, bool rebuildLayout); // 0x000000018D3FF284-0x000000018D3FF464
	}
}
