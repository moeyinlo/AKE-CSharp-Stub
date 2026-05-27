/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Buffers;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

// Image 24: Google.Protobuf.dll - Assembly: Google.Protobuf, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 51903-52220
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Google.Protobuf
{
	internal static class ByteArray // TypeDefIndex: 51908
	{
		// Fields
		private const int CopyThreshold = 12; // Metadata: 0x01FD1662
	
		// Methods
		internal static void Copy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count) {} // 0x000000018229DBE0-0x000000018229DC10
		internal static void Reverse(byte[] bytes) {} // 0x000000018853DD10-0x000000018853DD78
	}

	public sealed class ByteString : IEnumerable<byte>, IEquatable<ByteString> // TypeDefIndex: 51909
	{
		// Fields
		private static readonly ByteString empty; // 0x00
		private readonly ReadOnlyMemory<byte> bytes; // 0x10
	
		// Properties
		public static ByteString Empty { get => default; } // 0x000000018853E9D0-0x000000018853EA20 
		public int Length { get => default; } // 0x0000000183543640-0x0000000183543680 
		public bool IsEmpty { get => default; } // 0x000000018853EA20-0x000000018853EA38 
		public ReadOnlySpan<byte> Span { get => default; } // 0x0000000183543560-0x00000001835435C0 
		public ReadOnlyMemory<byte> Memory { get => default; } // 0x00000001820B7B30-0x00000001820B7B40 
		public byte this[int index] { get => default; } // 0x000000018853EA38-0x000000018853EA98 
	
		// Constructors
		public ByteString() {} // Dummy constructor
		private ByteString(ReadOnlyMemory<byte> bytes) {} // 0x000000018229DBD0-0x000000018229DBE0
		static ByteString() {} // 0x000000018229D8D0-0x000000018229DA00
	
		// Methods
		internal static ByteString AttachBytes(ReadOnlyMemory<byte> bytes) => default; // 0x000000018229DA90-0x000000018229DAF0
		internal static ByteString AttachBytes(byte[] bytes) => default; // 0x000000018229DA00-0x000000018229DA90
		public byte[] ToByteArray() => default; // 0x0000000183187700-0x0000000183187740
		public string ToBase64() => default; // 0x000000018853E69C-0x000000018853E7B0
		public static ByteString FromBase64(string bytes) => default; // 0x000000018853E2C0-0x000000018853E3A0
		public static ByteString FromStream(Stream stream) => default; // 0x000000018853E408-0x000000018853E598
		public static Task<ByteString> FromStreamAsync(Stream stream, CancellationToken cancellationToken = default) => default; // 0x000000018853E3A0-0x000000018853E408
		public static ByteString CopyFrom(params byte[] bytes) => default; // 0x000000018229D820-0x000000018229D8D0
		public static ByteString CopyFrom(byte[] bytes, int offset, int count) => default; // 0x000000018229DAF0-0x000000018229DBD0
		public static ByteString CopyFrom(ReadOnlySpan<byte> bytes) => default; // 0x000000018853DF64-0x000000018853E004
		public static ByteString CopyFrom(string text, Encoding encoding) => default; // 0x000000018853DEC0-0x000000018853DF64
		public static ByteString CopyFromUtf8(string text) => default; // 0x000000018853DE68-0x000000018853DEC0
		public string ToString(Encoding encoding) => default; // 0x000000018853E7D4-0x000000018853E8D0
		public string ToStringUtf8() => default; // 0x000000018853E7B0-0x000000018853E7D4
		public IEnumerator<byte> GetEnumerator() => default; // 0x000000018853E598-0x000000018853E608
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018853E694-0x000000018853E69C
		public CodedInputStream CreateCodedInput() => default; // 0x000000018853E08C-0x000000018853E1F4
		public static bool operator ==(ByteString lhs, ByteString rhs) => default; // 0x0000000182F0E490-0x0000000182F0E4E0
		public static bool operator !=(ByteString lhs, ByteString rhs) => default; // 0x000000018853EA98-0x000000018853EAEC
		public override bool Equals(object obj) => default; // 0x000000018853E1F4-0x000000018853E264
		public override int GetHashCode() => default; // 0x000000018853E608-0x000000018853E694
		public bool Equals(ByteString other) => default; // 0x000000018853E264-0x000000018853E2C0
		public void CopyTo(byte[] array, int position) {} // 0x000000018853E004-0x000000018853E08C
		public void WriteTo(Stream outputStream) {} // 0x000000018853E8D0-0x000000018853E9D0
	}

	internal static class ByteStringAsync // TypeDefIndex: 51911
	{
		// Methods
		internal static async Task<ByteString> FromStreamAsyncCore(Stream stream, CancellationToken cancellationToken) => default; // 0x000000018853DD78-0x000000018853DE68
	}

	public sealed class CodedInputStream : IDisposable // TypeDefIndex: 51912
	{
		// Fields
		private readonly bool leaveOpen; // 0x10
		private readonly byte[] buffer; // 0x18
		private readonly Stream input; // 0x20
		private ParserInternalState state; // 0x28
		internal const int DefaultRecursionLimit = 100; // Metadata: 0x01FD1663
		internal const int DefaultSizeLimit = 2147483647; // Metadata: 0x01FD1665
		internal const int BufferSize = 4096; // Metadata: 0x01FD1666
	
		// Properties
		public long Position { get => default; } // 0x000000018853F8BC-0x000000018853F8F8 
		internal uint LastTag { get => default; } // 0x0000000183D4F0B0-0x0000000183D4F0C0 
		public int SizeLimit { get => default; } // 0x0000000183D5B3A0-0x0000000183D5B3B0 
		public int RecursionLimit { get => default; } // 0x0000000183D4EB50-0x0000000183D4EB60 
		internal bool DiscardUnknownFields { get => default; set {} } // 0x0000000183D5E1C0-0x0000000183D5E1D0 0x0000000183D5E200-0x0000000183D5E210
		internal ExtensionRegistry ExtensionRegistry { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
		internal byte[] InternalBuffer { get => default; } // 0x0000000181041090-0x00000001810410A0 
		internal Stream InternalInputStream { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		internal ref ParserInternalState InternalState { get => default; } // 0x0000000183D6BB40-0x0000000183D6BB50 
		internal bool ReachedLimit { get => default; } // 0x000000018853F8F8-0x000000018853F904 
		public bool IsAtEnd { get => default; } // 0x000000018853F858-0x000000018853F8BC 
	
		// Constructors
		public CodedInputStream() {} // Dummy constructor
		public CodedInputStream(byte[] buffer) {} // 0x000000018853F7D0-0x000000018853F858
		public CodedInputStream(byte[] buffer, int offset, int length) {} // 0x00000001824D1940-0x00000001824D1AD0
		public CodedInputStream(Stream input) {} // 0x000000018853F5FC-0x000000018853F608
		public CodedInputStream(Stream input, bool leaveOpen) {} // 0x000000018853F728-0x000000018853F7D0
		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, bool leaveOpen) {} // 0x00000001824D2150-0x00000001824D2290
		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, int sizeLimit, int recursionLimit, bool leaveOpen) {} // 0x000000018853F608-0x000000018853F728
	
		// Methods
		public static CodedInputStream CreateWithLimits(Stream input, int sizeLimit, int recursionLimit) => default; // 0x000000018853EAEC-0x000000018853EBAC
		public void Dispose() {} // 0x000000018853EBAC-0x000000018853EBD8
		internal void CheckReadEndOfStreamTag() {} // 0x00000001824D20F0-0x00000001824D2150
		public uint PeekTag() => default; // 0x000000018853EC4C-0x000000018853ECB4
		public uint ReadTag() => default; // 0x000000018853F40C-0x000000018853F474
		public void SkipLastField() {} // 0x000000018853F57C-0x000000018853F5FC
		internal void SkipGroup(uint startGroupTag) {} // 0x000000018853F4F0-0x000000018853F57C
		public double ReadDouble() => default; // 0x000000018853ED4C-0x000000018853EDB4
		public float ReadFloat() => default; // 0x000000018853EDCC-0x000000018853EE34
		public ulong ReadUInt64() => default; // 0x000000018853EF30-0x000000018853EF38
		public long ReadInt64() => default; // 0x000000018853EF30-0x000000018853EF38
		public int ReadInt32() => default; // 0x000000018853EDB4-0x000000018853EDBC
		public ulong ReadFixed64() => default; // 0x000000018853EDC4-0x000000018853EDCC
		public uint ReadFixed32() => default; // 0x000000018853EDBC-0x000000018853EDC4
		public bool ReadBool() => default; // 0x000000018853ECD0-0x000000018853ECE8
		public string ReadString() => default; // 0x000000018853F3A8-0x000000018853F40C
		public void ReadMessage(IMessage builder) {} // 0x000000018853EFA0-0x000000018853F150
		public void ReadGroup(IMessage builder) {} // 0x000000018853EE34-0x000000018853EF30
		public ByteString ReadBytes() => default; // 0x000000018853ECE8-0x000000018853ED4C
		public uint ReadUInt32() => default; // 0x000000018853EDB4-0x000000018853EDBC
		public int ReadEnum() => default; // 0x000000018853EDB4-0x000000018853EDBC
		public int ReadSFixed32() => default; // 0x000000018853EDBC-0x000000018853EDC4
		public long ReadSFixed64() => default; // 0x000000018853EDC4-0x000000018853EDCC
		public int ReadSInt32() => default; // 0x000000018853F36C-0x000000018853F388
		public long ReadSInt64() => default; // 0x000000018853F388-0x000000018853F3A8
		public int ReadLength() => default; // 0x000000018853EF38-0x000000018853EFA0
		public bool MaybeConsumeTag(uint tag) => default; // 0x000000018853EBD8-0x000000018853EC4C
		internal uint ReadRawVarint32() => default; // 0x000000018853F29C-0x000000018853F304
		internal static uint ReadRawVarint32(Stream input) => default; // 0x000000018853F294-0x000000018853F29C
		internal ulong ReadRawVarint64() => default; // 0x000000018853F304-0x000000018853F36C
		internal uint ReadRawLittleEndian32() => default; // 0x000000018853F1C4-0x000000018853F22C
		internal ulong ReadRawLittleEndian64() => default; // 0x000000018853F22C-0x000000018853F294
		internal int PushLimit(int byteLimit) => default; // 0x000000018853ECC4-0x000000018853ECD0
		internal void PopLimit(int oldLimit) {} // 0x000000018853ECB4-0x000000018853ECC4
		private bool RefillBuffer(bool mustSucceed) => default; // 0x000000018853F474-0x000000018853F4F0
		internal byte[] ReadRawBytes(int size) => default; // 0x000000018853F150-0x000000018853F1C4
		public void ReadRawMessage(IMessage message) {} // 0x0000000182942560-0x0000000182942730
	}

	public sealed class CodedOutputStream : IDisposable // TypeDefIndex: 51914
	{
		// Fields
		private const int LittleEndian64Size = 8; // Metadata: 0x01FD1668
		private const int LittleEndian32Size = 4; // Metadata: 0x01FD1669
		internal const int DoubleSize = 8; // Metadata: 0x01FD166A
		internal const int FloatSize = 4; // Metadata: 0x01FD166B
		internal const int BoolSize = 1; // Metadata: 0x01FD166C
		public static readonly int DefaultBufferSize; // 0x00
		private readonly bool leaveOpen; // 0x10
		private readonly byte[] buffer; // 0x18
		private WriterInternalState state; // 0x20
		private readonly Stream output; // 0x38
	
		// Properties
		public long Position { get => default; } // 0x0000000188540F64-0x0000000188540F98 
		public int NonOutputPosition { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public int SpaceLeft { get => default; } // 0x0000000188540F98-0x0000000188540FA4 
		internal byte[] InternalBuffer { get => default; } // 0x0000000181041090-0x00000001810410A0 
		internal Stream InternalOutputStream { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		internal ref WriterInternalState InternalState { get => default; } // 0x0000000183D69590-0x0000000183D695A0 
	
		// Nested types
		public sealed class OutOfSpaceException : IOException // TypeDefIndex: 51913
		{
			// Constructors
			internal OutOfSpaceException() {} // 0x00000001885528A4-0x00000001885528E8
		}
	
		// Constructors
		public CodedOutputStream() {} // Dummy constructor
		public CodedOutputStream(byte[] flatArray) {} // 0x0000000188540D38-0x0000000188540D64
		public CodedOutputStream(byte[] buffer, int offset, int length) {} // 0x00000001824D1FD0-0x00000001824D20C0
		private CodedOutputStream(Stream output, byte[] buffer, bool leaveOpen) {} // 0x0000000188540DD0-0x0000000188540E84
		public CodedOutputStream(Stream output) {} // 0x0000000188540EFC-0x0000000188540F64
		public CodedOutputStream(Stream output, int bufferSize) {} // 0x0000000188540D64-0x0000000188540DD0
		public CodedOutputStream(Stream output, bool leaveOpen) {} // 0x0000000188540CC0-0x0000000188540D38
		public CodedOutputStream(Stream output, int bufferSize, bool leaveOpen) {} // 0x0000000188540E84-0x0000000188540EFC
		static CodedOutputStream() {} // 0x0000000183D44A20-0x0000000183D44A60
	
		// Methods
		public static int ComputeDoubleSize(double value) => default; // 0x0000000183D55800-0x0000000183D55810
		public static int ComputeFloatSize(float value) => default; // 0x0000000183D50CD0-0x0000000183D50CE0
		public static int ComputeUInt64Size(ulong value) => default; // 0x00000001824D6680-0x00000001824D66D0
		public static int ComputeInt64Size(long value) => default; // 0x00000001824D6630-0x00000001824D6680
		public static int ComputeInt32Size(int value) => default; // 0x00000001824D5F30-0x00000001824D5FE0
		public static int ComputeFixed64Size(ulong value) => default; // 0x0000000183D55800-0x0000000183D55810
		public static int ComputeFixed32Size(uint value) => default; // 0x0000000183D50CD0-0x0000000183D50CE0
		public static int ComputeBoolSize(bool value) => default; // 0x0000000181168950-0x0000000181168960
		public static int ComputeStringSize(string value) => default; // 0x00000001824D5730-0x00000001824D57D0
		public static int ComputeGroupSize(IMessage value) => default; // 0x000000018853F910-0x000000018853F95C
		public static int ComputeMessageSize(IMessage value) => default; // 0x00000001824D5C70-0x00000001824D5CF0
		public static int ComputeBytesSize(ByteString value) => default; // 0x00000001835435C0-0x0000000183543640
		public static int ComputeUInt32Size(uint value) => default; // 0x00000001824D5CF0-0x00000001824D5D90
		public static int ComputeEnumSize(int value) => default; // 0x00000001824D5E30-0x00000001824D5F30
		public static int ComputeSFixed32Size(int value) => default; // 0x0000000183D50CD0-0x0000000183D50CE0
		public static int ComputeSFixed64Size(long value) => default; // 0x0000000183D55800-0x0000000183D55810
		public static int ComputeSInt32Size(int value) => default; // 0x000000018853F95C-0x000000018853F9BC
		public static int ComputeSInt64Size(long value) => default; // 0x000000018853F9BC-0x000000018853FA20
		public static int ComputeLengthSize(int length) => default; // 0x00000001824D5D90-0x00000001824D5E30
		public static int ComputeRawVarint32Size(uint value) => default; // 0x00000001824D5FE0-0x00000001824D6020
		public static int ComputeRawVarint64Size(ulong value) => default; // 0x00000001824D66D0-0x00000001824D6770
		public static int ComputeTagSize(int fieldNumber) => default; // 0x000000018853FA20-0x000000018853FA70
		public void WriteDouble(double value) {} // 0x000000018853FC04-0x000000018853FC88
		public void WriteFloat(float value) {} // 0x000000018853FE08-0x000000018853FE8C
		public void WriteUInt64(ulong value) {} // 0x0000000188540C40-0x0000000188540CC0
		public void WriteInt64(long value) {} // 0x0000000188540020-0x00000001885400A0
		public void WriteInt32(int value) {} // 0x000000018853FFA0-0x0000000188540020
		public void WriteFixed64(ulong value) {} // 0x000000018853FD88-0x000000018853FE08
		public void WriteFixed32(uint value) {} // 0x000000018853FD08-0x000000018853FD88
		public void WriteBool(bool value) {} // 0x000000018853FB04-0x000000018853FB84
		public void WriteString(string value) {} // 0x0000000188540A2C-0x0000000188540AAC
		public void WriteMessage(IMessage value) {} // 0x0000000188540120-0x0000000188540234
		public void WriteRawMessage(IMessage value) {} // 0x00000001824D3B30-0x00000001824D3CB0
		public void WriteGroup(IMessage value) {} // 0x000000018853FE8C-0x000000018853FFA0
		public void WriteBytes(ByteString value) {} // 0x000000018853FB84-0x000000018853FC04
		public void WriteUInt32(uint value) {} // 0x0000000188540BC0-0x0000000188540C40
		public void WriteEnum(int value) {} // 0x000000018853FC88-0x000000018853FD08
		public void WriteSFixed32(int value) {} // 0x000000018854082C-0x00000001885408AC
		public void WriteSFixed64(long value) {} // 0x00000001885408AC-0x000000018854092C
		public void WriteSInt32(int value) {} // 0x000000018854092C-0x00000001885409AC
		public void WriteSInt64(long value) {} // 0x00000001885409AC-0x0000000188540A2C
		public void WriteLength(int length) {} // 0x00000001885400A0-0x0000000188540120
		public void WriteTag(int fieldNumber, WireFormat.WireType type) {} // 0x0000000188540B2C-0x0000000188540BC0
		public void WriteTag(uint tag) {} // 0x0000000188540AAC-0x0000000188540B2C
		public void WriteRawTag(byte b1) {} // 0x00000001885406AC-0x000000018854072C
		public void WriteRawTag(byte b1, byte b2) {} // 0x0000000188540618-0x00000001885406AC
		public void WriteRawTag(byte b1, byte b2, byte b3) {} // 0x00000001885404C0-0x0000000188540568
		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4) {} // 0x0000000188540568-0x0000000188540618
		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5) {} // 0x0000000188540404-0x00000001885404C0
		internal void WriteRawVarint32(uint value) {} // 0x000000018854072C-0x00000001885407AC
		internal void WriteRawVarint64(ulong value) {} // 0x00000001885407AC-0x000000018854082C
		internal void WriteRawLittleEndian32(uint value) {} // 0x0000000188540304-0x0000000188540384
		internal void WriteRawLittleEndian64(ulong value) {} // 0x0000000188540384-0x0000000188540404
		internal void WriteRawBytes(byte[] value) {} // 0x0000000188540234-0x0000000188540260
		internal void WriteRawBytes(byte[] value, int offset, int length) {} // 0x0000000188540260-0x0000000188540304
		public void Dispose() {} // 0x000000018853FA70-0x000000018853FAAC
		public void Flush() {} // 0x000000018853FAAC-0x000000018853FB04
		public void CheckNoSpaceLeft() {} // 0x000000018853F904-0x000000018853F910
	}

	public abstract class Extension // TypeDefIndex: 51915
	{
		// Properties
		internal abstract System.Type TargetType { get; }
		public int FieldNumber { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		internal abstract bool IsRepeated { get; }
	
		// Constructors
		protected Extension() {} // Dummy constructor
		protected Extension(int fieldNumber) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		internal abstract IExtensionValue CreateValue();
	}

	public sealed class Extension<TTarget, TValue> : Google.Protobuf.Extension // TypeDefIndex: 51916
		where TTarget : IExtendableMessage<TTarget>
	{
		// Fields
		private readonly FieldCodec<TValue> codec;
	
		// Properties
		internal TValue DefaultValue { get => default; }
		internal override System.Type TargetType { get => default; }
		internal override bool IsRepeated { get => default; }
	
		// Constructors
		public Extension() {} // Dummy constructor
		public Extension(int fieldNumber, FieldCodec<TValue> codec) {}
	
		// Methods
		internal override IExtensionValue CreateValue() => default;
	}

	public sealed class RepeatedExtension<TTarget, TValue> : Google.Protobuf.Extension // TypeDefIndex: 51917
		where TTarget : IExtendableMessage<TTarget>
	{
		// Fields
		private readonly FieldCodec<TValue> codec;
	
		// Properties
		internal override System.Type TargetType { get => default; }
		internal override bool IsRepeated { get => default; }
	
		// Constructors
		public RepeatedExtension() {} // Dummy constructor
		public RepeatedExtension(int fieldNumber, FieldCodec<TValue> codec) {}
	
		// Methods
		internal override IExtensionValue CreateValue() => default;
	}

	public sealed class ExtensionRegistry : ICollection<Google.Protobuf.Extension>, IDeepCloneable<ExtensionRegistry> // TypeDefIndex: 51920
	{
		// Fields
		private IDictionary<ObjectIntPair<System.Type>, Google.Protobuf.Extension> extensions; // 0x10
	
		// Properties
		public int Count { get => default; } // 0x0000000188541B10-0x0000000188541B58 
		bool System.Collections.Generic.ICollection<Google.Protobuf.Extension>.IsReadOnly { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Nested types
		internal sealed class ExtensionComparer : IEqualityComparer<Google.Protobuf.Extension> // TypeDefIndex: 51918
		{
			// Fields
			internal static ExtensionComparer Instance; // 0x00
	
			// Constructors
			public ExtensionComparer() {} // 0x000000018350B670-0x000000018350B680
			static ExtensionComparer() {} // 0x0000000188541100-0x0000000188541164
	
			// Methods
			public bool Equals(Google.Protobuf.Extension a, Google.Protobuf.Extension b) => default; // 0x0000000188540FA4-0x0000000188541078
			public int GetHashCode(Google.Protobuf.Extension a) => default; // 0x0000000188541078-0x0000000188541100
		}
	
		// Constructors
		public ExtensionRegistry() {} // 0x00000001885418C0-0x0000000188541938
		private ExtensionRegistry(IDictionary<ObjectIntPair<System.Type>, Google.Protobuf.Extension> collection) {} // 0x0000000188541938-0x0000000188541B10
	
		// Methods
		internal bool ContainsInputField(uint lastTag, System.Type target, out Google.Protobuf.Extension extension) {
			extension = default;
			return default;
		} // 0x0000000188541434-0x00000001885414D8
		public void Add(Google.Protobuf.Extension extension) {} // 0x00000001885412B8-0x0000000188541384
		public void AddRange(IEnumerable<Google.Protobuf.Extension> extensions) {} // 0x0000000188541164-0x00000001885412B8
		public void Clear() {} // 0x0000000188541384-0x00000001885413D0
		public bool Contains(Google.Protobuf.Extension item) => default; // 0x00000001885414D8-0x00000001885415A4
		void ICollection<Extension>.CopyTo(Google.Protobuf.Extension[] array, int arrayIndex) {} // 0x00000001885416DC-0x00000001885418B8
		public IEnumerator<Google.Protobuf.Extension> GetEnumerator() => default; // 0x00000001885415A4-0x0000000188541610
		public bool Remove(Google.Protobuf.Extension item) => default; // 0x0000000188541610-0x00000001885416DC
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001885418B8-0x00000001885418C0
		public ExtensionRegistry Clone() => default; // 0x00000001885413D0-0x0000000188541434
	}

	public static class ExtensionSet // TypeDefIndex: 51921
	{
		// Methods
		private static bool TryGetValue<TTarget>(ref ExtensionSet<TTarget> set, Google.Protobuf.Extension extension, out IExtensionValue value)
			where TTarget : IExtendableMessage<TTarget> {
			value = default;
			return default;
		}
		public static TValue Get<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension)
			where TTarget : IExtendableMessage<TTarget> => default;
		public static RepeatedField<TValue> Get<TTarget, TValue>(ref ExtensionSet<TTarget> set, RepeatedExtension<TTarget, TValue> extension)
			where TTarget : IExtendableMessage<TTarget> => default;
		public static RepeatedField<TValue> GetOrInitialize<TTarget, TValue>(ref ExtensionSet<TTarget> set, RepeatedExtension<TTarget, TValue> extension)
			where TTarget : IExtendableMessage<TTarget> => default;
		public static void Set<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension, TValue value)
			where TTarget : IExtendableMessage<TTarget> {}
		public static bool Has<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension)
			where TTarget : IExtendableMessage<TTarget> => default;
		public static void Clear<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension)
			where TTarget : IExtendableMessage<TTarget> {}
		public static void Clear<TTarget, TValue>(ref ExtensionSet<TTarget> set, RepeatedExtension<TTarget, TValue> extension)
			where TTarget : IExtendableMessage<TTarget> {}
		public static bool TryMergeFieldFrom<TTarget>(ref ExtensionSet<TTarget> set, CodedInputStream stream)
			where TTarget : IExtendableMessage<TTarget> => default;
		public static bool TryMergeFieldFrom<TTarget>(ref ExtensionSet<TTarget> set, ref ParseContext ctx)
			where TTarget : IExtendableMessage<TTarget> => default;
		public static void MergeFrom<TTarget>(ref ExtensionSet<TTarget> first, ExtensionSet<TTarget> second)
			where TTarget : IExtendableMessage<TTarget> {}
		public static ExtensionSet<TTarget> Clone<TTarget>(ExtensionSet<TTarget> set)
			where TTarget : IExtendableMessage<TTarget> => default;
	}

	public sealed class ExtensionSet<TTarget> // TypeDefIndex: 51923
		where TTarget : IExtendableMessage<TTarget>
	{
		// Properties
		internal Dictionary<int, IExtensionValue> ValuesByNumber { get; }
	
		// Constructors
		public ExtensionSet() {}
	
		// Methods
		public override int GetHashCode() => default;
		public override bool Equals(object other) => default;
		public int CalculateSize() => default;
		public void WriteTo(CodedOutputStream stream) {}
		public void WriteTo(ref WriteContext ctx) {}
		internal bool IsInitialized() => default;
	}

	internal interface IExtensionValue : IEquatable<IExtensionValue>, IDeepCloneable<IExtensionValue> // TypeDefIndex: 51924
	{
		// Methods
		void MergeFrom(ref ParseContext ctx);
		void MergeFrom(IExtensionValue value);
		void WriteTo(ref WriteContext ctx);
		int CalculateSize();
		bool IsInitialized();
		object GetValue();
	}

	internal sealed class ExtensionValue<T> : IExtensionValue // TypeDefIndex: 51925
	{
		// Fields
		private T field;
		private FieldCodec<T> codec;
	
		// Constructors
		public ExtensionValue() {} // Dummy constructor
		internal ExtensionValue(FieldCodec<T> codec) {}
	
		// Methods
		public int CalculateSize() => default;
		public IExtensionValue Clone() => default;
		public bool Equals(IExtensionValue other) => default;
		public override int GetHashCode() => default;
		public void MergeFrom(ref ParseContext ctx) {}
		public void MergeFrom(IExtensionValue value) {}
		public void WriteTo(ref WriteContext ctx) {}
		public T GetValue() => default;
		object IExtensionValue.GetValue() => default;
		public void SetValue(T value) {}
		public bool IsInitialized() => default;
	}

	internal sealed class RepeatedExtensionValue<T> : IExtensionValue // TypeDefIndex: 51926
	{
		// Fields
		private RepeatedField<T> field;
		private readonly FieldCodec<T> codec;
	
		// Constructors
		public RepeatedExtensionValue() {} // Dummy constructor
		internal RepeatedExtensionValue(FieldCodec<T> codec) {}
	
		// Methods
		public int CalculateSize() => default;
		public IExtensionValue Clone() => default;
		public bool Equals(IExtensionValue other) => default;
		public override int GetHashCode() => default;
		public void MergeFrom(ref ParseContext ctx) {}
		public void MergeFrom(IExtensionValue value) {}
		public void WriteTo(ref WriteContext ctx) {}
		public RepeatedField<T> GetValue() => default;
		object IExtensionValue.GetValue() => default;
		public bool IsInitialized() => default;
	}

	public static class FieldCodec // TypeDefIndex: 51939
	{
		// Nested types
		private static class WrapperCodecs // TypeDefIndex: 51928
		{
			// Fields
			private static readonly Dictionary<System.Type, object> Codecs; // 0x00
			private static readonly Dictionary<System.Type, object> Readers; // 0x08
	
			// Constructors
			static WrapperCodecs() {} // 0x000000018855445C-0x0000000188554EB0
	
			// Methods
			internal static FieldCodec<T> GetCodec<T>() => default;
			internal static ValueReader<T?> GetReader<T>()
				where T : struct => default;
			internal static T Read<T>(ref ParseContext ctx, FieldCodec<T> codec) => default;
			internal static void Write<T>(ref WriteContext ctx, T value, FieldCodec<T> codec) {}
			internal static int CalculateSize<T>(T value, FieldCodec<T> codec) => default;
		}
	
		// Methods
		public static FieldCodec<string> ForString(uint tag) => default; // 0x00000001832E9E90-0x00000001832E9ED0
		public static FieldCodec<ByteString> ForBytes(uint tag) => default; // 0x0000000188541B58-0x0000000188541BA8
		public static FieldCodec<bool> ForBool(uint tag) => default; // 0x0000000184276060-0x000000018427606C
		public static FieldCodec<int> ForInt32(uint tag) => default; // 0x0000000184276048-0x0000000184276054
		public static FieldCodec<int> ForSInt32(uint tag) => default; // 0x0000000188542870-0x000000018854287C
		public static FieldCodec<uint> ForFixed32(uint tag) => default; // 0x0000000188541FCC-0x0000000188541FD8
		public static FieldCodec<int> ForSFixed32(uint tag) => default; // 0x0000000188542400-0x000000018854240C
		public static FieldCodec<uint> ForUInt32(uint tag) => default; // 0x000000018427603C-0x0000000184276048
		public static FieldCodec<long> ForInt64(uint tag) => default; // 0x000000018427606C-0x0000000184276078
		public static FieldCodec<long> ForSInt64(uint tag) => default; // 0x0000000188542ACC-0x0000000188542AD8
		public static FieldCodec<ulong> ForFixed64(uint tag) => default; // 0x0000000188541FD8-0x0000000188541FE4
		public static FieldCodec<long> ForSFixed64(uint tag) => default; // 0x0000000188542624-0x0000000188542630
		public static FieldCodec<ulong> ForUInt64(uint tag) => default; // 0x0000000184276768-0x0000000184276774
		public static FieldCodec<float> ForFloat(uint tag) => default; // 0x0000000184276054-0x0000000184276060
		public static FieldCodec<double> ForDouble(uint tag) => default; // 0x0000000188541DBC-0x0000000188541DC8
		public static FieldCodec<T> ForEnum<T>(uint tag, Func<T, int> toInt32, Func<int, T> fromInt32) => default;
		public static FieldCodec<string> ForString(uint tag, string defaultValue) => default; // 0x00000001832E9ED0-0x00000001832EA170
		public static FieldCodec<ByteString> ForBytes(uint tag, ByteString defaultValue) => default; // 0x0000000182F0E210-0x0000000182F0E490
		public static FieldCodec<bool> ForBool(uint tag, bool defaultValue) => default; // 0x00000001832E6A00-0x00000001832E6C70
		public static FieldCodec<int> ForInt32(uint tag, int defaultValue) => default; // 0x00000001832E81E0-0x00000001832E8480
		public static FieldCodec<int> ForSInt32(uint tag, int defaultValue) => default; // 0x0000000188542630-0x0000000188542870
		public static FieldCodec<uint> ForFixed32(uint tag, uint defaultValue) => default; // 0x0000000188541DC8-0x0000000188541FCC
		public static FieldCodec<int> ForSFixed32(uint tag, int defaultValue) => default; // 0x00000001885421FC-0x0000000188542400
		public static FieldCodec<uint> ForUInt32(uint tag, uint defaultValue) => default; // 0x00000001832E3E80-0x00000001832E41E0
		public static FieldCodec<long> ForInt64(uint tag, long defaultValue) => default; // 0x00000001832E6080-0x00000001832E6330
		public static FieldCodec<long> ForSInt64(uint tag, long defaultValue) => default; // 0x000000018854287C-0x0000000188542ACC
		public static FieldCodec<ulong> ForFixed64(uint tag, ulong defaultValue) => default; // 0x0000000188541FE4-0x00000001885421FC
		public static FieldCodec<long> ForSFixed64(uint tag, long defaultValue) => default; // 0x000000018854240C-0x0000000188542624
		public static FieldCodec<ulong> ForUInt64(uint tag, ulong defaultValue) => default; // 0x00000001835D0E10-0x00000001835D10C0
		public static FieldCodec<float> ForFloat(uint tag, float defaultValue) => default; // 0x00000001839DE5B0-0x00000001839DE7F0
		public static FieldCodec<double> ForDouble(uint tag, double defaultValue) => default; // 0x0000000188541BA8-0x0000000188541DBC
		public static FieldCodec<T> ForEnum<T>(uint tag, Func<T, int> toInt32, Func<int, T> fromInt32, T defaultValue) => default;
		public static FieldCodec<T> ForMessage<T>(uint tag, MessageParser<T> parser)
			where T : class, IMessage<T> => default;
		public static FieldCodec<T> ForGroup<T>(uint startTag, uint endTag, MessageParser<T> parser)
			where T : class, IMessage<T> => default;
		public static FieldCodec<T> ForClassWrapper<T>(uint tag)
			where T : class => default;
		public static FieldCodec<T?> ForStructWrapper<T>(uint tag)
			where T : struct => default;
	}

	internal delegate TValue ValueReader<out TValue>(ref ParseContext ctx); // TypeDefIndex: 51940; 0x00000000-0x00000000

	internal delegate void ValueWriter<T>(ref WriteContext ctx, T value); // TypeDefIndex: 51941; 0x00000000-0x00000000

	public sealed class FieldCodec<T> // TypeDefIndex: 51947
	{
		// Fields
		private static readonly EqualityComparer<T> EqualityComparer;
		private static readonly T DefaultDefault;
		private static readonly bool TypeSupportsPacking;
		private readonly int tagSize;
	
		// Properties
		internal bool PackedRepeatedField { get; }
		internal ValueWriter<T> ValueWriter { get; }
		internal Func<T, int> ValueSizeCalculator { get; }
		internal ValueReader<T> ValueReader { get; }
		internal InputMerger ValueMerger { get; }
		internal ValuesMerger FieldMerger { get; }
		internal int FixedSize { get; }
		internal uint Tag { get; }
		internal uint EndTag { get; }
		internal T DefaultValue { get; }
	
		// Nested types
		internal delegate void InputMerger(ref ParseContext ctx, ref ref T value); // TypeDefIndex: 51942; 0x00000000-0x00000000
	
		internal delegate bool ValuesMerger(ref ref T value, T other); // TypeDefIndex: 51943; 0x00000000-0x00000000
	
		// Constructors
		public FieldCodec() {} // Dummy constructor
		static FieldCodec() {}
		internal FieldCodec(ValueReader<T> reader, ValueWriter<T> writer, int fixedSize, uint tag, T defaultValue) {}
		internal FieldCodec(ValueReader<T> reader, ValueWriter<T> writer, Func<T, int> sizeCalculator, uint tag, T defaultValue) {}
		internal FieldCodec(ValueReader<T> reader, ValueWriter<T> writer, InputMerger inputMerger, ValuesMerger valuesMerger, Func<T, int> sizeCalculator, uint tag, uint endTag = 0 /* Metadata: 0x01FD166D */) {}
		internal FieldCodec(ValueReader<T> reader, ValueWriter<T> writer, InputMerger inputMerger, ValuesMerger valuesMerger, Func<T, int> sizeCalculator, uint tag, uint endTag, T defaultValue) {}
	
		// Methods
		internal static bool IsPackedRepeatedField(uint tag) => default;
		public void WriteTagAndValue(CodedOutputStream output, T value) {}
		public void WriteTagAndValue(ref WriteContext ctx, T value) {}
		public T Read(CodedInputStream input) => default;
		public T Read(ref ParseContext ctx) => default;
		public int CalculateSizeWithTag(T value) => default;
		internal int CalculateUnconditionalSizeWithTag(T value) => default;
		private bool IsDefault(T value) => default;
	}

	internal sealed class FieldMaskTree // TypeDefIndex: 51949
	{
		// Fields
		private const char FIELD_PATH_SEPARATOR = '.'; // Metadata: 0x01FD166E
		private readonly Node root; // 0x10
	
		// Nested types
		internal sealed class Node // TypeDefIndex: 51948
		{
			// Properties
			public Dictionary<string, Node> Children { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
			// Constructors
			public Node() {} // 0x0000000188552240-0x00000001885522B8
		}
	
		// Constructors
		public FieldMaskTree() {} // 0x0000000188543E34-0x0000000188543E98
		public FieldMaskTree(FieldMask mask) {} // 0x0000000188543E98-0x0000000188543F18
	
		// Methods
		public override string ToString() => default; // 0x0000000188543E0C-0x0000000188543E34
		public FieldMaskTree AddFieldPath(string path) => default; // 0x0000000188542AD8-0x0000000188542C84
		public FieldMaskTree MergeFromFieldMask(FieldMask mask) => default; // 0x00000001885431A8-0x00000001885432F4
		public FieldMask ToFieldMask() => default; // 0x0000000188543CF4-0x0000000188543E0C
		private void GetFieldPaths(Node node, string path, List<string> paths) {} // 0x0000000188542C84-0x0000000188542EA0
		public void IntersectFieldPath(string path, FieldMaskTree output) {} // 0x0000000188542EA0-0x00000001885431A8
		public void Merge(IMessage source, IMessage destination, FieldMask.MergeOptions options) {} // 0x00000001885432F4-0x0000000188543448
		private void Merge(Node node, string path, IMessage source, IMessage destination, FieldMask.MergeOptions options) {} // 0x0000000188543448-0x0000000188543CF4
	}

	internal static class FrameworkPortability // TypeDefIndex: 51950
	{
		// Fields
		internal static readonly RegexOptions CompiledRegexWhereAvailable; // 0x00
	
		// Constructors
		static FrameworkPortability() {} // 0x0000000188543F18-0x0000000188543FE8
	}

	public interface IBufferMessage : IMessage // TypeDefIndex: 51951
	{
		// Methods
		void InternalMergeFrom(ref ParseContext ctx);
		void InternalWriteTo(ref WriteContext ctx);
	}

	public interface ICustomDiagnosticMessage : IMessage // TypeDefIndex: 51952
	{
		// Methods
		string ToDiagnosticString();
	}

	public interface IDeepCloneable<T> // TypeDefIndex: 51953
	{
		// Methods
		T Clone();
	}

	public interface IExtendableMessage<T> : IMessage<T> // TypeDefIndex: 51954
		where T : IExtendableMessage<T>
	{
		// Methods
		TValue GetExtension<TValue>(Extension<T, TValue> extension);
		RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<T, TValue> extension);
		RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<T, TValue> extension);
		void SetExtension<TValue>(Extension<T, TValue> extension, TValue value);
		bool HasExtension<TValue>(Extension<T, TValue> extension);
		void ClearExtension<TValue>(Extension<T, TValue> extension);
		void ClearExtension<TValue>(RepeatedExtension<T, TValue> extension);
	}

	public interface IMessage // TypeDefIndex: 51955
	{
		// Properties
		MessageDescriptor Descriptor { get; }
	
		// Methods
		void MergeFrom(CodedInputStream input);
		void WriteTo(CodedOutputStream output);
		int CalculateSize();
	}

	public interface IMessage<T> : IMessage, IEquatable<T>, IDeepCloneable<T> // TypeDefIndex: 51956
		where T : IMessage<T>
	{
		// Methods
		void MergeFrom(T message);
	}

	public sealed class InvalidJsonException : IOException // TypeDefIndex: 51957
	{
		// Constructors
		public InvalidJsonException() {} // Dummy constructor
		internal InvalidJsonException(string message) {} // 0x0000000188543FE8-0x0000000188544008
	}

	public sealed class InvalidProtocolBufferException : IOException // TypeDefIndex: 51958
	{
		// Constructors
		public InvalidProtocolBufferException() {} // Dummy constructor
		internal InvalidProtocolBufferException(string message) {} // 0x0000000188543FE8-0x0000000188544008
		internal InvalidProtocolBufferException(string message, Exception innerException) {} // 0x000000018854452C-0x0000000188544534
	
		// Methods
		internal static InvalidProtocolBufferException MoreDataAvailable() => default; // 0x0000000188544338-0x000000018854439C
		internal static InvalidProtocolBufferException TruncatedMessage() => default; // 0x00000001885444C8-0x000000018854452C
		internal static InvalidProtocolBufferException NegativeSize() => default; // 0x000000018854439C-0x0000000188544400
		internal static InvalidProtocolBufferException MalformedVarint() => default; // 0x0000000188544270-0x00000001885442D4
		internal static InvalidProtocolBufferException InvalidTag() => default; // 0x0000000188544144-0x00000001885441A8
		internal static InvalidProtocolBufferException InvalidWireType() => default; // 0x00000001885441A8-0x000000018854420C
		internal static InvalidProtocolBufferException InvalidBase64(Exception innerException) => default; // 0x0000000188544008-0x000000018854407C
		internal static InvalidProtocolBufferException InvalidEndTag() => default; // 0x000000018854407C-0x00000001885440E0
		internal static InvalidProtocolBufferException RecursionLimitExceeded() => default; // 0x0000000188544400-0x0000000188544464
		internal static InvalidProtocolBufferException JsonRecursionLimitExceeded() => default; // 0x000000018854420C-0x0000000188544270
		internal static InvalidProtocolBufferException SizeLimitExceeded() => default; // 0x0000000188544464-0x00000001885444C8
		internal static InvalidProtocolBufferException InvalidMessageStreamTag() => default; // 0x00000001885440E0-0x0000000188544144
		internal static InvalidProtocolBufferException MissingFields() => default; // 0x00000001885442D4-0x0000000188544338
	}

	public sealed class JsonFormatter // TypeDefIndex: 51962
	{
		// Fields
		internal const string AnyTypeUrlField = "@type"; // Metadata: 0x01FD1670
		internal const string AnyDiagnosticValueField = "@value"; // Metadata: 0x01FD1676
		internal const string AnyWellKnownTypeValueField = "value"; // Metadata: 0x01FD167D
		private const string TypeUrlPrefix = "type.googleapis.com"; // Metadata: 0x01FD1683
		private const string NameValueSeparator = ": "; // Metadata: 0x01FD1697
		private const string PropertySeparator = ", "; // Metadata: 0x01FD169A
		private static readonly JsonFormatter diagnosticFormatter; // 0x08
		private static readonly string[] CommonRepresentations; // 0x10
		private readonly Settings settings; // 0x10
		private const string Hex = "0123456789abcdef"; // Metadata: 0x01FD169D
	
		// Properties
		public static JsonFormatter Default { get; } // 0x000000018854975C-0x00000001885497AC 
		private bool DiagnosticOnly { get => default; } // 0x00000001885497AC-0x00000001885497F8 
	
		// Nested types
		public sealed class Settings // TypeDefIndex: 51959
		{
			// Properties
			public static Settings Default { get; } // 0x000000018855368C-0x00000001885536DC 
			public bool FormatDefaultValues { get; } // 0x00000001811797F0-0x0000000181179800 
			public TypeRegistry TypeRegistry { get; } // 0x0000000181041090-0x00000001810410A0 
			public bool FormatEnumsAsIntegers { get; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
			public bool PreserveProtoFieldNames { get; } // 0x0000000183D4F070-0x0000000183D4F080 
	
			// Constructors
			public Settings() {} // Dummy constructor
			static Settings() {} // 0x00000001885533A8-0x000000018855341C
			public Settings(bool formatDefaultValues) {} // 0x0000000188553490-0x00000001885534E8
			public Settings(bool formatDefaultValues, TypeRegistry typeRegistry) {} // 0x000000018855355C-0x000000018855357C
			private Settings(bool formatDefaultValues, TypeRegistry typeRegistry, bool formatEnumsAsIntegers, bool preserveProtoFieldNames) {} // 0x000000018855357C-0x0000000188553604
	
			// Methods
			public Settings WithFormatDefaultValues(bool formatDefaultValues) => default; // 0x0000000188552F70-0x000000018855300C
			public Settings WithTypeRegistry(TypeRegistry typeRegistry) => default; // 0x0000000188553254-0x00000001885532F0
			public Settings WithFormatEnumsAsIntegers(bool formatEnumsAsIntegers) => default; // 0x000000018855300C-0x00000001885530A8
			public Settings WithPreserveProtoFieldNames(bool preserveProtoFieldNames) => default; // 0x0000000188553130-0x00000001885531CC
		}
	
		private static class OriginalEnumValueHelper // TypeDefIndex: 51961
		{
			// Fields
			private static readonly Dictionary<System.Type, Dictionary<object, string>> dictionaries; // 0x00
	
			// Constructors
			static OriginalEnumValueHelper() {} // 0x0000000188552818-0x00000001885528A4
	
			// Methods
			[UnconditionalSuppressMessage("Trimming", "IL2072", Justification = "The field for the value must still be present. It will be returned by reflection, will be in this collection, and its name can be resolved.")]
			internal static string GetOriginalName(object value) => default; // 0x0000000188552614-0x0000000188552818
			private static Dictionary<object, string> GetNameMapping([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)] System.Type enumType) => default; // 0x00000001885522B8-0x0000000188552614
		}
	
		// Constructors
		public JsonFormatter() {} // Dummy constructor
		static JsonFormatter() {} // 0x000000018854854C-0x00000001885496F4
		public JsonFormatter(Settings settings) {} // 0x00000001885496F4-0x000000018854975C
	
		// Methods
		public string Format(IMessage message) => default; // 0x0000000188544534-0x00000001885445B8
		public void Format(IMessage message, TextWriter writer) {} // 0x00000001885445B8-0x00000001885446C8
		public static string ToDiagnosticString(IMessage message) => default; // 0x0000000188544CE0-0x0000000188544D6C
		private void WriteMessage(TextWriter writer, IMessage message) {} // 0x0000000188546D4C-0x0000000188546EE8
		private bool WriteMessageFields(TextWriter writer, IMessage message, bool assumeFirstFieldWritten) => default; // 0x0000000188546A28-0x0000000188546D4C
		private bool ShouldFormatFieldValue(IMessage message, FieldDescriptor field, object value) => default; // 0x0000000188544C34-0x0000000188544CE0
		internal static string ToJsonName(string name) => default; // 0x0000000188544D6C-0x0000000188544E78
		internal static string FromJsonName(string name) => default; // 0x00000001885446C8-0x00000001885447CC
		private static void WriteNull(TextWriter writer) {} // 0x0000000188546EE8-0x0000000188546F34
		private static bool IsDefaultValue(FieldDescriptor descriptor, object value) => default; // 0x00000001885448E8-0x0000000188544C34
		public void WriteValue(TextWriter writer, object value) {} // 0x0000000188547A94-0x00000001885480DC
		private void WriteWellKnownTypeValue(TextWriter writer, MessageDescriptor descriptor, object value) {} // 0x00000001885480DC-0x000000018854854C
		private void WriteTimestamp(TextWriter writer, IMessage value) {} // 0x0000000188547908-0x0000000188547A94
		private void WriteDuration(TextWriter writer, IMessage value) {} // 0x000000018854654C-0x00000001885466D8
		private void WriteFieldMask(TextWriter writer, IMessage value) {} // 0x00000001885466D8-0x00000001885467E4
		private void WriteAny(TextWriter writer, IMessage value) {} // 0x0000000188544E78-0x0000000188545234
		private void WriteDiagnosticOnlyAny(TextWriter writer, IMessage value) {} // 0x0000000188545234-0x00000001885454C0
		private void WriteStruct(TextWriter writer, IMessage message) {} // 0x00000001885474D8-0x0000000188547908
		private void WriteStructFieldValue(TextWriter writer, IMessage message) {} // 0x0000000188547258-0x00000001885474D8
		internal void WriteList(TextWriter writer, IList list) {} // 0x00000001885467E4-0x0000000188546A28
		internal void WriteDictionary(TextWriter writer, IDictionary dictionary) {} // 0x00000001885454C0-0x000000018854654C
		internal static void WriteString(TextWriter writer, string text) {} // 0x0000000188546F34-0x0000000188547258
		private static void HexEncodeUtf16CodeUnit(TextWriter writer, char c) {} // 0x00000001885447CC-0x00000001885448E8
	}

	public sealed class JsonParser // TypeDefIndex: 51965
	{
		// Fields
		private static readonly Regex TimestampRegex; // 0x00
		private static readonly Regex DurationRegex; // 0x08
		private static readonly int[] SubsecondScalingFactors; // 0x10
		private static readonly char[] FieldMaskPathSeparators; // 0x18
		private static readonly EnumDescriptor NullValueDescriptor; // 0x20
		private static readonly JsonParser defaultInstance; // 0x28
		private static readonly Dictionary<string, Action<JsonParser, IMessage, JsonTokenizer>> WellKnownTypeHandlers; // 0x30
		private readonly Settings settings; // 0x10
	
		// Properties
		public static JsonParser Default { get => default; } // 0x000000018854E660-0x000000018854E6B0 
	
		// Nested types
		public sealed class Settings // TypeDefIndex: 51963
		{
			// Properties
			public static Settings Default { get; } // 0x00000001885536DC-0x000000018855372C 
			public int RecursionLimit { get; } // 0x0000000183D4E340-0x0000000183D4E350 
			public TypeRegistry TypeRegistry { get; } // 0x0000000181041090-0x00000001810410A0 
			public bool IgnoreUnknownFields { get; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
	
			// Constructors
			public Settings() {} // Dummy constructor
			static Settings() {} // 0x000000018855341C-0x0000000188553490
			private Settings(int recursionLimit, TypeRegistry typeRegistry, bool ignoreUnknownFields) {} // 0x0000000188553604-0x000000018855368C
			public Settings(int recursionLimit) {} // 0x0000000188553504-0x000000018855355C
			public Settings(int recursionLimit, TypeRegistry typeRegistry) {} // 0x00000001885534E8-0x0000000188553504
	
			// Methods
			public Settings WithIgnoreUnknownFields(bool ignoreUnknownFields) => default; // 0x00000001885530A8-0x0000000188553130
			public Settings WithRecursionLimit(int recursionLimit) => default; // 0x00000001885531CC-0x0000000188553254
			public Settings WithTypeRegistry(TypeRegistry typeRegistry) => default; // 0x00000001885532F0-0x00000001885533A8
		}
	
		// Constructors
		public JsonParser() {} // Dummy constructor
		public JsonParser(Settings settings) {} // 0x000000018854E5F8-0x000000018854E660
		static JsonParser() {} // 0x000000018854DA34-0x000000018854E5F8
	
		// Methods
		private static void MergeWrapperField(JsonParser parser, IMessage message, JsonTokenizer tokenizer) {} // 0x000000018854BA38-0x000000018854BAD4
		internal void Merge(IMessage message, string json) {} // 0x000000018854C074-0x000000018854C0FC
		internal void Merge(IMessage message, TextReader jsonReader) {} // 0x000000018854BF94-0x000000018854C074
		private void Merge(IMessage message, JsonTokenizer tokenizer) {} // 0x000000018854BAD4-0x000000018854BF94
		private void MergeField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer) {} // 0x000000018854A6A0-0x000000018854A824
		private void MergeRepeatedField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer) {} // 0x000000018854AAB0-0x000000018854AC98
		private void MergeMapField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer) {} // 0x000000018854A824-0x000000018854AAB0
		private static bool IsGoogleProtobufValueField(FieldDescriptor field) => default; // 0x0000000188549A0C-0x0000000188549A8C
		private static bool IsGoogleProtobufNullValueField(FieldDescriptor field) => default; // 0x0000000188549984-0x0000000188549A0C
		private object ParseSingleValue(FieldDescriptor field, JsonTokenizer tokenizer) => default; // 0x000000018854D24C-0x000000018854D5B8
		public T Parse<T>(string json)
			where T : IMessage, new() => default;
		public T Parse<T>(TextReader jsonReader)
			where T : IMessage, new() => default;
		public IMessage Parse(string json, MessageDescriptor descriptor) => default; // 0x000000018854D680-0x000000018854D764
		public IMessage Parse(TextReader jsonReader, MessageDescriptor descriptor) => default; // 0x000000018854D5B8-0x000000018854D680
		private void MergeStructValue(IMessage message, JsonTokenizer tokenizer) {} // 0x000000018854AC98-0x000000018854AFBC
		private void MergeStruct(IMessage message, JsonTokenizer tokenizer) {} // 0x000000018854AFBC-0x000000018854B0DC
		private void MergeAny(IMessage message, JsonTokenizer tokenizer) {} // 0x0000000188549A8C-0x0000000188549EB8
		private void MergeWellKnownTypeAnyBody(IMessage body, JsonTokenizer tokenizer) {} // 0x000000018854B8D4-0x000000018854BA38
		private static object ParseMapKey(FieldDescriptor field, string keyText) => default; // 0x000000018854C12C-0x000000018854C598
		private static object ParseSingleNumberValue(FieldDescriptor field, JsonToken token) => default; // 0x000000018854C598-0x000000018854CB7C
		private static void CheckInteger(double value) {} // 0x00000001885497F8-0x0000000188549984
		private static object ParseSingleStringValue(FieldDescriptor field, string text) => default; // 0x000000018854CB7C-0x000000018854D24C
		private static IMessage NewMessageForField(FieldDescriptor field) => default; // 0x000000018854C0FC-0x000000018854C12C
		private static T ParseNumericString<T>(string text, Func<string, NumberStyles, IFormatProvider, T> parser) => default;
		private static void ValidateInfinityAndNan(string text, bool isPositiveInfinity, bool isNegativeInfinity, bool isNaN) {} // 0x000000018854D914-0x000000018854DA34
		private static void MergeTimestamp(IMessage message, JsonToken token) {} // 0x000000018854B0DC-0x000000018854B8D4
		private static void MergeDuration(IMessage message, JsonToken token) {} // 0x0000000188549EB8-0x000000018854A4D8
		private static void MergeFieldMask(IMessage message, JsonToken token) {} // 0x000000018854A4D8-0x000000018854A6A0
		private static string ToSnakeCase(string text) => default; // 0x000000018854D764-0x000000018854D914
	}

	internal sealed class JsonToken : IEquatable<JsonToken> // TypeDefIndex: 51967
	{
		// Fields
		private static readonly JsonToken _true; // 0x00
		private static readonly JsonToken _false; // 0x08
		private static readonly JsonToken _null; // 0x10
		private static readonly JsonToken startObject; // 0x18
		private static readonly JsonToken endObject; // 0x20
		private static readonly JsonToken startArray; // 0x28
		private static readonly JsonToken endArray; // 0x30
		private static readonly JsonToken endDocument; // 0x38
		private readonly TokenType type; // 0x10
		private readonly string stringValue; // 0x18
		private readonly double numberValue; // 0x20
	
		// Properties
		internal static JsonToken Null { get => default; } // 0x0000000188550938-0x0000000188550988 
		internal static JsonToken False { get => default; } // 0x00000001885508E8-0x0000000188550938 
		internal static JsonToken True { get => default; } // 0x0000000188550A28-0x0000000188550A78 
		internal static JsonToken StartObject { get => default; } // 0x00000001885509D8-0x0000000188550A28 
		internal static JsonToken EndObject { get => default; } // 0x0000000188550898-0x00000001885508E8 
		internal static JsonToken StartArray { get => default; } // 0x0000000188550988-0x00000001885509D8 
		internal static JsonToken EndArray { get => default; } // 0x00000001885507F8-0x0000000188550848 
		internal static JsonToken EndDocument { get => default; } // 0x0000000188550848-0x0000000188550898 
		internal TokenType Type { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
		internal string StringValue { get => default; } // 0x0000000181041090-0x00000001810410A0 
		internal double NumberValue { get => default; } // 0x0000000183D4F1C0-0x0000000183D4F1D0 
	
		// Nested types
		internal enum TokenType // TypeDefIndex: 51966
		{
			Null = 0,
			False = 1,
			True = 2,
			StringValue = 3,
			Number = 4,
			Name = 5,
			StartObject = 6,
			EndObject = 7,
			StartArray = 8,
			EndArray = 9,
			EndDocument = 10
		}
	
		// Constructors
		public JsonToken() {} // Dummy constructor
		private JsonToken(TokenType type, string stringValue = null, double numberValue = 0 /* Metadata: 0x01FD16AE */) {} // 0x00000001885507D4-0x00000001885507F8
		static JsonToken() {} // 0x00000001885504E8-0x00000001885507D4
	
		// Methods
		internal static JsonToken Name(string name) => default; // 0x0000000188550170-0x00000001885501DC
		internal static JsonToken Value(string value) => default; // 0x000000018855047C-0x00000001885504E8
		internal static JsonToken Value(double value) => default; // 0x0000000188550410-0x000000018855047C
		public override bool Equals(object obj) => default; // 0x0000000188550098-0x00000001885500FC
		public override int GetHashCode() => default; // 0x00000001885500FC-0x0000000188550170
		public override string ToString() => default; // 0x00000001885501DC-0x0000000188550410
		public bool Equals(JsonToken other) => default; // 0x0000000188550044-0x0000000188550098
	}

	internal abstract class JsonTokenizer // TypeDefIndex: 51973
	{
		// Fields
		private JsonToken bufferedToken; // 0x10
	
		// Properties
		internal int ObjectDepth { get; private set; } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
	
		// Nested types
		private class JsonReplayTokenizer : JsonTokenizer // TypeDefIndex: 51968
		{
			// Fields
			private readonly IList<JsonToken> tokens; // 0x20
			private readonly JsonTokenizer nextTokenizer; // 0x28
			private int nextTokenIndex; // 0x30
	
			// Constructors
			public JsonReplayTokenizer() {} // Dummy constructor
			internal JsonReplayTokenizer(IList<JsonToken> tokens, JsonTokenizer nextTokenizer) {} // 0x000000018854E740-0x000000018854E768
	
			// Methods
			protected override JsonToken NextImpl() => default; // 0x000000018854E6B0-0x000000018854E740
		}
	
		private sealed class JsonTextTokenizer : JsonTokenizer // TypeDefIndex: 51972
		{
			// Fields
			private static readonly State ValueStates; // 0x00
			private readonly Stack<ContainerType> containerStack; // 0x20
			private readonly PushBackReader reader; // 0x28
			private State state; // 0x30
	
			// Nested types
			private enum ContainerType // TypeDefIndex: 51969
			{
				Document = 0,
				Object = 1,
				Array = 2
			}
	
			[Flags]
			private enum State // TypeDefIndex: 51970
			{
				StartOfDocument = 1,
				ExpectedEndOfDocument = 2,
				ReaderExhausted = 4,
				ObjectStart = 8,
				ObjectBeforeColon = 16,
				ObjectAfterColon = 32,
				ObjectAfterProperty = 64,
				ObjectAfterComma = 128,
				ArrayStart = 256,
				ArrayAfterValue = 512,
				ArrayAfterComma = 1024
			}
	
			private class PushBackReader // TypeDefIndex: 51971
			{
				// Fields
				private readonly TextReader reader; // 0x10
				private char? nextChar; // 0x18
	
				// Constructors
				public PushBackReader() {} // Dummy constructor
				internal PushBackReader(TextReader reader) {} // 0x000000018426FEE0-0x000000018426FEF0
	
				// Methods
				internal char? Read() => default; // 0x0000000188552EF4-0x0000000188552F70
				internal char ReadOrFail(string messageOnFailure) => default; // 0x0000000188552E64-0x0000000188552EF4
				internal void PushBack(char c) {} // 0x0000000188552DB0-0x0000000188552E64
				internal InvalidJsonException CreateException(string message) => default; // 0x0000000188552D50-0x0000000188552DB0
			}
	
			// Constructors
			public JsonTextTokenizer() {} // Dummy constructor
			internal JsonTextTokenizer(TextReader reader) {} // 0x000000018854FF5C-0x0000000188550044
			static JsonTextTokenizer() {} // 0x000000018854FF20-0x000000018854FF5C
	
			// Methods
			protected override JsonToken NextImpl() => default; // 0x000000018854E994-0x000000018854F054
			private void ValidateState(State validStates, string errorPrefix) {} // 0x000000018854FE84-0x000000018854FF20
			private string ReadString() => default; // 0x000000018854FA24-0x000000018854FC5C
			private char ReadEscapedCharacter() => default; // 0x000000018854F18C-0x000000018854F2F8
			private char ReadUnicodeEscape() => default; // 0x000000018854FC5C-0x000000018854FD94
			private void ConsumeLiteral(string text) {} // 0x000000018854E840-0x000000018854E994
			private double ReadNumber(char initialCharacter) => default; // 0x000000018854F6A8-0x000000018854FA24
			private char? ReadInt(StringBuilder builder) => default; // 0x000000018854F578-0x000000018854F6A8
			private char? ReadFrac(StringBuilder builder) => default; // 0x000000018854F4E4-0x000000018854F578
			private char? ReadExp(StringBuilder builder) => default; // 0x000000018854F2F8-0x000000018854F4E4
			private char? ConsumeDigits(StringBuilder builder, out int count) {
				count = default;
				return default;
			} // 0x000000018854E768-0x000000018854E840
			private void ValidateAndModifyStateForValue(string errorPrefix) {} // 0x000000018854FD94-0x000000018854FE84
			private void PopContainer() {} // 0x000000018854F054-0x000000018854F18C
		}
	
		// Constructors
		protected JsonTokenizer() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal static JsonTokenizer FromTextReader(TextReader reader) => default; // 0x0000000188550AE8-0x0000000188550B48
		internal static JsonTokenizer FromReplayedTokens(IList<JsonToken> tokens, JsonTokenizer continuation) => default; // 0x0000000188550A78-0x0000000188550AE8
		internal void PushBack(JsonToken token) {} // 0x0000000188550BB8-0x0000000188550C50
		internal JsonToken Next() => default; // 0x0000000188550B48-0x0000000188550BB8
		protected abstract JsonToken NextImpl();
		internal void SkipValue() {} // 0x0000000188550C50-0x0000000188550CA0
	}

	internal sealed class LimitedInputStream : Stream // TypeDefIndex: 51974
	{
		// Fields
		private readonly Stream proxied; // 0x28
		private int bytesLeft; // 0x30
	
		// Properties
		public override bool CanRead { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool CanSeek { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool CanWrite { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override long Length { get => default; } // 0x0000000188550E84-0x0000000188550ED0 
		public override long Position { get => default; set {} } // 0x0000000188550ED0-0x0000000188550F1C 0x0000000188550F1C-0x0000000188550F68
	
		// Constructors
		public LimitedInputStream() {} // Dummy constructor
		internal LimitedInputStream(Stream proxied, int size) {} // 0x0000000188550E24-0x0000000188550E84
	
		// Methods
		public override void Flush() {} // 0x000000018350B670-0x000000018350B680
		public override int Read(byte[] buffer, int offset, int count) => default; // 0x0000000188550CA0-0x0000000188550D40
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x0000000188550D40-0x0000000188550D8C
		public override void SetLength(long value) {} // 0x0000000188550D8C-0x0000000188550DD8
		public override void Write(byte[] buffer, int offset, int count) {} // 0x0000000188550DD8-0x0000000188550E24
	}

	public static class MessageExtensions // TypeDefIndex: 51976
	{
		// Extension methods
		public static void MergeFrom(this IMessage message, byte[] data) {} // 0x0000000188551348-0x0000000188551368
		public static void MergeFrom(this IMessage message, byte[] data, int offset, int length) {} // 0x0000000184272670-0x0000000184272690
		public static void MergeFrom(this IMessage message, ByteString data) {} // 0x0000000188551210-0x0000000188551230
		public static void MergeFrom(this IMessage message, Stream input) {} // 0x0000000188551230-0x0000000188551250
		public static void MergeFrom(this IMessage message, ReadOnlySpan<byte> span) {} // 0x000000018427262C-0x0000000184272658
		public static void MergeDelimitedFrom(this IMessage message, Stream input) {} // 0x00000001885511F0-0x0000000188551210
		public static byte[] ToByteArray(this IMessage message) => default; // 0x0000000188551670-0x0000000188551760
		public static int WriteToByteArray(this IMessage message, byte[] buffer, int pos) => default; // 0x00000001824D1E10-0x00000001824D1FD0
		public static void WriteTo(this IMessage message, Stream output) {} // 0x00000001885518E8-0x00000001885519D4
		public static void WriteDelimitedTo(this IMessage message, Stream output) {} // 0x00000001885517DC-0x00000001885518E8
		public static ByteString ToByteString(this IMessage message) => default; // 0x0000000188551760-0x00000001885517DC
		public static void WriteTo(this IMessage message, IBufferWriter<byte> output) {} // 0x0000000188551AA8-0x0000000188551BB0
		public static void WriteTo(this IMessage message, Span<byte> output) {} // 0x00000001885519D4-0x0000000188551AA8
		public static bool IsInitialized(this IMessage message) => default; // 0x0000000188550F68-0x00000001885510EC
		internal static void MergeFrom(this IMessage message, byte[] data, bool discardUnknownFields, ExtensionRegistry registry) {} // 0x0000000188551368-0x0000000188551484
		internal static void MergeFrom(this IMessage message, byte[] data, int offset, int length, bool discardUnknownFields, ExtensionRegistry registry) {} // 0x00000001824D1780-0x00000001824D1940
		internal static void MergeFrom(this IMessage message, ByteString data, bool discardUnknownFields, ExtensionRegistry registry) {} // 0x0000000188551250-0x0000000188551348
		internal static void MergeFrom(this IMessage message, Stream input, bool discardUnknownFields, ExtensionRegistry registry) {} // 0x0000000188551484-0x00000001885515A4
		internal static void MergeFrom(this IMessage message, ReadOnlySequence<byte> data, bool discardUnknownFields, ExtensionRegistry registry) {} // 0x00000001885515A4-0x0000000188551670
		internal static void MergeFrom(this IMessage message, ReadOnlySpan<byte> data, bool discardUnknownFields, ExtensionRegistry registry) {} // 0x000000018307A230-0x000000018307A3A0
		internal static void MergeDelimitedFrom(this IMessage message, Stream input, bool discardUnknownFields, ExtensionRegistry registry) {} // 0x00000001885510EC-0x00000001885511F0
	}

	public class MessageParser // TypeDefIndex: 51977
	{
		// Fields
		private Func<IMessage> factory; // 0x10
	
		// Properties
		internal bool DiscardUnknownFields { get; } // 0x0000000181002A50-0x0000000181002A60 
		internal ExtensionRegistry Extensions { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public MessageParser() {} // Dummy constructor
		internal MessageParser(Func<IMessage> factory, bool discardUnknownFields, ExtensionRegistry extensions) {} // 0x0000000183240600-0x0000000183240630
	
		// Methods
		internal IMessage CreateTemplate() => default; // 0x0000000188551BB0-0x0000000188551BD0
		public IMessage ParseFrom(byte[] data) => default; // 0x0000000188551F2C-0x0000000188551F88
		public IMessage ParseFrom(byte[] data, int offset, int length) => default; // 0x0000000188551DF0-0x0000000188551E74
		public IMessage ParseFrom(ByteString data) => default; // 0x0000000188551ED0-0x0000000188551F2C
		public IMessage ParseFrom(Stream input) => default; // 0x0000000188551E74-0x0000000188551ED0
		public IMessage ParseFrom(ReadOnlySequence<byte> data) => default; // 0x0000000188551FF0-0x0000000188552060
		public IMessage ParseFrom(ReadOnlySpan<byte> data) => default; // 0x0000000188551F88-0x0000000188551FF0
		public IMessage ParseDelimitedFrom(Stream input) => default; // 0x0000000188551D94-0x0000000188551DF0
		public IMessage ParseFrom(CodedInputStream input) => default; // 0x0000000188552060-0x00000001885520B4
		public IMessage ParseJson(string json) => default; // 0x00000001885520B4-0x0000000188552130
		internal void MergeFrom(IMessage message, CodedInputStream codedInput) {} // 0x0000000188551BD0-0x0000000188551D94
		public MessageParser WithDiscardUnknownFields(bool discardUnknownFields) => default; // 0x0000000188552130-0x00000001885521B8
		public MessageParser WithExtensionRegistry(ExtensionRegistry registry) => default; // 0x00000001885521B8-0x0000000188552240
	}

	public sealed class MessageParser<T> : MessageParser // TypeDefIndex: 51979
		where T : IMessage<T>
	{
		// Fields
		private readonly Func<T> factory;
	
		// Constructors
		public MessageParser() {} // Dummy constructor
		public MessageParser(Func<T> factory) {}
		internal MessageParser(Func<T> factory, bool discardUnknownFields, ExtensionRegistry extensions) {}
	
		// Methods
		internal new T CreateTemplate() => default;
		public new T ParseFrom(byte[] data) => default;
		public new T ParseFrom(byte[] data, int offset, int length) => default;
		public new T ParseFrom(ByteString data) => default;
		public new T ParseFrom(Stream input) => default;
		public new T ParseFrom(ReadOnlySequence<byte> data) => default;
		public new T ParseFrom(ReadOnlySpan<byte> data) => default;
		public new T ParseDelimitedFrom(Stream input) => default;
		public new T ParseFrom(CodedInputStream input) => default;
		public new T ParseJson(string json) => default;
		public new MessageParser<T> WithDiscardUnknownFields(bool discardUnknownFields) => default;
		public new MessageParser<T> WithExtensionRegistry(ExtensionRegistry registry) => default;
	}

	internal struct ObjectIntPair<T> : IEquatable<ObjectIntPair<T>> // TypeDefIndex: 51980
		where T : class
	{
		// Fields
		private readonly int number;
		private readonly T obj;
	
		// Constructors
		internal ObjectIntPair(T obj, int number) {
			this.number = default;
			this.obj = default;
		}
	
		// Methods
		public bool Equals(ObjectIntPair<T> other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct ParseContext // TypeDefIndex: 51981
	{
		// Fields
		internal const int DefaultRecursionLimit = 100; // Metadata: 0x01FD16D4
		internal const int DefaultSizeLimit = 2147483647; // Metadata: 0x01FD16D6
		internal ReadOnlySpan<byte> buffer; // 0x00
		internal ParserInternalState state; // 0x10
	
		// Properties
		internal uint LastTag { get => default; } // 0x0000000183D4F0C0-0x0000000183D4F0D0 
		internal bool DiscardUnknownFields { get => default; set {} } // 0x0000000183D51AD0-0x0000000183D51AE0 0x0000000183D51B30-0x0000000183D51B40
		internal ExtensionRegistry ExtensionRegistry { get => default; set {} } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000184274DA0-0x0000000184274DB4
	
		// Methods
		internal static void Initialize(ReadOnlySpan<byte> buffer, out ParseContext ctx) {
			ctx = default;
		} // 0x0000000188552A94-0x0000000188552B58
		internal static void Initialize(ReadOnlySpan<byte> buffer, ref ParserInternalState state, out ParseContext ctx) {
			ctx = default;
		} // 0x0000000183D6BB50-0x0000000183D6BBC0
		internal static void Initialize(CodedInputStream input, out ParseContext ctx) {
			ctx = default;
		} // 0x00000001885529C8-0x0000000188552A94
		internal static void Initialize(ReadOnlySequence<byte> input, out ParseContext ctx) {
			ctx = default;
		} // 0x000000018855299C-0x00000001885529C8
		internal static void Initialize(ReadOnlySequence<byte> input, int recursionLimit, out ParseContext ctx) {
			ctx = default;
		} // 0x00000001885528E8-0x000000018855299C
		public uint ReadTag() => default; // 0x0000000188552D44-0x0000000188552D50
		public double ReadDouble() => default; // 0x0000000188552BF4-0x0000000188552C00
		public float ReadFloat() => default; // 0x0000000188552C24-0x0000000188552C30
		public ulong ReadUInt64() => default; // 0x0000000188552C8C-0x0000000188552C98
		public long ReadInt64() => default; // 0x0000000188552C8C-0x0000000188552C98
		public int ReadInt32() => default; // 0x0000000188552C00-0x0000000188552C0C
		public ulong ReadFixed64() => default; // 0x0000000188552C18-0x0000000188552C24
		public uint ReadFixed32() => default; // 0x0000000188552C0C-0x0000000188552C18
		public bool ReadBool() => default; // 0x0000000188552BCC-0x0000000188552BE8
		public string ReadString() => default; // 0x0000000188552D38-0x0000000188552D44
		public void ReadMessage(IMessage message) {} // 0x0000000188552C98-0x0000000188552CF4
		public void ReadGroup(IMessage message) {} // 0x0000000188552C30-0x0000000188552C8C
		public ByteString ReadBytes() => default; // 0x0000000188552BE8-0x0000000188552BF4
		public uint ReadUInt32() => default; // 0x0000000188552C00-0x0000000188552C0C
		public int ReadEnum() => default; // 0x0000000188552C00-0x0000000188552C0C
		public int ReadSFixed32() => default; // 0x0000000188552C0C-0x0000000188552C18
		public long ReadSFixed64() => default; // 0x0000000188552C18-0x0000000188552C24
		public int ReadSInt32() => default; // 0x0000000188552CF4-0x0000000188552D14
		public long ReadSInt64() => default; // 0x0000000188552D14-0x0000000188552D38
		public int ReadLength() => default; // 0x0000000188552C00-0x0000000188552C0C
		internal void CopyStateTo(CodedInputStream input) {} // 0x0000000183171C20-0x0000000183171CA0
		internal void LoadStateFrom(CodedInputStream input) {} // 0x0000000188552B58-0x0000000188552BCC
	}

	internal struct ParserInternalState // TypeDefIndex: 51982
	{
		// Fields
		internal int bufferPos; // 0x00
		internal int bufferSize; // 0x04
		internal int bufferSizeAfterLimit; // 0x08
		internal int currentLimit; // 0x0C
		internal int totalBytesRetired; // 0x10
		internal int recursionDepth; // 0x14
		internal SegmentedBufferHelper segmentedBufferHelper; // 0x18
		internal uint lastTag; // 0x60
		internal uint nextTag; // 0x64
		internal bool hasNextTag; // 0x68
		internal int sizeLimit; // 0x6C
		internal int recursionLimit; // 0x70
	
		// Properties
		internal CodedInputStream CodedInputStream { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		internal bool DiscardUnknownFields { [IsReadOnly] get; set; } // 0x0000000183D58980-0x0000000183D58990 0x0000000183D5BFE0-0x0000000183D5BFF0
		internal ExtensionRegistry ExtensionRegistry { [IsReadOnly] get; set; } // 0x0000000183D4EB20-0x0000000183D4EB30 0x00000001851DFCA4-0x00000001851DFCB4
	}

	internal static class ParsingPrimitives // TypeDefIndex: 51983
	{
		// Fields
		private const int StackallocThreshold = 256; // Metadata: 0x01FD16D7
	
		// Methods
		public static int ParseLength(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855D2E0-0x000000018855D2E8
		public static uint ParseTag(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x00000001823A7E60-0x00000001823A7F80
		public static bool MaybeConsumeTag(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, uint tag) => default; // 0x0000000182BCF140-0x0000000182BCF1A0
		public static uint PeekTag(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x0000000182BCF1A0-0x0000000182BCF1E0
		public static ulong ParseRawVarint64(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x00000001823C4190-0x00000001823C4290
		private static ulong ParseRawVarint64SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x00000001823C4290-0x00000001823C4310
		public static uint ParseRawVarint32(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x00000001823A7F80-0x00000001823A80F0
		private static uint ParseRawVarint32SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x00000001823A8E70-0x00000001823A8F70
		public static uint ParseRawLittleEndian32(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855D374-0x000000018855D400
		private static uint ParseRawLittleEndian32SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855D2E8-0x000000018855D374
		public static ulong ParseRawLittleEndian64(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855D4FC-0x000000018855D588
		private static ulong ParseRawLittleEndian64SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855D400-0x000000018855D4FC
		public static double ParseDouble(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x00000001830E8410-0x00000001830E8510
		public static float ParseFloat(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x0000000182F802D0-0x0000000182F80430
		private static float ParseFloatSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855D1BC-0x000000018855D2E0
		public static byte[] ReadRawBytes(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size) => default; // 0x00000001823BD010-0x00000001823BD690
		private static byte[] ReadRawBytesSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size) => default; // 0x000000018855D760-0x000000018855DBAC
		public static void SkipRawBytes(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size) {} // 0x000000018855DCD0-0x000000018855DD84
		public static string ReadString(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855DC9C-0x000000018855DCD0
		public static ByteString ReadBytes(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855D588-0x000000018855D5F8
		public static string ReadRawString(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int length) => default; // 0x00000001823BE5C0-0x00000001823BED10
		private static string ReadStringSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int length) => default; // 0x00000001823BD690-0x00000001823BDDA0
		private static void ValidateCurrentLimit(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size) {} // 0x0000000182FC8D50-0x0000000182FC8D70
		private static byte ReadRawByte(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x00000001823A7E20-0x00000001823A7E60
		public static uint ReadRawVarint32(Stream input) => default; // 0x000000018855DBAC-0x000000018855DC9C
		public static int DecodeZigZag32(uint n) => default; // 0x0000000183D6BBC0-0x0000000183D6BBD0
		public static long DecodeZigZag64(ulong n) => default; // 0x0000000183D6BBD0-0x0000000183D6BBE0
		public static bool IsDataAvailable(ref ParserInternalState state, int size) => default; // 0x00000001831AB850-0x00000001831AB870
		private static bool IsDataAvailableInSource(ref ParserInternalState state, int size) => default; // 0x000000018855D110-0x000000018855D1BC
		private static void ReadRawBytesIntoSpan(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int length, Span<byte> byteSpan) {} // 0x000000018855D5F8-0x000000018855D760
	}

	internal static class ParsingPrimitivesMessages // TypeDefIndex: 51984
	{
		// Fields
		private static readonly byte[] ZeroLengthMessageStreamData; // 0x00
	
		// Constructors
		static ParsingPrimitivesMessages() {} // 0x0000000183D05200-0x0000000183D05270
	
		// Methods
		public static void SkipLastField(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) {} // 0x000000018855C5C0-0x000000018855C75C
		public static void SkipGroup(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, uint startGroupTag) {} // 0x000000018855C434-0x000000018855C5C0
		public static void ReadMessage(ref ParseContext ctx, IMessage message) {} // 0x00000001823BF4C0-0x00000001823BF600
		public static KeyValuePair<TKey, TValue> ReadMapEntry<TKey, TValue>(ref ParseContext ctx, MapField<TKey, TValue> codec) => default;
		public static void ReadGroup(ref ParseContext ctx, IMessage message) {} // 0x000000018855C2D8-0x000000018855C380
		public static void ReadGroup(ref ParseContext ctx, int fieldNumber, UnknownFieldSet set) {} // 0x000000018855C380-0x000000018855C434
		public static void ReadRawMessage(ref ParseContext ctx, IMessage message) {} // 0x00000001823BF6D0-0x00000001823BFC00
		public static void CheckReadEndOfStreamTag(ref ParserInternalState state) {} // 0x00000001823BF690-0x00000001823BF6B0
		private static void CheckLastTagWas(ref ParserInternalState state, uint expectedTag) {} // 0x000000018855C29C-0x000000018855C2D8
	}

	internal static class ParsingPrimitivesWrappers // TypeDefIndex: 51985
	{
		// Methods
		internal static float? ReadFloatWrapperLittleEndian(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855CA0C-0x000000018855CAC8
		internal static float? ReadFloatWrapperSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855CAD4-0x000000018855CBB4
		internal static double? ReadDoubleWrapperLittleEndian(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855C828-0x000000018855C8F8
		internal static double? ReadDoubleWrapperSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855C924-0x000000018855CA0C
		internal static bool? ReadBoolWrapper(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855C75C-0x000000018855C7F0
		internal static uint? ReadUInt32Wrapper(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855CDF0-0x000000018855CED4
		internal static uint? ReadUInt32WrapperSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855CD18-0x000000018855CDF0
		internal static int? ReadInt32Wrapper(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855CBCC-0x000000018855CC4C
		internal static ulong? ReadUInt64Wrapper(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855CFF0-0x000000018855D0E4
		internal static ulong? ReadUInt64WrapperSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855CF0C-0x000000018855CFF0
		internal static long? ReadInt64Wrapper(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855CC78-0x000000018855CD18
		internal static float? ReadFloatWrapperLittleEndian(ref ParseContext ctx) => default; // 0x000000018855CAC8-0x000000018855CAD4
		internal static float? ReadFloatWrapperSlow(ref ParseContext ctx) => default; // 0x000000018855CBB4-0x000000018855CBC0
		internal static double? ReadDoubleWrapperLittleEndian(ref ParseContext ctx) => default; // 0x000000018855C7FC-0x000000018855C828
		internal static double? ReadDoubleWrapperSlow(ref ParseContext ctx) => default; // 0x000000018855C8F8-0x000000018855C924
		internal static bool? ReadBoolWrapper(ref ParseContext ctx) => default; // 0x000000018855C7F0-0x000000018855C7FC
		internal static uint? ReadUInt32Wrapper(ref ParseContext ctx) => default; // 0x000000018855CED4-0x000000018855CEE0
		internal static int? ReadInt32Wrapper(ref ParseContext ctx) => default; // 0x000000018855CBC0-0x000000018855CBCC
		internal static ulong? ReadUInt64Wrapper(ref ParseContext ctx) => default; // 0x000000018855D0E4-0x000000018855D110
		internal static ulong? ReadUInt64WrapperSlow(ref ParseContext ctx) => default; // 0x000000018855CEE0-0x000000018855CF0C
		internal static long? ReadInt64Wrapper(ref ParseContext ctx) => default; // 0x000000018855CC4C-0x000000018855CC78
	}

	public static class ProtoPreconditions // TypeDefIndex: 51986
	{
		// Methods
		public static T CheckNotNull<T>(T value, string name)
			where T : class => default;
		internal static T CheckNotNullUnconstrained<T>(T value, string name) => default;
	}

	internal struct SegmentedBufferHelper // TypeDefIndex: 51987
	{
		// Fields
		private int? totalLength; // 0x00
		private ReadOnlySequence<byte> readOnlySequenceEnumerator; // 0x08
		private CodedInputStream codedInputStream; // 0x40
	
		// Properties
		public int? TotalLength { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
		public CodedInputStream CodedInputStream { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
	
		// Methods
		public static void Initialize(CodedInputStream codedInputStream, out SegmentedBufferHelper instance) {
			instance = default;
		} // 0x000000018855DD84-0x000000018855DE1C
		public static void Initialize(ReadOnlySequence<byte> sequence, out SegmentedBufferHelper instance, out ReadOnlySpan<byte> firstSpan) {
			instance = default;
			firstSpan = default;
		} // 0x000000018855DE1C-0x000000018855E014
		public bool RefillBuffer(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, bool mustSucceed) => default; // 0x00000001823A9A00-0x00000001823A9A30
		public static int PushLimit(ref ParserInternalState state, int byteLimit) => default; // 0x00000001823BF600-0x00000001823BF660
		public static void PopLimit(ref ParserInternalState state, int oldLimit) {} // 0x000000018426FC34-0x000000018426FC40
		public static bool IsReachedLimit(ref ParserInternalState state) => default; // 0x00000001823BF6B0-0x00000001823BF6D0
		public static bool IsAtEnd(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018855E014-0x000000018855E048
		private bool RefillFromReadOnlySequence(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, bool mustSucceed) => default; // 0x00000001831267E0-0x00000001831268D0
		private bool RefillFromCodedInputStream(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, bool mustSucceed) => default; // 0x00000001823A9CB0-0x00000001823A9D70
		private static void RecomputeBufferSizeAfterLimit(ref ParserInternalState state) {} // 0x00000001823BF660-0x00000001823BF690
		private static void CheckCurrentBufferIsEmpty(ref ParserInternalState state) {} // 0x00000001823A9D70-0x00000001823A9D90
	}

	internal sealed class UnknownField // TypeDefIndex: 51988
	{
		// Fields
		private List<ulong> varintList; // 0x10
		private List<uint> fixed32List; // 0x18
		private List<ulong> fixed64List; // 0x20
		private List<ByteString> lengthDelimitedList; // 0x28
		private List<UnknownFieldSet> groupList; // 0x30
	
		// Constructors
		public UnknownField() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool Equals(object other) => default; // 0x00000001885638B4-0x00000001885639B8
		public override int GetHashCode() => default; // 0x00000001885639B8-0x0000000188563AA0
		internal void WriteTo(int fieldNumber, ref WriteContext output) {} // 0x00000001885640B4-0x0000000188564684
		internal int GetSerializedSize(int fieldNumber) => default; // 0x0000000188563AA0-0x0000000188563FA4
		internal UnknownField MergeFrom(UnknownField other) => default; // 0x0000000188563FA4-0x00000001885640B4
		private static List<T> AddAll<T>(List<T> current, IList<T> extras) => default;
		internal UnknownField AddVarint(ulong value) => default; // 0x0000000188563858-0x00000001885638B4
		internal UnknownField AddFixed32(uint value) => default; // 0x00000001885636EC-0x0000000188563744
		internal UnknownField AddFixed64(ulong value) => default; // 0x0000000188563744-0x00000001885637A0
		internal UnknownField AddLengthDelimited(ByteString value) => default; // 0x00000001885637FC-0x0000000188563858
		internal UnknownField AddGroup(UnknownFieldSet value) => default; // 0x00000001885637A0-0x00000001885637FC
		private static List<T> Add<T>(List<T> list, T value) => default;
	}

	public sealed class UnknownFieldSet // TypeDefIndex: 51989
	{
		// Fields
		private readonly IDictionary<int, UnknownField> fields; // 0x10
		private int lastFieldNumber; // 0x18
		private UnknownField lastField; // 0x20
	
		// Constructors
		internal UnknownFieldSet() {} // 0x0000000188563674-0x00000001885636EC
	
		// Methods
		internal bool HasField(int field) => default; // 0x0000000188562C34-0x0000000188562C8C
		public void WriteTo(CodedOutputStream output) {} // 0x00000001885633D8-0x000000018856349C
		public void WriteTo(ref WriteContext ctx) {} // 0x000000018856349C-0x0000000188563674
		public int CalculateSize() => default; // 0x00000001885625F8-0x000000018856275C
		public override bool Equals(object other) => default; // 0x000000018856275C-0x00000001885629E8
		public override int GetHashCode() => default; // 0x00000001885629E8-0x0000000188562B74
		private UnknownField GetOrAddField(int number) => default; // 0x0000000188562B74-0x0000000188562C34
		internal UnknownFieldSet AddOrReplaceField(int number, UnknownField field) => default; // 0x0000000188562530-0x00000001885625F8
		private bool MergeFieldFrom(ref ParseContext ctx) => default; // 0x0000000188562E70-0x0000000188563064
		internal void MergeGroupFrom(ref ParseContext ctx) {} // 0x000000018856338C-0x00000001885633D8
		public static UnknownFieldSet MergeFieldFrom(UnknownFieldSet unknownFields, CodedInputStream input) => default; // 0x0000000188562D84-0x0000000188562E70
		public static UnknownFieldSet MergeFieldFrom(UnknownFieldSet unknownFields, ref ParseContext ctx) => default; // 0x0000000188562C8C-0x0000000188562D84
		private UnknownFieldSet MergeFrom(UnknownFieldSet other) => default; // 0x00000001885631AC-0x000000018856338C
		public static UnknownFieldSet MergeFrom(UnknownFieldSet unknownFields, UnknownFieldSet other) => default; // 0x0000000188563134-0x00000001885631AC
		private UnknownFieldSet MergeField(int number, UnknownField field) => default; // 0x0000000188563064-0x0000000188563134
		public static UnknownFieldSet Clone(UnknownFieldSet other) => default; // 0x0000000182F0D8A0-0x0000000182F0D8E0
	}

	public static class UnsafeByteOperations // TypeDefIndex: 51990
	{
		// Methods
		public static ByteString UnsafeWrap(ReadOnlyMemory<byte> bytes) => default; // 0x0000000188564684-0x00000001885646D8
	}

	public static class WireFormat // TypeDefIndex: 51992
	{
		// Fields
		private const int TagTypeBits = 3; // Metadata: 0x01FD16D9
		private const uint TagTypeMask = 7; // Metadata: 0x01FD16DA
	
		// Nested types
		public enum WireType : uint // TypeDefIndex: 51991
		{
			Varint = 0,
			Fixed64 = 1,
			LengthDelimited = 2,
			StartGroup = 3,
			EndGroup = 4,
			Fixed32 = 5
		}
	
		// Methods
		public static WireType GetTagWireType(uint tag) => default; // 0x0000000183D6BBF0-0x0000000183D6BC00
		public static int GetTagFieldNumber(uint tag) => default; // 0x0000000183D6BBE0-0x0000000183D6BBF0
		public static uint MakeTag(int fieldNumber, WireType wireType) => default; // 0x0000000183D6BC00-0x0000000183D6BC10
	}

	internal struct WriteBufferHelper // TypeDefIndex: 51993
	{
		// Fields
		private IBufferWriter<byte> bufferWriter; // 0x00
		private CodedOutputStream codedOutputStream; // 0x08
	
		// Properties
		public CodedOutputStream CodedOutputStream { get => default; } // 0x0000000183D50DE0-0x0000000183D50DF0 
	
		// Methods
		public static void Initialize(CodedOutputStream codedOutputStream, out WriteBufferHelper instance) {
			instance = default;
		} // 0x00000001824D20C0-0x00000001824D20F0
		public static void Initialize(IBufferWriter<byte> bufferWriter, out WriteBufferHelper instance, out Span<byte> buffer) {
			instance = default;
			buffer = default;
		} // 0x000000018853DCDC-0x000000018853DD10
		public static void InitializeNonRefreshable(out WriteBufferHelper instance) {
			instance = default;
		} // 0x000000018853DCB8-0x000000018853DCDC
		public static void CheckNoSpaceLeft(ref WriterInternalState state) {} // 0x000000018853DB28-0x000000018853DC3C
		public static int GetSpaceLeft(ref WriterInternalState state) => default; // 0x000000018853DC3C-0x000000018853DCB8
		public static void RefreshBuffer(ref Span<byte> buffer, ref WriterInternalState state) {} // 0x0000000188565BF4-0x0000000188565D10
		public static void Flush(ref Span<byte> buffer, ref WriterInternalState state) {} // 0x0000000188565B4C-0x0000000188565BF4
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct WriteContext // TypeDefIndex: 51994
	{
		// Fields
		internal Span<byte> buffer; // 0x00
		internal WriterInternalState state; // 0x10
	
		// Methods
		internal static void Initialize(ref Span<byte> buffer, ref WriterInternalState state, out WriteContext ctx) {
			ctx = default;
		} // 0x0000000183D6BC10-0x0000000183D6BC30
		internal static void Initialize(CodedOutputStream output, out WriteContext ctx) {
			ctx = default;
		} // 0x0000000188565D84-0x0000000188565E00
		internal static void Initialize(IBufferWriter<byte> output, out WriteContext ctx) {
			ctx = default;
		} // 0x0000000188565E00-0x0000000188565E68
		internal static void Initialize(ref Span<byte> buffer, out WriteContext ctx) {
			ctx = default;
		} // 0x0000000188565D28-0x0000000188565D84
		public void WriteDouble(double value) {} // 0x00000001833C0400-0x00000001833C0470
		public void WriteFloat(float value) {} // 0x00000001824D4440-0x00000001824D44B0
		public void WriteUInt64(ulong value) {} // 0x00000001824D4FF0-0x00000001824D5090
		public void WriteInt64(long value) {} // 0x00000001824D5100-0x00000001824D51A0
		public void WriteInt32(int value) {} // 0x00000001824D4610-0x00000001824D4680
		public void WriteFixed64(ulong value) {} // 0x0000000188565EE4-0x0000000188565F38
		public void WriteFixed32(uint value) {} // 0x0000000188565E90-0x0000000188565EE4
		public void WriteBool(bool value) {} // 0x00000001833C0870-0x00000001833C08E0
		public void WriteString(string value) {} // 0x00000001824D52F0-0x00000001824D5360
		public void WriteMessage(IMessage value) {} // 0x0000000184270278-0x0000000184270280
		public void WriteGroup(IMessage value) {} // 0x0000000188565F38-0x0000000188565F40
		public void WriteBytes(ByteString value) {} // 0x0000000183543420-0x0000000183543490
		public void WriteUInt32(uint value) {} // 0x00000001824D4680-0x00000001824D47D0
		public void WriteEnum(int value) {} // 0x00000001824D48E0-0x00000001824D4AB0
		public void WriteSFixed32(int value) {} // 0x00000001885660CC-0x0000000188566120
		public void WriteSFixed64(long value) {} // 0x0000000188566120-0x0000000188566174
		public void WriteSInt32(int value) {} // 0x0000000188566174-0x00000001885661C8
		public void WriteSInt64(long value) {} // 0x00000001885661C8-0x000000018856621C
		public void WriteLength(int length) {} // 0x000000018397C1E0-0x000000018397C250
		public void WriteTag(int fieldNumber, WireFormat.WireType type) {} // 0x000000018856621C-0x0000000188566284
		public void WriteTag(uint tag) {} // 0x00000001824D3390-0x00000001824D3400
		public void WriteRawTag(byte b1) {} // 0x00000001824D4230-0x00000001824D4320
		public void WriteRawTag(byte b1, byte b2) {} // 0x00000001824D4E60-0x00000001824D4F40
		public void WriteRawTag(byte b1, byte b2, byte b3) {} // 0x0000000188565FC4-0x0000000188566040
		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4) {} // 0x0000000188565F40-0x0000000188565FC4
		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5) {} // 0x0000000188566040-0x00000001885660CC
		internal void Flush() {} // 0x0000000188565D1C-0x0000000188565D28
		internal void CheckNoSpaceLeft() {} // 0x0000000188565D10-0x0000000188565D1C
		internal void CopyStateTo(CodedOutputStream output) {} // 0x00000001831C0BC0-0x00000001831C0BF0
		internal void LoadStateFrom(CodedOutputStream output) {} // 0x0000000188565E68-0x0000000188565E90
	}

	internal struct WriterInternalState // TypeDefIndex: 51995
	{
		// Fields
		internal int limit; // 0x00
		internal int position; // 0x04
		internal WriteBufferHelper writeBufferHelper; // 0x08
	
		// Properties
		internal CodedOutputStream CodedOutputStream { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	}

	internal static class WritingPrimitives // TypeDefIndex: 51996
	{
		// Fields
		internal static readonly Encoding Utf8Encoding; // 0x00
	
		// Constructors
		static WritingPrimitives() {} // 0x0000000183D26FB0-0x0000000183D27000
	
		// Methods
		public static void WriteDouble(ref Span<byte> buffer, ref WriterInternalState state, double value) {} // 0x00000001833C0470-0x00000001833C0510
		public static void WriteFloat(ref Span<byte> buffer, ref WriterInternalState state, float value) {} // 0x00000001824D44B0-0x00000001824D4610
		private static void WriteFloatSlowPath(ref Span<byte> buffer, ref WriterInternalState state, float value) {} // 0x0000000188566628-0x00000001885667BC
		public static void WriteUInt64(ref Span<byte> buffer, ref WriterInternalState state, ulong value) {} // 0x00000001824D5090-0x00000001824D5100
		public static void WriteInt64(ref Span<byte> buffer, ref WriterInternalState state, long value) {} // 0x00000001824D51A0-0x00000001824D5210
		public static void WriteInt32(ref Span<byte> buffer, ref WriterInternalState state, int value) {} // 0x00000001824D4C40-0x00000001824D4D90
		public static void WriteFixed64(ref Span<byte> buffer, ref WriterInternalState state, ulong value) {} // 0x00000001885665C8-0x0000000188566628
		public static void WriteFixed32(ref Span<byte> buffer, ref WriterInternalState state, uint value) {} // 0x0000000188566568-0x00000001885665C8
		public static void WriteBool(ref Span<byte> buffer, ref WriterInternalState state, bool value) {} // 0x00000001833C08E0-0x00000001833C0960
		public static void WriteString(ref Span<byte> buffer, ref WriterInternalState state, string value) {} // 0x00000001824D5360-0x00000001824D55A0
		private static void WriteAsciiStringToBuffer(Span<byte> buffer, ref WriterInternalState state, string value, int length) {} // 0x0000000182D4A540-0x0000000182D4A740
		private static void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(ref byte outputBuffer, ulong value) {} // 0x00000001885664E0-0x0000000188566568
		private static int WriteStringToBuffer(Span<byte> buffer, ref WriterInternalState state, string value) => default; // 0x00000001824D55A0-0x00000001824D5730
		public static void WriteBytes(ref Span<byte> buffer, ref WriterInternalState state, ByteString value) {} // 0x0000000183543490-0x0000000183543560
		public static void WriteUInt32(ref Span<byte> buffer, ref WriterInternalState state, uint value) {} // 0x00000001824D47D0-0x00000001824D48E0
		public static void WriteEnum(ref Span<byte> buffer, ref WriterInternalState state, int value) {} // 0x00000001824D4AB0-0x00000001824D4C40
		public static void WriteSFixed32(ref Span<byte> buffer, ref WriterInternalState state, int value) {} // 0x00000001885670D4-0x0000000188567134
		public static void WriteSFixed64(ref Span<byte> buffer, ref WriterInternalState state, long value) {} // 0x0000000188567134-0x0000000188567194
		public static void WriteSInt32(ref Span<byte> buffer, ref WriterInternalState state, int value) {} // 0x0000000188567194-0x0000000188567200
		public static void WriteSInt64(ref Span<byte> buffer, ref WriterInternalState state, long value) {} // 0x0000000188567200-0x000000018856726C
		public static void WriteLength(ref Span<byte> buffer, ref WriterInternalState state, int length) {} // 0x00000001824D3DD0-0x00000001824D3E40
		public static void WriteRawVarint32(ref Span<byte> buffer, ref WriterInternalState state, uint value) {} // 0x00000001824D4D90-0x00000001824D4E60
		public static void WriteRawVarint64(ref Span<byte> buffer, ref WriterInternalState state, ulong value) {} // 0x00000001824D5210-0x00000001824D52F0
		public static void WriteRawLittleEndian32(ref Span<byte> buffer, ref WriterInternalState state, uint value) {} // 0x00000001885669A4-0x0000000188566A60
		private static void WriteRawLittleEndian32SlowPath(ref Span<byte> buffer, ref WriterInternalState state, uint value) {} // 0x0000000188566904-0x00000001885669A4
		public static void WriteRawLittleEndian64(ref Span<byte> buffer, ref WriterInternalState state, ulong value) {} // 0x00000001833C0510-0x00000001833C0660
		public static void WriteRawLittleEndian64SlowPath(ref Span<byte> buffer, ref WriterInternalState state, ulong value) {} // 0x0000000188566A60-0x0000000188566B54
		private static void WriteRawByte(ref Span<byte> buffer, ref WriterInternalState state, byte value) {} // 0x00000001824D43D0-0x00000001824D4440
		public static void WriteRawBytes(ref Span<byte> buffer, ref WriterInternalState state, byte[] value) {} // 0x00000001885667BC-0x0000000188566860
		public static void WriteRawBytes(ref Span<byte> buffer, ref WriterInternalState state, byte[] value, int offset, int length) {} // 0x0000000188566860-0x0000000188566904
		public static void WriteRawBytes(ref Span<byte> buffer, ref WriterInternalState state, ReadOnlySpan<byte> value) {} // 0x0000000183543680-0x0000000183543750
		public static void WriteTag(ref Span<byte> buffer, ref WriterInternalState state, int fieldNumber, WireFormat.WireType type) {} // 0x000000018856726C-0x0000000188567834
		public static void WriteTag(ref Span<byte> buffer, ref WriterInternalState state, uint tag) {} // 0x00000001824D3400-0x00000001824D3470
		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1) {} // 0x00000001824D4320-0x00000001824D43D0
		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2) {} // 0x00000001824D4F40-0x00000001824D4FF0
		private static void WriteRawTagSlowPath(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2) {} // 0x0000000188566D44-0x0000000188566DC4
		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3) {} // 0x0000000188566FF4-0x00000001885670D4
		private static void WriteRawTagSlowPath(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3) {} // 0x0000000188566C0C-0x0000000188566CA0
		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3, byte b4) {} // 0x0000000188566DC4-0x0000000188566EC8
		private static void WriteRawTagSlowPath(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3, byte b4) {} // 0x0000000188566CA0-0x0000000188566D44
		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3, byte b4, byte b5) {} // 0x0000000188566EC8-0x0000000188566FF4
		private static void WriteRawTagSlowPath(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3, byte b4, byte b5) {} // 0x0000000188566B54-0x0000000188566C0C
		public static uint EncodeZigZag32(int n) => default; // 0x0000000183D6BC30-0x0000000183D6BC40
		public static ulong EncodeZigZag64(long n) => default; // 0x0000000183D6BC40-0x0000000183D6BC50
	}

	internal static class WritingPrimitivesMessages // TypeDefIndex: 51997
	{
		// Methods
		public static void WriteMessage(ref WriteContext ctx, IMessage value) {} // 0x0000000188566284-0x000000018856631C
		public static void WriteGroup(ref WriteContext ctx, IMessage value) {} // 0x0000000188565F38-0x0000000188565F40
		public static void WriteRawMessage(ref WriteContext ctx, IMessage message) {} // 0x000000018856631C-0x00000001885664E0
	}
}

namespace Google.Protobuf.Collections
{
	public static class Lists // TypeDefIndex: 52204
	{
		// Methods
		public static bool Equals<T>(List<T> left, List<T> right) => default;
		public static int GetHashCode<T>(List<T> list) => default;
	}

	public sealed class MapField<TKey, TValue> : IDeepCloneable<MapField<TKey, TValue>>, IDictionary<TKey, TValue>, IEquatable<MapField<TKey, TValue>>, IDictionary, IReadOnlyDictionary<TKey, TValue> // TypeDefIndex: 52210
	{
		// Fields
		private static readonly EqualityComparer<TValue> ValueEqualityComparer;
		private static readonly EqualityComparer<TKey> KeyEqualityComparer;
		private readonly Dictionary<TKey, LinkedListNode<KeyValuePair<TKey, TValue>>> map;
		private readonly LinkedList<KeyValuePair<TKey, TValue>> list;
	
		// Properties
		public TValue this[TKey key] { get => default; set {} }
		public ICollection<TKey> Keys { get => default; }
		public ICollection<TValue> Values { get => default; }
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
		bool IDictionary.IsFixedSize { get => default; }
		ICollection IDictionary.Keys { get => default; }
		ICollection IDictionary.Values { get => default; }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
		object IDictionary.this[object key] { get => default; set {} }
		IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get => default; }
		IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get => default; }
	
		// Nested types
		private class DictionaryEnumerator : IDictionaryEnumerator // TypeDefIndex: 52205
		{
			// Fields
			private readonly IEnumerator<KeyValuePair<TKey, TValue>> enumerator;
	
			// Properties
			public object Current { get => default; }
			public DictionaryEntry Entry { get => default; }
			public object Key { get => default; }
			public object Value { get => default; }
	
			// Constructors
			public DictionaryEnumerator() {} // Dummy constructor
			internal DictionaryEnumerator(IEnumerator<KeyValuePair<TKey, TValue>> enumerator) {}
	
			// Methods
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public sealed class Codec // TypeDefIndex: 52206
		{
			// Fields
			private readonly FieldCodec<TKey> keyCodec;
			private readonly FieldCodec<TValue> valueCodec;
			private readonly uint mapTag;
	
			// Properties
			internal FieldCodec<TKey> KeyCodec { get => default; }
			internal FieldCodec<TValue> ValueCodec { get => default; }
			internal uint MapTag { get => default; }
	
			// Constructors
			public Codec() {} // Dummy constructor
			public Codec(FieldCodec<TKey> keyCodec, FieldCodec<TValue> valueCodec, uint mapTag) {}
		}
	
		private class MapView<T> : ICollection<T>, ICollection // TypeDefIndex: 52207
		{
			// Fields
			private readonly MapField<TKey, TValue> parent;
			private readonly Func<KeyValuePair<TKey, TValue>, T> projection;
			private readonly Func<T, bool> containsCheck;
	
			// Properties
			public int Count { get => default; }
			public bool IsReadOnly { get => default; }
			public bool IsSynchronized { get => default; }
			public object SyncRoot { get => default; }
	
			// Constructors
			public MapView() {} // Dummy constructor
			internal MapView(MapField<TKey, TValue> parent, Func<KeyValuePair<TKey, TValue>, T> projection, Func<T, bool> containsCheck) {}
	
			// Methods
			public void Add(T item) {}
			public void Clear() {}
			public bool Contains(T item) => default;
			public void CopyTo(T[] array, int arrayIndex) {}
			public IEnumerator<T> GetEnumerator() => default;
			public bool Remove(T item) => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
			public void CopyTo(Array array, int index) {}
		}
	
		// Constructors
		public MapField() {}
		static MapField() {}
	
		// Methods
		public MapField<TKey, TValue> Clone() => default;
		public void Add(TKey key, TValue value) {}
		public bool ContainsKey(TKey key) => default;
		private bool ContainsValue(TValue value) => default;
		public bool Remove(TKey key) => default;
		public bool TryGetValue(TKey key, out ref TValue value) {
			value = default;
			return default;
		}
		public void Add(IDictionary<TKey, TValue> entries) {}
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item) {}
		public void Clear() {}
		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item) => default;
		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) {}
		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item) => default;
		public override bool Equals(object other) => default;
		public override int GetHashCode() => default;
		public bool Equals(MapField<TKey, TValue> other) => default;
		public void AddEntriesFrom(CodedInputStream input, Codec codec) {}
		public void AddEntriesFrom(ref ParseContext ctx, Codec codec) {}
		public void WriteTo(CodedOutputStream output, Codec codec) {}
		public void WriteTo(ref WriteContext ctx, Codec codec) {}
		public int CalculateSize(Codec codec) => default;
		private static int CalculateEntrySize(Codec codec, KeyValuePair<TKey, TValue> entry) => default;
		public override string ToString() => default;
		void IDictionary.Add(object key, object value) {}
		bool IDictionary.Contains(object key) => default;
		IDictionaryEnumerator IDictionary.GetEnumerator() => default;
		void IDictionary.Remove(object key) {}
		void ICollection.CopyTo(Array array, int index) {}
	}

	public static class ProtobufEqualityComparers // TypeDefIndex: 52215
	{
		// Properties
		public static EqualityComparer<double> BitwiseDoubleEqualityComparer { get; } // 0x0000000188594BD0-0x0000000188594C20 
		public static EqualityComparer<float> BitwiseSingleEqualityComparer { get; } // 0x0000000188594CC0-0x0000000188594D10 
		public static EqualityComparer<double?> BitwiseNullableDoubleEqualityComparer { get; } // 0x0000000188594C20-0x0000000188594C70 
		public static EqualityComparer<float?> BitwiseNullableSingleEqualityComparer { get; } // 0x0000000188594C70-0x0000000188594CC0 
	
		// Nested types
		private class BitwiseDoubleEqualityComparerImpl : EqualityComparer<double> // TypeDefIndex: 52211
		{
			// Constructors
			public BitwiseDoubleEqualityComparerImpl() {} // 0x00000001839D7A80-0x00000001839D7AB0
	
			// Methods
			public override bool Equals(double x, double y) => default; // 0x000000018858D734-0x000000018858D790
			public override int GetHashCode(double obj) => default; // 0x000000018858D790-0x000000018858D7E8
		}
	
		private class BitwiseSingleEqualityComparerImpl : EqualityComparer<float> // TypeDefIndex: 52212
		{
			// Constructors
			public BitwiseSingleEqualityComparerImpl() {} // 0x00000001839D7A50-0x00000001839D7A80
	
			// Methods
			public override bool Equals(float x, float y) => default; // 0x000000018858DAB0-0x000000018858DB1C
			public override int GetHashCode(float obj) => default; // 0x000000018858DB1C-0x000000018858DB70
		}
	
		private class BitwiseNullableDoubleEqualityComparerImpl : EqualityComparer<double?> // TypeDefIndex: 52213
		{
			// Constructors
			public BitwiseNullableDoubleEqualityComparerImpl() {} // 0x00000001839D7A20-0x00000001839D7A50
	
			// Methods
			public override bool Equals(double? x, double? y) => default; // 0x000000018858D7E8-0x000000018858D8B0
			public override int GetHashCode(double? obj) => default; // 0x000000018858D8B0-0x000000018858D948
		}
	
		private class BitwiseNullableSingleEqualityComparerImpl : EqualityComparer<float?> // TypeDefIndex: 52214
		{
			// Constructors
			public BitwiseNullableSingleEqualityComparerImpl() {} // 0x00000001839D79F0-0x00000001839D7A20
	
			// Methods
			public override bool Equals(float? x, float? y) => default; // 0x000000018858D948-0x000000018858DA18
			public override int GetHashCode(float? obj) => default; // 0x000000018858DA18-0x000000018858DAB0
		}
	
		// Constructors
		static ProtobufEqualityComparers() {} // 0x00000001839D7870-0x00000001839D79F0
	
		// Methods
		public static EqualityComparer<T> GetEqualityComparer<T>() => default;
	}

	internal sealed class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue> // TypeDefIndex: 52216
	{
		// Fields
		private readonly IDictionary<TKey, TValue> wrapped;
	
		// Properties
		public ICollection<TKey> Keys { get => default; }
		public ICollection<TValue> Values { get => default; }
		public TValue this[TKey key] { get => default; set {} }
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
	
		// Constructors
		public ReadOnlyDictionary() {} // Dummy constructor
		public ReadOnlyDictionary(IDictionary<TKey, TValue> wrapped) {}
	
		// Methods
		public void Add(TKey key, TValue value) {}
		public bool ContainsKey(TKey key) => default;
		public bool Remove(TKey key) => default;
		public bool TryGetValue(TKey key, out ref TValue value) {
			value = default;
			return default;
		}
		public void Add(KeyValuePair<TKey, TValue> item) {}
		public void Clear() {}
		public bool Contains(KeyValuePair<TKey, TValue> item) => default;
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) {}
		public bool Remove(KeyValuePair<TKey, TValue> item) => default;
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
		public override string ToString() => default;
	}

	public sealed class RepeatedField<T> : IList<T>, IList, IDeepCloneable<RepeatedField<T>>, IEquatable<RepeatedField<T>>, IReadOnlyList<T> // TypeDefIndex: 52218
	{
		// Fields
		private static readonly EqualityComparer<T> EqualityComparer;
		private static readonly T[] EmptyArray;
		private const int MinArraySize = 8; // Metadata: 0x01FD1889
		private T[] array;
		private int count;
	
		// Properties
		public int Capacity { get => default; set {} }
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
		public T this[int index] { get => default; set {} }
		bool IList.IsFixedSize { get => default; }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
		object IList.this[int index] { get => default; set {} }
	
		// Constructors
		public RepeatedField() {}
		static RepeatedField() {}
	
		// Methods
		public RepeatedField<T> Clone() => default;
		public void AddEntriesFrom(CodedInputStream input, FieldCodec<T> codec) {}
		public void AddEntriesFrom(ref ParseContext ctx, FieldCodec<T> codec) {}
		public int CalculateSize(FieldCodec<T> codec) => default;
		private int CalculatePackedDataSize(FieldCodec<T> codec) => default;
		public void WriteTo(CodedOutputStream output, FieldCodec<T> codec) {}
		public void WriteTo(ref WriteContext ctx, FieldCodec<T> codec) {}
		private void EnsureSize(int size) {}
		private void SetSize(int size) {}
		public void SetCount(int newCount) {}
		public void Add(T item) {}
		public void Clear() {}
		public bool Contains(T item) => default;
		public void CopyTo(T[] array, int arrayIndex) {}
		public bool Remove(T item) => default;
		public void AddRange(IEnumerable<T> values) {}
		public void Add(IEnumerable<T> values) {}
		[IteratorStateMachine(typeof(_GetEnumerator_d__29))]
		public IEnumerator<T> GetEnumerator() => default;
		public override bool Equals(object obj) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public override int GetHashCode() => default;
		public bool Equals(RepeatedField<T> other) => default;
		public int IndexOf(T item) => default;
		public void Insert(int index, T item) {}
		public void RemoveAt(int index) {}
		public override string ToString() => default;
		void ICollection.CopyTo(Array array, int index) {}
		int IList.Add(object value) => default;
		bool IList.Contains(object value) => default;
		int IList.IndexOf(object value) => default;
		void IList.Insert(int index, object value) {}
		void IList.Remove(object value) {}
	}
}

namespace Google.Protobuf.Compatibility
{
	internal static class PropertyInfoExtensions // TypeDefIndex: 52202
	{
		// Extension methods
		internal static MethodInfo GetGetMethod(this PropertyInfo target) => default; // 0x0000000188594B30-0x0000000188594B80
		internal static MethodInfo GetSetMethod(this PropertyInfo target) => default; // 0x0000000188594B80-0x0000000188594BD0
	}

	internal static class TypeExtensions // TypeDefIndex: 52203
	{
		// Extension methods
		internal static bool IsAssignableFrom(this System.Type target, System.Type c) => default; // 0x0000000188596940-0x000000018859699C
		[UnconditionalSuppressMessage("Trimming", "IL2072", Justification = "The BaseType of the target will have all properties because of the annotation.")]
		internal static PropertyInfo GetProperty([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] this System.Type target, string name) => default; // 0x000000018859682C-0x0000000188596940
		[UnconditionalSuppressMessage("Trimming", "IL2072", Justification = "The BaseType of the target will have all properties because of the annotation.")]
		internal static MethodInfo GetMethod([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] this System.Type target, string name) => default; // 0x0000000188596774-0x000000018859682C
	}
}

namespace Google.Protobuf.Reflection
{
	public sealed class CustomOptions // TypeDefIndex: 52069
	{
		// Fields
		private const string UnreferencedCodeMessage = "CustomOptions is incompatible with trimming."; // Metadata: 0x01FD179C
		private static readonly object[] EmptyParameters; // 0x00
		private readonly IDictionary<int, IExtensionValue> values; // 0x10
	
		// Constructors
		public CustomOptions() {} // Dummy constructor
		internal CustomOptions(IDictionary<int, IExtensionValue> values) {} // 0x000000018426FEE0-0x000000018426FEF0
		static CustomOptions() {} // 0x000000018856859C-0x0000000188568600
	
		// Methods
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetBool(int field, out bool value) {
			value = default;
			return default;
		} // 0x00000001885681B4-0x000000018856820C
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetInt32(int field, out int value) {
			value = default;
			return default;
		} // 0x0000000188568324-0x000000018856837C
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetInt64(int field, out long value) {
			value = default;
			return default;
		} // 0x000000018856837C-0x00000001885683D4
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetFixed32(int field, out uint value) {
			value = default;
			return default;
		} // 0x00000001885682BC-0x00000001885682C4
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetFixed64(int field, out ulong value) {
			value = default;
			return default;
		} // 0x00000001885682C4-0x00000001885682CC
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetSFixed32(int field, out int value) {
			value = default;
			return default;
		} // 0x00000001885683D4-0x00000001885683DC
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetSFixed64(int field, out long value) {
			value = default;
			return default;
		} // 0x00000001885683DC-0x00000001885683E4
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetSInt32(int field, out int value) {
			value = default;
			return default;
		} // 0x00000001885683E4-0x000000018856843C
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetSInt64(int field, out long value) {
			value = default;
			return default;
		} // 0x000000018856843C-0x0000000188568494
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetUInt32(int field, out uint value) {
			value = default;
			return default;
		} // 0x00000001885684EC-0x0000000188568544
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetUInt64(int field, out ulong value) {
			value = default;
			return default;
		} // 0x0000000188568544-0x000000018856859C
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetFloat(int field, out float value) {
			value = default;
			return default;
		} // 0x00000001885682CC-0x0000000188568324
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetDouble(int field, out double value) {
			value = default;
			return default;
		} // 0x0000000188568264-0x00000001885682BC
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetString(int field, out string value) {
			value = default;
			return default;
		} // 0x0000000188568494-0x00000001885684EC
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetBytes(int field, out ByteString value) {
			value = default;
			return default;
		} // 0x000000018856820C-0x0000000188568264
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetMessage<T>(int field, out ref T value)
			where T : class, IMessage, new() {
			value = default;
			return default;
		}
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		private bool TryGetPrimitiveValue<T>(int field, out ref T value) {
			value = default;
			return default;
		}
	}

	public static class DescriptorReflection // TypeDefIndex: 52070
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018856D514-0x000000018856D564 
	
		// Constructors
		static DescriptorReflection() {} // 0x0000000188569F38-0x000000018856D514
	}

	public sealed class FileDescriptorSet : IMessage<FileDescriptorSet>, IBufferMessage // TypeDefIndex: 52072
	{
		// Fields
		private static readonly MessageParser<FileDescriptorSet> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int FileFieldNumber = 1; // Metadata: 0x01FD17C9
		private static readonly FieldCodec<FileDescriptorProto> _repeated_file_codec; // 0x08
		private readonly RepeatedField<FileDescriptorProto> file_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FileDescriptorSet> Parser { get => default; } // 0x0000000188575A54-0x0000000188575AA4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001885759F4-0x0000000188575A54 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188575C18-0x0000000188575C58 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FileDescriptorProto> File { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileDescriptorSet() {} // 0x000000018857597C-0x00000001885759F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileDescriptorSet(FileDescriptorSet other) {} // 0x00000001885758F4-0x000000018857597C
		static FileDescriptorSet() {} // 0x0000000188575784-0x00000001885758F4
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileDescriptorSet Clone() => default; // 0x0000000188575580-0x00000001885755E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x00000001885755E0-0x0000000188575644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FileDescriptorSet other) => default; // 0x0000000188575644-0x00000001885756C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018517BB20-0x000000018517BB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188575738-0x0000000188575784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188575B74-0x0000000188575C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x00000001885754EC-0x0000000188575580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FileDescriptorSet other) {} // 0x00000001885756C0-0x0000000188575738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188575AA4-0x0000000188575B74
	}

	public sealed class FileDescriptorProto : IMessage<FileDescriptorProto>, IBufferMessage // TypeDefIndex: 52074
	{
		// Fields
		private static readonly MessageParser<FileDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x01FD17CA
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x18
		public const int PackageFieldNumber = 2; // Metadata: 0x01FD17CB
		private static readonly string PackageDefaultValue; // 0x10
		private string package_; // 0x20
		public const int DependencyFieldNumber = 3; // Metadata: 0x01FD17CC
		private static readonly FieldCodec<string> _repeated_dependency_codec; // 0x18
		private readonly RepeatedField<string> dependency_; // 0x28
		public const int PublicDependencyFieldNumber = 10; // Metadata: 0x01FD17CD
		private static readonly FieldCodec<int> _repeated_publicDependency_codec; // 0x20
		private readonly RepeatedField<int> publicDependency_; // 0x30
		public const int WeakDependencyFieldNumber = 11; // Metadata: 0x01FD17CE
		private static readonly FieldCodec<int> _repeated_weakDependency_codec; // 0x28
		private readonly RepeatedField<int> weakDependency_; // 0x38
		public const int MessageTypeFieldNumber = 4; // Metadata: 0x01FD17CF
		private static readonly FieldCodec<DescriptorProto> _repeated_messageType_codec; // 0x30
		private readonly RepeatedField<DescriptorProto> messageType_; // 0x40
		public const int EnumTypeFieldNumber = 5; // Metadata: 0x01FD17D0
		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; // 0x38
		private readonly RepeatedField<EnumDescriptorProto> enumType_; // 0x48
		public const int ServiceFieldNumber = 6; // Metadata: 0x01FD17D1
		private static readonly FieldCodec<ServiceDescriptorProto> _repeated_service_codec; // 0x40
		private readonly RepeatedField<ServiceDescriptorProto> service_; // 0x50
		public const int ExtensionFieldNumber = 7; // Metadata: 0x01FD17D2
		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec; // 0x48
		private readonly RepeatedField<FieldDescriptorProto> extension_; // 0x58
		public const int OptionsFieldNumber = 8; // Metadata: 0x01FD17D3
		private Google.Protobuf.Reflection.FileOptions options_; // 0x60
		public const int SourceCodeInfoFieldNumber = 9; // Metadata: 0x01FD17D4
		private SourceCodeInfo sourceCodeInfo_; // 0x68
		public const int SyntaxFieldNumber = 12; // Metadata: 0x01FD17D5
		private static readonly string SyntaxDefaultValue; // 0x50
		private string syntax_; // 0x70
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FileDescriptorProto> Parser { get => default; } // 0x0000000188574C24-0x0000000188574C74 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188574B10-0x0000000188574B70 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188575374-0x00000001885753B4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x0000000188574B7C-0x0000000188574BD0 0x00000001885753B4-0x000000018857541C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get => default; } // 0x0000000182702DB0-0x0000000182702DC0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Package { get => default; set {} } // 0x0000000188574BD0-0x0000000188574C24 0x000000018857541C-0x0000000188575484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPackage { get => default; } // 0x0000000188571E40-0x0000000188571E4C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Dependency { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PublicDependency { get => default; } // 0x0000000181003830-0x0000000181003840 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WeakDependency { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DescriptorProto> MessageType { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnumDescriptorProto> EnumType { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ServiceDescriptorProto> Service { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FieldDescriptorProto> Extension { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Google.Protobuf.Reflection.FileOptions Options { get => default; set {} } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceCodeInfo SourceCodeInfo { get => default; set {} } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Syntax { get => default; set {} } // 0x0000000188574C74-0x0000000188574CC8 0x0000000188575484-0x00000001885754EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSyntax { get => default; } // 0x0000000188574B70-0x0000000188574B7C 
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileDescriptorProto() {} // 0x00000001885748E8-0x0000000188574B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileDescriptorProto(FileDescriptorProto other) {} // 0x00000001885746B8-0x00000001885748E8
		static FileDescriptorProto() {} // 0x00000001885742D4-0x00000001885746B8
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileDescriptorProto Clone() => default; // 0x0000000188573B3C-0x0000000188573B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName() {} // 0x000000018364B0F0-0x000000018364B110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPackage() {} // 0x0000000188571380-0x0000000188571394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSyntax() {} // 0x0000000188573B28-0x0000000188573B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188573B9C-0x0000000188573C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FileDescriptorProto other) => default; // 0x0000000188573C00-0x0000000188573E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000188573E54-0x0000000188573FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188574288-0x00000001885742D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001885750AC-0x0000000188575374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188573848-0x0000000188573B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FileDescriptorProto other) {} // 0x0000000188573FF8-0x0000000188574288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188574CC8-0x00000001885750AC
	}

	public sealed class DescriptorProto : IMessage<DescriptorProto>, IBufferMessage // TypeDefIndex: 52081
	{
		// Fields
		private static readonly MessageParser<DescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x01FD17D6
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x18
		public const int FieldFieldNumber = 2; // Metadata: 0x01FD17D7
		private static readonly FieldCodec<FieldDescriptorProto> _repeated_field_codec; // 0x10
		private readonly RepeatedField<FieldDescriptorProto> field_; // 0x20
		public const int ExtensionFieldNumber = 6; // Metadata: 0x01FD17D8
		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec; // 0x18
		private readonly RepeatedField<FieldDescriptorProto> extension_; // 0x28
		public const int NestedTypeFieldNumber = 3; // Metadata: 0x01FD17D9
		private static readonly FieldCodec<DescriptorProto> _repeated_nestedType_codec; // 0x20
		private readonly RepeatedField<DescriptorProto> nestedType_; // 0x30
		public const int EnumTypeFieldNumber = 4; // Metadata: 0x01FD17DA
		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; // 0x28
		private readonly RepeatedField<EnumDescriptorProto> enumType_; // 0x38
		public const int ExtensionRangeFieldNumber = 5; // Metadata: 0x01FD17DB
		private static readonly FieldCodec<Types.ExtensionRange> _repeated_extensionRange_codec; // 0x30
		private readonly RepeatedField<Types.ExtensionRange> extensionRange_; // 0x40
		public const int OneofDeclFieldNumber = 8; // Metadata: 0x01FD17DC
		private static readonly FieldCodec<OneofDescriptorProto> _repeated_oneofDecl_codec; // 0x38
		private readonly RepeatedField<OneofDescriptorProto> oneofDecl_; // 0x48
		public const int OptionsFieldNumber = 7; // Metadata: 0x01FD17DD
		private MessageOptions options_; // 0x50
		public const int ReservedRangeFieldNumber = 9; // Metadata: 0x01FD17DE
		private static readonly FieldCodec<Types.ReservedRange> _repeated_reservedRange_codec; // 0x40
		private readonly RepeatedField<Types.ReservedRange> reservedRange_; // 0x58
		public const int ReservedNameFieldNumber = 10; // Metadata: 0x01FD17DF
		private static readonly FieldCodec<string> _repeated_reservedName_codec; // 0x48
		private readonly RepeatedField<string> reservedName_; // 0x60
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DescriptorProto> Parser { get => default; } // 0x000000018856985C-0x00000001885698AC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001885697A8-0x0000000188569808 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188569E90-0x0000000188569ED0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x0000000188569808-0x000000018856985C 0x0000000188569ED0-0x0000000188569F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get => default; } // 0x0000000182702DB0-0x0000000182702DC0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FieldDescriptorProto> Field { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FieldDescriptorProto> Extension { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DescriptorProto> NestedType { get => default; } // 0x0000000181003830-0x0000000181003840 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnumDescriptorProto> EnumType { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Types.ExtensionRange> ExtensionRange { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneofDescriptorProto> OneofDecl { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageOptions Options { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Types.ReservedRange> ReservedRange { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ReservedName { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 52079
		{
			// Nested types
			public sealed class ExtensionRange : IMessage<ExtensionRange>, IBufferMessage // TypeDefIndex: 52076
			{
				// Fields
				private static readonly MessageParser<ExtensionRange> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				private int _hasBits0; // 0x18
				public const int StartFieldNumber = 1; // Metadata: 0x01FD17E0
				private static readonly int StartDefaultValue; // 0x08
				private int start_; // 0x1C
				public const int EndFieldNumber = 2; // Metadata: 0x01FD17E1
				private static readonly int EndDefaultValue; // 0x0C
				private int end_; // 0x20
				public const int OptionsFieldNumber = 3; // Metadata: 0x01FD17E2
				private ExtensionRangeOptions options_; // 0x28
	
				// Properties
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ExtensionRange> Parser { get => default; } // 0x0000000188570E98-0x0000000188570EE8 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor Descriptor { get => default; } // 0x0000000188570DDC-0x0000000188570E3C 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188571100-0x0000000188571140 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Start { get => default; set {} } // 0x0000000188570EE8-0x0000000188570F3C 0x0000000183D6BC70-0x0000000183D6BC80
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasStart { get => default; } // 0x0000000182461A70-0x0000000182461A80 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int End { get => default; set {} } // 0x0000000188570E3C-0x0000000188570E90 0x0000000183D6BC60-0x0000000183D6BC70
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasEnd { get => default; } // 0x0000000188570E90-0x0000000188570E98 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ExtensionRangeOptions Options { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
	
				// Constructors
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ExtensionRange() {} // 0x000000018350B670-0x000000018350B680
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ExtensionRange(ExtensionRange other) {} // 0x0000000188570D68-0x0000000188570DDC
				static ExtensionRange() {} // 0x0000000188570C3C-0x0000000188570D68
	
				// Methods
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ExtensionRange Clone() => default; // 0x0000000188570944-0x00000001885709A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearStart() {} // 0x0000000183D4F650-0x0000000183D4F660
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearEnd() {} // 0x0000000183D6BC50-0x0000000183D6BC60
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other) => default; // 0x0000000188570A30-0x0000000188570A94
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(ExtensionRange other) => default; // 0x00000001885709A4-0x0000000188570A30
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode() => default; // 0x0000000188570A94-0x0000000188570B04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString() => default; // 0x0000000188570BF0-0x0000000188570C3C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188571058-0x0000000188571100
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize() => default; // 0x0000000188570874-0x0000000188570944
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(ExtensionRange other) {} // 0x0000000188570B04-0x0000000188570BF0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188570F3C-0x0000000188571058
			}
	
			public sealed class ReservedRange : IMessage<ReservedRange>, IBufferMessage // TypeDefIndex: 52078
			{
				// Fields
				private static readonly MessageParser<ReservedRange> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				private int _hasBits0; // 0x18
				public const int StartFieldNumber = 1; // Metadata: 0x01FD17E3
				private static readonly int StartDefaultValue; // 0x08
				private int start_; // 0x1C
				public const int EndFieldNumber = 2; // Metadata: 0x01FD17E4
				private static readonly int EndDefaultValue; // 0x0C
				private int end_; // 0x20
	
				// Properties
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ReservedRange> Parser { get => default; } // 0x0000000188577B48-0x0000000188577B98 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor Descriptor { get => default; } // 0x0000000188577A90-0x0000000188577AF4 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188577D10-0x0000000188577D50 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Start { get => default; set {} } // 0x0000000188577B98-0x0000000188577BEC 0x0000000183D6BC70-0x0000000183D6BC80
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasStart { get => default; } // 0x0000000182461A70-0x0000000182461A80 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int End { get => default; set {} } // 0x0000000188577AF4-0x0000000188577B48 0x0000000183D6BC60-0x0000000183D6BC70
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasEnd { get => default; } // 0x0000000188570E90-0x0000000188570E98 
	
				// Constructors
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ReservedRange() {} // 0x000000018350B670-0x000000018350B680
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ReservedRange(ReservedRange other) {} // 0x00000001851669EC-0x0000000185166A34
				static ReservedRange() {} // 0x0000000188577964-0x0000000188577A90
	
				// Methods
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ReservedRange Clone() => default; // 0x0000000188577718-0x0000000188577778
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearStart() {} // 0x0000000183D4F650-0x0000000183D4F660
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearEnd() {} // 0x0000000183D6BC50-0x0000000183D6BC60
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other) => default; // 0x0000000188577778-0x00000001885777DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(ReservedRange other) => default; // 0x00000001885777DC-0x0000000188577854
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode() => default; // 0x0000000188577854-0x00000001885778AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString() => default; // 0x0000000188577918-0x0000000188577964
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188577C88-0x0000000188577D10
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize() => default; // 0x000000018857766C-0x0000000188577718
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(ReservedRange other) {} // 0x00000001885778AC-0x0000000188577918
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188577BEC-0x0000000188577C88
			}
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DescriptorProto() {} // 0x0000000188569534-0x00000001885697A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DescriptorProto(DescriptorProto other) {} // 0x0000000188569328-0x0000000188569534
		static DescriptorProto() {} // 0x0000000188568F1C-0x0000000188569328
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DescriptorProto Clone() => default; // 0x00000001885688A0-0x0000000188568900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName() {} // 0x000000018364B0F0-0x000000018364B110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188568B0C-0x0000000188568B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DescriptorProto other) => default; // 0x0000000188568900-0x0000000188568B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000188568B70-0x0000000188568CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188568ED0-0x0000000188568F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188569C0C-0x0000000188569E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188568600-0x00000001885688A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DescriptorProto other) {} // 0x0000000188568CBC-0x0000000188568ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001885698AC-0x0000000188569C0C
	}

	public sealed class ExtensionRangeOptions : IExtendableMessage<ExtensionRangeOptions>, IBufferMessage // TypeDefIndex: 52083
	{
		// Fields
		private static readonly MessageParser<ExtensionRangeOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<ExtensionRangeOptions> _extensions; // 0x18
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x01FD17E5
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x20
	
		// Properties
		private ExtensionSet<ExtensionRangeOptions> _Extensions { get => default; } // 0x0000000181041090-0x00000001810410A0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExtensionRangeOptions> Parser { get => default; } // 0x000000018857061C-0x000000018857066C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001885705BC-0x000000018857061C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188570834-0x0000000188570874 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtensionRangeOptions() {} // 0x0000000188570544-0x00000001885705BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtensionRangeOptions(ExtensionRangeOptions other) {} // 0x0000000188570494-0x0000000188570544
		static ExtensionRangeOptions() {} // 0x0000000188570324-0x0000000188570494
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtensionRangeOptions Clone() => default; // 0x0000000188570084-0x00000001885700E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188570174-0x00000001885701D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExtensionRangeOptions other) => default; // 0x00000001885700E4-0x0000000188570174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x00000001885701D8-0x0000000188570240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x00000001885702D8-0x0000000188570324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018857076C-0x0000000188570834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018856FFC8-0x0000000188570084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExtensionRangeOptions other) {} // 0x0000000188570240-0x00000001885702D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018857066C-0x000000018857076C
		public TValue GetExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension) => default;
		public void ClearExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension) {}
		public void ClearExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension) {}
	}

	public sealed class FieldDescriptorProto : IMessage<FieldDescriptorProto>, IBufferMessage // TypeDefIndex: 52088
	{
		// Fields
		private static readonly MessageParser<FieldDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		private int _hasBits0; // 0x18
		public const int NameFieldNumber = 1; // Metadata: 0x01FD17E7
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x20
		public const int NumberFieldNumber = 3; // Metadata: 0x01FD17E8
		private static readonly int NumberDefaultValue; // 0x10
		private int number_; // 0x28
		public const int LabelFieldNumber = 4; // Metadata: 0x01FD17E9
		private static readonly Types.Label LabelDefaultValue; // 0x14
		private Types.Label label_; // 0x2C
		public const int TypeFieldNumber = 5; // Metadata: 0x01FD17EA
		private static readonly Types.Type TypeDefaultValue; // 0x18
		private Types.Type type_; // 0x30
		public const int TypeNameFieldNumber = 6; // Metadata: 0x01FD17EB
		private static readonly string TypeNameDefaultValue; // 0x20
		private string typeName_; // 0x38
		public const int ExtendeeFieldNumber = 2; // Metadata: 0x01FD17EC
		private static readonly string ExtendeeDefaultValue; // 0x28
		private string extendee_; // 0x40
		public const int DefaultValueFieldNumber = 7; // Metadata: 0x01FD17ED
		private static readonly string DefaultValueDefaultValue; // 0x30
		private string defaultValue_; // 0x48
		public const int OneofIndexFieldNumber = 9; // Metadata: 0x01FD17EE
		private static readonly int OneofIndexDefaultValue; // 0x38
		private int oneofIndex_; // 0x50
		public const int JsonNameFieldNumber = 10; // Metadata: 0x01FD17EF
		private static readonly string JsonNameDefaultValue; // 0x40
		private string jsonName_; // 0x58
		public const int OptionsFieldNumber = 8; // Metadata: 0x01FD17F0
		private Google.Protobuf.Reflection.FieldOptions options_; // 0x60
		public const int Proto3OptionalFieldNumber = 17; // Metadata: 0x01FD17F1
		private static readonly bool Proto3OptionalDefaultValue; // 0x48
		private bool proto3Optional_; // 0x68
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FieldDescriptorProto> Parser { get => default; } // 0x0000000188572008-0x0000000188572058 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188571D8C-0x0000000188571DEC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188572598-0x00000001885725D8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x0000000188571F0C-0x0000000188571F60 0x0000000188572710-0x0000000188572778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get => default; } // 0x0000000188571E40-0x0000000188571E4C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Number { get => default; set {} } // 0x0000000188571F60-0x0000000188571FB4 0x0000000183D6BCC0-0x0000000183D6BCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasNumber { get => default; } // 0x0000000182461A70-0x0000000182461A80 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.Label Label { get => default; set {} } // 0x0000000188571EB8-0x0000000188571F0C 0x0000000183D6BCB0-0x0000000183D6BCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLabel { get => default; } // 0x0000000188570E90-0x0000000188570E98 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.Type Type { get => default; set {} } // 0x0000000188572100-0x0000000188572154 0x0000000183D6BCF0-0x0000000183D6BD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasType { get => default; } // 0x0000000188571E5C-0x0000000188571E64 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TypeName { get => default; set {} } // 0x00000001885720AC-0x0000000188572100 0x0000000188572778-0x00000001885727E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTypeName { get => default; } // 0x00000001860DAC58-0x00000001860DAC64 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Extendee { get => default; set {} } // 0x0000000188571DEC-0x0000000188571E40 0x0000000188572640-0x00000001885726A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasExtendee { get => default; } // 0x0000000182A794C0-0x0000000182A794D0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DefaultValue { get => default; set {} } // 0x0000000188571D38-0x0000000188571D8C 0x00000001885725D8-0x0000000188572640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDefaultValue { get => default; } // 0x0000000185ED8890-0x0000000185ED889C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OneofIndex { get => default; set {} } // 0x0000000188571FB4-0x0000000188572008 0x0000000183D6BCD0-0x0000000183D6BCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasOneofIndex { get => default; } // 0x0000000188571E4C-0x0000000188571E54 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string JsonName { get => default; set {} } // 0x0000000188571E64-0x0000000188571EB8 0x00000001885726A8-0x0000000188572710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasJsonName { get => default; } // 0x0000000185C72CF8-0x0000000185C72D04 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Google.Protobuf.Reflection.FieldOptions Options { get => default; set {} } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Proto3Optional { get => default; set {} } // 0x0000000188572058-0x00000001885720AC 0x0000000183D6BCE0-0x0000000183D6BCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasProto3Optional { get => default; } // 0x0000000188571E54-0x0000000188571E5C 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 52086
		{
			// Nested types
			public enum Type // TypeDefIndex: 52084
			{
				Double = 1,
				Float = 2,
				Int64 = 3,
				Uint64 = 4,
				Int32 = 5,
				Fixed64 = 6,
				Fixed32 = 7,
				Bool = 8,
				String = 9,
				Group = 10,
				Message = 11,
				Bytes = 12,
				Uint32 = 13,
				Enum = 14,
				Sfixed32 = 15,
				Sfixed64 = 16,
				Sint32 = 17,
				Sint64 = 18
			}
	
			public enum Label // TypeDefIndex: 52085
			{
				Optional = 1,
				Required = 2,
				Repeated = 3
			}
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldDescriptorProto() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldDescriptorProto(FieldDescriptorProto other) {} // 0x0000000188571C54-0x0000000188571D38
		static FieldDescriptorProto() {} // 0x00000001885719EC-0x0000000188571C54
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldDescriptorProto Clone() => default; // 0x0000000188571394-0x00000001885713F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName() {} // 0x0000000188571380-0x0000000188571394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearNumber() {} // 0x0000000183D4F650-0x0000000183D4F660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLabel() {} // 0x0000000183D6BC50-0x0000000183D6BC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearType() {} // 0x0000000183D6BCA0-0x0000000183D6BCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTypeName() {} // 0x0000000185D62B50-0x0000000185D62B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearExtendee() {} // 0x0000000188571358-0x000000018857136C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDefaultValue() {} // 0x0000000185D6CFCC-0x0000000185D6CFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearOneofIndex() {} // 0x0000000183D6BC80-0x0000000183D6BC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearJsonName() {} // 0x000000018857136C-0x0000000188571380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearProto3Optional() {} // 0x0000000183D6BC90-0x0000000183D6BCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x00000001885713F4-0x0000000188571458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FieldDescriptorProto other) => default; // 0x0000000188571458-0x0000000188571624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000188571624-0x00000001885717D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x00000001885719A0-0x00000001885719EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188572394-0x0000000188572598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188571140-0x0000000188571358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FieldDescriptorProto other) {} // 0x00000001885717D4-0x00000001885719A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188572154-0x0000000188572394
	}

	public sealed class OneofDescriptorProto : IMessage<OneofDescriptorProto>, IBufferMessage // TypeDefIndex: 52090
	{
		// Fields
		private static readonly MessageParser<OneofDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x01FD1807
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x18
		public const int OptionsFieldNumber = 2; // Metadata: 0x01FD1808
		private OneofOptions options_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneofDescriptorProto> Parser { get => default; } // 0x0000000188576D5C-0x0000000188576DAC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188576CA8-0x0000000188576D08 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188576F20-0x0000000188576F60 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x0000000188576D08-0x0000000188576D5C 0x0000000188576F60-0x0000000188576FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get => default; } // 0x0000000182702DB0-0x0000000182702DC0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneofOptions Options { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneofDescriptorProto() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneofDescriptorProto(OneofDescriptorProto other) {} // 0x0000000188576C34-0x0000000188576CA8
		static OneofDescriptorProto() {} // 0x0000000188576AF0-0x0000000188576C34
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneofDescriptorProto Clone() => default; // 0x000000018857680C-0x000000018857686C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName() {} // 0x000000018364B0F0-0x000000018364B110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x00000001885768F0-0x0000000188576954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneofDescriptorProto other) => default; // 0x000000018857686C-0x00000001885768F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000188576954-0x00000001885769C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188576AA4-0x0000000188576AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188576EA0-0x0000000188576F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188576764-0x000000018857680C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneofDescriptorProto other) {} // 0x00000001885769C8-0x0000000188576AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188576DAC-0x0000000188576EA0
	}

	public sealed class EnumDescriptorProto : IMessage<EnumDescriptorProto>, IBufferMessage // TypeDefIndex: 52095
	{
		// Fields
		private static readonly MessageParser<EnumDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x01FD1809
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x18
		public const int ValueFieldNumber = 2; // Metadata: 0x01FD180A
		private static readonly FieldCodec<EnumValueDescriptorProto> _repeated_value_codec; // 0x10
		private readonly RepeatedField<EnumValueDescriptorProto> value_; // 0x20
		public const int OptionsFieldNumber = 3; // Metadata: 0x01FD180B
		private EnumOptions options_; // 0x28
		public const int ReservedRangeFieldNumber = 4; // Metadata: 0x01FD180C
		private static readonly FieldCodec<Types.EnumReservedRange> _repeated_reservedRange_codec; // 0x18
		private readonly RepeatedField<Types.EnumReservedRange> reservedRange_; // 0x30
		public const int ReservedNameFieldNumber = 5; // Metadata: 0x01FD180D
		private static readonly FieldCodec<string> _repeated_reservedName_codec; // 0x20
		private readonly RepeatedField<string> reservedName_; // 0x38
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnumDescriptorProto> Parser { get => default; } // 0x000000018856E490-0x000000018856E4E0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018856E3DC-0x000000018856E43C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018856E83C-0x000000018856E87C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x000000018856E43C-0x000000018856E490 0x000000018856E87C-0x000000018856E8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get => default; } // 0x0000000182702DB0-0x0000000182702DC0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnumValueDescriptorProto> Value { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumOptions Options { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Types.EnumReservedRange> ReservedRange { get => default; } // 0x0000000181003830-0x0000000181003840 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ReservedName { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 52093
		{
			// Nested types
			public sealed class EnumReservedRange : IMessage<EnumReservedRange>, IBufferMessage // TypeDefIndex: 52092
			{
				// Fields
				private static readonly MessageParser<EnumReservedRange> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				private int _hasBits0; // 0x18
				public const int StartFieldNumber = 1; // Metadata: 0x01FD180E
				private static readonly int StartDefaultValue; // 0x08
				private int start_; // 0x1C
				public const int EndFieldNumber = 2; // Metadata: 0x01FD180F
				private static readonly int EndDefaultValue; // 0x0C
				private int end_; // 0x20
	
				// Properties
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<EnumReservedRange> Parser { get => default; } // 0x000000018857ED08-0x000000018857ED58 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor Descriptor { get => default; } // 0x000000018857EC54-0x000000018857ECB4 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018857EE34-0x000000018857EE74 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Start { get => default; set {} } // 0x000000018857ED58-0x000000018857EDAC 0x0000000183D6BC70-0x0000000183D6BC80
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasStart { get => default; } // 0x0000000182461A70-0x0000000182461A80 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int End { get => default; set {} } // 0x000000018857ECB4-0x000000018857ED08 0x0000000183D6BC60-0x0000000183D6BC70
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasEnd { get => default; } // 0x0000000188570E90-0x0000000188570E98 
	
				// Constructors
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public EnumReservedRange() {} // 0x000000018350B670-0x000000018350B680
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public EnumReservedRange(EnumReservedRange other) {} // 0x00000001851669EC-0x0000000185166A34
				static EnumReservedRange() {} // 0x000000018857EB28-0x000000018857EC54
	
				// Methods
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public EnumReservedRange Clone() => default; // 0x000000018857E8DC-0x000000018857E93C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearStart() {} // 0x0000000183D4F650-0x0000000183D4F660
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearEnd() {} // 0x0000000183D6BC50-0x0000000183D6BC60
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other) => default; // 0x000000018857E93C-0x000000018857E9A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(EnumReservedRange other) => default; // 0x000000018857E9A0-0x000000018857EA18
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode() => default; // 0x000000018857EA18-0x000000018857EA70
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString() => default; // 0x000000018857EADC-0x000000018857EB28
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018857EDAC-0x000000018857EE34
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize() => default; // 0x000000018857E830-0x000000018857E8DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(EnumReservedRange other) {} // 0x000000018857EA70-0x000000018857EADC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188577BEC-0x0000000188577C88
			}
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumDescriptorProto() {} // 0x000000018856E1B0-0x000000018856E2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumDescriptorProto(EnumDescriptorProto other) {} // 0x000000018856E2BC-0x000000018856E3DC
		static EnumDescriptorProto() {} // 0x000000018856DF64-0x000000018856E1B0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumDescriptorProto Clone() => default; // 0x000000018856DB10-0x000000018856DB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName() {} // 0x000000018364B0F0-0x000000018364B110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018856DB70-0x000000018856DBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnumDescriptorProto other) => default; // 0x000000018856DBD4-0x000000018856DCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018856DCF8-0x000000018856DDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018856DF18-0x000000018856DF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018856E6CC-0x000000018856E83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018856D988-0x000000018856DB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnumDescriptorProto other) {} // 0x000000018856DDC4-0x000000018856DF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018856E4E0-0x000000018856E6CC
	}

	public sealed class EnumValueDescriptorProto : IMessage<EnumValueDescriptorProto>, IBufferMessage // TypeDefIndex: 52097
	{
		// Fields
		private static readonly MessageParser<EnumValueDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		private int _hasBits0; // 0x18
		public const int NameFieldNumber = 1; // Metadata: 0x01FD1810
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x20
		public const int NumberFieldNumber = 2; // Metadata: 0x01FD1811
		private static readonly int NumberDefaultValue; // 0x10
		private int number_; // 0x28
		public const int OptionsFieldNumber = 3; // Metadata: 0x01FD1812
		private EnumValueOptions options_; // 0x30
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnumValueDescriptorProto> Parser { get => default; } // 0x000000018857F554-0x000000018857F5A4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018857F44C-0x000000018857F4AC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018857F76C-0x000000018857F7AC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x000000018857F4AC-0x000000018857F500 0x000000018857F7AC-0x000000018857F814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get => default; } // 0x0000000188571E40-0x0000000188571E4C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Number { get => default; set {} } // 0x000000018857F500-0x000000018857F554 0x0000000183D6BCC0-0x0000000183D6BCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasNumber { get => default; } // 0x0000000182461A70-0x0000000182461A80 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValueOptions Options { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValueDescriptorProto() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValueDescriptorProto(EnumValueDescriptorProto other) {} // 0x000000018857F3CC-0x000000018857F44C
		static EnumValueDescriptorProto() {} // 0x000000018857F270-0x000000018857F3CC
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValueDescriptorProto Clone() => default; // 0x000000018857EF48-0x000000018857EFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName() {} // 0x0000000188571380-0x0000000188571394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearNumber() {} // 0x0000000183D4F650-0x0000000183D4F660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018857EFA8-0x000000018857F00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnumValueDescriptorProto other) => default; // 0x000000018857F00C-0x000000018857F0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018857F0A8-0x000000018857F130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018857F224-0x000000018857F270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018857F6C4-0x000000018857F76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018857EE74-0x000000018857EF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnumValueDescriptorProto other) {} // 0x000000018857F130-0x000000018857F224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018857F5A4-0x000000018857F6C4
	}

	public sealed class ServiceDescriptorProto : IMessage<ServiceDescriptorProto>, IBufferMessage // TypeDefIndex: 52099
	{
		// Fields
		private static readonly MessageParser<ServiceDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x01FD1813
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x18
		public const int MethodFieldNumber = 2; // Metadata: 0x01FD1814
		private static readonly FieldCodec<MethodDescriptorProto> _repeated_method_codec; // 0x10
		private readonly RepeatedField<MethodDescriptorProto> method_; // 0x20
		public const int OptionsFieldNumber = 3; // Metadata: 0x01FD1815
		private ServiceOptions options_; // 0x28
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ServiceDescriptorProto> Parser { get => default; } // 0x000000018858A1F8-0x000000018858A248 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018858A144-0x000000018858A1A4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018858A48C-0x000000018858A4CC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x000000018858A1A4-0x000000018858A1F8 0x000000018858A4CC-0x000000018858A534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get => default; } // 0x0000000182702DB0-0x0000000182702DC0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MethodDescriptorProto> Method { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServiceOptions Options { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServiceDescriptorProto() {} // 0x000000018858A008-0x000000018858A080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServiceDescriptorProto(ServiceDescriptorProto other) {} // 0x000000018858A080-0x000000018858A144
		static ServiceDescriptorProto() {} // 0x0000000188589E5C-0x000000018858A008
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServiceDescriptorProto Clone() => default; // 0x0000000188589AFC-0x0000000188589B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName() {} // 0x000000018364B0F0-0x000000018364B110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188589C20-0x0000000188589C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ServiceDescriptorProto other) => default; // 0x0000000188589B5C-0x0000000188589C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000188589C84-0x0000000188589D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188589E10-0x0000000188589E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018858A39C-0x000000018858A48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x00000001885899FC-0x0000000188589AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ServiceDescriptorProto other) {} // 0x0000000188589D0C-0x0000000188589E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018858A248-0x000000018858A39C
	}

	public sealed class MethodDescriptorProto : IMessage<MethodDescriptorProto>, IBufferMessage // TypeDefIndex: 52101
	{
		// Fields
		private static readonly MessageParser<MethodDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		private int _hasBits0; // 0x18
		public const int NameFieldNumber = 1; // Metadata: 0x01FD1816
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x20
		public const int InputTypeFieldNumber = 2; // Metadata: 0x01FD1817
		private static readonly string InputTypeDefaultValue; // 0x10
		private string inputType_; // 0x28
		public const int OutputTypeFieldNumber = 3; // Metadata: 0x01FD1818
		private static readonly string OutputTypeDefaultValue; // 0x18
		private string outputType_; // 0x30
		public const int OptionsFieldNumber = 4; // Metadata: 0x01FD1819
		private MethodOptions options_; // 0x38
		public const int ClientStreamingFieldNumber = 5; // Metadata: 0x01FD181A
		private static readonly bool ClientStreamingDefaultValue; // 0x20
		private bool clientStreaming_; // 0x40
		public const int ServerStreamingFieldNumber = 6; // Metadata: 0x01FD181B
		private static readonly bool ServerStreamingDefaultValue; // 0x21
		private bool serverStreaming_; // 0x41
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MethodDescriptorProto> Parser { get => default; } // 0x00000001885879A8-0x00000001885879F8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018858784C-0x00000001885878AC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188587CF8-0x0000000188587D38 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x0000000188587900-0x0000000188587954 0x0000000188587DA0-0x0000000188587E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get => default; } // 0x0000000188571E40-0x0000000188571E4C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string InputType { get => default; set {} } // 0x00000001885878AC-0x0000000188587900 0x0000000188587D38-0x0000000188587DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasInputType { get => default; } // 0x0000000185693D38-0x0000000185693D44 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OutputType { get => default; set {} } // 0x0000000188587954-0x00000001885879A8 0x0000000188587E08-0x0000000188587E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasOutputType { get => default; } // 0x00000001885839D0-0x00000001885839DC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MethodOptions Options { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ClientStreaming { get => default; set {} } // 0x00000001885877F8-0x000000018858784C 0x0000000183D6BF10-0x0000000183D6BF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasClientStreaming { get => default; } // 0x0000000182461A70-0x0000000182461A80 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ServerStreaming { get => default; set {} } // 0x00000001885879F8-0x0000000188587A4C 0x0000000183D6BF20-0x0000000183D6BF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasServerStreaming { get => default; } // 0x0000000188570E90-0x0000000188570E98 
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MethodDescriptorProto() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MethodDescriptorProto(MethodDescriptorProto other) {} // 0x000000018858774C-0x00000001885877F8
		static MethodDescriptorProto() {} // 0x0000000188587584-0x000000018858774C
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MethodDescriptorProto Clone() => default; // 0x00000001885870D4-0x0000000188587134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName() {} // 0x0000000188571380-0x0000000188571394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearInputType() {} // 0x0000000188254178-0x000000018825418C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearOutputType() {} // 0x0000000185572920-0x0000000185572934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearClientStreaming() {} // 0x0000000183D4F650-0x0000000183D4F660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearServerStreaming() {} // 0x0000000183D6BC50-0x0000000183D6BC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018858724C-0x00000001885872B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MethodDescriptorProto other) => default; // 0x0000000188587134-0x000000018858724C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x00000001885872B0-0x00000001885873F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188587538-0x0000000188587584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188587BCC-0x0000000188587CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188586FBC-0x00000001885870D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MethodDescriptorProto other) {} // 0x00000001885873F0-0x0000000188587538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188587A4C-0x0000000188587BCC
	}

	public sealed class FileOptions : IExtendableMessage<Google.Protobuf.Reflection.FileOptions>, IBufferMessage // TypeDefIndex: 52105
	{
		// Fields
		private static readonly MessageParser<FileOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<FileOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int JavaPackageFieldNumber = 1; // Metadata: 0x01FD181C
		private static readonly string JavaPackageDefaultValue; // 0x08
		private string javaPackage_; // 0x28
		public const int JavaOuterClassnameFieldNumber = 8; // Metadata: 0x01FD181D
		private static readonly string JavaOuterClassnameDefaultValue; // 0x10
		private string javaOuterClassname_; // 0x30
		public const int JavaMultipleFilesFieldNumber = 10; // Metadata: 0x01FD181E
		private static readonly bool JavaMultipleFilesDefaultValue; // 0x18
		private bool javaMultipleFiles_; // 0x38
		public const int JavaGenerateEqualsAndHashFieldNumber = 20; // Metadata: 0x01FD181F
		private static readonly bool JavaGenerateEqualsAndHashDefaultValue; // 0x19
		private bool javaGenerateEqualsAndHash_; // 0x39
		public const int JavaStringCheckUtf8FieldNumber = 27; // Metadata: 0x01FD1820
		private static readonly bool JavaStringCheckUtf8DefaultValue; // 0x1A
		private bool javaStringCheckUtf8_; // 0x3A
		public const int OptimizeForFieldNumber = 9; // Metadata: 0x01FD1821
		private static readonly Types.OptimizeMode OptimizeForDefaultValue; // 0x1C
		private Types.OptimizeMode optimizeFor_; // 0x3C
		public const int GoPackageFieldNumber = 11; // Metadata: 0x01FD1822
		private static readonly string GoPackageDefaultValue; // 0x20
		private string goPackage_; // 0x40
		public const int CcGenericServicesFieldNumber = 16; // Metadata: 0x01FD1823
		private static readonly bool CcGenericServicesDefaultValue; // 0x28
		private bool ccGenericServices_; // 0x48
		public const int JavaGenericServicesFieldNumber = 17; // Metadata: 0x01FD1824
		private static readonly bool JavaGenericServicesDefaultValue; // 0x29
		private bool javaGenericServices_; // 0x49
		public const int PyGenericServicesFieldNumber = 18; // Metadata: 0x01FD1825
		private static readonly bool PyGenericServicesDefaultValue; // 0x2A
		private bool pyGenericServices_; // 0x4A
		public const int PhpGenericServicesFieldNumber = 42; // Metadata: 0x01FD1826
		private static readonly bool PhpGenericServicesDefaultValue; // 0x2B
		private bool phpGenericServices_; // 0x4B
		public const int DeprecatedFieldNumber = 23; // Metadata: 0x01FD1827
		private static readonly bool DeprecatedDefaultValue; // 0x2C
		private bool deprecated_; // 0x4C
		public const int CcEnableArenasFieldNumber = 31; // Metadata: 0x01FD1828
		private static readonly bool CcEnableArenasDefaultValue; // 0x2D
		private bool ccEnableArenas_; // 0x4D
		public const int ObjcClassPrefixFieldNumber = 36; // Metadata: 0x01FD1829
		private static readonly string ObjcClassPrefixDefaultValue; // 0x30
		private string objcClassPrefix_; // 0x50
		public const int CsharpNamespaceFieldNumber = 37; // Metadata: 0x01FD182A
		private static readonly string CsharpNamespaceDefaultValue; // 0x38
		private string csharpNamespace_; // 0x58
		public const int SwiftPrefixFieldNumber = 39; // Metadata: 0x01FD182B
		private static readonly string SwiftPrefixDefaultValue; // 0x40
		private string swiftPrefix_; // 0x60
		public const int PhpClassPrefixFieldNumber = 40; // Metadata: 0x01FD182C
		private static readonly string PhpClassPrefixDefaultValue; // 0x48
		private string phpClassPrefix_; // 0x68
		public const int PhpNamespaceFieldNumber = 41; // Metadata: 0x01FD182D
		private static readonly string PhpNamespaceDefaultValue; // 0x50
		private string phpNamespace_; // 0x70
		public const int PhpMetadataNamespaceFieldNumber = 44; // Metadata: 0x01FD182E
		private static readonly string PhpMetadataNamespaceDefaultValue; // 0x58
		private string phpMetadataNamespace_; // 0x78
		public const int RubyPackageFieldNumber = 45; // Metadata: 0x01FD182F
		private static readonly string RubyPackageDefaultValue; // 0x60
		private string rubyPackage_; // 0x80
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x01FD1830
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x68
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x88
	
		// Properties
		private ExtensionSet<FileOptions> _Extensions { get => default; } // 0x0000000181041090-0x00000001810410A0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FileOptions> Parser { get => default; } // 0x0000000188583CAC-0x0000000188583CFC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188583910-0x0000000188583970 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188584794-0x00000001885847D4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string JavaPackage { get => default; set {} } // 0x0000000188583B5C-0x0000000188583BB0 0x000000018858490C-0x0000000188584974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasJavaPackage { get => default; } // 0x0000000185693D38-0x0000000185693D44 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string JavaOuterClassname { get => default; set {} } // 0x0000000188583B08-0x0000000188583B5C 0x00000001885848A4-0x000000018858490C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasJavaOuterClassname { get => default; } // 0x00000001885839D0-0x00000001885839DC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JavaMultipleFiles { get => default; set {} } // 0x0000000188583AB4-0x0000000188583B08 0x0000000183D6BEA0-0x0000000183D6BEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasJavaMultipleFiles { get => default; } // 0x000000018857E548-0x000000018857E550 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[Obsolete]
		public bool JavaGenerateEqualsAndHash { get => default; set {} } // 0x0000000188583A0C-0x0000000188583A60 0x0000000183D6BE80-0x0000000183D6BE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[Obsolete]
		public bool HasJavaGenerateEqualsAndHash { get => default; } // 0x0000000188581D24-0x0000000188581D2C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JavaStringCheckUtf8 { get => default; set {} } // 0x0000000188583BB0-0x0000000188583C04 0x0000000183D6BEB0-0x0000000183D6BEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasJavaStringCheckUtf8 { get => default; } // 0x00000001885839DC-0x00000001885839E8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.OptimizeMode OptimizeFor { get => default; set {} } // 0x0000000188583C58-0x0000000188583CAC 0x0000000183D6BEC0-0x0000000183D6BED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasOptimizeFor { get => default; } // 0x000000018857E540-0x000000018857E548 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GoPackage { get => default; set {} } // 0x0000000188583970-0x00000001885839C4 0x000000018858483C-0x00000001885848A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasGoPackage { get => default; } // 0x0000000182A794C0-0x0000000182A794D0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CcGenericServices { get => default; set {} } // 0x0000000188583814-0x0000000188583868 0x0000000183D6BE60-0x0000000183D6BE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasCcGenericServices { get => default; } // 0x0000000188581D04-0x0000000188581D0C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JavaGenericServices { get => default; set {} } // 0x0000000188583A60-0x0000000188583AB4 0x0000000183D6BE90-0x0000000183D6BEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasJavaGenericServices { get => default; } // 0x0000000188581D14-0x0000000188581D1C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PyGenericServices { get => default; set {} } // 0x0000000188583E50-0x0000000188583EA4 0x0000000183D6BEE0-0x0000000183D6BEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPyGenericServices { get => default; } // 0x0000000188581D0C-0x0000000188581D14 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PhpGenericServices { get => default; set {} } // 0x0000000188583D50-0x0000000188583DA8 0x0000000183D6BED0-0x0000000183D6BEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPhpGenericServices { get => default; } // 0x0000000183874860-0x0000000183874870 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deprecated { get => default; set {} } // 0x00000001885838BC-0x0000000188583910 0x0000000183D6BE70-0x0000000183D6BE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDeprecated { get => default; } // 0x0000000188581D1C-0x0000000188581D24 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CcEnableArenas { get => default; set {} } // 0x00000001885837BC-0x0000000188583814 0x0000000183D6BE50-0x0000000183D6BE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasCcEnableArenas { get => default; } // 0x00000001885839C4-0x00000001885839D0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ObjcClassPrefix { get => default; set {} } // 0x0000000188583C04-0x0000000188583C58 0x0000000188584974-0x00000001885849DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasObjcClassPrefix { get => default; } // 0x0000000182B84230-0x0000000182B84240 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CsharpNamespace { get => default; set {} } // 0x0000000188583868-0x00000001885838BC 0x00000001885847D4-0x000000018858483C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasCsharpNamespace { get => default; } // 0x0000000185C72CF8-0x0000000185C72D04 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SwiftPrefix { get => default; set {} } // 0x0000000188583EFC-0x0000000188583F50 0x0000000188584B80-0x0000000188584BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSwiftPrefix { get => default; } // 0x0000000185B08B40-0x0000000185B08B4C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PhpClassPrefix { get => default; set {} } // 0x0000000188583CFC-0x0000000188583D50 0x00000001885849DC-0x0000000188584A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPhpClassPrefix { get => default; } // 0x00000001885839E8-0x00000001885839F4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PhpNamespace { get => default; set {} } // 0x0000000188583DFC-0x0000000188583E50 0x0000000188584AAC-0x0000000188584B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPhpNamespace { get => default; } // 0x0000000188574B70-0x0000000188574B7C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PhpMetadataNamespace { get => default; set {} } // 0x0000000188583DA8-0x0000000188583DFC 0x0000000188584A44-0x0000000188584AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPhpMetadataNamespace { get => default; } // 0x00000001885839F4-0x0000000188583A00 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RubyPackage { get => default; set {} } // 0x0000000188583EA4-0x0000000188583EFC 0x0000000188584B14-0x0000000188584B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasRubyPackage { get => default; } // 0x0000000188583A00-0x0000000188583A0C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x0000000183D4EA60-0x0000000183D4EA70 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 52103
		{
			// Nested types
			public enum OptimizeMode // TypeDefIndex: 52102
			{
				Speed = 1,
				CodeSize = 2,
				LiteRuntime = 3
			}
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileOptions() {} // 0x000000018858358C-0x0000000188583608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileOptions(FileOptions other) {} // 0x0000000188583608-0x00000001885837BC
		static FileOptions() {} // 0x0000000188583178-0x000000018858358C
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileOptions Clone() => default; // 0x00000001885826A0-0x0000000188582700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearJavaPackage() {} // 0x0000000188254178-0x000000018825418C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearJavaOuterClassname() {} // 0x0000000185572920-0x0000000185572934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearJavaMultipleFiles() {} // 0x0000000183D6BD30-0x0000000183D6BD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[Obsolete]
		public void ClearJavaGenerateEqualsAndHash() {} // 0x0000000183D6BDA0-0x0000000183D6BDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearJavaStringCheckUtf8() {} // 0x0000000183D6BE30-0x0000000183D6BE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearOptimizeFor() {} // 0x0000000183D6BD20-0x0000000183D6BD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearGoPackage() {} // 0x0000000188571358-0x000000018857136C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCcGenericServices() {} // 0x0000000183D6BD60-0x0000000183D6BD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearJavaGenericServices() {} // 0x0000000183D6BD80-0x0000000183D6BD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPyGenericServices() {} // 0x0000000183D6BD70-0x0000000183D6BD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPhpGenericServices() {} // 0x0000000183D6BE40-0x0000000183D6BE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDeprecated() {} // 0x0000000183D6BD90-0x0000000183D6BDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCcEnableArenas() {} // 0x0000000183D6BE20-0x0000000183D6BE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearObjcClassPrefix() {} // 0x0000000185D62B3C-0x0000000185D62B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCsharpNamespace() {} // 0x000000018857136C-0x0000000188571380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSwiftPrefix() {} // 0x0000000185755F70-0x0000000185755F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPhpClassPrefix() {} // 0x0000000188582664-0x0000000188582678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPhpNamespace() {} // 0x0000000188573B28-0x0000000188573B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPhpMetadataNamespace() {} // 0x0000000188582678-0x000000018858268C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearRubyPackage() {} // 0x000000018858268C-0x00000001885826A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188582700-0x0000000188582764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FileOptions other) => default; // 0x0000000188582764-0x0000000188582AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000188582AF4-0x0000000188582E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018858312C-0x0000000188583178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188584334-0x0000000188584794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018858232C-0x0000000188582664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FileOptions other) {} // 0x0000000188582E5C-0x000000018858312C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188583F50-0x0000000188584334
		public TValue GetExtension<TValue>(Extension<FileOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<FileOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<FileOptions, TValue> extension) => default;
		public void ClearExtension<TValue>(Extension<FileOptions, TValue> extension) {}
		public void ClearExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension) {}
	}

	public sealed class MessageOptions : IExtendableMessage<MessageOptions>, IBufferMessage // TypeDefIndex: 52107
	{
		// Fields
		private static readonly MessageParser<MessageOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<MessageOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int MessageSetWireFormatFieldNumber = 1; // Metadata: 0x01FD1835
		private static readonly bool MessageSetWireFormatDefaultValue; // 0x08
		private bool messageSetWireFormat_; // 0x24
		public const int NoStandardDescriptorAccessorFieldNumber = 2; // Metadata: 0x01FD1836
		private static readonly bool NoStandardDescriptorAccessorDefaultValue; // 0x09
		private bool noStandardDescriptorAccessor_; // 0x25
		public const int DeprecatedFieldNumber = 3; // Metadata: 0x01FD1837
		private static readonly bool DeprecatedDefaultValue; // 0x0A
		private bool deprecated_; // 0x26
		public const int MapEntryFieldNumber = 7; // Metadata: 0x01FD1838
		private static readonly bool MapEntryDefaultValue; // 0x0B
		private bool mapEntry_; // 0x27
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x01FD1839
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x28
	
		// Properties
		private ExtensionSet<MessageOptions> _Extensions { get => default; } // 0x0000000181041090-0x00000001810410A0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MessageOptions> Parser { get => default; } // 0x0000000188586C54-0x0000000188586CA4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188586AF8-0x0000000188586B58 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188586F7C-0x0000000188586FBC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MessageSetWireFormat { get => default; set {} } // 0x0000000188586BAC-0x0000000188586C00 0x0000000183D6BD40-0x0000000183D6BD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasMessageSetWireFormat { get => default; } // 0x000000018857E540-0x000000018857E548 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NoStandardDescriptorAccessor { get => default; set {} } // 0x0000000188586C00-0x0000000188586C54 0x0000000183D6BD50-0x0000000183D6BD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasNoStandardDescriptorAccessor { get => default; } // 0x000000018857E548-0x000000018857E550 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deprecated { get => default; set {} } // 0x0000000188586AA4-0x0000000188586AF8 0x0000000183D6BEF0-0x0000000183D6BF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDeprecated { get => default; } // 0x0000000188581D04-0x0000000188581D0C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MapEntry { get => default; set {} } // 0x0000000188586B58-0x0000000188586BAC 0x0000000183D6BF00-0x0000000183D6BF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasMapEntry { get => default; } // 0x0000000188581D14-0x0000000188581D1C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageOptions() {} // 0x0000000188586A2C-0x0000000188586AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageOptions(MessageOptions other) {} // 0x0000000188586960-0x0000000188586A2C
		static MessageOptions() {} // 0x00000001885867D0-0x0000000188586960
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageOptions Clone() => default; // 0x00000001885863A0-0x0000000188586400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessageSetWireFormat() {} // 0x0000000183D6BD20-0x0000000183D6BD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearNoStandardDescriptorAccessor() {} // 0x0000000183D6BD30-0x0000000183D6BD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDeprecated() {} // 0x0000000183D6BD60-0x0000000183D6BD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMapEntry() {} // 0x0000000183D6BD80-0x0000000183D6BD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188586400-0x0000000188586464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MessageOptions other) => default; // 0x0000000188586464-0x0000000188586578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000188586578-0x000000018858668C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188586784-0x00000001885867D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188586E0C-0x0000000188586F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x00000001885862B8-0x00000001885863A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MessageOptions other) {} // 0x000000018858668C-0x0000000188586784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188586CA4-0x0000000188586E0C
		public TValue GetExtension<TValue>(Extension<MessageOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<MessageOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<MessageOptions, TValue> extension) => default;
		public void ClearExtension<TValue>(Extension<MessageOptions, TValue> extension) {}
		public void ClearExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension) {}
	}

	public sealed class FieldOptions : IExtendableMessage<Google.Protobuf.Reflection.FieldOptions>, IBufferMessage // TypeDefIndex: 52112
	{
		// Fields
		private static readonly MessageParser<FieldOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<FieldOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int CtypeFieldNumber = 1; // Metadata: 0x01FD183B
		private static readonly Types.CType CtypeDefaultValue; // 0x08
		private Types.CType ctype_; // 0x24
		public const int PackedFieldNumber = 2; // Metadata: 0x01FD183C
		private static readonly bool PackedDefaultValue; // 0x0C
		private bool packed_; // 0x28
		public const int JstypeFieldNumber = 6; // Metadata: 0x01FD183D
		private static readonly Types.JSType JstypeDefaultValue; // 0x10
		private Types.JSType jstype_; // 0x2C
		public const int LazyFieldNumber = 5; // Metadata: 0x01FD183E
		private static readonly bool LazyDefaultValue; // 0x14
		private bool lazy_; // 0x30
		public const int UnverifiedLazyFieldNumber = 15; // Metadata: 0x01FD183F
		private static readonly bool UnverifiedLazyDefaultValue; // 0x15
		private bool unverifiedLazy_; // 0x31
		public const int DeprecatedFieldNumber = 3; // Metadata: 0x01FD1840
		private static readonly bool DeprecatedDefaultValue; // 0x16
		private bool deprecated_; // 0x32
		public const int WeakFieldNumber = 10; // Metadata: 0x01FD1841
		private static readonly bool WeakDefaultValue; // 0x17
		private bool weak_; // 0x33
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x01FD1842
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x18
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x38
	
		// Properties
		private ExtensionSet<FieldOptions> _Extensions { get => default; } // 0x0000000181041090-0x00000001810410A0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FieldOptions> Parser { get => default; } // 0x0000000188581E28-0x0000000188581E78 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188581CA4-0x0000000188581D04 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001885822EC-0x000000018858232C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.CType Ctype { get => default; set {} } // 0x0000000188581BFC-0x0000000188581C50 0x0000000183D6BDB0-0x0000000183D6BDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasCtype { get => default; } // 0x000000018857E540-0x000000018857E548 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Packed { get => default; set {} } // 0x0000000188581DD4-0x0000000188581E28 0x0000000183D6BDF0-0x0000000183D6BE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPacked { get => default; } // 0x000000018857E548-0x000000018857E550 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.JSType Jstype { get => default; set {} } // 0x0000000188581D2C-0x0000000188581D80 0x0000000183D6BDD0-0x0000000183D6BDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasJstype { get => default; } // 0x0000000188581D0C-0x0000000188581D14 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Lazy { get => default; set {} } // 0x0000000188581D80-0x0000000188581DD4 0x0000000183D6BDE0-0x0000000183D6BDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLazy { get => default; } // 0x0000000188581D14-0x0000000188581D1C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UnverifiedLazy { get => default; set {} } // 0x0000000188581E78-0x0000000188581ECC 0x0000000183D6BE00-0x0000000183D6BE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnverifiedLazy { get => default; } // 0x0000000188581D1C-0x0000000188581D24 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deprecated { get => default; set {} } // 0x0000000188581C50-0x0000000188581CA4 0x0000000183D6BDC0-0x0000000183D6BDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDeprecated { get => default; } // 0x0000000188581D04-0x0000000188581D0C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Weak { get => default; set {} } // 0x0000000188581ECC-0x0000000188581F20 0x0000000183D6BE10-0x0000000183D6BE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasWeak { get => default; } // 0x0000000188581D24-0x0000000188581D2C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 52110
		{
			// Nested types
			public enum CType // TypeDefIndex: 52108
			{
				String = 0,
				Cord = 1,
				StringPiece = 2
			}
	
			public enum JSType // TypeDefIndex: 52109
			{
				JsNormal = 0,
				JsString = 1,
				JsNumber = 2
			}
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldOptions() {} // 0x0000000188581B84-0x0000000188581BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldOptions(FieldOptions other) {} // 0x0000000188581AA0-0x0000000188581B84
		static FieldOptions() {} // 0x00000001885818DC-0x0000000188581AA0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldOptions Clone() => default; // 0x00000001885813C8-0x0000000188581428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCtype() {} // 0x0000000183D6BD20-0x0000000183D6BD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPacked() {} // 0x0000000183D6BD30-0x0000000183D6BD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearJstype() {} // 0x0000000183D6BD70-0x0000000183D6BD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLazy() {} // 0x0000000183D6BD80-0x0000000183D6BD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnverifiedLazy() {} // 0x0000000183D6BD90-0x0000000183D6BDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDeprecated() {} // 0x0000000183D6BD60-0x0000000183D6BD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearWeak() {} // 0x0000000183D6BDA0-0x0000000183D6BDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188581428-0x000000018858148C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FieldOptions other) => default; // 0x000000018858148C-0x00000001885815F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x00000001885815F8-0x0000000188581750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188581890-0x00000001885818DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001885820FC-0x00000001885822EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188581260-0x00000001885813C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FieldOptions other) {} // 0x0000000188581750-0x0000000188581890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188581F20-0x00000001885820FC
		public TValue GetExtension<TValue>(Extension<FieldOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<FieldOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<FieldOptions, TValue> extension) => default;
		public void ClearExtension<TValue>(Extension<FieldOptions, TValue> extension) {}
		public void ClearExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension) {}
	}

	public sealed class OneofOptions : IExtendableMessage<OneofOptions>, IBufferMessage // TypeDefIndex: 52114
	{
		// Fields
		private static readonly MessageParser<OneofOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<OneofOptions> _extensions; // 0x18
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x01FD184A
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x20
	
		// Properties
		private ExtensionSet<OneofOptions> _Extensions { get => default; } // 0x0000000181041090-0x00000001810410A0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneofOptions> Parser { get => default; } // 0x00000001885897A4-0x00000001885897F4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188589744-0x00000001885897A4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001885899BC-0x00000001885899FC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneofOptions() {} // 0x00000001885896CC-0x0000000188589744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneofOptions(OneofOptions other) {} // 0x000000018858961C-0x00000001885896CC
		static OneofOptions() {} // 0x00000001885894AC-0x000000018858961C
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneofOptions Clone() => default; // 0x0000000188589274-0x00000001885892D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188589364-0x00000001885893C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneofOptions other) => default; // 0x00000001885892D4-0x0000000188589364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x00000001885701D8-0x0000000188570240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188589460-0x00000001885894AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001885898F4-0x00000001885899BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x00000001885891B8-0x0000000188589274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneofOptions other) {} // 0x00000001885893C8-0x0000000188589460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001885897F4-0x00000001885898F4
		public TValue GetExtension<TValue>(Extension<OneofOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<OneofOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<OneofOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<OneofOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<OneofOptions, TValue> extension) => default;
		public void ClearExtension<TValue>(Extension<OneofOptions, TValue> extension) {}
		public void ClearExtension<TValue>(RepeatedExtension<OneofOptions, TValue> extension) {}
	}

	public sealed class EnumOptions : IExtendableMessage<EnumOptions>, IBufferMessage // TypeDefIndex: 52116
	{
		// Fields
		private static readonly MessageParser<EnumOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<EnumOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int AllowAliasFieldNumber = 2; // Metadata: 0x01FD184C
		private static readonly bool AllowAliasDefaultValue; // 0x08
		private bool allowAlias_; // 0x24
		public const int DeprecatedFieldNumber = 3; // Metadata: 0x01FD184D
		private static readonly bool DeprecatedDefaultValue; // 0x09
		private bool deprecated_; // 0x25
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x01FD184E
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x28
	
		// Properties
		private ExtensionSet<EnumOptions> _Extensions { get => default; } // 0x0000000181041090-0x00000001810410A0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnumOptions> Parser { get => default; } // 0x000000018857E550-0x000000018857E5A0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018857E4E0-0x000000018857E540 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018857E7F0-0x000000018857E830 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AllowAlias { get => default; set {} } // 0x000000018857E438-0x000000018857E48C 0x0000000183D6BD40-0x0000000183D6BD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasAllowAlias { get => default; } // 0x000000018857E540-0x000000018857E548 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deprecated { get => default; set {} } // 0x000000018857E48C-0x000000018857E4E0 0x0000000183D6BD50-0x0000000183D6BD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDeprecated { get => default; } // 0x000000018857E548-0x000000018857E550 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumOptions() {} // 0x000000018857E3C0-0x000000018857E438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumOptions(EnumOptions other) {} // 0x000000018857E300-0x000000018857E3C0
		static EnumOptions() {} // 0x000000018857E170-0x000000018857E300
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumOptions Clone() => default; // 0x000000018857DDF4-0x000000018857DE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearAllowAlias() {} // 0x0000000183D6BD20-0x0000000183D6BD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDeprecated() {} // 0x0000000183D6BD30-0x0000000183D6BD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018857DE54-0x000000018857DEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnumOptions other) => default; // 0x000000018857DEB8-0x000000018857DF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018857DF8C-0x000000018857E05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018857E124-0x000000018857E170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018857E6D4-0x000000018857E7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018857DD1C-0x000000018857DDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnumOptions other) {} // 0x000000018857E05C-0x000000018857E124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018857E5A0-0x000000018857E6D4
		public TValue GetExtension<TValue>(Extension<EnumOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<EnumOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<EnumOptions, TValue> extension) => default;
		public void ClearExtension<TValue>(Extension<EnumOptions, TValue> extension) {}
		public void ClearExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension) {}
	}

	public sealed class EnumValueOptions : IExtendableMessage<EnumValueOptions>, IBufferMessage // TypeDefIndex: 52118
	{
		// Fields
		private static readonly MessageParser<EnumValueOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<EnumValueOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int DeprecatedFieldNumber = 1; // Metadata: 0x01FD1850
		private static readonly bool DeprecatedDefaultValue; // 0x08
		private bool deprecated_; // 0x24
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x01FD1851
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x28
	
		// Properties
		private ExtensionSet<EnumValueOptions> _Extensions { get => default; } // 0x0000000181041090-0x00000001810410A0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnumValueOptions> Parser { get => default; } // 0x0000000188580180-0x00000001885801D0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188580120-0x0000000188580180 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001885803DC-0x000000018858041C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deprecated { get => default; set {} } // 0x00000001885800CC-0x0000000188580120 0x0000000183D6BD40-0x0000000183D6BD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDeprecated { get => default; } // 0x000000018857E540-0x000000018857E548 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValueOptions() {} // 0x0000000188580054-0x00000001885800CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValueOptions(EnumValueOptions other) {} // 0x000000018857FF98-0x0000000188580054
		static EnumValueOptions() {} // 0x000000018857FE14-0x000000018857FF98
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValueOptions Clone() => default; // 0x000000018857FAF4-0x000000018857FB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDeprecated() {} // 0x0000000183D6BD20-0x0000000183D6BD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018857FB54-0x000000018857FBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnumValueOptions other) => default; // 0x000000018857FBB8-0x000000018857FC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018857FC6C-0x000000018857FD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018857FDC8-0x000000018857FE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001885802E8-0x00000001885803DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018857FA28-0x000000018857FAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnumValueOptions other) {} // 0x000000018857FD18-0x000000018857FDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001885801D0-0x00000001885802E8
		public TValue GetExtension<TValue>(Extension<EnumValueOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<EnumValueOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<EnumValueOptions, TValue> extension) => default;
		public void ClearExtension<TValue>(Extension<EnumValueOptions, TValue> extension) {}
		public void ClearExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension) {}
	}

	public sealed class ServiceOptions : IExtendableMessage<ServiceOptions>, IBufferMessage // TypeDefIndex: 52120
	{
		// Fields
		private static readonly MessageParser<ServiceOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<ServiceOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int DeprecatedFieldNumber = 33; // Metadata: 0x01FD1853
		private static readonly bool DeprecatedDefaultValue; // 0x08
		private bool deprecated_; // 0x24
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x01FD1854
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x28
	
		// Properties
		private ExtensionSet<ServiceOptions> _Extensions { get => default; } // 0x0000000181041090-0x00000001810410A0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ServiceOptions> Parser { get => default; } // 0x000000018858AC9C-0x000000018858ACEC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018858AC3C-0x000000018858AC9C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018858AF00-0x000000018858AF40 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deprecated { get => default; set {} } // 0x000000018858ABE8-0x000000018858AC3C 0x0000000183D6BD40-0x0000000183D6BD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDeprecated { get => default; } // 0x000000018857E540-0x000000018857E548 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServiceOptions() {} // 0x000000018858AAB4-0x000000018858AB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServiceOptions(ServiceOptions other) {} // 0x000000018858AB2C-0x000000018858ABE8
		static ServiceOptions() {} // 0x000000018858A930-0x000000018858AAB4
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServiceOptions Clone() => default; // 0x000000018858A610-0x000000018858A670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDeprecated() {} // 0x0000000183D6BD20-0x0000000183D6BD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018858A724-0x000000018858A788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ServiceOptions other) => default; // 0x000000018858A670-0x000000018858A724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018858A788-0x000000018858A834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018858A8E4-0x000000018858A930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018858AE08-0x000000018858AF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018858A534-0x000000018858A610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ServiceOptions other) {} // 0x000000018858A834-0x000000018858A8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018858ACEC-0x000000018858AE08
		public TValue GetExtension<TValue>(Extension<ServiceOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<ServiceOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<ServiceOptions, TValue> extension) => default;
		public void ClearExtension<TValue>(Extension<ServiceOptions, TValue> extension) {}
		public void ClearExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension) {}
	}

	public sealed class MethodOptions : IExtendableMessage<MethodOptions>, IBufferMessage // TypeDefIndex: 52124
	{
		// Fields
		private static readonly MessageParser<MethodOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<MethodOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int DeprecatedFieldNumber = 33; // Metadata: 0x01FD1856
		private static readonly bool DeprecatedDefaultValue; // 0x08
		private bool deprecated_; // 0x24
		public const int IdempotencyLevelFieldNumber = 34; // Metadata: 0x01FD1857
		private static readonly Types.IdempotencyLevel IdempotencyLevelDefaultValue; // 0x0C
		private Types.IdempotencyLevel idempotencyLevel_; // 0x28
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x01FD1858
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x30
	
		// Properties
		private ExtensionSet<MethodOptions> _Extensions { get => default; } // 0x0000000181041090-0x00000001810410A0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MethodOptions> Parser { get => default; } // 0x00000001885886C0-0x0000000188588710 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018858860C-0x000000018858866C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188588970-0x00000001885889B0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deprecated { get => default; set {} } // 0x00000001885885B8-0x000000018858860C 0x0000000183D6BD40-0x0000000183D6BD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDeprecated { get => default; } // 0x000000018857E540-0x000000018857E548 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.IdempotencyLevel IdempotencyLevel { get => default; set {} } // 0x000000018858866C-0x00000001885886C0 0x0000000183D6BF30-0x0000000183D6BF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIdempotencyLevel { get => default; } // 0x000000018857E548-0x000000018857E550 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x0000000181003830-0x0000000181003840 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 52122
		{
			// Nested types
			public enum IdempotencyLevel // TypeDefIndex: 52121
			{
				IdempotencyUnknown = 0,
				NoSideEffects = 1,
				Idempotent = 2
			}
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MethodOptions() {} // 0x0000000188588540-0x00000001885885B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MethodOptions(MethodOptions other) {} // 0x0000000188588480-0x0000000188588540
		static MethodOptions() {} // 0x00000001885882EC-0x0000000188588480
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MethodOptions Clone() => default; // 0x0000000188587F84-0x0000000188587FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDeprecated() {} // 0x0000000183D6BD20-0x0000000183D6BD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIdempotencyLevel() {} // 0x0000000183D6BD30-0x0000000183D6BD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188587FE4-0x0000000188588048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MethodOptions other) => default; // 0x0000000188588048-0x000000018858811C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018858811C-0x00000001885881D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x00000001885882A0-0x00000001885882EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018858884C-0x0000000188588970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188587E70-0x0000000188587F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MethodOptions other) {} // 0x00000001885881D8-0x00000001885882A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188588710-0x000000018858884C
		public TValue GetExtension<TValue>(Extension<MethodOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<MethodOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<MethodOptions, TValue> extension) => default;
		public void ClearExtension<TValue>(Extension<MethodOptions, TValue> extension) {}
		public void ClearExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension) {}
	}

	public sealed class UninterpretedOption : IMessage<UninterpretedOption>, IBufferMessage // TypeDefIndex: 52129
	{
		// Fields
		private static readonly MessageParser<UninterpretedOption> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		private int _hasBits0; // 0x18
		public const int NameFieldNumber = 2; // Metadata: 0x01FD185D
		private static readonly FieldCodec<Types.NamePart> _repeated_name_codec; // 0x08
		private readonly RepeatedField<Types.NamePart> name_; // 0x20
		public const int IdentifierValueFieldNumber = 3; // Metadata: 0x01FD185E
		private static readonly string IdentifierValueDefaultValue; // 0x10
		private string identifierValue_; // 0x28
		public const int PositiveIntValueFieldNumber = 4; // Metadata: 0x01FD185F
		private static readonly ulong PositiveIntValueDefaultValue; // 0x18
		private ulong positiveIntValue_; // 0x30
		public const int NegativeIntValueFieldNumber = 5; // Metadata: 0x01FD1860
		private static readonly long NegativeIntValueDefaultValue; // 0x20
		private long negativeIntValue_; // 0x38
		public const int DoubleValueFieldNumber = 6; // Metadata: 0x01FD1861
		private static readonly double DoubleValueDefaultValue; // 0x28
		private double doubleValue_; // 0x40
		public const int StringValueFieldNumber = 7; // Metadata: 0x01FD1862
		private static readonly ByteString StringValueDefaultValue; // 0x30
		private ByteString stringValue_; // 0x48
		public const int AggregateValueFieldNumber = 8; // Metadata: 0x01FD1863
		private static readonly string AggregateValueDefaultValue; // 0x38
		private string aggregateValue_; // 0x50
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UninterpretedOption> Parser { get => default; } // 0x000000018858D144-0x000000018858D194 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018858CF90-0x000000018858CFF0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018858D5BC-0x000000018858D5FC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Types.NamePart> Name { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string IdentifierValue { get => default; set {} } // 0x000000018858D098-0x000000018858D0EC 0x000000018858D664-0x000000018858D6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIdentifierValue { get => default; } // 0x0000000185693D38-0x0000000185693D44 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong PositiveIntValue { get => default; set {} } // 0x000000018858D194-0x000000018858D1EC 0x0000000183D6BF70-0x0000000183D6BF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPositiveIntValue { get => default; } // 0x0000000182461A70-0x0000000182461A80 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NegativeIntValue { get => default; set {} } // 0x000000018858D0EC-0x000000018858D144 0x0000000183D6BF60-0x0000000183D6BF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasNegativeIntValue { get => default; } // 0x0000000188570E90-0x0000000188570E98 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double DoubleValue { get => default; set {} } // 0x000000018858CFF0-0x000000018858D048 0x0000000183D6BF50-0x0000000183D6BF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDoubleValue { get => default; } // 0x0000000188571E5C-0x0000000188571E64 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString StringValue { get => default; set {} } // 0x000000018858D1EC-0x000000018858D240 0x000000018858D6CC-0x000000018858D734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasStringValue { get => default; } // 0x000000018858D048-0x000000018858D098 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AggregateValue { get => default; set {} } // 0x000000018858CF3C-0x000000018858CF90 0x000000018858D5FC-0x000000018858D664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasAggregateValue { get => default; } // 0x0000000182B84230-0x0000000182B84240 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 52127
		{
			// Nested types
			public sealed class NamePart : IMessage<NamePart>, IBufferMessage // TypeDefIndex: 52126
			{
				// Fields
				private static readonly MessageParser<NamePart> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				private int _hasBits0; // 0x18
				public const int NamePart_FieldNumber = 1; // Metadata: 0x01FD1864
				private static readonly string NamePart_DefaultValue; // 0x08
				private string namePart_; // 0x20
				public const int IsExtensionFieldNumber = 2; // Metadata: 0x01FD1865
				private static readonly bool IsExtensionDefaultValue; // 0x10
				private bool isExtension_; // 0x28
	
				// Properties
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<NamePart> Parser { get => default; } // 0x0000000188588FA4-0x0000000188588FF4 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor Descriptor { get => default; } // 0x0000000188588E9C-0x0000000188588EFC 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188589110-0x0000000188589150 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string NamePart_ { get => default; set {} } // 0x0000000188588F50-0x0000000188588FA4 0x0000000188589150-0x00000001885891B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasNamePart_ { get => default; } // 0x0000000188571E40-0x0000000188571E4C 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool IsExtension { get => default; set {} } // 0x0000000188588EFC-0x0000000188588F50 0x0000000183D6BF40-0x0000000183D6BF50
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasIsExtension { get => default; } // 0x0000000182461A70-0x0000000182461A80 
	
				// Constructors
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NamePart() {} // 0x000000018350B670-0x000000018350B680
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NamePart(NamePart other) {} // 0x0000000188588E48-0x0000000188588E9C
				static NamePart() {} // 0x0000000188588CEC-0x0000000188588E48
	
				// Methods
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NamePart Clone() => default; // 0x0000000188588A34-0x0000000188588A94
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearNamePart_() {} // 0x0000000188571380-0x0000000188571394
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearIsExtension() {} // 0x0000000183D4F650-0x0000000183D4F660
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other) => default; // 0x0000000188588A94-0x0000000188588AF8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(NamePart other) => default; // 0x0000000188588AF8-0x0000000188588B80
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode() => default; // 0x0000000188588B80-0x0000000188588C2C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString() => default; // 0x0000000188588CA0-0x0000000188588CEC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188589088-0x0000000188589110
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize() => default; // 0x00000001885889B0-0x0000000188588A34
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(NamePart other) {} // 0x0000000188588C2C-0x0000000188588CA0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188588FF4-0x0000000188589088
			}
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UninterpretedOption() {} // 0x000000018858CEC4-0x000000018858CF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UninterpretedOption(UninterpretedOption other) {} // 0x000000018858CDE4-0x000000018858CEC4
		static UninterpretedOption() {} // 0x000000018858CB88-0x000000018858CDE4
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UninterpretedOption Clone() => default; // 0x000000018858C604-0x000000018858C664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIdentifierValue() {} // 0x0000000188254178-0x000000018825418C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPositiveIntValue() {} // 0x0000000183D4F650-0x0000000183D4F660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearNegativeIntValue() {} // 0x0000000183D6BC50-0x0000000183D6BC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDoubleValue() {} // 0x0000000183D6BCA0-0x0000000183D6BCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStringValue() {} // 0x0000000185D6CFCC-0x0000000185D6CFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearAggregateValue() {} // 0x0000000185D62B3C-0x0000000185D62B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018858C664-0x000000018858C6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UninterpretedOption other) => default; // 0x000000018858C6C8-0x000000018858C8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018858C8A0-0x000000018858CA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018858CB3C-0x000000018858CB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018858D408-0x000000018858D5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018858C454-0x000000018858C604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UninterpretedOption other) {} // 0x000000018858CA10-0x000000018858CB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018858D240-0x000000018858D408
	}

	public sealed class SourceCodeInfo : IMessage<SourceCodeInfo>, IBufferMessage // TypeDefIndex: 52134
	{
		// Fields
		private static readonly MessageParser<SourceCodeInfo> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int LocationFieldNumber = 1; // Metadata: 0x01FD1866
		private static readonly FieldCodec<Types.Location> _repeated_location_codec; // 0x08
		private readonly RepeatedField<Types.Location> location_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SourceCodeInfo> Parser { get => default; } // 0x000000018858B4A8-0x000000018858B4F8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018858B448-0x000000018858B4A8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018858B66C-0x000000018858B6AC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Types.Location> Location { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 52132
		{
			// Nested types
			public sealed class Location : IMessage<Location>, IBufferMessage // TypeDefIndex: 52131
			{
				// Fields
				private static readonly MessageParser<Location> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				public const int PathFieldNumber = 1; // Metadata: 0x01FD1867
				private static readonly FieldCodec<int> _repeated_path_codec; // 0x08
				private readonly RepeatedField<int> path_; // 0x18
				public const int SpanFieldNumber = 2; // Metadata: 0x01FD1868
				private static readonly FieldCodec<int> _repeated_span_codec; // 0x10
				private readonly RepeatedField<int> span_; // 0x20
				public const int LeadingCommentsFieldNumber = 3; // Metadata: 0x01FD1869
				private static readonly string LeadingCommentsDefaultValue; // 0x18
				private string leadingComments_; // 0x28
				public const int TrailingCommentsFieldNumber = 4; // Metadata: 0x01FD186A
				private static readonly string TrailingCommentsDefaultValue; // 0x20
				private string trailingComments_; // 0x30
				public const int LeadingDetachedCommentsFieldNumber = 6; // Metadata: 0x01FD186B
				private static readonly FieldCodec<string> _repeated_leadingDetachedComments_codec; // 0x28
				private readonly RepeatedField<string> leadingDetachedComments_; // 0x38
	
				// Properties
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<Location> Parser { get => default; } // 0x0000000188585DB8-0x0000000188585E08 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor Descriptor { get => default; } // 0x0000000188585D04-0x0000000188585D64 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001885861A8-0x00000001885861E8 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> Path { get => default; } // 0x0000000181041090-0x00000001810410A0 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> Span { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string LeadingComments { get => default; set {} } // 0x0000000188585D64-0x0000000188585DB8 0x00000001885861E8-0x0000000188586250
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasLeadingComments { get => default; } // 0x0000000185693D38-0x0000000185693D44 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string TrailingComments { get => default; set {} } // 0x0000000188585E08-0x0000000188585E5C 0x0000000188586250-0x00000001885862B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasTrailingComments { get => default; } // 0x00000001885839D0-0x00000001885839DC 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<string> LeadingDetachedComments { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
	
				// Constructors
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Location() {} // 0x0000000188585B10-0x0000000188585C04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Location(Location other) {} // 0x0000000188585C04-0x0000000188585D04
				static Location() {} // 0x00000001885858F8-0x0000000188585B10
	
				// Methods
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Location Clone() => default; // 0x00000001885854D0-0x0000000188585530
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearLeadingComments() {} // 0x0000000188254178-0x000000018825418C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearTrailingComments() {} // 0x0000000185572920-0x0000000185572934
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other) => default; // 0x0000000188585530-0x0000000188585594
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(Location other) => default; // 0x0000000188585594-0x00000001885856CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode() => default; // 0x00000001885856CC-0x00000001885857AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString() => default; // 0x00000001885858AC-0x00000001885858F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188586034-0x00000001885861A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize() => default; // 0x0000000188585354-0x00000001885854D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(Location other) {} // 0x00000001885857AC-0x00000001885858AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188585E5C-0x0000000188586034
			}
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceCodeInfo() {} // 0x000000018858B348-0x000000018858B3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceCodeInfo(SourceCodeInfo other) {} // 0x000000018858B3C0-0x000000018858B448
		static SourceCodeInfo() {} // 0x000000018858B1D8-0x000000018858B348
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceCodeInfo Clone() => default; // 0x000000018858AFD4-0x000000018858B034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018858B0B0-0x000000018858B114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SourceCodeInfo other) => default; // 0x000000018858B034-0x000000018858B0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018517BB20-0x000000018517BB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018858B18C-0x000000018858B1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018858B5C8-0x000000018858B66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018858AF40-0x000000018858AFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SourceCodeInfo other) {} // 0x000000018858B114-0x000000018858B18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018858B4F8-0x000000018858B5C8
	}

	public sealed class GeneratedCodeInfo : IMessage<GeneratedCodeInfo>, IBufferMessage // TypeDefIndex: 52139
	{
		// Fields
		private static readonly MessageParser<GeneratedCodeInfo> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int AnnotationFieldNumber = 1; // Metadata: 0x01FD186C
		private static readonly FieldCodec<Types.Annotation> _repeated_annotation_codec; // 0x08
		private readonly RepeatedField<Types.Annotation> annotation_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GeneratedCodeInfo> Parser { get => default; } // 0x0000000188585150-0x00000001885851A0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001885850F0-0x0000000188585150 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188585314-0x0000000188585354 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Types.Annotation> Annotation { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 52137
		{
			// Nested types
			public sealed class Annotation : IMessage<Annotation>, IBufferMessage // TypeDefIndex: 52136
			{
				// Fields
				private static readonly MessageParser<Annotation> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				private int _hasBits0; // 0x18
				public const int PathFieldNumber = 1; // Metadata: 0x01FD186D
				private static readonly FieldCodec<int> _repeated_path_codec; // 0x08
				private readonly RepeatedField<int> path_; // 0x20
				public const int SourceFileFieldNumber = 2; // Metadata: 0x01FD186E
				private static readonly string SourceFileDefaultValue; // 0x10
				private string sourceFile_; // 0x28
				public const int BeginFieldNumber = 3; // Metadata: 0x01FD186F
				private static readonly int BeginDefaultValue; // 0x18
				private int begin_; // 0x30
				public const int EndFieldNumber = 4; // Metadata: 0x01FD1870
				private static readonly int EndDefaultValue; // 0x1C
				private int end_; // 0x34
	
				// Properties
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<Annotation> Parser { get => default; } // 0x000000018857BD50-0x000000018857BDA0 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor Descriptor { get => default; } // 0x000000018857BC9C-0x000000018857BCFC 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018857C06C-0x000000018857C0AC 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> Path { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string SourceFile { get => default; set {} } // 0x000000018857BDA0-0x000000018857BDF4 0x000000018857C0AC-0x000000018857C114
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasSourceFile { get => default; } // 0x0000000185693D38-0x0000000185693D44 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Begin { get => default; set {} } // 0x000000018857BC48-0x000000018857BC9C 0x0000000183D6BD00-0x0000000183D6BD10
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasBegin { get => default; } // 0x0000000182461A70-0x0000000182461A80 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int End { get => default; set {} } // 0x000000018857BCFC-0x000000018857BD50 0x0000000183D6BD10-0x0000000183D6BD20
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasEnd { get => default; } // 0x0000000188570E90-0x0000000188570E98 
	
				// Constructors
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Annotation() {} // 0x000000018857BBD0-0x000000018857BC48
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Annotation(Annotation other) {} // 0x000000018857BB24-0x000000018857BBD0
				static Annotation() {} // 0x000000018857B980-0x000000018857BB24
	
				// Methods
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Annotation Clone() => default; // 0x000000018857B620-0x000000018857B680
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearSourceFile() {} // 0x0000000188254178-0x000000018825418C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearBegin() {} // 0x0000000183D4F650-0x0000000183D4F660
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearEnd() {} // 0x0000000183D6BC50-0x0000000183D6BC60
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other) => default; // 0x000000018857B76C-0x000000018857B7D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(Annotation other) => default; // 0x000000018857B680-0x000000018857B76C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode() => default; // 0x000000018857B7D0-0x000000018857B868
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString() => default; // 0x000000018857B934-0x000000018857B980
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018857BF44-0x000000018857C06C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize() => default; // 0x000000018857B4EC-0x000000018857B620
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(Annotation other) {} // 0x000000018857B868-0x000000018857B934
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018857BDF4-0x000000018857BF44
			}
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GeneratedCodeInfo() {} // 0x0000000188585078-0x00000001885850F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GeneratedCodeInfo(GeneratedCodeInfo other) {} // 0x0000000188584FF0-0x0000000188585078
		static GeneratedCodeInfo() {} // 0x0000000188584E80-0x0000000188584FF0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GeneratedCodeInfo Clone() => default; // 0x0000000188584C7C-0x0000000188584CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188584CDC-0x0000000188584D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GeneratedCodeInfo other) => default; // 0x0000000188584D40-0x0000000188584DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018517BB20-0x000000018517BB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188584E34-0x0000000188584E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188585270-0x0000000188585314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188584BE8-0x0000000188584C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GeneratedCodeInfo other) {} // 0x0000000188584DBC-0x0000000188584E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001885851A0-0x0000000188585270
	}

	public abstract class DescriptorBase : IDescriptor // TypeDefIndex: 52140
	{
		// Properties
		public int Index { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public abstract string Name { get; }
		public string FullName { get; } // 0x0000000181041090-0x00000001810410A0 
		public FileDescriptor File { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public DescriptorDeclaration Declaration { get; } // 0x000000018857C144-0x000000018857C16C 
	
		// Constructors
		protected DescriptorBase() {} // Dummy constructor
		internal DescriptorBase(FileDescriptor file, string fullName, int index) {} // 0x000000018857C114-0x000000018857C144
	
		// Methods
		internal virtual IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) => default; // 0x0000000181002730-0x0000000181002740
	}

	public sealed class DescriptorDeclaration // TypeDefIndex: 52141
	{
		// Properties
		public IDescriptor Descriptor { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public int StartLine { get; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public int StartColumn { get; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 
		public int EndLine { get; } // 0x0000000181003B50-0x0000000181003B60 
		public int EndColumn { get; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public string LeadingComments { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public string TrailingComments { get; } // 0x0000000181003830-0x0000000181003840 
		public IReadOnlyList<string> LeadingDetachedComments { get; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
	
		// Constructors
		public DescriptorDeclaration() {} // Dummy constructor
		private DescriptorDeclaration(IDescriptor descriptor, SourceCodeInfo.Types.Location location) {} // 0x000000018857C1DC-0x000000018857C37C
	
		// Methods
		internal static DescriptorDeclaration FromProto(IDescriptor descriptor, SourceCodeInfo.Types.Location location) => default; // 0x000000018857C16C-0x000000018857C1DC
	}

	internal sealed class DescriptorPool // TypeDefIndex: 52142
	{
		// Fields
		private readonly IDictionary<string, IDescriptor> descriptorsByName; // 0x10
		private readonly IDictionary<ObjectIntPair<IDescriptor>, FieldDescriptor> fieldsByNumber; // 0x18
		private readonly IDictionary<ObjectIntPair<IDescriptor>, EnumValueDescriptor> enumValuesByNumber; // 0x20
		private readonly HashSet<FileDescriptor> dependencies; // 0x28
		private static readonly Regex ValidationRegex; // 0x00
	
		// Constructors
		public DescriptorPool() {} // Dummy constructor
		internal DescriptorPool(IEnumerable<FileDescriptor> dependencyFiles) {} // 0x000000018857D3AC-0x000000018857D75C
		static DescriptorPool() {} // 0x000000018857D2E8-0x000000018857D3AC
	
		// Methods
		private void ImportPublicDependencies(FileDescriptor file) {} // 0x000000018857CD24-0x000000018857CE98
		internal T FindSymbol<T>(string fullName)
			where T : class => default;
		internal void AddPackage(string fullName, FileDescriptor file) {} // 0x000000018857C678-0x000000018857C8E0
		internal void AddSymbol(IDescriptor descriptor) {} // 0x000000018857C8E0-0x000000018857CBDC
		private static void ValidateSymbolName(IDescriptor descriptor) {} // 0x000000018857D158-0x000000018857D2E8
		internal FieldDescriptor FindFieldByNumber(MessageDescriptor messageDescriptor, int number) => default; // 0x000000018857CC80-0x000000018857CD24
		internal EnumValueDescriptor FindEnumValueByNumber(EnumDescriptor enumDescriptor, int number) => default; // 0x000000018857CBDC-0x000000018857CC80
		internal void AddFieldByNumber(FieldDescriptor field) {} // 0x000000018857C440-0x000000018857C678
		internal void AddEnumValueByNumber(EnumValueDescriptor enumValue) {} // 0x000000018857C37C-0x000000018857C440
		internal IDescriptor LookupSymbol(string name, IDescriptor relativeTo) => default; // 0x000000018857CE98-0x000000018857D158
	}

	internal static class DescriptorUtil // TypeDefIndex: 52144
	{
		// Nested types
		internal delegate TOutput IndexedConverter<TInput, TOutput>(TInput element, int index); // TypeDefIndex: 52143; 0x00000000-0x00000000
	
		// Methods
		internal static IList<TOutput> ConvertAndMakeReadOnly<TInput, TOutput>(IList<TInput> input, IndexedConverter<TInput, TOutput> converter) => default;
	}

	public sealed class DescriptorValidationException : Exception // TypeDefIndex: 52145
	{
		// Fields
		private readonly string name; // 0x90
		private readonly string description; // 0x98
	
		// Properties
		public string ProblemSymbolName { get => default; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
		public string Description { get => default; } // 0x00000001811AC510-0x00000001811AC520 
	
		// Constructors
		public DescriptorValidationException() {} // Dummy constructor
		internal DescriptorValidationException(IDescriptor problemDescriptor, string description) {} // 0x000000018857D75C-0x000000018857D828
		internal DescriptorValidationException(IDescriptor problemDescriptor, string description, Exception cause) {} // 0x000000018857D828-0x000000018857D908
	}

	public sealed class EnumDescriptor : DescriptorBase // TypeDefIndex: 52147
	{
		// Fields
		private readonly EnumDescriptorProto proto; // 0x28
		private readonly MessageDescriptor containingType; // 0x30
		private readonly IList<EnumValueDescriptor> values; // 0x38
		private readonly System.Type clrType; // 0x40
	
		// Properties
		internal EnumDescriptorProto Proto { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public override string Name { get => default; } // 0x000000018857DCFC-0x000000018857DD1C 
		public System.Type ClrType { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public MessageDescriptor ContainingType { get => default; } // 0x0000000181003830-0x0000000181003840 
		public IList<EnumValueDescriptor> Values { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions() method.")]
		public CustomOptions CustomOptions { get => default; } // 0x000000018857DC6C-0x000000018857DCFC 
	
		// Constructors
		public EnumDescriptor() {} // Dummy constructor
		internal EnumDescriptor(EnumDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, System.Type clrType) {} // 0x000000018857DA60-0x000000018857DC6C
	
		// Methods
		public EnumDescriptorProto ToProto() => default; // 0x000000018857DA40-0x000000018857DA60
		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) => default; // 0x000000018857D9C4-0x000000018857DA14
		public EnumValueDescriptor FindValueByNumber(int number) => default; // 0x000000018857D994-0x000000018857D9C4
		public EnumValueDescriptor FindValueByName(string name) => default; // 0x000000018857D908-0x000000018857D994
		public EnumOptions GetOptions() => default; // 0x000000018857DA14-0x000000018857DA40
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<EnumOptions, T> extension) => default;
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<EnumOptions, T> extension) => default;
	}

	public sealed class EnumValueDescriptor : DescriptorBase // TypeDefIndex: 52148
	{
		// Fields
		private readonly EnumDescriptor enumDescriptor; // 0x28
		private readonly EnumValueDescriptorProto proto; // 0x30
	
		// Properties
		internal EnumValueDescriptorProto Proto { get => default; } // 0x0000000181003830-0x0000000181003840 
		public override string Name { get => default; } // 0x000000018857F9E8-0x000000018857FA08 
		public int Number { get => default; } // 0x000000018857FA08-0x000000018857FA28 
		public EnumDescriptor EnumDescriptor { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions() method.")]
		public CustomOptions CustomOptions { get => default; } // 0x000000018857F958-0x000000018857F9E8 
	
		// Constructors
		public EnumValueDescriptor() {} // Dummy constructor
		internal EnumValueDescriptor(EnumValueDescriptorProto proto, FileDescriptor file, EnumDescriptor parent, int index) {} // 0x000000018857F860-0x000000018857F958
	
		// Methods
		public EnumValueDescriptorProto ToProto() => default; // 0x000000018857F840-0x000000018857F860
		public EnumValueOptions GetOptions() => default; // 0x000000018857F814-0x000000018857F840
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<EnumValueOptions, T> extension) => default;
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<EnumValueOptions, T> extension) => default;
	}

	internal sealed class ExtensionAccessor : IFieldAccessor // TypeDefIndex: 52149
	{
		// Fields
		private readonly Google.Protobuf.Extension extension; // 0x10
		private readonly ReflectionUtil.IExtensionReflectionHelper helper; // 0x18
	
		// Properties
		public FieldDescriptor Descriptor { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public ExtensionAccessor() {} // Dummy constructor
		internal ExtensionAccessor(FieldDescriptor descriptor) {} // 0x00000001885805D0-0x0000000188580658
	
		// Methods
		public void Clear(IMessage message) {} // 0x000000018858041C-0x00000001885804A4
		public bool HasValue(IMessage message) => default; // 0x000000018858052C-0x00000001885805B4
		public object GetValue(IMessage message) => default; // 0x00000001885804A4-0x000000018858052C
		public void SetValue(IMessage message, object value) {} // 0x00000001885805B4-0x00000001885805D0
	}

	public sealed class ExtensionCollection // TypeDefIndex: 52153
	{
		// Fields
		private IDictionary<MessageDescriptor, IList<FieldDescriptor>> extensionsByTypeInDeclarationOrder; // 0x10
		private IDictionary<MessageDescriptor, IList<FieldDescriptor>> extensionsByTypeInNumberOrder; // 0x18
	
		// Properties
		public IList<FieldDescriptor> UnorderedExtensions { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public ExtensionCollection() {} // Dummy constructor
		internal ExtensionCollection(FileDescriptor file, Google.Protobuf.Extension[] extensions) {} // 0x0000000188581158-0x0000000188581260
		internal ExtensionCollection(MessageDescriptor message, Google.Protobuf.Extension[] extensions) {} // 0x0000000188581050-0x0000000188581158
	
		// Methods
		public IList<FieldDescriptor> GetExtensionsInDeclarationOrder(MessageDescriptor descriptor) => default; // 0x0000000188580FB0-0x0000000188581000
		public IList<FieldDescriptor> GetExtensionsInNumberOrder(MessageDescriptor descriptor) => default; // 0x0000000188581000-0x0000000188581050
		internal void CrossLink() {} // 0x0000000188580658-0x0000000188580FB0
	}

	internal abstract class FieldAccessorBase : IFieldAccessor // TypeDefIndex: 52154
	{
		// Fields
		private readonly Func<IMessage, object> getValueDelegate; // 0x10
		private readonly FieldDescriptor descriptor; // 0x18
	
		// Properties
		public FieldDescriptor Descriptor { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		protected FieldAccessorBase() {} // Dummy constructor
		internal FieldAccessorBase(PropertyInfo property, FieldDescriptor descriptor) {} // 0x000000018858E0F8-0x000000018858E184
	
		// Methods
		public object GetValue(IMessage message) => default; // 0x000000018858E0D8-0x000000018858E0F8
		public abstract bool HasValue(IMessage message);
		public abstract void Clear(IMessage message);
		public abstract void SetValue(IMessage message, object value);
	}

	public sealed class FieldDescriptor : DescriptorBase, IComparable<FieldDescriptor> // TypeDefIndex: 52155
	{
		// Fields
		private EnumDescriptor enumType; // 0x28
		private MessageDescriptor extendeeType; // 0x30
		private MessageDescriptor messageType; // 0x38
		private Google.Protobuf.Reflection.FieldType fieldType; // 0x40
		private IFieldAccessor accessor; // 0x48
	
		// Properties
		public MessageDescriptor ContainingType { get; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public OneofDescriptor ContainingOneof { get; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		public OneofDescriptor RealContainingOneof { get => default; } // 0x000000018858F2E4-0x000000018858F2F8 
		public string JsonName { get; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public string PropertyName { get; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
		public bool HasPresence { get => default; } // 0x000000018858F0DC-0x000000018858F148 
		internal FieldDescriptorProto Proto { get; } // 0x0000000183D4EB30-0x0000000183D4EB40 
		public Google.Protobuf.Extension Extension { get; } // 0x0000000183D4EB20-0x0000000183D4EB30 
		public override string Name { get => default; } // 0x000000018858F2C4-0x000000018858F2E4 
		public IFieldAccessor Accessor { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public bool IsRepeated { get => default; } // 0x000000018858F204-0x000000018858F22C 
		public bool IsRequired { get => default; } // 0x000000018858F22C-0x000000018858F254 
		public bool IsMap { get => default; } // 0x000000018858F168-0x000000018858F1A8 
		public bool IsPacked { get => default; } // 0x000000018858F1A8-0x000000018858F204 
		public bool IsExtension { get => default; } // 0x000000018858F148-0x000000018858F168 
		public Google.Protobuf.Reflection.FieldType FieldType { get => default; } // 0x0000000183D4ED80-0x0000000183D4ED90 
		public int FieldNumber { get => default; } // 0x000000018858F0BC-0x000000018858F0DC 
		public EnumDescriptor EnumType { get => default; } // 0x000000018858EFDC-0x000000018858F048 
		public MessageDescriptor MessageType { get => default; } // 0x000000018858F254-0x000000018858F2C4 
		public MessageDescriptor ExtendeeType { get => default; } // 0x000000018858F048-0x000000018858F0BC 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions() method.")]
		public CustomOptions CustomOptions { get => default; } // 0x000000018858EF4C-0x000000018858EFDC 
	
		// Constructors
		public FieldDescriptor() {} // Dummy constructor
		internal FieldDescriptor(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string propertyName, Google.Protobuf.Extension extension) {} // 0x000000018858EC34-0x000000018858EF4C
	
		// Methods
		public FieldDescriptorProto ToProto() => default; // 0x000000018858EC14-0x000000018858EC34
		private static Google.Protobuf.Reflection.FieldType GetFieldTypeFromProtoType(FieldDescriptorProto.Types.Type type) => default; // 0x000000018858EA80-0x000000018858EBE8
		public int CompareTo(FieldDescriptor other) => default; // 0x000000018858E274-0x000000018858E308
		public Google.Protobuf.Reflection.FieldOptions GetOptions() => default; // 0x000000018858EBE8-0x000000018858EC14
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<Google.Protobuf.Reflection.FieldOptions, T> extension) => default;
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<Google.Protobuf.Reflection.FieldOptions, T> extension) => default;
		internal void CrossLink() {} // 0x000000018858E50C-0x000000018858EA80
		private IFieldAccessor CreateAccessor() => default; // 0x000000018858E308-0x000000018858E50C
	}

	public enum FieldType // TypeDefIndex: 52156
	{
		Double = 0,
		Float = 1,
		Int64 = 2,
		UInt64 = 3,
		Int32 = 4,
		Fixed64 = 5,
		Fixed32 = 6,
		Bool = 7,
		String = 8,
		Group = 9,
		Message = 10,
		Bytes = 11,
		UInt32 = 12,
		SFixed32 = 13,
		SFixed64 = 14,
		SInt32 = 15,
		SInt64 = 16,
		Enum = 17
	}

	public enum Syntax // TypeDefIndex: 52157
	{
		Proto2 = 0,
		Proto3 = 1,
		Unknown = 2
	}

	public sealed class FileDescriptor : IDescriptor // TypeDefIndex: 52160
	{
		// Fields
		private readonly Lazy<Dictionary<IDescriptor, DescriptorDeclaration>> declarations; // 0x10
	
		// Properties
		internal FileDescriptorProto Proto { get; } // 0x0000000181041090-0x00000001810410A0 
		public Google.Protobuf.Reflection.Syntax Syntax { get; } // 0x0000000181003B50-0x0000000181003B60 
		public string Name { get => default; } // 0x0000000188591B10-0x0000000188591B30 
		public string Package { get => default; } // 0x0000000188591B30-0x0000000188591B50 
		public IList<MessageDescriptor> MessageTypes { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public IList<EnumDescriptor> EnumTypes { get; } // 0x0000000181003830-0x0000000181003840 
		public IList<ServiceDescriptor> Services { get; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public ExtensionCollection Extensions { get; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public IList<FileDescriptor> Dependencies { get; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public IList<FileDescriptor> PublicDependencies { get; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public ByteString SerializedData { get; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		string IDescriptor.FullName { get => default; } // 0x00000001885914E4-0x00000001885914EC 
		FileDescriptor IDescriptor.File { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		internal DescriptorPool DescriptorPool { get; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public static FileDescriptor DescriptorProtoFileDescriptor { get => default; } // 0x0000000188591AD0-0x0000000188591B10 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions() method.")]
		public CustomOptions CustomOptions { get => default; } // 0x0000000188591A40-0x0000000188591AD0 
	
		// Constructors
		public FileDescriptor() {} // Dummy constructor
		static FileDescriptor() {} // 0x0000000188591554-0x00000001885915E4
		private FileDescriptor(ByteString descriptorData, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, DescriptorPool pool, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo) {} // 0x00000001885915E4-0x0000000188591A40
	
		// Methods
		private Dictionary<IDescriptor, DescriptorDeclaration> CreateDeclarationMap() => default; // 0x000000018858FE74-0x0000000188590088
		private IDescriptor FindDescriptorForPath(IList<int> path) => default; // 0x000000018859062C-0x0000000188590788
		private DescriptorBase GetDescriptorFromList(IReadOnlyList<DescriptorBase> list, int index) => default; // 0x000000018859138C-0x0000000188591450
		private IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) => default; // 0x0000000188591450-0x00000001885914B8
		internal DescriptorDeclaration GetDeclaration(IDescriptor descriptor) => default; // 0x0000000188591304-0x000000018859138C
		internal string ComputeFullName(MessageDescriptor parent, string name) => default; // 0x000000018858FDE4-0x000000018858FE74
		private static IList<FileDescriptor> DeterminePublicDependencies(FileDescriptor @this, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, bool allowUnknownDependencies) => default; // 0x00000001885902D8-0x000000018859062C
		public FileDescriptorProto ToProto() => default; // 0x00000001885914EC-0x000000018859150C
		public T FindTypeByName<T>(string name)
			where T : class, IDescriptor => default;
		private static FileDescriptor BuildFrom(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo) => default; // 0x000000018858FC5C-0x000000018858FDE4
		private void CrossLink() {} // 0x0000000188590088-0x00000001885902D8
		public static FileDescriptor FromGeneratedCode(byte[] descriptorData, FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedCodeInfo) => default; // 0x0000000188590788-0x0000000188590AA4
		private static IEnumerable<Google.Protobuf.Extension> GetAllExtensions(FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedInfo) => default; // 0x000000018859103C-0x0000000188591160
		private static IEnumerable<Google.Protobuf.Extension> GetAllGeneratedExtensions(GeneratedClrTypeInfo generated) => default; // 0x0000000188591160-0x0000000188591304
		private static IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensions(FileDescriptor descriptor) => default; // 0x0000000188590D24-0x000000018859103C
		private static IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensionsFromMessage(MessageDescriptor descriptor) => default; // 0x0000000188590AA4-0x0000000188590D24
		public static IReadOnlyList<FileDescriptor> BuildFromByteStrings(IEnumerable<ByteString> descriptorData, ExtensionRegistry registry) => default; // 0x000000018858F344-0x000000018858FC5C
		public static IReadOnlyList<FileDescriptor> BuildFromByteStrings(IEnumerable<ByteString> descriptorData) => default; // 0x000000018858F2F8-0x000000018858F344
		public override string ToString() => default; // 0x000000018859150C-0x0000000188591554
		public Google.Protobuf.Reflection.FileOptions GetOptions() => default; // 0x00000001885914B8-0x00000001885914E4
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<Google.Protobuf.Reflection.FileOptions, T> extension) => default;
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<Google.Protobuf.Reflection.FileOptions, T> extension) => default;
		public static void ForceReflectionInitialization<T>() {}
	}

	public sealed class GeneratedClrTypeInfo // TypeDefIndex: 52161
	{
		// Fields
		private static readonly string[] EmptyNames; // 0x00
		private static readonly GeneratedClrTypeInfo[] EmptyCodeInfo; // 0x08
		private static readonly Google.Protobuf.Extension[] EmptyExtensions; // 0x10
		internal const DynamicallyAccessedMemberTypes MessageAccessibility = DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties; // Metadata: 0x01FD1886
	
		// Properties
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public System.Type ClrType { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public MessageParser Parser { get; } // 0x0000000181041090-0x00000001810410A0 
		public string[] PropertyNames { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public Google.Protobuf.Extension[] Extensions { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public string[] OneofNames { get; } // 0x0000000181003830-0x0000000181003840 
		public GeneratedClrTypeInfo[] NestedTypes { get; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public System.Type[] NestedEnums { get; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
	
		// Constructors
		public GeneratedClrTypeInfo() {} // Dummy constructor
		public GeneratedClrTypeInfo([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type clrType, MessageParser parser, string[] propertyNames, string[] oneofNames, System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, GeneratedClrTypeInfo[] nestedTypes) {} // 0x0000000188591C64-0x0000000188591DE8
		public GeneratedClrTypeInfo([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type clrType, MessageParser parser, string[] propertyNames, string[] oneofNames, System.Type[] nestedEnums, GeneratedClrTypeInfo[] nestedTypes) {} // 0x0000000188591E1C-0x0000000188591E60
		public GeneratedClrTypeInfo(System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, GeneratedClrTypeInfo[] nestedTypes) {} // 0x0000000188591DE8-0x0000000188591E1C
		public GeneratedClrTypeInfo(System.Type[] nestedEnums, GeneratedClrTypeInfo[] nestedTypes) {} // 0x0000000188591C38-0x0000000188591C64
		static GeneratedClrTypeInfo() {} // 0x0000000188591B50-0x0000000188591C38
	}

	public interface IDescriptor // TypeDefIndex: 52162
	{
		// Properties
		string Name { get; }
		string FullName { get; }
		FileDescriptor File { get; }
	}

	public interface IFieldAccessor // TypeDefIndex: 52163
	{
		// Properties
		FieldDescriptor Descriptor { get; }
	
		// Methods
		void Clear(IMessage message);
		object GetValue(IMessage message);
		bool HasValue(IMessage message);
		void SetValue(IMessage message, object value);
	}

	internal sealed class MapFieldAccessor : FieldAccessorBase // TypeDefIndex: 52164
	{
		// Constructors
		public MapFieldAccessor() {} // Dummy constructor
		internal MapFieldAccessor(PropertyInfo property, FieldDescriptor descriptor) {} // 0x0000000188591F94-0x0000000188591F9C
	
		// Methods
		public override void Clear(IMessage message) {} // 0x0000000188591E60-0x0000000188591EDC
		public override bool HasValue(IMessage message) => default; // 0x0000000188591EDC-0x0000000188591F38
		public override void SetValue(IMessage message, object value) {} // 0x0000000188591F38-0x0000000188591F94
	}

	public sealed class MessageDescriptor : DescriptorBase // TypeDefIndex: 52168
	{
		// Fields
		private static readonly HashSet<string> WellKnownTypeNames; // 0x00
		private readonly IList<FieldDescriptor> fieldsInDeclarationOrder; // 0x28
		private readonly IList<FieldDescriptor> fieldsInNumberOrder; // 0x30
		private readonly IDictionary<string, FieldDescriptor> jsonFieldMap; // 0x38
		private Func<IMessage, bool> extensionSetIsInitialized; // 0x40
	
		// Properties
		public override string Name { get => default; } // 0x0000000188593AB0-0x0000000188593AD0 
		internal DescriptorProto Proto { get; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public System.Type ClrType { get; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public MessageParser Parser { get; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		internal bool IsWellKnownType { get => default; } // 0x0000000188593964-0x0000000188593A24 
		internal bool IsWrapperType { get => default; } // 0x0000000188593A24-0x0000000188593AB0 
		public MessageDescriptor ContainingType { get; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public FieldCollection Fields { get; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
		public ExtensionCollection Extensions { get; } // 0x0000000183D4EB30-0x0000000183D4EB40 
		public IList<MessageDescriptor> NestedTypes { get; } // 0x0000000183D4EB20-0x0000000183D4EB30 
		public IList<EnumDescriptor> EnumTypes { get; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 
		public IList<OneofDescriptor> Oneofs { get; } // 0x0000000183D4EA60-0x0000000183D4EA70 
		public int RealOneofCount { get; } // 0x0000000183D4FB60-0x0000000183D4FB70 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions() method.")]
		public CustomOptions CustomOptions { get => default; } // 0x00000001885938D4-0x0000000188593964 
	
		// Nested types
		public sealed class FieldCollection // TypeDefIndex: 52165
		{
			// Fields
			private readonly MessageDescriptor messageDescriptor; // 0x10
	
			// Properties
			public FieldDescriptor this[int number] { get => default; } // 0x000000018858E184-0x000000018858E1FC 
			public FieldDescriptor this[string name] { get => default; } // 0x000000018858E1FC-0x000000018858E274 
	
			// Constructors
			public FieldCollection() {} // Dummy constructor
			internal FieldCollection(MessageDescriptor messageDescriptor) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public IList<FieldDescriptor> InDeclarationOrder() => default; // 0x00000001856B1D28-0x00000001856B1D44
			public IList<FieldDescriptor> InFieldNumberOrder() => default; // 0x00000001856B1D0C-0x00000001856B1D28
			internal IDictionary<string, FieldDescriptor> ByJsonName() => default; // 0x0000000186191144-0x0000000186191160
		}
	
		// Constructors
		public MessageDescriptor() {} // Dummy constructor
		internal MessageDescriptor(DescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int typeIndex, GeneratedClrTypeInfo generatedCodeInfo) {} // 0x0000000188592A90-0x00000001885938D4
		static MessageDescriptor() {} // 0x00000001885928A0-0x0000000188592A90
	
		// Methods
		private static ReadOnlyDictionary<string, FieldDescriptor> CreateJsonFieldMap(IList<FieldDescriptor> fields) => default; // 0x0000000188591F9C-0x0000000188592328
		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) => default; // 0x0000000188592734-0x00000001885927A0
		public DescriptorProto ToProto() => default; // 0x0000000188592880-0x00000001885928A0
		internal bool IsExtensionsInitialized(IMessage message) => default; // 0x00000001885927CC-0x0000000188592880
		public FieldDescriptor FindFieldByName(string name) => default; // 0x0000000188592678-0x0000000188592704
		public FieldDescriptor FindFieldByNumber(int number) => default; // 0x0000000188592704-0x0000000188592734
		public T FindDescriptor<T>(string name)
			where T : class, IDescriptor => default;
		public MessageOptions GetOptions() => default; // 0x00000001885927A0-0x00000001885927CC
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<MessageOptions, T> extension) => default;
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<MessageOptions, T> extension) => default;
		internal void CrossLink() {} // 0x0000000188592328-0x0000000188592678
	}

	public sealed class MethodDescriptor : DescriptorBase // TypeDefIndex: 52169
	{
		// Fields
		private readonly MethodDescriptorProto proto; // 0x28
		private readonly ServiceDescriptor service; // 0x30
		private MessageDescriptor inputType; // 0x38
		private MessageDescriptor outputType; // 0x40
	
		// Properties
		public ServiceDescriptor Service { get => default; } // 0x0000000181003830-0x0000000181003840 
		public MessageDescriptor InputType { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public MessageDescriptor OutputType { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public bool IsClientStreaming { get => default; } // 0x0000000188593ED8-0x0000000188593EF8 
		public bool IsServerStreaming { get => default; } // 0x0000000188593EF8-0x0000000188593F18 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions() method.")]
		public CustomOptions CustomOptions { get => default; } // 0x0000000188593E48-0x0000000188593ED8 
		internal MethodDescriptorProto Proto { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public override string Name { get => default; } // 0x0000000188593F18-0x0000000188593F38 
	
		// Constructors
		public MethodDescriptor() {} // Dummy constructor
		internal MethodDescriptor(MethodDescriptorProto proto, FileDescriptor file, ServiceDescriptor parent, int index) {} // 0x0000000188593D64-0x0000000188593E48
	
		// Methods
		public MethodOptions GetOptions() => default; // 0x0000000188593D18-0x0000000188593D44
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<MethodOptions, T> extension) => default;
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<MethodOptions, T> extension) => default;
		public MethodDescriptorProto ToProto() => default; // 0x0000000188593D44-0x0000000188593D64
		internal void CrossLink() {} // 0x0000000188593AD0-0x0000000188593D18
	}

	public sealed class OneofAccessor // TypeDefIndex: 52171
	{
		// Fields
		private readonly Func<IMessage, int> caseDelegate; // 0x10
		private readonly Action<IMessage> clearDelegate; // 0x18
	
		// Properties
		public OneofDescriptor Descriptor { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public OneofAccessor() {} // Dummy constructor
		private OneofAccessor(OneofDescriptor descriptor, Func<IMessage, int> caseDelegate, Action<IMessage> clearDelegate) {} // 0x00000001885941A8-0x00000001885941E0
	
		// Methods
		internal static OneofAccessor ForRegularOneof(OneofDescriptor descriptor, PropertyInfo caseProperty, MethodInfo clearMethod) => default; // 0x0000000188593F58-0x0000000188594020
		internal static OneofAccessor ForSyntheticOneof(OneofDescriptor descriptor) => default; // 0x0000000188594020-0x0000000188594158
		public void Clear(IMessage message) {} // 0x0000000188593F38-0x0000000188593F58
		public FieldDescriptor GetCaseFieldDescriptor(IMessage message) => default; // 0x0000000188594158-0x00000001885941A8
	}

	public sealed class OneofDescriptor : DescriptorBase // TypeDefIndex: 52173
	{
		// Fields
		private MessageDescriptor containingType; // 0x28
		private IList<FieldDescriptor> fields; // 0x30
		private readonly OneofAccessor accessor; // 0x38
	
		// Properties
		public override string Name { get => default; } // 0x0000000188594AD4-0x0000000188594AF4 
		internal OneofDescriptorProto Proto { get; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public MessageDescriptor ContainingType { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public IList<FieldDescriptor> Fields { get => default; } // 0x0000000181003830-0x0000000181003840 
		public bool IsSynthetic { get; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 
		public OneofAccessor Accessor { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions method.")]
		public CustomOptions CustomOptions { get => default; } // 0x0000000188594A44-0x0000000188594AD4 
	
		// Constructors
		public OneofDescriptor() {} // Dummy constructor
		internal OneofDescriptor(OneofDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string clrName) {} // 0x00000001885948A4-0x0000000188594A44
	
		// Methods
		public OneofDescriptorProto ToProto() => default; // 0x0000000188594884-0x00000001885948A4
		public OneofOptions GetOptions() => default; // 0x0000000188594858-0x0000000188594884
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<OneofOptions, T> extension) => default;
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<OneofOptions, T> extension) => default;
		internal void CrossLink() {} // 0x0000000188594484-0x0000000188594858
		private OneofAccessor CreateAccessor(string clrName) => default; // 0x00000001885941E0-0x0000000188594484
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class OriginalNameAttribute : Attribute // TypeDefIndex: 52174
	{
		// Properties
		public string Name { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public bool PreferredAlias { get; set; } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
	
		// Constructors
		public OriginalNameAttribute() {} // Dummy constructor
		public OriginalNameAttribute(string name) {} // 0x00000001823C46A0-0x00000001823C4710
	}

	internal sealed class PackageDescriptor : IDescriptor // TypeDefIndex: 52175
	{
		// Fields
		private readonly string name; // 0x10
		private readonly string fullName; // 0x18
		private readonly FileDescriptor file; // 0x20
	
		// Properties
		public string Name { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public string FullName { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public FileDescriptor File { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public PackageDescriptor() {} // Dummy constructor
		internal PackageDescriptor(string name, string fullName, FileDescriptor file) {} // 0x0000000188594AF4-0x0000000188594B30
	}

	public static class ReflectionUtil // TypeDefIndex: 52190
	{
		// Fields
		internal static readonly System.Type[] EmptyTypes; // 0x00
	
		// Properties
		private static bool CanConvertEnumFuncToInt32Func { get; } // 0x00000001885958F4-0x0000000188595944 
	
		// Nested types
		private interface IReflectionHelper // TypeDefIndex: 52176
		{
			// Methods
			Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method);
			Action<IMessage> CreateActionIMessage(MethodInfo method);
			Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method);
			Action<IMessage, object> CreateActionIMessageObject(MethodInfo method);
			Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method);
		}
	
		internal interface IExtensionReflectionHelper // TypeDefIndex: 52177
		{
			// Methods
			object GetExtension(IMessage message);
			void SetExtension(IMessage message, object value);
			bool HasExtension(IMessage message);
			void ClearExtension(IMessage message);
		}
	
		private interface IExtensionSetReflector // TypeDefIndex: 52178
		{
			// Methods
			Func<IMessage, bool> CreateIsInitializedCaller();
		}
	
		private class ReflectionHelper<T1, T2> : IReflectionHelper // TypeDefIndex: 52185
		{
			// Constructors
			public ReflectionHelper() {}
	
			// Methods
			public Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method) => default;
			public Action<IMessage> CreateActionIMessage(MethodInfo method) => default;
			public Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method) => default;
			public Action<IMessage, object> CreateActionIMessageObject(MethodInfo method) => default;
			public Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method) => default;
		}
	
		public class ExtensionReflectionHelper<T1, T3> : IExtensionReflectionHelper // TypeDefIndex: 52186
			where T1 : IExtendableMessage<T1>
		{
			// Fields
			private readonly Google.Protobuf.Extension extension;
	
			// Constructors
			public ExtensionReflectionHelper() {} // Dummy constructor
			public ExtensionReflectionHelper(Google.Protobuf.Extension extension) {}
	
			// Methods
			public object GetExtension(IMessage message) => default;
			public bool HasExtension(IMessage message) => default;
			public void SetExtension(IMessage message, object value) {}
			public void ClearExtension(IMessage message) {}
		}
	
		private class ExtensionSetReflector<T1> : IExtensionSetReflector // TypeDefIndex: 52188
			where T1 : IExtendableMessage<T1>
		{
			// Constructors
			public ExtensionSetReflector() {}
	
			// Methods
			public Func<IMessage, bool> CreateIsInitializedCaller() => default;
		}
	
		public enum SampleEnum // TypeDefIndex: 52189
		{
			X = 0
		}
	
		// Constructors
		static ReflectionUtil() {} // 0x00000001885956F4-0x00000001885958F4
	
		// Methods
		internal static void ForceInitialize<T>() {}
		internal static Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method) => default; // 0x00000001885953B4-0x0000000188595498
		internal static Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method) => default; // 0x00000001885952D0-0x00000001885953B4
		internal static Action<IMessage, object> CreateActionIMessageObject(MethodInfo method) => default; // 0x0000000188594E3C-0x0000000188594F40
		internal static Action<IMessage> CreateActionIMessage(MethodInfo method) => default; // 0x0000000188594F40-0x000000018859504C
		internal static Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method) => default; // 0x00000001885951EC-0x00000001885952D0
		[UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Type parameter members are preserved with DynamicallyAccessedMembers on GeneratedClrTypeInfo.ctor clrType parameter.")]
		internal static Func<IMessage, bool> CreateIsInitializedCaller([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type msg) => default; // 0x0000000188595498-0x00000001885955E8
		[UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Type parameter members are preserved with DynamicallyAccessedMembers on GeneratedClrTypeInfo.ctor clrType parameter.")]
		internal static IExtensionReflectionHelper CreateExtensionHelper(Google.Protobuf.Extension extension) => default; // 0x000000018859504C-0x00000001885951EC
		[UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Type parameter members are preserved with DynamicallyAccessedMembers on GeneratedClrTypeInfo.ctor clrType parameter.")]
		private static IReflectionHelper GetReflectionHelper(System.Type t1, System.Type t2) => default; // 0x00000001885955E8-0x00000001885956F4
		private static bool CheckCanConvertEnumFuncToInt32Func() => default; // 0x0000000188594D10-0x0000000188594E3C
		public static SampleEnum SampleEnumMethod() => default; // 0x0000000181002730-0x0000000181002740
	}

	internal sealed class RepeatedFieldAccessor : FieldAccessorBase // TypeDefIndex: 52191
	{
		// Constructors
		public RepeatedFieldAccessor() {} // Dummy constructor
		internal RepeatedFieldAccessor(PropertyInfo property, FieldDescriptor descriptor) {} // 0x0000000188591F94-0x0000000188591F9C
	
		// Methods
		public override void Clear(IMessage message) {} // 0x0000000188595944-0x00000001885959C0
		public override bool HasValue(IMessage message) => default; // 0x00000001885959C0-0x0000000188595A1C
		public override void SetValue(IMessage message, object value) {} // 0x0000000188595A1C-0x0000000188595A78
	}

	public sealed class ServiceDescriptor : DescriptorBase // TypeDefIndex: 52193
	{
		// Fields
		private readonly ServiceDescriptorProto proto; // 0x28
		private readonly IList<MethodDescriptor> methods; // 0x30
	
		// Properties
		public override string Name { get => default; } // 0x0000000188595EC4-0x0000000188595EE4 
		internal ServiceDescriptorProto Proto { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public IList<MethodDescriptor> Methods { get => default; } // 0x0000000181003830-0x0000000181003840 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions() method.")]
		public CustomOptions CustomOptions { get => default; } // 0x0000000188595E34-0x0000000188595EC4 
	
		// Constructors
		public ServiceDescriptor() {} // Dummy constructor
		internal ServiceDescriptor(ServiceDescriptorProto proto, FileDescriptor file, int index) {} // 0x0000000188595CC0-0x0000000188595E34
	
		// Methods
		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) => default; // 0x0000000188595C24-0x0000000188595C74
		public ServiceDescriptorProto ToProto() => default; // 0x0000000188595CA0-0x0000000188595CC0
		public MethodDescriptor FindMethodByName(string name) => default; // 0x0000000188595B98-0x0000000188595C24
		public ServiceOptions GetOptions() => default; // 0x0000000188595C74-0x0000000188595CA0
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<ServiceOptions, T> extension) => default;
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<ServiceOptions, T> extension) => default;
		internal void CrossLink() {} // 0x0000000188595A78-0x0000000188595B98
	}

	internal sealed class SingleFieldAccessor : FieldAccessorBase // TypeDefIndex: 52198
	{
		// Fields
		private readonly Action<IMessage, object> setValueDelegate; // 0x20
		private readonly Action<IMessage> clearDelegate; // 0x28
		private readonly Func<IMessage, bool> hasDelegate; // 0x30
	
		// Constructors
		public SingleFieldAccessor() {} // Dummy constructor
		internal SingleFieldAccessor([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type messageType, PropertyInfo property, FieldDescriptor descriptor) {} // 0x0000000188596154-0x0000000188596774
	
		// Methods
		private static object GetDefaultValue(FieldDescriptor descriptor) => default; // 0x0000000188595EE4-0x0000000188596114
		public override void Clear(IMessage message) {} // 0x00000001857776CC-0x00000001857776EC
		public override bool HasValue(IMessage message) => default; // 0x0000000188596114-0x0000000188596134
		public override void SetValue(IMessage message, object value) {} // 0x0000000188596134-0x0000000188596154
	}

	public sealed class TypeRegistry // TypeDefIndex: 52201
	{
		// Fields
		private readonly Dictionary<string, MessageDescriptor> fullNameToMessageMap; // 0x10
	
		// Properties
		public static TypeRegistry Empty { get; } // 0x0000000188596E64-0x0000000188596EB4 
	
		// Nested types
		private class Builder // TypeDefIndex: 52199
		{
			// Fields
			private readonly Dictionary<string, MessageDescriptor> types; // 0x10
			private readonly HashSet<string> fileDescriptorNames; // 0x18
	
			// Constructors
			internal Builder() {} // 0x000000018858E018-0x000000018858E0D8
	
			// Methods
			internal void AddFile(FileDescriptor fileDescriptor) {} // 0x000000018858DB70-0x000000018858DE30
			private void AddMessage(MessageDescriptor messageDescriptor) {} // 0x000000018858DE30-0x000000018858DFB4
			internal TypeRegistry Build() => default; // 0x000000018858DFB4-0x000000018858E018
		}
	
		// Constructors
		public TypeRegistry() {} // Dummy constructor
		private TypeRegistry(Dictionary<string, MessageDescriptor> fullNameToMessageMap) {} // 0x000000018426FEE0-0x000000018426FEF0
		static TypeRegistry() {} // 0x0000000188596DAC-0x0000000188596E64
	
		// Methods
		public MessageDescriptor Find(string fullName) => default; // 0x000000018859699C-0x0000000188596A04
		public static TypeRegistry FromFiles(params FileDescriptor[] fileDescriptors) => default; // 0x0000000188596A04-0x0000000188596A50
		public static TypeRegistry FromFiles(IEnumerable<FileDescriptor> fileDescriptors) => default; // 0x0000000188596A50-0x0000000188596C08
		public static TypeRegistry FromMessages(params MessageDescriptor[] messageDescriptors) => default; // 0x0000000188596C08-0x0000000188596C54
		public static TypeRegistry FromMessages(IEnumerable<MessageDescriptor> messageDescriptors) => default; // 0x0000000188596C54-0x0000000188596DAC
	}
}

namespace Google.Protobuf.WellKnownTypes
{
	public static class AnyReflection // TypeDefIndex: 51998
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000188555208-0x0000000188555258 
	
		// Constructors
		static AnyReflection() {} // 0x0000000188554EB0-0x0000000188555208
	}

	public sealed class Any : IMessage<Any>, IBufferMessage // TypeDefIndex: 52000
	{
		// Fields
		private static readonly MessageParser<Any> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int TypeUrlFieldNumber = 1; // Metadata: 0x01FD16E1
		private string typeUrl_; // 0x18
		public const int ValueFieldNumber = 2; // Metadata: 0x01FD16E2
		private ByteString value_; // 0x20
		private const string DefaultPrefix = "type.googleapis.com"; // Metadata: 0x01FD16E3
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Any> Parser { get => default; } // 0x0000000188555B44-0x0000000188555B94 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188555AE4-0x0000000188555B44 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188555CD4-0x0000000188555D14 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TypeUrl { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000188555D14-0x0000000188555D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString Value { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000188555D7C-0x0000000188555DE4
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Any() {} // 0x0000000188555A7C-0x0000000188555AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Any(Any other) {} // 0x0000000188555A14-0x0000000188555A7C
		static Any() {} // 0x0000000188555910-0x0000000188555A14
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Any Clone() => default; // 0x0000000188555310-0x0000000188555370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188555370-0x00000001885553D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Any other) => default; // 0x00000001885553D4-0x000000018855547C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018855547C-0x0000000188555500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x00000001885558C4-0x0000000188555910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188555C40-0x0000000188555CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188555258-0x0000000188555310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Any other) {} // 0x00000001885556B8-0x0000000188555738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188555B94-0x0000000188555C40
		private static string GetTypeUrl(MessageDescriptor descriptor, string prefix) => default; // 0x0000000188555594-0x0000000188555620
		public static string GetTypeName(string typeUrl) => default; // 0x0000000188555500-0x0000000188555594
		public bool Is(MessageDescriptor descriptor) => default; // 0x0000000188555620-0x00000001885556B8
		public T Unpack<T>()
			where T : IMessage, new() => default;
		public bool TryUnpack<T>(out ref T result)
			where T : IMessage, new() {
			result = default;
			return default;
		}
		public static Any Pack(IMessage message) => default; // 0x0000000188555870-0x00000001885558C4
		public static Any Pack(IMessage message, string typeUrlPrefix) => default; // 0x0000000188555738-0x0000000188555870
	}

	public static class ApiReflection // TypeDefIndex: 52001
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x00000001885565E0-0x0000000188556630 
	
		// Constructors
		static ApiReflection() {} // 0x0000000188555DE4-0x00000001885565E0
	}

	public sealed class Api : IMessage<Api>, IBufferMessage // TypeDefIndex: 52003
	{
		// Fields
		private static readonly MessageParser<Api> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x01FD16F7
		private string name_; // 0x18
		public const int MethodsFieldNumber = 2; // Metadata: 0x01FD16F8
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Method> _repeated_methods_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Method> methods_; // 0x20
		public const int OptionsFieldNumber = 3; // Metadata: 0x01FD16F9
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x10
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x28
		public const int VersionFieldNumber = 4; // Metadata: 0x01FD16FA
		private string version_; // 0x30
		public const int SourceContextFieldNumber = 5; // Metadata: 0x01FD16FB
		private SourceContext sourceContext_; // 0x38
		public const int MixinsFieldNumber = 6; // Metadata: 0x01FD16FC
		private static readonly FieldCodec<Mixin> _repeated_mixins_codec; // 0x18
		private readonly RepeatedField<Mixin> mixins_; // 0x40
		public const int SyntaxFieldNumber = 7; // Metadata: 0x01FD16FD
		private Google.Protobuf.WellKnownTypes.Syntax syntax_; // 0x48
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Api> Parser { get => default; } // 0x00000001885571D8-0x0000000188557228 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188557178-0x00000001885571D8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188557638-0x0000000188557678 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000188557678-0x00000001885576E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Method> Methods { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Version { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x00000001885576E0-0x0000000188557748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceContext SourceContext { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Mixin> Mixins { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Google.Protobuf.WellKnownTypes.Syntax Syntax { get => default; set {} } // 0x0000000183D4EC50-0x0000000183D4EC60 0x0000000183D4ECD0-0x0000000183D4ECE0
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Api() {} // 0x0000000188556EFC-0x000000018855703C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Api(Api other) {} // 0x000000018855703C-0x0000000188557178
		static Api() {} // 0x0000000188556CBC-0x0000000188556EFC
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Api Clone() => default; // 0x0000000188556810-0x0000000188556870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188556870-0x00000001885568D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Api other) => default; // 0x00000001885568D4-0x00000001885569FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x00000001885569FC-0x0000000188556AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188556C70-0x0000000188556CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188557474-0x0000000188557638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188556630-0x0000000188556810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Api other) {} // 0x0000000188556AF0-0x0000000188556C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188557228-0x0000000188557474
	}

	public sealed class Method : IMessage<Google.Protobuf.WellKnownTypes.Method>, IBufferMessage // TypeDefIndex: 52005
	{
		// Fields
		private static readonly MessageParser<Method> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x01FD16FE
		private string name_; // 0x18
		public const int RequestTypeUrlFieldNumber = 2; // Metadata: 0x01FD16FF
		private string requestTypeUrl_; // 0x20
		public const int RequestStreamingFieldNumber = 3; // Metadata: 0x01FD1700
		private bool requestStreaming_; // 0x28
		public const int ResponseTypeUrlFieldNumber = 4; // Metadata: 0x01FD1701
		private string responseTypeUrl_; // 0x30
		public const int ResponseStreamingFieldNumber = 5; // Metadata: 0x01FD1702
		private bool responseStreaming_; // 0x38
		public const int OptionsFieldNumber = 6; // Metadata: 0x01FD1703
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x40
		public const int SyntaxFieldNumber = 7; // Metadata: 0x01FD1704
		private Google.Protobuf.WellKnownTypes.Syntax syntax_; // 0x48
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Method> Parser { get => default; } // 0x000000018855B72C-0x000000018855B77C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018855B6CC-0x000000018855B72C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018855BAB8-0x000000018855BAF8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x000000018855BAF8-0x000000018855BB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RequestTypeUrl { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x000000018855BB60-0x000000018855BBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RequestStreaming { get => default; set {} } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ResponseTypeUrl { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x000000018855BBC8-0x000000018855BC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ResponseStreaming { get => default; set {} } // 0x0000000183D4F190-0x0000000183D4F1A0 0x0000000183D4E280-0x0000000183D4E290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Google.Protobuf.WellKnownTypes.Syntax Syntax { get => default; set {} } // 0x0000000183D4EC50-0x0000000183D4EC60 0x0000000183D4ECD0-0x0000000183D4ECE0
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Method() {} // 0x000000018855B60C-0x000000018855B6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Method(Method other) {} // 0x000000018855B538-0x000000018855B60C
		static Method() {} // 0x000000018855B3C8-0x000000018855B538
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Method Clone() => default; // 0x000000018855AFD4-0x000000018855B034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018855B10C-0x000000018855B170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Method other) => default; // 0x000000018855B034-0x000000018855B10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018855B170-0x000000018855B27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018855B37C-0x000000018855B3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018855B924-0x000000018855BAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018855AE48-0x000000018855AFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Method other) {} // 0x000000018855B27C-0x000000018855B37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018855B77C-0x000000018855B924
	}

	public sealed class Mixin : IMessage<Mixin>, IBufferMessage // TypeDefIndex: 52007
	{
		// Fields
		private static readonly MessageParser<Mixin> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x01FD1705
		private string name_; // 0x18
		public const int RootFieldNumber = 2; // Metadata: 0x01FD1706
		private string root_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Mixin> Parser { get => default; } // 0x000000018855C090-0x000000018855C0E0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018855C030-0x000000018855C090 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018855C18C-0x000000018855C1CC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x000000018855C1CC-0x000000018855C234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Root { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x000000018855C234-0x000000018855C29C
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mixin() {} // 0x000000018855BFDC-0x000000018855C030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mixin(Mixin other) {} // 0x000000018855BF74-0x000000018855BFDC
		static Mixin() {} // 0x000000018855BE70-0x000000018855BF74
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mixin Clone() => default; // 0x000000018855BCE4-0x000000018855BD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018855BD44-0x000000018855BDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Mixin other) => default; // 0x00000001851B1588-0x00000001851B15F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x00000001851B15F0-0x00000001851B1668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018855BE24-0x000000018855BE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001851B19A0-0x00000001851B1A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018855BC30-0x000000018855BCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Mixin other) {} // 0x000000018855BDA8-0x000000018855BE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018855C0E0-0x000000018855C18C
	}

	public static class DurationReflection // TypeDefIndex: 52008
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000188557AC0-0x0000000188557B10 
	
		// Constructors
		static DurationReflection() {} // 0x0000000188557748-0x0000000188557AC0
	}

	public sealed class Duration : IMessage<Duration>, IBufferMessage, ICustomDiagnosticMessage // TypeDefIndex: 52010
	{
		// Fields
		private static readonly MessageParser<Duration> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int SecondsFieldNumber = 1; // Metadata: 0x01FD1707
		private long seconds_; // 0x18
		public const int NanosFieldNumber = 2; // Metadata: 0x01FD1708
		private int nanos_; // 0x20
		public const int NanosecondsPerSecond = 1000000000; // Metadata: 0x01FD1709
		public const int NanosecondsPerTick = 100; // Metadata: 0x01FD170E
		public const long MaxSeconds = 315576000000; // Metadata: 0x01FD1710
		public const long MinSeconds = -315576000000; // Metadata: 0x01FD1718
		internal const int MaxNanoseconds = 999999999; // Metadata: 0x01FD1720
		internal const int MinNanoseconds = -999999999; // Metadata: 0x01FD1725
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Duration> Parser { get => default; } // 0x0000000188558664-0x00000001885586B4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001885585D0-0x0000000188558664 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188558A3C-0x0000000188558A7C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Seconds { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000183D4EC10-0x0000000183D4EC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Nanos { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Duration() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Duration(Duration other) {} // 0x0000000185167AFC-0x0000000185167B40
		static Duration() {} // 0x00000001885584CC-0x00000001885585D0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Duration Clone() => default; // 0x0000000188557CFC-0x0000000188557D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188557D5C-0x0000000188557DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Duration other) => default; // 0x0000000185168418-0x000000018516844C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018516844C-0x0000000185168498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188558318-0x0000000188558364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185168678-0x00000001851686F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188557C60-0x0000000188557CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Duration other) {} // 0x0000000185168498-0x00000001851684E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001851685E0-0x0000000185168678
		internal static bool IsNormalized(long seconds, int nanoseconds) => default; // 0x0000000188557F44-0x0000000188557FD8
		public TimeSpan ToTimeSpan() => default; // 0x0000000188558364-0x00000001885584CC
		public static Duration FromTimeSpan(TimeSpan timeSpan) => default; // 0x0000000188557DC0-0x0000000188557F44
		public static Duration operator -(Duration value) => default; // 0x0000000188558944-0x0000000188558A3C
		public static Duration operator +(Duration lhs, Duration rhs) => default; // 0x00000001885586B4-0x00000001885587F8
		public static Duration operator -(Duration lhs, Duration rhs) => default; // 0x00000001885587F8-0x0000000188558944
		internal static Duration Normalize(long seconds, int nanoseconds) => default; // 0x0000000188557FD8-0x0000000188558074
		internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly) => default; // 0x00000001885580CC-0x0000000188558318
		public string ToDiagnosticString() => default; // 0x0000000188558074-0x00000001885580CC
		internal static void AppendNanoseconds(StringBuilder builder, int nanos) {} // 0x0000000188557B10-0x0000000188557C60
	}

	public static class EmptyReflection // TypeDefIndex: 52011
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000188558D74-0x0000000188558DC4 
	
		// Constructors
		static EmptyReflection() {} // 0x0000000188558A7C-0x0000000188558D74
	}

	public sealed class Empty : IMessage<Google.Protobuf.WellKnownTypes.Empty>, IBufferMessage // TypeDefIndex: 52013
	{
		// Fields
		private static readonly MessageParser<Empty> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Empty> Parser { get => default; } // 0x000000018855906C-0x00000001885590BC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188558FD8-0x000000018855906C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001885590BC-0x00000001885590FC 
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Empty() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Empty(Empty other) {} // 0x000000018518C054-0x000000018518C088
		static Empty() {} // 0x0000000188558ED4-0x0000000188558FD8
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Empty Clone() => default; // 0x0000000188558DC4-0x0000000188558E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188558E24-0x0000000188558E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Empty other) => default; // 0x000000018518BE84-0x000000018518BEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018518BEA8-0x000000018518BED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188558E88-0x0000000188558ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018518C194-0x000000018518C1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018518BDA0-0x000000018518BDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Empty other) {} // 0x000000018518BED4-0x000000018518BF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018518C138-0x000000018518C194
	}

	public static class FieldMaskReflection // TypeDefIndex: 52014
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000188559434-0x0000000188559484 
	
		// Constructors
		static FieldMaskReflection() {} // 0x00000001885590FC-0x0000000188559434
	}

	public sealed class FieldMask : IMessage<FieldMask>, IBufferMessage, ICustomDiagnosticMessage // TypeDefIndex: 52017
	{
		// Fields
		private static readonly MessageParser<FieldMask> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int PathsFieldNumber = 1; // Metadata: 0x01FD172A
		private static readonly FieldCodec<string> _repeated_paths_codec; // 0x08
		private readonly RepeatedField<string> paths_; // 0x18
		private const char FIELD_PATH_SEPARATOR = ','; // Metadata: 0x01FD172B
		private const char FIELD_SEPARATOR_REGEX = '.'; // Metadata: 0x01FD172D
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FieldMask> Parser { get => default; } // 0x000000018855A4D8-0x000000018855A528 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018855A444-0x000000018855A4D8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018855A69C-0x000000018855A6DC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Paths { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Nested types
		public sealed class MergeOptions // TypeDefIndex: 52015
		{
			// Properties
			public bool ReplaceMessageFields { get; set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
			public bool ReplaceRepeatedFields { get; set; } // 0x0000000183D510E0-0x0000000183D510F0 0x0000000183D510F0-0x0000000183D51100
			public bool ReplacePrimitiveFields { get; set; } // 0x0000000183D519E0-0x0000000183D519F0 0x0000000183D6B770-0x0000000183D6B780
	
			// Constructors
			public MergeOptions() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldMask() {} // 0x000000018855A3CC-0x000000018855A444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldMask(FieldMask other) {} // 0x000000018855A344-0x000000018855A3CC
		static FieldMask() {} // 0x000000018855A208-0x000000018855A344
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldMask Clone() => default; // 0x0000000188559518-0x0000000188559578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188559578-0x00000001885595DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FieldMask other) => default; // 0x00000001885595DC-0x0000000188559658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018517BB20-0x000000018517BB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018855A114-0x000000018855A160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018855A5F8-0x000000018855A69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188559484-0x0000000188559518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FieldMask other) {} // 0x0000000188559B88-0x0000000188559C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018855A528-0x000000018855A5F8
		internal static string ToJson(IList<string> paths, bool diagnosticOnly) => default; // 0x0000000188559DC8-0x000000018855A114
		public string ToDiagnosticString() => default; // 0x0000000188559D78-0x0000000188559DC8
		public static FieldMask FromString(string value) => default; // 0x0000000188559658-0x0000000188559714
		public static FieldMask FromString<T>(string value)
			where T : IMessage => default;
		public static FieldMask FromStringEnumerable<T>(IEnumerable<string> paths)
			where T : IMessage => default;
		public static FieldMask FromFieldNumbers<T>(params int[] fieldNumbers)
			where T : IMessage => default;
		public static FieldMask FromFieldNumbers<T>(IEnumerable<int> fieldNumbers)
			where T : IMessage => default;
		private static bool IsPathValid(string input) => default; // 0x00000001885598F0-0x0000000188559964
		public static bool IsValid<T>(FieldMask fieldMask)
			where T : IMessage => default;
		public static bool IsValid(MessageDescriptor descriptor, FieldMask fieldMask) => default; // 0x0000000188559964-0x0000000188559AD4
		public static bool IsValid<T>(string path)
			where T : IMessage => default;
		public static bool IsValid(MessageDescriptor descriptor, string path) => default; // 0x0000000188559AD4-0x0000000188559B88
		public FieldMask Normalize() => default; // 0x0000000188559D10-0x0000000188559D78
		public FieldMask Union(params FieldMask[] otherMasks) => default; // 0x000000018855A160-0x000000018855A208
		public FieldMask Intersection(FieldMask additionalMask) => default; // 0x0000000188559714-0x00000001885598F0
		public void Merge(IMessage source, IMessage destination, MergeOptions options) {} // 0x0000000188559C00-0x0000000188559C9C
		public void Merge(IMessage source, IMessage destination) {} // 0x0000000188559C9C-0x0000000188559D10
	}

	public static class SourceContextReflection // TypeDefIndex: 52018
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018855E3A0-0x000000018855E3F0 
	
		// Constructors
		static SourceContextReflection() {} // 0x000000018855E048-0x000000018855E3A0
	}

	public sealed class SourceContext : IMessage<SourceContext>, IBufferMessage // TypeDefIndex: 52020
	{
		// Fields
		private static readonly MessageParser<SourceContext> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int FileNameFieldNumber = 1; // Metadata: 0x01FD172F
		private string fileName_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SourceContext> Parser { get => default; } // 0x000000018855E7D8-0x000000018855E828 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018855E778-0x000000018855E7D8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018855E8A4-0x000000018855E8E4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FileName { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x000000018855E8E4-0x000000018855E94C
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceContext() {} // 0x000000018855E738-0x000000018855E778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceContext(SourceContext other) {} // 0x000000018855E6E0-0x000000018855E738
		static SourceContext() {} // 0x000000018855E5DC-0x000000018855E6E0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceContext Clone() => default; // 0x000000018855E46C-0x000000018855E4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018855E4CC-0x000000018855E530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SourceContext other) => default; // 0x0000000185188EA8-0x0000000185188EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000185188F60-0x0000000185188FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018855E590-0x000000018855E5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018518932C-0x0000000185189390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018855E3F0-0x000000018855E46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SourceContext other) {} // 0x000000018855E530-0x000000018855E590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018855E828-0x000000018855E8A4
	}

	public static class StructReflection // TypeDefIndex: 52021
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018855F0BC-0x000000018855F10C 
	
		// Constructors
		static StructReflection() {} // 0x000000018855E94C-0x000000018855F0BC
	}

	public enum NullValue // TypeDefIndex: 52022
	{
		NullValue = 0
	}

	public sealed class Struct : IMessage<Struct>, IBufferMessage // TypeDefIndex: 52024
	{
		// Fields
		private static readonly MessageParser<Struct> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int FieldsFieldNumber = 1; // Metadata: 0x01FD1731
		private static readonly MapField<string, Google.Protobuf.WellKnownTypes.Value> _map_fields_codec; // 0x08
		private readonly MapField<string, Google.Protobuf.WellKnownTypes.Value> fields_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Struct> Parser { get => default; } // 0x000000018855F6F4-0x000000018855F744 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018855F694-0x000000018855F6F4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018855F8B8-0x000000018855F8F8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, Google.Protobuf.WellKnownTypes.Value> Fields { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Struct() {} // 0x000000018855F61C-0x000000018855F694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Struct(Struct other) {} // 0x000000018855F594-0x000000018855F61C
		static Struct() {} // 0x000000018855F3A4-0x000000018855F594
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Struct Clone() => default; // 0x000000018855F1A0-0x000000018855F200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018855F200-0x000000018855F264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Struct other) => default; // 0x000000018855F264-0x000000018855F2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018517BB20-0x000000018517BB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018855F358-0x000000018855F3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018855F814-0x000000018855F8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018855F10C-0x000000018855F1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Struct other) {} // 0x000000018855F2E0-0x000000018855F358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018855F744-0x000000018855F814
	}

	public sealed class Value : IMessage<Google.Protobuf.WellKnownTypes.Value>, IBufferMessage // TypeDefIndex: 52027
	{
		// Fields
		private static readonly MessageParser<Value> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NullValueFieldNumber = 1; // Metadata: 0x01FD1732
		public const int NumberValueFieldNumber = 2; // Metadata: 0x01FD1733
		public const int StringValueFieldNumber = 3; // Metadata: 0x01FD1734
		public const int BoolValueFieldNumber = 4; // Metadata: 0x01FD1735
		public const int StructValueFieldNumber = 5; // Metadata: 0x01FD1736
		public const int ListValueFieldNumber = 6; // Metadata: 0x01FD1737
		private object kind_; // 0x18
		private KindOneofCase kindCase_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Value> Parser { get => default; } // 0x00000001885654B4-0x0000000188565504 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018856536C-0x00000001885653CC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188565924-0x0000000188565964 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NullValue NullValue { get => default; set {} } // 0x0000000188565420-0x0000000188565468 0x00000001885659F0-0x0000000188565A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double NumberValue { get => default; set {} } // 0x0000000188565468-0x00000001885654B4 0x0000000188565A50-0x0000000188565AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string StringValue { get => default; set {} } // 0x0000000188565504-0x0000000188565578 0x0000000188565AB4-0x0000000188565B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BoolValue { get => default; set {} } // 0x0000000188565324-0x000000018856536C 0x0000000188565964-0x00000001885659C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Struct StructValue { get => default; set {} } // 0x0000000188565578-0x00000001885655CC 0x0000000188565B24-0x0000000188565B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ListValue ListValue { get => default; set {} } // 0x00000001885653CC-0x0000000188565420 0x00000001885659C8-0x00000001885659F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KindOneofCase KindCase { get => default; } // 0x0000000181003B50-0x0000000181003B60 
	
		// Nested types
		public enum KindOneofCase // TypeDefIndex: 52025
		{
			None = 0,
			NullValue = 1,
			NumberValue = 2,
			StringValue = 3,
			BoolValue = 4,
			StructValue = 5,
			ListValue = 6
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Value() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Value(Value other) {} // 0x00000001885651E8-0x0000000188565324
		static Value() {} // 0x00000001885650E4-0x00000001885651E8
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Value Clone() => default; // 0x00000001885647FC-0x000000018856485C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearKind() {} // 0x00000001851A6FE0-0x00000001851A6FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018856485C-0x00000001885648C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Value other) => default; // 0x00000001885648C0-0x0000000188564A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000188564D5C-0x0000000188564EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188565098-0x00000001885650E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001885657F8-0x0000000188565924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x00000001885646D8-0x00000001885647FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Value other) {} // 0x0000000188564EB0-0x0000000188565098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001885655CC-0x00000001885657F8
		public static Value ForString(string value) => default; // 0x0000000188564C3C-0x0000000188564CCC
		public static Value ForNumber(double value) => default; // 0x0000000188564BDC-0x0000000188564C3C
		public static Value ForBool(bool value) => default; // 0x0000000188564A40-0x0000000188564AA0
		public static Value ForNull() => default; // 0x0000000188564B88-0x0000000188564BDC
		public static Value ForList(params Value[] values) => default; // 0x0000000188564AA0-0x0000000188564B88
		public static Value ForStruct(Struct value) => default; // 0x0000000188564CCC-0x0000000188564D5C
	}

	public sealed class ListValue : IMessage<ListValue>, IBufferMessage // TypeDefIndex: 52029
	{
		// Fields
		private static readonly MessageParser<ListValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValuesFieldNumber = 1; // Metadata: 0x01FD173F
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Value> _repeated_values_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Value> values_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ListValue> Parser { get => default; } // 0x000000018855AC44-0x000000018855AC94 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018855ABE4-0x000000018855AC44 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018855AE08-0x000000018855AE48 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Value> Values { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ListValue() {} // 0x000000018855AB6C-0x000000018855ABE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ListValue(ListValue other) {} // 0x000000018855AAE4-0x000000018855AB6C
		static ListValue() {} // 0x000000018855A974-0x000000018855AAE4
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ListValue Clone() => default; // 0x000000018855A770-0x000000018855A7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018855A7D0-0x000000018855A834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ListValue other) => default; // 0x000000018855A834-0x000000018855A8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018517BB20-0x000000018517BB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018855A928-0x000000018855A974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018855AD64-0x000000018855AE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018855A6DC-0x000000018855A770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ListValue other) {} // 0x000000018855A8B0-0x000000018855A928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018855AC94-0x000000018855AD64
	}

	public static class TimeExtensions // TypeDefIndex: 52030
	{
		// Extension methods
		public static Timestamp ToTimestamp(this System.DateTime dateTime) => default; // 0x000000018855F944-0x000000018855F990
		public static Timestamp ToTimestamp(this DateTimeOffset dateTimeOffset) => default; // 0x000000018855F990-0x000000018855F9E4
		public static Duration ToDuration(this TimeSpan timeSpan) => default; // 0x000000018855F8F8-0x000000018855F944
	}

	public static class TimestampReflection // TypeDefIndex: 52031
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018855FD5C-0x000000018855FDAC 
	
		// Constructors
		static TimestampReflection() {} // 0x000000018855F9E4-0x000000018855FD5C
	}

	public sealed class Timestamp : IMessage<Timestamp>, IBufferMessage, ICustomDiagnosticMessage, IComparable<Timestamp> // TypeDefIndex: 52033
	{
		// Fields
		private static readonly MessageParser<Timestamp> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int SecondsFieldNumber = 1; // Metadata: 0x01FD1740
		private long seconds_; // 0x18
		public const int NanosFieldNumber = 2; // Metadata: 0x01FD1741
		private int nanos_; // 0x20
		private static readonly System.DateTime UnixEpoch; // 0x08
		private const long BclSecondsAtUnixEpoch = 62135596800; // Metadata: 0x01FD1742
		internal const long UnixSecondsAtBclMaxValue = 253402300799; // Metadata: 0x01FD174A
		internal const long UnixSecondsAtBclMinValue = -62135596800; // Metadata: 0x01FD1752
		internal const int MaxNanos = 999999999; // Metadata: 0x01FD175A
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Timestamp> Parser { get => default; } // 0x0000000188560968-0x00000001885609B8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001885608D4-0x0000000188560968 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188560EA8-0x0000000188560EE8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Seconds { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000183D4EC10-0x0000000183D4EC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Nanos { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Timestamp() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Timestamp(Timestamp other) {} // 0x0000000185167AFC-0x0000000185167B40
		static Timestamp() {} // 0x0000000188560774-0x00000001885608D4
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Timestamp Clone() => default; // 0x000000018855FE48-0x000000018855FEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018855FF3C-0x000000018855FFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Timestamp other) => default; // 0x0000000185168418-0x000000018516844C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018516844C-0x0000000185168498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188560728-0x0000000188560774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185168678-0x00000001851686F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018855FDAC-0x000000018855FE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Timestamp other) {} // 0x000000018856019C-0x0000000188560234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001851685E0-0x0000000185168678
		private static bool IsNormalized(long seconds, int nanoseconds) => default; // 0x0000000188560170-0x000000018856019C
		public static Duration operator -(Timestamp lhs, Timestamp rhs) => default; // 0x0000000188560C04-0x0000000188560D50
		public static Timestamp operator +(Timestamp lhs, Duration rhs) => default; // 0x00000001885609B8-0x0000000188560B08
		public static Timestamp operator -(Timestamp lhs, Duration rhs) => default; // 0x0000000188560D50-0x0000000188560EA8
		public System.DateTime ToDateTime() => default; // 0x0000000188560338-0x0000000188560460
		public DateTimeOffset ToDateTimeOffset() => default; // 0x00000001885602C0-0x0000000188560338
		public static Timestamp FromDateTime(System.DateTime dateTime) => default; // 0x0000000188560008-0x0000000188560170
		public static Timestamp FromDateTimeOffset(DateTimeOffset dateTimeOffset) => default; // 0x000000018855FFA0-0x0000000188560008
		internal static Timestamp Normalize(long seconds, int nanoseconds) => default; // 0x0000000188560234-0x00000001885602C0
		internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly) => default; // 0x00000001885604B8-0x0000000188560728
		public int CompareTo(Timestamp other) => default; // 0x000000018855FEA8-0x000000018855FF3C
		public static bool operator <(Timestamp a, Timestamp b) => default; // 0x0000000188560BE4-0x0000000188560C04
		public static bool operator >(Timestamp a, Timestamp b) => default; // 0x0000000188560B48-0x0000000188560B6C
		public static bool operator <=(Timestamp a, Timestamp b) => default; // 0x0000000188560BC0-0x0000000188560BE4
		public static bool operator >=(Timestamp a, Timestamp b) => default; // 0x0000000188560B24-0x0000000188560B48
		public static bool operator ==(Timestamp a, Timestamp b) => default; // 0x0000000188560B08-0x0000000188560B24
		public static bool operator !=(Timestamp a, Timestamp b) => default; // 0x0000000188560B6C-0x0000000188560BC0
		public string ToDiagnosticString() => default; // 0x0000000188560460-0x00000001885604B8
	}

	public static class TypeReflection // TypeDefIndex: 52034
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000188561C7C-0x0000000188561CCC 
	
		// Constructors
		static TypeReflection() {} // 0x0000000188560EE8-0x0000000188561C7C
	}

	public enum Syntax // TypeDefIndex: 52035
	{
		Proto2 = 0,
		Proto3 = 1
	}

	public sealed class Type : IMessage<Google.Protobuf.WellKnownTypes.Type>, IBufferMessage // TypeDefIndex: 52037
	{
		// Fields
		private static readonly MessageParser<Type> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x01FD1761
		private string name_; // 0x18
		public const int FieldsFieldNumber = 2; // Metadata: 0x01FD1762
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Field> _repeated_fields_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Field> fields_; // 0x20
		public const int OneofsFieldNumber = 3; // Metadata: 0x01FD1763
		private static readonly FieldCodec<string> _repeated_oneofs_codec; // 0x10
		private readonly RepeatedField<string> oneofs_; // 0x28
		public const int OptionsFieldNumber = 4; // Metadata: 0x01FD1764
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x18
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x30
		public const int SourceContextFieldNumber = 5; // Metadata: 0x01FD1765
		private SourceContext sourceContext_; // 0x38
		public const int SyntaxFieldNumber = 6; // Metadata: 0x01FD1766
		private Google.Protobuf.WellKnownTypes.Syntax syntax_; // 0x40
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Type> Parser { get => default; } // 0x0000000188578D70-0x0000000188578DC0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188578D10-0x0000000188578D70 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188579168-0x00000001885791A8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001885791A8-0x0000000188579210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Field> Fields { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Oneofs { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get => default; } // 0x0000000181003830-0x0000000181003840 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceContext SourceContext { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Google.Protobuf.WellKnownTypes.Syntax Syntax { get => default; set {} } // 0x0000000183D4ED80-0x0000000183D4ED90 0x0000000183D4EDB0-0x0000000183D4EDC0
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Type() {} // 0x0000000188578AB0-0x0000000188578BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Type(Type other) {} // 0x0000000188578BDC-0x0000000188578D10
		static Type() {} // 0x00000001885788A4-0x0000000188578AB0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Type Clone() => default; // 0x0000000188578444-0x00000001885784A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x00000001885785B0-0x0000000188578614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Type other) => default; // 0x00000001885784A4-0x00000001885785B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000188578614-0x00000001885786F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188578858-0x00000001885788A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188578FE0-0x0000000188579168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x00000001885782AC-0x0000000188578444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Type other) {} // 0x00000001885786F4-0x0000000188578858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188578DC0-0x0000000188578FE0
	}

	public sealed class Field : IMessage<Google.Protobuf.WellKnownTypes.Field>, IBufferMessage // TypeDefIndex: 52042
	{
		// Fields
		private static readonly MessageParser<Field> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int KindFieldNumber = 1; // Metadata: 0x01FD1767
		private Types.Kind kind_; // 0x18
		public const int CardinalityFieldNumber = 2; // Metadata: 0x01FD1768
		private Types.Cardinality cardinality_; // 0x1C
		public const int NumberFieldNumber = 3; // Metadata: 0x01FD1769
		private int number_; // 0x20
		public const int NameFieldNumber = 4; // Metadata: 0x01FD176A
		private string name_; // 0x28
		public const int TypeUrlFieldNumber = 6; // Metadata: 0x01FD176B
		private string typeUrl_; // 0x30
		public const int OneofIndexFieldNumber = 7; // Metadata: 0x01FD176C
		private int oneofIndex_; // 0x38
		public const int PackedFieldNumber = 8; // Metadata: 0x01FD176D
		private bool packed_; // 0x3C
		public const int OptionsFieldNumber = 9; // Metadata: 0x01FD176E
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x40
		public const int JsonNameFieldNumber = 10; // Metadata: 0x01FD176F
		private string jsonName_; // 0x48
		public const int DefaultValueFieldNumber = 11; // Metadata: 0x01FD1770
		private string defaultValue_; // 0x50
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Field> Parser { get => default; } // 0x0000000188573204-0x0000000188573254 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001885731A4-0x0000000188573204 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188573668-0x00000001885736A8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.Kind Kind { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.Cardinality Cardinality { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Number { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000188573778-0x00000001885737E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TypeUrl { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x00000001885737E0-0x0000000188573848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OneofIndex { get => default; set {} } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Packed { get => default; set {} } // 0x0000000183D4F460-0x0000000183D4F470 0x0000000183D4F470-0x0000000183D4F480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string JsonName { get => default; set {} } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000188573710-0x0000000188573778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DefaultValue { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x00000001885736A8-0x0000000188573710
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 52040
		{
			// Nested types
			public enum Kind // TypeDefIndex: 52038
			{
				TypeUnknown = 0,
				TypeDouble = 1,
				TypeFloat = 2,
				TypeInt64 = 3,
				TypeUint64 = 4,
				TypeInt32 = 5,
				TypeFixed64 = 6,
				TypeFixed32 = 7,
				TypeBool = 8,
				TypeString = 9,
				TypeGroup = 10,
				TypeMessage = 11,
				TypeBytes = 12,
				TypeUint32 = 13,
				TypeEnum = 14,
				TypeSfixed32 = 15,
				TypeSfixed64 = 16,
				TypeSint32 = 17,
				TypeSint64 = 18
			}
	
			public enum Cardinality // TypeDefIndex: 52039
			{
				Unknown = 0,
				Optional = 1,
				Required = 2,
				Repeated = 3
			}
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Field() {} // 0x00000001885730D0-0x00000001885731A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Field(Field other) {} // 0x0000000188572FE0-0x00000001885730D0
		static Field() {} // 0x0000000188572E70-0x0000000188572FE0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Field Clone() => default; // 0x00000001885729F8-0x0000000188572A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188572B64-0x0000000188572BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Field other) => default; // 0x0000000188572A58-0x0000000188572B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000188572BC8-0x0000000188572CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188572E24-0x0000000188572E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000188573468-0x0000000188573668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x00000001885727E0-0x00000001885729F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Field other) {} // 0x0000000188572CF0-0x0000000188572E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188573254-0x0000000188573468
	}

	public sealed class Enum : IMessage<Google.Protobuf.WellKnownTypes.Enum>, IBufferMessage // TypeDefIndex: 52044
	{
		// Fields
		private static readonly MessageParser<Enum> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x01FD1788
		private string name_; // 0x18
		public const int EnumvalueFieldNumber = 2; // Metadata: 0x01FD1789
		private static readonly FieldCodec<EnumValue> _repeated_enumvalue_codec; // 0x08
		private readonly RepeatedField<EnumValue> enumvalue_; // 0x20
		public const int OptionsFieldNumber = 3; // Metadata: 0x01FD178A
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x10
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x28
		public const int SourceContextFieldNumber = 4; // Metadata: 0x01FD178B
		private SourceContext sourceContext_; // 0x30
		public const int SyntaxFieldNumber = 5; // Metadata: 0x01FD178C
		private Google.Protobuf.WellKnownTypes.Syntax syntax_; // 0x38
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Enum> Parser { get => default; } // 0x000000018856FBB4-0x000000018856FC04 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018856FB54-0x000000018856FBB4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018856FF20-0x000000018856FF60 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x000000018856FF60-0x000000018856FFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnumValue> Enumvalue { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceContext SourceContext { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Google.Protobuf.WellKnownTypes.Syntax Syntax { get => default; set {} } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Enum() {} // 0x000000018856F970-0x000000018856FA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Enum(Enum other) {} // 0x000000018856FA50-0x000000018856FB54
		static Enum() {} // 0x000000018856F798-0x000000018856F970
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Enum Clone() => default; // 0x000000018856F3B0-0x000000018856F410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018856F410-0x000000018856F474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Enum other) => default; // 0x000000018856F474-0x000000018856F554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018856F554-0x000000018856F610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018856F74C-0x000000018856F798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018856FDD4-0x000000018856FF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018856F244-0x000000018856F3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Enum other) {} // 0x000000018856F610-0x000000018856F74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018856FC04-0x000000018856FDD4
	}

	public sealed class EnumValue : IMessage<EnumValue>, IBufferMessage // TypeDefIndex: 52046
	{
		// Fields
		private static readonly MessageParser<EnumValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x01FD178D
		private string name_; // 0x18
		public const int NumberFieldNumber = 2; // Metadata: 0x01FD178E
		private int number_; // 0x20
		public const int OptionsFieldNumber = 3; // Metadata: 0x01FD178F
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x28
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnumValue> Parser { get => default; } // 0x000000018856EF34-0x000000018856EF84 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018856EED4-0x000000018856EF34 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018856F19C-0x000000018856F1DC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x000000018856F1DC-0x000000018856F244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Number { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValue() {} // 0x000000018856EE3C-0x000000018856EED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValue(EnumValue other) {} // 0x000000018856ED9C-0x000000018856EE3C
		static EnumValue() {} // 0x000000018856EC2C-0x000000018856ED9C
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValue Clone() => default; // 0x000000018856E9E0-0x000000018856EA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018856EA40-0x000000018856EAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnumValue other) => default; // 0x000000018856EAA4-0x000000018856EB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x00000001851B8B70-0x00000001851B8BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018856EBE0-0x000000018856EC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018856F0A8-0x000000018856F19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018856E8E4-0x000000018856E9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnumValue other) {} // 0x000000018856EB3C-0x000000018856EBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018856EF84-0x000000018856F0A8
	}

	public sealed class Option : IMessage<Google.Protobuf.WellKnownTypes.Option>, IBufferMessage // TypeDefIndex: 52048
	{
		// Fields
		private static readonly MessageParser<Option> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x01FD1790
		private string name_; // 0x18
		public const int ValueFieldNumber = 2; // Metadata: 0x01FD1791
		private Any value_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Option> Parser { get => default; } // 0x0000000188577480-0x00000001885774D0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188577420-0x0000000188577480 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001885775C4-0x0000000188577604 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000188577604-0x000000018857766C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Any Value { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Option() {} // 0x00000001885773E0-0x0000000188577420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Option(Option other) {} // 0x0000000188577364-0x00000001885773E0
		static Option() {} // 0x0000000188577260-0x0000000188577364
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Option Clone() => default; // 0x0000000188577074-0x00000001885770D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x00000001885770D4-0x0000000188577138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Option other) => default; // 0x00000001851B076C-0x00000001851B07D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x00000001851B07D4-0x00000001851B0844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188577214-0x0000000188577260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001851B0C24-0x00000001851B0CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188576FC8-0x0000000188577074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Option other) {} // 0x0000000188577138-0x0000000188577214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001885774D0-0x00000001885775C4
	}

	public static class WrappersReflection // TypeDefIndex: 52049
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
		internal const int WrapperValueFieldNumber = 1; // Metadata: 0x01FD1792
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018857B2F4-0x000000018857B4EC 
	
		// Constructors
		static WrappersReflection() {} // 0x000000018857A790-0x000000018857B2F4
	}

	public sealed class DoubleValue : IMessage<DoubleValue>, IBufferMessage // TypeDefIndex: 52051
	{
		// Fields
		private static readonly MessageParser<DoubleValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x01FD1793
		private double value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DoubleValue> Parser { get => default; } // 0x000000018856D8F8-0x000000018856D948 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018856D898-0x000000018856D8F8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018856D948-0x000000018856D988 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Value { get => default; set {} } // 0x0000000183D4EBD0-0x0000000183D4EBE0 0x0000000183D4EBE0-0x0000000183D4EBF0
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoubleValue() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoubleValue(DoubleValue other) {} // 0x000000018517A59C-0x000000018517A5D8
		static DoubleValue() {} // 0x000000018856D794-0x000000018856D898
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoubleValue Clone() => default; // 0x000000018856D564-0x000000018856D5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018856D650-0x000000018856D6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DoubleValue other) => default; // 0x000000018856D5C4-0x000000018856D650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018856D6B4-0x000000018856D748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018856D748-0x000000018856D794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001853CFAC8-0x00000001853CFB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x00000001853CF694-0x00000001853CF6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DoubleValue other) {} // 0x00000001853CF8B4-0x00000001853CF900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001853CFA54-0x00000001853CFAC8
	}

	public sealed class FloatValue : IMessage<FloatValue>, IBufferMessage // TypeDefIndex: 52053
	{
		// Fields
		private static readonly MessageParser<FloatValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x01FD1794
		private float value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloatValue> Parser { get => default; } // 0x0000000188575FF0-0x0000000188576040 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188575F90-0x0000000188575FF0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188576040-0x0000000188576080 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Value { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloatValue() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloatValue(FloatValue other) {} // 0x00000001851AA354-0x00000001851AA390
		static FloatValue() {} // 0x0000000188575E8C-0x0000000188575F90
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloatValue Clone() => default; // 0x0000000188575C58-0x0000000188575CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188575CB8-0x0000000188575D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloatValue other) => default; // 0x0000000188575D1C-0x0000000188575DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000188575DAC-0x0000000188575E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188575E40-0x0000000188575E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001853EFF04-0x00000001853EFF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x00000001853EFAD0-0x00000001853EFB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloatValue other) {} // 0x00000001853EFCF4-0x00000001853EFD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001853EFE90-0x00000001853EFF04
	}

	public sealed class Int64Value : IMessage<Int64Value>, IBufferMessage // TypeDefIndex: 52055
	{
		// Fields
		private static readonly MessageParser<Int64Value> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x01FD1795
		private long value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Int64Value> Parser { get => default; } // 0x00000001885766D4-0x0000000188576724 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188576674-0x00000001885766D4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188576724-0x0000000188576764 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Value { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000183D4EC10-0x0000000183D4EC20
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int64Value() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int64Value(Int64Value other) {} // 0x000000018517A59C-0x000000018517A5D8
		static Int64Value() {} // 0x0000000188576570-0x0000000188576674
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int64Value Clone() => default; // 0x0000000188576460-0x00000001885764C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x00000001885764C0-0x0000000188576524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Int64Value other) => default; // 0x000000018517A39C-0x000000018517A3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018517A3C8-0x000000018517A40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188576524-0x0000000188576570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018517A6FC-0x000000018517A750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x00000001885763F0-0x0000000188576460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Int64Value other) {} // 0x000000018517A40C-0x000000018517A44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018517A688-0x000000018517A6FC
	}

	public sealed class UInt64Value : IMessage<UInt64Value>, IBufferMessage // TypeDefIndex: 52057
	{
		// Fields
		private static readonly MessageParser<UInt64Value> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x01FD1796
		private ulong value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UInt64Value> Parser { get => default; } // 0x000000018857A700-0x000000018857A750 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018857A6A0-0x000000018857A700 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018857A750-0x000000018857A790 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong Value { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000183D4EC10-0x0000000183D4EC20
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UInt64Value() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UInt64Value(UInt64Value other) {} // 0x000000018517A59C-0x000000018517A5D8
		static UInt64Value() {} // 0x000000018857A59C-0x000000018857A6A0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UInt64Value Clone() => default; // 0x000000018857A48C-0x000000018857A4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018857A4EC-0x000000018857A550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UInt64Value other) => default; // 0x000000018517A39C-0x000000018517A3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018518F37C-0x000000018518F3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018857A550-0x000000018857A59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018518F5C0-0x000000018518F614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018857A41C-0x000000018857A48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UInt64Value other) {} // 0x000000018517A40C-0x000000018517A44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018517A688-0x000000018517A6FC
	}

	public sealed class Int32Value : IMessage<Int32Value>, IBufferMessage // TypeDefIndex: 52059
	{
		// Fields
		private static readonly MessageParser<Int32Value> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x01FD1797
		private int value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Int32Value> Parser { get => default; } // 0x0000000188576360-0x00000001885763B0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188576300-0x0000000188576360 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001885763B0-0x00000001885763F0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Value { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int32Value() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int32Value(Int32Value other) {} // 0x00000001851AA354-0x00000001851AA390
		static Int32Value() {} // 0x00000001885761FC-0x0000000188576300
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int32Value Clone() => default; // 0x00000001885760EC-0x000000018857614C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018857614C-0x00000001885761B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Int32Value other) => default; // 0x00000001851AA14C-0x00000001851AA178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x00000001851AA1DC-0x00000001851AA214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x00000001885761B0-0x00000001885761FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001851AA450-0x00000001851AA4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188576080-0x00000001885760EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Int32Value other) {} // 0x00000001851AA214-0x00000001851AA250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001851AA3E0-0x00000001851AA450
	}

	public sealed class UInt32Value : IMessage<UInt32Value>, IBufferMessage // TypeDefIndex: 52061
	{
		// Fields
		private static readonly MessageParser<UInt32Value> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x01FD1798
		private uint value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UInt32Value> Parser { get => default; } // 0x000000018857A38C-0x000000018857A3DC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018857A32C-0x000000018857A38C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018857A3DC-0x000000018857A41C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Value { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UInt32Value() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UInt32Value(UInt32Value other) {} // 0x00000001851AA354-0x00000001851AA390
		static UInt32Value() {} // 0x000000018857A228-0x000000018857A32C
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UInt32Value Clone() => default; // 0x000000018857A118-0x000000018857A178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x000000018857A178-0x000000018857A1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UInt32Value other) => default; // 0x00000001851AA14C-0x00000001851AA178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x00000001851AA1DC-0x00000001851AA214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x000000018857A1DC-0x000000018857A228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018527B0C4-0x000000018527B118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018857A0AC-0x000000018857A118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UInt32Value other) {} // 0x00000001851AA214-0x00000001851AA250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001851AA3E0-0x00000001851AA450
	}

	public sealed class BoolValue : IMessage<BoolValue>, IBufferMessage // TypeDefIndex: 52063
	{
		// Fields
		private static readonly MessageParser<BoolValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x01FD1799
		private bool value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BoolValue> Parser { get => default; } // 0x0000000188567B10-0x0000000188567B60 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188567AB0-0x0000000188567B10 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188567B60-0x0000000188567BA0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Value { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoolValue() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoolValue(BoolValue other) {} // 0x000000018521BA50-0x000000018521BA8C
		static BoolValue() {} // 0x00000001885679AC-0x0000000188567AB0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoolValue Clone() => default; // 0x0000000188567834-0x0000000188567894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188567894-0x00000001885678F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoolValue other) => default; // 0x000000018521B818-0x000000018521B844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x00000001885678F8-0x0000000188567960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188567960-0x00000001885679AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018521BB48-0x000000018521BB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x000000018521B788-0x000000018521B7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoolValue other) {} // 0x000000018521B910-0x000000018521B94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018521BADC-0x000000018521BB48
	}

	public sealed class StringValue : IMessage<StringValue>, IBufferMessage // TypeDefIndex: 52065
	{
		// Fields
		private static readonly MessageParser<StringValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x01FD179A
		private string value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StringValue> Parser { get => default; } // 0x0000000188578138-0x0000000188578188 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001885780D8-0x0000000188578138 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000188578204-0x0000000188578244 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Value { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000188578244-0x00000001885782AC
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StringValue() {} // 0x0000000188578040-0x0000000188578080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StringValue(StringValue other) {} // 0x0000000188578080-0x00000001885780D8
		static StringValue() {} // 0x0000000188577F3C-0x0000000188578040
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StringValue Clone() => default; // 0x0000000188577DCC-0x0000000188577E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188577E2C-0x0000000188577E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StringValue other) => default; // 0x0000000185188EA8-0x0000000185188EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000185188F60-0x0000000185188FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188577EF0-0x0000000188577F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018518932C-0x0000000185189390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188577D50-0x0000000188577DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StringValue other) {} // 0x0000000188577E90-0x0000000188577EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188578188-0x0000000188578204
	}

	public sealed class BytesValue : IMessage<BytesValue>, IBufferMessage // TypeDefIndex: 52067
	{
		// Fields
		private static readonly MessageParser<BytesValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x01FD179B
		private ByteString value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BytesValue> Parser { get => default; } // 0x0000000188568040-0x0000000188568090 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000188567FE0-0x0000000188568040 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018856810C-0x000000018856814C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString Value { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x000000018856814C-0x00000001885681B4
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BytesValue() {} // 0x0000000188567F8C-0x0000000188567FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BytesValue(BytesValue other) {} // 0x0000000188567F34-0x0000000188567F8C
		static BytesValue() {} // 0x0000000188567E30-0x0000000188567F34
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BytesValue Clone() => default; // 0x0000000188567C24-0x0000000188567C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000188567D18-0x0000000188567D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BytesValue other) => default; // 0x0000000188567C84-0x0000000188567D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x00000001851C30A0-0x00000001851C3104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000188567DE4-0x0000000188567E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001851C33E8-0x00000001851C3450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000188567BA0-0x0000000188567C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BytesValue other) {} // 0x0000000188567D7C-0x0000000188567DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000188568090-0x000000018856810C
	}
}

namespace System.Diagnostics.CodeAnalysis
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, Inherited = false)]
	internal sealed class DynamicallyAccessedMembersAttribute : Attribute // TypeDefIndex: 51904
	{
		// Properties
		public DynamicallyAccessedMemberTypes MemberTypes { get; } // 0x0000000183D4E340-0x0000000183D4E350 
	
		// Constructors
		public DynamicallyAccessedMembersAttribute() {} // Dummy constructor
		public DynamicallyAccessedMembersAttribute(DynamicallyAccessedMemberTypes memberTypes) {} // 0x00000001810410F0-0x0000000181041100
	}

	[Flags]
	internal enum DynamicallyAccessedMemberTypes // TypeDefIndex: 51905
	{
		All = -1,
		None = 0,
		PublicParameterlessConstructor = 1,
		PublicConstructors = 3,
		NonPublicConstructors = 4,
		PublicMethods = 8,
		NonPublicMethods = 16,
		PublicFields = 32,
		NonPublicFields = 64,
		PublicNestedTypes = 128,
		NonPublicNestedTypes = 256,
		PublicProperties = 512,
		NonPublicProperties = 1024,
		PublicEvents = 2048,
		NonPublicEvents = 4096,
		Interfaces = 8192
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
	internal sealed class RequiresUnreferencedCodeAttribute : Attribute // TypeDefIndex: 51906
	{
		// Properties
		public string Message { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public string Url { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public RequiresUnreferencedCodeAttribute() {} // Dummy constructor
		public RequiresUnreferencedCodeAttribute(string message) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All, Inherited = false, AllowMultiple = true)]
	internal sealed class UnconditionalSuppressMessageAttribute : Attribute // TypeDefIndex: 51907
	{
		// Properties
		public string Category { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public string CheckId { get; } // 0x0000000181041090-0x00000001810410A0 
		public string Scope { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public string Target { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public string MessageId { get; set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public string Justification { get; set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
	
		// Constructors
		public UnconditionalSuppressMessageAttribute() {} // Dummy constructor
		public UnconditionalSuppressMessageAttribute(string category, string checkId) {} // 0x0000000182676770-0x00000001826767A0
	}
}
