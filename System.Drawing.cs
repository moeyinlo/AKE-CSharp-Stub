/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 75: System.Drawing.dll - Assembly: System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a - Types 89716-89726

namespace System.Drawing
{
	public enum KnownColor // TypeDefIndex: 89718
	{
		ActiveBorder = 1,
		ActiveCaption = 2,
		ActiveCaptionText = 3,
		AppWorkspace = 4,
		Control = 5,
		ControlDark = 6,
		ControlDarkDark = 7,
		ControlLight = 8,
		ControlLightLight = 9,
		ControlText = 10,
		Desktop = 11,
		GrayText = 12,
		Highlight = 13,
		HighlightText = 14,
		HotTrack = 15,
		InactiveBorder = 16,
		InactiveCaption = 17,
		InactiveCaptionText = 18,
		Info = 19,
		InfoText = 20,
		Menu = 21,
		MenuText = 22,
		ScrollBar = 23,
		Window = 24,
		WindowFrame = 25,
		WindowText = 26,
		Transparent = 27,
		AliceBlue = 28,
		AntiqueWhite = 29,
		Aqua = 30,
		Aquamarine = 31,
		Azure = 32,
		Beige = 33,
		Bisque = 34,
		Black = 35,
		BlanchedAlmond = 36,
		Blue = 37,
		BlueViolet = 38,
		Brown = 39,
		BurlyWood = 40,
		CadetBlue = 41,
		Chartreuse = 42,
		Chocolate = 43,
		Coral = 44,
		CornflowerBlue = 45,
		Cornsilk = 46,
		Crimson = 47,
		Cyan = 48,
		DarkBlue = 49,
		DarkCyan = 50,
		DarkGoldenrod = 51,
		DarkGray = 52,
		DarkGreen = 53,
		DarkKhaki = 54,
		DarkMagenta = 55,
		DarkOliveGreen = 56,
		DarkOrange = 57,
		DarkOrchid = 58,
		DarkRed = 59,
		DarkSalmon = 60,
		DarkSeaGreen = 61,
		DarkSlateBlue = 62,
		DarkSlateGray = 63,
		DarkTurquoise = 64,
		DarkViolet = 65,
		DeepPink = 66,
		DeepSkyBlue = 67,
		DimGray = 68,
		DodgerBlue = 69,
		Firebrick = 70,
		FloralWhite = 71,
		ForestGreen = 72,
		Fuchsia = 73,
		Gainsboro = 74,
		GhostWhite = 75,
		Gold = 76,
		Goldenrod = 77,
		Gray = 78,
		Green = 79,
		GreenYellow = 80,
		Honeydew = 81,
		HotPink = 82,
		IndianRed = 83,
		Indigo = 84,
		Ivory = 85,
		Khaki = 86,
		Lavender = 87,
		LavenderBlush = 88,
		LawnGreen = 89,
		LemonChiffon = 90,
		LightBlue = 91,
		LightCoral = 92,
		LightCyan = 93,
		LightGoldenrodYellow = 94,
		LightGray = 95,
		LightGreen = 96,
		LightPink = 97,
		LightSalmon = 98,
		LightSeaGreen = 99,
		LightSkyBlue = 100,
		LightSlateGray = 101,
		LightSteelBlue = 102,
		LightYellow = 103,
		Lime = 104,
		LimeGreen = 105,
		Linen = 106,
		Magenta = 107,
		Maroon = 108,
		MediumAquamarine = 109,
		MediumBlue = 110,
		MediumOrchid = 111,
		MediumPurple = 112,
		MediumSeaGreen = 113,
		MediumSlateBlue = 114,
		MediumSpringGreen = 115,
		MediumTurquoise = 116,
		MediumVioletRed = 117,
		MidnightBlue = 118,
		MintCream = 119,
		MistyRose = 120,
		Moccasin = 121,
		NavajoWhite = 122,
		Navy = 123,
		OldLace = 124,
		Olive = 125,
		OliveDrab = 126,
		Orange = 127,
		OrangeRed = 128,
		Orchid = 129,
		PaleGoldenrod = 130,
		PaleGreen = 131,
		PaleTurquoise = 132,
		PaleVioletRed = 133,
		PapayaWhip = 134,
		PeachPuff = 135,
		Peru = 136,
		Pink = 137,
		Plum = 138,
		PowderBlue = 139,
		Purple = 140,
		Red = 141,
		RosyBrown = 142,
		RoyalBlue = 143,
		SaddleBrown = 144,
		Salmon = 145,
		SandyBrown = 146,
		SeaGreen = 147,
		SeaShell = 148,
		Sienna = 149,
		Silver = 150,
		SkyBlue = 151,
		SlateBlue = 152,
		SlateGray = 153,
		Snow = 154,
		SpringGreen = 155,
		SteelBlue = 156,
		Tan = 157,
		Teal = 158,
		Thistle = 159,
		Tomato = 160,
		Turquoise = 161,
		Violet = 162,
		Wheat = 163,
		White = 164,
		WhiteSmoke = 165,
		Yellow = 166,
		YellowGreen = 167,
		ButtonFace = 168,
		ButtonHighlight = 169,
		ButtonShadow = 170,
		GradientActiveCaption = 171,
		GradientInactiveCaption = 172,
		MenuBar = 173,
		MenuHighlight = 174
	}

	internal static class KnownColorTable // TypeDefIndex: 89719
	{
		// Fields
		private static int[] s_colorTable; // 0x00
		private static string[] s_colorNameTable; // 0x08
	
		// Methods
		private static void EnsureColorTable(); // 0x000000018CFCB9F4-0x000000018CFCBA38
		private static void InitColorTable(); // 0x000000018CFCD078-0x000000018CFCDC60
		private static void EnsureColorNameTable(); // 0x000000018CFCB9AC-0x000000018CFCB9F4
		private static void InitColorNameTable(); // 0x000000018CFCBA38-0x000000018CFCD078
		public static int KnownColorToArgb(KnownColor color); // 0x000000018CFCDC60-0x000000018CFCDCC0
		public static string KnownColorToName(KnownColor color); // 0x000000018CFCDCC0-0x000000018CFCDD20
		private static void UpdateSystemColors(int[] colorTable); // 0x000000018CFCDD20-0x000000018CFCDF50
	}

	[Serializable]
	[DebuggerDisplay("{NameAndARGBValue}")]
	[IsReadOnly]
	public struct Color : IEquatable<Color> // TypeDefIndex: 89720
	{
		// Fields
		private readonly string name; // 0x00
		private readonly long value; // 0x08
		private readonly short knownColor; // 0x10
		private readonly short state; // 0x12
	
		// Properties
		public byte R { get; } // 0x000000018CFCB874-0x000000018CFCB888 
		public byte G { get; } // 0x000000018CFCB7E8-0x000000018CFCB7FC 
		public byte B { get; } // 0x000000018CFCB7E0-0x000000018CFCB7E8 
		public byte A { get; } // 0x000000018CFCB7CC-0x000000018CFCB7E0 
		public bool IsKnownColor { get; } // 0x000000018CFCB7FC-0x000000018CFCB804 
		public string Name { get; } // 0x000000018CFCB804-0x000000018CFCB874 
		private long Value { get; } // 0x000000018CFCB888-0x000000018CFCB8B4 
	
		// Methods
		public override string ToString(); // 0x000000018CFCB5D0-0x000000018CFCB7CC
		public static bool operator ==(Color left, Color right); // 0x000000018CFCB8B4-0x000000018CFCB934
		public override bool Equals(object obj); // 0x000000018CFCB454-0x000000018CFCB4CC
		public bool Equals(Color other); // 0x000000018CFCB4CC-0x000000018CFCB510
		public override int GetHashCode(); // 0x000000018CFCB510-0x000000018CFCB5D0
	}

	[Serializable]
	public struct Point : IEquatable<Point> // TypeDefIndex: 89721
	{
		// Fields
		private int x; // 0x00
		private int y; // 0x04
	
		// Properties
		public int X { get; } // 0x00000001844AD290-0x00000001844AD2A0 
		public int Y { get; } // 0x00000001872342E0-0x00000001872342F0 
	
		// Methods
		public static bool operator ==(Point left, Point right); // 0x00000001887DD0F0-0x00000001887DD108
		public override bool Equals(object obj); // 0x000000018CFCE184-0x000000018CFCE1E8
		public bool Equals(Point other); // 0x000000018CFCE178-0x000000018CFCE184
		public override int GetHashCode(); // 0x000000018CFCE1E8-0x000000018CFCE240
		public override string ToString(); // 0x000000018CFCE240-0x000000018CFCE340
	}

	[Serializable]
	public struct PointF : IEquatable<PointF> // TypeDefIndex: 89722
	{
		// Fields
		private float x; // 0x00
		private float y; // 0x04
	
		// Properties
		public float X { get; } // 0x00000001872342D0-0x00000001872342E0 
		public float Y { get; } // 0x000000018724A6D0-0x000000018724A6E0 
	
		// Methods
		public static bool operator ==(PointF left, PointF right); // 0x000000018CFCE140-0x000000018CFCE178
		public override bool Equals(object obj); // 0x000000018CFCDF5C-0x000000018CFCDFCC
		public bool Equals(PointF other); // 0x000000018CFCDF50-0x000000018CFCDF5C
		public override int GetHashCode(); // 0x000000018CFCDFCC-0x000000018CFCE050
		public override string ToString(); // 0x000000018CFCE050-0x000000018CFCE140
	}

	[Serializable]
	public struct Rectangle : IEquatable<Rectangle> // TypeDefIndex: 89723
	{
		// Fields
		private int x; // 0x00
		private int y; // 0x04
		private int width; // 0x08
		private int height; // 0x0C
	
		// Properties
		public int X { get; } // 0x00000001844AD290-0x00000001844AD2A0 
		public int Y { get; } // 0x00000001872342E0-0x00000001872342F0 
		public int Width { get; } // 0x0000000184431A70-0x0000000184431A80 
		public int Height { get; } // 0x0000000184431980-0x0000000184431990 
	
		// Methods
		public override bool Equals(object obj); // 0x000000018CFCE660-0x000000018CFCE6D8
		public bool Equals(Rectangle other); // 0x000000018CFCE6D8-0x000000018CFCE704
		public static bool operator ==(Rectangle left, Rectangle right); // 0x0000000188BCAFE8-0x0000000188BCB00C
		public override int GetHashCode(); // 0x000000018CFCE704-0x000000018CFCE790
		public override string ToString(); // 0x000000018CFCE790-0x000000018CFCE914
	}

	[Serializable]
	public struct RectangleF : IEquatable<RectangleF> // TypeDefIndex: 89724
	{
		// Fields
		private float x; // 0x00
		private float y; // 0x04
		private float width; // 0x08
		private float height; // 0x0C
	
		// Properties
		public float X { get; } // 0x00000001872342D0-0x00000001872342E0 
		public float Y { get; } // 0x000000018724A6D0-0x000000018724A6E0 
		public float Width { get; } // 0x000000018724A400-0x000000018724A410 
		public float Height { get; } // 0x000000018724AEC0-0x000000018724AED0 
	
		// Methods
		public override bool Equals(object obj); // 0x000000018CFCE340-0x000000018CFCE3B8
		public bool Equals(RectangleF other); // 0x000000018CFCE3B8-0x000000018CFCE3E4
		public static bool operator ==(RectangleF left, RectangleF right); // 0x00000001862F2760-0x00000001862F27A0
		public override int GetHashCode(); // 0x000000018CFCE3E4-0x000000018CFCE4CC
		public override string ToString(); // 0x000000018CFCE4CC-0x000000018CFCE660
	}

	[Serializable]
	public struct Size : IEquatable<Size> // TypeDefIndex: 89725
	{
		// Fields
		private int width; // 0x00
		private int height; // 0x04
	
		// Properties
		public int Width { get; } // 0x00000001844AD290-0x00000001844AD2A0 
		public int Height { get; } // 0x00000001872342E0-0x00000001872342F0 
	
		// Methods
		public static bool operator ==(Size sz1, Size sz2); // 0x00000001887DD0F0-0x00000001887DD108
		public override bool Equals(object obj); // 0x000000018CFCEAF8-0x000000018CFCEB5C
		public bool Equals(Size other); // 0x000000018CFCE178-0x000000018CFCE184
		public override int GetHashCode(); // 0x000000018CFCEB5C-0x000000018CFCEBB4
		public override string ToString(); // 0x000000018CFCEBB4-0x000000018CFCECA4
	}

	[Serializable]
	public struct SizeF : IEquatable<SizeF> // TypeDefIndex: 89726
	{
		// Fields
		private float width; // 0x00
		private float height; // 0x04
	
		// Properties
		public float Width { get; } // 0x00000001872342D0-0x00000001872342E0 
		public float Height { get; } // 0x000000018724A6D0-0x000000018724A6E0 
	
		// Methods
		public static bool operator ==(SizeF sz1, SizeF sz2); // 0x000000018CFCE140-0x000000018CFCE178
		public override bool Equals(object obj); // 0x000000018CFCE914-0x000000018CFCE984
		public bool Equals(SizeF other); // 0x000000018CFCDF50-0x000000018CFCDF5C
		public override int GetHashCode(); // 0x000000018CFCE984-0x000000018CFCEA08
		public override string ToString(); // 0x000000018CFCEA08-0x000000018CFCEAF8
	}
}

namespace System.Numerics.Hashing
{
	internal static class HashHelpers // TypeDefIndex: 89717
	{
		// Fields
		public static readonly int RandomSeed; // 0x00
	
		// Constructors
		static HashHelpers(); // 0x000000018CFCB934-0x000000018CFCB9AC
	
		// Methods
		public static int Combine(int h1, int h2); // 0x0000000187251FA0-0x0000000187251FC0
	}
}
