/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;

// Image 95: Google.FlatBuffers.dll - Assembly: Google.FlatBuffers, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59465-59481
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Google.FlatBuffers
{
	public struct ByteData // TypeDefIndex: 59468
	{
		// Fields
		private unsafe byte* _buffer; // 0x00
		private int _length; // 0x08
	
		// Properties
		public unsafe byte* Buffer { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
		public int Length { get => default; } // 0x0000000183D516F0-0x0000000183D51700 
		public Span<byte> Span { get => default; } // 0x000000018853ABBC-0x000000018853AC18 
		public ReadOnlySpan<byte> ReadOnlySpan { get => default; } // 0x00000001823327B0-0x00000001823332D0 
	
		// Constructors
		public unsafe ByteData(NativeArray<byte> buffer) : this() {
			_buffer = default;
			_length = default;
		} // 0x0000000182F46190-0x0000000182F461E0
	
		// Methods
		public bool IsCreated() => default; // 0x00000001822B9B50-0x00000001822B9B60
		public static unsafe Span<T> ToSpan<T>(T* ptr, int length)
			where T : struct => default;
		public static unsafe ReadOnlySpan<T> ToReadOnlySpan<T>(T* ptr, int length)
			where T : struct => default;
	}

	public struct ByteBuffer // TypeDefIndex: 59469
	{
		// Fields
		private ByteData _buffer; // 0x00
		private int _pos; // 0x10
		private static Dictionary<System.Type, int> genericSizes; // 0x00
	
		// Properties
		public int Position { get => default; set {} } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public int Length { get => default; } // 0x0000000183D516F0-0x0000000183D51700 
	
		// Constructors
		public ByteBuffer(ByteData allocator, int position) : this() {
			_buffer = default;
			_pos = default;
		} // 0x0000000183D675E0-0x0000000183D675F0
		public ByteBuffer(NativeArray<byte> buffer) : this() {
			_buffer = default;
			_pos = default;
		} // 0x0000000182F460A0-0x0000000182F46110
		public ByteBuffer(NativeArray<byte> buffer, int pos) : this() {
			_buffer = default;
			_pos = default;
		} // 0x0000000182F46110-0x0000000182F46190
		static ByteBuffer() {
			genericSizes = default;
		} // 0x00000001837060D0-0x00000001837063D0
	
		// Methods
		public bool IsCreated() => default; // 0x00000001822B9B50-0x00000001822B9B60
		public void Reset() {} // 0x0000000183D58F70-0x0000000183D58F80
		public ByteBuffer Duplicate() => default; // 0x0000000188539B40-0x0000000188539BA4
		public byte[] ToArray(int pos, int len) => default; // 0x000000018853A964-0x000000018853A9D4
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
		public byte[] ToSizedArray() => default; // 0x000000018853AA2C-0x000000018853AA88
		public byte[] ToFullArray() => default; // 0x000000018853A9D4-0x000000018853AA2C
		public Span<byte> ToSpan(int pos, int len) => default; // 0x000000018853AA88-0x000000018853AB20
		public unsafe byte* GetUnsafePtr() => default; // 0x00000001820C61B0-0x00000001820C61C0
		private void WriteLittleEndian(int offset, int count, ulong data) {} // 0x000000018853AB20-0x000000018853ABBC
		private ulong ReadLittleEndian(int offset, int count) => default; // 0x000000018853A8A4-0x000000018853A964
		private void AssertOffsetAndLength(int offset, int length) {} // 0x000000018350B670-0x000000018350B680
		public void PutSbyte(int offset, sbyte value) {} // 0x000000018853A434-0x000000018853A4AC
		public void PutByte(int offset, byte value) {} // 0x000000018853A104-0x000000018853A17C
		public void PutByte(int offset, byte value, int count) {} // 0x000000018853A17C-0x000000018853A25C
		public void Put(int offset, byte value) {} // 0x000000018853A844-0x000000018853A8A4
		public void PutStringUTF8(int offset, string value) {} // 0x000000018853A50C-0x000000018853A5F8
		public void PutShort(int offset, short value) {} // 0x000000018853A4AC-0x000000018853A50C
		public void PutUshort(int offset, ushort value) {} // 0x000000018853A744-0x000000018853A844
		public void PutInt(int offset, int value) {} // 0x000000018853A374-0x000000018853A3D4
		public void PutUint(int offset, uint value) {} // 0x000000018853A5F8-0x000000018853A69C
		public void PutLong(int offset, long value) {} // 0x000000018853A3D4-0x000000018853A434
		public void PutUlong(int offset, ulong value) {} // 0x000000018853A69C-0x000000018853A744
		public void PutFloat(int offset, float value) {} // 0x000000018853A2E8-0x000000018853A374
		public void PutDouble(int offset, double value) {} // 0x000000018853A25C-0x000000018853A2E8
		public sbyte GetSbyte(int index) => default; // 0x0000000188539D4C-0x0000000188539DB8
		public byte Get(int index) => default; // 0x000000018853A098-0x000000018853A104
		public string GetStringUTF8(int startPos, int len) => default; // 0x0000000188539E0C-0x0000000188539ED0
		public short GetShort(int offset) => default; // 0x0000000188539DB8-0x0000000188539E0C
		public ushort GetUshort(int offset) => default; // 0x000000018853A000-0x000000018853A098
		public int GetInt(int offset) => default; // 0x0000000188539CA4-0x0000000188539CF8
		public uint GetUint(int offset) => default; // 0x0000000188539ED0-0x0000000188539F68
		public long GetLong(int offset) => default; // 0x0000000188539CF8-0x0000000188539D4C
		public ulong GetUlong(int offset) => default; // 0x0000000188539F68-0x000000018853A000
		public float GetFloat(int offset) => default; // 0x0000000188539C24-0x0000000188539CA4
		public double GetDouble(int offset) => default; // 0x0000000188539BA4-0x0000000188539C24
		public int Put<T>(int offset, T[] x)
			where T : struct => default;
		public int Put<T>(int offset, ArraySegment<T> x)
			where T : struct => default;
		public int Put<T>(int offset, IntPtr ptr, int sizeInBytes)
			where T : struct => default;
		public int Put<T>(int offset, Span<T> x)
			where T : struct => default;
	}

	public class ByteBufferUtil // TypeDefIndex: 59470
	{
		// Constructors
		public ByteBufferUtil() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static int GetSizePrefix(ByteBuffer bb) => default; // 0x0000000188539A7C-0x0000000188539AC8
		public static ByteBuffer RemoveSizePrefix(ByteBuffer bb) => default; // 0x0000000188539AC8-0x0000000188539B40
	}

	public class FlatBufferBuilder : IDisposable // TypeDefIndex: 59471
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
	
		// Properties
		public bool ForceDefaults { get; set; } // 0x0000000183D4F260-0x0000000183D4F270 0x0000000183D4F290-0x0000000183D4F2A0
		public int Offset { get => default; } // 0x000000018853CDDC-0x000000018853CE24 
		public ByteBuffer DataBuffer { get => default; } // 0x0000000183D67F30-0x0000000183D67F50 
	
		// Constructors
		public FlatBufferBuilder() {} // Dummy constructor
		public FlatBufferBuilder(int initialSize) {} // 0x000000018853CC48-0x000000018853CDDC
	
		// Methods
		public void Dispose() {} // 0x000000018853BB98-0x000000018853BBD4
		public void Clear() {} // 0x000000018853B81C-0x000000018853B8CC
		public void Pad(int size) {} // 0x000000018853C394-0x000000018853C400
		private void GrowBuffer() {} // 0x000000018853C12C-0x000000018853C2BC
		public void Prep(int size, int additionalBytes) {} // 0x000000018853C400-0x000000018853C4AC
		public void PutBool(bool x) {} // 0x000000018853C4AC-0x000000018853C514
		public void PutSbyte(sbyte x) {} // 0x000000018853C71C-0x000000018853C784
		public void PutByte(byte x) {} // 0x000000018853C514-0x000000018853C57C
		public void PutShort(short x) {} // 0x000000018853C784-0x000000018853C7EC
		public void PutUshort(ushort x) {} // 0x000000018853C8BC-0x000000018853C924
		public void PutInt(int x) {} // 0x000000018853C64C-0x000000018853C6B4
		public void PutUint(uint x) {} // 0x000000018853C7EC-0x000000018853C854
		public void PutLong(long x) {} // 0x000000018853C6B4-0x000000018853C71C
		public void PutUlong(ulong x) {} // 0x000000018853C854-0x000000018853C8BC
		public void PutFloat(float x) {} // 0x000000018853C5E4-0x000000018853C64C
		public void Put<T>(T[] x)
			where T : struct {}
		public void Put<T>(ArraySegment<T> x)
			where T : struct {}
		public void Put<T>(IntPtr ptr, int sizeInBytes)
			where T : struct {}
		public void Put<T>(Span<T> x)
			where T : struct {}
		public void PutDouble(double x) {} // 0x000000018853C57C-0x000000018853C5E4
		public void AddBool(bool x) {} // 0x000000018853ACA0-0x000000018853ACD8
		public void AddSbyte(sbyte x) {} // 0x000000018853B2E8-0x000000018853B320
		public void AddByte(byte x) {} // 0x000000018853AD1C-0x000000018853AD54
		public void AddShort(short x) {} // 0x000000018853B4B4-0x000000018853B4EC
		public void AddUshort(ushort x) {} // 0x000000018853B7E4-0x000000018853B81C
		public void AddInt(int x) {} // 0x000000018853B024-0x000000018853B05C
		public void AddUint(uint x) {} // 0x000000018853B568-0x000000018853B5A0
		public void AddLong(long x) {} // 0x000000018853B120-0x000000018853B158
		public void AddUlong(ulong x) {} // 0x000000018853B6E4-0x000000018853B71C
		public void AddFloat(float x) {} // 0x000000018853AF64-0x000000018853AFA0
		public void Add<T>(T[] x)
			where T : struct {}
		public void Add<T>(ArraySegment<T> x)
			where T : struct {}
		public void Add<T>(IntPtr ptr, int sizeInBytes)
			where T : struct {}
		public void Add<T>(Span<T> x)
			where T : struct {}
		public void AddDouble(double x) {} // 0x000000018853AEE0-0x000000018853AF1C
		public void AddOffset(int off) {} // 0x000000018853B218-0x000000018853B2AC
		public void StartVector(int elemSize, int count, int alignment) {} // 0x000000018853CBE0-0x000000018853CC48
		public VectorOffset EndVector() => default; // 0x000000018853BF08-0x000000018853BF2C
		public VectorOffset CreateVectorOfTables<T>(Offset<T>[] offsets)
			where T : struct => default;
		public void Nested(int obj) {} // 0x000000018853C2BC-0x000000018853C32C
		public void NotNested() {} // 0x000000018853C32C-0x000000018853C394
		public void StartTable(int numfields) {} // 0x000000018853CB0C-0x000000018853CBE0
		public void Slot(int voffset) {} // 0x000000018853CA7C-0x000000018853CB0C
		public void AddBool(int o, bool x, bool d) {} // 0x000000018853ACD8-0x000000018853AD1C
		public void AddBool(int o, bool? x) {} // 0x000000018853AC18-0x000000018853ACA0
		public void AddSbyte(int o, sbyte x, sbyte d) {} // 0x000000018853B3A8-0x000000018853B3EC
		public void AddSbyte(int o, sbyte? x) {} // 0x000000018853B320-0x000000018853B3A8
		public void AddByte(int o, byte x, byte d) {} // 0x000000018853ADDC-0x000000018853AE20
		public void AddByte(int o, byte? x) {} // 0x000000018853AD54-0x000000018853ADDC
		public void AddShort(int o, short x, int d) {} // 0x000000018853B3EC-0x000000018853B430
		public void AddShort(int o, short? x) {} // 0x000000018853B430-0x000000018853B4B4
		public void AddUshort(int o, ushort x, ushort d) {} // 0x000000018853B7A0-0x000000018853B7E4
		public void AddUshort(int o, ushort? x) {} // 0x000000018853B71C-0x000000018853B7A0
		public void AddInt(int o, int x, int d) {} // 0x000000018853B05C-0x000000018853B09C
		public void AddInt(int o, int? x) {} // 0x000000018853B09C-0x000000018853B120
		public void AddUint(int o, uint x, uint d) {} // 0x000000018853B528-0x000000018853B568
		public void AddUint(int o, uint? x) {} // 0x000000018853B5A0-0x000000018853B624
		public void AddLong(int o, long x, long d) {} // 0x000000018853B1D8-0x000000018853B218
		public void AddLong(int o, long? x) {} // 0x000000018853B158-0x000000018853B1D8
		public void AddUlong(int o, ulong x, ulong d) {} // 0x000000018853B6A4-0x000000018853B6E4
		public void AddUlong(int o, ulong? x) {} // 0x000000018853B624-0x000000018853B6A4
		public void AddFloat(int o, float x, double d) {} // 0x000000018853AF1C-0x000000018853AF64
		public void AddFloat(int o, float? x) {} // 0x000000018853AFA0-0x000000018853B024
		public void AddDouble(int o, double x, double d) {} // 0x000000018853AEA0-0x000000018853AEE0
		public void AddDouble(int o, double? x) {} // 0x000000018853AE20-0x000000018853AEA0
		public void AddOffset(int o, int x, int d) {} // 0x000000018853B2AC-0x000000018853B2E8
		public StringOffset CreateString(string s) => default; // 0x000000018853B9F0-0x000000018853BAD0
		public StringOffset CreateUTF8String(Span<byte> chars) => default; // 0x000000018853BAD0-0x000000018853BB98
		public StringOffset CreateSharedString(string s) => default; // 0x000000018853B8CC-0x000000018853B9F0
		public void AddStruct(int voffset, int x, int d) {} // 0x000000018853B4EC-0x000000018853B528
		public int EndTable() => default; // 0x000000018853BBD4-0x000000018853BF08
		public void Required(int table, int field) {} // 0x000000018853C924-0x000000018853CA30
		protected void Finish(int rootTable, bool sizePrefix) {} // 0x000000018853BF54-0x000000018853BFF0
		public void Finish(int rootTable) {} // 0x000000018853C104-0x000000018853C110
		public void FinishSizePrefixed(int rootTable) {} // 0x000000018853BF48-0x000000018853BF54
		public byte[] SizedByteArray() => default; // 0x000000018853CA30-0x000000018853CA7C
		protected void Finish(int rootTable, string fileIdentifier, bool sizePrefix) {} // 0x000000018853BFF0-0x000000018853C104
		public void Finish(int rootTable, string fileIdentifier) {} // 0x000000018853C110-0x000000018853C12C
		public void FinishSizePrefixed(int rootTable, string fileIdentifier) {} // 0x000000018853BF2C-0x000000018853BF48
	}

	public static class FlatBufferConstants // TypeDefIndex: 59472
	{
		// Fields
		public const int FileIdentifierLength = 4; // Metadata: 0x01FDD124
		public const int SizePrefixLength = 4; // Metadata: 0x01FDD125
	
		// Methods
		public static void FLATBUFFERS_23_1_21() {} // 0x000000018350B670-0x000000018350B680
	}

	public static class FlatBufferUtils // TypeDefIndex: 59475
	{
		// Nested types
		public struct UnionForShort // TypeDefIndex: 59473
		{
			// Fields
			public short shortVal; // 0x00
			public ushort ushortVal; // 0x00
		}
	
		public struct UnionForLong // TypeDefIndex: 59474
		{
			// Fields
			public long longVal; // 0x00
			public float floatValLow; // 0x00
			public float floatValHigh; // 0x04
		}
	
		// Extension methods
		public static short ReinterpretAsShort(this ushort val) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		public static ushort ReinterpretAsUShort(this short val) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		public static void ReinterpretAsFloat(this long val, out float floatValLow, out float floatValHigh) {
			floatValLow = default;
			floatValHigh = default;
		} // 0x0000000183D6BAE0-0x0000000183D6BB00
		public static Span<T> AsSpan<T>(this NativeArray<T> nativeArray)
			where T : struct => default;
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> nativeArray)
			where T : struct => default;
	}

	public interface IFlatbufferObject // TypeDefIndex: 59476
	{
		// Properties
		ByteBuffer ByteBuffer { get; }
	
		// Methods
		void __init(int _i, ByteBuffer _bb);
	}

	public struct Offset<T> // TypeDefIndex: 59477
		where T : struct
	{
		// Fields
		public int Value;
	
		// Constructors
		public Offset(int value) {
			Value = default;
		}
	}

	public struct StringOffset // TypeDefIndex: 59478
	{
		// Fields
		public int Value; // 0x00
	
		// Constructors
		public StringOffset(int value) {
			Value = default;
		} // 0x0000000183D4E970-0x0000000183D4E980
	}

	public struct VectorOffset // TypeDefIndex: 59479
	{
		// Fields
		public int Value; // 0x00
	
		// Constructors
		public VectorOffset(int value) {
			Value = default;
		} // 0x0000000183D4E970-0x0000000183D4E980
	}

	public struct Struct // TypeDefIndex: 59480
	{
		// Properties
		public int bb_pos { [IsReadOnly] get; private set; } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public ByteBuffer bb { [IsReadOnly] get; private set; } // 0x0000000183D5C760-0x0000000183D5C780 0x0000000183D6BB20-0x0000000183D6BB40
	
		// Constructors
		public Struct(int _i, ByteBuffer _bb) : this() {} // 0x0000000183D6BB00-0x0000000183D6BB20
	}

	public struct Table // TypeDefIndex: 59481
	{
		// Properties
		public int bb_pos { [IsReadOnly] get; private set; } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public ByteBuffer bb { [IsReadOnly] get; private set; } // 0x0000000183D5C760-0x0000000183D5C780 0x0000000183D6BB20-0x0000000183D6BB40
		public ByteBuffer ByteBuffer { get => default; } // 0x0000000183D5C760-0x0000000183D5C780 
	
		// Constructors
		public Table(int _i, ByteBuffer _bb) : this() {} // 0x0000000183D6BB00-0x0000000183D6BB20
	
		// Methods
		public int __offset(int vtableOffset) => default; // 0x000000018853D2A0-0x000000018853D37C
		public static int __offset(int vtableOffset, int offset, ByteBuffer bb) => default; // 0x000000018853D228-0x000000018853D2A0
		public int __indirect(int offset) => default; // 0x000000018853D1C4-0x000000018853D228
		public static int __indirect(int offset, ByteBuffer bb) => default; // 0x000000018853D16C-0x000000018853D1C4
		public string __string(int offset) => default; // 0x00000001826F65A0-0x00000001826F6840
		public int __vector_len(int offset) => default; // 0x000000018853D37C-0x000000018853D404
		public int __vector(int offset) => default; // 0x000000018853D404-0x000000018853DB28
		public Span<T> __vector_as_span<T>(int offset, int elementSize)
			where T : struct => default;
		public T[] __vector_as_array<T>(int offset)
			where T : struct => default;
		public T __union<T>(int offset)
			where T : struct, IFlatbufferObject => default;
		public static bool __has_identifier(ByteBuffer bb, string ident) => default; // 0x000000018853D044-0x000000018853D16C
		public static int CompareStrings(int offset_1, int offset_2, ByteBuffer bb) => default; // 0x000000018853CF2C-0x000000018853D044
		public static int CompareStrings(int offset_1, byte[] key, ByteBuffer bb) => default; // 0x000000018853CE24-0x000000018853CF2C
	}
}
