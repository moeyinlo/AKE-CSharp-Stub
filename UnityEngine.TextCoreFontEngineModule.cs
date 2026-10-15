/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;

// Image 99: UnityEngine.TextCoreFontEngineModule.dll - Assembly: UnityEngine.TextCoreFontEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90565-90584

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 90566
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 90567
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine.TextCore
{
	[Serializable]
	[UsedByNativeCode]
	public struct FaceInfo // TypeDefIndex: 90568
	{
		// Fields
		[NativeName("faceIndex")]
		[SerializeField]
		private int m_FaceIndex; // 0x00
		[NativeName("familyName")]
		[SerializeField]
		private string m_FamilyName; // 0x08
		[NativeName("styleName")]
		[SerializeField]
		private string m_StyleName; // 0x10
		[NativeName("pointSize")]
		[SerializeField]
		private int m_PointSize; // 0x18
		[NativeName("scale")]
		[SerializeField]
		private float m_Scale; // 0x1C
		[NativeName("unitsPerEM")]
		[SerializeField]
		private int m_UnitsPerEM; // 0x20
		[NativeName("lineHeight")]
		[SerializeField]
		private float m_LineHeight; // 0x24
		[NativeName("ascentLine")]
		[SerializeField]
		private float m_AscentLine; // 0x28
		[NativeName("capLine")]
		[SerializeField]
		private float m_CapLine; // 0x2C
		[NativeName("meanLine")]
		[SerializeField]
		private float m_MeanLine; // 0x30
		[NativeName("baseline")]
		[SerializeField]
		private float m_Baseline; // 0x34
		[NativeName("descentLine")]
		[SerializeField]
		private float m_DescentLine; // 0x38
		[NativeName("superscriptOffset")]
		[SerializeField]
		private float m_SuperscriptOffset; // 0x3C
		[NativeName("superscriptSize")]
		[SerializeField]
		private float m_SuperscriptSize; // 0x40
		[NativeName("subscriptOffset")]
		[SerializeField]
		private float m_SubscriptOffset; // 0x44
		[NativeName("subscriptSize")]
		[SerializeField]
		private float m_SubscriptSize; // 0x48
		[NativeName("underlineOffset")]
		[SerializeField]
		private float m_UnderlineOffset; // 0x4C
		[NativeName("underlineThickness")]
		[SerializeField]
		private float m_UnderlineThickness; // 0x50
		[NativeName("strikethroughOffset")]
		[SerializeField]
		private float m_StrikethroughOffset; // 0x54
		[NativeName("strikethroughThickness")]
		[SerializeField]
		private float m_StrikethroughThickness; // 0x58
		[NativeName("tabWidth")]
		[SerializeField]
		private float m_TabWidth; // 0x5C
	
		// Properties
		internal int faceIndex { get; } // 0x000000018725FD00-0x000000018725FD10 
		public string familyName { get; set; } // 0x000000018725FF40-0x000000018725FF50 0x0000000188AC06FC-0x0000000188AC070C
		public string styleName { get; set; } // 0x0000000187249840-0x0000000187249850 0x0000000184FD2410-0x0000000184FD2420
		public int pointSize { get; set; } // 0x000000018724B960-0x000000018724B970 0x000000018442F470-0x000000018442F480
		public float scale { get; set; } // 0x0000000187262050-0x0000000187262060 0x0000000187233420-0x0000000187233430
		public float lineHeight { get; set; } // 0x0000000187261350-0x0000000187261360 0x0000000187236720-0x0000000187236730
		public float ascentLine { get; set; } // 0x0000000187262200-0x0000000187262210 0x0000000187233440-0x0000000187233450
		public float capLine { get; set; } // 0x0000000187262080-0x0000000187262090 0x0000000187233340-0x0000000187233350
		public float meanLine { get; set; } // 0x000000018725EFA0-0x000000018725EFB0 0x0000000187233880-0x0000000187233890
		public float baseline { get; set; } // 0x000000018783AB70-0x000000018783AB78 0x0000000187233AF0-0x0000000187233B00
		public float descentLine { get; set; } // 0x0000000187837390-0x0000000187837398 0x0000000187235390-0x00000001872353A0
		public float superscriptOffset { get; set; } // 0x0000000187837310-0x0000000187837318 0x0000000187233110-0x0000000187233120
		public float superscriptSize { get; set; } // 0x0000000187837380-0x0000000187837390 0x0000000187233120-0x0000000187233130
		public float subscriptOffset { get; set; } // 0x0000000187837370-0x0000000187837380 0x0000000187233130-0x0000000187233140
		public float subscriptSize { get; set; } // 0x0000000187837360-0x0000000187837370 0x000000018723F470-0x000000018723F480
		public float underlineOffset { get; set; } // 0x00000001872621D0-0x00000001872621E0 0x000000018723F3C0-0x000000018723F3D0
		public float underlineThickness { get; set; } // 0x0000000187262220-0x0000000187262230 0x000000018226EF10-0x000000018226EF20
		public float strikethroughOffset { get; set; } // 0x00000001872621E0-0x00000001872621F0 0x00000001872335A0-0x00000001872335B0
		public float strikethroughThickness { set; } // 0x00000001872353E0-0x00000001872353F0
		public float tabWidth { get; set; } // 0x0000000187262210-0x0000000187262220 0x00000001826DD0C0-0x00000001826DD0D0
	}

	public enum GlyphClassDefinitionType // TypeDefIndex: 90569
	{
		Undefined = 0,
		Base = 1,
		Ligature = 2,
		Mark = 3,
		Component = 4
	}

	[Serializable]
	[UsedByNativeCode]
	public struct GlyphRect : IEquatable<GlyphRect> // TypeDefIndex: 90570
	{
		// Fields
		[NativeName("x")]
		[SerializeField]
		private int m_X; // 0x00
		[NativeName("y")]
		[SerializeField]
		private int m_Y; // 0x04
		[NativeName("width")]
		[SerializeField]
		private int m_Width; // 0x08
		[NativeName("height")]
		[SerializeField]
		private int m_Height; // 0x0C
		private static readonly GlyphRect s_ZeroGlyphRect; // 0x00
	
		// Properties
		public int x { get; } // 0x000000018725FD00-0x000000018725FD10 
		public int y { get; } // 0x000000018724CA40-0x000000018724CA50 
		public int width { get; } // 0x000000018453A050-0x000000018453A060 
		public int height { get; } // 0x000000018724B3B0-0x000000018724B3C0 
		public static GlyphRect zero { get; } // 0x00000001852DBE10-0x00000001852DBE80 
	
		// Constructors
		public GlyphRect(int x, int y, int width, int height); // 0x0000000187235B70-0x0000000187235B90
		static GlyphRect(); // 0x0000000187217FE0-0x0000000187218020
	
		// Methods
		public override int GetHashCode(); // 0x000000018D55C9F4-0x000000018D55CA44
		public override bool Equals(object obj); // 0x000000018D55C994-0x000000018D55C9F4
		public bool Equals(GlyphRect other); // 0x000000018D55C918-0x000000018D55C994
	}

	[Serializable]
	[UsedByNativeCode]
	public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 90571
	{
		// Fields
		[NativeName("width")]
		[SerializeField]
		private float m_Width; // 0x00
		[NativeName("height")]
		[SerializeField]
		private float m_Height; // 0x04
		[NativeName("horizontalBearingX")]
		[SerializeField]
		private float m_HorizontalBearingX; // 0x08
		[NativeName("horizontalBearingY")]
		[SerializeField]
		private float m_HorizontalBearingY; // 0x0C
		[NativeName("horizontalAdvance")]
		[SerializeField]
		private float m_HorizontalAdvance; // 0x10
	
		// Properties
		public float width { get; } // 0x000000018725FF90-0x000000018725FFA0 
		public float height { get; } // 0x000000018725FCF0-0x000000018725FD00 
		public float horizontalBearingX { get; } // 0x000000018725FCE0-0x000000018725FCF0 
		public float horizontalBearingY { get; } // 0x000000018725FF10-0x000000018725FF20 
		public float horizontalAdvance { get; } // 0x000000018725FCD0-0x000000018725FCE0 
	
		// Constructors
		public GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance); // 0x0000000187262230-0x0000000187262260
	
		// Methods
		public override int GetHashCode(); // 0x000000018D55C734-0x000000018D55C788
		public override bool Equals(object obj); // 0x000000018D55C6D0-0x000000018D55C734
		public bool Equals(GlyphMetrics other); // 0x000000018D55C648-0x000000018D55C6D0
	}

	[Serializable]
	[UsedByNativeCode]
	public class Glyph // TypeDefIndex: 90572
	{
		// Fields
		[NativeName("index")]
		[SerializeField]
		private uint m_Index; // 0x10
		[NativeName("metrics")]
		[SerializeField]
		private GlyphMetrics m_Metrics; // 0x14
		[NativeName("glyphRect")]
		[SerializeField]
		private GlyphRect m_GlyphRect; // 0x28
		[NativeName("scale")]
		[SerializeField]
		private float m_Scale; // 0x38
		[NativeName("atlasIndex")]
		[SerializeField]
		private int m_AtlasIndex; // 0x3C
		[NativeName("type")]
		[SerializeField]
		private GlyphClassDefinitionType m_ClassDefinitionType; // 0x40
	
		// Properties
		public uint index { get; set; } // 0x000000018725FFC0-0x000000018725FFD0 0x0000000182234E90-0x0000000182234EA0
		public GlyphMetrics metrics { get; set; } // 0x0000000187244E70-0x0000000187244E90 0x00000001872622F0-0x0000000187262300
		public GlyphRect glyphRect { get; set; } // 0x0000000187261E80-0x0000000187261E90 0x000000018723D780-0x000000018723D790
		public float scale { get; set; } // 0x0000000187837390-0x0000000187837398 0x0000000187235390-0x00000001872353A0
		public int atlasIndex { get; set; } // 0x000000018725FDF0-0x000000018725FE00 0x000000018226F010-0x000000018226F020
		public GlyphClassDefinitionType classDefinitionType { get; } // 0x000000018725FDE0-0x000000018725FDF0 
	
		// Constructors
		public Glyph(); // 0x000000018634F8D0-0x000000018634F8F0
		internal Glyph(GlyphMarshallingStruct glyphStruct); // 0x0000000187262290-0x00000001872622C0
		public Glyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex); // 0x00000001872622C0-0x00000001872622F0
	}
}

namespace UnityEngine.TextCore.LowLevel
{
	[Flags]
	[UsedByNativeCode]
	public enum GlyphLoadFlags // TypeDefIndex: 90573
	{
		LOAD_DEFAULT = 0,
		LOAD_NO_SCALE = 1,
		LOAD_NO_HINTING = 2,
		LOAD_RENDER = 4,
		LOAD_NO_BITMAP = 8,
		LOAD_FORCE_AUTOHINT = 32,
		LOAD_MONOCHROME = 4096,
		LOAD_NO_AUTOHINT = 32768,
		LOAD_COLOR = 1048576,
		LOAD_COMPUTE_METRICS = 2097152,
		LOAD_BITMAP_METRICS_ONLY = 4194304
	}

	public enum FontEngineError // TypeDefIndex: 90574
	{
		Success = 0,
		Invalid_File_Path = 1,
		Invalid_File_Format = 2,
		Invalid_File_Structure = 3,
		Invalid_File = 4,
		Invalid_Table = 8,
		Invalid_Glyph_Index = 16,
		Invalid_Character_Code = 17,
		Invalid_Pixel_Size = 23,
		Invalid_Library = 33,
		Invalid_Face = 35,
		Invalid_Library_or_Face = 41,
		Atlas_Generation_Cancelled = 100,
		Invalid_SharedTextureData = 101,
		OpenTypeLayoutLookup_Mismatch = 116
	}

	[UsedByNativeCode]
	public enum GlyphRenderMode // TypeDefIndex: 90575
	{
		SMOOTH = 4117,
		RASTER = 4118,
		SMOOTH_HINTED = 4121,
		RASTER_HINTED = 4122,
		SDF = 4134,
		SDFAA = 4165,
		SDFAA_HINTED = 4169,
		SDF8 = 8230,
		SDF16 = 16422,
		SDF32 = 32806,
		COLOR = 69652,
		COLOR_HINTED = 69656,
		SDFBezier = 135172
	}

	[UsedByNativeCode]
	public enum GlyphPackingMode // TypeDefIndex: 90576
	{
		BestShortSideFit = 0,
		BestLongSideFit = 1,
		BestAreaFit = 2,
		BottomLeftRule = 3,
		ContactPointRule = 4
	}

	[DebuggerDisplay("{familyName} - {styleName}")]
	[UsedByNativeCode]
	internal struct FontReference // TypeDefIndex: 90577
	{
		// Fields
		public string familyName; // 0x00
		public string styleName; // 0x08
		public int faceIndex; // 0x10
		public string filePath; // 0x18
	}

	[NativeHeader("Modules/TextCoreFontEngine/Native/FontEngine.h")]
	public sealed class FontEngine // TypeDefIndex: 90578
	{
		// Fields
		private static Glyph[] s_Glyphs; // 0x00
		private static uint[] s_GlyphIndexes_MarshallingArray_A; // 0x08
		private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; // 0x10
		private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; // 0x18
		private static GlyphRect[] s_FreeGlyphRects; // 0x20
		private static GlyphRect[] s_UsedGlyphRects; // 0x28
		private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; // 0x30
		private static Dictionary<uint, Glyph> s_GlyphLookupDictionary; // 0x38
	
		// Constructors
		static FontEngine(); // 0x000000018D55C2FC-0x000000018D55C4C4
	
		// Methods
		public static FontEngineError InitializeFontEngine(); // 0x000000018D55AD98-0x000000018D55ADD8
		[NativeMethod(Name = "TextCore::FontEngine::InitFontEngine", IsFreeFunction = true)]
		private static int InitializeFontEngine_Internal(); // 0x000000018D55AD6C-0x000000018D55AD98
		public static FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex); // 0x000000018D55AFC4-0x000000018D55B024
		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex); // 0x000000018D55ADD8-0x000000018D55AE28
		public static FontEngineError LoadFontFace(Font font, int pointSize); // 0x000000018D55AF6C-0x000000018D55AFC4
		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		private static int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize); // 0x000000018D55AE28-0x000000018D55AE68
		public static FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex); // 0x000000018D55AF0C-0x000000018D55AF6C
		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex); // 0x000000018D55AE68-0x000000018D55AEB8
		public static FontEngineError LoadFontFace(string familyName, string styleName, int pointSize); // 0x000000018D55B024-0x000000018D55B084
		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize); // 0x000000018D55AEB8-0x000000018D55AF0C
		internal static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef); // 0x000000018D55C29C-0x000000018D55C2FC
		[NativeMethod(Name = "TextCore::FontEngine::TryGetSystemFontReference", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef); // 0x000000018D55C248-0x000000018D55C29C
		public static FaceInfo GetFaceInfo(); // 0x000000018D55AA28-0x000000018D55AAC8
		[NativeMethod(Name = "TextCore::FontEngine::GetFaceInfo", IsThreadSafe = true, IsFreeFunction = true)]
		private static int GetFaceInfo_Internal(ref FaceInfo faceInfo); // 0x000000018D55A9F4-0x000000018D55AA28
		[NativeMethod(Name = "TextCore::FontEngine::GetGlyphIndex", IsThreadSafe = true, IsFreeFunction = true)]
		internal static uint GetGlyphIndex(uint unicode); // 0x000000018D55AAC8-0x000000018D55AAFC
		public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph); // 0x000000018D55C130-0x000000018D55C248
		[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithUnicodeValue", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct); // 0x000000018D55C0E0-0x000000018D55C130
		public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph); // 0x000000018D55BFC8-0x000000018D55C0E0
		[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithIndexValue", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct); // 0x000000018D55BF78-0x000000018D55BFC8
		public static void AddGlyphToTextureByGpu([IsReadOnly] in Glyph glyph, int padding, RenderTexture texture); // 0x000000018D55A968-0x000000018D55A9F4
		[NativeMethod(Name = "TextCore::FontEngine::AddGlyphToTextureByGpu", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool AddGlyphToTextureByGpu_Internal([IsReadOnly] in GlyphMarshallingStruct glyph, int padding, RenderTexture texture); // 0x000000018D55A918-0x000000018D55A968
		public static void ProcessSDFGenerationRequest(Material material, ScriptableRenderContext scriptableRenderContext, CommandBuffer cmd); // 0x000000018D55B11C-0x000000018D55B194
		[NativeMethod(Name = "TextCore::FontEngine::ProcessSDFGenerationRequest", IsThreadSafe = true, IsFreeFunction = true)]
		private static void ProcessSDFGenerationRequest_Internal(Material material, IntPtr scriptableRenderContext, CommandBuffer cmd); // 0x000000018D55B0C8-0x000000018D55B11C
		[NativeMethod(Name = "TextCore::FontEngine::SetTextureUploadMode", IsThreadSafe = true, IsFreeFunction = true)]
		internal static void SetTextureUploadMode(bool shouldUploadImmediately); // 0x000000018D55B1C8-0x000000018D55B1FC
		internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture texture, out Glyph glyph); // 0x000000018D55B260-0x000000018D55B714
		[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphToTexture", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, out GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, out GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture texture, out GlyphMarshallingStruct glyph); // 0x000000018D55B1FC-0x000000018D55B260
		internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture texture, out Glyph[] glyphs); // 0x000000018D55B778-0x000000018D55BF78
		[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphsToTexture", IsThreadSafe = true, IsFreeFunction = true)]
		private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, out GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, out GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture texture, out GlyphMarshallingStruct[] glyphs, ref int glyphCount); // 0x000000018D55B714-0x000000018D55B778
		internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes); // 0x000000018D55AC34-0x000000018D55AD38
		internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(List<uint> glyphIndexes, out int recordCount); // 0x000000018D55AAFC-0x000000018D55AC34
		[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArrayFromKernTable", IsFreeFunction = true)]
		private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(uint[] glyphIndexes, out int recordCount); // 0x000000018D55B084-0x000000018D55B0C8
		[NativeMethod(Name = "TextCore::FontEngine::GetGlyphPairAdjustmentRecordsFromMarshallingArray", IsFreeFunction = true)]
		private static int GetPairAdjustmentRecordsFromMarshallingArray(out GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords); // 0x000000018D55AD38-0x000000018D55AD6C
		private static void GenericListToMarshallingArray<T>(ref List<T> srcList, ref ref T[] dstArray);
		private static void SetMarshallingArraySize<T>(ref ref T[] marshallingArray, int recordCount);
		[NativeMethod(Name = "TextCore::FontEngine::ResetAtlasTexture", IsFreeFunction = true)]
		internal static void ResetAtlasTexture(Texture2D texture); // 0x000000018D55B194-0x000000018D55B1C8
	}

	internal struct FontEngineUtilities // TypeDefIndex: 90579
	{
		// Methods
		internal static int MaxValue(int a, int b, int c); // 0x000000018D55A8FC-0x000000018D55A918
	}

	[UsedByNativeCode]
	internal struct GlyphMarshallingStruct // TypeDefIndex: 90580
	{
		// Fields
		public uint index; // 0x00
		public GlyphMetrics metrics; // 0x04
		public GlyphRect glyphRect; // 0x18
		public float scale; // 0x28
		public int atlasIndex; // 0x2C
		public GlyphClassDefinitionType classDefinitionType; // 0x30
	
		// Constructors
		public GlyphMarshallingStruct(Glyph glyph); // 0x000000018D55C604-0x000000018D55C648
	}

	[Flags]
	public enum FontFeatureLookupFlags // TypeDefIndex: 90581
	{
		None = 0,
		IgnoreLigatures = 4,
		IgnoreSpacingAdjustments = 256
	}

	[Serializable]
	[UsedByNativeCode]
	public struct GlyphValueRecord : IEquatable<GlyphValueRecord> // TypeDefIndex: 90582
	{
		// Fields
		[NativeName("xPlacement")]
		[SerializeField]
		private float m_XPlacement; // 0x00
		[NativeName("yPlacement")]
		[SerializeField]
		private float m_YPlacement; // 0x04
		[NativeName("xAdvance")]
		[SerializeField]
		private float m_XAdvance; // 0x08
		[NativeName("yAdvance")]
		[SerializeField]
		private float m_YAdvance; // 0x0C
	
		// Properties
		public float xPlacement { get; } // 0x000000018725FF90-0x000000018725FFA0 
		public float yPlacement { get; } // 0x000000018725FCF0-0x000000018725FD00 
		public float xAdvance { get; } // 0x000000018725FCE0-0x000000018725FCF0 
		public float yAdvance { get; } // 0x000000018725FF10-0x000000018725FF20 
	
		// Methods
		public static GlyphValueRecord operator +(GlyphValueRecord a, GlyphValueRecord b); // 0x0000000187262270-0x0000000187262290
		public override int GetHashCode(); // 0x000000018D55CB20-0x000000018D55CB70
		public override bool Equals(object obj); // 0x000000018D55CA44-0x000000018D55CAA4
		public bool Equals(GlyphValueRecord other); // 0x000000018D55CAA4-0x000000018D55CB20
	}

	[Serializable]
	[UsedByNativeCode]
	public struct GlyphAdjustmentRecord : IEquatable<GlyphAdjustmentRecord> // TypeDefIndex: 90583
	{
		// Fields
		[NativeName("glyphIndex")]
		[SerializeField]
		private uint m_GlyphIndex; // 0x00
		[NativeName("glyphValueRecord")]
		[SerializeField]
		private GlyphValueRecord m_GlyphValueRecord; // 0x04
	
		// Properties
		public uint glyphIndex { get; } // 0x000000018725FD00-0x000000018725FD10 
		public GlyphValueRecord glyphValueRecord { get; } // 0x0000000187261B00-0x0000000187261B10 
	
		// Methods
		[ExcludeFromDocs]
		public override int GetHashCode(); // 0x000000018D55C5B0-0x000000018D55C604
		[ExcludeFromDocs]
		public override bool Equals(object obj); // 0x000000018D55C54C-0x000000018D55C5B0
		[ExcludeFromDocs]
		public bool Equals(GlyphAdjustmentRecord other); // 0x000000018D55C4C4-0x000000018D55C54C
	}

	[Serializable]
	[DebuggerDisplay("First glyphIndex = {m_FirstAdjustmentRecord.m_GlyphIndex},  Second glyphIndex = {m_SecondAdjustmentRecord.m_GlyphIndex}")]
	[UsedByNativeCode]
	public struct GlyphPairAdjustmentRecord : IEquatable<GlyphPairAdjustmentRecord> // TypeDefIndex: 90584
	{
		// Fields
		[NativeName("firstAdjustmentRecord")]
		[SerializeField]
		private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x00
		[NativeName("secondAdjustmentRecord")]
		[SerializeField]
		private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x14
		[SerializeField]
		private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x28
	
		// Properties
		public GlyphAdjustmentRecord firstAdjustmentRecord { get; } // 0x0000000187262260-0x0000000187262270 
		public GlyphAdjustmentRecord secondAdjustmentRecord { get; } // 0x0000000187244E70-0x0000000187244E90 
	
		// Methods
		[ExcludeFromDocs]
		public override int GetHashCode(); // 0x000000018D55C8B0-0x000000018D55C918
		[ExcludeFromDocs]
		public override bool Equals(object obj); // 0x000000018D55C788-0x000000018D55C800
		[ExcludeFromDocs]
		public bool Equals(GlyphPairAdjustmentRecord other); // 0x000000018D55C800-0x000000018D55C8B0
	}
}
