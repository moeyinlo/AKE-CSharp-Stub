/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using Beyond.Byte;
using IFix.Core;

// Image 96: Beyond.Byte.dll - Assembly: Beyond.Byte, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63091-63098
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Byte
{
	[Serializable]
	public struct UInt128 : IComparable<Beyond.Byte.UInt128>, IEquatable<Beyond.Byte.UInt128> // TypeDefIndex: 63092
	{
		// Fields
		public ulong high; // 0x00
		public ulong low; // 0x08
	
		// Constructors
		public UInt128(ulong high, ulong low); // 0x0000000184D861B0-0x0000000184D861C0
		public UInt128(byte[] bytes); // 0x000000018636D300-0x000000018636D33C
	
		// Methods
		[IDTag(1)]
		public override bool Equals(object obj); // 0x000000018636D0AC-0x000000018636D150
		public override int GetHashCode(); // 0x0000000182F7AAE0-0x0000000182F7ACD0
		public static implicit operator UInt128(byte[] bytes); // 0x000000018636D3BC-0x000000018636D430
		public Guid ToGuid(); // 0x000000018636D150-0x000000018636D250
		public int CompareTo(UInt128 other); // 0x000000018636D02C-0x000000018636D0AC
		[IDTag(0)]
		public bool Equals(UInt128 other); // 0x0000000182F7BC80-0x0000000182F7BD00
		public static bool operator ==(UInt128 a, UInt128 b); // 0x000000018636D33C-0x000000018636D3BC
		public static bool operator !=(UInt128 a, UInt128 B); // 0x000000018636D430-0x000000018636D4C0
		public bool __iFixBaseProxy_Equals(object P0); // 0x000000018636D250-0x000000018636D2B0
		public int __iFixBaseProxy_GetHashCode(); // 0x000000018636D2B0-0x000000018636D300
	}

	public struct ByteBufStream // TypeDefIndex: 63093
	{
		// Fields
		public int currentIdx; // 0x00
		public byte[] datas; // 0x08
	
		// Methods
		public int GetCurrentIdx(); // 0x0000000182F7B350-0x0000000182F7B3B0
		public byte[] GetRaw(); // 0x0000000186367FE8-0x0000000186368034
		public byte[] GetDataCopy(); // 0x0000000186367F58-0x0000000186367FE8
		public uint ReadUInt(); // 0x0000000186368034-0x0000000186368090
		public int ReadInt(); // 0x0000000182F78F00-0x0000000182F790A0
		public int ReadByte(); // 0x0000000182F793A0-0x0000000182F79480
		public ulong ReadULong(); // 0x0000000186368090-0x00000001863680EC
		public long ReadLong(); // 0x0000000182F7A6D0-0x0000000182F7A7F0
		public Beyond.Byte.UInt128 ReadUInt128(); // 0x0000000182F78DE0-0x0000000182F78F00
		public string ReadUTF8(); // 0x0000000183117190-0x00000001831171E0
		public void SkipReadUTF8(); // 0x0000000182F7B530-0x0000000182F7B700
		public void WriteByte(byte val); // 0x00000001863680EC-0x0000000186368150
		public void WriteUInt(uint val); // 0x0000000186368294-0x0000000186368300
		public void WriteInt(int val); // 0x0000000186368150-0x00000001863681B0
		public void WriteULong(ulong val); // 0x0000000186368300-0x000000018636836C
		public void WriteLong(long val); // 0x00000001863681B0-0x0000000186368210
		public void WriteUInt128(Beyond.Byte.UInt128 val); // 0x0000000186368210-0x0000000186368294
		public void WriteUTF8(string val); // 0x000000018636836C-0x00000001863683E4
		public void SkipBytes(int offset); // 0x0000000182F7B4A0-0x0000000182F7B530
		public int RemainBytes(); // 0x00000001831170E0-0x0000000183117120
		public static ByteBufStream CreateFromByte(byte[] bs, int startIdx = 0 /* Metadata: 0x023525D6 */); // 0x0000000183117120-0x0000000183117190
		public static ByteBufStream Create(int cap); // 0x0000000186367EB0-0x0000000186367F58
	}

	public static class ByteHelper // TypeDefIndex: 63094
	{
		// Methods
		public static void SplitLong(long longValue, out int highInt, out int lowInt); // 0x00000001863688B8-0x0000000186368928
		public static long MergeLong(int highInt, int lowInt); // 0x0000000186368778-0x00000001863687D4
		public static int SingleToInt32Bits(float value); // 0x0000000186368864-0x00000001863688B8
		public static float Int32BitsToSingle(int value); // 0x0000000186368730-0x0000000186368778
	
		// Extension methods
		public static Beyond.Byte.UInt128 ReadUInt128(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x023525D7 */); // 0x0000000182F79510-0x0000000182F795D0
		public static long ReadLong(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x023525D8 */); // 0x0000000182F7A7F0-0x0000000182F7A8A0
		public static ulong ReadULong(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x023525D9 */); // 0x0000000182F7A8A0-0x0000000182F7AA50
		public static uint ReadUInt(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x023525DA */); // 0x0000000182F791F0-0x0000000182F792E0
		public static int ReadInt(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x023525DB */); // 0x0000000182F790A0-0x0000000182F791F0
		public static ushort ReadUShort(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x023525DC */); // 0x0000000182F792E0-0x0000000182F793A0
		public static short ReadShort(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x023525DD */); // 0x0000000182F78CC0-0x0000000182F78DE0
		public static byte ReadByte(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x023525DE */); // 0x0000000182F79480-0x0000000182F79510
		public static float ReadFloat(this byte[] bs, int startIndex, bool bIsLittle = true /* Metadata: 0x023525DF */); // 0x00000001863687D4-0x0000000186368864
		public static string ReadUTF8(this byte[] bs, int startIndex, out short len); // 0x00000001831171E0-0x0000000183117290
		public static void SkipReadUTF8(this byte[] bs, int startIndex, out short len); // 0x0000000182F78960-0x0000000182F78AC0
		public static byte[] WriteByte(this byte[] data, int writerIndex, byte value); // 0x0000000186368928-0x00000001863689A4
		public static byte[] WriteUShort(this byte[] data, int writerIndex, ushort value, bool bIsLittle = true /* Metadata: 0x023525E0 */); // 0x00000001831439B0-0x0000000183143A40
		public static byte[] WriteShort(this byte[] data, int writerIndex, short value, bool bIsLittle = true /* Metadata: 0x023525E1 */); // 0x0000000186368ABC-0x0000000186368B4C
		[IDTag(0)]
		public static byte[] WriteUInt(this byte[] data, int writerIndex, uint value, bool bIsLittle = true /* Metadata: 0x023525E2 */); // 0x0000000183143A40-0x0000000183143CE0
		[IDTag(1)]
		public static Span<byte> WriteUInt(this Span<byte> data, int writerIndex, uint value, bool bIsLittle = true /* Metadata: 0x023525E3 */); // 0x0000000182F7E7D0-0x0000000182F7E8F0
		public static byte[] WriteInt(this byte[] data, int writerIndex, int value, bool bIsLittle = true /* Metadata: 0x023525E4 */); // 0x0000000183143940-0x00000001831439B0
		[IDTag(0)]
		public static byte[] WriteULong(this byte[] data, int writerIndex, ulong value, bool bIsLittle = true /* Metadata: 0x023525E5 */); // 0x0000000186368C00-0x0000000186368DF8
		[IDTag(1)]
		public static Span<byte> WriteULong(this Span<byte> data, int writerIndex, ulong value, bool bIsLittle = true /* Metadata: 0x023525E6 */); // 0x0000000182F7FF20-0x0000000182F800B0
		public static byte[] WriteLong(this byte[] data, int writerIndex, long value, bool bIsLittle = true /* Metadata: 0x023525E7 */); // 0x0000000186368A30-0x0000000186368ABC
		[IDTag(0)]
		public static byte[] WriteUInt128(this byte[] data, int writerIndex, Beyond.Byte.UInt128 value, bool bIsLittle = true /* Metadata: 0x023525E8 */); // 0x0000000186368B4C-0x0000000186368C00
		[IDTag(1)]
		public static Span<byte> WriteUInt128(this Span<byte> data, int writerIndex, Beyond.Byte.UInt128 value, bool bIsLittle = true /* Metadata: 0x023525E9 */); // 0x0000000182F7BD00-0x0000000182F7BE10
		public static byte[] WriteFloat(this byte[] data, int writerIndex, float value); // 0x00000001863689A4-0x0000000186368A30
		public static byte[] WriteUTF8(this byte[] data, int writerIndex, string value, out int len); // 0x0000000186368DF8-0x0000000186368EE0
		[IDTag(1)]
		public static string GetHexString(this byte[] byteArray); // 0x0000000186368564-0x00000001863685C0
		[IDTag(0)]
		public static string GetHexString(this byte[] byteArray, int startIdx, int length); // 0x00000001863685C0-0x0000000186368730
		[IDTag(3)]
		public static string GetHexString(this Span<byte> byteArray); // 0x0000000182F76D20-0x0000000182F76DA0
		[IDTag(2)]
		public static string GetHexString(this Span<byte> byteArray, int startIdx, int length); // 0x0000000182F7EE90-0x0000000182F7F400
		[IDTag(1)]
		public static void AppendHexString(this UnSafeString str, Span<byte> byteArray); // 0x0000000183C6AF10-0x0000000183C6B320
		[IDTag(0)]
		public static void AppendHexString(this UnSafeString str, Span<byte> byteArray, int startIdx, int length); // 0x0000000182F7F400-0x0000000182F7F7B0
		[IDTag(1)]
		public static string GetHexStringUnsafeString(this Span<byte> byteArray); // 0x0000000183351C90-0x0000000183351D10
		[IDTag(0)]
		public static string GetHexStringUnsafeString(this Span<byte> byteArray, int startIdx, int length); // 0x0000000182F7E220-0x0000000182F7E6A0
		public static Beyond.Byte.UInt128 ComputeMD5Bytes(this byte[] bs, int offset, int count); // 0x00000001863683E4-0x0000000186368564
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63095
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37A30-0x0000000184D37AA0
	
		// Methods
		public bool __Gen_Wrap_0(ref Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1); // 0x0000000186368EE0-0x0000000186369058
		public bool __Gen_Wrap_1(ref Beyond.Byte.UInt128 P0, object P1); // 0x00000001863698D4-0x0000000186369A24
		public int __Gen_Wrap_2(ref Beyond.Byte.UInt128 P0); // 0x000000018636A550-0x000000018636A694
		public Beyond.Byte.UInt128 __Gen_Wrap_3(object P0); // 0x000000018636B318-0x000000018636B410
		public Guid __Gen_Wrap_4(ref Beyond.Byte.UInt128 P0); // 0x000000018636BF4C-0x000000018636C0AC
		public int __Gen_Wrap_5(ref Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1); // 0x000000018636CA70-0x000000018636CBD8
		public bool __Gen_Wrap_6(Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1); // 0x000000018636CBD8-0x000000018636CD00
		public int __Gen_Wrap_7(ref ByteBufStream P0); // 0x000000018636CD00-0x000000018636CE4C
		public byte[] __Gen_Wrap_8(ref ByteBufStream P0); // 0x000000018636CE4C-0x000000018636CF98
		public uint __Gen_Wrap_9(object P0, int P1, bool P2); // 0x0000000186369194-0x0000000186369298
		public uint __Gen_Wrap_10(ref ByteBufStream P0); // 0x0000000186369058-0x0000000186369194
		public int __Gen_Wrap_11(object P0, int P1, bool P2); // 0x0000000186369194-0x0000000186369298
		public byte __Gen_Wrap_12(object P0, int P1, bool P2); // 0x0000000186369194-0x0000000186369298
		public ulong __Gen_Wrap_13(object P0, int P1, bool P2); // 0x0000000186369298-0x000000018636939C
		public ulong __Gen_Wrap_14(ref ByteBufStream P0); // 0x000000018636939C-0x00000001863694D8
		public long __Gen_Wrap_15(object P0, int P1, bool P2); // 0x0000000186369298-0x000000018636939C
		public long __Gen_Wrap_16(ref ByteBufStream P0); // 0x00000001863694D8-0x0000000186369624
		public Beyond.Byte.UInt128 __Gen_Wrap_17(object P0, int P1, bool P2); // 0x0000000186369624-0x000000018636975C
		public Beyond.Byte.UInt128 __Gen_Wrap_18(ref ByteBufStream P0); // 0x000000018636975C-0x00000001863698D4
		public ushort __Gen_Wrap_19(object P0, int P1, bool P2); // 0x0000000186369194-0x0000000186369298
		public short __Gen_Wrap_20(object P0, int P1, bool P2); // 0x0000000186369194-0x0000000186369298
		public string __Gen_Wrap_21(object P0, int P1, out short P2); // 0x0000000186369A24-0x0000000186369B70
		public string __Gen_Wrap_22(ref ByteBufStream P0); // 0x0000000186369B70-0x0000000186369CD0
		public void __Gen_Wrap_23(object P0, int P1, out short P2); // 0x0000000186369CD0-0x0000000186369DE8
		public void __Gen_Wrap_24(ref ByteBufStream P0); // 0x0000000186369DE8-0x0000000186369F24
		public byte[] __Gen_Wrap_25(object P0, int P1, byte P2); // 0x0000000186369F24-0x000000018636A038
		public void __Gen_Wrap_26(ref ByteBufStream P0, byte P1); // 0x000000018636A038-0x000000018636A180
		public byte[] __Gen_Wrap_27(object P0, int P1, uint P2, bool P3); // 0x000000018636A180-0x000000018636A2B4
		public void __Gen_Wrap_28(ref ByteBufStream P0, uint P1); // 0x000000018636A2B4-0x000000018636A3F8
		public void __Gen_Wrap_29(ref ByteBufStream P0, int P1); // 0x000000018636A3F8-0x000000018636A550
		public byte[] __Gen_Wrap_30(object P0, int P1, ulong P2, bool P3); // 0x000000018636A694-0x000000018636A7BC
		public void __Gen_Wrap_31(ref ByteBufStream P0, ulong P1); // 0x000000018636A7BC-0x000000018636A904
		public void __Gen_Wrap_32(ref ByteBufStream P0, long P1); // 0x000000018636A904-0x000000018636AA4C
		public byte[] __Gen_Wrap_33(object P0, int P1, Beyond.Byte.UInt128 P2, bool P3); // 0x000000018636AA4C-0x000000018636AB94
		public void __Gen_Wrap_34(ref ByteBufStream P0, Beyond.Byte.UInt128 P1); // 0x000000018636AB94-0x000000018636AD00
		public byte[] __Gen_Wrap_35(object P0, int P1, ushort P2, bool P3); // 0x000000018636AD00-0x000000018636AE34
		public byte[] __Gen_Wrap_36(object P0, int P1, short P2, bool P3); // 0x000000018636AE34-0x000000018636AF5C
		public byte[] __Gen_Wrap_37(object P0, int P1, object P2, out int P3); // 0x000000018636AF5C-0x000000018636B0A8
		public void __Gen_Wrap_38(ref ByteBufStream P0, object P1); // 0x000000018636B0A8-0x000000018636B1F0
		public ByteBufStream __Gen_Wrap_39(object P0, int P1); // 0x000000018636B1F0-0x000000018636B318
		public ByteBufStream __Gen_Wrap_40(int P0); // 0x000000018636B410-0x000000018636B508
		public float __Gen_Wrap_41(int P0); // 0x000000018636B508-0x000000018636B5C0
		public float __Gen_Wrap_42(object P0, int P1, bool P2); // 0x000000018636B5C0-0x000000018636B6B4
		public Span<byte> __Gen_Wrap_43(Span<byte> P0, int P1, uint P2, bool P3); // 0x000000018636B6B4-0x000000018636B820
		public byte[] __Gen_Wrap_44(object P0, int P1, int P2, bool P3); // 0x000000018636B820-0x000000018636B954
		public Span<byte> __Gen_Wrap_45(Span<byte> P0, int P1, ulong P2, bool P3); // 0x000000018636B954-0x000000018636BAC0
		public byte[] __Gen_Wrap_46(object P0, int P1, long P2, bool P3); // 0x000000018636BAC0-0x000000018636BBE8
		public Span<byte> __Gen_Wrap_47(Span<byte> P0, int P1, Beyond.Byte.UInt128 P2, bool P3); // 0x000000018636BBE8-0x000000018636BD7C
		public int __Gen_Wrap_48(float P0); // 0x000000018636BD7C-0x000000018636BE38
		public byte[] __Gen_Wrap_49(object P0, int P1, float P2); // 0x000000018636BE38-0x000000018636BF4C
		public void __Gen_Wrap_50(long P0, out int P1, out int P2); // 0x000000018636C0AC-0x000000018636C1D4
		public long __Gen_Wrap_51(int P0, int P1); // 0x000000018636C1D4-0x000000018636C2A8
		public string __Gen_Wrap_52(object P0, int P1, int P2); // 0x000000018636C2A8-0x000000018636C3BC
		public string __Gen_Wrap_53(object P0); // 0x000000018636C3BC-0x000000018636C498
		public string __Gen_Wrap_54(Span<byte> P0, int P1, int P2); // 0x000000018636C498-0x000000018636C5E4
		public string __Gen_Wrap_55(Span<byte> P0); // 0x000000018636C5E4-0x000000018636C6FC
		public void __Gen_Wrap_56(object P0, Span<byte> P1, int P2, int P3); // 0x000000018636C6FC-0x000000018636C838
		public void __Gen_Wrap_57(object P0, Span<byte> P1); // 0x000000018636C838-0x000000018636C94C
		public Beyond.Byte.UInt128 __Gen_Wrap_58(object P0, int P1, int P2); // 0x000000018636C94C-0x000000018636CA70
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 63096
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018636CF98-0x000000018636D02C
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 63097
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018636D6A8-0x000000018636D70C
		public static bool IsPatched(int id); // 0x0000000182F7AA50-0x0000000182F7AAE0
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018636D564-0x000000018636D630
		public object CreateWrapper(int id); // 0x000000018636D630-0x000000018636D6A8
		public object InitWrapperArray(int len); // 0x000000018636D70C-0x000000018636D864
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018636D4C0-0x000000018636D564
	}

	public enum IDMAP0 // TypeDefIndex: 63098
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
