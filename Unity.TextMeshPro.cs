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

// Image 25: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 52221-52405
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.FontEngine.Tests")]
[assembly: InternalsVisibleTo("Unity.TextCore")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace TMPro
{
	public class FastAction // TypeDefIndex: 52222
	{
		// Fields
		private LinkedList<Action> delegates; // 0x10
		private Dictionary<Action, LinkedListNode<Action>> lookup; // 0x18
	
		// Constructors
		public FastAction() {} // 0x00000001837F5CE0-0x00000001837F5D90
	
		// Methods
		public void Add(Action rhs) {} // 0x0000000189CE3BCC-0x0000000189CE3C80
		public void Remove(Action rhs) {} // 0x0000000189CE3D00-0x0000000189CE3DB0
		public void Call() {} // 0x0000000189CE3C80-0x0000000189CE3D00
	}

	public class FastAction<A> // TypeDefIndex: 52223
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

	public class FastAction<A, B> // TypeDefIndex: 52224
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

	public class FastAction<A, B, C> // TypeDefIndex: 52225
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

	public interface IFontAssetLoader // TypeDefIndex: 52226
	{
		// Methods
		bool TryGetFontAsset(TMP_Text refText, uint unicode, out TMP_FontAsset fontAsset);
		void TryRemoveRefText(TMP_Text refText);
	}

	public interface ITextPreprocessor // TypeDefIndex: 52227
	{
		// Methods
		string PreprocessText(string text);
	}

	public class MaterialReferenceManager // TypeDefIndex: 52228
	{
		// Fields
		private static MaterialReferenceManager s_Instance; // 0x00
		private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
		private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
		private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
		private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x28
	
		// Properties
		public static MaterialReferenceManager instance { get => default; } // 0x0000000189CE4694-0x0000000189CE4724 
	
		// Constructors
		public MaterialReferenceManager() {} // 0x0000000189CE453C-0x0000000189CE4694
	
		// Methods
		public static void AddFontAsset(TMP_FontAsset fontAsset) {} // 0x0000000189CE3F28-0x0000000189CE3F58
		private void AddFontAssetInternal(TMP_FontAsset fontAsset) {} // 0x0000000189CE3E78-0x0000000189CE3F28
		public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset) {} // 0x0000000189CE4168-0x0000000189CE4198
		private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset) {} // 0x0000000189CE3FF8-0x0000000189CE40A8
		public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset) {} // 0x0000000189CE4198-0x0000000189CE41D4
		private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset) {} // 0x0000000189CE40A8-0x0000000189CE4168
		public static void AddFontMaterial(int hashCode, Material material) {} // 0x0000000189CE3FBC-0x0000000189CE3FF8
		private void AddFontMaterialInternal(int hashCode, Material material) {} // 0x0000000189CE3F58-0x0000000189CE3FBC
		public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset) {} // 0x0000000189CE3E3C-0x0000000189CE3E78
		private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset) {} // 0x0000000189CE3DB0-0x0000000189CE3E3C
		public bool Contains(TMP_FontAsset font) => default; // 0x0000000189CE41D4-0x0000000189CE4230
		public bool Contains(TMP_SpriteAsset sprite) => default; // 0x0000000189CE4230-0x0000000189CE428C
		public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset) {
			fontAsset = default;
			return default;
		} // 0x0000000189CE43A8-0x0000000189CE43E4
		private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset) {
			fontAsset = default;
			return default;
		} // 0x0000000189CE4338-0x0000000189CE43A8
		public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset) {
			spriteAsset = default;
			return default;
		} // 0x0000000189CE4500-0x0000000189CE453C
		private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset) {
			spriteAsset = default;
			return default;
		} // 0x0000000189CE4490-0x0000000189CE4500
		public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset) {
			gradientPreset = default;
			return default;
		} // 0x0000000189CE42FC-0x0000000189CE4338
		private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset) {
			gradientPreset = default;
			return default;
		} // 0x0000000189CE428C-0x0000000189CE42FC
		public static bool TryGetMaterial(int hashCode, out Material material) {
			material = default;
			return default;
		} // 0x0000000189CE4454-0x0000000189CE4490
		private bool TryGetMaterialInternal(int hashCode, out Material material) {
			material = default;
			return default;
		} // 0x0000000189CE43E4-0x0000000189CE4454
	}

	public struct TMP_MaterialReference // TypeDefIndex: 52229
	{
		// Fields
		public Material material; // 0x00
		public int referenceCount; // 0x08
	}

	public struct MaterialReference // TypeDefIndex: 52230
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
		} // 0x0000000182F5C690-0x0000000182F5C880
	
		// Methods
		public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset) => default; // 0x0000000189CE4910-0x0000000189CE49D8
		public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) => default; // 0x0000000182948900-0x0000000182948BD0
		public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) => default; // 0x0000000189CE4724-0x0000000189CE4910
	}

	public enum TextContainerAnchors // TypeDefIndex: 52231
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
	public class TextContainer : UIBehaviour // TypeDefIndex: 52232
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
		public bool hasChanged { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public Vector2 pivot { get => default; set {} } // 0x0000000183D84B60-0x0000000183D84B80 0x0000000189CE530C-0x0000000189CE537C
		public TextContainerAnchors anchorPosition { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000189CE522C-0x0000000189CE5274
		public Rect rect { get => default; set {} } // 0x0000000183D59E20-0x0000000183D59E30 0x0000000189CE537C-0x0000000189CE53D4
		public Vector2 size { get => default; set {} } // 0x0000000183D84B80-0x0000000183D84BA0 0x0000000189CE53D4-0x0000000189CE5434
		public float width { get => default; set {} } // 0x0000000183D84BA0-0x0000000183D84BB0 0x0000000189CE5434-0x0000000189CE547C
		public float height { get => default; set {} } // 0x00000001842743D0-0x00000001842743D8 0x0000000189CE5274-0x0000000189CE52BC
		public bool isDefaultWidth { get => default; } // 0x0000000183D4F190-0x0000000183D4F1A0 
		public bool isDefaultHeight { get => default; } // 0x0000000183D4F300-0x0000000183D4F310 
		public bool isAutoFitting { get => default; set {} } // 0x0000000183D4F500-0x0000000183D4F510 0x0000000183D4F530-0x0000000183D4F540
		public Vector3[] corners { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public Vector3[] worldCorners { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public Vector4 margins { get => default; set {} } // 0x0000000183D55950-0x0000000183D55960 0x0000000189CE52BC-0x0000000189CE530C
		public RectTransform rectTransform { get => default; } // 0x0000000189CE5124-0x0000000189CE51A8 
		public TextMeshPro textMeshPro { get => default; } // 0x0000000189CE51A8-0x0000000189CE522C 
	
		// Constructors
		public TextContainer() {} // 0x0000000189CE50AC-0x0000000189CE5124
		static TextContainer() {} // 0x0000000189CE506C-0x0000000189CE50AC
	
		// Methods
		protected override void Awake() {} // 0x0000000189CE49D8-0x0000000189CE4A78
		protected override void OnEnable() {} // 0x0000000189CE4D4C-0x0000000189CE4D54
		protected override void OnDisable() {} // 0x000000018350B670-0x000000018350B680
		private void OnContainerChanged() {} // 0x0000000189CE4C50-0x0000000189CE4D4C
		protected override void OnRectTransformDimensionsChange() {} // 0x0000000189CE4D54-0x0000000189CE4EAC
		private void SetRect(Vector2 size) {} // 0x0000000183D84B10-0x0000000183D84B60
		private void UpdateCorners() {} // 0x0000000189CE4EAC-0x0000000189CE506C
		private Vector2 GetPivot(TextContainerAnchors anchor) => default; // 0x0000000189CE4BC4-0x0000000189CE4C50
		private TextContainerAnchors GetAnchorPosition(Vector2 pivot) => default; // 0x0000000189CE4A78-0x0000000189CE4BC4
	}

	[AddComponentMenu("Mesh/TextMeshPro - Text")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.0")]
	[RequireComponent(typeof(MeshRenderer))]
	public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 52233
	{
		// Fields
		[SerializeField]
		internal int _SortingLayer; // 0xAF8
		[SerializeField]
		internal int _SortingLayerID; // 0xAFC
		[SerializeField]
		internal int _SortingOrder; // 0xB00
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
		public int sortingLayerID { get => default; set {} } // 0x0000000189CEE3F0-0x0000000189CEE46C 0x0000000189CEE688-0x0000000189CEE724
		public int sortingOrder { get => default; set {} } // 0x0000000189CEE46C-0x0000000189CEE4E8 0x0000000189CEE724-0x0000000189CEE7C0
		public override bool autoSizeTextContainer { get => default; set {} } // 0x0000000183D84BB0-0x0000000183D84BC0 0x0000000189CEE608-0x0000000189CEE678
		[Obsolete("The TextContainer is now obsolete. Use the RectTransform instead.")]
		public TextContainer textContainer { get => default; } // 0x0000000181002730-0x0000000181002740 
		public new Transform transform { get => default; } // 0x0000000189CEE4E8-0x0000000189CEE578 
		public Renderer renderer { get => default; } // 0x0000000189CEE360-0x0000000189CEE3F0 
		public override Mesh mesh { get => default; } // 0x0000000189CEE2A4-0x0000000189CEE360 
		public MeshFilter meshFilter { get => default; } // 0x0000000189CEE194-0x0000000189CEE2A4 
		public MaskingTypes maskType { get => default; set {} } // 0x0000000183D84BE0-0x0000000183D84BF0 0x0000000189CEE678-0x0000000189CEE688
	
		// Events
		public override event Action<TMP_TextInfo> OnPreRenderText;
	
		// Constructors
		public TextMeshPro() {} // 0x0000000189CEE048-0x0000000189CEE104
		static TextMeshPro() {} // 0x0000000189CEDBCC-0x0000000189CEE048
	
		// Methods
		public void SetMask(MaskingTypes type, Vector4 maskCoords) {} // 0x0000000189CEC2D0-0x0000000189CEC30C
		public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) {} // 0x0000000189CEC494-0x0000000189CEC4F0
		public override void SetVerticesDirty() {} // 0x0000000189CECF34-0x0000000189CECFB0
		public override void SetLayoutDirty() {} // 0x0000000189CEC0A4-0x0000000189CEC14C
		public override void SetMaterialDirty() {} // 0x0000000189381C74-0x0000000189381C84
		public override void SetAllDirty() {} // 0x0000000183219AC0-0x0000000183219B00
		public override void Rebuild(CanvasUpdate update) {} // 0x0000000189CE980C-0x0000000189CE98D0
		protected override void UpdateMaterial() {} // 0x0000000189CED27C-0x0000000189CED39C
		public override void UpdateMeshPadding() {} // 0x0000000189CED39C-0x0000000189CED4A4
		public override void ForceMeshUpdate(bool ignoreActiveState = false /* Metadata: 0x01FD18C6 */, bool forceTextReparsing = false /* Metadata: 0x01FD18C7 */) {} // 0x0000000189CE82A8-0x0000000189CE82BC
		public override TMP_TextInfo GetTextInfo(string text) => default; // 0x0000000189CE8AE4-0x0000000189CE8B3C
		public override void ClearMesh(bool updateMesh) {} // 0x0000000189CE7CA8-0x0000000189CE7D90
		public override void UpdateGeometry(Mesh mesh, int index) {} // 0x0000000189CED1EC-0x0000000189CED210
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) {} // 0x0000000189CED838-0x0000000189CED9FC
		public override void UpdateVertexData() {} // 0x0000000189CED9FC-0x0000000189CEDBCC
		public void UpdateFontAsset() {} // 0x0000000189CE6DC4-0x0000000189CE6DD4
		public void CalculateLayoutInputHorizontal() {} // 0x000000018350B670-0x000000018350B680
		public void CalculateLayoutInputVertical() {} // 0x000000018350B670-0x000000018350B680
		protected override void Awake() {} // 0x0000000189CE7880-0x0000000189CE7CA8
		protected override void OnEnable() {} // 0x0000000189CE9358-0x0000000189CE9420
		protected override void OnDisable() {} // 0x0000000189CE92C8-0x0000000189CE9358
		protected override void OnDestroy() {} // 0x0000000189CE9204-0x0000000189CE92AC
		protected override void LoadFontAsset() {} // 0x0000000189CE8BF4-0x0000000189CE9204
		private void UpdateEnvMapMatrix() {} // 0x0000000189CECFB0-0x0000000189CED1EC
		private void SetMask(MaskingTypes maskType) {} // 0x0000000189CEC30C-0x0000000189CEC494
		private void SetMaskCoordinates(Vector4 coords) {} // 0x0000000189CEC24C-0x0000000189CEC2D0
		private void SetMaskCoordinates(Vector4 coords, float softX, float softY) {} // 0x0000000189CEC14C-0x0000000189CEC24C
		private void EnableMasking() {} // 0x0000000189CE818C-0x0000000189CE82A8
		private void DisableMasking() {} // 0x0000000189CE8070-0x0000000189CE818C
		private void UpdateMask() {} // 0x0000000189CED210-0x0000000189CED27C
		protected override Material GetMaterial(Material mat) => default; // 0x0000000189CE866C-0x0000000189CE8778
		protected override Material[] GetMaterials(Material[] mats) => default; // 0x0000000189CE8778-0x0000000189CE88F4
		protected override void SetSharedMaterial(Material mat) {} // 0x0000000189CE6704-0x0000000189CE6744
		protected override Material[] GetSharedMaterials() => default; // 0x0000000189CE88F4-0x0000000189CE8A44
		protected override void SetSharedMaterials(Material[] materials) {} // 0x0000000189CECBB8-0x0000000189CECF34
		protected override void SetOutlineThickness(float thickness) {} // 0x0000000189CEC828-0x0000000189CEC998
		protected override void SetFaceColor(Color32 color) {} // 0x0000000189CEBF5C-0x0000000189CEC0A4
		protected override void SetOutlineColor(Color32 color) {} // 0x0000000189CEC6E0-0x0000000189CEC828
		private void CreateMaterialInstance() {} // 0x0000000189CE7ED8-0x0000000189CE7FB0
		protected override void SetShaderDepth() {} // 0x0000000189CECA38-0x0000000189CECBB8
		protected override void SetCulling() {} // 0x0000000189CEBC08-0x0000000189CEBF5C
		private void SetPerspectiveCorrection() {} // 0x0000000189CEC998-0x0000000189CECA38
		protected override int SetArraySizes(UnicodeChar[] unicodeChars) => default; // 0x0000000189CE9AE0-0x0000000189CEBC08
		public override void ComputeMarginSize() {} // 0x0000000189CE7D90-0x0000000189CE7ED8
		protected override void OnDidApplyAnimationProperties() {} // 0x0000000189CE92AC-0x0000000189CE92C8
		protected override void OnTransformParentChanged() {} // 0x0000000189CE97E4-0x0000000189CE980C
		protected override void OnRectTransformDimensionsChange() {} // 0x0000000189CE9664-0x0000000189CE97E4
		internal override void InternalUpdate() {} // 0x0000000189CE8B3C-0x0000000189CE8BF4
		private void OnPreRenderObject() {} // 0x0000000189CE9420-0x0000000189CE9664
		protected virtual void GenerateTextMesh() {} // 0x0000000189CD827C-0x0000000189CE3BCC
		protected override Vector3[] GetTextContainerLocalCorners() => default; // 0x0000000189CE8A44-0x0000000189CE8AE4
		private void SetMeshFilters(bool state) {} // 0x0000000189CEC4F0-0x0000000189CEC6E0
		protected override void SetActiveSubMeshes(bool state) {} // 0x0000000189CE98D0-0x0000000189CE99CC
		protected void SetActiveSubTextObjectRenderers(bool state) {} // 0x0000000189CE99CC-0x0000000189CE9AE0
		protected override void DestroySubMeshObjects() {} // 0x0000000189CE7FB0-0x0000000189CE8070
		internal void UpdateSubMeshSortingLayerID(int id) {} // 0x0000000189CED638-0x0000000189CED738
		internal void UpdateSubMeshSortingOrder(int order) {} // 0x0000000189CED738-0x0000000189CED838
		protected override Bounds GetCompoundBounds() => default; // 0x0000000189CE82BC-0x0000000189CE866C
		private void UpdateSDFScale(float scaleDelta) {} // 0x0000000189CED4A4-0x0000000189CED638
	}

	[AddComponentMenu("UI/TextMeshPro - Text (UI)", 11)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.0")]
	[RequireComponent(typeof(CanvasRenderer))]
	[RequireComponent(typeof(RectTransform))]
	public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 52236
	{
		// Fields
		private bool m_isRebuildingLayout; // 0xAF8
		private Coroutine m_DelayedGraphicRebuild; // 0xB00
		private Coroutine m_DelayedMaterialRebuild; // 0xB08
		private Rect m_ClipRect; // 0xB10
		private bool m_ValidRect; // 0xB20
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
		public override Material materialForRendering { get => default; } // 0x000000018303D6D0-0x000000018303D740 
		public override bool autoSizeTextContainer { get => default; set {} } // 0x0000000183D84BB0-0x0000000183D84BC0 0x0000000189CE77E8-0x0000000189CE7858
		public override Mesh mesh { get => default; } // 0x0000000183D84BD0-0x0000000183D84BE0 
		public new CanvasRenderer canvasRenderer { get => default; } // 0x0000000183069D40-0x0000000183069E80 
		public Vector4 maskOffset { get => default; set {} } // 0x0000000183D84BC0-0x0000000183D84BD0 0x0000000189CE7858-0x0000000189CE7880
	
		// Events
		public override event Action<TMP_TextInfo> OnPreRenderText;
	
		// Constructors
		public TextMeshProUGUI() {} // 0x0000000182845660-0x0000000182845730
		static TextMeshProUGUI() {} // 0x0000000183822750-0x0000000183822C20
	
		// Methods
		public void CalculateLayoutInputHorizontal() {} // 0x000000018350B670-0x000000018350B680
		public void CalculateLayoutInputVertical() {} // 0x000000018350B670-0x000000018350B680
		public override void SetVerticesDirty() {} // 0x000000018239E1A0-0x000000018239E310
		public override void SetLayoutDirty() {} // 0x00000001824A58A0-0x00000001824A5A00
		public override void SetMaterialDirty() {} // 0x000000018239B220-0x000000018239B3A0
		public override void SetAllDirty() {} // 0x0000000183219AC0-0x0000000183219B00
		[IteratorStateMachine(typeof(_DelayedGraphicRebuild_d__18))]
		private IEnumerator DelayedGraphicRebuild() => default; // 0x0000000189CE54C0-0x0000000189CE551C
		[IteratorStateMachine(typeof(_DelayedMaterialRebuild_d__19))]
		private IEnumerator DelayedMaterialRebuild() => default; // 0x0000000189CE551C-0x0000000189CE5578
		public override void Rebuild(CanvasUpdate update) {} // 0x000000018296B1E0-0x000000018296B310
		private void UpdateSubObjectPivot() {} // 0x00000001824A4AE0-0x00000001824A4BC0
		public override Material GetModifiedMaterial(Material baseMaterial) => default; // 0x00000001825172C0-0x0000000182517370
		protected override void UpdateMaterial() {} // 0x0000000183069B00-0x0000000183069D40
		public override void RecalculateClipping() {} // 0x0000000182515D70-0x0000000182515D80
		public override void Cull(Rect clipRect, bool validRect) {} // 0x0000000182342750-0x0000000182342A70
		internal override void UpdateCulling() {} // 0x0000000182C6F270-0x0000000182C6F4A0
		public override void UpdateMeshPadding() {} // 0x0000000189CE72A0-0x0000000189CE73A8
		protected override void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) {} // 0x00000001839DE190-0x00000001839DE1F0
		protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) {} // 0x0000000189CE5D0C-0x0000000189CE5DB8
		public override void ForceMeshUpdate(bool ignoreActiveState = false /* Metadata: 0x01FD18C8 */, bool forceTextReparsing = false /* Metadata: 0x01FD18C9 */) {} // 0x0000000182969C30-0x0000000182969CE0
		public override TMP_TextInfo GetTextInfo(string text) => default; // 0x0000000189CE5C40-0x0000000189CE5D0C
		public override void ClearMesh() {} // 0x0000000183536010-0x00000001835360D0
		public override void UpdateGeometry(Mesh mesh, int index) {} // 0x0000000189CE6DD4-0x0000000189CE6E60
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) {} // 0x0000000189CE73A8-0x0000000189CE75C0
		public override void UpdateVertexData() {} // 0x0000000189CE75C0-0x0000000189CE77E8
		public void UpdateFontAsset() {} // 0x0000000189CE6DC4-0x0000000189CE6DD4
		protected override void Awake() {} // 0x0000000182813FB0-0x00000001828142F0
		protected override void OnEnable() {} // 0x000000018239F800-0x000000018239F9A0
		protected override void OnDisable() {} // 0x000000018239E310-0x000000018239E5F0
		protected override void OnDestroy() {} // 0x000000018285F3B0-0x000000018285F520
		protected override void LoadFontAsset() {} // 0x000000018296C170-0x000000018296C560
		private Canvas GetCanvas() => default; // 0x000000018239F9A0-0x000000018239FB50
		private void UpdateEnvMapMatrix() {} // 0x0000000189CE6B88-0x0000000189CE6DC4
		private void EnableMasking() {} // 0x0000000189CE5638-0x0000000189CE583C
		private void DisableMasking() {} // 0x000000018350B670-0x000000018350B680
		private void UpdateMask() {} // 0x0000000189CE6E60-0x0000000189CE72A0
		protected override Material GetMaterial(Material mat) => default; // 0x0000000189CE583C-0x0000000189CE596C
		protected override Material[] GetMaterials(Material[] mats) => default; // 0x0000000189CE596C-0x0000000189CE5AEC
		protected override void SetSharedMaterial(Material mat) {} // 0x0000000189CE6704-0x0000000189CE6744
		protected override Material[] GetSharedMaterials() => default; // 0x0000000189CE5AEC-0x0000000189CE5C40
		protected override void SetSharedMaterials(Material[] materials) {} // 0x0000000189CE6744-0x0000000189CE6B88
		protected override void SetOutlineThickness(float thickness) {} // 0x0000000189CE6368-0x0000000189CE6540
		protected override void SetFaceColor(Color32 color) {} // 0x0000000189CE607C-0x0000000189CE6198
		protected override void SetOutlineColor(Color32 color) {} // 0x0000000189CE624C-0x0000000189CE6368
		protected override void SetShaderDepth() {} // 0x0000000189CE65E0-0x0000000189CE6704
		protected override void SetCulling() {} // 0x0000000189CE5DB8-0x0000000189CE607C
		private void SetPerspectiveCorrection() {} // 0x0000000189CE6540-0x0000000189CE65E0
		private void SetMeshArrays(int size) {} // 0x0000000189CE6198-0x0000000189CE624C
		protected override int SetArraySizes(UnicodeChar[] unicodeChars) => default; // 0x0000000182572210-0x0000000182573C20
		public override void ComputeMarginSize() {} // 0x00000001824A5690-0x00000001824A58A0
		protected override void OnDidApplyAnimationProperties() {} // 0x00000001834D36F0-0x00000001834D3720
		protected override void OnCanvasHierarchyChanged() {} // 0x00000001825A1A60-0x00000001825A1BD0
		protected override void OnTransformParentChanged() {} // 0x0000000183163500-0x0000000183163550
		protected override void OnRectTransformDimensionsChange() {} // 0x00000001824A4840-0x00000001824A4AE0
		internal override void InternalUpdate() {} // 0x00000001823432D0-0x00000001823433D0
		private void OnPreRenderCanvas() {} // 0x000000018296B310-0x000000018296B720
		protected virtual TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) => default; // 0x0000000189CE547C-0x0000000189CE54C0
		protected virtual void GenerateTextMesh() {} // 0x0000000182575510-0x000000018257C5B0
		protected override Vector3[] GetTextContainerLocalCorners() => default; // 0x00000001830D8960-0x00000001830D8AB0
		protected override void SetActiveSubMeshes(bool state) {} // 0x00000001830924F0-0x0000000183092690
		protected override void DestroySubMeshObjects() {} // 0x0000000189CE5578-0x0000000189CE5638
		protected override Bounds GetCompoundBounds() => default; // 0x00000001823F1700-0x00000001823F2220
		internal override Rect GetCanvasSpaceClippingRect() => default; // 0x00000001823433D0-0x0000000182343990
		private void UpdateSDFScale(float scaleDelta) {} // 0x000000018285D480-0x000000018285D640
	}

	public class ThaiTextPreprocessor : ITextPreprocessor // TypeDefIndex: 52237
	{
		// Fields
		private static ThaiTextPreprocessor _instance; // 0x00
	
		// Properties
		public static ThaiTextPreprocessor Instance { get => default; } // 0x0000000189CEE7C0-0x0000000189CEE810 
	
		// Constructors
		public ThaiTextPreprocessor() {} // 0x000000018350B670-0x000000018350B680
		static ThaiTextPreprocessor() {} // 0x0000000183D1ABD0-0x0000000183D1AC30
	
		// Methods
		public string PreprocessText(string text) => default; // 0x0000000182815E90-0x0000000182815F10
	}

	public enum Compute_DistanceTransform_EventTypes // TypeDefIndex: 52238
	{
		Processing = 0,
		Completed = 1
	}

	public static class TMPro_EventManager // TypeDefIndex: 52239
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
		static TMPro_EventManager() {} // 0x00000001837F5860-0x00000001837F5CE0
	
		// Methods
		public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) {} // 0x0000000189CFB6E0-0x0000000189CFB760
		public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj) {} // 0x0000000189CFB660-0x0000000189CFB6E0
		public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj) {} // 0x0000000189CFB7B4-0x0000000189CFB834
		public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj) {} // 0x0000000189CFB834-0x0000000189CFB8B4
		public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) {} // 0x0000000189CFB5CC-0x0000000189CFB660
		public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) {} // 0x0000000189CFB934-0x0000000189CFB9A0
		public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(UnityEngine.Object obj) {} // 0x0000000189CFB4E0-0x0000000189CFB550
		public static void ON_TEXT_CHANGED(UnityEngine.Object obj) {} // 0x00000001831DD5F0-0x00000001831DD670
		public static void ON_TMP_SETTINGS_CHANGED() {} // 0x0000000189CFB9A0-0x0000000189CFB9F4
		public static void ON_RESOURCES_LOADED() {} // 0x0000000189CFB760-0x0000000189CFB7B4
		public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj) {} // 0x0000000189CFB8B4-0x0000000189CFB934
		public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) {} // 0x0000000189CFB550-0x0000000189CFB5CC
	}

	public class Compute_DT_EventArgs // TypeDefIndex: 52240
	{
		// Fields
		public Compute_DistanceTransform_EventTypes EventType; // 0x10
		public float ProgressPercentage; // 0x14
		public UnityEngine.Color[] Colors; // 0x18
	
		// Constructors
		public Compute_DT_EventArgs() {} // Dummy constructor
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress) {} // 0x0000000183D84BF0-0x0000000183D84C00
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, UnityEngine.Color[] colors) {} // 0x0000000184270E40-0x0000000184270E50
	}

	public static class TMPro_ExtensionMethods // TypeDefIndex: 52241
	{
		// Extension methods
		public static int[] ToIntArray(this string text) => default; // 0x0000000189CFBFA4-0x0000000189CFC034
		public static string ArrayToString(this char[] chars) => default; // 0x0000000189CFB9F4-0x0000000189CFBAB8
		public static string IntToString(this int[] unicodes) => default; // 0x0000000189CFBC68-0x0000000189CFBCE8
		internal static string UintToString(this List<uint> unicodes) => default; // 0x0000000189CFC034-0x0000000189CFC0E4
		public static string IntToString(this int[] unicodes, int start, int length) => default; // 0x0000000189CFBCE8-0x0000000189CFBDBC
		public static int FindInstanceID<T>(this List<T> list, T target)
			where T : UnityEngine.Object => default;
		public static bool Compare(this Color32 a, Color32 b) => default; // 0x0000000189CFBADC-0x0000000189CFBB14
		public static bool CompareRGB(this Color32 a, Color32 b) => default; // 0x0000000189CFBAB8-0x0000000189CFBADC
		public static bool Compare(this UnityEngine.Color a, UnityEngine.Color b) => default; // 0x00000001822CDA10-0x00000001822CDA50
		public static bool CompareRGB(this UnityEngine.Color a, UnityEngine.Color b) => default; // 0x0000000182799940-0x0000000182799970
		public static Color32 Multiply(this Color32 c1, Color32 c2) => default; // 0x0000000189CFBDE4-0x0000000189CFBEC4
		public static Color32 Tint(this Color32 c1, Color32 c2) => default; // 0x0000000189CFBDE4-0x0000000189CFBEC4
		public static Color32 Tint(this Color32 c1, float tint) => default; // 0x0000000189CFBEC4-0x0000000189CFBFA4
		public static UnityEngine.Color MinAlpha(this UnityEngine.Color c1, UnityEngine.Color c2) => default; // 0x0000000189CFBDBC-0x0000000189CFBDE4
		public static bool Compare(this Vector3 v1, Vector3 v2, int accuracy) => default; // 0x0000000189CFBBD8-0x0000000189CFBC68
		public static bool Compare(this Quaternion q1, Quaternion q2, int accuracy) => default; // 0x0000000189CFBB14-0x0000000189CFBBD8
	}

	public static class TMP_Math // TypeDefIndex: 52242
	{
		// Fields
		public const float FLOAT_MAX = 32767f; // Metadata: 0x01FD18CC
		public const float FLOAT_MIN = -32767f; // Metadata: 0x01FD18D0
		public const int INT_MAX = 2147483647; // Metadata: 0x01FD18D4
		public const int INT_MIN = -2147483647; // Metadata: 0x01FD18D5
		public const float FLOAT_UNSET = -32767f; // Metadata: 0x01FD18DA
		public const int INT_UNSET = -32767; // Metadata: 0x01FD18DE
		public static Vector2 MAX_16BIT; // 0x00
		public static Vector2 MIN_16BIT; // 0x08
	
		// Constructors
		static TMP_Math() {} // 0x0000000189CFB14C-0x0000000189CFB1A8
	
		// Methods
		public static bool Approximately(float a, float b) => default; // 0x0000000189CFB110-0x0000000189CFB134
		public static int Mod(int a, int b) => default; // 0x0000000189CFB134-0x0000000189CFB14C
	}

	public enum TMP_VertexDataUpdateFlags // TypeDefIndex: 52243
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
	public struct VertexGradient // TypeDefIndex: 52244
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
		} // 0x0000000183D84DC0-0x0000000183D84DE0
		public VertexGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3) {
			topLeft = default;
			topRight = default;
			bottomLeft = default;
			bottomRight = default;
		} // 0x0000000183D7E4A0-0x0000000183D7E4D0
	}

	public struct TMP_PageInfo // TypeDefIndex: 52245
	{
		// Fields
		public int firstCharacterIndex; // 0x00
		public int lastCharacterIndex; // 0x04
		public float ascender; // 0x08
		public float baseLine; // 0x0C
		public float descender; // 0x10
	}

	public struct TMP_LinkInfo // TypeDefIndex: 52246
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
		internal void SetLinkID(char[] text, int startIndex, int length) {} // 0x0000000189CFB04C-0x0000000189CFB110
		public string GetLinkText() => default; // 0x0000000189CFAF6C-0x0000000189CFB04C
		public string GetLinkID() => default; // 0x0000000189CFAEE0-0x0000000189CFAF6C
	}

	public struct TMP_WordInfo // TypeDefIndex: 52247
	{
		// Fields
		public TMP_Text textComponent; // 0x00
		public int firstCharacterIndex; // 0x08
		public int lastCharacterIndex; // 0x0C
		public int characterCount; // 0x10
	
		// Methods
		public string GetWord() => default; // 0x0000000189CFB3FC-0x0000000189CFB4E0
	}

	public struct TMP_SpriteInfo // TypeDefIndex: 52248
	{
		// Fields
		public int spriteIndex; // 0x00
		public int characterIndex; // 0x04
		public int vertexIndex; // 0x08
	}

	public struct Extents // TypeDefIndex: 52249
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
		} // 0x0000000183D4EA10-0x0000000183D4EA20
		static Extents() {
			zero = default;
			uninitialized = default;
		} // 0x0000000189CEEEA8-0x0000000189CEEF00
	
		// Methods
		public override string ToString() => default; // 0x0000000189CEED24-0x0000000189CEEEA8
	}

	[Serializable]
	public struct Mesh_Extents // TypeDefIndex: 52250
	{
		// Fields
		public Vector2 min; // 0x00
		public Vector2 max; // 0x08
	
		// Constructors
		public Mesh_Extents(Vector2 min, Vector2 max) {
			this.min = default;
			this.max = default;
		} // 0x0000000183D4EA10-0x0000000183D4EA20
	
		// Methods
		public override string ToString() => default; // 0x0000000189CEFAE0-0x0000000189CEFC64
	}

	public struct WordWrapState // TypeDefIndex: 52251
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

	public struct TagAttribute // TypeDefIndex: 52252
	{
		// Fields
		public int startIndex; // 0x00
		public int length; // 0x04
		public int hashCode; // 0x08
	}

	public struct RichTextTagAttribute // TypeDefIndex: 52253
	{
		// Fields
		public int nameHashCode; // 0x00
		public int valueHashCode; // 0x04
		public TagValueType valueType; // 0x08
		public int valueStartIndex; // 0x0C
		public int valueLength; // 0x10
		public TagUnitType unitType; // 0x14
	}

	internal class TMP_ArrayObjectPool<T> // TypeDefIndex: 52255
	{
		// Fields
		private readonly Dictionary<int, Stack<T[]>> m_StackDic;
		private readonly UnityAction<T[]> m_ActionOnGet;
		private readonly UnityAction<T[]> m_ActionOnRelease;
		private readonly PoolOptions m_Options;
		private int m_TotalCachedCount;
	
		// Properties
		public int countAll { get; private set; }
		public int countActive { get => default; }
		public int countInactive { get => default; }
	
		// Nested types
		[IsReadOnly]
		internal struct PoolOptions // TypeDefIndex: 52254
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

	internal static class TMP_ArrayPool<T> // TypeDefIndex: 52257
	{
		// Fields
		private static readonly TMP_ArrayObjectPool<T> s_ArrayPool;
		private static readonly TMP_ArrayPoolWrapper<T> s_ArrayPoolWrapper;
	
		// Constructors
		static TMP_ArrayPool() {}
	
		// Methods
		private static TMP_ArrayObjectPool<T> _CreateOptions() => default;
		public static T[] Get(int count) => default;
		public static void Release(T[] toRelease) {}
		public static void Resize(ref ref T[] array, int newCount) {}
		public static void Shrink() {}
	}

	public interface IPoolClearable // TypeDefIndex: 52258
	{
		// Methods
		void Clear();
	}

	internal interface ITMPArrayPoolRegistryItem // TypeDefIndex: 52259
	{
		// Methods
		void Shrink();
	}

	public static class TMP_ArrayPoolRegistry // TypeDefIndex: 52260
	{
		// Fields
		private static readonly List<ITMPArrayPoolRegistryItem> registeredPools; // 0x00
	
		// Constructors
		static TMP_ArrayPoolRegistry() {} // 0x0000000182296140-0x00000001822976D0
	
		// Methods
		internal static void Register(ITMPArrayPoolRegistryItem pool) {} // 0x0000000182294F90-0x0000000182295860
		public static void ShrinkAll() {} // 0x0000000182295860-0x0000000182296140
	}

	internal class TMP_ArrayPoolWrapper<T> : ITMPArrayPoolRegistryItem // TypeDefIndex: 52261
	{
		// Constructors
		public TMP_ArrayPoolWrapper() {}
	
		// Methods
		public void Shrink() {}
	}

	[Serializable]
	public abstract class TMP_Asset : ScriptableObject // TypeDefIndex: 52262
	{
		// Fields
		private int m_InstanceID; // 0x18
		public int hashCode; // 0x1C
		public Material material; // 0x20
		public int materialHashCode; // 0x28
	
		// Properties
		public int instanceID { get; } // 0x0000000182573C20-0x0000000182573C50 
	
		// Constructors
		protected TMP_Asset() {} // 0x000000018286F540-0x000000018286F550
	}

	[Serializable]
	public class TMP_Character : TMP_TextElement // TypeDefIndex: 52263
	{
		// Constructors
		public TMP_Character() {} // 0x0000000183D84CA0-0x0000000183D84CB0
		public TMP_Character(uint unicode, Glyph glyph) {} // 0x0000000189CEFD1C-0x0000000189CEFD68
		public TMP_Character(uint unicode, TMP_FontAsset fontAsset, Glyph glyph) {} // 0x0000000182EE8F00-0x0000000182EE8F50
		internal TMP_Character(uint unicode, uint glyphIndex) {} // 0x0000000189CEFCDC-0x0000000189CEFD1C
	}

	public struct TMP_Vertex // TypeDefIndex: 52264
	{
		// Fields
		public Vector3 position; // 0x00
		public Vector2 uv; // 0x0C
		public Vector2 uv2; // 0x14
		public Vector2 uv4; // 0x1C
		public Color32 color; // 0x24
		private static readonly TMP_Vertex k_Zero; // 0x00
	
		// Properties
		public static TMP_Vertex zero { get => default; } // 0x0000000189CFB39C-0x0000000189CFB3FC 
	
		// Constructors
		static TMP_Vertex() {
			k_Zero = default;
		} // 0x000000018350B670-0x000000018350B680
	}

	public struct TMP_Offset // TypeDefIndex: 52265
	{
		// Fields
		private float m_Left; // 0x00
		private float m_Right; // 0x04
		private float m_Top; // 0x08
		private float m_Bottom; // 0x0C
		private static readonly TMP_Offset k_ZeroOffset; // 0x00
	
		// Properties
		public float left { get => default; set {} } // 0x0000000183D4FA00-0x0000000183D4FA10 0x0000000183D58BD0-0x0000000183D58BE0
		public float right { get => default; set {} } // 0x0000000183D58BC0-0x0000000183D58BD0 0x0000000183D58BF0-0x0000000183D58C00
		public float top { get => default; set {} } // 0x0000000183D58BB0-0x0000000183D58BC0 0x0000000183D58BE0-0x0000000183D58BF0
		public float bottom { get => default; set {} } // 0x0000000183D5E120-0x0000000183D5E130 0x0000000183D5E130-0x0000000183D5E140
		public float horizontal { get => default; set {} } // 0x0000000183D4FA00-0x0000000183D4FA10 0x0000000183D7F8C0-0x0000000183D7F8D0
		public float vertical { get => default; set {} } // 0x0000000183D58BB0-0x0000000183D58BC0 0x0000000183D84DB0-0x0000000183D84DC0
		public static TMP_Offset zero { get => default; } // 0x0000000189CFB2D4-0x0000000189CFB330 
	
		// Constructors
		public TMP_Offset(float left, float right, float top, float bottom) : this() {
			m_Left = default;
			m_Right = default;
			m_Top = default;
			m_Bottom = default;
		} // 0x0000000183D516B0-0x0000000183D516D0
		public TMP_Offset(float horizontal, float vertical) : this() {
			m_Left = default;
			m_Right = default;
			m_Top = default;
			m_Bottom = default;
		} // 0x0000000183D84D90-0x0000000183D84DB0
		static TMP_Offset() {
			k_ZeroOffset = default;
		} // 0x0000000183D3B6A0-0x0000000183D3B6E0
	
		// Methods
		public static bool operator ==(TMP_Offset lhs, TMP_Offset rhs) => default; // 0x00000001822CDA10-0x00000001822CDA50
		public static bool operator !=(TMP_Offset lhs, TMP_Offset rhs) => default; // 0x0000000189CFB330-0x0000000189CFB39C
		public static TMP_Offset operator *(TMP_Offset a, float b) => default; // 0x0000000182E260C0-0x0000000182E260E0
		public override int GetHashCode() => default; // 0x0000000189CFB284-0x0000000189CFB2D4
		public override bool Equals(object obj) => default; // 0x0000000189CFB224-0x0000000189CFB284
		public bool Equals(TMP_Offset other) => default; // 0x0000000189CFB1A8-0x0000000189CFB224
	}

	public struct HighlightState // TypeDefIndex: 52266
	{
		// Fields
		public Color32 color; // 0x00
		public TMP_Offset padding; // 0x04
	
		// Constructors
		public HighlightState(Color32 color, TMP_Offset padding) {
			this.color = default;
			this.padding = default;
		} // 0x0000000183D675C0-0x0000000183D675D0
	
		// Methods
		public static bool operator ==(HighlightState lhs, HighlightState rhs) => default; // 0x0000000189CEF284-0x0000000189CEF348
		public static bool operator !=(HighlightState lhs, HighlightState rhs) => default; // 0x0000000189CEF348-0x0000000189CEF384
		public override int GetHashCode() => default; // 0x0000000189CEF230-0x0000000189CEF284
		public override bool Equals(object obj) => default; // 0x0000000189CEF144-0x0000000189CEF1A8
		public bool Equals(HighlightState other) => default; // 0x0000000189CEF1A8-0x0000000189CEF230
	}

	[DebuggerDisplay("Unicode \'{character}\'  ({((uint)character).ToString(\"X\")})")]
	public struct TMP_CharacterInfo : IPoolClearable // TypeDefIndex: 52267
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
		public void Clear() {} // 0x000000018285E6A0-0x000000018285E6F0
	}

	public enum ColorMode // TypeDefIndex: 52268
	{
		Single = 0,
		HorizontalGradient = 1,
		VerticalGradient = 2,
		FourCornersGradient = 3
	}

	[Serializable]
	[ExcludeFromPreset]
	public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 52269
	{
		// Fields
		public ColorMode colorMode; // 0x18
		public UnityEngine.Color topLeft; // 0x1C
		public UnityEngine.Color topRight; // 0x2C
		public UnityEngine.Color bottomLeft; // 0x3C
		public UnityEngine.Color bottomRight; // 0x4C
		private const ColorMode k_DefaultColorMode = ColorMode.FourCornersGradient; // Metadata: 0x01FD18EE
		private static readonly UnityEngine.Color k_DefaultColor; // 0x00
	
		// Constructors
		public TMP_ColorGradient() {} // 0x0000000189CEFDAC-0x0000000189CEFE58
		public TMP_ColorGradient(UnityEngine.Color color) {} // 0x0000000189CEFE58-0x0000000189CEFE9C
		public TMP_ColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3) {} // 0x0000000189CEFE9C-0x0000000189CEFF0C
		static TMP_ColorGradient() {} // 0x0000000189CEFD68-0x0000000189CEFDAC
	}

	public static class TMP_Compatibility // TypeDefIndex: 52271
	{
		// Nested types
		public enum AnchorPositions // TypeDefIndex: 52270
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
		public static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue) => default; // 0x0000000189CEFF0C-0x0000000189CF0028
	}

	internal interface ITweenValue // TypeDefIndex: 52272
	{
		// Properties
		bool ignoreTimeScale { get; }
		float duration { get; }
	
		// Methods
		void TweenValue(float floatPercentage);
		bool ValidTarget();
	}

	internal struct ColorTween : ITweenValue // TypeDefIndex: 52275
	{
		// Fields
		private ColorTweenCallback m_Target; // 0x00
		private UnityEngine.Color m_StartColor; // 0x08
		private UnityEngine.Color m_TargetColor; // 0x18
		private ColorTweenMode m_TweenMode; // 0x28
		private float m_Duration; // 0x2C
		private bool m_IgnoreTimeScale; // 0x30
	
		// Properties
		public UnityEngine.Color startColor { get => default; set {} } // 0x00000001820C61C0-0x00000001820C61D0 0x0000000183D707A0-0x0000000183D707B0
		public UnityEngine.Color targetColor { get => default; set {} } // 0x0000000183D51D80-0x0000000183D51D90 0x0000000183D51D90-0x0000000183D51DA0
		public ColorTweenMode tweenMode { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public float duration { get => default; set {} } // 0x0000000183D4F3A0-0x0000000183D4F3B0 0x0000000183D4F3B0-0x0000000183D4F3C0
		public bool ignoreTimeScale { get => default; set {} } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000183D4EF70-0x0000000183D4EF80
	
		// Nested types
		public enum ColorTweenMode // TypeDefIndex: 52273
		{
			All = 0,
			RGB = 1,
			Alpha = 2
		}
	
		public class ColorTweenCallback : UnityEvent<UnityEngine.Color> // TypeDefIndex: 52274
		{
			// Constructors
			public ColorTweenCallback() {} // 0x0000000189CEEA58-0x0000000189CEEA94
		}
	
		// Methods
		public void TweenValue(float floatPercentage) {} // 0x0000000189CEEB2C-0x0000000189CEEC04
		public void AddOnChangedCallback(UnityAction<UnityEngine.Color> callback) {} // 0x0000000189CEEA94-0x0000000189CEEB2C
		public bool GetIgnoreTimescale() => default; // 0x0000000183D4EF60-0x0000000183D4EF70
		public float GetDuration() => default; // 0x0000000183D4F3A0-0x0000000183D4F3B0
		public bool ValidTarget() => default; // 0x00000001822B4F90-0x00000001822B4FA0
	}

	internal struct FloatTween : ITweenValue // TypeDefIndex: 52277
	{
		// Fields
		private FloatTweenCallback m_Target; // 0x00
		private float m_StartValue; // 0x08
		private float m_TargetValue; // 0x0C
		private float m_Duration; // 0x10
		private bool m_IgnoreTimeScale; // 0x14
	
		// Properties
		public float startValue { get => default; set {} } // 0x0000000183D58BB0-0x0000000183D58BC0 0x0000000183D58BE0-0x0000000183D58BF0
		public float targetValue { get => default; set {} } // 0x0000000183D5E120-0x0000000183D5E130 0x0000000183D5E130-0x0000000183D5E140
		public float duration { get => default; set {} } // 0x0000000183D4E7A0-0x0000000183D4E7B0 0x0000000183D50CA0-0x0000000183D50CB0
		public bool ignoreTimeScale { get => default; set {} } // 0x0000000183D58C00-0x0000000183D58C10 0x0000000183D58C20-0x0000000183D58C30
	
		// Nested types
		public class FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 52276
		{
			// Constructors
			public FloatTweenCallback() {} // 0x0000000189CEEF00-0x0000000189CEEF3C
		}
	
		// Methods
		public void TweenValue(float floatPercentage) {} // 0x0000000189CEEFD4-0x0000000189CEF038
		public void AddOnChangedCallback(UnityAction<float> callback) {} // 0x0000000189CEEF3C-0x0000000189CEEFD4
		public bool GetIgnoreTimescale() => default; // 0x0000000183D58C00-0x0000000183D58C10
		public float GetDuration() => default; // 0x0000000183D4E7A0-0x0000000183D4E7B0
		public bool ValidTarget() => default; // 0x00000001822B4F90-0x00000001822B4FA0
	}

	internal class TweenRunner<T> // TypeDefIndex: 52279
		where T : struct, ITweenValue
	{
		// Fields
		protected MonoBehaviour m_CoroutineContainer;
		protected IEnumerator m_Tween;
	
		// Constructors
		public TweenRunner() {}
	
		// Methods
		[IteratorStateMachine(typeof(_Start_d__2))]
		private static IEnumerator Start(T tweenInfo) => default;
		public void Init(MonoBehaviour coroutineContainer) {}
		public void StartTween(T info) {}
		public void StopTween() {}
	}

	public static class TMP_DefaultControls // TypeDefIndex: 52281
	{
		// Fields
		private const float kWidth = 160f; // Metadata: 0x01FD18FD
		private const float kThickHeight = 30f; // Metadata: 0x01FD1901
		private const float kThinHeight = 20f; // Metadata: 0x01FD1905
		private static Vector2 s_TextElementSize; // 0x00
		private static Vector2 s_ThickElementSize; // 0x08
		private static Vector2 s_ThinElementSize; // 0x10
		private static UnityEngine.Color s_DefaultSelectableColor; // 0x18
		private static UnityEngine.Color s_TextColor; // 0x28
	
		// Nested types
		public struct Resources // TypeDefIndex: 52280
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
		static TMP_DefaultControls() {} // 0x0000000189CF1D18-0x0000000189CF1DC0
	
		// Methods
		private static GameObject CreateUIElementRoot(string name, Vector2 size) => default; // 0x0000000189CF196C-0x0000000189CF1A0C
		private static GameObject CreateUIObject(string name, GameObject parent) => default; // 0x0000000189CF1A0C-0x0000000189CF1ABC
		private static void SetDefaultTextValues(TMP_Text lbl) {} // 0x0000000189CF1B0C-0x0000000189CF1B8C
		private static void SetDefaultColorTransitionValues(Selectable slider) {} // 0x0000000189CF1ABC-0x0000000189CF1B0C
		private static void SetParentAndAlign(GameObject child, GameObject parent) {} // 0x0000000189CF1C4C-0x0000000189CF1D18
		private static void SetLayerRecursively(GameObject go, int layer) {} // 0x0000000189CF1B8C-0x0000000189CF1C4C
		public static GameObject CreateScrollbar(Resources resources) => default; // 0x0000000189CF15F4-0x0000000189CF18D0
		public static GameObject CreateButton(Resources resources) => default; // 0x0000000189CF0028-0x0000000189CF02A4
		public static GameObject CreateText(Resources resources) => default; // 0x0000000189CF18D0-0x0000000189CF196C
		public static GameObject CreateInputField(Resources resources) => default; // 0x0000000189CF104C-0x0000000189CF15F4
		public static GameObject CreateDropdown(Resources resources) => default; // 0x0000000189CF02A4-0x0000000189CF104C
	}

	[AddComponentMenu("UI/Dropdown - TextMeshPro", 35)]
	[RequireComponent(typeof(RectTransform))]
	public class TMP_Dropdown : Selectable, IPointerClickHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 52288
	{
		// Fields
		[SerializeField]
		private RectTransform m_Template; // 0x180
		[SerializeField]
		private TMP_Text m_CaptionText; // 0x188
		[SerializeField]
		private Image m_CaptionImage; // 0x190
		[SerializeField]
		private Graphic m_Placeholder; // 0x198
		[SerializeField]
		[Space]
		private TMP_Text m_ItemText; // 0x1A0
		[SerializeField]
		private Image m_ItemImage; // 0x1A8
		[SerializeField]
		[Space]
		private int m_Value; // 0x1B0
		[SerializeField]
		[Space]
		private OptionDataList m_Options; // 0x1B8
		[SerializeField]
		[Space]
		private DropdownEvent m_OnValueChanged; // 0x1C0
		[SerializeField]
		private float m_AlphaFadeSpeed; // 0x1C8
		private GameObject m_Dropdown; // 0x1D0
		private GameObject m_Blocker; // 0x1D8
		private List<DropdownItem> m_Items; // 0x1E0
		private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x1E8
		private bool validTemplate; // 0x1F0
		private Coroutine m_Coroutine; // 0x1F8
		private static OptionData s_NoOptionData; // 0x00
	
		// Properties
		public RectTransform template { get => default; set {} } // 0x0000000183D56B50-0x0000000183D56B60 0x0000000189CF4BE0-0x0000000189CF4C08
		public TMP_Text captionText { get => default; set {} } // 0x0000000183D56AF0-0x0000000183D56B00 0x0000000189CF4B0C-0x0000000189CF4B34
		public Image captionImage { get => default; set {} } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000189CF4AE4-0x0000000189CF4B0C
		public Graphic placeholder { get => default; set {} } // 0x0000000183D56AE0-0x0000000183D56AF0 0x0000000189CF4BB8-0x0000000189CF4BE0
		public TMP_Text itemText { get => default; set {} } // 0x0000000183D56AD0-0x0000000183D56AE0 0x0000000189CF4B5C-0x0000000189CF4B84
		public Image itemImage { get => default; set {} } // 0x0000000183D57170-0x0000000183D57180 0x0000000189CF4B34-0x0000000189CF4B5C
		public List<OptionData> options { get => default; set {} } // 0x0000000189CF4AC4-0x0000000189CF4AE4 0x0000000189CF4B84-0x0000000189CF4BB8
		public DropdownEvent onValueChanged { get => default; set {} } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000184275C68-0x0000000184275C7C
		public float alphaFadeSpeed { get => default; set {} } // 0x0000000183D59880-0x0000000183D59890 0x0000000183D5BAC0-0x0000000183D5BAD0
		public int value { get => default; set {} } // 0x0000000183D84CB0-0x0000000183D84CC0 0x0000000189CF4C08-0x0000000189CF4C14
		public bool IsExpanded { get => default; } // 0x0000000189CF4A70-0x0000000189CF4AC4 
	
		// Nested types
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, ICancelHandler // TypeDefIndex: 52282
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
			public TMP_Text text { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
			public Image image { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
			public RectTransform rectTransform { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
			public Toggle toggle { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
	
			// Constructors
			public DropdownItem() {} // 0x000000018426FE60-0x000000018426FE68
	
			// Methods
			public virtual void OnPointerEnter(PointerEventData eventData) {} // 0x0000000189CEECB8-0x0000000189CEED24
			public virtual void OnCancel(BaseEventData eventData) {} // 0x0000000189CEEC40-0x0000000189CEECB8
		}
	
		[Serializable]
		public class OptionData // TypeDefIndex: 52283
		{
			// Fields
			[SerializeField]
			private string m_Text; // 0x10
			[SerializeField]
			private Sprite m_Image; // 0x18
	
			// Properties
			public string text { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
			public Sprite image { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
			// Constructors
			public OptionData() {} // 0x000000018350B670-0x000000018350B680
			public OptionData(string text) {} // 0x000000018426FEE0-0x000000018426FEF0
			public OptionData(Sprite image) {} // 0x00000001822C3A90-0x00000001822C3AA0
			public OptionData(string text, Sprite image) {} // 0x0000000182676770-0x00000001826767A0
		}
	
		[Serializable]
		public class OptionDataList // TypeDefIndex: 52284
		{
			// Fields
			[SerializeField]
			private List<OptionData> m_Options; // 0x10
	
			// Properties
			public List<OptionData> options { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
			// Constructors
			public OptionDataList() {} // 0x0000000189CEFC64-0x0000000189CEFCDC
		}
	
		[Serializable]
		public class DropdownEvent : UnityEvent<int> // TypeDefIndex: 52285
		{
			// Constructors
			public DropdownEvent() {} // 0x0000000189CEEC04-0x0000000189CEEC40
		}
	
		// Constructors
		protected TMP_Dropdown() {} // 0x0000000189CF4948-0x0000000189CF4A70
		static TMP_Dropdown() {} // 0x0000000189CF48D8-0x0000000189CF4948
	
		// Methods
		public void SetValueWithoutNotify(int input) {} // 0x0000000189CF3328-0x0000000189CF3334
		private void SetValue(int value, bool sendCallback = true /* Metadata: 0x01FD1909 */) {} // 0x0000000189CF3334-0x0000000189CF346C
		protected override void Awake() {} // 0x0000000189CF249C-0x0000000189CF2584
		protected override void Start() {} // 0x0000000189CF4848-0x0000000189CF48D8
		protected override void OnDisable() {} // 0x0000000189CF2E80-0x0000000189CF2F14
		public void RefreshShownValue() {} // 0x0000000189CF3024-0x0000000189CF3288
		public void AddOptions(List<OptionData> options) {} // 0x0000000189CF204C-0x0000000189CF20B4
		public void AddOptions(List<string> options) {} // 0x0000000189CF20B4-0x0000000189CF21A4
		public void AddOptions(List<Sprite> options) {} // 0x0000000189CF21A4-0x0000000189CF2294
		public void ClearOptions() {} // 0x0000000189CF2584-0x0000000189CF261C
		private void SetupTemplate() {} // 0x0000000189CF346C-0x0000000189CF3A70
		private static T GetOrAddComponent<T>(GameObject go)
			where T : Component => default;
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x0000000189CF2F14-0x0000000189CF2F1C
		public virtual void OnSubmit(BaseEventData eventData) {} // 0x0000000189CF2F14-0x0000000189CF2F1C
		public virtual void OnCancel(BaseEventData eventData) {} // 0x0000000189CF2E78-0x0000000189CF2E80
		public void Show() {} // 0x0000000189CF3A70-0x0000000189CF4848
		protected virtual GameObject CreateBlocker(Canvas rootCanvas) => default; // 0x0000000189CF261C-0x0000000189CF2A50
		protected virtual void DestroyBlocker(GameObject blocker) {} // 0x0000000189CF2B64-0x0000000189CF2BB0
		protected virtual GameObject CreateDropdownList(GameObject template) => default; // 0x0000000189CF2A50-0x0000000189CF2AA4
		protected virtual void DestroyDropdownList(GameObject dropdownList) {} // 0x0000000189CF2BB0-0x0000000189CF2BFC
		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate) => default; // 0x0000000189CF2AA4-0x0000000189CF2AF8
		protected virtual void DestroyItem(DropdownItem item) {} // 0x000000018350B670-0x000000018350B680
		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items) => default; // 0x0000000189CF1DC0-0x0000000189CF204C
		private void AlphaFadeList(float duration, float alpha) {} // 0x0000000189CF2410-0x0000000189CF249C
		private void AlphaFadeList(float duration, float start, float end) {} // 0x0000000189CF2294-0x0000000189CF2410
		private void SetAlpha(float alpha) {} // 0x0000000189CF3288-0x0000000189CF3328
		public void Hide() {} // 0x0000000189CF2BFC-0x0000000189CF2D14
		[IteratorStateMachine(typeof(_DelayedDestroyDropdownList_d__81))]
		private IEnumerator DelayedDestroyDropdownList(float delay) => default; // 0x0000000189CF2AF8-0x0000000189CF2B64
		private void ImmediateDestroyDropdownList() {} // 0x0000000189CF2D14-0x0000000189CF2E78
		private void OnSelectItem(Toggle toggle) {} // 0x0000000189CF2F1C-0x0000000189CF3024
	}

	public enum AtlasPopulationMode // TypeDefIndex: 52289
	{
		Static = 0,
		Dynamic = 1
	}

	[Serializable]
	[ExcludeFromPreset]
	public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 52291
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
		public string version { get => default; internal set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public Font sourceFontFile { get => default; internal set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public float thaiBiasConsonantsValue { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public string prefixMaterialSearchPatternValue { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public AtlasPopulationMode atlasPopulationMode { get => default; set {} } // 0x0000000183D4EF00-0x0000000183D4EF10 0x0000000183D4EF50-0x0000000183D4EF60
		public FaceInfo faceInfo { get => default; set {} } // 0x0000000183D84D20-0x0000000183D84D60 0x0000000189CFA9EC-0x0000000189CFAA30
		public List<Glyph> glyphTable { get => default; internal set {} } // 0x0000000183D50E60-0x0000000183D50E70 0x00000001858B426C-0x00000001858B4280
		public Dictionary<uint, Glyph> glyphLookupTable { get => default; } // 0x0000000189CFA96C-0x0000000189CFA99C 
		public List<TMP_Character> characterTable { get => default; internal set {} } // 0x0000000183D50050-0x0000000183D50060 0x000000018554A7E0-0x000000018554A7F4
		public Dictionary<uint, TMP_Character> characterLookupTable { get => default; } // 0x0000000182571660-0x00000001825716A0 
		public Texture2D atlasTexture { get => default; } // 0x0000000182860E30-0x0000000182860F80 
		public Texture2D[] atlasTextures { get => default; set {} } // 0x0000000183D50EA0-0x0000000183D50EB0 0x00000001856A2B64-0x00000001856A2B78
		public int atlasTextureCount { get => default; } // 0x0000000183D84CC0-0x0000000183D84CD0 
		public bool isMultiAtlasTexturesEnabled { get => default; set {} } // 0x0000000183D72B20-0x0000000183D72B30 0x0000000183D72B30-0x0000000183D72B40
		internal bool clearDynamicDataOnBuild { get => default; set {} } // 0x0000000183D72B40-0x0000000183D72B50 0x0000000183D72B50-0x0000000183D72B60
		internal List<GlyphRect> usedGlyphRects { get => default; set {} } // 0x0000000183D50160-0x0000000183D50170 0x000000018554D2E0-0x000000018554D2F4
		internal List<GlyphRect> freeGlyphRects { get => default; set {} } // 0x0000000183D50770-0x0000000183D50780 0x00000001855631FC-0x0000000185563210
		[Obsolete("The fontInfo property and underlying type is now obsolete. Please use the faceInfo property and FaceInfo type instead.")]
		public FaceInfo_Legacy fontInfo { get => default; } // 0x0000000183D56D30-0x0000000183D56D40 
		public int atlasWidth { get => default; internal set {} } // 0x0000000183D50A10-0x0000000183D50A20 0x0000000183D50A20-0x0000000183D50A30
		public int atlasHeight { get => default; internal set {} } // 0x0000000183D5D760-0x0000000183D5D770 0x0000000183D5D770-0x0000000183D5D780
		public int atlasPadding { get => default; internal set {} } // 0x0000000183D5D890-0x0000000183D5D8A0 0x0000000183D84D60-0x0000000183D84D70
		public GlyphRenderMode atlasRenderMode { get => default; internal set {} } // 0x0000000183D6DED0-0x0000000183D6DEE0 0x0000000183D742C0-0x0000000183D742D0
		public TMP_FontFeatureTable fontFeatureTable { get => default; internal set {} } // 0x0000000183D56EF0-0x0000000183D56F00 0x0000000184275CE0-0x0000000184275CF4
		public List<TMP_FontAsset> fallbackFontAssetTable { get => default; set {} } // 0x0000000183D571B0-0x0000000183D571C0 0x00000001858B3DA8-0x00000001858B3DBC
		public FontAssetCreationSettings creationSettings { get => default; set {} } // 0x0000000183D84CD0-0x0000000183D84D20 0x0000000189CFA99C-0x0000000189CFA9EC
		public TMP_FontWeightPair[] fontWeightTable { get => default; internal set {} } // 0x0000000183D57170-0x0000000183D57180 0x0000000184275BE8-0x0000000184275BFC
		public RenderTexture[] dynamicRenderTextures { get => default; } // 0x0000000183D57480-0x0000000183D57490 
	
		// Constructors
		public TMP_FontAsset() {} // 0x000000018363C8D0-0x000000018363CD50
		static TMP_FontAsset() {} // 0x00000001838BED90-0x00000001838BF100
	
		// Methods
		public static TMP_FontAsset CreateFontAsset(Font font) => default; // 0x0000000189CF5ADC-0x0000000189CF5B4C
		public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic /* Metadata: 0x01FD190C */, bool enableMultiAtlasSupport = true /* Metadata: 0x01FD190D */) => default; // 0x0000000189CF5B4C-0x0000000189CF609C
		private void Awake() {} // 0x0000000183A91970-0x0000000183A919F0
		public void ReadFontAssetDefinition() {} // 0x0000000182EE81F0-0x0000000182EE8BD0
		internal void InitializeDictionaryLookupTables() {} // 0x0000000182EE8C30-0x0000000182EE8C60
		internal void InitializeGlyphLookupDictionary() {} // 0x0000000182EE9600-0x0000000182EE9810
		internal void InitializeCharacterLookupDictionary() {} // 0x0000000182EE9340-0x0000000182EE9550
		internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() {} // 0x0000000182EE8DD0-0x0000000182EE8F00
		internal void AddSynthesizedCharactersAndFaceMetrics() {} // 0x0000000182EE8F50-0x0000000182EE9170
		private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false /* Metadata: 0x01FD190E */) {} // 0x0000000182EE9170-0x0000000182EE9340
		internal void AddCharacterToLookupCache(uint unicode, TMP_Character character) {} // 0x0000000189CF5108-0x0000000189CF51AC
		internal void SortCharacterTable() {} // 0x0000000189CF771C-0x0000000189CF7888
		internal void SortGlyphTable() {} // 0x0000000189CF78AC-0x0000000189CF7A18
		internal void SortFontFeatureTable() {} // 0x0000000189CF7888-0x0000000189CF78AC
		internal void SortAllTables() {} // 0x0000000189CF76F0-0x0000000189CF771C
		public bool HasCharacter(int character) => default; // 0x0000000189CF6544-0x0000000189CF65A0
		public bool HasCharacter(char character, bool searchFallbacks = false /* Metadata: 0x01FD190F */, bool tryAddCharacter = false /* Metadata: 0x01FD1910 */) => default; // 0x0000000189CF65A0-0x0000000189CF6A80
		private bool HasCharacter_Internal(uint character, bool searchFallbacks = false /* Metadata: 0x01FD1911 */, bool tryAddCharacter = false /* Metadata: 0x01FD1912 */) => default; // 0x0000000189CF632C-0x0000000189CF6544
		public bool HasCharacters(string text, out List<char> missingCharacters) {
			missingCharacters = default;
			return default;
		} // 0x0000000189CF6A80-0x0000000189CF6BD4
		public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false /* Metadata: 0x01FD1913 */, bool tryAddCharacter = false /* Metadata: 0x01FD1914 */) {
			missingCharacters = default;
			return default;
		} // 0x0000000189CF6BD4-0x0000000189CF71A0
		public bool HasCharacters(string text) => default; // 0x0000000189CF71A0-0x0000000189CF7240
		public static string GetCharacters(TMP_FontAsset fontAsset) => default; // 0x0000000189CF6168-0x0000000189CF6248
		public static int[] GetCharactersArray(TMP_FontAsset fontAsset) => default; // 0x0000000189CF609C-0x0000000189CF6168
		internal uint GetGlyphIndex(uint unicode) => default; // 0x0000000189CF6248-0x0000000189CF632C
		internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset) {} // 0x0000000182EE7B10-0x0000000182EE7BF0
		internal static void UpdateFontFeaturesForFontAssetsInQueue() {} // 0x000000018296B070-0x000000018296B1E0
		internal static void RegisterFontAssetForAtlasTextureUpdate(TMP_FontAsset fontAsset) {} // 0x0000000189CF7290-0x0000000189CF735C
		internal static void UpdateAtlasTexturesForFontAssetsInQueue() {} // 0x0000000189CF9774-0x0000000189CF9898
		public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false /* Metadata: 0x01FD1915 */) => default; // 0x0000000189CF8E44-0x0000000189CF8E68
		public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false /* Metadata: 0x01FD1916 */) {
			missingUnicodes = default;
			return default;
		} // 0x0000000189CF7A18-0x0000000189CF8430
		public bool TryAddCharacters(string characters, bool includeFontFeatures = false /* Metadata: 0x01FD1917 */) => default; // 0x0000000189CF8430-0x0000000189CF8454
		public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false /* Metadata: 0x01FD1918 */) {
			missingCharacters = default;
			return default;
		} // 0x0000000189CF8454-0x0000000189CF8E44
		public void AddCharacters(string characters) {} // 0x0000000189CF51AC-0x0000000189CF525C
		internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) {
			character = default;
			return default;
		} // 0x0000000182EE7DF0-0x0000000182EE81F0
		internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character) {
			character = default;
			return default;
		} // 0x0000000189CF91E0-0x0000000189CF95F0
		internal void TryAddGlyphsToAtlasTextures() {} // 0x000000018350B670-0x000000018350B680
		private bool TryAddGlyphsToNewAtlasTexture() => default; // 0x0000000189CF8E68-0x0000000189CF91E0
		private void SetupNewAtlasTexture() {} // 0x0000000189CF735C-0x0000000189CF76F0
		internal void UpdateAtlasTexture() {} // 0x0000000189CF95F0-0x0000000189CF9774
		internal void UpdateGlyphAdjustmentRecords() {} // 0x0000000183A1F2E0-0x0000000183A1F3E0
		internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) {} // 0x0000000189CF99A0-0x0000000189CF9BCC
		internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes) {} // 0x000000018350B670-0x000000018350B680
		internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes) {} // 0x000000018350B670-0x000000018350B680
		private void CopyListDataToArray<T>(List<T> srcList, ref ref T[] dstArray) {}
		public void ClearFontAssetData(bool setAtlasSizeToZero = false /* Metadata: 0x01FD1919 */) {} // 0x0000000189CF5918-0x0000000189CF5954
		public void ClearFontAssetData() {} // 0x0000000189CF5910-0x0000000189CF5918
		internal void ClearFontAssetDataInternal() {} // 0x0000000189CF58EC-0x0000000189CF5910
		internal void UpdateFontAssetData() {} // 0x0000000189CF9898-0x0000000189CF99A0
		internal void ClearFontAssetTables() {} // 0x0000000189CF5954-0x0000000189CF5ADC
		internal void ClearAtlasTextures(bool setAtlasSizeToZero = false /* Metadata: 0x01FD191A */) {} // 0x0000000189CF525C-0x0000000189CF58EC
		internal void UpgradeFontAsset() {} // 0x0000000189CF9BCC-0x0000000189CFA5D4
		private void UpgradeGlyphAdjustmentTableToFontFeatureTable() {} // 0x0000000189CFA5D4-0x0000000189CFA96C
		private void OnDestroy() {} // 0x0000000189CF7240-0x0000000189CF7290
	}

	[Serializable]
	public class FaceInfo_Legacy // TypeDefIndex: 52292
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
		public FaceInfo_Legacy() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class TMP_Glyph : TMP_TextElement_Legacy // TypeDefIndex: 52293
	{
		// Constructors
		public TMP_Glyph() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static TMP_Glyph Clone(TMP_Glyph source) => default; // 0x0000000189CFAE40-0x0000000189CFAEE0
	}

	[Serializable]
	public struct FontAssetCreationSettings // TypeDefIndex: 52294
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
		} // 0x0000000189CEF038-0x0000000189CEF144
	}

	[Serializable]
	public struct TMP_FontWeightPair // TypeDefIndex: 52295
	{
		// Fields
		public TMP_FontAsset regularTypeface; // 0x00
		public TMP_FontAsset italicTypeface; // 0x08
	}

	public struct KerningPairKey // TypeDefIndex: 52296
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
		} // 0x0000000183D84C20-0x0000000183D84C40
	}

	[Serializable]
	public struct GlyphValueRecord_Legacy // TypeDefIndex: 52297
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
		} // 0x0000000183D84C00-0x0000000183D84C20
	
		// Methods
		public static GlyphValueRecord_Legacy operator +(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b) => default; // 0x00000001828B5D60-0x00000001828B5DB0
	}

	[Serializable]
	public class KerningPair // TypeDefIndex: 52298
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
		public uint firstGlyph { get => default; set {} } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public GlyphValueRecord_Legacy firstGlyphAdjustments { get => default; } // 0x0000000183D60DB0-0x0000000183D60DC0 
		public uint secondGlyph { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
		public GlyphValueRecord_Legacy secondGlyphAdjustments { get => default; } // 0x0000000183D59E20-0x0000000183D59E30 
		public bool ignoreSpacingAdjustments { get => default; } // 0x0000000183D4F460-0x0000000183D4F470 
	
		// Constructors
		public KerningPair() {} // 0x0000000183D84C80-0x0000000183D84CA0
		public KerningPair(uint left, uint right, float offset) {} // 0x0000000183D84C50-0x0000000183D84C60
		public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) {} // 0x0000000183D84C60-0x0000000183D84C80
		static KerningPair() {} // 0x0000000183CF26E0-0x0000000183CF2760
	
		// Methods
		internal void ConvertLegacyKerningData() {} // 0x0000000183D84C40-0x0000000183D84C50
	}

	[Serializable]
	public class KerningTable // TypeDefIndex: 52303
	{
		// Fields
		public List<KerningPair> kerningPairs; // 0x10
	
		// Constructors
		public KerningTable() {} // 0x000000018363CD50-0x000000018363CDD0
	
		// Methods
		public void AddKerningPair() {} // 0x0000000189CEF634-0x0000000189CEF76C
		public int AddKerningPair(uint first, uint second, float offset) => default; // 0x0000000189CEF4E8-0x0000000189CEF634
		public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments) => default; // 0x0000000189CEF384-0x0000000189CEF4E8
		public void RemoveKerningPair(int left, int right) {} // 0x0000000189CEF76C-0x0000000189CEF86C
		public void RemoveKerningPair(int index) {} // 0x0000000189CEF86C-0x0000000189CEF8C0
		public void SortKerningPairs() {} // 0x0000000189CEF8C0-0x0000000189CEFAE0
	}

	public static class TMP_FontUtilities // TypeDefIndex: 52304
	{
		// Fields
		private static List<int> k_searchedFontAssets; // 0x00
	
		// Methods
		public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character) {
			character = default;
			return default;
		} // 0x0000000189CFAD40-0x0000000189CFAE40
		public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) {
			character = default;
			return default;
		} // 0x0000000189CFAD38-0x0000000189CFAD40
		private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character) {
			character = default;
			return default;
		} // 0x0000000189CFAA30-0x0000000189CFAC5C
		private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) {
			character = default;
			return default;
		} // 0x0000000189CFAC5C-0x0000000189CFAD38
	}

	public class TMP_FontAssetUtilities // TypeDefIndex: 52305
	{
		// Fields
		private static readonly TMP_FontAssetUtilities s_Instance; // 0x00
		private static HashSet<int> k_SearchedAssets; // 0x08
		private static bool k_IsFontEngineInitialized; // 0x10
	
		// Properties
		public static TMP_FontAssetUtilities instance { get => default; } // 0x0000000189CF50B8-0x0000000189CF5108 
	
		// Constructors
		static TMP_FontAssetUtilities() {} // 0x0000000183D1ACF0-0x0000000183D1AD50
		public TMP_FontAssetUtilities() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) {
			isAlternativeTypeface = default;
			return default;
		} // 0x0000000182570D10-0x0000000182570DD0
		private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) {
			isAlternativeTypeface = default;
			return default;
		} // 0x0000000182570DD0-0x0000000182571660
		public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) {
			isAlternativeTypeface = default;
			return default;
		} // 0x00000001829696B0-0x0000000182969980
		public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) => default; // 0x0000000189CF4DCC-0x0000000189CF50B8
		private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) => default; // 0x0000000189CF4C14-0x0000000189CF4DCC
	}

	[Flags]
	public enum FontFeatureLookupFlags // TypeDefIndex: 52306
	{
		None = 0,
		IgnoreLigatures = 4,
		IgnoreSpacingAdjustments = 256
	}

	[Serializable]
	public struct TMP_GlyphValueRecord // TypeDefIndex: 52307
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
		public float xPlacement { get => default; set {} } // 0x0000000183D4FA00-0x0000000183D4FA10 0x0000000183D58BD0-0x0000000183D58BE0
		public float yPlacement { get => default; set {} } // 0x0000000183D58BC0-0x0000000183D58BD0 0x0000000183D58BF0-0x0000000183D58C00
		public float xAdvance { get => default; set {} } // 0x0000000183D58BB0-0x0000000183D58BC0 0x0000000183D58BE0-0x0000000183D58BF0
		public float yAdvance { get => default; set {} } // 0x0000000183D5E120-0x0000000183D5E130 0x0000000183D5E130-0x0000000183D5E140
	
		// Constructors
		public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance) : this() {
			m_XPlacement = default;
			m_YPlacement = default;
			m_XAdvance = default;
			m_YAdvance = default;
		} // 0x0000000183D516B0-0x0000000183D516D0
		internal TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord) : this() {
			m_XPlacement = default;
			m_YPlacement = default;
			m_XAdvance = default;
			m_YAdvance = default;
		} // 0x0000000183D5DBB0-0x0000000183D5DBD0
		internal TMP_GlyphValueRecord(GlyphValueRecord valueRecord) : this() {
			m_XPlacement = default;
			m_YPlacement = default;
			m_XAdvance = default;
			m_YAdvance = default;
		} // 0x0000000183D84C00-0x0000000183D84C20
	
		// Methods
		public static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) => default; // 0x0000000183D84D70-0x0000000183D84D90
	}

	[Serializable]
	public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 52308
	{
		// Fields
		[SerializeField]
		internal uint m_GlyphIndex; // 0x00
		[SerializeField]
		internal TMP_GlyphValueRecord m_GlyphValueRecord; // 0x04
	
		// Properties
		public uint glyphIndex { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public TMP_GlyphValueRecord glyphValueRecord { get => default; set {} } // 0x0000000183D67710-0x0000000183D67720 0x0000000183D84E00-0x0000000183D84E10
	
		// Constructors
		public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord) : this() {
			m_GlyphIndex = default;
			m_GlyphValueRecord = default;
		} // 0x0000000183D675C0-0x0000000183D675D0
		internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord) : this() {
			m_GlyphIndex = default;
			m_GlyphValueRecord = default;
		} // 0x0000000189CFC754-0x0000000189CFC79C
	}

	[Serializable]
	public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 52309
	{
		// Fields
		[SerializeField]
		public TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
		[SerializeField]
		public TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
		[SerializeField]
		public FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38
	
		// Properties
		public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get => default; set {} } // 0x0000000183D60A90-0x0000000183D60AB0 0x0000000183D6E5B0-0x0000000183D6E5C0
		public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get => default; set {} } // 0x0000000183D84E40-0x0000000183D84E60 0x0000000183D84E60-0x0000000183D84E70
		public FontFeatureLookupFlags featureLookupFlags { get => default; set {} } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
	
		// Constructors
		public TMP_GlyphPairAdjustmentRecord() {} // Dummy constructor
		public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) {} // 0x0000000183D84E10-0x0000000183D84E40
		internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) {} // 0x0000000189CFC79C-0x0000000189CFC86C
	}

	public struct GlyphPairKey // TypeDefIndex: 52310
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
		} // 0x0000000183D84DE0-0x0000000183D84E00
		internal GlyphPairKey(TMP_GlyphPairAdjustmentRecord record) {
			firstGlyphIndex = default;
			secondGlyphIndex = default;
			key = default;
		} // 0x0000000189CFC354-0x0000000189CFC384
	}

	[Serializable]
	public class TMP_FontFeatureTable // TypeDefIndex: 52312
	{
		// Fields
		[SerializeField]
		internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
		public Dictionary<uint, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18
	
		// Properties
		public List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
		// Constructors
		public TMP_FontFeatureTable() {} // 0x000000018363CDD0-0x000000018363CEA0
	
		// Methods
		public void SortGlyphPairAdjustmentRecords() {} // 0x0000000189CFC534-0x0000000189CFC754
	}

	[AddComponentMenu("UI/TextMeshPro - Input Field", 11)]
	public class TMP_InputField : Selectable, IUpdateSelectedHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, UnityEngine.EventSystems.IScrollHandler // TypeDefIndex: 52326
	{
		// Fields
		protected TouchScreenKeyboard m_SoftKeyboard; // 0x180
		private static readonly char[] kSeparators; // 0x00
		protected RectTransform m_RectTransform; // 0x188
		[SerializeField]
		protected RectTransform m_TextViewport; // 0x190
		protected RectMask2D m_TextComponentRectMask; // 0x198
		protected RectMask2D m_TextViewportRectMask; // 0x1A0
		private Rect m_CachedViewportRect; // 0x1A8
		[SerializeField]
		protected TMP_Text m_TextComponent; // 0x1B8
		protected RectTransform m_TextComponentRectTransform; // 0x1C0
		[SerializeField]
		protected Graphic m_Placeholder; // 0x1C8
		[SerializeField]
		protected Scrollbar m_VerticalScrollbar; // 0x1D0
		[SerializeField]
		protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x1D8
		private bool m_IsDrivenByLayoutComponents; // 0x1E0
		[SerializeField]
		private LayoutGroup m_LayoutGroup; // 0x1E8
		private UnityEngine.EventSystems.IScrollHandler m_IScrollHandlerParent; // 0x1F0
		private float m_ScrollPosition; // 0x1F8
		[SerializeField]
		protected float m_ScrollSensitivity; // 0x1FC
		[SerializeField]
		private ContentType m_ContentType; // 0x200
		[SerializeField]
		private InputType m_InputType; // 0x204
		[SerializeField]
		private char m_AsteriskChar; // 0x208
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType; // 0x20C
		[SerializeField]
		private LineType m_LineType; // 0x210
		[SerializeField]
		private bool m_HideMobileInput; // 0x214
		[SerializeField]
		private bool m_HideSoftKeyboard; // 0x215
		[SerializeField]
		private CharacterValidation m_CharacterValidation; // 0x218
		[SerializeField]
		private string m_RegexValue; // 0x220
		[SerializeField]
		private float m_GlobalPointSize; // 0x228
		[SerializeField]
		private int m_CharacterLimit; // 0x22C
		[SerializeField]
		private SubmitEvent m_OnEndEdit; // 0x230
		[SerializeField]
		private SubmitEvent m_OnSubmit; // 0x238
		[SerializeField]
		private SelectionEvent m_OnSelect; // 0x240
		[SerializeField]
		private SelectionEvent m_OnDeselect; // 0x248
		[SerializeField]
		private TextSelectionEvent m_OnTextSelection; // 0x250
		[SerializeField]
		private TextSelectionEvent m_OnEndTextSelection; // 0x258
		[SerializeField]
		private OnChangeEvent m_OnValueChanged; // 0x260
		[SerializeField]
		private TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x268
		[SerializeField]
		private OnValidateInput m_OnValidateInput; // 0x270
		[SerializeField]
		private UnityEvent m_OnFocused; // 0x278
		[SerializeField]
		private UnityEngine.Color m_CaretColor; // 0x280
		[SerializeField]
		private bool m_CustomCaretColor; // 0x290
		[SerializeField]
		private UnityEngine.Color m_SelectionColor; // 0x294
		[SerializeField]
		[TextArea(5, 10)]
		protected string m_Text; // 0x2A8
		[Range(0f, 4f)]
		[SerializeField]
		private float m_CaretBlinkRate; // 0x2B0
		[Range(1f, 5f)]
		[SerializeField]
		private int m_CaretWidth; // 0x2B4
		[SerializeField]
		private bool m_ReadOnly; // 0x2B8
		[SerializeField]
		private bool m_RichText; // 0x2B9
		[SerializeField]
		private bool m_disableUpDownArrowKeyMovingCaret; // 0x2BA
		[SerializeField]
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
		private const float kHScrollSpeed = 0.05f; // Metadata: 0x01FD1921
		private const float kVScrollSpeed = 0.1f; // Metadata: 0x01FD1925
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
		private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~"; // Metadata: 0x01FD1929
		private bool m_IsCompositionActive; // 0x340
		private bool m_ShouldUpdateIMEWindowPosition; // 0x341
		private int m_PreviousIMEInsertionLine; // 0x344
		public Func<string, int, string> onValidateCharacterLimit; // 0x348
		public Func<string, int> onGetTextLength; // 0x350
		[SerializeField]
		protected bool m_OnFocusSelectAll; // 0x358
		protected bool m_isSelectAll; // 0x359
		[SerializeField]
		protected bool m_ResetOnDeActivation; // 0x35A
		private bool m_SelectionStillActive; // 0x35B
		private bool m_ReleaseSelection; // 0x35C
		private GameObject m_PreviouslySelectedObject; // 0x360
		[SerializeField]
		private bool m_RestoreOriginalTextOnEscape; // 0x368
		[SerializeField]
		private bool m_WontReleaseSelectionOnEscape; // 0x369
		private bool m_tempClearCompositionString; // 0x36A
		[SerializeField]
		protected bool m_isRichTextEditingAllowed; // 0x36B
		[SerializeField]
		protected int m_LineLimit; // 0x36C
		[SerializeField]
		protected TMP_InputValidator m_InputValidator; // 0x370
		private bool m_isSelected; // 0x378
		private bool m_IsStringPositionDirty; // 0x379
		private bool m_IsCaretPositionDirty; // 0x37A
		private bool m_forceRectTransformAdjustment; // 0x37B
		private UnityEngine.Event m_ProcessingEvent; // 0x380
	
		// Properties
		public bool isLastKeyBackspace { get => default; set {} } // 0x0000000183D84EE0-0x0000000183D84EF0 0x0000000183D84FA0-0x0000000183D84FB0
		private BaseInput inputSystem { get => default; } // 0x00000001822B3890-0x00000001822B39D0 
		private string compositionString { get => default; } // 0x00000001822B42A0-0x00000001822B4360 
		private int compositionLength { get => default; } // 0x00000001822B4C50-0x00000001822B4C80 
		protected Mesh mesh { get => default; } // 0x0000000182CDA930-0x0000000182CDA9F0 
		public bool shouldHideMobileInput { get => default; set {} } // 0x0000000189D00840-0x0000000189D00870 0x0000000189D0127C-0x0000000189D012E8
		public bool shouldHideSoftKeyboard { get => default; set {} } // 0x0000000189D00870-0x0000000189D008C4 0x0000000189D012E8-0x0000000189D013FC
		public string text { get => default; set {} } // 0x0000000183D57460-0x0000000183D57470 0x00000001842759BC-0x00000001842759C8
		public bool isFocused { get => default; } // 0x0000000183D84ED0-0x0000000183D84EE0 
		public float caretBlinkRate { get => default; set {} } // 0x0000000183D84E80-0x0000000183D84E90 0x0000000189D00920-0x0000000189D00988
		public int caretWidth { get => default; set {} } // 0x0000000183D84E90-0x0000000183D84EA0 0x0000000189D00A00-0x0000000189D00A5C
		public RectTransform textViewport { get => default; set {} } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000189D01490-0x0000000189D014DC
		public TMP_Text textComponent { get => default; set {} } // 0x0000000183D57130-0x0000000183D57140 0x0000000189D01434-0x0000000189D01490
		public Graphic placeholder { get => default; set {} } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000189D00FFC-0x0000000189D01048
		public Scrollbar verticalScrollbar { get => default; set {} } // 0x0000000183D57000-0x0000000183D57010 0x0000000189D014DC-0x0000000189D01678
		public float scrollSensitivity { get => default; set {} } // 0x0000000183D59A20-0x0000000183D59A30 0x0000000189D010F0-0x0000000189D0114C
		public UnityEngine.Color caretColor { get => default; set {} } // 0x0000000182CDBED0-0x0000000182CDBF20 0x0000000189D00988-0x0000000189D009C8
		public bool customCaretColor { get => default; set {} } // 0x0000000183D5A4E0-0x0000000183D5A4F0 0x0000000189D00B1C-0x0000000189D00B34
		public UnityEngine.Color selectionColor { get => default; set {} } // 0x0000000183D84F60-0x0000000183D84F70 0x0000000189D01188-0x0000000189D011C8
		public SubmitEvent onEndEdit { get => default; set {} } // 0x0000000183D57210-0x0000000183D57220 0x0000000189D00D9C-0x0000000189D00DE8
		public SubmitEvent onSubmit { get => default; set {} } // 0x0000000183D57220-0x0000000183D57230 0x0000000189D00ECC-0x0000000189D00F18
		public SelectionEvent onSelect { get => default; set {} } // 0x0000000183D56B10-0x0000000183D56B20 0x0000000189D00E80-0x0000000189D00ECC
		public SelectionEvent onDeselect { get => default; set {} } // 0x0000000183D56D60-0x0000000183D56D70 0x0000000189D00D50-0x0000000189D00D9C
		public TextSelectionEvent onTextSelection { get => default; set {} } // 0x0000000183D57350-0x0000000183D57360 0x0000000189D00F18-0x0000000189D00F64
		public TextSelectionEvent onEndTextSelection { get => default; set {} } // 0x0000000183D57440-0x0000000183D57450 0x0000000189D00DE8-0x0000000189D00E34
		public OnChangeEvent onValueChanged { get => default; set {} } // 0x0000000183D57050-0x0000000183D57060 0x0000000189D00FB0-0x0000000189D00FFC
		public TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get => default; set {} } // 0x0000000183D57450-0x0000000183D57460 0x0000000189D00F64-0x0000000189D00FB0
		public OnValidateInput onValidateInput { get => default; set {} } // 0x0000000183D574B0-0x0000000183D574C0 0x0000000183CDDA60-0x0000000183CDDAB0
		public UnityEvent onFocused { get => default; set {} } // 0x0000000183D57270-0x0000000183D57280 0x0000000189D00E34-0x0000000189D00E80
		public int characterLimit { get => default; set {} } // 0x0000000183D84EA0-0x0000000183D84EB0 0x0000000182CD9220-0x0000000182CD92C0
		public float pointSize { get => default; set {} } // 0x0000000183D76010-0x0000000183D76020 0x0000000189D01048-0x0000000189D010E0
		public bool onFocusSelectAll { get => default; set {} } // 0x0000000183D84F30-0x0000000183D84F40 0x0000000183D84FC0-0x0000000183D84FD0
		public bool resetOnDeActivation { get => default; set {} } // 0x0000000183D84F40-0x0000000183D84F50 0x0000000183D84FE0-0x0000000183D84FF0
		public bool restoreOriginalTextOnEscape { get => default; set {} } // 0x0000000183D5B950-0x0000000183D5B960 0x0000000183D5BA80-0x0000000183D5BA90
		public bool wontReleaseSelectionOnEscape { get => default; set {} } // 0x0000000183D84F80-0x0000000183D84F90 0x0000000183D84FF0-0x0000000183D85000
		public bool disableArrowKeyMoveCaret { get => default; set {} } // 0x0000000183D84EB0-0x0000000183D84EC0 0x0000000183D84F90-0x0000000183D84FA0
		public bool isRichTextEditingAllowed { get => default; set {} } // 0x0000000183D84EF0-0x0000000183D84F00 0x0000000183D84FB0-0x0000000183D84FC0
		public ContentType contentType { get => default; set {} } // 0x0000000183D5A250-0x0000000183D5A260 0x0000000189D00AC0-0x0000000189D00B1C
		public LineType lineType { get => default; set {} } // 0x0000000183D84F20-0x0000000183D84F30 0x0000000189D00CAC-0x0000000189D00D50
		public int lineLimit { get => default; set {} } // 0x0000000183D84F10-0x0000000183D84F20 0x0000000189D00C4C-0x0000000189D00CAC
		public InputType inputType { get => default; set {} } // 0x0000000183D84EC0-0x0000000183D84ED0 0x0000000189D00B34-0x0000000189D00B90
		public TouchScreenKeyboardType keyboardType { get => default; set {} } // 0x0000000183D84F00-0x0000000183D84F10 0x0000000189D00BF0-0x0000000189D00C4C
		public CharacterValidation characterValidation { get => default; set {} } // 0x0000000183D5A730-0x0000000183D5A740 0x0000000189D00A5C-0x0000000189D00AB8
		public TMP_InputValidator inputValidator { get => default; set {} } // 0x0000000183D55E50-0x0000000183D55E60 0x0000000189D00B90-0x0000000189D00BF0
		public bool readOnly { get => default; set {} } // 0x0000000183D57A10-0x0000000183D57A20 0x0000000183D84FD0-0x0000000183D84FE0
		public bool richText { get => default; set {} } // 0x0000000183D84F50-0x0000000183D84F60 0x0000000189D010E0-0x0000000189D010F0
		public bool multiLine { get => default; } // 0x0000000182CD9BA0-0x0000000182CD9BC0 
		public char asteriskChar { get => default; set {} } // 0x0000000183D84E70-0x0000000183D84E80 0x0000000189D008C4-0x0000000189D00920
		public bool wasCanceled { get => default; } // 0x0000000183D84F70-0x0000000183D84F80 
		protected int caretPositionInternal { get => default; set {} } // 0x0000000182CDBEB0-0x0000000182CDBED0 0x00000001842731E8-0x0000000184273200
		protected int stringPositionInternal { get => default; set {} } // 0x0000000182CDB350-0x0000000182CDB370 0x00000001842768E4-0x00000001842768FC
		protected int caretSelectPositionInternal { get => default; set {} } // 0x0000000183D42AB0-0x0000000183D42AD0 0x00000001842731D0-0x00000001842731E8
		protected int stringSelectPositionInternal { get => default; set {} } // 0x0000000182CDB330-0x0000000182CDB350 0x00000001842768CC-0x00000001842768E4
		private new bool hasSelection { get => default; } // 0x0000000182CDB150-0x0000000182CDB180 
		public int caretPosition { get => default; set {} } // 0x0000000184273150-0x0000000184273158 0x0000000189D009C8-0x0000000189D00A00
		public int selectionAnchorPosition { get => default; set {} } // 0x0000000184273148-0x0000000184273150 0x0000000189D0114C-0x0000000189D01188
		public int selectionFocusPosition { get => default; set {} } // 0x0000000184273150-0x0000000184273158 0x0000000189D011C8-0x0000000189D01204
		public int stringPosition { get => default; set {} } // 0x0000000189D00838-0x0000000189D00840 0x0000000189D013FC-0x0000000189D01434
		public int selectionStringAnchorPosition { get => default; set {} } // 0x0000000189D00830-0x0000000189D00838 0x0000000189D01204-0x0000000189D01240
		public int selectionStringFocusPosition { get => default; set {} } // 0x0000000189D00838-0x0000000189D00840 0x0000000189D01240-0x0000000189D0127C
		private static string clipboard { get => default; set {} } // 0x0000000189D005B0-0x0000000189D005B8 0x0000000189D00AB8-0x0000000189D00AC0
		public virtual float minWidth { get => default; } // 0x0000000183D503F0-0x0000000183D50400 
		public virtual float preferredWidth { get => default; } // 0x0000000189D006F4-0x0000000189D00830 
		public virtual float flexibleWidth { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
		public virtual float minHeight { get => default; } // 0x0000000183D503F0-0x0000000183D50400 
		public virtual float preferredHeight { get => default; } // 0x0000000189D005B8-0x0000000189D006F4 
		public virtual float flexibleHeight { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
		public virtual int layoutPriority { get => default; } // 0x0000000181168950-0x0000000181168960 
		Transform ICanvasElement.transform { get => default; } // 0x0000000184273A88-0x0000000184273A90 
	
		// Nested types
		public enum ContentType // TypeDefIndex: 52313
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
	
		public enum InputType // TypeDefIndex: 52314
		{
			Standard = 0,
			AutoCorrect = 1,
			Password = 2
		}
	
		public enum CharacterValidation // TypeDefIndex: 52315
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
	
		public enum LineType // TypeDefIndex: 52316
		{
			SingleLine = 0,
			MultiLineSubmit = 1,
			MultiLineNewline = 2
		}
	
		public delegate char OnValidateInput(string text, int charIndex, char addedChar); // TypeDefIndex: 52317; 0x0000000181035ED0-0x0000000181035EF0
	
		[Serializable]
		public class SubmitEvent : UnityEvent<string> // TypeDefIndex: 52318
		{
			// Constructors
			public SubmitEvent() {} // 0x0000000182849CF0-0x0000000182849D30
		}
	
		[Serializable]
		public class OnChangeEvent : UnityEvent<string> // TypeDefIndex: 52319
		{
			// Constructors
			public OnChangeEvent() {} // 0x00000001828498E0-0x0000000182849920
		}
	
		[Serializable]
		public class SelectionEvent : UnityEvent<string> // TypeDefIndex: 52320
		{
			// Constructors
			public SelectionEvent() {} // 0x0000000182849D30-0x0000000182849D70
		}
	
		[Serializable]
		public class TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 52321
		{
			// Constructors
			public TextSelectionEvent() {} // 0x0000000182849D70-0x0000000182849DB0
		}
	
		[Serializable]
		public class TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 52322
		{
			// Constructors
			public TouchScreenKeyboardEvent() {} // 0x0000000182849E10-0x0000000182849E50
		}
	
		protected enum EditState // TypeDefIndex: 52323
		{
			Continue = 0,
			Finish = 1
		}
	
		// Constructors
		protected TMP_InputField() {} // 0x0000000182849920-0x0000000182849CF0
		static TMP_InputField() {} // 0x0000000183CE2E00-0x0000000183CE2E90
	
		// Methods
		private bool isKeyboardUsingEvents() => default; // 0x0000000182CDAC90-0x0000000182CDACC0
		public void SetTextWithoutNotify(string input) {} // 0x0000000189CFFC44-0x0000000189CFFC50
		private void SetText(string value, bool sendCallback = true /* Metadata: 0x01FD191F */) {} // 0x0000000183B22830-0x0000000183B22960
		protected void ClampStringPos(ref int pos) {} // 0x0000000183D3B6E0-0x0000000183D3B720
		protected void ClampCaretPos(ref int pos) {} // 0x00000001838549D0-0x0000000183854A20
		protected override void OnEnable() {} // 0x0000000182CD8830-0x0000000182CD8F30
		protected override void OnDisable() {} // 0x0000000182CD8300-0x0000000182CD8670
		private void ON_TEXT_CHANGED(UnityEngine.Object obj) {} // 0x0000000182CDB180-0x0000000182CDB2A0
		[IteratorStateMachine(typeof(_CaretBlink_d__291))]
		private IEnumerator CaretBlink() => default; // 0x0000000183D42DE0-0x0000000183D42E40
		private void SetCaretVisible() {} // 0x0000000182CD9850-0x0000000182CD9890
		private void SetCaretActive() {} // 0x0000000182CD9890-0x0000000182CD9900
		protected void OnFocus() {} // 0x00000001836841C0-0x0000000183684200
		protected void SelectAll() {} // 0x0000000183684200-0x0000000183684250
		public void MoveTextEnd(bool shift) {} // 0x0000000189CFE814-0x0000000189CFE8E4
		public void MoveTextStart(bool shift) {} // 0x0000000189CFE8E4-0x0000000189CFE988
		public void MoveToEndOfLine(bool shift, bool ctrl) {} // 0x0000000189CFE988-0x0000000189CFEAE0
		public void MoveToStartOfLine(bool shift, bool ctrl) {} // 0x0000000189CFEAE0-0x0000000189CFEC64
		private bool InPlaceEditing() => default; // 0x0000000182CDACF0-0x0000000182CDAD50
		private void UpdateStringPositionFromKeyboard() {} // 0x0000000189CFFD94-0x0000000189CFFE8C
		protected virtual void LateUpdate() {} // 0x0000000182CDAB80-0x0000000182CDAC90
		private bool MayDrag(PointerEventData eventData) => default; // 0x00000001822C5150-0x00000001822C5200
		public virtual void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189CFED94-0x0000000189CFEDB8
		public virtual void OnDrag(PointerEventData eventData) {} // 0x0000000189CFEDB8-0x0000000189CFF110
		[IteratorStateMachine(typeof(_MouseDragOutsideRect_d__309))]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData) => default; // 0x0000000189CFDAF8-0x0000000189CFDB6C
		public virtual void OnEndDrag(PointerEventData eventData) {} // 0x0000000189CFF110-0x0000000189CFF134
		public override void OnPointerDown(PointerEventData eventData) {} // 0x00000001822C4F80-0x00000001822C5150
		protected EditState KeyPressed(UnityEngine.Event evt) => default; // 0x0000000182CD9900-0x0000000182CD9AC0
		protected virtual bool IsValidChar(char c) => default; // 0x0000000182CD9B80-0x0000000182CD9BA0
		public void ProcessEvent(UnityEngine.Event e) {} // 0x0000000189CFF984-0x0000000189CFF98C
		public virtual void OnUpdateSelected(BaseEventData eventData) {} // 0x0000000182CD9330-0x0000000182CD9440
		public virtual void OnScroll(PointerEventData eventData) {} // 0x0000000189CFF134-0x0000000189CFF2B4
		private float GetScrollPositionRelativeToViewport() => default; // 0x0000000189CFD444-0x0000000189CFD54C
		private string GetSelectedString() => default; // 0x0000000189CFD54C-0x0000000189CFD5D8
		private int FindNextWordBegin() => default; // 0x0000000189CFD168-0x0000000189CFD224
		private void MoveRight(bool shift, bool ctrl) {} // 0x0000000189CFE508-0x0000000189CFE814
		private int FindPrevWordBegin() => default; // 0x0000000189CFD224-0x0000000189CFD2D8
		private void MoveLeft(bool shift, bool ctrl) {} // 0x0000000189CFDCC4-0x0000000189CFDF68
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) => default; // 0x0000000189CFD8A4-0x0000000189CFDAF8
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar) => default; // 0x0000000189CFD62C-0x0000000189CFD8A4
		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) => default; // 0x0000000189CFF67C-0x0000000189CFF984
		private int PageDownCharacterPosition(int originalPos, bool goToLastChar) => default; // 0x0000000189CFF33C-0x0000000189CFF67C
		private void MoveDown(bool shift) {} // 0x0000000189CFDCB8-0x0000000189CFDCC4
		private void MoveDown(bool shift, bool goToLastChar) {} // 0x0000000189CFDB6C-0x0000000189CFDCB8
		private void MoveUp(bool shift) {} // 0x0000000189CFEC64-0x0000000189CFEC70
		private void MoveUp(bool shift, bool goToFirstChar) {} // 0x0000000189CFEC70-0x0000000189CFED94
		private void MovePageUp(bool shift) {} // 0x0000000189CFE4FC-0x0000000189CFE508
		private void MovePageUp(bool shift, bool goToFirstChar) {} // 0x0000000189CFE244-0x0000000189CFE4FC
		private void MovePageDown(bool shift) {} // 0x0000000189CFE238-0x0000000189CFE244
		private void MovePageDown(bool shift, bool goToLastChar) {} // 0x0000000189CFDF68-0x0000000189CFE238
		private void Delete() {} // 0x00000001830822F0-0x00000001830823B0
		private void DeleteKey() {} // 0x0000000189CFCE10-0x0000000189CFD034
		private void Backspace() {} // 0x0000000189CFCB1C-0x0000000189CFCE10
		protected virtual void Append(string input) {} // 0x0000000189CFCA94-0x0000000189CFCB1C
		protected virtual void Append(char input) {} // 0x0000000182CD9E30-0x0000000182CD9F50
		private void Insert(char c) {} // 0x0000000183081F90-0x00000001830820E0
		private void UpdateTouchKeyboardFromEditChanges() {} // 0x0000000183082270-0x0000000183082290
		private void SendOnValueChangedAndUpdateLabel() {} // 0x0000000189CFF9DC-0x0000000189CFF9FC
		private void SendOnValueChanged() {} // 0x0000000183082290-0x00000001830822F0
		protected void SendOnEndEdit() {} // 0x00000001836842A0-0x0000000183684300
		protected void SendOnSubmit() {} // 0x0000000189CFF98C-0x0000000189CFF9DC
		protected virtual void SendOnFocus() {} // 0x0000000183CC4B60-0x0000000183CC4BC0
		protected virtual void SendOnFocusLost() {} // 0x0000000183CFB570-0x0000000183CFB5D0
		protected void SendOnTextSelection() {} // 0x0000000183D23970-0x0000000183D23A10
		protected void SendOnEndTextSelection() {} // 0x0000000182CDB370-0x0000000182CDB420
		protected void SendTouchScreenKeyboardStatusChanged() {} // 0x0000000189CFF9FC-0x0000000189CFFA6C
		protected void UpdateLabel() {} // 0x0000000182CD94C0-0x0000000182CD9800
		private void UpdateScrollbar() {} // 0x0000000189CFFCB8-0x0000000189CFFD94
		private void OnScrollbarValueChange(float value) {} // 0x0000000189CFF2B4-0x0000000189CFF2F4
		private void UpdateMaskRegions() {} // 0x000000018350B670-0x000000018350B680
		private void AdjustTextPositionRelativeToViewport(float relativePosition) {} // 0x0000000189CFC86C-0x0000000189CFCA94
		private int GetCaretPositionFromStringIndex(int stringIndex) => default; // 0x0000000182CDB2A0-0x0000000182CDB330
		private int GetMinCaretPositionFromStringIndex(int stringIndex) => default; // 0x0000000189CFD370-0x0000000189CFD444
		private int GetMaxCaretPositionFromStringIndex(int stringIndex) => default; // 0x0000000189CFD2E0-0x0000000189CFD370
		private int GetStringIndexFromCaretPosition(int caretPosition) => default; // 0x0000000189CFD5D8-0x0000000189CFD62C
		public void ForceLabelUpdate() {} // 0x0000000189CFD2D8-0x0000000189CFD2E0
		private void MarkGeometryAsDirty() {} // 0x0000000182CD9800-0x0000000182CD9850
		public virtual void Rebuild(CanvasUpdate update) {} // 0x0000000182CDA860-0x0000000182CDA870
		public virtual void LayoutComplete() {} // 0x000000018350B670-0x000000018350B680
		public virtual void GraphicUpdateComplete() {} // 0x000000018350B670-0x000000018350B680
		private void UpdateGeometry() {} // 0x0000000182CDA870-0x0000000182CDA930
		private void AssignPositioningIfNeeded() {} // 0x0000000182CD6AE0-0x0000000182CD6F50
		private void OnFillVBO(Mesh vbo) {} // 0x0000000182CDAD90-0x0000000182CDB150
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) {} // 0x0000000182CDB420-0x0000000182CDBCF0
		private void CreateCursorVerts() {} // 0x0000000182CDD600-0x0000000182CDD7A0
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset) {} // 0x00000001836A46D0-0x00000001836A4D70
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) {} // 0x00000001836A4E20-0x00000001836A51B0
		protected char Validate(string text, int pos, char ch) => default; // 0x0000000189CFFE8C-0x0000000189D005B0
		public virtual void ActivateInputField() {} // 0x0000000183683F00-0x0000000183683FF0
		private void ActivateInputFieldInternal() {} // 0x0000000183683FF0-0x00000001836841C0
		public override void OnSelect(BaseEventData eventData) {} // 0x0000000183CDD120-0x0000000183CDD160
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x0000000183D4C560-0x0000000183D4C5A0
		public void OnControlClick() {} // 0x000000018350B670-0x000000018350B680
		public void ReleaseSelection() {} // 0x0000000183684250-0x00000001836842A0
		public virtual void DeactivateInputField(bool clearSelection = false /* Metadata: 0x01FD1920 */) {} // 0x0000000183683C00-0x0000000183683F00
		public override void OnDeselect(BaseEventData eventData) {} // 0x0000000183CBAB60-0x0000000183CBABA0
		public virtual void OnSubmit(BaseEventData eventData) {} // 0x0000000189CFF2F4-0x0000000189CFF33C
		private void EnforceContentType() {} // 0x0000000189CFD034-0x0000000189CFD168
		private void SetTextComponentWrapMode() {} // 0x0000000182849E50-0x0000000182849EC0
		private void SetTextComponentRichTextMode() {} // 0x0000000189CFFBCC-0x0000000189CFFC44
		private void SetToCustomIfContentTypeIsNot(params ContentType[] allowedContentTypes) {} // 0x0000000189CFFC50-0x0000000189CFFCA0
		private void SetToCustom() {} // 0x0000000189CFFCA0-0x0000000189CFFCB8
		private void SetToCustom(CharacterValidation characterValidation) {} // 0x0000000189CFFCA0-0x0000000189CFFCB8
		protected override void DoStateTransition(SelectionState state, bool instant) {} // 0x0000000183C84A00-0x0000000183C84A30
		public virtual void CalculateLayoutInputHorizontal() {} // 0x000000018350B670-0x000000018350B680
		public virtual void CalculateLayoutInputVertical() {} // 0x000000018350B670-0x000000018350B680
		public void SetGlobalPointSize(float pointSize) {} // 0x0000000189CFFB1C-0x0000000189CFFBCC
		public void SetGlobalFontAsset(TMP_FontAsset fontAsset) {} // 0x0000000189CFFA6C-0x0000000189CFFB1C
	}

	internal static class SetPropertyUtility // TypeDefIndex: 52327
	{
		// Methods
		public static bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue) => default; // 0x0000000189CFC4F4-0x0000000189CFC534
		public static bool SetEquatableStruct<T>(ref ref T currentValue, T newValue)
			where T : IEquatable<T> => default;
		public static bool SetStruct<T>(ref ref T currentValue, T newValue)
			where T : struct => default;
		public static bool SetClass<T>(ref ref T currentValue, T newValue)
			where T : class => default;
	}

	[Serializable]
	public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 52328
	{
		// Constructors
		protected TMP_InputValidator() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public abstract char Validate(ref string text, ref int pos, char ch);
	}

	public struct TMP_LineInfo // TypeDefIndex: 52329
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

	internal static class TMP_ListPool<T> // TypeDefIndex: 52331
	{
		// Fields
		private static readonly TMP_ObjectPool<List<T>> s_ListPool;
	
		// Constructors
		static TMP_ListPool() {}
	
		// Methods
		public static List<T> Get() => default;
		public static void Release(List<T> toRelease) {}
	}

	public static class TMP_MaterialManager // TypeDefIndex: 52338
	{
		// Fields
		private static List<MaskingMaterial> m_materialList; // 0x00
		private static Dictionary<long, FallbackMaterial> m_fallbackMaterials; // 0x08
		private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
		private static List<FallbackMaterial> m_fallbackCleanupList; // 0x18
		private static bool isFallbackListDirty; // 0x20
		private static string s_overlayShaderKeyword; // 0x28
	
		// Properties
		public static string overlayShaderKeyword { get; set; } // 0x0000000189D03244-0x0000000189D03294 0x0000000189D03294-0x0000000189D032F4
	
		// Nested types
		private class FallbackMaterial // TypeDefIndex: 52332
		{
			// Fields
			public long fallbackID; // 0x10
			public Material sourceMaterial; // 0x18
			internal int sourceMaterialCRC; // 0x20
			public Material fallbackMaterial; // 0x28
			public int count; // 0x30
	
			// Constructors
			public FallbackMaterial() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private class MaskingMaterial // TypeDefIndex: 52333
		{
			// Fields
			public Material baseMaterial; // 0x10
			public Material stencilMaterial; // 0x18
			public int count; // 0x20
			public int stencilID; // 0x24
	
			// Constructors
			public MaskingMaterial() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		static TMP_MaterialManager() {} // 0x0000000182CCFFC0-0x0000000182CD0210
	
		// Methods
		private static void OnPreRender() {} // 0x00000001831EB540-0x00000001831EB5C0
		public static Material GetStencilMaterial(Material baseMaterial, int stencilID) => default; // 0x0000000189D024C8-0x0000000189D02840
		public static void ReleaseStencilMaterial(Material stencilMaterial) {} // 0x0000000189D02CE4-0x0000000189D02ED8
		public static Material GetBaseMaterial(Material stencilMaterial) => default; // 0x0000000189D01E08-0x0000000189D01F54
		public static Material SetStencil(Material material, int stencilID) => default; // 0x0000000189D0318C-0x0000000189D03244
		public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) {} // 0x0000000189D01678-0x0000000189D018B4
		public static void RemoveStencilMaterial(Material stencilMaterial) {} // 0x0000000189D03050-0x0000000189D0318C
		public static void ReleaseBaseMaterial(Material baseMaterial) {} // 0x0000000189D02840-0x0000000189D02CE4
		public static void ClearMaterials() {} // 0x0000000189D018B4-0x0000000189D01A24
		public static int GetStencilID(GameObject obj) => default; // 0x0000000189D02274-0x0000000189D024C8
		public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) => default; // 0x000000018303D740-0x000000018303D970
		private static Transform FindRootSortOverrideCanvas(Transform start) => default; // 0x0000000189D01CBC-0x0000000189D01E08
		internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex) => default; // 0x0000000189D01F54-0x0000000189D02274
		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) => default; // 0x0000000182515160-0x00000001825155E0
		public static void AddFallbackMaterialReference(Material targetMaterial) {} // 0x0000000182514E40-0x0000000182514F80
		public static void RemoveFallbackMaterialReference(Material targetMaterial) {} // 0x0000000189D02ED8-0x0000000189D03050
		public static void CleanupFallbackMaterials() {} // 0x00000001831EB5C0-0x00000001831EB800
		public static void ReleaseFallbackMaterial(Material fallbackMaterial) {} // 0x0000000182514F80-0x0000000182515160
		public static void CopyMaterialPresetProperties(Material source, Material destination) {} // 0x0000000189D01A24-0x0000000189D01CBC
	}

	public enum VertexSortingOrder // TypeDefIndex: 52339
	{
		Normal = 0,
		Reverse = 1
	}

	public struct TMP_MeshInfo : IDisposable // TypeDefIndex: 52340
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
		} // 0x0000000182573C50-0x0000000182574280
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
		} // 0x0000000189D10A74-0x0000000189D1143C
		static TMP_MeshInfo() {
			s_DefaultColor = default;
			s_DefaultNormal = default;
			s_DefaultTangent = default;
			s_DefaultBounds = default;
		} // 0x0000000183CA9010-0x0000000183CA90B0
	
		// Methods
		public void ResizeMeshInfo(int size) {} // 0x000000018285BE00-0x000000018285C380
		public void ResizeMeshInfo(int size, bool isVolumetric) {} // 0x0000000189D0F520-0x0000000189D10084
		public void Clear() {} // 0x0000000189D0F490-0x0000000189D0F520
		public void Clear(bool uploadChanges) {} // 0x00000001822D4100-0x00000001822D42D0
		public void ClearUnusedVertices() {} // 0x0000000183B22710-0x0000000183B22750
		public void ClearUnusedVertices(int startIndex) {} // 0x0000000189D0F3B4-0x0000000189D0F3E8
		public void ClearUnusedVertices(int startIndex, bool updateMesh) {} // 0x0000000189D0F3E8-0x0000000189D0F490
		public void SortGeometry(VertexSortingOrder order) {} // 0x0000000189D10084-0x0000000189D10128
		public void SortGeometry(IList<int> sortingOrder) {} // 0x0000000189D10128-0x0000000189D10224
		public void SwapVertexData(int src, int dst) {} // 0x0000000189D10224-0x0000000189D10A74
		public void Dispose() {} // 0x000000018285E6F0-0x000000018285E910
	}

	internal class TMP_ObjectPool<T> // TypeDefIndex: 52341
		where T : new()
	{
		// Fields
		private readonly Stack<T> m_Stack;
		private readonly UnityAction<T> m_ActionOnGet;
		private readonly UnityAction<T> m_ActionOnRelease;
	
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

	public class TMP_ResourceManager // TypeDefIndex: 52342
	{
		// Fields
		private static readonly TMP_ResourceManager s_instance; // 0x00
		private static TMP_Settings s_TextSettings; // 0x08
		private static readonly List<TMP_FontAsset> s_FontAssetReferences; // 0x10
		private static readonly Dictionary<int, TMP_FontAsset> s_FontAssetReferenceLookup; // 0x18
	
		// Constructors
		static TMP_ResourceManager() {} // 0x0000000189D117A4-0x0000000189D118D8
		public TMP_ResourceManager() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal static TMP_Settings GetTextSettings() => default; // 0x0000000189D11538-0x0000000189D11628
		public static void AddFontAsset(TMP_FontAsset fontAsset) {} // 0x0000000189D1143C-0x0000000189D11538
		public static bool TryGetFontAsset(int hashcode, out TMP_FontAsset fontAsset) {
			fontAsset = default;
			return default;
		} // 0x0000000189D1171C-0x0000000189D117A4
		internal static void RebuildFontAssetCache(int instanceID) {} // 0x0000000189D11628-0x0000000189D1171C
	}

	internal enum MarkupTag // TypeDefIndex: 52343
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

	public enum TagValueType // TypeDefIndex: 52344
	{
		None = 0,
		NumericalValue = 1,
		StringValue = 2,
		ColorValue = 4
	}

	public enum TagUnitType // TypeDefIndex: 52345
	{
		Pixels = 0,
		FontUnits = 1,
		Percentage = 2
	}

	internal static class CodePoint // TypeDefIndex: 52346
	{
		// Fields
		public const uint SPACE = 32; // Metadata: 0x01FD1B60
		public const uint DOUBLE_QUOTE = 34; // Metadata: 0x01FD1B61
		public const uint NUMBER_SIGN = 35; // Metadata: 0x01FD1B62
		public const uint PERCENTAGE = 37; // Metadata: 0x01FD1B63
		public const uint PLUS = 43; // Metadata: 0x01FD1B64
		public const uint MINUS = 45; // Metadata: 0x01FD1B65
		public const uint PERIOD = 46; // Metadata: 0x01FD1B66
		public const uint HYPHEN_MINUS = 45; // Metadata: 0x01FD1B67
		public const uint SOFT_HYPHEN = 173; // Metadata: 0x01FD1B68
		public const uint HYPHEN = 8208; // Metadata: 0x01FD1B6A
		public const uint NON_BREAKING_HYPHEN = 8209; // Metadata: 0x01FD1B6C
		public const uint ZERO_WIDTH_SPACE = 8203; // Metadata: 0x01FD1B6E
		public const uint RIGHT_SINGLE_QUOTATION = 8217; // Metadata: 0x01FD1B70
		public const uint APOSTROPHE = 39; // Metadata: 0x01FD1B72
		public const uint WORD_JOINER = 8288; // Metadata: 0x01FD1B73
		public const uint HIGH_SURROGATE_START = 55296; // Metadata: 0x01FD1B75
		public const uint HIGH_SURROGATE_END = 56319; // Metadata: 0x01FD1B79
		public const uint LOW_SURROGATE_START = 56320; // Metadata: 0x01FD1B7D
		public const uint LOW_SURROGATE_END = 57343; // Metadata: 0x01FD1B81
		public const uint UNICODE_PLANE01_START = 65536; // Metadata: 0x01FD1B85
	}

	public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 52347
	{
		// Fields
		public bool isSelected; // 0x18
	
		// Constructors
		public TMP_ScrollbarEventHandler() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void OnPointerClick(PointerEventData eventData) {} // 0x0000000189D11930-0x0000000189D11984
		public void OnSelect(BaseEventData eventData) {} // 0x0000000189D11984-0x0000000189D119DC
		public void OnDeselect(BaseEventData eventData) {} // 0x0000000189D118D8-0x0000000189D11930
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class TMP_SelectionCaret : MaskableGraphic // TypeDefIndex: 52348
	{
		// Constructors
		public TMP_SelectionCaret() {} // 0x0000000183D4C420-0x0000000183D4C430
	
		// Methods
		public override void Cull(Rect clipRect, bool validRect) {} // 0x0000000182C6F1D0-0x0000000182C6F270
		protected override void UpdateGeometry() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[ExcludeFromPreset]
	public class TMP_Settings : ScriptableObject // TypeDefIndex: 52350
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
		public static string version { get => default; } // 0x0000000189D120E0-0x0000000189D1210C 
		public static bool enableWordWrapping { get => default; } // 0x0000000189D11FB0-0x0000000189D11FD0 
		public static bool enableKerning { get => default; } // 0x0000000189D11F30-0x0000000189D11F50 
		public static bool enableExtraPadding { get => default; } // 0x0000000189D11F10-0x0000000189D11F30 
		public static bool enableTintAllSprites { get => default; } // 0x0000000189D11F90-0x0000000189D11FB0 
		public static bool enableParseEscapeCharacters { get => default; } // 0x0000000189D11F50-0x0000000189D11F70 
		public static bool enableRaycastTarget { get => default; } // 0x0000000189D11F70-0x0000000189D11F90 
		public static bool getFontFeaturesAtRuntime { get => default; } // 0x0000000182EE7BF0-0x0000000182EE7C10 
		public static int missingGlyphCharacter { get => default; set {} } // 0x0000000189D12078-0x0000000189D12098 0x0000000189D12198-0x0000000189D121BC
		public static bool warningsDisabled { get => default; } // 0x0000000189D1210C-0x0000000189D1212C 
		public static TMP_FontAsset defaultFontAsset { get => default; } // 0x0000000189D11DD0-0x0000000189D11DF0 
		public static string defaultFontAssetPath { get => default; } // 0x0000000189D11DB0-0x0000000189D11DD0 
		public static float defaultFontSize { get => default; } // 0x0000000189D11DF0-0x0000000189D11E10 
		public static float defaultTextAutoSizingMinRatio { get => default; } // 0x0000000189D11E70-0x0000000189D11E90 
		public static float defaultTextAutoSizingMaxRatio { get => default; } // 0x0000000189D11E50-0x0000000189D11E70 
		public static Vector2 defaultTextMeshProTextContainerSize { get => default; } // 0x0000000189D11E90-0x0000000189D11EC0 
		public static Vector2 defaultTextMeshProUITextContainerSize { get => default; } // 0x0000000189D11EC0-0x0000000189D11EF0 
		public static bool autoSizeTextContainer { get => default; } // 0x0000000189D11D6C-0x0000000189D11D8C 
		public static bool isTextObjectScaleStatic { get => default; set {} } // 0x0000000189D12014-0x0000000189D12034 0x0000000189D12150-0x0000000189D12174
		public static List<TMP_FontAsset> fallbackFontAssets { get => default; } // 0x0000000189D11FD0-0x0000000189D11FF0 
		public static bool matchMaterialPreset { get => default; } // 0x00000001839CD010-0x00000001839CD030 
		public static TMP_SpriteAsset defaultSpriteAsset { get => default; } // 0x0000000189D11E30-0x0000000189D11E50 
		public static string defaultSpriteAssetPath { get => default; } // 0x0000000189D11E10-0x0000000189D11E30 
		public static bool enableEmojiSupport { get => default; set {} } // 0x0000000189D11EF0-0x0000000189D11F10 0x0000000189D1212C-0x0000000189D12150
		public static uint missingCharacterSpriteUnicode { get => default; set {} } // 0x0000000189D12058-0x0000000189D12078 0x0000000189D12174-0x0000000189D12198
		public static string defaultColorGradientPresetsPath { get => default; } // 0x0000000189D11D8C-0x0000000189D11DB0 
		public static TMP_StyleSheet defaultStyleSheet { get => default; } // 0x000000018296C8B0-0x000000018296C8E0 
		public static string styleSheetsResourcePath { get => default; } // 0x0000000189D12098-0x0000000189D120BC 
		public static TextAsset leadingCharacters { get => default; } // 0x0000000189D12034-0x0000000189D12058 
		public static TextAsset followingCharacters { get => default; } // 0x0000000189D11FF0-0x0000000189D12014 
		public static LineBreakingTable linebreakingRules { get => default; } // 0x000000018296C8E0-0x000000018296C930 
		public static bool useModernHangulLineBreakingRules { get => default; set {} } // 0x0000000189D120BC-0x0000000189D120E0 0x0000000189D121BC-0x0000000189D121E4
		public static TMP_Settings instance { get => default; } // 0x000000018296C930-0x000000018296CAA0 
	
		// Nested types
		public class LineBreakingTable // TypeDefIndex: 52349
		{
			// Fields
			public Dictionary<int, char> leadingCharacters; // 0x10
			public Dictionary<int, char> followingCharacters; // 0x18
	
			// Constructors
			public LineBreakingTable() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public TMP_Settings() {} // 0x0000000183D4CDA0-0x0000000183D4CDB0
	
		// Methods
		public static TMP_Settings LoadDefaultSettings() => default; // 0x0000000189D11C88-0x0000000189D11D6C
		public static TMP_Settings GetSettings() => default; // 0x0000000189D11B50-0x0000000189D11BB0
		public static TMP_FontAsset GetFontAsset() => default; // 0x0000000189D11AE4-0x0000000189D11B50
		public static void ClearDefaultFontAsset() {} // 0x0000000189D119DC-0x0000000189D11A78
		public static TMP_SpriteAsset GetSpriteAsset() => default; // 0x0000000189D11BB0-0x0000000189D11C1C
		public static TMP_StyleSheet GetStyleSheet() => default; // 0x0000000189D11C1C-0x0000000189D11C88
		public static void LoadLinebreakingRules() {} // 0x00000001834A2F60-0x00000001834A30B0
		public static IFontAssetLoader GetDynamicFallbackFontAssetLoader() => default; // 0x0000000189D11A78-0x0000000189D11AE4
		private static Dictionary<int, char> GetCharacters(TextAsset file) => default; // 0x00000001834A30B0-0x00000001834A31B0
	}

	public static class ShaderUtilities // TypeDefIndex: 52351
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
		internal static Shader ShaderRef_MobileSDF { get; } // 0x0000000189D0F12C-0x0000000189D0F218 
		internal static Shader ShaderRef_MobileBitmap { get; } // 0x0000000189D0F040-0x0000000189D0F12C 
	
		// Constructors
		static ShaderUtilities() {} // 0x00000001829687E0-0x0000000182968B60
	
		// Methods
		public static void GetShaderPropertyIDs() {} // 0x0000000182969CE0-0x000000018296A890
		public static void UpdateShaderRatios(Material mat) {} // 0x00000001828024F0-0x0000000182802B60
		public static Vector4 GetFontExtent(Material material) => default; // 0x0000000189D0E594-0x0000000189D0E5B4
		public static bool IsMaskingEnabled(Material material) => default; // 0x0000000182800F50-0x0000000182801160
		public static float GetPadding(Material material, bool enableExtraPadding, bool isBold) => default; // 0x0000000182801820-0x0000000182802090
		public static float GetPadding(Material[] materials, bool enableExtraPadding, bool isBold) => default; // 0x0000000189D0E5B4-0x0000000189D0F040
	}

	[Serializable]
	public class TMP_Sprite : TMP_TextElement_Legacy // TypeDefIndex: 52352
	{
		// Fields
		public string name; // 0x38
		public int hashCode; // 0x40
		public int unicode; // 0x44
		public Vector2 pivot; // 0x48
		public Sprite sprite; // 0x50
	
		// Constructors
		public TMP_Sprite() {} // 0x000000018350B670-0x000000018350B680
	}

	[DisallowMultipleComponent]
	public class TMP_SpriteAnimator : MonoBehaviour // TypeDefIndex: 52354
	{
		// Fields
		private Dictionary<int, bool> m_animations; // 0x18
		private TMP_Text m_TextComponent; // 0x20
	
		// Constructors
		public TMP_SpriteAnimator() {} // 0x0000000189D123F8-0x0000000189D1247C
	
		// Methods
		private void Awake() {} // 0x0000000189D121E4-0x0000000189D1222C
		private void OnEnable() {} // 0x000000018350B670-0x000000018350B680
		private void OnDisable() {} // 0x000000018350B670-0x000000018350B680
		public void StopAllAnimations() {} // 0x0000000189D123A8-0x0000000189D123F8
		public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) {} // 0x0000000189D122D0-0x0000000189D123A8
		[IteratorStateMachine(typeof(_DoSpriteAnimationInternal_d__7))]
		private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) => default; // 0x0000000189D1222C-0x0000000189D122D0
	}

	[ExcludeFromPreset]
	public class TMP_SpriteAsset : TMP_Asset // TypeDefIndex: 52356
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
		public string version { get => default; internal set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public FaceInfo faceInfo { get => default; internal set {} } // 0x0000000183D85440-0x0000000183D85480 0x0000000189D13D0C-0x0000000189D13D4C
		public List<TMP_SpriteCharacter> spriteCharacterTable { get => default; internal set {} } // 0x0000000189D13CDC-0x0000000189D13D0C 0x0000000182B47080-0x0000000182B470A0
		public Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable { get => default; internal set {} } // 0x0000000189D13CAC-0x0000000189D13CDC 0x00000001858AAF64-0x00000001858AAF78
		public List<TMP_SpriteGlyph> spriteGlyphTable { get => default; internal set {} } // 0x0000000183D50E60-0x0000000183D50E70 0x00000001858B426C-0x00000001858B4280
	
		// Constructors
		public TMP_SpriteAsset() {} // 0x0000000189D13BD8-0x0000000189D13CAC
	
		// Methods
		private void Awake() {} // 0x0000000189D1247C-0x0000000189D124EC
		private Material GetDefaultSpriteMaterial() => default; // 0x0000000189D124EC-0x0000000189D125C4
		public void UpdateLookupTables() {} // 0x0000000189D1336C-0x0000000189D138A8
		public int GetSpriteIndexFromHashcode(int hashCode) => default; // 0x0000000189D125C4-0x0000000189D12640
		public int GetSpriteIndexFromUnicode(uint unicode) => default; // 0x0000000189D126AC-0x0000000189D12738
		public int GetSpriteIndexFromName(string name) => default; // 0x0000000189D12640-0x0000000189D126AC
		public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x0000000189D12E5C-0x0000000189D13074
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x0000000189D12C54-0x0000000189D12DAC
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x0000000189D12DAC-0x0000000189D12E5C
		public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x0000000189D12940-0x0000000189D12C54
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x0000000189D127E8-0x0000000189D12940
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x0000000189D12738-0x0000000189D127E8
		public void SortGlyphTable() {} // 0x0000000189D13200-0x0000000189D1336C
		internal void SortCharacterTable() {} // 0x0000000189D13074-0x0000000189D131E0
		internal void SortGlyphAndCharacterTables() {} // 0x0000000189D131E0-0x0000000189D13200
		private void UpgradeSpriteAsset() {} // 0x0000000189D138A8-0x0000000189D13BD8
	}

	[Serializable]
	public class TMP_SpriteCharacter : TMP_TextElement // TypeDefIndex: 52357
	{
		// Fields
		[SerializeField]
		private string m_Name; // 0x30
		[SerializeField]
		private int m_HashCode; // 0x38
	
		// Properties
		public string name { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000189D13E10-0x0000000189D13E84
		public int hashCode { get => default; } // 0x0000000183D4EC30-0x0000000183D4EC40 
	
		// Constructors
		public TMP_SpriteCharacter() {} // 0x0000000183D85480-0x0000000183D85490
		public TMP_SpriteCharacter(uint unicode, TMP_SpriteGlyph glyph) {} // 0x0000000189D13D8C-0x0000000189D13DC8
		public TMP_SpriteCharacter(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph) {} // 0x0000000189D13DC8-0x0000000189D13E10
		internal TMP_SpriteCharacter(uint unicode, uint glyphIndex) {} // 0x0000000189D13D4C-0x0000000189D13D8C
	}

	[Serializable]
	public class TMP_SpriteGlyph : Glyph // TypeDefIndex: 52358
	{
		// Fields
		public Sprite sprite; // 0x48
	
		// Constructors
		public TMP_SpriteGlyph() {} // 0x0000000189D13F64-0x0000000189D13F6C
		public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) {} // 0x0000000189D13EFC-0x0000000189D13F64
		public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex, Sprite sprite) {} // 0x0000000189D13E84-0x0000000189D13EFC
	}

	[Serializable]
	public class TMP_Style // TypeDefIndex: 52359
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
		public static TMP_Style NormalStyle { get => default; } // 0x0000000189D14010-0x0000000189D140EC 
		public string name { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x0000000189D140F8-0x0000000189D14134
		public int hashCode { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000189D140EC-0x0000000189D140F8
		public string styleOpeningDefinition { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public string styleClosingDefinition { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public int[] styleOpeningTagArray { get => default; } // 0x0000000181003830-0x0000000181003840 
		public int[] styleClosingTagArray { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
	
		// Constructors
		public TMP_Style() {} // Dummy constructor
		internal TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition) {} // 0x0000000183302030-0x00000001833020E0
	
		// Methods
		public void RefreshStyle() {} // 0x00000001833023B0-0x00000001833025E0
	}

	[Serializable]
	[ExcludeFromPreset]
	public class TMP_StyleSheet : ScriptableObject // TypeDefIndex: 52360
	{
		// Fields
		[SerializeField]
		private List<TMP_Style> m_StyleList; // 0x18
		private Dictionary<int, TMP_Style> m_StyleLookupDictionary; // 0x20
	
		// Properties
		internal List<TMP_Style> styles { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public TMP_StyleSheet() {} // 0x0000000183CEEF90-0x0000000183CEF020
	
		// Methods
		private void Reset() {} // 0x0000000189D14008-0x0000000189D14010
		public TMP_Style GetStyle(int hashCode) => default; // 0x000000018296CAA0-0x000000018296CBA0
		public TMP_Style GetStyle(string name) => default; // 0x0000000189D13F6C-0x0000000189D14008
		public void RefreshStyles() {} // 0x0000000189D14008-0x0000000189D14010
		private void LoadStyleDictionaryInternal() {} // 0x00000001833020E0-0x00000001833023B0
	}

	[ExecuteAlways]
	[RequireComponent(typeof(MeshRenderer))]
	public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 52361
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
		public TMP_FontAsset fontAsset { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public TMP_SpriteAsset spriteAsset { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public Material material { get => default; set {} } // 0x0000000189D152F4-0x0000000189D15300 0x0000000189D156B0-0x0000000189D15740
		public Material sharedMaterial { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000189D15740-0x0000000189D15748
		public Material fallbackMaterial { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x0000000189D155A8-0x0000000189D156B0
		public Material fallbackSourceMaterial { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public bool isDefaultMaterial { get => default; set {} } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x0000000183D4F010-0x0000000183D4F020
		public float padding { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public Renderer renderer { get => default; } // 0x0000000189D154A0-0x0000000189D15524 
		public MeshFilter meshFilter { get => default; } // 0x0000000189D15300-0x0000000189D153F4 
		public Mesh mesh { get => default; set {} } // 0x0000000189D153F4-0x0000000189D154A0 0x00000001839274B0-0x00000001839274C0
		public TMP_Text textComponent { get => default; } // 0x0000000189D15524-0x0000000189D155A8 
	
		// Constructors
		public TMP_SubMesh() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) => default; // 0x0000000189D146E0-0x0000000189D14A40
		private void OnEnable() {} // 0x0000000189D14F48-0x0000000189D1504C
		private void OnDisable() {} // 0x0000000189D14EA4-0x0000000189D14F48
		private void OnDestroy() {} // 0x0000000189D14D8C-0x0000000189D14EA4
		public void DestroySelf() {} // 0x0000000189D14AF4-0x0000000189D14B4C
		private Material GetMaterial(Material mat) => default; // 0x0000000189D14B4C-0x0000000189D14C78
		private Material CreateMaterialInstance(Material source) => default; // 0x0000000189D14A40-0x0000000189D14AF4
		private Material GetSharedMaterial() => default; // 0x0000000189D14CF8-0x0000000189D14D8C
		private void SetSharedMaterial(Material mat) {} // 0x0000000189D15054-0x0000000189D15088
		public float GetPaddingForMaterial() => default; // 0x0000000189D14C78-0x0000000189D14CF8
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) {} // 0x0000000189D15280-0x0000000189D152F4
		public void SetVerticesDirty() {} // 0x0000000189D15088-0x0000000189D15118
		public void SetMaterialDirty() {} // 0x0000000189D1504C-0x0000000189D15054
		protected void UpdateMaterial() {} // 0x0000000189D15118-0x0000000189D15280
	}

	[ExecuteAlways]
	[RequireComponent(typeof(CanvasRenderer))]
	public class TMP_SubMeshUI : MaskableGraphic // TypeDefIndex: 52362
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
		public TMP_FontAsset fontAsset { get => default; set {} } // 0x0000000183D50EA0-0x0000000183D50EB0 0x00000001856A2B64-0x00000001856A2B78
		public TMP_SpriteAsset spriteAsset { get => default; set {} } // 0x0000000183D51950-0x0000000183D51960 0x00000001858B408C-0x00000001858B40A0
		public override Texture mainTexture { get => default; } // 0x0000000189D1453C-0x0000000189D145E0 
		public override Material material { get => default; set {} } // 0x0000000189D145E0-0x0000000189D145F0 0x0000000189D145F0-0x0000000189D146D8
		public Material sharedMaterial { get => default; set {} } // 0x0000000183D50770-0x0000000183D50780 0x0000000189D146D8-0x0000000189D146E0
		public Material fallbackMaterial { get => default; set {} } // 0x0000000183D56D30-0x0000000183D56D40 0x00000001825156D0-0x00000001825157E0
		public Material fallbackSourceMaterial { get => default; set {} } // 0x0000000183D56CF0-0x0000000183D56D00 0x0000000184275CF4-0x0000000184275D08
		public override Material materialForRendering { get => default; } // 0x000000018303D660-0x000000018303D6D0 
		public bool isDefaultMaterial { get => default; set {} } // 0x0000000183D57B90-0x0000000183D57BA0 0x0000000183D5E110-0x0000000183D5E120
		public float padding { get => default; set {} } // 0x0000000183D4FAF0-0x0000000183D4FB00 0x0000000183D85490-0x0000000183D854A0
		public Mesh mesh { get => default; set {} } // 0x0000000183441F50-0x0000000183442040 0x0000000184275CA4-0x0000000184275CB8
		public TMP_Text textComponent { get => default; } // 0x000000018379BE00-0x000000018379BE80 
	
		// Constructors
		public TMP_SubMeshUI() {} // 0x0000000183D4C420-0x0000000183D4C430
	
		// Methods
		public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) => default; // 0x00000001825159C0-0x0000000182515D30
		protected override void OnEnable() {} // 0x0000000183D22CB0-0x0000000183D22D00
		protected override void OnDisable() {} // 0x0000000182514D80-0x0000000182514E40
		protected override void OnDestroy() {} // 0x0000000183771110-0x0000000183771280
		protected override void OnTransformParentChanged() {} // 0x0000000189D1444C-0x0000000189D14490
		public override Material GetModifiedMaterial(Material baseMaterial) => default; // 0x0000000182515D80-0x0000000182515E30
		public float GetPaddingForMaterial() => default; // 0x0000000182515840-0x00000001825158D0
		public float GetPaddingForMaterial(Material mat) => default; // 0x0000000189D142F4-0x0000000189D14378
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) {} // 0x0000000189D144C0-0x0000000189D1453C
		public override void SetAllDirty() {} // 0x000000018350B670-0x000000018350B680
		public override void SetVerticesDirty() {} // 0x0000000183771280-0x0000000183771340
		public override void SetLayoutDirty() {} // 0x000000018350B670-0x000000018350B680
		public override void SetMaterialDirty() {} // 0x0000000183CDDF00-0x0000000183CDDF30
		public void SetPivotDirty() {} // 0x00000001838015A0-0x0000000183801620
		private Transform GetRootCanvasTransform() => default; // 0x0000000189D14378-0x0000000189D14424
		public override void Cull(Rect clipRect, bool validRect) {} // 0x000000018350B670-0x000000018350B680
		protected override void UpdateGeometry() {} // 0x000000018350B670-0x000000018350B680
		public override void Rebuild(CanvasUpdate update) {} // 0x0000000189D14490-0x0000000189D144C0
		public void RefreshMaterial() {} // 0x0000000189381C74-0x0000000189381C84
		protected override void UpdateMaterial() {} // 0x000000018379BC30-0x000000018379BE00
		public override void RecalculateClipping() {} // 0x0000000182515D70-0x0000000182515D80
		private Material GetMaterial() => default; // 0x0000000183D50770-0x0000000183D50780
		private Material GetMaterial(Material mat) => default; // 0x0000000189D141E8-0x0000000189D142F4
		private Material CreateMaterialInstance(Material source) => default; // 0x0000000189D14134-0x0000000189D141E8
		private Material GetSharedMaterial() => default; // 0x0000000189D14424-0x0000000189D1444C
		private void SetSharedMaterial(Material mat) {} // 0x00000001825157E0-0x0000000182515840
	}

	public interface ITextElement // TypeDefIndex: 52363
	{
		// Properties
		Material sharedMaterial { get; }
	
		// Methods
		void Rebuild(CanvasUpdate update);
		int GetInstanceID();
	}

	public enum TextAlignmentOptions // TypeDefIndex: 52364
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

	public enum HorizontalAlignmentOptions // TypeDefIndex: 52365
	{
		Left = 1,
		Center = 2,
		Right = 4,
		Justified = 8,
		Flush = 16,
		Geometry = 32
	}

	public enum VerticalAlignmentOptions // TypeDefIndex: 52366
	{
		Top = 256,
		Middle = 512,
		Bottom = 1024,
		Baseline = 2048,
		Geometry = 4096,
		Capline = 8192
	}

	public enum TextRenderFlags // TypeDefIndex: 52367
	{
		DontRender = 0,
		Render = 255
	}

	public enum TMP_TextElementType // TypeDefIndex: 52368
	{
		Character = 0,
		Sprite = 1,
		Image = 2
	}

	public enum MaskingTypes // TypeDefIndex: 52369
	{
		MaskOff = 0,
		MaskHard = 1,
		MaskSoft = 2
	}

	public enum TextOverflowModes // TypeDefIndex: 52370
	{
		Overflow = 0,
		Ellipsis = 1,
		Masking = 2,
		Truncate = 3,
		ScrollRect = 4,
		Page = 5,
		Linked = 6
	}

	public enum MaskingOffsetMode // TypeDefIndex: 52371
	{
		Percentage = 0,
		Pixel = 1
	}

	public enum TextureMappingOptions // TypeDefIndex: 52372
	{
		Character = 0,
		Line = 1,
		Paragraph = 2,
		MatchAspect = 3
	}

	[Flags]
	public enum FontStyles // TypeDefIndex: 52373
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

	public enum FontWeight // TypeDefIndex: 52374
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

	public class PhoneticData // TypeDefIndex: 52375
	{
		// Fields
		public static PhoneticData Default; // 0x00
		public string m_phonetic; // 0x10
		public bool m_autoSize; // 0x18
		public bool m_padding; // 0x19
		public bool m_justify; // 0x1A
		public int m_length; // 0x1C
		public int m_startIndex; // 0x20
		public int m_startCharCount; // 0x24
	
		// Constructors
		public PhoneticData() {} // 0x0000000183C9C260-0x0000000183C9C2C0
		static PhoneticData() {} // 0x0000000183C9C1F0-0x0000000183C9C260
	}

	public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 52382
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
		protected const float m_basePhoneticElementScale = 0.5f; // Metadata: 0x01FD1C31
		protected FontStyles m_phoneticFontStyle; // 0x234
		protected FontWeight m_phoneticFontWeight; // 0x238
		protected WordWrapState m_phoneticWordWarpState; // 0x240
		protected int m_phoneticStartCharIndex; // 0x5D8
		protected int m_phoneticStartIndex; // 0x5DC
		protected int m_phoneticEndIndex; // 0x5E0
		protected bool m_isPhoneticOverLength; // 0x5E4
		protected List<float> m_phoneticSizeList; // 0x5E8
		protected TMP_TextProcessingQueue<PhoneticData> m_phoneticDataQueue; // 0x5F0
		protected PhoneticData m_currentPhoneticData; // 0x610
		protected int m_phoneticCount; // 0x618
		protected float m_phoneticFontSize; // 0x61C
		[SerializeField]
		protected bool m_showPhonetic; // 0x620
		protected int m_phoneticIndex; // 0x624
		[SerializeField]
		protected bool m_needParseActionId; // 0x628
		[SerializeField]
		protected FontWeight m_fontWeight; // 0x62C
		protected FontWeight m_FontWeightInternal; // 0x630
		protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; // 0x638
		[SerializeField]
		protected bool m_enableAutoSizing; // 0x658
		protected float m_maxFontSize; // 0x65C
		protected float m_minFontSize; // 0x660
		protected int m_AutoSizeIterationCount; // 0x664
		protected int m_AutoSizeMaxIterationCount; // 0x668
		protected bool m_IsAutoSizePointSizeSet; // 0x66C
		[SerializeField]
		protected float m_fontSizeMin; // 0x670
		[SerializeField]
		protected float m_fontSizeMax; // 0x674
		[SerializeField]
		protected FontStyles m_fontStyle; // 0x678
		protected FontStyles m_FontStyleInternal; // 0x67C
		protected TMP_FontStyleStack m_fontStyleStack; // 0x680
		protected bool m_isUsingBold; // 0x68A
		[SerializeField]
		protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x68C
		[SerializeField]
		protected VerticalAlignmentOptions m_VerticalAlignment; // 0x690
		[FormerlySerializedAs("m_lineJustification")]
		[SerializeField]
		protected TextAlignmentOptions m_textAlignment; // 0x694
		protected HorizontalAlignmentOptions m_lineJustification; // 0x698
		protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x6A0
		protected Vector3[] m_textContainerLocalCorners; // 0x6C0
		[SerializeField]
		protected float m_characterSpacing; // 0x6C8
		protected float m_cSpacing; // 0x6CC
		protected float m_monoSpacing; // 0x6D0
		[SerializeField]
		protected float m_wordSpacing; // 0x6D4
		[SerializeField]
		protected float m_lineSpacing; // 0x6D8
		protected float m_lineSpacingDelta; // 0x6DC
		protected float m_lineHeight; // 0x6E0
		protected bool m_IsDrivenLineSpacing; // 0x6E4
		[SerializeField]
		protected float m_lineSpacingMax; // 0x6E8
		[SerializeField]
		protected float m_paragraphSpacing; // 0x6EC
		[SerializeField]
		protected float m_charWidthMaxAdj; // 0x6F0
		protected float m_charWidthAdjDelta; // 0x6F4
		[SerializeField]
		protected bool m_enableWordWrapping; // 0x6F8
		protected bool m_isCharacterWrappingEnabled; // 0x6F9
		protected bool m_isNonBreakingSpace; // 0x6FA
		protected bool m_isIgnoringAlignment; // 0x6FB
		[SerializeField]
		protected float m_wordWrappingRatios; // 0x6FC
		[SerializeField]
		protected TextOverflowModes m_overflowMode; // 0x700
		protected int m_firstOverflowCharacterIndex; // 0x704
		[SerializeField]
		protected TMP_Text m_linkedTextComponent; // 0x708
		[SerializeField]
		internal TMP_Text parentLinkedComponent; // 0x710
		protected bool m_isTextTruncated; // 0x718
		[SerializeField]
		protected bool m_enableKerning; // 0x719
		protected float m_GlyphHorizontalAdvanceAdjustment; // 0x71C
		[SerializeField]
		protected bool m_enableExtraPadding; // 0x720
		[SerializeField]
		protected bool checkPaddingRequired; // 0x721
		[SerializeField]
		protected bool m_isRichText; // 0x722
		[SerializeField]
		protected bool m_enableHyperlink; // 0x723
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
		protected bool m_autoSizeTextContainer; // 0x7B9
		protected Mesh m_mesh; // 0x7C0
		[SerializeField]
		protected bool m_isVolumetricText; // 0x7C8
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
		public virtual string text { get; set; } // 0x00000001831E7010-0x00000001831E7030 0x00000001830CAB10-0x00000001830CABC0
		public virtual string textForPopulate { get; } // 0x0000000182815E50-0x0000000182815E90 
		public ITextPreprocessor textPreprocessor { get; set; } // 0x0000000183D50770-0x0000000183D50780 0x00000001855631FC-0x0000000185563210
		public bool isRightToLeftText { get; set; } // 0x0000000183D57BA0-0x0000000183D57BB0 0x0000000189D0DD5C-0x0000000189D0DDA0
		public TMP_FontAsset font { get; set; } // 0x0000000184273118-0x0000000184273120 0x0000000189D0DBC4-0x0000000189D0DC68
		public virtual TMP_FontAsset m_fontAsset { get; set; } // 0x0000000183D56CF0-0x0000000183D56D00 0x0000000184275CF4-0x0000000184275D08
		public virtual Material fontSharedMaterial { get; set; } // 0x0000000183D56F00-0x0000000183D56F10 0x0000000189D0DA5C-0x0000000189D0DAF4
		protected virtual Material m_sharedMaterial { get; set; } // 0x0000000183D56F00-0x0000000183D56F10 0x0000000184275CB8-0x0000000184275CCC
		public virtual Material[] fontSharedMaterials { get; set; } // 0x0000000189D0CDCC-0x0000000189D0CDFC 0x0000000189D0DA20-0x0000000189D0DA5C
		public Material fontMaterial { get; set; } // 0x0000000189D0CD78-0x0000000189D0CD8C 0x0000000189D0D944-0x0000000189D0DA20
		public virtual Material[] fontMaterials { get; set; } // 0x0000000189D0CD8C-0x0000000189D0CDCC 0x0000000189D0DA20-0x0000000189D0DA5C
		public override UnityEngine.Color color { get; set; } // 0x0000000183CA4A40-0x0000000183CA4A50 0x00000001838DF5F0-0x00000001838DF650
		public float alpha { get; set; } // 0x0000000183D582A0-0x0000000183D582B0 0x0000000189D0D600-0x0000000189D0D62C
		public bool enableVertexGradient { get; set; } // 0x0000000183D57C50-0x0000000183D57C60 0x0000000189D0D808-0x0000000189D0D830
		public VertexGradient colorGradient { get; set; } // 0x0000000183D850C0-0x0000000183D850F0 0x0000000189D0D6F8-0x0000000189D0D73C
		public TMP_ColorGradient colorGradientPreset { get; set; } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000189D0D6C4-0x0000000189D0D6F8
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x0000000183D571D0-0x0000000183D571E0 0x0000000189D0E354-0x0000000189D0E398
		public bool tintAllSprites { get; set; } // 0x0000000183D57AF0-0x0000000183D57B00 0x0000000189D0E43C-0x0000000189D0E464
		public TMP_StyleSheet styleSheet { get; set; } // 0x0000000183D50210-0x0000000183D50220 0x0000000189D0E398-0x0000000189D0E3DC
		public TMP_Style textStyle { get; set; } // 0x000000018296C560-0x000000018296C5B0 0x0000000189D0E3DC-0x0000000189D0E43C
		public bool overrideColorTags { get; set; } // 0x0000000183D6DF30-0x0000000183D6DF40 0x0000000189D0E1F8-0x0000000189D0E220
		public Color32 faceColor { get; set; } // 0x0000000189D0CCB0-0x0000000189D0CD78 0x0000000189D0D8B8-0x0000000189D0D91C
		public Color32 outlineColor { get; set; } // 0x0000000189D0CFC4-0x0000000189D0D08C 0x0000000189D0E104-0x0000000189D0E15C
		public float outlineWidth { get; set; } // 0x0000000189D0D08C-0x0000000189D0D13C 0x0000000189D0E15C-0x0000000189D0E1B4
		public float fontSize { get; set; } // 0x0000000183D59A20-0x0000000183D59A30 0x0000000182CD08B0-0x0000000182CD08E0
		protected float PhoneticElementScale { get; } // 0x0000000189D0CBEC-0x0000000189D0CC0C 
		protected string m_currentPhonetic { get; } // 0x0000000189D0CF60-0x0000000189D0CFC4 
		protected bool m_currentEnablePhoneticAutoPadding { get; } // 0x0000000183B1EB90-0x0000000183B1EC10 
		protected bool m_currentEnablePhoneticAutoSize { get; } // 0x0000000189D0CEFC-0x0000000189D0CF60 
		protected bool m_currentEnablePhoneticAutoJustify { get; } // 0x0000000189D0CE98-0x0000000189D0CEFC 
		public FontWeight fontWeight { get; set; } // 0x0000000183D851C0-0x0000000183D851D0 0x0000000189D0DB80-0x0000000189D0DBC4
		public float pixelsPerUnit { get; } // 0x0000000189D0D13C-0x0000000189D0D25C 
		public bool enableAutoSizing { get; set; } // 0x0000000183D850F0-0x0000000183D85100 0x0000000189D0D73C-0x0000000189D0D778
		public float fontSizeMin { get; set; } // 0x0000000183D851A0-0x0000000183D851B0 0x0000000189D0DAF4-0x0000000189D0DB3C
		public float fontSizeMax { get; set; } // 0x0000000183D85190-0x0000000183D851A0 0x0000000182CD15B0-0x0000000182CD15E0
		public FontStyles fontStyle { get; set; } // 0x0000000183D851B0-0x0000000183D851C0 0x0000000189D0DB3C-0x0000000189D0DB80
		public bool isUsingBold { get; } // 0x0000000183D85260-0x0000000183D85270 
		public HorizontalAlignmentOptions horizontalAlignment { get; set; } // 0x0000000183D851F0-0x0000000183D85200 0x0000000189D0DC88-0x0000000189D0DCB0
		public VerticalAlignmentOptions verticalAlignment { get; set; } // 0x0000000183D853E0-0x0000000183D853F0 0x0000000189D0E4AC-0x0000000189D0E4D4
		public TextAlignmentOptions alignment { get; set; } // 0x0000000183D85080-0x0000000183D85090 0x0000000189D0D5C4-0x0000000189D0D600
		public float characterSpacing { get; set; } // 0x0000000183D850A0-0x0000000183D850B0 0x0000000189D0D62C-0x0000000189D0D678
		public float wordSpacing { get; set; } // 0x0000000183D85400-0x0000000183D85410 0x0000000189D0E4FC-0x0000000189D0E548
		public float lineSpacing { get; set; } // 0x0000000183D852B0-0x0000000183D852C0 0x0000000189D0DEA0-0x0000000189D0DEEC
		public float lineSpacingAdjustment { get; set; } // 0x0000000183D852A0-0x0000000183D852B0 0x0000000189D0DE54-0x0000000189D0DEA0
		public float paragraphSpacing { get; set; } // 0x0000000183D85360-0x0000000183D85370 0x0000000189D0E248-0x0000000189D0E294
		public float characterWidthAdjustment { get; set; } // 0x0000000183D850B0-0x0000000183D850C0 0x0000000189D0D678-0x0000000189D0D6C4
		public bool enableWordWrapping { get; set; } // 0x0000000183D85130-0x0000000183D85140 0x0000000189D0D830-0x0000000189D0D874
		public float wordWrappingRatios { get; set; } // 0x0000000183D85410-0x0000000183D85420 0x0000000189D0E548-0x0000000189D0E594
		public TextOverflowModes overflowMode { get; set; } // 0x0000000183D65E10-0x0000000183D65E20 0x0000000189D0E1B4-0x0000000189D0E1F8
		public bool isTextOverflowing { get; } // 0x0000000189D0CDFC-0x0000000189D0CE08 
		public int firstOverflowCharacterIndex { get; } // 0x0000000183D85150-0x0000000183D85160 
		public TMP_Text linkedTextComponent { get; set; } // 0x0000000183D6C480-0x0000000183D6C490 0x0000000189D0DEEC-0x0000000189D0DFE0
		public bool isTextTruncated { get; } // 0x0000000183D85250-0x0000000183D85260 
		public bool enableKerning { get; set; } // 0x0000000183D85120-0x0000000183D85130 0x0000000189D0D7C4-0x0000000189D0D808
		public bool extraPadding { get; set; } // 0x0000000183D85140-0x0000000183D85150 0x0000000189D0D874-0x0000000189D0D8B8
		public bool richText { get; set; } // 0x0000000183D853A0-0x0000000183D853B0 0x0000000189D0E310-0x0000000189D0E354
		public bool enableHyperlink { get; set; } // 0x0000000183D85110-0x0000000183D85120 0x0000000189D0D7AC-0x0000000189D0D7C4
		public float richTextColorBlend { get; set; } // 0x0000000183D85390-0x0000000183D853A0 0x0000000189D0E2F0-0x0000000189D0E310
		public bool parseCtrlCharacters { get; set; } // 0x0000000183D85370-0x0000000183D85380 0x0000000189D0E294-0x0000000189D0E2D8
		public bool isOverlay { get; set; } // 0x0000000183D85230-0x0000000183D85240 0x0000000189D0DD18-0x0000000189D0DD5C
		public bool isOrthographic { get; set; } // 0x0000000183D85220-0x0000000183D85230 0x0000000189D0DCF0-0x0000000189D0DD18
		public bool enableCulling { get; set; } // 0x0000000183D85100-0x0000000183D85110 0x0000000189D0D778-0x0000000189D0D7AC
		public bool ignoreVisibility { get; set; } // 0x0000000183D85210-0x0000000183D85220 0x0000000189D0DCD8-0x0000000189D0DCF0
		public TextureMappingOptions horizontalMapping { get; set; } // 0x0000000183D85200-0x0000000183D85210 0x0000000189D0DCB0-0x0000000189D0DCD8
		public TextureMappingOptions verticalMapping { get; set; } // 0x0000000183D853F0-0x0000000183D85400 0x0000000189D0E4D4-0x0000000189D0E4FC
		public float mappingUvLineOffset { get; set; } // 0x0000000183D852C0-0x0000000183D852D0 0x0000000189D0DFE0-0x0000000189D0E00C
		public TextRenderFlags renderMode { get; set; } // 0x0000000183D85380-0x0000000183D85390 0x0000000189D0E2D8-0x0000000189D0E2F0
		public VertexSortingOrder geometrySortingOrder { get; set; } // 0x0000000183D851D0-0x0000000183D851E0 0x0000000189D0DC68-0x0000000189D0DC88
		public bool isTextObjectScaleStatic { get; set; } // 0x0000000183D85240-0x0000000183D85250 0x0000000189D0DDA0-0x0000000189D0DE00
		public bool vertexBufferAutoSizeReduction { get; set; } // 0x0000000183D853D0-0x0000000183D853E0 0x0000000189D0E48C-0x0000000189D0E4AC
		public int firstVisibleCharacter { get; set; } // 0x0000000183D85160-0x0000000183D85170 0x0000000189D0D91C-0x0000000189D0D944
		public int maxVisibleCharacters { get; set; } // 0x0000000183D852F0-0x0000000183D85300 0x0000000183B3CE20-0x0000000183B3CE50
		public int maxVisibleWords { get; set; } // 0x0000000183D85310-0x0000000183D85320 0x0000000189D0E0DC-0x0000000189D0E104
		public int maxVisibleLines { get; set; } // 0x0000000183D85300-0x0000000183D85310 0x0000000189D0E0B4-0x0000000189D0E0DC
		public bool useMaxVisibleDescender { get; set; } // 0x0000000183D853C0-0x0000000183D853D0 0x0000000189D0E464-0x0000000189D0E48C
		public int pageToDisplay { get; set; } // 0x0000000183D85350-0x0000000183D85360 0x0000000189D0E220-0x0000000189D0E248
		public virtual Vector4 margin { get; set; } // 0x0000000183D852D0-0x0000000183D852E0 0x0000000189D0E00C-0x0000000189D0E0B4
		public TMP_TextInfo textInfo { get; } // 0x0000000183D853B0-0x0000000183D853C0 
		public bool havePropertiesChanged { get; set; } // 0x0000000183D851E0-0x0000000183D851F0 0x0000000183771340-0x00000001837714D0
		public bool isUsingLegacyAnimationComponent { get; set; } // 0x0000000183D85270-0x0000000183D85280 0x0000000183D85430-0x0000000183D85440
		public new Transform transform { get; } // 0x0000000182517370-0x00000001825174B0 
		public new RectTransform rectTransform { get; } // 0x00000001824A5A00-0x00000001824A5B40 
		public virtual bool autoSizeTextContainer { get; set; } // 0x0000000183D85090-0x0000000183D850A0 0x0000000183D85420-0x0000000183D85430
		public virtual Mesh mesh { get; } // 0x0000000183D84BD0-0x0000000183D84BE0 
		public bool isVolumetricText { get; set; } // 0x0000000183D85280-0x0000000183D85290 0x0000000189D0DE00-0x0000000189D0DE54
		public Bounds bounds { get; } // 0x0000000189D0CC0C-0x0000000189D0CCB0 
		public Bounds textBounds { get; } // 0x0000000189D0D350-0x0000000189D0D3A4 
		protected TMP_SpriteAnimator spriteAnimator { get; } // 0x0000000189D0D25C-0x0000000189D0D350 
		public float flexibleHeight { get; } // 0x0000000183D85170-0x0000000183D85180 
		public float flexibleWidth { get; } // 0x0000000183D85180-0x0000000183D85190 
		public float minWidth { get; } // 0x0000000183D85340-0x0000000183D85350 
		public float minHeight { get; } // 0x0000000183D85330-0x0000000183D85340 
		public float maxWidth { get; } // 0x0000000183D85320-0x0000000183D85330 
		public float maxHeight { get; } // 0x0000000183D852E0-0x0000000183D852F0 
		protected LayoutElement layoutElement { get; } // 0x0000000189D0CE08-0x0000000189D0CE98 
		public virtual float preferredWidth { get; } // 0x0000000184270798-0x00000001842707B8 
		public virtual float preferredHeight { get; } // 0x0000000184270768-0x0000000184270790 
		public virtual float renderedWidth { get; } // 0x0000000189D085D8-0x0000000189D085F4 
		public virtual float renderedHeight { get; } // 0x0000000189D084E8-0x0000000189D08504 
		public int layoutPriority { get; } // 0x0000000183D85290-0x0000000183D852A0 
	
		// Events
		public static event Func<int, string, TMP_FontAsset> OnFontAssetRequest;
		public static event Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest;
		public virtual event Action<TMP_TextInfo> OnPreRenderText;
	
		// Nested types
		protected struct CharacterSubstitution // TypeDefIndex: 52376
		{
			// Fields
			public int index; // 0x00
			public uint unicode; // 0x04
	
			// Constructors
			public CharacterSubstitution(int index, uint unicode) {
				this.index = default;
				this.unicode = default;
			} // 0x0000000183D4E4B0-0x0000000183D4E4C0
		}
	
		internal enum TextInputSources // TypeDefIndex: 52377
		{
			TextInputBox = 0,
			SetText = 1,
			SetTextArray = 2,
			TextString = 3
		}
	
		[DebuggerDisplay("Unicode ({unicode})  \'{(char)unicode}\'")]
		protected struct UnicodeChar // TypeDefIndex: 52378
		{
			// Fields
			public int unicode; // 0x00
			public int stringIndex; // 0x04
			public int length; // 0x08
		}
	
		protected struct SpecialCharacter // TypeDefIndex: 52379
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
			} // 0x000000018296AA20-0x000000018296ABE0
		}
	
		private struct TextBackingContainer : IDisposable // TypeDefIndex: 52380
		{
			// Fields
			private uint[] m_Array; // 0x00
			private int m_Count; // 0x08
	
			// Properties
			public int Capacity { get => default; } // 0x0000000184271BF0-0x0000000184271C0C 
			public int Count { get => default; set {} } // 0x0000000183D516F0-0x0000000183D51700 0x0000000183D51710-0x0000000183D51720
			public uint this[int index] { get => default; set {} } // 0x00000001825716A0-0x00000001825716D0 0x00000001828179D0-0x0000000182817A30
	
			// Constructors
			public TextBackingContainer(int size) : this() {
				m_Array = default;
				m_Count = default;
			} // 0x000000018285F330-0x000000018285F3B0
	
			// Methods
			public void Resize(int size) {} // 0x000000018337F9E0-0x000000018337FA60
			public void Dispose() {} // 0x000000018285EC40-0x000000018285ECB0
		}
	
		// Constructors
		protected TMP_Text() {} // 0x0000000182845730-0x0000000182845CC0
		static TMP_Text() {} // 0x00000001837F5270-0x00000001837F5860
	
		// Methods
		public void ResetTextForPopulate() {} // 0x0000000189D0B84C-0x0000000189D0B85C
		public virtual void RefreshPopulateText() {} // 0x0000000189D0A85C-0x0000000189D0A88C
		protected virtual Material LoadMaterial(string path) => default; // 0x0000000181002730-0x0000000181002740
		protected override void Awake() {} // 0x0000000184271BC8-0x0000000184271BD0
		protected void InitDataFromPool() {} // 0x000000018285ED80-0x000000018285F330
		protected override void OnDestroy() {} // 0x000000018285E910-0x000000018285EBB0
		protected virtual void LoadFontAsset() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void SetSharedMaterial(Material mat) {} // 0x000000018350B670-0x000000018350B680
		protected virtual Material GetMaterial(Material mat) => default; // 0x0000000181002730-0x0000000181002740
		protected virtual void SetFontBaseMaterial(Material mat) {} // 0x000000018350B670-0x000000018350B680
		protected virtual Material[] GetSharedMaterials() => default; // 0x0000000181002730-0x0000000181002740
		protected virtual void SetSharedMaterials(Material[] materials) {} // 0x000000018350B670-0x000000018350B680
		protected virtual Material[] GetMaterials(Material[] mats) => default; // 0x0000000181002730-0x0000000181002740
		protected virtual Material CreateMaterialInstance(Material source) => default; // 0x0000000189D0423C-0x0000000189D042F0
		protected void SetVertexColorGradient(TMP_ColorGradient gradient) {} // 0x0000000189D0C92C-0x0000000189D0C9CC
		protected void SetTextSortingOrder(VertexSortingOrder order) {} // 0x000000018350B670-0x000000018350B680
		protected void SetTextSortingOrder(int[] order) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void SetFaceColor(Color32 color) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void SetOutlineColor(Color32 color) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void SetOutlineThickness(float thickness) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void SetShaderDepth() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void SetCulling() {} // 0x000000018350B670-0x000000018350B680
		internal virtual void UpdateCulling() {} // 0x000000018350B670-0x000000018350B680
		protected virtual float GetPaddingForMaterial() => default; // 0x000000018296AD80-0x000000018296AEE0
		protected virtual float GetPaddingForMaterial(Material mat) => default; // 0x0000000189D07FC8-0x0000000189D080BC
		protected virtual Vector3[] GetTextContainerLocalCorners() => default; // 0x0000000181002730-0x0000000181002740
		public virtual void ForceMeshUpdate(bool ignoreActiveState = false /* Metadata: 0x01FD1C2E */, bool forceTextReparsing = false /* Metadata: 0x01FD1C2F */) {} // 0x000000018350B670-0x000000018350B680
		public virtual void UpdateGeometry(Mesh mesh, int index) {} // 0x000000018350B670-0x000000018350B680
		public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) {} // 0x000000018350B670-0x000000018350B680
		public virtual void UpdateVertexData() {} // 0x000000018350B670-0x000000018350B680
		public virtual void SetVertices(Vector3[] vertices) {} // 0x000000018350B670-0x000000018350B680
		public virtual void UpdateMeshPadding() {} // 0x000000018350B670-0x000000018350B680
		public override void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) {} // 0x00000001838711D0-0x0000000183871260
		public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) {} // 0x0000000189D042F0-0x0000000189D04350
		protected virtual void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) {} // 0x000000018350B670-0x000000018350B680
		protected void ParseInputText() {} // 0x0000000182815D20-0x0000000182815E50
		private void PopulateTextBackingArray(string sourceText) {} // 0x0000000182815F10-0x0000000182815F40
		private void PopulateTextBackingArray(string sourceText, int start, int length) {} // 0x0000000182817820-0x00000001828179D0
		private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length) {} // 0x0000000189D0A660-0x0000000189D0A760
		private void PopulateTextBackingArray(char[] sourceText, int start, int length) {} // 0x0000000189D0A760-0x0000000189D0A85C
		private void PopulateTextProcessingArray() {} // 0x0000000182571E80-0x0000000182572210
		private void SetTextInternal(string sourceText) {} // 0x0000000189D0C3D0-0x0000000189D0C424
		public void SetText(string sourceText, bool syncTextInputBox = true /* Metadata: 0x01FD1C30 */) {} // 0x0000000182CB5860-0x0000000182CB5920
		public void SetText(string sourceText, float arg0) {} // 0x0000000189D0C888-0x0000000189D0C8C4
		public void SetText(string sourceText, float arg0, float arg1) {} // 0x0000000189D0C424-0x0000000189D0C460
		public void SetText(string sourceText, float arg0, float arg1, float arg2) {} // 0x0000000189D0C7F8-0x0000000189D0C83C
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3) {} // 0x0000000189D0C83C-0x0000000189D0C888
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4) {} // 0x0000000189D0C7A0-0x0000000189D0C7F8
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) {} // 0x0000000189D0C6D8-0x0000000189D0C738
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) {} // 0x0000000189D0C738-0x0000000189D0C7A0
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) {} // 0x0000000189D0C48C-0x0000000189D0C6D8
		public void SetText(StringBuilder sourceText) {} // 0x0000000189D0C460-0x0000000189D0C48C
		private void SetText(StringBuilder sourceText, int start, int length) {} // 0x0000000189D0C8D4-0x0000000189D0C92C
		public void SetText(char[] sourceText) {} // 0x0000000189D0C3A8-0x0000000189D0C3D0
		public void SetText(char[] sourceText, int start, int length) {} // 0x0000000189D0C8C4-0x0000000189D0C8D4
		public void SetCharArray(char[] sourceText) {} // 0x0000000189D0C3A8-0x0000000189D0C3D0
		public void SetCharArray(char[] sourceText, int start, int length) {} // 0x0000000189D0C350-0x0000000189D0C3A8
		private TMP_Style GetStyle(int hashCode) => default; // 0x000000018296C5B0-0x000000018296C8B0
		private bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex) {
			srcOffset = default;
			return default;
		} // 0x0000000189D0B084-0x0000000189D0B44C
		private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex) {
			srcOffset = default;
			return default;
		} // 0x0000000189D0B44C-0x0000000189D0B7F4
		private void ReplaceClosingStyleTag(ref TextBackingContainer sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex) {} // 0x0000000189D0A984-0x0000000189D0AD0C
		private void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex) {} // 0x0000000189D0AD0C-0x0000000189D0B084
		private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex) => default; // 0x0000000189D09F68-0x0000000189D0A2E4
		private void InsertClosingStyleTag(ref UnicodeChar[] charBuffer, ref int writeIndex) {} // 0x0000000189D09BEC-0x0000000189D09F68
		private int GetMarkupTagHashCode(int[] tagDefinition, int readIndex) => default; // 0x0000000189D07F14-0x0000000189D07FC8
		private int GetMarkupTagHashCode(TextBackingContainer tagDefinition, int readIndex) => default; // 0x00000001834B63C0-0x00000001834B6480
		private int GetStyleHashCode(ref int[] text, int index, out int closeIndex) {
			closeIndex = default;
			return default;
		} // 0x0000000189D085F4-0x0000000189D086B4
		private int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) {
			closeIndex = default;
			return default;
		} // 0x0000000189D086B4-0x0000000189D0877C
		private void ResizeInternalArray<T>(ref ref T[] array) {}
		private void ResizeInternalArray<T>(ref ref T[] array, int size) {}
		private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex) {} // 0x0000000189D03770-0x0000000189D03A54
		private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex) {} // 0x0000000189D03A54-0x0000000189D03B6C
		private string InternalTextBackingArrayToString() => default; // 0x0000000189D0A2E4-0x0000000189D0A3BC
		protected virtual int SetArraySizes(UnicodeChar[] unicodeChars) => default; // 0x0000000181002730-0x0000000181002740
		public Vector2 GetPreferredValues() => default; // 0x0000000189D083FC-0x0000000189D08450
		public Vector2 GetPreferredValues(float width, float height) => default; // 0x0000000189D08254-0x0000000189D082BC
		public Vector2 GetPreferredValues(string text) => default; // 0x0000000189D082BC-0x0000000189D08384
		public Vector2 GetPreferredValues(string text, float width, float height) => default; // 0x0000000189D08384-0x0000000189D083FC
		protected float GetPreferredWidth() => default; // 0x000000018296AEE0-0x000000018296B070
		private float GetPreferredWidth(Vector2 margin) => default; // 0x0000000189D08450-0x0000000189D084CC
		protected float GetPreferredHeight() => default; // 0x00000001831BE5C0-0x00000001831BE860
		private float GetPreferredHeight(Vector2 margin) => default; // 0x0000000189D081A4-0x0000000189D08254
		public Vector2 GetRenderedValues() => default; // 0x0000000189D08560-0x0000000189D085BC
		public Vector2 GetRenderedValues(bool onlyVisibleCharacters) => default; // 0x0000000189D08504-0x0000000189D08560
		private float GetRenderedWidth() => default; // 0x0000000189D085D8-0x0000000189D085F4
		protected float GetRenderedWidth(bool onlyVisibleCharacters) => default; // 0x0000000189D085BC-0x0000000189D085D8
		private float GetRenderedHeight() => default; // 0x0000000189D084E8-0x0000000189D08504
		protected float GetRenderedHeight(bool onlyVisibleCharacters) => default; // 0x0000000189D084CC-0x0000000189D084E8
		protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled) => default; // 0x000000018296CBA0-0x000000018296ED60
		protected virtual Bounds GetCompoundBounds() => default; // 0x0000000183D595C0-0x0000000183D595D0
		internal virtual Rect GetCanvasSpaceClippingRect() => default; // 0x0000000183D605F0-0x0000000183D60600
		protected Bounds GetTextBounds() => default; // 0x0000000189D08AB4-0x0000000189D08DC4
		protected Bounds GetTextBounds(bool onlyVisibleCharacters) => default; // 0x0000000189D0877C-0x0000000189D08AB4
		protected void AdjustLineOffset(int startIndex, int endIndex, float offset) {} // 0x0000000189D03B6C-0x0000000189D04050
		protected void ResizeLineExtents(int size) {} // 0x0000000189D0B85C-0x0000000189D0BAE4
		public virtual TMP_TextInfo GetTextInfo(string text) => default; // 0x0000000181002730-0x0000000181002740
		public virtual void ComputeMarginSize() {} // 0x000000018350B670-0x000000018350B680
		protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) {} // 0x000000018285D8F0-0x000000018285E2C0
		protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) {} // 0x000000018296B720-0x000000018296C170
		protected int RestoreWordWrappingState(ref WordWrapState state) => default; // 0x000000018314E6F0-0x000000018314EF20
		protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) {} // 0x00000001825745E0-0x0000000182574C70
		protected virtual void SaveSpriteVertexInfo(Color32 vertexColor) {} // 0x0000000189D0BAE4-0x0000000189D0C350
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4) {} // 0x0000000182574C70-0x0000000182575510
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) {} // 0x0000000189D06A48-0x0000000189D07634
		protected virtual void FillSpriteVertexBuffers(int i, int index_X4) {} // 0x0000000189D07634-0x0000000189D07DE4
		protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) {} // 0x0000000189D05B58-0x0000000189D06A48
		protected virtual float PhoneticWidth(string str, int materialIndex, float padding, float style_padding) => default; // 0x0000000189D0A484-0x0000000189D0A660
		protected virtual bool DrawPhoneticMesh(Rect rect, string str, int materialIndex, float padding, float style_padding, bool autoSize, int phoneticIndex, bool justify, float lossyScale) => default; // 0x0000000189D04350-0x0000000189D0567C
		protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) {} // 0x0000000189D0567C-0x0000000189D05B58
		protected void LoadDefaultSettings() {} // 0x0000000182814400-0x0000000182814490
		protected void GetSpecialCharacters(TMP_FontAsset fontAsset) {} // 0x000000018296AD50-0x000000018296AD80
		protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) {} // 0x000000018296A890-0x000000018296AA20
		protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) {} // 0x000000018296ABE0-0x000000018296AD50
		protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) {} // 0x0000000189D0B7F4-0x0000000189D0B84C
		protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) => default; // 0x0000000189D07E90-0x0000000189D07F14
		internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) {
			isUsingAlternativeTypeface = default;
			return default;
		} // 0x0000000182570B30-0x0000000182570D10
		public void TryRemoveDynamicFallbackFontAssetTextRef() {} // 0x000000018239E5F0-0x000000018239E610
		protected virtual void SetActiveSubMeshes(bool state) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void DestroySubMeshObjects() {} // 0x000000018350B670-0x000000018350B680
		public virtual void ClearMesh() {} // 0x000000018350B670-0x000000018350B680
		public virtual void ClearMesh(bool uploadGeometry) {} // 0x000000018350B670-0x000000018350B680
		public virtual string GetParsedText() => default; // 0x0000000189D080BC-0x0000000189D081A4
		internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) => default; // 0x0000000189D0A3BC-0x0000000189D0A484
		internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) {} // 0x0000000189D0A88C-0x0000000189D0A984
		protected Vector2 PackUV(float x, float y, float scale) => default; // 0x0000000183D85040-0x0000000183D85080
		protected float PackUV(float x, float y) => default; // 0x0000000183D85000-0x0000000183D85040
		internal virtual void InternalUpdate() {} // 0x000000018350B670-0x000000018350B680
		protected static int HexToInt(char hex) => default; // 0x00000001830DCFB0-0x00000001830DD050
		protected int GetUTF16(string text, int i) => default; // 0x0000000189D08F8C-0x0000000189D09074
		protected int GetUTF16(int[] text, int i) => default; // 0x0000000189D08EAC-0x0000000189D08F8C
		internal int GetUTF16(uint[] text, int i) => default; // 0x0000000189D0914C-0x0000000189D0922C
		protected int GetUTF16(StringBuilder text, int i) => default; // 0x0000000189D08DC4-0x0000000189D08EAC
		private int GetUTF16(TextBackingContainer text, int i) => default; // 0x0000000189D09074-0x0000000189D0914C
		protected int GetUTF32(string text, int i) => default; // 0x0000000189D0922C-0x0000000189D093A4
		protected int GetUTF32(int[] text, int i) => default; // 0x0000000189D09518-0x0000000189D0968C
		internal int GetUTF32(uint[] text, int i) => default; // 0x0000000189D093A4-0x0000000189D09518
		protected int GetUTF32(StringBuilder text, int i) => default; // 0x0000000189D097EC-0x0000000189D09964
		private int GetUTF32(TextBackingContainer text, int i) => default; // 0x0000000189D0968C-0x0000000189D097EC
		protected static Color32 HexCharsToColor(ReadOnlySpan<char> hexChars, int tagCount) => default; // 0x00000001830DCDA0-0x00000001830DCFB0
		protected static Color32 HexCharsToColor(ReadOnlySpan<char> hexChars, int startIndex, int length) => default; // 0x0000000189D09964-0x0000000189D09BEC
		private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) => default; // 0x0000000189D07DE4-0x0000000189D07E90
		protected float ConvertToFloat(char[] chars, int startIndex, int length) => default; // 0x0000000189D04218-0x0000000189D0423C
		protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) {
			lastIndex = default;
			return default;
		} // 0x0000000189D040D8-0x0000000189D04218
		protected bool CheckIfEndPhonetic(UnicodeChar[] chars, int startIndex) => default; // 0x0000000189D04050-0x0000000189D040D8
		protected bool ValidateHtmlTag(UnicodeChar[] chars, int startIndex, out int endIndex) {
			endIndex = default;
			return default;
		} // 0x00000001830DC0C0-0x00000001830DCDA0
	}

	public enum TextElementType : byte // TypeDefIndex: 52383
	{
		Character = 1,
		Sprite = 2
	}

	[Serializable]
	public class TMP_TextElement // TypeDefIndex: 52384
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
		public TextElementType elementType { get => default; } // 0x00000001811797F0-0x0000000181179800 
		public uint unicode { get => default; set {} } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
		public TMP_Asset textAsset { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public Glyph glyph { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public uint glyphIndex { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public float scale { get => default; set {} } // 0x0000000183D4F3A0-0x0000000183D4F3B0 0x0000000183D4F3B0-0x0000000183D4F3C0
	
		// Constructors
		public TMP_TextElement() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class TMP_TextElement_Legacy // TypeDefIndex: 52385
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
		public TMP_TextElement_Legacy() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class TMP_TextInfo : IDisposable // TypeDefIndex: 52386
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
		public TMP_TextInfo() {} // 0x0000000189D15F90-0x0000000189D16140
		internal TMP_TextInfo(int characterCount) {} // 0x0000000189D16140-0x0000000189D162F8
		public TMP_TextInfo(TMP_Text textComponent) {} // 0x0000000182813D20-0x0000000182813FB0
		static TMP_TextInfo() {} // 0x0000000183D26950-0x0000000183D269B0
	
		// Methods
		public void Clear() {} // 0x00000001830D1390-0x00000001830D13F0
		internal void ClearAllData() {} // 0x0000000189D15748-0x0000000189D15888
		public void ClearMeshInfo(bool updateMesh) {} // 0x0000000189D15908-0x0000000189D15998
		public void ClearAllMeshInfo() {} // 0x0000000189D15888-0x0000000189D15908
		public void ResetVertexLayout(bool isVolumetric) {} // 0x0000000189D15F00-0x0000000189D15F90
		public void ClearUnusedVertices(MaterialReference[] materials) {} // 0x0000000189D15998-0x0000000189D15A18
		public void ClearLineInfo() {} // 0x0000000182574280-0x00000001825745E0
		public void ClearPageInfo() {} // 0x0000000182DF80F0-0x0000000182DF8210
		public TMP_MeshInfo[] CopyMeshInfoVertexData() => default; // 0x0000000189D15A18-0x0000000189D15F00
		public static void Resize<T>(ref ref T[] array, int size) {}
		public static void Resize<T>(ref ref T[] array, int size, bool isBlockAllocated) {}
		public void Dispose() {} // 0x000000018285E2C0-0x000000018285E6A0
	}

	public class TMP_TextParsingUtilities // TypeDefIndex: 52387
	{
		// Fields
		private static readonly TMP_TextParsingUtilities s_Instance; // 0x00
		private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x01FD1C3B
		private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x01FD1CBD
	
		// Properties
		public static TMP_TextParsingUtilities instance { get => default; } // 0x0000000189D1648C-0x0000000189D164DC 
	
		// Constructors
		static TMP_TextParsingUtilities() {} // 0x0000000183D1AC90-0x0000000183D1ACF0
		public TMP_TextParsingUtilities() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static int GetHashCode(string s) => default; // 0x00000001833025E0-0x0000000183302690
		public static int GetHashCodeCaseSensitive(string s) => default; // 0x0000000189D162F8-0x0000000189D1634C
		public static char ToLowerASCIIFast(char c) => default; // 0x0000000189D1637C-0x0000000189D163D4
		public static char ToUpperASCIIFast(char c) => default; // 0x0000000183302690-0x00000001833026F0
		public static uint ToUpperASCIIFast(uint c) => default; // 0x0000000189D16430-0x0000000189D1648C
		public static uint ToLowerASCIIFast(uint c) => default; // 0x0000000189D163D4-0x0000000189D16430
		public static bool IsHighSurrogate(uint c) => default; // 0x0000000189D1634C-0x0000000189D16364
		public static bool IsLowSurrogate(uint c) => default; // 0x0000000189D16364-0x0000000189D1637C
		internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) => default; // 0x0000000183D854A0-0x0000000183D854B0
	}

	public struct TMP_FontStyleStack // TypeDefIndex: 52388
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
		public void Clear() {} // 0x000000018311E3C0-0x000000018311E3D0
		public byte Add(FontStyles style) => default; // 0x0000000189D0F218-0x0000000189D0F2B8
		public byte Remove(FontStyles style) => default; // 0x0000000189D0F2B8-0x0000000189D0F3B4
	}

	[DebuggerDisplay("Item count = {m_Count}")]
	public struct TMP_TextProcessingStack<T> : IDisposable // TypeDefIndex: 52389
	{
		// Fields
		public T[] itemStack;
		public int index;
		private T m_DefaultItem;
		private int m_Capacity;
		private int m_RolloverSize;
		private int m_Count;
		private const int k_DefaultCapacity = 4; // Metadata: 0x01FD1D3F
	
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

	[DebuggerDisplay("Item count = {m_Count}")]
	public struct TMP_TextProcessingQueue<T> : IDisposable // TypeDefIndex: 52390
	{
		// Fields
		public T[] itemQueue;
		private int m_Head;
		private int m_Tail;
		private int m_Capacity;
		private int m_Count;
		private T m_DefaultItem;
		private const int k_DefaultCapacity = 4; // Metadata: 0x01FD1D40
	
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

	public enum CaretPosition // TypeDefIndex: 52391
	{
		None = 0,
		Left = 1,
		Right = 2
	}

	public struct CaretInfo // TypeDefIndex: 52392
	{
		// Fields
		public int index; // 0x00
		public CaretPosition position; // 0x04
	
		// Constructors
		public CaretInfo(int index, CaretPosition position) {
			this.index = default;
			this.position = default;
		} // 0x0000000183D4E4B0-0x0000000183D4E4C0
	}

	public static class TMP_TextUtilities // TypeDefIndex: 52394
	{
		// Fields
		private static Vector3[] m_rectWorldCorners; // 0x00
		private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x01FD1D44
		private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x01FD1DC6
	
		// Nested types
		private struct LineSegment // TypeDefIndex: 52393
		{
			// Fields
			public Vector3 Point1; // 0x00
			public Vector3 Point2; // 0x0C
	
			// Constructors
			public LineSegment(Vector3 p1, Vector3 p2) {
				Point1 = default;
				Point2 = default;
			} // 0x0000000183D4FF30-0x0000000183D4FF50
		}
	
		// Constructors
		static TMP_TextUtilities() {} // 0x0000000183D04E80-0x0000000183D04EF0
	
		// Methods
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera) => default; // 0x0000000189D1982C-0x0000000189D199E0
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor) {
			cursor = default;
			return default;
		} // 0x0000000189D199E0-0x0000000189D19C20
		public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera) => default; // 0x0000000189D180E0-0x0000000189D182DC
		public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly) => default; // 0x0000000189D177F8-0x0000000189D17C94
		public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera) => default; // 0x0000000189D1A05C-0x0000000189D1A244
		public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) => default; // 0x0000000189D166B4-0x0000000189D16984
		public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) => default; // 0x0000000189D17C94-0x0000000189D180E0
		public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera) => default; // 0x0000000189D170D4-0x0000000189D177F8
		public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera) => default; // 0x0000000189D18D80-0x0000000189D1982C
		public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera) => default; // 0x0000000189D16984-0x0000000189D16B14
		public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera) => default; // 0x0000000189D16B14-0x0000000189D170D4
		public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera) => default; // 0x0000000189D182DC-0x0000000189D18D80
		private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) => default; // 0x0000000189D1A244-0x0000000189D1A410
		public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) {
			worldPoint = default;
			return default;
		} // 0x0000000189D1A410-0x0000000189D1A5D4
		private static bool IntersectLinePlane(LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint) {
			intersectingPoint = default;
			return default;
		} // 0x0000000189D19E38-0x0000000189D1A05C
		public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) => default; // 0x0000000189D164DC-0x0000000189D166B4
		public static char ToLowerFast(char c) => default; // 0x0000000189D1A684-0x0000000189D1A6DC
		public static char ToUpperFast(char c) => default; // 0x0000000189D1A6DC-0x0000000189D1A734
		internal static uint ToUpperASCIIFast(uint c) => default; // 0x00000001834B6480-0x00000001834B64E0
		public static int GetHashCode(string s) => default; // 0x0000000189D19C20-0x0000000189D19CB0
		public static int GetSimpleHashCode(string s) => default; // 0x0000000182EE8BD0-0x0000000182EE8C30
		public static uint GetSimpleHashCodeLowercase(string s) => default; // 0x0000000189D19CB0-0x0000000189D19D44
		public static int HexToInt(char hex) => default; // 0x0000000189D19D44-0x0000000189D19E38
		public static int StringHexToInt(string s) => default; // 0x0000000189D1A5D4-0x0000000189D1A684
		public static bool IsThaiZeroWidthCharacter(char c) => default; // 0x0000000182C9DF30-0x0000000182C9DFE0
		public static bool IsUpVowel(char c) => default; // 0x0000000182C9E040-0x0000000182C9E070
		public static bool IsLowVowel(char c) => default; // 0x0000000182C9DFE0-0x0000000182C9E010
		public static bool IsToneMark(char c) => default; // 0x0000000182C9E010-0x0000000182C9E040
		public static bool IsAscenderThai(char c) => default; // 0x0000000182EE9BD0-0x0000000182EE9C00
		public static bool IsDescenderThai(char c) => default; // 0x0000000183009330-0x0000000183009350
	}

	public class TMP_UpdateManager // TypeDefIndex: 52395
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
		private static TMP_UpdateManager instance { get => default; } // 0x00000001823A0100-0x00000001823A0200 
	
		// Constructors
		private TMP_UpdateManager() {} // 0x0000000182CD0370-0x0000000182CD05B0
		static TMP_UpdateManager() {} // 0x0000000183B1D820-0x0000000183B1D970
	
		// Methods
		internal static void RegisterTextObjectForUpdate(TMP_Text textObject) {} // 0x000000018239FC70-0x000000018239FCE0
		private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) {} // 0x000000018239FB50-0x000000018239FC70
		public static void RegisterTextElementForLayoutRebuild(TMP_Text element) {} // 0x0000000189D1B784-0x0000000189D1B7DC
		private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element) {} // 0x0000000189D1B540-0x0000000189D1B5FC
		public static void RegisterTextElementForGraphicRebuild(TMP_Text element) {} // 0x0000000189D1B72C-0x0000000189D1B784
		private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element) {} // 0x0000000189D1B484-0x0000000189D1B540
		public static void RegisterTextElementForCullingUpdate(TMP_Text element) {} // 0x00000001830D1570-0x00000001830D15E0
		private void InternalRegisterTextElementForCullingUpdate(TMP_Text element) {} // 0x00000001830D15E0-0x00000001830D16A0
		private void OnCameraPreCull() {} // 0x0000000189D1B724-0x0000000189D1B72C
		private void DoRebuilds() {} // 0x0000000182343120-0x00000001823432D0
		internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) {} // 0x00000001823A0090-0x00000001823A0100
		public static void UnRegisterTextElementForRebuild(TMP_Text element) {} // 0x0000000189D1B7DC-0x0000000189D1B868
		private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) {} // 0x0000000189D1B5FC-0x0000000189D1B690
		private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) {} // 0x0000000189D1B690-0x0000000189D1B724
		private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject) {} // 0x00000001823A0200-0x00000001823A02A0
	}

	public class TMP_UpdateRegistry // TypeDefIndex: 52396
	{
		// Fields
		private static TMP_UpdateRegistry s_Instance; // 0x00
		private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
		private HashSet<int> m_LayoutQueueLookup; // 0x18
		private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
		private HashSet<int> m_GraphicQueueLookup; // 0x28
	
		// Properties
		public static TMP_UpdateRegistry instance { get => default; } // 0x0000000189D1BFA4-0x0000000189D1DF24 
	
		// Constructors
		protected TMP_UpdateRegistry() {} // 0x0000000189D1BE30-0x0000000189D1BFA4
	
		// Methods
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) {} // 0x0000000189D1BDB8-0x0000000189D1BDE8
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) => default; // 0x0000000189D1B954-0x0000000189D1BA40
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) {} // 0x0000000189D1BD88-0x0000000189D1BDB8
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) => default; // 0x0000000189D1B868-0x0000000189D1B954
		private void PerformUpdateForCanvasRendererObjects() {} // 0x0000000189D1BBD0-0x0000000189D1BD34
		private void PerformUpdateForMeshRendererObjects() {} // 0x0000000189D1BD34-0x0000000189D1BD88
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) {} // 0x0000000189D1BDE8-0x0000000189D1BE30
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) {} // 0x0000000189D1BB08-0x0000000189D1BBD0
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) {} // 0x0000000189D1BA40-0x0000000189D1BB08
	}
}

namespace TMPro.SpriteAssetUtilities
{
	public enum SpriteAssetImportFormats // TypeDefIndex: 52397
	{
		None = 0,
		TexturePackerJsonArray = 1
	}

	public class TexturePacker_JsonArray // TypeDefIndex: 52403
	{
		// Nested types
		[Serializable]
		public struct SpriteFrame // TypeDefIndex: 52398
		{
			// Fields
			public float x; // 0x00
			public float y; // 0x04
			public float w; // 0x08
			public float h; // 0x0C
	
			// Methods
			public override string ToString() => default; // 0x0000000189D1B280-0x0000000189D1B3F0
		}
	
		[Serializable]
		public struct SpriteSize // TypeDefIndex: 52399
		{
			// Fields
			public float w; // 0x00
			public float h; // 0x04
	
			// Methods
			public override string ToString() => default; // 0x0000000189D1B3F0-0x0000000189D1B484
		}
	
		[Serializable]
		public struct Frame // TypeDefIndex: 52400
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
		public struct Meta // TypeDefIndex: 52401
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
		public class SpriteDataObject // TypeDefIndex: 52402
		{
			// Fields
			public List<Frame> frames; // 0x10
			public Meta meta; // 0x18
	
			// Constructors
			public SpriteDataObject() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public TexturePacker_JsonArray() {} // 0x000000018350B670-0x000000018350B680
	}
}
