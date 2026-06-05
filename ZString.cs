/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Buffers;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Beyond;
using IFix.Core;
using Unity.Mathematics;

// Image 69: ZString.dll - Assembly: ZString, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59626-59657

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 59655
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_256 _1861BF4EAE96D61721D493270BADE6B1F1FFEB0A6BCA271EE90DC9B33E918625; // 0x00 // Static value (base64): AAABAAIAAwAEAAUABgAHAAgACQAKAAsADAANAA4ADwAQABEAEgATABQAFQAWABcAGAAZABoAGwAcAB0AHgAfACAAIQAiACMAJAAlACYAJwAoACkAKgArACwALQAuAC8AMAAxADIAMwA0ADUANgA3ADgAOQA6ADsAPAA9AD4APwBAAEEAQgBDAEQARQBGAEcASABJAEoASwBMAE0ATgBPAFAAUQBSAFMAVABVAFYAVwBYAFkAWgBbAFwAXQBeAF8AYABBAEIAQwBEAEUARgBHAEgASQBKAEsATABNAE4ATwBQAFEAUgBTAFQAVQBWAFcAWABZAFoAewB8AH0AfgB/AA== - Metadata: 0x02080DC4
	internal static readonly __StaticArrayInitTypeSize_32 _3BF63951626584EB1653F9B8DBB590A5EE1EAE1135A904B9317C3773896DF076; // 0x100 // Static value (base64): AAEcAh0OGAMeFhQPGREECB8bDRcVExAHGgwSBgsFCgk= - Metadata: 0x02080ECC
	internal static readonly __StaticArrayInitTypeSize_32 _4BCD43D478B9229AB7A13406353712C7944B60348C36B4D0E6B789D10F697652; // 0x120 // Static value (base64): AAkBCg0VAh0LDhASFhkDHggMFBwPERgHExsXBhoFBB8= - Metadata: 0x02080EF4
	internal static readonly __StaticArrayInitTypeSize_256 E14330899333C68046C96292E14EF1B988B41F2809D50D9C2D5A83F2E83BF2AA; // 0x140 // Static value (base64): AAABAAIAAwAEAAUABgAHAAgACQAKAAsADAANAA4ADwAQABEAEgATABQAFQAWABcAGAAZABoAGwAcAB0AHgAfACAAIQAiACMAJAAlACYAJwAoACkAKgArACwALQAuAC8AMAAxADIAMwA0ADUANgA3ADgAOQA6ADsAPAA9AD4APwBAAGEAYgBjAGQAZQBmAGcAaABpAGoAawBsAG0AbgBvAHAAcQByAHMAdAB1AHYAdwB4AHkAegBbAFwAXQBeAF8AYABhAGIAYwBkAGUAZgBnAGgAaQBqAGsAbABtAG4AbwBwAHEAcgBzAHQAdQB2AHcAeAB5AHoAewB8AH0AfgB/AA== - Metadata: 0x02080F1C

	// Nested types
	private struct __StaticArrayInitTypeSize_32 // TypeDefIndex: 59653
	{
	}

	private struct __StaticArrayInitTypeSize_256 // TypeDefIndex: 59654
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Beyond
{
	public struct MonoObject_64 // TypeDefIndex: 59630
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x08
	}

	public struct MonoObject_32 // TypeDefIndex: 59631
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x04
	}

	public struct MonoString_64 // TypeDefIndex: 59632
	{
		// Fields
		public MonoObject_64 obj; // 0x00
		public int length; // 0x10
		public char firstChar; // 0x14
	}

	public struct MonoString_32 // TypeDefIndex: 59633
	{
		// Fields
		public MonoObject_32 obj; // 0x00
		public int length; // 0x08
		public char firstChar; // 0x0C
	}

	public class UnSafeString // TypeDefIndex: 59638
	{
		// Fields
		private static Stack<HgStringBlock> s_blocks; // 0x00
		private static Stack<HgStringBlock> s_stackBlocks; // 0x08
		private static HgStringBlock s_currentBlock; // 0x10
		private static ThreadLocal<Stack<HgThreadStringBlock>> s_threadBlockPool; // 0x18
		private static ThreadLocal<Stack<HgThreadStringBlock>> s_threadStackBlocks; // 0x20
		private static ThreadLocal<HgThreadStringBlock> s_threadCurrentBlock; // 0x28
		private static ConcurrentStack<UnSafeString> s_threadSharedStringPool; // 0x30
		private static readonly char[] UP_TABLE; // 0x38
		private static readonly char[] LOW_TABLE; // 0x40
		private string m_buffer; // 0x10
		private ulong m_handler; // 0x18
		private unsafe int* m_strCount; // 0x20
		private int m_length; // 0x28
		private bool m_resizeFlag; // 0x2C
		public static UnSafeString Empty; // 0x48
		public static int s_mainThread; // 0x50
		private static Queue<UnSafeString>[] s_freeListPool; // 0x58
		private static Queue<UnSafeString>[] s_secondFreeListPool; // 0x60
		private static Dictionary<uint2, string> s_sharedStringPool; // 0x68
	
		// Properties
		public int Length { get => default; private set {} } // 0x000000018C3D8250-0x000000018C3D8338 0x000000018C3D7FC4-0x000000018C3D806C
	
		// Nested types
		public class HgStringBlock : IDisposable // TypeDefIndex: 59634
		{
			// Fields
			private readonly Stack<UnSafeString> m_stack; // 0x10
	
			// Constructors
			public HgStringBlock() {} // Dummy constructor
			internal HgStringBlock(int capacity) {} // 0x00000001840561F0-0x00000001840562E0
	
			// Methods
			internal void Push(UnSafeString str) {} // 0x0000000184054590-0x0000000184054650
			void IDisposable.Dispose() {} // 0x00000001847790C0-0x0000000184779210
		}
	
		public class HgThreadStringBlock : IDisposable // TypeDefIndex: 59635
		{
			// Fields
			private readonly Stack<UnSafeString> m_stack; // 0x10
	
			// Constructors
			public HgThreadStringBlock() {} // Dummy constructor
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184056D50-0x0000000184056EB0
		}
	
		public struct UnSafeStringHandle : IDisposable // TypeDefIndex: 59636
		{
			// Fields
			private GCHandle m_stringHandler; // 0x00
	
			// Constructors
			private UnSafeStringHandle(UnSafeString unSafeString) {
				m_stringHandler = default;
			} // 0x000000018445F960-0x000000018445F9C0
	
			// Methods
			public static UnSafeStringHandle CreateHandle(int count = 64 /* Metadata: 0x02080DBC */) => default; // 0x00000001848B79F0-0x00000001848B7A70
			public void Dispose() {} // 0x00000001844F3440-0x00000001844F35A0
			public UnSafeString Get() => default; // 0x000000018C3D7C2C-0x000000018C3D7E94
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 59637
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018C3D81B8-0x000000018C3D8250
			public __c() {} // 0x00000001840546B0-0x0000000184054A70
	
			// Methods
			internal Stack<HgThreadStringBlock> _.cctor_b__43_0() => default;
			internal Stack<HgThreadStringBlock> _.cctor_b__43_1() => default;
		}
	
		// Constructors
		public UnSafeString() {} // Dummy constructor
		static UnSafeString() {} // 0x00000001844F4AA0-0x00000001844F4D20
		private UnSafeString(int count = 256 /* Metadata: 0x02080DB5 */) {} // 0x000000018C3D813C-0x000000018C3D81B8
	
		// Methods
		public void Append(char value) {}
		public unsafe void Append(char* value, int count) {} // 0x0000000185FEB080-0x0000000185FEB090
		public void Append(int value) {} // 0x0000000185FEB090-0x0000000185FEB0A0
		public void Append(string value) {} // 0x0000000185962F10-0x0000000185963460
		public void Append(Span<char> value) {} // 0x0000000184777A30-0x0000000184777AD0
		public void Replace(char newChar, int Index) {} // 0x0000000184059160-0x0000000184059270
		public void Append(UnSafeString value) {} // 0x00000001847779B0-0x0000000184777A30
		public unsafe void Append(byte* value, int count) {} // 0x00000001847715B0-0x0000000184771600
		private int _GetUTF8ByteCnt(byte bt) => default; // 0x00000001840581D0-0x0000000184058250
		public static IDisposable Scope() => default; // 0x00000001840590C0-0x0000000184059160
		public static UnSafeString Concat<T1, T2>(T1 arg1, T2 arg2) => default; // 0x00000001844D0DC0-0x00000001844D0E10
		public static UnSafeString Concat<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3) => default; // 0x000000018C3D7E94-0x000000018C3D7FC4
		public static UnSafeString Concat<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4) => default; // 0x0000000184057B70-0x0000000184057BF0
		public static UnSafeString Create(int count = 256 /* Metadata: 0x02080DB7 */) => default; // 0x000000018C3D806C-0x000000018C3D813C
		public static UnSafeString CreateRaw(int count = 256 /* Metadata: 0x02080DB9 */) => default;
		public void Dispose() {}
		public int GetStringBufferSize() => default;
		public void Clear() {}
		public string CloneString() => default;
		public void CloneToBytes(Span<byte> bytes) {} // 0x0000000184255640-0x00000001842556D0
		public override string ToString() => default; // 0x000000018C3D8338-0x000000018C3D83DC
		private void _Resize(int size) {} // 0x0000000184058250-0x0000000184058EC0
		public override int GetHashCode() => default; // 0x0000000184057BF0-0x00000001840581D0
		public void ToLow() {} // 0x0000000184771330-0x00000001847715B0
		public static unsafe UnSafeString GetUnsafeString(char* ptr, int length) => default; // 0x0000000184266B40-0x0000000184266D10
		public static UnSafeString GetUnsafeStringUTF8(Span<byte> span) => default; // 0x0000000185C28D10-0x0000000185C28DA0
		public static UnSafeString Format<T>(string formatString, T arg) => default; // 0x0000000184058EC0-0x00000001840590C0
		public static UnSafeString Format<T1, T2>(string formatString, T1 arg, T2 arg1) => default; // 0x0000000184054A70-0x0000000184054F50
		public static UnSafeString Format<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) => default; // 0x000000018C3D6400-0x000000018C3D6630
		public static UnSafeString Format<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => default; // 0x0000000185729640-0x00000001857296C0
		public static UnSafeString Format<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => default; // 0x0000000186474374-0x0000000186474394
		public static implicit operator string(UnSafeString value) => default; // 0x000000018C3D7B0C-0x000000018C3D7BBC
		public static implicit operator UnSafeString(string value) => default; // 0x000000018C3D7BBC-0x000000018C3D7C2C
		public static UnSafeString TryGetUnSafeStringFromPool(int requestStringLength, bool inScope = true /* Metadata: 0x02080DBB */) => default; // 0x0000000185F6D9F0-0x0000000185F6DA50
		private static void _RecycleString(UnSafeString uString) {} // 0x0000000185492010-0x0000000185492020
		public static void FreeCacheMemory() {} // 0x000000018C3D7A4C-0x000000018C3D7AAC
		public void Split(char separator, ref List<UnSafeString> list) {} // 0x000000018C3D7AAC-0x000000018C3D7B0C
	}
}

namespace Cysharp.Text
{
	internal static class EnumUtil<T> // TypeDefIndex: 59640
	{
		// Fields
		private static readonly Dictionary<T, string> names;
		private static readonly Dictionary<T, byte[]> utf8names;
	
		// Constructors
		static EnumUtil() {}
	
		// Methods
		public static bool TryFormatUtf16(T value, Span<char> dest, out int written, ReadOnlySpan<char> _) {
			written = default;
			return default;
		}
	}

	internal static class ExceptionUtil // TypeDefIndex: 59641
	{
		// Methods
		internal static void ThrowFormatException() {} // 0x000000018C3D6154-0x000000018C3D61B0
		internal static void ThrowFormatError() {} // 0x000000018C3D60F8-0x000000018C3D6154
	}

	internal static class FastNumberWriter // TypeDefIndex: 59642
	{
		// Methods
		public static bool TryWriteInt64(Span<char> buffer, out int charsWritten, long value) {
			charsWritten = default;
			return default;
		} // 0x0000000184B224D0-0x0000000184B22AE0
		public static bool TryWriteUInt64(Span<char> buffer, out int charsWritten, ulong value) {
			charsWritten = default;
			return default;
		} // 0x0000000184C60EC0-0x0000000184C613F0
	}

	internal static class FormatParser // TypeDefIndex: 59644
	{
		// Nested types
		public struct ParseResult // TypeDefIndex: 59643
		{
			// Fields
			public readonly int Index; // 0x00
			public readonly ReadOnlySpan<char> FormatString; // 0x08
			public readonly int LastIndex; // 0x18
			public readonly int Alignment; // 0x1C
	
			// Constructors
			public ParseResult(int index, ReadOnlySpan<char> formatString, int lastIndex, int alignment) {
				Index = default;
				FormatString = default;
				LastIndex = default;
				Alignment = default;
			} // 0x000000018C3D61B0-0x000000018C3D61C8
		}
	
		// Methods
		private static bool IsDigit(char c) => default; // 0x000000018C3D61C8-0x000000018C3D6400
		public static ParseResult Parse(string format, int i) => default; // 0x0000000185FEB060-0x0000000185FEB080
	}

	internal class NestedStringBuilderCreationException : InvalidOperationException // TypeDefIndex: 59645
	{
		// Constructors
		public NestedStringBuilderCreationException() {} // Dummy constructor
		protected internal NestedStringBuilderCreationException(string typeName, string extraMessage = "" /* Metadata: 0x02080DBE */) {} // 0x000000018C3D73E0-0x000000018C3D745C
	}

	internal struct ReadOnlyListAdaptor<T> : IReadOnlyList<T> // TypeDefIndex: 59646
	{
		// Fields
		private readonly IList<T> _list;
	
		// Properties
		public T this[int index] { get => default; }
		public int Count { get => default; }
	
		// Constructors
		public ReadOnlyListAdaptor(IList<T> list) : this() {
			_list = default;
		}
	
		// Methods
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	public struct Utf16ValueStringBuilder : IDisposable, IBufferWriter<char> // TypeDefIndex: 59651
	{
		// Fields
		private static char newLine1; // 0x00
		private static char newLine2; // 0x02
		private static bool crlf; // 0x04
		private static char[] scratchBuffer; // 0x80000000
		internal static bool scratchBufferUsed; // 0x80000008
		private char[] buffer; // 0x00
		private int index; // 0x08
		private bool disposeImmediately; // 0x0C
	
		// Properties
		public int Length { get => default; }
	
		// Nested types
		public delegate bool TryFormat<T>(T value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format); // TypeDefIndex: 59647; 0x00000000-0x00000000
	
		public static class FormatterCache<T> // TypeDefIndex: 59648
		{
			// Fields
			public static TryFormat<T> TryFormatDelegate;
	
			// Constructors
			static FormatterCache() {}
	
			// Methods
			private static bool TryFormatString(T value, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
			private static bool TryFormatUnsafeString(T value, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
			private static bool TryFormatDefault(T value, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 59649
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static TryFormat<bool> __9__52_0; // 0x08
			public static TryFormat<sbyte> __9__52_1; // 0x10
			public static TryFormat<short> __9__52_2; // 0x18
			public static TryFormat<int> __9__52_3; // 0x20
			public static TryFormat<long> __9__52_4; // 0x28
			public static TryFormat<byte> __9__52_5; // 0x30
			public static TryFormat<ushort> __9__52_6; // 0x38
			public static TryFormat<uint> __9__52_7; // 0x40
			public static TryFormat<ulong> __9__52_8; // 0x48
			public static TryFormat<float> __9__52_9; // 0x50
			public static TryFormat<double> __9__52_10; // 0x58
			public static TryFormat<TimeSpan> __9__52_11; // 0x60
			public static TryFormat<System.DateTime> __9__52_12; // 0x68
			public static TryFormat<DateTimeOffset> __9__52_13; // 0x70
			public static TryFormat<decimal> __9__52_14; // 0x78
			public static TryFormat<Guid> __9__52_15; // 0x80
			public static TryFormat<IntPtr> __9__52_16; // 0x88
			public static TryFormat<UIntPtr> __9__52_17; // 0x90
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal bool _CreateFormatter_b__52_0(bool x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
			internal bool _CreateFormatter_b__52_1(sbyte x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
			internal bool _CreateFormatter_b__52_2(short x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
			internal bool _CreateFormatter_b__52_3(int x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
			internal bool _CreateFormatter_b__52_4(long x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
			internal bool _CreateFormatter_b__52_5(byte x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
			internal bool _CreateFormatter_b__52_6(ushort x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
			internal bool _CreateFormatter_b__52_7(uint x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
			internal bool _CreateFormatter_b__52_8(ulong x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
			internal bool _CreateFormatter_b__52_9(float x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
			internal bool _CreateFormatter_b__52_10(double x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
			internal bool _CreateFormatter_b__52_11(TimeSpan x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			} // 0x000000018529E260-0x000000018529F390
			internal bool _CreateFormatter_b__52_12(System.DateTime x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			} // 0x000000018C3D8680-0x000000018C3D87AC
			internal bool _CreateFormatter_b__52_13(DateTimeOffset x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			} // 0x00000001851675B0-0x0000000185167650
			internal bool _CreateFormatter_b__52_14(decimal x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			} // 0x0000000181B7E450-0x0000000181B7E460
			internal bool _CreateFormatter_b__52_15(Guid x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			} // 0x000000018C3D8AC4-0x000000018C3D8B54
			internal bool _CreateFormatter_b__52_16(IntPtr x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			} // 0x000000018C3D8A64-0x000000018C3D8AC4
			internal bool _CreateFormatter_b__52_17(UIntPtr x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			} // 0x000000018C3D8F9C-0x000000018C3D9120
		}
	
		[Serializable]
		private sealed class __c__170<T> // TypeDefIndex: 59650
			where T : struct
		{
			// Fields
			public static readonly __c__170<T> __9;
			public static TryFormat<T?> __9__170_0;
	
			// Constructors
			static __c__170() {} // 0x000000018C3D8B54-0x000000018C3D8C10
			public __c__170() {}
	
			// Methods
			internal bool _CreateNullableFormatter_b__170_0(T? x, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			} // 0x000000018C3D8434-0x000000018C3D8598
		}
	
		// Constructors
		static Utf16ValueStringBuilder() {
			newLine1 = default;
			newLine2 = default;
			crlf = default;
			scratchBuffer = default;
			scratchBufferUsed = default;
		}
		public Utf16ValueStringBuilder(bool disposeImmediately) : this() {
			buffer = default;
			index = default;
			this.disposeImmediately = default;
		} // 0x000000018510CE40-0x000000018510CEC0
	
		// Methods
		internal void AppendJoinInternal<T>(ReadOnlySpan<char> separator, IReadOnlyList<T> values) {} // 0x000000018C3D8874-0x000000018C3D8904
		internal void AppendJoinInternal<T>(ReadOnlySpan<char> separator, ReadOnlySpan<T> values) {} // 0x000000018C3D8598-0x000000018C3D8680
		internal void AppendJoinInternal<T>(ReadOnlySpan<char> separator, IEnumerable<T> values) {} // 0x000000018C3D8904-0x000000018C3D8974
		public void AppendFormat<T1>(string format, T1 arg1) {} // 0x000000018C3D83DC-0x000000018C3D8434
		public void AppendFormat<T1, T2>(string format, T1 arg1, T2 arg2) {} // 0x000000018C3D8974-0x000000018C3D8A64
		public void AppendFormat<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) {} // 0x000000018C3D87AC-0x000000018C3D8874
		public void AppendFormat<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {}
		public void AppendFormat<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {} // 0x000000018405BF10-0x000000018405C5E0
		public void AppendFormat<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {} // 0x000000018C3D8C10-0x000000018C3D8CB8
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {} // 0x000000018C3D8CB8-0x000000018C3D8D54
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {} // 0x0000000185FCF250-0x0000000185FCF260
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {} // 0x000000018C3D8E6C-0x000000018C3D8ED0
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {} // 0x000000018C3D8ED0-0x000000018C3D8F2C
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {}
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {} // 0x000000018C3D8F2C-0x000000018C3D8F9C
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) {}
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) {} // 0x0000000184059B10-0x0000000184059FB0
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) {}
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) {}
		private static object CreateFormatter(System.Type type) => default;
		public void Append(int value) {}
		public ReadOnlySpan<char> AsSpan() => default; // 0x0000000185F6C670-0x0000000185F6C6D0
		public ArraySegment<char> AsArraySegment() => default; // 0x0000000185492010-0x0000000185492020
		public void Dispose() {} // 0x000000018C3D779C-0x000000018C3D7848
		public void Grow(int sizeHint) {} // 0x000000018C3D7848-0x000000018C3D78F4
		public void AppendLine() {} // 0x0000000184B22450-0x0000000184B224D0
		public void Append(char value) {} // 0x0000000184B223D0-0x0000000184B22450
		public void Append(char value, int repeatCount) {} // 0x000000018C3D78F4-0x000000018C3D79A0
		public void Append(string value) {} // 0x000000018C3D79A0-0x000000018C3D7A4C
		public void AppendLine(string value) {} // 0x0000000184C60E40-0x0000000184C60EC0
		public void Append(string value, int startIndex, int count) {} // 0x0000000184C60DC0-0x0000000184C60E40
		public void Append(ReadOnlySpan<char> value) {} // 0x0000000185A97F70-0x0000000185A97FC0
		public void Append<T>(T value) {} // 0x00000001840063F0-0x00000001840064B0
		public override string ToString() => default; // 0x000000018C3D74CC-0x000000018C3D7554
		public Memory<char> GetMemory(int sizeHint) => default; // 0x00000001848B5F10-0x00000001848B5FF0
		public Span<char> GetSpan(int sizeHint) => default; // 0x000000018C3D7554-0x000000018C3D75E0
		public void Advance(int count) {} // 0x000000018C3D75E0-0x000000018C3D766C
		private void ThrowArgumentException(string paramName) {} // 0x000000018C3D766C-0x000000018C3D76B0
		private static void ThrowFormatException() {} // 0x000000018C3D76B0-0x000000018C3D76FC
		private void AppendFormatInternal<T>(T arg, int width, ReadOnlySpan<char> format, string argName) {} // 0x000000018C3D76FC-0x000000018C3D779C
		private static void ThrowNestedException() {}
		private static TryFormat<T?> CreateNullableFormatter<T>()
			where T : struct => default;
		public ref char GetPinnableReference() => ref _refReturnTypeForGetPinnableReference;
		private ref char _refReturnTypeForGetPinnableReference; // Dummy field
	}

	public static class ZString // TypeDefIndex: 59652
	{
		// Fields
		private static Encoding UTF8NoBom; // 0x00
	
		// Constructors
		static ZString() {} // 0x0000000185C2C950-0x0000000185C2C9E0
	
		// Methods
		public static string Concat<T1, T2>(T1 arg1, T2 arg2) => default;
		public static string Concat<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3) => default;
		public static string Concat<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4) => default;
		public static string Concat<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => default;
		public static string Concat<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => default;
		public static string Concat<T1, T2, T3, T4, T5, T6, T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => default;
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => default;
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) => default;
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) => default;
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) => default;
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) => default;
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) => default;
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) => default;
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) => default;
		public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) => default;
		public static Utf16ValueStringBuilder CreateStringBuilder() => default; // 0x0000000184FC1130-0x0000000184FC1150
		public static string Join<T>(char separator, T[] values) => default;
		public static string Join<T>(char separator, List<T> values) => default;
		public static string Join<T>(char separator, IEnumerable<T> values) => default;
		public static string Join<T>(char separator, ICollection<T> values) => default;
		public static string Join<T>(char separator, IList<T> values) => default;
		public static string Join<T>(char separator, IReadOnlyList<T> values) => default;
		public static string Join<T>(char separator, IReadOnlyCollection<T> values) => default;
		public static string Join<T>(string separator, List<T> values) => default;
		public static string Join<T>(string separator, ICollection<T> values) => default;
		public static string Join<T>(string separator, IList<T> values) => default;
		public static string Join<T>(string separator, IReadOnlyList<T> values) => default;
		public static string Join<T>(string separator, IReadOnlyCollection<T> values) => default;
		public static string Join<T>(string separator, IEnumerable<T> values) => default;
		private static string JoinInternal<T>(ReadOnlySpan<char> separator, IList<T> values) => default;
		private static string JoinInternal<T>(ReadOnlySpan<char> separator, IReadOnlyList<T> values) => default;
		private static string JoinInternal<T>(ReadOnlySpan<char> separator, ReadOnlySpan<T> values) => default;
		private static string JoinInternal<T>(ReadOnlySpan<char> separator, IEnumerable<T> values) => default;
		public static string Format<T1>(string format, T1 arg1) => default;
		public static string Format<T1, T2>(string format, T1 arg1, T2 arg2) => default;
		public static string Format<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) => default;
		public static string Format<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => default;
		public static string Format<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => default;
		public static string Format<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => default;
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 59656
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F64470-0x0000000185F644E0
	
		// Methods
		public void __Gen_Wrap_0(object P0, char P1) {} // 0x000000018C3D6630-0x000000018C3D670C
		public void __Gen_Wrap_2(object P0, int P1) {} // 0x000000018769E90C-0x000000018769E9E8
		public void __Gen_Wrap_3(object P0, object P1) {} // 0x00000001873527E8-0x00000001873528C4
		public void __Gen_Wrap_5(object P0, Span<char> P1) {} // 0x000000018C3D70FC-0x000000018C3D7210
		public void __Gen_Wrap_6(object P0, char P1, int P2) {} // 0x000000018C3D7210-0x000000018C3D7308
		public int __Gen_Wrap_8(object P0, byte P1) => default; // 0x000000018C3D7308-0x000000018C3D73E0
		public void __Gen_Wrap_9(object P0) {} // 0x000000018646FFC0-0x0000000186470080
		public void __Gen_Wrap_10() {} // 0x0000000187678160-0x00000001876781FC
		public IDisposable __Gen_Wrap_11() => default; // 0x000000018C3D670C-0x000000018C3D67D8
		public UnSafeString __Gen_Wrap_12(int P0, bool P1) => default; // 0x000000018C3D67D8-0x000000018C3D68E4
		public UnSafeString __Gen_Wrap_13(int P0) => default; // 0x000000018C3D68E4-0x000000018C3D69D0
		public int __Gen_Wrap_14(object P0) => default; // 0x00000001873408C8-0x0000000187340998
		public string __Gen_Wrap_15(object P0) => default; // 0x000000018C3D69D0-0x000000018C3D6AC0
		public void __Gen_Wrap_16(object P0, Span<byte> P1) {} // 0x000000018C3D6AC0-0x000000018C3D6BC0
		public UnSafeString __Gen_Wrap_23(Span<byte> P0) => default; // 0x000000018C3D6BC0-0x000000018C3D6CC0
		public UnSafeString __Gen_Wrap_24(object P0) => default; // 0x000000018C3D6CC0-0x000000018C3D6DB0
		public void __Gen_Wrap_31(object P0, char P1, ref List<UnSafeString> P2) {} // 0x000000018C3D6DB0-0x000000018C3D6EF4
		public UnSafeString.UnSafeStringHandle __Gen_Wrap_32(int P0) => default; // 0x000000018C3D6EF4-0x000000018C3D6FE0
		public void __Gen_Wrap_33(ref UnSafeString.UnSafeStringHandle P0) {} // 0x000000018C3D6FE0-0x000000018C3D70FC
	}

	public class WrappersManagerImpl // TypeDefIndex: 59657
	{
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018C3D9120-0x000000018C3D9184
		public static bool IsPatched(int id) => default; // 0x00000001840562E0-0x0000000184056480
	}
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 59627
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Numerics
{
	public static class BitOperations // TypeDefIndex: 59639
	{
		// Properties
		private static ReadOnlySpan<byte> TrailingZeroCountDeBruijn { get; } // 0x000000018441BD30-0x000000018441BDB0 
		private static ReadOnlySpan<byte> Log2DeBruijn { get; } // 0x000000018C3D609C-0x000000018C3D60F8 
	
		// Methods
		public static int LeadingZeroCount(uint value) => default; // 0x0000000186936AC8-0x0000000186936AEC
		private static int Log2SoftwareFallback(uint value) => default; // 0x000000018C3D5F8C-0x000000018C3D600C
		public static int TrailingZeroCount(uint value) => default; // 0x000000018C3D600C-0x000000018C3D607C
		public static int TrailingZeroCount(ulong value) => default; // 0x000000018C3D607C-0x000000018C3D609C
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class NullableAttribute : Attribute // TypeDefIndex: 59628
	{
		// Fields
		public readonly byte[] NullableFlags; // 0x10
	
		// Constructors
		public NullableAttribute() {} // Dummy constructor
		public NullableAttribute(byte param_0007d5c2) {} // 0x000000018C3D745C-0x000000018C3D74CC
		public NullableAttribute(byte[] param_0007d5c3) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 59629
	{
		// Fields
		public readonly byte Flag; // 0x10
	
		// Constructors
		public NullableContextAttribute() {} // Dummy constructor
		public NullableContextAttribute(byte param_0007d5c4) {} // 0x000000018184FBD0-0x000000018184FBE0
	}
}
