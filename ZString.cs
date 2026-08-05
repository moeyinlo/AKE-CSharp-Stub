/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Buffers;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Beyond;
using IFix.Core;
using Microsoft.CodeAnalysis;
using Unity.Mathematics;

// Image 70: ZString.dll - Assembly: ZString, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62201-62232
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 62230
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_256 _1861BF4EAE96D61721D493270BADE6B1F1FFEB0A6BCA271EE90DC9B33E918625; // 0x00 // Static value (base64): AAABAAIAAwAEAAUABgAHAAgACQAKAAsADAANAA4ADwAQABEAEgATABQAFQAWABcAGAAZABoAGwAcAB0AHgAfACAAIQAiACMAJAAlACYAJwAoACkAKgArACwALQAuAC8AMAAxADIAMwA0ADUANgA3ADgAOQA6ADsAPAA9AD4APwBAAEEAQgBDAEQARQBGAEcASABJAEoASwBMAE0ATgBPAFAAUQBSAFMAVABVAFYAVwBYAFkAWgBbAFwAXQBeAF8AYABBAEIAQwBEAEUARgBHAEgASQBKAEsATABNAE4ATwBQAFEAUgBTAFQAVQBWAFcAWABZAFoAewB8AH0AfgB/AA== - Metadata: 0x023507AC
	internal static readonly __StaticArrayInitTypeSize_32 _3BF63951626584EB1653F9B8DBB590A5EE1EAE1135A904B9317C3773896DF076; // 0x100 // Static value (base64): AAEcAh0OGAMeFhQPGREECB8bDRcVExAHGgwSBgsFCgk= - Metadata: 0x023508B4
	internal static readonly __StaticArrayInitTypeSize_32 _4BCD43D478B9229AB7A13406353712C7944B60348C36B4D0E6B789D10F697652; // 0x120 // Static value (base64): AAkBCg0VAh0LDhASFhkDHggMFBwPERgHExsXBhoFBB8= - Metadata: 0x023508DC
	internal static readonly __StaticArrayInitTypeSize_256 E14330899333C68046C96292E14EF1B988B41F2809D50D9C2D5A83F2E83BF2AA; // 0x140 // Static value (base64): AAABAAIAAwAEAAUABgAHAAgACQAKAAsADAANAA4ADwAQABEAEgATABQAFQAWABcAGAAZABoAGwAcAB0AHgAfACAAIQAiACMAJAAlACYAJwAoACkAKgArACwALQAuAC8AMAAxADIAMwA0ADUANgA3ADgAOQA6ADsAPAA9AD4APwBAAGEAYgBjAGQAZQBmAGcAaABpAGoAawBsAG0AbgBvAHAAcQByAHMAdAB1AHYAdwB4AHkAegBbAFwAXQBeAF8AYABhAGIAYwBkAGUAZgBnAGgAaQBqAGsAbABtAG4AbwBwAHEAcgBzAHQAdQB2AHcAeAB5AHoAewB8AH0AfgB/AA== - Metadata: 0x02350904

	// Nested types
	private struct __StaticArrayInitTypeSize_32 // TypeDefIndex: 62228
	{
	}

	private struct __StaticArrayInitTypeSize_256 // TypeDefIndex: 62229
	{
	}
}

namespace Beyond
{
	public struct MonoObject_64 // TypeDefIndex: 62205
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x08
	}

	public struct MonoObject_32 // TypeDefIndex: 62206
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x04
	}

	public struct MonoString_64 // TypeDefIndex: 62207
	{
		// Fields
		public MonoObject_64 obj; // 0x00
		public int length; // 0x10
		public char firstChar; // 0x14
	}

	public struct MonoString_32 // TypeDefIndex: 62208
	{
		// Fields
		public MonoObject_32 obj; // 0x00
		public int length; // 0x08
		public char firstChar; // 0x0C
	}

	[DefaultMember("Item")]
	[Nullable(0)]
	[NullableContext(1)]
	public class UnSafeString // TypeDefIndex: 62213
	{
		// Fields
		private static Stack<HgStringBlock> s_blocks; // 0x00
		private static Stack<HgStringBlock> s_stackBlocks; // 0x08
		[Nullable(2)]
		private static HgStringBlock s_currentBlock; // 0x10
		private static ThreadLocal<Stack<HgThreadStringBlock>> s_threadBlockPool; // 0x18
		private static ThreadLocal<Stack<HgThreadStringBlock>> s_threadStackBlocks; // 0x20
		private static ThreadLocal<HgThreadStringBlock> s_threadCurrentBlock; // 0x28
		private static ConcurrentStack<UnSafeString> s_threadSharedStringPool; // 0x30
		private static readonly char[] UP_TABLE; // 0x38
		private static readonly char[] LOW_TABLE; // 0x40
		private string m_buffer; // 0x10
		private ulong m_handler; // 0x18
		[Nullable(0)]
		private unsafe int* m_strCount; // 0x20
		private int m_length; // 0x28
		private bool m_resizeFlag; // 0x2C
		public static UnSafeString Empty; // 0x48
		public static int s_mainThread; // 0x50
		private static Queue<UnSafeString>[] s_freeListPool; // 0x58
		private static Queue<UnSafeString>[] s_secondFreeListPool; // 0x60
		private static Dictionary<uint2, string> s_sharedStringPool; // 0x68
	
		// Properties
		public int Length { get; private set; } // 0x0000000182F7FE00-0x0000000182F7FE90 0x0000000182F7FBB0-0x0000000182F7FE00
	
		// Nested types
		[NullableContext(0)]
		public class HgStringBlock : IDisposable // TypeDefIndex: 62209
		{
			// Fields
			[Nullable(1)]
			private readonly Stack<UnSafeString> m_stack; // 0x10
	
			// Constructors
			internal HgStringBlock(int capacity); // 0x0000000184A22950-0x0000000184A229E0
	
			// Methods
			[NullableContext(1)]
			internal void Push(UnSafeString str); // 0x0000000182F82630-0x0000000182F827F0
			void IDisposable.Dispose(); // 0x0000000182F81080-0x0000000182F814E0
		}
	
		[NullableContext(0)]
		public class HgThreadStringBlock : IDisposable // TypeDefIndex: 62210
		{
			// Fields
			[Nullable(1)]
			private readonly Stack<UnSafeString> m_stack; // 0x10
	
			// Methods
			void IDisposable.Dispose(); // 0x000000018B8BF30C-0x000000018B8BF53C
		}
	
		[Nullable(0)]
		public struct UnSafeStringHandle : IDisposable // TypeDefIndex: 62211
		{
			// Fields
			private GCHandle m_stringHandler; // 0x00
	
			// Constructors
			private UnSafeStringHandle(UnSafeString unSafeString); // 0x0000000185397798-0x00000001853977B8
	
			// Methods
			public static UnSafeStringHandle CreateHandle(int count = 64 /* Metadata: 0x023507A7 */); // 0x00000001844F4D70-0x00000001844F4DF0
			public void Dispose(); // 0x000000018B8C0844-0x000000018B8C08F4
			public UnSafeString Get(); // 0x000000018B8C08F4-0x000000018B8C0964
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62212
		{
			// Fields
			[Nullable(0)]
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000184D411D0-0x0000000184D41230
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Stack<HgThreadStringBlock> _.cctor_b__43_0(); // 0x000000018B8C0784-0x000000018B8C07E4
			internal Stack<HgThreadStringBlock> _.cctor_b__43_1(); // 0x000000018B8C07E4-0x000000018B8C0844
		}
	
		// Constructors
		static UnSafeString(); // 0x00000001847A13D0-0x00000001847A1920
		private UnSafeString(int count = 256 /* Metadata: 0x023507A0 */); // 0x0000000182F23970-0x0000000182F23A60
	
		// Methods
		[IDTag(0)]
		public void Append(char value); // 0x0000000182F7FA00-0x0000000182F7FBB0
		[NullableContext(0)]
		public unsafe void Append(char* value, int count); // 0x0000000182F7F7B0-0x0000000182F7FA00
		[IDTag(2)]
		public void Append(int value); // 0x00000001833319C0-0x0000000183331C90
		[IDTag(3)]
		public void Append(string value); // 0x0000000182F7E8F0-0x0000000182F7EBC0
		[IDTag(5)]
		[NullableContext(0)]
		public void Append(Span<char> value); // 0x0000000183A756F0-0x0000000183A75750
		public void Replace(char newChar, int Index); // 0x0000000183E22FF0-0x0000000183E23060
		[IDTag(7)]
		public void Append(UnSafeString value); // 0x0000000182F67C40-0x0000000182F67DA0
		[NullableContext(0)]
		public unsafe void Append(byte* value, int count); // 0x000000018B8C0964-0x000000018B8C0BDC
		private int _GetUTF8ByteCnt(byte bt); // 0x000000018B8C0F20-0x000000018B8C0FB8
		public static IDisposable Scope(); // 0x0000000182F80D20-0x0000000182F81080
		public static UnSafeString Concat<T1, T2>(T1 arg1, T2 arg2);
		public static UnSafeString Concat<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3);
		public static UnSafeString Concat<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
		public static UnSafeString Create(int count = 256 /* Metadata: 0x023507A2 */); // 0x0000000182F70F90-0x0000000182F71040
		public static UnSafeString CreateRaw(int count = 256 /* Metadata: 0x023507A4 */); // 0x0000000182F238E0-0x0000000182F23970
		public void Dispose(); // 0x0000000183C87890-0x0000000183C878E0
		public int GetStringBufferSize(); // 0x0000000182F7E1C0-0x0000000182F7E220
		public void Clear(); // 0x0000000182F7E6A0-0x0000000182F7E770
		public string CloneString(); // 0x0000000183829930-0x0000000183829990
		[IDTag(1)]
		[NullableContext(0)]
		public void CloneToBytes(Span<byte> bytes); // 0x000000018B8C0BDC-0x000000018B8C0D2C
		public override string ToString(); // 0x0000000182F7E770-0x0000000182F7E7D0
		private void _Resize(int size); // 0x000000018B8C0FB8-0x000000018B8C10D8
		public override int GetHashCode(); // 0x000000018B8C0D2C-0x000000018B8C0DD4
		public void ToLow(); // 0x000000018304A710-0x000000018304A850
		[NullableContext(0)]
		public static unsafe UnSafeString GetUnsafeString(char* ptr, int length); // 0x000000018B8C0EA4-0x000000018B8C0F20
		[IDTag(0)]
		[NullableContext(0)]
		public static UnSafeString GetUnsafeStringUTF8(Span<byte> span); // 0x000000018B8C0DD4-0x000000018B8C0EA4
		public static UnSafeString Format<T>(string formatString, T arg);
		public static UnSafeString Format<T1, T2>(string formatString, T1 arg, T2 arg1);
		public static UnSafeString Format<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3);
		public static UnSafeString Format<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
		public static UnSafeString Format<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
		[IDTag(0)]
		public static implicit operator string(UnSafeString value); // 0x0000000182F814E0-0x0000000182F81560
		[IDTag(1)]
		public static implicit operator UnSafeString(string value); // 0x000000018B8C10D8-0x000000018B8C117C
		public static UnSafeString TryGetUnSafeStringFromPool(int requestStringLength, bool inScope = true /* Metadata: 0x023507A6 */); // 0x0000000182F816F0-0x0000000182F81FF0
		private static void _RecycleString(UnSafeString uString); // 0x0000000182F7DC70-0x0000000182F7E1C0
		public static void FreeCacheMemory(); // 0x0000000183C87620-0x0000000183C87890
		public void Split(char separator, ref List<UnSafeString> list); // 0x000000018333B880-0x000000018333B9B0
	}
}

namespace Cysharp.Text
{
	internal static class EnumUtil<T> // TypeDefIndex: 62215
	{
		// Fields
		[Nullable(1)]
		private static readonly Dictionary<T, string> names;
		[Nullable(1)]
		private static readonly Dictionary<T, byte[]> utf8names;
	
		// Constructors
		static EnumUtil();
	
		// Methods
		public static bool TryFormatUtf16([Nullable(1)] T value, Span<char> dest, out int written, ReadOnlySpan<char> _);
	}

	internal static class ExceptionUtil // TypeDefIndex: 62216
	{
		// Methods
		internal static void ThrowFormatException(); // 0x000000018B8BF060-0x000000018B8BF0BC
		internal static void ThrowFormatError(); // 0x000000018B8BF004-0x000000018B8BF060
	}

	internal static class FastNumberWriter // TypeDefIndex: 62217
	{
		// Methods
		public static bool TryWriteInt64(Span<char> buffer, out int charsWritten, long value); // 0x00000001839AE2F0-0x00000001839AE9B0
		public static bool TryWriteUInt64(Span<char> buffer, out int charsWritten, ulong value); // 0x0000000183C49A90-0x0000000183C49FD0
	}

	internal static class FormatParser // TypeDefIndex: 62219
	{
		// Nested types
		[IsByRefLike]
		[IsReadOnly]
		[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		public struct ParseResult // TypeDefIndex: 62218
		{
			// Fields
			public readonly int Index; // 0x00
			public readonly ReadOnlySpan<char> FormatString; // 0x08
			public readonly int LastIndex; // 0x18
			public readonly int Alignment; // 0x1C
	
			// Constructors
			public ParseResult(int index, ReadOnlySpan<char> formatString, int lastIndex, int alignment); // 0x0000000184DBF6D0-0x0000000184DBF6F0
		}
	
		// Methods
		private static bool IsDigit(char c); // 0x000000018B8BF0BC-0x000000018B8BF0D4
		[NullableContext(1)]
		public static ParseResult Parse(string format, int i); // 0x000000018B8BF0D4-0x000000018B8BF30C
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class NestedStringBuilderCreationException : InvalidOperationException // TypeDefIndex: 62220
	{
		// Constructors
		protected internal NestedStringBuilderCreationException(string typeName, string extraMessage = "" /* Metadata: 0x023507A9 */); // 0x000000018B8C0118-0x000000018B8C0194
	}

	[IsReadOnly]
	[Nullable(0)]
	[NullableContext(1)]
	internal struct ReadOnlyListAdaptor<T> : IReadOnlyList<T> // TypeDefIndex: 62221
	{
		// Fields
		private readonly IList<T> _list;
	
		// Properties
		public T this[int index] { get => default; }
		public int Count { get; }
	
		// Constructors
		public ReadOnlyListAdaptor(IList<T> list);
	
		// Methods
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	[Nullable(0)]
	[NullableContext(1)]
	public struct Utf16ValueStringBuilder : IDisposable, IBufferWriter<char> // TypeDefIndex: 62226
	{
		// Fields
		private static char newLine1; // 0x00
		private static char newLine2; // 0x02
		private static bool crlf; // 0x04
		[Nullable(2)]
		[ThreadStatic]
		private static char[] scratchBuffer; // 0x80000000
		[ThreadStatic]
		internal static bool scratchBufferUsed; // 0x80000008
		[Nullable(2)]
		private char[] buffer; // 0x00
		private int index; // 0x08
		private bool disposeImmediately; // 0x0C
	
		// Properties
		public int Length { get; } // 0x0000000184D88B10-0x0000000184D88B20 
	
		// Nested types
		[NullableContext(0)]
		public delegate bool TryFormat<T>([Nullable(1)] T value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format); // TypeDefIndex: 62222; 0x00000000-0x00000000
	
		[NullableContext(0)]
		public static class FormatterCache<T> // TypeDefIndex: 62223
		{
			// Fields
			[Nullable(1)]
			public static TryFormat<T> TryFormatDelegate;
	
			// Constructors
			static FormatterCache();
	
			// Methods
			private static bool TryFormatString([Nullable(1)] T value, Span<char> dest, out int written, ReadOnlySpan<char> format);
			private static bool TryFormatUnsafeString([Nullable(1)] T value, Span<char> dest, out int written, ReadOnlySpan<char> format);
			private static bool TryFormatDefault([Nullable(1)] T value, Span<char> dest, out int written, ReadOnlySpan<char> format);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62224
		{
			// Fields
			[Nullable(0)]
			public static readonly __c __9; // 0x00
			[Nullable(0)]
			public static TryFormat<bool> __9__52_0; // 0x08
			[Nullable(0)]
			public static TryFormat<sbyte> __9__52_1; // 0x10
			[Nullable(0)]
			public static TryFormat<short> __9__52_2; // 0x18
			[Nullable(0)]
			public static TryFormat<int> __9__52_3; // 0x20
			[Nullable(0)]
			public static TryFormat<long> __9__52_4; // 0x28
			[Nullable(0)]
			public static TryFormat<byte> __9__52_5; // 0x30
			[Nullable(0)]
			public static TryFormat<ushort> __9__52_6; // 0x38
			[Nullable(0)]
			public static TryFormat<uint> __9__52_7; // 0x40
			[Nullable(0)]
			public static TryFormat<ulong> __9__52_8; // 0x48
			[Nullable(0)]
			public static TryFormat<float> __9__52_9; // 0x50
			[Nullable(0)]
			public static TryFormat<double> __9__52_10; // 0x58
			[Nullable(0)]
			public static TryFormat<TimeSpan> __9__52_11; // 0x60
			[Nullable(0)]
			public static TryFormat<System.DateTime> __9__52_12; // 0x68
			[Nullable(0)]
			public static TryFormat<DateTimeOffset> __9__52_13; // 0x70
			[Nullable(0)]
			public static TryFormat<decimal> __9__52_14; // 0x78
			[Nullable(0)]
			public static TryFormat<Guid> __9__52_15; // 0x80
			[Nullable(0)]
			public static TryFormat<IntPtr> __9__52_16; // 0x88
			[Nullable(0)]
			public static TryFormat<UIntPtr> __9__52_17; // 0x90
	
			// Constructors
			static __c(); // 0x0000000184D3FDF0-0x0000000184D3FE50
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_0(bool x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018419D790-0x000000018419D840
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_1(sbyte x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018B8C04D4-0x000000018B8C0580
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_2(short x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018B8C0580-0x000000018B8C062C
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_3(int x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x00000001839AE240-0x00000001839AE2F0
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_4(long x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x00000001839AE1C0-0x00000001839AE240
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_5(byte x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018B8C062C-0x000000018B8C06D8
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_6(ushort x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018B8C06D8-0x000000018B8C0784
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_7(uint x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x0000000183C49A50-0x0000000183C49A90
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_8(ulong x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x0000000183C49A10-0x0000000183C49A50
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_9(float x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018382D410-0x000000018382D460
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_10(double x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018382D740-0x000000018382D7D0
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_11(TimeSpan x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018B8C0204-0x000000018B8C028C
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_12(System.DateTime x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x0000000183779680-0x0000000183779750
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_13(DateTimeOffset x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018B8C028C-0x000000018B8C0318
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_14(decimal x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018B8C0318-0x000000018B8C03A4
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_15(Guid x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018B8C03A4-0x000000018B8C03E8
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_16(IntPtr x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018B8C03E8-0x000000018B8C0434
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_17(UIntPtr x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018B8C0434-0x000000018B8C04D4
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__170<T> // TypeDefIndex: 62225
			where T : struct
		{
			// Fields
			[Nullable(0)]
			public static readonly __c__170<T> __9;
			[Nullable(0)]
			public static TryFormat<T?> __9__170_0;
	
			// Constructors
			static __c__170();
			public __c__170();
	
			// Methods
			[NullableContext(0)]
			internal bool _CreateNullableFormatter_b__170_0(T? x, Span<char> dest, out int written, ReadOnlySpan<char> format);
		}
	
		// Constructors
		static Utf16ValueStringBuilder(); // 0x000000018403C8B0-0x000000018403C950
		public Utf16ValueStringBuilder(bool disposeImmediately); // 0x000000018B8C1BC8-0x000000018B8C1D4C
	
		// Methods
		[NullableContext(0)]
		internal void AppendJoinInternal<T>(ReadOnlySpan<char> separator, [Nullable(1)] IReadOnlyList<T> values);
		[NullableContext(0)]
		internal void AppendJoinInternal<T>(ReadOnlySpan<char> separator, [Nullable(new byte[2] {0, 1 })] ReadOnlySpan<T> values);
		[NullableContext(0)]
		internal void AppendJoinInternal<T>(ReadOnlySpan<char> separator, [Nullable(1)] IEnumerable<T> values);
		public void AppendFormat<T1>(string format, T1 arg1);
		public void AppendFormat<T1, T2>(string format, T1 arg1, T2 arg2);
		public void AppendFormat<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3);
		public void AppendFormat<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
		public void AppendFormat<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
		public void AppendFormat<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);
		private static object CreateFormatter(System.Type type); // 0x000000018414FA30-0x0000000184150B60
		public void Append(int value); // 0x000000018B8C1420-0x000000018B8C154C
		[NullableContext(0)]
		public ReadOnlySpan<char> AsSpan(); // 0x000000018B8C1864-0x000000018B8C18F4
		[NullableContext(0)]
		public ArraySegment<char> AsArraySegment(); // 0x000000018B8C1804-0x000000018B8C1864
		public void Dispose(); // 0x000000018B8C18F4-0x000000018B8C19B0
		public void Grow(int sizeHint); // 0x00000001832B1C70-0x00000001832B1DD0
		public void AppendLine(); // 0x000000018B8C11D4-0x000000018B8C1338
		public void Append(char value); // 0x000000018B8C1614-0x000000018B8C16A4
		public void Append(char value, int repeatCount); // 0x000000018B8C1338-0x000000018B8C1420
		public void Append(string value); // 0x000000018B8C16A4-0x000000018B8C1714
		public void AppendLine(string value); // 0x000000018B8C117C-0x000000018B8C11D4
		public void Append(string value, int startIndex, int count); // 0x000000018B8C1714-0x000000018B8C1804
		[NullableContext(0)]
		public void Append(ReadOnlySpan<char> value); // 0x000000018B8C154C-0x000000018B8C1614
		public void Append<T>(T value);
		public override string ToString(); // 0x0000000182F25CE0-0x0000000182F26090
		[NullableContext(0)]
		public Memory<char> GetMemory(int sizeHint); // 0x000000018B8C19B0-0x000000018B8C1A58
		[NullableContext(0)]
		public Span<char> GetSpan(int sizeHint); // 0x000000018B8C1A58-0x000000018B8C1AF4
		public void Advance(int count); // 0x0000000184DA3A90-0x0000000184DA3AA0
		private void ThrowArgumentException(string paramName); // 0x000000018B8C1AF4-0x000000018B8C1B58
		private static void ThrowFormatException(); // 0x0000000183996AE0-0x0000000183996B50
		private void AppendFormatInternal<T>(T arg, int width, [Nullable(0)] ReadOnlySpan<char> format, string argName);
		private static void ThrowNestedException(); // 0x000000018B8C1B58-0x000000018B8C1BC8
		[NullableContext(0)]
		private static TryFormat<T?> CreateNullableFormatter<T>()
			where T : struct;
		public ref char GetPinnableReference(); // 0x0000000182F26090-0x0000000182F26A30
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class ZString // TypeDefIndex: 62227
	{
		// Fields
		private static Encoding UTF8NoBom; // 0x00
	
		// Constructors
		static ZString(); // 0x0000000184A25BD0-0x0000000184A25C60
	
		// Methods
		public static string Concat<T1, T2>(T1 arg1, T2 arg2);
		public static string Concat<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3);
		public static string Concat<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
		public static string Concat<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
		public static string Concat<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
		public static string Concat<T1, T2, T3, T4, T5, T6, T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);
		public static Utf16ValueStringBuilder CreateStringBuilder(); // 0x000000018379A620-0x000000018379A640
		public static string Join<T>(char separator, params T[] values);
		public static string Join<T>(char separator, List<T> values);
		public static string Join<T>(char separator, IEnumerable<T> values);
		public static string Join<T>(char separator, ICollection<T> values);
		public static string Join<T>(char separator, IList<T> values);
		public static string Join<T>(char separator, IReadOnlyList<T> values);
		public static string Join<T>(char separator, IReadOnlyCollection<T> values);
		public static string Join<T>(string separator, List<T> values);
		public static string Join<T>(string separator, ICollection<T> values);
		public static string Join<T>(string separator, IList<T> values);
		public static string Join<T>(string separator, IReadOnlyList<T> values);
		public static string Join<T>(string separator, IReadOnlyCollection<T> values);
		public static string Join<T>(string separator, IEnumerable<T> values);
		private static string JoinInternal<T>([Nullable(0)] ReadOnlySpan<char> separator, IList<T> values);
		private static string JoinInternal<T>([Nullable(0)] ReadOnlySpan<char> separator, IReadOnlyList<T> values);
		[NullableContext(0)]
		private static string JoinInternal<T>(ReadOnlySpan<char> separator, [Nullable(new byte[2] {0, 1 })] ReadOnlySpan<T> values);
		private static string JoinInternal<T>([Nullable(0)] ReadOnlySpan<char> separator, IEnumerable<T> values);
		public static string Format<T1>(string format, T1 arg1);
		public static string Format<T1, T2>(string format, T1 arg1, T2 arg2);
		public static string Format<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3);
		public static string Format<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
		public static string Format<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
		public static string Format<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
		public static string Format<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
		public static string Format<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 62231
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		static ILFixDynamicMethodWrapper(); // 0x0000000184D374F0-0x0000000184D37560
	
		// Methods
		public int __Gen_Wrap_0(object P0); // 0x0000000186360E84-0x0000000186360F54
		public void __Gen_Wrap_1(object P0, int P1); // 0x00000001866F3838-0x00000001866F3914
		public void __Gen_Wrap_2(object P0, char P1); // 0x000000018698C880-0x000000018698C95C
		public void __Gen_Wrap_4(object P0, object P1); // 0x0000000186377B18-0x0000000186377BF4
		public void __Gen_Wrap_6(object P0, Span<char> P1); // 0x000000018B8BFF2C-0x000000018B8C0040
		public void __Gen_Wrap_7(object P0, char P1, int P2); // 0x000000018698C95C-0x000000018698CA54
		public int __Gen_Wrap_9(object P0, byte P1); // 0x000000018B8C0040-0x000000018B8C0118
		public void __Gen_Wrap_10(object P0); // 0x00000001863633B4-0x0000000186363474
		public void __Gen_Wrap_11(); // 0x00000001863625A4-0x0000000186362640
		public IDisposable __Gen_Wrap_12(); // 0x000000018B8BF53C-0x000000018B8BF608
		public UnSafeString __Gen_Wrap_13(int P0, bool P1); // 0x000000018B8BF608-0x000000018B8BF714
		public UnSafeString __Gen_Wrap_14(int P0); // 0x000000018B8BF714-0x000000018B8BF800
		public string __Gen_Wrap_15(object P0); // 0x000000018B8BF800-0x000000018B8BF8F0
		public void __Gen_Wrap_16(object P0, Span<byte> P1); // 0x000000018B8BF8F0-0x000000018B8BF9F0
		public UnSafeString __Gen_Wrap_23(Span<byte> P0); // 0x000000018B8BF9F0-0x000000018B8BFAF0
		public UnSafeString __Gen_Wrap_24(object P0); // 0x000000018B8BFAF0-0x000000018B8BFBE0
		public void __Gen_Wrap_31(object P0, char P1, ref List<UnSafeString> P2); // 0x000000018B8BFBE0-0x000000018B8BFD24
		public UnSafeString.UnSafeStringHandle __Gen_Wrap_32(int P0); // 0x000000018B8BFD24-0x000000018B8BFE10
		public void __Gen_Wrap_33(ref UnSafeString.UnSafeStringHandle P0); // 0x000000018B8BFE10-0x000000018B8BFF2C
	}

	public class WrappersManagerImpl // TypeDefIndex: 62232
	{
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018B8C1D4C-0x000000018B8C1DB0
		public static bool IsPatched(int id); // 0x0000000182F7FE90-0x0000000182F7FF20
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 62202
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Numerics
{
	public static class BitOperations // TypeDefIndex: 62214
	{
		// Properties
		private static ReadOnlySpan<byte> TrailingZeroCountDeBruijn { get; } // 0x0000000182FEC520-0x0000000182FEC570 
		private static ReadOnlySpan<byte> Log2DeBruijn { get; } // 0x0000000182FEC570-0x0000000182FEC5F0 
	
		// Methods
		public static int LeadingZeroCount(uint value); // 0x000000018B8BEEC4-0x000000018B8BEEE8
		public static int LeadingZeroCount(ulong value); // 0x000000018B8BEEE8-0x000000018B8BEF10
		private static int Log2SoftwareFallback(uint value); // 0x0000000182FEA7D0-0x0000000182FEC520
		public static int PopCount(uint value); // 0x0000000184DADFA0-0x0000000184DADFE0
		public static int PopCount(ulong value); // 0x000000018B8BEF10-0x000000018B8BEF6C
		public static int TrailingZeroCount(int value); // 0x000000018B8BEFDC-0x000000018B8BEFE4
		public static int TrailingZeroCount(uint value); // 0x000000018B8BEF6C-0x000000018B8BEFDC
		public static int TrailingZeroCount(ulong value); // 0x000000018B8BEFE4-0x000000018B8BF004
	}
}

namespace System.Runtime.CompilerServices
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Embedded]
	internal sealed class NullableAttribute : Attribute // TypeDefIndex: 62203
	{
		// Fields
		public readonly byte[] NullableFlags; // 0x10
	
		// Constructors
		public NullableAttribute(byte param_00084da0); // 0x000000018B8C0194-0x000000018B8C0204
		public NullableAttribute(byte[] param_00084da1); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Embedded]
	internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 62204
	{
		// Fields
		public readonly byte Flag; // 0x10
	
		// Constructors
		public NullableContextAttribute(byte param_00084da2); // 0x0000000184D86130-0x0000000184D86140
	}
}
