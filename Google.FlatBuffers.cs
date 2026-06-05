/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using Unity.Collections;

// Image 98: Google.FlatBuffers.dll - Assembly: Google.FlatBuffers, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60569-60585

namespace Google.FlatBuffers
{
	public struct ByteData // TypeDefIndex: 60572
	{
		// Fields
		private unsafe byte* _buffer; // 0x00
		private int _length; // 0x08
	
		// Properties
		public unsafe byte* Buffer { get => default; } // 0x00000001834AFB60-0x00000001834AFB70 
		public int Length { get => default; } // 0x0000000181B7E450-0x0000000181B7E460 
		public Span<byte> Span { get => default; } // 0x000000018A6645D0-0x000000018A66462C 
		public ReadOnlySpan<byte> ReadOnlySpan { get => default; } // 0x00000001840A68F0-0x00000001840A7410 
	
		// Constructors
		public unsafe ByteData(NativeArray<byte> buffer) : this() {
			_buffer = default;
			_length = default;
		} // 0x000000018457A7B0-0x000000018457A920
	
		// Methods
		public bool IsCreated() => default; // 0x0000000184443DF0-0x0000000184443E00
		public static unsafe Span<T> ToSpan<T>(T* ptr, int length)
			where T : struct => default;
		public static unsafe ReadOnlySpan<T> ToReadOnlySpan<T>(T* ptr, int length)
			where T : struct => default;
	}

	public struct ByteBuffer // TypeDefIndex: 60573
	{
		// Fields
		private ByteData _buffer; // 0x00
		private int _pos; // 0x10
		private static Dictionary<System.Type, int> genericSizes; // 0x00
	
		// Properties
		public int Position { get => default; set {} } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x0000000181378230-0x0000000181378240
		public int Length { get => default; } // 0x0000000181B7E450-0x0000000181B7E460 
	
		// Constructors
		public ByteBuffer(ByteData allocator, int position) : this() {
			_buffer = default;
			_pos = default;
		} // 0x000000018357CA90-0x000000018357CAA0
		public ByteBuffer(NativeArray<byte> buffer) : this() {
			_buffer = default;
			_pos = default;
		} // 0x000000018457A6C0-0x000000018457A730
		public ByteBuffer(NativeArray<byte> buffer, int pos) : this() {
			_buffer = default;
			_pos = default;
		} // 0x000000018457A730-0x000000018457A7B0
		static ByteBuffer() {
			genericSizes = default;
		} // 0x0000000185801130-0x0000000185801430
	
		// Methods
		public bool IsCreated() => default; // 0x0000000184443DF0-0x0000000184443E00
		public void Reset() {} // 0x0000000185FBA4D0-0x0000000185FBA4E0
		public ByteBuffer Duplicate() => default; // 0x000000018A663554-0x000000018A6635B8
		public byte[] ToArray(int pos, int len) => default; // 0x000000018A664378-0x000000018A6643E8
		public static int SizeOf<T>() => default;
		public static bool IsSupportedType<T>() => default;
		public static int ArraySize<T>(T[] x) => default;
		public static int ArraySize<T>(ArraySegment<T> x) => default;
		public static int ArraySize<T>(Span<T> x) => default;
		public ReadOnlySpan<T> ToSpanSlice<T>(int pos, int count)
			where T : struct => default;
		public T[] ToArray<T>(int pos, int count)
			where T : struct => default;
		public NativeArray<T> ToNativeArray<T>(int pos, int count)
			where T : struct => default;
		public byte[] ToSizedArray() => default; // 0x000000018A664440-0x000000018A66449C
		public byte[] ToFullArray() => default; // 0x000000018A6643E8-0x000000018A664440
		public Span<byte> ToSpan(int pos, int len) => default; // 0x000000018A66449C-0x000000018A664534
		public unsafe byte* GetUnsafePtr() => default; // 0x00000001834AFB60-0x00000001834AFB70
		private void WriteLittleEndian(int offset, int count, ulong data) {} // 0x000000018A664534-0x000000018A6645D0
		private ulong ReadLittleEndian(int offset, int count) => default; // 0x000000018A6642B8-0x000000018A664378
		private void AssertOffsetAndLength(int offset, int length) {} // 0x0000000185492010-0x0000000185492020
		public void PutSbyte(int offset, sbyte value) {} // 0x000000018A663E48-0x000000018A663EC0
		public void PutByte(int offset, byte value) {} // 0x000000018A663B18-0x000000018A663B90
		public void PutByte(int offset, byte value, int count) {} // 0x000000018A663B90-0x000000018A663C70
		public void Put(int offset, byte value) {} // 0x000000018A664258-0x000000018A6642B8
		public void PutStringUTF8(int offset, string value) {} // 0x000000018A663F20-0x000000018A66400C
		public void PutShort(int offset, short value) {} // 0x000000018A663EC0-0x000000018A663F20
		public void PutUshort(int offset, ushort value) {} // 0x000000018A664158-0x000000018A664258
		public void PutInt(int offset, int value) {} // 0x000000018A663D88-0x000000018A663DE8
		public void PutUint(int offset, uint value) {} // 0x000000018A66400C-0x000000018A6640B0
		public void PutLong(int offset, long value) {} // 0x000000018A663DE8-0x000000018A663E48
		public void PutUlong(int offset, ulong value) {} // 0x000000018A6640B0-0x000000018A664158
		public void PutFloat(int offset, float value) {} // 0x000000018A663CFC-0x000000018A663D88
		public void PutDouble(int offset, double value) {} // 0x000000018A663C70-0x000000018A663CFC
		public sbyte GetSbyte(int index) => default; // 0x000000018A663760-0x000000018A6637CC
		public byte Get(int index) => default; // 0x000000018A663AAC-0x000000018A663B18
		public string GetStringUTF8(int startPos, int len) => default; // 0x000000018A663820-0x000000018A6638E4
		public short GetShort(int offset) => default; // 0x000000018A6637CC-0x000000018A663820
		public ushort GetUshort(int offset) => default; // 0x000000018A663A14-0x000000018A663AAC
		public int GetInt(int offset) => default; // 0x000000018A6636B8-0x000000018A66370C
		public uint GetUint(int offset) => default; // 0x000000018A6638E4-0x000000018A66397C
		public long GetLong(int offset) => default; // 0x000000018A66370C-0x000000018A663760
		public ulong GetUlong(int offset) => default; // 0x000000018A66397C-0x000000018A663A14
		public float GetFloat(int offset) => default; // 0x000000018A663638-0x000000018A6636B8
		public double GetDouble(int offset) => default; // 0x000000018A6635B8-0x000000018A663638
		public int Put<T>(int offset, T[] x)
			where T : struct => default;
		public int Put<T>(int offset, ArraySegment<T> x)
			where T : struct => default;
		public int Put<T>(int offset, IntPtr ptr, int sizeInBytes)
			where T : struct => default;
		public int Put<T>(int offset, Span<T> x)
			where T : struct => default;
	}

	public class ByteBufferUtil // TypeDefIndex: 60574
	{
		// Constructors
		public ByteBufferUtil() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static int GetSizePrefix(ByteBuffer bb) => default; // 0x000000018A663490-0x000000018A6634DC
		public static ByteBuffer RemoveSizePrefix(ByteBuffer bb) => default; // 0x000000018A6634DC-0x000000018A663554
	}

	public class FlatBufferBuilder : IDisposable // TypeDefIndex: 60575
	{
		// Fields
		private int _space; // 0x10
		private NativeArray<byte> _data; // 0x18
		private ByteBuffer _bb; // 0x28
		private int _minAlign; // 0x40
		private int[] _vtable; // 0x48
		private int _vtableSize; // 0x50
		private int _objectStart; // 0x54
		private int[] _vtables; // 0x58
		private int _numVtables; // 0x60
		private int _vectorNumElems; // 0x64
		private Dictionary<string, StringOffset> _sharedStringMap; // 0x68
		private bool _ForceDefaults_k__BackingField; // 0x70
	
		// Properties
		public bool ForceDefaults { get; set; } // 0x0000000185FB0950-0x0000000185FB0960 0x0000000185FB0970-0x0000000185FB0980
		public int Offset { get => default; } // 0x000000018A6667F0-0x000000018A666838 
		public ByteBuffer DataBuffer { get => default; } // 0x0000000185FC8CD0-0x0000000185FC8CF0 
	
		// Constructors
		public FlatBufferBuilder() {} // Dummy constructor
		public FlatBufferBuilder(int initialSize) {} // 0x000000018A66665C-0x000000018A6667F0
	
		// Methods
		public void Dispose() {} // 0x000000018A6655AC-0x000000018A6655E8
		public void Clear() {} // 0x000000018A665230-0x000000018A6652E0
		public void Pad(int size) {} // 0x000000018A665DA8-0x000000018A665E14
		private void GrowBuffer() {} // 0x000000018A665B40-0x000000018A665CD0
		public void Prep(int size, int additionalBytes) {} // 0x000000018A665E14-0x000000018A665EC0
		public void PutBool(bool x) {} // 0x000000018A665EC0-0x000000018A665F28
		public void PutSbyte(sbyte x) {} // 0x000000018A666130-0x000000018A666198
		public void PutByte(byte x) {} // 0x000000018A665F28-0x000000018A665F90
		public void PutShort(short x) {} // 0x000000018A666198-0x000000018A666200
		public void PutUshort(ushort x) {} // 0x000000018A6662D0-0x000000018A666338
		public void PutInt(int x) {} // 0x000000018A666060-0x000000018A6660C8
		public void PutUint(uint x) {} // 0x000000018A666200-0x000000018A666268
		public void PutLong(long x) {} // 0x000000018A6660C8-0x000000018A666130
		public void PutUlong(ulong x) {} // 0x000000018A666268-0x000000018A6662D0
		public void PutFloat(float x) {} // 0x000000018A665FF8-0x000000018A666060
		public void Put<T>(T[] x)
			where T : struct {}
		public void Put<T>(ArraySegment<T> x)
			where T : struct {}
		public void Put<T>(IntPtr ptr, int sizeInBytes)
			where T : struct {}
		public void Put<T>(Span<T> x)
			where T : struct {}
		public void PutDouble(double x) {} // 0x000000018A665F90-0x000000018A665FF8
		public void AddBool(bool x) {} // 0x000000018A6646B4-0x000000018A6646EC
		public void AddSbyte(sbyte x) {} // 0x000000018A664CFC-0x000000018A664D34
		public void AddByte(byte x) {} // 0x000000018A664730-0x000000018A664768
		public void AddShort(short x) {} // 0x000000018A664EC8-0x000000018A664F00
		public void AddUshort(ushort x) {} // 0x000000018A6651F8-0x000000018A665230
		public void AddInt(int x) {} // 0x000000018A664A38-0x000000018A664A70
		public void AddUint(uint x) {} // 0x000000018A664F7C-0x000000018A664FB4
		public void AddLong(long x) {} // 0x000000018A664B34-0x000000018A664B6C
		public void AddUlong(ulong x) {} // 0x000000018A6650F8-0x000000018A665130
		public void AddFloat(float x) {} // 0x000000018A664978-0x000000018A6649B4
		public void Add<T>(T[] x)
			where T : struct {}
		public void Add<T>(ArraySegment<T> x)
			where T : struct {}
		public void Add<T>(IntPtr ptr, int sizeInBytes)
			where T : struct {}
		public void Add<T>(Span<T> x)
			where T : struct {}
		public void AddDouble(double x) {} // 0x000000018A6648F4-0x000000018A664930
		public void AddOffset(int off) {} // 0x000000018A664C2C-0x000000018A664CC0
		public void StartVector(int elemSize, int count, int alignment) {} // 0x000000018A6665F4-0x000000018A66665C
		public VectorOffset EndVector() => default; // 0x000000018A66591C-0x000000018A665940
		public VectorOffset CreateVectorOfTables<T>(Offset<T>[] offsets)
			where T : struct => default;
		public void Nested(int obj) {} // 0x000000018A665CD0-0x000000018A665D40
		public void NotNested() {} // 0x000000018A665D40-0x000000018A665DA8
		public void StartTable(int numfields) {} // 0x000000018A666520-0x000000018A6665F4
		public void Slot(int voffset) {} // 0x000000018A666490-0x000000018A666520
		public void AddBool(int o, bool x, bool d) {} // 0x000000018A6646EC-0x000000018A664730
		public void AddBool(int o, bool? x) {} // 0x000000018A66462C-0x000000018A6646B4
		public void AddSbyte(int o, sbyte x, sbyte d) {} // 0x000000018A664DBC-0x000000018A664E00
		public void AddSbyte(int o, sbyte? x) {} // 0x000000018A664D34-0x000000018A664DBC
		public void AddByte(int o, byte x, byte d) {} // 0x000000018A6647F0-0x000000018A664834
		public void AddByte(int o, byte? x) {} // 0x000000018A664768-0x000000018A6647F0
		public void AddShort(int o, short x, int d) {} // 0x000000018A664E00-0x000000018A664E44
		public void AddShort(int o, short? x) {} // 0x000000018A664E44-0x000000018A664EC8
		public void AddUshort(int o, ushort x, ushort d) {} // 0x000000018A6651B4-0x000000018A6651F8
		public void AddUshort(int o, ushort? x) {} // 0x000000018A665130-0x000000018A6651B4
		public void AddInt(int o, int x, int d) {} // 0x000000018A664A70-0x000000018A664AB0
		public void AddInt(int o, int? x) {} // 0x000000018A664AB0-0x000000018A664B34
		public void AddUint(int o, uint x, uint d) {} // 0x000000018A664F3C-0x000000018A664F7C
		public void AddUint(int o, uint? x) {} // 0x000000018A664FB4-0x000000018A665038
		public void AddLong(int o, long x, long d) {} // 0x000000018A664BEC-0x000000018A664C2C
		public void AddLong(int o, long? x) {} // 0x000000018A664B6C-0x000000018A664BEC
		public void AddUlong(int o, ulong x, ulong d) {} // 0x000000018A6650B8-0x000000018A6650F8
		public void AddUlong(int o, ulong? x) {} // 0x000000018A665038-0x000000018A6650B8
		public void AddFloat(int o, float x, double d) {} // 0x000000018A664930-0x000000018A664978
		public void AddFloat(int o, float? x) {} // 0x000000018A6649B4-0x000000018A664A38
		public void AddDouble(int o, double x, double d) {} // 0x000000018A6648B4-0x000000018A6648F4
		public void AddDouble(int o, double? x) {} // 0x000000018A664834-0x000000018A6648B4
		public void AddOffset(int o, int x, int d) {} // 0x000000018A664CC0-0x000000018A664CFC
		public StringOffset CreateString(string s) => default; // 0x000000018A665404-0x000000018A6654E4
		public StringOffset CreateUTF8String(Span<byte> chars) => default; // 0x000000018A6654E4-0x000000018A6655AC
		public StringOffset CreateSharedString(string s) => default; // 0x000000018A6652E0-0x000000018A665404
		public void AddStruct(int voffset, int x, int d) {} // 0x000000018A664F00-0x000000018A664F3C
		public int EndTable() => default; // 0x000000018A6655E8-0x000000018A66591C
		public void Required(int table, int field) {} // 0x000000018A666338-0x000000018A666444
		protected void Finish(int rootTable, bool sizePrefix) {} // 0x000000018A665968-0x000000018A665A04
		public void Finish(int rootTable) {} // 0x000000018A665B18-0x000000018A665B24
		public void FinishSizePrefixed(int rootTable) {} // 0x000000018A66595C-0x000000018A665968
		public byte[] SizedByteArray() => default; // 0x000000018A666444-0x000000018A666490
		protected void Finish(int rootTable, string fileIdentifier, bool sizePrefix) {} // 0x000000018A665A04-0x000000018A665B18
		public void Finish(int rootTable, string fileIdentifier) {} // 0x000000018A665B24-0x000000018A665B40
		public void FinishSizePrefixed(int rootTable, string fileIdentifier) {} // 0x000000018A665940-0x000000018A66595C
	}

	public static class FlatBufferConstants // TypeDefIndex: 60576
	{
		// Fields
		public const int FileIdentifierLength = 4; // Metadata: 0x02082A10
		public const int SizePrefixLength = 4; // Metadata: 0x02082A11
	
		// Methods
		public static void FLATBUFFERS_23_1_21() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class FlatBufferUtils // TypeDefIndex: 60579
	{
		// Nested types
		public struct UnionForShort // TypeDefIndex: 60577
		{
			// Fields
			public short shortVal; // 0x00
			public ushort ushortVal; // 0x00
		}
	
		public struct UnionForLong // TypeDefIndex: 60578
		{
			// Fields
			public long longVal; // 0x00
			public float floatValLow; // 0x00
			public float floatValHigh; // 0x04
		}
	
		// Methods
		public static short ReinterpretAsShort(ushort val) => default; // 0x0000000185FB1400-0x0000000185FB1410
		public static ushort ReinterpretAsUShort(short val) => default; // 0x0000000185FB1400-0x0000000185FB1410
		public static void ReinterpretAsFloat(long val, out float floatValLow, out float floatValHigh) {
			floatValLow = default;
			floatValHigh = default;
		} // 0x0000000185FCC750-0x0000000185FCC770
		public static Span<T> AsSpan<T>(NativeArray<T> nativeArray)
			where T : struct => default;
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(NativeArray<T> nativeArray)
			where T : struct => default;
	}

	public interface IFlatbufferObject // TypeDefIndex: 60580
	{
		// Properties
		ByteBuffer ByteBuffer { get; }
	
		// Methods
		void __init(int _i, ByteBuffer _bb);
	}

	public struct Offset<T> // TypeDefIndex: 60581
		where T : struct
	{
		// Fields
		public int Value;
	
		// Constructors
		public Offset(int value) {
			Value = default;
		}
	}

	public struct StringOffset // TypeDefIndex: 60582
	{
		// Fields
		public int Value; // 0x00
	
		// Constructors
		public StringOffset(int value) {
			Value = default;
		} // 0x00000001818AA390-0x00000001818AA3A0
	}

	public struct VectorOffset // TypeDefIndex: 60583
	{
		// Fields
		public int Value; // 0x00
	
		// Constructors
		public VectorOffset(int value) {
			Value = default;
		} // 0x00000001818AA390-0x00000001818AA3A0
	}

	public struct Struct // TypeDefIndex: 60584
	{
		// Fields
		private int _bb_pos_k__BackingField; // 0x00
		private ByteBuffer _bb_k__BackingField; // 0x08
	
		// Properties
		public int bb_pos { get; private set; } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public ByteBuffer bb { get; private set; } // 0x0000000181EBBAA0-0x0000000181EBBAC0 0x0000000185FCC790-0x0000000185FCC7B0
	
		// Constructors
		public Struct(int _i, ByteBuffer _bb) : this() {
			<bb_pos>k__BackingField = default;
			<bb>k__BackingField = default;
		} // 0x0000000185FCC770-0x0000000185FCC790
	}

	public struct Table // TypeDefIndex: 60585
	{
		// Fields
		private int _bb_pos_k__BackingField; // 0x00
		private ByteBuffer _bb_k__BackingField; // 0x08
	
		// Properties
		public int bb_pos { get; private set; } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public ByteBuffer bb { get; private set; } // 0x0000000181EBBAA0-0x0000000181EBBAC0 0x0000000185FCC790-0x0000000185FCC7B0
		public ByteBuffer ByteBuffer { get => default; } // 0x0000000181EBBAA0-0x0000000181EBBAC0 
	
		// Constructors
		public Table(int _i, ByteBuffer _bb) : this() {
			<bb_pos>k__BackingField = default;
			<bb>k__BackingField = default;
		} // 0x0000000185FCC770-0x0000000185FCC790
	
		// Methods
		public int __offset(int vtableOffset) => default; // 0x000000018A666CB4-0x000000018A666D90
		public static int __offset(int vtableOffset, int offset, ByteBuffer bb) => default; // 0x000000018A666C3C-0x000000018A666CB4
		public int __indirect(int offset) => default; // 0x000000018A666BD8-0x000000018A666C3C
		public static int __indirect(int offset, ByteBuffer bb) => default; // 0x000000018A666B80-0x000000018A666BD8
		public string __string(int offset) => default; // 0x0000000184465540-0x00000001844656E0
		public int __vector_len(int offset) => default; // 0x000000018A666D90-0x000000018A666E18
		public int __vector(int offset) => default; // 0x000000018A666E18-0x000000018A66753C
		public Span<T> __vector_as_span<T>(int offset, int elementSize)
			where T : struct => default;
		public T[] __vector_as_array<T>(int offset)
			where T : struct => default;
		public T __union<T>(int offset)
			where T : struct, IFlatbufferObject => default;
		public static bool __has_identifier(ByteBuffer bb, string ident) => default; // 0x000000018A666A58-0x000000018A666B80
		public static int CompareStrings(int offset_1, int offset_2, ByteBuffer bb) => default; // 0x000000018A666940-0x000000018A666A58
		public static int CompareStrings(int offset_1, byte[] key, ByteBuffer bb) => default; // 0x000000018A666838-0x000000018A666940
	}
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 60570
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 60571
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}
