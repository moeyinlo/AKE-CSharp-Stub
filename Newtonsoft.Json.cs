/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

// Image 23: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 51594-51902
[assembly: AssemblyCompany("Newtonsoft")]
[assembly: AssemblyConfiguration("UnityAOT")]
[assembly: AssemblyCopyright("Copyright \u00A9 James Newton-King 2008")]
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyDescription("Json.NET is a popular high-performance JSON framework for .NET")]
[assembly: AssemblyFileVersion("13.0.2")]
[assembly: AssemblyInformationalVersion("13.0.2+cf0a246981c33ae00121dfe58b850aefeac1aac0")]
[assembly: AssemblyKeyFile("../IdentityPublicKey.snk")]
[assembly: AssemblyMetadata("RepositoryUrl", "https://github.com/sousapedro/Newtonsoft.Json-for-Unity.git")]
[assembly: AssemblyProduct("Json.NET")]
[assembly: AssemblyTitle("Json.NET .NET Standard 2.0")]
[assembly: AssemblyTrademark("")]
[assembly: CLSCompliant(true)]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Guid("9ca358aa-317b-4925-8ada-4a29e943a363")]
[assembly: InternalsVisibleTo("Newtonsoft.Json.Schema, PublicKey=0024000004800000940000000602000000240000525341310004000001000100f561df277c6c0b497d629032b410cdcf286e537c054724f7ffa0164345f62b3e642029d7a80cc351918955328c4adc8a048823ef90b0cf38ea7db0d729caf2b633c3babe08b0310198c1081995c19029bc675193744eab9d7345b8a67258ec17d112cebdbbb2a281487dceeafb9d83aa930f32103fbe1d2911425bc5744002c7")]
[assembly: InternalsVisibleTo("Newtonsoft.Json.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100f561df277c6c0b497d629032b410cdcf286e537c054724f7ffa0164345f62b3e642029d7a80cc351918955328c4adc8a048823ef90b0cf38ea7db0d729caf2b633c3babe08b0310198c1081995c19029bc675193744eab9d7345b8a67258ec17d112cebdbbb2a281487dceeafb9d83aa930f32103fbe1d2911425bc5744002c7")]
[assembly: InternalsVisibleTo("Newtonsoft.Json.Dynamic, PublicKey=0024000004800000940000000602000000240000525341310004000001000100cbd8d53b9d7de30f1f1278f636ec462cf9c254991291e66ebb157a885638a517887633b898ccbcf0d5c5ff7be85a6abe9e765d0ac7cd33c68dac67e7e64530e8222101109f154ab14a941c490ac155cd1d4fcba0fabb49016b4ef28593b015cab5937da31172f03f67d09edda404b88a60023f062ae71d0b2e4438b74cc11dc9")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: TargetFramework(".NETStandard,Version=v2.0", FrameworkDisplayName = "")]

namespace Newtonsoft.Json
{
	public enum ConstructorHandling // TypeDefIndex: 51601
	{
		Default = 0,
		AllowNonPublicDefaultConstructor = 1
	}

	public enum DateFormatHandling // TypeDefIndex: 51602
	{
		IsoDateFormat = 0,
		MicrosoftDateFormat = 1
	}

	public enum DateParseHandling // TypeDefIndex: 51603
	{
		None = 0,
		DateTime = 1,
		DateTimeOffset = 2
	}

	public enum DateTimeZoneHandling // TypeDefIndex: 51604
	{
		Local = 0,
		Utc = 1,
		Unspecified = 2,
		RoundtripKind = 3
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class DefaultJsonNameTable : JsonNameTable // TypeDefIndex: 51606
	{
		// Fields
		private static readonly int HashCodeRandomizer; // 0x00
		private int _count; // 0x10
		private Entry[] _entries; // 0x18
		private int _mask; // 0x20
	
		// Nested types
		[Nullable(0)]
		private class Entry // TypeDefIndex: 51605
		{
			// Fields
			internal readonly string Value; // 0x10
			internal readonly int HashCode; // 0x18
			internal Entry Next; // 0x20
	
			// Constructors
			public Entry() {} // Dummy constructor
			internal Entry(string value, int hashCode, Entry next) {} // 0x0000000183020510-0x0000000183020540
		}
	
		// Constructors
		static DefaultJsonNameTable() {} // 0x0000000183D41660-0x0000000183D416A0
		public DefaultJsonNameTable() {} // 0x0000000183702F40-0x0000000183702FA0
	
		// Methods
		public override string Get(char[] key, int start, int length) => default; // 0x000000018236C9E0-0x000000018236CBD0
		public string Add(string key) => default; // 0x00000001824E67F0-0x00000001824E6960
		private string AddEntry(string str, int hashCode) => default; // 0x0000000183020400-0x0000000183020510
		private void Grow() {} // 0x0000000183020540-0x0000000183020690
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) => default; // 0x000000018236C960-0x000000018236C9E0
	}

	[Flags]
	public enum DefaultValueHandling // TypeDefIndex: 51607
	{
		Include = 0,
		Ignore = 1,
		Populate = 2,
		IgnoreAndPopulate = 3
	}

	public enum FloatFormatHandling // TypeDefIndex: 51608
	{
		String = 0,
		Symbol = 1,
		DefaultValue = 2
	}

	public enum FloatParseHandling // TypeDefIndex: 51609
	{
		Double = 0,
		Decimal = 1
	}

	public enum Formatting // TypeDefIndex: 51610
	{
		None = 0,
		Indented = 1
	}

	[NullableContext(1)]
	public interface IArrayPool<T> // TypeDefIndex: 51611
	{
		// Methods
		T[] Rent(int minimumLength);
		void Return([Nullable(new byte[2] {2, 1 })] T[] array);
	}

	public interface IJsonLineInfo // TypeDefIndex: 51612
	{
		// Properties
		int LineNumber { get; }
		int LinePosition { get; }
	
		// Methods
		bool HasLineInfo();
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonArrayAttribute : JsonContainerAttribute // TypeDefIndex: 51613
	{
		// Constructors
		public JsonArrayAttribute() {} // Dummy constructor
	}

	[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false)]
	public sealed class JsonConstructorAttribute : Attribute // TypeDefIndex: 51614
	{
		// Constructors
		public JsonConstructorAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	[Nullable(0)]
	[NullableContext(2)]
	public abstract class JsonContainerAttribute : Attribute // TypeDefIndex: 51615
	{
		// Fields
		internal bool? _isReference; // 0x28
		internal bool? _itemIsReference; // 0x2A
		internal ReferenceLoopHandling? _itemReferenceLoopHandling; // 0x2C
		internal TypeNameHandling? _itemTypeNameHandling; // 0x34
		private System.Type _namingStrategyType; // 0x40
		[Nullable(new byte[2] {2, 1 })]
		private object[] _namingStrategyParameters; // 0x48
	
		// Properties
		public System.Type ItemConverterType { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		[Nullable(new byte[2] {2, 1 })]
		public object[] ItemConverterParameters { get; } // 0x0000000181041090-0x00000001810410A0 
		public System.Type NamingStrategyType { get; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		[Nullable(new byte[2] {2, 1 })]
		public object[] NamingStrategyParameters { get; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		internal NamingStrategy NamingStrategyInstance { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Constructors
		protected JsonContainerAttribute() {} // Dummy constructor
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class JsonConvert // TypeDefIndex: 51616
	{
		// Fields
		public static readonly string True; // 0x08
		public static readonly string False; // 0x10
		public static readonly string Null; // 0x18
		public static readonly string Undefined; // 0x20
		public static readonly string PositiveInfinity; // 0x28
		public static readonly string NegativeInfinity; // 0x30
		public static readonly string NaN; // 0x38
	
		// Properties
		[Nullable(new byte[2] {2, 1 })]
		public static Func<JsonSerializerSettings> DefaultSettings { get; } // 0x00000001892B06F8-0x00000001892B0748 
	
		// Constructors
		static JsonConvert() {} // 0x0000000183A2D920-0x0000000183A2DAF0
	
		// Methods
		public static string ToString(bool value) => default; // 0x0000000182905B90-0x0000000182905C20
		public static string ToString(char value) => default; // 0x00000001892B0350-0x00000001892B03B8
		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) => default; // 0x00000001892B0538-0x00000001892B061C
		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) => default; // 0x00000001892AFEFC-0x00000001892AFFF0
		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) => default; // 0x00000001892B061C-0x00000001892B06F8
		private static string EnsureDecimalPlace(double value, string text) => default; // 0x00000001892AFDF8-0x00000001892AFEA0
		private static string EnsureDecimalPlace(string text) => default; // 0x00000001892AFEA0-0x00000001892AFEFC
		public static string ToString(decimal value) => default; // 0x00000001892B02B8-0x00000001892B0350
		public static string ToString([Nullable(2)] string value) => default; // 0x00000001892B04E8-0x00000001892B0538
		public static string ToString([Nullable(2)] string value, char delimiter) => default; // 0x00000001892B0494-0x00000001892B04E8
		public static string ToString([Nullable(2)] string value, char delimiter, StringEscapeHandling stringEscapeHandling) => default; // 0x00000001892B03B8-0x00000001892B0494
		[DebuggerStepThrough]
		public static string SerializeObject([Nullable(2)] object value) => default; // 0x0000000182696450-0x00000001826964B0
		[DebuggerStepThrough]
		public static string SerializeObject([Nullable(2)] object value, Newtonsoft.Json.Formatting formatting) => default; // 0x00000001892B0210-0x00000001892B0264
		[DebuggerStepThrough]
		[NullableContext(2)]
		public static string SerializeObject(object value, JsonSerializerSettings settings) => default; // 0x00000001892B0264-0x00000001892B02B8
		[DebuggerStepThrough]
		[NullableContext(2)]
		public static string SerializeObject(object value, System.Type type, JsonSerializerSettings settings) => default; // 0x00000001826963D0-0x0000000182696450
		[DebuggerStepThrough]
		[NullableContext(2)]
		public static string SerializeObject(object value, Newtonsoft.Json.Formatting formatting, JsonSerializerSettings settings) => default; // 0x00000001835A1D80-0x00000001835A1E00
		[DebuggerStepThrough]
		[NullableContext(2)]
		public static string SerializeObject(object value, System.Type type, Newtonsoft.Json.Formatting formatting, JsonSerializerSettings settings) => default; // 0x00000001835A1E00-0x00000001835A1EA0
		private static string SerializeObjectInternal([Nullable(2)] object value, [Nullable(2)] System.Type type, JsonSerializer jsonSerializer) => default; // 0x0000000182696B20-0x0000000182696DC0
		[DebuggerStepThrough]
		public static object DeserializeObject(string value) => default; // 0x0000000183C8F4B0-0x0000000183C8F500
		[DebuggerStepThrough]
		public static object DeserializeObject(string value, System.Type type) => default; // 0x0000000182694430-0x0000000182694490
		[DebuggerStepThrough]
		[NullableContext(2)]
		public static T DeserializeObject<T>([Nullable(1)] string value) => default;
		[DebuggerStepThrough]
		[NullableContext(2)]
		public static T DeserializeObject<T>([Nullable(1)] string value, JsonSerializerSettings settings) => default;
		[NullableContext(2)]
		public static object DeserializeObject([Nullable(1)] string value, System.Type type, JsonSerializerSettings settings) => default; // 0x0000000182695B30-0x0000000182695E10
		public static void PopulateObject(string value, object target, [Nullable(2)] JsonSerializerSettings settings) {} // 0x00000001892AFFF0-0x00000001892B0210
	}

	[Nullable(0)]
	[NullableContext(1)]
	public abstract class JsonConverter // TypeDefIndex: 51617
	{
		// Properties
		public virtual bool CanRead { get; } // 0x000000018232EB60-0x000000018232EB70 
		public virtual bool CanWrite { get; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		protected JsonConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer);
		public abstract object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer);
		public abstract bool CanConvert(System.Type objectType);
	}

	[Nullable(0)]
	[NullableContext(1)]
	public abstract class JsonConverter<T> : JsonConverter // TypeDefIndex: 51618
	{
		// Constructors
		protected JsonConverter() {}
	
		// Methods
		public sealed override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {}
		public abstract void WriteJson(JsonWriter writer, [Nullable(2)] T value, JsonSerializer serializer);
		public sealed override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default;
		public abstract T ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] T existingValue, bool hasExistingValue, JsonSerializer serializer);
		public sealed override bool CanConvert(System.Type objectType) => default;
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter, AllowMultiple = false)]
	[Nullable(0)]
	[NullableContext(1)]
	public sealed class JsonConverterAttribute : Attribute // TypeDefIndex: 51619
	{
		// Fields
		private readonly System.Type _converterType; // 0x10
	
		// Properties
		public System.Type ConverterType { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		[Nullable(new byte[2] {2, 1 })]
		public object[] ConverterParameters { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public JsonConverterAttribute() {} // Dummy constructor
	}

	[Nullable(new byte[2] {0, 1 })]
	public class JsonConverterCollection : Collection<JsonConverter> // TypeDefIndex: 51620
	{
		// Constructors
		public JsonConverterCollection() {} // 0x0000000183043740-0x0000000183043780
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonDictionaryAttribute : JsonContainerAttribute // TypeDefIndex: 51621
	{
		// Constructors
		public JsonDictionaryAttribute() {} // Dummy constructor
	}

	[Serializable]
	[Nullable(0)]
	[NullableContext(1)]
	public class JsonException : Exception // TypeDefIndex: 51622
	{
		// Constructors
		public JsonException() {} // 0x00000001892B0748-0x00000001892B0794
		public JsonException(string message) {} // 0x00000001892B0794-0x00000001892B07F0
		public JsonException(string message, [Nullable(2)] Exception innerException) {} // 0x00000001892B07F0-0x00000001892B0850
		public JsonException(SerializationInfo info, StreamingContext context) {} // 0x00000001892B0850-0x00000001892B08BC
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public class JsonExtensionDataAttribute : Attribute // TypeDefIndex: 51623
	{
		// Properties
		public bool WriteData { get; } // 0x00000001811797F0-0x0000000181179800 
		public bool ReadData { get; } // 0x0000000183D510E0-0x0000000183D510F0 
	
		// Constructors
		public JsonExtensionDataAttribute() {} // Dummy constructor
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class JsonIgnoreAttribute : Attribute // TypeDefIndex: 51624
	{
		// Constructors
		public JsonIgnoreAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class JsonNameTable // TypeDefIndex: 51625
	{
		// Constructors
		protected JsonNameTable() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[NullableContext(1)]
		public abstract string Get(char[] key, int start, int length);
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonObjectAttribute : JsonContainerAttribute // TypeDefIndex: 51626
	{
		// Fields
		private MemberSerialization _memberSerialization; // 0x50
		internal MissingMemberHandling? _missingMemberHandling; // 0x54
		internal Required? _itemRequired; // 0x5C
		internal NullValueHandling? _itemNullValueHandling; // 0x64
	
		// Properties
		public MemberSerialization MemberSerialization { get => default; } // 0x0000000183D4EED0-0x0000000183D4EEE0 
	
		// Constructors
		public JsonObjectAttribute() {} // Dummy constructor
	}

	internal enum JsonContainerType // TypeDefIndex: 51627
	{
		None = 0,
		Object = 1,
		Array = 2,
		Constructor = 3
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal struct JsonPosition // TypeDefIndex: 51628
	{
		// Fields
		private static readonly char[] SpecialCharacters; // 0x00
		internal JsonContainerType Type; // 0x00
		internal int Position; // 0x04
		[Nullable(2)]
		internal string PropertyName; // 0x08
		internal bool HasIndex; // 0x10
	
		// Constructors
		public JsonPosition(JsonContainerType type) {
			Type = default;
			Position = default;
			PropertyName = default;
			HasIndex = default;
		} // 0x0000000182907480-0x0000000182907530
		static JsonPosition() {
			SpecialCharacters = default;
		} // 0x0000000183CE3DC0-0x0000000183CE3E50
	
		// Methods
		internal int CalculateLength() => default; // 0x00000001892B0BF0-0x00000001892B0C80
		[NullableContext(2)]
		internal void WriteTo([Nullable(1)] StringBuilder sb, ref StringWriter writer, ref char[] buffer) {} // 0x00000001892B0E5C-0x00000001892B1048
		internal static bool TypeHasIndex(JsonContainerType type) => default; // 0x0000000182907530-0x0000000182907540
		internal static string BuildPath(List<JsonPosition> positions, JsonPosition? currentPosition) => default; // 0x00000001892B08BC-0x00000001892B0BF0
		internal static string FormatMessage([Nullable(2)] IJsonLineInfo lineInfo, string path, string message) => default; // 0x00000001892B0C80-0x00000001892B0E5C
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
	[Nullable(0)]
	[NullableContext(2)]
	public sealed class JsonPropertyAttribute : Attribute // TypeDefIndex: 51629
	{
		// Fields
		internal NullValueHandling? _nullValueHandling; // 0x10
		internal DefaultValueHandling? _defaultValueHandling; // 0x18
		internal ReferenceLoopHandling? _referenceLoopHandling; // 0x20
		internal ObjectCreationHandling? _objectCreationHandling; // 0x28
		internal TypeNameHandling? _typeNameHandling; // 0x30
		internal bool? _isReference; // 0x38
		internal int? _order; // 0x3C
		internal Required? _required; // 0x44
		internal bool? _itemIsReference; // 0x4C
		internal ReferenceLoopHandling? _itemReferenceLoopHandling; // 0x50
		internal TypeNameHandling? _itemTypeNameHandling; // 0x58
	
		// Properties
		public System.Type ItemConverterType { get; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		[Nullable(new byte[2] {2, 1 })]
		public object[] ItemConverterParameters { get; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
		public System.Type NamingStrategyType { get; } // 0x0000000183D4EB30-0x0000000183D4EB40 
		[Nullable(new byte[2] {2, 1 })]
		public object[] NamingStrategyParameters { get; } // 0x0000000183D4EB20-0x0000000183D4EB30 
		public DefaultValueHandling DefaultValueHandling { set {} } // 0x000000018381E590-0x000000018381E5F0
		public int Order { set {} } // 0x00000001833DA250-0x00000001833DA2B0
		public string PropertyName { get; set; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x00000001851DFC94-0x00000001851DFCA4
	
		// Constructors
		public JsonPropertyAttribute() {} // 0x000000018350B670-0x000000018350B680
		[NullableContext(1)]
		public JsonPropertyAttribute(string propertyName) {} // 0x00000001851DFC94-0x00000001851DFCA4
	}

	[Nullable(0)]
	[NullableContext(2)]
	public abstract class JsonReader : IDisposable // TypeDefIndex: 51631
	{
		// Fields
		private JsonToken _tokenType; // 0x10
		private object _value; // 0x18
		internal char _quoteChar; // 0x20
		internal State _currentState; // 0x24
		private JsonPosition _currentPosition; // 0x28
		private CultureInfo _culture; // 0x40
		private DateTimeZoneHandling _dateTimeZoneHandling; // 0x48
		private int? _maxDepth; // 0x4C
		private bool _hasExceededMaxDepth; // 0x54
		internal DateParseHandling _dateParseHandling; // 0x58
		internal FloatParseHandling _floatParseHandling; // 0x5C
		private string _dateFormatString; // 0x60
		private List<JsonPosition> _stack; // 0x68
	
		// Properties
		protected State CurrentState { get; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public bool CloseInput { get; set; } // 0x0000000183D4F260-0x0000000183D4F270 0x0000000183D4F290-0x0000000183D4F2A0
		public bool SupportMultipleContent { get; set; } // 0x0000000183D51CF0-0x0000000183D51D00 0x0000000183D51D00-0x0000000183D51D10
		public DateTimeZoneHandling DateTimeZoneHandling { get; set; } // 0x0000000183D4EC50-0x0000000183D4EC60 0x00000001892B35E4-0x00000001892B364C
		public DateParseHandling DateParseHandling { get; set; } // 0x0000000183D4EF00-0x0000000183D4EF10 0x00000001892B357C-0x00000001892B35E4
		public FloatParseHandling FloatParseHandling { get; set; } // 0x0000000183D4EEF0-0x0000000183D4EF00 0x00000001892B364C-0x00000001892B36B4
		public string DateFormatString { get; set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		public int? MaxDepth { get; set; } // 0x0000000183D56700-0x0000000183D56710 0x00000001827BC040-0x00000001827BC0B0
		public virtual JsonToken TokenType { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public virtual object Value { get; } // 0x0000000181041090-0x00000001810410A0 
		public virtual System.Type ValueType { get; } // 0x00000001892B3558-0x00000001892B357C 
		public virtual int Depth { get; } // 0x000000018269A890-0x000000018269A900 
		[Nullable(1)]
		public virtual string Path { [NullableContext(1)] get; } // 0x00000001892B3464-0x00000001892B3558 
		[Nullable(1)]
		public CultureInfo Culture { [NullableContext(1)] get; [NullableContext(1)] set; } // 0x00000001827BC3A0-0x00000001827BC400 0x0000000183CB2D80-0x0000000183CB2D90
	
		// Nested types
		[NullableContext(0)]
		protected internal enum State // TypeDefIndex: 51630
		{
			Start = 0,
			Complete = 1,
			Property = 2,
			ObjectStart = 3,
			Object = 4,
			ArrayStart = 5,
			Array = 6,
			Closed = 7,
			PostValue = 8,
			ConstructorStart = 9,
			Constructor = 10,
			Error = 11,
			Finished = 12
		}
	
		// Constructors
		protected JsonReader() {} // 0x0000000182696330-0x0000000182696390
	
		// Methods
		internal JsonPosition GetPosition(int depth) => default; // 0x00000001892B129C-0x00000001892B1340
		private void Push(JsonContainerType value) {} // 0x0000000182906EF0-0x0000000182907480
		private JsonContainerType Pop() => default; // 0x000000018247C880-0x000000018247CB10
		private JsonContainerType Peek() => default; // 0x0000000183D4EB90-0x0000000183D4EBA0
		public abstract bool Read();
		public virtual int? ReadAsInt32() => default; // 0x00000001892B23F0-0x00000001892B277C
		internal int? ReadInt32String(string s) => default; // 0x00000001892B30CC-0x00000001892B3238
		public virtual string ReadAsString() => default; // 0x0000000183B23610-0x0000000183B236C0
		public virtual byte[] ReadAsBytes() => default; // 0x00000001892B15C8-0x00000001892B1914
		[NullableContext(1)]
		internal byte[] ReadArrayIntoByteArray() => default; // 0x00000001892B14F4-0x00000001892B15C8
		[NullableContext(1)]
		private bool ReadArrayElementIntoByteArrayReportDone(List<byte> buffer) => default; // 0x00000001892B1340-0x00000001892B14F4
		public virtual double? ReadAsDouble() => default; // 0x00000001892B214C-0x00000001892B23F0
		internal double? ReadDoubleString(string s) => default; // 0x00000001892B2EEC-0x00000001892B3078
		public virtual bool? ReadAsBoolean() => default; // 0x0000000183B23540-0x0000000183B23610
		internal bool? ReadBooleanString(string s) => default; // 0x00000001892B277C-0x00000001892B28E4
		public virtual decimal? ReadAsDecimal() => default; // 0x00000001892B1D74-0x00000001892B214C
		internal decimal? ReadDecimalString(string s) => default; // 0x00000001892B2CDC-0x00000001892B2EEC
		public virtual System.DateTime? ReadAsDateTime() => default; // 0x00000001892B1B4C-0x00000001892B1D74
		internal System.DateTime? ReadDateTimeString(string s) => default; // 0x00000001892B2AEC-0x00000001892B2CDC
		public virtual DateTimeOffset? ReadAsDateTimeOffset() => default; // 0x00000001892B1914-0x00000001892B1B4C
		internal DateTimeOffset? ReadDateTimeOffsetString(string s) => default; // 0x00000001892B28E4-0x00000001892B2AEC
		internal void ReaderReadAndAssert() {} // 0x00000001892B341C-0x00000001892B3464
		[NullableContext(1)]
		internal JsonReaderException CreateUnexpectedEndException() => default; // 0x00000001892B125C-0x00000001892B129C
		internal void ReadIntoWrappedTypeObject() {} // 0x00000001892B3238-0x00000001892B341C
		public void Skip() {} // 0x000000018269A0F0-0x000000018269A170
		protected void SetToken(JsonToken newToken) {} // 0x000000018426FA14-0x000000018426FA34
		protected void SetToken(JsonToken newToken, object value) {} // 0x00000001842702E0-0x00000001842702FC
		protected void SetToken(JsonToken newToken, object value, bool updateIndex) {} // 0x000000018247E340-0x000000018247E590
		internal void SetPostValueState(bool updateIndex) {} // 0x000000018247E590-0x000000018247E5D0
		private void UpdateScopeWithFinishedValue() {} // 0x000000018247E5D0-0x000000018247E5E0
		private void ValidateEnd(JsonToken endToken) {} // 0x000000018247C400-0x000000018247C840
		protected void SetStateBasedOnCurrent() {} // 0x000000018236AC80-0x000000018236ACD0
		private void SetFinished() {} // 0x00000001832FF660-0x00000001832FF680
		private JsonContainerType GetTypeForCloseToken(JsonToken token) => default; // 0x000000018247C840-0x000000018247C880
		void IDisposable.Dispose() {} // 0x000000018289C760-0x000000018289C800
		protected virtual void Dispose(bool disposing) {} // 0x000000018289C800-0x000000018289C830
		public virtual void Close() {} // 0x00000001830AB570-0x00000001830AB590
		internal void ReadAndAssert() {} // 0x00000001824E8B90-0x00000001824E8BC0
		internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter) {} // 0x00000001892B3078-0x00000001892B30CC
		internal bool ReadForType(JsonContract contract, bool hasConverter) => default; // 0x00000001824EC430-0x00000001824EC680
		internal bool ReadAndMoveToContent() => default; // 0x00000001824EC680-0x00000001824EC6D0
		internal bool MoveToContent() => default; // 0x00000001824EC6D0-0x00000001824EC700
		private JsonToken GetContentToken() => default; // 0x0000000183B236C0-0x0000000183B23700
	}

	[Serializable]
	[Nullable(0)]
	[NullableContext(1)]
	public class JsonReaderException : JsonException // TypeDefIndex: 51632
	{
		// Constructors
		public JsonReaderException() {} // 0x00000001892B11D4-0x00000001892B11DC
		public JsonReaderException(string message) {} // 0x00000001892B1254-0x00000001892B125C
		public JsonReaderException(SerializationInfo info, StreamingContext context) {} // 0x00000001892B1234-0x00000001892B1254
		public JsonReaderException(string message, string path, int lineNumber, int linePosition, [Nullable(2)] Exception innerException) {} // 0x00000001892B11DC-0x00000001892B1234
	
		// Methods
		internal static JsonReaderException Create(JsonReader reader, string message) => default; // 0x00000001892B11C8-0x00000001892B11D4
		internal static JsonReaderException Create(JsonReader reader, string message, [Nullable(2)] Exception ex) => default; // 0x00000001892B1138-0x00000001892B11C8
		internal static JsonReaderException Create([Nullable(2)] IJsonLineInfo lineInfo, string path, string message, [Nullable(2)] Exception ex) => default; // 0x00000001892B1048-0x00000001892B1138
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class JsonRequiredAttribute : Attribute // TypeDefIndex: 51633
	{
		// Constructors
		public JsonRequiredAttribute() {} // Dummy constructor
	}

	[Serializable]
	[Nullable(0)]
	[NullableContext(1)]
	public class JsonSerializationException : JsonException // TypeDefIndex: 51634
	{
		// Constructors
		public JsonSerializationException() {} // 0x00000001892B11D4-0x00000001892B11DC
		public JsonSerializationException(string message) {} // 0x00000001892B1254-0x00000001892B125C
		public JsonSerializationException(string message, Exception innerException) {} // 0x00000001892B3840-0x00000001892B3848
		public JsonSerializationException(SerializationInfo info, StreamingContext context) {} // 0x00000001892B1234-0x00000001892B1254
		public JsonSerializationException(string message, string path, int lineNumber, int linePosition, [Nullable(2)] Exception innerException) {} // 0x00000001892B11DC-0x00000001892B1234
	
		// Methods
		internal static JsonSerializationException Create(JsonReader reader, string message) => default; // 0x00000001892B36B4-0x00000001892B36C0
		internal static JsonSerializationException Create(JsonReader reader, string message, [Nullable(2)] Exception ex) => default; // 0x00000001892B36C0-0x00000001892B3750
		internal static JsonSerializationException Create([Nullable(2)] IJsonLineInfo lineInfo, string path, string message, [Nullable(2)] Exception ex) => default; // 0x00000001892B3750-0x00000001892B3840
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class JsonSerializer // TypeDefIndex: 51635
	{
		// Fields
		internal TypeNameHandling _typeNameHandling; // 0x10
		internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling; // 0x14
		internal PreserveReferencesHandling _preserveReferencesHandling; // 0x18
		internal ReferenceLoopHandling _referenceLoopHandling; // 0x1C
		internal MissingMemberHandling _missingMemberHandling; // 0x20
		internal ObjectCreationHandling _objectCreationHandling; // 0x24
		internal NullValueHandling _nullValueHandling; // 0x28
		internal DefaultValueHandling _defaultValueHandling; // 0x2C
		internal ConstructorHandling _constructorHandling; // 0x30
		internal MetadataPropertyHandling _metadataPropertyHandling; // 0x34
		[Nullable(2)]
		internal JsonConverterCollection _converters; // 0x38
		internal IContractResolver _contractResolver; // 0x40
		[Nullable(2)]
		internal ITraceWriter _traceWriter; // 0x48
		[Nullable(2)]
		internal IEqualityComparer _equalityComparer; // 0x50
		internal ISerializationBinder _serializationBinder; // 0x58
		internal StreamingContext _context; // 0x60
		[Nullable(2)]
		private IReferenceResolver _referenceResolver; // 0x70
		private Newtonsoft.Json.Formatting? _formatting; // 0x78
		private DateFormatHandling? _dateFormatHandling; // 0x80
		private DateTimeZoneHandling? _dateTimeZoneHandling; // 0x88
		private DateParseHandling? _dateParseHandling; // 0x90
		private FloatFormatHandling? _floatFormatHandling; // 0x98
		private FloatParseHandling? _floatParseHandling; // 0xA0
		private StringEscapeHandling? _stringEscapeHandling; // 0xA8
		private CultureInfo _culture; // 0xB0
		private int? _maxDepth; // 0xB8
		private bool _maxDepthSet; // 0xC0
		private bool? _checkAdditionalContent; // 0xC1
		[Nullable(2)]
		private string _dateFormatString; // 0xC8
		private bool _dateFormatStringSet; // 0xD0
	
		// Properties
		[Nullable(2)]
		public virtual IReferenceResolver ReferenceResolver { [NullableContext(2)] set {} } // 0x00000001892B4004-0x00000001892B4090
		public virtual ISerializationBinder SerializationBinder { set {} } // 0x00000001892B4090-0x00000001892B411C
		[Nullable(2)]
		public virtual ITraceWriter TraceWriter { [NullableContext(2)] get => default; [NullableContext(2)] set {} } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		[Nullable(2)]
		public virtual IEqualityComparer EqualityComparer { [NullableContext(2)] set {} } // 0x0000000182C926C0-0x0000000182C926D0
		public virtual TypeNameHandling TypeNameHandling { set {} } // 0x00000001833008C0-0x00000001833008E0
		public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { set {} } // 0x0000000183D4B8E0-0x0000000183D4B900
		public virtual PreserveReferencesHandling PreserveReferencesHandling { set {} } // 0x00000001892B3F9C-0x00000001892B4004
		public virtual ReferenceLoopHandling ReferenceLoopHandling { set {} } // 0x0000000183D4B900-0x0000000183D4B920
		public virtual MissingMemberHandling MissingMemberHandling { set {} } // 0x00000001892B3F34-0x00000001892B3F9C
		public virtual NullValueHandling NullValueHandling { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183300DA0-0x0000000183300DC0
		public virtual DefaultValueHandling DefaultValueHandling { set {} } // 0x0000000183300DC0-0x0000000183300DE0
		public virtual ObjectCreationHandling ObjectCreationHandling { set {} } // 0x0000000183B45E20-0x0000000183B45E40
		public virtual ConstructorHandling ConstructorHandling { set {} } // 0x0000000183B45E40-0x0000000183B45E60
		public virtual MetadataPropertyHandling MetadataPropertyHandling { get => default; set {} } // 0x0000000183D4EE00-0x0000000183D4EE10 0x00000001892B3ECC-0x00000001892B3F34
		public virtual JsonConverterCollection Converters { get => default; } // 0x00000001830436A0-0x0000000183043740 
		public virtual IContractResolver ContractResolver { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183B368B0-0x0000000183B36910
		public virtual StreamingContext Context { get => default; set {} } // 0x0000000183D5A130-0x0000000183D5A140 0x0000000185A9EA30-0x0000000185A9EA40
		public virtual Newtonsoft.Json.Formatting Formatting { get => default; set {} } // 0x0000000183CF50D0-0x0000000183CF5110 0x0000000183CF9A40-0x0000000183CF9AA0
		public virtual int? MaxDepth { get => default; } // 0x0000000183D4E750-0x0000000183D4E760 
		public virtual bool CheckAdditionalContent { get => default; set {} } // 0x0000000183366F90-0x0000000183366FD0 0x000000018323E420-0x000000018323E470
	
		// Events
		[Nullable(new byte[2] {2, 1 })]
		public virtual event EventHandler<ErrorEventArgs> Error;
	
		// Constructors
		public JsonSerializer() {} // 0x0000000182695FD0-0x0000000182696160
	
		// Methods
		internal bool IsCheckAdditionalContentSet() => default; // 0x0000000182696160-0x00000001826961A0
		public static JsonSerializer Create() => default; // 0x0000000182695F70-0x0000000182695FD0
		public static JsonSerializer Create([Nullable(2)] JsonSerializerSettings settings) => default; // 0x0000000182695EE0-0x0000000182695F70
		public static JsonSerializer CreateDefault() => default; // 0x0000000182695E50-0x0000000182695EE0
		public static JsonSerializer CreateDefault([Nullable(2)] JsonSerializerSettings settings) => default; // 0x0000000182695E10-0x0000000182695E50
		private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) {} // 0x00000001824B38D0-0x00000001824B3DF0
		[DebuggerStepThrough]
		public void Populate(JsonReader reader, object target) {} // 0x00000001892B3D60-0x00000001892B3DAC
		internal virtual void PopulateInternal(JsonReader reader, object target) {} // 0x00000001892B3ACC-0x00000001892B3D60
		[DebuggerStepThrough]
		[NullableContext(2)]
		public T Deserialize<T>([Nullable(1)] JsonReader reader) => default;
		[DebuggerStepThrough]
		[NullableContext(2)]
		public object Deserialize([Nullable(1)] JsonReader reader, System.Type objectType) => default; // 0x0000000184271114-0x0000000184271160
		[NullableContext(2)]
		internal virtual object DeserializeInternal([Nullable(1)] JsonReader reader, System.Type objectType) => default; // 0x00000001827BC5C0-0x00000001827BC7E0
		[NullableContext(2)]
		internal void SetupReader([Nullable(1)] JsonReader reader, out CultureInfo previousCulture, out DateTimeZoneHandling? previousDateTimeZoneHandling, out DateParseHandling? previousDateParseHandling, out FloatParseHandling? previousFloatParseHandling, out int? previousMaxDepth, out string previousDateFormatString) {
			previousCulture = default;
			previousDateTimeZoneHandling = default;
			previousDateParseHandling = default;
			previousFloatParseHandling = default;
			previousMaxDepth = default;
			previousDateFormatString = default;
		} // 0x00000001827BC0B0-0x00000001827BC3A0
		[NullableContext(2)]
		private void ResetReader([Nullable(1)] JsonReader reader, CultureInfo previousCulture, DateTimeZoneHandling? previousDateTimeZoneHandling, DateParseHandling? previousDateParseHandling, FloatParseHandling? previousFloatParseHandling, int? previousMaxDepth, string previousDateFormatString) {} // 0x00000001827BC400-0x00000001827BC5C0
		[NullableContext(2)]
		public void Serialize([Nullable(1)] JsonWriter jsonWriter, object value, System.Type objectType) {} // 0x0000000184271160-0x0000000184271174
		public void Serialize(JsonWriter jsonWriter, [Nullable(2)] object value) {} // 0x00000001842710E8-0x0000000184271108
		private TraceJsonReader CreateTraceJsonReader(JsonReader reader) => default; // 0x00000001892B39D0-0x00000001892B3A50
		[NullableContext(2)]
		internal virtual void SerializeInternal([Nullable(1)] JsonWriter jsonWriter, object value, System.Type objectType) {} // 0x00000001831637E0-0x0000000183163B30
		internal IReferenceResolver GetReferenceResolver() => default; // 0x00000001892B3A50-0x00000001892B3AAC
		internal JsonConverter GetMatchingConverter(System.Type type) => default; // 0x00000001842702D4-0x00000001842702E0
		internal static JsonConverter GetMatchingConverter([Nullable(new byte[2] {2, 1 })] IList<JsonConverter> converters, System.Type objectType) => default; // 0x0000000182415890-0x0000000182415CC0
		internal void OnError(ErrorEventArgs e) {} // 0x00000001892B3AAC-0x00000001892B3ACC
	}

	[Nullable(0)]
	[NullableContext(2)]
	public class JsonSerializerSettings // TypeDefIndex: 51636
	{
		// Fields
		internal const ReferenceLoopHandling DefaultReferenceLoopHandling = ReferenceLoopHandling.Error; // Metadata: 0x01FD112F
		internal const MissingMemberHandling DefaultMissingMemberHandling = MissingMemberHandling.Ignore; // Metadata: 0x01FD1130
		internal const NullValueHandling DefaultNullValueHandling = NullValueHandling.Include; // Metadata: 0x01FD1131
		internal const DefaultValueHandling DefaultDefaultValueHandling = DefaultValueHandling.Include; // Metadata: 0x01FD1132
		internal const ObjectCreationHandling DefaultObjectCreationHandling = ObjectCreationHandling.Auto; // Metadata: 0x01FD1133
		internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = PreserveReferencesHandling.None; // Metadata: 0x01FD1134
		internal const ConstructorHandling DefaultConstructorHandling = ConstructorHandling.Default; // Metadata: 0x01FD1135
		internal const TypeNameHandling DefaultTypeNameHandling = TypeNameHandling.None; // Metadata: 0x01FD1136
		internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = MetadataPropertyHandling.Default; // Metadata: 0x01FD1137
		internal static readonly StreamingContext DefaultContext; // 0x00
		internal const Newtonsoft.Json.Formatting DefaultFormatting = Newtonsoft.Json.Formatting.None; // Metadata: 0x01FD1138
		internal const DateFormatHandling DefaultDateFormatHandling = DateFormatHandling.IsoDateFormat; // Metadata: 0x01FD1139
		internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind; // Metadata: 0x01FD113A
		internal const DateParseHandling DefaultDateParseHandling = DateParseHandling.DateTime; // Metadata: 0x01FD113B
		internal const FloatParseHandling DefaultFloatParseHandling = FloatParseHandling.Double; // Metadata: 0x01FD113C
		internal const FloatFormatHandling DefaultFloatFormatHandling = FloatFormatHandling.String; // Metadata: 0x01FD113D
		internal const StringEscapeHandling DefaultStringEscapeHandling = StringEscapeHandling.Default; // Metadata: 0x01FD113E
		internal const TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple; // Metadata: 0x01FD113F
		[Nullable(1)]
		internal static readonly CultureInfo DefaultCulture; // 0x10
		internal const bool DefaultCheckAdditionalContent = false; // Metadata: 0x01FD1140
		[Nullable(1)]
		internal const string DefaultDateFormatString = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.FFFFFFFK"; // Metadata: 0x01FD1141
		internal const int DefaultMaxDepth = 64; // Metadata: 0x01FD1168
		internal Newtonsoft.Json.Formatting? _formatting; // 0x10
		internal DateFormatHandling? _dateFormatHandling; // 0x18
		internal DateTimeZoneHandling? _dateTimeZoneHandling; // 0x20
		internal DateParseHandling? _dateParseHandling; // 0x28
		internal FloatFormatHandling? _floatFormatHandling; // 0x30
		internal FloatParseHandling? _floatParseHandling; // 0x38
		internal StringEscapeHandling? _stringEscapeHandling; // 0x40
		internal CultureInfo _culture; // 0x48
		internal bool? _checkAdditionalContent; // 0x50
		internal int? _maxDepth; // 0x54
		internal bool _maxDepthSet; // 0x5C
		internal string _dateFormatString; // 0x60
		internal bool _dateFormatStringSet; // 0x68
		internal TypeNameAssemblyFormatHandling? _typeNameAssemblyFormatHandling; // 0x6C
		internal DefaultValueHandling? _defaultValueHandling; // 0x74
		internal PreserveReferencesHandling? _preserveReferencesHandling; // 0x7C
		internal NullValueHandling? _nullValueHandling; // 0x84
		internal ObjectCreationHandling? _objectCreationHandling; // 0x8C
		internal MissingMemberHandling? _missingMemberHandling; // 0x94
		internal ReferenceLoopHandling? _referenceLoopHandling; // 0x9C
		internal StreamingContext? _context; // 0xA8
		internal ConstructorHandling? _constructorHandling; // 0xC0
		internal TypeNameHandling? _typeNameHandling; // 0xC8
		internal MetadataPropertyHandling? _metadataPropertyHandling; // 0xD0
	
		// Properties
		public ReferenceLoopHandling ReferenceLoopHandling { get => default; set {} } // 0x0000000183D46F50-0x0000000183D46F90 0x0000000183D29B60-0x0000000183D29BC0
		public MissingMemberHandling MissingMemberHandling { get => default; } // 0x00000001892B3958-0x00000001892B3994 
		public ObjectCreationHandling ObjectCreationHandling { get => default; set {} } // 0x0000000183C90470-0x0000000183C904B0 0x0000000183D29BC0-0x0000000183D29C20
		public NullValueHandling NullValueHandling { get => default; set {} } // 0x00000001833696A0-0x00000001833696E0 0x0000000183CF9AA0-0x0000000183CF9B00
		public DefaultValueHandling DefaultValueHandling { get => default; set {} } // 0x00000001833696E0-0x0000000183369720 0x0000000183CF9B00-0x0000000183CF9B60
		[Nullable(1)]
		public IList<JsonConverter> Converters { [NullableContext(1)] get; [NullableContext(1)] set; } // 0x0000000183D4E7B0-0x0000000183D4E7C0 0x0000000185142FC4-0x0000000185142FD8
		public PreserveReferencesHandling PreserveReferencesHandling { get => default; } // 0x00000001892B3994-0x00000001892B39D0 
		public TypeNameHandling TypeNameHandling { get => default; set {} } // 0x0000000183367F30-0x0000000183367F70 0x0000000183C8FD90-0x0000000183C8FDF0
		public MetadataPropertyHandling MetadataPropertyHandling { get => default; } // 0x00000001892B391C-0x00000001892B3958 
		public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { get => default; set {} } // 0x0000000183D46F10-0x0000000183D46F50 0x0000000183D29B00-0x0000000183D29B60
		public ConstructorHandling ConstructorHandling { get => default; set {} } // 0x0000000183C904B0-0x0000000183C904F0 0x0000000183D29C80-0x0000000183D29CE0
		public IContractResolver ContractResolver { get; set; } // 0x0000000183D51140-0x0000000183D51150 0x000000018589D964-0x000000018589D978
		public IEqualityComparer EqualityComparer { get; set; } // 0x0000000183D50EA0-0x0000000183D50EB0 0x00000001856A2B64-0x00000001856A2B78
		public Func<IReferenceResolver> ReferenceResolverProvider { get; set; } // 0x0000000183D51950-0x0000000183D51960 0x00000001858B408C-0x00000001858B40A0
		public ITraceWriter TraceWriter { get; set; } // 0x0000000183D50160-0x0000000183D50170 0x000000018554D2E0-0x000000018554D2F4
		public ISerializationBinder SerializationBinder { get; set; } // 0x0000000183D50770-0x0000000183D50780 0x00000001855631FC-0x0000000185563210
		[Nullable(new byte[2] {2, 1 })]
		public EventHandler<ErrorEventArgs> Error { get; set; } // 0x0000000183D56D30-0x0000000183D56D40 0x000000018589D950-0x000000018589D964
		public StreamingContext Context { get => default; } // 0x00000001892B3880-0x00000001892B391C 
		public int? MaxDepth { set {} } // 0x0000000183C801B0-0x0000000183C80220
		public Newtonsoft.Json.Formatting Formatting { set {} } // 0x0000000183D29C20-0x0000000183D29C80
		public bool CheckAdditionalContent { get => default; } // 0x00000001892B3848-0x00000001892B3880 
	
		// Constructors
		static JsonSerializerSettings() {} // 0x0000000183CF1A70-0x0000000183CF1B00
		[DebuggerStepThrough]
		public JsonSerializerSettings() {} // 0x00000001835A2350-0x00000001835A23D0
		[NullableContext(1)]
		public JsonSerializerSettings(JsonSerializerSettings original) {} // 0x00000001835A23D0-0x00000001835A2600
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class JsonTextReader : JsonReader, IJsonLineInfo // TypeDefIndex: 51637
	{
		// Fields
		private readonly bool _safeAsync; // 0x78
		private readonly TextReader _reader; // 0x80
		[Nullable(2)]
		private char[] _chars; // 0x88
		private int _charsUsed; // 0x90
		private int _charPos; // 0x94
		private int _lineStartPos; // 0x98
		private int _lineNumber; // 0x9C
		private bool _isEndOfFile; // 0xA0
		private StringBuffer _stringBuffer; // 0xA8
		private StringReference _stringReference; // 0xB8
		[Nullable(2)]
		private IArrayPool<char> _arrayPool; // 0xC8
	
		// Properties
		[Nullable(2)]
		public JsonNameTable PropertyNameTable { [NullableContext(2)] get; [NullableContext(2)] set; } // 0x0000000183D50050-0x0000000183D50060 0x000000018554A7E0-0x000000018554A7F4
		public int LineNumber { get => default; } // 0x0000000182698E90-0x0000000182698F00 
		public int LinePosition { get => default; } // 0x0000000183D71450-0x0000000183D71460 
	
		// Constructors
		public JsonTextReader() {} // Dummy constructor
		public JsonTextReader(TextReader reader) {} // 0x0000000182696210-0x0000000182696330
	
		// Methods
		private void EnsureBufferNotEmpty() {} // 0x00000001829057F0-0x0000000182905860
		private void SetNewLine(bool hasNextChar) {} // 0x000000018236BEC0-0x000000018236BF20
		private void OnNewLine(int pos) {} // 0x0000000183D71420-0x0000000183D71430
		private void ParseString(char quote, ReadType readType) {} // 0x00000001823692D0-0x0000000182369400
		private void ParseReadString(char quote, ReadType readType) {} // 0x0000000182368A90-0x00000001823692D0
		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) {} // 0x0000000182462430-0x0000000182462450
		private void ShiftBufferIfNeeded() {} // 0x000000018236AAA0-0x000000018236AB90
		private int ReadData(bool append) => default; // 0x00000001842726CC-0x00000001842726D8
		private void PrepareBufferForReadData(bool append, int charsRequired) {} // 0x0000000182B46370-0x0000000182B46470
		private int ReadData(bool append, int charsRequired) => default; // 0x0000000182B461E0-0x0000000182B462E0
		private bool EnsureChars(int relativePosition, bool append) => default; // 0x000000018236BBA0-0x000000018236BD20
		private bool ReadChars(int relativePosition, bool append) => default; // 0x0000000182B46090-0x0000000182B461E0
		public override bool Read() => default; // 0x00000001822A7F70-0x00000001822A8130
		public override int? ReadAsInt32() => default; // 0x00000001829DEEF0-0x00000001829DEFE0
		public override System.DateTime? ReadAsDateTime() => default; // 0x00000001892B5A64-0x00000001892B5AE8
		[NullableContext(2)]
		public override string ReadAsString() => default; // 0x000000018247E2E0-0x000000018247E340
		[NullableContext(2)]
		public override byte[] ReadAsBytes() => default; // 0x00000001892B551C-0x00000001892B59D8
		[NullableContext(2)]
		private object ReadStringValue(ReadType readType) => default; // 0x000000018247D000-0x000000018247E2E0
		[NullableContext(2)]
		private object FinishReadQuotedStringValue(ReadType readType) => default; // 0x000000018247C2A0-0x000000018247C400
		private JsonReaderException CreateUnexpectedCharacterException(char c) => default; // 0x00000001892B4308-0x00000001892B43B4
		public override bool? ReadAsBoolean() => default; // 0x00000001824EC700-0x00000001824ED670
		private void ProcessValueComma() {} // 0x00000001892B54B4-0x00000001892B551C
		[NullableContext(2)]
		private object ReadNumberValue(ReadType readType) => default; // 0x00000001829DEFE0-0x00000001829DF620
		[NullableContext(2)]
		private object FinishReadQuotedNumber(ReadType readType) => default; // 0x00000001892B43F0-0x00000001892B4550
		public override DateTimeOffset? ReadAsDateTimeOffset() => default; // 0x00000001892B59D8-0x00000001892B5A64
		public override decimal? ReadAsDecimal() => default; // 0x00000001892B5AE8-0x00000001892B5B74
		public override double? ReadAsDouble() => default; // 0x00000001829DEE00-0x00000001829DEEF0
		private void HandleNull() {} // 0x00000001892B4550-0x00000001892B462C
		private void ReadFinished() {} // 0x00000001892B5B74-0x00000001892B5CC0
		private bool ReadNullChar() => default; // 0x00000001829DF620-0x00000001829DF660
		private void EnsureBuffer() {} // 0x00000001822A8130-0x00000001822A81E0
		private void ReadStringIntoBuffer(char quote) {} // 0x000000018236D260-0x000000018236DB00
		private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) {} // 0x000000018236B970-0x000000018236BBA0
		private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) {} // 0x00000001833B9C90-0x00000001833B9D00
		private char ConvertUnicode(bool enoughChars) => default; // 0x00000001892B418C-0x00000001892B4308
		private char ParseUnicode() => default; // 0x00000001892B5378-0x00000001892B53A4
		private void ReadNumberIntoBuffer() {} // 0x000000018236BFD0-0x000000018236C050
		private bool ReadNumberCharIntoBuffer(char currentChar, int charPos) => default; // 0x000000018236DD30-0x000000018236DEF0
		private void ClearRecentString() {} // 0x0000000183D71400-0x0000000183D71420
		private bool ParsePostValue(bool ignoreComments) => default; // 0x000000018236C050-0x000000018236C7B0
		private bool ParseObject() => default; // 0x000000018236CBD0-0x000000018236D260
		private bool ParseProperty() => default; // 0x000000018236DEF0-0x000000018236E7C0
		private bool ValidIdentifierChar(char value) => default; // 0x00000001892B5E70-0x00000001892B5EC8
		private void ParseUnquotedProperty() {} // 0x00000001892B53A4-0x00000001892B54B4
		private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition) => default; // 0x00000001892B5CC0-0x00000001892B5E1C
		private bool ParseValue() => default; // 0x0000000182369400-0x000000018236A1C0
		private void ProcessLineFeed() {} // 0x0000000183D71430-0x0000000183D71450
		private void ProcessCarriageReturn(bool append) {} // 0x000000018236BD20-0x000000018236BEC0
		private void EatWhitespace() {} // 0x000000018236B220-0x000000018236B620
		private void ParseConstructor() {} // 0x00000001892B4948-0x00000001892B4D20
		private void ParseNumber(ReadType readType) {} // 0x000000018236A8F0-0x000000018236AAA0
		private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition) {} // 0x000000018247E5E0-0x0000000182480720
		private JsonReaderException ThrowReaderError(string message, [Nullable(2)] Exception ex = null) => default; // 0x00000001892B5E1C-0x00000001892B5E70
		private static object BigIntegerParse(string number, CultureInfo culture) => default; // 0x00000001892B411C-0x00000001892B418C
		private void ParseComment(bool setToken) {} // 0x00000001892B462C-0x00000001892B4948
		private void EndComment(bool setToken, int initialPosition, int endPosition) {} // 0x00000001892B43B4-0x00000001892B43F0
		private bool MatchValue(string value) => default; // 0x00000001824EDAE0-0x00000001824EDCD0
		private bool MatchValue(bool enoughChars, string value) => default; // 0x00000001824EDCD0-0x00000001824EDD60
		private bool MatchValueWithTrailingSeparator(string value) => default; // 0x00000001824ED700-0x00000001824EDA70
		private bool IsSeparator(char c) => default; // 0x00000001824EDA70-0x00000001824EDAE0
		private void ParseTrue() {} // 0x0000000183A2C3D0-0x0000000183A2C4A0
		private void ParseNull() {} // 0x0000000183C85E30-0x0000000183C85EB0
		private void ParseUndefined() {} // 0x00000001892B52D8-0x00000001892B5378
		private void ParseFalse() {} // 0x00000001838C6C60-0x00000001838C6D30
		private object ParseNumberNegativeInfinity(ReadType readType) => default; // 0x00000001892B5080-0x00000001892B50F0
		private object ParseNumberNegativeInfinity(ReadType readType, bool matched) => default; // 0x00000001892B4F08-0x00000001892B5080
		private object ParseNumberPositiveInfinity(ReadType readType) => default; // 0x00000001892B5268-0x00000001892B52D8
		private object ParseNumberPositiveInfinity(ReadType readType, bool matched) => default; // 0x00000001892B50F0-0x00000001892B5268
		private object ParseNumberNaN(ReadType readType) => default; // 0x00000001892B4D20-0x00000001892B4D90
		private object ParseNumberNaN(ReadType readType, bool matched) => default; // 0x00000001892B4D90-0x00000001892B4F08
		public override void Close() {} // 0x00000001830AB480-0x00000001830AB570
		public bool HasLineInfo() => default; // 0x000000018232EB60-0x000000018232EB70
	}

	internal enum ReadType // TypeDefIndex: 51638
	{
		Read = 0,
		ReadAsInt32 = 1,
		ReadAsInt64 = 2,
		ReadAsBytes = 3,
		ReadAsString = 4,
		ReadAsDecimal = 5,
		ReadAsDateTime = 6,
		ReadAsDateTimeOffset = 7,
		ReadAsDouble = 8,
		ReadAsBoolean = 9
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class JsonTextWriter : JsonWriter // TypeDefIndex: 51639
	{
		// Fields
		private readonly bool _safeAsync; // 0x60
		private readonly TextWriter _writer; // 0x68
		[Nullable(2)]
		private Newtonsoft.Json.Utilities.Base64Encoder _base64Encoder; // 0x70
		private char _indentChar; // 0x78
		private int _indentation; // 0x7C
		private char _quoteChar; // 0x80
		private bool _quoteName; // 0x82
		[Nullable(2)]
		private bool[] _charEscapeFlags; // 0x88
		[Nullable(2)]
		private char[] _writeBuffer; // 0x90
		[Nullable(2)]
		private IArrayPool<char> _arrayPool; // 0x98
		[Nullable(2)]
		private char[] _indentChars; // 0xA0
	
		// Properties
		private Newtonsoft.Json.Utilities.Base64Encoder Base64Encoder { get => default; } // 0x00000001892B6F30-0x00000001892B6FB4 
		public char QuoteChar { get => default; } // 0x0000000183D71460-0x0000000183D71470 
	
		// Constructors
		public JsonTextWriter() {} // Dummy constructor
		public JsonTextWriter(TextWriter textWriter) {} // 0x0000000182697830-0x0000000182697940
	
		// Methods
		public override void Close() {} // 0x00000001830AB3E0-0x00000001830AB410
		private void CloseBufferAndWriter() {} // 0x00000001830AB410-0x00000001830AB480
		public override void WriteStartObject() {} // 0x0000000182905C80-0x0000000182905CC0
		public override void WriteStartArray() {} // 0x0000000182905510-0x0000000182905550
		public override void WriteStartConstructor(string name) {} // 0x00000001892B606C-0x00000001892B6104
		protected override void WriteEnd(JsonToken token) {} // 0x0000000182905CC0-0x0000000182905D20
		public override void WritePropertyName(string name) {} // 0x0000000182905C20-0x0000000182905C80
		public override void WritePropertyName(string name, bool escape) {} // 0x00000001829060B0-0x0000000182906190
		internal override void OnStringEscapeHandlingChanged() {} // 0x00000001892B5EC8-0x00000001892B5ED0
		private void UpdateCharEscapeFlags() {} // 0x0000000182697940-0x00000001826979C0
		protected override void WriteIndent() {} // 0x00000001825EE550-0x00000001825EE630
		private int SetIndentChars() => default; // 0x00000001825EE6F0-0x00000001825EE7E0
		protected override void WriteValueDelimiter() {} // 0x0000000182905D20-0x0000000182905D50
		protected override void WriteIndentSpace() {} // 0x0000000182905EC0-0x0000000182905EF0
		private void WriteValueInternal(string value, JsonToken token) {} // 0x0000000182907540-0x0000000182907570
		[NullableContext(2)]
		public override void WriteValue(object value) {} // 0x00000001892B64B0-0x00000001892B6578
		public override void WriteNull() {} // 0x00000001892B5FE0-0x00000001892B6048
		public override void WriteUndefined() {} // 0x00000001892B6104-0x00000001892B616C
		[NullableContext(2)]
		public override void WriteRaw(string json) {} // 0x00000001892B6048-0x00000001892B606C
		[NullableContext(2)]
		public override void WriteValue(string value) {} // 0x0000000182905A90-0x0000000182905B00
		private void WriteEscapedString(string value, bool quote) {} // 0x0000000182905D90-0x0000000182905E70
		public override void WriteValue(int value) {} // 0x00000001829054A0-0x0000000182905510
		[CLSCompliant(false)]
		public override void WriteValue(uint value) {} // 0x00000001892B6778-0x00000001892B67AC
		public override void WriteValue(long value) {} // 0x0000000182905A50-0x0000000182905A90
		[CLSCompliant(false)]
		public override void WriteValue(ulong value) {} // 0x00000001892B6D9C-0x00000001892B6DD4
		public override void WriteValue(float value) {} // 0x00000001892B6DD4-0x00000001892B6E6C
		public override void WriteValue(float? value) {} // 0x00000001892B6E6C-0x00000001892B6F30
		public override void WriteValue(double value) {} // 0x00000001892B6D04-0x00000001892B6D9C
		public override void WriteValue(double? value) {} // 0x00000001892B6578-0x00000001892B6640
		public override void WriteValue(bool value) {} // 0x0000000182905B00-0x0000000182905B90
		public override void WriteValue(short value) {} // 0x00000001892B6640-0x00000001892B6674
		[CLSCompliant(false)]
		public override void WriteValue(ushort value) {} // 0x00000001892B6744-0x00000001892B6778
		public override void WriteValue(char value) {} // 0x00000001892B6C94-0x00000001892B6D04
		public override void WriteValue(byte value) {} // 0x00000001892B6C60-0x00000001892B6C94
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value) {} // 0x00000001892B69F8-0x00000001892B6A2C
		public override void WriteValue(decimal value) {} // 0x00000001892B68E8-0x00000001892B6960
		public override void WriteValue(System.DateTime value) {} // 0x00000001892B6A2C-0x00000001892B6B84
		private int WriteValueToBuffer(System.DateTime value) => default; // 0x00000001892B62D0-0x00000001892B63F4
		[NullableContext(2)]
		public override void WriteValue(byte[] value) {} // 0x00000001892B63F4-0x00000001892B64B0
		public override void WriteValue(DateTimeOffset value) {} // 0x00000001892B67AC-0x00000001892B68E8
		private int WriteValueToBuffer(DateTimeOffset value) => default; // 0x00000001892B616C-0x00000001892B62D0
		public override void WriteValue(Guid value) {} // 0x00000001892B6674-0x00000001892B6744
		public override void WriteValue(TimeSpan value) {} // 0x00000001892B6B84-0x00000001892B6C60
		[NullableContext(2)]
		public override void WriteValue(System.Uri value) {} // 0x00000001892B6960-0x00000001892B69F8
		[NullableContext(2)]
		public override void WriteComment(string text) {} // 0x00000001892B5ED0-0x00000001892B5F6C
		private void EnsureWriteBuffer() {} // 0x0000000182905E70-0x0000000182905EC0
		private void WriteIntegerValue(long value) {} // 0x0000000182907570-0x00000001829075A0
		private void WriteIntegerValue(ulong value, bool negative) {} // 0x00000001829058A0-0x0000000182905930
		private int WriteNumberToBuffer(ulong value, bool negative) => default; // 0x0000000182905930-0x0000000182905970
		private void WriteIntegerValue(int value) {} // 0x0000000182905450-0x00000001829054A0
		private void WriteIntegerValue(uint value, bool negative) {} // 0x00000001892B5F6C-0x00000001892B5FE0
		private int WriteNumberToBuffer(uint value, bool negative) => default; // 0x0000000182905970-0x0000000182905A20
	}

	public enum JsonToken // TypeDefIndex: 51640
	{
		None = 0,
		StartObject = 1,
		StartArray = 2,
		StartConstructor = 3,
		PropertyName = 4,
		Comment = 5,
		Raw = 6,
		Integer = 7,
		Float = 8,
		String = 9,
		Boolean = 10,
		Null = 11,
		Undefined = 12,
		EndObject = 13,
		EndArray = 14,
		EndConstructor = 15,
		Date = 16,
		Bytes = 17
	}

	[Nullable(0)]
	[NullableContext(1)]
	public abstract class JsonWriter : IDisposable // TypeDefIndex: 51642
	{
		// Fields
		private static readonly State[][] StateArray; // 0x00
		internal static readonly State[][] StateArrayTemplate; // 0x08
		[Nullable(2)]
		private List<JsonPosition> _stack; // 0x10
		private JsonPosition _currentPosition; // 0x18
		private State _currentState; // 0x30
		private Newtonsoft.Json.Formatting _formatting; // 0x34
		private DateFormatHandling _dateFormatHandling; // 0x3C
		private DateTimeZoneHandling _dateTimeZoneHandling; // 0x40
		private StringEscapeHandling _stringEscapeHandling; // 0x44
		private FloatFormatHandling _floatFormatHandling; // 0x48
		[Nullable(2)]
		private string _dateFormatString; // 0x50
		[Nullable(2)]
		private CultureInfo _culture; // 0x58
	
		// Properties
		public bool CloseOutput { get; set; } // 0x0000000183D4F190-0x0000000183D4F1A0 0x0000000183D4E280-0x0000000183D4E290
		public bool AutoCompleteOnClose { get; set; } // 0x0000000183D4F300-0x0000000183D4F310 0x0000000183D4F330-0x0000000183D4F340
		protected internal int Top { get; } // 0x00000001825EE690-0x00000001825EE6F0 
		public Newtonsoft.Json.WriteState WriteState { get; } // 0x00000001892B7FA0-0x00000001892B80A4 
		internal string ContainerPath { get; } // 0x00000001892B7E28-0x00000001892B7EAC 
		public string Path { get; } // 0x00000001892B7EAC-0x00000001892B7FA0 
		public Newtonsoft.Json.Formatting Formatting { get; set; } // 0x0000000183D4EE00-0x0000000183D4EE10 0x0000000182697660-0x0000000182697680
		public DateFormatHandling DateFormatHandling { get; set; } // 0x0000000183D4ED90-0x0000000183D4EDA0 0x00000001892B80A4-0x00000001892B810C
		public DateTimeZoneHandling DateTimeZoneHandling { get; set; } // 0x0000000183D4ED80-0x0000000183D4ED90 0x00000001892B810C-0x00000001892B8174
		public StringEscapeHandling StringEscapeHandling { get; set; } // 0x0000000183D4EE80-0x0000000183D4EE90 0x00000001892B81DC-0x00000001892B8530
		public FloatFormatHandling FloatFormatHandling { get; set; } // 0x0000000183D4EC50-0x0000000183D4EC60 0x00000001892B8174-0x00000001892B81DC
		[Nullable(2)]
		public string DateFormatString { [NullableContext(2)] get; [NullableContext(2)] set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public CultureInfo Culture { get; set; } // 0x0000000183163B30-0x0000000183163B90 0x0000000183081D30-0x0000000183081D40
	
		// Nested types
		[NullableContext(0)]
		internal enum State // TypeDefIndex: 51641
		{
			Start = 0,
			Property = 1,
			ObjectStart = 2,
			Object = 3,
			ArrayStart = 4,
			Array = 5,
			ConstructorStart = 6,
			Constructor = 7,
			Closed = 8,
			Error = 9
		}
	
		// Constructors
		static JsonWriter() {} // 0x0000000182563190-0x0000000182563450
		protected JsonWriter() {} // 0x0000000183D71470-0x0000000183D71490
	
		// Methods
		internal static State[][] BuildStateArray() => default; // 0x0000000182905610-0x00000001829057F0
		internal virtual void OnStringEscapeHandlingChanged() {} // 0x000000018350B670-0x000000018350B680
		internal void UpdateScopeWithFinishedValue() {} // 0x0000000182906C00-0x0000000182906C10
		private void Push(JsonContainerType value) {} // 0x0000000182906DD0-0x0000000182906EF0
		private JsonContainerType Pop() => default; // 0x0000000183437BF0-0x0000000183437CE0
		private JsonContainerType Peek() => default; // 0x00000001820D1AC0-0x00000001820D1AD0
		public virtual void Close() {} // 0x00000001825EE630-0x00000001825EE640
		public virtual void WriteStartObject() {} // 0x0000000184271184-0x0000000184271194
		public virtual void WriteEndObject() {} // 0x00000001838936C0-0x00000001838936D0
		public virtual void WriteStartArray() {} // 0x0000000184271194-0x00000001842711A4
		public virtual void WriteEndArray() {} // 0x00000001838936B0-0x00000001838936C0
		public virtual void WriteStartConstructor(string name) {} // 0x00000001892B753C-0x00000001892B754C
		public virtual void WriteEndConstructor() {} // 0x00000001892B7410-0x00000001892B7420
		public virtual void WritePropertyName(string name) {} // 0x00000001842711A4-0x00000001842711AC
		public virtual void WritePropertyName(string name, bool escape) {} // 0x0000000183B45E00-0x0000000183B45E20
		public virtual void WriteEnd() {} // 0x00000001892B7420-0x00000001892B742C
		public void WriteToken(JsonReader reader) {} // 0x0000000184271108-0x0000000184271114
		public void WriteToken(JsonReader reader, bool writeChildren) {} // 0x000000018269A170-0x000000018269A1E0
		[NullableContext(2)]
		public void WriteToken(JsonToken token, object value) {} // 0x000000018269A500-0x000000018269A840
		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) {} // 0x000000018269A370-0x000000018269A4F0
		private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth) => default; // 0x000000018269A2C0-0x000000018269A310
		private int CalculateWriteTokenInitialDepth(JsonReader reader) => default; // 0x000000018269A840-0x000000018269A890
		private int CalculateWriteTokenFinalDepth(JsonReader reader) => default; // 0x000000018269A310-0x000000018269A370
		private void WriteConstructorDate(JsonReader reader) {} // 0x00000001892B7368-0x00000001892B7410
		private void WriteEnd(JsonContainerType type) {} // 0x00000001892B742C-0x00000001892B74EC
		private void AutoCompleteAll() {} // 0x00000001825EE640-0x00000001825EE690
		private JsonToken GetCloseTokenForType(JsonContainerType type) => default; // 0x0000000183437B50-0x0000000183437B90
		private void AutoCompleteClose(JsonContainerType type) {} // 0x0000000183437AB0-0x0000000183437B50
		private int CalculateLevelsToComplete(JsonContainerType type) => default; // 0x0000000183437B90-0x0000000183437BF0
		private void UpdateCurrentState() {} // 0x0000000183437CE0-0x0000000183437D20
		protected virtual void WriteEnd(JsonToken token) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void WriteIndent() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void WriteValueDelimiter() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void WriteIndentSpace() {} // 0x000000018350B670-0x000000018350B680
		internal void AutoComplete(JsonToken tokenBeingWritten) {} // 0x0000000182906C10-0x0000000182906D50
		public virtual void WriteNull() {} // 0x00000001892B74EC-0x00000001892B74FC
		public virtual void WriteUndefined() {} // 0x00000001892B754C-0x00000001892B755C
		[NullableContext(2)]
		public virtual void WriteRaw(string json) {} // 0x000000018350B670-0x000000018350B680
		[NullableContext(2)]
		public virtual void WriteRawValue(string json) {} // 0x00000001892B74FC-0x00000001892B753C
		[NullableContext(2)]
		public virtual void WriteValue(string value) {} // 0x00000001842711D8-0x00000001842711E8
		public virtual void WriteValue(int value) {} // 0x00000001842711E8-0x00000001842711F8
		[CLSCompliant(false)]
		public virtual void WriteValue(uint value) {} // 0x00000001842711E8-0x00000001842711F8
		public virtual void WriteValue(long value) {} // 0x00000001842711E8-0x00000001842711F8
		[CLSCompliant(false)]
		public virtual void WriteValue(ulong value) {} // 0x00000001842711E8-0x00000001842711F8
		public virtual void WriteValue(float value) {} // 0x00000001892B7718-0x00000001892B7728
		public virtual void WriteValue(double value) {} // 0x00000001892B7718-0x00000001892B7728
		public virtual void WriteValue(bool value) {} // 0x0000000184276B00-0x0000000184276B10
		public virtual void WriteValue(short value) {} // 0x00000001842711E8-0x00000001842711F8
		[CLSCompliant(false)]
		public virtual void WriteValue(ushort value) {} // 0x00000001842711E8-0x00000001842711F8
		public virtual void WriteValue(char value) {} // 0x00000001842711D8-0x00000001842711E8
		public virtual void WriteValue(byte value) {} // 0x00000001842711E8-0x00000001842711F8
		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte value) {} // 0x00000001842711E8-0x00000001842711F8
		public virtual void WriteValue(decimal value) {} // 0x00000001892B7718-0x00000001892B7728
		public virtual void WriteValue(System.DateTime value) {} // 0x00000001892B75C8-0x00000001892B75D8
		public virtual void WriteValue(DateTimeOffset value) {} // 0x00000001892B75C8-0x00000001892B75D8
		public virtual void WriteValue(Guid value) {} // 0x00000001842711D8-0x00000001842711E8
		public virtual void WriteValue(TimeSpan value) {} // 0x00000001842711D8-0x00000001842711E8
		public virtual void WriteValue(int? value) {} // 0x00000001892B7CEC-0x00000001892B7D58
		[CLSCompliant(false)]
		public virtual void WriteValue(uint? value) {} // 0x00000001892B77F4-0x00000001892B7860
		public virtual void WriteValue(long? value) {} // 0x00000001892B7A74-0x00000001892B7ADC
		[CLSCompliant(false)]
		public virtual void WriteValue(ulong? value) {} // 0x00000001892B7934-0x00000001892B799C
		public virtual void WriteValue(float? value) {} // 0x00000001892B7728-0x00000001892B7794
		public virtual void WriteValue(double? value) {} // 0x00000001892B7860-0x00000001892B78C8
		public virtual void WriteValue(bool? value) {} // 0x00000001892B7C4C-0x00000001892B7CB8
		public virtual void WriteValue(short? value) {} // 0x00000001892B799C-0x00000001892B7A08
		[CLSCompliant(false)]
		public virtual void WriteValue(ushort? value) {} // 0x00000001892B7DC4-0x00000001892B7E28
		public virtual void WriteValue(char? value) {} // 0x00000001892B755C-0x00000001892B75C8
		public virtual void WriteValue(byte? value) {} // 0x00000001892B78C8-0x00000001892B7934
		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte? value) {} // 0x00000001892B76B0-0x00000001892B7718
		public virtual void WriteValue(decimal? value) {} // 0x00000001892B7640-0x00000001892B76B0
		public virtual void WriteValue(System.DateTime? value) {} // 0x00000001892B75D8-0x00000001892B7640
		public virtual void WriteValue(DateTimeOffset? value) {} // 0x00000001892B7A08-0x00000001892B7A74
		public virtual void WriteValue(Guid? value) {} // 0x00000001892B7D58-0x00000001892B7DC4
		public virtual void WriteValue(TimeSpan? value) {} // 0x00000001892B7794-0x00000001892B77F4
		[NullableContext(2)]
		public virtual void WriteValue(byte[] value) {} // 0x00000001892B7CB8-0x00000001892B7CEC
		[NullableContext(2)]
		public virtual void WriteValue(System.Uri value) {} // 0x00000001892B7ADC-0x00000001892B7B50
		[NullableContext(2)]
		public virtual void WriteValue(object value) {} // 0x00000001892B7B50-0x00000001892B7C4C
		[NullableContext(2)]
		public virtual void WriteComment(string text) {} // 0x00000001892B7054-0x00000001892B7064
		void IDisposable.Dispose() {} // 0x000000018341A550-0x000000018341A5B0
		protected virtual void Dispose(bool disposing) {} // 0x000000018341A5B0-0x000000018341A5E0
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) {} // 0x00000001827BB550-0x00000001827BB940
		private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value) {
			typeCode = default;
			value = default;
		} // 0x00000001892B7064-0x00000001892B715C
		private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) => default; // 0x00000001892B6FB4-0x00000001892B7054
		protected void SetWriteState(JsonToken token, object value) {} // 0x00000001892B715C-0x00000001892B7368
		internal void InternalWriteEnd(JsonContainerType container) {} // 0x0000000184276BEC-0x0000000184276BF4
		internal void InternalWritePropertyName(string name) {} // 0x0000000182906BB0-0x0000000182906BE0
		internal void InternalWriteRaw() {} // 0x000000018350B670-0x000000018350B680
		internal void InternalWriteStart(JsonToken token, JsonContainerType container) {} // 0x0000000182905D50-0x0000000182905D90
		internal void InternalWriteValue(JsonToken token) {} // 0x0000000182906BE0-0x0000000182906C00
		internal void InternalWriteComment() {} // 0x00000001892B7054-0x00000001892B7064
	}

	[Serializable]
	[Nullable(0)]
	[NullableContext(1)]
	public class JsonWriterException : JsonException // TypeDefIndex: 51643
	{
		// Constructors
		public JsonWriterException() {} // 0x00000001892B11D4-0x00000001892B11DC
		public JsonWriterException(SerializationInfo info, StreamingContext context) {} // 0x00000001892B1234-0x00000001892B1254
		public JsonWriterException(string message, string path, [Nullable(2)] Exception innerException) {} // 0x00000001892C15B4-0x00000001892C15F0
	
		// Methods
		internal static JsonWriterException Create(JsonWriter writer, string message, [Nullable(2)] Exception ex) => default; // 0x00000001892C1574-0x00000001892C15B4
		internal static JsonWriterException Create(string path, string message, [Nullable(2)] Exception ex) => default; // 0x00000001892C14C4-0x00000001892C1574
	}

	public enum MemberSerialization // TypeDefIndex: 51644
	{
		OptOut = 0,
		OptIn = 1,
		Fields = 2
	}

	public enum MetadataPropertyHandling // TypeDefIndex: 51645
	{
		Default = 0,
		ReadAhead = 1,
		Ignore = 2
	}

	public enum MissingMemberHandling // TypeDefIndex: 51646
	{
		Ignore = 0,
		Error = 1
	}

	public enum NullValueHandling // TypeDefIndex: 51647
	{
		Include = 0,
		Ignore = 1
	}

	public enum ObjectCreationHandling // TypeDefIndex: 51648
	{
		Auto = 0,
		Reuse = 1,
		Replace = 2
	}

	[Flags]
	public enum PreserveReferencesHandling // TypeDefIndex: 51649
	{
		None = 0,
		Objects = 1,
		Arrays = 2,
		All = 3
	}

	public enum ReferenceLoopHandling // TypeDefIndex: 51650
	{
		Error = 0,
		Ignore = 1,
		Serialize = 2
	}

	public enum Required // TypeDefIndex: 51651
	{
		Default = 0,
		AllowNull = 1,
		Always = 2,
		DisallowNull = 3
	}

	public enum StringEscapeHandling // TypeDefIndex: 51652
	{
		Default = 0,
		EscapeNonAscii = 1,
		EscapeHtml = 2
	}

	public enum TypeNameAssemblyFormatHandling // TypeDefIndex: 51653
	{
		Simple = 0,
		Full = 1
	}

	[Flags]
	public enum TypeNameHandling // TypeDefIndex: 51654
	{
		None = 0,
		Objects = 1,
		Arrays = 2,
		All = 3,
		Auto = 4
	}

	public enum WriteState // TypeDefIndex: 51655
	{
		Error = 0,
		Closed = 1,
		Object = 2,
		Array = 3,
		Constructor = 4,
		Property = 5,
		Start = 6
	}
}

namespace Newtonsoft.Json.Bson
{
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonObjectId // TypeDefIndex: 51883
	{
		// Properties
		public byte[] Value { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public BsonObjectId() {} // Dummy constructor
		public BsonObjectId(byte[] value) {} // 0x00000001892E059C-0x00000001892E069C
	}

	internal abstract class BsonToken // TypeDefIndex: 51884
	{
		// Properties
		public abstract BsonType Type { get; }
		public BsonToken Parent { get; set; } // 0x000000018426FEE0-0x000000018426FEF0
	
		// Constructors
		protected BsonToken() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class BsonObject : BsonToken // TypeDefIndex: 51885
	{
		// Fields
		private readonly List<BsonProperty> _children; // 0x18
	
		// Properties
		public override BsonType Type { get => default; } // 0x0000000183D51050-0x0000000183D51060 
	
		// Constructors
		public BsonObject() {} // Dummy constructor
	
		// Methods
		public void Add(string name, BsonToken token) {} // 0x00000001892E069C-0x00000001892E0794
	}

	internal class BsonArray : BsonToken // TypeDefIndex: 51886
	{
		// Fields
		private readonly List<BsonToken> _children; // 0x18
	
		// Properties
		public override BsonType Type { get => default; } // 0x0000000183D51040-0x0000000183D51050 
	
		// Constructors
		public BsonArray() {} // Dummy constructor
	
		// Methods
		public void Add(BsonToken token) {} // 0x00000001892E0534-0x00000001892E059C
	}

	internal class BsonValue : BsonToken // TypeDefIndex: 51887
	{
		// Fields
		private readonly object _value; // 0x18
		private readonly BsonType _type; // 0x20
	
		// Properties
		public override BsonType Type { get => default; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
	
		// Constructors
		public BsonValue() {} // Dummy constructor
		public BsonValue(object value, BsonType type) {} // 0x0000000187F33C78-0x0000000187F33C9C
	}

	internal class BsonString : BsonValue // TypeDefIndex: 51888
	{
		// Constructors
		public BsonString() {} // Dummy constructor
		public BsonString(object value, bool includeLength) {} // 0x00000001892E084C-0x00000001892E0874
	}

	internal class BsonRegex : BsonToken // TypeDefIndex: 51889
	{
		// Properties
		public BsonString Pattern { get; set; } // 0x00000001822C3A90-0x00000001822C3AA0
		public BsonString Options { get; set; } // 0x0000000184271930-0x0000000184271940
		public override BsonType Type { get => default; } // 0x0000000183D5C650-0x0000000183D5C660 
	
		// Constructors
		public BsonRegex() {} // Dummy constructor
		public BsonRegex(string pattern, string options) {} // 0x00000001892E0794-0x00000001892E084C
	}

	internal class BsonProperty // TypeDefIndex: 51890
	{
		// Properties
		public BsonString Name { get; set; } // 0x000000018426FEE0-0x000000018426FEF0
		public BsonToken Value { get; set; } // 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public BsonProperty() {} // 0x000000018350B670-0x000000018350B680
	}

	internal enum BsonType : sbyte // TypeDefIndex: 51891
	{
		Number = 1,
		String = 2,
		Object = 3,
		Array = 4,
		Binary = 5,
		Undefined = 6,
		Oid = 7,
		Boolean = 8,
		Date = 9,
		Null = 10,
		Regex = 11,
		Reference = 12,
		Code = 13,
		Symbol = 14,
		CodeWScope = 15,
		Integer = 16,
		TimeStamp = 17,
		Long = 18,
		MaxKey = 127,
		MinKey = 255
	}

	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonWriter : JsonWriter // TypeDefIndex: 51892
	{
		// Fields
		private BsonToken _root; // 0x60
		private BsonToken _parent; // 0x68
		private string _propertyName; // 0x70
	
		// Constructors
		public BsonWriter() {} // Dummy constructor
	
		// Methods
		private void AddValue(object value, BsonType type) {} // 0x00000001892E0A10-0x00000001892E0A98
		internal void AddToken(BsonToken token) {} // 0x00000001892E0874-0x00000001892E0A10
		public void WriteObjectId(byte[] value) {} // 0x00000001892E0A98-0x00000001892E0B84
		public void WriteRegex(string pattern, string options) {} // 0x00000001892E0B84-0x00000001892E0C78
	}
}

namespace Newtonsoft.Json.Converters
{
	[Nullable(0)]
	[NullableContext(1)]
	public class BinaryConverter : JsonConverter // TypeDefIndex: 51842
	{
		// Fields
		private const string BinaryTypeName = "System.Data.Linq.Binary"; // Metadata: 0x01FD1218
		private const string BinaryToArrayName = "ToArray"; // Metadata: 0x01FD1230
		[Nullable(2)]
		private static ReflectionObject _reflectionObject; // 0x00
	
		// Constructors
		public BinaryConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {} // 0x00000001892CE610-0x00000001892CE660
		private byte[] GetByteArray(object value) => default; // 0x00000001892CDE50-0x00000001892CE014
		private static void EnsureReflectionObject(System.Type t) {} // 0x00000001892CDCE8-0x00000001892CDE50
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default; // 0x00000001892CE22C-0x00000001892CE610
		private byte[] ReadByteArray(JsonReader reader) => default; // 0x00000001892CE014-0x00000001892CE22C
		public override bool CanConvert(System.Type objectType) => default; // 0x000000018323F3B0-0x000000018323F4C0
	}

	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonObjectIdConverter : JsonConverter // TypeDefIndex: 51843
	{
		// Constructors
		public BsonObjectIdConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {} // 0x00000001892CE7B4-0x00000001892CE854
		public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer) => default; // 0x00000001892CE660-0x00000001892CE7B4
		public override bool CanConvert(System.Type objectType) => default; // 0x00000001833B3D50-0x00000001833B3DC0
	}

	[Nullable(0)]
	[NullableContext(1)]
	public abstract class CustomCreationConverter<T> : JsonConverter // TypeDefIndex: 51844
	{
		// Properties
		public override bool CanWrite { get; }
	
		// Constructors
		protected CustomCreationConverter() {}
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {}
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default;
		public abstract T Create(System.Type objectType);
		public override bool CanConvert(System.Type objectType) => default;
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class DataSetConverter : JsonConverter // TypeDefIndex: 51845
	{
		// Constructors
		public DataSetConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {} // 0x00000001892E0E98-0x00000001892E1194
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default; // 0x00000001892E0C78-0x00000001892E0E98
		public override bool CanConvert(System.Type valueType) => default; // 0x0000000183365BE0-0x0000000183365C70
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class DataTableConverter : JsonConverter // TypeDefIndex: 51846
	{
		// Constructors
		public DataTableConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {} // 0x00000001892E19AC-0x00000001892E1E5C
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default; // 0x00000001892E1754-0x00000001892E19AC
		private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer) {} // 0x00000001892E1194-0x00000001892E1580
		private static System.Type GetColumnDataType(JsonReader reader) => default; // 0x00000001892E1580-0x00000001892E1754
		public override bool CanConvert(System.Type valueType) => default; // 0x0000000183365B50-0x0000000183365BE0
	}

	public abstract class DateTimeConverterBase : JsonConverter // TypeDefIndex: 51847
	{
		// Constructors
		protected DateTimeConverterBase() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[NullableContext(1)]
		public override bool CanConvert(System.Type objectType) => default; // 0x00000001892E1E5C-0x00000001892E1F50
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class DiscriminatedUnionConverter : JsonConverter // TypeDefIndex: 51852
	{
		// Fields
		private const string CasePropertyName = "Case"; // Metadata: 0x01FD1238
		private const string FieldsPropertyName = "Fields"; // Metadata: 0x01FD123D
		private static readonly ThreadSafeStore<System.Type, Union> UnionCache; // 0x00
		private static readonly ThreadSafeStore<System.Type, System.Type> UnionTypeLookupCache; // 0x08
	
		// Nested types
		[Nullable(0)]
		internal class Union // TypeDefIndex: 51848
		{
			// Fields
			public readonly FSharpFunction TagReader; // 0x10
			public readonly List<UnionCase> Cases; // 0x18
	
			// Constructors
			public Union() {} // Dummy constructor
			public Union(FSharpFunction tagReader, List<UnionCase> cases) {} // 0x0000000182676770-0x00000001826767A0
		}
	
		[Nullable(0)]
		internal class UnionCase // TypeDefIndex: 51849
		{
			// Fields
			public readonly int Tag; // 0x10
			public readonly string Name; // 0x18
			public readonly PropertyInfo[] Fields; // 0x20
			public readonly FSharpFunction FieldReader; // 0x28
			public readonly FSharpFunction Constructor; // 0x30
	
			// Constructors
			public UnionCase() {} // Dummy constructor
			public UnionCase(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor) {} // 0x00000001892E5FE0-0x00000001892E602C
		}
	
		// Constructors
		public DiscriminatedUnionConverter() {} // 0x000000018350B670-0x000000018350B680
		static DiscriminatedUnionConverter() {} // 0x00000001838CEDA0-0x00000001838CF0A0
	
		// Methods
		private static System.Type CreateUnionTypeLookup(System.Type t) => default; // 0x00000001892E1F50-0x00000001892E2074
		private static Union CreateUnion(System.Type t) => default; // 0x00000001892E2074-0x00000001892E24FC
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {} // 0x00000001892E2B94-0x00000001892E2F60
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default; // 0x00000001892E24FC-0x00000001892E2B94
		public override bool CanConvert(System.Type objectType) => default; // 0x000000018283D120-0x000000018283D2E0
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class EntityKeyMemberConverter : JsonConverter // TypeDefIndex: 51853
	{
		// Fields
		private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember"; // Metadata: 0x01FD1244
		private const string KeyPropertyName = "Key"; // Metadata: 0x01FD1260
		private const string TypePropertyName = "Type"; // Metadata: 0x01FD1264
		private const string ValuePropertyName = "Value"; // Metadata: 0x01FD1269
		[Nullable(2)]
		private static ReflectionObject _reflectionObject; // 0x00
	
		// Constructors
		public EntityKeyMemberConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {} // 0x00000001892E3384-0x00000001892E3644
		private static void ReadAndAssertProperty(JsonReader reader, string propertyName) {} // 0x00000001892E3044-0x00000001892E3140
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default; // 0x00000001892E3140-0x00000001892E3384
		private static void EnsureReflectionObject(System.Type objectType) {} // 0x00000001892E2F60-0x00000001892E3044
		public override bool CanConvert(System.Type objectType) => default; // 0x0000000183269D90-0x0000000183269DE0
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class ExpandoObjectConverter : JsonConverter // TypeDefIndex: 51854
	{
		// Properties
		public override bool CanWrite { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public ExpandoObjectConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {} // 0x000000018350B670-0x000000018350B680
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default; // 0x00000001892E3644-0x00000001892E364C
		private object ReadValue(JsonReader reader) => default; // 0x00000001892E3900-0x00000001892E3A70
		private object ReadList(JsonReader reader) => default; // 0x00000001892E364C-0x00000001892E3768
		private object ReadObject(JsonReader reader) => default; // 0x00000001892E3768-0x00000001892E3900
		public override bool CanConvert(System.Type objectType) => default; // 0x00000001833B3CE0-0x00000001833B3D50
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class IsoDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 51855
	{
		// Fields
		private const string DefaultDateTimeFormat = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.FFFFFFFK"; // Metadata: 0x01FD126F
		private DateTimeStyles _dateTimeStyles; // 0x10
		[Nullable(2)]
		private string _dateTimeFormat; // 0x18
		[Nullable(2)]
		private CultureInfo _culture; // 0x20
	
		// Properties
		public DateTimeStyles DateTimeStyles { get => default; set {} } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		[Nullable(2)]
		public string DateTimeFormat { [NullableContext(2)] get => default; [NullableContext(2)] set {} } // 0x00000001892E4138-0x00000001892E4180 0x00000001892E4180-0x00000001892E41C8
		public CultureInfo Culture { get => default; set {} } // 0x00000001892E40E4-0x00000001892E4138 0x0000000184271930-0x0000000184271940
	
		// Constructors
		public IsoDateTimeConverter() {} // 0x0000000183D71650-0x0000000183D71660
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {} // 0x00000001892E3EA8-0x00000001892E40E4
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default; // 0x00000001892E3A70-0x00000001892E3EA8
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class JavaScriptDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 51856
	{
		// Constructors
		public JavaScriptDateTimeConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {} // 0x00000001892E44E4-0x00000001892E467C
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default; // 0x00000001892E41C8-0x00000001892E44E4
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class KeyValuePairConverter : JsonConverter // TypeDefIndex: 51857
	{
		// Fields
		private const string KeyName = "Key"; // Metadata: 0x01FD1296
		private const string ValueName = "Value"; // Metadata: 0x01FD129A
		private static readonly ThreadSafeStore<System.Type, ReflectionObject> ReflectionObjectPerType; // 0x00
	
		// Constructors
		public KeyValuePairConverter() {} // 0x000000018350B670-0x000000018350B680
		static KeyValuePairConverter() {} // 0x0000000183C83B50-0x0000000183C83C30
	
		// Methods
		private static ReflectionObject InitializeReflectionObject(System.Type t) => default; // 0x00000001892E467C-0x00000001892E47FC
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {} // 0x00000001892E4B58-0x00000001892E4D6C
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default; // 0x00000001892E47FC-0x00000001892E4B58
		public override bool CanConvert(System.Type objectType) => default; // 0x00000001824768F0-0x00000001824769F0
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class RegexConverter : JsonConverter // TypeDefIndex: 51858
	{
		// Fields
		private const string PatternName = "Pattern"; // Metadata: 0x01FD12A0
		private const string OptionsName = "Options"; // Metadata: 0x01FD12A8
	
		// Constructors
		public RegexConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {} // 0x00000001892E54E0-0x00000001892E55A8
		private bool HasFlag(RegexOptions options, RegexOptions flag) => default; // 0x0000000182325BB0-0x0000000182325C30
		private void WriteBson(BsonWriter writer, Regex regex) {} // 0x00000001892E5250-0x00000001892E536C
		private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) {} // 0x00000001892E536C-0x00000001892E54E0
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default; // 0x00000001892E4DD0-0x00000001892E4E70
		private object ReadRegexString(JsonReader reader) => default; // 0x00000001892E5100-0x00000001892E5250
		private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) => default; // 0x00000001892E4E70-0x00000001892E5100
		public override bool CanConvert(System.Type objectType) => default; // 0x0000000183365C70-0x0000000183365CE0
		private bool IsRegex(System.Type objectType) => default; // 0x00000001892E4D6C-0x00000001892E4DD0
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class StringEnumConverter : JsonConverter // TypeDefIndex: 51859
	{
		// Properties
		[Obsolete("StringEnumConverter.CamelCaseText is obsolete. Set StringEnumConverter.NamingStrategy with CamelCaseNamingStrategy instead.")]
		public bool CamelCaseText { get => default; set {} } // 0x00000001892E5EF0-0x00000001892E5F34 0x00000001892E5F34-0x00000001892E5FB8
		[Nullable(2)]
		public NamingStrategy NamingStrategy { [NullableContext(2)] get; [NullableContext(2)] set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public bool AllowIntegerValues { get; set; } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
	
		// Constructors
		public StringEnumConverter() {} // 0x0000000183D587A0-0x0000000183D587B0
		[Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
		public StringEnumConverter(bool camelCaseText) {} // 0x00000001892E5C1C-0x00000001892E5C80
		public StringEnumConverter(NamingStrategy namingStrategy, bool allowIntegerValues = true /* Metadata: 0x01FD12B0 */) {} // 0x00000001892E5BF4-0x00000001892E5C1C
		public StringEnumConverter(System.Type namingStrategyType) {} // 0x00000001892E5C80-0x00000001892E5D40
		public StringEnumConverter(System.Type namingStrategyType, object[] namingStrategyParameters) {} // 0x00000001892E5D40-0x00000001892E5E10
		public StringEnumConverter(System.Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues) {} // 0x00000001892E5E10-0x00000001892E5EF0
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {} // 0x00000001892E5A38-0x00000001892E5BF4
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default; // 0x00000001892E5604-0x00000001892E5A38
		public override bool CanConvert(System.Type objectType) => default; // 0x00000001892E55A8-0x00000001892E5604
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class UnixDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 51860
	{
		// Fields
		internal static readonly System.DateTime UnixEpoch; // 0x00
	
		// Properties
		public bool AllowPreEpoch { get; set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
	
		// Constructors
		public UnixDateTimeConverter() {} // 0x0000000183D557C0-0x0000000183D557D0
		public UnixDateTimeConverter(bool allowPreEpoch) {} // 0x0000000183D4E960-0x0000000183D4E970
		static UnixDateTimeConverter() {} // 0x00000001892E66AC-0x00000001892E6724
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {} // 0x00000001892E6458-0x00000001892E66AC
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default; // 0x00000001892E602C-0x00000001892E6458
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class VersionConverter : JsonConverter // TypeDefIndex: 51861
	{
		// Constructors
		public VersionConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {} // 0x00000001892E6A00-0x00000001892E6AD4
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default; // 0x00000001892E6788-0x00000001892E6A00
		public override bool CanConvert(System.Type objectType) => default; // 0x00000001892E6724-0x00000001892E6788
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument // TypeDefIndex: 51862
	{
		// Fields
		private readonly XmlDocument _document; // 0x28
	
		// Properties
		[Nullable(2)]
		public IXmlElement DocumentElement { [NullableContext(2)] get => default; } // 0x00000001892E9160-0x00000001892E91EC 
	
		// Constructors
		public XmlDocumentWrapper() {} // Dummy constructor
		public XmlDocumentWrapper(XmlDocument document) {} // 0x00000001892E8A00-0x00000001892E8A28
	
		// Methods
		public IXmlNode CreateComment([Nullable(2)] string data) => default; // 0x00000001892E8C9C-0x00000001892E8D18
		public IXmlNode CreateTextNode([Nullable(2)] string text) => default; // 0x00000001892E8F28-0x00000001892E8FA4
		public IXmlNode CreateCDataSection([Nullable(2)] string data) => default; // 0x00000001892E8C20-0x00000001892E8C9C
		public IXmlNode CreateWhitespace([Nullable(2)] string text) => default; // 0x00000001892E8FA4-0x00000001892E9020
		public IXmlNode CreateSignificantWhitespace([Nullable(2)] string text) => default; // 0x00000001892E8EAC-0x00000001892E8F28
		public IXmlNode CreateXmlDeclaration(string version, [Nullable(2)] string encoding, [Nullable(2)] string standalone) => default; // 0x00000001892E9020-0x00000001892E90BC
		[NullableContext(2)]
		public IXmlNode CreateXmlDocumentType([Nullable(1)] string name, string publicId, string systemId, string internalSubset) => default; // 0x00000001892E90BC-0x00000001892E9160
		public IXmlNode CreateProcessingInstruction(string target, string data) => default; // 0x00000001892E8E20-0x00000001892E8EAC
		public IXmlElement CreateElement(string elementName) => default; // 0x00000001892E8D18-0x00000001892E8D94
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri) => default; // 0x00000001892E8D94-0x00000001892E8E20
		public IXmlNode CreateAttribute(string name, [Nullable(2)] string value) => default; // 0x00000001892E8AE8-0x00000001892E8B7C
		public IXmlNode CreateAttribute(string qualifiedName, [Nullable(2)] string namespaceUri, [Nullable(2)] string value) => default; // 0x00000001892E8B7C-0x00000001892E8C20
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement // TypeDefIndex: 51863
	{
		// Fields
		private readonly XmlElement _element; // 0x28
	
		// Properties
		public bool IsEmpty { get => default; } // 0x00000001892E9290-0x00000001892E92B0 
	
		// Constructors
		public XmlElementWrapper() {} // Dummy constructor
		public XmlElementWrapper(XmlElement element) {} // 0x00000001892E8A00-0x00000001892E8A28
	
		// Methods
		public void SetAttributeNode(IXmlNode attribute) {} // 0x00000001892E920C-0x00000001892E9290
		public string GetPrefixOfNamespace(string namespaceUri) => default; // 0x00000001892E91EC-0x00000001892E920C
	}

	[Nullable(0)]
	[NullableContext(2)]
	internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration // TypeDefIndex: 51864
	{
		// Fields
		[Nullable(1)]
		private readonly XmlDeclaration _declaration; // 0x28
	
		// Properties
		public string Version { get => default; } // 0x00000001892E8A60-0x00000001892E8A7C 
		public string Encoding { get => default; } // 0x00000001892E8A28-0x00000001892E8A44 
		public string Standalone { get => default; } // 0x00000001892E8A44-0x00000001892E8A60 
	
		// Constructors
		public XmlDeclarationWrapper() {} // Dummy constructor
		[NullableContext(1)]
		public XmlDeclarationWrapper(XmlDeclaration declaration) {} // 0x00000001892E8A00-0x00000001892E8A28
	}

	[Nullable(0)]
	[NullableContext(2)]
	internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType // TypeDefIndex: 51865
	{
		// Fields
		[Nullable(1)]
		private readonly XmlDocumentType _documentType; // 0x28
	
		// Properties
		[Nullable(1)]
		public string Name { [NullableContext(1)] get => default; } // 0x00000001892E8AC4-0x00000001892E8AE8 
		public string System { get => default; } // 0x00000001892E8A44-0x00000001892E8A60 
		public string Public { get => default; } // 0x00000001892E8A28-0x00000001892E8A44 
		public string InternalSubset { get => default; } // 0x00000001892E8A7C-0x00000001892E8A98 
		public override string LocalName { get => default; } // 0x00000001892E8A98-0x00000001892E8AC4 
	
		// Constructors
		public XmlDocumentTypeWrapper() {} // Dummy constructor
		[NullableContext(1)]
		public XmlDocumentTypeWrapper(XmlDocumentType documentType) {} // 0x00000001892E8A00-0x00000001892E8A28
	}

	[Nullable(0)]
	[NullableContext(2)]
	internal class XmlNodeWrapper : IXmlNode // TypeDefIndex: 51866
	{
		// Fields
		[Nullable(1)]
		private readonly XmlNode _node; // 0x10
		[Nullable(new byte[2] {2, 1 })]
		private List<IXmlNode> _childNodes; // 0x18
		[Nullable(new byte[2] {2, 1 })]
		private List<IXmlNode> _attributes; // 0x20
	
		// Properties
		public object WrappedNode { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public XmlNodeType NodeType { get => default; } // 0x00000001892EFB48-0x00000001892EFB6C 
		public virtual string LocalName { get => default; } // 0x00000001892EFB00-0x00000001892EFB24 
		[Nullable(1)]
		public List<IXmlNode> ChildNodes { [NullableContext(1)] get => default; } // 0x00000001892EF7C8-0x00000001892EFA80 
		[Nullable(1)]
		public List<IXmlNode> Attributes { [NullableContext(1)] get => default; } // 0x00000001892EF52C-0x00000001892EF7C8 
		private bool HasAttributes { get => default; } // 0x00000001892EFA80-0x00000001892EFB00 
		public IXmlNode ParentNode { get => default; } // 0x00000001892EFB6C-0x00000001892EFBE8 
		public string Value { get => default; set {} } // 0x00000001892EFBE8-0x00000001892EFC0C 0x00000001892EFC0C-0x00000001892EFC30
		public string NamespaceUri { get => default; } // 0x00000001892EFB24-0x00000001892EFB48 
	
		// Constructors
		public XmlNodeWrapper() {} // Dummy constructor
		[NullableContext(1)]
		public XmlNodeWrapper(XmlNode node) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		[NullableContext(1)]
		internal static IXmlNode WrapNode(XmlNode node) => default; // 0x00000001892EF3C0-0x00000001892EF52C
		[NullableContext(1)]
		public IXmlNode AppendChild(IXmlNode newChild) => default; // 0x00000001892EF338-0x00000001892EF3C0
	}

	[NullableContext(1)]
	internal interface IXmlDocument : IXmlNode // TypeDefIndex: 51867
	{
		// Properties
		[Nullable(2)]
		IXmlElement DocumentElement { [NullableContext(2)] get; }
	
		// Methods
		IXmlNode CreateComment([Nullable(2)] string text);
		IXmlNode CreateTextNode([Nullable(2)] string text);
		IXmlNode CreateCDataSection([Nullable(2)] string data);
		IXmlNode CreateWhitespace([Nullable(2)] string text);
		IXmlNode CreateSignificantWhitespace([Nullable(2)] string text);
		IXmlNode CreateXmlDeclaration(string version, [Nullable(2)] string encoding, [Nullable(2)] string standalone);
		[NullableContext(2)]
		IXmlNode CreateXmlDocumentType([Nullable(1)] string name, string publicId, string systemId, string internalSubset);
		IXmlNode CreateProcessingInstruction(string target, string data);
		IXmlElement CreateElement(string elementName);
		IXmlElement CreateElement(string qualifiedName, string namespaceUri);
		IXmlNode CreateAttribute(string name, string value);
		IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
	}

	[NullableContext(2)]
	internal interface IXmlDeclaration : IXmlNode // TypeDefIndex: 51868
	{
		// Properties
		string Version { get; }
		string Encoding { get; }
		string Standalone { get; }
	}

	[NullableContext(2)]
	internal interface IXmlDocumentType : IXmlNode // TypeDefIndex: 51869
	{
		// Properties
		[Nullable(1)]
		string Name { [NullableContext(1)] get; }
		string System { get; }
		string Public { get; }
		string InternalSubset { get; }
	}

	[NullableContext(1)]
	internal interface IXmlElement : IXmlNode // TypeDefIndex: 51870
	{
		// Properties
		bool IsEmpty { get; }
	
		// Methods
		void SetAttributeNode(IXmlNode attribute);
		string GetPrefixOfNamespace(string namespaceUri);
	}

	[NullableContext(2)]
	internal interface IXmlNode // TypeDefIndex: 51871
	{
		// Properties
		XmlNodeType NodeType { get; }
		string LocalName { get; }
		[Nullable(1)]
		List<IXmlNode> ChildNodes { [NullableContext(1)] get; }
		[Nullable(1)]
		List<IXmlNode> Attributes { [NullableContext(1)] get; }
		IXmlNode ParentNode { get; }
		string Value { get; }
		string NamespaceUri { get; }
		object WrappedNode { get; }
	
		// Methods
		[NullableContext(1)]
		IXmlNode AppendChild(IXmlNode newChild);
	}

	[Nullable(0)]
	[NullableContext(2)]
	internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration // TypeDefIndex: 51872
	{
		// Properties
		[Nullable(1)]
		internal XDeclaration Declaration { [NullableContext(1)] get; } // 0x0000000181041090-0x00000001810410A0 
		public override XmlNodeType NodeType { get => default; } // 0x0000000183D55F90-0x0000000183D55FA0 
		public string Version { get => default; } // 0x00000001892E734C-0x00000001892E7368 
		public string Encoding { get => default; } // 0x0000000186179578-0x0000000186179594 
		public string Standalone { get => default; } // 0x0000000185F986E4-0x0000000185F98700 
	
		// Constructors
		public XDeclarationWrapper() {} // Dummy constructor
		[NullableContext(1)]
		public XDeclarationWrapper(XDeclaration declaration) {} // 0x00000001892E7320-0x00000001892E734C
	}

	[Nullable(0)]
	[NullableContext(2)]
	internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType // TypeDefIndex: 51873
	{
		// Fields
		[Nullable(1)]
		private readonly XDocumentType _documentType; // 0x18
	
		// Properties
		[Nullable(1)]
		public string Name { [NullableContext(1)] get => default; } // 0x0000000185F9871C-0x0000000185F98738 
		public string System { get => default; } // 0x0000000185F407B4-0x0000000185F407D0 
		public string Public { get => default; } // 0x0000000186177C5C-0x0000000186177C78 
		public string InternalSubset { get => default; } // 0x00000001892E7390-0x00000001892E73AC 
		public override string LocalName { get => default; } // 0x00000001892E73AC-0x00000001892E73D8 
	
		// Constructors
		public XDocumentTypeWrapper() {} // Dummy constructor
		[NullableContext(1)]
		public XDocumentTypeWrapper(XDocumentType documentType) {} // 0x00000001892E7368-0x00000001892E7390
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class XDocumentWrapper : XContainerWrapper, IXmlDocument // TypeDefIndex: 51874
	{
		// Properties
		private XDocument Document { get => default; } // 0x00000001892E7DA0-0x00000001892E7DDC 
		public override List<IXmlNode> ChildNodes { get => default; } // 0x00000001892E7BF4-0x00000001892E7D04 
		protected override bool HasChildNodes { get => default; } // 0x00000001892E7DDC-0x00000001892E7E18 
		[Nullable(2)]
		public IXmlElement DocumentElement { [NullableContext(2)] get => default; } // 0x00000001892E7D04-0x00000001892E7DA0 
	
		// Constructors
		public XDocumentWrapper() {} // Dummy constructor
		public XDocumentWrapper(XDocument document) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public IXmlNode CreateComment([Nullable(2)] string text) => default; // 0x00000001892E7660-0x00000001892E76F0
		public IXmlNode CreateTextNode([Nullable(2)] string text) => default; // 0x00000001892E7968-0x00000001892E79F8
		public IXmlNode CreateCDataSection([Nullable(2)] string data) => default; // 0x00000001892E75D0-0x00000001892E7660
		public IXmlNode CreateWhitespace([Nullable(2)] string text) => default; // 0x00000001892E79F8-0x00000001892E7A88
		public IXmlNode CreateSignificantWhitespace([Nullable(2)] string text) => default; // 0x00000001892E78D8-0x00000001892E7968
		public IXmlNode CreateXmlDeclaration(string version, [Nullable(2)] string encoding, [Nullable(2)] string standalone) => default; // 0x00000001892E7A88-0x00000001892E7B38
		[NullableContext(2)]
		public IXmlNode CreateXmlDocumentType([Nullable(1)] string name, string publicId, string systemId, string internalSubset) => default; // 0x00000001892E7B38-0x00000001892E7BF4
		public IXmlNode CreateProcessingInstruction(string target, string data) => default; // 0x00000001892E7838-0x00000001892E78D8
		public IXmlElement CreateElement(string elementName) => default; // 0x00000001892E76F0-0x00000001892E778C
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri) => default; // 0x00000001892E778C-0x00000001892E7838
		public IXmlNode CreateAttribute(string name, string value) => default; // 0x00000001892E7468-0x00000001892E7514
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) => default; // 0x00000001892E7514-0x00000001892E75D0
		public override IXmlNode AppendChild(IXmlNode newChild) => default; // 0x00000001892E73D8-0x00000001892E7468
	}

	[Nullable(0)]
	[NullableContext(2)]
	internal class XTextWrapper : XObjectWrapper // TypeDefIndex: 51875
	{
		// Properties
		[Nullable(1)]
		private XText Text { [NullableContext(1)] get => default; } // 0x00000001892E89A4-0x00000001892E89E0 
		public override string Value { get => default; } // 0x00000001892E89E0-0x00000001892E8A00 
		public override IXmlNode ParentNode { get => default; } // 0x00000001892E894C-0x00000001892E89A4 
	
		// Constructors
		public XTextWrapper() {} // Dummy constructor
		[NullableContext(1)]
		public XTextWrapper(XText text) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[Nullable(0)]
	[NullableContext(2)]
	internal class XCommentWrapper : XObjectWrapper // TypeDefIndex: 51876
	{
		// Properties
		[Nullable(1)]
		private XComment Text { [NullableContext(1)] get => default; } // 0x00000001892E6C34-0x00000001892E6C70 
		public override string Value { get => default; } // 0x00000001892E6C70-0x00000001892E6C90 
		public override IXmlNode ParentNode { get => default; } // 0x00000001892E6BDC-0x00000001892E6C34 
	
		// Constructors
		public XCommentWrapper() {} // Dummy constructor
		[NullableContext(1)]
		public XCommentWrapper(XComment text) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[Nullable(0)]
	[NullableContext(2)]
	internal class XProcessingInstructionWrapper : XObjectWrapper // TypeDefIndex: 51877
	{
		// Properties
		[Nullable(1)]
		private XProcessingInstruction ProcessingInstruction { [NullableContext(1)] get => default; } // 0x00000001892E88F0-0x00000001892E892C 
		public override string LocalName { get => default; } // 0x00000001892E88D0-0x00000001892E88F0 
		public override string Value { get => default; } // 0x00000001892E892C-0x00000001892E894C 
	
		// Constructors
		public XProcessingInstructionWrapper() {} // Dummy constructor
		[NullableContext(1)]
		public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class XContainerWrapper : XObjectWrapper // TypeDefIndex: 51878
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private List<IXmlNode> _childNodes; // 0x18
	
		// Properties
		private XContainer Container { get => default; } // 0x00000001892E7260-0x00000001892E729C 
		public override List<IXmlNode> ChildNodes { get => default; } // 0x00000001892E7034-0x00000001892E7260 
		protected virtual bool HasChildNodes { get => default; } // 0x00000001892E729C-0x00000001892E72C8 
		[Nullable(2)]
		public override IXmlNode ParentNode { [NullableContext(2)] get => default; } // 0x00000001892E72C8-0x00000001892E7320 
	
		// Constructors
		public XContainerWrapper() {} // Dummy constructor
		public XContainerWrapper(XContainer container) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		internal static IXmlNode WrapNode(XObject node) => default; // 0x00000001892E6CF8-0x00000001892E7034
		public override IXmlNode AppendChild(IXmlNode newChild) => default; // 0x00000001892E6C90-0x00000001892E6CF8
	}

	[Nullable(0)]
	[NullableContext(2)]
	internal class XObjectWrapper : IXmlNode // TypeDefIndex: 51879
	{
		// Fields
		private readonly XObject _xmlObject; // 0x10
	
		// Properties
		public object WrappedNode { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public virtual XmlNodeType NodeType { get => default; } // 0x00000001892E88B0-0x00000001892E88D0 
		public virtual string LocalName { get => default; } // 0x0000000181002730-0x0000000181002740 
		[Nullable(1)]
		public virtual List<IXmlNode> ChildNodes { [NullableContext(1)] get => default; } // 0x00000001892E8860-0x00000001892E88B0 
		[Nullable(1)]
		public virtual List<IXmlNode> Attributes { [NullableContext(1)] get => default; } // 0x00000001892E8810-0x00000001892E8860 
		public virtual IXmlNode ParentNode { get => default; } // 0x0000000181002730-0x0000000181002740 
		public virtual string Value { get => default; } // 0x0000000181002730-0x0000000181002740 
		public virtual string NamespaceUri { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public XObjectWrapper() {} // Dummy constructor
		public XObjectWrapper(XObject xmlObject) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		[NullableContext(1)]
		public virtual IXmlNode AppendChild(IXmlNode newChild) => default; // 0x00000001892E87C4-0x00000001892E8810
	}

	[Nullable(0)]
	[NullableContext(2)]
	internal class XAttributeWrapper : XObjectWrapper // TypeDefIndex: 51880
	{
		// Properties
		[Nullable(1)]
		private XAttribute Attribute { [NullableContext(1)] get => default; } // 0x00000001892E6AD4-0x00000001892E6B10 
		public override string Value { get => default; } // 0x00000001892E6BBC-0x00000001892E6BDC 
		public override string LocalName { get => default; } // 0x00000001892E6B10-0x00000001892E6B38 
		public override string NamespaceUri { get => default; } // 0x00000001892E6B38-0x00000001892E6B64 
		public override IXmlNode ParentNode { get => default; } // 0x00000001892E6B64-0x00000001892E6BBC 
	
		// Constructors
		public XAttributeWrapper() {} // Dummy constructor
		[NullableContext(1)]
		public XAttributeWrapper(XAttribute attribute) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class XElementWrapper : XContainerWrapper, IXmlElement // TypeDefIndex: 51881
	{
		// Fields
		[Nullable(new byte[2] {2, 1 })]
		private List<IXmlNode> _attributes; // 0x20
	
		// Properties
		private XElement Element { get => default; } // 0x00000001892E86EC-0x00000001892E8728 
		public override List<IXmlNode> Attributes { get => default; } // 0x00000001892E8184-0x00000001892E86EC 
		[Nullable(2)]
		public override string Value { [NullableContext(2)] get => default; } // 0x00000001892E87A0-0x00000001892E87C4 
		[Nullable(2)]
		public override string LocalName { [NullableContext(2)] get => default; } // 0x00000001892E874C-0x00000001892E8774 
		[Nullable(2)]
		public override string NamespaceUri { [NullableContext(2)] get => default; } // 0x00000001892E8774-0x00000001892E87A0 
		public bool IsEmpty { get => default; } // 0x00000001892E8728-0x00000001892E874C 
	
		// Constructors
		public XElementWrapper() {} // Dummy constructor
		public XElementWrapper(XElement element) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public void SetAttributeNode(IXmlNode attribute) {} // 0x00000001892E8104-0x00000001892E8184
		private bool HasImplicitNamespaceAttribute(string namespaceUri) => default; // 0x00000001892E7E8C-0x00000001892E8104
		public override IXmlNode AppendChild(IXmlNode newChild) => default; // 0x00000001892E7E18-0x00000001892E7E48
		public string GetPrefixOfNamespace(string namespaceUri) => default; // 0x00000001892E7E48-0x00000001892E7E8C
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class XmlNodeConverter : JsonConverter // TypeDefIndex: 51882
	{
		// Fields
		internal static readonly List<IXmlNode> EmptyChildNodes; // 0x00
		private const string TextName = "#text"; // Metadata: 0x01FD12B1
		private const string CommentName = "#comment"; // Metadata: 0x01FD12B7
		private const string CDataName = "#cdata-section"; // Metadata: 0x01FD12C0
		private const string WhitespaceName = "#whitespace"; // Metadata: 0x01FD12CF
		private const string SignificantWhitespaceName = "#significant-whitespace"; // Metadata: 0x01FD12DB
		private const string DeclarationName = "?xml"; // Metadata: 0x01FD12F3
		private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json"; // Metadata: 0x01FD12F8
	
		// Properties
		[Nullable(2)]
		public string DeserializeRootElementName { [NullableContext(2)] get; [NullableContext(2)] set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public bool WriteArrayAttribute { get; set; } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public bool OmitRootObject { get; set; } // 0x0000000183D4EF80-0x0000000183D4EF90 0x0000000183D4EFB0-0x0000000183D4EFC0
		public bool EncodeSpecialCharacters { get; set; } // 0x0000000183D4EFA0-0x0000000183D4EFB0 0x0000000183D4EFD0-0x0000000183D4EFE0
	
		// Constructors
		public XmlNodeConverter() {} // 0x000000018350B670-0x000000018350B680
		static XmlNodeConverter() {} // 0x0000000183CE2A10-0x0000000183CE2AA0
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer) {} // 0x00000001892EF200-0x00000001892EF338
		private IXmlNode WrapXml(object value) => default; // 0x00000001892EEF04-0x00000001892EEFEC
		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) {} // 0x00000001892EB864-0x00000001892EBBE4
		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) => default; // 0x00000001892ECD38-0x00000001892ECE78
		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) => default; // 0x00000001892EB210-0x00000001892EB4F0
		private bool IsArray(IXmlNode node) => default; // 0x00000001892EB4F0-0x00000001892EB6A8
		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) {} // 0x00000001892ECE78-0x00000001892ED614
		private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, List<IXmlNode> groupedNodes, string elementNames) {} // 0x00000001892EEFEC-0x00000001892EF138
		private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames) {} // 0x00000001892EF138-0x00000001892EF200
		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) {} // 0x00000001892ED614-0x00000001892EED04
		private static bool AllSameName(IXmlNode node) => default; // 0x00000001892E95E0-0x00000001892E973C
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer) => default; // 0x00000001892EC75C-0x00000001892ECD38
		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) {} // 0x00000001892EAE50-0x00000001892EB210
		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) {} // 0x00000001892EC450-0x00000001892EC75C
		private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, [Nullable(2)] string elementPrefix, [Nullable(new byte[3] {2, 1, 2 })] Dictionary<string, string> attributeNameValues) {} // 0x00000001892E9F20-0x00000001892EA374
		private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, [Nullable(2)] string attributePrefix) {} // 0x00000001892E92B0-0x00000001892E9468
		private static string ConvertTokenToXmlValue(JsonReader reader) => default; // 0x00000001892E973C-0x00000001892E9C44
		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) {} // 0x00000001892EBBE4-0x00000001892EBE70
		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) {} // 0x00000001892E9468-0x00000001892E95E0
		private bool ShouldReadInto(JsonReader reader) => default; // 0x00000001892EED04-0x00000001892EED70
		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) => default; // 0x00000001892EBE70-0x00000001892EC450
		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) {} // 0x00000001892EA4D8-0x00000001892EA7D0
		private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) {} // 0x00000001892E9C44-0x00000001892E9F20
		private IXmlElement CreateElement(string elementName, IXmlDocument document, [Nullable(2)] string elementPrefix, XmlNamespaceManager manager) => default; // 0x00000001892EA374-0x00000001892EA4D8
		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) {} // 0x00000001892EA7D0-0x00000001892EAE50
		private bool IsNamespaceAttribute(string attributeName, [NotNullWhen(true)] [Nullable(2)] out string prefix) {
			prefix = default;
			return default;
		} // 0x00000001892EB6A8-0x00000001892EB774
		private bool ValueAttributes(List<IXmlNode> c) => default; // 0x00000001892EED70-0x00000001892EEF04
		public override bool CanConvert(System.Type valueType) => default; // 0x0000000183269DE0-0x0000000183269E90
		private bool IsXObject(System.Type valueType) => default; // 0x00000001892EB774-0x00000001892EB7EC
		private bool IsXmlNode(System.Type valueType) => default; // 0x00000001892EB7EC-0x00000001892EB864
	}
}

namespace Newtonsoft.Json.Linq
{
	public enum CommentHandling // TypeDefIndex: 51815
	{
		Ignore = 0,
		Load = 1
	}

	public enum DuplicatePropertyNameHandling // TypeDefIndex: 51816
	{
		Replace = 0,
		Ignore = 1,
		Error = 2
	}

	[Nullable(0)]
	[NullableContext(1)]
	public static class Extensions // TypeDefIndex: 51817
	{
		// Extension methods
		[NullableContext(2)]
		public static U Value<U>([Nullable(1)] this IEnumerable<JToken> value) => default;
		public static U Value<T, U>(this IEnumerable<T> value)
			where T : JToken => default;
		[NullableContext(2)]
		internal static U Convert<T, U>([Nullable(1)] this T token)
			where T : JToken => default;
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class JArray : JContainer, IList<JToken> // TypeDefIndex: 51818
	{
		// Fields
		private readonly List<JToken> _values; // 0x50
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public override JTokenType Type { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		[Nullable(2)]
		public override JToken this[object key] { get => default; } // 0x00000001892CEDB4-0x00000001892CEEFC 
		public JToken this[int index] { get => default; set {} } // 0x00000001892CEEFC-0x00000001892CEF08 0x00000001892CEF08-0x00000001892CEF18
		public bool IsReadOnly { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public JArray() {} // 0x0000000182697BA0-0x0000000182697C30
		internal JArray(JArray other, [Nullable(2)] JsonCloneSettings settings) {} // 0x00000001892CED14-0x00000001892CEDB4
		public JArray(object content) {} // 0x00000001892CEC78-0x00000001892CED14
	
		// Methods
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings = null) => default; // 0x00000001892CE86C-0x00000001892CE8DC
		public static new JArray Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings) => default; // 0x00000001892CE9E0-0x00000001892CEB98
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters) {} // 0x00000001892CEBC0-0x00000001892CEC78
		[NullableContext(2)]
		internal override int IndexOfItem(JToken item) => default; // 0x00000001892CE95C-0x00000001892CE9B0
		public int IndexOf(JToken item) => default; // 0x00000001892CE9B0-0x00000001892CE9BC
		public void Insert(int index, JToken item) {} // 0x00000001892CE9BC-0x00000001892CE9E0
		public void RemoveAt(int index) {} // 0x00000001892CEB98-0x00000001892CEBAC
		public IEnumerator<JToken> GetEnumerator() => default; // 0x00000001892CE8F8-0x00000001892CE95C
		public void Add(JToken item) {} // 0x00000001892CE854-0x00000001892CE85C
		public void Clear() {} // 0x00000001892CE85C-0x00000001892CE86C
		public bool Contains(JToken item) => default; // 0x00000001892CE8DC-0x00000001892CE8F0
		public void CopyTo(JToken[] array, int arrayIndex) {} // 0x00000001892CE8F0-0x00000001892CE8F8
		public bool Remove(JToken item) => default; // 0x00000001892CEBAC-0x00000001892CEBC0
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class JConstructor : JContainer // TypeDefIndex: 51819
	{
		// Fields
		[Nullable(2)]
		private string _name; // 0x50
		private readonly List<JToken> _values; // 0x58
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		[Nullable(2)]
		public string Name { [NullableContext(2)] get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public override JTokenType Type { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
		[Nullable(2)]
		public override JToken this[object key] { get => default; } // 0x00000001892CF4C0-0x00000001892CF60C 
	
		// Constructors
		public JConstructor() {} // Dummy constructor
		internal JConstructor(JConstructor other, [Nullable(2)] JsonCloneSettings settings) {} // 0x00000001892CF408-0x00000001892CF4C0
		public JConstructor(string name) {} // 0x00000001892CF2A8-0x00000001892CF408
	
		// Methods
		[NullableContext(2)]
		internal override int IndexOfItem(JToken item) => default; // 0x00000001892CEF88-0x00000001892CEFDC
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings = null) => default; // 0x00000001892CEF18-0x00000001892CEF88
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters) {} // 0x00000001892CF1D8-0x00000001892CF2A8
		public static new JConstructor Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings) => default; // 0x00000001892CEFDC-0x00000001892CF1D8
	}

	[Nullable(0)]
	[NullableContext(1)]
	public abstract class JContainer : JToken, IList<JToken>, IBindingList, INotifyCollectionChanged // TypeDefIndex: 51820
	{
		// Fields
		[Nullable(2)]
		internal ListChangedEventHandler _listChanged; // 0x30
		[Nullable(2)]
		internal NotifyCollectionChangedEventHandler _collectionChanged; // 0x38
		[Nullable(2)]
		private object _syncRoot; // 0x40
		private bool _busy; // 0x48
	
		// Properties
		protected abstract IList<JToken> ChildrenTokens { get; }
		public override bool HasValues { get; } // 0x0000000183609800-0x0000000183609860 
		[Nullable(2)]
		public override JToken First { [NullableContext(2)] get; } // 0x0000000183C79F60-0x0000000183C79FF0 
		[Nullable(2)]
		public override JToken Last { [NullableContext(2)] get; } // 0x0000000182698290-0x0000000182698320 
		JToken IList<Newtonsoft.Json.Linq.JToken>.this[int index] { get => default; set {} } // 0x00000001892CEEFC-0x00000001892CEF08 0x00000001892CEF08-0x00000001892CEF18
		bool ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get; } // 0x000000018115F4C0-0x000000018115F530 
		bool IList.IsFixedSize { get; } // 0x000000018115F4C0-0x000000018115F530 
		bool IList.IsReadOnly { get; } // 0x000000018115F4C0-0x000000018115F530 
		[Nullable(2)]
		object IList.this[int index] { [NullableContext(2)] get => default; [NullableContext(2)] set {} } // 0x00000001892CEEFC-0x00000001892CEF08 0x00000001892D0654-0x00000001892D068C
		public int Count { get; } // 0x00000001892D091C-0x00000001892D0970 
		bool ICollection.IsSynchronized { get; } // 0x000000018115F4C0-0x000000018115F530 
		object ICollection.SyncRoot { get; } // 0x00000001892D050C-0x00000001892D056C 
	
		// Events
		[Nullable(2)]
		public event NotifyCollectionChangedEventHandler CollectionChanged;
	
		// Constructors
		internal JContainer() {} // 0x0000000182699D40-0x0000000182699D80
		internal JContainer(JContainer other, [Nullable(2)] JsonCloneSettings settings) {} // 0x00000001892D068C-0x00000001892D0890
	
		// Methods
		internal void CheckReentrancy() {} // 0x0000000182698B10-0x0000000182698B30
		protected virtual void OnListChanged(ListChangedEventArgs e) {} // 0x00000001892D0118-0x00000001892D01B4
		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) {} // 0x00000001892D007C-0x00000001892D0118
		public override JEnumerable<JToken> Children() => default; // 0x00000001892CF60C-0x00000001892CF664
		[NullableContext(2)]
		internal bool IsMultiContent([NotNullWhen(true)] object content) => default; // 0x0000000182699C20-0x0000000182699CB0
		internal JToken EnsureParentToken([Nullable(2)] JToken item, bool skipParentCheck, bool copyAnnotations) => default; // 0x0000000182698A70-0x0000000182698B10
		[NullableContext(2)]
		internal abstract int IndexOfItem(JToken item);
		[NullableContext(2)]
		internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) => default; // 0x00000001826988B0-0x0000000182698A70
		internal virtual void RemoveItemAt(int index) {} // 0x00000001892D01B4-0x00000001892D0490
		[NullableContext(2)]
		internal virtual bool RemoveItem(JToken item) => default; // 0x00000001892D0490-0x00000001892D04CC
		internal virtual JToken GetItem(int index) => default; // 0x00000001892D001C-0x00000001892D007C
		[NullableContext(2)]
		internal virtual void SetItem(int index, JToken item) {} // 0x00000001837AE600-0x00000001837AE830
		internal virtual void ClearItems() {} // 0x00000001892CF664-0x00000001892CFBC8
		internal virtual void ReplaceItem(JToken existing, JToken replacement) {} // 0x00000001892D04CC-0x00000001892D050C
		[NullableContext(2)]
		internal virtual bool ContainsItem(JToken item) => default; // 0x00000001892CFBC8-0x00000001892CFBE4
		internal virtual void CopyItemsTo(Array array, int arrayIndex) {} // 0x00000001892CFBE4-0x00000001892CFF80
		internal static bool IsTokenUnchanged(JToken currentValue, [Nullable(2)] JToken newValue) => default; // 0x00000001837AE960-0x00000001837AE9C0
		internal virtual void ValidateToken(JToken o, [Nullable(2)] JToken existing) {} // 0x0000000183603760-0x00000001836037D0
		[NullableContext(2)]
		public virtual void Add(object content) {} // 0x0000000182699010-0x0000000182699090
		[NullableContext(2)]
		internal bool TryAdd(object content) => default; // 0x0000000182698130-0x00000001826981B0
		internal void AddAndSkipParentCheck(JToken token) {} // 0x0000000182697D70-0x0000000182697DF0
		[NullableContext(2)]
		internal bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations) => default; // 0x0000000182699090-0x0000000182699BC0
		internal static JToken CreateFromContent([Nullable(2)] object content) => default; // 0x0000000182699BC0-0x0000000182699C20
		public void RemoveAll() {} // 0x00000001892CE85C-0x00000001892CE86C
		internal void ReadTokenFrom(JsonReader reader, [Nullable(2)] JsonLoadSettings options) {} // 0x00000001838C3470-0x00000001838C3500
		internal void ReadContentFrom(JsonReader r, [Nullable(2)] JsonLoadSettings settings) {} // 0x00000001826985D0-0x00000001826988B0
		[NullableContext(2)]
		private static JProperty ReadProperty([Nullable(1)] JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, [Nullable(1)] JContainer parent) => default; // 0x0000000182698390-0x00000001826984E0
		int IList<JToken>.IndexOf(JToken item) => default; // 0x00000001892CE9B0-0x00000001892CE9BC
		void IList<JToken>.Insert(int index, JToken item) {} // 0x00000001892CE9BC-0x00000001892CE9E0
		void IList<JToken>.RemoveAt(int index) {} // 0x00000001892CEB98-0x00000001892CEBAC
		void ICollection<JToken>.Add(JToken item) {} // 0x00000001892CE854-0x00000001892CE85C
		void ICollection<JToken>.Clear() {} // 0x00000001892CE85C-0x00000001892CE86C
		bool ICollection<JToken>.Contains(JToken item) => default; // 0x00000001892CE8DC-0x00000001892CE8F0
		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex) {} // 0x00000001892CE8F0-0x00000001892CE8F8
		bool ICollection<JToken>.Remove(JToken item) => default; // 0x00000001892CEBAC-0x00000001892CEBC0
		[NullableContext(2)]
		private JToken EnsureValue(object value) => default; // 0x00000001892CFF80-0x00000001892D001C
		[NullableContext(2)]
		int IList.Add(object value) => default; // 0x00000001892D056C-0x00000001892D05A0
		void IList.Clear() {} // 0x00000001892CE85C-0x00000001892CE86C
		[NullableContext(2)]
		bool IList.Contains(object value) => default; // 0x00000001892D05A0-0x00000001892D05C8
		[NullableContext(2)]
		int IList.IndexOf(object value) => default; // 0x00000001892D05C8-0x00000001892D05EC
		[NullableContext(2)]
		void IList.Insert(int index, object value) {} // 0x00000001892D05EC-0x00000001892D062C
		[NullableContext(2)]
		void IList.Remove(object value) {} // 0x00000001892D062C-0x00000001892D0654
		void IList.RemoveAt(int index) {} // 0x00000001892CEB98-0x00000001892CEBAC
		void ICollection.CopyTo(Array array, int index) {} // 0x00000001892CE8F0-0x00000001892CE8F8
	}

	[DefaultMember("Item")]
	[IsReadOnly]
	[Nullable(0)]
	[NullableContext(1)]
	public struct JEnumerable<T> : IEnumerable<T>, IEquatable<JEnumerable<T>> // TypeDefIndex: 51821
		where T : JToken
	{
		// Fields
		[Nullable(new byte[2] {0, 1 })]
		public static readonly JEnumerable<T> Empty;
		private readonly IEnumerable<T> _enumerable;
	
		// Constructors
		public JEnumerable(IEnumerable<T> enumerable) {
			_enumerable = default;
		}
		static JEnumerable() {
			Empty = default;
		}
	
		// Methods
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public bool Equals([Nullable(new byte[2] {0, 1 })] JEnumerable<T> other) => default;
		[NullableContext(2)]
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class JObject : JContainer, IDictionary<string, JToken>, INotifyPropertyChanged, ICustomTypeDescriptor // TypeDefIndex: 51825
	{
		// Fields
		private readonly JPropertyKeyedCollection _properties; // 0x50
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public override JTokenType Type { get => default; } // 0x0000000181168950-0x0000000181168960 
		[Nullable(2)]
		public override JToken this[object key] { get => default; } // 0x00000001832F7BD0-0x00000001832F7C40 
		[Nullable(2)]
		public JToken this[string propertyName] { get => default; set {} } // 0x00000001832F7C40-0x00000001832F7CB0 0x00000001837AE510-0x00000001837AE5A0
		ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys { get => default; } // 0x00000001892D145C-0x00000001892D147C 
		[Nullable(new byte[2] {1, 2 })]
		ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get => default; } // 0x00000001892D147C-0x00000001892D14C8 
		bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Events
		[Nullable(2)]
		public event PropertyChangedEventHandler PropertyChanged;
	
		// Nested types
		[Nullable(new byte[2] {0, 1 })]
		private class JObjectDynamicProxy : DynamicProxy<JObject> // TypeDefIndex: 51823
		{
			// Constructors
			public JObjectDynamicProxy() {} // 0x00000001892D0C14-0x00000001892D0C3C
	
			// Methods
			public override bool TryGetMember(JObject instance, GetMemberBinder binder, [Nullable(2)] out object result) {
				result = default;
				return default;
			} // 0x00000001892D0B1C-0x00000001892D0B5C
			public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value) => default; // 0x00000001892D0B5C-0x00000001892D0C14
			public override IEnumerable<string> GetDynamicMemberNames(JObject instance) => default; // 0x00000001892D09FC-0x00000001892D0B1C
		}
	
		// Constructors
		public JObject() {} // 0x0000000182697DF0-0x0000000182697E60
		internal JObject(JObject other, [Nullable(2)] JsonCloneSettings settings) {} // 0x00000001892D1944-0x00000001892D19D4
	
		// Methods
		[NullableContext(2)]
		internal override int IndexOfItem(JToken item) => default; // 0x00000001892D0EA0-0x00000001892D0ECC
		[NullableContext(2)]
		internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) => default; // 0x00000001826984E0-0x0000000182698560
		internal override void ValidateToken(JToken o, [Nullable(2)] JToken existing) {} // 0x0000000182698B30-0x0000000182698C10
		internal void InternalPropertyChanged(JProperty childProperty) {} // 0x00000001837AE9C0-0x00000001837AEA50
		internal void InternalPropertyChanging(JProperty childProperty) {} // 0x00000001837AE8F0-0x00000001837AE910
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings) => default; // 0x00000001892D0C3C-0x00000001892D0CAC
		public IEnumerable<JProperty> Properties() => default; // 0x00000001892D0ECC-0x00000001892D0F08
		public JProperty Property(string name, StringComparison comparison) => default; // 0x0000000182698C10-0x0000000182698CF0
		public static new JObject Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings) => default; // 0x00000001838C3370-0x00000001838C3470
		public static new JObject Parse(string json) => default; // 0x0000000184276080-0x000000018427608C
		public static new JObject Parse(string json, [Nullable(2)] JsonLoadSettings settings) => default; // 0x00000001838C3210-0x00000001838C3370
		public static new JObject FromObject(object o) => default; // 0x0000000182694400-0x0000000182694430
		public static JObject FromObject(object o, JsonSerializer jsonSerializer) => default; // 0x0000000182693920-0x00000001826939C0
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters) {} // 0x00000001826981B0-0x0000000182698290
		[NullableContext(2)]
		public JToken GetValue(string propertyName) => default; // 0x00000001892D0E90-0x00000001892D0EA0
		[NullableContext(2)]
		public JToken GetValue(string propertyName, StringComparison comparison) => default; // 0x00000001892D0E64-0x00000001892D0E90
		public void Add(string propertyName, [Nullable(2)] JToken value) {} // 0x00000001837AEAA0-0x00000001837AEB30
		public bool ContainsKey(string propertyName) => default; // 0x00000001892D0CAC-0x00000001892D0D4C
		public bool Remove(string propertyName) => default; // 0x0000000182697CF0-0x0000000182697D10
		public bool TryGetValue(string propertyName, [NotNullWhen(true)] [Nullable(2)] out JToken value) {
			value = default;
			return default;
		} // 0x0000000182697340-0x0000000182697390
		void ICollection<KeyValuePair<string, JToken>>.Add([Nullable(new byte[3] {0, 1, 2 })] KeyValuePair<string, JToken> item) {} // 0x00000001892D0F08-0x00000001892D0F9C
		void ICollection<KeyValuePair<string, JToken>>.Clear() {} // 0x00000001892CE85C-0x00000001892CE86C
		bool ICollection<KeyValuePair<string, JToken>>.Contains([Nullable(new byte[3] {0, 1, 2 })] KeyValuePair<string, JToken> item) => default; // 0x00000001892D0F9C-0x00000001892D1008
		void ICollection<KeyValuePair<string, JToken>>.CopyTo([Nullable(new byte[4] {1, 0, 1, 2 })] KeyValuePair<string, JToken>[] array, int arrayIndex) {} // 0x00000001892D1008-0x00000001892D13D4
		bool ICollection<KeyValuePair<string, JToken>>.Remove([Nullable(new byte[3] {0, 1, 2 })] KeyValuePair<string, JToken> item) => default; // 0x00000001892D13D4-0x00000001892D145C
		[IteratorStateMachine(typeof(_GetEnumerator_d__64))]
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator() => default; // 0x00000001892D0D4C-0x00000001892D0DA8
		protected virtual void OnPropertyChanged(string propertyName) {} // 0x00000001837AEA50-0x00000001837AEAA0
		protected virtual void OnPropertyChanging(string propertyName) {} // 0x00000001837AE910-0x00000001837AE960
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties() => default; // 0x00000001892D18EC-0x00000001892D18F4
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties([Nullable(new byte[2] {2, 1 })] Attribute[] attributes) => default; // 0x00000001892D1554-0x00000001892D18EC
		AttributeCollection ICustomTypeDescriptor.GetAttributes() => default; // 0x00000001892D14C8-0x00000001892D1518
		TypeConverter ICustomTypeDescriptor.GetConverter() => default; // 0x00000001892D1518-0x00000001892D1554
		[NullableContext(2)]
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) => default; // 0x00000001892D18F4-0x00000001892D1944
		protected override DynamicMetaObject GetMetaObject(Expression parameter) => default; // 0x00000001892D0DA8-0x00000001892D0E64
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class JProperty : JContainer // TypeDefIndex: 51828
	{
		// Fields
		private readonly JPropertyList _content; // 0x50
		private readonly string _name; // 0x58
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public string Name { [DebuggerStepThrough] get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		public JToken Value { [DebuggerStepThrough] get => default; set {} } // 0x00000001842711AC-0x00000001842711C8 0x00000001837AE5A0-0x00000001837AE600
		public override JTokenType Type { [DebuggerStepThrough] get => default; } // 0x0000000183D50CD0-0x0000000183D50CE0 
	
		// Nested types
		[Nullable(0)]
		private class JPropertyList : IList<JToken> // TypeDefIndex: 51827
		{
			// Fields
			[Nullable(2)]
			internal JToken _token; // 0x10
	
			// Properties
			public int Count { get => default; } // 0x0000000183676D20-0x0000000183676D30 
			public bool IsReadOnly { get => default; } // 0x000000018115F4C0-0x000000018115F530 
			public JToken this[int index] { get => default; set {} } // 0x0000000183B5B050-0x0000000183B5B070 0x0000000183D4B920-0x0000000183D4B940
	
			// Constructors
			public JPropertyList() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			[IteratorStateMachine(typeof(_GetEnumerator_d__1))]
			public IEnumerator<JToken> GetEnumerator() => default; // 0x00000001892D218C-0x00000001892D21E8
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001892D2238-0x00000001892D2240
			public void Add(JToken item) {} // 0x000000018426FEE0-0x000000018426FEF0
			public void Clear() {} // 0x00000001835ACAA0-0x00000001835ACAC0
			public bool Contains(JToken item) => default; // 0x00000001892D211C-0x00000001892D2124
			public void CopyTo(JToken[] array, int arrayIndex) {} // 0x00000001892D2124-0x00000001892D218C
			public bool Remove(JToken item) => default; // 0x00000001892D2210-0x00000001892D2238
			public int IndexOf(JToken item) => default; // 0x00000001892D21E8-0x00000001892D21F8
			public void Insert(int index, JToken item) {} // 0x000000018381BD20-0x000000018381BE50
			public void RemoveAt(int index) {} // 0x00000001892D21F8-0x00000001892D2210
		}
	
		// Constructors
		public JProperty() {} // Dummy constructor
		internal JProperty(JProperty other, [Nullable(2)] JsonCloneSettings settings) {} // 0x00000001892D2794-0x00000001892D2824
		internal JProperty(string name) {} // 0x0000000182699CB0-0x0000000182699D40
		public JProperty(string name, [Nullable(2)] object content) {} // 0x00000001837AE440-0x00000001837AE510
	
		// Methods
		internal override JToken GetItem(int index) => default; // 0x00000001892D238C-0x00000001892D23E8
		[NullableContext(2)]
		internal override void SetItem(int index, JToken item) {} // 0x00000001837AE830-0x00000001837AE8F0
		[NullableContext(2)]
		internal override bool RemoveItem(JToken item) => default; // 0x00000001892D26D4-0x00000001892D2794
		internal override void RemoveItemAt(int index) {} // 0x00000001892D2614-0x00000001892D26D4
		[NullableContext(2)]
		internal override int IndexOfItem(JToken item) => default; // 0x00000001892D23E8-0x00000001892D2418
		[NullableContext(2)]
		internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) => default; // 0x0000000182698560-0x00000001826985D0
		[NullableContext(2)]
		internal override bool ContainsItem(JToken item) => default; // 0x00000001892D2370-0x00000001892D238C
		internal override void ClearItems() {} // 0x00000001892D2240-0x00000001892D2300
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings) => default; // 0x00000001892D2300-0x00000001892D2370
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters) {} // 0x0000000182698320-0x0000000182698390
		public static new JProperty Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings) => default; // 0x00000001892D2418-0x00000001892D2614
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class JPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 51829
	{
		// Properties
		public override System.Type ComponentType { get => default; } // 0x00000001892D1C48-0x00000001892D1C98 
		public override bool IsReadOnly { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override System.Type PropertyType { get => default; } // 0x00000001892D1C98-0x00000001892D1CE8 
		protected override int NameHashCode { get => default; } // 0x0000000181003B50-0x0000000181003B60 
	
		// Constructors
		public JPropertyDescriptor() {} // Dummy constructor
		public JPropertyDescriptor(string name) {} // 0x00000001892D1C3C-0x00000001892D1C48
	
		// Methods
		public override bool CanResetValue(object component) => default; // 0x000000018115F4C0-0x000000018115F530
		[NullableContext(2)]
		public override object GetValue(object component) => default; // 0x00000001892D1AFC-0x00000001892D1B64
		public override void ResetValue(object component) {} // 0x000000018350B670-0x000000018350B680
		[NullableContext(2)]
		public override void SetValue(object component, object value) {} // 0x00000001892D1B64-0x00000001892D1C3C
		public override bool ShouldSerializeValue(object component) => default; // 0x000000018115F4C0-0x000000018115F530
	}

	[DefaultMember("Item")]
	[Nullable(new byte[2] {0, 1 })]
	[NullableContext(1)]
	internal class JPropertyKeyedCollection : Collection<JToken> // TypeDefIndex: 51830
	{
		// Fields
		private static readonly IEqualityComparer<string> Comparer; // 0x00
		[Nullable(new byte[3] {2, 1, 1 })]
		private Dictionary<string, JToken> _dictionary; // 0x18
	
		// Properties
		public ICollection<string> Keys { get => default; } // 0x00000001892D20CC-0x00000001892D211C 
	
		// Constructors
		public JPropertyKeyedCollection() {} // 0x0000000182697E60-0x0000000182697EF0
		static JPropertyKeyedCollection() {} // 0x0000000183D05430-0x0000000183D054A0
	
		// Methods
		private void AddKey(string key, JToken item) {} // 0x00000001834B7D50-0x00000001834B7DC0
		protected override void ClearItems() {} // 0x00000001892D1CE8-0x00000001892D1D44
		public bool Contains(string key) => default; // 0x00000001892D1D44-0x00000001892D1DF4
		private void EnsureDictionary() {} // 0x00000001834B7DC0-0x00000001834B7E90
		private string GetKeyForItem(JToken item) => default; // 0x00000001834B7CF0-0x00000001834B7D50
		protected override void InsertItem(int index, JToken item) {} // 0x00000001834B7C70-0x00000001834B7CF0
		protected override void RemoveItem(int index) {} // 0x00000001892D1E74-0x00000001892D1F0C
		private void RemoveKey(string key) {} // 0x00000001892D1F0C-0x00000001892D1F5C
		protected override void SetItem(int index, JToken item) {} // 0x00000001892D1F5C-0x00000001892D20CC
		public bool TryGetValue(string key, [Nullable(2)] [NotNullWhen(true)] out JToken value) {
			value = default;
			return default;
		} // 0x0000000182698CF0-0x0000000182698D70
		public int IndexOfReference(JToken t) => default; // 0x00000001892D1DF4-0x00000001892D1E74
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class JRaw : JValue // TypeDefIndex: 51831
	{
		// Constructors
		public JRaw() {} // Dummy constructor
		internal JRaw(JRaw other, [Nullable(2)] JsonCloneSettings settings) {} // 0x00000001892D2BD4-0x00000001892D2BDC
		[NullableContext(2)]
		public JRaw(object rawJson) {} // 0x00000001892D2BC4-0x00000001892D2BD4
	
		// Methods
		public static JRaw Create(JsonReader reader) => default; // 0x00000001892D2894-0x00000001892D2BC4
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings) => default; // 0x00000001892D2824-0x00000001892D2894
	}

	public class JsonCloneSettings // TypeDefIndex: 51832
	{
		// Fields
		[Nullable(1)]
		internal static readonly JsonCloneSettings SkipCopyAnnotations; // 0x00
	
		// Properties
		public bool CopyAnnotations { get; set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
	
		// Constructors
		public JsonCloneSettings() {} // 0x0000000181168960-0x0000000181168970
		static JsonCloneSettings() {} // 0x00000001892DBBF8-0x00000001892DBC60
	}

	public class JsonLoadSettings // TypeDefIndex: 51833
	{
		// Fields
		private CommentHandling _commentHandling; // 0x10
		private LineInfoHandling _lineInfoHandling; // 0x14
		private DuplicatePropertyNameHandling _duplicatePropertyNameHandling; // 0x18
	
		// Properties
		public CommentHandling CommentHandling { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
		public LineInfoHandling LineInfoHandling { get => default; } // 0x0000000183D50CC0-0x0000000183D50CD0 
		public DuplicatePropertyNameHandling DuplicatePropertyNameHandling { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
	
		// Constructors
		public JsonLoadSettings() {} // Dummy constructor
	}

	[Nullable(0)]
	[NullableContext(1)]
	public abstract class JToken : IEnumerable<JToken>, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider // TypeDefIndex: 51835
	{
		// Fields
		[Nullable(2)]
		private JContainer _parent; // 0x10
		[Nullable(2)]
		private JToken _previous; // 0x18
		[Nullable(2)]
		private JToken _next; // 0x20
		[Nullable(2)]
		private object _annotations; // 0x28
		private static readonly JTokenType[] BooleanTypes; // 0x00
		private static readonly JTokenType[] NumberTypes; // 0x08
		private static readonly JTokenType[] BigIntegerTypes; // 0x10
		private static readonly JTokenType[] StringTypes; // 0x18
		private static readonly JTokenType[] GuidTypes; // 0x20
		private static readonly JTokenType[] TimeSpanTypes; // 0x28
		private static readonly JTokenType[] UriTypes; // 0x30
		private static readonly JTokenType[] CharTypes; // 0x38
		private static readonly JTokenType[] DateTimeTypes; // 0x40
		private static readonly JTokenType[] BytesTypes; // 0x48
	
		// Properties
		[Nullable(2)]
		public JContainer Parent { [DebuggerStepThrough] [NullableContext(2)] get; [NullableContext(2)] internal set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public JToken Root { get; } // 0x0000000183D2ACF0-0x0000000183D2AD10 
		public abstract JTokenType Type { get; }
		public abstract bool HasValues { get; }
		[Nullable(2)]
		public JToken Next { [NullableContext(2)] get; [NullableContext(2)] internal set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		[Nullable(2)]
		public JToken Previous { [NullableContext(2)] get; [NullableContext(2)] internal set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public string Path { get; } // 0x00000001892D4BFC-0x00000001892D4E24 
		[Nullable(2)]
		public virtual JToken this[object key] { get => default; } // 0x00000001892D4ABC-0x00000001892D4B5C 
		[Nullable(2)]
		public virtual JToken First { [NullableContext(2)] get; } // 0x00000001892D4A1C-0x00000001892D4ABC 
		[Nullable(2)]
		public virtual JToken Last { [NullableContext(2)] get; } // 0x00000001892D4B5C-0x00000001892D4BFC 
		int IJsonLineInfo.LineNumber { get; } // 0x00000001892D3E74-0x00000001892D3EB8 
		int IJsonLineInfo.LinePosition { get; } // 0x00000001892D3EB8-0x00000001892D3EFC 
	
		// Nested types
		[NullableContext(0)]
		private class LineInfoAnnotation // TypeDefIndex: 51834
		{
			// Fields
			internal readonly int LineNumber; // 0x10
			internal readonly int LinePosition; // 0x14
	
			// Constructors
			public LineInfoAnnotation() {} // Dummy constructor
			public LineInfoAnnotation(int lineNumber, int linePosition) {} // 0x0000000183D50CB0-0x0000000183D50CC0
		}
	
		// Constructors
		internal JToken() {} // 0x000000018350B670-0x000000018350B680
		static JToken() {} // 0x00000001825634E0-0x00000001825638A0
	
		// Methods
		internal abstract JToken CloneToken([Nullable(2)] JsonCloneSettings settings);
		public virtual JEnumerable<JToken> Children() => default; // 0x00000001892D39BC-0x00000001892D3A0C
		public void Remove() {} // 0x00000001892D4470-0x00000001892D44EC
		public void Replace(JToken value) {} // 0x00000001892D44EC-0x00000001892D4564
		public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);
		public override string ToString() => default; // 0x0000000182697410-0x0000000182697460
		public string ToString(Newtonsoft.Json.Formatting formatting, params JsonConverter[] converters) => default; // 0x0000000182697460-0x0000000182697660
		private static JValue EnsureValue(JToken value) => default; // 0x00000001892D3B04-0x00000001892D3BC4
		private static string GetType(JToken token) => default; // 0x00000001892D3CDC-0x00000001892D3DD8
		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) => default; // 0x00000001892D4978-0x00000001892D4A1C
		public static explicit operator bool(JToken value) => default; // 0x00000001892D6CCC-0x00000001892D6EB0
		public static explicit operator DateTimeOffset(JToken value) => default; // 0x00000001892D5E40-0x00000001892D607C
		[NullableContext(2)]
		public static explicit operator bool?(JToken value) => default; // 0x00000001892D81AC-0x00000001892D83CC
		public static explicit operator long(JToken value) => default; // 0x00000001892D8B80-0x00000001892D8D50
		[NullableContext(2)]
		public static explicit operator System.DateTime?(JToken value) => default; // 0x00000001892D7D50-0x00000001892D7F6C
		[NullableContext(2)]
		public static explicit operator DateTimeOffset?(JToken value) => default; // 0x00000001892D5BA8-0x00000001892D5E40
		[NullableContext(2)]
		public static explicit operator decimal?(JToken value) => default; // 0x00000001892D78E4-0x00000001892D7B44
		[NullableContext(2)]
		public static explicit operator double?(JToken value) => default; // 0x00000001892D9304-0x00000001892D9528
		[NullableContext(2)]
		public static explicit operator char?(JToken value) => default; // 0x00000001892D624C-0x00000001892D6454
		public static explicit operator int(JToken value) => default; // 0x00000001892D6868-0x00000001892D6A38
		public static explicit operator short(JToken value) => default; // 0x00000001892D70FC-0x00000001892D72CC
		[CLSCompliant(false)]
		public static explicit operator ushort(JToken value) => default; // 0x00000001892D83CC-0x00000001892D859C
		[CLSCompliant(false)]
		public static explicit operator char(JToken value) => default; // 0x00000001892D859C-0x00000001892D876C
		public static explicit operator byte(JToken value) => default; // 0x00000001892D9528-0x00000001892D96F8
		[CLSCompliant(false)]
		public static explicit operator sbyte(JToken value) => default; // 0x00000001892D74F0-0x00000001892D76C0
		[NullableContext(2)]
		public static explicit operator int?(JToken value) => default; // 0x00000001892D7B44-0x00000001892D7D50
		[NullableContext(2)]
		public static explicit operator short?(JToken value) => default; // 0x00000001892D6454-0x00000001892D665C
		[CLSCompliant(false)]
		[NullableContext(2)]
		public static explicit operator ushort?(JToken value) => default; // 0x00000001892D876C-0x00000001892D8974
		[NullableContext(2)]
		public static explicit operator byte?(JToken value) => default; // 0x00000001892D55C4-0x00000001892D57D0
		[CLSCompliant(false)]
		[NullableContext(2)]
		public static explicit operator sbyte?(JToken value) => default; // 0x00000001892D8974-0x00000001892D8B80
		public static explicit operator System.DateTime(JToken value) => default; // 0x00000001892D59E4-0x00000001892D5BA8
		[NullableContext(2)]
		public static explicit operator long?(JToken value) => default; // 0x00000001892D76C0-0x00000001892D78E4
		[NullableContext(2)]
		public static explicit operator float?(JToken value) => default; // 0x00000001892D51E8-0x00000001892D53F4
		public static explicit operator decimal(JToken value) => default; // 0x00000001892D4FF4-0x00000001892D51E8
		[CLSCompliant(false)]
		[NullableContext(2)]
		public static explicit operator uint?(JToken value) => default; // 0x00000001892D665C-0x00000001892D6868
		[CLSCompliant(false)]
		[NullableContext(2)]
		public static explicit operator ulong?(JToken value) => default; // 0x00000001892D72CC-0x00000001892D74F0
		public static explicit operator double(JToken value) => default; // 0x00000001892D8F6C-0x00000001892D913C
		public static explicit operator float(JToken value) => default; // 0x00000001892D607C-0x00000001892D624C
		[NullableContext(2)]
		public static explicit operator string(JToken value) => default; // 0x00000001892D7F6C-0x00000001892D81AC
		[CLSCompliant(false)]
		public static explicit operator uint(JToken value) => default; // 0x00000001892D53F4-0x00000001892D55C4
		[CLSCompliant(false)]
		public static explicit operator ulong(JToken value) => default; // 0x00000001892D4E24-0x00000001892D4FF4
		public static explicit operator Guid(JToken value) => default; // 0x00000001892D57D0-0x00000001892D59E4
		[NullableContext(2)]
		public static explicit operator Guid?(JToken value) => default; // 0x00000001892D6A38-0x00000001892D6CCC
		public static explicit operator TimeSpan(JToken value) => default; // 0x00000001892D913C-0x00000001892D9304
		[NullableContext(2)]
		public static explicit operator TimeSpan?(JToken value) => default; // 0x00000001892D8D50-0x00000001892D8F6C
		[NullableContext(2)]
		public static explicit operator System.Uri(JToken value) => default; // 0x00000001892D6EB0-0x00000001892D70FC
		private static BigInteger ToBigInteger(JToken value) => default; // 0x00000001892D480C-0x00000001892D4978
		private static BigInteger? ToBigIntegerNullable(JToken value) => default; // 0x00000001892D4640-0x00000001892D480C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001892D45C8-0x00000001892D4604
		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator() => default; // 0x00000001892D4564-0x00000001892D45C8
		public JsonReader CreateReader() => default; // 0x00000001892D3A98-0x00000001892D3AF8
		internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer) => default; // 0x0000000182692F80-0x0000000182693190
		public static JToken FromObject(object o) => default; // 0x00000001892D3BC4-0x00000001892D3C1C
		[NullableContext(2)]
		public T ToObject<T>() => default;
		public object ToObject(System.Type objectType) => default; // 0x0000000183973740-0x00000001839739E0
		[NullableContext(2)]
		public object ToObject(System.Type objectType, [Nullable(1)] JsonSerializer jsonSerializer) => default; // 0x00000001839739E0-0x0000000183973EF0
		public static JToken ReadFrom(JsonReader reader) => default; // 0x00000001892D4424-0x00000001892D4470
		public static JToken ReadFrom(JsonReader reader, [Nullable(2)] JsonLoadSettings settings) => default; // 0x00000001892D40D0-0x00000001892D4424
		public static JToken Parse(string json) => default; // 0x00000001892D4084-0x00000001892D40D0
		public static JToken Parse(string json, [Nullable(2)] JsonLoadSettings settings) => default; // 0x00000001892D3EFC-0x00000001892D4084
		public static JToken Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings) => default; // 0x00000001892D3DD8-0x00000001892D3E34
		[NullableContext(2)]
		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) {} // 0x0000000182698D70-0x0000000182698E90
		internal void SetLineInfo(int lineNumber, int linePosition) {} // 0x0000000182698F00-0x0000000182698F70
		bool IJsonLineInfo.HasLineInfo() => default; // 0x00000001892D3E34-0x00000001892D3E74
		protected virtual DynamicMetaObject GetMetaObject(Expression parameter) => default; // 0x00000001892D3C1C-0x00000001892D3CDC
		DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) => default; // 0x00000001892D4604-0x00000001892D4640
		object ICloneable.Clone() => default; // 0x00000001892D3AF8-0x00000001892D3B04
		public JToken DeepClone() => default; // 0x00000001892D3AF8-0x00000001892D3B04
		public void AddAnnotation(object annotation) {} // 0x0000000182698F70-0x0000000182699010
		public T Annotation<T>()
			where T : class => default;
		internal void CopyAnnotations(JToken target, JToken source) {} // 0x00000001892D3A0C-0x00000001892D3A98
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class JTokenReader : JsonReader, IJsonLineInfo // TypeDefIndex: 51836
	{
		// Fields
		private readonly JToken _root; // 0x78
		[Nullable(2)]
		private string _initialPath; // 0x80
		[Nullable(2)]
		private JToken _parent; // 0x88
		[Nullable(2)]
		private JToken _current; // 0x90
	
		// Properties
		[Nullable(2)]
		public JToken CurrentToken { [NullableContext(2)] get => default; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
		int IJsonLineInfo.LineNumber { get => default; } // 0x00000001892D2C04-0x00000001892D2C2C 
		int IJsonLineInfo.LinePosition { get => default; } // 0x00000001892D2C2C-0x00000001892D2C54 
		public override string Path { get => default; } // 0x00000001892D2CA4-0x00000001892D2D84 
	
		// Constructors
		public JTokenReader() {} // Dummy constructor
		public JTokenReader(JToken token) {} // 0x0000000183973EF0-0x0000000183973F50
	
		// Methods
		public override bool Read() => default; // 0x00000001836E2930-0x00000001836E2A00
		private bool ReadOver(JToken t) => default; // 0x00000001836E2C70-0x00000001836E2D30
		private bool ReadToEnd() => default; // 0x00000001892D2C54-0x00000001892D2C88
		private JsonToken? GetEndToken(JContainer c) => default; // 0x00000001836E2DD0-0x00000001836E2E50
		private bool ReadInto(JContainer c) => default; // 0x00000001836E2A00-0x00000001836E2A80
		private bool SetEnd(JContainer c) => default; // 0x00000001836E2D30-0x00000001836E2DD0
		private void SetToken(JToken token) {} // 0x00000001836E2A80-0x00000001836E2C70
		[NullableContext(2)]
		private string SafeToString(object value) => default; // 0x00000001892D2C88-0x00000001892D2CA4
		bool IJsonLineInfo.HasLineInfo() => default; // 0x00000001892D2BDC-0x00000001892D2C04
	}

	public enum JTokenType // TypeDefIndex: 51837
	{
		None = 0,
		Object = 1,
		Array = 2,
		Constructor = 3,
		Property = 4,
		Comment = 5,
		Integer = 6,
		Float = 7,
		String = 8,
		Boolean = 9,
		Null = 10,
		Undefined = 11,
		Date = 12,
		Raw = 13,
		Bytes = 14,
		Guid = 15,
		Uri = 16,
		TimeSpan = 17
	}

	[Nullable(0)]
	[NullableContext(2)]
	public class JTokenWriter : JsonWriter // TypeDefIndex: 51838
	{
		// Fields
		private JContainer _token; // 0x60
		private JContainer _parent; // 0x68
		private JValue _value; // 0x70
		private JToken _current; // 0x78
	
		// Properties
		public JToken Token { get => default; } // 0x00000001826938A0-0x00000001826938C0 
	
		// Constructors
		public JTokenWriter() {} // 0x00000001826938C0-0x0000000182693920
	
		// Methods
		public override void Close() {} // 0x00000001825EE630-0x00000001825EE640
		public override void WriteStartObject() {} // 0x0000000182697390-0x0000000182697410
		[NullableContext(1)]
		private void AddParent(JContainer container) {} // 0x0000000182697D10-0x0000000182697D70
		private void RemoveParent() {} // 0x00000001837B8D90-0x00000001837B8E10
		public override void WriteStartArray() {} // 0x0000000182697B20-0x0000000182697BA0
		[NullableContext(1)]
		public override void WriteStartConstructor(string name) {} // 0x00000001892D2F18-0x00000001892D2F9C
		protected override void WriteEnd(JsonToken token) {} // 0x00000001837B8D80-0x00000001837B8D90
		[NullableContext(1)]
		public override void WritePropertyName(string name) {} // 0x0000000182697C30-0x0000000182697CF0
		private void AddRawValue(object value, JTokenType type, JsonToken token) {} // 0x00000001892D2D84-0x00000001892D2E1C
		internal void AddJValue(JValue value, JsonToken token) {} // 0x000000018269A9B0-0x000000018269AA70
		public override void WriteValue(object value) {} // 0x00000001892D3368-0x00000001892D33EC
		public override void WriteNull() {} // 0x00000001892D2E64-0x00000001892D2E9C
		public override void WriteUndefined() {} // 0x00000001892D2F9C-0x00000001892D2FD4
		public override void WriteRaw(string json) {} // 0x00000001892D2E9C-0x00000001892D2F18
		public override void WriteComment(string text) {} // 0x00000001892D2E1C-0x00000001892D2E64
		public override void WriteValue(string value) {} // 0x000000018269A910-0x000000018269A9B0
		public override void WriteValue(int value) {} // 0x00000001892D33EC-0x00000001892D3460
		[CLSCompliant(false)]
		public override void WriteValue(uint value) {} // 0x00000001892D30BC-0x00000001892D3130
		public override void WriteValue(long value) {} // 0x000000018269AA70-0x000000018269AB10
		[CLSCompliant(false)]
		public override void WriteValue(ulong value) {} // 0x00000001892D3258-0x00000001892D32E0
		public override void WriteValue(float value) {} // 0x00000001892D31D0-0x00000001892D3258
		public override void WriteValue(double value) {} // 0x00000001892D3880-0x00000001892D3908
		public override void WriteValue(bool value) {} // 0x0000000183741100-0x00000001837411A0
		public override void WriteValue(short value) {} // 0x00000001892D372C-0x00000001892D37A4
		[CLSCompliant(false)]
		public override void WriteValue(ushort value) {} // 0x00000001892D362C-0x00000001892D36A4
		public override void WriteValue(char value) {} // 0x00000001892D37A4-0x00000001892D3880
		public override void WriteValue(byte value) {} // 0x00000001892D3048-0x00000001892D30BC
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value) {} // 0x00000001892D2FD4-0x00000001892D3048
		public override void WriteValue(decimal value) {} // 0x00000001892D3130-0x00000001892D31D0
		public override void WriteValue(System.DateTime value) {} // 0x00000001892D3908-0x00000001892D39BC
		public override void WriteValue(DateTimeOffset value) {} // 0x00000001892D358C-0x00000001892D362C
		public override void WriteValue(byte[] value) {} // 0x00000001892D3460-0x00000001892D34EC
		public override void WriteValue(TimeSpan value) {} // 0x00000001892D36A4-0x00000001892D372C
		public override void WriteValue(Guid value) {} // 0x00000001892D34EC-0x00000001892D358C
		public override void WriteValue(System.Uri value) {} // 0x00000001892D32E0-0x00000001892D3368
		[NullableContext(1)]
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) {} // 0x000000018269A1E0-0x000000018269A2C0
	}

	[Nullable(0)]
	[NullableContext(2)]
	public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible // TypeDefIndex: 51840
	{
		// Fields
		private JTokenType _valueType; // 0x30
		private object _value; // 0x38
	
		// Properties
		public override bool HasValues { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override JTokenType Type { get => default; } // 0x0000000183D4ED20-0x0000000183D4ED30 
		public object Value { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
	
		// Nested types
		[Nullable(new byte[2] {0, 1 })]
		[NullableContext(1)]
		private class JValueDynamicProxy : DynamicProxy<JValue> // TypeDefIndex: 51839
		{
			// Constructors
			public JValueDynamicProxy() {} // 0x00000001892D9B20-0x00000001892D9B48
	
			// Methods
			public override bool TryConvert(JValue instance, ConvertBinder binder, [Nullable(2)] [NotNullWhen(true)] out object result) {
				result = default;
				return default;
			} // 0x00000001892D99A4-0x00000001892D9B20
			public override bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, [NotNullWhen(true)] [Nullable(2)] out object result) {
				result = default;
				return default;
			} // 0x00000001892D96F8-0x00000001892D99A4
		}
	
		// Constructors
		public JValue() {} // Dummy constructor
		internal JValue(object value, JTokenType type) {} // 0x000000018269AB80-0x000000018269ABF0
		[NullableContext(1)]
		internal JValue(JValue other, [Nullable(2)] JsonCloneSettings settings) {} // 0x00000001892DB950-0x00000001892DBA00
		public JValue(long value) {} // 0x000000018269AB10-0x000000018269AB80
		public JValue(decimal value) {} // 0x00000001892DBB28-0x00000001892DBB94
		[CLSCompliant(false)]
		public JValue(ulong value) {} // 0x00000001892DB7D0-0x00000001892DB830
		public JValue(double value) {} // 0x00000001892DB830-0x00000001892DB890
		public JValue(float value) {} // 0x00000001892DBA00-0x00000001892DBA60
		public JValue(System.DateTime value) {} // 0x00000001892DB890-0x00000001892DB8F0
		public JValue(DateTimeOffset value) {} // 0x00000001892DBB94-0x00000001892DBBF8
		public JValue(bool value) {} // 0x00000001837411A0-0x0000000183741210
		public JValue(string value) {} // 0x00000001842711C8-0x00000001842711D8
		public JValue(Guid value) {} // 0x00000001892DBAC4-0x00000001892DBB28
		public JValue(System.Uri value) {} // 0x00000001892DBA60-0x00000001892DBAC4
		public JValue(TimeSpan value) {} // 0x00000001892DB8F0-0x00000001892DB950
		public JValue(object value) {} // 0x0000000182699D80-0x0000000182699DC0
	
		// Methods
		[NullableContext(1)]
		private static int CompareBigInteger(BigInteger i1, object i2) => default; // 0x00000001892D9BB8-0x00000001892D9DE4
		internal static int Compare(JTokenType valueType, object objA, object objB) => default; // 0x00000001892D9EF0-0x00000001892DA7EC
		[NullableContext(1)]
		private static int CompareFloat(object objA, object objB) => default; // 0x00000001892D9DE4-0x00000001892D9EBC
		private static bool Operation(ExpressionType operation, object objA, object objB, out object result) {
			result = default;
			return default;
		} // 0x00000001892DAA5C-0x00000001892DB1A4
		[NullableContext(1)]
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings) => default; // 0x00000001892D9B48-0x00000001892D9BB8
		[NullableContext(1)]
		public static JValue CreateComment([Nullable(2)] string value) => default; // 0x00000001892DA7EC-0x00000001892DA850
		[NullableContext(1)]
		public static JValue CreateNull() => default; // 0x00000001892DA850-0x00000001892DA8A8
		[NullableContext(1)]
		public static JValue CreateUndefined() => default; // 0x00000001892DA8A8-0x00000001892DA900
		private static JTokenType GetValueType(JTokenType? current, object value) => default; // 0x0000000182699DC0-0x000000018269A0A0
		private static JTokenType GetStringValueType(JTokenType? current) => default; // 0x00000001838BA8D0-0x00000001838BA920
		[NullableContext(1)]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters) {} // 0x0000000182697EF0-0x0000000182698130
		[NullableContext(1)]
		private static bool ValuesEquals(JValue v1, JValue v2) => default; // 0x00000001892DB788-0x00000001892DB7D0
		public bool Equals(JValue other) => default; // 0x00000001892DA95C-0x00000001892DA978
		public override bool Equals(object obj) => default; // 0x00000001892DA900-0x00000001892DA95C
		public override int GetHashCode() => default; // 0x00000001892DA978-0x00000001892DA9A0
		[NullableContext(1)]
		public override string ToString() => default; // 0x0000000183D1E910-0x0000000183D1E960
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider formatProvider) => default; // 0x00000001892DB778-0x00000001892DB788
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x00000001892DB6CC-0x00000001892DB778
		[NullableContext(1)]
		protected override DynamicMetaObject GetMetaObject(Expression parameter) => default; // 0x00000001892DA9A0-0x00000001892DAA5C
		int IComparable.CompareTo(object obj) => default; // 0x00000001892DB1A4-0x00000001892DB228
		public int CompareTo(JValue obj) => default; // 0x00000001892D9EBC-0x00000001892D9EF0
		TypeCode IConvertible.GetTypeCode() => default; // 0x00000001892DB228-0x00000001892DB288
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x00000001892DB288-0x00000001892DB2D4
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x00000001892DB320-0x00000001892DB36C
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x00000001892DB548-0x00000001892DB594
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x00000001892DB2D4-0x00000001892DB320
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x00000001892DB464-0x00000001892DB4B0
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x00000001892DB5E8-0x00000001892DB634
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x00000001892DB4B0-0x00000001892DB4FC
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x00000001892DB634-0x00000001892DB680
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x00000001892DB4FC-0x00000001892DB548
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x00000001892DB680-0x00000001892DB6CC
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x00000001892DB594-0x00000001892DB5E0
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x00000001892DB418-0x00000001892DB464
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x00000001892DB3B8-0x00000001892DB418
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x00000001892DB36C-0x00000001892DB3B8
		[NullableContext(1)]
		object IConvertible.ToType(System.Type conversionType, [Nullable(2)] IFormatProvider provider) => default; // 0x00000001892DB5E0-0x00000001892DB5E8
	}

	public enum LineInfoHandling // TypeDefIndex: 51841
	{
		Ignore = 0,
		Load = 1
	}
}

namespace Newtonsoft.Json.Serialization
{
	internal static class CachedAttributeGetter<T> // TypeDefIndex: 51749
		where T : Attribute
	{
		// Fields
		[Nullable(new byte[3] {1, 1, 2 })]
		private static readonly ThreadSafeStore<object, T> TypeAttributeCache;
	
		// Constructors
		static CachedAttributeGetter() {}
	
		// Methods
		[NullableContext(1)]
		public static T GetAttribute(object type) => default;
	}

	public class CamelCaseNamingStrategy : NamingStrategy // TypeDefIndex: 51750
	{
		// Constructors
		public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames) {} // 0x0000000183D714A0-0x0000000183D714B0
		public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) {} // 0x0000000183D71490-0x0000000183D714A0
		public CamelCaseNamingStrategy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[NullableContext(1)]
		protected override string ResolvePropertyName(string name) => default; // 0x00000001892B976C-0x00000001892B9778
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class DefaultContractResolver : IContractResolver // TypeDefIndex: 51762
	{
		// Fields
		private static readonly IContractResolver _instance; // 0x00
		private static readonly string[] BlacklistedTypeNames; // 0x08
		private static readonly JsonConverter[] BuiltInConverters; // 0x10
		private readonly DefaultJsonNameTable _nameTable; // 0x10
		private readonly ThreadSafeStore<System.Type, JsonContract> _contractCache; // 0x18
	
		// Properties
		internal static IContractResolver Instance { get => default; } // 0x00000001892BFF8C-0x00000001892BFFDC 
		[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
		public System.Reflection.BindingFlags DefaultMembersSearchFlags { get; set; } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public bool SerializeCompilerGeneratedMembers { get; } // 0x0000000183D4F090-0x0000000183D4F0A0 
		public bool IgnoreSerializableInterface { get; } // 0x0000000183D4F130-0x0000000183D4F140 
		public bool IgnoreSerializableAttribute { get; set; } // 0x0000000183D4F140-0x0000000183D4F150 0x0000000183D4F160-0x0000000183D4F170
		public bool IgnoreIsSpecifiedMembers { get; } // 0x0000000183D714B0-0x0000000183D714C0 
		public bool IgnoreShouldSerializeMembers { get; } // 0x0000000183D4ED50-0x0000000183D4ED60 
		[Nullable(2)]
		public NamingStrategy NamingStrategy { [NullableContext(2)] get; [NullableContext(2)] set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
	
		// Nested types
		[NullableContext(0)]
		internal class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>> // TypeDefIndex: 51752
		{
			// Fields
			[Nullable(new byte[4] {1, 0, 1, 1 })]
			private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;
	
			// Constructors
			public EnumerableDictionaryWrapper() {} // Dummy constructor
			public EnumerableDictionaryWrapper([Nullable(new byte[4] {1, 0, 1, 1 })] IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e) {}
	
			// Methods
			[IteratorStateMachine(typeof(_GetEnumerator_d__2))]
			public IEnumerator<KeyValuePair<object, object>> GetEnumerator() => default;
			[NullableContext(1)]
			IEnumerator IEnumerable.GetEnumerator() => default;
		}
	
		// Constructors
		public DefaultContractResolver() {} // 0x0000000183702E30-0x0000000183702F40
		static DefaultContractResolver() {} // 0x00000001837029F0-0x0000000183702DE0
	
		// Methods
		public virtual JsonContract ResolveContract(System.Type type) => default; // 0x00000001827BE670-0x00000001827BEBA0
		private static bool FilterMembers(MemberInfo member) => default; // 0x00000001824789A0-0x0000000182478AE0
		protected virtual List<MemberInfo> GetSerializableMembers(System.Type objectType) => default; // 0x00000001825E2100-0x00000001825E2EF0
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo) => default; // 0x00000001892BFE28-0x00000001892BFEE4
		protected virtual JsonObjectContract CreateObjectContract(System.Type objectType) => default; // 0x000000018283DAA0-0x000000018283DEE0
		private static void ThrowUnableToSerializeError(object o, StreamingContext context) {} // 0x00000001892BFEE4-0x00000001892BFF8C
		private MemberInfo GetExtensionDataMemberForType(System.Type type) => default; // 0x000000018283DF90-0x000000018283E1D0
		private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) {} // 0x00000001892BF5F8-0x00000001892BFE28
		private ConstructorInfo GetAttributeConstructor(System.Type objectType) => default; // 0x000000018283D870-0x000000018283DAA0
		private ConstructorInfo GetImmutableConstructor(System.Type objectType, JsonPropertyCollection memberProperties) => default; // 0x00000001834F8430-0x00000001834F85B0
		private ConstructorInfo GetParameterizedConstructor(System.Type objectType) => default; // 0x0000000183D1BC00-0x0000000183D1BC40
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) => default; // 0x00000001834F8300-0x00000001834F8430
		private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, System.Type type) => default; // 0x00000001834F85B0-0x00000001834F8660
		protected virtual JsonProperty CreatePropertyFromConstructorParameter([Nullable(2)] JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) => default; // 0x00000001834F8660-0x00000001834F88D0
		protected virtual JsonConverter ResolveContractConverter(System.Type objectType) => default; // 0x0000000182475BE0-0x0000000182475C30
		private Func<object> GetDefaultCreator(System.Type createdType) => default; // 0x0000000182475E40-0x0000000182475EB0
		private void InitializeContract(JsonContract contract) {} // 0x0000000182475960-0x0000000182475BE0
		private void ResolveCallbackMethods(JsonContract contract, System.Type t) {} // 0x0000000182475C30-0x0000000182475D80
		private void GetCallbackMethodsForType(System.Type type, [Nullable(new byte[2] {2, 1 })] out List<SerializationCallback> onSerializing, [Nullable(new byte[2] {2, 1 })] out List<SerializationCallback> onSerialized, [Nullable(new byte[2] {2, 1 })] out List<SerializationCallback> onDeserializing, [Nullable(new byte[2] {2, 1 })] out List<SerializationCallback> onDeserialized, [Nullable(new byte[2] {2, 1 })] out List<SerializationErrorCallback> onError) {
			onSerializing = default;
			onSerialized = default;
			onDeserializing = default;
			onDeserialized = default;
			onError = default;
		} // 0x000000018253F8D0-0x0000000182540F30
		private static bool IsConcurrentOrObservableCollection(System.Type t) => default; // 0x00000001824782C0-0x0000000182478400
		private static bool ShouldSkipDeserialized(System.Type t) => default; // 0x0000000182478080-0x00000001824781A0
		private static bool ShouldSkipSerializing(System.Type t) => default; // 0x00000001824781A0-0x00000001824782C0
		private List<System.Type> GetClassHierarchyForType(System.Type type) => default; // 0x000000018283F850-0x000000018283F990
		protected virtual JsonDictionaryContract CreateDictionaryContract(System.Type objectType) => default; // 0x000000018308E0C0-0x000000018308E2E0
		protected virtual JsonArrayContract CreateArrayContract(System.Type objectType) => default; // 0x000000018308D520-0x000000018308D650
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType) => default; // 0x0000000183439DA0-0x0000000183439E20
		protected virtual JsonLinqContract CreateLinqContract(System.Type objectType) => default; // 0x0000000183CF60E0-0x0000000183CF6170
		protected virtual JsonISerializableContract CreateISerializableContract(System.Type objectType) => default; // 0x00000001892BF324-0x00000001892BF500
		protected virtual JsonDynamicContract CreateDynamicContract(System.Type objectType) => default; // 0x00000001892BF134-0x00000001892BF324
		protected virtual JsonStringContract CreateStringContract(System.Type objectType) => default; // 0x0000000183439CB0-0x0000000183439D30
		protected virtual JsonContract CreateContract(System.Type objectType) => default; // 0x00000001824772C0-0x00000001824776F0
		internal static bool IsJsonPrimitiveType(System.Type t) => default; // 0x0000000182476C30-0x0000000182476C90
		internal static bool IsIConvertible(System.Type t) => default; // 0x00000001833576D0-0x00000001833577B0
		internal static bool CanConvertToString(System.Type type) => default; // 0x0000000182475590-0x00000001824756B0
		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, System.Type attributeType, [Nullable(2)] MethodInfo currentCallback, [Nullable(2)] ref System.Type prevAttributeType) => default; // 0x0000000182540F30-0x0000000182541230
		internal static string GetClrTypeFullName(System.Type type) => default; // 0x00000001892BF500-0x00000001892BF5D4
		protected virtual IList<JsonProperty> CreateProperties(System.Type type, MemberSerialization memberSerialization) => default; // 0x00000001824E60C0-0x00000001824E67F0
		internal virtual DefaultJsonNameTable GetNameTable() => default; // 0x00000001820B7B20-0x00000001820B7B30
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) => default; // 0x00000001824E5770-0x00000001824E5800
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) => default; // 0x00000001824E5330-0x00000001824E5770
		private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, System.Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess) {
			allowNonPublicAccess = default;
		} // 0x00000001824E6AB0-0x00000001824E71A0
		private Predicate<object> CreateShouldSerializeTest(MemberInfo member) => default; // 0x00000001824E5960-0x00000001824E5BC0
		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) {} // 0x00000001824E4A20-0x00000001824E4C30
		protected virtual string ResolvePropertyName(string propertyName) => default; // 0x00000001824E71A0-0x00000001824E71C0
		protected virtual string ResolveExtensionDataName(string extensionDataName) => default; // 0x00000001892BF5DC-0x00000001892BF5F8
		protected virtual string ResolveDictionaryKey(string dictionaryKey) => default; // 0x00000001839B9B50-0x00000001839B9B70
		public string GetResolvedPropertyName(string propertyName) => default; // 0x00000001892BF5D4-0x00000001892BF5DC
	}

	public class DefaultNamingStrategy : NamingStrategy // TypeDefIndex: 51763
	{
		// Constructors
		public DefaultNamingStrategy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[NullableContext(1)]
		protected override string ResolvePropertyName(string name) => default; // 0x0000000183D51810-0x0000000183D51820
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class DefaultReferenceResolver : IReferenceResolver // TypeDefIndex: 51764
	{
		// Fields
		private int _referenceCount; // 0x10
	
		// Constructors
		public DefaultReferenceResolver() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private BidirectionalDictionary<string, object> GetMappings(object context) => default; // 0x00000001892C4774-0x00000001892C4840
		public object ResolveReference(object context, string reference) => default; // 0x00000001892C499C-0x00000001892C4A1C
		public string GetReference(object context, object value) => default; // 0x00000001892C4840-0x00000001892C4920
		public void AddReference(object context, string reference, object value) {} // 0x00000001892C46F4-0x00000001892C4774
		public bool IsReferenced(object context, object value) => default; // 0x00000001892C4920-0x00000001892C499C
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder // TypeDefIndex: 51765
	{
		// Fields
		internal static readonly DefaultSerializationBinder Instance; // 0x00
		[Nullable(new byte[5] {1, 0, 2, 1, 1 })]
		private readonly ThreadSafeStore<StructMultiKey<string, string>, System.Type> _typeCache; // 0x10
	
		// Constructors
		public DefaultSerializationBinder() {} // 0x0000000183B38AE0-0x0000000183B38BB0
		static DefaultSerializationBinder() {} // 0x0000000183B38A70-0x0000000183B38AE0
	
		// Methods
		private System.Type GetTypeFromTypeNameKey([Nullable(new byte[3] {0, 2, 1 })] StructMultiKey<string, string> typeNameKey) => default; // 0x0000000182679EE0-0x0000000182679FC0
		private System.Type GetGenericTypeFromTypeName(string typeName, Assembly assembly) => default; // 0x00000001892C4A90-0x00000001892C4CA0
		private System.Type GetTypeByName([Nullable(new byte[3] {0, 2, 1 })] StructMultiKey<string, string> typeNameKey) => default; // 0x00000001827BCF80-0x00000001827BCFF0
		public override System.Type BindToType([Nullable(2)] string assemblyName, string typeName) => default; // 0x00000001827BCEC0-0x00000001827BCF80
		[NullableContext(2)]
		public override void BindToName([Nullable(1)] System.Type serializedType, out string assemblyName, out string typeName) {
			assemblyName = default;
			typeName = default;
		} // 0x00000001892C4A1C-0x00000001892C4A90
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class ErrorContext // TypeDefIndex: 51766
	{
		// Properties
		internal bool Traced { get; set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
		public Exception Error { get; } // 0x0000000181041090-0x00000001810410A0 
		public bool Handled { get; } // 0x0000000183D4F190-0x0000000183D4F1A0 
	
		// Constructors
		public ErrorContext() {} // Dummy constructor
		internal ErrorContext([Nullable(2)] object originalObject, [Nullable(2)] object member, string path, Exception error) {} // 0x00000001892C4CA0-0x00000001892C4CE8
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class ErrorEventArgs : EventArgs // TypeDefIndex: 51767
	{
		// Constructors
		public ErrorEventArgs() {} // Dummy constructor
		public ErrorEventArgs([Nullable(2)] object currentObject, ErrorContext errorContext) {} // 0x00000001892C4CE8-0x00000001892C4D54
	}

	[NullableContext(1)]
	public interface IAttributeProvider // TypeDefIndex: 51768
	{
	}

	[NullableContext(1)]
	public interface IContractResolver // TypeDefIndex: 51769
	{
		// Methods
		JsonContract ResolveContract(System.Type type);
	}

	[NullableContext(1)]
	public interface IReferenceResolver // TypeDefIndex: 51770
	{
		// Methods
		object ResolveReference(object context, string reference);
		string GetReference(object context, object value);
		bool IsReferenced(object context, object value);
		void AddReference(object context, string reference, object value);
	}

	[NullableContext(1)]
	public interface ISerializationBinder // TypeDefIndex: 51771
	{
		// Methods
		System.Type BindToType([Nullable(2)] string assemblyName, string typeName);
		[NullableContext(2)]
		void BindToName([Nullable(1)] System.Type serializedType, out string assemblyName, out string typeName);
	}

	[NullableContext(1)]
	public interface ITraceWriter // TypeDefIndex: 51772
	{
		// Properties
		TraceLevel LevelFilter { get; }
	
		// Methods
		void Trace(TraceLevel level, string message, [Nullable(2)] Exception ex);
	}

	[NullableContext(1)]
	public interface IValueProvider // TypeDefIndex: 51773
	{
		// Methods
		void SetValue(object target, [Nullable(2)] object value);
		object GetValue(object target);
	}

	[Nullable(0)]
	[NullableContext(2)]
	public class JsonArrayContract : JsonContainerContract // TypeDefIndex: 51774
	{
		// Fields
		private readonly System.Type _genericCollectionDefinitionType; // 0xD0
		private System.Type _genericWrapperType; // 0xD8
		[Nullable(new byte[2] {2, 1 })]
		private ObjectConstructor<object> _genericWrapperCreator; // 0xE0
		[Nullable(new byte[2] {2, 1 })]
		private Func<object> _genericTemporaryCollectionCreator; // 0xE8
		private readonly ConstructorInfo _parameterizedConstructor; // 0xF8
		[Nullable(new byte[2] {2, 1 })]
		private ObjectConstructor<object> _parameterizedCreator; // 0x100
		[Nullable(new byte[2] {2, 1 })]
		private ObjectConstructor<object> _overrideCreator; // 0x108
	
		// Properties
		public System.Type CollectionItemType { get; } // 0x0000000183D50E60-0x0000000183D50E70 
		public bool IsMultidimensionalArray { get; } // 0x0000000183D519D0-0x0000000183D519E0 
		internal bool IsArray { get; } // 0x0000000183D57D50-0x0000000183D57D60 
		internal bool ShouldCreateWrapper { get; } // 0x0000000183D57BD0-0x0000000183D57BE0 
		internal bool CanDeserialize { get; private set; } // 0x0000000183D714C0-0x0000000183D714D0 0x0000000183D714D0-0x0000000183D714E0
		[Nullable(new byte[2] {2, 1 })]
		internal ObjectConstructor<object> ParameterizedCreator { get => default; } // 0x00000001892C4F54-0x00000001892C500C 
		[Nullable(new byte[2] {2, 1 })]
		public ObjectConstructor<object> OverrideCreator { get => default; set {} } // 0x0000000183D56D30-0x0000000183D56D40 0x00000001892C500C-0x00000001892C5034
		public bool HasParameterizedCreator { get; set; } // 0x0000000183D57AB0-0x0000000183D57AC0 0x0000000183D5B8E0-0x0000000183D5B8F0
		internal bool HasParameterizedCreatorInternal { get => default; } // 0x000000018247A150-0x000000018247A200 
	
		// Constructors
		public JsonArrayContract() {} // Dummy constructor
		[NullableContext(1)]
		public JsonArrayContract(System.Type underlyingType) {} // 0x000000018308D650-0x000000018308DDD0
	
		// Methods
		[NullableContext(1)]
		internal IWrappedCollection CreateWrapper(object list) => default; // 0x000000018308F160-0x000000018308F480
		[NullableContext(1)]
		internal IList CreateTemporaryCollection() => default; // 0x00000001824E7E80-0x00000001824E8090
		[NullableContext(1)]
		private void StoreFSharpListCreatorIfNecessary(System.Type underlyingType) {} // 0x00000001892C4E7C-0x00000001892C4F54
	}

	[Nullable(0)]
	[NullableContext(2)]
	public class JsonContainerContract : JsonContract // TypeDefIndex: 51775
	{
		// Fields
		private JsonContract _itemContract; // 0x90
		private JsonContract _finalItemContract; // 0x98
	
		// Properties
		internal JsonContract ItemContract { get => default; set {} } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x0000000182474FC0-0x0000000182475030
		internal JsonContract FinalItemContract { get => default; } // 0x00000001811AC510-0x00000001811AC520 
		public JsonConverter ItemConverter { get; set; } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
		public bool? ItemIsReference { get; set; } // 0x0000000183D714E0-0x0000000183D714F0 0x0000000183D71510-0x0000000183D71520
		public ReferenceLoopHandling? ItemReferenceLoopHandling { get; set; } // 0x0000000183D714F0-0x0000000183D71500 0x0000000183D71520-0x0000000183D71530
		public TypeNameHandling? ItemTypeNameHandling { get; set; } // 0x0000000183D71500-0x0000000183D71510 0x0000000183D71530-0x0000000183D71540
	
		// Constructors
		public JsonContainerContract() {} // Dummy constructor
		[NullableContext(1)]
		internal JsonContainerContract(System.Type underlyingType) {} // 0x0000000182475860-0x0000000182475900
	}

	internal enum JsonContractType // TypeDefIndex: 51776
	{
		None = 0,
		Object = 1,
		Array = 2,
		Primitive = 3,
		String = 4,
		Dictionary = 5,
		Dynamic = 6,
		Serializable = 7,
		Linq = 8
	}

	public delegate void SerializationCallback(object o, StreamingContext context); // TypeDefIndex: 51777; 0x00000001829CE1E0-0x00000001829CE210

	public delegate void SerializationErrorCallback(object o, StreamingContext context, ErrorContext errorContext); // TypeDefIndex: 51778; 0x000000018500800C-0x0000000185008038

	public delegate void ExtensionDataSetter(object o, string key, [Nullable(2)] object value); // TypeDefIndex: 51779; 0x00000001811360D0-0x00000001811360F0

	public delegate IEnumerable<KeyValuePair<object, object>> ExtensionDataGetter(object o); // TypeDefIndex: 51780; 0x000000018102B410-0x000000018102B420

	[Nullable(0)]
	[NullableContext(1)]
	public abstract class JsonContract // TypeDefIndex: 51783
	{
		// Fields
		internal bool IsNullable; // 0x10
		internal bool IsConvertable; // 0x11
		internal bool IsEnum; // 0x12
		internal System.Type NonNullableUnderlyingType; // 0x18
		internal ReadType InternalReadType; // 0x20
		internal JsonContractType ContractType; // 0x24
		internal bool IsReadOnlyOrFixedSize; // 0x28
		internal bool IsSealed; // 0x29
		internal bool IsInstantiable; // 0x2A
		[Nullable(new byte[2] {2, 1 })]
		private List<SerializationCallback> _onDeserializedCallbacks; // 0x30
		[Nullable(new byte[2] {2, 1 })]
		private List<SerializationCallback> _onDeserializingCallbacks; // 0x38
		[Nullable(new byte[2] {2, 1 })]
		private List<SerializationCallback> _onSerializedCallbacks; // 0x40
		[Nullable(new byte[2] {2, 1 })]
		private List<SerializationCallback> _onSerializingCallbacks; // 0x48
		[Nullable(new byte[2] {2, 1 })]
		private List<SerializationErrorCallback> _onErrorCallbacks; // 0x50
		private System.Type _createdType; // 0x58
	
		// Properties
		public System.Type UnderlyingType { get; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public System.Type CreatedType { get; set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000182476B80-0x0000000182476C30
		public bool? IsReference { get; set; } // 0x0000000183D71540-0x0000000183D71550 0x0000000183D71550-0x0000000183D71560
		[Nullable(2)]
		public JsonConverter Converter { [NullableContext(2)] get; [NullableContext(2)] set; } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		[Nullable(2)]
		public JsonConverter InternalConverter { [NullableContext(2)] get; [NullableContext(2)] internal set; } // 0x0000000183D4EB20-0x0000000183D4EB30 0x00000001851DFCA4-0x00000001851DFCB4
		public IList<SerializationCallback> OnDeserializedCallbacks { get; } // 0x0000000183152300-0x0000000183152390 
		public IList<SerializationCallback> OnDeserializingCallbacks { get; } // 0x00000001892C5234-0x00000001892C52B8 
		public IList<SerializationCallback> OnSerializedCallbacks { get; } // 0x00000001892C52B8-0x00000001892C533C 
		public IList<SerializationCallback> OnSerializingCallbacks { get; } // 0x0000000183152270-0x0000000183152300 
		public IList<SerializationErrorCallback> OnErrorCallbacks { get; } // 0x00000001831527C0-0x0000000183152850 
		[Nullable(new byte[2] {2, 1 })]
		public Func<object> DefaultCreator { get; set; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x00000001851DFC94-0x00000001851DFCA4
		public bool DefaultCreatorNonPublic { get; set; } // 0x0000000183D51D50-0x0000000183D51D60 0x0000000183D56D40-0x0000000183D56D50
	
		// Constructors
		protected JsonContract() {} // Dummy constructor
		internal JsonContract(System.Type underlyingType) {} // 0x00000001824776F0-0x0000000182477850
	
		// Methods
		internal void InvokeOnSerializing(object o, StreamingContext context) {} // 0x00000001827B9260-0x00000001827B9370
		internal void InvokeOnSerialized(object o, StreamingContext context) {} // 0x00000001827B9420-0x00000001827B9530
		internal void InvokeOnDeserializing(object o, StreamingContext context) {} // 0x0000000182B39290-0x0000000182B393A0
		internal void InvokeOnDeserialized(object o, StreamingContext context) {} // 0x00000001824E9D40-0x00000001824E9EC0
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) {} // 0x00000001892C50D4-0x00000001892C5234
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) => default; // 0x00000001836E5E00-0x00000001836E5EB0
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) => default; // 0x00000001892C5034-0x00000001892C50D4
	}

	[Nullable(0)]
	[NullableContext(2)]
	public class JsonDictionaryContract : JsonContainerContract // TypeDefIndex: 51784
	{
		// Fields
		private readonly System.Type _genericCollectionDefinitionType; // 0xE0
		private System.Type _genericWrapperType; // 0xE8
		[Nullable(new byte[2] {2, 1 })]
		private ObjectConstructor<object> _genericWrapperCreator; // 0xF0
		[Nullable(new byte[2] {2, 1 })]
		private Func<object> _genericTemporaryDictionaryCreator; // 0xF8
		private readonly ConstructorInfo _parameterizedConstructor; // 0x108
		[Nullable(new byte[2] {2, 1 })]
		private ObjectConstructor<object> _overrideCreator; // 0x110
		[Nullable(new byte[2] {2, 1 })]
		private ObjectConstructor<object> _parameterizedCreator; // 0x118
	
		// Properties
		[Nullable(new byte[3] {2, 1, 1 })]
		public Func<string, string> DictionaryKeyResolver { get; set; } // 0x0000000183D50E60-0x0000000183D50E70 0x00000001858B426C-0x00000001858B4280
		public System.Type DictionaryKeyType { get; } // 0x0000000183D4E7C0-0x0000000183D4E7D0 
		public System.Type DictionaryValueType { get; } // 0x0000000183D50050-0x0000000183D50060 
		internal JsonContract KeyContract { get; set; } // 0x0000000183D4E7B0-0x0000000183D4E7C0 0x0000000185142FC4-0x0000000185142FD8
		internal bool ShouldCreateWrapper { get; } // 0x0000000183D56750-0x0000000183D56760 
		[Nullable(new byte[2] {2, 1 })]
		internal ObjectConstructor<object> ParameterizedCreator { get => default; } // 0x00000001892C5758-0x00000001892C5810 
		[Nullable(new byte[2] {2, 1 })]
		public ObjectConstructor<object> OverrideCreator { get => default; set {} } // 0x0000000183D56CF0-0x0000000183D56D00 0x0000000184275CF4-0x0000000184275D08
		public bool HasParameterizedCreator { get; set; } // 0x0000000183D57B30-0x0000000183D57B40 0x0000000183D5A200-0x0000000183D5A210
		internal bool HasParameterizedCreatorInternal { get => default; } // 0x000000018308EDB0-0x000000018308EE30 
	
		// Constructors
		public JsonDictionaryContract() {} // Dummy constructor
		[NullableContext(1)]
		public JsonDictionaryContract(System.Type underlyingType) {} // 0x000000018308E2E0-0x000000018308E930
	
		// Methods
		[NullableContext(1)]
		internal IWrappedDictionary CreateWrapper(object dictionary) => default; // 0x00000001892C5518-0x00000001892C5758
		[NullableContext(1)]
		internal IDictionary CreateTemporaryDictionary() => default; // 0x00000001892C533C-0x00000001892C5518
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class JsonDynamicContract : JsonContainerContract // TypeDefIndex: 51785
	{
		// Fields
		private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object>>> _callSiteGetters; // 0xD0
		[Nullable(new byte[8] {1, 1, 1, 1, 1, 1, 2, 1 })]
		private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object, object>>> _callSiteSetters; // 0xD8
	
		// Properties
		public JsonPropertyCollection Properties { get; } // 0x0000000183D50E60-0x0000000183D50E70 
		[Nullable(new byte[3] {2, 1, 1 })]
		public Func<string, string> PropertyNameResolver { get; set; } // 0x0000000183D4E7C0-0x0000000183D4E7D0 0x00000001858B4280-0x00000001858B4294
	
		// Constructors
		public JsonDynamicContract() {} // Dummy constructor
		public JsonDynamicContract(System.Type underlyingType) {} // 0x00000001892C5C18-0x00000001892C5DE8
	
		// Methods
		private static CallSite<Func<CallSite, object, object>> CreateCallSiteGetter(string name) => default; // 0x00000001892C5810-0x00000001892C58E8
		private static CallSite<Func<CallSite, object, object, object>> CreateCallSiteSetter(string name) => default; // 0x00000001892C58E8-0x00000001892C59C0
		internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, [Nullable(2)] out object value) {
			value = default;
			return default;
		} // 0x00000001892C59C0-0x00000001892C5AF4
		internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, [Nullable(2)] object value) => default; // 0x00000001892C5AF4-0x00000001892C5C18
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 51786
	{
		// Fields
		private readonly JsonSerializerInternalReader _reader; // 0x10
		private readonly JsonISerializableContract _contract; // 0x18
		[Nullable(2)]
		private readonly JsonProperty _member; // 0x20
	
		// Constructors
		public JsonFormatterConverter() {} // Dummy constructor
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, [Nullable(2)] JsonProperty member) {} // 0x00000001892C6094-0x00000001892C61BC
	
		// Methods
		private T GetTokenValue<T>(object value) => default;
		public object Convert(object value, System.Type type) => default; // 0x00000001892C5DE8-0x00000001892C5F2C
		public bool ToBoolean(object value) => default; // 0x00000001892C5F2C-0x00000001892C5F74
		public int ToInt32(object value) => default; // 0x00000001892C5F74-0x00000001892C5FBC
		public long ToInt64(object value) => default; // 0x00000001892C5FBC-0x00000001892C6004
		public float ToSingle(object value) => default; // 0x00000001892C6004-0x00000001892C604C
		public string ToString(object value) => default; // 0x00000001892C604C-0x00000001892C6094
	}

	public class JsonISerializableContract : JsonContainerContract // TypeDefIndex: 51787
	{
		// Properties
		[Nullable(new byte[2] {2, 1 })]
		public ObjectConstructor<object> ISerializableCreator { get; set; } // 0x0000000183D50E60-0x0000000183D50E70 0x00000001858B426C-0x00000001858B4280
	
		// Constructors
		public JsonISerializableContract() {} // Dummy constructor
		[NullableContext(1)]
		public JsonISerializableContract(System.Type underlyingType) {} // 0x00000001892C61BC-0x00000001892C61DC
	}

	public class JsonLinqContract : JsonContract // TypeDefIndex: 51788
	{
		// Constructors
		public JsonLinqContract() {} // Dummy constructor
		[NullableContext(1)]
		public JsonLinqContract(System.Type underlyingType) {} // 0x00000001842770F8-0x0000000184277118
	}

	[Nullable(0)]
	[NullableContext(2)]
	public class JsonObjectContract : JsonContainerContract // TypeDefIndex: 51789
	{
		// Fields
		internal bool ExtensionDataIsJToken; // 0x100
		private bool? _hasRequiredOrDefaultValueProperties; // 0x101
		[Nullable(new byte[2] {2, 1 })]
		private ObjectConstructor<object> _overrideCreator; // 0x108
		[Nullable(new byte[2] {2, 1 })]
		private ObjectConstructor<object> _parameterizedCreator; // 0x110
		private JsonPropertyCollection _creatorParameters; // 0x118
		private System.Type _extensionDataValueType; // 0x120
	
		// Properties
		public MemberSerialization MemberSerialization { get; set; } // 0x0000000183D57EF0-0x0000000183D57F00 0x0000000183D57F70-0x0000000183D57F80
		public MissingMemberHandling? MissingMemberHandling { get; set; } // 0x0000000183D71580-0x0000000183D71590 0x0000000183D69470-0x0000000183D69480
		public Required? ItemRequired { get; set; } // 0x0000000183D71570-0x0000000183D71580 0x0000000183D715A0-0x0000000183D715B0
		public NullValueHandling? ItemNullValueHandling { get; set; } // 0x0000000183D71560-0x0000000183D71570 0x0000000183D71590-0x0000000183D715A0
		[Nullable(1)]
		public JsonPropertyCollection Properties { [NullableContext(1)] get; } // 0x0000000183D51140-0x0000000183D51150 
		[Nullable(1)]
		public JsonPropertyCollection CreatorParameters { [NullableContext(1)] get => default; } // 0x0000000183CF5EA0-0x0000000183CF5F30 
		[Nullable(new byte[2] {2, 1 })]
		public ObjectConstructor<object> OverrideCreator { get => default; set {} } // 0x0000000183D56D30-0x0000000183D56D40 0x000000018589D950-0x000000018589D964
		[Nullable(new byte[2] {2, 1 })]
		internal ObjectConstructor<object> ParameterizedCreator { get => default; set {} } // 0x0000000183D56CF0-0x0000000183D56D00 0x0000000184275CF4-0x0000000184275D08
		public ExtensionDataSetter ExtensionDataSetter { get; set; } // 0x0000000183D50EA0-0x0000000183D50EB0 0x00000001856A2B64-0x00000001856A2B78
		public ExtensionDataGetter ExtensionDataGetter { get; set; } // 0x0000000183D51950-0x0000000183D51960 0x00000001858B408C-0x00000001858B40A0
		public System.Type ExtensionDataValueType { set {} } // 0x00000001892C62D8-0x00000001892C6398
		[Nullable(new byte[3] {2, 1, 1 })]
		public Func<string, string> ExtensionDataNameResolver { get; set; } // 0x0000000183D50160-0x0000000183D50170 0x000000018554D2E0-0x000000018554D2F4
		internal bool HasRequiredOrDefaultValueProperties { get => default; } // 0x0000000182D73000-0x0000000182D735B0 
	
		// Constructors
		public JsonObjectContract() {} // Dummy constructor
		[NullableContext(1)]
		public JsonObjectContract(System.Type underlyingType) {} // 0x00000001824754F0-0x0000000182475590
	
		// Methods
		[NullableContext(1)]
		internal object GetUninitializedObject() => default; // 0x00000001892C61DC-0x00000001892C62D8
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class JsonPrimitiveContract : JsonContract // TypeDefIndex: 51790
	{
		// Fields
		private static readonly Dictionary<System.Type, ReadType> ReadTypeMap; // 0x00
	
		// Properties
		internal PrimitiveTypeCode TypeCode { get; set; } // 0x0000000183D4FB60-0x0000000183D4FB70 0x0000000183D4FB70-0x0000000183D4FB80
	
		// Constructors
		public JsonPrimitiveContract() {} // Dummy constructor
		public JsonPrimitiveContract(System.Type underlyingType) {} // 0x0000000183439E20-0x0000000183439F30
		static JsonPrimitiveContract() {} // 0x0000000183875BF0-0x0000000183875F20
	}

	[Nullable(0)]
	[NullableContext(2)]
	public class JsonProperty // TypeDefIndex: 51791
	{
		// Fields
		internal Required? _required; // 0x10
		internal bool _hasExplicitDefaultValue; // 0x18
		private object _defaultValue; // 0x20
		private bool _hasGeneratedDefaultValue; // 0x28
		private string _propertyName; // 0x30
		internal bool _skipPropertyNameEscape; // 0x38
		private System.Type _propertyType; // 0x40
	
		// Properties
		internal JsonContract PropertyContract { get; set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public string PropertyName { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x00000001824E6960-0x00000001824E6A40
		public System.Type DeclaringType { get; set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public int? Order { get; set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183D4F270-0x0000000183D4F280
		public string UnderlyingName { get; set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		public IValueProvider ValueProvider { get; set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		public IAttributeProvider AttributeProvider { get; set; } // 0x000000018519C3C8-0x000000018519C3D8
		public System.Type PropertyType { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x00000001824E5C60-0x00000001824E5CE0
		public JsonConverter Converter { get; set; } // 0x0000000183D4EB20-0x0000000183D4EB30 0x00000001851DFCA4-0x00000001851DFCB4
		public bool Ignored { get; set; } // 0x0000000183D4F360-0x0000000183D4F370 0x0000000183D4F380-0x0000000183D4F390
		public bool Readable { get; set; } // 0x0000000183D5A210-0x0000000183D5A220 0x0000000183D5A220-0x0000000183D5A230
		public bool Writable { get; set; } // 0x0000000183D6C200-0x0000000183D6C210 0x0000000183D71640-0x0000000183D71650
		public bool HasMemberAttribute { get; set; } // 0x0000000183D715D0-0x0000000183D715E0 0x0000000183D71610-0x0000000183D71620
		public object DefaultValue { get => default; set {} } // 0x00000001892C63E0-0x00000001892C63F0 0x00000001892C63F0-0x00000001892C6404
		public Required Required { get => default; } // 0x0000000182D735B0-0x0000000182D735F0 
		public bool? IsReference { get; set; } // 0x0000000183D67F10-0x0000000183D67F20 0x0000000183D67F20-0x0000000183D67F30
		public NullValueHandling? NullValueHandling { get; set; } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000183D4E740-0x0000000183D4E750
		public DefaultValueHandling? DefaultValueHandling { get; set; } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x0000000183D5D630-0x0000000183D5D640
		public ReferenceLoopHandling? ReferenceLoopHandling { get; set; } // 0x00000001811AC510-0x00000001811AC520 0x0000000183D50F10-0x0000000183D50F20
		public ObjectCreationHandling? ObjectCreationHandling { get; set; } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000183D71630-0x0000000183D71640
		public TypeNameHandling? TypeNameHandling { get; set; } // 0x0000000183D4EB10-0x0000000183D4EB20 0x0000000183D4EB70-0x0000000183D4EB80
		[Nullable(new byte[2] {2, 1 })]
		public Predicate<object> ShouldSerialize { get; set; } // 0x0000000183D4EAD0-0x0000000183D4EAE0 0x0000000182B47080-0x0000000182B470A0
		[Nullable(new byte[2] {2, 1 })]
		public Predicate<object> ShouldDeserialize { get; } // 0x0000000183D4E750-0x0000000183D4E760 
		[Nullable(new byte[2] {2, 1 })]
		public Predicate<object> GetIsSpecified { get; set; } // 0x0000000183D50E60-0x0000000183D50E70 0x00000001858B426C-0x00000001858B4280
		[Nullable(new byte[3] {2, 1, 2 })]
		public Action<object, object> SetIsSpecified { get; set; } // 0x0000000183D4E7C0-0x0000000183D4E7D0 0x00000001858B4280-0x00000001858B4294
		public JsonConverter ItemConverter { get; set; } // 0x0000000183D50050-0x0000000183D50060 0x000000018554A7E0-0x000000018554A7F4
		public bool? ItemIsReference { get; set; } // 0x0000000183D715E0-0x0000000183D715F0 0x0000000183D71620-0x0000000183D71630
		public TypeNameHandling? ItemTypeNameHandling { get; set; } // 0x0000000183D71600-0x0000000183D71610 0x0000000183D68FA0-0x0000000183D68FB0
		public ReferenceLoopHandling? ItemReferenceLoopHandling { get; set; } // 0x0000000183D715F0-0x0000000183D71600 0x0000000183D68F90-0x0000000183D68FA0
	
		// Constructors
		public JsonProperty() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal object GetResolvedDefaultValue() => default; // 0x00000001827BBFC0-0x00000001827BC040
		[NullableContext(1)]
		public override string ToString() => default; // 0x00000001892C6398-0x00000001892C63E0
		[NullableContext(1)]
		internal void WritePropertyName(JsonWriter writer) {} // 0x00000001827BAAA0-0x00000001827BAAD0
	}

	[Nullable(new byte[3] {0, 1, 1 })]
	[NullableContext(1)]
	public class JsonPropertyCollection : KeyedCollection<string, JsonProperty> // TypeDefIndex: 51792
	{
		// Fields
		private readonly System.Type _type; // 0x30
		private readonly List<JsonProperty> _list; // 0x38
	
		// Constructors
		public JsonPropertyCollection() {} // Dummy constructor
		public JsonPropertyCollection(System.Type type) {} // 0x00000001824753A0-0x00000001824754F0
	
		// Methods
		protected override string GetKeyForItem(JsonProperty item) => default; // 0x0000000183D715B0-0x0000000183D715D0
		public void AddProperty(JsonProperty property) {} // 0x00000001824E5F60-0x00000001824E60C0
		public JsonProperty GetClosestMatchProperty(string propertyName) => default; // 0x00000001823236D0-0x0000000182323910
		private bool TryGetProperty(string key, [Nullable(2)] [NotNullWhen(true)] out JsonProperty item) {
			item = default;
			return default;
		} // 0x0000000182323BF0-0x0000000182323E00
		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) => default; // 0x0000000182323910-0x0000000182323BF0
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal abstract class JsonSerializerInternalBase // TypeDefIndex: 51794
	{
		// Fields
		[Nullable(2)]
		private ErrorContext _currentErrorContext; // 0x10
		[Nullable(new byte[3] {2, 1, 1 })]
		private BidirectionalDictionary<string, object> _mappings; // 0x18
		internal readonly JsonSerializer Serializer; // 0x20
		[Nullable(2)]
		internal readonly ITraceWriter TraceWriter; // 0x28
		[Nullable(2)]
		protected JsonSerializerProxy InternalSerializer; // 0x30
	
		// Properties
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings { get; } // 0x00000001892C68DC-0x00000001892C69E4 
	
		// Nested types
		[NullableContext(0)]
		private class ReferenceEqualsEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 51793
		{
			// Constructors
			public ReferenceEqualsEqualityComparer() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			[NullableContext(2)]
			bool IEqualityComparer<object>.Equals(object x, object y) => default; // 0x0000000186DDEAAC-0x0000000186DDEAB4
			[NullableContext(1)]
			int IEqualityComparer<object>.GetHashCode(object obj) => default; // 0x0000000183D6E640-0x0000000183D6E650
		}
	
		// Constructors
		protected JsonSerializerInternalBase() {} // Dummy constructor
		protected JsonSerializerInternalBase(JsonSerializer serializer) {} // 0x0000000183163C30-0x0000000183163CA0
	
		// Methods
		protected NullValueHandling ResolvedNullValueHandling([Nullable(2)] JsonObjectContract containerContract, JsonProperty property) => default; // 0x00000001892C6850-0x00000001892C68DC
		private ErrorContext GetErrorContext([Nullable(2)] object currentObject, [Nullable(2)] object member, string path, Exception error) => default; // 0x00000001892C6478-0x00000001892C6584
		protected void ClearErrorContext() {} // 0x00000001892C6404-0x00000001892C6478
		[NullableContext(2)]
		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, [Nullable(1)] string path, [Nullable(1)] Exception ex) => default; // 0x00000001892C6584-0x00000001892C6850
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 51799
	{
		// Nested types
		[NullableContext(0)]
		internal enum PropertyPresence // TypeDefIndex: 51795
		{
			None = 0,
			Null = 1,
			Value = 2
		}
	
		[Nullable(0)]
		[NullableContext(2)]
		internal class CreatorPropertyContext // TypeDefIndex: 51796
		{
			// Fields
			[Nullable(1)]
			public readonly string Name; // 0x10
			public JsonProperty Property; // 0x18
			public JsonProperty ConstructorProperty; // 0x20
			public PropertyPresence? Presence; // 0x28
			public object Value; // 0x30
			public bool Used; // 0x38
	
			// Constructors
			public CreatorPropertyContext() {} // Dummy constructor
			[NullableContext(1)]
			public CreatorPropertyContext(string name) {} // 0x000000018426FEE0-0x000000018426FEF0
		}
	
		// Constructors
		public JsonSerializerInternalReader() {} // Dummy constructor
		public JsonSerializerInternalReader(JsonSerializer serializer) {} // 0x00000001842719A0-0x00000001842719A8
	
		// Methods
		public void Populate(JsonReader reader, object target) {} // 0x00000001892C9CF0-0x00000001892CA1CC
		[NullableContext(2)]
		private JsonContract GetContractSafe(System.Type type) => default; // 0x00000001827BC960-0x00000001827BC9D0
		private JsonContract GetContract(System.Type type) => default; // 0x00000001827BDC20-0x00000001827BE670
		[NullableContext(2)]
		public object Deserialize([Nullable(1)] JsonReader reader, System.Type objectType, bool checkAdditionalContent) => default; // 0x00000001827BC7E0-0x00000001827BC960
		private JsonSerializerProxy GetInternalSerializer() => default; // 0x00000001824DF020-0x00000001824DF0A0
		[NullableContext(2)]
		private JToken CreateJToken([Nullable(1)] JsonReader reader, JsonContract contract) => default; // 0x0000000182693190-0x00000001826938A0
		private JToken CreateJObject(JsonReader reader) => default; // 0x0000000183A378D0-0x0000000183A38060
		[NullableContext(2)]
		private object CreateValueInternal([Nullable(1)] JsonReader reader, System.Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) => default; // 0x0000000182323E60-0x0000000182324690
		[NullableContext(2)]
		private static bool CoerceEmptyStringToNull(System.Type objectType, JsonContract contract, [Nullable(1)] string s) => default; // 0x0000000182906460-0x0000000182906BB0
		internal string GetExpectedDescription(JsonContract contract) => default; // 0x00000001892C94D8-0x00000001892C95BC
		[NullableContext(2)]
		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) => default; // 0x00000001824EA550-0x00000001824EBC20
		[NullableContext(2)]
		private object CreateObject([Nullable(1)] JsonReader reader, System.Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) => default; // 0x00000001824E8590-0x00000001824E8B90
		[NullableContext(2)]
		private bool ReadMetadataPropertiesToken([Nullable(1)] JTokenReader reader, ref System.Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) {
			newValue = default;
			id = default;
			return default;
		} // 0x00000001892CA278-0x00000001892CA870
		[NullableContext(2)]
		private bool ReadMetadataProperties([Nullable(1)] JsonReader reader, ref System.Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) {
			newValue = default;
			id = default;
			return default;
		} // 0x00000001824E8D50-0x00000001824E9BA0
		[NullableContext(2)]
		private void ResolveTypeName([Nullable(1)] JsonReader reader, ref System.Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, [Nullable(1)] string qualifiedTypeName) {} // 0x00000001827BC9D0-0x00000001827BCEC0
		private JsonArrayContract EnsureArrayContract(JsonReader reader, System.Type objectType, JsonContract contract) => default; // 0x00000001824EA4E0-0x00000001824EA550
		[NullableContext(2)]
		private object CreateList([Nullable(1)] JsonReader reader, System.Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) => default; // 0x00000001824E9EC0-0x00000001824EA4E0
		[NullableContext(2)]
		private bool HasNoDefinedType(JsonContract contract) => default; // 0x00000001824E8BC0-0x00000001824E8D50
		[NullableContext(2)]
		private object EnsureType([Nullable(1)] JsonReader reader, object value, [Nullable(1)] CultureInfo culture, JsonContract contract, System.Type targetType) => default; // 0x0000000182417B90-0x00000001824183B0
		private bool SetPropertyValue(JsonProperty property, [Nullable(2)] JsonConverter propertyConverter, [Nullable(2)] JsonContainerContract containerContract, [Nullable(2)] JsonProperty containerProperty, JsonReader reader, object target) => default; // 0x0000000182325070-0x00000001823253A0
		[NullableContext(2)]
		private bool CalculatePropertyDetails([Nullable(1)] JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, [Nullable(1)] JsonReader reader, [Nullable(1)] object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue, out bool ignoredValue) {
			useExistingValue = default;
			currentValue = default;
			propertyContract = default;
			gottenCurrentValue = default;
			ignoredValue = default;
			return default;
		} // 0x00000001823253A0-0x0000000182325BB0
		private void AddReference(JsonReader reader, string id, object value) {} // 0x00000001892C69E4-0x00000001892C6CA0
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) => default; // 0x0000000182325BB0-0x0000000182325C30
		[NullableContext(2)]
		private bool ShouldSetPropertyValue([Nullable(1)] JsonProperty property, JsonObjectContract contract, object value) => default; // 0x0000000182324F90-0x0000000182325070
		private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) {
			createdFromNonDefaultCreator = default;
			return default;
		} // 0x00000001824E8160-0x00000001824E82B0
		private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) {
			createdFromNonDefaultCreator = default;
			return default;
		} // 0x0000000183241110-0x00000001832411F0
		private void OnDeserializing(JsonReader reader, JsonContract contract, object value) {} // 0x0000000182B391C0-0x0000000182B39290
		private void OnDeserialized(JsonReader reader, JsonContract contract, object value) {} // 0x00000001824E9C70-0x00000001824E9D40
		private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, [Nullable(2)] JsonProperty containerProperty, [Nullable(2)] string id) => default; // 0x00000001824EDD60-0x00000001824EE3E0
		private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, [Nullable(2)] JsonProperty containerProperty, [Nullable(2)] string id) => default; // 0x00000001892C9628-0x00000001892C9CF0
		private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, [Nullable(2)] object currentObject, string message) {} // 0x00000001892CAFB0-0x00000001892CB0F8
		private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, [Nullable(2)] JsonProperty containerProperty, [Nullable(2)] string id) => default; // 0x00000001824EBC20-0x00000001824EC430
		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] string id) => default; // 0x00000001892C74AC-0x00000001892C7B00
		internal object CreateISerializableItem(JToken token, System.Type type, JsonISerializableContract contract, [Nullable(2)] JsonProperty member) => default; // 0x00000001892C7390-0x00000001892C74AC
		private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] string id) => default; // 0x00000001892C6CA0-0x00000001892C7390
		private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, [Nullable(2)] JsonProperty containerProperty, ObjectConstructor<object> creator, [Nullable(2)] string id) => default; // 0x00000001892C7B00-0x00000001892C94D8
		private object DeserializeConvertable(JsonConverter converter, JsonReader reader, System.Type objectType, [Nullable(2)] object existingValue) => default; // 0x00000001824DEEB0-0x00000001824DF020
		private List<CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, [Nullable(2)] JsonProperty containerProperty, JsonReader reader, System.Type objectType) => default; // 0x00000001892CA870-0x00000001892CAFB0
		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, [Nullable(2)] JsonProperty containerMember, [Nullable(2)] JsonProperty containerProperty, [Nullable(2)] string id, out bool createdFromNonDefaultCreator) {
			createdFromNonDefaultCreator = default;
			return default;
		} // 0x00000001824E9BA0-0x00000001824E9C70
		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] string id) => default; // 0x0000000182321C70-0x00000001823233C0
		private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) => default; // 0x0000000182B0FC70-0x0000000182B0FD00
		private bool CheckPropertyName(JsonReader reader, string memberName) => default; // 0x00000001824EE3E0-0x00000001824F47C0
		private void SetExtensionData(JsonObjectContract contract, [Nullable(2)] JsonProperty member, JsonReader reader, string memberName, object o) {} // 0x000000018269A0A0-0x000000018269A0F0
		private object ReadExtensionDataValue(JsonObjectContract contract, [Nullable(2)] JsonProperty member, JsonReader reader) => default; // 0x00000001892CA1CC-0x00000001892CA278
		private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue) {} // 0x00000001827BBCC0-0x00000001827BBFC0
		private void SetPropertyPresence(JsonReader reader, JsonProperty property, [Nullable(new byte[2] {2, 1 })] Dictionary<JsonProperty, PropertyPresence> requiredProperties) {} // 0x0000000182906310-0x0000000182906460
		private void HandleError(JsonReader reader, bool readPastError, int initialDepth) {} // 0x00000001892C95BC-0x00000001892C9628
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 51800
	{
		// Fields
		[Nullable(2)]
		private System.Type _rootType; // 0x38
		private int _rootLevel; // 0x40
		private readonly List<object> _serializeStack; // 0x48
	
		// Constructors
		public JsonSerializerInternalWriter() {} // Dummy constructor
		public JsonSerializerInternalWriter(JsonSerializer serializer) {} // 0x0000000183163B90-0x0000000183163C30
	
		// Methods
		[NullableContext(2)]
		public void Serialize([Nullable(1)] JsonWriter jsonWriter, object value, System.Type objectType) {} // 0x0000000183163CA0-0x0000000183163F50
		private JsonSerializerProxy GetInternalSerializer() => default; // 0x00000001892CB0F8-0x00000001892CB16C
		[NullableContext(2)]
		private JsonContract GetContractSafe(object value) => default; // 0x00000001827BEC50-0x00000001827BEC70
		private JsonContract GetContract(object value) => default; // 0x00000001827BEC70-0x00000001827BECB0
		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract containerContract, [Nullable(2)] JsonProperty containerProperty) {} // 0x00000001827BB4A0-0x00000001827BB550
		[NullableContext(2)]
		private void SerializeValue([Nullable(1)] JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) {} // 0x00000001827BB160-0x00000001827BB4A0
		[NullableContext(2)]
		private bool? ResolveIsReference([Nullable(1)] JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) => default; // 0x00000001827BB940-0x00000001827BB9D0
		[NullableContext(2)]
		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) => default; // 0x00000001827BAED0-0x00000001827BAFD0
		[NullableContext(2)]
		private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, [Nullable(1)] JsonProperty property) => default; // 0x00000001827BAE20-0x00000001827BAEC0
		[NullableContext(2)]
		private bool CheckForCircularReference([Nullable(1)] JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) => default; // 0x00000001827BAFD0-0x00000001827BB160
		private void WriteReference(JsonWriter writer, object value) {} // 0x00000001892CD2AC-0x00000001892CD450
		private string GetReference(JsonWriter writer, object value) => default; // 0x00000001892CB16C-0x00000001892CB304
		internal static bool TryConvertToString(object value, System.Type type, [NotNullWhen(true)] [Nullable(2)] out string s) {
			s = default;
			return default;
		} // 0x00000001892CD068-0x00000001892CD138
		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) {} // 0x00000001892CCF38-0x00000001892CCFD0
		private void OnSerializing(JsonWriter writer, JsonContract contract, object value) {} // 0x00000001827B91B0-0x00000001827B9260
		private void OnSerialized(JsonWriter writer, JsonContract contract, object value) {} // 0x00000001827B9370-0x00000001827B9420
		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty) {} // 0x00000001827B9530-0x00000001827BAAA0
		private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, [Nullable(2)] JsonProperty member, JsonProperty property, [NotNullWhen(true)] [Nullable(2)] out JsonContract memberContract, [Nullable(2)] out object memberValue) {
			memberContract = default;
			memberValue = default;
			return default;
		} // 0x00000001827BAAD0-0x00000001827BAD00
		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty) {} // 0x00000001827BB9D0-0x00000001827BBB00
		private bool HasCreatorParameter([Nullable(2)] JsonContainerContract contract, JsonProperty property) => default; // 0x00000001892CB36C-0x00000001892CB3F4
		private void WriteReferenceIdProperty(JsonWriter writer, System.Type type, object value) {} // 0x00000001892CD138-0x00000001892CD2AC
		private void WriteTypeProperty(JsonWriter writer, System.Type type) {} // 0x00000001892CD450-0x00000001892CD5F4
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) => default; // 0x00000001827BAEC0-0x00000001827BAED0
		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) => default; // 0x00000001827BAEC0-0x00000001827BAED0
		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) => default; // 0x0000000182325BB0-0x0000000182325C30
		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty) {} // 0x00000001892CB3F4-0x00000001892CB734
		private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty) {} // 0x00000001827B8270-0x00000001827B91B0
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty) {} // 0x00000001892CCDA8-0x00000001892CCF38
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, [Nullable(2)] JsonProperty member, int initialDepth, int[] indices) {} // 0x00000001892CC9CC-0x00000001892CCDA8
		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract containerContract, [Nullable(2)] JsonProperty containerProperty) => default; // 0x00000001827B8110-0x00000001827B8270
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty) {} // 0x00000001892CC5C8-0x00000001892CC9CC
		private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty) {} // 0x00000001892CB734-0x00000001892CC5C8
		[NullableContext(2)]
		private bool ShouldWriteDynamicProperty(object memberValue) => default; // 0x00000001892CCFD0-0x00000001892CD068
		[NullableContext(2)]
		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, [Nullable(1)] JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) => default; // 0x00000001827BBB00-0x00000001827BBCC0
		private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, [Nullable(2)] JsonProperty member, [Nullable(2)] JsonContainerContract collectionContract, [Nullable(2)] JsonProperty containerProperty) {} // 0x00000001827BECB0-0x00000001827C05A0
		private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) {
			escape = default;
			return default;
		} // 0x00000001827C05A0-0x00000001827C0740
		private void HandleError(JsonWriter writer, int initialDepth) {} // 0x00000001892CB304-0x00000001892CB36C
		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) => default; // 0x00000001827BAD90-0x00000001827BAE20
		private bool IsSpecified(JsonWriter writer, JsonProperty property, object target) => default; // 0x00000001827BAD00-0x00000001827BAD90
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class JsonSerializerProxy : JsonSerializer // TypeDefIndex: 51801
	{
		// Fields
		[Nullable(2)]
		private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
		[Nullable(2)]
		private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
		internal readonly JsonSerializer _serializer; // 0xF0
	
		// Properties
		[Nullable(2)]
		public override IReferenceResolver ReferenceResolver { [NullableContext(2)] set {} } // 0x00000001892DC1CC-0x00000001892DC1F4
		[Nullable(2)]
		public override ITraceWriter TraceWriter { [NullableContext(2)] get => default; [NullableContext(2)] set {} } // 0x00000001892DBF68-0x00000001892DBF8C 0x00000001892DC21C-0x00000001892DC244
		[Nullable(2)]
		public override IEqualityComparer EqualityComparer { [NullableContext(2)] set {} } // 0x00000001892DC08C-0x00000001892DC0B4
		public override JsonConverterCollection Converters { get => default; } // 0x00000001892DBEB8-0x00000001892DBED8 
		public override DefaultValueHandling DefaultValueHandling { set {} } // 0x00000001892DC064-0x00000001892DC08C
		public override IContractResolver ContractResolver { get => default; set {} } // 0x00000001892DBE94-0x00000001892DBEB8 0x00000001892DC03C-0x00000001892DC064
		public override MissingMemberHandling MissingMemberHandling { set {} } // 0x00000001892DC104-0x00000001892DC12C
		public override NullValueHandling NullValueHandling { get => default; set {} } // 0x00000001892DBF44-0x00000001892DBF68 0x00000001892DC12C-0x00000001892DC154
		public override ObjectCreationHandling ObjectCreationHandling { set {} } // 0x00000001892DC154-0x00000001892DC17C
		public override ReferenceLoopHandling ReferenceLoopHandling { set {} } // 0x00000001892DC1A4-0x00000001892DC1CC
		public override PreserveReferencesHandling PreserveReferencesHandling { set {} } // 0x00000001892DC17C-0x00000001892DC1A4
		public override TypeNameHandling TypeNameHandling { set {} } // 0x00000001892DC26C-0x00000001892DC294
		public override MetadataPropertyHandling MetadataPropertyHandling { get => default; set {} } // 0x00000001892DBF20-0x00000001892DBF44 0x00000001892DC0DC-0x00000001892DC104
		public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { set {} } // 0x00000001892DC244-0x00000001892DC26C
		public override ConstructorHandling ConstructorHandling { set {} } // 0x00000001892DBFDC-0x00000001892DC004
		public override ISerializationBinder SerializationBinder { set {} } // 0x00000001892DC1F4-0x00000001892DC21C
		public override StreamingContext Context { get => default; set {} } // 0x00000001892DBE60-0x00000001892DBE94 0x00000001892DC004-0x00000001892DC03C
		public override Newtonsoft.Json.Formatting Formatting { get => default; set {} } // 0x00000001892DBED8-0x00000001892DBEFC 0x00000001892DC0B4-0x00000001892DC0DC
		public override int? MaxDepth { get => default; } // 0x00000001892DBEFC-0x00000001892DBF20 
		public override bool CheckAdditionalContent { get => default; set {} } // 0x00000001892DBE3C-0x00000001892DBE60 0x00000001892DBFB4-0x00000001892DBFDC
	
		// Events
		[Nullable(new byte[2] {2, 1 })]
		public override event EventHandler<ErrorEventArgs> Error;
	
		// Constructors
		public JsonSerializerProxy() {} // Dummy constructor
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader) {} // 0x0000000182695990-0x0000000182695A10
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter) {} // 0x00000001892DBD54-0x00000001892DBE14
	
		// Methods
		internal JsonSerializerInternalBase GetInternalSerializer() => default; // 0x00000001892DBCAC-0x00000001892DBCC8
		[NullableContext(2)]
		internal override object DeserializeInternal([Nullable(1)] JsonReader reader, System.Type objectType) => default; // 0x00000001892DBC60-0x00000001892DBCAC
		internal override void PopulateInternal(JsonReader reader, object target) {} // 0x00000001892DBCC8-0x00000001892DBD0C
		[NullableContext(2)]
		internal override void SerializeInternal([Nullable(1)] JsonWriter jsonWriter, object value, System.Type rootType) {} // 0x00000001892DBD0C-0x00000001892DBD54
	}

	public class JsonStringContract : JsonPrimitiveContract // TypeDefIndex: 51802
	{
		// Constructors
		public JsonStringContract() {} // Dummy constructor
		[NullableContext(1)]
		public JsonStringContract(System.Type underlyingType) {} // 0x0000000183439D30-0x0000000183439DA0
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class JsonTypeReflector // TypeDefIndex: 51805
	{
		// Fields
		private static bool? _fullyTrusted; // 0x00
		[Nullable(new byte[6] {1, 1, 1, 2, 1, 1 })]
		private static readonly ThreadSafeStore<System.Type, Func<object[], object>> CreatorCache; // 0x08
		[Nullable(new byte[3] {1, 1, 2 })]
		private static readonly ThreadSafeStore<System.Type, System.Type> AssociatedMetadataTypesCache; // 0x10
		[Nullable(2)]
		private static ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18
	
		// Properties
		public static bool FullyTrusted { get; } // 0x00000001892DC7C8-0x00000001892DC888 
		public static ReflectionDelegateFactory ReflectionDelegateFactory { get; } // 0x0000000182476090-0x0000000182476130 
	
		// Constructors
		static JsonTypeReflector() {} // 0x00000001838CEC10-0x00000001838CEDA0
	
		// Methods
		public static T GetCachedAttribute<T>(object attributeProvider)
			where T : Attribute => default;
		public static bool CanTypeDescriptorConvertString(System.Type type, out TypeConverter typeConverter) {
			typeConverter = default;
			return default;
		} // 0x00000001825E6FD0-0x00000001825E7180
		public static DataContractAttribute GetDataContractAttribute(System.Type type) => default; // 0x00000001824E7560-0x00000001824E7600
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) => default; // 0x00000001892DC5AC-0x00000001892DC76C
		public static MemberSerialization GetObjectMemberSerialization(System.Type objectType, bool ignoreSerializableAttribute) => default; // 0x000000018283DEE0-0x000000018283DF90
		public static JsonConverter GetJsonConverter(object attributeProvider) => default; // 0x00000001824E71C0-0x00000001824E7250
		public static JsonConverter CreateJsonConverterInstance(System.Type converterType, [Nullable(new byte[2] {2, 1 })] object[] args) => default; // 0x00000001892DC294-0x00000001892DC33C
		public static NamingStrategy CreateNamingStrategyInstance(System.Type namingStrategyType, [Nullable(new byte[2] {2, 1 })] object[] args) => default; // 0x00000001892DC33C-0x00000001892DC3E4
		public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute) => default; // 0x00000001892DC3E4-0x00000001892DC48C
		private static Func<object[], object> GetCreator(System.Type type) => default; // 0x00000001892DC48C-0x00000001892DC5AC
		private static System.Type GetAssociatedMetadataType(System.Type type) => default; // 0x0000000182303720-0x0000000182303C10
		private static System.Type GetAssociateMetadataTypeFromAttribute(System.Type type) => default; // 0x00000001830ED130-0x00000001830ED270
		private static T GetAttribute<T>(System.Type type)
			where T : Attribute => default;
		private static T GetAttribute<T>(MemberInfo memberInfo)
			where T : Attribute => default;
		public static bool IsNonSerializable(object provider) => default; // 0x0000000183132B60-0x0000000183132BD0
		public static bool IsSerializable(object provider) => default; // 0x00000001892DC76C-0x00000001892DC7C8
		public static T GetAttribute<T>(object provider)
			where T : Attribute => default;
	}

	public class KebabCaseNamingStrategy : NamingStrategy // TypeDefIndex: 51806
	{
		// Constructors
		public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames) {} // 0x0000000183D714A0-0x0000000183D714B0
		public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) {} // 0x0000000183D71490-0x0000000183D714A0
		public KebabCaseNamingStrategy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[NullableContext(1)]
		protected override string ResolvePropertyName(string name) => default; // 0x00000001892DC888-0x00000001892DC894
	}

	[Nullable(0)]
	[NullableContext(1)]
	public abstract class NamingStrategy // TypeDefIndex: 51807
	{
		// Properties
		public bool ProcessDictionaryKeys { get; set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
		public bool ProcessExtensionDataNames { get; set; } // 0x0000000183D510E0-0x0000000183D510F0 0x0000000183D510F0-0x0000000183D51100
		public bool OverrideSpecifiedNames { get; set; } // 0x0000000183D519E0-0x0000000183D519F0 0x0000000183D6B770-0x0000000183D6B780
	
		// Constructors
		protected NamingStrategy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual string GetPropertyName(string name, bool hasSpecifiedName) => default; // 0x00000001892DCA80-0x00000001892DCAA4
		public virtual string GetExtensionDataName(string name) => default; // 0x00000001892DC9A8-0x00000001892DC9D0
		public virtual string GetDictionaryKey(string key) => default; // 0x00000001892DC980-0x00000001892DC9A8
		protected abstract string ResolvePropertyName(string name);
		public override int GetHashCode() => default; // 0x00000001892DC9D0-0x00000001892DCA80
		[NullableContext(2)]
		public override bool Equals(object obj) => default; // 0x00000001892DC92C-0x00000001892DC980
		[NullableContext(2)]
		protected bool Equals(NamingStrategy other) => default; // 0x00000001892DC894-0x00000001892DC92C
	}

	public delegate object ObjectConstructor<T>(params [Nullable(new byte[2] {1, 2 })] object[] args); // TypeDefIndex: 51808; 0x00000000-0x00000000

	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class OnErrorAttribute : Attribute // TypeDefIndex: 51809
	{
		// Constructors
		public OnErrorAttribute() {} // Dummy constructor
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class ReflectionAttributeProvider : IAttributeProvider // TypeDefIndex: 51810
	{
		// Fields
		private readonly object _attributeProvider; // 0x10
	
		// Constructors
		public ReflectionAttributeProvider() {} // Dummy constructor
		public ReflectionAttributeProvider(object attributeProvider) {} // 0x00000001824E5C10-0x00000001824E5C60
	}

	[Nullable(0)]
	[NullableContext(1)]
	public class ReflectionValueProvider : IValueProvider // TypeDefIndex: 51811
	{
		// Fields
		private readonly MemberInfo _memberInfo; // 0x10
	
		// Constructors
		public ReflectionValueProvider() {} // Dummy constructor
		public ReflectionValueProvider(MemberInfo memberInfo) {} // 0x00000001824E5BC0-0x00000001824E5C10
	
		// Methods
		public void SetValue(object target, [Nullable(2)] object value) {} // 0x0000000182325C30-0x0000000182325F00
		public object GetValue(object target) => default; // 0x000000018232C920-0x000000018232CBA0
	}

	public class SnakeCaseNamingStrategy : NamingStrategy // TypeDefIndex: 51812
	{
		// Constructors
		public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames) {} // 0x0000000183D714A0-0x0000000183D714B0
		public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) {} // 0x0000000183D71490-0x0000000183D714A0
		public SnakeCaseNamingStrategy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[NullableContext(1)]
		protected override string ResolvePropertyName(string name) => default; // 0x00000001892DCAA4-0x00000001892DCAB0
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class TraceJsonReader : JsonReader, IJsonLineInfo // TypeDefIndex: 51813
	{
		// Fields
		private readonly JsonReader _innerReader; // 0x78
		private readonly JsonTextWriter _textWriter; // 0x80
		private readonly StringWriter _sw; // 0x88
	
		// Properties
		public override int Depth { get => default; } // 0x00000001892DD008-0x00000001892DD02C 
		public override string Path { get => default; } // 0x00000001892DD02C-0x00000001892DD050 
		public override JsonToken TokenType { get => default; } // 0x00000001892DD050-0x00000001892DD074 
		[Nullable(2)]
		public override object Value { [NullableContext(2)] get => default; } // 0x00000001892DD098-0x00000001892DD0BC 
		[Nullable(2)]
		public override System.Type ValueType { [NullableContext(2)] get => default; } // 0x00000001892DD074-0x00000001892DD098 
		int IJsonLineInfo.LineNumber { get => default; } // 0x00000001892DCB48-0x00000001892DCB98 
		int IJsonLineInfo.LinePosition { get => default; } // 0x00000001892DCB98-0x00000001892DCBE8 
	
		// Constructors
		public TraceJsonReader() {} // Dummy constructor
		public TraceJsonReader(JsonReader innerReader) {} // 0x00000001892DCEB0-0x00000001892DD008
	
		// Methods
		public string GetDeserializedJsonMessage() => default; // 0x00000001892DCAD4-0x00000001892DCAF8
		public override bool Read() => default; // 0x00000001892DCE38-0x00000001892DCE7C
		public override int? ReadAsInt32() => default; // 0x00000001892DCDB0-0x00000001892DCDF4
		[NullableContext(2)]
		public override string ReadAsString() => default; // 0x00000001892DCDF4-0x00000001892DCE38
		[NullableContext(2)]
		public override byte[] ReadAsBytes() => default; // 0x00000001892DCC2C-0x00000001892DCC70
		public override decimal? ReadAsDecimal() => default; // 0x00000001892DCD0C-0x00000001892DCD60
		public override double? ReadAsDouble() => default; // 0x00000001892DCD60-0x00000001892DCDB0
		public override bool? ReadAsBoolean() => default; // 0x00000001892DCBE8-0x00000001892DCC2C
		public override System.DateTime? ReadAsDateTime() => default; // 0x00000001892DCCC4-0x00000001892DCD0C
		public override DateTimeOffset? ReadAsDateTimeOffset() => default; // 0x00000001892DCC70-0x00000001892DCCC4
		public void WriteCurrentToken() {} // 0x00000001892DCE7C-0x00000001892DCEB0
		public override void Close() {} // 0x00000001892DCAB0-0x00000001892DCAD4
		bool IJsonLineInfo.HasLineInfo() => default; // 0x00000001892DCAF8-0x00000001892DCB48
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 51814
	{
		// Fields
		private readonly JsonWriter _innerWriter; // 0x60
		private readonly JsonTextWriter _textWriter; // 0x68
		private readonly StringWriter _sw; // 0x70
	
		// Constructors
		public TraceJsonWriter() {} // Dummy constructor
		public TraceJsonWriter(JsonWriter innerWriter) {} // 0x00000001892DE82C-0x00000001892DEA24
	
		// Methods
		public string GetSerializedJsonMessage() => default; // 0x00000001892DD100-0x00000001892DD124
		public override void WriteValue(decimal value) {} // 0x00000001892DD878-0x00000001892DD8F4
		public override void WriteValue(decimal? value) {} // 0x00000001892DDAC8-0x00000001892DDB88
		public override void WriteValue(bool value) {} // 0x00000001892DDA6C-0x00000001892DDAC8
		public override void WriteValue(bool? value) {} // 0x00000001892DDCA4-0x00000001892DDD3C
		public override void WriteValue(byte value) {} // 0x00000001892DD608-0x00000001892DD664
		public override void WriteValue(byte? value) {} // 0x00000001892DDF74-0x00000001892DE004
		public override void WriteValue(char value) {} // 0x00000001892DDC48-0x00000001892DDCA4
		public override void WriteValue(char? value) {} // 0x00000001892DE004-0x00000001892DE090
		[NullableContext(2)]
		public override void WriteValue(byte[] value) {} // 0x00000001892DE6CC-0x00000001892DE738
		public override void WriteValue(System.DateTime value) {} // 0x00000001892DE4D4-0x00000001892DE530
		public override void WriteValue(System.DateTime? value) {} // 0x00000001892DD664-0x00000001892DD704
		public override void WriteValue(DateTimeOffset value) {} // 0x00000001892DD8F4-0x00000001892DD968
		public override void WriteValue(DateTimeOffset? value) {} // 0x00000001892DDB88-0x00000001892DDC48
		public override void WriteValue(double value) {} // 0x00000001892DD968-0x00000001892DD9C4
		public override void WriteValue(double? value) {} // 0x00000001892DDE24-0x00000001892DDED0
		public override void WriteUndefined() {} // 0x00000001892DD4DC-0x00000001892DD520
		public override void WriteNull() {} // 0x00000001892DD24C-0x00000001892DD290
		public override void WriteValue(float value) {} // 0x00000001892DE238-0x00000001892DE294
		public override void WriteValue(float? value) {} // 0x00000001892DE5D8-0x00000001892DE670
		public override void WriteValue(Guid value) {} // 0x00000001892DE130-0x00000001892DE1A4
		public override void WriteValue(Guid? value) {} // 0x00000001892DE294-0x00000001892DE34C
		public override void WriteValue(int value) {} // 0x00000001892DD820-0x00000001892DD878
		public override void WriteValue(int? value) {} // 0x00000001892DD520-0x00000001892DD5B8
		public override void WriteValue(long value) {} // 0x00000001892DE3A4-0x00000001892DE400
		public override void WriteValue(long? value) {} // 0x00000001892DD9C4-0x00000001892DDA6C
		[NullableContext(2)]
		public override void WriteValue(object value) {} // 0x00000001892DE400-0x00000001892DE4D4
		public override void WriteValue(sbyte value) {} // 0x00000001892DD5B8-0x00000001892DD608
		public override void WriteValue(sbyte? value) {} // 0x00000001892DD704-0x00000001892DD794
		public override void WriteValue(short value) {} // 0x00000001892DE738-0x00000001892DE794
		public override void WriteValue(short? value) {} // 0x00000001892DD794-0x00000001892DD820
		[NullableContext(2)]
		public override void WriteValue(string value) {} // 0x00000001892DDDC8-0x00000001892DDE24
		public override void WriteValue(TimeSpan value) {} // 0x00000001892DDED0-0x00000001892DDF20
		public override void WriteValue(TimeSpan? value) {} // 0x00000001892DE090-0x00000001892DE130
		public override void WriteValue(uint value) {} // 0x00000001892DE34C-0x00000001892DE3A4
		public override void WriteValue(uint? value) {} // 0x00000001892DE794-0x00000001892DE82C
		public override void WriteValue(ulong value) {} // 0x00000001892DE670-0x00000001892DE6CC
		public override void WriteValue(ulong? value) {} // 0x00000001892DE530-0x00000001892DE5D8
		[NullableContext(2)]
		public override void WriteValue(System.Uri value) {} // 0x00000001892DE1A4-0x00000001892DE238
		public override void WriteValue(ushort value) {} // 0x00000001892DDF20-0x00000001892DDF74
		public override void WriteValue(ushort? value) {} // 0x00000001892DDD3C-0x00000001892DDDC8
		[NullableContext(2)]
		public override void WriteComment(string text) {} // 0x00000001892DD124-0x00000001892DD180
		public override void WriteStartArray() {} // 0x00000001892DD3F8-0x00000001892DD43C
		public override void WriteEndArray() {} // 0x00000001892DD180-0x00000001892DD1C4
		public override void WriteStartConstructor(string name) {} // 0x00000001892DD43C-0x00000001892DD498
		public override void WriteEndConstructor() {} // 0x00000001892DD1C4-0x00000001892DD208
		public override void WritePropertyName(string name) {} // 0x00000001892DD290-0x00000001892DD2EC
		public override void WritePropertyName(string name, bool escape) {} // 0x00000001892DD2EC-0x00000001892DD350
		public override void WriteStartObject() {} // 0x00000001892DD498-0x00000001892DD4DC
		public override void WriteEndObject() {} // 0x00000001892DD208-0x00000001892DD24C
		[NullableContext(2)]
		public override void WriteRawValue(string json) {} // 0x00000001892DD350-0x00000001892DD3AC
		[NullableContext(2)]
		public override void WriteRaw(string json) {} // 0x00000001892DD3AC-0x00000001892DD3F8
		public override void Close() {} // 0x00000001892DD0BC-0x00000001892DD100
	}
}

namespace Newtonsoft.Json.Utilities
{
	[Nullable(0)]
	[NullableContext(2)]
	public static class AotHelper // TypeDefIndex: 51657
	{
		// Fields
		private static bool s_alwaysFalse; // 0x00
	
		// Constructors
		static AotHelper() {} // 0x0000000183CF5C20-0x0000000183CF5CD0
	
		// Methods
		[NullableContext(1)]
		public static void Ensure(Action action) {} // 0x0000000183A28210-0x0000000183A282A0
		public static void EnsureList<T>() {}
		public static bool IsFalse() => default; // 0x00000001892B8530-0x00000001892B8580
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class Base64Encoder // TypeDefIndex: 51658
	{
		// Fields
		private readonly char[] _charsLine; // 0x10
		private readonly TextWriter _writer; // 0x18
		[Nullable(2)]
		private byte[] _leftOverBytes; // 0x20
		private int _leftOverBytesCount; // 0x28
	
		// Constructors
		public Base64Encoder() {} // Dummy constructor
		public Base64Encoder(TextWriter writer) {} // 0x00000001892B8AA8-0x00000001892B8B6C
	
		// Methods
		private void ValidateEncode(byte[] buffer, int index, int count) {} // 0x00000001892B8900-0x00000001892B8A78
		public void Encode(byte[] buffer, int index, int count) {} // 0x00000001892B8580-0x00000001892B86EC
		private void StoreLeftOverBytes(byte[] buffer, int index, ref int count) {} // 0x00000001892B8818-0x00000001892B8900
		private bool FulfillFromLeftover(byte[] buffer, int index, ref int count) => default; // 0x00000001892B8788-0x00000001892B8818
		public void Flush() {} // 0x00000001892B86EC-0x00000001892B8788
		private void WriteChars(char[] chars, int index, int count) {} // 0x00000001892B8A78-0x00000001892B8AA8
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class BidirectionalDictionary<TFirst, TSecond> // TypeDefIndex: 51659
	{
		// Fields
		private readonly IDictionary<TFirst, TSecond> _firstToSecond;
		private readonly IDictionary<TSecond, TFirst> _secondToFirst;
		private readonly string _duplicateFirstErrorMessage;
		private readonly string _duplicateSecondErrorMessage;
	
		// Constructors
		public BidirectionalDictionary() {} // Dummy constructor
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage) {}
	
		// Methods
		public void Set(TFirst first, TSecond second) {}
		public bool TryGetByFirst(TFirst first, [Nullable(2)] [NotNullWhen(true)] out ref TSecond second) {
			second = default;
			return default;
		}
		public bool TryGetBySecond(TSecond second, [Nullable(2)] [NotNullWhen(true)] out ref TFirst first) {
			first = default;
			return default;
		}
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class BoxedPrimitives // TypeDefIndex: 51660
	{
		// Fields
		internal static readonly object BooleanTrue; // 0x00
		internal static readonly object BooleanFalse; // 0x08
		internal static readonly object Int32_M1; // 0x10
		internal static readonly object Int32_0; // 0x18
		internal static readonly object Int32_1; // 0x20
		internal static readonly object Int32_2; // 0x28
		internal static readonly object Int32_3; // 0x30
		internal static readonly object Int32_4; // 0x38
		internal static readonly object Int32_5; // 0x40
		internal static readonly object Int32_6; // 0x48
		internal static readonly object Int32_7; // 0x50
		internal static readonly object Int32_8; // 0x58
		internal static readonly object Int64_M1; // 0x60
		internal static readonly object Int64_0; // 0x68
		internal static readonly object Int64_1; // 0x70
		internal static readonly object Int64_2; // 0x78
		internal static readonly object Int64_3; // 0x80
		internal static readonly object Int64_4; // 0x88
		internal static readonly object Int64_5; // 0x90
		internal static readonly object Int64_6; // 0x98
		internal static readonly object Int64_7; // 0xA0
		internal static readonly object Int64_8; // 0xA8
		private static readonly object DecimalZero; // 0xB0
		internal static readonly object DoubleNaN; // 0xB8
		internal static readonly object DoublePositiveInfinity; // 0xC0
		internal static readonly object DoubleNegativeInfinity; // 0xC8
		internal static readonly object DoubleZero; // 0xD0
	
		// Constructors
		static BoxedPrimitives() {} // 0x0000000182C2B4A0-0x0000000182C2BC50
	
		// Methods
		internal static object Get(bool value) => default; // 0x00000001824ED670-0x00000001824ED700
		internal static object Get(int value) => default; // 0x00000001824E3FE0-0x00000001824E42C0
		internal static object Get(long value) => default; // 0x00000001824E3CF0-0x00000001824E3FE0
		internal static object Get(decimal value) => default; // 0x00000001892B9634-0x00000001892B96EC
		internal static object Get(double value) => default; // 0x0000000182E869B0-0x0000000182E86AF0
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class CollectionUtils // TypeDefIndex: 51662
	{
		// Nested types
		[NullableContext(0)]
		private static class EmptyArrayContainer<T> // TypeDefIndex: 51661
		{
			// Fields
			[Nullable(1)]
			public static readonly T[] Empty;
	
			// Constructors
			static EmptyArrayContainer() {}
		}
	
		// Methods
		public static bool IsNullOrEmpty<T>(ICollection<T> collection) => default;
		public static bool IsDictionaryType(System.Type type) => default; // 0x0000000182477E60-0x0000000182478010
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType) => default; // 0x000000018308DFC0-0x000000018308E0C0
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType, System.Type constructorArgumentType) => default; // 0x000000018308E930-0x000000018308EB80
		private static IList<int> GetDimensions(IList values, int dimensionsCount) => default; // 0x00000001892B994C-0x00000001892B9A50
		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) {} // 0x00000001892B9778-0x00000001892B994C
		private static object JaggedArrayGetValue(IList values, int[] indices) => default; // 0x00000001892B9A50-0x00000001892B9AEC
		public static Array ToMultidimensionalArray(IList values, System.Type type, int rank) => default; // 0x00000001892B9AEC-0x00000001892B9BE0
		public static T[] ArrayEmpty<T>() => default;
	
		// Extension methods
		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection) {}
		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate) => default;
		public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer) => default;
		public static int IndexOfReference<T>(this List<T> list, T item) => default;
		public static void FastReverse<T>(this List<T> list) {}
	}

	internal interface IWrappedCollection : IList // TypeDefIndex: 51663
	{
		// Properties
		[Nullable(1)]
		object UnderlyingCollection { [NullableContext(1)] get; }
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class CollectionWrapper<T> : ICollection<T>, IWrappedCollection // TypeDefIndex: 51664
	{
		// Fields
		[Nullable(2)]
		private readonly IList _list;
		[Nullable(new byte[2] {2, 1 })]
		private readonly ICollection<T> _genericCollection;
		[Nullable(2)]
		private object _syncRoot;
	
		// Properties
		public virtual int Count { get => default; }
		public virtual bool IsReadOnly { get => default; }
		bool IList.IsFixedSize { get => default; }
		[Nullable(2)]
		object IList.this[int index] { [NullableContext(2)] get => default; [NullableContext(2)] set {} }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
		public object UnderlyingCollection { get => default; }
	
		// Constructors
		public CollectionWrapper() {} // Dummy constructor
		public CollectionWrapper(IList list) {}
		public CollectionWrapper(ICollection<T> list) {}
	
		// Methods
		public virtual void Add(T item) {}
		public virtual void Clear() {}
		public virtual bool Contains(T item) => default;
		public virtual void CopyTo(T[] array, int arrayIndex) {}
		public virtual bool Remove(T item) => default;
		public virtual IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		[NullableContext(2)]
		int IList.Add(object value) => default;
		[NullableContext(2)]
		bool IList.Contains(object value) => default;
		[NullableContext(2)]
		int IList.IndexOf(object value) => default;
		void IList.RemoveAt(int index) {}
		[NullableContext(2)]
		void IList.Insert(int index, object value) {}
		[NullableContext(2)]
		void IList.Remove(object value) {}
		void ICollection.CopyTo(Array array, int arrayIndex) {}
		[NullableContext(2)]
		private static void VerifyValueType(object value) {}
		[NullableContext(2)]
		private static bool IsCompatibleObject(object value) => default;
	}

	internal enum PrimitiveTypeCode // TypeDefIndex: 51665
	{
		Empty = 0,
		Object = 1,
		Char = 2,
		CharNullable = 3,
		Boolean = 4,
		BooleanNullable = 5,
		SByte = 6,
		SByteNullable = 7,
		Int16 = 8,
		Int16Nullable = 9,
		UInt16 = 10,
		UInt16Nullable = 11,
		Int32 = 12,
		Int32Nullable = 13,
		Byte = 14,
		ByteNullable = 15,
		UInt32 = 16,
		UInt32Nullable = 17,
		Int64 = 18,
		Int64Nullable = 19,
		UInt64 = 20,
		UInt64Nullable = 21,
		Single = 22,
		SingleNullable = 23,
		Double = 24,
		DoubleNullable = 25,
		DateTime = 26,
		DateTimeNullable = 27,
		DateTimeOffset = 28,
		DateTimeOffsetNullable = 29,
		Decimal = 30,
		DecimalNullable = 31,
		Guid = 32,
		GuidNullable = 33,
		TimeSpan = 34,
		TimeSpanNullable = 35,
		BigInteger = 36,
		BigIntegerNullable = 37,
		Uri = 38,
		String = 39,
		Bytes = 40,
		DBNull = 41
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class TypeInformation // TypeDefIndex: 51666
	{
		// Properties
		public System.Type Type { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public PrimitiveTypeCode TypeCode { get; } // 0x00000001820D1AC0-0x00000001820D1AD0 
	
		// Constructors
		public TypeInformation() {} // Dummy constructor
		public TypeInformation(System.Type type, PrimitiveTypeCode typeCode) {} // 0x0000000182738A30-0x0000000182738A50
	}

	internal enum ParseResult // TypeDefIndex: 51667
	{
		None = 0,
		Success = 1,
		Overflow = 2,
		Invalid = 3
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class ConvertUtils // TypeDefIndex: 51670
	{
		// Fields
		private static readonly Dictionary<System.Type, PrimitiveTypeCode> TypeCodeMap; // 0x00
		private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x08
		[Nullable(new byte[7] {1, 0, 1, 1, 2, 2, 2 })]
		private static readonly ThreadSafeStore<StructMultiKey<System.Type, System.Type>, Func<object, object>> CastConverters; // 0x10
	
		// Nested types
		[NullableContext(0)]
		internal enum ConvertResult // TypeDefIndex: 51668
		{
			Success = 0,
			CannotConvertNull = 1,
			NotInstantiableType = 2,
			NoValidConversion = 3
		}
	
		// Constructors
		static ConvertUtils() {} // 0x00000001835D3A50-0x00000001835D4AA0
	
		// Methods
		public static PrimitiveTypeCode GetTypeCode(System.Type t) => default; // 0x0000000182476D60-0x0000000182476FF0
		public static PrimitiveTypeCode GetTypeCode(System.Type t, out bool isEnum) {
			isEnum = default;
			return default;
		} // 0x0000000182476FF0-0x0000000182477240
		public static TypeInformation GetTypeInformation(IConvertible convertable) => default; // 0x00000001892BAE94-0x00000001892BAF10
		public static bool IsConvertible(System.Type t) => default; // 0x00000001824769F0-0x0000000182476A80
		public static TimeSpan ParseTimeSpan(string input) => default; // 0x00000001892BAF10-0x00000001892BAF80
		[NullableContext(2)]
		private static Func<object, object> CreateCastConverter([Nullable(new byte[3] {0, 1, 1 })] StructMultiKey<System.Type, System.Type> t) => default; // 0x00000001892B9E98-0x00000001892BA058
		internal static BigInteger ToBigInteger(object value) => default; // 0x00000001892BAF80-0x00000001892BB2F0
		public static object FromBigInteger(BigInteger i, System.Type targetType) => default; // 0x00000001892BAA54-0x00000001892BAE94
		public static object Convert(object initialValue, CultureInfo culture, System.Type targetType) => default; // 0x00000001892B9BE0-0x00000001892B9E98
		private static bool TryConvert([Nullable(2)] object initialValue, CultureInfo culture, System.Type targetType, [Nullable(2)] out object value) {
			value = default;
			return default;
		} // 0x00000001892BBB60-0x00000001892BBC60
		private static ConvertResult TryConvertInternal([Nullable(2)] object initialValue, CultureInfo culture, System.Type targetType, [Nullable(2)] out object value) {
			value = default;
			return default;
		} // 0x00000001892BB33C-0x00000001892BBB60
		public static object ConvertOrCast([Nullable(2)] object initialValue, CultureInfo culture, System.Type targetType) => default; // 0x0000000183CEDFA0-0x0000000183CEE050
		private static object EnsureTypeAssignable([Nullable(2)] object value, System.Type initialType, System.Type targetType) => default; // 0x00000001892BA844-0x00000001892BAA54
		public static bool VersionTryParse(string input, [Nullable(2)] [NotNullWhen(true)] out System.Version result) {
			result = default;
			return default;
		} // 0x00000001892BBCF8-0x00000001892BBD00
		public static bool IsInteger(object value) => default; // 0x0000000182476C90-0x0000000182476D60
		public static Newtonsoft.Json.Utilities.ParseResult Int32TryParse(char[] chars, int start, int length, out int value) {
			value = default;
			return default;
		} // 0x0000000182BAF140-0x0000000182BAF230
		public static Newtonsoft.Json.Utilities.ParseResult Int64TryParse(char[] chars, int start, int length, out long value) {
			value = default;
			return default;
		} // 0x0000000182B390D0-0x0000000182B391C0
		public static Newtonsoft.Json.Utilities.ParseResult DecimalTryParse(char[] chars, int start, int length, out decimal value) {
			value = default;
			return default;
		} // 0x00000001892BA058-0x00000001892BA844
		public static bool TryConvertGuid(string s, out Guid g) {
			g = default;
			return default;
		} // 0x00000001892BB2F0-0x00000001892BB33C
		public static bool TryHexTextToInt(char[] text, int start, int end, out int value) {
			value = default;
			return default;
		} // 0x00000001892BBC60-0x00000001892BBCF8
	}

	internal enum ParserTimeZone // TypeDefIndex: 51671
	{
		Unspecified = 0,
		Utc = 1,
		LocalWestOfUtc = 2,
		LocalEastOfUtc = 3
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal struct DateTimeParser // TypeDefIndex: 51672
	{
		// Fields
		public int Year; // 0x00
		public int Month; // 0x04
		public int Day; // 0x08
		public int Hour; // 0x0C
		public int Minute; // 0x10
		public int Second; // 0x14
		public int Fraction; // 0x18
		public int ZoneHour; // 0x1C
		public int ZoneMinute; // 0x20
		public ParserTimeZone Zone; // 0x24
		private char[] _text; // 0x28
		private int _end; // 0x30
		private static readonly int[] Power10; // 0x00
		private static readonly int Lzyyyy; // 0x08
		private static readonly int Lzyyyy_; // 0x0C
		private static readonly int Lzyyyy_MM; // 0x10
		private static readonly int Lzyyyy_MM_; // 0x14
		private static readonly int Lzyyyy_MM_dd; // 0x18
		private static readonly int Lzyyyy_MM_ddT; // 0x1C
		private static readonly int LzHH; // 0x20
		private static readonly int LzHH_; // 0x24
		private static readonly int LzHH_mm; // 0x28
		private static readonly int LzHH_mm_; // 0x2C
		private static readonly int LzHH_mm_ss; // 0x30
		private static readonly int Lz_; // 0x34
		private static readonly int Lz_zz; // 0x38
	
		// Constructors
		static DateTimeParser() {
			Power10 = default;
			Lzyyyy = default;
			Lzyyyy_ = default;
			Lzyyyy_MM = default;
			Lzyyyy_MM_ = default;
			Lzyyyy_MM_dd = default;
			Lzyyyy_MM_ddT = default;
			LzHH = default;
			LzHH_ = default;
			LzHH_mm = default;
			LzHH_mm_ = default;
			LzHH_mm_ss = default;
			Lz_ = default;
			Lz_zz = default;
		} // 0x00000001892BC54C-0x00000001892BC844
	
		// Methods
		public bool Parse(char[] text, int startIndex, int length) => default; // 0x00000001892BC460-0x00000001892BC54C
		private bool ParseDate(int start) => default; // 0x00000001892BBE74-0x00000001892BC004
		private bool ParseTimeAndZoneAndWhitespace(int start) => default; // 0x00000001892BC004-0x00000001892BC074
		private bool ParseTime(ref int start) => default; // 0x00000001892BC074-0x00000001892BC2F4
		private bool ParseZone(int start) => default; // 0x00000001892BC2F4-0x00000001892BC460
		private bool Parse4Digit(int start, out int num) {
			num = default;
			return default;
		} // 0x00000001892BBD70-0x00000001892BBE3C
		private bool Parse2Digit(int start, out int num) {
			num = default;
			return default;
		} // 0x00000001892BBD00-0x00000001892BBD70
		private bool ParseChar(int start, char ch) => default; // 0x00000001892BBE3C-0x00000001892BBE74
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class DateTimeUtils // TypeDefIndex: 51673
	{
		// Fields
		internal static readonly long InitialJavaScriptDateTicks; // 0x00
		private static readonly int[] DaysToMonth365; // 0x08
		private static readonly int[] DaysToMonth366; // 0x10
	
		// Constructors
		static DateTimeUtils() {} // 0x0000000182562620-0x0000000182562730
	
		// Methods
		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) => default; // 0x00000001892BD044-0x00000001892BD0E0
		internal static System.DateTime EnsureDateTime(System.DateTime value, DateTimeZoneHandling timeZone) => default; // 0x00000001892BCBB8-0x00000001892BCCD8
		private static System.DateTime SwitchToLocalTime(System.DateTime value) => default; // 0x00000001892BCEEC-0x00000001892BCF98
		private static System.DateTime SwitchToUtcTime(System.DateTime value) => default; // 0x00000001892BCF98-0x00000001892BD044
		private static long ToUniversalTicks(System.DateTime dateTime) => default; // 0x00000001892BD20C-0x00000001892BD2A8
		private static long ToUniversalTicks(System.DateTime dateTime, TimeSpan offset) => default; // 0x00000001892BD0E0-0x00000001892BD20C
		internal static long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, TimeSpan offset) => default; // 0x00000001892BC844-0x00000001892BC8A0
		internal static long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime) => default; // 0x00000001892BC8A0-0x00000001892BC8EC
		internal static long ConvertDateTimeToJavaScriptTicks(System.DateTime dateTime, bool convertToUtc) => default; // 0x00000001892BC8EC-0x00000001892BC984
		private static long UniversalTicksToJavaScriptTicks(long universalTicks) => default; // 0x00000001892BE694-0x00000001892BE6F8
		internal static System.DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) => default; // 0x00000001892BC984-0x00000001892BC9F0
		internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out System.DateTime dt) {
			dt = default;
			return default;
		} // 0x00000001892BD374-0x00000001892BD784
		internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) {
			dt = default;
			return default;
		} // 0x00000001892BD954-0x00000001892BDBA8
		private static System.DateTime CreateDateTime(DateTimeParser dateTimeParser) => default; // 0x00000001892BCA7C-0x00000001892BCBB8
		internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, [Nullable(2)] string dateFormatString, CultureInfo culture, out System.DateTime dt) {
			dt = default;
			return default;
		} // 0x0000000182906190-0x00000001829062E0
		internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, [Nullable(2)] string dateFormatString, CultureInfo culture, out System.DateTime dt) {
			dt = default;
			return default;
		} // 0x00000001892BE15C-0x00000001892BE3E0
		internal static bool TryParseDateTimeOffset(StringReference s, [Nullable(2)] string dateFormatString, CultureInfo culture, out DateTimeOffset dt) {
			dt = default;
			return default;
		} // 0x00000001892BDCD0-0x00000001892BDEB4
		internal static bool TryParseDateTimeOffset(string s, [Nullable(2)] string dateFormatString, CultureInfo culture, out DateTimeOffset dt) {
			dt = default;
			return default;
		} // 0x00000001892BDEB4-0x00000001892BE15C
		private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) {
			ticks = default;
			offset = default;
			kind = default;
			return default;
		} // 0x00000001892BE3E0-0x00000001892BE550
		private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out System.DateTime dt) {
			dt = default;
			return default;
		} // 0x00000001892BD784-0x00000001892BD8B4
		private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out System.DateTime dt) {
			dt = default;
			return default;
		} // 0x00000001892BD2A8-0x00000001892BD374
		private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) {
			dt = default;
			return default;
		} // 0x00000001892BDBA8-0x00000001892BDCD0
		private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) {
			dt = default;
			return default;
		} // 0x00000001892BD8B4-0x00000001892BD954
		private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) {
			offset = default;
			return default;
		} // 0x00000001892BE550-0x00000001892BE694
		internal static void WriteDateTimeString(TextWriter writer, System.DateTime value, DateFormatHandling format, [Nullable(2)] string formatString, CultureInfo culture) {} // 0x00000001892BEA5C-0x00000001892BEBB0
		internal static int WriteDateTimeString(char[] chars, int start, System.DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format) => default; // 0x00000001892BEBB0-0x00000001892BEEA0
		internal static int WriteDefaultIsoDate(char[] chars, int start, System.DateTime dt) => default; // 0x00000001892BEEA0-0x00000001892BF134
		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits) {} // 0x00000001892BC9F0-0x00000001892BCA7C
		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format) => default; // 0x00000001892BE888-0x00000001892BEA5C
		internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, [Nullable(2)] string formatString, CultureInfo culture) {} // 0x00000001892BE6F8-0x00000001892BE888
		private static void GetDateValues(System.DateTime td, out int year, out int month, out int day) {
			year = default;
			month = default;
			day = default;
		} // 0x00000001892BCCD8-0x00000001892BCE94
	
		// Extension methods
		public static TimeSpan GetUtcOffset(this System.DateTime d) => default; // 0x00000001892BCE94-0x00000001892BCEEC
	}

	internal interface IWrappedDictionary : IDictionary // TypeDefIndex: 51674
	{
		// Properties
		[Nullable(1)]
		object UnderlyingDictionary { [NullableContext(1)] get; }
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, IWrappedDictionary // TypeDefIndex: 51677
	{
		// Fields
		[Nullable(2)]
		private readonly IDictionary _dictionary;
		[Nullable(new byte[3] {2, 1, 1 })]
		private readonly IDictionary<TKey, TValue> _genericDictionary;
		[Nullable(new byte[3] {2, 1, 1 })]
		private readonly IReadOnlyDictionary<TKey, TValue> _readOnlyDictionary;
		[Nullable(2)]
		private object _syncRoot;
	
		// Properties
		internal IDictionary<TKey, TValue> GenericDictionary { get => default; }
		public ICollection<TKey> Keys { get => default; }
		public ICollection<TValue> Values { get => default; }
		public TValue this[TKey key] { get => default; set {} }
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
		[Nullable(2)]
		object IDictionary.this[object key] { get => default; set {} }
		bool IDictionary.IsFixedSize { get => default; }
		ICollection IDictionary.Keys { get => default; }
		ICollection IDictionary.Values { get => default; }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
		public object UnderlyingDictionary { get => default; }
	
		// Nested types
		[IsReadOnly]
		[Nullable(0)]
		private struct DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue> : IDictionaryEnumerator // TypeDefIndex: 51675
		{
			// Fields
			[Nullable(new byte[4] {1, 0, 1, 1 })]
			private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;
	
			// Properties
			public DictionaryEntry Entry { get => default; }
			public object Key { get => default; }
			[Nullable(2)]
			public object Value { [NullableContext(2)] get => default; }
			public object Current { get => default; }
	
			// Constructors
			public DictionaryEnumerator([Nullable(new byte[4] {1, 0, 1, 1 })] IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e) : this() {
				_e = default;
			}
	
			// Methods
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		// Constructors
		public DictionaryWrapper() {} // Dummy constructor
	
		// Methods
		public void Add(TKey key, TValue value) {}
		public bool ContainsKey(TKey key) => default;
		public bool Remove(TKey key) => default;
		public bool TryGetValue(TKey key, [Nullable(2)] out ref TValue value) {
			value = default;
			return default;
		}
		public void Add([Nullable(new byte[3] {0, 1, 1 })] KeyValuePair<TKey, TValue> item) {}
		public void Clear() {}
		public bool Contains([Nullable(new byte[3] {0, 1, 1 })] KeyValuePair<TKey, TValue> item) => default;
		public void CopyTo([Nullable(new byte[4] {1, 0, 1, 1 })] KeyValuePair<TKey, TValue>[] array, int arrayIndex) {}
		public bool Remove([Nullable(new byte[3] {0, 1, 1 })] KeyValuePair<TKey, TValue> item) => default;
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		void IDictionary.Add(object key, [Nullable(2)] object value) {}
		IDictionaryEnumerator IDictionary.GetEnumerator() => default;
		bool IDictionary.Contains(object key) => default;
		public void Remove(object key) {}
		void ICollection.CopyTo(Array array, int index) {}
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class DynamicProxy<T> // TypeDefIndex: 51678
	{
		// Constructors
		public DynamicProxy() {}
	
		// Methods
		public virtual IEnumerable<string> GetDynamicMemberNames(T instance) => default;
		public virtual bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, [Nullable(2)] out object result) {
			result = default;
			return default;
		}
		public virtual bool TryConvert(T instance, ConvertBinder binder, [Nullable(2)] out object result) {
			result = default;
			return default;
		}
		public virtual bool TryCreateInstance(T instance, CreateInstanceBinder binder, object[] args, [Nullable(2)] out object result) {
			result = default;
			return default;
		}
		public virtual bool TryDeleteIndex(T instance, DeleteIndexBinder binder, object[] indexes) => default;
		public virtual bool TryDeleteMember(T instance, DeleteMemberBinder binder) => default;
		public virtual bool TryGetIndex(T instance, GetIndexBinder binder, object[] indexes, [Nullable(2)] out object result) {
			result = default;
			return default;
		}
		public virtual bool TryGetMember(T instance, GetMemberBinder binder, [Nullable(2)] out object result) {
			result = default;
			return default;
		}
		public virtual bool TryInvoke(T instance, InvokeBinder binder, object[] args, [Nullable(2)] out object result) {
			result = default;
			return default;
		}
		public virtual bool TryInvokeMember(T instance, InvokeMemberBinder binder, object[] args, [Nullable(2)] out object result) {
			result = default;
			return default;
		}
		public virtual bool TrySetIndex(T instance, SetIndexBinder binder, object[] indexes, object value) => default;
		public virtual bool TrySetMember(T instance, SetMemberBinder binder, object value) => default;
		public virtual bool TryUnaryOperation(T instance, UnaryOperationBinder binder, [Nullable(2)] out object result) {
			result = default;
			return default;
		}
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal sealed class DynamicProxyMetaObject<T> : DynamicMetaObject // TypeDefIndex: 51694
	{
		// Fields
		private readonly DynamicProxy<T> _proxy;
	
		// Properties
		private static Expression[] NoArgs { get => default; }
	
		// Nested types
		[NullableContext(0)]
		private delegate DynamicMetaObject Fallback([Nullable(2)] DynamicMetaObject errorSuggestion); // TypeDefIndex: 51679; 0x00000000-0x00000000
	
		[Nullable(0)]
		private sealed class GetBinderAdapter : GetMemberBinder // TypeDefIndex: 51680
		{
			// Constructors
			public GetBinderAdapter() {} // Dummy constructor
			internal GetBinderAdapter(InvokeMemberBinder binder) {}
	
			// Methods
			public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, [Nullable(2)] DynamicMetaObject errorSuggestion) => default;
		}
	
		// Constructors
		public DynamicProxyMetaObject() {} // Dummy constructor
		internal DynamicProxyMetaObject(Expression expression, T value, DynamicProxy<T> proxy) {}
	
		// Methods
		private bool IsOverridden(string method) => default;
		public override DynamicMetaObject BindGetMember(GetMemberBinder binder) => default;
		public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) => default;
		public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) => default;
		public override DynamicMetaObject BindConvert(ConvertBinder binder) => default;
		public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) => default;
		public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) => default;
		public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) => default;
		public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) => default;
		public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) => default;
		public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) => default;
		public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) => default;
		public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) => default;
		private static IEnumerable<Expression> GetArgs(params DynamicMetaObject[] args) => default;
		private static Expression[] GetArgArray(DynamicMetaObject[] args) => default;
		private static Expression[] GetArgArray(DynamicMetaObject[] args, DynamicMetaObject value) => default;
		private static ConstantExpression Constant(DynamicMetaObjectBinder binder) => default;
		private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, [Nullable(new byte[2] {1, 0 })] Fallback fallback, [Nullable(new byte[2] {2, 0 })] Fallback fallbackInvoke = null) => default;
		private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicMetaObject fallbackResult, [Nullable(new byte[2] {2, 0 })] Fallback fallbackInvoke) => default;
		private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, [Nullable(new byte[2] {1, 0 })] Fallback fallback) => default;
		private DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, [Nullable(new byte[2] {1, 0 })] Fallback fallback) => default;
		private BindingRestrictions GetRestrictions() => default;
		public override IEnumerable<string> GetDynamicMemberNames() => default;
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class DynamicUtils // TypeDefIndex: 51696
	{
		// Nested types
		[Nullable(0)]
		internal static class BinderWrapper // TypeDefIndex: 51695
		{
			// Fields
			[Nullable(2)]
			private static object _getCSharpArgumentInfoArray; // 0x00
			[Nullable(2)]
			private static object _setCSharpArgumentInfoArray; // 0x08
			[Nullable(2)]
			private static MethodCall<object, object> _getMemberCall; // 0x10
			[Nullable(2)]
			private static MethodCall<object, object> _setMemberCall; // 0x18
			private static bool _init; // 0x20
	
			// Methods
			private static void Init() {} // 0x00000001892B92D4-0x00000001892B94D0
			private static object CreateSharpArgumentInfoArray(params int[] values) => default; // 0x00000001892B8F38-0x00000001892B9174
			private static void CreateMemberCalls() {} // 0x00000001892B8B6C-0x00000001892B8F38
			public static CallSiteBinder GetMember(string name, System.Type context) => default; // 0x00000001892B9174-0x00000001892B92D4
			public static CallSiteBinder SetMember(string name, System.Type context) => default; // 0x00000001892B94D0-0x00000001892B9634
		}
	
		// Extension methods
		public static IEnumerable<string> GetDynamicMemberNames(this IDynamicMetaObjectProvider dynamicProvider) => default; // 0x00000001892BFFDC-0x00000001892C0044
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class NoThrowGetBinderMember : GetMemberBinder // TypeDefIndex: 51697
	{
		// Fields
		private readonly GetMemberBinder _innerBinder; // 0x28
	
		// Constructors
		public NoThrowGetBinderMember() {} // Dummy constructor
		public NoThrowGetBinderMember(GetMemberBinder innerBinder) {} // 0x00000001892C1C78-0x00000001892C1CBC
	
		// Methods
		public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, [Nullable(2)] DynamicMetaObject errorSuggestion) => default; // 0x00000001892C1B9C-0x00000001892C1C78
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class NoThrowSetBinderMember : SetMemberBinder // TypeDefIndex: 51698
	{
		// Fields
		private readonly SetMemberBinder _innerBinder; // 0x28
	
		// Constructors
		public NoThrowSetBinderMember() {} // Dummy constructor
		public NoThrowSetBinderMember(SetMemberBinder innerBinder) {} // 0x00000001892C1DCC-0x00000001892C1E10
	
		// Methods
		public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, [Nullable(2)] DynamicMetaObject errorSuggestion) => default; // 0x00000001892C1CBC-0x00000001892C1DCC
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class NoThrowExpressionVisitor : ExpressionVisitor // TypeDefIndex: 51699
	{
		// Fields
		internal static readonly object ErrorResult; // 0x00
	
		// Constructors
		public NoThrowExpressionVisitor() {} // 0x000000018350B670-0x000000018350B680
		static NoThrowExpressionVisitor() {} // 0x00000001892C1B2C-0x00000001892C1B9C
	
		// Methods
		protected override Expression VisitConditional(ConditionalExpression node) => default; // 0x00000001892C1A50-0x00000001892C1B2C
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class EnumInfo // TypeDefIndex: 51700
	{
		// Fields
		public readonly bool IsFlags; // 0x10
		public readonly ulong[] Values; // 0x18
		public readonly string[] Names; // 0x20
		public readonly string[] ResolvedNames; // 0x28
	
		// Constructors
		public EnumInfo() {} // Dummy constructor
		public EnumInfo(bool isFlags, ulong[] values, string[] names, string[] resolvedNames) {} // 0x00000001826BCEF0-0x00000001826BCF30
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class EnumUtils // TypeDefIndex: 51702
	{
		// Fields
		[Nullable(new byte[5] {1, 0, 1, 2, 1 })]
		private static readonly ThreadSafeStore<StructMultiKey<System.Type, NamingStrategy>, EnumInfo> ValuesAndNamesPerEnum; // 0x00
		private static CamelCaseNamingStrategy _camelCaseNamingStrategy; // 0x08
	
		// Constructors
		static EnumUtils() {} // 0x0000000183B37790-0x0000000183B378B0
	
		// Methods
		private static EnumInfo InitializeValuesAndNames([Nullable(new byte[3] {0, 1, 2 })] StructMultiKey<System.Type, NamingStrategy> key) => default; // 0x00000001826BB510-0x00000001826BB950
		public static bool TryToString(System.Type enumType, object value, [Nullable(2)] NamingStrategy namingStrategy, [NotNullWhen(true)] [Nullable(2)] out string name) {
			name = default;
			return default;
		} // 0x00000001892C0280-0x00000001892C0408
		private static string InternalFlagsFormat(EnumInfo entry, ulong result) => default; // 0x00000001892C0044-0x00000001892C01BC
		public static EnumInfo GetEnumValuesAndNames(System.Type enumType) => default; // 0x0000000182905550-0x0000000182905610
		private static ulong ToUInt64(object value) => default; // 0x00000001826BB950-0x00000001826BBA80
		public static object ParseEnum(System.Type enumType, [Nullable(2)] NamingStrategy namingStrategy, string value, bool disallowNumber) => default; // 0x0000000182476130-0x0000000182476360
		private static int? MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison) => default; // 0x00000001892C01BC-0x00000001892C0280
		private static int? FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison) => default; // 0x0000000182476360-0x0000000182476450
	}

	[Nullable(0)]
	[NullableContext(2)]
	internal class FSharpFunction // TypeDefIndex: 51703
	{
		// Fields
		private readonly object _instance; // 0x10
		[Nullable(new byte[3] {1, 2, 1 })]
		private readonly MethodCall<object, object> _invoker; // 0x18
	
		// Constructors
		public FSharpFunction() {} // Dummy constructor
		public FSharpFunction(object instance, [Nullable(new byte[3] {1, 2, 1 })] MethodCall<object, object> invoker) {} // 0x0000000182676770-0x00000001826767A0
	
		// Methods
		[NullableContext(1)]
		public object Invoke(params object[] args) => default; // 0x00000001892C0408-0x00000001892C0438
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class FSharpUtils // TypeDefIndex: 51707
	{
		// Fields
		private static readonly object Lock; // 0x00
		[Nullable(2)]
		private static FSharpUtils _instance; // 0x08
		private MethodInfo _ofSeq; // 0x10
		private System.Type _mapType; // 0x18
	
		// Properties
		public static FSharpUtils Instance { get => default; } // 0x00000001892C0E28-0x00000001892C0E78 
		private Assembly FSharpCoreAssembly { get; set; } // 0x0000000184271930-0x0000000184271940
		[Nullable(new byte[3] {1, 2, 1 })]
		public MethodCall<object, object> IsUnion { get; private set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		[Nullable(new byte[3] {1, 2, 1 })]
		public MethodCall<object, object> GetUnionCases { get; private set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		[Nullable(new byte[3] {1, 2, 1 })]
		public MethodCall<object, object> PreComputeUnionTagReader { get; private set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		[Nullable(new byte[3] {1, 2, 1 })]
		public MethodCall<object, object> PreComputeUnionReader { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		[Nullable(new byte[3] {1, 2, 1 })]
		public MethodCall<object, object> PreComputeUnionConstructor { get; private set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public Func<object, object> GetUnionCaseInfoDeclaringType { get; private set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public Func<object, object> GetUnionCaseInfoName { get; private set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		public Func<object, object> GetUnionCaseInfoTag { get; private set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		[Nullable(new byte[3] {1, 1, 2 })]
		public MethodCall<object, object> GetUnionCaseInfoFields { get; private set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
	
		// Constructors
		public FSharpUtils() {} // Dummy constructor
		private FSharpUtils(Assembly fsharpCoreAssembly) {} // 0x00000001892C0A48-0x00000001892C0E28
		static FSharpUtils() {} // 0x00000001892C09D8-0x00000001892C0A48
	
		// Methods
		public static void EnsureInitialized(Assembly fsharpCoreAssembly) {} // 0x00000001892C07C8-0x00000001892C097C
		private static MethodInfo GetMethodWithNonPublicFallback(System.Type type, string methodName, System.Reflection.BindingFlags bindingFlags) => default; // 0x00000001892C097C-0x00000001892C09D8
		private static MethodCall<object, object> CreateFSharpFuncCall(System.Type type, string methodName) => default; // 0x00000001892C0438-0x00000001892C05B8
		public ObjectConstructor<object> CreateSeq(System.Type t) => default; // 0x00000001892C0708-0x00000001892C07C8
		public ObjectConstructor<object> CreateMap(System.Type keyType, System.Type valueType) => default; // 0x00000001892C05B8-0x00000001892C0708
		[NullableContext(2)]
		public ObjectConstructor<object> BuildMapCreator<TKey, TValue>() => default;
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class ImmutableCollectionsUtils // TypeDefIndex: 51712
	{
		// Fields
		private static readonly IList<ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; // 0x00
		private static readonly IList<ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; // 0x08
	
		// Nested types
		[Nullable(0)]
		internal class ImmutableCollectionTypeInfo // TypeDefIndex: 51708
		{
			// Properties
			public string ContractTypeName { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
			public string CreatedTypeName { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
			public string BuilderTypeName { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
			// Constructors
			public ImmutableCollectionTypeInfo() {} // Dummy constructor
			public ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName) {} // 0x000000018285BDC0-0x000000018285BE00
		}
	
		// Constructors
		static ImmutableCollectionsUtils() {} // 0x0000000183704CB0-0x0000000183705270
	
		// Methods
		internal static bool TryBuildImmutableForArrayContract(System.Type underlyingType, System.Type collectionItemType, [NotNullWhen(true)] [Nullable(2)] out System.Type createdType, [Nullable(new byte[2] {2, 1 })] [NotNullWhen(true)] out ObjectConstructor<object> parameterizedCreator) {
			createdType = default;
			parameterizedCreator = default;
			return default;
		} // 0x000000018308DDD0-0x000000018308DFC0
		internal static bool TryBuildImmutableForDictionaryContract(System.Type underlyingType, System.Type keyItemType, System.Type valueItemType, [NotNullWhen(true)] [Nullable(2)] out System.Type createdType, [NotNullWhen(true)] [Nullable(new byte[2] {2, 1 })] out ObjectConstructor<object> parameterizedCreator) {
			createdType = default;
			parameterizedCreator = default;
			return default;
		} // 0x000000018308EEC0-0x000000018308F0C0
	}

	[Nullable(0)]
	[NullableContext(2)]
	internal static class BufferUtils // TypeDefIndex: 51713
	{
		// Methods
		[NullableContext(1)]
		public static char[] RentBuffer([Nullable(2)] IArrayPool<char> bufferPool, int minSize) => default; // 0x00000001829075A0-0x00000001829076D0
		public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer) {} // 0x00000001830AB590-0x00000001830AB5E0
		public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer) => default; // 0x00000001892B96EC-0x00000001892B976C
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class JavaScriptUtils // TypeDefIndex: 51714
	{
		// Fields
		internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x00
		internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x08
		internal static readonly bool[] HtmlCharEscapeFlags; // 0x10
	
		// Constructors
		static JavaScriptUtils() {} // 0x0000000183216A60-0x00000001832176C0
	
		// Methods
		public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) => default; // 0x00000001826979C0-0x0000000182697A40
		public static bool ShouldEscapeJavaScriptString([Nullable(2)] string s, bool[] charEscapeFlags) => default; // 0x00000001824E6A40-0x00000001824E6AB0
		[NullableContext(2)]
		public static void WriteEscapedJavaScriptString([Nullable(1)] TextWriter writer, string s, char delimiter, bool appendDelimiters, [Nullable(1)] bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer) {} // 0x0000000182905EF0-0x00000001829060B0
		public static string ToEscapedJavaScriptString([Nullable(2)] string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) => default; // 0x00000001892C0E78-0x00000001892C1000
		private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling) => default; // 0x0000000182906D50-0x0000000182906DD0
		public static bool TryGetDateFromConstructorJson(JsonReader reader, out System.DateTime dateTime, [NotNullWhen(false)] [Nullable(2)] out string errorMessage) {
			dateTime = default;
			errorMessage = default;
			return default;
		} // 0x00000001892C115C-0x00000001892C14C4
		private static bool TryGetDateConstructorValue(JsonReader reader, out long? integer, [NotNullWhen(false)] [Nullable(2)] out string errorMessage) {
			integer = default;
			errorMessage = default;
			return default;
		} // 0x00000001892C1000-0x00000001892C115C
	}

	internal static class JsonTokenUtils // TypeDefIndex: 51715
	{
		// Methods
		internal static bool IsEndToken(JsonToken token) => default; // 0x000000018269A4F0-0x000000018269A500
		internal static bool IsStartToken(JsonToken token) => default; // 0x000000018269A900-0x000000018269A910
		internal static bool IsPrimitiveToken(JsonToken token) => default; // 0x00000001837E7D50-0x00000001837E7D60
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 51723
	{
		// Fields
		private static readonly LateBoundReflectionDelegateFactory _instance; // 0x00
	
		// Properties
		internal static ReflectionDelegateFactory Instance { get => default; } // 0x00000001892C15F0-0x00000001892C1640 
	
		// Constructors
		public LateBoundReflectionDelegateFactory() {} // 0x000000018350B670-0x000000018350B680
		static LateBoundReflectionDelegateFactory() {} // 0x0000000183D1B4D0-0x0000000183D1B530
	
		// Methods
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method) => default; // 0x00000001838DD3E0-0x00000001838DD500
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method) => default;
		public override Func<T> CreateDefaultConstructor<T>(System.Type type) => default;
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) => default;
		public override Func<T, object> CreateGet<T>(System.Reflection.FieldInfo fieldInfo) => default;
		public override Action<T, object> CreateSet<T>(System.Reflection.FieldInfo fieldInfo) => default;
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) => default;
	}

	internal static class MathUtils // TypeDefIndex: 51724
	{
		// Methods
		public static int IntLength(ulong i) => default; // 0x0000000182905A20-0x0000000182905A50
		public static char IntToHex(int n) => default; // 0x00000001892C16E0-0x00000001892C16F0
		public static bool ApproxEquals(double d1, double d2) => default; // 0x00000001892C1640-0x00000001892C16E0
	}

	internal delegate TResult MethodCall<T, TResult>(T target, [Nullable(new byte[2] {1, 2 })] params object[] args); // TypeDefIndex: 51725; 0x00000000-0x00000000

	[Nullable(0)]
	[NullableContext(1)]
	internal static class MiscellaneousUtils // TypeDefIndex: 51726
	{
		// Methods
		[NullableContext(2)]
		public static bool ValueEquals(object objA, object objB) => default; // 0x0000000183387590-0x0000000183387810
		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message) => default; // 0x00000001892C1778-0x00000001892C1854
		public static string ToString([Nullable(2)] object value) => default; // 0x00000001892C19CC-0x00000001892C1A50
		public static int ByteArrayCompare(byte[] a1, byte[] a2) => default; // 0x00000001892C16F0-0x00000001892C1778
		public static string GetPrefix(string qualifiedName) => default; // 0x00000001892C1880-0x00000001892C18AC
		public static string GetLocalName(string qualifiedName) => default; // 0x00000001892C1854-0x00000001892C1880
		public static void GetQualifiedNameParts(string qualifiedName, [Nullable(2)] out string prefix, out string localName) {
			prefix = default;
			localName = default;
		} // 0x00000001892C18AC-0x00000001892C1950
		internal static RegexOptions GetRegexOptions(string optionsText) => default; // 0x00000001892C1950-0x00000001892C19CC
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal abstract class ReflectionDelegateFactory // TypeDefIndex: 51727
	{
		// Constructors
		protected ReflectionDelegateFactory() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public Func<T, object> CreateGet<T>(MemberInfo memberInfo) => default;
		public Action<T, object> CreateSet<T>(MemberInfo memberInfo) => default;
		public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
		public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);
		public abstract Func<T> CreateDefaultConstructor<T>(System.Type type);
		public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
		public abstract Func<T, object> CreateGet<T>(System.Reflection.FieldInfo fieldInfo);
		public abstract Action<T, object> CreateSet<T>(System.Reflection.FieldInfo fieldInfo);
		public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	}

	[Nullable(0)]
	[NullableContext(2)]
	internal class ReflectionMember // TypeDefIndex: 51728
	{
		// Properties
		public System.Type MemberType { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		[Nullable(new byte[3] {2, 1, 2 })]
		public Func<object, object> Getter { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		[Nullable(new byte[3] {2, 1, 2 })]
		public Action<object, object> Setter { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Constructors
		public ReflectionMember() {} // 0x000000018350B670-0x000000018350B680
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class ReflectionObject // TypeDefIndex: 51732
	{
		// Properties
		[Nullable(new byte[2] {2, 1 })]
		public ObjectConstructor<object> Creator { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public IDictionary<string, ReflectionMember> Members { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public ReflectionObject() {} // Dummy constructor
		private ReflectionObject([Nullable(new byte[2] {2, 1 })] ObjectConstructor<object> creator) {} // 0x00000001892C266C-0x00000001892C26FC
	
		// Methods
		public object GetValue(object target, string member) => default; // 0x00000001892C2574-0x00000001892C25E8
		public void SetValue(object target, string member, [Nullable(2)] object value) {} // 0x00000001892C25E8-0x00000001892C266C
		public System.Type GetType(string member) => default; // 0x00000001892C251C-0x00000001892C2574
		public static ReflectionObject Create(System.Type t, params string[] memberNames) => default; // 0x00000001892C1E10-0x00000001892C1E20
		public static ReflectionObject Create(System.Type t, [Nullable(2)] MethodBase creator, params string[] memberNames) => default; // 0x00000001892C1E20-0x00000001892C251C
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class ReflectionUtils // TypeDefIndex: 51738
	{
		// Fields
		public static readonly System.Type[] EmptyTypes; // 0x00
	
		// Constructors
		static ReflectionUtils() {} // 0x0000000183CFF250-0x0000000183CFF2D0
	
		// Methods
		public static bool IsPublic(PropertyInfo property) => default; // 0x0000000182479FB0-0x000000018247A020
		[NullableContext(2)]
		public static System.Type GetObjectType(object v) => default; // 0x0000000182419740-0x0000000182419AF0
		public static string GetTypeName(System.Type t, TypeNameAssemblyFormatHandling assemblyFormat, [Nullable(2)] ISerializationBinder binder) => default; // 0x00000001892C2DB8-0x00000001892C2E7C
		private static string GetFullyQualifiedTypeName(System.Type t, [Nullable(2)] ISerializationBinder binder) => default; // 0x00000001892C2CA8-0x00000001892C2DB8
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) => default; // 0x00000001892C2F74-0x00000001892C3090
		public static bool HasDefaultConstructor(System.Type t, bool nonPublic) => default; // 0x0000000182475D80-0x0000000182475E40
		public static ConstructorInfo GetDefaultConstructor(System.Type t) => default; // 0x00000001824756B0-0x0000000182475700
		public static ConstructorInfo GetDefaultConstructor(System.Type t, bool nonPublic) => default; // 0x0000000182475700-0x0000000182475860
		public static bool IsNullable(System.Type t) => default; // 0x0000000182476A80-0x0000000182476B00
		public static bool IsNullableType(System.Type t) => default; // 0x0000000182478570-0x0000000182478620
		public static System.Type EnsureNotNullableType(System.Type t) => default; // 0x0000000182475900-0x0000000182475960
		public static System.Type EnsureNotByRefType(System.Type t) => default; // 0x0000000182477850-0x0000000182477890
		public static bool IsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition) => default; // 0x000000018308EE30-0x000000018308EEC0
		public static bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition) => default; // 0x0000000182478010-0x0000000182478080
		public static bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition, [Nullable(2)] [NotNullWhen(true)] out System.Type implementingType) {
			implementingType = default;
			return default;
		} // 0x0000000182478400-0x0000000182478570
		public static bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition) => default; // 0x000000018308EB80-0x000000018308EBF0
		public static bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition, [Nullable(2)] out System.Type implementingType) {
			implementingType = default;
			return default;
		} // 0x000000018308EBF0-0x000000018308ECB0
		private static bool InheritsGenericDefinitionInternal(System.Type type, System.Type genericClassDefinition, [Nullable(2)] out System.Type implementingType) {
			implementingType = default;
			return default;
		} // 0x000000018308ECD0-0x000000018308EDB0
		public static System.Type GetCollectionItemType(System.Type type) => default; // 0x000000018308F0C0-0x000000018308F160
		[NullableContext(2)]
		public static void GetDictionaryKeyValueTypes([Nullable(1)] System.Type dictionaryType, out System.Type keyType, out System.Type valueType) {
			keyType = default;
			valueType = default;
		} // 0x00000001892C29C0-0x00000001892C2CA8
		public static System.Type GetMemberUnderlyingType(MemberInfo member) => default; // 0x00000001824E5800-0x00000001824E5960
		public static bool IsByRefLikeType(System.Type type) => default; // 0x00000001824E7370-0x00000001824E7480
		public static bool IsIndexedProperty(PropertyInfo property) => default; // 0x0000000182478AE0-0x0000000182478B40
		public static object GetMemberValue(MemberInfo member, object target) => default; // 0x000000018232C7D0-0x000000018232C920
		public static void SetMemberValue(MemberInfo member, object target, [Nullable(2)] object value) {} // 0x00000001823279A0-0x0000000182327C30
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) => default; // 0x00000001824E5CE0-0x00000001824E5E10
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) => default; // 0x00000001824E5E10-0x00000001824E5F60
		public static List<MemberInfo> GetFieldsAndProperties(System.Type type, System.Reflection.BindingFlags bindingAttr) => default; // 0x00000001825E1470-0x00000001825E2100
		private static bool IsOverridenGenericMember(MemberInfo memberInfo, System.Reflection.BindingFlags bindingAttr) => default; // 0x0000000183C85780-0x0000000183C85830
		public static T GetAttribute<T>(object attributeProvider)
			where T : Attribute => default;
		public static T GetAttribute<T>(object attributeProvider, bool inherit)
			where T : Attribute => default;
		public static T[] GetAttributes<T>(object attributeProvider, bool inherit)
			where T : Attribute => default;
		public static Attribute[] GetAttributes(object attributeProvider, [Nullable(2)] System.Type attributeType, bool inherit) => default; // 0x00000001824E32B0-0x00000001824E3CF0
		public static StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName) => default; // 0x00000001827BCFF0-0x00000001827BD180
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) => default; // 0x00000001827BEBA0-0x00000001827BEC50
		public static MemberInfo GetMemberInfoFromType(System.Type targetType, MemberInfo memberInfo) => default; // 0x00000001824E2400-0x00000001824E2A70
		public static IEnumerable<System.Reflection.FieldInfo> GetFields(System.Type targetType, System.Reflection.BindingFlags bindingAttr) => default; // 0x00000001825E1360-0x00000001825E1470
		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, System.Type type, System.Reflection.BindingFlags bindingAttr) {} // 0x00000001825E1160-0x00000001825E1360
		public static IEnumerable<PropertyInfo> GetProperties(System.Type targetType, System.Reflection.BindingFlags bindingAttr) => default; // 0x0000000182478680-0x00000001824788C0
		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, System.Type type, System.Reflection.BindingFlags bindingAttr) {} // 0x0000000182478B40-0x00000001824798A0
		public static bool IsMethodOverridden(System.Type currentType, System.Type methodDeclaringType, string method) => default; // 0x00000001892C2E7C-0x00000001892C2F74
		public static object GetDefaultValue(System.Type type) => default; // 0x00000001892C26FC-0x00000001892C29C0
	
		// Extension methods
		public static bool IsVirtual(this PropertyInfo propertyInfo) => default; // 0x0000000182541360-0x0000000182541610
		public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo) => default; // 0x0000000182479E00-0x0000000182479F50
		public static System.Reflection.BindingFlags RemoveFlag(this System.Reflection.BindingFlags bindingAttr, System.Reflection.BindingFlags flag) => default; // 0x00000001834EF0B0-0x00000001834EF0D0
	}

	[Nullable(0)]
	[NullableContext(2)]
	internal struct StringBuffer // TypeDefIndex: 51739
	{
		// Fields
		private char[] _buffer; // 0x00
		private int _position; // 0x08
	
		// Properties
		public int Position { get => default; set {} } // 0x0000000183D516F0-0x0000000183D51700 0x0000000183D51710-0x0000000183D51720
		public bool IsEmpty { get => default; } // 0x0000000182361C20-0x0000000182361C30 
		public char[] InternalBuffer { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
	
		// Constructors
		public StringBuffer(IArrayPool<char> bufferPool, int initalSize) : this() {
			_buffer = default;
			_position = default;
		} // 0x0000000182905860-0x00000001829058A0
		[NullableContext(1)]
		private StringBuffer(char[] buffer) : this() {
			_buffer = default;
			_position = default;
		} // 0x0000000184271F74-0x0000000184271F90
	
		// Methods
		public void Append(IArrayPool<char> bufferPool, char value) {} // 0x00000001833B9D00-0x00000001833B9D60
		[NullableContext(1)]
		public void Append([Nullable(2)] IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count) {} // 0x00000001833B9D60-0x00000001833B9DE0
		public void Clear(IArrayPool<char> bufferPool) {} // 0x00000001830AB5E0-0x00000001830AB630
		private void EnsureSize(IArrayPool<char> bufferPool, int appendLength) {} // 0x00000001892C3090-0x00000001892C30FC
		[NullableContext(1)]
		public override string ToString() => default; // 0x00000001892C30FC-0x00000001892C310C
		[NullableContext(1)]
		public string ToString(int start, int length) => default; // 0x00000001892C310C-0x00000001892C3130
	}

	[IsReadOnly]
	[Nullable(0)]
	[NullableContext(1)]
	internal struct StringReference // TypeDefIndex: 51740
	{
		// Fields
		private readonly char[] _chars; // 0x00
		private readonly int _startIndex; // 0x08
		private readonly int _length; // 0x0C
	
		// Properties
		public char this[int i] { get => default; } // 0x00000001829062E0-0x0000000182906310 
		public char[] Chars { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
		public int StartIndex { get => default; } // 0x0000000183D516F0-0x0000000183D51700 
		public int Length { get => default; } // 0x0000000183D4FBF0-0x0000000183D4FC00 
	
		// Constructors
		public StringReference(char[] chars, int startIndex, int length) : this() {
			_chars = default;
			_startIndex = default;
			_length = default;
		} // 0x000000018426FA34-0x000000018426FA54
	
		// Methods
		public override string ToString() => default; // 0x000000018426F9F0-0x000000018426FA14
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class StringReferenceExtensions // TypeDefIndex: 51741
	{
		// Extension methods
		public static int IndexOf(this StringReference s, char c, int startIndex, int length) => default; // 0x00000001892C31BC-0x00000001892C323C
		public static bool StartsWith(this StringReference s, string text) => default; // 0x00000001892C323C-0x00000001892C32C4
		public static bool EndsWith(this StringReference s, string text) => default; // 0x00000001892C3130-0x00000001892C31BC
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class StringUtils // TypeDefIndex: 51744
	{
		// Nested types
		[NullableContext(0)]
		private enum SeparatedCaseState // TypeDefIndex: 51742
		{
			Start = 0,
			Lower = 1,
			Upper = 2,
			NewWord = 3
		}
	
		// Methods
		[NullableContext(2)]
		public static bool IsNullOrEmpty([NotNullWhen(false)] string value) => default; // 0x0000000184271F60-0x0000000184271F74
		public static StringWriter CreateStringWriter(int capacity) => default; // 0x00000001892C32C4-0x00000001892C3380
		public static void ToCharAsUnicode(char c, char[] buffer) {} // 0x00000001892C3A28-0x00000001892C3AF8
		public static string ToCamelCase(string s) => default; // 0x00000001892C387C-0x00000001892C3A28
		private static char ToLower(char c) => default; // 0x00000001892C3B08-0x00000001892C3B78
		public static string ToSnakeCase(string s) => default; // 0x00000001892C3DC0-0x00000001892C3DD0
		public static string ToKebabCase(string s) => default; // 0x00000001892C3AF8-0x00000001892C3B08
		private static string ToSeparatedCase(string s, char separator) => default; // 0x00000001892C3B78-0x00000001892C3DC0
		public static bool IsHighSurrogate(char c) => default; // 0x00000001892C37B0-0x00000001892C37FC
		public static bool IsLowSurrogate(char c) => default; // 0x00000001892C37FC-0x00000001892C3848
		public static int IndexOf(string s, char c) => default; // 0x00000001892C3794-0x00000001892C37B0
	
		// Extension methods
		public static string FormatWith(this string format, IFormatProvider provider, [Nullable(2)] object arg0) => default; // 0x00000001892C363C-0x00000001892C36D4
		public static string FormatWith(this string format, IFormatProvider provider, [Nullable(2)] object arg0, [Nullable(2)] object arg1) => default; // 0x00000001892C36D4-0x00000001892C3794
		public static string FormatWith(this string format, IFormatProvider provider, [Nullable(2)] object arg0, [Nullable(2)] object arg1, [Nullable(2)] object arg2) => default; // 0x00000001892C355C-0x00000001892C363C
		[NullableContext(2)]
		public static string FormatWith([Nullable(1)] this string format, [Nullable(1)] IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) => default; // 0x00000001892C3460-0x00000001892C355C
		private static string FormatWith(this string format, IFormatProvider provider, [Nullable(new byte[2] {1, 2 })] params object[] args) => default; // 0x00000001892C33B8-0x00000001892C3460
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue) => default;
		public static bool StartsWith(this string source, char value) => default; // 0x00000001892C3848-0x00000001892C387C
		public static bool EndsWith(this string source, char value) => default; // 0x00000001892C3380-0x00000001892C33B8
		public static string Trim(this string s, int start, int length) => default; // 0x00000001827BD180-0x00000001827BDC20
	}

	[IsReadOnly]
	[Nullable(0)]
	[NullableContext(1)]
	internal struct StructMultiKey<T1, T2> : IEquatable<StructMultiKey<T1, T2>> // TypeDefIndex: 51745
	{
		// Fields
		public readonly T1 Value1;
		public readonly T2 Value2;
	
		// Constructors
		public StructMultiKey(T1 v1, T2 v2) {
			Value1 = default;
			Value2 = default;
		}
	
		// Methods
		public override int GetHashCode() => default;
		[NullableContext(2)]
		public override bool Equals(object obj) => default;
		public bool Equals([Nullable(new byte[3] {0, 1, 1 })] StructMultiKey<T1, T2> other) => default;
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal class ThreadSafeStore<TKey, TValue> // TypeDefIndex: 51746
	{
		// Fields
		private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore;
		private readonly Func<TKey, TValue> _creator;
	
		// Constructors
		public ThreadSafeStore() {} // Dummy constructor
		public ThreadSafeStore(Func<TKey, TValue> creator) {}
	
		// Methods
		public TValue Get(TKey key) => default;
	}

	[Nullable(0)]
	[NullableContext(1)]
	internal static class TypeExtensions // TypeDefIndex: 51747
	{
		// Extension methods
		public static MemberTypes MemberType(this MemberInfo memberInfo) => default; // 0x00000001823206F0-0x0000000182320710
		public static bool ContainsGenericParameters(this System.Type type) => default; // 0x00000001892C3DF0-0x00000001892C3E10
		public static bool IsInterface(this System.Type type) => default; // 0x0000000182478640-0x0000000182478660
		public static bool IsGenericType(this System.Type type) => default; // 0x0000000182478620-0x0000000182478640
		public static bool IsGenericTypeDefinition(this System.Type type) => default; // 0x0000000182478660-0x0000000182478680
		public static System.Type BaseType(this System.Type type) => default; // 0x00000001824E7600-0x00000001824E7E80
		public static Assembly Assembly(this System.Type type) => default; // 0x00000001892C3DD0-0x00000001892C3DF0
		public static bool IsEnum(this System.Type type) => default; // 0x0000000182477240-0x0000000182477260
		public static bool IsClass(this System.Type type) => default; // 0x000000018308ECB0-0x000000018308ECD0
		public static bool IsSealed(this System.Type type) => default; // 0x0000000182476B00-0x0000000182476B30
		public static bool IsAbstract(this System.Type type) => default; // 0x0000000182476B50-0x0000000182476B80
		public static bool IsVisible(this System.Type type) => default; // 0x00000001892C4078-0x00000001892C4094
		public static bool IsValueType(this System.Type type) => default; // 0x000000018247C260-0x000000018247C280
		public static bool AssignableToTypeName(this System.Type type, string fullTypeName, bool searchInterfaces, [NotNullWhen(true)] [Nullable(2)] out System.Type match) {
			match = default;
			return default;
		} // 0x00000001824E7480-0x00000001824E7560
		public static bool AssignableToTypeName(this System.Type type, string fullTypeName, bool searchInterfaces) => default; // 0x0000000184275F58-0x0000000184275F78
		public static bool ImplementInterface(this System.Type type, System.Type interfaceType) => default; // 0x00000001892C3E10-0x00000001892C4078
	}

	internal static class ValidationUtils // TypeDefIndex: 51748
	{
		// Methods
		[NullableContext(1)]
		public static void ArgumentNotNull([NotNull] [Nullable(2)] object value, string parameterName) {} // 0x0000000182327960-0x00000001823279A0
	}
}
