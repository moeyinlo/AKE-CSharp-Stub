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
using Microsoft.CodeAnalysis;
using UnityEngine;

// Image 46: MemoryPack.dll - Assembly: MemoryPack, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59922-60086
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public class MemoryPackRegister<T> // TypeDefIndex: 59927
{
	// Fields
	public static Func<bool> s_initFunc;

	// Constructors
	public MemoryPackRegister();
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 60086
{
	// Fields
	internal static readonly int AD95131BC0B799C0B1AF477FB14FCF26A6A9F76079E48BF090ACB7E8367BFD0E; // 0x00 // Static value (base64): /////w== - Metadata: 0x0234D27C
	internal static readonly int DF3F619804A92FDB4057192DC43DD748EA778ADC52BC498CE80524C014B81119; // 0x04 // Static value (base64): AAAAAA== - Metadata: 0x0234D284
}

namespace MemoryPack
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackableAttribute : Attribute // TypeDefIndex: 59929
	{
		// Fields
		[CompilerGenerated]
		private readonly GenerateType _GenerateType_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly SerializeLayout _SerializeLayout_k__BackingField; // 0x14
	
		// Properties
		public GenerateType GenerateType { [CompilerGenerated] get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
		public SerializeLayout SerializeLayout { [CompilerGenerated] get; } // 0x0000000184D882A0-0x0000000184D882B0 
	
		// Constructors
		public MemoryPackableAttribute(GenerateType generateType = GenerateType.Object /* Metadata: 0x0234D225 */); // 0x000000018A7062E4-0x000000018A7062F8
		public MemoryPackableAttribute(SerializeLayout serializeLayout); // 0x0000000184DA3AB0-0x0000000184DA3AC0
		public MemoryPackableAttribute(GenerateType generateType, SerializeLayout serializeLayout); // 0x0000000184D88290-0x0000000184D882A0
	}

	public enum GenerateType // TypeDefIndex: 59930
	{
		Object = 0,
		VersionTolerant = 1,
		CircularReference = 2,
		Collection = 3,
		NoGenerate = 4
	}

	public enum SerializeLayout // TypeDefIndex: 59931
	{
		Sequential = 0,
		Explicit = 1
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	[Nullable(0)]
	[NullableContext(1)]
	public sealed class MemoryPackUnionAttribute : Attribute // TypeDefIndex: 59932
	{
		// Fields
		[CompilerGenerated]
		private readonly ushort _Tag_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly System.Type _Type_k__BackingField; // 0x18
	
		// Properties
		public ushort Tag { [CompilerGenerated] get; } // 0x0000000184D96190-0x0000000184D961A0 
		public System.Type Type { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
	
		// Constructors
		public MemoryPackUnionAttribute(ushort tag, System.Type type); // 0x000000018A704CE0-0x000000018A704CF4
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	[Nullable(0)]
	[NullableContext(1)]
	public sealed class MemoryPackUnionFormatterAttribute : Attribute // TypeDefIndex: 59933
	{
		// Fields
		[CompilerGenerated]
		private readonly System.Type _Type_k__BackingField; // 0x10
	
		// Properties
		public System.Type Type { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Constructors
		public MemoryPackUnionFormatterAttribute(System.Type type); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackAllowSerializeAttribute : Attribute // TypeDefIndex: 59934
	{
		// Constructors
		public MemoryPackAllowSerializeAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackOrderAttribute : Attribute // TypeDefIndex: 59935
	{
		// Fields
		[CompilerGenerated]
		private readonly int _Order_k__BackingField; // 0x10
	
		// Properties
		public int Order { [CompilerGenerated] get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
	
		// Constructors
		public MemoryPackOrderAttribute(int order); // 0x00000001814F51F0-0x00000001814F5220
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackIgnoreAttribute : Attribute // TypeDefIndex: 59936
	{
		// Constructors
		public MemoryPackIgnoreAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackIncludeAttribute : Attribute // TypeDefIndex: 59937
	{
		// Constructors
		public MemoryPackIncludeAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackConstructorAttribute : Attribute // TypeDefIndex: 59938
	{
		// Constructors
		public MemoryPackConstructorAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackOnSerializingAttribute : Attribute // TypeDefIndex: 59939
	{
		// Constructors
		public MemoryPackOnSerializingAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackOnSerializedAttribute : Attribute // TypeDefIndex: 59940
	{
		// Constructors
		public MemoryPackOnSerializedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackOnDeserializingAttribute : Attribute // TypeDefIndex: 59941
	{
		// Constructors
		public MemoryPackOnDeserializingAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackOnDeserializedAttribute : Attribute // TypeDefIndex: 59942
	{
		// Constructors
		public MemoryPackOnDeserializedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public sealed class GenerateTypeScriptAttribute : Attribute // TypeDefIndex: 59943
	{
		// Constructors
		public GenerateTypeScriptAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class MemoryPackFormatterProvider // TypeDefIndex: 59946
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
		private static class Check<T> // TypeDefIndex: 59944
		{
			// Fields
			public static bool registered;
		}
	
		[Nullable(0)]
		public static class Cache<T> // TypeDefIndex: 59945
		{
			// Fields
			[Nullable(new byte[2] {2, 1 })]
			private static IMemoryPackFormatter<T> _formatter;
	
			// Properties
			public static IMemoryPackFormatter<T> formatter { get; set; }
		}
	
		// Constructors
		static MemoryPackFormatterProvider(); // 0x00000001839D94A0-0x00000001839DA260
	
		// Methods
		private static void RegisterInitialFormatters(); // 0x00000001839D8040-0x00000001839D85E0
		[NullableContext(2)]
		public static bool IsRegistered<T>();
		public static void Register<T>(IMemoryPackFormatter<T> formatter);
		public static void RegisterGenericType(System.Type genericType, System.Type genericFormatterType); // 0x000000018A700E08-0x000000018A700F20
		[NullableContext(0)]
		public static void RegisterCollection<TCollection, TElement>()
			where TCollection : ICollection<TElement>, new();
		public static void RegisterCollection(System.Type genericCollectionType); // 0x000000018A700BB0-0x000000018A700CDC
		[NullableContext(0)]
		public static void RegisterSet<TSet, TElement>()
			where TSet : ISet<TElement>, new();
		public static void RegisterSet(System.Type genericSetType); // 0x000000018A700F20-0x000000018A70104C
		[NullableContext(0)]
		public static void RegisterDictionary<TDictionary, TKey, TValue>()
			where TDictionary : IDictionary<TKey, TValue>, new();
		public static void RegisterDictionary(System.Type genericDictionaryType); // 0x000000018A700CDC-0x000000018A700E08
		public static IMemoryPackFormatter<T> GetFormatter<T>();
		internal static IMemoryPackFormatter GetFormatter(System.Type type); // 0x000000018A7009AC-0x000000018A700BB0
		private static bool TryInvokeRegisterFormatter(System.Type type); // 0x000000018A70121C-0x000000018A701380
		public static void ForceRegister<T>(IMemoryPackFormatter<T> formatter);
		internal static object CreateGenericFormatter(System.Type type, bool typeIsReferenceOrContainsReferences); // 0x000000018A7005E0-0x000000018A7009AC
		private static System.Type TryCreateGenericFormatterType(System.Type type, IDictionary<System.Type, System.Type> knownTypes); // 0x000000018A70116C-0x000000018A70121C
		private static System.Type TryCreateGenericCollectionFormatterType(System.Type type); // 0x000000018A70104C-0x000000018A70116C
		internal static void RegisterWellKnownTypesFormatters(); // 0x000000018428B4C0-0x000000018428D730
		[NullableContext(0)]
		private static void UnityRegister<T>()
			where T : struct;
	}

	public interface IMemoryPackFormatterRegister // TypeDefIndex: 59947
	{
	}

	public interface IMemoryPackable<T> : IMemoryPackFormatterRegister // TypeDefIndex: 59948
	{
	}

	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public interface IMemoryPackFormatter // TypeDefIndex: 59949
	{
		// Methods
		[MemoryPack.Internal.Preserve]
		void Deserialize(ref MemoryPackReader reader, ref object value);
	}

	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public interface IMemoryPackFormatter<T> // TypeDefIndex: 59950
	{
		// Methods
		[MemoryPack.Internal.Preserve]
		void Deserialize(ref MemoryPackReader reader, ref ref T value);
	}

	[Nullable(0)]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public abstract class MemoryPackFormatter<T> : IMemoryPackFormatter<T>, IMemoryPackFormatter // TypeDefIndex: 59951
	{
		// Constructors
		protected MemoryPackFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public abstract void Deserialize(ref MemoryPackReader reader, ref ref T value);
		[MemoryPack.Internal.Preserve]
		void IMemoryPackFormatter.Deserialize(ref MemoryPackReader reader, ref object value);
	}

	public static class MemoryPackCode // TypeDefIndex: 59952
	{
		// Fields
		public const int NullCollection = -1; // Metadata: 0x0234D22D
		public const byte WideTag = 250; // Metadata: 0x0234D22E
		public const byte ReferenceId = 250; // Metadata: 0x0234D22F
		public const byte Reserved1 = 250; // Metadata: 0x0234D230
		public const byte Reserved2 = 251; // Metadata: 0x0234D231
		public const byte Reserved3 = 252; // Metadata: 0x0234D232
		public const byte Reserved4 = 253; // Metadata: 0x0234D233
		public const byte Reserved5 = 254; // Metadata: 0x0234D234
		public const byte NullObject = 255; // Metadata: 0x0234D235
	
		// Properties
		internal static ReadOnlySpan<byte> NullCollectionData { get; } // 0x000000018A700528-0x000000018A700584 
		internal static ReadOnlySpan<byte> ZeroCollectionData { get; } // 0x000000018A700584-0x000000018A7005E0 
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal sealed class ErrorMemoryPackFormatter : IMemoryPackFormatter // TypeDefIndex: 59953
	{
		// Fields
		private readonly System.Type type; // 0x10
		[Nullable(2)]
		private readonly string message; // 0x18
	
		// Constructors
		public ErrorMemoryPackFormatter(System.Type type); // 0x0000000183E8CD90-0x0000000183E8CDC0
		public ErrorMemoryPackFormatter(System.Type type, string message); // 0x00000001832AF420-0x00000001832AF450
	
		// Methods
		[NullableContext(2)]
		public void Serialize(ref MemoryPackWriter writer, ref object value); // 0x000000018A700138-0x000000018A700144
		[NullableContext(2)]
		public void Deserialize(ref MemoryPackReader reader, ref object value); // 0x000000018A700138-0x000000018A700144
		[DoesNotReturn]
		private void Throw(); // 0x000000018A700144-0x000000018A700164
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	internal sealed class ErrorMemoryPackFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 59954
	{
		// Fields
		private readonly Exception exception;
		private readonly string message;
	
		// Constructors
		public ErrorMemoryPackFormatter();
		[NullableContext(1)]
		public ErrorMemoryPackFormatter(Exception exception);
		[NullableContext(1)]
		public ErrorMemoryPackFormatter(string message);
	
		// Methods
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value);
		[DoesNotReturn]
		private void Throw();
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct MemoryPackReader // TypeDefIndex: 59955
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
		public int Consumed { get; } // 0x0000000184D86530-0x0000000184D86540 
		public long Remaining { get; } // 0x0000000184DA3AA0-0x0000000184DA3AB0 
		[Nullable(1)]
		public MemoryPackReaderOptionalState OptionalState { [NullableContext(1)] get; } // 0x0000000184D86200-0x0000000184D86210 
		[Nullable(1)]
		public MemoryPackSerializerOptions Options { [NullableContext(1)] get; } // 0x000000018A7034A4-0x000000018A7034C0 
	
		// Constructors
		public MemoryPackReader([IsReadOnly] in ReadOnlySequence<byte> sequence, [Nullable(1)] MemoryPackReaderOptionalState optionalState); // 0x000000018A70338C-0x000000018A7034A4
		public MemoryPackReader(ReadOnlySpan<byte> buffer, [Nullable(1)] MemoryPackReaderOptionalState optionalState); // 0x0000000183B70820-0x0000000183B708B0
	
		// Methods
		public ref byte GetSpanReference(int sizeHint); // 0x000000018A701DB8-0x000000018A701E20
		private ref byte GetNextSpan(int sizeHint); // 0x000000018A701828-0x000000018A701BA4
		public void Advance(int count); // 0x000000018A7016E8-0x000000018A701770
		private bool TryAdvanceSequence(int count); // 0x000000018A703050-0x000000018A70316C
		public void GetRemainingSource(out ReadOnlySpan<byte> singleSource, out ReadOnlySequence<byte> remainingSource); // 0x000000018A701BA4-0x000000018A701DB8
		public void Dispose(); // 0x000000018A701770-0x000000018A7017E0
		[NullableContext(1)]
		public IMemoryPackFormatter GetFormatter(System.Type type); // 0x000000018A7017E0-0x000000018A701828
		[NullableContext(1)]
		public IMemoryPackFormatter<T> GetFormatter<T>();
		public bool TryReadObjectHeader(out byte memberCount); // 0x000000018A7032B4-0x000000018A7032F4
		public bool TryReadUnionHeader(out ushort tag); // 0x000000018A7032F4-0x000000018A70338C
		public bool TryReadCollectionHeader(out int length); // 0x000000018A703258-0x000000018A7032B4
		public bool PeekIsNull(); // 0x000000018A701E20-0x000000018A701E3C
		public bool TryPeekObjectHeader(out byte memberCount); // 0x000000018A7031BC-0x000000018A7031E0
		public bool TryPeekUnionHeader(out ushort tag); // 0x000000018A7031E0-0x000000018A703234
		public bool TryPeekUshort(out ushort tag); // 0x000000018A703234-0x000000018A703258
		public bool TryPeekCollectionHeader(out int length); // 0x000000018A70316C-0x000000018A7031BC
		public bool DangerousTryReadCollectionHeader(out int length); // 0x000000018A6FCE34-0x000000018A6FCEA0
		[NullableContext(2)]
		public string ReadString(); // 0x000000018A701E3C-0x000000018A701EA0
		[NullableContext(1)]
		private string ReadUtf16(int length); // 0x000000018A701EA0-0x000000018A701F70
		[NullableContext(1)]
		public string ReadUtf8(int utf8Length); // 0x0000000182FEC5F0-0x0000000182FEC820
		public T1 ReadUnmanaged<T1>()
			where T1 : struct;
		public void ReadPackable<T>([Nullable(2)] ref ref T value)
			where T : IMemoryPackable<T>;
		public T ReadPackable<T>()
			where T : IMemoryPackable<T>;
		[NullableContext(2)]
		public void ReadValue<T>(ref ref T value);
		[NullableContext(2)]
		public T ReadValue<T>();
		[NullableContext(1)]
		public void ReadValue(System.Type type, [Nullable(2)] ref object value); // 0x000000018A701F70-0x000000018A701FE0
		[NullableContext(1)]
		public object ReadValue(System.Type type); // 0x000000018A701FE0-0x000000018A702054
		[NullableContext(1)]
		public void ReadValueWithFormatter<TFormatter, T>(TFormatter formatter, [Nullable(2)] ref ref T value)
			where TFormatter : IMemoryPackFormatter<T>;
		[NullableContext(1)]
		public T ReadValueWithFormatter<TFormatter, T>(TFormatter formatter)
			where TFormatter : IMemoryPackFormatter<T>;
		[NullableContext(2)]
		public T[] ReadArray<T>();
		[NullableContext(2)]
		public void ReadArray<T>(ref ref T[] value);
		[NullableContext(2)]
		public void ReadSpan<T>([Nullable(new byte[2] {0, 2 })] ref Span<T> value);
		public T[] ReadPackableArray<T>()
			where T : IMemoryPackable<T>;
		public void ReadPackableArray<T>([Nullable(2)] ref ref T[] value)
			where T : IMemoryPackable<T>;
		public void ReadPackableSpan<T>([Nullable(new byte[2] {0, 2 })] ref Span<T> value)
			where T : IMemoryPackable<T>;
		public T[] ReadUnmanagedArray<T>()
			where T : struct;
		public void ReadUnmanagedArray<T>([Nullable(new byte[2] {2, 0 })] ref ref T[] value)
			where T : struct;
		public void ReadUnmanagedSpan<T>(ref Span<T> value)
			where T : struct;
		[NullableContext(2)]
		public T[] DangerousReadUnmanagedArray<T>();
		[NullableContext(2)]
		public void DangerousReadUnmanagedArray<T>([Nullable(new byte[2] {2, 1 })] ref ref T[] value);
		[NullableContext(2)]
		public void DangerousReadUnmanagedSpan<T>([Nullable(new byte[2] {0, 1 })] ref Span<T> value);
		[NullableContext(2)]
		public void ReadSpanWithoutReadLengthHeader<T>(int length, [Nullable(new byte[2] {0, 2 })] ref Span<T> value);
		public void ReadPackableSpanWithoutReadLengthHeader<T>(int length, [Nullable(new byte[2] {0, 2 })] ref Span<T> value)
			where T : IMemoryPackable<T>;
		public void DangerousReadUnmanagedSpanView<T>(out bool isNull, out ReadOnlySpan<byte> view);
		public void ReadUnmanaged<T1>(out ref T1 value1)
			where T1 : struct;
		public void ReadUnmanaged<T1, T2>(out ref T1 value1, out ref T2 value2)
			where T1 : struct
			where T2 : struct;
		public void ReadUnmanaged<T1, T2, T3>(out ref T1 value1, out ref T2 value2, out ref T3 value3)
			where T1 : struct
			where T2 : struct
			where T3 : struct;
		public void ReadUnmanaged<T1, T2, T3, T4>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct;
		public void ReadUnmanaged<T1, T2, T3, T4, T5>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct;
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct;
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6, T7>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct;
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct;
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct
			where T9 : struct;
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
			where T10 : struct;
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
			where T11 : struct;
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
			where T12 : struct;
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
			where T13 : struct;
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
			where T14 : struct;
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
			where T15 : struct;
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1>(out ref T1 value1);
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2>(out ref T1 value1, out ref T2 value2);
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3>(out ref T1 value1, out ref T2 value2, out ref T3 value3);
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4);
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5);
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6);
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7);
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8);
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9);
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10);
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11);
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12);
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12, out ref T13 value13);
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12, out ref T13 value13, out ref T14 value14);
		[NullableContext(1)]
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12, out ref T13 value13, out ref T14 value14, out ref T15 value15);
		public byte ReadVarIntByte(); // 0x000000018A702054-0x000000018A702260
		public sbyte ReadVarIntSByte(); // 0x000000018A702850-0x000000018A702AC4
		public ushort ReadVarIntUInt16(); // 0x000000018A702AC4-0x000000018A702CCC
		public short ReadVarIntInt16(); // 0x000000018A702260-0x000000018A702494
		public uint ReadVarIntUInt32(); // 0x000000018A702CCC-0x000000018A702EA0
		public int ReadVarIntInt32(); // 0x000000018A702494-0x000000018A70267C
		public ulong ReadVarIntUInt64(); // 0x000000018A702EA0-0x000000018A703050
		public long ReadVarIntInt64(); // 0x000000018A70267C-0x000000018A702850
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class MemoryPackReaderOptionalStatePool // TypeDefIndex: 59956
	{
		// Fields
		private static readonly ConcurrentQueue<MemoryPackReaderOptionalState> queue; // 0x00
	
		// Constructors
		static MemoryPackReaderOptionalStatePool(); // 0x000000018A7014D0-0x000000018A70155C
	
		// Methods
		public static MemoryPackReaderOptionalState Rent([Nullable(2)] MemoryPackSerializerOptions options); // 0x000000018A701380-0x000000018A701454
		internal static void Return(MemoryPackReaderOptionalState state); // 0x000000018A701454-0x000000018A7014D0
	}

	[Nullable(0)]
	[NullableContext(1)]
	public sealed class MemoryPackReaderOptionalState : IDisposable // TypeDefIndex: 59957
	{
		// Fields
		private readonly Dictionary<uint, object> refToObject; // 0x10
		[CompilerGenerated]
		private MemoryPackSerializerOptions _Options_k__BackingField; // 0x18
	
		// Properties
		public MemoryPackSerializerOptions Options { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		internal MemoryPackReaderOptionalState(); // 0x0000000183B70420-0x0000000183B704B0
	
		// Methods
		[NullableContext(2)]
		internal void Init(MemoryPackSerializerOptions options); // 0x0000000183B70730-0x0000000183B70790
		public object GetObjectReference(uint id); // 0x000000018A7015FC-0x000000018A70169C
		public void AddObjectReference(uint id, object value); // 0x000000018A70155C-0x000000018A7015FC
		public void Reset(); // 0x0000000183B70790-0x0000000183B70820
		void IDisposable.Dispose(); // 0x000000018A70169C-0x000000018A7016E8
	}

	internal static class VarIntCodes // TypeDefIndex: 59958
	{
		// Fields
		public const byte MaxSingleValue = 127; // Metadata: 0x0234D236
		public const sbyte MinSingleValue = 136; // Metadata: 0x0234D237
		public const sbyte Byte = 135; // Metadata: 0x0234D238
		public const sbyte SByte = 134; // Metadata: 0x0234D239
		public const sbyte UInt16 = 133; // Metadata: 0x0234D23A
		public const sbyte Int16 = 132; // Metadata: 0x0234D23B
		public const sbyte UInt32 = 131; // Metadata: 0x0234D23C
		public const sbyte Int32 = 130; // Metadata: 0x0234D23D
		public const sbyte UInt64 = 129; // Metadata: 0x0234D23E
		public const sbyte Int64 = 128; // Metadata: 0x0234D23F
	}

	[IsByRefLike]
	[Nullable(0)]
	[NullableContext(1)]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct MemoryPackWriter // TypeDefIndex: 59959
	{
		// Fields
		private const int DepthLimit = 1000; // Metadata: 0x0234D241
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
		public int WrittenCount { get; } // 0x00000001811F0020-0x00000001811F0030 
		public int BufferLength { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public MemoryPackWriterOptionalState OptionalState { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public MemoryPackSerializerOptions Options { get; } // 0x000000018A7062C8-0x000000018A7062E4 
	
		// Constructors
		public MemoryPackWriter(ref IBufferWriter<byte> writer, MemoryPackWriterOptionalState optionalState); // 0x000000018A706284-0x000000018A7062C8
		public MemoryPackWriter(ref IBufferWriter<byte> writer, byte[] firstBufferOfWriter, MemoryPackWriterOptionalState optionalState); // 0x000000018A70613C-0x000000018A7061EC
		public MemoryPackWriter(ref IBufferWriter<byte> writer, [Nullable(0)] Span<byte> firstBufferOfWriter, MemoryPackWriterOptionalState optionalState); // 0x000000018A7061EC-0x000000018A706284
	
		// Methods
		public void WriteVarInt(byte x); // 0x000000018A705F98-0x000000018A706014
		public void WriteVarInt(sbyte x); // 0x000000018A706014-0x000000018A706090
		public void WriteVarInt(ushort x); // 0x000000018A705BE4-0x000000018A705C64
		public void WriteVarInt(short x); // 0x000000018A705B14-0x000000018A705BE4
		public void WriteVarInt(uint x); // 0x000000018A706090-0x000000018A70613C
		public void WriteVarInt(int x); // 0x000000018A705D48-0x000000018A705E44
		public void WriteVarInt(ulong x); // 0x000000018A705C64-0x000000018A705D48
		public void WriteVarInt(long x); // 0x000000018A705E44-0x000000018A705F98
		public ref byte GetSpanReference(int sizeHint); // 0x000000018A70539C-0x000000018A705400
		private void RequestNewBuffer(int sizeHint); // 0x000000018A7054B8-0x000000018A70554C
		public void Advance(int count); // 0x000000018A70527C-0x000000018A7052F0
		public void Flush(); // 0x000000018A7052F0-0x000000018A705354
		public IMemoryPackFormatter GetFormatter(System.Type type); // 0x000000018A705354-0x000000018A70539C
		public IMemoryPackFormatter<T> GetFormatter<T>();
		[NullableContext(2)]
		public int GetStringWriteLength(string value); // 0x000000018A705400-0x000000018A7054B8
		[NullableContext(0)]
		public int GetUnmanageArrayWriteLength<T>([Nullable(new byte[2] {2, 0 })] T[] value)
			where T : struct;
		public void WriteObjectHeader(byte memberCount); // 0x000000018A7055A8-0x000000018A7055EC
		public void WriteNullObjectHeader(); // 0x000000018A705580-0x000000018A7055A8
		public void WriteObjectReferenceId(uint referenceId); // 0x000000018A7055EC-0x000000018A70562C
		public void WriteUnionHeader(ushort tag); // 0x000000018A70564C-0x000000018A7056AC
		public void WriteNullUnionHeader(); // 0x000000018A705580-0x000000018A7055A8
		public void WriteCollectionHeader(int length); // 0x000000018A70554C-0x000000018A705580
		public void WriteNullCollectionHeader(); // 0x000000018A6FCEA0-0x000000018A6FD2E4
		[NullableContext(2)]
		public void WriteString(string value); // 0x000000018A70562C-0x000000018A70564C
		[NullableContext(2)]
		public void WriteUtf16(string value); // 0x000000018A7057E8-0x000000018A70593C
		[NullableContext(0)]
		public void WriteUtf16(ReadOnlySpan<char> value); // 0x000000018A7056AC-0x000000018A7057E8
		[NullableContext(2)]
		public void WriteUtf8(string value); // 0x000000018A70593C-0x000000018A705A68
		[NullableContext(0)]
		public void WriteUtf8(ReadOnlySpan<byte> utf8Value, int utf16Length = -1 /* Metadata: 0x0234D240 */); // 0x000000018A705A68-0x000000018A705B14
		[NullableContext(0)]
		public void WriteUnmanaged<T1>([IsReadOnly] in ref T1 value1)
			where T1 : struct;
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1>(byte propertyCount, [IsReadOnly] in ref T1 value1)
			where T1 : struct;
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2)
			where T1 : struct
			where T2 : struct;
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2)
			where T1 : struct
			where T2 : struct;
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3)
			where T1 : struct
			where T2 : struct
			where T3 : struct;
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3)
			where T1 : struct
			where T2 : struct
			where T3 : struct;
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct;
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct;
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4, T5>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct;
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct;
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct;
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct;
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct;
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct;
		[NullableContext(0)]
		public void WriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct;
		[NullableContext(0)]
		public void WriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct;
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
			where T9 : struct;
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
			where T9 : struct;
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
			where T10 : struct;
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
			where T10 : struct;
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
			where T11 : struct;
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
			where T11 : struct;
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
			where T12 : struct;
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
			where T12 : struct;
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
			where T13 : struct;
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
			where T13 : struct;
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
			where T14 : struct;
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
			where T14 : struct;
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
			where T15 : struct;
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
			where T15 : struct;
		public void DangerousWriteUnmanaged<T1>([IsReadOnly] in ref T1 value1);
		public void DangerousWriteUnmanagedWithObjectHeader<T1>(byte propertyCount, [IsReadOnly] in ref T1 value1);
		public void DangerousWriteUnmanaged<T1, T2>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2);
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2);
		public void DangerousWriteUnmanaged<T1, T2, T3>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3);
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3);
		public void DangerousWriteUnmanaged<T1, T2, T3, T4>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4);
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4);
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5);
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5);
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6);
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6);
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7);
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7);
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8);
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8);
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9);
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9);
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10);
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10);
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11);
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11);
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12);
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12);
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13);
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13);
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13, [IsReadOnly] in ref T14 value14);
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13, [IsReadOnly] in ref T14 value14);
		public void DangerousWriteUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>([IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13, [IsReadOnly] in ref T14 value14, [IsReadOnly] in ref T15 value15);
		public void DangerousWriteUnmanagedWithObjectHeader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(byte propertyCount, [IsReadOnly] in ref T1 value1, [IsReadOnly] in ref T2 value2, [IsReadOnly] in ref T3 value3, [IsReadOnly] in ref T4 value4, [IsReadOnly] in ref T5 value5, [IsReadOnly] in ref T6 value6, [IsReadOnly] in ref T7 value7, [IsReadOnly] in ref T8 value8, [IsReadOnly] in ref T9 value9, [IsReadOnly] in ref T10 value10, [IsReadOnly] in ref T11 value11, [IsReadOnly] in ref T12 value12, [IsReadOnly] in ref T13 value13, [IsReadOnly] in ref T14 value14, [IsReadOnly] in ref T15 value15);
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class MemoryPackSerializationException : Exception // TypeDefIndex: 59960
	{
		// Constructors
		public MemoryPackSerializationException(string message); // 0x00000001839985D0-0x0000000183998610
		public MemoryPackSerializationException(string message, Exception innerException); // 0x000000018A703F80-0x000000018A703FE0
	
		// Methods
		[DoesNotReturn]
		public static void ThrowMessage(string message); // 0x000000018A703B88-0x000000018A703BE0
		[DoesNotReturn]
		public static void ThrowInvalidPropertyCount(byte expected, byte actual); // 0x000000018A703974-0x000000018A703A28
		[DoesNotReturn]
		public static void ThrowInvalidPropertyCount(System.Type type, byte expected, byte actual); // 0x0000000183998300-0x00000001839984A0
		[DoesNotReturn]
		public static void ThrowInvalidCollection(); // 0x000000018A7038BC-0x000000018A703918
		[DoesNotReturn]
		public static void ThrowInvalidRange(int expected, int actual); // 0x000000018A703A28-0x000000018A703ADC
		[DoesNotReturn]
		public static void ThrowInvalidAdvance(); // 0x000000018A703860-0x000000018A7038BC
		[DoesNotReturn]
		public static void ThrowSequenceReachedEnd(); // 0x000000018A703E94-0x000000018A703EF0
		[DoesNotReturn]
		public static void ThrowWriteInvalidMemberCount(byte memberCount); // 0x000000018A703EF0-0x000000018A703F80
		[DoesNotReturn]
		public static void ThrowInsufficientBufferUnless(int length); // 0x000000018A7037D0-0x000000018A703860
		[DoesNotReturn]
		public static void ThrowNotRegisteredInProvider(System.Type type); // 0x000000018A703D0C-0x000000018A703D90
		[DoesNotReturn]
		public static void ThrowRegisterInProviderFailed(System.Type type, Exception innerException); // 0x000000018A703E04-0x000000018A703E94
		[DoesNotReturn]
		public static void ThrowNotFoundInUnionType(System.Type actualType, System.Type baseType); // 0x000000018A703BE0-0x000000018A703D0C
		[DoesNotReturn]
		public static void ThrowInvalidTag(ushort tag, System.Type baseType); // 0x000000018A703ADC-0x000000018A703B88
		[DoesNotReturn]
		public static void ThrowReachedDepthLimit(System.Type type); // 0x000000018A703D90-0x000000018A703E04
		[DoesNotReturn]
		public static void ThrowInvalidConcurrrentCollectionOperation(); // 0x000000018A703918-0x000000018A703974
		[DoesNotReturn]
		public static void ThrowDeserializeObjectIsNull(string target); // 0x000000018A7036BC-0x000000018A703740
		[DoesNotReturn]
		public static void ThrowFailedEncoding(OperationStatus status); // 0x000000018A703740-0x000000018A7037D0
		[DoesNotReturn]
		public static void ThrowCompressionFailed(OperationStatus status); // 0x000000018A703578-0x000000018A703608
		[DoesNotReturn]
		public static void ThrowCompressionFailed(); // 0x000000018A70351C-0x000000018A703578
		[DoesNotReturn]
		public static void ThrowAlreadyDecompressed(); // 0x000000018A7034C0-0x000000018A70351C
		[DoesNotReturn]
		public static void ThrowDecompressionSizeLimitExceeded(int limit, int size); // 0x000000018A703608-0x000000018A7036BC
	}

	[Nullable(0)]
	[NullableContext(2)]
	public static class MemoryPackSerializer // TypeDefIndex: 59964
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
		private sealed class SerializerWriterThreadStaticState // TypeDefIndex: 59961
		{
			// Fields
			public ReusableLinkedArrayBufferWriter BufferWriter; // 0x10
			public MemoryPackWriterOptionalState OptionalState; // 0x18
	
			// Constructors
			public SerializerWriterThreadStaticState(); // 0x000000018A707DC8-0x000000018A707E6C
	
			// Methods
			[NullableContext(2)]
			public void Init(MemoryPackSerializerOptions options); // 0x000000018A707D74-0x000000018A707D94
			public void Reset(); // 0x000000018A707D94-0x000000018A707DC8
		}
	
		[CompilerGenerated]
		private struct _DeserializeAsync_d__6<T> : IAsyncStateMachine // TypeDefIndex: 59962
		{
			// Fields
			public int __1__state;
			[Nullable(0)]
			public AsyncValueTaskMethodBuilder<T> __t__builder;
			[Nullable(0)]
			public Stream stream;
			public CancellationToken cancellationToken;
			[Nullable(0)]
			public MemoryPackSerializerOptions options;
			[Nullable(0)]
			private ReusableReadOnlySequenceBuilder _builder_5__2;
			[Nullable(0)]
			private byte[] _buffer_5__3;
			private int _offset_5__4;
			[Nullable(0)]
			private ConfiguredValueTaskAwaitable<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine([Nullable(0)] IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _DeserializeAsync_d__11 : IAsyncStateMachine // TypeDefIndex: 59963
		{
			// Fields
			public int __1__state; // 0x00
			[Nullable(0)]
			public AsyncValueTaskMethodBuilder<object> __t__builder; // 0x08
			[Nullable(0)]
			public Stream stream; // 0x30
			public CancellationToken cancellationToken; // 0x38
			[Nullable(0)]
			public System.Type type; // 0x40
			[Nullable(0)]
			public MemoryPackSerializerOptions options; // 0x48
			[Nullable(0)]
			private ReusableReadOnlySequenceBuilder _builder_5__2; // 0x50
			[Nullable(0)]
			private byte[] _buffer_5__3; // 0x58
			private int _offset_5__4; // 0x60
			[Nullable(0)]
			private ConfiguredValueTaskAwaitable<int> __u__1; // 0x68
	
			// Methods
			private void MoveNext(); // 0x000000018A7096A0-0x000000018A70A1AC
			[DebuggerHidden]
			private void SetStateMachine([Nullable(0)] IAsyncStateMachine stateMachine); // 0x000000018A70A1AC-0x000000018A70A1F8
		}
	
		// Methods
		public static T Deserialize<T>([Nullable(0)] ReadOnlySpan<byte> buffer, MemoryPackSerializerOptions options = null);
		public static int Deserialize<T>([Nullable(0)] ReadOnlySpan<byte> buffer, ref ref T value, MemoryPackSerializerOptions options = null);
		public static T Deserialize<T>([Nullable(0)] [IsReadOnly] in ReadOnlySequence<byte> buffer, MemoryPackSerializerOptions options = null);
		public static int Deserialize<T>([IsReadOnly] [Nullable(0)] in ReadOnlySequence<byte> buffer, ref ref T value, MemoryPackSerializerOptions options = null);
		public static int Deserialize([IsReadOnly] [Nullable(0)] in ReadOnlySequence<byte> buffer, ref object value, [Nullable(1)] System.Type type, MemoryPackSerializerOptions options = null); // 0x000000018A70462C-0x000000018A704854
		public static async ValueTask<T> DeserializeAsync<T>([Nullable(1)] Stream stream, MemoryPackSerializerOptions options = null, CancellationToken cancellationToken = default);
		public static object Deserialize([Nullable(1)] System.Type type, [Nullable(0)] ReadOnlySpan<byte> buffer, MemoryPackSerializerOptions options = null); // 0x000000018A7045F8-0x000000018A70462C
		public static int Deserialize([Nullable(1)] System.Type type, [Nullable(0)] ReadOnlySpan<byte> buffer, ref object value, MemoryPackSerializerOptions options = null); // 0x000000018A704AD0-0x000000018A704CE0
		public static object Deserialize([Nullable(1)] System.Type type, [IsReadOnly] [Nullable(0)] in ReadOnlySequence<byte> buffer, MemoryPackSerializerOptions options = null); // 0x000000018A704854-0x000000018A70487C
		public static int Deserialize([Nullable(1)] System.Type type, [IsReadOnly] [Nullable(0)] in ReadOnlySequence<byte> buffer, ref object value, MemoryPackSerializerOptions options = null); // 0x000000018A70487C-0x000000018A704AD0
		[NullableContext(1)]
		public static async ValueTask<object> DeserializeAsync(System.Type type, Stream stream, [Nullable(2)] MemoryPackSerializerOptions options = null, CancellationToken cancellationToken = default); // 0x000000018A7044D0-0x000000018A7045F8
	}

	[Nullable(0)]
	[NullableContext(2)]
	public class MemoryPackSerializerOptions : IEquatable<MemoryPackSerializerOptions> // TypeDefIndex: 59965
	{
		// Fields
		[Nullable(1)]
		public static readonly MemoryPackSerializerOptions Default; // 0x00
		[Nullable(1)]
		public static readonly MemoryPackSerializerOptions Utf8; // 0x08
		[Nullable(1)]
		public static readonly MemoryPackSerializerOptions Utf16; // 0x10
		[CompilerGenerated]
		private readonly StringEncoding _StringEncoding_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly IServiceProvider _ServiceProvider_k__BackingField; // 0x18
	
		// Properties
		[Nullable(1)]
		protected virtual System.Type EqualityContract { [NullableContext(1)] [CompilerGenerated] get; } // 0x000000018A704414-0x000000018A704464 
		public StringEncoding StringEncoding { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
		public IServiceProvider ServiceProvider { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		protected MemoryPackSerializerOptions([Nullable(1)] MemoryPackSerializerOptions original); // 0x00000001849C6AF0-0x00000001849C6B20
		public MemoryPackSerializerOptions(); // 0x00000001841E1670-0x00000001841E1680
		static MemoryPackSerializerOptions(); // 0x00000001849C6980-0x00000001849C6A90
	
		// Methods
		[NullableContext(0)]
		public override string ToString(); // 0x000000018A704324-0x000000018A704414
		[NullableContext(1)]
		protected virtual bool PrintMembers(StringBuilder builder); // 0x000000018A704214-0x000000018A704324
		public static bool operator !=(MemoryPackSerializerOptions r1, MemoryPackSerializerOptions r2); // 0x000000018A70447C-0x000000018A7044D0
		public static bool operator ==(MemoryPackSerializerOptions r1, MemoryPackSerializerOptions r2); // 0x000000018A704464-0x000000018A70447C
		public override int GetHashCode(); // 0x000000018A70411C-0x000000018A704214
		public override bool Equals(object obj); // 0x000000018A703FE0-0x000000018A704034
		public virtual bool Equals(MemoryPackSerializerOptions other); // 0x000000018A704034-0x000000018A70411C
		[NullableContext(1)]
		public virtual MemoryPackSerializerOptions _Clone__(); // 0x00000001849C6A90-0x00000001849C6AF0
	}

	public enum StringEncoding : byte // TypeDefIndex: 59966
	{
		Utf16 = 0,
		Utf8 = 1
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class MemoryPackWriterOptionalStatePool // TypeDefIndex: 59967
	{
		// Fields
		private static readonly ConcurrentQueue<MemoryPackWriterOptionalState> queue; // 0x00
	
		// Constructors
		static MemoryPackWriterOptionalStatePool(); // 0x000000018A704E44-0x000000018A704ED0
	
		// Methods
		public static MemoryPackWriterOptionalState Rent([Nullable(2)] MemoryPackSerializerOptions options); // 0x000000018A704CF4-0x000000018A704DC8
		internal static void Return(MemoryPackWriterOptionalState state); // 0x000000018A704DC8-0x000000018A704E44
	}

	[Nullable(0)]
	[NullableContext(1)]
	public sealed class MemoryPackWriterOptionalState : IDisposable // TypeDefIndex: 59969
	{
		// Fields
		internal static readonly MemoryPackWriterOptionalState NullState; // 0x00
		private uint nextId; // 0x10
		private readonly Dictionary<object, uint> objectToRef; // 0x18
		[CompilerGenerated]
		private MemoryPackSerializerOptions _Options_k__BackingField; // 0x20
	
		// Properties
		public MemoryPackSerializerOptions Options { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
	
		// Nested types
		[Nullable(0)]
		private sealed class ReferenceEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 59968
		{
			// Fields
			[CompilerGenerated]
			private static readonly ReferenceEqualityComparer _Instance_k__BackingField; // 0x00
	
			// Properties
			public static ReferenceEqualityComparer Instance { [CompilerGenerated] get; } // 0x000000018A7064B0-0x000000018A706500 
	
			// Constructors
			private ReferenceEqualityComparer(); // 0x00000001841E1670-0x00000001841E1680
			static ReferenceEqualityComparer(); // 0x000000018A70644C-0x000000018A7064B0
	
			// Methods
			[NullableContext(2)]
			public new bool Equals(object x, object y); // 0x000000018829C278-0x000000018829C280
			public int GetHashCode(object obj); // 0x0000000184DA3AC0-0x0000000184DA3AD0
		}
	
		// Constructors
		internal MemoryPackWriterOptionalState(); // 0x000000018A70512C-0x000000018A705214
		private MemoryPackWriterOptionalState(bool _); // 0x000000018A705214-0x000000018A70527C
		static MemoryPackWriterOptionalState(); // 0x000000018A7050B8-0x000000018A70512C
	
		// Methods
		[NullableContext(2)]
		internal void Init(MemoryPackSerializerOptions options); // 0x000000018A704FA4-0x000000018A705014
		public void Reset(); // 0x000000018A705014-0x000000018A70506C
		[NullableContext(0)]
		public ValueTuple<bool, uint> GetOrAddReference([Nullable(1)] object value); // 0x000000018A704ED0-0x000000018A704FA4
		void IDisposable.Dispose(); // 0x000000018A70506C-0x000000018A7050B8
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	internal sealed class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve> // TypeDefIndex: 59970
	{
		// Constructors
		public AnimationCurveFormatter(); // 0x00000001839D8F50-0x00000001839D8F80
	
		// Methods
		private void SerializeKeyFrame(Keyframe keyframe, ref MemoryPackWriter writer); // 0x000000018A6FD40C-0x000000018A6FD4D8
		private void DeserializeKeyFrame(ref MemoryPackReader reader, out Keyframe keyframe); // 0x0000000183663040-0x0000000183663200
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref AnimationCurve value); // 0x0000000183662B30-0x0000000183662ED0
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	internal sealed class GradientFormatter : MemoryPackFormatter<Gradient> // TypeDefIndex: 59971
	{
		// Constructors
		public GradientFormatter(); // 0x00000001839D8F20-0x00000001839D8F50
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Gradient value); // 0x000000018A7002E8-0x000000018A700444
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	internal sealed class RectOffsetFormatter : MemoryPackFormatter<RectOffset> // TypeDefIndex: 59972
	{
		// Constructors
		public RectOffsetFormatter(); // 0x00000001839D8EF0-0x00000001839D8F20
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref RectOffset value); // 0x000000018A7062F8-0x000000018A70644C
	}
}

namespace MemoryPack.Compression
{
	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class BitPackFormatter : MemoryPackFormatter<bool[]> // TypeDefIndex: 60079
	{
		// Fields
		public static readonly BitPackFormatter Default; // 0x00
	
		// Constructors
		public BitPackFormatter(); // 0x000000018A6FD918-0x000000018A6FD940
		static BitPackFormatter(); // 0x000000018A6FD8A8-0x000000018A6FD918
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref bool[] value); // 0x000000018A6FD6E8-0x000000018A6FD86C
		public bool Get(int data, int index); // 0x000000018A6FD86C-0x000000018A6FD884
		public void Set(ref int data, int index, bool value); // 0x000000018A6FD884-0x000000018A6FD8A8
	}

	public class BrotliCompressor : IBufferWriter<byte>, IDisposable // TypeDefIndex: 60081
	{
		// Fields
		[Nullable(2)]
		private ReusableLinkedArrayBufferWriter bufferWriter; // 0x10
		private readonly int quality; // 0x18
		private readonly int window; // 0x1C
	
		// Nested types
		[CompilerGenerated]
		private struct _CopyToAsync_d__11 : IAsyncStateMachine // TypeDefIndex: 60080
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
			private void MoveNext(); // 0x000000018A708964-0x000000018A709694
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018A709694-0x000000018A7096A0
		}
	
		// Constructors
		public BrotliCompressor(CompressionLevel compressionLevel); // 0x000000018A6FEA90-0x000000018A6FEABC
		public BrotliCompressor(CompressionLevel compressionLevel, int window); // 0x000000018A6FE9EC-0x000000018A6FEA24
		public BrotliCompressor(int quality = 1 /* Metadata: 0x0234D25F */, int window = 22 /* Metadata: 0x0234D260 */); // 0x000000018A6FEA24-0x000000018A6FEA90
	
		// Methods
		void IBufferWriter<byte>.Advance(int count); // 0x000000018A6FE370-0x000000018A6FE3B8
		Memory<byte> IBufferWriter<byte>.GetMemory(int sizeHint); // 0x000000018A6FE3B8-0x000000018A6FE3F4
		Span<byte> IBufferWriter<byte>.GetSpan(int sizeHint); // 0x000000018A6FE3F4-0x000000018A6FE450
		[NullableContext(1)]
		public byte[] ToArray(); // 0x000000018A6FE4AC-0x000000018A6FE9EC
		[NullableContext(1)]
		public void CopyTo([IsReadOnly] in IBufferWriter<byte> destBufferWriter); // 0x000000018A6FDD68-0x000000018A6FE03C
		[NullableContext(1)]
		public async ValueTask CopyToAsync(Stream stream, int bufferSize = 65535 /* Metadata: 0x0234D261 */, CancellationToken cancellationToken = default); // 0x000000018A6FDC74-0x000000018A6FDD68
		public void CopyTo(ref MemoryPackWriter memoryPackWriter); // 0x000000018A6FE03C-0x000000018A6FE304
		private static int CompressCore(ref BrotliEncoder encoder, ReadOnlySpan<byte> source, [Nullable(1)] ref IBufferWriter<byte> destBufferWriter, int? initialLength, bool isFinalBlock); // 0x000000018A6FD940-0x000000018A6FDAC0
		private static int CompressCore(ref BrotliEncoder encoder, ReadOnlySpan<byte> source, ref MemoryPackWriter destBufferWriter, int? initialLength, bool isFinalBlock); // 0x000000018A6FDAC0-0x000000018A6FDC74
		public void Dispose(); // 0x000000018A6FE304-0x000000018A6FE370
		private void ThrowIfDisposed(); // 0x000000018A6FE450-0x000000018A6FE4AC
	}

	internal static class BrotliUtils // TypeDefIndex: 60082
	{
		// Fields
		public const int WindowBits_Min = 10; // Metadata: 0x0234D265
		public const int WindowBits_Default = 22; // Metadata: 0x0234D266
		public const int WindowBits_Max = 24; // Metadata: 0x0234D267
		public const int Quality_Min = 0; // Metadata: 0x0234D268
		public const int Quality_Default = 4; // Metadata: 0x0234D269
		public const int Quality_Max = 11; // Metadata: 0x0234D26A
		public const int MaxInputSize = 2147483132; // Metadata: 0x0234D26B
	
		// Methods
		internal static int GetQualityFromCompressionLevel(CompressionLevel compressionLevel); // 0x000000018A6FFBF0-0x000000018A6FFC68
		internal static int BrotliEncoderMaxCompressedSize(int input_size); // 0x000000018A6FFBD0-0x000000018A6FFBF0
	}

	public struct BrotliDecompressor : IDisposable // TypeDefIndex: 60083
	{
		// Fields
		[Nullable(2)]
		private ReusableReadOnlySequenceBuilder sequenceBuilder; // 0x00
	
		// Methods
		public ReadOnlySequence<byte> Decompress(ReadOnlySpan<byte> compressedSpan); // 0x000000018A6FF13C-0x000000018A6FF184
		public ReadOnlySequence<byte> Decompress(ReadOnlySpan<byte> compressedSpan, out int consumed); // 0x000000018A6FEFCC-0x000000018A6FF13C
		public ReadOnlySequence<byte> Decompress(ReadOnlySequence<byte> compressedSequence); // 0x000000018A6FF184-0x000000018A6FF1D8
		public ReadOnlySequence<byte> Decompress(ReadOnlySequence<byte> compressedSequence, out int consumed); // 0x000000018A6FED28-0x000000018A6FEFCC
		private void DecompressCore(ref OperationStatus status, ref BrotliDecoder decoder, ReadOnlySpan<byte> source, out int consumed); // 0x000000018A6FEABC-0x000000018A6FED28
		public void Dispose(); // 0x000000018A6FF1D8-0x000000018A6FF238
		private int GetDoubleCapacity(int length); // 0x000000018A6FF238-0x000000018A6FF284
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class BrotliFormatter : MemoryPackFormatter<byte[]> // TypeDefIndex: 60084
	{
		// Fields
		internal const int DefaultDecompssionSizeLimit = 134217728; // Metadata: 0x0234D270
		public static readonly BrotliFormatter Default; // 0x00
		private readonly CompressionLevel compressionLevel; // 0x10
		private readonly int window; // 0x14
		private readonly int decompressionSizeLimit; // 0x18
	
		// Constructors
		public BrotliFormatter(); // 0x000000018A6FF550-0x000000018A6FF564
		public BrotliFormatter(CompressionLevel compressionLevel); // 0x000000018A6FF5C0-0x000000018A6FF5D0
		public BrotliFormatter(CompressionLevel compressionLevel, int window); // 0x000000018A6FF530-0x000000018A6FF550
		public BrotliFormatter(CompressionLevel compressionLevel, int window, int decompressionSizeLimit); // 0x000000018A6FF564-0x000000018A6FF5C0
		static BrotliFormatter(); // 0x000000018A6FF4C0-0x000000018A6FF530
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref byte[] value); // 0x000000018A6FF284-0x000000018A6FF4C0
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class BrotliFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 60085
	{
		// Fields
		internal const int DefaultDecompssionSizeLimit = 134217728; // Metadata: 0x0234D274
		[Nullable(1)]
		public static readonly BrotliFormatter Default;
		private readonly CompressionLevel compressionLevel;
		private readonly int window;
	
		// Constructors
		public BrotliFormatter();
		public BrotliFormatter(CompressionLevel compressionLevel);
		public BrotliFormatter(CompressionLevel compressionLevel, int window);
		static BrotliFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value);
	}
}

namespace MemoryPack.Formatters
{
	[Nullable(new byte[3] {0, 1, 0 })]
	[MemoryPack.Internal.Preserve]
	public sealed class UnmanagedArrayFormatter<T> : MemoryPackFormatter<T[]> // TypeDefIndex: 59990
		where T : struct
	{
		// Constructors
		public UnmanagedArrayFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {2, 0 })] ref ref T[] value);
	}

	[Nullable(new byte[3] {0, 1, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class DangerousUnmanagedArrayFormatter<T> : MemoryPackFormatter<T[]> // TypeDefIndex: 59991
	{
		// Constructors
		public DangerousUnmanagedArrayFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {2, 1 })] ref ref T[] value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ArrayFormatter<T> : MemoryPackFormatter<T[]> // TypeDefIndex: 59992
	{
		// Constructors
		public ArrayFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T[] value);
	}

	[Nullable(new byte[3] {0, 0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ArraySegmentFormatter<T> : MemoryPackFormatter<ArraySegment<T>> // TypeDefIndex: 59993
	{
		// Constructors
		public ArraySegmentFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {0, 2 })] ref ArraySegment<T> value);
	}

	[Nullable(new byte[3] {0, 0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class MemoryFormatter<T> : MemoryPackFormatter<Memory<T>> // TypeDefIndex: 59994
	{
		// Constructors
		public MemoryFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {0, 2 })] ref Memory<T> value);
	}

	[Nullable(new byte[3] {0, 0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ReadOnlyMemoryFormatter<T> : MemoryPackFormatter<ReadOnlyMemory<T>> // TypeDefIndex: 59995
	{
		// Constructors
		public ReadOnlyMemoryFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {0, 2 })] ref ReadOnlyMemory<T> value);
	}

	[Nullable(new byte[3] {0, 0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ReadOnlySequenceFormatter<T> : MemoryPackFormatter<ReadOnlySequence<T>> // TypeDefIndex: 59996
	{
		// Constructors
		public ReadOnlySequenceFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {0, 2 })] ref ReadOnlySequence<T> value);
	}

	[Nullable(new byte[3] {0, 0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class MemoryPoolFormatter<T> : MemoryPackFormatter<Memory<T>> // TypeDefIndex: 59997
	{
		// Constructors
		public MemoryPoolFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {0, 2 })] ref Memory<T> value);
	}

	[Nullable(new byte[3] {0, 0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ReadOnlyMemoryPoolFormatter<T> : MemoryPackFormatter<ReadOnlyMemory<T>> // TypeDefIndex: 59998
	{
		// Constructors
		public ReadOnlyMemoryPoolFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {0, 2 })] ref ReadOnlyMemory<T> value);
	}

	[MemoryPack.Internal.Preserve]
	public sealed class BigIntegerFormatter : MemoryPackFormatter<BigInteger> // TypeDefIndex: 59999
	{
		// Constructors
		public BigIntegerFormatter(); // 0x0000000184D81920-0x0000000184D81950
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref BigInteger value); // 0x000000018A6FD4D8-0x000000018A6FD5FC
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class BitArrayFormatter : MemoryPackFormatter<BitArray> // TypeDefIndex: 60000
	{
		// Constructors
		public BitArrayFormatter(); // 0x0000000184D818F0-0x0000000184D81920
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref BitArray value); // 0x000000018A6FD5FC-0x000000018A6FD6E8
	}

	[MemoryPack.Internal.Preserve]
	internal class BitArrayView // TypeDefIndex: 60001
	{
		// Fields
		[Nullable(1)]
		public int[] m_array; // 0x10
		public int m_length; // 0x18
		public int _version; // 0x1C
	
		// Constructors
		public BitArrayView(); // 0x00000001841E1670-0x00000001841E1680
	}

	[MemoryPack.Internal.Preserve]
	public static class ListFormatter // TypeDefIndex: 60002
	{
		// Methods
		[MemoryPack.Internal.Preserve]
		public static List<T> DeserializePackable<T>(ref MemoryPackReader reader)
			where T : IMemoryPackable<T>;
		[MemoryPack.Internal.Preserve]
		public static void DeserializePackable<T>(ref MemoryPackReader reader, [Nullable(2)] ref List<T> value)
			where T : IMemoryPackable<T>;
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ListFormatter<T> : MemoryPackFormatter<List<T>> // TypeDefIndex: 60003
	{
		// Constructors
		public ListFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref List<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class StackFormatter<T> : MemoryPackFormatter<Stack<T>> // TypeDefIndex: 60004
	{
		// Constructors
		public StackFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Stack<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class QueueFormatter<T> : MemoryPackFormatter<Queue<T>> // TypeDefIndex: 60005
	{
		// Constructors
		public QueueFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Queue<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class LinkedListFormatter<T> : MemoryPackFormatter<LinkedList<T>> // TypeDefIndex: 60006
	{
		// Constructors
		public LinkedListFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref LinkedList<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class HashSetFormatter<T> : MemoryPackFormatter<HashSet<T>> // TypeDefIndex: 60007
	{
		// Fields
		private readonly IEqualityComparer<T> equalityComparer;
	
		// Constructors
		public HashSetFormatter();
		public HashSetFormatter(IEqualityComparer<T> equalityComparer);
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref HashSet<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class SortedSetFormatter<T> : MemoryPackFormatter<SortedSet<T>> // TypeDefIndex: 60008
	{
		// Fields
		private readonly IComparer<T> comparer;
	
		// Constructors
		public SortedSetFormatter();
		public SortedSetFormatter(IComparer<T> comparer);
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref SortedSet<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class CollectionFormatter<T> : MemoryPackFormatter<Collection<T>> // TypeDefIndex: 60009
	{
		// Constructors
		public CollectionFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Collection<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ObservableCollectionFormatter<T> : MemoryPackFormatter<ObservableCollection<T>> // TypeDefIndex: 60010
	{
		// Constructors
		public ObservableCollectionFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ObservableCollection<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ConcurrentQueueFormatter<T> : MemoryPackFormatter<ConcurrentQueue<T>> // TypeDefIndex: 60011
	{
		// Constructors
		public ConcurrentQueueFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ConcurrentQueue<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ConcurrentStackFormatter<T> : MemoryPackFormatter<ConcurrentStack<T>> // TypeDefIndex: 60012
	{
		// Constructors
		public ConcurrentStackFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ConcurrentStack<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ConcurrentBagFormatter<T> : MemoryPackFormatter<ConcurrentBag<T>> // TypeDefIndex: 60013
	{
		// Constructors
		public ConcurrentBagFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ConcurrentBag<T> value);
	}

	[Nullable(new byte[4] {0, 1, 1, 2 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class DictionaryFormatter<TKey, TValue> : MemoryPackFormatter<Dictionary<TKey, TValue>> // TypeDefIndex: 60014
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private readonly IEqualityComparer<TKey> equalityComparer;
	
		// Constructors
		public DictionaryFormatter();
		public DictionaryFormatter([Nullable(new byte[2] {2, 1 })] IEqualityComparer<TKey> equalityComparer);
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 2 })] ref Dictionary<TKey, TValue> value);
	}

	[Nullable(new byte[4] {0, 1, 1, 2 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class SortedDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<SortedDictionary<TKey, TValue>> // TypeDefIndex: 60015
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private readonly IComparer<TKey> comparer;
	
		// Constructors
		public SortedDictionaryFormatter();
		public SortedDictionaryFormatter([Nullable(new byte[2] {2, 1 })] IComparer<TKey> comparer);
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 2 })] ref SortedDictionary<TKey, TValue> value);
	}

	[Nullable(new byte[4] {0, 1, 1, 2 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class SortedListFormatter<TKey, TValue> : MemoryPackFormatter<SortedList<TKey, TValue>> // TypeDefIndex: 60016
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private readonly IComparer<TKey> comparer;
	
		// Constructors
		public SortedListFormatter();
		public SortedListFormatter([Nullable(new byte[2] {2, 1 })] IComparer<TKey> comparer);
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 2 })] ref SortedList<TKey, TValue> value);
	}

	[Nullable(new byte[4] {0, 1, 1, 2 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class ConcurrentDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<ConcurrentDictionary<TKey, TValue>> // TypeDefIndex: 60017
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private readonly IEqualityComparer<TKey> equalityComparer;
	
		// Constructors
		public ConcurrentDictionaryFormatter();
		public ConcurrentDictionaryFormatter([Nullable(new byte[2] {2, 1 })] IEqualityComparer<TKey> equalityComparer);
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 2 })] ref ConcurrentDictionary<TKey, TValue> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ReadOnlyCollectionFormatter<T> : MemoryPackFormatter<ReadOnlyCollection<T>> // TypeDefIndex: 60018
	{
		// Constructors
		public ReadOnlyCollectionFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ReadOnlyCollection<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ReadOnlyObservableCollectionFormatter<T> : MemoryPackFormatter<ReadOnlyObservableCollection<T>> // TypeDefIndex: 60019
	{
		// Constructors
		public ReadOnlyObservableCollectionFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ReadOnlyObservableCollection<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class BlockingCollectionFormatter<T> : MemoryPackFormatter<BlockingCollection<T>> // TypeDefIndex: 60020
	{
		// Constructors
		public BlockingCollectionFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref BlockingCollection<T> value);
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class CultureInfoFormatter : MemoryPackFormatter<CultureInfo> // TypeDefIndex: 60021
	{
		// Constructors
		public CultureInfoFormatter(); // 0x0000000184D81710-0x0000000184D81740
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref CultureInfo value); // 0x000000018A6FFE80-0x000000018A6FFEF8
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	public sealed class DynamicUnionFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 60023
		where T : class
	{
		// Fields
		private readonly Dictionary<System.Type, ushort> typeToTag;
		private readonly Dictionary<ushort, System.Type> tagToType;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 60022
		{
			// Fields
			[Nullable(0)]
			public static readonly __c<T> __9;
			[Nullable(0)]
			[TupleElementNames(new string[2] {"Tag", "Type" })]
			public static Func<ValueTuple<ushort, System.Type>, System.Type> __9__2_0;
			[Nullable(0)]
			[TupleElementNames(new string[2] {"Tag", "Type" })]
			public static Func<ValueTuple<ushort, System.Type>, ushort> __9__2_1;
			[Nullable(0)]
			[TupleElementNames(new string[2] {"Tag", "Type" })]
			public static Func<ValueTuple<ushort, System.Type>, ushort> __9__2_2;
			[Nullable(0)]
			[TupleElementNames(new string[2] {"Tag", "Type" })]
			public static Func<ValueTuple<ushort, System.Type>, System.Type> __9__2_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			[NullableContext(0)]
			internal System.Type _.ctor_b__2_0([TupleElementNames(new string[2] {"Tag", "Type" })] ValueTuple<ushort, System.Type> x);
			[NullableContext(0)]
			internal ushort _.ctor_b__2_1([TupleElementNames(new string[2] {"Tag", "Type" })] ValueTuple<ushort, System.Type> x);
			[NullableContext(0)]
			internal ushort _.ctor_b__2_2([TupleElementNames(new string[2] {"Tag", "Type" })] ValueTuple<ushort, System.Type> x);
			[NullableContext(0)]
			internal System.Type _.ctor_b__2_3([TupleElementNames(new string[2] {"Tag", "Type" })] ValueTuple<ushort, System.Type> x);
		}
	
		// Constructors
		public DynamicUnionFormatter([Nullable(new byte[3] {1, 0, 1 })] params [TupleElementNames(new string[2] {"Tag", "Type" })] ValueTuple<ushort, System.Type>[] memoryPackUnions);
	
		// Methods
		[NullableContext(2)]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value);
	}

	[Nullable(new byte[2] {0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class GenericCollectionFormatter<TCollection, TElement> : MemoryPackFormatter<TCollection> // TypeDefIndex: 60024
		where TCollection : ICollection<TElement>, new()
	{
		// Constructors
		public GenericCollectionFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref TCollection value);
	}

	[Nullable(new byte[2] {0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public abstract class GenericSetFormatterBase<TSet, TElement> : MemoryPackFormatter<TSet> // TypeDefIndex: 60025
		where TSet : ISet<TElement>
	{
		// Constructors
		protected GenericSetFormatterBase();
	
		// Methods
		[NullableContext(1)]
		[MemoryPack.Internal.Preserve]
		protected abstract TSet CreateSet();
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref TSet value);
	}

	[Nullable(new byte[3] {0, 1, 1 })]
	[MemoryPack.Internal.Preserve]
	public sealed class GenericSetFormatter<TSet, TElement> : GenericSetFormatterBase<TSet, TElement> // TypeDefIndex: 60026
		where TSet : ISet<TElement>, new()
	{
		// Constructors
		public GenericSetFormatter();
	
		// Methods
		[NullableContext(1)]
		protected override TSet CreateSet();
	}

	[Nullable(new byte[2] {0, 2 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public abstract class GenericDictionaryFormatterBase<TDictionary, TKey, TValue> : MemoryPackFormatter<TDictionary> // TypeDefIndex: 60027
		where TDictionary : IDictionary<TKey, TValue>
	{
		// Constructors
		protected GenericDictionaryFormatterBase();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		protected abstract TDictionary CreateDictionary();
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref TDictionary value);
	}

	[Nullable(new byte[4] {0, 1, 1, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class GenericDictionaryFormatter<TDictionary, TKey, TValue> : GenericDictionaryFormatterBase<TDictionary, TKey, TValue> // TypeDefIndex: 60028
		where TDictionary : IDictionary<TKey, TValue>, new()
	{
		// Constructors
		public GenericDictionaryFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		protected override TDictionary CreateDictionary();
	}

	internal static class InterfaceCollectionFormatterUtils // TypeDefIndex: 60029
	{
		// Methods
		[NullableContext(2)]
		public static List<T> ReadList<T>(ref MemoryPackReader reader);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceEnumerableFormatter<T> : MemoryPackFormatter<IEnumerable<T>> // TypeDefIndex: 60030
	{
		// Constructors
		public InterfaceEnumerableFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref IEnumerable<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceCollectionFormatter<T> : MemoryPackFormatter<ICollection<T>> // TypeDefIndex: 60031
	{
		// Constructors
		static InterfaceCollectionFormatter();
		public InterfaceCollectionFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ICollection<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceReadOnlyCollectionFormatter<T> : MemoryPackFormatter<IReadOnlyCollection<T>> // TypeDefIndex: 60032
	{
		// Constructors
		static InterfaceReadOnlyCollectionFormatter();
		public InterfaceReadOnlyCollectionFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref IReadOnlyCollection<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceListFormatter<T> : MemoryPackFormatter<IList<T>> // TypeDefIndex: 60033
	{
		// Constructors
		static InterfaceListFormatter();
		public InterfaceListFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref IList<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceReadOnlyListFormatter<T> : MemoryPackFormatter<IReadOnlyList<T>> // TypeDefIndex: 60034
	{
		// Constructors
		static InterfaceReadOnlyListFormatter();
		public InterfaceReadOnlyListFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref IReadOnlyList<T> value);
	}

	[Nullable(new byte[4] {0, 1, 1, 2 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<IDictionary<TKey, TValue>> // TypeDefIndex: 60035
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private readonly IEqualityComparer<TKey> equalityComparer;
	
		// Constructors
		public InterfaceDictionaryFormatter();
		public InterfaceDictionaryFormatter([Nullable(new byte[2] {2, 1 })] IEqualityComparer<TKey> equalityComparer);
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 2 })] ref IDictionary<TKey, TValue> value);
	}

	[Nullable(new byte[4] {0, 1, 1, 2 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceReadOnlyDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<IReadOnlyDictionary<TKey, TValue>> // TypeDefIndex: 60036
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private readonly IEqualityComparer<TKey> equalityComparer;
	
		// Constructors
		public InterfaceReadOnlyDictionaryFormatter();
		public InterfaceReadOnlyDictionaryFormatter([Nullable(new byte[2] {2, 1 })] IEqualityComparer<TKey> equalityComparer);
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 2 })] ref IReadOnlyDictionary<TKey, TValue> value);
	}

	[Nullable(new byte[4] {0, 1, 1, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceLookupFormatter<TKey, TElement> : MemoryPackFormatter<ILookup<TKey, TElement>> // TypeDefIndex: 60037
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private readonly IEqualityComparer<TKey> equalityComparer;
	
		// Constructors
		static InterfaceLookupFormatter();
		public InterfaceLookupFormatter();
		public InterfaceLookupFormatter([Nullable(new byte[2] {2, 1 })] IEqualityComparer<TKey> equalityComparer);
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 1 })] ref ILookup<TKey, TElement> value);
	}

	[Nullable(new byte[4] {0, 1, 1, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceGroupingFormatter<TKey, TElement> : MemoryPackFormatter<IGrouping<TKey, TElement>> // TypeDefIndex: 60038
	{
		// Constructors
		static InterfaceGroupingFormatter();
		public InterfaceGroupingFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {2, 1, 1 })] ref IGrouping<TKey, TElement> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceSetFormatter<T> : MemoryPackFormatter<ISet<T>> // TypeDefIndex: 60039
	{
		// Fields
		private readonly IEqualityComparer<T> equalityComparer;
	
		// Constructors
		static InterfaceSetFormatter();
		public InterfaceSetFormatter();
		public InterfaceSetFormatter(IEqualityComparer<T> equalityComparer);
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ISet<T> value);
	}

	[Nullable(0)]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	internal sealed class Grouping<TKey, TElement> : IGrouping<TKey, TElement> // TypeDefIndex: 60040
	{
		// Fields
		private readonly TKey key;
		private readonly IEnumerable<TElement> elements;
	
		// Properties
		public TKey Key { get; }
	
		// Constructors
		public Grouping(TKey key, IEnumerable<TElement> elements);
	
		// Methods
		public IEnumerator<TElement> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	[Nullable(0)]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	internal sealed class Lookup<TKey, TElement> : ILookup<TKey, TElement> // TypeDefIndex: 60041
	{
		// Fields
		private readonly Dictionary<TKey, IGrouping<TKey, TElement>> groupings;
	
		// Properties
		public IEnumerable<TElement> this[TKey key] { get => default; }
		public int Count { get; }
	
		// Constructors
		public Lookup(Dictionary<TKey, IGrouping<TKey, TElement>> groupings);
	
		// Methods
		public bool Contains(TKey key);
		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	[MemoryPack.Internal.Preserve]
	public static class KeyValuePairFormatter // TypeDefIndex: 60042
	{
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public static void Deserialize<TKey, TValue>([Nullable(1)] IMemoryPackFormatter<TKey> keyFormatter, [Nullable(1)] IMemoryPackFormatter<TValue> valueFormatter, ref MemoryPackReader reader, out ref TKey key, out ref TValue value);
	}

	[Nullable(new byte[4] {0, 0, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class KeyValuePairFormatter<TKey, TValue> : MemoryPackFormatter<KeyValuePair<TKey, TValue>> // TypeDefIndex: 60043
	{
		// Constructors
		public KeyValuePairFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {0, 2, 2 })] ref KeyValuePair<TKey, TValue> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class LazyFormatter<T> : MemoryPackFormatter<Lazy<T>> // TypeDefIndex: 60044
	{
		// Constructors
		public LazyFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Lazy<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TwoDimensionalArrayFormatter<T> : MemoryPackFormatter<T[,]> // TypeDefIndex: 60045
	{
		// Constructors
		public TwoDimensionalArrayFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T[,] value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ThreeDimensionalArrayFormatter<T> : MemoryPackFormatter<T[,,]> // TypeDefIndex: 60046
	{
		// Constructors
		public ThreeDimensionalArrayFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T[,,] value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class FourDimensionalArrayFormatter<T> : MemoryPackFormatter<T[,,,]> // TypeDefIndex: 60047
	{
		// Constructors
		public FourDimensionalArrayFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T[,,,] value);
	}

	[MemoryPack.Internal.Preserve]
	public sealed class NullableFormatter<T> : MemoryPackFormatter<T?> // TypeDefIndex: 60048
		where T : struct
	{
		// Constructors
		public NullableFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref T? value);
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class StringBuilderFormatter : MemoryPackFormatter<StringBuilder> // TypeDefIndex: 60049
	{
		// Constructors
		public StringBuilderFormatter(); // 0x0000000184D80CF0-0x0000000184D80D20
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref StringBuilder value); // 0x000000018A707E6C-0x000000018A708014
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class StringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 60050
	{
		// Fields
		public static readonly StringFormatter Default; // 0x00
	
		// Constructors
		public StringFormatter(); // 0x0000000184D109A0-0x0000000184D109D0
		static StringFormatter(); // 0x0000000184D10930-0x0000000184D109A0
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref string value); // 0x0000000183C32650-0x0000000183C32750
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class Utf8StringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 60051
	{
		// Fields
		public static readonly Utf8StringFormatter Default; // 0x00
	
		// Constructors
		public Utf8StringFormatter(); // 0x000000018A70B12C-0x000000018A70B154
		static Utf8StringFormatter(); // 0x000000018A70B0BC-0x000000018A70B12C
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref string value); // 0x00000001867C5DC0-0x00000001867C5DE4
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class Utf16StringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 60052
	{
		// Fields
		public static readonly Utf16StringFormatter Default; // 0x00
	
		// Constructors
		public Utf16StringFormatter(); // 0x000000018A70B094-0x000000018A70B0BC
		static Utf16StringFormatter(); // 0x000000018A70B024-0x000000018A70B094
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref string value); // 0x00000001867C5DC0-0x00000001867C5DE4
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class InternStringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 60053
	{
		// Fields
		public static readonly InternStringFormatter Default; // 0x00
	
		// Constructors
		public InternStringFormatter(); // 0x000000018A7004F0-0x000000018A700518
		static InternStringFormatter(); // 0x000000018A700480-0x000000018A7004F0
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref string value); // 0x000000018A700444-0x000000018A700480
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class BrotliStringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 60055
	{
		// Fields
		[ThreadStatic]
		private static StrongBox<int> threadStaticConsumedBox; // 0x80000000
		internal const int DefaultDecompssionSizeLimit = 134217728; // Metadata: 0x0234D25B
		[Nullable(1)]
		public static readonly BrotliStringFormatter Default; // 0x00
		private readonly CompressionLevel compressionLevel; // 0x10
		private readonly int window; // 0x14
		private readonly int decompressionSizeLimit; // 0x18
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 60054
		{
			// Fields
			[Nullable(0)]
			public static readonly __c __9; // 0x00
			[Nullable(0)]
			[TupleElementNames(new string[4] {null, "Length", "byteLength", "consumedBox" })]
			public static SpanAction<char, ValueTuple<IntPtr, int, int, StrongBox<int>>> __9__10_1; // 0x08
			[Nullable(0)]
			[TupleElementNames(new string[4] {"remainingSource", "Length", "byteLength", "consumedBox" })]
			public static SpanAction<char, ValueTuple<ReadOnlySequence<byte>, long, int, StrongBox<int>>> __9__10_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018A70A680-0x000000018A70A6E4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			[NullableContext(0)]
			internal void _Deserialize_b__10_1(Span<char> stringSpan, [TupleElementNames(new string[4] {null, "Length", "byteLength", "consumedBox" })] ValueTuple<IntPtr, int, int, StrongBox<int>> state); // 0x000000018A70A4A4-0x000000018A70A680
			[NullableContext(0)]
			internal void _Deserialize_b__10_0(Span<char> stringSpan, [TupleElementNames(new string[4] {"remainingSource", "Length", "byteLength", "consumedBox" })] ValueTuple<ReadOnlySequence<byte>, long, int, StrongBox<int>> state); // 0x000000018A70A1F8-0x000000018A70A4A4
		}
	
		// Constructors
		public BrotliStringFormatter(); // 0x000000018A6FFB64-0x000000018A6FFB74
		public BrotliStringFormatter(CompressionLevel compressionLevel); // 0x000000018A6FFB18-0x000000018A6FFB44
		public BrotliStringFormatter(CompressionLevel compressionLevel, int window); // 0x000000018A6FFB44-0x000000018A6FFB64
		public BrotliStringFormatter(CompressionLevel compressionLevel, int window, int decompressionSizeLimit); // 0x000000018A6FFB74-0x000000018A6FFBD0
		static BrotliStringFormatter(); // 0x000000018A6FFAA8-0x000000018A6FFB18
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref string value); // 0x000000018A6FF5D0-0x000000018A6FFAA8
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TimeZoneInfoFormatter : MemoryPackFormatter<TimeZoneInfo> // TypeDefIndex: 60056
	{
		// Constructors
		public TimeZoneInfoFormatter(); // 0x0000000184D80C90-0x0000000184D80CC0
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref TimeZoneInfo value); // 0x000000018A708014-0x000000018A70808C
	}

	internal static class TupleFormatterTypes // TypeDefIndex: 60057
	{
		// Fields
		[Nullable(1)]
		public static readonly Dictionary<System.Type, System.Type> TupleFormatters; // 0x00
	
		// Constructors
		static TupleFormatterTypes(); // 0x000000018A70808C-0x000000018A708614
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1> : MemoryPackFormatter<Tuple<T1>> // TypeDefIndex: 60058
	{
		// Constructors
		public TupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1> value);
	}

	[Nullable(new byte[4] {0, 1, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1, T2> : MemoryPackFormatter<Tuple<T1, T2>> // TypeDefIndex: 60059
	{
		// Constructors
		public TupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2> value);
	}

	[Nullable(new byte[5] {0, 1, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1, T2, T3> : MemoryPackFormatter<Tuple<T1, T2, T3>> // TypeDefIndex: 60060
	{
		// Constructors
		public TupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3> value);
	}

	[Nullable(new byte[6] {0, 1, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1, T2, T3, T4> : MemoryPackFormatter<Tuple<T1, T2, T3, T4>> // TypeDefIndex: 60061
	{
		// Constructors
		public TupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3, T4> value);
	}

	[Nullable(new byte[7] {0, 1, 2, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1, T2, T3, T4, T5> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5>> // TypeDefIndex: 60062
	{
		// Constructors
		public TupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3, T4, T5> value);
	}

	[Nullable(new byte[8] {0, 1, 2, 2, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1, T2, T3, T4, T5, T6> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5, T6>> // TypeDefIndex: 60063
	{
		// Constructors
		public TupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3, T4, T5, T6> value);
	}

	[Nullable(new byte[9] {0, 1, 2, 2, 2, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1, T2, T3, T4, T5, T6, T7> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5, T6, T7>> // TypeDefIndex: 60064
	{
		// Constructors
		public TupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Tuple<T1, T2, T3, T4, T5, T6, T7> value);
	}

	[Nullable(new byte[10] {0, 1, 2, 2, 2, 2, 2, 2, 2, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1, T2, T3, T4, T5, T6, T7, TRest> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>> // TypeDefIndex: 60065
	{
		// Constructors
		public TupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[9] {2, 2, 2, 2, 2, 2, 2, 2, 1 })] ref Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> value);
	}

	[Nullable(new byte[3] {0, 0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1> : MemoryPackFormatter<ValueTuple<T1>> // TypeDefIndex: 60066
	{
		// Constructors
		public ValueTupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {0, 2 })] ref ValueTuple<T1> value);
	}

	[Nullable(new byte[4] {0, 0, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1, T2> : MemoryPackFormatter<ValueTuple<T1, T2>> // TypeDefIndex: 60067
	{
		// Constructors
		public ValueTupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[3] {0, 2, 2 })] ref ValueTuple<T1, T2> value);
	}

	[Nullable(new byte[5] {0, 0, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1, T2, T3> : MemoryPackFormatter<ValueTuple<T1, T2, T3>> // TypeDefIndex: 60068
	{
		// Constructors
		public ValueTupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[4] {0, 2, 2, 2 })] ref ValueTuple<T1, T2, T3> value);
	}

	[Nullable(new byte[6] {0, 0, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1, T2, T3, T4> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4>> // TypeDefIndex: 60069
	{
		// Constructors
		public ValueTupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[5] {0, 2, 2, 2, 2 })] ref ValueTuple<T1, T2, T3, T4> value);
	}

	[Nullable(new byte[7] {0, 0, 2, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5>> // TypeDefIndex: 60070
	{
		// Constructors
		public ValueTupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[6] {0, 2, 2, 2, 2, 2 })] ref ValueTuple<T1, T2, T3, T4, T5> value);
	}

	[Nullable(new byte[8] {0, 0, 2, 2, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5, T6> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5, T6>> // TypeDefIndex: 60071
	{
		// Constructors
		public ValueTupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[7] {0, 2, 2, 2, 2, 2, 2 })] ref ValueTuple<T1, T2, T3, T4, T5, T6> value);
	}

	[Nullable(new byte[9] {0, 0, 2, 2, 2, 2, 2, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> // TypeDefIndex: 60072
	{
		// Constructors
		public ValueTupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[8] {0, 2, 2, 2, 2, 2, 2, 2 })] ref ValueTuple<T1, T2, T3, T4, T5, T6, T7> value);
	}

	[Nullable(new byte[10] {0, 0, 2, 2, 2, 2, 2, 2, 2, 0 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7, TRest> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>> // TypeDefIndex: 60073
		where TRest : struct
	{
		// Constructors
		public ValueTupleFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[9] {0, 2, 2, 2, 2, 2, 2, 2, 0 })] ref ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> value);
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class TypeFormatter : MemoryPackFormatter<System.Type> // TypeDefIndex: 60074
	{
		// Fields
		private static readonly Regex _shortTypeNameRegex; // 0x00
	
		// Constructors
		public TypeFormatter(); // 0x0000000184D80C00-0x0000000184D80C30
		static TypeFormatter(); // 0x0000000184CF7430-0x0000000184CF74D0
	
		// Methods
		private static Regex ShortTypeNameRegex(); // 0x000000018A7086A8-0x000000018A7086F8
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref System.Type value); // 0x000000018A708614-0x000000018A7086A8
	}

	[MemoryPack.Internal.Preserve]
	public sealed class UnmanagedFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 60075
		where T : struct
	{
		// Constructors
		public UnmanagedFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value);
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class DangerousUnmanagedFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 60076
	{
		// Constructors
		public DangerousUnmanagedFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value);
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class UriFormatter : MemoryPackFormatter<System.Uri> // TypeDefIndex: 60077
	{
		// Constructors
		public UriFormatter(); // 0x0000000184D80BA0-0x0000000184D80BD0
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref System.Uri value); // 0x000000018A70AF98-0x000000018A70B024
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class VersionFormatter : MemoryPackFormatter<System.Version> // TypeDefIndex: 60078
	{
		// Constructors
		public VersionFormatter(); // 0x0000000184D80B10-0x0000000184D80B40
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref System.Version value); // 0x000000018A70B154-0x000000018A70B5A4
	}
}

namespace MemoryPack.Internal
{
	internal static class EnumerableExtensions // TypeDefIndex: 59973
	{
		// Extension methods
		[NullableContext(1)]
		public static bool TryGetNonEnumeratedCountEx<T>(this IEnumerable<T> value, out int count);
	}

	internal struct FixedArrayBufferWriter : IBufferWriter<byte> // TypeDefIndex: 59974
	{
		// Fields
		[Nullable(1)]
		private byte[] buffer; // 0x00
		private int written; // 0x08
	
		// Constructors
		[NullableContext(1)]
		public FixedArrayBufferWriter(byte[] buffer); // 0x0000000185393828-0x0000000185393844
	
		// Methods
		public void Advance(int count); // 0x0000000184DA3A90-0x0000000184DA3AA0
		public Memory<byte> GetMemory(int sizeHint = 0 /* Metadata: 0x0234D245 */); // 0x000000018A7001B4-0x000000018A700254
		public Span<byte> GetSpan(int sizeHint = 0 /* Metadata: 0x0234D246 */); // 0x000000018A700254-0x000000018A7002E8
		[NullableContext(1)]
		public byte[] GetFilledBuffer(); // 0x000000018A700164-0x000000018A7001B4
	}

	internal static class MathEx // TypeDefIndex: 59975
	{
		// Fields
		private const int ArrayMexLength = 2147483591; // Metadata: 0x0234D247
	
		// Methods
		public static int NewArrayCapacity(int size); // 0x000000018A700518-0x000000018A700528
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class MemoryMarshalEx // TypeDefIndex: 59976
	{
		// Methods
		public static ref ref T GetArrayDataReference<T>(T[] array);
		public static T[] AllocateUninitializedArray<T>(int length, bool pinned = false /* Metadata: 0x0234D24C */);
	}

	public sealed class PreserveAttribute : Attribute // TypeDefIndex: 59977
	{
		// Constructors
		public PreserveAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class ReusableLinkedArrayBufferWriterPool // TypeDefIndex: 59978
	{
		// Fields
		private static readonly ConcurrentQueue<ReusableLinkedArrayBufferWriter> queue; // 0x00
	
		// Constructors
		static ReusableLinkedArrayBufferWriterPool(); // 0x000000018A706630-0x000000018A7066BC
	
		// Methods
		public static ReusableLinkedArrayBufferWriter Rent(); // 0x000000018A706500-0x000000018A7065B4
		public static void Return(ReusableLinkedArrayBufferWriter writer); // 0x000000018A7065B4-0x000000018A706630
	}

	[Nullable(0)]
	[NullableContext(1)]
	public sealed class ReusableLinkedArrayBufferWriter : IBufferWriter<byte> // TypeDefIndex: 59982
	{
		// Fields
		private const int InitialBufferSize = 262144; // Metadata: 0x0234D24F
		private static readonly byte[] noUseFirstBufferSentinel; // 0x00
		private List<BufferSegment> buffers; // 0x10
		private byte[] firstBuffer; // 0x18
		private int firstBufferWritten; // 0x20
		private BufferSegment current; // 0x28
		private int nextBufferSize; // 0x38
		private int totalWritten; // 0x3C
	
		// Properties
		public int TotalWritten { get; } // 0x0000000184D86640-0x0000000184D86650 
		private bool UseFirstBuffer { get; } // 0x000000018A707338-0x000000018A707388 
	
		// Nested types
		[NullableContext(0)]
		public struct Enumerator : IEnumerator<Memory<byte>> // TypeDefIndex: 59980
		{
			// Fields
			[Nullable(1)]
			private ReusableLinkedArrayBufferWriter parent; // 0x00
			private State state; // 0x08
			private Memory<byte> current; // 0x10
			private List<BufferSegment> buffersEnumerator; // 0x20
	
			// Properties
			public Memory<byte> Current { get; } // 0x0000000182B2D510-0x0000000182B2D520 
			[Nullable(1)]
			object IEnumerator.Current { [NullableContext(1)] get; } // 0x000000018A7000B8-0x000000018A700104 
	
			// Nested types
			private enum State // TypeDefIndex: 59979
			{
				FirstBuffer = 0,
				BuffersInit = 1,
				BuffersIterate = 2,
				Current = 3,
				End = 4
			}
	
			// Constructors
			[NullableContext(1)]
			public Enumerator(ReusableLinkedArrayBufferWriter parent); // 0x000000018A700104-0x000000018A700138
	
			// Methods
			public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
			public bool MoveNext(); // 0x000000018A6FFEF8-0x000000018A70006C
			public void Reset(); // 0x000000018A70006C-0x000000018A7000B8
		}
	
		[CompilerGenerated]
		private struct _WriteToAndResetAsync_d__19 : IAsyncStateMachine // TypeDefIndex: 59981
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncValueTaskMethodBuilder __t__builder; // 0x08
			[Nullable(0)]
			public ReusableLinkedArrayBufferWriter __4__this; // 0x28
			[Nullable(0)]
			public Stream stream; // 0x30
			public CancellationToken cancellationToken; // 0x38
			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter __u__1; // 0x40
			[Nullable(0)]
			private List<BufferSegment> __7__wrap1; // 0x50
			private BufferSegment _item_5__3; // 0x70
	
			// Methods
			private void MoveNext(); // 0x000000018A70A6E4-0x000000018A70AF98
			[DebuggerHidden]
			private void SetStateMachine([Nullable(0)] IAsyncStateMachine stateMachine); // 0x000000018A709694-0x000000018A7096A0
		}
	
		// Constructors
		public ReusableLinkedArrayBufferWriter(bool useFirstBuffer, bool pinned); // 0x000000018A707234-0x000000018A707338
		static ReusableLinkedArrayBufferWriter(); // 0x000000018A7071D0-0x000000018A707234
	
		// Methods
		public byte[] DangerousGetFirstBuffer(); // 0x000000018385B100-0x000000018385B110
		[NullableContext(0)]
		public Memory<byte> GetMemory(int sizeHint = 0 /* Metadata: 0x0234D24D */); // 0x000000018A706708-0x000000018A706754
		[NullableContext(0)]
		public Span<byte> GetSpan(int sizeHint = 0 /* Metadata: 0x0234D24E */); // 0x000000018A706754-0x000000018A706898
		public void Advance(int count); // 0x000000018A7066BC-0x000000018A7066DC
		public byte[] ToArrayAndReset(); // 0x000000018A706A44-0x000000018A706DB0
		public void WriteToAndReset(ref MemoryPackWriter writer); // 0x000000018A706E94-0x000000018A7071D0
		public async ValueTask WriteToAndResetAsync(Stream stream, CancellationToken cancellationToken); // 0x000000018A706DB0-0x000000018A706E94
		public Enumerator GetEnumerator(); // 0x000000018A7066DC-0x000000018A706708
		private void ResetCore(); // 0x000000018A706898-0x000000018A7068F4
		public void Reset(); // 0x000000018A7068F4-0x000000018A706A44
	}

	internal struct BufferSegment // TypeDefIndex: 59983
	{
		// Fields
		[Nullable(1)]
		private byte[] buffer; // 0x00
		private int written; // 0x08
	
		// Properties
		public bool IsNull { get; } // 0x000000018314CD60-0x000000018314CD70 
		public int WrittenCount { get; } // 0x0000000184D88B10-0x0000000184D88B20 
		public Span<byte> WrittenBuffer { get; } // 0x000000018A6FFDB8-0x000000018A6FFE1C 
		public Memory<byte> WrittenMemory { get; } // 0x000000018A6FFE1C-0x000000018A6FFE80 
		public Span<byte> FreeBuffer { get; } // 0x000000018A6FFD64-0x000000018A6FFDB8 
	
		// Constructors
		public BufferSegment(int size); // 0x000000018A6FFCE4-0x000000018A6FFD64
	
		// Methods
		public void Advance(int count); // 0x0000000184DA3A90-0x0000000184DA3AA0
		public void Clear(); // 0x000000018A6FFC68-0x000000018A6FFCE4
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class ReusableReadOnlySequenceBuilderPool // TypeDefIndex: 59984
	{
		// Fields
		private static readonly ConcurrentQueue<ReusableReadOnlySequenceBuilder> queue; // 0x00
	
		// Constructors
		static ReusableReadOnlySequenceBuilderPool(); // 0x000000018A7074B0-0x000000018A70753C
	
		// Methods
		public static ReusableReadOnlySequenceBuilder Rent(); // 0x000000018A707388-0x000000018A707434
		public static void Return(ReusableReadOnlySequenceBuilder builder); // 0x000000018A707434-0x000000018A7074B0
	}

	internal sealed class ReusableReadOnlySequenceBuilder // TypeDefIndex: 59986
	{
		// Fields
		[Nullable(1)]
		private readonly Stack<Segment> segmentPool; // 0x10
		[Nullable(1)]
		private readonly List<Segment> list; // 0x18
	
		// Nested types
		private class Segment : ReadOnlySequenceSegment<byte> // TypeDefIndex: 59985
		{
			// Fields
			private bool returnToPool; // 0x30
	
			// Constructors
			public Segment(); // 0x000000018A707D3C-0x000000018A707D74
	
			// Methods
			public void SetBuffer(ReadOnlyMemory<byte> buffer, bool returnToPool); // 0x000000018A707C80-0x000000018A707CDC
			public void Reset(); // 0x000000018A707B40-0x000000018A707C80
			[NullableContext(2)]
			public void SetRunningIndexAndNext(long runningIndex, Segment nextSegment); // 0x000000018A707CDC-0x000000018A707D3C
		}
	
		// Constructors
		public ReusableReadOnlySequenceBuilder(); // 0x000000018A707A80-0x000000018A707B40
	
		// Methods
		public void Add(ReadOnlyMemory<byte> buffer, bool returnToPool); // 0x000000018A70753C-0x000000018A707638
		public bool TryGetSingleMemory(out ReadOnlyMemory<byte> memory); // 0x000000018A7079E4-0x000000018A707A80
		public ReadOnlySequence<byte> Build(); // 0x000000018A707638-0x000000018A70786C
		public void Reset(); // 0x000000018A70786C-0x000000018A7079E4
	}

	internal static class TypeHelpers // TypeDefIndex: 59989
	{
		// Fields
		[Nullable(1)]
		private static readonly MethodInfo isReferenceOrContainsReferences; // 0x00
		[Nullable(1)]
		private static readonly MethodInfo unsafeSizeOf; // 0x08
	
		// Nested types
		private static class Cache<T> // TypeDefIndex: 59987
		{
			// Fields
			public static bool IsReferenceOrNullable;
			public static bool IsUnmanagedSZArray;
			public static int UnmanagedSZArrayElementSize;
			public static bool IsFixedSizeMemoryPackable;
			public static int MemoryPackableFixedSize;
	
			// Constructors
			static Cache();
		}
	
		internal enum TypeKind : byte // TypeDefIndex: 59988
		{
			None = 0,
			UnmanagedSZArray = 1,
			FixedSizeMemoryPackable = 2
		}
	
		// Constructors
		static TypeHelpers(); // 0x000000018A708850-0x000000018A708964
	
		// Methods
		[NullableContext(2)]
		public static bool IsReferenceOrNullable<T>();
		[NullableContext(2)]
		public static TypeKind TryGetUnmanagedSZArrayElementSizeOrMemoryPackableFixedSize<T>(out int size);
		[NullableContext(1)]
		public static bool IsAnonymous(System.Type type); // 0x000000018A7086F8-0x000000018A708850
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 59923
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 59924
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Embedded]
	internal sealed class NullableAttribute : Attribute // TypeDefIndex: 59925
	{
		// Fields
		public readonly byte[] NullableFlags; // 0x10
	
		// Constructors
		public NullableAttribute(byte param_000803fe); // 0x0000000183F26320-0x0000000183F26390
		public NullableAttribute(byte[] param_000803ff); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Embedded]
	internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 59926
	{
		// Fields
		public readonly byte Flag; // 0x10
	
		// Constructors
		public NullableContextAttribute(byte param_00080400); // 0x0000000184D86130-0x0000000184D86140
	}

	internal sealed class IsExternalInit // TypeDefIndex: 59928
	{
		// Constructors
		public IsExternalInit(); // 0x00000001841E1670-0x00000001841E1680
	}
}
