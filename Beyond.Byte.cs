/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using Beyond.Byte;
using IFix.Core;

// Image 93: Beyond.Byte.dll - Assembly: Beyond.Byte, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90286-90352

namespace Beyond.Byte
{
	[Serializable]
	public struct UInt128 : IComparable<Beyond.Byte.UInt128>, IEquatable<Beyond.Byte.UInt128> // TypeDefIndex: 90287
	{
		// Fields
		public ulong high; // 0x00
		public ulong low; // 0x08
	
		// Constructors
		public UInt128(ulong high, ulong low); // 0x0000000187232F10-0x0000000187232F20
		public UInt128(byte[] bytes); // 0x00000001887F9290-0x00000001887F92CC
	
		// Methods
		[IDTag(1)]
		public override bool Equals(object obj); // 0x00000001887F9030-0x00000001887F90E0
		public override int GetHashCode(); // 0x00000001855A1FA0-0x00000001855A2160
		public static implicit operator UInt128(byte[] bytes); // 0x00000001887F9338-0x00000001887F939C
		public Guid ToGuid(); // 0x00000001887F90E0-0x00000001887F91E0
		public int CompareTo(UInt128 other); // 0x00000001887F8FC4-0x00000001887F9030
		[IDTag(0)]
		public bool Equals(UInt128 other); // 0x00000001859EBBD0-0x00000001859EBC10
		public static bool operator ==(UInt128 a, UInt128 b); // 0x00000001887F92CC-0x00000001887F9338
		public static bool operator !=(UInt128 a, UInt128 B); // 0x00000001887F939C-0x00000001887F941C
		public bool __iFixBaseProxy_Equals(object P0); // 0x00000001887F91E0-0x00000001887F9240
		public int __iFixBaseProxy_GetHashCode(); // 0x00000001887F9240-0x00000001887F9290
	}

	public struct ByteBufStream // TypeDefIndex: 90288
	{
		// Fields
		public int currentIdx; // 0x00
		public byte[] datas; // 0x08
	
		// Methods
		public int GetCurrentIdx(); // 0x00000001887F3FE0-0x00000001887F4020
		public byte[] GetRaw(); // 0x00000001887F40B0-0x00000001887F40F0
		public byte[] GetDataCopy(); // 0x00000001887F4020-0x00000001887F40B0
		public uint ReadUInt(); // 0x00000001887F40F0-0x00000001887F4148
		public int ReadInt(); // 0x00000001851122C0-0x0000000185112380
		public int ReadByte(); // 0x0000000185112220-0x0000000185112280
		public ulong ReadULong(); // 0x00000001887F4148-0x00000001887F41A0
		public long ReadLong(); // 0x0000000185112050-0x00000001851120A0
		public Beyond.Byte.UInt128 ReadUInt128(); // 0x00000001851112C0-0x0000000185111350
		public string ReadUTF8(); // 0x00000001868595B0-0x0000000186859600
		public void SkipReadUTF8(); // 0x0000000185112B80-0x0000000185112C20
		public void WriteByte(byte val); // 0x00000001887F41A0-0x00000001887F41FC
		public void WriteUInt(uint val); // 0x00000001887F42F4-0x00000001887F4358
		public void WriteInt(int val); // 0x00000001887F41FC-0x00000001887F423C
		public void WriteULong(ulong val); // 0x00000001887F4358-0x00000001887F43BC
		public void WriteLong(long val); // 0x00000001887F423C-0x00000001887F427C
		public void WriteUInt128(Beyond.Byte.UInt128 val); // 0x00000001887F427C-0x00000001887F42F4
		public void WriteUTF8(string val); // 0x00000001887F43BC-0x00000001887F4428
		public void SkipBytes(int offset); // 0x0000000185112AA0-0x0000000185112AF0
		public int RemainBytes(); // 0x0000000186B779A0-0x0000000186B779E0
		public static ByteBufStream CreateFromByte(byte[] bs, int startIdx = 0 /* Metadata: 0x0264ADA9 */); // 0x0000000186B520F0-0x0000000186B52130
		public static ByteBufStream Create(int cap); // 0x00000001887F3F3C-0x00000001887F3FE0
	}

	public static class ByteHelper // TypeDefIndex: 90289
	{
		// Methods
		public static void SplitLong(long longValue, out int highInt, out int lowInt); // 0x00000001887F4900-0x00000001887F4950
		public static long MergeLong(int highInt, int lowInt); // 0x00000001887F480C-0x00000001887F4850
		public static int SingleToInt32Bits(float value); // 0x00000001887F48C0-0x00000001887F4900
		public static float Int32BitsToSingle(int value); // 0x00000001887F47C8-0x00000001887F480C
	
		// Extension methods
		public static Beyond.Byte.UInt128 ReadUInt128(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x0264ADAA */); // 0x0000000185111350-0x00000001851113E0
		public static long ReadLong(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x0264ADAB */); // 0x00000001851120A0-0x00000001851120D0
		public static ulong ReadULong(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x0264ADAC */); // 0x00000001851120D0-0x0000000185112220
		public static uint ReadUInt(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x0264ADAD */); // 0x0000000185112440-0x00000001851124E0
		public static int ReadInt(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x0264ADAE */); // 0x0000000185112380-0x0000000185112440
		public static ushort ReadUShort(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x0264ADAF */); // 0x0000000185112D20-0x0000000185112D90
		public static short ReadShort(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x0264ADB0 */); // 0x0000000185112CA0-0x0000000185112D20
		public static byte ReadByte(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x0264ADB1 */); // 0x0000000185112280-0x00000001851122C0
		public static float ReadFloat(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x0264ADB2 */); // 0x00000001887F4850-0x00000001887F48C0
		public static string ReadUTF8(this byte[] bs, int startIndex, out short len); // 0x0000000186859600-0x00000001868596C0
		public static void SkipReadUTF8(this byte[] bs, int startIndex, out short len); // 0x0000000185112C20-0x0000000185112CA0
		public static byte[] WriteByte(this byte[] data, int writerIndex, byte value); // 0x00000001887F4950-0x00000001887F49B4
		public static byte[] WriteUShort(this byte[] data, int writerIndex, ushort value, bool bIsLittle = true /* Metadata: 0x0264ADB3 */); // 0x000000018578A490-0x000000018578A500
		public static byte[] WriteShort(this byte[] data, int writerIndex, short value, bool bIsLittle = true /* Metadata: 0x0264ADB4 */); // 0x00000001887F4A98-0x00000001887F4AFC
		[IDTag(0)]
		public static byte[] WriteUInt(this byte[] data, int writerIndex, uint value, bool bIsLittle = true /* Metadata: 0x0264ADB5 */); // 0x000000018578A500-0x000000018578A5A0
		[IDTag(1)]
		public static Span<byte> WriteUInt(this Span<byte> data, int writerIndex, uint value, bool bIsLittle = true /* Metadata: 0x0264ADB6 */); // 0x0000000184F8C560-0x0000000184F8C610
		public static byte[] WriteInt(this byte[] data, int writerIndex, int value, bool bIsLittle = true /* Metadata: 0x0264ADB7 */); // 0x000000018578A450-0x000000018578A490
		[IDTag(0)]
		public static byte[] WriteULong(this byte[] data, int writerIndex, ulong value, bool bIsLittle = true /* Metadata: 0x0264ADB8 */); // 0x00000001887F4BB0-0x00000001887F4DCC
		[IDTag(1)]
		public static Span<byte> WriteULong(this Span<byte> data, int writerIndex, ulong value, bool bIsLittle = true /* Metadata: 0x0264ADB9 */); // 0x0000000184F8EAC0-0x0000000184F8EBE0
		public static byte[] WriteLong(this byte[] data, int writerIndex, long value, bool bIsLittle = true /* Metadata: 0x0264ADBA */); // 0x00000001887F4A34-0x00000001887F4A98
		[IDTag(0)]
		public static byte[] WriteUInt128(this byte[] data, int writerIndex, Beyond.Byte.UInt128 value, bool bIsLittle = true /* Metadata: 0x0264ADBB */); // 0x00000001887F4AFC-0x00000001887F4BB0
		[IDTag(1)]
		public static Span<byte> WriteUInt128(this Span<byte> data, int writerIndex, Beyond.Byte.UInt128 value, bool bIsLittle = true /* Metadata: 0x0264ADBC */); // 0x0000000184F8EA00-0x0000000184F8EAC0
		public static byte[] WriteFloat(this byte[] data, int writerIndex, float value); // 0x00000001887F49B4-0x00000001887F4A34
		public static byte[] WriteUTF8(this byte[] data, int writerIndex, string value, out int len); // 0x00000001887F4DCC-0x00000001887F4EC4
		[IDTag(1)]
		public static string GetHexString(this byte[] byteArray); // 0x00000001887F45C0-0x00000001887F4614
		[IDTag(0)]
		public static string GetHexString(this byte[] byteArray, int startIdx, int length); // 0x00000001887F4614-0x00000001887F47C8
		[IDTag(3)]
		public static string GetHexString(this Span<byte> byteArray); // 0x0000000185110740-0x0000000185110780
		[IDTag(2)]
		public static string GetHexString(this Span<byte> byteArray, int startIdx, int length); // 0x00000001851A75B0-0x00000001851A7A30
		[IDTag(1)]
		public static void AppendHexString(this UnSafeString str, Span<byte> byteArray); // 0x0000000184F8EEA0-0x0000000184F8F0C0
		[IDTag(0)]
		public static void AppendHexString(this UnSafeString str, Span<byte> byteArray, int startIdx, int length); // 0x000000018524E930-0x000000018524EB50
		[IDTag(1)]
		public static string GetHexStringUnsafeString(this Span<byte> byteArray); // 0x0000000186357020-0x0000000186357060
		[IDTag(0)]
		public static string GetHexStringUnsafeString(this Span<byte> byteArray, int startIdx, int length); // 0x000000018524CFA0-0x000000018524D2B0
		public static Beyond.Byte.UInt128 ComputeMD5Bytes(this byte[] bs, int offset, int count); // 0x00000001887F4428-0x00000001887F45C0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 90290
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x00000001887F8EC8-0x00000001887F8F2C
	
		// Methods
		public bool __Gen_Wrap_0(ref Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1); // 0x00000001887F4EC4-0x00000001887F502C
		public bool __Gen_Wrap_1(ref Beyond.Byte.UInt128 P0, object P1); // 0x00000001887F5874-0x00000001887F59C4
		public int __Gen_Wrap_2(ref Beyond.Byte.UInt128 P0); // 0x00000001887F64A4-0x00000001887F65DC
		public Beyond.Byte.UInt128 __Gen_Wrap_3(object P0); // 0x00000001887F725C-0x00000001887F735C
		public Guid __Gen_Wrap_4(ref Beyond.Byte.UInt128 P0); // 0x00000001887F7E94-0x00000001887F7FF8
		public int __Gen_Wrap_5(ref Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1); // 0x00000001887F89A0-0x00000001887F8B08
		public bool __Gen_Wrap_6(Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1); // 0x00000001887F8B08-0x00000001887F8C38
		public int __Gen_Wrap_7(ref ByteBufStream P0); // 0x00000001887F8C38-0x00000001887F8D78
		public byte[] __Gen_Wrap_8(ref ByteBufStream P0); // 0x00000001887F8D78-0x00000001887F8EC8
		public uint __Gen_Wrap_9(object P0, int P1, bool P2); // 0x00000001887F516C-0x00000001887F5264
		public uint __Gen_Wrap_10(ref ByteBufStream P0); // 0x00000001887F502C-0x00000001887F516C
		public int __Gen_Wrap_11(object P0, int P1, bool P2); // 0x00000001887F516C-0x00000001887F5264
		public byte __Gen_Wrap_12(object P0, int P1, bool P2); // 0x00000001887F516C-0x00000001887F5264
		public ulong __Gen_Wrap_13(object P0, int P1, bool P2); // 0x00000001887F5264-0x00000001887F535C
		public ulong __Gen_Wrap_14(ref ByteBufStream P0); // 0x00000001887F535C-0x00000001887F549C
		public long __Gen_Wrap_15(object P0, int P1, bool P2); // 0x00000001887F5264-0x00000001887F535C
		public long __Gen_Wrap_16(ref ByteBufStream P0); // 0x00000001887F549C-0x00000001887F55DC
		public Beyond.Byte.UInt128 __Gen_Wrap_17(object P0, int P1, bool P2); // 0x00000001887F55DC-0x00000001887F5708
		public Beyond.Byte.UInt128 __Gen_Wrap_18(ref ByteBufStream P0); // 0x00000001887F5708-0x00000001887F5874
		public ushort __Gen_Wrap_19(object P0, int P1, bool P2); // 0x00000001887F516C-0x00000001887F5264
		public short __Gen_Wrap_20(object P0, int P1, bool P2); // 0x00000001887F516C-0x00000001887F5264
		public string __Gen_Wrap_21(object P0, int P1, out short P2); // 0x00000001887F59C4-0x00000001887F5B00
		public string __Gen_Wrap_22(ref ByteBufStream P0); // 0x00000001887F5B00-0x00000001887F5C50
		public void __Gen_Wrap_23(object P0, int P1, out short P2); // 0x00000001887F5C50-0x00000001887F5D58
		public void __Gen_Wrap_24(ref ByteBufStream P0); // 0x00000001887F5D58-0x00000001887F5E88
		public byte[] __Gen_Wrap_25(object P0, int P1, byte P2); // 0x00000001887F5E88-0x00000001887F5FA0
		public void __Gen_Wrap_26(ref ByteBufStream P0, byte P1); // 0x00000001887F5FA0-0x00000001887F60E8
		public byte[] __Gen_Wrap_27(object P0, int P1, uint P2, bool P3); // 0x00000001887F60E8-0x00000001887F6214
		public void __Gen_Wrap_28(ref ByteBufStream P0, uint P1); // 0x00000001887F6214-0x00000001887F635C
		public void __Gen_Wrap_29(ref ByteBufStream P0, int P1); // 0x00000001887F635C-0x00000001887F64A4
		public byte[] __Gen_Wrap_30(object P0, int P1, ulong P2, bool P3); // 0x00000001887F65DC-0x00000001887F6708
		public void __Gen_Wrap_31(ref ByteBufStream P0, ulong P1); // 0x00000001887F6708-0x00000001887F6850
		public void __Gen_Wrap_32(ref ByteBufStream P0, long P1); // 0x00000001887F6850-0x00000001887F6998
		public byte[] __Gen_Wrap_33(object P0, int P1, Beyond.Byte.UInt128 P2, bool P3); // 0x00000001887F6998-0x00000001887F6AE8
		public void __Gen_Wrap_34(ref ByteBufStream P0, Beyond.Byte.UInt128 P1); // 0x00000001887F6AE8-0x00000001887F6C54
		public byte[] __Gen_Wrap_35(object P0, int P1, ushort P2, bool P3); // 0x00000001887F6C54-0x00000001887F6D80
		public byte[] __Gen_Wrap_36(object P0, int P1, short P2, bool P3); // 0x00000001887F6D80-0x00000001887F6EAC
		public byte[] __Gen_Wrap_37(object P0, int P1, object P2, out int P3); // 0x00000001887F6EAC-0x00000001887F6FF8
		public void __Gen_Wrap_38(ref ByteBufStream P0, object P1); // 0x00000001887F6FF8-0x00000001887F7140
		public ByteBufStream __Gen_Wrap_39(object P0, int P1); // 0x00000001887F7140-0x00000001887F725C
		public ByteBufStream __Gen_Wrap_40(int P0); // 0x00000001887F735C-0x00000001887F745C
		public float __Gen_Wrap_41(int P0); // 0x00000001887F745C-0x00000001887F751C
		public float __Gen_Wrap_42(object P0, int P1, bool P2); // 0x00000001887F751C-0x00000001887F7614
		public Span<byte> __Gen_Wrap_43(Span<byte> P0, int P1, uint P2, bool P3); // 0x00000001887F7614-0x00000001887F7774
		public byte[] __Gen_Wrap_44(object P0, int P1, int P2, bool P3); // 0x00000001887F7774-0x00000001887F78A0
		public Span<byte> __Gen_Wrap_45(Span<byte> P0, int P1, ulong P2, bool P3); // 0x00000001887F78A0-0x00000001887F7A00
		public byte[] __Gen_Wrap_46(object P0, int P1, long P2, bool P3); // 0x00000001887F7A00-0x00000001887F7B2C
		public Span<byte> __Gen_Wrap_47(Span<byte> P0, int P1, Beyond.Byte.UInt128 P2, bool P3); // 0x00000001887F7B2C-0x00000001887F7CB4
		public int __Gen_Wrap_48(float P0); // 0x00000001887F7CB4-0x00000001887F7D78
		public byte[] __Gen_Wrap_49(object P0, int P1, float P2); // 0x00000001887F7D78-0x00000001887F7E94
		public void __Gen_Wrap_50(long P0, out int P1, out int P2); // 0x00000001887F7FF8-0x00000001887F8124
		public long __Gen_Wrap_51(int P0, int P1); // 0x00000001887F8124-0x00000001887F8200
		public string __Gen_Wrap_52(object P0, int P1, int P2); // 0x00000001887F8200-0x00000001887F8318
		public string __Gen_Wrap_53(object P0); // 0x00000001887F8318-0x00000001887F83F8
		public string __Gen_Wrap_54(Span<byte> P0, int P1, int P2); // 0x00000001887F83F8-0x00000001887F8538
		public string __Gen_Wrap_55(Span<byte> P0); // 0x00000001887F8538-0x00000001887F8640
		public void __Gen_Wrap_56(object P0, Span<byte> P1, int P2, int P3); // 0x00000001887F8640-0x00000001887F8770
		public void __Gen_Wrap_57(object P0, Span<byte> P1); // 0x00000001887F8770-0x00000001887F8874
		public Beyond.Byte.UInt128 __Gen_Wrap_58(object P0, int P1, int P2); // 0x00000001887F8874-0x00000001887F89A0
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 90291
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x00000001887F8F2C-0x00000001887F8FC4
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 90292
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x00000001887F9608-0x00000001887F966C
		public static bool IsPatched(int id); // 0x00000001887F96F8-0x00000001887F9774
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x00000001887F94C0-0x00000001887F958C
		public object CreateWrapper(int id); // 0x00000001887F958C-0x00000001887F9608
		public object InitWrapperArray(int len); // 0x00000001887F966C-0x00000001887F96F8
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x00000001887F941C-0x00000001887F94C0
	}

	public delegate bool __HotPatchDelegate_0(ref Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1); // TypeDefIndex: 90293; 0x00000001857E4CE0-0x00000001857E4D10

	public enum HotPatchIDMAP0 // TypeDefIndex: 90294
	{
		Beyond-Byte-UInt128-Equals0 = 0,
		Beyond-Byte-UInt128-Equals1 = 1,
		Beyond-Byte-UInt128-GetHashCode0 = 2,
		Beyond-Byte-UInt128-op_Implicit0 = 3,
		Beyond-Byte-UInt128-ToGuid0 = 4,
		Beyond-Byte-UInt128-CompareTo0 = 5,
		Beyond-Byte-UInt128-op_Equality0 = 6,
		Beyond-Byte-UInt128-op_Inequality0 = 6,
		Beyond-Byte-ByteBufStream-GetCurrentIdx0 = 7,
		Beyond-Byte-ByteBufStream-ReadInt0 = 7,
		Beyond-Byte-ByteBufStream-ReadByte0 = 7,
		Beyond-Byte-ByteBufStream-RemainBytes0 = 7,
		Beyond-Byte-ByteBufStream-GetRaw0 = 8,
		Beyond-Byte-ByteBufStream-GetDataCopy0 = 8,
		Beyond-Byte-ByteHelper-ReadUInt0 = 9,
		Beyond-Byte-ByteBufStream-ReadUInt0 = 10,
		Beyond-Byte-ByteHelper-ReadInt0 = 11,
		Beyond-Byte-ByteHelper-ReadByte0 = 12,
		Beyond-Byte-ByteHelper-ReadULong0 = 13,
		Beyond-Byte-ByteBufStream-ReadULong0 = 14,
		Beyond-Byte-ByteHelper-ReadLong0 = 15,
		Beyond-Byte-ByteBufStream-ReadLong0 = 16,
		Beyond-Byte-ByteHelper-ReadUInt1280 = 17,
		Beyond-Byte-ByteBufStream-ReadUInt1280 = 18,
		Beyond-Byte-ByteHelper-ReadUShort0 = 19,
		Beyond-Byte-ByteHelper-ReadShort0 = 20,
		Beyond-Byte-ByteHelper-ReadUTF80 = 21,
		Beyond-Byte-ByteBufStream-ReadUTF80 = 22,
		Beyond-Byte-ByteHelper-SkipReadUTF80 = 23,
		Beyond-Byte-ByteBufStream-SkipReadUTF80 = 24,
		Beyond-Byte-ByteHelper-WriteByte0 = 25,
		Beyond-Byte-ByteBufStream-WriteByte0 = 26,
		Beyond-Byte-ByteHelper-WriteUInt0 = 27,
		Beyond-Byte-ByteBufStream-WriteUInt0 = 28,
		Beyond-Byte-ByteBufStream-WriteInt0 = 29,
		Beyond-Byte-ByteBufStream-SkipBytes0 = 29,
		Beyond-Byte-ByteHelper-WriteULong0 = 30,
		Beyond-Byte-ByteBufStream-WriteULong0 = 31,
		Beyond-Byte-ByteBufStream-WriteLong0 = 32,
		Beyond-Byte-ByteHelper-WriteUInt1280 = 33,
		Beyond-Byte-ByteBufStream-WriteUInt1280 = 34,
		Beyond-Byte-ByteHelper-WriteUShort0 = 35,
		Beyond-Byte-ByteHelper-WriteShort0 = 36,
		Beyond-Byte-ByteHelper-WriteUTF80 = 37,
		Beyond-Byte-ByteBufStream-WriteUTF80 = 38,
		Beyond-Byte-ByteBufStream-CreateFromByte0 = 39,
		Beyond-Byte-ByteBufStream-Create0 = 40,
		Beyond-Byte-ByteHelper-Int32BitsToSingle0 = 41,
		Beyond-Byte-ByteHelper-ReadFloat0 = 42,
		Beyond-Byte-ByteHelper-WriteUInt1 = 43,
		Beyond-Byte-ByteHelper-WriteInt0 = 44,
		Beyond-Byte-ByteHelper-WriteULong1 = 45,
		Beyond-Byte-ByteHelper-WriteLong0 = 46,
		Beyond-Byte-ByteHelper-WriteUInt1281 = 47,
		Beyond-Byte-ByteHelper-SingleToInt32Bits0 = 48,
		Beyond-Byte-ByteHelper-WriteFloat0 = 49,
		Beyond-Byte-ByteHelper-SplitLong0 = 50,
		Beyond-Byte-ByteHelper-MergeLong0 = 51,
		Beyond-Byte-ByteHelper-GetHexString0 = 52,
		Beyond-Byte-ByteHelper-GetHexString1 = 53,
		Beyond-Byte-ByteHelper-GetHexString2 = 54,
		Beyond-Byte-ByteHelper-GetHexStringUnsafeString0 = 54,
		Beyond-Byte-ByteHelper-GetHexString3 = 55,
		Beyond-Byte-ByteHelper-GetHexStringUnsafeString1 = 55,
		Beyond-Byte-ByteHelper-AppendHexString0 = 56,
		Beyond-Byte-ByteHelper-AppendHexString1 = 57,
		Beyond-Byte-ByteHelper-ComputeMD5Bytes0 = 58
	}

	public delegate bool __HotPatchDelegate_1(ref Beyond.Byte.UInt128 P0, object P1); // TypeDefIndex: 90295; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_2(ref Beyond.Byte.UInt128 P0); // TypeDefIndex: 90296; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Beyond.Byte.UInt128 __HotPatchDelegate_3(object P0); // TypeDefIndex: 90297; 0x0000000186464680-0x00000001864646B0

	public delegate Guid __HotPatchDelegate_4(ref Beyond.Byte.UInt128 P0); // TypeDefIndex: 90298; 0x0000000186464680-0x00000001864646B0

	public delegate int __HotPatchDelegate_5(ref Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1); // TypeDefIndex: 90299; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate bool __HotPatchDelegate_6(Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1); // TypeDefIndex: 90300; 0x00000001860025A0-0x00000001860025E0

	public delegate int __HotPatchDelegate_7(ref ByteBufStream P0); // TypeDefIndex: 90301; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate byte[] __HotPatchDelegate_8(ref ByteBufStream P0); // TypeDefIndex: 90302; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate uint __HotPatchDelegate_9(object P0, int P1, bool P2); // TypeDefIndex: 90303; 0x00000001811DF7F0-0x00000001811DF810

	public delegate uint __HotPatchDelegate_10(ref ByteBufStream P0); // TypeDefIndex: 90304; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_11(object P0, int P1, bool P2); // TypeDefIndex: 90305; 0x00000001811DF7F0-0x00000001811DF810

	public delegate byte __HotPatchDelegate_12(object P0, int P1, bool P2); // TypeDefIndex: 90306; 0x00000001811DF7F0-0x00000001811DF810

	public delegate ulong __HotPatchDelegate_13(object P0, int P1, bool P2); // TypeDefIndex: 90307; 0x00000001811DF7F0-0x00000001811DF810

	public delegate ulong __HotPatchDelegate_14(ref ByteBufStream P0); // TypeDefIndex: 90308; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate long __HotPatchDelegate_15(object P0, int P1, bool P2); // TypeDefIndex: 90309; 0x00000001811DF7F0-0x00000001811DF810

	public delegate long __HotPatchDelegate_16(ref ByteBufStream P0); // TypeDefIndex: 90310; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Beyond.Byte.UInt128 __HotPatchDelegate_17(object P0, int P1, bool P2); // TypeDefIndex: 90311; 0x0000000184160630-0x0000000184160670

	public delegate Beyond.Byte.UInt128 __HotPatchDelegate_18(ref ByteBufStream P0); // TypeDefIndex: 90312; 0x0000000186464680-0x00000001864646B0

	public delegate ushort __HotPatchDelegate_19(object P0, int P1, bool P2); // TypeDefIndex: 90313; 0x00000001811DF7F0-0x00000001811DF810

	public delegate short __HotPatchDelegate_20(object P0, int P1, bool P2); // TypeDefIndex: 90314; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_21(object P0, int P1, out short P2); // TypeDefIndex: 90315; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_22(ref ByteBufStream P0); // TypeDefIndex: 90316; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_23(object P0, int P1, out short P2); // TypeDefIndex: 90317; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_24(ref ByteBufStream P0); // TypeDefIndex: 90318; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate byte[] __HotPatchDelegate_25(object P0, int P1, byte P2); // TypeDefIndex: 90319; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_26(ref ByteBufStream P0, byte P1); // TypeDefIndex: 90320; 0x00000001859B7730-0x00000001859B7740

	public delegate byte[] __HotPatchDelegate_27(object P0, int P1, uint P2, bool P3); // TypeDefIndex: 90321; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_28(ref ByteBufStream P0, uint P1); // TypeDefIndex: 90322; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_29(ref ByteBufStream P0, int P1); // TypeDefIndex: 90323; 0x00000001859B7730-0x00000001859B7740

	public delegate byte[] __HotPatchDelegate_30(object P0, int P1, ulong P2, bool P3); // TypeDefIndex: 90324; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_31(ref ByteBufStream P0, ulong P1); // TypeDefIndex: 90325; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_32(ref ByteBufStream P0, long P1); // TypeDefIndex: 90326; 0x00000001859B7730-0x00000001859B7740

	public delegate byte[] __HotPatchDelegate_33(object P0, int P1, Beyond.Byte.UInt128 P2, bool P3); // TypeDefIndex: 90327; 0x00000001812674E0-0x0000000181267520

	public delegate void __HotPatchDelegate_34(ref ByteBufStream P0, Beyond.Byte.UInt128 P1); // TypeDefIndex: 90328; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate byte[] __HotPatchDelegate_35(object P0, int P1, ushort P2, bool P3); // TypeDefIndex: 90329; 0x0000000181217F60-0x0000000181217F80

	public delegate byte[] __HotPatchDelegate_36(object P0, int P1, short P2, bool P3); // TypeDefIndex: 90330; 0x0000000181217F60-0x0000000181217F80

	public delegate byte[] __HotPatchDelegate_37(object P0, int P1, object P2, out int P3); // TypeDefIndex: 90331; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_38(ref ByteBufStream P0, object P1); // TypeDefIndex: 90332; 0x00000001859B7730-0x00000001859B7740

	public delegate ByteBufStream __HotPatchDelegate_39(object P0, int P1); // TypeDefIndex: 90333; 0x00000001812C43A0-0x00000001812C43E0

	public delegate ByteBufStream __HotPatchDelegate_40(int P0); // TypeDefIndex: 90334; 0x0000000186464680-0x00000001864646B0

	public delegate float __HotPatchDelegate_41(int P0); // TypeDefIndex: 90335; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_42(object P0, int P1, bool P2); // TypeDefIndex: 90336; 0x00000001811DF7F0-0x00000001811DF810

	public delegate Span<byte> __HotPatchDelegate_43(Span<byte> P0, int P1, uint P2, bool P3); // TypeDefIndex: 90337; 0x00000001887F9D74-0x00000001887F9DCC

	public delegate byte[] __HotPatchDelegate_44(object P0, int P1, int P2, bool P3); // TypeDefIndex: 90338; 0x0000000181217F60-0x0000000181217F80

	public delegate Span<byte> __HotPatchDelegate_45(Span<byte> P0, int P1, ulong P2, bool P3); // TypeDefIndex: 90339; 0x00000001887F9E7C-0x00000001887F9ED4

	public delegate byte[] __HotPatchDelegate_46(object P0, int P1, long P2, bool P3); // TypeDefIndex: 90340; 0x0000000181217F60-0x0000000181217F80

	public delegate Span<byte> __HotPatchDelegate_47(Span<byte> P0, int P1, Beyond.Byte.UInt128 P2, bool P3); // TypeDefIndex: 90341; 0x00000001887F9F84-0x00000001887F9FE8

	public delegate int __HotPatchDelegate_48(float P0); // TypeDefIndex: 90342; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate byte[] __HotPatchDelegate_49(object P0, int P1, float P2); // TypeDefIndex: 90343; 0x000000018124EAD0-0x000000018124EAF0

	public delegate void __HotPatchDelegate_50(long P0, out int P1, out int P2); // TypeDefIndex: 90344; 0x00000001811DF7F0-0x00000001811DF810

	public delegate long __HotPatchDelegate_51(int P0, int P1); // TypeDefIndex: 90345; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_52(object P0, int P1, int P2); // TypeDefIndex: 90346; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_53(object P0); // TypeDefIndex: 90347; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_54(Span<byte> P0, int P1, int P2); // TypeDefIndex: 90348; 0x00000001826DF9A0-0x00000001826DF9D0

	public delegate string __HotPatchDelegate_55(Span<byte> P0); // TypeDefIndex: 90349; 0x0000000186A4F2D0-0x0000000186A4F300

	public delegate void __HotPatchDelegate_56(object P0, Span<byte> P1, int P2, int P3); // TypeDefIndex: 90350; 0x00000001826E9FD0-0x00000001826EA010

	public delegate void __HotPatchDelegate_57(object P0, Span<byte> P1); // TypeDefIndex: 90351; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate Beyond.Byte.UInt128 __HotPatchDelegate_58(object P0, int P1, int P2); // TypeDefIndex: 90352; 0x00000001812D51A0-0x00000001812D51E0
}
