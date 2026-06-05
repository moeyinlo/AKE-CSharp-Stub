/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using Beyond;
using Beyond.Byte;
using IFix.Core;

// Image 93: Beyond.Byte.dll - Assembly: Beyond.Byte, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60481-60488

namespace Beyond.Byte
{
	[Serializable]
	public struct UInt128 : IComparable<Beyond.Byte.UInt128>, IEquatable<Beyond.Byte.UInt128> // TypeDefIndex: 60482
	{
		// Fields
		public ulong high; // 0x00
		public ulong low; // 0x08
	
		// Constructors
		public UInt128(ulong high, ulong low) {
			this.high = default;
			this.low = default;
		} // 0x0000000183680100-0x0000000183680110
		public UInt128(byte[] bytes) {
			high = default;
			low = default;
		} // 0x0000000187348AF4-0x0000000187348B30
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000187348804-0x00000001873488A8
		public override int GetHashCode() => default; // 0x00000001873488A8-0x0000000187348944
		public static implicit operator UInt128(byte[] bytes) => default; // 0x0000000187348BB0-0x0000000187348C24
		public Guid ToGuid() => default; // 0x0000000187348944-0x0000000187348A44
		public int CompareTo(UInt128 other) => default; // 0x0000000187348710-0x0000000187348790
		public bool Equals(UInt128 other) => default; // 0x0000000187348790-0x0000000187348804
		public static bool operator ==(UInt128 a, UInt128 b) => default; // 0x0000000187348B30-0x0000000187348BB0
		public static bool operator !=(UInt128 a, UInt128 B) => default; // 0x0000000187348C24-0x0000000187348CB4
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x0000000187348A44-0x0000000187348AA4
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000187348AA4-0x0000000187348AF4
	}

	public struct ByteBufStream // TypeDefIndex: 60483
	{
		// Fields
		public int currentIdx; // 0x00
		public byte[] datas; // 0x08
	
		// Methods
		public int GetCurrentIdx() => default; // 0x0000000184181D40-0x0000000184181DC0
		public byte[] GetRaw() => default; // 0x0000000187343670-0x00000001873436BC
		public byte[] GetDataCopy() => default; // 0x00000001873435E0-0x0000000187343670
		public uint ReadUInt() => default; // 0x00000001873436BC-0x0000000187343718
		public int ReadInt() => default; // 0x0000000184180130-0x0000000184180350
		public int ReadByte() => default; // 0x00000001841806F0-0x0000000184180830
		public ulong ReadULong() => default; // 0x0000000187343718-0x0000000187343774
		public long ReadLong() => default; // 0x0000000184181820-0x0000000184181950
		public Beyond.Byte.UInt128 ReadUInt128() => default; // 0x00000001841808E0-0x0000000184180A50
		public string ReadUTF8() => default; // 0x000000018417F790-0x000000018417F7E0
		public void SkipReadUTF8() {} // 0x0000000184181DC0-0x0000000184182030
		public void WriteByte(byte val) {} // 0x00000001873437E0-0x0000000187343844
		public void WriteUInt(uint val) {} // 0x0000000187343988-0x00000001873439F4
		public void WriteInt(int val) {} // 0x0000000187343844-0x00000001873438A4
		public void WriteULong(ulong val) {} // 0x00000001873439F4-0x0000000187343A60
		public void WriteLong(long val) {} // 0x00000001873438A4-0x0000000187343904
		public void WriteUInt128(Beyond.Byte.UInt128 val) {} // 0x0000000187343904-0x0000000187343988
		public void WriteUTF8(string val) {} // 0x0000000187343A60-0x0000000187343AD8
		public void SkipBytes(int offset) {} // 0x0000000187343774-0x00000001873437E0
		public int RemainBytes() => default; // 0x000000018417E6D0-0x000000018417E710
		public static ByteBufStream CreateFromByte(byte[] bs, int startIdx = 0 /* Metadata: 0x0208294D */) => default; // 0x000000018417F720-0x000000018417F790
		public static ByteBufStream Create(int cap) => default; // 0x0000000187343538-0x00000001873435E0
	}

	public static class ByteHelper // TypeDefIndex: 60484
	{
		// Methods
		public static Beyond.Byte.UInt128 ReadUInt128(byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x0208294E */) => default; // 0x0000000184181A00-0x0000000184181AF0
		public static long ReadLong(byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x0208294F */) => default; // 0x0000000184181950-0x0000000184181A00
		public static ulong ReadULong(byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x02082950 */) => default; // 0x0000000184181AF0-0x0000000184181C90
		public static uint ReadUInt(byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x02082951 */) => default; // 0x00000001841804F0-0x0000000184180610
		public static int ReadInt(byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x02082952 */) => default; // 0x0000000184180350-0x00000001841804F0
		public static ushort ReadUShort(byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x02082953 */) => default; // 0x0000000184180610-0x00000001841806F0
		public static short ReadShort(byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x02082954 */) => default; // 0x000000018417FFC0-0x0000000184180130
		public static byte ReadByte(byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x02082955 */) => default; // 0x0000000184180830-0x00000001841808E0
		public static float ReadFloat(byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x02082956 */) => default; // 0x0000000187343EC8-0x0000000187343F58
		public static string ReadUTF8(byte[] bs, int startIndex, out short len) {
			len = default;
			return default;
		} // 0x000000018417F7E0-0x000000018417F890
		public static void SkipReadUTF8(byte[] bs, int startIndex, out short len) {
			len = default;
		} // 0x000000018417FBA0-0x000000018417FD90
		public static byte[] WriteByte(byte[] data, int writerIndex, byte value) => default; // 0x000000018734401C-0x0000000187344098
		public static byte[] WriteUShort(byte[] data, int writerIndex, ushort value, bool bIsLittle = true /* Metadata: 0x02082957 */) => default; // 0x00000001843CF090-0x00000001843CF120
		public static byte[] WriteShort(byte[] data, int writerIndex, short value, bool bIsLittle = true /* Metadata: 0x02082958 */) => default; // 0x00000001873441B0-0x0000000187344240
		public static byte[] WriteUInt(byte[] data, int writerIndex, uint value, bool bIsLittle = true /* Metadata: 0x02082959 */) => default; // 0x00000001843CF120-0x00000001843CF380
		public static Span<byte> WriteUInt(Span<byte> data, int writerIndex, uint value, bool bIsLittle = true /* Metadata: 0x0208295A */) => default; // 0x0000000184056EB0-0x0000000184057020
		public static byte[] WriteInt(byte[] data, int writerIndex, int value, bool bIsLittle = true /* Metadata: 0x0208295B */) => default; // 0x00000001843CF020-0x00000001843CF090
		public static byte[] WriteULong(byte[] data, int writerIndex, ulong value, bool bIsLittle = true /* Metadata: 0x0208295C */) => default; // 0x00000001873442F4-0x00000001873444EC
		public static Span<byte> WriteULong(Span<byte> data, int writerIndex, ulong value, bool bIsLittle = true /* Metadata: 0x0208295D */) => default; // 0x0000000184056480-0x0000000184056660
		public static byte[] WriteLong(byte[] data, int writerIndex, long value, bool bIsLittle = true /* Metadata: 0x0208295E */) => default; // 0x0000000187344124-0x00000001873441B0
		public static byte[] WriteUInt128(byte[] data, int writerIndex, Beyond.Byte.UInt128 value, bool bIsLittle = true /* Metadata: 0x0208295F */) => default; // 0x0000000187344240-0x00000001873442F4
		public static Span<byte> WriteUInt128(Span<byte> data, int writerIndex, Beyond.Byte.UInt128 value, bool bIsLittle = true /* Metadata: 0x02082960 */) => default; // 0x0000000184182120-0x0000000184182250
		public static byte[] WriteFloat(byte[] data, int writerIndex, float value) => default; // 0x0000000187344098-0x0000000187344124
		public static byte[] WriteUTF8(byte[] data, int writerIndex, string value, out int len) {
			len = default;
			return default;
		} // 0x00000001873444EC-0x00000001873445D4
		public static void SplitLong(long longValue, out int highInt, out int lowInt) {
			highInt = default;
			lowInt = default;
		} // 0x0000000187343FAC-0x000000018734401C
		public static long MergeLong(int highInt, int lowInt) => default; // 0x0000000187343E6C-0x0000000187343EC8
		public static int SingleToInt32Bits(float value) => default; // 0x0000000187343F58-0x0000000187343FAC
		public static float Int32BitsToSingle(int value) => default; // 0x0000000187343E24-0x0000000187343E6C
		public static string GetHexString(byte[] byteArray) => default; // 0x0000000187343C58-0x0000000187343CB4
		public static string GetHexString(byte[] byteArray, int startIdx, int length) => default; // 0x0000000187343CB4-0x0000000187343E24
		public static string GetHexString(Span<byte> byteArray) => default; // 0x0000000184183740-0x0000000184183800
		public static string GetHexString(Span<byte> byteArray, int startIdx, int length) => default; // 0x00000001840556C0-0x0000000184055B10
		public static void AppendHexString(UnSafeString str, Span<byte> byteArray) {} // 0x0000000184183360-0x0000000184183740
		public static void AppendHexString(UnSafeString str, Span<byte> byteArray, int startIdx, int length) {} // 0x0000000184055ED0-0x00000001840561F0
		public static string GetHexStringUnsafeString(Span<byte> byteArray) => default; // 0x0000000184AD6560-0x0000000184AD65C0
		public static string GetHexStringUnsafeString(Span<byte> byteArray, int startIdx, int length) => default; // 0x0000000184AD6730-0x0000000184AD6A40
		public static Beyond.Byte.UInt128 ComputeMD5Bytes(byte[] bs, int offset, int count) => default; // 0x0000000187343AD8-0x0000000187343C58
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60485
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F649B0-0x0000000185F64A20
	
		// Methods
		public bool __Gen_Wrap_0(ref Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1) => default; // 0x00000001873445D4-0x000000018734473C
		public bool __Gen_Wrap_1(ref Beyond.Byte.UInt128 P0, object P1) => default; // 0x0000000187344FB8-0x0000000187345108
		public int __Gen_Wrap_2(ref Beyond.Byte.UInt128 P0) => default; // 0x0000000187345C34-0x0000000187345D78
		public Beyond.Byte.UInt128 __Gen_Wrap_3(object P0) => default; // 0x00000001873469FC-0x0000000187346AF4
		public Guid __Gen_Wrap_4(ref Beyond.Byte.UInt128 P0) => default; // 0x0000000187347630-0x0000000187347790
		public int __Gen_Wrap_5(ref Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1) => default; // 0x0000000187348154-0x00000001873482BC
		public bool __Gen_Wrap_6(Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1) => default; // 0x00000001873482BC-0x00000001873483E4
		public int __Gen_Wrap_7(ref ByteBufStream P0) => default; // 0x00000001873483E4-0x0000000187348530
		public byte[] __Gen_Wrap_8(ref ByteBufStream P0) => default; // 0x0000000187348530-0x000000018734867C
		public uint __Gen_Wrap_9(object P0, int P1, bool P2) => default; // 0x0000000187344878-0x000000018734497C
		public uint __Gen_Wrap_10(ref ByteBufStream P0) => default; // 0x000000018734473C-0x0000000187344878
		public int __Gen_Wrap_11(object P0, int P1, bool P2) => default; // 0x0000000187344878-0x000000018734497C
		public byte __Gen_Wrap_12(object P0, int P1, bool P2) => default; // 0x0000000187344878-0x000000018734497C
		public ulong __Gen_Wrap_13(object P0, int P1, bool P2) => default; // 0x000000018734497C-0x0000000187344A80
		public ulong __Gen_Wrap_14(ref ByteBufStream P0) => default; // 0x0000000187344A80-0x0000000187344BBC
		public long __Gen_Wrap_15(object P0, int P1, bool P2) => default; // 0x000000018734497C-0x0000000187344A80
		public long __Gen_Wrap_16(ref ByteBufStream P0) => default; // 0x0000000187344BBC-0x0000000187344D08
		public Beyond.Byte.UInt128 __Gen_Wrap_17(object P0, int P1, bool P2) => default; // 0x0000000187344D08-0x0000000187344E40
		public Beyond.Byte.UInt128 __Gen_Wrap_18(ref ByteBufStream P0) => default; // 0x0000000187344E40-0x0000000187344FB8
		public ushort __Gen_Wrap_19(object P0, int P1, bool P2) => default; // 0x0000000187344878-0x000000018734497C
		public short __Gen_Wrap_20(object P0, int P1, bool P2) => default; // 0x0000000187344878-0x000000018734497C
		public string __Gen_Wrap_21(object P0, int P1, out short P2) {
			P2 = default;
			return default;
		} // 0x0000000187345108-0x0000000187345254
		public string __Gen_Wrap_22(ref ByteBufStream P0) => default; // 0x0000000187345254-0x00000001873453B4
		public void __Gen_Wrap_23(object P0, int P1, out short P2) {
			P2 = default;
		} // 0x00000001873453B4-0x00000001873454CC
		public void __Gen_Wrap_24(ref ByteBufStream P0) {} // 0x00000001873454CC-0x0000000187345608
		public byte[] __Gen_Wrap_25(object P0, int P1, byte P2) => default; // 0x0000000187345608-0x000000018734571C
		public void __Gen_Wrap_26(ref ByteBufStream P0, byte P1) {} // 0x000000018734571C-0x0000000187345864
		public byte[] __Gen_Wrap_27(object P0, int P1, uint P2, bool P3) => default; // 0x0000000187345864-0x0000000187345998
		public void __Gen_Wrap_28(ref ByteBufStream P0, uint P1) {} // 0x0000000187345998-0x0000000187345ADC
		public void __Gen_Wrap_29(ref ByteBufStream P0, int P1) {} // 0x0000000187345ADC-0x0000000187345C34
		public byte[] __Gen_Wrap_30(object P0, int P1, ulong P2, bool P3) => default; // 0x0000000187345D78-0x0000000187345EA0
		public void __Gen_Wrap_31(ref ByteBufStream P0, ulong P1) {} // 0x0000000187345EA0-0x0000000187345FE8
		public void __Gen_Wrap_32(ref ByteBufStream P0, long P1) {} // 0x0000000187345FE8-0x0000000187346130
		public byte[] __Gen_Wrap_33(object P0, int P1, Beyond.Byte.UInt128 P2, bool P3) => default; // 0x0000000187346130-0x0000000187346278
		public void __Gen_Wrap_34(ref ByteBufStream P0, Beyond.Byte.UInt128 P1) {} // 0x0000000187346278-0x00000001873463E4
		public byte[] __Gen_Wrap_35(object P0, int P1, ushort P2, bool P3) => default; // 0x00000001873463E4-0x0000000187346518
		public byte[] __Gen_Wrap_36(object P0, int P1, short P2, bool P3) => default; // 0x0000000187346518-0x0000000187346640
		public byte[] __Gen_Wrap_37(object P0, int P1, object P2, out int P3) {
			P3 = default;
			return default;
		} // 0x0000000187346640-0x000000018734678C
		public void __Gen_Wrap_38(ref ByteBufStream P0, object P1) {} // 0x000000018734678C-0x00000001873468D4
		public ByteBufStream __Gen_Wrap_39(object P0, int P1) => default; // 0x00000001873468D4-0x00000001873469FC
		public ByteBufStream __Gen_Wrap_40(int P0) => default; // 0x0000000187346AF4-0x0000000187346BEC
		public float __Gen_Wrap_41(int P0) => default; // 0x0000000187346BEC-0x0000000187346CA4
		public float __Gen_Wrap_42(object P0, int P1, bool P2) => default; // 0x0000000187346CA4-0x0000000187346D98
		public Span<byte> __Gen_Wrap_43(Span<byte> P0, int P1, uint P2, bool P3) => default; // 0x0000000187346D98-0x0000000187346F04
		public byte[] __Gen_Wrap_44(object P0, int P1, int P2, bool P3) => default; // 0x0000000187346F04-0x0000000187347038
		public Span<byte> __Gen_Wrap_45(Span<byte> P0, int P1, ulong P2, bool P3) => default; // 0x0000000187347038-0x00000001873471A4
		public byte[] __Gen_Wrap_46(object P0, int P1, long P2, bool P3) => default; // 0x00000001873471A4-0x00000001873472CC
		public Span<byte> __Gen_Wrap_47(Span<byte> P0, int P1, Beyond.Byte.UInt128 P2, bool P3) => default; // 0x00000001873472CC-0x0000000187347460
		public int __Gen_Wrap_48(float P0) => default; // 0x0000000187347460-0x000000018734751C
		public byte[] __Gen_Wrap_49(object P0, int P1, float P2) => default; // 0x000000018734751C-0x0000000187347630
		public void __Gen_Wrap_50(long P0, out int P1, out int P2) {
			P1 = default;
			P2 = default;
		} // 0x0000000187347790-0x00000001873478B8
		public long __Gen_Wrap_51(int P0, int P1) => default; // 0x00000001873478B8-0x000000018734798C
		public string __Gen_Wrap_52(object P0, int P1, int P2) => default; // 0x000000018734798C-0x0000000187347AA0
		public string __Gen_Wrap_53(object P0) => default; // 0x0000000187347AA0-0x0000000187347B7C
		public string __Gen_Wrap_54(Span<byte> P0, int P1, int P2) => default; // 0x0000000187347B7C-0x0000000187347CC8
		public string __Gen_Wrap_55(Span<byte> P0) => default; // 0x0000000187347CC8-0x0000000187347DE0
		public void __Gen_Wrap_56(object P0, Span<byte> P1, int P2, int P3) {} // 0x0000000187347DE0-0x0000000187347F1C
		public void __Gen_Wrap_57(object P0, Span<byte> P1) {} // 0x0000000187347F1C-0x0000000187348030
		public Beyond.Byte.UInt128 __Gen_Wrap_58(object P0, int P1, int P2) => default; // 0x0000000187348030-0x0000000187348154
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 60486
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018734867C-0x0000000187348710
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 60487
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000187348E9C-0x0000000187348F00
		public static bool IsPatched(int id) => default; // 0x0000000184181C90-0x0000000184181D40
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x0000000187348D58-0x0000000187348E24
		public object CreateWrapper(int id) => default; // 0x0000000187348E24-0x0000000187348E9C
		public object InitWrapperArray(int len) => default; // 0x0000000187348F00-0x0000000187349058
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000187348CB4-0x0000000187348D58
	}

	public enum IDMAP0 // TypeDefIndex: 60488
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
