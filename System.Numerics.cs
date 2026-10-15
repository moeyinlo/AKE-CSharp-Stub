/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 80: System.Numerics.dll - Assembly: System.Numerics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 89859-89881

internal static class SR // TypeDefIndex: 89860
{
	// Methods
	internal static string Format(string resourceFormat, object p1); // 0x000000018CFE7208-0x000000018CFE7264
}

namespace System.Globalization
{
	internal class FormatProvider // TypeDefIndex: 89879
	{
		// Nested types
		private class Number // TypeDefIndex: 89878
		{
			// Fields
			private static string[] s_posCurrencyFormats; // 0x00
			private static string[] s_negCurrencyFormats; // 0x08
			private static string[] s_posPercentFormats; // 0x10
			private static string[] s_negPercentFormats; // 0x18
			private static string[] s_negNumberFormats; // 0x20
			private static string s_posNumberFormat; // 0x28
	
			// Nested types
			internal struct NumberBuffer // TypeDefIndex: 89877
			{
				// Fields
				public int precision; // 0x00
				public int scale; // 0x04
				public bool sign; // 0x08
				public unsafe char* overrideDigits; // 0x10
	
				// Properties
				public unsafe char* digits { get; } // 0x00000001829260F0-0x0000000182926100 
			}
	
			// Constructors
			static Number(); // 0x0000000186B6D900-0x0000000186B6DFE0
	
			// Methods
			private static bool IsWhite(char ch); // 0x00000001854EFC80-0x00000001854EFCA0
			private static unsafe char* MatchChars(char* p, char* pEnd, string str); // 0x00000001854EFBC0-0x00000001854EFC40
			private static unsafe char* MatchChars(char* p, char* pEnd, char* str); // 0x00000001854EFC40-0x00000001854EFC80
			private static unsafe bool ParseNumber(ref char* str, char* strEnd, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal); // 0x00000001854EF7F0-0x00000001854EFBC0
			private static bool TrailingZeros(ReadOnlySpan<char> s, int index); // 0x000000018CFE6C30-0x000000018CFE6C98
			internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal); // 0x00000001854EF6B0-0x00000001854EF7F0
			internal static unsafe void Int32ToDecChars(char* buffer, ref int index, uint value, int digits); // 0x000000018CFE59F0-0x000000018CFE5A54
			internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits); // 0x000000018CFE6A04-0x000000018CFE6B6C
			internal static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal); // 0x000000018CFE6630-0x000000018CFE6A04
			private static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info); // 0x000000018CFE4DC0-0x000000018CFE4F64
			private static unsafe int wcslen(char* s); // 0x000000018CFE6C98-0x000000018CFE6CB8
			private static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup); // 0x000000018CFE5068-0x000000018CFE544C
			private static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info); // 0x000000018CFE55A4-0x000000018CFE572C
			private static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar); // 0x000000018CFE58DC-0x000000018CFE59F0
			private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign); // 0x000000018CFE4F64-0x000000018CFE5068
			private static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific); // 0x000000018CFE544C-0x000000018CFE55A4
			private static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info); // 0x000000018CFE572C-0x000000018CFE58DC
			private static void RoundNumber(ref NumberBuffer number, int pos); // 0x000000018CFE6B6C-0x000000018CFE6C30
			private static int FindSection(ReadOnlySpan<char> format, int section); // 0x000000018CFE4CB0-0x000000018CFE4DC0
			internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info); // 0x000000018CFE5A54-0x000000018CFE6630
		}
	
		// Methods
		internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex); // 0x000000018CFE3FF0-0x000000018CFE4130
		internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign); // 0x00000001854EF5B0-0x00000001854EF6B0
	}
}

namespace System.Numerics
{
	public struct Matrix3x2 : IEquatable<Matrix3x2> // TypeDefIndex: 89861
	{
		// Fields
		public float M11; // 0x00
		public float M12; // 0x04
		public float M21; // 0x08
		public float M22; // 0x0C
		public float M31; // 0x10
		public float M32; // 0x14
		private static readonly Matrix3x2 _identity; // 0x00
	
		// Constructors
		public Matrix3x2(float m11, float m12, float m21, float m22, float m31, float m32); // 0x0000000187258280-0x00000001872582B0
		static Matrix3x2(); // 0x000000018CFE44EC-0x000000018CFE4538
	
		// Methods
		public bool Equals(Matrix3x2 other); // 0x000000018CFE422C-0x000000018CFE42AC
		public override bool Equals(object obj); // 0x000000018CFE41A8-0x000000018CFE422C
		public override string ToString(); // 0x000000018CFE4338-0x000000018CFE44EC
		public override int GetHashCode(); // 0x000000018CFE42AC-0x000000018CFE4338
	}

	public struct Matrix4x4 : IEquatable<Matrix4x4> // TypeDefIndex: 89862
	{
		// Fields
		public float M11; // 0x00
		public float M12; // 0x04
		public float M13; // 0x08
		public float M14; // 0x0C
		public float M21; // 0x10
		public float M22; // 0x14
		public float M23; // 0x18
		public float M24; // 0x1C
		public float M31; // 0x20
		public float M32; // 0x24
		public float M33; // 0x28
		public float M34; // 0x2C
		public float M41; // 0x30
		public float M42; // 0x34
		public float M43; // 0x38
		public float M44; // 0x3C
		private static readonly Matrix4x4 _identity; // 0x00
	
		// Constructors
		public Matrix4x4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44); // 0x00000001872582B0-0x0000000187258360
		static Matrix4x4(); // 0x000000018CFE4BBC-0x000000018CFE4CB0
	
		// Methods
		public bool Equals(Matrix4x4 other); // 0x000000018CFE4538-0x000000018CFE465C
		public override bool Equals(object obj); // 0x000000018CFE465C-0x000000018CFE46F0
		public override string ToString(); // 0x000000018CFE4844-0x000000018CFE4BBC
		public override int GetHashCode(); // 0x000000018CFE46F0-0x000000018CFE4844
	}

	public struct Plane : IEquatable<Plane> // TypeDefIndex: 89863
	{
		// Fields
		public Vector3 Normal; // 0x00
		public float D; // 0x0C
	
		// Methods
		public bool Equals(Plane other); // 0x0000000184FB1FB0-0x0000000184FB1FF0
		public override bool Equals(object obj); // 0x000000018CFE6EA4-0x000000018CFE6F10
		public override string ToString(); // 0x000000018CFE6F40-0x000000018CFE6FDC
		public override int GetHashCode(); // 0x000000018CFE6F10-0x000000018CFE6F40
	}

	public struct Quaternion : IEquatable<Quaternion> // TypeDefIndex: 89864
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
		public float Z; // 0x08
		public float W; // 0x0C
	
		// Methods
		public bool Equals(Quaternion other); // 0x00000001862F2760-0x00000001862F27A0
		public override bool Equals(object obj); // 0x000000018CFE6FDC-0x000000018CFE704C
		public override string ToString(); // 0x000000018CFE70AC-0x000000018CFE7208
		public override int GetHashCode(); // 0x000000018CFE704C-0x000000018CFE70AC
	}

	public struct Vector2 : IEquatable<Vector2>, IFormattable // TypeDefIndex: 89865
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
	
		// Methods
		public override int GetHashCode(); // 0x000000018CFE7B88-0x000000018CFE7BF4
		public override bool Equals(object obj); // 0x000000018CFE7B24-0x000000018CFE7B88
		public override string ToString(); // 0x000000018CFE7BF4-0x000000018CFE7C54
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018CFE7C54-0x000000018CFE7D78
		[Intrinsic]
		public bool Equals(Vector2 other); // 0x000000018CCDF29C-0x000000018CCDF2C4
	}

	public struct Vector3 : IEquatable<Vector3>, IFormattable // TypeDefIndex: 89866
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
		public float Z; // 0x08
	
		// Methods
		public override int GetHashCode(); // 0x000000018CFE7DF0-0x000000018CFE7E88
		public override bool Equals(object obj); // 0x000000018CFE7D78-0x000000018CFE7DF0
		public override string ToString(); // 0x000000018CFE8074-0x000000018CFE80D4
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018CFE7E88-0x000000018CFE8074
		[Intrinsic]
		public bool Equals(Vector3 other); // 0x00000001855780F0-0x0000000185578120
	}

	public struct Vector4 : IEquatable<Vector4>, IFormattable // TypeDefIndex: 89867
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
		public float Z; // 0x08
		public float W; // 0x0C
	
		// Methods
		public override int GetHashCode(); // 0x000000018CFE8144-0x000000018CFE81FC
		public override bool Equals(object obj); // 0x000000018CFE80D4-0x000000018CFE8144
		public override string ToString(); // 0x000000018CFE839C-0x000000018CFE8678
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018CFE81FC-0x000000018CFE839C
		[Intrinsic]
		public bool Equals(Vector4 other); // 0x00000001862F2760-0x00000001862F27A0
	}

	[Serializable]
	[IsReadOnly]
	public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 89869
	{
		// Fields
		internal readonly int _sign; // 0x00
		internal readonly uint[] _bits; // 0x08
		private static readonly BigInteger s_bnMinInt; // 0x00
		private static readonly BigInteger s_bnOneInt; // 0x10
		private static readonly BigInteger s_bnZeroInt; // 0x20
		private static readonly BigInteger s_bnMinusOneInt; // 0x30
		private static readonly byte[] s_success; // 0x40
	
		// Properties
		public static BigInteger Zero { get; } // 0x000000018CFE2704-0x000000018CFE2760 
		public static BigInteger MinusOne { get; } // 0x000000018CFE26A8-0x000000018CFE2704 
		public bool IsZero { get; } // 0x0000000186535F00-0x0000000186535F10 
	
		// Nested types
		private enum GetBytesMode // TypeDefIndex: 89868
		{
			AllocateArray = 0,
			Count = 1,
			Span = 2
		}
	
		// Constructors
		public BigInteger(int value); // 0x0000000186175F00-0x0000000186175F30
		[CLSCompliant(false)]
		public BigInteger(uint value); // 0x000000018CFE2604-0x000000018CFE26A8
		public BigInteger(long value); // 0x0000000186176110-0x00000001861761E0
		[CLSCompliant(false)]
		public BigInteger(ulong value); // 0x000000018CFE1FEC-0x000000018CFE20E4
		public BigInteger(float value); // 0x000000018CFE25AC-0x000000018CFE2604
		public BigInteger(double value); // 0x000000018CFE20E4-0x000000018CFE23C8
		public BigInteger(decimal value); // 0x000000018CFE23C8-0x000000018CFE25AC
		[CLSCompliant(false)]
		public BigInteger(byte[] value); // 0x00000001861729E0-0x0000000186172A90
		public BigInteger(ReadOnlySpan<byte> value, bool isUnsigned = false /* Metadata: 0x0264A947 */, bool isBigEndian = false /* Metadata: 0x0264A948 */); // 0x0000000186172890-0x00000001861729E0
		internal BigInteger(int n, uint[] rgu); // 0x000000018783C19C-0x000000018783C1AC
		internal BigInteger(uint[] value, bool negative); // 0x0000000186176590-0x00000001861766C0
		static BigInteger(); // 0x0000000186496A40-0x0000000186496C10
	
		// Methods
		public static BigInteger Parse(string value, IFormatProvider provider); // 0x00000001854EF0C0-0x00000001854EF160
		public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider); // 0x00000001854EF160-0x00000001854EF1C0
		public override int GetHashCode(); // 0x000000018CFE1758-0x000000018CFE17B4
		public override bool Equals(object obj); // 0x000000018CFE1680-0x000000018CFE16FC
		public bool Equals(long other); // 0x000000018CFE1618-0x000000018CFE1680
		public bool Equals(BigInteger other); // 0x000000018CFE1578-0x000000018CFE1618
		public int CompareTo(long other); // 0x000000018CFE1400-0x000000018CFE1490
		public int CompareTo(BigInteger other); // 0x000000018CFE12CC-0x000000018CFE1400
		public int CompareTo(object obj); // 0x000000018CFE1490-0x000000018CFE1578
		public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false /* Metadata: 0x0264A949 */, bool isBigEndian = false /* Metadata: 0x0264A94A */); // 0x000000018CFE1EA0-0x000000018CFE1F4C
		internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false /* Metadata: 0x0264A94B */, bool isBigEndian = false /* Metadata: 0x0264A94C */); // 0x000000018CFE1F4C-0x000000018CFE1FEC
		private byte[] TryGetBytes(GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten); // 0x000000018CFE199C-0x000000018CFE1EA0
		public override string ToString(); // 0x0000000185392860-0x00000001853928A0
		public string ToString(IFormatProvider provider); // 0x000000018CFE1920-0x000000018CFE195C
		public string ToString(string format, IFormatProvider provider); // 0x000000018CFE195C-0x000000018CFE199C
		private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign); // 0x0000000186175FE0-0x00000001861760F0
		public static BigInteger operator -(BigInteger left, BigInteger right); // 0x000000018CFE35BC-0x000000018CFE3678
		private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign); // 0x000000018CFE17B4-0x000000018CFE1920
		public static implicit operator BigInteger(byte value); // 0x0000000186175AE0-0x0000000186175B10
		[CLSCompliant(false)]
		public static implicit operator BigInteger(sbyte value); // 0x000000018CFE2F58-0x000000018CFE2F7C
		public static implicit operator BigInteger(short value); // 0x000000018CFE2FBC-0x000000018CFE2FE0
		[CLSCompliant(false)]
		public static implicit operator BigInteger(ushort value); // 0x000000018CFE2FE0-0x000000018CFE3004
		public static implicit operator BigInteger(int value); // 0x0000000186175EE0-0x0000000186175F00
		[CLSCompliant(false)]
		public static implicit operator BigInteger(uint value); // 0x000000018CFE2F9C-0x000000018CFE2FBC
		public static implicit operator BigInteger(long value); // 0x00000001861760F0-0x0000000186176110
		[CLSCompliant(false)]
		public static implicit operator BigInteger(ulong value); // 0x000000018CFE2F7C-0x000000018CFE2F9C
		public static explicit operator byte(BigInteger value); // 0x000000018CFE2DB8-0x000000018CFE2E30
		[CLSCompliant(false)]
		public static explicit operator sbyte(BigInteger value); // 0x000000018CFE2ADC-0x000000018CFE2B54
		public static explicit operator short(BigInteger value); // 0x000000018CFE2908-0x000000018CFE2980
		[CLSCompliant(false)]
		public static explicit operator ushort(BigInteger value); // 0x000000018CFE2D40-0x000000018CFE2DB8
		public static explicit operator int(BigInteger value); // 0x0000000186172B40-0x0000000186172B80
		[CLSCompliant(false)]
		public static explicit operator uint(BigInteger value); // 0x000000018CFE2BA4-0x000000018CFE2C4C
		public static explicit operator long(BigInteger value); // 0x000000018CFE2E30-0x000000018CFE2F58
		[CLSCompliant(false)]
		public static explicit operator ulong(BigInteger value); // 0x0000000186BD20B0-0x0000000186BD2120
		public static explicit operator float(BigInteger value); // 0x000000018CFE2B54-0x000000018CFE2BA4
		public static explicit operator double(BigInteger value); // 0x000000018CFE2C4C-0x000000018CFE2D40
		public static explicit operator decimal(BigInteger value); // 0x000000018CFE2980-0x000000018CFE2ADC
		public static BigInteger operator <<(BigInteger value, int shift); // 0x0000000186176350-0x00000001861764E0
		public static BigInteger operator >>(BigInteger value, int shift); // 0x000000018CFE3278-0x000000018CFE35BC
		public static BigInteger operator -(BigInteger value); // 0x000000018CFE3678-0x000000018CFE36A8
		public static BigInteger operator +(BigInteger left, BigInteger right); // 0x0000000186175F30-0x0000000186175FE0
		public static BigInteger operator *(BigInteger left, BigInteger right); // 0x00000001861761E0-0x0000000186176350
		public static BigInteger operator /(BigInteger dividend, BigInteger divisor); // 0x000000018CFE2760-0x000000018CFE28AC
		public static bool operator <=(BigInteger left, BigInteger right); // 0x000000018CFE30B8-0x000000018CFE311C
		public static bool operator !=(BigInteger left, BigInteger right); // 0x000000018CFE3058-0x000000018CFE30B8
		public static bool operator <(BigInteger left, long right); // 0x000000018CFE3224-0x000000018CFE3278
		public static bool operator <=(BigInteger left, long right); // 0x000000018CFE311C-0x000000018CFE3174
		public static bool operator ==(BigInteger left, long right); // 0x000000018CFE28AC-0x000000018CFE2908
		public static bool operator !=(BigInteger left, long right); // 0x000000018CFE3004-0x000000018CFE3058
		public static bool operator <(long left, BigInteger right); // 0x000000018CFE31CC-0x000000018CFE3224
		public static bool operator <=(long left, BigInteger right); // 0x000000018CFE3174-0x000000018CFE31CC
		private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl); // 0x00000001861764E0-0x0000000186176590
		internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu); // 0x000000018CFE16FC-0x000000018CFE1758
	}

	internal static class BigIntegerCalculator // TypeDefIndex: 89870
	{
		// Fields
		private static int ReducerThreshold; // 0x00
		private static int SquareThreshold; // 0x04
		private static int AllocationThreshold; // 0x08
		private static int MultiplyThreshold; // 0x0C
	
		// Constructors
		static BigIntegerCalculator(); // 0x00000001871D76D0-0x00000001871D77D0
	
		// Methods
		public static uint[] Add(uint[] left, uint right); // 0x0000000186176700-0x00000001861767D0
		public static uint[] Add(uint[] left, uint[] right); // 0x000000018CFDFEBC-0x000000018CFDFFC0
		private static unsafe void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength); // 0x000000018CFDFE10-0x000000018CFDFEBC
		private static unsafe void AddSelf(uint* left, int leftLength, uint* right, int rightLength); // 0x000000018CFDFDA0-0x000000018CFDFE10
		public static uint[] Subtract(uint[] left, uint right); // 0x000000018CFE121C-0x000000018CFE12CC
		public static uint[] Subtract(uint[] left, uint[] right); // 0x000000018CFE1064-0x000000018CFE1178
		private static unsafe void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength); // 0x000000018CFE1178-0x000000018CFE121C
		public static int Compare(uint[] left, uint[] right); // 0x000000018CFDFFC0-0x000000018CFE0038
		public static uint[] Divide(uint[] left, uint right); // 0x000000018CFE043C-0x000000018CFE0510
		public static uint[] Divide(uint[] left, uint[] right); // 0x000000018CFE0510-0x000000018CFE0614
		private static unsafe void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength); // 0x000000018CFE00F0-0x000000018CFE043C
		private static unsafe uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength); // 0x000000018CFDFD6C-0x000000018CFDFDA0
		private static unsafe uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q); // 0x000000018CFE1024-0x000000018CFE1064
		private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo); // 0x000000018CFE00B4-0x000000018CFE00F0
		private static uint[] CreateCopy(uint[] value); // 0x000000018CFE0038-0x000000018CFE00B4
		private static int LeadingZeros(uint value); // 0x000000018CFE0614-0x000000018CFE067C
		public static uint[] Square(uint[] value); // 0x000000018CFE0E64-0x000000018CFE0F40
		private static unsafe void Square(uint* value, int valueLength, uint* bits, int bitsLength); // 0x000000018CFE0B64-0x000000018CFE0E64
		public static uint[] Multiply(uint[] left, uint right); // 0x00000001861767D0-0x00000001861768A0
		public static uint[] Multiply(uint[] left, uint[] right); // 0x000000018CFE067C-0x000000018CFE0790
		private static unsafe void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength); // 0x000000018CFE0790-0x000000018CFE0B64
		private static unsafe void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength); // 0x000000018CFE0F40-0x000000018CFE1024
	}

	internal static class BigNumber // TypeDefIndex: 89872
	{
		// Nested types
		private struct BigNumberBuffer // TypeDefIndex: 89871
		{
			// Fields
			public StringBuilder digits; // 0x00
			public int precision; // 0x08
			public int scale; // 0x0C
			public bool sign; // 0x10
	
			// Methods
			public static BigNumberBuffer Create(); // 0x00000001854EF4B0-0x00000001854EF530
		}
	
		// Methods
		internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e); // 0x00000001854EF530-0x00000001854EF5B0
		internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result); // 0x00000001854EF230-0x00000001854EF380
		internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info); // 0x00000001854EF1C0-0x00000001854EF230
		internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info); // 0x00000001854EF380-0x00000001854EF4B0
		private static bool HexNumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value); // 0x000000018CFE3AF8-0x000000018CFE3C7C
		private static bool NumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value); // 0x0000000186175B10-0x0000000186175DC0
		internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits); // 0x0000000185392830-0x0000000185392860
		private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess); // 0x000000018CFE36A8-0x000000018CFE3AF8
		internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info); // 0x00000001853928A0-0x0000000185392940
		private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess); // 0x0000000185392940-0x0000000185392A60
	}

	[Serializable]
	public struct Complex : IEquatable<Complex>, IFormattable // TypeDefIndex: 89873
	{
		// Fields
		public static readonly Complex Zero; // 0x00
		public static readonly Complex One; // 0x10
		public static readonly Complex ImaginaryOne; // 0x20
		private static readonly double s_sqrtRescaleThreshold; // 0x30
		private static readonly double s_asinOverflowThreshold; // 0x38
		private static readonly double s_log2; // 0x40
		private double m_real; // 0x00
		private double m_imaginary; // 0x08
	
		// Constructors
		public Complex(double real, double imaginary); // 0x0000000187235160-0x0000000187235170
		static Complex(); // 0x000000018CFE3EDC-0x000000018CFE3FF0
	
		// Methods
		public override bool Equals(object obj); // 0x000000018CFE3CBC-0x000000018CFE3D38
		public bool Equals(Complex value); // 0x000000018CFE3C7C-0x000000018CFE3CBC
		public override int GetHashCode(); // 0x000000018CFE3D38-0x000000018CFE3D84
		public override string ToString(); // 0x000000018CFE3E18-0x000000018CFE3EDC
		public string ToString(string format, IFormatProvider provider); // 0x000000018CFE3D84-0x000000018CFE3E18
	}

	internal struct DoubleUlong // TypeDefIndex: 89874
	{
		// Fields
		public double dbl; // 0x00
		public ulong uu; // 0x00
	}

	internal static class NumericsHelpers // TypeDefIndex: 89875
	{
		// Methods
		public static void GetDoubleParts(double dbl, out int sign, out int exp, out ulong man, out bool fFinite); // 0x000000018CFE6E1C-0x000000018CFE6EA4
		public static double GetDoubleFromParts(int sign, int exp, ulong man); // 0x000000018CFE6D68-0x000000018CFE6E1C
		public static void DangerousMakeTwosComplement(uint[] d); // 0x000000018CFE6CE8-0x000000018CFE6D68
		public static ulong MakeUlong(uint uHi, uint uLo); // 0x000000018723FC50-0x000000018723FC60
		public static uint Abs(int a); // 0x0000000187258360-0x0000000187258370
		public static uint CombineHash(uint u1, uint u2); // 0x0000000187258370-0x0000000187258380
		public static int CombineHash(int n1, int n2); // 0x0000000187258370-0x0000000187258380
		public static int CbitHighZero(uint u); // 0x000000018CFE0614-0x000000018CFE067C
		public static int CbitHighZero(ulong uu); // 0x000000018CFE6CB8-0x000000018CFE6CE8
	}
}

namespace System.Numerics.Hashing
{
	internal static class HashHelpers // TypeDefIndex: 89876
	{
		// Fields
		public static readonly int RandomSeed; // 0x00
	
		// Constructors
		static HashHelpers(); // 0x000000018CFE4130-0x000000018CFE41A8
	
		// Methods
		public static int Combine(int h1, int h2); // 0x0000000187251FA0-0x0000000187251FC0
	}
}

namespace System.Runtime.CompilerServices
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field, Inherited = false)]
	internal sealed class IntrinsicAttribute : Attribute // TypeDefIndex: 89881
	{
		// Constructors
		public IntrinsicAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Text
{
	[DefaultMember("Item")]
	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal struct ValueStringBuilder // TypeDefIndex: 89880
	{
		// Fields
		private char[] _arrayToReturnToPool; // 0x00
		private Span<char> _chars; // 0x08
		private int _pos; // 0x18
	
		// Properties
		public int Length { get; } // 0x00000001844AF510-0x00000001844AF520 
	
		// Constructors
		public ValueStringBuilder(Span<char> initialBuffer); // 0x0000000187251C80-0x0000000187251C90
	
		// Methods
		public override string ToString(); // 0x000000018CFE79BC-0x000000018CFE7A64
		public bool TryCopyTo(Span<char> destination, out int charsWritten); // 0x000000018CFE7A64-0x000000018CFE7B24
		public void Insert(int index, char value, int count); // 0x000000018CFE7878-0x000000018CFE79BC
		public void Append(char c); // 0x000000018CFE7600-0x000000018CFE7668
		public void Append(string s); // 0x000000018CFE74A0-0x000000018CFE753C
		private void AppendSlow(string s); // 0x000000018CFE7264-0x000000018CFE733C
		public void Append(char c, int count); // 0x000000018CFE73E4-0x000000018CFE74A0
		public unsafe void Append(char* value, int length); // 0x000000018CFE753C-0x000000018CFE7600
		public Span<char> AppendSpan(int length); // 0x000000018CFE733C-0x000000018CFE73E4
		private void GrowAndAppend(char c); // 0x000000018CFE76E8-0x000000018CFE7720
		private void Grow(int requiredAdditionalCapacity); // 0x000000018CFE7720-0x000000018CFE7878
		public void Dispose(); // 0x000000018CFE7668-0x000000018CFE76E8
	}
}
