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

// Image 81: System.Numerics.dll - Assembly: System.Numerics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 62572-62594
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

internal static class SR // TypeDefIndex: 62573
{
	// Methods
	internal static string Format(string resourceFormat, object p1); // 0x000000018AE33D18-0x000000018AE33D74
}

namespace System.Globalization
{
	internal class FormatProvider // TypeDefIndex: 62592
	{
		// Nested types
		private class Number // TypeDefIndex: 62591
		{
			// Fields
			private static string[] s_posCurrencyFormats; // 0x00
			private static string[] s_negCurrencyFormats; // 0x08
			private static string[] s_posPercentFormats; // 0x10
			private static string[] s_negPercentFormats; // 0x18
			private static string[] s_negNumberFormats; // 0x20
			private static string s_posNumberFormat; // 0x28
	
			// Nested types
			internal struct NumberBuffer // TypeDefIndex: 62590
			{
				// Fields
				public int precision; // 0x00
				public int scale; // 0x04
				public bool sign; // 0x08
				public unsafe char* overrideDigits; // 0x10
	
				// Properties
				public unsafe char* digits { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
			}
	
			// Constructors
			static Number(); // 0x000000018AE330D8-0x000000018AE3379C
	
			// Methods
			private static bool IsWhite(char ch); // 0x000000018AE31558-0x000000018AE31574
			private static unsafe char* MatchChars(char* p, char* pEnd, string str); // 0x000000018AE315C0-0x000000018AE31628
			private static unsafe char* MatchChars(char* p, char* pEnd, char* str); // 0x000000018AE31574-0x000000018AE315C0
			private static unsafe bool ParseNumber(ref char* str, char* strEnd, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal); // 0x000000018AE32730-0x000000018AE32E7C
			private static bool TrailingZeros(ReadOnlySpan<char> s, int index); // 0x000000018AE32F40-0x000000018AE32FA4
			internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal); // 0x000000018AE32FA4-0x000000018AE330D8
			internal static unsafe void Int32ToDecChars(char* buffer, ref int index, uint value, int digits); // 0x000000018AE314F0-0x000000018AE31558
			internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits); // 0x000000018AE325CC-0x000000018AE32730
			internal static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal); // 0x000000018AE321E8-0x000000018AE325CC
			private static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info); // 0x000000018AE308D0-0x000000018AE30A74
			private static unsafe int wcslen(char* s); // 0x000000018AE3379C-0x000000018AE337BC
			private static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup); // 0x000000018AE30B78-0x000000018AE30F50
			private static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info); // 0x000000018AE310AC-0x000000018AE31230
			private static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar); // 0x000000018AE313DC-0x000000018AE314F0
			private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign); // 0x000000018AE30A74-0x000000018AE30B78
			private static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific); // 0x000000018AE30F50-0x000000018AE310AC
			private static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info); // 0x000000018AE31230-0x000000018AE313DC
			private static void RoundNumber(ref NumberBuffer number, int pos); // 0x000000018AE32E7C-0x000000018AE32F40
			private static int FindSection(ReadOnlySpan<char> format, int section); // 0x000000018AE307C4-0x000000018AE308D0
			internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info); // 0x000000018AE31628-0x000000018AE321E8
		}
	
		// Methods
		internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex); // 0x000000018AE2FA34-0x000000018AE2FB68
		internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign); // 0x000000018AE2FB68-0x000000018AE2FC60
	}
}

namespace System.Numerics
{
	public struct Matrix3x2 : IEquatable<Matrix3x2> // TypeDefIndex: 62574
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
		public Matrix3x2(float m11, float m12, float m21, float m22, float m31, float m32); // 0x0000000184DAA360-0x0000000184DAA390
		static Matrix3x2(); // 0x000000018AE30004-0x000000018AE30050
	
		// Methods
		public bool Equals(Matrix3x2 other); // 0x000000018AE2FD44-0x000000018AE2FDC4
		public override bool Equals(object obj); // 0x000000018AE2FCC0-0x000000018AE2FD44
		public override string ToString(); // 0x000000018AE2FE50-0x000000018AE30004
		public override int GetHashCode(); // 0x000000018AE2FDC4-0x000000018AE2FE50
	}

	public struct Matrix4x4 : IEquatable<Matrix4x4> // TypeDefIndex: 62575
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
		public Matrix4x4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44); // 0x0000000184DAA390-0x0000000184DAA440
		static Matrix4x4(); // 0x000000018AE306D4-0x000000018AE307C4
	
		// Methods
		public bool Equals(Matrix4x4 other); // 0x000000018AE30050-0x000000018AE30174
		public override bool Equals(object obj); // 0x000000018AE30174-0x000000018AE30208
		public override string ToString(); // 0x000000018AE3035C-0x000000018AE306D4
		public override int GetHashCode(); // 0x000000018AE30208-0x000000018AE3035C
	}

	public struct Plane : IEquatable<Plane> // TypeDefIndex: 62576
	{
		// Fields
		public Vector3 Normal; // 0x00
		public float D; // 0x0C
	
		// Methods
		public bool Equals(Plane other); // 0x00000001831C3A00-0x00000001831C3A40
		public override bool Equals(object obj); // 0x000000018AE339B8-0x000000018AE33A24
		public override string ToString(); // 0x000000018AE33A54-0x000000018AE33AEC
		public override int GetHashCode(); // 0x000000018AE33A24-0x000000018AE33A54
	}

	public struct Quaternion : IEquatable<Quaternion> // TypeDefIndex: 62577
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
		public float Z; // 0x08
		public float W; // 0x0C
	
		// Methods
		public bool Equals(Quaternion other); // 0x000000018415FC30-0x000000018415FC70
		public override bool Equals(object obj); // 0x000000018AE33AEC-0x000000018AE33B5C
		public override string ToString(); // 0x000000018AE33BBC-0x000000018AE33D18
		public override int GetHashCode(); // 0x000000018AE33B5C-0x000000018AE33BBC
	}

	public struct Vector2 : IEquatable<Vector2>, IFormattable // TypeDefIndex: 62578
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
	
		// Methods
		public override int GetHashCode(); // 0x000000018AE34684-0x000000018AE346F0
		public override bool Equals(object obj); // 0x000000018AE34620-0x000000018AE34684
		public override string ToString(); // 0x000000018AE346F0-0x000000018AE34750
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018AE34750-0x000000018AE34874
		[Intrinsic]
		public bool Equals(Vector2 other); // 0x000000018AAEC490-0x000000018AAEC4B8
	}

	public struct Vector3 : IEquatable<Vector3>, IFormattable // TypeDefIndex: 62579
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
		public float Z; // 0x08
	
		// Methods
		public override int GetHashCode(); // 0x000000018AE348EC-0x000000018AE34984
		public override bool Equals(object obj); // 0x000000018AE34874-0x000000018AE348EC
		public override string ToString(); // 0x000000018AE34B70-0x000000018AE34BD0
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018AE34984-0x000000018AE34B70
		[Intrinsic]
		public bool Equals(Vector3 other); // 0x00000001830F9620-0x00000001830F9650
	}

	public struct Vector4 : IEquatable<Vector4>, IFormattable // TypeDefIndex: 62580
	{
		// Fields
		public float X; // 0x00
		public float Y; // 0x04
		public float Z; // 0x08
		public float W; // 0x0C
	
		// Methods
		public override int GetHashCode(); // 0x000000018AE34C40-0x000000018AE34CF8
		public override bool Equals(object obj); // 0x000000018AE34BD0-0x000000018AE34C40
		public override string ToString(); // 0x000000018AE34E98-0x000000018AE35184
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018AE34CF8-0x000000018AE34E98
		[Intrinsic]
		public bool Equals(Vector4 other); // 0x000000018415FC30-0x000000018415FC70
	}

	[Serializable]
	[IsReadOnly]
	public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 62582
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
		public static BigInteger Zero { get; } // 0x000000018AE2C744-0x000000018AE2C7A0 
		public static BigInteger MinusOne { get; } // 0x000000018AE2C6E8-0x000000018AE2C744 
		public bool IsZero { get; } // 0x000000018426F6A0-0x000000018426F6B0 
	
		// Nested types
		private enum GetBytesMode // TypeDefIndex: 62581
		{
			AllocateArray = 0,
			Count = 1,
			Span = 2
		}
	
		// Constructors
		public BigInteger(int value); // 0x000000018AE2C694-0x000000018AE2C6E8
		[CLSCompliant(false)]
		public BigInteger(uint value); // 0x000000018AE2C070-0x000000018AE2C110
		public BigInteger(long value); // 0x000000018AE2BF40-0x000000018AE2C070
		[CLSCompliant(false)]
		public BigInteger(ulong value); // 0x000000018AE2B93C-0x000000018AE2BA30
		public BigInteger(float value); // 0x000000018AE2BEE8-0x000000018AE2BF40
		public BigInteger(double value); // 0x000000018AE2BA30-0x000000018AE2BD0C
		public BigInteger(decimal value); // 0x000000018AE2BD0C-0x000000018AE2BEE8
		[CLSCompliant(false)]
		public BigInteger(byte[] value); // 0x000000018AE2B858-0x000000018AE2B93C
		public BigInteger(ReadOnlySpan<byte> value, bool isUnsigned = false /* Metadata: 0x02352030 */, bool isBigEndian = false /* Metadata: 0x02352031 */); // 0x000000018AE2C110-0x000000018AE2C694
		internal BigInteger(int n, uint[] rgu); // 0x0000000186B17430-0x0000000186B17440
		internal BigInteger(uint[] value, bool negative); // 0x000000018AE2B6E0-0x000000018AE2B858
		static BigInteger(); // 0x000000018AE2B528-0x000000018AE2B6E0
	
		// Methods
		public static BigInteger Parse(string value, IFormatProvider provider); // 0x000000018AE2AC28-0x000000018AE2ACAC
		public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider); // 0x000000018AE2ACAC-0x000000018AE2AD04
		public override int GetHashCode(); // 0x000000018AE2AB28-0x000000018AE2AB78
		public override bool Equals(object obj); // 0x000000018AE2AA58-0x000000018AE2AAD4
		public bool Equals(long other); // 0x000000018AE2A9F0-0x000000018AE2AA58
		public bool Equals(BigInteger other); // 0x000000018AE2A950-0x000000018AE2A9F0
		public int CompareTo(long other); // 0x000000018AE2A7D8-0x000000018AE2A868
		public int CompareTo(BigInteger other); // 0x000000018AE2A6A4-0x000000018AE2A7D8
		public int CompareTo(object obj); // 0x000000018AE2A868-0x000000018AE2A950
		public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false /* Metadata: 0x02352032 */, bool isBigEndian = false /* Metadata: 0x02352033 */); // 0x000000018AE2B3E8-0x000000018AE2B48C
		internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false /* Metadata: 0x02352034 */, bool isBigEndian = false /* Metadata: 0x02352035 */); // 0x000000018AE2B48C-0x000000018AE2B528
		private byte[] TryGetBytes(GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten); // 0x000000018AE2AF24-0x000000018AE2B3E8
		public override string ToString(); // 0x000000018AE2AE70-0x000000018AE2AEA8
		public string ToString(IFormatProvider provider); // 0x000000018AE2AEA8-0x000000018AE2AEE4
		public string ToString(string format, IFormatProvider provider); // 0x000000018AE2AEE4-0x000000018AE2AF24
		private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign); // 0x000000018AE2A594-0x000000018AE2A6A4
		public static BigInteger operator -(BigInteger left, BigInteger right); // 0x000000018AE2DC48-0x000000018AE2DCFC
		private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign); // 0x000000018AE2AD04-0x000000018AE2AE70
		public static implicit operator BigInteger(byte value); // 0x000000018AE2D2D8-0x000000018AE2D2FC
		[CLSCompliant(false)]
		public static implicit operator BigInteger(sbyte value); // 0x000000018AE2D250-0x000000018AE2D274
		public static implicit operator BigInteger(short value); // 0x000000018AE2D2B4-0x000000018AE2D2D8
		[CLSCompliant(false)]
		public static implicit operator BigInteger(ushort value); // 0x000000018AE2D31C-0x000000018AE2D340
		public static implicit operator BigInteger(int value); // 0x000000018AE2D230-0x000000018AE2D250
		[CLSCompliant(false)]
		public static implicit operator BigInteger(uint value); // 0x000000018AE2D294-0x000000018AE2D2B4
		public static implicit operator BigInteger(long value); // 0x000000018AE2D2FC-0x000000018AE2D31C
		[CLSCompliant(false)]
		public static implicit operator BigInteger(ulong value); // 0x000000018AE2D274-0x000000018AE2D294
		public static explicit operator byte(BigInteger value); // 0x000000018AE2D090-0x000000018AE2D108
		[CLSCompliant(false)]
		public static explicit operator sbyte(BigInteger value); // 0x000000018AE2CCEC-0x000000018AE2CD64
		public static explicit operator short(BigInteger value); // 0x000000018AE2C9EC-0x000000018AE2CA64
		[CLSCompliant(false)]
		public static explicit operator ushort(BigInteger value); // 0x000000018AE2D018-0x000000018AE2D090
		public static explicit operator int(BigInteger value); // 0x000000018AE2CBB8-0x000000018AE2CCEC
		[CLSCompliant(false)]
		public static explicit operator uint(BigInteger value); // 0x000000018AE2CDB4-0x000000018AE2CE5C
		public static explicit operator long(BigInteger value); // 0x000000018AE2D108-0x000000018AE2D230
		[CLSCompliant(false)]
		public static explicit operator ulong(BigInteger value); // 0x000000018AE2CF54-0x000000018AE2D018
		public static explicit operator float(BigInteger value); // 0x000000018AE2CD64-0x000000018AE2CDB4
		public static explicit operator double(BigInteger value); // 0x000000018AE2CE5C-0x000000018AE2CF54
		public static explicit operator decimal(BigInteger value); // 0x000000018AE2CA64-0x000000018AE2CBB8
		public static BigInteger operator <<(BigInteger value, int shift); // 0x000000018AE2D3F4-0x000000018AE2D604
		public static BigInteger operator >>(BigInteger value, int shift); // 0x000000018AE2D940-0x000000018AE2DC48
		public static BigInteger operator -(BigInteger value); // 0x000000018AE2DCFC-0x000000018AE2DD2C
		public static BigInteger operator +(BigInteger left, BigInteger right); // 0x000000018AE2C7A0-0x000000018AE2C844
		public static BigInteger operator *(BigInteger left, BigInteger right); // 0x000000018AE2D7C4-0x000000018AE2D940
		public static BigInteger operator /(BigInteger dividend, BigInteger divisor); // 0x000000018AE2C844-0x000000018AE2C990
		public static bool operator <=(BigInteger left, BigInteger right); // 0x000000018AE2D604-0x000000018AE2D668
		public static bool operator !=(BigInteger left, BigInteger right); // 0x000000018AE2D394-0x000000018AE2D3F4
		public static bool operator <(BigInteger left, long right); // 0x000000018AE2D770-0x000000018AE2D7C4
		public static bool operator <=(BigInteger left, long right); // 0x000000018AE2D668-0x000000018AE2D6C0
		public static bool operator ==(BigInteger left, long right); // 0x000000018AE2C990-0x000000018AE2C9EC
		public static bool operator !=(BigInteger left, long right); // 0x000000018AE2D340-0x000000018AE2D394
		public static bool operator <(long left, BigInteger right); // 0x000000018AE2D718-0x000000018AE2D770
		public static bool operator <=(long left, BigInteger right); // 0x000000018AE2D6C0-0x000000018AE2D718
		private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl); // 0x000000018AE2AB78-0x000000018AE2AC28
		internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu); // 0x000000018AE2AAD4-0x000000018AE2AB28
	}

	internal static class BigIntegerCalculator // TypeDefIndex: 62583
	{
		// Fields
		private static int ReducerThreshold; // 0x00
		private static int SquareThreshold; // 0x04
		private static int AllocationThreshold; // 0x08
		private static int MultiplyThreshold; // 0x0C
	
		// Constructors
		static BigIntegerCalculator(); // 0x000000018AE2A520-0x000000018AE2A594
	
		// Methods
		public static uint[] Add(uint[] left, uint right); // 0x000000018AE28F6C-0x000000018AE29028
		public static uint[] Add(uint[] left, uint[] right); // 0x000000018AE29028-0x000000018AE29128
		private static unsafe void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength); // 0x000000018AE28EC0-0x000000018AE28F6C
		private static unsafe void AddSelf(uint* left, int leftLength, uint* right, int rightLength); // 0x000000018AE28E50-0x000000018AE28EC0
		public static uint[] Subtract(uint[] left, uint right); // 0x000000018AE2A478-0x000000018AE2A520
		public static uint[] Subtract(uint[] left, uint[] right); // 0x000000018AE2A2C4-0x000000018AE2A3D4
		private static unsafe void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength); // 0x000000018AE2A3D4-0x000000018AE2A478
		public static int Compare(uint[] left, uint[] right); // 0x000000018AE29128-0x000000018AE291A4
		public static uint[] Divide(uint[] left, uint right); // 0x000000018AE29598-0x000000018AE2963C
		public static uint[] Divide(uint[] left, uint[] right); // 0x000000018AE2963C-0x000000018AE2973C
		private static unsafe void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength); // 0x000000018AE29258-0x000000018AE29598
		private static unsafe uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength); // 0x000000018AE28E1C-0x000000018AE28E50
		private static unsafe uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q); // 0x000000018AE2A284-0x000000018AE2A2C4
		private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo); // 0x000000018AE2921C-0x000000018AE29258
		private static uint[] CreateCopy(uint[] value); // 0x000000018AE291A4-0x000000018AE2921C
		private static int LeadingZeros(uint value); // 0x000000018AE2973C-0x000000018AE297A4
		public static uint[] Square(uint[] value); // 0x000000018AE2A0C8-0x000000018AE2A1A0
		private static unsafe void Square(uint* value, int valueLength, uint* bits, int bitsLength); // 0x000000018AE29DDC-0x000000018AE2A0C8
		public static uint[] Multiply(uint[] left, uint right); // 0x000000018AE29D28-0x000000018AE29DDC
		public static uint[] Multiply(uint[] left, uint[] right); // 0x000000018AE297A4-0x000000018AE298B4
		private static unsafe void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength); // 0x000000018AE298B4-0x000000018AE29D28
		private static unsafe void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength); // 0x000000018AE2A1A0-0x000000018AE2A284
	}

	internal static class BigNumber // TypeDefIndex: 62585
	{
		// Nested types
		private struct BigNumberBuffer // TypeDefIndex: 62584
		{
			// Fields
			public StringBuilder digits; // 0x00
			public int precision; // 0x08
			public int scale; // 0x0C
			public bool sign; // 0x10
	
			// Methods
			public static BigNumberBuffer Create(); // 0x000000018AE2DD2C-0x000000018AE2DDA0
		}
	
		// Methods
		internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e); // 0x000000018AE2F5D4-0x000000018AE2F6D0
		internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result); // 0x000000018AE2F498-0x000000018AE2F5D4
		internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info); // 0x000000018AE2F1A4-0x000000018AE2F260
		internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info); // 0x000000018AE2F260-0x000000018AE2F38C
		private static bool HexNumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value); // 0x000000018AE2EE08-0x000000018AE2EF8C
		private static bool NumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value); // 0x000000018AE2EF8C-0x000000018AE2F1A4
		internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits); // 0x000000018AE2F38C-0x000000018AE2F498
		private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess); // 0x000000018AE2DDA0-0x000000018AE2E200
		internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info); // 0x000000018AE2E200-0x000000018AE2E2A0
		private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess); // 0x000000018AE2E2A0-0x000000018AE2EE08
	}

	[Serializable]
	public struct Complex : IEquatable<Complex>, IFormattable // TypeDefIndex: 62586
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
		public Complex(double real, double imaginary); // 0x0000000184D881B0-0x0000000184D881C0
		static Complex(); // 0x000000018AE2F92C-0x000000018AE2FA34
	
		// Methods
		public override bool Equals(object obj); // 0x000000018AE2F710-0x000000018AE2F78C
		public bool Equals(Complex value); // 0x000000018AE2F6D0-0x000000018AE2F710
		public override int GetHashCode(); // 0x000000018AE2F78C-0x000000018AE2F7D8
		public override string ToString(); // 0x000000018AE2F868-0x000000018AE2F92C
		public string ToString(string format, IFormatProvider provider); // 0x000000018AE2F7D8-0x000000018AE2F868
	}

	internal struct DoubleUlong // TypeDefIndex: 62587
	{
		// Fields
		public double dbl; // 0x00
		public ulong uu; // 0x00
	}

	internal static class NumericsHelpers // TypeDefIndex: 62588
	{
		// Methods
		public static void GetDoubleParts(double dbl, out int sign, out int exp, out ulong man, out bool fFinite); // 0x000000018AE33930-0x000000018AE339B8
		public static double GetDoubleFromParts(int sign, int exp, ulong man); // 0x000000018AE3386C-0x000000018AE33930
		public static void DangerousMakeTwosComplement(uint[] d); // 0x000000018AE337EC-0x000000018AE3386C
		public static ulong MakeUlong(uint uHi, uint uLo); // 0x0000000184D91D20-0x0000000184D91D30
		public static uint Abs(int a); // 0x0000000184DAA440-0x0000000184DAA450
		public static uint CombineHash(uint u1, uint u2); // 0x0000000184DAA450-0x0000000184DAA460
		public static int CombineHash(int n1, int n2); // 0x0000000184DAA450-0x0000000184DAA460
		public static int CbitHighZero(uint u); // 0x000000018AE2973C-0x000000018AE297A4
		public static int CbitHighZero(ulong uu); // 0x000000018AE337BC-0x000000018AE337EC
	}
}

namespace System.Numerics.Hashing
{
	internal static class HashHelpers // TypeDefIndex: 62589
	{
		// Fields
		public static readonly int RandomSeed; // 0x00
	
		// Constructors
		static HashHelpers(); // 0x000000018AE2FC60-0x000000018AE2FCC0
	
		// Methods
		public static int Combine(int h1, int h2); // 0x0000000184DA4450-0x0000000184DA4470
	}
}

namespace System.Runtime.CompilerServices
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field, Inherited = false)]
	internal sealed class IntrinsicAttribute : Attribute // TypeDefIndex: 62594
	{
		// Constructors
		public IntrinsicAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Text
{
	[DefaultMember("Item")]
	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal struct ValueStringBuilder // TypeDefIndex: 62593
	{
		// Fields
		private char[] _arrayToReturnToPool; // 0x00
		private Span<char> _chars; // 0x08
		private int _pos; // 0x18
	
		// Properties
		public int Length { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
	
		// Constructors
		public ValueStringBuilder(Span<char> initialBuffer); // 0x0000000184DA4110-0x0000000184DA4120
	
		// Methods
		public override string ToString(); // 0x000000018AE344C0-0x000000018AE34568
		public bool TryCopyTo(Span<char> destination, out int charsWritten); // 0x000000018AE34568-0x000000018AE34620
		public void Insert(int index, char value, int count); // 0x000000018AE34380-0x000000018AE344C0
		public void Append(char c); // 0x000000018AE3410C-0x000000018AE34174
		public void Append(string s); // 0x000000018AE33FAC-0x000000018AE34048
		private void AppendSlow(string s); // 0x000000018AE33D74-0x000000018AE33E48
		public void Append(char c, int count); // 0x000000018AE33EF0-0x000000018AE33FAC
		public unsafe void Append(char* value, int length); // 0x000000018AE34048-0x000000018AE3410C
		public Span<char> AppendSpan(int length); // 0x000000018AE33E48-0x000000018AE33EF0
		private void GrowAndAppend(char c); // 0x000000018AE341F4-0x000000018AE3422C
		private void Grow(int requiredAdditionalCapacity); // 0x000000018AE3422C-0x000000018AE34380
		public void Dispose(); // 0x000000018AE34174-0x000000018AE341F4
	}
}
