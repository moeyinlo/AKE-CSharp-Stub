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
using IFix.Core;
using Microsoft.CodeAnalysis;
using Unity.Mathematics;

// Image 70: ZString.dll - Assembly: ZString, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89533-89561

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 89561
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_256 _1861BF4EAE96D61721D493270BADE6B1F1FFEB0A6BCA271EE90DC9B33E918625; // 0x00 // Static value (base64): AAABAAIAAwAEAAUABgAHAAgACQAKAAsADAANAA4ADwAQABEAEgATABQAFQAWABcAGAAZABoAGwAcAB0AHgAfACAAIQAiACMAJAAlACYAJwAoACkAKgArACwALQAuAC8AMAAxADIAMwA0ADUANgA3ADgAOQA6ADsAPAA9AD4APwBAAEEAQgBDAEQARQBGAEcASABJAEoASwBMAE0ATgBPAFAAUQBSAFMAVABVAFYAVwBYAFkAWgBbAFwAXQBeAF8AYABBAEIAQwBEAEUARgBHAEgASQBKAEsATABNAE4ATwBQAFEAUgBTAFQAVQBWAFcAWABZAFoAewB8AH0AfgB/AA== - Metadata: 0x02649240
	internal static readonly __StaticArrayInitTypeSize_32 _3BF63951626584EB1653F9B8DBB590A5EE1EAE1135A904B9317C3773896DF076; // 0x100 // Static value (base64): AAEcAh0OGAMeFhQPGREECB8bDRcVExAHGgwSBgsFCgk= - Metadata: 0x02649348
	internal static readonly __StaticArrayInitTypeSize_32 _4BCD43D478B9229AB7A13406353712C7944B60348C36B4D0E6B789D10F697652; // 0x120 // Static value (base64): AAkBCg0VAh0LDhASFhkDHggMFBwPERgHExsXBhoFBB8= - Metadata: 0x02649370
	internal static readonly __StaticArrayInitTypeSize_256 E14330899333C68046C96292E14EF1B988B41F2809D50D9C2D5A83F2E83BF2AA; // 0x140 // Static value (base64): AAABAAIAAwAEAAUABgAHAAgACQAKAAsADAANAA4ADwAQABEAEgATABQAFQAWABcAGAAZABoAGwAcAB0AHgAfACAAIQAiACMAJAAlACYAJwAoACkAKgArACwALQAuAC8AMAAxADIAMwA0ADUANgA3ADgAOQA6ADsAPAA9AD4APwBAAGEAYgBjAGQAZQBmAGcAaABpAGoAawBsAG0AbgBvAHAAcQByAHMAdAB1AHYAdwB4AHkAegBbAFwAXQBeAF8AYABhAGIAYwBkAGUAZgBnAGgAaQBqAGsAbABtAG4AbwBwAHEAcgBzAHQAdQB2AHcAeAB5AHoAewB8AH0AfgB/AA== - Metadata: 0x02649398

	// Nested types
	private struct __StaticArrayInitTypeSize_32 // TypeDefIndex: 89559
	{
	}

	private struct __StaticArrayInitTypeSize_256 // TypeDefIndex: 89560
	{
	}
}

namespace Beyond
{
	public struct MonoObject_64 // TypeDefIndex: 89537
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x08
	}

	public struct MonoObject_32 // TypeDefIndex: 89538
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x04
	}

	public struct MonoString_64 // TypeDefIndex: 89539
	{
		// Fields
		public MonoObject_64 obj; // 0x00
		public int length; // 0x10
		public char firstChar; // 0x14
	}

	public struct MonoString_32 // TypeDefIndex: 89540
	{
		// Fields
		public MonoObject_32 obj; // 0x00
		public int length; // 0x08
		public char firstChar; // 0x0C
	}

	[DefaultMember("Item")]
	[Nullable(0)]
	[NullableContext(1)]
	public class UnSafeString // TypeDefIndex: 89545
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
		public int Length { get; private set; } // 0x000000018524EE60-0x000000018524EE90 0x000000018524EE90-0x000000018524EEC0
	
		// Nested types
		[NullableContext(0)]
		public class HgStringBlock : IDisposable // TypeDefIndex: 89541
		{
			// Fields
			[Nullable(1)]
			private readonly Stack<UnSafeString> m_stack; // 0x10
	
			// Constructors
			internal HgStringBlock(int capacity); // 0x0000000186DBAF30-0x0000000186DBAFC0
	
			// Methods
			[NullableContext(1)]
			internal void Push(UnSafeString str); // 0x000000018524E530-0x000000018524E680
			void IDisposable.Dispose(); // 0x000000018524D5A0-0x000000018524D980
		}
	
		[NullableContext(0)]
		public class HgThreadStringBlock : IDisposable // TypeDefIndex: 89542
		{
			// Fields
			[Nullable(1)]
			private readonly Stack<UnSafeString> m_stack; // 0x10
	
			// Methods
			void IDisposable.Dispose(); // 0x000000018D9F9FC4-0x000000018D9FA1F4
		}
	
		[Nullable(0)]
		public struct UnSafeStringHandle : IDisposable // TypeDefIndex: 89543
		{
			// Fields
			private GCHandle m_stringHandler; // 0x00
	
			// Constructors
			private UnSafeStringHandle(UnSafeString unSafeString); // 0x000000018783970C-0x000000018783972C
	
			// Methods
			public static UnSafeStringHandle CreateHandle(int count = 64 /* Metadata: 0x0264923A */); // 0x0000000185AD5910-0x0000000185AD59A0
			public void Dispose(); // 0x000000018D9FA91C-0x000000018D9FA9CC
			public UnSafeString Get(); // 0x000000018D9FA9CC-0x000000018D9FAA3C
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 89544
		{
			// Fields
			[Nullable(0)]
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x00000001871E4E20-0x00000001871E4E80
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Stack<HgThreadStringBlock> _.cctor_b__43_0(); // 0x000000018D9FA85C-0x000000018D9FA8BC
			internal Stack<HgThreadStringBlock> _.cctor_b__43_1(); // 0x000000018D9FA8BC-0x000000018D9FA91C
		}
	
		// Constructors
		static UnSafeString(); // 0x0000000186C33ED0-0x0000000186C34420
		private UnSafeString(int count = 256 /* Metadata: 0x02649233 */); // 0x000000018588B4C0-0x000000018588B5F0
	
		// Methods
		[IDTag(0)]
		public void Append(char value); // 0x000000018524EC60-0x000000018524EE60
		[NullableContext(0)]
		public unsafe void Append(char* value, int count); // 0x000000018524EB50-0x000000018524EC60
		[IDTag(2)]
		public void Append(int value); // 0x0000000185445A70-0x0000000185445C10
		[IDTag(3)]
		public void Append(string value); // 0x000000018524E6F0-0x000000018524E830
		[IDTag(5)]
		[NullableContext(0)]
		public void Append(Span<char> value); // 0x0000000185AEEFC0-0x0000000185AEF020
		public void Replace(char newChar, int Index); // 0x00000001861AFBA0-0x00000001861AFC00
		[IDTag(7)]
		public void Append(UnSafeString value); // 0x000000018510A000-0x000000018510A180
		[NullableContext(0)]
		public unsafe void Append(byte* value, int count); // 0x0000000185806480-0x00000001858065E0
		private int _GetUTF8ByteCnt(byte bt); // 0x00000001858065E0-0x0000000185806620
		public static IDisposable Scope(); // 0x000000018524D2B0-0x000000018524D5A0
		public static UnSafeString Concat<T1, T2>(T1 arg1, T2 arg2);
		public static UnSafeString Concat<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3);
		public static UnSafeString Concat<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
		public static UnSafeString Create(int count = 256 /* Metadata: 0x02649235 */); // 0x000000018524CF20-0x000000018524CFA0
		public static UnSafeString CreateRaw(int count = 256 /* Metadata: 0x02649237 */); // 0x000000018588B460-0x000000018588B4C0
		public void Dispose(); // 0x0000000186063F20-0x0000000186063F80
		public int GetStringBufferSize(); // 0x000000018D9FAC2C-0x000000018D9FAC6C
		public void Clear(); // 0x000000018524E680-0x000000018524E6F0
		public string CloneString(); // 0x0000000186645930-0x0000000186645990
		[IDTag(1)]
		[NullableContext(0)]
		public void CloneToBytes(Span<byte> bytes); // 0x000000018D9FAA3C-0x000000018D9FAB84
		public override string ToString(); // 0x0000000185E6DE90-0x0000000185E6DEC0
		private void _Resize(int size); // 0x000000018D9FADC0-0x000000018D9FAEE0
		public override int GetHashCode(); // 0x000000018D9FAB84-0x000000018D9FAC2C
		public int IndexOf(string value); // 0x0000000184F7B680-0x0000000184F7B7A0
		public void ToLow(); // 0x000000018524E830-0x000000018524E930
		[NullableContext(0)]
		public static unsafe UnSafeString GetUnsafeString(char* ptr, int length); // 0x000000018D9FAD44-0x000000018D9FADC0
		[IDTag(0)]
		[NullableContext(0)]
		public static UnSafeString GetUnsafeStringUTF8(Span<byte> span); // 0x000000018D9FAC6C-0x000000018D9FAD44
		public static UnSafeString Format<T>(string formatString, T arg);
		public static UnSafeString Format<T1, T2>(string formatString, T1 arg, T2 arg1);
		public static UnSafeString Format<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3);
		public static UnSafeString Format<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
		public static UnSafeString Format<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
		[IDTag(0)]
		public static implicit operator string(UnSafeString value); // 0x0000000184F91900-0x0000000184F91940
		[IDTag(1)]
		public static implicit operator UnSafeString(string value); // 0x000000018D9FAEE0-0x000000018D9FAF88
		public static UnSafeString TryGetUnSafeStringFromPool(int requestStringLength, bool inScope = true /* Metadata: 0x02649239 */); // 0x000000018524DD90-0x000000018524E530
		private static void _RecycleString(UnSafeString uString); // 0x000000018524D980-0x000000018524DD90
		public static void FreeCacheMemory(); // 0x0000000186063AB0-0x0000000186063D40
		public string Shared(); // 0x0000000184F7B7A0-0x0000000184F7C220
		public void Split(char separator, ref List<UnSafeString> list); // 0x00000001852D0240-0x00000001852D04E0
	}
}

namespace Cysharp.Text
{
	internal static class EnumUtil<T> // TypeDefIndex: 89547
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

	internal static class ExceptionUtil // TypeDefIndex: 89548
	{
		// Methods
		internal static void ThrowFormatException(); // 0x000000018D9F9D24-0x000000018D9F9D80
		internal static void ThrowFormatError(); // 0x000000018D9F9CC8-0x000000018D9F9D24
	}

	internal static class FastNumberWriter // TypeDefIndex: 89549
	{
		// Methods
		public static bool TryWriteInt64(Span<char> buffer, out int charsWritten, long value); // 0x0000000185F02090-0x0000000185F02650
		public static bool TryWriteUInt64(Span<char> buffer, out int charsWritten, ulong value); // 0x0000000185EC3B30-0x0000000185EC4070
	}

	internal static class FormatParser // TypeDefIndex: 89551
	{
		// Nested types
		[IsByRefLike]
		[IsReadOnly]
		[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		public struct ParseResult // TypeDefIndex: 89550
		{
			// Fields
			public readonly int Index; // 0x00
			public readonly ReadOnlySpan<char> FormatString; // 0x08
			public readonly int LastIndex; // 0x18
			public readonly int Alignment; // 0x1C
	
			// Constructors
			public ParseResult(int index, ReadOnlySpan<char> formatString, int lastIndex, int alignment); // 0x0000000187264B00-0x0000000187264B20
		}
	
		// Methods
		private static bool IsDigit(char c); // 0x000000018D9F9D80-0x000000018D9F9D98
		[NullableContext(1)]
		public static ParseResult Parse(string format, int i); // 0x000000018D9F9D98-0x000000018D9F9FC4
	}

	[IsReadOnly]
	[Nullable(0)]
	[NullableContext(1)]
	internal struct ReadOnlyListAdaptor<T> : IReadOnlyList<T> // TypeDefIndex: 89552
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
	public struct Utf16ValueStringBuilder : IDisposable, IBufferWriter<char> // TypeDefIndex: 89557
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
		private bool usesThreadStaticBuffer; // 0x0C
	
		// Properties
		public int Length { get; } // 0x0000000184431A70-0x0000000184431A80 
	
		// Nested types
		[NullableContext(0)]
		public delegate bool TryFormat<T>([Nullable(1)] T value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format); // TypeDefIndex: 89553; 0x00000000-0x00000000
	
		[NullableContext(0)]
		public static class FormatterCache<T> // TypeDefIndex: 89554
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
		private sealed class __c // TypeDefIndex: 89555
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
			static __c(); // 0x00000001871E4A60-0x00000001871E4AC0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_0(bool x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x0000000186547B50-0x0000000186547C00
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_1(sbyte x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018D9FA598-0x000000018D9FA648
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_2(short x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018D9FA648-0x000000018D9FA6FC
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_3(int x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x0000000185F01FE0-0x0000000185F02090
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_4(long x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x0000000185F01F60-0x0000000185F01FE0
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_5(byte x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018D9FA6FC-0x000000018D9FA7AC
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_6(ushort x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018D9FA7AC-0x000000018D9FA85C
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_7(uint x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x0000000185EC3AF0-0x0000000185EC3B30
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_8(ulong x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x0000000185EC3AB0-0x0000000185EC3AF0
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_9(float x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x0000000185394360-0x00000001853943B0
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_10(double x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x0000000185399790-0x0000000185399820
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_11(TimeSpan x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018D9FA264-0x000000018D9FA2F0
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_12(System.DateTime x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x0000000185392CA0-0x0000000185392D70
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_13(DateTimeOffset x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018D9FA2F0-0x000000018D9FA384
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_14(decimal x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018D9FA384-0x000000018D9FA418
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_15(Guid x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018D9FA418-0x000000018D9FA4A0
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_16(IntPtr x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018D9FA4A0-0x000000018D9FA4F4
			[NullableContext(0)]
			internal bool _CreateFormatter_b__52_17(UIntPtr x, Span<char> dest, out int written, ReadOnlySpan<char> format); // 0x000000018D9FA4F4-0x000000018D9FA598
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__169<T> // TypeDefIndex: 89556
			where T : struct
		{
			// Fields
			[Nullable(0)]
			public static readonly __c__169<T> __9;
			[Nullable(0)]
			public static TryFormat<T?> __9__169_0;
	
			// Constructors
			static __c__169();
			public __c__169();
	
			// Methods
			[NullableContext(0)]
			internal bool _CreateNullableFormatter_b__169_0(T? x, Span<char> dest, out int written, ReadOnlySpan<char> format);
		}
	
		// Constructors
		static Utf16ValueStringBuilder(); // 0x00000001870BF180-0x00000001870BF220
		public Utf16ValueStringBuilder(bool disposeImmediately); // 0x000000018D9FBAAC-0x000000018D9FBC2C
	
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
		private static object CreateFormatter(System.Type type); // 0x0000000186481360-0x0000000186482490
		public void Append(int value); // 0x000000018D9FB220-0x000000018D9FB360
		public void Append(ulong value); // 0x000000018D9FB618-0x000000018D9FB758
		[NullableContext(0)]
		public ReadOnlySpan<char> AsSpan(); // 0x0000000186430630-0x00000001864306D0
		[NullableContext(0)]
		public ArraySegment<char> AsArraySegment(); // 0x000000018D9FB758-0x000000018D9FB7B8
		public void Dispose(); // 0x000000018D9FB7B8-0x000000018D9FB8A8
		public void Grow(int sizeHint); // 0x0000000185890170-0x00000001858905C0
		public void AppendLine(); // 0x000000018D9FAFE0-0x000000018D9FB138
		public void Append(char value); // 0x000000018D9FB428-0x000000018D9FB4B8
		public void Append(char value, int repeatCount); // 0x000000018D9FB138-0x000000018D9FB220
		public void Append(string value); // 0x000000018D9FB4B8-0x000000018D9FB528
		public void AppendLine(string value); // 0x000000018D9FAF88-0x000000018D9FAFE0
		public void Append(string value, int startIndex, int count); // 0x000000018D9FB528-0x000000018D9FB618
		[NullableContext(0)]
		public void Append(ReadOnlySpan<char> value); // 0x000000018D9FB360-0x000000018D9FB428
		public void Append<T>(T value);
		public override string ToString(); // 0x000000018588D8E0-0x000000018588E480
		[NullableContext(0)]
		public Memory<char> GetMemory(int sizeHint); // 0x000000018D9FB8A8-0x000000018D9FB950
		[NullableContext(0)]
		public Span<char> GetSpan(int sizeHint); // 0x000000018D9FB950-0x000000018D9FB9EC
		public void Advance(int count); // 0x0000000187251640-0x0000000187251650
		private void ThrowArgumentException(string paramName); // 0x000000018D9FB9EC-0x000000018D9FBA50
		private static void ThrowFormatException(); // 0x000000018D9FBA50-0x000000018D9FBAAC
		private void AppendFormatInternal<T>(T arg, int width, [Nullable(0)] ReadOnlySpan<char> format, string argName);
		[NullableContext(0)]
		private static TryFormat<T?> CreateNullableFormatter<T>()
			where T : struct;
		public ref char GetPinnableReference(); // 0x000000018588E480-0x000000018588E800
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class ZString // TypeDefIndex: 89558
	{
		// Fields
		private static Encoding UTF8NoBom; // 0x00
	
		// Constructors
		static ZString(); // 0x0000000186EBC1F0-0x0000000186EBC280
	
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
		public static Utf16ValueStringBuilder CreateStringBuilder(); // 0x0000000185092EE0-0x0000000185092F00
		public static Utf16ValueStringBuilder CreateStringBuilder(bool notNested); // 0x000000018D9FBC2C-0x000000018D9FBC4C
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

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 89534
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Numerics
{
	public static class BitOperations // TypeDefIndex: 89546
	{
		// Properties
		private static ReadOnlySpan<byte> TrailingZeroCountDeBruijn { get; } // 0x0000000185004C30-0x0000000185004E00 
		private static ReadOnlySpan<byte> Log2DeBruijn { get; } // 0x0000000185004ED0-0x0000000185005130 
	
		// Methods
		public static int LeadingZeroCount(uint value); // 0x000000018D9F9B88-0x000000018D9F9BAC
		public static int LeadingZeroCount(ulong value); // 0x000000018D9F9BAC-0x000000018D9F9BD4
		private static int Log2SoftwareFallback(uint value); // 0x0000000185004E00-0x0000000185004ED0
		public static int PopCount(uint value); // 0x000000018725CC50-0x000000018725CC90
		public static int PopCount(ulong value); // 0x000000018D9F9BD4-0x000000018D9F9C30
		public static int TrailingZeroCount(int value); // 0x000000018D9F9CA0-0x000000018D9F9CA8
		public static int TrailingZeroCount(uint value); // 0x000000018D9F9C30-0x000000018D9F9CA0
		public static int TrailingZeroCount(ulong value); // 0x000000018D9F9CA8-0x000000018D9F9CC8
	}
}

namespace System.Runtime.CompilerServices
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Embedded]
	internal sealed class NullableAttribute : Attribute // TypeDefIndex: 89535
	{
		// Fields
		public readonly byte[] NullableFlags; // 0x10
	
		// Constructors
		public NullableAttribute(byte param_000bdc17); // 0x000000018D9FA1F4-0x000000018D9FA264
		public NullableAttribute(byte[] param_000bdc18); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Embedded]
	internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 89536
	{
		// Fields
		public readonly byte Flag; // 0x10
	
		// Constructors
		public NullableContextAttribute(byte param_000bdc19); // 0x0000000182A819C0-0x0000000182A819D0
	}
}
