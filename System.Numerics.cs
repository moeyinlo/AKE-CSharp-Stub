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

// Image 78: System.Numerics.dll - Assembly: System.Numerics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 58932-58954
[assembly: AssemblyCompany("Mono development team")]
[assembly: AssemblyCopyright("(c) Various Mono authors")]
[assembly: AssemblyDefaultAlias("System.Numerics.dll")]
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyDescription("System.Numerics.dll")]
[assembly: AssemblyFileVersion("4.0.30319.17020")]
[assembly: AssemblyInformationalVersion("4.0.30319.17020")]
[assembly: AssemblyProduct("Mono Common Language Infrastructure")]
[assembly: AssemblyTitle("System.Numerics.dll")]
[assembly: CLSCompliant(true)]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SatelliteContractVersion("4.0.0.0")]

internal static class SR // TypeDefIndex: 58933
{
	// Methods
	internal static string Format(string resourceFormat, object p1) => default; // 0x0000000189854B88-0x0000000189854BE4
}

namespace System.Globalization
{
	internal class FormatProvider // TypeDefIndex: 58952
	{
		// Nested types
		private class Number // TypeDefIndex: 58951
		{
			// Fields
			private static string[] s_posCurrencyFormats; // 0x00
			private static string[] s_negCurrencyFormats; // 0x08
			private static string[] s_posPercentFormats; // 0x10
			private static string[] s_negPercentFormats; // 0x18
			private static string[] s_negNumberFormats; // 0x20
			private static string s_posNumberFormat; // 0x28
	
			// Nested types
			internal struct NumberBuffer // TypeDefIndex: 58950
			{
				// Fields
				public int precision; // 0x00
				public int scale; // 0x04
				public bool sign; // 0x08
				public unsafe char* overrideDigits; // 0x10
	
				// Properties
				public unsafe char* digits { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
			}
	
			// Constructors
			public Number() {} // Dummy constructor
			static Number() {} // 0x0000000189853F48-0x000000018985460C
	
			// Methods
			private static bool IsWhite(char ch) => default; // 0x00000001898523C8-0x00000001898523E4
			private static unsafe char* MatchChars(char* p, char* pEnd, string str) => default; // 0x0000000189852430-0x0000000189852498
			private static unsafe char* MatchChars(char* p, char* pEnd, char* str) => default; // 0x00000001898523E4-0x0000000189852430
			private static unsafe bool ParseNumber(ref char* str, char* strEnd, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) => default; // 0x00000001898535A0-0x0000000189853CEC
			private static bool TrailingZeros(ReadOnlySpan<char> s, int index) => default; // 0x0000000189853DB0-0x0000000189853E14
			internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) => default; // 0x0000000189853E14-0x0000000189853F48
			internal static unsafe void Int32ToDecChars(char* buffer, ref int index, uint value, int digits) {} // 0x0000000189852360-0x00000001898523C8
			internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) {
				digits = default;
				return default;
			} // 0x000000018985343C-0x00000001898535A0
			internal static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) {} // 0x0000000189853058-0x000000018985343C
			private static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) {} // 0x0000000189851740-0x00000001898518E4
			private static unsafe int wcslen(char* s) => default; // 0x000000018985460C-0x000000018985462C
			private static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) {} // 0x00000001898519E8-0x0000000189851DC0
			private static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) {} // 0x0000000189851F1C-0x00000001898520A0
			private static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) {} // 0x000000018985224C-0x0000000189852360
			private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) {} // 0x00000001898518E4-0x00000001898519E8
			private static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) {} // 0x0000000189851DC0-0x0000000189851F1C
			private static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) {} // 0x00000001898520A0-0x000000018985224C
			private static void RoundNumber(ref NumberBuffer number, int pos) {} // 0x0000000189853CEC-0x0000000189853DB0
			private static int FindSection(ReadOnlySpan<char> format, int section) => default; // 0x0000000189851634-0x0000000189851740
			internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info) {} // 0x0000000189852498-0x0000000189853058
		}
	
		// Constructors
		public FormatProvider() {} // Dummy constructor
	
		// Methods
		internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) {} // 0x00000001898508A4-0x00000001898509D8
		internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) {
			precision = default;
			scale = default;
			sign = default;
			return default;
		} // 0x00000001898509D8-0x0000000189850AD0
	}
}

namespace System.Numerics
{
	public struct Matrix3x2 : IEquatable<Matrix3x2> // TypeDefIndex: 58934
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
		} // 0x0000000183D75600-0x0000000183D75630
		static Matrix3x2() {
			_identity = default;
		} // 0x0000000189850E74-0x0000000189850EC0
	
		// Methods
		public bool Equals(Matrix3x2 other) => default; // 0x0000000189850BB4-0x0000000189850C34
		public override bool Equals(object obj) => default; // 0x0000000189850B30-0x0000000189850BB4
		public override string ToString() => default; // 0x0000000189850CC0-0x0000000189850E74
		public override int GetHashCode() => default; // 0x0000000189850C34-0x0000000189850CC0
	}

	public struct Matrix4x4 : IEquatable<Matrix4x4> // TypeDefIndex: 58935
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
		} // 0x0000000183D75630-0x0000000183D756E0
		static Matrix4x4() {
			_identity = default;
		} // 0x0000000189851544-0x0000000189851634
	
		// Methods
		public bool Equals(Matrix4x4 other) => default; // 0x0000000189850EC0-0x0000000189850FE4
		public override bool Equals(object obj) => default; // 0x0000000189850FE4-0x0000000189851078
		public override string ToString() => default; // 0x00000001898511CC-0x0000000189851544
		public override int GetHashCode() => default; // 0x0000000189851078-0x00000001898511CC
	}

	public struct Plane : IEquatable<Plane> // TypeDefIndex: 58936
	{
		// Fields
		public Vector3 Normal; // 0x00
		public float D; // 0x0C
	
		// Methods
		public bool Equals(Plane other) => default; // 0x0000000182743F00-0x0000000182743F40
		public override bool Equals(object obj) => default; // 0x0000000189854828-0x0000000189854894
		public override string ToString() => default; // 0x00000001898548C4-0x000000018985495C
		public override int GetHashCode() => default; // 0x0000000189854894-0x00000001898548C4
	}

	public struct Quaternion : IEquatable<Quaternion> // TypeDefIndex: 58937
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
		public float Z; // 0x08
		public float W; // 0x0C
	
		// Methods
		public bool Equals(Quaternion other) => default; // 0x00000001822CDA10-0x00000001822CDA50
		public override bool Equals(object obj) => default; // 0x000000018985495C-0x00000001898549CC
		public override string ToString() => default; // 0x0000000189854A2C-0x0000000189854B88
		public override int GetHashCode() => default; // 0x00000001898549CC-0x0000000189854A2C
	}

	public struct Vector2 : IEquatable<Vector2>, IFormattable // TypeDefIndex: 58938
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
	
		// Methods
		public override int GetHashCode() => default; // 0x00000001898554F4-0x0000000189855560
		public override bool Equals(object obj) => default; // 0x0000000189855490-0x00000001898554F4
		public override string ToString() => default; // 0x0000000189855560-0x00000001898555C0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x00000001898555C0-0x00000001898556E4
		[Intrinsic]
		public bool Equals(Vector2 other) => default; // 0x000000018950B3E8-0x000000018950B410
	}

	public struct Vector3 : IEquatable<Vector3>, IFormattable // TypeDefIndex: 58939
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
		public float Z; // 0x08
	
		// Methods
		public override int GetHashCode() => default; // 0x000000018985575C-0x00000001898557F4
		public override bool Equals(object obj) => default; // 0x00000001898556E4-0x000000018985575C
		public override string ToString() => default; // 0x00000001898559E4-0x0000000189855A44
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x00000001898557F4-0x00000001898559E4
		[Intrinsic]
		public bool Equals(Vector3 other) => default; // 0x0000000182799940-0x0000000182799970
	}

	public struct Vector4 : IEquatable<Vector4>, IFormattable // TypeDefIndex: 58940
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
		public float Z; // 0x08
		public float W; // 0x0C
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000189855AB4-0x0000000189855B6C
		public override bool Equals(object obj) => default; // 0x0000000189855A44-0x0000000189855AB4
		public override string ToString() => default; // 0x0000000189855D0C-0x00000001898560B8
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189855B6C-0x0000000189855D0C
		[Intrinsic]
		public bool Equals(Vector4 other) => default; // 0x00000001822CDA10-0x00000001822CDA50
	}

	[Serializable]
	[IsReadOnly]
	public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 58942
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
		public static BigInteger Zero { get => default; } // 0x000000018984D500-0x000000018984D55C 
		public static BigInteger MinusOne { get => default; } // 0x000000018984D4A4-0x000000018984D500 
		public bool IsZero { get => default; } // 0x00000001822FBAA0-0x00000001822FBAB0 
	
		// Nested types
		private enum GetBytesMode // TypeDefIndex: 58941
		{
			AllocateArray = 0,
			Count = 1,
			Span = 2
		}
	
		// Constructors
		public BigInteger(int value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018984D428-0x000000018984D4A4
		[CLSCompliant(false)]
		public BigInteger(uint value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018984CE04-0x000000018984CEA4
		public BigInteger(long value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018984CCA8-0x000000018984CE04
		[CLSCompliant(false)]
		public BigInteger(ulong value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018984C6A4-0x000000018984C798
		public BigInteger(float value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018984CC50-0x000000018984CCA8
		public BigInteger(double value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018984C798-0x000000018984CA74
		public BigInteger(decimal value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018984CA74-0x000000018984CC50
		[CLSCompliant(false)]
		public BigInteger(byte[] value) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018984C5C0-0x000000018984C6A4
		public BigInteger(ReadOnlySpan<byte> value, bool isUnsigned = false /* Metadata: 0x01FDCBFC */, bool isBigEndian = false /* Metadata: 0x01FDCBFD */) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018984CEA4-0x000000018984D428
		internal BigInteger(int n, uint[] rgu) : this() {
			_sign = default;
			_bits = default;
		} // 0x00000001871AED58-0x00000001871AED68
		internal BigInteger(uint[] value, bool negative) : this() {
			_sign = default;
			_bits = default;
		} // 0x000000018984C414-0x000000018984C5C0
		static BigInteger() {
			s_bnMinInt = default;
			s_bnOneInt = default;
			s_bnZeroInt = default;
			s_bnMinusOneInt = default;
			s_success = default;
		} // 0x000000018984C25C-0x000000018984C414
	
		// Methods
		public static BigInteger Parse(string value, IFormatProvider provider) => default; // 0x000000018984B95C-0x000000018984B9E0
		public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) => default; // 0x000000018984B9E0-0x000000018984BA38
		public override int GetHashCode() => default; // 0x000000018984B840-0x000000018984B890
		public override bool Equals(object obj) => default; // 0x000000018984B770-0x000000018984B7EC
		public bool Equals(long other) => default; // 0x000000018984B708-0x000000018984B770
		public bool Equals(BigInteger other) => default; // 0x000000018984B668-0x000000018984B708
		public int CompareTo(long other) => default; // 0x000000018984B4F0-0x000000018984B580
		public int CompareTo(BigInteger other) => default; // 0x000000018984B3BC-0x000000018984B4F0
		public int CompareTo(object obj) => default; // 0x000000018984B580-0x000000018984B668
		public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false /* Metadata: 0x01FDCBFE */, bool isBigEndian = false /* Metadata: 0x01FDCBFF */) {
			bytesWritten = default;
			return default;
		} // 0x000000018984C11C-0x000000018984C1C0
		internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false /* Metadata: 0x01FDCC00 */, bool isBigEndian = false /* Metadata: 0x01FDCC01 */) {
			bytesWritten = default;
			return default;
		} // 0x000000018984C1C0-0x000000018984C25C
		private byte[] TryGetBytes(GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten) => default; // 0x000000018984BC58-0x000000018984C11C
		public override string ToString() => default; // 0x000000018984BBA4-0x000000018984BBDC
		public string ToString(IFormatProvider provider) => default; // 0x000000018984BBDC-0x000000018984BC18
		public string ToString(string format, IFormatProvider provider) => default; // 0x000000018984BC18-0x000000018984BC58
		private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) => default; // 0x000000018984B288-0x000000018984B3BC
		public static BigInteger operator -(BigInteger left, BigInteger right) => default; // 0x000000018984EA28-0x000000018984EADC
		private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) => default; // 0x000000018984BA38-0x000000018984BBA4
		public static implicit operator BigInteger(byte value) => default; // 0x000000018984E094-0x000000018984E0B8
		[CLSCompliant(false)]
		public static implicit operator BigInteger(sbyte value) => default; // 0x000000018984E00C-0x000000018984E030
		public static implicit operator BigInteger(short value) => default; // 0x000000018984E070-0x000000018984E094
		[CLSCompliant(false)]
		public static implicit operator BigInteger(ushort value) => default; // 0x000000018984E0D8-0x000000018984E0FC
		public static implicit operator BigInteger(int value) => default; // 0x000000018984DFEC-0x000000018984E00C
		[CLSCompliant(false)]
		public static implicit operator BigInteger(uint value) => default; // 0x000000018984E050-0x000000018984E070
		public static implicit operator BigInteger(long value) => default; // 0x000000018984E0B8-0x000000018984E0D8
		[CLSCompliant(false)]
		public static implicit operator BigInteger(ulong value) => default; // 0x000000018984E030-0x000000018984E050
		public static explicit operator byte(BigInteger value) => default; // 0x000000018984DE4C-0x000000018984DEC4
		[CLSCompliant(false)]
		public static explicit operator sbyte(BigInteger value) => default; // 0x000000018984DAA8-0x000000018984DB20
		public static explicit operator short(BigInteger value) => default; // 0x000000018984D7B8-0x000000018984D830
		[CLSCompliant(false)]
		public static explicit operator ushort(BigInteger value) => default; // 0x000000018984DDD4-0x000000018984DE4C
		public static explicit operator int(BigInteger value) => default; // 0x000000018984D974-0x000000018984DAA8
		[CLSCompliant(false)]
		public static explicit operator uint(BigInteger value) => default; // 0x000000018984DB70-0x000000018984DC18
		public static explicit operator long(BigInteger value) => default; // 0x000000018984DEC4-0x000000018984DFEC
		[CLSCompliant(false)]
		public static explicit operator ulong(BigInteger value) => default; // 0x000000018984DD10-0x000000018984DDD4
		public static explicit operator float(BigInteger value) => default; // 0x000000018984DB20-0x000000018984DB70
		public static explicit operator double(BigInteger value) => default; // 0x000000018984DC18-0x000000018984DD10
		public static explicit operator decimal(BigInteger value) => default; // 0x000000018984D830-0x000000018984D974
		public static BigInteger operator <<(BigInteger value, int shift) => default; // 0x000000018984E1B0-0x000000018984E3E4
		public static BigInteger operator >>(BigInteger value, int shift) => default; // 0x000000018984E720-0x000000018984EA28
		public static BigInteger operator -(BigInteger value) => default; // 0x000000018984EADC-0x000000018984EB0C
		public static BigInteger operator +(BigInteger left, BigInteger right) => default; // 0x000000018984D55C-0x000000018984D610
		public static BigInteger operator *(BigInteger left, BigInteger right) => default; // 0x000000018984E5A4-0x000000018984E720
		public static BigInteger operator /(BigInteger dividend, BigInteger divisor) => default; // 0x000000018984D610-0x000000018984D75C
		public static bool operator <=(BigInteger left, BigInteger right) => default; // 0x000000018984E3E4-0x000000018984E448
		public static bool operator !=(BigInteger left, BigInteger right) => default; // 0x000000018984E150-0x000000018984E1B0
		public static bool operator <(BigInteger left, long right) => default; // 0x000000018984E550-0x000000018984E5A4
		public static bool operator <=(BigInteger left, long right) => default; // 0x000000018984E448-0x000000018984E4A0
		public static bool operator ==(BigInteger left, long right) => default; // 0x000000018984D75C-0x000000018984D7B8
		public static bool operator !=(BigInteger left, long right) => default; // 0x000000018984E0FC-0x000000018984E150
		public static bool operator <(long left, BigInteger right) => default; // 0x000000018984E4F8-0x000000018984E550
		public static bool operator <=(long left, BigInteger right) => default; // 0x000000018984E4A0-0x000000018984E4F8
		private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl) {
			xd = default;
			xl = default;
			return default;
		} // 0x000000018984B890-0x000000018984B95C
		internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) => default; // 0x000000018984B7EC-0x000000018984B840
	}

	internal static class BigIntegerCalculator // TypeDefIndex: 58943
	{
		// Fields
		private static int ReducerThreshold; // 0x00
		private static int SquareThreshold; // 0x04
		private static int AllocationThreshold; // 0x08
		private static int MultiplyThreshold; // 0x0C
	
		// Constructors
		static BigIntegerCalculator() {} // 0x000000018984B214-0x000000018984B288
	
		// Methods
		public static uint[] Add(uint[] left, uint right) => default; // 0x0000000189849C60-0x0000000189849D1C
		public static uint[] Add(uint[] left, uint[] right) => default; // 0x0000000189849D1C-0x0000000189849E1C
		private static unsafe void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) {} // 0x0000000189849BB4-0x0000000189849C60
		private static unsafe void AddSelf(uint* left, int leftLength, uint* right, int rightLength) {} // 0x0000000189849B44-0x0000000189849BB4
		public static uint[] Subtract(uint[] left, uint right) => default; // 0x000000018984B16C-0x000000018984B214
		public static uint[] Subtract(uint[] left, uint[] right) => default; // 0x000000018984AFB8-0x000000018984B0C8
		private static unsafe void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) {} // 0x000000018984B0C8-0x000000018984B16C
		public static int Compare(uint[] left, uint[] right) => default; // 0x0000000189849E1C-0x0000000189849E98
		public static uint[] Divide(uint[] left, uint right) => default; // 0x000000018984A28C-0x000000018984A330
		public static uint[] Divide(uint[] left, uint[] right) => default; // 0x000000018984A330-0x000000018984A430
		private static unsafe void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) {} // 0x0000000189849F4C-0x000000018984A28C
		private static unsafe uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength) => default; // 0x0000000189849B10-0x0000000189849B44
		private static unsafe uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q) => default; // 0x000000018984AF78-0x000000018984AFB8
		private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo) => default; // 0x0000000189849F10-0x0000000189849F4C
		private static uint[] CreateCopy(uint[] value) => default; // 0x0000000189849E98-0x0000000189849F10
		private static int LeadingZeros(uint value) => default; // 0x000000018984A430-0x000000018984A498
		public static uint[] Square(uint[] value) => default; // 0x000000018984ADBC-0x000000018984AE94
		private static unsafe void Square(uint* value, int valueLength, uint* bits, int bitsLength) {} // 0x000000018984AAD0-0x000000018984ADBC
		public static uint[] Multiply(uint[] left, uint right) => default; // 0x000000018984AA1C-0x000000018984AAD0
		public static uint[] Multiply(uint[] left, uint[] right) => default; // 0x000000018984A498-0x000000018984A5A8
		private static unsafe void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) {} // 0x000000018984A5A8-0x000000018984AA1C
		private static unsafe void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength) {} // 0x000000018984AE94-0x000000018984AF78
	}

	internal static class BigNumber // TypeDefIndex: 58945
	{
		// Nested types
		private struct BigNumberBuffer // TypeDefIndex: 58944
		{
			// Fields
			public StringBuilder digits; // 0x00
			public int precision; // 0x08
			public int scale; // 0x0C
			public bool sign; // 0x10
	
			// Methods
			public static BigNumberBuffer Create() => default; // 0x000000018984EB0C-0x000000018984EB80
		}
	
		// Methods
		internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) {
			e = default;
			return default;
		} // 0x0000000189850444-0x0000000189850540
		internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) {
			result = default;
			return default;
		} // 0x0000000189850308-0x0000000189850444
		internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) => default; // 0x0000000189850000-0x00000001898500BC
		internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info) => default; // 0x00000001898500BC-0x00000001898501E8
		private static bool HexNumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value) => default; // 0x000000018984FC64-0x000000018984FDE8
		private static bool NumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value) => default; // 0x000000018984FDE8-0x0000000189850000
		internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) {
			digits = default;
			return default;
		} // 0x00000001898501E8-0x0000000189850308
		private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) {
			charsWritten = default;
			spanSuccess = default;
			return default;
		} // 0x000000018984EB80-0x000000018984EFE0
		internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) => default; // 0x000000018984EFE0-0x000000018984F080
		private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) {
			charsWritten = default;
			spanSuccess = default;
			return default;
		} // 0x000000018984F080-0x000000018984FC64
	}

	[Serializable]
	public struct Complex : IEquatable<Complex>, IFormattable // TypeDefIndex: 58946
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
		} // 0x0000000183D50BD0-0x0000000183D50BE0
		static Complex() {
			Zero = default;
			One = default;
			ImaginaryOne = default;
			s_sqrtRescaleThreshold = default;
			s_asinOverflowThreshold = default;
			s_log2 = default;
		} // 0x000000018985079C-0x00000001898508A4
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189850580-0x00000001898505FC
		public bool Equals(Complex value) => default; // 0x0000000189850540-0x0000000189850580
		public override int GetHashCode() => default; // 0x00000001898505FC-0x0000000189850648
		public override string ToString() => default; // 0x00000001898506D8-0x000000018985079C
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000189850648-0x00000001898506D8
	}

	internal struct DoubleUlong // TypeDefIndex: 58947
	{
		// Fields
		public double dbl; // 0x00
		public ulong uu; // 0x00
	}

	internal static class NumericsHelpers // TypeDefIndex: 58948
	{
		// Methods
		public static void GetDoubleParts(double dbl, out int sign, out int exp, out ulong man, out bool fFinite) {
			sign = default;
			exp = default;
			man = default;
			fFinite = default;
		} // 0x00000001898547A0-0x0000000189854828
		public static double GetDoubleFromParts(int sign, int exp, ulong man) => default; // 0x00000001898546DC-0x00000001898547A0
		public static void DangerousMakeTwosComplement(uint[] d) {} // 0x000000018985465C-0x00000001898546DC
		public static ulong MakeUlong(uint uHi, uint uLo) => default; // 0x0000000183D5C6C0-0x0000000183D5C6D0
		public static uint Abs(int a) => default; // 0x0000000183D756E0-0x0000000183D756F0
		public static uint CombineHash(uint u1, uint u2) => default; // 0x0000000183D756F0-0x0000000183D75700
		public static int CombineHash(int n1, int n2) => default; // 0x0000000183D756F0-0x0000000183D75700
		public static int CbitHighZero(uint u) => default; // 0x000000018984A430-0x000000018984A498
		public static int CbitHighZero(ulong uu) => default; // 0x000000018985462C-0x000000018985465C
	}
}

namespace System.Numerics.Hashing
{
	internal static class HashHelpers // TypeDefIndex: 58949
	{
		// Fields
		public static readonly int RandomSeed; // 0x00
	
		// Constructors
		static HashHelpers() {} // 0x0000000189850AD0-0x0000000189850B30
	
		// Methods
		public static int Combine(int h1, int h2) => default; // 0x0000000183D6EF70-0x0000000183D6EF90
	}
}

namespace System.Runtime.CompilerServices
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field, Inherited = false)]
	internal sealed class IntrinsicAttribute : Attribute // TypeDefIndex: 58954
	{
		// Constructors
		public IntrinsicAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace System.Text
{
	[DefaultMember("Item")]
	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal struct ValueStringBuilder // TypeDefIndex: 58953
	{
		// Fields
		private char[] _arrayToReturnToPool; // 0x00
		private Span<char> _chars; // 0x08
		private int _pos; // 0x18
	
		// Properties
		public int Length { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
	
		// Constructors
		public ValueStringBuilder(Span<char> initialBuffer) : this() {
			_arrayToReturnToPool = default;
			_chars = default;
			_pos = default;
		} // 0x0000000183D6EC80-0x0000000183D6EC90
	
		// Methods
		public override string ToString() => default; // 0x0000000189855330-0x00000001898553D8
		public bool TryCopyTo(Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x00000001898553D8-0x0000000189855490
		public void Insert(int index, char value, int count) {} // 0x00000001898551F0-0x0000000189855330
		public void Append(char c) {} // 0x0000000189854F7C-0x0000000189854FE4
		public void Append(string s) {} // 0x0000000189854E1C-0x0000000189854EB8
		private void AppendSlow(string s) {} // 0x0000000189854BE4-0x0000000189854CB8
		public void Append(char c, int count) {} // 0x0000000189854D60-0x0000000189854E1C
		public unsafe void Append(char* value, int length) {} // 0x0000000189854EB8-0x0000000189854F7C
		public Span<char> AppendSpan(int length) => default; // 0x0000000189854CB8-0x0000000189854D60
		private void GrowAndAppend(char c) {} // 0x0000000189855064-0x000000018985509C
		private void Grow(int requiredAdditionalCapacity) {} // 0x000000018985509C-0x00000001898551F0
		public void Dispose() {} // 0x0000000189854FE4-0x0000000189855064
	}
}
