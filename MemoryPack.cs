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
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

// Image 46: MemoryPack.dll - Assembly: MemoryPack, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 87141-87305

public class MemoryPackRegister<T> // TypeDefIndex: 87146
{
	// Fields
	public static Func<bool> s_initFunc;

	// Constructors
	public MemoryPackRegister();
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 87305
{
	// Fields
	internal static readonly int AD95131BC0B799C0B1AF477FB14FCF26A6A9F76079E48BF090ACB7E8367BFD0E; // 0x00 // Static value (base64): /////w== - Metadata: 0x02646348
	internal static readonly int DF3F619804A92FDB4057192DC43DD748EA778ADC52BC498CE80524C014B81119; // 0x04 // Static value (base64): AAAAAA== - Metadata: 0x02646350
}

namespace Beyond.MemoryPack
{
	public static class MemoryPackLazyFormatterRegister // TypeDefIndex: 87148
	{
		// Fields
		private static readonly object s_lock; // 0x00
		private static readonly List<Func<System.Type, bool>> s_resolvers; // 0x08
		private static readonly HashSet<System.Type> s_initializedTypes; // 0x10
	
		// Constructors
		static MemoryPackLazyFormatterRegister(); // 0x0000000186FAB8E0-0x0000000186FABA30
	
		// Methods
		public static void RegisterResolver(Func<System.Type, bool> resolver); // 0x00000001862D0D80-0x00000001862D0F70
		public static bool TryInit(System.Type type); // 0x0000000185473C50-0x0000000185473F40
		public static bool InitOnce(System.Type type, Func<bool> init); // 0x000000018687AA70-0x000000018687ACF0
	}
}

namespace MemoryPack
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackableAttribute : Attribute // TypeDefIndex: 87149
	{
		// Fields
		[CompilerGenerated]
		private readonly GenerateType _GenerateType_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly SerializeLayout _SerializeLayout_k__BackingField; // 0x14
	
		// Properties
		public GenerateType GenerateType { [CompilerGenerated] get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
		public SerializeLayout SerializeLayout { [CompilerGenerated] get; } // 0x0000000182971EE0-0x0000000182971EF0 
	
		// Constructors
		public MemoryPackableAttribute(GenerateType generateType = GenerateType.Object /* Metadata: 0x026462EF */); // 0x000000018C8C8108-0x000000018C8C811C
		public MemoryPackableAttribute(SerializeLayout serializeLayout); // 0x0000000187251660-0x0000000187251670
		public MemoryPackableAttribute(GenerateType generateType, SerializeLayout serializeLayout); // 0x0000000187235240-0x0000000187235250
	}

	public enum GenerateType // TypeDefIndex: 87150
	{
		Object = 0,
		VersionTolerant = 1,
		CircularReference = 2,
		Collection = 3,
		NoGenerate = 4
	}

	public enum SerializeLayout // TypeDefIndex: 87151
	{
		Sequential = 0,
		Explicit = 1
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	[Nullable(0)]
	[NullableContext(1)]
	public sealed class MemoryPackUnionAttribute : Attribute // TypeDefIndex: 87152
	{
		// Fields
		[CompilerGenerated]
		private readonly ushort _Tag_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly System.Type _Type_k__BackingField; // 0x18
	
		// Properties
		public ushort Tag { [CompilerGenerated] get; } // 0x0000000184434E50-0x0000000184434E60 
		public System.Type Type { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
	
		// Constructors
		public MemoryPackUnionAttribute(ushort tag, System.Type type); // 0x000000018C8C6ACC-0x000000018C8C6AE0
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	[Nullable(0)]
	[NullableContext(1)]
	public sealed class MemoryPackUnionFormatterAttribute : Attribute // TypeDefIndex: 87153
	{
		// Fields
		[CompilerGenerated]
		private readonly System.Type _Type_k__BackingField; // 0x10
	
		// Properties
		public System.Type Type { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		public MemoryPackUnionFormatterAttribute(System.Type type); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackAllowSerializeAttribute : Attribute // TypeDefIndex: 87154
	{
		// Constructors
		public MemoryPackAllowSerializeAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackOrderAttribute : Attribute // TypeDefIndex: 87155
	{
		// Fields
		[CompilerGenerated]
		private readonly int _Order_k__BackingField; // 0x10
	
		// Properties
		public int Order { [CompilerGenerated] get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
	
		// Constructors
		public MemoryPackOrderAttribute(int order); // 0x0000000182234E90-0x0000000182234EA0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackIgnoreAttribute : Attribute // TypeDefIndex: 87156
	{
		// Constructors
		public MemoryPackIgnoreAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackIncludeAttribute : Attribute // TypeDefIndex: 87157
	{
		// Constructors
		public MemoryPackIncludeAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackConstructorAttribute : Attribute // TypeDefIndex: 87158
	{
		// Constructors
		public MemoryPackConstructorAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackOnSerializingAttribute : Attribute // TypeDefIndex: 87159
	{
		// Constructors
		public MemoryPackOnSerializingAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackOnSerializedAttribute : Attribute // TypeDefIndex: 87160
	{
		// Constructors
		public MemoryPackOnSerializedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackOnDeserializingAttribute : Attribute // TypeDefIndex: 87161
	{
		// Constructors
		public MemoryPackOnDeserializingAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class MemoryPackOnDeserializedAttribute : Attribute // TypeDefIndex: 87162
	{
		// Constructors
		public MemoryPackOnDeserializedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public sealed class GenerateTypeScriptAttribute : Attribute // TypeDefIndex: 87163
	{
		// Constructors
		public GenerateTypeScriptAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class MemoryPackFormatterProvider // TypeDefIndex: 87166
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
		private static class Check<T> // TypeDefIndex: 87164
		{
			// Fields
			public static bool registered;
		}
	
		[Nullable(0)]
		public static class Cache<T> // TypeDefIndex: 87165
		{
			// Fields
			[Nullable(new byte[2] {2, 1 })]
			private static MemoryPackFormatter<T> _formatter;
	
			// Properties
			public static MemoryPackFormatter<T> formatter { get; set; }
		}
	
		// Constructors
		static MemoryPackFormatterProvider(); // 0x0000000185B7B2A0-0x0000000185B7C060
	
		// Methods
		private static void RegisterInitialFormatters(); // 0x0000000186781190-0x0000000186781730
		[NullableContext(2)]
		public static bool IsRegistered<T>();
		public static bool HasFormatter(System.Type type); // 0x0000000186035500-0x00000001860360C0
		[NullableContext(2)]
		public static bool HasFormatter<T>();
		public static void Register<T>(MemoryPackFormatter<T> formatter);
		public static void RegisterWrap(IMemoryPackFormatter formatter, System.Type type); // 0x000000018585B050-0x000000018585B0E0
		public static void RegisterGenericType(System.Type genericType, System.Type genericFormatterType); // 0x000000018C8C2AC4-0x000000018C8C2BDC
		[NullableContext(0)]
		public static void RegisterCollection<TCollection, TElement>()
			where TCollection : ICollection<TElement>, new();
		public static void RegisterCollection(System.Type genericCollectionType); // 0x000000018C8C286C-0x000000018C8C2998
		[NullableContext(0)]
		public static void RegisterSet<TSet, TElement>()
			where TSet : ISet<TElement>, new();
		public static void RegisterSet(System.Type genericSetType); // 0x000000018C8C2BDC-0x000000018C8C2D08
		[NullableContext(0)]
		public static void RegisterDictionary<TDictionary, TKey, TValue>()
			where TDictionary : IDictionary<TKey, TValue>, new();
		public static void RegisterDictionary(System.Type genericDictionaryType); // 0x000000018C8C2998-0x000000018C8C2AC4
		public static MemoryPackFormatter<T> GetFormatter<T>();
		public static IMemoryPackFormatter GetFormatter(System.Type type); // 0x000000018C8C2824-0x000000018C8C286C
		internal static IMemoryPackFormatter GetFormatter_(System.Type type); // 0x000000018C8C253C-0x000000018C8C2824
		private static bool TryInvokeRegisterFormatter(System.Type type); // 0x000000018C8C2EE0-0x000000018C8C3044
		public static void ForceRegister<T>(MemoryPackFormatter<T> formatter);
		internal static object CreateGenericFormatter(System.Type type, bool typeIsReferenceOrContainsReferences); // 0x000000018C8C2170-0x000000018C8C253C
		private static System.Type TryCreateGenericFormatterType(System.Type type, IDictionary<System.Type, System.Type> knownTypes); // 0x000000018C8C2E2C-0x000000018C8C2EE0
		private static System.Type TryCreateGenericCollectionFormatterType(System.Type type); // 0x000000018C8C2D08-0x000000018C8C2E2C
		internal static void RegisterWellKnownTypesFormatters(); // 0x000000018666D5C0-0x000000018666F830
		[NullableContext(0)]
		private static void UnityRegister<T>()
			where T : struct;
	}

	public interface IMemoryPackFormatterRegister // TypeDefIndex: 87167
	{
	}

	public interface IMemoryPackable<T> : IMemoryPackFormatterRegister // TypeDefIndex: 87168
	{
	}

	[MemoryPack.Internal.Preserve]
	public abstract class IMemoryPackFormatter // TypeDefIndex: 87169
	{
		// Constructors
		protected IMemoryPackFormatter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[NullableContext(2)]
		public abstract void Deserialize(ref MemoryPackReader reader, ref object value);
	}

	[Nullable(0)]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public abstract class MemoryPackFormatter<T> : IMemoryPackFormatter // TypeDefIndex: 87170
	{
		// Constructors
		protected MemoryPackFormatter();
	
		// Methods
		public abstract void Deserialize(ref MemoryPackReader reader, ref ref T value);
		public override void Deserialize(ref MemoryPackReader reader, ref object value);
	}

	public static class MemoryPackCode // TypeDefIndex: 87171
	{
		// Fields
		public const int NullCollection = -1; // Metadata: 0x026462F7
		public const byte WideTag = 250; // Metadata: 0x026462F8
		public const byte ReferenceId = 250; // Metadata: 0x026462F9
		public const byte Reserved1 = 250; // Metadata: 0x026462FA
		public const byte Reserved2 = 251; // Metadata: 0x026462FB
		public const byte Reserved3 = 252; // Metadata: 0x026462FC
		public const byte Reserved4 = 253; // Metadata: 0x026462FD
		public const byte Reserved5 = 254; // Metadata: 0x026462FE
		public const byte NullObject = 255; // Metadata: 0x026462FF
	
		// Properties
		internal static ReadOnlySpan<byte> NullCollectionData { get; } // 0x000000018C8C20B8-0x000000018C8C2114 
		internal static ReadOnlySpan<byte> ZeroCollectionData { get; } // 0x000000018C8C2114-0x000000018C8C2170 
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal sealed class ErrorMemoryPackFormatter : IMemoryPackFormatter // TypeDefIndex: 87172
	{
		// Fields
		private readonly System.Type type; // 0x10
		[Nullable(2)]
		private readonly string message; // 0x18
	
		// Constructors
		public ErrorMemoryPackFormatter(System.Type type); // 0x0000000186183450-0x0000000186183480
		public ErrorMemoryPackFormatter(System.Type type, string message); // 0x0000000185381AC0-0x0000000185381AF0
	
		// Methods
		[NullableContext(2)]
		public override void Deserialize(ref MemoryPackReader reader, ref object value); // 0x000000018C8C1CC0-0x000000018C8C1CCC
		[DoesNotReturn]
		private void Throw(); // 0x000000018C8C1CCC-0x000000018C8C1CEC
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	internal sealed class ErrorMemoryPackFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 87173
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
	[Nullable(0)]
	[NullableContext(1)]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct MemoryPackReader // TypeDefIndex: 87174
	{
		// Fields
		[Nullable(0)]
		private ReadOnlySequence<byte> bufferSource; // 0x00
		private readonly long totalLength; // 0x18
		[Nullable(0)]
		private ReadOnlySpan<byte> bufferReference; // 0x20
		private int bufferLength; // 0x30
		[Nullable(2)]
		private byte[] rentBuffer; // 0x38
		private int advancedCount; // 0x40
		private int consumed; // 0x44
		private readonly MemoryPackReaderOptionalState optionalState; // 0x48
		[Nullable(0)]
		private unsafe byte* currentPtr; // 0x50
	
		// Properties
		public int Consumed { get; } // 0x0000000182271C40-0x0000000182271C50 
		public long Remaining { get; } // 0x0000000187251650-0x0000000187251660 
		public MemoryPackReaderOptionalState OptionalState { get; } // 0x000000018226EE80-0x000000018226EE90 
		public MemoryPackSerializerOptions Options { get; } // 0x000000018C8C5250-0x000000018C8C526C 
	
		// Constructors
		[NullableContext(0)]
		public unsafe MemoryPackReader([IsReadOnly] in ReadOnlySequence<byte> sequence, [Nullable(1)] MemoryPackReaderOptionalState optionalState); // 0x000000018C8C5118-0x000000018C8C5250
		[NullableContext(0)]
		public unsafe MemoryPackReader(ReadOnlySpan<byte> buffer, [Nullable(1)] MemoryPackReaderOptionalState optionalState); // 0x0000000185EF1540-0x0000000185EF1840
	
		// Methods
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		public ref byte GetSpanReference(int sizeHint); // 0x000000018C8C3A24-0x000000018C8C3A40
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private ref byte GetNextSpan(int sizeHint); // 0x000000018C8C34B0-0x000000018C8C3810
		public void Advance(int count); // 0x000000018C8C33B0-0x000000018C8C33F8
		private bool TryAdvanceSequence(int count); // 0x000000018C8C4D40-0x000000018C8C4E80
		[NullableContext(0)]
		public void GetRemainingSource(out ReadOnlySpan<byte> singleSource, out ReadOnlySequence<byte> remainingSource); // 0x000000018C8C3810-0x000000018C8C3A24
		public void Dispose(); // 0x000000018C8C33F8-0x000000018C8C3468
		public IMemoryPackFormatter GetFormatter(System.Type type); // 0x000000018C8C3468-0x000000018C8C34B0
		public MemoryPackFormatter<T> GetFormatter<T>();
		public bool TryReadObjectHeader(out byte memberCount); // 0x000000018C8C5028-0x000000018C8C5074
		public bool TryReadUnionHeader(out ushort tag); // 0x000000018C8C5074-0x000000018C8C5118
		public bool TryReadCollectionHeader(out int length); // 0x000000018C8C4FC0-0x000000018C8C5028
		public bool PeekIsNull(); // 0x000000018C8C3A40-0x000000018C8C3A6C
		public bool TryPeekObjectHeader(out byte memberCount); // 0x000000018C8C4EDC-0x000000018C8C4F18
		public bool TryPeekUnionHeader(out ushort tag); // 0x000000018C8C4F18-0x000000018C8C4F84
		public bool TryPeekUshort(out ushort tag); // 0x000000018C8C4F84-0x000000018C8C4FC0
		public bool TryPeekCollectionHeader(out int length); // 0x000000018C8C4E80-0x000000018C8C4EDC
		public bool DangerousTryReadCollectionHeader(out int length); // 0x000000018C8BEA70-0x000000018C8BEAE8
		[NullableContext(2)]
		public string ReadString(); // 0x000000018C8C3B38-0x000000018C8C3BA0
		private string ReadUtf16(int length); // 0x000000018C8C3BA0-0x000000018C8C3C78
		public string ReadUtf8(int utf8Length); // 0x000000018C8C3C78-0x000000018C8C3D00
		[NullableContext(0)]
		public T1 ReadUnmanaged<T1>()
			where T1 : struct;
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		public bool ReadBoolean(); // 0x000000018C8C3A6C-0x000000018C8C3AB0
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		public byte ReadByte(); // 0x000000018997BEEC-0x000000018997BF30
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		public sbyte ReadSByte(); // 0x000000018997BEEC-0x000000018997BF30
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		public short ReadInt16(); // 0x0000000189B7EFCC-0x0000000189B7F010
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		public ushort ReadUInt16(); // 0x0000000189B7EFCC-0x0000000189B7F010
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		public int ReadInt32(); // 0x0000000189B7F06C-0x0000000189B7F0AC
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		public uint ReadUInt32(); // 0x0000000189B7F06C-0x0000000189B7F0AC
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		public long ReadInt64(); // 0x0000000189B7F194-0x0000000189B7F1D8
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		public ulong ReadUInt64(); // 0x0000000189B7F194-0x0000000189B7F1D8
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		public float ReadSingle(); // 0x000000018C8C3AF4-0x000000018C8C3B38
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		public double ReadDouble(); // 0x000000018C8C3AB0-0x000000018C8C3AF4
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		public char ReadChar(); // 0x0000000189B7EFCC-0x0000000189B7F010
		[NullableContext(2)]
		public void ReadPackable<T>(ref ref T value);
		[NullableContext(2)]
		public T ReadPackable<T>();
		[NullableContext(2)]
		public void ReadValue<T>(ref ref T value);
		[NullableContext(2)]
		public T ReadValue<T>();
		public void ReadValue(System.Type type, [Nullable(2)] ref object value); // 0x000000018A4EDF50-0x000000018A4EDF90
		public object ReadValue(System.Type type); // 0x000000018C8C3D00-0x000000018C8C3D44
		public void ReadValueWithFormatter<TFormatter, T>(TFormatter formatter, [Nullable(2)] ref ref T value)
			where TFormatter : MemoryPackFormatter<T>;
		public T ReadValueWithFormatter<TFormatter, T>(TFormatter formatter)
			where TFormatter : MemoryPackFormatter<T>;
		[NullableContext(2)]
		public T[] ReadArray<T>();
		[NullableContext(2)]
		public void ReadArray<T>(ref ref T[] value);
		[NullableContext(2)]
		public void ReadSpan<T>([Nullable(new byte[2] {0, 2 })] ref Span<T> value);
		[NullableContext(2)]
		public T[] ReadPackableArray<T>();
		[NullableContext(2)]
		public void ReadPackableArray<T>(ref ref T[] value);
		[NullableContext(2)]
		public void ReadPackableSpan<T>([Nullable(new byte[2] {0, 2 })] ref Span<T> value);
		[NullableContext(0)]
		public T[] ReadUnmanagedArray<T>()
			where T : struct;
		[NullableContext(0)]
		public void ReadUnmanagedArray<T>([Nullable(new byte[2] {2, 0 })] ref ref T[] value)
			where T : struct;
		[NullableContext(0)]
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
		[NullableContext(2)]
		public void ReadPackableSpanWithoutReadLengthHeader<T>(int length, [Nullable(new byte[2] {0, 2 })] ref Span<T> value);
		[NullableContext(0)]
		public void DangerousReadUnmanagedSpanView<T>(out bool isNull, out ReadOnlySpan<byte> view);
		[NullableContext(0)]
		public void ReadUnmanaged<T1>(out ref T1 value1)
			where T1 : struct;
		[NullableContext(0)]
		public void ReadUnmanaged<T1, T2>(out ref T1 value1, out ref T2 value2)
			where T1 : struct
			where T2 : struct;
		[NullableContext(0)]
		public void ReadUnmanaged<T1, T2, T3>(out ref T1 value1, out ref T2 value2, out ref T3 value3)
			where T1 : struct
			where T2 : struct
			where T3 : struct;
		[NullableContext(0)]
		public void ReadUnmanaged<T1, T2, T3, T4>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct;
		[NullableContext(0)]
		public void ReadUnmanaged<T1, T2, T3, T4, T5>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct;
		[NullableContext(0)]
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct;
		[NullableContext(0)]
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6, T7>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct;
		[NullableContext(0)]
		public void ReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8)
			where T1 : struct
			where T2 : struct
			where T3 : struct
			where T4 : struct
			where T5 : struct
			where T6 : struct
			where T7 : struct
			where T8 : struct;
		[NullableContext(0)]
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
		[NullableContext(0)]
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
		[NullableContext(0)]
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
		[NullableContext(0)]
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
		[NullableContext(0)]
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
		[NullableContext(0)]
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
		[NullableContext(0)]
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
		public void DangerousReadUnmanaged<T1>(out ref T1 value1);
		public void DangerousReadUnmanaged<T1, T2>(out ref T1 value1, out ref T2 value2);
		public void DangerousReadUnmanaged<T1, T2, T3>(out ref T1 value1, out ref T2 value2, out ref T3 value3);
		public void DangerousReadUnmanaged<T1, T2, T3, T4>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4);
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5);
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6);
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7);
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8);
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9);
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10);
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11);
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12);
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12, out ref T13 value13);
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12, out ref T13 value13, out ref T14 value14);
		public void DangerousReadUnmanaged<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(out ref T1 value1, out ref T2 value2, out ref T3 value3, out ref T4 value4, out ref T5 value5, out ref T6 value6, out ref T7 value7, out ref T8 value8, out ref T9 value9, out ref T10 value10, out ref T11 value11, out ref T12 value12, out ref T13 value13, out ref T14 value14, out ref T15 value15);
		public byte ReadVarIntByte(); // 0x000000018C8C3D44-0x000000018C8C3F50
		public sbyte ReadVarIntSByte(); // 0x000000018C8C4540-0x000000018C8C47B4
		public ushort ReadVarIntUInt16(); // 0x000000018C8C47B4-0x000000018C8C49BC
		public short ReadVarIntInt16(); // 0x000000018C8C3F50-0x000000018C8C4184
		public uint ReadVarIntUInt32(); // 0x000000018C8C49BC-0x000000018C8C4B90
		public int ReadVarIntInt32(); // 0x000000018C8C4184-0x000000018C8C436C
		public ulong ReadVarIntUInt64(); // 0x000000018C8C4B90-0x000000018C8C4D40
		public long ReadVarIntInt64(); // 0x000000018C8C436C-0x000000018C8C4540
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class MemoryPackReaderOptionalStatePool // TypeDefIndex: 87175
	{
		// Fields
		private static readonly ConcurrentQueue<MemoryPackReaderOptionalState> queue; // 0x00
	
		// Constructors
		static MemoryPackReaderOptionalStatePool(); // 0x000000018C8C3194-0x000000018C8C3220
	
		// Methods
		public static MemoryPackReaderOptionalState Rent([Nullable(2)] MemoryPackSerializerOptions options); // 0x000000018C8C3044-0x000000018C8C3118
		internal static void Return(MemoryPackReaderOptionalState state); // 0x000000018C8C3118-0x000000018C8C3194
	}

	[Nullable(0)]
	[NullableContext(1)]
	public sealed class MemoryPackReaderOptionalState : IDisposable // TypeDefIndex: 87176
	{
		// Fields
		private readonly Dictionary<uint, object> refToObject; // 0x10
		[CompilerGenerated]
		private MemoryPackSerializerOptions _Options_k__BackingField; // 0x18
	
		// Properties
		public MemoryPackSerializerOptions Options { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		internal MemoryPackReaderOptionalState(); // 0x0000000185EF0DD0-0x0000000185EF0E60
	
		// Methods
		[NullableContext(2)]
		internal void Init(MemoryPackSerializerOptions options); // 0x0000000185EF1450-0x0000000185EF14B0
		public object GetObjectReference(uint id); // 0x000000018C8C32C0-0x000000018C8C3364
		public void AddObjectReference(uint id, object value); // 0x000000018C8C3220-0x000000018C8C32C0
		public void Reset(); // 0x0000000185EF14B0-0x0000000185EF1540
		void IDisposable.Dispose(); // 0x000000018C8C3364-0x000000018C8C33B0
	}

	internal static class VarIntCodes // TypeDefIndex: 87177
	{
		// Fields
		public const byte MaxSingleValue = 127; // Metadata: 0x02646300
		public const sbyte MinSingleValue = 136; // Metadata: 0x02646301
		public const sbyte Byte = 135; // Metadata: 0x02646302
		public const sbyte SByte = 134; // Metadata: 0x02646303
		public const sbyte UInt16 = 133; // Metadata: 0x02646304
		public const sbyte Int16 = 132; // Metadata: 0x02646305
		public const sbyte UInt32 = 131; // Metadata: 0x02646306
		public const sbyte Int32 = 130; // Metadata: 0x02646307
		public const sbyte UInt64 = 129; // Metadata: 0x02646308
		public const sbyte Int64 = 128; // Metadata: 0x02646309
	}

	[IsByRefLike]
	[Nullable(0)]
	[NullableContext(1)]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct MemoryPackWriter // TypeDefIndex: 87178
	{
		// Fields
		private const int DepthLimit = 1000; // Metadata: 0x0264630B
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
		public int WrittenCount { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public int BufferLength { get; } // 0x00000001844AF510-0x00000001844AF520 
		public MemoryPackWriterOptionalState OptionalState { get; } // 0x00000001829600D0-0x00000001829600E0 
		public MemoryPackSerializerOptions Options { get; } // 0x000000018C8C80EC-0x000000018C8C8108 
	
		// Constructors
		public MemoryPackWriter(ref IBufferWriter<byte> writer, MemoryPackWriterOptionalState optionalState); // 0x000000018C8C80A8-0x000000018C8C80EC
		public MemoryPackWriter(ref IBufferWriter<byte> writer, byte[] firstBufferOfWriter, MemoryPackWriterOptionalState optionalState); // 0x000000018C8C7F5C-0x000000018C8C8010
		public MemoryPackWriter(ref IBufferWriter<byte> writer, [Nullable(0)] Span<byte> firstBufferOfWriter, MemoryPackWriterOptionalState optionalState); // 0x000000018C8C8010-0x000000018C8C80A8
	
		// Methods
		public void WriteVarInt(byte x); // 0x000000018C8C7DB8-0x000000018C8C7E34
		public void WriteVarInt(sbyte x); // 0x000000018C8C7E34-0x000000018C8C7EB0
		public void WriteVarInt(ushort x); // 0x000000018C8C7A04-0x000000018C8C7A84
		public void WriteVarInt(short x); // 0x000000018C8C7934-0x000000018C8C7A04
		public void WriteVarInt(uint x); // 0x000000018C8C7EB0-0x000000018C8C7F5C
		public void WriteVarInt(int x); // 0x000000018C8C7B68-0x000000018C8C7C64
		public void WriteVarInt(ulong x); // 0x000000018C8C7A84-0x000000018C8C7B68
		public void WriteVarInt(long x); // 0x000000018C8C7C64-0x000000018C8C7DB8
		public ref byte GetSpanReference(int sizeHint); // 0x000000018C8C71B0-0x000000018C8C7214
		private void RequestNewBuffer(int sizeHint); // 0x000000018C8C72CC-0x000000018C8C7364
		public void Advance(int count); // 0x000000018C8C7084-0x000000018C8C70F8
		public void Flush(); // 0x000000018C8C70F8-0x000000018C8C7168
		public IMemoryPackFormatter GetFormatter(System.Type type); // 0x000000018C8C7168-0x000000018C8C71B0
		public MemoryPackFormatter<T> GetFormatter<T>();
		[NullableContext(2)]
		public int GetStringWriteLength(string value); // 0x000000018C8C7214-0x000000018C8C72CC
		[NullableContext(0)]
		public int GetUnmanageArrayWriteLength<T>([Nullable(new byte[2] {2, 0 })] T[] value)
			where T : struct;
		public void WriteObjectHeader(byte memberCount); // 0x000000018C8C73C0-0x000000018C8C7404
		public void WriteNullObjectHeader(); // 0x000000018C8C7398-0x000000018C8C73C0
		public void WriteObjectReferenceId(uint referenceId); // 0x000000018C8C7404-0x000000018C8C7444
		public void WriteUnionHeader(ushort tag); // 0x000000018C8C7464-0x000000018C8C74C4
		public void WriteNullUnionHeader(); // 0x000000018C8C7398-0x000000018C8C73C0
		public void WriteCollectionHeader(int length); // 0x000000018C8C7364-0x000000018C8C7398
		public void WriteNullCollectionHeader(); // 0x000000018C8BEAE8-0x000000018C8BEF38
		[NullableContext(2)]
		public void WriteString(string value); // 0x000000018C8C7444-0x000000018C8C7464
		[NullableContext(2)]
		public void WriteUtf16(string value); // 0x000000018C8C7600-0x000000018C8C7754
		[NullableContext(0)]
		public void WriteUtf16(ReadOnlySpan<char> value); // 0x000000018C8C74C4-0x000000018C8C7600
		[NullableContext(2)]
		public void WriteUtf8(string value); // 0x000000018C8C7754-0x000000018C8C7888
		[NullableContext(0)]
		public void WriteUtf8(ReadOnlySpan<byte> utf8Value, int utf16Length = -1 /* Metadata: 0x0264630A */); // 0x000000018C8C7888-0x000000018C8C7934
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
	public class MemoryPackSerializationException : Exception // TypeDefIndex: 87179
	{
		// Constructors
		public MemoryPackSerializationException(string message); // 0x0000000186AC7270-0x0000000186AC72B0
		public MemoryPackSerializationException(string message, Exception innerException); // 0x000000018C8C5D2C-0x000000018C8C5D8C
	
		// Methods
		[DoesNotReturn]
		public static void ThrowMessage(string message); // 0x000000018C8C5934-0x000000018C8C598C
		[DoesNotReturn]
		public static void ThrowInvalidPropertyCount(byte expected, byte actual); // 0x000000018C8C5720-0x000000018C8C57D4
		[DoesNotReturn]
		public static void ThrowInvalidPropertyCount(System.Type type, byte expected, byte actual); // 0x0000000186AC7180-0x0000000186AC7270
		[DoesNotReturn]
		public static void ThrowInvalidCollection(); // 0x000000018C8C5668-0x000000018C8C56C4
		[DoesNotReturn]
		public static void ThrowInvalidRange(int expected, int actual); // 0x000000018C8C57D4-0x000000018C8C5888
		[DoesNotReturn]
		public static void ThrowInvalidAdvance(); // 0x000000018C8C560C-0x000000018C8C5668
		[DoesNotReturn]
		public static void ThrowSequenceReachedEnd(); // 0x000000018C8C5C40-0x000000018C8C5C9C
		[DoesNotReturn]
		public static void ThrowWriteInvalidMemberCount(byte memberCount); // 0x000000018C8C5C9C-0x000000018C8C5D2C
		[DoesNotReturn]
		public static void ThrowInsufficientBufferUnless(int length); // 0x000000018C8C557C-0x000000018C8C560C
		[DoesNotReturn]
		public static void ThrowNotRegisteredInProvider(System.Type type); // 0x000000018C8C5AB8-0x000000018C8C5B3C
		[DoesNotReturn]
		public static void ThrowRegisterInProviderFailed(System.Type type, Exception innerException); // 0x000000018C8C5BB0-0x000000018C8C5C40
		[DoesNotReturn]
		public static void ThrowNotFoundInUnionType(System.Type actualType, System.Type baseType); // 0x000000018C8C598C-0x000000018C8C5AB8
		[DoesNotReturn]
		public static void ThrowInvalidTag(ushort tag, System.Type baseType); // 0x000000018C8C5888-0x000000018C8C5934
		[DoesNotReturn]
		public static void ThrowReachedDepthLimit(System.Type type); // 0x000000018C8C5B3C-0x000000018C8C5BB0
		[DoesNotReturn]
		public static void ThrowInvalidConcurrrentCollectionOperation(); // 0x000000018C8C56C4-0x000000018C8C5720
		[DoesNotReturn]
		public static void ThrowDeserializeObjectIsNull(string target); // 0x000000018C8C5468-0x000000018C8C54EC
		[DoesNotReturn]
		public static void ThrowFailedEncoding(OperationStatus status); // 0x000000018C8C54EC-0x000000018C8C557C
		[DoesNotReturn]
		public static void ThrowCompressionFailed(OperationStatus status); // 0x000000018C8C5324-0x000000018C8C53B4
		[DoesNotReturn]
		public static void ThrowCompressionFailed(); // 0x000000018C8C52C8-0x000000018C8C5324
		[DoesNotReturn]
		public static void ThrowAlreadyDecompressed(); // 0x000000018C8C526C-0x000000018C8C52C8
		[DoesNotReturn]
		public static void ThrowDecompressionSizeLimitExceeded(int limit, int size); // 0x000000018C8C53B4-0x000000018C8C5468
	}

	[Nullable(0)]
	[NullableContext(2)]
	public static class MemoryPackSerializer // TypeDefIndex: 87183
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
		private sealed class SerializerWriterThreadStaticState // TypeDefIndex: 87180
		{
			// Fields
			public ReusableLinkedArrayBufferWriter BufferWriter; // 0x10
			public MemoryPackWriterOptionalState OptionalState; // 0x18
	
			// Constructors
			public SerializerWriterThreadStaticState(); // 0x000000018C8C9C50-0x000000018C8C9CF4
	
			// Methods
			[NullableContext(2)]
			public void Init(MemoryPackSerializerOptions options); // 0x000000018C8C9BFC-0x000000018C8C9C1C
			public void Reset(); // 0x000000018C8C9C1C-0x000000018C8C9C50
		}
	
		[CompilerGenerated]
		private struct _DeserializeAsync_d__6<T> : IAsyncStateMachine // TypeDefIndex: 87181
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
		private struct _DeserializeAsync_d__11 : IAsyncStateMachine // TypeDefIndex: 87182
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
			private void MoveNext(); // 0x000000018C8CB554-0x000000018C8CC114
			[DebuggerHidden]
			private void SetStateMachine([Nullable(0)] IAsyncStateMachine stateMachine); // 0x000000018C8CC114-0x000000018C8CC160
		}
	
		// Methods
		public static T Deserialize<T>([Nullable(0)] ReadOnlySpan<byte> buffer, MemoryPackSerializerOptions options = null);
		public static int Deserialize<T>([Nullable(0)] ReadOnlySpan<byte> buffer, ref ref T value, MemoryPackSerializerOptions options = null);
		public static T Deserialize<T>([Nullable(0)] [IsReadOnly] in ReadOnlySequence<byte> buffer, MemoryPackSerializerOptions options = null);
		public static int Deserialize<T>([Nullable(0)] [IsReadOnly] in ReadOnlySequence<byte> buffer, ref ref T value, MemoryPackSerializerOptions options = null);
		public static int Deserialize([Nullable(0)] [IsReadOnly] in ReadOnlySequence<byte> buffer, ref object value, [Nullable(1)] System.Type type, MemoryPackSerializerOptions options = null); // 0x000000018C8C63E4-0x000000018C8C6634
		public static async ValueTask<T> DeserializeAsync<T>([Nullable(1)] Stream stream, MemoryPackSerializerOptions options = null, CancellationToken cancellationToken = default);
		public static object Deserialize([Nullable(1)] System.Type type, [Nullable(0)] ReadOnlySpan<byte> buffer, MemoryPackSerializerOptions options = null); // 0x000000018C8C63B0-0x000000018C8C63E4
		public static int Deserialize([Nullable(1)] System.Type type, [Nullable(0)] ReadOnlySpan<byte> buffer, ref object value, MemoryPackSerializerOptions options = null); // 0x000000018C8C68C4-0x000000018C8C6ACC
		public static object Deserialize([Nullable(1)] System.Type type, [Nullable(0)] [IsReadOnly] in ReadOnlySequence<byte> buffer, MemoryPackSerializerOptions options = null); // 0x000000018C8C6634-0x000000018C8C665C
		public static int Deserialize([Nullable(1)] System.Type type, [Nullable(0)] [IsReadOnly] in ReadOnlySequence<byte> buffer, ref object value, MemoryPackSerializerOptions options = null); // 0x000000018C8C665C-0x000000018C8C68C4
		[NullableContext(1)]
		public static async ValueTask<object> DeserializeAsync(System.Type type, Stream stream, [Nullable(2)] MemoryPackSerializerOptions options = null, CancellationToken cancellationToken = default); // 0x000000018C8C6284-0x000000018C8C63B0
	}

	[Nullable(0)]
	[NullableContext(2)]
	public class MemoryPackSerializerOptions : IEquatable<MemoryPackSerializerOptions> // TypeDefIndex: 87184
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
		protected virtual System.Type EqualityContract { [NullableContext(1)] [CompilerGenerated] get; } // 0x000000018C8C61C8-0x000000018C8C6218 
		public StringEncoding StringEncoding { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
		public IServiceProvider ServiceProvider { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		protected MemoryPackSerializerOptions([Nullable(1)] MemoryPackSerializerOptions original); // 0x0000000186E23EB0-0x0000000186E23EE0
		public MemoryPackSerializerOptions(); // 0x0000000186805BA0-0x0000000186805BB0
		static MemoryPackSerializerOptions(); // 0x0000000186E23D40-0x0000000186E23E50
	
		// Methods
		[NullableContext(0)]
		public override string ToString(); // 0x000000018C8C60D8-0x000000018C8C61C8
		[NullableContext(1)]
		protected virtual bool PrintMembers(StringBuilder builder); // 0x000000018C8C5FC4-0x000000018C8C60D8
		public static bool operator !=(MemoryPackSerializerOptions r1, MemoryPackSerializerOptions r2); // 0x000000018C8C6230-0x000000018C8C6284
		public static bool operator ==(MemoryPackSerializerOptions r1, MemoryPackSerializerOptions r2); // 0x000000018C8C6218-0x000000018C8C6230
		public override int GetHashCode(); // 0x000000018C8C5EC8-0x000000018C8C5FC4
		public override bool Equals(object obj); // 0x000000018C8C5D8C-0x000000018C8C5DE0
		public virtual bool Equals(MemoryPackSerializerOptions other); // 0x000000018C8C5DE0-0x000000018C8C5EC8
		[NullableContext(1)]
		public virtual MemoryPackSerializerOptions _Clone__(); // 0x0000000186E23E50-0x0000000186E23EB0
	}

	public enum StringEncoding : byte // TypeDefIndex: 87185
	{
		Utf16 = 0,
		Utf8 = 1
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class MemoryPackWriterOptionalStatePool // TypeDefIndex: 87186
	{
		// Fields
		private static readonly ConcurrentQueue<MemoryPackWriterOptionalState> queue; // 0x00
	
		// Constructors
		static MemoryPackWriterOptionalStatePool(); // 0x000000018C8C6C30-0x000000018C8C6CBC
	
		// Methods
		public static MemoryPackWriterOptionalState Rent([Nullable(2)] MemoryPackSerializerOptions options); // 0x000000018C8C6AE0-0x000000018C8C6BB4
		internal static void Return(MemoryPackWriterOptionalState state); // 0x000000018C8C6BB4-0x000000018C8C6C30
	}

	[Nullable(0)]
	[NullableContext(1)]
	public sealed class MemoryPackWriterOptionalState : IDisposable // TypeDefIndex: 87188
	{
		// Fields
		internal static readonly MemoryPackWriterOptionalState NullState; // 0x00
		private uint nextId; // 0x10
		private readonly Dictionary<object, uint> objectToRef; // 0x18
		[CompilerGenerated]
		private MemoryPackSerializerOptions _Options_k__BackingField; // 0x20
	
		// Properties
		public MemoryPackSerializerOptions Options { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
	
		// Nested types
		[Nullable(0)]
		private sealed class ReferenceEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 87187
		{
			// Fields
			[CompilerGenerated]
			private static readonly ReferenceEqualityComparer _Instance_k__BackingField; // 0x00
	
			// Properties
			public static ReferenceEqualityComparer Instance { [CompilerGenerated] get; } // 0x000000018C8C82E4-0x000000018C8C8334 
	
			// Constructors
			private ReferenceEqualityComparer(); // 0x0000000186805BA0-0x0000000186805BB0
			static ReferenceEqualityComparer(); // 0x000000018C8C8280-0x000000018C8C82E4
	
			// Methods
			[NullableContext(2)]
			public new bool Equals(object x, object y); // 0x000000018A797384-0x000000018A79738C
			public int GetHashCode(object obj); // 0x0000000187251670-0x0000000187251680
		}
	
		// Constructors
		internal MemoryPackWriterOptionalState(); // 0x000000018C8C6F28-0x000000018C8C7014
		private MemoryPackWriterOptionalState(bool _); // 0x000000018C8C7014-0x000000018C8C7084
		static MemoryPackWriterOptionalState(); // 0x000000018C8C6EB4-0x000000018C8C6F28
	
		// Methods
		[NullableContext(2)]
		internal void Init(MemoryPackSerializerOptions options); // 0x000000018C8C6D98-0x000000018C8C6E08
		public void Reset(); // 0x000000018C8C6E08-0x000000018C8C6E68
		[NullableContext(0)]
		public ValueTuple<bool, uint> GetOrAddReference([Nullable(1)] object value); // 0x000000018C8C6CBC-0x000000018C8C6D98
		void IDisposable.Dispose(); // 0x000000018C8C6E68-0x000000018C8C6EB4
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	internal sealed class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve> // TypeDefIndex: 87189
	{
		// Constructors
		public AnimationCurveFormatter(); // 0x000000018677FBA0-0x000000018677FBD0
	
		// Methods
		private void SerializeKeyFrame(Keyframe keyframe, ref MemoryPackWriter writer); // 0x000000018C8BEF38-0x000000018C8BF004
		private void DeserializeKeyFrame(ref MemoryPackReader reader, out Keyframe keyframe); // 0x00000001853686E0-0x00000001853687D0
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref AnimationCurve value); // 0x0000000185368200-0x0000000185368570
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	internal sealed class GradientFormatter : MemoryPackFormatter<Gradient> // TypeDefIndex: 87190
	{
		// Constructors
		public GradientFormatter(); // 0x000000018677FBD0-0x000000018677FC00
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref Gradient value); // 0x000000018C8C1E70-0x000000018C8C1FD4
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	internal sealed class RectOffsetFormatter : MemoryPackFormatter<RectOffset> // TypeDefIndex: 87191
	{
		// Constructors
		public RectOffsetFormatter(); // 0x000000018677FC00-0x000000018677FC30
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref RectOffset value); // 0x000000018C8C811C-0x000000018C8C8280
	}
}

namespace MemoryPack.Compression
{
	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class BitPackFormatter : MemoryPackFormatter<bool[]> // TypeDefIndex: 87298
	{
		// Fields
		public static readonly BitPackFormatter Default; // 0x00
	
		// Constructors
		public BitPackFormatter(); // 0x000000018C8BF438-0x000000018C8BF460
		static BitPackFormatter(); // 0x000000018C8BF3C8-0x000000018C8BF438
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref bool[] value); // 0x000000018C8BF1F8-0x000000018C8BF38C
		public bool Get(int data, int index); // 0x000000018C8BF38C-0x000000018C8BF3A4
		public void Set(ref int data, int index, bool value); // 0x000000018C8BF3A4-0x000000018C8BF3C8
	}

	public class BrotliCompressor : IBufferWriter<byte>, IDisposable // TypeDefIndex: 87300
	{
		// Fields
		[Nullable(2)]
		private ReusableLinkedArrayBufferWriter bufferWriter; // 0x10
		private readonly int quality; // 0x18
		private readonly int window; // 0x1C
	
		// Nested types
		[CompilerGenerated]
		private struct _CopyToAsync_d__11 : IAsyncStateMachine // TypeDefIndex: 87299
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
			private void MoveNext(); // 0x000000018C8CA828-0x000000018C8CB548
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018C8CB548-0x000000018C8CB554
		}
	
		// Constructors
		public BrotliCompressor(CompressionLevel compressionLevel); // 0x000000018C8C05E0-0x000000018C8C060C
		public BrotliCompressor(CompressionLevel compressionLevel, int window); // 0x000000018C8C053C-0x000000018C8C0574
		public BrotliCompressor(int quality = 1 /* Metadata: 0x02646329 */, int window = 22 /* Metadata: 0x0264632A */); // 0x000000018C8C0574-0x000000018C8C05E0
	
		// Methods
		void IBufferWriter<byte>.Advance(int count); // 0x000000018C8BFEC0-0x000000018C8BFF08
		Memory<byte> IBufferWriter<byte>.GetMemory(int sizeHint); // 0x000000018C8BFF08-0x000000018C8BFF44
		Span<byte> IBufferWriter<byte>.GetSpan(int sizeHint); // 0x000000018C8BFF44-0x000000018C8BFFA0
		[NullableContext(1)]
		public byte[] ToArray(); // 0x000000018C8BFFFC-0x000000018C8C053C
		[NullableContext(1)]
		public void CopyTo([IsReadOnly] in IBufferWriter<byte> destBufferWriter); // 0x000000018C8BF89C-0x000000018C8BFB7C
		[NullableContext(1)]
		public async ValueTask CopyToAsync(Stream stream, int bufferSize = 65535 /* Metadata: 0x0264632B */, CancellationToken cancellationToken = default); // 0x000000018C8BF7A8-0x000000018C8BF89C
		public void CopyTo(ref MemoryPackWriter memoryPackWriter); // 0x000000018C8BFB7C-0x000000018C8BFE50
		private static int CompressCore(ref BrotliEncoder encoder, ReadOnlySpan<byte> source, [Nullable(1)] ref IBufferWriter<byte> destBufferWriter, int? initialLength, bool isFinalBlock); // 0x000000018C8BF460-0x000000018C8BF5EC
		private static int CompressCore(ref BrotliEncoder encoder, ReadOnlySpan<byte> source, ref MemoryPackWriter destBufferWriter, int? initialLength, bool isFinalBlock); // 0x000000018C8BF5EC-0x000000018C8BF7A8
		public void Dispose(); // 0x000000018C8BFE50-0x000000018C8BFEC0
		private void ThrowIfDisposed(); // 0x000000018C8BFFA0-0x000000018C8BFFFC
	}

	internal static class BrotliUtils // TypeDefIndex: 87301
	{
		// Fields
		public const int WindowBits_Min = 10; // Metadata: 0x0264632F
		public const int WindowBits_Default = 22; // Metadata: 0x02646330
		public const int WindowBits_Max = 24; // Metadata: 0x02646331
		public const int Quality_Min = 0; // Metadata: 0x02646332
		public const int Quality_Default = 4; // Metadata: 0x02646333
		public const int Quality_Max = 11; // Metadata: 0x02646334
		public const int MaxInputSize = 2147483132; // Metadata: 0x02646335
	
		// Methods
		internal static int GetQualityFromCompressionLevel(CompressionLevel compressionLevel); // 0x000000018C8C176C-0x000000018C8C17E4
		internal static int BrotliEncoderMaxCompressedSize(int input_size); // 0x000000018C8C174C-0x000000018C8C176C
	}

	public struct BrotliDecompressor : IDisposable // TypeDefIndex: 87302
	{
		// Fields
		[Nullable(2)]
		private ReusableReadOnlySequenceBuilder sequenceBuilder; // 0x00
	
		// Methods
		public ReadOnlySequence<byte> Decompress(ReadOnlySpan<byte> compressedSpan); // 0x000000018C8C0CC0-0x000000018C8C0D10
		public ReadOnlySequence<byte> Decompress(ReadOnlySpan<byte> compressedSpan, out int consumed); // 0x000000018C8C0B44-0x000000018C8C0CC0
		public ReadOnlySequence<byte> Decompress(ReadOnlySequence<byte> compressedSequence); // 0x000000018C8C0D10-0x000000018C8C0D68
		public ReadOnlySequence<byte> Decompress(ReadOnlySequence<byte> compressedSequence, out int consumed); // 0x000000018C8C0884-0x000000018C8C0B44
		private void DecompressCore(ref OperationStatus status, ref BrotliDecoder decoder, ReadOnlySpan<byte> source, out int consumed); // 0x000000018C8C060C-0x000000018C8C0884
		public void Dispose(); // 0x000000018C8C0D68-0x000000018C8C0DCC
		private int GetDoubleCapacity(int length); // 0x000000018C8C0DCC-0x000000018C8C0E18
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class BrotliFormatter : MemoryPackFormatter<byte[]> // TypeDefIndex: 87303
	{
		// Fields
		internal const int DefaultDecompssionSizeLimit = 134217728; // Metadata: 0x0264633A
		public static readonly BrotliFormatter Default; // 0x00
		private readonly CompressionLevel compressionLevel; // 0x10
		private readonly int window; // 0x14
		private readonly int decompressionSizeLimit; // 0x18
	
		// Constructors
		public BrotliFormatter(); // 0x000000018C8C10FC-0x000000018C8C1110
		public BrotliFormatter(CompressionLevel compressionLevel); // 0x000000018C8C116C-0x000000018C8C117C
		public BrotliFormatter(CompressionLevel compressionLevel, int window); // 0x000000018C8C10DC-0x000000018C8C10FC
		public BrotliFormatter(CompressionLevel compressionLevel, int window, int decompressionSizeLimit); // 0x000000018C8C1110-0x000000018C8C116C
		static BrotliFormatter(); // 0x000000018C8C106C-0x000000018C8C10DC
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref byte[] value); // 0x000000018C8C0E18-0x000000018C8C106C
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class BrotliFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 87304
	{
		// Fields
		internal const int DefaultDecompssionSizeLimit = 134217728; // Metadata: 0x0264633E
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
	public sealed class UnmanagedArrayFormatter<T> : MemoryPackFormatter<T[]> // TypeDefIndex: 87209
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
	public sealed class DangerousUnmanagedArrayFormatter<T> : MemoryPackFormatter<T[]> // TypeDefIndex: 87210
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
	public sealed class ArrayFormatter<T> : MemoryPackFormatter<T[]> // TypeDefIndex: 87211
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
	public sealed class ArraySegmentFormatter<T> : MemoryPackFormatter<ArraySegment<T>> // TypeDefIndex: 87212
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
	public sealed class MemoryFormatter<T> : MemoryPackFormatter<Memory<T>> // TypeDefIndex: 87213
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
	public sealed class ReadOnlyMemoryFormatter<T> : MemoryPackFormatter<ReadOnlyMemory<T>> // TypeDefIndex: 87214
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
	public sealed class ReadOnlySequenceFormatter<T> : MemoryPackFormatter<ReadOnlySequence<T>> // TypeDefIndex: 87215
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
	public sealed class MemoryPoolFormatter<T> : MemoryPackFormatter<Memory<T>> // TypeDefIndex: 87216
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
	public sealed class ReadOnlyMemoryPoolFormatter<T> : MemoryPackFormatter<ReadOnlyMemory<T>> // TypeDefIndex: 87217
	{
		// Constructors
		public ReadOnlyMemoryPoolFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, [Nullable(new byte[2] {0, 2 })] ref ReadOnlyMemory<T> value);
	}

	[MemoryPack.Internal.Preserve]
	public sealed class BigIntegerFormatter : MemoryPackFormatter<BigInteger> // TypeDefIndex: 87218
	{
		// Constructors
		public BigIntegerFormatter(); // 0x0000000187227ED0-0x0000000187227F00
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref BigInteger value); // 0x000000018C8BF004-0x000000018C8BF108
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class BitArrayFormatter : MemoryPackFormatter<BitArray> // TypeDefIndex: 87219
	{
		// Constructors
		public BitArrayFormatter(); // 0x0000000187227EA0-0x0000000187227ED0
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref BitArray value); // 0x000000018C8BF108-0x000000018C8BF1F8
	}

	[MemoryPack.Internal.Preserve]
	internal class BitArrayView // TypeDefIndex: 87220
	{
		// Fields
		[Nullable(1)]
		public int[] m_array; // 0x10
		public int m_length; // 0x18
		public int _version; // 0x1C
	
		// Constructors
		public BitArrayView(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Nullable(0)]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public static class ListFormatter // TypeDefIndex: 87221
	{
		// Methods
		[MemoryPack.Internal.Preserve]
		public static List<T> DeserializePackable<T>(ref MemoryPackReader reader);
		[MemoryPack.Internal.Preserve]
		public static void DeserializePackable<T>(ref MemoryPackReader reader, ref List<T> value);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class ListFormatter<T> : MemoryPackFormatter<List<T>> // TypeDefIndex: 87222
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
	public sealed class StackFormatter<T> : MemoryPackFormatter<Stack<T>> // TypeDefIndex: 87223
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
	public sealed class QueueFormatter<T> : MemoryPackFormatter<Queue<T>> // TypeDefIndex: 87224
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
	public sealed class LinkedListFormatter<T> : MemoryPackFormatter<LinkedList<T>> // TypeDefIndex: 87225
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
	public sealed class HashSetFormatter<T> : MemoryPackFormatter<HashSet<T>> // TypeDefIndex: 87226
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
	public sealed class SortedSetFormatter<T> : MemoryPackFormatter<SortedSet<T>> // TypeDefIndex: 87227
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
	public sealed class CollectionFormatter<T> : MemoryPackFormatter<Collection<T>> // TypeDefIndex: 87228
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
	public sealed class ObservableCollectionFormatter<T> : MemoryPackFormatter<ObservableCollection<T>> // TypeDefIndex: 87229
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
	public sealed class ConcurrentQueueFormatter<T> : MemoryPackFormatter<ConcurrentQueue<T>> // TypeDefIndex: 87230
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
	public sealed class ConcurrentStackFormatter<T> : MemoryPackFormatter<ConcurrentStack<T>> // TypeDefIndex: 87231
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
	public sealed class ConcurrentBagFormatter<T> : MemoryPackFormatter<ConcurrentBag<T>> // TypeDefIndex: 87232
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
	public sealed class DictionaryFormatter<TKey, TValue> : MemoryPackFormatter<Dictionary<TKey, TValue>> // TypeDefIndex: 87233
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
	public sealed class SortedDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<SortedDictionary<TKey, TValue>> // TypeDefIndex: 87234
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
	public sealed class SortedListFormatter<TKey, TValue> : MemoryPackFormatter<SortedList<TKey, TValue>> // TypeDefIndex: 87235
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
	public sealed class ConcurrentDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<ConcurrentDictionary<TKey, TValue>> // TypeDefIndex: 87236
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
	public sealed class ReadOnlyCollectionFormatter<T> : MemoryPackFormatter<ReadOnlyCollection<T>> // TypeDefIndex: 87237
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
	public sealed class ReadOnlyObservableCollectionFormatter<T> : MemoryPackFormatter<ReadOnlyObservableCollection<T>> // TypeDefIndex: 87238
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
	public sealed class BlockingCollectionFormatter<T> : MemoryPackFormatter<BlockingCollection<T>> // TypeDefIndex: 87239
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
	public sealed class CultureInfoFormatter : MemoryPackFormatter<CultureInfo> // TypeDefIndex: 87240
	{
		// Constructors
		public CultureInfoFormatter(); // 0x0000000187227840-0x0000000187227870
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref CultureInfo value); // 0x000000018C8C1A08-0x000000018C8C1A80
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	public sealed class DynamicUnionFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 87242
		where T : class
	{
		// Fields
		private readonly Dictionary<System.Type, ushort> typeToTag;
		private readonly Dictionary<ushort, System.Type> tagToType;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 87241
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
		public DynamicUnionFormatter([Nullable(new byte[3] {1, 0, 1 })] [TupleElementNames(new string[2] {"Tag", "Type" })] params ValueTuple<ushort, System.Type>[] memoryPackUnions);
	
		// Methods
		[NullableContext(2)]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T value);
	}

	[Nullable(new byte[2] {0, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class GenericCollectionFormatter<TCollection, TElement> : MemoryPackFormatter<TCollection> // TypeDefIndex: 87243
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
	public abstract class GenericSetFormatterBase<TSet, TElement> : MemoryPackFormatter<TSet> // TypeDefIndex: 87244
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
	public sealed class GenericSetFormatter<TSet, TElement> : GenericSetFormatterBase<TSet, TElement> // TypeDefIndex: 87245
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
	public abstract class GenericDictionaryFormatterBase<TDictionary, TKey, TValue> : MemoryPackFormatter<TDictionary> // TypeDefIndex: 87246
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
	public sealed class GenericDictionaryFormatter<TDictionary, TKey, TValue> : GenericDictionaryFormatterBase<TDictionary, TKey, TValue> // TypeDefIndex: 87247
		where TDictionary : IDictionary<TKey, TValue>, new()
	{
		// Constructors
		public GenericDictionaryFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		protected override TDictionary CreateDictionary();
	}

	internal static class InterfaceCollectionFormatterUtils // TypeDefIndex: 87248
	{
		// Methods
		[NullableContext(2)]
		public static List<T> ReadList<T>(ref MemoryPackReader reader);
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class InterfaceEnumerableFormatter<T> : MemoryPackFormatter<IEnumerable<T>> // TypeDefIndex: 87249
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
	public sealed class InterfaceCollectionFormatter<T> : MemoryPackFormatter<ICollection<T>> // TypeDefIndex: 87250
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
	public sealed class InterfaceReadOnlyCollectionFormatter<T> : MemoryPackFormatter<IReadOnlyCollection<T>> // TypeDefIndex: 87251
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
	public sealed class InterfaceListFormatter<T> : MemoryPackFormatter<IList<T>> // TypeDefIndex: 87252
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
	public sealed class InterfaceReadOnlyListFormatter<T> : MemoryPackFormatter<IReadOnlyList<T>> // TypeDefIndex: 87253
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
	public sealed class InterfaceDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<IDictionary<TKey, TValue>> // TypeDefIndex: 87254
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
	public sealed class InterfaceReadOnlyDictionaryFormatter<TKey, TValue> : MemoryPackFormatter<IReadOnlyDictionary<TKey, TValue>> // TypeDefIndex: 87255
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
	public sealed class InterfaceLookupFormatter<TKey, TElement> : MemoryPackFormatter<ILookup<TKey, TElement>> // TypeDefIndex: 87256
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
	public sealed class InterfaceGroupingFormatter<TKey, TElement> : MemoryPackFormatter<IGrouping<TKey, TElement>> // TypeDefIndex: 87257
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
	public sealed class InterfaceSetFormatter<T> : MemoryPackFormatter<ISet<T>> // TypeDefIndex: 87258
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
	internal sealed class Grouping<TKey, TElement> : IGrouping<TKey, TElement> // TypeDefIndex: 87259
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
	internal sealed class Lookup<TKey, TElement> : ILookup<TKey, TElement> // TypeDefIndex: 87260
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
	public static class KeyValuePairFormatter // TypeDefIndex: 87261
	{
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public static void Deserialize<TKey, TValue>([Nullable(1)] MemoryPackFormatter<TKey> keyFormatter, [Nullable(1)] MemoryPackFormatter<TValue> valueFormatter, ref MemoryPackReader reader, out ref TKey key, out ref TValue value);
	}

	[Nullable(new byte[4] {0, 0, 2, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class KeyValuePairFormatter<TKey, TValue> : MemoryPackFormatter<KeyValuePair<TKey, TValue>> // TypeDefIndex: 87262
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
	public sealed class LazyFormatter<T> : MemoryPackFormatter<Lazy<T>> // TypeDefIndex: 87263
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
	public sealed class TwoDimensionalArrayFormatter<T> : MemoryPackFormatter<T[,]> // TypeDefIndex: 87264
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
	public sealed class ThreeDimensionalArrayFormatter<T> : MemoryPackFormatter<T[,,]> // TypeDefIndex: 87265
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
	public sealed class FourDimensionalArrayFormatter<T> : MemoryPackFormatter<T[,,,]> // TypeDefIndex: 87266
	{
		// Constructors
		public FourDimensionalArrayFormatter();
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref ref T[,,,] value);
	}

	[MemoryPack.Internal.Preserve]
	public sealed class NullableFormatter<T> : MemoryPackFormatter<T?> // TypeDefIndex: 87267
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
	public sealed class StringBuilderFormatter : MemoryPackFormatter<StringBuilder> // TypeDefIndex: 87268
	{
		// Constructors
		public StringBuilderFormatter(); // 0x0000000187225410-0x0000000187225440
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref StringBuilder value); // 0x000000018C8C9CF4-0x000000018C8C9EB4
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class StringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 87269
	{
		// Fields
		public static readonly StringFormatter Default; // 0x00
	
		// Constructors
		public StringFormatter(); // 0x000000018716C140-0x000000018716C170
		static StringFormatter(); // 0x000000018716C0D0-0x000000018716C140
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref string value); // 0x000000018C8C9EB4-0x000000018C8C9ED8
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class Utf8StringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 87270
	{
		// Fields
		public static readonly Utf8StringFormatter Default; // 0x00
	
		// Constructors
		public Utf8StringFormatter(); // 0x000000018C8CD0D0-0x000000018C8CD0F8
		static Utf8StringFormatter(); // 0x000000018C8CD060-0x000000018C8CD0D0
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref string value); // 0x000000018C8C9EB4-0x000000018C8C9ED8
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class Utf16StringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 87271
	{
		// Fields
		public static readonly Utf16StringFormatter Default; // 0x00
	
		// Constructors
		public Utf16StringFormatter(); // 0x000000018C8CD038-0x000000018C8CD060
		static Utf16StringFormatter(); // 0x000000018C8CCFC8-0x000000018C8CD038
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref string value); // 0x000000018C8C9EB4-0x000000018C8C9ED8
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	[MemoryPack.Internal.Preserve]
	public sealed class InternStringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 87272
	{
		// Fields
		public static readonly InternStringFormatter Default; // 0x00
	
		// Constructors
		public InternStringFormatter(); // 0x000000018C8C2080-0x000000018C8C20A8
		static InternStringFormatter(); // 0x000000018C8C2010-0x000000018C8C2080
	
		// Methods
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref string value); // 0x000000018C8C1FD4-0x000000018C8C2010
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class BrotliStringFormatter : MemoryPackFormatter<string> // TypeDefIndex: 87274
	{
		// Fields
		[ThreadStatic]
		private static StrongBox<int> threadStaticConsumedBox; // 0x80000000
		internal const int DefaultDecompssionSizeLimit = 134217728; // Metadata: 0x02646325
		[Nullable(1)]
		public static readonly BrotliStringFormatter Default; // 0x00
		private readonly CompressionLevel compressionLevel; // 0x10
		private readonly int window; // 0x14
		private readonly int decompressionSizeLimit; // 0x18
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 87273
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
			static __c(); // 0x000000018C8CC60C-0x000000018C8CC670
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			[NullableContext(0)]
			internal void _Deserialize_b__10_1(Span<char> stringSpan, [TupleElementNames(new string[4] {null, "Length", "byteLength", "consumedBox" })] ValueTuple<IntPtr, int, int, StrongBox<int>> state); // 0x000000018C8CC41C-0x000000018C8CC60C
			[NullableContext(0)]
			internal void _Deserialize_b__10_0(Span<char> stringSpan, [TupleElementNames(new string[4] {"remainingSource", "Length", "byteLength", "consumedBox" })] ValueTuple<ReadOnlySequence<byte>, long, int, StrongBox<int>> state); // 0x000000018C8CC160-0x000000018C8CC41C
		}
	
		// Constructors
		public BrotliStringFormatter(); // 0x000000018C8C16E0-0x000000018C8C16F0
		public BrotliStringFormatter(CompressionLevel compressionLevel); // 0x000000018C8C1694-0x000000018C8C16C0
		public BrotliStringFormatter(CompressionLevel compressionLevel, int window); // 0x000000018C8C16C0-0x000000018C8C16E0
		public BrotliStringFormatter(CompressionLevel compressionLevel, int window, int decompressionSizeLimit); // 0x000000018C8C16F0-0x000000018C8C174C
		static BrotliStringFormatter(); // 0x000000018C8C1624-0x000000018C8C1694
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref string value); // 0x000000018C8C117C-0x000000018C8C1624
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TimeZoneInfoFormatter : MemoryPackFormatter<TimeZoneInfo> // TypeDefIndex: 87275
	{
		// Constructors
		public TimeZoneInfoFormatter(); // 0x0000000187225320-0x0000000187225350
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref TimeZoneInfo value); // 0x000000018C8C9ED8-0x000000018C8C9F50
	}

	internal static class TupleFormatterTypes // TypeDefIndex: 87276
	{
		// Fields
		[Nullable(1)]
		public static readonly Dictionary<System.Type, System.Type> TupleFormatters; // 0x00
	
		// Constructors
		static TupleFormatterTypes(); // 0x000000018C8C9F50-0x000000018C8CA4D8
	}

	[Nullable(new byte[3] {0, 1, 2 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class TupleFormatter<T1> : MemoryPackFormatter<Tuple<T1>> // TypeDefIndex: 87277
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
	public sealed class TupleFormatter<T1, T2> : MemoryPackFormatter<Tuple<T1, T2>> // TypeDefIndex: 87278
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
	public sealed class TupleFormatter<T1, T2, T3> : MemoryPackFormatter<Tuple<T1, T2, T3>> // TypeDefIndex: 87279
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
	public sealed class TupleFormatter<T1, T2, T3, T4> : MemoryPackFormatter<Tuple<T1, T2, T3, T4>> // TypeDefIndex: 87280
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
	public sealed class TupleFormatter<T1, T2, T3, T4, T5> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5>> // TypeDefIndex: 87281
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
	public sealed class TupleFormatter<T1, T2, T3, T4, T5, T6> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5, T6>> // TypeDefIndex: 87282
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
	public sealed class TupleFormatter<T1, T2, T3, T4, T5, T6, T7> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5, T6, T7>> // TypeDefIndex: 87283
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
	public sealed class TupleFormatter<T1, T2, T3, T4, T5, T6, T7, TRest> : MemoryPackFormatter<Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>> // TypeDefIndex: 87284
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
	public sealed class ValueTupleFormatter<T1> : MemoryPackFormatter<ValueTuple<T1>> // TypeDefIndex: 87285
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
	public sealed class ValueTupleFormatter<T1, T2> : MemoryPackFormatter<ValueTuple<T1, T2>> // TypeDefIndex: 87286
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
	public sealed class ValueTupleFormatter<T1, T2, T3> : MemoryPackFormatter<ValueTuple<T1, T2, T3>> // TypeDefIndex: 87287
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
	public sealed class ValueTupleFormatter<T1, T2, T3, T4> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4>> // TypeDefIndex: 87288
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
	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5>> // TypeDefIndex: 87289
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
	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5, T6> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5, T6>> // TypeDefIndex: 87290
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
	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> // TypeDefIndex: 87291
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
	public sealed class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7, TRest> : MemoryPackFormatter<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>> // TypeDefIndex: 87292
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
	public sealed class TypeFormatter : MemoryPackFormatter<System.Type> // TypeDefIndex: 87293
	{
		// Fields
		private static readonly Regex _shortTypeNameRegex; // 0x00
	
		// Constructors
		public TypeFormatter(); // 0x0000000187225200-0x0000000187225230
		static TypeFormatter(); // 0x000000018714FD40-0x000000018714FDE0
	
		// Methods
		private static Regex ShortTypeNameRegex(); // 0x000000018C8CA56C-0x000000018C8CA5BC
		[NullableContext(2)]
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref System.Type value); // 0x000000018C8CA4D8-0x000000018C8CA56C
	}

	[MemoryPack.Internal.Preserve]
	public sealed class UnmanagedFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 87294
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
	public sealed class DangerousUnmanagedFormatter<T> : MemoryPackFormatter<T> // TypeDefIndex: 87295
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
	public sealed class UriFormatter : MemoryPackFormatter<System.Uri> // TypeDefIndex: 87296
	{
		// Constructors
		public UriFormatter(); // 0x0000000187225080-0x00000001872250B0
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref System.Uri value); // 0x000000018C8CCF30-0x000000018C8CCFC8
	}

	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(2)]
	[MemoryPack.Internal.Preserve]
	public sealed class VersionFormatter : MemoryPackFormatter<System.Version> // TypeDefIndex: 87297
	{
		// Constructors
		public VersionFormatter(); // 0x0000000187224FF0-0x0000000187225020
	
		// Methods
		[MemoryPack.Internal.Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref System.Version value); // 0x000000018C8CD0F8-0x000000018C8CD5D8
	}
}

namespace MemoryPack.Internal
{
	internal static class EnumerableExtensions // TypeDefIndex: 87192
	{
		// Extension methods
		[NullableContext(1)]
		public static bool TryGetNonEnumeratedCountEx<T>(this IEnumerable<T> value, out int count);
	}

	internal struct FixedArrayBufferWriter : IBufferWriter<byte> // TypeDefIndex: 87193
	{
		// Fields
		[Nullable(1)]
		private byte[] buffer; // 0x00
		private int written; // 0x08
	
		// Constructors
		[NullableContext(1)]
		public FixedArrayBufferWriter(byte[] buffer); // 0x000000018783C714-0x000000018783C730
	
		// Methods
		public void Advance(int count); // 0x0000000187251640-0x0000000187251650
		public Memory<byte> GetMemory(int sizeHint = 0 /* Metadata: 0x0264630F */); // 0x000000018C8C1D3C-0x000000018C8C1DDC
		public Span<byte> GetSpan(int sizeHint = 0 /* Metadata: 0x02646310 */); // 0x000000018C8C1DDC-0x000000018C8C1E70
		[NullableContext(1)]
		public byte[] GetFilledBuffer(); // 0x000000018C8C1CEC-0x000000018C8C1D3C
	}

	internal static class MathEx // TypeDefIndex: 87194
	{
		// Fields
		private const int ArrayMexLength = 2147483591; // Metadata: 0x02646311
	
		// Methods
		public static int NewArrayCapacity(int size); // 0x000000018C8C20A8-0x000000018C8C20B8
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class MemoryMarshalEx // TypeDefIndex: 87195
	{
		// Methods
		public static ref ref T GetArrayDataReference<T>(T[] array);
		public static T[] AllocateUninitializedArray<T>(int length, bool pinned = false /* Metadata: 0x02646316 */);
	}

	public sealed class PreserveAttribute : Attribute // TypeDefIndex: 87196
	{
		// Constructors
		public PreserveAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class ReusableLinkedArrayBufferWriterPool // TypeDefIndex: 87197
	{
		// Fields
		private static readonly ConcurrentQueue<ReusableLinkedArrayBufferWriter> queue; // 0x00
	
		// Constructors
		static ReusableLinkedArrayBufferWriterPool(); // 0x000000018C8C8464-0x000000018C8C84F0
	
		// Methods
		public static ReusableLinkedArrayBufferWriter Rent(); // 0x000000018C8C8334-0x000000018C8C83E8
		public static void Return(ReusableLinkedArrayBufferWriter writer); // 0x000000018C8C83E8-0x000000018C8C8464
	}

	[Nullable(0)]
	[NullableContext(1)]
	public sealed class ReusableLinkedArrayBufferWriter : IBufferWriter<byte> // TypeDefIndex: 87201
	{
		// Fields
		private const int InitialBufferSize = 262144; // Metadata: 0x02646319
		private static readonly byte[] noUseFirstBufferSentinel; // 0x00
		private List<BufferSegment> buffers; // 0x10
		private byte[] firstBuffer; // 0x18
		private int firstBufferWritten; // 0x20
		private BufferSegment current; // 0x28
		private int nextBufferSize; // 0x38
		private int totalWritten; // 0x3C
	
		// Properties
		public int TotalWritten { get; } // 0x000000018226F000-0x000000018226F010 
		private bool UseFirstBuffer { get; } // 0x000000018C8C91A0-0x000000018C8C91F0 
	
		// Nested types
		[NullableContext(0)]
		public struct Enumerator : IEnumerator<Memory<byte>> // TypeDefIndex: 87199
		{
			// Fields
			[Nullable(1)]
			private ReusableLinkedArrayBufferWriter parent; // 0x00
			private State state; // 0x08
			private Memory<byte> current; // 0x10
			private List<BufferSegment> buffersEnumerator; // 0x20
	
			// Properties
			public Memory<byte> Current { get; } // 0x0000000184430480-0x0000000184430490 
			[Nullable(1)]
			object IEnumerator.Current { [NullableContext(1)] get; } // 0x000000018C8C1C40-0x000000018C8C1C8C 
	
			// Nested types
			private enum State // TypeDefIndex: 87198
			{
				FirstBuffer = 0,
				BuffersInit = 1,
				BuffersIterate = 2,
				Current = 3,
				End = 4
			}
	
			// Constructors
			[NullableContext(1)]
			public Enumerator(ReusableLinkedArrayBufferWriter parent); // 0x000000018C8C1C8C-0x000000018C8C1CC0
	
			// Methods
			public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			public bool MoveNext(); // 0x000000018C8C1A80-0x000000018C8C1BF4
			public void Reset(); // 0x000000018C8C1BF4-0x000000018C8C1C40
		}
	
		[CompilerGenerated]
		private struct _WriteToAndResetAsync_d__19 : IAsyncStateMachine // TypeDefIndex: 87200
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
			private void MoveNext(); // 0x000000018C8CC670-0x000000018C8CCF30
			[DebuggerHidden]
			private void SetStateMachine([Nullable(0)] IAsyncStateMachine stateMachine); // 0x000000018C8CB548-0x000000018C8CB554
		}
	
		// Constructors
		public ReusableLinkedArrayBufferWriter(bool useFirstBuffer, bool pinned); // 0x000000018C8C909C-0x000000018C8C91A0
		static ReusableLinkedArrayBufferWriter(); // 0x000000018C8C9038-0x000000018C8C909C
	
		// Methods
		public byte[] DangerousGetFirstBuffer(); // 0x0000000182234E30-0x0000000182234E40
		[NullableContext(0)]
		public Memory<byte> GetMemory(int sizeHint = 0 /* Metadata: 0x02646317 */); // 0x000000018C8C853C-0x000000018C8C8588
		[NullableContext(0)]
		public Span<byte> GetSpan(int sizeHint = 0 /* Metadata: 0x02646318 */); // 0x000000018C8C8588-0x000000018C8C86D0
		public void Advance(int count); // 0x000000018C8C84F0-0x000000018C8C8510
		public byte[] ToArrayAndReset(); // 0x000000018C8C8880-0x000000018C8C8BF4
		public void WriteToAndReset(ref MemoryPackWriter writer); // 0x000000018C8C8CDC-0x000000018C8C9038
		public async ValueTask WriteToAndResetAsync(Stream stream, CancellationToken cancellationToken); // 0x000000018C8C8BF4-0x000000018C8C8CDC
		public Enumerator GetEnumerator(); // 0x000000018C8C8510-0x000000018C8C853C
		private void ResetCore(); // 0x000000018C8C86D0-0x000000018C8C872C
		public void Reset(); // 0x000000018C8C872C-0x000000018C8C8880
	}

	internal struct BufferSegment // TypeDefIndex: 87202
	{
		// Fields
		[Nullable(1)]
		private byte[] buffer; // 0x00
		private int written; // 0x08
	
		// Properties
		public bool IsNull { get; } // 0x00000001850BC1F0-0x00000001850BC200 
		public int WrittenCount { get; } // 0x0000000184431A70-0x0000000184431A80 
		public Span<byte> WrittenBuffer { get; } // 0x000000018C8C1940-0x000000018C8C19A4 
		public Memory<byte> WrittenMemory { get; } // 0x000000018C8C19A4-0x000000018C8C1A08 
		public Span<byte> FreeBuffer { get; } // 0x000000018C8C18EC-0x000000018C8C1940 
	
		// Constructors
		public BufferSegment(int size); // 0x000000018C8C1868-0x000000018C8C18EC
	
		// Methods
		public void Advance(int count); // 0x0000000187251640-0x0000000187251650
		public void Clear(); // 0x000000018C8C17E4-0x000000018C8C1868
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class ReusableReadOnlySequenceBuilderPool // TypeDefIndex: 87203
	{
		// Fields
		private static readonly ConcurrentQueue<ReusableReadOnlySequenceBuilder> queue; // 0x00
	
		// Constructors
		static ReusableReadOnlySequenceBuilderPool(); // 0x000000018C8C931C-0x000000018C8C93A8
	
		// Methods
		public static ReusableReadOnlySequenceBuilder Rent(); // 0x000000018C8C91F0-0x000000018C8C92A0
		public static void Return(ReusableReadOnlySequenceBuilder builder); // 0x000000018C8C92A0-0x000000018C8C931C
	}

	internal sealed class ReusableReadOnlySequenceBuilder // TypeDefIndex: 87205
	{
		// Fields
		[Nullable(1)]
		private readonly Stack<Segment> segmentPool; // 0x10
		[Nullable(1)]
		private readonly List<Segment> list; // 0x18
	
		// Nested types
		private class Segment : ReadOnlySequenceSegment<byte> // TypeDefIndex: 87204
		{
			// Fields
			private bool returnToPool; // 0x30
	
			// Constructors
			public Segment(); // 0x000000018C8C9BC4-0x000000018C8C9BFC
	
			// Methods
			public void SetBuffer(ReadOnlyMemory<byte> buffer, bool returnToPool); // 0x000000018C8C9B08-0x000000018C8C9B64
			public void Reset(); // 0x000000018C8C99C4-0x000000018C8C9B08
			[NullableContext(2)]
			public void SetRunningIndexAndNext(long runningIndex, Segment nextSegment); // 0x000000018C8C9B64-0x000000018C8C9BC4
		}
	
		// Constructors
		public ReusableReadOnlySequenceBuilder(); // 0x000000018C8C9904-0x000000018C8C99C4
	
		// Methods
		public void Add(ReadOnlyMemory<byte> buffer, bool returnToPool); // 0x000000018C8C93A8-0x000000018C8C94A8
		public bool TryGetSingleMemory(out ReadOnlyMemory<byte> memory); // 0x000000018C8C9868-0x000000018C8C9904
		public ReadOnlySequence<byte> Build(); // 0x000000018C8C94A8-0x000000018C8C96DC
		public void Reset(); // 0x000000018C8C96DC-0x000000018C8C9868
	}

	internal static class TypeHelpers // TypeDefIndex: 87208
	{
		// Fields
		[Nullable(1)]
		private static readonly MethodInfo isReferenceOrContainsReferences; // 0x00
		[Nullable(1)]
		private static readonly MethodInfo unsafeSizeOf; // 0x08
	
		// Nested types
		private static class Cache<T> // TypeDefIndex: 87206
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
	
		internal enum TypeKind : byte // TypeDefIndex: 87207
		{
			None = 0,
			UnmanagedSZArray = 1,
			FixedSizeMemoryPackable = 2
		}
	
		// Constructors
		static TypeHelpers(); // 0x000000018C8CA714-0x000000018C8CA828
	
		// Methods
		[NullableContext(2)]
		public static bool IsReferenceOrNullable<T>();
		[NullableContext(2)]
		public static TypeKind TryGetUnmanagedSZArrayElementSizeOrMemoryPackableFixedSize<T>(out int size);
		[NullableContext(1)]
		public static bool IsAnonymous(System.Type type); // 0x000000018C8CA5BC-0x000000018C8CA714
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 87142
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 87143
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Embedded]
	internal sealed class NullableAttribute : Attribute // TypeDefIndex: 87144
	{
		// Fields
		public readonly byte[] NullableFlags; // 0x10
	
		// Constructors
		public NullableAttribute(byte param_000b8e87); // 0x00000001871C6990-0x00000001871C6A00
		public NullableAttribute(byte[] param_000b8e88); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Embedded]
	internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 87145
	{
		// Fields
		public readonly byte Flag; // 0x10
	
		// Constructors
		public NullableContextAttribute(byte param_000b8e89); // 0x0000000182A819C0-0x0000000182A819D0
	}

	internal sealed class IsExternalInit // TypeDefIndex: 87147
	{
		// Constructors
		public IsExternalInit(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
