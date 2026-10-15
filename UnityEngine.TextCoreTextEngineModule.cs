/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;

// Image 43: UnityEngine.TextCoreTextEngineModule.dll - Assembly: UnityEngine.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 86570-86628

namespace UnityEngine.TextCore.Text
{
	[Serializable]
	public class Character : TextElement // TypeDefIndex: 86571
	{
		// Constructors
		public Character(); // 0x000000018725F0A0-0x000000018725F0B0
		public Character(uint unicode, FontAsset fontAsset, Glyph glyph); // 0x000000018D57287C-0x000000018D5728D4
		internal Character(uint unicode, uint glyphIndex); // 0x000000018D41D96C-0x000000018D41D9AC
	}

	internal static class ColorUtilities // TypeDefIndex: 86572
	{
		// Methods
		internal static bool CompareColors(Color32 a, Color32 b); // 0x000000018D5728D4-0x000000018D57290C
		internal static Color32 MultiplyColors(Color32 c1, Color32 c2); // 0x000000018D57290C-0x000000018D5729E8
	}

	public enum TextFontWeight // TypeDefIndex: 86573
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
	public struct FontWeightPair // TypeDefIndex: 86574
	{
		// Fields
		public FontAsset regularTypeface; // 0x00
		public FontAsset italicTypeface; // 0x08
	}

	[Serializable]
	public struct FontAssetCreationEditorSettings // TypeDefIndex: 86575
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

	public enum AtlasPopulationMode // TypeDefIndex: 86576
	{
		Static = 0,
		Dynamic = 1,
		DynamicOS = 2
	}

	[Serializable]
	[ExcludeFromPreset]
	public class FontAsset : TextAsset // TypeDefIndex: 86578
	{
		// Fields
		[SerializeField]
		internal string m_SourceFontFileGUID; // 0x38
		[SerializeField]
		private Font m_SourceFontFile; // 0x40
		[SerializeField]
		private AtlasPopulationMode m_AtlasPopulationMode; // 0x48
		[SerializeField]
		internal bool InternalDynamicOS; // 0x4C
		[SerializeField]
		internal FaceInfo m_FaceInfo; // 0x50
		private int m_FamilyNameHashCode; // 0xB0
		private int m_StyleNameHashCode; // 0xB4
		[SerializeField]
		private FontWeightPair[] m_FontWeightTable; // 0xB8
		[SerializeField]
		internal List<Glyph> m_GlyphTable; // 0xC0
		internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0xC8
		[SerializeField]
		internal List<Character> m_CharacterTable; // 0xD0
		internal Dictionary<uint, Character> m_CharacterLookupDictionary; // 0xD8
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
		internal int m_AtlasWidth; // 0xF8
		[SerializeField]
		internal int m_AtlasHeight; // 0xFC
		[SerializeField]
		internal int m_AtlasPadding; // 0x100
		[SerializeField]
		internal GlyphRenderMode m_AtlasRenderMode; // 0x104
		[SerializeField]
		private List<GlyphRect> m_UsedGlyphRects; // 0x108
		[SerializeField]
		private List<GlyphRect> m_FreeGlyphRects; // 0x110
		[SerializeField]
		internal FontFeatureTable m_FontFeatureTable; // 0x118
		[SerializeField]
		internal List<FontAsset> m_FallbackFontAssetTable; // 0x120
		[SerializeField]
		internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings; // 0x128
		[FormerlySerializedAs("normalStyle")]
		[SerializeField]
		internal float m_RegularStyleWeight; // 0x178
		[FormerlySerializedAs("normalSpacingOffset")]
		[SerializeField]
		internal float m_RegularStyleSpacing; // 0x17C
		[FormerlySerializedAs("boldStyle")]
		[SerializeField]
		internal float m_BoldStyleWeight; // 0x180
		[FormerlySerializedAs("boldSpacing")]
		[SerializeField]
		internal float m_BoldStyleSpacing; // 0x184
		[FormerlySerializedAs("italicStyle")]
		[SerializeField]
		internal byte m_ItalicStyleSlant; // 0x188
		[FormerlySerializedAs("tabSize")]
		[SerializeField]
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
		public Font sourceFontFile { get; internal set; } // 0x0000000187261E60-0x0000000187261E70 0x00000001870EAAD0-0x00000001870EAAE0
		public AtlasPopulationMode atlasPopulationMode { get; set; } // 0x00000001872615F0-0x0000000187261600 0x0000000185E120B0-0x0000000185E120C0
		public FaceInfo faceInfo { get; set; } // 0x00000001872623A0-0x00000001872623E0 0x000000018D579D7C-0x000000018D579DC0
		internal int familyNameHashCode { get; set; } // 0x000000018D579CE4-0x000000018D579D18 0x000000018723DB00-0x000000018723DB10
		internal int styleNameHashCode { get; set; } // 0x000000018D579D48-0x000000018D579D7C 0x0000000185B8EB10-0x0000000185B8EB20
		public FontWeightPair[] fontWeightTable { get; internal set; } // 0x0000000187261F70-0x0000000187261F80 0x0000000188D80C28-0x0000000188D80C3C
		public List<Glyph> glyphTable { get; internal set; } // 0x0000000187261F80-0x0000000187261F90 0x0000000188D95540-0x0000000188D95554
		public Dictionary<uint, Glyph> glyphLookupTable { get; } // 0x000000018D579D18-0x000000018D579D48 
		public List<Character> characterTable { get; internal set; } // 0x0000000187261F20-0x0000000187261F30 0x0000000188A79A0C-0x0000000188A79A20
		public Dictionary<uint, Character> characterLookupTable { get; } // 0x000000018D579CB4-0x000000018D579CE4 
		public Texture2D atlasTexture { get; } // 0x000000018D579C14-0x000000018D579CA8 
		public Texture2D[] atlasTextures { get; set; } // 0x000000018D579CA8-0x000000018D579CB4 0x0000000188D62F7C-0x0000000188D62F90
		public int atlasTextureCount { get; } // 0x0000000187262350-0x0000000187262360 
		public bool isMultiAtlasTexturesEnabled { get; set; } // 0x0000000187262450-0x0000000187262460 0x0000000187255590-0x00000001872555A0
		internal bool clearDynamicDataOnBuild { get; set; } // 0x0000000187262390-0x00000001872623A0 0x00000001872555B0-0x00000001872555C0
		public int atlasWidth { get; internal set; } // 0x0000000187262360-0x0000000187262370 0x00000001828A9D50-0x00000001828A9D60
		public int atlasHeight { get; internal set; } // 0x0000000187262320-0x0000000187262330 0x000000018723D600-0x000000018723D610
		public int atlasPadding { get; internal set; } // 0x0000000187262330-0x0000000187262340 0x0000000187240770-0x0000000187240780
		public GlyphRenderMode atlasRenderMode { get; internal set; } // 0x0000000187262340-0x0000000187262350 0x00000001872624B0-0x00000001872624C0
		internal List<GlyphRect> usedGlyphRects { get; set; } // 0x00000001872624A0-0x00000001872624B0 0x0000000188BD49B4-0x0000000188BD49C8
		internal List<GlyphRect> freeGlyphRects { get; set; } // 0x0000000187262440-0x0000000187262450 0x000000018783BFB4-0x000000018783BFC8
		public FontFeatureTable fontFeatureTable { get; internal set; } // 0x0000000187262430-0x0000000187262440 0x000000018783BFA0-0x000000018783BFB4
		public List<FontAsset> fallbackFontAssetTable { get; set; } // 0x00000001872623E0-0x00000001872623F0 0x000000018783BF50-0x000000018783BF64
		public FontAssetCreationEditorSettings fontAssetCreationEditorSettings { get; set; } // 0x00000001872623F0-0x0000000187262430 0x000000018D579DC0-0x000000018D579E04
		public float regularStyleWeight { get; set; } // 0x0000000187262480-0x0000000187262490 0x000000018723E230-0x000000018723E240
		public float regularStyleSpacing { get; set; } // 0x0000000187262470-0x0000000187262480 0x000000018723E380-0x000000018723E390
		public float boldStyleWeight { get; set; } // 0x0000000187262380-0x0000000187262390 0x00000001872624D0-0x00000001872624E0
		public float boldStyleSpacing { get; set; } // 0x0000000187262370-0x0000000187262380 0x00000001872624C0-0x00000001872624D0
		public byte italicStyleSlant { get; set; } // 0x0000000187262460-0x0000000187262470 0x000000018723C650-0x000000018723C660
		public byte tabMultiple { get; set; } // 0x0000000187262490-0x00000001872624A0 0x0000000187240AC0-0x0000000187240AD0
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86577
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Character, uint> __9__144_0; // 0x08
			public static Func<Glyph, uint> __9__145_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D58327C-0x000000018D5832E0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal uint _SortCharacterTable_b__144_0(Character c); // 0x000000018D42B2E8-0x000000018D42B300
			internal uint _SortGlyphTable_b__145_0(Glyph c); // 0x000000018CC33418-0x000000018CC33430
		}
	
		// Constructors
		public FontAsset(); // 0x000000018D579834-0x000000018D579C14
		static FontAsset(); // 0x000000018D5794A0-0x000000018D579834
	
		// Methods
		public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90 /* Metadata: 0x026458AF */); // 0x000000018D574448-0x000000018D57462C
		private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.DynamicOS /* Metadata: 0x026458B1 */, bool enableMultiAtlasSupport = true /* Metadata: 0x026458B2 */); // 0x000000018D5742A4-0x000000018D5743D4
		public static FontAsset CreateFontAsset(Font font); // 0x000000018D5743D4-0x000000018D574448
		public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic /* Metadata: 0x026458B3 */, bool enableMultiAtlasSupport = true /* Metadata: 0x026458B4 */); // 0x000000018D57462C-0x000000018D5746D4
		private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic /* Metadata: 0x026458B5 */, bool enableMultiAtlasSupport = true /* Metadata: 0x026458B6 */); // 0x000000018D5746D4-0x000000018D574880
		private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport); // 0x000000018D573E00-0x000000018D5742A4
		private void Awake(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnDestroy(); // 0x000000018D575E60-0x000000018D575EB0
		public void ReadFontAssetDefinition(); // 0x000000018D575EB0-0x000000018D5761C8
		internal void InitializeDictionaryLookupTables(); // 0x000000018D57595C-0x000000018D575988
		internal void InitializeGlyphLookupDictionary(); // 0x000000018D575988-0x000000018D575C04
		internal void InitializeCharacterLookupDictionary(); // 0x000000018D57579C-0x000000018D57595C
		internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary(); // 0x000000018D575C04-0x000000018D575DD0
		internal void AddSynthesizedCharactersAndFaceMetrics(); // 0x000000018D573860-0x000000018D573A48
		private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false /* Metadata: 0x026458B7 */); // 0x000000018D57363C-0x000000018D573860
		internal void AddCharacterToLookupCache(uint unicode, Character character); // 0x000000018D5735D4-0x000000018D57363C
		private FontEngineError LoadFontFace(); // 0x000000018D575DD0-0x000000018D575E60
		internal void SortCharacterTable(); // 0x000000018D57657C-0x000000018D5766E8
		internal void SortGlyphTable(); // 0x000000018D57670C-0x000000018D576878
		internal void SortFontFeatureTable(); // 0x000000018D5766E8-0x000000018D57670C
		internal void SortAllTables(); // 0x000000018D576550-0x000000018D57657C
		public bool HasCharacter(int character); // 0x000000018D574DE0-0x000000018D574E44
		public bool HasCharacter(char character, bool searchFallbacks = false /* Metadata: 0x026458B8 */, bool tryAddCharacter = false /* Metadata: 0x026458B9 */); // 0x000000018D574E44-0x000000018D575178
		private bool HasCharacter_Internal(uint character, bool searchFallbacks = false /* Metadata: 0x026458BA */, bool tryAddCharacter = false /* Metadata: 0x026458BB */); // 0x000000018D574BC0-0x000000018D574DE0
		public bool HasCharacters(string text, out List<char> missingCharacters); // 0x000000018D575648-0x000000018D57579C
		public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false /* Metadata: 0x026458BC */, bool tryAddCharacter = false /* Metadata: 0x026458BD */); // 0x000000018D575224-0x000000018D575648
		public bool HasCharacters(string text); // 0x000000018D575178-0x000000018D575224
		public static string GetCharacters(FontAsset fontAsset); // 0x000000018D574A18-0x000000018D574AF8
		public static int[] GetCharactersArray(FontAsset fontAsset); // 0x000000018D574938-0x000000018D574A18
		internal uint GetGlyphIndex(uint unicode); // 0x000000018D574AF8-0x000000018D574BC0
		internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset); // 0x000000018D576294-0x000000018D576360
		internal static void UpdateFontFeaturesForFontAssetsInQueue(); // 0x000000018D578F00-0x000000018D579030
		internal static void RegisterAtlasTextureForApply(Texture2D texture); // 0x000000018D5761C8-0x000000018D576294
		internal static void UpdateAtlasTexturesInQueue(); // 0x000000018D578C6C-0x000000018D578DA0
		internal static void UpdateFontAssetInUpdateQueue(); // 0x000000018D578EB8-0x000000018D578F00
		public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false /* Metadata: 0x026458BE */); // 0x000000018D577050-0x000000018D577074
		public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false /* Metadata: 0x026458BF */); // 0x000000018D577074-0x000000018D577A18
		public bool TryAddCharacters(string characters, bool includeFontFeatures = false /* Metadata: 0x026458C0 */); // 0x000000018D57702C-0x000000018D577050
		public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false /* Metadata: 0x026458C1 */); // 0x000000018D577A18-0x000000018D57837C
		internal bool TryAddCharacterInternal(uint unicode, out Character character, bool shouldGetFontFeatures = false /* Metadata: 0x026458C2 */); // 0x000000018D576878-0x000000018D57702C
		internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out Character character, bool shouldGetFontFeatures = false /* Metadata: 0x026458C3 */); // 0x000000018D5786E8-0x000000018D578AE0
		internal void TryAddGlyphsToAtlasTextures(); // 0x0000000186805BA0-0x0000000186805BB0
		private bool TryAddGlyphsToNewAtlasTexture(); // 0x000000018D57837C-0x000000018D5786E8
		private void SetupNewAtlasTexture(); // 0x000000018D576360-0x000000018D576550
		internal void UpdateAtlasTexture(); // 0x000000018D578AE0-0x000000018D578C6C
		internal void UpdateGlyphAdjustmentRecords(); // 0x000000018D57924C-0x000000018D5794A0
		internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes); // 0x000000018D579030-0x000000018D57924C
		internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes); // 0x0000000186805BA0-0x0000000186805BB0
		internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes); // 0x0000000186805BA0-0x0000000186805BB0
		private void CopyListDataToArray<T>(List<T> srcList, ref ref T[] dstArray);
		public void ClearFontAssetData(bool setAtlasSizeToZero = false /* Metadata: 0x026458C4 */); // 0x000000018D573C48-0x000000018D573C84
		internal void ClearFontAssetDataInternal(); // 0x000000018D573C24-0x000000018D573C48
		internal void UpdateFontAssetData(); // 0x000000018D578DA0-0x000000018D578EB8
		internal void ClearFontAssetTables(); // 0x000000018D573C84-0x000000018D573E00
		internal void ClearAtlasTextures(bool setAtlasSizeToZero = false /* Metadata: 0x026458C5 */); // 0x000000018D573A48-0x000000018D573C24
		private void DestroyAtlasTextures(); // 0x000000018D574880-0x000000018D574938
	}

	internal static class FontAssetUtilities // TypeDefIndex: 86579
	{
		// Fields
		private static HashSet<int> k_SearchedAssets; // 0x00
	
		// Methods
		internal static Character GetCharacterFromFontAsset(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface); // 0x000000018D572EF8-0x000000018D57300C
		private static Character GetCharacterFromFontAsset_Internal(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface); // 0x000000018D572B6C-0x000000018D572EF8
		public static Character GetCharacterFromFontAssets(uint unicode, FontAsset sourceFontAsset, List<FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface); // 0x000000018D57300C-0x000000018D5731C0
		public static SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks); // 0x000000018D573354-0x000000018D5735D4
		private static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks); // 0x000000018D5731C0-0x000000018D573354
	}

	[Serializable]
	public class FontFeatureTable // TypeDefIndex: 86581
	{
		// Fields
		[SerializeField]
		internal List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
		internal Dictionary<uint, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; // 0x18
	
		// Properties
		internal List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; } // 0x0000000187249840-0x0000000187249850 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86580
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<GlyphPairAdjustmentRecord, uint> __9__6_0; // 0x08
			public static Func<GlyphPairAdjustmentRecord, uint> __9__6_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D5831B4-0x000000018D583218
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal uint _SortGlyphPairAdjustmentRecords_b__6_0(GlyphPairAdjustmentRecord s); // 0x0000000187262560-0x0000000187262570
			internal uint _SortGlyphPairAdjustmentRecords_b__6_1(GlyphPairAdjustmentRecord s); // 0x0000000187262570-0x0000000187262580
		}
	
		// Constructors
		public FontFeatureTable(); // 0x000000018D57A024-0x000000018D57A0E4
	
		// Methods
		public void SortGlyphPairAdjustmentRecords(); // 0x000000018D579E04-0x000000018D57A024
	}

	internal struct Extents // TypeDefIndex: 86582
	{
		// Fields
		public Vector2 min; // 0x00
		public Vector2 max; // 0x08
	
		// Methods
		public override string ToString(); // 0x000000018D5729E8-0x000000018D572B6C
	}

	internal struct LineInfo // TypeDefIndex: 86583
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

	internal struct LinkInfo // TypeDefIndex: 86584
	{
		// Fields
		public int hashCode; // 0x00
		public int linkIdFirstCharacterIndex; // 0x04
		public int linkIdLength; // 0x08
		public int linkTextfirstCharacterIndex; // 0x0C
		public int linkTextLength; // 0x10
		internal char[] linkId; // 0x18
	
		// Methods
		internal void SetLinkId(char[] text, int startIndex, int length); // 0x000000018D57A0E4-0x000000018D57A1B0
	}

	internal static class MaterialManager // TypeDefIndex: 86585
	{
		// Fields
		private static Dictionary<long, Material> s_FallbackMaterials; // 0x00
	
		// Constructors
		static MaterialManager(); // 0x000000018D57A70C-0x000000018D57A798
	
		// Methods
		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial); // 0x000000018D57A1B0-0x000000018D57A544
		public static Material GetFallbackMaterial(FontAsset fontAsset, Material sourceMaterial, int atlasIndex); // 0x000000018D57A544-0x000000018D57A70C
	}

	internal struct MaterialReference // TypeDefIndex: 86586
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
		public MaterialReference(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding); // 0x000000018D57B3A4-0x000000018D57B454
	
		// Methods
		public static int AddMaterialReference(Material material, FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup); // 0x000000018D57AFAC-0x000000018D57B1B4
		public static int AddMaterialReference(Material material, SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup); // 0x000000018D57B1B4-0x000000018D57B3A4
	}

	internal class MaterialReferenceManager // TypeDefIndex: 86587
	{
		// Fields
		private static MaterialReferenceManager s_Instance; // 0x00
		private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
		private Dictionary<int, FontAsset> m_FontAssetReferenceLookup; // 0x18
		private Dictionary<int, SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
		private Dictionary<int, TextColorGradient> m_ColorGradientReferenceLookup; // 0x28
	
		// Properties
		public static MaterialReferenceManager instance { get; } // 0x000000018D57AF1C-0x000000018D57AFAC 
	
		// Constructors
		public MaterialReferenceManager(); // 0x000000018D57ADC4-0x000000018D57AF1C
	
		// Methods
		public static void AddFontAsset(FontAsset fontAsset); // 0x000000018D57A940-0x000000018D57A970
		private void AddFontAssetInternal(FontAsset fontAsset); // 0x000000018D57A860-0x000000018D57A940
		public static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset); // 0x000000018D57AAC8-0x000000018D57AB04
		private void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset); // 0x000000018D57AA10-0x000000018D57AAC8
		public static void AddFontMaterial(int hashCode, Material material); // 0x000000018D57A9D4-0x000000018D57AA10
		private void AddFontMaterialInternal(int hashCode, Material material); // 0x000000018D57A970-0x000000018D57A9D4
		public static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset); // 0x000000018D57A824-0x000000018D57A860
		private void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset); // 0x000000018D57A798-0x000000018D57A824
		public static bool TryGetFontAsset(int hashCode, out FontAsset fontAsset); // 0x000000018D57AC28-0x000000018D57AC64
		private bool TryGetFontAssetInternal(int hashCode, out FontAsset fontAsset); // 0x000000018D57ABB4-0x000000018D57AC28
		public static bool TryGetSpriteAsset(int hashCode, out SpriteAsset spriteAsset); // 0x000000018D57AD88-0x000000018D57ADC4
		private bool TryGetSpriteAssetInternal(int hashCode, out SpriteAsset spriteAsset); // 0x000000018D57AD14-0x000000018D57AD88
		public static bool TryGetColorGradientPreset(int hashCode, out TextColorGradient gradientPreset); // 0x000000018D57AB78-0x000000018D57ABB4
		private bool TryGetColorGradientPresetInternal(int hashCode, out TextColorGradient gradientPreset); // 0x000000018D57AB04-0x000000018D57AB78
		public static bool TryGetMaterial(int hashCode, out Material material); // 0x000000018D57ACD8-0x000000018D57AD14
		private bool TryGetMaterialInternal(int hashCode, out Material material); // 0x000000018D57AC64-0x000000018D57ACD8
	}

	internal enum VertexSortingOrder // TypeDefIndex: 86588
	{
		Normal = 0,
		Reverse = 1
	}

	internal struct MeshInfo // TypeDefIndex: 86589
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
		public MeshInfo(int size); // 0x000000018D57BFD8-0x000000018D57C328
		static MeshInfo(); // 0x000000018D57BF94-0x000000018D57BFD8
	
		// Methods
		internal void ResizeMeshInfo(int size); // 0x000000018D57B4BC-0x000000018D57B6A8
		internal void Clear(bool uploadChanges); // 0x000000018D57B488-0x000000018D57B4BC
		internal void ClearUnusedVertices(); // 0x000000018D57B454-0x000000018D57B488
		internal void SortGeometry(VertexSortingOrder order); // 0x000000018D57B6A8-0x000000018D57B744
		internal void SwapVertexData(int src, int dst); // 0x000000018D57B744-0x000000018D57BF94
	}

	[ExcludeFromPreset]
	public class SpriteAsset : TextAsset // TypeDefIndex: 86591
	{
		// Fields
		internal Dictionary<int, int> m_NameLookup; // 0x38
		internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x40
		[SerializeField]
		internal FaceInfo m_FaceInfo; // 0x48
		[FormerlySerializedAs("spriteSheet")]
		[SerializeField]
		internal Texture m_SpriteAtlasTexture; // 0xA8
		[SerializeField]
		private List<SpriteCharacter> m_SpriteCharacterTable; // 0xB0
		internal Dictionary<uint, SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
		[SerializeField]
		private List<SpriteGlyph> m_SpriteGlyphTable; // 0xC0
		internal Dictionary<uint, SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
		[SerializeField]
		public List<SpriteAsset> fallbackSpriteAssets; // 0xD0
		internal bool m_IsSpriteAssetLookupTablesDirty; // 0xD8
		private static HashSet<int> k_searchedSpriteAssets; // 0x00
	
		// Properties
		public FaceInfo faceInfo { get; internal set; } // 0x00000001872624E0-0x0000000187262520 0x000000018D43F758-0x000000018D43F798
		public Texture spriteSheet { get; internal set; } // 0x0000000187261EC0-0x0000000187261ED0 0x0000000185017110-0x0000000185017130
		public List<SpriteCharacter> spriteCharacterTable { get; internal set; } // 0x000000018D57D7AC-0x000000018D57D7DC 0x0000000185017130-0x0000000185017150
		public Dictionary<uint, SpriteCharacter> spriteCharacterLookupTable { get; internal set; } // 0x000000018D57D77C-0x000000018D57D7AC 0x0000000188D80C28-0x0000000188D80C3C
		public List<SpriteGlyph> spriteGlyphTable { get; internal set; } // 0x0000000187261F80-0x0000000187261F90 0x0000000188D95540-0x0000000188D95554
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86590
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<SpriteGlyph, uint> __9__37_0; // 0x08
			public static Func<SpriteCharacter, uint> __9__38_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D583218-0x000000018D58327C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal uint _SortGlyphTable_b__37_0(SpriteGlyph item); // 0x000000018CC33418-0x000000018CC33430
			internal uint _SortCharacterTable_b__38_0(SpriteCharacter c); // 0x000000018D42B2E8-0x000000018D42B300
		}
	
		// Constructors
		public SpriteAsset(); // 0x000000018D57D6A0-0x000000018D57D77C
	
		// Methods
		private void Awake(); // 0x0000000186805BA0-0x0000000186805BB0
		public void UpdateLookupTables(); // 0x000000018D57D1A0-0x000000018D57D6A0
		public int GetSpriteIndexFromHashcode(int hashCode); // 0x000000018D57C40C-0x000000018D57C48C
		public int GetSpriteIndexFromUnicode(uint unicode); // 0x000000018D57C4CC-0x000000018D57C55C
		public int GetSpriteIndexFromName(string name); // 0x000000018D57C48C-0x000000018D57C4CC
		public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x000000018D57CCDC-0x000000018D57CEA8
		private static SpriteAsset SearchForSpriteByUnicodeInternal(List<SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x000000018D57CAC0-0x000000018D57CC1C
		private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x000000018D57CC1C-0x000000018D57CCDC
		public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, TextSettings textSettings = null); // 0x000000018D57C778-0x000000018D57CAC0
		private static SpriteAsset SearchForSpriteByHashCodeInternal(List<SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex); // 0x000000018D57C55C-0x000000018D57C6B8
		private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex); // 0x000000018D57C6B8-0x000000018D57C778
		public void SortGlyphTable(); // 0x000000018D57D034-0x000000018D57D1A0
		internal void SortCharacterTable(); // 0x000000018D57CEA8-0x000000018D57D014
		internal void SortGlyphAndCharacterTables(); // 0x000000018D57D014-0x000000018D57D034
	}

	[Serializable]
	public class SpriteCharacter : TextElement // TypeDefIndex: 86592
	{
		// Fields
		[SerializeField]
		private string m_Name; // 0x30
		[SerializeField]
		private int m_HashCode; // 0x38
	
		// Properties
		public string name { get; } // 0x00000001872613B0-0x00000001872613C0 
	
		// Constructors
		public SpriteCharacter(); // 0x000000018725F920-0x000000018725F930
	}

	[Serializable]
	public class SpriteGlyph : Glyph // TypeDefIndex: 86593
	{
		// Fields
		public Sprite sprite; // 0x48
	
		// Constructors
		public SpriteGlyph(); // 0x000000018D43F9B0-0x000000018D43F9B8
	}

	[Serializable]
	[ExcludeFromObjectFactory]
	public abstract class TextAsset : ScriptableObject // TypeDefIndex: 86594
	{
		// Fields
		[SerializeField]
		internal string m_Version; // 0x18
		internal int m_InstanceID; // 0x20
		internal int m_HashCode; // 0x24
		[FormerlySerializedAs("material")]
		[SerializeField]
		internal Material m_Material; // 0x28
		internal int m_MaterialHashCode; // 0x30
	
		// Properties
		public string version { get; internal set; } // 0x0000000187244530-0x0000000187244540 0x0000000187835500-0x0000000187835510
		public int instanceID { get; } // 0x000000018D57D808-0x000000018D57D82C 
		public int hashCode { get; set; } // 0x000000018D57D7DC-0x000000018D57D808 0x0000000182A819D0-0x0000000182A819E0
		public Material material { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public int materialHashCode { get; set; } // 0x000000018D57D82C-0x000000018D57D8BC 0x0000000186033510-0x0000000186033520
	
		// Constructors
		protected TextAsset(); // 0x0000000185DD6260-0x0000000185DD6270
	}

	public enum ColorGradientMode // TypeDefIndex: 86595
	{
		Single = 0,
		HorizontalGradient = 1,
		VerticalGradient = 2,
		FourCornersGradient = 3
	}

	[Serializable]
	[ExcludeFromObjectFactory]
	[ExcludeFromPreset]
	public class TextColorGradient : ScriptableObject // TypeDefIndex: 86596
	{
		// Fields
		public ColorGradientMode colorMode; // 0x18
		public UnityEngine.Color topLeft; // 0x1C
		public UnityEngine.Color topRight; // 0x2C
		public UnityEngine.Color bottomLeft; // 0x3C
		public UnityEngine.Color bottomRight; // 0x4C
		private const ColorGradientMode k_DefaultColorMode = ColorGradientMode.FourCornersGradient; // Metadata: 0x026458CC
		private static readonly UnityEngine.Color k_DefaultColor; // 0x00
	
		// Constructors
		public TextColorGradient(); // 0x000000018D57D900-0x000000018D57D9AC
		public TextColorGradient(UnityEngine.Color color); // 0x000000018D41DAEC-0x000000018D41DB30
		public TextColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3); // 0x000000018D41DB30-0x000000018D41DBA0
		static TextColorGradient(); // 0x000000018D57D8BC-0x000000018D57D900
	}

	public enum TextElementType : byte // TypeDefIndex: 86597
	{
		Character = 1,
		Sprite = 2
	}

	[Serializable]
	public abstract class TextElement // TypeDefIndex: 86598
	{
		// Fields
		[SerializeField]
		protected TextElementType m_ElementType; // 0x10
		[SerializeField]
		internal uint m_Unicode; // 0x14
		internal TextAsset m_TextAsset; // 0x18
		internal Glyph m_Glyph; // 0x20
		[SerializeField]
		internal uint m_GlyphIndex; // 0x28
		[SerializeField]
		internal float m_Scale; // 0x2C
	
		// Properties
		public TextElementType elementType { get; } // 0x0000000187261E70-0x0000000187261E80 
		public uint unicode { get; set; } // 0x0000000187233B60-0x0000000187233B70 0x000000018275FD70-0x000000018275FD80
		public TextAsset textAsset { get; set; } // 0x0000000187244530-0x0000000187244540 0x0000000187835500-0x0000000187835510
		public Glyph glyph { get; set; } // 0x000000018725FED0-0x000000018725FEE0 0x0000000187835950-0x0000000187835960
		public uint glyphIndex { get; set; } // 0x00000001872613C0-0x00000001872613D0 0x0000000182271A90-0x0000000182271AA0
		public float scale { get; set; } // 0x0000000187262080-0x0000000187262090 0x0000000187233340-0x0000000187233350
	
		// Constructors
		protected TextElement(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal struct TextVertex // TypeDefIndex: 86599
	{
		// Fields
		public Vector3 position; // 0x00
		public Vector2 uv; // 0x0C
		public Vector2 uv2; // 0x14
		public Vector2 uv4; // 0x1C
		public Color32 color; // 0x24
	}

	internal struct TextElementInfo // TypeDefIndex: 86600
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

	internal enum TextOverflowMode // TypeDefIndex: 86601
	{
		Overflow = 0,
		Ellipsis = 1,
		Masking = 2,
		Truncate = 3,
		ScrollRect = 4,
		Page = 5,
		Linked = 6
	}

	internal enum TextureMapping // TypeDefIndex: 86602
	{
		Character = 0,
		Line = 1,
		Paragraph = 2,
		MatchAspect = 3
	}

	internal class TextGenerationSettings : IEquatable<TextGenerationSettings> // TypeDefIndex: 86603
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
		public TextGenerationSettings(); // 0x000000018D57F60C-0x000000018D57F69C
	
		// Methods
		public bool Equals(TextGenerationSettings other); // 0x000000018D57D9AC-0x000000018D57DDD8
		public override bool Equals(object obj); // 0x000000018D57DDD8-0x000000018D57DE74
		public override int GetHashCode(); // 0x000000018D57DE74-0x000000018D57E388
		public override string ToString(); // 0x000000018D57E388-0x000000018D57F60C
	}

	internal class TextGenerator // TypeDefIndex: 86605
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
		protected struct SpecialCharacter // TypeDefIndex: 86604
		{
			// Fields
			public Character character; // 0x00
			public FontAsset fontAsset; // 0x08
			public Material material; // 0x10
			public int materialIndex; // 0x18
	
			// Constructors
			public SpecialCharacter(Character character, int materialIndex); // 0x000000018D57C328-0x000000018D57C40C
		}
	
		// Constructors
		public TextGenerator(); // 0x000000018D5721B0-0x000000018D57287C
	
		// Methods
		private static TextGenerator GetTextGenerator(); // 0x000000018D56AFEC-0x000000018D56B07C
		public static void GenerateText(TextGenerationSettings settings, TextInfo textInfo); // 0x000000018D56A484-0x000000018D56A5C4
		public static Vector2 GetCursorPosition(TextInfo textInfo, Rect screenRect, int index, bool inverseYAxis = true /* Metadata: 0x026458DA */); // 0x000000018D56A5C4-0x000000018D56A750
		public static Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo); // 0x000000018D56AB80-0x000000018D56AC84
		private void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo); // 0x000000018D56B1C8-0x000000018D56B324
		private void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo); // 0x000000018D55CB70-0x000000018D566B88
		private void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo); // 0x000000018D56C8B8-0x000000018D56CD4C
		protected int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo); // 0x000000018D56B324-0x000000018D56B81C
		protected bool ValidateHtmlTag(int[] chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo); // 0x000000018D56DE1C-0x000000018D5721B0
		private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo); // 0x000000018D56B81C-0x000000018D56C11C
		private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo); // 0x000000018D56C11C-0x000000018D56C8B8
		private void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo); // 0x000000018D569248-0x000000018D56A484
		private void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo); // 0x000000018D568C04-0x000000018D569248
		private static void ClearMesh(bool updateMesh, TextInfo textInfo); // 0x000000018D568ABC-0x000000018D568AE0
		private void EnableMasking(); // 0x0000000187262310-0x0000000187262320
		private void DisableMasking(); // 0x0000000187262300-0x0000000187262310
		private void SetArraySizes(int[] chars, TextGenerationSettings generationSettings, TextInfo textInfo); // 0x000000018D56CD4C-0x000000018D56DE1C
		internal TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface); // 0x000000018D56ACB4-0x000000018D56AFEC
		private void ComputeMarginSize(Rect rect, Vector4 margins); // 0x000000018D568AE0-0x000000018D568C04
		protected void GetSpecialCharacters(TextGenerationSettings generationSettings); // 0x000000018D56AC84-0x000000018D56ACB4
		protected void GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings); // 0x000000018D56A750-0x000000018D56A958
		protected void GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings); // 0x000000018D56B07C-0x000000018D56B1C8
		private float GetPaddingForMaterial(Material material, bool extraPadding); // 0x000000018D56A958-0x000000018D56AA58
		private Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo); // 0x000000018D56AA58-0x000000018D56AB80
		protected virtual Vector2 CalculatePreferredValues(float defaultFontSize, Vector2 marginSize, bool ignoreTextAutoSizing, TextGenerationSettings generationSettings, TextInfo textInfo); // 0x000000018D566B88-0x000000018D568ABC
	}

	internal enum TextAlignment // TypeDefIndex: 86606
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

	[Flags]
	public enum FontStyles // TypeDefIndex: 86607
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

	internal struct XmlTagAttribute // TypeDefIndex: 86608
	{
		// Fields
		public int nameHashCode; // 0x00
		public TagValueType valueType; // 0x04
		public int valueStartIndex; // 0x08
		public int valueLength; // 0x0C
		public int valueHashCode; // 0x10
	}

	internal struct RichTextTagAttribute // TypeDefIndex: 86609
	{
		// Fields
		public int nameHashCode; // 0x00
		public int valueHashCode; // 0x04
		public TagValueType valueType; // 0x08
		public int valueStartIndex; // 0x0C
		public int valueLength; // 0x10
	}

	internal struct WordWrapState // TypeDefIndex: 86610
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

	internal static class TextGeneratorUtilities // TypeDefIndex: 86611
	{
		// Fields
		public static readonly Vector2 largePositiveVector2; // 0x00
		public static readonly Vector2 largeNegativeVector2; // 0x08
	
		// Constructors
		static TextGeneratorUtilities(); // 0x000000018D583158-0x000000018D5831B4
	
		// Methods
		public static bool Approximately(float a, float b); // 0x000000018D57FAC8-0x000000018D57FAEC
		public static Color32 HexCharsToColor(char[] hexChars, int tagCount); // 0x000000018D581280-0x000000018D5818E0
		public static Color32 HexCharsToColor(char[] hexChars, int startIndex, int length); // 0x000000018D5818E0-0x000000018D581B4C
		public static int HexToInt(char hex); // 0x000000018D581B4C-0x000000018D581CA0
		public static float ConvertToFloat(char[] chars, int startIndex, int length); // 0x000000018D57FC5C-0x000000018D57FCD0
		public static float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex); // 0x000000018D57FAEC-0x000000018D57FC5C
		public static Vector2 PackUV(float x, float y, float scale); // 0x0000000187262520-0x0000000187262560
		public static void StringToCharArray(string sourceText, ref int[] charBuffer, ref TextProcessingStack<int> styleStack, TextGenerationSettings generationSettings); // 0x000000018D582948-0x000000018D583158
		private static void ResizeInternalArray<T>(ref ref T[] array);
		private static bool IsTagName(ref string text, string tag, int index); // 0x000000018D581CA0-0x000000018D581D44
		private static bool IsTagName(ref int[] text, string tag, int index); // 0x000000018D581D44-0x000000018D581E0C
		private static bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref int[] charBuffer, ref int writeIndex, ref TextProcessingStack<int> styleStack, ref TextGenerationSettings generationSettings); // 0x000000018D582170-0x000000018D582478
		private static bool ReplaceOpeningStyleTag(ref string sourceText, int srcIndex, out int srcOffset, ref int[] charBuffer, ref int writeIndex, ref TextProcessingStack<int> styleStack, ref TextGenerationSettings generationSettings); // 0x000000018D582478-0x000000018D582778
		private static void ReplaceClosingStyleTag(ref int[] charBuffer, ref int writeIndex, ref TextProcessingStack<int> styleStack, ref TextGenerationSettings generationSettings); // 0x000000018D581E94-0x000000018D582170
		private static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode); // 0x000000018D580E54-0x000000018D580F2C
		private static int GetUtf32(string text, int i); // 0x000000018D581134-0x000000018D581280
		private static int GetUtf16(string text, int i); // 0x000000018D58105C-0x000000018D581134
		private static int GetTagHashCode(ref int[] text, int index, out int closeIndex); // 0x000000018D580FCC-0x000000018D58105C
		private static int GetTagHashCode(ref string text, int index, out int closeIndex); // 0x000000018D580F2C-0x000000018D580FCC
		public static void FillCharacterVertexBuffers(int i, TextGenerationSettings generationSettings, TextInfo textInfo); // 0x000000018D57FCD0-0x000000018D5805D8
		public static void FillSpriteVertexBuffers(int i, TextGenerationSettings generationSettings, TextInfo textInfo); // 0x000000018D5805D8-0x000000018D580E54
		public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo); // 0x000000018D57F69C-0x000000018D57FAC8
		public static void ResizeLineExtents(int size, TextInfo textInfo); // 0x000000018D582778-0x000000018D582948
		public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle); // 0x000000018D581E70-0x000000018D581E94
		public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor); // 0x000000018D581E0C-0x000000018D581E70
	}

	internal struct PageInfo // TypeDefIndex: 86612
	{
		// Fields
		public int firstCharacterIndex; // 0x00
		public int lastCharacterIndex; // 0x04
		public float ascender; // 0x08
		public float baseLine; // 0x0C
		public float descender; // 0x10
	}

	internal struct WordInfo // TypeDefIndex: 86613
	{
		// Fields
		public int firstCharacterIndex; // 0x00
		public int lastCharacterIndex; // 0x04
		public int characterCount; // 0x08
	}

	internal class TextInfo // TypeDefIndex: 86614
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
		public TextInfo(); // 0x000000018D5838A0-0x000000018D5839CC
		static TextInfo(); // 0x000000018D583844-0x000000018D5838A0
	
		// Methods
		internal void Clear(); // 0x000000018D5837E0-0x000000018D583844
		internal void ClearMeshInfo(bool updateMesh); // 0x000000018D583750-0x000000018D5837E0
		internal void ClearLineInfo(); // 0x000000018D583500-0x000000018D583750
		internal static void Resize<T>(ref ref T[] array, int size);
		internal static void Resize<T>(ref ref T[] array, int size, bool isBlockAllocated);
	}

	internal enum MarkupTag // TypeDefIndex: 86615
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

	internal enum TagValueType // TypeDefIndex: 86616
	{
		None = 0,
		NumericalValue = 1,
		StringValue = 2,
		ColorValue = 4
	}

	internal enum TagUnitType // TypeDefIndex: 86617
	{
		Pixels = 0,
		FontUnits = 1,
		Percentage = 2
	}

	internal struct FontStyleStack // TypeDefIndex: 86618
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
		public byte Add(FontStyles style); // 0x000000018D583310-0x000000018D5833DC
		public byte Remove(FontStyles style); // 0x000000018D5833DC-0x000000018D583500
	}

	[DebuggerDisplay("Item count = {m_Count}")]
	internal struct TextProcessingStack<T> // TypeDefIndex: 86619
	{
		// Fields
		public T[] itemStack;
		public int index;
		private T m_DefaultItem;
		private int m_Capacity;
		private int m_RolloverSize;
		private int m_Count;
	
		// Constructors
		public TextProcessingStack(T[] stack);
		public TextProcessingStack(int capacity);
	
		// Methods
		public void Clear();
		public void SetDefault(T item);
		public void Add(T item);
		public T Remove();
		public void Push(T item);
		public T Pop();
		public T Peek();
		public T CurrentItem();
	}

	internal class TextResourceManager // TypeDefIndex: 86621
	{
		// Fields
		private static readonly Dictionary<int, FontAssetRef> s_FontAssetReferences; // 0x00
		private static readonly Dictionary<int, FontAsset> s_FontAssetNameReferenceLookup; // 0x08
		private static readonly Dictionary<long, FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; // 0x10
		private static readonly List<int> s_FontAssetRemovalList; // 0x18
		private static readonly int k_RegularStyleHashCode; // 0x20
	
		// Nested types
		private struct FontAssetRef // TypeDefIndex: 86620
		{
			// Fields
			public int nameHashCode; // 0x00
			public int familyNameHashCode; // 0x04
			public int styleNameHashCode; // 0x08
			public long familyNameAndStyleHashCode; // 0x10
			public readonly FontAsset fontAsset; // 0x18
	
			// Constructors
			public FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, FontAsset fontAsset); // 0x000000018D5832E0-0x000000018D583310
		}
	
		// Constructors
		static TextResourceManager(); // 0x000000018D583F40-0x000000018D584138
	
		// Methods
		internal static void AddFontAsset(FontAsset fontAsset); // 0x000000018D5839CC-0x000000018D583F40
	}

	[Serializable]
	[ExcludeFromObjectFactory]
	[ExcludeFromPreset]
	public class TextSettings : ScriptableObject // TypeDefIndex: 86623
	{
		// Fields
		[SerializeField]
		protected string m_Version; // 0x18
		[FormerlySerializedAs("m_defaultFontAsset")]
		[SerializeField]
		protected FontAsset m_DefaultFontAsset; // 0x20
		[FormerlySerializedAs("m_defaultFontAssetPath")]
		[SerializeField]
		protected string m_DefaultFontAssetPath; // 0x28
		[FormerlySerializedAs("m_fallbackFontAssets")]
		[SerializeField]
		protected List<FontAsset> m_FallbackFontAssets; // 0x30
		[FormerlySerializedAs("m_matchMaterialPreset")]
		[SerializeField]
		protected bool m_MatchMaterialPreset; // 0x38
		[FormerlySerializedAs("m_missingGlyphCharacter")]
		[SerializeField]
		protected int m_MissingCharacterUnicode; // 0x3C
		[SerializeField]
		protected bool m_ClearDynamicDataOnBuild; // 0x40
		[FormerlySerializedAs("m_defaultSpriteAsset")]
		[SerializeField]
		protected SpriteAsset m_DefaultSpriteAsset; // 0x48
		[FormerlySerializedAs("m_defaultSpriteAssetPath")]
		[SerializeField]
		protected string m_DefaultSpriteAssetPath; // 0x50
		[SerializeField]
		protected List<SpriteAsset> m_FallbackSpriteAssets; // 0x58
		[SerializeField]
		protected uint m_MissingSpriteCharacterUnicode; // 0x60
		[FormerlySerializedAs("m_defaultStyleSheet")]
		[SerializeField]
		protected TextStyleSheet m_DefaultStyleSheet; // 0x68
		[SerializeField]
		protected string m_StyleSheetsResourcePath; // 0x70
		[FormerlySerializedAs("m_defaultColorGradientPresetsPath")]
		[SerializeField]
		protected string m_DefaultColorGradientPresetsPath; // 0x78
		[SerializeField]
		protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules; // 0x80
		[FormerlySerializedAs("m_warningsDisabled")]
		[SerializeField]
		protected bool m_DisplayWarnings; // 0x88
		internal Dictionary<int, FontAsset> m_FontLookup; // 0x90
		private List<FontReferenceMap> m_FontReferences; // 0x98
	
		// Properties
		public string version { get; internal set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public FontAsset defaultFontAsset { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public string defaultFontAssetPath { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public List<FontAsset> fallbackFontAssets { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public bool matchMaterialPreset { get; set; } // 0x000000018225E070-0x000000018225E080 0x000000018225E080-0x000000018225E090
		public int missingCharacterUnicode { get; set; } // 0x000000018226F000-0x000000018226F010 0x000000018226F010-0x000000018226F020
		public bool clearDynamicDataOnBuild { get; set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018225DFC0-0x000000018225DFD0
		public SpriteAsset defaultSpriteAsset { get; set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public string defaultSpriteAssetPath { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public List<SpriteAsset> fallbackSpriteAssets { get; set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		public uint missingSpriteCharacterUnicode { get; set; } // 0x00000001872332A0-0x00000001872332B0 0x0000000185FF5E70-0x0000000185FF5F30
		public TextStyleSheet defaultStyleSheet { get; set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
		public string styleSheetsResourcePath { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
		public string defaultColorGradientPresetsPath { get; set; } // 0x00000001829CD170-0x00000001829CD180 0x0000000188800CC0-0x0000000188800CD0
		public UnicodeLineBreakingRules lineBreakingRules { get; set; } // 0x000000018D584744-0x000000018D5847C0 0x00000001870EAAE0-0x00000001870EAAF0
		public bool displayWarnings { get; set; } // 0x000000018236FC60-0x000000018236FC70 0x000000018236FC70-0x000000018236FC80
	
		// Nested types
		[Serializable]
		private struct FontReferenceMap // TypeDefIndex: 86622
		{
			// Fields
			public Font font; // 0x00
			public FontAsset fontAsset; // 0x08
	
			// Constructors
			public FontReferenceMap(Font font, FontAsset fontAsset); // 0x0000000185B2C340-0x0000000185B2C370
		}
	
		// Constructors
		public TextSettings(); // 0x000000018D584634-0x000000018D584744
	
		// Methods
		protected void InitializeFontReferenceLookup(); // 0x000000018D58443C-0x000000018D584634
		protected FontAsset GetCachedFontAssetInternal(Font font); // 0x000000018D584138-0x000000018D58443C
	}

	public static class TextShaderUtilities // TypeDefIndex: 86624
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
		internal static Shader ShaderRef_MobileSDF { get; } // 0x000000018D5863EC-0x000000018D586568 
		internal static Shader ShaderRef_MobileBitmap { get; } // 0x000000018D586270-0x000000018D5863EC 
	
		// Constructors
		static TextShaderUtilities(); // 0x000000018D585F80-0x000000018D586270
	
		// Methods
		internal static void GetShaderPropertyIDs(); // 0x000000018D584F78-0x000000018D5858DC
		private static void UpdateShaderRatios(Material mat); // 0x000000018D585A60-0x000000018D585F80
		internal static bool IsMaskingEnabled(Material material); // 0x000000018D5858DC-0x000000018D585A60
		internal static float GetPadding(Material material, bool enableExtraPadding, bool isBold); // 0x000000018D5847C0-0x000000018D584F78
	}

	[Serializable]
	public class TextStyle // TypeDefIndex: 86625
	{
		// Fields
		internal static TextStyle k_NormalStyle; // 0x00
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
		public int hashCode { get; } // 0x000000018724B960-0x000000018724B970 
		public int[] styleOpeningTagArray { get; } // 0x00000001872613B0-0x00000001872613C0 
		public int[] styleClosingTagArray { get; } // 0x00000001872615B0-0x00000001872615C0 
	
		// Methods
		public void RefreshStyle(); // 0x000000018D5868B0-0x000000018D586AB4
	}

	[Serializable]
	[ExcludeFromObjectFactory]
	[ExcludeFromPreset]
	public class TextStyleSheet : ScriptableObject // TypeDefIndex: 86626
	{
		// Fields
		[SerializeField]
		private List<TextStyle> m_StyleList; // 0x18
		private Dictionary<int, TextStyle> m_StyleLookupDictionary; // 0x20
	
		// Properties
		internal List<TextStyle> styles { get; } // 0x0000000187244530-0x0000000187244540 
	
		// Constructors
		public TextStyleSheet(); // 0x000000018D58682C-0x000000018D5868B0
	
		// Methods
		public TextStyle GetStyle(int hashCode); // 0x000000018D586568-0x000000018D5865E4
		public TextStyle GetStyle(string name); // 0x000000018D5865E4-0x000000018D58666C
		public void RefreshStyles(); // 0x000000018D586824-0x000000018D58682C
		private void LoadStyleDictionaryInternal(); // 0x000000018D58666C-0x000000018D586824
	}

	internal static class TextUtilities // TypeDefIndex: 86627
	{
		// Methods
		internal static char ToUpperFast(char c); // 0x000000018D586B68-0x000000018D586BC0
		internal static uint ToUpperASCIIFast(uint c); // 0x000000018D586B10-0x000000018D586B68
		public static int GetHashCodeCaseInSensitive(string s); // 0x000000018D586AB4-0x000000018D586B10
	
		// Extension methods
		internal static string UintToString(this List<uint> unicodes); // 0x000000018D586BC0-0x000000018D586C80
	}

	[Serializable]
	public class UnicodeLineBreakingRules // TypeDefIndex: 86628
	{
		// Fields
		private static UnicodeLineBreakingRules s_Instance; // 0x00
		[SerializeField]
		private TextAsset m_UnicodeLineBreakingRules; // 0x10
		[SerializeField]
		private TextAsset m_LeadingCharacters; // 0x18
		[SerializeField]
		private TextAsset m_FollowingCharacters; // 0x20
		[SerializeField]
		private bool m_UseModernHangulLineBreakingRules; // 0x28
		private static HashSet<uint> s_LeadingCharactersLookup; // 0x08
		private static HashSet<uint> s_FollowingCharactersLookup; // 0x10
	
		// Properties
		internal HashSet<uint> leadingCharactersLookup { get; } // 0x000000018D587164-0x000000018D5871D4 
		internal HashSet<uint> followingCharactersLookup { get; } // 0x000000018D5870F4-0x000000018D587164 
	
		// Constructors
		public UnicodeLineBreakingRules(); // 0x0000000186805BA0-0x0000000186805BB0
		static UnicodeLineBreakingRules(); // 0x000000018D587090-0x000000018D5870F4
	
		// Methods
		internal static void LoadLineBreakingRules(); // 0x000000018D586D44-0x000000018D587090
		private static HashSet<uint> GetCharacters(TextAsset file); // 0x000000018D586C80-0x000000018D586D44
	}
}
