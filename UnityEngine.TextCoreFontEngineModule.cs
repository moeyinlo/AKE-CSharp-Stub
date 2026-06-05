/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;

// Image 94: UnityEngine.TextCoreFontEngineModule.dll - Assembly: UnityEngine.TextCoreFontEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60489-60508

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 60490
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 60491
	{
		// Constructors
		public IsReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine.TextCore
{
	[Serializable]
	public struct FaceInfo // TypeDefIndex: 60492
	{
		// Fields
		private int m_FaceIndex; // 0x00
		private string m_FamilyName; // 0x08
		private string m_StyleName; // 0x10
		private int m_PointSize; // 0x18
		private float m_Scale; // 0x1C
		private int m_UnitsPerEM; // 0x20
		private float m_LineHeight; // 0x24
		private float m_AscentLine; // 0x28
		private float m_CapLine; // 0x2C
		private float m_MeanLine; // 0x30
		private float m_Baseline; // 0x34
		private float m_DescentLine; // 0x38
		private float m_SuperscriptOffset; // 0x3C
		private float m_SuperscriptSize; // 0x40
		private float m_SubscriptOffset; // 0x44
		private float m_SubscriptSize; // 0x48
		private float m_UnderlineOffset; // 0x4C
		private float m_UnderlineThickness; // 0x50
		private float m_StrikethroughOffset; // 0x54
		private float m_StrikethroughThickness; // 0x58
		private float m_TabWidth; // 0x5C
	
		// Properties
		internal int faceIndex { get => default; } // 0x0000000185FE64F0-0x0000000185FE6500 
		public string familyName { get => default; set {} } // 0x0000000185FE6720-0x0000000185FE6730 0x00000001877900A4-0x00000001877900B4
		public string styleName { get => default; set {} } // 0x0000000185FC7990-0x0000000185FC79A0 0x0000000184096E30-0x0000000184096EF0
		public int pointSize { get => default; set {} } // 0x0000000185FC9940-0x0000000185FC9950 0x00000001813AE9C0-0x00000001813AE9D0
		public float scale { get => default; set {} } // 0x0000000185FE8CF0-0x0000000185FE8D00 0x0000000183B7E5A0-0x0000000183B7E5B0
		public float lineHeight { get => default; set {} } // 0x0000000185FE7AE0-0x0000000185FE7AF0 0x0000000185FB3820-0x0000000185FB3830
		public float ascentLine { get => default; set {} } // 0x0000000185FE8EA0-0x0000000185FE8EB0 0x0000000185FB0A60-0x0000000185FB0A70
		public float capLine { get => default; set {} } // 0x0000000185FE8D20-0x0000000185FE8D30 0x0000000185FB09B0-0x0000000185FB09C0
		public float meanLine { get => default; set {} } // 0x0000000185FE5830-0x0000000185FE5840 0x0000000185FB0BF0-0x0000000185FB0C00
		public float baseline { get => default; set {} } // 0x0000000186472350-0x0000000186472358 0x0000000185FB8A50-0x0000000185FB8A60
		public float descentLine { get => default; set {} } // 0x000000018646D1E0-0x000000018646D1F0 0x0000000185FB24C0-0x0000000185FB24D0
		public float superscriptOffset { get => default; set {} } // 0x000000018646D240-0x000000018646D248 0x0000000185FB05E0-0x0000000185FB05F0
		public float superscriptSize { get => default; set {} } // 0x000000018646D1F0-0x000000018646D200 0x0000000185FB05F0-0x0000000185FB0600
		public float subscriptOffset { get => default; set {} } // 0x000000018646D200-0x000000018646D210 0x0000000185FB0600-0x0000000185FB0610
		public float subscriptSize { get => default; set {} } // 0x000000018646D210-0x000000018646D218 0x0000000185FBCE20-0x0000000185FBCE30
		public float underlineOffset { get => default; set {} } // 0x0000000185FE8E70-0x0000000185FE8E80 0x0000000185FBFAC0-0x0000000185FBFAD0
		public float underlineThickness { get => default; set {} } // 0x0000000185FE8EC0-0x0000000185FE8ED0 0x0000000185FB3010-0x0000000185FB3020
		public float strikethroughOffset { get => default; set {} } // 0x0000000185FE8E80-0x0000000185FE8E90 0x0000000183F804D0-0x0000000183F804E0
		public float strikethroughThickness { set {} } // 0x0000000181DE28C0-0x0000000181DE28D0
		public float tabWidth { get => default; set {} } // 0x0000000185FE8EB0-0x0000000185FE8EC0 0x0000000185FBD3C0-0x0000000185FBD3D0
	}

	public enum GlyphClassDefinitionType // TypeDefIndex: 60493
	{
		Undefined = 0,
		Base = 1,
		Ligature = 2,
		Mark = 3,
		Component = 4
	}

	[Serializable]
	public struct GlyphRect : IEquatable<GlyphRect> // TypeDefIndex: 60494
	{
		// Fields
		private int m_X; // 0x00
		private int m_Y; // 0x04
		private int m_Width; // 0x08
		private int m_Height; // 0x0C
		private static readonly GlyphRect s_ZeroGlyphRect; // 0x00
	
		// Properties
		public int x { get => default; } // 0x0000000185FE64F0-0x0000000185FE6500 
		public int y { get => default; } // 0x0000000185FCA560-0x0000000185FCA570 
		public int width { get => default; } // 0x00000001835DC780-0x00000001835DC790 
		public int height { get => default; } // 0x0000000185FC9070-0x0000000185FC9080 
		public static GlyphRect zero { get => default; } // 0x00000001840130F0-0x0000000184013160 
	
		// Constructors
		public GlyphRect(int x, int y, int width, int height) : this() {
			m_X = default;
			m_Y = default;
			m_Width = default;
			m_Height = default;
		} // 0x0000000185FB2C50-0x0000000185FB2C70
		static GlyphRect() {
			s_ZeroGlyphRect = default;
		} // 0x0000000185F9E6F0-0x0000000185F9E730
	
		// Methods
		public override int GetHashCode() => default; // 0x000000018BF473D8-0x000000018BF47428
		public override bool Equals(object obj) => default; // 0x000000018BF47378-0x000000018BF473D8
		public bool Equals(GlyphRect other) => default; // 0x000000018BF472FC-0x000000018BF47378
	}

	[Serializable]
	public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 60495
	{
		// Fields
		private float m_Width; // 0x00
		private float m_Height; // 0x04
		private float m_HorizontalBearingX; // 0x08
		private float m_HorizontalBearingY; // 0x0C
		private float m_HorizontalAdvance; // 0x10
	
		// Properties
		public float width { get => default; } // 0x0000000185FE6770-0x0000000185FE6780 
		public float height { get => default; } // 0x0000000185FE64E0-0x0000000185FE64F0 
		public float horizontalBearingX { get => default; } // 0x0000000185FE64D0-0x0000000185FE64E0 
		public float horizontalBearingY { get => default; } // 0x0000000185FE66F0-0x0000000185FE6700 
		public float horizontalAdvance { get => default; } // 0x0000000185FE64C0-0x0000000185FE64D0 
	
		// Constructors
		public GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance) : this() {
			m_Width = default;
			m_Height = default;
			m_HorizontalBearingX = default;
			m_HorizontalBearingY = default;
			m_HorizontalAdvance = default;
		} // 0x0000000185FE8ED0-0x0000000185FE8F00
	
		// Methods
		public override int GetHashCode() => default; // 0x000000018BF47118-0x000000018BF4716C
		public override bool Equals(object obj) => default; // 0x000000018BF470B4-0x000000018BF47118
		public bool Equals(GlyphMetrics other) => default; // 0x000000018BF4702C-0x000000018BF470B4
	}

	[Serializable]
	public class Glyph // TypeDefIndex: 60496
	{
		// Fields
		private uint m_Index; // 0x10
		private GlyphMetrics m_Metrics; // 0x14
		private GlyphRect m_GlyphRect; // 0x28
		private float m_Scale; // 0x38
		private int m_AtlasIndex; // 0x3C
		private GlyphClassDefinitionType m_ClassDefinitionType; // 0x40
	
		// Properties
		public uint index { get => default; set {} } // 0x0000000185FE6790-0x0000000185FE67A0 0x0000000181378230-0x0000000181378240
		public GlyphMetrics metrics { get => default; set {} } // 0x0000000185FC3360-0x0000000185FC3380 0x0000000185FE8F60-0x0000000185FE8F70
		public GlyphRect glyphRect { get => default; set {} } // 0x0000000185FE8B20-0x0000000185FE8B30 0x0000000185FBB620-0x0000000185FBB630
		public float scale { get => default; set {} } // 0x000000018646D1E0-0x000000018646D1F0 0x0000000185FB24C0-0x0000000185FB24D0
		public int atlasIndex { get => default; set {} } // 0x0000000185FE65E0-0x0000000185FE65F0 0x0000000185FB07A0-0x0000000185FB07B0
		public GlyphClassDefinitionType classDefinitionType { get => default; } // 0x0000000185FE65D0-0x0000000185FE65E0 
	
		// Constructors
		public Glyph() {} // 0x00000001851339B0-0x00000001851339D0
		internal Glyph(GlyphMarshallingStruct glyphStruct) {} // 0x0000000184011680-0x00000001840116B0
		public Glyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) {} // 0x0000000185FE8F30-0x0000000185FE8F60
	}
}

namespace UnityEngine.TextCore.LowLevel
{
	public enum GlyphLoadFlags // TypeDefIndex: 60497
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

	public enum FontEngineError // TypeDefIndex: 60498
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

	public enum GlyphRenderMode // TypeDefIndex: 60499
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

	public enum GlyphPackingMode // TypeDefIndex: 60500
	{
		BestShortSideFit = 0,
		BestLongSideFit = 1,
		BestAreaFit = 2,
		BottomLeftRule = 3,
		ContactPointRule = 4
	}

	internal struct FontReference // TypeDefIndex: 60501
	{
		// Fields
		public string familyName; // 0x00
		public string styleName; // 0x08
		public int faceIndex; // 0x10
		public string filePath; // 0x18
	}

	public sealed class FontEngine // TypeDefIndex: 60502
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
		public FontEngine() {} // Dummy constructor
		static FontEngine() {} // 0x00000001840117B0-0x0000000184011990
	
		// Methods
		public static FontEngineError InitializeFontEngine() => default; // 0x000000018BF45FC4-0x000000018BF46004
		private static int InitializeFontEngine_Internal() => default; // 0x000000018BF45F98-0x000000018BF45FC4
		public static FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex) => default; // 0x000000018BF46158-0x000000018BF461B8
		private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex) => default; // 0x000000018BF46004-0x000000018BF46054
		public static FontEngineError LoadFontFace(Font font, int pointSize) => default; // 0x0000000184013680-0x00000001840136E0
		private static int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize) => default; // 0x00000001840136E0-0x0000000184013730
		public static FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex) => default; // 0x000000018BF460F8-0x000000018BF46158
		private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex) => default; // 0x000000018BF46054-0x000000018BF460A4
		public static FontEngineError LoadFontFace(string familyName, string styleName, int pointSize) => default; // 0x000000018BF461B8-0x000000018BF46218
		private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize) => default; // 0x000000018BF460A4-0x000000018BF460F8
		internal static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef) {
			fontRef = default;
			return default;
		} // 0x000000018BF46E8C-0x000000018BF46EEC
		private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef) {
			fontRef = default;
			return default;
		} // 0x000000018BF46E38-0x000000018BF46E8C
		public static FaceInfo GetFaceInfo() => default; // 0x000000018BF45DC0-0x000000018BF45E60
		private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) => default; // 0x000000018BF45D8C-0x000000018BF45DC0
		internal static uint GetGlyphIndex(uint unicode) => default; // 0x0000000184013160-0x00000001840131A0
		public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) {
			glyph = default;
			return default;
		} // 0x000000018BF46D20-0x000000018BF46E38
		private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) => default; // 0x000000018BF46CD0-0x000000018BF46D20
		public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) {
			glyph = default;
			return default;
		} // 0x000000018BF46BB8-0x000000018BF46CD0
		private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) => default; // 0x000000018BF46B68-0x000000018BF46BB8
		public static void AddGlyphToTextureByGpu(in Glyph glyph, int padding, RenderTexture texture) {} // 0x0000000184012800-0x00000001840128C0
		private static bool AddGlyphToTextureByGpu_Internal(in GlyphMarshallingStruct glyph, int padding, RenderTexture texture) => default; // 0x0000000184012910-0x0000000184012970
		public static void ProcessSDFGenerationRequest(Material material, ScriptableRenderContext scriptableRenderContext, CommandBuffer cmd) {} // 0x000000018BF4626C-0x000000018BF462E4
		private static void ProcessSDFGenerationRequest_Internal(Material material, IntPtr scriptableRenderContext, CommandBuffer cmd) {} // 0x000000018BF46218-0x000000018BF4626C
		internal static void SetTextureUploadMode(bool shouldUploadImmediately) {} // 0x000000018BF46318-0x000000018BF4634C
		internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture texture, out Glyph glyph) {
			glyph = default;
			return default;
		} // 0x0000000184011110-0x0000000184011610
		private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, out GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, out GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture texture, out GlyphMarshallingStruct glyph) {
			freeGlyphRects = default;
			usedGlyphRects = default;
			glyph = default;
			return default;
		} // 0x0000000184011610-0x0000000184011680
		internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture texture, out Glyph[] glyphs) {
			glyphs = default;
			return default;
		} // 0x000000018BF463B0-0x000000018BF46B68
		private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, out GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, out GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture texture, out GlyphMarshallingStruct[] glyphs, ref int glyphCount) {
			freeGlyphRects = default;
			usedGlyphRects = default;
			glyphs = default;
			return default;
		} // 0x000000018BF4634C-0x000000018BF463B0
		internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes) => default; // 0x000000018BF45E60-0x000000018BF45F64
		internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(List<uint> glyphIndexes, out int recordCount) {
			recordCount = default;
			return default;
		} // 0x0000000184682470-0x0000000184682520
		private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(uint[] glyphIndexes, out int recordCount) {
			recordCount = default;
			return default;
		} // 0x0000000184682520-0x0000000184682570
		private static int GetPairAdjustmentRecordsFromMarshallingArray(out GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) {
			glyphPairAdjustmentRecords = default;
			return default;
		} // 0x000000018BF45F64-0x000000018BF45F98
		private static void GenericListToMarshallingArray<T>(ref List<T> srcList, ref ref T[] dstArray) {}
		private static void SetMarshallingArraySize<T>(ref ref T[] marshallingArray, int recordCount) {}
		internal static void ResetAtlasTexture(Texture2D texture) {} // 0x000000018BF462E4-0x000000018BF46318
	}

	internal struct FontEngineUtilities // TypeDefIndex: 60503
	{
		// Methods
		internal static int MaxValue(int a, int b, int c) => default; // 0x000000018BF45D70-0x000000018BF45D8C
	}

	internal struct GlyphMarshallingStruct // TypeDefIndex: 60504
	{
		// Fields
		public uint index; // 0x00
		public GlyphMetrics metrics; // 0x04
		public GlyphRect glyphRect; // 0x18
		public float scale; // 0x28
		public int atlasIndex; // 0x2C
		public GlyphClassDefinitionType classDefinitionType; // 0x30
	
		// Constructors
		public GlyphMarshallingStruct(Glyph glyph) {
			index = default;
			metrics = default;
			glyphRect = default;
			scale = default;
			atlasIndex = default;
			classDefinitionType = default;
		} // 0x00000001840128C0-0x0000000184012910
	}

	public enum FontFeatureLookupFlags // TypeDefIndex: 60505
	{
		None = 0,
		IgnoreLigatures = 4,
		IgnoreSpacingAdjustments = 256
	}

	[Serializable]
	public struct GlyphValueRecord : IEquatable<GlyphValueRecord> // TypeDefIndex: 60506
	{
		// Fields
		private float m_XPlacement; // 0x00
		private float m_YPlacement; // 0x04
		private float m_XAdvance; // 0x08
		private float m_YAdvance; // 0x0C
	
		// Properties
		public float xPlacement { get => default; } // 0x0000000185FE6770-0x0000000185FE6780 
		public float yPlacement { get => default; } // 0x0000000185FE64E0-0x0000000185FE64F0 
		public float xAdvance { get => default; } // 0x0000000185FE64D0-0x0000000185FE64E0 
		public float yAdvance { get => default; } // 0x0000000185FE66F0-0x0000000185FE6700 
	
		// Methods
		public static GlyphValueRecord operator +(GlyphValueRecord a, GlyphValueRecord b) => default; // 0x0000000185FE8F10-0x0000000185FE8F30
		public override int GetHashCode() => default; // 0x000000018BF47504-0x000000018BF47554
		public override bool Equals(object obj) => default; // 0x000000018BF47428-0x000000018BF47488
		public bool Equals(GlyphValueRecord other) => default; // 0x000000018BF47488-0x000000018BF47504
	}

	[Serializable]
	public struct GlyphAdjustmentRecord : IEquatable<GlyphAdjustmentRecord> // TypeDefIndex: 60507
	{
		// Fields
		private uint m_GlyphIndex; // 0x00
		private GlyphValueRecord m_GlyphValueRecord; // 0x04
	
		// Properties
		public uint glyphIndex { get => default; } // 0x0000000185FE64F0-0x0000000185FE6500 
		public GlyphValueRecord glyphValueRecord { get => default; } // 0x0000000185FE8820-0x0000000185FE8830 
	
		// Methods
		public override int GetHashCode() => default; // 0x000000018BF46FD8-0x000000018BF4702C
		public override bool Equals(object obj) => default; // 0x000000018BF46F74-0x000000018BF46FD8
		public bool Equals(GlyphAdjustmentRecord other) => default; // 0x000000018BF46EEC-0x000000018BF46F74
	}

	[Serializable]
	public struct GlyphPairAdjustmentRecord : IEquatable<GlyphPairAdjustmentRecord> // TypeDefIndex: 60508
	{
		// Fields
		private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x00
		private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x14
		private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x28
	
		// Properties
		public GlyphAdjustmentRecord firstAdjustmentRecord { get => default; } // 0x0000000185FE8F00-0x0000000185FE8F10 
		public GlyphAdjustmentRecord secondAdjustmentRecord { get => default; } // 0x0000000185FC3360-0x0000000185FC3380 
	
		// Methods
		public override int GetHashCode() => default; // 0x000000018BF47294-0x000000018BF472FC
		public override bool Equals(object obj) => default; // 0x000000018BF4716C-0x000000018BF471E4
		public bool Equals(GlyphPairAdjustmentRecord other) => default; // 0x000000018BF471E4-0x000000018BF47294
	}
}
