/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using Beyond.Byte;
using IFix.Core;

// Image 92: Beyond.Byte.dll - Assembly: Beyond.Byte, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59425-59432
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Byte
{
	[Serializable]
	public struct UInt128 : IComparable<Beyond.Byte.UInt128>, IEquatable<Beyond.Byte.UInt128> // TypeDefIndex: 59426
	{
		// Fields
		public ulong high; // 0x00
		public ulong low; // 0x08
	
		// Constructors
		public UInt128(ulong high, ulong low) {
			this.high = default;
			this.low = default;
		} // 0x0000000183D4EA10-0x0000000183D4EA20
		public UInt128(byte[] bytes) {
			high = default;
			low = default;
		} // 0x000000018515A1C4-0x000000018515A200
	
		// Methods
		[IDTag(1)]
		public override bool Equals(object obj) => default; // 0x0000000185159ED4-0x0000000185159F78
		public override int GetHashCode() => default; // 0x0000000185159F78-0x000000018515A014
		public static implicit operator UInt128(byte[] bytes) => default; // 0x000000018515A280-0x000000018515A2F4
		public Guid ToGuid() => default; // 0x000000018515A014-0x000000018515A114
		public int CompareTo(UInt128 other) => default; // 0x0000000185159DE0-0x0000000185159E60
		[IDTag(0)]
		public bool Equals(UInt128 other) => default; // 0x0000000185159E60-0x0000000185159ED4
		public static bool operator ==(UInt128 a, UInt128 b) => default; // 0x000000018515A200-0x000000018515A280
		public static bool operator !=(UInt128 a, UInt128 B) => default; // 0x000000018515A2F4-0x000000018515A384
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x000000018515A114-0x000000018515A174
		public int __iFixBaseProxy_GetHashCode() => default; // 0x000000018515A174-0x000000018515A1C4
	}

	public struct ByteBufStream // TypeDefIndex: 59427
	{
		// Fields
		public int currentIdx; // 0x00
		public byte[] datas; // 0x08
	
		// Methods
		public int GetCurrentIdx() => default; // 0x0000000182431680-0x0000000182431700
		public byte[] GetRaw() => default; // 0x0000000185154E1C-0x0000000185154E68
		public byte[] GetDataCopy() => default; // 0x0000000185154D8C-0x0000000185154E1C
		public uint ReadUInt() => default; // 0x0000000185154E68-0x0000000185154EC4
		public int ReadInt() => default; // 0x000000018242F7E0-0x000000018242FA00
		public int ReadByte() => default; // 0x000000018242FDA0-0x000000018242FEE0
		public ulong ReadULong() => default; // 0x0000000185154EC4-0x0000000185154F20
		public long ReadLong() => default; // 0x0000000182431160-0x0000000182431290
		public Beyond.Byte.UInt128 ReadUInt128() => default; // 0x000000018242FF90-0x0000000182430100
		public string ReadUTF8() => default; // 0x000000018242EE30-0x000000018242EE80
		public void SkipReadUTF8() {} // 0x0000000182431700-0x0000000182431970
		public void WriteByte(byte val) {} // 0x0000000185154F8C-0x0000000185154FF0
		public void WriteUInt(uint val) {} // 0x0000000185155134-0x00000001851551A0
		public void WriteInt(int val) {} // 0x0000000185154FF0-0x0000000185155050
		public void WriteULong(ulong val) {} // 0x00000001851551A0-0x000000018515520C
		public void WriteLong(long val) {} // 0x0000000185155050-0x00000001851550B0
		public void WriteUInt128(Beyond.Byte.UInt128 val) {} // 0x00000001851550B0-0x0000000185155134
		public void WriteUTF8(string val) {} // 0x000000018515520C-0x0000000185155284
		public void SkipBytes(int offset) {} // 0x0000000185154F20-0x0000000185154F8C
		public int RemainBytes() => default; // 0x000000018242DDA0-0x000000018242DDE0
		public static ByteBufStream CreateFromByte(byte[] bs, int startIdx = 0 /* Metadata: 0x01FDD061 */) => default; // 0x000000018242EDC0-0x000000018242EE30
		public static ByteBufStream Create(int cap) => default; // 0x0000000185154CE4-0x0000000185154D8C
	}

	public static class ByteHelper // TypeDefIndex: 59428
	{
		// Methods
		public static void SplitLong(long longValue, out int highInt, out int lowInt) {
			highInt = default;
			lowInt = default;
		} // 0x0000000185155758-0x00000001851557C8
		public static long MergeLong(int highInt, int lowInt) => default; // 0x0000000185155618-0x0000000185155674
		public static int SingleToInt32Bits(float value) => default; // 0x0000000185155704-0x0000000185155758
		public static float Int32BitsToSingle(int value) => default; // 0x00000001851555D0-0x0000000185155618
	
		// Extension methods
		public static Beyond.Byte.UInt128 ReadUInt128(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x01FDD062 */) => default; // 0x0000000182431340-0x0000000182431430
		public static long ReadLong(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x01FDD063 */) => default; // 0x0000000182431290-0x0000000182431340
		public static ulong ReadULong(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x01FDD064 */) => default; // 0x0000000182431430-0x00000001824315D0
		public static uint ReadUInt(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x01FDD065 */) => default; // 0x000000018242FBA0-0x000000018242FCC0
		public static int ReadInt(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x01FDD066 */) => default; // 0x000000018242FA00-0x000000018242FBA0
		public static ushort ReadUShort(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x01FDD067 */) => default; // 0x000000018242FCC0-0x000000018242FDA0
		public static short ReadShort(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x01FDD068 */) => default; // 0x000000018242F670-0x000000018242F7E0
		public static byte ReadByte(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x01FDD069 */) => default; // 0x000000018242FEE0-0x000000018242FF90
		public static float ReadFloat(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x01FDD06A */) => default; // 0x0000000185155674-0x0000000185155704
		public static string ReadUTF8(this byte[] bs, int startIndex, out short len) {
			len = default;
			return default;
		} // 0x000000018242EE80-0x000000018242EF30
		public static void SkipReadUTF8(this byte[] bs, int startIndex, out short len) {
			len = default;
		} // 0x000000018242F240-0x000000018242F430
		public static byte[] WriteByte(this byte[] data, int writerIndex, byte value) => default; // 0x00000001851557C8-0x0000000185155844
		public static byte[] WriteUShort(this byte[] data, int writerIndex, ushort value, bool bIsLittle = true /* Metadata: 0x01FDD06B */) => default; // 0x00000001824D2330-0x00000001824D23C0
		public static byte[] WriteShort(this byte[] data, int writerIndex, short value, bool bIsLittle = true /* Metadata: 0x01FDD06C */) => default; // 0x000000018515595C-0x00000001851559EC
		[IDTag(0)]
		public static byte[] WriteUInt(this byte[] data, int writerIndex, uint value, bool bIsLittle = true /* Metadata: 0x01FDD06D */) => default; // 0x00000001824D23C0-0x00000001824D2620
		[IDTag(1)]
		public static Span<byte> WriteUInt(this Span<byte> data, int writerIndex, uint value, bool bIsLittle = true /* Metadata: 0x01FDD06E */) => default; // 0x00000001823A90D0-0x00000001823A9240
		public static byte[] WriteInt(this byte[] data, int writerIndex, int value, bool bIsLittle = true /* Metadata: 0x01FDD06F */) => default; // 0x00000001824D22C0-0x00000001824D2330
		[IDTag(0)]
		public static byte[] WriteULong(this byte[] data, int writerIndex, ulong value, bool bIsLittle = true /* Metadata: 0x01FDD070 */) => default; // 0x0000000185155AA0-0x0000000185155C98
		[IDTag(1)]
		public static Span<byte> WriteULong(this Span<byte> data, int writerIndex, ulong value, bool bIsLittle = true /* Metadata: 0x01FDD071 */) => default; // 0x00000001823A86A0-0x00000001823A8880
		public static byte[] WriteLong(this byte[] data, int writerIndex, long value, bool bIsLittle = true /* Metadata: 0x01FDD072 */) => default; // 0x00000001851558D0-0x000000018515595C
		[IDTag(0)]
		public static byte[] WriteUInt128(this byte[] data, int writerIndex, Beyond.Byte.UInt128 value, bool bIsLittle = true /* Metadata: 0x01FDD073 */) => default; // 0x00000001851559EC-0x0000000185155AA0
		[IDTag(1)]
		public static Span<byte> WriteUInt128(this Span<byte> data, int writerIndex, Beyond.Byte.UInt128 value, bool bIsLittle = true /* Metadata: 0x01FDD074 */) => default; // 0x00000001824BEF20-0x00000001824BF050
		public static byte[] WriteFloat(this byte[] data, int writerIndex, float value) => default; // 0x0000000185155844-0x00000001851558D0
		public static byte[] WriteUTF8(this byte[] data, int writerIndex, string value, out int len) {
			len = default;
			return default;
		} // 0x0000000185155C98-0x0000000185155D80
		[IDTag(1)]
		public static string GetHexString(this byte[] byteArray) => default; // 0x0000000185155404-0x0000000185155460
		[IDTag(0)]
		public static string GetHexString(this byte[] byteArray, int startIdx, int length) => default; // 0x0000000185155460-0x00000001851555D0
		[IDTag(3)]
		public static string GetHexString(this Span<byte> byteArray) => default; // 0x00000001824C0770-0x00000001824C0830
		[IDTag(2)]
		public static string GetHexString(this Span<byte> byteArray, int startIdx, int length) => default; // 0x00000001823A78E0-0x00000001823A7D30
		[IDTag(1)]
		public static void AppendHexString(this UnSafeString str, Span<byte> byteArray) {} // 0x00000001824BF050-0x00000001824BF430
		[IDTag(0)]
		public static void AppendHexString(this UnSafeString str, Span<byte> byteArray, int startIdx, int length) {} // 0x00000001823A80F0-0x00000001823A8410
		[IDTag(1)]
		public static string GetHexStringUnsafeString(this Span<byte> byteArray) => default; // 0x0000000182E9CC10-0x0000000182E9CC70
		[IDTag(0)]
		public static string GetHexStringUnsafeString(this Span<byte> byteArray, int startIdx, int length) => default; // 0x0000000182E9CDE0-0x0000000182E9D0F0
		public static Beyond.Byte.UInt128 ComputeMD5Bytes(this byte[] bs, int offset, int count) => default; // 0x0000000185155284-0x0000000185155404
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 59429
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D060C0-0x0000000183D06130
	
		// Methods
		public bool __Gen_Wrap_0(ref Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1) => default; // 0x0000000185155D80-0x0000000185155EE8
		public bool __Gen_Wrap_1(ref Beyond.Byte.UInt128 P0, object P1) => default; // 0x0000000185156764-0x00000001851568B4
		public int __Gen_Wrap_2(ref Beyond.Byte.UInt128 P0) => default; // 0x00000001851573CC-0x0000000185157500
		public Beyond.Byte.UInt128 __Gen_Wrap_3(object P0) => default; // 0x0000000185158184-0x000000018515827C
		public Guid __Gen_Wrap_4(ref Beyond.Byte.UInt128 P0) => default; // 0x0000000185158D00-0x0000000185158E60
		public int __Gen_Wrap_5(ref Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1) => default; // 0x0000000185159824-0x000000018515998C
		public bool __Gen_Wrap_6(Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1) => default; // 0x000000018515998C-0x0000000185159AB4
		public int __Gen_Wrap_7(ref ByteBufStream P0) => default; // 0x0000000185159AB4-0x0000000185159C00
		public byte[] __Gen_Wrap_8(ref ByteBufStream P0) => default; // 0x0000000185159C00-0x0000000185159D4C
		public uint __Gen_Wrap_9(object P0, int P1, bool P2) => default; // 0x0000000185156024-0x0000000185156128
		public uint __Gen_Wrap_10(ref ByteBufStream P0) => default; // 0x0000000185155EE8-0x0000000185156024
		public int __Gen_Wrap_11(object P0, int P1, bool P2) => default; // 0x0000000185156024-0x0000000185156128
		public byte __Gen_Wrap_12(object P0, int P1, bool P2) => default; // 0x0000000185156024-0x0000000185156128
		public ulong __Gen_Wrap_13(object P0, int P1, bool P2) => default; // 0x0000000185156128-0x000000018515622C
		public ulong __Gen_Wrap_14(ref ByteBufStream P0) => default; // 0x000000018515622C-0x0000000185156368
		public long __Gen_Wrap_15(object P0, int P1, bool P2) => default; // 0x0000000185156128-0x000000018515622C
		public long __Gen_Wrap_16(ref ByteBufStream P0) => default; // 0x0000000185156368-0x00000001851564B4
		public Beyond.Byte.UInt128 __Gen_Wrap_17(object P0, int P1, bool P2) => default; // 0x00000001851564B4-0x00000001851565EC
		public Beyond.Byte.UInt128 __Gen_Wrap_18(ref ByteBufStream P0) => default; // 0x00000001851565EC-0x0000000185156764
		public ushort __Gen_Wrap_19(object P0, int P1, bool P2) => default; // 0x0000000185156024-0x0000000185156128
		public short __Gen_Wrap_20(object P0, int P1, bool P2) => default; // 0x0000000185156024-0x0000000185156128
		public string __Gen_Wrap_21(object P0, int P1, out short P2) {
			P2 = default;
			return default;
		} // 0x00000001851568B4-0x0000000185156A00
		public string __Gen_Wrap_22(ref ByteBufStream P0) => default; // 0x0000000185156A00-0x0000000185156B60
		public void __Gen_Wrap_23(object P0, int P1, out short P2) {
			P2 = default;
		} // 0x0000000185156B60-0x0000000185156C78
		public void __Gen_Wrap_24(ref ByteBufStream P0) {} // 0x0000000185156C78-0x0000000185156DB4
		public byte[] __Gen_Wrap_25(object P0, int P1, byte P2) => default; // 0x0000000185156DB4-0x0000000185156EC8
		public void __Gen_Wrap_26(ref ByteBufStream P0, byte P1) {} // 0x0000000185156EC8-0x0000000185157010
		public byte[] __Gen_Wrap_27(object P0, int P1, uint P2, bool P3) => default; // 0x0000000185157010-0x0000000185157144
		public void __Gen_Wrap_28(ref ByteBufStream P0, uint P1) {} // 0x0000000185157144-0x0000000185157288
		public void __Gen_Wrap_29(ref ByteBufStream P0, int P1) {} // 0x0000000185157288-0x00000001851573CC
		public byte[] __Gen_Wrap_30(object P0, int P1, ulong P2, bool P3) => default; // 0x0000000185157500-0x0000000185157628
		public void __Gen_Wrap_31(ref ByteBufStream P0, ulong P1) {} // 0x0000000185157628-0x0000000185157770
		public void __Gen_Wrap_32(ref ByteBufStream P0, long P1) {} // 0x0000000185157770-0x00000001851578B8
		public byte[] __Gen_Wrap_33(object P0, int P1, Beyond.Byte.UInt128 P2, bool P3) => default; // 0x00000001851578B8-0x0000000185157A00
		public void __Gen_Wrap_34(ref ByteBufStream P0, Beyond.Byte.UInt128 P1) {} // 0x0000000185157A00-0x0000000185157B6C
		public byte[] __Gen_Wrap_35(object P0, int P1, ushort P2, bool P3) => default; // 0x0000000185157B6C-0x0000000185157CA0
		public byte[] __Gen_Wrap_36(object P0, int P1, short P2, bool P3) => default; // 0x0000000185157CA0-0x0000000185157DC8
		public byte[] __Gen_Wrap_37(object P0, int P1, object P2, out int P3) {
			P3 = default;
			return default;
		} // 0x0000000185157DC8-0x0000000185157F14
		public void __Gen_Wrap_38(ref ByteBufStream P0, object P1) {} // 0x0000000185157F14-0x000000018515805C
		public ByteBufStream __Gen_Wrap_39(object P0, int P1) => default; // 0x000000018515805C-0x0000000185158184
		public ByteBufStream __Gen_Wrap_40(int P0) => default; // 0x000000018515827C-0x0000000185158374
		public float __Gen_Wrap_41(int P0) => default; // 0x00000001850F29AC-0x00000001850F2A64
		public float __Gen_Wrap_42(object P0, int P1, bool P2) => default; // 0x0000000185158374-0x0000000185158468
		public Span<byte> __Gen_Wrap_43(Span<byte> P0, int P1, uint P2, bool P3) => default; // 0x0000000185158468-0x00000001851585D4
		public byte[] __Gen_Wrap_44(object P0, int P1, int P2, bool P3) => default; // 0x00000001851585D4-0x0000000185158708
		public Span<byte> __Gen_Wrap_45(Span<byte> P0, int P1, ulong P2, bool P3) => default; // 0x0000000185158708-0x0000000185158874
		public byte[] __Gen_Wrap_46(object P0, int P1, long P2, bool P3) => default; // 0x0000000185158874-0x000000018515899C
		public Span<byte> __Gen_Wrap_47(Span<byte> P0, int P1, Beyond.Byte.UInt128 P2, bool P3) => default; // 0x000000018515899C-0x0000000185158B30
		public int __Gen_Wrap_48(float P0) => default; // 0x0000000185158B30-0x0000000185158BEC
		public byte[] __Gen_Wrap_49(object P0, int P1, float P2) => default; // 0x0000000185158BEC-0x0000000185158D00
		public void __Gen_Wrap_50(long P0, out int P1, out int P2) {
			P1 = default;
			P2 = default;
		} // 0x0000000185158E60-0x0000000185158F88
		public long __Gen_Wrap_51(int P0, int P1) => default; // 0x0000000185158F88-0x000000018515905C
		public string __Gen_Wrap_52(object P0, int P1, int P2) => default; // 0x000000018515905C-0x0000000185159170
		public string __Gen_Wrap_53(object P0) => default; // 0x0000000185159170-0x000000018515924C
		public string __Gen_Wrap_54(Span<byte> P0, int P1, int P2) => default; // 0x000000018515924C-0x0000000185159398
		public string __Gen_Wrap_55(Span<byte> P0) => default; // 0x0000000185159398-0x00000001851594B0
		public void __Gen_Wrap_56(object P0, Span<byte> P1, int P2, int P3) {} // 0x00000001851594B0-0x00000001851595EC
		public void __Gen_Wrap_57(object P0, Span<byte> P1) {} // 0x00000001851595EC-0x0000000185159700
		public Beyond.Byte.UInt128 __Gen_Wrap_58(object P0, int P1, int P2) => default; // 0x0000000185159700-0x0000000185159824
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 59430
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x0000000185159D4C-0x0000000185159DE0
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 59431
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018515A56C-0x000000018515A5D0
		public static bool IsPatched(int id) => default; // 0x00000001824315D0-0x0000000182431680
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018515A428-0x000000018515A4F4
		public object CreateWrapper(int id) => default; // 0x000000018515A4F4-0x000000018515A56C
		public object InitWrapperArray(int len) => default; // 0x000000018515A5D0-0x000000018515A728
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018515A384-0x000000018515A428
	}

	public enum IDMAP0 // TypeDefIndex: 59432
	{
		Beyond-Byte-UInt128-Equals1 = 0,
		Beyond-Byte-UInt128-Equals0 = 1,
		Beyond-Byte-UInt128-GetHashCode0 = 2,
		Beyond-Byte-UInt128-op_Implicit0 = 3,
		Beyond-Byte-UInt128-ToGuid0 = 4,
		Beyond-Byte-UInt128-CompareTo0 = 5,
		Beyond-Byte-UInt128-op_Equality0 = 6,
		Beyond-Byte-UInt128-op_Inequality0 = 7,
		Beyond-Byte-ByteBufStream-GetCurrentIdx0 = 8,
		Beyond-Byte-ByteBufStream-GetRaw0 = 9,
		Beyond-Byte-ByteBufStream-GetDataCopy0 = 10,
		Beyond-Byte-ByteBufStream-ReadUInt0 = 11,
		Beyond-Byte-ByteHelper-ReadUInt0 = 12,
		Beyond-Byte-ByteBufStream-ReadInt0 = 13,
		Beyond-Byte-ByteHelper-ReadInt0 = 14,
		Beyond-Byte-ByteBufStream-ReadByte0 = 15,
		Beyond-Byte-ByteHelper-ReadByte0 = 16,
		Beyond-Byte-ByteBufStream-ReadULong0 = 17,
		Beyond-Byte-ByteHelper-ReadULong0 = 18,
		Beyond-Byte-ByteBufStream-ReadLong0 = 19,
		Beyond-Byte-ByteHelper-ReadLong0 = 20,
		Beyond-Byte-ByteBufStream-ReadUInt1280 = 21,
		Beyond-Byte-ByteHelper-ReadUInt1280 = 22,
		Beyond-Byte-ByteBufStream-ReadUTF80 = 23,
		Beyond-Byte-ByteHelper-ReadUTF80 = 24,
		Beyond-Byte-ByteHelper-ReadShort0 = 25,
		Beyond-Byte-ByteHelper-ReadUShort0 = 26,
		Beyond-Byte-ByteBufStream-SkipReadUTF80 = 27,
		Beyond-Byte-ByteHelper-SkipReadUTF80 = 28,
		Beyond-Byte-ByteBufStream-WriteByte0 = 29,
		Beyond-Byte-ByteHelper-WriteByte0 = 30,
		Beyond-Byte-ByteBufStream-WriteUInt0 = 31,
		Beyond-Byte-ByteHelper-WriteUInt0 = 32,
		Beyond-Byte-ByteBufStream-WriteInt0 = 33,
		Beyond-Byte-ByteBufStream-WriteULong0 = 34,
		Beyond-Byte-ByteHelper-WriteULong0 = 35,
		Beyond-Byte-ByteBufStream-WriteLong0 = 36,
		Beyond-Byte-ByteBufStream-WriteUInt1280 = 37,
		Beyond-Byte-ByteHelper-WriteUInt1280 = 38,
		Beyond-Byte-ByteBufStream-WriteUTF80 = 39,
		Beyond-Byte-ByteHelper-WriteUTF80 = 40,
		Beyond-Byte-ByteHelper-WriteShort0 = 41,
		Beyond-Byte-ByteHelper-WriteUShort0 = 42,
		Beyond-Byte-ByteBufStream-SkipBytes0 = 43,
		Beyond-Byte-ByteBufStream-RemainBytes0 = 44,
		Beyond-Byte-ByteBufStream-CreateFromByte0 = 45,
		Beyond-Byte-ByteBufStream-Create0 = 46,
		Beyond-Byte-ByteHelper-ReadFloat0 = 47,
		Beyond-Byte-ByteHelper-Int32BitsToSingle0 = 48,
		Beyond-Byte-ByteHelper-WriteUInt1 = 49,
		Beyond-Byte-ByteHelper-WriteInt0 = 50,
		Beyond-Byte-ByteHelper-WriteULong1 = 51,
		Beyond-Byte-ByteHelper-WriteLong0 = 52,
		Beyond-Byte-ByteHelper-WriteUInt1281 = 53,
		Beyond-Byte-ByteHelper-WriteFloat0 = 54,
		Beyond-Byte-ByteHelper-SingleToInt32Bits0 = 55,
		Beyond-Byte-ByteHelper-SplitLong0 = 56,
		Beyond-Byte-ByteHelper-MergeLong0 = 57,
		Beyond-Byte-ByteHelper-GetHexString1 = 58,
		Beyond-Byte-ByteHelper-GetHexString0 = 59,
		Beyond-Byte-ByteHelper-GetHexString3 = 60,
		Beyond-Byte-ByteHelper-GetHexString2 = 61,
		Beyond-Byte-ByteHelper-AppendHexString1 = 62,
		Beyond-Byte-ByteHelper-AppendHexString0 = 63,
		Beyond-Byte-ByteHelper-GetHexStringUnsafeString1 = 64,
		Beyond-Byte-ByteHelper-GetHexStringUnsafeString0 = 65,
		Beyond-Byte-ByteHelper-ComputeMD5Bytes0 = 66
	}
}
