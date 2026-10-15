/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 117: UnityEngine.TextRenderingModule.dll - Assembly: UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91010-91023

namespace UnityEngine
{
	public enum FontStyle // TypeDefIndex: 91011
	{
		Normal = 0,
		Bold = 1,
		Italic = 2,
		BoldAndItalic = 3
	}

	[Flags]
	internal enum TextGenerationError // TypeDefIndex: 91012
	{
		None = 0,
		CustomSizeOnNonDynamicFont = 1,
		CustomStyleOnNonDynamicFont = 2,
		NoFont = 4
	}

	public struct TextGenerationSettings // TypeDefIndex: 91013
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
		private bool CompareColors(Color left, Color right); // 0x000000018D587488-0x000000018D587588
		private bool CompareVector2(Vector2 left, Vector2 right); // 0x000000018D587588-0x000000018D587630
		public bool Equals(TextGenerationSettings other); // 0x000000018D587630-0x000000018D5878B8
	}

	[NativeHeader("Modules/TextRendering/TextGenerator.h")]
	[UsedByNativeCode]
	public sealed class TextGenerator : IDisposable // TypeDefIndex: 91014
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
		public int characterCountVisible { get; } // 0x000000018D5888B8-0x000000018D5888CC 
		public IList<UIVertex> verts { get; } // 0x000000018D588A24-0x000000018D588A64 
		public IList<UICharInfo> characters { get; } // 0x000000018D588900-0x000000018D588940 
		public IList<UILineInfo> lines { get; } // 0x000000018D588974-0x000000018D5889B4 
		public Rect rectExtents { get; } // 0x000000018D5889F8-0x000000018D588A24 
		public int characterCount { get; } // 0x000000018D5888CC-0x000000018D588900 
		public int lineCount { get; } // 0x000000018D588940-0x000000018D588974 
	
		// Constructors
		public TextGenerator(); // 0x000000018D5888A8-0x000000018D5888B8
		public TextGenerator(int initialCapacity); // 0x000000018D588764-0x000000018D5888A8
	
		// Methods
		~TextGenerator(); // 0x000000018D5878B8-0x000000018D587950
		void IDisposable.Dispose(); // 0x000000018D5884DC-0x000000018D588508
		private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings); // 0x000000018D588508-0x000000018D588764
		public void Invalidate(); // 0x0000000187262580-0x0000000187262590
		public void GetCharacters(List<UICharInfo> characters); // 0x000000018D587994-0x000000018D58799C
		public void GetLines(List<UILineInfo> lines); // 0x000000018D5879E0-0x000000018D5879E8
		public void GetVertices(List<UIVertex> vertices); // 0x000000018D587B2C-0x000000018D587B34
		public float GetPreferredWidth(string str, TextGenerationSettings settings); // 0x000000018D587A64-0x000000018D587AE8
		public float GetPreferredHeight(string str, TextGenerationSettings settings); // 0x000000018D5879E8-0x000000018D587A64
		public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context); // 0x000000018D587F28-0x000000018D5880D4
		public bool Populate(string str, TextGenerationSettings settings); // 0x000000018D588484-0x000000018D5884DC
		private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings); // 0x000000018D587E3C-0x000000018D587F28
		private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings); // 0x000000018D587B94-0x000000018D587E3C
		[NativeMethod(IsThreadSafe = true)]
		private static IntPtr Internal_Create(); // 0x000000018D587B34-0x000000018D587B60
		[NativeMethod(IsThreadSafe = true)]
		private static void Internal_Destroy(IntPtr ptr); // 0x000000018D587B60-0x000000018D587B94
		internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error); // 0x000000018D588314-0x000000018D588484
		internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error); // 0x000000018D588140-0x000000018D588314
		[NativeThrows]
		private void GetVerticesInternal(object vertices); // 0x000000018D587AE8-0x000000018D587B2C
		[NativeThrows]
		private void GetCharactersInternal(object characters); // 0x000000018D587950-0x000000018D587994
		[NativeThrows]
		private void GetLinesInternal(object lines); // 0x000000018D58799C-0x000000018D5879E0
		private void get_rectExtents_Injected(out Rect ret); // 0x000000018D5889B4-0x000000018D5889F8
		private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error); // 0x000000018D5880D4-0x000000018D588140
	}

	public enum TextAlignment // TypeDefIndex: 91015
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	public enum TextAnchor // TypeDefIndex: 91016
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

	public enum HorizontalWrapMode // TypeDefIndex: 91017
	{
		Wrap = 0,
		Overflow = 1
	}

	public enum VerticalWrapMode // TypeDefIndex: 91018
	{
		Truncate = 0,
		Overflow = 1
	}

	[UsedByNativeCode]
	public struct UICharInfo // TypeDefIndex: 91019
	{
		// Fields
		public Vector2 cursorPos; // 0x00
		public float charWidth; // 0x08
	}

	[UsedByNativeCode]
	public struct UILineInfo // TypeDefIndex: 91020
	{
		// Fields
		public int startCharIdx; // 0x00
		public int height; // 0x04
		public float topY; // 0x08
		public float leading; // 0x0C
	}

	[UsedByNativeCode]
	public struct UIVertex // TypeDefIndex: 91021
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
		static UIVertex(); // 0x0000000186DDC350-0x0000000186DDC490
	}

	[NativeClass("TextRendering::Font")]
	[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
	[NativeHeader("Modules/TextRendering/Public/Font.h")]
	[StaticAccessor("TextRenderingPrivate", StaticAccessorType.DoubleColon)]
	public sealed class Font : Object // TypeDefIndex: 91023
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Font> textureRebuilt; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18
	
		// Properties
		public Material material { get; } // 0x000000018D5873B8-0x000000018D5873EC 
		public bool dynamic { get; } // 0x000000018D587350-0x000000018D587384 
		public int fontSize { get; } // 0x000000018D587384-0x000000018D5873B8 
	
		// Events
		public static event Action<Font> textureRebuilt {
			add; // 0x000000018D5872B4-0x000000018D587350
			remove; // 0x000000018D5873EC-0x000000018D587488
		}
	
		// Nested types
		public delegate void FontTextureRebuildCallback(); // TypeDefIndex: 91022; 0x0000000185B44B70-0x0000000185B44B80
	
		// Constructors
		public Font(); // 0x000000018D587268-0x000000018D5872B4
	
		// Methods
		[RequiredByNativeCode]
		internal static void InvokeTextureRebuilt_Internal(Font font); // 0x00000001860632F0-0x0000000186063350
		public bool HasCharacter(char c); // 0x000000018D5871D4-0x000000018D5871E4
		private bool HasCharacter(int c); // 0x000000018D5871E4-0x000000018D587224
		private static void Internal_CreateFont([Writable] Font self, string name); // 0x000000018D587224-0x000000018D587268
	}
}
