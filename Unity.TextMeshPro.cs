/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;
using UnityEngine.UI;

// Image 25: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 53079-53264

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 53264
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB; // 0x00 // Static value (base64): IAAuACwACQANAAoA - Metadata: 0x0207801C

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 53263
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace TMPro
{
	public class FastAction // TypeDefIndex: 53080
	{
		// Fields
		private LinkedList<Action> delegates; // 0x10
		private Dictionary<Action, LinkedListNode<Action>> lookup; // 0x18
	
		// Constructors
		public FastAction() {} // 0x000000018594A7B0-0x000000018594A860
	
		// Methods
		public void Add(Action rhs) {} // 0x000000018BDFD3E8-0x000000018BDFD49C
		public void Remove(Action rhs) {} // 0x000000018BDFD51C-0x000000018BDFD5CC
		public void Call() {} // 0x000000018BDFD49C-0x000000018BDFD51C
	}

	public class FastAction<A> // TypeDefIndex: 53081
	{
		// Fields
		private LinkedList<Action<A>> delegates;
		private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup;
	
		// Constructors
		public FastAction() {}
	
		// Methods
		public void Add(Action<A> rhs) {}
		public void Remove(Action<A> rhs) {}
		public void Call(A a) {}
	}

	public class FastAction<A, B> // TypeDefIndex: 53082
	{
		// Fields
		private LinkedList<Action<A, B>> delegates;
		private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup;
	
		// Constructors
		public FastAction() {}
	
		// Methods
		public void Add(Action<A, B> rhs) {}
		public void Remove(Action<A, B> rhs) {}
		public void Call(A a, B b) {}
	}

	public class FastAction<A, B, C> // TypeDefIndex: 53083
	{
		// Fields
		private LinkedList<Action<A, B, C>> delegates;
		private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup;
	
		// Constructors
		public FastAction() {}
	
		// Methods
		public void Add(Action<A, B, C> rhs) {}
		public void Remove(Action<A, B, C> rhs) {}
		public void Call(A a, B b, C c) {}
	}

	public interface IFontAssetLoader // TypeDefIndex: 53084
	{
		// Methods
		bool TryGetFontAsset(TMP_Text refText, uint unicode, out TMP_FontAsset fontAsset);
		void TryRemoveRefText(TMP_Text refText);
	}

	public interface ITextPreprocessor // TypeDefIndex: 53085
	{
		// Methods
		string PreprocessText(string text);
	}

	public class LocalizedTextPreprocessor : ITextPreprocessor // TypeDefIndex: 53086
	{
		// Fields
		private static LocalizedTextPreprocessor _instance; // 0x00
	
		// Properties
		public static LocalizedTextPreprocessor Instance { get => default; } // 0x0000000183F78100-0x0000000183F78410 
	
		// Constructors
		public LocalizedTextPreprocessor() {} // 0x0000000185492010-0x0000000185492020
		static LocalizedTextPreprocessor() {} // 0x0000000183F77DA0-0x0000000183F78100
	
		// Methods
		public string PreprocessText(string text) => default; // 0x0000000183F76C70-0x0000000183F77DA0
	}

	public class MaterialReferenceManager // TypeDefIndex: 53087
	{
		// Fields
		private static MaterialReferenceManager s_Instance; // 0x00
		private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
		private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
		private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
		private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x28
	
		// Properties
		public static MaterialReferenceManager instance { get => default; } // 0x000000018BDFDEB0-0x000000018BDFDF40 
	
		// Constructors
		public MaterialReferenceManager() {} // 0x000000018BDFDD58-0x000000018BDFDEB0
	
		// Methods
		public static void AddFontAsset(TMP_FontAsset fontAsset) {} // 0x000000018BDFD744-0x000000018BDFD774
		private void AddFontAssetInternal(TMP_FontAsset fontAsset) {} // 0x000000018BDFD694-0x000000018BDFD744
		public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset) {} // 0x000000018BDFD984-0x000000018BDFD9B4
		private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset) {} // 0x000000018BDFD814-0x000000018BDFD8C4
		public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset) {} // 0x000000018BDFD9B4-0x000000018BDFD9F0
		private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset) {} // 0x000000018BDFD8C4-0x000000018BDFD984
		public static void AddFontMaterial(int hashCode, Material material) {} // 0x000000018BDFD7D8-0x000000018BDFD814
		private void AddFontMaterialInternal(int hashCode, Material material) {} // 0x000000018BDFD774-0x000000018BDFD7D8
		public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset) {} // 0x000000018BDFD658-0x000000018BDFD694
		private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset) {} // 0x000000018BDFD5CC-0x000000018BDFD658
		public bool Contains(TMP_FontAsset font) => default; // 0x000000018BDFD9F0-0x000000018BDFDA4C
		public bool Contains(TMP_SpriteAsset sprite) => default; // 0x000000018BDFDA4C-0x000000018BDFDAA8
		public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset) {
			fontAsset = default;
			return default;
		} // 0x000000018BDFDBC4-0x000000018BDFDC00
		private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset) {
			fontAsset = default;
			return default;
		} // 0x000000018BDFDB54-0x000000018BDFDBC4
		public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset) {
			spriteAsset = default;
			return default;
		} // 0x000000018BDFDD1C-0x000000018BDFDD58
		private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset) {
			spriteAsset = default;
			return default;
		} // 0x000000018BDFDCAC-0x000000018BDFDD1C
		public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset) {
			gradientPreset = default;
			return default;
		} // 0x000000018BDFDB18-0x000000018BDFDB54
		private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset) {
			gradientPreset = default;
			return default;
		} // 0x000000018BDFDAA8-0x000000018BDFDB18
		public static bool TryGetMaterial(int hashCode, out Material material) {
			material = default;
			return default;
		} // 0x000000018BDFDC70-0x000000018BDFDCAC
		private bool TryGetMaterialInternal(int hashCode, out Material material) {
			material = default;
			return default;
		} // 0x000000018BDFDC00-0x000000018BDFDC70
	}

	public struct TMP_MaterialReference // TypeDefIndex: 53088
	{
		// Fields
		public Material material; // 0x00
		public int referenceCount; // 0x08
	}

	public struct MaterialReference // TypeDefIndex: 53089
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
		public MaterialReference(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding) {
			this.index = default;
			this.fontAsset = default;
			this.spriteAsset = default;
			this.material = default;
			isDefaultMaterial = default;
			isFallbackMaterial = default;
			fallbackMaterial = default;
			this.padding = default;
			referenceCount = default;
		} // 0x0000000184D66A00-0x0000000184D66BF0
	
		// Methods
		public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset) => default; // 0x000000018BDFE12C-0x000000018BDFE1F4
		public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) => default; // 0x0000000184264790-0x0000000184264A60
		public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) => default; // 0x000000018BDFDF40-0x000000018BDFE12C
	}

	public enum TextContainerAnchors // TypeDefIndex: 53090
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

	public class TextContainer : UIBehaviour // TypeDefIndex: 53091
	{
		// Fields
		private bool m_hasChanged; // 0x18
		private Vector2 m_pivot; // 0x1C
		private TextContainerAnchors m_anchorPosition; // 0x24
		private Rect m_rect; // 0x28
		private bool m_isDefaultWidth; // 0x38
		private bool m_isDefaultHeight; // 0x39
		private bool m_isAutoFitting; // 0x3A
		private Vector3[] m_corners; // 0x40
		private Vector3[] m_worldCorners; // 0x48
		private Vector4 m_margins; // 0x50
		private RectTransform m_rectTransform; // 0x60
		private static Vector2 k_defaultSize; // 0x00
		private TextMeshPro m_textMeshPro; // 0x68
	
		// Properties
		public bool hasChanged { get => default; set {} } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public Vector2 pivot { get => default; set {} } // 0x0000000185FE57F0-0x0000000185FE5810 0x000000018BDFEB28-0x000000018BDFEB98
		public TextContainerAnchors anchorPosition { get => default; set {} } // 0x0000000181424480-0x0000000181424490 0x000000018BDFEA48-0x000000018BDFEA90
		public Rect rect { get => default; set {} } // 0x0000000185FBB610-0x0000000185FBB620 0x000000018BDFEB98-0x000000018BDFEBF0
		public Vector2 size { get => default; set {} } // 0x0000000185FE5810-0x0000000185FE5830 0x000000018BDFEBF0-0x000000018BDFEC50
		public float width { get => default; set {} } // 0x0000000185FE5830-0x0000000185FE5840 0x000000018BDFEC50-0x000000018BDFEC98
		public float height { get => default; set {} } // 0x0000000186472350-0x0000000186472358 0x000000018BDFEA90-0x000000018BDFEAD8
		public bool isDefaultWidth { get => default; } // 0x0000000185FB0700-0x0000000185FB0710 
		public bool isDefaultHeight { get => default; } // 0x0000000185FB0710-0x0000000185FB0720 
		public bool isAutoFitting { get => default; set {} } // 0x0000000185FB0B20-0x0000000185FB0B30 0x0000000185FB0B50-0x0000000185FB0B60
		public Vector3[] corners { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		public Vector3[] worldCorners { get => default; } // 0x00000001813ECF20-0x00000001813ECF30 
		public Vector4 margins { get => default; set {} } // 0x0000000185FB6BD0-0x0000000185FB6BE0 0x000000018BDFEAD8-0x000000018BDFEB28
		public RectTransform rectTransform { get => default; } // 0x000000018BDFE940-0x000000018BDFE9C4 
		public TextMeshPro textMeshPro { get => default; } // 0x000000018BDFE9C4-0x000000018BDFEA48 
	
		// Constructors
		public TextContainer() {} // 0x000000018BDFE8C8-0x000000018BDFE940
		static TextContainer() {} // 0x000000018BDFE888-0x000000018BDFE8C8
	
		// Methods
		protected override void Awake() {} // 0x000000018BDFE1F4-0x000000018BDFE294
		protected override void OnEnable() {} // 0x000000018BDFE568-0x000000018BDFE570
		protected override void OnDisable() {} // 0x0000000185492010-0x0000000185492020
		private void OnContainerChanged() {} // 0x000000018BDFE46C-0x000000018BDFE568
		protected override void OnRectTransformDimensionsChange() {} // 0x000000018BDFE570-0x000000018BDFE6C8
		private void SetRect(Vector2 size) {} // 0x0000000185FE57A0-0x0000000185FE57F0
		private void UpdateCorners() {} // 0x000000018BDFE6C8-0x000000018BDFE888
		private Vector2 GetPivot(TextContainerAnchors anchor) => default; // 0x000000018BDFE3E0-0x000000018BDFE46C
		private TextContainerAnchors GetAnchorPosition(Vector2 pivot) => default; // 0x000000018BDFE294-0x000000018BDFE3E0
	}

	public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 53092
	{
		// Fields
		internal int _SortingLayer; // 0xAF0
		internal int _SortingLayerID; // 0xAF4
		internal int _SortingOrder; // 0xAF8
		private Action<TMP_TextInfo> OnPreRenderText; // 0xB00
		private bool m_currentAutoSizeMode; // 0xB08
		private bool m_hasFontAssetChanged; // 0xB09
		private float m_previousLossyScaleY; // 0xB0C
		private Renderer m_renderer; // 0xB10
		private MeshFilter m_meshFilter; // 0xB18
		private bool m_isFirstAllocation; // 0xB20
		private int m_max_characters; // 0xB24
		private int m_max_numberOfLines; // 0xB28
		private TMP_SubMesh[] m_subTextObjects; // 0xB30
		private MaskingTypes m_maskType; // 0xB38
		private Matrix4x4 m_EnvMapMatrix; // 0xB3C
		private Vector3[] m_RectTransformCorners; // 0xB80
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0xB88
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
		public int sortingLayerID { get => default; set {} } // 0x000000018BE07D74-0x000000018BE07DF0 0x000000018BE0800C-0x000000018BE080A8
		public int sortingOrder { get => default; set {} } // 0x000000018BE07DF0-0x000000018BE07E6C 0x000000018BE080A8-0x000000018BE08144
		public override bool autoSizeTextContainer { get => default; set {} } // 0x0000000185FE5840-0x0000000185FE5850 0x000000018BE07F8C-0x000000018BE07FFC
		public TextContainer textContainer { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public new Transform transform { get => default; } // 0x000000018BE07E6C-0x000000018BE07EFC 
		public Renderer renderer { get => default; } // 0x000000018BE07CE4-0x000000018BE07D74 
		public override Mesh mesh { get => default; } // 0x000000018BE07C28-0x000000018BE07CE4 
		public MeshFilter meshFilter { get => default; } // 0x000000018BE07B18-0x000000018BE07C28 
		public MaskingTypes maskType { get => default; set {} } // 0x0000000185FE5870-0x0000000185FE5880 0x000000018BE07FFC-0x000000018BE0800C
	
		// Events
		public override event Action<TMP_TextInfo> OnPreRenderText;
	
		// Constructors
		public TextMeshPro() {} // 0x000000018BE079CC-0x000000018BE07A88
		static TextMeshPro() {} // 0x000000018BE07550-0x000000018BE079CC
	
		// Methods
		public void SetMask(MaskingTypes type, Vector4 maskCoords) {} // 0x000000018BE05C54-0x000000018BE05C90
		public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) {} // 0x000000018BE05E18-0x000000018BE05E74
		public override void SetVerticesDirty() {} // 0x000000018BE068B8-0x000000018BE06934
		public override void SetLayoutDirty() {} // 0x000000018BE05A28-0x000000018BE05AD0
		public override void SetMaterialDirty() {} // 0x000000018B4A7C74-0x000000018B4A7C84
		public override void SetAllDirty() {} // 0x0000000185179950-0x0000000185179990
		public override void Rebuild(CanvasUpdate update) {} // 0x000000018BE03180-0x000000018BE03244
		protected override void UpdateMaterial() {} // 0x000000018BE06C00-0x000000018BE06D20
		public override void UpdateMeshPadding() {} // 0x000000018BE06D20-0x000000018BE06E28
		public override void ForceMeshUpdate(bool ignoreActiveState = false /* Metadata: 0x02077A94 */, bool forceTextReparsing = false /* Metadata: 0x02077A95 */) {} // 0x000000018BE01AC4-0x000000018BE01AD8
		public override TMP_TextInfo GetTextInfo(string text) => default; // 0x000000018BE02300-0x000000018BE02358
		public override void ClearMesh(bool updateMesh) {} // 0x000000018BE014C4-0x000000018BE015AC
		public override void UpdateGeometry(Mesh mesh, int index) {} // 0x000000018BE06B70-0x000000018BE06B94
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) {} // 0x000000018BE071BC-0x000000018BE07380
		public override void UpdateVertexData() {} // 0x000000018BE07380-0x000000018BE07550
		public void UpdateFontAsset() {} // 0x000000018BE005E0-0x000000018BE005F0
		public void CalculateLayoutInputHorizontal() {} // 0x0000000185492010-0x0000000185492020
		public void CalculateLayoutInputVertical() {} // 0x0000000185492010-0x0000000185492020
		protected override void Awake() {} // 0x000000018BE0109C-0x000000018BE014C4
		protected override void OnEnable() {} // 0x000000018BE02C88-0x000000018BE02D64
		protected override void OnDisable() {} // 0x000000018BE02BEC-0x000000018BE02C88
		protected override void OnDestroy() {} // 0x000000018BE02B28-0x000000018BE02BD0
		protected override void LoadFontAsset() {} // 0x000000018BE02410-0x000000018BE02B28
		private void UpdateEnvMapMatrix() {} // 0x000000018BE06934-0x000000018BE06B70
		private void SetMask(MaskingTypes maskType) {} // 0x000000018BE05C90-0x000000018BE05E18
		private void SetMaskCoordinates(Vector4 coords) {} // 0x000000018BE05BD0-0x000000018BE05C54
		private void SetMaskCoordinates(Vector4 coords, float softX, float softY) {} // 0x000000018BE05AD0-0x000000018BE05BD0
		private void EnableMasking() {} // 0x000000018BE019A8-0x000000018BE01AC4
		private void DisableMasking() {} // 0x000000018BE0188C-0x000000018BE019A8
		private void UpdateMask() {} // 0x000000018BE06B94-0x000000018BE06C00
		protected override Material GetMaterial(Material mat) => default; // 0x000000018BE01E88-0x000000018BE01F94
		protected override Material[] GetMaterials(Material[] mats) => default; // 0x000000018BE01F94-0x000000018BE02110
		protected override void SetSharedMaterial(Material mat) {} // 0x000000018BDFFF20-0x000000018BDFFF60
		protected override Material[] GetSharedMaterials() => default; // 0x000000018BE02110-0x000000018BE02260
		protected override void SetSharedMaterials(Material[] materials) {} // 0x000000018BE0653C-0x000000018BE068B8
		protected override void SetOutlineThickness(float thickness) {} // 0x000000018BE061AC-0x000000018BE0631C
		protected override void SetFaceColor(Color32 color) {} // 0x000000018BE058E0-0x000000018BE05A28
		protected override void SetOutlineColor(Color32 color) {} // 0x000000018BE06064-0x000000018BE061AC
		private void CreateMaterialInstance() {} // 0x000000018BE016F4-0x000000018BE017CC
		protected override void SetShaderDepth() {} // 0x000000018BE063BC-0x000000018BE0653C
		protected override void SetCulling() {} // 0x000000018BE0558C-0x000000018BE058E0
		private void SetPerspectiveCorrection() {} // 0x000000018BE0631C-0x000000018BE063BC
		protected override int SetArraySizes(UnicodeChar[] unicodeChars) => default; // 0x000000018BE03454-0x000000018BE0558C
		public override void ComputeMarginSize() {} // 0x000000018BE015AC-0x000000018BE016F4
		protected override void OnDidApplyAnimationProperties() {} // 0x000000018BE02BD0-0x000000018BE02BEC
		protected override void OnTransformParentChanged() {} // 0x000000018BE03158-0x000000018BE03180
		protected override void OnRectTransformDimensionsChange() {} // 0x000000018BE02FD8-0x000000018BE03158
		internal override void InternalUpdate() {} // 0x000000018BE02358-0x000000018BE02410
		private void OnPreRenderObject() {} // 0x000000018BE02D64-0x000000018BE02FD8
		protected virtual void GenerateTextMesh() {} // 0x000000018BDF1A98-0x000000018BDFD3E8
		protected override Vector3[] GetTextContainerLocalCorners() => default; // 0x000000018BE02260-0x000000018BE02300
		private void SetMeshFilters(bool state) {} // 0x000000018BE05E74-0x000000018BE06064
		protected override void SetActiveSubMeshes(bool state) {} // 0x000000018BE03244-0x000000018BE03340
		protected void SetActiveSubTextObjectRenderers(bool state) {} // 0x000000018BE03340-0x000000018BE03454
		protected override void DestroySubMeshObjects() {} // 0x000000018BE017CC-0x000000018BE0188C
		internal void UpdateSubMeshSortingLayerID(int id) {} // 0x000000018BE06FBC-0x000000018BE070BC
		internal void UpdateSubMeshSortingOrder(int order) {} // 0x000000018BE070BC-0x000000018BE071BC
		protected override Bounds GetCompoundBounds() => default; // 0x000000018BE01AD8-0x000000018BE01E88
		private void UpdateSDFScale(float scaleDelta) {} // 0x000000018BE06E28-0x000000018BE06FBC
	}

	public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 53095
	{
		// Fields
		private bool m_isRebuildingLayout; // 0xAF0
		private Coroutine m_DelayedGraphicRebuild; // 0xAF8
		private Coroutine m_DelayedMaterialRebuild; // 0xB00
		private Rect m_ClipRect; // 0xB08
		private bool m_ValidRect; // 0xB18
		private Action<TMP_TextInfo> OnPreRenderText; // 0xB20
		private bool m_hasFontAssetChanged; // 0xB28
		protected TMP_SubMeshUI[] m_subTextObjects; // 0xB30
		protected Vector3[] m_RectTransformCorners; // 0xB38
		protected CanvasRenderer m_canvasRenderer; // 0xB40
		protected Canvas m_canvas; // 0xB48
		protected float m_CanvasScaleFactor; // 0xB50
		protected float m_previousLossyScaleY; // 0xB54
		private bool m_isFirstAllocation; // 0xB58
		private int m_max_characters; // 0xB5C
		private Material m_baseMaterial; // 0xB60
		private bool m_isScrollRegionSet; // 0xB68
		private Vector4 m_maskOffset; // 0xB6C
		private Matrix4x4 m_EnvMapMatrix; // 0xB7C
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0xBBC
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
		public override Material materialForRendering { get => default; } // 0x000000018BDFED38-0x000000018BDFED94 
		public override bool autoSizeTextContainer { get => default; set {} } // 0x0000000184683470-0x00000001846835A0 0x00000001840E0B10-0x00000001840E0BF0
		public override Mesh mesh { get => default; } // 0x0000000183FCB620-0x0000000183FCB6D0 
		public new CanvasRenderer canvasRenderer { get => default; } // 0x0000000184F05270-0x0000000184F054B0 
		public Vector4 maskOffset { get => default; set {} } // 0x00000001849D0AF0-0x00000001849D0B90 0x000000018BE005F0-0x000000018BE0067C
	
		// Events
		public override event Action<TMP_TextInfo> OnPreRenderText;
	
		// Nested types
		private sealed class _DelayedGraphicRebuild_d__18 : IEnumerator<object> // TypeDefIndex: 53093
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TextMeshProUGUI __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185FE5860-0x0000000185FE5870 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public _DelayedGraphicRebuild_d__18() {} // Dummy constructor
			public _DelayedGraphicRebuild_d__18(int __1__state) {} // 0x0000000184EC2EE0-0x0000000184EC2F50
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FE5840-0x0000000185FE5850
			private bool MoveNext() => default; // 0x000000018BE01004-0x000000018BE01074
			void IEnumerator.Reset() {} // 0x0000000184F054B0-0x0000000184F055F0
		}
	
		private sealed class _DelayedMaterialRebuild_d__19 : IEnumerator<object> // TypeDefIndex: 53094
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TextMeshProUGUI __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018423CAF0-0x000000018423CC70 
			object IEnumerator.Current { get => default; } // 0x000000018BDFECDC-0x000000018BDFED38 
	
			// Constructors
			public _DelayedMaterialRebuild_d__19() {} // Dummy constructor
			public _DelayedMaterialRebuild_d__19(int __1__state) {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018423FA70-0x000000018423FBE0
			private bool MoveNext() => default; // 0x0000000184430ED0-0x0000000184431030
			void IEnumerator.Reset() {} // 0x0000000185179950-0x0000000185179990
		}
	
		// Constructors
		public TextMeshProUGUI() {} // 0x000000018BE15AB4-0x000000018BE15B00
		static TextMeshProUGUI() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public void CalculateLayoutInputHorizontal() {} // 0x0000000185FE5850-0x0000000185FE5860
		public void CalculateLayoutInputVertical() {} // 0x000000018BE01074-0x000000018BE0109C
		public override void SetVerticesDirty() {} // 0x0000000183FCA880-0x0000000183FCA890
		public override void SetLayoutDirty() {} // 0x00000001840E6520-0x00000001840E6840
		public override void SetMaterialDirty() {} // 0x000000018422D2D0-0x000000018422D500
		public override void SetAllDirty() {} // 0x000000018BE00ABC-0x000000018BE00BC4
		private IEnumerator DelayedGraphicRebuild() => default; // 0x0000000185BC64C0-0x0000000185BC6520
		private IEnumerator DelayedMaterialRebuild() => default; // 0x000000018BDFF528-0x000000018BDFF5D4
		public override void Rebuild(CanvasUpdate update) {} // 0x0000000184682840-0x00000001846828F0
		private void UpdateSubObjectPivot() {} // 0x000000018BDFF45C-0x000000018BDFF528
		public override Material GetModifiedMaterial(Material baseMaterial) => default; // 0x000000018557C340-0x000000018557C400
		protected override void UpdateMaterial() {} // 0x00000001849D0B90-0x00000001849D0C30
		public override void RecalculateClipping() {} // 0x000000018BE00BC4-0x000000018BE00DDC
		public override void Cull(Rect clipRect, bool validRect) {} // 0x000000018BE00DDC-0x000000018BE01004
		internal override void UpdateCulling() {} // 0x000000018BE005E0-0x000000018BE005F0
		public override void UpdateMeshPadding() {} // 0x00000001842450C0-0x0000000184245400
		protected override void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) {} // 0x0000000184240AA0-0x0000000184240C40
		protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) {} // 0x000000018423FBE0-0x000000018423FEC0
		public override void ForceMeshUpdate(bool ignoreActiveState = false /* Metadata: 0x02077A96 */, bool forceTextReparsing = false /* Metadata: 0x02077A97 */) {} // 0x0000000184243140-0x00000001842432B0
		public override TMP_TextInfo GetTextInfo(string text) => default; // 0x0000000184685000-0x00000001846853F0
		public override void ClearMesh() {} // 0x0000000184240C40-0x0000000184240DF0
		public override void UpdateGeometry(Mesh mesh, int index) {} // 0x0000000185492010-0x0000000185492020
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) {} // 0x000000018BE0067C-0x000000018BE00ABC
		public override void UpdateVertexData() {} // 0x000000018BDFF058-0x000000018BDFF188
		public void UpdateFontAsset() {} // 0x000000018BDFF188-0x000000018BDFF308
		protected override void Awake() {} // 0x000000018BDFFF20-0x000000018BDFFF60
		protected override void OnEnable() {} // 0x000000018BDFF308-0x000000018BDFF45C
		protected override void OnDisable() {} // 0x000000018BDFFF60-0x000000018BE003A4
		protected override void OnDestroy() {} // 0x000000018BDFFB84-0x000000018BDFFD5C
		protected override void LoadFontAsset() {} // 0x000000018BDFF898-0x000000018BDFF9B4
		private Canvas GetCanvas() => default; // 0x000000018BDFFA68-0x000000018BDFFB84
		private void UpdateEnvMapMatrix() {} // 0x000000018BDFFDFC-0x000000018BDFFF20
		private void EnableMasking() {} // 0x000000018BDFF5D4-0x000000018BDFF898
		private void DisableMasking() {} // 0x000000018BDFFD5C-0x000000018BDFFDFC
		private void UpdateMask() {} // 0x000000018BDFF9B4-0x000000018BDFFA68
		protected override Material GetMaterial(Material mat) => default; // 0x00000001842B24C0-0x00000001842B3EF0
		protected override Material[] GetMaterials(Material[] mats) => default; // 0x0000000184430CC0-0x0000000184430ED0
		protected override void SetSharedMaterial(Material mat) {} // 0x0000000185502350-0x0000000185502380
		protected override Material[] GetSharedMaterials() => default; // 0x0000000183F91DD0-0x0000000183F91F40
		protected override void SetSharedMaterials(Material[] materials) {} // 0x00000001850B7C50-0x00000001850B7CA0
		protected override void SetOutlineThickness(float thickness) {} // 0x00000001840E0BF0-0x00000001840E0E90
		protected override void SetFaceColor(Color32 color) {} // 0x00000001840E70A0-0x00000001840E71A0
		protected override void SetOutlineColor(Color32 color) {} // 0x00000001846835A0-0x00000001846845B0
		protected override void SetShaderDepth() {} // 0x000000018BDFEC98-0x000000018BDFECDC
		protected override void SetCulling() {} // 0x00000001842B57E0-0x00000001842C4CC0
		private void SetPerspectiveCorrection() {} // 0x0000000184FCC930-0x0000000184FCCA80
		private void SetMeshArrays(int size) {} // 0x0000000184F3AE60-0x0000000184F3B000
		protected override int SetArraySizes(UnicodeChar[] unicodeChars) => default; // 0x000000018BDFED94-0x000000018BDFEE54
		public override void ComputeMarginSize() {} // 0x0000000184133CE0-0x0000000184134800
		protected override void OnDidApplyAnimationProperties() {} // 0x00000001840E71A0-0x00000001840E7760
		protected override void OnCanvasHierarchyChanged() {} // 0x000000018496D460-0x000000018496D620
		protected override void OnTransformParentChanged() {} // 0x00000001848136E0-0x00000001848137B0
		protected override void OnRectTransformDimensionsChange() {} // 0x00000001859928E0-0x0000000185992DB0
		internal override void InternalUpdate() {} // 0x0000000181378230-0x0000000181378240
		private void OnPreRenderCanvas() {} // 0x0000000185492010-0x0000000185492020
		protected virtual TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) => default; // 0x000000018BE08144-0x000000018BE081F0
		protected virtual void GenerateTextMesh() {} // 0x0000000181377E40-0x0000000181377E50
		protected override Vector3[] GetTextContainerLocalCorners() => default; // 0x000000018BE081F0-0x000000018BE0828C
		protected override void SetActiveSubMeshes(bool state) {} // 0x0000000181377E40-0x0000000181377E50
		protected override void DestroySubMeshObjects() {} // 0x0000000181378230-0x0000000181378240
		protected override Bounds GetCompoundBounds() => default; // 0x0000000185492010-0x0000000185492020
		internal override Rect GetCanvasSpaceClippingRect() => default; // 0x000000018BE15A00-0x000000018BE15AB4
		private void UpdateSDFScale(float scaleDelta) {} // 0x0000000181377E40-0x0000000181377E50
	}

	public enum Compute_DistanceTransform_EventTypes // TypeDefIndex: 53096
	{
		Processing = 0,
		Completed = 1
	}

	public static class TMPro_EventManager // TypeDefIndex: 53097
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
		static TMPro_EventManager() {} // 0x000000018594A330-0x000000018594A7B0
	
		// Methods
		public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) {} // 0x000000018BE14F14-0x000000018BE14F94
		public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj) {} // 0x000000018BE14E94-0x000000018BE14F14
		public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj) {} // 0x000000018BE14FE8-0x000000018BE15068
		public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj) {} // 0x000000018BE15068-0x000000018BE150E8
		public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) {} // 0x000000018BE14E00-0x000000018BE14E94
		public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) {} // 0x000000018BE15168-0x000000018BE151D4
		public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(UnityEngine.Object obj) {} // 0x000000018BE14D14-0x000000018BE14D84
		public static void ON_TEXT_CHANGED(UnityEngine.Object obj) {} // 0x000000018514C8C0-0x000000018514C940
		public static void ON_TMP_SETTINGS_CHANGED() {} // 0x000000018BE151D4-0x000000018BE15228
		public static void ON_RESOURCES_LOADED() {} // 0x000000018BE14F94-0x000000018BE14FE8
		public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj) {} // 0x000000018BE150E8-0x000000018BE15168
		public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) {} // 0x000000018BE14D84-0x000000018BE14E00
	}

	public class Compute_DT_EventArgs // TypeDefIndex: 53098
	{
		// Fields
		public Compute_DistanceTransform_EventTypes EventType; // 0x10
		public float ProgressPercentage; // 0x14
		public UnityEngine.Color[] Colors; // 0x18
	
		// Constructors
		public Compute_DT_EventArgs() {} // Dummy constructor
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress) {} // 0x0000000185FE5880-0x0000000185FE5890
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, UnityEngine.Color[] colors) {} // 0x000000018646E950-0x000000018646E960
	}

	public static class TMPro_ExtensionMethods // TypeDefIndex: 53099
	{
		// Methods
		public static int[] ToIntArray(string text) => default; // 0x000000018BE157D8-0x000000018BE15868
		public static string ArrayToString(char[] chars) => default; // 0x000000018BE15228-0x000000018BE152EC
		public static string IntToString(int[] unicodes) => default; // 0x000000018BE1549C-0x000000018BE1551C
		internal static string UintToString(List<uint> unicodes) => default; // 0x000000018BE15868-0x000000018BE15918
		public static string IntToString(int[] unicodes, int start, int length) => default; // 0x000000018BE1551C-0x000000018BE155F0
		public static int FindInstanceID<T>(List<T> list, T target)
			where T : UnityEngine.Object => default;
		public static bool Compare(Color32 a, Color32 b) => default; // 0x000000018BE15310-0x000000018BE15348
		public static bool CompareRGB(Color32 a, Color32 b) => default; // 0x000000018BE152EC-0x000000018BE15310
		public static bool Compare(UnityEngine.Color a, UnityEngine.Color b) => default; // 0x0000000184A6EB60-0x0000000184A6EBA0
		public static bool CompareRGB(UnityEngine.Color a, UnityEngine.Color b) => default; // 0x00000001843884A0-0x00000001843884D0
		public static Color32 Multiply(Color32 c1, Color32 c2) => default; // 0x000000018BE15618-0x000000018BE156F8
		public static Color32 Tint(Color32 c1, Color32 c2) => default; // 0x000000018BE15618-0x000000018BE156F8
		public static Color32 Tint(Color32 c1, float tint) => default; // 0x000000018BE156F8-0x000000018BE157D8
		public static UnityEngine.Color MinAlpha(UnityEngine.Color c1, UnityEngine.Color c2) => default; // 0x000000018BE155F0-0x000000018BE15618
		public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) => default; // 0x000000018BE1540C-0x000000018BE1549C
		public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) => default; // 0x000000018BE15348-0x000000018BE1540C
	}

	public static class TMP_Math // TypeDefIndex: 53100
	{
		// Fields
		public const float FLOAT_MAX = 32767f; // Metadata: 0x02077A9A
		public const float FLOAT_MIN = -32767f; // Metadata: 0x02077A9E
		public const int INT_MAX = 2147483647; // Metadata: 0x02077AA2
		public const int INT_MIN = -2147483647; // Metadata: 0x02077AA3
		public const float FLOAT_UNSET = -32767f; // Metadata: 0x02077AA8
		public const int INT_UNSET = -32767; // Metadata: 0x02077AAC
		public static Vector2 MAX_16BIT; // 0x00
		public static Vector2 MIN_16BIT; // 0x08
	
		// Constructors
		static TMP_Math() {} // 0x000000018BE14980-0x000000018BE149DC
	
		// Methods
		public static bool Approximately(float a, float b) => default; // 0x000000018BE14944-0x000000018BE14968
		public static int Mod(int a, int b) => default; // 0x000000018BE14968-0x000000018BE14980
	}

	public enum TMP_VertexDataUpdateFlags // TypeDefIndex: 53101
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
	public struct VertexGradient // TypeDefIndex: 53102
	{
		// Fields
		public UnityEngine.Color topLeft; // 0x00
		public UnityEngine.Color topRight; // 0x10
		public UnityEngine.Color bottomLeft; // 0x20
		public UnityEngine.Color bottomRight; // 0x30
	
		// Constructors
		public VertexGradient(UnityEngine.Color color) {
			topLeft = default;
			topRight = default;
			bottomLeft = default;
			bottomRight = default;
		} // 0x0000000185FE5A40-0x0000000185FE5A60
		public VertexGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3) {
			topLeft = default;
			topRight = default;
			bottomLeft = default;
			bottomRight = default;
		} // 0x0000000185FDF130-0x0000000185FDF160
	}

	public struct TMP_PageInfo // TypeDefIndex: 53103
	{
		// Fields
		public int firstCharacterIndex; // 0x00
		public int lastCharacterIndex; // 0x04
		public float ascender; // 0x08
		public float baseLine; // 0x0C
		public float descender; // 0x10
	}

	public struct TMP_LinkInfo // TypeDefIndex: 53104
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
		internal void SetLinkID(char[] text, int startIndex, int length) {} // 0x000000018BE14880-0x000000018BE14944
		public string GetLinkText() => default; // 0x000000018BE147A0-0x000000018BE14880
		public string GetLinkID() => default; // 0x000000018BE14714-0x000000018BE147A0
	}

	public struct TMP_WordInfo // TypeDefIndex: 53105
	{
		// Fields
		public TMP_Text textComponent; // 0x00
		public int firstCharacterIndex; // 0x08
		public int lastCharacterIndex; // 0x0C
		public int characterCount; // 0x10
	
		// Methods
		public string GetWord() => default; // 0x000000018BE14C30-0x000000018BE14D14
	}

	public struct TMP_SpriteInfo // TypeDefIndex: 53106
	{
		// Fields
		public int spriteIndex; // 0x00
		public int characterIndex; // 0x04
		public int vertexIndex; // 0x08
	}

	public struct Extents // TypeDefIndex: 53107
	{
		// Fields
		internal static Extents zero; // 0x00
		internal static Extents uninitialized; // 0x10
		public Vector2 min; // 0x00
		public Vector2 max; // 0x08
	
		// Constructors
		public Extents(Vector2 min, Vector2 max) {
			this.min = default;
			this.max = default;
		} // 0x0000000183680100-0x0000000183680110
		static Extents() {
			zero = default;
			uninitialized = default;
		} // 0x000000018BE086DC-0x000000018BE08734
	
		// Methods
		public override string ToString() => default; // 0x000000018BE08558-0x000000018BE086DC
	}

	[Serializable]
	public struct Mesh_Extents // TypeDefIndex: 53108
	{
		// Fields
		public Vector2 min; // 0x00
		public Vector2 max; // 0x08
	
		// Constructors
		public Mesh_Extents(Vector2 min, Vector2 max) {
			this.min = default;
			this.max = default;
		} // 0x0000000183680100-0x0000000183680110
	
		// Methods
		public override string ToString() => default; // 0x000000018BE09314-0x000000018BE09498
	}

	public struct WordWrapState // TypeDefIndex: 53109
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

	public struct TagAttribute // TypeDefIndex: 53110
	{
		// Fields
		public int startIndex; // 0x00
		public int length; // 0x04
		public int hashCode; // 0x08
	}

	public struct RichTextTagAttribute // TypeDefIndex: 53111
	{
		// Fields
		public int nameHashCode; // 0x00
		public int valueHashCode; // 0x04
		public TagValueType valueType; // 0x08
		public int valueStartIndex; // 0x0C
		public int valueLength; // 0x10
		public TagUnitType unitType; // 0x14
	}

	internal class TMP_ArrayObjectPool<T> // TypeDefIndex: 53113
	{
		// Fields
		private readonly Dictionary<int, Stack<T[]>> m_StackDic;
		private readonly UnityAction<T[]> m_ActionOnGet;
		private readonly UnityAction<T[]> m_ActionOnRelease;
		private readonly PoolOptions m_Options;
		private int m_TotalCachedCount;
		private int _countAll_k__BackingField;
	
		// Properties
		public int countAll { get; private set; }
		public int countActive { get => default; }
		public int countInactive { get => default; }
	
		// Nested types
		internal struct PoolOptions // TypeDefIndex: 53112
		{
			// Fields
			public static readonly PoolOptions<T> Default;
			public readonly bool restrictArraySize;
			public readonly IReadOnlyList<int> allowedSizes;
			public readonly int maxTotalCachedCount;
	
			// Constructors
			public PoolOptions(bool restrictArraySize, IReadOnlyList<int> allowedSizes, int maxTotalCachedCount) {
				this.restrictArraySize = default;
				this.allowedSizes = default;
				this.maxTotalCachedCount = default;
			}
			static PoolOptions() {
				Default = default;
			}
		}
	
		// Constructors
		public TMP_ArrayObjectPool() {} // Dummy constructor
		public TMP_ArrayObjectPool(UnityAction<T[]> actionOnGet, UnityAction<T[]> actionOnRelease, PoolOptions options = default) {}
	
		// Methods
		public T[] Get(int count) => default;
		public void Release(int count, T[] element) {}
		public void Shrink() {}
		private bool _CanUsePool(int count) => default;
	}

	internal static class TMP_ArrayPool<T> // TypeDefIndex: 53115
	{
		// Fields
		private static readonly TMP_ArrayObjectPool<T> s_ArrayPool;
		private static readonly TMP_ArrayPoolWrapper<T> s_ArrayPoolWrapper;
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53114
		{
			// Fields
			public static readonly __c<T> __9;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal void _.cctor_b__2_0(T[] arr) {}
		}
	
		// Constructors
		static TMP_ArrayPool() {}
	
		// Methods
		private static TMP_ArrayObjectPool<T> _CreateOptions() => default;
		public static T[] Get(int count) => default;
		public static void Release(T[] toRelease) {}
		public static void Resize(ref ref T[] array, int newCount) {}
		public static void Shrink() {}
	}

	public interface IPoolClearable // TypeDefIndex: 53116
	{
		// Methods
		void Clear();
	}

	internal interface ITMPArrayPoolRegistryItem // TypeDefIndex: 53117
	{
		// Methods
		void Shrink();
	}

	public static class TMP_ArrayPoolRegistry // TypeDefIndex: 53118
	{
		// Fields
		private static readonly List<ITMPArrayPoolRegistryItem> registeredPools; // 0x00
	
		// Constructors
		static TMP_ArrayPoolRegistry() {} // 0x0000000183F795C0-0x0000000183F79E80
	
		// Methods
		internal static void Register(ITMPArrayPoolRegistryItem pool) {} // 0x0000000183F78410-0x0000000183F78CE0
		public static void ShrinkAll() {} // 0x0000000183F78CE0-0x0000000183F795C0
	}

	internal class TMP_ArrayPoolWrapper<T> : ITMPArrayPoolRegistryItem // TypeDefIndex: 53119
	{
		// Constructors
		public TMP_ArrayPoolWrapper() {}
	
		// Methods
		public void Shrink() {}
	}

	[Serializable]
	public abstract class TMP_Asset : ScriptableObject // TypeDefIndex: 53120
	{
		// Fields
		private int m_InstanceID; // 0x18
		public int hashCode; // 0x1C
		public Material material; // 0x20
		public int materialHashCode; // 0x28
	
		// Properties
		public int instanceID { get; } // 0x00000001842B3EF0-0x00000001842B3F20 
	
		// Constructors
		protected TMP_Asset() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	}

	[Serializable]
	public class TMP_Character : TMP_TextElement // TypeDefIndex: 53121
	{
		// Constructors
		public TMP_Character() {} // 0x0000000185FE5930-0x0000000185FE5940
		public TMP_Character(uint unicode, Glyph glyph) {} // 0x000000018BE09550-0x000000018BE0959C
		public TMP_Character(uint unicode, TMP_FontAsset fontAsset, Glyph glyph) {} // 0x0000000184012AA0-0x0000000184012AF0
		internal TMP_Character(uint unicode, uint glyphIndex) {} // 0x000000018BE09510-0x000000018BE09550
	}

	public struct TMP_Vertex // TypeDefIndex: 53122
	{
		// Fields
		public Vector3 position; // 0x00
		public Vector2 uv; // 0x0C
		public Vector2 uv2; // 0x14
		public Vector2 uv4; // 0x1C
		public Color32 color; // 0x24
		private static readonly TMP_Vertex k_Zero; // 0x00
	
		// Properties
		public static TMP_Vertex zero { get => default; } // 0x000000018BE14BD0-0x000000018BE14C30 
	
		// Constructors
		static TMP_Vertex() {
			k_Zero = default;
		} // 0x0000000185492010-0x0000000185492020
	}

	public struct TMP_Offset // TypeDefIndex: 53123
	{
		// Fields
		private float m_Left; // 0x00
		private float m_Right; // 0x04
		private float m_Top; // 0x08
		private float m_Bottom; // 0x0C
		private static readonly TMP_Offset k_ZeroOffset; // 0x00
	
		// Properties
		public float left { get => default; set {} } // 0x0000000185FB0F90-0x0000000185FB0FA0 0x0000000185FBA160-0x0000000185FBA170
		public float right { get => default; set {} } // 0x0000000185FBA150-0x0000000185FBA160 0x0000000185FBA180-0x0000000185FBA190
		public float top { get => default; set {} } // 0x0000000185FBA140-0x0000000185FBA150 0x0000000185FBA170-0x0000000185FBA180
		public float bottom { get => default; set {} } // 0x0000000185FBF760-0x0000000185FBF770 0x0000000185FBF770-0x0000000185FBF780
		public float horizontal { get => default; set {} } // 0x0000000185FB0F90-0x0000000185FB0FA0 0x0000000185FE0550-0x0000000185FE0560
		public float vertical { get => default; set {} } // 0x0000000185FBA140-0x0000000185FBA150 0x0000000185FE5A30-0x0000000185FE5A40
		public static TMP_Offset zero { get => default; } // 0x000000018BE14B08-0x000000018BE14B64 
	
		// Constructors
		public TMP_Offset(float left, float right, float top, float bottom) : this() {
			m_Left = default;
			m_Right = default;
			m_Top = default;
			m_Bottom = default;
		} // 0x0000000185FB2B40-0x0000000185FB2B60
		public TMP_Offset(float horizontal, float vertical) : this() {
			m_Left = default;
			m_Right = default;
			m_Top = default;
			m_Bottom = default;
		} // 0x0000000185FE5A10-0x0000000185FE5A30
		static TMP_Offset() {
			k_ZeroOffset = default;
		} // 0x0000000185F9B5F0-0x0000000185F9B630
	
		// Methods
		public static bool operator ==(TMP_Offset lhs, TMP_Offset rhs) => default; // 0x0000000184A6EB60-0x0000000184A6EBA0
		public static bool operator !=(TMP_Offset lhs, TMP_Offset rhs) => default; // 0x000000018BE14B64-0x000000018BE14BD0
		public static TMP_Offset operator *(TMP_Offset a, float b) => default; // 0x00000001840DD310-0x00000001840DD330
		public override int GetHashCode() => default; // 0x000000018BE14AB8-0x000000018BE14B08
		public override bool Equals(object obj) => default; // 0x000000018BE14A58-0x000000018BE14AB8
		public bool Equals(TMP_Offset other) => default; // 0x000000018BE149DC-0x000000018BE14A58
	}

	public struct HighlightState // TypeDefIndex: 53124
	{
		// Fields
		public Color32 color; // 0x00
		public TMP_Offset padding; // 0x04
	
		// Constructors
		public HighlightState(Color32 color, TMP_Offset padding) {
			this.color = default;
			this.padding = default;
		} // 0x0000000185FC8390-0x0000000185FC83A0
	
		// Methods
		public static bool operator ==(HighlightState lhs, HighlightState rhs) => default; // 0x000000018BE08AB8-0x000000018BE08B7C
		public static bool operator !=(HighlightState lhs, HighlightState rhs) => default; // 0x000000018BE08B7C-0x000000018BE08BB8
		public override int GetHashCode() => default; // 0x000000018BE08A64-0x000000018BE08AB8
		public override bool Equals(object obj) => default; // 0x000000018BE08978-0x000000018BE089DC
		public bool Equals(HighlightState other) => default; // 0x000000018BE089DC-0x000000018BE08A64
	}

	public struct TMP_CharacterInfo : IPoolClearable // TypeDefIndex: 53125
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
		public void Clear() {} // 0x0000000184244BA0-0x0000000184244BF0
	}

	public enum ColorMode // TypeDefIndex: 53126
	{
		Single = 0,
		HorizontalGradient = 1,
		VerticalGradient = 2,
		FourCornersGradient = 3
	}

	[Serializable]
	public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 53127
	{
		// Fields
		public ColorMode colorMode; // 0x18
		public UnityEngine.Color topLeft; // 0x1C
		public UnityEngine.Color topRight; // 0x2C
		public UnityEngine.Color bottomLeft; // 0x3C
		public UnityEngine.Color bottomRight; // 0x4C
		private const ColorMode k_DefaultColorMode = ColorMode.FourCornersGradient; // Metadata: 0x02077ABC
		private static readonly UnityEngine.Color k_DefaultColor; // 0x00
	
		// Constructors
		public TMP_ColorGradient() {} // 0x000000018BE095E0-0x000000018BE0968C
		public TMP_ColorGradient(UnityEngine.Color color) {} // 0x000000018BE0968C-0x000000018BE096D0
		public TMP_ColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3) {} // 0x000000018BE096D0-0x000000018BE09740
		static TMP_ColorGradient() {} // 0x000000018BE0959C-0x000000018BE095E0
	}

	public static class TMP_Compatibility // TypeDefIndex: 53129
	{
		// Nested types
		public enum AnchorPositions // TypeDefIndex: 53128
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
		public static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue) => default; // 0x000000018BE09740-0x000000018BE0985C
	}

	internal interface ITweenValue // TypeDefIndex: 53130
	{
		// Properties
		bool ignoreTimeScale { get; }
		float duration { get; }
	
		// Methods
		void TweenValue(float floatPercentage);
		bool ValidTarget();
	}

	internal struct ColorTween : ITweenValue // TypeDefIndex: 53133
	{
		// Fields
		private ColorTweenCallback m_Target; // 0x00
		private UnityEngine.Color m_StartColor; // 0x08
		private UnityEngine.Color m_TargetColor; // 0x18
		private ColorTweenMode m_TweenMode; // 0x28
		private float m_Duration; // 0x2C
		private bool m_IgnoreTimeScale; // 0x30
	
		// Properties
		public UnityEngine.Color startColor { get => default; set {} } // 0x0000000185FD13F0-0x0000000185FD1400 0x0000000185FB30D0-0x0000000185FB30E0
		public UnityEngine.Color targetColor { get => default; set {} } // 0x0000000185FB30E0-0x0000000185FB30F0 0x0000000181C9AC80-0x0000000181C9AC90
		public ColorTweenMode tweenMode { get => default; set {} } // 0x0000000181C9A5C0-0x0000000181C9A5D0 0x0000000185FB09A0-0x0000000185FB09B0
		public float duration { get => default; set {} } // 0x0000000185FB09B0-0x0000000185FB09C0 0x00000001814294C0-0x00000001814294D0
		public bool ignoreTimeScale { get => default; set {} } // 0x000000018142A360-0x000000018142A370 0x000000018BE08360-0x000000018BE08438
	
		// Nested types
		public enum ColorTweenMode // TypeDefIndex: 53131
		{
			All = 0,
			RGB = 1,
			Alpha = 2
		}
	
		public class ColorTweenCallback : UnityEvent<UnityEngine.Color> // TypeDefIndex: 53132
		{
			// Constructors
			public ColorTweenCallback() {} // 0x0000000183577F20-0x0000000183577F30
		}
	
		// Methods
		public void TweenValue(float floatPercentage) {} // 0x000000018BE082C8-0x000000018BE08360
		public void AddOnChangedCallback(UnityAction<UnityEngine.Color> callback) {} // 0x00000001814294C0-0x00000001814294D0
		public bool GetIgnoreTimescale() => default; // 0x0000000185FB09A0-0x0000000185FB09B0
		public float GetDuration() => default; // 0x0000000183FB53F0-0x0000000183FB5400
		public bool ValidTarget() => default; // 0x000000018BE0828C-0x000000018BE082C8
	}

	internal struct FloatTween : ITweenValue // TypeDefIndex: 53135
	{
		// Fields
		private FloatTweenCallback m_Target; // 0x00
		private float m_StartValue; // 0x08
		private float m_TargetValue; // 0x0C
		private float m_Duration; // 0x10
		private bool m_IgnoreTimeScale; // 0x14
	
		// Properties
		public float startValue { get => default; set {} } // 0x0000000185FBA170-0x0000000185FBA180 0x0000000185FBF760-0x0000000185FBF770
		public float targetValue { get => default; set {} } // 0x0000000185FBF770-0x0000000185FBF780 0x0000000181DCCCE0-0x0000000181DCCCF0
		public float duration { get => default; set {} } // 0x0000000181A6E380-0x0000000181A6E390 0x0000000185FBA190-0x0000000185FBA1A0
		public bool ignoreTimeScale { get => default; set {} } // 0x0000000185FBA1B0-0x0000000185FBA1C0 0x000000018BE08808-0x000000018BE0886C
	
		// Nested types
		public class FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 53134
		{
			// Constructors
			public FloatTweenCallback() {} // 0x0000000185FBA140-0x0000000185FBA150
		}
	
		// Methods
		public void TweenValue(float floatPercentage) {} // 0x000000018BE08770-0x000000018BE08808
		public void AddOnChangedCallback(UnityAction<float> callback) {} // 0x0000000185FBA190-0x0000000185FBA1A0
		public bool GetIgnoreTimescale() => default; // 0x0000000181DCCCE0-0x0000000181DCCCF0
		public float GetDuration() => default; // 0x0000000183FB53F0-0x0000000183FB5400
		public bool ValidTarget() => default; // 0x000000018BE08734-0x000000018BE08770
	}

	internal class TweenRunner<T> // TypeDefIndex: 53137
		where T : struct, ITweenValue
	{
		// Fields
		protected MonoBehaviour m_CoroutineContainer;
		protected IEnumerator m_Tween;
	
		// Nested types
		private sealed class _Start_d__2 : IEnumerator<object> // TypeDefIndex: 53136
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public T tweenInfo;
			private float _elapsedTime_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _Start_d__2() {} // Dummy constructor
			public _Start_d__2(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		public TweenRunner() {}
	
		// Methods
		private static IEnumerator Start(T tweenInfo) => default;
		public void Init(MonoBehaviour coroutineContainer) {}
		public void StartTween(T info) {}
		public void StopTween() {}
	}

	public static class TMP_DefaultControls // TypeDefIndex: 53139
	{
		// Fields
		private const float kWidth = 160f; // Metadata: 0x02077ACB
		private const float kThickHeight = 30f; // Metadata: 0x02077ACF
		private const float kThinHeight = 20f; // Metadata: 0x02077AD3
		private static Vector2 s_TextElementSize; // 0x00
		private static Vector2 s_ThickElementSize; // 0x08
		private static Vector2 s_ThinElementSize; // 0x10
		private static UnityEngine.Color s_DefaultSelectableColor; // 0x18
		private static UnityEngine.Color s_TextColor; // 0x28
	
		// Nested types
		public struct Resources // TypeDefIndex: 53138
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
		static TMP_DefaultControls() {} // 0x000000018BE0B54C-0x000000018BE0B5F4
	
		// Methods
		private static GameObject CreateUIElementRoot(string name, Vector2 size) => default; // 0x000000018BE0B1A0-0x000000018BE0B240
		private static GameObject CreateUIObject(string name, GameObject parent) => default; // 0x000000018BE0B240-0x000000018BE0B2F0
		private static void SetDefaultTextValues(TMP_Text lbl) {} // 0x000000018BE0B340-0x000000018BE0B3C0
		private static void SetDefaultColorTransitionValues(Selectable slider) {} // 0x000000018BE0B2F0-0x000000018BE0B340
		private static void SetParentAndAlign(GameObject child, GameObject parent) {} // 0x000000018BE0B480-0x000000018BE0B54C
		private static void SetLayerRecursively(GameObject go, int layer) {} // 0x000000018BE0B3C0-0x000000018BE0B480
		public static GameObject CreateScrollbar(Resources resources) => default; // 0x000000018BE0AE28-0x000000018BE0B104
		public static GameObject CreateButton(Resources resources) => default; // 0x000000018BE0985C-0x000000018BE09AD8
		public static GameObject CreateText(Resources resources) => default; // 0x000000018BE0B104-0x000000018BE0B1A0
		public static GameObject CreateInputField(Resources resources) => default; // 0x000000018BE0A880-0x000000018BE0AE28
		public static GameObject CreateDropdown(Resources resources) => default; // 0x000000018BE09AD8-0x000000018BE0A880
	}

	public class TMP_Dropdown : Selectable, IPointerClickHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 53146
	{
		// Fields
		private RectTransform m_Template; // 0x180
		private TMP_Text m_CaptionText; // 0x188
		private Image m_CaptionImage; // 0x190
		private Graphic m_Placeholder; // 0x198
		private TMP_Text m_ItemText; // 0x1A0
		private Image m_ItemImage; // 0x1A8
		private int m_Value; // 0x1B0
		private OptionDataList m_Options; // 0x1B8
		private DropdownEvent m_OnValueChanged; // 0x1C0
		private float m_AlphaFadeSpeed; // 0x1C8
		private GameObject m_Dropdown; // 0x1D0
		private GameObject m_Blocker; // 0x1D8
		private List<DropdownItem> m_Items; // 0x1E0
		private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x1E8
		private bool validTemplate; // 0x1F0
		private Coroutine m_Coroutine; // 0x1F8
		private static OptionData s_NoOptionData; // 0x00
	
		// Properties
		public RectTransform template { get => default; set {} } // 0x000000018BE0BDB8-0x000000018BE0BE50 0x000000018BE0CCA0-0x000000018BE0D2A4
		public TMP_Text captionText { get => default; set {} } // 0x000000018BE0C748-0x000000018BE0C750
		public Image captionImage { get => default; set {} } // 0x000000018BE0C748-0x000000018BE0C750 0x000000018BE0C6AC-0x000000018BE0C6B4
		public Graphic placeholder { get => default; set {} } // 0x000000018BE0D2A4-0x000000018BE0E07C 0x000000018BE0BE50-0x000000018BE0C284
		public TMP_Text itemText { get => default; set {} } // 0x000000018BE0C398-0x000000018BE0C3E4 0x000000018BE0C284-0x000000018BE0C2D8
		public Image itemImage { get => default; set {} } // 0x000000018BE0C3E4-0x000000018BE0C430 0x000000018BE0C2D8-0x000000018BE0C32C
		public List<OptionData> options { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x000000018BE0B5F4-0x000000018BE0B880
		public DropdownEvent onValueChanged { get => default; set {} } // 0x000000018BE0BC44-0x000000018BE0BCD0 0x000000018BE0BAC8-0x000000018BE0BC44
		public float alphaFadeSpeed { get => default; set {} } // 0x000000018BE0CABC-0x000000018BE0CB5C 0x000000018BE0C430-0x000000018BE0C548
		public int value { get => default; set {} } // 0x000000018BE0C32C-0x000000018BE0C398 0x000000018BE0C548-0x000000018BE0C6AC
		public bool IsExpanded { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Nested types
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, ICancelHandler // TypeDefIndex: 53140
		{
			// Fields
			private TMP_Text m_Text; // 0x18
			private Image m_Image; // 0x20
			private RectTransform m_RectTransform; // 0x28
			private Toggle m_Toggle; // 0x30
	
			// Properties
			public TMP_Text text { get => default; set {} } // 0x0000000185FB8280-0x0000000185FB8290 0x000000018BE0E414-0x000000018BE0E43C
			public Image image { get => default; set {} } // 0x0000000185FB8360-0x0000000185FB8370 0x000000018BE0E340-0x000000018BE0E368
			public RectTransform rectTransform { get => default; set {} } // 0x0000000181B44930-0x0000000181B44940 0x000000018BE0E318-0x000000018BE0E340
			public Toggle toggle { get => default; set {} } // 0x0000000185FB88A0-0x0000000185FB88B0 0x000000018BE0E3EC-0x000000018BE0E414
	
			// Constructors
			public DropdownItem() {} // 0x0000000185FB82E0-0x0000000185FB82F0
	
			// Methods
			public virtual void OnPointerEnter(PointerEventData eventData) {} // 0x0000000185FB82F0-0x0000000185FB8300
			public virtual void OnCancel(BaseEventData eventData) {} // 0x000000018BE0E390-0x000000018BE0E3B8
		}
	
		[Serializable]
		public class OptionData // TypeDefIndex: 53141
		{
			// Fields
			private string m_Text; // 0x10
			private Sprite m_Image; // 0x18
	
			// Properties
			public string text { get => default; set {} } // 0x000000018BE0E368-0x000000018BE0E390 0x000000018BE0E2F8-0x000000018BE0E318
			public Sprite image { get => default; set {} } // 0x000000018BE0E3B8-0x000000018BE0E3EC 0x0000000185FB7F50-0x0000000185FB7F60
	
			// Constructors
			public OptionData() {} // 0x0000000186473554-0x0000000186473568
			public OptionData(string text) {} // 0x0000000185FB9D00-0x0000000185FB9D10
			public OptionData(Sprite image) {} // 0x0000000185FB9E10-0x0000000185FB9E20
			public OptionData(string text, Sprite image) {} // 0x0000000185FB9BD0-0x0000000185FB9BE0
		}
	
		[Serializable]
		public class OptionDataList // TypeDefIndex: 53142
		{
			// Fields
			private List<OptionData> m_Options; // 0x10
	
			// Properties
			public List<OptionData> options { get => default; set {} } // 0x000000018BE0E43C-0x000000018BE0E448 0x000000018BE0CB5C-0x000000018BE0CB68
	
			// Constructors
			public OptionDataList() {} // 0x000000018BE0CB68-0x000000018BE0CCA0
		}
	
		[Serializable]
		public class DropdownEvent : UnityEvent<int> // TypeDefIndex: 53143
		{
			// Constructors
			public DropdownEvent() {} // 0x000000018BE0E2A4-0x000000018BE0E2F8
		}
	
		private sealed class __c__DisplayClass69_0 // TypeDefIndex: 53144
		{
			// Fields
			public DropdownItem item; // 0x10
			public TMP_Dropdown __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass69_0() {} // 0x000000018BE0E17C-0x000000018BE0E2A4
	
			// Methods
			internal void _Show_b__0(bool x) {} // 0x000000018BE0BCD0-0x000000018BE0BDB8
		}
	
		private sealed class _DelayedDestroyDropdownList_d__81 : IEnumerator<object> // TypeDefIndex: 53145
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float delay; // 0x20
			public TMP_Dropdown __4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018BE0B880-0x000000018BE0B8E8 
			object IEnumerator.Current { get => default; } // 0x000000018BE0B9D8-0x000000018BE0BAC8 
	
			// Constructors
			public _DelayedDestroyDropdownList_d__81() {} // Dummy constructor
			public _DelayedDestroyDropdownList_d__81(int __1__state) {} // 0x000000018BE0E07C-0x000000018BE0E10C
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BE0C6B4-0x000000018BE0C748
			private bool MoveNext() => default; // 0x000000018BE0C858-0x000000018BE0CABC
			void IEnumerator.Reset() {} // 0x000000018BE0B8E8-0x000000018BE0B9D8
		}
	
		// Constructors
		protected TMP_Dropdown() {} // 0x0000000184088E70-0x0000000184088E80
		static TMP_Dropdown() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public void SetValueWithoutNotify(int input) {} // 0x000000018BE0C750-0x000000018BE0C858
		private void SetValue(int value, bool sendCallback = true /* Metadata: 0x02077AD7 */) {} // 0x000000018BE0E10C-0x000000018BE0E17C
		protected override void Awake() {} // 0x00000001813B31A0-0x00000001813B31B0
		protected override void Start() {} // 0x000000018646EE40-0x000000018646EE50
		protected override void OnDisable() {} // 0x00000001813B8590-0x00000001813B85A0
		public void RefreshShownValue() {} // 0x0000000184A4EDC0-0x0000000184A4EDD0
		public void AddOptions(List<OptionData> options) {} // 0x00000001813B51D0-0x00000001813B51E0
		public void AddOptions(List<string> options) {} // 0x00000001864721F0-0x0000000186472200
		public void AddOptions(List<Sprite> options) {} // 0x000000018BE084EC-0x000000018BE08558
		public void ClearOptions() {} // 0x000000018BE08474-0x000000018BE084EC
		private void SetupTemplate() {} // 0x000000018646DB20-0x000000018646DB28
		private static T GetOrAddComponent<T>(GameObject go)
			where T : Component => default; // 0x000000018346D130-0x000000018346D140
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x0000000184096E30-0x0000000184096EF0
		public virtual void OnSubmit(BaseEventData eventData) {} // 0x0000000181377E40-0x0000000181377E50
		public virtual void OnCancel(BaseEventData eventData) {} // 0x0000000184088E70-0x0000000184088E80
		public void Show() {} // 0x0000000185492010-0x0000000185492020
		protected virtual GameObject CreateBlocker(Canvas rootCanvas) => default; // 0x0000000184096E30-0x0000000184096EF0
		protected virtual void DestroyBlocker(GameObject blocker) {} // 0x0000000184088E70-0x0000000184088E80
		protected virtual GameObject CreateDropdownList(GameObject template) => default; // 0x00000001841BC230-0x00000001841BC260
		protected virtual void DestroyDropdownList(GameObject dropdownList) {} // 0x000000018346D130-0x000000018346D140
		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate) => default; // 0x0000000184096E30-0x0000000184096EF0
		protected virtual void DestroyItem(DropdownItem item) {} // 0x000000018BE09498-0x000000018BE09510
		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items) => default; // 0x000000018BE08438-0x000000018BE08474
		private void AlphaFadeList(float duration, float alpha) {} // 0x0000000185492010-0x0000000185492020
		private void AlphaFadeList(float duration, float start, float end) {} // 0x000000018BE15B90-0x000000018BE15BC0
		private void SetAlpha(float alpha) {} // 0x0000000181378230-0x0000000181378240
		public void Hide() {} // 0x0000000185492010-0x0000000185492020
		private IEnumerator DelayedDestroyDropdownList(float delay) => default; // 0x000000018BE15918-0x000000018BE159B4
		private void ImmediateDestroyDropdownList() {} // 0x0000000181377E40-0x0000000181377E50
		private void OnSelectItem(Toggle toggle) {} // 0x000000018BE159B4-0x000000018BE15A00
	}

	public enum AtlasPopulationMode // TypeDefIndex: 53147
	{
		Static = 0,
		Dynamic = 1
	}

	[Serializable]
	public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 53149
	{
		// Fields
		private string m_Version; // 0x30
		internal string m_SourceFontFileGUID; // 0x38
		private Font m_SourceFontFile; // 0x40
		private float m_ThaiBiasConsonantsValue; // 0x48
		private string m_prefixMaterialSearchPatternValue; // 0x50
		private AtlasPopulationMode m_AtlasPopulationMode; // 0x58
		public FaceInfo m_FaceInfo; // 0x60
		internal List<Glyph> m_GlyphTable; // 0xC0
		internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0xC8
		internal List<TMP_Character> m_CharacterTable; // 0xD0
		public Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0xD8
		internal Texture2D m_AtlasTexture; // 0xE0
		internal Texture2D[] m_AtlasTextures; // 0xE8
		internal int m_AtlasTextureIndex; // 0xF0
		private bool m_IsMultiAtlasTexturesEnabled; // 0xF4
		private bool m_ClearDynamicDataOnBuild; // 0xF5
		private List<GlyphRect> m_UsedGlyphRects; // 0xF8
		private List<GlyphRect> m_FreeGlyphRects; // 0x100
		private FaceInfo_Legacy m_fontInfo; // 0x108
		public Texture2D atlas; // 0x110
		internal int m_AtlasWidth; // 0x118
		internal int m_AtlasHeight; // 0x11C
		internal int m_AtlasPadding; // 0x120
		internal GlyphRenderMode m_AtlasRenderMode; // 0x124
		internal List<TMP_Glyph> m_glyphInfoList; // 0x128
		internal KerningTable m_KerningTable; // 0x130
		public TMP_FontFeatureTable m_FontFeatureTable; // 0x138
		private List<TMP_FontAsset> fallbackFontAssets; // 0x140
		internal List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x148
		internal FontAssetCreationSettings m_CreationSettings; // 0x150
		private TMP_FontWeightPair[] m_FontWeightTable; // 0x1A8
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
		public string version { get => default; internal set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public Font sourceFontFile { get => default; internal set {} } // 0x0000000181460F60-0x0000000181460F70 0x0000000184A4E570-0x0000000184A4E580
		public float thaiBiasConsonantsValue { get => default; set {} } // 0x0000000183F80450-0x0000000183F80460 0x0000000183F804E0-0x0000000183F804F0
		public string prefixMaterialSearchPatternValue { get => default; set {} } // 0x0000000185FE59A0-0x0000000185FE59E0 0x000000018BE14220-0x000000018BE14264
		public AtlasPopulationMode atlasPopulationMode { get => default; set {} } // 0x0000000181B388F0-0x0000000181B38900 0x0000000187A47C1C-0x0000000187A47C30
		public FaceInfo faceInfo { get => default; set {} } // 0x000000018BE141A0-0x000000018BE141D0 0x0000000185FB15A0-0x0000000185FB15B0
		public List<Glyph> glyphTable { get => default; internal set {} } // 0x000000018774BD78-0x000000018774BD8C 0x00000001842B1910-0x00000001842B1950
		public Dictionary<uint, Glyph> glyphLookupTable { get => default; } // 0x0000000184246260-0x00000001842463B0 
		public List<TMP_Character> characterTable { get => default; internal set {} } // 0x0000000185FB2360-0x0000000185FB2370 0x0000000187A47730-0x0000000187A47744
		public Dictionary<uint, TMP_Character> characterLookupTable { get => default; } // 0x0000000185FE5940-0x0000000185FE5950 
		public Texture2D atlasTexture { get => default; } // 0x0000000185FB9640-0x0000000185FB9650 
		public Texture2D[] atlasTextures { get => default; set {} } // 0x0000000185FB96A0-0x0000000185FB96B0 0x0000000185FD3770-0x0000000185FD3780
		public int atlasTextureCount { get => default; } // 0x0000000185FD3780-0x0000000185FD3790 
		public bool isMultiAtlasTexturesEnabled { get => default; set {} } // 0x0000000185FB16B0-0x0000000185FB16C0 0x000000018774E878-0x000000018774E88C
		internal bool clearDynamicDataOnBuild { get => default; set {} } // 0x0000000185FB1CB0-0x0000000185FB1CC0 0x0000000187764794-0x00000001877647A8
		internal List<GlyphRect> usedGlyphRects { get => default; set {} } // 0x0000000181ABEDF0-0x0000000181ABEE00 0x0000000185FB1F40-0x0000000185FB1F50
		internal List<GlyphRect> freeGlyphRects { get => default; set {} } // 0x0000000185FB1F50-0x0000000185FB1F60 0x0000000185FBC8D0-0x0000000185FBC8E0
		public FaceInfo_Legacy fontInfo { get => default; } // 0x0000000185FBC8E0-0x0000000185FBC8F0 
		public int atlasWidth { get => default; internal set {} } // 0x0000000185FBED30-0x0000000185FBED40 0x0000000185FE59E0-0x0000000185FE59F0
		public int atlasHeight { get => default; internal set {} } // 0x0000000185FCEAF0-0x0000000185FCEB00 0x0000000185FD4F30-0x0000000185FD4F40
		public int atlasPadding { get => default; internal set {} } // 0x0000000185FB8720-0x0000000185FB8730 0x00000001864735CC-0x00000001864735E0
		public GlyphRenderMode atlasRenderMode { get => default; internal set {} } // 0x0000000185FB8610-0x0000000185FB8620 0x0000000187A47780-0x0000000187A47794
		public TMP_FontFeatureTable fontFeatureTable { get => default; internal set {} } // 0x0000000185FE5950-0x0000000185FE59A0 0x000000018BE141D0-0x000000018BE14220
		public List<TMP_FontAsset> fallbackFontAssetTable { get => default; set {} } // 0x0000000185FB82E0-0x0000000185FB82F0 0x00000001864734D4-0x00000001864734E8
		public FontAssetCreationSettings creationSettings { get => default; set {} } // 0x000000018BE0F310-0x000000018BE0F380 0x000000018BE0F380-0x000000018BE0F8D0
		public TMP_FontWeightPair[] fontWeightTable { get => default; internal set {} } // 0x0000000185CA4BE0-0x0000000185CA4C60 0x0000000184011D90-0x0000000184012770
		public RenderTexture[] dynamicRenderTextures { get => default; } // 0x000000018BE15BC0-0x000000018BE15C24 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53148
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<TMP_Character, uint> __9__133_0; // 0x08
			public static Func<Glyph, uint> __9__134_0; // 0x10
	
			// Constructors
			static __c() {} // 0x00000001813B51D0-0x00000001813B51E0
			public __c() {} // 0x00000001864721F0-0x0000000186472200
	
			// Methods
			internal uint _SortCharacterTable_b__133_0(TMP_Character c) => default; // 0x00000001813FF010-0x00000001813FF020
			internal uint _SortGlyphTable_b__134_0(Glyph c) => default; // 0x0000000185F05C80-0x0000000185F05C90
		}
	
		// Constructors
		public TMP_FontAsset() {} // 0x000000018BE15B00-0x000000018BE15B18
		static TMP_FontAsset() {} // 0x000000018B584038-0x000000018B584050
	
		// Methods
		public static TMP_FontAsset CreateFontAsset(Font font) => default; // 0x00000001840127D0-0x0000000184012800
		public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic /* Metadata: 0x02077ADA */, bool enableMultiAtlasSupport = true /* Metadata: 0x02077ADB */) => default; // 0x00000001840131A0-0x00000001840133B0
		private void Awake() {} // 0x0000000184012EE0-0x00000001840130F0
		public void ReadFontAssetDefinition() {} // 0x0000000184012970-0x0000000184012AA0
		internal void InitializeDictionaryLookupTables() {} // 0x0000000184012AF0-0x0000000184012D10
		internal void InitializeGlyphLookupDictionary() {} // 0x0000000184012D10-0x0000000184012EE0
		internal void InitializeCharacterLookupDictionary() {} // 0x000000018BE0E93C-0x000000018BE0E9E0
		internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() {} // 0x000000018BE10F50-0x000000018BE110BC
		internal void AddSynthesizedCharactersAndFaceMetrics() {} // 0x000000018BE110E0-0x000000018BE1124C
		private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false /* Metadata: 0x02077ADC */) {} // 0x000000018BE110BC-0x000000018BE110E0
		internal void AddCharacterToLookupCache(uint unicode, TMP_Character character) {} // 0x000000018BE10F24-0x000000018BE10F50
		internal void SortCharacterTable() {} // 0x000000018BE0FD78-0x000000018BE0FDD4
		internal void SortGlyphTable() {} // 0x000000018BE0FDD4-0x000000018BE102B4
		internal void SortFontFeatureTable() {} // 0x000000018BE0FB60-0x000000018BE0FD78
		internal void SortAllTables() {} // 0x000000018BE102B4-0x000000018BE10408
		public bool HasCharacter(int character) => default; // 0x000000018BE10408-0x000000018BE109D4
		public bool HasCharacter(char character, bool searchFallbacks = false /* Metadata: 0x02077ADD */, bool tryAddCharacter = false /* Metadata: 0x02077ADE */) => default; // 0x000000018BE109D4-0x000000018BE10A74
		private bool HasCharacter_Internal(uint character, bool searchFallbacks = false /* Metadata: 0x02077ADF */, bool tryAddCharacter = false /* Metadata: 0x02077AE0 */) => default; // 0x000000018BE0F99C-0x000000018BE0FA7C
		public bool HasCharacters(string text, out List<char> missingCharacters) {
			missingCharacters = default;
			return default;
		} // 0x000000018BE0F8D0-0x000000018BE0F99C
		public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false /* Metadata: 0x02077AE1 */, bool tryAddCharacter = false /* Metadata: 0x02077AE2 */) {
			missingCharacters = default;
			return default;
		} // 0x000000018BE0FA7C-0x000000018BE0FB60
		public bool HasCharacters(string text) => default; // 0x00000001840116B0-0x0000000184011790
		public static string GetCharacters(TMP_FontAsset fontAsset) => default; // 0x0000000184683160-0x00000001846832D0
		public static int[] GetCharactersArray(TMP_FontAsset fontAsset) => default; // 0x000000018BE10AC4-0x000000018BE10B90
		internal uint GetGlyphIndex(uint unicode) => default; // 0x000000018BE12FA8-0x000000018BE130CC
		internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset) {} // 0x000000018BE12678-0x000000018BE1269C
		internal static void UpdateFontFeaturesForFontAssetsInQueue() {} // 0x000000018BE1124C-0x000000018BE11C64
		internal static void RegisterFontAssetForAtlasTextureUpdate(TMP_FontAsset fontAsset) {} // 0x000000018BE11C64-0x000000018BE11C88
		internal static void UpdateAtlasTexturesForFontAssetsInQueue() {} // 0x000000018BE11C88-0x000000018BE12678
		public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false /* Metadata: 0x02077AE3 */) => default; // 0x000000018BE0E9E0-0x000000018BE0EA90
		public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false /* Metadata: 0x02077AE4 */) {
			missingUnicodes = default;
			return default;
		} // 0x0000000184011990-0x0000000184011D90
		public bool TryAddCharacters(string characters, bool includeFontFeatures = false /* Metadata: 0x02077AE5 */) => default; // 0x000000018BE12A14-0x000000018BE12E24
		public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false /* Metadata: 0x02077AE6 */) {
			missingCharacters = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		public void AddCharacters(string characters) {} // 0x000000018BE1269C-0x000000018BE12A14
		internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) {
			character = default;
			return default;
		} // 0x000000018BE10B90-0x000000018BE10F24
		internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character) {
			character = default;
			return default;
		} // 0x000000018BE12E24-0x000000018BE12FA8
		internal void TryAddGlyphsToAtlasTextures() {} // 0x0000000184682370-0x0000000184682470
		private bool TryAddGlyphsToNewAtlasTexture() => default; // 0x000000018BE131D4-0x000000018BE13400
		private void SetupNewAtlasTexture() {} // 0x0000000185492010-0x0000000185492020
		internal void UpdateAtlasTexture() {} // 0x0000000185492010-0x0000000185492020
		internal void UpdateGlyphAdjustmentRecords() {}
		internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) {} // 0x000000018BE0F14C-0x000000018BE0F188
		internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes) {} // 0x000000018BE0F144-0x000000018BE0F14C
		internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes) {} // 0x000000018BE0F120-0x000000018BE0F144
		private void CopyListDataToArray<T>(List<T> srcList, ref ref T[] dstArray) {} // 0x000000018BE130CC-0x000000018BE131D4
		public void ClearFontAssetData(bool setAtlasSizeToZero = false /* Metadata: 0x02077AE7 */) {} // 0x000000018BE0F188-0x000000018BE0F310
		public void ClearFontAssetData() {} // 0x000000018BE0EA90-0x000000018BE0F120
		internal void ClearFontAssetDataInternal() {} // 0x000000018BE13400-0x000000018BE13E08
		internal void UpdateFontAssetData() {} // 0x000000018BE13E08-0x000000018BE141A0
		internal void ClearFontAssetTables() {} // 0x0000000185FB8620-0x0000000185FB8630
		internal void ClearAtlasTextures(bool setAtlasSizeToZero = false /* Metadata: 0x02077AE8 */) {} // 0x000000018BE10A74-0x000000018BE10AC4
		internal void UpgradeFontAsset() {} // 0x00000001856F6C10-0x00000001856F7090
		private void UpgradeGlyphAdjustmentTableToFontFeatureTable() {} // 0x0000000185A58DA0-0x0000000185A59110
		private void OnDestroy() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class FaceInfo_Legacy // TypeDefIndex: 53150
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
		public FaceInfo_Legacy() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class TMP_Glyph : TMP_TextElement_Legacy // TypeDefIndex: 53151
	{
		// Constructors
		public TMP_Glyph() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static TMP_Glyph Clone(TMP_Glyph source) => default; // 0x000000018BE14674-0x000000018BE14714
	}

	[Serializable]
	public struct FontAssetCreationSettings // TypeDefIndex: 53152
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
		internal FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode) {
			sourceFontFileName = default;
			this.sourceFontFileGUID = default;
			this.pointSizeSamplingMode = default;
			this.pointSize = default;
			this.padding = default;
			this.packingMode = default;
			this.atlasWidth = default;
			this.atlasHeight = default;
			characterSetSelectionMode = default;
			characterSequence = default;
			referencedFontAssetGUID = default;
			referencedTextAssetGUID = default;
			fontStyle = default;
			fontStyleModifier = default;
			this.renderMode = default;
			includeFontFeatures = default;
		} // 0x000000018BE0886C-0x000000018BE08978
	}

	[Serializable]
	public struct TMP_FontWeightPair // TypeDefIndex: 53153
	{
		// Fields
		public TMP_FontAsset regularTypeface; // 0x00
		public TMP_FontAsset italicTypeface; // 0x08
	}

	public struct KerningPairKey // TypeDefIndex: 53154
	{
		// Fields
		public uint ascii_Left; // 0x00
		public uint ascii_Right; // 0x04
		public uint key; // 0x08
	
		// Constructors
		public KerningPairKey(uint ascii_left, uint ascii_right) {
			ascii_Left = default;
			ascii_Right = default;
			key = default;
		} // 0x0000000185FE58B0-0x0000000185FE58D0
	}

	[Serializable]
	public struct GlyphValueRecord_Legacy // TypeDefIndex: 53155
	{
		// Fields
		public float xPlacement; // 0x00
		public float yPlacement; // 0x04
		public float xAdvance; // 0x08
		public float yAdvance; // 0x0C
	
		// Constructors
		internal GlyphValueRecord_Legacy(GlyphValueRecord valueRecord) {
			xPlacement = default;
			yPlacement = default;
			xAdvance = default;
			yAdvance = default;
		} // 0x0000000185FE5890-0x0000000185FE58B0
	
		// Methods
		public static GlyphValueRecord_Legacy operator +(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b) => default; // 0x00000001845B9D50-0x00000001845B9DA0
	}

	[Serializable]
	public class KerningPair // TypeDefIndex: 53156
	{
		// Fields
		private uint m_FirstGlyph; // 0x10
		private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
		private uint m_SecondGlyph; // 0x24
		private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
		public float xOffset; // 0x38
		internal static KerningPair empty; // 0x00
		private bool m_IgnoreSpacingAdjustments; // 0x3C
	
		// Properties
		public uint firstGlyph { get => default; set {} } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x0000000181378230-0x0000000181378240
		public GlyphValueRecord_Legacy firstGlyphAdjustments { get => default; } // 0x0000000185FC2240-0x0000000185FC2250 
		public uint secondGlyph { get => default; set {} } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950
		public GlyphValueRecord_Legacy secondGlyphAdjustments { get => default; } // 0x0000000185FBB610-0x0000000185FBB620 
		public bool ignoreSpacingAdjustments { get => default; } // 0x0000000185FB0A40-0x0000000185FB0A50 
	
		// Constructors
		public KerningPair() {} // 0x0000000185FE5910-0x0000000185FE5930
		public KerningPair(uint left, uint right, float offset) {} // 0x0000000185FE58E0-0x0000000185FE58F0
		public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) {} // 0x0000000185FE58F0-0x0000000185FE5910
		static KerningPair() {} // 0x0000000185F4ED30-0x0000000185F4EDB0
	
		// Methods
		internal void ConvertLegacyKerningData() {} // 0x0000000185FE58D0-0x0000000185FE58E0
	}

	[Serializable]
	public class KerningTable // TypeDefIndex: 53161
	{
		// Fields
		public List<KerningPair> kerningPairs; // 0x10
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 53157
		{
			// Fields
			public uint first; // 0x10
			public uint second; // 0x14
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x00000001856F7090-0x00000001856F7110
	
			// Methods
			internal bool _AddKerningPair_b__0(KerningPair item) => default; // 0x000000018BE08E68-0x000000018BE08FA0
		}
	
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 53158
		{
			// Fields
			public uint first; // 0x10
			public uint second; // 0x14
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x000000018BE08D1C-0x000000018BE08E68
	
			// Methods
			internal bool _AddGlyphPairAdjustmentRecord_b__0(KerningPair item) => default; // 0x000000018BE08BB8-0x000000018BE08D1C
		}
	
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 53159
		{
			// Fields
			public int left; // 0x10
			public int right; // 0x14
	
			// Constructors
			public __c__DisplayClass5_0() {} // 0x000000018BE08FA0-0x000000018BE090A0
	
			// Methods
			internal bool _RemoveKerningPair_b__0(KerningPair item) => default; // 0x000000018BE090A0-0x000000018BE090F4
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53160
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KerningPair, uint> __9__7_0; // 0x08
			public static Func<KerningPair, uint> __9__7_1; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BE090F4-0x000000018BE09314
			public __c() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal uint _SortKerningPairs_b__7_0(KerningPair s) => default; // 0x000000018BE15B30-0x000000018BE15B5C
			internal uint _SortKerningPairs_b__7_1(KerningPair s) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public KerningTable() {} // 0x000000018BE15B30-0x000000018BE15B5C
	
		// Methods
		public void AddKerningPair() {} // 0x0000000185492010-0x0000000185492020
		public int AddKerningPair(uint first, uint second, float offset) => default; // 0x000000018BE15B5C-0x000000018BE15B90
		public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments) => default; // 0x000000018BE15C24-0x000000018BE15C88
		public void RemoveKerningPair(int left, int right) {} // 0x0000000185492010-0x0000000185492020
		public void RemoveKerningPair(int index) {} // 0x000000018B584038-0x000000018B584050
		public void SortKerningPairs() {} // 0x000000018BE15B18-0x000000018BE15B30
	}

	public static class TMP_FontUtilities // TypeDefIndex: 53162
	{
		// Fields
		private static List<int> k_searchedFontAssets; // 0x00
	
		// Methods
		public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character) {
			character = default;
			return default;
		} // 0x000000018BE14574-0x000000018BE14674
		public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) {
			character = default;
			return default;
		} // 0x000000018BE1456C-0x000000018BE14574
		private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character) {
			character = default;
			return default;
		} // 0x000000018BE14264-0x000000018BE14490
		private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) {
			character = default;
			return default;
		} // 0x000000018BE14490-0x000000018BE1456C
	}

	public class TMP_FontAssetUtilities // TypeDefIndex: 53163
	{
		// Fields
		private static readonly TMP_FontAssetUtilities s_Instance; // 0x00
		private static HashSet<int> k_SearchedAssets; // 0x08
		private static bool k_IsFontEngineInitialized; // 0x10
	
		// Properties
		public static TMP_FontAssetUtilities instance { get => default; } // 0x000000018BE0E8EC-0x000000018BE0E93C 
	
		// Constructors
		static TMP_FontAssetUtilities() {} // 0x0000000185F797B0-0x0000000185F79810
		public TMP_FontAssetUtilities() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) {
			isAlternativeTypeface = default;
			return default;
		} // 0x00000001842B0FC0-0x00000001842B1080
		private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) {
			isAlternativeTypeface = default;
			return default;
		} // 0x00000001842B1080-0x00000001842B1910
		public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) {
			isAlternativeTypeface = default;
			return default;
		} // 0x0000000184682570-0x0000000184682840
		public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) => default; // 0x000000018BE0E600-0x000000018BE0E8EC
		private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) => default; // 0x000000018BE0E448-0x000000018BE0E600
	}

	public enum FontFeatureLookupFlags // TypeDefIndex: 53164
	{
		None = 0,
		IgnoreLigatures = 4,
		IgnoreSpacingAdjustments = 256
	}

	[Serializable]
	public struct TMP_GlyphValueRecord // TypeDefIndex: 53165
	{
		// Fields
		internal float m_XPlacement; // 0x00
		internal float m_YPlacement; // 0x04
		internal float m_XAdvance; // 0x08
		internal float m_YAdvance; // 0x0C
	
		// Properties
		public float xPlacement { get => default; set {} } // 0x0000000185FB0F90-0x0000000185FB0FA0 0x0000000185FBA160-0x0000000185FBA170
		public float yPlacement { get => default; set {} } // 0x0000000185FBA150-0x0000000185FBA160 0x0000000185FBA180-0x0000000185FBA190
		public float xAdvance { get => default; set {} } // 0x0000000185FBA140-0x0000000185FBA150 0x0000000185FBA170-0x0000000185FBA180
		public float yAdvance { get => default; set {} } // 0x0000000185FBF760-0x0000000185FBF770 0x0000000185FBF770-0x0000000185FBF780
	
		// Constructors
		public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance) : this() {
			m_XPlacement = default;
			m_YPlacement = default;
			m_XAdvance = default;
			m_YAdvance = default;
		} // 0x0000000185FB2B40-0x0000000185FB2B60
		internal TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord) : this() {
			m_XPlacement = default;
			m_YPlacement = default;
			m_XAdvance = default;
			m_YAdvance = default;
		} // 0x0000000185FBF140-0x0000000185FBF160
		internal TMP_GlyphValueRecord(GlyphValueRecord valueRecord) : this() {
			m_XPlacement = default;
			m_YPlacement = default;
			m_XAdvance = default;
			m_YAdvance = default;
		} // 0x0000000185FE5890-0x0000000185FE58B0
	
		// Methods
		public static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) => default; // 0x0000000185FE59F0-0x0000000185FE5A10
	}

	[Serializable]
	public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 53166
	{
		// Fields
		internal uint m_GlyphIndex; // 0x00
		internal TMP_GlyphValueRecord m_GlyphValueRecord; // 0x04
	
		// Properties
		public uint glyphIndex { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public TMP_GlyphValueRecord glyphValueRecord { get => default; set {} } // 0x0000000185FC8490-0x0000000185FC84A0 0x0000000185FE5A80-0x0000000185FE5A90
	
		// Constructors
		public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord) : this() {
			m_GlyphIndex = default;
			m_GlyphValueRecord = default;
		} // 0x0000000185FC8390-0x0000000185FC83A0
		internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord) : this() {
			m_GlyphIndex = default;
			m_GlyphValueRecord = default;
		} // 0x000000018BE16088-0x000000018BE160D0
	}

	[Serializable]
	public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 53167
	{
		// Fields
		public TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
		public TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
		public FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38
	
		// Properties
		public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get => default; set {} } // 0x00000001834A7280-0x00000001834A72A0 0x0000000185FCF1E0-0x0000000185FCF1F0
		public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get => default; set {} } // 0x0000000185FE5AC0-0x0000000185FE5AE0 0x0000000185FE5AE0-0x0000000185FE5AF0
		public FontFeatureLookupFlags featureLookupFlags { get => default; set {} } // 0x00000001813E5E30-0x00000001813E5E40 0x00000001813E6F50-0x00000001813E6F60
	
		// Constructors
		public TMP_GlyphPairAdjustmentRecord() {} // Dummy constructor
		public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) {} // 0x0000000185FE5A90-0x0000000185FE5AC0
		internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) {} // 0x000000018BE160D0-0x000000018BE161A0
	}

	public struct GlyphPairKey // TypeDefIndex: 53168
	{
		// Fields
		public uint firstGlyphIndex; // 0x00
		public uint secondGlyphIndex; // 0x04
		public uint key; // 0x08
	
		// Constructors
		public GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex) {
			this.firstGlyphIndex = default;
			this.secondGlyphIndex = default;
			key = default;
		} // 0x0000000185FE5A60-0x0000000185FE5A80
		internal GlyphPairKey(TMP_GlyphPairAdjustmentRecord record) {
			firstGlyphIndex = default;
			secondGlyphIndex = default;
			key = default;
		} // 0x000000018BE15C88-0x000000018BE15CB8
	}

	[Serializable]
	public class TMP_FontFeatureTable // TypeDefIndex: 53170
	{
		// Fields
		internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
		public Dictionary<uint, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18
	
		// Properties
		public List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get => default; set {} } // 0x000000018BE1CF4C-0x000000018BE1D0A4 0x0000000185492010-0x0000000185492020
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53169
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> __9__6_0; // 0x08
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> __9__6_1; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018346D130-0x000000018346D140
			public __c() {} // 0x0000000184096E30-0x0000000184096EF0
	
			// Methods
			internal uint _SortGlyphPairAdjustmentRecords_b__6_0(TMP_GlyphPairAdjustmentRecord s) => default; // 0x00000001856F7110-0x00000001856F71E0
			internal uint _SortGlyphPairAdjustmentRecords_b__6_1(TMP_GlyphPairAdjustmentRecord s) => default; // 0x000000018BE15E68-0x000000018BE16088
		}
	
		// Constructors
		public TMP_FontFeatureTable() {} // 0x000000018BE1CF1C-0x000000018BE1CF34
	
		// Methods
		public void SortGlyphPairAdjustmentRecords() {} // 0x000000018BE1CF34-0x000000018BE1CF4C
	}

	public class TMP_InputField : Selectable, IUpdateSelectedHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, UnityEngine.EventSystems.IScrollHandler // TypeDefIndex: 53184
	{
		// Fields
		protected TouchScreenKeyboard m_SoftKeyboard; // 0x180
		private static readonly char[] kSeparators; // 0x00
		protected RectTransform m_RectTransform; // 0x188
		protected RectTransform m_TextViewport; // 0x190
		protected RectMask2D m_TextComponentRectMask; // 0x198
		protected RectMask2D m_TextViewportRectMask; // 0x1A0
		private Rect m_CachedViewportRect; // 0x1A8
		protected TMP_Text m_TextComponent; // 0x1B8
		protected RectTransform m_TextComponentRectTransform; // 0x1C0
		protected Graphic m_Placeholder; // 0x1C8
		protected Scrollbar m_VerticalScrollbar; // 0x1D0
		protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x1D8
		private bool m_IsDrivenByLayoutComponents; // 0x1E0
		private LayoutGroup m_LayoutGroup; // 0x1E8
		private UnityEngine.EventSystems.IScrollHandler m_IScrollHandlerParent; // 0x1F0
		private float m_ScrollPosition; // 0x1F8
		protected float m_ScrollSensitivity; // 0x1FC
		private ContentType m_ContentType; // 0x200
		private InputType m_InputType; // 0x204
		private char m_AsteriskChar; // 0x208
		private TouchScreenKeyboardType m_KeyboardType; // 0x20C
		private LineType m_LineType; // 0x210
		private bool m_HideMobileInput; // 0x214
		private bool m_HideSoftKeyboard; // 0x215
		private CharacterValidation m_CharacterValidation; // 0x218
		private string m_RegexValue; // 0x220
		private float m_GlobalPointSize; // 0x228
		private int m_CharacterLimit; // 0x22C
		private SubmitEvent m_OnEndEdit; // 0x230
		private SubmitEvent m_OnSubmit; // 0x238
		private SelectionEvent m_OnSelect; // 0x240
		private SelectionEvent m_OnDeselect; // 0x248
		private TextSelectionEvent m_OnTextSelection; // 0x250
		private TextSelectionEvent m_OnEndTextSelection; // 0x258
		private OnChangeEvent m_OnValueChanged; // 0x260
		private TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x268
		private OnValidateInput m_OnValidateInput; // 0x270
		private UnityEvent m_OnFocused; // 0x278
		private UnityEngine.Color m_CaretColor; // 0x280
		private bool m_CustomCaretColor; // 0x290
		private UnityEngine.Color m_SelectionColor; // 0x294
		protected string m_Text; // 0x2A8
		private float m_CaretBlinkRate; // 0x2B0
		private int m_CaretWidth; // 0x2B4
		private bool m_ReadOnly; // 0x2B8
		private bool m_RichText; // 0x2B9
		private bool m_disableUpDownArrowKeyMovingCaret; // 0x2BA
		private bool m_disableLeftRightArrowKeyMovingCaret; // 0x2BB
		protected int m_StringPosition; // 0x2BC
		protected int m_StringSelectPosition; // 0x2C0
		protected int m_CaretPosition; // 0x2C4
		protected int m_CaretSelectPosition; // 0x2C8
		private RectTransform caretRectTrans; // 0x2D0
		protected UIVertex[] m_CursorVerts; // 0x2D8
		private CanvasRenderer m_CachedInputRenderer; // 0x2E0
		private Vector2 m_LastPosition; // 0x2E8
		[NonSerialized]
		protected Mesh m_Mesh; // 0x2F0
		private bool m_AllowInput; // 0x2F8
		private bool m_ShouldActivateNextUpdate; // 0x2F9
		private bool m_UpdateDrag; // 0x2FA
		private bool m_DragPositionOutOfBounds; // 0x2FB
		private const float kHScrollSpeed = 0.05f; // Metadata: 0x02077AEF
		private const float kVScrollSpeed = 0.1f; // Metadata: 0x02077AF3
		protected bool m_CaretVisible; // 0x2FC
		private Coroutine m_BlinkCoroutine; // 0x300
		private float m_BlinkStartTime; // 0x308
		private Coroutine m_DragCoroutine; // 0x310
		private string m_OriginalText; // 0x318
		private bool m_WasCanceled; // 0x320
		private bool m_HasDoneFocusTransition; // 0x321
		private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x328
		private bool m_PreventCallback; // 0x330
		private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x331
		private bool m_IsTextComponentUpdateRequired; // 0x332
		private bool m_isLastKeyBackspace; // 0x333
		private float m_PointerDownClickStartTime; // 0x334
		private float m_KeyDownStartTime; // 0x338
		private float m_DoubleClickDelay; // 0x33C
		private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~"; // Metadata: 0x02077AF7
		private bool m_IsCompositionActive; // 0x340
		private bool m_ShouldUpdateIMEWindowPosition; // 0x341
		private int m_PreviousIMEInsertionLine; // 0x344
		public Func<string, int, string> onValidateCharacterLimit; // 0x348
		public Func<string, int> onGetTextLength; // 0x350
		protected bool m_OnFocusSelectAll; // 0x358
		protected bool m_isSelectAll; // 0x359
		protected bool m_ResetOnDeActivation; // 0x35A
		private bool m_SelectionStillActive; // 0x35B
		private bool m_ReleaseSelection; // 0x35C
		private GameObject m_PreviouslySelectedObject; // 0x360
		private bool m_RestoreOriginalTextOnEscape; // 0x368
		private bool m_WontReleaseSelectionOnEscape; // 0x369
		private bool m_tempClearCompositionString; // 0x36A
		protected bool m_isRichTextEditingAllowed; // 0x36B
		protected int m_LineLimit; // 0x36C
		protected TMP_InputValidator m_InputValidator; // 0x370
		private bool m_isSelected; // 0x378
		private bool m_IsStringPositionDirty; // 0x379
		private bool m_IsCaretPositionDirty; // 0x37A
		private bool m_forceRectTransformAdjustment; // 0x37B
		private UnityEngine.Event m_ProcessingEvent; // 0x380
	
		// Properties
		public bool isLastKeyBackspace { get => default; set {} } // 0x0000000181B44930-0x0000000181B44940 0x000000018BE1ADC4-0x000000018BE1AE10
		private BaseInput inputSystem { get => default; } // 0x0000000181BE0A10-0x0000000181BE0A20 
		private string compositionString { get => default; } // 0x000000018BE1AD68-0x000000018BE1ADC4 
		private int compositionLength { get => default; } // 0x0000000185FB8420-0x0000000185FB8430 
		protected Mesh mesh { get => default; } // 0x0000000185FB8030-0x0000000185FB8040 
		public bool shouldHideMobileInput { get => default; set {} } // 0x000000018BE1AE10-0x000000018BE1AFAC 0x0000000185FBACC0-0x0000000185FBACD0
		public bool shouldHideSoftKeyboard { get => default; set {} } // 0x000000018BE1AA24-0x000000018BE1AA80 0x0000000184A18A10-0x0000000184A18A60
		public string text { get => default; set {} } // 0x0000000185FE5B30-0x0000000185FE5B40 0x000000018BE1A450-0x000000018BE1A468
		public bool isFocused { get => default; } // 0x0000000185FB8310-0x0000000185FB8320 
		public float caretBlinkRate { get => default; set {} } // 0x000000018BE1A6D0-0x000000018BE1A71C 0x0000000185FB8850-0x0000000185FB8860
		public int caretWidth { get => default; set {} } // 0x000000018BE1A800-0x000000018BE1A84C 0x0000000185FB8770-0x0000000185FB8780
		public RectTransform textViewport { get => default; set {} } // 0x000000018BE1A7B4-0x000000018BE1A800 0x0000000185FB8840-0x0000000185FB8850
		public TMP_Text textComponent { get => default; set {} } // 0x000000018BE1A684-0x000000018BE1A6D0 0x0000000185FB8470-0x0000000185FB8480
		public Graphic placeholder { get => default; set {} } // 0x000000018BE1A84C-0x000000018BE1A898 0x0000000185FB8860-0x0000000185FB8870
		public Scrollbar verticalScrollbar { get => default; set {} } // 0x000000018BE1A71C-0x000000018BE1A768 0x0000000185FB88E0-0x0000000185FB88F0
		public float scrollSensitivity { get => default; set {} } // 0x000000018BE1A8E4-0x000000018BE1A930 0x0000000185FB8680-0x0000000185FB8690
		public UnityEngine.Color caretColor { get => default; set {} } // 0x000000018BE1A898-0x000000018BE1A8E4 0x0000000185FB87D0-0x0000000185FB87E0
		public bool customCaretColor { get => default; set {} } // 0x0000000185F37370-0x0000000185F373C0 0x0000000185FB8480-0x0000000185FB8490
		public UnityEngine.Color selectionColor { get => default; set {} } // 0x000000018BE1A768-0x000000018BE1A7B4 0x0000000185FE5B20-0x0000000185FE5B30
		public SubmitEvent onEndEdit { get => default; set {} } // 0x0000000184A148E0-0x0000000184A14980 0x0000000185FD6C50-0x0000000185FD6C60
		public SubmitEvent onSubmit { get => default; set {} } // 0x000000018BE1A97C-0x000000018BE1AA14 0x0000000185FE5BC0-0x0000000185FE5BD0
		public SelectionEvent onSelect { get => default; set {} } // 0x0000000185FE5C50-0x0000000185FE5C60 0x0000000185FE5BD0-0x0000000185FE5BE0
		public SelectionEvent onDeselect { get => default; set {} } // 0x0000000185FE5C70-0x0000000185FE5C80 0x0000000185FBD140-0x0000000185FBD150
		public TextSelectionEvent onTextSelection { get => default; set {} } // 0x0000000185FBD240-0x0000000185FBD250 0x0000000185FE5C10-0x0000000185FE5C20
		public TextSelectionEvent onEndTextSelection { get => default; set {} } // 0x0000000185FE5C80-0x0000000185FE5C90 0x0000000185FE5B40-0x0000000185FE5B50
		public OnChangeEvent onValueChanged { get => default; set {} } // 0x0000000185FE5C20-0x0000000185FE5C30 0x0000000185FE5B80-0x0000000185FE5B90
		public TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get => default; set {} } // 0x0000000185FE5C40-0x0000000185FE5C50 0x0000000185FCDD10-0x0000000185FCDD20
		public OnValidateInput onValidateInput { get => default; set {} } // 0x000000018BE1A3F4-0x000000018BE1A450 0x0000000185FE5BB0-0x0000000185FE5BC0
		public UnityEvent onFocused { get => default; set {} } // 0x000000018BE1A5E0-0x000000018BE1A684 0x0000000185FE5BA0-0x0000000185FE5BB0
		public int characterLimit { get => default; set {} } // 0x000000018BE1A580-0x000000018BE1A5E0 0x0000000185FE5B50-0x0000000185FE5B60
		public float pointSize { get => default; set {} } // 0x000000018BE1A468-0x000000018BE1A4C4 0x0000000185FE5B90-0x0000000185FE5BA0
		public bool onFocusSelectAll { get => default; set {} } // 0x000000018BE1A524-0x000000018BE1A580 0x0000000181CE76D0-0x0000000181CE76E0
		public bool resetOnDeActivation { get => default; set {} } // 0x000000018BE1A390-0x000000018BE1A3EC 0x0000000185FB7030-0x0000000185FB7040
		public bool restoreOriginalTextOnEscape { get => default; set {} } // 0x000000018BE1A4C4-0x000000018BE1A524 0x0000000185FB9200-0x0000000185FB9210
		public bool wontReleaseSelectionOnEscape { get => default; set {} } // 0x0000000185FE5C60-0x0000000185FE5C70 0x0000000185FE5BE0-0x0000000185FE5BF0
		public bool disableArrowKeyMoveCaret { get => default; set {} } // 0x000000018BE1AA14-0x000000018BE1AA24 0x0000000184A15A30-0x0000000184A15A50
		public bool isRichTextEditingAllowed { get => default; set {} } // 0x0000000185FE5AF0-0x0000000185FE5B00 0x000000018BE1A1F8-0x000000018BE1A254
		public ContentType contentType { get => default; set {} } // 0x0000000185FE5C00-0x0000000185FE5C10 0x0000000185F9B630-0x0000000185F9B670
		public LineType lineType { get => default; set {} } // 0x00000001859C7540-0x00000001859C7590 0x0000000184A189F0-0x0000000184A18A10
		public int lineLimit { get => default; set {} } // 0x000000018647174C-0x0000000186471764 0x0000000184A17E90-0x0000000184A17EB0
		public InputType inputType { get => default; set {} } // 0x00000001864743AC-0x00000001864743C4 0x0000000185FA29C0-0x0000000185FA29E0
		public TouchScreenKeyboardType keyboardType { get => default; set {} } // 0x0000000186471734-0x000000018647174C 0x0000000184A17E70-0x0000000184A17E90
		public CharacterValidation characterValidation { get => default; set {} } // 0x0000000186474394-0x00000001864743AC 0x0000000184A17C90-0x0000000184A17CC0
		public TMP_InputValidator inputValidator { get => default; set {} } // 0x000000018647172C-0x0000000186471734 0x000000018BE1A2FC-0x000000018BE1A334
		public bool readOnly { get => default; set {} } // 0x0000000186471724-0x000000018647172C 0x000000018BE1AA80-0x000000018BE1AABC
		public bool richText { get => default; set {} } // 0x000000018647172C-0x0000000186471734 0x000000018BE1AAFC-0x000000018BE1AB38
		public bool multiLine { get => default; } // 0x000000018BE1A16C-0x000000018BE1A174 
		public char asteriskChar { get => default; set {} } // 0x000000018BE1AD30-0x000000018BE1AD68 0x000000018BE1A164-0x000000018BE1A16C
		public bool wasCanceled { get => default; } // 0x000000018BE1AB38-0x000000018BE1AB74 
		protected int caretPositionInternal { get => default; set {} } // 0x0000000184A13EF0-0x0000000184A145F0 0x0000000184A139C0-0x0000000184A13D30
		protected int stringPositionInternal { get => default; set {} } // 0x0000000184A17CC0-0x0000000184A17DE0 0x0000000185FA2D00-0x0000000185FA2D60
		protected int caretSelectPositionInternal { get => default; set {} } // 0x0000000184A156E0-0x0000000184A15720 0x0000000184A15720-0x0000000184A15790
		protected int stringSelectPositionInternal { get => default; set {} } // 0x000000018572FFB0-0x000000018572FFF0 0x000000018572FF60-0x000000018572FFB0
		private new bool hasSelection { get => default; } // 0x000000018BE18148-0x000000018BE18218 
		public int caretPosition { get => default; set {} } // 0x000000018BE18218-0x000000018BE182BC 0x000000018BE182BC-0x000000018BE18414
		public int selectionAnchorPosition { get => default; set {} } // 0x000000018BE18414-0x000000018BE18598 0x000000018BE19EE4-0x000000018BE19EEC
		public int selectionFocusPosition { get => default; set {} } // 0x000000018BE1A3EC-0x000000018BE1A3F4 0x0000000184A17830-0x0000000184A17890
		public int stringPosition { get => default; set {} } // 0x000000018BE196C8-0x000000018BE197C0 0x0000000184A15F70-0x0000000184A177D0
		public int selectionStringAnchorPosition { get => default; set {} } // 0x00000001845E23A0-0x00000001845E2450 0x000000018BE186C8-0x000000018BE186EC
		public int selectionStringFocusPosition { get => default; set {} } // 0x000000018BE186EC-0x000000018BE18A44 0x000000018BE1742C-0x000000018BE174A0
		private static string clipboard { get => default; set {} } // 0x000000018BE175F8-0x000000018BE1789C 0x000000018BE171D8-0x000000018BE1742C
		public virtual float minWidth { get => default; } // 0x0000000185492010-0x0000000185492020 
		public virtual float preferredWidth { get => default; } // 0x0000000185682EE0-0x0000000185683030 
		public virtual float flexibleWidth { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public virtual float minHeight { get => default; } // 0x000000018BE1CC28-0x000000018BE1CC74 
		public virtual float preferredHeight { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public virtual float flexibleHeight { get => default; } // 0x0000000181378230-0x0000000181378240 
		public virtual int layoutPriority { get => default; } // 0x0000000185492010-0x0000000185492020 
		Transform ICanvasElement.transform { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Nested types
		public enum ContentType // TypeDefIndex: 53171
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
	
		public enum InputType // TypeDefIndex: 53172
		{
			Standard = 0,
			AutoCorrect = 1,
			Password = 2
		}
	
		public enum CharacterValidation // TypeDefIndex: 53173
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
	
		public enum LineType // TypeDefIndex: 53174
		{
			SingleLine = 0,
			MultiLineSubmit = 1,
			MultiLineNewline = 2
		}
	
		public delegate char OnValidateInput(string text, int charIndex, char addedChar); // TypeDefIndex: 53175; 0x0000000185FE5C30-0x0000000185FE5C40
	
		[Serializable]
		public class SubmitEvent : UnityEvent<string> // TypeDefIndex: 53176
		{
			// Constructors
			public SubmitEvent() {} // 0x0000000183FB50C0-0x0000000183FB50F0
		}
	
		[Serializable]
		public class OnChangeEvent : UnityEvent<string> // TypeDefIndex: 53177
		{
			// Constructors
			public OnChangeEvent() {} // 0x0000000184D70FD0-0x0000000184D713A0
		}
	
		[Serializable]
		public class SelectionEvent : UnityEvent<string> // TypeDefIndex: 53178
		{
			// Constructors
			public SelectionEvent() {} // 0x0000000184A15D20-0x0000000184A15DE0
		}
	
		[Serializable]
		public class TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 53179
		{
			// Constructors
			public TextSelectionEvent() {} // 0x000000018BE1A174-0x000000018BE1A1A4
		}
	
		[Serializable]
		public class TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 53180
		{
			// Constructors
			public TouchScreenKeyboardEvent() {} // 0x000000018BE1ABB0-0x000000018BE1AC1C
		}
	
		protected enum EditState // TypeDefIndex: 53181
		{
			Continue = 0,
			Finish = 1
		}
	
		private sealed class _CaretBlink_d__291 : IEnumerator<object> // TypeDefIndex: 53182
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TMP_InputField __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185FB8650-0x0000000185FB8660 
			object IEnumerator.Current { get => default; } // 0x000000018BE19578-0x000000018BE19584 
	
			// Constructors
			public _CaretBlink_d__291() {} // Dummy constructor
			public _CaretBlink_d__291(int __1__state) {} // 0x000000018BE1A1A4-0x000000018BE1A1F8
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BE1AC1C-0x000000018BE1AD30
			private bool MoveNext() => default; // 0x0000000184A177D0-0x0000000184A17800
			void IEnumerator.Reset() {} // 0x0000000186473118-0x0000000186473124
		}
	
		private sealed class _MouseDragOutsideRect_d__309 : IEnumerator<object> // TypeDefIndex: 53183
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TMP_InputField __4__this; // 0x20
			public PointerEventData eventData; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018BE1A254-0x000000018BE1A2BC 
			object IEnumerator.Current { get => default; } // 0x000000018BE1A334-0x000000018BE1A390 
	
			// Constructors
			public _MouseDragOutsideRect_d__309() {} // Dummy constructor
			public _MouseDragOutsideRect_d__309(int __1__state) {} // 0x000000018504C6B0-0x000000018504C7E0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FE5B60-0x0000000185FE5B70
			private bool MoveNext() => default; // 0x0000000185FE5B00-0x0000000185FE5B10
			void IEnumerator.Reset() {} // 0x0000000185FE5B10-0x0000000185FE5B20
		}
	
		// Constructors
		protected TMP_InputField() {} // 0x000000018BE1A930-0x000000018BE1A97C
		static TMP_InputField() {} // 0x000000018BE1CED0-0x000000018BE1CF1C
	
		// Methods
		private bool isKeyboardUsingEvents() => default; // 0x000000018BE1A2BC-0x000000018BE1A2FC
		public void SetTextWithoutNotify(string input) {} // 0x0000000185FE5BF0-0x0000000185FE5C00
		private void SetText(string value, bool sendCallback = true /* Metadata: 0x02077AED */) {} // 0x000000018BE1AABC-0x000000018BE1AAFC
		protected void ClampStringPos(ref int pos) {} // 0x000000018BE1A16C-0x000000018BE1A174
		protected void ClampCaretPos(ref int pos) {} // 0x000000018BE1AB74-0x000000018BE1ABB0
		protected override void OnEnable() {} // 0x000000018BE18A44-0x000000018BE18A68
		protected override void OnDisable() {} // 0x00000001845E21D0-0x00000001845E23A0
		private void ON_TEXT_CHANGED(UnityEngine.Object obj) {} // 0x0000000184A15790-0x0000000184A15950
		private IEnumerator CaretBlink() => default; // 0x0000000184A15A10-0x0000000184A15A30
		private void SetCaretVisible() {} // 0x000000018BE192B8-0x000000018BE192C0
		private void SetCaretActive() {} // 0x0000000184A151C0-0x0000000184A152D0
		protected void OnFocus() {} // 0x000000018BE18A68-0x000000018BE18BE8
		protected void SelectAll() {} // 0x000000018BE16D78-0x000000018BE16E80
		public void MoveTextEnd(bool shift) {} // 0x000000018BE16E80-0x000000018BE16F0C
		public void MoveTextStart(bool shift) {} // 0x000000018BE16A9C-0x000000018BE16B58
		public void MoveToEndOfLine(bool shift, bool ctrl) {} // 0x000000018BE17E3C-0x000000018BE18148
		public void MoveToStartOfLine(bool shift, bool ctrl) {} // 0x000000018BE16B58-0x000000018BE16C0C
		private bool InPlaceEditing() => default; // 0x000000018BE16F60-0x000000018BE171D8
		private void UpdateStringPositionFromKeyboard() {} // 0x000000018BE18FB0-0x000000018BE192B8
		protected virtual void LateUpdate() {} // 0x000000018BE18C70-0x000000018BE18FB0
		private bool MayDrag(PointerEventData eventData) => default; // 0x000000018BE175EC-0x000000018BE175F8
		public virtual void OnBeginDrag(PointerEventData eventData) {} // 0x000000018BE174A0-0x000000018BE175EC
		public virtual void OnDrag(PointerEventData eventData) {} // 0x000000018BE18598-0x000000018BE185A4
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData) => default; // 0x000000018BE185A4-0x000000018BE186C8
		public virtual void OnEndDrag(PointerEventData eventData) {} // 0x000000018BE17E30-0x000000018BE17E3C
		public override void OnPointerDown(PointerEventData eventData) {} // 0x000000018BE17B78-0x000000018BE17E30
		protected EditState KeyPressed(UnityEngine.Event evt) => default; // 0x000000018BE17B6C-0x000000018BE17B78
		protected virtual bool IsValidChar(char c) => default; // 0x000000018BE1789C-0x000000018BE17B6C
		public void ProcessEvent(UnityEngine.Event e) {} // 0x000000018504E080-0x000000018504E140
		public virtual void OnUpdateSelected(BaseEventData eventData) {} // 0x000000018BE16744-0x000000018BE16968
		public virtual void OnScroll(PointerEventData eventData) {} // 0x000000018BE16450-0x000000018BE16744
		private float GetScrollPositionRelativeToViewport() => default; // 0x000000018BE163C8-0x000000018BE16450
		private string GetSelectedString() => default; // 0x0000000184A15A90-0x0000000184A15BB0
		private int FindNextWordBegin() => default; // 0x000000018504DD20-0x000000018504DE70
		private void MoveRight(bool shift, bool ctrl) {} // 0x000000018504E000-0x000000018504E020
		private int FindPrevWordBegin() => default; // 0x000000018BE19310-0x000000018BE19330
		private void MoveLeft(bool shift, bool ctrl) {} // 0x000000018504E020-0x000000018504E080
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) => default; // 0x0000000185734C40-0x0000000185734CA0
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar) => default; // 0x000000018BE192C0-0x000000018BE19310
		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) => default; // 0x0000000185F1D720-0x0000000185F1D780
		private int PageDownCharacterPosition(int originalPos, bool goToLastChar) => default; // 0x0000000185F57670-0x0000000185F576D0
		private void MoveDown(bool shift) {} // 0x0000000185F82D70-0x0000000185F82E10
		private void MoveDown(bool shift, bool goToLastChar) {} // 0x0000000184A17EB0-0x0000000184A17F60
		private void MoveUp(bool shift) {} // 0x000000018BE19330-0x000000018BE193A0
		private void MoveUp(bool shift, bool goToFirstChar) {} // 0x0000000184A15350-0x0000000184A15690
		private void MovePageUp(bool shift) {} // 0x000000018BE195EC-0x000000018BE196C8
		private void MovePageUp(bool shift, bool goToFirstChar) {} // 0x000000018BE18BE8-0x000000018BE18C28
		private void MovePageDown(bool shift) {} // 0x0000000185492010-0x0000000185492020
		private void MovePageDown(bool shift, bool goToLastChar) {} // 0x000000018BE161A0-0x000000018BE163C8
		private void Delete() {} // 0x0000000184A17DE0-0x0000000184A17E70
		private void DeleteKey() {} // 0x000000018BE16CA4-0x000000018BE16D78
		private void Backspace() {} // 0x000000018BE16C14-0x000000018BE16CA4
		protected virtual void Append(string input) {} // 0x000000018BE16F0C-0x000000018BE16F60
		protected virtual void Append(char input) {} // 0x000000018BE16C0C-0x000000018BE16C14
		private void Insert(char c) {} // 0x0000000184A15690-0x0000000184A156E0
		private void UpdateTouchKeyboardFromEditChanges() {} // 0x0000000184A15C50-0x0000000184A15C60
		private void SendOnValueChangedAndUpdateLabel() {} // 0x0000000185492010-0x0000000185492020
		private void SendOnValueChanged() {} // 0x0000000185492010-0x0000000185492020
		protected void SendOnEndEdit() {} // 0x0000000184A15C60-0x0000000184A15D20
		protected void SendOnSubmit() {} // 0x0000000184A121A0-0x0000000184A12610
		protected virtual void SendOnFocus() {} // 0x0000000184A178D0-0x0000000184A17C90
		protected virtual void SendOnFocusLost() {} // 0x0000000184A17F60-0x0000000184A18830
		protected void SendOnTextSelection() {} // 0x0000000185A946D0-0x0000000185A94870
		protected void SendOnEndTextSelection() {} // 0x0000000185785B00-0x00000001857861A0
		protected void SendTouchScreenKeyboardStatusChanged() {} // 0x0000000185786250-0x00000001857865E0
		protected void UpdateLabel() {} // 0x000000018BE197C0-0x000000018BE19EE4
		private void UpdateScrollbar() {} // 0x0000000185734960-0x0000000185734A50
		private void OnScrollbarValueChange(float value) {} // 0x00000001814A81B0-0x00000001814A81C0
		private void UpdateMaskRegions() {} // 0x0000000183F79E80-0x0000000183F7A420
		private void AdjustTextPositionRelativeToViewport(float relativePosition) {} // 0x000000018572FFF0-0x00000001857313D0
		private int GetCaretPositionFromStringIndex(int stringIndex) => default; // 0x0000000185F388C0-0x0000000185F38900
		private int GetMinCaretPositionFromStringIndex(int stringIndex) => default; // 0x0000000185FAE070-0x0000000185FAE0B0
		private int GetMaxCaretPositionFromStringIndex(int stringIndex) => default; // 0x0000000185492010-0x0000000185492020
		private int GetStringIndexFromCaretPosition(int caretPosition) => default; // 0x0000000185734BF0-0x0000000185734C40
		public void ForceLabelUpdate() {} // 0x0000000185732D40-0x0000000185733040
		private void MarkGeometryAsDirty() {} // 0x0000000185F10A00-0x0000000185F10A40
		public virtual void Rebuild(CanvasUpdate update) {} // 0x000000018BE18C28-0x000000018BE18C70
		public virtual void LayoutComplete() {} // 0x000000018BE16968-0x000000018BE16A9C
		public virtual void GraphicUpdateComplete() {} // 0x0000000184D71500-0x0000000184D71570
		private void UpdateGeometry() {} // 0x000000018BE19500-0x000000018BE19578
		private void AssignPositioningIfNeeded() {} // 0x000000018BE19584-0x000000018BE195D4
		private void OnFillVBO(Mesh vbo) {} // 0x000000018BE195D4-0x000000018BE195EC
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) {} // 0x000000018BE195D4-0x000000018BE195EC
		private void CreateCursorVerts() {} // 0x0000000185EC28F0-0x0000000185EC2920
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset) {} // 0x0000000185492010-0x0000000185492020
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) {} // 0x0000000185492010-0x0000000185492020
		protected char Validate(string text, int pos, char ch) => default; // 0x0000000183908D00-0x0000000183908D10
		public virtual void ActivateInputField() {} // 0x000000018BE1A028-0x000000018BE1A164
		protected virtual bool TryActivateInputFieldCustom() => default; // 0x0000000185FD5E00-0x0000000185FD5E10
		protected void CompleteActivation() {} // 0x0000000183908D00-0x0000000183908D10
		private void ActivateInputFieldInternal() {} // 0x000000018BE19EEC-0x000000018BE1A028
		public override void OnSelect(BaseEventData eventData) {} // 0x0000000185FD5E00-0x0000000185FD5E10
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x0000000181B87DE0-0x0000000181B87DF0
		public void OnControlClick() {} // 0x000000018BE19450-0x000000018BE19500
		public void ReleaseSelection() {} // 0x000000018BE193A0-0x000000018BE19450
		public virtual void DeactivateInputField(bool clearSelection = false /* Metadata: 0x02077AEE */) {} // 0x0000000185F3E9E0-0x0000000185F3EA70
		public override void OnDeselect(BaseEventData eventData) {} // 0x000000018646DBCC-0x000000018646DBD4
		public virtual void OnSubmit(BaseEventData eventData) {} // 0x000000018BE15D54-0x000000018BE15E28
		private void EnforceContentType() {} // 0x00000001817E31E0-0x00000001817E3200
		private void SetTextComponentWrapMode() {} // 0x000000018BE15CB8-0x000000018BE15D54
		private void SetTextComponentRichTextMode() {} // 0x000000018A1CE150-0x000000018A1CE280
		private void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) {} // 0x0000000184D713A0-0x0000000184D713E0
		private void SetToCustom() {} // 0x0000000184D70F90-0x0000000184D70FD0
		private void SetToCustom(CharacterValidation characterValidation) {} // 0x0000000184D713E0-0x0000000184D71420
		protected override void DoStateTransition(SelectionState state, bool instant) {} // 0x0000000184D71420-0x0000000184D71460
		public virtual void CalculateLayoutInputHorizontal() {} // 0x0000000184D714C0-0x0000000184D71500
		public virtual void CalculateLayoutInputVertical() {} // 0x0000000181378230-0x0000000181378240
		public void SetGlobalPointSize(float pointSize) {} // 0x000000018BE1CC74-0x000000018BE1CED0
		public void SetGlobalFontAsset(TMP_FontAsset fontAsset) {} // 0x0000000181377E40-0x0000000181377E50
	}

	internal static class SetPropertyUtility // TypeDefIndex: 53185
	{
		// Methods
		public static bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue) => default; // 0x000000018BE15E28-0x000000018BE15E68
		public static bool SetEquatableStruct<T>(ref ref T currentValue, T newValue)
			where T : IEquatable<T> => default;
		public static bool SetStruct<T>(ref ref T currentValue, T newValue)
			where T : struct => default;
		public static bool SetClass<T>(ref ref T currentValue, T newValue)
			where T : class => default;
	}

	[Serializable]
	public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 53186
	{
		// Constructors
		protected TMP_InputValidator() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public abstract char Validate(ref string text, ref int pos, char ch);
	}

	public struct TMP_LineInfo // TypeDefIndex: 53187
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

	internal static class TMP_ListPool<T> // TypeDefIndex: 53189
	{
		// Fields
		private static readonly TMP_ObjectPool<List<T>> s_ListPool;
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53188
		{
			// Fields
			public static readonly __c<T> __9;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal void _.cctor_b__3_0(List<T> l) {}
		}
	
		// Constructors
		static TMP_ListPool() {}
	
		// Methods
		public static List<T> Get() => default;
		public static void Release(List<T> toRelease) {}
	}

	public static class TMP_MaterialManager // TypeDefIndex: 53196
	{
		// Fields
		private static List<MaskingMaterial> m_materialList; // 0x00
		private static Dictionary<long, FallbackMaterial> m_fallbackMaterials; // 0x08
		private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
		private static List<FallbackMaterial> m_fallbackCleanupList; // 0x18
		private static bool isFallbackListDirty; // 0x20
		private static string s_overlayShaderKeyword; // 0x28
	
		// Properties
		public static string overlayShaderKeyword { get; set; } // 0x000000018BE1BBA8-0x000000018BE1BDFC 0x0000000184EC2F50-0x0000000184EC3180
	
		// Nested types
		private class FallbackMaterial // TypeDefIndex: 53190
		{
			// Fields
			public long fallbackID; // 0x10
			public Material sourceMaterial; // 0x18
			internal int sourceMaterialCRC; // 0x20
			public Material fallbackMaterial; // 0x28
			public int count; // 0x30
	
			// Constructors
			public FallbackMaterial() {} // 0x00000001845A1EF0-0x00000001845A2140
		}
	
		private class MaskingMaterial // TypeDefIndex: 53191
		{
			// Fields
			public Material baseMaterial; // 0x10
			public Material stencilMaterial; // 0x18
			public int count; // 0x20
			public int stencilID; // 0x24
	
			// Constructors
			public MaskingMaterial() {} // 0x000000018515E420-0x000000018515E4A0
		}
	
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 53192
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x000000018BE1CB78-0x000000018BE1CBC8
	
			// Methods
			internal bool _GetBaseMaterial_b__0(MaskingMaterial item) => default; // 0x000000018BE1CBC8-0x000000018BE1CC28
		}
	
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 53193
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass15_0() {} // 0x000000018BE1BDFC-0x000000018BE1C174
	
			// Methods
			internal bool _AddMaskingMaterial_b__0(MaskingMaterial item) => default; // 0x000000018BE1C618-0x000000018BE1C80C
		}
	
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 53194
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0() {} // 0x000000018BE1B73C-0x000000018BE1B888
	
			// Methods
			internal bool _RemoveStencilMaterial_b__0(MaskingMaterial item) => default; // 0x000000018BE1CAC0-0x000000018BE1CB78
		}
	
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 53195
		{
			// Fields
			public Material baseMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass17_0() {} // 0x000000018BE1AFAC-0x000000018BE1B1E8
	
			// Methods
			internal bool _ReleaseBaseMaterial_b__0(MaskingMaterial item) => default; // 0x000000018BE1C984-0x000000018BE1CAC0
		}
	
		// Constructors
		static TMP_MaterialManager() {} // 0x000000018BE1C174-0x000000018BE1C618
	
		// Methods
		private static void OnPreRender() {} // 0x000000018BE1B1E8-0x000000018BE1B358
		public static Material GetStencilMaterial(Material baseMaterial, int stencilID) => default; // 0x000000018BE1B5F0-0x000000018BE1B73C
		public static void ReleaseStencilMaterial(Material stencilMaterial) {} // 0x000000018BE1B888-0x000000018BE1BBA8
		public static Material GetBaseMaterial(Material stencilMaterial) => default; // 0x00000001845138C0-0x0000000184513D40
		public static Material SetStencil(Material material, int stencilID) => default; // 0x00000001845135A0-0x00000001845136E0
		public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) {} // 0x000000018BE1C80C-0x000000018BE1C984
		public static void RemoveStencilMaterial(Material stencilMaterial) {} // 0x000000018515E4A0-0x000000018515E6E0
		public static void ReleaseBaseMaterial(Material baseMaterial) {} // 0x00000001845136E0-0x00000001845138C0
		public static void ClearMaterials() {} // 0x000000018BE1B358-0x000000018BE1B5F0
		public static int GetStencilID(GameObject obj) => default; // 0x0000000185492010-0x0000000185492020
		public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) => default; // 0x0000000185492010-0x0000000185492020
		private static Transform FindRootSortOverrideCanvas(Transform start) => default; // 0x0000000185492010-0x0000000185492020
		internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex) => default; // 0x000000018BE33454-0x000000018BE334B8
		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) => default; // 0x0000000185492010-0x0000000185492020
		public static void AddFallbackMaterialReference(Material targetMaterial) {} // 0x000000018BE334B8-0x000000018BE3351C
		public static void RemoveFallbackMaterialReference(Material targetMaterial) {} // 0x0000000185492010-0x0000000185492020
		public static void CleanupFallbackMaterials() {} // 0x000000018BE3351C-0x000000018BE33580
		public static void ReleaseFallbackMaterial(Material fallbackMaterial) {} // 0x0000000185492010-0x0000000185492020
		public static void CopyMaterialPresetProperties(Material source, Material destination) {} // 0x000000018BE33580-0x000000018BE335E4
	}

	public enum VertexSortingOrder // TypeDefIndex: 53197
	{
		Normal = 0,
		Reverse = 1
	}

	public struct TMP_MeshInfo : IDisposable // TypeDefIndex: 53198
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
		public TMP_MeshInfo(Mesh mesh, int size) {
			this.mesh = default;
			vertexCount = default;
			vertices = default;
			normals = default;
			tangents = default;
			uvs0 = default;
			uvs2 = default;
			colors32 = default;
			triangles = default;
			material = default;
		} // 0x00000001842B3F20-0x00000001842B4550
		public TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric) {
			this.mesh = default;
			vertexCount = default;
			vertices = default;
			normals = default;
			tangents = default;
			uvs0 = default;
			uvs2 = default;
			colors32 = default;
			triangles = default;
			material = default;
		} // 0x000000018BE28E3C-0x000000018BE29804
		static TMP_MeshInfo() {
			s_DefaultColor = default;
			s_DefaultNormal = default;
			s_DefaultTangent = default;
			s_DefaultBounds = default;
		} // 0x0000000185EFA110-0x0000000185EFA1B0
	
		// Methods
		public void ResizeMeshInfo(int size) {} // 0x0000000184970230-0x00000001849707B0
		public void ResizeMeshInfo(int size, bool isVolumetric) {} // 0x000000018BE278E8-0x000000018BE2844C
		public void Clear() {} // 0x000000018BE27858-0x000000018BE278E8
		public void Clear(bool uploadChanges) {} // 0x0000000183FE2360-0x0000000183FE2530
		public void ClearUnusedVertices() {} // 0x0000000185D4BCA0-0x0000000185D4BCE0
		public void ClearUnusedVertices(int startIndex) {} // 0x000000018BE2777C-0x000000018BE277B0
		public void ClearUnusedVertices(int startIndex, bool updateMesh) {} // 0x000000018BE277B0-0x000000018BE27858
		public void SortGeometry(VertexSortingOrder order) {} // 0x000000018BE2844C-0x000000018BE284F0
		public void SortGeometry(IList<int> sortingOrder) {} // 0x000000018BE284F0-0x000000018BE285EC
		public void SwapVertexData(int src, int dst) {} // 0x000000018BE285EC-0x000000018BE28E3C
		public void Dispose() {} // 0x0000000184244BF0-0x0000000184244E10
	}

	internal class TMP_ObjectPool<T> // TypeDefIndex: 53199
		where T : new()
	{
		// Fields
		private readonly Stack<T> m_Stack;
		private readonly UnityAction<T> m_ActionOnGet;
		private readonly UnityAction<T> m_ActionOnRelease;
		private int _countAll_k__BackingField;
	
		// Properties
		public int countAll { get; private set; }
		public int countActive { get => default; }
		public int countInactive { get => default; }
	
		// Constructors
		public TMP_ObjectPool() {} // Dummy constructor
		public TMP_ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) {}
	
		// Methods
		public T Get() => default;
		public void Release(T element) {}
	}

	public class TMP_ResourceManager // TypeDefIndex: 53200
	{
		// Fields
		private static readonly TMP_ResourceManager s_instance; // 0x00
		private static TMP_Settings s_TextSettings; // 0x08
		private static readonly List<TMP_FontAsset> s_FontAssetReferences; // 0x10
		private static readonly Dictionary<int, TMP_FontAsset> s_FontAssetReferenceLookup; // 0x18
	
		// Constructors
		static TMP_ResourceManager() {} // 0x000000018BE29B6C-0x000000018BE29CA0
		public TMP_ResourceManager() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		internal static TMP_Settings GetTextSettings() => default; // 0x000000018BE29900-0x000000018BE299F0
		public static void AddFontAsset(TMP_FontAsset fontAsset) {} // 0x000000018BE29804-0x000000018BE29900
		public static bool TryGetFontAsset(int hashcode, out TMP_FontAsset fontAsset) {
			fontAsset = default;
			return default;
		} // 0x000000018BE29AE4-0x000000018BE29B6C
		internal static void RebuildFontAssetCache(int instanceID) {} // 0x000000018BE299F0-0x000000018BE29AE4
	}

	internal enum MarkupTag // TypeDefIndex: 53201
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

	public enum TagValueType // TypeDefIndex: 53202
	{
		None = 0,
		NumericalValue = 1,
		StringValue = 2,
		ColorValue = 4
	}

	public enum TagUnitType // TypeDefIndex: 53203
	{
		Pixels = 0,
		FontUnits = 1,
		Percentage = 2
	}

	internal static class CodePoint // TypeDefIndex: 53204
	{
		// Fields
		public const uint SPACE = 32; // Metadata: 0x02077D2E
		public const uint DOUBLE_QUOTE = 34; // Metadata: 0x02077D2F
		public const uint NUMBER_SIGN = 35; // Metadata: 0x02077D30
		public const uint PERCENTAGE = 37; // Metadata: 0x02077D31
		public const uint PLUS = 43; // Metadata: 0x02077D32
		public const uint MINUS = 45; // Metadata: 0x02077D33
		public const uint PERIOD = 46; // Metadata: 0x02077D34
		public const uint HYPHEN_MINUS = 45; // Metadata: 0x02077D35
		public const uint SOFT_HYPHEN = 173; // Metadata: 0x02077D36
		public const uint HYPHEN = 8208; // Metadata: 0x02077D38
		public const uint NON_BREAKING_HYPHEN = 8209; // Metadata: 0x02077D3A
		public const uint ZERO_WIDTH_SPACE = 8203; // Metadata: 0x02077D3C
		public const uint RIGHT_SINGLE_QUOTATION = 8217; // Metadata: 0x02077D3E
		public const uint APOSTROPHE = 39; // Metadata: 0x02077D40
		public const uint WORD_JOINER = 8288; // Metadata: 0x02077D41
		public const uint HIGH_SURROGATE_START = 55296; // Metadata: 0x02077D43
		public const uint HIGH_SURROGATE_END = 56319; // Metadata: 0x02077D47
		public const uint LOW_SURROGATE_START = 56320; // Metadata: 0x02077D4B
		public const uint LOW_SURROGATE_END = 57343; // Metadata: 0x02077D4F
		public const uint UNICODE_PLANE01_START = 65536; // Metadata: 0x02077D53
	}

	public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 53205
	{
		// Fields
		public bool isSelected; // 0x18
	
		// Constructors
		public TMP_ScrollbarEventHandler() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void OnPointerClick(PointerEventData eventData) {} // 0x000000018BE29CF8-0x000000018BE29D4C
		public void OnSelect(BaseEventData eventData) {} // 0x000000018BE29D4C-0x000000018BE29DA4
		public void OnDeselect(BaseEventData eventData) {} // 0x000000018BE29CA0-0x000000018BE29CF8
	}

	public class TMP_SelectionCaret : MaskableGraphic // TypeDefIndex: 53206
	{
		// Constructors
		public TMP_SelectionCaret() {} // 0x0000000185FADBF0-0x0000000185FADC00
	
		// Methods
		public override void Cull(Rect clipRect, bool validRect) {} // 0x000000018422D230-0x000000018422D2D0
		protected override void UpdateGeometry() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class TMP_Settings : ScriptableObject // TypeDefIndex: 53208
	{
		// Fields
		private static TMP_Settings s_Instance; // 0x00
		private bool m_enableWordWrapping; // 0x18
		private bool m_enableKerning; // 0x19
		private bool m_enableExtraPadding; // 0x1A
		private bool m_enableTintAllSprites; // 0x1B
		private bool m_enableParseEscapeCharacters; // 0x1C
		private bool m_EnableRaycastTarget; // 0x1D
		private bool m_GetFontFeaturesAtRuntime; // 0x1E
		private int m_missingGlyphCharacter; // 0x20
		private bool m_warningsDisabled; // 0x24
		private TMP_FontAsset m_defaultFontAsset; // 0x28
		private string m_defaultFontAssetPath; // 0x30
		private float m_defaultFontSize; // 0x38
		private float m_defaultAutoSizeMinRatio; // 0x3C
		private float m_defaultAutoSizeMaxRatio; // 0x40
		private Vector2 m_defaultTextMeshProTextContainerSize; // 0x44
		private Vector2 m_defaultTextMeshProUITextContainerSize; // 0x4C
		private bool m_autoSizeTextContainer; // 0x54
		private bool m_IsTextObjectScaleStatic; // 0x55
		private List<TMP_FontAsset> m_fallbackFontAssets; // 0x58
		private bool m_matchMaterialPreset; // 0x60
		private TMP_SpriteAsset m_defaultSpriteAsset; // 0x68
		private string m_defaultSpriteAssetPath; // 0x70
		private bool m_enableEmojiSupport; // 0x78
		private uint m_MissingCharacterSpriteUnicode; // 0x7C
		private string m_defaultColorGradientPresetsPath; // 0x80
		private TMP_StyleSheet m_defaultStyleSheet; // 0x88
		private string m_StyleSheetsResourcePath; // 0x90
		private TextAsset m_leadingCharacters; // 0x98
		private TextAsset m_followingCharacters; // 0xA0
		private LineBreakingTable m_linebreakingRules; // 0xA8
		private bool m_UseModernHangulLineBreakingRules; // 0xB0
		public IFontAssetLoader dynamicFontAssetLoader; // 0xB8
	
		// Properties
		public static string version { get => default; } // 0x000000018BE2A378-0x000000018BE2A398 
		public static bool enableWordWrapping { get => default; } // 0x000000018BE2A2F8-0x000000018BE2A318 
		public static bool enableKerning { get => default; } // 0x000000018BE2A2D8-0x000000018BE2A2F8 
		public static bool enableExtraPadding { get => default; } // 0x000000018BE2A358-0x000000018BE2A378 
		public static bool enableTintAllSprites { get => default; } // 0x000000018BE2A318-0x000000018BE2A338 
		public static bool enableParseEscapeCharacters { get => default; } // 0x000000018BE2A338-0x000000018BE2A358 
		public static bool enableRaycastTarget { get => default; } // 0x0000000184011790-0x00000001840117B0 
		public static bool getFontFeaturesAtRuntime { get => default; } // 0x000000018BE2A440-0x000000018BE2A460 
		public static int missingGlyphCharacter { get => default; set {} } // 0x000000018BE2A560-0x000000018BE2A584 0x000000018BE2A4D4-0x000000018BE2A4F4
		public static bool warningsDisabled { get => default; } // 0x000000018BE2A198-0x000000018BE2A1B8 
		public static TMP_FontAsset defaultFontAsset { get => default; } // 0x000000018BE2A178-0x000000018BE2A198 
		public static string defaultFontAssetPath { get => default; } // 0x000000018BE2A1B8-0x000000018BE2A1D8 
		public static float defaultFontSize { get => default; } // 0x000000018BE2A238-0x000000018BE2A258 
		public static float defaultTextAutoSizingMinRatio { get => default; } // 0x000000018BE2A218-0x000000018BE2A238 
		public static float defaultTextAutoSizingMaxRatio { get => default; } // 0x000000018BE2A258-0x000000018BE2A288 
		public static Vector2 defaultTextMeshProTextContainerSize { get => default; } // 0x000000018BE2A288-0x000000018BE2A2B8 
		public static Vector2 defaultTextMeshProUITextContainerSize { get => default; } // 0x000000018BE2A134-0x000000018BE2A154 
		public static bool autoSizeTextContainer { get => default; } // 0x000000018BE2A3DC-0x000000018BE2A3FC 
		public static bool isTextObjectScaleStatic { get => default; set {} } // 0x000000018BE2A518-0x000000018BE2A53C 0x000000018BE2A398-0x000000018BE2A3B8
		public static List<TMP_FontAsset> fallbackFontAssets { get => default; } // 0x0000000185BB3820-0x0000000185BB3840 
		public static bool matchMaterialPreset { get => default; } // 0x000000018BE2A1F8-0x000000018BE2A218 
		public static TMP_SpriteAsset defaultSpriteAsset { get => default; } // 0x000000018BE2A1D8-0x000000018BE2A1F8 
		public static string defaultSpriteAssetPath { get => default; } // 0x000000018BE2A2B8-0x000000018BE2A2D8 
		public static bool enableEmojiSupport { get => default; set {} } // 0x000000018BE2A4F4-0x000000018BE2A518 0x000000018BE2A420-0x000000018BE2A440
		public static uint missingCharacterSpriteUnicode { get => default; set {} } // 0x000000018BE2A53C-0x000000018BE2A560 0x000000018BE2A154-0x000000018BE2A178
		public static string defaultColorGradientPresetsPath { get => default; } // 0x0000000184685740-0x0000000184685770 
		public static TMP_StyleSheet defaultStyleSheet { get => default; } // 0x000000018BE2A460-0x000000018BE2A484 
		public static string styleSheetsResourcePath { get => default; } // 0x000000018BE2A3FC-0x000000018BE2A420 
		public static TextAsset leadingCharacters { get => default; } // 0x000000018BE2A3B8-0x000000018BE2A3DC 
		public static TextAsset followingCharacters { get => default; } // 0x0000000184685770-0x00000001846857C0 
		public static LineBreakingTable linebreakingRules { get => default; } // 0x000000018BE2A484-0x000000018BE2A4A8 
		public static bool useModernHangulLineBreakingRules { get => default; set {} } // 0x000000018BE2A584-0x000000018BE2A5AC 0x00000001846857C0-0x0000000184685930
		public static TMP_Settings instance { get => default; } // 0x000000018BE2A050-0x000000018BE2A134 
	
		// Nested types
		public class LineBreakingTable // TypeDefIndex: 53207
		{
			// Fields
			public Dictionary<int, char> leadingCharacters; // 0x10
			public Dictionary<int, char> followingCharacters; // 0x18
	
			// Constructors
			public LineBreakingTable() {} // 0x000000018BE2A4A8-0x000000018BE2A4D4
		}
	
		// Constructors
		public TMP_Settings() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static TMP_Settings LoadDefaultSettings() => default; // 0x000000018BE29F18-0x000000018BE29F78
		public static TMP_Settings GetSettings() => default; // 0x000000018BE29EAC-0x000000018BE29F18
		public static TMP_FontAsset GetFontAsset() => default; // 0x000000018BE29DA4-0x000000018BE29E40
		public static void ClearDefaultFontAsset() {} // 0x000000018BE29F78-0x000000018BE29FE4
		public static TMP_SpriteAsset GetSpriteAsset() => default; // 0x000000018BE29FE4-0x000000018BE2A050
		public static TMP_StyleSheet GetStyleSheet() => default; // 0x00000001854A8F40-0x00000001854A9090
		public static void LoadLinebreakingRules() {} // 0x000000018BE29E40-0x000000018BE29EAC
		public static IFontAssetLoader GetDynamicFallbackFontAssetLoader() => default; // 0x00000001854A9090-0x00000001854A9190
		private static Dictionary<int, char> GetCharacters(TextAsset file) => default; // 0x0000000185FAE7E0-0x0000000185FAE7F0
	}

	public static class ShaderUtilities // TypeDefIndex: 53209
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
		internal static Shader ShaderRef_MobileSDF { get; } // 0x000000018BE274F4-0x000000018BE275E0 
		internal static Shader ShaderRef_MobileBitmap { get; } // 0x000000018BE27408-0x000000018BE274F4 
	
		// Constructors
		static ShaderUtilities() {} // 0x0000000185AD6F20-0x0000000185AD72A0
	
		// Methods
		public static void GetShaderPropertyIDs() {} // 0x00000001845E7650-0x00000001845E8200
		public static void UpdateShaderRatios(Material mat) {} // 0x00000001845E9900-0x00000001845E9F70
		public static Vector4 GetFontExtent(Material material) => default; // 0x000000018BE2695C-0x000000018BE2697C
		public static bool IsMaskingEnabled(Material material) => default; // 0x00000001845E8360-0x00000001845E8570
		public static float GetPadding(Material material, bool enableExtraPadding, bool isBold) => default; // 0x00000001845E8C30-0x00000001845E94A0
		public static float GetPadding(Material[] materials, bool enableExtraPadding, bool isBold) => default; // 0x000000018BE2697C-0x000000018BE27408
	}

	[Serializable]
	public class TMP_Sprite : TMP_TextElement_Legacy // TypeDefIndex: 53210
	{
		// Fields
		public string name; // 0x38
		public int hashCode; // 0x40
		public int unicode; // 0x44
		public Vector2 pivot; // 0x48
		public Sprite sprite; // 0x50
	
		// Constructors
		public TMP_Sprite() {} // 0x0000000185492010-0x0000000185492020
	}

	public class TMP_SpriteAnimator : MonoBehaviour // TypeDefIndex: 53212
	{
		// Fields
		private Dictionary<int, bool> m_animations; // 0x18
		private TMP_Text m_TextComponent; // 0x20
	
		// Nested types
		private sealed class _DoSpriteAnimationInternal_d__7 : IEnumerator<object> // TypeDefIndex: 53211
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018BE2A770-0x000000018BE2A7C0 
			object IEnumerator.Current { get => default; } // 0x000000018BE2A5F4-0x000000018BE2A698 
	
			// Constructors
			public _DoSpriteAnimationInternal_d__7() {} // Dummy constructor
			public _DoSpriteAnimationInternal_d__7(int __1__state) {} // 0x000000018BE2A5AC-0x000000018BE2A5F4
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x000000018BE2A698-0x000000018BE2A770
		}
	
		// Constructors
		public TMP_SpriteAnimator() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		private void Awake() {} // 0x000000018BE2A7C0-0x000000018BE2A844
		private void OnEnable() {} // 0x0000000181378230-0x0000000181378240
		private void OnDisable() {} // 0x0000000185492010-0x0000000185492020
		public void StopAllAnimations() {} // 0x000000018BE32AFC-0x000000018BE33408
		public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) => default; // 0x000000018BE33408-0x000000018BE33454
	}

	public class TMP_SpriteAsset : TMP_Asset // TypeDefIndex: 53214
	{
		// Fields
		internal Dictionary<int, int> m_NameLookup; // 0x30
		internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x38
		private string m_Version; // 0x40
		internal FaceInfo m_FaceInfo; // 0x48
		public Texture spriteSheet; // 0xA8
		private List<TMP_SpriteCharacter> m_SpriteCharacterTable; // 0xB0
		internal Dictionary<uint, TMP_SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
		private List<TMP_SpriteGlyph> m_SpriteGlyphTable; // 0xC0
		internal Dictionary<uint, TMP_SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
		public List<TMP_Sprite> spriteInfoList; // 0xD0
		public List<TMP_SpriteAsset> fallbackSpriteAssets; // 0xD8
		internal bool m_IsSpriteAssetLookupTablesDirty; // 0xE0
		private static HashSet<int> k_searchedSpriteAssets; // 0x00
	
		// Properties
		public string version { get => default; internal set {} } // 0x000000018BE2C0A4-0x000000018BE2C0D4 0x0000000184784C70-0x0000000184784C90
		public FaceInfo faceInfo { get => default; internal set {} } // 0x000000018BE2C074-0x000000018BE2C0A4 0x0000000187A47500-0x0000000187A47514
		public List<TMP_SpriteCharacter> spriteCharacterTable { get => default; internal set {} } // 0x0000000181B388F0-0x0000000181B38900 0x0000000187A47C1C-0x0000000187A47C30
		public Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable { get => default; internal set {} } // 0x000000018BE2A844-0x000000018BE2A8B4 0x000000018BE2A8B4-0x000000018BE2A98C
		public List<TMP_SpriteGlyph> spriteGlyphTable { get => default; internal set {} } // 0x000000018BE2B734-0x000000018BE2BC70 0x000000018BE2A98C-0x000000018BE2AA08
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53213
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<TMP_SpriteGlyph, uint> __9__40_0; // 0x08
			public static Func<TMP_SpriteCharacter, uint> __9__41_0; // 0x10
	
			// Constructors
			static __c() {} // 0x00000001813FF010-0x00000001813FF020
			public __c() {} // 0x0000000185F05C80-0x0000000185F05C90
	
			// Methods
			internal uint _SortGlyphTable_b__40_0(TMP_SpriteGlyph item) => default; // 0x0000000185FE60D0-0x0000000185FE6110
			internal uint _SortCharacterTable_b__41_0(TMP_SpriteCharacter c) => default; // 0x000000018BE2C0D4-0x000000018BE2C114
		}
	
		// Constructors
		public TMP_SpriteAsset() {} // 0x000000018BE15B00-0x000000018BE15B18
	
		// Methods
		private void Awake() {} // 0x000000018BE2AA74-0x000000018BE2AB00
		private Material GetDefaultSpriteMaterial() => default; // 0x000000018BE2AA08-0x000000018BE2AA74
		public void UpdateLookupTables() {} // 0x000000018BE2B224-0x000000018BE2B43C
		public int GetSpriteIndexFromHashcode(int hashCode) => default; // 0x000000018BE2B01C-0x000000018BE2B174
		public int GetSpriteIndexFromUnicode(uint unicode) => default; // 0x000000018BE2B174-0x000000018BE2B224
		public int GetSpriteIndexFromName(string name) => default; // 0x000000018BE2AD08-0x000000018BE2B01C
		public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x000000018BE2ABB0-0x000000018BE2AD08
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x000000018BE2AB00-0x000000018BE2ABB0
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x000000018BE2B5C8-0x000000018BE2B734
		public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x000000018BE2B43C-0x000000018BE2B5A8
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x000000018BE2B5A8-0x000000018BE2B5C8
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x000000018BE2BC70-0x000000018BE2BFA0
		public void SortGlyphTable() {} // 0x000000018BE2BFA0-0x000000018BE2C074
		internal void SortCharacterTable() {} // 0x000000018BE335E4-0x000000018BE33648
		internal void SortGlyphAndCharacterTables() {} // 0x0000000185492010-0x0000000185492020
		private void UpgradeSpriteAsset() {} // 0x000000018B584038-0x000000018B584050
	}

	[Serializable]
	public class TMP_SpriteCharacter : TMP_TextElement // TypeDefIndex: 53215
	{
		// Fields
		private string m_Name; // 0x30
		private int m_HashCode; // 0x38
	
		// Properties
		public string name { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x000000018BE2C1D8-0x000000018BE2C24C
		public int hashCode { get => default; } // 0x00000001813E5E30-0x00000001813E5E40 
	
		// Constructors
		public TMP_SpriteCharacter() {} // 0x0000000185FE6110-0x0000000185FE6120
		public TMP_SpriteCharacter(uint unicode, TMP_SpriteGlyph glyph) {} // 0x000000018BE2C154-0x000000018BE2C190
		public TMP_SpriteCharacter(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph) {} // 0x000000018BE2C190-0x000000018BE2C1D8
		internal TMP_SpriteCharacter(uint unicode, uint glyphIndex) {} // 0x000000018BE2C114-0x000000018BE2C154
	}

	[Serializable]
	public class TMP_SpriteGlyph : Glyph // TypeDefIndex: 53216
	{
		// Fields
		public Sprite sprite; // 0x48
	
		// Constructors
		public TMP_SpriteGlyph() {} // 0x000000018BE2C32C-0x000000018BE2C334
		public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) {} // 0x000000018BE2C2C4-0x000000018BE2C32C
		public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex, Sprite sprite) {} // 0x000000018BE2C24C-0x000000018BE2C2C4
	}

	[Serializable]
	public class TMP_Style // TypeDefIndex: 53217
	{
		// Fields
		internal static TMP_Style k_NormalStyle; // 0x00
		private string m_Name; // 0x10
		private int m_HashCode; // 0x18
		private string m_OpeningDefinition; // 0x20
		private string m_ClosingDefinition; // 0x28
		private int[] m_OpeningTagArray; // 0x30
		private int[] m_ClosingTagArray; // 0x38
		internal uint[] m_OpeningTagUnicodeArray; // 0x40
		internal uint[] m_ClosingTagUnicodeArray; // 0x48
	
		// Properties
		public static TMP_Style NormalStyle { get => default; } // 0x000000018BE2C3D8-0x000000018BE2C4B4 
		public string name { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x000000018BE2C4C0-0x000000018BE2C4FC
		public int hashCode { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x000000018BE2C4B4-0x000000018BE2C4C0
		public string styleOpeningDefinition { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public string styleClosingDefinition { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
		public int[] styleOpeningTagArray { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
		public int[] styleClosingTagArray { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
	
		// Constructors
		public TMP_Style() {} // Dummy constructor
		internal TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition) {} // 0x00000001852634D0-0x0000000185263580
	
		// Methods
		public void RefreshStyle() {} // 0x0000000185263850-0x0000000185263A80
	}

	[Serializable]
	public class TMP_StyleSheet : ScriptableObject // TypeDefIndex: 53218
	{
		// Fields
		private List<TMP_Style> m_StyleList; // 0x18
		private Dictionary<int, TMP_Style> m_StyleLookupDictionary; // 0x20
	
		// Properties
		internal List<TMP_Style> styles { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Constructors
		public TMP_StyleSheet() {} // 0x0000000185F4B690-0x0000000185F4B720
	
		// Methods
		private void Reset() {} // 0x000000018BE2C3D0-0x000000018BE2C3D8
		public TMP_Style GetStyle(int hashCode) => default; // 0x0000000184685930-0x0000000184685A30
		public TMP_Style GetStyle(string name) => default; // 0x000000018BE2C334-0x000000018BE2C3D0
		public void RefreshStyles() {} // 0x000000018BE2C3D0-0x000000018BE2C3D8
		private void LoadStyleDictionaryInternal() {} // 0x0000000185263580-0x0000000185263850
	}

	public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 53219
	{
		// Fields
		private TMP_FontAsset m_fontAsset; // 0x18
		private TMP_SpriteAsset m_spriteAsset; // 0x20
		private Material m_material; // 0x28
		private Material m_sharedMaterial; // 0x30
		private Material m_fallbackMaterial; // 0x38
		private Material m_fallbackSourceMaterial; // 0x40
		private bool m_isDefaultMaterial; // 0x48
		private float m_padding; // 0x4C
		private Renderer m_renderer; // 0x50
		private MeshFilter m_meshFilter; // 0x58
		private Mesh m_mesh; // 0x60
		private TextMeshPro m_TextComponent; // 0x68
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0x70
	
		// Properties
		public TMP_FontAsset fontAsset { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public TMP_SpriteAsset spriteAsset { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public Material material { get => default; set {} } // 0x000000018BE2D6BC-0x000000018BE2D6C8 0x000000018BE2DA78-0x000000018BE2DB08
		public Material sharedMaterial { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x000000018BE2DB08-0x000000018BE2DB10
		public Material fallbackMaterial { get => default; set {} } // 0x00000001813ECBC0-0x00000001813ECBD0 0x000000018BE2D970-0x000000018BE2DA78
		public Material fallbackSourceMaterial { get => default; set {} } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public bool isDefaultMaterial { get => default; set {} } // 0x0000000185FB0750-0x0000000185FB0760 0x0000000185FB0770-0x0000000185FB0780
		public float padding { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public Renderer renderer { get => default; } // 0x000000018BE2D868-0x000000018BE2D8EC 
		public MeshFilter meshFilter { get => default; } // 0x000000018BE2D6C8-0x000000018BE2D7BC 
		public Mesh mesh { get => default; set {} } // 0x000000018BE2D7BC-0x000000018BE2D868 0x0000000185AE8FE0-0x0000000185AE8FF0
		public TMP_Text textComponent { get => default; } // 0x000000018BE2D8EC-0x000000018BE2D970 
	
		// Constructors
		public TMP_SubMesh() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) => default; // 0x000000018BE2CAA8-0x000000018BE2CE08
		private void OnEnable() {} // 0x000000018BE2D310-0x000000018BE2D414
		private void OnDisable() {} // 0x000000018BE2D26C-0x000000018BE2D310
		private void OnDestroy() {} // 0x000000018BE2D154-0x000000018BE2D26C
		public void DestroySelf() {} // 0x000000018BE2CEBC-0x000000018BE2CF14
		private Material GetMaterial(Material mat) => default; // 0x000000018BE2CF14-0x000000018BE2D040
		private Material CreateMaterialInstance(Material source) => default; // 0x000000018BE2CE08-0x000000018BE2CEBC
		private Material GetSharedMaterial() => default; // 0x000000018BE2D0C0-0x000000018BE2D154
		private void SetSharedMaterial(Material mat) {} // 0x000000018BE2D41C-0x000000018BE2D450
		public float GetPaddingForMaterial() => default; // 0x000000018BE2D040-0x000000018BE2D0C0
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) {} // 0x000000018BE2D648-0x000000018BE2D6BC
		public void SetVerticesDirty() {} // 0x000000018BE2D450-0x000000018BE2D4E0
		public void SetMaterialDirty() {} // 0x000000018BE2D414-0x000000018BE2D41C
		protected void UpdateMaterial() {} // 0x000000018BE2D4E0-0x000000018BE2D648
	}

	public class TMP_SubMeshUI : MaskableGraphic // TypeDefIndex: 53220
	{
		// Fields
		private TMP_FontAsset m_fontAsset; // 0xE8
		private TMP_SpriteAsset m_spriteAsset; // 0xF0
		private Material m_material; // 0xF8
		private Material m_sharedMaterial; // 0x100
		private Material m_fallbackMaterial; // 0x108
		private Material m_fallbackSourceMaterial; // 0x110
		private bool m_isDefaultMaterial; // 0x118
		private float m_padding; // 0x11C
		private Mesh m_mesh; // 0x120
		private TextMeshProUGUI m_TextComponent; // 0x128
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0x130
		private bool m_materialDirty; // 0x131
		private int m_materialReferenceIndex; // 0x134
		private Transform m_RootCanvasTransform; // 0x138
	
		// Properties
		public TMP_FontAsset fontAsset { get => default; set {} } // 0x0000000185FB2360-0x0000000185FB2370 0x0000000187A47730-0x0000000187A47744
		public TMP_SpriteAsset spriteAsset { get => default; set {} } // 0x0000000185FB87A0-0x0000000185FB87B0 0x0000000187A47A14-0x0000000187A47A28
		public override Texture mainTexture { get => default; } // 0x000000018BE2C904-0x000000018BE2C9A8 
		public override Material material { get => default; set {} } // 0x000000018BE2C9A8-0x000000018BE2C9B8 0x000000018BE2C9B8-0x000000018BE2CAA0
		public Material sharedMaterial { get => default; set {} } // 0x0000000185FB1CB0-0x0000000185FB1CC0 0x000000018BE2CAA0-0x000000018BE2CAA8
		public Material fallbackMaterial { get => default; set {} } // 0x0000000181ABEDF0-0x0000000181ABEE00 0x0000000183FCA1E0-0x0000000183FCA2F0
		public Material fallbackSourceMaterial { get => default; set {} } // 0x0000000185FB8600-0x0000000185FB8610 0x00000001864735E0-0x00000001864735F4
		public override Material materialForRendering { get => default; } // 0x0000000184EC2E70-0x0000000184EC2EE0 
		public bool isDefaultMaterial { get => default; set {} } // 0x0000000185FB9360-0x0000000185FB9370 0x0000000185FBB950-0x0000000185FBB960
		public float padding { get => default; set {} } // 0x0000000185FB1080-0x0000000185FB1090 0x0000000185FE6120-0x0000000185FE6130
		public Mesh mesh { get => default; set {} } // 0x0000000184132A70-0x0000000184132B60 0x0000000186473590-0x00000001864735A4
		public TMP_Text textComponent { get => default; } // 0x00000001858C35C0-0x00000001858C3640 
	
		// Constructors
		public TMP_SubMeshUI() {} // 0x0000000185FADBF0-0x0000000185FADC00
	
		// Methods
		public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) => default; // 0x0000000183FCA4D0-0x0000000183FCA840
		protected override void OnEnable() {} // 0x0000000185F820A0-0x0000000185F820F0
		protected override void OnDisable() {} // 0x0000000184512F30-0x0000000184512FF0
		protected override void OnDestroy() {} // 0x000000018588CEA0-0x000000018588D010
		protected override void OnTransformParentChanged() {} // 0x000000018BE2C814-0x000000018BE2C858
		public override Material GetModifiedMaterial(Material baseMaterial) => default; // 0x0000000183FCA890-0x0000000183FCA940
		public float GetPaddingForMaterial() => default; // 0x0000000183FCA350-0x0000000183FCA3E0
		public float GetPaddingForMaterial(Material mat) => default; // 0x000000018BE2C6BC-0x000000018BE2C740
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) {} // 0x000000018BE2C888-0x000000018BE2C904
		public override void SetAllDirty() {} // 0x0000000185492010-0x0000000185492020
		public override void SetVerticesDirty() {} // 0x000000018588D010-0x000000018588D0D0
		public override void SetLayoutDirty() {} // 0x0000000185492010-0x0000000185492020
		public override void SetMaterialDirty() {} // 0x0000000185F377C0-0x0000000185F377F0
		public void SetPivotDirty() {} // 0x00000001845A83B0-0x00000001845A8430
		private Transform GetRootCanvasTransform() => default; // 0x000000018BE2C740-0x000000018BE2C7EC
		public override void Cull(Rect clipRect, bool validRect) {} // 0x0000000185492010-0x0000000185492020
		protected override void UpdateGeometry() {} // 0x0000000185492010-0x0000000185492020
		public override void Rebuild(CanvasUpdate update) {} // 0x000000018BE2C858-0x000000018BE2C888
		public void RefreshMaterial() {} // 0x000000018B4A7C74-0x000000018B4A7C84
		protected override void UpdateMaterial() {} // 0x00000001858C33F0-0x00000001858C35C0
		public override void RecalculateClipping() {} // 0x0000000183FCA880-0x0000000183FCA890
		private Material GetMaterial() => default; // 0x0000000185FB1CB0-0x0000000185FB1CC0
		private Material GetMaterial(Material mat) => default; // 0x000000018BE2C5B0-0x000000018BE2C6BC
		private Material CreateMaterialInstance(Material source) => default; // 0x000000018BE2C4FC-0x000000018BE2C5B0
		private Material GetSharedMaterial() => default; // 0x000000018BE2C7EC-0x000000018BE2C814
		private void SetSharedMaterial(Material mat) {} // 0x0000000183FCA2F0-0x0000000183FCA350
	}

	public interface ITextElement // TypeDefIndex: 53221
	{
		// Properties
		Material sharedMaterial { get; }
	
		// Methods
		void Rebuild(CanvasUpdate update);
		int GetInstanceID();
	}

	public enum TextAlignmentOptions // TypeDefIndex: 53222
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

	public enum HorizontalAlignmentOptions // TypeDefIndex: 53223
	{
		Left = 1,
		Center = 2,
		Right = 4,
		Justified = 8,
		Flush = 16,
		Geometry = 32
	}

	public enum VerticalAlignmentOptions // TypeDefIndex: 53224
	{
		Top = 256,
		Middle = 512,
		Bottom = 1024,
		Baseline = 2048,
		Geometry = 4096,
		Capline = 8192
	}

	public enum TextRenderFlags // TypeDefIndex: 53225
	{
		DontRender = 0,
		Render = 255
	}

	public enum TMP_TextElementType // TypeDefIndex: 53226
	{
		Character = 0,
		Sprite = 1,
		Image = 2
	}

	public enum MaskingTypes // TypeDefIndex: 53227
	{
		MaskOff = 0,
		MaskHard = 1,
		MaskSoft = 2
	}

	public enum TextOverflowModes // TypeDefIndex: 53228
	{
		Overflow = 0,
		Ellipsis = 1,
		Masking = 2,
		Truncate = 3,
		ScrollRect = 4,
		Page = 5,
		Linked = 6
	}

	public enum MaskingOffsetMode // TypeDefIndex: 53229
	{
		Percentage = 0,
		Pixel = 1
	}

	public enum TextureMappingOptions // TypeDefIndex: 53230
	{
		Character = 0,
		Line = 1,
		Paragraph = 2,
		MatchAspect = 3
	}

	public enum FontStyles // TypeDefIndex: 53231
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

	public enum FontWeight // TypeDefIndex: 53232
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

	public struct PhoneticCharSlot // TypeDefIndex: 53233
	{
		// Fields
		public TMP_FontAsset fontAsset; // 0x00
		public int materialIndex; // 0x08
		public Glyph glyph; // 0x10
	}

	public class PhoneticData // TypeDefIndex: 53234
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
		public PhoneticData() {} // 0x0000000185EEA980-0x0000000185EEA9E0
		static PhoneticData() {} // 0x0000000185EEA910-0x0000000185EEA980
	}

	public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 53241
	{
		// Fields
		protected string m_textForPopulate; // 0xE8
		protected string m_text; // 0xF0
		private bool m_IsTextBackingStringDirty; // 0xF8
		protected ITextPreprocessor m_TextPreprocessor; // 0x100
		protected bool m_isRightToLeft; // 0x108
		protected TMP_FontAsset m_serializedFontAsset; // 0x110
		protected TMP_FontAsset m_currentFontAsset; // 0x118
		protected bool m_isSDFShader; // 0x120
		protected Material m_serializedSharedMaterial; // 0x128
		protected Material m_currentMaterial; // 0x130
		protected static MaterialReference[] m_materialReferences; // 0x00
		protected static Dictionary<int, int> m_materialReferenceIndexLookup; // 0x08
		protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; // 0x10
		protected int m_currentMaterialIndex; // 0x138
		protected Material[] m_fontSharedMaterials; // 0x140
		protected Material m_fontMaterial; // 0x148
		protected Material[] m_fontMaterials; // 0x150
		protected bool m_isMaterialDirty; // 0x158
		protected Color32 m_fontColor32; // 0x15C
		protected UnityEngine.Color m_fontColor; // 0x160
		protected static Color32 s_colorWhite; // 0x68
		protected Color32 m_underlineColor; // 0x170
		protected Color32 m_strikethroughColor; // 0x174
		protected bool m_enableVertexGradient; // 0x178
		protected ColorMode m_colorMode; // 0x17C
		protected VertexGradient m_fontColorGradient; // 0x180
		protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1C0
		protected TMP_SpriteAsset m_spriteAsset; // 0x1C8
		protected bool m_tintAllSprites; // 0x1D0
		protected bool m_tintSprite; // 0x1D1
		protected Color32 m_spriteColor; // 0x1D4
		protected TMP_StyleSheet m_StyleSheet; // 0x1D8
		internal TMP_Style m_TextStyle; // 0x1E0
		protected int m_TextStyleHashCode; // 0x1E8
		protected bool m_overrideHtmlColors; // 0x1EC
		protected Color32 m_faceColor; // 0x1F0
		protected Color32 m_outlineColor; // 0x1F4
		protected float m_outlineWidth; // 0x1F8
		protected float m_fontSize; // 0x1FC
		protected float m_currentFontSize; // 0x200
		protected float m_fontSizeBase; // 0x204
		protected TMP_TextProcessingStack<float> m_sizeStack; // 0x208
		protected float m_imageWidth; // 0x228
		protected float m_imageHeight; // 0x22C
		protected float m_maxLineAscenderWithImage; // 0x230
		protected const float m_basePhoneticElementScale = 0.5f; // Metadata: 0x02077DFF
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
		protected bool m_showPhonetic; // 0x618
		protected int m_phoneticIndex; // 0x61C
		[NonSerialized]
		protected bool m_isInSetArraySizes; // 0x620
		protected bool m_needParseActionId; // 0x621
		protected FontWeight m_fontWeight; // 0x624
		protected FontWeight m_FontWeightInternal; // 0x628
		protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; // 0x630
		protected bool m_enableAutoSizing; // 0x650
		protected float m_maxFontSize; // 0x654
		protected float m_minFontSize; // 0x658
		protected int m_AutoSizeIterationCount; // 0x65C
		protected int m_AutoSizeMaxIterationCount; // 0x660
		protected bool m_IsAutoSizePointSizeSet; // 0x664
		protected float m_fontSizeMin; // 0x668
		protected float m_fontSizeMax; // 0x66C
		protected FontStyles m_fontStyle; // 0x670
		protected FontStyles m_FontStyleInternal; // 0x674
		protected TMP_FontStyleStack m_fontStyleStack; // 0x678
		protected bool m_isUsingBold; // 0x682
		protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x684
		protected VerticalAlignmentOptions m_VerticalAlignment; // 0x688
		protected TextAlignmentOptions m_textAlignment; // 0x68C
		protected HorizontalAlignmentOptions m_lineJustification; // 0x690
		protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x698
		protected Vector3[] m_textContainerLocalCorners; // 0x6B8
		protected float m_characterSpacing; // 0x6C0
		protected float m_cSpacing; // 0x6C4
		protected float m_monoSpacing; // 0x6C8
		protected float m_wordSpacing; // 0x6CC
		protected float m_lineSpacing; // 0x6D0
		protected float m_lineSpacingDelta; // 0x6D4
		protected float m_lineHeight; // 0x6D8
		protected bool m_IsDrivenLineSpacing; // 0x6DC
		protected float m_lineSpacingMax; // 0x6E0
		protected float m_paragraphSpacing; // 0x6E4
		protected float m_charWidthMaxAdj; // 0x6E8
		protected float m_charWidthAdjDelta; // 0x6EC
		protected bool m_enableWordWrapping; // 0x6F0
		protected bool m_isCharacterWrappingEnabled; // 0x6F1
		protected bool m_isNonBreakingSpace; // 0x6F2
		protected bool m_isIgnoringAlignment; // 0x6F3
		protected float m_wordWrappingRatios; // 0x6F4
		protected TextOverflowModes m_overflowMode; // 0x6F8
		protected int m_firstOverflowCharacterIndex; // 0x6FC
		protected TMP_Text m_linkedTextComponent; // 0x700
		internal TMP_Text parentLinkedComponent; // 0x708
		protected bool m_isTextTruncated; // 0x710
		protected bool m_enableKerning; // 0x711
		protected float m_GlyphHorizontalAdvanceAdjustment; // 0x714
		protected bool m_enableExtraPadding; // 0x718
		protected bool checkPaddingRequired; // 0x719
		protected bool m_isRichText; // 0x71A
		protected bool m_enableHyperlink; // 0x71B
		protected float m_richTextColorBlend; // 0x71C
		protected bool m_parseCtrlCharacters; // 0x720
		protected bool m_isOverlay; // 0x721
		protected bool m_isOrthographic; // 0x722
		protected bool m_isCullingEnabled; // 0x723
		protected bool m_isMaskingEnabled; // 0x724
		protected bool isMaskUpdateRequired; // 0x725
		protected bool m_ignoreCulling; // 0x726
		protected TextureMappingOptions m_horizontalMapping; // 0x728
		protected TextureMappingOptions m_verticalMapping; // 0x72C
		protected float m_uvLineOffset; // 0x730
		protected TextRenderFlags m_renderMode; // 0x734
		protected VertexSortingOrder m_geometrySortingOrder; // 0x738
		protected bool m_IsTextObjectScaleStatic; // 0x73C
		protected bool m_VertexBufferAutoSizeReduction; // 0x73D
		protected int m_firstVisibleCharacter; // 0x740
		protected int m_maxVisibleCharacters; // 0x744
		protected int m_maxVisibleWords; // 0x748
		protected int m_maxVisibleLines; // 0x74C
		protected bool m_useMaxVisibleDescender; // 0x750
		protected int m_pageToDisplay; // 0x754
		protected bool m_isNewPage; // 0x758
		protected Vector4 m_margin; // 0x75C
		protected float m_marginLeft; // 0x76C
		protected float m_marginRight; // 0x770
		protected float m_marginWidth; // 0x774
		protected float m_marginHeight; // 0x778
		protected float m_width; // 0x77C
		protected TMP_TextInfo m_textInfo; // 0x780
		protected bool m_havePropertiesChanged; // 0x788
		protected bool m_isUsingLegacyAnimationComponent; // 0x789
		protected Transform m_transform; // 0x790
		protected RectTransform m_rectTransform; // 0x798
		protected Vector2 m_PreviousRectTransformSize; // 0x7A0
		protected Vector2 m_PreviousPivotPosition; // 0x7A8
		private bool _autoSizeTextContainer_k__BackingField; // 0x7B0
		protected bool m_autoSizeTextContainer; // 0x7B1
		protected Mesh m_mesh; // 0x7B8
		protected bool m_isVolumetricText; // 0x7C0
		private static Func<int, string, TMP_FontAsset> OnFontAssetRequest; // 0x70
		private static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest; // 0x78
		private Action<TMP_TextInfo> OnPreRenderText; // 0x7C8
		protected TMP_SpriteAnimator m_spriteAnimator; // 0x7D0
		protected float m_flexibleHeight; // 0x7D8
		protected float m_flexibleWidth; // 0x7DC
		protected float m_minWidth; // 0x7E0
		protected float m_minHeight; // 0x7E4
		protected float m_maxWidth; // 0x7E8
		protected float m_maxHeight; // 0x7EC
		protected LayoutElement m_LayoutElement; // 0x7F0
		protected float m_preferredWidth; // 0x7F8
		protected float m_renderedWidth; // 0x7FC
		protected bool m_isPreferredWidthDirty; // 0x800
		protected float m_preferredHeight; // 0x804
		protected float m_renderedHeight; // 0x808
		protected bool m_isPreferredHeightDirty; // 0x80C
		protected bool m_isCalculatingPreferredValues; // 0x80D
		protected int m_layoutPriority; // 0x810
		protected bool m_isLayoutDirty; // 0x814
		[NonSerialized]
		protected bool m_isAwake; // 0x815
		internal bool m_isWaitingOnResourceLoad; // 0x816
		[NonSerialized]
		protected bool m_isInit; // 0x817
		internal TextInputSources m_inputSource; // 0x818
		protected float m_fontScaleMultiplier; // 0x81C
		private static char[] m_htmlTag; // 0x80
		protected static RichTextTagAttribute[] m_xmlAttribute; // 0x88
		private static float[] m_attributeParameterValues; // 0x90
		protected float tag_LineIndent; // 0x820
		protected float tag_Indent; // 0x824
		protected TMP_TextProcessingStack<float> m_indentStack; // 0x828
		protected bool tag_NoParsing; // 0x848
		protected bool m_isParsingText; // 0x849
		protected Matrix4x4 m_FXMatrix; // 0x84C
		protected bool m_isFXMatrixSet; // 0x88C
		protected UnicodeChar[] m_TextProcessingArray; // 0x890
		internal int m_InternalTextProcessingArraySize; // 0x898
		private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x8A0
		protected int m_totalCharacterCount; // 0x8A8
		protected static WordWrapState m_SavedWordWrapState; // 0x98
		protected static WordWrapState m_SavedLineState; // 0x430
		protected static WordWrapState m_SavedEllipsisState; // 0x7C8
		protected static WordWrapState m_SavedLastValidState; // 0xB60
		protected static WordWrapState m_SavedSoftLineBreakState; // 0xEF8
		protected static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x1290
		protected int m_characterCount; // 0x8AC
		protected int m_firstCharacterOfLine; // 0x8B0
		protected int m_firstVisibleCharacterOfLine; // 0x8B4
		protected int m_lastCharacterOfLine; // 0x8B8
		protected int m_lastVisibleCharacterOfLine; // 0x8BC
		protected int m_lineNumber; // 0x8C0
		protected int m_lineVisibleCharacterCount; // 0x8C4
		protected int m_pageNumber; // 0x8C8
		protected float m_PageAscender; // 0x8CC
		protected float m_maxTextAscender; // 0x8D0
		protected float m_maxCapHeight; // 0x8D4
		protected float m_ElementAscender; // 0x8D8
		protected float m_ElementDescender; // 0x8DC
		protected float m_maxLineAscender; // 0x8E0
		protected float m_maxLineDescender; // 0x8E4
		protected float m_startOfLineAscender; // 0x8E8
		protected float m_startOfLineDescender; // 0x8EC
		protected float m_lineOffset; // 0x8F0
		protected Extents m_meshExtents; // 0x8F4
		protected Color32 m_htmlColor; // 0x904
		protected TMP_TextProcessingStack<Color32> m_colorStack; // 0x908
		protected TMP_TextProcessingStack<Color32> m_underlineColorStack; // 0x928
		protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; // 0x948
		protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x968
		protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; // 0x998
		protected TMP_ColorGradient m_colorGradientPreset; // 0x9C0
		protected bool m_colorGradientPresetIsTinted; // 0x9C8
		protected float m_tabSpacing; // 0x9CC
		protected float m_spacing; // 0x9D0
		protected TMP_TextProcessingStack<int>[] m_TextStyleStacks; // 0x9D8
		protected TMP_TextProcessingStack<int> m_ItalicAngleStack; // 0x9E0
		protected TMP_TextProcessingStack<int> m_actionStack; // 0xA00
		protected TMP_TextProcessingStack<float> m_baselineOffsetStack; // 0xA20
		protected int m_TextStyleStackDepth; // 0xA40
		protected int m_ItalicAngle; // 0xA44
		protected float m_padding; // 0xA48
		protected float m_baselineOffset; // 0xA4C
		protected float m_xAdvance; // 0xA50
		protected float m_lastCharAdvance; // 0xA54
		protected bool m_lastIsUpVowels; // 0xA58
		protected bool m_lastIsAscender; // 0xA59
		protected bool m_lastIsDescender; // 0xA5A
		protected float m_lastHeight; // 0xA5C
		protected static bool s_forceLeftAlign; // 0x1648
		protected TMP_TextElementType m_textElementType; // 0xA60
		protected TMP_TextElement m_cached_TextElement; // 0xA68
		protected SpecialCharacter m_Ellipsis; // 0xA70
		protected SpecialCharacter m_Underline; // 0xA90
		protected TMP_SpriteAsset m_defaultSpriteAsset; // 0xAB0
		protected TMP_SpriteAsset m_currentSpriteAsset; // 0xAB8
		protected int m_spriteCount; // 0xAC0
		protected int m_spriteIndex; // 0xAC4
		protected int m_spriteAnimationID; // 0xAC8
		private static ProfilerMarker k_ParseTextMarker; // 0x1650
		private static ProfilerMarker k_InsertNewLineMarker; // 0x1658
		protected bool m_ignoreActiveState; // 0xACC
		private TextBackingContainer m_TextBackingArray; // 0xAD0
		private readonly decimal[] k_Power; // 0xAE0
		protected static Vector2 k_LargePositiveVector2; // 0x1660
		protected static Vector2 k_LargeNegativeVector2; // 0x1668
		protected static float k_LargePositiveFloat; // 0x1670
		protected static float k_LargeNegativeFloat; // 0x1674
		protected static int k_LargePositiveInt; // 0x1678
		protected static int k_LargeNegativeInt; // 0x167C
		private bool m_dynamicFontAssetUsed; // 0xAE8
	
		// Properties
		public virtual string text { get; set; } // 0x00000001864735E0-0x00000001864735F4 0x0000000185FB8550-0x0000000185FB8560
		public virtual string textForPopulate { get; } // 0x000000018BE25E24-0x000000018BE25EBC 
		public ITextPreprocessor textPreprocessor { get; set; } // 0x000000018BE251F8-0x000000018BE25228 0x000000018BE25DE8-0x000000018BE25E24
		public bool isRightToLeftText { get; set; } // 0x000000018BE251A4-0x000000018BE251B8 0x000000018BE25D0C-0x000000018BE25DE8
		public TMP_FontAsset font { get; set; } // 0x000000018BE251B8-0x000000018BE251F8 0x000000018BE25DE8-0x000000018BE25E24
		public virtual TMP_FontAsset m_fontAsset { get; set; } // 0x0000000185A83380-0x0000000185A833E0 0x0000000185FB9AD0-0x0000000185FB9AE0
		public virtual Material fontSharedMaterial { get; set; } // 0x000000018BE259C8-0x000000018BE259F4 0x0000000185FB9410-0x0000000185FB9420
		protected virtual Material m_sharedMaterial { get; set; } // 0x000000018BE25BD0-0x000000018BE25BF8 0x0000000185FE5D50-0x0000000185FE5D80
		public virtual Material[] fontSharedMaterials { get; set; } // 0x000000018BE25AC0-0x000000018BE25B04 0x0000000185FB7F50-0x0000000185FB7F60
		public Material fontMaterial { get; set; } // 0x000000018BE25A8C-0x000000018BE25AC0 0x0000000185FB8420-0x0000000185FB8430
		public virtual Material[] fontMaterials { get; set; } // 0x000000018BE2671C-0x000000018BE26760 0x0000000185FB92D0-0x0000000185FB92E0
		public override UnityEngine.Color color { get; set; } // 0x000000018BE26804-0x000000018BE2682C 0x0000000185FB1760-0x0000000185FB1770
		public float alpha { get; set; } // 0x000000018BE26760-0x000000018BE267A4 0x00000001846853F0-0x0000000184685440
		public bool enableVertexGradient { get; set; } // 0x000000018BE267A4-0x000000018BE26804 0x0000000185FCEB50-0x0000000185FCEB60
		public VertexGradient colorGradient { get; set; } // 0x000000018BE265C0-0x000000018BE265E8 0x000000018BE250DC-0x000000018BE251A4
		public TMP_ColorGradient colorGradientPreset { get; set; } // 0x000000018BE25C80-0x000000018BE25CE4 0x000000018BE2538C-0x000000018BE25454
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x000000018BE264CC-0x000000018BE26524 0x000000018BE25454-0x000000018BE25504
		public bool tintAllSprites { get; set; } // 0x000000018BE26524-0x000000018BE2657C 0x0000000185FBACC0-0x0000000185FBACD0
		public TMP_StyleSheet styleSheet { get; set; } // 0x00000001845A2D40-0x00000001845A2D70 0x000000018BE25018-0x000000018BE25038
		public TMP_Style textStyle { get; set; } // 0x000000018BE25328-0x000000018BE2538C 0x0000000185D45B70-0x0000000185D45BF0
		public bool overrideColorTags { get; set; } // 0x000000018BE252C4-0x000000018BE25328 0x0000000185FE5E40-0x0000000185FE5E50
		public Color32 faceColor { get; set; } // 0x000000018BE25F48-0x000000018BE25F8C 0x000000018BE25504-0x000000018BE25624
		public Color32 outlineColor { get; set; } // 0x0000000185FE5D80-0x0000000185FE5D90 0x000000018BE25B04-0x000000018BE25B40
		public float outlineWidth { get; set; } // 0x0000000185FE5E30-0x0000000185FE5E40 0x000000018BE25EBC-0x000000018BE25F04
		public float fontSize { get; set; } // 0x0000000185FE5E20-0x0000000185FE5E30 0x00000001845A3990-0x00000001845A39C0
		protected float PhoneticElementScale { get; } // 0x0000000185FCD000-0x0000000185FCD010 
		protected string m_currentPhonetic { get; } // 0x000000018BE25F04-0x000000018BE25F48 
		protected bool m_currentEnablePhoneticAutoPadding { get; } // 0x0000000185FE5EE0-0x0000000185FE5EF0 
		protected bool m_currentEnablePhoneticAutoJustify { get; } // 0x0000000185FE5E70-0x0000000185FE5E80 
		public FontWeight fontWeight { get; set; } // 0x000000018BE26050-0x000000018BE26078 0x0000000185FCD0B0-0x0000000185FCD0C0
		public float pixelsPerUnit { get; } // 0x000000018BE26874-0x000000018BE2689C 
		public bool enableAutoSizing { get; set; } // 0x0000000185FE5D10-0x0000000185FE5D20 0x000000018BE2598C-0x000000018BE259C8
		public float fontSizeMin { get; set; } // 0x0000000185FE5D30-0x0000000185FE5D40 0x000000018BE259F4-0x000000018BE25A40
		public float fontSizeMax { get; set; } // 0x0000000185FE6090-0x0000000185FE60A0 0x000000018BE268C4-0x000000018BE26910
		public FontStyles fontStyle { get; set; } // 0x0000000185FE5F30-0x0000000185FE5F40 0x000000018BE26268-0x000000018BE262B4
		public bool isUsingBold { get; } // 0x0000000185FE5F20-0x0000000185FE5F30 
		public HorizontalAlignmentOptions horizontalAlignment { get; set; } // 0x000000018BE2621C-0x000000018BE26268 0x0000000185FE6000-0x0000000185FE6010
		public VerticalAlignmentOptions verticalAlignment { get; set; } // 0x000000018BE26610-0x000000018BE2665C 0x0000000185FE5D40-0x0000000185FE5D50
		public TextAlignmentOptions alignment { get; set; } // 0x000000018BE25A40-0x000000018BE25A8C 0x0000000185FE5DC0-0x0000000185FE5DD0
		public float characterSpacing { get; set; } // 0x000000018BE25BF8-0x000000018BE25C3C 0x0000000185FE60A0-0x0000000185FE60B0
		public float wordSpacing { get; set; } // 0x000000018BE26910-0x000000018BE2695C 0x0000000185FE5FE0-0x0000000185FE5FF0
		public float lineSpacing { get; set; } // 0x000000018BE2657C-0x000000018BE265C0 0x000000018BE25228-0x000000018BE25234
		public float lineSpacingAdjustment { get; set; } // 0x0000000185FE5DE0-0x0000000185FE5DF0 0x0000000185FE5F40-0x0000000185FE5F50
		public float paragraphSpacing { get; set; } // 0x000000018BE262B4-0x000000018BE263A8 0x0000000185FE5ED0-0x0000000185FE5EE0
		public float characterWidthAdjustment { get; set; } // 0x0000000185FE5DB0-0x0000000185FE5DC0 0x000000018BE25B8C-0x000000018BE25BD0
		public bool enableWordWrapping { get; set; } // 0x0000000185FE5DD0-0x0000000185FE5DE0 0x000000018BE25C3C-0x000000018BE25C80
		public float wordWrappingRatios { get; set; } // 0x0000000185FE6040-0x0000000185FE6050 0x000000018BE266D8-0x000000018BE2671C
		public TextOverflowModes overflowMode { get; set; } // 0x0000000185FE5DA0-0x0000000185FE5DB0 0x000000018BE25B74-0x000000018BE25B8C
		public bool isTextOverflowing { get; } // 0x0000000185FE6030-0x0000000185FE6040 
		public int firstOverflowCharacterIndex { get; } // 0x000000018BE266B8-0x000000018BE266D8 
		public TMP_Text linkedTextComponent { get; set; } // 0x0000000185FE6010-0x0000000185FE6020 0x000000018BE2665C-0x000000018BE266A0
		public bool isTextTruncated { get; } // 0x0000000185FE5EB0-0x0000000185FE5EC0 
		public bool enableKerning { get; set; } // 0x000000018BE260E0-0x000000018BE26124 0x0000000185FE5EA0-0x0000000185FE5EB0
		public bool extraPadding { get; set; } // 0x000000018BE260B8-0x000000018BE260E0 0x0000000185FE5D90-0x0000000185FE5DA0
		public bool richText { get; set; } // 0x000000018BE25B40-0x000000018BE25B74 0x0000000185FE5E90-0x0000000185FE5EA0
		public bool enableHyperlink { get; set; } // 0x000000018BE260A0-0x000000018BE260B8 0x0000000185FE5E80-0x0000000185FE5E90
		public float richTextColorBlend { get; set; } // 0x000000018BE26078-0x000000018BE260A0 0x0000000185FE6080-0x0000000185FE6090
		public bool parseCtrlCharacters { get; set; } // 0x000000018BE2689C-0x000000018BE268C4 0x0000000185FE5F50-0x0000000185FE5F60
		public bool isOverlay { get; set; } // 0x000000018BE263A8-0x000000018BE263D4 0x0000000185FE6020-0x0000000185FE6030
		public bool isOrthographic { get; set; } // 0x000000018BE266A0-0x000000018BE266B8 0x0000000185FE5E50-0x0000000185FE5E60
		public bool enableCulling { get; set; } // 0x000000018BE26030-0x000000018BE26050 0x0000000185FE5EC0-0x0000000185FE5ED0
		public bool ignoreVisibility { get; set; } // 0x000000018BE26168-0x000000018BE261C8 0x0000000185FE6070-0x0000000185FE6080
		public TextureMappingOptions horizontalMapping { get; set; } // 0x000000018BE26854-0x000000018BE26874 0x0000000185FE5DF0-0x0000000185FE5E00
		public TextureMappingOptions verticalMapping { get; set; } // 0x000000018BE25CE4-0x000000018BE25D0C 0x0000000185FE5F80-0x0000000185FE5F90
		public float mappingUvLineOffset { get; set; } // 0x0000000185D6F430-0x0000000185D6F460 0x0000000185FE5FA0-0x0000000185FE5FB0
		public TextRenderFlags renderMode { get; set; } // 0x000000018BE264A4-0x000000018BE264CC 0x0000000185FE5F90-0x0000000185FE5FA0
		public VertexSortingOrder geometrySortingOrder { get; set; } // 0x000000018BE2647C-0x000000018BE264A4 0x0000000185FE6060-0x0000000185FE6070
		public bool isTextObjectScaleStatic { get; set; } // 0x000000018BE2682C-0x000000018BE26854 0x0000000185FE5FF0-0x0000000185FE6000
		public bool vertexBufferAutoSizeReduction { get; set; } // 0x000000018BE265E8-0x000000018BE26610 0x0000000185FE5F60-0x0000000185FE5F70
		public int firstVisibleCharacter { get; set; } // 0x000000018BE263D4-0x000000018BE2647C 0x0000000185FE6050-0x0000000185FE6060
		public int maxVisibleCharacters { get; set; } // 0x0000000185FE5E60-0x0000000185FE5E70 0x000000018588D0D0-0x000000018588D260
		public int maxVisibleWords { get; set; } // 0x0000000185FE5EF0-0x0000000185FE5F00 0x0000000185FE60C0-0x0000000185FE60D0
		public int maxVisibleLines { get; set; } // 0x0000000183FCB6D0-0x0000000183FCB810 0x0000000184431030-0x0000000184431170
		public bool useMaxVisibleDescender { get; set; } // 0x0000000185FE5D20-0x0000000185FE5D30 0x0000000185FE60B0-0x0000000185FE60C0
		public int pageToDisplay { get; set; } // 0x0000000185FE5860-0x0000000185FE5870 0x0000000185FE5F00-0x0000000185FE5F10
		public virtual Vector4 margin { get; set; } // 0x000000018BE261C8-0x000000018BE2621C 0x000000018BE25038-0x000000018BE250DC
		public TMP_TextInfo textInfo { get; } // 0x000000018BE25718-0x000000018BE2576C 
		public bool havePropertiesChanged { get; set; } // 0x000000018BE24DF8-0x000000018BE24EC0 0x000000018BE2576C-0x000000018BE25834
		public bool isUsingLegacyAnimationComponent { get; set; } // 0x000000018BE24F50-0x000000018BE25018 0x000000018BE258C4-0x000000018BE2598C
		public new Transform transform { get; } // 0x000000018BE24EC0-0x000000018BE24F50 
		public new RectTransform rectTransform { get; } // 0x000000018BE25834-0x000000018BE258C4 
		public virtual bool autoSizeTextContainer { get; set; } // 0x000000018BE25624-0x000000018BE25718 0x0000000185FE5E00-0x0000000185FE5E10
		public virtual Mesh mesh { get; } // 0x0000000185FE5E10-0x0000000185FE5E20 
		public bool isVolumetricText { get; set; } // 0x0000000185FE5FD0-0x0000000185FE5FE0 0x0000000185FE5FC0-0x0000000185FE5FD0
		public Bounds bounds { get; } // 0x0000000185FE5FB0-0x0000000185FE5FC0 
		public Bounds textBounds { get; } // 0x0000000185FE5F70-0x0000000185FE5F80 
		protected TMP_SpriteAnimator spriteAnimator { get; } // 0x000000018646E430-0x000000018646E438 
		public float flexibleHeight { get; } // 0x00000001842437C0-0x0000000184243D70 
		public float flexibleWidth { get; } // 0x0000000184243350-0x00000001842435F0 
		public float minWidth { get; } // 0x0000000185492010-0x0000000185492020 
		public float minHeight { get; } // 0x0000000185492010-0x0000000185492020 
		public float maxWidth { get; } // 0x00000001813AE580-0x00000001813AE590 
		public float maxHeight { get; } // 0x0000000185492010-0x0000000185492020 
		protected LayoutElement layoutElement { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual float preferredWidth { get; } // 0x0000000185492010-0x0000000185492020 
		public virtual float preferredHeight { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual float renderedWidth { get; } // 0x000000018BE1DB70-0x000000018BE1DC24 
		public virtual float renderedHeight { get; } // 0x000000018BE24D58-0x000000018BE24DF8 
		public int layoutPriority { get; } // 0x0000000185492010-0x0000000185492020 
	
		// Events
		public static event Func<int, string, TMP_FontAsset> OnFontAssetRequest;
		public static event Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest;
		public virtual event Action<TMP_TextInfo> OnPreRenderText;
	
		// Nested types
		protected struct CharacterSubstitution // TypeDefIndex: 53235
		{
			// Fields
			public int index; // 0x00
			public uint unicode; // 0x04
	
			// Constructors
			public CharacterSubstitution(int index, uint unicode) {
				this.index = default;
				this.unicode = default;
			} // 0x000000018515D230-0x000000018515D250
		}
	
		internal enum TextInputSources // TypeDefIndex: 53236
		{
			TextInputBox = 0,
			SetText = 1,
			SetTextArray = 2,
			TextString = 3
		}
	
		protected struct UnicodeChar // TypeDefIndex: 53237
		{
			// Fields
			public int unicode; // 0x00
			public int stringIndex; // 0x04
			public int length; // 0x08
		}
	
		protected struct SpecialCharacter // TypeDefIndex: 53238
		{
			// Fields
			public TMP_Character character; // 0x00
			public TMP_FontAsset fontAsset; // 0x08
			public Material material; // 0x10
			public int materialIndex; // 0x18
	
			// Constructors
			public SpecialCharacter(TMP_Character character, int materialIndex) {
				this.character = default;
				fontAsset = default;
				material = default;
				this.materialIndex = default;
			} // 0x0000000184FB78D0-0x0000000184FB7980
		}
	
		private struct TextBackingContainer : IDisposable // TypeDefIndex: 53239
		{
			// Fields
			private uint[] m_Array; // 0x00
			private int m_Count; // 0x08
	
			// Properties
			public int Capacity { get => default; } // 0x0000000184683400-0x0000000184683440 
			public int Count { get => default; set {} } // 0x000000018BE23C78-0x000000018BE23C88 0x000000018BE22C88-0x000000018BE22CB8
			public uint this[int index] { get => default; set {} } // 0x0000000185FB1CB0-0x0000000185FB1CC0 0x0000000187764794-0x00000001877647A8
	
			// Constructors
			public TextBackingContainer(int size) : this() {
				m_Array = default;
				m_Count = default;
			} // 0x0000000185FB9370-0x0000000185FB9380
	
			// Methods
			public void Resize(int size) {} // 0x000000018BE26124-0x000000018BE26168
			public void Dispose() {} // 0x0000000186471710-0x0000000186471718
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53240
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<TMP_TextInfo> __9__685_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018BE25F8C-0x000000018BE26030
			public __c() {} // 0x00000001813AE580-0x00000001813AE590
	
			// Methods
			internal void _.ctor_b__685_0(TMP_TextInfo _p0_) {} // 0x0000000185FB8600-0x0000000185FB8610
		}
	
		// Constructors
		protected TMP_Text() {} // 0x0000000185492010-0x0000000185492020
		static TMP_Text() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void ResetTextForPopulate() {} // 0x0000000185FB8550-0x0000000185FB8560
		public virtual void RefreshPopulateText() {} // 0x00000001864735A4-0x00000001864735B8
		protected virtual Material LoadMaterial(string path) => default; // 0x0000000185EF5F40-0x0000000185EF5F50
		protected override void Awake() {} // 0x0000000185492010-0x0000000185492020
		protected void InitDataFromPool() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnDestroy() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void LoadFontAsset() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void SetSharedMaterial(Material mat) {} // 0x0000000185492010-0x0000000185492020
		protected virtual Material GetMaterial(Material mat) => default; // 0x0000000185492010-0x0000000185492020
		protected virtual void SetFontBaseMaterial(Material mat) {} // 0x0000000185492010-0x0000000185492020
		protected virtual Material[] GetSharedMaterials() => default; // 0x00000001845E8200-0x00000001845E8360
		protected virtual void SetSharedMaterials(Material[] materials) {} // 0x000000018BE205D0-0x000000018BE206C4
		protected virtual Material[] GetMaterials(Material[] mats) => default; // 0x00000001813AE580-0x00000001813AE590
		protected virtual Material CreateMaterialInstance(Material source) => default; // 0x0000000185492010-0x0000000185492020
		protected void SetVertexColorGradient(TMP_ColorGradient gradient) {} // 0x0000000185492010-0x0000000185492020
		protected void SetTextSortingOrder(VertexSortingOrder order) {} // 0x0000000185492010-0x0000000185492020
		protected void SetTextSortingOrder(int[] order) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void SetFaceColor(Color32 color) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void SetOutlineColor(Color32 color) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void SetOutlineThickness(float thickness) {} // 0x00000001859EACD0-0x00000001859EAD60
		protected virtual void SetShaderDepth() {} // 0x000000018BE1DC24-0x000000018BE1DC84
		protected virtual void SetCulling() {} // 0x0000000185492010-0x0000000185492020
		internal virtual void UpdateCulling() {} // 0x0000000185492010-0x0000000185492020
		protected virtual float GetPaddingForMaterial() => default; // 0x00000001846832D0-0x0000000184683400
		protected virtual float GetPaddingForMaterial(Material mat) => default; // 0x0000000184683440-0x0000000184683470
		protected virtual Vector3[] GetTextContainerLocalCorners() => default; // 0x0000000184297BA0-0x0000000184297D50
		public virtual void ForceMeshUpdate(bool ignoreActiveState = false /* Metadata: 0x02077DFC */, bool forceTextReparsing = false /* Metadata: 0x02077DFD */) {} // 0x000000018BE22A8C-0x000000018BE22B8C
		public virtual void UpdateGeometry(Mesh mesh, int index) {} // 0x000000018BE22B8C-0x000000018BE22C88
		public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) {} // 0x00000001842B2130-0x00000001842B24C0
		public virtual void UpdateVertexData() {} // 0x000000018BE247FC-0x000000018BE24850
		public virtual void SetVertices(Vector3[] vertices) {} // 0x0000000185DB1B30-0x0000000185DB1BF0
		public virtual void UpdateMeshPadding() {} // 0x000000018BE24CB4-0x000000018BE24CF0
		public override void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) {} // 0x000000018BE24850-0x000000018BE2488C
		public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) {} // 0x000000018BE24C24-0x000000018BE24C68
		protected virtual void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) {} // 0x000000018BE24C68-0x000000018BE24CB4
		protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) {} // 0x000000018BE24BCC-0x000000018BE24C24
		protected void ParseInputText() {} // 0x000000018BE24B04-0x000000018BE24B64
		private void PopulateTextBackingArray(string sourceText) {} // 0x000000018BE24B64-0x000000018BE24BCC
		private void PopulateTextBackingArray(string sourceText, int start, int length) {} // 0x000000018BE248B8-0x000000018BE24B04
		private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length) {} // 0x000000018BE2488C-0x000000018BE248B8
		private void PopulateTextBackingArray(char[] sourceText, int start, int length) {} // 0x000000018BE24D00-0x000000018BE24D58
		private void PopulateTextProcessingArray() {} // 0x000000018BE247D4-0x000000018BE247FC
		private void SetTextInternal(string sourceText) {} // 0x000000018BE24CF0-0x000000018BE24D00
		public void SetText(string sourceText, bool syncTextInputBox = true /* Metadata: 0x02077DFE */) {} // 0x000000018BE247D4-0x000000018BE247FC
		public void SetText(string sourceText, float arg0) {} // 0x000000018BE2477C-0x000000018BE247D4
		public void SetText(string sourceText, float arg0, float arg1) {} // 0x0000000184685440-0x0000000184685740
		public void SetText(string sourceText, float arg0, float arg1, float arg2) {} // 0x000000018BE234B0-0x000000018BE23878
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3) {} // 0x000000018BE23878-0x000000018BE23C20
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4) {} // 0x000000018BE22DB0-0x000000018BE23138
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) {} // 0x000000018BE23138-0x000000018BE234B0
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) {} // 0x000000018BE22570-0x000000018BE228EC
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) {} // 0x000000018BE221F4-0x000000018BE22570
		public void SetText(StringBuilder sourceText) {} // 0x000000018BE2051C-0x000000018BE205D0
		private void SetText(StringBuilder sourceText, int start, int length) {} // 0x00000001854CC7F0-0x00000001854CC8B0
		public void SetText(char[] sourceText) {} // 0x000000018BE20BFC-0x000000018BE20CBC
		public void SetText(char[] sourceText, int start, int length) {} // 0x000000018BE20CBC-0x000000018BE20D84
		public void SetCharArray(char[] sourceText) {}
		public void SetCharArray(char[] sourceText, int start, int length) {}
		private TMP_Style GetStyle(int hashCode) => default; // 0x000000018BE1D0A4-0x000000018BE1D388
		private bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex) {
			srcOffset = default;
			return default;
		} // 0x000000018BE1D388-0x000000018BE1D4A0
		private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex) {
			srcOffset = default;
			return default;
		} // 0x000000018BE228EC-0x000000018BE229C4
		private void ReplaceClosingStyleTag(ref TextBackingContainer sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex) {} // 0x00000001813AE580-0x00000001813AE590
		private void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex) {} // 0x000000018BE20A04-0x000000018BE20A58
		private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex) => default; // 0x000000018BE2085C-0x000000018BE208C4
		private void InsertClosingStyleTag(ref UnicodeChar[] charBuffer, ref int writeIndex) {} // 0x000000018BE208C4-0x000000018BE2098C
		private int GetMarkupTagHashCode(int[] tagDefinition, int readIndex) => default; // 0x000000018BE2098C-0x000000018BE20A04
		private int GetMarkupTagHashCode(TextBackingContainer tagDefinition, int readIndex) => default; // 0x0000000184682AE0-0x0000000184682C70
		private int GetStyleHashCode(ref int[] text, int index, out int closeIndex) {
			closeIndex = default;
			return default;
		} // 0x000000018BE20A58-0x000000018BE20AD4
		private int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) {
			closeIndex = default;
			return default;
		} // 0x00000001846828F0-0x0000000184682AE0
		private void ResizeInternalArray<T>(ref ref T[] array) {} // 0x000000018BE207AC-0x000000018BE2085C
		private void ResizeInternalArray<T>(ref ref T[] array, int size) {} // 0x000000018BE20B68-0x000000018BE20BC4
		private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex) {} // 0x000000018BE20B0C-0x000000018BE20B68
		private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex) {} // 0x000000018BE20BE0-0x000000018BE20BFC
		private string InternalTextBackingArrayToString() => default; // 0x000000018BE20BC4-0x000000018BE20BE0
		protected virtual int SetArraySizes(UnicodeChar[] unicodeChars) => default; // 0x000000018BE20AF0-0x000000018BE20B0C
		public Vector2 GetPreferredValues() => default; // 0x000000018BE20AD4-0x000000018BE20AF0
		public Vector2 GetPreferredValues(float width, float height) => default; // 0x0000000184685A30-0x000000018468B4A0
		public Vector2 GetPreferredValues(string text) => default; // 0x0000000185FBB100-0x0000000185FBB110
		public Vector2 GetPreferredValues(string text, float width, float height) => default; // 0x000000018361A650-0x000000018361A660
		protected float GetPreferredWidth() => default; // 0x000000018BE210BC-0x000000018BE213CC
		private float GetPreferredWidth(Vector2 margin) => default; // 0x000000018BE20D84-0x000000018BE210BC
		protected float GetPreferredHeight() => default; // 0x000000018BE1D4A0-0x000000018BE1D984
		private float GetPreferredHeight(Vector2 margin) => default; // 0x000000018BE23C88-0x000000018BE23F10
		public Vector2 GetRenderedValues() => default; // 0x00000001813AE580-0x00000001813AE590
		public Vector2 GetRenderedValues(bool onlyVisibleCharacters) => default; // 0x0000000185492010-0x0000000185492020
		private float GetRenderedWidth() => default; // 0x0000000184243DF0-0x00000001842447C0
		protected float GetRenderedWidth(bool onlyVisibleCharacters) => default; // 0x00000001846845B0-0x0000000184685000
		private float GetRenderedHeight() => default; // 0x00000001850A53F0-0x00000001850A5C20
		protected float GetRenderedHeight(bool onlyVisibleCharacters) => default; // 0x00000001842B48B0-0x00000001842B4F40
		protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled) => default; // 0x000000018BE23F10-0x000000018BE2477C
		protected virtual Bounds GetCompoundBounds() => default; // 0x00000001842B4F40-0x00000001842B57E0
		internal virtual Rect GetCanvasSpaceClippingRect() => default; // 0x000000018BE1F050-0x000000018BE1FC3C
		protected Bounds GetTextBounds() => default; // 0x000000018BE1FC3C-0x000000018BE203EC
		protected Bounds GetTextBounds(bool onlyVisibleCharacters) => default; // 0x000000018BE1E160-0x000000018BE1F050
		protected void AdjustLineOffset(int startIndex, int endIndex, float offset) {} // 0x0000000183F7D540-0x0000000183F7EF60
		protected void ResizeLineExtents(int size) {} // 0x0000000183F7CEC0-0x0000000183F7D540
		public virtual TMP_TextInfo GetTextInfo(string text) => default; // 0x0000000183F7A420-0x0000000183F7CEC0
		public virtual void ComputeMarginSize() {} // 0x000000018BE1DC84-0x000000018BE1E160
		protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) {} // 0x0000000184245510-0x00000001842455A0
		protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) {} // 0x0000000184683130-0x0000000184683160
		protected int RestoreWordWrappingState(ref WordWrapState state) => default; // 0x0000000184682C70-0x0000000184682E00
		protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) {} // 0x0000000184682FC0-0x0000000184683130
		protected virtual void SaveSpriteVertexInfo(Color32 vertexColor) {} // 0x000000018BE23C20-0x000000018BE23C78
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4) {} // 0x000000018BE20498-0x000000018BE2051C
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) {} // 0x00000001842B0DE0-0x00000001842B0FC0
		protected virtual void FillSpriteVertexBuffers(int i, int index_X4) {} // 0x000000018423FEC0-0x000000018423FEE0
		protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) {} // 0x0000000185492010-0x0000000185492020
		protected void PrepareCharSlots(PhoneticData data) {} // 0x0000000185492010-0x0000000185492020
		protected virtual float PhoneticWidth(PhoneticData data) => default; // 0x0000000185492010-0x0000000185492020
		protected virtual void DrawPhoneticMesh(Rect rect, PhoneticData data, float padding, float style_padding, bool justify, float lossyScale) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) {} // 0x000000018BE206C4-0x000000018BE207AC
		protected void LoadDefaultSettings() {} // 0x000000018BE229C4-0x000000018BE22A8C
		protected void GetSpecialCharacters(TMP_FontAsset fontAsset) {} // 0x000000018BE22CB8-0x000000018BE22DB0
		protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) {} // 0x0000000185FE5CD0-0x0000000185FE5D10
		protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) {} // 0x0000000185FE5C90-0x0000000185FE5CD0
		protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) {} // 0x0000000185492010-0x0000000185492020
		protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) => default; // 0x0000000184FD8BA0-0x0000000184FD8D40
		internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) {
			isUsingAlternativeTypeface = default;
			return default;
		} // 0x000000018BE21594-0x000000018BE2167C
		public void TryRemoveDynamicFallbackFontAssetTextRef() {} // 0x000000018BE214B4-0x000000018BE21594
		protected virtual void SetActiveSubMeshes(bool state) {} // 0x000000018BE21754-0x000000018BE21834
		protected virtual void DestroySubMeshObjects() {} // 0x000000018BE213CC-0x000000018BE214B4
		public virtual void ClearMesh() {} // 0x000000018BE2167C-0x000000018BE21754
		public virtual void ClearMesh(bool uploadGeometry) {} // 0x000000018BE21834-0x000000018BE219AC
		public virtual string GetParsedText() => default; // 0x000000018BE21B20-0x000000018BE21C94
		internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) => default; // 0x000000018BE219AC-0x000000018BE21B20
		internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) {} // 0x000000018BE21DF4-0x000000018BE21F6C
		protected Vector2 PackUV(float x, float y, float scale) => default; // 0x000000018BE21C94-0x000000018BE21DF4
		protected float PackUV(float x, float y) => default; // 0x0000000184FD8990-0x0000000184FD8BA0
		internal virtual void InternalUpdate() {} // 0x000000018BE21F6C-0x000000018BE221F4
		protected static int HexToInt(char hex) => default; // 0x000000018BE203EC-0x000000018BE20498
		protected int GetUTF16(string text, int i) => default; // 0x000000018BE1DB4C-0x000000018BE1DB70
		protected int GetUTF16(int[] text, int i) => default; // 0x000000018BE1DA0C-0x000000018BE1DB4C
		internal int GetUTF16(uint[] text, int i) => default; // 0x000000018BE1D984-0x000000018BE1DA0C
		protected int GetUTF16(StringBuilder text, int i) => default; // 0x0000000184FD8D40-0x0000000184FE0BB0
		private int GetUTF16(TextBackingContainer text, int i) => default; // 0x00000001848137B0-0x0000000184814A90
		protected int GetUTF32(string text, int i) => default; // 0x0000000185949D40-0x000000018594A330
		protected int GetUTF32(int[] text, int i) => default; // 0x000000018357CB90-0x000000018357CBA0
		internal int GetUTF32(uint[] text, int i) => default; // 0x0000000184682E00-0x0000000184682FC0
		protected int GetUTF32(StringBuilder text, int i) => default; // 0x0000000186473EAC-0x0000000186473EC8
		private int GetUTF32(TextBackingContainer text, int i) => default; // 0x0000000181B7E450-0x0000000181B7E460
		protected static Color32 HexCharsToColor(ReadOnlySpan<char> hexChars, int tagCount) => default; // 0x0000000185FB2B90-0x0000000185FB2BA0
		protected static Color32 HexCharsToColor(ReadOnlySpan<char> hexChars, int startIndex, int length) => default; // 0x00000001842B1950-0x00000001842B1980
		private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) => default; // 0x0000000184297D50-0x0000000184297DB0
		protected float ConvertToFloat(char[] chars, int startIndex, int length) => default; // 0x0000000184243D70-0x0000000184243DF0
		protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) {
			lastIndex = default;
			return default;
		} // 0x0000000184402EA0-0x0000000184402F20
		protected bool CheckIfEndPhonetic(UnicodeChar[] chars, int startIndex) => default; // 0x0000000184243680-0x00000001842436F0
		protected bool ValidateHtmlTag(UnicodeChar[] chars, int startIndex, out int endIndex) {
			endIndex = default;
			return default;
		} // 0x0000000185F75DF0-0x0000000185F75E50
	}

	public enum TextElementType : byte // TypeDefIndex: 53242
	{
		Character = 1,
		Sprite = 2
	}

	[Serializable]
	public class TMP_TextElement // TypeDefIndex: 53243
	{
		// Fields
		protected TextElementType m_ElementType; // 0x10
		internal uint m_Unicode; // 0x14
		internal TMP_Asset m_TextAsset; // 0x18
		internal Glyph m_Glyph; // 0x20
		internal uint m_GlyphIndex; // 0x28
		internal float m_Scale; // 0x2C
	
		// Properties
		public TextElementType elementType { get => default; } // 0x0000000181C2FD60-0x0000000181C2FD70 
		public uint unicode { get => default; set {} } // 0x0000000185FB21A0-0x0000000185FB21B0 0x0000000185FBB0B0-0x0000000185FBB0C0
		public TMP_Asset textAsset { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public Glyph glyph { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public uint glyphIndex { get => default; set {} } // 0x0000000181C9AC80-0x0000000181C9AC90 0x0000000181C9A5C0-0x0000000181C9A5D0
		public float scale { get => default; set {} } // 0x0000000185FB09A0-0x0000000185FB09B0 0x0000000185FB09B0-0x0000000185FB09C0
	
		// Constructors
		public TMP_TextElement() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class TMP_TextElement_Legacy // TypeDefIndex: 53244
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
		public TMP_TextElement_Legacy() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class TMP_TextInfo : IDisposable // TypeDefIndex: 53245
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
		public TMP_TextInfo() {} // 0x000000018BE2E358-0x000000018BE2E508
		internal TMP_TextInfo(int characterCount) {} // 0x000000018BE2E508-0x000000018BE2E6C0
		public TMP_TextInfo(TMP_Text textComponent) {} // 0x0000000184245A80-0x0000000184245D10
		static TMP_TextInfo() {} // 0x0000000185F85CD0-0x0000000185F85D30
	
		// Methods
		public void Clear() {} // 0x0000000184FCC400-0x0000000184FCC460
		internal void ClearAllData() {} // 0x000000018BE2DB10-0x000000018BE2DC50
		public void ClearMeshInfo(bool updateMesh) {} // 0x000000018BE2DCD0-0x000000018BE2DD60
		public void ClearAllMeshInfo() {} // 0x000000018BE2DC50-0x000000018BE2DCD0
		public void ResetVertexLayout(bool isVolumetric) {} // 0x000000018BE2E2C8-0x000000018BE2E358
		public void ClearUnusedVertices(MaterialReference[] materials) {} // 0x000000018BE2DD60-0x000000018BE2DDE0
		public void ClearLineInfo() {} // 0x00000001842B4550-0x00000001842B48B0
		public void ClearPageInfo() {} // 0x0000000184BE8320-0x0000000184BE8440
		public TMP_MeshInfo[] CopyMeshInfoVertexData() => default; // 0x000000018BE2DDE0-0x000000018BE2E2C8
		public static void Resize<T>(ref ref T[] array, int size) {}
		public static void Resize<T>(ref ref T[] array, int size, bool isBlockAllocated) {}
		public void Dispose() {} // 0x00000001842447C0-0x0000000184244BA0
	}

	public class TMP_TextParsingUtilities // TypeDefIndex: 53246
	{
		// Fields
		private static readonly TMP_TextParsingUtilities s_Instance; // 0x00
		private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x02077E09
		private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x02077E8B
	
		// Properties
		public static TMP_TextParsingUtilities instance { get => default; } // 0x000000018BE2E854-0x000000018BE2E8A4 
	
		// Constructors
		static TMP_TextParsingUtilities() {} // 0x0000000185F79750-0x0000000185F797B0
		public TMP_TextParsingUtilities() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static int GetHashCode(string s) => default; // 0x0000000185263A80-0x0000000185263B30
		public static int GetHashCodeCaseSensitive(string s) => default; // 0x000000018BE2E6C0-0x000000018BE2E714
		public static char ToLowerASCIIFast(char c) => default; // 0x000000018BE2E744-0x000000018BE2E79C
		public static char ToUpperASCIIFast(char c) => default; // 0x0000000185263B30-0x0000000185263B90
		public static uint ToUpperASCIIFast(uint c) => default; // 0x000000018BE2E7F8-0x000000018BE2E854
		public static uint ToLowerASCIIFast(uint c) => default; // 0x000000018BE2E79C-0x000000018BE2E7F8
		public static bool IsHighSurrogate(uint c) => default; // 0x000000018BE2E714-0x000000018BE2E72C
		public static bool IsLowSurrogate(uint c) => default; // 0x000000018BE2E72C-0x000000018BE2E744
		internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) => default; // 0x0000000185FE6130-0x0000000185FE6140
	}

	public struct TMP_FontStyleStack // TypeDefIndex: 53247
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
		public void Clear() {} // 0x0000000185073880-0x0000000185073890
		public byte Add(FontStyles style) => default; // 0x000000018BE275E0-0x000000018BE27680
		public byte Remove(FontStyles style) => default; // 0x000000018BE27680-0x000000018BE2777C
	}

	public struct TMP_TextProcessingStack<T> : IDisposable // TypeDefIndex: 53248
	{
		// Fields
		public T[] itemStack;
		public int index;
		private T m_DefaultItem;
		private int m_Capacity;
		private int m_RolloverSize;
		private int m_Count;
		private const int k_DefaultCapacity = 4; // Metadata: 0x02077F0D
	
		// Properties
		public int Count { get => default; }
		public T current { get => default; }
		public int rolloverSize { get => default; set {} }
	
		// Constructors
		public TMP_TextProcessingStack(T[] stack) : this() {
			itemStack = default;
			index = default;
			m_DefaultItem = default;
			m_Capacity = default;
			m_RolloverSize = default;
			m_Count = default;
		}
		public TMP_TextProcessingStack(int capacity) : this() {
			itemStack = default;
			index = default;
			m_DefaultItem = default;
			m_Capacity = default;
			m_RolloverSize = default;
			m_Count = default;
		}
		public TMP_TextProcessingStack(int capacity, int rolloverSize) : this() {
			itemStack = default;
			index = default;
			m_DefaultItem = default;
			m_Capacity = default;
			m_RolloverSize = default;
			m_Count = default;
		}
	
		// Methods
		internal static void SetDefault(TMP_TextProcessingStack<T>[] stack, T item) {}
		public void Clear() {}
		public void SetDefault(T item) {}
		public void Add(T item) {}
		public T Remove() => default;
		public void Push(T item) {}
		public T Pop() => default;
		public T Peek() => default;
		public T CurrentItem() => default;
		public T PreviousItem() => default;
		public void RestoreFrom(TMP_TextProcessingStack<T> other) {}
		public void Dispose() {}
	}

	public struct TMP_TextProcessingQueue<T> : IDisposable // TypeDefIndex: 53249
	{
		// Fields
		public T[] itemQueue;
		private int m_Head;
		private int m_Tail;
		private int m_Capacity;
		private int m_Count;
		private T m_DefaultItem;
		private const int k_DefaultCapacity = 4; // Metadata: 0x02077F0E
	
		// Properties
		public int Count { get => default; }
	
		// Constructors
		public TMP_TextProcessingQueue(T[] queue) : this() {
			itemQueue = default;
			m_Head = default;
			m_Tail = default;
			m_Capacity = default;
			m_Count = default;
			m_DefaultItem = default;
		}
		public TMP_TextProcessingQueue(int capacity) : this() {
			itemQueue = default;
			m_Head = default;
			m_Tail = default;
			m_Capacity = default;
			m_Count = default;
			m_DefaultItem = default;
		}
	
		// Methods
		public void Clear() {}
		public void SetDefault(T item) {}
		public void Enqueue(T item) {}
		public T Dequeue() => default;
		public T Peek() => default;
		private void Resize(int newCapacity) {}
		public void RestoreFrom(TMP_TextProcessingQueue<T> other) {}
		public void Dispose() {}
	}

	public enum CaretPosition // TypeDefIndex: 53250
	{
		None = 0,
		Left = 1,
		Right = 2
	}

	public struct CaretInfo // TypeDefIndex: 53251
	{
		// Fields
		public int index; // 0x00
		public CaretPosition position; // 0x04
	
		// Constructors
		public CaretInfo(int index, CaretPosition position) {
			this.index = default;
			this.position = default;
		} // 0x000000018357CB90-0x000000018357CBA0
	}

	public static class TMP_TextUtilities // TypeDefIndex: 53253
	{
		// Fields
		private static Vector3[] m_rectWorldCorners; // 0x00
		private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x02077F12
		private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x02077F94
	
		// Nested types
		private struct LineSegment // TypeDefIndex: 53252
		{
			// Fields
			public Vector3 Point1; // 0x00
			public Vector3 Point2; // 0x0C
	
			// Constructors
			public LineSegment(Vector3 p1, Vector3 p2) {
				Point1 = default;
				Point2 = default;
			} // 0x000000018BE31BF4-0x000000018BE31DA8
		}
	
		// Constructors
		static TMP_TextUtilities() {} // 0x0000000185FB1480-0x0000000185FB14A0
	
		// Methods
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera) => default; // 0x000000018BE31DA8-0x000000018BE31FE8
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor) {
			cursor = default;
			return default;
		} // 0x000000018BE304A8-0x000000018BE306A4
		public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera) => default; // 0x000000018BE2FBC0-0x000000018BE3005C
		public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly) => default; // 0x000000018BE32424-0x000000018BE3260C
		public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera) => default; // 0x000000018BE2EA7C-0x000000018BE2ED4C
		public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) => default; // 0x000000018BE3005C-0x000000018BE304A8
		public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) => default; // 0x000000018BE2F49C-0x000000018BE2FBC0
		public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera) => default; // 0x000000018BE31148-0x000000018BE31BF4
		public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera) => default; // 0x000000018BE2ED4C-0x000000018BE2EEDC
		public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera) => default; // 0x000000018BE2EEDC-0x000000018BE2F49C
		public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera) => default; // 0x000000018BE306A4-0x000000018BE31148
		public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera) => default; // 0x000000018BE3260C-0x000000018BE327D8
		private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) => default; // 0x000000018BE327D8-0x000000018BE3299C
		public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) {
			worldPoint = default;
			return default;
		} // 0x000000018BE32200-0x000000018BE32424
		private static bool IntersectLinePlane(LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint) {
			intersectingPoint = default;
			return default;
		} // 0x000000018BE2E8A4-0x000000018BE2EA7C
		public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) => default; // 0x000000018BE32A4C-0x000000018BE32AA4
		public static char ToLowerFast(char c) => default; // 0x000000018BE32AA4-0x000000018BE32AFC
		public static char ToUpperFast(char c) => default; // 0x00000001854CC8B0-0x00000001854CC910
		internal static uint ToUpperASCIIFast(uint c) => default; // 0x000000018BE31FE8-0x000000018BE32078
		public static int GetHashCode(string s) => default; // 0x0000000184012770-0x00000001840127D0
		public static int GetSimpleHashCode(string s) => default; // 0x000000018BE32078-0x000000018BE3210C
		public static uint GetSimpleHashCodeLowercase(string s) => default; // 0x000000018BE3210C-0x000000018BE32200
		public static int HexToInt(char hex) => default; // 0x000000018BE3299C-0x000000018BE32A4C
		public static int StringHexToInt(string s) => default; // 0x00000001849AA570-0x00000001849AA620
		public static bool IsThaiZeroWidthCharacter(char c) => default; // 0x00000001849AA680-0x00000001849AA6B0
		public static bool IsUpVowel(char c) => default; // 0x00000001849AA620-0x00000001849AA650
		public static bool IsLowVowel(char c) => default; // 0x00000001849AA650-0x00000001849AA680
		public static bool IsToneMark(char c) => default; // 0x0000000184CFF420-0x0000000184CFF450
		public static bool IsAscenderThai(char c) => default; // 0x0000000184E57530-0x0000000184E57550
		public static bool IsDescenderThai(char c) => default; // 0x0000000185F63620-0x0000000185F63690
	}

	public class TMP_UpdateManager // TypeDefIndex: 53254
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
		private static TMP_UpdateManager instance { get => default; } // 0x0000000184240ED0-0x0000000184240FD0 
	
		// Constructors
		private TMP_UpdateManager() {} // 0x00000001845A2800-0x00000001845A2A40
		static TMP_UpdateManager() {} // 0x0000000185D444B0-0x0000000185D44600
	
		// Methods
		internal static void RegisterTextObjectForUpdate(TMP_Text textObject) {} // 0x0000000184240DF0-0x0000000184240E60
		private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) {} // 0x0000000184241070-0x0000000184241190
		public static void RegisterTextElementForLayoutRebuild(TMP_Text element) {} // 0x000000018BE33B4C-0x000000018BE33BA4
		private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element) {} // 0x000000018BE33908-0x000000018BE339C4
		public static void RegisterTextElementForGraphicRebuild(TMP_Text element) {} // 0x000000018BE33AF4-0x000000018BE33B4C
		private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element) {} // 0x000000018BE3384C-0x000000018BE33908
		public static void RegisterTextElementForCullingUpdate(TMP_Text element) {} // 0x00000001842417C0-0x0000000184241830
		private void InternalRegisterTextElementForCullingUpdate(TMP_Text element) {} // 0x0000000184241830-0x00000001842418F0
		private void OnCameraPreCull() {} // 0x000000018BE33AEC-0x000000018BE33AF4
		private void DoRebuilds() {} // 0x00000001840E6EF0-0x00000001840E70A0
		internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) {} // 0x0000000184240E60-0x0000000184240ED0
		public static void UnRegisterTextElementForRebuild(TMP_Text element) {} // 0x000000018BE33BA4-0x000000018BE33C30
		private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) {} // 0x000000018BE339C4-0x000000018BE33A58
		private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) {} // 0x000000018BE33A58-0x000000018BE33AEC
		private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject) {} // 0x0000000184240FD0-0x0000000184241070
	}

	public class TMP_UpdateRegistry // TypeDefIndex: 53255
	{
		// Fields
		private static TMP_UpdateRegistry s_Instance; // 0x00
		private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
		private HashSet<int> m_LayoutQueueLookup; // 0x18
		private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
		private HashSet<int> m_GraphicQueueLookup; // 0x28
	
		// Properties
		public static TMP_UpdateRegistry instance { get => default; } // 0x000000018BE3436C-0x000000018BE3637C 
	
		// Constructors
		protected TMP_UpdateRegistry() {} // 0x000000018BE341F8-0x000000018BE3436C
	
		// Methods
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) {} // 0x000000018BE34180-0x000000018BE341B0
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) => default; // 0x000000018BE33D1C-0x000000018BE33E08
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) {} // 0x000000018BE34150-0x000000018BE34180
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) => default; // 0x000000018BE33C30-0x000000018BE33D1C
		private void PerformUpdateForCanvasRendererObjects() {} // 0x000000018BE33F98-0x000000018BE340FC
		private void PerformUpdateForMeshRendererObjects() {} // 0x000000018BE340FC-0x000000018BE34150
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) {} // 0x000000018BE341B0-0x000000018BE341F8
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) {} // 0x000000018BE33ED0-0x000000018BE33F98
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) {} // 0x000000018BE33E08-0x000000018BE33ED0
	}
}

namespace TMPro.SpriteAssetUtilities
{
	public enum SpriteAssetImportFormats // TypeDefIndex: 53256
	{
		None = 0,
		TexturePackerJsonArray = 1
	}

	public class TexturePacker_JsonArray // TypeDefIndex: 53262
	{
		// Nested types
		[Serializable]
		public struct SpriteFrame // TypeDefIndex: 53257
		{
			// Fields
			public float x; // 0x00
			public float y; // 0x04
			public float w; // 0x08
			public float h; // 0x0C
	
			// Methods
			public override string ToString() => default; // 0x0000000185492010-0x0000000185492020
		}
	
		[Serializable]
		public struct SpriteSize // TypeDefIndex: 53258
		{
			// Fields
			public float w; // 0x00
			public float h; // 0x04
	
			// Methods
			public override string ToString() => default; // 0x000000018BE33648-0x000000018BE337B8
		}
	
		[Serializable]
		public struct Frame // TypeDefIndex: 53259
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
		public struct Meta // TypeDefIndex: 53260
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
		public class SpriteDataObject // TypeDefIndex: 53261
		{
			// Fields
			public List<Frame> frames; // 0x10
			public Meta meta; // 0x18
	
			// Constructors
			public SpriteDataObject() {} // 0x000000018BE337B8-0x000000018BE3384C
		}
	
		// Constructors
		public TexturePacker_JsonArray() {} // 0x0000000185492010-0x0000000185492020
	}
}
