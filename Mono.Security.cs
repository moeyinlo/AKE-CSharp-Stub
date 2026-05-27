/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Mono.Math;
using Mono.Math.Prime;
using Mono.Security;
using Mono.Security.Cryptography;
using Mono.Security.X509;

// Image 51: Mono.Security.dll - Assembly: Mono.Security, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56920-57023

namespace Mono.Math
{
	public class BigInteger // TypeDefIndex: 57007
	{
		// Fields
		private uint length; // 0x10
		private uint[] data; // 0x18
		internal static readonly uint[] smallPrimes; // 0x00
		private static RandomNumberGenerator rng; // 0x08
	
		// Properties
		private static RandomNumberGenerator Rng { get => default; } // 0x00000001891286A0-0x00000001891286E4 
	
		// Nested types
		public enum Sign // TypeDefIndex: 57004
		{
			Negative = -1,
			Zero = 0,
			Positive = 1
		}
	
		public sealed class ModulusRing // TypeDefIndex: 57005
		{
			// Fields
			private BigInteger mod; // 0x10
			private BigInteger constant; // 0x18
	
			// Constructors
			public ModulusRing() {} // Dummy constructor
			public ModulusRing(BigInteger modulus) {} // 0x0000000189128D8C-0x0000000189128DEC
	
			// Methods
			public void BarrettReduction(BigInteger x) {} // 0x0000000189128CF4-0x0000000189128D8C
			public BigInteger Multiply(BigInteger a, BigInteger b) => default; // 0x0000000189129088-0x000000018912913C
			public BigInteger Difference(BigInteger a, BigInteger b) => default; // 0x0000000189128DEC-0x0000000189129014
			public BigInteger Pow(BigInteger a, BigInteger k) => default; // 0x0000000189129014-0x0000000189129088
			[CLSCompliant(false)]
			public BigInteger Pow(uint b, BigInteger exp) => default; // 0x00000001891293F4-0x0000000189129454
		}
	
		private sealed class Kernel // TypeDefIndex: 57006
		{
			// Constructors
			public Kernel() {} // Dummy constructor
	
			// Methods
			public static BigInteger AddSameSign(BigInteger bi1, BigInteger bi2) => default; // 0x0000000189129454-0x0000000189129504
			public static BigInteger Subtract(BigInteger big, BigInteger small) => default; // 0x00000001891291E4-0x00000001891292AC
			public static void MinusEq(BigInteger big, BigInteger small) {} // 0x0000000189129874-0x0000000189129A40
			public static void PlusEq(BigInteger bi1, BigInteger bi2) {} // 0x0000000189129650-0x0000000189129658
			public static Sign Compare(BigInteger bi1, BigInteger bi2) => default; // 0x0000000189129624-0x0000000189129650
			public static uint SingleByteDivideInPlace(BigInteger n, uint d) => default; // 0x00000001891292AC-0x00000001891292D8
			public static uint DwordMod(BigInteger n, uint d) => default; // 0x0000000189129658-0x000000018912986C
			public static BigInteger[] DwordDivMod(BigInteger n, uint d) => default; // 0x00000001891295F0-0x00000001891295F8
			public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) => default; // 0x000000018912986C-0x0000000189129874
			public static BigInteger LeftShift(BigInteger bi, int n) => default; // 0x000000018912913C-0x00000001891291E4
			public static BigInteger RightShift(BigInteger bi, int n) => default; // 0x00000001891283DC-0x000000018912853C
			public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) {} // 0x000000018912853C-0x0000000189128588
			public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) {} // 0x00000001891281E8-0x0000000189128244
			public static uint modInverse(BigInteger bi, uint modulus) => default; // 0x000000018912891C-0x00000001891289BC
			public static BigInteger modInverse(BigInteger bi, BigInteger modulus) => default; // 0x00000001891288BC-0x00000001891288C8
		}
	
		// Constructors
		public BigInteger() {} // Dummy constructor
		[CLSCompliant(false)]
		public BigInteger(Sign sign, uint len) {} // 0x00000001891288C8-0x000000018912891C
		public BigInteger(BigInteger bi) {} // 0x000000018912876C-0x00000001891287E0
		[CLSCompliant(false)]
		public BigInteger(BigInteger bi, uint len) {} // 0x0000000189128588-0x00000001891286A0
		public BigInteger(byte[] inData) {} // 0x00000001891292D8-0x0000000189129330
		[CLSCompliant(false)]
		public BigInteger(uint ui) {} // 0x0000000189129598-0x00000001891295F0
		static BigInteger() {} // 0x000000018912B4F0-0x000000018912B980
	
		// Methods
		[CLSCompliant(false)]
		public static implicit operator BigInteger(uint value) => default; // 0x0000000189129330-0x00000001891293C4
		public static implicit operator BigInteger(int value) => default; // 0x0000000189129504-0x0000000189129598
		public static BigInteger operator +(BigInteger bi1, BigInteger bi2) => default; // 0x00000001891293DC-0x00000001891293F4
		public static BigInteger operator -(BigInteger bi1, BigInteger bi2) => default; // 0x0000000189129610-0x0000000189129624
		[CLSCompliant(false)]
		public static uint operator %(BigInteger bi, uint ui) => default; // 0x00000001891293C4-0x00000001891293DC
		public static BigInteger operator %(BigInteger bi1, BigInteger bi2) => default; // 0x00000001891295F8-0x0000000189129610
		public static BigInteger operator /(BigInteger bi1, BigInteger bi2) => default; // 0x0000000189128C0C-0x0000000189128C58
		public static BigInteger operator *(BigInteger bi1, BigInteger bi2) => default; // 0x00000001891289BC-0x0000000189128C0C
		public static BigInteger operator <<(BigInteger bi1, int shiftVal) => default; // 0x0000000189128870-0x00000001891288BC
		public static BigInteger operator >>(BigInteger bi1, int shiftVal) => default; // 0x0000000189128244-0x000000018912828C
		public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) => default; // 0x0000000189128C58-0x0000000189128C68
		public static BigInteger GenerateRandom(int bits) => default; // 0x000000018912828C-0x000000018912836C
		public int BitCount() => default; // 0x00000001891287E0-0x00000001891287E8
		public bool TestBit(int bitNum) => default; // 0x00000001891287E8-0x0000000189128870
		[CLSCompliant(false)]
		public void SetBit(uint bitNum) {} // 0x000000018912836C-0x00000001891283DC
		[CLSCompliant(false)]
		public void SetBit(uint bitNum, bool value) {} // 0x00000001891286E4-0x000000018912876C
		public int LowestSetBit() => default; // 0x0000000189128C68-0x0000000189128CF4
		public byte[] GetBytes() => default; // 0x000000018912E3E4-0x000000018912E4D8
		[CLSCompliant(false)]
		public static bool operator ==(BigInteger bi1, uint ui) => default; // 0x000000018912DC98-0x000000018912DF54
		[CLSCompliant(false)]
		public static bool operator !=(BigInteger bi1, uint ui) => default; // 0x000000018912E0F0-0x000000018912E24C
		public static bool operator ==(BigInteger bi1, BigInteger bi2) => default; // 0x000000018912DF54-0x000000018912E0F0
		public static bool operator !=(BigInteger bi1, BigInteger bi2) => default; // 0x000000018912E2D0-0x000000018912E3E4
		public static bool operator >(BigInteger bi1, BigInteger bi2) => default; // 0x000000018912E24C-0x000000018912E2D0
		public static bool operator <(BigInteger bi1, BigInteger bi2) => default; // 0x000000018912A4D4-0x000000018912A6A4
		public static bool operator >=(BigInteger bi1, BigInteger bi2) => default; // 0x000000018912B298-0x000000018912B444
		public static bool operator <=(BigInteger bi1, BigInteger bi2) => default; // 0x000000018912AB70-0x000000018912AC98
		[CLSCompliant(false)]
		public string ToString(uint radix) => default; // 0x000000018912AEE0-0x000000018912B078
		[CLSCompliant(false)]
		public string ToString(uint radix, string characterSet) => default; // 0x000000018912A6A4-0x000000018912A7D8
		private void Normalize() {} // 0x000000018912B22C-0x000000018912B298
		public void Clear() {} // 0x000000018912A940-0x000000018912A998
		public override int GetHashCode() => default; // 0x000000018912A7D8-0x000000018912A940
		public override string ToString() => default; // 0x000000018912B980-0x000000018912BEFC
		public override bool Equals(object o) => default; // 0x000000018912A998-0x000000018912AB70
		public BigInteger ModInverse(BigInteger modulus) => default; // 0x000000018912B078-0x000000018912B22C
		public BigInteger ModPow(BigInteger exp, BigInteger n) => default; // 0x000000018912ADCC-0x000000018912AEE0
		public static BigInteger GeneratePseudoPrime(int bits) => default; // 0x000000018912AC98-0x000000018912ADCC
		public void Incr2() {} // 0x000000018912B444-0x000000018912B4F0
	}
}

namespace Mono.Math.Prime
{
	public enum ConfidenceFactor // TypeDefIndex: 57008
	{
		ExtraLow = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		ExtraHigh = 4,
		Provable = 5
	}

	public delegate bool PrimalityTest(BigInteger bi, ConfidenceFactor confidence); // TypeDefIndex: 57009; 0x0000000181165340-0x0000000181165350

	public sealed class PrimalityTests // TypeDefIndex: 57010
	{
		// Constructors
		public PrimalityTests() {} // Dummy constructor
	
		// Methods
		private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) => default; // 0x000000018912F9F8-0x000000018912FBAC
		public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence) => default; // 0x000000018912FBAC-0x000000018912FE34
	}
}

namespace Mono.Math.Prime.Generator
{
	public abstract class PrimeGeneratorBase // TypeDefIndex: 57011
	{
		// Properties
		public virtual ConfidenceFactor Confidence { get; } // 0x0000000182102C70-0x0000000182102C80 
		public virtual PrimalityTest PrimalityTest { get; } // 0x000000018912FE34-0x000000018912FE9C 
		public virtual int TrialDivisionBounds { get; } // 0x0000000183D5D090-0x0000000183D5D0A0 
	
		// Constructors
		protected PrimeGeneratorBase() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract BigInteger GenerateNewPrime(int bits);
	}

	public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 57012
	{
		// Constructors
		public SequentialSearchPrimeGeneratorBase() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected virtual BigInteger GenerateSearchBase(int bits, object context) => default; // 0x0000000189133088-0x00000001891330E8
		public override BigInteger GenerateNewPrime(int bits) => default; // 0x000000018913307C-0x0000000189133088
		public virtual BigInteger GenerateNewPrime(int bits, object context) => default; // 0x0000000189132E68-0x000000018913307C
		protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) => default; // 0x000000018232EB60-0x000000018232EB70
	}
}

namespace Mono.Security
{
	public class ASN1 // TypeDefIndex: 56922
	{
		// Fields
		private byte m_nTag; // 0x10
		private byte[] m_aValue; // 0x18
		private ArrayList elist; // 0x20
	
		// Properties
		public int Count { get => default; } // 0x0000000189111D64-0x0000000189111D8C 
		public byte Tag { get => default; } // 0x00000001811797F0-0x0000000181179800 
		public int Length { get => default; } // 0x0000000188972AA4-0x0000000188972AB8 
		public byte[] Value { get => default; set {} } // 0x0000000189111E7C-0x0000000189111EDC 0x0000000189111EDC-0x0000000189111F50
		public ASN1 this[int index] { get => default; } // 0x0000000189111D8C-0x0000000189111E7C 
	
		// Constructors
		public ASN1() {} // Dummy constructor
		public ASN1(byte tag) {} // 0x0000000184275ADC-0x0000000184275AF0
		public ASN1(byte tag, byte[] data) {} // 0x0000000182F73D00-0x0000000182F73D10
		public ASN1(byte[] data) {} // 0x0000000189111BF4-0x0000000189111D64
	
		// Methods
		private bool CompareArray(byte[] array1, byte[] array2) => default; // 0x00000001891110A4-0x0000000189111108
		public bool CompareValue(byte[] value) => default; // 0x0000000189111108-0x0000000189111118
		public ASN1 Add(ASN1 asn1) => default; // 0x000000018911100C-0x00000001891110A4
		public virtual byte[] GetBytes() => default; // 0x0000000189111450-0x00000001891119CC
		protected void Decode(byte[] asn1, ref int anPos, int anLength) {} // 0x0000000189111218-0x000000018911133C
		protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) {
			tag = default;
			length = default;
			content = default;
		} // 0x0000000189111118-0x0000000189111218
		public ASN1 Element(int index, byte anTag) => default; // 0x000000018911133C-0x0000000189111450
		public override string ToString() => default; // 0x00000001891119CC-0x0000000189111BF4
	}

	public static class ASN1Convert // TypeDefIndex: 56923
	{
		// Methods
		public static ASN1 FromInt32(int value) => default; // 0x00000001891104D8-0x0000000189110608
		public static ASN1 FromOid(string oid) => default; // 0x0000000189110608-0x00000001891106E0
		public static ASN1 FromUnsignedBigInteger(byte[] big) => default; // 0x00000001891106E0-0x00000001891107FC
		public static int ToInt32(ASN1 asn1) => default; // 0x0000000189110C84-0x0000000189110DA8
		public static string ToOid(ASN1 asn1) => default; // 0x0000000189110DA8-0x000000018911100C
		public static System.DateTime ToDateTime(ASN1 time) => default; // 0x00000001891107FC-0x0000000189110C84
	}

	internal sealed class BitConverterLE // TypeDefIndex: 56924
	{
		// Constructors
		public BitConverterLE() {} // Dummy constructor
	
		// Methods
		private static unsafe byte[] GetUIntBytes(byte* bytes) => default; // 0x0000000189112A74-0x0000000189112B50
		private static unsafe byte[] GetULongBytes(byte* bytes) => default; // 0x0000000189112B50-0x0000000189112CAC
		internal static byte[] GetBytes(int value) => default; // 0x0000000189112A58-0x0000000189112A74
		internal static byte[] GetBytes(long value) => default; // 0x0000000189112A3C-0x0000000189112A58
		private static unsafe void UShortFromBytes(byte* dst, byte[] src, int startIndex) {} // 0x0000000189112DF4-0x0000000189112EA8
		private static unsafe void UIntFromBytes(byte* dst, byte[] src, int startIndex) {} // 0x0000000189112CFC-0x0000000189112DF4
		internal static int ToInt32(byte[] value, int startIndex) => default; // 0x0000000189112CAC-0x0000000189112CD4
		internal static ushort ToUInt16(byte[] value, int startIndex) => default; // 0x0000000189112CD4-0x0000000189112CFC
		internal static uint ToUInt32(byte[] value, int startIndex) => default; // 0x0000000189112CAC-0x0000000189112CD4
	}

	public sealed class PKCS7 // TypeDefIndex: 56929
	{
		// Nested types
		public class ContentInfo // TypeDefIndex: 56925
		{
			// Fields
			private string contentType; // 0x10
			private ASN1 content; // 0x18
	
			// Properties
			public ASN1 ASN1 { get => default; } // 0x0000000189115038-0x0000000189115040 
			public ASN1 Content { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
			public string ContentType { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
			// Constructors
			public ContentInfo() {} // 0x0000000189114D50-0x0000000189114DB8
			public ContentInfo(string oid) {} // 0x0000000189114E30-0x0000000189114E60
			public ContentInfo(byte[] data) {} // 0x0000000189114DB8-0x0000000189114E30
			public ContentInfo(ASN1 asn1) {} // 0x0000000189114E60-0x0000000189115038
	
			// Methods
			internal ASN1 GetASN1() => default; // 0x0000000189114CB4-0x0000000189114D50
		}
	
		public class EncryptedData // TypeDefIndex: 56926
		{
			// Fields
			private byte _version; // 0x10
			private ContentInfo _content; // 0x18
			private ContentInfo _encryptionAlgorithm; // 0x20
			private byte[] _encrypted; // 0x28
	
			// Properties
			public ContentInfo EncryptionAlgorithm { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
			public byte[] EncryptedContent { get => default; } // 0x0000000189115DC8-0x0000000189115E1C 
	
			// Constructors
			public EncryptedData() {} // 0x0000000183D557C0-0x0000000183D557D0
			public EncryptedData(ASN1 asn1) {} // 0x00000001891159A8-0x0000000189115DC8
		}
	
		public class SignedData // TypeDefIndex: 56927
		{
			// Fields
			private byte version; // 0x10
			private string hashAlgorithm; // 0x18
			private ContentInfo contentInfo; // 0x20
			private Mono.Security.X509.X509CertificateCollection certs; // 0x28
			private ArrayList crls; // 0x30
			private SignerInfo signerInfo; // 0x38
			private bool mda; // 0x40
	
			// Properties
			public Mono.Security.X509.X509CertificateCollection Certificates { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
			public ContentInfo ContentInfo { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
			public string HashName { set {} } // 0x000000018911DA6C-0x000000018911DAA4
			public SignerInfo SignerInfo { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
	
			// Constructors
			public SignedData() {} // Dummy constructor
			public SignedData(ASN1 asn1) {} // 0x000000018911D494-0x000000018911DA6C
	
			// Methods
			internal string OidToName(string oid) => default; // 0x000000018911D324-0x000000018911D494
		}
	
		public class SignerInfo // TypeDefIndex: 56928
		{
			// Fields
			private byte version; // 0x10
			private string hashAlgorithm; // 0x18
			private ArrayList authenticatedAttributes; // 0x20
			private ArrayList unauthenticatedAttributes; // 0x28
			private byte[] signature; // 0x30
			private string issuer; // 0x38
			private byte[] serial; // 0x40
			private byte[] ski; // 0x48
	
			// Properties
			public string IssuerName { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
			public byte[] SerialNumber { get => default; } // 0x000000018911DF68-0x000000018911DFBC 
			public ArrayList AuthenticatedAttributes { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
			public string HashName { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
			public byte[] Signature { get => default; } // 0x000000018911DFBC-0x000000018911E010 
			public ArrayList UnauthenticatedAttributes { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
			public byte Version { get => default; } // 0x00000001811797F0-0x0000000181179800 
	
			// Constructors
			public SignerInfo() {} // 0x000000018911DAA4-0x000000018911DB38
			public SignerInfo(ASN1 asn1) {} // 0x000000018911DB38-0x000000018911DF68
		}
	
		// Constructors
		public PKCS7() {} // Dummy constructor
	}
}

namespace Mono.Security.Authenticode
{
	public class AuthenticodeBase // TypeDefIndex: 57002
	{
		// Fields
		private byte[] fileblock; // 0x10
		private Stream fs; // 0x18
		private int blockNo; // 0x20
		private int blockLength; // 0x24
		private int peOffset; // 0x28
		private int dirSecurityOffset; // 0x2C
		private int dirSecuritySize; // 0x30
		private int coffSymbolTableOffset; // 0x34
		private bool pe64; // 0x38
	
		// Properties
		internal int PEOffset { get => default; } // 0x0000000189126834-0x0000000189126858 
	
		// Constructors
		public AuthenticodeBase() {} // 0x00000001891267EC-0x0000000189126834
	
		// Methods
		internal void Open(string filename) {} // 0x0000000189126390-0x0000000189126430
		internal void Open(byte[] rawdata) {} // 0x0000000189126430-0x00000001891264C0
		internal void Close() {} // 0x0000000189125E80-0x0000000189125EBC
		internal void ReadFirstBlock() {} // 0x0000000189126708-0x00000001891267EC
		internal int ProcessFirstBlock() => default; // 0x00000001891264C0-0x0000000189126708
		internal byte[] GetSecurityEntry() => default; // 0x00000001891262E0-0x0000000189126390
		internal byte[] GetHash(HashAlgorithm hash) => default; // 0x0000000189125EBC-0x00000001891262E0
	}

	public class AuthenticodeDeformatter : AuthenticodeBase // TypeDefIndex: 57003
	{
		// Fields
		private string filename; // 0x40
		private byte[] rawdata; // 0x48
		private byte[] hash; // 0x50
		private Mono.Security.X509.X509CertificateCollection coll; // 0x58
		private ASN1 signedHash; // 0x60
		private System.DateTime timestamp; // 0x68
		private Mono.Security.X509.X509Certificate signingCertificate; // 0x70
		private int reason; // 0x78
		private bool trustedRoot; // 0x7C
		private bool trustedTimestampRoot; // 0x7D
		private byte[] entry; // 0x80
		private Mono.Security.X509.X509Chain signerChain; // 0x88
		private Mono.Security.X509.X509Chain timestampChain; // 0x90
	
		// Properties
		public byte[] RawData { set {} } // 0x00000001891280FC-0x00000001891281E8
		public Mono.Security.X509.X509Certificate SigningCertificate { get => default; } // 0x0000000183D4EB30-0x0000000183D4EB40 
	
		// Constructors
		public AuthenticodeDeformatter() {} // 0x0000000189128020-0x00000001891280CC
		public AuthenticodeDeformatter(byte[] rawData) {} // 0x00000001891280CC-0x00000001891280FC
	
		// Methods
		private bool CheckSignature() => default; // 0x0000000189126858-0x0000000189126B54
		private bool CompareIssuerSerial(string issuer, byte[] serial, Mono.Security.X509.X509Certificate x509) => default; // 0x0000000189126B54-0x0000000189126C14
		private bool VerifySignature(PKCS7.SignedData sd, byte[] calculatedMessageDigest, HashAlgorithm ha) => default; // 0x0000000189127600-0x0000000189128020
		private bool VerifyCounterSignature(PKCS7.SignerInfo cs, byte[] signature) => default; // 0x0000000189126CF0-0x0000000189127600
		private void Reset() {} // 0x0000000189126C14-0x0000000189126CF0
	}
}

namespace Mono.Security.Cryptography
{
	public sealed class CryptoConvert // TypeDefIndex: 56991
	{
		// Constructors
		public CryptoConvert() {} // Dummy constructor
	
		// Methods
		public static string ToHex(byte[] input) => default; // 0x0000000189129C18-0x0000000189129D08
		private static byte FromHexChar(char c) => default; // 0x0000000189129A40-0x0000000189129AC8
		public static byte[] FromHex(string hex) => default; // 0x0000000189129AC8-0x0000000189129C18
	}

	public abstract class MD2 : HashAlgorithm // TypeDefIndex: 56992
	{
		// Constructors
		protected MD2() {} // 0x0000000183D6E650-0x0000000183D6E660
	
		// Methods
		public static MD2 Create() => default; // 0x000000018912C500-0x000000018912C550
	}

	public class MD2Managed : MD2 // TypeDefIndex: 56993
	{
		// Fields
		private byte[] state; // 0x28
		private byte[] checksum; // 0x30
		private byte[] buffer; // 0x38
		private int count; // 0x40
		private byte[] x; // 0x48
		private static readonly byte[] PI_SUBST; // 0x00
	
		// Constructors
		public MD2Managed() {} // 0x000000018912C448-0x000000018912C500
		static MD2Managed() {} // 0x000000018912C3BC-0x000000018912C448
	
		// Methods
		private byte[] Padding(int nLength) => default; // 0x000000018912C344-0x000000018912C3BC
		public override void Initialize() {} // 0x000000018912C0A8-0x000000018912C104
		protected override void HashCore(byte[] array, int ibStart, int cbSize) {} // 0x000000018912BEFC-0x000000018912BFF8
		protected override byte[] HashFinal() => default; // 0x000000018912BFF8-0x000000018912C0A8
		private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) {} // 0x000000018912C104-0x000000018912C344
	}

	public abstract class MD4 : HashAlgorithm // TypeDefIndex: 56994
	{
		// Constructors
		protected MD4() {} // 0x0000000183D6E650-0x0000000183D6E660
	
		// Methods
		public static MD4 Create() => default; // 0x000000018912D840-0x000000018912D890
	}

	public class MD4Managed : MD4 // TypeDefIndex: 56995
	{
		// Fields
		private uint[] state; // 0x28
		private byte[] buffer; // 0x30
		private uint[] count; // 0x38
		private uint[] x; // 0x40
		private byte[] digest; // 0x48
	
		// Constructors
		public MD4Managed() {} // 0x000000018912D760-0x000000018912D840
	
		// Methods
		public override void Initialize() {} // 0x000000018912C92C-0x000000018912C9F8
		protected override void HashCore(byte[] array, int ibStart, int cbSize) {} // 0x000000018912C6AC-0x000000018912C82C
		protected override byte[] HashFinal() => default; // 0x000000018912C82C-0x000000018912C92C
		private byte[] Padding(int nLength) => default; // 0x000000018912D704-0x000000018912D760
		private uint F(uint x, uint y, uint z) => default; // 0x0000000183D6E6A0-0x0000000183D6E6B0
		private uint G(uint x, uint y, uint z) => default; // 0x0000000183D6E700-0x0000000183D6E710
		private uint H(uint x, uint y, uint z) => default; // 0x0000000183D6E750-0x0000000183D6E760
		private uint ROL(uint x, byte n) => default; // 0x0000000183D6E760-0x0000000183D6E780
		private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) {} // 0x0000000183D6E660-0x0000000183D6E6A0
		private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) {} // 0x0000000183D6E6B0-0x0000000183D6E700
		private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) {} // 0x0000000183D6E710-0x0000000183D6E750
		private void Encode(byte[] output, uint[] input) {} // 0x000000018912C5E8-0x000000018912C6AC
		private void Decode(uint[] output, byte[] input, int index) {} // 0x000000018912C550-0x000000018912C5E8
		private void MD4Transform(uint[] state, byte[] block, int index) {} // 0x000000018912C9F8-0x000000018912D704
	}

	public sealed class PKCS1 // TypeDefIndex: 56996
	{
		// Fields
		private static byte[] emptySHA1; // 0x00
		private static byte[] emptySHA256; // 0x08
		private static byte[] emptySHA384; // 0x10
		private static byte[] emptySHA512; // 0x18
	
		// Constructors
		public PKCS1() {} // Dummy constructor
		static PKCS1() {} // 0x000000018912F734-0x000000018912F8D0
	
		// Methods
		private static bool Compare(byte[] array1, byte[] array2) => default; // 0x000000018912EA24-0x000000018912EA88
		public static byte[] I2OSP(byte[] x, int size) => default; // 0x000000018912F448-0x000000018912F4C8
		public static byte[] OS2IP(byte[] x) => default; // 0x000000018912F4C8-0x000000018912F578
		public static byte[] RSAVP1(RSA rsa, byte[] s) => default; // 0x00000001831874E0-0x0000000183187510
		public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) => default; // 0x000000018912F578-0x000000018912F734
		public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) => default; // 0x000000018912EE18-0x000000018912F130
		internal static string HashNameFromOid(string oid, bool throwOnError = true /* Metadata: 0x01FD8B47 */) => default; // 0x000000018912F130-0x000000018912F448
		internal static HashAlgorithm CreateFromOid(string oid) => default; // 0x000000018912EDC8-0x000000018912EE18
		internal static HashAlgorithm CreateFromName(string name) => default; // 0x000000018912EA88-0x000000018912EDC8
	}

	public sealed class PKCS8 // TypeDefIndex: 56999
	{
		// Nested types
		public class PrivateKeyInfo // TypeDefIndex: 56997
		{
			// Fields
			private int _version; // 0x10
			private string _algorithm; // 0x18
			private byte[] _key; // 0x20
			private ArrayList _list; // 0x28
	
			// Properties
			public string Algorithm { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
			public byte[] PrivateKey { get => default; set {} } // 0x00000001891310F4-0x0000000189131148 0x0000000189131148-0x0000000189131210
	
			// Constructors
			public PrivateKeyInfo() {} // 0x000000018913105C-0x00000001891310C4
			public PrivateKeyInfo(byte[] data) {} // 0x00000001891310C4-0x00000001891310F4
	
			// Methods
			private void Decode(byte[] data) {} // 0x00000001891304E4-0x00000001891307E8
			public byte[] GetBytes() => default; // 0x0000000189130B30-0x0000000189130F20
			private static byte[] RemoveLeadingZero(byte[] bigInt) => default; // 0x0000000189130FB8-0x000000018913105C
			private static byte[] Normalize(byte[] bigInt, int length) => default; // 0x0000000189130F20-0x0000000189130FB8
			public static RSA DecodeRSA(byte[] keypair) => default; // 0x000000018912FFCC-0x00000001891304E4
			public static byte[] Encode(RSA rsa) => default; // 0x000000018913082C-0x0000000189130A28
			public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) => default; // 0x000000018912FE9C-0x000000018912FFCC
			public static byte[] Encode(DSA dsa) => default; // 0x00000001891307E8-0x000000018913082C
			public static byte[] Encode(AsymmetricAlgorithm aa) => default; // 0x0000000189130A28-0x0000000189130B30
		}
	
		public class EncryptedPrivateKeyInfo // TypeDefIndex: 56998
		{
			// Fields
			private string _algorithm; // 0x10
			private byte[] _salt; // 0x18
			private int _iterations; // 0x20
			private byte[] _data; // 0x28
	
			// Properties
			public string Algorithm { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
			public byte[] EncryptedData { get => default; set {} } // 0x000000018912A2F0-0x000000018912A344 0x000000018912A3E0-0x000000018912A450
			public byte[] Salt { get => default; } // 0x000000018912A344-0x000000018912A3E0 
			public int IterationCount { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x000000018912A450-0x000000018912A4D4
	
			// Constructors
			public EncryptedPrivateKeyInfo() {} // 0x000000018350B670-0x000000018350B680
			public EncryptedPrivateKeyInfo(byte[] data) {} // 0x000000018912A2E8-0x000000018912A2F0
	
			// Methods
			private void Decode(byte[] data) {} // 0x0000000189129D08-0x000000018912A0E8
			public byte[] GetBytes() => default; // 0x000000018912A0E8-0x000000018912A2E8
		}
	
		// Constructors
		public PKCS8() {} // Dummy constructor
	}

	public class RSAManaged : RSA // TypeDefIndex: 57001
	{
		// Fields
		private bool isCRTpossible; // 0x20
		private bool keyBlinding; // 0x21
		private bool keypairGenerated; // 0x22
		private bool m_disposed; // 0x23
		private BigInteger d; // 0x28
		private BigInteger p; // 0x30
		private BigInteger q; // 0x38
		private BigInteger dp; // 0x40
		private BigInteger dq; // 0x48
		private BigInteger qInv; // 0x50
		private BigInteger n; // 0x58
		private BigInteger e; // 0x60
	
		// Properties
		public override int KeySize { get => default; } // 0x0000000189131210-0x0000000189131580 
		public bool PublicOnly { get => default; } // 0x00000001891317F0-0x000000018913191C 
	
		// Nested types
		public delegate void KeyGeneratedEventHandler(object sender, EventArgs e); // TypeDefIndex: 57000; 0x0000000189132C94-0x0000000189132D50
	
		// Constructors
		public RSAManaged() {} // 0x0000000189131CE0-0x0000000189131D58
		public RSAManaged(int keySize) {} // 0x0000000189131D58-0x000000018913201C
	
		// Methods
		~RSAManaged() {} // 0x0000000189132D50-0x0000000189132DE8
		private void GenerateKeyPair() {} // 0x0000000189132DE8-0x0000000189132E68
		public override byte[] DecryptValue(byte[] rgb) => default; // 0x000000018913191C-0x0000000189131CE0
		public override byte[] EncryptValue(byte[] rgb) => default; // 0x00000001891320C8-0x00000001891326EC
		public override RSAParameters ExportParameters(bool includePrivateParameters) => default; // 0x0000000189131580-0x00000001891317F0
		public override void ImportParameters(RSAParameters parameters) {} // 0x00000001891326EC-0x0000000189132C84
		protected override void Dispose(bool disposing) {} // 0x000000018913201C-0x00000001891320C8
		public override string ToXmlString(bool includePrivateParameters) => default; // 0x0000000186E7B27C-0x0000000186E7B3A4
		private byte[] GetPaddedValue(BigInteger value, int length) => default; // 0x0000000182065C10-0x0000000182065C20
	}
}

namespace Mono.Security.Interface
{
	public enum AlertLevel : byte // TypeDefIndex: 56975
	{
		Warning = 1,
		Fatal = 2
	}

	public enum AlertDescription : byte // TypeDefIndex: 56976
	{
		CloseNotify = 0,
		UnexpectedMessage = 10,
		BadRecordMAC = 20,
		DecryptionFailed_RESERVED = 21,
		RecordOverflow = 22,
		DecompressionFailure = 30,
		HandshakeFailure = 40,
		NoCertificate_RESERVED = 41,
		BadCertificate = 42,
		UnsupportedCertificate = 43,
		CertificateRevoked = 44,
		CertificateExpired = 45,
		CertificateUnknown = 46,
		IlegalParameter = 47,
		UnknownCA = 48,
		AccessDenied = 49,
		DecodeError = 50,
		DecryptError = 51,
		ExportRestriction = 60,
		ProtocolVersion = 70,
		InsuficientSecurity = 71,
		InternalError = 80,
		UserCancelled = 90,
		NoRenegotiation = 100,
		UnsupportedExtension = 110
	}

	public class Alert // TypeDefIndex: 56977
	{
		// Fields
		private AlertLevel level; // 0x10
		private AlertDescription description; // 0x11
	
		// Properties
		public AlertLevel Level { get => default; } // 0x00000001811797F0-0x0000000181179800 
		public AlertDescription Description { get => default; } // 0x0000000183D510E0-0x0000000183D510F0 
	
		// Constructors
		public Alert() {} // Dummy constructor
		public Alert(AlertDescription description) {} // 0x0000000189125E08-0x0000000189125E14
	
		// Methods
		private void inferAlertLevel() {} // 0x0000000189125E14-0x0000000189125E80
		public override string ToString() => default; // 0x0000000189125D74-0x0000000189125E08
	}

	public class ValidationResult // TypeDefIndex: 56978
	{
		// Fields
		private bool trusted; // 0x10
		private bool user_denied; // 0x11
		private int error_code; // 0x14
		private MonoSslPolicyErrors? policy_errors; // 0x18
	
		// Properties
		public bool Trusted { get => default; } // 0x00000001811797F0-0x0000000181179800 
		public bool UserDenied { get => default; } // 0x0000000183D510E0-0x0000000183D510F0 
	
		// Constructors
		public ValidationResult() {} // Dummy constructor
		public ValidationResult(bool trusted, bool user_denied, int error_code, MonoSslPolicyErrors? policy_errors) {} // 0x0000000183D6E7D0-0x0000000183D6E7F0
	}

	public interface ICertificateValidator // TypeDefIndex: 56979
	{
	}

	[CLSCompliant(false)]
	public enum CipherSuiteCode : ushort // TypeDefIndex: 56980
	{
		TLS_NULL_WITH_NULL_NULL = 0,
		TLS_RSA_WITH_NULL_MD5 = 1,
		TLS_RSA_WITH_NULL_SHA = 2,
		TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3,
		TLS_RSA_WITH_RC4_128_MD5 = 4,
		TLS_RSA_WITH_RC4_128_SHA = 5,
		TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6,
		TLS_RSA_WITH_IDEA_CBC_SHA = 7,
		TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8,
		TLS_RSA_WITH_DES_CBC_SHA = 9,
		TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10,
		TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11,
		TLS_DH_DSS_WITH_DES_CBC_SHA = 12,
		TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13,
		TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14,
		TLS_DH_RSA_WITH_DES_CBC_SHA = 15,
		TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16,
		TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17,
		TLS_DHE_DSS_WITH_DES_CBC_SHA = 18,
		TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19,
		TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20,
		TLS_DHE_RSA_WITH_DES_CBC_SHA = 21,
		TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22,
		TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23,
		TLS_DH_anon_WITH_RC4_128_MD5 = 24,
		TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25,
		TLS_DH_anon_WITH_DES_CBC_SHA = 26,
		TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27,
		TLS_PSK_WITH_NULL_SHA = 44,
		TLS_DHE_PSK_WITH_NULL_SHA = 45,
		TLS_RSA_PSK_WITH_NULL_SHA = 46,
		TLS_RSA_WITH_AES_128_CBC_SHA = 47,
		TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48,
		TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49,
		TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50,
		TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51,
		TLS_DH_anon_WITH_AES_128_CBC_SHA = 52,
		TLS_RSA_WITH_AES_256_CBC_SHA = 53,
		TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54,
		TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55,
		TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56,
		TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57,
		TLS_DH_anon_WITH_AES_256_CBC_SHA = 58,
		TLS_RSA_WITH_NULL_SHA256 = 59,
		TLS_RSA_WITH_AES_128_CBC_SHA256 = 60,
		TLS_RSA_WITH_AES_256_CBC_SHA256 = 61,
		TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62,
		TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63,
		TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64,
		TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65,
		TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66,
		TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67,
		TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68,
		TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69,
		TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70,
		TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103,
		TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104,
		TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105,
		TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106,
		TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107,
		TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108,
		TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109,
		TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132,
		TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133,
		TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134,
		TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135,
		TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136,
		TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137,
		TLS_PSK_WITH_RC4_128_SHA = 138,
		TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139,
		TLS_PSK_WITH_AES_128_CBC_SHA = 140,
		TLS_PSK_WITH_AES_256_CBC_SHA = 141,
		TLS_DHE_PSK_WITH_RC4_128_SHA = 142,
		TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143,
		TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144,
		TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145,
		TLS_RSA_PSK_WITH_RC4_128_SHA = 146,
		TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147,
		TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148,
		TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149,
		TLS_RSA_WITH_SEED_CBC_SHA = 150,
		TLS_DH_DSS_WITH_SEED_CBC_SHA = 151,
		TLS_DH_RSA_WITH_SEED_CBC_SHA = 152,
		TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153,
		TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154,
		TLS_DH_anon_WITH_SEED_CBC_SHA = 155,
		TLS_RSA_WITH_AES_128_GCM_SHA256 = 156,
		TLS_RSA_WITH_AES_256_GCM_SHA384 = 157,
		TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158,
		TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159,
		TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160,
		TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161,
		TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162,
		TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163,
		TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164,
		TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165,
		TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166,
		TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167,
		TLS_PSK_WITH_AES_128_GCM_SHA256 = 168,
		TLS_PSK_WITH_AES_256_GCM_SHA384 = 169,
		TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170,
		TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171,
		TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172,
		TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173,
		TLS_PSK_WITH_AES_128_CBC_SHA256 = 174,
		TLS_PSK_WITH_AES_256_CBC_SHA384 = 175,
		TLS_PSK_WITH_NULL_SHA256 = 176,
		TLS_PSK_WITH_NULL_SHA384 = 177,
		TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178,
		TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179,
		TLS_DHE_PSK_WITH_NULL_SHA256 = 180,
		TLS_DHE_PSK_WITH_NULL_SHA384 = 181,
		TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182,
		TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183,
		TLS_RSA_PSK_WITH_NULL_SHA256 = 184,
		TLS_RSA_PSK_WITH_NULL_SHA384 = 185,
		TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186,
		TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187,
		TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188,
		TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189,
		TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190,
		TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191,
		TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192,
		TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193,
		TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194,
		TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195,
		TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196,
		TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197,
		TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255,
		TLS_FALLBACK_SCSV = 22016,
		TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153,
		TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154,
		TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155,
		TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156,
		TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157,
		TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158,
		TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159,
		TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160,
		TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161,
		TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162,
		TLS_ECDH_RSA_WITH_NULL_SHA = 49163,
		TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164,
		TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165,
		TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166,
		TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167,
		TLS_ECDHE_RSA_WITH_NULL_SHA = 49168,
		TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169,
		TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170,
		TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171,
		TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172,
		TLS_ECDH_anon_WITH_NULL_SHA = 49173,
		TLS_ECDH_anon_WITH_RC4_128_SHA = 49174,
		TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175,
		TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176,
		TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177,
		TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178,
		TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179,
		TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180,
		TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181,
		TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182,
		TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183,
		TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184,
		TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185,
		TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186,
		TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187,
		TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188,
		TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189,
		TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190,
		TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191,
		TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192,
		TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193,
		TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194,
		TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195,
		TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196,
		TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197,
		TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198,
		TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199,
		TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200,
		TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201,
		TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202,
		TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203,
		TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204,
		TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205,
		TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206,
		TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207,
		TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208,
		TLS_ECDHE_PSK_WITH_NULL_SHA = 49209,
		TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210,
		TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211,
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266,
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267,
		TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268,
		TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269,
		TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270,
		TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271,
		TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272,
		TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273,
		TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274,
		TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275,
		TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276,
		TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277,
		TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278,
		TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279,
		TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280,
		TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281,
		TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282,
		TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283,
		TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284,
		TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285,
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286,
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287,
		TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288,
		TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289,
		TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290,
		TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291,
		TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292,
		TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293,
		TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294,
		TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295,
		TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296,
		TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297,
		TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298,
		TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299,
		TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300,
		TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301,
		TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302,
		TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303,
		TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304,
		TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305,
		TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306,
		TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307,
		TLS_RSA_WITH_AES_128_CCM = 49308,
		TLS_RSA_WITH_AES_256_CCM = 49309,
		TLS_DHE_RSA_WITH_AES_128_CCM = 49310,
		TLS_DHE_RSA_WITH_AES_256_CCM = 49311,
		TLS_RSA_WITH_AES_128_CCM_8 = 49312,
		TLS_RSA_WITH_AES_256_CCM_8 = 49313,
		TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314,
		TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315,
		TLS_PSK_WITH_AES_128_CCM = 49316,
		TLS_PSK_WITH_AES_256_CCM = 49317,
		TLS_DHE_PSK_WITH_AES_128_CCM = 49318,
		TLS_DHE_PSK_WITH_AES_256_CCM = 49319,
		TLS_PSK_WITH_AES_128_CCM_8 = 49320,
		TLS_PSK_WITH_AES_256_CCM_8 = 49321,
		TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322,
		TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323,
		TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52243,
		TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52244,
		TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52245,
		TLS_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58384,
		TLS_RSA_WITH_SALSA20_SHA1 = 58385,
		TLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58386,
		TLS_ECDHE_RSA_WITH_SALSA20_SHA1 = 58387,
		TLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1 = 58388,
		TLS_ECDHE_ECDSA_WITH_SALSA20_SHA1 = 58389,
		TLS_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58390,
		TLS_PSK_WITH_SALSA20_SHA1 = 58391,
		TLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58392,
		TLS_ECDHE_PSK_WITH_SALSA20_SHA1 = 58393,
		TLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58394,
		TLS_RSA_PSK_WITH_SALSA20_SHA1 = 58395,
		TLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58396,
		TLS_DHE_PSK_WITH_SALSA20_SHA1 = 58397,
		TLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58398,
		TLS_DHE_RSA_WITH_SALSA20_SHA1 = 58399
	}

	public class MonoTlsConnectionInfo // TypeDefIndex: 56981
	{
		// Properties
		[CLSCompliant(false)]
		public CipherSuiteCode CipherSuiteCode { get; set; } // 0x0000000183D61390-0x0000000183D613A0 0x0000000183D60960-0x0000000183D60970
		public TlsProtocols ProtocolVersion { get; set; } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
		public string PeerDomainName { get; set; } // 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public MonoTlsConnectionInfo() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override string ToString() => default; // 0x000000018912E5AC-0x000000018912E644
	}

	[Flags]
	public enum MonoSslPolicyErrors // TypeDefIndex: 56982
	{
		None = 0,
		RemoteCertificateNotAvailable = 1,
		RemoteCertificateNameMismatch = 2,
		RemoteCertificateChainErrors = 4
	}

	public delegate bool MonoRemoteCertificateValidationCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, MonoSslPolicyErrors sslPolicyErrors); // TypeDefIndex: 56983; 0x000000018101C850-0x000000018101C870

	public delegate System.Security.Cryptography.X509Certificates.X509Certificate MonoLocalCertificateSelectionCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers); // TypeDefIndex: 56984; 0x000000018101C850-0x000000018101C870

	public abstract class MonoTlsProvider // TypeDefIndex: 56985
	{
		// Properties
		public abstract Guid ID { get; }
		public abstract string Name { get; }
		public abstract bool SupportsSslStream { get; }
		public abstract bool SupportsConnectionInfo { get; }
		public abstract bool SupportsMonoExtensions { get; }
		public abstract SslProtocols SupportedProtocols { get; }
		internal abstract bool SupportsCleanShutdown { get; }
	
		// Constructors
		internal MonoTlsProvider() {} // 0x000000018350B670-0x000000018350B680
	}

	public static class MonoTlsProviderFactory // TypeDefIndex: 56986
	{
		// Methods
		public static MonoTlsProvider GetProvider() => default; // 0x000000018912E644-0x000000018912E680
	}

	public sealed class MonoTlsSettings // TypeDefIndex: 56987
	{
		// Fields
		private bool cloned; // 0x70
		private bool checkCertName; // 0x71
		private bool checkCertRevocationStatus; // 0x72
		private bool? useServicePointManagerCallback; // 0x73
		private bool skipSystemValidators; // 0x75
		private bool callbackNeedsChain; // 0x76
		private ICertificateValidator certificateValidator; // 0x78
		private static MonoTlsSettings defaultSettings; // 0x00
	
		// Properties
		public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public bool? UseServicePointManagerCallback { get => default; set {} } // 0x0000000183D6E7A0-0x0000000183D6E7B0 0x0000000183D6E7C0-0x0000000183D6E7D0
		public bool CallbackNeedsCertificateChain { get => default; } // 0x0000000183D589B0-0x0000000183D589C0 
		public System.DateTime? CertificateValidationTime { get; set; } // 0x0000000183D54E00-0x0000000183D54E10 0x0000000183D54E10-0x0000000183D54E20
		public System.Security.Cryptography.X509Certificates.X509CertificateCollection TrustAnchors { get; set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public object UserSettings { get; set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		internal string[] CertificateSearchPaths { get; set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		internal bool SendCloseNotify { get; set; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x0000000183D4F010-0x0000000183D4F020
		public string[] ClientCertificateIssuers { get; set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public bool DisallowUnauthenticatedCertificateRequest { get; set; } // 0x0000000183D4F7E0-0x0000000183D4F7F0 0x0000000183D4F7F0-0x0000000183D4F800
		public TlsProtocols? EnabledProtocols { get; set; } // 0x0000000183D6E790-0x0000000183D6E7A0 0x0000000183D6E7B0-0x0000000183D6E7C0
		[CLSCompliant(false)]
		public CipherSuiteCode[] EnabledCiphers { get; set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		public static MonoTlsSettings DefaultSettings { get => default; } // 0x000000018912E91C-0x000000018912E998 
		[Obsolete("Do not use outside System.dll!")]
		public ICertificateValidator CertificateValidator { get => default; } // 0x0000000183D4EB20-0x0000000183D4EB30 
	
		// Constructors
		public MonoTlsSettings() {} // 0x0000000183D6E780-0x0000000183D6E790
		private MonoTlsSettings(MonoTlsSettings other) {} // 0x000000018912E798-0x000000018912E91C
	
		// Methods
		public static MonoTlsSettings CopyDefaultSettings() => default; // 0x000000018912E774-0x000000018912E798
		[Obsolete("Do not use outside System.dll!")]
		public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) => default; // 0x000000018912E680-0x000000018912E714
		public MonoTlsSettings Clone() => default; // 0x000000018912E714-0x000000018912E774
	}

	public sealed class TlsException : Exception // TypeDefIndex: 56988
	{
		// Fields
		private Alert alert; // 0x90
	
		// Constructors
		public TlsException() {} // Dummy constructor
		public TlsException(Alert alert) {} // 0x0000000189133258-0x00000001891332D0
		public TlsException(Alert alert, string message) {} // 0x00000001891330E8-0x0000000189133158
		public TlsException(AlertDescription description) {} // 0x00000001891331E0-0x0000000189133258
		public TlsException(AlertDescription description, string message) {} // 0x0000000189133158-0x00000001891331E0
	}

	public enum TlsProtocolCode : short // TypeDefIndex: 56989
	{
		Tls10 = 769,
		Tls11 = 770,
		Tls12 = 771
	}

	[Flags]
	public enum TlsProtocols // TypeDefIndex: 56990
	{
		Zero = 0,
		Tls10Server = 64,
		Tls10Client = 128,
		Tls10 = 192,
		Tls11Server = 256,
		Tls11Client = 512,
		Tls11 = 768,
		Tls12Server = 1024,
		ServerMask = 1344,
		Tls12Client = 2048,
		ClientMask = 2688,
		Tls12 = 3072
	}
}

namespace Mono.Security.Protocol.Ntlm
{
	[Obsolete("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)\' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
	public class ChallengeResponse : IDisposable // TypeDefIndex: 56966
	{
		// Fields
		private static byte[] magic; // 0x00
		private static byte[] nullEncMagic; // 0x08
		private bool _disposed; // 0x10
		private byte[] _challenge; // 0x18
		private byte[] _lmpwd; // 0x20
		private byte[] _ntpwd; // 0x28
	
		// Properties
		public string Password { set {} } // 0x0000000189114948-0x0000000189114C70
		public byte[] Challenge { set {} } // 0x0000000189114828-0x0000000189114948
		public byte[] LM { get => default; } // 0x0000000189114740-0x00000001891147B4 
		public byte[] NT { get => default; } // 0x00000001891147B4-0x0000000189114828 
	
		// Constructors
		public ChallengeResponse() {} // 0x00000001891146D4-0x0000000189114740
		public ChallengeResponse(string password, byte[] challenge) {} // 0x0000000189114688-0x00000001891146D4
		static ChallengeResponse() {} // 0x00000001891145A4-0x0000000189114688
	
		// Methods
		~ChallengeResponse() {} // 0x000000018911407C-0x00000001891140F4
		public void Dispose() {} // 0x0000000189113FB8-0x0000000189114008
		private void Dispose(bool disposing) {} // 0x0000000189114008-0x000000018911407C
		private byte[] GetResponse(byte[] pwd) => default; // 0x00000001891140F4-0x00000001891142A0
		private byte[] PrepareDESKey(byte[] key56bits, int position) => default; // 0x00000001891143C4-0x00000001891145A4
		private byte[] PasswordToKey(string password, int position) => default; // 0x00000001891142A0-0x00000001891143C4
	}

	public static class ChallengeResponse2 // TypeDefIndex: 56967
	{
		// Fields
		private static byte[] magic; // 0x00
		private static byte[] nullEncMagic; // 0x08
	
		// Constructors
		static ChallengeResponse2() {} // 0x0000000189113ED4-0x0000000189113FB8
	
		// Methods
		private static byte[] Compute_LM(string password, byte[] challenge) => default; // 0x0000000189112EA8-0x00000001891130E4
		private static byte[] Compute_NTLM_Password(string password) => default; // 0x00000001891130E4-0x00000001891131E4
		private static byte[] Compute_NTLM(string password, byte[] challenge) => default; // 0x00000001891131E4-0x0000000189113240
		private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) {
			lm = default;
			ntlm = default;
		} // 0x0000000189113240-0x0000000189113414
		private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) => default; // 0x0000000189113414-0x000000018911383C
		public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) {
			lm = default;
			ntlm = default;
		} // 0x000000018911383C-0x0000000189113A04
		private static byte[] GetResponse(byte[] challenge, byte[] pwd) => default; // 0x0000000189113A04-0x0000000189113BBC
		private static byte[] PrepareDESKey(byte[] key56bits, int position) => default; // 0x0000000189113CF4-0x0000000189113ED4
		private static byte[] PasswordToKey(string password, int position) => default; // 0x0000000189113BBC-0x0000000189113CF4
	}

	public abstract class MessageBase // TypeDefIndex: 56968
	{
		// Fields
		private static byte[] header; // 0x00
		private int _type; // 0x10
		private NtlmFlags _flags; // 0x14
	
		// Properties
		public NtlmFlags Flags { get; set; } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
		public int Type { get; } // 0x0000000183D4E340-0x0000000183D4E350 
	
		// Constructors
		protected MessageBase() {} // Dummy constructor
		protected MessageBase(int messageType) {} // 0x00000001810410F0-0x0000000181041100
		static MessageBase() {} // 0x000000018912DC0C-0x000000018912DC98
	
		// Methods
		protected byte[] PrepareMessage(int messageSize) => default; // 0x000000018912DB30-0x000000018912DC0C
		protected virtual void Decode(byte[] message) {} // 0x000000018912D974-0x000000018912DB30
		protected bool CheckHeader(byte[] message) => default; // 0x000000018912D890-0x000000018912D974
		public abstract byte[] GetBytes();
	}

	public enum NtlmAuthLevel // TypeDefIndex: 56969
	{
		LM_and_NTLM = 0,
		LM_and_NTLM_and_try_NTLMv2_Session = 1,
		NTLM_only = 2,
		NTLMv2_only = 3
	}

	[Flags]
	public enum NtlmFlags // TypeDefIndex: 56970
	{
		NegotiateUnicode = 1,
		NegotiateOem = 2,
		RequestTarget = 4,
		NegotiateNtlm = 512,
		NegotiateDomainSupplied = 4096,
		NegotiateWorkstationSupplied = 8192,
		NegotiateAlwaysSign = 32768,
		NegotiateNtlm2Key = 524288,
		Negotiate128 = 536870912,
		Negotiate56 = 2147483647
	}

	public static class NtlmSettings // TypeDefIndex: 56971
	{
		// Fields
		private static NtlmAuthLevel defaultAuthLevel; // 0x00
	
		// Properties
		public static NtlmAuthLevel DefaultAuthLevel { get; } // 0x000000018912E9D4-0x000000018912EA24 
	
		// Constructors
		static NtlmSettings() {} // 0x000000018912E998-0x000000018912E9D4
	}

	public class Type1Message : MessageBase // TypeDefIndex: 56972
	{
		// Fields
		private string _host; // 0x18
		private string _domain; // 0x20
	
		// Properties
		public string Domain { set {} } // 0x00000001891336C8-0x000000018913373C
		public string Host { set {} } // 0x000000018913373C-0x00000001891337B0
	
		// Constructors
		public Type1Message() {} // 0x000000018913365C-0x00000001891336C8
	
		// Methods
		protected override void Decode(byte[] message) {} // 0x00000001891332D0-0x00000001891333B0
		public override byte[] GetBytes() => default; // 0x00000001891333B0-0x000000018913365C
	}

	public class Type2Message : MessageBase // TypeDefIndex: 56973
	{
		// Fields
		private byte[] _nonce; // 0x18
		private string _targetName; // 0x20
		private byte[] _targetInfo; // 0x28
	
		// Properties
		public byte[] Nonce { get => default; } // 0x0000000189133AE8-0x0000000189133B38 
		public string TargetName { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public byte[] TargetInfo { get => default; } // 0x0000000189133B38-0x0000000189133B88 
	
		// Constructors
		public Type2Message() {} // Dummy constructor
		public Type2Message(byte[] message) {} // 0x0000000189133A64-0x0000000189133AE8
	
		// Methods
		~Type2Message() {} // 0x000000018913391C-0x00000001891339A4
		protected override void Decode(byte[] message) {} // 0x00000001891337B0-0x000000018913391C
		public override byte[] GetBytes() => default; // 0x00000001891339A4-0x0000000189133A64
	}

	public class Type3Message : MessageBase // TypeDefIndex: 56974
	{
		// Fields
		private NtlmAuthLevel _level; // 0x18
		private byte[] _challenge; // 0x20
		private string _host; // 0x28
		private string _domain; // 0x30
		private string _username; // 0x38
		private string _password; // 0x40
		private Type2Message _type2; // 0x48
		private byte[] _lm; // 0x50
		private byte[] _nt; // 0x58
	
		// Properties
		public string Domain { set {} } // 0x000000018913476C-0x0000000189134974
		public string Password { set {} } // 0x0000000183CB2D80-0x0000000183CB2D90
		public string Username { set {} } // 0x000000018388FF30-0x000000018388FF40
	
		// Constructors
		public Type3Message() {} // Dummy constructor
		public Type3Message(Type2Message type2) {} // 0x00000001891345D0-0x000000018913476C
	
		// Methods
		~Type3Message() {} // 0x0000000189133E78-0x0000000189133F44
		protected override void Decode(byte[] message) {} // 0x0000000189133BE4-0x0000000189133DFC
		private string DecodeString(byte[] buffer, int offset, int len) => default; // 0x0000000189133B88-0x0000000189133BE4
		private byte[] EncodeString(string text) => default; // 0x0000000189133DFC-0x0000000189133E78
		public override byte[] GetBytes() => default; // 0x0000000189133F44-0x00000001891345D0
	}
}

namespace Mono.Security.X509
{
	internal class SafeBag // TypeDefIndex: 56930
	{
		// Fields
		private string _bagOID; // 0x10
		private ASN1 _asn1; // 0x18
	
		// Properties
		public string BagOID { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public ASN1 ASN1 { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public SafeBag() {} // Dummy constructor
		public SafeBag(string bagOID, ASN1 asn1) {} // 0x0000000182676770-0x00000001826767A0
	}

	public class PKCS12 : ICloneable // TypeDefIndex: 56932
	{
		// Fields
		private byte[] _password; // 0x10
		private ArrayList _keyBags; // 0x18
		private ArrayList _secretBags; // 0x20
		private Mono.Security.X509.X509CertificateCollection _certs; // 0x28
		private bool _keyBagsChanged; // 0x30
		private bool _secretBagsChanged; // 0x31
		private bool _certsChanged; // 0x32
		private int _iterations; // 0x34
		private ArrayList _safeBags; // 0x38
		private RandomNumberGenerator _rng; // 0x40
		private static int password_max_length; // 0x00
	
		// Properties
		public string Password { set {} } // 0x000000018911A3E0-0x000000018911A60C
		public int IterationCount { get => default; set {} } // 0x000000018911654C-0x0000000189116888 0x000000018911B958-0x000000018911C1BC
		public ArrayList Keys { get => default; } // 0x000000018911AC74-0x000000018911B958 
		public Mono.Security.X509.X509CertificateCollection Certificates { get => default; } // 0x0000000189116888-0x00000001891172A8 
		internal RandomNumberGenerator RNG { get => default; } // 0x000000018911AB60-0x000000018911AC74 
		public static int MaximumPasswordLength { get => default; } // 0x0000000189115214-0x0000000189115278 
	
		// Nested types
		public class DeriveBytes // TypeDefIndex: 56931
		{
			// Fields
			private static byte[] keyDiversifier; // 0x00
			private static byte[] ivDiversifier; // 0x08
			private static byte[] macDiversifier; // 0x10
			private string _hashName; // 0x10
			private int _iterations; // 0x18
			private byte[] _password; // 0x20
			private byte[] _salt; // 0x28
	
			// Properties
			public string HashName { set {} } // 0x000000018911C62C-0x000000018911C668
			public int IterationCount { set {} } // 0x000000018911C5E0-0x000000018911C62C
			public byte[] Password { set {} } // 0x000000018911746C-0x0000000189117D5C
			public byte[] Salt { set {} } // 0x0000000189118354-0x0000000189118428
	
			// Constructors
			public DeriveBytes() {} // 0x000000018911C668-0x000000018911C774
			static DeriveBytes() {} // 0x000000018911D148-0x000000018911D17C
	
			// Methods
			private void Adjust(byte[] a, int aOff, byte[] b) {} // 0x000000018911D17C-0x000000018911D2D8
			private byte[] Derive(byte[] diversifier, int n) => default; // 0x0000000183D4EE00-0x0000000183D4EE10
			public byte[] DeriveKey(int size) => default; // 0x0000000183D4EE40-0x0000000183D4EE50
			public byte[] DeriveIV(int size) => default; // 0x000000018911CB44-0x000000018911D0F8
			public byte[] DeriveMAC(int size) => default; // 0x000000018911C774-0x000000018911CB44
		}
	
		// Constructors
		public PKCS12() {} // 0x000000018911740C-0x000000018911746C
		public PKCS12(byte[] data) {} // 0x000000018911A60C-0x000000018911AB60
		public PKCS12(byte[] data, string password) {} // 0x0000000189117E30-0x0000000189117F14
		static PKCS12() {} // 0x0000000189115678-0x00000001891157BC
	
		// Methods
		private void Decode(byte[] data) {} // 0x0000000189117D5C-0x0000000189117E30
		~PKCS12() {} // 0x0000000189117F14-0x0000000189118034
		private bool Compare(byte[] expected, byte[] actual) => default; // 0x0000000189118428-0x000000018911A3E0
		private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) => default; // 0x0000000189118034-0x0000000189118354
		public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) => default; // 0x0000000189115F80-0x0000000189115F8C
		public byte[] Decrypt(PKCS7.EncryptedData ed) => default; // 0x0000000189115F8C-0x00000001891161C4
		public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) => default; // 0x000000018911C598-0x000000018911C5A4
		private DSAParameters GetExistingParameters(out bool found) {
			found = default;
			return default;
		} // 0x000000018911C1BC-0x000000018911C598
		private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) {} // 0x0000000189117384-0x000000018911740C
		private void ReadSafeBag(ASN1 safeBag) {} // 0x00000001891161C4-0x000000018911654C
		private ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes) => default; // 0x00000001891172A8-0x0000000189117384
		private ASN1 CertificateSafeBag(Mono.Security.X509.X509Certificate x509, IDictionary attributes) => default; // 0x000000018911D0F8-0x000000018911D148
		private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) => default; // 0x000000018911C5A4-0x000000018911C5E0
		public byte[] GetBytes() => default; // 0x000000018350B670-0x000000018350B680
		private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) => default; // 0x000000018426FEE0-0x000000018426FEF0
		public void AddCertificate(Mono.Security.X509.X509Certificate cert) {} // 0x0000000183D4E9C0-0x0000000183D4E9D0
		public void AddCertificate(Mono.Security.X509.X509Certificate cert, IDictionary attributes) {} // 0x00000001891157BC-0x0000000189115848
		public void RemoveCertificate(Mono.Security.X509.X509Certificate cert) {} // 0x0000000189115848-0x00000001891158C4
		public void RemoveCertificate(Mono.Security.X509.X509Certificate cert, IDictionary attrs) {} // 0x000000018911508C-0x0000000189115150
		private bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2) => default; // 0x0000000189115278-0x0000000189115678
		public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes) {} // 0x00000001891151B4-0x0000000189115214
		public object Clone() => default; // 0x0000000189115150-0x00000001891151B4
	}

	public sealed class X501 // TypeDefIndex: 56933
	{
		// Fields
		private static byte[] countryName; // 0x00
		private static byte[] organizationName; // 0x08
		private static byte[] organizationalUnitName; // 0x10
		private static byte[] commonName; // 0x18
		private static byte[] localityName; // 0x20
		private static byte[] stateOrProvinceName; // 0x28
		private static byte[] streetAddress; // 0x30
		private static byte[] serialNumber; // 0x38
		private static byte[] domainComponent; // 0x40
		private static byte[] userid; // 0x48
		private static byte[] email; // 0x50
		private static byte[] dnQualifier; // 0x58
		private static byte[] title; // 0x60
		private static byte[] surname; // 0x68
		private static byte[] givenName; // 0x70
		private static byte[] initial; // 0x78
	
		// Constructors
		public X501() {} // Dummy constructor
		static X501() {} // 0x000000018911FEAC-0x0000000189120470
	
		// Methods
		public static string ToString(ASN1 seq) => default; // 0x000000018911FDAC-0x000000018911FEAC
		public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes) => default; // 0x000000018911FC40-0x000000018911FDAC
		private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) {} // 0x000000018911E120-0x000000018911E9B8
		private static X520.AttributeTypeAndValue GetAttributeFromOid(string attributeType) => default; // 0x000000018911EB38-0x000000018911F308
		private static bool IsOid(string oid) => default; // 0x000000018911F3A8-0x000000018911F434
		private static X520.AttributeTypeAndValue ReadAttribute(string value, ref int pos) => default; // 0x000000018911F434-0x000000018911F5A8
		private static bool IsHex(char c) => default; // 0x000000018911F308-0x000000018911F3A8
		private static string ReadHex(string value, ref int pos) => default; // 0x000000018911F730-0x000000018911F8B4
		private static int ReadEscaped(StringBuilder sb, string value, int pos) => default; // 0x000000018911F5A8-0x000000018911F730
		private static int ReadQuoted(StringBuilder sb, string value, int pos) => default; // 0x000000018911F8B4-0x000000018911F9EC
		private static string ReadValue(string value, ref int pos) => default; // 0x000000018911F9EC-0x000000018911FC40
		public static ASN1 FromString(string rdn) => default; // 0x000000018911E9B8-0x000000018911EB38
	}

	[DefaultMember("Item")]
	public class X509Crl // TypeDefIndex: 56935
	{
		// Fields
		private string issuer; // 0x10
		private byte version; // 0x18
		private System.DateTime thisUpdate; // 0x20
		private System.DateTime nextUpdate; // 0x28
		private ArrayList entries; // 0x30
		private string signatureOID; // 0x38
		private byte[] signature; // 0x40
		private Mono.Security.X509.X509ExtensionCollection extensions; // 0x48
		private byte[] encoded; // 0x50
		private byte[] hash_value; // 0x58
	
		// Properties
		public Mono.Security.X509.X509ExtensionCollection Extensions { get => default; } // 0x00000001891205B8-0x0000000189120610 
		public byte[] Hash { get => default; } // 0x0000000189123350-0x00000001891233D4 
		public string IssuerName { get => default; } // 0x00000001891233D4-0x00000001891234F0 
		public System.DateTime NextUpdate { get => default; } // 0x0000000189123D6C-0x0000000189124010 
	
		// Nested types
		public class X509CrlEntry // TypeDefIndex: 56934
		{
			// Fields
			private byte[] sn; // 0x10
			private System.DateTime revocationDate; // 0x18
			private Mono.Security.X509.X509ExtensionCollection extensions; // 0x20
	
			// Properties
			public byte[] SerialNumber { get => default; } // 0x00000001891234F0-0x0000000189123B34 
			public System.DateTime RevocationDate { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
			public Mono.Security.X509.X509ExtensionCollection Extensions { get => default; } // 0x00000001891240E4-0x000000018912428C 
	
			// Constructors
			public X509CrlEntry() {} // Dummy constructor
			internal X509CrlEntry(ASN1 entry) {} // 0x0000000189124010-0x00000001891240E4
		}
	
		// Constructors
		public X509Crl() {} // Dummy constructor
		public X509Crl(byte[] crl) {} // 0x00000001820B7B20-0x00000001820B7B30
	
		// Methods
		private void Parse(byte[] crl) {} // 0x0000000183D4EAC0-0x0000000183D4EAD0
		private bool Compare(byte[] array1, byte[] array2) => default; // 0x0000000189123CAC-0x0000000189123D6C
		public X509CrlEntry GetCrlEntry(Mono.Security.X509.X509Certificate x509) => default; // 0x0000000189123B34-0x0000000189123CAC
		public X509CrlEntry GetCrlEntry(byte[] serialNumber) => default; // 0x0000000189123208-0x0000000189123300
		internal bool VerifySignature(DSA dsa) => default; // 0x0000000189123300-0x0000000189123350
		internal bool VerifySignature(RSA rsa) => default; // 0x0000000181041090-0x00000001810410A0
		public bool VerifySignature(AsymmetricAlgorithm aa) => default; // 0x0000000183D4EB40-0x0000000183D4EB50
	}

	public class X509Certificate : ISerializable // TypeDefIndex: 56936
	{
		// Fields
		private ASN1 decoder; // 0x10
		private byte[] m_encodedcert; // 0x18
		private System.DateTime m_from; // 0x20
		private System.DateTime m_until; // 0x28
		private ASN1 issuer; // 0x30
		private string m_issuername; // 0x38
		private string m_keyalgo; // 0x40
		private byte[] m_keyalgoparams; // 0x48
		private ASN1 subject; // 0x50
		private string m_subject; // 0x58
		private byte[] m_publickey; // 0x60
		private byte[] signature; // 0x68
		private string m_signaturealgo; // 0x70
		private byte[] m_signaturealgoparams; // 0x78
		private byte[] certhash; // 0x80
		private RSA _rsa; // 0x88
		private DSA _dsa; // 0x90
		private int version; // 0x98
		private byte[] serialnumber; // 0xA0
		private byte[] issuerUniqueID; // 0xA8
		private byte[] subjectUniqueID; // 0xB0
		private Mono.Security.X509.X509ExtensionCollection extensions; // 0xB8
		private static string encoding_error; // 0x00
	
		// Properties
		public DSA DSA { get => default; set {} } // 0x0000000189121A8C-0x0000000189121DD0 0x00000001891227F0-0x0000000189122834
		public Mono.Security.X509.X509ExtensionCollection Extensions { get => default; } // 0x0000000183D4E750-0x0000000183D4E760 
		public byte[] Hash { get => default; } // 0x0000000189121DD0-0x0000000189121FEC 
		public virtual string IssuerName { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public virtual string KeyAlgorithm { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public virtual byte[] KeyAlgorithmParameters { get => default; set {} } // 0x0000000189122124-0x0000000189122178 0x0000000182692290-0x00000001826922A0
		public virtual byte[] PublicKey { get => default; } // 0x0000000189122178-0x00000001891221CC 
		public virtual RSA RSA { get => default; set {} } // 0x00000001891221CC-0x00000001891223AC 0x0000000189122834-0x0000000189122874
		public virtual byte[] RawData { get => default; } // 0x00000001891223AC-0x0000000189122400 
		public virtual byte[] SerialNumber { get => default; } // 0x0000000189122400-0x0000000189122458 
		public virtual byte[] Signature { get => default; } // 0x0000000189122458-0x00000001891227F0 
		public virtual string SubjectName { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		public virtual System.DateTime ValidFrom { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public virtual System.DateTime ValidUntil { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public int Version { get => default; } // 0x0000000183D4EB50-0x0000000183D4EB60 
		public bool IsCurrent { get => default; } // 0x0000000189121FEC-0x0000000189122038 
		public bool IsSelfSigned { get => default; } // 0x0000000189122038-0x0000000189122124 
	
		// Constructors
		public X509Certificate() {} // Dummy constructor
		public X509Certificate(byte[] data) {} // 0x0000000189121910-0x0000000189121A8C
		static X509Certificate() {} // 0x00000001891218B4-0x0000000189121910
	
		// Methods
		private void Parse(byte[] data) {} // 0x0000000189120C18-0x000000018912150C
		private byte[] GetUnsignedBigInteger(byte[] integer) => default; // 0x0000000189120A78-0x0000000189120B10
		public bool WasCurrent(System.DateTime instant) => default; // 0x0000000189121830-0x00000001891218B4
		internal bool VerifySignature(DSA dsa) => default; // 0x000000018912177C-0x0000000189121830
		internal bool VerifySignature(RSA rsa) => default; // 0x0000000189121684-0x000000018912177C
		public bool VerifySignature(AsymmetricAlgorithm aa) => default; // 0x000000018912150C-0x0000000189121684
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000189120A20-0x0000000189120A78
		private static byte[] PEM(string type, byte[] data) => default; // 0x0000000189120B10-0x0000000189120C18
	}

	[Serializable]
	public class X509CertificateCollection : CollectionBase, IEnumerable // TypeDefIndex: 56938
	{
		// Properties
		public Mono.Security.X509.X509Certificate this[int index] { get => default; } // 0x0000000186FAB9A8-0x0000000186FAB9CC 
	
		// Nested types
		public class X509CertificateEnumerator : IEnumerator // TypeDefIndex: 56937
		{
			// Fields
			private IEnumerator enumerator; // 0x10
	
			// Properties
			public Mono.Security.X509.X509Certificate Current { get => default; } // 0x00000001891207D0-0x0000000189120830 
			object IEnumerator.Current { get => default; } // 0x000000018912053C-0x00000001891205B8 
	
			// Constructors
			public X509CertificateEnumerator() {} // Dummy constructor
			public X509CertificateEnumerator(X509CertificateCollection mappings) {} // 0x00000001891207C8-0x00000001891207D0
	
			// Methods
			bool IEnumerator.MoveNext() => default; // 0x0000000189120470-0x000000018912053C
			void IEnumerator.Reset() {} // 0x0000000189120610-0x0000000189120628
			public bool MoveNext() => default; // 0x0000000189120628-0x0000000189120688
		}
	
		// Constructors
		public X509CertificateCollection() {} // 0x00000001891207A4-0x00000001891207C8
	
		// Methods
		public int Add(Mono.Security.X509.X509Certificate value) => default; // 0x0000000189120688-0x00000001891207A4
		public void AddRange(X509CertificateCollection value) {} // 0x00000001891205B8-0x0000000189120610
		public bool Contains(Mono.Security.X509.X509Certificate value) => default; // 0x0000000189120958-0x00000001891209B8
		public new X509CertificateEnumerator GetEnumerator() => default; // 0x00000001891209B8-0x0000000189120A20
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018912090C-0x0000000189120958
		public override int GetHashCode() => default; // 0x0000000189120878-0x00000001891208C0
		public int IndexOf(Mono.Security.X509.X509Certificate value) => default; // 0x00000001891208C0-0x000000018912090C
		private bool Compare(byte[] array1, byte[] array2) => default; // 0x0000000189120830-0x0000000189120878
	}

	public class X509Chain // TypeDefIndex: 56939
	{
		// Fields
		private Mono.Security.X509.X509CertificateCollection roots; // 0x10
		private Mono.Security.X509.X509CertificateCollection certs; // 0x18
		private Mono.Security.X509.X509Certificate _root; // 0x20
		private Mono.Security.X509.X509CertificateCollection _chain; // 0x28
		private Mono.Security.X509.X509ChainStatusFlags _status; // 0x30
	
		// Properties
		public Mono.Security.X509.X509CertificateCollection TrustAnchors { get => default; } // 0x0000000189123178-0x0000000189123208 
	
		// Constructors
		public X509Chain() {} // 0x0000000189123114-0x0000000189123178
	
		// Methods
		public void LoadCertificates(Mono.Security.X509.X509CertificateCollection collection) {} // 0x00000001891230A8-0x00000001891230C8
		public bool Build(Mono.Security.X509.X509Certificate leaf) => default; // 0x0000000189122874-0x0000000189122BDC
		public void Reset() {} // 0x00000001891230C8-0x0000000189123114
		private bool IsValid(Mono.Security.X509.X509Certificate cert) => default; // 0x0000000189123038-0x00000001891230A8
		private Mono.Security.X509.X509Certificate FindCertificateParent(Mono.Security.X509.X509Certificate child) => default; // 0x0000000189122BDC-0x0000000189122D24
		private Mono.Security.X509.X509Certificate FindCertificateRoot(Mono.Security.X509.X509Certificate potentialRoot) => default; // 0x0000000189122D24-0x0000000189122ED8
		private bool IsTrusted(Mono.Security.X509.X509Certificate potentialTrusted) => default; // 0x0000000189123008-0x0000000189123038
		private bool IsParent(Mono.Security.X509.X509Certificate child, Mono.Security.X509.X509Certificate parent) => default; // 0x0000000189122ED8-0x0000000189123008
	}

	[Serializable]
	[Flags]
	public enum X509ChainStatusFlags // TypeDefIndex: 56940
	{
		NoError = 0,
		NotTimeValid = 1,
		NotTimeNested = 2,
		NotSignatureValid = 8,
		UntrustedRoot = 32,
		InvalidBasicConstraints = 1024,
		PartialChain = 65536
	}

	public class X509Extension // TypeDefIndex: 56941
	{
		// Fields
		protected string extnOid; // 0x10
		protected bool extnCritical; // 0x18
		protected ASN1 extnValue; // 0x20
	
		// Properties
		public string Oid { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public bool Critical { get => default; } // 0x0000000181002A50-0x0000000181002A60 
		public ASN1 Value { get => default; } // 0x0000000189124DA0-0x0000000189124DD0 
	
		// Constructors
		public X509Extension() {} // Dummy constructor
		public X509Extension(ASN1 asn1) {} // 0x0000000189124944-0x0000000189124C4C
		public X509Extension(X509Extension extension) {} // 0x0000000189124C4C-0x0000000189124DA0
	
		// Methods
		protected virtual void Decode() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void Encode() {} // 0x000000018350B670-0x000000018350B680
		public override bool Equals(object obj) => default; // 0x0000000189124554-0x0000000189124660
		public override int GetHashCode() => default; // 0x0000000186FAB9A8-0x0000000186FAB9CC
		private void WriteLine(StringBuilder sb, int n, int pos) {} // 0x0000000189124760-0x0000000189124944
		public override string ToString() => default; // 0x0000000189124660-0x0000000189124760
	}

	public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 56942
	{
		// Fields
		private bool readOnly; // 0x18
	
		// Properties
		public Mono.Security.X509.X509Extension this[string oid] { get => default; } // 0x00000001891244D8-0x0000000189124554 
	
		// Constructors
		public X509ExtensionCollection() {} // 0x00000001891207C8-0x00000001891207D0
		public X509ExtensionCollection(ASN1 asn1) {} // 0x00000001891243B0-0x00000001891244D8
	
		// Methods
		public int IndexOf(string oid) => default; // 0x000000018912428C-0x00000001891243B0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001891207A4-0x00000001891207C8
	}

	public class X509Store // TypeDefIndex: 56943
	{
		// Fields
		private string _storePath; // 0x10
		private Mono.Security.X509.X509CertificateCollection _certificates; // 0x18
		private ArrayList _crls; // 0x20
		private bool _crl; // 0x28
		private bool _newFormat; // 0x29
	
		// Properties
		public Mono.Security.X509.X509CertificateCollection Certificates { get => default; } // 0x0000000189125AC0-0x0000000189125AFC 
		public ArrayList Crls { get => default; } // 0x0000000189125AFC-0x0000000189125B90 
	
		// Constructors
		public X509Store() {} // Dummy constructor
		internal X509Store(string path, bool crl, bool newFormat) {} // 0x0000000189125A98-0x0000000189125AC0
	
		// Methods
		private byte[] Load(string filename) => default; // 0x000000018912595C-0x0000000189125A98
		private Mono.Security.X509.X509Certificate LoadCertificate(string filename) => default; // 0x0000000189125874-0x00000001891258E8
		private X509Crl LoadCrl(string filename) => default; // 0x00000001891258E8-0x000000018912595C
		private bool CheckStore(string path, bool throwException) => default; // 0x00000001891257BC-0x0000000189125874
		private Mono.Security.X509.X509CertificateCollection BuildCertificatesCollection(string storeName) => default; // 0x0000000189125460-0x0000000189125618
		private ArrayList BuildCrlsCollection(string storeName) => default; // 0x0000000189125618-0x00000001891257BC
	}

	public sealed class X509StoreManager // TypeDefIndex: 56944
	{
		// Fields
		private static string _userPath; // 0x00
		private static string _localMachinePath; // 0x08
		private static string _newUserPath; // 0x10
		private static string _newLocalMachinePath; // 0x18
		private static X509Stores _userStore; // 0x20
		private static X509Stores _machineStore; // 0x28
	
		// Properties
		internal static string CurrentUserPath { get => default; } // 0x0000000189124DD0-0x0000000189124ED8 
		internal static string LocalMachinePath { get => default; } // 0x0000000189124F9C-0x00000001891250B4 
		internal static string NewCurrentUserPath { get => default; } // 0x0000000189125178-0x0000000189125290 
		internal static string NewLocalMachinePath { get => default; } // 0x0000000189125290-0x00000001891253A8 
		public static X509Stores CurrentUser { get => default; } // 0x0000000189124ED8-0x0000000189124F9C 
		public static X509Stores LocalMachine { get => default; } // 0x00000001891250B4-0x0000000189125178 
		public static Mono.Security.X509.X509CertificateCollection TrustedRootCertificates { get => default; } // 0x00000001891253A8-0x0000000189125460 
	
		// Constructors
		public X509StoreManager() {} // Dummy constructor
	}

	public class X509Stores // TypeDefIndex: 56945
	{
		// Fields
		private string _storePath; // 0x10
		private bool _newFormat; // 0x18
		private Mono.Security.X509.X509Store _trusted; // 0x20
	
		// Properties
		public Mono.Security.X509.X509Store TrustedRoot { get => default; } // 0x0000000189125CA0-0x0000000189125D74 
	
		// Constructors
		public X509Stores() {} // Dummy constructor
		internal X509Stores(string path, bool newFormat) {} // 0x00000001825E7390-0x00000001825E73C0
	
		// Methods
		public Mono.Security.X509.X509Store Open(string storeName, bool create) => default; // 0x0000000189125B90-0x0000000189125CA0
	}

	public class X520 // TypeDefIndex: 56963
	{
		// Nested types
		public abstract class AttributeTypeAndValue // TypeDefIndex: 56946
		{
			// Fields
			private string oid; // 0x10
			private string attrValue; // 0x18
			private int upperBound; // 0x20
			private byte encoding; // 0x24
	
			// Properties
			public string Value { get; set; } // 0x0000000189112180-0x0000000189112248
	
			// Constructors
			protected AttributeTypeAndValue() {} // Dummy constructor
			protected AttributeTypeAndValue(string oid, int upperBound) {} // 0x0000000189112134-0x000000018911215C
			protected AttributeTypeAndValue(string oid, int upperBound, byte encoding) {} // 0x000000018911215C-0x0000000189112180
	
			// Methods
			internal ASN1 GetASN1(byte encoding) => default; // 0x0000000189111F5C-0x00000001891120E0
			internal ASN1 GetASN1() => default; // 0x0000000189111F50-0x0000000189111F5C
			private byte SelectBestEncoding() => default; // 0x00000001891120E0-0x0000000189112134
		}
	
		public class CommonName : AttributeTypeAndValue // TypeDefIndex: 56947
		{
			// Constructors
			public CommonName() {} // 0x0000000189114C70-0x0000000189114CB4
		}
	
		public class SerialNumber : AttributeTypeAndValue // TypeDefIndex: 56948
		{
			// Constructors
			public SerialNumber() {} // 0x000000018911D2D8-0x000000018911D324
		}
	
		public class LocalityName : AttributeTypeAndValue // TypeDefIndex: 56949
		{
			// Constructors
			public LocalityName() {} // 0x0000000189115EA4-0x0000000189115EE8
		}
	
		public class StateOrProvinceName : AttributeTypeAndValue // TypeDefIndex: 56950
		{
			// Constructors
			public StateOrProvinceName() {} // 0x000000018911E010-0x000000018911E054
		}
	
		public class OrganizationName : AttributeTypeAndValue // TypeDefIndex: 56951
		{
			// Constructors
			public OrganizationName() {} // 0x0000000189115EF8-0x0000000189115F3C
		}
	
		public class OrganizationalUnitName : AttributeTypeAndValue // TypeDefIndex: 56952
		{
			// Constructors
			public OrganizationalUnitName() {} // 0x0000000189115F3C-0x0000000189115F80
		}
	
		public class EmailAddress : AttributeTypeAndValue // TypeDefIndex: 56953
		{
			// Constructors
			public EmailAddress() {} // 0x000000018911595C-0x00000001891159A8
		}
	
		public class DomainComponent : AttributeTypeAndValue // TypeDefIndex: 56954
		{
			// Constructors
			public DomainComponent() {} // 0x0000000189115910-0x000000018911595C
		}
	
		public class UserId : AttributeTypeAndValue // TypeDefIndex: 56955
		{
			// Constructors
			public UserId() {} // 0x000000018911E0DC-0x000000018911E120
		}
	
		public class Oid : AttributeTypeAndValue // TypeDefIndex: 56956
		{
			// Constructors
			public Oid() {} // Dummy constructor
			public Oid(string oid) {} // 0x0000000189115EE8-0x0000000189115EF8
		}
	
		public class Title : AttributeTypeAndValue // TypeDefIndex: 56957
		{
			// Constructors
			public Title() {} // 0x000000018911E098-0x000000018911E0DC
		}
	
		public class CountryName : AttributeTypeAndValue // TypeDefIndex: 56958
		{
			// Constructors
			public CountryName() {} // 0x0000000189115040-0x000000018911508C
		}
	
		public class DnQualifier : AttributeTypeAndValue // TypeDefIndex: 56959
		{
			// Constructors
			public DnQualifier() {} // 0x00000001891158C4-0x0000000189115910
		}
	
		public class Surname : AttributeTypeAndValue // TypeDefIndex: 56960
		{
			// Constructors
			public Surname() {} // 0x000000018911E054-0x000000018911E098
		}
	
		public class GivenName : AttributeTypeAndValue // TypeDefIndex: 56961
		{
			// Constructors
			public GivenName() {} // 0x0000000189115E1C-0x0000000189115E60
		}
	
		public class Initial : AttributeTypeAndValue // TypeDefIndex: 56962
		{
			// Constructors
			public Initial() {} // 0x0000000189115E60-0x0000000189115EA4
		}
	
		// Constructors
		public X520() {} // Dummy constructor
	}
}

namespace Mono.Security.X509.Extensions
{
	public class AuthorityKeyIdentifierExtension : Mono.Security.X509.X509Extension // TypeDefIndex: 56964
	{
		// Fields
		private byte[] aki; // 0x28
	
		// Properties
		public byte[] Identifier { get => default; } // 0x0000000189112600-0x0000000189112654 
	
		// Constructors
		public AuthorityKeyIdentifierExtension() {} // Dummy constructor
		public AuthorityKeyIdentifierExtension(Mono.Security.X509.X509Extension extension) {} // 0x00000001891125F8-0x0000000189112600
	
		// Methods
		protected override void Decode() {} // 0x0000000189112248-0x0000000189112364
		protected override void Encode() {} // 0x0000000189112364-0x00000001891124A8
		public override string ToString() => default; // 0x00000001891124A8-0x00000001891125F8
	}

	public class BasicConstraintsExtension : Mono.Security.X509.X509Extension // TypeDefIndex: 56965
	{
		// Fields
		private bool cA; // 0x28
		private int pathLenConstraint; // 0x2C
	
		// Properties
		public bool CertificateAuthority { get => default; } // 0x0000000183D4ED50-0x0000000183D4ED60 
	
		// Constructors
		public BasicConstraintsExtension() {} // Dummy constructor
		public BasicConstraintsExtension(Mono.Security.X509.X509Extension extension) {} // 0x00000001891125F8-0x0000000189112600
	
		// Methods
		protected override void Decode() {} // 0x0000000189112654-0x000000018911279C
		protected override void Encode() {} // 0x000000018911279C-0x00000001891128E4
		public override string ToString() => default; // 0x00000001891128E4-0x0000000189112A3C
	}
}
