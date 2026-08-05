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

// Image 30: Unity.RenderPipelines.Core.Runtime.dll - Assembly: Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56762-57172
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.RenderPipelines.Core.Editor.Tests")]
[assembly: InternalsVisibleTo("Unity.RenderPipelines.Core.Editor")]
[assembly: InternalsVisibleTo("Unity.RenderPipelines.HighDefinition.Runtime")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[ExecuteAlways]
public class SceneRenderPipeline : MonoBehaviour // TypeDefIndex: 56765
{
	// Fields
	public RenderPipelineAsset renderPipelineAsset; // 0x18

	// Constructors
	public SceneRenderPipeline(); // 0x0000000185393520-0x0000000185393538

	// Methods
	private void OnEnable(); // 0x000000018B2B5E40-0x000000018B2B5E4C
	private void OnValidate(); // 0x000000018B2B5E40-0x000000018B2B5E4C
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 57172
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_256 _45AC882BD91FEBD5A58E67471A0EF32BFC485447A8A18D61DBA335FDA5A2C097; // 0x00 // Static value (base64): AAAAAAAAAAAAAAAAAAAAAAAAgD0AAAA/AAAAAAAAAAAAAAA+AACAPgAAAAAAAAAAAABAPgAAQD8AAAAAAAAAAAAAgD4AAAA+AAAAAAAAAAAAAKA+AAAgPwAAAAAAAAAAAADAPgAAwD4AAAAAAAAAAAAA4D4AAGA/AAAAAAAAAAAAAAA/AACAPQAAAAAAAAAAAAAQPwAAED8AAAAAAAAAAAAAID8AAKA+AAAAAAAAAAAAADA/AABQPwAAAAAAAAAAAABAPwAAQD4AAAAAAAAAAAAAUD8AADA/AAAAAAAAAAAAAGA/AADgPgAAAAAAAAAAAABwPwAAcD8AAAAAAAAAAA== - Metadata: 0x0234970C
	internal static readonly __StaticArrayInitTypeSize_512 _4A1D5C231BB4DDB64A57CFF5FC45592F845DB22D8DE0DCCA7BB59D822908C39A; // 0x100 // Static value (base64): AAAAAAAAAAAAAAAAAAAAAAAAAD0AAAA/AAAAAAAAAAAAAIA9AACAPgAAAAAAAAAAAADAPQAAQD8AAAAAAAAAAAAAAD4AAAA+AAAAAAAAAAAAACA+AAAgPwAAAAAAAAAAAABAPgAAwD4AAAAAAAAAAAAAYD4AAGA/AAAAAAAAAAAAAIA+AACAPQAAAAAAAAAAAACQPgAAED8AAAAAAAAAAAAAoD4AAKA+AAAAAAAAAAAAALA+AABQPwAAAAAAAAAAAADAPgAAQD4AAAAAAAAAAAAA0D4AADA/AAAAAAAAAAAAAOA+AADgPgAAAAAAAAAAAADwPgAAcD8AAAAAAAAAAAAAAD8AAAA9AAAAAAAAAAAAAAg/AAAIPwAAAAAAAAAAAAAQPwAAkD4AAAAAAAAAAAAAGD8AAEg/AAAAAAAAAAAAACA/AAAgPgAAAAAAAAAAAAAoPwAAKD8AAAAAAAAAAAAAMD8AANA+AAAAAAAAAAAAADg/AABoPwAAAAAAAAAAAABAPwAAwD0AAAAAAAAAAAAASD8AABg/AAAAAAAAAAAAAFA/AACwPgAAAAAAAAAAAABYPwAAWD8AAAAAAAAAAAAAYD8AAGA+AAAAAAAAAAAAAGg/AAA4PwAAAAAAAAAAAABwPwAA8D4AAAAAAAAAAAAAeD8AAHg/AAAAAAAAAAA= - Metadata: 0x02349814
	internal static readonly __StaticArrayInitTypeSize_1024 _90C2D148CDB931199C77ADD692B92324CDFC328EDD1D0AB7FA24830C177A4FF4; // 0x300 // Static value (base64): AAAAAAAAAAAAAAAAAAAAAAAAgDwAAAA/AAAAAAAAAAAAAAA9AACAPgAAAAAAAAAAAABAPQAAQD8AAAAAAAAAAAAAgD0AAAA+AAAAAAAAAAAAAKA9AAAgPwAAAAAAAAAAAADAPQAAwD4AAAAAAAAAAAAA4D0AAGA/AAAAAAAAAAAAAAA+AACAPQAAAAAAAAAAAAAQPgAAED8AAAAAAAAAAAAAID4AAKA+AAAAAAAAAAAAADA+AABQPwAAAAAAAAAAAABAPgAAQD4AAAAAAAAAAAAAUD4AADA/AAAAAAAAAAAAAGA+AADgPgAAAAAAAAAAAABwPgAAcD8AAAAAAAAAAAAAgD4AAAA9AAAAAAAAAAAAAIg+AAAIPwAAAAAAAAAAAACQPgAAkD4AAAAAAAAAAAAAmD4AAEg/AAAAAAAAAAAAAKA+AAAgPgAAAAAAAAAAAACoPgAAKD8AAAAAAAAAAAAAsD4AANA+AAAAAAAAAAAAALg+AABoPwAAAAAAAAAAAADAPgAAwD0AAAAAAAAAAAAAyD4AABg/AAAAAAAAAAAAANA+AACwPgAAAAAAAAAAAADYPgAAWD8AAAAAAAAAAAAA4D4AAGA+AAAAAAAAAAAAAOg+AAA4PwAAAAAAAAAAAADwPgAA8D4AAAAAAAAAAAAA+D4AAHg/AAAAAAAAAAAAAAA/AACAPAAAAAAAAAAAAAAEPwAABD8AAAAAAAAAAAAACD8AAIg+AAAAAAAAAAAAAAw/AABEPwAAAAAAAAAAAAAQPwAAED4AAAAAAAAAAAAAFD8AACQ/AAAAAAAAAAAAABg/AADIPgAAAAAAAAAAAAAcPwAAZD8AAAAAAAAAAAAAID8AAKA9AAAAAAAAAAAAACQ/AAAUPwAAAAAAAAAAAAAoPwAAqD4AAAAAAAAAAAAALD8AAFQ/AAAAAAAAAAAAADA/AABQPgAAAAAAAAAAAAA0PwAAND8AAAAAAAAAAAAAOD8AAOg+AAAAAAAAAAAAADw/AAB0PwAAAAAAAAAAAABAPwAAQD0AAAAAAAAAAAAARD8AAAw/AAAAAAAAAAAAAEg/AACYPgAAAAAAAAAAAABMPwAATD8AAAAAAAAAAAAAUD8AADA+AAAAAAAAAAAAAFQ/AAAsPwAAAAAAAAAAAABYPwAA2D4AAAAAAAAAAAAAXD8AAGw/AAAAAAAAAAAAAGA/AADgPQAAAAAAAAAAAABkPwAAHD8AAAAAAAAAAAAAaD8AALg+AAAAAAAAAAAAAGw/AABcPwAAAAAAAAAAAABwPwAAcD4AAAAAAAAAAAAAdD8AADw/AAAAAAAAAAAAAHg/AAD4PgAAAAAAAAAAAAB8PwAAfD8AAAAAAAAAAA== - Metadata: 0x02349A1C
	internal static readonly __StaticArrayInitTypeSize_144 BDFF4BF48DBC7214A392CF884F7F2A6073CCDB77CA3EB11BEBB93DA8ED8B2158; // 0x700 // Static value (base64): AwAAAAEAAAAAAAAAAwAAAAIAAAABAAAABwAAAAUAAAAEAAAABwAAAAYAAAAFAAAACwAAAAkAAAAIAAAACwAAAAoAAAAJAAAADwAAAA0AAAAMAAAADwAAAA4AAAANAAAAEwAAABEAAAAQAAAAEwAAABIAAAARAAAAFwAAABUAAAAUAAAAFwAAABYAAAAVAAAA - Metadata: 0x02349E24
	internal static readonly __StaticArrayInitTypeSize_4096 C606E03B5FE8EAD2ECA6BCB45AE684039D928B4EE7C4A03C63D0DF9F94F81DAF; // 0x790 // Static value (base64): AAAAAAAAAAAAAAAAAAAAAAAAgDsAAAA/AAAAAAAAAAAAAAA8AACAPgAAAAAAAAAAAABAPAAAQD8AAAAAAAAAAAAAgDwAAAA+AAAAAAAAAAAAAKA8AAAgPwAAAAAAAAAAAADAPAAAwD4AAAAAAAAAAAAA4DwAAGA/AAAAAAAAAAAAAAA9AACAPQAAAAAAAAAAAAAQPQAAED8AAAAAAAAAAAAAID0AAKA+AAAAAAAAAAAAADA9AABQPwAAAAAAAAAAAABAPQAAQD4AAAAAAAAAAAAAUD0AADA/AAAAAAAAAAAAAGA9AADgPgAAAAAAAAAAAABwPQAAcD8AAAAAAAAAAAAAgD0AAAA9AAAAAAAAAAAAAIg9AAAIPwAAAAAAAAAAAACQPQAAkD4AAAAAAAAAAAAAmD0AAEg/AAAAAAAAAAAAAKA9AAAgPgAAAAAAAAAAAACoPQAAKD8AAAAAAAAAAAAAsD0AANA+AAAAAAAAAAAAALg9AABoPwAAAAAAAAAAAADAPQAAwD0AAAAAAAAAAAAAyD0AABg/AAAAAAAAAAAAANA9AACwPgAAAAAAAAAAAADYPQAAWD8AAAAAAAAAAAAA4D0AAGA+AAAAAAAAAAAAAOg9AAA4PwAAAAAAAAAAAADwPQAA8D4AAAAAAAAAAAAA+D0AAHg/AAAAAAAAAAAAAAA+AACAPAAAAAAAAAAAAAAEPgAABD8AAAAAAAAAAAAACD4AAIg+AAAAAAAAAAAAAAw+AABEPwAAAAAAAAAAAAAQPgAAED4AAAAAAAAAAAAAFD4AACQ/AAAAAAAAAAAAABg+AADIPgAAAAAAAAAAAAAcPgAAZD8AAAAAAAAAAAAAID4AAKA9AAAAAAAAAAAAACQ+AAAUPwAAAAAAAAAAAAAoPgAAqD4AAAAAAAAAAAAALD4AAFQ/AAAAAAAAAAAAADA+AABQPgAAAAAAAAAAAAA0PgAAND8AAAAAAAAAAAAAOD4AAOg+AAAAAAAAAAAAADw+AAB0PwAAAAAAAAAAAABAPgAAQD0AAAAAAAAAAAAARD4AAAw/AAAAAAAAAAAAAEg+AACYPgAAAAAAAAAAAABMPgAATD8AAAAAAAAAAAAAUD4AADA+AAAAAAAAAAAAAFQ+AAAsPwAAAAAAAAAAAABYPgAA2D4AAAAAAAAAAAAAXD4AAGw/AAAAAAAAAAAAAGA+AADgPQAAAAAAAAAAAABkPgAAHD8AAAAAAAAAAAAAaD4AALg+AAAAAAAAAAAAAGw+AABcPwAAAAAAAAAAAABwPgAAcD4AAAAAAAAAAAAAdD4AADw/AAAAAAAAAAAAAHg+AAD4PgAAAAAAAAAAAAB8PgAAfD8AAAAAAAAAAAAAgD4AAAA8AAAAAAAAAAAAAII+AAACPwAAAAAAAAAAAACEPgAAhD4AAAAAAAAAAAAAhj4AAEI/AAAAAAAAAAAAAIg+AAAIPgAAAAAAAAAAAACKPgAAIj8AAAAAAAAAAAAAjD4AAMQ+AAAAAAAAAAAAAI4+AABiPwAAAAAAAAAAAACQPgAAkD0AAAAAAAAAAAAAkj4AABI/AAAAAAAAAAAAAJQ+AACkPgAAAAAAAAAAAACWPgAAUj8AAAAAAAAAAAAAmD4AAEg+AAAAAAAAAAAAAJo+AAAyPwAAAAAAAAAAAACcPgAA5D4AAAAAAAAAAAAAnj4AAHI/AAAAAAAAAAAAAKA+AAAgPQAAAAAAAAAAAACiPgAACj8AAAAAAAAAAAAApD4AAJQ+AAAAAAAAAAAAAKY+AABKPwAAAAAAAAAAAACoPgAAKD4AAAAAAAAAAAAAqj4AACo/AAAAAAAAAAAAAKw+AADUPgAAAAAAAAAAAACuPgAAaj8AAAAAAAAAAAAAsD4AANA9AAAAAAAAAAAAALI+AAAaPwAAAAAAAAAAAAC0PgAAtD4AAAAAAAAAAAAAtj4AAFo/AAAAAAAAAAAAALg+AABoPgAAAAAAAAAAAAC6PgAAOj8AAAAAAAAAAAAAvD4AAPQ+AAAAAAAAAAAAAL4+AAB6PwAAAAAAAAAAAADAPgAAwDwAAAAAAAAAAAAAwj4AAAY/AAAAAAAAAAAAAMQ+AACMPgAAAAAAAAAAAADGPgAARj8AAAAAAAAAAAAAyD4AABg+AAAAAAAAAAAAAMo+AAAmPwAAAAAAAAAAAADMPgAAzD4AAAAAAAAAAAAAzj4AAGY/AAAAAAAAAAAAANA+AACwPQAAAAAAAAAAAADSPgAAFj8AAAAAAAAAAAAA1D4AAKw+AAAAAAAAAAAAANY+AABWPwAAAAAAAAAAAADYPgAAWD4AAAAAAAAAAAAA2j4AADY/AAAAAAAAAAAAANw+AADsPgAAAAAAAAAAAADePgAAdj8AAAAAAAAAAAAA4D4AAGA9AAAAAAAAAAAAAOI+AAAOPwAAAAAAAAAAAADkPgAAnD4AAAAAAAAAAAAA5j4AAE4/AAAAAAAAAAAAAOg+AAA4PgAAAAAAAAAAAADqPgAALj8AAAAAAAAAAAAA7D4AANw+AAAAAAAAAAAAAO4+AABuPwAAAAAAAAAAAADwPgAA8D0AAAAAAAAAAAAA8j4AAB4/AAAAAAAAAAAAAPQ+AAC8PgAAAAAAAAAAAAD2PgAAXj8AAAAAAAAAAAAA+D4AAHg+AAAAAAAAAAAAAPo+AAA+PwAAAAAAAAAAAAD8PgAA/D4AAAAAAAAAAAAA/j4AAH4/AAAAAAAAAAAAAAA/AACAOwAAAAAAAAAAAAABPwAAAT8AAAAAAAAAAAAAAj8AAII+AAAAAAAAAAAAAAM/AABBPwAAAAAAAAAAAAAEPwAABD4AAAAAAAAAAAAABT8AACE/AAAAAAAAAAAAAAY/AADCPgAAAAAAAAAAAAAHPwAAYT8AAAAAAAAAAAAACD8AAIg9AAAAAAAAAAAAAAk/AAARPwAAAAAAAAAAAAAKPwAAoj4AAAAAAAAAAAAACz8AAFE/AAAAAAAAAAAAAAw/AABEPgAAAAAAAAAAAAANPwAAMT8AAAAAAAAAAAAADj8AAOI+AAAAAAAAAAAAAA8/AABxPwAAAAAAAAAAAAAQPwAAED0AAAAAAAAAAAAAET8AAAk/AAAAAAAAAAAAABI/AACSPgAAAAAAAAAAAAATPwAAST8AAAAAAAAAAAAAFD8AACQ+AAAAAAAAAAAAABU/AAApPwAAAAAAAAAAAAAWPwAA0j4AAAAAAAAAAAAAFz8AAGk/AAAAAAAAAAAAABg/AADIPQAAAAAAAAAAAAAZPwAAGT8AAAAAAAAAAAAAGj8AALI+AAAAAAAAAAAAABs/AABZPwAAAAAAAAAAAAAcPwAAZD4AAAAAAAAAAAAAHT8AADk/AAAAAAAAAAAAAB4/AADyPgAAAAAAAAAAAAAfPwAAeT8AAAAAAAAAAAAAID8AAKA8AAAAAAAAAAAAACE/AAAFPwAAAAAAAAAAAAAiPwAAij4AAAAAAAAAAAAAIz8AAEU/AAAAAAAAAAAAACQ/AAAUPgAAAAAAAAAAAAAlPwAAJT8AAAAAAAAAAAAAJj8AAMo+AAAAAAAAAAAAACc/AABlPwAAAAAAAAAAAAAoPwAAqD0AAAAAAAAAAAAAKT8AABU/AAAAAAAAAAAAACo/AACqPgAAAAAAAAAAAAArPwAAVT8AAAAAAAAAAAAALD8AAFQ+AAAAAAAAAAAAAC0/AAA1PwAAAAAAAAAAAAAuPwAA6j4AAAAAAAAAAAAALz8AAHU/AAAAAAAAAAAAADA/AABQPQAAAAAAAAAAAAAxPwAADT8AAAAAAAAAAAAAMj8AAJo+AAAAAAAAAAAAADM/AABNPwAAAAAAAAAAAAA0PwAAND4AAAAAAAAAAAAANT8AAC0/AAAAAAAAAAAAADY/AADaPgAAAAAAAAAAAAA3PwAAbT8AAAAAAAAAAAAAOD8AAOg9AAAAAAAAAAAAADk/AAAdPwAAAAAAAAAAAAA6PwAAuj4AAAAAAAAAAAAAOz8AAF0/AAAAAAAAAAAAADw/AAB0PgAAAAAAAAAAAAA9PwAAPT8AAAAAAAAAAAAAPj8AAPo+AAAAAAAAAAAAAD8/AAB9PwAAAAAAAAAAAABAPwAAQDwAAAAAAAAAAAAAQT8AAAM/AAAAAAAAAAAAAEI/AACGPgAAAAAAAAAAAABDPwAAQz8AAAAAAAAAAAAARD8AAAw+AAAAAAAAAAAAAEU/AAAjPwAAAAAAAAAAAABGPwAAxj4AAAAAAAAAAAAARz8AAGM/AAAAAAAAAAAAAEg/AACYPQAAAAAAAAAAAABJPwAAEz8AAAAAAAAAAAAASj8AAKY+AAAAAAAAAAAAAEs/AABTPwAAAAAAAAAAAABMPwAATD4AAAAAAAAAAAAATT8AADM/AAAAAAAAAAAAAE4/AADmPgAAAAAAAAAAAABPPwAAcz8AAAAAAAAAAAAAUD8AADA9AAAAAAAAAAAAAFE/AAALPwAAAAAAAAAAAABSPwAAlj4AAAAAAAAAAAAAUz8AAEs/AAAAAAAAAAAAAFQ/AAAsPgAAAAAAAAAAAABVPwAAKz8AAAAAAAAAAAAAVj8AANY+AAAAAAAAAAAAAFc/AABrPwAAAAAAAAAAAABYPwAA2D0AAAAAAAAAAAAAWT8AABs/AAAAAAAAAAAAAFo/AAC2PgAAAAAAAAAAAABbPwAAWz8AAAAAAAAAAAAAXD8AAGw+AAAAAAAAAAAAAF0/AAA7PwAAAAAAAAAAAABePwAA9j4AAAAAAAAAAAAAXz8AAHs/AAAAAAAAAAAAAGA/AADgPAAAAAAAAAAAAABhPwAABz8AAAAAAAAAAAAAYj8AAI4+AAAAAAAAAAAAAGM/AABHPwAAAAAAAAAAAABkPwAAHD4AAAAAAAAAAAAAZT8AACc/AAAAAAAAAAAAAGY/AADOPgAAAAAAAAAAAABnPwAAZz8AAAAAAAAAAAAAaD8AALg9AAAAAAAAAAAAAGk/AAAXPwAAAAAAAAAAAABqPwAArj4AAAAAAAAAAAAAaz8AAFc/AAAAAAAAAAAAAGw/AABcPgAAAAAAAAAAAABtPwAANz8AAAAAAAAAAAAAbj8AAO4+AAAAAAAAAAAAAG8/AAB3PwAAAAAAAAAAAABwPwAAcD0AAAAAAAAAAAAAcT8AAA8/AAAAAAAAAAAAAHI/AACePgAAAAAAAAAAAABzPwAATz8AAAAAAAAAAAAAdD8AADw+AAAAAAAAAAAAAHU/AAAvPwAAAAAAAAAAAAB2PwAA3j4AAAAAAAAAAAAAdz8AAG8/AAAAAAAAAAAAAHg/AAD4PQAAAAAAAAAAAAB5PwAAHz8AAAAAAAAAAAAAej8AAL4+AAAAAAAAAAAAAHs/AABfPwAAAAAAAAAAAAB8PwAAfD4AAAAAAAAAAAAAfT8AAD8/AAAAAAAAAAAAAH4/AAD+PgAAAAAAAAAAAAB/PwAAfz8AAAAAAAAAAA== - Metadata: 0x02349EBC
	internal static readonly __StaticArrayInitTypeSize_24 FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE; // 0x1790 // Static value (base64): AAAAAAEAAAACAAAAAAAAAAIAAAADAAAA - Metadata: 0x0234AEC4

	// Nested types
	private struct __StaticArrayInitTypeSize_24 // TypeDefIndex: 57166
	{
	}

	private struct __StaticArrayInitTypeSize_144 // TypeDefIndex: 57167
	{
	}

	private struct __StaticArrayInitTypeSize_256 // TypeDefIndex: 57168
	{
	}

	private struct __StaticArrayInitTypeSize_512 // TypeDefIndex: 57169
	{
	}

	private struct __StaticArrayInitTypeSize_1024 // TypeDefIndex: 57170
	{
	}

	private struct __StaticArrayInitTypeSize_4096 // TypeDefIndex: 57171
	{
	}
}

namespace Beyond.Rendering
{
	public static class HGShaderQualitySettings // TypeDefIndex: 56767
	{
		// Fields
		public static ShaderQuality HgShaderLod; // 0x00
	
		// Nested types
		public enum ShaderQuality // TypeDefIndex: 56766
		{
			Low = 0,
			High = 1
		}
	
		// Constructors
		static HGShaderQualitySettings(); // 0x000000018B29F78C-0x000000018B29F7C8
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 56763
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 56764
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace UnityEngine
{
	[AddComponentMenu("Rendering/Light Anchor")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class LightAnchor : MonoBehaviour // TypeDefIndex: 56770
	{
		// Fields
		private const float k_ArcRadius = 5f; // Metadata: 0x0234932E
		private const float k_AxisLength = 10f; // Metadata: 0x02349332
		internal const float k_MaxDistance = 10000f; // Metadata: 0x02349336
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
		public float yaw { get; set; } // 0x0000000184D8E050-0x0000000184D8E060 0x000000018B2A0C38-0x000000018B2A0C88
		public float pitch { get; set; } // 0x0000000184D88360-0x0000000184D88370 0x000000018B2A0B98-0x000000018B2A0BE8
		public float roll { get; set; } // 0x0000000184D863E0-0x0000000184D863F0 0x000000018B2A0BE8-0x000000018B2A0C38
		public float distance { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x000000018B2A0B74-0x000000018B2A0B98
		public UpDirection frameSpace { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
		public Vector3 anchorPosition { get; } // 0x000000018B2A09F8-0x000000018B2A0B74 
		public Transform anchorPositionOverride { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public Vector3 anchorPositionOffset { get; set; } // 0x0000000184D90C00-0x0000000184D90C20 0x0000000184D90C20-0x0000000184D90C30
	
		// Nested types
		public enum UpDirection // TypeDefIndex: 56768
		{
			World = 0,
			Local = 1
		}
	
		private struct Axes // TypeDefIndex: 56769
		{
			// Fields
			public Vector3 up; // 0x00
			public Vector3 right; // 0x0C
			public Vector3 forward; // 0x18
		}
	
		// Constructors
		public LightAnchor(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public static float NormalizeAngleDegree(float angle); // 0x000000018B2A0090-0x000000018B2A00D8
		public void SynchronizeOnTransform(Camera camera); // 0x000000018B2A01A0-0x000000018B2A059C
		public void UpdateTransform(Camera camera, Vector3 anchor); // 0x000000018B2A059C-0x000000018B2A0678
		private Axes GetWorldSpaceAxes(Camera camera, Vector3 anchor); // 0x000000018B29F954-0x000000018B2A0090
		private void Update(); // 0x000000018B2A08FC-0x000000018B2A09F8
		private void OnDrawGizmosSelected(); // 0x000000018B2A00D8-0x000000018B2A01A0
		private void UpdateTransform(Vector3 up, Vector3 right, Vector3 forward, Vector3 anchor); // 0x000000018B2A0678-0x000000018B2A08FC
	}
}

namespace UnityEngine.Experimental.Rendering
{
	internal class ProbeBrickIndex // TypeDefIndex: 56778
	{
		// Fields
		internal const int kMaxSubdivisionLevels = 7; // Metadata: 0x0234933C
		internal const int kIndexChunkSize = 243; // Metadata: 0x0234933D
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
		internal int estimatedVMemCost { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
	
		// Nested types
		[Serializable]
		[DebuggerDisplay("Brick [{position}, {subdivisionLevel}]")]
		public struct Brick : IEquatable<Brick> // TypeDefIndex: 56771
		{
			// Fields
			public Vector3Int position; // 0x00
			public int subdivisionLevel; // 0x0C
	
			// Constructors
			internal Brick(Vector3Int position, int subdivisionLevel); // 0x0000000184D92BB0-0x0000000184D92BD0
	
			// Methods
			public bool Equals(Brick other); // 0x000000018B29F5C8-0x000000018B29F61C
		}
	
		[DebuggerDisplay("Brick [{brick.position}, {brick.subdivisionLevel}], {flattenedIdx}")]
		private struct ReservedBrick // TypeDefIndex: 56772
		{
			// Fields
			public Brick brick; // 0x00
			public int flattenedIdx; // 0x10
		}
	
		private struct VoxelMeta // TypeDefIndex: 56773
		{
			// Fields
			public ProbeReferenceVolume.RegId id; // 0x00
			public List<ushort> brickIndices; // 0x08
		}
	
		private struct BrickMeta // TypeDefIndex: 56774
		{
			// Fields
			public HashSet<Vector3Int> voxels; // 0x00
			public List<ReservedBrick> bricks; // 0x08
		}
	
		public struct CellIndexUpdateInfo // TypeDefIndex: 56775
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
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 56776
		{
			// Fields
			public ProbeReferenceVolume.RegId id; // 0x10
			public Predicate<VoxelMeta> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass31_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _AddBricks_b__0(VoxelMeta lhs); // 0x000000018702DACC-0x000000018702DAD8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 56777
		{
			// Fields
			public ProbeReferenceVolume.RegId id; // 0x10
			public Predicate<VoxelMeta> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass32_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _RemoveBricks_b__0(VoxelMeta lhs); // 0x000000018702DACC-0x000000018702DAD8
		}
	
		// Constructors
		internal ProbeBrickIndex(ProbeVolumeTextureMemoryBudget memoryBudget); // 0x000000018B2A2C84-0x000000018B2A2E80
	
		// Methods
		private int GetVoxelSubdivLevel(); // 0x000000018B2A1B84-0x000000018B2A1BD4
		private int SizeOfPhysicalIndexFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget); // 0x000000018B2A2248-0x000000018B2A2274
		internal void UploadIndexData(); // 0x000000018B2A2C54-0x000000018B2A2C84
		internal void Clear(); // 0x000000018B2A18B4-0x000000018B2A195C
		private void MapBrickToVoxels(Brick brick, HashSet<Vector3Int> voxels); // 0x000000018B2A1BD4-0x000000018B2A1DC4
		private void ClearVoxel(Vector3Int pos, CellIndexUpdateInfo cellInfo); // 0x000000018B2A17B4-0x000000018B2A18B4
		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr); // 0x000000018B2A1B4C-0x000000018B2A1B84
		internal void Cleanup(); // 0x000000018B2A1754-0x000000018B2A17B4
		private int MergeIndex(int index, int size); // 0x0000000184DB8A20-0x0000000184DB8A40
		internal bool AssignIndexChunksToCell(ProbeReferenceVolume.Cell cell, int bricksCount, ref CellIndexUpdateInfo cellUpdateInfo); // 0x000000018B2A1638-0x000000018B2A1754
		public void AddBricks(ProbeReferenceVolume.RegId id, List<Brick> bricks, List<ProbeBrickPool.BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight, CellIndexUpdateInfo cellInfo); // 0x000000018B2A0C88-0x000000018B2A1638
		public void RemoveBricks(ProbeReferenceVolume.RegId id, CellIndexUpdateInfo cellInfo); // 0x000000018B2A1DC4-0x000000018B2A2248
		private void UpdateIndexForVoxel(Vector3Int voxel, CellIndexUpdateInfo cellInfo); // 0x000000018B2A2274-0x000000018B2A24D4
		private void UpdatePhysicalIndex(Vector3Int brickMin, Vector3Int brickMax, int value, CellIndexUpdateInfo cellInfo); // 0x000000018B2A2858-0x000000018B2A2C54
		private void ClipToIndexSpace(Vector3Int pos, int subdiv, out Vector3Int outMinpos, out Vector3Int outMaxpos, CellIndexUpdateInfo cellInfo); // 0x000000018B2A195C-0x000000018B2A1B4C
		private void UpdateIndexForVoxel(Vector3Int voxel, List<ReservedBrick> bricks, List<ushort> indices, CellIndexUpdateInfo cellInfo); // 0x000000018B2A24D4-0x000000018B2A2858
	}

	internal class ProbeBrickPool // TypeDefIndex: 56781
	{
		// Fields
		internal const int kBrickCellCount = 3; // Metadata: 0x0234933F
		internal const int kBrickProbeCountPerDim = 4; // Metadata: 0x02349340
		internal const int kBrickProbeCountTotal = 64; // Metadata: 0x02349341
		[CompilerGenerated]
		private int _estimatedVMemCost_k__BackingField; // 0x10
		private const int kMaxPoolWidth = 2048; // Metadata: 0x02349343
		private int m_AllocationSize; // 0x14
		private ProbeVolumeTextureMemoryBudget m_MemoryBudget; // 0x18
		private DataLocation m_Pool; // 0x20
		private BrickChunkAlloc m_NextFreeChunk; // 0x68
		private Stack<BrickChunkAlloc> m_FreeList; // 0x78
		private ProbeVolumeSHBands m_SHBands; // 0x80
	
		// Properties
		internal int estimatedVMemCost { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
	
		// Nested types
		[DebuggerDisplay("Chunk ({x}, {y}, {z})")]
		public struct BrickChunkAlloc // TypeDefIndex: 56779
		{
			// Fields
			public int x; // 0x00
			public int y; // 0x04
			public int z; // 0x08
	
			// Methods
			internal int flattenIndex(int sx, int sy); // 0x0000000184DB8A00-0x0000000184DB8A20
		}
	
		public struct DataLocation // TypeDefIndex: 56780
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
			internal void Cleanup(); // 0x000000018B29F69C-0x000000018B29F78C
		}
	
		// Constructors
		internal ProbeBrickPool(int allocationSize, ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands); // 0x000000018B2A43D0-0x000000018B2A44F8
	
		// Methods
		internal void EnsureTextureValidity(); // 0x000000018B2A3550-0x000000018B2A3638
		internal int GetChunkSize(); // 0x0000000184D882A0-0x0000000184D882B0
		internal int GetChunkSizeInProbeCount(); // 0x0000000184DB8A60-0x0000000184DB8A70
		internal int GetPoolWidth(); // 0x0000000184D86570-0x0000000184D86580
		internal int GetPoolHeight(); // 0x0000000184D86560-0x0000000184D86570
		internal Vector3Int GetPoolDimensions(); // 0x0000000184DB8A70-0x0000000184DB8A90
		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr); // 0x000000018B2A3F0C-0x000000018B2A3F94
		internal void Clear(); // 0x000000018B2A2FC8-0x000000018B2A3018
		internal void Allocate(int numberOfBrickChunks, List<BrickChunkAlloc> outAllocations); // 0x000000018B2A2E80-0x000000018B2A2FBC
		internal void Deallocate(List<BrickChunkAlloc> allocations); // 0x000000018B2A3404-0x000000018B2A3550
		internal void Update(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, ProbeVolumeSHBands bands); // 0x000000018B2A4038-0x000000018B2A43D0
		private static Vector3Int ProbeCountToDataLocSize(int numProbes); // 0x000000018B2A3F94-0x000000018B2A3FF4
		public static DataLocation CreateDataLocation(int numProbes, bool compressed, ProbeVolumeSHBands bands, out int allocatedBytes); // 0x000000018B2A3018-0x000000018B2A3404
		private static void SetPixel(ref UnityEngine.Color[] data, int x, int y, int z, int dataLocWidth, int dataLocHeight, UnityEngine.Color value); // 0x000000018B2A3FF4-0x000000018B2A4038
		public static void FillDataLocation(ref DataLocation loc, SphericalHarmonicsL2[] shl2, ProbeVolumeSHBands bands); // 0x000000018B2A3638-0x000000018B2A3F0C
		private void DerivePoolSizeFromBudget(int allocationSize, ProbeVolumeTextureMemoryBudget memoryBudget, out int width, out int height, out int depth); // 0x0000000184DB8A40-0x0000000184DB8A60
		internal void Cleanup(); // 0x000000018B2A2FBC-0x000000018B2A2FC8
	}

	internal class ProbeCellIndices // TypeDefIndex: 56783
	{
		// Fields
		private const int kUintPerEntry = 3; // Metadata: 0x02349345
		[CompilerGenerated]
		private int _estimatedVMemCost_k__BackingField; // 0x10
		private ComputeBuffer m_IndexOfIndicesBuffer; // 0x18
		private uint[] m_IndexOfIndicesData; // 0x20
		private Vector3Int m_CellCount; // 0x28
		private Vector3Int m_CellMin; // 0x34
		private int m_CellSizeInMinBricks; // 0x40
		private bool m_NeedUpdateComputeBuffer; // 0x44
	
		// Properties
		internal int estimatedVMemCost { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
	
		// Nested types
		internal struct IndexMetaData // TypeDefIndex: 56782
		{
			// Fields
			internal Vector3Int minLocalIdx; // 0x00
			internal Vector3Int maxLocalIdx; // 0x0C
			internal int firstChunkIndex; // 0x18
			internal int minSubdiv; // 0x1C
	
			// Methods
			internal void Pack(out uint[] vals); // 0x000000018B29F7C8-0x000000018B29F954
		}
	
		// Constructors
		internal ProbeCellIndices(Vector3Int cellMin, Vector3Int cellMax, int cellSizeInMinBricks); // 0x000000018B2A47DC-0x000000018B2A491C
	
		// Methods
		internal Vector3Int GetCellIndexDimension(); // 0x0000000184D90C00-0x0000000184D90C20
		internal Vector3Int GetCellMinPosition(); // 0x0000000184D89640-0x0000000184D89660
		private int GetFlatIndex(Vector3Int normalizedPos); // 0x0000000184DB8A90-0x0000000184DB8AB0
		internal int GetFlatIdxForCell(Vector3Int cellPosition); // 0x000000018B2A46C8-0x000000018B2A472C
		internal void AddCell(int cellFlatIdx, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo); // 0x000000018B2A44F8-0x000000018B2A4668
		internal void MarkCellAsUnloaded(int cellFlatIdx); // 0x000000018B2A4764-0x000000018B2A47AC
		internal void PushComputeData(); // 0x000000018B2A47AC-0x000000018B2A47DC
		internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr); // 0x000000018B2A472C-0x000000018B2A4764
		internal void Cleanup(); // 0x000000018B2A4668-0x000000018B2A46C8
	}

	public struct ProbeVolumeSystemParameters // TypeDefIndex: 56784
	{
		// Fields
		public ProbeVolumeTextureMemoryBudget memoryBudget; // 0x00
		public Mesh probeDebugMesh; // 0x08
		public Shader probeDebugShader; // 0x10
		public ProbeVolumeSceneData sceneData; // 0x18
		public ProbeVolumeSHBands shBands; // 0x20
	}

	public struct ProbeVolumeShadingParameters // TypeDefIndex: 56785
	{
		// Fields
		public float normalBias; // 0x00
		public float viewBias; // 0x04
		public bool scaleBiasByMinDistanceBetweenProbes; // 0x08
		public float samplingNoise; // 0x0C
	}

	[Serializable]
	public enum ProbeVolumeTextureMemoryBudget // TypeDefIndex: 56786
	{
		MemoryBudgetLow = 512,
		MemoryBudgetMedium = 1024,
		MemoryBudgetHigh = 2048
	}

	[Serializable]
	public enum ProbeVolumeSHBands // TypeDefIndex: 56787
	{
		SphericalHarmonicsL1 = 1,
		SphericalHarmonicsL2 = 2
	}

	public class ProbeReferenceVolume // TypeDefIndex: 56799
	{
		// Fields
		private const int kProbeIndexPoolAllocationSize = 128; // Metadata: 0x02349350
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
		private const int kProbesPerBatch = 1023; // Metadata: 0x02349352
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
		internal bool isInitialized { get; } // 0x0000000184DB8B40-0x0000000184DB8B50 
		internal bool enabledBySRP { get; } // 0x0000000184DB8B30-0x0000000184DB8B40 
		public ProbeVolumeSHBands shBands { get; } // 0x0000000184DB8B50-0x0000000184DB8B60 
		public ProbeVolumeTextureMemoryBudget memoryBudget { get; } // 0x0000000184DA24D0-0x0000000184DA24E0 
		public static ProbeReferenceVolume instance { get; } // 0x000000018B2AA918-0x000000018B2AA94C 
		internal ProbeVolumeDebug debugDisplay { [CompilerGenerated] get; } // 0x0000000184D8D8F0-0x0000000184D8D900 
		public UnityEngine.Color[] subdivisionDebugColors { [CompilerGenerated] get; } // 0x0000000184D8DF00-0x0000000184D8DF10 
	
		// Nested types
		[Serializable]
		internal class Cell // TypeDefIndex: 56788
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
			public Cell(); // 0x0000000184D8EC90-0x0000000184D8ECA0
		}
	
		private class CellChunkInfo // TypeDefIndex: 56789
		{
			// Fields
			public List<ProbeBrickPool.BrickChunkAlloc> chunks; // 0x10
	
			// Constructors
			public CellChunkInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private class CellSortInfo : IComparable // TypeDefIndex: 56790
		{
			// Fields
			internal string sourceAsset; // 0x10
			internal Cell cell; // 0x18
			internal float distanceToCamera; // 0x20
			internal Vector3 position; // 0x24
	
			// Constructors
			public CellSortInfo(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public int CompareTo(object obj); // 0x000000018B29F61C-0x000000018B29F69C
		}
	
		internal struct Volume : IEquatable<Volume> // TypeDefIndex: 56791
		{
			// Fields
			internal Vector3 corner; // 0x00
			internal Vector3 X; // 0x0C
			internal Vector3 Y; // 0x18
			internal Vector3 Z; // 0x24
			internal float maxSubdivisionMultiplier; // 0x30
			internal float minSubdivisionMultiplier; // 0x34
	
			// Constructors
			public Volume(Matrix4x4 trs, float maxSubdivision, float minSubdivision); // 0x000000018B2B6B2C-0x000000018B2B6EE4
			public Volume(Vector3 corner, Vector3 X, Vector3 Y, Vector3 Z, float maxSubdivision = 1f /* Metadata: 0x02349354 */, float minSubdivision = 0f /* Metadata: 0x02349358 */); // 0x0000000184DB8C10-0x0000000184DB8C70
			public Volume(Volume copy); // 0x0000000184DB8BC0-0x0000000184DB8C10
	
			// Methods
			public Bounds CalculateAABB(); // 0x000000018B2B6240-0x000000018B2B6550
			public void CalculateCenterAndSize(out Vector3 center, out Vector3 size); // 0x000000018B2B6550-0x000000018B2B66D0
			public void Transform(Matrix4x4 trs); // 0x000000018B2B6A40-0x000000018B2B6B2C
			public override string ToString(); // 0x000000018B2B6874-0x000000018B2B6A40
			public bool Equals(Volume other); // 0x000000018B2B66D0-0x000000018B2B6874
		}
	
		internal struct RefVolTransform // TypeDefIndex: 56792
		{
			// Fields
			public Matrix4x4 refSpaceToWS; // 0x00
			public Vector3 posWS; // 0x40
			public Quaternion rot; // 0x4C
			public float scale; // 0x5C
		}
	
		public struct RuntimeResources // TypeDefIndex: 56793
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
	
		internal struct RegId // TypeDefIndex: 56794
		{
			// Fields
			internal int id; // 0x00
	
			// Methods
			public bool IsValid(); // 0x00000001868B8E74-0x00000001868B8E7C
			public void Invalidate(); // 0x0000000184D910C0-0x0000000184D910D0
			public static bool operator ==(RegId lhs, RegId rhs); // 0x0000000187872540-0x0000000187872548
			public static bool operator !=(RegId lhs, RegId rhs); // 0x000000018AAED910-0x000000018AAED918
			public override bool Equals(object obj); // 0x000000018B2AD4E4-0x000000018B2AD590
			public override int GetHashCode(); // 0x0000000182B77620-0x0000000182B77630
		}
	
		public struct ExtraDataActionInput // TypeDefIndex: 56795
		{
		}
	
		private struct InitInfo // TypeDefIndex: 56796
		{
			// Fields
			public Vector3Int pendingMinCellPosition; // 0x00
			public Vector3Int pendingMaxCellPosition; // 0x0C
		}
	
		private class CellInstancedDebugProbes // TypeDefIndex: 56797
		{
			// Fields
			public List<Matrix4x4[]> probeBuffers; // 0x10
			public List<MaterialPropertyBlock> props; // 0x18
			public Hash128 cellHash; // 0x20
			public Vector3 cellPosition; // 0x30
	
			// Constructors
			public CellInstancedDebugProbes(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56798
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
			static __c(); // 0x000000018B2B61DC-0x000000018B2B6240
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _RegisterDebug_b__119_6(); // 0x0000000184D879D0-0x0000000184D879E0
			internal float _RegisterDebug_b__119_15(); // 0x0000000184DB8BB0-0x0000000184DB8BC0
			internal float _RegisterDebug_b__119_16(); // 0x0000000184DA9C10-0x0000000184DA9C20
			internal float _RegisterDebug_b__119_21(); // 0x0000000184D879D0-0x0000000184D879E0
			internal int _RegisterDebug_b__119_24(); // 0x00000001811EC580-0x00000001811EC590
			internal int _RegisterDebug_b__119_25(); // 0x000000018B2B6128-0x000000018B2B6178
		}
	
		// Constructors
		private ProbeReferenceVolume(); // 0x0000000184735900-0x0000000184735EA0
		static ProbeReferenceVolume(); // 0x0000000184735890-0x0000000184735900
	
		// Methods
		private void InvalidateAllCellRefs(); // 0x000000018B2A79F8-0x000000018B2A7A40
		public void SetNumberOfCellsLoadedPerFrame(int numberOfCells); // 0x000000018B2A9F68-0x000000018B2A9F7C
		public void Initialize([IsReadOnly] in ProbeVolumeSystemParameters parameters); // 0x000000018B2A7924-0x000000018B2A79F8
		public void SetEnableStateFromSRP(bool srpEnablesPV); // 0x0000000184DB8B20-0x0000000184DB8B30
		internal void ForceSHBand(ProbeVolumeSHBands shBands); // 0x000000018B2A6D94-0x000000018B2A6DEC
		public void Cleanup(); // 0x000000018B2A5AF8-0x000000018B2A5B78
		public int GetVideoMemoryCost(); // 0x000000018B2A74B8-0x000000018B2A7508
		private void RemoveCell(Cell cell); // 0x000000018B2A99CC-0x000000018B2A9C34
		private void AddCell(Cell cell, List<ProbeBrickPool.BrickChunkAlloc> chunks); // 0x000000018B2A4E2C-0x000000018B2A4FBC
		private bool CheckCompatibilityWithCollection(ProbeVolumeAsset asset, Dictionary<string, ProbeVolumeAsset> collection); // 0x000000018B2A5878-0x000000018B2A5A30
		internal void AddPendingAssetLoading(ProbeVolumeAsset asset); // 0x000000018B2A4FBC-0x000000018B2A5744
		internal void AddPendingAssetRemoval(ProbeVolumeAsset asset); // 0x000000018B2A5744-0x000000018B2A5804
		internal void RemovePendingAsset(ProbeVolumeAsset asset); // 0x000000018B2A9C34-0x000000018B2A9EA8
		private void PerformPendingIndexChangeAndInit(); // 0x000000018B2A82B4-0x000000018B2A8310
		internal void SetMinBrickAndMaxSubdiv(float minBrickSize, int maxSubdiv); // 0x000000018B2A9EF8-0x000000018B2A9F68
		private void LoadAsset(ProbeVolumeAsset asset); // 0x000000018B2A7A40-0x000000018B2A7CA8
		private void PerformPendingLoading(); // 0x000000018B2A8310-0x000000018B2A867C
		private void PerformPendingDeletion(); // 0x000000018B2A810C-0x000000018B2A82B4
		private int GetNumberOfBricksAtSubdiv(Cell cell, out Vector3Int minValidLocalIdxAtMaxRes, out Vector3Int sizeOfValidIndicesAtMaxRes); // 0x000000018B2A6FA0-0x000000018B2A73F0
		private bool GetCellIndexUpdate(Cell cell, out ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo); // 0x000000018B2A6DEC-0x000000018B2A6F70
		private void LoadPendingCells(bool loadAll = false /* Metadata: 0x0234934E */); // 0x000000018B2A7CA8-0x000000018B2A80F0
		public void PerformPendingOperations(bool loadAllCells = false /* Metadata: 0x0234934F */); // 0x000000018B2A867C-0x000000018B2A86C0
		private void InitProbeReferenceVolume(int allocationSize, ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands); // 0x000000018B2A7508-0x000000018B2A7754
		public void SortPendingCells(Vector3 cameraPosition); // 0x000000018B2AA298-0x000000018B2AA3BC
		public RuntimeResources GetRuntimeResources(); // 0x000000018B2A73F0-0x000000018B2A74B8
		internal void SetTRS(Vector3 position, Quaternion rotation, float minBrickSize); // 0x000000018B2A9F7C-0x000000018B2AA04C
		internal void SetMaxSubdivision(int maxSubdivision); // 0x000000018B2A9EA8-0x000000018B2A9EF8
		internal static int CellSize(int subdivisionLevel); // 0x0000000184DB8AF0-0x0000000184DB8B20
		internal float BrickSize(int subdivisionLevel); // 0x000000018B2A5804-0x000000018B2A5878
		internal float MinBrickSize(); // 0x0000000184DA60B0-0x0000000184DA60C0
		internal float MaxBrickSize(); // 0x000000018B2A80F0-0x000000018B2A8100
		internal Matrix4x4 GetRefSpaceToWS(); // 0x0000000184D978B0-0x0000000184D978E0
		internal RefVolTransform GetTransform(); // 0x0000000184D96DC0-0x0000000184D96E00
		internal int GetMaxSubdivision(); // 0x0000000184D863C0-0x0000000184D863D0
		internal int GetMaxSubdivision(float multiplier); // 0x000000018B2A6F8C-0x000000018B2A6FA0
		internal float GetDistanceBetweenProbes(int subdivisionLevel); // 0x000000018B2A6F70-0x000000018B2A6F8C
		internal float MinDistanceBetweenProbes(); // 0x000000018B2A8100-0x000000018B2A810C
		public bool DataHasBeenLoaded(); // 0x0000000184D8C8C0-0x0000000184D8C8D0
		internal void Clear(); // 0x000000018B2A5BE4-0x000000018B2A5CCC
		private RegId AddBricks(List<ProbeBrickIndex.Brick> bricks, ProbeBrickPool.DataLocation dataloc, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, out List<ProbeBrickPool.BrickChunkAlloc> ch_list); // 0x000000018B2A4AAC-0x000000018B2A4E2C
		private void ReleaseBricks(RegId id); // 0x000000018B2A9818-0x000000018B2A99CC
		public void UpdateConstantBuffer(CommandBuffer cmd, ProbeVolumeShadingParameters parameters); // 0x000000018B2AA714-0x000000018B2AA918
		private void CleanupLoadedData(); // 0x000000018B2A5A84-0x000000018B2A5AF8
		public void RenderDebug(Camera camera); // 0x0000000183451490-0x0000000183451500
		private void InitializeDebug(Mesh debugProbeMesh, Shader debugProbeShader); // 0x000000018B2A7754-0x000000018B2A7924
		private void CleanupDebug(); // 0x000000018B2A5A30-0x000000018B2A5A84
		private void RefreshDebug<T>(DebugUI.Field<T> field, T value);
		private void DebugCellIndexChanged<T>(DebugUI.Field<T> field, T value);
		private void RegisterDebug(); // 0x000000018B2A86C0-0x000000018B2A9818
		private void UnregisterDebug(bool destroyPanel); // 0x000000018B2AA648-0x000000018B2AA714
		private bool ShouldCullCell(Vector3 cellPosition, Transform cameraTransform, Plane[] frustumPlanes); // 0x000000018B2AA04C-0x000000018B2AA298
		private void DrawProbeDebug(Camera camera); // 0x000000018B2A685C-0x000000018B2A6D94
		private void ClearDebugData(); // 0x000000018B2A5B78-0x000000018B2A5BE4
		private void CreateInstancedProbes(); // 0x000000018B2A5CCC-0x000000018B2A685C
		private void OnClearLightingdata(); // 0x00000001877CA5E4-0x00000001877CA5EC
		[CompilerGenerated]
		private bool _RegisterDebug_b__119_0(); // 0x000000018B2AA3BC-0x000000018B2AA3DC
		[CompilerGenerated]
		private void _RegisterDebug_b__119_1(bool value); // 0x000000018B2AA4BC-0x000000018B2AA4DC
		[CompilerGenerated]
		private bool _RegisterDebug_b__119_2(); // 0x000000018B2AA588-0x000000018B2AA5A8
		[CompilerGenerated]
		private void _RegisterDebug_b__119_3(bool value); // 0x000000018B2AA5A8-0x000000018B2AA5C8
		[CompilerGenerated]
		private float _RegisterDebug_b__119_4(); // 0x000000018B2AA5C8-0x000000018B2AA5E8
		[CompilerGenerated]
		private void _RegisterDebug_b__119_5(float value); // 0x000000018B2AA5E8-0x000000018B2AA608
		[CompilerGenerated]
		private bool _RegisterDebug_b__119_7(); // 0x000000018B2AA608-0x000000018B2AA628
		[CompilerGenerated]
		private void _RegisterDebug_b__119_8(bool value); // 0x000000018B2AA628-0x000000018B2AA648
		[CompilerGenerated]
		private int _RegisterDebug_b__119_9(); // 0x000000018B2AA3FC-0x000000018B2AA41C
		[CompilerGenerated]
		private void _RegisterDebug_b__119_10(int value); // 0x000000018B2AA3DC-0x000000018B2AA3FC
		[CompilerGenerated]
		private int _RegisterDebug_b__119_11(); // 0x000000018B2AA3FC-0x000000018B2AA41C
		[CompilerGenerated]
		private void _RegisterDebug_b__119_12(int value); // 0x000000018B2AA3DC-0x000000018B2AA3FC
		[CompilerGenerated]
		private float _RegisterDebug_b__119_13(); // 0x000000018B2AA41C-0x000000018B2AA43C
		[CompilerGenerated]
		private void _RegisterDebug_b__119_14(float value); // 0x000000018B2AA43C-0x000000018B2AA45C
		[CompilerGenerated]
		private float _RegisterDebug_b__119_17(); // 0x000000018B2AA45C-0x000000018B2AA47C
		[CompilerGenerated]
		private void _RegisterDebug_b__119_18(float value); // 0x000000018B2AA47C-0x000000018B2AA49C
		[CompilerGenerated]
		private float _RegisterDebug_b__119_19(); // 0x000000018B2AA49C-0x000000018B2AA4BC
		[CompilerGenerated]
		private void _RegisterDebug_b__119_20(float value); // 0x000000018B2AA4DC-0x000000018B2AA4FC
		[CompilerGenerated]
		private int _RegisterDebug_b__119_22(); // 0x000000018B2AA4FC-0x000000018B2AA51C
		[CompilerGenerated]
		private void _RegisterDebug_b__119_23(int v); // 0x000000018B2AA51C-0x000000018B2AA588
	}

	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "G:\\Build\\Release_v1d4\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\Lighting\\ProbeVolume\\ProbeReferenceVolume.Debug.cs")]
	public enum DebugProbeShadingMode // TypeDefIndex: 56800
	{
		SH = 0,
		Validity = 1,
		ValidityOverDilationThreshold = 2,
		Size = 3
	}

	internal class ProbeVolumeDebug // TypeDefIndex: 56801
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
		public ProbeVolumeDebug(); // 0x0000000184DB8B70-0x0000000184DB8BA0
	}

	public sealed class ProbeReferenceVolumeProfile : ScriptableObject // TypeDefIndex: 56803
	{
		// Fields
		[SerializeField]
		private Version version; // 0x18
		[Range(2f, 5f)]
		public int simplificationLevels; // 0x1C
		[Min(0.1f)]
		public float minDistanceBetweenProbes; // 0x20
	
		// Properties
		public int cellSizeInBricks { get; } // 0x0000000184DB8AB0-0x0000000184DB8AE0 
		public int maxSubdivision { get; } // 0x0000000184DB8AE0-0x0000000184DB8AF0 
		public float minBrickSize { get; } // 0x000000018B2A4A90-0x000000018B2A4AAC 
		public float cellSizeInMeters { get; } // 0x000000018B2A4A44-0x000000018B2A4A90 
	
		// Nested types
		internal enum Version // TypeDefIndex: 56802
		{
			Initial = 0
		}
	
		// Constructors
		public ProbeReferenceVolumeProfile(); // 0x000000018B2A49D8-0x000000018B2A4A44
	
		// Methods
		private void OnEnable(); // 0x000000018B2A4984-0x000000018B2A49D8
		public bool IsEquivalent(ProbeReferenceVolumeProfile otherProfile); // 0x000000018B2A491C-0x000000018B2A4984
	}

	[AddComponentMenu("Light/Probe Volume (Experimental)")]
	[ExecuteAlways]
	public class ProbeVolume : MonoBehaviour // TypeDefIndex: 56804
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
		public ProbeVolume(); // 0x000000018B2AD4A0-0x000000018B2AD4E4
	}

	[PreferBinarySerialization]
	internal class ProbeVolumeAsset : ScriptableObject // TypeDefIndex: 56806
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
		public int Version { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		internal int maxSubdivision { get; } // 0x0000000184DB8B60-0x0000000184DB8B70 
		internal float minBrickSize { get; } // 0x000000018B2AAA54-0x000000018B2AAA70 
	
		// Nested types
		[Serializable]
		internal enum AssetVersion // TypeDefIndex: 56805
		{
			First = 0,
			AddProbeVolumesAtlasEncodingModes = 1,
			PV2 = 2,
			ChunkBasedIndex = 3,
			Current = 3,
			Max = 4
		}
	
		// Constructors
		public ProbeVolumeAsset(); // 0x000000018B2AA9AC-0x000000018B2AAA54
	
		// Methods
		internal bool CompatibleWith(ProbeVolumeAsset otherAsset); // 0x000000018B2AA94C-0x000000018B2AA9AC
		public string GetSerializedFullPath(); // 0x0000000184D86280-0x0000000184D86290
	}

	[Serializable]
	internal struct ProbeDilationSettings // TypeDefIndex: 56807
	{
		// Fields
		public bool enableDilation; // 0x00
		public float dilationDistance; // 0x04
		public float dilationValidityThreshold; // 0x08
		public int dilationIterations; // 0x0C
		public bool squaredDistWeighting; // 0x10
	}

	[Serializable]
	internal struct VirtualOffsetSettings // TypeDefIndex: 56808
	{
		// Fields
		public bool useVirtualOffset; // 0x00
		public float outOfGeoOffset; // 0x04
		public float searchMultiplier; // 0x08
	}

	[Serializable]
	internal struct ProbeVolumeBakingProcessSettings // TypeDefIndex: 56809
	{
		// Fields
		public ProbeDilationSettings dilationSettings; // 0x00
		public VirtualOffsetSettings virtualOffsetSettings; // 0x14
	}

	internal enum ProbeVolumeState // TypeDefIndex: 56810
	{
		Default = 0,
		Invalid = 999
	}

	[AddComponentMenu("")]
	[ExecuteAlways]
	internal class ProbeVolumePerSceneData : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 56812
	{
		// Fields
		internal Dictionary<ProbeVolumeState, ProbeVolumeAsset> assets; // 0x18
		[SerializeField]
		private List<SerializableAssetItem> serializedAssets; // 0x20
		private ProbeVolumeState m_CurrentState; // 0x28
		private ProbeVolumeState m_PreviousState; // 0x2C
	
		// Nested types
		[Serializable]
		private struct SerializableAssetItem // TypeDefIndex: 56811
		{
			// Fields
			[SerializeField]
			public ProbeVolumeState state; // 0x00
			[SerializeField]
			public ProbeVolumeAsset asset; // 0x08
		}
	
		// Constructors
		public ProbeVolumePerSceneData(); // 0x000000018B2AB3F8-0x000000018B2AB480
	
		// Methods
		public void OnAfterDeserialize(); // 0x000000018B2AACAC-0x000000018B2AAE40
		public void OnBeforeSerialize(); // 0x000000018B2AAE40-0x000000018B2AB070
		internal void StoreAssetForState(ProbeVolumeState state, ProbeVolumeAsset asset); // 0x000000018B2AB280-0x000000018B2AB2E4
		internal void InvalidateAllAssets(); // 0x000000018B2AAAE8-0x000000018B2AACAC
		internal ProbeVolumeAsset GetCurrentStateAsset(); // 0x000000018B2AAA70-0x000000018B2AAAE8
		internal void QueueAssetLoading(); // 0x000000018B2AB080-0x000000018B2AB188
		internal void QueueAssetRemoval(); // 0x000000018B2AB188-0x000000018B2AB280
		private void OnEnable(); // 0x000000018B2AB078-0x000000018B2AB080
		private void OnDisable(); // 0x000000018B2AB070-0x000000018B2AB078
		private void OnDestroy(); // 0x000000018B2AB070-0x000000018B2AB078
		private void Update(); // 0x000000018B2AB2E4-0x000000018B2AB3F8
	}

	[Serializable]
	public class ProbeVolumeSceneData : ISerializationCallbackReceiver // TypeDefIndex: 56819
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
		private struct SerializableBoundItem // TypeDefIndex: 56813
		{
			// Fields
			[SerializeField]
			public string sceneGUID; // 0x00
			[SerializeField]
			public Bounds bounds; // 0x08
		}
	
		[Serializable]
		private struct SerializableHasPVItem // TypeDefIndex: 56814
		{
			// Fields
			[SerializeField]
			public string sceneGUID; // 0x00
			[SerializeField]
			public bool hasProbeVolumes; // 0x08
		}
	
		[Serializable]
		private struct SerializablePVProfile // TypeDefIndex: 56815
		{
			// Fields
			[SerializeField]
			public string sceneGUID; // 0x00
			[SerializeField]
			public ProbeReferenceVolumeProfile profile; // 0x08
		}
	
		[Serializable]
		private struct SerializablePVBakeSettings // TypeDefIndex: 56816
		{
			// Fields
			[SerializeField]
			public string sceneGUID; // 0x00
			[SerializeField]
			public ProbeVolumeBakingProcessSettings settings; // 0x08
		}
	
		[Serializable]
		internal class BakingSet // TypeDefIndex: 56817
		{
			// Fields
			public string name; // 0x10
			public List<string> sceneGUIDs; // 0x18
			public ProbeVolumeBakingProcessSettings settings; // 0x20
			public ProbeReferenceVolumeProfile profile; // 0x40
	
			// Constructors
			public BakingSet(); // 0x000000018B29F550-0x000000018B29F5C8
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56818
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<SerializablePVProfile, string> __9__22_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B2B6178-0x000000018B2B61DC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _UpdateBakingSets_b__22_0(SerializablePVProfile s); // 0x0000000182A55C30-0x0000000182A55C40
		}
	
		// Constructors
		public ProbeVolumeSceneData(UnityEngine.Object parentAsset, string parentSceneDataPropertyName); // 0x000000018B2AD194-0x000000018B2AD4A0
		static ProbeVolumeSceneData(); // 0x000000018B2AD0E4-0x000000018B2AD194
	
		// Methods
		private string GetSceneGUID(Scene scene); // 0x000000018B2AB520-0x000000018B2AB5E4
		public void SetParentObject(UnityEngine.Object parent, string parentSceneDataPropertyName); // 0x000000018B2ACA78-0x000000018B2ACAAC
		public void OnAfterDeserialize(); // 0x000000018B2AB6C0-0x000000018B2ABF1C
		private void UpdateBakingSets(); // 0x000000018B2ACD68-0x000000018B2AD0E4
		public void OnBeforeSerialize(); // 0x000000018B2ABF1C-0x000000018B2ACA78
		internal BakingSet CreateNewBakingSet(string name); // 0x000000018B2AB480-0x000000018B2AB520
		private void InitializeBakingSet(BakingSet set, string name); // 0x000000018B2AB5E4-0x000000018B2AB6C0
		internal void SyncBakingSetSettings(); // 0x000000018B2ACAAC-0x000000018B2ACD68
	}

	[Obsolete("Use the updated RendererList API which is defined in the UnityEngine.Rendering.RendererUtils namespace.")]
	public struct RendererList // TypeDefIndex: 56820
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
		public bool isValid { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000184D883E0-0x0000000184D883F0 0x0000000184D87180-0x0000000184D87190
	
		// Constructors
		static RendererList(); // 0x000000018B2B5DC4-0x000000018B2B5E40
	
		// Methods
		public static RendererList Create([IsReadOnly] in UnityEngine.Experimental.Rendering.RendererListDesc desc); // 0x000000018B2B5828-0x000000018B2B5DC4
	}

	[Obsolete("Use the updated RendererList API which is defined in the UnityEngine.Rendering.RendererUtils namespace.")]
	public struct RendererListDesc // TypeDefIndex: 56821
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
		internal CullingResults cullingResult { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8E900-0x0000000184D8E910 0x0000000184DB8BA0-0x0000000184DB8BB0
		internal Camera camera { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184D86290-0x0000000184D862A0 0x0000000184D84CC0-0x0000000184D84CE0
		internal ShaderTagId passName { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8F8E0-0x0000000184D8F8F0 0x0000000184D8F8F0-0x0000000184D8F900
		internal ShaderTagId[] passNames { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000184D85EF0-0x0000000184D85F00 0x0000000186AC5AF4-0x0000000186AC5B08
	
		// Constructors
		public RendererListDesc(ShaderTagId passName, CullingResults cullingResult, Camera camera); // 0x000000018B2B57A8-0x000000018B2B5828
		public RendererListDesc(ShaderTagId[] passNames, CullingResults cullingResult, Camera camera); // 0x000000018B2B56F0-0x000000018B2B57A8
	
		// Methods
		public bool IsValid(); // 0x000000018B2B5650-0x000000018B2B56F0
	}
}

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	[Flags]
	public enum DepthAccess // TypeDefIndex: 56822
	{
		Read = 1,
		Write = 2,
		ReadWrite = 3
	}

	public class RenderGraphContext // TypeDefIndex: 56823
	{
		// Fields
		public ScriptableRenderContext renderContext; // 0x10
		public CommandBuffer cmd; // 0x18
		public RenderGraphObjectPool renderGraphPool; // 0x20
		public RenderGraphDefaultResources defaultResources; // 0x28
	
		// Constructors
		public RenderGraphContext(); // 0x00000001841E1670-0x00000001841E1680
	}

	public struct RenderGraphParameters // TypeDefIndex: 56824
	{
		// Fields
		public string executionName; // 0x00
		public int currentFrameIndex; // 0x08
		public bool rendererListCulling; // 0x0C
		public ScriptableRenderContext scriptableRenderContext; // 0x10
		public CommandBuffer commandBuffer; // 0x18
	}

	public struct RenderGraphExecution : IDisposable // TypeDefIndex: 56825
	{
		// Fields
		private RenderGraph renderGraph; // 0x00
	
		// Constructors
		internal RenderGraphExecution(RenderGraph renderGraph); // 0x0000000185392320-0x0000000185392328
	
		// Methods
		public void Dispose(); // 0x000000018B2AE004-0x000000018B2AE024
	}

	internal class RenderGraphDebugParams // TypeDefIndex: 56827
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
		private static class Strings // TypeDefIndex: 56826
		{
			// Fields
			public static readonly DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtCreation; // 0x00
			public static readonly DebugUI.Widget.NameAndTooltip DisablePassCulling; // 0x10
			public static readonly DebugUI.Widget.NameAndTooltip ImmediateMode; // 0x20
			public static readonly DebugUI.Widget.NameAndTooltip EnableLogging; // 0x30
			public static readonly DebugUI.Widget.NameAndTooltip LogFrameInformation; // 0x40
			public static readonly DebugUI.Widget.NameAndTooltip LogResources; // 0x50
	
			// Constructors
			static Strings(); // 0x000000018B2B5E4C-0x000000018B2B6128
		}
	
		// Constructors
		public RenderGraphDebugParams(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void RegisterDebug(string name, DebugUI.Panel debugPanel = null); // 0x000000018B2AD770-0x000000018B2ADEDC
		public void UnRegisterDebug(string name); // 0x000000018B2ADF94-0x000000018B2AE004
		[CompilerGenerated]
		private bool _RegisterDebug_b__10_0(); // 0x0000000184D866B0-0x0000000184D866C0
		[CompilerGenerated]
		private void _RegisterDebug_b__10_1(bool value); // 0x0000000184D866D0-0x0000000184D866E0
		[CompilerGenerated]
		private bool _RegisterDebug_b__10_2(); // 0x0000000184D86AD0-0x0000000184D86AE0
		[CompilerGenerated]
		private void _RegisterDebug_b__10_3(bool value); // 0x0000000184D86AE0-0x0000000184D86AF0
		[CompilerGenerated]
		private bool _RegisterDebug_b__10_4(); // 0x0000000184D8E070-0x0000000184D8E080
		[CompilerGenerated]
		private void _RegisterDebug_b__10_5(bool value); // 0x0000000184D8E080-0x0000000184D8E090
		[CompilerGenerated]
		private bool _RegisterDebug_b__10_6(); // 0x0000000184D86870-0x0000000184D86880
		[CompilerGenerated]
		private void _RegisterDebug_b__10_7(bool value); // 0x0000000184D86880-0x0000000184D86890
		[CompilerGenerated]
		private void _RegisterDebug_b__10_8(); // 0x000000018B2ADEDC-0x000000018B2ADF38
		[CompilerGenerated]
		private void _RegisterDebug_b__10_9(); // 0x000000018B2ADF38-0x000000018B2ADF94
	}

	public delegate void RenderFunc<PassData>(PassData data, RenderGraphContext renderGraphContext); // TypeDefIndex: 56828; 0x00000000-0x00000000

	internal class RenderGraphDebugData // TypeDefIndex: 56831
	{
		// Fields
		public List<PassDebugData> passList; // 0x10
		public List<ResourceDebugData>[] resourceLists; // 0x18
	
		// Nested types
		[DebuggerDisplay("PassDebug: {name}")]
		public struct PassDebugData // TypeDefIndex: 56829
		{
			// Fields
			public string name; // 0x00
			public List<int>[] resourceReadLists; // 0x08
			public List<int>[] resourceWriteLists; // 0x10
			public bool culled; // 0x18
			public bool generateDebugData; // 0x19
		}
	
		[DebuggerDisplay("ResourceDebug: {name} [{creationPassIndex}:{releasePassIndex}]")]
		public struct ResourceDebugData // TypeDefIndex: 56830
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
		public RenderGraphDebugData(); // 0x000000018B2AD6D0-0x000000018B2AD770
	
		// Methods
		public void Clear(); // 0x000000018B2AD590-0x000000018B2AD6D0
	}

	public class RenderGraph // TypeDefIndex: 56838
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
		public string name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85EF0-0x0000000184D85F00 0x0000000186AC5AF4-0x0000000186AC5B08
		internal static bool requireDebugData { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018B2B525C-0x000000018B2B52AC 0x000000018B2B55FC-0x000000018B2B5650
		public RenderGraphDefaultResources defaultResources { get; } // 0x0000000184D85A60-0x0000000184D85A70 
	
		// Events
		internal static event OnGraphRegisteredDelegate onGraphRegistered {
			add; // 0x000000018B2B50B4-0x000000018B2B5188
			remove; // 0x000000018B2B5454-0x000000018B2B5528
		}
		internal static event OnGraphRegisteredDelegate onGraphUnregistered {
			add; // 0x000000018B2B5188-0x000000018B2B525C
			remove; // 0x000000018B2B5528-0x000000018B2B55FC
		}
		internal static event OnExecutionRegisteredDelegate onExecutionRegistered {
			add; // 0x000000018B2B4F0C-0x000000018B2B4FE0
			remove; // 0x000000018B2B52AC-0x000000018B2B5380
		}
		internal static event OnExecutionRegisteredDelegate onExecutionUnregistered {
			add; // 0x000000018B2B4FE0-0x000000018B2B50B4
			remove; // 0x000000018B2B5380-0x000000018B2B5454
		}
	
		// Nested types
		internal struct CompiledResourceInfo // TypeDefIndex: 56832
		{
			// Fields
			public List<int> producers; // 0x00
			public List<int> consumers; // 0x08
			public int refCount; // 0x10
			public bool imported; // 0x14
	
			// Methods
			public void Reset(); // 0x000000018B2B7BB4-0x000000018B2B7C9C
		}
	
		[DebuggerDisplay("RenderPass: {pass.name} (Index:{pass.index} Async:{enableAsyncCompute})")]
		internal struct CompiledPassInfo // TypeDefIndex: 56833
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
			public bool allowPassCulling { get; } // 0x000000018B2B7B98-0x000000018B2B7BB4 
	
			// Methods
			public void Reset(RenderGraphPass pass); // 0x000000018B2B79B0-0x000000018B2B7B98
		}
	
		private class ProfilingScopePassData // TypeDefIndex: 56834
		{
			// Fields
			public ProfilingSampler sampler; // 0x10
	
			// Constructors
			public ProfilingScopePassData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		internal delegate void OnGraphRegisteredDelegate(RenderGraph graph); // TypeDefIndex: 56835; 0x0000000182B46B90-0x0000000182B46BA0
	
		internal delegate void OnExecutionRegisteredDelegate(RenderGraph graph, string executionName); // TypeDefIndex: 56836; 0x00000001838E1420-0x00000001838E1430
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56837
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static RenderFunc<ProfilingScopePassData> __9__61_0; // 0x08
			public static RenderFunc<ProfilingScopePassData> __9__62_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B2C7CD8-0x000000018B2C7D3C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _BeginProfilingSampler_b__61_0(ProfilingScopePassData data, RenderGraphContext ctx); // 0x0000000189B428A8-0x0000000189B428D8
			internal void _EndProfilingSampler_b__62_0(ProfilingScopePassData data, RenderGraphContext ctx); // 0x0000000189B428D8-0x0000000189B42908
		}
	
		// Constructors
		public RenderGraph(string name = "RenderGraph" /* Metadata: 0x0234936D */); // 0x000000018B2B4A08-0x000000018B2B4F0C
		static RenderGraph(); // 0x000000018B2B4950-0x000000018B2B4A08
	
		// Methods
		public void Cleanup(); // 0x000000018B2AE638-0x000000018B2AE700
		public void RegisterDebug(DebugUI.Panel panel = null); // 0x000000018B2B3A38-0x000000018B2B3A68
		public void UnRegisterDebug(); // 0x000000018B2B3D90-0x000000018B2B3DBC
		public static List<RenderGraph> GetRegisteredRenderGraphs(); // 0x000000018B2B21B4-0x000000018B2B2204
		internal RenderGraphDebugData GetDebugData(string executionName); // 0x000000018B2B1CB0-0x000000018B2B1D20
		public void EndFrame(); // 0x000000018B2B028C-0x000000018B2B034C
		public TextureHandle ImportTexture(RTHandle rt); // 0x000000018B2B22E4-0x000000018B2B2318
		public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt); // 0x000000018B2B2268-0x000000018B2B22C4
		public TextureHandle CreateTexture([IsReadOnly] in TextureDesc desc); // 0x000000018B2AFB10-0x000000018B2AFB50
		public TextureHandle CreateSharedTexture([IsReadOnly] in TextureDesc desc, bool explicitRelease = false /* Metadata: 0x02349379 */); // 0x000000018B2AF9F4-0x000000018B2AFA84
		public void ReleaseSharedTexture(TextureHandle texture); // 0x000000018B2B3C04-0x000000018B2B3C8C
		public TextureHandle CreateTexture(TextureHandle texture); // 0x000000018B2AFB50-0x000000018B2AFBF4
		public void CreateTextureIfInvalid([IsReadOnly] in TextureDesc desc, ref TextureHandle texture); // 0x000000018B2AFA84-0x000000018B2AFB10
		public TextureDesc GetTextureDesc(TextureHandle texture); // 0x000000018B2B2204-0x000000018B2B2268
		public RendererListHandle CreateRendererList([IsReadOnly] in UnityEngine.Rendering.RendererUtils.RendererListDesc desc); // 0x000000018B2AF904-0x000000018B2AF924
		public ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer); // 0x000000018B2B22C4-0x000000018B2B22E4
		public ComputeBufferHandle CreateComputeBuffer([IsReadOnly] in ComputeBufferDesc desc); // 0x000000018B2AF8DC-0x000000018B2AF904
		public ComputeBufferHandle CreateComputeBuffer([IsReadOnly] in ComputeBufferHandle computeBuffer); // 0x000000018B2AF884-0x000000018B2AF8DC
		public ComputeBufferDesc GetComputeBufferDesc([IsReadOnly] in ComputeBufferHandle computeBuffer); // 0x000000018B2B1C70-0x000000018B2B1CB0
		public RenderGraphBuilder AddRenderPass<PassData>(string passName, out ref PassData passData, ProfilingSampler sampler)
			where PassData : class, new();
		public RenderGraphBuilder AddRenderPass<PassData>(string passName, out ref PassData passData)
			where PassData : class, new();
		public RenderGraphExecution RecordAndExecute([IsReadOnly] in RenderGraphParameters parameters); // 0x000000018B2B377C-0x000000018B2B3A38
		internal void Execute(); // 0x000000018B2B0A88-0x000000018B2B0CB0
		public void BeginProfilingSampler(ProfilingSampler sampler); // 0x000000018B2AE1F0-0x000000018B2AE484
		public void EndProfilingSampler(ProfilingSampler sampler); // 0x000000018B2B034C-0x000000018B2B05E0
		internal DynamicArray<CompiledPassInfo> GetCompiledPassInfos(); // 0x0000000184D86260-0x0000000184D86270
		internal void ClearCompiledGraph(); // 0x000000018B2AE700-0x000000018B2AE7D0
		private void InvalidateContext(); // 0x000000018B2B252C-0x000000018B2B2584
		internal void OnPassAdded(RenderGraphPass pass); // 0x000000018B2B2D68-0x000000018B2B2D94
		private void InitResourceInfosData(DynamicArray<CompiledResourceInfo> resourceInfos, int count); // 0x000000018B2B2318-0x000000018B2B23B8
		private void InitializeCompilationData(); // 0x000000018B2B23B8-0x000000018B2B252C
		private void CountReferences(); // 0x000000018B2AF230-0x000000018B2AF884
		private void CullUnusedPasses(); // 0x000000018B2AFCEC-0x000000018B2B028C
		private void UpdatePassSynchronization(ref CompiledPassInfo currentPassInfo, ref CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex); // 0x000000018B2B3F1C-0x000000018B2B3F3C
		private void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, [IsReadOnly] in CompiledResourceInfo resource); // 0x000000018B2B4830-0x000000018B2B4950
		private int GetLatestProducerIndex(int passIndex, [IsReadOnly] in CompiledResourceInfo info); // 0x000000018B2B1EE0-0x000000018B2B2014
		private int GetLatestValidReadIndex([IsReadOnly] in CompiledResourceInfo info); // 0x000000018B2B2014-0x000000018B2B20E4
		private int GetFirstValidWriteIndex([IsReadOnly] in CompiledResourceInfo info); // 0x000000018B2B1E10-0x000000018B2B1EE0
		private int GetLatestValidWriteIndex([IsReadOnly] in CompiledResourceInfo info); // 0x000000018B2B20E4-0x000000018B2B21B4
		private void CreateRendererLists(); // 0x000000018B2AF924-0x000000018B2AF9F4
		private void UpdateResourceAllocationAndSynchronization(); // 0x000000018B2B3F3C-0x000000018B2B4830
		private bool AreRendererListsEmpty(List<RendererListHandle> rendererLists); // 0x000000018B2AE024-0x000000018B2AE1F0
		private void TryCullPassAtIndex(int passIndex); // 0x000000018B2B3C8C-0x000000018B2B3D90
		private void CullRendererLists(); // 0x000000018B2AFBF4-0x000000018B2AFCEC
		internal void CompileRenderGraph(); // 0x000000018B2AF138-0x000000018B2AF230
		private ref CompiledPassInfo CompilePassImmediatly(RenderGraphPass pass); // 0x000000018B2AE948-0x000000018B2AF138
		private void ExecutePassImmediatly(RenderGraphPass pass); // 0x000000018B2B0954-0x000000018B2B0980
		private void ExecuteCompiledPass(ref CompiledPassInfo passInfo, int passIndex); // 0x000000018B2B05E0-0x000000018B2B0954
		private void ExecuteRenderGraph(); // 0x000000018B2B0980-0x000000018B2B0A88
		private void PreRenderPassSetRenderTargets([IsReadOnly] in CompiledPassInfo passInfo, RenderGraphContext rgContext); // 0x000000018B2B3378-0x000000018B2B377C
		private void PreRenderPassExecute([IsReadOnly] in CompiledPassInfo passInfo, RenderGraphContext rgContext); // 0x000000018B2B3038-0x000000018B2B3378
		private void PostRenderPassExecute(ref CompiledPassInfo passInfo, RenderGraphContext rgContext); // 0x000000018B2B2D94-0x000000018B2B3038
		private void ClearRenderPasses(); // 0x000000018B2AE7D0-0x000000018B2AE948
		private void ReleaseImmediateModeResources(); // 0x000000018B2B3A68-0x000000018B2B3C04
		private void LogFrameInformation(); // 0x000000018B2B2848-0x000000018B2B29BC
		private void LogRendererListsCreation(); // 0x000000018B2B2C78-0x000000018B2B2D68
		private void LogRenderPassBegin([IsReadOnly] in CompiledPassInfo passInfo); // 0x000000018B2B29BC-0x000000018B2B2C78
		private void LogCulledPasses(); // 0x000000018B2B2584-0x000000018B2B2848
		private ProfilingSampler GetDefaultProfilingSampler(string name); // 0x000000018B2B1D20-0x000000018B2B1E10
		private void UpdateImportedResourceLifeTime(ref RenderGraphDebugData.ResourceDebugData data, List<int> passList); // 0x000000018B2B3DBC-0x000000018B2B3F1C
		private void GenerateDebugData(); // 0x000000018B2B0CB0-0x000000018B2B1C70
		private void CleanupDebugData(); // 0x000000018B2AE484-0x000000018B2AE638
	}

	public struct RenderGraphProfilingScope : IDisposable // TypeDefIndex: 56839
	{
		// Fields
		private bool m_Disposed; // 0x00
		private ProfilingSampler m_Sampler; // 0x08
		private RenderGraph m_RenderGraph; // 0x10
	
		// Constructors
		public RenderGraphProfilingScope(RenderGraph renderGraph, ProfilingSampler sampler); // 0x000000018B2C314C-0x000000018B2C3194
	
		// Methods
		public void Dispose(); // 0x000000018B2C3140-0x000000018B2C314C
		private void Dispose(bool disposing); // 0x000000018B2C3108-0x000000018B2C3140
	}

	public struct RenderGraphBuilder : IDisposable // TypeDefIndex: 56840
	{
		// Fields
		private RenderGraphPass m_RenderPass; // 0x00
		private RenderGraphResourceRegistry m_Resources; // 0x08
		private RenderGraph m_RenderGraph; // 0x10
		private bool m_Disposed; // 0x18
	
		// Constructors
		internal RenderGraphBuilder(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph); // 0x0000000189B369D8-0x0000000189B36A10
	
		// Methods
		public TextureHandle UseColorBuffer([IsReadOnly] in TextureHandle input, int index); // 0x000000018B2C18D4-0x000000018B2C1950
		public TextureHandle UseDepthBuffer([IsReadOnly] in TextureHandle input, DepthAccess flags); // 0x000000018B2C1950-0x000000018B2C1A1C
		public TextureHandle ReadTexture([IsReadOnly] in TextureHandle input); // 0x000000018B2C1694-0x000000018B2C1860
		public TextureHandle WriteTexture([IsReadOnly] in TextureHandle input); // 0x000000018B2C1A64-0x000000018B2C1AC4
		public TextureHandle ReadWriteTexture([IsReadOnly] in TextureHandle input); // 0x000000018B2C1860-0x000000018B2C18D4
		public TextureHandle CreateTransientTexture([IsReadOnly] in TextureDesc desc); // 0x000000018B2C148C-0x000000018B2C14F8
		public TextureHandle CreateTransientTexture([IsReadOnly] in TextureHandle texture); // 0x000000018B2C14F8-0x000000018B2C15C8
		public RendererListHandle UseRendererList([IsReadOnly] in RendererListHandle input); // 0x000000018B2C15C8-0x000000018B2C15F4
		public ComputeBufferHandle ReadComputeBuffer([IsReadOnly] in ComputeBufferHandle input); // 0x000000018B2C166C-0x000000018B2C1694
		public ComputeBufferHandle WriteComputeBuffer([IsReadOnly] in ComputeBufferHandle input); // 0x000000018B2C1A1C-0x000000018B2C1A64
		public ComputeBufferHandle CreateTransientComputeBuffer([IsReadOnly] in ComputeBufferDesc desc); // 0x000000018B2C1438-0x000000018B2C148C
		public ComputeBufferHandle CreateTransientComputeBuffer([IsReadOnly] in ComputeBufferHandle computebuffer); // 0x000000018B2C13B4-0x000000018B2C1438
		public void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc)
			where PassData : class, new();
		public void EnableAsyncCompute(bool value); // 0x000000018B2C1634-0x000000018B2C1650
		public void AllowPassCulling(bool value); // 0x000000018B2C137C-0x000000018B2C1398
		public void Dispose(); // 0x000000018B2C1628-0x000000018B2C1634
		public void AllowRendererListCulling(bool value); // 0x000000018B2C1398-0x000000018B2C13B4
		public RendererListHandle DependsOn([IsReadOnly] in RendererListHandle input); // 0x000000018B2C15C8-0x000000018B2C15F4
		private void Dispose(bool disposing); // 0x000000018B2C15F4-0x000000018B2C1628
		private void CheckResource([IsReadOnly] in ResourceHandle res, bool dontCheckTransientReadWrite = false /* Metadata: 0x0234937A */); // 0x00000001841E1670-0x00000001841E1680
		internal void GenerateDebugData(bool value); // 0x000000018B2C1650-0x000000018B2C166C
	}

	public class RenderGraphDefaultResources // TypeDefIndex: 56841
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
		public TextureHandle blackTexture { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87480-0x0000000184D87490 0x0000000184D87490-0x0000000184D874A0
		public TextureHandle whiteTexture { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D905C0-0x0000000184D905D0 0x0000000184D926F0-0x0000000184D92700
		public TextureHandle clearTextureXR { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8CE10-0x0000000184D8CE20 0x0000000184D906B0-0x0000000184D906C0
		public TextureHandle magentaTextureXR { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA1280-0x0000000184DA1290 0x0000000184DA1330-0x0000000184DA1340
		public TextureHandle blackTextureXR { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8FD40-0x0000000184D8FD50 0x0000000184DA1310-0x0000000184DA1320
		public TextureHandle blackTextureArrayXR { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D90620-0x0000000184D90630 0x0000000184D9DEE0-0x0000000184D9DEF0
		public TextureHandle blackUIntTextureXR { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D9DC90-0x0000000184D9DCA0 0x0000000184DA12D0-0x0000000184DA12E0
		public TextureHandle blackTexture3DXR { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA1260-0x0000000184DA1270 0x0000000184DA1300-0x0000000184DA1310
		public TextureHandle whiteTextureXR { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA1230-0x0000000184DA1240 0x0000000184DA12B0-0x0000000184DA12C0
		public TextureHandle defaultShadowTexture { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA1220-0x0000000184DA1230 0x0000000184DA12A0-0x0000000184DA12B0
	
		// Constructors
		internal RenderGraphDefaultResources(); // 0x000000018B2C1CA4-0x000000018B2C1DC8
	
		// Methods
		internal void Cleanup(); // 0x000000018B2C1AC4-0x000000018B2C1B08
		internal void InitializeForRendering(RenderGraph renderGraph); // 0x000000018B2C1B08-0x000000018B2C1CA4
	}

	internal struct RenderGraphLogIndent : IDisposable // TypeDefIndex: 56842
	{
		// Fields
		private int m_Indentation; // 0x00
		private RenderGraphLogger m_Logger; // 0x08
		private bool m_Disposed; // 0x10
	
		// Constructors
		public RenderGraphLogIndent(RenderGraphLogger logger, int indentation = 1 /* Metadata: 0x0234937B */); // 0x000000018B2C1E08-0x000000018B2C1E44
	
		// Methods
		public void Dispose(); // 0x000000018B2C1DC8-0x000000018B2C1DD4
		private void Dispose(bool disposing); // 0x000000018B2C1DD4-0x000000018B2C1E08
	}

	internal class RenderGraphLogger // TypeDefIndex: 56843
	{
		// Fields
		private Dictionary<string, StringBuilder> m_LogMap; // 0x10
		private StringBuilder m_CurrentBuilder; // 0x18
		private int m_CurrentIndentation; // 0x20
	
		// Constructors
		public RenderGraphLogger(); // 0x000000018B2C22A8-0x000000018B2C2320
	
		// Methods
		public void Initialize(string logName); // 0x000000018B2C2134-0x000000018B2C2224
		public void IncrementIndentation(int value); // 0x000000018B2C20D8-0x000000018B2C2134
		public void DecrementIndentation(int value); // 0x000000018B2C1E44-0x000000018B2C1EB0
		public void LogLine(string format, params object[] args); // 0x000000018B2C2224-0x000000018B2C22A8
		public string GetLog(string logName); // 0x000000018B2C2048-0x000000018B2C20D8
		public string GetAllLogs(); // 0x000000018B2C1EB0-0x000000018B2C2048
	}

	public sealed class RenderGraphObjectPool // TypeDefIndex: 56846
	{
		// Fields
		private Dictionary<ValueTuple<System.Type, int>, Stack<object>> m_ArrayPool; // 0x10
		private List<ValueTuple<object, ValueTuple<System.Type, int>>> m_AllocatedArrays; // 0x18
		private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks; // 0x20
	
		// Nested types
		private abstract class SharedObjectPoolBase // TypeDefIndex: 56844
		{
			// Fields
			protected static List<SharedObjectPoolBase> s_AllocatedPools; // 0x00
	
			// Constructors
			protected SharedObjectPoolBase(); // 0x00000001841E1670-0x00000001841E1680
			static SharedObjectPoolBase(); // 0x000000018B2C6694-0x000000018B2C6720
	
			// Methods
			protected abstract void Clear();
			public static void ClearAll(); // 0x000000018B2C6560-0x000000018B2C6694
		}
	
		private class SharedObjectPool<T> : SharedObjectPoolBase // TypeDefIndex: 56845
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
		internal RenderGraphObjectPool(); // 0x000000018B2C2800-0x000000018B2C290C
	
		// Methods
		public T[] GetTempArray<T>(int size);
		public MaterialPropertyBlock GetTempMaterialPropertyBlock(); // 0x000000018B2C23C8-0x000000018B2C2484
		internal void ReleaseAllTempAlloc(); // 0x000000018B2C2484-0x000000018B2C2800
		internal T Get<T>()
			where T : new();
		internal void Release<T>(T value)
			where T : new();
		internal void Cleanup(); // 0x000000018B2C2320-0x000000018B2C23C8
	}

	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal abstract class RenderGraphPass // TypeDefIndex: 56847
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
		public string name { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public int index { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public ProfilingSampler customSampler { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public bool enableAsyncCompute { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
		public bool allowPassCulling { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D867B0-0x0000000184D867C0 0x0000000184D867C0-0x0000000184D867D0
		public TextureHandle depthBuffer { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8D370-0x0000000184D8D380 0x0000000184D8D3A0-0x0000000184D8D3B0
		public TextureHandle[] colorBuffers { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public int colorBufferMaxIndex { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D863D0-0x0000000184D863E0 0x0000000184D86450-0x0000000184D86460
		public int refCount { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D86600-0x0000000184D86610 0x0000000184D86630-0x0000000184D86640
		public bool generateDebugData { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D86800-0x0000000184D86810 0x0000000184D86840-0x0000000184D86850
		public bool allowRendererListCulling { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D867F0-0x0000000184D86800 0x0000000184D86830-0x0000000184D86840
	
		// Constructors
		public RenderGraphPass(); // 0x000000018B2C2E80-0x000000018B2C3108
	
		// Methods
		public RenderFunc<PassData> GetExecuteDelegate<PassData>()
			where PassData : class, new();
		public abstract void Execute(RenderGraphContext renderGraphContext);
		public abstract void Release(RenderGraphObjectPool pool);
		public abstract bool HasRenderFunc();
		public void Clear(); // 0x000000018B2C2AD4-0x000000018B2C2CE8
		public void AddResourceWrite([IsReadOnly] in ResourceHandle res); // 0x000000018B2C29A4-0x000000018B2C2A3C
		public void AddResourceRead([IsReadOnly] in ResourceHandle res); // 0x000000018B2C290C-0x000000018B2C29A4
		public void AddTransientResource([IsReadOnly] in ResourceHandle res); // 0x000000018B2C2A3C-0x000000018B2C2AD4
		public void UseRendererList(RendererListHandle rendererList); // 0x000000018B2C2E2C-0x000000018B2C2E80
		public void DependsOnRendererList(RendererListHandle rendererList); // 0x000000018B2C2CE8-0x000000018B2C2D3C
		public void EnableAsyncCompute(bool value); // 0x00000001811F33D0-0x00000001811F33E0
		public void AllowPassCulling(bool value); // 0x0000000184D867C0-0x0000000184D867D0
		public void AllowRendererListCulling(bool value); // 0x0000000184D86830-0x0000000184D86840
		public void GenerateDebugData(bool value); // 0x0000000184D86840-0x0000000184D86850
		public void SetColorBuffer(TextureHandle resource, int index); // 0x000000018B2C2D3C-0x000000018B2C2DD8
		public void SetDepthBuffer(TextureHandle resource, DepthAccess flags); // 0x000000018B2C2DD8-0x000000018B2C2E2C
	}

	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal sealed class RenderGraphPass<PassData> : RenderGraphPass // TypeDefIndex: 56848
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

	internal enum RenderGraphProfileId // TypeDefIndex: 56849
	{
		CompileRenderGraph = 0,
		ExecuteRenderGraph = 1,
		RenderGraphClear = 2,
		RenderGraphClearDebug = 3
	}

	[DebuggerDisplay("ComputeBuffer ({handle.index})")]
	public struct ComputeBufferHandle // TypeDefIndex: 56850
	{
		// Fields
		private static ComputeBufferHandle s_NullHandle; // 0x00
		internal ResourceHandle handle; // 0x00
	
		// Properties
		public static ComputeBufferHandle nullHandle { get; } // 0x000000018B2B7D20-0x000000018B2B7D70 
	
		// Constructors
		internal ComputeBufferHandle(int handle, bool shared = false /* Metadata: 0x02349380 */); // 0x000000018B2B7CE8-0x000000018B2B7D20
		static ComputeBufferHandle(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static implicit operator ComputeBuffer(ComputeBufferHandle buffer); // 0x000000018B2B7D70-0x000000018B2B7DDC
		public bool IsValid(); // 0x000000018B2B7C9C-0x000000018B2B7CE8
	}

	public struct ComputeBufferDesc // TypeDefIndex: 56851
	{
		// Fields
		public int count; // 0x00
		public int stride; // 0x04
		public ComputeBufferType type; // 0x08
		public string name; // 0x10
	
		// Constructors
		public ComputeBufferDesc(int count, int stride); // 0x0000000184DA11E0-0x0000000184DA1200
		public ComputeBufferDesc(int count, int stride, ComputeBufferType type); // 0x0000000184DA11C0-0x0000000184DA11E0
	
		// Methods
		public override int GetHashCode(); // 0x0000000184DB8C70-0x0000000184DB8C90
	}

	[DebuggerDisplay("ComputeBufferResource ({desc.name})")]
	internal class ComputeBufferResource : RenderGraphResource<ComputeBufferDesc, ComputeBuffer> // TypeDefIndex: 56852
	{
		// Constructors
		public ComputeBufferResource(); // 0x000000018B2B885C-0x000000018B2B8884
	
		// Methods
		public override string GetName(); // 0x000000018B2B859C-0x000000018B2B85DC
		public override void CreatePooledGraphicsResource(); // 0x000000018B2B8448-0x000000018B2B859C
		public override void ReleasePooledGraphicsResource(int frameIndex); // 0x000000018B2B8720-0x000000018B2B885C
		public override void CreateGraphicsResource(string name = "" /* Metadata: 0x02349381 */); // 0x000000018B2B82E0-0x000000018B2B8448
		public override void ReleaseGraphicsResource(); // 0x000000018B2B86DC-0x000000018B2B8720
		public override void LogCreation(RenderGraphLogger logger); // 0x000000018B2B85DC-0x000000018B2B865C
		public override void LogRelease(RenderGraphLogger logger); // 0x000000018B2B865C-0x000000018B2B86DC
	}

	internal class ComputeBufferPool : RenderGraphResourcePool<ComputeBuffer> // TypeDefIndex: 56853
	{
		// Constructors
		public ComputeBufferPool(); // 0x000000018B2B82A4-0x000000018B2B82E0
	
		// Methods
		protected override void ReleaseInternalResource(ComputeBuffer res); // 0x000000018B2B8284-0x000000018B2B82A4
		protected override string GetResourceName(ComputeBuffer res); // 0x000000018B2B7DDC-0x000000018B2B7E08
		protected override long GetResourceSize(ComputeBuffer res); // 0x000000018B2B7E08-0x000000018B2B7E48
		protected override string GetResourceTypeName(); // 0x000000018B2B7E48-0x000000018B2B7E74
		protected override int GetSortIndex(ComputeBuffer res); // 0x0000000189878C7C-0x0000000189878C9C
		public override void PurgeUnusedResources(int currentFrameIndex); // 0x000000018B2B7E74-0x000000018B2B8284
	}

	internal abstract class IRenderGraphResourcePool // TypeDefIndex: 56854
	{
		// Constructors
		protected IRenderGraphResourcePool(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract void PurgeUnusedResources(int currentFrameIndex);
		public abstract void Cleanup();
		public abstract void CheckFrameAllocation(bool onException, int frameIndex);
		public abstract void LogResources(RenderGraphLogger logger);
	}

	internal abstract class RenderGraphResourcePool<Type> : IRenderGraphResourcePool // TypeDefIndex: 56857
		where Type : class
	{
		// Fields
		[TupleElementNames(new string[2] {"resource", "frameIndex" })]
		protected Dictionary<int, SortedList<int, ValueTuple<Type, int>>> m_ResourcePool;
		protected List<int> m_RemoveList;
		private List<ValueTuple<int, Type>> m_FrameAllocatedResources;
		protected static int s_CurrentFrameIndex;
		private const int kStaleResourceLifetime = 10; // Metadata: 0x02349382
	
		// Nested types
		private struct ResourceLogInfo // TypeDefIndex: 56855
		{
			// Fields
			public string name;
			public long size;
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56856
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

	internal class RenderGraphResourceRegistry // TypeDefIndex: 56860
	{
		// Fields
		private const int kSharedResourceLifetime = 30; // Metadata: 0x02349386
		private static RenderGraphResourceRegistry m_CurrentRegistry; // 0x00
		private RenderGraphResourcesData[] m_RenderGraphResources; // 0x10
		private DynamicArray<RendererListResource> m_RendererListResources; // 0x18
		private RenderGraphDebugParams m_RenderGraphDebug; // 0x20
		private RenderGraphLogger m_ResourceLogger; // 0x28
		private RenderGraphLogger m_FrameInformationLogger; // 0x30
		private int m_CurrentFrameIndex; // 0x38
		private int m_ExecutionCount; // 0x3C
		private RTHandle m_CurrentBackbuffer; // 0x40
		private const int kInitialRendererListCount = 256; // Metadata: 0x02349387
		private List<UnityEngine.Rendering.RendererUtils.RendererList> m_ActiveRendererLists; // 0x48
	
		// Properties
		internal static RenderGraphResourceRegistry current { get; set; } // 0x000000018B2C5E60-0x000000018B2C5E98 0x000000018B2C5E98-0x000000018B2C5EE8
	
		// Nested types
		private delegate void ResourceCallback(RenderGraphContext rgContext, IRenderGraphResource res); // TypeDefIndex: 56858; 0x00000001838E1420-0x00000001838E1430
	
		private class RenderGraphResourcesData // TypeDefIndex: 56859
		{
			// Fields
			public DynamicArray<IRenderGraphResource> resourceArray; // 0x10
			public int sharedResourcesCount; // 0x18
			public IRenderGraphResourcePool pool; // 0x20
			public ResourceCallback createResourceCallback; // 0x28
			public ResourceCallback releaseResourceCallback; // 0x30
	
			// Constructors
			public RenderGraphResourcesData(); // 0x000000018B2C6010-0x000000018B2C6088
	
			// Methods
			public void Clear(bool onException, int frameIndex); // 0x000000018B2C5F6C-0x000000018B2C5FEC
			public void Cleanup(); // 0x000000018B2C5EE8-0x000000018B2C5F6C
			public void PurgeUnusedGraphicsResources(int frameIndex); // 0x000000018B2C5FEC-0x000000018B2C6010
			public int AddNewRenderGraphResource<ResType>(out ref ResType outRes, bool pooledResource = true /* Metadata: 0x02349389 */)
				where ResType : IRenderGraphResource, new();
		}
	
		// Constructors
		private RenderGraphResourceRegistry(); // 0x000000018B2C5D38-0x000000018B2C5E60
		internal RenderGraphResourceRegistry(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger frameInformationLogger); // 0x000000018B2C59D4-0x000000018B2C5D38
	
		// Methods
		internal RTHandle GetTexture([IsReadOnly] in TextureHandle handle); // 0x000000018B2C49D0-0x000000018B2C4B7C
		internal bool TextureNeedsFallback([IsReadOnly] in TextureHandle handle); // 0x000000018B2C58C0-0x000000018B2C5944
		internal UnityEngine.Rendering.RendererUtils.RendererList GetRendererList([IsReadOnly] in RendererListHandle handle); // 0x000000018B2C46C0-0x000000018B2C478C
		internal ComputeBuffer GetComputeBuffer([IsReadOnly] in ComputeBufferHandle handle); // 0x000000018B2C43D4-0x000000018B2C44A4
		internal void BeginRenderGraph(int executionCount); // 0x000000018B2C31B4-0x000000018B2C323C
		internal void BeginExecute(int currentFrameIndex); // 0x000000018B2C3194-0x000000018B2C31B4
		internal void EndExecute(); // 0x000000018B2C40F0-0x000000018B2C40F8
		private void CheckHandleValidity([IsReadOnly] in ResourceHandle res); // 0x000000018B2C323C-0x000000018B2C3290
		private void CheckHandleValidity(RenderGraphResourceType type, int index); // 0x000000018B2C3290-0x000000018B2C33B8
		internal void IncrementWriteCount([IsReadOnly] in ResourceHandle res); // 0x000000018B2C4E7C-0x000000018B2C4F38
		internal string GetRenderGraphResourceName([IsReadOnly] in ResourceHandle res); // 0x000000018B2C44A4-0x000000018B2C4564
		internal string GetRenderGraphResourceName(RenderGraphResourceType type, int index); // 0x000000018B2C4564-0x000000018B2C4604
		internal bool IsRenderGraphResourceImported([IsReadOnly] in ResourceHandle res); // 0x000000018B2C5094-0x000000018B2C5150
		internal bool IsRenderGraphResourceShared(RenderGraphResourceType type, int index); // 0x000000018B2C5150-0x000000018B2C51AC
		internal bool IsGraphicsResourceCreated([IsReadOnly] in ResourceHandle res); // 0x000000018B2C4F38-0x000000018B2C4FF8
		internal bool IsRendererListCreated([IsReadOnly] in RendererListHandle res); // 0x000000018B2C51AC-0x000000018B2C5234
		internal bool IsRenderGraphResourceImported(RenderGraphResourceType type, int index); // 0x000000018B2C4FF8-0x000000018B2C5094
		internal int GetRenderGraphResourceTransientIndex([IsReadOnly] in ResourceHandle res); // 0x000000018B2C4604-0x000000018B2C46C0
		internal TextureHandle ImportTexture(RTHandle rt); // 0x000000018B2C4DAC-0x000000018B2C4E7C
		internal TextureHandle CreateSharedTexture([IsReadOnly] in TextureDesc desc, bool explicitRelease); // 0x000000018B2C3B2C-0x000000018B2C3D34
		internal void ReleaseSharedTexture(TextureHandle texture); // 0x000000018B2C55F4-0x000000018B2C571C
		internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt); // 0x000000018B2C4B7C-0x000000018B2C4CF0
		internal TextureHandle CreateTexture([IsReadOnly] in TextureDesc desc, int transientPassIndex = -1 /* Metadata: 0x02349383 */); // 0x000000018B2C3FD8-0x000000018B2C40F0
		internal int GetTextureResourceCount(); // 0x000000018B2C478C-0x000000018B2C47E8
		private TextureResource GetTextureResource([IsReadOnly] in ResourceHandle handle); // 0x000000018B2C4910-0x000000018B2C49D0
		internal TextureDesc GetTextureResourceDesc([IsReadOnly] in ResourceHandle handle); // 0x000000018B2C47E8-0x000000018B2C4910
		internal void ForceTextureClear([IsReadOnly] in ResourceHandle handle, UnityEngine.Color clearColor); // 0x000000018B2C4154-0x000000018B2C41B4
		internal RendererListHandle CreateRendererList([IsReadOnly] in UnityEngine.Rendering.RendererUtils.RendererListDesc desc); // 0x000000018B2C36C0-0x000000018B2C37F4
		internal ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer); // 0x000000018B2C4CF0-0x000000018B2C4DAC
		internal ComputeBufferHandle CreateComputeBuffer([IsReadOnly] in ComputeBufferDesc desc, int transientPassIndex = -1 /* Metadata: 0x02349384 */); // 0x000000018B2C34D4-0x000000018B2C35B0
		internal ComputeBufferDesc GetComputeBufferResourceDesc([IsReadOnly] in ResourceHandle handle); // 0x000000018B2C4210-0x000000018B2C4314
		internal int GetComputeBufferResourceCount(); // 0x000000018B2C41B4-0x000000018B2C4210
		private ComputeBufferResource GetComputeBufferResource([IsReadOnly] in ResourceHandle handle); // 0x000000018B2C4314-0x000000018B2C43D4
		internal void UpdateSharedResourceLastFrameIndex(int type, int index); // 0x000000018B2C5944-0x000000018B2C59D4
		private void ManageSharedRenderGraphResources(); // 0x000000018B2C5340-0x000000018B2C548C
		internal void CreatePooledResource(RenderGraphContext rgContext, int type, int index); // 0x000000018B2C35B0-0x000000018B2C36C0
		private void CreateTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res); // 0x000000018B2C3D34-0x000000018B2C3FD8
		internal void ReleasePooledResource(RenderGraphContext rgContext, int type, int index); // 0x000000018B2C54E0-0x000000018B2C55F4
		private void ReleaseTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res); // 0x000000018B2C571C-0x000000018B2C58C0
		private void ValidateTextureDesc([IsReadOnly] in TextureDesc desc); // 0x00000001841E1670-0x00000001841E1680
		private void ValidateRendererListDesc([IsReadOnly] in UnityEngine.Rendering.RendererUtils.RendererListDesc desc); // 0x00000001841E1670-0x00000001841E1680
		private void ValidateComputeBufferDesc([IsReadOnly] in ComputeBufferDesc desc); // 0x00000001841E1670-0x00000001841E1680
		internal void CreateRendererLists(List<RendererListHandle> rendererLists, ScriptableRenderContext context, bool manualDispatch = false /* Metadata: 0x02349385 */); // 0x000000018B2C37F4-0x000000018B2C3B2C
		internal void Clear(bool onException); // 0x000000018B2C3418-0x000000018B2C34D4
		internal void PurgeUnusedGraphicsResources(); // 0x000000018B2C548C-0x000000018B2C54E0
		internal void Cleanup(); // 0x000000018B2C33B8-0x000000018B2C3418
		internal void FlushLogs(); // 0x000000018B2C40F8-0x000000018B2C4154
		private void LogResources(); // 0x000000018B2C5234-0x000000018B2C5340
	}

	[DebuggerDisplay("RendererList ({handle})")]
	public struct RendererListHandle // TypeDefIndex: 56861
	{
		// Fields
		private bool m_IsValid; // 0x00
		[CompilerGenerated]
		private int _handle_k__BackingField; // 0x04
	
		// Properties
		internal int handle { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000184D88B20-0x0000000184D88B30 0x0000000184D88B50-0x0000000184D88B60
	
		// Constructors
		internal RendererListHandle(int handle); // 0x0000000184D9D420-0x0000000184D9D430
	
		// Methods
		public static implicit operator int(RendererListHandle handle); // 0x0000000184D9D8A0-0x0000000184D9D8B0
		public static implicit operator UnityEngine.Rendering.RendererUtils.RendererList(RendererListHandle rendererList); // 0x000000018B2C6088-0x000000018B2C6118
		public bool IsValid(); // 0x0000000184D883E0-0x0000000184D883F0
	}

	internal struct RendererListResource // TypeDefIndex: 56862
	{
		// Fields
		public UnityEngine.Rendering.RendererUtils.RendererListDesc desc; // 0x00
		public UnityEngine.Rendering.RendererUtils.RendererList rendererList; // 0xE0
	
		// Constructors
		internal RendererListResource([IsReadOnly] in UnityEngine.Rendering.RendererUtils.RendererListDesc desc); // 0x0000000189B3F960-0x0000000189B3FA80
	}

	internal enum RenderGraphResourceType // TypeDefIndex: 56863
	{
		Texture = 0,
		ComputeBuffer = 1,
		Count = 2
	}

	internal struct ResourceHandle // TypeDefIndex: 56864
	{
		// Fields
		private const uint kValidityMask = 4294901760; // Metadata: 0x0234938D
		private const uint kIndexMask = 65535; // Metadata: 0x02349392
		private uint m_Value; // 0x00
		private static uint s_CurrentValidBit; // 0x00
		private static uint s_SharedResourceValidBit; // 0x04
		[CompilerGenerated]
		private RenderGraphResourceType _type_k__BackingField; // 0x04
	
		// Properties
		public int index { get; } // 0x0000000184D87110-0x0000000184D87120 
		public RenderGraphResourceType type { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88B20-0x0000000184D88B30 0x0000000184D88B50-0x0000000184D88B60
		public int iType { get; } // 0x000000018B2C6330-0x000000018B2C6374 
	
		// Constructors
		internal ResourceHandle(int value, RenderGraphResourceType type, bool shared); // 0x000000018B2C62A4-0x000000018B2C6330
		static ResourceHandle(); // 0x000000018B2C6254-0x000000018B2C62A4
	
		// Methods
		public static implicit operator int(ResourceHandle handle); // 0x000000018B2C6374-0x000000018B2C63B8
		public bool IsValid(); // 0x000000018B2C6118-0x000000018B2C6190
		public static void NewFrame(int executionIndex); // 0x000000018B2C6190-0x000000018B2C6254
	}

	internal class IRenderGraphResource // TypeDefIndex: 56865
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
		public IRenderGraphResource(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public virtual void Reset(IRenderGraphResourcePool pool); // 0x000000018B2C12BC-0x000000018B2C12E0
		public virtual string GetName(); // 0x000000018B2C127C-0x000000018B2C12A8
		public virtual bool IsCreated(); // 0x00000001812081B0-0x0000000181208610
		public virtual void IncrementWriteCount(); // 0x0000000184DB8D00-0x0000000184DB8D10
		public virtual bool NeedsFallBack(); // 0x000000018B2C12A8-0x000000018B2C12BC
		public virtual void CreatePooledGraphicsResource(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void CreateGraphicsResource(string name = "" /* Metadata: 0x02349396 */); // 0x00000001841E1670-0x00000001841E1680
		public virtual void ReleasePooledGraphicsResource(int frameIndex); // 0x00000001841E1670-0x00000001841E1680
		public virtual void ReleaseGraphicsResource(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void LogCreation(RenderGraphLogger logger); // 0x00000001841E1670-0x00000001841E1680
		public virtual void LogRelease(RenderGraphLogger logger); // 0x00000001841E1670-0x00000001841E1680
		public virtual int GetSortIndex(); // 0x00000001811EC580-0x00000001811EC590
	}

	[DebuggerDisplay("Resource ({GetType().Name}:{GetName()})")]
	internal abstract class RenderGraphResource<DescType, ResType> : IRenderGraphResource // TypeDefIndex: 56866
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
	public struct TextureHandle // TypeDefIndex: 56867
	{
		// Fields
		private static TextureHandle s_NullHandle; // 0x00
		internal ResourceHandle handle; // 0x00
		internal ResourceHandle fallBackResource; // 0x08
	
		// Properties
		public static TextureHandle nullHandle { get; } // 0x000000018B2C6CBC-0x000000018B2C6D18 
	
		// Constructors
		internal TextureHandle(int handle, bool shared = false /* Metadata: 0x02349397 */); // 0x000000018B2C6C30-0x000000018B2C6CBC
		static TextureHandle(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static implicit operator RenderTargetIdentifier(TextureHandle texture); // 0x000000018B2C6E78-0x000000018B2C6F2C
		public static implicit operator Texture(TextureHandle texture); // 0x000000018B2C6D18-0x000000018B2C6D94
		public static implicit operator RenderTexture(TextureHandle texture); // 0x000000018B2C6DFC-0x000000018B2C6E78
		public static implicit operator RTHandle(TextureHandle texture); // 0x000000018B2C6D94-0x000000018B2C6DFC
		public bool IsValid(); // 0x000000018B2C6BE4-0x000000018B2C6C30
		public void SetFallBackResource(TextureHandle texture); // 0x0000000184DB8D10-0x0000000184DB8D20
	}

	public enum TextureSizeMode // TypeDefIndex: 56868
	{
		Explicit = 0,
		Scale = 1,
		Functor = 2
	}

	public struct FastMemoryDesc // TypeDefIndex: 56869
	{
		// Fields
		public bool inFastMemory; // 0x00
		public FastMemoryFlags flags; // 0x04
		public float residencyFraction; // 0x08
	}

	public struct TextureDesc // TypeDefIndex: 56870
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
		public TextureDesc(int width, int height, bool xrReady = false /* Metadata: 0x0234939B */); // 0x000000018B2C6BB0-0x000000018B2C6BE4
		public TextureDesc(TextureDesc input); // 0x0000000189B419A0-0x0000000189B419D8
	
		// Methods
		private void InitDefaultValues(bool xrReady); // 0x000000018B2C6B48-0x000000018B2C6BB0
		public override int GetHashCode(); // 0x000000018B2C6A4C-0x000000018B2C6B48
	}

	[DebuggerDisplay("TextureResource ({desc.name})")]
	internal class TextureResource : RenderGraphResource<TextureDesc, RTHandle> // TypeDefIndex: 56871
	{
		// Fields
		private static int m_TextureCreationIndex; // 0x00
	
		// Constructors
		public TextureResource(); // 0x000000018B2C7ACC-0x000000018B2C7AF4
	
		// Methods
		public override string GetName(); // 0x000000018B2C77A8-0x000000018B2C7804
		public override void CreatePooledGraphicsResource(); // 0x000000018B2C7654-0x000000018B2C77A8
		public override void ReleasePooledGraphicsResource(int frameIndex); // 0x000000018B2C7984-0x000000018B2C7ACC
		public override void CreateGraphicsResource(string name = "" /* Metadata: 0x0234939C */); // 0x000000018B2C742C-0x000000018B2C7654
		public override void ReleaseGraphicsResource(); // 0x000000018B2C7938-0x000000018B2C7984
		public override void LogCreation(RenderGraphLogger logger); // 0x000000018B2C7804-0x000000018B2C78B8
		public override void LogRelease(RenderGraphLogger logger); // 0x000000018B2C78B8-0x000000018B2C7938
	}

	internal class TexturePool : RenderGraphResourcePool<RTHandle> // TypeDefIndex: 56872
	{
		// Constructors
		public TexturePool(); // 0x000000018B2C73F0-0x000000018B2C742C
	
		// Methods
		protected override void ReleaseInternalResource(RTHandle res); // 0x000000018B2C73D0-0x000000018B2C73F0
		protected override string GetResourceName(RTHandle res); // 0x000000018B2C6F2C-0x000000018B2C6F50
		protected override long GetResourceSize(RTHandle res); // 0x000000018B2C6F50-0x000000018B2C6F74
		protected override string GetResourceTypeName(); // 0x000000018B2C6F74-0x000000018B2C6FA0
		protected override int GetSortIndex(RTHandle res); // 0x000000018B2C6FA0-0x000000018B2C6FC0
		public override void PurgeUnusedResources(int currentFrameIndex); // 0x000000018B2C6FC0-0x000000018B2C73D0
	}
}

namespace UnityEngine.Rendering
{
	public class CameraSwitcher : MonoBehaviour // TypeDefIndex: 56873
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
		public CameraSwitcher(); // 0x000000018B2B7854-0x000000018B2B7870
	
		// Methods
		private void OnEnable(); // 0x000000018B2B7060-0x000000018B2B75B4
		private void OnDisable(); // 0x000000018B2B6FEC-0x000000018B2B7060
		private int GetCameraCount(); // 0x000000018B2B6F8C-0x000000018B2B6FAC
		private Camera GetNextCamera(); // 0x000000018B2B6FAC-0x000000018B2B6FEC
		private void SetCameraIndex(int index); // 0x000000018B2B75B4-0x000000018B2B784C
		[CompilerGenerated]
		private int _OnEnable_b__10_0(); // 0x0000000182B70F90-0x0000000182B70FA0
		[CompilerGenerated]
		private void _OnEnable_b__10_1(int value); // 0x000000018B2B784C-0x000000018B2B7854
		[CompilerGenerated]
		private int _OnEnable_b__10_2(); // 0x0000000184D868A0-0x0000000184D868B0
		[CompilerGenerated]
		private void _OnEnable_b__10_3(int value); // 0x0000000184D868D0-0x0000000184D868E0
	}

	public class FreeCamera : MonoBehaviour // TypeDefIndex: 56874
	{
		// Fields
		private const float k_MouseSensitivityMultiplier = 0.01f; // Metadata: 0x0234939D
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
		public FreeCamera(); // 0x000000018B2C1154-0x000000018B2C118C
	
		// Methods
		private void OnEnable(); // 0x000000018B2C02DC-0x000000018B2C02E4
		private void RegisterInputs(); // 0x000000018B2C02E4-0x000000018B2C0A78
		private void UpdateInputs(); // 0x000000018B2C0A78-0x000000018B2C0C90
		private void Update(); // 0x000000018B2C0C90-0x000000018B2C1154
	}

	public static class CommandBufferPool // TypeDefIndex: 56876
	{
		// Fields
		private static ObjectPool<CommandBuffer> s_BufferPool; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56875
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000184D43C90-0x0000000184D43CF0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _.cctor_b__4_0(CommandBuffer x); // 0x0000000183127EF0-0x0000000183128110
			internal void _.cctor_b__4_1(CommandBuffer x); // 0x0000000183128110-0x0000000183128170
		}
	
		// Constructors
		static CommandBufferPool(); // 0x0000000184B083D0-0x0000000184B08540
	
		// Methods
		public static CommandBuffer Get(); // 0x000000018B2B7914-0x000000018B2B79B0
		public static CommandBuffer Get(string name); // 0x0000000183339460-0x0000000183339740
		public static void Release(CommandBuffer buffer); // 0x0000000183339790-0x00000001833397E0
	}

	[Flags]
	public enum ClearFlag // TypeDefIndex: 56877
	{
		None = 0,
		Color = 1,
		Depth = 2,
		Stencil = 4,
		ColorStencil = 5,
		DepthStencil = 6,
		All = 7
	}

	public static class ComponentSingleton<TType> // TypeDefIndex: 56878
		where TType : Component
	{
		// Fields
		private static TType s_Instance;
	
		// Properties
		public static TType instance { get; }
	
		// Methods
		public static void Release();
	}

	public class ConstantBuffer // TypeDefIndex: 56879
	{
		// Fields
		private static List<ConstantBufferBase> m_RegisteredConstantBuffers; // 0x00
	
		// Constructors
		public ConstantBuffer(); // 0x00000001841E1670-0x00000001841E1680
		static ConstantBuffer(); // 0x0000000184D187B0-0x0000000184D18840
	
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
		public static void ReleaseAll(); // 0x0000000184A41F00-0x0000000184A42080
		internal static void Register(ConstantBufferBase cb); // 0x000000018B2B8884-0x000000018B2B88F4
	}

	public abstract class ConstantBufferBase // TypeDefIndex: 56880
	{
		// Constructors
		protected ConstantBufferBase(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract void Release();
	}

	public class ConstantBuffer<CBType> : ConstantBufferBase // TypeDefIndex: 56881
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

	internal class ConstantBufferSingleton<CBType> : ConstantBuffer<CBType> // TypeDefIndex: 56882
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
	public class DisplayInfoAttribute : Attribute // TypeDefIndex: 56883
	{
		// Fields
		public string name; // 0x10
		public int order; // 0x18
	
		// Constructors
		public DisplayInfoAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class AdditionalPropertyAttribute : Attribute // TypeDefIndex: 56884
	{
		// Constructors
		public AdditionalPropertyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal enum CoreProfileId // TypeDefIndex: 56885
	{
		BlitTextureInPotAtlas = 0
	}

	public static class CoreUnsafeUtils // TypeDefIndex: 56890
	{
		// Nested types
		public struct FixedBufferStringQueue // TypeDefIndex: 56886
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
			public int Count { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
	
			// Constructors
			public unsafe FixedBufferStringQueue(byte* ptr, int length); // 0x000000018B2C014C-0x000000018B2C0174
	
			// Methods
			public bool TryPush(string v); // 0x000000018B2C00AC-0x000000018B2C014C
			public bool TryPop(out string v); // 0x000000018B2C003C-0x000000018B2C00AC
			public void Clear(); // 0x000000018B2C0018-0x000000018B2C003C
		}
	
		public interface IKeyGetter<TValue, TKey> // TypeDefIndex: 56887
		{
			// Methods
			TKey Get(ref ref TValue v);
		}
	
		internal struct DefaultKeyGetter<T> : IKeyGetter<T, T> // TypeDefIndex: 56888
		{
			// Methods
			public T Get(ref ref T v);
		}
	
		internal struct UintKeyGetter : IKeyGetter<uint, uint> // TypeDefIndex: 56889
		{
			// Methods
			public uint Get(ref uint v); // 0x0000000184D94D20-0x0000000184D94D30
		}
	
		// Methods
		private static void CalculateRadixParams(int radixBits, out int bitStates); // 0x000000018B2B8FF8-0x000000018B2B9074
		private static int CalculateRadixSupportSize(int bitStates, int arrayLength); // 0x0000000184DB8CD0-0x0000000184DB8CE0
		private static unsafe void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, uint* supportArray, out uint* bucketIndices, out uint* bucketSizes, out uint* bucketPrefix, out uint* arrayOutput); // 0x0000000184DB8C90-0x0000000184DB8CD0
		private static unsafe void MergeSort(uint* array, uint* support, int length); // 0x000000018B2B9398-0x000000018B2B9544
		public static void MergeSort(uint[] arr, int sortSize, ref uint[] supportArray); // 0x000000018B2B9544-0x000000018B2B9638
		public static void MergeSort(NativeArray<uint> arr, Unity.Collections.Allocator arrAllocator, int sortSize, ref NativeArray<uint> supportArray); // 0x000000018B2B9638-0x000000018B2B9708
		private static unsafe void InsertionSort(uint* arr, int length); // 0x000000018B2B92D4-0x000000018B2B9314
		public static void InsertionSort(uint[] arr, int sortSize); // 0x000000018B2B9314-0x000000018B2B9398
		public static void InsertionSort(NativeArray<uint> arr, int sortSize); // 0x000000018B2B925C-0x000000018B2B92D4
		private static unsafe void RadixSort(uint* array, uint* support, int radixBits, int bitStates, int length); // 0x000000018B2B9780-0x000000018B2B9944
		public static void RadixSort(uint[] arr, int sortSize, ref uint[] supportArray, int radixBits = 8 /* Metadata: 0x023493A9 */); // 0x000000018B2B9A30-0x000000018B2B9B40
		public static void RadixSort(NativeArray<uint> array, int sortSize, ref NativeArray<uint> supportArray, Unity.Collections.Allocator supportArrayAllocator, int radixBits = 8 /* Metadata: 0x023493AA */); // 0x000000018B2B9944-0x000000018B2B9A30
		public static void QuickSort(uint[] arr, int left, int right); // 0x000000018B2B9708-0x000000018B2B9780
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
		public static unsafe int CompareHashes(int oldHashCount, Hash128* oldHashes, int newHashCount, Hash128* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount); // 0x000000018B2B90CC-0x000000018B2B913C
		public static unsafe void CombineHashes<TValue, TGetter>(int count, void* hashes, Hash128* outHash)
			where TValue : struct
			where TGetter : struct, IKeyGetter<TValue, Hash128>;
		public static unsafe void CombineHashes(int count, Hash128* hashes, Hash128* outHash); // 0x000000018B2B9074-0x000000018B2B90CC
		private static unsafe int Partition<TValue, TKey, TGetter>(void* data, int left, int right)
			where TValue : struct
			where TKey : struct, IComparable<TKey>
			where TGetter : struct, IKeyGetter<TValue, TKey>;
		public static bool HaveDuplicates(int[] arr); // 0x000000018B2B913C-0x000000018B2B925C
	
		// Extension methods
		public static unsafe void CopyTo<T>(this List<T> list, void* dest, int count)
			where T : struct;
		public static unsafe void CopyTo<T>(this T[] list, void* dest, int count)
			where T : struct;
	}

	public class DynamicArray<T> // TypeDefIndex: 56891
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
		public void Resize(int newSize, bool keepContent = false /* Metadata: 0x023493AB */);
		public void Reserve(int newCapacity, bool keepContent = false /* Metadata: 0x023493AC */);
		public static implicit operator T[](DynamicArray<T> array);
	}

	public static class DynamicArrayExtensions // TypeDefIndex: 56892
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

	public delegate float PerformDynamicRes(); // TypeDefIndex: 56893; 0x0000000187378308-0x0000000187378318

	public enum DynamicResScalePolicyType // TypeDefIndex: 56894
	{
		ReturnsPercentage = 0,
		ReturnsMinMaxLerpFactor = 1
	}

	public enum DynamicResScalerSlot // TypeDefIndex: 56895
	{
		User = 0,
		System = 1,
		Count = 2
	}

	public class DynamicResolutionHandler // TypeDefIndex: 56898
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
		private const int CameraDictionaryMaxcCapacity = 32; // Metadata: 0x023493B5
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
		public DynamicResUpscaleFilter filter { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86A30-0x0000000184D86A40 0x0000000184D86A40-0x0000000184D86A50
		public Vector2Int finalViewport { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86200-0x0000000184D86210 0x0000000184D866F0-0x0000000184D86700
		public bool runUpscalerFilterOnFullResolution { get; set; } // 0x000000018B2BFA4C-0x000000018B2BFA60 0x0000000184D867C0-0x0000000184D867D0
		public UpsamplerScheduleType upsamplerSchedule { get; set; } // 0x0000000184D86890-0x0000000184D868A0 0x0000000184D868C0-0x0000000184D868D0
		public static DynamicResolutionHandler instance { get; } // 0x000000018B2BFA18-0x000000018B2BFA4C 
	
		// Nested types
		private struct ScalerContainer // TypeDefIndex: 56896
		{
			// Fields
			public DynamicResScalePolicyType type; // 0x00
			public PerformDynamicRes method; // 0x08
		}
	
		public enum UpsamplerScheduleType // TypeDefIndex: 56897
		{
			BeforePost = 0,
			AfterPost = 1
		}
	
		// Constructors
		private DynamicResolutionHandler(); // 0x0000000184671750-0x00000001846717A0
		static DynamicResolutionHandler(); // 0x00000001846713A0-0x00000001846716C0
	
		// Methods
		private void Reset(); // 0x0000000184671970-0x00000001846719C0
		private bool FlushScalableBufferManagerState(); // 0x000000018B2BEAB0-0x000000018B2BEBBC
		private static DynamicResolutionHandler GetOrCreateDrsInstanceHandler(Camera camera); // 0x000000018B2BEBD8-0x000000018B2BF0A4
		private static float DefaultDynamicResMethod(); // 0x0000000184D88DD0-0x0000000184D88DE0
		private void ProcessSettings(GlobalDynamicResolutionSettings settings); // 0x000000018B2BF104-0x000000018B2BF2CC
		public Vector2 GetResolvedScale(); // 0x000000018B2BF0A4-0x000000018B2BF104
		public float CalculateMipBias(Vector2Int inputResolution, Vector2Int outputResolution, bool forceApply = false /* Metadata: 0x023493B2 */); // 0x0000000183EC96B0-0x0000000183EC96F0
		public static void SetDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor /* Metadata: 0x023493B3 */); // 0x000000018B2BF334-0x000000018B2BF3C8
		public static void SetSystemDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor /* Metadata: 0x023493B4 */); // 0x000000018B2BF3C8-0x000000018B2BF45C
		public static void SetActiveDynamicScalerSlot(DynamicResScalerSlot slot); // 0x000000018B2BF2E0-0x000000018B2BF334
		public static void ClearSelectedCamera(); // 0x0000000183DF2EA0-0x0000000183DF2F20
		public static void SetUpscaleFilter(Camera camera, DynamicResUpscaleFilter filter); // 0x000000018B2BF45C-0x000000018B2BF570
		public void SetCurrentCameraRequest(bool cameraRequest); // 0x0000000184D86860-0x0000000184D86870
		public static void UpdateAndUseCamera(Camera camera, GlobalDynamicResolutionSettings? settings = default, Action OnResolutionChange = null); // 0x000000018B2BF5BC-0x000000018B2BF794
		public void Update(GlobalDynamicResolutionSettings settings, Action OnResolutionChange = null); // 0x000000018B2BF794-0x000000018B2BFA18
		public bool SoftwareDynamicResIsEnabled(); // 0x000000018B2BF570-0x000000018B2BF5BC
		public bool HardwareDynamicResIsEnabled(); // 0x0000000184D30F30-0x0000000184D31040
		public bool RequestsHardwareDynamicResolution(); // 0x000000018B2BF2CC-0x000000018B2BF2E0
		public bool DynamicResolutionEnabled(); // 0x000000018B2BEA7C-0x000000018B2BEAB0
		public void ForceSoftwareFallback(); // 0x0000000184D8E3B0-0x0000000184D8E3C0
		public Vector2Int GetScaledSize(Vector2Int size); // 0x0000000183F65000-0x0000000183F65020
		public Vector2Int ApplyScalesOnSize(Vector2Int size); // 0x000000018B2BE994-0x000000018B2BE9C8
		internal Vector2Int ApplyScalesOnSize(Vector2Int size, Vector2 scales); // 0x000000018B2BE9C8-0x000000018B2BEA7C
		public float GetCurrentScale(); // 0x000000018B2BEBBC-0x000000018B2BEBD8
		public Vector2Int GetLastScaledSize(); // 0x0000000184DB8CF0-0x0000000184DB8D00
		public float GetLowResMultiplier(float targetLowRes); // 0x0000000183F64FD0-0x0000000183F65000
	}

	public enum DynamicResolutionType : byte // TypeDefIndex: 56899
	{
		Software = 0,
		Hardware = 1
	}

	public enum DynamicResUpscaleFilter : byte // TypeDefIndex: 56900
	{
		Bilinear = 0,
		CatmullRom = 1,
		Lanczos = 2,
		ContrastAdaptiveSharpen = 3,
		EdgeAdaptiveScalingUpres = 4,
		TAAU = 5
	}

	[Serializable]
	public struct GlobalDynamicResolutionSettings // TypeDefIndex: 56901
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
		public static GlobalDynamicResolutionSettings NewDefault(); // 0x0000000184671920-0x0000000184671970
	}

	public interface IAdditionalData // TypeDefIndex: 56902
	{
	}

	public interface IVirtualTexturingEnabledRenderPipeline // TypeDefIndex: 56903
	{
		// Properties
		bool virtualTexturingEnabled { get; }
	}

	public struct ListBuffer<T> // TypeDefIndex: 56904
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

	public static class ListBufferExtensions // TypeDefIndex: 56905
	{
		// Extension methods
		public static void QuickSort<T>(this ListBuffer<T> self)
			where T : struct, IComparable<T>;
	}

	public class ObjectPool<T> // TypeDefIndex: 56907
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
		public struct PooledObject : IDisposable // TypeDefIndex: 56906
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
		public ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease, bool collectionCheck = true /* Metadata: 0x023493C0 */);
	
		// Methods
		public T Get();
		public PooledObject Get(out ref T v);
		public void Release(T element);
	}

	public static class GenericPool<T> // TypeDefIndex: 56908
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

	public static class UnsafeGenericPool<T> // TypeDefIndex: 56909
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

	public static class ListPool<T> // TypeDefIndex: 56911
	{
		// Fields
		private static readonly ObjectPool<List<T>> s_Pool;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56910
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

	public static class HashSetPool<T> // TypeDefIndex: 56913
	{
		// Fields
		private static readonly ObjectPool<HashSet<T>> s_Pool;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56912
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

	public static class DictionaryPool<TKey, TValue> // TypeDefIndex: 56915
	{
		// Fields
		private static readonly ObjectPool<Dictionary<TKey, TValue>> s_Pool;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56914
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

	public sealed class ListChangedEventArgs<T> : EventArgs // TypeDefIndex: 56916
	{
		// Fields
		public readonly int index;
		public readonly T item;
	
		// Constructors
		public ListChangedEventArgs(int index, T item);
	}

	public delegate void ListChangedEventHandler<T>(ObservableList<T> sender, ListChangedEventArgs<T> e); // TypeDefIndex: 56917; 0x00000000-0x00000000

	public class ObservableList<T> : IList<T> // TypeDefIndex: 56918
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
	public class SerializableEnum // TypeDefIndex: 56919
	{
		// Fields
		[SerializeField]
		private string m_EnumValueAsString; // 0x10
		[SerializeField]
		private System.Type m_EnumType; // 0x18
	
		// Properties
		public Enum value { get; set; } // 0x000000018B2C6484-0x000000018B2C6530 0x000000018B2C6530-0x000000018B2C6560
	
		// Constructors
		public SerializableEnum(System.Type enumType); // 0x000000018B2C6400-0x000000018B2C6484
	}

	[Serializable]
	public class SerializedDictionary<K, V> : SerializedDictionary<K, V, K, V> // TypeDefIndex: 56920
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
	public abstract class SerializedDictionary<K, V, SK, SV> : Dictionary<K, V>, ISerializationCallbackReceiver // TypeDefIndex: 56921
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
	public class XRGraphics // TypeDefIndex: 56923
	{
		// Properties
		public static float eyeTextureResolutionScale { get; set; } // 0x000000018B2C8140-0x000000018B2C816C 0x000000018B2C8298-0x000000018B2C82A0
		public static float renderViewportScale { get; } // 0x000000018B2C81F8-0x000000018B2C8224 
		public static bool enabled { get; } // 0x000000018B2C80A8-0x000000018B2C80B0 
		public static bool isDeviceActive { get; } // 0x000000018B2C8190-0x000000018B2C81B4 
		public static string loadedDeviceName { get; } // 0x000000018B2C81B4-0x000000018B2C81F8 
		public static string[] supportedDevices { get; } // 0x000000018B2C824C-0x000000018B2C8298 
		public static StereoRenderingMode stereoRenderingMode { get; } // 0x000000018B2C8224-0x000000018B2C824C 
		public static RenderTextureDescriptor eyeTextureDesc { get; } // 0x000000018B2C80B0-0x000000018B2C811C 
		public static int eyeTextureWidth { get; } // 0x000000018B2C816C-0x000000018B2C8190 
		public static int eyeTextureHeight { get; } // 0x000000018B2C811C-0x000000018B2C8140 
	
		// Nested types
		public enum StereoRenderingMode // TypeDefIndex: 56922
		{
			MultiPass = 0,
			SinglePass = 1,
			SinglePassInstanced = 2,
			SinglePassMultiView = 3
		}
	
		// Constructors
		public XRGraphics(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal enum DebugAction // TypeDefIndex: 56924
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

	internal enum DebugActionRepeatMode // TypeDefIndex: 56925
	{
		Never = 0,
		Delay = 1
	}

	public sealed class DebugManager // TypeDefIndex: 56927
	{
		// Fields
		private const string kEnableDebugBtn1 = "Enable Debug Button 1"; // Metadata: 0x023493D4
		private const string kEnableDebugBtn2 = "Enable Debug Button 2"; // Metadata: 0x023493EA
		private const string kDebugPreviousBtn = "Debug Previous"; // Metadata: 0x02349400
		private const string kDebugNextBtn = "Debug Next"; // Metadata: 0x0234940F
		private const string kValidateBtn = "Debug Validate"; // Metadata: 0x0234941A
		private const string kPersistentBtn = "Debug Persistent"; // Metadata: 0x02349429
		private const string kDPadVertical = "Debug Vertical"; // Metadata: 0x0234943A
		private const string kDPadHorizontal = "Debug Horizontal"; // Metadata: 0x02349449
		private const string kMultiplierBtn = "Debug Multiplier"; // Metadata: 0x0234945A
		private const string kResetBtn = "Debug Reset"; // Metadata: 0x0234946B
		private const string kEnableDebug = "Enable Debug"; // Metadata: 0x02349477
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
		public static DebugManager instance { get; } // 0x0000000183948C00-0x0000000183948C50 
		public ReadOnlyCollection<DebugUI.Panel> panels { get; } // 0x000000018B2BC27C-0x000000018B2BC2A4 
		public bool displayEditorUI { get; } // 0x0000000184D8D1F0-0x0000000184D8D200 
		public bool enableRuntimeUI { get; set; } // 0x0000000184D8FEE0-0x0000000184D8FEF0 0x0000000183948CD0-0x0000000183948D00
		public bool displayRuntimeUI { get; set; } // 0x0000000183948C50-0x0000000183948CD0 0x0000000184A438B0-0x0000000184A439B0
		public bool displayPersistentRuntimeUI { get; set; } // 0x000000018B2BC20C-0x000000018B2BC27C 0x0000000184D230A0-0x0000000184D23120
	
		// Events
		public event Action<bool> onDisplayRuntimeUIChanged {
			add; // 0x000000018B2BC058-0x000000018B2BC0E4
			remove; // 0x000000018B2BC2A4-0x000000018B2BC330
		}
		public event Action onSetDirty {
			add; // 0x000000018B2BC0E4-0x000000018B2BC178
			remove; // 0x000000018B2BC330-0x000000018B2BC3C4
		}
		private event Action resetData {
			add; // 0x000000018B2BC178-0x000000018B2BC20C
			remove; // 0x000000018B2BC3C4-0x000000018B2BC458
		}
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56926
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<bool> __9__61_0; // 0x08
			public static Action __9__61_1; // 0x10
	
			// Constructors
			static __c(); // 0x0000000184D41B90-0x0000000184D41BF0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _.ctor_b__61_0(bool _p0_); // 0x00000001841E1670-0x00000001841E1680
			internal void _.ctor_b__61_1(); // 0x00000001841E1670-0x00000001841E1680
			internal DebugManager _.cctor_b__81_0(); // 0x000000018484F270-0x000000018484F2C0
		}
	
		// Constructors
		private DebugManager(); // 0x000000018484F2C0-0x000000018484F540
		static DebugManager(); // 0x0000000184B7D6F0-0x0000000184B7D800
	
		// Methods
		private void RegisterActions(); // 0x000000018B2BABE0-0x000000018B2BB020
		internal void EnableInputActions(); // 0x000000018B2B9EE8-0x000000018B2B9FF4
		private void AddAction(DebugAction action, DebugActionDesc desc); // 0x000000018B2B9DF8-0x000000018B2B9EC8
		private void SampleAction(int actionIndex); // 0x000000018B2BBCD0-0x000000018B2BBDE8
		private void UpdateAction(int actionIndex); // 0x000000018B2BBF40-0x000000018B2BBF98
		internal void UpdateActions(); // 0x000000018B2BBF98-0x000000018B2BBFE4
		internal float GetAction(DebugAction action); // 0x000000018B2BA454-0x000000018B2BA48C
		internal bool GetActionToggleDebugMenuWithTouch(); // 0x000000018B2BA290-0x000000018B2BA454
		internal bool GetActionReleaseScrollTarget(); // 0x000000018B2BA1C4-0x000000018B2BA290
		private void RegisterInputs(); // 0x000000018B2BB050-0x000000018B2BB9D4
		private void UpdateReadOnlyCollection(); // 0x000000018B2BBFE4-0x000000018B2BC058
		public void ToggleEditorUI(bool open); // 0x0000000184D8D200-0x0000000184D8D210
		public void RefreshEditor(); // 0x0000000184DA9DE0-0x0000000184DA9DF0
		public void Reset(); // 0x000000018B2BBCA8-0x000000018B2BBCD0
		public void ReDrawOnScreenDebug(); // 0x000000018B2BABB4-0x000000018B2BABE0
		public void RegisterData(IDebugData data); // 0x000000018B2BB020-0x000000018B2BB050
		public void UnregisterData(IDebugData data); // 0x000000018B2BBF10-0x000000018B2BBF40
		public int GetState(); // 0x000000018B2BAA60-0x000000018B2BAB98
		internal void RegisterRootCanvas(DebugUIHandlerCanvas root); // 0x000000018B2BB9D4-0x000000018B2BBA20
		internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext); // 0x000000018B2B9EC8-0x000000018B2B9EE8
		internal void SetScrollTarget(DebugUIHandlerWidget widget); // 0x000000018B2BBDE8-0x000000018B2BBE64
		private void EnsurePersistentCanvas(); // 0x000000018B2B9FF4-0x000000018B2BA1C4
		internal void TogglePersistent(DebugUI.Widget widget); // 0x000000018B2BBE64-0x000000018B2BBF10
		private void OnPanelDirty(DebugUI.Panel panel); // 0x000000018B2BAB98-0x000000018B2BABB4
		public void RequestEditorWindowPanelIndex(int index); // 0x000000018B2BBC54-0x000000018B2BBCA8
		internal int? GetRequestedEditorWindowPanelIndex(); // 0x0000000184DB8CE0-0x0000000184DB8CF0
		public DebugUI.Panel GetPanel(string displayName, bool createIfNull = false /* Metadata: 0x023493D1 */, int groupIndex = 0 /* Metadata: 0x023493D2 */, bool overrideIfExist = false /* Metadata: 0x023493D3 */); // 0x000000018B2BA770-0x000000018B2BAA60
		public void RemovePanel(string displayName); // 0x000000018B2BBA20-0x000000018B2BBBF0
		public void RemovePanel(DebugUI.Panel panel); // 0x000000018B2BBBF0-0x000000018B2BBC54
		public DebugUI.Widget GetItem(string queryPath); // 0x000000018B2BA644-0x000000018B2BA770
		private DebugUI.Widget GetItem(string queryPath, DebugUI.IContainer container); // 0x000000018B2BA48C-0x000000018B2BA644
	}

	internal class DebugActionDesc // TypeDefIndex: 56928
	{
		// Fields
		public InputAction buttonAction; // 0x10
		public DebugActionRepeatMode repeatMode; // 0x18
		public float repeatDelay; // 0x1C
	
		// Constructors
		public DebugActionDesc(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal class DebugActionState // TypeDefIndex: 56930
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
		internal bool runningAction { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D869F0-0x0000000184D86A00 0x0000000184D86A00-0x0000000184D86A10
		internal float actionState { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86E20-0x0000000184D86E30 0x0000000184D86E30-0x0000000184D86E40
	
		// Nested types
		private enum DebugActionKeyType // TypeDefIndex: 56929
		{
			Button = 0,
			Axis = 1,
			Key = 2
		}
	
		// Constructors
		public DebugActionState(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private void Trigger(int triggerCount, float state); // 0x000000018B2B9BDC-0x000000018B2B9C78
		public void TriggerWithButton(InputAction action, float state); // 0x000000018B2B9B58-0x000000018B2B9BDC
		private void Reset(); // 0x000000018B2B9B40-0x000000018B2B9B58
		public void Update(DebugActionDesc desc); // 0x000000018B2B9C78-0x000000018B2B9DF8
	}

	public interface IDebugData // TypeDefIndex: 56931
	{
		// Methods
		Action GetReset();
	}

	public class DebugShapes // TypeDefIndex: 56932
	{
		// Fields
		private static DebugShapes s_Instance; // 0x00
		private Mesh m_sphereMesh; // 0x10
		private Mesh m_boxMesh; // 0x18
		private Mesh m_coneMesh; // 0x20
		private Mesh m_pyramidMesh; // 0x28
	
		// Properties
		public static DebugShapes instance { get; } // 0x000000018B2BE910-0x000000018B2BE994 
	
		// Constructors
		public DebugShapes(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private void BuildSphere(ref Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv); // 0x000000018B2BE17C-0x000000018B2BE7DC
		private void BuildBox(ref Mesh outputMesh, float length, float width, float height); // 0x000000018B2BC458-0x000000018B2BD098
		private void BuildCone(ref Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides); // 0x000000018B2BD098-0x000000018B2BDAE0
		private void BuildPyramid(ref Mesh outputMesh, float width, float height, float depth); // 0x000000018B2BDAE0-0x000000018B2BDFF0
		private void BuildShapes(); // 0x000000018B2BDFF0-0x000000018B2BE17C
		private void RebuildResources(); // 0x000000018B2BE7DC-0x000000018B2BE8A0
		public Mesh RequestSphereMesh(); // 0x000000018B2BE8F4-0x000000018B2BE910
		public Mesh RequestBoxMesh(); // 0x000000018B2BE8A0-0x000000018B2BE8BC
		public Mesh RequestConeMesh(); // 0x000000018B2BE8BC-0x000000018B2BE8D8
		public Mesh RequestPyramidMesh(); // 0x000000018B2BE8D8-0x000000018B2BE8F4
	}

	public class DebugUI // TypeDefIndex: 56967
	{
		// Nested types
		public class Container : Widget, IContainer // TypeDefIndex: 56933
		{
			// Fields
			[CompilerGenerated]
			private ObservableList<Widget> _children_k__BackingField; // 0x48
	
			// Properties
			public ObservableList<Widget> children { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
			public override Panel panel { get; internal set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x000000018B2B8EBC-0x000000018B2B8FF8
	
			// Constructors
			public Container(); // 0x000000018B2B8C48-0x000000018B2B8DB0
			public Container(string displayName, ObservableList<Widget> children); // 0x000000018B2B8DB0-0x000000018B2B8EBC
	
			// Methods
			internal override void GenerateQueryPath(); // 0x000000018B2B88F4-0x000000018B2B8A1C
			protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e); // 0x000000018B2B8B80-0x000000018B2B8BE4
			protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e); // 0x000000018B2B8BE4-0x000000018B2B8C48
			public override int GetHashCode(); // 0x000000018B2B8A1C-0x000000018B2B8B80
		}
	
		public class Foldout : Container, IValueField // TypeDefIndex: 56935
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
			public bool isReadOnly { get; } // 0x00000001812081B0-0x0000000181208610 
			public string[] columnLabels { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
			public string[] columnTooltips { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
	
			// Nested types
			public struct ContextMenuItem // TypeDefIndex: 56934
			{
				// Fields
				public string displayName; // 0x00
				public Action action; // 0x08
			}
	
			// Constructors
			public Foldout(); // 0x000000018B2C0290-0x000000018B2C0298
			public Foldout(string displayName, ObservableList<Widget> children, string[] columnLabels = null, string[] columnTooltips = null); // 0x000000018B2C0298-0x000000018B2C02DC
	
			// Methods
			public bool GetValue(); // 0x0000000184D86800-0x0000000184D86810
			object UnityEngine.Rendering.DebugUI.IValueField.GetValue(); // 0x000000018B2C024C-0x000000018B2C0290
			public void SetValue(object value); // 0x000000018B2C0200-0x000000018B2C024C
			public object ValidateValue(object value); // 0x0000000184D88C30-0x0000000184D88C40
			public void SetValue(bool value); // 0x0000000184D86840-0x0000000184D86850
		}
	
		public class HBox : Container // TypeDefIndex: 56936
		{
			// Constructors
			public HBox(); // 0x000000018B2C118C-0x000000018B2C11D4
		}
	
		public class VBox : Container // TypeDefIndex: 56937
		{
			// Constructors
			public VBox(); // 0x000000018B2C7EA0-0x000000018B2C7EE8
		}
	
		public class Table : Container // TypeDefIndex: 56939
		{
			// Fields
			public bool isReadOnly; // 0x50
			private bool[] m_Header; // 0x58
	
			// Properties
			public bool[] VisibleColumns { get; } // 0x000000018B2C683C-0x000000018B2C6A4C 
	
			// Nested types
			public class Row : Foldout // TypeDefIndex: 56938
			{
				// Constructors
				public Row(); // 0x000000018B2C63B8-0x000000018B2C6400
			}
	
			// Constructors
			public Table(); // 0x000000018B2C67F4-0x000000018B2C683C
	
			// Methods
			public void SetColumnVisibility(int index, bool visible); // 0x000000018B2C67B0-0x000000018B2C67F4
			public bool GetColumnVisibility(int index); // 0x000000018B2C6720-0x000000018B2C6760
			protected override void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e); // 0x000000018B2C6760-0x000000018B2C6788
			protected override void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e); // 0x000000018B2C6788-0x000000018B2C67B0
		}
	
		[Flags]
		public enum Flags // TypeDefIndex: 56940
		{
			None = 0,
			EditorOnly = 2,
			RuntimeOnly = 4,
			EditorForceUpdate = 8
		}
	
		public abstract class Widget // TypeDefIndex: 56942
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
			public virtual Panel panel { get; internal set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
			public virtual IContainer parent { get; internal set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
			public Flags flags { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
			public string displayName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
			public string tooltip { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
			public string queryPath { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
			public bool isEditorOnly { get; } // 0x000000018B2C802C-0x000000018B2C8034 
			public bool isRuntimeOnly { get; } // 0x000000018B2C8070-0x000000018B2C807C 
			public bool isInactiveInEditor { get; } // 0x000000018B2C8054-0x000000018B2C8070 
			public bool isHidden { get; } // 0x000000018B2C8034-0x000000018B2C8054 
			public NameAndTooltip nameAndTooltip { set; } // 0x000000018B2C807C-0x000000018B2C80A8
	
			// Nested types
			public struct NameAndTooltip // TypeDefIndex: 56941
			{
				// Fields
				public string name; // 0x00
				public string tooltip; // 0x08
			}
	
			// Constructors
			protected Widget(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal virtual void GenerateQueryPath(); // 0x000000018B2C7F50-0x000000018B2C8008
			public override int GetHashCode(); // 0x000000018B2C8008-0x000000018B2C802C
		}
	
		public interface IContainer // TypeDefIndex: 56943
		{
			// Properties
			ObservableList<Widget> children { get; }
			string displayName { get; set; }
			string queryPath { get; }
		}
	
		public interface IValueField // TypeDefIndex: 56944
		{
			// Methods
			object GetValue();
			void SetValue(object value);
			object ValidateValue(object value);
		}
	
		public class Button : Widget // TypeDefIndex: 56945
		{
			// Fields
			[CompilerGenerated]
			private Action _action_k__BackingField; // 0x48
	
			// Properties
			public Action action { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
	
			// Constructors
			public Button(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class Value : Widget // TypeDefIndex: 56946
		{
			// Fields
			[CompilerGenerated]
			private Func<object> _getter_k__BackingField; // 0x48
			public float refreshRate; // 0x50
	
			// Properties
			public Func<object> getter { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
	
			// Constructors
			public Value(); // 0x000000018B2C7F08-0x000000018B2C7F50
	
			// Methods
			public object GetValue(); // 0x000000018B2C7EE8-0x000000018B2C7F08
		}
	
		public abstract class Field<T> : Widget, IValueField // TypeDefIndex: 56947
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
	
		public class BoolField : Field<bool> // TypeDefIndex: 56948
		{
			// Constructors
			public BoolField(); // 0x000000018B2B6F64-0x000000018B2B6F8C
		}
	
		public class HistoryBoolField : BoolField // TypeDefIndex: 56949
		{
			// Fields
			[CompilerGenerated]
			private Func<bool>[] _historyGetter_k__BackingField; // 0x60
	
			// Properties
			public Func<bool>[] historyGetter { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
			public int historyDepth { get; } // 0x000000018B2C1214-0x000000018B2C1224 
	
			// Constructors
			public HistoryBoolField(); // 0x000000018B2C120C-0x000000018B2C1214
	
			// Methods
			public bool GetHistoryValue(int historyIndex); // 0x000000018B2C11D4-0x000000018B2C120C
		}
	
		public class IntField : Field<int> // TypeDefIndex: 56950
		{
			// Fields
			public Func<int> min; // 0x60
			public Func<int> max; // 0x68
			public int incStep; // 0x70
			public int intStepMult; // 0x74
	
			// Constructors
			public IntField(); // 0x000000018B2C1330-0x000000018B2C137C
	
			// Methods
			public override int ValidateValue(int value); // 0x000000018B2C12E0-0x000000018B2C1330
		}
	
		public class UIntField : Field<uint> // TypeDefIndex: 56951
		{
			// Fields
			public Func<uint> min; // 0x60
			public Func<uint> max; // 0x68
			public uint incStep; // 0x70
			public uint intStepMult; // 0x74
	
			// Constructors
			public UIntField(); // 0x000000018B2C7E54-0x000000018B2C7EA0
	
			// Methods
			public override uint ValidateValue(uint value); // 0x000000018B2C7E04-0x000000018B2C7E54
		}
	
		public class FloatField : Field<float> // TypeDefIndex: 56952
		{
			// Fields
			public Func<float> min; // 0x60
			public Func<float> max; // 0x68
			public float incStep; // 0x70
			public float incStepMult; // 0x74
			public int decimals; // 0x78
	
			// Constructors
			public FloatField(); // 0x000000018B2C01C0-0x000000018B2C0200
	
			// Methods
			public override float ValidateValue(float value); // 0x000000018B2C0174-0x000000018B2C01C0
		}
	
		private static class EnumUtility // TypeDefIndex: 56954
		{
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 56953
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<System.Reflection.FieldInfo, GUIContent> __9__0_0; // 0x08
	
				// Constructors
				static __c(); // 0x000000018B2C7D3C-0x000000018B2C7DA0
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal GUIContent _MakeEnumNames_b__0_0(System.Reflection.FieldInfo fieldInfo); // 0x000000018B2C7B68-0x000000018B2C7CD8
			}
	
			// Methods
			internal static GUIContent[] MakeEnumNames(System.Type enumType); // 0x000000018B2BFDF8-0x000000018B2BFF34
			internal static int[] MakeEnumValues(System.Type enumType); // 0x000000018B2BFF34-0x000000018B2C0018
		}
	
		public class EnumField : Field<int> // TypeDefIndex: 56956
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
			public Func<int> getIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86260-0x0000000184D86270 0x0000000184CD9970-0x0000000184CD9980
			public Action<int> setIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D861F0-0x0000000184D86200 0x0000000185395D30-0x0000000185395D44
			public int currentIndex { get; set; } // 0x000000018B2BFD54-0x000000018B2BFD78 0x000000018B2BFDD4-0x000000018B2BFDF8
			public System.Type autoEnum { set; } // 0x000000018B2BFD78-0x000000018B2BFDD4
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 56955
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<GUIContent, string> __9__17_0; // 0x08
	
				// Constructors
				static __c(); // 0x000000018B2C7DA0-0x000000018B2C7E04
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal string _InitQuickSeparators_b__17_0(GUIContent x); // 0x000000018B2C7AF4-0x000000018B2C7B68
			}
	
			// Constructors
			public EnumField(); // 0x000000018B2BFD2C-0x000000018B2BFD54
	
			// Methods
			internal void InitQuickSeparators(); // 0x000000018B2BFB18-0x000000018B2BFD2C
			internal void InitIndexes(); // 0x000000018B2BFA60-0x000000018B2BFB18
		}
	
		public class HistoryEnumField : EnumField // TypeDefIndex: 56957
		{
			// Fields
			[CompilerGenerated]
			private Func<int>[] _historyIndexGetter_k__BackingField; // 0x90
	
			// Properties
			public Func<int>[] historyIndexGetter { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86220-0x0000000184D86230 0x0000000186402330-0x0000000186402344
			public int historyDepth { get; } // 0x000000018B2C1268-0x000000018B2C127C 
	
			// Constructors
			public HistoryEnumField(); // 0x000000018B2C1260-0x000000018B2C1268
	
			// Methods
			public int GetHistoryValue(int historyIndex); // 0x000000018B2C1224-0x000000018B2C1260
		}
	
		public class BitField : Field<Enum> // TypeDefIndex: 56958
		{
			// Fields
			[CompilerGenerated]
			private GUIContent[] _enumNames_k__BackingField; // 0x60
			[CompilerGenerated]
			private int[] _enumValues_k__BackingField; // 0x68
			private System.Type m_EnumType; // 0x70
	
			// Properties
			public GUIContent[] enumNames { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
			public int[] enumValues { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
			public System.Type enumType { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x000000018B2B6F0C-0x000000018B2B6F64
	
			// Constructors
			public BitField(); // 0x000000018B2B6EE4-0x000000018B2B6F0C
		}
	
		public class ColorField : Field<UnityEngine.Color> // TypeDefIndex: 56959
		{
			// Fields
			public bool hdr; // 0x60
			public bool showAlpha; // 0x61
			public bool showPicker; // 0x62
			public float incStep; // 0x64
			public float incStepMult; // 0x68
			public int decimals; // 0x6C
	
			// Constructors
			public ColorField(); // 0x000000018B2B78CC-0x000000018B2B7914
	
			// Methods
			public override UnityEngine.Color ValidateValue(UnityEngine.Color value); // 0x000000018B2B7870-0x000000018B2B78CC
		}
	
		public class Vector2Field : Field<Vector2> // TypeDefIndex: 56960
		{
			// Fields
			public float incStep; // 0x60
			public float incStepMult; // 0x64
			public int decimals; // 0x68
	
			// Constructors
			public Vector2Field(); // 0x000000018B2D8D40-0x000000018B2D8D80
		}
	
		public class Vector3Field : Field<Vector3> // TypeDefIndex: 56961
		{
			// Fields
			public float incStep; // 0x60
			public float incStepMult; // 0x64
			public int decimals; // 0x68
	
			// Constructors
			public Vector3Field(); // 0x000000018B2D8D80-0x000000018B2D8DC0
		}
	
		public class Vector4Field : Field<Vector4> // TypeDefIndex: 56962
		{
			// Fields
			public float incStep; // 0x60
			public float incStepMult; // 0x64
			public int decimals; // 0x68
	
			// Constructors
			public Vector4Field(); // 0x000000018B2D8DC0-0x000000018B2D8E00
		}
	
		public class MessageBox : Widget // TypeDefIndex: 56964
		{
			// Fields
			public Style style; // 0x48
	
			// Nested types
			public enum Style // TypeDefIndex: 56963
			{
				Info = 0,
				Warning = 1,
				Error = 2
			}
	
			// Constructors
			public MessageBox(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class Panel : IContainer, IComparable<Panel> // TypeDefIndex: 56966
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
			public Flags flags { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
			public string displayName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
			public int groupIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
			public string queryPath { get; } // 0x000000018385B100-0x000000018385B110 
			public bool isEditorOnly { get; } // 0x0000000182F2E070-0x0000000182F2E080 
			public bool isRuntimeOnly { get; } // 0x000000018B2D1C94-0x000000018B2D1C9C 
			public bool isInactiveInEditor { get; } // 0x000000018B2D1C78-0x000000018B2D1C94 
			public bool editorForceUpdate { get; } // 0x000000018B2D1C70-0x000000018B2D1C78 
			public ObservableList<Widget> children { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
	
			// Events
			public event Action<Panel> onSetDirty {
				add; // 0x000000018B2D1BE4-0x000000018B2D1C70
				remove; // 0x000000018B2D1C9C-0x000000018B2D1D28
			}
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 56965
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Action<Panel> __9__29_0; // 0x08
	
				// Constructors
				static __c(); // 0x000000018B2D8C78-0x000000018B2D8CDC
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal void _.ctor_b__29_0(Panel _p0_); // 0x00000001841E1670-0x00000001841E1680
			}
	
			// Constructors
			public Panel(); // 0x000000018B2D19D4-0x000000018B2D1BE4
	
			// Methods
			protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e); // 0x000000018B2D17A0-0x000000018B2D17F8
			protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e); // 0x000000018B2D17F8-0x000000018B2D1854
			public void SetDirty(); // 0x000000018B2D1854-0x000000018B2D19A8
			public override int GetHashCode(); // 0x000000018B2D163C-0x000000018B2D17A0
			int System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(Panel other); // 0x000000018B2D19A8-0x000000018B2D19D4
		}
	
		// Constructors
		public DebugUI(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal class DebugUpdater : MonoBehaviour // TypeDefIndex: 56970
	{
		// Fields
		private static DebugUpdater s_Instance; // 0x00
		private ScreenOrientation m_Orientation; // 0x18
		private bool m_RuntimeUiWasVisibleLastFrame; // 0x1C
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DoAfterInputModuleUpdated_d__9 : IEnumerator<object> // TypeDefIndex: 56968
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Action action; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _DoAfterInputModuleUpdated_d__9(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B2D8A10-0x000000018B2D8AC0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B2D8AC0-0x000000018B2D8B0C
		}
	
		[CompilerGenerated]
		private sealed class _RefreshRuntimeUINextFrame_d__15 : IEnumerator<object> // TypeDefIndex: 56969
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _RefreshRuntimeUINextFrame_d__15(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B2D8B0C-0x000000018B2D8B90
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B2D8B90-0x000000018B2D8BDC
		}
	
		// Constructors
		public DebugUpdater(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void RuntimeInit(); // 0x00000001841E1670-0x00000001841E1680
		internal static void SetEnabled(bool enabled); // 0x0000000183949B80-0x0000000183949BA0
		private static void EnableRuntime(); // 0x000000018B2CAAB0-0x000000018B2CAC1C
		private static void DisableRuntime(); // 0x00000001839499F0-0x0000000183949AF0
		internal static void HandleInternalEventSystemComponents(bool uiEnabled); // 0x0000000184A439B0-0x0000000184A43A50
		private void EnsureExactlyOneEventSystem(); // 0x000000018B2CAC1C-0x000000018B2CADA8
		[IteratorStateMachine(typeof(_DoAfterInputModuleUpdated_d__9))]
		private IEnumerator DoAfterInputModuleUpdated(Action action); // 0x000000018B2CAA54-0x000000018B2CAAB0
		private void CheckInputModuleExists(); // 0x000000018B2CA76C-0x000000018B2CA844
		private void AssignDefaultActions(); // 0x000000018B2CA64C-0x000000018B2CA76C
		private void CreateDebugEventSystem(); // 0x000000018B2CA844-0x000000018B2CA924
		private void DestroyDebugEventSystem(); // 0x000000018B2CA924-0x000000018B2CAA54
		private void Update(); // 0x000000018B2CADEC-0x000000018B2CAF40
		[IteratorStateMachine(typeof(_RefreshRuntimeUINextFrame_d__15))]
		private static IEnumerator RefreshRuntimeUINextFrame(); // 0x000000018B2CADA8-0x000000018B2CADEC
	}

	public class MousePositionDebug // TypeDefIndex: 56971
	{
		// Fields
		private static MousePositionDebug s_Instance; // 0x00
	
		// Properties
		public static MousePositionDebug instance { get; } // 0x0000000183945840-0x00000001839458D0 
	
		// Constructors
		public MousePositionDebug(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Build(); // 0x00000001841E1670-0x00000001841E1680
		public void Cleanup(); // 0x00000001841E1670-0x00000001841E1680
		public Vector2 GetMousePosition(float ScreenHeight, bool sceneView); // 0x000000018B2D1430-0x000000018B2D1438
		private Vector2 GetInputMousePosition(); // 0x000000018B2D13C0-0x000000018B2D1430
		public Vector2 GetMouseClickPosition(float ScreenHeight); // 0x0000000184DBB8D0-0x0000000184DBB8E0
	}

	internal class TProfilingSampler<TEnum> : ProfilingSampler // TypeDefIndex: 56972
		where TEnum : Enum
	{
		// Fields
		internal static Dictionary<TEnum, TProfilingSampler<TEnum>> samples;
	
		// Constructors
		static TProfilingSampler();
		public TProfilingSampler(string name);
	}

	public class ProfilingSampler // TypeDefIndex: 56973
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
		internal CustomSampler sampler { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		internal CustomSampler inlineSampler { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public string name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public bool enableRecording { set; } // 0x000000018B2D355C-0x000000018B2D35A0
		public float gpuElapsedTime { get; } // 0x000000018B2D343C-0x000000018B2D348C 
		public int gpuSampleCount { get; } // 0x000000018B2D348C-0x000000018B2D34CC 
		public float cpuElapsedTime { get; } // 0x000000018B2D33AC-0x000000018B2D33FC 
		public int cpuSampleCount { get; } // 0x000000018B2D33FC-0x000000018B2D343C 
		public float inlineCpuElapsedTime { get; } // 0x000000018B2D34CC-0x000000018B2D351C 
		public int inlineCpuSampleCount { get; } // 0x000000018B2D351C-0x000000018B2D355C 
	
		// Constructors
		public ProfilingSampler(string name); // 0x0000000183B945E0-0x0000000183B946E0
		private ProfilingSampler(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static ProfilingSampler Get<TEnum>(TEnum marker)
			where TEnum : Enum;
		public void Begin(CommandBuffer cmd); // 0x000000018B2D3324-0x000000018B2D3368
		public void End(CommandBuffer cmd); // 0x000000018B2D3368-0x000000018B2D33AC
		internal bool IsValid(); // 0x000000018AB8BD08-0x000000018AB8BD1C
	}

	public struct ProfilingScope : IDisposable // TypeDefIndex: 56974
	{
		// Constructors
		public ProfilingScope(CommandBuffer cmd, ProfilingSampler sampler); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Obsolete("Please use ProfilingScope")]
	public struct ProfilingSample : IDisposable // TypeDefIndex: 56975
	{
		// Fields
		private readonly CommandBuffer m_Cmd; // 0x00
		private readonly string m_Name; // 0x08
		private bool m_Disposed; // 0x10
		private CustomSampler m_Sampler; // 0x18
	
		// Constructors
		public ProfilingSample(CommandBuffer cmd, string name, CustomSampler sampler = null); // 0x000000018B2D31F0-0x000000018B2D3294
		public ProfilingSample(CommandBuffer cmd, string format, object arg); // 0x000000018B2D3294-0x000000018B2D32DC
		public ProfilingSample(CommandBuffer cmd, string format, params object[] args); // 0x000000018B2D32DC-0x000000018B2D3324
	
		// Methods
		public void Dispose(); // 0x000000018B2D31E4-0x000000018B2D31F0
		private void Dispose(bool disposing); // 0x000000018B2D3164-0x000000018B2D31E4
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, AllowMultiple = false)]
	[Conditional("UNITY_EDITOR")]
	public class CoreRPHelpURLAttribute : HelpURLAttribute // TypeDefIndex: 56976
	{
		// Constructors
		public CoreRPHelpURLAttribute(string pageName, string packageName = "com.unity.render-pipelines.core" /* Metadata: 0x0234948E */); // 0x000000018B2CA620-0x000000018B2CA64C
	}

	public class DocumentationInfo // TypeDefIndex: 56977
	{
		// Fields
		private const string fallbackVersion = "12.1"; // Metadata: 0x023494AE
		private const string url = "https://docs.unity3d.com/Packages/{0}@{1}/manual/{2}.html"; // Metadata: 0x023494B3
	
		// Properties
		public static string version { get; } // 0x000000018B2CAF9C-0x000000018B2CAFC8 
	
		// Constructors
		public DocumentationInfo(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static string GetPageLink(string packageName, string pageName); // 0x000000018B2CAF40-0x000000018B2CAF9C
	}

	public static class DocumentationUtils // TypeDefIndex: 56978
	{
		// Methods
		public static string GetHelpURL<TEnum>(TEnum mask = default)
			where TEnum : struct, IConvertible;
	}

	public enum APVConstantBufferRegister // TypeDefIndex: 56979
	{
		GlobalRegister = 5
	}

	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "G:\\Build\\Release_v1d4\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\Lighting\\ProbeVolume\\ShaderVariablesProbeVolumes.cs", needAccessors = false, generateCBuffer = true, constantRegister = 5)]
	internal struct ShaderVariablesProbeVolumes // TypeDefIndex: 56980
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
	public struct SphericalHarmonicsL1 // TypeDefIndex: 56981
	{
		// Fields
		public Vector4 shAr; // 0x00
		public Vector4 shAg; // 0x10
		public Vector4 shAb; // 0x20
		public static readonly SphericalHarmonicsL1 zero; // 0x00
	
		// Constructors
		static SphericalHarmonicsL1(); // 0x000000018B2D4240-0x000000018B2D42A8
	
		// Methods
		public static SphericalHarmonicsL1 operator +(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs); // 0x000000018B2D42A8-0x000000018B2D4360
		public static SphericalHarmonicsL1 operator -(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs); // 0x000000018B2D46AC-0x000000018B2D4764
		public static SphericalHarmonicsL1 operator *(SphericalHarmonicsL1 lhs, float rhs); // 0x000000018B2D4620-0x000000018B2D46AC
		public static SphericalHarmonicsL1 operator /(SphericalHarmonicsL1 lhs, float rhs); // 0x000000018B2D4360-0x000000018B2D4448
		public static bool operator ==(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs); // 0x000000018B2D4448-0x000000018B2D458C
		public static bool operator !=(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs); // 0x000000018B2D458C-0x000000018B2D4620
		public override bool Equals(object other); // 0x000000018B2D410C-0x000000018B2D41F0
		public override int GetHashCode(); // 0x000000018B2D41F0-0x000000018B2D4240
	}

	public class SphericalHarmonicsL2Utils // TypeDefIndex: 56982
	{
		// Constructors
		public SphericalHarmonicsL2Utils(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void GetL1(SphericalHarmonicsL2 sh, out Vector3 L1_R, out Vector3 L1_G, out Vector3 L1_B); // 0x000000018B2D47E8-0x000000018B2D490C
		public static void GetL2(SphericalHarmonicsL2 sh, out Vector3 L2_0, out Vector3 L2_1, out Vector3 L2_2, out Vector3 L2_3, out Vector3 L2_4); // 0x000000018B2D490C-0x000000018B2D4AD8
		public static void SetL0(ref SphericalHarmonicsL2 sh, Vector3 L0); // 0x000000018B2D4B4C-0x000000018B2D4BB0
		public static void SetL1R(ref SphericalHarmonicsL2 sh, Vector3 L1_R); // 0x000000018B2D4C88-0x000000018B2D4CEC
		public static void SetL1G(ref SphericalHarmonicsL2 sh, Vector3 L1_G); // 0x000000018B2D4C1C-0x000000018B2D4C88
		public static void SetL1B(ref SphericalHarmonicsL2 sh, Vector3 L1_B); // 0x000000018B2D4BB0-0x000000018B2D4C1C
		public static void SetL1(ref SphericalHarmonicsL2 sh, Vector3 L1_R, Vector3 L1_G, Vector3 L1_B); // 0x000000018B2D4CEC-0x000000018B2D4D74
		public static void SetCoefficient(ref SphericalHarmonicsL2 sh, int index, Vector3 coefficient); // 0x000000018B2D4AD8-0x000000018B2D4B4C
		public static Vector3 GetCoefficient(SphericalHarmonicsL2 sh, int index); // 0x000000018B2D4764-0x000000018B2D47E8
	}

	public sealed class LensFlareCommonSRP // TypeDefIndex: 56988
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
		public static LensFlareCommonSRP Instance { get; } // 0x0000000183AAE370-0x0000000183AAE850 
		private List<LensFlareComponentSRP> Data { get; } // 0x000000018B2D1184-0x000000018B2D11B8 
	
		// Nested types
		public struct SunSourceDirLightOverrideLensFlareData // TypeDefIndex: 56983
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
	
		public struct SunSourceDirLightOverrideLightData // TypeDefIndex: 56984
		{
			// Fields
			public Quaternion rotationLensFlare; // 0x00
			public Vector3 dirLightFoward; // 0x10
			public UnityEngine.Color color; // 0x1C
		}
	
		public struct SunSourceDirLightOverrideInfo // TypeDefIndex: 56985
		{
			// Fields
			public GameObject dirLightGameObject; // 0x00
			public SunSourceDirLightOverrideLensFlareData flareData; // 0x08
			public SunSourceDirLightOverrideLightData lightData; // 0x38
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass35_0 // TypeDefIndex: 56986
		{
			// Fields
			public LensFlareDataElementSRP element; // 0x00
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass35_1 // TypeDefIndex: 56987
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
		private LensFlareCommonSRP(); // 0x00000001841E1670-0x00000001841E1680
		static LensFlareCommonSRP(); // 0x0000000184B1D060-0x0000000184B1D1F0
	
		// Methods
		public static void Initialize(); // 0x000000018B2CFDF8-0x000000018B2CFF8C
		public static void Dispose(); // 0x000000018B2CC848-0x000000018B2CC8E4
		public List<LensFlareComponentSRP> GetData(); // 0x0000000185394AF0-0x0000000185394AF8
		public bool IsEmpty(); // 0x0000000183AAE0F0-0x0000000183AAE160
		public void AddData(LensFlareComponentSRP newData); // 0x000000018B2CB67C-0x000000018B2CB6FC
		public static float ShapeAttenuationPointLight(); // 0x0000000184D88DD0-0x0000000184D88DE0
		public static float ShapeAttenuationDirLight(Vector3 forward, Vector3 wo); // 0x000000018B2D0518-0x000000018B2D055C
		public static float ShapeAttenuationSpotConeLight(Vector3 forward, Vector3 wo, float spotAngle, float innerSpotPercent01); // 0x000000018B2D05A4-0x000000018B2D0698
		public static float ShapeAttenuationSpotBoxLight(Vector3 forward, Vector3 wo); // 0x000000018B2D055C-0x000000018B2D05A4
		public static float ShapeAttenuationSpotPyramidLight(Vector3 forward, Vector3 wo); // 0x000000018B2D0698-0x000000018B2D071C
		public static float ShapeAttenuationAreaTubeLight(Vector3 lightPositionWS, Vector3 lightSide, float lightWidth, Camera cam); // 0x000000018B2D0100-0x000000018B2D0518
		public static float ShapeAttenuationAreaRectangleLight(Vector3 forward, Vector3 wo); // 0x000000018B2D0084-0x000000018B2D0100
		public static float ShapeAttenuationAreaDiscLight(Vector3 forward, Vector3 wo); // 0x000000018B2D0008-0x000000018B2D0084
		public static Vector4 GetFlareData0(Vector2 screenPos, Vector2 translationScale, Vector2 rayOff0, Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, Vector2 positionOffset, bool autoRotate); // 0x000000018B2CFB30-0x000000018B2CFD70
		public static Vector2 GetLensFlareRayOffset(Vector2 screenPos, float position, float globalCos0, float globalSin0); // 0x000000018B2CFD70-0x000000018B2CFDF8
		public static Vector3 WorldToViewport(Camera camera, bool isLocalLight, bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 positionWS); // 0x000000018B2D1048-0x000000018B2D1184
		private static Vector3 WorldToViewportLocal(bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 cameraPosWS, Vector3 positionWS); // 0x000000018B2D0EEC-0x000000018B2D1048
		private static Vector3 WorldToViewportDistance(Camera cam, Vector3 positionWS); // 0x000000018B2D0D60-0x000000018B2D0EEC
		public static void ComputeOcclusion(Material lensFlareShader, LensFlareCommonSRP lensFlares, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4); // 0x000000018B2CB830-0x000000018B2CC848
		public static void DoLensFlareDataDrivenCommon(Material lensFlareShader, LensFlareCommonSRP lensFlares, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, RenderTargetIdentifier colorBuffer, Func<Light, Camera, Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugFullScreen, ComputeBuffer debugFullscreenBuffer, SunSourceDirLightOverrideInfo dirLightOverrideInfo); // 0x000000018B2CC8E4-0x000000018B2CF974
		public void RemoveData(LensFlareComponentSRP data); // 0x0000000183AADF50-0x0000000183AADFF0
		private static Vector2 DoPaniniProjection(Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance); // 0x000000018B2CF974-0x000000018B2CFB30
		private static Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView); // 0x000000018B2CB7E4-0x000000018B2CB830
		private static Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d); // 0x000000018B2CB6FC-0x000000018B2CB7E4
		private static Vector2 Panini_Generic_Inv(Vector2 projPos, float d); // 0x000000018B2CFF8C-0x000000018B2D0008
		[CompilerGenerated]
		internal static float _ShapeAttenuationAreaTubeLight_g__Fpo_26_0(float d, float l); // 0x000000018B2D0CEC-0x000000018B2D0D44
		[CompilerGenerated]
		internal static float _ShapeAttenuationAreaTubeLight_g__Fwt_26_1(float d, float l); // 0x000000018B2D0D44-0x000000018B2D0D60
		[CompilerGenerated]
		internal static float _ShapeAttenuationAreaTubeLight_g__DiffLineIntegral_26_2(Vector3 p1, Vector3 p2); // 0x000000018B2D0910-0x000000018B2D0CEC
		[CompilerGenerated]
		internal static Vector2 _DoLensFlareDataDrivenCommon_g__ComputeLocalSize_35_0(Vector2 rayOff, Vector2 rayOff0, Vector2 curSize, AnimationCurve distortionCurve, ref __c__DisplayClass35_0 param_00079a66, ref __c__DisplayClass35_1 param_00079a67); // 0x000000018B2D071C-0x000000018B2D0910
		[CompilerGenerated]
		internal static float _DoLensFlareDataDrivenCommon_g__RandomRange_35_1(float min, float max); // 0x0000000189BBB1DC-0x0000000189BBB1E4
	}

	[AddComponentMenu("Rendering/Lens Flare (SRP)")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public sealed class LensFlareComponentSRP : MonoBehaviour // TypeDefIndex: 56989
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
		public LensFlareDataSRP lensFlareData { get; set; } // 0x000000018385B100-0x000000018385B110 0x000000018B2D1300-0x000000018B2D1324
	
		// Constructors
		public LensFlareComponentSRP(); // 0x000000018402B7F0-0x000000018402BAB0
		static LensFlareComponentSRP(); // 0x0000000184D7A250-0x0000000184D7A290
	
		// Methods
		public float celestialProjectedOcclusionRadius(Camera mainCam); // 0x000000018B2D1250-0x000000018B2D1300
		private void OnEnable(); // 0x0000000183AADFF0-0x0000000183AAE090
		private void OnDisable(); // 0x0000000183AAE090-0x0000000183AAE0F0
		private void OnValidate(); // 0x000000018B2D11B8-0x000000018B2D1250
	}

	[Serializable]
	public enum SRPLensFlareBlendMode // TypeDefIndex: 56990
	{
		Additive = 0,
		Screen = 1,
		Premultiply = 2,
		Lerp = 3
	}

	[Serializable]
	public enum SRPLensFlareDistribution // TypeDefIndex: 56991
	{
		Uniform = 0,
		Curve = 1,
		Random = 2
	}

	[Serializable]
	public enum SRPLensFlareType // TypeDefIndex: 56992
	{
		Image = 0,
		Circle = 1,
		Polygon = 2
	}

	[Serializable]
	public sealed class LensFlareDataElementSRP // TypeDefIndex: 56993
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
		public float localIntensity { get; set; } // 0x0000000184D86AF0-0x0000000184D86B00 0x000000018B2D1380-0x000000018B2D1390
		public int count { get; set; } // 0x0000000184D863D0-0x0000000184D863E0 0x000000018B2D1324-0x000000018B2D1334
		public float intensityVariation { get; set; } // 0x0000000184D91E60-0x0000000184D91E70 0x000000018B2D136C-0x000000018B2D1380
		public float fallOff { get; set; } // 0x0000000184D9DFA0-0x0000000184D9DFB0 0x000000018B2D1350-0x000000018B2D136C
		public float edgeOffset { get; set; } // 0x0000000184D8E2E0-0x0000000184D8E2F0 0x000000018B2D1334-0x000000018B2D1350
		public int sideCount { get; set; } // 0x0000000184DB8DE0-0x0000000184DB8DF0 0x000000018B2D13AC-0x000000018B2D13C0
		public float sdfRoundness { get; set; } // 0x0000000184D9DFB0-0x0000000184D9DFC0 0x000000018B2D1390-0x000000018B2D13AC
	
		// Constructors
		public LensFlareDataElementSRP(); // 0x00000001839C4B00-0x00000001839C5080
	}

	[Serializable]
	public sealed class LensFlareDataSRP : ScriptableObject // TypeDefIndex: 56994
	{
		// Fields
		public LensFlareDataElementSRP[] elements; // 0x18
	
		// Constructors
		public LensFlareDataSRP(); // 0x0000000184D5ECE0-0x0000000184D5ED10
	}

	public abstract class RenderPipelineResources : ScriptableObject // TypeDefIndex: 56995
	{
		// Properties
		protected virtual string packagePath { get; } // 0x00000001811EC580-0x00000001811EC590 
		internal string packagePath_Internal { get; } // 0x0000000185395664-0x0000000185395674 
	
		// Constructors
		protected RenderPipelineResources(); // 0x0000000183573370-0x0000000183573380
	}

	public enum PackingRules // TypeDefIndex: 56996
	{
		Exact = 0,
		Aggressive = 1
	}

	public enum FieldPacking // TypeDefIndex: 56997
	{
		NoPacking = 0,
		R11G11B10 = 1,
		PackedFloat = 2,
		PackedUint = 3
	}

	public enum FieldPrecision // TypeDefIndex: 56998
	{
		Half = 0,
		Real = 1,
		Default = 2
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
	public class GenerateHLSL : Attribute // TypeDefIndex: 56999
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
		public GenerateHLSL(PackingRules rules = PackingRules.Exact /* Metadata: 0x02349501 */, bool needAccessors = true /* Metadata: 0x02349502 */, bool needSetters = false /* Metadata: 0x02349503 */, bool needParamDebug = false /* Metadata: 0x02349504 */, int paramDefinesStart = 1 /* Metadata: 0x02349505 */, bool omitStructDeclaration = false /* Metadata: 0x02349506 */, bool containsPackedFields = false /* Metadata: 0x02349507 */, bool generateCBuffer = false /* Metadata: 0x02349508 */, int constantRegister = -1 /* Metadata: 0x02349509 */, [CallerFilePath] string sourcePath = null); // 0x000000018B2CAFC8-0x000000018B2CB028
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class SurfaceDataAttributes : Attribute // TypeDefIndex: 57000
	{
		// Fields
		public string[] displayNames; // 0x10
		public bool isDirection; // 0x18
		public bool sRGBDisplay; // 0x19
		public FieldPrecision precision; // 0x1C
		public bool checkIsNormalized; // 0x20
		public string preprocessor; // 0x28
	
		// Constructors
		public SurfaceDataAttributes(string displayName = "" /* Metadata: 0x0234950A */, bool isDirection = false /* Metadata: 0x0234950B */, bool sRGBDisplay = false /* Metadata: 0x0234950C */, FieldPrecision precision = FieldPrecision.Default /* Metadata: 0x0234950D */, bool checkIsNormalized = false /* Metadata: 0x0234950E */, string preprocessor = "" /* Metadata: 0x0234950F */); // 0x000000018B2D4D74-0x000000018B2D4E24
		public SurfaceDataAttributes(string[] displayNames, bool isDirection = false /* Metadata: 0x02349510 */, bool sRGBDisplay = false /* Metadata: 0x02349511 */, FieldPrecision precision = FieldPrecision.Default /* Metadata: 0x02349512 */, bool checkIsNormalized = false /* Metadata: 0x02349513 */, string preprocessor = "" /* Metadata: 0x02349514 */); // 0x000000018B2D4E24-0x000000018B2D4E6C
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class HLSLArray : Attribute // TypeDefIndex: 57001
	{
		// Fields
		public int arraySize; // 0x10
		public System.Type elementType; // 0x18
	
		// Constructors
		public HLSLArray(int arraySize, System.Type elementType); // 0x0000000185391D70-0x0000000185391D80
	}

	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
	public class PackingAttribute : Attribute // TypeDefIndex: 57002
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
		public PackingAttribute(string[] displayNames, FieldPacking packingScheme = FieldPacking.NoPacking /* Metadata: 0x02349515 */, int bitSize = 32 /* Metadata: 0x02349516 */, int offsetInSource = 0 /* Metadata: 0x02349517 */, float minValue = 0f /* Metadata: 0x02349518 */, float maxValue = 1f /* Metadata: 0x0234951C */, bool isDirection = false /* Metadata: 0x02349520 */, bool sRGBDisplay = false /* Metadata: 0x02349521 */, bool checkIsNormalized = false /* Metadata: 0x02349522 */, string preprocessor = "" /* Metadata: 0x02349523 */); // 0x000000018B2D1438-0x000000018B2D1520
		public PackingAttribute(string displayName = "" /* Metadata: 0x02349524 */, FieldPacking packingScheme = FieldPacking.NoPacking /* Metadata: 0x02349525 */, int bitSize = 0 /* Metadata: 0x02349526 */, int offsetInSource = 0 /* Metadata: 0x02349527 */, float minValue = 0f /* Metadata: 0x02349528 */, float maxValue = 1f /* Metadata: 0x0234952C */, bool isDirection = false /* Metadata: 0x02349530 */, bool sRGBDisplay = false /* Metadata: 0x02349531 */, bool checkIsNormalized = false /* Metadata: 0x02349532 */, string preprocessor = "" /* Metadata: 0x02349533 */); // 0x000000018B2D1520-0x000000018B2D163C
	}

	public struct ShaderGenUInt4 // TypeDefIndex: 57003
	{
	}

	internal static class Hammersley // TypeDefIndex: 57012
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
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "G:\\Build\\Release_v1d4\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq16 // TypeDefIndex: 57005
		{
			// Fields
			[HLSLArray(16, typeof(Vector4))]
			public unsafe fixed /* 0x00000000-0x00000000 */ float hammersley2dSeq16[0]; // 0x00
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _hammersley2dSeq16_e__FixedBuffer // TypeDefIndex: 57004
			{
				// Fields
				public float FixedElementField; // 0x00
			}
		}
	
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "G:\\Build\\Release_v1d4\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq32 // TypeDefIndex: 57007
		{
			// Fields
			[HLSLArray(32, typeof(Vector4))]
			public unsafe fixed /* 0x00000000-0x00000000 */ float hammersley2dSeq32[0]; // 0x00
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _hammersley2dSeq32_e__FixedBuffer // TypeDefIndex: 57006
			{
				// Fields
				public float FixedElementField; // 0x00
			}
		}
	
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "G:\\Build\\Release_v1d4\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq64 // TypeDefIndex: 57009
		{
			// Fields
			[HLSLArray(64, typeof(Vector4))]
			public unsafe fixed /* 0x00000000-0x00000000 */ float hammersley2dSeq64[0]; // 0x00
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _hammersley2dSeq64_e__FixedBuffer // TypeDefIndex: 57008
			{
				// Fields
				public float FixedElementField; // 0x00
			}
		}
	
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "G:\\Build\\Release_v1d4\\Windows\\Rel\\Proj\\Packages\\com.unity.render-pipelines.core\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
		private struct Hammersley2dSeq256 // TypeDefIndex: 57011
		{
			// Fields
			[HLSLArray(256, typeof(Vector4))]
			public unsafe fixed /* 0x00000000-0x00000000 */ float hammersley2dSeq256[0]; // 0x00
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _hammersley2dSeq256_e__FixedBuffer // TypeDefIndex: 57010
			{
				// Fields
				public float FixedElementField; // 0x00
			}
		}
	
		// Constructors
		static Hammersley(); // 0x000000018B2CB434-0x000000018B2CB67C
	
		// Methods
		public static void Initialize(); // 0x000000018B2CB150-0x000000018B2CB434
		public static void BindConstants(CommandBuffer cmd, ComputeShader cs); // 0x000000018B2CB028-0x000000018B2CB150
	}

	public class BufferedRTHandleSystem : IDisposable // TypeDefIndex: 57013
	{
		// Fields
		private Dictionary<int, RTHandle[]> m_RTHandles; // 0x10
		private bool m_DisposedValue; // 0x18
	
		// Constructors
		public BufferedRTHandleSystem(); // 0x0000000184A3B350-0x0000000184A3B3D0
	
		// Methods
		public RTHandle GetFrameRT(int bufferId, int frameIndex); // 0x000000018B2CA220-0x000000018B2CA2C0
		public void AllocBuffer(int bufferId, Func<int, RTHandle> allocator, int bufferCount); // 0x000000018B2CA0F8-0x000000018B2CA214
		public void ReleaseBuffer(int bufferId); // 0x000000018B2CA348-0x000000018B2CA41C
		public int GetNumFramesAllocated(int bufferId); // 0x000000018B2CA2C0-0x000000018B2CA348
		private void Swap(); // 0x000000018B2CA41C-0x000000018B2CA620
		private void Dispose(bool disposing); // 0x00000001847006E0-0x0000000184700710
		public void Dispose(); // 0x000000018B2CA214-0x000000018B2CA220
		public void ReleaseAll(); // 0x0000000184700710-0x00000001847008C0
	}

	public enum DepthBits // TypeDefIndex: 57014
	{
		None = 0,
		Depth8 = 8,
		Depth16 = 16,
		Depth24 = 24,
		Depth32 = 32
	}

	public enum MSAASamples // TypeDefIndex: 57015
	{
		None = 1,
		MSAA2x = 2,
		MSAA4x = 4,
		MSAA8x = 8
	}

	public class PowerOfTwoTextureAtlas : Texture2DAtlas // TypeDefIndex: 57018
	{
		// Fields
		private readonly int m_MipPadding; // 0x48
		private const float k_MipmapFactorApprox = 1.33f; // Metadata: 0x02349549
		private Dictionary<int, Vector2Int> m_RequestedTextures; // 0x50
	
		// Properties
		public int mipPadding { get; } // 0x0000000184D863D0-0x0000000184D863E0 
	
		// Nested types
		private enum BlitType // TypeDefIndex: 57016
		{
			Padding = 0,
			PaddingMultiply = 1,
			OctahedralPadding = 2,
			OctahedralPaddingMultiply = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 57017
		{
			// Fields
			public static readonly __c __9; // 0x00
			[TupleElementNames(new string[2] {"instanceId", "size" })]
			public static Comparison<ValueTuple<int, Vector2Int>> __9__23_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B2D8CDC-0x000000018B2D8D40
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _RelayoutEntries_b__23_0([TupleElementNames(new string[2] {"instanceId", "size" })] ValueTuple<int, Vector2Int> c1, [TupleElementNames(new string[2] {"instanceId", "size" })] ValueTuple<int, Vector2Int> c2); // 0x000000018B2D8BDC-0x000000018B2D8C14
		}
	
		// Constructors
		public PowerOfTwoTextureAtlas(int size, int mipPadding, GraphicsFormat format, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x0234953D */, string name = "" /* Metadata: 0x0234953E */, bool useMipMap = true /* Metadata: 0x0234953F */); // 0x000000018B2D306C-0x000000018B2D3164
	
		// Methods
		private int GetTexturePadding(); // 0x0000000184DB8DF0-0x0000000184DB8E20
		public Vector4 GetPayloadScaleOffset(Texture texture, [IsReadOnly] in Vector4 scaleOffset); // 0x000000018B2D2870-0x000000018B2D291C
		public static Vector4 GetPayloadScaleOffset([IsReadOnly] in Vector2 textureSize, [IsReadOnly] in Vector2 paddingSize, [IsReadOnly] in Vector4 scaleOffset); // 0x000000018B2D2758-0x000000018B2D2870
		private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, BlitType blitType); // 0x000000018B2D1EC0-0x000000018B2D2298
		public override void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x02349540 */, int overrideInstanceID = -1 /* Metadata: 0x02349541 */); // 0x000000018B2D2514-0x000000018B2D25E0
		public void BlitTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x02349542 */, int overrideInstanceID = -1 /* Metadata: 0x02349543 */); // 0x000000018B2D2440-0x000000018B2D2514
		public override void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x02349544 */, int overrideInstanceID = -1 /* Metadata: 0x02349545 */); // 0x000000018B2D236C-0x000000018B2D2440
		public void BlitOctahedralTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x02349546 */, int overrideInstanceID = -1 /* Metadata: 0x02349547 */); // 0x000000018B2D2298-0x000000018B2D236C
		private void TextureSizeToPowerOfTwo(Texture texture, ref int width, ref int height); // 0x000000018B2D3038-0x000000018B2D306C
		private Vector2 GetPowerOfTwoTextureSize(Texture texture); // 0x000000018B2D291C-0x000000018B2D2998
		public override bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1 /* Metadata: 0x02349548 */); // 0x000000018B2D1D28-0x000000018B2D1EC0
		public void ResetRequestedTexture(); // 0x000000018B2D2FF0-0x000000018B2D3038
		public bool ReserveSpace(Texture texture); // 0x000000018B2D2E14-0x000000018B2D2E74
		public bool ReserveSpace(Texture texture, int width, int height); // 0x000000018B2D2FA8-0x000000018B2D2FF0
		public bool ReserveSpace(Texture textureA, Texture textureB, int width, int height); // 0x000000018B2D2F68-0x000000018B2D2FA8
		private bool ReserveSpace(int id, int width, int height); // 0x000000018B2D2E74-0x000000018B2D2F68
		public bool RelayoutEntries(); // 0x000000018B2D2998-0x000000018B2D2E14
		public static long GetApproxCacheSizeInByte(int nbElement, int resolution, bool hasMipmap, GraphicsFormat format); // 0x000000018B2D25E0-0x000000018B2D2690
		public static int GetMaxCacheSizeForWeightInByte(int weight, bool hasMipmap, GraphicsFormat format); // 0x000000018B2D2690-0x000000018B2D2758
	}

	public class RTHandle // TypeDefIndex: 57019
	{
		// Fields
		internal RenderTexture m_RT; // 0x10
		internal Texture m_ExternalTexture; // 0x18
		internal RenderTargetIdentifier m_NameID; // 0x20
		internal bool m_EnableMSAA; // 0x48
		internal bool m_EnableRandomWrite; // 0x49
		internal string m_Name; // 0x50
	
		// Properties
		public RenderTexture rt { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public RenderTargetIdentifier nameID { get; } // 0x0000000184D8E8C0-0x0000000184D8E8E0 
		public string name { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x000000018B2D3EC0-0x000000018B2D3F78
		public bool isMSAAEnabled { get; } // 0x0000000184D867D0-0x0000000184D867E0 
	
		// Constructors
		public RTHandle(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static implicit operator RenderTargetIdentifier(RTHandle handle); // 0x000000018B2D3E14-0x000000018B2D3E58
		public static implicit operator Texture(RTHandle handle); // 0x000000018B2D3E58-0x000000018B2D3EC0
		public static implicit operator RenderTexture(RTHandle handle); // 0x00000001833021A0-0x00000001833021B0
		public void SetRenderTexture(RenderTexture rt); // 0x00000001837DF870-0x00000001837DF8F0
		public void SetTexture(Texture tex); // 0x00000001837DF980-0x00000001837DFA00
		public void SetTexture(RenderTargetIdentifier tex); // 0x000000018B2D3CD8-0x000000018B2D3D24
		public int GetInstanceID(); // 0x000000018B2D3C34-0x000000018B2D3CD8
		public void Release(); // 0x00000001837DC790-0x00000001837DC840
		public void SwitchToFastMemory(CommandBuffer cmd, float residencyFraction = 1f /* Metadata: 0x02349551 */, FastMemoryFlags flags = FastMemoryFlags.None | FastMemoryFlags.SpillTop /* Metadata: 0x02349555 */, bool copyContents = false /* Metadata: 0x02349556 */); // 0x000000018B2D3D88-0x000000018B2D3E14
		public void CopyToFastMemory(CommandBuffer cmd, float residencyFraction = 1f /* Metadata: 0x02349557 */, FastMemoryFlags flags = FastMemoryFlags.None | FastMemoryFlags.SpillTop /* Metadata: 0x0234955B */); // 0x000000018B2D3C18-0x000000018B2D3C34
		public void SwitchOutFastMemory(CommandBuffer cmd, bool copyContents = true /* Metadata: 0x0234955C */); // 0x000000018B2D3D24-0x000000018B2D3D88
	}

	public static class RTHandles // TypeDefIndex: 57020
	{
		// Fields
		private static RTHandleSystem s_DefaultInstance; // 0x00
	
		// Constructors
		static RTHandles(); // 0x0000000184D31EF0-0x0000000184D31F60
	
		// Methods
		public static RTHandle Alloc(int width, int height, int slices = 1 /* Metadata: 0x0234955D */, DepthBits depthBufferBits = DepthBits.None /* Metadata: 0x0234955E */, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB /* Metadata: 0x0234955F */, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x02349560 */, TextureWrapMode wrapMode = TextureWrapMode.Repeat /* Metadata: 0x02349561 */, TextureDimension dimension = TextureDimension.Tex2D /* Metadata: 0x02349562 */, bool enableRandomWrite = false /* Metadata: 0x02349563 */, bool useMipMap = false /* Metadata: 0x02349564 */, bool autoGenerateMips = true /* Metadata: 0x02349565 */, bool isShadowMap = false /* Metadata: 0x02349566 */, int anisoLevel = 1 /* Metadata: 0x02349567 */, float mipMapBias = 0f /* Metadata: 0x02349568 */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x0234956C */, bool bindTextureMS = false /* Metadata: 0x0234956D */, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None /* Metadata: 0x0234956E */, string name = "" /* Metadata: 0x0234956F */); // 0x00000001837DED20-0x00000001837DEDF0
		public static RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = TextureWrapMode.Repeat /* Metadata: 0x02349570 */, int slices = 1 /* Metadata: 0x02349571 */, DepthBits depthBufferBits = DepthBits.None /* Metadata: 0x02349572 */, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB /* Metadata: 0x02349573 */, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x02349574 */, TextureDimension dimension = TextureDimension.Tex2D /* Metadata: 0x02349575 */, bool enableRandomWrite = false /* Metadata: 0x02349576 */, bool useMipMap = false /* Metadata: 0x02349577 */, bool autoGenerateMips = true /* Metadata: 0x02349578 */, bool isShadowMap = false /* Metadata: 0x02349579 */, int anisoLevel = 1 /* Metadata: 0x0234957A */, float mipMapBias = 0f /* Metadata: 0x0234957B */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x0234957F */, bool bindTextureMS = false /* Metadata: 0x02349580 */, bool useDynamicScale = false /* Metadata: 0x02349581 */, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None /* Metadata: 0x02349582 */, string name = "" /* Metadata: 0x02349583 */); // 0x000000018B2D3F78-0x000000018B2D404C
		public static RTHandle Alloc(Texture tex); // 0x0000000185390780-0x0000000185390788
		public static RTHandle Alloc(RenderTexture tex); // 0x000000018B2D4104-0x000000018B2D410C
		public static RTHandle Alloc(RenderTargetIdentifier tex); // 0x000000018B2D404C-0x000000018B2D4080
		public static RTHandle Alloc(RenderTargetIdentifier tex, string name); // 0x000000018B2D40D0-0x000000018B2D4104
		private static RTHandle Alloc(RTHandle tex); // 0x000000018B2D4080-0x000000018B2D40D0
	}

	public class RTHandleSystem // TypeDefIndex: 57021
	{
		// Constructors
		public RTHandleSystem(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Initialize(); // 0x00000001841E1670-0x00000001841E1680
		public static RTHandle Alloc(int width, int height, int slices = 1 /* Metadata: 0x02349584 */, DepthBits depthBufferBits = DepthBits.None /* Metadata: 0x02349585 */, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB /* Metadata: 0x02349586 */, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x02349587 */, TextureWrapMode wrapMode = TextureWrapMode.Repeat /* Metadata: 0x02349588 */, TextureDimension dimension = TextureDimension.Tex2D /* Metadata: 0x02349589 */, bool enableRandomWrite = false /* Metadata: 0x0234958A */, bool useMipMap = false /* Metadata: 0x0234958B */, bool autoGenerateMips = true /* Metadata: 0x0234958C */, bool isShadowMap = false /* Metadata: 0x0234958D */, int anisoLevel = 1 /* Metadata: 0x0234958E */, float mipMapBias = 0f /* Metadata: 0x0234958F */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x02349593 */, bool bindTextureMS = false /* Metadata: 0x02349594 */, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None /* Metadata: 0x02349595 */, string name = "" /* Metadata: 0x02349596 */); // 0x00000001837DEDF0-0x00000001837DEED0
		public static RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = TextureWrapMode.Repeat /* Metadata: 0x02349597 */, int slices = 1 /* Metadata: 0x02349598 */, DepthBits depthBufferBits = DepthBits.None /* Metadata: 0x02349599 */, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB /* Metadata: 0x0234959A */, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x0234959B */, TextureDimension dimension = TextureDimension.Tex2D /* Metadata: 0x0234959C */, bool enableRandomWrite = false /* Metadata: 0x0234959D */, bool useMipMap = false /* Metadata: 0x0234959E */, bool autoGenerateMips = true /* Metadata: 0x0234959F */, bool isShadowMap = false /* Metadata: 0x023495A0 */, int anisoLevel = 1 /* Metadata: 0x023495A1 */, float mipMapBias = 0f /* Metadata: 0x023495A2 */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x023495A6 */, bool bindTextureMS = false /* Metadata: 0x023495A7 */, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None /* Metadata: 0x023495A8 */, string name = "" /* Metadata: 0x023495A9 */); // 0x00000001837DEED0-0x00000001837DF3D0
		private static RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, DepthBits depthBufferBits, GraphicsFormat colorFormat, UnityEngine.FilterMode filterMode, TextureWrapMode wrapMode, TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, MSAASamples msaaSamples, bool bindTextureMS, RenderTextureMemoryless memoryless, string name); // 0x000000018B2D35A0-0x000000018B2D3A50
		public static RTHandle Alloc(RenderTexture texture); // 0x000000018B2D3AAC-0x000000018B2D3B2C
		public static RTHandle Alloc(Texture texture); // 0x00000001837DF8F0-0x00000001837DF980
		public static RTHandle Alloc(RenderTargetIdentifier texture); // 0x000000018B2D3A50-0x000000018B2D3AAC
		public static RTHandle Alloc(RenderTargetIdentifier texture, string name); // 0x000000018B2D3B2C-0x000000018B2D3BC8
		private static RTHandle Alloc(RTHandle tex); // 0x000000018B2D3BC8-0x000000018B2D3C18
	}

	internal class AtlasAllocator // TypeDefIndex: 57024
	{
		// Fields
		private AtlasNode m_Root; // 0x10
		private int m_Width; // 0x18
		private int m_Height; // 0x1C
		private bool powerOfTwoPadding; // 0x20
		private ObjectPool<AtlasNode> m_NodePool; // 0x28
	
		// Nested types
		private class AtlasNode // TypeDefIndex: 57022
		{
			// Fields
			public AtlasNode m_RightChild; // 0x10
			public AtlasNode m_BottomChild; // 0x18
			public Vector4 m_Rect; // 0x20
	
			// Constructors
			public AtlasNode(); // 0x0000000184DB8D50-0x0000000184DB8D60
	
			// Methods
			public AtlasNode Allocate(ref ObjectPool<AtlasNode> pool, int width, int height, bool powerOfTwoPadding); // 0x000000018B2C9070-0x000000018B2C93D0
			public void Release(ref ObjectPool<AtlasNode> pool); // 0x000000018B2C99C8-0x000000018B2C9A90
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 57023
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static UnityAction<AtlasNode> __9__6_0; // 0x08
			public static UnityAction<AtlasNode> __9__6_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B2D8C14-0x000000018B2D8C78
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _.ctor_b__6_0(AtlasNode _); // 0x00000001841E1670-0x00000001841E1680
			internal void _.ctor_b__6_1(AtlasNode _); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public AtlasAllocator(int width, int height, bool potPadding); // 0x000000018B2C8C34-0x000000018B2C8EA4
	
		// Methods
		public bool Allocate(ref Vector4 result, int width, int height); // 0x000000018B2C8B80-0x000000018B2C8BDC
		public void Reset(); // 0x000000018B2C8BDC-0x000000018B2C8C34
	}

	public class Texture2DAtlas // TypeDefIndex: 57026
	{
		// Fields
		private protected const int kGPUTexInvalid = 0; // Metadata: 0x023495BC
		private protected const int kGPUTexValidMip0 = 1; // Metadata: 0x023495BD
		private protected const int kGPUTexValidMipAll = 2; // Metadata: 0x023495BE
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
		public static int maxMipLevelPadding { get; } // 0x000000018B2D7398-0x000000018B2D73E8 
		public RTHandle AtlasTexture { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Nested types
		private enum BlitType // TypeDefIndex: 57025
		{
			Default = 0,
			CubeTo2DOctahedral = 1,
			SingleChannel = 2,
			CubeTo2DOctahedralSingleChannel = 3
		}
	
		// Constructors
		public Texture2DAtlas(int width, int height, GraphicsFormat format, UnityEngine.FilterMode filterMode = UnityEngine.FilterMode.Point /* Metadata: 0x023495AA */, bool powerOfTwoPadding = false /* Metadata: 0x023495AB */, string name = "" /* Metadata: 0x023495AC */, bool useMipMap = true /* Metadata: 0x023495AD */); // 0x000000018B2D70D0-0x000000018B2D7398
		static Texture2DAtlas(); // 0x000000018B2D707C-0x000000018B2D70D0
	
		// Methods
		public void Release(); // 0x000000018B2D6DAC-0x000000018B2D6DE4
		public void ResetAllocator(); // 0x000000018B2D6DE4-0x000000018B2D6E5C
		public void ClearTarget(CommandBuffer cmd); // 0x000000018B2D5FD0-0x000000018B2D615C
		private protected int GetTextureMipmapCount(int width, int height); // 0x000000018B2D6428-0x000000018B2D6460
		private protected bool Is2D(Texture texture); // 0x000000018B2D6460-0x000000018B2D64D4
		private protected bool IsSingleChannelBlit(Texture source, Texture destination); // 0x000000018B2D65D0-0x000000018B2D67A4
		private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, BlitType blitType); // 0x000000018B2D5AAC-0x000000018B2D5CC0
		private protected void MarkGPUTextureValid(int instanceId, bool mipAreValid = false /* Metadata: 0x023495AE */); // 0x000000018B2D67FC-0x000000018B2D6860
		private protected void MarkGPUTextureInvalid(int instanceId); // 0x000000018B2D67A4-0x000000018B2D67FC
		public virtual void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x023495AF */, int overrideInstanceID = -1 /* Metadata: 0x023495B0 */); // 0x000000018B2D5E78-0x000000018B2D5FD0
		public virtual void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true /* Metadata: 0x023495B1 */, int overrideInstanceID = -1 /* Metadata: 0x023495B2 */); // 0x000000018B2D5E20-0x000000018B2D5E78
		public virtual void BlitCubeTexture2D(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, bool blitMips = true /* Metadata: 0x023495B3 */, int overrideInstanceID = -1 /* Metadata: 0x023495B4 */); // 0x000000018B2D5CC0-0x000000018B2D5E20
		public virtual bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1 /* Metadata: 0x023495B5 */); // 0x000000018B2D58F4-0x000000018B2D5AAC
		public bool AllocateTextureWithoutBlit(Texture texture, int width, int height, ref Vector4 scaleOffset); // 0x000000018B2D5894-0x000000018B2D58F4
		public virtual bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref Vector4 scaleOffset); // 0x000000018B2D5708-0x000000018B2D5894
		private protected int GetTextureHash(Texture textureA, Texture textureB); // 0x000000018B2D6364-0x000000018B2D63C4
		public int GetTextureID(Texture texture); // 0x000000018B2D6408-0x000000018B2D6428
		public int GetTextureID(Texture textureA, Texture textureB); // 0x000000018B2D63C4-0x000000018B2D6408
		public bool IsCached(out Vector4 scaleOffset, Texture textureA, Texture textureB); // 0x000000018B2D64D4-0x000000018B2D6514
		public bool IsCached(out Vector4 scaleOffset, Texture texture); // 0x000000018B2D6594-0x000000018B2D65D0
		public bool IsCached(out Vector4 scaleOffset, int id); // 0x000000018B2D6514-0x000000018B2D6594
		internal Vector2Int GetCachedTextureSize(int id); // 0x000000018B2D62F8-0x000000018B2D6364
		public virtual bool NeedsUpdate(Texture texture, bool needMips = false /* Metadata: 0x023495B6 */); // 0x000000018B2D6BB4-0x000000018B2D6DAC
		public virtual bool NeedsUpdate(Texture textureA, Texture textureB, bool needMips = false /* Metadata: 0x023495B7 */); // 0x000000018B2D6860-0x000000018B2D6BB4
		public virtual bool AddTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture); // 0x000000018B2D5670-0x000000018B2D5708
		public virtual bool UpdateTexture(CommandBuffer cmd, Texture oldTexture, Texture newTexture, ref Vector4 scaleOffset, Vector4 sourceScaleOffset, bool updateIfNeeded = true /* Metadata: 0x023495B8 */, bool blitMips = true /* Metadata: 0x023495B9 */); // 0x000000018B2D6E5C-0x000000018B2D6FC8
		public virtual bool UpdateTexture(CommandBuffer cmd, Texture texture, ref Vector4 scaleOffset, bool updateIfNeeded = true /* Metadata: 0x023495BA */, bool blitMips = true /* Metadata: 0x023495BB */); // 0x000000018B2D6FC8-0x000000018B2D707C
		internal bool EnsureTextureSlot(out bool isUploadNeeded, ref Vector4 scaleBias, int key, int width, int height); // 0x000000018B2D615C-0x000000018B2D62F8
	}

	internal class AtlasAllocatorDynamic // TypeDefIndex: 57030
	{
		// Fields
		private int m_Width; // 0x10
		private int m_Height; // 0x14
		private AtlasNodePool m_Pool; // 0x18
		private short m_Root; // 0x20
		private Dictionary<int, short> m_NodeFromID; // 0x28
	
		// Nested types
		private class AtlasNodePool // TypeDefIndex: 57027
		{
			// Fields
			internal AtlasNode[] m_Nodes; // 0x10
			private short m_Next; // 0x18
			private short m_FreelistHead; // 0x1A
	
			// Constructors
			public AtlasNodePool(short capacity); // 0x000000018B2C9008-0x000000018B2C9070
	
			// Methods
			public void Dispose(); // 0x000000018B2C8FF0-0x000000018B2C9008
			public void Clear(); // 0x0000000184DB8D20-0x0000000184DB8D30
			public short AtlasNodeCreate(short parent); // 0x000000018B2C8EA4-0x000000018B2C8FA4
			public void AtlasNodeFree(short index); // 0x000000018B2C8FA4-0x000000018B2C8FF0
		}
	
		private struct AtlasNode // TypeDefIndex: 57029
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
			private enum AtlasNodeFlags : uint // TypeDefIndex: 57028
			{
				IsOccupied = 1
			}
	
			// Constructors
			public AtlasNode(short self, short parent); // 0x000000018B2C9A90-0x000000018B2C9AC4
	
			// Methods
			public bool IsOccupied(); // 0x000000018B2C9868-0x000000018B2C9870
			public void SetIsOccupied(); // 0x0000000184DB8D40-0x0000000184DB8D50
			public void ClearIsOccupied(); // 0x0000000184DB8D30-0x0000000184DB8D40
			public bool IsLeafNode(); // 0x000000018B2C97C8-0x000000018B2C97D4
			public short Allocate(AtlasNodePool pool, int width, int height); // 0x000000018B2C93D0-0x000000018B2C97C8
			public void ReleaseChildren(AtlasNodePool pool); // 0x000000018B2C9924-0x000000018B2C99C8
			public void ReleaseAndMerge(AtlasNodePool pool); // 0x000000018B2C9870-0x000000018B2C9924
			public bool IsMergeNeeded(AtlasNodePool pool); // 0x000000018B2C97D4-0x000000018B2C9868
		}
	
		// Constructors
		public AtlasAllocatorDynamic(int width, int height, int capacityAllocations); // 0x000000018B2C8A3C-0x000000018B2C8B80
	
		// Methods
		public bool Allocate(out Vector4 result, int key, int width, int height); // 0x000000018B2C8354-0x000000018B2C8458
		public void Release(int key); // 0x000000018B2C88C0-0x000000018B2C8988
		public void Release(); // 0x000000018B2C8988-0x000000018B2C8A3C
		public string DebugStringFromRoot(int depthMax = -1 /* Metadata: 0x023495C3 */); // 0x000000018B2C8858-0x000000018B2C88C0
		private void DebugStringFromNode(ref string res, short n, int depthCurrent = 0 /* Metadata: 0x023495C4 */, int depthMax = -1 /* Metadata: 0x023495C5 */); // 0x000000018B2C8458-0x000000018B2C8858
	}

	internal class Texture2DAtlasDynamic // TypeDefIndex: 57031
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
		public RTHandle AtlasTexture { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Constructors
		public Texture2DAtlasDynamic(int width, int height, int capacity, GraphicsFormat format); // 0x000000018B2D54C4-0x000000018B2D5670
		public Texture2DAtlasDynamic(int width, int height, int capacity, RTHandle atlasTexture); // 0x000000018B2D53A4-0x000000018B2D54C4
	
		// Methods
		public void Release(); // 0x000000018B2D5314-0x000000018B2D534C
		public void ResetAllocator(); // 0x000000018B2D534C-0x000000018B2D53A4
		public bool AddTexture(CommandBuffer cmd, out Vector4 scaleOffset, Texture texture); // 0x000000018B2D4E6C-0x000000018B2D50E4
		public bool IsCached(out Vector4 scaleOffset, int key); // 0x000000018B2D5248-0x000000018B2D52AC
		public bool EnsureTextureSlot(out bool isUploadNeeded, out Vector4 scaleOffset, int key, int width, int height); // 0x000000018B2D50E4-0x000000018B2D5248
		public void ReleaseTextureSlot(int key); // 0x000000018B2D52AC-0x000000018B2D5314
	}

	public static class TextureXR // TypeDefIndex: 57032
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
		public static int maxViews { set; } // 0x000000018B2D89BC-0x000000018B2D8A10
		public static int slices { get; } // 0x000000018B2D896C-0x000000018B2D89BC 
		public static bool useTexArray { get; } // 0x0000000184775CF0-0x0000000184775D20 
		public static TextureDimension dimension { get; } // 0x000000018B2D8918-0x000000018B2D896C 
	
		// Constructors
		static TextureXR(); // 0x0000000184D79990-0x0000000184D799D0
	
		// Methods
		public static RTHandle GetBlackUIntTexture(); // 0x000000018B2D7AFC-0x000000018B2D7B70
		public static RTHandle GetClearTexture(); // 0x000000018B2D7B70-0x000000018B2D7BE4
		public static RTHandle GetMagentaTexture(); // 0x000000018B2D7BE4-0x000000018B2D7C58
		public static RTHandle GetBlackTexture(); // 0x000000018B2D7A80-0x000000018B2D7AFC
		public static RTHandle GetBlackTextureArray(); // 0x000000018B2D7A2C-0x000000018B2D7A80
		public static RTHandle GetBlackTexture3D(); // 0x000000018B2D79D8-0x000000018B2D7A2C
		public static RTHandle GetWhiteTexture(); // 0x000000018B2D7C58-0x000000018B2D7CD4
		public static void Initialize(CommandBuffer cmd, ComputeShader clearR32_UIntShader); // 0x000000018B2D7CD4-0x000000018B2D8918
		private static Texture2DArray CreateTexture2DArrayFromTexture2D(Texture2D source, string name); // 0x000000018B2D7870-0x000000018B2D79D8
		private static Texture CreateBlackUIntTextureArray(CommandBuffer cmd, ComputeShader clearR32_UIntShader); // 0x000000018B2D74B8-0x000000018B2D7694
		private static Texture CreateBlackUintTexture(CommandBuffer cmd, ComputeShader clearR32_UIntShader); // 0x000000018B2D7694-0x000000018B2D7870
		private static Texture3D CreateBlackTexture3D(string name); // 0x000000018B2D73E8-0x000000018B2D74B8
	}

	public static class ArrayExtensions // TypeDefIndex: 57033
	{
		// Methods
		public static void ResizeArray<T>(ref ref T[] array, int capacity);
		public static void Grow<T>(ref ref T[] array, int targetSize);
		public static void GrowToNearestPowerOf2<T>(ref ref T[] array, int targetSize);
		public static uint RoundUpToPowerOf2(uint n); // 0x000000018B2C832C-0x000000018B2C8354
	
		// Extension methods
		public static void ResizeArray<T>(this ref NativeArray<T> array, int capacity, Unity.Collections.Allocator allocator)
			where T : struct;
		public static void ResizeArray(this ref TransformAccessArray array, int capacity); // 0x000000018B2C82A0-0x000000018B2C832C
	}

	public interface IBitArray // TypeDefIndex: 57034
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
	public struct BitArray8 : IBitArray // TypeDefIndex: 57035
	{
		// Fields
		[SerializeField]
		private byte data; // 0x00
	
		// Properties
		public uint capacity { get; } // 0x0000000184D8D060-0x0000000184D8D070 
		public bool allFalse { get; } // 0x000000018961F480-0x000000018961F488 
		public bool allTrue { get; } // 0x000000018B2CA01C-0x000000018B2CA024 
		public string humanizedData { get; } // 0x000000018B2CA024-0x000000018B2CA0E8 
		public bool this[uint index] { get => default; set {} } // 0x000000018B2CA000-0x000000018B2CA01C 0x000000018B2CA0E8-0x000000018B2CA0F8
	
		// Constructors
		public BitArray8(byte initValue); // 0x0000000184D87180-0x0000000184D87190
		public BitArray8(IEnumerable<uint> bitIndexTrue); // 0x000000018B2C9F70-0x000000018B2CA000
	
		// Methods
		public static BitArray8 operator ~(BitArray8 a); // 0x0000000184DB8DD0-0x0000000184DB8DE0
		public static BitArray8 operator |(BitArray8 a, BitArray8 b); // 0x0000000184DB8DC0-0x0000000184DB8DD0
		public static BitArray8 operator &(BitArray8 a, BitArray8 b); // 0x0000000184DB8DB0-0x0000000184DB8DC0
		public IBitArray BitAnd(IBitArray other); // 0x000000018B2C9E08-0x000000018B2C9E6C
		public IBitArray BitOr(IBitArray other); // 0x000000018B2C9EB4-0x000000018B2C9F14
		public IBitArray BitNot(); // 0x000000018B2C9E6C-0x000000018B2C9EB4
		public static bool operator ==(BitArray8 a, BitArray8 b); // 0x00000001866FF158-0x00000001866FF160
		public static bool operator !=(BitArray8 a, BitArray8 b); // 0x00000001866FF160-0x00000001866FF168
		public override bool Equals(object obj); // 0x000000018B2C9F14-0x000000018B2C9F70
		public override int GetHashCode(); // 0x0000000184DB8DA0-0x0000000184DB8DB0
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray16 : IBitArray // TypeDefIndex: 57036
	{
		// Fields
		[SerializeField]
		private ushort data; // 0x00
	
		// Properties
		public uint capacity { get; } // 0x0000000184DA43A0-0x0000000184DA43B0 
		public bool allFalse { get; } // 0x000000018B160F5C-0x000000018B160F64 
		public bool allTrue { get; } // 0x000000018B2C9CCC-0x000000018B2C9CD8 
		public string humanizedData { get; } // 0x000000018B2C9CD8-0x000000018B2C9E00 
		public bool this[uint index] { get => default; set {} } // 0x0000000185396E28-0x0000000185396E38 0x000000018539559C-0x00000001853955AC
	
		// Constructors
		public BitArray16(ushort initValue); // 0x0000000184D87160-0x0000000184D87170
		public BitArray16(IEnumerable<uint> bitIndexTrue); // 0x000000018B2C9C38-0x000000018B2C9CCC
	
		// Methods
		public static BitArray16 operator ~(BitArray16 a); // 0x0000000184DB8D90-0x0000000184DB8DA0
		public static BitArray16 operator |(BitArray16 a, BitArray16 b); // 0x0000000184DB8D80-0x0000000184DB8D90
		public static BitArray16 operator &(BitArray16 a, BitArray16 b); // 0x0000000184DB8D70-0x0000000184DB8D80
		public IBitArray BitAnd(IBitArray other); // 0x000000018B2C9AC4-0x000000018B2C9B2C
		public IBitArray BitOr(IBitArray other); // 0x000000018B2C9B74-0x000000018B2C9BD8
		public IBitArray BitNot(); // 0x000000018B2C9B2C-0x000000018B2C9B74
		public static bool operator ==(BitArray16 a, BitArray16 b); // 0x000000018B290008-0x000000018B290010
		public static bool operator !=(BitArray16 a, BitArray16 b); // 0x000000018B2C9E00-0x000000018B2C9E08
		public override bool Equals(object obj); // 0x000000018B2C9BD8-0x000000018B2C9C38
		public override int GetHashCode(); // 0x0000000184DB8D60-0x0000000184DB8D70
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray32 : IBitArray // TypeDefIndex: 57037
	{
		// Fields
		[SerializeField]
		private uint data; // 0x00
	
		// Properties
		public uint capacity { get; } // 0x0000000184DA43E0-0x0000000184DA43F0 
		public bool allFalse { get; } // 0x000000018426F6A0-0x000000018426F6B0 
		public bool allTrue { get; } // 0x000000018B2D9B6C-0x000000018B2D9B74 
		private string humanizedVersion { get; } // 0x000000018B2D9C9C-0x000000018B2D9CF0 
		public string humanizedData { get; } // 0x000000018B2D9B74-0x000000018B2D9C9C 
		public bool this[uint index] { get => default; set {} } // 0x000000018B2D9B54-0x000000018B2D9B6C 0x000000018B2D9CF0-0x000000018B2D9D00
	
		// Constructors
		public BitArray32(uint initValue); // 0x0000000184D86140-0x0000000184D86150
		public BitArray32(IEnumerable<uint> bitIndexTrue); // 0x000000018B2D9AC4-0x000000018B2D9B54
	
		// Methods
		public IBitArray BitAnd(IBitArray other); // 0x000000018B2D9960-0x000000018B2D99C4
		public IBitArray BitOr(IBitArray other); // 0x000000018B2D9A08-0x000000018B2D9A68
		public IBitArray BitNot(); // 0x000000018B2D99C4-0x000000018B2D9A08
		public static BitArray32 operator ~(BitArray32 a); // 0x0000000184DB8FF0-0x0000000184DB9000
		public static BitArray32 operator |(BitArray32 a, BitArray32 b); // 0x0000000184DB8FE0-0x0000000184DB8FF0
		public static BitArray32 operator &(BitArray32 a, BitArray32 b); // 0x0000000184DA5940-0x0000000184DA5950
		public static bool operator ==(BitArray32 a, BitArray32 b); // 0x0000000187872540-0x0000000187872548
		public static bool operator !=(BitArray32 a, BitArray32 b); // 0x000000018AAED910-0x000000018AAED918
		public override bool Equals(object obj); // 0x000000018B2D9A68-0x000000018B2D9AC4
		public override int GetHashCode(); // 0x0000000184DB8FD0-0x0000000184DB8FE0
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray64 : IBitArray // TypeDefIndex: 57038
	{
		// Fields
		[SerializeField]
		private ulong data; // 0x00
	
		// Properties
		public uint capacity { get; } // 0x0000000184DB9010-0x0000000184DB9020 
		public bool allFalse { get; } // 0x000000018314CD60-0x000000018314CD70 
		public bool allTrue { get; } // 0x000000018B2D9F20-0x000000018B2D9F28 
		public string humanizedData { get; } // 0x000000018B2D9F28-0x000000018B2DA050 
		public bool this[uint index] { get => default; set {} } // 0x000000018B2D9F08-0x000000018B2D9F20 0x000000018B2DA050-0x000000018B2DA060
	
		// Constructors
		public BitArray64(ulong initValue); // 0x0000000184D88B60-0x0000000184D88B70
		public BitArray64(IEnumerable<uint> bitIndexTrue); // 0x000000018B2D9E74-0x000000018B2D9F08
	
		// Methods
		public static BitArray64 operator ~(BitArray64 a); // 0x0000000184DB9040-0x0000000184DB9050
		public static BitArray64 operator |(BitArray64 a, BitArray64 b); // 0x0000000184DB9030-0x0000000184DB9040
		public static BitArray64 operator &(BitArray64 a, BitArray64 b); // 0x0000000184DB9020-0x0000000184DB9030
		public IBitArray BitAnd(IBitArray other); // 0x000000018B2D9D00-0x000000018B2D9D68
		public IBitArray BitOr(IBitArray other); // 0x000000018B2D9DB0-0x000000018B2D9E14
		public IBitArray BitNot(); // 0x000000018B2D9D68-0x000000018B2D9DB0
		public static bool operator ==(BitArray64 a, BitArray64 b); // 0x0000000182FB1840-0x0000000182FB1850
		public static bool operator !=(BitArray64 a, BitArray64 b); // 0x0000000182F019D0-0x0000000182F01A10
		public override bool Equals(object obj); // 0x000000018B2D9E14-0x000000018B2D9E74
		public override int GetHashCode(); // 0x0000000184DB9000-0x0000000184DB9010
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray128 : IBitArray // TypeDefIndex: 57039
	{
		// Fields
		[SerializeField]
		private ulong data1; // 0x00
		[SerializeField]
		private ulong data2; // 0x08
	
		// Properties
		public ulong Data1 { get; } // 0x0000000182B76770-0x0000000182B76780 
		public ulong Data2 { get; } // 0x0000000184D88320-0x0000000184D88330 
		public uint capacity { get; } // 0x0000000184DB8E50-0x0000000184DB8E60 
		public bool allFalse { get; } // 0x000000018B2D9000-0x000000018B2D9014 
		public bool allTrue { get; } // 0x000000018B2D9014-0x000000018B2D9028 
		public string humanizedData { get; } // 0x000000018B2D9028-0x000000018B2D91E8 
		public bool this[uint index] { get => default; set {} } // 0x0000000185392684-0x0000000185392698 0x0000000185392698-0x00000001853926C0
	
		// Constructors
		public BitArray128(ulong initValue1, ulong initValue2); // 0x0000000184D861B0-0x0000000184D861C0
		public BitArray128(IEnumerable<uint> bitIndexTrue); // 0x00000001837DB200-0x00000001837DB2C0
	
		// Methods
		public static BitArray128 operator ~(BitArray128 a); // 0x0000000184DB8EA0-0x0000000184DB8EC0
		public static BitArray128 operator |(BitArray128 a, BitArray128 b); // 0x0000000184DB8E80-0x0000000184DB8EA0
		public static BitArray128 operator &(BitArray128 a, BitArray128 b); // 0x0000000184DB8E60-0x0000000184DB8E80
		public IBitArray BitAnd(IBitArray other); // 0x000000018B2D8E00-0x000000018B2D8E94
		public IBitArray BitOr(IBitArray other); // 0x000000018B2D8EF4-0x000000018B2D8F88
		public IBitArray BitNot(); // 0x000000018B2D8E94-0x000000018B2D8EF4
		public static bool operator ==(BitArray128 a, BitArray128 b); // 0x00000001867C4D3C-0x00000001867C4D54
		public static bool operator !=(BitArray128 a, BitArray128 b); // 0x00000001867C4D54-0x00000001867C4D6C
		public override bool Equals(object obj); // 0x000000018B2D8F88-0x000000018B2D9000
		public override int GetHashCode(); // 0x0000000184DB8E20-0x0000000184DB8E50
	}

	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray256 : IBitArray // TypeDefIndex: 57040
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
		public uint capacity { get; } // 0x0000000184DB8F10-0x0000000184DB8F20 
		public bool allFalse { get; } // 0x000000018B2D95A8-0x000000018B2D95C8 
		public bool allTrue { get; } // 0x000000018B2D95C8-0x000000018B2D95E8 
		public string humanizedData { get; } // 0x000000018B2D95E8-0x000000018B2D98B4 
		public bool this[uint index] { get => default; set {} } // 0x000000018B2D9574-0x000000018B2D95A8 0x000000018B2D9924-0x000000018B2D9960
	
		// Constructors
		public BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4); // 0x0000000184D861C0-0x0000000184D861E0
		public BitArray256(IEnumerable<uint> bitIndexTrue); // 0x000000018B2D9480-0x000000018B2D9574
	
		// Methods
		public static BitArray256 operator ~(BitArray256 a); // 0x0000000184DB8FA0-0x0000000184DB8FD0
		public static BitArray256 operator |(BitArray256 a, BitArray256 b); // 0x0000000184DB8F60-0x0000000184DB8FA0
		public static BitArray256 operator &(BitArray256 a, BitArray256 b); // 0x0000000184DB8F20-0x0000000184DB8F60
		public IBitArray BitAnd(IBitArray other); // 0x000000018B2D91E8-0x000000018B2D92A8
		public IBitArray BitOr(IBitArray other); // 0x000000018B2D9318-0x000000018B2D93D8
		public IBitArray BitNot(); // 0x000000018B2D92A8-0x000000018B2D9318
		public static bool operator ==(BitArray256 a, BitArray256 b); // 0x000000018B2D98B4-0x000000018B2D98EC
		public static bool operator !=(BitArray256 a, BitArray256 b); // 0x000000018B2D98EC-0x000000018B2D9924
		public override bool Equals(object obj); // 0x000000018B2D93D8-0x000000018B2D9480
		public override int GetHashCode(); // 0x0000000184DB8EC0-0x0000000184DB8F10
	}

	public static class BitArrayUtilities // TypeDefIndex: 57041
	{
		// Methods
		public static bool Get8(uint index, byte data); // 0x000000018B2DA0B4-0x000000018B2DA0CC
		public static bool Get16(uint index, ushort data); // 0x000000018489D0A0-0x000000018489D0C0
		public static bool Get32(uint index, uint data); // 0x000000018690DAE4-0x000000018690DAF4
		public static bool Get64(uint index, ulong data); // 0x000000018B2DA0A0-0x000000018B2DA0B4
		public static bool Get128(uint index, ulong data1, ulong data2); // 0x0000000183A3D9D0-0x0000000183A3DA00
		public static bool Get256(uint index, ulong data1, ulong data2, ulong data3, ulong data4); // 0x000000018B2DA060-0x000000018B2DA0A0
		public static void Set8(uint index, ref byte data, bool value); // 0x000000018B2DA168-0x000000018B2DA180
		public static void Set16(uint index, ref ushort data, bool value); // 0x0000000184489110-0x0000000184489130
		public static void Set32(uint index, ref uint data, bool value); // 0x000000018B2DA134-0x000000018B2DA14C
		public static void Set64(uint index, ref ulong data, bool value); // 0x000000018B2DA14C-0x000000018B2DA168
		public static void Set128(uint index, ref ulong data1, ref ulong data2, bool value); // 0x0000000183B201E0-0x0000000183B20210
		public static void Set256(uint index, ref ulong data1, ref ulong data2, ref ulong data3, ref ulong data4, bool value); // 0x000000018B2DA0CC-0x000000018B2DA134
	}

	public static class Blitter // TypeDefIndex: 57043
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
		private static class BlitShaderIDs // TypeDefIndex: 57042
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
			static BlitShaderIDs(); // 0x000000018B2DA180-0x000000018B2DA2FC
		}
	
		// Constructors
		static Blitter(); // 0x0000000184D22230-0x0000000184D222C0
	
		// Methods
		public static void Initialize(Shader blitPS, Shader blitColorAndDepthPS, Shader blitMotionVectorPS, Shader lowResBlitPS); // 0x0000000184775980-0x0000000184775CF0
		public static void Cleanup(); // 0x00000001837DC4E0-0x00000001837DC750
		public static Material GetBlitMaterial(bool isFP32Output, TextureDimension dimension, bool singleSlice = false /* Metadata: 0x023495C7 */); // 0x0000000183D24420-0x0000000183D244D0
		public static Material GetBlitColorAndDepth(bool isFP32Output); // 0x000000018B2DC374-0x000000018B2DC3C4
		public static Material GetBlitMotionVectorMaterial(); // 0x000000018B2DC3C4-0x000000018B2DC414
		public static Material GetLowResBlitMaterial(); // 0x000000018B2DC414-0x000000018B2DC464
		private static void DrawTriangle(CommandBuffer cmd, Material material, int shaderPass); // 0x000000018B2DC1AC-0x000000018B2DC374
		internal static void DrawQuad(CommandBuffer cmd, Material material, int shaderPass); // 0x000000018B2DBFE0-0x000000018B2DC1AC
		public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear); // 0x000000018B2DBEB8-0x000000018B2DBFE0
		public static void BlitTexture2D(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear); // 0x000000018B2DBC84-0x000000018B2DBD98
		public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass); // 0x000000018B2DBD98-0x000000018B2DBEB8
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f /* Metadata: 0x023495C8 */, bool bilinear = false /* Metadata: 0x023495CC */); // 0x000000018B2DA4A0-0x000000018B2DA644
		public static void BlitCameraTexture2D(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0f /* Metadata: 0x023495CD */, bool bilinear = false /* Metadata: 0x023495D1 */); // 0x000000018B2DA2FC-0x000000018B2DA4A0
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material, int pass); // 0x000000018B2DA8C8-0x000000018B2DAA58
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Vector4 scaleBias, float mipLevel = 0f /* Metadata: 0x023495D2 */, bool bilinear = false /* Metadata: 0x023495D6 */); // 0x000000018B2DA7FC-0x000000018B2DA8C8
		public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect destViewport, float mipLevel = 0f /* Metadata: 0x023495D7 */, bool bilinear = false /* Metadata: 0x023495DB */); // 0x000000018B2DA644-0x000000018B2DA7FC
		public static void BlitQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear); // 0x000000018B2DBAC0-0x000000018B2DBC84
		public static void BlitQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels); // 0x000000018B2DB7F8-0x000000018B2DBAC0
		public static void BlitQuadWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels); // 0x000000018B2DB530-0x000000018B2DB7F8
		public static void BlitOctahedralWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels); // 0x000000018B2DB0A0-0x000000018B2DB2EC
		public static void BlitOctahedralWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels); // 0x000000018B2DAE54-0x000000018B2DB0A0
		public static void BlitCubeToOctahedral2DQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex); // 0x000000018B2DACA0-0x000000018B2DAE54
		public static void BlitCubeToOctahedral2DQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex); // 0x000000018B2DAA58-0x000000018B2DACA0
		public static void BlitQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex); // 0x000000018B2DB2EC-0x000000018B2DB530
		[CompilerGenerated]
		internal static Vector3[] _Initialize_g__GetFullScreenTriangleVertexPosition_10_0(float z); // 0x000000018B2DC55C-0x000000018B2DC628
		[CompilerGenerated]
		internal static Vector2[] _Initialize_g__GetFullScreenTriangleTexCoord_10_1(); // 0x000000018B2DC464-0x000000018B2DC55C
		[CompilerGenerated]
		internal static Vector3[] _Initialize_g__GetQuadVertexPosition_10_2(float z); // 0x000000018B2DC6F0-0x000000018B2DC7B0
		[CompilerGenerated]
		internal static Vector2[] _Initialize_g__GetQuadTexCoord_10_3(); // 0x000000018B2DC628-0x000000018B2DC6F0
	}

	public static class CameraCaptureBridge // TypeDefIndex: 57044
	{
		// Fields
		private static Dictionary<Camera, HashSet<Action<RenderTargetIdentifier, CommandBuffer>>> actionDict; // 0x00
		private static bool _enabled; // 0x08
	
		// Properties
		public static bool enabled { get; set; } // 0x000000018B2DC9CC-0x000000018B2DCA1C 0x000000018B2DCA1C-0x000000018B2DCA70
	
		// Constructors
		static CameraCaptureBridge(); // 0x0000000184D18A80-0x0000000184D18B10
	
		// Methods
		public static IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> GetCaptureActions(Camera camera); // 0x000000018324C8D0-0x000000018324C990
		public static void AddCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action); // 0x000000018B2DC7B0-0x000000018B2DC8F4
		public static void RemoveCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action); // 0x000000018B2DC8F4-0x000000018B2DC9CC
	}

	public static class ColorUtils // TypeDefIndex: 57045
	{
		// Fields
		public static float s_LightMeterCalibrationConstant; // 0x00
		public static float s_LensAttenuation; // 0x04
	
		// Properties
		public static float lensImperfectionExposureScale { get; } // 0x000000018B2DD54C-0x000000018B2DD5B0 
	
		// Constructors
		static ColorUtils(); // 0x0000000184D5E270-0x0000000184D5E2C0
	
		// Methods
		public static float StandardIlluminantY(float x); // 0x0000000184DB9180-0x0000000184DB91B0
		public static Vector3 CIExyToLMS(float x, float y); // 0x000000018B2DCA90-0x000000018B2DCB20
		public static Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint); // 0x000000018B2DCB20-0x000000018B2DCC34
		public static ValueTuple<Vector4, Vector4, Vector4> PrepareShadowsMidtonesHighlights([IsReadOnly] in Vector4 inShadows, [IsReadOnly] in Vector4 inMidtones, [IsReadOnly] in Vector4 inHighlights); // 0x000000018B2DD168-0x000000018B2DD3C8
		public static ValueTuple<Vector4, Vector4, Vector4> PrepareLiftGammaGain([IsReadOnly] in Vector4 inLift, [IsReadOnly] in Vector4 inGamma, [IsReadOnly] in Vector4 inGain); // 0x000000018B2DCDE4-0x000000018B2DD168
		public static ValueTuple<Vector4, Vector4> PrepareSplitToning([IsReadOnly] in Vector4 inShadows, [IsReadOnly] in Vector4 inHighlights, float balance); // 0x000000018B2DD3C8-0x000000018B2DD454
		public static float Luminance([IsReadOnly] in UnityEngine.Color color); // 0x0000000184DB9150-0x0000000184DB9180
		public static float ComputeEV100(float aperture, float shutterSpeed, float ISO); // 0x000000018B2DCC9C-0x000000018B2DCCC0
		public static float ConvertEV100ToExposure(float EV100); // 0x000000018B2DCD0C-0x000000018B2DCD80
		public static float ConvertExposureToEV100(float exposure); // 0x000000018B2DCD80-0x000000018B2DCDE4
		public static float ComputeEV100FromAvgLuminance(float avgLuminance); // 0x000000018B2DCC34-0x000000018B2DCC9C
		public static float ComputeISO(float aperture, float shutterSpeed, float targetEV100); // 0x000000018B2DCCC0-0x000000018B2DCD0C
		public static uint ToHex(UnityEngine.Color c); // 0x000000018B2DD454-0x000000018B2DD4D4
		public static UnityEngine.Color ToRGBA(uint hex); // 0x000000018B2DD4D4-0x000000018B2DD54C
	}

	public static class CoreMatrixUtils // TypeDefIndex: 57046
	{
		// Methods
		public static void MatrixTimesTranslation(ref Matrix4x4 inOutMatrix, Vector3 translation); // 0x0000000184DB91B0-0x0000000184DB9240
		public static void TranslationTimesMatrix(ref Matrix4x4 inOutMatrix, Vector3 translation); // 0x0000000184DB9680-0x0000000184DB9770
		public static Matrix4x4 MultiplyPerspectiveMatrix(Matrix4x4 perspective, Matrix4x4 rhs); // 0x0000000184DB9530-0x0000000184DB9680
		private static Matrix4x4 MultiplyOrthoMatrixCentered(Matrix4x4 ortho, Matrix4x4 rhs); // 0x0000000184DB93F0-0x0000000184DB9530
		private static Matrix4x4 MultiplyGenericOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs); // 0x0000000184DB9240-0x0000000184DB93F0
		public static Matrix4x4 MultiplyOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs, bool centered); // 0x000000018B2DD5B0-0x000000018B2DD6A0
		public static Matrix4x4 MultiplyProjectionMatrix(Matrix4x4 projMatrix, Matrix4x4 rhs, bool orthoCentered); // 0x000000018B2DD6A0-0x000000018B2DD790
	}

	public static class CoreUtils // TypeDefIndex: 57051
	{
		// Fields
		public static readonly Vector3[] lookAtList; // 0x00
		public static readonly Vector3[] upVectorList; // 0x08
		private const string obsoletePriorityMessage = "Use CoreUtils.Priorities instead"; // Metadata: 0x0234961B
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority1 = 320; // Metadata: 0x0234963C
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority2 = 331; // Metadata: 0x0234963E
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority3 = 342; // Metadata: 0x02349640
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int editMenuPriority4 = 353; // Metadata: 0x02349642
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int assetCreateMenuPriority1 = 230; // Metadata: 0x02349644
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int assetCreateMenuPriority2 = 241; // Metadata: 0x02349646
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int assetCreateMenuPriority3 = 300; // Metadata: 0x02349648
		[Obsolete("Use CoreUtils.Priorities instead", false)]
		public const int gameObjectMenuPriority = 10; // Metadata: 0x0234964A
		private static Cubemap m_BlackCubeTexture; // 0x10
		private static Cubemap m_MagentaCubeTexture; // 0x18
		private static CubemapArray m_MagentaCubeTextureArray; // 0x20
		private static Cubemap m_WhiteCubeTexture; // 0x28
		private static RenderTexture m_EmptyUAV; // 0x30
		private static Texture3D m_BlackVolumeTexture; // 0x38
		private static IEnumerable<System.Type> m_AssemblyTypes; // 0x40
	
		// Properties
		public static Cubemap blackCubeTexture { get; } // 0x000000018B2E03DC-0x000000018B2E0570 
		public static Cubemap magentaCubeTexture { get; } // 0x000000018B2E0A38-0x000000018B2E0BCC 
		public static CubemapArray magentaCubeTextureArray { get; } // 0x000000018B2E0868-0x000000018B2E0A38 
		public static Cubemap whiteCubeTexture { get; } // 0x000000018B2E0BCC-0x000000018B2E0D60 
		public static RenderTexture emptyUAV { get; } // 0x000000018B2E0720-0x000000018B2E0868 
		public static Texture3D blackVolumeTexture { get; } // 0x000000018B2E0570-0x000000018B2E0720 
	
		// Nested types
		public static class Sections // TypeDefIndex: 57047
		{
			// Fields
			public const int section1 = 10000; // Metadata: 0x0234964B
			public const int section2 = 20000; // Metadata: 0x0234964F
			public const int section3 = 30000; // Metadata: 0x02349653
			public const int section4 = 40000; // Metadata: 0x02349657
			public const int section5 = 50000; // Metadata: 0x0234965B
			public const int section6 = 60000; // Metadata: 0x0234965F
			public const int section7 = 70000; // Metadata: 0x02349663
			public const int section8 = 80000; // Metadata: 0x02349667
		}
	
		public static class Priorities // TypeDefIndex: 57048
		{
			// Fields
			public const int assetsCreateShaderMenuPriority = 83; // Metadata: 0x0234966B
			public const int assetsCreateRenderingMenuPriority = 308; // Metadata: 0x0234966D
			public const int editMenuPriority = 320; // Metadata: 0x0234966F
			public const int gameObjectMenuPriority = 10; // Metadata: 0x02349671
			public const int srpLensFlareMenuPriority = 303; // Metadata: 0x02349672
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 57049
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Assembly, IEnumerable<System.Type>> __9__81_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D44A70-0x0000000184D44AD0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal IEnumerable<System.Type> _GetAllAssemblyTypes_b__81_0(Assembly t); // 0x0000000183B0F0B0-0x0000000183B0F100
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__82<T> // TypeDefIndex: 57050
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
		static CoreUtils(); // 0x00000001848B65E0-0x00000001848B6810
	
		// Methods
		public static void ClearRenderTarget(CommandBuffer cmd, ClearFlag clearFlag, UnityEngine.Color clearColor); // 0x000000018B2DD8E0-0x000000018B2DD920
		private static int FixupDepthSlice(int depthSlice, RTHandle buffer); // 0x000000018B2DE678-0x000000018B2DE6BC
		private static int FixupDepthSlice(int depthSlice, CubemapFace cubemapFace); // 0x000000018B2DE668-0x000000018B2DE678
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel = 0 /* Metadata: 0x023495DC */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x023495DD */, int depthSlice = -1 /* Metadata: 0x023495DE */); // 0x000000018B2DF178-0x000000018B2DF258
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag = ClearFlag.None /* Metadata: 0x023495DF */, int miplevel = 0 /* Metadata: 0x023495E0 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x023495E1 */, int depthSlice = -1 /* Metadata: 0x023495E2 */); // 0x000000018B2DF368-0x000000018B2DF43C
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, int miplevel = 0 /* Metadata: 0x023495E3 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x023495E4 */, int depthSlice = -1 /* Metadata: 0x023495E5 */); // 0x000000018B2DFFF8-0x000000018B2E0100
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, int miplevel = 0 /* Metadata: 0x023495E6 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x023495E7 */, int depthSlice = -1 /* Metadata: 0x023495E8 */); // 0x000000018B2DF258-0x000000018B2DF368
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel = 0 /* Metadata: 0x023495E9 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x023495EA */, int depthSlice = -1 /* Metadata: 0x023495EB */); // 0x000000018B2DFA34-0x000000018B2DFB4C
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer); // 0x000000018B2DF0C0-0x000000018B2DF178
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag = ClearFlag.None /* Metadata: 0x023495EC */); // 0x000000018B2DF000-0x000000018B2DF0C0
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, UnityEngine.Color clearColor); // 0x000000018B2DFB4C-0x000000018B2DFC20
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, UnityEngine.Color clearColor); // 0x000000018B2E0100-0x000000018B2E01C8
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag); // 0x000000018B2DFD24-0x000000018B2DFDF0
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, UnityEngine.Color clearColor); // 0x000000018B2DFEDC-0x000000018B2DFFF8
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, UnityEngine.Color clearColor); // 0x000000018B2DF43C-0x000000018B2DF520
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag); // 0x000000018B2DF748-0x000000018B2DF868
		private static void SetViewportAndClear(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, UnityEngine.Color clearColor); // 0x000000018B2E0278-0x000000018B2E0300
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel = 0 /* Metadata: 0x023495ED */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x023495EE */, int depthSlice = -1 /* Metadata: 0x023495EF */); // 0x000000018B2DFC20-0x000000018B2DFD24
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag = ClearFlag.None /* Metadata: 0x023495F0 */, int miplevel = 0 /* Metadata: 0x023495F1 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x023495F2 */, int depthSlice = -1 /* Metadata: 0x023495F3 */); // 0x000000018B2E01C8-0x000000018B2E0278
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, int miplevel = 0 /* Metadata: 0x023495F4 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x023495F5 */, int depthSlice = -1 /* Metadata: 0x023495F6 */); // 0x000000018B2DF61C-0x000000018B2DF748
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, int miplevel = 0 /* Metadata: 0x023495F7 */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x023495F8 */, int depthSlice = -1 /* Metadata: 0x023495F9 */); // 0x000000018B2DEDCC-0x000000018B2DEF00
		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, UnityEngine.Color clearColor, int miplevel = 0 /* Metadata: 0x023495FA */, CubemapFace cubemapFace = CubemapFace.Unknown /* Metadata: 0x023495FB */, int depthSlice = -1 /* Metadata: 0x023495FC */); // 0x000000018B2DF868-0x000000018B2DFA34
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer); // 0x000000018B2DEF00-0x000000018B2DF000
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag = ClearFlag.None /* Metadata: 0x023495FD */); // 0x000000018B2DF520-0x000000018B2DF61C
		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag, UnityEngine.Color clearColor); // 0x000000018B2DFDF0-0x000000018B2DFEDC
		public static void SetViewport(CommandBuffer cmd, RTHandle target); // 0x000000018B2E0300-0x000000018B2E03DC
		public static string GetRenderTargetAutoName(int width, int height, int depth, RenderTextureFormat format, string name, bool mips = false /* Metadata: 0x023495FE */, bool enableMSAA = false /* Metadata: 0x023495FF */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x02349600 */); // 0x00000001837E0EB0-0x00000001837E0FB0
		public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, string name, bool mips = false /* Metadata: 0x02349601 */, bool enableMSAA = false /* Metadata: 0x02349602 */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x02349603 */); // 0x000000018B2DE6E8-0x000000018B2DE7C8
		public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, TextureDimension dim, string name, bool mips = false /* Metadata: 0x02349604 */, bool enableMSAA = false /* Metadata: 0x02349605 */, MSAASamples msaaSamples = MSAASamples.None /* Metadata: 0x02349606 */, bool dynamicRes = false /* Metadata: 0x02349607 */); // 0x00000001837DFB30-0x00000001837DFC40
		private static string GetRenderTargetAutoName(int width, int height, int depth, string format, TextureDimension dim, string name, bool mips, bool enableMSAA, MSAASamples msaaSamples, bool dynamicRes); // 0x00000001837DFC40-0x00000001837DFE00
		public static string GetTextureAutoName(int width, int height, TextureFormat format, TextureDimension dim = TextureDimension.None /* Metadata: 0x02349608 */, string name = "" /* Metadata: 0x02349609 */, bool mips = false /* Metadata: 0x0234960A */, int depth = 0 /* Metadata: 0x0234960B */); // 0x000000018B2DE890-0x000000018B2DE958
		public static string GetTextureAutoName(int width, int height, GraphicsFormat format, TextureDimension dim = TextureDimension.None /* Metadata: 0x0234960C */, string name = "" /* Metadata: 0x0234960D */, bool mips = false /* Metadata: 0x0234960E */, int depth = 0 /* Metadata: 0x0234960F */); // 0x000000018B2DE7C8-0x000000018B2DE890
		private static string GetTextureAutoName(int width, int height, string format, TextureDimension dim = TextureDimension.None /* Metadata: 0x02349610 */, string name = "" /* Metadata: 0x02349611 */, bool mips = false /* Metadata: 0x02349612 */, int depth = 0 /* Metadata: 0x02349613 */); // 0x000000018B2DE958-0x000000018B2DEC54
		public static void ClearCubemap(CommandBuffer cmd, RenderTexture renderTexture, UnityEngine.Color clearColor, bool clearMips = false /* Metadata: 0x02349614 */); // 0x000000018B2DD790-0x000000018B2DD8E0
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x02349615 */); // 0x000000018B2DE0CC-0x000000018B2DE14C
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x02349616 */); // 0x000000018B2DE14C-0x000000018B2DE230
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x02349617 */); // 0x000000018B2DE230-0x000000018B2DE32C
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x02349618 */); // 0x000000018B2DDF14-0x000000018B2DE000
		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, MaterialPropertyBlock properties = null, int shaderPassId = 0 /* Metadata: 0x02349619 */); // 0x000000018B2DE000-0x000000018B2DE0CC
		public static UnityEngine.Color ConvertSRGBToActiveColorSpace(UnityEngine.Color color); // 0x000000018B2DD964-0x000000018B2DD9A8
		public static UnityEngine.Color ConvertLinearToActiveColorSpace(UnityEngine.Color color); // 0x000000018B2DD920-0x000000018B2DD964
		public static Material CreateEngineMaterial(string shaderPath); // 0x000000018B2DDE14-0x000000018B2DDF14
		public static Material CreateEngineMaterial(Shader shader, bool enableInstancing = false /* Metadata: 0x0234961A */); // 0x000000018351F8A0-0x000000018351F980
		public static bool HasFlag<T>(T mask, T flag)
			where T : IConvertible;
		public static void Swap<T>(ref ref T a, ref ref T b);
		public static void SetKeyword(CommandBuffer cmd, string keyword, bool state); // 0x000000018B2DED98-0x000000018B2DEDCC
		public static void SetKeyword(Material material, string keyword, bool state); // 0x000000018690914C-0x0000000186909180
		public static void SetKeyword(ComputeShader cs, string keyword, bool state); // 0x000000018B2DED64-0x000000018B2DED98
		public static void Destroy(UnityEngine.Object obj); // 0x00000001837DD090-0x00000001837DD120
		public static IEnumerable<System.Type> GetAllAssemblyTypes(); // 0x0000000183B0CFF0-0x0000000183B0D1D0
		public static IEnumerable<System.Type> GetAllTypesDerivedFrom<T>();
		public static void SafeRelease(ComputeBuffer buffer); // 0x000000018B2DED54-0x000000018B2DED64
		public static Mesh CreateCubeMesh(Vector3 min, Vector3 max); // 0x000000018B2DD9A8-0x000000018B2DDE14
		public static bool ArePostProcessesEnabled(Camera camera); // 0x0000000182FFF600-0x0000000182FFF610
		public static bool AreAnimatedMaterialsEnabled(Camera camera); // 0x0000000182FFF600-0x0000000182FFF610
		public static bool IsSceneLightingDisabled(Camera camera); // 0x00000001812081B0-0x0000000181208610
		public static bool IsLightOverlapDebugEnabled(Camera camera); // 0x00000001812081B0-0x0000000181208610
		public static bool IsSceneViewFogEnabled(Camera camera); // 0x0000000182FFF600-0x0000000182FFF610
		public static bool IsSceneFilteringEnabled(); // 0x00000001812081B0-0x0000000181208610
		public static bool IsSceneViewPrefabStageContextHidden(); // 0x00000001812081B0-0x0000000181208610
		[Obsolete("Use the updated RendererList API in the UnityEngine.Rendering.RendererUtils namespace.")]
		public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, UnityEngine.Experimental.Rendering.RendererList rendererList); // 0x000000018B2DE32C-0x000000018B2DE5F0
		public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, UnityEngine.Rendering.RendererUtils.RendererList rendererList); // 0x000000018B2DE5F0-0x000000018B2DE668
		public static int GetTextureHash(Texture texture); // 0x000000018B2DEC54-0x000000018B2DED20
		public static int PreviousPowerOfTwo(int size); // 0x000000018B2DED20-0x000000018B2DED54
		public static T GetLastEnumValue<T>()
			where T : Enum;
		internal static string GetCorePath(); // 0x000000018B2DE6BC-0x000000018B2DE6E8
	}

	public static class DelegateUtility // TypeDefIndex: 57052
	{
		// Methods
		public static Delegate Cast(Delegate source, System.Type type); // 0x000000018B2E321C-0x000000018B2E335C
	}

	public static class FSRUtils // TypeDefIndex: 57054
	{
		// Fields
		internal const float kMaxSharpnessStops = 2.5f; // Metadata: 0x0234967C
		public const float kDefaultSharpnessStops = 0.2f; // Metadata: 0x02349680
		public const float kDefaultSharpnessLinear = 0.92f; // Metadata: 0x02349684
	
		// Nested types
		private static class ShaderConstants // TypeDefIndex: 57053
		{
			// Fields
			public static readonly int _FsrEasuConstants0; // 0x00
			public static readonly int _FsrEasuConstants1; // 0x04
			public static readonly int _FsrEasuConstants2; // 0x08
			public static readonly int _FsrEasuConstants3; // 0x0C
			public static readonly int _FsrRcasConstants; // 0x10
	
			// Constructors
			static ShaderConstants(); // 0x000000018B2E6168-0x000000018B2E6264
		}
	
		// Methods
		public static void SetEasuConstants(CommandBuffer cmd, Vector2 inputViewportSizeInPixels, Vector2 inputImageSizeInPixels, Vector2 outputImageSizeInPixels); // 0x000000018B2E3374-0x000000018B2E3560
		public static void SetRcasConstants(CommandBuffer cmd, float sharpnessStops = 0.2f /* Metadata: 0x02349674 */); // 0x000000018B2E3580-0x000000018B2E365C
		public static void SetRcasConstantsLinear(CommandBuffer cmd, float sharpnessLinear = 0.92f /* Metadata: 0x02349678 */); // 0x000000018B2E3560-0x000000018B2E3580
		public static bool IsSupported(); // 0x000000018B2E335C-0x000000018B2E3374
	}

	public class HableCurve // TypeDefIndex: 57058
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
		public float whitePoint { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85F70-0x0000000184D85F80 0x0000000184D88280-0x0000000184D88290
		public float inverseWhitePoint { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88D40-0x0000000184D88D50 0x0000000184D88D50-0x0000000184D88D60
		public float x0 { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
		public float x1 { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
	
		// Nested types
		public class Segment // TypeDefIndex: 57055
		{
			// Fields
			public float offsetX; // 0x10
			public float offsetY; // 0x14
			public float scaleX; // 0x18
			public float scaleY; // 0x1C
			public float lnA; // 0x20
			public float B; // 0x24
	
			// Constructors
			public Segment(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public float Eval(float x); // 0x000000018B2E6124-0x000000018B2E6168
		}
	
		private struct DirectParams // TypeDefIndex: 57056
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
	
		public class Uniforms // TypeDefIndex: 57057
		{
			// Fields
			private HableCurve parent; // 0x10
	
			// Properties
			public Vector4 curve { get; } // 0x000000018B2E68B8-0x000000018B2E68F0 
			public Vector4 toeSegmentA { get; } // 0x000000018B2E6AD8-0x000000018B2E6B64 
			public Vector4 toeSegmentB { get; } // 0x000000018B2E6B64-0x000000018B2E6BCC 
			public Vector4 midSegmentA { get; } // 0x000000018B2E68F0-0x000000018B2E697C 
			public Vector4 midSegmentB { get; } // 0x000000018B2E697C-0x000000018B2E69E4 
			public Vector4 shoSegmentA { get; } // 0x000000018B2E69E4-0x000000018B2E6A70 
			public Vector4 shoSegmentB { get; } // 0x000000018B2E6A70-0x000000018B2E6AD8 
	
			// Constructors
			internal Uniforms(HableCurve parent); // 0x00000001853908C0-0x00000001853908D0
		}
	
		// Constructors
		public HableCurve(); // 0x000000018B2E3E30-0x000000018B2E3F34
	
		// Methods
		public float Eval(float x); // 0x000000018B2E36CC-0x000000018B2E3734
		public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma); // 0x000000018B2E3C1C-0x000000018B2E3DC0
		private void InitSegments(DirectParams srcParams); // 0x000000018B2E3734-0x000000018B2E3C1C
		private void SolveAB(out float lnA, out float B, float x0, float y0, float m); // 0x000000018B2E3DC0-0x000000018B2E3E30
		private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1); // 0x000000018B2E3684-0x000000018B2E36CC
		private float EvalDerivativeLinearGamma(float m, float b, float g, float x); // 0x0000000184DB97E0-0x0000000184DB9830
	}

	public static class HaltonSequence // TypeDefIndex: 57059
	{
		// Methods
		public static float Get(int index, int radix); // 0x000000018326BFC0-0x000000018326C010
	}

	[Flags]
	[MovedFrom("Utilities")]
	public enum MaterialQuality // TypeDefIndex: 57060
	{
		Low = 1,
		Medium = 2,
		High = 4
	}

	[MovedFrom("Utilities")]
	public static class MaterialQualityUtilities // TypeDefIndex: 57061
	{
		// Fields
		public static string[] KeywordNames; // 0x00
		public static string[] EnumNames; // 0x08
		public static ShaderKeyword[] Keywords; // 0x10
	
		// Constructors
		static MaterialQualityUtilities(); // 0x000000018B2E435C-0x000000018B2E4610
	
		// Methods
		public static MaterialQuality FromIndex(int index); // 0x0000000184D88AF0-0x0000000184D88B00
	
		// Extension methods
		public static MaterialQuality GetHighestQuality(this MaterialQuality levels); // 0x000000018B2E4090-0x000000018B2E4104
		public static MaterialQuality GetClosestQuality(this MaterialQuality availableLevels, MaterialQuality requestedLevel); // 0x000000018B2E3F88-0x000000018B2E4090
		public static void SetGlobalShaderKeywords(this MaterialQuality level); // 0x000000018B2E4104-0x000000018B2E41E0
		public static void SetGlobalShaderKeywords(this MaterialQuality level, CommandBuffer cmd); // 0x000000018B2E41E0-0x000000018B2E42E0
		public static int ToFirstIndex(this MaterialQuality level); // 0x000000018B2E42E0-0x000000018B2E435C
	}

	internal class MeshGizmo : IDisposable // TypeDefIndex: 57063
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
		private struct __c__DisplayClass10_0 // TypeDefIndex: 57062
		{
			// Fields
			public MeshGizmo __4__this; // 0x00
			public UnityEngine.Color color; // 0x08
		}
	
		// Constructors
		public MeshGizmo(int capacity = 0 /* Metadata: 0x0234968B */); // 0x000000018B2E541C-0x000000018B2E5590
		static MeshGizmo(); // 0x000000018B2E53E0-0x000000018B2E541C
	
		// Methods
		public void Clear(); // 0x000000018B2E4FA0-0x000000018B2E501C
		public void AddWireCube(Vector3 center, Vector3 size, UnityEngine.Color color); // 0x000000018B2E465C-0x000000018B2E4FA0
		private void DrawMesh(Matrix4x4 trs, Material mat, MeshTopology topology, CompareFunction depthTest, string gizmoName); // 0x000000018B2E506C-0x000000018B2E522C
		public void RenderWireframe(Matrix4x4 trs, CompareFunction depthTest = CompareFunction.LessEqual /* Metadata: 0x0234968C */, string gizmoName = null); // 0x000000018B2E522C-0x000000018B2E5280
		public void Dispose(); // 0x000000018B2E501C-0x000000018B2E506C
		[CompilerGenerated]
		private void _AddWireCube_g__AddEdge_10_0(Vector3 p1, Vector3 p2, ref __c__DisplayClass10_0 param_00079e8e); // 0x000000018B2E5280-0x000000018B2E53E0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class ReloadAttribute : Attribute // TypeDefIndex: 57065
	{
		// Nested types
		public enum Package // TypeDefIndex: 57064
		{
			Builtin = 0,
			Root = 1
		}
	
		// Constructors
		public ReloadAttribute(string[] paths, Package package = Package.Root /* Metadata: 0x0234968D */); // 0x00000001841E1670-0x00000001841E1680
		public ReloadAttribute(string path, Package package = Package.Root /* Metadata: 0x0234968E */); // 0x000000018B2E5FC0-0x000000018B2E6014
		public ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, Package package = Package.Root /* Metadata: 0x0234968F */); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ReloadGroupAttribute : Attribute // TypeDefIndex: 57066
	{
		// Constructors
		public ReloadGroupAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class TextureCurve : IDisposable // TypeDefIndex: 57067
	{
		// Fields
		private const int k_Precision = 128; // Metadata: 0x02349692
		private const float k_Step = 0.0078125f; // Metadata: 0x02349694
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
		public int length { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		public Keyframe this[int index] { get => default; } // 0x000000018B2E6588-0x000000018B2E65CC 
	
		// Constructors
		public TextureCurve(AnimationCurve baseCurve, float zeroValue, bool loop, [IsReadOnly] in Vector2 bounds); // 0x000000018B2E6524-0x000000018B2E6588
		public TextureCurve(Keyframe[] keys, float zeroValue, bool loop, [IsReadOnly] in Vector2 bounds); // 0x00000001839C5760-0x00000001839C5840
	
		// Methods
		public bool IsTextureCurveDirty(); // 0x0000000183C06DA0-0x0000000183C06DD0
		~TextureCurve(); // 0x000000018421C210-0x000000018421C230
		[Obsolete("Please use Release() instead.")]
		public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
		public void Release(); // 0x00000001837DC8B0-0x00000001837DC920
		public void SetDirty(); // 0x0000000184DB9870-0x0000000184DB9880
		private static GraphicsFormat GetTextureFormat(); // 0x00000001837E0A50-0x00000001837E0A80
		public Texture2D GetTexture(); // 0x00000001837E07A0-0x00000001837E09B0
		public float Evaluate(float time); // 0x00000001837E09B0-0x00000001837E0A50
		public int AddKey(float time, float value); // 0x000000018B2E6448-0x000000018B2E647C
		public int MoveKey(int index, [IsReadOnly] in Keyframe key); // 0x000000018B2E647C-0x000000018B2E64CC
		public void RemoveKey(int index); // 0x000000018B2E64CC-0x000000018B2E64F8
		public void SmoothTangents(int index, float weight); // 0x000000018B2E64F8-0x000000018B2E6524
	}

	[Serializable]
	public class TextureCurveParameter : VolumeParameter<TextureCurve> // TypeDefIndex: 57068
	{
		// Constructors
		public TextureCurveParameter(TextureCurve value, bool overrideState = false /* Metadata: 0x02349698 */); // 0x00000001839C5700-0x00000001839C5760
	
		// Methods
		public override void Release(); // 0x00000001837DC890-0x00000001837DC8B0
	}

	public static class TileLayoutUtils // TypeDefIndex: 57069
	{
		// Methods
		public static bool TryLayoutByTiles(RectInt src, uint tileSize, out RectInt main, out RectInt topRow, out RectInt rightCol, out RectInt topRight); // 0x000000018B2E6770-0x000000018B2E686C
		public static bool TryLayoutByRow(RectInt src, uint tileSize, out RectInt main, out RectInt other); // 0x000000018B2E66FC-0x000000018B2E6770
		public static bool TryLayoutByCol(RectInt src, uint tileSize, out RectInt main, out RectInt other); // 0x000000018B2E668C-0x000000018B2E66FC
	}

	public static class XRUtils // TypeDefIndex: 57070
	{
		// Methods
		public static void DrawOcclusionMesh(CommandBuffer cmd, Camera camera, bool stereoEnabled = true /* Metadata: 0x02349699 */); // 0x000000018B2E7AA4-0x000000018B2E7B3C
	}

	public interface IVolume // TypeDefIndex: 57071
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
	public class Volume : MonoBehaviour, IVolume // TypeDefIndex: 57072
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
		public bool isGlobal { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public List<Collider> colliders { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		internal VolumeProfile profileRef { get; } // 0x0000000182FC7110-0x0000000182FC71A0 
	
		// Constructors
		public Volume(); // 0x000000018395B350-0x000000018395B3F0
	
		// Methods
		public VolumeProfile GetInstantiatedProfile(); // 0x000000018B2E7768-0x000000018B2E79BC
		public void SetInstantiatedProfile(VolumeProfile profile); // 0x0000000182FDAEA0-0x0000000182FDAEB0
		public bool HasInstantiatedProfile(); // 0x000000018B2E79BC-0x000000018B2E7A0C
		private void OnEnable(); // 0x0000000184255790-0x0000000184255840
		private void OnDisable(); // 0x0000000184255700-0x0000000184255790
		private void Update(); // 0x00000001831C4890-0x00000001831C4980
		internal void UpdateLayer(); // 0x00000001831C4980-0x00000001831C4A00
		public void Play(); // 0x0000000184DA7440-0x0000000184DA7450
		public void Stop(); // 0x0000000184DB98D0-0x0000000184DB98E0
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class VolumeComponentMenu : Attribute // TypeDefIndex: 57073
	{
		// Fields
		public readonly string menu; // 0x10
	
		// Constructors
		public VolumeComponentMenu(string menu); // 0x00000001853908C0-0x00000001853908D0
	}

	public class VolumeComponentMenuForRenderPipeline : VolumeComponentMenu // TypeDefIndex: 57074
	{
		// Fields
		[CompilerGenerated]
		private readonly System.Type[] _pipelineTypes_k__BackingField; // 0x18
	
		// Properties
		public System.Type[] pipelineTypes { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
	
		// Constructors
		public VolumeComponentMenuForRenderPipeline(string menu, params System.Type[] pipelineTypes); // 0x000000018B2E6BCC-0x000000018B2E6D98
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Obsolete("VolumeComponentDeprecated has been deprecated (UnityUpgradable) -> [UnityEngine] UnityEngine.HideInInspector", false)]
	public sealed class VolumeComponentDeprecated : Attribute // TypeDefIndex: 57075
	{
		// Constructors
		public VolumeComponentDeprecated(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class MigratingVolumeComponent : Attribute // TypeDefIndex: 57076
	{
		// Constructors
		public MigratingVolumeComponent(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class VolumeComponent : ScriptableObject // TypeDefIndex: 57079
	{
		// Fields
		public bool active; // 0x18
		[CompilerGenerated]
		private string _displayName_k__BackingField; // 0x20
		[CompilerGenerated]
		private VolumeParameter[] _parameters_k__BackingField; // 0x28
	
		// Properties
		public string displayName { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public VolumeParameter[] parameters { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
	
		// Nested types
		public sealed class Indent : PropertyAttribute // TypeDefIndex: 57077
		{
			// Fields
			public readonly int relativeAmount; // 0x10
	
			// Constructors
			public Indent(int relativeAmount = 1 /* Metadata: 0x0234969A */); // 0x00000001814F51F0-0x00000001814F5220
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 57078
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Reflection.FieldInfo, int> __9__10_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D4A770-0x0000000184D4A7D0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _FindParameters_b__10_0(System.Reflection.FieldInfo t); // 0x0000000183E64790-0x0000000183E647B0
		}
	
		// Constructors
		public VolumeComponent(); // 0x0000000183573680-0x00000001835736B0
	
		// Methods
		internal static void FindParameters(object o, List<VolumeParameter> parameters, Func<System.Reflection.FieldInfo, bool> filter = null); // 0x00000001835938A0-0x0000000183593CD0
		protected virtual void OnEnable(); // 0x0000000182FC49F0-0x0000000182FC4AB0
		protected virtual void OnDisable(); // 0x0000000182FC4950-0x0000000182FC4980
		public virtual void Override(VolumeComponent state, float interpFactor); // 0x0000000182FC5B80-0x0000000182FC67F0
		public void SetAllOverridesTo(bool state); // 0x0000000182FC4340-0x0000000182FC4350
		internal void SetOverridesTo(IEnumerable<VolumeParameter> enumerable, bool state); // 0x0000000182FC4110-0x0000000182FC4340
		public override int GetHashCode(); // 0x000000018B2E6D98-0x000000018B2E6E04
		protected virtual void OnDestroy(); // 0x0000000182FC4830-0x0000000182FC4840
		public void Release(); // 0x0000000182FC4980-0x0000000182FC49F0
	}

	public sealed class VolumeManager // TypeDefIndex: 57081
	{
		// Fields
		private static readonly Lazy<VolumeManager> s_Instance; // 0x00
		[CompilerGenerated]
		private VolumeStack _stack_k__BackingField; // 0x10
		[CompilerGenerated]
		private System.Type[] _baseComponentTypeArray_k__BackingField; // 0x18
		private const int k_MaxLayerCount = 32; // Metadata: 0x0234969B
		private readonly Dictionary<int, List<UnityEngine.Rendering.Volume>> m_SortedVolumes; // 0x20
		private readonly List<UnityEngine.Rendering.Volume> m_Volumes; // 0x28
		private readonly Dictionary<int, bool> m_SortNeeded; // 0x30
		private readonly List<VolumeComponent> m_ComponentsDefaultState; // 0x38
		private readonly List<Collider> m_TempColliders; // 0x40
		private VolumeStack m_DefaultStack; // 0x48
	
		// Properties
		public static VolumeManager instance { get; } // 0x0000000183450900-0x0000000183450950 
		public VolumeStack stack { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		[Obsolete("Please use baseComponentTypeArray instead.")]
		public IEnumerable<System.Type> baseComponentTypes { get; private set; } // 0x000000018385B100-0x000000018385B110 0x000000018B2E7218-0x000000018B2E726C
		public System.Type[] baseComponentTypeArray { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 57080
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, bool> __9__25_0; // 0x08
			public static Predicate<UnityEngine.Rendering.Volume> __9__38_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000184D4C330-0x0000000184D4C390
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _ReloadBaseTypes_b__25_0(System.Type t); // 0x00000001847039E0-0x0000000184703A10
			internal bool _GetVolumes_b__38_0(UnityEngine.Rendering.Volume v); // 0x000000018B2E686C-0x000000018B2E68B8
			internal VolumeManager _.cctor_b__42_0(); // 0x00000001846FE1E0-0x00000001846FE230
		}
	
		// Constructors
		private VolumeManager(); // 0x00000001846FE230-0x00000001846FE410
		static VolumeManager(); // 0x0000000184B705A0-0x0000000184B706B0
	
		// Methods
		public VolumeStack CreateStack(); // 0x0000000182FC44D0-0x0000000182FC4540
		public void ResetMainStack(); // 0x000000018B2E71A0-0x000000018B2E71B4
		public void DestroyStack(VolumeStack stack); // 0x0000000184D39BD0-0x0000000184D39BF0
		private void ReloadBaseTypes(); // 0x0000000182FC45C0-0x0000000182FC4830
		public void Register(UnityEngine.Rendering.Volume volume, int layer); // 0x00000001842559C0-0x0000000184255BB0
		public void Unregister(UnityEngine.Rendering.Volume volume, int layer); // 0x0000000184255840-0x00000001842559C0
		public bool IsComponentActiveInMask<T>(LayerMask layerMask)
			where T : VolumeComponent;
		internal void SetLayerDirty(int layer); // 0x0000000184255BB0-0x0000000184255D60
		internal void UpdateVolumeLayer(UnityEngine.Rendering.Volume volume, int prevLayer, int newLayer); // 0x000000018B2E71B4-0x000000018B2E71F4
		private void OverrideData(VolumeStack stack, List<VolumeComponent> components, float interpFactor); // 0x0000000182FC58F0-0x0000000182FC5A60
		private void ReplaceData(VolumeStack stack); // 0x00000001831B7B60-0x00000001831B7F30
		[Conditional("UNITY_EDITOR")]
		public void CheckBaseTypes(); // 0x000000018B2E6E04-0x000000018B2E6E9C
		[Conditional("UNITY_EDITOR")]
		public void CheckStack(VolumeStack stack); // 0x000000018B2E6E9C-0x000000018B2E7064
		private bool CheckUpdateRequired(VolumeStack stack); // 0x0000000183D52330-0x0000000183D52360
		public void Update(Transform trigger, LayerMask layerMask); // 0x000000018B2E71F4-0x000000018B2E7218
		public void Update(VolumeStack stack, Transform trigger, LayerMask layerMask); // 0x0000000182FC67F0-0x0000000182FC7110
		public UnityEngine.Rendering.Volume[] GetVolumes(LayerMask layerMask); // 0x000000018B2E7064-0x000000018B2E71A0
		private List<UnityEngine.Rendering.Volume> GrabVolumes(LayerMask mask); // 0x00000001836DB830-0x00000001836DC020
		private static void SortByPriority(List<UnityEngine.Rendering.Volume> volumes); // 0x0000000184331D70-0x0000000184331E90
		private static bool IsVolumeRenderedByCamera(UnityEngine.Rendering.Volume volume, Camera camera); // 0x0000000182FFF600-0x0000000182FFF610
	}

	[Obsolete("VolumeIsolationScope is deprecated, it does not have any effect anymore.")]
	public struct VolumeIsolationScope : IDisposable // TypeDefIndex: 57082
	{
		// Constructors
		public VolumeIsolationScope(bool unused); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
	}

	public abstract class VolumeParameter // TypeDefIndex: 57083
	{
		// Fields
		public const string k_DebuggerDisplay = "{m_Value} ({overrideState})"; // Metadata: 0x0234969C
		[FormerlySerializedAs("m_OverrideState")]
		[SerializeField]
		public bool overrideState; // 0x10
	
		// Constructors
		protected VolumeParameter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		internal abstract void Interp(VolumeParameter from, VolumeParameter to, float t);
		public T GetValue<T>();
		public abstract void SetValue(VolumeParameter parameter);
		protected internal virtual void OnEnable(); // 0x00000001841E1670-0x00000001841E1680
		protected internal virtual void OnDisable(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void Release(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class VolumeParameter<T> : VolumeParameter, IEquatable<VolumeParameter<T>> // TypeDefIndex: 57084
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
	public class BoolParameter : VolumeParameter<bool> // TypeDefIndex: 57085
	{
		// Constructors
		public BoolParameter(bool value, bool overrideState = false /* Metadata: 0x023496B8 */); // 0x0000000184DA0980-0x0000000184DA0990
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class LayerMaskParameter : VolumeParameter<LayerMask> // TypeDefIndex: 57086
	{
		// Constructors
		public LayerMaskParameter(LayerMask value, bool overrideState = false /* Metadata: 0x023496B9 */); // 0x000000018B2E3F34-0x000000018B2E3F88
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class IntParameter : VolumeParameter<int> // TypeDefIndex: 57087
	{
		// Constructors
		public IntParameter(int value, bool overrideState = false /* Metadata: 0x023496BA */); // 0x00000001847A60C0-0x00000001847A6130
	
		// Methods
		public sealed override void Interp(int from, int to, float t); // 0x0000000184DB9830-0x0000000184DB9860
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpIntParameter : VolumeParameter<int> // TypeDefIndex: 57088
	{
		// Constructors
		public NoInterpIntParameter(int value, bool overrideState = false /* Metadata: 0x023496BB */); // 0x000000018B2E59D0-0x000000018B2E5A24
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class MinIntParameter : IntParameter // TypeDefIndex: 57089
	{
		// Fields
		[NonSerialized]
		public int min; // 0x20
	
		// Properties
		public override int value { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x000000018B2E55A0-0x000000018B2E55AC
	
		// Constructors
		public MinIntParameter(int value, int min, bool overrideState = false /* Metadata: 0x023496BC */); // 0x000000018B2E4620-0x000000018B2E4650
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpMinIntParameter : VolumeParameter<int> // TypeDefIndex: 57090
	{
		// Fields
		[NonSerialized]
		public int min; // 0x20
	
		// Properties
		public override int value { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x000000018B2E55A0-0x000000018B2E55AC
	
		// Constructors
		public NoInterpMinIntParameter(int value, int min, bool overrideState = false /* Metadata: 0x023496BD */); // 0x000000018B2E5B40-0x000000018B2E5B9C
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class MaxIntParameter : IntParameter // TypeDefIndex: 57091
	{
		// Fields
		[NonSerialized]
		public int max; // 0x20
	
		// Properties
		public override int value { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x000000018B2E4650-0x000000018B2E465C
	
		// Constructors
		public MaxIntParameter(int value, int max, bool overrideState = false /* Metadata: 0x023496BE */); // 0x000000018B2E4620-0x000000018B2E4650
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpMaxIntParameter : VolumeParameter<int> // TypeDefIndex: 57092
	{
		// Fields
		[NonSerialized]
		public int max; // 0x20
	
		// Properties
		public override int value { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x000000018B2E4650-0x000000018B2E465C
	
		// Constructors
		public NoInterpMaxIntParameter(int value, int max, bool overrideState = false /* Metadata: 0x023496BF */); // 0x000000018B2E5A84-0x000000018B2E5AE0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class ClampedIntParameter : IntParameter // TypeDefIndex: 57093
	{
		// Fields
		[NonSerialized]
		public int min; // 0x20
		[NonSerialized]
		public int max; // 0x24
	
		// Properties
		public override int value { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x000000018B2DCA70-0x000000018B2DCA90
	
		// Constructors
		public ClampedIntParameter(int value, int min, int max, bool overrideState = false /* Metadata: 0x023496C0 */); // 0x0000000185397614-0x0000000185397650
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpClampedIntParameter : VolumeParameter<int> // TypeDefIndex: 57094
	{
		// Fields
		[NonSerialized]
		public int min; // 0x20
		[NonSerialized]
		public int max; // 0x24
	
		// Properties
		public override int value { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x000000018B2DCA70-0x000000018B2DCA90
	
		// Constructors
		public NoInterpClampedIntParameter(int value, int min, int max, bool overrideState = false /* Metadata: 0x023496C1 */); // 0x000000018B2E56CC-0x000000018B2E572C
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class FloatParameter : VolumeParameter<float> // TypeDefIndex: 57095
	{
		// Constructors
		public FloatParameter(float value, bool overrideState = false /* Metadata: 0x023496C2 */); // 0x0000000184DA09C0-0x0000000184DA09D0
	
		// Methods
		public sealed override void Interp(float from, float to, float t); // 0x0000000184DB9770-0x0000000184DB9790
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpFloatParameter : VolumeParameter<float> // TypeDefIndex: 57096
	{
		// Constructors
		public NoInterpFloatParameter(float value, bool overrideState = false /* Metadata: 0x023496C3 */); // 0x000000018B2E5904-0x000000018B2E5960
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class MinFloatParameter : FloatParameter // TypeDefIndex: 57097
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
	
		// Properties
		public override float value { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x000000018B2E5590-0x000000018B2E55A0
	
		// Constructors
		public MinFloatParameter(float value, float min, bool overrideState = false /* Metadata: 0x023496C4 */); // 0x0000000184DB9860-0x0000000184DB9870
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpMinFloatParameter : VolumeParameter<float> // TypeDefIndex: 57098
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
	
		// Properties
		public override float value { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x000000018B2E5590-0x000000018B2E55A0
	
		// Constructors
		public NoInterpMinFloatParameter(float value, float min, bool overrideState = false /* Metadata: 0x023496C5 */); // 0x000000018B2E5AE0-0x000000018B2E5B40
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class MaxFloatParameter : FloatParameter // TypeDefIndex: 57099
	{
		// Fields
		[NonSerialized]
		public float max; // 0x20
	
		// Properties
		public override float value { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x000000018B2E4610-0x000000018B2E4620
	
		// Constructors
		public MaxFloatParameter(float value, float max, bool overrideState = false /* Metadata: 0x023496C6 */); // 0x0000000184DB9860-0x0000000184DB9870
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpMaxFloatParameter : VolumeParameter<float> // TypeDefIndex: 57100
	{
		// Fields
		[NonSerialized]
		public float max; // 0x20
	
		// Properties
		public override float value { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x000000018B2E4610-0x000000018B2E4620
	
		// Constructors
		public NoInterpMaxFloatParameter(float value, float max, bool overrideState = false /* Metadata: 0x023496C7 */); // 0x000000018B2E5A24-0x000000018B2E5A84
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class ClampedFloatParameter : FloatParameter // TypeDefIndex: 57101
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
		[NonSerialized]
		public float sliderExponent; // 0x28
	
		// Properties
		public override float value { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000183EE0E50-0x0000000183EE0E80
	
		// Constructors
		public ClampedFloatParameter(float value, float min, float max, float sliderExponent, bool overrideState = false /* Metadata: 0x023496C8 */); // 0x0000000184DB9050-0x0000000184DB9080
		public ClampedFloatParameter(float value, float min, float max, bool overrideState = false /* Metadata: 0x023496C9 */); // 0x0000000184DB9080-0x0000000184DB90A0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpClampedFloatParameter : VolumeParameter<float> // TypeDefIndex: 57102
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
		[NonSerialized]
		public float sliderExponent; // 0x28
	
		// Properties
		public override float value { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x000000018B2E56A4-0x000000018B2E56CC
	
		// Constructors
		public NoInterpClampedFloatParameter(float value, float min, float max, float sliderExponent, bool overrideState = false /* Metadata: 0x023496CA */); // 0x000000018B2E5624-0x000000018B2E56A4
		public NoInterpClampedFloatParameter(float value, float min, float max, bool overrideState = false /* Metadata: 0x023496CB */); // 0x000000018B2E55AC-0x000000018B2E5624
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class UnclampedFloatParameter : FloatParameter // TypeDefIndex: 57103
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
		[NonSerialized]
		public float sliderExponent; // 0x28
	
		// Properties
		public override float value { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
	
		// Constructors
		public UnclampedFloatParameter(float value, float min, float max, float sliderExponent, bool overrideState = false /* Metadata: 0x023496CC */); // 0x0000000184DB9050-0x0000000184DB9080
		public UnclampedFloatParameter(float value, float min, float max, bool overrideState = false /* Metadata: 0x023496CD */); // 0x0000000184DB9080-0x0000000184DB90A0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpUnclampedFloatParameter : VolumeParameter<float> // TypeDefIndex: 57104
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
		[NonSerialized]
		public float sliderExponent; // 0x28
	
		// Properties
		public override float value { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
	
		// Constructors
		public NoInterpUnclampedFloatParameter(float value, float min, float max, float sliderExponent, bool overrideState = false /* Metadata: 0x023496CE */); // 0x000000018B2E5DC4-0x000000018B2E5E44
		public NoInterpUnclampedFloatParameter(float value, float min, float max, bool overrideState = false /* Metadata: 0x023496CF */); // 0x000000018B2E5E44-0x000000018B2E5EBC
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class FloatRangeParameter : VolumeParameter<Vector2> // TypeDefIndex: 57105
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
	
		// Properties
		public override Vector2 value { get; set; } // 0x0000000184D92340-0x0000000184D92360 0x000000018B2E365C-0x000000018B2E3684
	
		// Constructors
		public FloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false /* Metadata: 0x023496D0 */); // 0x00000001843D42E0-0x00000001843D4360
	
		// Methods
		public override void Interp(Vector2 from, Vector2 to, float t); // 0x0000000184DB9790-0x0000000184DB97E0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpFloatRangeParameter : VolumeParameter<Vector2> // TypeDefIndex: 57106
	{
		// Fields
		[NonSerialized]
		public float min; // 0x20
		[NonSerialized]
		public float max; // 0x24
	
		// Properties
		public override Vector2 value { get; set; } // 0x0000000184D92340-0x0000000184D92360 0x000000018B2E365C-0x000000018B2E3684
	
		// Constructors
		public NoInterpFloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false /* Metadata: 0x023496D1 */); // 0x000000018B2E5960-0x000000018B2E59D0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class ColorParameter : VolumeParameter<UnityEngine.Color> // TypeDefIndex: 57107
	{
		// Fields
		[NonSerialized]
		public bool hdr; // 0x28
		[NonSerialized]
		public bool showAlpha; // 0x29
		[NonSerialized]
		public bool showEyeDropper; // 0x2A
	
		// Constructors
		public ColorParameter(UnityEngine.Color value, bool overrideState = false /* Metadata: 0x023496D2 */); // 0x0000000184DB9130-0x0000000184DB9150
		public ColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false /* Metadata: 0x023496D3 */); // 0x0000000184DB9110-0x0000000184DB9130
	
		// Methods
		public override void Interp(UnityEngine.Color from, UnityEngine.Color to, float t); // 0x0000000184DB90A0-0x0000000184DB9110
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpColorParameter : VolumeParameter<UnityEngine.Color> // TypeDefIndex: 57108
	{
		// Fields
		public bool hdr; // 0x28
		[NonSerialized]
		public bool showAlpha; // 0x29
		[NonSerialized]
		public bool showEyeDropper; // 0x2A
	
		// Constructors
		public NoInterpColorParameter(UnityEngine.Color value, bool overrideState = false /* Metadata: 0x023496D4 */); // 0x000000018B2E572C-0x000000018B2E5784
		public NoInterpColorParameter(UnityEngine.Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false /* Metadata: 0x023496D5 */); // 0x000000018B2E5784-0x000000018B2E57F4
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class Vector2Parameter : VolumeParameter<Vector2> // TypeDefIndex: 57109
	{
		// Constructors
		public Vector2Parameter(Vector2 value, bool overrideState = false /* Metadata: 0x023496D6 */); // 0x0000000184DA09D0-0x0000000184DA09E0
	
		// Methods
		public override void Interp(Vector2 from, Vector2 to, float t); // 0x0000000184DB9790-0x0000000184DB97E0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpVector2Parameter : VolumeParameter<Vector2> // TypeDefIndex: 57110
	{
		// Constructors
		public NoInterpVector2Parameter(Vector2 value, bool overrideState = false /* Metadata: 0x023496D7 */); // 0x000000018B2E5EBC-0x000000018B2E5F18
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class Vector3Parameter : VolumeParameter<Vector3> // TypeDefIndex: 57111
	{
		// Constructors
		public Vector3Parameter(Vector3 value, bool overrideState = false /* Metadata: 0x023496D8 */); // 0x0000000184416260-0x00000001844162C0
	
		// Methods
		public override void Interp(Vector3 from, Vector3 to, float t); // 0x0000000184DB9880-0x0000000184DB98D0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpVector3Parameter : VolumeParameter<Vector3> // TypeDefIndex: 57112
	{
		// Constructors
		public NoInterpVector3Parameter(Vector3 value, bool overrideState = false /* Metadata: 0x023496D9 */); // 0x000000018B2E5F18-0x000000018B2E5F70
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class Vector4Parameter : VolumeParameter<Vector4> // TypeDefIndex: 57113
	{
		// Constructors
		public Vector4Parameter(Vector4 value, bool overrideState = false /* Metadata: 0x023496DA */); // 0x0000000184DA09E0-0x0000000184DA09F0
	
		// Methods
		public override void Interp(Vector4 from, Vector4 to, float t); // 0x0000000184DB90A0-0x0000000184DB9110
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpVector4Parameter : VolumeParameter<Vector4> // TypeDefIndex: 57114
	{
		// Constructors
		public NoInterpVector4Parameter(Vector4 value, bool overrideState = false /* Metadata: 0x023496DB */); // 0x000000018B2E5F70-0x000000018B2E5FC0
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class TextureParameter : VolumeParameter<Texture> // TypeDefIndex: 57115
	{
		// Fields
		public TextureDimension dimension; // 0x20
	
		// Constructors
		public TextureParameter(Texture value, bool overrideState = false /* Metadata: 0x023496DC */); // 0x0000000185397BEC-0x0000000185397C10
		public TextureParameter(Texture value, TextureDimension dimension, bool overrideState = false /* Metadata: 0x023496DD */); // 0x000000018402BF60-0x000000018402BFD0
	
		// Methods
		public override int GetHashCode(); // 0x000000018B2E65CC-0x000000018B2E668C
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpTextureParameter : VolumeParameter<Texture> // TypeDefIndex: 57116
	{
		// Constructors
		public NoInterpTextureParameter(Texture value, bool overrideState = false /* Metadata: 0x023496DE */); // 0x000000018B2E5D6C-0x000000018B2E5DC4
	
		// Methods
		public override int GetHashCode(); // 0x000000018B2E5CAC-0x000000018B2E5D6C
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class Texture2DParameter : VolumeParameter<Texture> // TypeDefIndex: 57117
	{
		// Constructors
		public Texture2DParameter(Texture value, bool overrideState = false /* Metadata: 0x023496DF */); // 0x000000018402D9F0-0x000000018402DA50
	
		// Methods
		public override int GetHashCode(); // 0x000000018B2E62C8-0x000000018B2E6388
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class Texture3DParameter : VolumeParameter<Texture> // TypeDefIndex: 57118
	{
		// Constructors
		public Texture3DParameter(Texture value, bool overrideState = false /* Metadata: 0x023496E0 */); // 0x000000018402C1F0-0x000000018402C250
	
		// Methods
		public override int GetHashCode(); // 0x000000018B2E6388-0x000000018B2E6448
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class RenderTextureParameter : VolumeParameter<RenderTexture> // TypeDefIndex: 57119
	{
		// Constructors
		public RenderTextureParameter(RenderTexture value, bool overrideState = false /* Metadata: 0x023496E1 */); // 0x000000018B2E60CC-0x000000018B2E6124
	
		// Methods
		public override int GetHashCode(); // 0x000000018B2E6014-0x000000018B2E60CC
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpRenderTextureParameter : VolumeParameter<RenderTexture> // TypeDefIndex: 57120
	{
		// Constructors
		public NoInterpRenderTextureParameter(RenderTexture value, bool overrideState = false /* Metadata: 0x023496E2 */); // 0x000000018B2E5C54-0x000000018B2E5CAC
	
		// Methods
		public override int GetHashCode(); // 0x000000018B2E5B9C-0x000000018B2E5C54
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class CubemapParameter : VolumeParameter<Texture> // TypeDefIndex: 57121
	{
		// Constructors
		public CubemapParameter(Texture value, bool overrideState = false /* Metadata: 0x023496E3 */); // 0x000000018402D990-0x000000018402D9F0
	
		// Methods
		public override int GetHashCode(); // 0x000000018B2E0D60-0x000000018B2E0E20
	}

	[Serializable]
	[DebuggerDisplay("{m_Value} ({overrideState})")]
	public class NoInterpCubemapParameter : VolumeParameter<Cubemap> // TypeDefIndex: 57122
	{
		// Constructors
		public NoInterpCubemapParameter(Cubemap value, bool overrideState = false /* Metadata: 0x023496E4 */); // 0x000000018B2E58AC-0x000000018B2E5904
	
		// Methods
		public override int GetHashCode(); // 0x000000018B2E57F4-0x000000018B2E58AC
	}

	[Serializable]
	public class AnimationCurveParameter : VolumeParameter<AnimationCurve> // TypeDefIndex: 57123
	{
		// Constructors
		public AnimationCurveParameter(AnimationCurve value, bool overrideState = false /* Metadata: 0x023496E5 */); // 0x00000001843D4360-0x00000001843D43C0
	}

	public sealed class VolumeProfile : ScriptableObject // TypeDefIndex: 57125
	{
		// Fields
		public List<VolumeComponent> components; // 0x18
		[NonSerialized]
		public bool isDirty; // 0x20
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 57124
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<VolumeComponent> __9__2_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D47890-0x0000000184D478F0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _OnEnable_b__2_0(VolumeComponent x); // 0x000000018463BDE0-0x000000018463BE70
		}
	
		// Constructors
		public VolumeProfile(); // 0x00000001846FE410-0x00000001846FE4A0
	
		// Methods
		private void OnEnable(); // 0x00000001847C4430-0x00000001847C4570
		internal void OnDisable(); // 0x000000018B2E74F0-0x000000018B2E75C0
		public void Reset(); // 0x0000000184D8F6A0-0x0000000184D8F6B0
		public T Add<T>(bool overrides = false /* Metadata: 0x023496E6 */)
			where T : VolumeComponent;
		public VolumeComponent Add(System.Type type, bool overrides = false /* Metadata: 0x023496E7 */); // 0x0000000182FC4400-0x0000000182FC44D0
		public void Remove<T>()
			where T : VolumeComponent;
		public void Remove(System.Type type); // 0x000000018B2E75C0-0x000000018B2E769C
		public bool Has<T>()
			where T : VolumeComponent;
		public bool Has(System.Type type); // 0x0000000182FC5040-0x0000000182FC5150
		public bool HasSubclassOf(System.Type type); // 0x000000018B2E73A4-0x000000018B2E74F0
		public bool TryGet<T>(out ref T component)
			where T : VolumeComponent;
		public bool TryGet<T>(System.Type type, out ref T component)
			where T : VolumeComponent;
		public bool TryGetSubclassOf<T>(System.Type type, out ref T component)
			where T : VolumeComponent;
		public bool TryGetAllSubclassOf<T>(System.Type type, List<T> result)
			where T : VolumeComponent;
		public override int GetHashCode(); // 0x000000018B2E7310-0x000000018B2E73A4
		internal int GetComponentListHashCode(); // 0x000000018B2E726C-0x000000018B2E7310
		internal void Sanitize(); // 0x000000018B2E769C-0x000000018B2E7768
	}

	public sealed class VolumeStack : IDisposable // TypeDefIndex: 57126
	{
		// Fields
		internal readonly Dictionary<System.Type, VolumeComponent> components; // 0x10
		[TupleElementNames(new string[2] {"parameter", "defaultValue" })]
		public ValueTuple<VolumeParameter, VolumeParameter>[] defaultParameters; // 0x18
		internal bool requiresReset; // 0x20
	
		// Constructors
		internal VolumeStack(); // 0x0000000182FC4540-0x0000000182FC45C0
	
		// Methods
		internal void Reload(List<VolumeComponent> componentDefaultStates); // 0x0000000182FC4AB0-0x0000000182FC4FD0
		public T GetComponent<T>()
			where T : VolumeComponent;
		public VolumeComponent GetComponent(System.Type type); // 0x0000000182FC5A60-0x0000000182FC5B80
		public void Dispose(); // 0x00000001837DCDB0-0x00000001837DCFD0
	}

	public static class XRGraphicsAutomatedTests // TypeDefIndex: 57127
	{
		// Fields
		[CompilerGenerated]
		private static readonly bool _enabled_k__BackingField; // 0x00
		public static bool running; // 0x01
	
		// Properties
		private static bool activatedFromCommandLine { get; } // 0x00000001812081B0-0x0000000181208610 
		public static bool enabled { [CompilerGenerated] get; } // 0x000000018B2E7A54-0x000000018B2E7AA4 
	
		// Constructors
		static XRGraphicsAutomatedTests(); // 0x000000018B2E7A0C-0x000000018B2E7A54
	}
}

namespace UnityEngine.Rendering.LookDev
{
	public interface IDataProvider // TypeDefIndex: 57128
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

	public struct Sky // TypeDefIndex: 57129
	{
		// Fields
		public Cubemap cubemap; // 0x00
		public float longitudeOffset; // 0x08
		public float exposure; // 0x0C
	}

	public class StageRuntimeInterface // TypeDefIndex: 57130
	{
		// Fields
		private Func<bool, GameObject> m_AddGameObject; // 0x10
		private Func<Camera> m_GetCamera; // 0x18
		private Func<Light> m_GetSunLight; // 0x20
		public object SRPData; // 0x28
	
		// Properties
		public Camera camera { get; } // 0x000000018B2E6288-0x000000018B2E62A8 
		public Light sunLight { get; } // 0x000000018B2E62A8-0x000000018B2E62C8 
	
		// Constructors
		public StageRuntimeInterface(Func<bool, GameObject> AddGameObject, Func<Camera> GetCamera, Func<Light> GetSunLight); // 0x00000001831D14F0-0x00000001831D1530
	
		// Methods
		public GameObject AddGameObject(bool persistent = false /* Metadata: 0x023496E8 */); // 0x000000018B2E6264-0x000000018B2E6288
	}
}

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerBitField : DebugUIHandlerWidget // TypeDefIndex: 57131
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UIFoldout valueToggle; // 0x60
		public List<DebugUIHandlerIndirectToggle> toggles; // 0x68
		private DebugUI.BitField m_Field; // 0x70
		private DebugUIHandlerContainer m_Container; // 0x78
	
		// Constructors
		public DebugUIHandlerBitField(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2E13C0-0x000000018B2E170C
		private bool GetValue(int index); // 0x000000018B2E0E20-0x000000018B2E0EBC
		private void SetValue(int index, bool value); // 0x000000018B2E10F0-0x000000018B2E13C0
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2E1014-0x000000018B2E10F0
		public override void OnDeselection(); // 0x000000018B2E0FBC-0x000000018B2E0FEC
		public override void OnIncrement(bool fast); // 0x000000018B2E0FEC-0x000000018B2E1014
		public override void OnDecrement(bool fast); // 0x000000018B2E0F98-0x000000018B2E0FBC
		public override void OnAction(); // 0x000000018B2E0F68-0x000000018B2E0F98
		public override DebugUIHandlerWidget Next(); // 0x000000018B2E0EBC-0x000000018B2E0F68
	}

	public class DebugUIHandlerButton : DebugUIHandlerWidget // TypeDefIndex: 57132
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		private DebugUI.Button m_Field; // 0x60
	
		// Constructors
		public DebugUIHandlerButton(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2E1774-0x000000018B2E17F8
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2E1740-0x000000018B2E1774
		public override void OnDeselection(); // 0x000000018B2E0FBC-0x000000018B2E0FEC
		public override void OnAction(); // 0x000000018B2E1714-0x000000018B2E1740
	}

	[Serializable]
	public class DebugUIPrefabBundle // TypeDefIndex: 57133
	{
		// Fields
		public string type; // 0x10
		public RectTransform prefab; // 0x18
	
		// Constructors
		public DebugUIPrefabBundle(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class DebugUIHandlerCanvas : MonoBehaviour // TypeDefIndex: 57136
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
		private sealed class __c // TypeDefIndex: 57134
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<DebugUI.Widget, bool> __9__12_0; // 0x08
			public static Action<DebugUIHandlerPanel> __9__15_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B2EE3DC-0x000000018B2EE440
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _Rebuild_b__12_0(DebugUI.Widget x); // 0x000000018B2EE308-0x000000018B2EE338
			internal void _ActivatePanel_b__15_0(DebugUIHandlerPanel p); // 0x000000018B2EE2D4-0x000000018B2EE308
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 57135
		{
			// Fields
			public string queryPath; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetWidgetFromPath_b__0(DebugUIHandlerWidget w); // 0x000000018B2EE338-0x000000018B2EE368
		}
	
		// Constructors
		public DebugUIHandlerCanvas(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void OnEnable(); // 0x000000018B2E2020-0x000000018B2E2170
		private void Update(); // 0x000000018B2E3114-0x000000018B2E321C
		internal void RequestHierarchyReset(); // 0x0000000184D87910-0x0000000184D87920
		private void ResetAllHierarchy(); // 0x000000018B2E288C-0x000000018B2E2A44
		private void Rebuild(); // 0x000000018B2E2170-0x000000018B2E288C
		private void Traverse(DebugUI.IContainer container, Transform parentTransform, DebugUIHandlerWidget parentUIHandler, ref DebugUIHandlerWidget selectedHandler); // 0x000000018B2E2D40-0x000000018B2E3114
		private DebugUIHandlerWidget GetWidgetFromPath(string queryPath); // 0x000000018B2E1CE0-0x000000018B2E1E0C
		private void ActivatePanel(int index, DebugUIHandlerWidget selectedWidget = null); // 0x000000018B2E17F8-0x000000018B2E1A00
		internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext); // 0x000000018B2E1B54-0x000000018B2E1CE0
		internal void SelectPreviousItem(); // 0x000000018B2E2B64-0x000000018B2E2C00
		internal void SelectNextPanel(); // 0x000000018B2E2AF8-0x000000018B2E2B64
		internal void SelectPreviousPanel(); // 0x000000018B2E2C00-0x000000018B2E2C70
		internal void SelectNextItem(); // 0x000000018B2E2A44-0x000000018B2E2AF8
		private void ChangeSelectionValue(float multiplier); // 0x000000018B2E1A70-0x000000018B2E1B54
		private void ActivateSelection(); // 0x000000018B2E1A00-0x000000018B2E1A70
		private void HandleInput(); // 0x000000018B2E1E0C-0x000000018B2E2020
		internal void SetScrollTarget(DebugUIHandlerWidget widget); // 0x000000018B2E2C70-0x000000018B2E2D40
	}

	public class DebugUIHandlerColor : DebugUIHandlerWidget // TypeDefIndex: 57137
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
		public DebugUIHandlerColor(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2E7DE8-0x000000018B2E82D4
		private void SetValue(float x, bool r = false /* Metadata: 0x023496E9 */, bool g = false /* Metadata: 0x023496EA */, bool b = false /* Metadata: 0x023496EB */, bool a = false /* Metadata: 0x023496EC */); // 0x000000018B2E7CD4-0x000000018B2E7DE8
		private void SetupSettings(DebugUIHandlerIndirectFloatField field); // 0x000000018B2E82D4-0x000000018B2E8410
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2E7BF0-0x000000018B2E7CD4
		public override void OnDeselection(); // 0x000000018B2E0FBC-0x000000018B2E0FEC
		public override void OnIncrement(bool fast); // 0x000000018B2E0FEC-0x000000018B2E1014
		public override void OnDecrement(bool fast); // 0x000000018B2E0F98-0x000000018B2E0FBC
		public override void OnAction(); // 0x000000018B2E0F68-0x000000018B2E0F98
		internal void UpdateColor(); // 0x000000018B2E8664-0x000000018B2E8710
		public override DebugUIHandlerWidget Next(); // 0x000000018B2E7B3C-0x000000018B2E7BF0
		[CompilerGenerated]
		private float _SetWidget_b__9_0(); // 0x000000018B2E8410-0x000000018B2E8464
		[CompilerGenerated]
		private void _SetWidget_b__9_1(float x); // 0x000000018B2E8464-0x000000018B2E848C
		[CompilerGenerated]
		private float _SetWidget_b__9_2(); // 0x000000018B2E848C-0x000000018B2E84E0
		[CompilerGenerated]
		private void _SetWidget_b__9_3(float x); // 0x000000018B2E84E0-0x000000018B2E8508
		[CompilerGenerated]
		private float _SetWidget_b__9_4(); // 0x000000018B2E8508-0x000000018B2E855C
		[CompilerGenerated]
		private void _SetWidget_b__9_5(float x); // 0x000000018B2E855C-0x000000018B2E8584
		[CompilerGenerated]
		private float _SetWidget_b__9_6(); // 0x000000018B2E8584-0x000000018B2E85D8
		[CompilerGenerated]
		private void _SetWidget_b__9_7(float x); // 0x000000018B2E85D8-0x000000018B2E8600
		[CompilerGenerated]
		private float _SetupSettings_b__11_0(); // 0x000000018B2E8600-0x000000018B2E8620
		[CompilerGenerated]
		private float _SetupSettings_b__11_1(); // 0x000000018B2E8620-0x000000018B2E8640
		[CompilerGenerated]
		private float _SetupSettings_b__11_2(); // 0x000000018B2E8640-0x000000018B2E8664
	}

	public class DebugUIHandlerContainer : MonoBehaviour // TypeDefIndex: 57139
	{
		// Fields
		[SerializeField]
		public RectTransform contentHolder; // 0x18
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 57138
		{
			// Fields
			public DebugUIHandlerWidget widget; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _IsDirectChild_b__0(DebugUIHandlerWidget x); // 0x000000018B2EE368-0x000000018B2EE3BC
		}
	
		// Constructors
		public DebugUIHandlerContainer(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		internal DebugUIHandlerWidget GetFirstItem(); // 0x000000018B2E8964-0x000000018B2E89E4
		internal DebugUIHandlerWidget GetLastItem(); // 0x000000018B2E89E4-0x000000018B2E8A68
		internal bool IsDirectChild(DebugUIHandlerWidget widget); // 0x000000018B2E8A68-0x000000018B2E8B60
		private List<DebugUIHandlerWidget> GetActiveChildren(); // 0x000000018B2E8710-0x000000018B2E8964
	}

	public class DebugUIHandlerEnumField : DebugUIHandlerWidget // TypeDefIndex: 57140
	{
		// Fields
		public UI.Text nextButtonText; // 0x58
		public UI.Text previousButtonText; // 0x60
		public UI.Text nameLabel; // 0x68
		public UI.Text valueLabel; // 0x70
		protected internal DebugUI.EnumField m_Field; // 0x78
	
		// Constructors
		public DebugUIHandlerEnumField(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2E906C-0x000000018B2E90FC
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2E8F60-0x000000018B2E906C
		public override void OnDeselection(); // 0x000000018B2E8D0C-0x000000018B2E8E14
		public override void OnAction(); // 0x000000018B2E8B60-0x000000018B2E8B70
		public override void OnIncrement(bool fast); // 0x000000018B2E8E14-0x000000018B2E8F60
		public override void OnDecrement(bool fast); // 0x000000018B2E8B70-0x000000018B2E8D0C
		protected virtual void UpdateValueLabel(); // 0x000000018B2E90FC-0x000000018B2E91B8
	}

	public class DebugUIHandlerEnumHistory : DebugUIHandlerEnumField // TypeDefIndex: 57142
	{
		// Fields
		private UI.Text[] historyValues; // 0x80
		private const float xDecal = 60f; // Metadata: 0x023496ED
	
		// Nested types
		[CompilerGenerated]
		private sealed class _RefreshAfterSanitization_d__4 : IEnumerator<object> // TypeDefIndex: 57141
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DebugUIHandlerEnumHistory __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _RefreshAfterSanitization_d__4(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B2EE158-0x000000018B2EE23C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B2EE288-0x000000018B2EE2D4
		}
	
		// Constructors
		public DebugUIHandlerEnumHistory(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2E9214-0x000000018B2E9448
		protected override void UpdateValueLabel(); // 0x000000018B2E9448-0x000000018B2E9620
		[IteratorStateMachine(typeof(_RefreshAfterSanitization_d__4))]
		private IEnumerator RefreshAfterSanitization(); // 0x000000018B2E91B8-0x000000018B2E9214
	}

	public class DebugUIHandlerFloatField : DebugUIHandlerWidget // TypeDefIndex: 57143
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UI.Text valueLabel; // 0x60
		private DebugUI.FloatField m_Field; // 0x68
	
		// Constructors
		public DebugUIHandlerFloatField(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2E97AC-0x000000018B2E983C
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2E9750-0x000000018B2E97AC
		public override void OnDeselection(); // 0x000000018B2E96E4-0x000000018B2E9740
		public override void OnIncrement(bool fast); // 0x000000018B2E9740-0x000000018B2E9750
		public override void OnDecrement(bool fast); // 0x000000018B2E96D4-0x000000018B2E96E4
		private void ChangeValue(bool fast, float multiplier); // 0x000000018B2E9620-0x000000018B2E96D4
		private void UpdateValueLabel(); // 0x000000018B2E983C-0x000000018B2E98EC
	}

	public class DebugUIHandlerFoldout : DebugUIHandlerWidget // TypeDefIndex: 57144
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UIFoldout valueToggle; // 0x60
		private DebugUI.Foldout m_Field; // 0x68
		private DebugUIHandlerContainer m_Container; // 0x70
		private const float xDecal = 60f; // Metadata: 0x023496F1
		private const float xDecalInit = 230f; // Metadata: 0x023496F5
	
		// Constructors
		public DebugUIHandlerFoldout(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2E9AE8-0x000000018B2E9EC4
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2E9A0C-0x000000018B2E9AE8
		public override void OnDeselection(); // 0x000000018B2E0FBC-0x000000018B2E0FEC
		public override void OnIncrement(bool fast); // 0x000000018B2E99E8-0x000000018B2E9A0C
		public override void OnDecrement(bool fast); // 0x000000018B2E99C4-0x000000018B2E99E8
		public override void OnAction(); // 0x000000018B2E9998-0x000000018B2E99C4
		private void UpdateValue(); // 0x000000018B2E9EC4-0x000000018B2E9EF8
		public override DebugUIHandlerWidget Next(); // 0x000000018B2E98EC-0x000000018B2E9998
	}

	public class DebugUIHandlerGroup : DebugUIHandlerWidget // TypeDefIndex: 57145
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public Transform header; // 0x60
		private DebugUI.Container m_Field; // 0x68
		private DebugUIHandlerContainer m_Container; // 0x70
	
		// Constructors
		public DebugUIHandlerGroup(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2EA040-0x000000018B2EA124
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2E9F94-0x000000018B2EA040
		public override DebugUIHandlerWidget Next(); // 0x000000018B2E9EF8-0x000000018B2E9F94
	}

	public class DebugUIHandlerHBox : DebugUIHandlerWidget // TypeDefIndex: 57146
	{
		// Fields
		private DebugUIHandlerContainer m_Container; // 0x58
	
		// Constructors
		public DebugUIHandlerHBox(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2EA26C-0x000000018B2EA2CC
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2EA1C0-0x000000018B2EA26C
		public override DebugUIHandlerWidget Next(); // 0x000000018B2EA124-0x000000018B2EA1C0
	}

	public class DebugUIHandlerIndirectFloatField : DebugUIHandlerWidget // TypeDefIndex: 57147
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
		public DebugUIHandlerIndirectFloatField(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		public void Init(); // 0x000000018B2EA388-0x000000018B2EA390
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2E9750-0x000000018B2E97AC
		public override void OnDeselection(); // 0x000000018B2E96E4-0x000000018B2E9740
		public override void OnIncrement(bool fast); // 0x000000018B2EA3A0-0x000000018B2EA3B0
		public override void OnDecrement(bool fast); // 0x000000018B2EA390-0x000000018B2EA3A0
		private void ChangeValue(bool fast, float multiplier); // 0x000000018B2EA2CC-0x000000018B2EA388
		private void UpdateValueLabel(); // 0x000000018B2EA3B0-0x000000018B2EA48C
	}

	public class DebugUIHandlerIndirectToggle : DebugUIHandlerWidget // TypeDefIndex: 57148
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public Toggle valueToggle; // 0x60
		public Image checkmarkImage; // 0x68
		public Func<int, bool> getter; // 0x70
		public Action<int, bool> setter; // 0x78
		internal int index; // 0x80
	
		// Constructors
		public DebugUIHandlerIndirectToggle(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		public void Init(); // 0x000000018B2EA48C-0x000000018B2EA544
		private void OnToggleValueChanged(bool value); // 0x000000018B2EA650-0x000000018B2EA680
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2EA5F4-0x000000018B2EA650
		public override void OnDeselection(); // 0x000000018B2EA598-0x000000018B2EA5F4
		public override void OnAction(); // 0x000000018B2EA544-0x000000018B2EA598
		internal void UpdateValueLabel(); // 0x000000018B2EA680-0x000000018B2EA70C
	}

	public class DebugUIHandlerIntField : DebugUIHandlerWidget // TypeDefIndex: 57149
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UI.Text valueLabel; // 0x60
		private DebugUI.IntField m_Field; // 0x68
	
		// Constructors
		public DebugUIHandlerIntField(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2EA7E0-0x000000018B2EA870
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2E9750-0x000000018B2E97AC
		public override void OnDeselection(); // 0x000000018B2E96E4-0x000000018B2E9740
		public override void OnIncrement(bool fast); // 0x000000018B2EA7D0-0x000000018B2EA7E0
		public override void OnDecrement(bool fast); // 0x000000018B2EA7C0-0x000000018B2EA7D0
		private void ChangeValue(bool fast, int multiplier); // 0x000000018B2EA70C-0x000000018B2EA7C0
		private void UpdateValueLabel(); // 0x000000018B2EA870-0x000000018B2EA928
	}

	public class DebugUIHandlerMessageBox : DebugUIHandlerWidget // TypeDefIndex: 57150
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		private DebugUI.MessageBox m_Field; // 0x60
		private static Color32 k_WarningBackgroundColor; // 0x00
		private static Color32 k_WarningTextColor; // 0x04
		private static Color32 k_ErrorBackgroundColor; // 0x08
		private static Color32 k_ErrorTextColor; // 0x0C
	
		// Constructors
		public DebugUIHandlerMessageBox(); // 0x000000018B2E170C-0x000000018B2E1714
		static DebugUIHandlerMessageBox(); // 0x000000018B2EAA58-0x000000018B2EAAF0
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2EA928-0x000000018B2EAA58
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x00000001812081B0-0x0000000181208610
	}

	public class DebugUIHandlerPanel : MonoBehaviour // TypeDefIndex: 57151
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
		public DebugUIHandlerPanel(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void OnEnable(); // 0x000000018B2EACA4-0x000000018B2EAD60
		internal void SetPanel(DebugUI.Panel panel); // 0x000000018B2EAE3C-0x000000018B2EAE78
		internal DebugUI.Panel GetPanel(); // 0x0000000182E56440-0x0000000182E56460
		public void SelectNextItem(); // 0x000000018B2EADFC-0x000000018B2EAE1C
		public void SelectPreviousItem(); // 0x000000018B2EAE1C-0x000000018B2EAE3C
		public void OnScrollbarClicked(); // 0x000000018B2EAD60-0x000000018B2EADB0
		internal void SetScrollTarget(DebugUIHandlerWidget target); // 0x0000000182FDAEA0-0x0000000182FDAEB0
		internal void UpdateScroll(); // 0x000000018B2EAE78-0x000000018B2EB028
		private float GetYPosInScroll(RectTransform target); // 0x000000018B2EAB40-0x000000018B2EACA4
		internal DebugUIHandlerWidget GetFirstItem(); // 0x000000018B2EAAF0-0x000000018B2EAB40
		public void ResetDebugManager(); // 0x000000018B2EADB0-0x000000018B2EADFC
	}

	internal class DebugUIHandlerPersistentCanvas : MonoBehaviour // TypeDefIndex: 57153
	{
		// Fields
		public RectTransform panel; // 0x18
		public RectTransform valuePrefab; // 0x20
		private List<DebugUIHandlerValue> m_Items; // 0x28
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 57152
		{
			// Fields
			public DebugUI.Value widget; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _Toggle_b__0(DebugUIHandlerValue x); // 0x000000018B2EE3BC-0x000000018B2EE3DC
		}
	
		// Constructors
		public DebugUIHandlerPersistentCanvas(); // 0x000000018B2EB3D8-0x000000018B2EB458
	
		// Methods
		internal void Toggle(DebugUI.Value widget); // 0x000000018B2EB194-0x000000018B2EB3D8
		internal void Clear(); // 0x000000018B2EB028-0x000000018B2EB194
	}

	public class DebugUIHandlerRow : DebugUIHandlerFoldout // TypeDefIndex: 57154
	{
		// Fields
		private float m_Timer; // 0x78
	
		// Constructors
		public DebugUIHandlerRow(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		protected override void OnEnable(); // 0x0000000184DB98E0-0x0000000184DB98F0
		protected void Update(); // 0x000000018B2EB458-0x000000018B2EB818
	}

	public class DebugUIHandlerToggle : DebugUIHandlerWidget // TypeDefIndex: 57155
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public Toggle valueToggle; // 0x60
		public Image checkmarkImage; // 0x68
		protected internal DebugUI.BoolField m_Field; // 0x70
	
		// Constructors
		public DebugUIHandlerToggle(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2EBDC0-0x000000018B2EBED0
		private void OnToggleValueChanged(bool value); // 0x000000018B2EBD6C-0x000000018B2EBDC0
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2EA5F4-0x000000018B2EA650
		public override void OnDeselection(); // 0x000000018B2EA598-0x000000018B2EA5F4
		public override void OnAction(); // 0x000000018B2EBCF4-0x000000018B2EBD6C
		protected internal virtual void UpdateValueLabel(); // 0x000000018B2EBED0-0x000000018B2EBF68
	}

	public class DebugUIHandlerToggleHistory : DebugUIHandlerToggle // TypeDefIndex: 57157
	{
		// Fields
		private Toggle[] historyToggles; // 0x78
		private const float xDecal = 60f; // Metadata: 0x023496F9
	
		// Nested types
		[CompilerGenerated]
		private sealed class _RefreshAfterSanitization_d__4 : IEnumerator<object> // TypeDefIndex: 57156
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DebugUIHandlerToggleHistory __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _RefreshAfterSanitization_d__4(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B2EE0BC-0x000000018B2EE158
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B2EE23C-0x000000018B2EE288
		}
	
		// Constructors
		public DebugUIHandlerToggleHistory(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2EB874-0x000000018B2EBBAC
		protected internal override void UpdateValueLabel(); // 0x000000018B2EBBAC-0x000000018B2EBCF4
		[IteratorStateMachine(typeof(_RefreshAfterSanitization_d__4))]
		private IEnumerator RefreshAfterSanitization(); // 0x000000018B2EB818-0x000000018B2EB874
	}

	public class DebugUIHandlerUIntField : DebugUIHandlerWidget // TypeDefIndex: 57158
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UI.Text valueLabel; // 0x60
		private DebugUI.UIntField m_Field; // 0x68
	
		// Constructors
		public DebugUIHandlerUIntField(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2EC048-0x000000018B2EC0D8
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2E9750-0x000000018B2E97AC
		public override void OnDeselection(); // 0x000000018B2E96E4-0x000000018B2E9740
		public override void OnIncrement(bool fast); // 0x000000018B2EC038-0x000000018B2EC048
		public override void OnDecrement(bool fast); // 0x000000018B2EC028-0x000000018B2EC038
		private void ChangeValue(bool fast, int multiplier); // 0x000000018B2EBF68-0x000000018B2EC028
		private void UpdateValueLabel(); // 0x000000018B2EC0D8-0x000000018B2EC190
	}

	public class DebugUIHandlerValue : DebugUIHandlerWidget // TypeDefIndex: 57159
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UI.Text valueLabel; // 0x60
		private DebugUI.Value m_Field; // 0x68
		private float m_Timer; // 0x70
	
		// Constructors
		public DebugUIHandlerValue(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		protected override void OnEnable(); // 0x0000000184DB98F0-0x0000000184DB9900
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2EC338-0x000000018B2EC3BC
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2E9750-0x000000018B2E97AC
		public override void OnDeselection(); // 0x000000018B2E96E4-0x000000018B2E9740
		private void Update(); // 0x000000018B2EC3BC-0x000000018B2EC458
	}

	public class DebugUIHandlerVBox : DebugUIHandlerWidget // TypeDefIndex: 57160
	{
		// Fields
		private DebugUIHandlerContainer m_Container; // 0x58
	
		// Constructors
		public DebugUIHandlerVBox(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2EC2D8-0x000000018B2EC338
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2EC22C-0x000000018B2EC2D8
		public override DebugUIHandlerWidget Next(); // 0x000000018B2EC190-0x000000018B2EC22C
	}

	public class DebugUIHandlerVector2 : DebugUIHandlerWidget // TypeDefIndex: 57161
	{
		// Fields
		public UI.Text nameLabel; // 0x58
		public UIFoldout valueToggle; // 0x60
		public DebugUIHandlerIndirectFloatField fieldX; // 0x68
		public DebugUIHandlerIndirectFloatField fieldY; // 0x70
		private DebugUI.Vector2Field m_Field; // 0x78
		private DebugUIHandlerContainer m_Container; // 0x80
	
		// Constructors
		public DebugUIHandlerVector2(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2EC6A8-0x000000018B2EC920
		private void SetValue(float v, bool x = false /* Metadata: 0x023496FD */, bool y = false /* Metadata: 0x023496FE */); // 0x000000018B2EC5F0-0x000000018B2EC6A8
		private void SetupSettings(DebugUIHandlerIndirectFloatField field); // 0x000000018B2EC920-0x000000018B2ECA5C
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2EC50C-0x000000018B2EC5F0
		public override void OnDeselection(); // 0x000000018B2E0FBC-0x000000018B2E0FEC
		public override void OnIncrement(bool fast); // 0x000000018B2E0FEC-0x000000018B2E1014
		public override void OnDecrement(bool fast); // 0x000000018B2E0F98-0x000000018B2E0FBC
		public override void OnAction(); // 0x000000018B2E0F68-0x000000018B2E0F98
		public override DebugUIHandlerWidget Next(); // 0x000000018B2EC458-0x000000018B2EC50C
		[CompilerGenerated]
		private float _SetWidget_b__6_0(); // 0x000000018B2ECA5C-0x000000018B2ECAB0
		[CompilerGenerated]
		private void _SetWidget_b__6_1(float x); // 0x000000018B2ECAB0-0x000000018B2ECAD0
		[CompilerGenerated]
		private float _SetWidget_b__6_2(); // 0x000000018B2ECAD0-0x000000018B2ECB24
		[CompilerGenerated]
		private void _SetWidget_b__6_3(float x); // 0x000000018B2ECB24-0x000000018B2ECB44
		[CompilerGenerated]
		private float _SetupSettings_b__8_0(); // 0x000000018B2ECB44-0x000000018B2ECB64
		[CompilerGenerated]
		private float _SetupSettings_b__8_1(); // 0x000000018B2ECB64-0x000000018B2ECB84
		[CompilerGenerated]
		private float _SetupSettings_b__8_2(); // 0x000000018B2ECB84-0x000000018B2ECBA4
	}

	public class DebugUIHandlerVector3 : DebugUIHandlerWidget // TypeDefIndex: 57162
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
		public DebugUIHandlerVector3(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2ECE14-0x000000018B2ED184
		private void SetValue(float v, bool x = false /* Metadata: 0x023496FF */, bool y = false /* Metadata: 0x02349700 */, bool z = false /* Metadata: 0x02349701 */); // 0x000000018B2ECD3C-0x000000018B2ECE14
		private void SetupSettings(DebugUIHandlerIndirectFloatField field); // 0x000000018B2ED184-0x000000018B2ED2C0
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2ECC58-0x000000018B2ECD3C
		public override void OnDeselection(); // 0x000000018B2E0FBC-0x000000018B2E0FEC
		public override void OnIncrement(bool fast); // 0x000000018B2E0FEC-0x000000018B2E1014
		public override void OnDecrement(bool fast); // 0x000000018B2E0F98-0x000000018B2E0FBC
		public override void OnAction(); // 0x000000018B2E0F68-0x000000018B2E0F98
		public override DebugUIHandlerWidget Next(); // 0x000000018B2ECBA4-0x000000018B2ECC58
		[CompilerGenerated]
		private float _SetWidget_b__7_0(); // 0x000000018B2ED2C0-0x000000018B2ED314
		[CompilerGenerated]
		private void _SetWidget_b__7_1(float v); // 0x000000018B2ED314-0x000000018B2ED338
		[CompilerGenerated]
		private float _SetWidget_b__7_2(); // 0x000000018B2ED338-0x000000018B2ED38C
		[CompilerGenerated]
		private void _SetWidget_b__7_3(float v); // 0x000000018B2ED38C-0x000000018B2ED3B0
		[CompilerGenerated]
		private float _SetWidget_b__7_4(); // 0x000000018B2ED3B0-0x000000018B2ED404
		[CompilerGenerated]
		private void _SetWidget_b__7_5(float v); // 0x000000018B2ED404-0x000000018B2ED428
		[CompilerGenerated]
		private float _SetupSettings_b__9_0(); // 0x000000018B2ED428-0x000000018B2ED448
		[CompilerGenerated]
		private float _SetupSettings_b__9_1(); // 0x000000018B2ED448-0x000000018B2ED468
		[CompilerGenerated]
		private float _SetupSettings_b__9_2(); // 0x000000018B2ED468-0x000000018B2ED48C
	}

	public class DebugUIHandlerVector4 : DebugUIHandlerWidget // TypeDefIndex: 57163
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
		public DebugUIHandlerVector4(); // 0x000000018B2E170C-0x000000018B2E1714
	
		// Methods
		internal override void SetWidget(DebugUI.Widget widget); // 0x000000018B2ED72C-0x000000018B2EDBA0
		private void SetValue(float v, bool x = false /* Metadata: 0x02349702 */, bool y = false /* Metadata: 0x02349703 */, bool z = false /* Metadata: 0x02349704 */, bool w = false /* Metadata: 0x02349705 */); // 0x000000018B2ED624-0x000000018B2ED72C
		private void SetupSettings(DebugUIHandlerIndirectFloatField field); // 0x000000018B2EDBA0-0x000000018B2EDCDC
		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x000000018B2ED540-0x000000018B2ED624
		public override void OnDeselection(); // 0x000000018B2E0FBC-0x000000018B2E0FEC
		public override void OnIncrement(bool fast); // 0x000000018B2E0FEC-0x000000018B2E1014
		public override void OnDecrement(bool fast); // 0x000000018B2E0F98-0x000000018B2E0FBC
		public override void OnAction(); // 0x000000018B2E0F68-0x000000018B2E0F98
		public override DebugUIHandlerWidget Next(); // 0x000000018B2ED48C-0x000000018B2ED540
		[CompilerGenerated]
		private float _SetWidget_b__8_0(); // 0x000000018B2EDCDC-0x000000018B2EDD30
		[CompilerGenerated]
		private void _SetWidget_b__8_1(float x); // 0x000000018B2EDD30-0x000000018B2EDD58
		[CompilerGenerated]
		private float _SetWidget_b__8_2(); // 0x000000018B2EDD58-0x000000018B2EDDAC
		[CompilerGenerated]
		private void _SetWidget_b__8_3(float x); // 0x000000018B2EDDAC-0x000000018B2EDDD4
		[CompilerGenerated]
		private float _SetWidget_b__8_4(); // 0x000000018B2EDDD4-0x000000018B2EDE28
		[CompilerGenerated]
		private void _SetWidget_b__8_5(float x); // 0x000000018B2EDE28-0x000000018B2EDE50
		[CompilerGenerated]
		private float _SetWidget_b__8_6(); // 0x000000018B2EDE50-0x000000018B2EDEA4
		[CompilerGenerated]
		private void _SetWidget_b__8_7(float x); // 0x000000018B2EDEA4-0x000000018B2EDECC
		[CompilerGenerated]
		private float _SetupSettings_b__10_0(); // 0x000000018B2EDECC-0x000000018B2EDEEC
		[CompilerGenerated]
		private float _SetupSettings_b__10_1(); // 0x000000018B2EDEEC-0x000000018B2EDF0C
		[CompilerGenerated]
		private float _SetupSettings_b__10_2(); // 0x000000018B2EDF0C-0x000000018B2EDF30
	}

	public class DebugUIHandlerWidget : MonoBehaviour // TypeDefIndex: 57164
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
		public DebugUIHandlerWidget parentUIHandler { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public DebugUIHandlerWidget previousUIHandler { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public DebugUIHandlerWidget nextUIHandler { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
	
		// Constructors
		public DebugUIHandlerWidget(); // 0x000000018B2EE08C-0x000000018B2EE0BC
	
		// Methods
		protected virtual void OnEnable(); // 0x00000001841E1670-0x00000001841E1680
		internal virtual void SetWidget(DebugUI.Widget widget); // 0x0000000182FDAEA0-0x0000000182FDAEB0
		internal DebugUI.Widget GetWidget(); // 0x0000000184D86270-0x0000000184D86280
		protected T CastWidget<T>()
			where T : DebugUI.Widget;
		public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous); // 0x0000000182FFF600-0x0000000182FFF610
		public virtual void OnDeselection(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnAction(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnIncrement(bool fast); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnDecrement(bool fast); // 0x00000001841E1670-0x00000001841E1680
		public virtual DebugUIHandlerWidget Previous(); // 0x000000018B2EE008-0x000000018B2EE08C
		public virtual DebugUIHandlerWidget Next(); // 0x000000018B2EDF30-0x000000018B2EE008
	}

	[ExecuteAlways]
	public class UIFoldout : Toggle // TypeDefIndex: 57165
	{
		// Fields
		public GameObject content; // 0x1B0
		public GameObject arrowOpened; // 0x1B8
		public GameObject arrowClosed; // 0x1C0
	
		// Constructors
		public UIFoldout(); // 0x000000018B2EE704-0x000000018B2EE70C
	
		// Methods
		protected override void Start(); // 0x000000018B2EE640-0x000000018B2EE704
		private void OnValidate(); // 0x000000018B2EE440-0x000000018B2EE454
		public void SetState(bool state); // 0x000000018B2EE454-0x000000018B2EE460
		public void SetState(bool state, bool rebuildLayout); // 0x000000018B2EE460-0x000000018B2EE640
	}
}
