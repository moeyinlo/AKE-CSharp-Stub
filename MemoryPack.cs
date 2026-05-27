/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Buffers;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using MemoryPack;
using MemoryPack.Internal;
using UnityEngine;

// Image 45: MemoryPack.dll - Assembly: MemoryPack, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56219-56383
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public class MemoryPackRegister<T> // TypeDefIndex: 56224
{
	// Fields
	public static Func<bool> s_initFunc;

	// Constructors
	public MemoryPackRegister() {}
}

namespace MemoryPack
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackableAttribute : Attribute // TypeDefIndex: 56226
	{
		// Properties
		public GenerateType GenerateType { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public SerializeLayout SerializeLayout { get; } // 0x0000000183D50CC0-0x0000000183D50CD0 
	
		// Constructors
		public MemoryPackableAttribute() {} // Dummy constructor
		public MemoryPackableAttribute(GenerateType generateType = GenerateType.Object /* Metadata: 0x01FD7FDF */) {} // 0x000000018910B1AC-0x000000018910B1C0
		public MemoryPackableAttribute(SerializeLayout serializeLayout) {} // 0x0000000183D6E630-0x0000000183D6E640
		public MemoryPackableAttribute(GenerateType generateType, SerializeLayout serializeLayout) {} // 0x0000000183D50CB0-0x0000000183D50CC0
	}

	public enum GenerateType // TypeDefIndex: 56227
	{
		Object = 0,
		VersionTolerant = 1,
		CircularReference = 2,
		Collection = 3,
		NoGenerate = 4
	}

	public enum SerializeLayout // TypeDefIndex: 56228
	{
		Sequential = 0,
		Explicit = 1
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	[Nullable(0)]
	[NullableContext(1)]
	public sealed class MemoryPackUnionAttribute : Attribute // TypeDefIndex: 56229
	{
		// Properties
		public ushort Tag { get; } // 0x0000000183D61390-0x0000000183D613A0 
		public System.Type Type { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public MemoryPackUnionAttribute() {} // Dummy constructor
		public MemoryPackUnionAttribute(ushort tag, System.Type type) {} // 0x0000000189109BA8-0x0000000189109BBC
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	[Nullable(0)]
	[NullableContext(1)]
	public sealed class MemoryPackUnionFormatterAttribute : Attribute // TypeDefIndex: 56230
	{
		// Properties
		public System.Type Type { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public MemoryPackUnionFormatterAttribute() {} // Dummy constructor
		public MemoryPackUnionFormatterAttribute(System.Type type) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackAllowSerializeAttribute : Attribute // TypeDefIndex: 56231
	{
		// Constructors
		public MemoryPackAllowSerializeAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackOrderAttribute : Attribute // TypeDefIndex: 56232
	{
		// Properties
		public int Order { get; } // 0x0000000183D4E340-0x0000000183D4E350 
	
		// Constructors
		public MemoryPackOrderAttribute() {} // Dummy constructor
		public MemoryPackOrderAttribute(int order) {} // 0x00000001810410F0-0x0000000181041100
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackIgnoreAttribute : Attribute // TypeDefIndex: 56233
	{
		// Constructors
		public MemoryPackIgnoreAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackIncludeAttribute : Attribute // TypeDefIndex: 56234
	{
		// Constructors
		public MemoryPackIncludeAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackConstructorAttribute : Attribute // TypeDefIndex: 56235
	{
		// Constructors
		public MemoryPackConstructorAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackOnSerializingAttribute : Attribute // TypeDefIndex: 56236
	{
		// Constructors
		public MemoryPackOnSerializingAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackOnSerializedAttribute : Attribute // TypeDefIndex: 56237
	{
		// Constructors
		public MemoryPackOnSerializedAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackOnDeserializingAttribute : Attribute // TypeDefIndex: 56238
	{
		// Constructors
		public MemoryPackOnDeserializingAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackOnDeserializedAttribute : Attribute // TypeDefIndex: 56239
	{
		// Constructors
		public MemoryPackOnDeserializedAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public sealed class GenerateTypeScriptAttribute : Attribute // TypeDefIndex: 56240
	{
		// Constructors
		public GenerateTypeScriptAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class MemoryPackFormatterProvider // TypeDefIndex: 56243
	{
		// Fields
		private static readonly Dictionary<System.Type, System.Type> ArrayLikeFormatters; // 0x00
		private static readonly Dictionary<System.Type, System.Type> CollectionFormatters; // 0x08
		private static readonly Dictionary<System.Type, System.Type> InterfaceCollectionFormatters; // 0x10
		private static readonly ConcurrentDictionary<System.Type, IMemoryPackFormatter> formatters; // 0x18
		private static readonly ConcurrentDictionary<System.Type, System.Type> genericFormatterFactory; // 0x20
		private static readonly ConcurrentDictionary<System.Type, System.Type> genericCollectionFormatterFactory; // 0x28
		private static readonly Dictionary<System.Type, System.Type> KnownGenericTypeFormatters; // 0x30
		private static object lockObj; // 0x38
	
		// Nested types
		[NullableContext(0)]
		private static class Check<T> // TypeDefIndex: 56241
		{
			// Fields
			public static bool registered;
		}
	
		[Nullable(0)]
		public static class Cache<T> // TypeDefIndex: 56242
		{
			// Fields
			[Nullable(new byte[2] {2, 1 })]
			private static IMemoryPackFormatter<T> _formatter;
	
			// Properties
			public static IMemoryPackFormatter<T> formatter { get; set; }
		}
	
		// Constructors
		static MemoryPackFormatterProvider() {} // 0x0000000182935BF0-0x00000001829369B0
	
		// Methods
		private static void RegisterInitialFormatters() {} // 0x0000000182934B10-0x00000001829350B0
		[NullableContext(2)]
		public static bool IsRegistered<T>() => default;
		public static void Register<T>(IMemoryPackFormatter<T> formatter) {}
		public static void RegisterGenericType(System.Type genericType, System.Type genericFormatterType) {} // 0x0000000189105CD0-0x0000000189105DE8
		[NullableContext(0)]
		public static void RegisterCollection<TCollection, TElement>()
			where TCollection : ICollection<TElement>, new() {}
		public static void RegisterCollection(System.Type genericCollectionType) {} // 0x0000000189105A78-0x0000000189105BA4
		[NullableContext(0)]
		public static void RegisterSet<TSet, TElement>()
			where TSet : ISet<TElement>, new() {}
		public static void RegisterSet(System.Type genericSetType) {} // 0x0000000189105DE8-0x0000000189105F14
		[NullableContext(0)]
		public static void RegisterDictionary<TDictionary, TKey, TValue>()
			where TDictionary : IDictionary<TKey, TValue>, new() {}
		public static void RegisterDictionary(System.Type genericDictionaryType) {} // 0x0000000189105BA4-0x0000000189105CD0
		public static IMemoryPackFormatter<T> GetFormatter<T>() => default;
		internal static IMemoryPackFormatter GetFormatter(System.Type type) => default; // 0x0000000189105874-0x0000000189105A78
		private static bool TryInvokeRegisterFormatter(System.Type type) => default; // 0x00000001891060E4-0x0000000189106248
		public static void ForceRegister<T>(IMemoryPackFormatter<T> formatter) {}
		internal static object CreateGenericFormatter(System.Type type, bool typeIsReferenceOrContainsReferences) => default; // 0x00000001891054A8-0x0000000189105874
		private static System.Type TryCreateGenericFormatterType(System.Type type, IDictionary<System.Type, System.Type> knownTypes) => default; // 0x0000000189106034-0x00000001891060E4
		private static System.Type TryCreateGenericCollectionFormatterType(System.Type type) => default; // 0x0000000189105F14-0x0000000189106034
		internal static void RegisterWellKnownTypesFormatters() {} // 0x000000018340D190-0x000000018340F400
		[NullableContext(0)]
		private static void UnityRegister<T>()
			where T : struct {}
	}

	public interface IMemoryPackFormatterRegister // TypeDefIndex: 56244
	{
	}

	public interface IMemoryPackable<T> : IMemoryPackFormatterRegister // TypeDefIndex: 56245
	{
	}

	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public interface IMemoryPackFormatter // TypeDefIndex: 56246
	{
		// Methods
		[MemoryPack.Internal.Preserve]
		void Deserialize(ref MemoryPackReader reader, ref object value);
	}

	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public interface IMemoryPackFormatter<T> // TypeDefIndex: 56247
	{
		// Methods
		[MemoryPack.Internal.Preserve]
		void Deserialize(ref MemoryPackReader reader, ref ref T value);
	}

	[Nullable(0)]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public abstract class MemoryPackFormatter<T> : IMemoryPackFormatter<T>, IMemoryPackFormatter // TypeDefIndex: 56248
	{
		// Constructors
		protected MemoryPackFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public abstract void Deserialize(ref MemoryPackReader reader, ref ref T value);
		[MemoryPack.Internal.Preserve]
		void IMemoryPackFormatter.Deserialize(ref MemoryPackReader reader, ref object value) {}
	}

	public static class MemoryPackCode // TypeDefIndex: 56249
	{
		// Fields
		public const int NullCollection = -1; // Metadata: 0x01FD7FE7
		public const byte WideTag = 250; // Metadata: 0x01FD7FE8
		public const byte ReferenceId = 250; // Metadata: 0x01FD7FE9
		public const byte Reserved1 = 250; // Metadata: 0x01FD7FEA
		public const byte Reserved2 = 251; // Metadata: 0x01FD7FEB
		public const byte Reserved3 = 252; // Metadata: 0x01FD7FEC
		public const byte Reserved4 = 253; // Metadata: 0x01FD7FED
		public const byte Reserved5 = 254; // Metadata: 0x01FD7FEE
		public const byte NullObject = 255; // Metadata: 0x01FD7FEF
	
		// Properties
		internal static ReadOnlySpan<byte> NullCollectionData { get; } // 0x00000001891053F0-0x000000018910544C 
		internal static ReadOnlySpan<byte> ZeroCollectionData { get; } // 0x000000018910544C-0x00000001891054A8 
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal sealed class ErrorMemoryPackFormatter : IMemoryPackFormatter // TypeDefIndex: 56250
	{
		// Fields
		private readonly System.Type type; // 0x10
		[Nullable(2)]
		private readonly string message; // 0x18
	
		// Constructors
		public ErrorMemoryPackFormatter() {} // Dummy constructor
		public ErrorMemoryPackFormatter(System.Type type) {} // 0x0000000182E1A410-0x0000000182E1A440
		public ErrorMemoryPackFormatter(System.Type type, string message) {} // 0x0000000182676770-0x00000001826767A0
	
		// Methods
		[NullableContext(2)]
		public void Serialize(ref MemoryPackWriter writer, ref object value) {} // 0x0000000189105000-0x000000018910500C
		[NullableContext(2)]
		public void Deserialize(ref MemoryPackReader reader, ref object value) {} // 0x0000000189105000-0x000000018910500C
		[DoesNotReturn]
		private void Throw() {} // 0x000000018910500C-0x000000018910502C
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	internal sealed class ErrorMemoryPackFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 56251
	{
		// Fields
		private readonly Exception exception;
		private readonly string message;
	
		// Constructors
		public ErrorMemoryPackFormatter() {}
		[NullableContext(1)]
		public ErrorMemoryPackFormatter(Exception exception) {}
		[NullableContext(1)]
		public ErrorMemoryPackFormatter(string message) {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value) {}
		[DoesNotReturn]
		private void Throw() {}
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct MemoryPackReader // TypeDefIndex: 56252
	{
		// Fields
		private ReadOnlySequence<byte> bufferSource; // 0x00
		private readonly long totalLength; // 0x18
		private ReadOnlySpan<byte> bufferReference; // 0x20
		private int bufferLength; // 0x30
		[Nullable(2)]
		private byte[] rentBuffer; // 0x38
		private int advancedCount; // 0x40
		private int consumed; // 0x44
		[Nullable(1)]
		private readonly MemoryPackReaderOptionalState optionalState; // 0x48
	
		// Properties
		public int Consumed { get => default; } // 0x0000000183D4EE80-0x0000000183D4EE90 
		public long Remaining { get => default; } // 0x0000000183D6E620-0x0000000183D6E630 
		[Nullable(1)]
		public MemoryPackReaderOptionalState OptionalState { [NullableContext(1)] get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		[Nullable(1)]
		public MemoryPackSerializerOptions Options { [NullableContext(1)] get => default; } // 0x000000018910836C-0x0000000189108388 
	
		// Constructors
		public MemoryPackReader([IsReadOnly] in ReadOnlySequence<byte> sequence, [Nullable(1)] MemoryPackReaderOptionalState optionalState) : this() {
			bufferSource = default;
			totalLength = default;
			bufferReference = default;
			bufferLength = default;
			rentBuffer = default;
			advancedCount = default;
			consumed = default;
			this.optionalState = default;
		} // 0x0000000189108254-0x000000018910836C
		public MemoryPackReader(ReadOnlySpan<byte> buffer, [Nullable(1)] MemoryPackReaderOptionalState optionalState) : this() {
			bufferSource = default;
			totalLength = default;
			bufferReference = default;
			bufferLength = default;
			rentBuffer = default;
			advancedCount = default;
			consumed = default;
			this.optionalState = default;
		} // 0x0000000182DD2460-0x0000000182DD2510
	
		// Methods
		public ref byte GetSpanReference(int sizeHint) => ref _refReturnTypeForGetSpanReference; // 0x0000000189106C80-0x0000000189106CE8
		private ref byte _refReturnTypeForGetSpanReference; // Dummy field
		private ref byte GetNextSpan(int sizeHint) => ref _refReturnTypeForGetNextSpan; // 0x00000001891066F0-0x0000000189106A6C
		private ref byte _refReturnTypeForGetNextSpan; // Dummy field
		public void Advance(int count) {} // 0x00000001891065B0-0x0000000189106638
		private bool TryAdvanceSequence(int count) => default; // 0x0000000189107F18-0x0000000189108034
		public void GetRemainingSource(out ReadOnlySpan<byte> singleSource, out ReadOnlySequence<byte> remainingSource) {
			singleSource = default;
			remainingSource = default;
		} // 0x0000000189106A6C-0x0000000189106C80
		public void Dispose() {} // 0x0000000189106638-0x00000001891066A8
		[NullableContext(1)]
		public IMemoryPackFormatter GetFormatter(System.Type type) => default; // 0x00000001891066A8-0x00000001891066F0
		[NullableContext(1)]
		public IMemoryPackFormatter<T> GetFormatter<T>() => default;
		public bool TryReadObjectHeader(out byte memberCount) {
			memberCount = default;
			return default;
		} // 0x000000018910817C-0x00000001891081BC
		public bool TryReadUnionHeader(out ushort tag) {
			tag = default;
			return default;
		} // 0x00000001891081BC-0x0000000189108254
		public bool TryReadCollectionHeader(out int length) {
			length = default;
			return default;
		} // 0x0000000189108120-0x000000018910817C
		public bool PeekIsNull() => default; // 0x0000000189106CE8-0x0000000189106D04
		public bool TryPeekObjectHeader(out byte memberCount) {
			memberCount = default;
			return default;
		} // 0x0000000189108084-0x00000001891080A8
		public bool TryPeekUnionHeader(out ushort tag) {
			tag = default;
			return default;
		} // 0x00000001891080A8-0x00000001891080FC
		public bool TryPeekUshort(out ushort tag) {
			tag = default;
			return default;
		} // 0x00000001891080FC-0x0000000189108120
		public bool TryPeekCollectionHeader(out int length) {
			length = default;
			return default;
		} // 0x0000000189108034-0x0000000189108084
		public bool DangerousTryReadCollectionHeader(out int length) {
			length = default;
			return default;
		} // 0x0000000189101CFC-0x0000000189101D68
		[NullableContext(2)]
		public string ReadString() => default; // 0x0000000189106D04-0x0000000189106D68
		[NullableContext(1)]
		private string ReadUtf16(int length) => default; // 0x0000000189106D68-0x0000000189106E38
		[NullableContext(1)]
		public string ReadUtf8(int utf8Length) => default; // 0x0000000182331BA0-0x0000000182331E50
		public T1 ReadUnmanaged<T1>()
			where T1 : struct => default;
		public void ReadPackable<T>([Nullable(2)] ref ref T value)
			where T : IMemoryPackable<T> {}
		public T ReadPackable<T>()
			where T : IMemoryPackable<T> => default;
		[NullableContext(2)]
		public void ReadValue<T>(ref ref T value) {}
		[NullableContext(2)]
		public T ReadValue<T>() => default;
		[NullableContext(1)]
		public void ReadValue(System.Type type, [Nullable(2)] ref object value) {} // 0x0000000189106E38-0x0000000189106EA8
		[NullableContext(1)]
		public object ReadValue(System.Type type) => default; // 0x0000000189106EA8-0x0000000189106F1C
		[NullableContext(1)]
		public void ReadValueWithFormatter<TFormatter, T>(TFormatter formatter, [Nullable(2)] ref ref T value)
			where TFormatter : IMemoryPackFormatter<T> {}
		[NullableContext(1)]
		public T ReadValueWithFormatter<TFormatter, T>(TFormatter formatter)
			where TFormatter : IMemoryPackFormatter<T> => default;
		[NullableContext(2)]
		public T[] ReadArray<T>() => default;
		[NullableContext(2)]
		public void ReadArray<T>(ref ref T[] value) {}
		[NullableContext(2)]
		public void ReadSpan<T>([Nullable(new byte[2] {0, 2 })] ref Span<T> value) {}
		public T[] ReadPackableArray<T>()
			where T : IMemoryPackable<T> => default;
		public void ReadPackableArray<T>([Nullable(2)] ref ref T[] value)
			where T : IMemoryPackable<T> {}
		public void ReadPackableSpan<T>([Nullable(new byte[2] {0, 2 })] ref Span<T> value)
			where T : IMemoryPackable<T> {}
		public T[] ReadUnmanagedArray<T>()
			where T : struct => default;
		public void ReadUnmanagedArray<T>([Nullable(new byte[2] {2, 0 })] ref ref T[] value)
			where T : struct {}
		public void ReadUnmanagedSpan<T>(ref Span<T> value)
			where T : struct {}
		[NullableContext(2)]
		public T[] DangerousReadUnmanagedArray<T>() => default;
		[NullableContext(2)]
		public void DangerousReadUnmanagedArray<T>([Nullable(new byte[2] {2, 1 })] ref ref T[] value) {}
		[NullableContext(2)]
		public void DangerousReadUnmanagedSpan<T>([Nullable(new byte[2] {0, 1 })] ref Span<T> value) {}
		[NullableContext(2)]
		public void ReadSpanWithoutReadLengthHeader<T>(int length, [Nullable(new byte[2] {0, 2 })] ref Span<T> value) {}
		public void ReadPackableSpanWithoutReadLengthHeader<T>(int length, [Nullable(new byte[2] {0, 2 })] ref Span<T> value)
			where T : IMemoryPackable<T> {}
		public void DangerousReadUnmanagedSpanView<T>(out bool isNull, out ReadOnlySpan<byte> view) {
			isNull = default;
			view = default;
		}
		public void ReadUnmanaged<T1>(out ref T1 value1)
			where T1 : struct {
			value1 = default;
		}
		public void ReadUnmanaged<T1, T2>(out ref T1 value1, out ref T2 value2)
			where T1 : struct
			where T2 : struct {
			value1 = default;
			value2 = default;
		}
		public void ReadUnmanaged<T1, T2, T3>(out ref T1 value1, out ref T2 value2, out ref T3 value3)
			where T1 : struct
			where T2 : struct
			where T3 : struct {
			value1 = default;
			value2 = default;
			value3 = default;
		}
		public void ReadUnmanaged<T1, T2, T3, T4>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
		}
		public void ReadUnmanaged<T1, T2, T3, T4, T5>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
		}
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
		}
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6, T7>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
		}
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
		}
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
			value9 = default;
		}
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
			value9 = default;
			value10 = default;
		}
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct
			where T11 : struct {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
			value9 = default;
			value10 = default;
			value11 = default;
		}
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct
			where T11 : struct
			where T12 : struct {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
			value9 = default;
			value10 = default;
			value11 = default;
			value12 = default;
		}
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12, out ref T13 value13)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct
			where T11 : struct
			where T12 : struct
			where T13 : struct {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
			value9 = default;
			value10 = default;
			value11 = default;
			value12 = default;
			value13 = default;
		}
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12, out ref T13 value13, out ref T14 value14)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct
			where T11 : struct
			where T12 : struct
			where T13 : struct
			where T14 : struct {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
			value9 = default;
			value10 = default;
			value11 = default;
			value12 = default;
			value13 = default;
			value14 = default;
		}
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12, out ref T13 value13, out ref T14 value14, out ref T15 value15)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct
			where T11 : struct
			where T12 : struct
			where T13 : struct
			where T14 : struct
			where T15 : struct {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
			value9 = default;
			value10 = default;
			value11 = default;
			value12 = default;
			value13 = default;
			value14 = default;
			value15 = default;
		}
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1>(out ref T1 value1) {
			value1 = default;
		}
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2>(out ref T1 value1, out ref T2 value2) {
			value1 = default;
			value2 = default;
		}
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3>(out ref T1 value1, out ref T2 value2, out ref T3 value3) {
			value1 = default;
			value2 = default;
			value3 = default;
		}
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
		}
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
		}
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
		}
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
		}
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
		}
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
			value9 = default;
		}
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
			value9 = default;
			value10 = default;
		}
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
			value9 = default;
			value10 = default;
			value11 = default;
		}
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
			value9 = default;
			value10 = default;
			value11 = default;
			value12 = default;
		}
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12, out ref T13 value13) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
			value9 = default;
			value10 = default;
			value11 = default;
			value12 = default;
			value13 = default;
		}
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12, out ref T13 value13, out ref T14 value14) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
			value9 = default;
			value10 = default;
			value11 = default;
			value12 = default;
			value13 = default;
			value14 = default;
		}
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12, out ref T13 value13, out ref T14 value14, out ref T15 value15) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
			value8 = default;
			value9 = default;
			value10 = default;
			value11 = default;
			value12 = default;
			value13 = default;
			value14 = default;
			value15 = default;
		}
		public byte ReadVarIntByte() => default; // 0x0000000189106F1C-0x0000000189107128
		public sbyte ReadVarIntSByte() => default; // 0x0000000189107718-0x000000018910798C
		public ushort ReadVarIntUInt16() => default; // 0x000000018910798C-0x0000000189107B94
		public short ReadVarIntInt16() => default; // 0x0000000189107128-0x000000018910735C
		public uint ReadVarIntUInt32() => default; // 0x0000000189107B94-0x0000000189107D68
		public int ReadVarIntInt32() => default; // 0x000000018910735C-0x0000000189107544
		public ulong ReadVarIntUInt64() => default; // 0x0000000189107D68-0x0000000189107F18
		public long ReadVarIntInt64() => default; // 0x0000000189107544-0x0000000189107718
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class MemoryPackReaderOptionalStatePool // TypeDefIndex: 56253
	{
		// Fields
		private static readonly ConcurrentQueue<MemoryPackReaderOptionalState> queue; // 0x00
	
		// Constructors
		static MemoryPackReaderOptionalStatePool() {} // 0x0000000189106398-0x0000000189106424
	
		// Methods
		public static MemoryPackReaderOptionalState Rent([Nullable(2)] MemoryPackSerializerOptions options) => default; // 0x0000000189106248-0x000000018910631C
		internal static void Return(MemoryPackReaderOptionalState state) {} // 0x000000018910631C-0x0000000189106398
	}

	[Nullable(0)]
	[NullableContext(1)]
	public sealed class MemoryPackReaderOptionalState : IDisposable // TypeDefIndex: 56254
	{
		// Fields
		private readonly Dictionary<uint, object> refToObject; // 0x10
	
		// Properties
		public MemoryPackSerializerOptions Options { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		internal MemoryPackReaderOptionalState() {} // 0x0000000182DD1F80-0x0000000182DD2010
	
		// Methods
		[NullableContext(2)]
		internal void Init(MemoryPackSerializerOptions options) {} // 0x0000000182DD2320-0x0000000182DD23A0
		public object GetObjectReference(uint id) => default; // 0x00000001891064C4-0x0000000189106564
		public void AddObjectReference(uint id, object value) {} // 0x0000000189106424-0x00000001891064C4
		public void Reset() {} // 0x0000000182DD23A0-0x0000000182DD2460
		void IDisposable.Dispose() {} // 0x0000000189106564-0x00000001891065B0
	}

	internal static class VarIntCodes // TypeDefIndex: 56255
	{
		// Fields
		public const byte MaxSingleValue = 127; // Metadata: 0x01FD7FF0
		public const sbyte MinSingleValue = 136; // Metadata: 0x01FD7FF1
		public const sbyte Byte = 135; // Metadata: 0x01FD7FF2
		public const sbyte SByte = 134; // Metadata: 0x01FD7FF3
		public const sbyte UInt16 = 133; // Metadata: 0x01FD7FF4
		public const sbyte Int16 = 132; // Metadata: 0x01FD7FF5
		public const sbyte UInt32 = 131; // Metadata: 0x01FD7FF6
		public const sbyte Int32 = 130; // Metadata: 0x01FD7FF7
		public const sbyte UInt64 = 129; // Metadata: 0x01FD7FF8
		public const sbyte Int64 = 128; // Metadata: 0x01FD7FF9
	}

	[IsByRefLike]
	[Nullable(0)]
	[NullableContext(1)]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct MemoryPackWriter // TypeDefIndex: 56256
	{
		// Fields
		private const int DepthLimit = 1000; // Metadata: 0x01FD7FFB
		private IBufferWriter<byte> bufferWriter; // 0x00
		[Nullable(0)]
		private Span<byte> bufferReference; // 0x08
		private int bufferLength; // 0x18
		private int advancedCount; // 0x1C
		private int depth; // 0x20
		private int writtenCount; // 0x24
		private readonly bool serializeStringAsUtf8; // 0x28
		private readonly MemoryPackWriterOptionalState optionalState; // 0x30
	
		// Properties
		public int WrittenCount { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public int BufferLength { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public MemoryPackWriterOptionalState OptionalState { get => default; } // 0x0000000181003830-0x0000000181003840 
		public MemoryPackSerializerOptions Options { get => default; } // 0x000000018910B190-0x000000018910B1AC 
	
		// Constructors
		public MemoryPackWriter(ref IBufferWriter<byte> writer, MemoryPackWriterOptionalState optionalState) : this() {
			bufferWriter = default;
			bufferReference = default;
			bufferLength = default;
			advancedCount = default;
			depth = default;
			writtenCount = default;
			serializeStringAsUtf8 = default;
			this.optionalState = default;
		} // 0x000000018910B14C-0x000000018910B190
		public MemoryPackWriter(ref IBufferWriter<byte> writer, byte[] firstBufferOfWriter, MemoryPackWriterOptionalState optionalState) : this() {
			bufferWriter = default;
			bufferReference = default;
			bufferLength = default;
			advancedCount = default;
			depth = default;
			writtenCount = default;
			serializeStringAsUtf8 = default;
			this.optionalState = default;
		} // 0x000000018910B004-0x000000018910B0B4
		public MemoryPackWriter(ref IBufferWriter<byte> writer, [Nullable(0)] Span<byte> firstBufferOfWriter, MemoryPackWriterOptionalState optionalState) : this() {
			bufferWriter = default;
			bufferReference = default;
			bufferLength = default;
			advancedCount = default;
			depth = default;
			writtenCount = default;
			serializeStringAsUtf8 = default;
			this.optionalState = default;
		} // 0x000000018910B0B4-0x000000018910B14C
	
		// Methods
		public void WriteVarInt(byte x) {} // 0x000000018910AE60-0x000000018910AEDC
		public void WriteVarInt(sbyte x) {} // 0x000000018910AEDC-0x000000018910AF58
		public void WriteVarInt(ushort x) {} // 0x000000018910AAAC-0x000000018910AB2C
		public void WriteVarInt(short x) {} // 0x000000018910A9DC-0x000000018910AAAC
		public void WriteVarInt(uint x) {} // 0x000000018910AF58-0x000000018910B004
		public void WriteVarInt(int x) {} // 0x000000018910AC10-0x000000018910AD0C
		public void WriteVarInt(ulong x) {} // 0x000000018910AB2C-0x000000018910AC10
		public void WriteVarInt(long x) {} // 0x000000018910AD0C-0x000000018910AE60
		public ref byte GetSpanReference(int sizeHint) => ref _refReturnTypeForGetSpanReference; // 0x000000018910A264-0x000000018910A2C8
		private ref byte _refReturnTypeForGetSpanReference; // Dummy field
		private void RequestNewBuffer(int sizeHint) {} // 0x000000018910A380-0x000000018910A414
		public void Advance(int count) {} // 0x000000018910A144-0x000000018910A1B8
		public void Flush() {} // 0x000000018910A1B8-0x000000018910A21C
		public IMemoryPackFormatter GetFormatter(System.Type type) => default; // 0x000000018910A21C-0x000000018910A264
		public IMemoryPackFormatter<T> GetFormatter<T>() => default;
		[NullableContext(2)]
		public int GetStringWriteLength(string value) => default; // 0x000000018910A2C8-0x000000018910A380
		[NullableContext(0)]
		public int GetUnmanageArrayWriteLength<T>([Nullable(new byte[2] {2, 0 })] T[] value)
			where T : struct => default;
		public void WriteObjectHeader(byte memberCount) {} // 0x000000018910A470-0x000000018910A4B4
		public void WriteNullObjectHeader() {} // 0x000000018910A448-0x000000018910A470
		public void WriteObjectReferenceId(uint referenceId) {} // 0x000000018910A4B4-0x000000018910A4F4
		public void WriteUnionHeader(ushort tag) {} // 0x000000018910A514-0x000000018910A574
		public void WriteNullUnionHeader() {} // 0x000000018910A448-0x000000018910A470
		public void WriteCollectionHeader(int length) {} // 0x000000018910A414-0x000000018910A448
		public void WriteNullCollectionHeader() {} // 0x0000000189101D68-0x00000001891021AC
		[NullableContext(2)]
		public void WriteString(string value) {} // 0x000000018910A4F4-0x000000018910A514
		[NullableContext(2)]
		public void WriteUtf16(string value) {} // 0x000000018910A6B0-0x000000018910A804
		[NullableContext(0)]
		public void WriteUtf16(ReadOnlySpan<char> value) {} // 0x000000018910A574-0x000000018910A6B0
		[NullableContext(2)]
		public void WriteUtf8(string value) {} // 0x000000018910A804-0x000000018910A930
		[NullableContext(0)]
		public void WriteUtf8(ReadOnlySpan<byte> utf8Value, int utf16Length = -1 /* Metadata: 0x01FD7FFA */) {} // 0x000000018910A930-0x000000018910A9DC
		[NullableContext(0)]
		public void WriteUnmanaged<T1>([IsReadOnly] in ref T1 value1)
			where T1 : struct {}
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1>(byte propertyCount, [IsReadOnly] in ref T1 value1)
			where T1 : struct {}
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2)
			where T1 : struct
			where T2 : struct {}
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2)
			where T1 : struct
			where T2 : struct {}
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3)
			where T1 : struct
			where T2 : struct
			where T3 : struct {}
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3)
			where T1 : struct
			where T2 : struct
			where T3 : struct {}
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct {}
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct {}
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4, T5>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct {}
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct {}
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct {}
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct {}
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct {}
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct {}
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct {}
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct {}
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct {}
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct {}
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct {}
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct {}
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct
			where T11 : struct {}
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct
			where T11 : struct {}
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct
			where T11 : struct
			where T12 : struct {}
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct
			where T11 : struct
			where T12 : struct {}
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct
			where T11 : struct
			where T12 : struct
			where T13 : struct {}
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct
			where T11 : struct
			where T12 : struct
			where T13 : struct {}
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13, [IsReadOnly] in ref T14 value14)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct
			where T11 : struct
			where T12 : struct
			where T13 : struct
			where T14 : struct {}
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13, [IsReadOnly] in ref T14 value14)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct
			where T11 : struct
			where T12 : struct
			where T13 : struct
			where T14 : struct {}
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13, [IsReadOnly] in ref T14 value14, [IsReadOnly] in ref T15 value15)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct
			where T11 : struct
			where T12 : struct
			where T13 : struct
			where T14 : struct
			where T15 : struct {}
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13, [IsReadOnly] in ref T14 value14, [IsReadOnly] in ref T15 value15)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct
			where T10 : struct
			where T11 : struct
			where T12 : struct
			where T13 : struct
			where T14 : struct
			where T15 : struct {}
		public void DangerousWriteUnmanaged<T1>([IsReadOnly] in ref T1 value1) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1>(byte propertyCount, [IsReadOnly] in ref T1 value1) {}
		public void DangerousWriteUnmanaged<T1, T2>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2) {}
		public void DangerousWriteUnmanaged<T1, T2, T3>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13, [IsReadOnly] in ref T14 value14) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13, [IsReadOnly] in ref T14 value14) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13, [IsReadOnly] in ref T14 value14, [IsReadOnly] in ref T15 value15) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13, [IsReadOnly] in ref T14 value14, [IsReadOnly] in ref T15 value15) {}
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class MemoryPackSerializationException : Exception // TypeDefIndex: 56257
	{
		// Constructors
		public MemoryPackSerializationException() {} // Dummy constructor
		public MemoryPackSerializationException(string message) {} // 0x0000000182944430-0x00000001829444A0
		public MemoryPackSerializationException(string message, Exception innerException) {} // 0x0000000189108E48-0x0000000189108EA8
	
		// Methods
		[DoesNotReturn]
		public static void ThrowMessage(string message) {} // 0x0000000189108A50-0x0000000189108AA8
		[DoesNotReturn]
		public static void ThrowInvalidPropertyCount(byte expected, byte actual) {} // 0x000000018910883C-0x00000001891088F0
		[DoesNotReturn]
		public static void ThrowInvalidPropertyCount(System.Type type, byte expected, byte actual) {} // 0x00000001822AD600-0x00000001822AD730
		[DoesNotReturn]
		public static void ThrowInvalidCollection() {} // 0x0000000189108784-0x00000001891087E0
		[DoesNotReturn]
		public static void ThrowInvalidRange(int expected, int actual) {} // 0x00000001891088F0-0x00000001891089A4
		[DoesNotReturn]
		public static void ThrowInvalidAdvance() {} // 0x0000000189108728-0x0000000189108784
		[DoesNotReturn]
		public static void ThrowSequenceReachedEnd() {} // 0x0000000189108D5C-0x0000000189108DB8
		[DoesNotReturn]
		public static void ThrowWriteInvalidMemberCount(byte memberCount) {} // 0x0000000189108DB8-0x0000000189108E48
		[DoesNotReturn]
		public static void ThrowInsufficientBufferUnless(int length) {} // 0x0000000189108698-0x0000000189108728
		[DoesNotReturn]
		public static void ThrowNotRegisteredInProvider(System.Type type) {} // 0x0000000189108BD4-0x0000000189108C58
		[DoesNotReturn]
		public static void ThrowRegisterInProviderFailed(System.Type type, Exception innerException) {} // 0x0000000189108CCC-0x0000000189108D5C
		[DoesNotReturn]
		public static void ThrowNotFoundInUnionType(System.Type actualType, System.Type baseType) {} // 0x0000000189108AA8-0x0000000189108BD4
		[DoesNotReturn]
		public static void ThrowInvalidTag(ushort tag, System.Type baseType) {} // 0x00000001891089A4-0x0000000189108A50
		[DoesNotReturn]
		public static void ThrowReachedDepthLimit(System.Type type) {} // 0x0000000189108C58-0x0000000189108CCC
		[DoesNotReturn]
		public static void ThrowInvalidConcurrrentCollectionOperation() {} // 0x00000001891087E0-0x000000018910883C
		[DoesNotReturn]
		public static void ThrowDeserializeObjectIsNull(string target) {} // 0x0000000189108584-0x0000000189108608
		[DoesNotReturn]
		public static void ThrowFailedEncoding(OperationStatus status) {} // 0x0000000189108608-0x0000000189108698
		[DoesNotReturn]
		public static void ThrowCompressionFailed(OperationStatus status) {} // 0x0000000189108440-0x00000001891084D0
		[DoesNotReturn]
		public static void ThrowCompressionFailed() {} // 0x00000001891083E4-0x0000000189108440
		[DoesNotReturn]
		public static void ThrowAlreadyDecompressed() {} // 0x0000000189108388-0x00000001891083E4
		[DoesNotReturn]
		public static void ThrowDecompressionSizeLimitExceeded(int limit, int size) {} // 0x00000001891084D0-0x0000000189108584
	}

	[Nullable(0)]
	[NullableContext(2)]
	public static class MemoryPackSerializer // TypeDefIndex: 56261
	{
		// Fields
		[ThreadStatic]
		private static MemoryPackReaderOptionalState threadStaticReaderOptionalState; // 0x80000000
		[ThreadStatic]
		private static SerializerWriterThreadStaticState threadStaticState; // 0x80000008
		[ThreadStatic]
		private static MemoryPackWriterOptionalState threadStaticWriterOptionalState; // 0x80000010
	
		// Nested types
		[Nullable(0)]
		[NullableContext(1)]
		private sealed class SerializerWriterThreadStaticState // TypeDefIndex: 56258
		{
			// Fields
			public ReusableLinkedArrayBufferWriter BufferWriter; // 0x10
			public MemoryPackWriterOptionalState OptionalState; // 0x18
	
			// Constructors
			public SerializerWriterThreadStaticState() {} // 0x000000018910CC90-0x000000018910CD34
	
			// Methods
			[NullableContext(2)]
			public void Init(MemoryPackSerializerOptions options) {} // 0x000000018910CC3C-0x000000018910CC5C
			public void Reset() {} // 0x000000018910CC5C-0x000000018910CC90
		}
	
		// Methods
		public static T Deserialize<T>([Nullable(0)] ReadOnlySpan<byte> buffer, MemoryPackSerializerOptions options = null) => default;
		public static int Deserialize<T>([Nullable(0)] ReadOnlySpan<byte> buffer, ref ref T value, MemoryPackSerializerOptions options = null) => default;
		public static T Deserialize<T>([Nullable(0)] [IsReadOnly] in ReadOnlySequence<byte> buffer, MemoryPackSerializerOptions options = null) => default;
		public static int Deserialize<T>([IsReadOnly] [Nullable(0)] in ReadOnlySequence<byte> buffer, ref ref T value, MemoryPackSerializerOptions options = null) => default;
		public static int Deserialize([IsReadOnly] [Nullable(0)] in ReadOnlySequence<byte> buffer, ref object value, [Nullable(1)] System.Type type, MemoryPackSerializerOptions options = null) => default; // 0x00000001891094F4-0x000000018910971C
		public static async ValueTask<T> DeserializeAsync<T>([Nullable(1)] Stream stream, MemoryPackSerializerOptions options = null, CancellationToken cancellationToken = default) => default;
		public static object Deserialize([Nullable(1)] System.Type type, [Nullable(0)] ReadOnlySpan<byte> buffer, MemoryPackSerializerOptions options = null) => default; // 0x00000001891094C0-0x00000001891094F4
		public static int Deserialize([Nullable(1)] System.Type type, [Nullable(0)] ReadOnlySpan<byte> buffer, ref object value, MemoryPackSerializerOptions options = null) => default; // 0x0000000189109998-0x0000000189109BA8
		public static object Deserialize([Nullable(1)] System.Type type, [IsReadOnly] [Nullable(0)] in ReadOnlySequence<byte> buffer, MemoryPackSerializerOptions options = null) => default; // 0x000000018910971C-0x0000000189109744
		public static int Deserialize([Nullable(1)] System.Type type, [IsReadOnly] [Nullable(0)] in ReadOnlySequence<byte> buffer, ref object value, MemoryPackSerializerOptions options = null) => default; // 0x0000000189109744-0x0000000189109998
		[NullableContext(1)]
		public static async ValueTask<object> DeserializeAsync(System.Type type, Stream stream, [Nullable(2)] MemoryPackSerializerOptions options = null, CancellationToken cancellationToken = default) => default; // 0x0000000189109398-0x00000001891094C0
	}

	[Nullable(0)]
	[NullableContext(2)]
	public class MemoryPackSerializerOptions : IEquatable<MemoryPackSerializerOptions> // TypeDefIndex: 56262
	{
		// Fields
		[Nullable(1)]
		public static readonly MemoryPackSerializerOptions Default; // 0x00
		[Nullable(1)]
		public static readonly MemoryPackSerializerOptions Utf8; // 0x08
		[Nullable(1)]
		public static readonly MemoryPackSerializerOptions Utf16; // 0x10
	
		// Properties
		[Nullable(1)]
		protected virtual System.Type EqualityContract { [NullableContext(1)] get => default; } // 0x00000001891092DC-0x000000018910932C 
		public StringEncoding StringEncoding { get; set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
		public IServiceProvider ServiceProvider { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		protected MemoryPackSerializerOptions([Nullable(1)] MemoryPackSerializerOptions original) {} // 0x00000001839C0D10-0x00000001839C0D40
		public MemoryPackSerializerOptions() {} // 0x000000018350B670-0x000000018350B680
		static MemoryPackSerializerOptions() {} // 0x00000001839C0BA0-0x00000001839C0CB0
	
		// Methods
		[NullableContext(0)]
		public override string ToString() => default; // 0x00000001891091EC-0x00000001891092DC
		[NullableContext(1)]
		protected virtual bool PrintMembers(StringBuilder builder) => default; // 0x00000001891090DC-0x00000001891091EC
		public static bool operator !=(MemoryPackSerializerOptions r1, MemoryPackSerializerOptions r2) => default; // 0x0000000189109344-0x0000000189109398
		public static bool operator ==(MemoryPackSerializerOptions r1, MemoryPackSerializerOptions r2) => default; // 0x000000018910932C-0x0000000189109344
		public override int GetHashCode() => default; // 0x0000000189108FE4-0x00000001891090DC
		public override bool Equals(object obj) => default; // 0x0000000189108EA8-0x0000000189108EFC
		public virtual bool Equals(MemoryPackSerializerOptions other) => default; // 0x0000000189108EFC-0x0000000189108FE4
		[NullableContext(1)]
		public virtual MemoryPackSerializerOptions _Clone__() => default; // 0x00000001839C0CB0-0x00000001839C0D10
	}

	public enum StringEncoding : byte // TypeDefIndex: 56263
	{
		Utf16 = 0,
		Utf8 = 1
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class MemoryPackWriterOptionalStatePool // TypeDefIndex: 56264
	{
		// Fields
		private static readonly ConcurrentQueue<MemoryPackWriterOptionalState> queue; // 0x00
	
		// Constructors
		static MemoryPackWriterOptionalStatePool() {} // 0x0000000189109D0C-0x0000000189109D98
	
		// Methods
		public static MemoryPackWriterOptionalState Rent([Nullable(2)] MemoryPackSerializerOptions options) => default; // 0x0000000189109BBC-0x0000000189109C90
		internal static void Return(MemoryPackWriterOptionalState state) {} // 0x0000000189109C90-0x0000000189109D0C
	}

	[Nullable(0)]
	[NullableContext(1)]
	public sealed class MemoryPackWriterOptionalState : IDisposable // TypeDefIndex: 56266
	{
		// Fields
		internal static readonly MemoryPackWriterOptionalState NullState; // 0x00
		private uint nextId; // 0x10
		private readonly Dictionary<object, uint> objectToRef; // 0x18
	
		// Properties
		public MemoryPackSerializerOptions Options { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Nested types
		[Nullable(0)]
		private sealed class ReferenceEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 56265
		{
			// Properties
			public static ReferenceEqualityComparer Instance { get; } // 0x000000018910B378-0x000000018910B3C8 
	
			// Constructors
			private ReferenceEqualityComparer() {} // 0x000000018350B670-0x000000018350B680
			static ReferenceEqualityComparer() {} // 0x000000018910B314-0x000000018910B378
	
			// Methods
			[NullableContext(2)]
			public new bool Equals(object x, object y) => default; // 0x0000000186DDEAAC-0x0000000186DDEAB4
			public int GetHashCode(object obj) => default; // 0x0000000183D6E640-0x0000000183D6E650
		}
	
		// Constructors
		internal MemoryPackWriterOptionalState() {} // 0x0000000189109FF4-0x000000018910A0DC
		private MemoryPackWriterOptionalState(bool _) {} // 0x000000018910A0DC-0x000000018910A144
		static MemoryPackWriterOptionalState() {} // 0x0000000189109F80-0x0000000189109FF4
	
		// Methods
		[NullableContext(2)]
		internal void Init(MemoryPackSerializerOptions options) {} // 0x0000000189109E6C-0x0000000189109EDC
		public void Reset() {} // 0x0000000189109EDC-0x0000000189109F34
		[NullableContext(0)]
		public ValueTuple<bool, uint> GetOrAddReference([Nullable(1)] object value) => default; // 0x0000000189109D98-0x0000000189109E6C
		void IDisposable.Dispose() {} // 0x0000000189109F34-0x0000000189109F80
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	internal sealed class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve> // TypeDefIndex: 56267
	{
		// Constructors
		public AnimationCurveFormatter() {} // 0x0000000182935110-0x0000000182935140
	
		// Methods
		private void SerializeKeyFrame(Keyframe keyframe, ref MemoryPackWriter writer) {} // 0x00000001891022D4-0x00000001891023A0
		private void DeserializeKeyFrame(ref MemoryPackReader reader, out Keyframe keyframe) {
			keyframe = default;
		} // 0x000000018291ED00-0x000000018291EE20
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref AnimationCurve value) {} // 0x000000018291E620-0x000000018291EB80
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	internal sealed class GradientFormatter : MemoryPackFormatter<Gradient> // TypeDefIndex: 56268
	{
		// Constructors
		public GradientFormatter() {} // 0x00000001829350E0-0x0000000182935110
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Gradient value) {} // 0x00000001891051B0-0x000000018910530C
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	internal sealed class RectOffsetFormatter : MemoryPackFormatter<RectOffset> // TypeDefIndex: 56269
	{
		// Constructors
		public RectOffsetFormatter() {} // 0x00000001829350B0-0x00000001829350E0
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref RectOffset value) {} // 0x000000018910B1C0-0x000000018910B314
	}
}

namespace MemoryPack.Compression
{
	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class BitPackFormatter : MemoryPackFormatter<bool[]> // TypeDefIndex: 56376
	{
		// Fields
		public static readonly BitPackFormatter Default; // 0x00
	
		// Constructors
		public BitPackFormatter() {} // 0x00000001891027E0-0x0000000189102808
		static BitPackFormatter() {} // 0x0000000189102770-0x00000001891027E0
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref bool[] value) {} // 0x00000001891025B0-0x0000000189102734
		public bool Get(int data, int index) => default; // 0x0000000189102734-0x000000018910274C
		public void Set(ref int data, int index, bool value) {} // 0x000000018910274C-0x0000000189102770
	}

	public class BrotliCompressor : IBufferWriter<byte>, IDisposable // TypeDefIndex: 56378
	{
		// Fields
		[Nullable(2)]
		private ReusableLinkedArrayBufferWriter bufferWriter; // 0x10
		private readonly int quality; // 0x18
		private readonly int window; // 0x1C
	
		// Constructors
		public BrotliCompressor() {} // Dummy constructor
		public BrotliCompressor(CompressionLevel compressionLevel) {} // 0x0000000189103958-0x0000000189103984
		public BrotliCompressor(CompressionLevel compressionLevel, int window) {} // 0x00000001891038B4-0x00000001891038EC
		public BrotliCompressor(int quality = 1 /* Metadata: 0x01FD8019 */, int window = 22 /* Metadata: 0x01FD801A */) {} // 0x00000001891038EC-0x0000000189103958
	
		// Methods
		void IBufferWriter<byte>.Advance(int count) {} // 0x0000000189103238-0x0000000189103280
		Memory<byte> IBufferWriter<byte>.GetMemory(int sizeHint) => default; // 0x0000000189103280-0x00000001891032BC
		Span<byte> IBufferWriter<byte>.GetSpan(int sizeHint) => default; // 0x00000001891032BC-0x0000000189103318
		[NullableContext(1)]
		public byte[] ToArray() => default; // 0x0000000189103374-0x00000001891038B4
		[NullableContext(1)]
		public void CopyTo([IsReadOnly] in IBufferWriter<byte> destBufferWriter) {} // 0x0000000189102C30-0x0000000189102F04
		[NullableContext(1)]
		public async ValueTask CopyToAsync(Stream stream, int bufferSize = 65535 /* Metadata: 0x01FD801B */, CancellationToken cancellationToken = default) => default; // 0x0000000189102B3C-0x0000000189102C30
		public void CopyTo(ref MemoryPackWriter memoryPackWriter) {} // 0x0000000189102F04-0x00000001891031CC
		private static int CompressCore(ref BrotliEncoder encoder, ReadOnlySpan<byte> source, [Nullable(1)] ref IBufferWriter<byte> destBufferWriter, int? initialLength, bool isFinalBlock) => default; // 0x0000000189102808-0x0000000189102988
		private static int CompressCore(ref BrotliEncoder encoder, ReadOnlySpan<byte> source, ref MemoryPackWriter destBufferWriter, int? initialLength, bool isFinalBlock) => default; // 0x0000000189102988-0x0000000189102B3C
		public void Dispose() {} // 0x00000001891031CC-0x0000000189103238
		private void ThrowIfDisposed() {} // 0x0000000189103318-0x0000000189103374
	}

	internal static class BrotliUtils // TypeDefIndex: 56379
	{
		// Fields
		public const int WindowBits_Min = 10; // Metadata: 0x01FD801F
		public const int WindowBits_Default = 22; // Metadata: 0x01FD8020
		public const int WindowBits_Max = 24; // Metadata: 0x01FD8021
		public const int Quality_Min = 0; // Metadata: 0x01FD8022
		public const int Quality_Default = 4; // Metadata: 0x01FD8023
		public const int Quality_Max = 11; // Metadata: 0x01FD8024
		public const int MaxInputSize = 2147483132; // Metadata: 0x01FD8025
	
		// Methods
		internal static int GetQualityFromCompressionLevel(CompressionLevel compressionLevel) => default; // 0x0000000189104AB8-0x0000000189104B30
		internal static int BrotliEncoderMaxCompressedSize(int input_size) => default; // 0x0000000189104A98-0x0000000189104AB8
	}

	public struct BrotliDecompressor : IDisposable // TypeDefIndex: 56380
	{
		// Fields
		[Nullable(2)]
		private ReusableReadOnlySequenceBuilder sequenceBuilder; // 0x00
	
		// Methods
		public ReadOnlySequence<byte> Decompress(ReadOnlySpan<byte> compressedSpan) => default; // 0x0000000189104004-0x000000018910404C
		public ReadOnlySequence<byte> Decompress(ReadOnlySpan<byte> compressedSpan, out int consumed) {
			consumed = default;
			return default;
		} // 0x0000000189103E94-0x0000000189104004
		public ReadOnlySequence<byte> Decompress(ReadOnlySequence<byte> compressedSequence) => default; // 0x000000018910404C-0x00000001891040A0
		public ReadOnlySequence<byte> Decompress(ReadOnlySequence<byte> compressedSequence, out int consumed) {
			consumed = default;
			return default;
		} // 0x0000000189103BF0-0x0000000189103E94
		private void DecompressCore(ref OperationStatus status, ref BrotliDecoder decoder, ReadOnlySpan<byte> source, out int consumed) {
			consumed = default;
		} // 0x0000000189103984-0x0000000189103BF0
		public void Dispose() {} // 0x00000001891040A0-0x0000000189104100
		private int GetDoubleCapacity(int length) => default; // 0x0000000189104100-0x000000018910414C
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class BrotliFormatter : MemoryPackFormatter<byte[]> // TypeDefIndex: 56381
	{
		// Fields
		internal const int DefaultDecompssionSizeLimit = 134217728; // Metadata: 0x01FD802A
		public static readonly BrotliFormatter Default; // 0x00
		private readonly CompressionLevel compressionLevel; // 0x10
		private readonly int window; // 0x14
		private readonly int decompressionSizeLimit; // 0x18
	
		// Constructors
		public BrotliFormatter() {} // 0x0000000189104418-0x000000018910442C
		public BrotliFormatter(CompressionLevel compressionLevel) {} // 0x0000000189104488-0x0000000189104498
		public BrotliFormatter(CompressionLevel compressionLevel, int window) {} // 0x00000001891043F8-0x0000000189104418
		public BrotliFormatter(CompressionLevel compressionLevel, int window, int decompressionSizeLimit) {} // 0x000000018910442C-0x0000000189104488
		static BrotliFormatter() {} // 0x0000000189104388-0x00000001891043F8
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref byte[] value) {} // 0x000000018910414C-0x0000000189104388
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class BrotliFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 56382
	{
		// Fields
		internal const int DefaultDecompssionSizeLimit = 134217728; // Metadata: 0x01FD802E
		[Nullable(1)]
		public static readonly BrotliFormatter Default;
		private readonly CompressionLevel compressionLevel;
		private readonly int window;
	
		// Constructors
		public BrotliFormatter() {}
		public BrotliFormatter(CompressionLevel compressionLevel) {}
		public BrotliFormatter(CompressionLevel compressionLevel, int window) {}
		static BrotliFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value) {}
	}
}

namespace MemoryPack.Formatters
{
	[Nullable(new byte[3] {0, 1, 0 })]
	[MemoryPack.Internal.Preserve]
	public sealed class UnmanagedArrayFormatter<T> : MemoryPackFormatter<T[]> // TypeDefIndex: 56287
		where T : struct
	{
		// Constructors
		public UnmanagedArrayFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {2, 0 })] ref ref T[] value) {}
	}

	[Nullable(new byte[3] {0, 1, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class DangerousUnmanagedArrayFormatter<T> : MemoryPackFormatter<T[]> // TypeDefIndex: 56288
	{
		// Constructors
		public DangerousUnmanagedArrayFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {2, 1 })] ref ref T[] value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ArrayFormatter<T> : MemoryPackFormatter<T[]> // TypeDefIndex: 56289
	{
		// Constructors
		public ArrayFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T[] value) {}
	}

	[Nullable(new byte[3] {0, 0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ArraySegmentFormatter<T> : MemoryPackFormatter<ArraySegment<T>> // TypeDefIndex: 56290
	{
		// Constructors
		public ArraySegmentFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {0, 2 })] ref ArraySegment<T> value) {}
	}

	[Nullable(new byte[3] {0, 0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class MemoryFormatter<T> : MemoryPackFormatter<Memory<T>> // TypeDefIndex: 56291
	{
		// Constructors
		public MemoryFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {0, 2 })] ref Memory<T> value) {}
	}

	[Nullable(new byte[3] {0, 0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ReadOnlyMemoryFormatter<T> : MemoryPackFormatter<ReadOnlyMemory<T>> // TypeDefIndex: 56292
	{
		// Constructors
		public ReadOnlyMemoryFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {0, 2 })] ref ReadOnlyMemory<T> value) {}
	}

	[Nullable(new byte[3] {0, 0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ReadOnlySequenceFormatter<T> : MemoryPackFormatter<ReadOnlySequence<T>> // TypeDefIndex: 56293
	{
		// Constructors
		public ReadOnlySequenceFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {0, 2 })] ref ReadOnlySequence<T> value) {}
	}

	[Nullable(new byte[3] {0, 0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class MemoryPoolFormatter<T> : MemoryPackFormatter<Memory<T>> // TypeDefIndex: 56294
	{
		// Constructors
		public MemoryPoolFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {0, 2 })] ref Memory<T> value) {}
	}

	[Nullable(new byte[3] {0, 0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ReadOnlyMemoryPoolFormatter<T> : MemoryPackFormatter<ReadOnlyMemory<T>> // TypeDefIndex: 56295
	{
		// Constructors
		public ReadOnlyMemoryPoolFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {0, 2 })] ref ReadOnlyMemory<T> value) {}
	}

	[MemoryPack.Internal.Preserve]
	public sealed class BigIntegerFormatter : MemoryPackFormatter<BigInteger> // TypeDefIndex: 56296
	{
		// Constructors
		public BigIntegerFormatter() {} // 0x0000000183D4A9A0-0x0000000183D4A9D0
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref BigInteger value) {} // 0x00000001891023A0-0x00000001891024C4
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class BitArrayFormatter : MemoryPackFormatter<BitArray> // TypeDefIndex: 56297
	{
		// Constructors
		public BitArrayFormatter() {} // 0x0000000183D4A970-0x0000000183D4A9A0
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref BitArray value) {} // 0x00000001891024C4-0x00000001891025B0
	}

	[MemoryPack.Internal.Preserve]
	internal class BitArrayView // TypeDefIndex: 56298
	{
		// Fields
		[Nullable(1)]
		public int[] m_array; // 0x10
		public int m_length; // 0x18
		public int _version; // 0x1C
	
		// Constructors
		public BitArrayView() {} // 0x000000018350B670-0x000000018350B680
	}

	[MemoryPack.Internal.Preserve]
	public static class ListFormatter // TypeDefIndex: 56299
	{
		// Methods
		[MemoryPack.Internal.Preserve]
		public static List<T> DeserializePackable<T>(ref MemoryPackReader reader)
			where T : IMemoryPackable<T> => default;
		[MemoryPack.Internal.Preserve]
		public static void DeserializePackable<T>(ref MemoryPackReader reader, [Nullable(2)] ref List<T> value)
			where T : IMemoryPackable<T> {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ListFormatter<T> : MemoryPackFormatter<List<T>> // TypeDefIndex: 56300
	{
		// Constructors
		public ListFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref List<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class StackFormatter<T> : MemoryPackFormatter<Stack<T>> // TypeDefIndex: 56301
	{
		// Constructors
		public StackFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Stack<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class QueueFormatter<T> : MemoryPackFormatter<Queue<T>> // TypeDefIndex: 56302
	{
		// Constructors
		public QueueFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Queue<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class LinkedListFormatter<T> : MemoryPackFormatter<LinkedList<T>> // TypeDefIndex: 56303
	{
		// Constructors
		public LinkedListFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref LinkedList<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class HashSetFormatter<T> : MemoryPackFormatter<HashSet<T>> // TypeDefIndex: 56304
	{
		// Fields
		private readonly IEqualityComparer<T> equalityComparer;
	
		// Constructors
		public HashSetFormatter() {}
		public HashSetFormatter(IEqualityComparer<T> equalityComparer) {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref HashSet<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class SortedSetFormatter<T> : MemoryPackFormatter<SortedSet<T>> // TypeDefIndex: 56305
	{
		// Fields
		private readonly IComparer<T> comparer;
	
		// Constructors
		public SortedSetFormatter() {}
		public SortedSetFormatter(IComparer<T> comparer) {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref SortedSet<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class CollectionFormatter<T> : MemoryPackFormatter<Collection<T>> // TypeDefIndex: 56306
	{
		// Constructors
		public CollectionFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Collection<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ObservableCollectionFormatter<T> : MemoryPackFormatter<ObservableCollection<T>> // TypeDefIndex: 56307
	{
		// Constructors
		public ObservableCollectionFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ObservableCollection<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ConcurrentQueueFormatter<T> : MemoryPackFormatter<ConcurrentQueue<T>> // TypeDefIndex: 56308
	{
		// Constructors
		public ConcurrentQueueFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ConcurrentQueue<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ConcurrentStackFormatter<T> : MemoryPackFormatter<ConcurrentStack<T>> // TypeDefIndex: 56309
	{
		// Constructors
		public ConcurrentStackFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ConcurrentStack<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ConcurrentBagFormatter<T> : MemoryPackFormatter<ConcurrentBag<T>> // TypeDefIndex: 56310
	{
		// Constructors
		public ConcurrentBagFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ConcurrentBag<T> value) {}
	}

	[Nullable(new byte[4] {0, 1, 1, 2 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class DictionaryFormatter<TKey, TValue> : MemoryPackFormatter<Dictionary<TKey, TValue>> // TypeDefIndex: 56311
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private readonly IEqualityComparer<TKey> equalityComparer;
	
		// Constructors
		public DictionaryFormatter() {}
		public DictionaryFormatter([Nullable(new byte[2] {2, 1 })] IEqualityComparer<TKey> equalityComparer) {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 2 })] ref Dictionary<TKey, TValue> value) {}
	}

	[Nullable(new byte[4] {0, 1, 1, 2 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class SortedDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<SortedDictionary<TKey, TValue>> // TypeDefIndex: 56312
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private readonly IComparer<TKey> comparer;
	
		// Constructors
		public SortedDictionaryFormatter() {}
		public SortedDictionaryFormatter([Nullable(new byte[2] {2, 1 })] IComparer<TKey> comparer) {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 2 })] ref SortedDictionary<TKey, TValue> value) {}
	}

	[Nullable(new byte[4] {0, 1, 1, 2 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class SortedListFormatter<TKey, TValue> : MemoryPackFormatter<SortedList<TKey, TValue>> // TypeDefIndex: 56313
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private readonly IComparer<TKey> comparer;
	
		// Constructors
		public SortedListFormatter() {}
		public SortedListFormatter([Nullable(new byte[2] {2, 1 })] IComparer<TKey> comparer) {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 2 })] ref SortedList<TKey, TValue> value) {}
	}

	[Nullable(new byte[4] {0, 1, 1, 2 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class ConcurrentDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<ConcurrentDictionary<TKey, TValue>> // TypeDefIndex: 56314
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private readonly IEqualityComparer<TKey> equalityComparer;
	
		// Constructors
		public ConcurrentDictionaryFormatter() {}
		public ConcurrentDictionaryFormatter([Nullable(new byte[2] {2, 1 })] IEqualityComparer<TKey> equalityComparer) {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 2 })] ref ConcurrentDictionary<TKey, TValue> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ReadOnlyCollectionFormatter<T> : MemoryPackFormatter<ReadOnlyCollection<T>> // TypeDefIndex: 56315
	{
		// Constructors
		public ReadOnlyCollectionFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ReadOnlyCollection<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ReadOnlyObservableCollectionFormatter<T> : MemoryPackFormatter<ReadOnlyObservableCollection<T>> // TypeDefIndex: 56316
	{
		// Constructors
		public ReadOnlyObservableCollectionFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ReadOnlyObservableCollection<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class BlockingCollectionFormatter<T> : MemoryPackFormatter<BlockingCollection<T>> // TypeDefIndex: 56317
	{
		// Constructors
		public BlockingCollectionFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref BlockingCollection<T> value) {}
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class CultureInfoFormatter : MemoryPackFormatter<CultureInfo> // TypeDefIndex: 56318
	{
		// Constructors
		public CultureInfoFormatter() {} // 0x0000000183D4A7C0-0x0000000183D4A7F0
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref CultureInfo value) {} // 0x0000000189104D48-0x0000000189104DC0
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	public sealed class DynamicUnionFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 56320
		where T : class
	{
		// Fields
		private readonly Dictionary<System.Type, ushort> typeToTag;
		private readonly Dictionary<ushort, System.Type> tagToType;
	
		// Constructors
		public DynamicUnionFormatter() {} // Dummy constructor
		public DynamicUnionFormatter([Nullable(new byte[3] {1, 0, 1 })] params [TupleElementNames(new string[2] {"Tag", "Type" })] ValueTuple<ushort, System.Type>[] memoryPackUnions) {}
	
		// Methods
		[NullableContext(2)]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value) {}
	}

	[Nullable(new byte[2] {0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class GenericCollectionFormatter<TCollection, TElement> : MemoryPackFormatter<TCollection> // TypeDefIndex: 56321
		where TCollection : ICollection<TElement>, new()
	{
		// Constructors
		public GenericCollectionFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref TCollection value) {}
	}

	[Nullable(new byte[2] {0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public abstract class GenericSetFormatterBase<TSet, TElement> : MemoryPackFormatter<TSet> // TypeDefIndex: 56322
		where TSet : ISet<TElement>
	{
		// Constructors
		protected GenericSetFormatterBase() {}
	
		// Methods
		[NullableContext(1)]
		[MemoryPack.Internal.Preserve]
		protected abstract TSet CreateSet();
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref TSet value) {}
	}

	[Nullable(new byte[3] {0, 1, 1 })]
	[MemoryPack.Internal.Preserve]
	public sealed class GenericSetFormatter<TSet, TElement> : GenericSetFormatterBase<TSet, TElement> // TypeDefIndex: 56323
		where TSet : ISet<TElement>, new()
	{
		// Constructors
		public GenericSetFormatter() {}
	
		// Methods
		[NullableContext(1)]
		protected override TSet CreateSet() => default;
	}

	[Nullable(new byte[2] {0, 2 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public abstract class GenericDictionaryFormatterBase<TDictionary, TKey, TValue> : MemoryPackFormatter<TDictionary> // TypeDefIndex: 56324
		where TDictionary : IDictionary<TKey, TValue>
	{
		// Constructors
		protected GenericDictionaryFormatterBase() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		protected abstract TDictionary CreateDictionary();
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref TDictionary value) {}
	}

	[Nullable(new byte[4] {0, 1, 1, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class GenericDictionaryFormatter<TDictionary, TKey, TValue> : GenericDictionaryFormatterBase<TDictionary, TKey, TValue> // TypeDefIndex: 56325
		where TDictionary : IDictionary<TKey, TValue>, new()
	{
		// Constructors
		public GenericDictionaryFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		protected override TDictionary CreateDictionary() => default;
	}

	internal static class InterfaceCollectionFormatterUtils // TypeDefIndex: 56326
	{
		// Methods
		[NullableContext(2)]
		public static List<T> ReadList<T>(ref MemoryPackReader reader) => default;
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceEnumerableFormatter<T> : MemoryPackFormatter<IEnumerable<T>> // TypeDefIndex: 56327
	{
		// Constructors
		public InterfaceEnumerableFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref IEnumerable<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceCollectionFormatter<T> : MemoryPackFormatter<ICollection<T>> // TypeDefIndex: 56328
	{
		// Constructors
		static InterfaceCollectionFormatter() {}
		public InterfaceCollectionFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ICollection<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceReadOnlyCollectionFormatter<T> : MemoryPackFormatter<IReadOnlyCollection<T>> // TypeDefIndex: 56329
	{
		// Constructors
		static InterfaceReadOnlyCollectionFormatter() {}
		public InterfaceReadOnlyCollectionFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref IReadOnlyCollection<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceListFormatter<T> : MemoryPackFormatter<IList<T>> // TypeDefIndex: 56330
	{
		// Constructors
		static InterfaceListFormatter() {}
		public InterfaceListFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref IList<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceReadOnlyListFormatter<T> : MemoryPackFormatter<IReadOnlyList<T>> // TypeDefIndex: 56331
	{
		// Constructors
		static InterfaceReadOnlyListFormatter() {}
		public InterfaceReadOnlyListFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref IReadOnlyList<T> value) {}
	}

	[Nullable(new byte[4] {0, 1, 1, 2 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<IDictionary<TKey, TValue>> // TypeDefIndex: 56332
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private readonly IEqualityComparer<TKey> equalityComparer;
	
		// Constructors
		public InterfaceDictionaryFormatter() {}
		public InterfaceDictionaryFormatter([Nullable(new byte[2] {2, 1 })] IEqualityComparer<TKey> equalityComparer) {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 2 })] ref IDictionary<TKey, TValue> value) {}
	}

	[Nullable(new byte[4] {0, 1, 1, 2 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceReadOnlyDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<IReadOnlyDictionary<TKey, TValue>> // TypeDefIndex: 56333
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private readonly IEqualityComparer<TKey> equalityComparer;
	
		// Constructors
		public InterfaceReadOnlyDictionaryFormatter() {}
		public InterfaceReadOnlyDictionaryFormatter([Nullable(new byte[2] {2, 1 })] IEqualityComparer<TKey> equalityComparer) {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 2 })] ref IReadOnlyDictionary<TKey, TValue> value) {}
	}

	[Nullable(new byte[4] {0, 1, 1, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceLookupFormatter<TKey, TElement> : MemoryPackFormatter<ILookup<TKey, TElement>> // TypeDefIndex: 56334
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private readonly IEqualityComparer<TKey> equalityComparer;
	
		// Constructors
		static InterfaceLookupFormatter() {}
		public InterfaceLookupFormatter() {}
		public InterfaceLookupFormatter([Nullable(new byte[2] {2, 1 })] IEqualityComparer<TKey> equalityComparer) {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 1 })] ref ILookup<TKey, TElement> value) {}
	}

	[Nullable(new byte[4] {0, 1, 1, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceGroupingFormatter<TKey, TElement> : MemoryPackFormatter<IGrouping<TKey, TElement>> // TypeDefIndex: 56335
	{
		// Constructors
		static InterfaceGroupingFormatter() {}
		public InterfaceGroupingFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 1 })] ref IGrouping<TKey, TElement> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceSetFormatter<T> : MemoryPackFormatter<ISet<T>> // TypeDefIndex: 56336
	{
		// Fields
		private readonly IEqualityComparer<T> equalityComparer;
	
		// Constructors
		static InterfaceSetFormatter() {}
		public InterfaceSetFormatter() {}
		public InterfaceSetFormatter(IEqualityComparer<T> equalityComparer) {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ISet<T> value) {}
	}

	[Nullable(0)]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	internal sealed class Grouping<TKey, TElement> : IGrouping<TKey, TElement> // TypeDefIndex: 56337
	{
		// Fields
		private readonly TKey key;
		private readonly IEnumerable<TElement> elements;
	
		// Properties
		public TKey Key { get => default; }
	
		// Constructors
		public Grouping() {} // Dummy constructor
		public Grouping(TKey key, IEnumerable<TElement> elements) {}
	
		// Methods
		public IEnumerator<TElement> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	[Nullable(0)]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	internal sealed class Lookup<TKey, TElement> : ILookup<TKey, TElement> // TypeDefIndex: 56338
	{
		// Fields
		private readonly Dictionary<TKey, IGrouping<TKey, TElement>> groupings;
	
		// Properties
		public IEnumerable<TElement> this[TKey key] { get => default; }
		public int Count { get => default; }
	
		// Constructors
		public Lookup() {} // Dummy constructor
		public Lookup(Dictionary<TKey, IGrouping<TKey, TElement>> groupings) {}
	
		// Methods
		public bool Contains(TKey key) => default;
		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	[MemoryPack.Internal.Preserve]
	public static class KeyValuePairFormatter // TypeDefIndex: 56339
	{
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public static void Deserialize<TKey, TValue>([Nullable(1)] IMemoryPackFormatter<TKey> keyFormatter, [Nullable(1)] IMemoryPackFormatter<TValue> valueFormatter, ref MemoryPackReader reader, out ref TKey key, out ref TValue value) {
			key = default;
			value = default;
		}
	}

	[Nullable(new byte[4] {0, 0, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class KeyValuePairFormatter<TKey, TValue> : MemoryPackFormatter<KeyValuePair<TKey, TValue>> // TypeDefIndex: 56340
	{
		// Constructors
		public KeyValuePairFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {0, 2, 2 })] ref KeyValuePair<TKey, TValue> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class LazyFormatter<T> : MemoryPackFormatter<Lazy<T>> // TypeDefIndex: 56341
	{
		// Constructors
		public LazyFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Lazy<T> value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TwoDimensionalArrayFormatter<T> : MemoryPackFormatter<T[,]> // TypeDefIndex: 56342
	{
		// Constructors
		public TwoDimensionalArrayFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T[,] value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ThreeDimensionalArrayFormatter<T> : MemoryPackFormatter<T[,,]> // TypeDefIndex: 56343
	{
		// Constructors
		public ThreeDimensionalArrayFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T[,,] value) {}
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class FourDimensionalArrayFormatter<T> : MemoryPackFormatter<T[,,,]> // TypeDefIndex: 56344
	{
		// Constructors
		public FourDimensionalArrayFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T[,,,] value) {}
	}

	[MemoryPack.Internal.Preserve]
	public sealed class NullableFormatter<T> : MemoryPackFormatter<T?> // TypeDefIndex: 56345
		where T : struct
	{
		// Constructors
		public NullableFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref T? value) {}
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class StringBuilderFormatter : MemoryPackFormatter<StringBuilder> // TypeDefIndex: 56346
	{
		// Constructors
		public StringBuilderFormatter() {} // 0x0000000183D49F20-0x0000000183D49F50
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref StringBuilder value) {} // 0x000000018910CD34-0x000000018910CEDC
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class StringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 56347
	{
		// Fields
		public static readonly StringFormatter Default; // 0x00
	
		// Constructors
		public StringFormatter() {} // 0x0000000183CDCDC0-0x0000000183CDCDF0
		static StringFormatter() {} // 0x0000000183CDCD50-0x0000000183CDCDC0
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref string value) {} // 0x0000000182538460-0x00000001825384C0
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class Utf8StringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 56348
	{
		// Fields
		public static readonly Utf8StringFormatter Default; // 0x00
	
		// Constructors
		public Utf8StringFormatter() {} // 0x000000018910FFF4-0x000000018911001C
		static Utf8StringFormatter() {} // 0x000000018910FF84-0x000000018910FFF4
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref string value) {} // 0x0000000185583170-0x0000000185583194
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class Utf16StringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 56349
	{
		// Fields
		public static readonly Utf16StringFormatter Default; // 0x00
	
		// Constructors
		public Utf16StringFormatter() {} // 0x000000018910FF5C-0x000000018910FF84
		static Utf16StringFormatter() {} // 0x000000018910FEEC-0x000000018910FF5C
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref string value) {} // 0x0000000185583170-0x0000000185583194
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class InternStringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 56350
	{
		// Fields
		public static readonly InternStringFormatter Default; // 0x00
	
		// Constructors
		public InternStringFormatter() {} // 0x00000001891053B8-0x00000001891053E0
		static InternStringFormatter() {} // 0x0000000189105348-0x00000001891053B8
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref string value) {} // 0x000000018910530C-0x0000000189105348
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class BrotliStringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 56352
	{
		// Fields
		[ThreadStatic]
		private static StrongBox<int> threadStaticConsumedBox; // 0x80000000
		internal const int DefaultDecompssionSizeLimit = 134217728; // Metadata: 0x01FD8015
		[Nullable(1)]
		public static readonly BrotliStringFormatter Default; // 0x00
		private readonly CompressionLevel compressionLevel; // 0x10
		private readonly int window; // 0x14
		private readonly int decompressionSizeLimit; // 0x18
	
		// Constructors
		public BrotliStringFormatter() {} // 0x0000000189104A2C-0x0000000189104A3C
		public BrotliStringFormatter(CompressionLevel compressionLevel) {} // 0x00000001891049E0-0x0000000189104A0C
		public BrotliStringFormatter(CompressionLevel compressionLevel, int window) {} // 0x0000000189104A0C-0x0000000189104A2C
		public BrotliStringFormatter(CompressionLevel compressionLevel, int window, int decompressionSizeLimit) {} // 0x0000000189104A3C-0x0000000189104A98
		static BrotliStringFormatter() {} // 0x0000000189104970-0x00000001891049E0
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref string value) {} // 0x0000000189104498-0x0000000189104970
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TimeZoneInfoFormatter : MemoryPackFormatter<TimeZoneInfo> // TypeDefIndex: 56353
	{
		// Constructors
		public TimeZoneInfoFormatter() {} // 0x0000000183D49EF0-0x0000000183D49F20
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref TimeZoneInfo value) {} // 0x000000018910CEDC-0x000000018910CF54
	}

	internal static class TupleFormatterTypes // TypeDefIndex: 56354
	{
		// Fields
		[Nullable(1)]
		public static readonly Dictionary<System.Type, System.Type> TupleFormatters; // 0x00
	
		// Constructors
		static TupleFormatterTypes() {} // 0x000000018910CF54-0x000000018910D4DC
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1> : MemoryPackFormatter<Tuple<T1>> // TypeDefIndex: 56355
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1> value) {}
	}

	[Nullable(new byte[4] {0, 1, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1, T2> : MemoryPackFormatter<Tuple<T1, T2>> // TypeDefIndex: 56356
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2> value) {}
	}

	[Nullable(new byte[5] {0, 1, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1, T2, T3> : MemoryPackFormatter<Tuple<T1, T2, T3>> // TypeDefIndex: 56357
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3> value) {}
	}

	[Nullable(new byte[6] {0, 1, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1, T2, T3, T4> : MemoryPackFormatter<Tuple<T1, T2, T3, T4>> // TypeDefIndex: 56358
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3, T4> value) {}
	}

	[Nullable(new byte[7] {0, 1, 2, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1, T2, T3, T4, T5> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5>> // TypeDefIndex: 56359
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3, T4, T5> value) {}
	}

	[Nullable(new byte[8] {0, 1, 2, 2, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1, T2, T3, T4, T5, T6> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5, T6>> // TypeDefIndex: 56360
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3, T4, T5, T6> value) {}
	}

	[Nullable(new byte[9] {0, 1, 2, 2, 2, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1, T2, T3, T4, T5, T6, T7> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5, T6, T7>> // TypeDefIndex: 56361
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3, T4, T5, T6, T7> value) {}
	}

	[Nullable(new byte[10] {0, 1, 2, 2, 2, 2, 2, 2, 2, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1, T2, T3, T4, T5, T6, T7, TRest> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>> // TypeDefIndex: 56362
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[9] {2, 2, 2, 2, 2, 2, 2, 2, 1 })] ref Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> value) {}
	}

	[Nullable(new byte[3] {0, 0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1> : MemoryPackFormatter<ValueTuple<T1>> // TypeDefIndex: 56363
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {0, 2 })] ref ValueTuple<T1> value) {}
	}

	[Nullable(new byte[4] {0, 0, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1, T2> : MemoryPackFormatter<ValueTuple<T1, T2>> // TypeDefIndex: 56364
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {0, 2, 2 })] ref ValueTuple<T1, T2> value) {}
	}

	[Nullable(new byte[5] {0, 0, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1, T2, T3> : MemoryPackFormatter<ValueTuple<T1, T2, T3>> // TypeDefIndex: 56365
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[4] {0, 2, 2, 2 })] ref ValueTuple<T1, T2, T3> value) {}
	}

	[Nullable(new byte[6] {0, 0, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1, T2, T3, T4> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4>> // TypeDefIndex: 56366
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[5] {0, 2, 2, 2, 2 })] ref ValueTuple<T1, T2, T3, T4> value) {}
	}

	[Nullable(new byte[7] {0, 0, 2, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5>> // TypeDefIndex: 56367
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[6] {0, 2, 2, 2, 2, 2 })] ref ValueTuple<T1, T2, T3, T4, T5> value) {}
	}

	[Nullable(new byte[8] {0, 0, 2, 2, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5, T6> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5, T6>> // TypeDefIndex: 56368
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[7] {0, 2, 2, 2, 2, 2, 2 })] ref ValueTuple<T1, T2, T3, T4, T5, T6> value) {}
	}

	[Nullable(new byte[9] {0, 0, 2, 2, 2, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> // TypeDefIndex: 56369
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[8] {0, 2, 2, 2, 2, 2, 2, 2 })] ref ValueTuple<T1, T2, T3, T4, T5, T6, T7> value) {}
	}

	[Nullable(new byte[10] {0, 0, 2, 2, 2, 2, 2, 2, 2, 0 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7, TRest> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>> // TypeDefIndex: 56370
		where TRest : struct
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[9] {0, 2, 2, 2, 2, 2, 2, 2, 0 })] ref ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> value) {}
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class TypeFormatter : MemoryPackFormatter<System.Type> // TypeDefIndex: 56371
	{
		// Fields
		private static readonly Regex _shortTypeNameRegex; // 0x00
	
		// Constructors
		public TypeFormatter() {} // 0x0000000183D49E90-0x0000000183D49EC0
		static TypeFormatter() {} // 0x0000000183CC6FE0-0x0000000183CC7080
	
		// Methods
		private static Regex ShortTypeNameRegex() => default; // 0x000000018910D570-0x000000018910D5C0
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref System.Type value) {} // 0x000000018910D4DC-0x000000018910D570
	}

	[MemoryPack.Internal.Preserve]
	public sealed class UnmanagedFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 56372
		where T : struct
	{
		// Constructors
		public UnmanagedFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value) {}
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class DangerousUnmanagedFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 56373
	{
		// Constructors
		public DangerousUnmanagedFormatter() {}
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value) {}
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class UriFormatter : MemoryPackFormatter<System.Uri> // TypeDefIndex: 56374
	{
		// Constructors
		public UriFormatter() {} // 0x0000000183D49E60-0x0000000183D49E90
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref System.Uri value) {} // 0x000000018910FE60-0x000000018910FEEC
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class VersionFormatter : MemoryPackFormatter<System.Version> // TypeDefIndex: 56375
	{
		// Constructors
		public VersionFormatter() {} // 0x0000000183D49E00-0x0000000183D49E30
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref System.Version value) {} // 0x000000018911001C-0x00000001891104D8
	}
}

namespace MemoryPack.Internal
{
	internal static class EnumerableExtensions // TypeDefIndex: 56270
	{
		// Extension methods
		[NullableContext(1)]
		public static bool TryGetNonEnumeratedCountEx<T>(this IEnumerable<T> value, out int count) {
			count = default;
			return default;
		}
	}

	internal struct FixedArrayBufferWriter : IBufferWriter<byte> // TypeDefIndex: 56271
	{
		// Fields
		[Nullable(1)]
		private byte[] buffer; // 0x00
		private int written; // 0x08
	
		// Constructors
		[NullableContext(1)]
		public FixedArrayBufferWriter(byte[] buffer) {
			this.buffer = default;
			written = default;
		} // 0x0000000184271F74-0x0000000184271F90
	
		// Methods
		public void Advance(int count) {} // 0x0000000183D6E610-0x0000000183D6E620
		public Memory<byte> GetMemory(int sizeHint = 0 /* Metadata: 0x01FD7FFF */) => default; // 0x000000018910507C-0x000000018910511C
		public Span<byte> GetSpan(int sizeHint = 0 /* Metadata: 0x01FD8000 */) => default; // 0x000000018910511C-0x00000001891051B0
		[NullableContext(1)]
		public byte[] GetFilledBuffer() => default; // 0x000000018910502C-0x000000018910507C
	}

	internal static class MathEx // TypeDefIndex: 56272
	{
		// Fields
		private const int ArrayMexLength = 2147483591; // Metadata: 0x01FD8001
	
		// Methods
		public static int NewArrayCapacity(int size) => default; // 0x00000001891053E0-0x00000001891053F0
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class MemoryMarshalEx // TypeDefIndex: 56273
	{
		// Methods
		public static ref ref T GetArrayDataReference<T>(T[] array) => ref _refReturnTypeForGetArrayDataReference;
		private ref T _refReturnTypeForGetArrayDataReference; // Dummy field
		public static T[] AllocateUninitializedArray<T>(int length, bool pinned = false /* Metadata: 0x01FD8006 */) => default;
	}

	public sealed class PreserveAttribute : Attribute // TypeDefIndex: 56274
	{
		// Constructors
		public PreserveAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class ReusableLinkedArrayBufferWriterPool // TypeDefIndex: 56275
	{
		// Fields
		private static readonly ConcurrentQueue<ReusableLinkedArrayBufferWriter> queue; // 0x00
	
		// Constructors
		static ReusableLinkedArrayBufferWriterPool() {} // 0x000000018910B4F8-0x000000018910B584
	
		// Methods
		public static ReusableLinkedArrayBufferWriter Rent() => default; // 0x000000018910B3C8-0x000000018910B47C
		public static void Return(ReusableLinkedArrayBufferWriter writer) {} // 0x000000018910B47C-0x000000018910B4F8
	}

	[Nullable(0)]
	[NullableContext(1)]
	public sealed class ReusableLinkedArrayBufferWriter : IBufferWriter<byte> // TypeDefIndex: 56279
	{
		// Fields
		private const int InitialBufferSize = 262144; // Metadata: 0x01FD8009
		private static readonly byte[] noUseFirstBufferSentinel; // 0x00
		private List<BufferSegment> buffers; // 0x10
		private byte[] firstBuffer; // 0x18
		private int firstBufferWritten; // 0x20
		private BufferSegment current; // 0x28
		private int nextBufferSize; // 0x38
		private int totalWritten; // 0x3C
	
		// Properties
		public int TotalWritten { get => default; } // 0x0000000183D4ED90-0x0000000183D4EDA0 
		private bool UseFirstBuffer { get => default; } // 0x000000018910C200-0x000000018910C250 
	
		// Nested types
		[NullableContext(0)]
		public struct Enumerator : IEnumerator<Memory<byte>> // TypeDefIndex: 56277
		{
			// Fields
			[Nullable(1)]
			private ReusableLinkedArrayBufferWriter parent; // 0x00
			private State state; // 0x08
			private Memory<byte> current; // 0x10
			private List<BufferSegment> buffersEnumerator; // 0x20
	
			// Properties
			public Memory<byte> Current { get => default; } // 0x00000001820B7B30-0x00000001820B7B40 
			[Nullable(1)]
			object IEnumerator.Current { [NullableContext(1)] get => default; } // 0x0000000189104F80-0x0000000189104FCC 
	
			// Nested types
			private enum State // TypeDefIndex: 56276
			{
				FirstBuffer = 0,
				BuffersInit = 1,
				BuffersIterate = 2,
				Current = 3,
				End = 4
			}
	
			// Constructors
			[NullableContext(1)]
			public Enumerator(ReusableLinkedArrayBufferWriter parent) : this() {
				this.parent = default;
				state = default;
				current = default;
				buffersEnumerator = default;
			} // 0x0000000189104FCC-0x0000000189105000
	
			// Methods
			public void Dispose() {} // 0x000000018350B670-0x000000018350B680
			public bool MoveNext() => default; // 0x0000000189104DC0-0x0000000189104F34
			public void Reset() {} // 0x0000000189104F34-0x0000000189104F80
		}
	
		// Constructors
		public ReusableLinkedArrayBufferWriter() {} // Dummy constructor
		public ReusableLinkedArrayBufferWriter(bool useFirstBuffer, bool pinned) {} // 0x000000018910C0FC-0x000000018910C200
		static ReusableLinkedArrayBufferWriter() {} // 0x000000018910C098-0x000000018910C0FC
	
		// Methods
		public byte[] DangerousGetFirstBuffer() => default; // 0x0000000181041090-0x00000001810410A0
		[NullableContext(0)]
		public Memory<byte> GetMemory(int sizeHint = 0 /* Metadata: 0x01FD8007 */) => default; // 0x000000018910B5D0-0x000000018910B61C
		[NullableContext(0)]
		public Span<byte> GetSpan(int sizeHint = 0 /* Metadata: 0x01FD8008 */) => default; // 0x000000018910B61C-0x000000018910B760
		public void Advance(int count) {} // 0x000000018910B584-0x000000018910B5A4
		public byte[] ToArrayAndReset() => default; // 0x000000018910B90C-0x000000018910BC78
		public void WriteToAndReset(ref MemoryPackWriter writer) {} // 0x000000018910BD5C-0x000000018910C098
		public async ValueTask WriteToAndResetAsync(Stream stream, CancellationToken cancellationToken) => default; // 0x000000018910BC78-0x000000018910BD5C
		public Enumerator GetEnumerator() => default; // 0x000000018910B5A4-0x000000018910B5D0
		private void ResetCore() {} // 0x000000018910B760-0x000000018910B7BC
		public void Reset() {} // 0x000000018910B7BC-0x000000018910B90C
	}

	internal struct BufferSegment // TypeDefIndex: 56280
	{
		// Fields
		[Nullable(1)]
		private byte[] buffer; // 0x00
		private int written; // 0x08
	
		// Properties
		public bool IsNull { get => default; } // 0x0000000182361C20-0x0000000182361C30 
		public int WrittenCount { get => default; } // 0x0000000183D516F0-0x0000000183D51700 
		public Span<byte> WrittenBuffer { get => default; } // 0x0000000189104C80-0x0000000189104CE4 
		public Memory<byte> WrittenMemory { get => default; } // 0x0000000189104CE4-0x0000000189104D48 
		public Span<byte> FreeBuffer { get => default; } // 0x0000000189104C2C-0x0000000189104C80 
	
		// Constructors
		public BufferSegment(int size) : this() {
			buffer = default;
			written = default;
		} // 0x0000000189104BAC-0x0000000189104C2C
	
		// Methods
		public void Advance(int count) {} // 0x0000000183D6E610-0x0000000183D6E620
		public void Clear() {} // 0x0000000189104B30-0x0000000189104BAC
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class ReusableReadOnlySequenceBuilderPool // TypeDefIndex: 56281
	{
		// Fields
		private static readonly ConcurrentQueue<ReusableReadOnlySequenceBuilder> queue; // 0x00
	
		// Constructors
		static ReusableReadOnlySequenceBuilderPool() {} // 0x000000018910C378-0x000000018910C404
	
		// Methods
		public static ReusableReadOnlySequenceBuilder Rent() => default; // 0x000000018910C250-0x000000018910C2FC
		public static void Return(ReusableReadOnlySequenceBuilder builder) {} // 0x000000018910C2FC-0x000000018910C378
	}

	internal sealed class ReusableReadOnlySequenceBuilder // TypeDefIndex: 56283
	{
		// Fields
		[Nullable(1)]
		private readonly Stack<Segment> segmentPool; // 0x10
		[Nullable(1)]
		private readonly List<Segment> list; // 0x18
	
		// Nested types
		private class Segment : ReadOnlySequenceSegment<byte> // TypeDefIndex: 56282
		{
			// Fields
			private bool returnToPool; // 0x30
	
			// Constructors
			public Segment() {} // 0x000000018910CC04-0x000000018910CC3C
	
			// Methods
			public void SetBuffer(ReadOnlyMemory<byte> buffer, bool returnToPool) {} // 0x000000018910CB48-0x000000018910CBA4
			public void Reset() {} // 0x000000018910CA08-0x000000018910CB48
			[NullableContext(2)]
			public void SetRunningIndexAndNext(long runningIndex, Segment nextSegment) {} // 0x000000018910CBA4-0x000000018910CC04
		}
	
		// Constructors
		public ReusableReadOnlySequenceBuilder() {} // 0x000000018910C948-0x000000018910CA08
	
		// Methods
		public void Add(ReadOnlyMemory<byte> buffer, bool returnToPool) {} // 0x000000018910C404-0x000000018910C500
		public bool TryGetSingleMemory(out ReadOnlyMemory<byte> memory) {
			memory = default;
			return default;
		} // 0x000000018910C8AC-0x000000018910C948
		public ReadOnlySequence<byte> Build() => default; // 0x000000018910C500-0x000000018910C734
		public void Reset() {} // 0x000000018910C734-0x000000018910C8AC
	}

	internal static class TypeHelpers // TypeDefIndex: 56286
	{
		// Fields
		[Nullable(1)]
		private static readonly MethodInfo isReferenceOrContainsReferences; // 0x00
		[Nullable(1)]
		private static readonly MethodInfo unsafeSizeOf; // 0x08
	
		// Nested types
		private static class Cache<T> // TypeDefIndex: 56284
		{
			// Fields
			public static bool IsReferenceOrNullable;
			public static bool IsUnmanagedSZArray;
			public static int UnmanagedSZArrayElementSize;
			public static bool IsFixedSizeMemoryPackable;
			public static int MemoryPackableFixedSize;
	
			// Constructors
			static Cache() {}
		}
	
		internal enum TypeKind : byte // TypeDefIndex: 56285
		{
			None = 0,
			UnmanagedSZArray = 1,
			FixedSizeMemoryPackable = 2
		}
	
		// Constructors
		static TypeHelpers() {} // 0x000000018910D718-0x000000018910D82C
	
		// Methods
		[NullableContext(2)]
		public static bool IsReferenceOrNullable<T>() => default;
		[NullableContext(2)]
		public static TypeKind TryGetUnmanagedSZArrayElementSizeOrMemoryPackableFixedSize<T>(out int size) {
			size = default;
			return default;
		}
		[NullableContext(1)]
		public static bool IsAnonymous(System.Type type) => default; // 0x000000018910D5C0-0x000000018910D718
	}
}
