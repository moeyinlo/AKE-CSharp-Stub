/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;

// Image 114: UnityEngine.TextRenderingModule.dll - Assembly: UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60915-60928

namespace UnityEngine
{
	public enum FontStyle // TypeDefIndex: 60916
	{
		Normal = 0,
		Bold = 1,
		Italic = 2,
		BoldAndItalic = 3
	}

	internal enum TextGenerationError // TypeDefIndex: 60917
	{
		None = 0,
		CustomSizeOnNonDynamicFont = 1,
		CustomStyleOnNonDynamicFont = 2,
		NoFont = 4
	}

	public struct TextGenerationSettings // TypeDefIndex: 60918
	{
		// Fields
		public Font font; // 0x00
		public Color color; // 0x08
		public int fontSize; // 0x18
		public float lineSpacing; // 0x1C
		public bool richText; // 0x20
		public float scaleFactor; // 0x24
		public FontStyle fontStyle; // 0x28
		public TextAnchor textAnchor; // 0x2C
		public bool alignByGeometry; // 0x30
		public bool resizeTextForBestFit; // 0x31
		public int resizeTextMinSize; // 0x34
		public int resizeTextMaxSize; // 0x38
		public bool updateBounds; // 0x3C
		public VerticalWrapMode verticalOverflow; // 0x40
		public HorizontalWrapMode horizontalOverflow; // 0x44
		public Vector2 generationExtents; // 0x48
		public Vector2 pivot; // 0x50
		public bool generateOutOfBounds; // 0x58
	
		// Methods
		private bool CompareColors(Color left, Color right) => default; // 0x000000018BF71B64-0x000000018BF71BD8
		private bool CompareVector2(Vector2 left, Vector2 right) => default; // 0x000000018BF71BD8-0x000000018BF71C18
		public bool Equals(TextGenerationSettings other) => default; // 0x000000018BF71C18-0x000000018BF71E2C
	}

	public sealed class TextGenerator : IDisposable // TypeDefIndex: 60919
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
		private string m_LastString; // 0x18
		private TextGenerationSettings m_LastSettings; // 0x20
		private bool m_HasGenerated; // 0x80
		private TextGenerationError m_LastValid; // 0x84
		private readonly List<UIVertex> m_Verts; // 0x88
		private readonly List<UICharInfo> m_Characters; // 0x90
		private readonly List<UILineInfo> m_Lines; // 0x98
		private bool m_CachedVerts; // 0xA0
		private bool m_CachedCharacters; // 0xA1
		private bool m_CachedLines; // 0xA2
	
		// Properties
		public int characterCountVisible { get => default; } // 0x000000018BF72E20-0x000000018BF72E34 
		public IList<UIVertex> verts { get => default; } // 0x000000018BF72F8C-0x000000018BF72FCC 
		public IList<UICharInfo> characters { get => default; } // 0x000000018BF72E68-0x000000018BF72EA8 
		public IList<UILineInfo> lines { get => default; } // 0x000000018BF72EDC-0x000000018BF72F1C 
		public Rect rectExtents { get => default; } // 0x000000018BF72F60-0x000000018BF72F8C 
		public int characterCount { get => default; } // 0x000000018BF72E34-0x000000018BF72E68 
		public int lineCount { get => default; } // 0x000000018BF72EA8-0x000000018BF72EDC 
	
		// Constructors
		public TextGenerator() {} // 0x000000018BF72E10-0x000000018BF72E20
		public TextGenerator(int initialCapacity) {} // 0x000000018BF72CCC-0x000000018BF72E10
	
		// Methods
		~TextGenerator() {} // 0x000000018BF71E2C-0x000000018BF71EC4
		void IDisposable.Dispose() {} // 0x000000018BF72A44-0x000000018BF72A70
		private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) => default; // 0x000000018BF72A70-0x000000018BF72CCC
		public void Invalidate() {} // 0x0000000185FE9200-0x0000000185FE9210
		public void GetCharacters(List<UICharInfo> characters) {} // 0x000000018BF71F08-0x000000018BF71F10
		public void GetLines(List<UILineInfo> lines) {} // 0x000000018BF71F54-0x000000018BF71F5C
		public void GetVertices(List<UIVertex> vertices) {} // 0x000000018BF720A0-0x000000018BF720A8
		public float GetPreferredWidth(string str, TextGenerationSettings settings) => default; // 0x000000018BF71FD8-0x000000018BF7205C
		public float GetPreferredHeight(string str, TextGenerationSettings settings) => default; // 0x000000018BF71F5C-0x000000018BF71FD8
		public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) => default; // 0x000000018BF72494-0x000000018BF72640
		public bool Populate(string str, TextGenerationSettings settings) => default; // 0x000000018BF729EC-0x000000018BF72A44
		private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) => default; // 0x000000018BF723A8-0x000000018BF72494
		private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) => default; // 0x000000018BF72108-0x000000018BF723A8
		private static IntPtr Internal_Create() => default; // 0x000000018BF720A8-0x000000018BF720D4
		private static void Internal_Destroy(IntPtr ptr) {} // 0x000000018BF720D4-0x000000018BF72108
		internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) {
			error = default;
			return default;
		} // 0x000000018BF7287C-0x000000018BF729EC
		internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) {
			error = default;
			return default;
		} // 0x000000018BF726AC-0x000000018BF7287C
		private void GetVerticesInternal(object vertices) {} // 0x000000018BF7205C-0x000000018BF720A0
		private void GetCharactersInternal(object characters) {} // 0x000000018BF71EC4-0x000000018BF71F08
		private void GetLinesInternal(object lines) {} // 0x000000018BF71F10-0x000000018BF71F54
		private void get_rectExtents_Injected(out Rect ret) {
			ret = default;
		} // 0x000000018BF72F1C-0x000000018BF72F60
		private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) {
			error = default;
			return default;
		} // 0x000000018BF72640-0x000000018BF726AC
	}

	public enum TextAlignment // TypeDefIndex: 60920
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	public enum TextAnchor // TypeDefIndex: 60921
	{
		UpperLeft = 0,
		UpperCenter = 1,
		UpperRight = 2,
		MiddleLeft = 3,
		MiddleCenter = 4,
		MiddleRight = 5,
		LowerLeft = 6,
		LowerCenter = 7,
		LowerRight = 8
	}

	public enum HorizontalWrapMode // TypeDefIndex: 60922
	{
		Wrap = 0,
		Overflow = 1
	}

	public enum VerticalWrapMode // TypeDefIndex: 60923
	{
		Truncate = 0,
		Overflow = 1
	}

	public struct UICharInfo // TypeDefIndex: 60924
	{
		// Fields
		public Vector2 cursorPos; // 0x00
		public float charWidth; // 0x08
	}

	public struct UILineInfo // TypeDefIndex: 60925
	{
		// Fields
		public int startCharIdx; // 0x00
		public int height; // 0x04
		public float topY; // 0x08
		public float leading; // 0x0C
	}

	public struct UIVertex // TypeDefIndex: 60926
	{
		// Fields
		public Vector3 position; // 0x00
		public Vector3 normal; // 0x0C
		public Vector4 tangent; // 0x18
		public Color32 color; // 0x28
		public Vector4 uv0; // 0x2C
		public Vector4 uv1; // 0x3C
		public Vector4 uv2; // 0x4C
		public Vector4 uv3; // 0x5C
		private static readonly Color32 s_DefaultColor; // 0x00
		private static readonly Vector4 s_DefaultTangent; // 0x04
		public static UIVertex simpleVert; // 0x14
	
		// Constructors
		static UIVertex() {
			s_DefaultColor = default;
			s_DefaultTangent = default;
			simpleVert = default;
		} // 0x0000000185B56F00-0x0000000185B57040
	}

	public sealed class Font : Object // TypeDefIndex: 60928
	{
		// Fields
		private static Action<Font> textureRebuilt; // 0x00
		private FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18
	
		// Properties
		public Material material { get => default; } // 0x000000018BF71A60-0x000000018BF71A94 
		public bool dynamic { get => default; } // 0x000000018BF71944-0x000000018BF71990 
		public int fontSize { get => default; } // 0x0000000184ED10F0-0x0000000184ED1150 
	
		// Events
		public static event Action<Font> textureRebuilt;
	
		// Nested types
		public delegate void FontTextureRebuildCallback(); // TypeDefIndex: 60927; 0x000000018BF71AC8-0x000000018BF71B64
	
		// Constructors
		public Font() {} // 0x000000018BF718B0-0x000000018BF718C0
	
		// Methods
		internal static void InvokeTextureRebuilt_Internal(Font font) {} // 0x000000018BF718C0-0x000000018BF71900
		public bool HasCharacter(char c) => default; // 0x000000018BF71900-0x000000018BF71944
		private bool HasCharacter(int c) => default; // 0x00000001864BC330-0x00000001864BC3F4
		private static void Internal_CreateFont(Font self, string name) {} // 0x00000001864BC320-0x00000001864BC330
	}
}
