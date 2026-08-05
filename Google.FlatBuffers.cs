/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Unity.Collections;

// Image 103: Google.FlatBuffers.dll - Assembly: Google.FlatBuffers, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63249-63265
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Google.FlatBuffers
{
	public struct ByteData // TypeDefIndex: 63252
	{
		// Fields
		private unsafe byte* _buffer; // 0x00
		private int _length; // 0x08
	
		// Properties
		public unsafe byte* Buffer { get; } // 0x0000000182B76770-0x0000000182B76780 
		public int Length { get; } // 0x0000000184D88B10-0x0000000184D88B20 
		public Span<byte> Span { get; } // 0x0000000189AC920C-0x0000000189AC9268 
		public ReadOnlySpan<byte> ReadOnlySpan { get; } // 0x0000000185390CF0-0x0000000185390D24 
	
		// Constructors
		public unsafe ByteData(NativeArray<byte> buffer); // 0x0000000183585F10-0x0000000183585F60
	
		// Methods
		public bool IsCreated(); // 0x00000001830CFC40-0x00000001830CFC50
		public static unsafe Span<T> ToSpan<T>(T* ptr, int length)
			where T : struct;
		public static unsafe ReadOnlySpan<T> ToReadOnlySpan<T>(T* ptr, int length)
			where T : struct;
	}

	public struct ByteBuffer // TypeDefIndex: 63253
	{
		// Fields
		private ByteData _buffer; // 0x00
		private int _pos; // 0x10
		private static Dictionary<System.Type, int> genericSizes; // 0x00
	
		// Properties
		public int Position { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		public int Length { get; } // 0x0000000184D88B10-0x0000000184D88B20 
	
		// Constructors
		public ByteBuffer(ByteData allocator, int position); // 0x0000000182B775A0-0x0000000182B775B0
		public ByteBuffer(NativeArray<byte> buffer); // 0x0000000183585E20-0x0000000183585E90
		public ByteBuffer(NativeArray<byte> buffer, int pos); // 0x0000000183585E90-0x0000000183585F10
		static ByteBuffer(); // 0x000000018404E940-0x000000018404EC40
	
		// Methods
		public bool IsCreated(); // 0x00000001830CFC40-0x00000001830CFC50
		public void Reset(); // 0x0000000184D91EC0-0x0000000184D91ED0
		public ByteBuffer Duplicate(); // 0x0000000189AC8190-0x0000000189AC81F4
		public byte[] ToArray(int pos, int len); // 0x0000000189AC8FB4-0x0000000189AC9024
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
		public byte[] ToSizedArray(); // 0x0000000189AC907C-0x0000000189AC90D8
		public byte[] ToFullArray(); // 0x0000000189AC9024-0x0000000189AC907C
		public Span<byte> ToSpan(int pos, int len); // 0x0000000189AC90D8-0x0000000189AC9170
		public unsafe byte* GetUnsafePtr(); // 0x0000000182B76770-0x0000000182B76780
		private void WriteLittleEndian(int offset, int count, ulong data); // 0x0000000189AC9170-0x0000000189AC920C
		private ulong ReadLittleEndian(int offset, int count); // 0x0000000189AC8EF4-0x0000000189AC8FB4
		private void AssertOffsetAndLength(int offset, int length); // 0x00000001841E1670-0x00000001841E1680
		public void PutSbyte(int offset, sbyte value); // 0x0000000189AC8A84-0x0000000189AC8AFC
		public void PutByte(int offset, byte value); // 0x0000000189AC8754-0x0000000189AC87CC
		public void PutByte(int offset, byte value, int count); // 0x0000000189AC87CC-0x0000000189AC88AC
		public void Put(int offset, byte value); // 0x0000000189AC8E94-0x0000000189AC8EF4
		public void PutStringUTF8(int offset, string value); // 0x0000000189AC8B5C-0x0000000189AC8C48
		public void PutShort(int offset, short value); // 0x0000000189AC8AFC-0x0000000189AC8B5C
		public void PutUshort(int offset, ushort value); // 0x0000000189AC8D94-0x0000000189AC8E94
		public void PutInt(int offset, int value); // 0x0000000189AC89C4-0x0000000189AC8A24
		public void PutUint(int offset, uint value); // 0x0000000189AC8C48-0x0000000189AC8CEC
		public void PutLong(int offset, long value); // 0x0000000189AC8A24-0x0000000189AC8A84
		public void PutUlong(int offset, ulong value); // 0x0000000189AC8CEC-0x0000000189AC8D94
		public void PutFloat(int offset, float value); // 0x0000000189AC8938-0x0000000189AC89C4
		public void PutDouble(int offset, double value); // 0x0000000189AC88AC-0x0000000189AC8938
		public sbyte GetSbyte(int index); // 0x0000000189AC839C-0x0000000189AC8408
		public byte Get(int index); // 0x0000000189AC86E8-0x0000000189AC8754
		public string GetStringUTF8(int startPos, int len); // 0x0000000189AC845C-0x0000000189AC8520
		public short GetShort(int offset); // 0x0000000189AC8408-0x0000000189AC845C
		public ushort GetUshort(int offset); // 0x0000000189AC8650-0x0000000189AC86E8
		public int GetInt(int offset); // 0x0000000189AC82F4-0x0000000189AC8348
		public uint GetUint(int offset); // 0x0000000189AC8520-0x0000000189AC85B8
		public long GetLong(int offset); // 0x0000000189AC8348-0x0000000189AC839C
		public ulong GetUlong(int offset); // 0x0000000189AC85B8-0x0000000189AC8650
		public float GetFloat(int offset); // 0x0000000189AC8274-0x0000000189AC82F4
		public double GetDouble(int offset); // 0x0000000189AC81F4-0x0000000189AC8274
		public int Put<T>(int offset, T[] x)
			where T : struct;
		public int Put<T>(int offset, ArraySegment<T> x)
			where T : struct;
		public int Put<T>(int offset, IntPtr ptr, int sizeInBytes)
			where T : struct;
		public int Put<T>(int offset, Span<T> x)
			where T : struct;
	}

	public class ByteBufferUtil // TypeDefIndex: 63254
	{
		// Constructors
		public ByteBufferUtil(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static int GetSizePrefix(ByteBuffer bb); // 0x0000000189AC80CC-0x0000000189AC8118
		public static ByteBuffer RemoveSizePrefix(ByteBuffer bb); // 0x0000000189AC8118-0x0000000189AC8190
	}

	public class FlatBufferBuilder : IDisposable // TypeDefIndex: 63255
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
		public bool ForceDefaults { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86A50-0x0000000184D86A60 0x0000000184D86A80-0x0000000184D86A90
		public int Offset { get; } // 0x0000000189ACB42C-0x0000000189ACB474 
		public ByteBuffer DataBuffer { get; } // 0x0000000184D9CD10-0x0000000184D9CD30 
	
		// Constructors
		public FlatBufferBuilder(int initialSize); // 0x0000000189ACB298-0x0000000189ACB42C
	
		// Methods
		public void Dispose(); // 0x0000000189ACA1E8-0x0000000189ACA224
		public void Clear(); // 0x0000000189AC9E6C-0x0000000189AC9F1C
		public void Pad(int size); // 0x0000000189ACA9E4-0x0000000189ACAA50
		private void GrowBuffer(); // 0x0000000189ACA77C-0x0000000189ACA90C
		public void Prep(int size, int additionalBytes); // 0x0000000189ACAA50-0x0000000189ACAAFC
		public void PutBool(bool x); // 0x0000000189ACAAFC-0x0000000189ACAB64
		public void PutSbyte(sbyte x); // 0x0000000189ACAD6C-0x0000000189ACADD4
		public void PutByte(byte x); // 0x0000000189ACAB64-0x0000000189ACABCC
		public void PutShort(short x); // 0x0000000189ACADD4-0x0000000189ACAE3C
		public void PutUshort(ushort x); // 0x0000000189ACAF0C-0x0000000189ACAF74
		public void PutInt(int x); // 0x0000000189ACAC9C-0x0000000189ACAD04
		public void PutUint(uint x); // 0x0000000189ACAE3C-0x0000000189ACAEA4
		public void PutLong(long x); // 0x0000000189ACAD04-0x0000000189ACAD6C
		public void PutUlong(ulong x); // 0x0000000189ACAEA4-0x0000000189ACAF0C
		public void PutFloat(float x); // 0x0000000189ACAC34-0x0000000189ACAC9C
		public void Put<T>(T[] x)
			where T : struct;
		public void Put<T>(ArraySegment<T> x)
			where T : struct;
		public void Put<T>(IntPtr ptr, int sizeInBytes)
			where T : struct;
		public void Put<T>(Span<T> x)
			where T : struct;
		public void PutDouble(double x); // 0x0000000189ACABCC-0x0000000189ACAC34
		public void AddBool(bool x); // 0x0000000189AC92F0-0x0000000189AC9328
		public void AddSbyte(sbyte x); // 0x0000000189AC9938-0x0000000189AC9970
		public void AddByte(byte x); // 0x0000000189AC936C-0x0000000189AC93A4
		public void AddShort(short x); // 0x0000000189AC9B04-0x0000000189AC9B3C
		public void AddUshort(ushort x); // 0x0000000189AC9E34-0x0000000189AC9E6C
		public void AddInt(int x); // 0x0000000189AC9674-0x0000000189AC96AC
		public void AddUint(uint x); // 0x0000000189AC9BB8-0x0000000189AC9BF0
		public void AddLong(long x); // 0x0000000189AC9770-0x0000000189AC97A8
		public void AddUlong(ulong x); // 0x0000000189AC9D34-0x0000000189AC9D6C
		public void AddFloat(float x); // 0x0000000189AC95B4-0x0000000189AC95F0
		public void Add<T>(T[] x)
			where T : struct;
		public void Add<T>(ArraySegment<T> x)
			where T : struct;
		public void Add<T>(IntPtr ptr, int sizeInBytes)
			where T : struct;
		public void Add<T>(Span<T> x)
			where T : struct;
		public void AddDouble(double x); // 0x0000000189AC9530-0x0000000189AC956C
		public void AddOffset(int off); // 0x0000000189AC9868-0x0000000189AC98FC
		public void StartVector(int elemSize, int count, int alignment); // 0x0000000189ACB230-0x0000000189ACB298
		public VectorOffset EndVector(); // 0x0000000189ACA558-0x0000000189ACA57C
		public VectorOffset CreateVectorOfTables<T>(Offset<T>[] offsets)
			where T : struct;
		public void Nested(int obj); // 0x0000000189ACA90C-0x0000000189ACA97C
		public void NotNested(); // 0x0000000189ACA97C-0x0000000189ACA9E4
		public void StartTable(int numfields); // 0x0000000189ACB15C-0x0000000189ACB230
		public void Slot(int voffset); // 0x0000000189ACB0CC-0x0000000189ACB15C
		public void AddBool(int o, bool x, bool d); // 0x0000000189AC9328-0x0000000189AC936C
		public void AddBool(int o, bool? x); // 0x0000000189AC9268-0x0000000189AC92F0
		public void AddSbyte(int o, sbyte x, sbyte d); // 0x0000000189AC99F8-0x0000000189AC9A3C
		public void AddSbyte(int o, sbyte? x); // 0x0000000189AC9970-0x0000000189AC99F8
		public void AddByte(int o, byte x, byte d); // 0x0000000189AC942C-0x0000000189AC9470
		public void AddByte(int o, byte? x); // 0x0000000189AC93A4-0x0000000189AC942C
		public void AddShort(int o, short x, int d); // 0x0000000189AC9A3C-0x0000000189AC9A80
		public void AddShort(int o, short? x); // 0x0000000189AC9A80-0x0000000189AC9B04
		public void AddUshort(int o, ushort x, ushort d); // 0x0000000189AC9DF0-0x0000000189AC9E34
		public void AddUshort(int o, ushort? x); // 0x0000000189AC9D6C-0x0000000189AC9DF0
		public void AddInt(int o, int x, int d); // 0x0000000189AC96AC-0x0000000189AC96EC
		public void AddInt(int o, int? x); // 0x0000000189AC96EC-0x0000000189AC9770
		public void AddUint(int o, uint x, uint d); // 0x0000000189AC9B78-0x0000000189AC9BB8
		public void AddUint(int o, uint? x); // 0x0000000189AC9BF0-0x0000000189AC9C74
		public void AddLong(int o, long x, long d); // 0x0000000189AC9828-0x0000000189AC9868
		public void AddLong(int o, long? x); // 0x0000000189AC97A8-0x0000000189AC9828
		public void AddUlong(int o, ulong x, ulong d); // 0x0000000189AC9CF4-0x0000000189AC9D34
		public void AddUlong(int o, ulong? x); // 0x0000000189AC9C74-0x0000000189AC9CF4
		public void AddFloat(int o, float x, double d); // 0x0000000189AC956C-0x0000000189AC95B4
		public void AddFloat(int o, float? x); // 0x0000000189AC95F0-0x0000000189AC9674
		public void AddDouble(int o, double x, double d); // 0x0000000189AC94F0-0x0000000189AC9530
		public void AddDouble(int o, double? x); // 0x0000000189AC9470-0x0000000189AC94F0
		public void AddOffset(int o, int x, int d); // 0x0000000189AC98FC-0x0000000189AC9938
		public StringOffset CreateString(string s); // 0x0000000189ACA040-0x0000000189ACA120
		public StringOffset CreateUTF8String(Span<byte> chars); // 0x0000000189ACA120-0x0000000189ACA1E8
		public StringOffset CreateSharedString(string s); // 0x0000000189AC9F1C-0x0000000189ACA040
		public void AddStruct(int voffset, int x, int d); // 0x0000000189AC9B3C-0x0000000189AC9B78
		public int EndTable(); // 0x0000000189ACA224-0x0000000189ACA558
		public void Required(int table, int field); // 0x0000000189ACAF74-0x0000000189ACB080
		protected void Finish(int rootTable, bool sizePrefix); // 0x0000000189ACA5A4-0x0000000189ACA640
		public void Finish(int rootTable); // 0x0000000189ACA754-0x0000000189ACA760
		public void FinishSizePrefixed(int rootTable); // 0x0000000189ACA598-0x0000000189ACA5A4
		public byte[] SizedByteArray(); // 0x0000000189ACB080-0x0000000189ACB0CC
		protected void Finish(int rootTable, string fileIdentifier, bool sizePrefix); // 0x0000000189ACA640-0x0000000189ACA754
		public void Finish(int rootTable, string fileIdentifier); // 0x0000000189ACA760-0x0000000189ACA77C
		public void FinishSizePrefixed(int rootTable, string fileIdentifier); // 0x0000000189ACA57C-0x0000000189ACA598
	}

	public static class FlatBufferConstants // TypeDefIndex: 63256
	{
		// Fields
		public const int FileIdentifierLength = 4; // Metadata: 0x02352752
		public const int SizePrefixLength = 4; // Metadata: 0x02352753
	
		// Methods
		public static void FLATBUFFERS_23_1_21(); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class FlatBufferUtils // TypeDefIndex: 63259
	{
		// Nested types
		public struct UnionForShort // TypeDefIndex: 63257
		{
			// Fields
			public short shortVal; // 0x00
			public ushort ushortVal; // 0x00
		}
	
		public struct UnionForLong // TypeDefIndex: 63258
		{
			// Fields
			public long longVal; // 0x00
			public float floatValLow; // 0x00
			public float floatValHigh; // 0x04
		}
	
		// Extension methods
		public static short ReinterpretAsShort(this ushort val); // 0x0000000184D875C0-0x0000000184D875D0
		public static ushort ReinterpretAsUShort(this short val); // 0x0000000184D875C0-0x0000000184D875D0
		public static void ReinterpretAsFloat(this long val, out float floatValLow, out float floatValHigh); // 0x0000000184DA0C70-0x0000000184DA0C90
		public static Span<T> AsSpan<T>(this NativeArray<T> nativeArray)
			where T : struct;
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> nativeArray)
			where T : struct;
	}

	public interface IFlatbufferObject // TypeDefIndex: 63260
	{
		// Properties
		ByteBuffer ByteBuffer { get; }
	
		// Methods
		void __init(int _i, ByteBuffer _bb);
	}

	public struct Offset<T> // TypeDefIndex: 63261
		where T : struct
	{
		// Fields
		public int Value;
	
		// Constructors
		public Offset(int value);
	}

	public struct StringOffset // TypeDefIndex: 63262
	{
		// Fields
		public int Value; // 0x00
	
		// Constructors
		public StringOffset(int value); // 0x0000000184D86140-0x0000000184D86150
	}

	public struct VectorOffset // TypeDefIndex: 63263
	{
		// Fields
		public int Value; // 0x00
	
		// Constructors
		public VectorOffset(int value); // 0x0000000184D86140-0x0000000184D86150
	}

	public struct Struct // TypeDefIndex: 63264
	{
		// Fields
		[CompilerGenerated]
		private int _bb_pos_k__BackingField; // 0x00
		[CompilerGenerated]
		private ByteBuffer _bb_k__BackingField; // 0x08
	
		// Properties
		public int bb_pos { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public ByteBuffer bb { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182A8F1E0-0x0000000182A8F200 0x0000000184DA0CB0-0x0000000184DA0CD0
	
		// Constructors
		public Struct(int _i, ByteBuffer _bb); // 0x0000000184DA0C90-0x0000000184DA0CB0
	}

	public struct Table // TypeDefIndex: 63265
	{
		// Fields
		[CompilerGenerated]
		private int _bb_pos_k__BackingField; // 0x00
		[CompilerGenerated]
		private ByteBuffer _bb_k__BackingField; // 0x08
	
		// Properties
		public int bb_pos { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public ByteBuffer bb { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000182A8F1E0-0x0000000182A8F200 0x0000000184DA0CB0-0x0000000184DA0CD0
		public ByteBuffer ByteBuffer { get; } // 0x0000000182A8F1E0-0x0000000182A8F200 
	
		// Constructors
		public Table(int _i, ByteBuffer _bb); // 0x0000000184DA0C90-0x0000000184DA0CB0
	
		// Methods
		public int __offset(int vtableOffset); // 0x0000000189ACB8F0-0x0000000189ACB9CC
		public static int __offset(int vtableOffset, int offset, ByteBuffer bb); // 0x0000000189ACB878-0x0000000189ACB8F0
		public int __indirect(int offset); // 0x0000000189ACB814-0x0000000189ACB878
		public static int __indirect(int offset, ByteBuffer bb); // 0x0000000189ACB7BC-0x0000000189ACB814
		public string __string(int offset); // 0x000000018336F6C0-0x000000018336F8E0
		public int __vector_len(int offset); // 0x0000000189ACB9CC-0x0000000189ACBA54
		public int __vector(int offset); // 0x0000000189ACBA54-0x0000000189ACC01C
		public Span<T> __vector_as_span<T>(int offset, int elementSize)
			where T : struct;
		public T[] __vector_as_array<T>(int offset)
			where T : struct;
		public T __union<T>(int offset)
			where T : struct, IFlatbufferObject;
		public static bool __has_identifier(ByteBuffer bb, string ident); // 0x0000000189ACB694-0x0000000189ACB7BC
		public static int CompareStrings(int offset_1, int offset_2, ByteBuffer bb); // 0x0000000189ACB57C-0x0000000189ACB694
		public static int CompareStrings(int offset_1, byte[] key, ByteBuffer bb); // 0x0000000189ACB474-0x0000000189ACB57C
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 63250
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 63251
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}
