/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;

// Image 42: UnityEngine.TextCoreTextEngineModule.dll - Assembly: UnityEngine.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56897-56955

namespace UnityEngine.TextCore.Text
{
	[Serializable]
	public class Character : TextElement // TypeDefIndex: 56898
	{
		// Constructors
		public Character() {} // 0x0000000185FE5930-0x0000000185FE5940
		public Character(uint unicode, FontAsset fontAsset, Glyph glyph) {} // 0x000000018BF5D064-0x000000018BF5D0BC
		internal Character(uint unicode, uint glyphIndex) {} // 0x000000018BE09510-0x000000018BE09550
	}

	internal static class ColorUtilities // TypeDefIndex: 56899
	{
		// Methods
		internal static bool CompareColors(Color32 a, Color32 b) => default; // 0x000000018BE15310-0x000000018BE15348
		internal static Color32 MultiplyColors(Color32 c1, Color32 c2) => default; // 0x000000018BF5D0BC-0x000000018BF5D198
	}

	public enum TextFontWeight // TypeDefIndex: 56900
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

	[Serializable]
	public struct FontWeightPair // TypeDefIndex: 56901
	{
		// Fields
		public FontAsset regularTypeface; // 0x00
		public FontAsset italicTypeface; // 0x08
	}

	[Serializable]
	public struct FontAssetCreationEditorSettings // TypeDefIndex: 56902
	{
		// Fields
		public string sourceFontFileGUID; // 0x00
		public int faceIndex; // 0x08
		public int pointSizeSamplingMode; // 0x0C
		public int pointSize; // 0x10
		public int padding; // 0x14
		public int packingMode; // 0x18
		public int atlasWidth; // 0x1C
		public int atlasHeight; // 0x20
		public int characterSetSelectionMode; // 0x24
		public string characterSequence; // 0x28
		public string referencedFontAssetGUID; // 0x30
		public string referencedTextAssetGUID; // 0x38
		public int fontStyle; // 0x40
		public float fontStyleModifier; // 0x44
		public int renderMode; // 0x48
		public bool includeFontFeatures; // 0x4C
	}

	public enum AtlasPopulationMode // TypeDefIndex: 56903
	{
		Static = 0,
		Dynamic = 1,
		DynamicOS = 2
	}

	[Serializable]
	public class FontAsset : TextAsset // TypeDefIndex: 56905
	{
		// Fields
		internal string m_SourceFontFileGUID; // 0x38
		private Font m_SourceFontFile; // 0x40
		private AtlasPopulationMode m_AtlasPopulationMode; // 0x48
		internal bool InternalDynamicOS; // 0x4C
		internal FaceInfo m_FaceInfo; // 0x50
		private int m_FamilyNameHashCode; // 0xB0
		private int m_StyleNameHashCode; // 0xB4
		private FontWeightPair[] m_FontWeightTable; // 0xB8
		internal List<Glyph> m_GlyphTable; // 0xC0
		internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0xC8
		internal List<Character> m_CharacterTable; // 0xD0
		internal Dictionary<uint, Character> m_CharacterLookupDictionary; // 0xD8
		internal Texture2D m_AtlasTexture; // 0xE0
		internal Texture2D[] m_AtlasTextures; // 0xE8
		internal int m_AtlasTextureIndex; // 0xF0
		private bool m_IsMultiAtlasTexturesEnabled; // 0xF4
		private bool m_ClearDynamicDataOnBuild; // 0xF5
		internal int m_AtlasWidth; // 0xF8
		internal int m_AtlasHeight; // 0xFC
		internal int m_AtlasPadding; // 0x100
		internal GlyphRenderMode m_AtlasRenderMode; // 0x104
		private List<GlyphRect> m_UsedGlyphRects; // 0x108
		private List<GlyphRect> m_FreeGlyphRects; // 0x110
		internal FontFeatureTable m_FontFeatureTable; // 0x118
		internal List<FontAsset> m_FallbackFontAssetTable; // 0x120
		internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings; // 0x128
		internal float m_RegularStyleWeight; // 0x178
		internal float m_RegularStyleSpacing; // 0x17C
		internal float m_BoldStyleWeight; // 0x180
		internal float m_BoldStyleSpacing; // 0x184
		internal byte m_ItalicStyleSlant; // 0x188
		internal byte m_TabMultiple; // 0x189
		internal bool IsFontAssetLookupTablesDirty; // 0x18A
		private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x00
		private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x08
		private static ProfilerMarker k_TryAddCharacterMarker; // 0x10
		private static ProfilerMarker k_TryAddCharactersMarker; // 0x18
		private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x20
		private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x28
		private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x30
		private static string s_DefaultMaterialSuffix; // 0x38
		private static HashSet<int> k_SearchedFontAssetLookup; // 0x40
		private static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x48
		private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x50
		private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; // 0x58
		private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x60
		private List<Glyph> m_GlyphsToRender; // 0x190
		private List<Glyph> m_GlyphsRendered; // 0x198
		private List<uint> m_GlyphIndexList; // 0x1A0
		private List<uint> m_GlyphIndexListNewlyAdded; // 0x1A8
		internal List<uint> m_GlyphsToAdd; // 0x1B0
		internal HashSet<uint> m_GlyphsToAddLookup; // 0x1B8
		internal List<Character> m_CharactersToAdd; // 0x1C0
		internal HashSet<uint> m_CharactersToAddLookup; // 0x1C8
		internal List<uint> s_MissingCharacterList; // 0x1D0
		internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x1D8
		internal static uint[] k_GlyphIndexArray; // 0x68
	
		// Properties
		public Font sourceFontFile { get => default; internal set {} } // 0x0000000185FE9010-0x0000000185FE9050 0x000000018BF645F8-0x000000018BF6463C
		public AtlasPopulationMode atlasPopulationMode { get => default; set {} } // 0x000000018BF64560-0x000000018BF64594 0x0000000185FBB320-0x0000000185FBB330
		public FaceInfo faceInfo { get => default; set {} } // 0x000000018BF645C4-0x000000018BF645F8 0x0000000185FB3300-0x0000000185FB3310
		internal int familyNameHashCode { get => default; set {} } // 0x0000000185FE8C10-0x0000000185FE8C20 0x0000000187A47500-0x0000000187A47514
		internal int styleNameHashCode { get => default; set {} } // 0x0000000185FE8C20-0x0000000185FE8C30 0x0000000187A47C1C-0x0000000187A47C30
		public FontWeightPair[] fontWeightTable { get => default; internal set {} } // 0x000000018BF64594-0x000000018BF645C4 0x0000000185FE8BC0-0x0000000185FE8BD0
		public List<Glyph> glyphTable { get => default; internal set {} } // 0x000000018774BD78-0x000000018774BD8C 0x000000018BF64530-0x000000018BF64560
		public Dictionary<uint, Glyph> glyphLookupTable { get => default; } // 0x000000018BF64490-0x000000018BF64524 
		public List<Character> characterTable { get => default; internal set {} } // 0x000000018BF64524-0x000000018BF64530 0x0000000187A47730-0x0000000187A47744
		public Dictionary<uint, Character> characterLookupTable { get => default; } // 0x0000000185FE8FC0-0x0000000185FE8FD0 
		public Texture2D atlasTexture { get => default; } // 0x0000000185FE90C0-0x0000000185FE90D0 
		public Texture2D[] atlasTextures { get => default; set {} } // 0x0000000185FB96A0-0x0000000185FB96B0 0x0000000185FE9000-0x0000000185FE9010
		public int atlasTextureCount { get => default; } // 0x0000000185FD3780-0x0000000185FD3790 
		public bool isMultiAtlasTexturesEnabled { get => default; set {} } // 0x0000000185FE8FD0-0x0000000185FE8FE0 0x0000000185FCD280-0x0000000185FCD290
		internal bool clearDynamicDataOnBuild { get => default; set {} } // 0x0000000185FE8F90-0x0000000185FE8FA0 0x0000000185FBB540-0x0000000185FBB550
		public int atlasWidth { get => default; internal set {} } // 0x0000000185FE8FA0-0x0000000185FE8FB0 0x0000000185FE9120-0x0000000185FE9130
		public int atlasHeight { get => default; internal set {} } // 0x0000000185FE8FB0-0x0000000185FE8FC0 0x0000000185FE9130-0x0000000185FE9140
		public int atlasPadding { get => default; internal set {} } // 0x0000000185FE9110-0x0000000185FE9120 0x0000000187A474C4-0x0000000187A474D8
		public GlyphRenderMode atlasRenderMode { get => default; internal set {} } // 0x0000000185FE90B0-0x0000000185FE90C0 0x00000001864735E0-0x00000001864735F4
		internal List<GlyphRect> usedGlyphRects { get => default; set {} } // 0x0000000185FE90A0-0x0000000185FE90B0 0x00000001864735F4-0x0000000186473608
		internal List<GlyphRect> freeGlyphRects { get => default; set {} } // 0x0000000185FE9050-0x0000000185FE9060 0x0000000186473590-0x00000001864735A4
		public FontFeatureTable fontFeatureTable { get => default; internal set {} } // 0x0000000185FE9060-0x0000000185FE90A0 0x000000018BF6463C-0x000000018BF64680
		public List<FontAsset> fallbackFontAssetTable { get => default; set {} } // 0x0000000185FE90F0-0x0000000185FE9100 0x0000000185FBBDC0-0x0000000185FBBDD0
		public FontAssetCreationEditorSettings fontAssetCreationEditorSettings { get => default; set {} } // 0x0000000185FE90E0-0x0000000185FE90F0 0x0000000185FBBE90-0x0000000185FBBEA0
		public float regularStyleWeight { get => default; set {} } // 0x0000000185FE8FF0-0x0000000185FE9000 0x0000000185FE9140-0x0000000185FE9150
		public float regularStyleSpacing { get => default; set {} } // 0x0000000185FE8FE0-0x0000000185FE8FF0 0x0000000185FBA120-0x0000000185FBA130
		public float boldStyleWeight { get => default; set {} } // 0x0000000185FE90D0-0x0000000185FE90E0 0x0000000185FBBB70-0x0000000185FBBB80
		public float boldStyleSpacing { get => default; set {} } // 0x0000000185FE9100-0x0000000185FE9110 0x0000000185FE9150-0x0000000185FE9160
		public byte italicStyleSlant { get => default; set {} } // 0x000000018BF5EBF8-0x000000018BF5EDDC 0x000000018BF5EA58-0x000000018BF5EB88
		public byte tabMultiple { get => default; set {} } // 0x000000018BF5EB88-0x000000018BF5EBF8 0x000000018BF5EDDC-0x000000018BF5EE80
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56904
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Character, uint> __9__144_0; // 0x08
			public static Func<Glyph, uint> __9__145_0; // 0x10
	
			// Constructors
			static __c() {} // 0x0000000185FE8B00-0x0000000185FE8B10
			public __c() {} // 0x0000000185F05C80-0x0000000185F05C90
	
			// Methods
			internal uint _SortCharacterTable_b__144_0(Character c) => default; // 0x0000000185FE7D20-0x0000000185FE7D30
			internal uint _SortGlyphTable_b__145_0(Glyph c) => default; // 0x0000000185FB05D0-0x0000000185FB05E0
		}
	
		// Constructors
		public FontAsset() {} // 0x000000018BE15B00-0x000000018BE15B18
		static FontAsset() {} // 0x000000018B584038-0x000000018B584050
	
		// Methods
		public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90 /* Metadata: 0x0207D203 */) => default; // 0x000000018BF5EE80-0x000000018BF5F02C
		private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.DynamicOS /* Metadata: 0x0207D205 */, bool enableMultiAtlasSupport = true /* Metadata: 0x0207D206 */) => default; // 0x000000018BF5E5B0-0x000000018BF5EA58
		public static FontAsset CreateFontAsset(Font font) => default; // 0x0000000185492010-0x0000000185492020
		public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic /* Metadata: 0x0207D207 */, bool enableMultiAtlasSupport = true /* Metadata: 0x0207D208 */) => default; // 0x000000018BF60614-0x000000018BF60664
		private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic /* Metadata: 0x0207D209 */, bool enableMultiAtlasSupport = true /* Metadata: 0x0207D20A */) => default; // 0x000000018BF60664-0x000000018BF6097C
		private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) => default; // 0x000000018BF60114-0x000000018BF60140
		private void Awake() {} // 0x000000018BF60140-0x000000018BF603B8
		private void OnDestroy() {} // 0x000000018BF5FF54-0x000000018BF60114
		public void ReadFontAssetDefinition() {} // 0x000000018BF603B8-0x000000018BF60584
		internal void InitializeDictionaryLookupTables() {} // 0x000000018BF5E024-0x000000018BF5E20C
		internal void InitializeGlyphLookupDictionary() {} // 0x000000018BF5DE08-0x000000018BF5E024
		internal void InitializeCharacterLookupDictionary() {} // 0x000000018BF5DDA0-0x000000018BF5DE08
		internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() {} // 0x000000018BF60584-0x000000018BF60614
		internal void AddSynthesizedCharactersAndFaceMetrics() {} // 0x000000018BF60D24-0x000000018BF60E90
		private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false /* Metadata: 0x0207D20B */) {} // 0x000000018BF60EB4-0x000000018BF61020
		internal void AddCharacterToLookupCache(uint unicode, Character character) {} // 0x000000018BF60E90-0x000000018BF60EB4
		private FontEngineError LoadFontFace() => default; // 0x000000018BF60CF8-0x000000018BF60D24
		internal void SortCharacterTable() {} // 0x000000018BF5F57C-0x000000018BF5F5E0
		internal void SortGlyphTable() {} // 0x000000018BF5F5E0-0x000000018BF5F924
		internal void SortFontFeatureTable() {} // 0x000000018BF5F34C-0x000000018BF5F57C
		internal void SortAllTables() {} // 0x000000018BF5FE00-0x000000018BF5FF54
		public bool HasCharacter(int character) => default; // 0x000000018BF5F9D0-0x000000018BF5FE00
		public bool HasCharacter(char character, bool searchFallbacks = false /* Metadata: 0x0207D20C */, bool tryAddCharacter = false /* Metadata: 0x0207D20D */) => default; // 0x000000018BF5F924-0x000000018BF5F9D0
		private bool HasCharacter_Internal(uint character, bool searchFallbacks = false /* Metadata: 0x0207D20E */, bool tryAddCharacter = false /* Metadata: 0x0207D20F */) => default; // 0x000000018BF5F1A4-0x000000018BF5F284
		public bool HasCharacters(string text, out List<char> missingCharacters) {
			missingCharacters = default;
			return default;
		} // 0x000000018BF5F0D8-0x000000018BF5F1A4
		public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false /* Metadata: 0x0207D210 */, bool tryAddCharacter = false /* Metadata: 0x0207D211 */) {
			missingCharacters = default;
			return default;
		} // 0x000000018BF5F284-0x000000018BF5F34C
		public bool HasCharacters(string text) => default; // 0x000000018BF60A48-0x000000018BF60B14
		public static string GetCharacters(FontAsset fontAsset) => default; // 0x000000018BF63790-0x000000018BF638C0
		public static int[] GetCharactersArray(FontAsset fontAsset) => default; // 0x000000018BF6097C-0x000000018BF60A48
		internal uint GetGlyphIndex(uint unicode) => default; // 0x000000018BF6350C-0x000000018BF63640
		internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset) {} // 0x000000018BF63748-0x000000018BF63790
		internal static void UpdateFontFeaturesForFontAssetsInQueue() {} // 0x000000018BF61938-0x000000018BF6195C
		internal static void RegisterAtlasTextureForApply(Texture2D texture) {} // 0x000000018BF6195C-0x000000018BF622D8
		internal static void UpdateAtlasTexturesInQueue() {} // 0x000000018BF61914-0x000000018BF61938
		internal static void UpdateFontAssetInUpdateQueue() {} // 0x000000018BF622D8-0x000000018BF62C30
		public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false /* Metadata: 0x0207D212 */) => default; // 0x000000018BF61020-0x000000018BF61914
		public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false /* Metadata: 0x0207D213 */) {
			missingUnicodes = default;
			return default;
		} // 0x000000018BF62F90-0x000000018BF63380
		public bool TryAddCharacters(string characters, bool includeFontFeatures = false /* Metadata: 0x0207D214 */) => default; // 0x0000000185492010-0x0000000185492020
		public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false /* Metadata: 0x0207D215 */) {
			missingCharacters = default;
			return default;
		} // 0x000000018BF62C30-0x000000018BF62F90
		internal bool TryAddCharacterInternal(uint unicode, out Character character, bool shouldGetFontFeatures = false /* Metadata: 0x0207D216 */) {
			character = default;
			return default;
		} // 0x000000018BF60B14-0x000000018BF60CF8
		internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out Character character, bool shouldGetFontFeatures = false /* Metadata: 0x0207D217 */) {
			character = default;
			return default;
		} // 0x000000018BF63380-0x000000018BF6350C
		internal void TryAddGlyphsToAtlasTextures() {} // 0x000000018BF63ADC-0x000000018BF63D2C
		private bool TryAddGlyphsToNewAtlasTexture() => default; // 0x000000018BF638C0-0x000000018BF63ADC
		private void SetupNewAtlasTexture() {} // 0x0000000185492010-0x0000000185492020
		internal void UpdateAtlasTexture() {} // 0x0000000185492010-0x0000000185492020
		internal void UpdateGlyphAdjustmentRecords() {}
		internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) {} // 0x000000018BF5E3F8-0x000000018BF5E434
		internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes) {} // 0x000000018BF5E3D4-0x000000018BF5E3F8
		internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes) {} // 0x000000018BF63640-0x000000018BF63748
		private void CopyListDataToArray<T>(List<T> srcList, ref ref T[] dstArray) {} // 0x000000018BF5E434-0x000000018BF5E5B0
		public void ClearFontAssetData(bool setAtlasSizeToZero = false /* Metadata: 0x0207D218 */) {} // 0x000000018BF5E20C-0x000000018BF5E3D4
		internal void ClearFontAssetDataInternal() {} // 0x000000018BF5F02C-0x000000018BF5F0D8
		internal void UpdateFontAssetData() {} // 0x000000018BF640AC-0x000000018BF64490
		internal void ClearFontAssetTables() {} // 0x000000018BF63D2C-0x000000018BF640AC
		internal void ClearAtlasTextures(bool setAtlasSizeToZero = false /* Metadata: 0x0207D219 */) {} // 0x000000018BF6D9A4-0x000000018BF6DA08
		private void DestroyAtlasTextures() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class FontAssetUtilities // TypeDefIndex: 56906
	{
		// Fields
		private static HashSet<int> k_SearchedAssets; // 0x00
	
		// Methods
		internal static Character GetCharacterFromFontAsset(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface) {
			isAlternativeTypeface = default;
			return default;
		} // 0x000000018BF5D6B8-0x000000018BF5D7D8
		private static Character GetCharacterFromFontAsset_Internal(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface) {
			isAlternativeTypeface = default;
			return default;
		} // 0x000000018BF5D31C-0x000000018BF5D6B8
		public static Character GetCharacterFromFontAssets(uint unicode, FontAsset sourceFontAsset, List<FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface) {
			isAlternativeTypeface = default;
			return default;
		} // 0x000000018BF5D7D8-0x000000018BF5D994
		public static SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) => default; // 0x000000018BF5DB24-0x000000018BF5DDA0
		private static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) => default; // 0x000000018BF5D994-0x000000018BF5DB24
	}

	[Serializable]
	public class FontFeatureTable // TypeDefIndex: 56908
	{
		// Fields
		internal List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
		internal Dictionary<uint, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; // 0x18
	
		// Properties
		internal List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56907
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<GlyphPairAdjustmentRecord, uint> __9__6_0; // 0x08
			public static Func<GlyphPairAdjustmentRecord, uint> __9__6_1; // 0x10
	
			// Constructors
			static __c() {} // 0x0000000185FC7990-0x0000000185FC79A0
			public __c() {} // 0x000000018BF648A0-0x000000018BF64960
	
			// Methods
			internal uint _SortGlyphPairAdjustmentRecords_b__6_0(GlyphPairAdjustmentRecord s) => default; // 0x000000018BF64680-0x000000018BF648A0
			internal uint _SortGlyphPairAdjustmentRecords_b__6_1(GlyphPairAdjustmentRecord s) => default; // 0x000000018BF6D8DC-0x000000018BF6D940
		}
	
		// Constructors
		public FontFeatureTable() {} // 0x0000000185FE91E0-0x0000000185FE91F0
	
		// Methods
		public void SortGlyphPairAdjustmentRecords() {} // 0x0000000185FE91F0-0x0000000185FE9200
	}

	internal struct Extents // TypeDefIndex: 56909
	{
		// Fields
		public Vector2 min; // 0x00
		public Vector2 max; // 0x08
	
		// Methods
		public override string ToString() => default; // 0x000000018BF5D198-0x000000018BF5D31C
	}

	internal struct LineInfo // TypeDefIndex: 56910
	{
		// Fields
		internal int controlCharacterCount; // 0x00
		public int characterCount; // 0x04
		public int visibleCharacterCount; // 0x08
		public int spaceCount; // 0x0C
		public int visibleSpaceCount; // 0x10
		public int wordCount; // 0x14
		public int firstCharacterIndex; // 0x18
		public int firstVisibleCharacterIndex; // 0x1C
		public int lastCharacterIndex; // 0x20
		public int lastVisibleCharacterIndex; // 0x24
		public float length; // 0x28
		public float lineHeight; // 0x2C
		public float ascender; // 0x30
		public float baseline; // 0x34
		public float descender; // 0x38
		public float maxAdvance; // 0x3C
		public float width; // 0x40
		public float marginLeft; // 0x44
		public float marginRight; // 0x48
		public TextAlignment alignment; // 0x4C
		public Extents lineExtents; // 0x50
	}

	internal struct LinkInfo // TypeDefIndex: 56911
	{
		// Fields
		public int hashCode; // 0x00
		public int linkIdFirstCharacterIndex; // 0x04
		public int linkIdLength; // 0x08
		public int linkTextfirstCharacterIndex; // 0x0C
		public int linkTextLength; // 0x10
		internal char[] linkId; // 0x18
	
		// Methods
		internal void SetLinkId(char[] text, int startIndex, int length) {} // 0x000000018BF64960-0x000000018BF64A24
	}

	internal static class MaterialManager // TypeDefIndex: 56912
	{
		// Fields
		private static Dictionary<long, Material> s_FallbackMaterials; // 0x00
	
		// Constructors
		static MaterialManager() {} // 0x000000018BF64F78-0x000000018BF65004
	
		// Methods
		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) => default; // 0x000000018BF64A24-0x000000018BF64DB4
		public static Material GetFallbackMaterial(FontAsset fontAsset, Material sourceMaterial, int atlasIndex) => default; // 0x000000018BF64DB4-0x000000018BF64F78
	}

	internal struct MaterialReference // TypeDefIndex: 56913
	{
		// Fields
		public int index; // 0x00
		public FontAsset fontAsset; // 0x08
		public SpriteAsset spriteAsset; // 0x10
		public Material material; // 0x18
		public bool isDefaultMaterial; // 0x20
		public bool isFallbackMaterial; // 0x21
		public Material fallbackMaterial; // 0x28
		public float padding; // 0x30
		public int referenceCount; // 0x34
	
		// Constructors
		public MaterialReference(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding) {
			this.index = default;
			this.fontAsset = default;
			this.spriteAsset = default;
			this.material = default;
			isDefaultMaterial = default;
			isFallbackMaterial = default;
			fallbackMaterial = default;
			this.padding = default;
			referenceCount = default;
		} // 0x000000018BF65BF4-0x000000018BF65C9C
	
		// Methods
		public static int AddMaterialReference(Material material, FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) => default; // 0x000000018BF65808-0x000000018BF65A08
		public static int AddMaterialReference(Material material, SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) => default; // 0x000000018BF65A08-0x000000018BF65BF4
	}

	internal class MaterialReferenceManager // TypeDefIndex: 56914
	{
		// Fields
		private static MaterialReferenceManager s_Instance; // 0x00
		private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
		private Dictionary<int, FontAsset> m_FontAssetReferenceLookup; // 0x18
		private Dictionary<int, SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
		private Dictionary<int, TextColorGradient> m_ColorGradientReferenceLookup; // 0x28
	
		// Properties
		public static MaterialReferenceManager instance { get => default; } // 0x000000018BF65778-0x000000018BF65808 
	
		// Constructors
		public MaterialReferenceManager() {} // 0x000000018BF65620-0x000000018BF65778
	
		// Methods
		public static void AddFontAsset(FontAsset fontAsset) {} // 0x000000018BF651AC-0x000000018BF651DC
		private void AddFontAssetInternal(FontAsset fontAsset) {} // 0x000000018BF650CC-0x000000018BF651AC
		public static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset) {} // 0x000000018BF65334-0x000000018BF65370
		private void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset) {} // 0x000000018BF6527C-0x000000018BF65334
		public static void AddFontMaterial(int hashCode, Material material) {} // 0x000000018BF65240-0x000000018BF6527C
		private void AddFontMaterialInternal(int hashCode, Material material) {} // 0x000000018BF651DC-0x000000018BF65240
		public static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset) {} // 0x000000018BF65090-0x000000018BF650CC
		private void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset) {} // 0x000000018BF65004-0x000000018BF65090
		public static bool TryGetFontAsset(int hashCode, out FontAsset fontAsset) {
			fontAsset = default;
			return default;
		} // 0x000000018BF6548C-0x000000018BF654C8
		private bool TryGetFontAssetInternal(int hashCode, out FontAsset fontAsset) {
			fontAsset = default;
			return default;
		} // 0x000000018BF6541C-0x000000018BF6548C
		public static bool TryGetSpriteAsset(int hashCode, out SpriteAsset spriteAsset) {
			spriteAsset = default;
			return default;
		} // 0x000000018BF655E4-0x000000018BF65620
		private bool TryGetSpriteAssetInternal(int hashCode, out SpriteAsset spriteAsset) {
			spriteAsset = default;
			return default;
		} // 0x000000018BF65574-0x000000018BF655E4
		public static bool TryGetColorGradientPreset(int hashCode, out TextColorGradient gradientPreset) {
			gradientPreset = default;
			return default;
		} // 0x000000018BF653E0-0x000000018BF6541C
		private bool TryGetColorGradientPresetInternal(int hashCode, out TextColorGradient gradientPreset) {
			gradientPreset = default;
			return default;
		} // 0x000000018BF65370-0x000000018BF653E0
		public static bool TryGetMaterial(int hashCode, out Material material) {
			material = default;
			return default;
		} // 0x000000018BF65538-0x000000018BF65574
		private bool TryGetMaterialInternal(int hashCode, out Material material) {
			material = default;
			return default;
		} // 0x000000018BF654C8-0x000000018BF65538
	}

	internal enum VertexSortingOrder // TypeDefIndex: 56915
	{
		Normal = 0,
		Reverse = 1
	}

	internal struct MeshInfo // TypeDefIndex: 56916
	{
		// Fields
		private static readonly Color32 k_DefaultColor; // 0x00
		public int vertexCount; // 0x00
		public Vector3[] vertices; // 0x08
		public Vector2[] uvs0; // 0x10
		public Vector2[] uvs2; // 0x18
		public Color32[] colors32; // 0x20
		public int[] triangles; // 0x28
		public Material material; // 0x30
	
		// Constructors
		public MeshInfo(int size) {
			vertexCount = default;
			vertices = default;
			uvs0 = default;
			uvs2 = default;
			colors32 = default;
			triangles = default;
			material = default;
		} // 0x000000018BF66818-0x000000018BF66B0C
		static MeshInfo() {
			k_DefaultColor = default;
		} // 0x000000018BF667D8-0x000000018BF66818
	
		// Methods
		internal void ResizeMeshInfo(int size) {} // 0x000000018BF65D00-0x000000018BF65EEC
		internal void Clear(bool uploadChanges) {} // 0x000000018BF65CD0-0x000000018BF65D00
		internal void ClearUnusedVertices() {} // 0x000000018BF65C9C-0x000000018BF65CD0
		internal void SortGeometry(VertexSortingOrder order) {} // 0x000000018BF65EEC-0x000000018BF65F88
		internal void SwapVertexData(int src, int dst) {} // 0x000000018BF65F88-0x000000018BF667D8
	}

	public class SpriteAsset : TextAsset // TypeDefIndex: 56918
	{
		// Fields
		internal Dictionary<int, int> m_NameLookup; // 0x38
		internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x40
		internal FaceInfo m_FaceInfo; // 0x48
		internal Texture m_SpriteAtlasTexture; // 0xA8
		private List<SpriteCharacter> m_SpriteCharacterTable; // 0xB0
		internal Dictionary<uint, SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
		private List<SpriteGlyph> m_SpriteGlyphTable; // 0xC0
		internal Dictionary<uint, SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
		public List<SpriteAsset> fallbackSpriteAssets; // 0xD0
		internal bool m_IsSpriteAssetLookupTablesDirty; // 0xD8
		private static HashSet<int> k_searchedSpriteAssets; // 0x00
	
		// Properties
		public FaceInfo faceInfo { get => default; internal set {} } // 0x000000018BF67F74-0x000000018BF67FA4 0x0000000184784C70-0x0000000184784C90
		public Texture spriteSheet { get => default; internal set {} } // 0x000000018BF67F44-0x000000018BF67F74 0x0000000187A47500-0x0000000187A47514
		public List<SpriteCharacter> spriteCharacterTable { get => default; internal set {} } // 0x0000000185FE8C20-0x0000000185FE8C30 0x0000000187A47C1C-0x0000000187A47C30
		public Dictionary<uint, SpriteCharacter> spriteCharacterLookupTable { get => default; internal set {} } // 0x0000000185492010-0x0000000185492020 0x000000018BF67968-0x000000018BF67E68
		public List<SpriteGlyph> spriteGlyphTable { get => default; internal set {} } // 0x000000018BF66BF0-0x000000018BF66C6C 0x000000018BF66CAC-0x000000018BF66D38
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56917
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<SpriteGlyph, uint> __9__37_0; // 0x08
			public static Func<SpriteCharacter, uint> __9__38_0; // 0x10
	
			// Constructors
			static __c() {} // 0x0000000185FE9160-0x0000000185FE91A0
			public __c() {} // 0x000000018BE2C0D4-0x000000018BE2C114
	
			// Methods
			internal uint _SortGlyphTable_b__37_0(SpriteGlyph item) => default; // 0x0000000185FE8B60-0x0000000185FE8B70
			internal uint _SortCharacterTable_b__38_0(SpriteCharacter c) => default; // 0x000000018774BD8C-0x000000018774BDA0
		}
	
		// Constructors
		public SpriteAsset() {} // 0x000000018BE15B00-0x000000018BE15B18
	
		// Methods
		private void Awake() {} // 0x000000018BF66C6C-0x000000018BF66CAC
		public void UpdateLookupTables() {} // 0x000000018BF674A8-0x000000018BF67670
		public int GetSpriteIndexFromHashcode(int hashCode) => default; // 0x000000018BF67290-0x000000018BF673E8
		public int GetSpriteIndexFromUnicode(uint unicode) => default; // 0x000000018BF673E8-0x000000018BF674A8
		public int GetSpriteIndexFromName(string name) => default; // 0x000000018BF66F50-0x000000018BF67290
		public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x000000018BF66D38-0x000000018BF66E90
		private static SpriteAsset SearchForSpriteByUnicodeInternal(List<SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x000000018BF66E90-0x000000018BF66F50
		private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x000000018BF677FC-0x000000018BF67968
		public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, TextSettings textSettings = null) {
			spriteIndex = default;
			return default;
		} // 0x000000018BF67670-0x000000018BF677DC
		private static SpriteAsset SearchForSpriteByHashCodeInternal(List<SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x000000018BF677DC-0x000000018BF677FC
		private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) {
			spriteIndex = default;
			return default;
		} // 0x000000018BF67E68-0x000000018BF67F44
		public void SortGlyphTable() {} // 0x000000018BF6D940-0x000000018BF6D9A4
		internal void SortCharacterTable() {} // 0x0000000185492010-0x0000000185492020
		internal void SortGlyphAndCharacterTables() {} // 0x000000018B584038-0x000000018B584050
	}

	[Serializable]
	public class SpriteCharacter : TextElement // TypeDefIndex: 56919
	{
		// Fields
		private string m_Name; // 0x30
		private int m_HashCode; // 0x38
	
		// Properties
		public string name { get => default; } // 0x0000000185FE7B40-0x0000000185FE7B50 
	
		// Constructors
		public SpriteCharacter() {} // 0x0000000185FE6110-0x0000000185FE6120
	}

	[Serializable]
	public class SpriteGlyph : Glyph // TypeDefIndex: 56920
	{
		// Fields
		public Sprite sprite; // 0x48
	
		// Constructors
		public SpriteGlyph() {} // 0x000000018BE2C32C-0x000000018BE2C334
	}

	[Serializable]
	public abstract class TextAsset : ScriptableObject // TypeDefIndex: 56921
	{
		// Fields
		internal string m_Version; // 0x18
		internal int m_InstanceID; // 0x20
		internal int m_HashCode; // 0x24
		internal Material m_Material; // 0x28
		internal int m_MaterialHashCode; // 0x30
	
		// Properties
		public string version { get; internal set; } // 0x0000000185FC2A70-0x0000000185FC2A80 0x0000000184088E70-0x0000000184088E80
		public int instanceID { get; } // 0x000000018BF67FD0-0x000000018BF67FF4 
		public int hashCode { get; set; } // 0x000000018BF67FA4-0x000000018BF67FD0 0x0000000181424940-0x0000000181424950
		public Material material { get; set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public int materialHashCode { get; set; } // 0x000000018BF67FF4-0x000000018BF68084 0x00000001813D0A90-0x00000001813D0AA0
	
		// Constructors
		protected TextAsset() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	}

	public enum ColorGradientMode // TypeDefIndex: 56922
	{
		Single = 0,
		HorizontalGradient = 1,
		VerticalGradient = 2,
		FourCornersGradient = 3
	}

	[Serializable]
	public class TextColorGradient : ScriptableObject // TypeDefIndex: 56923
	{
		// Fields
		public ColorGradientMode colorMode; // 0x18
		public UnityEngine.Color topLeft; // 0x1C
		public UnityEngine.Color topRight; // 0x2C
		public UnityEngine.Color bottomLeft; // 0x3C
		public UnityEngine.Color bottomRight; // 0x4C
		private const ColorGradientMode k_DefaultColorMode = ColorGradientMode.FourCornersGradient; // Metadata: 0x0207D220
		private static readonly UnityEngine.Color k_DefaultColor; // 0x00
	
		// Constructors
		public TextColorGradient() {} // 0x000000018BF680C8-0x000000018BF68174
		public TextColorGradient(UnityEngine.Color color) {} // 0x000000018BE0968C-0x000000018BE096D0
		public TextColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3) {} // 0x000000018BE096D0-0x000000018BE09740
		static TextColorGradient() {} // 0x000000018BF68084-0x000000018BF680C8
	}

	public enum TextElementType : byte // TypeDefIndex: 56924
	{
		Character = 1,
		Sprite = 2
	}

	[Serializable]
	public abstract class TextElement // TypeDefIndex: 56925
	{
		// Fields
		protected TextElementType m_ElementType; // 0x10
		internal uint m_Unicode; // 0x14
		internal TextAsset m_TextAsset; // 0x18
		internal Glyph m_Glyph; // 0x20
		internal uint m_GlyphIndex; // 0x28
		internal float m_Scale; // 0x2C
	
		// Properties
		public TextElementType elementType { get; } // 0x0000000185FE8B10-0x0000000185FE8B20 
		public uint unicode { get; set; } // 0x0000000185FB1090-0x0000000185FB10A0 0x0000000185FBB0B0-0x0000000185FBB0C0
		public TextAsset textAsset { get; set; } // 0x0000000185FC2A70-0x0000000185FC2A80 0x0000000184088E70-0x0000000184088E80
		public Glyph glyph { get; set; } // 0x0000000185FE66B0-0x0000000185FE66C0 0x000000018646EE40-0x000000018646EE50
		public uint glyphIndex { get; set; } // 0x0000000185FE7B60-0x0000000185FE7B70 0x0000000181C9A5C0-0x0000000181C9A5D0
		public float scale { get; set; } // 0x0000000185FE8D20-0x0000000185FE8D30 0x0000000185FB09B0-0x0000000185FB09C0
	
		// Constructors
		protected TextElement() {} // 0x0000000185492010-0x0000000185492020
	}

	internal struct TextVertex // TypeDefIndex: 56926
	{
		// Fields
		public Vector3 position; // 0x00
		public Vector2 uv; // 0x0C
		public Vector2 uv2; // 0x14
		public Vector2 uv4; // 0x1C
		public Color32 color; // 0x24
	}

	internal struct TextElementInfo // TypeDefIndex: 56927
	{
		// Fields
		public char character; // 0x00
		public int index; // 0x04
		public TextElementType elementType; // 0x08
		public TextElement textElement; // 0x10
		public FontAsset fontAsset; // 0x18
		public SpriteAsset spriteAsset; // 0x20
		public int spriteIndex; // 0x28
		public Material material; // 0x30
		public int materialReferenceIndex; // 0x38
		public bool isUsingAlternateTypeface; // 0x3C
		public float pointSize; // 0x40
		public int lineNumber; // 0x44
		public int pageNumber; // 0x48
		public int vertexIndex; // 0x4C
		public TextVertex vertexTopLeft; // 0x50
		public TextVertex vertexBottomLeft; // 0x78
		public TextVertex vertexTopRight; // 0xA0
		public TextVertex vertexBottomRight; // 0xC8
		public Vector3 topLeft; // 0xF0
		public Vector3 bottomLeft; // 0xFC
		public Vector3 topRight; // 0x108
		public Vector3 bottomRight; // 0x114
		public float origin; // 0x120
		public float ascender; // 0x124
		public float baseLine; // 0x128
		public float descender; // 0x12C
		public float xAdvance; // 0x130
		public float aspectRatio; // 0x134
		public float scale; // 0x138
		public Color32 color; // 0x13C
		public Color32 underlineColor; // 0x140
		public Color32 strikethroughColor; // 0x144
		public Color32 highlightColor; // 0x148
		public FontStyles style; // 0x14C
		public bool isVisible; // 0x150
	}

	internal enum TextOverflowMode // TypeDefIndex: 56928
	{
		Overflow = 0,
		Ellipsis = 1,
		Masking = 2,
		Truncate = 3,
		ScrollRect = 4,
		Page = 5,
		Linked = 6
	}

	internal enum TextureMapping // TypeDefIndex: 56929
	{
		Character = 0,
		Line = 1,
		Paragraph = 2,
		MatchAspect = 3
	}

	internal class TextGenerationSettings : IEquatable<TextGenerationSettings> // TypeDefIndex: 56930
	{
		// Fields
		public string text; // 0x10
		public Rect screenRect; // 0x18
		public Vector4 margins; // 0x28
		public float scale; // 0x38
		public FontAsset fontAsset; // 0x40
		public Material material; // 0x48
		public SpriteAsset spriteAsset; // 0x50
		public TextStyleSheet styleSheet; // 0x58
		public FontStyles fontStyle; // 0x60
		public TextSettings textSettings; // 0x68
		public TextAlignment textAlignment; // 0x70
		public TextOverflowMode overflowMode; // 0x74
		public bool wordWrap; // 0x78
		public float wordWrappingRatio; // 0x7C
		public UnityEngine.Color color; // 0x80
		public TextColorGradient fontColorGradient; // 0x90
		public bool tintSprites; // 0x98
		public bool overrideRichTextColors; // 0x99
		public float fontSize; // 0x9C
		public bool autoSize; // 0xA0
		public float fontSizeMin; // 0xA4
		public float fontSizeMax; // 0xA8
		public bool enableKerning; // 0xAC
		public bool richText; // 0xAD
		public bool isRightToLeft; // 0xAE
		public bool extraPadding; // 0xAF
		public bool parseControlCharacters; // 0xB0
		public float characterSpacing; // 0xB4
		public float wordSpacing; // 0xB8
		public float lineSpacing; // 0xBC
		public float paragraphSpacing; // 0xC0
		public float lineSpacingMax; // 0xC4
		public int maxVisibleCharacters; // 0xC8
		public int maxVisibleWords; // 0xCC
		public int maxVisibleLines; // 0xD0
		public int firstVisibleCharacter; // 0xD4
		public bool useMaxVisibleDescender; // 0xD8
		public TextFontWeight fontWeight; // 0xDC
		public int pageToDisplay; // 0xE0
		public TextureMapping horizontalMapping; // 0xE4
		public TextureMapping verticalMapping; // 0xE8
		public float uvLineOffset; // 0xEC
		public VertexSortingOrder geometrySortingOrder; // 0xF0
		public bool inverseYAxis; // 0xF4
		public float charWidthMaxAdj; // 0xF8
	
		// Constructors
		public TextGenerationSettings() {} // 0x000000018BF69DCC-0x000000018BF69E5C
	
		// Methods
		public bool Equals(TextGenerationSettings other) => default; // 0x000000018BF68174-0x000000018BF685A0
		public override bool Equals(object obj) => default; // 0x000000018BF685A0-0x000000018BF6863C
		public override int GetHashCode() => default; // 0x000000018BF6863C-0x000000018BF68B48
		public override string ToString() => default; // 0x000000018BF68B48-0x000000018BF69DCC
	}

	internal class TextGenerator // TypeDefIndex: 56932
	{
		// Fields
		private static TextGenerator s_TextGenerator; // 0x00
		private Vector3[] m_RectTransformCorners; // 0x10
		private float m_MarginWidth; // 0x18
		private float m_MarginHeight; // 0x1C
		private int[] m_CharBuffer; // 0x20
		private float m_PreferredWidth; // 0x28
		private float m_PreferredHeight; // 0x2C
		private FontAsset m_CurrentFontAsset; // 0x30
		private Material m_CurrentMaterial; // 0x38
		private int m_CurrentMaterialIndex; // 0x40
		private TextProcessingStack<MaterialReference> m_MaterialReferenceStack; // 0x48
		private float m_Padding; // 0xA0
		private SpriteAsset m_CurrentSpriteAsset; // 0xA8
		private int m_TotalCharacterCount; // 0xB0
		private float m_FontScale; // 0xB4
		private float m_FontSize; // 0xB8
		private float m_FontScaleMultiplier; // 0xBC
		private float m_CurrentFontSize; // 0xC0
		private TextProcessingStack<float> m_SizeStack; // 0xC8
		private FontStyles m_FontStyleInternal; // 0xE8
		private FontStyleStack m_FontStyleStack; // 0xEC
		private TextFontWeight m_FontWeightInternal; // 0xF8
		private TextProcessingStack<TextFontWeight> m_FontWeightStack; // 0x100
		private TextAlignment m_LineJustification; // 0x120
		private TextProcessingStack<TextAlignment> m_LineJustificationStack; // 0x128
		private float m_BaselineOffset; // 0x148
		private TextProcessingStack<float> m_BaselineOffsetStack; // 0x150
		private Color32 m_FontColor32; // 0x170
		private Color32 m_HtmlColor; // 0x174
		private Color32 m_UnderlineColor; // 0x178
		private Color32 m_StrikethroughColor; // 0x17C
		private TextProcessingStack<Color32> m_ColorStack; // 0x180
		private TextProcessingStack<Color32> m_UnderlineColorStack; // 0x1A0
		private TextProcessingStack<Color32> m_StrikethroughColorStack; // 0x1C0
		private TextProcessingStack<Color32> m_HighlightColorStack; // 0x1E0
		private TextColorGradient m_ColorGradientPreset; // 0x200
		private TextProcessingStack<TextColorGradient> m_ColorGradientStack; // 0x208
		private TextProcessingStack<int> m_ActionStack; // 0x230
		private bool m_IsFxMatrixSet; // 0x250
		private float m_LineOffset; // 0x254
		private float m_LineHeight; // 0x258
		private float m_CSpacing; // 0x25C
		private float m_MonoSpacing; // 0x260
		private float m_XAdvance; // 0x264
		private float m_TagLineIndent; // 0x268
		private float m_TagIndent; // 0x26C
		private TextProcessingStack<float> m_IndentStack; // 0x270
		private bool m_TagNoParsing; // 0x290
		private int m_CharacterCount; // 0x294
		private int m_FirstCharacterOfLine; // 0x298
		private int m_LastCharacterOfLine; // 0x29C
		private int m_FirstVisibleCharacterOfLine; // 0x2A0
		private int m_LastVisibleCharacterOfLine; // 0x2A4
		private float m_MaxLineAscender; // 0x2A8
		private float m_MaxLineDescender; // 0x2AC
		private int m_LineNumber; // 0x2B0
		private int m_LineVisibleCharacterCount; // 0x2B4
		private int m_FirstOverflowCharacterIndex; // 0x2B8
		private int m_PageNumber; // 0x2BC
		private float m_MarginLeft; // 0x2C0
		private float m_MarginRight; // 0x2C4
		private float m_Width; // 0x2C8
		private Extents m_MeshExtents; // 0x2CC
		private float m_MaxCapHeight; // 0x2DC
		private float m_MaxAscender; // 0x2E0
		private float m_MaxDescender; // 0x2E4
		private bool m_IsNewPage; // 0x2E8
		private bool m_IsNonBreakingSpace; // 0x2E9
		private WordWrapState m_SavedWordWrapState; // 0x2F0
		private WordWrapState m_SavedLineState; // 0x600
		private int m_LoopCountA; // 0x910
		private TextElementType m_TextElementType; // 0x914
		private bool m_IsParsingText; // 0x915
		private int m_SpriteIndex; // 0x918
		private Color32 m_SpriteColor; // 0x91C
		private TextElement m_CachedTextElement; // 0x920
		private Color32 m_HighlightColor; // 0x928
		private float m_CharWidthAdjDelta; // 0x92C
		private Matrix4x4 m_FxMatrix; // 0x930
		private float m_MaxFontSize; // 0x970
		private float m_MinFontSize; // 0x974
		private bool m_IsCharacterWrappingEnabled; // 0x978
		private float m_StartOfLineAscender; // 0x97C
		private float m_LineSpacingDelta; // 0x980
		private bool m_IsMaskingEnabled; // 0x984
		private MaterialReference[] m_MaterialReferences; // 0x988
		private int m_SpriteCount; // 0x990
		private TextProcessingStack<int> m_StyleStack; // 0x998
		private int m_SpriteAnimationId; // 0x9B8
		private uint[] m_InternalTextParsingBuffer; // 0x9C0
		private RichTextTagAttribute[] m_Attributes; // 0x9C8
		private XmlTagAttribute[] m_XmlAttribute; // 0x9D0
		private char[] m_RichTextTag; // 0x9D8
		private Dictionary<int, int> m_MaterialReferenceIndexLookup; // 0x9E0
		private bool m_IsCalculatingPreferredValues; // 0x9E8
		private SpriteAsset m_DefaultSpriteAsset; // 0x9F0
		private bool m_TintSprite; // 0x9F8
		protected SpecialCharacter m_Ellipsis; // 0xA00
		protected SpecialCharacter m_Underline; // 0xA20
		private bool m_IsUsingBold; // 0xA40
		private bool m_IsSdfShader; // 0xA41
		private TextElementInfo[] m_InternalTextElementInfo; // 0xA48
		private int m_RecursiveCount; // 0xA50
	
		// Nested types
		protected struct SpecialCharacter // TypeDefIndex: 56931
		{
			// Fields
			public Character character; // 0x00
			public FontAsset fontAsset; // 0x08
			public Material material; // 0x10
			public int materialIndex; // 0x18
	
			// Constructors
			public SpecialCharacter(Character character, int materialIndex) {
				this.character = default;
				fontAsset = default;
				material = default;
				this.materialIndex = default;
			} // 0x000000018BF5585C-0x000000018BF558EC
		}
	
		// Constructors
		public TextGenerator() {} // 0x000000018BF66B0C-0x000000018BF66BF0
	
		// Methods
		private static TextGenerator GetTextGenerator() => default; // 0x000000018BF54D04-0x000000018BF54E44
		public static void GenerateText(TextGenerationSettings settings, TextInfo textInfo) {} // 0x000000018BF54E44-0x000000018BF54FDC
		public static Vector2 GetCursorPosition(TextInfo textInfo, Rect screenRect, int index, bool inverseYAxis = true /* Metadata: 0x0207D22E */) => default; // 0x000000018BF553F4-0x000000018BF554F8
		public static Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo) => default; // 0x000000018BF55A34-0x000000018BF55B84
		private void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo) {} // 0x000000018BF47554-0x000000018BF513AC
		private void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo) {} // 0x000000018BF57114-0x000000018BF575A8
		private void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo) {} // 0x000000018BF55B84-0x000000018BF5607C
		protected int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo) => default; // 0x000000018BF58684-0x000000018BF5C99C
		protected bool ValidateHtmlTag(int[] chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo) {
			endIndex = default;
			return default;
		} // 0x000000018BF5607C-0x000000018BF5697C
		private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) {} // 0x000000018BF5697C-0x000000018BF57114
		private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) {} // 0x000000018BF53A98-0x000000018BF54D04
		private void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo) {} // 0x000000018BF5344C-0x000000018BF53A98
		private void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo) {} // 0x000000018BF53310-0x000000018BF53334
		private static void ClearMesh(bool updateMesh, TextInfo textInfo) {} // 0x0000000185FE8F80-0x0000000185FE8F90
		private void EnableMasking() {} // 0x0000000185FE8F70-0x0000000185FE8F80
		private void DisableMasking() {} // 0x000000018BF575A8-0x000000018BF58684
		private void SetArraySizes(int[] chars, TextGenerationSettings generationSettings, TextInfo textInfo) {} // 0x000000018BF55528-0x000000018BF5585C
		internal TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface) {
			isUsingAlternativeTypeface = default;
			return default;
		} // 0x000000018BF53334-0x000000018BF5344C
		private void ComputeMarginSize(Rect rect, Vector4 margins) {} // 0x000000018BF554F8-0x000000018BF55528
		protected void GetSpecialCharacters(TextGenerationSettings generationSettings) {} // 0x000000018BF54FDC-0x000000018BF551D8
		protected void GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings) {} // 0x000000018BF558EC-0x000000018BF55A34
		protected void GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings) {} // 0x000000018BF551D8-0x000000018BF552D8
		private float GetPaddingForMaterial(Material material, bool extraPadding) => default; // 0x000000018BF552D8-0x000000018BF553F4
		private Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo) => default; // 0x000000018BF513AC-0x000000018BF53310
		protected virtual Vector2 CalculatePreferredValues(float defaultFontSize, Vector2 marginSize, bool ignoreTextAutoSizing, TextGenerationSettings generationSettings, TextInfo textInfo) => default; // 0x000000018BF5C99C-0x000000018BF5D064
	}

	internal enum TextAlignment // TypeDefIndex: 56933
	{
		TopLeft = 257,
		TopCenter = 258,
		TopRight = 260,
		TopJustified = 264,
		TopFlush = 272,
		TopGeoAligned = 288,
		MiddleLeft = 513,
		MiddleCenter = 514,
		MiddleRight = 516,
		MiddleJustified = 520,
		MiddleFlush = 528,
		MiddleGeoAligned = 544,
		BottomLeft = 1025,
		BottomCenter = 1026,
		BottomRight = 1028,
		BottomJustified = 1032,
		BottomFlush = 1040,
		BottomGeoAligned = 1056,
		BaselineLeft = 2049,
		BaselineCenter = 2050,
		BaselineRight = 2052,
		BaselineJustified = 2056,
		BaselineFlush = 2064,
		BaselineGeoAligned = 2080,
		MidlineLeft = 4097,
		MidlineCenter = 4098,
		MidlineRight = 4100,
		MidlineJustified = 4104,
		MidlineFlush = 4112,
		MidlineGeoAligned = 4128,
		CaplineLeft = 8193,
		CaplineCenter = 8194,
		CaplineRight = 8196,
		CaplineJustified = 8200,
		CaplineFlush = 8208,
		CaplineGeoAligned = 8224
	}

	public enum FontStyles // TypeDefIndex: 56934
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
		Highlight = 512
	}

	internal struct XmlTagAttribute // TypeDefIndex: 56935
	{
		// Fields
		public int nameHashCode; // 0x00
		public TagValueType valueType; // 0x04
		public int valueStartIndex; // 0x08
		public int valueLength; // 0x0C
		public int valueHashCode; // 0x10
	}

	internal struct RichTextTagAttribute // TypeDefIndex: 56936
	{
		// Fields
		public int nameHashCode; // 0x00
		public int valueHashCode; // 0x04
		public TagValueType valueType; // 0x08
		public int valueStartIndex; // 0x0C
		public int valueLength; // 0x10
	}

	internal struct WordWrapState // TypeDefIndex: 56937
	{
		// Fields
		public int previousWordBreak; // 0x00
		public int totalCharacterCount; // 0x04
		public int visibleCharacterCount; // 0x08
		public int visibleSpriteCount; // 0x0C
		public int visibleLinkCount; // 0x10
		public int firstCharacterIndex; // 0x14
		public int firstVisibleCharacterIndex; // 0x18
		public int lastCharacterIndex; // 0x1C
		public int lastVisibleCharIndex; // 0x20
		public int lineNumber; // 0x24
		public float maxCapHeight; // 0x28
		public float maxAscender; // 0x2C
		public float maxDescender; // 0x30
		public float maxLineAscender; // 0x34
		public float maxLineDescender; // 0x38
		public float previousLineAscender; // 0x3C
		public float xAdvance; // 0x40
		public float preferredWidth; // 0x44
		public float preferredHeight; // 0x48
		public float previousLineScale; // 0x4C
		public int wordCount; // 0x50
		public FontStyles fontStyle; // 0x54
		public float fontScale; // 0x58
		public float fontScaleMultiplier; // 0x5C
		public float currentFontSize; // 0x60
		public float baselineOffset; // 0x64
		public float lineOffset; // 0x68
		public TextInfo textInfo; // 0x70
		public LineInfo lineInfo; // 0x78
		public Color32 vertexColor; // 0xD8
		public Color32 underlineColor; // 0xDC
		public Color32 strikethroughColor; // 0xE0
		public Color32 highlightColor; // 0xE4
		public FontStyleStack basicStyleStack; // 0xE8
		public TextProcessingStack<Color32> colorStack; // 0xF8
		public TextProcessingStack<Color32> underlineColorStack; // 0x118
		public TextProcessingStack<Color32> strikethroughColorStack; // 0x138
		public TextProcessingStack<Color32> highlightColorStack; // 0x158
		public TextProcessingStack<TextColorGradient> colorGradientStack; // 0x178
		public TextProcessingStack<float> sizeStack; // 0x1A0
		public TextProcessingStack<float> indentStack; // 0x1C0
		public TextProcessingStack<TextFontWeight> fontWeightStack; // 0x1E0
		public TextProcessingStack<int> styleStack; // 0x200
		public TextProcessingStack<float> baselineStack; // 0x220
		public TextProcessingStack<int> actionStack; // 0x240
		public TextProcessingStack<MaterialReference> materialReferenceStack; // 0x260
		public TextProcessingStack<TextAlignment> lineJustificationStack; // 0x2B8
		public int spriteAnimationId; // 0x2D8
		public FontAsset currentFontAsset; // 0x2E0
		public SpriteAsset currentSpriteAsset; // 0x2E8
		public Material currentMaterial; // 0x2F0
		public int currentMaterialIndex; // 0x2F8
		public Extents meshExtents; // 0x2FC
		public bool tagNoParsing; // 0x30C
		public bool isNonBreakingSpace; // 0x30D
	}

	internal static class TextGeneratorUtilities // TypeDefIndex: 56938
	{
		// Fields
		public static readonly Vector2 largePositiveVector2; // 0x00
		public static readonly Vector2 largeNegativeVector2; // 0x08
	
		// Constructors
		static TextGeneratorUtilities() {} // 0x000000018BF6D880-0x000000018BF6D8DC
	
		// Methods
		public static bool Approximately(float a, float b) => default; // 0x000000018BE14944-0x000000018BE14968
		public static Color32 HexCharsToColor(char[] hexChars, int tagCount) => default; // 0x000000018BF6B9EC-0x000000018BF6C04C
		public static Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) => default; // 0x000000018BF6C04C-0x000000018BF6C2B4
		public static int HexToInt(char hex) => default; // 0x000000018BF6C2B4-0x000000018BF6C3EC
		public static float ConvertToFloat(char[] chars, int startIndex, int length) => default; // 0x000000018BF6A3D0-0x000000018BF6A43C
		public static float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) {
			lastIndex = default;
			return default;
		} // 0x000000018BF6A280-0x000000018BF6A3D0
		public static Vector2 PackUV(float x, float y, float scale) => default; // 0x0000000185FE91A0-0x0000000185FE91E0
		public static void StringToCharArray(string sourceText, ref int[] charBuffer, ref TextProcessingStack<int> styleStack, TextGenerationSettings generationSettings) {} // 0x000000018BF6D064-0x000000018BF6D880
		private static void ResizeInternalArray<T>(ref ref T[] array) {}
		private static bool IsTagName(ref string text, string tag, int index) => default; // 0x000000018BF6C3EC-0x000000018BF6C490
		private static bool IsTagName(ref int[] text, string tag, int index) => default; // 0x000000018BF6C490-0x000000018BF6C540
		private static bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref int[] charBuffer, ref int writeIndex, ref TextProcessingStack<int> styleStack, ref TextGenerationSettings generationSettings) {
			srcOffset = default;
			return default;
		} // 0x000000018BF6C898-0x000000018BF6CB90
		private static bool ReplaceOpeningStyleTag(ref string sourceText, int srcIndex, out int srcOffset, ref int[] charBuffer, ref int writeIndex, ref TextProcessingStack<int> styleStack, ref TextGenerationSettings generationSettings) {
			srcOffset = default;
			return default;
		} // 0x000000018BF6CB90-0x000000018BF6CE8C
		private static void ReplaceClosingStyleTag(ref int[] charBuffer, ref int writeIndex, ref TextProcessingStack<int> styleStack, ref TextGenerationSettings generationSettings) {} // 0x000000018BF6C5C8-0x000000018BF6C898
		private static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode) => default; // 0x000000018BF6B5C0-0x000000018BF6B698
		private static int GetUtf32(string text, int i) => default; // 0x000000018BF6B898-0x000000018BF6B9EC
		private static int GetUtf16(string text, int i) => default; // 0x000000018BF6B7C0-0x000000018BF6B898
		private static int GetTagHashCode(ref int[] text, int index, out int closeIndex) {
			closeIndex = default;
			return default;
		} // 0x000000018BF6B738-0x000000018BF6B7C0
		private static int GetTagHashCode(ref string text, int index, out int closeIndex) {
			closeIndex = default;
			return default;
		} // 0x000000018BF6B698-0x000000018BF6B738
		public static void FillCharacterVertexBuffers(int i, TextGenerationSettings generationSettings, TextInfo textInfo) {} // 0x000000018BF6A43C-0x000000018BF6AD44
		public static void FillSpriteVertexBuffers(int i, TextGenerationSettings generationSettings, TextInfo textInfo) {} // 0x000000018BF6AD44-0x000000018BF6B5C0
		public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo) {} // 0x000000018BF69E5C-0x000000018BF6A280
		public static void ResizeLineExtents(int size, TextInfo textInfo) {} // 0x000000018BF6CE8C-0x000000018BF6D064
		public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle) => default; // 0x000000018BF6C5A4-0x000000018BF6C5C8
		public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor) => default; // 0x000000018BF6C540-0x000000018BF6C5A4
	}

	internal struct PageInfo // TypeDefIndex: 56939
	{
		// Fields
		public int firstCharacterIndex; // 0x00
		public int lastCharacterIndex; // 0x04
		public float ascender; // 0x08
		public float baseLine; // 0x0C
		public float descender; // 0x10
	}

	internal struct WordInfo // TypeDefIndex: 56940
	{
		// Fields
		public int firstCharacterIndex; // 0x00
		public int lastCharacterIndex; // 0x04
		public int characterCount; // 0x08
	}

	internal class TextInfo // TypeDefIndex: 56941
	{
		// Fields
		private static Vector2 s_InfinityVectorPositive; // 0x00
		private static Vector2 s_InfinityVectorNegative; // 0x08
		public int characterCount; // 0x10
		public int spriteCount; // 0x14
		public int spaceCount; // 0x18
		public int wordCount; // 0x1C
		public int linkCount; // 0x20
		public int lineCount; // 0x24
		public int pageCount; // 0x28
		public int materialCount; // 0x2C
		public TextElementInfo[] textElementInfo; // 0x30
		public WordInfo[] wordInfo; // 0x38
		public LinkInfo[] linkInfo; // 0x40
		public LineInfo[] lineInfo; // 0x48
		public PageInfo[] pageInfo; // 0x50
		public MeshInfo[] meshInfo; // 0x58
		public bool isDirty; // 0x60
	
		// Constructors
		public TextInfo() {} // 0x000000018BF6DFB0-0x000000018BF6E0D8
		static TextInfo() {} // 0x000000018BF6DF54-0x000000018BF6DFB0
	
		// Methods
		internal void Clear() {} // 0x000000018BF6DEF8-0x000000018BF6DF54
		internal void ClearMeshInfo(bool updateMesh) {} // 0x000000018BF6DE68-0x000000018BF6DEF8
		internal void ClearLineInfo() {} // 0x000000018BF6DC28-0x000000018BF6DE68
		internal static void Resize<T>(ref ref T[] array, int size) {}
		internal static void Resize<T>(ref ref T[] array, int size, bool isBlockAllocated) {}
	}

	internal enum MarkupTag // TypeDefIndex: 56942
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

	internal enum TagValueType // TypeDefIndex: 56943
	{
		None = 0,
		NumericalValue = 1,
		StringValue = 2,
		ColorValue = 4
	}

	internal enum TagUnitType // TypeDefIndex: 56944
	{
		Pixels = 0,
		FontUnits = 1,
		Percentage = 2
	}

	internal struct FontStyleStack // TypeDefIndex: 56945
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
		public byte Add(FontStyles style) => default; // 0x000000018BF6DA38-0x000000018BF6DB04
		public byte Remove(FontStyles style) => default; // 0x000000018BF6DB04-0x000000018BF6DC28
	}

	internal struct TextProcessingStack<T> // TypeDefIndex: 56946
	{
		// Fields
		public T[] itemStack;
		public int index;
		private T m_DefaultItem;
		private int m_Capacity;
		private int m_RolloverSize;
		private int m_Count;
	
		// Constructors
		public TextProcessingStack(T[] stack) {
			itemStack = default;
			index = default;
			m_DefaultItem = default;
			m_Capacity = default;
			m_RolloverSize = default;
			m_Count = default;
		}
		public TextProcessingStack(int capacity) {
			itemStack = default;
			index = default;
			m_DefaultItem = default;
			m_Capacity = default;
			m_RolloverSize = default;
			m_Count = default;
		}
	
		// Methods
		public void Clear() {}
		public void SetDefault(T item) {}
		public void Add(T item) {}
		public T Remove() => default;
		public void Push(T item) {}
		public T Pop() => default;
		public T Peek() => default;
		public T CurrentItem() => default;
	}

	internal class TextResourceManager // TypeDefIndex: 56948
	{
		// Fields
		private static readonly Dictionary<int, FontAssetRef> s_FontAssetReferences; // 0x00
		private static readonly Dictionary<int, FontAsset> s_FontAssetNameReferenceLookup; // 0x08
		private static readonly Dictionary<long, FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; // 0x10
		private static readonly List<int> s_FontAssetRemovalList; // 0x18
		private static readonly int k_RegularStyleHashCode; // 0x20
	
		// Nested types
		private struct FontAssetRef // TypeDefIndex: 56947
		{
			// Fields
			public int nameHashCode; // 0x00
			public int familyNameHashCode; // 0x04
			public int styleNameHashCode; // 0x08
			public long familyNameAndStyleHashCode; // 0x10
			public readonly FontAsset fontAsset; // 0x18
	
			// Constructors
			public FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, FontAsset fontAsset) {
				this.nameHashCode = default;
				this.familyNameHashCode = default;
				this.styleNameHashCode = default;
				familyNameAndStyleHashCode = default;
				this.fontAsset = default;
			} // 0x000000018BF6E0D8-0x000000018BF6E648
		}
	
		// Constructors
		public TextResourceManager() {} // Dummy constructor
		static TextResourceManager() {} // 0x000000018BF6DA08-0x000000018BF6DA38
	
		// Methods
		internal static void AddFontAsset(FontAsset fontAsset) {} // 0x000000018BF6E648-0x000000018BF6E840
	}

	[Serializable]
	public class TextSettings : ScriptableObject // TypeDefIndex: 56950
	{
		// Fields
		protected string m_Version; // 0x18
		protected FontAsset m_DefaultFontAsset; // 0x20
		protected string m_DefaultFontAssetPath; // 0x28
		protected List<FontAsset> m_FallbackFontAssets; // 0x30
		protected bool m_MatchMaterialPreset; // 0x38
		protected int m_MissingCharacterUnicode; // 0x3C
		protected bool m_ClearDynamicDataOnBuild; // 0x40
		protected SpriteAsset m_DefaultSpriteAsset; // 0x48
		protected string m_DefaultSpriteAssetPath; // 0x50
		protected List<SpriteAsset> m_FallbackSpriteAssets; // 0x58
		protected uint m_MissingSpriteCharacterUnicode; // 0x60
		protected TextStyleSheet m_DefaultStyleSheet; // 0x68
		protected string m_StyleSheetsResourcePath; // 0x70
		protected string m_DefaultColorGradientPresetsPath; // 0x78
		protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules; // 0x80
		protected bool m_DisplayWarnings; // 0x88
		internal Dictionary<int, FontAsset> m_FontLookup; // 0x90
		private List<FontReferenceMap> m_FontReferences; // 0x98
	
		// Properties
		public string version { get => default; internal set {} } // 0x0000000184088E70-0x0000000184088E80 0x00000001813B31A0-0x00000001813B31B0
		public FontAsset defaultFontAsset { get => default; set {} } // 0x000000018646EE40-0x000000018646EE50 0x00000001813B8590-0x00000001813B85A0
		public string defaultFontAssetPath { get => default; set {} } // 0x0000000184A4EDC0-0x0000000184A4EDD0 0x00000001813B51D0-0x00000001813B51E0
		public List<FontAsset> fallbackFontAssets { get => default; set {} } // 0x00000001864721F0-0x0000000186472200 0x0000000185FB0700-0x0000000185FB0710
		public bool matchMaterialPreset { get => default; set {} } // 0x0000000185FAFE20-0x0000000185FAFE30 0x0000000185FB0790-0x0000000185FB07A0
		public int missingCharacterUnicode { get => default; set {} } // 0x0000000185FB07A0-0x0000000185FB07B0 0x0000000185FB0650-0x0000000185FB0660
		public bool clearDynamicDataOnBuild { get => default; set {} } // 0x0000000185FB0660-0x0000000185FB0670 0x00000001813ECF20-0x00000001813ECF30
		public SpriteAsset defaultSpriteAsset { get => default; set {} } // 0x000000018571FEC0-0x000000018571FED0 0x0000000181460F60-0x0000000181460F70
		public string defaultSpriteAssetPath { get => default; set {} } // 0x0000000184A4E570-0x0000000184A4E580 0x00000001813F1630-0x00000001813F1640
		public List<SpriteAsset> fallbackSpriteAssets { get => default; set {} } // 0x0000000186472DB0-0x0000000186472DC0 0x000000018143E3B0-0x000000018143E3C0
		public uint missingSpriteCharacterUnicode { get => default; set {} } // 0x000000018143E3C0-0x000000018143E3D0 0x00000001813AC280-0x00000001813AC290
		public TextStyleSheet defaultStyleSheet { get => default; set {} } // 0x0000000185A62990-0x0000000185A629A0 0x0000000181460F70-0x0000000181460F80
		public string styleSheetsResourcePath { get => default; set {} } // 0x00000001874BE90C-0x00000001874BE91C 0x0000000183060C50-0x0000000183060C60
		public string defaultColorGradientPresetsPath { get => default; set {} } // 0x000000018738A324-0x000000018738A334 0x000000018BF6EE48-0x000000018BF6EEC4
		public UnicodeLineBreakingRules lineBreakingRules { get => default; set {} } // 0x00000001873CBE98-0x00000001873CBEA8 0x000000018316BFD0-0x000000018316BFE0
		public bool displayWarnings { get => default; set {} } // 0x0000000185FB0AB0-0x0000000185FB0AC0 0x000000018BF6EB40-0x000000018BF6ED38
	
		// Nested types
		[Serializable]
		private struct FontReferenceMap // TypeDefIndex: 56949
		{
			// Fields
			public Font font; // 0x00
			public FontAsset fontAsset; // 0x08
	
			// Constructors
			public FontReferenceMap(Font font, FontAsset fontAsset) {
				this.font = default;
				this.fontAsset = default;
			} // 0x0000000181377E40-0x0000000181377E50
		}
	
		// Constructors
		public TextSettings() {} // 0x000000018523F5B0-0x000000018523F5E0
	
		// Methods
		protected void InitializeFontReferenceLookup() {} // 0x000000018BF6E840-0x000000018BF6EB40
		protected FontAsset GetCachedFontAssetInternal(Font font) => default; // 0x000000018BF6ED38-0x000000018BF6EE48
	}

	public static class TextShaderUtilities // TypeDefIndex: 56951
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
		public static int ID_WeightNormal; // 0x28
		public static int ID_WeightBold; // 0x2C
		public static int ID_OutlineTex; // 0x30
		public static int ID_OutlineWidth; // 0x34
		public static int ID_OutlineSoftness; // 0x38
		public static int ID_OutlineColor; // 0x3C
		public static int ID_Outline2Color; // 0x40
		public static int ID_Outline2Width; // 0x44
		public static int ID_Padding; // 0x48
		public static int ID_GradientScale; // 0x4C
		public static int ID_ScaleX; // 0x50
		public static int ID_ScaleY; // 0x54
		public static int ID_PerspectiveFilter; // 0x58
		public static int ID_Sharpness; // 0x5C
		public static int ID_TextureWidth; // 0x60
		public static int ID_TextureHeight; // 0x64
		public static int ID_BevelAmount; // 0x68
		public static int ID_GlowColor; // 0x6C
		public static int ID_GlowOffset; // 0x70
		public static int ID_GlowPower; // 0x74
		public static int ID_GlowOuter; // 0x78
		public static int ID_GlowInner; // 0x7C
		public static int ID_LightAngle; // 0x80
		public static int ID_EnvMap; // 0x84
		public static int ID_EnvMatrix; // 0x88
		public static int ID_EnvMatrixRotation; // 0x8C
		public static int ID_MaskCoord; // 0x90
		public static int ID_ClipRect; // 0x94
		public static int ID_MaskSoftnessX; // 0x98
		public static int ID_MaskSoftnessY; // 0x9C
		public static int ID_VertexOffsetX; // 0xA0
		public static int ID_VertexOffsetY; // 0xA4
		public static int ID_UseClipRect; // 0xA8
		public static int ID_StencilID; // 0xAC
		public static int ID_StencilOp; // 0xB0
		public static int ID_StencilComp; // 0xB4
		public static int ID_StencilReadMask; // 0xB8
		public static int ID_StencilWriteMask; // 0xBC
		public static int ID_ShaderFlags; // 0xC0
		public static int ID_ScaleRatio_A; // 0xC4
		public static int ID_ScaleRatio_B; // 0xC8
		public static int ID_ScaleRatio_C; // 0xCC
		public static string Keyword_Bevel; // 0xD0
		public static string Keyword_Glow; // 0xD8
		public static string Keyword_Underlay; // 0xE0
		public static string Keyword_Ratios; // 0xE8
		public static string Keyword_MASK_SOFT; // 0xF0
		public static string Keyword_MASK_HARD; // 0xF8
		public static string Keyword_MASK_TEX; // 0x100
		public static string Keyword_Outline; // 0x108
		public static string ShaderTag_ZTestMode; // 0x110
		public static string ShaderTag_CullMode; // 0x118
		private static float m_clamp; // 0x120
		public static bool isInitialized; // 0x124
		private static Shader k_ShaderRef_MobileSDF; // 0x128
		private static Shader k_ShaderRef_MobileBitmap; // 0x130
	
		// Properties
		internal static Shader ShaderRef_MobileSDF { get; } // 0x000000018BF70AF4-0x000000018BF70C70 
		internal static Shader ShaderRef_MobileBitmap { get; } // 0x000000018BF70978-0x000000018BF70AF4 
	
		// Constructors
		static TextShaderUtilities() {} // 0x000000018BF70688-0x000000018BF70978
	
		// Methods
		internal static void GetShaderPropertyIDs() {} // 0x000000018BF6F67C-0x000000018BF6FFE0
		private static void UpdateShaderRatios(Material mat) {} // 0x000000018BF70168-0x000000018BF70688
		internal static bool IsMaskingEnabled(Material material) => default; // 0x000000018BF6FFE0-0x000000018BF70168
		internal static float GetPadding(Material material, bool enableExtraPadding, bool isBold) => default; // 0x000000018BF6EEC4-0x000000018BF6F67C
	}

	[Serializable]
	public class TextStyle // TypeDefIndex: 56952
	{
		// Fields
		internal static TextStyle k_NormalStyle; // 0x00
		private string m_Name; // 0x10
		private int m_HashCode; // 0x18
		private string m_OpeningDefinition; // 0x20
		private string m_ClosingDefinition; // 0x28
		private int[] m_OpeningTagArray; // 0x30
		private int[] m_ClosingTagArray; // 0x38
		internal uint[] m_OpeningTagUnicodeArray; // 0x40
		internal uint[] m_ClosingTagUnicodeArray; // 0x48
	
		// Properties
		public int hashCode { get => default; } // 0x0000000185FC9940-0x0000000185FC9950 
		public int[] styleOpeningTagArray { get => default; } // 0x0000000185FE7B40-0x0000000185FE7B50 
		public int[] styleClosingTagArray { get => default; } // 0x0000000185FE7CE0-0x0000000185FE7CF0 
	
		// Constructors
		public TextStyle() {} // Dummy constructor
	
		// Methods
		public void RefreshStyle() {} // 0x000000018BF70FB4-0x000000018BF711A0
	}

	[Serializable]
	public class TextStyleSheet : ScriptableObject // TypeDefIndex: 56953
	{
		// Fields
		private List<TextStyle> m_StyleList; // 0x18
		private Dictionary<int, TextStyle> m_StyleLookupDictionary; // 0x20
	
		// Properties
		internal List<TextStyle> styles { get => default; } // 0x0000000185FC2A70-0x0000000185FC2A80 
	
		// Constructors
		public TextStyleSheet() {} // 0x000000018BF70F30-0x000000018BF70FB4
	
		// Methods
		public TextStyle GetStyle(int hashCode) => default; // 0x000000018BF70C70-0x000000018BF70CEC
		public TextStyle GetStyle(string name) => default; // 0x000000018BF70CEC-0x000000018BF70D70
		public void RefreshStyles() {} // 0x000000018BF70F28-0x000000018BF70F30
		private void LoadStyleDictionaryInternal() {} // 0x000000018BF70D70-0x000000018BF70F28
	}

	internal static class TextUtilities // TypeDefIndex: 56954
	{
		// Methods
		internal static char ToUpperFast(char c) => default; // 0x000000018BF71254-0x000000018BF712AC
		internal static uint ToUpperASCIIFast(uint c) => default; // 0x000000018BF711FC-0x000000018BF71254
		public static int GetHashCodeCaseInSensitive(string s) => default; // 0x000000018BF711A0-0x000000018BF711FC
		internal static string UintToString(List<uint> unicodes) => default; // 0x000000018BF712AC-0x000000018BF7135C
	}

	[Serializable]
	public class UnicodeLineBreakingRules // TypeDefIndex: 56955
	{
		// Fields
		private static UnicodeLineBreakingRules s_Instance; // 0x00
		private TextAsset m_UnicodeLineBreakingRules; // 0x10
		private TextAsset m_LeadingCharacters; // 0x18
		private TextAsset m_FollowingCharacters; // 0x20
		private bool m_UseModernHangulLineBreakingRules; // 0x28
		private static HashSet<uint> s_LeadingCharactersLookup; // 0x08
		private static HashSet<uint> s_FollowingCharactersLookup; // 0x10
	
		// Properties
		internal HashSet<uint> leadingCharactersLookup { get => default; } // 0x000000018BF71840-0x000000018BF718B0 
		internal HashSet<uint> followingCharactersLookup { get => default; } // 0x000000018BF717D0-0x000000018BF71840 
	
		// Constructors
		public UnicodeLineBreakingRules() {} // 0x0000000185492010-0x0000000185492020
		static UnicodeLineBreakingRules() {} // 0x000000018BF7176C-0x000000018BF717D0
	
		// Methods
		internal static void LoadLineBreakingRules() {} // 0x000000018BF71420-0x000000018BF7176C
		private static HashSet<uint> GetCharacters(TextAsset file) => default; // 0x000000018BF7135C-0x000000018BF71420
	}
}
