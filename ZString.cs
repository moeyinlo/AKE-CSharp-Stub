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
using Unity.Mathematics;

// Image 69: ZString.dll - Assembly: ZString, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58601-58632
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond
{
	public struct MonoObject_64 // TypeDefIndex: 58605
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x08
	}

	public struct MonoObject_32 // TypeDefIndex: 58606
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x04
	}

	public struct MonoString_64 // TypeDefIndex: 58607
	{
		// Fields
		public MonoObject_64 obj; // 0x00
		public int length; // 0x10
		public char firstChar; // 0x14
	}

	public struct MonoString_32 // TypeDefIndex: 58608
	{
		// Fields
		public MonoObject_32 obj; // 0x00
		public int length; // 0x08
		public char firstChar; // 0x0C
	}

	[DefaultMember("Item")]
	[Nullable(0)]
	[NullableContext(1)]
	public class UnSafeString // TypeDefIndex: 58613
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
		public int Length { get => default; private set {} } // 0x0000000183D8A240-0x0000000183D8A250 0x0000000183D8A250-0x0000000183D8A260
	
		// Nested types
		[NullableContext(0)]
		public class HgStringBlock : IDisposable // TypeDefIndex: 58609
		{
			// Fields
			[Nullable(1)]
			private readonly Stack<UnSafeString> m_stack; // 0x10
	
			// Constructors
			public HgStringBlock() {} // Dummy constructor
			internal HgStringBlock(int capacity) {} // 0x0000000183A24E30-0x0000000183A24EC0
	
			// Methods
			[NullableContext(1)]
			internal void Push(UnSafeString str) {} // 0x00000001823AB0E0-0x00000001823AB2E0
			void IDisposable.Dispose() {} // 0x00000001823A6C90-0x00000001823A7170
		}
	
		[NullableContext(0)]
		public class HgThreadStringBlock : IDisposable // TypeDefIndex: 58610
		{
			// Fields
			[Nullable(1)]
			private readonly Stack<UnSafeString> m_stack; // 0x10
	
			// Constructors
			public HgThreadStringBlock() {} // Dummy constructor
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018A2BE318-0x000000018A2BE548
		}
	
		[Nullable(0)]
		public struct UnSafeStringHandle : IDisposable // TypeDefIndex: 58611
		{
			// Fields
			private GCHandle m_stringHandler; // 0x00
	
			// Constructors
			private UnSafeStringHandle(UnSafeString unSafeString) {
				m_stringHandler = default;
			} // 0x0000000184272C70-0x0000000184272C90
	
			// Methods
			public static UnSafeStringHandle CreateHandle(int count = 64 /* Metadata: 0x01FDB4D8 */) => default; // 0x0000000182BDCD80-0x0000000182BDCE00
			public void Dispose() {} // 0x000000018A2BFA24-0x000000018A2BFAD4
			public UnSafeString Get() => default; // 0x000000018A2BFAD4-0x000000018A2BFB44
		}
	
		// Constructors
		public UnSafeString() {} // Dummy constructor
		static UnSafeString() {} // 0x0000000183802010-0x0000000183802560
		private UnSafeString(int count = 256 /* Metadata: 0x01FDB4D1 */) {} // 0x00000001826808F0-0x0000000182680990
	
		// Methods
		[IDTag(0)]
		public void Append(char value) {} // 0x00000001823A8410-0x00000001823A8500
		[NullableContext(0)]
		public unsafe void Append(char* value, int count) {} // 0x00000001823A67B0-0x00000001823A6870
		[IDTag(2)]
		public void Append(int value) {} // 0x0000000182CB51F0-0x0000000182CB5340
		[IDTag(3)]
		public void Append(string value) {} // 0x00000001823A8F70-0x00000001823A90D0
		[IDTag(5)]
		[NullableContext(0)]
		public void Append(Span<char> value) {} // 0x000000018267F210-0x000000018267F290
		public void Replace(char newChar, int Index) {} // 0x00000001826F1E30-0x00000001826F1E90
		[IDTag(7)]
		public void Append(UnSafeString value) {} // 0x00000001828DA400-0x00000001828DA560
		[NullableContext(0)]
		public unsafe void Append(byte* value, int count) {} // 0x000000018A2BFB44-0x000000018A2BFDAC
		private int _GetUTF8ByteCnt(byte bt) => default; // 0x000000018A2C00D0-0x000000018A2C0168
		public static IDisposable Scope() => default; // 0x00000001823A68D0-0x00000001823A6C90
		public static UnSafeString Concat<T1, T2>(T1 arg1, T2 arg2) => default;
		public static UnSafeString Concat<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3) => default;
		public static UnSafeString Concat<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4) => default;
		public static UnSafeString Create(int count = 256 /* Metadata: 0x01FDB4D3 */) => default; // 0x00000001823AB380-0x00000001823AB490
		public static UnSafeString CreateRaw(int count = 256 /* Metadata: 0x01FDB4D5 */) => default; // 0x0000000182680870-0x00000001826808F0
		public void Dispose() {} // 0x00000001830CE230-0x00000001830CE280
		public int GetStringBufferSize() => default; // 0x00000001823AA3F0-0x00000001823AA470
		public void Clear() {} // 0x00000001823AB2E0-0x00000001823AB380
		public string CloneString() => default; // 0x000000018268C6B0-0x000000018268C700
		[IDTag(1)]
		[NullableContext(0)]
		public void CloneToBytes(Span<byte> bytes) {} // 0x000000018A2BFDAC-0x000000018A2BFEDC
		public override string ToString() => default; // 0x00000001823A9D90-0x00000001823A9E10
		private void _Resize(int size) {} // 0x000000018A2C0168-0x000000018A2C0250
		public override int GetHashCode() => default; // 0x000000018A2BFEDC-0x000000018A2BFF84
		public void ToLow() {} // 0x00000001828DBFB0-0x00000001828DC230
		[NullableContext(0)]
		public static unsafe UnSafeString GetUnsafeString(char* ptr, int length) => default; // 0x000000018A2C0054-0x000000018A2C00D0
		[IDTag(0)]
		[NullableContext(0)]
		public static UnSafeString GetUnsafeStringUTF8(Span<byte> span) => default; // 0x000000018A2BFF84-0x000000018A2C0054
		public static UnSafeString Format<T>(string formatString, T arg) => default;
		public static UnSafeString Format<T1, T2>(string formatString, T1 arg, T2 arg1) => default;
		public static UnSafeString Format<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) => default;
		public static UnSafeString Format<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => default;
		public static UnSafeString Format<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => default;
		[IDTag(0)]
		public static implicit operator string(UnSafeString value) => default; // 0x00000001824BCCB0-0x00000001824BCD40
		[IDTag(1)]
		public static implicit operator UnSafeString(string value) => default; // 0x000000018A2C0250-0x000000018A2C02F4
		public static UnSafeString TryGetUnSafeStringFromPool(int requestStringLength, bool inScope = true /* Metadata: 0x01FDB4D7 */) => default; // 0x00000001823AA470-0x00000001823AB0E0
		private static void _RecycleString(UnSafeString uString) {} // 0x00000001823A9E10-0x00000001823AA3F0
		public static void FreeCacheMemory() {} // 0x00000001830CDFB0-0x00000001830CE230
		public void Split(char separator, ref List<UnSafeString> list) {} // 0x0000000182815240-0x0000000182815410
	}
}

namespace Cysharp.Text
{
	internal static class EnumUtil<T> // TypeDefIndex: 58615
	{
		// Fields
		[Nullable(1)]
		private static readonly Dictionary<T, string> names;
		[Nullable(1)]
		private static readonly Dictionary<T, byte[]> utf8names;
	
		// Constructors
		static EnumUtil() {}
	
		// Methods
		public static bool TryFormatUtf16([Nullable(1)] T value, Span<char> dest, out int written, ReadOnlySpan<char> _) {
			written = default;
			return default;
		}
	}

	internal static class ExceptionUtil // TypeDefIndex: 58616
	{
		// Methods
		internal static void ThrowFormatException() {} // 0x000000018A2BE06C-0x000000018A2BE0C8
		internal static void ThrowFormatError() {} // 0x000000018A2BE010-0x000000018A2BE06C
	}

	internal static class FastNumberWriter // TypeDefIndex: 58617
	{
		// Methods
		public static bool TryWriteInt64(Span<char> buffer, out int charsWritten, long value) {
			charsWritten = default;
			return default;
		} // 0x0000000182D74B70-0x0000000182D75180
		public static bool TryWriteUInt64(Span<char> buffer, out int charsWritten, ulong value) {
			charsWritten = default;
			return default;
		} // 0x0000000182E57EF0-0x0000000182E58420
	}

	internal static class FormatParser // TypeDefIndex: 58619
	{
		// Nested types
		[IsByRefLike]
		[IsReadOnly]
		[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		public struct ParseResult // TypeDefIndex: 58618
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
			} // 0x0000000183D8A220-0x0000000183D8A240
		}
	
		// Methods
		private static bool IsDigit(char c) => default; // 0x000000018A2BE0C8-0x000000018A2BE0E0
		[NullableContext(1)]
		public static ParseResult Parse(string format, int i) => default; // 0x000000018A2BE0E0-0x000000018A2BE318
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class NestedStringBuilderCreationException : InvalidOperationException // TypeDefIndex: 58620
	{
		// Constructors
		public NestedStringBuilderCreationException() {} // Dummy constructor
		protected internal NestedStringBuilderCreationException(string typeName, string extraMessage = "" /* Metadata: 0x01FDB4DA */) {} // 0x000000018A2BF2F8-0x000000018A2BF374
	}

	[IsReadOnly]
	[Nullable(0)]
	[NullableContext(1)]
	internal struct ReadOnlyListAdaptor<T> : IReadOnlyList<T> // TypeDefIndex: 58621
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

	[Nullable(0)]
	[NullableContext(1)]
	public struct Utf16ValueStringBuilder : IDisposable, IBufferWriter<char> // TypeDefIndex: 58626
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
		public int Length { get => default; } // 0x0000000183D516F0-0x0000000183D51700 
	
		// Nested types
		[NullableContext(0)]
		public delegate bool TryFormat<T>([Nullable(1)] T value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format); // TypeDefIndex: 58622; 0x00000000-0x00000000
	
		[NullableContext(0)]
		public static class FormatterCache<T> // TypeDefIndex: 58623
		{
			// Fields
			[Nullable(1)]
			public static TryFormat<T> TryFormatDelegate;
	
			// Constructors
			static FormatterCache() {}
	
			// Methods
			private static bool TryFormatString([Nullable(1)] T value, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
			private static bool TryFormatUnsafeString([Nullable(1)] T value, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
			private static bool TryFormatDefault([Nullable(1)] T value, Span<char> dest, out int written, ReadOnlySpan<char> format) {
				written = default;
				return default;
			}
		}
	
		// Constructors
		static Utf16ValueStringBuilder() {
			newLine1 = default;
			newLine2 = default;
			crlf = default;
			scratchBuffer = default;
			scratchBufferUsed = default;
		} // 0x00000001831EDB90-0x00000001831EDC30
		public Utf16ValueStringBuilder(bool disposeImmediately) : this() {
			buffer = default;
			index = default;
			this.disposeImmediately = default;
		} // 0x000000018A2C0EB4-0x000000018A2C1038
	
		// Methods
		[NullableContext(0)]
		internal void AppendJoinInternal<T>(ReadOnlySpan<char> separator, [Nullable(1)] IReadOnlyList<T> values) {}
		[NullableContext(0)]
		internal void AppendJoinInternal<T>(ReadOnlySpan<char> separator, [Nullable(new byte[2] {0, 1 })] ReadOnlySpan<T> values) {}
		[NullableContext(0)]
		internal void AppendJoinInternal<T>(ReadOnlySpan<char> separator, [Nullable(1)] IEnumerable<T> values) {}
		public void AppendFormat<T1>(string format, T1 arg1) {}
		public void AppendFormat<T1, T2>(string format, T1 arg1, T2 arg2) {}
		public void AppendFormat<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) {}
		public void AppendFormat<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {}
		public void AppendFormat<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {}
		public void AppendFormat<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {}
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {}
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {}
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {}
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {}
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {}
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {}
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) {}
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) {}
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) {}
		public void AppendFormat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) {}
		private static object CreateFormatter(System.Type type) => default; // 0x000000018332A040-0x000000018332B170
		public void Append(int value) {} // 0x000000018A2C0598-0x000000018A2C06C4
		[NullableContext(0)]
		public ReadOnlySpan<char> AsSpan() => default; // 0x000000018A2C09DC-0x000000018A2C0A6C
		[NullableContext(0)]
		public ArraySegment<char> AsArraySegment() => default; // 0x000000018A2C097C-0x000000018A2C09DC
		public void Dispose() {} // 0x000000018A2C0A6C-0x000000018A2C0B28
		public void Grow(int sizeHint) {} // 0x000000018A2C0C6C-0x000000018A2C0D84
		public void AppendLine() {} // 0x000000018A2C034C-0x000000018A2C04B0
		public void Append(char value) {} // 0x000000018A2C078C-0x000000018A2C081C
		public void Append(char value, int repeatCount) {} // 0x000000018A2C04B0-0x000000018A2C0598
		public void Append(string value) {} // 0x000000018A2C081C-0x000000018A2C088C
		public void AppendLine(string value) {} // 0x000000018A2C02F4-0x000000018A2C034C
		public void Append(string value, int startIndex, int count) {} // 0x000000018A2C088C-0x000000018A2C097C
		[NullableContext(0)]
		public void Append(ReadOnlySpan<char> value) {} // 0x000000018A2C06C4-0x000000018A2C078C
		public void Append<T>(T value) {}
		public override string ToString() => default; // 0x00000001823AE130-0x00000001823AE800
		[NullableContext(0)]
		public Memory<char> GetMemory(int sizeHint) => default; // 0x000000018A2C0B28-0x000000018A2C0BD0
		[NullableContext(0)]
		public Span<char> GetSpan(int sizeHint) => default; // 0x000000018A2C0BD0-0x000000018A2C0C6C
		public void Advance(int count) {} // 0x0000000183D6E610-0x0000000183D6E620
		private void ThrowArgumentException(string paramName) {} // 0x000000018A2C0D84-0x000000018A2C0DE8
		private static void ThrowFormatException() {} // 0x000000018A2C0DE8-0x000000018A2C0E44
		private void AppendFormatInternal<T>(T arg, int width, [Nullable(0)] ReadOnlySpan<char> format, string argName) {}
		private static void ThrowNestedException() {} // 0x000000018A2C0E44-0x000000018A2C0EB4
		[NullableContext(0)]
		private static TryFormat<T?> CreateNullableFormatter<T>()
			where T : struct => default;
		public ref char GetPinnableReference() => ref _refReturnTypeForGetPinnableReference; // 0x00000001823ABD30-0x00000001823AC1D0
		private ref char _refReturnTypeForGetPinnableReference; // Dummy field
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class ZString // TypeDefIndex: 58627
	{
		// Fields
		private static Encoding UTF8NoBom; // 0x00
	
		// Constructors
		static ZString() {} // 0x0000000183A28DB0-0x0000000183A28E40
	
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
		public static Utf16ValueStringBuilder CreateStringBuilder() => default; // 0x000000018284E090-0x000000018284E0B0
		public static string Join<T>(char separator, params T[] values) => default;
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
		private static string JoinInternal<T>([Nullable(0)] ReadOnlySpan<char> separator, IList<T> values) => default;
		private static string JoinInternal<T>([Nullable(0)] ReadOnlySpan<char> separator, IReadOnlyList<T> values) => default;
		[NullableContext(0)]
		private static string JoinInternal<T>(ReadOnlySpan<char> separator, [Nullable(new byte[2] {0, 1 })] ReadOnlySpan<T> values) => default;
		private static string JoinInternal<T>([Nullable(0)] ReadOnlySpan<char> separator, IEnumerable<T> values) => default;
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
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 58631
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05B80-0x0000000183D05BF0
	
		// Methods
		public void __Gen_Wrap_0(object P0, char P1) {} // 0x000000018A2BE548-0x000000018A2BE624
		public void __Gen_Wrap_2(object P0, int P1) {} // 0x000000018549D548-0x000000018549D624
		public void __Gen_Wrap_3(object P0, object P1) {} // 0x0000000185163BA0-0x0000000185163C7C
		public void __Gen_Wrap_5(object P0, Span<char> P1) {} // 0x000000018A2BF014-0x000000018A2BF128
		public void __Gen_Wrap_6(object P0, char P1, int P2) {} // 0x000000018A2BF128-0x000000018A2BF220
		public int __Gen_Wrap_8(object P0, byte P1) => default; // 0x000000018A2BF220-0x000000018A2BF2F8
		public void __Gen_Wrap_9(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public void __Gen_Wrap_10() {} // 0x00000001850F3444-0x00000001850F34E0
		public IDisposable __Gen_Wrap_11() => default; // 0x000000018A2BE624-0x000000018A2BE6F0
		public UnSafeString __Gen_Wrap_12(int P0, bool P1) => default; // 0x000000018A2BE6F0-0x000000018A2BE7FC
		public UnSafeString __Gen_Wrap_13(int P0) => default; // 0x000000018A2BE7FC-0x000000018A2BE8E8
		public int __Gen_Wrap_14(object P0) => default; // 0x00000001850EF614-0x00000001850EF6E4
		public string __Gen_Wrap_15(object P0) => default; // 0x000000018A2BE8E8-0x000000018A2BE9D8
		public void __Gen_Wrap_16(object P0, Span<byte> P1) {} // 0x000000018A2BE9D8-0x000000018A2BEAD8
		public UnSafeString __Gen_Wrap_23(Span<byte> P0) => default; // 0x000000018A2BEAD8-0x000000018A2BEBD8
		public UnSafeString __Gen_Wrap_24(object P0) => default; // 0x000000018A2BEBD8-0x000000018A2BECC8
		public void __Gen_Wrap_31(object P0, char P1, ref List<UnSafeString> P2) {} // 0x000000018A2BECC8-0x000000018A2BEE0C
		public UnSafeString.UnSafeStringHandle __Gen_Wrap_32(int P0) => default; // 0x000000018A2BEE0C-0x000000018A2BEEF8
		public void __Gen_Wrap_33(ref UnSafeString.UnSafeStringHandle P0) {} // 0x000000018A2BEEF8-0x000000018A2BF014
	}

	public class WrappersManagerImpl // TypeDefIndex: 58632
	{
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018A2C1038-0x000000018A2C109C
		public static bool IsPatched(int id) => default; // 0x00000001823A8500-0x00000001823A86A0
	}
}

namespace System.Numerics
{
	public static class BitOperations // TypeDefIndex: 58614
	{
		// Properties
		private static ReadOnlySpan<byte> TrailingZeroCountDeBruijn { get; } // 0x00000001823DE440-0x00000001823DE4C0 
		private static ReadOnlySpan<byte> Log2DeBruijn { get; } // 0x000000018A2BDFB4-0x000000018A2BE010 
	
		// Methods
		public static int LeadingZeroCount(uint value) => default; // 0x000000018473A550-0x000000018473A574
		private static int Log2SoftwareFallback(uint value) => default; // 0x000000018A2BDEA4-0x000000018A2BDF24
		public static int TrailingZeroCount(uint value) => default; // 0x000000018A2BDF24-0x000000018A2BDF94
		public static int TrailingZeroCount(ulong value) => default; // 0x000000018A2BDF94-0x000000018A2BDFB4
	}
}
