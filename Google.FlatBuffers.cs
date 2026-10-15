/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Unity.Collections;

// Image 104: Google.FlatBuffers.dll - Assembly: Google.FlatBuffers, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90701-90717

namespace Google.FlatBuffers
{
	public struct ByteData // TypeDefIndex: 90704
	{
		// Fields
		private unsafe byte* _buffer; // 0x00
		private int _length; // 0x08
	
		// Properties
		public unsafe byte* Buffer { get; } // 0x0000000184431970-0x0000000184431980 
		public int Length { get; } // 0x0000000184431A70-0x0000000184431A80 
		public Span<byte> Span { get; } // 0x00000001858068B0-0x0000000185806960 
		public ReadOnlySpan<byte> ReadOnlySpan { get; } // 0x00000001878347A4-0x00000001878347D8 
	
		// Constructors
		public unsafe ByteData(NativeArray<byte> buffer); // 0x000000018521B1C0-0x000000018521B380
	
		// Methods
		public bool IsCreated(); // 0x00000001853AE700-0x00000001853AE710
		public static unsafe Span<T> ToSpan<T>(T* ptr, int length)
			where T : struct;
		public static unsafe ReadOnlySpan<T> ToReadOnlySpan<T>(T* ptr, int length)
			where T : struct;
	}

	public struct ByteBuffer // TypeDefIndex: 90705
	{
		// Fields
		private ByteData _buffer; // 0x00
		private int _pos; // 0x10
		private static Dictionary<System.Type, int> genericSizes; // 0x00
	
		// Properties
		public int Position { get; set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public int Length { get; } // 0x0000000184431A70-0x0000000184431A80 
	
		// Constructors
		public ByteBuffer(ByteData allocator, int position); // 0x000000018724A310-0x000000018724A320
		public ByteBuffer(NativeArray<byte> buffer); // 0x000000018521B0D0-0x000000018521B140
		public ByteBuffer(NativeArray<byte> buffer, int pos); // 0x000000018521B140-0x000000018521B1C0
		static ByteBuffer(); // 0x0000000186B3F0A0-0x0000000186B3F3A0
	
		// Methods
		public bool IsCreated(); // 0x00000001853AE700-0x00000001853AE710
		public void Reset(); // 0x000000018723C880-0x000000018723C890
		public ByteBuffer Duplicate(); // 0x000000018BF885D4-0x000000018BF88638
		public byte[] ToArray(int pos, int len); // 0x000000018BF893F8-0x000000018BF89468
		public static int SizeOf<T>();
		public static bool IsSupportedType<T>();
		public static int ArraySize<T>(T[] x);
		public static int ArraySize<T>(ArraySegment<T> x);
		public static int ArraySize<T>(Span<T> x);
		public ReadOnlySpan<T> ToSpanSlice<T>(int pos, int count)
			where T : struct;
		public T[] ToArray<T>(int pos, int count)
			where T : struct;
		public NativeArray<T> ToNativeArray<T>(int pos, int count)
			where T : struct;
		public byte[] ToSizedArray(); // 0x000000018BF894C0-0x000000018BF8951C
		public byte[] ToFullArray(); // 0x000000018BF89468-0x000000018BF894C0
		public Span<byte> ToSpan(int pos, int len); // 0x000000018BF8951C-0x000000018BF895B4
		public unsafe byte* GetUnsafePtr(); // 0x0000000184431970-0x0000000184431980
		private void WriteLittleEndian(int offset, int count, ulong data); // 0x000000018BF895B4-0x000000018BF8964C
		private ulong ReadLittleEndian(int offset, int count); // 0x000000018BF89338-0x000000018BF893F8
		private void AssertOffsetAndLength(int offset, int length); // 0x0000000186805BA0-0x0000000186805BB0
		public void PutSbyte(int offset, sbyte value); // 0x000000018BF88EC8-0x000000018BF88F40
		public void PutByte(int offset, byte value); // 0x000000018BF88B98-0x000000018BF88C10
		public void PutByte(int offset, byte value, int count); // 0x000000018BF88C10-0x000000018BF88CF0
		public void Put(int offset, byte value); // 0x000000018BF892D8-0x000000018BF89338
		public void PutStringUTF8(int offset, string value); // 0x000000018BF88FA0-0x000000018BF8908C
		public void PutShort(int offset, short value); // 0x000000018BF88F40-0x000000018BF88FA0
		public void PutUshort(int offset, ushort value); // 0x000000018BF891D8-0x000000018BF892D8
		public void PutInt(int offset, int value); // 0x000000018BF88E08-0x000000018BF88E68
		public void PutUint(int offset, uint value); // 0x000000018BF8908C-0x000000018BF89130
		public void PutLong(int offset, long value); // 0x000000018BF88E68-0x000000018BF88EC8
		public void PutUlong(int offset, ulong value); // 0x000000018BF89130-0x000000018BF891D8
		public void PutFloat(int offset, float value); // 0x000000018BF88D7C-0x000000018BF88E08
		public void PutDouble(int offset, double value); // 0x000000018BF88CF0-0x000000018BF88D7C
		public sbyte GetSbyte(int index); // 0x000000018BF887E0-0x000000018BF8884C
		public byte Get(int index); // 0x000000018BF88B2C-0x000000018BF88B98
		public string GetStringUTF8(int startPos, int len); // 0x000000018BF888A0-0x000000018BF88964
		public short GetShort(int offset); // 0x000000018BF8884C-0x000000018BF888A0
		public ushort GetUshort(int offset); // 0x000000018BF88A94-0x000000018BF88B2C
		public int GetInt(int offset); // 0x000000018BF88738-0x000000018BF8878C
		public uint GetUint(int offset); // 0x000000018BF88964-0x000000018BF889FC
		public long GetLong(int offset); // 0x000000018BF8878C-0x000000018BF887E0
		public ulong GetUlong(int offset); // 0x000000018BF889FC-0x000000018BF88A94
		public float GetFloat(int offset); // 0x000000018BF886B8-0x000000018BF88738
		public double GetDouble(int offset); // 0x000000018BF88638-0x000000018BF886B8
		public int Put<T>(int offset, T[] x)
			where T : struct;
		public int Put<T>(int offset, ArraySegment<T> x)
			where T : struct;
		public int Put<T>(int offset, IntPtr ptr, int sizeInBytes)
			where T : struct;
		public int Put<T>(int offset, Span<T> x)
			where T : struct;
	}

	public class ByteBufferUtil // TypeDefIndex: 90706
	{
		// Constructors
		public ByteBufferUtil(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static int GetSizePrefix(ByteBuffer bb); // 0x000000018BF88510-0x000000018BF8855C
		public static ByteBuffer RemoveSizePrefix(ByteBuffer bb); // 0x000000018BF8855C-0x000000018BF885D4
	}

	public class FlatBufferBuilder : IDisposable // TypeDefIndex: 90707
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
		[CompilerGenerated]
		private bool _ForceDefaults_k__BackingField; // 0x70
	
		// Properties
		public bool ForceDefaults { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271A20-0x0000000182271A30 0x0000000182271A30-0x0000000182271A40
		public int Offset { get; } // 0x000000018BF8B874-0x000000018BF8B8BC 
		public ByteBuffer DataBuffer { get; } // 0x000000018724AF20-0x000000018724AF40 
	
		// Constructors
		public FlatBufferBuilder(int initialSize); // 0x000000018BF8B6D8-0x000000018BF8B874
	
		// Methods
		public void Dispose(); // 0x000000018BF8A5E8-0x000000018BF8A624
		public void Clear(); // 0x000000018BF8A25C-0x000000018BF8A318
		public void Pad(int size); // 0x000000018BF8AE20-0x000000018BF8AE90
		private void GrowBuffer(); // 0x000000018BF8ABB8-0x000000018BF8AD48
		public void Prep(int size, int additionalBytes); // 0x000000018BF8AE90-0x000000018BF8AF3C
		public void PutBool(bool x); // 0x000000018BF8AF3C-0x000000018BF8AFA4
		public void PutSbyte(sbyte x); // 0x000000018BF8B1AC-0x000000018BF8B214
		public void PutByte(byte x); // 0x000000018BF8AFA4-0x000000018BF8B00C
		public void PutShort(short x); // 0x000000018BF8B214-0x000000018BF8B27C
		public void PutUshort(ushort x); // 0x000000018BF8B34C-0x000000018BF8B3B4
		public void PutInt(int x); // 0x000000018BF8B0DC-0x000000018BF8B144
		public void PutUint(uint x); // 0x000000018BF8B27C-0x000000018BF8B2E4
		public void PutLong(long x); // 0x000000018BF8B144-0x000000018BF8B1AC
		public void PutUlong(ulong x); // 0x000000018BF8B2E4-0x000000018BF8B34C
		public void PutFloat(float x); // 0x000000018BF8B074-0x000000018BF8B0DC
		public void Put<T>(T[] x)
			where T : struct;
		public void Put<T>(ArraySegment<T> x)
			where T : struct;
		public void Put<T>(IntPtr ptr, int sizeInBytes)
			where T : struct;
		public void Put<T>(Span<T> x)
			where T : struct;
		public void PutDouble(double x); // 0x000000018BF8B00C-0x000000018BF8B074
		public void AddBool(bool x); // 0x000000018BF896D4-0x000000018BF8970C
		public void AddSbyte(sbyte x); // 0x000000018BF89D28-0x000000018BF89D60
		public void AddByte(byte x); // 0x000000018BF89750-0x000000018BF89788
		public void AddShort(short x); // 0x000000018BF89EF4-0x000000018BF89F2C
		public void AddUshort(ushort x); // 0x000000018BF8A224-0x000000018BF8A25C
		public void AddInt(int x); // 0x000000018BF89A58-0x000000018BF89A90
		public void AddUint(uint x); // 0x000000018BF89FA8-0x000000018BF89FE0
		public void AddLong(long x); // 0x000000018BF89B54-0x000000018BF89B8C
		public void AddUlong(ulong x); // 0x000000018BF8A124-0x000000018BF8A15C
		public void AddFloat(float x); // 0x000000018BF89998-0x000000018BF899D4
		public void Add<T>(T[] x)
			where T : struct;
		public void Add<T>(ArraySegment<T> x)
			where T : struct;
		public void Add<T>(IntPtr ptr, int sizeInBytes)
			where T : struct;
		public void Add<T>(Span<T> x)
			where T : struct;
		public void AddDouble(double x); // 0x000000018BF89914-0x000000018BF89950
		public void AddOffset(int off); // 0x000000018BF89C4C-0x000000018BF89CEC
		public void StartVector(int elemSize, int count, int alignment); // 0x000000018BF8B670-0x000000018BF8B6D8
		public VectorOffset EndVector(); // 0x000000018BF8A980-0x000000018BF8A9A4
		public VectorOffset CreateVectorOfTables<T>(Offset<T>[] offsets)
			where T : struct;
		public void Nested(int obj); // 0x000000018BF8AD48-0x000000018BF8ADB8
		public void NotNested(); // 0x000000018BF8ADB8-0x000000018BF8AE20
		public void StartTable(int numfields); // 0x000000018BF8B59C-0x000000018BF8B670
		public void Slot(int voffset); // 0x000000018BF8B50C-0x000000018BF8B59C
		public void AddBool(int o, bool x, bool d); // 0x000000018BF8970C-0x000000018BF89750
		public void AddBool(int o, bool? x); // 0x000000018BF8964C-0x000000018BF896D4
		public void AddSbyte(int o, sbyte x, sbyte d); // 0x000000018BF89DE8-0x000000018BF89E2C
		public void AddSbyte(int o, sbyte? x); // 0x000000018BF89D60-0x000000018BF89DE8
		public void AddByte(int o, byte x, byte d); // 0x000000018BF89810-0x000000018BF89854
		public void AddByte(int o, byte? x); // 0x000000018BF89788-0x000000018BF89810
		public void AddShort(int o, short x, int d); // 0x000000018BF89E2C-0x000000018BF89E70
		public void AddShort(int o, short? x); // 0x000000018BF89E70-0x000000018BF89EF4
		public void AddUshort(int o, ushort x, ushort d); // 0x000000018BF8A1E0-0x000000018BF8A224
		public void AddUshort(int o, ushort? x); // 0x000000018BF8A15C-0x000000018BF8A1E0
		public void AddInt(int o, int x, int d); // 0x000000018BF89A90-0x000000018BF89AD0
		public void AddInt(int o, int? x); // 0x000000018BF89AD0-0x000000018BF89B54
		public void AddUint(int o, uint x, uint d); // 0x000000018BF89F68-0x000000018BF89FA8
		public void AddUint(int o, uint? x); // 0x000000018BF89FE0-0x000000018BF8A064
		public void AddLong(int o, long x, long d); // 0x000000018BF89C0C-0x000000018BF89C4C
		public void AddLong(int o, long? x); // 0x000000018BF89B8C-0x000000018BF89C0C
		public void AddUlong(int o, ulong x, ulong d); // 0x000000018BF8A0E4-0x000000018BF8A124
		public void AddUlong(int o, ulong? x); // 0x000000018BF8A064-0x000000018BF8A0E4
		public void AddFloat(int o, float x, double d); // 0x000000018BF89950-0x000000018BF89998
		public void AddFloat(int o, float? x); // 0x000000018BF899D4-0x000000018BF89A58
		public void AddDouble(int o, double x, double d); // 0x000000018BF898D4-0x000000018BF89914
		public void AddDouble(int o, double? x); // 0x000000018BF89854-0x000000018BF898D4
		public void AddOffset(int o, int x, int d); // 0x000000018BF89CEC-0x000000018BF89D28
		public StringOffset CreateString(string s); // 0x000000018BF8A43C-0x000000018BF8A51C
		public StringOffset CreateUTF8String(Span<byte> chars); // 0x000000018BF8A51C-0x000000018BF8A5E8
		public StringOffset CreateSharedString(string s); // 0x000000018BF8A318-0x000000018BF8A43C
		public void AddStruct(int voffset, int x, int d); // 0x000000018BF89F2C-0x000000018BF89F68
		public int EndTable(); // 0x000000018BF8A624-0x000000018BF8A980
		public void Required(int table, int field); // 0x000000018BF8B3B4-0x000000018BF8B4C0
		protected void Finish(int rootTable, bool sizePrefix); // 0x000000018BF8A9CC-0x000000018BF8AA74
		public void Finish(int rootTable); // 0x000000018BF8AB90-0x000000018BF8AB9C
		public void FinishSizePrefixed(int rootTable); // 0x000000018BF8A9C0-0x000000018BF8A9CC
		public byte[] SizedByteArray(); // 0x000000018BF8B4C0-0x000000018BF8B50C
		protected void Finish(int rootTable, string fileIdentifier, bool sizePrefix); // 0x000000018BF8AA74-0x000000018BF8AB90
		public void Finish(int rootTable, string fileIdentifier); // 0x000000018BF8AB9C-0x000000018BF8ABB8
		public void FinishSizePrefixed(int rootTable, string fileIdentifier); // 0x000000018BF8A9A4-0x000000018BF8A9C0
	}

	public static class FlatBufferConstants // TypeDefIndex: 90708
	{
		// Fields
		public const int FileIdentifierLength = 4; // Metadata: 0x0264B107
		public const int SizePrefixLength = 4; // Metadata: 0x0264B108
	
		// Methods
		public static void FLATBUFFERS_23_1_21(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public static class FlatBufferUtils // TypeDefIndex: 90711
	{
		// Nested types
		public struct UnionForShort // TypeDefIndex: 90709
		{
			// Fields
			public short shortVal; // 0x00
			public ushort ushortVal; // 0x00
		}
	
		public struct UnionForLong // TypeDefIndex: 90710
		{
			// Fields
			public long longVal; // 0x00
			public float floatValLow; // 0x00
			public float floatValHigh; // 0x04
		}
	
		// Extension methods
		public static short ReinterpretAsShort(this ushort val); // 0x0000000187234210-0x0000000187234220
		public static ushort ReinterpretAsUShort(this short val); // 0x0000000187234210-0x0000000187234220
		public static void ReinterpretAsFloat(this long val, out float floatValLow, out float floatValHigh); // 0x000000018724EF00-0x000000018724EF20
		public static Span<T> AsSpan<T>(this NativeArray<T> nativeArray)
			where T : struct;
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> nativeArray)
			where T : struct;
	}

	public interface IFlatbufferObject // TypeDefIndex: 90712
	{
		// Properties
		ByteBuffer ByteBuffer { get; }
	
		// Methods
		void __init(int _i, ByteBuffer _bb);
	}

	public struct Offset<T> // TypeDefIndex: 90713
		where T : struct
	{
		// Fields
		public int Value;
	
		// Constructors
		public Offset(int value);
	}

	public struct StringOffset // TypeDefIndex: 90714
	{
		// Fields
		public int Value; // 0x00
	
		// Constructors
		public StringOffset(int value); // 0x0000000184547F40-0x0000000184547F50
	}

	public struct VectorOffset // TypeDefIndex: 90715
	{
		// Fields
		public int Value; // 0x00
	
		// Constructors
		public VectorOffset(int value); // 0x0000000184547F40-0x0000000184547F50
	}

	public struct Struct // TypeDefIndex: 90716
	{
		// Fields
		[CompilerGenerated]
		private int _bb_pos_k__BackingField; // 0x00
		[CompilerGenerated]
		private ByteBuffer _bb_k__BackingField; // 0x08
	
		// Properties
		public int bb_pos { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public ByteBuffer bb { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AD2E0-0x00000001844AD300 0x000000018724EF40-0x000000018724EF60
	
		// Constructors
		public Struct(int _i, ByteBuffer _bb); // 0x000000018724EF20-0x000000018724EF40
	}

	public struct Table // TypeDefIndex: 90717
	{
		// Fields
		[CompilerGenerated]
		private int _bb_pos_k__BackingField; // 0x00
		[CompilerGenerated]
		private ByteBuffer _bb_k__BackingField; // 0x08
	
		// Properties
		public int bb_pos { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public ByteBuffer bb { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x00000001844AD2E0-0x00000001844AD300 0x000000018724EF40-0x000000018724EF60
		public ByteBuffer ByteBuffer { get; } // 0x00000001844AD2E0-0x00000001844AD300 
	
		// Constructors
		public Table(int _i, ByteBuffer _bb); // 0x000000018724EF20-0x000000018724EF40
	
		// Methods
		public int __offset(int vtableOffset); // 0x000000018BF8BD38-0x000000018BF8BE14
		public static int __offset(int vtableOffset, int offset, ByteBuffer bb); // 0x000000018BF8BCC0-0x000000018BF8BD38
		public int __indirect(int offset); // 0x000000018BF8BC5C-0x000000018BF8BCC0
		public static int __indirect(int offset, ByteBuffer bb); // 0x000000018BF8BC04-0x000000018BF8BC5C
		public string __string(int offset); // 0x0000000185803530-0x0000000185803740
		public int __vector_len(int offset); // 0x000000018BF8BE14-0x000000018BF8BE9C
		public int __vector(int offset); // 0x000000018BF8BE9C-0x000000018BF8BF08
		public Span<T> __vector_as_span<T>(int offset, int elementSize)
			where T : struct;
		public T[] __vector_as_array<T>(int offset)
			where T : struct;
		public T __union<T>(int offset)
			where T : struct, IFlatbufferObject;
		public static bool __has_identifier(ByteBuffer bb, string ident); // 0x000000018BF8BADC-0x000000018BF8BC04
		public static int CompareStrings(int offset_1, int offset_2, ByteBuffer bb); // 0x000000018BF8B9C8-0x000000018BF8BADC
		public static int CompareStrings(int offset_1, byte[] key, ByteBuffer bb); // 0x000000018BF8B8BC-0x000000018BF8B9C8
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 90702
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 90703
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
