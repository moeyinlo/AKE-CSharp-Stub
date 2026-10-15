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

// Image 26: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 82302-82490

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 82490
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB; // 0x00 // Static value (base64): IAAuACwACQANAAoA - Metadata: 0x02641180

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 82489
	{
	}
}

namespace TMPro
{
	public class FastAction // TypeDefIndex: 82303
	{
		// Fields
		private LinkedList<Action> delegates; // 0x10
		private Dictionary<Action, LinkedListNode<Action>> lookup; // 0x18
	
		// Constructors
		public FastAction(); // 0x0000000186C22520-0x0000000186C225D0
	
		// Methods
		public void Add(Action rhs); // 0x000000018D411A24-0x000000018D411AD8
		public void Remove(Action rhs); // 0x000000018D411B58-0x000000018D411C0C
		public void Call(); // 0x000000018D411AD8-0x000000018D411B58
	}

	public class FastAction<A> // TypeDefIndex: 82304
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

	public class FastAction<A, B> // TypeDefIndex: 82305
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

	public class FastAction<A, B, C> // TypeDefIndex: 82306
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

	public interface IFontAssetLoader // TypeDefIndex: 82307
	{
		// Methods
		bool TryGetFontAsset(TMP_Text refText, uint unicode, out TMP_FontAsset fontAsset);
		void TryRemoveRefText(TMP_Text refText);
	}

	public interface ITextPreprocessor // TypeDefIndex: 82308
	{
		// Methods
		string PreprocessText(string text);
	}

	public class LocalizedTextPreprocessor : ITextPreprocessor // TypeDefIndex: 82309
	{
		// Fields
		private static LocalizedTextPreprocessor _instance; // 0x00
	
		// Properties
		public static LocalizedTextPreprocessor Instance { get; } // 0x000000018D411C0C-0x000000018D411C5C 
	
		// Constructors
		public LocalizedTextPreprocessor(); // 0x0000000186805BA0-0x0000000186805BB0
		static LocalizedTextPreprocessor(); // 0x00000001871E7DC0-0x00000001871E7E20
	
		// Methods
		public string PreprocessText(string text); // 0x00000001852D2160-0x00000001852D21F0
	}

	public class MaterialReferenceManager // TypeDefIndex: 82310
	{
		// Fields
		private static MaterialReferenceManager s_Instance; // 0x00
		private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
		private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
		private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
		private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x28
	
		// Properties
		public static MaterialReferenceManager instance { get; } // 0x000000018D412550-0x000000018D4125E0 
	
		// Constructors
		public MaterialReferenceManager(); // 0x000000018D4123F8-0x000000018D412550
	
		// Methods
		public static void AddFontAsset(TMP_FontAsset fontAsset); // 0x000000018D411DD4-0x000000018D411E04
		private void AddFontAssetInternal(TMP_FontAsset fontAsset); // 0x000000018D411D24-0x000000018D411DD4
		public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset); // 0x000000018D412014-0x000000018D412044
		private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset); // 0x000000018D411EA4-0x000000018D411F54
		public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset); // 0x000000018D412044-0x000000018D412080
		private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset); // 0x000000018D411F54-0x000000018D412014
		public static void AddFontMaterial(int hashCode, Material material); // 0x000000018D411E68-0x000000018D411EA4
		private void AddFontMaterialInternal(int hashCode, Material material); // 0x000000018D411E04-0x000000018D411E68
		public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset); // 0x000000018D411CE8-0x000000018D411D24
		private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset); // 0x000000018D411C5C-0x000000018D411CE8
		public bool Contains(TMP_FontAsset font); // 0x000000018D412080-0x000000018D4120DC
		public bool Contains(TMP_SpriteAsset sprite); // 0x000000018D4120DC-0x000000018D412138
		public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset); // 0x000000018D41225C-0x000000018D412298
		private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset); // 0x000000018D4121E8-0x000000018D41225C
		public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset); // 0x000000018D4123BC-0x000000018D4123F8
		private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset); // 0x000000018D412348-0x000000018D4123BC
		public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset); // 0x000000018D4121AC-0x000000018D4121E8
		private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset); // 0x000000018D412138-0x000000018D4121AC
		public static bool TryGetMaterial(int hashCode, out Material material); // 0x000000018D41230C-0x000000018D412348
		private bool TryGetMaterialInternal(int hashCode, out Material material); // 0x000000018D412298-0x000000018D41230C
	}

	public struct TMP_MaterialReference // TypeDefIndex: 82311
	{
		// Fields
		public Material material; // 0x00
		public int referenceCount; // 0x08
	}

	public struct MaterialReference // TypeDefIndex: 82312
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
		public MaterialReference(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding); // 0x00000001857E8230-0x00000001857E8400
	
		// Methods
		public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset); // 0x000000018D4127D0-0x000000018D412898
		public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup); // 0x00000001852D3180-0x00000001852D35C0
		public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup); // 0x000000018D4125E0-0x000000018D4127D0
	}

	public enum TextContainerAnchors // TypeDefIndex: 82313
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
	public class TextContainer : UIBehaviour // TypeDefIndex: 82314
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
		public bool hasChanged { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public Vector2 pivot { get; set; } // 0x000000018725EF60-0x000000018725EF80 0x000000018D4131CC-0x000000018D41323C
		public TextContainerAnchors anchorPosition { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x000000018D4130EC-0x000000018D413134
		public Rect rect { get; set; } // 0x000000018723D770-0x000000018723D780 0x000000018D41323C-0x000000018D413294
		public Vector2 size { get; set; } // 0x000000018725EF80-0x000000018725EFA0 0x000000018D413294-0x000000018D4132F4
		public float width { get; set; } // 0x000000018725EFA0-0x000000018725EFB0 0x000000018D4132F4-0x000000018D41333C
		public float height { get; set; } // 0x000000018783AB70-0x000000018783AB78 0x000000018D413134-0x000000018D41317C
		public bool isDefaultWidth { get; } // 0x000000018225E070-0x000000018225E080 
		public bool isDefaultHeight { get; } // 0x000000018226ED20-0x000000018226ED30 
		public bool isAutoFitting { get; set; } // 0x0000000187233610-0x0000000187233620 0x0000000187233640-0x0000000187233650
		public Vector3[] corners { get; } // 0x000000018226EEA0-0x000000018226EEB0 
		public Vector3[] worldCorners { get; } // 0x000000018226EE80-0x000000018226EE90 
		public Vector4 margins { get; set; } // 0x0000000187239B00-0x0000000187239B10 0x000000018D41317C-0x000000018D4131CC
		public RectTransform rectTransform { get; } // 0x000000018D412FE4-0x000000018D413068 
		public TextMeshPro textMeshPro { get; } // 0x000000018D413068-0x000000018D4130EC 
	
		// Constructors
		public TextContainer(); // 0x000000018D412F6C-0x000000018D412FE4
		static TextContainer(); // 0x000000018D412F2C-0x000000018D412F6C
	
		// Methods
		protected override void Awake(); // 0x000000018D412898-0x000000018D412938
		protected override void OnEnable(); // 0x000000018D412C0C-0x000000018D412C14
		protected override void OnDisable(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnContainerChanged(); // 0x000000018D412B10-0x000000018D412C0C
		protected override void OnRectTransformDimensionsChange(); // 0x000000018D412C14-0x000000018D412D6C
		private void SetRect(Vector2 size); // 0x000000018725EF10-0x000000018725EF60
		private void UpdateCorners(); // 0x000000018D412D6C-0x000000018D412F2C
		private Vector2 GetPivot(TextContainerAnchors anchor); // 0x000000018D412A84-0x000000018D412B10
		private TextContainerAnchors GetAnchorPosition(Vector2 pivot); // 0x000000018D412938-0x000000018D412A84
	}

	[AddComponentMenu("Mesh/TextMeshPro - Text")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.0")]
	[RequireComponent(typeof(MeshRenderer))]
	public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 82315
	{
		// Fields
		[SerializeField]
		internal int _SortingLayer; // 0xB08
		[SerializeField]
		internal int _SortingLayerID; // 0xB0C
		[SerializeField]
		internal int _SortingOrder; // 0xB10
		[CompilerGenerated]
		private Action<TMP_TextInfo> OnPreRenderText; // 0xB18
		private bool m_currentAutoSizeMode; // 0xB20
		[SerializeField]
		private bool m_hasFontAssetChanged; // 0xB21
		private float m_previousLossyScaleY; // 0xB24
		[SerializeField]
		private Renderer m_renderer; // 0xB28
		private MeshFilter m_meshFilter; // 0xB30
		private bool m_isFirstAllocation; // 0xB38
		private int m_max_characters; // 0xB3C
		private int m_max_numberOfLines; // 0xB40
		private TMP_SubMesh[] m_subTextObjects; // 0xB48
		[SerializeField]
		private MaskingTypes m_maskType; // 0xB50
		private Matrix4x4 m_EnvMapMatrix; // 0xB54
		private Vector3[] m_RectTransformCorners; // 0xB98
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0xBA0
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
		public int sortingLayerID { get; set; } // 0x000000018D41C318-0x000000018D41C394 0x000000018D41C5B0-0x000000018D41C64C
		public int sortingOrder { get; set; } // 0x000000018D41C394-0x000000018D41C410 0x000000018D41C64C-0x000000018D41C738
		public override bool autoSizeTextContainer { get; set; } // 0x000000018725EFB0-0x000000018725EFC0 0x000000018D41C530-0x000000018D41C5A0
		[Obsolete("The TextContainer is now obsolete. Use the RectTransform instead.")]
		public TextContainer textContainer { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public new Transform transform { get; } // 0x000000018D41C410-0x000000018D41C4A0 
		public Renderer renderer { get; } // 0x000000018D41C288-0x000000018D41C318 
		public override Mesh mesh { get; } // 0x000000018D41C1CC-0x000000018D41C288 
		public MeshFilter meshFilter { get; } // 0x000000018D41C0BC-0x000000018D41C1CC 
		public MaskingTypes maskType { get; set; } // 0x000000018725EFE0-0x000000018725EFF0 0x000000018D41C5A0-0x000000018D41C5B0
	
		// Events
		public override event Action<TMP_TextInfo> OnPreRenderText {
			add; // 0x000000018D41C02C-0x000000018D41C0BC
			remove; // 0x000000018D41C4A0-0x000000018D41C530
		}
	
		// Constructors
		public TextMeshPro(); // 0x000000018D41BF70-0x000000018D41C02C
		static TextMeshPro(); // 0x000000018D41BAF4-0x000000018D41BF70
	
		// Methods
		public void SetMask(MaskingTypes type, Vector4 maskCoords); // 0x000000018D41A1BC-0x000000018D41A1F8
		public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY); // 0x000000018D41A380-0x000000018D41A3DC
		public override void SetVerticesDirty(); // 0x000000018D41AE20-0x000000018D41AE9C
		public override void SetLayoutDirty(); // 0x000000018D419F90-0x000000018D41A038
		public override void SetMaterialDirty(); // 0x000000018CB260F0-0x000000018CB26100
		public override void SetAllDirty(); // 0x0000000186203140-0x0000000186203180
		public override void Rebuild(CanvasUpdate update); // 0x000000018D417668-0x000000018D41772C
		protected override void UpdateMaterial(); // 0x000000018D41B16C-0x000000018D41B28C
		public override void UpdateMeshPadding(); // 0x000000018D41B28C-0x000000018D41B398
		public override void ForceMeshUpdate(bool ignoreActiveState = false /* Metadata: 0x02640BF2 */, bool forceTextReparsing = false /* Metadata: 0x02640BF3 */); // 0x000000018D415F74-0x000000018D415F88
		public override TMP_TextInfo GetTextInfo(string text); // 0x000000018D416824-0x000000018D416880
		public override void ClearMesh(bool updateMesh); // 0x000000018D415984-0x000000018D415A6C
		public override void UpdateGeometry(Mesh mesh, int index); // 0x000000018D41B0DC-0x000000018D41B100
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x000000018D41B730-0x000000018D41B908
		public override void UpdateVertexData(); // 0x000000018D41B908-0x000000018D41BAF4
		public void UpdateFontAsset(); // 0x000000018D414D24-0x000000018D414D34
		public void CalculateLayoutInputHorizontal(); // 0x0000000186805BA0-0x0000000186805BB0
		public void CalculateLayoutInputVertical(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void Awake(); // 0x000000018D415544-0x000000018D415984
		protected override void OnEnable(); // 0x000000018D417170-0x000000018D417250
		protected override void OnDisable(); // 0x000000018D4170D4-0x000000018D417170
		protected override void OnDestroy(); // 0x000000018D417010-0x000000018D4170B8
		protected override void LoadFontAsset(); // 0x000000018D416938-0x000000018D417010
		private void UpdateEnvMapMatrix(); // 0x000000018D41AE9C-0x000000018D41B0DC
		private void SetMask(MaskingTypes maskType); // 0x000000018D41A1F8-0x000000018D41A380
		private void SetMaskCoordinates(Vector4 coords); // 0x000000018D41A138-0x000000018D41A1BC
		private void SetMaskCoordinates(Vector4 coords, float softX, float softY); // 0x000000018D41A038-0x000000018D41A138
		private void EnableMasking(); // 0x000000018D415E58-0x000000018D415F74
		private void DisableMasking(); // 0x000000018D415D3C-0x000000018D415E58
		private void UpdateMask(); // 0x000000018D41B100-0x000000018D41B16C
		protected override Material GetMaterial(Material mat); // 0x000000018D41633C-0x000000018D416448
		protected override Material[] GetMaterials(Material[] mats); // 0x000000018D416448-0x000000018D416600
		protected override void SetSharedMaterial(Material mat); // 0x000000018D414654-0x000000018D414694
		protected override Material[] GetSharedMaterials(); // 0x000000018D416600-0x000000018D416784
		protected override void SetSharedMaterials(Material[] materials); // 0x000000018D41AA9C-0x000000018D41AE20
		protected override void SetOutlineThickness(float thickness); // 0x000000018D41A70C-0x000000018D41A87C
		protected override void SetFaceColor(Color32 color); // 0x000000018D419E48-0x000000018D419F90
		protected override void SetOutlineColor(Color32 color); // 0x000000018D41A5C4-0x000000018D41A70C
		private void CreateMaterialInstance(); // 0x000000018D415B9C-0x000000018D415C74
		protected override void SetShaderDepth(); // 0x000000018D41A91C-0x000000018D41AA9C
		protected override void SetCulling(); // 0x000000018D419AF0-0x000000018D419E48
		private void SetPerspectiveCorrection(); // 0x000000018D41A87C-0x000000018D41A91C
		protected override int SetArraySizes(UnicodeChar[] unicodeChars); // 0x000000018D417940-0x000000018D419AF0
		public override void ComputeMarginSize(); // 0x000000018D415A6C-0x000000018D415B9C
		protected override void OnDidApplyAnimationProperties(); // 0x000000018D4170B8-0x000000018D4170D4
		protected override void OnTransformParentChanged(); // 0x000000018D417640-0x000000018D417668
		protected override void OnRectTransformDimensionsChange(); // 0x000000018D4174C0-0x000000018D417640
		internal override void InternalUpdate(); // 0x000000018D416880-0x000000018D416938
		private void OnPreRenderObject(); // 0x000000018D417250-0x000000018D4174C0
		protected virtual void GenerateTextMesh(); // 0x000000018D405EEC-0x000000018D411A24
		protected override Vector3[] GetTextContainerLocalCorners(); // 0x000000018D416784-0x000000018D416824
		private void SetMeshFilters(bool state); // 0x000000018D41A3DC-0x000000018D41A5C4
		protected override void SetActiveSubMeshes(bool state); // 0x000000018D41772C-0x000000018D417828
		protected void SetActiveSubTextObjectRenderers(bool state); // 0x000000018D417828-0x000000018D417940
		protected override void DestroySubMeshObjects(); // 0x000000018D415C74-0x000000018D415D3C
		internal void UpdateSubMeshSortingLayerID(int id); // 0x000000018D41B538-0x000000018D41B634
		internal void UpdateSubMeshSortingOrder(int order); // 0x000000018D41B634-0x000000018D41B730
		protected override Bounds GetCompoundBounds(); // 0x000000018D415F88-0x000000018D41633C
		private void UpdateSDFScale(float scaleDelta); // 0x000000018D41B398-0x000000018D41B538
	}

	[AddComponentMenu("UI/TextMeshPro - Text (UI)", 11)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.0")]
	[RequireComponent(typeof(CanvasRenderer))]
	[RequireComponent(typeof(RectTransform))]
	public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 82318
	{
		// Fields
		private bool m_isRebuildingLayout; // 0xB08
		private Coroutine m_DelayedGraphicRebuild; // 0xB10
		private Coroutine m_DelayedMaterialRebuild; // 0xB18
		private Rect m_ClipRect; // 0xB20
		private bool m_ValidRect; // 0xB30
		[CompilerGenerated]
		private Action<TMP_TextInfo> OnPreRenderText; // 0xB38
		[SerializeField]
		private bool m_hasFontAssetChanged; // 0xB40
		protected TMP_SubMeshUI[] m_subTextObjects; // 0xB48
		protected Vector3[] m_RectTransformCorners; // 0xB50
		protected CanvasRenderer m_canvasRenderer; // 0xB58
		protected Canvas m_canvas; // 0xB60
		protected float m_CanvasScaleFactor; // 0xB68
		protected float m_previousLossyScaleY; // 0xB6C
		private bool m_isFirstAllocation; // 0xB70
		private int m_max_characters; // 0xB74
		[SerializeField]
		private Material m_baseMaterial; // 0xB78
		private bool m_isScrollRegionSet; // 0xB80
		[SerializeField]
		private Vector4 m_maskOffset; // 0xB84
		private Matrix4x4 m_EnvMapMatrix; // 0xB94
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0xBD4
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
		public override Material materialForRendering { get; } // 0x00000001852E0CD0-0x00000001852E0D20 
		public override bool autoSizeTextContainer { get; set; } // 0x000000018725EFB0-0x000000018725EFC0 0x000000018D4154AC-0x000000018D41551C
		public override Mesh mesh { get; } // 0x000000018725EFD0-0x000000018725EFE0 
		public new CanvasRenderer canvasRenderer { get; } // 0x0000000185FFC0F0-0x0000000185FFC1A0 
		public Vector4 maskOffset { get; set; } // 0x000000018725EFC0-0x000000018725EFD0 0x000000018D41551C-0x000000018D415544
	
		// Events
		public override event Action<TMP_TextInfo> OnPreRenderText {
			add; // 0x000000018527D980-0x000000018527DBF0
			remove; // 0x000000018527DBF0-0x000000018527DE50
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DelayedGraphicRebuild_d__18 : IEnumerator<object> // TypeDefIndex: 82316
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TextMeshProUGUI __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _DelayedGraphicRebuild_d__18(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D42B0D8-0x000000018D42B190
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D42B190-0x000000018D42B1DC
		}
	
		[CompilerGenerated]
		private sealed class _DelayedMaterialRebuild_d__19 : IEnumerator<object> // TypeDefIndex: 82317
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TextMeshProUGUI __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _DelayedMaterialRebuild_d__19(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D42B1DC-0x000000018D42B29C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D42B29C-0x000000018D42B2E8
		}
	
		// Constructors
		public TextMeshProUGUI(); // 0x000000018548EA40-0x000000018548EB60
		static TextMeshProUGUI(); // 0x0000000186C5AEF0-0x0000000186C5B3C0
	
		// Methods
		public void CalculateLayoutInputHorizontal(); // 0x0000000186805BA0-0x0000000186805BB0
		public void CalculateLayoutInputVertical(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetVerticesDirty(); // 0x0000000185D2C9B0-0x0000000185D2CCE0
		public override void SetLayoutDirty(); // 0x000000018569F9E0-0x000000018569FB50
		public override void SetMaterialDirty(); // 0x0000000185D2C690-0x0000000185D2C9B0
		public override void SetAllDirty(); // 0x0000000186203140-0x0000000186203180
		[IteratorStateMachine(typeof(_DelayedGraphicRebuild_d__18))]
		private IEnumerator DelayedGraphicRebuild(); // 0x000000018D413380-0x000000018D4133DC
		[IteratorStateMachine(typeof(_DelayedMaterialRebuild_d__19))]
		private IEnumerator DelayedMaterialRebuild(); // 0x000000018D4133DC-0x000000018D413438
		public override void Rebuild(CanvasUpdate update); // 0x00000001851C1290-0x00000001851C1340
		private void UpdateSubObjectPivot(); // 0x000000018569E860-0x000000018569E950
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x00000001852E0D20-0x00000001852E0E60
		protected override void UpdateMaterial(); // 0x0000000185FFBEB0-0x0000000185FFC0F0
		public override void RecalculateClipping(); // 0x00000001851BFD90-0x00000001851BFDA0
		public override void Cull(Rect clipRect, bool validRect); // 0x0000000185146A80-0x0000000185146E10
		internal override void UpdateCulling(); // 0x0000000185AF8250-0x0000000185AF8540
		public override void UpdateMeshPadding(); // 0x000000018D415168-0x000000018D415274
		protected override void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x0000000186D246A0-0x0000000186D24700
		protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x000000018D413C48-0x000000018D413D08
		public override void ForceMeshUpdate(bool ignoreActiveState = false /* Metadata: 0x02640BF4 */, bool forceTextReparsing = false /* Metadata: 0x02640BF5 */); // 0x0000000186ACC830-0x0000000186ACC8F0
		public override TMP_TextInfo GetTextInfo(string text); // 0x000000018D413B78-0x000000018D413C48
		public override void ClearMesh(); // 0x00000001864947C0-0x0000000186494890
		public override void UpdateGeometry(Mesh mesh, int index); // 0x00000001868045A0-0x0000000186804600
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x0000000185CD0440-0x0000000185CD05B0
		public override void UpdateVertexData(); // 0x000000018D415274-0x000000018D4154AC
		public void UpdateFontAsset(); // 0x000000018D414D24-0x000000018D414D34
		protected override void Awake(); // 0x00000001852F1780-0x00000001852F1CF0
		protected override void OnEnable(); // 0x00000001852EA760-0x00000001852EA9A0
		protected override void OnDisable(); // 0x00000001852ECC00-0x00000001852ECED0
		protected override void OnDestroy(); // 0x00000001852EE510-0x00000001852EE700
		protected override void LoadFontAsset(); // 0x00000001857E8550-0x00000001857E8C00
		private Canvas GetCanvas(); // 0x00000001852EA9A0-0x00000001852EAAF0
		private void UpdateEnvMapMatrix(); // 0x000000018D414AE4-0x000000018D414D24
		private void EnableMasking(); // 0x000000018D413500-0x000000018D413704
		private void DisableMasking(); // 0x0000000186805BA0-0x0000000186805BB0
		private void UpdateMask(); // 0x000000018D414D34-0x000000018D415168
		protected override Material GetMaterial(Material mat); // 0x000000018D413704-0x000000018D413834
		protected override Material[] GetMaterials(Material[] mats); // 0x000000018D413834-0x000000018D4139EC
		protected override void SetSharedMaterial(Material mat); // 0x000000018D414654-0x000000018D414694
		protected override Material[] GetSharedMaterials(); // 0x000000018D4139EC-0x000000018D413B78
		protected override void SetSharedMaterials(Material[] materials); // 0x000000018D414694-0x000000018D414AE4
		protected override void SetOutlineThickness(float thickness); // 0x000000018D4142B8-0x000000018D414490
		protected override void SetFaceColor(Color32 color); // 0x000000018D413FCC-0x000000018D4140E8
		protected override void SetOutlineColor(Color32 color); // 0x000000018D41419C-0x000000018D4142B8
		protected override void SetShaderDepth(); // 0x000000018D414530-0x000000018D414654
		protected override void SetCulling(); // 0x000000018D413D08-0x000000018D413FCC
		private void SetPerspectiveCorrection(); // 0x000000018D414490-0x000000018D414530
		private void SetMeshArrays(int size); // 0x000000018D4140E8-0x000000018D41419C
		protected override int SetArraySizes(UnicodeChar[] unicodeChars); // 0x00000001852D4BA0-0x00000001852D7B70
		public override void ComputeMarginSize(); // 0x000000018569F690-0x000000018569F9E0
		protected override void OnDidApplyAnimationProperties(); // 0x0000000186352C30-0x0000000186352C60
		protected override void OnCanvasHierarchyChanged(); // 0x0000000185B08410-0x0000000185B087C0
		protected override void OnTransformParentChanged(); // 0x00000001861D2EB0-0x00000001861D2F00
		protected override void OnRectTransformDimensionsChange(); // 0x000000018569E2F0-0x000000018569E7B0
		internal override void InternalUpdate(); // 0x00000001850268F0-0x00000001850269D0
		private void OnPreRenderCanvas(); // 0x00000001851C0890-0x00000001851C0FC0
		protected virtual TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference); // 0x000000018D41333C-0x000000018D413380
		protected virtual void GenerateTextMesh(); // 0x00000001850E0620-0x00000001850EFEC0
		protected override Vector3[] GetTextContainerLocalCorners(); // 0x000000018605B070-0x000000018605B140
		protected override void SetActiveSubMeshes(bool state); // 0x0000000186010510-0x0000000186010650
		protected override void DestroySubMeshObjects(); // 0x000000018D413438-0x000000018D413500
		protected override Bounds GetCompoundBounds(); // 0x00000001851473D0-0x0000000185147990
		internal override Rect GetCanvasSpaceClippingRect(); // 0x0000000185146E10-0x00000001851472C0
		private void UpdateSDFScale(float scaleDelta); // 0x00000001856BF060-0x00000001856BF300
	}

	public enum Compute_DistanceTransform_EventTypes // TypeDefIndex: 82319
	{
		Processing = 0,
		Completed = 1
	}

	public static class TMPro_EventManager // TypeDefIndex: 82320
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
		static TMPro_EventManager(); // 0x0000000186C220A0-0x0000000186C22520
	
		// Methods
		public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat); // 0x000000018D42A5B0-0x000000018D42A630
		public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj); // 0x000000018D42A530-0x000000018D42A5B0
		public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj); // 0x000000018D42A684-0x000000018D42A704
		public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj); // 0x000000018D42A704-0x000000018D42A784
		public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial); // 0x000000018D42A49C-0x000000018D42A530
		public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged); // 0x000000018D42A804-0x000000018D42A870
		public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(UnityEngine.Object obj); // 0x000000018D42A3B0-0x000000018D42A420
		public static void ON_TEXT_CHANGED(UnityEngine.Object obj); // 0x00000001861B15D0-0x00000001861B1720
		public static void ON_TMP_SETTINGS_CHANGED(); // 0x000000018D42A870-0x000000018D42A8C4
		public static void ON_RESOURCES_LOADED(); // 0x000000018D42A630-0x000000018D42A684
		public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj); // 0x000000018D42A784-0x000000018D42A804
		public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e); // 0x000000018D42A420-0x000000018D42A49C
	}

	public class Compute_DT_EventArgs // TypeDefIndex: 82321
	{
		// Fields
		public Compute_DistanceTransform_EventTypes EventType; // 0x10
		public float ProgressPercentage; // 0x14
		public UnityEngine.Color[] Colors; // 0x18
	
		// Constructors
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress); // 0x000000018725EFF0-0x000000018725F000
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, UnityEngine.Color[] colors); // 0x0000000185CF10D0-0x0000000185CF1300
	}

	public static class TMPro_ExtensionMethods // TypeDefIndex: 82322
	{
		// Extension methods
		public static int[] ToIntArray(this string text); // 0x000000018D42AE88-0x000000018D42AF28
		public static string ArrayToString(this char[] chars); // 0x000000018D42A8C4-0x000000018D42A99C
		public static string IntToString(this int[] unicodes); // 0x000000018D42AB20-0x000000018D42ABA8
		internal static string UintToString(this List<uint> unicodes); // 0x000000018D42AF28-0x000000018D42AFE8
		public static string IntToString(this int[] unicodes, int start, int length); // 0x000000018D42ABA8-0x000000018D42AC98
		public static int FindInstanceID<T>(this List<T> list, T target)
			where T : UnityEngine.Object;
		public static bool Compare(this Color32 a, Color32 b); // 0x0000000186BABA20-0x0000000186BABA60
		public static bool CompareRGB(this Color32 a, Color32 b); // 0x000000018D42A99C-0x000000018D42A9C0
		public static bool Compare(this UnityEngine.Color a, UnityEngine.Color b); // 0x00000001862F2760-0x00000001862F27A0
		public static bool CompareRGB(this UnityEngine.Color a, UnityEngine.Color b); // 0x00000001855780F0-0x0000000185578120
		public static Color32 Multiply(this Color32 c1, Color32 c2); // 0x000000018D42ACC8-0x000000018D42ADA8
		public static Color32 Tint(this Color32 c1, Color32 c2); // 0x000000018D42ACC8-0x000000018D42ADA8
		public static Color32 Tint(this Color32 c1, float tint); // 0x000000018D42ADA8-0x000000018D42AE88
		public static UnityEngine.Color MinAlpha(this UnityEngine.Color c1, UnityEngine.Color c2); // 0x000000018D42AC98-0x000000018D42ACC8
		public static bool Compare(this Vector3 v1, Vector3 v2, int accuracy); // 0x000000018D42AA84-0x000000018D42AB20
		public static bool Compare(this Quaternion q1, Quaternion q2, int accuracy); // 0x000000018D42A9C0-0x000000018D42AA84
	}

	public static class TMP_Math // TypeDefIndex: 82323
	{
		// Fields
		public const float FLOAT_MAX = 32767f; // Metadata: 0x02640BF8
		public const float FLOAT_MIN = -32767f; // Metadata: 0x02640BFC
		public const int INT_MAX = 2147483647; // Metadata: 0x02640C00
		public const int INT_MIN = -2147483647; // Metadata: 0x02640C01
		public const float FLOAT_UNSET = -32767f; // Metadata: 0x02640C06
		public const int INT_UNSET = -32767; // Metadata: 0x02640C0A
		public static Vector2 MAX_16BIT; // 0x00
		public static Vector2 MIN_16BIT; // 0x08
	
		// Constructors
		static TMP_Math(); // 0x00000001871F3EA0-0x00000001871F3F00
	
		// Methods
		public static bool Approximately(float a, float b); // 0x0000000186C05AC0-0x0000000186C05AF0
		public static int Mod(int a, int b); // 0x000000018D42A07C-0x000000018D42A094
	}

	public enum TMP_VertexDataUpdateFlags // TypeDefIndex: 82324
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
	public struct VertexGradient // TypeDefIndex: 82325
	{
		// Fields
		public UnityEngine.Color topLeft; // 0x00
		public UnityEngine.Color topRight; // 0x10
		public UnityEngine.Color bottomLeft; // 0x20
		public UnityEngine.Color bottomRight; // 0x30
	
		// Constructors
		public VertexGradient(UnityEngine.Color color); // 0x000000018725F1E0-0x000000018725F200
		public VertexGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3); // 0x000000018725DA90-0x000000018725DAC0
	}

	public struct TMP_PageInfo // TypeDefIndex: 82326
	{
		// Fields
		public int firstCharacterIndex; // 0x00
		public int lastCharacterIndex; // 0x04
		public float ascender; // 0x08
		public float baseLine; // 0x0C
		public float descender; // 0x10
	}

	public struct TMP_LinkInfo // TypeDefIndex: 82327
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
		internal void SetLinkID(char[] text, int startIndex, int length); // 0x0000000186887660-0x0000000186887860
		public string GetLinkText(); // 0x000000018D429F90-0x000000018D42A07C
		public string GetLinkID(); // 0x000000018D429F00-0x000000018D429F90
	}

	public struct TMP_WordInfo // TypeDefIndex: 82328
	{
		// Fields
		public TMP_Text textComponent; // 0x00
		public int firstCharacterIndex; // 0x08
		public int lastCharacterIndex; // 0x0C
		public int characterCount; // 0x10
	
		// Methods
		public string GetWord(); // 0x000000018D42A2CC-0x000000018D42A3B0
	}

	public struct TMP_SpriteInfo // TypeDefIndex: 82329
	{
		// Fields
		public int spriteIndex; // 0x00
		public int characterIndex; // 0x04
		public int vertexIndex; // 0x08
	}

	public struct Extents // TypeDefIndex: 82330
	{
		// Fields
		internal static Extents zero; // 0x00
		internal static Extents uninitialized; // 0x10
		public Vector2 min; // 0x00
		public Vector2 max; // 0x08
	
		// Constructors
		public Extents(Vector2 min, Vector2 max); // 0x0000000187232F10-0x0000000187232F20
		static Extents(); // 0x00000001870DCC80-0x00000001870DCCE0
	
		// Methods
		public override string ToString(); // 0x000000018D41CA04-0x000000018D41CB88
	}

	[Serializable]
	public struct Mesh_Extents // TypeDefIndex: 82331
	{
		// Fields
		public Vector2 min; // 0x00
		public Vector2 max; // 0x08
	
		// Constructors
		public Mesh_Extents(Vector2 min, Vector2 max); // 0x0000000187232F10-0x0000000187232F20
	
		// Methods
		public override string ToString(); // 0x000000018D41D770-0x000000018D41D8F4
	}

	public struct WordWrapState // TypeDefIndex: 82332
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

	public struct TagAttribute // TypeDefIndex: 82333
	{
		// Fields
		public int startIndex; // 0x00
		public int length; // 0x04
		public int hashCode; // 0x08
	}

	public struct RichTextTagAttribute // TypeDefIndex: 82334
	{
		// Fields
		public int nameHashCode; // 0x00
		public int valueHashCode; // 0x04
		public TagValueType valueType; // 0x08
		public int valueStartIndex; // 0x0C
		public int valueLength; // 0x10
		public TagUnitType unitType; // 0x14
	}

	internal class TMP_ArrayObjectPool<T> // TypeDefIndex: 82336
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
		internal struct PoolOptions // TypeDefIndex: 82335
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

	internal static class TMP_ArrayPool<T> // TypeDefIndex: 82338
	{
		// Fields
		private static readonly TMP_ArrayObjectPool<T> s_ArrayPool;
		private static readonly TMP_ArrayPoolWrapper<T> s_ArrayPoolWrapper;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 82337
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

	public interface IPoolClearable // TypeDefIndex: 82339
	{
		// Methods
		void Clear();
	}

	internal interface ITMPArrayPoolRegistryItem // TypeDefIndex: 82340
	{
		// Methods
		void Shrink();
	}

	public static class TMP_ArrayPoolRegistry // TypeDefIndex: 82341
	{
		// Fields
		private static readonly List<ITMPArrayPoolRegistryItem> registeredPools; // 0x00
	
		// Constructors
		static TMP_ArrayPoolRegistry(); // 0x0000000187176970-0x0000000187176A00
	
		// Methods
		internal static void Register(ITMPArrayPoolRegistryItem pool); // 0x00000001867ABD00-0x00000001867ABDE0
		public static void ShrinkAll(); // 0x0000000186A7F650-0x0000000186A7F770
	}

	internal class TMP_ArrayPoolWrapper<T> : ITMPArrayPoolRegistryItem // TypeDefIndex: 82342
	{
		// Constructors
		public TMP_ArrayPoolWrapper();
	
		// Methods
		public void Shrink();
	}

	[Serializable]
	public abstract class TMP_Asset : ScriptableObject // TypeDefIndex: 82343
	{
		// Fields
		private int m_InstanceID; // 0x18
		public int hashCode; // 0x1C
		public Material material; // 0x20
		public int materialHashCode; // 0x28
	
		// Properties
		public int instanceID { get; } // 0x00000001852D35F0-0x00000001852D3620 
	
		// Constructors
		protected TMP_Asset(); // 0x0000000185DD6260-0x0000000185DD6270
	}

	[Serializable]
	public class TMP_Character : TMP_TextElement // TypeDefIndex: 82344
	{
		// Constructors
		public TMP_Character(); // 0x000000018725F0A0-0x000000018725F0B0
		public TMP_Character(uint unicode, Glyph glyph); // 0x000000018D41D9AC-0x000000018D41D9FC
		public TMP_Character(uint unicode, TMP_FontAsset fontAsset, Glyph glyph); // 0x00000001852DBC20-0x00000001852DBC70
		internal TMP_Character(uint unicode, uint glyphIndex); // 0x000000018D41D96C-0x000000018D41D9AC
	}

	public struct TMP_Vertex // TypeDefIndex: 82345
	{
		// Fields
		public Vector3 position; // 0x00
		public Vector2 uv; // 0x0C
		public Vector2 uv2; // 0x14
		public Vector2 uv4; // 0x1C
		public Color32 color; // 0x24
		private static readonly TMP_Vertex k_Zero; // 0x00
	
		// Properties
		public static TMP_Vertex zero { get; } // 0x000000018D42A26C-0x000000018D42A2CC 
	
		// Constructors
		static TMP_Vertex(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public struct TMP_Offset // TypeDefIndex: 82346
	{
		// Fields
		private float m_Left; // 0x00
		private float m_Right; // 0x04
		private float m_Top; // 0x08
		private float m_Bottom; // 0x0C
		private static readonly TMP_Offset k_ZeroOffset; // 0x00
	
		// Properties
		public float left { get; set; } // 0x00000001872342D0-0x00000001872342E0 0x0000000187241700-0x0000000187241710
		public float right { get; set; } // 0x000000018724A6D0-0x000000018724A6E0 0x00000001872598B0-0x00000001872598C0
		public float top { get; set; } // 0x000000018724A400-0x000000018724A410 0x000000018725A120-0x000000018725A130
		public float bottom { get; set; } // 0x000000018724AEC0-0x000000018724AED0 0x000000018725AC70-0x000000018725AC80
		public float horizontal { get; set; } // 0x00000001872342D0-0x00000001872342E0 0x000000018725B620-0x000000018725B630
		public float vertical { get; set; } // 0x000000018724A400-0x000000018724A410 0x000000018725F1D0-0x000000018725F1E0
		public static TMP_Offset zero { get; } // 0x000000018D42A1C0-0x000000018D42A200 
	
		// Constructors
		public TMP_Offset(float left, float right, float top, float bottom); // 0x00000001872359D0-0x00000001872359F0
		public TMP_Offset(float horizontal, float vertical); // 0x000000018725F1B0-0x000000018725F1D0
		static TMP_Offset(); // 0x0000000187214260-0x00000001872142A0
	
		// Methods
		public static bool operator ==(TMP_Offset lhs, TMP_Offset rhs); // 0x00000001862F2760-0x00000001862F27A0
		public static bool operator !=(TMP_Offset lhs, TMP_Offset rhs); // 0x000000018D42A200-0x000000018D42A26C
		public static TMP_Offset operator *(TMP_Offset a, float b); // 0x00000001855D4360-0x00000001855D4380
		public override int GetHashCode(); // 0x000000018D42A170-0x000000018D42A1C0
		public override bool Equals(object obj); // 0x000000018D42A110-0x000000018D42A170
		public bool Equals(TMP_Offset other); // 0x000000018D42A094-0x000000018D42A110
	}

	public struct HighlightState // TypeDefIndex: 82347
	{
		// Fields
		public Color32 color; // 0x00
		public TMP_Offset padding; // 0x04
	
		// Constructors
		public HighlightState(Color32 color, TMP_Offset padding); // 0x000000018724A2F0-0x000000018724A300
	
		// Methods
		public static bool operator ==(HighlightState lhs, HighlightState rhs); // 0x000000018D41CF0C-0x000000018D41CFD0
		public static bool operator !=(HighlightState lhs, HighlightState rhs); // 0x000000018D41CFD0-0x000000018D41D00C
		public override int GetHashCode(); // 0x000000018D41CEB8-0x000000018D41CF0C
		public override bool Equals(object obj); // 0x000000018D41CDCC-0x000000018D41CE30
		public bool Equals(HighlightState other); // 0x000000018D41CE30-0x000000018D41CEB8
	}

	[DebuggerDisplay("Unicode \'{character}\'  ({((uint)character).ToString(\"X\")})")]
	public struct TMP_CharacterInfo : IPoolClearable // TypeDefIndex: 82348
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
		public void Clear(); // 0x00000001852F0330-0x00000001852F0480
	}

	public enum ColorMode // TypeDefIndex: 82349
	{
		Single = 0,
		HorizontalGradient = 1,
		VerticalGradient = 2,
		FourCornersGradient = 3
	}

	[Serializable]
	[ExcludeFromPreset]
	public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 82350
	{
		// Fields
		public ColorMode colorMode; // 0x18
		public UnityEngine.Color topLeft; // 0x1C
		public UnityEngine.Color topRight; // 0x2C
		public UnityEngine.Color bottomLeft; // 0x3C
		public UnityEngine.Color bottomRight; // 0x4C
		private const ColorMode k_DefaultColorMode = ColorMode.FourCornersGradient; // Metadata: 0x02640C1A
		private static readonly UnityEngine.Color k_DefaultColor; // 0x00
	
		// Constructors
		public TMP_ColorGradient(); // 0x000000018D41DA40-0x000000018D41DAEC
		public TMP_ColorGradient(UnityEngine.Color color); // 0x000000018D41DAEC-0x000000018D41DB30
		public TMP_ColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3); // 0x000000018D41DB30-0x000000018D41DBA0
		static TMP_ColorGradient(); // 0x000000018D41D9FC-0x000000018D41DA40
	}

	public static class TMP_Compatibility // TypeDefIndex: 82352
	{
		// Nested types
		public enum AnchorPositions // TypeDefIndex: 82351
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
		public static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue); // 0x000000018D41DBA0-0x000000018D41DCBC
	}

	internal interface ITweenValue // TypeDefIndex: 82353
	{
		// Properties
		bool ignoreTimeScale { get; }
		float duration { get; }
	
		// Methods
		void TweenValue(float floatPercentage);
		bool ValidTarget();
	}

	internal struct ColorTween : ITweenValue // TypeDefIndex: 82356
	{
		// Fields
		private ColorTweenCallback m_Target; // 0x00
		private UnityEngine.Color m_StartColor; // 0x08
		private UnityEngine.Color m_TargetColor; // 0x18
		private ColorTweenMode m_TweenMode; // 0x28
		private float m_Duration; // 0x2C
		private bool m_IgnoreTimeScale; // 0x30
	
		// Properties
		public UnityEngine.Color startColor { get; set; } // 0x000000018453CA30-0x000000018453CA40 0x000000018723B0B0-0x000000018723B0C0
		public UnityEngine.Color targetColor { get; set; } // 0x00000001845C28E0-0x00000001845C28F0 0x0000000187235FF0-0x0000000187236000
		public ColorTweenMode tweenMode { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public float duration { get; set; } // 0x0000000187233330-0x0000000187233340 0x0000000187233340-0x0000000187233350
		public bool ignoreTimeScale { get; set; } // 0x00000001822434B0-0x00000001822434C0 0x00000001822434C0-0x00000001822434D0
	
		// Nested types
		public enum ColorTweenMode // TypeDefIndex: 82354
		{
			All = 0,
			RGB = 1,
			Alpha = 2
		}
	
		public class ColorTweenCallback : UnityEvent<UnityEngine.Color> // TypeDefIndex: 82355
		{
			// Constructors
			public ColorTweenCallback(); // 0x000000018D41C738-0x000000018D41C774
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x000000018D41C80C-0x000000018D41C8E4
		public void AddOnChangedCallback(UnityAction<UnityEngine.Color> callback); // 0x000000018D41C774-0x000000018D41C80C
		public bool GetIgnoreTimescale(); // 0x00000001822434B0-0x00000001822434C0
		public float GetDuration(); // 0x0000000187233330-0x0000000187233340
		public bool ValidTarget(); // 0x0000000185AEC7D0-0x0000000185AEC7E0
	}

	internal struct FloatTween : ITweenValue // TypeDefIndex: 82358
	{
		// Fields
		private FloatTweenCallback m_Target; // 0x00
		private float m_StartValue; // 0x08
		private float m_TargetValue; // 0x0C
		private float m_Duration; // 0x10
		private bool m_IgnoreTimeScale; // 0x14
	
		// Properties
		public float startValue { get; set; } // 0x000000018724A400-0x000000018724A410 0x000000018725A120-0x000000018725A130
		public float targetValue { get; set; } // 0x000000018724AEC0-0x000000018724AED0 0x000000018725AC70-0x000000018725AC80
		public float duration { get; set; } // 0x0000000187232D00-0x0000000187232D10 0x0000000187235230-0x0000000187235240
		public bool ignoreTimeScale { get; set; } // 0x0000000187239C50-0x0000000187239C60 0x000000018723C800-0x000000018723C810
	
		// Nested types
		public class FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 82357
		{
			// Constructors
			public FloatTweenCallback(); // 0x000000018D41CB88-0x000000018D41CBC4
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x000000018D41CC5C-0x000000018D41CCC0
		public void AddOnChangedCallback(UnityAction<float> callback); // 0x000000018D41CBC4-0x000000018D41CC5C
		public bool GetIgnoreTimescale(); // 0x0000000187239C50-0x0000000187239C60
		public float GetDuration(); // 0x0000000187232D00-0x0000000187232D10
		public bool ValidTarget(); // 0x0000000185AEC7D0-0x0000000185AEC7E0
	}

	internal class TweenRunner<T> // TypeDefIndex: 82360
		where T : struct, ITweenValue
	{
		// Fields
		protected MonoBehaviour m_CoroutineContainer;
		protected IEnumerator m_Tween;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__2 : IEnumerator<object> // TypeDefIndex: 82359
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

	public static class TMP_DefaultControls // TypeDefIndex: 82362
	{
		// Fields
		private const float kWidth = 160f; // Metadata: 0x02640C29
		private const float kThickHeight = 30f; // Metadata: 0x02640C2D
		private const float kThinHeight = 20f; // Metadata: 0x02640C31
		private static Vector2 s_TextElementSize; // 0x00
		private static Vector2 s_ThickElementSize; // 0x08
		private static Vector2 s_ThinElementSize; // 0x10
		private static UnityEngine.Color s_DefaultSelectableColor; // 0x18
		private static UnityEngine.Color s_TextColor; // 0x28
	
		// Nested types
		public struct Resources // TypeDefIndex: 82361
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
		static TMP_DefaultControls(); // 0x000000018D41F9AC-0x000000018D41FA54
	
		// Methods
		private static GameObject CreateUIElementRoot(string name, Vector2 size); // 0x000000018D41F600-0x000000018D41F6A0
		private static GameObject CreateUIObject(string name, GameObject parent); // 0x000000018D41F6A0-0x000000018D41F750
		private static void SetDefaultTextValues(TMP_Text lbl); // 0x000000018D41F7A0-0x000000018D41F820
		private static void SetDefaultColorTransitionValues(Selectable slider); // 0x000000018D41F750-0x000000018D41F7A0
		private static void SetParentAndAlign(GameObject child, GameObject parent); // 0x000000018D41F8E0-0x000000018D41F9AC
		private static void SetLayerRecursively(GameObject go, int layer); // 0x000000018D41F820-0x000000018D41F8E0
		public static GameObject CreateScrollbar(Resources resources); // 0x000000018D41F288-0x000000018D41F564
		public static GameObject CreateButton(Resources resources); // 0x000000018D41DCBC-0x000000018D41DF38
		public static GameObject CreateText(Resources resources); // 0x000000018D41F564-0x000000018D41F600
		public static GameObject CreateInputField(Resources resources); // 0x000000018D41ECE0-0x000000018D41F288
		public static GameObject CreateDropdown(Resources resources); // 0x000000018D41DF38-0x000000018D41ECE0
	}

	[AddComponentMenu("UI/Dropdown - TextMeshPro", 35)]
	[RequireComponent(typeof(RectTransform))]
	public class TMP_Dropdown : Selectable, IPointerClickHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 82369
	{
		// Fields
		[SerializeField]
		private RectTransform m_Template; // 0x190
		[SerializeField]
		private TMP_Text m_CaptionText; // 0x198
		[SerializeField]
		private Image m_CaptionImage; // 0x1A0
		[SerializeField]
		private Graphic m_Placeholder; // 0x1A8
		[SerializeField]
		[Space]
		private TMP_Text m_ItemText; // 0x1B0
		[SerializeField]
		private Image m_ItemImage; // 0x1B8
		[SerializeField]
		[Space]
		private int m_Value; // 0x1C0
		[SerializeField]
		[Space]
		private OptionDataList m_Options; // 0x1C8
		[SerializeField]
		[Space]
		private DropdownEvent m_OnValueChanged; // 0x1D0
		[SerializeField]
		private float m_AlphaFadeSpeed; // 0x1D8
		private GameObject m_Dropdown; // 0x1E0
		private GameObject m_Blocker; // 0x1E8
		private List<DropdownItem> m_Items; // 0x1F0
		private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x1F8
		private bool validTemplate; // 0x200
		private Coroutine m_Coroutine; // 0x208
		private static OptionData s_NoOptionData; // 0x00
	
		// Properties
		public RectTransform template { get; set; } // 0x000000018723C0A0-0x000000018723C0B0 0x000000018D42293C-0x000000018D422964
		public TMP_Text captionText { get; set; } // 0x000000018723C220-0x000000018723C230 0x000000018D422868-0x000000018D422890
		public Image captionImage { get; set; } // 0x000000018723BE20-0x000000018723BE30 0x000000018D422840-0x000000018D422868
		public Graphic placeholder { get; set; } // 0x000000018723BDE0-0x000000018723BDF0 0x000000018D422914-0x000000018D42293C
		public TMP_Text itemText { get; set; } // 0x000000018723BD90-0x000000018723BDA0 0x000000018D4228B8-0x000000018D4228E0
		public Image itemImage { get; set; } // 0x000000018723BE80-0x000000018723BE90 0x000000018D422890-0x000000018D4228B8
		public List<OptionData> options { get; set; } // 0x000000018D422820-0x000000018D422840 0x000000018D4228E0-0x000000018D422914
		public DropdownEvent onValueChanged { get; set; } // 0x000000018723BC70-0x000000018723BC80 0x0000000188DC4458-0x0000000188DC446C
		public float alphaFadeSpeed { get; set; } // 0x000000018725F0B0-0x000000018725F0C0 0x000000018725F0C0-0x000000018725F0D0
		public int value { get; set; } // 0x000000018723E870-0x000000018723E880 0x000000018D422964-0x000000018D422970
		public bool IsExpanded { get; } // 0x000000018D4227CC-0x000000018D422820 
	
		// Nested types
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, ICancelHandler // TypeDefIndex: 82363
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
			public TMP_Text text { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
			public Image image { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
			public RectTransform rectTransform { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
			public Toggle toggle { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
	
			// Constructors
			public DropdownItem(); // 0x00000001878364A0-0x00000001878364B8
	
			// Methods
			public virtual void OnPointerEnter(PointerEventData eventData); // 0x000000018D41C998-0x000000018D41CA04
			public virtual void OnCancel(BaseEventData eventData); // 0x000000018D41C920-0x000000018D41C998
		}
	
		[Serializable]
		public class OptionData // TypeDefIndex: 82364
		{
			// Fields
			[SerializeField]
			private string m_Text; // 0x10
			[SerializeField]
			private Sprite m_Image; // 0x18
	
			// Properties
			public string text { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
			public Sprite image { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
			// Constructors
			public OptionData(); // 0x0000000186805BA0-0x0000000186805BB0
			public OptionData(string text); // 0x0000000184FD2410-0x0000000184FD2420
			public OptionData(Sprite image); // 0x0000000187835500-0x0000000187835510
			public OptionData(string text, Sprite image); // 0x0000000185381AC0-0x0000000185381AF0
		}
	
		[Serializable]
		public class OptionDataList // TypeDefIndex: 82365
		{
			// Fields
			[SerializeField]
			private List<OptionData> m_Options; // 0x10
	
			// Properties
			public List<OptionData> options { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
			// Constructors
			public OptionDataList(); // 0x000000018D41D8F4-0x000000018D41D96C
		}
	
		[Serializable]
		public class DropdownEvent : UnityEvent<int> // TypeDefIndex: 82366
		{
			// Constructors
			public DropdownEvent(); // 0x000000018D41C8E4-0x000000018D41C920
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass69_0 // TypeDefIndex: 82367
		{
			// Fields
			public DropdownItem item; // 0x10
			public TMP_Dropdown __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass69_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Show_b__0(bool x); // 0x000000018D42B378-0x000000018D42B3A8
		}
	
		[CompilerGenerated]
		private sealed class _DelayedDestroyDropdownList_d__81 : IEnumerator<object> // TypeDefIndex: 82368
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float delay; // 0x20
			public TMP_Dropdown __4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _DelayedDestroyDropdownList_d__81(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D42AFE8-0x000000018D42B08C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D42B08C-0x000000018D42B0D8
		}
	
		// Constructors
		protected TMP_Dropdown(); // 0x000000018D4226A4-0x000000018D4227CC
		static TMP_Dropdown(); // 0x000000018D422634-0x000000018D4226A4
	
		// Methods
		public void SetValueWithoutNotify(int input); // 0x000000018D420FB4-0x000000018D420FC0
		private void SetValue(int value, bool sendCallback = true /* Metadata: 0x02640C35 */); // 0x000000018D420FC0-0x000000018D4210F8
		protected override void Awake(); // 0x000000018D420118-0x000000018D420200
		protected override void Start(); // 0x000000018D4225A4-0x000000018D422634
		protected override void OnDisable(); // 0x000000018D420B0C-0x000000018D420BA0
		public void RefreshShownValue(); // 0x000000018D420CB0-0x000000018D420F14
		public void AddOptions(List<OptionData> options); // 0x000000018D41FCE0-0x000000018D41FD48
		public void AddOptions(List<string> options); // 0x000000018D41FD48-0x000000018D41FE38
		public void AddOptions(List<Sprite> options); // 0x000000018D41FE38-0x000000018D41FF28
		public void ClearOptions(); // 0x000000018D420200-0x000000018D420298
		private void SetupTemplate(); // 0x000000018D4210F8-0x000000018D42170C
		private static T GetOrAddComponent<T>(GameObject go)
			where T : Component;
		public virtual void OnPointerClick(PointerEventData eventData); // 0x000000018D420BA0-0x000000018D420BA8
		public virtual void OnSubmit(BaseEventData eventData); // 0x000000018D420BA0-0x000000018D420BA8
		public virtual void OnCancel(BaseEventData eventData); // 0x000000018D420B04-0x000000018D420B0C
		public void Show(); // 0x000000018D42170C-0x000000018D4225A4
		protected virtual GameObject CreateBlocker(Canvas rootCanvas); // 0x000000018D420298-0x000000018D4206D0
		protected virtual void DestroyBlocker(GameObject blocker); // 0x000000018D4207E8-0x000000018D420834
		protected virtual GameObject CreateDropdownList(GameObject template); // 0x000000018D4206D0-0x000000018D420724
		protected virtual void DestroyDropdownList(GameObject dropdownList); // 0x000000018D420834-0x000000018D420880
		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate); // 0x000000018D420724-0x000000018D420778
		protected virtual void DestroyItem(DropdownItem item); // 0x0000000186805BA0-0x0000000186805BB0
		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items); // 0x000000018D41FA54-0x000000018D41FCE0
		private void AlphaFadeList(float duration, float alpha); // 0x000000018D42008C-0x000000018D420118
		private void AlphaFadeList(float duration, float start, float end); // 0x000000018D41FF28-0x000000018D42008C
		private void SetAlpha(float alpha); // 0x000000018D420F14-0x000000018D420FB4
		public void Hide(); // 0x000000018D420880-0x000000018D420998
		[IteratorStateMachine(typeof(_DelayedDestroyDropdownList_d__81))]
		private IEnumerator DelayedDestroyDropdownList(float delay); // 0x000000018D420778-0x000000018D4207E8
		private void ImmediateDestroyDropdownList(); // 0x000000018D420998-0x000000018D420B04
		private void OnSelectItem(Toggle toggle); // 0x000000018D420BA8-0x000000018D420CB0
	}

	public enum AtlasPopulationMode // TypeDefIndex: 82370
	{
		Static = 0,
		Dynamic = 1
	}

	[Serializable]
	[ExcludeFromPreset]
	public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 82372
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
		[SerializeField]
		private float m_NormAvgCJKWidth; // 0x1CC
		[SerializeField]
		private float m_NormSpaceWidth; // 0x1D0
		[SerializeField]
		private List<uint> m_LatinNormWidthKeys; // 0x1D8
		[SerializeField]
		private List<float> m_LatinNormWidthValues; // 0x1E0
		[NonSerialized]
		private Dictionary<uint, float> m_LatinNormWidthLookup; // 0x1E8
		internal bool IsFontAssetLookupTablesDirty; // 0x1F0
		private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x00
		private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x08
		private static ProfilerMarker<uint> k_TryAddCharacterMarker; // 0x10
		private static ProfilerMarker k_TryAddCharactersMarker; // 0x18
		private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x20
		private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x28
		private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x30
		private static string s_DefaultMaterialSuffix; // 0x38
		internal HashSet<int> FallbackSearchQueryLookup; // 0x1F8
		private static HashSet<int> k_SearchedFontAssetLookup; // 0x40
		private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x48
		private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x50
		private static List<TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue; // 0x58
		private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x60
		private List<Glyph> m_GlyphsToRender; // 0x200
		private List<Glyph> m_GlyphsRendered; // 0x208
		private List<uint> m_GlyphIndexList; // 0x210
		private List<uint> m_GlyphIndexListNewlyAdded; // 0x218
		internal List<uint> m_GlyphsToAdd; // 0x220
		internal HashSet<uint> m_GlyphsToAddLookup; // 0x228
		internal List<TMP_Character> m_CharactersToAdd; // 0x230
		internal HashSet<uint> m_CharactersToAddLookup; // 0x238
		internal List<uint> s_MissingCharacterList; // 0x240
		internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x248
		internal static uint[] k_GlyphIndexArray; // 0x68
		private RenderTexture[] m_DynamicRenderTextures; // 0x250
	
		// Properties
		public string version { get; internal set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public Font sourceFontFile { get; internal set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public float thaiBiasConsonantsValue { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public string prefixMaterialSearchPatternValue { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public AtlasPopulationMode atlasPopulationMode { get; set; } // 0x00000001872331A0-0x00000001872331B0 0x0000000185B8E8A0-0x0000000185B8EB10
		public FaceInfo faceInfo { get; set; } // 0x000000018725F150-0x000000018725F190 0x000000018D429A1C-0x000000018D429A60
		public List<Glyph> glyphTable { get; internal set; } // 0x0000000187236200-0x0000000187236210 0x0000000188D95540-0x0000000188D95554
		public Dictionary<uint, Glyph> glyphLookupTable { get; } // 0x000000018D42999C-0x000000018D4299CC 
		public List<TMP_Character> characterTable { get; internal set; } // 0x0000000187234580-0x0000000187234590 0x0000000188A79A0C-0x0000000188A79A20
		public Dictionary<uint, TMP_Character> characterLookupTable { get; } // 0x00000001857E9DA0-0x00000001857E9DE0 
		public Texture2D atlasTexture { get; } // 0x0000000185102210-0x00000001851022D0 
		public Texture2D[] atlasTextures { get; set; } // 0x00000001872354B0-0x00000001872354C0 0x0000000188D62F7C-0x0000000188D62F90
		public int atlasTextureCount { get; } // 0x000000018725F0E0-0x000000018725F0F0 
		public bool isMultiAtlasTexturesEnabled { get; set; } // 0x0000000187255580-0x0000000187255590 0x0000000187255590-0x00000001872555A0
		internal bool clearDynamicDataOnBuild { get; set; } // 0x00000001872555A0-0x00000001872555B0 0x00000001872555B0-0x00000001872555C0
		internal List<GlyphRect> usedGlyphRects { get; set; } // 0x00000001872346D0-0x00000001872346E0 0x0000000188A7C28C-0x0000000188A7C2A0
		internal List<GlyphRect> freeGlyphRects { get; set; } // 0x0000000187234CE0-0x0000000187234CF0 0x0000000188A90E90-0x0000000188A90EA4
		[Obsolete("The fontInfo property and underlying type is now obsolete. Please use the faceInfo property and FaceInfo type instead.")]
		public FaceInfo_Legacy fontInfo { get; } // 0x0000000187232D20-0x0000000187232D30 
		public int atlasWidth { get; internal set; } // 0x000000018725F0F0-0x000000018725F100 0x000000018725F1A0-0x000000018725F1B0
		public int atlasHeight { get; internal set; } // 0x000000018725F0D0-0x000000018725F0E0 0x000000018725F190-0x000000018725F1A0
		public int atlasPadding { get; internal set; } // 0x000000018723F8C0-0x000000018723F8D0 0x000000018723F900-0x000000018723F910
		public GlyphRenderMode atlasRenderMode { get; internal set; } // 0x0000000187240800-0x0000000187240810 0x0000000187240820-0x0000000187240830
		public TMP_FontFeatureTable fontFeatureTable { get; internal set; } // 0x000000018723B5C0-0x000000018723B5D0 0x000000018783BF8C-0x000000018783BFA0
		public List<TMP_FontAsset> fallbackFontAssetTable { get; set; } // 0x000000018723BEA0-0x000000018723BEB0 0x0000000188DC4804-0x0000000188DC4818
		public FontAssetCreationSettings creationSettings { get; set; } // 0x000000018725F100-0x000000018725F150 0x000000018D4299CC-0x000000018D429A1C
		public TMP_FontWeightPair[] fontWeightTable { get; internal set; } // 0x000000018723BDE0-0x000000018723BDF0 0x0000000188DC46B0-0x0000000188DC46C4
		public float normAvgCJKWidth { get; } // 0x000000018723C450-0x000000018723C460 
		public float normSpaceWidth { get; } // 0x000000018723C430-0x000000018723C440 
		public RenderTexture[] dynamicRenderTextures { get; } // 0x000000018723BCE0-0x000000018723BCF0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 82371
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<TMP_Character, uint> __9__144_0; // 0x08
			public static Func<Glyph, uint> __9__145_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D42B3A8-0x000000018D42B40C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal uint _SortCharacterTable_b__144_0(TMP_Character c); // 0x000000018D42B2E8-0x000000018D42B300
			internal uint _SortGlyphTable_b__145_0(Glyph c); // 0x000000018CC33418-0x000000018CC33430
		}
	
		// Constructors
		public TMP_FontAsset(); // 0x00000001869B2D30-0x00000001869B3240
		static TMP_FontAsset(); // 0x0000000186CFD0D0-0x0000000186CFD440
	
		// Methods
		public float GetNormCharWidth(uint unicode); // 0x000000018D4240B4-0x000000018D424248
		public void RebuildAutoSizeNormData(); // 0x000000018D4251D0-0x000000018D4256B4
		public static TMP_FontAsset CreateFontAsset(Font font); // 0x000000018D423848-0x000000018D4238BC
		public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic /* Metadata: 0x02640C38 */, bool enableMultiAtlasSupport = true /* Metadata: 0x02640C39 */); // 0x000000018D4238BC-0x000000018D423E10
		private void Awake(); // 0x0000000186EAB0A0-0x0000000186EAB150
		public void ReadFontAssetDefinition(); // 0x00000001852DB260-0x00000001852DB890
		internal void InitializeDictionaryLookupTables(); // 0x00000001852DB8F0-0x00000001852DB920
		internal void InitializeGlyphLookupDictionary(); // 0x00000001858E6F60-0x00000001858E7170
		internal void InitializeCharacterLookupDictionary(); // 0x00000001852DBE80-0x00000001852DC090
		internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary(); // 0x00000001852DB920-0x00000001852DBA40
		internal void AddSynthesizedCharactersAndFaceMetrics(); // 0x00000001852DBA40-0x00000001852DBC20
		private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false /* Metadata: 0x02640C3A */); // 0x00000001852DBC70-0x00000001852DBE10
		internal void AddCharacterToLookupCache(uint unicode, TMP_Character character); // 0x000000018D422E6C-0x000000018D422F10
		internal void SortCharacterTable(); // 0x000000018D425C10-0x000000018D425D7C
		internal void SortGlyphTable(); // 0x000000018D425DA0-0x000000018D425F0C
		internal void SortFontFeatureTable(); // 0x000000018D425D7C-0x000000018D425DA0
		internal void SortAllTables(); // 0x000000018D425BE4-0x000000018D425C10
		public bool HasCharacter(int character); // 0x000000018D424468-0x000000018D4244C4
		public bool HasCharacter(char character, bool searchFallbacks = false /* Metadata: 0x02640C3B */, bool tryAddCharacter = false /* Metadata: 0x02640C3C */); // 0x000000018D4244C4-0x000000018D4249B0
		private bool HasCharacter_Internal(uint character, bool searchFallbacks = false /* Metadata: 0x02640C3D */, bool tryAddCharacter = false /* Metadata: 0x02640C3E */); // 0x000000018D424248-0x000000018D424468
		public bool HasCharacters(string text, out List<char> missingCharacters); // 0x000000018D4249B0-0x000000018D424B08
		public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false /* Metadata: 0x02640C3F */, bool tryAddCharacter = false /* Metadata: 0x02640C40 */); // 0x000000018D424B08-0x000000018D4250D4
		public bool HasCharacters(string text); // 0x000000018D4250D4-0x000000018D425174
		public static string GetCharacters(TMP_FontAsset fontAsset); // 0x000000018D423EF0-0x000000018D423FD0
		public static int[] GetCharactersArray(TMP_FontAsset fontAsset); // 0x000000018D423E10-0x000000018D423EF0
		internal uint GetGlyphIndex(uint unicode); // 0x000000018D423FD0-0x000000018D4240B4
		internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset); // 0x000000018D425780-0x000000018D42584C
		internal static void UpdateFontFeaturesForFontAssetsInQueue(); // 0x00000001851C0360-0x00000001851C03D0
		internal static void RegisterFontAssetForAtlasTextureUpdate(TMP_FontAsset fontAsset); // 0x000000018D4256B4-0x000000018D425780
		internal static void UpdateAtlasTexturesForFontAssetsInQueue(); // 0x000000018D42851C-0x000000018D428640
		public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false /* Metadata: 0x02640C41 */); // 0x000000018D427BD0-0x000000018D427BF4
		public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false /* Metadata: 0x02640C42 */); // 0x000000018D42675C-0x000000018D4271A8
		public bool TryAddCharacters(string characters, bool includeFontFeatures = false /* Metadata: 0x02640C43 */); // 0x000000018D4271A8-0x000000018D4271CC
		public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false /* Metadata: 0x02640C44 */); // 0x000000018D4271CC-0x000000018D427BD0
		public void AddCharacters(string characters); // 0x000000018D422F10-0x000000018D422FC4
		internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character); // 0x000000018D425F0C-0x000000018D42675C
		internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character); // 0x000000018D427F74-0x000000018D428398
		internal void TryAddGlyphsToAtlasTextures(); // 0x0000000186805BA0-0x0000000186805BB0
		private bool TryAddGlyphsToNewAtlasTexture(); // 0x000000018D427BF4-0x000000018D427F74
		private void SetupNewAtlasTexture(); // 0x000000018D42584C-0x000000018D425BE4
		internal void UpdateAtlasTexture(); // 0x000000018D428398-0x000000018D42851C
		internal void UpdateGlyphAdjustmentRecords(); // 0x000000018D428758-0x000000018D4289BC
		internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes); // 0x000000018D4289BC-0x000000018D428BE8
		internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes); // 0x0000000186805BA0-0x0000000186805BB0
		internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes); // 0x0000000186805BA0-0x0000000186805BB0
		private void CopyListDataToArray<T>(List<T> srcList, ref ref T[] dstArray);
		public void ClearFontAssetData(bool setAtlasSizeToZero = false /* Metadata: 0x02640C45 */); // 0x000000018D423684-0x000000018D4236C0
		public void ClearFontAssetData(); // 0x000000018D42367C-0x000000018D423684
		internal void ClearFontAssetDataInternal(); // 0x000000018D423658-0x000000018D42367C
		internal void UpdateFontAssetData(); // 0x000000018D428640-0x000000018D428758
		internal void ClearFontAssetTables(); // 0x000000018D4236C0-0x000000018D423848
		internal void ClearAtlasTextures(bool setAtlasSizeToZero = false /* Metadata: 0x02640C46 */); // 0x000000018D422FC4-0x000000018D423658
		internal void UpgradeFontAsset(); // 0x000000018D428BE8-0x000000018D4295F4
		private void UpgradeGlyphAdjustmentTableToFontFeatureTable(); // 0x000000018D4295F4-0x000000018D42999C
		private void OnDestroy(); // 0x000000018D425174-0x000000018D4251D0
	}

	[Serializable]
	public class FaceInfo_Legacy // TypeDefIndex: 82373
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
		public FaceInfo_Legacy(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class TMP_Glyph : TMP_TextElement_Legacy // TypeDefIndex: 82374
	{
		// Constructors
		public TMP_Glyph(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static TMP_Glyph Clone(TMP_Glyph source); // 0x000000018D429E7C-0x000000018D429F00
	}

	[Serializable]
	public struct FontAssetCreationSettings // TypeDefIndex: 82375
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
		internal FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode); // 0x000000018D41CCC0-0x000000018D41CDCC
	}

	[Serializable]
	public struct TMP_FontWeightPair // TypeDefIndex: 82376
	{
		// Fields
		public TMP_FontAsset regularTypeface; // 0x00
		public TMP_FontAsset italicTypeface; // 0x08
	}

	public struct KerningPairKey // TypeDefIndex: 82377
	{
		// Fields
		public uint ascii_Left; // 0x00
		public uint ascii_Right; // 0x04
		public uint key; // 0x08
	
		// Constructors
		public KerningPairKey(uint ascii_left, uint ascii_right); // 0x000000018725F020-0x000000018725F040
	}

	[Serializable]
	public struct GlyphValueRecord_Legacy // TypeDefIndex: 82378
	{
		// Fields
		public float xPlacement; // 0x00
		public float yPlacement; // 0x04
		public float xAdvance; // 0x08
		public float yAdvance; // 0x0C
	
		// Constructors
		internal GlyphValueRecord_Legacy(GlyphValueRecord valueRecord); // 0x000000018725F000-0x000000018725F020
	
		// Methods
		public static GlyphValueRecord_Legacy operator +(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b); // 0x00000001855D4380-0x00000001855D4780
	}

	[Serializable]
	public class KerningPair // TypeDefIndex: 82379
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
		public uint firstGlyph { get; set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public GlyphValueRecord_Legacy firstGlyphAdjustments { get; } // 0x00000001872438C0-0x00000001872438D0 
		public uint secondGlyph { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		public GlyphValueRecord_Legacy secondGlyphAdjustments { get; } // 0x000000018723D770-0x000000018723D780 
		public bool ignoreSpacingAdjustments { get; } // 0x000000018226ECA0-0x000000018226ECB0 
	
		// Constructors
		public KerningPair(); // 0x000000018725F080-0x000000018725F0A0
		public KerningPair(uint left, uint right, float offset); // 0x000000018725F050-0x000000018725F060
		public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments); // 0x000000018725F060-0x000000018725F080
		static KerningPair(); // 0x0000000187180F90-0x0000000187181010
	
		// Methods
		internal void ConvertLegacyKerningData(); // 0x000000018725F040-0x000000018725F050
	}

	[Serializable]
	public class KerningTable // TypeDefIndex: 82384
	{
		// Fields
		public List<KerningPair> kerningPairs; // 0x10
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 82380
		{
			// Fields
			public uint first; // 0x10
			public uint second; // 0x14
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _AddKerningPair_b__0(KerningPair item); // 0x000000018D42B318-0x000000018D42B344
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 82381
		{
			// Fields
			public uint first; // 0x10
			public uint second; // 0x14
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _AddGlyphPairAdjustmentRecord_b__0(KerningPair item); // 0x000000018D42B318-0x000000018D42B344
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 82382
		{
			// Fields
			public int left; // 0x10
			public int right; // 0x14
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _RemoveKerningPair_b__0(KerningPair item); // 0x000000018D42B344-0x000000018D42B378
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 82383
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KerningPair, uint> __9__7_0; // 0x08
			public static Func<KerningPair, uint> __9__7_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D42B40C-0x000000018D42B470
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal uint _SortKerningPairs_b__7_0(KerningPair s); // 0x000000018CC33418-0x000000018CC33430
			internal uint _SortKerningPairs_b__7_1(KerningPair s); // 0x000000018D42B300-0x000000018D42B318
		}
	
		// Constructors
		public KerningTable(); // 0x00000001869B3240-0x00000001869B32C0
	
		// Methods
		public void AddKerningPair(); // 0x000000018D41D2BC-0x000000018D41D3FC
		public int AddKerningPair(uint first, uint second, float offset); // 0x000000018D41D170-0x000000018D41D2BC
		public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments); // 0x000000018D41D00C-0x000000018D41D170
		public void RemoveKerningPair(int left, int right); // 0x000000018D41D3FC-0x000000018D41D4FC
		public void RemoveKerningPair(int index); // 0x000000018D41D4FC-0x000000018D41D550
		public void SortKerningPairs(); // 0x000000018D41D550-0x000000018D41D770
	}

	public static class TMP_FontUtilities // TypeDefIndex: 82385
	{
		// Fields
		private static List<int> k_searchedFontAssets; // 0x00
	
		// Methods
		public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character); // 0x000000018D429D78-0x000000018D429E7C
		public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character); // 0x000000018D429D70-0x000000018D429D78
		private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character); // 0x000000018D429A60-0x000000018D429C90
		private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character); // 0x000000018D429C90-0x000000018D429D70
	}

	public class TMP_FontAssetUtilities // TypeDefIndex: 82386
	{
		// Fields
		private static readonly TMP_FontAssetUtilities s_Instance; // 0x00
		private static HashSet<int> k_SearchedAssets; // 0x08
		private static bool k_IsFontEngineInitialized; // 0x10
	
		// Properties
		public static TMP_FontAssetUtilities instance { get; } // 0x000000018D422E1C-0x000000018D422E6C 
	
		// Constructors
		static TMP_FontAssetUtilities(); // 0x00000001871E7A60-0x00000001871E7AC0
		public TMP_FontAssetUtilities(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface); // 0x00000001857E97B0-0x00000001857E98A0
		private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface); // 0x00000001857E98A0-0x00000001857E9DA0
		public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface); // 0x000000018657F4D0-0x000000018657F7D0
		public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks); // 0x000000018D422B2C-0x000000018D422E1C
		private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks); // 0x000000018D422970-0x000000018D422B2C
	}

	[Flags]
	public enum FontFeatureLookupFlags // TypeDefIndex: 82387
	{
		None = 0,
		IgnoreLigatures = 4,
		IgnoreSpacingAdjustments = 256
	}

	[Serializable]
	public struct TMP_GlyphValueRecord // TypeDefIndex: 82388
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
		public float xPlacement { get; set; } // 0x00000001872342D0-0x00000001872342E0 0x0000000187241700-0x0000000187241710
		public float yPlacement { get; set; } // 0x000000018724A6D0-0x000000018724A6E0 0x00000001872598B0-0x00000001872598C0
		public float xAdvance { get; set; } // 0x000000018724A400-0x000000018724A410 0x000000018725A120-0x000000018725A130
		public float yAdvance { get; set; } // 0x000000018724AEC0-0x000000018724AED0 0x000000018725AC70-0x000000018725AC80
	
		// Constructors
		public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance); // 0x00000001872359D0-0x00000001872359F0
		internal TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord); // 0x0000000187240AE0-0x0000000187240B00
		internal TMP_GlyphValueRecord(GlyphValueRecord valueRecord); // 0x000000018725F000-0x000000018725F020
	
		// Methods
		public static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b); // 0x000000018725F280-0x000000018725F2A0
	}

	[Serializable]
	public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 82389
	{
		// Fields
		[SerializeField]
		internal uint m_GlyphIndex; // 0x00
		[SerializeField]
		internal TMP_GlyphValueRecord m_GlyphValueRecord; // 0x04
	
		// Properties
		public uint glyphIndex { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public TMP_GlyphValueRecord glyphValueRecord { get; set; } // 0x000000018724A410-0x000000018724A420 0x000000018723A660-0x000000018723A670
	
		// Constructors
		public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord); // 0x000000018724A2F0-0x000000018724A300
		internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord); // 0x000000018D42B860-0x000000018D42B8A8
	}

	[Serializable]
	public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 82390
	{
		// Fields
		[SerializeField]
		public TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
		[SerializeField]
		public TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
		[SerializeField]
		public FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38
	
		// Properties
		public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; } // 0x0000000184437000-0x0000000184437020 0x0000000187251540-0x0000000187251550
		public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; } // 0x000000018725F250-0x000000018725F270 0x000000018725F270-0x000000018725F280
		public FontFeatureLookupFlags featureLookupFlags { get; set; } // 0x00000001829600C0-0x00000001829600D0 0x0000000185E3C070-0x0000000185E3C080
	
		// Constructors
		public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord); // 0x000000018725F220-0x000000018725F250
		internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord); // 0x000000018D42B8A8-0x000000018D42B97C
	}

	public struct GlyphPairKey // TypeDefIndex: 82391
	{
		// Fields
		public uint firstGlyphIndex; // 0x00
		public uint secondGlyphIndex; // 0x04
		public uint key; // 0x08
	
		// Constructors
		public GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex); // 0x000000018725F200-0x000000018725F220
		internal GlyphPairKey(TMP_GlyphPairAdjustmentRecord record); // 0x000000018D42B470-0x000000018D42B4A0
	}

	[Serializable]
	public class TMP_FontFeatureTable // TypeDefIndex: 82393
	{
		// Fields
		[SerializeField]
		internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
		public Dictionary<uint, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18
	
		// Properties
		public List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 82392
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> __9__6_0; // 0x08
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> __9__6_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D431BA8-0x000000018D431C0C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal uint _SortGlyphPairAdjustmentRecords_b__6_0(TMP_GlyphPairAdjustmentRecord s); // 0x000000018D431B78-0x000000018D431B90
			internal uint _SortGlyphPairAdjustmentRecords_b__6_1(TMP_GlyphPairAdjustmentRecord s); // 0x000000018D431B90-0x000000018D431BA8
		}
	
		// Constructors
		public TMP_FontFeatureTable(); // 0x00000001869B32C0-0x00000001869B3390
	
		// Methods
		public void SortGlyphPairAdjustmentRecords(); // 0x000000018D42B640-0x000000018D42B860
	}

	[AddComponentMenu("UI/TextMeshPro - Input Field", 11)]
	public class TMP_InputField : Selectable, IUpdateSelectedHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, UnityEngine.EventSystems.IScrollHandler // TypeDefIndex: 82407
	{
		// Fields
		protected TouchScreenKeyboard m_SoftKeyboard; // 0x190
		private static readonly char[] kSeparators; // 0x00
		protected RectTransform m_RectTransform; // 0x198
		[SerializeField]
		protected RectTransform m_TextViewport; // 0x1A0
		protected RectMask2D m_TextComponentRectMask; // 0x1A8
		protected RectMask2D m_TextViewportRectMask; // 0x1B0
		private Rect m_CachedViewportRect; // 0x1B8
		[SerializeField]
		protected TMP_Text m_TextComponent; // 0x1C8
		protected RectTransform m_TextComponentRectTransform; // 0x1D0
		[SerializeField]
		protected Graphic m_Placeholder; // 0x1D8
		[SerializeField]
		protected Scrollbar m_VerticalScrollbar; // 0x1E0
		[SerializeField]
		protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x1E8
		private bool m_IsDrivenByLayoutComponents; // 0x1F0
		[SerializeField]
		private LayoutGroup m_LayoutGroup; // 0x1F8
		private UnityEngine.EventSystems.IScrollHandler m_IScrollHandlerParent; // 0x200
		private float m_ScrollPosition; // 0x208
		[SerializeField]
		protected float m_ScrollSensitivity; // 0x20C
		[SerializeField]
		private ContentType m_ContentType; // 0x210
		[SerializeField]
		private InputType m_InputType; // 0x214
		[SerializeField]
		private char m_AsteriskChar; // 0x218
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType; // 0x21C
		[SerializeField]
		private LineType m_LineType; // 0x220
		[SerializeField]
		private bool m_HideMobileInput; // 0x224
		[SerializeField]
		private bool m_HideSoftKeyboard; // 0x225
		[SerializeField]
		private CharacterValidation m_CharacterValidation; // 0x228
		[SerializeField]
		private string m_RegexValue; // 0x230
		[SerializeField]
		private float m_GlobalPointSize; // 0x238
		[SerializeField]
		private int m_CharacterLimit; // 0x23C
		[SerializeField]
		private SubmitEvent m_OnEndEdit; // 0x240
		[SerializeField]
		private SubmitEvent m_OnSubmit; // 0x248
		[SerializeField]
		private SelectionEvent m_OnSelect; // 0x250
		[SerializeField]
		private SelectionEvent m_OnDeselect; // 0x258
		[SerializeField]
		private TextSelectionEvent m_OnTextSelection; // 0x260
		[SerializeField]
		private TextSelectionEvent m_OnEndTextSelection; // 0x268
		[SerializeField]
		private OnChangeEvent m_OnValueChanged; // 0x270
		[SerializeField]
		private TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x278
		[SerializeField]
		private OnValidateInput m_OnValidateInput; // 0x280
		[SerializeField]
		private UnityEvent m_OnFocused; // 0x288
		[SerializeField]
		private UnityEngine.Color m_CaretColor; // 0x290
		[SerializeField]
		private bool m_CustomCaretColor; // 0x2A0
		[SerializeField]
		private UnityEngine.Color m_SelectionColor; // 0x2A4
		[SerializeField]
		[TextArea(5, 10)]
		protected string m_Text; // 0x2B8
		[Range(0f, 4f)]
		[SerializeField]
		private float m_CaretBlinkRate; // 0x2C0
		[Range(1f, 5f)]
		[SerializeField]
		private int m_CaretWidth; // 0x2C4
		[SerializeField]
		private bool m_ReadOnly; // 0x2C8
		[SerializeField]
		private bool m_RichText; // 0x2C9
		[SerializeField]
		private bool m_disableUpDownArrowKeyMovingCaret; // 0x2CA
		[SerializeField]
		private bool m_disableLeftRightArrowKeyMovingCaret; // 0x2CB
		protected int m_StringPosition; // 0x2CC
		protected int m_StringSelectPosition; // 0x2D0
		protected int m_CaretPosition; // 0x2D4
		protected int m_CaretSelectPosition; // 0x2D8
		private RectTransform caretRectTrans; // 0x2E0
		protected UIVertex[] m_CursorVerts; // 0x2E8
		private CanvasRenderer m_CachedInputRenderer; // 0x2F0
		private Vector2 m_LastPosition; // 0x2F8
		[NonSerialized]
		protected Mesh m_Mesh; // 0x300
		private bool m_AllowInput; // 0x308
		private bool m_ShouldActivateNextUpdate; // 0x309
		private bool m_UpdateDrag; // 0x30A
		private bool m_DragPositionOutOfBounds; // 0x30B
		private const float kHScrollSpeed = 0.05f; // Metadata: 0x02640C4D
		private const float kVScrollSpeed = 0.1f; // Metadata: 0x02640C51
		protected bool m_CaretVisible; // 0x30C
		private Coroutine m_BlinkCoroutine; // 0x310
		private float m_BlinkStartTime; // 0x318
		private Coroutine m_DragCoroutine; // 0x320
		private string m_OriginalText; // 0x328
		private bool m_WasCanceled; // 0x330
		private bool m_HasDoneFocusTransition; // 0x331
		private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x338
		private bool m_PreventCallback; // 0x340
		private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x341
		private bool m_IsTextComponentUpdateRequired; // 0x342
		private bool m_isLastKeyBackspace; // 0x343
		private float m_PointerDownClickStartTime; // 0x344
		private float m_KeyDownStartTime; // 0x348
		private float m_DoubleClickDelay; // 0x34C
		private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~"; // Metadata: 0x02640C55
		private bool m_IsCompositionActive; // 0x350
		private bool m_ShouldUpdateIMEWindowPosition; // 0x351
		private int m_PreviousIMEInsertionLine; // 0x354
		public Func<string, int, string> onValidateCharacterLimit; // 0x358
		public Func<string, int> onGetTextLength; // 0x360
		[SerializeField]
		protected bool m_OnFocusSelectAll; // 0x368
		protected bool m_isSelectAll; // 0x369
		[SerializeField]
		protected bool m_ResetOnDeActivation; // 0x36A
		private bool m_SelectionStillActive; // 0x36B
		private bool m_ReleaseSelection; // 0x36C
		private GameObject m_PreviouslySelectedObject; // 0x370
		[SerializeField]
		private bool m_RestoreOriginalTextOnEscape; // 0x378
		[SerializeField]
		private bool m_WontReleaseSelectionOnEscape; // 0x379
		private bool m_tempClearCompositionString; // 0x37A
		[SerializeField]
		protected bool m_isRichTextEditingAllowed; // 0x37B
		[SerializeField]
		protected int m_LineLimit; // 0x37C
		[SerializeField]
		protected TMP_InputValidator m_InputValidator; // 0x380
		private bool m_isSelected; // 0x388
		private bool m_IsStringPositionDirty; // 0x389
		private bool m_IsCaretPositionDirty; // 0x38A
		private bool m_forceRectTransformAdjustment; // 0x38B
		private UnityEngine.Event m_ProcessingEvent; // 0x390
	
		// Properties
		public bool isLastKeyBackspace { get; set; } // 0x000000018725F330-0x000000018725F340 0x000000018725F3F0-0x000000018725F400
		private BaseInput inputSystem { get; } // 0x000000018503BB40-0x000000018503BC40 
		private string compositionString { get; } // 0x000000018503B7A0-0x000000018503B860 
		private int compositionLength { get; } // 0x000000018503B670-0x000000018503B6A0 
		protected Mesh mesh { get; } // 0x00000001856BA550-0x00000001856BA610 
		public bool shouldHideMobileInput { get; set; } // 0x000000018D42F008-0x000000018D42F038 0x000000018D42FA44-0x000000018D42FAB0
		public bool shouldHideSoftKeyboard { get; set; } // 0x000000018D42F038-0x000000018D42F08C 0x000000018D42FAB0-0x000000018D42FBC8
		public string text { get; set; } // 0x000000018723BD60-0x000000018723BD70 0x0000000186A24DD0-0x0000000186A24DE0
		public bool isFocused { get; } // 0x0000000182939C30-0x0000000182939C40 
		public float caretBlinkRate { get; set; } // 0x000000018725F2B0-0x000000018725F2C0 0x000000018D42F0E8-0x000000018D42F150
		public int caretWidth { get; set; } // 0x000000018725F2C0-0x000000018725F2D0 0x000000018D42F1C8-0x000000018D42F224
		public RectTransform textViewport { get; set; } // 0x000000018723BE20-0x000000018723BE30 0x000000018D42FC5C-0x000000018D42FCA8
		public TMP_Text textComponent { get; set; } // 0x000000018723BC50-0x000000018723BC60 0x000000018D42FC00-0x000000018D42FC5C
		public Graphic placeholder { get; set; } // 0x000000018723BCA0-0x000000018723BCB0 0x000000018D42F7C4-0x000000018D42F810
		public Scrollbar verticalScrollbar { get; set; } // 0x000000018723BD70-0x000000018723BD80 0x000000018D42FCA8-0x000000018D42FE44
		public float scrollSensitivity { get; set; } // 0x000000018725F3A0-0x000000018725F3B0 0x000000018D42F8B8-0x000000018D42F914
		public UnityEngine.Color caretColor { get; set; } // 0x00000001856BBEC0-0x00000001856BBF10 0x000000018D42F150-0x000000018D42F190
		public bool customCaretColor { get; set; } // 0x000000018725F300-0x000000018725F310 0x000000018D42F2E4-0x000000018D42F2FC
		public UnityEngine.Color selectionColor { get; set; } // 0x000000018725F3B0-0x000000018725F3C0 0x000000018D42F950-0x000000018D42F990
		public SubmitEvent onEndEdit { get; set; } // 0x000000018723BEB0-0x000000018723BEC0 0x000000018D42F564-0x000000018D42F5B0
		public SubmitEvent onSubmit { get; set; } // 0x000000018723C1C0-0x000000018723C1D0 0x000000018D42F694-0x000000018D42F6E0
		public SelectionEvent onSelect { get; set; } // 0x000000018723BCE0-0x000000018723BCF0 0x000000018D42F648-0x000000018D42F694
		public SelectionEvent onDeselect { get; set; } // 0x000000018723C030-0x000000018723C040 0x000000018D42F518-0x000000018D42F564
		public TextSelectionEvent onTextSelection { get; set; } // 0x000000018723BA70-0x000000018723BA80 0x000000018D42F6E0-0x000000018D42F72C
		public TextSelectionEvent onEndTextSelection { get; set; } // 0x000000018723B4A0-0x000000018723B4B0 0x000000018D42F5B0-0x000000018D42F5FC
		public OnChangeEvent onValueChanged { get; set; } // 0x000000018723C1F0-0x000000018723C200 0x000000018D42F778-0x000000018D42F7C4
		public TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get; set; } // 0x000000018723C250-0x000000018723C260 0x000000018D42F72C-0x000000018D42F778
		public OnValidateInput onValidateInput { get; set; } // 0x000000018723BF60-0x000000018723BF70 0x00000001856B8DB0-0x00000001856B8E00
		public UnityEvent onFocused { get; set; } // 0x000000018723C0F0-0x000000018723C100 0x000000018D42F5FC-0x000000018D42F648
		public int characterLimit { get; set; } // 0x000000018725F2D0-0x000000018725F2E0 0x0000000186912C20-0x0000000186912CC0
		public float pointSize { get; set; } // 0x000000018723F060-0x000000018723F070 0x000000018D42F810-0x000000018D42F8A8
		public bool onFocusSelectAll { get; set; } // 0x000000018725F360-0x000000018725F370 0x000000018725F410-0x000000018725F420
		public bool resetOnDeActivation { get; set; } // 0x000000018725F370-0x000000018725F380 0x000000018725F420-0x000000018725F430
		public bool restoreOriginalTextOnEscape { get; set; } // 0x000000018725F380-0x000000018725F390 0x000000018725F430-0x000000018725F440
		public bool wontReleaseSelectionOnEscape { get; set; } // 0x000000018725F3D0-0x000000018725F3E0 0x000000018725F440-0x000000018725F450
		public bool disableArrowKeyMoveCaret { get; set; } // 0x000000018725F310-0x000000018725F320 0x000000018725F3E0-0x000000018725F3F0
		public bool isRichTextEditingAllowed { get; set; } // 0x000000018725F340-0x000000018725F350 0x000000018725F400-0x000000018725F410
		public ContentType contentType { get; set; } // 0x000000018725F2F0-0x000000018725F300 0x000000018D42F288-0x000000018D42F2E4
		public LineType lineType { get; set; } // 0x0000000187258070-0x0000000187258080 0x000000018D42F474-0x000000018D42F518
		public int lineLimit { get; set; } // 0x000000018725F350-0x000000018725F360 0x000000018D42F414-0x000000018D42F474
		public InputType inputType { get; set; } // 0x000000018725F320-0x000000018725F330 0x000000018D42F2FC-0x000000018D42F358
		public TouchScreenKeyboardType keyboardType { get; set; } // 0x0000000187258080-0x0000000187258090 0x000000018D42F3B8-0x000000018D42F414
		public CharacterValidation characterValidation { get; set; } // 0x000000018725F2E0-0x000000018725F2F0 0x000000018D42F224-0x000000018D42F280
		public TMP_InputValidator inputValidator { get; set; } // 0x000000018723BDD0-0x000000018723BDE0 0x000000018D42F358-0x000000018D42F3B8
		public bool readOnly { get; set; } // 0x000000018723DB70-0x000000018723DB80 0x000000018723DBD0-0x000000018723DBE0
		public bool richText { get; set; } // 0x000000018725F390-0x000000018725F3A0 0x000000018D42F8A8-0x000000018D42F8B8
		public bool multiLine { get; } // 0x0000000185A06140-0x0000000185A06160 
		public char asteriskChar { get; set; } // 0x000000018725F2A0-0x000000018725F2B0 0x000000018D42F08C-0x000000018D42F0E8
		public bool wasCanceled { get; } // 0x000000018725F3C0-0x000000018725F3D0 
		protected int caretPositionInternal { get; set; } // 0x00000001856BBEA0-0x00000001856BBEC0 0x0000000187838E30-0x0000000187838E48
		protected int stringPositionInternal { get; set; } // 0x00000001856BB200-0x00000001856BB220 0x0000000187838E48-0x0000000187838E60
		protected int caretSelectPositionInternal { get; set; } // 0x0000000185A04250-0x0000000185A04270 0x0000000187838E60-0x0000000187838E78
		protected int stringSelectPositionInternal { get; set; } // 0x00000001856BB1E0-0x00000001856BB200 0x0000000187838E78-0x0000000187838E90
		private new bool hasSelection { get; } // 0x00000001856BB1B0-0x00000001856BB1E0 
		public int caretPosition { get; set; } // 0x00000001878372C0-0x00000001878372C8 0x000000018D42F190-0x000000018D42F1C8
		public int selectionAnchorPosition { get; set; } // 0x00000001878372B8-0x00000001878372C0 0x000000018D42F914-0x000000018D42F950
		public int selectionFocusPosition { get; set; } // 0x00000001878372C0-0x00000001878372C8 0x000000018D42F990-0x000000018D42F9CC
		public int stringPosition { get; set; } // 0x000000018D42F000-0x000000018D42F008 0x000000018D42FBC8-0x000000018D42FC00
		public int selectionStringAnchorPosition { get; set; } // 0x000000018D42EFF8-0x000000018D42F000 0x000000018D42F9CC-0x000000018D42FA08
		public int selectionStringFocusPosition { get; set; } // 0x000000018D42F000-0x000000018D42F008 0x000000018D42FA08-0x000000018D42FA44
		private static string clipboard { get; set; } // 0x000000018D42EFF0-0x000000018D42EFF8 0x000000018D42F280-0x000000018D42F288
		public virtual float minWidth { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		public virtual float preferredWidth { get; } // 0x0000000186E0FC20-0x0000000186E0FE00 
		public virtual float flexibleWidth { get; } // 0x0000000187257DF0-0x0000000187257E00 
		public virtual float minHeight { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		public virtual float preferredHeight { get; } // 0x0000000186E0FE00-0x0000000186E0FFE0 
		public virtual float flexibleHeight { get; } // 0x0000000187257DF0-0x0000000187257E00 
		public virtual int layoutPriority { get; } // 0x00000001872328C0-0x00000001872328D0 
		Transform ICanvasElement.transform { get; } // 0x0000000187834814-0x000000018783481C 
	
		// Nested types
		public enum ContentType // TypeDefIndex: 82394
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
	
		public enum InputType // TypeDefIndex: 82395
		{
			Standard = 0,
			AutoCorrect = 1,
			Password = 2
		}
	
		public enum CharacterValidation // TypeDefIndex: 82396
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
	
		public enum LineType // TypeDefIndex: 82397
		{
			SingleLine = 0,
			MultiLineSubmit = 1,
			MultiLineNewline = 2
		}
	
		public delegate char OnValidateInput(string text, int charIndex, char addedChar); // TypeDefIndex: 82398; 0x00000001811DF7F0-0x00000001811DF810
	
		[Serializable]
		public class SubmitEvent : UnityEvent<string> // TypeDefIndex: 82399
		{
			// Constructors
			public SubmitEvent(); // 0x0000000185E791A0-0x0000000185E791E0
		}
	
		[Serializable]
		public class OnChangeEvent : UnityEvent<string> // TypeDefIndex: 82400
		{
			// Constructors
			public OnChangeEvent(); // 0x0000000185E78D90-0x0000000185E78DD0
		}
	
		[Serializable]
		public class SelectionEvent : UnityEvent<string> // TypeDefIndex: 82401
		{
			// Constructors
			public SelectionEvent(); // 0x0000000185E791E0-0x0000000185E79220
		}
	
		[Serializable]
		public class TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 82402
		{
			// Constructors
			public TextSelectionEvent(); // 0x0000000185E79220-0x0000000185E79260
		}
	
		[Serializable]
		public class TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 82403
		{
			// Constructors
			public TouchScreenKeyboardEvent(); // 0x0000000185E792C0-0x0000000185E79300
		}
	
		protected enum EditState // TypeDefIndex: 82404
		{
			Continue = 0,
			Finish = 1
		}
	
		[CompilerGenerated]
		private sealed class _CaretBlink_d__291 : IEnumerator<object> // TypeDefIndex: 82405
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TMP_InputField __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _CaretBlink_d__291(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001856BB060-0x00000001856BB1B0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D431AE0-0x000000018D431B2C
		}
	
		[CompilerGenerated]
		private sealed class _MouseDragOutsideRect_d__309 : IEnumerator<object> // TypeDefIndex: 82406
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TMP_InputField __4__this; // 0x20
			public PointerEventData eventData; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _MouseDragOutsideRect_d__309(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000185A042C0-0x0000000185A044D0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D431B2C-0x000000018D431B78
		}
	
		// Constructors
		protected TMP_InputField(); // 0x0000000185E78DD0-0x0000000185E791A0
		static TMP_InputField(); // 0x00000001871768E0-0x0000000187176970
	
		// Methods
		private bool isKeyboardUsingEvents(); // 0x00000001856BA8A0-0x00000001856BA8D0
		public void SetTextWithoutNotify(string input); // 0x000000018D42E684-0x000000018D42E690
		private void SetText(string value, bool sendCallback = true /* Metadata: 0x02640C4B */); // 0x0000000186A24DE0-0x0000000186A24F20
		protected void ClampStringPos(ref int pos); // 0x0000000186E2A900-0x0000000186E2A940
		protected void ClampCaretPos(ref int pos); // 0x0000000186A14C80-0x0000000186A14CD0
		protected override void OnEnable(); // 0x0000000185A080A0-0x0000000185A08950
		protected override void OnDisable(); // 0x0000000185A07B90-0x0000000185A08010
		private void ON_TEXT_CHANGED(UnityEngine.Object obj); // 0x00000001858622B0-0x00000001858623B0
		[IteratorStateMachine(typeof(_CaretBlink_d__291))]
		private IEnumerator CaretBlink(); // 0x00000001870F3760-0x00000001870F37C0
		private void SetCaretVisible(); // 0x0000000185A08B80-0x0000000185A08BC0
		private void SetCaretActive(); // 0x0000000185A08B10-0x0000000185A08B80
		protected void OnFocus(); // 0x00000001856B7DB0-0x00000001856B7DF0
		protected void SelectAll(); // 0x0000000185A04270-0x0000000185A042C0
		public void MoveTextEnd(bool shift); // 0x000000018D42D5FC-0x000000018D42D6CC
		public void MoveTextStart(bool shift); // 0x000000018D42D6CC-0x000000018D42D770
		public void MoveToEndOfLine(bool shift, bool ctrl); // 0x000000018D42D770-0x000000018D42D8C0
		public void MoveToStartOfLine(bool shift, bool ctrl); // 0x000000018D42D8C0-0x000000018D42DA44
		private bool InPlaceEditing(); // 0x00000001856BA900-0x00000001856BA960
		private void UpdateStringPositionFromKeyboard(); // 0x000000018D42E7D4-0x000000018D42E8CC
		protected virtual void LateUpdate(); // 0x00000001856BA790-0x00000001856BA8A0
		private bool MayDrag(PointerEventData eventData); // 0x0000000185A044D0-0x0000000185A045B0
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x0000000186C1DB80-0x0000000186C1DBB0
		public virtual void OnDrag(PointerEventData eventData); // 0x0000000185F2CB50-0x0000000185F2CDA0
		[IteratorStateMachine(typeof(_MouseDragOutsideRect_d__309))]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData); // 0x0000000185F2C4C0-0x0000000185F2C540
		public virtual void OnEndDrag(PointerEventData eventData); // 0x0000000186B29F50-0x0000000186B29F80
		public override void OnPointerDown(PointerEventData eventData); // 0x0000000185A045B0-0x0000000185A04920
		protected EditState KeyPressed(UnityEngine.Event evt); // 0x0000000185A061C0-0x0000000185A06330
		protected virtual bool IsValidChar(char c); // 0x0000000185A06160-0x0000000185A06180
		public void ProcessEvent(UnityEngine.Event e); // 0x000000018D42E3C4-0x000000018D42E3CC
		public virtual void OnUpdateSelected(BaseEventData eventData); // 0x0000000185A07800-0x0000000185A07910
		public virtual void OnScroll(PointerEventData eventData); // 0x000000018D42DB74-0x000000018D42DCF4
		private float GetScrollPositionRelativeToViewport(); // 0x000000018D42C544-0x000000018D42C64C
		private string GetSelectedString(); // 0x000000018D42C64C-0x000000018D42C6D8
		private int FindNextWordBegin(); // 0x000000018D42C268-0x000000018D42C324
		private void MoveRight(bool shift, bool ctrl); // 0x000000018D42D2F0-0x000000018D42D5FC
		private int FindPrevWordBegin(); // 0x000000018D42C324-0x000000018D42C3D8
		private void MoveLeft(bool shift, bool ctrl); // 0x0000000185A04160-0x0000000185A04250
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar); // 0x000000018D42C9A4-0x000000018D42CBF8
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar); // 0x000000018D42C72C-0x000000018D42C9A4
		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar); // 0x000000018D42E0BC-0x000000018D42E3C4
		private int PageDownCharacterPosition(int originalPos, bool goToLastChar); // 0x000000018D42DD7C-0x000000018D42E0BC
		private void MoveDown(bool shift); // 0x000000018D42CD44-0x000000018D42CD50
		private void MoveDown(bool shift, bool goToLastChar); // 0x000000018D42CBF8-0x000000018D42CD44
		private void MoveUp(bool shift); // 0x000000018D42DA44-0x000000018D42DA50
		private void MoveUp(bool shift, bool goToFirstChar); // 0x000000018D42DA50-0x000000018D42DB74
		private void MovePageUp(bool shift); // 0x000000018D42D2E4-0x000000018D42D2F0
		private void MovePageUp(bool shift, bool goToFirstChar); // 0x000000018D42D02C-0x000000018D42D2E4
		private void MovePageDown(bool shift); // 0x000000018D42D020-0x000000018D42D02C
		private void MovePageDown(bool shift, bool goToLastChar); // 0x000000018D42CD50-0x000000018D42D020
		private void Delete(); // 0x00000001856B9D50-0x00000001856B9EC0
		private void DeleteKey(); // 0x000000018D42BF10-0x000000018D42C134
		private void Backspace(); // 0x000000018D42BC2C-0x000000018D42BF10
		protected virtual void Append(string input); // 0x000000018D42BBA4-0x000000018D42BC2C
		protected virtual void Append(char input); // 0x00000001856BA200-0x00000001856BA2D0
		private void Insert(char c); // 0x00000001856B9EC0-0x00000001856BA010
		private void UpdateTouchKeyboardFromEditChanges(); // 0x00000001856BA180-0x00000001856BA1A0
		private void SendOnValueChangedAndUpdateLabel(); // 0x000000018D42E41C-0x000000018D42E43C
		private void SendOnValueChanged(); // 0x00000001856BA1A0-0x00000001856BA200
		protected void SendOnEndEdit(); // 0x00000001856B7C40-0x00000001856B7CA0
		protected void SendOnSubmit(); // 0x000000018D42E3CC-0x000000018D42E41C
		protected virtual void SendOnFocus(); // 0x0000000186E4BA30-0x0000000186E4BA90
		protected virtual void SendOnFocusLost(); // 0x0000000186EDFA60-0x0000000186EDFAC0
		protected void SendOnTextSelection(); // 0x00000001856B99F0-0x00000001856B9A90
		protected void SendOnEndTextSelection(); // 0x00000001856BB220-0x00000001856BB2B0
		protected void SendTouchScreenKeyboardStatusChanged(); // 0x000000018D42E43C-0x000000018D42E4AC
		protected void UpdateLabel(); // 0x0000000185A08BC0-0x0000000185A09030
		private void UpdateScrollbar(); // 0x000000018D42E6F8-0x000000018D42E7D4
		private void OnScrollbarValueChange(float value); // 0x000000018D42DCF4-0x000000018D42DD34
		private void UpdateMaskRegions(); // 0x0000000186805BA0-0x0000000186805BB0
		private void AdjustTextPositionRelativeToViewport(float relativePosition); // 0x000000018D42B97C-0x000000018D42BBA4
		private int GetCaretPositionFromStringIndex(int stringIndex); // 0x00000001856BD270-0x00000001856BD300
		private int GetMinCaretPositionFromStringIndex(int stringIndex); // 0x000000018D42C470-0x000000018D42C544
		private int GetMaxCaretPositionFromStringIndex(int stringIndex); // 0x000000018D42C3E0-0x000000018D42C470
		private int GetStringIndexFromCaretPosition(int caretPosition); // 0x000000018D42C6D8-0x000000018D42C72C
		public void ForceLabelUpdate(); // 0x000000018D42C3D8-0x000000018D42C3E0
		private void MarkGeometryAsDirty(); // 0x0000000185A09C30-0x0000000185A09C60
		public virtual void Rebuild(CanvasUpdate update); // 0x00000001856BA470-0x00000001856BA480
		public virtual void LayoutComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void GraphicUpdateComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		private void UpdateGeometry(); // 0x00000001856BA480-0x00000001856BA550
		private void AssignPositioningIfNeeded(); // 0x00000001867AFB30-0x00000001867B0050
		private void OnFillVBO(Mesh vbo); // 0x00000001856BA9A0-0x00000001856BB060
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset); // 0x00000001856BB2B0-0x00000001856BBCC0
		private void CreateCursorVerts(); // 0x00000001856BA2D0-0x00000001856BA470
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset); // 0x00000001856BCB20-0x00000001856BD1C0
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible); // 0x00000001856BBF10-0x00000001856BC2B0
		protected char Validate(string text, int pos, char ch); // 0x000000018D42E8CC-0x000000018D42EFF0
		public virtual void ActivateInputField(); // 0x00000001856B8F90-0x00000001856B9110
		protected virtual bool TryActivateInputFieldCustom(); // 0x00000001843FFFF0-0x0000000184400000
		protected void CompleteActivation(); // 0x00000001856B7CF0-0x00000001856B7D40
		private void ActivateInputFieldInternal(); // 0x00000001856B9A90-0x00000001856B9CD0
		public override void OnSelect(BaseEventData eventData); // 0x0000000186EBA960-0x0000000186EBA9A0
		public virtual void OnPointerClick(PointerEventData eventData); // 0x0000000185032BA0-0x0000000185032BE0
		public void OnControlClick(); // 0x0000000186805BA0-0x0000000186805BB0
		public void ReleaseSelection(); // 0x00000001856B7CA0-0x00000001856B7CF0
		public virtual void DeactivateInputField(bool clearSelection = false /* Metadata: 0x02640C4C */); // 0x00000001856B8390-0x00000001856B87C0
		public override void OnDeselect(BaseEventData eventData); // 0x0000000186E7B020-0x0000000186E7B060
		public virtual void OnSubmit(BaseEventData eventData); // 0x000000018D42DD34-0x000000018D42DD7C
		private void EnforceContentType(); // 0x000000018D42C134-0x000000018D42C268
		private void SetTextComponentWrapMode(); // 0x0000000185E79300-0x0000000185E793A0
		private void SetTextComponentRichTextMode(); // 0x000000018D42E60C-0x000000018D42E684
		private void SetToCustomIfContentTypeIsNot(params ContentType[] allowedContentTypes); // 0x000000018D42E690-0x000000018D42E6E0
		private void SetToCustom(); // 0x000000018D42E6E0-0x000000018D42E6F8
		private void SetToCustom(CharacterValidation characterValidation); // 0x000000018D42E6E0-0x000000018D42E6F8
		protected override void DoStateTransition(SelectionState state, bool instant); // 0x0000000186CD9750-0x0000000186CD9780
		public virtual void CalculateLayoutInputHorizontal(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void CalculateLayoutInputVertical(); // 0x0000000186805BA0-0x0000000186805BB0
		public void SetGlobalPointSize(float pointSize); // 0x000000018D42E55C-0x000000018D42E60C
		public void SetGlobalFontAsset(TMP_FontAsset fontAsset); // 0x000000018D42E4AC-0x000000018D42E55C
	}

	internal static class SetPropertyUtility // TypeDefIndex: 82408
	{
		// Methods
		public static bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue); // 0x000000018D42B600-0x000000018D42B640
		public static bool SetEquatableStruct<T>(ref ref T currentValue, T newValue)
			where T : IEquatable<T>;
		public static bool SetStruct<T>(ref ref T currentValue, T newValue)
			where T : struct;
		public static bool SetClass<T>(ref ref T currentValue, T newValue)
			where T : class;
	}

	[Serializable]
	public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 82409
	{
		// Constructors
		protected TMP_InputValidator(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public abstract char Validate(ref string text, ref int pos, char ch);
	}

	public struct TMP_LineInfo // TypeDefIndex: 82410
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

	internal static class TMP_ListPool<T> // TypeDefIndex: 82412
	{
		// Fields
		private static readonly TMP_ObjectPool<List<T>> s_ListPool;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 82411
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

	public static class TMP_MaterialManager // TypeDefIndex: 82419
	{
		// Fields
		private static List<MaskingMaterial> m_materialList; // 0x00
		private static Dictionary<long, FallbackMaterial> m_fallbackMaterials; // 0x08
		private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
		private static List<FallbackMaterial> m_fallbackCleanupList; // 0x18
		private static bool isFallbackListDirty; // 0x20
		private static string s_overlayShaderKeyword; // 0x28
	
		// Properties
		public static string overlayShaderKeyword { get; set; } // 0x000000018D431A30-0x000000018D431A80 0x000000018D431A80-0x000000018D431AE0
	
		// Nested types
		private class FallbackMaterial // TypeDefIndex: 82413
		{
			// Fields
			public long fallbackID; // 0x10
			public Material sourceMaterial; // 0x18
			internal int sourceMaterialCRC; // 0x20
			public Material fallbackMaterial; // 0x28
			public int count; // 0x30
	
			// Constructors
			public FallbackMaterial(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private class MaskingMaterial // TypeDefIndex: 82414
		{
			// Fields
			public Material baseMaterial; // 0x10
			public Material stencilMaterial; // 0x18
			public int count; // 0x20
			public int stencilID; // 0x24
	
			// Constructors
			public MaskingMaterial(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 82415
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetBaseMaterial_b__0(MaskingMaterial item); // 0x000000018D4457C8-0x000000018D44582C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 82416
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _AddMaskingMaterial_b__0(MaskingMaterial item); // 0x000000018D44582C-0x000000018D445890
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 82417
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _RemoveStencilMaterial_b__0(MaskingMaterial item); // 0x000000018D445890-0x000000018D4458F4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 82418
		{
			// Fields
			public Material baseMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass17_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _ReleaseBaseMaterial_b__0(MaskingMaterial item); // 0x000000018D4458F4-0x000000018D445958
		}
	
		// Constructors
		static TMP_MaterialManager(); // 0x0000000186E0A1A0-0x0000000186E0A3F0
	
		// Methods
		private static void OnPreRender(); // 0x000000018631E160-0x000000018631E1C0
		public static Material GetStencilMaterial(Material baseMaterial, int stencilID); // 0x000000018D430CA8-0x000000018D431020
		public static void ReleaseStencilMaterial(Material stencilMaterial); // 0x000000018D4314C8-0x000000018D4316BC
		public static Material GetBaseMaterial(Material stencilMaterial); // 0x000000018D4305D4-0x000000018D430720
		public static Material SetStencil(Material material, int stencilID); // 0x000000018D431974-0x000000018D431A30
		public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID); // 0x000000018D42FE44-0x000000018D430080
		public static void RemoveStencilMaterial(Material stencilMaterial); // 0x000000018D431838-0x000000018D431974
		public static void ReleaseBaseMaterial(Material baseMaterial); // 0x000000018D431020-0x000000018D4314C8
		public static void ClearMaterials(); // 0x000000018D430080-0x000000018D4301F0
		public static int GetStencilID(GameObject obj); // 0x000000018D430A48-0x000000018D430CA8
		public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial); // 0x00000001852E0FC0-0x00000001852E11F0
		private static Transform FindRootSortOverrideCanvas(Transform start); // 0x000000018D430488-0x000000018D4305D4
		internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex); // 0x000000018D430720-0x000000018D430A48
		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial); // 0x0000000185A070D0-0x0000000185A07570
		public static void AddFallbackMaterialReference(Material targetMaterial); // 0x0000000185A06F30-0x0000000185A070D0
		public static void RemoveFallbackMaterialReference(Material targetMaterial); // 0x000000018D4316BC-0x000000018D431838
		public static void CleanupFallbackMaterials(); // 0x000000018631E1C0-0x000000018631E440
		public static void ReleaseFallbackMaterial(Material fallbackMaterial); // 0x0000000185A06A80-0x0000000185A06CD0
		public static void CopyMaterialPresetProperties(Material source, Material destination); // 0x000000018D4301F0-0x000000018D430488
	}

	public enum VertexSortingOrder // TypeDefIndex: 82420
	{
		Normal = 0,
		Reverse = 1
	}

	public struct TMP_MeshInfo : IDisposable // TypeDefIndex: 82421
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
		public TMP_MeshInfo(Mesh mesh, int size); // 0x00000001850DEC50-0x00000001850DF590
		public TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric); // 0x000000018D43C49C-0x000000018D43CE90
		static TMP_MeshInfo(); // 0x0000000186FD6890-0x0000000186FD6930
	
		// Methods
		public void ResizeMeshInfo(int size); // 0x0000000185CD05B0-0x0000000185CD0B40
		public void ResizeMeshInfo(int size, bool isVolumetric); // 0x000000018D43AF44-0x000000018D43BAAC
		public void Clear(); // 0x000000018D43AEB0-0x000000018D43AF44
		public void Clear(bool uploadChanges); // 0x00000001855AF6C0-0x00000001855AF8E0
		public void ClearUnusedVertices(); // 0x0000000186A8E7C0-0x0000000186A8E800
		public void ClearUnusedVertices(int startIndex); // 0x000000018D43ADD4-0x000000018D43AE08
		public void ClearUnusedVertices(int startIndex, bool updateMesh); // 0x000000018D43AE08-0x000000018D43AEB0
		public void SortGeometry(VertexSortingOrder order); // 0x000000018D43BAAC-0x000000018D43BB50
		public void SortGeometry(IList<int> sortingOrder); // 0x000000018D43BB50-0x000000018D43BC4C
		public void SwapVertexData(int src, int dst); // 0x000000018D43BC4C-0x000000018D43C49C
		public void Dispose(); // 0x00000001852F0480-0x00000001852F0600
	}

	internal class TMP_ObjectPool<T> // TypeDefIndex: 82422
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

	public class TMP_ResourceManager // TypeDefIndex: 82423
	{
		// Fields
		private static readonly TMP_ResourceManager s_instance; // 0x00
		private static TMP_Settings s_TextSettings; // 0x08
		private static readonly List<TMP_FontAsset> s_FontAssetReferences; // 0x10
		private static readonly Dictionary<int, TMP_FontAsset> s_FontAssetReferenceLookup; // 0x18
	
		// Constructors
		static TMP_ResourceManager(); // 0x000000018D43D1FC-0x000000018D43D330
		public TMP_ResourceManager(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		internal static TMP_Settings GetTextSettings(); // 0x000000018D43CF8C-0x000000018D43D07C
		public static void AddFontAsset(TMP_FontAsset fontAsset); // 0x000000018D43CE90-0x000000018D43CF8C
		public static bool TryGetFontAsset(int hashcode, out TMP_FontAsset fontAsset); // 0x000000018D43D170-0x000000018D43D1FC
		internal static void RebuildFontAssetCache(int instanceID); // 0x000000018D43D07C-0x000000018D43D170
	}

	internal enum MarkupTag // TypeDefIndex: 82424
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

	public enum TagValueType // TypeDefIndex: 82425
	{
		None = 0,
		NumericalValue = 1,
		StringValue = 2,
		ColorValue = 4
	}

	public enum TagUnitType // TypeDefIndex: 82426
	{
		Pixels = 0,
		FontUnits = 1,
		Percentage = 2
	}

	internal static class CodePoint // TypeDefIndex: 82427
	{
		// Fields
		public const uint SPACE = 32; // Metadata: 0x02640E8C
		public const uint DOUBLE_QUOTE = 34; // Metadata: 0x02640E8D
		public const uint NUMBER_SIGN = 35; // Metadata: 0x02640E8E
		public const uint PERCENTAGE = 37; // Metadata: 0x02640E8F
		public const uint PLUS = 43; // Metadata: 0x02640E90
		public const uint MINUS = 45; // Metadata: 0x02640E91
		public const uint PERIOD = 46; // Metadata: 0x02640E92
		public const uint HYPHEN_MINUS = 45; // Metadata: 0x02640E93
		public const uint SOFT_HYPHEN = 173; // Metadata: 0x02640E94
		public const uint HYPHEN = 8208; // Metadata: 0x02640E96
		public const uint NON_BREAKING_HYPHEN = 8209; // Metadata: 0x02640E98
		public const uint ZERO_WIDTH_SPACE = 8203; // Metadata: 0x02640E9A
		public const uint RIGHT_SINGLE_QUOTATION = 8217; // Metadata: 0x02640E9C
		public const uint APOSTROPHE = 39; // Metadata: 0x02640E9E
		public const uint WORD_JOINER = 8288; // Metadata: 0x02640E9F
		public const uint HIGH_SURROGATE_START = 55296; // Metadata: 0x02640EA1
		public const uint HIGH_SURROGATE_END = 56319; // Metadata: 0x02640EA5
		public const uint LOW_SURROGATE_START = 56320; // Metadata: 0x02640EA9
		public const uint LOW_SURROGATE_END = 57343; // Metadata: 0x02640EAD
		public const uint UNICODE_PLANE01_START = 65536; // Metadata: 0x02640EB1
	}

	public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 82428
	{
		// Fields
		public bool isSelected; // 0x18
	
		// Constructors
		public TMP_ScrollbarEventHandler(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void OnPointerClick(PointerEventData eventData); // 0x000000018D43D388-0x000000018D43D3DC
		public void OnSelect(BaseEventData eventData); // 0x000000018D43D3DC-0x000000018D43D434
		public void OnDeselect(BaseEventData eventData); // 0x000000018D43D330-0x000000018D43D388
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class TMP_SelectionCaret : MaskableGraphic // TypeDefIndex: 82429
	{
		// Constructors
		public TMP_SelectionCaret(); // 0x000000018702CD90-0x000000018702CDA0
	
		// Methods
		public override void Cull(Rect clipRect, bool validRect); // 0x000000018676D650-0x000000018676D6B0
		protected override void UpdateGeometry(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	[ExcludeFromPreset]
	public class TMP_Settings : ScriptableObject // TypeDefIndex: 82431
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
		public static string version { get; } // 0x000000018D43DAF0-0x000000018D43DB1C 
		public static bool enableWordWrapping { get; } // 0x000000018D43D9A0-0x000000018D43D9C0 
		public static bool enableKerning { get; } // 0x000000018D43D920-0x000000018D43D940 
		public static bool enableExtraPadding { get; } // 0x000000018D43D900-0x000000018D43D920 
		public static bool enableTintAllSprites { get; } // 0x000000018D43D980-0x000000018D43D9A0 
		public static bool enableParseEscapeCharacters { get; } // 0x000000018D43D940-0x000000018D43D960 
		public static bool enableRaycastTarget { get; } // 0x000000018D43D960-0x000000018D43D980 
		public static bool getFontFeaturesAtRuntime { get; } // 0x000000018D43DA04-0x000000018D43DA24 
		public static int missingGlyphCharacter { get; set; } // 0x000000018D43DA88-0x000000018D43DAA8 0x000000018D43DBA8-0x000000018D43DBCC
		public static bool warningsDisabled { get; } // 0x000000018D43DB1C-0x000000018D43DB3C 
		public static TMP_FontAsset defaultFontAsset { get; } // 0x000000018D43D7C0-0x000000018D43D7E0 
		public static string defaultFontAssetPath { get; } // 0x000000018D43D7A0-0x000000018D43D7C0 
		public static float defaultFontSize { get; } // 0x000000018D43D7E0-0x000000018D43D800 
		public static float defaultTextAutoSizingMinRatio { get; } // 0x000000018D43D860-0x000000018D43D880 
		public static float defaultTextAutoSizingMaxRatio { get; } // 0x000000018D43D840-0x000000018D43D860 
		public static Vector2 defaultTextMeshProTextContainerSize { get; } // 0x000000018D43D880-0x000000018D43D8B0 
		public static Vector2 defaultTextMeshProUITextContainerSize { get; } // 0x000000018D43D8B0-0x000000018D43D8E0 
		public static bool autoSizeTextContainer { get; } // 0x000000018D43D75C-0x000000018D43D77C 
		public static bool isTextObjectScaleStatic { get; set; } // 0x000000018D43DA24-0x000000018D43DA44 0x000000018D43DB60-0x000000018D43DB84
		public static List<TMP_FontAsset> fallbackFontAssets { get; } // 0x000000018D43D9C0-0x000000018D43D9E0 
		public static bool matchMaterialPreset { get; } // 0x0000000186A3F190-0x0000000186A3F300 
		public static TMP_SpriteAsset defaultSpriteAsset { get; } // 0x000000018D43D820-0x000000018D43D840 
		public static string defaultSpriteAssetPath { get; } // 0x000000018D43D800-0x000000018D43D820 
		public static bool enableEmojiSupport { get; set; } // 0x000000018D43D8E0-0x000000018D43D900 0x000000018D43DB3C-0x000000018D43DB60
		public static uint missingCharacterSpriteUnicode { get; set; } // 0x000000018D43DA68-0x000000018D43DA88 0x000000018D43DB84-0x000000018D43DBA8
		public static string defaultColorGradientPresetsPath { get; } // 0x000000018D43D77C-0x000000018D43D7A0 
		public static TMP_StyleSheet defaultStyleSheet { get; } // 0x00000001852D2980-0x00000001852D2A60 
		public static string styleSheetsResourcePath { get; } // 0x000000018D43DAA8-0x000000018D43DACC 
		public static TextAsset leadingCharacters { get; } // 0x000000018D43DA44-0x000000018D43DA68 
		public static TextAsset followingCharacters { get; } // 0x000000018D43D9E0-0x000000018D43DA04 
		public static LineBreakingTable linebreakingRules { get; } // 0x00000001852D2A60-0x00000001852D2C60 
		public static bool useModernHangulLineBreakingRules { get; set; } // 0x000000018D43DACC-0x000000018D43DAF0 0x000000018D43DBCC-0x000000018D43DBF4
		public static TMP_Settings instance { get; } // 0x00000001852D2C60-0x00000001852D2D40 
	
		// Nested types
		public class LineBreakingTable // TypeDefIndex: 82430
		{
			// Fields
			public Dictionary<int, char> leadingCharacters; // 0x10
			public Dictionary<int, char> followingCharacters; // 0x18
	
			// Constructors
			public LineBreakingTable(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public TMP_Settings(); // 0x000000018722E960-0x000000018722E970
	
		// Methods
		public static TMP_Settings LoadDefaultSettings(); // 0x000000018D43D678-0x000000018D43D75C
		public static TMP_Settings GetSettings(); // 0x000000018D43D540-0x000000018D43D5A0
		public static TMP_FontAsset GetFontAsset(); // 0x000000018D43D4D4-0x000000018D43D540
		public static void ClearDefaultFontAsset(); // 0x000000018D43D434-0x000000018D43D4D4
		public static TMP_SpriteAsset GetSpriteAsset(); // 0x000000018D43D5A0-0x000000018D43D60C
		public static TMP_StyleSheet GetStyleSheet(); // 0x000000018D43D60C-0x000000018D43D678
		public static void LoadLinebreakingRules(); // 0x000000018676A690-0x000000018676A810
		public static IFontAssetLoader GetDynamicFallbackFontAssetLoader(); // 0x0000000186BA2470-0x0000000186BA2520
		private static Dictionary<int, char> GetCharacters(TextAsset file); // 0x000000018676A810-0x000000018676A910
	}

	public static class ShaderUtilities // TypeDefIndex: 82432
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
		public static int ID_UseSDFDisturb; // 0xE0
		public static int ID_UseSDFHalo; // 0xE4
		public static int ID_HaloThickness; // 0xE8
		public static int ID_HaloSoftness; // 0xEC
		public static string Keyword_ClipSceneDepth; // 0xF0
		public static string Keyword_UsedForWorldUI; // 0xF8
		public static string Keyword_Bevel; // 0x100
		public static string Keyword_Glow; // 0x108
		public static string Keyword_Underlay; // 0x110
		public static string Keyword_Ratios; // 0x118
		public static string Keyword_MASK_SOFT; // 0x120
		public static string Keyword_MASK_HARD; // 0x128
		public static string Keyword_MASK_TEX; // 0x130
		public static string Keyword_Outline; // 0x138
		public static string ShaderTag_ZTestMode; // 0x140
		public static string ShaderTag_CullMode; // 0x148
		private static float m_clamp; // 0x150
		public static bool isInitialized; // 0x154
		private static Shader k_ShaderRef_MobileSDF; // 0x158
		private static Shader k_ShaderRef_MobileBitmap; // 0x160
	
		// Properties
		internal static Shader ShaderRef_MobileSDF { get; } // 0x000000018D43ACE8-0x000000018D43ADD4 
		internal static Shader ShaderRef_MobileBitmap { get; } // 0x000000018D43ABFC-0x000000018D43ACE8 
	
		// Constructors
		static ShaderUtilities(); // 0x0000000186D42DE0-0x0000000186D43160
	
		// Methods
		public static void GetShaderPropertyIDs(); // 0x00000001857E7340-0x00000001857E7CE0
		private static void GetFaceEdgePaddingContributions(Material mat, out float thickness, out float softness); // 0x00000001857E70D0-0x00000001857E7340
		public static void UpdateShaderRatios(Material mat); // 0x00000001857E5EB0-0x00000001857E65D0
		public static Vector4 GetFontExtent(Material material); // 0x000000018D43A274-0x000000018D43A294
		public static bool IsMaskingEnabled(Material material); // 0x00000001857E6EB0-0x00000001857E70D0
		public static float GetPadding(Material material, bool enableExtraPadding, bool isBold); // 0x00000001857E65D0-0x00000001857E6EB0
		public static float GetPadding(Material[] materials, bool enableExtraPadding, bool isBold); // 0x000000018D43A294-0x000000018D43ABFC
	}

	[Serializable]
	public class TMP_Sprite : TMP_TextElement_Legacy // TypeDefIndex: 82433
	{
		// Fields
		public string name; // 0x38
		public int hashCode; // 0x40
		public int unicode; // 0x44
		public Vector2 pivot; // 0x48
		public Sprite sprite; // 0x50
	
		// Constructors
		public TMP_Sprite(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[DisallowMultipleComponent]
	public class TMP_SpriteAnimator : MonoBehaviour // TypeDefIndex: 82435
	{
		// Fields
		private Dictionary<int, bool> m_animations; // 0x18
		private TMP_Text m_TextComponent; // 0x20
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DoSpriteAnimationInternal_d__7 : IEnumerator<object> // TypeDefIndex: 82434
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _DoSpriteAnimationInternal_d__7(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D444E5C-0x000000018D44577C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D44577C-0x000000018D4457C8
		}
	
		// Constructors
		public TMP_SpriteAnimator(); // 0x000000018D43DE0C-0x000000018D43DE90
	
		// Methods
		private void Awake(); // 0x000000018D43DBF4-0x000000018D43DC3C
		private void OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnDisable(); // 0x0000000186805BA0-0x0000000186805BB0
		public void StopAllAnimations(); // 0x000000018D43DDBC-0x000000018D43DE0C
		public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate); // 0x000000018D43DCE4-0x000000018D43DDBC
		[IteratorStateMachine(typeof(_DoSpriteAnimationInternal_d__7))]
		private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate); // 0x000000018D43DC3C-0x000000018D43DCE4
	}

	[ExcludeFromPreset]
	public class TMP_SpriteAsset : TMP_Asset // TypeDefIndex: 82437
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
		public string version { get; internal set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public FaceInfo faceInfo { get; internal set; } // 0x000000018725F8E0-0x000000018725F920 0x000000018D43F758-0x000000018D43F798
		public List<TMP_SpriteCharacter> spriteCharacterTable { get; internal set; } // 0x000000018D43F728-0x000000018D43F758 0x0000000185017130-0x0000000185017150
		public Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable { get; internal set; } // 0x000000018D43F6F8-0x000000018D43F728 0x0000000188D80C28-0x0000000188D80C3C
		public List<TMP_SpriteGlyph> spriteGlyphTable { get; internal set; } // 0x0000000187236200-0x0000000187236210 0x0000000188D95540-0x0000000188D95554
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 82436
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<TMP_SpriteGlyph, uint> __9__40_0; // 0x08
			public static Func<TMP_SpriteCharacter, uint> __9__41_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D445958-0x000000018D4459BC
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal uint _SortGlyphTable_b__40_0(TMP_SpriteGlyph item); // 0x000000018CC33418-0x000000018CC33430
			internal uint _SortCharacterTable_b__41_0(TMP_SpriteCharacter c); // 0x000000018D42B2E8-0x000000018D42B300
		}
	
		// Constructors
		public TMP_SpriteAsset(); // 0x000000018D43F624-0x000000018D43F6F8
	
		// Methods
		private void Awake(); // 0x000000018D43DE90-0x000000018D43DF00
		private Material GetDefaultSpriteMaterial(); // 0x000000018D43DF00-0x000000018D43DFD8
		public void UpdateLookupTables(); // 0x000000018D43EDBC-0x000000018D43F2F8
		public int GetSpriteIndexFromHashcode(int hashCode); // 0x000000018D43DFD8-0x000000018D43E058
		public int GetSpriteIndexFromUnicode(uint unicode); // 0x000000018D43E0C4-0x000000018D43E154
		public int GetSpriteIndexFromName(string name); // 0x000000018D43E058-0x000000018D43E0C4
		public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x000000018D43E8A4-0x000000018D43EAC4
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x000000018D43E690-0x000000018D43E7F0
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x000000018D43E7F0-0x000000018D43E8A4
		public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex); // 0x000000018D43E368-0x000000018D43E690
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex); // 0x000000018D43E208-0x000000018D43E368
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex); // 0x000000018D43E154-0x000000018D43E208
		public void SortGlyphTable(); // 0x000000018D43EC50-0x000000018D43EDBC
		internal void SortCharacterTable(); // 0x000000018D43EAC4-0x000000018D43EC30
		internal void SortGlyphAndCharacterTables(); // 0x000000018D43EC30-0x000000018D43EC50
		private void UpgradeSpriteAsset(); // 0x000000018D43F2F8-0x000000018D43F624
	}

	[Serializable]
	public class TMP_SpriteCharacter : TMP_TextElement // TypeDefIndex: 82438
	{
		// Fields
		[SerializeField]
		private string m_Name; // 0x30
		[SerializeField]
		private int m_HashCode; // 0x38
	
		// Properties
		public string name { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018D43F85C-0x000000018D43F8D0
		public int hashCode { get; } // 0x00000001829600C0-0x00000001829600D0 
	
		// Constructors
		public TMP_SpriteCharacter(); // 0x000000018725F920-0x000000018725F930
		public TMP_SpriteCharacter(uint unicode, TMP_SpriteGlyph glyph); // 0x000000018D43F7D8-0x000000018D43F814
		public TMP_SpriteCharacter(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph); // 0x000000018D43F814-0x000000018D43F85C
		internal TMP_SpriteCharacter(uint unicode, uint glyphIndex); // 0x000000018D43F798-0x000000018D43F7D8
	}

	[Serializable]
	public class TMP_SpriteGlyph : Glyph // TypeDefIndex: 82439
	{
		// Fields
		public Sprite sprite; // 0x48
	
		// Constructors
		public TMP_SpriteGlyph(); // 0x000000018D43F9B0-0x000000018D43F9B8
		public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex); // 0x000000018D43F948-0x000000018D43F9B0
		public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex, Sprite sprite); // 0x000000018D43F8D0-0x000000018D43F948
	}

	[Serializable]
	public class TMP_Style // TypeDefIndex: 82440
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
		public static TMP_Style NormalStyle { get; } // 0x000000018D43FA60-0x000000018D43FB40 
		public string name { get; set; } // 0x00000001829260F0-0x0000000182926100 0x000000018D43FB4C-0x000000018D43FB88
		public int hashCode { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018D43FB40-0x000000018D43FB4C
		public string styleOpeningDefinition { get; } // 0x000000018225E800-0x000000018225E810 
		public string styleClosingDefinition { get; } // 0x0000000182262130-0x0000000182262140 
		public int[] styleOpeningTagArray { get; } // 0x00000001829600D0-0x00000001829600E0 
		public int[] styleClosingTagArray { get; } // 0x0000000182986470-0x0000000182986480 
	
		// Constructors
		internal TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition); // 0x00000001864EE880-0x00000001864EE930
	
		// Methods
		public void RefreshStyle(); // 0x00000001864EEBF0-0x00000001864EEE60
	}

	[Serializable]
	[ExcludeFromPreset]
	public class TMP_StyleSheet : ScriptableObject // TypeDefIndex: 82441
	{
		// Fields
		[SerializeField]
		private List<TMP_Style> m_StyleList; // 0x18
		private Dictionary<int, TMP_Style> m_StyleLookupDictionary; // 0x20
	
		// Properties
		internal List<TMP_Style> styles { get; } // 0x0000000182234E30-0x0000000182234E40 
	
		// Constructors
		public TMP_StyleSheet(); // 0x000000018717C270-0x000000018717C300
	
		// Methods
		private void Reset(); // 0x000000018D43FA58-0x000000018D43FA60
		public TMP_Style GetStyle(int hashCode); // 0x00000001852D2D40-0x00000001852D2E70
		public TMP_Style GetStyle(string name); // 0x000000018D43F9B8-0x000000018D43FA58
		public void RefreshStyles(); // 0x000000018D43FA58-0x000000018D43FA60
		private void LoadStyleDictionaryInternal(); // 0x00000001864EE930-0x00000001864EEBF0
	}

	[ExecuteAlways]
	[RequireComponent(typeof(MeshRenderer))]
	public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 82442
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
		public TMP_FontAsset fontAsset { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public Material material { get; set; } // 0x000000018D440D08-0x000000018D440D14 0x000000018D4410C4-0x000000018D441154
		public Material sharedMaterial { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018D441154-0x000000018D44115C
		public Material fallbackMaterial { get; set; } // 0x0000000182986470-0x0000000182986480 0x000000018D440FBC-0x000000018D4410C4
		public Material fallbackSourceMaterial { get; set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public bool isDefaultMaterial { get; set; } // 0x000000018223CB60-0x000000018223CB70 0x000000018223CB70-0x000000018223CB80
		public float padding { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		public Renderer renderer { get; } // 0x000000018D440EB4-0x000000018D440F38 
		public MeshFilter meshFilter { get; } // 0x000000018D440D14-0x000000018D440E08 
		public Mesh mesh { get; set; } // 0x000000018D440E08-0x000000018D440EB4 0x0000000188800CB0-0x0000000188800CC0
		public TMP_Text textComponent { get; } // 0x000000018D440F38-0x000000018D440FBC 
	
		// Constructors
		public TMP_SubMesh(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference); // 0x000000018D4400F0-0x000000018D440450
		private void OnEnable(); // 0x000000018D44095C-0x000000018D440A60
		private void OnDisable(); // 0x000000018D4408B4-0x000000018D44095C
		private void OnDestroy(); // 0x000000018D44079C-0x000000018D4408B4
		public void DestroySelf(); // 0x000000018D440504-0x000000018D44055C
		private Material GetMaterial(Material mat); // 0x000000018D44055C-0x000000018D440688
		private Material CreateMaterialInstance(Material source); // 0x000000018D440450-0x000000018D440504
		private Material GetSharedMaterial(); // 0x000000018D440708-0x000000018D44079C
		private void SetSharedMaterial(Material mat); // 0x000000018D440A68-0x000000018D440A9C
		public float GetPaddingForMaterial(); // 0x000000018D440688-0x000000018D440708
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold); // 0x000000018D440C94-0x000000018D440D08
		public void SetVerticesDirty(); // 0x000000018D440A9C-0x000000018D440B2C
		public void SetMaterialDirty(); // 0x000000018D440A60-0x000000018D440A68
		protected void UpdateMaterial(); // 0x000000018D440B2C-0x000000018D440C94
	}

	[ExecuteAlways]
	[RequireComponent(typeof(CanvasRenderer))]
	public class TMP_SubMeshUI : MaskableGraphic // TypeDefIndex: 82443
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
		public TMP_FontAsset fontAsset { get; set; } // 0x00000001872354B0-0x00000001872354C0 0x0000000188D62F7C-0x0000000188D62F90
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x000000018723C070-0x000000018723C080 0x0000000188DC4AE8-0x0000000188DC4AFC
		public override Texture mainTexture { get; } // 0x000000018D43FF4C-0x000000018D43FFF0 
		public override Material material { get; set; } // 0x000000018D43FFF0-0x000000018D440000 0x000000018D440000-0x000000018D4400E8
		public Material sharedMaterial { get; set; } // 0x0000000187234CE0-0x0000000187234CF0 0x000000018D4400E8-0x000000018D4400F0
		public Material fallbackMaterial { get; set; } // 0x0000000187232D20-0x0000000187232D30 0x0000000185A06CD0-0x0000000185A06E40
		public Material fallbackSourceMaterial { get; set; } // 0x000000018723B410-0x000000018723B420 0x000000018783BFB4-0x000000018783BFC8
		public override Material materialForRendering { get; } // 0x0000000186942780-0x00000001869427F0 
		public bool isDefaultMaterial { get; set; } // 0x0000000187240D90-0x0000000187240DA0 0x0000000187240DA0-0x0000000187240DB0
		public float padding { get; set; } // 0x0000000187234540-0x0000000187234550 0x000000018725F930-0x000000018725F940
		public Mesh mesh { get; set; } // 0x00000001862F4530-0x00000001862F4620 0x000000018783BF50-0x000000018783BF64
		public TMP_Text textComponent { get; } // 0x00000001853A2C50-0x00000001853A2D30 
	
		// Constructors
		public TMP_SubMeshUI(); // 0x000000018702CD90-0x000000018702CDA0
	
		// Methods
		public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference); // 0x0000000185A064B0-0x0000000185A06840
		protected override void OnEnable(); // 0x0000000185276800-0x0000000185276850
		protected override void OnDisable(); // 0x0000000185A06970-0x0000000185A06A80
		protected override void OnDestroy(); // 0x00000001868AA9C0-0x00000001868AAC80
		protected override void OnTransformParentChanged(); // 0x00000001871F9C00-0x00000001871F9C50
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x000000018674CBC0-0x000000018674CC70
		public float GetPaddingForMaterial(); // 0x0000000185A06EA0-0x0000000185A06F30
		public float GetPaddingForMaterial(Material mat); // 0x000000018D43FD48-0x000000018D43FDCC
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold); // 0x000000018D43FED0-0x000000018D43FF4C
		public override void SetAllDirty(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetVerticesDirty(); // 0x00000001868AA8C0-0x00000001868AA9C0
		public override void SetLayoutDirty(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetMaterialDirty(); // 0x000000018697DC20-0x000000018697DC50
		public void SetPivotDirty(); // 0x000000018569CC30-0x000000018569CCB0
		private Transform GetRootCanvasTransform(); // 0x000000018D43FDCC-0x000000018D43FE78
		public override void Cull(Rect clipRect, bool validRect); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void UpdateGeometry(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void Rebuild(CanvasUpdate update); // 0x000000018D43FEA0-0x000000018D43FED0
		public void RefreshMaterial(); // 0x000000018CB260F0-0x000000018CB26100
		protected override void UpdateMaterial(); // 0x00000001853A2A70-0x00000001853A2C50
		public override void RecalculateClipping(); // 0x00000001851BFD90-0x00000001851BFDA0
		private Material GetMaterial(); // 0x0000000187234CE0-0x0000000187234CF0
		private Material GetMaterial(Material mat); // 0x000000018D43FC3C-0x000000018D43FD48
		private Material CreateMaterialInstance(Material source); // 0x000000018D43FB88-0x000000018D43FC3C
		private Material GetSharedMaterial(); // 0x000000018D43FE78-0x000000018D43FEA0
		private void SetSharedMaterial(Material mat); // 0x0000000185A06E40-0x0000000185A06EA0
	}

	public interface ITextElement // TypeDefIndex: 82444
	{
		// Properties
		Material sharedMaterial { get; }
	
		// Methods
		void Rebuild(CanvasUpdate update);
		int GetInstanceID();
	}

	public enum TextAlignmentOptions // TypeDefIndex: 82445
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

	public enum HorizontalAlignmentOptions // TypeDefIndex: 82446
	{
		Left = 1,
		Center = 2,
		Right = 4,
		Justified = 8,
		Flush = 16,
		Geometry = 32
	}

	public enum VerticalAlignmentOptions // TypeDefIndex: 82447
	{
		Top = 256,
		Middle = 512,
		Bottom = 1024,
		Baseline = 2048,
		Geometry = 4096,
		Capline = 8192
	}

	public enum TextRenderFlags // TypeDefIndex: 82448
	{
		DontRender = 0,
		Render = 255
	}

	public enum TMP_TextElementType // TypeDefIndex: 82449
	{
		Character = 0,
		Sprite = 1,
		Image = 2
	}

	public enum MaskingTypes // TypeDefIndex: 82450
	{
		MaskOff = 0,
		MaskHard = 1,
		MaskSoft = 2
	}

	public enum TextOverflowModes // TypeDefIndex: 82451
	{
		Overflow = 0,
		Ellipsis = 1,
		Masking = 2,
		Truncate = 3,
		ScrollRect = 4,
		Page = 5,
		Linked = 6
	}

	public enum MaskingOffsetMode // TypeDefIndex: 82452
	{
		Percentage = 0,
		Pixel = 1
	}

	public enum TextureMappingOptions // TypeDefIndex: 82453
	{
		Character = 0,
		Line = 1,
		Paragraph = 2,
		MatchAspect = 3
	}

	[Flags]
	public enum FontStyles // TypeDefIndex: 82454
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

	public enum FontWeight // TypeDefIndex: 82455
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

	public struct PhoneticCharSlot // TypeDefIndex: 82456
	{
		// Fields
		public TMP_FontAsset fontAsset; // 0x00
		public int materialIndex; // 0x08
		public Glyph glyph; // 0x10
	}

	public class PhoneticData // TypeDefIndex: 82457
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
		public PhoneticData(); // 0x00000001870DC8D0-0x00000001870DC930
		static PhoneticData(); // 0x00000001870DC860-0x00000001870DC8D0
	}

	public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 82467
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
		protected const float m_basePhoneticElementScale = 0.5f; // Metadata: 0x02640F5D
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
		public static bool s_enableAutoSizeCache; // 0x6C
		protected bool m_AutoSizeCacheHit; // 0x665
		protected int m_AutoSizeTextHash; // 0x668
		protected bool m_AutoSizeTextHashValid; // 0x66C
		private static Dictionary<AutoSizeCacheKey, float> s_AutoSizeCache; // 0x70
		public static bool s_enableAutoSizeAccel; // 0x78
		protected bool m_disableAccelAutoSizeByInlineImage; // 0x66D
		public static float s_accelAutoSizeProbeStep; // 0x7C
		protected int m_AccelIterationCount; // 0x670
		protected AutoSizeAccelProbeState m_AccelProbeState; // 0x674
		protected float m_AccelCandidateFontSize; // 0x678
		[SerializeField]
		protected float m_fontSizeMin; // 0x67C
		[SerializeField]
		protected float m_fontSizeMax; // 0x680
		[SerializeField]
		protected FontStyles m_fontStyle; // 0x684
		protected FontStyles m_FontStyleInternal; // 0x688
		protected TMP_FontStyleStack m_fontStyleStack; // 0x68C
		protected bool m_isUsingBold; // 0x696
		[SerializeField]
		protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x698
		[SerializeField]
		protected VerticalAlignmentOptions m_VerticalAlignment; // 0x69C
		[FormerlySerializedAs("m_lineJustification")]
		[SerializeField]
		protected TextAlignmentOptions m_textAlignment; // 0x6A0
		protected HorizontalAlignmentOptions m_lineJustification; // 0x6A4
		protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x6A8
		protected Vector3[] m_textContainerLocalCorners; // 0x6C8
		[SerializeField]
		protected float m_characterSpacing; // 0x6D0
		protected float m_cSpacing; // 0x6D4
		protected float m_monoSpacing; // 0x6D8
		[SerializeField]
		protected float m_wordSpacing; // 0x6DC
		[SerializeField]
		protected float m_lineSpacing; // 0x6E0
		protected float m_lineSpacingDelta; // 0x6E4
		protected float m_lineHeight; // 0x6E8
		protected bool m_IsDrivenLineSpacing; // 0x6EC
		[SerializeField]
		protected float m_lineSpacingMax; // 0x6F0
		[SerializeField]
		protected float m_paragraphSpacing; // 0x6F4
		[SerializeField]
		protected float m_charWidthMaxAdj; // 0x6F8
		protected float m_charWidthAdjDelta; // 0x6FC
		[SerializeField]
		protected bool m_enableWordWrapping; // 0x700
		protected bool m_isCharacterWrappingEnabled; // 0x701
		protected bool m_isNonBreakingSpace; // 0x702
		protected bool m_isIgnoringAlignment; // 0x703
		[SerializeField]
		protected float m_wordWrappingRatios; // 0x704
		[SerializeField]
		protected TextOverflowModes m_overflowMode; // 0x708
		protected int m_firstOverflowCharacterIndex; // 0x70C
		[SerializeField]
		protected TMP_Text m_linkedTextComponent; // 0x710
		[SerializeField]
		internal TMP_Text parentLinkedComponent; // 0x718
		protected bool m_isTextTruncated; // 0x720
		[SerializeField]
		protected bool m_enableKerning; // 0x721
		protected float m_GlyphHorizontalAdvanceAdjustment; // 0x724
		[SerializeField]
		protected bool m_enableExtraPadding; // 0x728
		[SerializeField]
		protected bool checkPaddingRequired; // 0x729
		[SerializeField]
		protected bool m_isRichText; // 0x72A
		[SerializeField]
		protected bool m_enableHyperlink; // 0x72B
		[SerializeField]
		protected Vector2 m_linkExtraPadding; // 0x72C
		[Range(0f, 1f)]
		[SerializeField]
		protected float m_richTextColorBlend; // 0x734
		[SerializeField]
		protected bool m_parseCtrlCharacters; // 0x738
		protected bool m_isOverlay; // 0x739
		[SerializeField]
		protected bool m_isOrthographic; // 0x73A
		[SerializeField]
		protected bool m_isCullingEnabled; // 0x73B
		protected bool m_isMaskingEnabled; // 0x73C
		protected bool isMaskUpdateRequired; // 0x73D
		protected bool m_ignoreCulling; // 0x73E
		[SerializeField]
		protected TextureMappingOptions m_horizontalMapping; // 0x740
		[SerializeField]
		protected TextureMappingOptions m_verticalMapping; // 0x744
		[SerializeField]
		protected float m_uvLineOffset; // 0x748
		protected TextRenderFlags m_renderMode; // 0x74C
		[SerializeField]
		protected VertexSortingOrder m_geometrySortingOrder; // 0x750
		[SerializeField]
		protected bool m_IsTextObjectScaleStatic; // 0x754
		[SerializeField]
		protected bool m_VertexBufferAutoSizeReduction; // 0x755
		protected int m_firstVisibleCharacter; // 0x758
		protected int m_maxVisibleCharacters; // 0x75C
		protected int m_maxVisibleWords; // 0x760
		protected int m_maxVisibleLines; // 0x764
		[SerializeField]
		protected bool m_useMaxVisibleDescender; // 0x768
		[SerializeField]
		protected int m_pageToDisplay; // 0x76C
		protected bool m_isNewPage; // 0x770
		[SerializeField]
		protected Vector4 m_margin; // 0x774
		protected float m_marginLeft; // 0x784
		protected float m_marginRight; // 0x788
		protected float m_marginWidth; // 0x78C
		protected float m_marginHeight; // 0x790
		protected float m_width; // 0x794
		protected TMP_TextInfo m_textInfo; // 0x798
		protected bool m_havePropertiesChanged; // 0x7A0
		[SerializeField]
		protected bool m_isUsingLegacyAnimationComponent; // 0x7A1
		protected Transform m_transform; // 0x7A8
		protected RectTransform m_rectTransform; // 0x7B0
		protected Vector2 m_PreviousRectTransformSize; // 0x7B8
		protected Vector2 m_PreviousPivotPosition; // 0x7C0
		[CompilerGenerated]
		private bool _autoSizeTextContainer_k__BackingField; // 0x7C8
		protected bool m_autoSizeTextContainer; // 0x7C9
		protected Mesh m_mesh; // 0x7D0
		[SerializeField]
		protected bool m_isVolumetricText; // 0x7D8
		[CompilerGenerated]
		private static Func<int, string, TMP_FontAsset> OnFontAssetRequest; // 0x80
		[CompilerGenerated]
		private static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest; // 0x88
		[CompilerGenerated]
		private Action<TMP_TextInfo> OnPreRenderText; // 0x7E0
		protected TMP_SpriteAnimator m_spriteAnimator; // 0x7E8
		protected float m_flexibleHeight; // 0x7F0
		protected float m_flexibleWidth; // 0x7F4
		protected float m_minWidth; // 0x7F8
		protected float m_minHeight; // 0x7FC
		protected float m_maxWidth; // 0x800
		protected float m_maxHeight; // 0x804
		protected LayoutElement m_LayoutElement; // 0x808
		protected float m_preferredWidth; // 0x810
		protected float m_renderedWidth; // 0x814
		protected bool m_isPreferredWidthDirty; // 0x818
		protected float m_preferredHeight; // 0x81C
		protected float m_renderedHeight; // 0x820
		protected bool m_isPreferredHeightDirty; // 0x824
		protected bool m_isCalculatingPreferredValues; // 0x825
		protected int m_layoutPriority; // 0x828
		protected bool m_isLayoutDirty; // 0x82C
		[NonSerialized]
		protected bool m_isAwake; // 0x82D
		internal bool m_isWaitingOnResourceLoad; // 0x82E
		[NonSerialized]
		protected bool m_isInit; // 0x82F
		internal TextInputSources m_inputSource; // 0x830
		protected float m_fontScaleMultiplier; // 0x834
		private static char[] m_htmlTag; // 0x90
		protected static RichTextTagAttribute[] m_xmlAttribute; // 0x98
		private static float[] m_attributeParameterValues; // 0xA0
		protected float tag_LineIndent; // 0x838
		protected float tag_Indent; // 0x83C
		protected TMP_TextProcessingStack<float> m_indentStack; // 0x840
		protected bool tag_NoParsing; // 0x860
		protected bool m_isParsingText; // 0x861
		protected Matrix4x4 m_FXMatrix; // 0x864
		protected bool m_isFXMatrixSet; // 0x8A4
		protected UnicodeChar[] m_TextProcessingArray; // 0x8A8
		internal int m_InternalTextProcessingArraySize; // 0x8B0
		private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x8B8
		protected int m_totalCharacterCount; // 0x8C0
		protected static WordWrapState m_SavedWordWrapState; // 0xA8
		protected static WordWrapState m_SavedLineState; // 0x440
		protected static WordWrapState m_SavedEllipsisState; // 0x7D8
		protected static WordWrapState m_SavedLastValidState; // 0xB70
		protected static WordWrapState m_SavedSoftLineBreakState; // 0xF08
		protected static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x12A0
		protected int m_characterCount; // 0x8C4
		protected int m_firstCharacterOfLine; // 0x8C8
		protected int m_firstVisibleCharacterOfLine; // 0x8CC
		protected int m_lastCharacterOfLine; // 0x8D0
		protected int m_lastVisibleCharacterOfLine; // 0x8D4
		protected int m_lineNumber; // 0x8D8
		protected int m_lineVisibleCharacterCount; // 0x8DC
		protected int m_pageNumber; // 0x8E0
		protected float m_PageAscender; // 0x8E4
		protected float m_maxTextAscender; // 0x8E8
		protected float m_maxCapHeight; // 0x8EC
		protected float m_ElementAscender; // 0x8F0
		protected float m_ElementDescender; // 0x8F4
		protected float m_maxLineAscender; // 0x8F8
		protected float m_maxLineDescender; // 0x8FC
		protected float m_startOfLineAscender; // 0x900
		protected float m_startOfLineDescender; // 0x904
		protected float m_lineOffset; // 0x908
		protected Extents m_meshExtents; // 0x90C
		protected Color32 m_htmlColor; // 0x91C
		protected TMP_TextProcessingStack<Color32> m_colorStack; // 0x920
		protected TMP_TextProcessingStack<Color32> m_underlineColorStack; // 0x940
		protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; // 0x960
		protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x980
		protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; // 0x9B0
		protected TMP_ColorGradient m_colorGradientPreset; // 0x9D8
		protected bool m_colorGradientPresetIsTinted; // 0x9E0
		protected float m_tabSpacing; // 0x9E4
		protected float m_spacing; // 0x9E8
		protected TMP_TextProcessingStack<int>[] m_TextStyleStacks; // 0x9F0
		protected TMP_TextProcessingStack<int> m_ItalicAngleStack; // 0x9F8
		protected TMP_TextProcessingStack<int> m_actionStack; // 0xA18
		protected TMP_TextProcessingStack<float> m_baselineOffsetStack; // 0xA38
		protected int m_TextStyleStackDepth; // 0xA58
		protected int m_ItalicAngle; // 0xA5C
		protected float m_padding; // 0xA60
		protected float m_baselineOffset; // 0xA64
		protected float m_xAdvance; // 0xA68
		protected float m_lastCharAdvance; // 0xA6C
		protected bool m_lastIsUpVowels; // 0xA70
		protected bool m_lastIsAscender; // 0xA71
		protected bool m_lastIsDescender; // 0xA72
		protected float m_lastHeight; // 0xA74
		protected static bool s_forceLeftAlign; // 0x1658
		protected TMP_TextElementType m_textElementType; // 0xA78
		protected TMP_TextElement m_cached_TextElement; // 0xA80
		protected SpecialCharacter m_Ellipsis; // 0xA88
		protected SpecialCharacter m_Underline; // 0xAA8
		protected TMP_SpriteAsset m_defaultSpriteAsset; // 0xAC8
		protected TMP_SpriteAsset m_currentSpriteAsset; // 0xAD0
		protected int m_spriteCount; // 0xAD8
		protected int m_spriteIndex; // 0xADC
		protected int m_spriteAnimationID; // 0xAE0
		private static ProfilerMarker k_ParseTextMarker; // 0x1660
		private static ProfilerMarker k_InsertNewLineMarker; // 0x1668
		protected bool m_ignoreActiveState; // 0xAE4
		private TextBackingContainer m_TextBackingArray; // 0xAE8
		private readonly decimal[] k_Power; // 0xAF8
		private const float k_AccelEstimationTolerance = 0.01f; // Metadata: 0x02640F61
		protected static Vector2 k_LargePositiveVector2; // 0x1670
		protected static Vector2 k_LargeNegativeVector2; // 0x1678
		protected static float k_LargePositiveFloat; // 0x1680
		protected static float k_LargeNegativeFloat; // 0x1684
		protected static int k_LargePositiveInt; // 0x1688
		protected static int k_LargeNegativeInt; // 0x168C
		private bool m_dynamicFontAssetUsed; // 0xB00
	
		// Properties
		public virtual string text { get; set; } // 0x0000000185A09360-0x0000000185A09380 0x0000000185A09260-0x0000000185A09320
		public virtual string textForPopulate { get; } // 0x00000001852D2120-0x00000001852D2160 
		public ITextPreprocessor textPreprocessor { get; set; } // 0x0000000187234CE0-0x0000000187234CF0 0x0000000188A90E90-0x0000000188A90EA4
		public bool isRightToLeftText { get; set; } // 0x00000001828CCF90-0x00000001828CCFA0 0x000000018D43997C-0x000000018D4399C0
		public TMP_FontAsset font { get; set; } // 0x0000000187838EA8-0x0000000187838EB8 0x000000018D439808-0x000000018D4398B0
		public virtual TMP_FontAsset m_fontAsset { get; set; } // 0x000000018723B410-0x000000018723B420 0x000000018783BFB4-0x000000018783BFC8
		public virtual Material fontSharedMaterial { get; set; } // 0x000000018723B5D0-0x000000018723B5E0 0x000000018D4396A0-0x000000018D439738
		protected virtual Material m_sharedMaterial { get; set; } // 0x000000018723B5D0-0x000000018723B5E0 0x000000018783BF64-0x000000018783BF78
		public virtual Material[] fontSharedMaterials { get; set; } // 0x000000018D438A98-0x000000018D438AA8 0x000000018D439664-0x000000018D4396A0
		public Material fontMaterial { get; set; } // 0x000000018D438A44-0x000000018D438A58 0x000000018D439588-0x000000018D439664
		public virtual Material[] fontMaterials { get; set; } // 0x000000018D438A58-0x000000018D438A98 0x000000018D439664-0x000000018D4396A0
		public override UnityEngine.Color color { get; set; } // 0x0000000186CD9BD0-0x0000000186CD9BE0 0x00000001859E2140-0x00000001859E22B0
		public float alpha { get; set; } // 0x0000000187255BC0-0x0000000187255BD0 0x000000018D439244-0x000000018D439270
		public bool enableVertexGradient { get; set; } // 0x0000000187233DF0-0x0000000187233E00 0x000000018D43944C-0x000000018D439474
		public VertexGradient colorGradient { get; set; } // 0x000000018725F520-0x000000018725F550 0x000000018D43933C-0x000000018D439380
		public TMP_ColorGradient colorGradientPreset { get; set; } // 0x000000018723BE70-0x000000018723BE80 0x000000018D439308-0x000000018D43933C
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x000000018723BC50-0x000000018723BC60 0x000000018D439FBC-0x000000018D43A000
		public bool tintAllSprites { get; set; } // 0x0000000187258CF0-0x0000000187258D00 0x000000018D43A0A4-0x000000018D43A0CC
		public TMP_StyleSheet styleSheet { get; set; } // 0x000000018723BCA0-0x000000018723BCB0 0x000000018D43A000-0x000000018D43A044
		public TMP_Style textStyle { get; set; } // 0x00000001852D2480-0x00000001852D2750 0x000000018D43A044-0x000000018D43A0A4
		public bool overrideColorTags { get; set; } // 0x0000000187250F00-0x0000000187250F10 0x000000018D439E60-0x000000018D439E88
		public Color32 faceColor { get; set; } // 0x000000018D43897C-0x000000018D438A44 0x000000018D4394FC-0x000000018D439560
		public Color32 outlineColor { get; set; } // 0x000000018D438C0C-0x000000018D438CD4 0x000000018D439D6C-0x000000018D439DC4
		public float outlineWidth { get; set; } // 0x000000018D438CD4-0x000000018D438D84 0x000000018D439DC4-0x000000018D439E1C
		public float fontSize { get; set; } // 0x000000018725F610-0x000000018725F620 0x0000000186BC3900-0x0000000186BC3960
		protected float PhoneticElementScale { get; } // 0x000000018D4388B8-0x000000018D4388D8 
		protected string m_currentPhonetic { get; } // 0x000000018D438BA8-0x000000018D438C0C 
		protected bool m_currentEnablePhoneticAutoPadding { get; } // 0x00000001862912E0-0x0000000186291330 
		protected bool m_currentEnablePhoneticAutoJustify { get; } // 0x000000018D438B44-0x000000018D438BA8 
		public FontWeight fontWeight { get; set; } // 0x000000018725F630-0x000000018725F640 0x000000018D4397C4-0x000000018D439808
		public float pixelsPerUnit { get; } // 0x000000018D438D84-0x000000018D438EA8 
		public bool enableAutoSizing { get; set; } // 0x000000018725F550-0x000000018725F560 0x000000018D439380-0x000000018D4393BC
		public static int s_totalAutoSizeCacheCount { get; } // 0x000000018D438EA8-0x000000018D438F28 
		protected virtual bool autoSizeCacheEnabled { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public float fontSizeMin { get; set; } // 0x000000018725F600-0x000000018725F610 0x000000018D439738-0x000000018D439780
		public float fontSizeMax { get; set; } // 0x000000018725F5F0-0x000000018725F600 0x0000000186E10A80-0x0000000186E10AD0
		public FontStyles fontStyle { get; set; } // 0x000000018725F620-0x000000018725F630 0x000000018D439780-0x000000018D4397C4
		public bool isUsingBold { get; } // 0x000000018725F6D0-0x000000018725F6E0 
		public HorizontalAlignmentOptions horizontalAlignment { get; set; } // 0x000000018725F660-0x000000018725F670 0x00000001870B46B0-0x00000001870B46D0
		public VerticalAlignmentOptions verticalAlignment { get; set; } // 0x000000018725F880-0x000000018725F890 0x000000018D43A114-0x000000018D43A13C
		public TextAlignmentOptions alignment { get; set; } // 0x000000018725F4E0-0x000000018725F4F0 0x00000001864B85C0-0x00000001864B85F0
		public float characterSpacing { get; set; } // 0x000000018725F500-0x000000018725F510 0x000000018D439270-0x000000018D4392BC
		public float wordSpacing { get; set; } // 0x000000018725F8A0-0x000000018725F8B0 0x000000018D43A164-0x000000018D43A1B0
		public float lineSpacing { get; set; } // 0x000000018725F720-0x000000018725F730 0x000000018D439AC0-0x000000018D439B0C
		public float lineSpacingAdjustment { get; set; } // 0x000000018725F710-0x000000018725F720 0x000000018D439A74-0x000000018D439AC0
		public float paragraphSpacing { get; set; } // 0x000000018725F800-0x000000018725F810 0x000000018D439EB0-0x000000018D439EFC
		public float characterWidthAdjustment { get; set; } // 0x000000018725F510-0x000000018725F520 0x000000018D4392BC-0x000000018D439308
		public bool enableWordWrapping { get; set; } // 0x000000018725F590-0x000000018725F5A0 0x000000018D439474-0x000000018D4394B8
		public float wordWrappingRatios { get; set; } // 0x000000018725F8B0-0x000000018725F8C0 0x000000018D43A1B0-0x000000018D43A1FC
		public TextOverflowModes overflowMode { get; set; } // 0x000000018725F7E0-0x000000018725F7F0 0x000000018D439E1C-0x000000018D439E60
		public bool isTextOverflowing { get; } // 0x000000018D438AA8-0x000000018D438AB4 
		public int firstOverflowCharacterIndex { get; } // 0x000000018725F5B0-0x000000018725F5C0 
		public TMP_Text linkedTextComponent { get; set; } // 0x000000018724F6F0-0x000000018724F700 0x000000018D439B54-0x000000018D439C48
		public bool isTextTruncated { get; } // 0x000000018725F6C0-0x000000018725F6D0 
		public bool enableKerning { get; set; } // 0x000000018725F580-0x000000018725F590 0x000000018D439408-0x000000018D43944C
		public bool extraPadding { get; set; } // 0x000000018725F5A0-0x000000018725F5B0 0x000000018D4394B8-0x000000018D4394FC
		public bool richText { get; set; } // 0x000000018725F840-0x000000018725F850 0x000000018D439F78-0x000000018D439FBC
		public bool enableHyperlink { get; set; } // 0x000000018725F570-0x000000018725F580 0x000000018D4393F0-0x000000018D439408
		public Vector2 linkExtraPadding { get; set; } // 0x000000018725F730-0x000000018725F750 0x000000018D439B0C-0x000000018D439B54
		public float richTextColorBlend { get; set; } // 0x000000018725F830-0x000000018725F840 0x000000018D439F58-0x000000018D439F78
		public bool parseCtrlCharacters { get; set; } // 0x000000018725F810-0x000000018725F820 0x000000018D439EFC-0x000000018D439F40
		public bool isOverlay { get; set; } // 0x000000018725F6A0-0x000000018725F6B0 0x000000018D439938-0x000000018D43997C
		public bool isOrthographic { get; set; } // 0x000000018725F690-0x000000018725F6A0 0x000000018D439910-0x000000018D439938
		public bool enableCulling { get; set; } // 0x000000018725F560-0x000000018725F570 0x000000018D4393BC-0x000000018D4393F0
		public bool ignoreVisibility { get; set; } // 0x000000018725F680-0x000000018725F690 0x000000018D4398F8-0x000000018D439910
		public TextureMappingOptions horizontalMapping { get; set; } // 0x000000018725F670-0x000000018725F680 0x000000018D4398D0-0x000000018D4398F8
		public TextureMappingOptions verticalMapping { get; set; } // 0x000000018725F890-0x000000018725F8A0 0x000000018D43A13C-0x000000018D43A164
		public float mappingUvLineOffset { get; set; } // 0x000000018725F750-0x000000018725F760 0x000000018D439C48-0x000000018D439C74
		public TextRenderFlags renderMode { get; set; } // 0x000000018725F820-0x000000018725F830 0x000000018D439F40-0x000000018D439F58
		public VertexSortingOrder geometrySortingOrder { get; set; } // 0x000000018725F640-0x000000018725F650 0x000000018D4398B0-0x000000018D4398D0
		public bool isTextObjectScaleStatic { get; set; } // 0x000000018725F6B0-0x000000018725F6C0 0x000000018D4399C0-0x000000018D439A20
		public bool vertexBufferAutoSizeReduction { get; set; } // 0x000000018725F870-0x000000018725F880 0x000000018D43A0F4-0x000000018D43A114
		public int firstVisibleCharacter { get; set; } // 0x000000018725F5C0-0x000000018725F5D0 0x000000018D439560-0x000000018D439588
		public int maxVisibleCharacters { get; set; } // 0x000000018725F780-0x000000018725F790 0x00000001860461B0-0x00000001860461E0
		public int maxVisibleWords { get; set; } // 0x000000018725F7A0-0x000000018725F7B0 0x000000018D439D44-0x000000018D439D6C
		public int maxVisibleLines { get; set; } // 0x000000018725F790-0x000000018725F7A0 0x000000018D439D1C-0x000000018D439D44
		public bool useMaxVisibleDescender { get; set; } // 0x000000018725F860-0x000000018725F870 0x000000018D43A0CC-0x000000018D43A0F4
		public int pageToDisplay { get; set; } // 0x000000018725F7F0-0x000000018725F800 0x000000018D439E88-0x000000018D439EB0
		public virtual Vector4 margin { get; set; } // 0x000000018725F760-0x000000018725F770 0x000000018D439C74-0x000000018D439D1C
		public TMP_TextInfo textInfo { get; } // 0x000000018725F850-0x000000018725F860 
		public bool havePropertiesChanged { get; set; } // 0x000000018725F650-0x000000018725F660 0x00000001868AAC80-0x00000001868AACA0
		public bool isUsingLegacyAnimationComponent { get; set; } // 0x000000018725F6E0-0x000000018725F6F0 0x000000018725F8D0-0x000000018725F8E0
		public new Transform transform { get; } // 0x00000001852E0E60-0x00000001852E0FC0 
		public new RectTransform rectTransform { get; } // 0x000000018569FB50-0x000000018569FC00 
		public virtual bool autoSizeTextContainer { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018725F4F0-0x000000018725F500 0x000000018725F8C0-0x000000018725F8D0
		public virtual Mesh mesh { get; } // 0x000000018725EFD0-0x000000018725EFE0 
		public bool isVolumetricText { get; set; } // 0x000000018725F6F0-0x000000018725F700 0x000000018D439A20-0x000000018D439A74
		public Bounds bounds { get; } // 0x000000018D4388D8-0x000000018D43897C 
		public Bounds textBounds { get; } // 0x0000000185CD0FF0-0x0000000185CD1030 
		protected TMP_SpriteAnimator spriteAnimator { get; } // 0x000000018D438F28-0x000000018D43901C 
		public float flexibleHeight { get; } // 0x000000018725F5D0-0x000000018725F5E0 
		public float flexibleWidth { get; } // 0x000000018725F5E0-0x000000018725F5F0 
		public float minWidth { get; } // 0x000000018725F7D0-0x000000018725F7E0 
		public float minHeight { get; } // 0x000000018725F7C0-0x000000018725F7D0 
		public float maxWidth { get; } // 0x000000018725F7B0-0x000000018725F7C0 
		public float maxHeight { get; } // 0x000000018725F770-0x000000018725F780 
		protected LayoutElement layoutElement { get; } // 0x000000018D438AB4-0x000000018D438B44 
		public virtual float preferredWidth { get; } // 0x0000000187837318-0x0000000187837338 
		public virtual float preferredHeight { get; } // 0x0000000187837338-0x0000000187837360 
		public virtual float renderedWidth { get; } // 0x000000018D43427C-0x000000018D434298 
		public virtual float renderedHeight { get; } // 0x000000018D434188-0x000000018D4341A4 
		public int layoutPriority { get; } // 0x000000018725F700-0x000000018725F710 
	
		// Events
		public static event Func<int, string, TMP_FontAsset> OnFontAssetRequest {
			add; // 0x000000018D438690-0x000000018D43875C
			remove; // 0x000000018D43901C-0x000000018D4390E8
		}
		public static event Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest {
			add; // 0x000000018D4387EC-0x000000018D4388B8
			remove; // 0x000000018D439178-0x000000018D439244
		}
		public virtual event Action<TMP_TextInfo> OnPreRenderText {
			add; // 0x000000018D43875C-0x000000018D4387EC
			remove; // 0x000000018D4390E8-0x000000018D439178
		}
	
		// Nested types
		protected struct AutoSizeCacheKey : IEquatable<AutoSizeCacheKey> // TypeDefIndex: 82458
		{
			// Fields
			private readonly int m_textHash; // 0x00
			private readonly long m_marginKey; // 0x08
			private readonly long m_spacingKey; // 0x10
			private readonly long m_layoutKey; // 0x18
	
			// Constructors
			public AutoSizeCacheKey(int textHash, float fontSizeMin, float fontSizeMax, float marginWidth, float marginHeight, FontStyles fontStyle, float characterSpacing, float wordSpacing, float lineSpacing, float paragraphSpacing, bool wordWrapping, TextOverflowModes overflowMode, HorizontalAlignmentOptions horizontalAlignment, VerticalAlignmentOptions verticalAlignment); // 0x00000001854688B0-0x0000000185468B20
	
			// Methods
			public bool Equals(AutoSizeCacheKey other); // 0x00000001861C36F0-0x00000001861C3730
			public override bool Equals(object obj); // 0x000000018D43A1FC-0x000000018D43A274
			public override int GetHashCode(); // 0x0000000185EBA270-0x0000000185EBA2B0
		}
	
		protected enum AutoSizeAccelProbeState // TypeDefIndex: 82459
		{
			None = 0,
			Candidate = 1
		}
	
		protected enum AutoSizeAccelPrecomputeResult // TypeDefIndex: 82460
		{
			Unsupported = 0,
			FitsMax = 1,
			Candidate = 2
		}
	
		protected struct CharacterSubstitution // TypeDefIndex: 82461
		{
			// Fields
			public int index; // 0x00
			public uint unicode; // 0x04
	
			// Constructors
			public CharacterSubstitution(int index, uint unicode); // 0x00000001827241A0-0x00000001827241B0
		}
	
		internal enum TextInputSources // TypeDefIndex: 82462
		{
			TextInputBox = 0,
			SetText = 1,
			SetTextArray = 2,
			TextString = 3
		}
	
		[DebuggerDisplay("Unicode ({unicode})  \'{(char)unicode}\'")]
		protected struct UnicodeChar // TypeDefIndex: 82463
		{
			// Fields
			public int unicode; // 0x00
			public int stringIndex; // 0x04
			public int length; // 0x08
		}
	
		protected struct SpecialCharacter // TypeDefIndex: 82464
		{
			// Fields
			public TMP_Character character; // 0x00
			public TMP_FontAsset fontAsset; // 0x08
			public Material material; // 0x10
			public int materialIndex; // 0x18
	
			// Constructors
			public SpecialCharacter(TMP_Character character, int materialIndex); // 0x00000001857E7EF0-0x00000001857E8030
		}
	
		private struct TextBackingContainer : IDisposable // TypeDefIndex: 82465
		{
			// Fields
			private uint[] m_Array; // 0x00
			private int m_Count; // 0x08
	
			// Properties
			public int Capacity { get; } // 0x0000000187836540-0x000000018783655C 
			public int Count { get; set; } // 0x0000000184431A70-0x0000000184431A80 0x0000000187235AA0-0x0000000187235AB0
			public uint this[int index] { get => default; set {} } // 0x00000001852D35C0-0x00000001852D35F0 0x00000001853F5610-0x00000001853F5670
	
			// Constructors
			public TextBackingContainer(int size); // 0x00000001852F1530-0x00000001852F1640
	
			// Methods
			public void Resize(int size); // 0x00000001863916E0-0x0000000186391740
			public void Dispose(); // 0x00000001852EED20-0x00000001852EEE20
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 82466
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<TMP_TextInfo> __9__724_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E6C20-0x00000001871E6C80
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _.ctor_b__724_0(TMP_TextInfo _p0_); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		protected TMP_Text(); // 0x000000018548EB60-0x000000018548F110
		static TMP_Text(); // 0x0000000186C16790-0x0000000186C16DC0
	
		// Methods
		public void ResetTextForPopulate(); // 0x000000018D437750-0x000000018D437760
		public virtual void RefreshPopulateText(); // 0x000000018D436720-0x000000018D436750
		protected virtual Material LoadMaterial(string path); // 0x0000000185829EC0-0x0000000185829ED0
		protected void TryComputeAutoSizeTextHash(); // 0x00000001851C02C0-0x00000001851C0360
		private static int QuantizeKeyFloat(float value, float scale); // 0x0000000185468480-0x0000000185468490
		private static long PackAutoSizeIntPair(int low, int high); // 0x000000018725F450-0x000000018725F460
		private static long PackAutoSizeSpacingKey(float characterSpacing, float wordSpacing, float lineSpacing, float paragraphSpacing); // 0x00000001854687A0-0x00000001854688B0
		private static long PackAutoSizeLayoutKey(float fontSizeMin, float fontSizeMax, FontStyles fontStyle, bool wordWrapping, TextOverflowModes overflowMode, HorizontalAlignmentOptions horizontalAlignment, VerticalAlignmentOptions verticalAlignment); // 0x0000000185466340-0x0000000185466460
		protected AutoSizeCacheKey MakeAutoSizeCacheKey(float marginW, float marginH); // 0x0000000185468490-0x00000001854687A0
		protected static bool TryGetAutoSizeCache(AutoSizeCacheKey key, out float fontSize); // 0x00000001851BFE10-0x00000001851BFF90
		protected static void SetAutoSizeCache(AutoSizeCacheKey key, float fontSize); // 0x00000001851BFF90-0x00000001851C0150
		public static void ClearAutoSizeCache(); // 0x000000018671D6F0-0x000000018671D760
		protected static float QuantizeAutoSize(float fontSize); // 0x000000018D4366FC-0x000000018D436720
		protected static bool IsAutoSizeExplicitLineBreak(uint unicode); // 0x00000001857E8530-0x00000001857E8550
		protected static bool IsAutoSizeLayoutCharacter(uint unicode); // 0x00000001857E84C0-0x00000001857E8530
		protected override void Awake(); // 0x0000000187835A1C-0x0000000187835A24
		public void InitDataFromPool(); // 0x00000001852F0980-0x00000001852F1530
		protected override void OnDestroy(); // 0x00000001852EE7B0-0x00000001852EEB10
		protected virtual void LoadFontAsset(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void SetSharedMaterial(Material mat); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual Material GetMaterial(Material mat); // 0x0000000185829EC0-0x0000000185829ED0
		protected virtual void SetFontBaseMaterial(Material mat); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual Material[] GetSharedMaterials(); // 0x0000000185829EC0-0x0000000185829ED0
		protected virtual void SetSharedMaterials(Material[] materials); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual Material[] GetMaterials(Material[] mats); // 0x0000000185829EC0-0x0000000185829ED0
		protected virtual Material CreateMaterialInstance(Material source); // 0x000000018D4320AC-0x000000018D432160
		protected void SetVertexColorGradient(TMP_ColorGradient gradient); // 0x000000018D4385F0-0x000000018D438690
		protected void SetTextSortingOrder(VertexSortingOrder order); // 0x0000000186805BA0-0x0000000186805BB0
		protected void SetTextSortingOrder(int[] order); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void SetFaceColor(Color32 color); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void SetOutlineColor(Color32 color); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void SetOutlineThickness(float thickness); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void SetShaderDepth(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void SetCulling(); // 0x0000000186805BA0-0x0000000186805BB0
		internal virtual void UpdateCulling(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual float GetPaddingForMaterial(); // 0x00000001857E5D20-0x00000001857E5EB0
		protected virtual float GetPaddingForMaterial(Material mat); // 0x000000018D433C44-0x000000018D433D38
		protected virtual Vector3[] GetTextContainerLocalCorners(); // 0x0000000185829EC0-0x0000000185829ED0
		public virtual void ForceMeshUpdate(bool ignoreActiveState = false /* Metadata: 0x02640F5A */, bool forceTextReparsing = false /* Metadata: 0x02640F5B */); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void UpdateGeometry(Mesh mesh, int index); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void UpdateVertexData(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void SetVertices(Vector3[] vertices); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void UpdateMeshPadding(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x0000000186BD98E0-0x0000000186BD9970
		public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x000000018D432160-0x000000018D4321C0
		protected virtual void InternalCrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x0000000186805BA0-0x0000000186805BB0
		protected void ParseInputText(); // 0x00000001852D1EC0-0x00000001852D2120
		private void PopulateTextBackingArray(string sourceText); // 0x00000001852D22B0-0x00000001852D2480
		private void PopulateTextBackingArray(string sourceText, int start, int length); // 0x00000001853F5400-0x00000001853F5610
		private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length); // 0x000000018D435F3C-0x000000018D43603C
		private void PopulateTextBackingArray(char[] sourceText, int start, int length); // 0x000000018D43603C-0x000000018D43614C
		private void PopulateTextProcessingArray(); // 0x00000001852D3620-0x00000001852D4BA0
		private void SetTextInternal(string sourceText); // 0x000000018D438090-0x000000018D4380E8
		public void SetText(string sourceText, bool syncTextInputBox = true /* Metadata: 0x02640F5C */); // 0x0000000185EC5EB0-0x0000000185EC5F70
		public void SetText(string sourceText, float arg0); // 0x000000018D43854C-0x000000018D438588
		public void SetText(string sourceText, float arg0, float arg1); // 0x000000018D4380E8-0x000000018D438124
		public void SetText(string sourceText, float arg0, float arg1, float arg2); // 0x000000018D4384BC-0x000000018D438500
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3); // 0x000000018D438500-0x000000018D43854C
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4); // 0x000000018D438464-0x000000018D4384BC
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5); // 0x000000018D43839C-0x000000018D4383FC
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6); // 0x000000018D4383FC-0x000000018D438464
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7); // 0x000000018D438150-0x000000018D43839C
		public void SetText(StringBuilder sourceText); // 0x000000018D438124-0x000000018D438150
		private void SetText(StringBuilder sourceText, int start, int length); // 0x000000018D438598-0x000000018D4385F0
		public void SetText(char[] sourceText); // 0x000000018D438068-0x000000018D438090
		public void SetText(char[] sourceText, int start, int length); // 0x000000018D438588-0x000000018D438598
		public void SetCharArray(char[] sourceText); // 0x000000018D438068-0x000000018D438090
		public void SetCharArray(char[] sourceText, int start, int length); // 0x000000018D437FCC-0x000000018D438068
		private TMP_Style GetStyle(int hashCode); // 0x00000001852D2750-0x00000001852D2980
		private bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018D436F64-0x000000018D437334
		private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018D437334-0x000000018D4376F0
		private void ReplaceClosingStyleTag(ref TextBackingContainer sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018D43684C-0x000000018D436BDC
		private void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018D436BDC-0x000000018D436F64
		private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018D4358EC-0x000000018D435C74
		private void InsertClosingStyleTag(ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018D435564-0x000000018D4358EC
		private int GetMarkupTagHashCode(int[] tagDefinition, int readIndex); // 0x000000018D433B78-0x000000018D433C44
		private int GetMarkupTagHashCode(TextBackingContainer tagDefinition, int readIndex); // 0x00000001852D1C00-0x00000001852D1D00
		private int GetStyleHashCode(ref int[] text, int index, out int closeIndex); // 0x000000018D434298-0x000000018D434350
		private int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex); // 0x000000018D434350-0x000000018D434418
		private void ResizeInternalArray<T>(ref ref T[] array);
		private void ResizeInternalArray<T>(ref ref T[] array, int size);
		private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex); // 0x000000018D431C0C-0x000000018D431EEC
		private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex); // 0x000000018D431EEC-0x000000018D432000
		private string InternalTextBackingArrayToString(); // 0x000000018D435C74-0x000000018D435D4C
		protected virtual int SetArraySizes(UnicodeChar[] unicodeChars); // 0x0000000185829EC0-0x0000000185829ED0
		public Vector2 GetPreferredValues(); // 0x000000018D434098-0x000000018D4340EC
		public Vector2 GetPreferredValues(float width, float height); // 0x000000018D433EF0-0x000000018D433F58
		public Vector2 GetPreferredValues(string text); // 0x000000018D433F58-0x000000018D434020
		public Vector2 GetPreferredValues(string text, float width, float height); // 0x000000018D434020-0x000000018D434098
		protected float GetPreferredWidth(); // 0x00000001852D1D00-0x00000001852D1EC0
		private float GetPreferredWidth(Vector2 margin); // 0x000000018D4340EC-0x000000018D43416C
		protected float GetPreferredHeight(); // 0x00000001852D1990-0x00000001852D1BB0
		private float GetPreferredHeight(Vector2 margin); // 0x000000018D433E38-0x000000018D433EF0
		public Vector2 GetRenderedValues(); // 0x000000018D434204-0x000000018D434260
		public Vector2 GetRenderedValues(bool onlyVisibleCharacters); // 0x000000018D4341A4-0x000000018D434204
		private float GetRenderedWidth(); // 0x000000018D43427C-0x000000018D434298
		protected float GetRenderedWidth(bool onlyVisibleCharacters); // 0x000000018D434260-0x000000018D43427C
		private float GetRenderedHeight(); // 0x000000018D434188-0x000000018D4341A4
		protected float GetRenderedHeight(bool onlyVisibleCharacters); // 0x000000018D43416C-0x000000018D434188
		protected float TryGetAutoSizeCachedFontSize(float marginWidth, float marginHeight); // 0x00000001851C0150-0x00000001851C02C0
		protected static bool HasWordBreakPoint(UnicodeChar[] processingArray); // 0x0000000185FEE5E0-0x0000000185FEE720
		private static bool IsCJKBreakableCharacter(uint unicode); // 0x0000000185FEE720-0x0000000185FEEBF0
		protected AutoSizeAccelPrecomputeResult PrecomputeAccelFontSize(out float accelFontSize, out int predictedLineCount); // 0x00000001857E8C00-0x00000001857E95E0
		protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled); // 0x00000001857E9DE0-0x00000001857EC3C0
		protected virtual Bounds GetCompoundBounds(); // 0x000000018723D1E0-0x000000018723D1F0
		internal virtual Rect GetCanvasSpaceClippingRect(); // 0x0000000184591DC0-0x0000000184591DD0
		protected Bounds GetTextBounds(); // 0x0000000185CD1160-0x0000000185CD1490
		protected Bounds GetTextBounds(bool onlyVisibleCharacters); // 0x000000018D434418-0x000000018D43473C
		protected void AdjustLineOffset(int startIndex, int endIndex, float offset); // 0x00000001861D7130-0x00000001861D7630
		protected void ResizeLineExtents(int size); // 0x00000001857EC910-0x00000001857ECC10
		public virtual TMP_TextInfo GetTextInfo(string text); // 0x0000000185829EC0-0x0000000185829ED0
		public virtual void ComputeMarginSize(); // 0x0000000186805BA0-0x0000000186805BB0
		protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender); // 0x00000001852EEE20-0x00000001852EFC40
		protected void SaveWordWrappingState(ref WordWrapState state, int index, int count); // 0x00000001857ECC10-0x00000001857ED640
		protected int RestoreWordWrappingState(ref WordWrapState state); // 0x00000001857ED640-0x00000001857EDE20
		protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor); // 0x00000001850E0020-0x00000001850E0620
		protected virtual void SaveSpriteVertexInfo(Color32 vertexColor); // 0x000000018D437760-0x000000018D437FCC
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4); // 0x00000001850DF7E0-0x00000001850E0020
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric); // 0x000000018D4326A4-0x000000018D433290
		protected virtual void FillSpriteVertexBuffers(int i, int index_X4); // 0x000000018D433290-0x000000018D433A40
		protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor); // 0x0000000185CCE670-0x0000000185CCF580
		protected void PrepareCharSlots(PhoneticData data); // 0x000000018D43614C-0x000000018D4366FC
		protected virtual float PhoneticWidth(PhoneticData data); // 0x000000018D435E14-0x000000018D435F3C
		protected virtual void DrawPhoneticMesh(Rect rect, PhoneticData data, float padding, float style_padding, bool justify, float lossyScale, UnityEngine.RenderMode canvasRenderMode, float canvasScaleFactor, bool isCameraAssigned); // 0x0000000184F50750-0x0000000184F52FB0
		protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor); // 0x000000018D4321C0-0x000000018D4326A4
		protected void LoadDefaultSettings(); // 0x00000001852F1D40-0x00000001852F1DA0
		protected void GetSpecialCharacters(TMP_FontAsset fontAsset); // 0x00000001857E7CE0-0x00000001857E7D10
		protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset); // 0x00000001857E8030-0x00000001857E8230
		protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset); // 0x00000001857E7D10-0x00000001857E7EF0
		protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c); // 0x000000018D4376F0-0x000000018D437750
		protected TMP_FontAsset GetFontAssetForWeight(int fontWeight); // 0x000000018D433B00-0x000000018D433B78
		internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface); // 0x00000001857E95E0-0x00000001857E97B0
		public void TryRemoveDynamicFallbackFontAssetTextRef(); // 0x00000001852ECED0-0x00000001852ECF20
		protected virtual void SetActiveSubMeshes(bool state); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void DestroySubMeshObjects(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void ClearMesh(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void ClearMesh(bool uploadGeometry); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual string GetParsedText(); // 0x000000018D433D38-0x000000018D433E38
		internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent); // 0x000000018D435D4C-0x000000018D435E14
		internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent); // 0x000000018D436750-0x000000018D43684C
		protected Vector2 PackUV(float x, float y, float scale); // 0x000000018725F4A0-0x000000018725F4E0
		protected float PackUV(float x, float y); // 0x000000018725F460-0x000000018725F4A0
		internal virtual void InternalUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected static int HexToInt(char hex); // 0x00000001851ABE30-0x00000001851ABF50
		protected int GetUTF16(string text, int i); // 0x000000018D434904-0x000000018D4349EC
		protected int GetUTF16(int[] text, int i); // 0x000000018D434824-0x000000018D434904
		internal int GetUTF16(uint[] text, int i); // 0x000000018D434AC4-0x000000018D434BA4
		protected int GetUTF16(StringBuilder text, int i); // 0x000000018D43473C-0x000000018D434824
		private int GetUTF16(TextBackingContainer text, int i); // 0x000000018D4349EC-0x000000018D434AC4
		protected int GetUTF32(string text, int i); // 0x000000018D434BA4-0x000000018D434D1C
		protected int GetUTF32(int[] text, int i); // 0x000000018D434E90-0x000000018D435004
		internal int GetUTF32(uint[] text, int i); // 0x000000018D434D1C-0x000000018D434E90
		protected int GetUTF32(StringBuilder text, int i); // 0x000000018D435164-0x000000018D4352DC
		private int GetUTF32(TextBackingContainer text, int i); // 0x000000018D435004-0x000000018D435164
		protected static Color32 HexCharsToColor(ReadOnlySpan<char> hexChars, int tagCount); // 0x00000001851ABC50-0x00000001851ABE30
		protected static Color32 HexCharsToColor(ReadOnlySpan<char> hexChars, int startIndex, int length); // 0x000000018D4352DC-0x000000018D435564
		private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters); // 0x000000018D433A40-0x000000018D433B00
		protected float ConvertToFloat(char[] chars, int startIndex, int length); // 0x000000018D432088-0x000000018D4320AC
		protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex); // 0x00000001863E1740-0x00000001863E1890
		protected bool CheckIfEndPhonetic(UnicodeChar[] chars, int startIndex); // 0x000000018D432000-0x000000018D432088
		protected bool ValidateHtmlTag(UnicodeChar[] chars, int startIndex, out int endIndex); // 0x00000001851A9F10-0x00000001851ABC50
	}

	public enum TextElementType : byte // TypeDefIndex: 82468
	{
		Character = 1,
		Sprite = 2
	}

	[Serializable]
	public class TMP_TextElement // TypeDefIndex: 82469
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
		public TextElementType elementType { get; } // 0x00000001829D0800-0x00000001829D0810 
		public uint unicode { get; set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018275FD70-0x000000018275FD80
		public TMP_Asset textAsset { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public Glyph glyph { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public uint glyphIndex { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public float scale { get; set; } // 0x0000000187233330-0x0000000187233340 0x0000000187233340-0x0000000187233350
	
		// Constructors
		public TMP_TextElement(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class TMP_TextElement_Legacy // TypeDefIndex: 82470
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
		public TMP_TextElement_Legacy(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class TMP_TextInfo : IDisposable // TypeDefIndex: 82471
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
		public TMP_TextInfo(); // 0x000000018D4419A8-0x000000018D441B5C
		internal TMP_TextInfo(int characterCount); // 0x000000018D441B5C-0x000000018D441D18
		public TMP_TextInfo(TMP_Text textComponent); // 0x00000001852F1FC0-0x00000001852F2550
		static TMP_TextInfo(); // 0x00000001871F3E40-0x00000001871F3EA0
	
		// Methods
		public void Clear(); // 0x0000000186044FE0-0x0000000186045030
		internal void ClearAllData(); // 0x000000018D44115C-0x000000018D4412A0
		public void ClearMeshInfo(bool updateMesh); // 0x000000018D441320-0x000000018D4413B0
		public void ClearAllMeshInfo(); // 0x000000018D4412A0-0x000000018D441320
		public void ResetVertexLayout(bool isVolumetric); // 0x000000018D441918-0x000000018D4419A8
		public void ClearUnusedVertices(MaterialReference[] materials); // 0x000000018D4413B0-0x000000018D441430
		public void ClearLineInfo(); // 0x00000001850DF590-0x00000001850DF7E0
		public void ClearPageInfo(); // 0x0000000185C42480-0x0000000185C42540
		public TMP_MeshInfo[] CopyMeshInfoVertexData(); // 0x000000018D441430-0x000000018D441918
		public static void Resize<T>(ref ref T[] array, int size);
		public static void Resize<T>(ref ref T[] array, int size, bool isBlockAllocated);
		public void Dispose(); // 0x00000001852EFC40-0x00000001852F0330
	}

	public class TMP_TextParsingUtilities // TypeDefIndex: 82472
	{
		// Fields
		private static readonly TMP_TextParsingUtilities s_Instance; // 0x00
		private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x02640F70
		private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x02640FF2
	
		// Properties
		public static TMP_TextParsingUtilities instance { get; } // 0x000000018D441EAC-0x000000018D441EFC 
	
		// Constructors
		static TMP_TextParsingUtilities(); // 0x00000001871E7A00-0x00000001871E7A60
		public TMP_TextParsingUtilities(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static int GetHashCode(string s); // 0x00000001864EEE60-0x00000001864EEF10
		public static int GetHashCodeCaseSensitive(string s); // 0x000000018D441D18-0x000000018D441D6C
		public static char ToLowerASCIIFast(char c); // 0x000000018D441D9C-0x000000018D441DF4
		public static char ToUpperASCIIFast(char c); // 0x00000001864EEF10-0x00000001864EEF70
		public static uint ToUpperASCIIFast(uint c); // 0x000000018D441E50-0x000000018D441EAC
		public static uint ToLowerASCIIFast(uint c); // 0x000000018D441DF4-0x000000018D441E50
		public static bool IsHighSurrogate(uint c); // 0x000000018D441D6C-0x000000018D441D84
		public static bool IsLowSurrogate(uint c); // 0x000000018D441D84-0x000000018D441D9C
		internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate); // 0x000000018725F940-0x000000018725F950
	}

	public struct TMP_FontStyleStack // TypeDefIndex: 82473
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
		public void Clear(); // 0x00000001861A9720-0x00000001861A9730
		public byte Add(FontStyles style); // 0x0000000186B662C0-0x0000000186B662E0
		public byte Remove(FontStyles style); // 0x0000000186B12600-0x0000000186B12630
	}

	[DebuggerDisplay("Item count = {m_Count}")]
	public struct TMP_TextProcessingStack<T> : IDisposable // TypeDefIndex: 82474
	{
		// Fields
		public T[] itemStack;
		public int index;
		private T m_DefaultItem;
		private int m_Capacity;
		private int m_RolloverSize;
		private int m_Count;
		private const int k_DefaultCapacity = 4; // Metadata: 0x02641074
	
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
	public struct TMP_TextProcessingQueue<T> : IDisposable // TypeDefIndex: 82475
	{
		// Fields
		public T[] itemQueue;
		private int m_Head;
		private int m_Tail;
		private int m_Capacity;
		private int m_Count;
		private T m_DefaultItem;
		private const int k_DefaultCapacity = 4; // Metadata: 0x02641075
	
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

	public enum CaretPosition // TypeDefIndex: 82476
	{
		None = 0,
		Left = 1,
		Right = 2
	}

	public struct CaretInfo // TypeDefIndex: 82477
	{
		// Fields
		public int index; // 0x00
		public CaretPosition position; // 0x04
	
		// Constructors
		public CaretInfo(int index, CaretPosition position); // 0x00000001827241A0-0x00000001827241B0
	}

	public static class TMP_TextUtilities // TypeDefIndex: 82479
	{
		// Fields
		private static Vector3[] m_rectWorldCorners; // 0x00
		private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x02641079
		private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x026410FB
	
		// Nested types
		private struct LineSegment // TypeDefIndex: 82478
		{
			// Fields
			public Vector3 Point1; // 0x00
			public Vector3 Point2; // 0x0C
	
			// Constructors
			public LineSegment(Vector3 p1, Vector3 p2); // 0x0000000187233BB0-0x0000000187233BD0
		}
	
		// Constructors
		static TMP_TextUtilities(); // 0x00000001871D7BC0-0x00000001871D7C30
	
		// Methods
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera); // 0x000000018D4444E8-0x000000018D4446A4
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor); // 0x00000001857EC3C0-0x00000001857EC6A0
		public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera); // 0x00000001857EC6A0-0x00000001857EC910
		public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly); // 0x00000001857EDE20-0x00000001857EE420
		public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera); // 0x000000018D444B0C-0x000000018D444CFC
		public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly); // 0x000000018D441EFC-0x000000018D4421D0
		public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly); // 0x000000018D442B1C-0x000000018D442F6C
		public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera); // 0x000000018D4423F4-0x000000018D442B1C
		public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera); // 0x000000018D443A14-0x000000018D4444E8
		public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera); // 0x000000018D4421D0-0x000000018D442360
		public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera); // 0x000000018D442360-0x000000018D4423F4
		public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera, Vector2 linkExtraPadding); // 0x00000001857EEDB0-0x00000001857EEFC0
		private static float CalculateTouchLinkDistanceScore(Vector2 touchPos, Vector2 linkCenter); // 0x000000018725F950-0x000000018725F9A0
		public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera); // 0x000000018D442F6C-0x000000018D443A14
		private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d); // 0x00000001857EE600-0x00000001857EE7D0
		public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint); // 0x00000001857EE7D0-0x00000001857EE9E0
		private static bool IntersectLinePlane(LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint); // 0x000000018D4448E8-0x000000018D444B0C
		public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point); // 0x00000001857EE420-0x00000001857EE600
		public static char ToLowerFast(char c); // 0x000000018D444DAC-0x000000018D444E04
		public static char ToUpperFast(char c); // 0x000000018D444E04-0x000000018D444E5C
		internal static uint ToUpperASCIIFast(uint c); // 0x00000001852D1BB0-0x00000001852D1C00
		public static int GetHashCode(string s); // 0x000000018D4446A4-0x000000018D444734
		public static int GetSimpleHashCode(string s); // 0x00000001852DB890-0x00000001852DB8F0
		public static uint GetSimpleHashCodeLowercase(string s); // 0x000000018D444734-0x000000018D4447C8
		public static int HexToInt(char hex); // 0x000000018D4447C8-0x000000018D4448E8
		public static int StringHexToInt(string s); // 0x000000018D444CFC-0x000000018D444DAC
		public static bool IsThaiZeroWidthCharacter(char c); // 0x0000000185E3D3E0-0x0000000185E3D490
		public static bool IsUpVowel(char c); // 0x00000001850DE870-0x00000001850DE8A0
		public static bool IsLowVowel(char c); // 0x0000000185E3D490-0x0000000185E3D4C0
		public static bool IsToneMark(char c); // 0x00000001850DE8A0-0x00000001850DE8D0
		public static bool IsAscenderThai(char c); // 0x0000000185E0EA60-0x0000000185E0EA90
		public static bool IsDescenderThai(char c); // 0x0000000185F32730-0x0000000185F32750
	}

	public class TMP_UpdateManager // TypeDefIndex: 82480
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
		private static TMP_UpdateManager instance { get; } // 0x00000001852E84D0-0x00000001852E85B0 
	
		// Constructors
		private TMP_UpdateManager(); // 0x0000000186DFEA70-0x0000000186DFECB0
		static TMP_UpdateManager(); // 0x0000000186F8E7D0-0x0000000186F8E920
	
		// Methods
		internal static void RegisterTextObjectForUpdate(TMP_Text textObject); // 0x00000001852E9910-0x00000001852E9A80
		private void InternalRegisterTextObjectForUpdate(TMP_Text textObject); // 0x00000001852E9A80-0x00000001852E9BD0
		public static void RegisterTextElementForLayoutRebuild(TMP_Text element); // 0x000000018D445EC4-0x000000018D445F1C
		private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element); // 0x000000018D445C80-0x000000018D445D3C
		public static void RegisterTextElementForGraphicRebuild(TMP_Text element); // 0x000000018D445E6C-0x000000018D445EC4
		private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element); // 0x000000018D445BC4-0x000000018D445C80
		public static void RegisterTextElementForCullingUpdate(TMP_Text element); // 0x00000001860F4B40-0x00000001860F4B90
		private void InternalRegisterTextElementForCullingUpdate(TMP_Text element); // 0x00000001860F4B90-0x00000001860F4CE0
		private void OnCameraPreCull(); // 0x000000018D445E64-0x000000018D445E6C
		private void DoRebuilds(); // 0x0000000184F97EA0-0x0000000184F98010
		internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject); // 0x00000001852E83D0-0x00000001852E84D0
		public static void UnRegisterTextElementForRebuild(TMP_Text element); // 0x000000018D445F1C-0x000000018D445FA8
		private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element); // 0x000000018D445D3C-0x000000018D445DD0
		private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element); // 0x000000018D445DD0-0x000000018D445E64
		private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject); // 0x00000001852E8300-0x00000001852E83D0
	}

	public class TMP_UpdateRegistry // TypeDefIndex: 82481
	{
		// Fields
		private static TMP_UpdateRegistry s_Instance; // 0x00
		private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
		private HashSet<int> m_LayoutQueueLookup; // 0x18
		private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
		private HashSet<int> m_GraphicQueueLookup; // 0x28
	
		// Properties
		public static TMP_UpdateRegistry instance { get; } // 0x000000018D4466E4-0x000000018D448774 
	
		// Constructors
		protected TMP_UpdateRegistry(); // 0x000000018D446570-0x000000018D4466E4
	
		// Methods
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x000000018D4464F8-0x000000018D446528
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x000000018D446094-0x000000018D446180
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x000000018D4464C8-0x000000018D4464F8
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x000000018D445FA8-0x000000018D446094
		private void PerformUpdateForCanvasRendererObjects(); // 0x000000018D446310-0x000000018D446474
		private void PerformUpdateForMeshRendererObjects(); // 0x000000018D446474-0x000000018D4464C8
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element); // 0x000000018D446528-0x000000018D446570
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x000000018D446248-0x000000018D446310
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x000000018D446180-0x000000018D446248
	}
}

namespace TMPro.SpriteAssetUtilities
{
	public enum SpriteAssetImportFormats // TypeDefIndex: 82482
	{
		None = 0,
		TexturePackerJsonArray = 1
	}

	public class TexturePacker_JsonArray // TypeDefIndex: 82488
	{
		// Nested types
		[Serializable]
		public struct SpriteFrame // TypeDefIndex: 82483
		{
			// Fields
			public float x; // 0x00
			public float y; // 0x04
			public float w; // 0x08
			public float h; // 0x0C
	
			// Methods
			public override string ToString(); // 0x000000018D4459BC-0x000000018D445B2C
		}
	
		[Serializable]
		public struct SpriteSize // TypeDefIndex: 82484
		{
			// Fields
			public float w; // 0x00
			public float h; // 0x04
	
			// Methods
			public override string ToString(); // 0x000000018D445B2C-0x000000018D445BC4
		}
	
		[Serializable]
		public struct Frame // TypeDefIndex: 82485
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
		public struct Meta // TypeDefIndex: 82486
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
		public class SpriteDataObject // TypeDefIndex: 82487
		{
			// Fields
			public List<Frame> frames; // 0x10
			public Meta meta; // 0x18
	
			// Constructors
			public SpriteDataObject(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public TexturePacker_JsonArray(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
