/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;
using UnityEngine.UI;

// Image 25: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 55564-55749
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.FontEngine.Tests")]
[assembly: InternalsVisibleTo("Unity.TextCore")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 55749
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB; // 0x00 // Static value (base64): IAAuACwACQANAAoA - Metadata: 0x0234761C

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 55748
	{
	}
}

namespace TMPro
{
	public class FastAction // TypeDefIndex: 55565
	{
		// Fields
		private LinkedList<Action> delegates; // 0x10
		private Dictionary<Action, LinkedListNode<Action>> lookup; // 0x18
	
		// Constructors
		public FastAction(); // 0x000000018478EC20-0x000000018478ECD0
	
		// Methods
		public void Add(Action rhs); // 0x000000018B3008BC-0x000000018B300970
		public void Remove(Action rhs); // 0x000000018B3009F0-0x000000018B300AA0
		public void Call(); // 0x000000018B300970-0x000000018B3009F0
	}

	public class FastAction<A> // TypeDefIndex: 55566
	{
		// Fields
		private LinkedList<Action<A>> delegates;
		private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup;
	
		// Constructors
		public FastAction();
	
		// Methods
		public void Add(Action<A> rhs);
		public void Remove(Action<A> rhs);
		public void Call(A a);
	}

	public class FastAction<A, B> // TypeDefIndex: 55567
	{
		// Fields
		private LinkedList<Action<A, B>> delegates;
		private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup;
	
		// Constructors
		public FastAction();
	
		// Methods
		public void Add(Action<A, B> rhs);
		public void Remove(Action<A, B> rhs);
		public void Call(A a, B b);
	}

	public class FastAction<A, B, C> // TypeDefIndex: 55568
	{
		// Fields
		private LinkedList<Action<A, B, C>> delegates;
		private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup;
	
		// Constructors
		public FastAction();
	
		// Methods
		public void Add(Action<A, B, C> rhs);
		public void Remove(Action<A, B, C> rhs);
		public void Call(A a, B b, C c);
	}

	public interface IFontAssetLoader // TypeDefIndex: 55569
	{
		// Methods
		bool TryGetFontAsset(TMP_Text refText, uint unicode, out TMP_FontAsset fontAsset);
		void TryRemoveRefText(TMP_Text refText);
	}

	public interface ITextPreprocessor // TypeDefIndex: 55570
	{
		// Methods
		string PreprocessText(string text);
	}

	public class LocalizedTextPreprocessor : ITextPreprocessor // TypeDefIndex: 55571
	{
		// Fields
		private static LocalizedTextPreprocessor _instance; // 0x00
	
		// Properties
		public static LocalizedTextPreprocessor Instance { get; } // 0x000000018B300AA0-0x000000018B300AF0 
	
		// Constructors
		public LocalizedTextPreprocessor(); // 0x00000001841E1670-0x00000001841E1680
		static LocalizedTextPreprocessor(); // 0x0000000184D4E010-0x0000000184D4E070
	
		// Methods
		public string PreprocessText(string text); // 0x000000018333C4E0-0x000000018333C560
	}

	public class MaterialReferenceManager // TypeDefIndex: 55572
	{
		// Fields
		private static MaterialReferenceManager s_Instance; // 0x00
		private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
		private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
		private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
		private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x28
	
		// Properties
		public static MaterialReferenceManager instance { get; } // 0x000000018B3013D4-0x000000018B301464 
	
		// Constructors
		public MaterialReferenceManager(); // 0x000000018B30127C-0x000000018B3013D4
	
		// Methods
		public static void AddFontAsset(TMP_FontAsset fontAsset); // 0x000000018B300C68-0x000000018B300C98
		private void AddFontAssetInternal(TMP_FontAsset fontAsset); // 0x000000018B300BB8-0x000000018B300C68
		public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset); // 0x000000018B300EA8-0x000000018B300ED8
		private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset); // 0x000000018B300D38-0x000000018B300DE8
		public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset); // 0x000000018B300ED8-0x000000018B300F14
		private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset); // 0x000000018B300DE8-0x000000018B300EA8
		public static void AddFontMaterial(int hashCode, Material material); // 0x000000018B300CFC-0x000000018B300D38
		private void AddFontMaterialInternal(int hashCode, Material material); // 0x000000018B300C98-0x000000018B300CFC
		public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset); // 0x000000018B300B7C-0x000000018B300BB8
		private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset); // 0x000000018B300AF0-0x000000018B300B7C
		public bool Contains(TMP_FontAsset font); // 0x000000018B300F14-0x000000018B300F70
		public bool Contains(TMP_SpriteAsset sprite); // 0x000000018B300F70-0x000000018B300FCC
		public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset); // 0x000000018B3010E8-0x000000018B301124
		private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset); // 0x000000018B301078-0x000000018B3010E8
		public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset); // 0x000000018B301240-0x000000018B30127C
		private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset); // 0x000000018B3011D0-0x000000018B301240
		public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset); // 0x000000018B30103C-0x000000018B301078
		private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset); // 0x000000018B300FCC-0x000000018B30103C
		public static bool TryGetMaterial(int hashCode, out Material material); // 0x000000018B301194-0x000000018B3011D0
		private bool TryGetMaterialInternal(int hashCode, out Material material); // 0x000000018B301124-0x000000018B301194
	}

	public struct TMP_MaterialReference // TypeDefIndex: 55573
	{
		// Fields
		public Material material; // 0x00
		public int referenceCount; // 0x08
	}

	public struct MaterialReference // TypeDefIndex: 55574
	{
		// Fields
		public int index; // 0x00
		public TMP_FontAsset fontAsset; // 0x08
		public TMP_SpriteAsset spriteAsset; // 0x10
		public Material material; // 0x18
		public bool isDefaultMaterial; // 0x20
		public bool isFallbackMaterial; // 0x21
		public Material fallbackMaterial; // 0x28
		public float padding; // 0x30
		public int referenceCount; // 0x34
	
		// Constructors
		public MaterialReference(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding); // 0x000000018333BC80-0x000000018333BE20
	
		// Methods
		public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset); // 0x000000018B301650-0x000000018B301718
		public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup); // 0x000000018333CE80-0x000000018333D0F0
		public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup); // 0x000000018B301464-0x000000018B301650
	}

	public enum TextContainerAnchors // TypeDefIndex: 55575
	{
		TopLeft = 0,
		Top = 1,
		TopRight = 2,
		Left = 3,
		Middle = 4,
		Right = 5,
		BottomLeft = 6,
		Bottom = 7,
		BottomRight = 8,
		Custom = 9
	}

	[RequireComponent(typeof(RectTransform))]
	public class TextContainer : UIBehaviour // TypeDefIndex: 55576
	{
		// Fields
		private bool m_hasChanged; // 0x18
		[SerializeField]
		private Vector2 m_pivot; // 0x1C
		[SerializeField]
		private TextContainerAnchors m_anchorPosition; // 0x24
		[SerializeField]
		private Rect m_rect; // 0x28
		private bool m_isDefaultWidth; // 0x38
		private bool m_isDefaultHeight; // 0x39
		private bool m_isAutoFitting; // 0x3A
		private Vector3[] m_corners; // 0x40
		private Vector3[] m_worldCorners; // 0x48
		[SerializeField]
		private Vector4 m_margins; // 0x50
		private RectTransform m_rectTransform; // 0x60
		private static Vector2 k_defaultSize; // 0x00
		private TextMeshPro m_textMeshPro; // 0x68
	
		// Properties
		public bool hasChanged { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public Vector2 pivot { get; set; } // 0x0000000184DB9A00-0x0000000184DB9A20 0x000000018B3020A8-0x000000018B302118
		public TextContainerAnchors anchorPosition { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x000000018B301FC8-0x000000018B302010
		public Rect rect { get; set; } // 0x0000000184D8FAD0-0x0000000184D8FAE0 0x000000018B302118-0x000000018B302170
		public Vector2 size { get; set; } // 0x0000000184DB9A20-0x0000000184DB9A40 0x000000018B302170-0x000000018B3021D0
		public float width { get; set; } // 0x0000000184DB9A40-0x0000000184DB9A50 0x000000018B3021D0-0x000000018B302218
		public float height { get; set; } // 0x00000001853957B0-0x00000001853957C0 0x000000018B302010-0x000000018B302058
		public bool isDefaultWidth { get; } // 0x00000001811F2A70-0x00000001811F2A80 
		public bool isDefaultHeight { get; } // 0x0000000184D86650-0x0000000184D86660 
		public bool isAutoFitting { get; set; } // 0x0000000184D86660-0x0000000184D86670 0x0000000184D86690-0x0000000184D866A0
		public Vector3[] corners { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public Vector3[] worldCorners { get; } // 0x0000000184D86200-0x0000000184D86210 
		public Vector4 margins { get; set; } // 0x0000000184D8CE10-0x0000000184D8CE20 0x000000018B302058-0x000000018B3020A8
		public RectTransform rectTransform { get; } // 0x000000018B301EC0-0x000000018B301F44 
		public TextMeshPro textMeshPro { get; } // 0x000000018B301F44-0x000000018B301FC8 
	
		// Constructors
		public TextContainer(); // 0x000000018B301E48-0x000000018B301EC0
		static TextContainer(); // 0x000000018B301E08-0x000000018B301E48
	
		// Methods
		protected override void Awake(); // 0x000000018B301718-0x000000018B3017B8
		protected override void OnEnable(); // 0x000000018B301AE8-0x000000018B301AF0
		protected override void OnDisable(); // 0x00000001841E1670-0x00000001841E1680
		private void OnContainerChanged(); // 0x000000018B3019EC-0x000000018B301AE8
		protected override void OnRectTransformDimensionsChange(); // 0x000000018B301AF0-0x000000018B301C48
		private void SetRect(Vector2 size); // 0x0000000184DB99B0-0x0000000184DB9A00
		private void UpdateCorners(); // 0x000000018B301C48-0x000000018B301E08
		private Vector2 GetPivot(TextContainerAnchors anchor); // 0x000000018B301960-0x000000018B3019EC
		private TextContainerAnchors GetAnchorPosition(Vector2 pivot); // 0x000000018B3017B8-0x000000018B301960
	}

	[AddComponentMenu("Mesh/TextMeshPro - Text")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.0")]
	[RequireComponent(typeof(MeshRenderer))]
	public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 55577
	{
		// Fields
		[SerializeField]
		internal int _SortingLayer; // 0xAF8
		[SerializeField]
		internal int _SortingLayerID; // 0xAFC
		[SerializeField]
		internal int _SortingOrder; // 0xB00
		[CompilerGenerated]
		private Action<TMP_TextInfo> OnPreRenderText; // 0xB08
		private bool m_currentAutoSizeMode; // 0xB10
		[SerializeField]
		private bool m_hasFontAssetChanged; // 0xB11
		private float m_previousLossyScaleY; // 0xB14
		[SerializeField]
		private Renderer m_renderer; // 0xB18
		private MeshFilter m_meshFilter; // 0xB20
		private bool m_isFirstAllocation; // 0xB28
		private int m_max_characters; // 0xB2C
		private int m_max_numberOfLines; // 0xB30
		private TMP_SubMesh[] m_subTextObjects; // 0xB38
		[SerializeField]
		private MaskingTypes m_maskType; // 0xB40
		private Matrix4x4 m_EnvMapMatrix; // 0xB44
		private Vector3[] m_RectTransformCorners; // 0xB88
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0xB90
		private static ProfilerMarker k_GenerateTextMarker; // 0x00
		private static ProfilerMarker k_SetArraySizesMarker; // 0x08
		private static ProfilerMarker k_GenerateTextPhaseIMarker; // 0x10
		private static ProfilerMarker k_ParseMarkupTextMarker; // 0x18
		private static ProfilerMarker k_CharacterLookupMarker; // 0x20
		private static ProfilerMarker k_HandleGPOSFeaturesMarker; // 0x28
		private static ProfilerMarker k_CalculateVerticesPositionMarker; // 0x30
		private static ProfilerMarker k_ComputeTextMetricsMarker; // 0x38
		private static ProfilerMarker k_HandleVisibleCharacterMarker; // 0x40
		private static ProfilerMarker k_HandleWhiteSpacesMarker; // 0x48
		private static ProfilerMarker k_HandleHorizontalLineBreakingMarker; // 0x50
		private static ProfilerMarker k_HandleVerticalLineBreakingMarker; // 0x58
		private static ProfilerMarker k_SaveGlyphVertexDataMarker; // 0x60
		private static ProfilerMarker k_ComputeCharacterAdvanceMarker; // 0x68
		private static ProfilerMarker k_HandleCarriageReturnMarker; // 0x70
		private static ProfilerMarker k_HandleLineTerminationMarker; // 0x78
		private static ProfilerMarker k_SavePageInfoMarker; // 0x80
		private static ProfilerMarker k_SaveProcessingStatesMarker; // 0x88
		private static ProfilerMarker k_GenerateTextPhaseIIMarker; // 0x90
		private static ProfilerMarker k_GenerateTextPhaseIIIMarker; // 0x98
	
		// Properties
		public int sortingLayerID { get; set; } // 0x000000018B30B248-0x000000018B30B2C4 0x000000018B30B4E0-0x000000018B30B57C
		public int sortingOrder { get; set; } // 0x000000018B30B2C4-0x000000018B30B340 0x000000018B30B57C-0x000000018B30B618
		public override bool autoSizeTextContainer { get; set; } // 0x0000000184DB9A50-0x0000000184DB9A60 0x000000018B30B460-0x000000018B30B4D0
		[Obsolete("The TextContainer is now obsolete. Use the RectTransform instead.")]
		public TextContainer textContainer { get; } // 0x00000001811EC580-0x00000001811EC590 
		public new Transform transform { get; } // 0x000000018B30B340-0x000000018B30B3D0 
		public Renderer renderer { get; } // 0x000000018B30B1B8-0x000000018B30B248 
		public override Mesh mesh { get; } // 0x000000018B30B0FC-0x000000018B30B1B8 
		public MeshFilter meshFilter { get; } // 0x000000018B30AFEC-0x000000018B30B0FC 
		public MaskingTypes maskType { get; set; } // 0x0000000184DB9A80-0x0000000184DB9A90 0x000000018B30B4D0-0x000000018B30B4E0
	
		// Events
		public override event Action<TMP_TextInfo> OnPreRenderText {
			add; // 0x000000018B30AF5C-0x000000018B30AFEC
			remove; // 0x000000018B30B3D0-0x000000018B30B460
		}
	
		// Constructors
		public TextMeshPro(); // 0x000000018B30AEA0-0x000000018B30AF5C
		static TextMeshPro(); // 0x000000018B30AA24-0x000000018B30AEA0
	
		// Methods
		public void SetMask(MaskingTypes type, Vector4 maskCoords); // 0x000000018B309128-0x000000018B309164
		public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY); // 0x000000018B3092EC-0x000000018B309348
		public override void SetVerticesDirty(); // 0x000000018B309D8C-0x000000018B309E08
		public override void SetLayoutDirty(); // 0x000000018B308EFC-0x000000018B308FA4
		public override void SetMaterialDirty(); // 0x000000018A973704-0x000000018A973714
		public override void SetAllDirty(); // 0x0000000184056D70-0x0000000184056DB0
		public override void Rebuild(CanvasUpdate update); // 0x000000018B306654-0x000000018B306718
		protected override void UpdateMaterial(); // 0x000000018B30A0D4-0x000000018B30A1F4
		public override void UpdateMeshPadding(); // 0x000000018B30A1F4-0x000000018B30A2FC
		public override void ForceMeshUpdate(bool ignoreActiveState = false /* Metadata: 0x02347096 */, bool forceTextReparsing = false /* Metadata: 0x02347097 */); // 0x000000018B305044-0x000000018B305058
		public override TMP_TextInfo GetTextInfo(string text); // 0x000000018B305880-0x000000018B3058D8
		public override void ClearMesh(bool updateMesh); // 0x000000018B304A44-0x000000018B304B2C
		public override void UpdateGeometry(Mesh mesh, int index); // 0x000000018B30A044-0x000000018B30A068
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x000000018B30A690-0x000000018B30A854
		public override void UpdateVertexData(); // 0x000000018B30A854-0x000000018B30AA24
		public void UpdateFontAsset(); // 0x000000018B303B60-0x000000018B303B70
		public void CalculateLayoutInputHorizontal(); // 0x00000001841E1670-0x00000001841E1680
		public void CalculateLayoutInputVertical(); // 0x00000001841E1670-0x00000001841E1680
		protected override void Awake(); // 0x000000018B30461C-0x000000018B304A44
		protected override void OnEnable(); // 0x000000018B306178-0x000000018B306254
		protected override void OnDisable(); // 0x000000018B3060DC-0x000000018B306178
		protected override void OnDestroy(); // 0x000000018B306018-0x000000018B3060C0
		protected override void LoadFontAsset(); // 0x000000018B305990-0x000000018B306018
		private void UpdateEnvMapMatrix(); // 0x000000018B309E08-0x000000018B30A044
		private void SetMask(MaskingTypes maskType); // 0x000000018B309164-0x000000018B3092EC
		private void SetMaskCoordinates(Vector4 coords); // 0x000000018B3090A4-0x000000018B309128
		private void SetMaskCoordinates(Vector4 coords, float softX, float softY); // 0x000000018B308FA4-0x000000018B3090A4
		private void EnableMasking(); // 0x000000018B304F28-0x000000018B305044
		private void DisableMasking(); // 0x000000018B304E0C-0x000000018B304F28
		private void UpdateMask(); // 0x000000018B30A068-0x000000018B30A0D4
		protected override Material GetMaterial(Material mat); // 0x000000018B305408-0x000000018B305514
		protected override Material[] GetMaterials(Material[] mats); // 0x000000018B305514-0x000000018B305690
		protected override void SetSharedMaterial(Material mat); // 0x000000018B3034A0-0x000000018B3034E0
		protected override Material[] GetSharedMaterials(); // 0x000000018B305690-0x000000018B3057E0
		protected override void SetSharedMaterials(Material[] materials); // 0x000000018B309A10-0x000000018B309D8C
		protected override void SetOutlineThickness(float thickness); // 0x000000018B309680-0x000000018B3097F0
		protected override void SetFaceColor(Color32 color); // 0x000000018B308DB4-0x000000018B308EFC
		protected override void SetOutlineColor(Color32 color); // 0x000000018B309538-0x000000018B309680
		private void CreateMaterialInstance(); // 0x000000018B304C74-0x000000018B304D4C
		protected override void SetShaderDepth(); // 0x000000018B309890-0x000000018B309A10
		protected override void SetCulling(); // 0x000000018B308A60-0x000000018B308DB4
		private void SetPerspectiveCorrection(); // 0x000000018B3097F0-0x000000018B309890
		protected override int SetArraySizes(UnicodeChar[] unicodeChars); // 0x000000018B306928-0x000000018B308A60
		public override void ComputeMarginSize(); // 0x000000018B304B2C-0x000000018B304C74
		protected override void OnDidApplyAnimationProperties(); // 0x000000018B3060C0-0x000000018B3060DC
		protected override void OnTransformParentChanged(); // 0x000000018B30662C-0x000000018B306654
		protected override void OnRectTransformDimensionsChange(); // 0x000000018B3064AC-0x000000018B30662C
		internal override void InternalUpdate(); // 0x000000018B3058D8-0x000000018B305990
		private void OnPreRenderObject(); // 0x000000018B306254-0x000000018B3064AC
		protected virtual void GenerateTextMesh(); // 0x000000018B2F4F6C-0x000000018B3008BC
		protected override Vector3[] GetTextContainerLocalCorners(); // 0x000000018B3057E0-0x000000018B305880
		private void SetMeshFilters(bool state); // 0x000000018B309348-0x000000018B309538
		protected override void SetActiveSubMeshes(bool state); // 0x000000018B306718-0x000000018B306814
		protected void SetActiveSubTextObjectRenderers(bool state); // 0x000000018B306814-0x000000018B306928
		protected override void DestroySubMeshObjects(); // 0x000000018B304D4C-0x000000018B304E0C
		internal void UpdateSubMeshSortingLayerID(int id); // 0x000000018B30A490-0x000000018B30A590
		internal void UpdateSubMeshSortingOrder(int order); // 0x000000018B30A590-0x000000018B30A690
		protected override Bounds GetCompoundBounds(); // 0x000000018B305058-0x000000018B305408
		private void UpdateSDFScale(float scaleDelta); // 0x000000018B30A2FC-0x000000018B30A490
	}

	[AddComponentMenu("UI/TextMeshPro - Text (UI)", 11)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.0")]
	[RequireComponent(typeof(CanvasRenderer))]
	[RequireComponent(typeof(RectTransform))]
	public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 55580
	{
		// Fields
		private bool m_isRebuildingLayout; // 0xAF8
		private Coroutine m_DelayedGraphicRebuild; // 0xB00
		private Coroutine m_DelayedMaterialRebuild; // 0xB08
		private Rect m_ClipRect; // 0xB10
		private bool m_ValidRect; // 0xB20
		[CompilerGenerated]
		private Action<TMP_TextInfo> OnPreRenderText; // 0xB28
		[SerializeField]
		private bool m_hasFontAssetChanged; // 0xB30
		protected TMP_SubMeshUI[] m_subTextObjects; // 0xB38
		protected Vector3[] m_RectTransformCorners; // 0xB40
		protected CanvasRenderer m_canvasRenderer; // 0xB48
		protected Canvas m_canvas; // 0xB50
		protected float m_CanvasScaleFactor; // 0xB58
		protected float m_previousLossyScaleY; // 0xB5C
		private bool m_isFirstAllocation; // 0xB60
		private int m_max_characters; // 0xB64
		[SerializeField]
		private Material m_baseMaterial; // 0xB68
		private bool m_isScrollRegionSet; // 0xB70
		[SerializeField]
		private Vector4 m_maskOffset; // 0xB74
		private Matrix4x4 m_EnvMapMatrix; // 0xB84
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0xBC4
		private static ProfilerMarker k_GenerateTextMarker; // 0x00
		private static ProfilerMarker k_SetArraySizesMarker; // 0x08
		private static ProfilerMarker k_GenerateTextPhaseIMarker; // 0x10
		private static ProfilerMarker k_ParseMarkupTextMarker; // 0x18
		private static ProfilerMarker k_CharacterLookupMarker; // 0x20
		private static ProfilerMarker k_HandleGPOSFeaturesMarker; // 0x28
		private static ProfilerMarker k_CalculateVerticesPositionMarker; // 0x30
		private static ProfilerMarker k_ComputeTextMetricsMarker; // 0x38
		private static ProfilerMarker k_HandleVisibleCharacterMarker; // 0x40
		private static ProfilerMarker k_HandleWhiteSpacesMarker; // 0x48
		private static ProfilerMarker k_HandleHorizontalLineBreakingMarker; // 0x50
		private static ProfilerMarker k_HandleVerticalLineBreakingMarker; // 0x58
		private static ProfilerMarker k_SaveGlyphVertexDataMarker; // 0x60
		private static ProfilerMarker k_ComputeCharacterAdvanceMarker; // 0x68
		private static ProfilerMarker k_HandleCarriageReturnMarker; // 0x70
		private static ProfilerMarker k_HandleLineTerminationMarker; // 0x78
		private static ProfilerMarker k_SavePageInfoMarker; // 0x80
		private static ProfilerMarker k_SaveProcessingStatesMarker; // 0x88
		private static ProfilerMarker k_GenerateTextPhaseIIMarker; // 0x90
		private static ProfilerMarker k_GenerateTextPhaseIIIMarker; // 0x98
	
		// Properties
		public override Material materialForRendering { get; } // 0x0000000183E32420-0x0000000183E32470 
		public override bool autoSizeTextContainer { get; set; } // 0x0000000184DB9A50-0x0000000184DB9A60 0x000000018B304584-0x000000018B3045F4
		public override Mesh mesh { get; } // 0x0000000184DB9A70-0x0000000184DB9A80 
		public new CanvasRenderer canvasRenderer { get; } // 0x0000000183E57CB0-0x0000000183E57D50 
		public Vector4 maskOffset { get; set; } // 0x0000000184DB9A60-0x0000000184DB9A70 0x000000018B3045F4-0x000000018B30461C
	
		// Events
		public override event Action<TMP_TextInfo> OnPreRenderText {
			add; // 0x000000018309B790-0x000000018309B800
			remove; // 0x000000018309B800-0x000000018309B8C0
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DelayedGraphicRebuild_d__18 : IEnumerator<object> // TypeDefIndex: 55578
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TextMeshProUGUI __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _DelayedGraphicRebuild_d__18(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B30B618-0x000000018B30B6C4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B30B6C4-0x000000018B30B760
		}
	
		[CompilerGenerated]
		private sealed class _DelayedMaterialRebuild_d__19 : IEnumerator<object> // TypeDefIndex: 55579
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TextMeshProUGUI __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _DelayedMaterialRebuild_d__19(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B319CF0-0x000000018B319DA4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B319DA4-0x000000018B319DF0
		}
	
		// Constructors
		public TextMeshProUGUI(); // 0x0000000183695970-0x0000000183695A00
		static TextMeshProUGUI(); // 0x00000001847CE1A0-0x00000001847CE670
	
		// Methods
		public void CalculateLayoutInputHorizontal(); // 0x00000001841E1670-0x00000001841E1680
		public void CalculateLayoutInputVertical(); // 0x00000001841E1670-0x00000001841E1680
		public override void SetVerticesDirty(); // 0x0000000183519FC0-0x000000018351A0A0
		public override void SetLayoutDirty(); // 0x00000001831E8280-0x00000001831E83F0
		public override void SetMaterialDirty(); // 0x000000018351A210-0x000000018351A2F0
		public override void SetAllDirty(); // 0x0000000184056D70-0x0000000184056DB0
		[IteratorStateMachine(typeof(_DelayedGraphicRebuild_d__18))]
		private IEnumerator DelayedGraphicRebuild(); // 0x000000018B30225C-0x000000018B3022B8
		[IteratorStateMachine(typeof(_DelayedMaterialRebuild_d__19))]
		private IEnumerator DelayedMaterialRebuild(); // 0x000000018B3022B8-0x000000018B302314
		public override void Rebuild(CanvasUpdate update); // 0x0000000183CF2490-0x0000000183CF2540
		private void UpdateSubObjectPivot(); // 0x00000001831E7FA0-0x00000001831E8050
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x0000000182EDE7E0-0x0000000182EDE870
		protected override void UpdateMaterial(); // 0x0000000183E57B40-0x0000000183E57CB0
		public override void RecalculateClipping(); // 0x0000000183F59BE0-0x0000000183F59BF0
		public override void Cull(Rect clipRect, bool validRect); // 0x000000018323F3B0-0x000000018323F6B0
		internal override void UpdateCulling(); // 0x0000000183F28900-0x0000000183F28AA0
		public override void UpdateMeshPadding(); // 0x000000018B30403C-0x000000018B304144
		protected override void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x0000000184731510-0x0000000184731570
		protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x000000018B302AA8-0x000000018B302B54
		public override void ForceMeshUpdate(bool ignoreActiveState = false /* Metadata: 0x02347098 */, bool forceTextReparsing = false /* Metadata: 0x02347099 */); // 0x0000000183CF23E0-0x0000000183CF2490
		public override TMP_TextInfo GetTextInfo(string text); // 0x000000018B3029DC-0x000000018B302AA8
		public override void ClearMesh(); // 0x0000000184404550-0x0000000184404610
		public override void UpdateGeometry(Mesh mesh, int index); // 0x000000018B303B70-0x000000018B303BFC
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x000000018B304144-0x000000018B30435C
		public override void UpdateVertexData(); // 0x000000018B30435C-0x000000018B304584
		public void UpdateFontAsset(); // 0x000000018B303B60-0x000000018B303B70
		protected override void Awake(); // 0x000000018351ED70-0x000000018351F170
		protected override void OnEnable(); // 0x000000018351C480-0x000000018351C5B0
		protected override void OnDisable(); // 0x0000000183519C60-0x0000000183519E20
		protected override void OnDestroy(); // 0x0000000183519510-0x00000001835196C0
		protected override void LoadFontAsset(); // 0x000000018333C620-0x000000018333CAC0
		private Canvas GetCanvas(); // 0x000000018351C5B0-0x000000018351C6F0
		private void UpdateEnvMapMatrix(); // 0x000000018B303924-0x000000018B303B60
		private void EnableMasking(); // 0x000000018B3023D4-0x000000018B3025D8
		private void DisableMasking(); // 0x00000001841E1670-0x00000001841E1680
		private void UpdateMask(); // 0x000000018B303BFC-0x000000018B30403C
		protected override Material GetMaterial(Material mat); // 0x000000018B3025D8-0x000000018B302708
		protected override Material[] GetMaterials(Material[] mats); // 0x000000018B302708-0x000000018B302888
		protected override void SetSharedMaterial(Material mat); // 0x000000018B3034A0-0x000000018B3034E0
		protected override Material[] GetSharedMaterials(); // 0x000000018B302888-0x000000018B3029DC
		protected override void SetSharedMaterials(Material[] materials); // 0x000000018B3034E0-0x000000018B303924
		protected override void SetOutlineThickness(float thickness); // 0x000000018B303104-0x000000018B3032DC
		protected override void SetFaceColor(Color32 color); // 0x000000018B302E18-0x000000018B302F34
		protected override void SetOutlineColor(Color32 color); // 0x000000018B302FE8-0x000000018B303104
		protected override void SetShaderDepth(); // 0x000000018B30337C-0x000000018B3034A0
		protected override void SetCulling(); // 0x000000018B302B54-0x000000018B302E18
		private void SetPerspectiveCorrection(); // 0x000000018B3032DC-0x000000018B30337C
		private void SetMeshArrays(int size); // 0x000000018B302F34-0x000000018B302FE8
		protected override int SetArraySizes(UnicodeChar[] unicodeChars); // 0x000000018333D430-0x000000018333E5E0
		public override void ComputeMarginSize(); // 0x00000001831E8050-0x00000001831E8280
		protected override void OnDidApplyAnimationProperties(); // 0x00000001843EE460-0x00000001843EE490
		protected override void OnCanvasHierarchyChanged(); // 0x0000000183B914B0-0x0000000183B91630
		protected override void OnTransformParentChanged(); // 0x0000000183F3AE50-0x0000000183F3AEA0
		protected override void OnRectTransformDimensionsChange(); // 0x00000001831E7C60-0x00000001831E7FA0
		internal override void InternalUpdate(); // 0x0000000182FAB6B0-0x0000000182FAB980
		private void OnPreRenderCanvas(); // 0x0000000183CF2540-0x0000000183CF2860
		protected virtual TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference); // 0x000000018B302218-0x000000018B30225C
		protected virtual void GenerateTextMesh(); // 0x0000000183254CE0-0x000000018325B760
		protected override Vector3[] GetTextContainerLocalCorners(); // 0x0000000183EADEF0-0x0000000183EADFB0
		protected override void SetActiveSubMeshes(bool state); // 0x0000000183E996F0-0x0000000183E997B0
		protected override void DestroySubMeshObjects(); // 0x000000018B302314-0x000000018B3023D4
		protected override Bounds GetCompoundBounds(); // 0x000000018323FC30-0x000000018323FF50
		internal override Rect GetCanvasSpaceClippingRect(); // 0x000000018323F6B0-0x000000018323FB20
		private void UpdateSDFScale(float scaleDelta); // 0x00000001831CC750-0x00000001831CC8E0
	}

	public enum Compute_DistanceTransform_EventTypes // TypeDefIndex: 55581
	{
		Processing = 0,
		Completed = 1
	}

	public static class TMPro_EventManager // TypeDefIndex: 55582
	{
		// Fields
		public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT; // 0x00
		public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT; // 0x08
		public static readonly FastAction<bool, UnityEngine.Object> FONT_PROPERTY_EVENT; // 0x10
		public static readonly FastAction<bool, UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT; // 0x18
		public static readonly FastAction<bool, UnityEngine.Object> TEXTMESHPRO_PROPERTY_EVENT; // 0x20
		public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; // 0x28
		public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT; // 0x30
		public static readonly FastAction<UnityEngine.Object> COLOR_GRADIENT_PROPERTY_EVENT; // 0x38
		public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; // 0x40
		public static readonly FastAction RESOURCE_LOAD_EVENT; // 0x48
		public static readonly FastAction<bool, UnityEngine.Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT; // 0x50
		public static readonly FastAction<UnityEngine.Object> TEXT_CHANGED_EVENT; // 0x58
	
		// Constructors
		static TMPro_EventManager(); // 0x000000018478E7A0-0x000000018478EC20
	
		// Methods
		public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat); // 0x000000018B31923C-0x000000018B3192BC
		public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj); // 0x000000018B3191BC-0x000000018B31923C
		public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj); // 0x000000018B319310-0x000000018B319390
		public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj); // 0x000000018B319390-0x000000018B319410
		public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial); // 0x000000018B319128-0x000000018B3191BC
		public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged); // 0x000000018B319490-0x000000018B3194FC
		public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(UnityEngine.Object obj); // 0x000000018B31903C-0x000000018B3190AC
		public static void ON_TEXT_CHANGED(UnityEngine.Object obj); // 0x00000001840736F0-0x0000000184073750
		public static void ON_TMP_SETTINGS_CHANGED(); // 0x000000018B3194FC-0x000000018B319550
		public static void ON_RESOURCES_LOADED(); // 0x000000018B3192BC-0x000000018B319310
		public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj); // 0x000000018B319410-0x000000018B319490
		public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e); // 0x000000018B3190AC-0x000000018B319128
	}

	public class Compute_DT_EventArgs // TypeDefIndex: 55583
	{
		// Fields
		public Compute_DistanceTransform_EventTypes EventType; // 0x10
		public float ProgressPercentage; // 0x14
		public UnityEngine.Color[] Colors; // 0x18
	
		// Constructors
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress); // 0x0000000184DB9A90-0x0000000184DB9AA0
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, UnityEngine.Color[] colors); // 0x0000000185391D70-0x0000000185391D80
	}

	public static class TMPro_ExtensionMethods // TypeDefIndex: 55584
	{
		// Extension methods
		public static int[] ToIntArray(this string text); // 0x000000018B319AC8-0x000000018B319B58
		public static string ArrayToString(this char[] chars); // 0x000000018B319550-0x000000018B319614
		public static string IntToString(this int[] unicodes); // 0x000000018B31978C-0x000000018B31980C
		internal static string UintToString(this List<uint> unicodes); // 0x000000018B319B58-0x000000018B319C08
		public static string IntToString(this int[] unicodes, int start, int length); // 0x000000018B31980C-0x000000018B3198E0
		public static int FindInstanceID<T>(this List<T> list, T target)
			where T : UnityEngine.Object;
		public static bool Compare(this Color32 a, Color32 b); // 0x0000000184D333E0-0x0000000184D33420
		public static bool CompareRGB(this Color32 a, Color32 b); // 0x000000018B319614-0x000000018B319638
		public static bool Compare(this UnityEngine.Color a, UnityEngine.Color b); // 0x000000018415FC30-0x000000018415FC70
		public static bool CompareRGB(this UnityEngine.Color a, UnityEngine.Color b); // 0x00000001830F9620-0x00000001830F9650
		public static Color32 Multiply(this Color32 c1, Color32 c2); // 0x000000018B319908-0x000000018B3199E8
		public static Color32 Tint(this Color32 c1, Color32 c2); // 0x000000018B319908-0x000000018B3199E8
		public static Color32 Tint(this Color32 c1, float tint); // 0x000000018B3199E8-0x000000018B319AC8
		public static UnityEngine.Color MinAlpha(this UnityEngine.Color c1, UnityEngine.Color c2); // 0x000000018B3198E0-0x000000018B319908
		public static bool Compare(this Vector3 v1, Vector3 v2, int accuracy); // 0x000000018B3196FC-0x000000018B31978C
		public static bool Compare(this Quaternion q1, Quaternion q2, int accuracy); // 0x000000018B319638-0x000000018B3196FC
	}

	public static class TMP_Math // TypeDefIndex: 55585
	{
		// Fields
		public const float FLOAT_MAX = 32767f; // Metadata: 0x0234709C
		public const float FLOAT_MIN = -32767f; // Metadata: 0x023470A0
		public const int INT_MAX = 2147483647; // Metadata: 0x023470A4
		public const int INT_MIN = -2147483647; // Metadata: 0x023470A5
		public const float FLOAT_UNSET = -32767f; // Metadata: 0x023470AA
		public const int INT_UNSET = -32767; // Metadata: 0x023470AE
		public static Vector2 MAX_16BIT; // 0x00
		public static Vector2 MIN_16BIT; // 0x08
	
		// Constructors
		static TMP_Math(); // 0x000000018B318CC4-0x000000018B318D20
	
		// Methods
		public static bool Approximately(float a, float b); // 0x000000018B318C88-0x000000018B318CAC
		public static int Mod(int a, int b); // 0x000000018B318CAC-0x000000018B318CC4
	}

	public enum TMP_VertexDataUpdateFlags // TypeDefIndex: 55586
	{
		None = 0,
		Vertices = 1,
		Uv0 = 2,
		Uv2 = 4,
		Uv4 = 8,
		Colors32 = 16,
		All = 255
	}

	[Serializable]
	public struct VertexGradient // TypeDefIndex: 55587
	{
		// Fields
		public UnityEngine.Color topLeft; // 0x00
		public UnityEngine.Color topRight; // 0x10
		public UnityEngine.Color bottomLeft; // 0x20
		public UnityEngine.Color bottomRight; // 0x30
	
		// Constructors
		public VertexGradient(UnityEngine.Color color); // 0x0000000184DB9C80-0x0000000184DB9CA0
		public VertexGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3); // 0x0000000184DB3220-0x0000000184DB3250
	}

	public struct TMP_PageInfo // TypeDefIndex: 55588
	{
		// Fields
		public int firstCharacterIndex; // 0x00
		public int lastCharacterIndex; // 0x04
		public float ascender; // 0x08
		public float baseLine; // 0x0C
		public float descender; // 0x10
	}

	public struct TMP_LinkInfo // TypeDefIndex: 55589
	{
		// Fields
		public TMP_Text textComponent; // 0x00
		public int hashCode; // 0x08
		public int linkIdFirstCharacterIndex; // 0x0C
		public int linkIdLength; // 0x10
		public int linkTextfirstCharacterIndex; // 0x14
		public int linkTextLength; // 0x18
		internal char[] linkID; // 0x20
	
		// Methods
		internal void SetLinkID(char[] text, int startIndex, int length); // 0x000000018B318BC4-0x000000018B318C88
		public string GetLinkText(); // 0x000000018B318AE4-0x000000018B318BC4
		public string GetLinkID(); // 0x000000018B318A58-0x000000018B318AE4
	}

	public struct TMP_WordInfo // TypeDefIndex: 55590
	{
		// Fields
		public TMP_Text textComponent; // 0x00
		public int firstCharacterIndex; // 0x08
		public int lastCharacterIndex; // 0x0C
		public int characterCount; // 0x10
	
		// Methods
		public string GetWord(); // 0x000000018B318F58-0x000000018B31903C
	}

	public struct TMP_SpriteInfo // TypeDefIndex: 55591
	{
		// Fields
		public int spriteIndex; // 0x00
		public int characterIndex; // 0x04
		public int vertexIndex; // 0x08
	}

	public struct Extents // TypeDefIndex: 55592
	{
		// Fields
		internal static Extents zero; // 0x00
		internal static Extents uninitialized; // 0x10
		public Vector2 min; // 0x00
		public Vector2 max; // 0x08
	
		// Constructors
		public Extents(Vector2 min, Vector2 max); // 0x0000000184D861B0-0x0000000184D861C0
		static Extents(); // 0x000000018B30BBB0-0x000000018B30BC08
	
		// Methods
		public override string ToString(); // 0x000000018B30BA2C-0x000000018B30BBB0
	}

	[Serializable]
	public struct Mesh_Extents // TypeDefIndex: 55593
	{
		// Fields
		public Vector2 min; // 0x00
		public Vector2 max; // 0x08
	
		// Constructors
		public Mesh_Extents(Vector2 min, Vector2 max); // 0x0000000184D861B0-0x0000000184D861C0
	
		// Methods
		public override string ToString(); // 0x000000018B30C7E8-0x000000018B30C96C
	}

	public struct WordWrapState // TypeDefIndex: 55594
	{
		// Fields
		public int previous_WordBreak; // 0x00
		public int total_CharacterCount; // 0x04
		public int visible_CharacterCount; // 0x08
		public int visible_SpriteCount; // 0x0C
		public int visible_LinkCount; // 0x10
		public int firstCharacterIndex; // 0x14
		public int firstVisibleCharacterIndex; // 0x18
		public int lastCharacterIndex; // 0x1C
		public int lastVisibleCharIndex; // 0x20
		public int lineNumber; // 0x24
		public float maxCapHeight; // 0x28
		public float maxAscender; // 0x2C
		public float maxLineAscenderWithOutImage; // 0x30
		public float maxDescender; // 0x34
		public float startOfLineAscender; // 0x38
		public float maxLineAscender; // 0x3C
		public float maxLineDescender; // 0x40
		public float pageAscender; // 0x44
		public HorizontalAlignmentOptions horizontalAlignment; // 0x48
		public float marginLeft; // 0x4C
		public float marginRight; // 0x50
		public float xAdvance; // 0x54
		public float preferredWidth; // 0x58
		public float preferredHeight; // 0x5C
		public float previousLineScale; // 0x60
		public int wordCount; // 0x64
		public FontStyles fontStyle; // 0x68
		public int italicAngle; // 0x6C
		public float fontScaleMultiplier; // 0x70
		public float currentFontSize; // 0x74
		public float baselineOffset; // 0x78
		public float lineOffset; // 0x7C
		public bool isDrivenLineSpacing; // 0x80
		public float glyphHorizontalAdvanceAdjustment; // 0x84
		public float cSpace; // 0x88
		public float mSpace; // 0x8C
		public TMP_TextInfo textInfo; // 0x90
		public TMP_LineInfo lineInfo; // 0x98
		public Color32 vertexColor; // 0xF4
		public Color32 underlineColor; // 0xF8
		public Color32 strikethroughColor; // 0xFC
		public Color32 highlightColor; // 0x100
		public TMP_FontStyleStack basicStyleStack; // 0x104
		public TMP_TextProcessingStack<int> italicAngleStack; // 0x110
		public TMP_TextProcessingStack<Color32> colorStack; // 0x130
		public TMP_TextProcessingStack<Color32> underlineColorStack; // 0x150
		public TMP_TextProcessingStack<Color32> strikethroughColorStack; // 0x170
		public TMP_TextProcessingStack<Color32> highlightColorStack; // 0x190
		public TMP_TextProcessingStack<HighlightState> highlightStateStack; // 0x1B0
		public TMP_TextProcessingStack<TMP_ColorGradient> colorGradientStack; // 0x1E0
		public TMP_TextProcessingStack<float> sizeStack; // 0x208
		public TMP_TextProcessingStack<float> indentStack; // 0x228
		public TMP_TextProcessingStack<FontWeight> fontWeightStack; // 0x248
		public TMP_TextProcessingStack<int> styleStack; // 0x268
		public TMP_TextProcessingStack<float> baselineStack; // 0x288
		public TMP_TextProcessingStack<int> actionStack; // 0x2A8
		public TMP_TextProcessingStack<MaterialReference> materialReferenceStack; // 0x2C8
		public TMP_TextProcessingStack<HorizontalAlignmentOptions> lineJustificationStack; // 0x320
		public TMP_TextProcessingQueue<PhoneticData> phoneticQueue; // 0x340
		public int spriteAnimationID; // 0x360
		public TMP_FontAsset currentFontAsset; // 0x368
		public TMP_SpriteAsset currentSpriteAsset; // 0x370
		public Material currentMaterial; // 0x378
		public int currentMaterialIndex; // 0x380
		public Extents meshExtents; // 0x384
		public bool tagNoParsing; // 0x394
		public bool isNonBreakingSpace; // 0x395
	}

	public struct TagAttribute // TypeDefIndex: 55595
	{
		// Fields
		public int startIndex; // 0x00
		public int length; // 0x04
		public int hashCode; // 0x08
	}

	public struct RichTextTagAttribute // TypeDefIndex: 55596
	{
		// Fields
		public int nameHashCode; // 0x00
		public int valueHashCode; // 0x04
		public TagValueType valueType; // 0x08
		public int valueStartIndex; // 0x0C
		public int valueLength; // 0x10
		public TagUnitType unitType; // 0x14
	}

	internal class TMP_ArrayObjectPool<T> // TypeDefIndex: 55598
	{
		// Fields
		private readonly Dictionary<int, Stack<T[]>> m_StackDic;
		private readonly UnityAction<T[]> m_ActionOnGet;
		private readonly UnityAction<T[]> m_ActionOnRelease;
		private readonly PoolOptions m_Options;
		private int m_TotalCachedCount;
		[CompilerGenerated]
		private int _countAll_k__BackingField;
	
		// Properties
		public int countAll { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int countActive { get; }
		public int countInactive { get; }
	
		// Nested types
		[IsReadOnly]
		internal struct PoolOptions // TypeDefIndex: 55597
		{
			// Fields
			public static readonly PoolOptions<T> Default;
			public readonly bool restrictArraySize;
			public readonly IReadOnlyList<int> allowedSizes;
			public readonly int maxTotalCachedCount;
	
			// Constructors
			public PoolOptions(bool restrictArraySize, IReadOnlyList<int> allowedSizes, int maxTotalCachedCount);
			static PoolOptions();
		}
	
		// Constructors
		public TMP_ArrayObjectPool(UnityAction<T[]> actionOnGet, UnityAction<T[]> actionOnRelease, PoolOptions options = default);
	
		// Methods
		public T[] Get(int count);
		public void Release(int count, T[] element);
		public void Shrink();
		private bool _CanUsePool(int count);
	}

	internal static class TMP_ArrayPool<T> // TypeDefIndex: 55600
	{
		// Fields
		private static readonly TMP_ArrayObjectPool<T> s_ArrayPool;
		private static readonly TMP_ArrayPoolWrapper<T> s_ArrayPoolWrapper;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55599
		{
			// Fields
			public static readonly __c<T> __9;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _.cctor_b__2_0(T[] arr);
		}
	
		// Constructors
		static TMP_ArrayPool();
	
		// Methods
		private static TMP_ArrayObjectPool<T> _CreateOptions();
		public static T[] Get(int count);
		public static void Release(T[] toRelease);
		public static void Resize(ref ref T[] array, int newCount);
		public static void Shrink();
	}

	public interface IPoolClearable // TypeDefIndex: 55601
	{
		// Methods
		void Clear();
	}

	internal interface ITMPArrayPoolRegistryItem // TypeDefIndex: 55602
	{
		// Methods
		void Shrink();
	}

	public static class TMP_ArrayPoolRegistry // TypeDefIndex: 55603
	{
		// Fields
		private static readonly List<ITMPArrayPoolRegistryItem> registeredPools; // 0x00
	
		// Constructors
		static TMP_ArrayPoolRegistry(); // 0x0000000184D16B00-0x0000000184D16B90
	
		// Methods
		internal static void Register(ITMPArrayPoolRegistryItem pool); // 0x0000000184390C40-0x0000000184390D20
		public static void ShrinkAll(); // 0x000000018458CE10-0x000000018458CF30
	}

	internal class TMP_ArrayPoolWrapper<T> : ITMPArrayPoolRegistryItem // TypeDefIndex: 55604
	{
		// Constructors
		public TMP_ArrayPoolWrapper();
	
		// Methods
		public void Shrink();
	}

	[Serializable]
	public abstract class TMP_Asset : ScriptableObject // TypeDefIndex: 55605
	{
		// Fields
		private int m_InstanceID; // 0x18
		public int hashCode; // 0x1C
		public Material material; // 0x20
		public int materialHashCode; // 0x28
	
		// Properties
		public int instanceID { get; } // 0x000000018333E5E0-0x000000018333E610 
	
		// Constructors
		protected TMP_Asset(); // 0x0000000183573370-0x0000000183573380
	}

	[Serializable]
	public class TMP_Character : TMP_TextElement // TypeDefIndex: 55606
	{
		// Constructors
		public TMP_Character(); // 0x0000000184DB9B40-0x0000000184DB9B50
		public TMP_Character(uint unicode, Glyph glyph); // 0x000000018B30CA24-0x000000018B30CA70
		public TMP_Character(uint unicode, TMP_FontAsset fontAsset, Glyph glyph); // 0x000000018393F5A0-0x000000018393F5F0
		internal TMP_Character(uint unicode, uint glyphIndex); // 0x000000018B30C9E4-0x000000018B30CA24
	}

	public struct TMP_Vertex // TypeDefIndex: 55607
	{
		// Fields
		public Vector3 position; // 0x00
		public Vector2 uv; // 0x0C
		public Vector2 uv2; // 0x14
		public Vector2 uv4; // 0x1C
		public Color32 color; // 0x24
		private static readonly TMP_Vertex k_Zero; // 0x00
	
		// Properties
		public static TMP_Vertex zero { get; } // 0x000000018B318EF8-0x000000018B318F58 
	
		// Constructors
		static TMP_Vertex(); // 0x00000001841E1670-0x00000001841E1680
	}

	public struct TMP_Offset // TypeDefIndex: 55608
	{
		// Fields
		private float m_Left; // 0x00
		private float m_Right; // 0x04
		private float m_Top; // 0x08
		private float m_Bottom; // 0x0C
		private static readonly TMP_Offset k_ZeroOffset; // 0x00
	
		// Properties
		public float left { get; set; } // 0x0000000184D871D0-0x0000000184D871E0 0x0000000184D932C0-0x0000000184D932D0
		public float right { get; set; } // 0x0000000184D9C560-0x0000000184D9C570 0x0000000184DAB920-0x0000000184DAB930
		public float top { get; set; } // 0x0000000184D9C280-0x0000000184D9C290 0x0000000184DAC1D0-0x0000000184DAC1E0
		public float bottom { get; set; } // 0x0000000184D9CC80-0x0000000184D9CC90 0x0000000184DACD70-0x0000000184DACD80
		public float horizontal { get; set; } // 0x0000000184D871D0-0x0000000184D871E0 0x0000000184DB4640-0x0000000184DB4650
		public float vertical { get; set; } // 0x0000000184D9C280-0x0000000184D9C290 0x0000000184DB9C70-0x0000000184DB9C80
		public static TMP_Offset zero { get; } // 0x000000018B318E4C-0x000000018B318E8C 
	
		// Constructors
		public TMP_Offset(float left, float right, float top, float bottom); // 0x0000000184D88AD0-0x0000000184D88AF0
		public TMP_Offset(float horizontal, float vertical); // 0x0000000184DB9C50-0x0000000184DB9C70
		static TMP_Offset(); // 0x0000000184D6F380-0x0000000184D6F3C0
	
		// Methods
		public static bool operator ==(TMP_Offset lhs, TMP_Offset rhs); // 0x000000018415FC30-0x000000018415FC70
		public static bool operator !=(TMP_Offset lhs, TMP_Offset rhs); // 0x000000018B318E8C-0x000000018B318EF8
		public static TMP_Offset operator *(TMP_Offset a, float b); // 0x000000018308B480-0x000000018308B4A0
		public override int GetHashCode(); // 0x000000018B318DFC-0x000000018B318E4C
		public override bool Equals(object obj); // 0x000000018B318D9C-0x000000018B318DFC
		public bool Equals(TMP_Offset other); // 0x000000018B318D20-0x000000018B318D9C
	}

	public struct HighlightState // TypeDefIndex: 55609
	{
		// Fields
		public Color32 color; // 0x00
		public TMP_Offset padding; // 0x04
	
		// Constructors
		public HighlightState(Color32 color, TMP_Offset padding); // 0x0000000184D9C150-0x0000000184D9C160
	
		// Methods
		public static bool operator ==(HighlightState lhs, HighlightState rhs); // 0x000000018B30BF8C-0x000000018B30C050
		public static bool operator !=(HighlightState lhs, HighlightState rhs); // 0x000000018B30C050-0x000000018B30C08C
		public override int GetHashCode(); // 0x000000018B30BF38-0x000000018B30BF8C
		public override bool Equals(object obj); // 0x000000018B30BE4C-0x000000018B30BEB0
		public bool Equals(HighlightState other); // 0x000000018B30BEB0-0x000000018B30BF38
	}

	[DebuggerDisplay("Unicode \'{character}\'  ({((uint)character).ToString(\"X\")})")]
	public struct TMP_CharacterInfo : IPoolClearable // TypeDefIndex: 55610
	{
		// Fields
		public char character; // 0x00
		public int index; // 0x04
		public int stringLength; // 0x08
		public TMP_TextElementType elementType; // 0x0C
		public TMP_TextElement textElement; // 0x10
		public TMP_FontAsset fontAsset; // 0x18
		public TMP_SpriteAsset spriteAsset; // 0x20
		public int spriteIndex; // 0x28
		public Material material; // 0x30
		public int materialReferenceIndex; // 0x38
		public bool isUsingAlternateTypeface; // 0x3C
		public float pointSize; // 0x40
		public int lineNumber; // 0x44
		public int pageNumber; // 0x48
		public int vertexIndex; // 0x4C
		public TMP_Vertex vertex_BL; // 0x50
		public TMP_Vertex vertex_TL; // 0x78
		public TMP_Vertex vertex_TR; // 0xA0
		public TMP_Vertex vertex_BR; // 0xC8
		public Vector3 topLeft; // 0xF0
		public Vector3 bottomLeft; // 0xFC
		public Vector3 topRight; // 0x108
		public Vector3 bottomRight; // 0x114
		public float origin; // 0x120
		public float xAdvance; // 0x124
		public float ascender; // 0x128
		public float baseLine; // 0x12C
		public float descender; // 0x130
		public float adjustedAscender; // 0x134
		public float adjustedDescender; // 0x138
		public float aspectRatio; // 0x13C
		public float scale; // 0x140
		public Color32 color; // 0x144
		public Color32 underlineColor; // 0x148
		public int underlineVertexIndex; // 0x14C
		public Color32 strikethroughColor; // 0x150
		public int strikethroughVertexIndex; // 0x154
		public Color32 highlightColor; // 0x158
		public HighlightState highlightState; // 0x15C
		public FontStyles style; // 0x170
		public bool isVisible; // 0x174
	
		// Methods
		public void Clear(); // 0x0000000183518F50-0x00000001835190A0
	}

	public enum ColorMode // TypeDefIndex: 55611
	{
		Single = 0,
		HorizontalGradient = 1,
		VerticalGradient = 2,
		FourCornersGradient = 3
	}

	[Serializable]
	[ExcludeFromPreset]
	public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 55612
	{
		// Fields
		public ColorMode colorMode; // 0x18
		public UnityEngine.Color topLeft; // 0x1C
		public UnityEngine.Color topRight; // 0x2C
		public UnityEngine.Color bottomLeft; // 0x3C
		public UnityEngine.Color bottomRight; // 0x4C
		private const ColorMode k_DefaultColorMode = ColorMode.FourCornersGradient; // Metadata: 0x023470BE
		private static readonly UnityEngine.Color k_DefaultColor; // 0x00
	
		// Constructors
		public TMP_ColorGradient(); // 0x000000018B30CAB4-0x000000018B30CB60
		public TMP_ColorGradient(UnityEngine.Color color); // 0x000000018B30CB60-0x000000018B30CBA4
		public TMP_ColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3); // 0x000000018B30CBA4-0x000000018B30CC14
		static TMP_ColorGradient(); // 0x000000018B30CA70-0x000000018B30CAB4
	}

	public static class TMP_Compatibility // TypeDefIndex: 55614
	{
		// Nested types
		public enum AnchorPositions // TypeDefIndex: 55613
		{
			TopLeft = 0,
			Top = 1,
			TopRight = 2,
			Left = 3,
			Center = 4,
			Right = 5,
			BottomLeft = 6,
			Bottom = 7,
			BottomRight = 8,
			BaseLine = 9,
			None = 10
		}
	
		// Methods
		public static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue); // 0x000000018B30CC14-0x000000018B30CD30
	}

	internal interface ITweenValue // TypeDefIndex: 55615
	{
		// Properties
		bool ignoreTimeScale { get; }
		float duration { get; }
	
		// Methods
		void TweenValue(float floatPercentage);
		bool ValidTarget();
	}

	internal struct ColorTween : ITweenValue // TypeDefIndex: 55618
	{
		// Fields
		private ColorTweenCallback m_Target; // 0x00
		private UnityEngine.Color m_StartColor; // 0x08
		private UnityEngine.Color m_TargetColor; // 0x18
		private ColorTweenMode m_TweenMode; // 0x28
		private float m_Duration; // 0x2C
		private bool m_IgnoreTimeScale; // 0x30
	
		// Properties
		public UnityEngine.Color startColor { get; set; } // 0x00000001815AD730-0x00000001815AD740 0x0000000184DA4E20-0x0000000184DA4E30
		public UnityEngine.Color targetColor { get; set; } // 0x0000000184D890C0-0x0000000184D890D0 0x0000000184D890D0-0x0000000184D890E0
		public ColorTweenMode tweenMode { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public float duration { get; set; } // 0x0000000184D86AF0-0x0000000184D86B00 0x0000000184D86B00-0x0000000184D86B10
		public bool ignoreTimeScale { get; set; } // 0x0000000184D865F0-0x0000000184D86600 0x0000000184D86620-0x0000000184D86630
	
		// Nested types
		public enum ColorTweenMode // TypeDefIndex: 55616
		{
			All = 0,
			RGB = 1,
			Alpha = 2
		}
	
		public class ColorTweenCallback : UnityEvent<UnityEngine.Color> // TypeDefIndex: 55617
		{
			// Constructors
			public ColorTweenCallback(); // 0x000000018B30B760-0x000000018B30B79C
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x000000018B30B834-0x000000018B30B90C
		public void AddOnChangedCallback(UnityAction<UnityEngine.Color> callback); // 0x000000018B30B79C-0x000000018B30B834
		public bool GetIgnoreTimescale(); // 0x0000000184D865F0-0x0000000184D86600
		public float GetDuration(); // 0x0000000184D86AF0-0x0000000184D86B00
		public bool ValidTarget(); // 0x0000000183A7A090-0x0000000183A7A0A0
	}

	internal struct FloatTween : ITweenValue // TypeDefIndex: 55620
	{
		// Fields
		private FloatTweenCallback m_Target; // 0x00
		private float m_StartValue; // 0x08
		private float m_TargetValue; // 0x0C
		private float m_Duration; // 0x10
		private bool m_IgnoreTimeScale; // 0x14
	
		// Properties
		public float startValue { get; set; } // 0x0000000184D9C280-0x0000000184D9C290 0x0000000184DAC1D0-0x0000000184DAC1E0
		public float targetValue { get; set; } // 0x0000000184D9CC80-0x0000000184D9CC90 0x0000000184DACD70-0x0000000184DACD80
		public float duration { get; set; } // 0x0000000184D85F70-0x0000000184D85F80 0x0000000184D88280-0x0000000184D88290
		public bool ignoreTimeScale { get; set; } // 0x0000000184D8EE50-0x0000000184D8EE60 0x0000000184D8EE70-0x0000000184D8EE80
	
		// Nested types
		public class FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 55619
		{
			// Constructors
			public FloatTweenCallback(); // 0x000000018B30BC08-0x000000018B30BC44
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x000000018B30BCDC-0x000000018B30BD40
		public void AddOnChangedCallback(UnityAction<float> callback); // 0x000000018B30BC44-0x000000018B30BCDC
		public bool GetIgnoreTimescale(); // 0x0000000184D8EE50-0x0000000184D8EE60
		public float GetDuration(); // 0x0000000184D85F70-0x0000000184D85F80
		public bool ValidTarget(); // 0x0000000183A7A090-0x0000000183A7A0A0
	}

	internal class TweenRunner<T> // TypeDefIndex: 55622
		where T : struct, ITweenValue
	{
		// Fields
		protected MonoBehaviour m_CoroutineContainer;
		protected IEnumerator m_Tween;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__2 : IEnumerator<object> // TypeDefIndex: 55621
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public T tweenInfo;
			private float _elapsedTime_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__2(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TweenRunner();
	
		// Methods
		[IteratorStateMachine(typeof(_Start_d__2))]
		private static IEnumerator Start(T tweenInfo);
		public void Init(MonoBehaviour coroutineContainer);
		public void StartTween(T info);
		public void StopTween();
	}

	public static class TMP_DefaultControls // TypeDefIndex: 55624
	{
		// Fields
		private const float kWidth = 160f; // Metadata: 0x023470CD
		private const float kThickHeight = 30f; // Metadata: 0x023470D1
		private const float kThinHeight = 20f; // Metadata: 0x023470D5
		private static Vector2 s_TextElementSize; // 0x00
		private static Vector2 s_ThickElementSize; // 0x08
		private static Vector2 s_ThinElementSize; // 0x10
		private static UnityEngine.Color s_DefaultSelectableColor; // 0x18
		private static UnityEngine.Color s_TextColor; // 0x28
	
		// Nested types
		public struct Resources // TypeDefIndex: 55623
		{
			// Fields
			public Sprite standard; // 0x00
			public Sprite background; // 0x08
			public Sprite inputField; // 0x10
			public Sprite knob; // 0x18
			public Sprite checkmark; // 0x20
			public Sprite dropdown; // 0x28
			public Sprite mask; // 0x30
		}
	
		// Constructors
		static TMP_DefaultControls(); // 0x000000018B30EA20-0x000000018B30EAC8
	
		// Methods
		private static GameObject CreateUIElementRoot(string name, Vector2 size); // 0x000000018B30E674-0x000000018B30E714
		private static GameObject CreateUIObject(string name, GameObject parent); // 0x000000018B30E714-0x000000018B30E7C4
		private static void SetDefaultTextValues(TMP_Text lbl); // 0x000000018B30E814-0x000000018B30E894
		private static void SetDefaultColorTransitionValues(Selectable slider); // 0x000000018B30E7C4-0x000000018B30E814
		private static void SetParentAndAlign(GameObject child, GameObject parent); // 0x000000018B30E954-0x000000018B30EA20
		private static void SetLayerRecursively(GameObject go, int layer); // 0x000000018B30E894-0x000000018B30E954
		public static GameObject CreateScrollbar(Resources resources); // 0x000000018B30E2FC-0x000000018B30E5D8
		public static GameObject CreateButton(Resources resources); // 0x000000018B30CD30-0x000000018B30CFAC
		public static GameObject CreateText(Resources resources); // 0x000000018B30E5D8-0x000000018B30E674
		public static GameObject CreateInputField(Resources resources); // 0x000000018B30DD54-0x000000018B30E2FC
		public static GameObject CreateDropdown(Resources resources); // 0x000000018B30CFAC-0x000000018B30DD54
	}

	[AddComponentMenu("UI/Dropdown - TextMeshPro", 35)]
	[RequireComponent(typeof(RectTransform))]
	public class TMP_Dropdown : Selectable, IPointerClickHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 55631
	{
		// Fields
		[SerializeField]
		private RectTransform m_Template; // 0x188
		[SerializeField]
		private TMP_Text m_CaptionText; // 0x190
		[SerializeField]
		private Image m_CaptionImage; // 0x198
		[SerializeField]
		private Graphic m_Placeholder; // 0x1A0
		[SerializeField]
		[Space]
		private TMP_Text m_ItemText; // 0x1A8
		[SerializeField]
		private Image m_ItemImage; // 0x1B0
		[SerializeField]
		[Space]
		private int m_Value; // 0x1B8
		[SerializeField]
		[Space]
		private OptionDataList m_Options; // 0x1C0
		[SerializeField]
		[Space]
		private DropdownEvent m_OnValueChanged; // 0x1C8
		[SerializeField]
		private float m_AlphaFadeSpeed; // 0x1D0
		private GameObject m_Dropdown; // 0x1D8
		private GameObject m_Blocker; // 0x1E0
		private List<DropdownItem> m_Items; // 0x1E8
		private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x1F0
		private bool validTemplate; // 0x1F8
		private Coroutine m_Coroutine; // 0x200
		private static OptionData s_NoOptionData; // 0x00
	
		// Properties
		public RectTransform template { get; set; } // 0x0000000184D8DA20-0x0000000184D8DA30 0x000000018B311974-0x000000018B31199C
		public TMP_Text captionText { get; set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018B3118A0-0x000000018B3118C8
		public Image captionImage { get; set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x000000018B311878-0x000000018B3118A0
		public Graphic placeholder { get; set; } // 0x0000000184D8DA10-0x0000000184D8DA20 0x000000018B31194C-0x000000018B311974
		public TMP_Text itemText { get; set; } // 0x0000000184D8D9C0-0x0000000184D8D9D0 0x000000018B3118F0-0x000000018B311918
		public Image itemImage { get; set; } // 0x0000000184D8D960-0x0000000184D8D970 0x000000018B3118C8-0x000000018B3118F0
		public List<OptionData> options { get; set; } // 0x000000018B311858-0x000000018B311878 0x000000018B311918-0x000000018B31194C
		public DropdownEvent onValueChanged { get; set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x0000000186B8B0D0-0x0000000186B8B0E4
		public float alphaFadeSpeed { get; set; } // 0x0000000184DB9B50-0x0000000184DB9B60 0x0000000184DB9B60-0x0000000184DB9B70
		public int value { get; set; } // 0x0000000184D8EAC0-0x0000000184D8EAD0 0x000000018B31199C-0x000000018B3119A8
		public bool IsExpanded { get; } // 0x000000018B311804-0x000000018B311858 
	
		// Nested types
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, ICancelHandler // TypeDefIndex: 55625
		{
			// Fields
			[SerializeField]
			private TMP_Text m_Text; // 0x18
			[SerializeField]
			private Image m_Image; // 0x20
			[SerializeField]
			private RectTransform m_RectTransform; // 0x28
			[SerializeField]
			private Toggle m_Toggle; // 0x30
	
			// Properties
			public TMP_Text text { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
			public Image image { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
			public RectTransform rectTransform { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
			public Toggle toggle { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
	
			// Constructors
			public DropdownItem(); // 0x0000000185393520-0x0000000185393538
	
			// Methods
			public virtual void OnPointerEnter(PointerEventData eventData); // 0x000000018B30B9C0-0x000000018B30BA2C
			public virtual void OnCancel(BaseEventData eventData); // 0x000000018B30B948-0x000000018B30B9C0
		}
	
		[Serializable]
		public class OptionData // TypeDefIndex: 55626
		{
			// Fields
			[SerializeField]
			private string m_Text; // 0x10
			[SerializeField]
			private Sprite m_Image; // 0x18
	
			// Properties
			public string text { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
			public Sprite image { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
			// Constructors
			public OptionData(); // 0x00000001841E1670-0x00000001841E1680
			public OptionData(string text); // 0x00000001853908C0-0x00000001853908D0
			public OptionData(Sprite image); // 0x0000000185392C40-0x0000000185392C50
			public OptionData(string text, Sprite image); // 0x00000001832AF420-0x00000001832AF450
		}
	
		[Serializable]
		public class OptionDataList // TypeDefIndex: 55627
		{
			// Fields
			[SerializeField]
			private List<OptionData> m_Options; // 0x10
	
			// Properties
			public List<OptionData> options { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
			// Constructors
			public OptionDataList(); // 0x000000018B30C96C-0x000000018B30C9E4
		}
	
		[Serializable]
		public class DropdownEvent : UnityEvent<int> // TypeDefIndex: 55628
		{
			// Constructors
			public DropdownEvent(); // 0x000000018B30B90C-0x000000018B30B948
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass69_0 // TypeDefIndex: 55629
		{
			// Fields
			public DropdownItem item; // 0x10
			public TMP_Dropdown __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass69_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Show_b__0(bool x); // 0x000000018B319E80-0x000000018B319EB0
		}
	
		[CompilerGenerated]
		private sealed class _DelayedDestroyDropdownList_d__81 : IEnumerator<object> // TypeDefIndex: 55630
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float delay; // 0x20
			public TMP_Dropdown __4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _DelayedDestroyDropdownList_d__81(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B319C08-0x000000018B319CA4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B319CA4-0x000000018B319CF0
		}
	
		// Constructors
		protected TMP_Dropdown(); // 0x000000018B3116DC-0x000000018B311804
		static TMP_Dropdown(); // 0x000000018B31166C-0x000000018B3116DC
	
		// Methods
		public void SetValueWithoutNotify(int input); // 0x000000018B310030-0x000000018B31003C
		private void SetValue(int value, bool sendCallback = true /* Metadata: 0x023470D9 */); // 0x000000018B31003C-0x000000018B310174
		protected override void Awake(); // 0x000000018B30F1A4-0x000000018B30F28C
		protected override void Start(); // 0x000000018B3115DC-0x000000018B31166C
		protected override void OnDisable(); // 0x000000018B30FB88-0x000000018B30FC1C
		public void RefreshShownValue(); // 0x000000018B30FD2C-0x000000018B30FF90
		public void AddOptions(List<OptionData> options); // 0x000000018B30ED54-0x000000018B30EDBC
		public void AddOptions(List<string> options); // 0x000000018B30EDBC-0x000000018B30EEAC
		public void AddOptions(List<Sprite> options); // 0x000000018B30EEAC-0x000000018B30EF9C
		public void ClearOptions(); // 0x000000018B30F28C-0x000000018B30F324
		private void SetupTemplate(); // 0x000000018B310174-0x000000018B310778
		private static T GetOrAddComponent<T>(GameObject go)
			where T : Component;
		public virtual void OnPointerClick(PointerEventData eventData); // 0x000000018B30FC1C-0x000000018B30FC24
		public virtual void OnSubmit(BaseEventData eventData); // 0x000000018B30FC1C-0x000000018B30FC24
		public virtual void OnCancel(BaseEventData eventData); // 0x000000018B30FB80-0x000000018B30FB88
		public void Show(); // 0x000000018B310778-0x000000018B3115DC
		protected virtual GameObject CreateBlocker(Canvas rootCanvas); // 0x000000018B30F324-0x000000018B30F758
		protected virtual void DestroyBlocker(GameObject blocker); // 0x000000018B30F86C-0x000000018B30F8B8
		protected virtual GameObject CreateDropdownList(GameObject template); // 0x000000018B30F758-0x000000018B30F7AC
		protected virtual void DestroyDropdownList(GameObject dropdownList); // 0x000000018B30F8B8-0x000000018B30F904
		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate); // 0x000000018B30F7AC-0x000000018B30F800
		protected virtual void DestroyItem(DropdownItem item); // 0x00000001841E1670-0x00000001841E1680
		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items); // 0x000000018B30EAC8-0x000000018B30ED54
		private void AlphaFadeList(float duration, float alpha); // 0x000000018B30F118-0x000000018B30F1A4
		private void AlphaFadeList(float duration, float start, float end); // 0x000000018B30EF9C-0x000000018B30F118
		private void SetAlpha(float alpha); // 0x000000018B30FF90-0x000000018B310030
		public void Hide(); // 0x000000018B30F904-0x000000018B30FA1C
		[IteratorStateMachine(typeof(_DelayedDestroyDropdownList_d__81))]
		private IEnumerator DelayedDestroyDropdownList(float delay); // 0x000000018B30F800-0x000000018B30F86C
		private void ImmediateDestroyDropdownList(); // 0x000000018B30FA1C-0x000000018B30FB80
		private void OnSelectItem(Toggle toggle); // 0x000000018B30FC24-0x000000018B30FD2C
	}

	public enum AtlasPopulationMode // TypeDefIndex: 55632
	{
		Static = 0,
		Dynamic = 1
	}

	[Serializable]
	[ExcludeFromPreset]
	public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 55634
	{
		// Fields
		[SerializeField]
		private string m_Version; // 0x30
		[SerializeField]
		internal string m_SourceFontFileGUID; // 0x38
		[SerializeField]
		private Font m_SourceFontFile; // 0x40
		[SerializeField]
		private float m_ThaiBiasConsonantsValue; // 0x48
		[Header("\u4FDD\u5B58\u7684\u65F6\u5019\u540C\u6B65\u4FEE\u6539\u7684\u6750\u8D28\u524D\u7F00\uFF0C\u4E0D\u586B\u641CFontAsset\u540D\u5B57")]
		[SerializeField]
		private string m_prefixMaterialSearchPatternValue; // 0x50
		[SerializeField]
		private AtlasPopulationMode m_AtlasPopulationMode; // 0x58
		[SerializeField]
		public FaceInfo m_FaceInfo; // 0x60
		[SerializeField]
		internal List<Glyph> m_GlyphTable; // 0xC0
		internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0xC8
		[SerializeField]
		internal List<TMP_Character> m_CharacterTable; // 0xD0
		public Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0xD8
		internal Texture2D m_AtlasTexture; // 0xE0
		[SerializeField]
		internal Texture2D[] m_AtlasTextures; // 0xE8
		[SerializeField]
		internal int m_AtlasTextureIndex; // 0xF0
		[SerializeField]
		private bool m_IsMultiAtlasTexturesEnabled; // 0xF4
		[SerializeField]
		private bool m_ClearDynamicDataOnBuild; // 0xF5
		[SerializeField]
		private List<GlyphRect> m_UsedGlyphRects; // 0xF8
		[SerializeField]
		private List<GlyphRect> m_FreeGlyphRects; // 0x100
		[SerializeField]
		private FaceInfo_Legacy m_fontInfo; // 0x108
		[SerializeField]
		public Texture2D atlas; // 0x110
		[SerializeField]
		internal int m_AtlasWidth; // 0x118
		[SerializeField]
		internal int m_AtlasHeight; // 0x11C
		[SerializeField]
		internal int m_AtlasPadding; // 0x120
		[SerializeField]
		internal GlyphRenderMode m_AtlasRenderMode; // 0x124
		[SerializeField]
		internal List<TMP_Glyph> m_glyphInfoList; // 0x128
		[FormerlySerializedAs("m_kerningInfo")]
		[SerializeField]
		internal KerningTable m_KerningTable; // 0x130
		[SerializeField]
		public TMP_FontFeatureTable m_FontFeatureTable; // 0x138
		[SerializeField]
		private List<TMP_FontAsset> fallbackFontAssets; // 0x140
		[SerializeField]
		internal List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x148
		[SerializeField]
		internal FontAssetCreationSettings m_CreationSettings; // 0x150
		[SerializeField]
		private TMP_FontWeightPair[] m_FontWeightTable; // 0x1A8
		[SerializeField]
		private TMP_FontWeightPair[] fontWeights; // 0x1B0
		public float normalStyle; // 0x1B8
		public float normalSpacingOffset; // 0x1BC
		public float boldStyle; // 0x1C0
		public float boldSpacing; // 0x1C4
		public byte italicStyle; // 0x1C8
		public byte tabSize; // 0x1C9
		public bool isUsedBySoftLink; // 0x1CA
		internal bool IsFontAssetLookupTablesDirty; // 0x1CB
		private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x00
		private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x08
		private static ProfilerMarker<uint> k_TryAddCharacterMarker; // 0x10
		private static ProfilerMarker k_TryAddCharactersMarker; // 0x18
		private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x20
		private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x28
		private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x30
		private static string s_DefaultMaterialSuffix; // 0x38
		internal HashSet<int> FallbackSearchQueryLookup; // 0x1D0
		private static HashSet<int> k_SearchedFontAssetLookup; // 0x40
		private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x48
		private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x50
		private static List<TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue; // 0x58
		private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x60
		private List<Glyph> m_GlyphsToRender; // 0x1D8
		private List<Glyph> m_GlyphsRendered; // 0x1E0
		private List<uint> m_GlyphIndexList; // 0x1E8
		private List<uint> m_GlyphIndexListNewlyAdded; // 0x1F0
		internal List<uint> m_GlyphsToAdd; // 0x1F8
		internal HashSet<uint> m_GlyphsToAddLookup; // 0x200
		internal List<TMP_Character> m_CharactersToAdd; // 0x208
		internal HashSet<uint> m_CharactersToAddLookup; // 0x210
		internal List<uint> s_MissingCharacterList; // 0x218
		internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x220
		internal static uint[] k_GlyphIndexArray; // 0x68
		private RenderTexture[] m_DynamicRenderTextures; // 0x228
	
		// Properties
		public string version { get; internal set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public Font sourceFontFile { get; internal set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public float thaiBiasConsonantsValue { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public string prefixMaterialSearchPatternValue { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public AtlasPopulationMode atlasPopulationMode { get; set; } // 0x0000000184D86570-0x0000000184D86580 0x0000000184D865D0-0x0000000184D865E0
		public FaceInfo faceInfo { get; set; } // 0x0000000184DB9BE0-0x0000000184DB9C20 0x000000018B318564-0x000000018B3185A8
		public List<Glyph> glyphTable { get; internal set; } // 0x0000000184D892F0-0x0000000184D89300 0x0000000186AC5ACC-0x0000000186AC5AE0
		public Dictionary<uint, Glyph> glyphLookupTable { get; } // 0x000000018B3184E4-0x000000018B318514 
		public List<TMP_Character> characterTable { get; internal set; } // 0x0000000184D876B0-0x0000000184D876C0 0x000000018678D7BC-0x000000018678D7D0
		public Dictionary<uint, TMP_Character> characterLookupTable { get; } // 0x000000018333EEE0-0x000000018333EF20 
		public Texture2D atlasTexture { get; } // 0x000000018351ECB0-0x000000018351ED70 
		public Texture2D[] atlasTextures { get; set; } // 0x0000000184D88590-0x0000000184D885A0 0x0000000186AC5B1C-0x0000000186AC5B30
		public int atlasTextureCount { get; } // 0x0000000184DB9B80-0x0000000184DB9B90 
		public bool isMultiAtlasTexturesEnabled { get; set; } // 0x0000000184DA7520-0x0000000184DA7530 0x0000000184DA7530-0x0000000184DA7540
		internal bool clearDynamicDataOnBuild { get; set; } // 0x0000000184DA7540-0x0000000184DA7550 0x0000000184DA7550-0x0000000184DA7560
		internal List<GlyphRect> usedGlyphRects { get; set; } // 0x0000000184D877C0-0x0000000184D877D0 0x0000000186790298-0x00000001867902AC
		internal List<GlyphRect> freeGlyphRects { get; set; } // 0x0000000184D87D50-0x0000000184D87D60 0x00000001867A5EA0-0x00000001867A5EB4
		[Obsolete("The fontInfo property and underlying type is now obsolete. Please use the faceInfo property and FaceInfo type instead.")]
		public FaceInfo_Legacy fontInfo { get; } // 0x0000000184D85F90-0x0000000184D85FA0 
		public int atlasWidth { get; internal set; } // 0x0000000184D87FF0-0x0000000184D88000 0x0000000184D88000-0x0000000184D88010
		public int atlasHeight { get; internal set; } // 0x0000000184DB9B70-0x0000000184DB9B80 0x0000000184DB9C20-0x0000000184DB9C30
		public int atlasPadding { get; internal set; } // 0x0000000184D90A90-0x0000000184D90AA0 0x0000000184D90AC0-0x0000000184D90AD0
		public GlyphRenderMode atlasRenderMode { get; internal set; } // 0x0000000184D90A80-0x0000000184D90A90 0x0000000184D90AB0-0x0000000184D90AC0
		public TMP_FontFeatureTable fontFeatureTable { get; internal set; } // 0x0000000184D8DC90-0x0000000184D8DCA0 0x0000000185397184-0x0000000185397198
		public List<TMP_FontAsset> fallbackFontAssetTable { get; set; } // 0x0000000184D8DAC0-0x0000000184D8DAD0 0x0000000186B8B468-0x0000000186B8B47C
		public FontAssetCreationSettings creationSettings { get; set; } // 0x0000000184DB9B90-0x0000000184DB9BE0 0x000000018B318514-0x000000018B318564
		public TMP_FontWeightPair[] fontWeightTable { get; internal set; } // 0x0000000184D8D9C0-0x0000000184D8D9D0 0x00000001853971F0-0x0000000185397204
		public RenderTexture[] dynamicRenderTextures { get; } // 0x0000000184D8D440-0x0000000184D8D450 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55633
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<TMP_Character, uint> __9__133_0; // 0x08
			public static Func<Glyph, uint> __9__134_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B319EB0-0x000000018B319F14
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal uint _SortCharacterTable_b__133_0(TMP_Character c); // 0x000000018B319DF0-0x000000018B319E08
			internal uint _SortGlyphTable_b__134_0(Glyph c); // 0x000000018AA421AC-0x000000018AA421C4
		}
	
		// Constructors
		public TMP_FontAsset(); // 0x000000018450C370-0x000000018450C7F0
		static TMP_FontAsset(); // 0x0000000184880740-0x0000000184880AB0
	
		// Methods
		public static TMP_FontAsset CreateFontAsset(Font font); // 0x000000018B312AC8-0x000000018B312B38
		public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic /* Metadata: 0x023470DC */, bool enableMultiAtlasSupport = true /* Metadata: 0x023470DD */); // 0x000000018B312B38-0x000000018B313088
		private void Awake(); // 0x0000000184A1E700-0x0000000184A1E7B0
		public void ReadFontAssetDefinition(); // 0x000000018393FB50-0x00000001839403C0
		internal void InitializeDictionaryLookupTables(); // 0x000000018393FB20-0x000000018393FB50
		internal void InitializeGlyphLookupDictionary(); // 0x000000018338C0B0-0x000000018338C2F0
		internal void InitializeCharacterLookupDictionary(); // 0x000000018393F800-0x000000018393FA00
		internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary(); // 0x000000018393FA00-0x000000018393FB20
		internal void AddSynthesizedCharactersAndFaceMetrics(); // 0x000000018393F3D0-0x000000018393F5A0
		private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false /* Metadata: 0x023470DE */); // 0x000000018393F5F0-0x000000018393F790
		internal void AddCharacterToLookupCache(uint unicode, TMP_Character character); // 0x000000018B3120F4-0x000000018B312198
		internal void SortCharacterTable(); // 0x000000018B3147CC-0x000000018B314938
		internal void SortGlyphTable(); // 0x000000018B31495C-0x000000018B314AC8
		internal void SortFontFeatureTable(); // 0x000000018B314938-0x000000018B31495C
		internal void SortAllTables(); // 0x000000018B3147A0-0x000000018B3147CC
		public bool HasCharacter(int character); // 0x000000018B313530-0x000000018B31358C
		public bool HasCharacter(char character, bool searchFallbacks = false /* Metadata: 0x023470DF */, bool tryAddCharacter = false /* Metadata: 0x023470E0 */); // 0x000000018B31358C-0x000000018B313A6C
		private bool HasCharacter_Internal(uint character, bool searchFallbacks = false /* Metadata: 0x023470E1 */, bool tryAddCharacter = false /* Metadata: 0x023470E2 */); // 0x000000018B313318-0x000000018B313530
		public bool HasCharacters(string text, out List<char> missingCharacters); // 0x000000018B313A6C-0x000000018B313BC0
		public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false /* Metadata: 0x023470E3 */, bool tryAddCharacter = false /* Metadata: 0x023470E4 */); // 0x000000018B313BC0-0x000000018B31418C
		public bool HasCharacters(string text); // 0x000000018B31418C-0x000000018B31422C
		public static string GetCharacters(TMP_FontAsset fontAsset); // 0x000000018B313154-0x000000018B313234
		public static int[] GetCharactersArray(TMP_FontAsset fontAsset); // 0x000000018B313088-0x000000018B313154
		internal uint GetGlyphIndex(uint unicode); // 0x000000018B313234-0x000000018B313318
		internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset); // 0x000000018B314348-0x000000018B314414
		internal static void UpdateFontFeaturesForFontAssetsInQueue(); // 0x0000000183CF2860-0x0000000183CF28D0
		internal static void RegisterFontAssetForAtlasTextureUpdate(TMP_FontAsset fontAsset); // 0x000000018B31427C-0x000000018B314348
		internal static void UpdateAtlasTexturesForFontAssetsInQueue(); // 0x000000018B31708C-0x000000018B3171B0
		public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false /* Metadata: 0x023470E5 */); // 0x000000018B31675C-0x000000018B316780
		public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false /* Metadata: 0x023470E6 */); // 0x000000018B315330-0x000000018B315D48
		public bool TryAddCharacters(string characters, bool includeFontFeatures = false /* Metadata: 0x023470E7 */); // 0x000000018B315D48-0x000000018B315D6C
		public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false /* Metadata: 0x023470E8 */); // 0x000000018B315D6C-0x000000018B31675C
		public void AddCharacters(string characters); // 0x000000018B312198-0x000000018B312248
		internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character); // 0x000000018B314AC8-0x000000018B315330
		internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character); // 0x000000018B316AF8-0x000000018B316F08
		internal void TryAddGlyphsToAtlasTextures(); // 0x00000001841E1670-0x00000001841E1680
		private bool TryAddGlyphsToNewAtlasTexture(); // 0x000000018B316780-0x000000018B316AF8
		private void SetupNewAtlasTexture(); // 0x000000018B314414-0x000000018B3147A0
		internal void UpdateAtlasTexture(); // 0x000000018B316F08-0x000000018B31708C
		internal void UpdateGlyphAdjustmentRecords(); // 0x000000018B3172B8-0x000000018B317518
		internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes); // 0x000000018B317518-0x000000018B317744
		internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes); // 0x00000001841E1670-0x00000001841E1680
		internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes); // 0x00000001841E1670-0x00000001841E1680
		private void CopyListDataToArray<T>(List<T> srcList, ref ref T[] dstArray);
		public void ClearFontAssetData(bool setAtlasSizeToZero = false /* Metadata: 0x023470E9 */); // 0x000000018B312904-0x000000018B312940
		public void ClearFontAssetData(); // 0x000000018B3128FC-0x000000018B312904
		internal void ClearFontAssetDataInternal(); // 0x000000018B3128D8-0x000000018B3128FC
		internal void UpdateFontAssetData(); // 0x000000018B3171B0-0x000000018B3172B8
		internal void ClearFontAssetTables(); // 0x000000018B312940-0x000000018B312AC8
		internal void ClearAtlasTextures(bool setAtlasSizeToZero = false /* Metadata: 0x023470EA */); // 0x000000018B312248-0x000000018B3128D8
		internal void UpgradeFontAsset(); // 0x000000018B317744-0x000000018B31814C
		private void UpgradeGlyphAdjustmentTableToFontFeatureTable(); // 0x000000018B31814C-0x000000018B3184E4
		private void OnDestroy(); // 0x000000018B31422C-0x000000018B31427C
	}

	[Serializable]
	public class FaceInfo_Legacy // TypeDefIndex: 55635
	{
		// Fields
		public string Name; // 0x10
		public float PointSize; // 0x18
		public float Scale; // 0x1C
		public int CharacterCount; // 0x20
		public float LineHeight; // 0x24
		public float Baseline; // 0x28
		public float Ascender; // 0x2C
		public float CapHeight; // 0x30
		public float Descender; // 0x34
		public float CenterLine; // 0x38
		public float SuperscriptOffset; // 0x3C
		public float SubscriptOffset; // 0x40
		public float SubSize; // 0x44
		public float Underline; // 0x48
		public float UnderlineThickness; // 0x4C
		public float strikethrough; // 0x50
		public float strikethroughThickness; // 0x54
		public float TabWidth; // 0x58
		public float Padding; // 0x5C
		public float AtlasWidth; // 0x60
		public float AtlasHeight; // 0x64
	
		// Constructors
		public FaceInfo_Legacy(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class TMP_Glyph : TMP_TextElement_Legacy // TypeDefIndex: 55636
	{
		// Constructors
		public TMP_Glyph(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static TMP_Glyph Clone(TMP_Glyph source); // 0x000000018B3189B8-0x000000018B318A58
	}

	[Serializable]
	public struct FontAssetCreationSettings // TypeDefIndex: 55637
	{
		// Fields
		public string sourceFontFileName; // 0x00
		public string sourceFontFileGUID; // 0x08
		public int pointSizeSamplingMode; // 0x10
		public int pointSize; // 0x14
		public int padding; // 0x18
		public int packingMode; // 0x1C
		public int atlasWidth; // 0x20
		public int atlasHeight; // 0x24
		public int characterSetSelectionMode; // 0x28
		public string characterSequence; // 0x30
		public string referencedFontAssetGUID; // 0x38
		public string referencedTextAssetGUID; // 0x40
		public int fontStyle; // 0x48
		public float fontStyleModifier; // 0x4C
		public int renderMode; // 0x50
		public bool includeFontFeatures; // 0x54
	
		// Constructors
		internal FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode); // 0x000000018B30BD40-0x000000018B30BE4C
	}

	[Serializable]
	public struct TMP_FontWeightPair // TypeDefIndex: 55638
	{
		// Fields
		public TMP_FontAsset regularTypeface; // 0x00
		public TMP_FontAsset italicTypeface; // 0x08
	}

	public struct KerningPairKey // TypeDefIndex: 55639
	{
		// Fields
		public uint ascii_Left; // 0x00
		public uint ascii_Right; // 0x04
		public uint key; // 0x08
	
		// Constructors
		public KerningPairKey(uint ascii_left, uint ascii_right); // 0x0000000184DB9AC0-0x0000000184DB9AE0
	}

	[Serializable]
	public struct GlyphValueRecord_Legacy // TypeDefIndex: 55640
	{
		// Fields
		public float xPlacement; // 0x00
		public float yPlacement; // 0x04
		public float xAdvance; // 0x08
		public float yAdvance; // 0x0C
	
		// Constructors
		internal GlyphValueRecord_Legacy(GlyphValueRecord valueRecord); // 0x0000000184DB9AA0-0x0000000184DB9AC0
	
		// Methods
		public static GlyphValueRecord_Legacy operator +(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b); // 0x00000001830E87A0-0x00000001830E87F0
	}

	[Serializable]
	public class KerningPair // TypeDefIndex: 55641
	{
		// Fields
		[FormerlySerializedAs("AscII_Left")]
		[SerializeField]
		private uint m_FirstGlyph; // 0x10
		[SerializeField]
		private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
		[FormerlySerializedAs("AscII_Right")]
		[SerializeField]
		private uint m_SecondGlyph; // 0x24
		[SerializeField]
		private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
		[FormerlySerializedAs("XadvanceOffset")]
		public float xOffset; // 0x38
		internal static KerningPair empty; // 0x00
		[SerializeField]
		private bool m_IgnoreSpacingAdjustments; // 0x3C
	
		// Properties
		public uint firstGlyph { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		public GlyphValueRecord_Legacy firstGlyphAdjustments { get; } // 0x0000000184D95480-0x0000000184D95490 
		public uint secondGlyph { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
		public GlyphValueRecord_Legacy secondGlyphAdjustments { get; } // 0x0000000184D8FAD0-0x0000000184D8FAE0 
		public bool ignoreSpacingAdjustments { get; } // 0x0000000184D86BD0-0x0000000184D86BE0 
	
		// Constructors
		public KerningPair(); // 0x0000000184DB9B20-0x0000000184DB9B40
		public KerningPair(uint left, uint right, float offset); // 0x0000000184DB9AF0-0x0000000184DB9B00
		public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments); // 0x0000000184DB9B00-0x0000000184DB9B20
		static KerningPair(); // 0x0000000184D22C20-0x0000000184D22CA0
	
		// Methods
		internal void ConvertLegacyKerningData(); // 0x0000000184DB9AE0-0x0000000184DB9AF0
	}

	[Serializable]
	public class KerningTable // TypeDefIndex: 55646
	{
		// Fields
		public List<KerningPair> kerningPairs; // 0x10
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 55642
		{
			// Fields
			public uint first; // 0x10
			public uint second; // 0x14
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _AddKerningPair_b__0(KerningPair item); // 0x000000018B319E20-0x000000018B319E4C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 55643
		{
			// Fields
			public uint first; // 0x10
			public uint second; // 0x14
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _AddGlyphPairAdjustmentRecord_b__0(KerningPair item); // 0x000000018B319E20-0x000000018B319E4C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 55644
		{
			// Fields
			public int left; // 0x10
			public int right; // 0x14
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _RemoveKerningPair_b__0(KerningPair item); // 0x000000018B319E4C-0x000000018B319E80
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55645
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KerningPair, uint> __9__7_0; // 0x08
			public static Func<KerningPair, uint> __9__7_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B319F14-0x000000018B31A044
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal uint _SortKerningPairs_b__7_0(KerningPair s); // 0x000000018AA421AC-0x000000018AA421C4
			internal uint _SortKerningPairs_b__7_1(KerningPair s); // 0x000000018B319E08-0x000000018B319E20
		}
	
		// Constructors
		public KerningTable(); // 0x000000018450C7F0-0x000000018450C870
	
		// Methods
		public void AddKerningPair(); // 0x000000018B30C33C-0x000000018B30C474
		public int AddKerningPair(uint first, uint second, float offset); // 0x000000018B30C1F0-0x000000018B30C33C
		public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments); // 0x000000018B30C08C-0x000000018B30C1F0
		public void RemoveKerningPair(int left, int right); // 0x000000018B30C474-0x000000018B30C574
		public void RemoveKerningPair(int index); // 0x000000018B30C574-0x000000018B30C5C8
		public void SortKerningPairs(); // 0x000000018B30C5C8-0x000000018B30C7E8
	}

	public static class TMP_FontUtilities // TypeDefIndex: 55647
	{
		// Fields
		private static List<int> k_searchedFontAssets; // 0x00
	
		// Methods
		public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character); // 0x000000018B3188B8-0x000000018B3189B8
		public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character); // 0x000000018B3188B0-0x000000018B3188B8
		private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character); // 0x000000018B3185A8-0x000000018B3187D4
		private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character); // 0x000000018B3187D4-0x000000018B3188B0
	}

	public class TMP_FontAssetUtilities // TypeDefIndex: 55648
	{
		// Fields
		private static readonly TMP_FontAssetUtilities s_Instance; // 0x00
		private static HashSet<int> k_SearchedAssets; // 0x08
		private static bool k_IsFontEngineInitialized; // 0x10
	
		// Properties
		public static TMP_FontAssetUtilities instance { get; } // 0x000000018B3120A4-0x000000018B3120F4 
	
		// Constructors
		static TMP_FontAssetUtilities(); // 0x0000000184D4DA10-0x0000000184D4DA70
		public TMP_FontAssetUtilities(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface); // 0x000000018333E700-0x000000018333E780
		private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface); // 0x000000018333E780-0x000000018333EEE0
		public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface); // 0x000000018B3119A8-0x000000018B311C00
		public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks); // 0x000000018B311DB8-0x000000018B3120A4
		private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks); // 0x000000018B311C00-0x000000018B311DB8
	}

	[Flags]
	public enum FontFeatureLookupFlags // TypeDefIndex: 55649
	{
		None = 0,
		IgnoreLigatures = 4,
		IgnoreSpacingAdjustments = 256
	}

	[Serializable]
	public struct TMP_GlyphValueRecord // TypeDefIndex: 55650
	{
		// Fields
		[SerializeField]
		internal float m_XPlacement; // 0x00
		[SerializeField]
		internal float m_YPlacement; // 0x04
		[SerializeField]
		internal float m_XAdvance; // 0x08
		[SerializeField]
		internal float m_YAdvance; // 0x0C
	
		// Properties
		public float xPlacement { get; set; } // 0x0000000184D871D0-0x0000000184D871E0 0x0000000184D932C0-0x0000000184D932D0
		public float yPlacement { get; set; } // 0x0000000184D9C560-0x0000000184D9C570 0x0000000184DAB920-0x0000000184DAB930
		public float xAdvance { get; set; } // 0x0000000184D9C280-0x0000000184D9C290 0x0000000184DAC1D0-0x0000000184DAC1E0
		public float yAdvance { get; set; } // 0x0000000184D9CC80-0x0000000184D9CC90 0x0000000184DACD70-0x0000000184DACD80
	
		// Constructors
		public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance); // 0x0000000184D88AD0-0x0000000184D88AF0
		internal TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord); // 0x0000000184D92B90-0x0000000184D92BB0
		internal TMP_GlyphValueRecord(GlyphValueRecord valueRecord); // 0x0000000184DB9AA0-0x0000000184DB9AC0
	
		// Methods
		public static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b); // 0x0000000184DB9C30-0x0000000184DB9C50
	}

	[Serializable]
	public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 55651
	{
		// Fields
		[SerializeField]
		internal uint m_GlyphIndex; // 0x00
		[SerializeField]
		internal TMP_GlyphValueRecord m_GlyphValueRecord; // 0x04
	
		// Properties
		public uint glyphIndex { get; set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public TMP_GlyphValueRecord glyphValueRecord { get; set; } // 0x0000000184D9C2B0-0x0000000184D9C2C0 0x0000000184DB9CC0-0x0000000184DB9CD0
	
		// Constructors
		public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord); // 0x0000000184D9C150-0x0000000184D9C160
		internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord); // 0x000000018B31A444-0x000000018B31A48C
	}

	[Serializable]
	public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 55652
	{
		// Fields
		[SerializeField]
		public TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
		[SerializeField]
		public TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
		[SerializeField]
		public FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38
	
		// Properties
		public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; } // 0x0000000184D8FE30-0x0000000184D8FE50 0x0000000184DA39A0-0x0000000184DA39B0
		public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; } // 0x0000000184DB9D00-0x0000000184DB9D20 0x0000000184DB9D20-0x0000000184DB9D30
		public FontFeatureLookupFlags featureLookupFlags { get; set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
	
		// Constructors
		public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord); // 0x0000000184DB9CD0-0x0000000184DB9D00
		internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord); // 0x000000018B31A48C-0x000000018B31A55C
	}

	public struct GlyphPairKey // TypeDefIndex: 55653
	{
		// Fields
		public uint firstGlyphIndex; // 0x00
		public uint secondGlyphIndex; // 0x04
		public uint key; // 0x08
	
		// Constructors
		public GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex); // 0x0000000184DB9CA0-0x0000000184DB9CC0
		internal GlyphPairKey(TMP_GlyphPairAdjustmentRecord record); // 0x000000018B31A044-0x000000018B31A074
	}

	[Serializable]
	public class TMP_FontFeatureTable // TypeDefIndex: 55655
	{
		// Fields
		[SerializeField]
		internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
		public Dictionary<uint, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18
	
		// Properties
		public List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55654
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> __9__6_0; // 0x08
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> __9__6_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B321904-0x000000018B321968
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal uint _SortGlyphPairAdjustmentRecords_b__6_0(TMP_GlyphPairAdjustmentRecord s); // 0x000000018B3218D4-0x000000018B3218EC
			internal uint _SortGlyphPairAdjustmentRecords_b__6_1(TMP_GlyphPairAdjustmentRecord s); // 0x000000018B3218EC-0x000000018B321904
		}
	
		// Constructors
		public TMP_FontFeatureTable(); // 0x000000018450C870-0x000000018450C940
	
		// Methods
		public void SortGlyphPairAdjustmentRecords(); // 0x000000018B31A224-0x000000018B31A444
	}

	[AddComponentMenu("UI/TextMeshPro - Input Field", 11)]
	public class TMP_InputField : Selectable, IUpdateSelectedHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, UnityEngine.EventSystems.IScrollHandler // TypeDefIndex: 55669
	{
		// Fields
		protected TouchScreenKeyboard m_SoftKeyboard; // 0x188
		private static readonly char[] kSeparators; // 0x00
		protected RectTransform m_RectTransform; // 0x190
		[SerializeField]
		protected RectTransform m_TextViewport; // 0x198
		protected RectMask2D m_TextComponentRectMask; // 0x1A0
		protected RectMask2D m_TextViewportRectMask; // 0x1A8
		private Rect m_CachedViewportRect; // 0x1B0
		[SerializeField]
		protected TMP_Text m_TextComponent; // 0x1C0
		protected RectTransform m_TextComponentRectTransform; // 0x1C8
		[SerializeField]
		protected Graphic m_Placeholder; // 0x1D0
		[SerializeField]
		protected Scrollbar m_VerticalScrollbar; // 0x1D8
		[SerializeField]
		protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x1E0
		private bool m_IsDrivenByLayoutComponents; // 0x1E8
		[SerializeField]
		private LayoutGroup m_LayoutGroup; // 0x1F0
		private UnityEngine.EventSystems.IScrollHandler m_IScrollHandlerParent; // 0x1F8
		private float m_ScrollPosition; // 0x200
		[SerializeField]
		protected float m_ScrollSensitivity; // 0x204
		[SerializeField]
		private ContentType m_ContentType; // 0x208
		[SerializeField]
		private InputType m_InputType; // 0x20C
		[SerializeField]
		private char m_AsteriskChar; // 0x210
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType; // 0x214
		[SerializeField]
		private LineType m_LineType; // 0x218
		[SerializeField]
		private bool m_HideMobileInput; // 0x21C
		[SerializeField]
		private bool m_HideSoftKeyboard; // 0x21D
		[SerializeField]
		private CharacterValidation m_CharacterValidation; // 0x220
		[SerializeField]
		private string m_RegexValue; // 0x228
		[SerializeField]
		private float m_GlobalPointSize; // 0x230
		[SerializeField]
		private int m_CharacterLimit; // 0x234
		[SerializeField]
		private SubmitEvent m_OnEndEdit; // 0x238
		[SerializeField]
		private SubmitEvent m_OnSubmit; // 0x240
		[SerializeField]
		private SelectionEvent m_OnSelect; // 0x248
		[SerializeField]
		private SelectionEvent m_OnDeselect; // 0x250
		[SerializeField]
		private TextSelectionEvent m_OnTextSelection; // 0x258
		[SerializeField]
		private TextSelectionEvent m_OnEndTextSelection; // 0x260
		[SerializeField]
		private OnChangeEvent m_OnValueChanged; // 0x268
		[SerializeField]
		private TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x270
		[SerializeField]
		private OnValidateInput m_OnValidateInput; // 0x278
		[SerializeField]
		private UnityEvent m_OnFocused; // 0x280
		[SerializeField]
		private UnityEngine.Color m_CaretColor; // 0x288
		[SerializeField]
		private bool m_CustomCaretColor; // 0x298
		[SerializeField]
		private UnityEngine.Color m_SelectionColor; // 0x29C
		[SerializeField]
		[TextArea(5, 10)]
		protected string m_Text; // 0x2B0
		[Range(0f, 4f)]
		[SerializeField]
		private float m_CaretBlinkRate; // 0x2B8
		[Range(1f, 5f)]
		[SerializeField]
		private int m_CaretWidth; // 0x2BC
		[SerializeField]
		private bool m_ReadOnly; // 0x2C0
		[SerializeField]
		private bool m_RichText; // 0x2C1
		[SerializeField]
		private bool m_disableUpDownArrowKeyMovingCaret; // 0x2C2
		[SerializeField]
		private bool m_disableLeftRightArrowKeyMovingCaret; // 0x2C3
		protected int m_StringPosition; // 0x2C4
		protected int m_StringSelectPosition; // 0x2C8
		protected int m_CaretPosition; // 0x2CC
		protected int m_CaretSelectPosition; // 0x2D0
		private RectTransform caretRectTrans; // 0x2D8
		protected UIVertex[] m_CursorVerts; // 0x2E0
		private CanvasRenderer m_CachedInputRenderer; // 0x2E8
		private Vector2 m_LastPosition; // 0x2F0
		[NonSerialized]
		protected Mesh m_Mesh; // 0x2F8
		private bool m_AllowInput; // 0x300
		private bool m_ShouldActivateNextUpdate; // 0x301
		private bool m_UpdateDrag; // 0x302
		private bool m_DragPositionOutOfBounds; // 0x303
		private const float kHScrollSpeed = 0.05f; // Metadata: 0x023470F1
		private const float kVScrollSpeed = 0.1f; // Metadata: 0x023470F5
		protected bool m_CaretVisible; // 0x304
		private Coroutine m_BlinkCoroutine; // 0x308
		private float m_BlinkStartTime; // 0x310
		private Coroutine m_DragCoroutine; // 0x318
		private string m_OriginalText; // 0x320
		private bool m_WasCanceled; // 0x328
		private bool m_HasDoneFocusTransition; // 0x329
		private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x330
		private bool m_PreventCallback; // 0x338
		private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x339
		private bool m_IsTextComponentUpdateRequired; // 0x33A
		private bool m_isLastKeyBackspace; // 0x33B
		private float m_PointerDownClickStartTime; // 0x33C
		private float m_KeyDownStartTime; // 0x340
		private float m_DoubleClickDelay; // 0x344
		private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~"; // Metadata: 0x023470F9
		private bool m_IsCompositionActive; // 0x348
		private bool m_ShouldUpdateIMEWindowPosition; // 0x349
		private int m_PreviousIMEInsertionLine; // 0x34C
		public Func<string, int, string> onValidateCharacterLimit; // 0x350
		public Func<string, int> onGetTextLength; // 0x358
		[SerializeField]
		protected bool m_OnFocusSelectAll; // 0x360
		protected bool m_isSelectAll; // 0x361
		[SerializeField]
		protected bool m_ResetOnDeActivation; // 0x362
		private bool m_SelectionStillActive; // 0x363
		private bool m_ReleaseSelection; // 0x364
		private GameObject m_PreviouslySelectedObject; // 0x368
		[SerializeField]
		private bool m_RestoreOriginalTextOnEscape; // 0x370
		[SerializeField]
		private bool m_WontReleaseSelectionOnEscape; // 0x371
		private bool m_tempClearCompositionString; // 0x372
		[SerializeField]
		protected bool m_isRichTextEditingAllowed; // 0x373
		[SerializeField]
		protected int m_LineLimit; // 0x374
		[SerializeField]
		protected TMP_InputValidator m_InputValidator; // 0x378
		private bool m_isSelected; // 0x380
		private bool m_IsStringPositionDirty; // 0x381
		private bool m_IsCaretPositionDirty; // 0x382
		private bool m_forceRectTransformAdjustment; // 0x383
		private UnityEngine.Event m_ProcessingEvent; // 0x388
	
		// Properties
		public bool isLastKeyBackspace { get; set; } // 0x0000000184DB9DA0-0x0000000184DB9DB0 0x0000000184DB9E70-0x0000000184DB9E80
		private BaseInput inputSystem { get; } // 0x0000000183795980-0x0000000183795B00 
		private string compositionString { get; } // 0x0000000183795240-0x00000001837952F0 
		private int compositionLength { get; } // 0x0000000183794E90-0x0000000183794EC0 
		protected Mesh mesh { get; } // 0x0000000183797620-0x00000001837976E0 
		public bool shouldHideMobileInput { get; set; } // 0x000000018B31E21C-0x000000018B31E24C 0x000000018B31EC58-0x000000018B31ECC4
		public bool shouldHideSoftKeyboard { get; set; } // 0x000000018B31E24C-0x000000018B31E2A0 0x000000018B31ECC4-0x000000018B31EDD8
		public string text { get; set; } // 0x0000000184D8DEA0-0x0000000184D8DEB0 0x000000018B31EEB8-0x000000018B31EEC4
		public bool isFocused { get; } // 0x0000000184D92940-0x0000000184D92950 
		public float caretBlinkRate { get; set; } // 0x0000000184DB9D40-0x0000000184DB9D50 0x000000018B31E2FC-0x000000018B31E364
		public int caretWidth { get; set; } // 0x0000000184DB9D50-0x0000000184DB9D60 0x000000018B31E3DC-0x000000018B31E438
		public RectTransform textViewport { get; set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x000000018B31EE6C-0x000000018B31EEB8
		public TMP_Text textComponent { get; set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x000000018B31EE10-0x000000018B31EE6C
		public Graphic placeholder { get; set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x000000018B31E9D8-0x000000018B31EA24
		public Scrollbar verticalScrollbar { get; set; } // 0x0000000184D87870-0x0000000184D87880 0x000000018B31EEC4-0x000000018B31F060
		public float scrollSensitivity { get; set; } // 0x0000000184DA2420-0x0000000184DA2430 0x000000018B31EACC-0x000000018B31EB28
		public UnityEngine.Color caretColor { get; set; } // 0x0000000183797430-0x00000001837974A0 0x000000018B31E364-0x000000018B31E3A4
		public bool customCaretColor { get; set; } // 0x0000000184D90190-0x0000000184D901A0 0x000000018B31E4F8-0x000000018B31E510
		public UnityEngine.Color selectionColor { get; set; } // 0x0000000184DB9E30-0x0000000184DB9E40 0x000000018B31EB64-0x000000018B31EBA4
		public SubmitEvent onEndEdit { get; set; } // 0x0000000184D8DAD0-0x0000000184D8DAE0 0x000000018B31E778-0x000000018B31E7C4
		public SubmitEvent onSubmit { get; set; } // 0x0000000184D8DE80-0x0000000184D8DE90 0x000000018B31E8A8-0x000000018B31E8F4
		public SelectionEvent onSelect { get; set; } // 0x0000000184D8D840-0x0000000184D8D850 0x000000018B31E85C-0x000000018B31E8A8
		public SelectionEvent onDeselect { get; set; } // 0x0000000184D8DCE0-0x0000000184D8DCF0 0x000000018B31E72C-0x000000018B31E778
		public TextSelectionEvent onTextSelection { get; set; } // 0x0000000184D8DE70-0x0000000184D8DE80 0x000000018B31E8F4-0x000000018B31E940
		public TextSelectionEvent onEndTextSelection { get; set; } // 0x0000000184D8D810-0x0000000184D8D820 0x000000018B31E7C4-0x000000018B31E810
		public OnChangeEvent onValueChanged { get; set; } // 0x0000000184D8DE90-0x0000000184D8DEA0 0x000000018B31E98C-0x000000018B31E9D8
		public TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get; set; } // 0x0000000184D8DF10-0x0000000184D8DF20 0x000000018B31E940-0x000000018B31E98C
		public OnValidateInput onValidateInput { get; set; } // 0x0000000184D8DB90-0x0000000184D8DBA0 0x00000001847A98F0-0x00000001847A9940
		public UnityEvent onFocused { get; set; } // 0x0000000184D8DD90-0x0000000184D8DDA0 0x000000018B31E810-0x000000018B31E85C
		public int characterLimit { get; set; } // 0x0000000184DB9D60-0x0000000184DB9D70 0x000000018461D360-0x000000018461D400
		public float pointSize { get; set; } // 0x0000000184DB9DF0-0x0000000184DB9E00 0x000000018B31EA24-0x000000018B31EABC
		public bool onFocusSelectAll { get; set; } // 0x0000000184DB9DE0-0x0000000184DB9DF0 0x0000000184DB9E90-0x0000000184DB9EA0
		public bool resetOnDeActivation { get; set; } // 0x0000000184DB9E10-0x0000000184DB9E20 0x0000000184DB9EB0-0x0000000184DB9EC0
		public bool restoreOriginalTextOnEscape { get; set; } // 0x0000000184DB9E20-0x0000000184DB9E30 0x0000000184DB9EC0-0x0000000184DB9ED0
		public bool wontReleaseSelectionOnEscape { get; set; } // 0x0000000184DB9E50-0x0000000184DB9E60 0x0000000184DB9ED0-0x0000000184DB9EE0
		public bool disableArrowKeyMoveCaret { get; set; } // 0x0000000184DB9D80-0x0000000184DB9D90 0x0000000184DB9E60-0x0000000184DB9E70
		public bool isRichTextEditingAllowed { get; set; } // 0x0000000184DB9DB0-0x0000000184DB9DC0 0x0000000184DB9E80-0x0000000184DB9E90
		public ContentType contentType { get; set; } // 0x0000000184DB9D70-0x0000000184DB9D80 0x000000018B31E49C-0x000000018B31E4F8
		public LineType lineType { get; set; } // 0x0000000184DAA150-0x0000000184DAA160 0x000000018B31E688-0x000000018B31E72C
		public int lineLimit { get; set; } // 0x0000000184DB9DD0-0x0000000184DB9DE0 0x000000018B31E628-0x000000018B31E688
		public InputType inputType { get; set; } // 0x0000000184DB9D90-0x0000000184DB9DA0 0x000000018B31E510-0x000000018B31E56C
		public TouchScreenKeyboardType keyboardType { get; set; } // 0x0000000184DB9DC0-0x0000000184DB9DD0 0x000000018B31E5CC-0x000000018B31E628
		public CharacterValidation characterValidation { get; set; } // 0x0000000184D902A0-0x0000000184D902B0 0x000000018B31E438-0x000000018B31E494
		public TMP_InputValidator inputValidator { get; set; } // 0x0000000184D8DD00-0x0000000184D8DD10 0x000000018B31E56C-0x000000018B31E5CC
		public bool readOnly { get; set; } // 0x0000000184DB9E00-0x0000000184DB9E10 0x0000000184DB9EA0-0x0000000184DB9EB0
		public bool richText { get; set; } // 0x0000000184D8FB10-0x0000000184D8FB20 0x000000018B31EABC-0x000000018B31EACC
		public bool multiLine { get; } // 0x0000000183798D60-0x0000000183798D80 
		public char asteriskChar { get; set; } // 0x0000000184DB9D30-0x0000000184DB9D40 0x000000018B31E2A0-0x000000018B31E2FC
		public bool wasCanceled { get; } // 0x0000000184DB9E40-0x0000000184DB9E50 
		protected int caretPositionInternal { get; set; } // 0x0000000183796960-0x00000001837969A0 0x000000018539550C-0x0000000185395524
		protected int stringPositionInternal { get; set; } // 0x00000001837969E0-0x0000000183796A20 0x0000000185395524-0x000000018539553C
		protected int caretSelectPositionInternal { get; set; } // 0x0000000184CD9910-0x0000000184CD9930 0x00000001853954F4-0x000000018539550C
		protected int stringSelectPositionInternal { get; set; } // 0x00000001837969A0-0x00000001837969E0 0x00000001853954DC-0x00000001853954F4
		private new bool hasSelection { get; } // 0x00000001837974A0-0x00000001837974D0 
		public int caretPosition { get; set; } // 0x00000001853954D4-0x00000001853954DC 0x000000018B31E3A4-0x000000018B31E3DC
		public int selectionAnchorPosition { get; set; } // 0x00000001853954CC-0x00000001853954D4 0x000000018B31EB28-0x000000018B31EB64
		public int selectionFocusPosition { get; set; } // 0x00000001853954D4-0x00000001853954DC 0x000000018B31EBA4-0x000000018B31EBE0
		public int stringPosition { get; set; } // 0x000000018B31E214-0x000000018B31E21C 0x000000018B31EDD8-0x000000018B31EE10
		public int selectionStringAnchorPosition { get; set; } // 0x000000018B31E20C-0x000000018B31E214 0x000000018B31EBE0-0x000000018B31EC1C
		public int selectionStringFocusPosition { get; set; } // 0x000000018B31E214-0x000000018B31E21C 0x000000018B31EC1C-0x000000018B31EC58
		private static string clipboard { get; set; } // 0x000000018B31DF8C-0x000000018B31DF94 0x000000018B31E494-0x000000018B31E49C
		public virtual float minWidth { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		public virtual float preferredWidth { get; } // 0x000000018B31E0D0-0x000000018B31E20C 
		public virtual float flexibleWidth { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public virtual float minHeight { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		public virtual float preferredHeight { get; } // 0x000000018B31DF94-0x000000018B31E0D0 
		public virtual float flexibleHeight { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public virtual int layoutPriority { get; } // 0x0000000184D85B80-0x0000000184D85B90 
		Transform ICanvasElement.transform { get; } // 0x00000001853953F4-0x00000001853953FC 
	
		// Nested types
		public enum ContentType // TypeDefIndex: 55656
		{
			Standard = 0,
			Autocorrected = 1,
			IntegerNumber = 2,
			DecimalNumber = 3,
			Alphanumeric = 4,
			Name = 5,
			EmailAddress = 6,
			Password = 7,
			Pin = 8,
			Custom = 9
		}
	
		public enum InputType // TypeDefIndex: 55657
		{
			Standard = 0,
			AutoCorrect = 1,
			Password = 2
		}
	
		public enum CharacterValidation // TypeDefIndex: 55658
		{
			None = 0,
			Digit = 1,
			Integer = 2,
			Decimal = 3,
			Alphanumeric = 4,
			Name = 5,
			Regex = 6,
			EmailAddress = 7,
			CustomValidator = 8
		}
	
		public enum LineType // TypeDefIndex: 55659
		{
			SingleLine = 0,
			MultiLineSubmit = 1,
			MultiLineNewline = 2
		}
	
		public delegate char OnValidateInput(string text, int charIndex, char addedChar); // TypeDefIndex: 55660; 0x00000001814F3120-0x00000001814F3140
	
		[Serializable]
		public class SubmitEvent : UnityEvent<string> // TypeDefIndex: 55661
		{
			// Constructors
			public SubmitEvent(); // 0x000000018405B7E0-0x000000018405B820
		}
	
		[Serializable]
		public class OnChangeEvent : UnityEvent<string> // TypeDefIndex: 55662
		{
			// Constructors
			public OnChangeEvent(); // 0x000000018405B3D0-0x000000018405B410
		}
	
		[Serializable]
		public class SelectionEvent : UnityEvent<string> // TypeDefIndex: 55663
		{
			// Constructors
			public SelectionEvent(); // 0x000000018405B820-0x000000018405B860
		}
	
		[Serializable]
		public class TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 55664
		{
			// Constructors
			public TextSelectionEvent(); // 0x000000018405B860-0x000000018405B8A0
		}
	
		[Serializable]
		public class TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 55665
		{
			// Constructors
			public TouchScreenKeyboardEvent(); // 0x000000018405B900-0x000000018405B940
		}
	
		protected enum EditState // TypeDefIndex: 55666
		{
			Continue = 0,
			Finish = 1
		}
	
		[CompilerGenerated]
		private sealed class _CaretBlink_d__291 : IEnumerator<object> // TypeDefIndex: 55667
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TMP_InputField __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _CaretBlink_d__291(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183797D20-0x0000000183797E70
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B3215E0-0x000000018B32162C
		}
	
		[CompilerGenerated]
		private sealed class _MouseDragOutsideRect_d__309 : IEnumerator<object> // TypeDefIndex: 55668
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TMP_InputField __4__this; // 0x20
			public PointerEventData eventData; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _MouseDragOutsideRect_d__309(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B32162C-0x000000018B321888
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B321888-0x000000018B3218D4
		}
	
		// Constructors
		protected TMP_InputField(); // 0x000000018405B410-0x000000018405B7E0
		static TMP_InputField(); // 0x0000000184D16A70-0x0000000184D16B00
	
		// Methods
		private bool isKeyboardUsingEvents(); // 0x00000001837977F0-0x0000000183797820
		public void SetTextWithoutNotify(string input); // 0x000000018B31D620-0x000000018B31D62C
		private void SetText(string value, bool sendCallback = true /* Metadata: 0x023470EF */); // 0x0000000184B387E0-0x0000000184B38910
		protected void ClampStringPos(ref int pos); // 0x00000001849B1550-0x00000001849B1590
		protected void ClampCaretPos(ref int pos); // 0x000000018456AF70-0x000000018456AFC0
		protected override void OnEnable(); // 0x0000000182EDD330-0x0000000182EDDB70
		protected override void OnDisable(); // 0x0000000182EDCD20-0x0000000182EDD170
		private void ON_TEXT_CHANGED(UnityEngine.Object obj); // 0x0000000183BA6410-0x0000000183BA6510
		[IteratorStateMachine(typeof(_CaretBlink_d__291))]
		private IEnumerator CaretBlink(); // 0x0000000184D35060-0x0000000184D350C0
		private void SetCaretVisible(); // 0x00000001837986B0-0x00000001837986F0
		private void SetCaretActive(); // 0x00000001837986F0-0x0000000183798760
		protected void OnFocus(); // 0x0000000183BA8AB0-0x0000000183BA8AF0
		protected void SelectAll(); // 0x0000000183BA7DF0-0x0000000183BA7E40
		public void MoveTextEnd(bool shift); // 0x000000018B31C210-0x000000018B31C2E0
		public void MoveTextStart(bool shift); // 0x000000018B31C2E0-0x000000018B31C384
		public void MoveToEndOfLine(bool shift, bool ctrl); // 0x000000018B31C384-0x000000018B31C4DC
		public void MoveToStartOfLine(bool shift, bool ctrl); // 0x000000018B31C4DC-0x000000018B31C660
		private bool InPlaceEditing(); // 0x0000000183797860-0x00000001837978C0
		private void UpdateStringPositionFromKeyboard(); // 0x000000018B31D770-0x000000018B31D868
		protected virtual void LateUpdate(); // 0x00000001837976E0-0x00000001837977F0
		private bool MayDrag(PointerEventData eventData); // 0x0000000183E9A110-0x0000000183E9A200
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x000000018B31C790-0x000000018B31C7B4
		public virtual void OnDrag(PointerEventData eventData); // 0x000000018B31C7B4-0x000000018B31CB0C
		[IteratorStateMachine(typeof(_MouseDragOutsideRect_d__309))]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData); // 0x000000018B31B4F4-0x000000018B31B568
		public virtual void OnEndDrag(PointerEventData eventData); // 0x000000018B31CB0C-0x000000018B31CB30
		public override void OnPointerDown(PointerEventData eventData); // 0x0000000183E99F40-0x0000000183E9A110
		protected EditState KeyPressed(UnityEngine.Event evt); // 0x0000000183798A90-0x0000000183798C20
		protected virtual bool IsValidChar(char c); // 0x0000000183798D40-0x0000000183798D60
		public void ProcessEvent(UnityEngine.Event e); // 0x000000018B31D380-0x000000018B31D388
		public virtual void OnUpdateSelected(BaseEventData eventData); // 0x0000000183798820-0x0000000183798960
		public virtual void OnScroll(PointerEventData eventData); // 0x000000018B31CB30-0x000000018B31CCB0
		private float GetScrollPositionRelativeToViewport(); // 0x000000018B31AE40-0x000000018B31AF48
		private string GetSelectedString(); // 0x000000018B31AF48-0x000000018B31AFD4
		private int FindNextWordBegin(); // 0x000000018B31AB64-0x000000018B31AC20
		private void MoveRight(bool shift, bool ctrl); // 0x000000018B31BF04-0x000000018B31C210
		private int FindPrevWordBegin(); // 0x000000018B31AC20-0x000000018B31ACD4
		private void MoveLeft(bool shift, bool ctrl); // 0x000000018B31B6C0-0x000000018B31B964
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar); // 0x000000018B31B2A0-0x000000018B31B4F4
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar); // 0x000000018B31B028-0x000000018B31B2A0
		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar); // 0x000000018B31D078-0x000000018B31D380
		private int PageDownCharacterPosition(int originalPos, bool goToLastChar); // 0x000000018B31CD38-0x000000018B31D078
		private void MoveDown(bool shift); // 0x000000018B31B6B4-0x000000018B31B6C0
		private void MoveDown(bool shift, bool goToLastChar); // 0x000000018B31B568-0x000000018B31B6B4
		private void MoveUp(bool shift); // 0x000000018B31C660-0x000000018B31C66C
		private void MoveUp(bool shift, bool goToFirstChar); // 0x000000018B31C66C-0x000000018B31C790
		private void MovePageUp(bool shift); // 0x000000018B31BEF8-0x000000018B31BF04
		private void MovePageUp(bool shift, bool goToFirstChar); // 0x000000018B31BC40-0x000000018B31BEF8
		private void MovePageDown(bool shift); // 0x000000018B31BC34-0x000000018B31BC40
		private void MovePageDown(bool shift, bool goToLastChar); // 0x000000018B31B964-0x000000018B31BC34
		private void Delete(); // 0x0000000183BA5E90-0x0000000183BA5F50
		private void DeleteKey(); // 0x000000018B31A80C-0x000000018B31AA30
		private void Backspace(); // 0x0000000183BA6110-0x0000000183BA6320
		protected virtual void Append(string input); // 0x000000018B31A784-0x000000018B31A80C
		protected virtual void Append(char input); // 0x0000000183BA5F50-0x0000000183BA6070
		private void Insert(char c); // 0x0000000183BA5BB0-0x0000000183BA5D20
		private void UpdateTouchKeyboardFromEditChanges(); // 0x0000000183BA5E10-0x0000000183BA5E30
		private void SendOnValueChangedAndUpdateLabel(); // 0x0000000183BA63F0-0x0000000183BA6410
		private void SendOnValueChanged(); // 0x0000000183BA5E30-0x0000000183BA5E90
		protected void SendOnEndEdit(); // 0x0000000183BA8B90-0x0000000183BA8BF0
		protected void SendOnSubmit(); // 0x000000018B31D388-0x000000018B31D3D8
		protected virtual void SendOnFocus(); // 0x0000000184B47D60-0x0000000184B47DC0
		protected virtual void SendOnFocusLost(); // 0x0000000184CB19D0-0x0000000184CB1A30
		protected void SendOnTextSelection(); // 0x0000000184CECD70-0x0000000184CECE10
		protected void SendOnEndTextSelection(); // 0x0000000183797C90-0x0000000183797D20
		protected void SendTouchScreenKeyboardStatusChanged(); // 0x000000018B31D3D8-0x000000018B31D448
		protected void UpdateLabel(); // 0x0000000183798250-0x00000001837986A0
		private void UpdateScrollbar(); // 0x000000018B31D694-0x000000018B31D770
		private void OnScrollbarValueChange(float value); // 0x000000018B31CCB0-0x000000018B31CCF0
		private void UpdateMaskRegions(); // 0x00000001841E1670-0x00000001841E1680
		private void AdjustTextPositionRelativeToViewport(float relativePosition); // 0x000000018B31A55C-0x000000018B31A784
		private int GetCaretPositionFromStringIndex(int stringIndex); // 0x0000000183BA6510-0x0000000183BA65A0
		private int GetMinCaretPositionFromStringIndex(int stringIndex); // 0x000000018B31AD6C-0x000000018B31AE40
		private int GetMaxCaretPositionFromStringIndex(int stringIndex); // 0x000000018B31ACDC-0x000000018B31AD6C
		private int GetStringIndexFromCaretPosition(int caretPosition); // 0x000000018B31AFD4-0x000000018B31B028
		public void ForceLabelUpdate(); // 0x000000018B31ACD4-0x000000018B31ACDC
		private void MarkGeometryAsDirty(); // 0x0000000183797E70-0x0000000183797EA0
		public virtual void Rebuild(CanvasUpdate update); // 0x0000000183797540-0x0000000183797550
		public virtual void LayoutComplete(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void GraphicUpdateComplete(); // 0x00000001841E1670-0x00000001841E1680
		private void UpdateGeometry(); // 0x0000000183797550-0x0000000183797620
		private void AssignPositioningIfNeeded(); // 0x00000001836CD400-0x00000001836CD8A0
		private void OnFillVBO(Mesh vbo); // 0x0000000183797900-0x0000000183797C90
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset); // 0x0000000183796A20-0x00000001837972C0
		private void CreateCursorVerts(); // 0x0000000184753660-0x0000000184753800
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset); // 0x0000000183BA6900-0x0000000183BA6F90
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible); // 0x0000000184419E00-0x000000018441A2B0
		protected char Validate(string text, int pos, char ch); // 0x000000018B31D868-0x000000018B31DF8C
		public virtual void ActivateInputField(); // 0x0000000183BA85A0-0x0000000183BA86F0
		protected virtual bool TryActivateInputFieldCustom(); // 0x00000001812081B0-0x0000000181208610
		protected void CompleteActivation(); // 0x0000000183BA8AF0-0x0000000183BA8B40
		private void ActivateInputFieldInternal(); // 0x0000000183BA88C0-0x0000000183BA8AB0
		public override void OnSelect(BaseEventData eventData); // 0x0000000184CA2AE0-0x0000000184CA2B20
		public virtual void OnPointerClick(PointerEventData eventData); // 0x0000000184D799D0-0x0000000184D79A10
		public void OnControlClick(); // 0x00000001841E1670-0x00000001841E1680
		public void ReleaseSelection(); // 0x0000000183BA8B40-0x0000000183BA8B90
		public virtual void DeactivateInputField(bool clearSelection = false /* Metadata: 0x023470F0 */); // 0x0000000183BA81C0-0x0000000183BA85A0
		public override void OnDeselect(BaseEventData eventData); // 0x0000000184B6C940-0x0000000184B6C980
		public virtual void OnSubmit(BaseEventData eventData); // 0x000000018B31CCF0-0x000000018B31CD38
		private void EnforceContentType(); // 0x000000018B31AA30-0x000000018B31AB64
		private void SetTextComponentWrapMode(); // 0x000000018405B940-0x000000018405B9E0
		private void SetTextComponentRichTextMode(); // 0x000000018B31D5A8-0x000000018B31D620
		private void SetToCustomIfContentTypeIsNot(params ContentType[] allowedContentTypes); // 0x000000018B31D62C-0x000000018B31D67C
		private void SetToCustom(); // 0x000000018B31D67C-0x000000018B31D694
		private void SetToCustom(CharacterValidation characterValidation); // 0x000000018B31D67C-0x000000018B31D694
		protected override void DoStateTransition(SelectionState state, bool instant); // 0x00000001849E42C0-0x00000001849E42F0
		public virtual void CalculateLayoutInputHorizontal(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void CalculateLayoutInputVertical(); // 0x00000001841E1670-0x00000001841E1680
		public void SetGlobalPointSize(float pointSize); // 0x000000018B31D4F8-0x000000018B31D5A8
		public void SetGlobalFontAsset(TMP_FontAsset fontAsset); // 0x000000018B31D448-0x000000018B31D4F8
	}

	internal static class SetPropertyUtility // TypeDefIndex: 55670
	{
		// Methods
		public static bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue); // 0x000000018B31A1E4-0x000000018B31A224
		public static bool SetEquatableStruct<T>(ref ref T currentValue, T newValue)
			where T : IEquatable<T>;
		public static bool SetStruct<T>(ref ref T currentValue, T newValue)
			where T : struct;
		public static bool SetClass<T>(ref ref T currentValue, T newValue)
			where T : class;
	}

	[Serializable]
	public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 55671
	{
		// Constructors
		protected TMP_InputValidator(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public abstract char Validate(ref string text, ref int pos, char ch);
	}

	public struct TMP_LineInfo // TypeDefIndex: 55672
	{
		// Fields
		public int controlCharacterCount; // 0x00
		public int characterCount; // 0x04
		public int visibleCharacterCount; // 0x08
		public int spaceCount; // 0x0C
		public int wordCount; // 0x10
		public int firstCharacterIndex; // 0x14
		public int firstVisibleCharacterIndex; // 0x18
		public int lastCharacterIndex; // 0x1C
		public int lastVisibleCharacterIndex; // 0x20
		public float length; // 0x24
		public float lineHeight; // 0x28
		public float ascender; // 0x2C
		public float baseline; // 0x30
		public float descender; // 0x34
		public float maxAdvance; // 0x38
		public float width; // 0x3C
		public float marginLeft; // 0x40
		public float marginRight; // 0x44
		public HorizontalAlignmentOptions alignment; // 0x48
		public Extents lineExtents; // 0x4C
	}

	internal static class TMP_ListPool<T> // TypeDefIndex: 55674
	{
		// Fields
		private static readonly TMP_ObjectPool<List<T>> s_ListPool;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55673
		{
			// Fields
			public static readonly __c<T> __9;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _.cctor_b__3_0(List<T> l);
		}
	
		// Constructors
		static TMP_ListPool();
	
		// Methods
		public static List<T> Get();
		public static void Release(List<T> toRelease);
	}

	public static class TMP_MaterialManager // TypeDefIndex: 55681
	{
		// Fields
		private static List<MaskingMaterial> m_materialList; // 0x00
		private static Dictionary<long, FallbackMaterial> m_fallbackMaterials; // 0x08
		private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
		private static List<FallbackMaterial> m_fallbackCleanupList; // 0x18
		private static bool isFallbackListDirty; // 0x20
		private static string s_overlayShaderKeyword; // 0x28
	
		// Properties
		public static string overlayShaderKeyword { get; set; } // 0x000000018B321530-0x000000018B321580 0x000000018B321580-0x000000018B3215E0
	
		// Nested types
		private class FallbackMaterial // TypeDefIndex: 55675
		{
			// Fields
			public long fallbackID; // 0x10
			public Material sourceMaterial; // 0x18
			internal int sourceMaterialCRC; // 0x20
			public Material fallbackMaterial; // 0x28
			public int count; // 0x30
	
			// Constructors
			public FallbackMaterial(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private class MaskingMaterial // TypeDefIndex: 55676
		{
			// Fields
			public Material baseMaterial; // 0x10
			public Material stencilMaterial; // 0x18
			public int count; // 0x20
			public int stencilID; // 0x24
	
			// Constructors
			public MaskingMaterial(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 55677
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetBaseMaterial_b__0(MaskingMaterial item); // 0x000000018B339194-0x000000018B3391F8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 55678
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _AddMaskingMaterial_b__0(MaskingMaterial item); // 0x000000018B3391F8-0x000000018B33925C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 55679
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _RemoveStencilMaterial_b__0(MaskingMaterial item); // 0x000000018B33925C-0x000000018B3392C0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 55680
		{
			// Fields
			public Material baseMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass17_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _ReleaseBaseMaterial_b__0(MaskingMaterial item); // 0x000000018B3392C0-0x000000018B339324
		}
	
		// Constructors
		static TMP_MaterialManager(); // 0x00000001849B2240-0x00000001849B2490
	
		// Methods
		private static void OnPreRender(); // 0x0000000183F64E20-0x0000000183F64E60
		public static Material GetStencilMaterial(Material baseMaterial, int stencilID); // 0x000000018B32061C-0x000000018B320994
		public static void ReleaseStencilMaterial(Material stencilMaterial); // 0x000000018B320FD0-0x000000018B3211C4
		public static Material GetBaseMaterial(Material stencilMaterial); // 0x000000018B31FAF4-0x000000018B31FC40
		public static Material SetStencil(Material material, int stencilID); // 0x000000018B321478-0x000000018B321530
		public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID); // 0x000000018B31F17C-0x000000018B31F3B8
		public static void RemoveStencilMaterial(Material stencilMaterial); // 0x000000018B32133C-0x000000018B321478
		public static void ReleaseBaseMaterial(Material baseMaterial); // 0x000000018B320994-0x000000018B320E38
		public static void ClearMaterials(); // 0x000000018B31F5A0-0x000000018B31F710
		public static int GetStencilID(GameObject obj); // 0x000000018B3203C8-0x000000018B32061C
		public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial); // 0x0000000183E32470-0x0000000183E325D0
		private static Transform FindRootSortOverrideCanvas(Transform start); // 0x000000018B31F9A8-0x000000018B31FAF4
		internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex); // 0x000000018B3200A8-0x000000018B3203C8
		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial); // 0x000000018B31FC40-0x000000018B3200A8
		public static void AddFallbackMaterialReference(Material targetMaterial); // 0x000000018B31F060-0x000000018B31F17C
		public static void RemoveFallbackMaterialReference(Material targetMaterial); // 0x000000018B3211C4-0x000000018B32133C
		public static void CleanupFallbackMaterials(); // 0x000000018B31F3B8-0x000000018B31F5A0
		public static void ReleaseFallbackMaterial(Material fallbackMaterial); // 0x000000018B320E38-0x000000018B320FD0
		public static void CopyMaterialPresetProperties(Material source, Material destination); // 0x000000018B31F710-0x000000018B31F9A8
	}

	public enum VertexSortingOrder // TypeDefIndex: 55682
	{
		Normal = 0,
		Reverse = 1
	}

	public struct TMP_MeshInfo : IDisposable // TypeDefIndex: 55683
	{
		// Fields
		private static readonly Color32 s_DefaultColor; // 0x00
		private static readonly Vector3 s_DefaultNormal; // 0x04
		private static readonly Vector4 s_DefaultTangent; // 0x10
		private static readonly Bounds s_DefaultBounds; // 0x20
		public Mesh mesh; // 0x00
		public int vertexCount; // 0x08
		public Vector3[] vertices; // 0x10
		public Vector3[] normals; // 0x18
		public Vector4[] tangents; // 0x20
		public Vector2[] uvs0; // 0x28
		public Vector2[] uvs2; // 0x30
		public Color32[] colors32; // 0x38
		public int[] triangles; // 0x40
		public Material material; // 0x48
	
		// Constructors
		public TMP_MeshInfo(Mesh mesh, int size); // 0x00000001832537A0-0x0000000183253E80
		public TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric); // 0x000000018B32DC78-0x000000018B32E640
		static TMP_MeshInfo(); // 0x0000000184B529D0-0x0000000184B52A70
	
		// Methods
		public void ResizeMeshInfo(int size); // 0x00000001831CF8D0-0x00000001831CFE50
		public void ResizeMeshInfo(int size, bool isVolumetric); // 0x000000018B32C724-0x000000018B32D288
		public void Clear(); // 0x000000018B32C694-0x000000018B32C724
		public void Clear(bool uploadChanges); // 0x0000000183BEB310-0x0000000183BEB450
		public void ClearUnusedVertices(); // 0x000000018B32C65C-0x000000018B32C694
		public void ClearUnusedVertices(int startIndex); // 0x000000018B32C580-0x000000018B32C5B4
		public void ClearUnusedVertices(int startIndex, bool updateMesh); // 0x000000018B32C5B4-0x000000018B32C65C
		public void SortGeometry(VertexSortingOrder order); // 0x000000018B32D288-0x000000018B32D32C
		public void SortGeometry(IList<int> sortingOrder); // 0x000000018B32D32C-0x000000018B32D428
		public void SwapVertexData(int src, int dst); // 0x000000018B32D428-0x000000018B32DC78
		public void Dispose(); // 0x00000001835190A0-0x0000000183519220
	}

	internal class TMP_ObjectPool<T> // TypeDefIndex: 55684
		where T : new()
	{
		// Fields
		private readonly Stack<T> m_Stack;
		private readonly UnityAction<T> m_ActionOnGet;
		private readonly UnityAction<T> m_ActionOnRelease;
		[CompilerGenerated]
		private int _countAll_k__BackingField;
	
		// Properties
		public int countAll { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int countActive { get; }
		public int countInactive { get; }
	
		// Constructors
		public TMP_ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease);
	
		// Methods
		public T Get();
		public void Release(T element);
	}

	public class TMP_ResourceManager // TypeDefIndex: 55685
	{
		// Fields
		private static readonly TMP_ResourceManager s_instance; // 0x00
		private static TMP_Settings s_TextSettings; // 0x08
		private static readonly List<TMP_FontAsset> s_FontAssetReferences; // 0x10
		private static readonly Dictionary<int, TMP_FontAsset> s_FontAssetReferenceLookup; // 0x18
	
		// Constructors
		static TMP_ResourceManager(); // 0x000000018B32E9A8-0x000000018B32EADC
		public TMP_ResourceManager(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		internal static TMP_Settings GetTextSettings(); // 0x000000018B32E73C-0x000000018B32E82C
		public static void AddFontAsset(TMP_FontAsset fontAsset); // 0x000000018B32E640-0x000000018B32E73C
		public static bool TryGetFontAsset(int hashcode, out TMP_FontAsset fontAsset); // 0x000000018B32E920-0x000000018B32E9A8
		internal static void RebuildFontAssetCache(int instanceID); // 0x000000018B32E82C-0x000000018B32E920
	}

	internal enum MarkupTag // TypeDefIndex: 55686
	{
		GRADIENT = -1999759898,
		FONT_WEIGHT = -1889896162,
		SLASH_GRADIENT = -1854491959,
		ACTION = -1827519330,
		SLASH_MARGIN = -1649644303,
		SLASH_MONOSPACE = -1638865562,
		CENTER = -1591113269,
		CHARACTER_SPACE = -1584382009,
		INDENT = -1514123076,
		LOWERCASE = -1506899689,
		SLASH_INDENT = -1496889389,
		SLASH_LOWERCASE = -1451284584,
		SLASH_CHARACTER_SPACE = -1394426712,
		MARGIN = -1355614050,
		MONOSPACE = -1340221943,
		PURPLE = -1250222130,
		SLASH_ACTION = -1187217679,
		NORMAL = -1183493901,
		ORANGE = -1108587920,
		SLASH_MATERIAL = -1100708252,
		ROTATE = -1000007783,
		SPRITE = -991527447,
		YELLOW = -882444668,
		LINE_INDENT = -844305121,
		LINE_HEIGHT = -799081892,
		SLASH_ALLCAPS = -797437649,
		SMALLCAPS = -766062114,
		SLASH_ROTATE = -764695562,
		SLASH_FONT_WEIGHT = -757976431,
		DEFAULT = -620974005,
		SLASH_UPPERCASE = -582368199,
		MARGIN_RIGHT = -447416589,
		NO_PARSE = -408011596,
		UPPERCASE = -305409418,
		SLASH_NO_PARSE = -294095813,
		MARGIN_LEFT = -272933656,
		SLASH_VERTICAL_OFFSET = -11107948,
		PERCENTAGE = 37,
		PLUS = 43,
		MINUS = 45,
		A = 65,
		BOLD = 66,
		ITALIC = 73,
		STRIKETHROUGH = 83,
		UNDERLINE = 85,
		PLUS_PERCENTAGE = 1454,
		MINUS_PERCENTAGE = 1512,
		SLASH_ITALIC = 1606,
		SLASH_BOLD = 1613,
		SLASH_A = 1614,
		SLASH_UNDERLINE = 1626,
		SLASH_STRIKETHROUGH = 1628,
		EM = 2216,
		BR = 2256,
		PX = 2568,
		MINUS_EM = 46789,
		MINUS_PX = 47461,
		PLUS_EM = 49091,
		PLUS_PX = 49507,
		PCT = 85031,
		POSITION = 85420,
		RED = 91635,
		SUBSCRIPT = 92132,
		SUPERSCRIPT = 92150,
		SHY = 92674,
		MINUS_PCT = 1567082,
		PLUS_PCT = 1634348,
		SLASH_SUBSCRIPT = 1770219,
		SLASH_SUPERSCRIPT = 1770233,
		SLASH_POSITION = 1777699,
		ANIM = 2283339,
		BLUE = 2457214,
		HREF = 2535353,
		FONT = 2586451,
		FRAC = 2598518,
		LIGA = 2655971,
		LINK = 2656128,
		LEFT = 2660507,
		MARK = 2699125,
		PAGE = 2808691,
		NO_BREAK = 2856657,
		NONE = 2857034,
		NBSP = 2869039,
		NAME = 2875623,
		TRUE = 2932022,
		TINT = 2960519,
		SIZE = 3061285,
		ZWSP = 3288238,
		SLASH_NO_BREAK = 57477502,
		SLASH_MARK = 57644506,
		SLASH_LINK = 57686191,
		SLASH_LIGA = 57686604,
		SLASH_FONT = 57747708,
		SLASH_FRAC = 57774681,
		SLASH_SIZE = 58429962,
		SLASH_PAGE = 58683868,
		ALIGN = 75138797,
		ALPHA = 75165780,
		ANGLE = 75347905,
		BLACK = 81074727,
		COLOR = 81999901,
		CLASS = 82115566,
		INDEX = 84268030,
		FALSE = 85422813,
		FLUSH = 85552164,
		GREEN = 87065851,
		SLASH_LINE_INDENT = 93886352,
		RIGHT = 99937376,
		SPACE = 100083556,
		STYLE = 100252951,
		SCALE = 100553336,
		WHITE = 105680263,
		WIDTH = 105793766,
		SLASH_SMALLCAPS = 199921873,
		SLASH_LINE_HEIGHT = 200452819,
		ALLCAPS = 218273952,
		JUSTIFIED = 817091359,
		MATERIAL = 825491659,
		INVALID = 1585415185,
		SLASH_COLOR = 1909026194,
		SLASH_ALIGN = 1916026786,
		SLASH_WIDTH = 1923459625,
		SLASH_STYLE = 1927738392,
		SLASH_SPACE = 1927873067,
		SLASH_SCALE = 1928413879,
		VERTICAL_OFFSET = 1952379995
	}

	public enum TagValueType // TypeDefIndex: 55687
	{
		None = 0,
		NumericalValue = 1,
		StringValue = 2,
		ColorValue = 4
	}

	public enum TagUnitType // TypeDefIndex: 55688
	{
		Pixels = 0,
		FontUnits = 1,
		Percentage = 2
	}

	internal static class CodePoint // TypeDefIndex: 55689
	{
		// Fields
		public const uint SPACE = 32; // Metadata: 0x02347330
		public const uint DOUBLE_QUOTE = 34; // Metadata: 0x02347331
		public const uint NUMBER_SIGN = 35; // Metadata: 0x02347332
		public const uint PERCENTAGE = 37; // Metadata: 0x02347333
		public const uint PLUS = 43; // Metadata: 0x02347334
		public const uint MINUS = 45; // Metadata: 0x02347335
		public const uint PERIOD = 46; // Metadata: 0x02347336
		public const uint HYPHEN_MINUS = 45; // Metadata: 0x02347337
		public const uint SOFT_HYPHEN = 173; // Metadata: 0x02347338
		public const uint HYPHEN = 8208; // Metadata: 0x0234733A
		public const uint NON_BREAKING_HYPHEN = 8209; // Metadata: 0x0234733C
		public const uint ZERO_WIDTH_SPACE = 8203; // Metadata: 0x0234733E
		public const uint RIGHT_SINGLE_QUOTATION = 8217; // Metadata: 0x02347340
		public const uint APOSTROPHE = 39; // Metadata: 0x02347342
		public const uint WORD_JOINER = 8288; // Metadata: 0x02347343
		public const uint HIGH_SURROGATE_START = 55296; // Metadata: 0x02347345
		public const uint HIGH_SURROGATE_END = 56319; // Metadata: 0x02347349
		public const uint LOW_SURROGATE_START = 56320; // Metadata: 0x0234734D
		public const uint LOW_SURROGATE_END = 57343; // Metadata: 0x02347351
		public const uint UNICODE_PLANE01_START = 65536; // Metadata: 0x02347355
	}

	public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 55690
	{
		// Fields
		public bool isSelected; // 0x18
	
		// Constructors
		public TMP_ScrollbarEventHandler(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void OnPointerClick(PointerEventData eventData); // 0x000000018B32EB34-0x000000018B32EB88
		public void OnSelect(BaseEventData eventData); // 0x000000018B32EB88-0x000000018B32EBE0
		public void OnDeselect(BaseEventData eventData); // 0x000000018B32EADC-0x000000018B32EB34
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class TMP_SelectionCaret : MaskableGraphic // TypeDefIndex: 55691
	{
		// Constructors
		public TMP_SelectionCaret(); // 0x0000000184D84AE0-0x0000000184D84AF0
	
		// Methods
		public override void Cull(Rect clipRect, bool validRect); // 0x0000000183519EE0-0x0000000183519F70
		protected override void UpdateGeometry(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	[ExcludeFromPreset]
	public class TMP_Settings : ScriptableObject // TypeDefIndex: 55693
	{
		// Fields
		private static TMP_Settings s_Instance; // 0x00
		[SerializeField]
		private bool m_enableWordWrapping; // 0x18
		[SerializeField]
		private bool m_enableKerning; // 0x19
		[SerializeField]
		private bool m_enableExtraPadding; // 0x1A
		[SerializeField]
		private bool m_enableTintAllSprites; // 0x1B
		[SerializeField]
		private bool m_enableParseEscapeCharacters; // 0x1C
		[SerializeField]
		private bool m_EnableRaycastTarget; // 0x1D
		[SerializeField]
		private bool m_GetFontFeaturesAtRuntime; // 0x1E
		[SerializeField]
		private int m_missingGlyphCharacter; // 0x20
		[SerializeField]
		private bool m_warningsDisabled; // 0x24
		[SerializeField]
		private TMP_FontAsset m_defaultFontAsset; // 0x28
		[SerializeField]
		private string m_defaultFontAssetPath; // 0x30
		[SerializeField]
		private float m_defaultFontSize; // 0x38
		[SerializeField]
		private float m_defaultAutoSizeMinRatio; // 0x3C
		[SerializeField]
		private float m_defaultAutoSizeMaxRatio; // 0x40
		[SerializeField]
		private Vector2 m_defaultTextMeshProTextContainerSize; // 0x44
		[SerializeField]
		private Vector2 m_defaultTextMeshProUITextContainerSize; // 0x4C
		[SerializeField]
		private bool m_autoSizeTextContainer; // 0x54
		[SerializeField]
		private bool m_IsTextObjectScaleStatic; // 0x55
		[SerializeField]
		private List<TMP_FontAsset> m_fallbackFontAssets; // 0x58
		[SerializeField]
		private bool m_matchMaterialPreset; // 0x60
		[SerializeField]
		private TMP_SpriteAsset m_defaultSpriteAsset; // 0x68
		[SerializeField]
		private string m_defaultSpriteAssetPath; // 0x70
		[SerializeField]
		private bool m_enableEmojiSupport; // 0x78
		[SerializeField]
		private uint m_MissingCharacterSpriteUnicode; // 0x7C
		[SerializeField]
		private string m_defaultColorGradientPresetsPath; // 0x80
		[SerializeField]
		private TMP_StyleSheet m_defaultStyleSheet; // 0x88
		[SerializeField]
		private string m_StyleSheetsResourcePath; // 0x90
		[SerializeField]
		private TextAsset m_leadingCharacters; // 0x98
		[SerializeField]
		private TextAsset m_followingCharacters; // 0xA0
		[SerializeField]
		private LineBreakingTable m_linebreakingRules; // 0xA8
		[SerializeField]
		private bool m_UseModernHangulLineBreakingRules; // 0xB0
		public IFontAssetLoader dynamicFontAssetLoader; // 0xB8
	
		// Properties
		public static string version { get; } // 0x000000018B32F324-0x000000018B32F350 
		public static bool enableWordWrapping { get; } // 0x000000018B32F1B4-0x000000018B32F1D4 
		public static bool enableKerning { get; } // 0x000000018B32F134-0x000000018B32F154 
		public static bool enableExtraPadding { get; } // 0x000000018B32F114-0x000000018B32F134 
		public static bool enableTintAllSprites { get; } // 0x000000018B32F194-0x000000018B32F1B4 
		public static bool enableParseEscapeCharacters { get; } // 0x000000018B32F154-0x000000018B32F174 
		public static bool enableRaycastTarget { get; } // 0x000000018B32F174-0x000000018B32F194 
		public static bool getFontFeaturesAtRuntime { get; } // 0x000000018B32F218-0x000000018B32F238 
		public static int missingGlyphCharacter { get; set; } // 0x000000018B32F2BC-0x000000018B32F2DC 0x000000018B32F3DC-0x000000018B32F400
		public static bool warningsDisabled { get; } // 0x000000018B32F350-0x000000018B32F370 
		public static TMP_FontAsset defaultFontAsset { get; } // 0x000000018B32EFD4-0x000000018B32EFF4 
		public static string defaultFontAssetPath { get; } // 0x000000018B32EFB4-0x000000018B32EFD4 
		public static float defaultFontSize { get; } // 0x000000018B32EFF4-0x000000018B32F014 
		public static float defaultTextAutoSizingMinRatio { get; } // 0x000000018B32F074-0x000000018B32F094 
		public static float defaultTextAutoSizingMaxRatio { get; } // 0x000000018B32F054-0x000000018B32F074 
		public static Vector2 defaultTextMeshProTextContainerSize { get; } // 0x000000018B32F094-0x000000018B32F0C4 
		public static Vector2 defaultTextMeshProUITextContainerSize { get; } // 0x000000018B32F0C4-0x000000018B32F0F4 
		public static bool autoSizeTextContainer { get; } // 0x000000018B32EF70-0x000000018B32EF90 
		public static bool isTextObjectScaleStatic { get; set; } // 0x000000018B32F238-0x000000018B32F258 0x000000018B32F394-0x000000018B32F3B8
		public static List<TMP_FontAsset> fallbackFontAssets { get; } // 0x000000018B32F1D4-0x000000018B32F1F4 
		public static bool matchMaterialPreset { get; } // 0x000000018B32F27C-0x000000018B32F29C 
		public static TMP_SpriteAsset defaultSpriteAsset { get; } // 0x000000018B32F034-0x000000018B32F054 
		public static string defaultSpriteAssetPath { get; } // 0x000000018B32F014-0x000000018B32F034 
		public static bool enableEmojiSupport { get; set; } // 0x000000018B32F0F4-0x000000018B32F114 0x000000018B32F370-0x000000018B32F394
		public static uint missingCharacterSpriteUnicode { get; set; } // 0x000000018B32F29C-0x000000018B32F2BC 0x000000018B32F3B8-0x000000018B32F3DC
		public static string defaultColorGradientPresetsPath { get; } // 0x000000018B32EF90-0x000000018B32EFB4 
		public static TMP_StyleSheet defaultStyleSheet { get; } // 0x000000018333CC00-0x000000018333CC30 
		public static string styleSheetsResourcePath { get; } // 0x000000018B32F2DC-0x000000018B32F300 
		public static TextAsset leadingCharacters { get; } // 0x000000018B32F258-0x000000018B32F27C 
		public static TextAsset followingCharacters { get; } // 0x000000018B32F1F4-0x000000018B32F218 
		public static LineBreakingTable linebreakingRules { get; } // 0x000000018333CC30-0x000000018333CC80 
		public static bool useModernHangulLineBreakingRules { get; set; } // 0x000000018B32F300-0x000000018B32F324 0x000000018B32F400-0x000000018B32F428
		public static TMP_Settings instance { get; } // 0x000000018333CC80-0x000000018333CD60 
	
		// Nested types
		public class LineBreakingTable // TypeDefIndex: 55692
		{
			// Fields
			public Dictionary<int, char> leadingCharacters; // 0x10
			public Dictionary<int, char> followingCharacters; // 0x18
	
			// Constructors
			public LineBreakingTable(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public TMP_Settings(); // 0x0000000184D84AD0-0x0000000184D84AE0
	
		// Methods
		public static TMP_Settings LoadDefaultSettings(); // 0x000000018B32EE8C-0x000000018B32EF70
		public static TMP_Settings GetSettings(); // 0x000000018B32ED54-0x000000018B32EDB4
		public static TMP_FontAsset GetFontAsset(); // 0x000000018B32ECE8-0x000000018B32ED54
		public static void ClearDefaultFontAsset(); // 0x000000018B32EBE0-0x000000018B32EC7C
		public static TMP_SpriteAsset GetSpriteAsset(); // 0x000000018B32EDB4-0x000000018B32EE20
		public static TMP_StyleSheet GetStyleSheet(); // 0x000000018B32EE20-0x000000018B32EE8C
		public static void LoadLinebreakingRules(); // 0x0000000184378C70-0x0000000184378DF0
		public static IFontAssetLoader GetDynamicFallbackFontAssetLoader(); // 0x000000018B32EC7C-0x000000018B32ECE8
		private static Dictionary<int, char> GetCharacters(TextAsset file); // 0x0000000184378DF0-0x0000000184378EF0
	}

	public static class ShaderUtilities // TypeDefIndex: 55694
	{
		// Fields
		public static int ID_MainTex; // 0x00
		public static int ID_FaceTex; // 0x04
		public static int ID_FaceColor; // 0x08
		public static int ID_FaceDilate; // 0x0C
		public static int ID_Shininess; // 0x10
		public static int ID_UnderlayColor; // 0x14
		public static int ID_UnderlayOffsetX; // 0x18
		public static int ID_UnderlayOffsetY; // 0x1C
		public static int ID_UnderlayDilate; // 0x20
		public static int ID_UnderlaySoftness; // 0x24
		public static int ID_UnderlayOffset; // 0x28
		public static int ID_UnderlayIsoPerimeter; // 0x2C
		public static int ID_WeightNormal; // 0x30
		public static int ID_WeightBold; // 0x34
		public static int ID_OutlineTex; // 0x38
		public static int ID_OutlineWidth; // 0x3C
		public static int ID_OutlineSoftness; // 0x40
		public static int ID_OutlineColor; // 0x44
		public static int ID_Outline2Color; // 0x48
		public static int ID_Outline2Width; // 0x4C
		public static int ID_Padding; // 0x50
		public static int ID_GradientScale; // 0x54
		public static int ID_ScaleX; // 0x58
		public static int ID_ScaleY; // 0x5C
		public static int ID_PerspectiveFilter; // 0x60
		public static int ID_Sharpness; // 0x64
		public static int ID_TextureWidth; // 0x68
		public static int ID_TextureHeight; // 0x6C
		public static int ID_BevelAmount; // 0x70
		public static int ID_GlowColor; // 0x74
		public static int ID_GlowOffset; // 0x78
		public static int ID_GlowPower; // 0x7C
		public static int ID_GlowOuter; // 0x80
		public static int ID_GlowInner; // 0x84
		public static int ID_LightAngle; // 0x88
		public static int ID_EnvMap; // 0x8C
		public static int ID_EnvMatrix; // 0x90
		public static int ID_EnvMatrixRotation; // 0x94
		public static int ID_MaskCoord; // 0x98
		public static int ID_ClipRect; // 0x9C
		public static int ID_MaskSoftnessX; // 0xA0
		public static int ID_MaskSoftnessY; // 0xA4
		public static int ID_VertexOffsetX; // 0xA8
		public static int ID_VertexOffsetY; // 0xAC
		public static int ID_UseClipRect; // 0xB0
		public static int ID_StencilID; // 0xB4
		public static int ID_StencilOp; // 0xB8
		public static int ID_StencilComp; // 0xBC
		public static int ID_StencilReadMask; // 0xC0
		public static int ID_StencilWriteMask; // 0xC4
		public static int ID_ShaderFlags; // 0xC8
		public static int ID_ScaleRatio_A; // 0xCC
		public static int ID_ScaleRatio_B; // 0xD0
		public static int ID_ScaleRatio_C; // 0xD4
		public static int ID_UseClipSceneDepth; // 0xD8
		public static int ID_UsedForWorldUI; // 0xDC
		public static string Keyword_ClipSceneDepth; // 0xE0
		public static string Keyword_UsedForWorldUI; // 0xE8
		public static string Keyword_Bevel; // 0xF0
		public static string Keyword_Glow; // 0xF8
		public static string Keyword_Underlay; // 0x100
		public static string Keyword_Ratios; // 0x108
		public static string Keyword_MASK_SOFT; // 0x110
		public static string Keyword_MASK_HARD; // 0x118
		public static string Keyword_MASK_TEX; // 0x120
		public static string Keyword_Outline; // 0x128
		public static string ShaderTag_ZTestMode; // 0x130
		public static string ShaderTag_CullMode; // 0x138
		private static float m_clamp; // 0x140
		public static bool isInitialized; // 0x144
		private static Shader k_ShaderRef_MobileSDF; // 0x148
		private static Shader k_ShaderRef_MobileBitmap; // 0x150
	
		// Properties
		internal static Shader ShaderRef_MobileSDF { get; } // 0x000000018B32C494-0x000000018B32C580 
		internal static Shader ShaderRef_MobileBitmap { get; } // 0x000000018B32C3A8-0x000000018B32C494 
	
		// Constructors
		static ShaderUtilities(); // 0x00000001848E34D0-0x00000001848E3850
	
		// Methods
		public static void GetShaderPropertyIDs(); // 0x000000018333A000-0x000000018333A910
		public static void UpdateShaderRatios(Material mat); // 0x000000018339F6A0-0x000000018339FDF0
		public static Vector4 GetFontExtent(Material material); // 0x000000018B32B8FC-0x000000018B32B91C
		public static bool IsMaskingEnabled(Material material); // 0x000000018333A910-0x000000018333AB20
		public static float GetPadding(Material material, bool enableExtraPadding, bool isBold); // 0x000000018339E950-0x000000018339F260
		public static float GetPadding(Material[] materials, bool enableExtraPadding, bool isBold); // 0x000000018B32B91C-0x000000018B32C3A8
	}

	[Serializable]
	public class TMP_Sprite : TMP_TextElement_Legacy // TypeDefIndex: 55695
	{
		// Fields
		public string name; // 0x38
		public int hashCode; // 0x40
		public int unicode; // 0x44
		public Vector2 pivot; // 0x48
		public Sprite sprite; // 0x50
	
		// Constructors
		public TMP_Sprite(); // 0x00000001841E1670-0x00000001841E1680
	}

	[DisallowMultipleComponent]
	public class TMP_SpriteAnimator : MonoBehaviour // TypeDefIndex: 55697
	{
		// Fields
		private Dictionary<int, bool> m_animations; // 0x18
		private TMP_Text m_TextComponent; // 0x20
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DoSpriteAnimationInternal_d__7 : IEnumerator<object> // TypeDefIndex: 55696
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TMP_SpriteAnimator __4__this; // 0x20
			public int start; // 0x28
			public int end; // 0x2C
			public TMP_SpriteAsset spriteAsset; // 0x30
			public int currentCharacter; // 0x38
			public int framerate; // 0x3C
			private int _currentFrame_5__2; // 0x40
			private TMP_CharacterInfo _charInfo_5__3; // 0x48
			private int _materialIndex_5__4; // 0x1C0
			private int _vertexIndex_5__5; // 0x1C4
			private TMP_MeshInfo _meshInfo_5__6; // 0x1C8
			private float _baseSpriteScale_5__7; // 0x218
			private float _elapsedTime_5__8; // 0x21C
			private float _targetTime_5__9; // 0x220
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _DoSpriteAnimationInternal_d__7(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B33883C-0x000000018B339148
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B339148-0x000000018B339194
		}
	
		// Constructors
		public TMP_SpriteAnimator(); // 0x000000018B32F63C-0x000000018B32F6C0
	
		// Methods
		private void Awake(); // 0x000000018B32F428-0x000000018B32F470
		private void OnEnable(); // 0x00000001841E1670-0x00000001841E1680
		private void OnDisable(); // 0x00000001841E1670-0x00000001841E1680
		public void StopAllAnimations(); // 0x000000018B32F5EC-0x000000018B32F63C
		public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate); // 0x000000018B32F514-0x000000018B32F5EC
		[IteratorStateMachine(typeof(_DoSpriteAnimationInternal_d__7))]
		private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate); // 0x000000018B32F470-0x000000018B32F514
	}

	[ExcludeFromPreset]
	public class TMP_SpriteAsset : TMP_Asset // TypeDefIndex: 55699
	{
		// Fields
		internal Dictionary<int, int> m_NameLookup; // 0x30
		internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x38
		[SerializeField]
		private string m_Version; // 0x40
		[SerializeField]
		internal FaceInfo m_FaceInfo; // 0x48
		public Texture spriteSheet; // 0xA8
		[SerializeField]
		private List<TMP_SpriteCharacter> m_SpriteCharacterTable; // 0xB0
		internal Dictionary<uint, TMP_SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
		[SerializeField]
		private List<TMP_SpriteGlyph> m_SpriteGlyphTable; // 0xC0
		internal Dictionary<uint, TMP_SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
		public List<TMP_Sprite> spriteInfoList; // 0xD0
		[SerializeField]
		public List<TMP_SpriteAsset> fallbackSpriteAssets; // 0xD8
		internal bool m_IsSpriteAssetLookupTablesDirty; // 0xE0
		private static HashSet<int> k_searchedSpriteAssets; // 0x00
	
		// Properties
		public string version { get; internal set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public FaceInfo faceInfo { get; internal set; } // 0x0000000184DBA360-0x0000000184DBA3A0 0x000000018B330F50-0x000000018B330F90
		public List<TMP_SpriteCharacter> spriteCharacterTable { get; internal set; } // 0x000000018B330F20-0x000000018B330F50 0x0000000184D84CE0-0x0000000184D84D00
		public Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable { get; internal set; } // 0x000000018B330EF0-0x000000018B330F20 0x0000000186AC5AF4-0x0000000186AC5B08
		public List<TMP_SpriteGlyph> spriteGlyphTable { get; internal set; } // 0x0000000184D892F0-0x0000000184D89300 0x0000000186AC5ACC-0x0000000186AC5AE0
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55698
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<TMP_SpriteGlyph, uint> __9__40_0; // 0x08
			public static Func<TMP_SpriteCharacter, uint> __9__41_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B339324-0x000000018B339388
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal uint _SortGlyphTable_b__40_0(TMP_SpriteGlyph item); // 0x000000018AA421AC-0x000000018AA421C4
			internal uint _SortCharacterTable_b__41_0(TMP_SpriteCharacter c); // 0x000000018B319DF0-0x000000018B319E08
		}
	
		// Constructors
		public TMP_SpriteAsset(); // 0x000000018B330E1C-0x000000018B330EF0
	
		// Methods
		private void Awake(); // 0x000000018B32F6C0-0x000000018B32F730
		private Material GetDefaultSpriteMaterial(); // 0x000000018B32F730-0x000000018B32F808
		public void UpdateLookupTables(); // 0x000000018B3305B0-0x000000018B330AEC
		public int GetSpriteIndexFromHashcode(int hashCode); // 0x000000018B32F808-0x000000018B32F884
		public int GetSpriteIndexFromUnicode(uint unicode); // 0x000000018B32F8F0-0x000000018B32F97C
		public int GetSpriteIndexFromName(string name); // 0x000000018B32F884-0x000000018B32F8F0
		public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x000000018B3300A0-0x000000018B3302B8
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x000000018B32FE98-0x000000018B32FFF0
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x000000018B32FFF0-0x000000018B3300A0
		public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex); // 0x000000018B32FB84-0x000000018B32FE98
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex); // 0x000000018B32FA2C-0x000000018B32FB84
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex); // 0x000000018B32F97C-0x000000018B32FA2C
		public void SortGlyphTable(); // 0x000000018B330444-0x000000018B3305B0
		internal void SortCharacterTable(); // 0x000000018B3302B8-0x000000018B330424
		internal void SortGlyphAndCharacterTables(); // 0x000000018B330424-0x000000018B330444
		private void UpgradeSpriteAsset(); // 0x000000018B330AEC-0x000000018B330E1C
	}

	[Serializable]
	public class TMP_SpriteCharacter : TMP_TextElement // TypeDefIndex: 55700
	{
		// Fields
		[SerializeField]
		private string m_Name; // 0x30
		[SerializeField]
		private int m_HashCode; // 0x38
	
		// Properties
		public string name { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x000000018B331054-0x000000018B3310C8
		public int hashCode { get; } // 0x0000000184D863B0-0x0000000184D863C0 
	
		// Constructors
		public TMP_SpriteCharacter(); // 0x0000000184DBA3A0-0x0000000184DBA3B0
		public TMP_SpriteCharacter(uint unicode, TMP_SpriteGlyph glyph); // 0x000000018B330FD0-0x000000018B33100C
		public TMP_SpriteCharacter(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph); // 0x000000018B33100C-0x000000018B331054
		internal TMP_SpriteCharacter(uint unicode, uint glyphIndex); // 0x000000018B330F90-0x000000018B330FD0
	}

	[Serializable]
	public class TMP_SpriteGlyph : Glyph // TypeDefIndex: 55701
	{
		// Fields
		public Sprite sprite; // 0x48
	
		// Constructors
		public TMP_SpriteGlyph(); // 0x000000018B3311A8-0x000000018B3311B0
		public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex); // 0x000000018B331140-0x000000018B3311A8
		public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex, Sprite sprite); // 0x000000018B3310C8-0x000000018B331140
	}

	[Serializable]
	public class TMP_Style // TypeDefIndex: 55702
	{
		// Fields
		internal static TMP_Style k_NormalStyle; // 0x00
		[SerializeField]
		private string m_Name; // 0x10
		[SerializeField]
		private int m_HashCode; // 0x18
		[SerializeField]
		private string m_OpeningDefinition; // 0x20
		[SerializeField]
		private string m_ClosingDefinition; // 0x28
		[SerializeField]
		private int[] m_OpeningTagArray; // 0x30
		[SerializeField]
		private int[] m_ClosingTagArray; // 0x38
		[SerializeField]
		internal uint[] m_OpeningTagUnicodeArray; // 0x40
		[SerializeField]
		internal uint[] m_ClosingTagUnicodeArray; // 0x48
	
		// Properties
		public static TMP_Style NormalStyle { get; } // 0x000000018B331254-0x000000018B331330 
		public string name { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x000000018B33133C-0x000000018B331378
		public int hashCode { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x000000018B331330-0x000000018B33133C
		public string styleOpeningDefinition { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public string styleClosingDefinition { get; } // 0x0000000184D86240-0x0000000184D86250 
		public int[] styleOpeningTagArray { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public int[] styleClosingTagArray { get; } // 0x0000000184D85A50-0x0000000184D85A60 
	
		// Constructors
		internal TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition); // 0x0000000184139E70-0x0000000184139F20
	
		// Methods
		public void RefreshStyle(); // 0x000000018413A1E0-0x000000018413A410
	}

	[Serializable]
	[ExcludeFromPreset]
	public class TMP_StyleSheet : ScriptableObject // TypeDefIndex: 55703
	{
		// Fields
		[SerializeField]
		private List<TMP_Style> m_StyleList; // 0x18
		private Dictionary<int, TMP_Style> m_StyleLookupDictionary; // 0x20
	
		// Properties
		internal List<TMP_Style> styles { get; } // 0x000000018385B100-0x000000018385B110 
	
		// Constructors
		public TMP_StyleSheet(); // 0x0000000184D1E550-0x0000000184D1E5E0
	
		// Methods
		private void Reset(); // 0x000000018B33124C-0x000000018B331254
		public TMP_Style GetStyle(int hashCode); // 0x000000018333CD60-0x000000018333CE30
		public TMP_Style GetStyle(string name); // 0x000000018B3311B0-0x000000018B33124C
		public void RefreshStyles(); // 0x000000018B33124C-0x000000018B331254
		private void LoadStyleDictionaryInternal(); // 0x0000000184139F20-0x000000018413A1E0
	}

	[ExecuteAlways]
	[RequireComponent(typeof(MeshRenderer))]
	public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 55704
	{
		// Fields
		[SerializeField]
		private TMP_FontAsset m_fontAsset; // 0x18
		[SerializeField]
		private TMP_SpriteAsset m_spriteAsset; // 0x20
		[SerializeField]
		private Material m_material; // 0x28
		[SerializeField]
		private Material m_sharedMaterial; // 0x30
		private Material m_fallbackMaterial; // 0x38
		private Material m_fallbackSourceMaterial; // 0x40
		[SerializeField]
		private bool m_isDefaultMaterial; // 0x48
		[SerializeField]
		private float m_padding; // 0x4C
		[SerializeField]
		private Renderer m_renderer; // 0x50
		private MeshFilter m_meshFilter; // 0x58
		private Mesh m_mesh; // 0x60
		[SerializeField]
		private TextMeshPro m_TextComponent; // 0x68
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0x70
	
		// Properties
		public TMP_FontAsset fontAsset { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public Material material { get; set; } // 0x000000018B333250-0x000000018B33325C 0x000000018B33360C-0x000000018B33369C
		public Material sharedMaterial { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x000000018B33369C-0x000000018B3336A4
		public Material fallbackMaterial { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x000000018B333504-0x000000018B33360C
		public Material fallbackSourceMaterial { get; set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public bool isDefaultMaterial { get; set; } // 0x0000000184D867D0-0x0000000184D867E0 0x0000000184D86810-0x0000000184D86820
		public float padding { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public Renderer renderer { get; } // 0x000000018B3333FC-0x000000018B333480 
		public MeshFilter meshFilter { get; } // 0x000000018B33325C-0x000000018B333350 
		public Mesh mesh { get; set; } // 0x000000018B333350-0x000000018B3333FC 0x00000001863CC164-0x00000001863CC174
		public TMP_Text textComponent { get; } // 0x000000018B333480-0x000000018B333504 
	
		// Constructors
		public TMP_SubMesh(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference); // 0x000000018B33263C-0x000000018B33299C
		private void OnEnable(); // 0x000000018B332EA4-0x000000018B332FA8
		private void OnDisable(); // 0x000000018B332E00-0x000000018B332EA4
		private void OnDestroy(); // 0x000000018B332CE8-0x000000018B332E00
		public void DestroySelf(); // 0x000000018B332A50-0x000000018B332AA8
		private Material GetMaterial(Material mat); // 0x000000018B332AA8-0x000000018B332BD4
		private Material CreateMaterialInstance(Material source); // 0x000000018B33299C-0x000000018B332A50
		private Material GetSharedMaterial(); // 0x000000018B332C54-0x000000018B332CE8
		private void SetSharedMaterial(Material mat); // 0x000000018B332FB0-0x000000018B332FE4
		public float GetPaddingForMaterial(); // 0x000000018B332BD4-0x000000018B332C54
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold); // 0x000000018B3331DC-0x000000018B333250
		public void SetVerticesDirty(); // 0x000000018B332FE4-0x000000018B333074
		public void SetMaterialDirty(); // 0x000000018B332FA8-0x000000018B332FB0
		protected void UpdateMaterial(); // 0x000000018B333074-0x000000018B3331DC
	}

	[ExecuteAlways]
	[RequireComponent(typeof(CanvasRenderer))]
	public class TMP_SubMeshUI : MaskableGraphic // TypeDefIndex: 55705
	{
		// Fields
		[SerializeField]
		private TMP_FontAsset m_fontAsset; // 0xE8
		[SerializeField]
		private TMP_SpriteAsset m_spriteAsset; // 0xF0
		[SerializeField]
		private Material m_material; // 0xF8
		[SerializeField]
		private Material m_sharedMaterial; // 0x100
		private Material m_fallbackMaterial; // 0x108
		private Material m_fallbackSourceMaterial; // 0x110
		[SerializeField]
		private bool m_isDefaultMaterial; // 0x118
		[SerializeField]
		private float m_padding; // 0x11C
		private Mesh m_mesh; // 0x120
		[SerializeField]
		private TextMeshProUGUI m_TextComponent; // 0x128
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0x130
		private bool m_materialDirty; // 0x131
		[SerializeField]
		private int m_materialReferenceIndex; // 0x134
		private Transform m_RootCanvasTransform; // 0x138
	
		// Properties
		public TMP_FontAsset fontAsset { get; set; } // 0x0000000184D88590-0x0000000184D885A0 0x0000000186AC5B1C-0x0000000186AC5B30
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x0000000184D8D1A0-0x0000000184D8D1B0 0x0000000186AC5AE0-0x0000000186AC5AF4
		public override Texture mainTexture { get; } // 0x000000018B3321F4-0x000000018B332298 
		public override Material material { get; set; } // 0x000000018B3322F8-0x000000018B332308 0x000000018B33254C-0x000000018B332634
		public Material sharedMaterial { get; set; } // 0x0000000184D87D50-0x0000000184D87D60 0x000000018B332634-0x000000018B33263C
		public Material fallbackMaterial { get; set; } // 0x0000000184D85F90-0x0000000184D85FA0 0x000000018B33242C-0x000000018B33254C
		public Material fallbackSourceMaterial { get; set; } // 0x0000000184D8D1B0-0x0000000184D8D1C0 0x0000000185397170-0x0000000185397184
		public override Material materialForRendering { get; } // 0x000000018B332298-0x000000018B3322F8 
		public bool isDefaultMaterial { get; set; } // 0x0000000184D92E30-0x0000000184D92E40 0x0000000184D92E40-0x0000000184D92E50
		public float padding { get; set; } // 0x0000000184DBA3B0-0x0000000184DBA3C0 0x0000000184DBA3C0-0x0000000184DBA3D0
		public Mesh mesh { get; set; } // 0x000000018B332308-0x000000018B33239C 0x00000001853971C0-0x00000001853971D4
		public TMP_Text textComponent { get; } // 0x000000018B33239C-0x000000018B33242C 
	
		// Constructors
		public TMP_SubMeshUI(); // 0x0000000184D84AE0-0x0000000184D84AF0
	
		// Methods
		public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference); // 0x000000018B331378-0x000000018B3316BC
		protected override void OnEnable(); // 0x000000018B331DB4-0x000000018B331E0C
		protected override void OnDisable(); // 0x000000018B331D14-0x000000018B331DB4
		protected override void OnDestroy(); // 0x000000018B331B90-0x000000018B331D14
		protected override void OnTransformParentChanged(); // 0x000000018B331E0C-0x000000018B331E50
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x000000018B33187C-0x000000018B3319B0
		public float GetPaddingForMaterial(); // 0x000000018B331A34-0x000000018B331ABC
		public float GetPaddingForMaterial(Material mat); // 0x000000018B3319B0-0x000000018B331A34
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold); // 0x000000018B332178-0x000000018B3321F4
		public override void SetAllDirty(); // 0x00000001841E1670-0x00000001841E1680
		public override void SetVerticesDirty(); // 0x000000018B331F80-0x000000018B33201C
		public override void SetLayoutDirty(); // 0x00000001841E1670-0x00000001841E1680
		public override void SetMaterialDirty(); // 0x000000018B331E80-0x000000018B331EB8
		public void SetPivotDirty(); // 0x000000018B331EB8-0x000000018B331F2C
		private Transform GetRootCanvasTransform(); // 0x000000018B331ABC-0x000000018B331B68
		public override void Cull(Rect clipRect, bool validRect); // 0x00000001841E1670-0x00000001841E1680
		protected override void UpdateGeometry(); // 0x00000001841E1670-0x00000001841E1680
		public override void Rebuild(CanvasUpdate update); // 0x000000018B331E50-0x000000018B331E80
		public void RefreshMaterial(); // 0x000000018A973704-0x000000018A973714
		protected override void UpdateMaterial(); // 0x000000018B33201C-0x000000018B332178
		public override void RecalculateClipping(); // 0x0000000183F59BE0-0x0000000183F59BF0
		private Material GetMaterial(); // 0x0000000184D87D50-0x0000000184D87D60
		private Material GetMaterial(Material mat); // 0x000000018B331770-0x000000018B33187C
		private Material CreateMaterialInstance(Material source); // 0x000000018B3316BC-0x000000018B331770
		private Material GetSharedMaterial(); // 0x000000018B331B68-0x000000018B331B90
		private void SetSharedMaterial(Material mat); // 0x000000018B331F2C-0x000000018B331F80
	}

	public interface ITextElement // TypeDefIndex: 55706
	{
		// Properties
		Material sharedMaterial { get; }
	
		// Methods
		void Rebuild(CanvasUpdate update);
		int GetInstanceID();
	}

	public enum TextAlignmentOptions // TypeDefIndex: 55707
	{
		TopLeft = 257,
		Top = 258,
		TopRight = 260,
		TopJustified = 264,
		TopFlush = 272,
		TopGeoAligned = 288,
		Left = 513,
		Center = 514,
		Right = 516,
		Justified = 520,
		Flush = 528,
		CenterGeoAligned = 544,
		BottomLeft = 1025,
		Bottom = 1026,
		BottomRight = 1028,
		BottomJustified = 1032,
		BottomFlush = 1040,
		BottomGeoAligned = 1056,
		BaselineLeft = 2049,
		Baseline = 2050,
		BaselineRight = 2052,
		BaselineJustified = 2056,
		BaselineFlush = 2064,
		BaselineGeoAligned = 2080,
		MidlineLeft = 4097,
		Midline = 4098,
		MidlineRight = 4100,
		MidlineJustified = 4104,
		MidlineFlush = 4112,
		MidlineGeoAligned = 4128,
		CaplineLeft = 8193,
		Capline = 8194,
		CaplineRight = 8196,
		CaplineJustified = 8200,
		CaplineFlush = 8208,
		CaplineGeoAligned = 8224,
		Converted = 65535
	}

	public enum HorizontalAlignmentOptions // TypeDefIndex: 55708
	{
		Left = 1,
		Center = 2,
		Right = 4,
		Justified = 8,
		Flush = 16,
		Geometry = 32
	}

	public enum VerticalAlignmentOptions // TypeDefIndex: 55709
	{
		Top = 256,
		Middle = 512,
		Bottom = 1024,
		Baseline = 2048,
		Geometry = 4096,
		Capline = 8192
	}

	public enum TextRenderFlags // TypeDefIndex: 55710
	{
		DontRender = 0,
		Render = 255
	}

	public enum TMP_TextElementType // TypeDefIndex: 55711
	{
		Character = 0,
		Sprite = 1,
		Image = 2
	}

	public enum MaskingTypes // TypeDefIndex: 55712
	{
		MaskOff = 0,
		MaskHard = 1,
		MaskSoft = 2
	}

	public enum TextOverflowModes // TypeDefIndex: 55713
	{
		Overflow = 0,
		Ellipsis = 1,
		Masking = 2,
		Truncate = 3,
		ScrollRect = 4,
		Page = 5,
		Linked = 6
	}

	public enum MaskingOffsetMode // TypeDefIndex: 55714
	{
		Percentage = 0,
		Pixel = 1
	}

	public enum TextureMappingOptions // TypeDefIndex: 55715
	{
		Character = 0,
		Line = 1,
		Paragraph = 2,
		MatchAspect = 3
	}

	[Flags]
	public enum FontStyles // TypeDefIndex: 55716
	{
		Normal = 0,
		Bold = 1,
		Italic = 2,
		Underline = 4,
		LowerCase = 8,
		UpperCase = 16,
		SmallCaps = 32,
		Strikethrough = 64,
		Superscript = 128,
		Subscript = 256,
		Highlight = 512,
		Phonetic = 1024
	}

	public enum FontWeight // TypeDefIndex: 55717
	{
		Thin = 100,
		ExtraLight = 200,
		Light = 300,
		Regular = 400,
		Medium = 500,
		SemiBold = 600,
		Bold = 700,
		Heavy = 800,
		Black = 900
	}

	public struct PhoneticCharSlot // TypeDefIndex: 55718
	{
		// Fields
		public TMP_FontAsset fontAsset; // 0x00
		public int materialIndex; // 0x08
		public Glyph glyph; // 0x10
	}

	public class PhoneticData // TypeDefIndex: 55719
	{
		// Fields
		public static PhoneticData Default; // 0x00
		public string m_phonetic; // 0x10
		public bool m_padding; // 0x18
		public bool m_justify; // 0x19
		public int m_length; // 0x1C
		public int m_startIndex; // 0x20
		public int m_startCharCount; // 0x24
		public PhoneticCharSlot?[] m_charSlots; // 0x28
	
		// Constructors
		public PhoneticData(); // 0x0000000184CD06D0-0x0000000184CD0730
		static PhoneticData(); // 0x0000000184CD0660-0x0000000184CD06D0
	}

	public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 55726
	{
		// Fields
		protected string m_textForPopulate; // 0xE8
		[SerializeField]
		[TextArea(5, 10)]
		protected string m_text; // 0xF0
		private bool m_IsTextBackingStringDirty; // 0xF8
		[SerializeField]
		protected ITextPreprocessor m_TextPreprocessor; // 0x100
		[SerializeField]
		protected bool m_isRightToLeft; // 0x108
		[FormerlySerializedAs("m_fontAsset")]
		[SerializeField]
		protected TMP_FontAsset m_serializedFontAsset; // 0x110
		protected TMP_FontAsset m_currentFontAsset; // 0x118
		protected bool m_isSDFShader; // 0x120
		[FormerlySerializedAs("m_sharedMaterial")]
		[SerializeField]
		protected Material m_serializedSharedMaterial; // 0x128
		protected Material m_currentMaterial; // 0x130
		protected static MaterialReference[] m_materialReferences; // 0x00
		protected static Dictionary<int, int> m_materialReferenceIndexLookup; // 0x08
		protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; // 0x10
		protected int m_currentMaterialIndex; // 0x138
		[SerializeField]
		protected Material[] m_fontSharedMaterials; // 0x140
		[SerializeField]
		protected Material m_fontMaterial; // 0x148
		[SerializeField]
		protected Material[] m_fontMaterials; // 0x150
		protected bool m_isMaterialDirty; // 0x158
		[SerializeField]
		protected Color32 m_fontColor32; // 0x15C
		[SerializeField]
		protected UnityEngine.Color m_fontColor; // 0x160
		protected static Color32 s_colorWhite; // 0x68
		protected Color32 m_underlineColor; // 0x170
		protected Color32 m_strikethroughColor; // 0x174
		[SerializeField]
		protected bool m_enableVertexGradient; // 0x178
		[SerializeField]
		protected ColorMode m_colorMode; // 0x17C
		[SerializeField]
		protected VertexGradient m_fontColorGradient; // 0x180
		[SerializeField]
		protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1C0
		[SerializeField]
		protected TMP_SpriteAsset m_spriteAsset; // 0x1C8
		[SerializeField]
		protected bool m_tintAllSprites; // 0x1D0
		protected bool m_tintSprite; // 0x1D1
		protected Color32 m_spriteColor; // 0x1D4
		[SerializeField]
		protected TMP_StyleSheet m_StyleSheet; // 0x1D8
		internal TMP_Style m_TextStyle; // 0x1E0
		[SerializeField]
		protected int m_TextStyleHashCode; // 0x1E8
		[SerializeField]
		protected bool m_overrideHtmlColors; // 0x1EC
		[SerializeField]
		protected Color32 m_faceColor; // 0x1F0
		protected Color32 m_outlineColor; // 0x1F4
		protected float m_outlineWidth; // 0x1F8
		[SerializeField]
		protected float m_fontSize; // 0x1FC
		protected float m_currentFontSize; // 0x200
		[SerializeField]
		protected float m_fontSizeBase; // 0x204
		protected TMP_TextProcessingStack<float> m_sizeStack; // 0x208
		protected float m_imageWidth; // 0x228
		protected float m_imageHeight; // 0x22C
		protected float m_maxLineAscenderWithImage; // 0x230
		protected const float m_basePhoneticElementScale = 0.5f; // Metadata: 0x02347401
		protected FontStyles m_phoneticFontStyle; // 0x234
		protected FontWeight m_phoneticFontWeight; // 0x238
		protected WordWrapState m_phoneticWordWarpState; // 0x240
		protected int m_phoneticStartCharIndex; // 0x5D8
		protected int m_phoneticStartIndex; // 0x5DC
		protected int m_phoneticEndIndex; // 0x5E0
		protected bool m_isPhoneticOverLength; // 0x5E4
		protected TMP_TextProcessingQueue<PhoneticData> m_phoneticDataQueue; // 0x5E8
		protected PhoneticData m_currentPhoneticData; // 0x608
		protected int m_phoneticCount; // 0x610
		protected float m_phoneticFontSize; // 0x614
		[SerializeField]
		protected bool m_showPhonetic; // 0x618
		protected int m_phoneticIndex; // 0x61C
		[NonSerialized]
		protected bool m_isInSetArraySizes; // 0x620
		[SerializeField]
		protected bool m_needParseActionId; // 0x621
		[SerializeField]
		protected FontWeight m_fontWeight; // 0x624
		protected FontWeight m_FontWeightInternal; // 0x628
		protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; // 0x630
		[SerializeField]
		protected bool m_enableAutoSizing; // 0x650
		protected float m_maxFontSize; // 0x654
		protected float m_minFontSize; // 0x658
		protected int m_AutoSizeIterationCount; // 0x65C
		protected int m_AutoSizeMaxIterationCount; // 0x660
		protected bool m_IsAutoSizePointSizeSet; // 0x664
		[SerializeField]
		protected float m_fontSizeMin; // 0x668
		[SerializeField]
		protected float m_fontSizeMax; // 0x66C
		[SerializeField]
		protected FontStyles m_fontStyle; // 0x670
		protected FontStyles m_FontStyleInternal; // 0x674
		protected TMP_FontStyleStack m_fontStyleStack; // 0x678
		protected bool m_isUsingBold; // 0x682
		[SerializeField]
		protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x684
		[SerializeField]
		protected VerticalAlignmentOptions m_VerticalAlignment; // 0x688
		[FormerlySerializedAs("m_lineJustification")]
		[SerializeField]
		protected TextAlignmentOptions m_textAlignment; // 0x68C
		protected HorizontalAlignmentOptions m_lineJustification; // 0x690
		protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x698
		protected Vector3[] m_textContainerLocalCorners; // 0x6B8
		[SerializeField]
		protected float m_characterSpacing; // 0x6C0
		protected float m_cSpacing; // 0x6C4
		protected float m_monoSpacing; // 0x6C8
		[SerializeField]
		protected float m_wordSpacing; // 0x6CC
		[SerializeField]
		protected float m_lineSpacing; // 0x6D0
		protected float m_lineSpacingDelta; // 0x6D4
		protected float m_lineHeight; // 0x6D8
		protected bool m_IsDrivenLineSpacing; // 0x6DC
		[SerializeField]
		protected float m_lineSpacingMax; // 0x6E0
		[SerializeField]
		protected float m_paragraphSpacing; // 0x6E4
		[SerializeField]
		protected float m_charWidthMaxAdj; // 0x6E8
		protected float m_charWidthAdjDelta; // 0x6EC
		[SerializeField]
		protected bool m_enableWordWrapping; // 0x6F0
		protected bool m_isCharacterWrappingEnabled; // 0x6F1
		protected bool m_isNonBreakingSpace; // 0x6F2
		protected bool m_isIgnoringAlignment; // 0x6F3
		[SerializeField]
		protected float m_wordWrappingRatios; // 0x6F4
		[SerializeField]
		protected TextOverflowModes m_overflowMode; // 0x6F8
		protected int m_firstOverflowCharacterIndex; // 0x6FC
		[SerializeField]
		protected TMP_Text m_linkedTextComponent; // 0x700
		[SerializeField]
		internal TMP_Text parentLinkedComponent; // 0x708
		protected bool m_isTextTruncated; // 0x710
		[SerializeField]
		protected bool m_enableKerning; // 0x711
		protected float m_GlyphHorizontalAdvanceAdjustment; // 0x714
		[SerializeField]
		protected bool m_enableExtraPadding; // 0x718
		[SerializeField]
		protected bool checkPaddingRequired; // 0x719
		[SerializeField]
		protected bool m_isRichText; // 0x71A
		[SerializeField]
		protected bool m_enableHyperlink; // 0x71B
		[SerializeField]
		protected Vector2 m_linkExtraPadding; // 0x71C
		[Range(0f, 1f)]
		[SerializeField]
		protected float m_richTextColorBlend; // 0x724
		[SerializeField]
		protected bool m_parseCtrlCharacters; // 0x728
		protected bool m_isOverlay; // 0x729
		[SerializeField]
		protected bool m_isOrthographic; // 0x72A
		[SerializeField]
		protected bool m_isCullingEnabled; // 0x72B
		protected bool m_isMaskingEnabled; // 0x72C
		protected bool isMaskUpdateRequired; // 0x72D
		protected bool m_ignoreCulling; // 0x72E
		[SerializeField]
		protected TextureMappingOptions m_horizontalMapping; // 0x730
		[SerializeField]
		protected TextureMappingOptions m_verticalMapping; // 0x734
		[SerializeField]
		protected float m_uvLineOffset; // 0x738
		protected TextRenderFlags m_renderMode; // 0x73C
		[SerializeField]
		protected VertexSortingOrder m_geometrySortingOrder; // 0x740
		[SerializeField]
		protected bool m_IsTextObjectScaleStatic; // 0x744
		[SerializeField]
		protected bool m_VertexBufferAutoSizeReduction; // 0x745
		protected int m_firstVisibleCharacter; // 0x748
		protected int m_maxVisibleCharacters; // 0x74C
		protected int m_maxVisibleWords; // 0x750
		protected int m_maxVisibleLines; // 0x754
		[SerializeField]
		protected bool m_useMaxVisibleDescender; // 0x758
		[SerializeField]
		protected int m_pageToDisplay; // 0x75C
		protected bool m_isNewPage; // 0x760
		[SerializeField]
		protected Vector4 m_margin; // 0x764
		protected float m_marginLeft; // 0x774
		protected float m_marginRight; // 0x778
		protected float m_marginWidth; // 0x77C
		protected float m_marginHeight; // 0x780
		protected float m_width; // 0x784
		protected TMP_TextInfo m_textInfo; // 0x788
		protected bool m_havePropertiesChanged; // 0x790
		[SerializeField]
		protected bool m_isUsingLegacyAnimationComponent; // 0x791
		protected Transform m_transform; // 0x798
		protected RectTransform m_rectTransform; // 0x7A0
		protected Vector2 m_PreviousRectTransformSize; // 0x7A8
		protected Vector2 m_PreviousPivotPosition; // 0x7B0
		[CompilerGenerated]
		private bool _autoSizeTextContainer_k__BackingField; // 0x7B8
		protected bool m_autoSizeTextContainer; // 0x7B9
		protected Mesh m_mesh; // 0x7C0
		[SerializeField]
		protected bool m_isVolumetricText; // 0x7C8
		[CompilerGenerated]
		private static Func<int, string, TMP_FontAsset> OnFontAssetRequest; // 0x70
		[CompilerGenerated]
		private static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest; // 0x78
		[CompilerGenerated]
		private Action<TMP_TextInfo> OnPreRenderText; // 0x7D0
		protected TMP_SpriteAnimator m_spriteAnimator; // 0x7D8
		protected float m_flexibleHeight; // 0x7E0
		protected float m_flexibleWidth; // 0x7E4
		protected float m_minWidth; // 0x7E8
		protected float m_minHeight; // 0x7EC
		protected float m_maxWidth; // 0x7F0
		protected float m_maxHeight; // 0x7F4
		protected LayoutElement m_LayoutElement; // 0x7F8
		protected float m_preferredWidth; // 0x800
		protected float m_renderedWidth; // 0x804
		protected bool m_isPreferredWidthDirty; // 0x808
		protected float m_preferredHeight; // 0x80C
		protected float m_renderedHeight; // 0x810
		protected bool m_isPreferredHeightDirty; // 0x814
		protected bool m_isCalculatingPreferredValues; // 0x815
		protected int m_layoutPriority; // 0x818
		protected bool m_isLayoutDirty; // 0x81C
		[NonSerialized]
		protected bool m_isAwake; // 0x81D
		internal bool m_isWaitingOnResourceLoad; // 0x81E
		[NonSerialized]
		protected bool m_isInit; // 0x81F
		internal TextInputSources m_inputSource; // 0x820
		protected float m_fontScaleMultiplier; // 0x824
		private static char[] m_htmlTag; // 0x80
		protected static RichTextTagAttribute[] m_xmlAttribute; // 0x88
		private static float[] m_attributeParameterValues; // 0x90
		protected float tag_LineIndent; // 0x828
		protected float tag_Indent; // 0x82C
		protected TMP_TextProcessingStack<float> m_indentStack; // 0x830
		protected bool tag_NoParsing; // 0x850
		protected bool m_isParsingText; // 0x851
		protected Matrix4x4 m_FXMatrix; // 0x854
		protected bool m_isFXMatrixSet; // 0x894
		protected UnicodeChar[] m_TextProcessingArray; // 0x898
		internal int m_InternalTextProcessingArraySize; // 0x8A0
		private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x8A8
		protected int m_totalCharacterCount; // 0x8B0
		protected static WordWrapState m_SavedWordWrapState; // 0x98
		protected static WordWrapState m_SavedLineState; // 0x430
		protected static WordWrapState m_SavedEllipsisState; // 0x7C8
		protected static WordWrapState m_SavedLastValidState; // 0xB60
		protected static WordWrapState m_SavedSoftLineBreakState; // 0xEF8
		protected static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x1290
		protected int m_characterCount; // 0x8B4
		protected int m_firstCharacterOfLine; // 0x8B8
		protected int m_firstVisibleCharacterOfLine; // 0x8BC
		protected int m_lastCharacterOfLine; // 0x8C0
		protected int m_lastVisibleCharacterOfLine; // 0x8C4
		protected int m_lineNumber; // 0x8C8
		protected int m_lineVisibleCharacterCount; // 0x8CC
		protected int m_pageNumber; // 0x8D0
		protected float m_PageAscender; // 0x8D4
		protected float m_maxTextAscender; // 0x8D8
		protected float m_maxCapHeight; // 0x8DC
		protected float m_ElementAscender; // 0x8E0
		protected float m_ElementDescender; // 0x8E4
		protected float m_maxLineAscender; // 0x8E8
		protected float m_maxLineDescender; // 0x8EC
		protected float m_startOfLineAscender; // 0x8F0
		protected float m_startOfLineDescender; // 0x8F4
		protected float m_lineOffset; // 0x8F8
		protected Extents m_meshExtents; // 0x8FC
		protected Color32 m_htmlColor; // 0x90C
		protected TMP_TextProcessingStack<Color32> m_colorStack; // 0x910
		protected TMP_TextProcessingStack<Color32> m_underlineColorStack; // 0x930
		protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; // 0x950
		protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x970
		protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; // 0x9A0
		protected TMP_ColorGradient m_colorGradientPreset; // 0x9C8
		protected bool m_colorGradientPresetIsTinted; // 0x9D0
		protected float m_tabSpacing; // 0x9D4
		protected float m_spacing; // 0x9D8
		protected TMP_TextProcessingStack<int>[] m_TextStyleStacks; // 0x9E0
		protected TMP_TextProcessingStack<int> m_ItalicAngleStack; // 0x9E8
		protected TMP_TextProcessingStack<int> m_actionStack; // 0xA08
		protected TMP_TextProcessingStack<float> m_baselineOffsetStack; // 0xA28
		protected int m_TextStyleStackDepth; // 0xA48
		protected int m_ItalicAngle; // 0xA4C
		protected float m_padding; // 0xA50
		protected float m_baselineOffset; // 0xA54
		protected float m_xAdvance; // 0xA58
		protected float m_lastCharAdvance; // 0xA5C
		protected bool m_lastIsUpVowels; // 0xA60
		protected bool m_lastIsAscender; // 0xA61
		protected bool m_lastIsDescender; // 0xA62
		protected float m_lastHeight; // 0xA64
		protected static bool s_forceLeftAlign; // 0x1648
		protected TMP_TextElementType m_textElementType; // 0xA68
		protected TMP_TextElement m_cached_TextElement; // 0xA70
		protected SpecialCharacter m_Ellipsis; // 0xA78
		protected SpecialCharacter m_Underline; // 0xA98
		protected TMP_SpriteAsset m_defaultSpriteAsset; // 0xAB8
		protected TMP_SpriteAsset m_currentSpriteAsset; // 0xAC0
		protected int m_spriteCount; // 0xAC8
		protected int m_spriteIndex; // 0xACC
		protected int m_spriteAnimationID; // 0xAD0
		private static ProfilerMarker k_ParseTextMarker; // 0x1650
		private static ProfilerMarker k_InsertNewLineMarker; // 0x1658
		protected bool m_ignoreActiveState; // 0xAD4
		private TextBackingContainer m_TextBackingArray; // 0xAD8
		private readonly decimal[] k_Power; // 0xAE8
		protected static Vector2 k_LargePositiveVector2; // 0x1660
		protected static Vector2 k_LargeNegativeVector2; // 0x1668
		protected static float k_LargePositiveFloat; // 0x1670
		protected static float k_LargeNegativeFloat; // 0x1674
		protected static int k_LargePositiveInt; // 0x1678
		protected static int k_LargeNegativeInt; // 0x167C
		private bool m_dynamicFontAssetUsed; // 0xAF0
	
		// Properties
		public virtual string text { get; set; } // 0x0000000183E60F20-0x0000000183E60FC0 0x0000000183E86700-0x0000000183E867B0
		public virtual string textForPopulate { get; } // 0x000000018333C4A0-0x000000018333C4E0 
		public ITextPreprocessor textPreprocessor { get; set; } // 0x0000000184D87D50-0x0000000184D87D60 0x00000001867A5EA0-0x00000001867A5EB4
		public bool isRightToLeftText { get; set; } // 0x0000000184DBA120-0x0000000184DBA130 0x000000018B32B074-0x000000018B32B0B8
		public TMP_FontAsset font { get; set; } // 0x0000000185393890-0x00000001853938A0 0x000000018B32AEBC-0x000000018B32AF60
		public virtual TMP_FontAsset m_fontAsset { get; set; } // 0x0000000184D8D1B0-0x0000000184D8D1C0 0x0000000185397170-0x0000000185397184
		public virtual Material fontSharedMaterial { get; set; } // 0x0000000184D8D910-0x0000000184D8D920 0x000000018B32AD0C-0x000000018B32ADA4
		protected virtual Material m_sharedMaterial { get; set; } // 0x0000000184D8D910-0x0000000184D8D920 0x00000001853971AC-0x00000001853971C0
		public virtual Material[] fontSharedMaterials { get; set; } // 0x000000018B32A0DC-0x000000018B32A10C 0x000000018B32ACD0-0x000000018B32AD0C
		public Material fontMaterial { get; set; } // 0x000000018B32A088-0x000000018B32A09C 0x000000018B32ABF4-0x000000018B32ACD0
		public virtual Material[] fontMaterials { get; set; } // 0x000000018B32A09C-0x000000018B32A0DC 0x000000018B32ACD0-0x000000018B32AD0C
		public override UnityEngine.Color color { get; set; } // 0x00000001843E92E0-0x00000001843E93B0 0x0000000184369F20-0x0000000184369F60
		public float alpha { get; set; } // 0x0000000184DA7C50-0x0000000184DA7C60 0x000000018B32A8B0-0x000000018B32A8DC
		public bool enableVertexGradient { get; set; } // 0x0000000184D8FF90-0x0000000184D8FFA0 0x000000018B32AAB8-0x000000018B32AAE0
		public VertexGradient colorGradient { get; set; } // 0x0000000184DB9FA0-0x0000000184DB9FD0 0x000000018B32A9A8-0x000000018B32A9EC
		public TMP_ColorGradient colorGradientPreset { get; set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x000000018B32A974-0x000000018B32A9A8
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x000000018B32B6BC-0x000000018B32B700
		public bool tintAllSprites { get; set; } // 0x0000000184D900F0-0x0000000184D90100 0x000000018B32B7A4-0x000000018B32B7CC
		public TMP_StyleSheet styleSheet { get; set; } // 0x0000000184D87870-0x0000000184D87880 0x000000018B32B700-0x000000018B32B744
		public TMP_Style textStyle { get; set; } // 0x000000018333CE30-0x000000018333CE80 0x000000018B32B744-0x000000018B32B7A4
		public bool overrideColorTags { get; set; } // 0x0000000184D90680-0x0000000184D90690 0x000000018B32B560-0x000000018B32B588
		public Color32 faceColor { get; set; } // 0x000000018B329FC0-0x000000018B32A088 0x000000018B32AB68-0x000000018B32ABCC
		public Color32 outlineColor { get; set; } // 0x000000018B32A270-0x000000018B32A338 0x000000018B32B46C-0x000000018B32B4C4
		public float outlineWidth { get; set; } // 0x000000018B32A338-0x000000018B32A3E8 0x000000018B32B4C4-0x000000018B32B51C
		public float fontSize { get; set; } // 0x0000000184DBA090-0x0000000184DBA0A0 0x0000000184D83710-0x0000000184D83740
		protected float PhoneticElementScale { get; } // 0x000000018B329EFC-0x000000018B329F1C 
		protected string m_currentPhonetic { get; } // 0x000000018B32A20C-0x000000018B32A270 
		protected bool m_currentEnablePhoneticAutoPadding { get; } // 0x000000018496E820-0x000000018496E870 
		protected bool m_currentEnablePhoneticAutoJustify { get; } // 0x000000018B32A1A8-0x000000018B32A20C 
		public FontWeight fontWeight { get; set; } // 0x0000000184DBA0A0-0x0000000184DBA0B0 0x000000018B32AE78-0x000000018B32AEBC
		public float pixelsPerUnit { get; } // 0x000000018B32A3E8-0x000000018B32A50C 
		public bool enableAutoSizing { get; set; } // 0x0000000184DB9FD0-0x0000000184DB9FE0 0x000000018B32A9EC-0x000000018B32AA28
		public float fontSizeMin { get; set; } // 0x0000000184DBA080-0x0000000184DBA090 0x000000018B32ADEC-0x000000018B32AE34
		public float fontSizeMax { get; set; } // 0x0000000184DBA070-0x0000000184DBA080 0x000000018B32ADA4-0x000000018B32ADEC
		public FontStyles fontStyle { get; set; } // 0x0000000184DA15F0-0x0000000184DA1600 0x000000018B32AE34-0x000000018B32AE78
		public bool isUsingBold { get; } // 0x0000000184DBA150-0x0000000184DBA160 
		public HorizontalAlignmentOptions horizontalAlignment { get; set; } // 0x0000000184DBA0D0-0x0000000184DBA0E0 0x000000018B32AFA0-0x000000018B32AFC8
		public VerticalAlignmentOptions verticalAlignment { get; set; } // 0x0000000184DA1650-0x0000000184DA1660 0x000000018B32B814-0x000000018B32B83C
		public TextAlignmentOptions alignment { get; set; } // 0x0000000184DB9F60-0x0000000184DB9F70 0x000000018B32A874-0x000000018B32A8B0
		public float characterSpacing { get; set; } // 0x0000000184DB9F80-0x0000000184DB9F90 0x000000018B32A8DC-0x000000018B32A928
		public float wordSpacing { get; set; } // 0x0000000184DBA320-0x0000000184DBA330 0x000000018B32B864-0x000000018B32B8B0
		public float lineSpacing { get; set; } // 0x0000000184DBA1A0-0x0000000184DBA1B0 0x000000018B32B1B8-0x000000018B32B204
		public float lineSpacingAdjustment { get; set; } // 0x0000000184DBA190-0x0000000184DBA1A0 0x000000018B32B16C-0x000000018B32B1B8
		public float paragraphSpacing { get; set; } // 0x0000000184DBA290-0x0000000184DBA2A0 0x000000018B32B5B0-0x000000018B32B5FC
		public float characterWidthAdjustment { get; set; } // 0x0000000184DB9F90-0x0000000184DB9FA0 0x000000018B32A928-0x000000018B32A974
		public bool enableWordWrapping { get; set; } // 0x0000000184DBA010-0x0000000184DBA020 0x000000018B32AAE0-0x000000018B32AB24
		public float wordWrappingRatios { get; set; } // 0x0000000184DBA330-0x0000000184DBA340 0x000000018B32B8B0-0x000000018B32B8FC
		public TextOverflowModes overflowMode { get; set; } // 0x0000000184DBA270-0x0000000184DBA280 0x000000018B32B51C-0x000000018B32B560
		public bool isTextOverflowing { get; } // 0x000000018B32A10C-0x000000018B32A118 
		public int firstOverflowCharacterIndex { get; } // 0x0000000184DBA030-0x0000000184DBA040 
		public TMP_Text linkedTextComponent { get; set; } // 0x0000000184DBA1D0-0x0000000184DBA1E0 0x000000018B32B254-0x000000018B32B348
		public bool isTextTruncated { get; } // 0x0000000184DBA140-0x0000000184DBA150 
		public bool enableKerning { get; set; } // 0x0000000184DBA000-0x0000000184DBA010 0x000000018B32AA74-0x000000018B32AAB8
		public bool extraPadding { get; set; } // 0x0000000184DBA020-0x0000000184DBA030 0x000000018B32AB24-0x000000018B32AB68
		public bool richText { get; set; } // 0x0000000184DBA2D0-0x0000000184DBA2E0 0x000000018B32B678-0x000000018B32B6BC
		public bool enableHyperlink { get; set; } // 0x0000000184DB9FF0-0x0000000184DBA000 0x000000018B32AA5C-0x000000018B32AA74
		public Vector2 linkExtraPadding { get; set; } // 0x0000000184DBA1B0-0x0000000184DBA1D0 0x000000018B32B204-0x000000018B32B254
		public float richTextColorBlend { get; set; } // 0x0000000184DBA2C0-0x0000000184DBA2D0 0x000000018B32B658-0x000000018B32B678
		public bool parseCtrlCharacters { get; set; } // 0x0000000184DBA2A0-0x0000000184DBA2B0 0x000000018B32B5FC-0x000000018B32B640
		public bool isOverlay { get; set; } // 0x0000000184DBA110-0x0000000184DBA120 0x000000018B32B030-0x000000018B32B074
		public bool isOrthographic { get; set; } // 0x0000000184DBA100-0x0000000184DBA110 0x000000018B32B008-0x000000018B32B030
		public bool enableCulling { get; set; } // 0x0000000184DB9FE0-0x0000000184DB9FF0 0x000000018B32AA28-0x000000018B32AA5C
		public bool ignoreVisibility { get; set; } // 0x0000000184DBA0F0-0x0000000184DBA100 0x000000018B32AFF0-0x000000018B32B008
		public TextureMappingOptions horizontalMapping { get; set; } // 0x0000000184DBA0E0-0x0000000184DBA0F0 0x000000018B32AFC8-0x000000018B32AFF0
		public TextureMappingOptions verticalMapping { get; set; } // 0x0000000184DBA310-0x0000000184DBA320 0x000000018B32B83C-0x000000018B32B864
		public float mappingUvLineOffset { get; set; } // 0x0000000184DBA1E0-0x0000000184DBA1F0 0x000000018B32B348-0x000000018B32B374
		public TextRenderFlags renderMode { get; set; } // 0x0000000184DBA2B0-0x0000000184DBA2C0 0x000000018B32B640-0x000000018B32B658
		public VertexSortingOrder geometrySortingOrder { get; set; } // 0x0000000184DBA0B0-0x0000000184DBA0C0 0x000000018B32AF60-0x000000018B32AF80
		public bool isTextObjectScaleStatic { get; set; } // 0x0000000184DBA130-0x0000000184DBA140 0x000000018B32B0B8-0x000000018B32B118
		public bool vertexBufferAutoSizeReduction { get; set; } // 0x0000000184DBA300-0x0000000184DBA310 0x000000018B32B7F4-0x000000018B32B814
		public int firstVisibleCharacter { get; set; } // 0x0000000184DBA040-0x0000000184DBA050 0x000000018B32ABCC-0x000000018B32ABF4
		public int maxVisibleCharacters { get; set; } // 0x0000000184DBA210-0x0000000184DBA220 0x0000000184B4A810-0x0000000184B4A840
		public int maxVisibleWords { get; set; } // 0x0000000184DBA230-0x0000000184DBA240 0x000000018B32B444-0x000000018B32B46C
		public int maxVisibleLines { get; set; } // 0x0000000184DBA220-0x0000000184DBA230 0x000000018B32B41C-0x000000018B32B444
		public bool useMaxVisibleDescender { get; set; } // 0x0000000184DBA2F0-0x0000000184DBA300 0x000000018B32B7CC-0x000000018B32B7F4
		public int pageToDisplay { get; set; } // 0x0000000184DBA280-0x0000000184DBA290 0x000000018B32B588-0x000000018B32B5B0
		public virtual Vector4 margin { get; set; } // 0x0000000184DBA1F0-0x0000000184DBA200 0x000000018B32B374-0x000000018B32B41C
		public TMP_TextInfo textInfo { get; } // 0x0000000184DBA2E0-0x0000000184DBA2F0 
		public bool havePropertiesChanged { get; set; } // 0x0000000184DBA0C0-0x0000000184DBA0D0 0x000000018B32AF80-0x000000018B32AFA0
		public bool isUsingLegacyAnimationComponent { get; set; } // 0x0000000184DBA160-0x0000000184DBA170 0x0000000184DBA350-0x0000000184DBA360
		public new Transform transform { get; } // 0x0000000182EDE870-0x0000000182EDE910 
		public new RectTransform rectTransform { get; } // 0x00000001831E83F0-0x00000001831E8490 
		public virtual bool autoSizeTextContainer { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DB9F70-0x0000000184DB9F80 0x0000000184DBA340-0x0000000184DBA350
		public virtual Mesh mesh { get; } // 0x0000000184DB9A70-0x0000000184DB9A80 
		public bool isVolumetricText { get; set; } // 0x0000000184DBA170-0x0000000184DBA180 0x000000018B32B118-0x000000018B32B16C
		public Bounds bounds { get; } // 0x000000018B329F1C-0x000000018B329FC0 
		public Bounds textBounds { get; } // 0x000000018B32A600-0x000000018B32A654 
		protected TMP_SpriteAnimator spriteAnimator { get; } // 0x000000018B32A50C-0x000000018B32A600 
		public float flexibleHeight { get; } // 0x0000000184DBA050-0x0000000184DBA060 
		public float flexibleWidth { get; } // 0x0000000184DBA060-0x0000000184DBA070 
		public float minWidth { get; } // 0x0000000184DBA260-0x0000000184DBA270 
		public float minHeight { get; } // 0x0000000184DBA250-0x0000000184DBA260 
		public float maxWidth { get; } // 0x0000000184DBA240-0x0000000184DBA250 
		public float maxHeight { get; } // 0x0000000184DBA200-0x0000000184DBA210 
		protected LayoutElement layoutElement { get; } // 0x000000018B32A118-0x000000018B32A1A8 
		public virtual float preferredWidth { get; } // 0x0000000185391678-0x0000000185391698 
		public virtual float preferredHeight { get; } // 0x000000018539160C-0x0000000185391630 
		public virtual float renderedWidth { get; } // 0x000000018B325694-0x000000018B3256B0 
		public virtual float renderedHeight { get; } // 0x000000018B3255A4-0x000000018B3255C0 
		public int layoutPriority { get; } // 0x0000000184DBA180-0x0000000184DBA190 
	
		// Events
		public static event Func<int, string, TMP_FontAsset> OnFontAssetRequest {
			add; // 0x000000018B329CDC-0x000000018B329DA4
			remove; // 0x000000018B32A654-0x000000018B32A71C
		}
		public static event Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest {
			add; // 0x000000018B329E34-0x000000018B329EFC
			remove; // 0x000000018B32A7AC-0x000000018B32A874
		}
		public virtual event Action<TMP_TextInfo> OnPreRenderText {
			add; // 0x000000018B329DA4-0x000000018B329E34
			remove; // 0x000000018B32A71C-0x000000018B32A7AC
		}
	
		// Nested types
		protected struct CharacterSubstitution // TypeDefIndex: 55720
		{
			// Fields
			public int index; // 0x00
			public uint unicode; // 0x04
	
			// Constructors
			public CharacterSubstitution(int index, uint unicode); // 0x0000000184D85C40-0x0000000184D85C50
		}
	
		internal enum TextInputSources // TypeDefIndex: 55721
		{
			TextInputBox = 0,
			SetText = 1,
			SetTextArray = 2,
			TextString = 3
		}
	
		[DebuggerDisplay("Unicode ({unicode})  \'{(char)unicode}\'")]
		protected struct UnicodeChar // TypeDefIndex: 55722
		{
			// Fields
			public int unicode; // 0x00
			public int stringIndex; // 0x04
			public int length; // 0x08
		}
	
		protected struct SpecialCharacter // TypeDefIndex: 55723
		{
			// Fields
			public TMP_Character character; // 0x00
			public TMP_FontAsset fontAsset; // 0x08
			public Material material; // 0x10
			public int materialIndex; // 0x18
	
			// Constructors
			public SpecialCharacter(TMP_Character character, int materialIndex); // 0x000000018333AD10-0x000000018333AE40
		}
	
		private struct TextBackingContainer : IDisposable // TypeDefIndex: 55724
		{
			// Fields
			private uint[] m_Array; // 0x00
			private int m_Count; // 0x08
	
			// Properties
			public int Capacity { get; } // 0x000000018539210C-0x0000000185392128 
			public int Count { get; set; } // 0x0000000184D88B10-0x0000000184D88B20 0x0000000184D88B40-0x0000000184D88B50
			public uint this[int index] { get => default; set {} } // 0x000000018333E610-0x000000018333E640 0x000000018333BC20-0x000000018333BC80
	
			// Constructors
			public TextBackingContainer(int size); // 0x0000000183518980-0x00000001835189E0
	
			// Methods
			public void Resize(int size); // 0x0000000183339F40-0x0000000183339FA0
			public void Dispose(); // 0x00000001835194D0-0x0000000183519510
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55725
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<TMP_TextInfo> __9__689_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D49A50-0x0000000184D49AB0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _.ctor_b__689_0(TMP_TextInfo _p0_); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		protected TMP_Text(); // 0x0000000183695A00-0x0000000183695EB0
		static TMP_Text(); // 0x000000018478E1B0-0x000000018478E7A0
	
		// Methods
		public void ResetTextForPopulate(); // 0x000000018B328DA4-0x000000018B328DB4
		public virtual void RefreshPopulateText(); // 0x000000018B327DB4-0x000000018B327DE4
		protected virtual Material LoadMaterial(string path); // 0x00000001811EC580-0x00000001811EC590
		protected override void Awake(); // 0x0000000185392D94-0x0000000185392D9C
		public void InitDataFromPool(); // 0x00000001835181E0-0x0000000183518980
		protected override void OnDestroy(); // 0x0000000183519220-0x0000000183519440
		protected virtual void LoadFontAsset(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void SetSharedMaterial(Material mat); // 0x00000001841E1670-0x00000001841E1680
		protected virtual Material GetMaterial(Material mat); // 0x00000001811EC580-0x00000001811EC590
		protected virtual void SetFontBaseMaterial(Material mat); // 0x00000001841E1670-0x00000001841E1680
		protected virtual Material[] GetSharedMaterials(); // 0x00000001811EC580-0x00000001811EC590
		protected virtual void SetSharedMaterials(Material[] materials); // 0x00000001841E1670-0x00000001841E1680
		protected virtual Material[] GetMaterials(Material[] mats); // 0x00000001811EC580-0x00000001811EC590
		protected virtual Material CreateMaterialInstance(Material source); // 0x000000018B3222D0-0x000000018B322384
		protected void SetVertexColorGradient(TMP_ColorGradient gradient); // 0x000000018B329C3C-0x000000018B329CDC
		protected void SetTextSortingOrder(VertexSortingOrder order); // 0x00000001841E1670-0x00000001841E1680
		protected void SetTextSortingOrder(int[] order); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void SetFaceColor(Color32 color); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void SetOutlineColor(Color32 color); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void SetOutlineThickness(float thickness); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void SetShaderDepth(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void SetCulling(); // 0x00000001841E1670-0x00000001841E1680
		internal virtual void UpdateCulling(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual float GetPaddingForMaterial(); // 0x000000018333AE70-0x000000018333B000
		protected virtual float GetPaddingForMaterial(Material mat); // 0x000000018B325078-0x000000018B32516C
		protected virtual Vector3[] GetTextContainerLocalCorners(); // 0x00000001811EC580-0x00000001811EC590
		public virtual void ForceMeshUpdate(bool ignoreActiveState = false /* Metadata: 0x023473FE */, bool forceTextReparsing = false /* Metadata: 0x023473FF */); // 0x00000001841E1670-0x00000001841E1680
		public virtual void UpdateGeometry(Mesh mesh, int index); // 0x00000001841E1670-0x00000001841E1680
		public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x00000001841E1670-0x00000001841E1680
		public virtual void UpdateVertexData(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void SetVertices(Vector3[] vertices); // 0x00000001841E1670-0x00000001841E1680
		public virtual void UpdateMeshPadding(); // 0x00000001841E1670-0x00000001841E1680
		public override void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x00000001845F3E40-0x00000001845F3ED0
		public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x000000018B322384-0x000000018B3223E4
		protected virtual void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x00000001841E1670-0x00000001841E1680
		protected void ParseInputText(); // 0x000000018333C3B0-0x000000018333C4A0
		private void PopulateTextBackingArray(string sourceText); // 0x000000018333BE20-0x000000018333BE50
		private void PopulateTextBackingArray(string sourceText, int start, int length); // 0x000000018333BA70-0x000000018333BC20
		private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length); // 0x000000018B327668-0x000000018B327768
		private void PopulateTextBackingArray(char[] sourceText, int start, int length); // 0x000000018B327768-0x000000018B327864
		private void PopulateTextProcessingArray(); // 0x000000018333D0F0-0x000000018333D430
		private void SetTextInternal(string sourceText); // 0x000000018B3296E0-0x000000018B329734
		public void SetText(string sourceText, bool syncTextInputBox = true /* Metadata: 0x02347400 */); // 0x0000000183639B30-0x0000000183639BF0
		public void SetText(string sourceText, float arg0); // 0x000000018B329B98-0x000000018B329BD4
		public void SetText(string sourceText, float arg0, float arg1); // 0x000000018B329734-0x000000018B329770
		public void SetText(string sourceText, float arg0, float arg1, float arg2); // 0x000000018B329B08-0x000000018B329B4C
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3); // 0x000000018B329B4C-0x000000018B329B98
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4); // 0x000000018B329AB0-0x000000018B329B08
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5); // 0x000000018B3299E8-0x000000018B329A48
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6); // 0x000000018B329A48-0x000000018B329AB0
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7); // 0x000000018B32979C-0x000000018B3299E8
		public void SetText(StringBuilder sourceText); // 0x000000018B329770-0x000000018B32979C
		private void SetText(StringBuilder sourceText, int start, int length); // 0x000000018B329BE4-0x000000018B329C3C
		public void SetText(char[] sourceText); // 0x000000018B3296B8-0x000000018B3296E0
		public void SetText(char[] sourceText, int start, int length); // 0x000000018B329BD4-0x000000018B329BE4
		public void SetCharArray(char[] sourceText); // 0x000000018B3296B8-0x000000018B3296E0
		public void SetCharArray(char[] sourceText, int start, int length); // 0x000000018B329620-0x000000018B3296B8
		private TMP_Style GetStyle(int hashCode); // 0x000000018333CAC0-0x000000018333CC00
		private bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018B3285DC-0x000000018B3289A4
		private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018B3289A4-0x000000018B328D4C
		private void ReplaceClosingStyleTag(ref TextBackingContainer sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018B327EDC-0x000000018B328264
		private void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018B328264-0x000000018B3285DC
		private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018B327024-0x000000018B3273A0
		private void InsertClosingStyleTag(ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018B326CA8-0x000000018B327024
		private int GetMarkupTagHashCode(int[] tagDefinition, int readIndex); // 0x000000018B324FC4-0x000000018B325078
		private int GetMarkupTagHashCode(TextBackingContainer tagDefinition, int readIndex); // 0x0000000184111440-0x00000001841114E0
		private int GetStyleHashCode(ref int[] text, int index, out int closeIndex); // 0x000000018B3256B0-0x000000018B325770
		private int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex); // 0x000000018B325770-0x000000018B325838
		private void ResizeInternalArray<T>(ref ref T[] array);
		private void ResizeInternalArray<T>(ref ref T[] array, int size);
		private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex); // 0x000000018B321968-0x000000018B321C4C
		private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex); // 0x000000018B321C4C-0x000000018B321D64
		private string InternalTextBackingArrayToString(); // 0x000000018B3273A0-0x000000018B327478
		protected virtual int SetArraySizes(UnicodeChar[] unicodeChars); // 0x00000001811EC580-0x00000001811EC590
		public Vector2 GetPreferredValues(); // 0x000000018B3254B0-0x000000018B325504
		public Vector2 GetPreferredValues(float width, float height); // 0x000000018B325308-0x000000018B325370
		public Vector2 GetPreferredValues(string text); // 0x000000018B325370-0x000000018B325438
		public Vector2 GetPreferredValues(string text, float width, float height); // 0x000000018B325438-0x000000018B3254B0
		protected float GetPreferredWidth(); // 0x0000000183E641C0-0x0000000183E64370
		private float GetPreferredWidth(Vector2 margin); // 0x000000018B325504-0x000000018B325588
		protected float GetPreferredHeight(); // 0x0000000183E63FA0-0x0000000183E641C0
		private float GetPreferredHeight(Vector2 margin); // 0x000000018B325254-0x000000018B325308
		public Vector2 GetRenderedValues(); // 0x000000018B32561C-0x000000018B325678
		public Vector2 GetRenderedValues(bool onlyVisibleCharacters); // 0x000000018B3255C0-0x000000018B32561C
		private float GetRenderedWidth(); // 0x000000018B325694-0x000000018B3256B0
		protected float GetRenderedWidth(bool onlyVisibleCharacters); // 0x000000018B325678-0x000000018B325694
		private float GetRenderedHeight(); // 0x000000018B3255A4-0x000000018B3255C0
		protected float GetRenderedHeight(bool onlyVisibleCharacters); // 0x000000018B325588-0x000000018B3255A4
		protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled); // 0x000000018333EF20-0x0000000183341030
		protected virtual Bounds GetCompoundBounds(); // 0x0000000184D8F590-0x0000000184D8F5A0
		internal virtual Rect GetCanvasSpaceClippingRect(); // 0x0000000184D94BD0-0x0000000184D94BE0
		protected Bounds GetTextBounds(); // 0x000000018B325B70-0x000000018B325E80
		protected Bounds GetTextBounds(bool onlyVisibleCharacters); // 0x000000018B325838-0x000000018B325B70
		protected void AdjustLineOffset(int startIndex, int endIndex, float offset); // 0x000000018B321D64-0x000000018B322248
		protected void ResizeLineExtents(int size); // 0x0000000183516A20-0x0000000183516D20
		public virtual TMP_TextInfo GetTextInfo(string text); // 0x00000001811EC580-0x00000001811EC590
		public virtual void ComputeMarginSize(); // 0x00000001841E1670-0x00000001841E1680
		protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender); // 0x0000000183517750-0x0000000183518110
		protected void SaveWordWrappingState(ref WordWrapState state, int index, int count); // 0x0000000183516D20-0x0000000183517750
		protected int RestoreWordWrappingState(ref WordWrapState state); // 0x0000000183516280-0x0000000183516A20
		protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor); // 0x00000001832546F0-0x0000000183254CE0
		protected virtual void SaveSpriteVertexInfo(Color32 vertexColor); // 0x000000018B328DB4-0x000000018B329620
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4); // 0x0000000183253E80-0x00000001832546F0
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric); // 0x000000018B323AF8-0x000000018B3246E4
		protected virtual void FillSpriteVertexBuffers(int i, int index_X4); // 0x000000018B3246E4-0x000000018B324E94
		protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor); // 0x00000001843C9F40-0x00000001843CADF0
		protected void PrepareCharSlots(PhoneticData data); // 0x000000018B327864-0x000000018B327DB4
		protected virtual float PhoneticWidth(PhoneticData data); // 0x000000018B327540-0x000000018B327668
		protected virtual void DrawPhoneticMesh(Rect rect, PhoneticData data, float padding, float style_padding, bool justify, float lossyScale); // 0x000000018B3223E4-0x000000018B323618
		protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor); // 0x000000018B323618-0x000000018B323AF8
		protected void LoadDefaultSettings(); // 0x000000018351F1C0-0x000000018351F220
		protected void GetSpecialCharacters(TMP_FontAsset fontAsset); // 0x000000018333AE40-0x000000018333AE70
		protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset); // 0x000000018333AC00-0x000000018333AD10
		protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset); // 0x000000018333AB20-0x000000018333AC00
		protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c); // 0x000000018B328D4C-0x000000018B328DA4
		protected TMP_FontAsset GetFontAssetForWeight(int fontWeight); // 0x000000018B324F40-0x000000018B324FC4
		internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface); // 0x000000018333E640-0x000000018333E700
		public void TryRemoveDynamicFallbackFontAssetTextRef(); // 0x0000000183519E20-0x0000000183519E40
		protected virtual void SetActiveSubMeshes(bool state); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void DestroySubMeshObjects(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void ClearMesh(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void ClearMesh(bool uploadGeometry); // 0x00000001841E1670-0x00000001841E1680
		public virtual string GetParsedText(); // 0x000000018B32516C-0x000000018B325254
		internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent); // 0x000000018B327478-0x000000018B327540
		internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent); // 0x000000018B327DE4-0x000000018B327EDC
		protected Vector2 PackUV(float x, float y, float scale); // 0x0000000184DB9F20-0x0000000184DB9F60
		protected float PackUV(float x, float y); // 0x0000000184DB9EE0-0x0000000184DB9F20
		internal virtual void InternalUpdate(); // 0x00000001841E1670-0x00000001841E1680
		protected static int HexToInt(char hex); // 0x0000000183A278A0-0x0000000183A27970
		protected int GetUTF16(string text, int i); // 0x000000018B326048-0x000000018B326130
		protected int GetUTF16(int[] text, int i); // 0x000000018B325F68-0x000000018B326048
		internal int GetUTF16(uint[] text, int i); // 0x000000018B326208-0x000000018B3262E8
		protected int GetUTF16(StringBuilder text, int i); // 0x000000018B325E80-0x000000018B325F68
		private int GetUTF16(TextBackingContainer text, int i); // 0x000000018B326130-0x000000018B326208
		protected int GetUTF32(string text, int i); // 0x000000018B3262E8-0x000000018B326460
		protected int GetUTF32(int[] text, int i); // 0x000000018B3265D4-0x000000018B326748
		internal int GetUTF32(uint[] text, int i); // 0x000000018B326460-0x000000018B3265D4
		protected int GetUTF32(StringBuilder text, int i); // 0x000000018B3268A8-0x000000018B326A20
		private int GetUTF32(TextBackingContainer text, int i); // 0x000000018B326748-0x000000018B3268A8
		protected static Color32 HexCharsToColor(ReadOnlySpan<char> hexChars, int tagCount); // 0x0000000183A276C0-0x0000000183A278A0
		protected static Color32 HexCharsToColor(ReadOnlySpan<char> hexChars, int startIndex, int length); // 0x000000018B326A20-0x000000018B326CA8
		private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters); // 0x000000018B324E94-0x000000018B324F40
		protected float ConvertToFloat(char[] chars, int startIndex, int length); // 0x00000001853948A0-0x00000001853948C4
		protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex); // 0x00000001844F4280-0x00000001844F4360
		protected bool CheckIfEndPhonetic(UnicodeChar[] chars, int startIndex); // 0x000000018B322248-0x000000018B3222D0
		protected bool ValidateHtmlTag(UnicodeChar[] chars, int startIndex, out int endIndex); // 0x0000000183A26780-0x0000000183A276C0
	}

	public enum TextElementType : byte // TypeDefIndex: 55727
	{
		Character = 1,
		Sprite = 2
	}

	[Serializable]
	public class TMP_TextElement // TypeDefIndex: 55728
	{
		// Fields
		[SerializeField]
		protected TextElementType m_ElementType; // 0x10
		[SerializeField]
		internal uint m_Unicode; // 0x14
		internal TMP_Asset m_TextAsset; // 0x18
		internal Glyph m_Glyph; // 0x20
		[SerializeField]
		internal uint m_GlyphIndex; // 0x28
		[SerializeField]
		internal float m_Scale; // 0x2C
	
		// Properties
		public TextElementType elementType { get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
		public uint unicode { get; set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
		public TMP_Asset textAsset { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public Glyph glyph { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public uint glyphIndex { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public float scale { get; set; } // 0x0000000184D86AF0-0x0000000184D86B00 0x0000000184D86B00-0x0000000184D86B10
	
		// Constructors
		public TMP_TextElement(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class TMP_TextElement_Legacy // TypeDefIndex: 55729
	{
		// Fields
		public int id; // 0x10
		public float x; // 0x14
		public float y; // 0x18
		public float width; // 0x1C
		public float height; // 0x20
		public float xOffset; // 0x24
		public float yOffset; // 0x28
		public float xAdvance; // 0x2C
		public float scale; // 0x30
	
		// Constructors
		public TMP_TextElement_Legacy(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class TMP_TextInfo : IDisposable // TypeDefIndex: 55730
	{
		// Fields
		internal static Vector2 k_InfinityVectorPositive; // 0x00
		internal static Vector2 k_InfinityVectorNegative; // 0x08
		public TMP_Text textComponent; // 0x10
		public int characterCount; // 0x18
		public int spriteCount; // 0x1C
		public int spaceCount; // 0x20
		public int wordCount; // 0x24
		public int linkCount; // 0x28
		public int lineCount; // 0x2C
		public int pageCount; // 0x30
		public int materialCount; // 0x34
		public int characterToSubstituteIndex; // 0x38
		public TMP_CharacterInfo[] characterInfo; // 0x40
		public TMP_WordInfo[] wordInfo; // 0x48
		public TMP_LinkInfo[] linkInfo; // 0x50
		public TMP_LineInfo[] lineInfo; // 0x58
		public TMP_PageInfo[] pageInfo; // 0x60
		public TMP_MeshInfo[] meshInfo; // 0x68
		private TMP_MeshInfo[] m_CachedMeshInfo; // 0x70
	
		// Constructors
		public TMP_TextInfo(); // 0x000000018B333EEC-0x000000018B33409C
		internal TMP_TextInfo(int characterCount); // 0x000000018B33409C-0x000000018B334254
		public TMP_TextInfo(TMP_Text textComponent); // 0x000000018351F3D0-0x000000018351F5B0
		static TMP_TextInfo(); // 0x0000000184D561D0-0x0000000184D56230
	
		// Methods
		public void Clear(); // 0x0000000183EE0820-0x0000000183EE0880
		internal void ClearAllData(); // 0x000000018B3336A4-0x000000018B3337E4
		public void ClearMeshInfo(bool updateMesh); // 0x000000018B333864-0x000000018B3338F4
		public void ClearAllMeshInfo(); // 0x000000018B3337E4-0x000000018B333864
		public void ResetVertexLayout(bool isVolumetric); // 0x000000018B333E5C-0x000000018B333EEC
		public void ClearUnusedVertices(MaterialReference[] materials); // 0x000000018B3338F4-0x000000018B333974
		public void ClearLineInfo(); // 0x00000001832527E0-0x0000000183252BD0
		public void ClearPageInfo(); // 0x0000000183BB6530-0x0000000183BB6620
		public TMP_MeshInfo[] CopyMeshInfoVertexData(); // 0x000000018B333974-0x000000018B333E5C
		public static void Resize<T>(ref ref T[] array, int size);
		public static void Resize<T>(ref ref T[] array, int size, bool isBlockAllocated);
		public void Dispose(); // 0x0000000183518C30-0x0000000183518F50
	}

	public class TMP_TextParsingUtilities // TypeDefIndex: 55731
	{
		// Fields
		private static readonly TMP_TextParsingUtilities s_Instance; // 0x00
		private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x0234740B
		private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x0234748D
	
		// Properties
		public static TMP_TextParsingUtilities instance { get; } // 0x000000018B3343E8-0x000000018B334438 
	
		// Constructors
		static TMP_TextParsingUtilities(); // 0x0000000184D4D9B0-0x0000000184D4DA10
		public TMP_TextParsingUtilities(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static int GetHashCode(string s); // 0x000000018413A410-0x000000018413A4C0
		public static int GetHashCodeCaseSensitive(string s); // 0x000000018B334254-0x000000018B3342A8
		public static char ToLowerASCIIFast(char c); // 0x000000018B3342D8-0x000000018B334330
		public static char ToUpperASCIIFast(char c); // 0x000000018413A4C0-0x000000018413A520
		public static uint ToUpperASCIIFast(uint c); // 0x000000018B33438C-0x000000018B3343E8
		public static uint ToLowerASCIIFast(uint c); // 0x000000018B334330-0x000000018B33438C
		public static bool IsHighSurrogate(uint c); // 0x000000018B3342A8-0x000000018B3342C0
		public static bool IsLowSurrogate(uint c); // 0x000000018B3342C0-0x000000018B3342D8
		internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate); // 0x0000000184DBA3D0-0x0000000184DBA3E0
	}

	public struct TMP_FontStyleStack // TypeDefIndex: 55732
	{
		// Fields
		public byte bold; // 0x00
		public byte italic; // 0x01
		public byte underline; // 0x02
		public byte strikethrough; // 0x03
		public byte highlight; // 0x04
		public byte superscript; // 0x05
		public byte subscript; // 0x06
		public byte uppercase; // 0x07
		public byte lowercase; // 0x08
		public byte smallcaps; // 0x09
	
		// Methods
		public void Clear(); // 0x000000018333C3A0-0x000000018333C3B0
		public byte Add(FontStyles style); // 0x0000000183A279C0-0x0000000183A279F0
		public byte Remove(FontStyles style); // 0x0000000183A279F0-0x0000000183A27A20
	}

	[DebuggerDisplay("Item count = {m_Count}")]
	public struct TMP_TextProcessingStack<T> : IDisposable // TypeDefIndex: 55733
	{
		// Fields
		public T[] itemStack;
		public int index;
		private T m_DefaultItem;
		private int m_Capacity;
		private int m_RolloverSize;
		private int m_Count;
		private const int k_DefaultCapacity = 4; // Metadata: 0x0234750F
	
		// Properties
		public int Count { get; }
		public T current { get; }
		public int rolloverSize { get; set; }
	
		// Constructors
		public TMP_TextProcessingStack(T[] stack);
		public TMP_TextProcessingStack(int capacity);
		public TMP_TextProcessingStack(int capacity, int rolloverSize);
	
		// Methods
		internal static void SetDefault(TMP_TextProcessingStack<T>[] stack, T item);
		public void Clear();
		public void SetDefault(T item);
		public void Add(T item);
		public T Remove();
		public void Push(T item);
		public T Pop();
		public T Peek();
		public T CurrentItem();
		public T PreviousItem();
		public void RestoreFrom(TMP_TextProcessingStack<T> other);
		public void Dispose();
	}

	[DebuggerDisplay("Item count = {m_Count}")]
	public struct TMP_TextProcessingQueue<T> : IDisposable // TypeDefIndex: 55734
	{
		// Fields
		public T[] itemQueue;
		private int m_Head;
		private int m_Tail;
		private int m_Capacity;
		private int m_Count;
		private T m_DefaultItem;
		private const int k_DefaultCapacity = 4; // Metadata: 0x02347510
	
		// Properties
		public int Count { get; }
	
		// Constructors
		public TMP_TextProcessingQueue(T[] queue);
		public TMP_TextProcessingQueue(int capacity);
	
		// Methods
		public void Clear();
		public void SetDefault(T item);
		public void Enqueue(T item);
		public T Dequeue();
		public T Peek();
		private void Resize(int newCapacity);
		public void RestoreFrom(TMP_TextProcessingQueue<T> other);
		public void Dispose();
	}

	public enum CaretPosition // TypeDefIndex: 55735
	{
		None = 0,
		Left = 1,
		Right = 2
	}

	public struct CaretInfo // TypeDefIndex: 55736
	{
		// Fields
		public int index; // 0x00
		public CaretPosition position; // 0x04
	
		// Constructors
		public CaretInfo(int index, CaretPosition position); // 0x0000000184D85C40-0x0000000184D85C50
	}

	public static class TMP_TextUtilities // TypeDefIndex: 55738
	{
		// Fields
		private static Vector3[] m_rectWorldCorners; // 0x00
		private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x02347514
		private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x02347596
	
		// Nested types
		private struct LineSegment // TypeDefIndex: 55737
		{
			// Fields
			public Vector3 Point1; // 0x00
			public Vector3 Point2; // 0x0C
	
			// Constructors
			public LineSegment(Vector3 p1, Vector3 p2); // 0x0000000184D871E0-0x0000000184D87200
		}
	
		// Constructors
		static TMP_TextUtilities(); // 0x0000000184D36370-0x0000000184D363E0
	
		// Methods
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera); // 0x000000018B337934-0x000000018B337AE8
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor); // 0x000000018B337AE8-0x000000018B337D28
		public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera); // 0x000000018B3361E8-0x000000018B3363E4
		public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly); // 0x000000018B335900-0x000000018B335D9C
		public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera); // 0x000000018B338164-0x000000018B33834C
		public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly); // 0x000000018B334610-0x000000018B3348E0
		public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly); // 0x000000018B335D9C-0x000000018B3361E8
		public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera); // 0x000000018B3351DC-0x000000018B335900
		public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera); // 0x000000018B336E88-0x000000018B337934
		public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera); // 0x000000018B3348E0-0x000000018B334A70
		public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera); // 0x000000018B33514C-0x000000018B3351DC
		public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera, Vector2 linkExtraPadding); // 0x000000018B334A70-0x000000018B33514C
		private static float CalculateTouchLinkDistanceScore(Vector2 touchPos, Vector2 linkCenter); // 0x0000000184DBA3E0-0x0000000184DBA430
		public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera); // 0x000000018B3363E4-0x000000018B336E88
		private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d); // 0x000000018B33834C-0x000000018B338518
		public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint); // 0x000000018B338518-0x000000018B3386DC
		private static bool IntersectLinePlane(LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint); // 0x000000018B337F40-0x000000018B338164
		public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point); // 0x000000018B334438-0x000000018B334610
		public static char ToLowerFast(char c); // 0x000000018B33878C-0x000000018B3387E4
		public static char ToUpperFast(char c); // 0x000000018B3387E4-0x000000018B33883C
		internal static uint ToUpperASCIIFast(uint c); // 0x00000001841114E0-0x0000000184111520
		public static int GetHashCode(string s); // 0x000000018B337D28-0x000000018B337DB8
		public static int GetSimpleHashCode(string s); // 0x00000001839403C0-0x0000000183940420
		public static uint GetSimpleHashCodeLowercase(string s); // 0x000000018B337DB8-0x000000018B337E4C
		public static int HexToInt(char hex); // 0x000000018B337E4C-0x000000018B337F40
		public static int StringHexToInt(string s); // 0x000000018B3386DC-0x000000018B33878C
		public static bool IsThaiZeroWidthCharacter(char c); // 0x0000000183A22940-0x0000000183A229D0
		public static bool IsUpVowel(char c); // 0x0000000183A22A30-0x0000000183A22A60
		public static bool IsLowVowel(char c); // 0x0000000183A229D0-0x0000000183A22A00
		public static bool IsToneMark(char c); // 0x0000000183A22A00-0x0000000183A22A30
		public static bool IsAscenderThai(char c); // 0x0000000183CF12C0-0x0000000183CF12F0
		public static bool IsDescenderThai(char c); // 0x0000000183E14980-0x0000000183E149A0
	}

	public class TMP_UpdateManager // TypeDefIndex: 55739
	{
		// Fields
		private static TMP_UpdateManager s_Instance; // 0x00
		private readonly HashSet<int> m_LayoutQueueLookup; // 0x10
		private readonly List<TMP_Text> m_LayoutRebuildQueue; // 0x18
		private readonly HashSet<int> m_GraphicQueueLookup; // 0x20
		private readonly List<TMP_Text> m_GraphicRebuildQueue; // 0x28
		private readonly HashSet<int> m_InternalUpdateLookup; // 0x30
		private readonly List<TMP_Text> m_InternalUpdateQueue; // 0x38
		private readonly HashSet<int> m_CullingUpdateLookup; // 0x40
		private readonly List<TMP_Text> m_CullingUpdateQueue; // 0x48
		private static ProfilerMarker k_RegisterTextObjectForUpdateMarker; // 0x08
		private static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker; // 0x10
		private static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker; // 0x18
		private static ProfilerMarker k_UnregisterTextObjectForUpdateMarker; // 0x20
		private static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker; // 0x28
	
		// Properties
		private static TMP_UpdateManager instance { get; } // 0x000000018351C7D0-0x000000018351C8B0 
	
		// Constructors
		private TMP_UpdateManager(); // 0x0000000184992D70-0x0000000184992FB0
		static TMP_UpdateManager(); // 0x0000000184B1D650-0x0000000184B1D7A0
	
		// Methods
		internal static void RegisterTextObjectForUpdate(TMP_Text textObject); // 0x000000018351C6F0-0x000000018351C740
		private void InternalRegisterTextObjectForUpdate(TMP_Text textObject); // 0x000000018351C920-0x000000018351C9B0
		public static void RegisterTextElementForLayoutRebuild(TMP_Text element); // 0x000000018B33988C-0x000000018B3398E4
		private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element); // 0x000000018B339648-0x000000018B339704
		public static void RegisterTextElementForGraphicRebuild(TMP_Text element); // 0x000000018B339834-0x000000018B33988C
		private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element); // 0x000000018B33958C-0x000000018B339648
		public static void RegisterTextElementForCullingUpdate(TMP_Text element); // 0x0000000183EFA6E0-0x0000000183EFA730
		private void InternalRegisterTextElementForCullingUpdate(TMP_Text element); // 0x0000000183EFA730-0x0000000183EFA7C0
		private void OnCameraPreCull(); // 0x000000018B33982C-0x000000018B339834
		private void DoRebuilds(); // 0x00000001831BC2C0-0x00000001831BC430
		internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject); // 0x000000018351C740-0x000000018351C7D0
		public static void UnRegisterTextElementForRebuild(TMP_Text element); // 0x000000018B3398E4-0x000000018B339970
		private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element); // 0x000000018B339704-0x000000018B339798
		private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element); // 0x000000018B339798-0x000000018B33982C
		private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject); // 0x000000018351C8B0-0x000000018351C920
	}

	public class TMP_UpdateRegistry // TypeDefIndex: 55740
	{
		// Fields
		private static TMP_UpdateRegistry s_Instance; // 0x00
		private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
		private HashSet<int> m_LayoutQueueLookup; // 0x18
		private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
		private HashSet<int> m_GraphicQueueLookup; // 0x28
	
		// Properties
		public static TMP_UpdateRegistry instance { get; } // 0x000000018B33A0AC-0x000000018B33AA78 
	
		// Constructors
		protected TMP_UpdateRegistry(); // 0x000000018B339F38-0x000000018B33A0AC
	
		// Methods
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x000000018B339EC0-0x000000018B339EF0
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x000000018B339A5C-0x000000018B339B48
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x000000018B339E90-0x000000018B339EC0
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x000000018B339970-0x000000018B339A5C
		private void PerformUpdateForCanvasRendererObjects(); // 0x000000018B339CD8-0x000000018B339E3C
		private void PerformUpdateForMeshRendererObjects(); // 0x000000018B339E3C-0x000000018B339E90
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element); // 0x000000018B339EF0-0x000000018B339F38
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x000000018B339C10-0x000000018B339CD8
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x000000018B339B48-0x000000018B339C10
	}
}

namespace TMPro.SpriteAssetUtilities
{
	public enum SpriteAssetImportFormats // TypeDefIndex: 55741
	{
		None = 0,
		TexturePackerJsonArray = 1
	}

	public class TexturePacker_JsonArray // TypeDefIndex: 55747
	{
		// Nested types
		[Serializable]
		public struct SpriteFrame // TypeDefIndex: 55742
		{
			// Fields
			public float x; // 0x00
			public float y; // 0x04
			public float w; // 0x08
			public float h; // 0x0C
	
			// Methods
			public override string ToString(); // 0x000000018B339388-0x000000018B3394F8
		}
	
		[Serializable]
		public struct SpriteSize // TypeDefIndex: 55743
		{
			// Fields
			public float w; // 0x00
			public float h; // 0x04
	
			// Methods
			public override string ToString(); // 0x000000018B3394F8-0x000000018B33958C
		}
	
		[Serializable]
		public struct Frame // TypeDefIndex: 55744
		{
			// Fields
			public string filename; // 0x00
			public SpriteFrame frame; // 0x08
			public bool rotated; // 0x18
			public bool trimmed; // 0x19
			public SpriteFrame spriteSourceSize; // 0x1C
			public SpriteSize sourceSize; // 0x2C
			public Vector2 pivot; // 0x34
		}
	
		[Serializable]
		public struct Meta // TypeDefIndex: 55745
		{
			// Fields
			public string app; // 0x00
			public string version; // 0x08
			public string image; // 0x10
			public string format; // 0x18
			public SpriteSize size; // 0x20
			public float scale; // 0x28
			public string smartupdate; // 0x30
		}
	
		[Serializable]
		public class SpriteDataObject // TypeDefIndex: 55746
		{
			// Fields
			public List<Frame> frames; // 0x10
			public Meta meta; // 0x18
	
			// Constructors
			public SpriteDataObject(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public TexturePacker_JsonArray(); // 0x00000001841E1670-0x00000001841E1680
	}
}
