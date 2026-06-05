/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Buffers;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// Image 45: MemoryPack.dll - Assembly: MemoryPack, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57220-57384

public class MemoryPackRegister<T> // TypeDefIndex: 57225
{
	// Fields
	public static Func<bool> s_initFunc;

	// Constructors
	public MemoryPackRegister() {}
}

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 57384
{
	// Fields
	internal static readonly int AD95131BC0B799C0B1AF477FB14FCF26A6A9F76079E48BF090ACB7E8367BFD0E; // 0x00 // Static value (base64): /////w== - Metadata: 0x0207D8DC
	internal static readonly int DF3F619804A92FDB4057192DC43DD748EA778ADC52BC498CE80524C014B81119; // 0x04 // Static value (base64): AAAAAA== - Metadata: 0x0207D8E4

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace MemoryPack
{
	public sealed class MemoryPackableAttribute : Attribute // TypeDefIndex: 57227
	{
		// Fields
		private readonly GenerateType _GenerateType_k__BackingField; // 0x10
		private readonly SerializeLayout _SerializeLayout_k__BackingField; // 0x14
	
		// Properties
		public GenerateType GenerateType { get; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
		public SerializeLayout SerializeLayout { get; } // 0x0000000185FB21A0-0x0000000185FB21B0 
	
		// Constructors
		public MemoryPackableAttribute() {} // Dummy constructor
		public MemoryPackableAttribute(GenerateType generateType = GenerateType.Object /* Metadata: 0x0207D887 */) {} // 0x000000018B23539C-0x000000018B2353B0
		public MemoryPackableAttribute(SerializeLayout serializeLayout) {} // 0x0000000185FCF270-0x0000000185FCF280
		public MemoryPackableAttribute(GenerateType generateType, SerializeLayout serializeLayout) {} // 0x0000000185FB2190-0x0000000185FB21A0
	}

	public enum GenerateType // TypeDefIndex: 57228
	{
		Object = 0,
		VersionTolerant = 1,
		CircularReference = 2,
		Collection = 3,
		NoGenerate = 4
	}

	public enum SerializeLayout // TypeDefIndex: 57229
	{
		Sequential = 0,
		Explicit = 1
	}

	public sealed class MemoryPackUnionAttribute : Attribute // TypeDefIndex: 57230
	{
		// Fields
		private readonly ushort _Tag_k__BackingField; // 0x10
		private readonly System.Type _Type_k__BackingField; // 0x18
	
		// Properties
		public ushort Tag { get; } // 0x0000000185FC2810-0x0000000185FC2820 
		public System.Type Type { get; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Constructors
		public MemoryPackUnionAttribute() {} // Dummy constructor
		public MemoryPackUnionAttribute(ushort tag, System.Type type) {} // 0x000000018B233D98-0x000000018B233DAC
	}

	public sealed class MemoryPackUnionFormatterAttribute : Attribute // TypeDefIndex: 57231
	{
		// Fields
		private readonly System.Type _Type_k__BackingField; // 0x10
	
		// Properties
		public System.Type Type { get; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		public MemoryPackUnionFormatterAttribute() {} // Dummy constructor
		public MemoryPackUnionFormatterAttribute(System.Type type) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public sealed class MemoryPackAllowSerializeAttribute : Attribute // TypeDefIndex: 57232
	{
		// Constructors
		public MemoryPackAllowSerializeAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class MemoryPackOrderAttribute : Attribute // TypeDefIndex: 57233
	{
		// Fields
		private readonly int _Order_k__BackingField; // 0x10
	
		// Properties
		public int Order { get; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
	
		// Constructors
		public MemoryPackOrderAttribute() {} // Dummy constructor
		public MemoryPackOrderAttribute(int order) {} // 0x0000000181378230-0x0000000181378240
	}

	public sealed class MemoryPackIgnoreAttribute : Attribute // TypeDefIndex: 57234
	{
		// Constructors
		public MemoryPackIgnoreAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class MemoryPackIncludeAttribute : Attribute // TypeDefIndex: 57235
	{
		// Constructors
		public MemoryPackIncludeAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class MemoryPackConstructorAttribute : Attribute // TypeDefIndex: 57236
	{
		// Constructors
		public MemoryPackConstructorAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class MemoryPackOnSerializingAttribute : Attribute // TypeDefIndex: 57237
	{
		// Constructors
		public MemoryPackOnSerializingAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class MemoryPackOnSerializedAttribute : Attribute // TypeDefIndex: 57238
	{
		// Constructors
		public MemoryPackOnSerializedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class MemoryPackOnDeserializingAttribute : Attribute // TypeDefIndex: 57239
	{
		// Constructors
		public MemoryPackOnDeserializingAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class MemoryPackOnDeserializedAttribute : Attribute // TypeDefIndex: 57240
	{
		// Constructors
		public MemoryPackOnDeserializedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class GenerateTypeScriptAttribute : Attribute // TypeDefIndex: 57241
	{
		// Constructors
		public GenerateTypeScriptAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class MemoryPackFormatterProvider // TypeDefIndex: 57244
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
		private static class Check<T> // TypeDefIndex: 57242
		{
			// Fields
			public static bool registered;
		}
	
		public static class Cache<T> // TypeDefIndex: 57243
		{
			// Fields
			private static IMemoryPackFormatter<T> _formatter;
	
			// Properties
			public static IMemoryPackFormatter<T> formatter { get; set; } // 0x0000000184699820-0x0000000184699DC0 0x000000018469A830-0x000000018469B5F0
		}
	
		// Constructors
		static MemoryPackFormatterProvider() {}
	
		// Methods
		private static void RegisterInitialFormatters() {}
		public static bool IsRegistered<T>() => default; // 0x000000018B22FEC0-0x000000018B22FFD8
		public static void Register<T>(IMemoryPackFormatter<T> formatter) {}
		public static void RegisterGenericType(System.Type genericType, System.Type genericFormatterType) {} // 0x000000018B22FC68-0x000000018B22FD94
		public static void RegisterCollection<TCollection, TElement>()
			where TCollection : ICollection<TElement>, new() {}
		public static void RegisterCollection(System.Type genericCollectionType) {} // 0x000000018B22FFD8-0x000000018B230104
		public static void RegisterSet<TSet, TElement>()
			where TSet : ISet<TElement>, new() {}
		public static void RegisterSet(System.Type genericSetType) {} // 0x000000018B22FD94-0x000000018B22FEC0
		public static void RegisterDictionary<TDictionary, TKey, TValue>()
			where TDictionary : IDictionary<TKey, TValue>, new() {}
		public static void RegisterDictionary(System.Type genericDictionaryType) {} // 0x000000018B22FA64-0x000000018B22FC68
		public static IMemoryPackFormatter<T> GetFormatter<T>() => default; // 0x000000018B2302D4-0x000000018B230438
		internal static IMemoryPackFormatter GetFormatter(System.Type type) => default;
		private static bool TryInvokeRegisterFormatter(System.Type type) => default; // 0x000000018B22F698-0x000000018B22FA64
		public static void ForceRegister<T>(IMemoryPackFormatter<T> formatter) {} // 0x000000018B230224-0x000000018B2302D4
		internal static object CreateGenericFormatter(System.Type type, bool typeIsReferenceOrContainsReferences) => default; // 0x000000018B230104-0x000000018B230224
		private static System.Type TryCreateGenericFormatterType(System.Type type, IDictionary<System.Type, System.Type> knownTypes) => default; // 0x000000018540FAC0-0x0000000185411D30
		private static System.Type TryCreateGenericCollectionFormatterType(System.Type type) => default;
		internal static void RegisterWellKnownTypesFormatters() {}
		private static void UnityRegister<T>()
			where T : struct {}
	}

	public interface IMemoryPackFormatterRegister // TypeDefIndex: 57245
	{
	}

	public interface IMemoryPackable<T> : IMemoryPackFormatterRegister // TypeDefIndex: 57246
	{
	}

	public interface IMemoryPackFormatter // TypeDefIndex: 57247
	{
		// Methods
		void Deserialize(ref MemoryPackReader reader, ref object value);
	}

	public interface IMemoryPackFormatter<T> // TypeDefIndex: 57248
	{
		// Methods
		void Deserialize(ref MemoryPackReader reader, ref ref T value);
	}

	public abstract class MemoryPackFormatter<T> : IMemoryPackFormatter<T>, IMemoryPackFormatter // TypeDefIndex: 57249
	{
		// Constructors
		protected MemoryPackFormatter() {}
	
		// Methods
		public abstract void Deserialize(ref MemoryPackReader reader, ref ref T value);
		void IMemoryPackFormatter.Deserialize(ref MemoryPackReader reader, ref object value) {}
	}

	public static class MemoryPackCode // TypeDefIndex: 57250
	{
		// Fields
		public const int NullCollection = -1; // Metadata: 0x0207D88F
		public const byte WideTag = 250; // Metadata: 0x0207D890
		public const byte ReferenceId = 250; // Metadata: 0x0207D891
		public const byte Reserved1 = 250; // Metadata: 0x0207D892
		public const byte Reserved2 = 251; // Metadata: 0x0207D893
		public const byte Reserved3 = 252; // Metadata: 0x0207D894
		public const byte Reserved4 = 253; // Metadata: 0x0207D895
		public const byte Reserved5 = 254; // Metadata: 0x0207D896
		public const byte NullObject = 255; // Metadata: 0x0207D897
	
		// Properties
		internal static ReadOnlySpan<byte> NullCollectionData { get; } // 0x000000018B22F5E0-0x000000018B22F63C 
		internal static ReadOnlySpan<byte> ZeroCollectionData { get; } // 0x000000018B22F63C-0x000000018B22F698 
	}

	internal sealed class ErrorMemoryPackFormatter : IMemoryPackFormatter // TypeDefIndex: 57251
	{
		// Fields
		private readonly System.Type type; // 0x10
		private readonly string message; // 0x18
	
		// Constructors
		public ErrorMemoryPackFormatter() {} // Dummy constructor
		public ErrorMemoryPackFormatter(System.Type type) {} // 0x00000001846A0F60-0x00000001846A0F90
		public ErrorMemoryPackFormatter(System.Type type, string message) {} // 0x00000001841BC230-0x00000001841BC260
	
		// Methods
		public void Serialize(ref MemoryPackWriter writer, ref object value) {} // 0x000000018B22F1F0-0x000000018B22F1FC
		public void Deserialize(ref MemoryPackReader reader, ref object value) {} // 0x000000018B22F1F0-0x000000018B22F1FC
		private void Throw() {} // 0x000000018B22F1FC-0x000000018B22F21C
	}

	internal sealed class ErrorMemoryPackFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 57252
	{
		// Fields
		private readonly Exception exception;
		private readonly string message;
	
		// Constructors
		public ErrorMemoryPackFormatter() {}
		public ErrorMemoryPackFormatter(Exception exception) {}
		public ErrorMemoryPackFormatter(string message) {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value) {}
		private void Throw() {}
	}

	public struct MemoryPackReader // TypeDefIndex: 57253
	{
		// Fields
		private ReadOnlySequence<byte> bufferSource; // 0x00
		private readonly long totalLength; // 0x18
		private ReadOnlySpan<byte> bufferReference; // 0x20
		private int bufferLength; // 0x30
		private byte[] rentBuffer; // 0x38
		private int advancedCount; // 0x40
		private int consumed; // 0x44
		private readonly MemoryPackReaderOptionalState optionalState; // 0x48
	
		// Properties
		public int Consumed { get => default; } // 0x0000000183908D10-0x0000000183908D20 
		public long Remaining { get => default; } // 0x0000000185FCF260-0x0000000185FCF270 
		public MemoryPackReaderOptionalState OptionalState { get => default; } // 0x00000001813ECF20-0x00000001813ECF30 
		public MemoryPackSerializerOptions Options { get => default; } // 0x000000018B23255C-0x000000018B232578 
	
		// Constructors
		public MemoryPackReader(in ReadOnlySequence<byte> sequence, MemoryPackReaderOptionalState optionalState) : this() {
			bufferSource = default;
			totalLength = default;
			bufferReference = default;
			bufferLength = default;
			rentBuffer = default;
			advancedCount = default;
			consumed = default;
			this.optionalState = default;
		} // 0x000000018B232444-0x000000018B23255C
		public MemoryPackReader(ReadOnlySpan<byte> buffer, MemoryPackReaderOptionalState optionalState) : this() {
			bufferSource = default;
			totalLength = default;
			bufferReference = default;
			bufferLength = default;
			rentBuffer = default;
			advancedCount = default;
			consumed = default;
			this.optionalState = default;
		} // 0x0000000184BDCAD0-0x0000000184BDCB80
	
		// Methods
		public ref byte GetSpanReference(int sizeHint) => ref _refReturnTypeForGetSpanReference; // 0x000000018B230E70-0x000000018B230ED8
		private ref byte _refReturnTypeForGetSpanReference; // Dummy field
		private ref byte GetNextSpan(int sizeHint) => ref _refReturnTypeForGetNextSpan; // 0x000000018B2308E0-0x000000018B230C5C
		private ref byte _refReturnTypeForGetNextSpan; // Dummy field
		public void Advance(int count) {} // 0x000000018B2307A0-0x000000018B230828
		private bool TryAdvanceSequence(int count) => default; // 0x000000018B232108-0x000000018B232224
		public void GetRemainingSource(out ReadOnlySpan<byte> singleSource, out ReadOnlySequence<byte> remainingSource) {
			singleSource = default;
			remainingSource = default;
		} // 0x000000018B230C5C-0x000000018B230E70
		public void Dispose() {} // 0x000000018B230828-0x000000018B230898
		public IMemoryPackFormatter GetFormatter(System.Type type) => default; // 0x000000018B230898-0x000000018B2308E0
		public IMemoryPackFormatter<T> GetFormatter<T>() => default;
		public bool TryReadObjectHeader(out byte memberCount) {
			memberCount = default;
			return default;
		} // 0x000000018B23236C-0x000000018B2323AC
		public bool TryReadUnionHeader(out ushort tag) {
			tag = default;
			return default;
		} // 0x000000018B2323AC-0x000000018B232444
		public bool TryReadCollectionHeader(out int length) {
			length = default;
			return default;
		} // 0x000000018B232310-0x000000018B23236C
		public bool PeekIsNull() => default; // 0x000000018B230ED8-0x000000018B230EF4
		public bool TryPeekObjectHeader(out byte memberCount) {
			memberCount = default;
			return default;
		} // 0x000000018B232274-0x000000018B232298
		public bool TryPeekUnionHeader(out ushort tag) {
			tag = default;
			return default;
		} // 0x000000018B232298-0x000000018B2322EC
		public bool TryPeekUshort(out ushort tag) {
			tag = default;
			return default;
		} // 0x000000018B2322EC-0x000000018B232310
		public bool TryPeekCollectionHeader(out int length) {
			length = default;
			return default;
		} // 0x000000018B232224-0x000000018B232274
		public bool DangerousTryReadCollectionHeader(out int length) {
			length = default;
			return default;
		} // 0x000000018B22BEEC-0x000000018B22BF58
		public string ReadString() => default; // 0x000000018B230EF4-0x000000018B230F58
		private string ReadUtf16(int length) => default; // 0x000000018B230F58-0x000000018B231028
		public string ReadUtf8(int utf8Length) => default; // 0x00000001840A5800-0x00000001840A5AB0
		public T1 ReadUnmanaged<T1>()
			where T1 : struct => default;
		public void ReadPackable<T>(ref ref T value)
			where T : IMemoryPackable<T> {}
		public T ReadPackable<T>()
			where T : IMemoryPackable<T> => default;
		public void ReadValue<T>(ref ref T value) {}
		public T ReadValue<T>() => default;
		public void ReadValue(System.Type type, ref object value) {} // 0x000000018B231028-0x000000018B231098
		public object ReadValue(System.Type type) => default; // 0x000000018B231098-0x000000018B23110C
		public void ReadValueWithFormatter<TFormatter, T>(TFormatter formatter, ref ref T value)
			where TFormatter : IMemoryPackFormatter<T> {}
		public T ReadValueWithFormatter<TFormatter, T>(TFormatter formatter)
			where TFormatter : IMemoryPackFormatter<T> => default;
		public T[] ReadArray<T>() => default;
		public void ReadArray<T>(ref ref T[] value) {}
		public void ReadSpan<T>(ref Span<T> value) {}
		public T[] ReadPackableArray<T>()
			where T : IMemoryPackable<T> => default;
		public void ReadPackableArray<T>(ref ref T[] value)
			where T : IMemoryPackable<T> {}
		public void ReadPackableSpan<T>(ref Span<T> value)
			where T : IMemoryPackable<T> {}
		public T[] ReadUnmanagedArray<T>()
			where T : struct => default;
		public void ReadUnmanagedArray<T>(ref ref T[] value)
			where T : struct {}
		public void ReadUnmanagedSpan<T>(ref Span<T> value)
			where T : struct {}
		public T[] DangerousReadUnmanagedArray<T>() => default;
		public void DangerousReadUnmanagedArray<T>(ref ref T[] value) {}
		public void DangerousReadUnmanagedSpan<T>(ref Span<T> value) {}
		public void ReadSpanWithoutReadLengthHeader<T>(int length, ref Span<T> value) {}
		public void ReadPackableSpanWithoutReadLengthHeader<T>(int length, ref Span<T> value)
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
		public void DangerousReadUnmanaged<T1>(out ref T1 value1) {
			value1 = default;
		}
		public void DangerousReadUnmanaged<T1, T2>(out ref T1 value1, out ref T2 value2) {
			value1 = default;
			value2 = default;
		}
		public void DangerousReadUnmanaged<T1, T2, T3>(out ref T1 value1, out ref T2 value2, out ref T3 value3) {
			value1 = default;
			value2 = default;
			value3 = default;
		}
		public void DangerousReadUnmanaged<T1, T2, T3, T4>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
		}
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
		}
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
		}
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7) {
			value1 = default;
			value2 = default;
			value3 = default;
			value4 = default;
			value5 = default;
			value6 = default;
			value7 = default;
		}
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
		public byte ReadVarIntByte() => default; // 0x000000018B23110C-0x000000018B231318
		public sbyte ReadVarIntSByte() => default; // 0x000000018B231908-0x000000018B231B7C
		public ushort ReadVarIntUInt16() => default; // 0x000000018B231B7C-0x000000018B231D84
		public short ReadVarIntInt16() => default; // 0x000000018B231318-0x000000018B23154C
		public uint ReadVarIntUInt32() => default; // 0x000000018B231D84-0x000000018B231F58
		public int ReadVarIntInt32() => default; // 0x000000018B23154C-0x000000018B231734
		public ulong ReadVarIntUInt64() => default; // 0x000000018B231F58-0x000000018B232108
		public long ReadVarIntInt64() => default; // 0x000000018B231734-0x000000018B231908
	}

	public static class MemoryPackReaderOptionalStatePool // TypeDefIndex: 57254
	{
		// Fields
		private static readonly ConcurrentQueue<MemoryPackReaderOptionalState> queue; // 0x00
	
		// Constructors
		static MemoryPackReaderOptionalStatePool() {} // 0x000000018B230588-0x000000018B230614
	
		// Methods
		public static MemoryPackReaderOptionalState Rent(MemoryPackSerializerOptions options) => default; // 0x000000018B230438-0x000000018B23050C
		internal static void Return(MemoryPackReaderOptionalState state) {} // 0x000000018B23050C-0x000000018B230588
	}

	public sealed class MemoryPackReaderOptionalState : IDisposable // TypeDefIndex: 57255
	{
		// Fields
		private readonly Dictionary<uint, object> refToObject; // 0x10
		private MemoryPackSerializerOptions _Options_k__BackingField; // 0x18
	
		// Properties
		public MemoryPackSerializerOptions Options { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		internal MemoryPackReaderOptionalState() {} // 0x0000000184BDC550-0x0000000184BDC5E0
	
		// Methods
		internal void Init(MemoryPackSerializerOptions options) {} // 0x0000000184BDC990-0x0000000184BDCA10
		public object GetObjectReference(uint id) => default; // 0x000000018B2306B4-0x000000018B230754
		public void AddObjectReference(uint id, object value) {} // 0x000000018B230614-0x000000018B2306B4
		public void Reset() {} // 0x0000000184BDCA10-0x0000000184BDCAD0
		void IDisposable.Dispose() {} // 0x000000018B230754-0x000000018B2307A0
	}

	internal static class VarIntCodes // TypeDefIndex: 57256
	{
		// Fields
		public const byte MaxSingleValue = 127; // Metadata: 0x0207D898
		public const sbyte MinSingleValue = 136; // Metadata: 0x0207D899
		public const sbyte Byte = 135; // Metadata: 0x0207D89A
		public const sbyte SByte = 134; // Metadata: 0x0207D89B
		public const sbyte UInt16 = 133; // Metadata: 0x0207D89C
		public const sbyte Int16 = 132; // Metadata: 0x0207D89D
		public const sbyte UInt32 = 131; // Metadata: 0x0207D89E
		public const sbyte Int32 = 130; // Metadata: 0x0207D89F
		public const sbyte UInt64 = 129; // Metadata: 0x0207D8A0
		public const sbyte Int64 = 128; // Metadata: 0x0207D8A1
	}

	public struct MemoryPackWriter // TypeDefIndex: 57257
	{
		// Fields
		private const int DepthLimit = 1000; // Metadata: 0x0207D8A3
		private IBufferWriter<byte> bufferWriter; // 0x00
		private Span<byte> bufferReference; // 0x08
		private int bufferLength; // 0x18
		private int advancedCount; // 0x1C
		private int depth; // 0x20
		private int writtenCount; // 0x24
		private readonly bool serializeStringAsUtf8; // 0x28
		private readonly MemoryPackWriterOptionalState optionalState; // 0x30
	
		// Properties
		public int WrittenCount { get => default; } // 0x0000000181424480-0x0000000181424490 
		public int BufferLength { get => default; } // 0x00000001813AE560-0x00000001813AE570 
		public MemoryPackWriterOptionalState OptionalState { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
		public MemoryPackSerializerOptions Options { get => default; } // 0x000000018B235380-0x000000018B23539C 
	
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
		} // 0x000000018B23533C-0x000000018B235380
		public MemoryPackWriter(ref IBufferWriter<byte> writer, byte[] firstBufferOfWriter, MemoryPackWriterOptionalState optionalState) : this() {
			bufferWriter = default;
			bufferReference = default;
			bufferLength = default;
			advancedCount = default;
			depth = default;
			writtenCount = default;
			serializeStringAsUtf8 = default;
			this.optionalState = default;
		} // 0x000000018B2351F4-0x000000018B2352A4
		public MemoryPackWriter(ref IBufferWriter<byte> writer, Span<byte> firstBufferOfWriter, MemoryPackWriterOptionalState optionalState) : this() {
			bufferWriter = default;
			bufferReference = default;
			bufferLength = default;
			advancedCount = default;
			depth = default;
			writtenCount = default;
			serializeStringAsUtf8 = default;
			this.optionalState = default;
		} // 0x000000018B2352A4-0x000000018B23533C
	
		// Methods
		public void WriteVarInt(byte x) {} // 0x000000018B235050-0x000000018B2350CC
		public void WriteVarInt(sbyte x) {} // 0x000000018B2350CC-0x000000018B235148
		public void WriteVarInt(ushort x) {} // 0x000000018B234C9C-0x000000018B234D1C
		public void WriteVarInt(short x) {} // 0x000000018B234BCC-0x000000018B234C9C
		public void WriteVarInt(uint x) {} // 0x000000018B235148-0x000000018B2351F4
		public void WriteVarInt(int x) {} // 0x000000018B234E00-0x000000018B234EFC
		public void WriteVarInt(ulong x) {} // 0x000000018B234D1C-0x000000018B234E00
		public void WriteVarInt(long x) {} // 0x000000018B234EFC-0x000000018B235050
		public ref byte GetSpanReference(int sizeHint) => ref _refReturnTypeForGetSpanReference; // 0x000000018B234454-0x000000018B2344B8
		private ref byte _refReturnTypeForGetSpanReference; // Dummy field
		private void RequestNewBuffer(int sizeHint) {} // 0x000000018B234570-0x000000018B234604
		public void Advance(int count) {} // 0x000000018B234334-0x000000018B2343A8
		public void Flush() {} // 0x000000018B2343A8-0x000000018B23440C
		public IMemoryPackFormatter GetFormatter(System.Type type) => default; // 0x000000018B23440C-0x000000018B234454
		public IMemoryPackFormatter<T> GetFormatter<T>() => default;
		public int GetStringWriteLength(string value) => default; // 0x000000018B2344B8-0x000000018B234570
		public int GetUnmanageArrayWriteLength<T>(T[] value)
			where T : struct => default;
		public void WriteObjectHeader(byte memberCount) {} // 0x000000018B234660-0x000000018B2346A4
		public void WriteNullObjectHeader() {} // 0x000000018B234638-0x000000018B234660
		public void WriteObjectReferenceId(uint referenceId) {} // 0x000000018B2346A4-0x000000018B2346E4
		public void WriteUnionHeader(ushort tag) {} // 0x000000018B234704-0x000000018B234764
		public void WriteNullUnionHeader() {} // 0x000000018B234638-0x000000018B234660
		public void WriteCollectionHeader(int length) {} // 0x000000018B234604-0x000000018B234638
		public void WriteNullCollectionHeader() {} // 0x000000018B22BF58-0x000000018B22C39C
		public void WriteString(string value) {} // 0x000000018B2346E4-0x000000018B234704
		public void WriteUtf16(string value) {} // 0x000000018B2348A0-0x000000018B2349F4
		public void WriteUtf16(ReadOnlySpan<char> value) {} // 0x000000018B234764-0x000000018B2348A0
		public void WriteUtf8(string value) {} // 0x000000018B2349F4-0x000000018B234B20
		public void WriteUtf8(ReadOnlySpan<byte> utf8Value, int utf16Length = -1 /* Metadata: 0x0207D8A2 */) {} // 0x000000018B234B20-0x000000018B234BCC
		public void WriteUnmanaged<T1>(in ref T1 value1)
			where T1 : struct {}
		public void WriteUnmanagedWithObjectHeader<T1>(byte propertyCount, in ref T1 value1)
			where T1 : struct {}
		public void WriteUnmanaged<T1, T2>(in ref T1 value1, in ref T2 value2)
			where T1 : struct
			where T2 : struct {}
		public void WriteUnmanagedWithObjectHeader<T1, T2>(byte propertyCount, in ref T1 value1, in ref T2 value2)
			where T1 : struct
			where T2 : struct {}
		public void WriteUnmanaged<T1, T2, T3>(in ref T1 value1, in ref T2 value2, in ref T3 value3)
			where T1 : struct
			where T2 : struct
			where T3 : struct {}
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3)
			where T1 : struct
			where T2 : struct
			where T3 : struct {}
		public void WriteUnmanaged<T1, T2, T3, T4>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct {}
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct {}
		public void WriteUnmanaged<T1, T2, T3, T4, T5>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct {}
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct {}
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct {}
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct {}
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct {}
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct {}
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct {}
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct {}
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct {}
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct {}
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10)
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
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10)
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
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11)
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
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11)
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
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12)
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
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12)
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
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12, in ref T13 value13)
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
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12, in ref T13 value13)
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
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12, in ref T13 value13, in ref T14 value14)
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
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12, in ref T13 value13, in ref T14 value14)
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
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12, in ref T13 value13, in ref T14 value14, in ref T15 value15)
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
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12, in ref T13 value13, in ref T14 value14, in ref T15 value15)
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
		public void DangerousWriteUnmanaged<T1>(in ref T1 value1) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1>(byte propertyCount, in ref T1 value1) {}
		public void DangerousWriteUnmanaged<T1, T2>(in ref T1 value1, in ref T2 value2) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2>(byte propertyCount, in ref T1 value1, in ref T2 value2) {}
		public void DangerousWriteUnmanaged<T1, T2, T3>(in ref T1 value1, in ref T2 value2, in ref T3 value3) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12, in ref T13 value13) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12, in ref T13 value13) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12, in ref T13 value13, in ref T14 value14) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12, in ref T13 value13, in ref T14 value14) {}
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12, in ref T13 value13, in ref T14 value14, in ref T15 value15) {}
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(byte propertyCount, in ref T1 value1, in ref T2 value2, in ref T3 value3, in ref T4 value4, in ref T5 value5, in ref T6 value6, in ref T7 value7, in ref T8 value8, in ref T9 value9, in ref T10 value10, in ref T11 value11, in ref T12 value12, in ref T13 value13, in ref T14 value14, in ref T15 value15) {}
	}

	public class MemoryPackSerializationException : Exception // TypeDefIndex: 57258
	{
		// Constructors
		public MemoryPackSerializationException() {} // Dummy constructor
		public MemoryPackSerializationException(string message) {} // 0x0000000184A91710-0x0000000184A91780
		public MemoryPackSerializationException(string message, Exception innerException) {} // 0x000000018B233038-0x000000018B233098
	
		// Methods
		public static void ThrowMessage(string message) {} // 0x000000018B232C40-0x000000018B232C98
		public static void ThrowInvalidPropertyCount(byte expected, byte actual) {} // 0x000000018B232A2C-0x000000018B232AE0
		public static void ThrowInvalidPropertyCount(System.Type type, byte expected, byte actual) {} // 0x0000000183FAE110-0x0000000183FAE240
		public static void ThrowInvalidCollection() {} // 0x000000018B232974-0x000000018B2329D0
		public static void ThrowInvalidRange(int expected, int actual) {} // 0x000000018B232AE0-0x000000018B232B94
		public static void ThrowInvalidAdvance() {} // 0x000000018B232918-0x000000018B232974
		public static void ThrowSequenceReachedEnd() {} // 0x000000018B232F4C-0x000000018B232FA8
		public static void ThrowWriteInvalidMemberCount(byte memberCount) {} // 0x000000018B232FA8-0x000000018B233038
		public static void ThrowInsufficientBufferUnless(int length) {} // 0x000000018B232888-0x000000018B232918
		public static void ThrowNotRegisteredInProvider(System.Type type) {} // 0x000000018B232DC4-0x000000018B232E48
		public static void ThrowRegisterInProviderFailed(System.Type type, Exception innerException) {} // 0x000000018B232EBC-0x000000018B232F4C
		public static void ThrowNotFoundInUnionType(System.Type actualType, System.Type baseType) {} // 0x000000018B232C98-0x000000018B232DC4
		public static void ThrowInvalidTag(ushort tag, System.Type baseType) {} // 0x000000018B232B94-0x000000018B232C40
		public static void ThrowReachedDepthLimit(System.Type type) {} // 0x000000018B232E48-0x000000018B232EBC
		public static void ThrowInvalidConcurrrentCollectionOperation() {} // 0x000000018B2329D0-0x000000018B232A2C
		public static void ThrowDeserializeObjectIsNull(string target) {} // 0x000000018B232774-0x000000018B2327F8
		public static void ThrowFailedEncoding(OperationStatus status) {} // 0x000000018B2327F8-0x000000018B232888
		public static void ThrowCompressionFailed(OperationStatus status) {} // 0x000000018B232630-0x000000018B2326C0
		public static void ThrowCompressionFailed() {} // 0x000000018B2325D4-0x000000018B232630
		public static void ThrowAlreadyDecompressed() {} // 0x000000018B232578-0x000000018B2325D4
		public static void ThrowDecompressionSizeLimitExceeded(int limit, int size) {} // 0x000000018B2326C0-0x000000018B232774
	}

	public static class MemoryPackSerializer // TypeDefIndex: 57262
	{
		// Fields
		private static MemoryPackReaderOptionalState threadStaticReaderOptionalState; // 0x80000000
		private static SerializerWriterThreadStaticState threadStaticState; // 0x80000008
		private static MemoryPackWriterOptionalState threadStaticWriterOptionalState; // 0x80000010
	
		// Nested types
		private sealed class SerializerWriterThreadStaticState // TypeDefIndex: 57259
		{
			// Fields
			public ReusableLinkedArrayBufferWriter BufferWriter; // 0x10
			public MemoryPackWriterOptionalState OptionalState; // 0x18
	
			// Constructors
			public SerializerWriterThreadStaticState() {}
	
			// Methods
			public void Init(MemoryPackSerializerOptions options) {}
			public void Reset() {}
		}
	
		private struct _DeserializeAsync_d__6<T> : IAsyncStateMachine // TypeDefIndex: 57260
		{
			// Fields
			public int __1__state;
			public AsyncValueTaskMethodBuilder<T> __t__builder;
			public Stream stream;
			public CancellationToken cancellationToken;
			public MemoryPackSerializerOptions options;
			private ReusableReadOnlySequenceBuilder _builder_5__2;
			private byte[] _buffer_5__3;
			private int _offset_5__4;
			private ConfiguredValueTaskAwaitable<int> __u__1;
	
			// Methods
			private void MoveNext() {}
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018B2336E4-0x000000018B23390C
		}
	
		private struct _DeserializeAsync_d__11 : IAsyncStateMachine // TypeDefIndex: 57261
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncValueTaskMethodBuilder<object> __t__builder; // 0x08
			public Stream stream; // 0x30
			public CancellationToken cancellationToken; // 0x38
			public System.Type type; // 0x40
			public MemoryPackSerializerOptions options; // 0x48
			private ReusableReadOnlySequenceBuilder _builder_5__2; // 0x50
			private byte[] _buffer_5__3; // 0x58
			private int _offset_5__4; // 0x60
			private ConfiguredValueTaskAwaitable<int> __u__1; // 0x68
	
			// Methods
			private void MoveNext() {}
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018B2336B0-0x000000018B2336E4
		}
	
		// Methods
		public static T Deserialize<T>(ReadOnlySpan<byte> buffer, MemoryPackSerializerOptions options = null) => default; // 0x000000018B233B88-0x000000018B233D98
		public static int Deserialize<T>(ReadOnlySpan<byte> buffer, ref ref T value, MemoryPackSerializerOptions options = null) => default; // 0x000000018B23390C-0x000000018B233934
		public static T Deserialize<T>(in ReadOnlySequence<byte> buffer, MemoryPackSerializerOptions options = null) => default; // 0x000000018B233934-0x000000018B233B88
		public static int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref ref T value, MemoryPackSerializerOptions options = null) => default; // 0x000000018B233588-0x000000018B2336B0
		public static int Deserialize(in ReadOnlySequence<byte> buffer, ref object value, System.Type type, MemoryPackSerializerOptions options = null) => default; // 0x000000018B236E80-0x000000018B236F24
		public static ValueTask<T> DeserializeAsync<T>(Stream stream, MemoryPackSerializerOptions options = null, CancellationToken cancellationToken = default) => default; // 0x000000018B236E2C-0x000000018B236E4C
		public static object Deserialize(System.Type type, ReadOnlySpan<byte> buffer, MemoryPackSerializerOptions options = null) => default; // 0x000000018B236E4C-0x000000018B236E80
		public static int Deserialize(System.Type type, ReadOnlySpan<byte> buffer, ref object value, MemoryPackSerializerOptions options = null) => default;
		public static object Deserialize(System.Type type, in ReadOnlySequence<byte> buffer, MemoryPackSerializerOptions options = null) => default;
		public static int Deserialize(System.Type type, in ReadOnlySequence<byte> buffer, ref object value, MemoryPackSerializerOptions options = null) => default; // 0x000000018B238758-0x000000018B239264
		public static ValueTask<object> DeserializeAsync(System.Type type, Stream stream, MemoryPackSerializerOptions options = null, CancellationToken cancellationToken = default) => default; // 0x000000018B239264-0x000000018B2392B0
	}

	public class MemoryPackSerializerOptions : IEquatable<MemoryPackSerializerOptions> // TypeDefIndex: 57263
	{
		// Fields
		public static readonly MemoryPackSerializerOptions Default; // 0x00
		public static readonly MemoryPackSerializerOptions Utf8; // 0x08
		public static readonly MemoryPackSerializerOptions Utf16; // 0x10
		private readonly StringEncoding _StringEncoding_k__BackingField; // 0x10
		private readonly IServiceProvider _ServiceProvider_k__BackingField; // 0x18
	
		// Properties
		protected virtual System.Type EqualityContract { get => default; } // 0x000000018B2334CC-0x000000018B23351C 
		public StringEncoding StringEncoding { get; set; } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
		public IServiceProvider ServiceProvider { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		protected MemoryPackSerializerOptions(MemoryPackSerializerOptions original) {} // 0x0000000185BA4F80-0x0000000185BA4FB0
		public MemoryPackSerializerOptions() {} // 0x0000000185492010-0x0000000185492020
		static MemoryPackSerializerOptions() {} // 0x0000000185BA4E10-0x0000000185BA4F20
	
		// Methods
		public override string ToString() => default; // 0x000000018B2333DC-0x000000018B2334CC
		protected virtual bool PrintMembers(StringBuilder builder) => default; // 0x000000018B2332CC-0x000000018B2333DC
		public static bool operator !=(MemoryPackSerializerOptions r1, MemoryPackSerializerOptions r2) => default; // 0x000000018B233534-0x000000018B233588
		public static bool operator ==(MemoryPackSerializerOptions r1, MemoryPackSerializerOptions r2) => default; // 0x000000018B23351C-0x000000018B233534
		public override int GetHashCode() => default; // 0x000000018B2331D4-0x000000018B2332CC
		public override bool Equals(object obj) => default; // 0x000000018B233098-0x000000018B2330EC
		public virtual bool Equals(MemoryPackSerializerOptions other) => default; // 0x000000018B2330EC-0x000000018B2331D4
		public virtual MemoryPackSerializerOptions _Clone__() => default; // 0x0000000185BA4F20-0x0000000185BA4F80
	}

	public enum StringEncoding : byte // TypeDefIndex: 57264
	{
		Utf16 = 0,
		Utf8 = 1
	}

	public static class MemoryPackWriterOptionalStatePool // TypeDefIndex: 57265
	{
		// Fields
		private static readonly ConcurrentQueue<MemoryPackWriterOptionalState> queue; // 0x00
	
		// Constructors
		static MemoryPackWriterOptionalStatePool() {} // 0x000000018B233EFC-0x000000018B233F88
	
		// Methods
		public static MemoryPackWriterOptionalState Rent(MemoryPackSerializerOptions options) => default; // 0x000000018B233DAC-0x000000018B233E80
		internal static void Return(MemoryPackWriterOptionalState state) {} // 0x000000018B233E80-0x000000018B233EFC
	}

	public sealed class MemoryPackWriterOptionalState : IDisposable // TypeDefIndex: 57267
	{
		// Fields
		internal static readonly MemoryPackWriterOptionalState NullState; // 0x00
		private uint nextId; // 0x10
		private readonly Dictionary<object, uint> objectToRef; // 0x18
		private MemoryPackSerializerOptions _Options_k__BackingField; // 0x20
	
		// Properties
		public MemoryPackSerializerOptions Options { get; private set; } // 0x000000018B2340CC-0x000000018B234124 0x000000018B233F88-0x000000018B23405C
	
		// Nested types
		private sealed class ReferenceEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 57266
		{
			// Fields
			private static readonly ReferenceEqualityComparer _Instance_k__BackingField; // 0x00
	
			// Properties
			public static ReferenceEqualityComparer Instance { get; } // 0x000000018646EE40-0x000000018646EE50 
	
			// Constructors
			private ReferenceEqualityComparer() {} // 0x00000001813B31A0-0x00000001813B31B0
			static ReferenceEqualityComparer() {} // 0x000000018B23405C-0x000000018B2340CC
	
			// Methods
			public new bool Equals(object x, object y) => default; // 0x000000018B2341E4-0x000000018B2342CC
			public int GetHashCode(object obj) => default; // 0x000000018B2342CC-0x000000018B234334
		}
	
		// Constructors
		internal MemoryPackWriterOptionalState() {} // 0x000000018B234124-0x000000018B234170
		private MemoryPackWriterOptionalState(bool _) {} // 0x000000018B234170-0x000000018B2341E4
		static MemoryPackWriterOptionalState() {} // 0x000000018B235504-0x000000018B235568
	
		// Methods
		internal void Init(MemoryPackSerializerOptions options) {} // 0x0000000185492010-0x0000000185492020
		public void Reset() {} // 0x000000018B235568-0x000000018B2355B8
		public ValueTuple<bool, uint> GetOrAddReference(object value) => default; // 0x0000000188F44660-0x0000000188F44668
		void IDisposable.Dispose() {} // 0x0000000185FCF280-0x0000000185FCF290
	}

	internal sealed class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve> // TypeDefIndex: 57268
	{
		// Constructors
		public AnimationCurveFormatter() {} // 0x0000000184699E20-0x0000000184699E50
	
		// Methods
		private void SerializeKeyFrame(Keyframe keyframe, ref MemoryPackWriter writer) {} // 0x000000018B22C4C4-0x000000018B22C590
		private void DeserializeKeyFrame(ref MemoryPackReader reader, out Keyframe keyframe) {
			keyframe = default;
		} // 0x0000000184714950-0x0000000184714A70
		public override void Deserialize(ref MemoryPackReader reader, ref AnimationCurve value) {} // 0x0000000184714270-0x00000001847147D0
	}

	internal sealed class GradientFormatter : MemoryPackFormatter<Gradient> // TypeDefIndex: 57269
	{
		// Constructors
		public GradientFormatter() {} // 0x0000000184699DF0-0x0000000184699E20
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Gradient value) {} // 0x000000018B22F3A0-0x000000018B22F4FC
	}

	internal sealed class RectOffsetFormatter : MemoryPackFormatter<RectOffset> // TypeDefIndex: 57270
	{
		// Constructors
		public RectOffsetFormatter() {} // 0x0000000184699DC0-0x0000000184699DF0
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref RectOffset value) {} // 0x000000018B2353B0-0x000000018B235504
	}
}

namespace MemoryPack.Compression
{
	public sealed class BitPackFormatter : MemoryPackFormatter<bool[]> // TypeDefIndex: 57377
	{
		// Fields
		public static readonly BitPackFormatter Default; // 0x00
	
		// Constructors
		public BitPackFormatter() {} // 0x000000018B22C9D0-0x000000018B22C9F8
		static BitPackFormatter() {} // 0x000000018B22C960-0x000000018B22C9D0
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref bool[] value) {} // 0x000000018B22C7A0-0x000000018B22C924
		public bool Get(int data, int index) => default; // 0x000000018B22C924-0x000000018B22C93C
		public void Set(ref int data, int index, bool value) {} // 0x000000018B22C93C-0x000000018B22C960
	}

	public class BrotliCompressor : IBufferWriter<byte>, IDisposable // TypeDefIndex: 57379
	{
		// Fields
		private ReusableLinkedArrayBufferWriter bufferWriter; // 0x10
		private readonly int quality; // 0x18
		private readonly int window; // 0x1C
	
		// Nested types
		private struct _CopyToAsync_d__11 : IAsyncStateMachine // TypeDefIndex: 57378
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncValueTaskMethodBuilder __t__builder; // 0x08
			public BrotliCompressor __4__this; // 0x28
			public int bufferSize; // 0x30
			public Stream stream; // 0x38
			public CancellationToken cancellationToken; // 0x40
			private BrotliEncoder _encoder_5__2; // 0x48
			private byte[] _buffer_5__3; // 0x58
			private ReusableLinkedArrayBufferWriter.Enumerator __7__wrap3; // 0x60
			private Memory<byte> _source_5__5; // 0xA0
			private OperationStatus _lastResult_5__6; // 0xB0
			private int _bytesConsumed_5__7; // 0xB4
			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter __u__1; // 0xB8
	
			// Methods
			private void MoveNext() {} // 0x000000018B22DB48-0x000000018B22DB74
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018B22DAA4-0x000000018B22DADC
		}
	
		// Constructors
		public BrotliCompressor() {} // Dummy constructor
		public BrotliCompressor(CompressionLevel compressionLevel) {} // 0x000000018B22DADC-0x000000018B22DB48
		public BrotliCompressor(CompressionLevel compressionLevel, int window) {} // 0x000000018B22D428-0x000000018B22D470
		public BrotliCompressor(int quality = 1 /* Metadata: 0x0207D8C1 */, int window = 22 /* Metadata: 0x0207D8C2 */) {} // 0x000000018B22D470-0x000000018B22D4AC
	
		// Methods
		void IBufferWriter<byte>.Advance(int count) {} // 0x000000018B22D4AC-0x000000018B22D508
		Memory<byte> IBufferWriter<byte>.GetMemory(int sizeHint) => default; // 0x000000018B22D564-0x000000018B22DAA4
		Span<byte> IBufferWriter<byte>.GetSpan(int sizeHint) => default; // 0x000000018B22CE20-0x000000018B22D0F4
		public byte[] ToArray() => default; // 0x000000018B22CD2C-0x000000018B22CE20
		public void CopyTo(in IBufferWriter<byte> destBufferWriter) {} // 0x000000018B22D0F4-0x000000018B22D3BC
		public ValueTask CopyToAsync(Stream stream, int bufferSize = 65535 /* Metadata: 0x0207D8C3 */, CancellationToken cancellationToken = default) => default; // 0x000000018B22C9F8-0x000000018B22CB78
		public void CopyTo(ref MemoryPackWriter memoryPackWriter) {} // 0x000000018B22CB78-0x000000018B22CD2C
		private static int CompressCore(ref BrotliEncoder encoder, ReadOnlySpan<byte> source, ref IBufferWriter<byte> destBufferWriter, int? initialLength, bool isFinalBlock) => default; // 0x000000018B22D3BC-0x000000018B22D428
		private static int CompressCore(ref BrotliEncoder encoder, ReadOnlySpan<byte> source, ref MemoryPackWriter destBufferWriter, int? initialLength, bool isFinalBlock) => default; // 0x000000018B22D508-0x000000018B22D564
		public void Dispose() {} // 0x000000018B237A1C-0x000000018B23874C
		private void ThrowIfDisposed() {} // 0x000000018B23874C-0x000000018B238758
	}

	internal static class BrotliUtils // TypeDefIndex: 57380
	{
		// Fields
		public const int WindowBits_Min = 10; // Metadata: 0x0207D8C7
		public const int WindowBits_Default = 22; // Metadata: 0x0207D8C8
		public const int WindowBits_Max = 24; // Metadata: 0x0207D8C9
		public const int Quality_Min = 0; // Metadata: 0x0207D8CA
		public const int Quality_Default = 4; // Metadata: 0x0207D8CB
		public const int Quality_Max = 11; // Metadata: 0x0207D8CC
		public const int MaxInputSize = 2147483132; // Metadata: 0x0207D8CD
	
		// Methods
		internal static int GetQualityFromCompressionLevel(CompressionLevel compressionLevel) => default; // 0x000000018B22ECA8-0x000000018B22ED20
		internal static int BrotliEncoderMaxCompressedSize(int input_size) => default; // 0x000000018B22EC88-0x000000018B22ECA8
	}

	public struct BrotliDecompressor : IDisposable // TypeDefIndex: 57381
	{
		// Fields
		private ReusableReadOnlySequenceBuilder sequenceBuilder; // 0x00
	
		// Methods
		public ReadOnlySequence<byte> Decompress(ReadOnlySpan<byte> compressedSpan) => default; // 0x000000018B22E1F4-0x000000018B22E23C
		public ReadOnlySequence<byte> Decompress(ReadOnlySpan<byte> compressedSpan, out int consumed) {
			consumed = default;
			return default;
		} // 0x000000018B22E084-0x000000018B22E1F4
		public ReadOnlySequence<byte> Decompress(ReadOnlySequence<byte> compressedSequence) => default; // 0x000000018B22E23C-0x000000018B22E290
		public ReadOnlySequence<byte> Decompress(ReadOnlySequence<byte> compressedSequence, out int consumed) {
			consumed = default;
			return default;
		} // 0x000000018B22DDE0-0x000000018B22E084
		private void DecompressCore(ref OperationStatus status, ref BrotliDecoder decoder, ReadOnlySpan<byte> source, out int consumed) {
			consumed = default;
		} // 0x000000018B22DB74-0x000000018B22DDE0
		public void Dispose() {} // 0x000000018B22E290-0x000000018B22E2F0
		private int GetDoubleCapacity(int length) => default; // 0x000000018B22E2F0-0x000000018B22E33C
	}

	public sealed class BrotliFormatter : MemoryPackFormatter<byte[]> // TypeDefIndex: 57382
	{
		// Fields
		internal const int DefaultDecompssionSizeLimit = 134217728; // Metadata: 0x0207D8D2
		public static readonly BrotliFormatter Default; // 0x00
		private readonly CompressionLevel compressionLevel; // 0x10
		private readonly int window; // 0x14
		private readonly int decompressionSizeLimit; // 0x18
	
		// Constructors
		public BrotliFormatter() {} // 0x000000018B22E608-0x000000018B22E61C
		public BrotliFormatter(CompressionLevel compressionLevel) {} // 0x000000018B22E678-0x000000018B22E688
		public BrotliFormatter(CompressionLevel compressionLevel, int window) {} // 0x000000018B22E5E8-0x000000018B22E608
		public BrotliFormatter(CompressionLevel compressionLevel, int window, int decompressionSizeLimit) {} // 0x000000018B22E61C-0x000000018B22E678
		static BrotliFormatter() {} // 0x000000018B22E578-0x000000018B22E5E8
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref byte[] value) {} // 0x000000018B22E33C-0x000000018B22E578
	}

	public sealed class BrotliFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 57383
	{
		// Fields
		internal const int DefaultDecompssionSizeLimit = 134217728; // Metadata: 0x0207D8D6
		public static readonly BrotliFormatter Default;
		private readonly CompressionLevel compressionLevel;
		private readonly int window;
	
		// Constructors
		public BrotliFormatter() {}
		public BrotliFormatter(CompressionLevel compressionLevel) {}
		public BrotliFormatter(CompressionLevel compressionLevel, int window) {}
		static BrotliFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value) {}
	}
}

namespace MemoryPack.Formatters
{
	public sealed class UnmanagedArrayFormatter<T> : MemoryPackFormatter<T[]> // TypeDefIndex: 57288
		where T : struct
	{
		// Constructors
		public UnmanagedArrayFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ref T[] value) {}
	}

	public sealed class DangerousUnmanagedArrayFormatter<T> : MemoryPackFormatter<T[]> // TypeDefIndex: 57289
	{
		// Constructors
		public DangerousUnmanagedArrayFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ref T[] value) {}
	}

	public sealed class ArrayFormatter<T> : MemoryPackFormatter<T[]> // TypeDefIndex: 57290
	{
		// Constructors
		public ArrayFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ref T[] value) {}
	}

	public sealed class ArraySegmentFormatter<T> : MemoryPackFormatter<ArraySegment<T>> // TypeDefIndex: 57291
	{
		// Constructors
		public ArraySegmentFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ArraySegment<T> value) {}
	}

	public sealed class MemoryFormatter<T> : MemoryPackFormatter<Memory<T>> // TypeDefIndex: 57292
	{
		// Constructors
		public MemoryFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Memory<T> value) {}
	}

	public sealed class ReadOnlyMemoryFormatter<T> : MemoryPackFormatter<ReadOnlyMemory<T>> // TypeDefIndex: 57293
	{
		// Constructors
		public ReadOnlyMemoryFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ReadOnlyMemory<T> value) {}
	}

	public sealed class ReadOnlySequenceFormatter<T> : MemoryPackFormatter<ReadOnlySequence<T>> // TypeDefIndex: 57294
	{
		// Constructors
		public ReadOnlySequenceFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ReadOnlySequence<T> value) {}
	}

	public sealed class MemoryPoolFormatter<T> : MemoryPackFormatter<Memory<T>> // TypeDefIndex: 57295
	{
		// Constructors
		public MemoryPoolFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Memory<T> value) {}
	}

	public sealed class ReadOnlyMemoryPoolFormatter<T> : MemoryPackFormatter<ReadOnlyMemory<T>> // TypeDefIndex: 57296
	{
		// Constructors
		public ReadOnlyMemoryPoolFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ReadOnlyMemory<T> value) {}
	}

	public sealed class BigIntegerFormatter : MemoryPackFormatter<BigInteger> // TypeDefIndex: 57297
	{
		// Constructors
		public BigIntegerFormatter() {} // 0x0000000185FAB970-0x0000000185FAB9A0
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref BigInteger value) {} // 0x000000018B22C590-0x000000018B22C6B4
	}

	public sealed class BitArrayFormatter : MemoryPackFormatter<BitArray> // TypeDefIndex: 57298
	{
		// Constructors
		public BitArrayFormatter() {} // 0x0000000185FAB940-0x0000000185FAB970
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref BitArray value) {} // 0x000000018B22C6B4-0x000000018B22C7A0
	}

	internal class BitArrayView // TypeDefIndex: 57299
	{
		// Fields
		public int[] m_array; // 0x10
		public int m_length; // 0x18
		public int _version; // 0x1C
	
		// Constructors
		public BitArrayView() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class ListFormatter // TypeDefIndex: 57300
	{
		// Methods
		public static List<T> DeserializePackable<T>(ref MemoryPackReader reader)
			where T : IMemoryPackable<T> => default;
		public static void DeserializePackable<T>(ref MemoryPackReader reader, ref List<T> value)
			where T : IMemoryPackable<T> {}
	}

	public sealed class ListFormatter<T> : MemoryPackFormatter<List<T>> // TypeDefIndex: 57301
	{
		// Constructors
		public ListFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref List<T> value) {}
	}

	public sealed class StackFormatter<T> : MemoryPackFormatter<Stack<T>> // TypeDefIndex: 57302
	{
		// Constructors
		public StackFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Stack<T> value) {}
	}

	public sealed class QueueFormatter<T> : MemoryPackFormatter<Queue<T>> // TypeDefIndex: 57303
	{
		// Constructors
		public QueueFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Queue<T> value) {}
	}

	public sealed class LinkedListFormatter<T> : MemoryPackFormatter<LinkedList<T>> // TypeDefIndex: 57304
	{
		// Constructors
		public LinkedListFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref LinkedList<T> value) {}
	}

	public sealed class HashSetFormatter<T> : MemoryPackFormatter<HashSet<T>> // TypeDefIndex: 57305
	{
		// Fields
		private readonly IEqualityComparer<T> equalityComparer;
	
		// Constructors
		public HashSetFormatter() {}
		public HashSetFormatter(IEqualityComparer<T> equalityComparer) {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref HashSet<T> value) {}
	}

	public sealed class SortedSetFormatter<T> : MemoryPackFormatter<SortedSet<T>> // TypeDefIndex: 57306
	{
		// Fields
		private readonly IComparer<T> comparer;
	
		// Constructors
		public SortedSetFormatter() {}
		public SortedSetFormatter(IComparer<T> comparer) {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref SortedSet<T> value) {}
	}

	public sealed class CollectionFormatter<T> : MemoryPackFormatter<Collection<T>> // TypeDefIndex: 57307
	{
		// Constructors
		public CollectionFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Collection<T> value) {}
	}

	public sealed class ObservableCollectionFormatter<T> : MemoryPackFormatter<ObservableCollection<T>> // TypeDefIndex: 57308
	{
		// Constructors
		public ObservableCollectionFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ObservableCollection<T> value) {}
	}

	public sealed class ConcurrentQueueFormatter<T> : MemoryPackFormatter<ConcurrentQueue<T>> // TypeDefIndex: 57309
	{
		// Constructors
		public ConcurrentQueueFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ConcurrentQueue<T> value) {}
	}

	public sealed class ConcurrentStackFormatter<T> : MemoryPackFormatter<ConcurrentStack<T>> // TypeDefIndex: 57310
	{
		// Constructors
		public ConcurrentStackFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ConcurrentStack<T> value) {}
	}

	public sealed class ConcurrentBagFormatter<T> : MemoryPackFormatter<ConcurrentBag<T>> // TypeDefIndex: 57311
	{
		// Constructors
		public ConcurrentBagFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ConcurrentBag<T> value) {}
	}

	public sealed class DictionaryFormatter<TKey, TValue> : MemoryPackFormatter<Dictionary<TKey, TValue>> // TypeDefIndex: 57312
	{
		// Fields
		private readonly IEqualityComparer<TKey> equalityComparer;
	
		// Constructors
		public DictionaryFormatter() {}
		public DictionaryFormatter(IEqualityComparer<TKey> equalityComparer) {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Dictionary<TKey, TValue> value) {}
	}

	public sealed class SortedDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<SortedDictionary<TKey, TValue>> // TypeDefIndex: 57313
	{
		// Fields
		private readonly IComparer<TKey> comparer;
	
		// Constructors
		public SortedDictionaryFormatter() {}
		public SortedDictionaryFormatter(IComparer<TKey> comparer) {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref SortedDictionary<TKey, TValue> value) {}
	}

	public sealed class SortedListFormatter<TKey, TValue> : MemoryPackFormatter<SortedList<TKey, TValue>> // TypeDefIndex: 57314
	{
		// Fields
		private readonly IComparer<TKey> comparer;
	
		// Constructors
		public SortedListFormatter() {}
		public SortedListFormatter(IComparer<TKey> comparer) {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref SortedList<TKey, TValue> value) {}
	}

	public sealed class ConcurrentDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<ConcurrentDictionary<TKey, TValue>> // TypeDefIndex: 57315
	{
		// Fields
		private readonly IEqualityComparer<TKey> equalityComparer;
	
		// Constructors
		public ConcurrentDictionaryFormatter() {}
		public ConcurrentDictionaryFormatter(IEqualityComparer<TKey> equalityComparer) {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ConcurrentDictionary<TKey, TValue> value) {}
	}

	public sealed class ReadOnlyCollectionFormatter<T> : MemoryPackFormatter<ReadOnlyCollection<T>> // TypeDefIndex: 57316
	{
		// Constructors
		public ReadOnlyCollectionFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ReadOnlyCollection<T> value) {}
	}

	public sealed class ReadOnlyObservableCollectionFormatter<T> : MemoryPackFormatter<ReadOnlyObservableCollection<T>> // TypeDefIndex: 57317
	{
		// Constructors
		public ReadOnlyObservableCollectionFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ReadOnlyObservableCollection<T> value) {}
	}

	public sealed class BlockingCollectionFormatter<T> : MemoryPackFormatter<BlockingCollection<T>> // TypeDefIndex: 57318
	{
		// Constructors
		public BlockingCollectionFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref BlockingCollection<T> value) {}
	}

	public sealed class CultureInfoFormatter : MemoryPackFormatter<CultureInfo> // TypeDefIndex: 57319
	{
		// Constructors
		public CultureInfoFormatter() {} // 0x0000000185FAB790-0x0000000185FAB7C0
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref CultureInfo value) {} // 0x000000018B22EF38-0x000000018B22EFB0
	}

	public sealed class DynamicUnionFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 57321
		where T : class
	{
		// Fields
		private readonly Dictionary<System.Type, ushort> typeToTag;
		private readonly Dictionary<ushort, System.Type> tagToType;
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 57320
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<ValueTuple<ushort, System.Type>, System.Type> __9__2_0;
			public static Func<ValueTuple<ushort, System.Type>, ushort> __9__2_1;
			public static Func<ValueTuple<ushort, System.Type>, ushort> __9__2_2;
			public static Func<ValueTuple<ushort, System.Type>, System.Type> __9__2_3;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal System.Type _.ctor_b__2_0(ValueTuple<ushort, System.Type> x) => default;
			internal ushort _.ctor_b__2_1(ValueTuple<ushort, System.Type> x) => default;
			internal ushort _.ctor_b__2_2(ValueTuple<ushort, System.Type> x) => default;
			internal System.Type _.ctor_b__2_3(ValueTuple<ushort, System.Type> x) => default;
		}
	
		// Constructors
		public DynamicUnionFormatter() {} // Dummy constructor
		public DynamicUnionFormatter(ValueTuple<ushort, System.Type>[] memoryPackUnions) {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value) {}
	}

	public sealed class GenericCollectionFormatter<TCollection, TElement> : MemoryPackFormatter<TCollection> // TypeDefIndex: 57322
		where TCollection : ICollection<TElement>, new()
	{
		// Constructors
		public GenericCollectionFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ref TCollection value) {}
	}

	public abstract class GenericSetFormatterBase<TSet, TElement> : MemoryPackFormatter<TSet> // TypeDefIndex: 57323
		where TSet : ISet<TElement>
	{
		// Constructors
		protected GenericSetFormatterBase() {}
	
		// Methods
		protected abstract TSet CreateSet();
		public override void Deserialize(ref MemoryPackReader reader, ref ref TSet value) {}
	}

	public sealed class GenericSetFormatter<TSet, TElement> : GenericSetFormatterBase<TSet, TElement> // TypeDefIndex: 57324
		where TSet : ISet<TElement>, new()
	{
		// Constructors
		public GenericSetFormatter() {}
	
		// Methods
		protected override TSet CreateSet() => default;
	}

	public abstract class GenericDictionaryFormatterBase<TDictionary, TKey, TValue> : MemoryPackFormatter<TDictionary> // TypeDefIndex: 57325
		where TDictionary : IDictionary<TKey, TValue>
	{
		// Constructors
		protected GenericDictionaryFormatterBase() {}
	
		// Methods
		protected abstract TDictionary CreateDictionary();
		public override void Deserialize(ref MemoryPackReader reader, ref ref TDictionary value) {}
	}

	public sealed class GenericDictionaryFormatter<TDictionary, TKey, TValue> : GenericDictionaryFormatterBase<TDictionary, TKey, TValue> // TypeDefIndex: 57326
		where TDictionary : IDictionary<TKey, TValue>, new()
	{
		// Constructors
		public GenericDictionaryFormatter() {}
	
		// Methods
		protected override TDictionary CreateDictionary() => default;
	}

	internal static class InterfaceCollectionFormatterUtils // TypeDefIndex: 57327
	{
		// Methods
		public static List<T> ReadList<T>(ref MemoryPackReader reader) => default;
	}

	public sealed class InterfaceEnumerableFormatter<T> : MemoryPackFormatter<IEnumerable<T>> // TypeDefIndex: 57328
	{
		// Constructors
		public InterfaceEnumerableFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref IEnumerable<T> value) {}
	}

	public sealed class InterfaceCollectionFormatter<T> : MemoryPackFormatter<ICollection<T>> // TypeDefIndex: 57329
	{
		// Constructors
		static InterfaceCollectionFormatter() {}
		public InterfaceCollectionFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ICollection<T> value) {}
	}

	public sealed class InterfaceReadOnlyCollectionFormatter<T> : MemoryPackFormatter<IReadOnlyCollection<T>> // TypeDefIndex: 57330
	{
		// Constructors
		static InterfaceReadOnlyCollectionFormatter() {}
		public InterfaceReadOnlyCollectionFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref IReadOnlyCollection<T> value) {}
	}

	public sealed class InterfaceListFormatter<T> : MemoryPackFormatter<IList<T>> // TypeDefIndex: 57331
	{
		// Constructors
		static InterfaceListFormatter() {}
		public InterfaceListFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref IList<T> value) {}
	}

	public sealed class InterfaceReadOnlyListFormatter<T> : MemoryPackFormatter<IReadOnlyList<T>> // TypeDefIndex: 57332
	{
		// Constructors
		static InterfaceReadOnlyListFormatter() {}
		public InterfaceReadOnlyListFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref IReadOnlyList<T> value) {}
	}

	public sealed class InterfaceDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<IDictionary<TKey, TValue>> // TypeDefIndex: 57333
	{
		// Fields
		private readonly IEqualityComparer<TKey> equalityComparer;
	
		// Constructors
		public InterfaceDictionaryFormatter() {}
		public InterfaceDictionaryFormatter(IEqualityComparer<TKey> equalityComparer) {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref IDictionary<TKey, TValue> value) {}
	}

	public sealed class InterfaceReadOnlyDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<IReadOnlyDictionary<TKey, TValue>> // TypeDefIndex: 57334
	{
		// Fields
		private readonly IEqualityComparer<TKey> equalityComparer;
	
		// Constructors
		public InterfaceReadOnlyDictionaryFormatter() {}
		public InterfaceReadOnlyDictionaryFormatter(IEqualityComparer<TKey> equalityComparer) {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref IReadOnlyDictionary<TKey, TValue> value) {}
	}

	public sealed class InterfaceLookupFormatter<TKey, TElement> : MemoryPackFormatter<ILookup<TKey, TElement>> // TypeDefIndex: 57335
	{
		// Fields
		private readonly IEqualityComparer<TKey> equalityComparer;
	
		// Constructors
		static InterfaceLookupFormatter() {}
		public InterfaceLookupFormatter() {}
		public InterfaceLookupFormatter(IEqualityComparer<TKey> equalityComparer) {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ILookup<TKey, TElement> value) {}
	}

	public sealed class InterfaceGroupingFormatter<TKey, TElement> : MemoryPackFormatter<IGrouping<TKey, TElement>> // TypeDefIndex: 57336
	{
		// Constructors
		static InterfaceGroupingFormatter() {}
		public InterfaceGroupingFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref IGrouping<TKey, TElement> value) {}
	}

	public sealed class InterfaceSetFormatter<T> : MemoryPackFormatter<ISet<T>> // TypeDefIndex: 57337
	{
		// Fields
		private readonly IEqualityComparer<T> equalityComparer;
	
		// Constructors
		static InterfaceSetFormatter() {}
		public InterfaceSetFormatter() {}
		public InterfaceSetFormatter(IEqualityComparer<T> equalityComparer) {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ISet<T> value) {}
	}

	internal sealed class Grouping<TKey, TElement> : IGrouping<TKey, TElement> // TypeDefIndex: 57338
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

	internal sealed class Lookup<TKey, TElement> : ILookup<TKey, TElement> // TypeDefIndex: 57339
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

	public static class KeyValuePairFormatter // TypeDefIndex: 57340
	{
		// Methods
		public static void Deserialize<TKey, TValue>(IMemoryPackFormatter<TKey> keyFormatter, IMemoryPackFormatter<TValue> valueFormatter, ref MemoryPackReader reader, out ref TKey key, out ref TValue value) {
			key = default;
			value = default;
		}
	}

	public sealed class KeyValuePairFormatter<TKey, TValue> : MemoryPackFormatter<KeyValuePair<TKey, TValue>> // TypeDefIndex: 57341
	{
		// Constructors
		public KeyValuePairFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref KeyValuePair<TKey, TValue> value) {}
	}

	public sealed class LazyFormatter<T> : MemoryPackFormatter<Lazy<T>> // TypeDefIndex: 57342
	{
		// Constructors
		public LazyFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Lazy<T> value) {}
	}

	public sealed class TwoDimensionalArrayFormatter<T> : MemoryPackFormatter<T[,]> // TypeDefIndex: 57343
	{
		// Constructors
		public TwoDimensionalArrayFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ref T[,] value) {}
	}

	public sealed class ThreeDimensionalArrayFormatter<T> : MemoryPackFormatter<T[,,]> // TypeDefIndex: 57344
	{
		// Constructors
		public ThreeDimensionalArrayFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ref T[,,] value) {}
	}

	public sealed class FourDimensionalArrayFormatter<T> : MemoryPackFormatter<T[,,,]> // TypeDefIndex: 57345
	{
		// Constructors
		public FourDimensionalArrayFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ref T[,,,] value) {}
	}

	public sealed class NullableFormatter<T> : MemoryPackFormatter<T?> // TypeDefIndex: 57346
		where T : struct
	{
		// Constructors
		public NullableFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref T? value) {}
	}

	public sealed class StringBuilderFormatter : MemoryPackFormatter<StringBuilder> // TypeDefIndex: 57347
	{
		// Constructors
		public StringBuilderFormatter() {} // 0x0000000185FAAEF0-0x0000000185FAAF20
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref StringBuilder value) {} // 0x000000018B236F24-0x000000018B2370CC
	}

	public sealed class StringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 57348
	{
		// Fields
		public static readonly StringFormatter Default; // 0x00
	
		// Constructors
		public StringFormatter() {} // 0x0000000185F36810-0x0000000185F36840
		static StringFormatter() {} // 0x0000000185F367A0-0x0000000185F36810
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref string value) {} // 0x000000018413F2F0-0x000000018413F350
	}

	public sealed class Utf8StringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 57349
	{
		// Fields
		public static readonly Utf8StringFormatter Default; // 0x00
	
		// Constructors
		public Utf8StringFormatter() {} // 0x000000018B23A1E4-0x000000018B23A20C
		static Utf8StringFormatter() {} // 0x000000018B23A174-0x000000018B23A1E4
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref string value) {} // 0x0000000187784C8C-0x0000000187784CB0
	}

	public sealed class Utf16StringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 57350
	{
		// Fields
		public static readonly Utf16StringFormatter Default; // 0x00
	
		// Constructors
		public Utf16StringFormatter() {} // 0x000000018B23A14C-0x000000018B23A174
		static Utf16StringFormatter() {} // 0x000000018B23A0DC-0x000000018B23A14C
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref string value) {} // 0x0000000187784C8C-0x0000000187784CB0
	}

	public sealed class InternStringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 57351
	{
		// Fields
		public static readonly InternStringFormatter Default; // 0x00
	
		// Constructors
		public InternStringFormatter() {} // 0x000000018B22F5A8-0x000000018B22F5D0
		static InternStringFormatter() {} // 0x000000018B22F538-0x000000018B22F5A8
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref string value) {} // 0x000000018B22F4FC-0x000000018B22F538
	}

	public sealed class BrotliStringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 57353
	{
		// Fields
		private static StrongBox<int> threadStaticConsumedBox; // 0x80000000
		internal const int DefaultDecompssionSizeLimit = 134217728; // Metadata: 0x0207D8BD
		public static readonly BrotliStringFormatter Default; // 0x00
		private readonly CompressionLevel compressionLevel; // 0x10
		private readonly int window; // 0x14
		private readonly int decompressionSizeLimit; // 0x18
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 57352
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static SpanAction<char, ValueTuple<IntPtr, int, int, StrongBox<int>>> __9__10_1; // 0x08
			public static SpanAction<char, ValueTuple<ReadOnlySequence<byte>, long, int, StrongBox<int>>> __9__10_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018B22EC1C-0x000000018B22EC2C
			public __c() {} // 0x000000018B22EBD0-0x000000018B22EBFC
	
			// Methods
			internal void _Deserialize_b__10_1(Span<char> stringSpan, ValueTuple<IntPtr, int, int, StrongBox<int>> state) {} // 0x000000018B22EBFC-0x000000018B22EC1C
			internal void _Deserialize_b__10_0(Span<char> stringSpan, ValueTuple<ReadOnlySequence<byte>, long, int, StrongBox<int>> state) {} // 0x000000018B22EC2C-0x000000018B22EC88
		}
	
		// Constructors
		public BrotliStringFormatter() {} // 0x000000018B22E688-0x000000018B22EB60
		public BrotliStringFormatter(CompressionLevel compressionLevel) {} // 0x000000018B22EB60-0x000000018B22EBD0
		public BrotliStringFormatter(CompressionLevel compressionLevel, int window) {} // 0x000000018B239738-0x000000018B23979C
		public BrotliStringFormatter(CompressionLevel compressionLevel, int window, int decompressionSizeLimit) {} // 0x0000000185492010-0x0000000185492020
		static BrotliStringFormatter() {} // 0x000000018B2392B0-0x000000018B23955C
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref string value) {} // 0x000000018B23955C-0x000000018B239738
	}

	public sealed class TimeZoneInfoFormatter : MemoryPackFormatter<TimeZoneInfo> // TypeDefIndex: 57354
	{
		// Constructors
		public TimeZoneInfoFormatter() {} // 0x0000000185FAAEC0-0x0000000185FAAEF0
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref TimeZoneInfo value) {} // 0x000000018B2370CC-0x000000018B237144
	}

	internal static class TupleFormatterTypes // TypeDefIndex: 57355
	{
		// Fields
		public static readonly Dictionary<System.Type, System.Type> TupleFormatters; // 0x00
	
		// Constructors
		static TupleFormatterTypes() {} // 0x000000018B237144-0x000000018B2376CC
	}

	public sealed class TupleFormatter<T1> : MemoryPackFormatter<Tuple<T1>> // TypeDefIndex: 57356
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1> value) {}
	}

	public sealed class TupleFormatter<T1, T2> : MemoryPackFormatter<Tuple<T1, T2>> // TypeDefIndex: 57357
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2> value) {}
	}

	public sealed class TupleFormatter<T1, T2, T3> : MemoryPackFormatter<Tuple<T1, T2, T3>> // TypeDefIndex: 57358
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3> value) {}
	}

	public sealed class TupleFormatter<T1, T2, T3, T4> : MemoryPackFormatter<Tuple<T1, T2, T3, T4>> // TypeDefIndex: 57359
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3, T4> value) {}
	}

	public sealed class TupleFormatter<T1, T2, T3, T4, T5> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5>> // TypeDefIndex: 57360
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3, T4, T5> value) {}
	}

	public sealed class TupleFormatter<T1, T2, T3, T4, T5, T6> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5, T6>> // TypeDefIndex: 57361
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3, T4, T5, T6> value) {}
	}

	public sealed class TupleFormatter<T1, T2, T3, T4, T5, T6, T7> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5, T6, T7>> // TypeDefIndex: 57362
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3, T4, T5, T6, T7> value) {}
	}

	public sealed class TupleFormatter<T1, T2, T3, T4, T5, T6, T7, TRest> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>> // TypeDefIndex: 57363
	{
		// Constructors
		public TupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> value) {}
	}

	public sealed class ValueTupleFormatter<T1> : MemoryPackFormatter<ValueTuple<T1>> // TypeDefIndex: 57364
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ValueTuple<T1> value) {}
	}

	public sealed class ValueTupleFormatter<T1, T2> : MemoryPackFormatter<ValueTuple<T1, T2>> // TypeDefIndex: 57365
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ValueTuple<T1, T2> value) {}
	}

	public sealed class ValueTupleFormatter<T1, T2, T3> : MemoryPackFormatter<ValueTuple<T1, T2, T3>> // TypeDefIndex: 57366
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ValueTuple<T1, T2, T3> value) {}
	}

	public sealed class ValueTupleFormatter<T1, T2, T3, T4> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4>> // TypeDefIndex: 57367
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ValueTuple<T1, T2, T3, T4> value) {}
	}

	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5>> // TypeDefIndex: 57368
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ValueTuple<T1, T2, T3, T4, T5> value) {}
	}

	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5, T6> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5, T6>> // TypeDefIndex: 57369
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ValueTuple<T1, T2, T3, T4, T5, T6> value) {}
	}

	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> // TypeDefIndex: 57370
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ValueTuple<T1, T2, T3, T4, T5, T6, T7> value) {}
	}

	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7, TRest> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>> // TypeDefIndex: 57371
		where TRest : struct
	{
		// Constructors
		public ValueTupleFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> value) {}
	}

	public sealed class TypeFormatter : MemoryPackFormatter<System.Type> // TypeDefIndex: 57372
	{
		// Fields
		private static readonly Regex _shortTypeNameRegex; // 0x00
	
		// Constructors
		public TypeFormatter() {} // 0x0000000185FAAE60-0x0000000185FAAE90
		static TypeFormatter() {} // 0x0000000185F208B0-0x0000000185F20950
	
		// Methods
		private static Regex ShortTypeNameRegex() => default; // 0x000000018B237760-0x000000018B2377B0
		public override void Deserialize(ref MemoryPackReader reader, ref System.Type value) {} // 0x000000018B2376CC-0x000000018B237760
	}

	public sealed class UnmanagedFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 57373
		where T : struct
	{
		// Constructors
		public UnmanagedFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value) {}
	}

	public sealed class DangerousUnmanagedFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 57374
	{
		// Constructors
		public DangerousUnmanagedFormatter() {}
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value) {}
	}

	public sealed class UriFormatter : MemoryPackFormatter<System.Uri> // TypeDefIndex: 57375
	{
		// Constructors
		public UriFormatter() {} // 0x0000000185FAAE30-0x0000000185FAAE60
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref System.Uri value) {} // 0x000000018B23A050-0x000000018B23A0DC
	}

	public sealed class VersionFormatter : MemoryPackFormatter<System.Version> // TypeDefIndex: 57376
	{
		// Constructors
		public VersionFormatter() {} // 0x0000000185FAADD0-0x0000000185FAAE00
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref System.Version value) {} // 0x000000018B23A20C-0x000000018B23A6C8
	}
}

namespace MemoryPack.Internal
{
	internal static class EnumerableExtensions // TypeDefIndex: 57271
	{
		// Methods
		public static bool TryGetNonEnumeratedCountEx<T>(IEnumerable<T> value, out int count) {
			count = default;
			return default;
		}
	}

	internal struct FixedArrayBufferWriter : IBufferWriter<byte> // TypeDefIndex: 57272
	{
		// Fields
		private byte[] buffer; // 0x00
		private int written; // 0x08
	
		// Constructors
		public FixedArrayBufferWriter(byte[] buffer) {
			this.buffer = default;
			written = default;
		} // 0x000000018646FB84-0x000000018646FBA0
	
		// Methods
		public void Advance(int count) {} // 0x0000000185FCF250-0x0000000185FCF260
		public Memory<byte> GetMemory(int sizeHint = 0 /* Metadata: 0x0207D8A7 */) => default; // 0x000000018B22F26C-0x000000018B22F30C
		public Span<byte> GetSpan(int sizeHint = 0 /* Metadata: 0x0207D8A8 */) => default; // 0x000000018B22F30C-0x000000018B22F3A0
		public byte[] GetFilledBuffer() => default; // 0x000000018B22F21C-0x000000018B22F26C
	}

	internal static class MathEx // TypeDefIndex: 57273
	{
		// Fields
		private const int ArrayMexLength = 2147483591; // Metadata: 0x0207D8A9
	
		// Methods
		public static int NewArrayCapacity(int size) => default; // 0x000000018B22F5D0-0x000000018B22F5E0
	}

	internal static class MemoryMarshalEx // TypeDefIndex: 57274
	{
		// Methods
		public static ref ref T GetArrayDataReference<T>(T[] array) => ref _refReturnTypeForGetArrayDataReference;
		private ref T _refReturnTypeForGetArrayDataReference; // Dummy field
		public static T[] AllocateUninitializedArray<T>(int length, bool pinned = false /* Metadata: 0x0207D8AE */) => default;
	}

	public sealed class PreserveAttribute : Attribute // TypeDefIndex: 57275
	{
		// Constructors
		public PreserveAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class ReusableLinkedArrayBufferWriterPool // TypeDefIndex: 57276
	{
		// Fields
		private static readonly ConcurrentQueue<ReusableLinkedArrayBufferWriter> queue; // 0x00
	
		// Constructors
		static ReusableLinkedArrayBufferWriterPool() {} // 0x000000018B2356E8-0x000000018B235774
	
		// Methods
		public static ReusableLinkedArrayBufferWriter Rent() => default; // 0x000000018B2355B8-0x000000018B23566C
		public static void Return(ReusableLinkedArrayBufferWriter writer) {} // 0x000000018B23566C-0x000000018B2356E8
	}

	public sealed class ReusableLinkedArrayBufferWriter : IBufferWriter<byte> // TypeDefIndex: 57280
	{
		// Fields
		private const int InitialBufferSize = 262144; // Metadata: 0x0207D8B1
		private static readonly byte[] noUseFirstBufferSentinel; // 0x00
		private List<BufferSegment> buffers; // 0x10
		private byte[] firstBuffer; // 0x18
		private int firstBufferWritten; // 0x20
		private BufferSegment current; // 0x28
		private int nextBufferSize; // 0x38
		private int totalWritten; // 0x3C
	
		// Properties
		public int TotalWritten { get => default; } // 0x000000018B235F4C-0x000000018B236288 
		private bool UseFirstBuffer { get => default; } // 0x000000018B235E68-0x000000018B235F4C 
	
		// Nested types
		public struct Enumerator : IEnumerator<Memory<byte>> // TypeDefIndex: 57278
		{
			// Fields
			private ReusableLinkedArrayBufferWriter parent; // 0x00
			private State state; // 0x08
			private Memory<byte> current; // 0x10
			private List<BufferSegment> buffersEnumerator; // 0x20
	
			// Properties
			public Memory<byte> Current { get => default; } // 0x000000018B2363F0-0x000000018B236440 
			object IEnumerator.Current { get => default; } // 0x000000018B2362EC-0x000000018B2363F0 
	
			// Nested types
			private enum State // TypeDefIndex: 57277
			{
				FirstBuffer = 0,
				BuffersInit = 1,
				BuffersIterate = 2,
				Current = 3,
				End = 4
			}
	
			// Constructors
			public Enumerator(ReusableLinkedArrayBufferWriter parent) : this() {
				this.parent = default;
				state = default;
				current = default;
				buffersEnumerator = default;
			} // 0x0000000185FB0790-0x0000000185FB07A0
	
			// Methods
			public void Dispose() {} // 0x0000000181377E40-0x0000000181377E50
			public bool MoveNext() => default; // 0x000000018B2357C0-0x000000018B23580C
			public void Reset() {} // 0x000000018B23580C-0x000000018B235950
		}
	
		private struct _WriteToAndResetAsync_d__19 : IAsyncStateMachine // TypeDefIndex: 57279
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncValueTaskMethodBuilder __t__builder; // 0x08
			public ReusableLinkedArrayBufferWriter __4__this; // 0x28
			public Stream stream; // 0x30
			public CancellationToken cancellationToken; // 0x38
			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter __u__1; // 0x40
			private List<BufferSegment> __7__wrap1; // 0x50
			private BufferSegment _item_5__3; // 0x70
	
			// Methods
			private void MoveNext() {} // 0x000000018B235774-0x000000018B235794
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018B235AFC-0x000000018B235E68
		}
	
		// Constructors
		public ReusableLinkedArrayBufferWriter() {} // Dummy constructor
		public ReusableLinkedArrayBufferWriter(bool useFirstBuffer, bool pinned) {} // 0x000000018B235794-0x000000018B2357C0
		static ReusableLinkedArrayBufferWriter() {} // 0x000000018B23874C-0x000000018B238758
	
		// Methods
		public byte[] DangerousGetFirstBuffer() => default; // 0x000000018B235950-0x000000018B2359AC
		public Memory<byte> GetMemory(int sizeHint = 0 /* Metadata: 0x0207D8AF */) => default; // 0x000000018B2359AC-0x000000018B235AFC
		public Span<byte> GetSpan(int sizeHint = 0 /* Metadata: 0x0207D8B0 */) => default; // 0x000000018B236288-0x000000018B2362EC
		public void Advance(int count) {} // 0x000000018B22F1BC-0x000000018B22F1F0
		public byte[] ToArrayAndReset() => default; // 0x00000001834A7540-0x00000001834A7550
		public void WriteToAndReset(ref MemoryPackWriter writer) {} // 0x000000018B22F170-0x000000018B22F1BC
		public ValueTask WriteToAndResetAsync(Stream stream, CancellationToken cancellationToken) => default; // 0x0000000185492010-0x0000000185492020
		public Enumerator GetEnumerator() => default; // 0x000000018B22EFB0-0x000000018B22F124
		private void ResetCore() {} // 0x000000018B22F124-0x000000018B22F170
		public void Reset() {} // 0x000000018B23979C-0x000000018B23A050
	}

	internal struct BufferSegment // TypeDefIndex: 57281
	{
		// Fields
		private byte[] buffer; // 0x00
		private int written; // 0x08
	
		// Properties
		public bool IsNull { get => default; } // 0x000000018402E460-0x000000018402E470 
		public int WrittenCount { get => default; } // 0x0000000181B7E450-0x0000000181B7E460 
		public Span<byte> WrittenBuffer { get => default; } // 0x000000018B22EE70-0x000000018B22EED4 
		public Memory<byte> WrittenMemory { get => default; } // 0x000000018B22EED4-0x000000018B22EF38 
		public Span<byte> FreeBuffer { get => default; } // 0x000000018B22EE1C-0x000000018B22EE70 
	
		// Constructors
		public BufferSegment(int size) : this() {
			buffer = default;
			written = default;
		} // 0x000000018B22ED9C-0x000000018B22EE1C
	
		// Methods
		public void Advance(int count) {} // 0x0000000185FCF250-0x0000000185FCF260
		public void Clear() {} // 0x000000018B22ED20-0x000000018B22ED9C
	}

	internal static class ReusableReadOnlySequenceBuilderPool // TypeDefIndex: 57282
	{
		// Fields
		private static readonly ConcurrentQueue<ReusableReadOnlySequenceBuilder> queue; // 0x00
	
		// Constructors
		static ReusableReadOnlySequenceBuilderPool() {} // 0x000000018B236568-0x000000018B2365F4
	
		// Methods
		public static ReusableReadOnlySequenceBuilder Rent() => default; // 0x000000018B236440-0x000000018B2364EC
		public static void Return(ReusableReadOnlySequenceBuilder builder) {} // 0x000000018B2364EC-0x000000018B236568
	}

	internal sealed class ReusableReadOnlySequenceBuilder // TypeDefIndex: 57284
	{
		// Fields
		private readonly Stack<Segment> segmentPool; // 0x10
		private readonly List<Segment> list; // 0x18
	
		// Nested types
		private class Segment : ReadOnlySequenceSegment<byte> // TypeDefIndex: 57283
		{
			// Fields
			private bool returnToPool; // 0x30
	
			// Constructors
			public Segment() {} // 0x000000018B236B38-0x000000018B236BF8
	
			// Methods
			public void SetBuffer(ReadOnlyMemory<byte> buffer, bool returnToPool) {} // 0x000000018B2365F4-0x000000018B2366F0
			public void Reset() {} // 0x000000018B236A9C-0x000000018B236B38
			public void SetRunningIndexAndNext(long runningIndex, Segment nextSegment) {} // 0x000000018B2366F0-0x000000018B236924
		}
	
		// Constructors
		public ReusableReadOnlySequenceBuilder() {} // 0x000000018B236924-0x000000018B236A9C
	
		// Methods
		public void Add(ReadOnlyMemory<byte> buffer, bool returnToPool) {} // 0x000000018B236DF4-0x000000018B236E2C
		public bool TryGetSingleMemory(out ReadOnlyMemory<byte> memory) {
			memory = default;
			return default;
		} // 0x000000018B236D38-0x000000018B236D94
		public ReadOnlySequence<byte> Build() => default; // 0x000000018B236BF8-0x000000018B236D38
		public void Reset() {} // 0x000000018B236D94-0x000000018B236DF4
	}

	internal static class TypeHelpers // TypeDefIndex: 57287
	{
		// Fields
		private static readonly MethodInfo isReferenceOrContainsReferences; // 0x00
		private static readonly MethodInfo unsafeSizeOf; // 0x08
	
		// Nested types
		private static class Cache<T> // TypeDefIndex: 57285
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
	
		internal enum TypeKind : byte // TypeDefIndex: 57286
		{
			None = 0,
			UnmanagedSZArray = 1,
			FixedSizeMemoryPackable = 2
		}
	
		// Constructors
		static TypeHelpers() {}
	
		// Methods
		public static bool IsReferenceOrNullable<T>() => default;
		public static TypeKind TryGetUnmanagedSZArrayElementSizeOrMemoryPackableFixedSize<T>(out int size) {
			size = default;
			return default;
		} // 0x000000018B2377B0-0x000000018B237908
		public static bool IsAnonymous(System.Type type) => default; // 0x000000018B237908-0x000000018B237A1C
	}
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 57221
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 57222
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal sealed class NullableAttribute : Attribute // TypeDefIndex: 57223
	{
		// Fields
		public readonly byte[] NullableFlags; // 0x10
	
		// Constructors
		public NullableAttribute() {} // Dummy constructor
		public NullableAttribute(byte param_00078b15) {} // 0x000000018509B960-0x000000018509B9D0
		public NullableAttribute(byte[] param_00078b16) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 57224
	{
		// Fields
		public readonly byte Flag; // 0x10
	
		// Constructors
		public NullableContextAttribute() {} // Dummy constructor
		public NullableContextAttribute(byte param_00078b17) {} // 0x000000018184FBD0-0x000000018184FBE0
	}

	internal sealed class IsExternalInit // TypeDefIndex: 57226
	{
		// Constructors
		public IsExternalInit() {} // 0x0000000185492010-0x0000000185492020
	}
}
