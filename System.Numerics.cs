/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Globalization;
using System.Text;

// Image 78: System.Numerics.dll - Assembly: System.Numerics, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59957-59979

internal static class SR // TypeDefIndex: 59958
{
	// Methods
	internal static string Format(string resourceFormat, object p1) => default; // 0x000000018B97AEBC-0x000000018B97AF18
}

namespace System.Globalization
{
	internal class FormatProvider // TypeDefIndex: 59977
	{
		// Nested types
		private class Number // TypeDefIndex: 59976
		{
			// Fields
			private static string[] s_posCurrencyFormats; // 0x00
			private static string[] s_negCurrencyFormats; // 0x08
			private static string[] s_posPercentFormats; // 0x10
			private static string[] s_negPercentFormats; // 0x18
			private static string[] s_negNumberFormats; // 0x20
			private static string s_posNumberFormat; // 0x28
	
			// Nested types
			internal struct NumberBuffer // TypeDefIndex: 59975
			{
				// Fields
				public int precision; // 0x00
				public int scale; // 0x04
				public bool sign; // 0x08
				public unsafe char* overrideDigits; // 0x10
	
				// Properties
				public unsafe char* digits { get => default; } // 0x000000018B976BD8-0x000000018B976D0C 
			}
	
			// Constructors
			public Number() {} // Dummy constructor
			static Number() {} // 0x000000018B9787CC-0x000000018B97938C
	
			// Methods
			private static bool IsWhite(char ch) => default; // 0x000000018B976D0C-0x000000018B976E04
			private static unsafe char* MatchChars(char* p, char* pEnd, string str) => default; // 0x000000018B9786FC-0x000000018B978718
			private static unsafe char* MatchChars(char* p, char* pEnd, char* str) => default; // 0x000000018B978764-0x000000018B9787CC
			private static unsafe bool ParseNumber(ref char* str, char* strEnd, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) => default; // 0x000000018B978718-0x000000018B978764
			private static bool TrailingZeros(ReadOnlySpan<char> s, int index) => default; // 0x000000018B9798D4-0x000000018B97A020
			internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) => default; // 0x000000018B97A0E4-0x000000018B97A148
			internal static unsafe void Int32ToDecChars(char* buffer, ref int index, uint value, int digits) {} // 0x000000018B97A148-0x000000018B97A27C
			internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) {
				digits = default;
				return default;
			} // 0x000000018B978694-0x000000018B9786FC
			internal static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) {} // 0x000000018B979770-0x000000018B9798D4
			private static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) {} // 0x000000018B97938C-0x000000018B979770
			private static unsafe int wcslen(char* s) => default; // 0x000000018B977A74-0x000000018B977C18
			private static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) {} // 0x000000018B97A940-0x000000018B97A960
			private static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) {} // 0x000000018B977D1C-0x000000018B9780F4
			private static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) {} // 0x000000018B978250-0x000000018B9783D4
			private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) {} // 0x000000018B978580-0x000000018B978694
			private static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) {} // 0x000000018B977C18-0x000000018B977D1C
			private static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) {} // 0x000000018B9780F4-0x000000018B978250
			private static void RoundNumber(ref NumberBuffer number, int pos) {} // 0x000000018B9783D4-0x000000018B978580
			private static int FindSection(ReadOnlySpan<char> format, int section) => default; // 0x000000018B97A020-0x000000018B97A0E4
			internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info) {} // 0x000000018B977968-0x000000018B977A74
		}
	
		// Constructors
		public FormatProvider() {} // Dummy constructor
	
		// Methods
		internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) {} // 0x000000018B97A27C-0x000000018B97A940
		internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) {
			precision = default;
			scale = default;
			sign = default;
			return default;
		} // 0x000000018346D130-0x000000018346D140
	}
}

namespace System.Numerics
{
	public struct Matrix3x2 : IEquatable<Matrix3x2> // TypeDefIndex: 59959
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
		public Matrix3x2(float m11, float m12, float m21, float m22, float m31, float m32) {
			M11 = default;
			M12 = default;
			M21 = default;
			M22 = default;
			M31 = default;
			M32 = default;
		} // 0x0000000185FD6260-0x0000000185FD6290
		static Matrix3x2() {
			_identity = default;
		} // 0x000000018B9771A8-0x000000018B9771F4
	
		// Methods
		public bool Equals(Matrix3x2 other) => default; // 0x000000018B976EE8-0x000000018B976F68
		public override bool Equals(object obj) => default; // 0x000000018B976E64-0x000000018B976EE8
		public override string ToString() => default; // 0x000000018B976FF4-0x000000018B9771A8
		public override int GetHashCode() => default; // 0x000000018B976F68-0x000000018B976FF4
	}

	public struct Matrix4x4 : IEquatable<Matrix4x4> // TypeDefIndex: 59960
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
		public Matrix4x4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44) {
			M11 = default;
			M12 = default;
			M13 = default;
			M14 = default;
			M21 = default;
			M22 = default;
			M23 = default;
			M24 = default;
			M31 = default;
			M32 = default;
			M33 = default;
			M34 = default;
			M41 = default;
			M42 = default;
			M43 = default;
			M44 = default;
		} // 0x0000000185FD6290-0x0000000185FD6340
		static Matrix4x4() {
			_identity = default;
		} // 0x000000018B977878-0x000000018B977968
	
		// Methods
		public bool Equals(Matrix4x4 other) => default; // 0x000000018B9771F4-0x000000018B977318
		public override bool Equals(object obj) => default; // 0x000000018B977318-0x000000018B9773AC
		public override string ToString() => default; // 0x000000018B977500-0x000000018B977878
		public override int GetHashCode() => default; // 0x000000018B9773AC-0x000000018B977500
	}

	public struct Plane : IEquatable<Plane> // TypeDefIndex: 59961
	{
		// Fields
		public Vector3 Normal; // 0x00
		public float D; // 0x0C
	
		// Methods
		public bool Equals(Plane other) => default; // 0x00000001841EEC50-0x00000001841EEC90
		public override bool Equals(object obj) => default; // 0x000000018B97AB5C-0x000000018B97ABC8
		public override string ToString() => default; // 0x000000018B97ABF8-0x000000018B97AC90
		public override int GetHashCode() => default; // 0x000000018B97ABC8-0x000000018B97ABF8
	}

	public struct Quaternion : IEquatable<Quaternion> // TypeDefIndex: 59962
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
		public float Z; // 0x08
		public float W; // 0x0C
	
		// Methods
		public bool Equals(Quaternion other) => default; // 0x0000000184A6EB60-0x0000000184A6EBA0
		public override bool Equals(object obj) => default; // 0x000000018B97AC90-0x000000018B97AD00
		public override string ToString() => default; // 0x000000018B97AD60-0x000000018B97AEBC
		public override int GetHashCode() => default; // 0x000000018B97AD00-0x000000018B97AD60
	}

	public struct Vector2 : IEquatable<Vector2>, IFormattable // TypeDefIndex: 59963
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
	
		// Methods
		public override int GetHashCode() => default; // 0x000000018B97B828-0x000000018B97B894
		public override bool Equals(object obj) => default; // 0x000000018B97B7C4-0x000000018B97B828
		public override string ToString() => default; // 0x000000018B97B894-0x000000018B97B8F4
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018B97B8F4-0x000000018B97BA18
		public bool Equals(Vector2 other) => default; // 0x000000018B631440-0x000000018B631468
	}

	public struct Vector3 : IEquatable<Vector3>, IFormattable // TypeDefIndex: 59964
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
		public float Z; // 0x08
	
		// Methods
		public override int GetHashCode() => default; // 0x000000018B97BA90-0x000000018B97BB28
		public override bool Equals(object obj) => default; // 0x000000018B97BA18-0x000000018B97BA90
		public override string ToString() => default; // 0x000000018B97BD18-0x000000018B97BD78
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018B97BB28-0x000000018B97BD18
		public bool Equals(Vector3 other) => default; // 0x00000001843884A0-0x00000001843884D0
	}

	public struct Vector4 : IEquatable<Vector4>, IFormattable // TypeDefIndex: 59965
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
		public float Z; // 0x08
		public float W; // 0x0C
	
		// Methods
		public override int GetHashCode() => default; // 0x000000018B97BDE8-0x000000018B97BEA0
		public override bool Equals(object obj) => default; // 0x000000018B97BD78-0x000000018B97BDE8
		public override string ToString() => default; // 0x000000018B97C040-0x000000018B97C3EC
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018B97BEA0-0x000000018B97C040
		public bool Equals(Vector4 other) => default; // 0x0000000184A6EB60-0x0000000184A6EBA0
	}

	[Serializable]
	public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 59967
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
		public static BigInteger Zero { get => default; } // 0x000000018B973834-0x000000018B973890 
		public static BigInteger MinusOne { get => default; } // 0x000000018B9737D8-0x000000018B973834 
		public bool IsZero { get => default; } // 0x00000001840066E0-0x00000001840066F0 
	
		// Nested types
		private enum GetBytesMode // TypeDefIndex: 59966
		{
			AllocateArray = 0,
			Count = 1,
			Span = 2
		}
	
		// Constructors
		public BigInteger(int value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018B97375C-0x000000018B9737D8
		public BigInteger(uint value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018B973138-0x000000018B9731D8
		public BigInteger(long value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018B972FDC-0x000000018B973138
		public BigInteger(ulong value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018B9729D8-0x000000018B972ACC
		public BigInteger(float value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018B972F84-0x000000018B972FDC
		public BigInteger(double value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018B972ACC-0x000000018B972DA8
		public BigInteger(decimal value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018B972DA8-0x000000018B972F84
		public BigInteger(byte[] value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018B9728F4-0x000000018B9729D8
		public BigInteger(ReadOnlySpan<byte> value, bool isUnsigned = false /* Metadata: 0x020824E0 */, bool isBigEndian = false /* Metadata: 0x020824E1 */) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018B9731D8-0x000000018B97375C
		internal BigInteger(int n, uint[] rgu) : this() {
			_sign = default;
			_bits = default;
		} // 0x0000000189317CA8-0x0000000189317CB8
		internal BigInteger(uint[] value, bool negative) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018B972748-0x000000018B9728F4
		static BigInteger() {
			s_bnMinInt = default;
			s_bnOneInt = default;
			s_bnZeroInt = default;
			s_bnMinusOneInt = default;
			s_success = default;
		} // 0x000000018B972590-0x000000018B972748
	
		// Methods
		public static BigInteger Parse(string value, IFormatProvider provider) => default; // 0x000000018B971C90-0x000000018B971D14
		public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) => default; // 0x000000018B971D14-0x000000018B971D6C
		public override int GetHashCode() => default; // 0x000000018B971B74-0x000000018B971BC4
		public override bool Equals(object obj) => default; // 0x000000018B971AA4-0x000000018B971B20
		public bool Equals(long other) => default; // 0x000000018B971A3C-0x000000018B971AA4
		public bool Equals(BigInteger other) => default; // 0x000000018B97199C-0x000000018B971A3C
		public int CompareTo(long other) => default; // 0x000000018B971824-0x000000018B9718B4
		public int CompareTo(BigInteger other) => default; // 0x000000018B9716F0-0x000000018B971824
		public int CompareTo(object obj) => default; // 0x000000018B9718B4-0x000000018B97199C
		public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false /* Metadata: 0x020824E2 */, bool isBigEndian = false /* Metadata: 0x020824E3 */) {
			bytesWritten = default;
			return default;
		} // 0x000000018B972450-0x000000018B9724F4
		internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false /* Metadata: 0x020824E4 */, bool isBigEndian = false /* Metadata: 0x020824E5 */) {
			bytesWritten = default;
			return default;
		} // 0x000000018B9724F4-0x000000018B972590
		private byte[] TryGetBytes(GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten) => default; // 0x000000018B971F8C-0x000000018B972450
		public override string ToString() => default; // 0x000000018B971ED8-0x000000018B971F10
		public string ToString(IFormatProvider provider) => default; // 0x000000018B971F10-0x000000018B971F4C
		public string ToString(string format, IFormatProvider provider) => default; // 0x000000018B971F4C-0x000000018B971F8C
		private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) => default; // 0x000000018B9715BC-0x000000018B9716F0
		public static BigInteger operator -(BigInteger left, BigInteger right) => default; // 0x000000018B974D5C-0x000000018B974E10
		private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) => default; // 0x000000018B971D6C-0x000000018B971ED8
		public static implicit operator BigInteger(byte value) => default; // 0x000000018B9743C8-0x000000018B9743EC
		public static implicit operator BigInteger(sbyte value) => default; // 0x000000018B974340-0x000000018B974364
		public static implicit operator BigInteger(short value) => default; // 0x000000018B9743A4-0x000000018B9743C8
		public static implicit operator BigInteger(ushort value) => default; // 0x000000018B97440C-0x000000018B974430
		public static implicit operator BigInteger(int value) => default; // 0x000000018B974320-0x000000018B974340
		public static implicit operator BigInteger(uint value) => default; // 0x000000018B974384-0x000000018B9743A4
		public static implicit operator BigInteger(long value) => default; // 0x000000018B9743EC-0x000000018B97440C
		public static implicit operator BigInteger(ulong value) => default; // 0x000000018B974364-0x000000018B974384
		public static explicit operator byte(BigInteger value) => default; // 0x000000018B974180-0x000000018B9741F8
		public static explicit operator sbyte(BigInteger value) => default; // 0x000000018B973DDC-0x000000018B973E54
		public static explicit operator short(BigInteger value) => default; // 0x000000018B973AEC-0x000000018B973B64
		public static explicit operator ushort(BigInteger value) => default; // 0x000000018B974108-0x000000018B974180
		public static explicit operator int(BigInteger value) => default; // 0x000000018B973CA8-0x000000018B973DDC
		public static explicit operator uint(BigInteger value) => default; // 0x000000018B973EA4-0x000000018B973F4C
		public static explicit operator long(BigInteger value) => default; // 0x000000018B9741F8-0x000000018B974320
		public static explicit operator ulong(BigInteger value) => default; // 0x000000018B974044-0x000000018B974108
		public static explicit operator float(BigInteger value) => default; // 0x000000018B973E54-0x000000018B973EA4
		public static explicit operator double(BigInteger value) => default; // 0x000000018B973F4C-0x000000018B974044
		public static explicit operator decimal(BigInteger value) => default; // 0x000000018B973B64-0x000000018B973CA8
		public static BigInteger operator <<(BigInteger value, int shift) => default; // 0x000000018B9744E4-0x000000018B974718
		public static BigInteger operator >>(BigInteger value, int shift) => default; // 0x000000018B974A54-0x000000018B974D5C
		public static BigInteger operator -(BigInteger value) => default; // 0x000000018B974E10-0x000000018B974E40
		public static BigInteger operator +(BigInteger left, BigInteger right) => default; // 0x000000018B973890-0x000000018B973944
		public static BigInteger operator *(BigInteger left, BigInteger right) => default; // 0x000000018B9748D8-0x000000018B974A54
		public static BigInteger operator /(BigInteger dividend, BigInteger divisor) => default; // 0x000000018B973944-0x000000018B973A90
		public static bool operator <=(BigInteger left, BigInteger right) => default; // 0x000000018B974718-0x000000018B97477C
		public static bool operator !=(BigInteger left, BigInteger right) => default; // 0x000000018B974484-0x000000018B9744E4
		public static bool operator <(BigInteger left, long right) => default; // 0x000000018B974884-0x000000018B9748D8
		public static bool operator <=(BigInteger left, long right) => default; // 0x000000018B97477C-0x000000018B9747D4
		public static bool operator ==(BigInteger left, long right) => default; // 0x000000018B973A90-0x000000018B973AEC
		public static bool operator !=(BigInteger left, long right) => default; // 0x000000018B974430-0x000000018B974484
		public static bool operator <(long left, BigInteger right) => default; // 0x000000018B97482C-0x000000018B974884
		public static bool operator <=(long left, BigInteger right) => default; // 0x000000018B9747D4-0x000000018B97482C
		private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl) {
			xd = default;
			xl = default;
			return default;
		} // 0x000000018B971BC4-0x000000018B971C90
		internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) => default; // 0x000000018B971B20-0x000000018B971B74
	}

	internal static class BigIntegerCalculator // TypeDefIndex: 59968
	{
		// Fields
		private static int ReducerThreshold; // 0x00
		private static int SquareThreshold; // 0x04
		private static int AllocationThreshold; // 0x08
		private static int MultiplyThreshold; // 0x0C
	
		// Constructors
		static BigIntegerCalculator() {} // 0x000000018B971548-0x000000018B9715BC
	
		// Methods
		public static uint[] Add(uint[] left, uint right) => default; // 0x000000018B96FF94-0x000000018B970050
		public static uint[] Add(uint[] left, uint[] right) => default; // 0x000000018B970050-0x000000018B970150
		private static unsafe void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) {} // 0x000000018B96FEE8-0x000000018B96FF94
		private static unsafe void AddSelf(uint* left, int leftLength, uint* right, int rightLength) {} // 0x000000018B96FE78-0x000000018B96FEE8
		public static uint[] Subtract(uint[] left, uint right) => default; // 0x000000018B9714A0-0x000000018B971548
		public static uint[] Subtract(uint[] left, uint[] right) => default; // 0x000000018B9712EC-0x000000018B9713FC
		private static unsafe void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) {} // 0x000000018B9713FC-0x000000018B9714A0
		public static int Compare(uint[] left, uint[] right) => default; // 0x000000018B970150-0x000000018B9701CC
		public static uint[] Divide(uint[] left, uint right) => default; // 0x000000018B9705C0-0x000000018B970664
		public static uint[] Divide(uint[] left, uint[] right) => default; // 0x000000018B970664-0x000000018B970764
		private static unsafe void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) {} // 0x000000018B970280-0x000000018B9705C0
		private static unsafe uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength) => default; // 0x000000018B96FE44-0x000000018B96FE78
		private static unsafe uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q) => default; // 0x000000018B9712AC-0x000000018B9712EC
		private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo) => default; // 0x000000018B970244-0x000000018B970280
		private static uint[] CreateCopy(uint[] value) => default; // 0x000000018B9701CC-0x000000018B970244
		private static int LeadingZeros(uint value) => default; // 0x000000018B970764-0x000000018B9707CC
		public static uint[] Square(uint[] value) => default; // 0x000000018B9710F0-0x000000018B9711C8
		private static unsafe void Square(uint* value, int valueLength, uint* bits, int bitsLength) {} // 0x000000018B970E04-0x000000018B9710F0
		public static uint[] Multiply(uint[] left, uint right) => default; // 0x000000018B970D50-0x000000018B970E04
		public static uint[] Multiply(uint[] left, uint[] right) => default; // 0x000000018B9707CC-0x000000018B9708DC
		private static unsafe void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) {} // 0x000000018B9708DC-0x000000018B970D50
		private static unsafe void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength) {} // 0x000000018B9711C8-0x000000018B9712AC
	}

	internal static class BigNumber // TypeDefIndex: 59970
	{
		// Nested types
		private struct BigNumberBuffer // TypeDefIndex: 59969
		{
			// Fields
			public StringBuilder digits; // 0x00
			public int precision; // 0x08
			public int scale; // 0x0C
			public bool sign; // 0x10
	
			// Methods
			public static BigNumberBuffer Create() => default; // 0x000000018B976778-0x000000018B976874
		}
	
		// Methods
		internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) {
			e = default;
			return default;
		} // 0x000000018B97663C-0x000000018B976778
		internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) {
			result = default;
			return default;
		} // 0x000000018B976334-0x000000018B9763F0
		internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) => default; // 0x000000018B9763F0-0x000000018B97651C
		internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info) => default; // 0x000000018B975F98-0x000000018B97611C
		private static bool HexNumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value) => default; // 0x000000018B97611C-0x000000018B976334
		private static bool NumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value) => default; // 0x000000018B97651C-0x000000018B97663C
		internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) {
			digits = default;
			return default;
		} // 0x000000018B974EB4-0x000000018B975314
		private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) {
			charsWritten = default;
			spanSuccess = default;
			return default;
		} // 0x000000018B975314-0x000000018B9753B4
		internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) => default; // 0x000000018B9753B4-0x000000018B975F98
		private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) {
			charsWritten = default;
			spanSuccess = default;
			return default;
		} // 0x000000018B974E40-0x000000018B974EB4
	}

	[Serializable]
	public struct Complex : IEquatable<Complex>, IFormattable // TypeDefIndex: 59971
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
		public Complex(double real, double imaginary) {
			m_real = default;
			m_imaginary = default;
		} // 0x0000000185FB20C0-0x0000000185FB20D0
		static Complex() {
			Zero = default;
			One = default;
			ImaginaryOne = default;
			s_sqrtRescaleThreshold = default;
			s_asinOverflowThreshold = default;
			s_log2 = default;
		} // 0x000000018B976AD0-0x000000018B976BD8
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018B9768B4-0x000000018B976930
		public bool Equals(Complex value) => default; // 0x000000018B976874-0x000000018B9768B4
		public override int GetHashCode() => default; // 0x000000018B976930-0x000000018B97697C
		public override string ToString() => default; // 0x000000018B976A0C-0x000000018B976AD0
		public string ToString(string format, IFormatProvider provider) => default; // 0x000000018B97697C-0x000000018B976A0C
	}

	internal struct DoubleUlong // TypeDefIndex: 59972
	{
		// Fields
		public double dbl; // 0x00
		public ulong uu; // 0x00
	}

	internal static class NumericsHelpers // TypeDefIndex: 59973
	{
		// Methods
		public static void GetDoubleParts(double dbl, out int sign, out int exp, out ulong man, out bool fFinite) {
			sign = default;
			exp = default;
			man = default;
			fFinite = default;
		} // 0x000000018B97AAD4-0x000000018B97AB5C
		public static double GetDoubleFromParts(int sign, int exp, ulong man) => default; // 0x000000018B97AA10-0x000000018B97AAD4
		public static void DangerousMakeTwosComplement(uint[] d) {} // 0x000000018B97A990-0x000000018B97AA10
		public static ulong MakeUlong(uint uHi, uint uLo) => default; // 0x0000000185FBDD90-0x0000000185FBDDA0
		public static uint Abs(int a) => default; // 0x0000000185FD6340-0x0000000185FD6350
		public static uint CombineHash(uint u1, uint u2) => default; // 0x0000000185FD6350-0x0000000185FD6360
		public static int CombineHash(int n1, int n2) => default; // 0x0000000185FD6350-0x0000000185FD6360
		public static int CbitHighZero(uint u) => default; // 0x000000018B970764-0x000000018B9707CC
		public static int CbitHighZero(ulong uu) => default; // 0x000000018B97A960-0x000000018B97A990
	}
}

namespace System.Numerics.Hashing
{
	internal static class HashHelpers // TypeDefIndex: 59974
	{
		// Fields
		public static readonly int RandomSeed; // 0x00
	
		// Constructors
		static HashHelpers() {} // 0x000000018B976E04-0x000000018B976E64
	
		// Methods
		public static int Combine(int h1, int h2) => default; // 0x0000000185FCFBB0-0x0000000185FCFBD0
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IntrinsicAttribute : Attribute // TypeDefIndex: 59979
	{
		// Constructors
		public IntrinsicAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Text
{
	internal struct ValueStringBuilder // TypeDefIndex: 59978
	{
		// Fields
		private char[] _arrayToReturnToPool; // 0x00
		private Span<char> _chars; // 0x08
		private int _pos; // 0x18
	
		// Properties
		public int Length { get => default; } // 0x00000001813AE560-0x00000001813AE570 
	
		// Constructors
		public ValueStringBuilder(Span<char> initialBuffer) : this() {
			_arrayToReturnToPool = default;
			_chars = default;
			_pos = default;
		} // 0x0000000185FCF8C0-0x0000000185FCF8D0
	
		// Methods
		public override string ToString() => default; // 0x000000018B97B664-0x000000018B97B70C
		public bool TryCopyTo(Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x000000018B97B70C-0x000000018B97B7C4
		public void Insert(int index, char value, int count) {} // 0x000000018B97B524-0x000000018B97B664
		public void Append(char c) {} // 0x000000018B97B2B0-0x000000018B97B318
		public void Append(string s) {} // 0x000000018B97B150-0x000000018B97B1EC
		private void AppendSlow(string s) {} // 0x000000018B97AF18-0x000000018B97AFEC
		public void Append(char c, int count) {} // 0x000000018B97B094-0x000000018B97B150
		public unsafe void Append(char* value, int length) {} // 0x000000018B97B1EC-0x000000018B97B2B0
		public Span<char> AppendSpan(int length) => default; // 0x000000018B97AFEC-0x000000018B97B094
		private void GrowAndAppend(char c) {} // 0x000000018B97B398-0x000000018B97B3D0
		private void Grow(int requiredAdditionalCapacity) {} // 0x000000018B97B3D0-0x000000018B97B524
		public void Dispose() {} // 0x000000018B97B318-0x000000018B97B398
	}
}
