/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// Image 26: Google.Protobuf.dll - Assembly: Google.Protobuf, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 53265-53582

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 53582
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_44 _1EFF1891409D680B30DE202BD7A16F945ED09F02601C0E7B90FD917BE1162300; // 0x00 // Static value (base64): AAAAAADh9QUA4fUFgJaYAEBCDwCghgEAECcAAOgDAABkAAAACgAAAAEAAAA= - Metadata: 0x0207826C

	// Nested types
	private struct __StaticArrayInitTypeSize_44 // TypeDefIndex: 53581
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Google.Protobuf
{
	internal static class ByteArray // TypeDefIndex: 53270
	{
		// Fields
		private const int CopyThreshold = 12; // Metadata: 0x02078042
	
		// Methods
		internal static void Copy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count) {} // 0x0000000185784CC0-0x0000000185784CF0
		internal static void Reverse(byte[] bytes) {} // 0x000000018A667724-0x000000018A66778C
	}

	public sealed class ByteString : IEnumerable<byte>, IEquatable<ByteString> // TypeDefIndex: 53271
	{
		// Fields
		private static readonly ByteString empty; // 0x00
		private readonly ReadOnlyMemory<byte> bytes; // 0x10
	
		// Properties
		public static ByteString Empty { get => default; } // 0x000000018A6683E4-0x000000018A668434 
		public int Length { get => default; } // 0x0000000185590DA0-0x0000000185590DE0 
		public bool IsEmpty { get => default; } // 0x000000018A668434-0x000000018A66844C 
		public ReadOnlySpan<byte> Span { get => default; } // 0x0000000185590CC0-0x0000000185590D20 
		public ReadOnlyMemory<byte> Memory { get => default; } // 0x00000001834A7540-0x00000001834A7550 
		public byte this[int index] { get => default; } // 0x000000018A66844C-0x000000018A6684AC 
	
		// Constructors
		public ByteString() {} // Dummy constructor
		private ByteString(ReadOnlyMemory<byte> bytes) {} // 0x0000000184AF8BE0-0x0000000184AF8BF0
		static ByteString() {} // 0x00000001857849C0-0x0000000185784AF0
	
		// Methods
		internal static ByteString AttachBytes(ReadOnlyMemory<byte> bytes) => default; // 0x0000000185784B80-0x0000000185784BE0
		internal static ByteString AttachBytes(byte[] bytes) => default; // 0x0000000185784AF0-0x0000000185784B80
		public byte[] ToByteArray() => default; // 0x0000000185F7DFB0-0x0000000185F7E030
		public string ToBase64() => default; // 0x000000018A6680B0-0x000000018A6681C4
		public static ByteString FromBase64(string bytes) => default; // 0x000000018A667CD4-0x000000018A667DB4
		public static ByteString FromStream(Stream stream) => default; // 0x000000018A667E1C-0x000000018A667FAC
		public static Task<ByteString> FromStreamAsync(Stream stream, CancellationToken cancellationToken = default) => default; // 0x000000018A667DB4-0x000000018A667E1C
		public static ByteString CopyFrom(byte[] bytes) => default; // 0x0000000185784910-0x00000001857849C0
		public static ByteString CopyFrom(byte[] bytes, int offset, int count) => default; // 0x0000000185784BE0-0x0000000185784CC0
		public static ByteString CopyFrom(ReadOnlySpan<byte> bytes) => default; // 0x000000018A667978-0x000000018A667A18
		public static ByteString CopyFrom(string text, Encoding encoding) => default; // 0x000000018A6678D4-0x000000018A667978
		public static ByteString CopyFromUtf8(string text) => default; // 0x000000018A66787C-0x000000018A6678D4
		public string ToString(Encoding encoding) => default; // 0x000000018A6681E8-0x000000018A6682E4
		public string ToStringUtf8() => default; // 0x000000018A6681C4-0x000000018A6681E8
		public IEnumerator<byte> GetEnumerator() => default; // 0x000000018A667FAC-0x000000018A66801C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018A6680A8-0x000000018A6680B0
		public CodedInputStream CreateCodedInput() => default; // 0x000000018A667AA0-0x000000018A667C08
		public static bool operator ==(ByteString lhs, ByteString rhs) => default; // 0x0000000184D95920-0x0000000184D95970
		public static bool operator !=(ByteString lhs, ByteString rhs) => default; // 0x000000018A6684AC-0x000000018A668500
		public override bool Equals(object obj) => default; // 0x000000018A667C08-0x000000018A667C78
		public override int GetHashCode() => default; // 0x000000018A66801C-0x000000018A6680A8
		public bool Equals(ByteString other) => default; // 0x000000018A667C78-0x000000018A667CD4
		public void CopyTo(byte[] array, int position) {} // 0x000000018A667A18-0x000000018A667AA0
		public void WriteTo(Stream outputStream) {} // 0x000000018A6682E4-0x000000018A6683E4
	}

	internal static class ByteStringAsync // TypeDefIndex: 53273
	{
		// Nested types
		private struct _FromStreamAsyncCore_d__0 : IAsyncStateMachine // TypeDefIndex: 53272
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<ByteString> __t__builder; // 0x08
			public Stream stream; // 0x20
			public CancellationToken cancellationToken; // 0x28
			private MemoryStream _memoryStream_5__2; // 0x30
			private TaskAwaiter __u__1; // 0x38
	
			// Methods
			private void MoveNext() {} // 0x000000018A66778C-0x000000018A66787C
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018A67D140-0x000000018A67D4AC
		}
	
		// Methods
		internal static Task<ByteString> FromStreamAsyncCore(Stream stream, CancellationToken cancellationToken) => default; // 0x000000018A67D4AC-0x000000018A67D50C
	}

	public sealed class CodedInputStream : IDisposable // TypeDefIndex: 53274
	{
		// Fields
		private readonly bool leaveOpen; // 0x10
		private readonly byte[] buffer; // 0x18
		private readonly Stream input; // 0x20
		private ParserInternalState state; // 0x28
		internal const int DefaultRecursionLimit = 100; // Metadata: 0x02078043
		internal const int DefaultSizeLimit = 2147483647; // Metadata: 0x02078045
		internal const int BufferSize = 4096; // Metadata: 0x02078046
	
		// Properties
		public long Position { get => default; } // 0x000000018A6692D0-0x000000018A66930C 
		internal uint LastTag { get => default; } // 0x00000001834A1F30-0x00000001834A1F40 
		public int SizeLimit { get => default; } // 0x0000000181A73EA0-0x0000000181A73EB0 
		public int RecursionLimit { get => default; } // 0x00000001834A0D40-0x00000001834A0D50 
		internal bool DiscardUnknownFields { get => default; set {} } // 0x0000000185FBF7D0-0x0000000185FBF7E0 0x0000000185FBF810-0x0000000185FBF820
		internal ExtensionRegistry ExtensionRegistry { get => default; set {} } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018646EBCC-0x000000018646EBE0
		internal byte[] InternalBuffer { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		internal Stream InternalInputStream { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		internal ref ParserInternalState InternalState { get => default; } // 0x0000000185FCC7B0-0x0000000185FCC7C0 
		internal bool ReachedLimit { get => default; } // 0x000000018A66930C-0x000000018A669318 
		public bool IsAtEnd { get => default; } // 0x000000018A66926C-0x000000018A6692D0 
	
		// Constructors
		public CodedInputStream() {} // Dummy constructor
		public CodedInputStream(byte[] buffer) {} // 0x000000018A6691E4-0x000000018A66926C
		public CodedInputStream(byte[] buffer, int offset, int length) {} // 0x00000001843CE6A0-0x00000001843CE830
		public CodedInputStream(Stream input) {} // 0x000000018A669010-0x000000018A66901C
		public CodedInputStream(Stream input, bool leaveOpen) {} // 0x000000018A66913C-0x000000018A6691E4
		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, bool leaveOpen) {} // 0x00000001843CEEB0-0x00000001843CEFF0
		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, int sizeLimit, int recursionLimit, bool leaveOpen) {} // 0x000000018A66901C-0x000000018A66913C
	
		// Methods
		public static CodedInputStream CreateWithLimits(Stream input, int sizeLimit, int recursionLimit) => default; // 0x000000018A668500-0x000000018A6685C0
		public void Dispose() {} // 0x000000018A6685C0-0x000000018A6685EC
		internal void CheckReadEndOfStreamTag() {} // 0x00000001843CEE50-0x00000001843CEEB0
		public uint PeekTag() => default; // 0x000000018A668660-0x000000018A6686C8
		public uint ReadTag() => default; // 0x000000018A668E20-0x000000018A668E88
		public void SkipLastField() {} // 0x000000018A668F90-0x000000018A669010
		internal void SkipGroup(uint startGroupTag) {} // 0x000000018A668F04-0x000000018A668F90
		public double ReadDouble() => default; // 0x000000018A668760-0x000000018A6687C8
		public float ReadFloat() => default; // 0x000000018A6687E0-0x000000018A668848
		public ulong ReadUInt64() => default; // 0x000000018A668944-0x000000018A66894C
		public long ReadInt64() => default; // 0x000000018A668944-0x000000018A66894C
		public int ReadInt32() => default; // 0x000000018A6687C8-0x000000018A6687D0
		public ulong ReadFixed64() => default; // 0x000000018A6687D8-0x000000018A6687E0
		public uint ReadFixed32() => default; // 0x000000018A6687D0-0x000000018A6687D8
		public bool ReadBool() => default; // 0x000000018A6686E4-0x000000018A6686FC
		public string ReadString() => default; // 0x000000018A668DBC-0x000000018A668E20
		public void ReadMessage(IMessage builder) {} // 0x000000018A6689B4-0x000000018A668B64
		public void ReadGroup(IMessage builder) {} // 0x000000018A668848-0x000000018A668944
		public ByteString ReadBytes() => default; // 0x000000018A6686FC-0x000000018A668760
		public uint ReadUInt32() => default; // 0x000000018A6687C8-0x000000018A6687D0
		public int ReadEnum() => default; // 0x000000018A6687C8-0x000000018A6687D0
		public int ReadSFixed32() => default; // 0x000000018A6687D0-0x000000018A6687D8
		public long ReadSFixed64() => default; // 0x000000018A6687D8-0x000000018A6687E0
		public int ReadSInt32() => default; // 0x000000018A668D80-0x000000018A668D9C
		public long ReadSInt64() => default; // 0x000000018A668D9C-0x000000018A668DBC
		public int ReadLength() => default; // 0x000000018A66894C-0x000000018A6689B4
		public bool MaybeConsumeTag(uint tag) => default; // 0x000000018A6685EC-0x000000018A668660
		internal uint ReadRawVarint32() => default; // 0x000000018A668CB0-0x000000018A668D18
		internal static uint ReadRawVarint32(Stream input) => default; // 0x000000018A668CA8-0x000000018A668CB0
		internal ulong ReadRawVarint64() => default; // 0x000000018A668D18-0x000000018A668D80
		internal uint ReadRawLittleEndian32() => default; // 0x000000018A668BD8-0x000000018A668C40
		internal ulong ReadRawLittleEndian64() => default; // 0x000000018A668C40-0x000000018A668CA8
		internal int PushLimit(int byteLimit) => default; // 0x000000018A6686D8-0x000000018A6686E4
		internal void PopLimit(int oldLimit) {} // 0x000000018A6686C8-0x000000018A6686D8
		private bool RefillBuffer(bool mustSucceed) => default; // 0x000000018A668E88-0x000000018A668F04
		internal byte[] ReadRawBytes(int size) => default; // 0x000000018A668B64-0x000000018A668BD8
		public void ReadRawMessage(IMessage message) {} // 0x00000001843D0AE0-0x00000001843D0CB0
	}

	public sealed class CodedOutputStream : IDisposable // TypeDefIndex: 53276
	{
		// Fields
		private const int LittleEndian64Size = 8; // Metadata: 0x02078048
		private const int LittleEndian32Size = 4; // Metadata: 0x02078049
		internal const int DoubleSize = 8; // Metadata: 0x0207804A
		internal const int FloatSize = 4; // Metadata: 0x0207804B
		internal const int BoolSize = 1; // Metadata: 0x0207804C
		public static readonly int DefaultBufferSize; // 0x00
		private readonly bool leaveOpen; // 0x10
		private readonly byte[] buffer; // 0x18
		private WriterInternalState state; // 0x20
		private readonly Stream output; // 0x38
	
		// Properties
		public long Position { get => default; } // 0x0000000181424480-0x0000000181424490 
		public int NonOutputPosition { get => default; } // 0x000000018A669618-0x000000018A66969C 
		public int SpaceLeft { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		internal byte[] InternalBuffer { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		internal Stream InternalOutputStream { get => default; } // 0x0000000185FCA250-0x0000000185FCA260 
		internal ref WriterInternalState InternalState { get => default; } // 0x0000000185FA4EA0-0x0000000185FA4EE0 
	
		// Nested types
		public sealed class OutOfSpaceException : IOException // TypeDefIndex: 53275
		{
			// Constructors
			internal OutOfSpaceException() {} // 0x0000000181E1B510-0x0000000181E1B520
		}
	
		// Constructors
		public CodedOutputStream() {} // Dummy constructor
		public CodedOutputStream(byte[] flatArray) {} // 0x00000001843CED30-0x00000001843CEE20
		public CodedOutputStream(byte[] buffer, int offset, int length) {} // 0x000000018A66A7E4-0x000000018A66A898
		private CodedOutputStream(Stream output, byte[] buffer, bool leaveOpen) {} // 0x000000018A66A910-0x000000018A66A978
		public CodedOutputStream(Stream output) {} // 0x000000018A66A778-0x000000018A66A7E4
		public CodedOutputStream(Stream output, int bufferSize) {} // 0x000000018A66A6D4-0x000000018A66A74C
		public CodedOutputStream(Stream output, bool leaveOpen) {} // 0x000000018A66A898-0x000000018A66A910
		public CodedOutputStream(Stream output, int bufferSize, bool leaveOpen) {} // 0x000000018A66A978-0x000000018A66A9AC
		static CodedOutputStream() {} // 0x000000018A67C2B8-0x000000018A67C2FC
	
		// Methods
		public static int ComputeDoubleSize(double value) => default; // 0x0000000181C44E90-0x0000000181C44EA0
		public static int ComputeFloatSize(float value) => default; // 0x0000000184341680-0x00000001843416D0
		public static int ComputeUInt64Size(ulong value) => default; // 0x0000000184341630-0x0000000184341680
		public static int ComputeInt64Size(long value) => default; // 0x0000000184340F30-0x0000000184340FE0
		public static int ComputeInt32Size(int value) => default; // 0x0000000181E1B510-0x0000000181E1B520
		public static int ComputeFixed64Size(ulong value) => default; // 0x0000000181C44E90-0x0000000181C44EA0
		public static int ComputeFixed32Size(uint value) => default; // 0x0000000181B87DE0-0x0000000181B87DF0
		public static int ComputeBoolSize(bool value) => default; // 0x0000000184340730-0x00000001843407D0
		public static int ComputeStringSize(string value) => default; // 0x000000018A669324-0x000000018A669370
		public static int ComputeGroupSize(IMessage value) => default; // 0x0000000184340C70-0x0000000184340CF0
		public static int ComputeMessageSize(IMessage value) => default; // 0x0000000185590D20-0x0000000185590DA0
		public static int ComputeBytesSize(ByteString value) => default; // 0x0000000184340CF0-0x0000000184340D90
		public static int ComputeUInt32Size(uint value) => default; // 0x0000000184340E30-0x0000000184340F30
		public static int ComputeEnumSize(int value) => default; // 0x0000000181C44E90-0x0000000181C44EA0
		public static int ComputeSFixed32Size(int value) => default; // 0x0000000181E1B510-0x0000000181E1B520
		public static int ComputeSFixed64Size(long value) => default; // 0x000000018A669370-0x000000018A6693D0
		public static int ComputeSInt32Size(int value) => default; // 0x000000018A6693D0-0x000000018A669434
		public static int ComputeSInt64Size(long value) => default; // 0x0000000184340D90-0x0000000184340E30
		public static int ComputeLengthSize(int length) => default; // 0x0000000184340FE0-0x0000000184341020
		public static int ComputeRawVarint32Size(uint value) => default; // 0x00000001843416D0-0x0000000184341770
		public static int ComputeRawVarint64Size(ulong value) => default; // 0x000000018A669434-0x000000018A669484
		public static int ComputeTagSize(int fieldNumber) => default; // 0x000000018A66A74C-0x000000018A66A778
		public void WriteDouble(double value) {} // 0x000000018A66981C-0x000000018A6698A0
		public void WriteFloat(float value) {} // 0x000000018A66A654-0x000000018A66A6D4
		public void WriteUInt64(ulong value) {} // 0x000000018A669A34-0x000000018A669AB4
		public void WriteInt64(long value) {} // 0x000000018A6699B4-0x000000018A669A34
		public void WriteInt32(int value) {} // 0x000000018A66979C-0x000000018A66981C
		public void WriteFixed64(ulong value) {} // 0x000000018A66971C-0x000000018A66979C
		public void WriteFixed32(uint value) {} // 0x000000018A669518-0x000000018A669598
		public void WriteBool(bool value) {} // 0x000000018A66A440-0x000000018A66A4C0
		public void WriteString(string value) {} // 0x000000018A669B34-0x000000018A669C48
		public void WriteMessage(IMessage value) {} // 0x0000000184664440-0x00000001846645C0
		public void WriteRawMessage(IMessage value) {} // 0x000000018A6698A0-0x000000018A6699B4
		public void WriteGroup(IMessage value) {} // 0x000000018A669598-0x000000018A669618
		public void WriteBytes(ByteString value) {} // 0x000000018A66A5D4-0x000000018A66A654
		public void WriteUInt32(uint value) {} // 0x000000018A66969C-0x000000018A66971C
		public void WriteEnum(int value) {} // 0x000000018A66A240-0x000000018A66A2C0
		public void WriteSFixed32(int value) {} // 0x000000018A66A2C0-0x000000018A66A340
		public void WriteSFixed64(long value) {} // 0x000000018A66A340-0x000000018A66A3C0
		public void WriteSInt32(int value) {} // 0x000000018A66A3C0-0x000000018A66A440
		public void WriteSInt64(long value) {} // 0x000000018A669AB4-0x000000018A669B34
		public void WriteLength(int length) {} // 0x000000018A66A540-0x000000018A66A5D4
		public void WriteTag(int fieldNumber, WireFormat.WireType type) {} // 0x000000018A66A4C0-0x000000018A66A540
		public void WriteTag(uint tag) {} // 0x000000018A66A0C0-0x000000018A66A140
		public void WriteRawTag(byte b1) {} // 0x000000018A66A02C-0x000000018A66A0C0
		public void WriteRawTag(byte b1, byte b2) {} // 0x000000018A669ED4-0x000000018A669F7C
		public void WriteRawTag(byte b1, byte b2, byte b3) {} // 0x000000018A669F7C-0x000000018A66A02C
		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4) {} // 0x000000018A669E18-0x000000018A669ED4
		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5) {} // 0x000000018A66A140-0x000000018A66A1C0
		internal void WriteRawVarint32(uint value) {} // 0x000000018A66A1C0-0x000000018A66A240
		internal void WriteRawVarint64(ulong value) {} // 0x000000018A669D18-0x000000018A669D98
		internal void WriteRawLittleEndian32(uint value) {} // 0x000000018A669D98-0x000000018A669E18
		internal void WriteRawLittleEndian64(ulong value) {} // 0x000000018A669C48-0x000000018A669C74
		internal void WriteRawBytes(byte[] value) {} // 0x000000018A669C74-0x000000018A669D18
		internal void WriteRawBytes(byte[] value, int offset, int length) {} // 0x000000018A669484-0x000000018A6694C0
		public void Dispose() {} // 0x000000018A6694C0-0x000000018A669518
		public void Flush() {} // 0x000000018A669318-0x000000018A669324
		public void CheckNoSpaceLeft() {} // 0x000000018A66A9AC-0x000000018A66A9B8
	}

	public abstract class Extension // TypeDefIndex: 53277
	{
		// Fields
		private readonly int _FieldNumber_k__BackingField; // 0x10
	
		// Properties
		internal abstract System.Type TargetType { get; }
		public int FieldNumber { get; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
		internal abstract bool IsRepeated { get; }
	
		// Constructors
		protected Extension() {} // Dummy constructor
		protected Extension(int fieldNumber) {} // 0x0000000181378230-0x0000000181378240
	
		// Methods
		internal abstract IExtensionValue CreateValue();
	}

	public sealed class Extension<TTarget, TValue> : Google.Protobuf.Extension // TypeDefIndex: 53278
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

	public sealed class RepeatedExtension<TTarget, TValue> : Google.Protobuf.Extension // TypeDefIndex: 53279
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

	public sealed class ExtensionRegistry : ICollection<Google.Protobuf.Extension>, IDeepCloneable<ExtensionRegistry> // TypeDefIndex: 53282
	{
		// Fields
		private IDictionary<ObjectIntPair<System.Type>, Google.Protobuf.Extension> extensions; // 0x10
	
		// Properties
		public int Count { get => default; } // 0x000000018A66AFB8-0x000000018A66B024 
		bool System.Collections.Generic.ICollection<Google.Protobuf.Extension>.IsReadOnly { get => default; } // 0x000000018A66B024-0x000000018A66B0F0 
	
		// Nested types
		internal sealed class ExtensionComparer : IEqualityComparer<Google.Protobuf.Extension> // TypeDefIndex: 53280
		{
			// Fields
			internal static ExtensionComparer Instance; // 0x00
	
			// Constructors
			public ExtensionComparer() {} // 0x000000018A66B524-0x000000018A66B56C
			static ExtensionComparer() {} // 0x00000001814A81B0-0x00000001814A81C0
	
			// Methods
			public bool Equals(Google.Protobuf.Extension a, Google.Protobuf.Extension b) => default; // 0x000000018A66B2D4-0x000000018A66B34C
			public int GetHashCode(Google.Protobuf.Extension a) => default; // 0x000000018A66B34C-0x000000018A66B524
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53281
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KeyValuePair<ObjectIntPair<System.Type>, Google.Protobuf.Extension>, ObjectIntPair<System.Type>> __9__3_0; // 0x08
			public static Func<KeyValuePair<ObjectIntPair<System.Type>, Google.Protobuf.Extension>, Google.Protobuf.Extension> __9__3_1; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018A66AE48-0x000000018A66AEEC
			public __c() {} // 0x000000018A66ACCC-0x000000018A66AD98
	
			// Methods
			internal ObjectIntPair<System.Type> _.ctor_b__3_0(KeyValuePair<ObjectIntPair<System.Type>, Google.Protobuf.Extension> k) => default; // 0x000000018A66AB78-0x000000018A66ACCC
			internal Google.Protobuf.Extension _.ctor_b__3_1(KeyValuePair<ObjectIntPair<System.Type>, Google.Protobuf.Extension> v) => default; // 0x000000018A66AD98-0x000000018A66ADE4
		}
	
		// Constructors
		public ExtensionRegistry() {} // 0x000000018A66AEEC-0x000000018A66AFB8
		private ExtensionRegistry(IDictionary<ObjectIntPair<System.Type>, Google.Protobuf.Extension> collection) {} // 0x000000018A66B0F0-0x000000018A66B2CC
	
		// Methods
		internal bool ContainsInputField(uint lastTag, System.Type target, out Google.Protobuf.Extension extension) {
			extension = default;
			return default;
		} // 0x000000018A66B2CC-0x000000018A66B2D4
		public void Add(Google.Protobuf.Extension extension) {} // 0x000000018A66ADE4-0x000000018A66AE48
		public void AddRange(IEnumerable<Google.Protobuf.Extension> extensions) {} // 0x000000018A66A9B8-0x000000018A66AA8C
		public void Clear() {} // 0x000000018A66AA8C-0x000000018A66AB14
		public bool Contains(Google.Protobuf.Extension item) => default; // 0x0000000185492010-0x0000000185492020
		void ICollection<Extension>.CopyTo(Google.Protobuf.Extension[] array, int arrayIndex) {} // 0x000000018A66AB14-0x000000018A66AB78
		public IEnumerator<Google.Protobuf.Extension> GetEnumerator() => default; // 0x000000018A67DDA8-0x000000018A67DE0C
		public bool Remove(Google.Protobuf.Extension item) => default; // 0x0000000185492010-0x0000000185492020
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018A67DA84-0x000000018A67DAC4
		public ExtensionRegistry Clone() => default; // 0x000000018A67DAC4-0x000000018A67DAFC
	}

	public static class ExtensionSet // TypeDefIndex: 53283
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

	public sealed class ExtensionSet<TTarget> // TypeDefIndex: 53285
		where TTarget : IExtendableMessage<TTarget>
	{
		// Fields
		private readonly Dictionary<int, IExtensionValue> _ValuesByNumber_k__BackingField;
	
		// Properties
		internal Dictionary<int, IExtensionValue> ValuesByNumber { get; }
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53284
		{
			// Fields
			public static readonly __c<TTarget> __9;
			public static Func<IExtensionValue, bool> __9__8_0;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal bool _IsInitialized_b__8_0(IExtensionValue v) => default;
		}
	
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

	internal interface IExtensionValue : IEquatable<IExtensionValue>, IDeepCloneable<IExtensionValue> // TypeDefIndex: 53286
	{
		// Methods
		void MergeFrom(ref ParseContext ctx);
		void MergeFrom(IExtensionValue value);
		void WriteTo(ref WriteContext ctx);
		int CalculateSize();
		bool IsInitialized();
		object GetValue();
	}

	internal sealed class ExtensionValue<T> : IExtensionValue // TypeDefIndex: 53287
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

	internal sealed class RepeatedExtensionValue<T> : IExtensionValue // TypeDefIndex: 53288
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

	public static class FieldCodec // TypeDefIndex: 53301
	{
		// Nested types
		private static class WrapperCodecs // TypeDefIndex: 53290
		{
			// Fields
			private static readonly Dictionary<System.Type, object> Codecs; // 0x00
			private static readonly Dictionary<System.Type, object> Readers; // 0x08
	
			// Nested types
			private sealed class __c__DisplayClass3_0<T> // TypeDefIndex: 53289
				where T : struct
			{
				// Fields
				public FieldCodec<T> nestedCoded;
	
				// Constructors
				public __c__DisplayClass3_0() {} // 0x0000000185235510-0x0000000185235550
	
				// Methods
				internal T? _GetReader_b__0(ref ParseContext ctx) => default; // 0x000000018A66B56C-0x000000018A66B5BC
			}
	
			// Constructors
			static WrapperCodecs() {} // 0x00000001864738BC-0x00000001864738C8
	
			// Methods
			internal static FieldCodec<T> GetCodec<T>() => default; // 0x00000001864738A4-0x00000001864738B0
			internal static ValueReader<T?> GetReader<T>()
				where T : struct => default; // 0x00000001864738C8-0x00000001864738D4
			internal static T Read<T>(ref ParseContext ctx, FieldCodec<T> codec) => default; // 0x000000018A66C284-0x000000018A66C290
			internal static void Write<T>(ref WriteContext ctx, T value, FieldCodec<T> codec) {} // 0x000000018A66B9E0-0x000000018A66B9EC
			internal static int CalculateSize<T>(T value, FieldCodec<T> codec) => default; // 0x000000018A66BE14-0x000000018A66BE20
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53291
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static ValueReader<string> __9__16_0; // 0x08
			public static ValueWriter<string> __9__16_1; // 0x10
			public static ValueReader<ByteString> __9__17_0; // 0x18
			public static ValueWriter<ByteString> __9__17_1; // 0x20
			public static ValueReader<bool> __9__18_0; // 0x28
			public static ValueWriter<bool> __9__18_1; // 0x30
			public static ValueReader<int> __9__19_0; // 0x38
			public static ValueWriter<int> __9__19_1; // 0x40
			public static ValueReader<int> __9__20_0; // 0x48
			public static ValueWriter<int> __9__20_1; // 0x50
			public static ValueReader<uint> __9__21_0; // 0x58
			public static ValueWriter<uint> __9__21_1; // 0x60
			public static ValueReader<int> __9__22_0; // 0x68
			public static ValueWriter<int> __9__22_1; // 0x70
			public static ValueReader<uint> __9__23_0; // 0x78
			public static ValueWriter<uint> __9__23_1; // 0x80
			public static ValueReader<long> __9__24_0; // 0x88
			public static ValueWriter<long> __9__24_1; // 0x90
			public static ValueReader<long> __9__25_0; // 0x98
			public static ValueWriter<long> __9__25_1; // 0xA0
			public static ValueReader<ulong> __9__26_0; // 0xA8
			public static ValueWriter<ulong> __9__26_1; // 0xB0
			public static ValueReader<long> __9__27_0; // 0xB8
			public static ValueWriter<long> __9__27_1; // 0xC0
			public static ValueReader<ulong> __9__28_0; // 0xC8
			public static ValueWriter<ulong> __9__28_1; // 0xD0
			public static ValueReader<float> __9__29_0; // 0xD8
			public static ValueWriter<float> __9__29_1; // 0xE0
			public static ValueReader<double> __9__30_0; // 0xE8
			public static ValueWriter<double> __9__30_1; // 0xF0
	
			// Constructors
			static __c() {} // 0x00000001864738B0-0x00000001864738BC
			public __c() {} // 0x000000018A66C4E0-0x000000018A66C4EC
	
			// Methods
			internal string _ForString_b__16_0(ref ParseContext ctx) => default; // 0x000000018A66B9EC-0x000000018A66B9F8
			internal void _ForString_b__16_1(ref WriteContext ctx, string value) {} // 0x000000018A66C038-0x000000018A66C044
			internal ByteString _ForBytes_b__17_0(ref ParseContext ctx) => default; // 0x00000001864738D4-0x00000001864738E0
			internal void _ForBytes_b__17_1(ref WriteContext ctx, ByteString value) {} // 0x0000000186473898-0x00000001864738A4
			internal bool _ForBool_b__18_0(ref ParseContext ctx) => default; // 0x000000018A66B7D0-0x000000018A66B7DC
			internal void _ForBool_b__18_1(ref WriteContext ctx, bool value) {}
			internal int _ForInt32_b__19_0(ref ParseContext ctx) => default; // 0x0000000185235550-0x00000001852357F0
			internal void _ForInt32_b__19_1(ref WriteContext output, int value) {} // 0x0000000184D956A0-0x0000000184D95920
			internal int _ForSInt32_b__20_0(ref ParseContext ctx) => default; // 0x0000000185232080-0x00000001852322F0
			internal void _ForSInt32_b__20_1(ref WriteContext output, int value) {} // 0x0000000185233860-0x0000000185233B00
			internal uint _ForFixed32_b__21_0(ref ParseContext ctx) => default; // 0x000000018A66C044-0x000000018A66C284
			internal void _ForFixed32_b__21_1(ref WriteContext output, uint value) {} // 0x000000018A66B7DC-0x000000018A66B9E0
			internal int _ForSFixed32_b__22_0(ref ParseContext ctx) => default; // 0x000000018A66BC10-0x000000018A66BE14
			internal void _ForSFixed32_b__22_1(ref WriteContext output, int value) {} // 0x000000018522F500-0x000000018522F860
			internal uint _ForUInt32_b__23_0(ref ParseContext ctx) => default; // 0x0000000185231700-0x00000001852319B0
			internal void _ForUInt32_b__23_1(ref WriteContext output, uint value) {} // 0x000000018A66C290-0x000000018A66C4E0
			internal long _ForInt64_b__24_0(ref ParseContext ctx) => default; // 0x000000018A66B9F8-0x000000018A66BC10
			internal void _ForInt64_b__24_1(ref WriteContext output, long value) {} // 0x000000018A66BE20-0x000000018A66C038
			internal long _ForSInt64_b__25_0(ref ParseContext ctx) => default; // 0x000000018566EF50-0x000000018566F200
			internal void _ForSInt64_b__25_1(ref WriteContext output, long value) {} // 0x0000000185BC75C0-0x0000000185BC7800
			internal ulong _ForFixed64_b__26_0(ref ParseContext ctx) => default; // 0x000000018A66B5BC-0x000000018A66B7D0
			internal void _ForFixed64_b__26_1(ref WriteContext output, ulong value) {}
			internal long _ForSFixed64_b__27_0(ref ParseContext ctx) => default;
			internal void _ForSFixed64_b__27_1(ref WriteContext output, long value) {}
			internal ulong _ForUInt64_b__28_0(ref ParseContext ctx) => default;
			internal void _ForUInt64_b__28_1(ref WriteContext output, ulong value) {}
			internal float _ForFloat_b__29_0(ref ParseContext ctx) => default;
			internal void _ForFloat_b__29_1(ref WriteContext output, float value) {}
			internal double _ForDouble_b__30_0(ref ParseContext ctx) => default;
			internal void _ForDouble_b__30_1(ref WriteContext output, double value) {}
		}
	
		private sealed class __c__DisplayClass31_0<T> // TypeDefIndex: 53292
		{
			// Fields
			public Func<int, T> fromInt32;
			public Func<T, int> toInt32;
	
			// Constructors
			public __c__DisplayClass31_0() {}
	
			// Methods
			internal T _ForEnum_b__0(ref ParseContext ctx) => default; // 0x000000018A67DE70-0x000000018A67E8C4
			internal void _ForEnum_b__1(ref WriteContext output, T value) {}
			internal int _ForEnum_b__2(T value) => default;
		}
	
		private sealed class __c__DisplayClass32_0<T> // TypeDefIndex: 53293
			where T : class, IMessage<T>
		{
			// Fields
			public MessageParser<T> parser;
	
			// Constructors
			public __c__DisplayClass32_0() {} // 0x0000000185F70090-0x0000000185F700F0
	
			// Methods
			internal T _ForMessage_b__0(ref ParseContext ctx) => default; // 0x0000000185492010-0x0000000185492020
			internal void _ForMessage_b__2(ref ParseContext ctx, ref ref T v) {} // 0x00000001841A2150-0x00000001841A2160
		}
	
		[Serializable]
		private sealed class __c__32<T> // TypeDefIndex: 53294
			where T : class, IMessage<T>
		{
			// Fields
			public static readonly __c__32<T> __9;
			public static ValueWriter<T> __9__32_1;
			public static FieldCodec<T> __9__32_3;
			public static Func<T, int> __9__32_4;
	
			// Constructors
			static __c__32() {} // 0x00000001859F22D0-0x00000001859F22F0
			public __c__32() {}
	
			// Methods
			internal void _ForMessage_b__32_1(ref WriteContext output, T value) {} // 0x000000018A67D52C-0x000000018A67D540
			internal bool _ForMessage_b__32_3(ref ref T v, T v2) => default; // 0x00000001857B2B10-0x00000001857B2B20
			internal int _ForMessage_b__32_4(T message) => default; // 0x000000018A67D50C-0x000000018A67D520
		}
	
		private sealed class __c__DisplayClass33_0<T> // TypeDefIndex: 53295
			where T : class, IMessage<T>
		{
			// Fields
			public MessageParser<T> parser;
	
			// Constructors
			public __c__DisplayClass33_0() {} // 0x000000018419EF00-0x000000018419EF10
	
			// Methods
			internal T _ForGroup_b__0(ref ParseContext ctx) => default; // 0x000000018A67D5C4-0x000000018A67D5D4
			internal void _ForGroup_b__2(ref ParseContext ctx, ref ref T v) {} // 0x000000018A67D5F8-0x000000018A67D61C
		}
	
		[Serializable]
		private sealed class __c__33<T> // TypeDefIndex: 53296
			where T : class, IMessage<T>
		{
			// Fields
			public static readonly __c__33<T> __9;
			public static ValueWriter<T> __9__33_1;
			public static FieldCodec<T> __9__33_3;
			public static Func<T, int> __9__33_4;
	
			// Constructors
			static __c__33() {} // 0x000000018A67D61C-0x000000018A67D62C
			public __c__33() {}
	
			// Methods
			internal void _ForGroup_b__33_1(ref WriteContext output, T value) {} // 0x000000018A67D570-0x000000018A67D580
			internal bool _ForGroup_b__33_3(ref ref T v, T v2) => default; // 0x000000018A67D560-0x000000018A67D570
			internal int _ForGroup_b__33_4(T message) => default; // 0x000000018A67D5D4-0x000000018A67D5E4
		}
	
		private sealed class __c__DisplayClass34_0<T> // TypeDefIndex: 53297
			where T : class
		{
			// Fields
			public FieldCodec<T> nestedCodec;
	
			// Constructors
			public __c__DisplayClass34_0() {} // 0x00000001841A0710-0x00000001841A0720
	
			// Methods
			internal T _ForClassWrapper_b__0(ref ParseContext ctx) => default; // 0x000000018A67D668-0x000000018A67D678
			internal void _ForClassWrapper_b__1(ref WriteContext output, T value) {} // 0x0000000184C66DA0-0x0000000184C66DB0
			internal void _ForClassWrapper_b__2(ref ParseContext ctx, ref ref T v) {} // 0x0000000185FA2980-0x0000000185FA29A0
			internal int _ForClassWrapper_b__4(T value) => default; // 0x000000018A67D62C-0x000000018A67D654
		}
	
		[Serializable]
		private sealed class __c__34<T> // TypeDefIndex: 53298
			where T : class
		{
			// Fields
			public static readonly __c__34<T> __9;
			public static FieldCodec<T> __9__34_3;
	
			// Constructors
			static __c__34() {} // 0x000000018A67D654-0x000000018A67D668
			public __c__34() {}
	
			// Methods
			internal bool _ForClassWrapper_b__34_3(ref ref T v, T v2) => default; // 0x000000018A67D590-0x000000018A67D5A4
		}
	
		private sealed class __c__DisplayClass35_0<T> // TypeDefIndex: 53299
			where T : struct
		{
			// Fields
			public FieldCodec<T> nestedCodec;
	
			// Constructors
			public __c__DisplayClass35_0() {} // 0x000000018A67D580-0x000000018A67D590
	
			// Methods
			internal void _ForStructWrapper_b__0(ref WriteContext output, T? value) {} // 0x000000018A67D5E4-0x000000018A67D5F8
			internal void _ForStructWrapper_b__1(ref ParseContext ctx, ref T? v) {} // 0x0000000184C66550-0x0000000184C66560
			internal int _ForStructWrapper_b__3(T? value) => default; // 0x000000018A67D678-0x000000018A67D68C
		}
	
		[Serializable]
		private sealed class __c__35<T> // TypeDefIndex: 53300
			where T : struct
		{
			// Fields
			public static readonly __c__35<T> __9;
			public static FieldCodec<T?> __9__35_2;
	
			// Constructors
			static __c__35() {} // 0x000000018A67D5A4-0x000000018A67D5B4
			public __c__35() {}
	
			// Methods
			internal bool _ForStructWrapper_b__35_2(ref T? v, T? v2) => default; // 0x000000018A67D540-0x000000018A67D550
		}
	
		// Methods
		public static FieldCodec<string> ForString(uint tag) => default; // 0x000000018A67D550-0x000000018A67D560
		public static FieldCodec<ByteString> ForBytes(uint tag) => default;
		public static FieldCodec<bool> ForBool(uint tag) => default;
		public static FieldCodec<int> ForInt32(uint tag) => default;
		public static FieldCodec<int> ForSInt32(uint tag) => default;
		public static FieldCodec<uint> ForFixed32(uint tag) => default;
		public static FieldCodec<int> ForSFixed32(uint tag) => default;
		public static FieldCodec<uint> ForUInt32(uint tag) => default;
		public static FieldCodec<long> ForInt64(uint tag) => default;
		public static FieldCodec<long> ForSInt64(uint tag) => default;
		public static FieldCodec<ulong> ForFixed64(uint tag) => default;
		public static FieldCodec<long> ForSFixed64(uint tag) => default;
		public static FieldCodec<ulong> ForUInt64(uint tag) => default;
		public static FieldCodec<float> ForFloat(uint tag) => default;
		public static FieldCodec<double> ForDouble(uint tag) => default;
		public static FieldCodec<T> ForEnum<T>(uint tag, Func<T, int> toInt32, Func<int, T> fromInt32) => default;
		public static FieldCodec<string> ForString(uint tag, string defaultValue) => default;
		public static FieldCodec<ByteString> ForBytes(uint tag, ByteString defaultValue) => default;
		public static FieldCodec<bool> ForBool(uint tag, bool defaultValue) => default;
		public static FieldCodec<int> ForInt32(uint tag, int defaultValue) => default;
		public static FieldCodec<int> ForSInt32(uint tag, int defaultValue) => default;
		public static FieldCodec<uint> ForFixed32(uint tag, uint defaultValue) => default;
		public static FieldCodec<int> ForSFixed32(uint tag, int defaultValue) => default;
		public static FieldCodec<uint> ForUInt32(uint tag, uint defaultValue) => default;
		public static FieldCodec<long> ForInt64(uint tag, long defaultValue) => default;
		public static FieldCodec<long> ForSInt64(uint tag, long defaultValue) => default;
		public static FieldCodec<ulong> ForFixed64(uint tag, ulong defaultValue) => default;
		public static FieldCodec<long> ForSFixed64(uint tag, long defaultValue) => default;
		public static FieldCodec<ulong> ForUInt64(uint tag, ulong defaultValue) => default;
		public static FieldCodec<float> ForFloat(uint tag, float defaultValue) => default;
		public static FieldCodec<double> ForDouble(uint tag, double defaultValue) => default;
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

	internal delegate TValue ValueReader<out TValue>(ref ParseContext ctx); // TypeDefIndex: 53302; 0x00000000-0x00000000

	internal delegate void ValueWriter<T>(ref WriteContext ctx, T value); // TypeDefIndex: 53303; 0x00000000-0x00000000

	public sealed class FieldCodec<T> // TypeDefIndex: 53309
	{
		// Fields
		private static readonly EqualityComparer<T> EqualityComparer;
		private static readonly T DefaultDefault;
		private static readonly bool TypeSupportsPacking;
		private readonly bool _PackedRepeatedField_k__BackingField;
		private readonly ValueWriter<T> _ValueWriter_k__BackingField;
		private readonly Func<T, int> _ValueSizeCalculator_k__BackingField;
		private readonly ValueReader<T> _ValueReader_k__BackingField;
		private readonly InputMerger _ValueMerger_k__BackingField;
		private readonly ValuesMerger _FieldMerger_k__BackingField;
		private readonly int _FixedSize_k__BackingField;
		private readonly uint _Tag_k__BackingField;
		private readonly uint _EndTag_k__BackingField;
		private readonly T _DefaultValue_k__BackingField;
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
		internal delegate void InputMerger(ref ParseContext ctx, ref ref T value); // TypeDefIndex: 53304; 0x00000000-0x00000000
	
		internal delegate bool ValuesMerger(ref ref T value, T other); // TypeDefIndex: 53305; 0x00000000-0x00000000
	
		private sealed class __c__DisplayClass38_0 // TypeDefIndex: 53306
		{
			// Fields
			public int fixedSize;
	
			// Constructors
			public __c__DisplayClass38_0() {}
	
			// Methods
			internal int _.ctor_b__0(T _) => default;
		}
	
		private sealed class __c__DisplayClass39_0 // TypeDefIndex: 53307
		{
			// Fields
			public ValueReader<T> reader;
	
			// Constructors
			public __c__DisplayClass39_0() {}
	
			// Methods
			internal void _.ctor_b__0(ref ParseContext ctx, ref ref T v) {}
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53308
		{
			// Fields
			public static readonly __c<T> __9;
			public static ValuesMerger<T> __9__39_1;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal bool _.ctor_b__39_1(ref ref T v, T v2) => default;
		}
	
		// Constructors
		public FieldCodec() {} // Dummy constructor
		static FieldCodec() {}
		internal FieldCodec(ValueReader<T> reader, ValueWriter<T> writer, int fixedSize, uint tag, T defaultValue) {}
		internal FieldCodec(ValueReader<T> reader, ValueWriter<T> writer, Func<T, int> sizeCalculator, uint tag, T defaultValue) {}
		internal FieldCodec(ValueReader<T> reader, ValueWriter<T> writer, InputMerger inputMerger, ValuesMerger valuesMerger, Func<T, int> sizeCalculator, uint tag, uint endTag = 0 /* Metadata: 0x0207804D */) {}
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

	internal sealed class FieldMaskTree // TypeDefIndex: 53311
	{
		// Fields
		private const char FIELD_PATH_SEPARATOR = '.'; // Metadata: 0x0207804E
		private readonly Node root; // 0x10
	
		// Nested types
		internal sealed class Node // TypeDefIndex: 53310
		{
			// Fields
			private readonly Dictionary<string, Node> _Children_k__BackingField; // 0x10
	
			// Properties
			public Dictionary<string, Node> Children { get; } // 0x000000018A66D848-0x000000018A66D8AC 
	
			// Constructors
			public Node() {} // 0x000000018A66D8AC-0x000000018A66D92C
		}
	
		// Constructors
		public FieldMaskTree() {} // 0x000000018A66D820-0x000000018A66D848
		public FieldMaskTree(FieldMask mask) {} // 0x000000018A66C4EC-0x000000018A66C698
	
		// Methods
		public override string ToString() => default; // 0x000000018A66CBBC-0x000000018A66CD08
		public FieldMaskTree AddFieldPath(string path) => default; // 0x000000018A66D708-0x000000018A66D820
		public FieldMaskTree MergeFromFieldMask(FieldMask mask) => default; // 0x000000018A66C698-0x000000018A66C8B4
		public FieldMask ToFieldMask() => default; // 0x000000018A66C8B4-0x000000018A66CBBC
		private void GetFieldPaths(Node node, string path, List<string> paths) {} // 0x000000018A66CD08-0x000000018A66CE5C
		public void IntersectFieldPath(string path, FieldMaskTree output) {} // 0x000000018A66CE5C-0x000000018A66D708
		public void Merge(IMessage source, IMessage destination, FieldMask.MergeOptions options) {} // 0x000000018346D130-0x000000018346D140
		private void Merge(Node node, string path, IMessage source, IMessage destination, FieldMask.MergeOptions options) {} // 0x000000018A67BC54-0x000000018A67BCCC
	}

	internal static class FrameworkPortability // TypeDefIndex: 53312
	{
		// Fields
		internal static readonly RegexOptions CompiledRegexWhereAvailable; // 0x00
	
		// Constructors
		static FrameworkPortability() {} // 0x000000018A66D92C-0x000000018A66D9FC
	}

	public interface IBufferMessage : IMessage // TypeDefIndex: 53313
	{
		// Methods
		void InternalMergeFrom(ref ParseContext ctx);
		void InternalWriteTo(ref WriteContext ctx);
	}

	public interface ICustomDiagnosticMessage : IMessage // TypeDefIndex: 53314
	{
		// Methods
		string ToDiagnosticString();
	}

	public interface IDeepCloneable<T> // TypeDefIndex: 53315
	{
		// Methods
		T Clone();
	}

	public interface IExtendableMessage<T> : IMessage<T> // TypeDefIndex: 53316
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

	public interface IMessage // TypeDefIndex: 53317
	{
		// Properties
		MessageDescriptor Descriptor { get; }
	
		// Methods
		void MergeFrom(CodedInputStream input);
		void WriteTo(CodedOutputStream output);
		int CalculateSize();
	}

	public interface IMessage<T> : IMessage, IEquatable<T>, IDeepCloneable<T> // TypeDefIndex: 53318
		where T : IMessage<T>
	{
		// Methods
		void MergeFrom(T message);
	}

	public sealed class InvalidJsonException : IOException // TypeDefIndex: 53319
	{
		// Constructors
		public InvalidJsonException() {} // Dummy constructor
		internal InvalidJsonException(string message) {} // 0x000000018A66D9FC-0x000000018A66DA1C
	}

	public sealed class InvalidProtocolBufferException : IOException // TypeDefIndex: 53320
	{
		// Constructors
		public InvalidProtocolBufferException() {} // Dummy constructor
		internal InvalidProtocolBufferException(string message) {} // 0x000000018A66D9FC-0x000000018A66DA1C
		internal InvalidProtocolBufferException(string message, Exception innerException) {} // 0x000000018A66DF40-0x000000018A66DF48
	
		// Methods
		internal static InvalidProtocolBufferException MoreDataAvailable() => default; // 0x000000018A66DD4C-0x000000018A66DDB0
		internal static InvalidProtocolBufferException TruncatedMessage() => default; // 0x000000018A66DEDC-0x000000018A66DF40
		internal static InvalidProtocolBufferException NegativeSize() => default; // 0x000000018A66DDB0-0x000000018A66DE14
		internal static InvalidProtocolBufferException MalformedVarint() => default; // 0x000000018A66DC84-0x000000018A66DCE8
		internal static InvalidProtocolBufferException InvalidTag() => default; // 0x000000018A66DB58-0x000000018A66DBBC
		internal static InvalidProtocolBufferException InvalidWireType() => default; // 0x000000018A66DBBC-0x000000018A66DC20
		internal static InvalidProtocolBufferException InvalidBase64(Exception innerException) => default; // 0x000000018A66DA1C-0x000000018A66DA90
		internal static InvalidProtocolBufferException InvalidEndTag() => default; // 0x000000018A66DA90-0x000000018A66DAF4
		internal static InvalidProtocolBufferException RecursionLimitExceeded() => default; // 0x000000018A66DE14-0x000000018A66DE78
		internal static InvalidProtocolBufferException JsonRecursionLimitExceeded() => default; // 0x000000018A66DC20-0x000000018A66DC84
		internal static InvalidProtocolBufferException SizeLimitExceeded() => default; // 0x000000018A66DE78-0x000000018A66DEDC
		internal static InvalidProtocolBufferException InvalidMessageStreamTag() => default; // 0x000000018A66DAF4-0x000000018A66DB58
		internal static InvalidProtocolBufferException MissingFields() => default; // 0x000000018A66DCE8-0x000000018A66DD4C
	}

	public sealed class JsonFormatter // TypeDefIndex: 53324
	{
		// Fields
		internal const string AnyTypeUrlField = "@type"; // Metadata: 0x02078050
		internal const string AnyDiagnosticValueField = "@value"; // Metadata: 0x02078056
		internal const string AnyWellKnownTypeValueField = "value"; // Metadata: 0x0207805D
		private const string TypeUrlPrefix = "type.googleapis.com"; // Metadata: 0x02078063
		private const string NameValueSeparator = ": "; // Metadata: 0x02078077
		private const string PropertySeparator = ", "; // Metadata: 0x0207807A
		private static readonly JsonFormatter _Default_k__BackingField; // 0x00
		private static readonly JsonFormatter diagnosticFormatter; // 0x08
		private static readonly string[] CommonRepresentations; // 0x10
		private readonly Settings settings; // 0x10
		private const string Hex = "0123456789abcdef"; // Metadata: 0x0207807D
	
		// Properties
		public static JsonFormatter Default { get; } // 0x000000018A670C6C-0x000000018A670EEC 
		private bool DiagnosticOnly { get => default; } // 0x000000018A66EED4-0x000000018A66FF60 
	
		// Nested types
		public sealed class Settings // TypeDefIndex: 53321
		{
			// Fields
			private static readonly Settings _Default_k__BackingField; // 0x00
			private readonly bool _FormatDefaultValues_k__BackingField; // 0x10
			private readonly TypeRegistry _TypeRegistry_k__BackingField; // 0x18
			private readonly bool _FormatEnumsAsIntegers_k__BackingField; // 0x20
			private readonly bool _PreserveProtoFieldNames_k__BackingField; // 0x21
	
			// Properties
			public static Settings Default { get; } // 0x000000018A673170-0x000000018A6731C0 
			public bool FormatDefaultValues { get; } // 0x000000018A6731C0-0x000000018A67320C 
			public TypeRegistry TypeRegistry { get; } // 0x000000018A673108-0x000000018A673170 
			public bool FormatEnumsAsIntegers { get; } // 0x000000018A66DF48-0x000000018A66DFCC 
			public bool PreserveProtoFieldNames { get; } // 0x000000018A66DFCC-0x000000018A66E0DC 
	
			// Constructors
			public Settings() {} // Dummy constructor
			static Settings() {} // 0x000000018A671F60-0x000000018A673108
			public Settings(bool formatDefaultValues) {} // 0x000000018A66E6F4-0x000000018A66E780
			public Settings(bool formatDefaultValues, TypeRegistry typeRegistry) {} // 0x000000018A670760-0x000000018A6708FC
			private Settings(bool formatDefaultValues, TypeRegistry typeRegistry, bool formatEnumsAsIntegers, bool preserveProtoFieldNames) {} // 0x000000018A67043C-0x000000018A670760
	
			// Methods
			public Settings WithFormatDefaultValues(bool formatDefaultValues) => default; // 0x000000018A66E648-0x000000018A66E6F4
			public Settings WithTypeRegistry(TypeRegistry typeRegistry) => default; // 0x000000018A66E780-0x000000018A66E88C
			public Settings WithFormatEnumsAsIntegers(bool formatEnumsAsIntegers) => default; // 0x000000018A66E0DC-0x000000018A66E1E0
			public Settings WithPreserveProtoFieldNames(bool preserveProtoFieldNames) => default; // 0x000000018A6708FC-0x000000018A670948
		}
	
		private static class OriginalEnumValueHelper // TypeDefIndex: 53323
		{
			// Fields
			private static readonly Dictionary<System.Type, Dictionary<object, string>> dictionaries; // 0x00
	
			// Nested types
			[Serializable]
			private sealed class __c // TypeDefIndex: 53322
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<System.Reflection.FieldInfo, bool> __9__2_0; // 0x08
				public static Func<System.Reflection.FieldInfo, bool> __9__2_1; // 0x10
				public static Func<System.Reflection.FieldInfo, object> __9__2_2; // 0x18
				public static Func<System.Reflection.FieldInfo, string> __9__2_3; // 0x20
	
				// Constructors
				static __c() {} // 0x000000018A66E2FC-0x000000018A66E648
				public __c() {} // 0x000000018A6714A8-0x000000018A671AF0
	
				// Methods
				internal bool _GetNameMapping_b__2_0(System.Reflection.FieldInfo f) => default; // 0x000000018A671AF0-0x000000018A671F60
				internal bool _GetNameMapping_b__2_1(System.Reflection.FieldInfo f) => default; // 0x000000018A67131C-0x000000018A6714A8
				internal object _GetNameMapping_b__2_2(System.Reflection.FieldInfo f) => default; // 0x000000018A66FF60-0x000000018A6700EC
				internal string _GetNameMapping_b__2_3(System.Reflection.FieldInfo f) => default; // 0x000000018A6700EC-0x000000018A6701F8
			}
	
			// Constructors
			static OriginalEnumValueHelper() {} // 0x000000018A670EEC-0x000000018A67131C
	
			// Methods
			internal static string GetOriginalName(object value) => default; // 0x000000018A66E88C-0x000000018A66EC48
			private static Dictionary<object, string> GetNameMapping(System.Type enumType) => default; // 0x000000018A66EC48-0x000000018A66EED4
		}
	
		// Constructors
		public JsonFormatter() {} // Dummy constructor
		static JsonFormatter() {} // 0x000000018A6701F8-0x000000018A67043C
		public JsonFormatter(Settings settings) {} // 0x000000018A670948-0x000000018A670C6C
	
		// Methods
		public string Format(IMessage message) => default; // 0x000000018A66E1E0-0x000000018A66E2FC
		public void Format(IMessage message, TextWriter writer) {} // 0x000000018A67D0A0-0x000000018A67D0F0
		public static string ToDiagnosticString(IMessage message) => default; // 0x000000018A67CDBC-0x000000018A67CE30
		private void WriteMessage(TextWriter writer, IMessage message) {} // 0x0000000181C2FD60-0x0000000181C2FD70
		private bool WriteMessageFields(TextWriter writer, IMessage message, bool assumeFirstFieldWritten) => default; // 0x0000000181377E40-0x0000000181377E50
		private bool ShouldFormatFieldValue(IMessage message, FieldDescriptor field, object value) => default; // 0x00000001813ECBF0-0x00000001813ECC00
		internal static string ToJsonName(string name) => default; // 0x00000001813ECBD0-0x00000001813ECBE0
		internal static string FromJsonName(string name) => default; // 0x000000018A67CEA4-0x000000018A67CEFC
		private static void WriteNull(TextWriter writer) {} // 0x000000018A67CF70-0x000000018A67CF90
		private static bool IsDefaultValue(FieldDescriptor descriptor, object value) => default; // 0x000000018A67CF90-0x000000018A67D018
		public void WriteValue(TextWriter writer, object value) {} // 0x000000018A67C984-0x000000018A67CA20
		private void WriteWellKnownTypeValue(TextWriter writer, MessageDescriptor descriptor, object value) {} // 0x000000018A67CC68-0x000000018A67CD04
		private void WriteTimestamp(TextWriter writer, IMessage value) {} // 0x000000018A67CA20-0x000000018A67CABC
		private void WriteDuration(TextWriter writer, IMessage value) {} // 0x000000018A67CB44-0x000000018A67CBE0
		private void WriteFieldMask(TextWriter writer, IMessage value) {} // 0x000000018A67C028-0x000000018A67C22C
		private void WriteAny(TextWriter writer, IMessage value) {} // 0x000000018A67BCCC-0x000000018A67C028
		private void WriteDiagnosticOnlyAny(TextWriter writer, IMessage value) {} // 0x000000018A67C22C-0x000000018A67C2B8
		private void WriteStruct(TextWriter writer, IMessage message) {} // 0x000000018A67DE0C-0x000000018A67DE70
		private void WriteStructFieldValue(TextWriter writer, IMessage message) {} // 0x0000000185492010-0x0000000185492020
		internal void WriteList(TextWriter writer, IList list) {} // 0x000000018A67D68C-0x000000018A67D6AC
		internal void WriteDictionary(TextWriter writer, IDictionary dictionary) {} // 0x000000018A67D6AC-0x000000018A67D710
		internal static void WriteString(TextWriter writer, string text) {} // 0x000000018A67D710-0x000000018A67D730
		private static void HexEncodeUtf16CodeUnit(TextWriter writer, char c) {} // 0x000000018A67D730-0x000000018A67D7AC
	}

	public sealed class JsonParser // TypeDefIndex: 53327
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
		public static JsonParser Default { get => default; } // 0x000000018A67320C-0x000000018A673398 
	
		// Nested types
		public sealed class Settings // TypeDefIndex: 53325
		{
			// Fields
			private static readonly Settings _Default_k__BackingField; // 0x00
			private readonly int _RecursionLimit_k__BackingField; // 0x10
			private readonly TypeRegistry _TypeRegistry_k__BackingField; // 0x18
			private readonly bool _IgnoreUnknownFields_k__BackingField; // 0x20
	
			// Properties
			public static Settings Default { get; } // 0x000000018A67544C-0x000000018A6754E8 
			public int RecursionLimit { get; } // 0x000000018A67800C-0x000000018A678074 
			public TypeRegistry TypeRegistry { get; } // 0x000000018A675A88-0x000000018A675B10 
			public bool IgnoreUnknownFields { get; } // 0x000000018A6759A8-0x000000018A675A88 
	
			// Constructors
			public Settings() {} // Dummy constructor
			static Settings() {} // 0x000000018A678074-0x000000018A6780C4
			private Settings(int recursionLimit, TypeRegistry typeRegistry, bool ignoreUnknownFields) {} // 0x000000018A6754E8-0x000000018A6759A8
			public Settings(int recursionLimit) {} // 0x000000018A6740B4-0x000000018A674238
			public Settings(int recursionLimit, TypeRegistry typeRegistry) {} // 0x000000018A6744C4-0x000000018A6746AC
	
			// Methods
			public Settings WithIgnoreUnknownFields(bool ignoreUnknownFields) => default; // 0x000000018A674238-0x000000018A6744C4
			public Settings WithRecursionLimit(int recursionLimit) => default; // 0x000000018A673420-0x000000018A6734A0
			public Settings WithTypeRegistry(TypeRegistry typeRegistry) => default; // 0x000000018A673398-0x000000018A673420
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53326
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A676C60-0x000000018A676FCC
			public __c() {}
	
			// Methods
			internal bool _.cctor_b__41_0(EnumDescriptor ed) => default;
			internal void _.cctor_b__41_1(JsonParser parser, IMessage message, JsonTokenizer tokenizer) {} // 0x000000018A677094-0x000000018A677178
			internal void _.cctor_b__41_2(JsonParser parser, IMessage message, JsonTokenizer tokenizer) {} // 0x000000018A676FCC-0x000000018A677094
			internal void _.cctor_b__41_3(JsonParser parser, IMessage message, JsonTokenizer tokenizer) {} // 0x000000018A6746AC-0x000000018A6749D0
			internal void _.cctor_b__41_4(JsonParser parser, IMessage message, JsonTokenizer tokenizer) {} // 0x000000018A6749D0-0x000000018A674AF0
			internal void _.cctor_b__41_5(JsonParser parser, IMessage message, JsonTokenizer tokenizer) {} // 0x000000018A6734A0-0x000000018A6738CC
			internal void _.cctor_b__41_6(JsonParser parser, IMessage message, JsonTokenizer tokenizer) {} // 0x000000018A6752E8-0x000000018A67544C
			internal void _.cctor_b__41_7(JsonParser parser, IMessage message, JsonTokenizer tokenizer) {} // 0x000000018A675B40-0x000000018A675FAC
		}
	
		// Constructors
		public JsonParser() {} // Dummy constructor
		public JsonParser(Settings settings) {} // 0x000000018A676590-0x000000018A676C60
		static JsonParser() {} // 0x000000018A67DA1C-0x000000018A67DA84
	
		// Methods
		private static void MergeWrapperField(JsonParser parser, IMessage message, JsonTokenizer tokenizer) {} // 0x000000018A675FAC-0x000000018A676590
		internal void Merge(IMessage message, string json) {} // 0x000000018A675B10-0x000000018A675B40
		internal void Merge(IMessage message, TextReader jsonReader) {}
		private void Merge(IMessage message, JsonTokenizer tokenizer) {} // 0x000000018A677328-0x000000018A677448
		private void MergeField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer) {} // 0x000000018A674AF0-0x000000018A6752E8
		private void MergeRepeatedField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer) {} // 0x000000018A6738CC-0x000000018A673EEC
		private void MergeMapField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer) {} // 0x000000018A673EEC-0x000000018A6740B4
		private static bool IsGoogleProtobufValueField(FieldDescriptor field) => default; // 0x000000018A677178-0x000000018A677328
		private static bool IsGoogleProtobufNullValueField(FieldDescriptor field) => default; // 0x000000018A677448-0x000000018A67800C
		private object ParseSingleValue(FieldDescriptor field, JsonTokenizer tokenizer) => default; // 0x000000018A67D0F0-0x000000018A67D140
		public T Parse<T>(string json)
			where T : IMessage, new() => default; // 0x000000018A67CE30-0x000000018A67CEA4
		public T Parse<T>(TextReader jsonReader)
			where T : IMessage, new() => default; // 0x0000000181C0BBD0-0x0000000181C0BBE0
		public IMessage Parse(string json, MessageDescriptor descriptor) => default; // 0x0000000181377E40-0x0000000181377E50
		public IMessage Parse(TextReader jsonReader, MessageDescriptor descriptor) => default; // 0x00000001813ECBF0-0x00000001813ECC00
		private void MergeStructValue(IMessage message, JsonTokenizer tokenizer) {} // 0x000000018A67D018-0x000000018A67D0A0
		private void MergeStruct(IMessage message, JsonTokenizer tokenizer) {} // 0x000000018A67CF18-0x000000018A67CF70
		private void MergeAny(IMessage message, JsonTokenizer tokenizer) {} // 0x000000018A67CEFC-0x000000018A67CF18
		private void MergeWellKnownTypeAnyBody(IMessage body, JsonTokenizer tokenizer) {} // 0x000000018A67CABC-0x000000018A67CB44
		private static object ParseMapKey(FieldDescriptor field, string keyText) => default; // 0x000000018A67CBE0-0x000000018A67CC68
		private static object ParseSingleNumberValue(FieldDescriptor field, JsonToken token) => default; // 0x000000018A67CD04-0x000000018A67CDBC
		private static void CheckInteger(double value) {} // 0x000000018A67DD44-0x000000018A67DDA8
		private static object ParseSingleStringValue(FieldDescriptor field, string text) => default; // 0x0000000185492010-0x0000000185492020
		private static IMessage NewMessageForField(FieldDescriptor field) => default; // 0x000000018A67D7AC-0x000000018A67D820
		private static T ParseNumericString<T>(string text, Func<string, NumberStyles, IFormatProvider, T> parser) => default; // 0x000000018A67D820-0x000000018A67D888
		private static void ValidateInfinityAndNan(string text, bool isPositiveInfinity, bool isNegativeInfinity, bool isNaN) {} // 0x000000018A67D888-0x000000018A67D8F0
		private static void MergeTimestamp(IMessage message, JsonToken token) {} // 0x000000018A67D8F0-0x000000018A67D920
		private static void MergeDuration(IMessage message, JsonToken token) {} // 0x000000018A67D920-0x000000018A67D9BC
		private static void MergeFieldMask(IMessage message, JsonToken token) {} // 0x000000018A67D9BC-0x000000018A67D9EC
		private static string ToSnakeCase(string text) => default; // 0x000000018A67D9EC-0x000000018A67DA1C
	}

	internal sealed class JsonToken : IEquatable<JsonToken> // TypeDefIndex: 53329
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
		internal static JsonToken Null { get => default; } // 0x000000018A67A34C-0x000000018A67A39C 
		internal static JsonToken False { get => default; } // 0x000000018A67A2FC-0x000000018A67A34C 
		internal static JsonToken True { get => default; } // 0x000000018A67A43C-0x000000018A67A48C 
		internal static JsonToken StartObject { get => default; } // 0x000000018A67A3EC-0x000000018A67A43C 
		internal static JsonToken EndObject { get => default; } // 0x000000018A67A2AC-0x000000018A67A2FC 
		internal static JsonToken StartArray { get => default; } // 0x000000018A67A39C-0x000000018A67A3EC 
		internal static JsonToken EndArray { get => default; } // 0x000000018A67A20C-0x000000018A67A25C 
		internal static JsonToken EndDocument { get => default; } // 0x000000018A67A25C-0x000000018A67A2AC 
		internal TokenType Type { get => default; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
		internal string StringValue { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		internal double NumberValue { get => default; } // 0x0000000181448670-0x0000000181448680 
	
		// Nested types
		internal enum TokenType // TypeDefIndex: 53328
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
		private JsonToken(TokenType type, string stringValue = null, double numberValue = 0 /* Metadata: 0x0207808E */) {} // 0x000000018A67A1E8-0x000000018A67A20C
		static JsonToken() {} // 0x000000018A679EFC-0x000000018A67A1E8
	
		// Methods
		internal static JsonToken Name(string name) => default; // 0x000000018A679B84-0x000000018A679BF0
		internal static JsonToken Value(string value) => default; // 0x000000018A679E90-0x000000018A679EFC
		internal static JsonToken Value(double value) => default; // 0x000000018A679E24-0x000000018A679E90
		public override bool Equals(object obj) => default; // 0x000000018A679AAC-0x000000018A679B10
		public override int GetHashCode() => default; // 0x000000018A679B10-0x000000018A679B84
		public override string ToString() => default; // 0x000000018A679BF0-0x000000018A679E24
		public bool Equals(JsonToken other) => default; // 0x000000018A679A58-0x000000018A679AAC
	}

	internal abstract class JsonTokenizer // TypeDefIndex: 53335
	{
		// Fields
		private JsonToken bufferedToken; // 0x10
		private int _ObjectDepth_k__BackingField; // 0x18
	
		// Properties
		internal int ObjectDepth { get; private set; } // 0x000000018A678A68-0x000000018A678BA0 0x000000018A679934-0x000000018A679970
	
		// Nested types
		private class JsonReplayTokenizer : JsonTokenizer // TypeDefIndex: 53330
		{
			// Fields
			private readonly IList<JsonToken> tokens; // 0x20
			private readonly JsonTokenizer nextTokenizer; // 0x28
			private int nextTokenIndex; // 0x30
	
			// Constructors
			public JsonReplayTokenizer() {} // Dummy constructor
			internal JsonReplayTokenizer(IList<JsonToken> tokens, JsonTokenizer nextTokenizer) {} // 0x000000018A67A4FC-0x000000018A67A55C
	
			// Methods
			protected override JsonToken NextImpl() => default; // 0x000000018A67A48C-0x000000018A67A4FC
		}
	
		private sealed class JsonTextTokenizer : JsonTokenizer // TypeDefIndex: 53334
		{
			// Fields
			private static readonly State ValueStates; // 0x00
			private readonly Stack<ContainerType> containerStack; // 0x20
			private readonly PushBackReader reader; // 0x28
			private State state; // 0x30
	
			// Nested types
			private enum ContainerType // TypeDefIndex: 53331
			{
				Document = 0,
				Object = 1,
				Array = 2
			}
	
			private enum State // TypeDefIndex: 53332
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
	
			private class PushBackReader // TypeDefIndex: 53333
			{
				// Fields
				private readonly TextReader reader; // 0x10
				private char? nextChar; // 0x18
	
				// Constructors
				public PushBackReader() {} // Dummy constructor
				internal PushBackReader(TextReader reader) {} // 0x00000001813AE560-0x00000001813AE570
	
				// Methods
				internal char? Read() => default; // 0x00000001813AE9C0-0x00000001813AE9D0
				internal char ReadOrFail(string messageOnFailure) => default; // 0x000000018A67A5CC-0x000000018A67A664
				internal void PushBack(char c) {} // 0x000000018A67A55C-0x000000018A67A5CC
				internal InvalidJsonException CreateException(string message) => default;
			}
	
			// Constructors
			public JsonTextTokenizer() {} // Dummy constructor
			internal JsonTextTokenizer(TextReader reader) {} // 0x000000018A67A664-0x000000018A67A6B4
			static JsonTextTokenizer() {} // 0x000000018A678D0C-0x000000018A678EF8
	
			// Methods
			protected override JsonToken NextImpl() => default; // 0x0000000185492010-0x0000000185492020
			private void ValidateState(State validStates, string errorPrefix) {} // 0x000000018A678154-0x000000018A67817C
			private string ReadString() => default; // 0x000000018A6780C4-0x000000018A678154
			private char ReadEscapedCharacter() => default; // 0x000000018A679970-0x000000018A679A58
			private char ReadUnicodeEscape() => default; // 0x000000018A6783A8-0x000000018A678A68
			private void ConsumeLiteral(string text) {} // 0x000000018A679898-0x000000018A679934
			private double ReadNumber(char initialCharacter) => default; // 0x000000018A679438-0x000000018A679670
			private char? ReadInt(StringBuilder builder) => default; // 0x000000018A678BA0-0x000000018A678D0C
			private char? ReadFrac(StringBuilder builder) => default; // 0x000000018A679670-0x000000018A6797A8
			private char? ReadExp(StringBuilder builder) => default; // 0x000000018A678254-0x000000018A6783A8
			private char? ConsumeDigits(StringBuilder builder, out int count) {
				count = default;
				return default;
			} // 0x000000018A6790BC-0x000000018A679438
			private void ValidateAndModifyStateForValue(string errorPrefix) {} // 0x000000018A678F8C-0x000000018A6790BC
			private void PopContainer() {} // 0x000000018A678EF8-0x000000018A678F8C
		}
	
		// Constructors
		protected JsonTokenizer() {} // 0x000000018A67C764-0x000000018A67C7C4
	
		// Methods
		internal static JsonTokenizer FromTextReader(TextReader reader) => default; // 0x000000018A67817C-0x000000018A678254
		internal static JsonTokenizer FromReplayedTokens(IList<JsonToken> tokens, JsonTokenizer continuation) => default; // 0x000000018A6797A8-0x000000018A679898
		internal void PushBack(JsonToken token) {} // 0x0000000184096E30-0x0000000184096EF0
		internal JsonToken Next() => default; // 0x000000018A67C908-0x000000018A67C984
		protected abstract JsonToken NextImpl(); // 0x000000018A67C878-0x000000018A67C908
		internal void SkipValue() {} // 0x000000018A67C7C4-0x000000018A67C878
	}

	internal sealed class LimitedInputStream : Stream // TypeDefIndex: 53336
	{
		// Fields
		private readonly Stream proxied; // 0x28
		private int bytesLeft; // 0x30
	
		// Properties
		public override bool CanRead { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override bool CanSeek { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override bool CanWrite { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override long Length { get => default; } // 0x000000018A67A898-0x000000018A67A8E4 
		public override long Position { get => default; set {} } // 0x000000018A67A8E4-0x000000018A67A930 0x000000018A67A930-0x000000018A67A97C
	
		// Constructors
		public LimitedInputStream() {} // Dummy constructor
		internal LimitedInputStream(Stream proxied, int size) {} // 0x000000018A67A838-0x000000018A67A898
	
		// Methods
		public override void Flush() {} // 0x0000000185492010-0x0000000185492020
		public override int Read(byte[] buffer, int offset, int count) => default; // 0x000000018A67A6B4-0x000000018A67A754
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x000000018A67A754-0x000000018A67A7A0
		public override void SetLength(long value) {} // 0x000000018A67A7A0-0x000000018A67A7EC
		public override void Write(byte[] buffer, int offset, int count) {} // 0x000000018A67A7EC-0x000000018A67A838
	}

	public static class MessageExtensions // TypeDefIndex: 53338
	{
		// Nested types
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 53337
		{
			// Fields
			public IMessage message; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x000000018A67AD5C-0x000000018A67AD7C
	
			// Methods
			internal bool _IsInitialized_b__0(FieldDescriptor f) => default; // 0x0000000186470E18-0x0000000186470E38
		}
	
		// Methods
		public static void MergeFrom(IMessage message, byte[] data) {} // 0x000000018A67AC24-0x000000018A67AC44
		public static void MergeFrom(IMessage message, byte[] data, int offset, int length) {} // 0x000000018A67AC44-0x000000018A67AC64
		public static void MergeFrom(IMessage message, ByteString data) {} // 0x0000000186470DDC-0x0000000186470E08
		public static void MergeFrom(IMessage message, Stream input) {} // 0x000000018A67AC04-0x000000018A67AC24
		public static void MergeFrom(IMessage message, ReadOnlySpan<byte> span) {} // 0x000000018A67B084-0x000000018A67B174
		public static void MergeDelimitedFrom(IMessage message, Stream input) {} // 0x00000001843CEB70-0x00000001843CED30
		public static byte[] ToByteArray(IMessage message) => default; // 0x000000018A67B2FC-0x000000018A67B3E8
		public static int WriteToByteArray(IMessage message, byte[] buffer, int pos) => default; // 0x000000018A67B1F0-0x000000018A67B2FC
		public static void WriteTo(IMessage message, Stream output) {} // 0x000000018A67B174-0x000000018A67B1F0
		public static void WriteDelimitedTo(IMessage message, Stream output) {} // 0x000000018A67B4BC-0x000000018A67B5C4
		public static ByteString ToByteString(IMessage message) => default; // 0x000000018A67B3E8-0x000000018A67B4BC
		public static void WriteTo(IMessage message, IBufferWriter<byte> output) {} // 0x000000018A67A97C-0x000000018A67AB00
		public static void WriteTo(IMessage message, Span<byte> output) {} // 0x000000018A67AD7C-0x000000018A67AE98
		public static bool IsInitialized(IMessage message) => default; // 0x00000001843CE4E0-0x00000001843CE6A0
		internal static void MergeFrom(IMessage message, byte[] data, bool discardUnknownFields, ExtensionRegistry registry) {} // 0x000000018A67AC64-0x000000018A67AD5C
		internal static void MergeFrom(IMessage message, byte[] data, int offset, int length, bool discardUnknownFields, ExtensionRegistry registry) {} // 0x000000018A67AE98-0x000000018A67AFB8
		internal static void MergeFrom(IMessage message, ByteString data, bool discardUnknownFields, ExtensionRegistry registry) {} // 0x000000018A67AFB8-0x000000018A67B084
		internal static void MergeFrom(IMessage message, Stream input, bool discardUnknownFields, ExtensionRegistry registry) {} // 0x0000000184F1DB20-0x0000000184F1DC90
		internal static void MergeFrom(IMessage message, ReadOnlySequence<byte> data, bool discardUnknownFields, ExtensionRegistry registry) {} // 0x000000018A67AB00-0x000000018A67AC04
		internal static void MergeFrom(IMessage message, ReadOnlySpan<byte> data, bool discardUnknownFields, ExtensionRegistry registry) {} // 0x0000000185492010-0x0000000185492020
		internal static void MergeDelimitedFrom(IMessage message, Stream input, bool discardUnknownFields, ExtensionRegistry registry) {} // 0x000000018A67DAFC-0x000000018A67DD44
	}

	public class MessageParser // TypeDefIndex: 53339
	{
		// Fields
		private Func<IMessage> factory; // 0x10
		private readonly bool _DiscardUnknownFields_k__BackingField; // 0x18
		private readonly ExtensionRegistry _Extensions_k__BackingField; // 0x20
	
		// Properties
		internal bool DiscardUnknownFields { get; } // 0x00000001813C0430-0x00000001813C0440 
		internal ExtensionRegistry Extensions { get; } // 0x00000001813B31A0-0x00000001813B31B0 
	
		// Constructors
		public MessageParser() {} // Dummy constructor
		internal MessageParser(Func<IMessage> factory, bool discardUnknownFields, ExtensionRegistry extensions) {} // 0x00000001851974C0-0x00000001851974F0
	
		// Methods
		internal IMessage CreateTemplate() => default; // 0x000000018A67B5C4-0x000000018A67B5E4
		public IMessage ParseFrom(byte[] data) => default; // 0x000000018A67B940-0x000000018A67B99C
		public IMessage ParseFrom(byte[] data, int offset, int length) => default; // 0x000000018A67B804-0x000000018A67B888
		public IMessage ParseFrom(ByteString data) => default; // 0x000000018A67B8E4-0x000000018A67B940
		public IMessage ParseFrom(Stream input) => default; // 0x000000018A67B888-0x000000018A67B8E4
		public IMessage ParseFrom(ReadOnlySequence<byte> data) => default; // 0x000000018A67BA04-0x000000018A67BA74
		public IMessage ParseFrom(ReadOnlySpan<byte> data) => default; // 0x000000018A67B99C-0x000000018A67BA04
		public IMessage ParseDelimitedFrom(Stream input) => default; // 0x000000018A67B7A8-0x000000018A67B804
		public IMessage ParseFrom(CodedInputStream input) => default; // 0x000000018A67BA74-0x000000018A67BAC8
		public IMessage ParseJson(string json) => default; // 0x000000018A67BAC8-0x000000018A67BB44
		internal void MergeFrom(IMessage message, CodedInputStream codedInput) {} // 0x000000018A67B5E4-0x000000018A67B7A8
		public MessageParser WithDiscardUnknownFields(bool discardUnknownFields) => default; // 0x000000018A67BB44-0x000000018A67BBCC
		public MessageParser WithExtensionRegistry(ExtensionRegistry registry) => default; // 0x000000018A67BBCC-0x000000018A67BC54
	}

	public sealed class MessageParser<T> : MessageParser // TypeDefIndex: 53341
		where T : IMessage<T>
	{
		// Fields
		private readonly Func<T> factory;
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 53340
		{
			// Fields
			public Func<T> factory;
	
			// Constructors
			public __c__DisplayClass2_0() {}
	
			// Methods
			internal IMessage _.ctor_b__0() => default;
		}
	
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

	internal struct ObjectIntPair<T> : IEquatable<ObjectIntPair<T>> // TypeDefIndex: 53342
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

	public struct ParseContext // TypeDefIndex: 53343
	{
		// Fields
		internal const int DefaultRecursionLimit = 100; // Metadata: 0x020780B4
		internal const int DefaultSizeLimit = 2147483647; // Metadata: 0x020780B6
		internal ReadOnlySpan<byte> buffer; // 0x00
		internal ParserInternalState state; // 0x10
	
		// Properties
		internal uint LastTag { get => default; } // 0x0000000185FB0690-0x0000000185FB06A0 
		internal bool DiscardUnknownFields { get => default; set {} } // 0x0000000185FB2E40-0x0000000185FB2E50 0x0000000185FB2EA0-0x0000000185FB2EB0
		internal ExtensionRegistry ExtensionRegistry { get => default; set {} } // 0x0000000185FB0510-0x0000000185FB0520 0x0000000186472AA8-0x0000000186472ABC
	
		// Methods
		internal static void Initialize(ReadOnlySpan<byte> buffer, out ParseContext ctx) {
			ctx = default;
		} // 0x000000018A67C4A8-0x000000018A67C56C
		internal static void Initialize(ReadOnlySpan<byte> buffer, ref ParserInternalState state, out ParseContext ctx) {
			ctx = default;
		} // 0x0000000185FCC7C0-0x0000000185FCC830
		internal static void Initialize(CodedInputStream input, out ParseContext ctx) {
			ctx = default;
		} // 0x000000018A67C3DC-0x000000018A67C4A8
		internal static void Initialize(ReadOnlySequence<byte> input, out ParseContext ctx) {
			ctx = default;
		} // 0x000000018A67C3B0-0x000000018A67C3DC
		internal static void Initialize(ReadOnlySequence<byte> input, int recursionLimit, out ParseContext ctx) {
			ctx = default;
		} // 0x000000018A67C2FC-0x000000018A67C3B0
		public uint ReadTag() => default; // 0x000000018A67C758-0x000000018A67C764
		public double ReadDouble() => default; // 0x000000018A67C608-0x000000018A67C614
		public float ReadFloat() => default; // 0x000000018A67C638-0x000000018A67C644
		public ulong ReadUInt64() => default; // 0x000000018A67C6A0-0x000000018A67C6AC
		public long ReadInt64() => default; // 0x000000018A67C6A0-0x000000018A67C6AC
		public int ReadInt32() => default; // 0x000000018A67C614-0x000000018A67C620
		public ulong ReadFixed64() => default; // 0x000000018A67C62C-0x000000018A67C638
		public uint ReadFixed32() => default; // 0x000000018A67C620-0x000000018A67C62C
		public bool ReadBool() => default; // 0x000000018A67C5E0-0x000000018A67C5FC
		public string ReadString() => default; // 0x000000018A67C74C-0x000000018A67C758
		public void ReadMessage(IMessage message) {} // 0x000000018A67C6AC-0x000000018A67C708
		public void ReadGroup(IMessage message) {} // 0x000000018A67C644-0x000000018A67C6A0
		public ByteString ReadBytes() => default; // 0x000000018A67C5FC-0x000000018A67C608
		public uint ReadUInt32() => default; // 0x000000018A67C614-0x000000018A67C620
		public int ReadEnum() => default; // 0x000000018A67C614-0x000000018A67C620
		public int ReadSFixed32() => default; // 0x000000018A67C620-0x000000018A67C62C
		public long ReadSFixed64() => default; // 0x000000018A67C62C-0x000000018A67C638
		public int ReadSInt32() => default; // 0x000000018A67C708-0x000000018A67C728
		public long ReadSInt64() => default; // 0x000000018A67C728-0x000000018A67C74C
		public int ReadLength() => default; // 0x000000018A67C614-0x000000018A67C620
		internal void CopyStateTo(CodedInputStream input) {} // 0x00000001850DA0C0-0x00000001850DA140
		internal void LoadStateFrom(CodedInputStream input) {} // 0x000000018A67C56C-0x000000018A67C5E0
	}

	internal struct ParserInternalState // TypeDefIndex: 53344
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
		private bool _DiscardUnknownFields_k__BackingField; // 0x74
		private ExtensionRegistry _ExtensionRegistry_k__BackingField; // 0x78
	
		// Properties
		internal CodedInputStream CodedInputStream { get => default; } // 0x00000001813F1630-0x00000001813F1640 
		internal bool DiscardUnknownFields { get; set; } // 0x0000000185FB9F40-0x0000000185FB9F50 0x0000000185FBD4F0-0x0000000185FBD500
		internal ExtensionRegistry ExtensionRegistry { get; set; } // 0x0000000183060C50-0x0000000183060C60 0x000000018738A324-0x000000018738A334
	}

	internal static class ParsingPrimitives // TypeDefIndex: 53345
	{
		// Fields
		private const int StackallocThreshold = 256; // Metadata: 0x020780B7
	
		// Methods
		public static int ParseLength(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A686CF4-0x000000018A686CFC
		public static uint ParseTag(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x0000000184055C40-0x0000000184055D60
		public static bool MaybeConsumeTag(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, uint tag) => default; // 0x0000000184342E30-0x0000000184342E90
		public static uint PeekTag(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x0000000184342E90-0x0000000184342ED0
		public static ulong ParseRawVarint64(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x00000001841A2420-0x00000001841A2520
		private static ulong ParseRawVarint64SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x00000001841A2520-0x00000001841A25A0
		public static uint ParseRawVarint32(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x0000000184055D60-0x0000000184055ED0
		private static uint ParseRawVarint32SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x0000000184056C50-0x0000000184056D50
		public static uint ParseRawLittleEndian32(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A686D88-0x000000018A686E14
		private static uint ParseRawLittleEndian32SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A686CFC-0x000000018A686D88
		public static ulong ParseRawLittleEndian64(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A686F10-0x000000018A686F9C
		private static ulong ParseRawLittleEndian64SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A686E14-0x000000018A686F10
		public static double ParseDouble(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x0000000184FEA2E0-0x0000000184FEA3E0
		public static float ParseFloat(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x0000000184DBDF00-0x0000000184DBE060
		private static float ParseFloatSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A686BD0-0x000000018A686CF4
		public static byte[] ReadRawBytes(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size) => default; // 0x000000018419B2A0-0x000000018419B920
		private static byte[] ReadRawBytesSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size) => default; // 0x000000018A687174-0x000000018A6875C0
		public static void SkipRawBytes(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size) {} // 0x000000018A6876E4-0x000000018A687798
		public static string ReadString(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A6876B0-0x000000018A6876E4
		public static ByteString ReadBytes(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A686F9C-0x000000018A68700C
		public static string ReadRawString(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int length) => default; // 0x000000018419C850-0x000000018419CFA0
		private static string ReadStringSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int length) => default; // 0x000000018419B920-0x000000018419C030
		private static void ValidateCurrentLimit(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size) {} // 0x0000000184E11100-0x0000000184E11120
		private static byte ReadRawByte(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x0000000184055C00-0x0000000184055C40
		public static uint ReadRawVarint32(Stream input) => default; // 0x000000018A6875C0-0x000000018A6876B0
		public static int DecodeZigZag32(uint n) => default; // 0x0000000185FCC830-0x0000000185FCC840
		public static long DecodeZigZag64(ulong n) => default; // 0x0000000185FCC840-0x0000000185FCC850
		public static bool IsDataAvailable(ref ParserInternalState state, int size) => default; // 0x0000000185121600-0x0000000185121620
		private static bool IsDataAvailableInSource(ref ParserInternalState state, int size) => default; // 0x000000018A686B24-0x000000018A686BD0
		private static void ReadRawBytesIntoSpan(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int length, Span<byte> byteSpan) {} // 0x000000018A68700C-0x000000018A687174
	}

	internal static class ParsingPrimitivesMessages // TypeDefIndex: 53346
	{
		// Fields
		private static readonly byte[] ZeroLengthMessageStreamData; // 0x00
	
		// Constructors
		static ParsingPrimitivesMessages() {} // 0x0000000185F639A0-0x0000000185F63A10
	
		// Methods
		public static void SkipLastField(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) {} // 0x000000018A685FD4-0x000000018A686170
		public static void SkipGroup(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, uint startGroupTag) {} // 0x000000018A685E48-0x000000018A685FD4
		public static void ReadMessage(ref ParseContext ctx, IMessage message) {} // 0x000000018419D750-0x000000018419D890
		public static KeyValuePair<TKey, TValue> ReadMapEntry<TKey, TValue>(ref ParseContext ctx, MapField<TKey, TValue> codec) => default;
		public static void ReadGroup(ref ParseContext ctx, IMessage message) {} // 0x000000018A685CEC-0x000000018A685D94
		public static void ReadGroup(ref ParseContext ctx, int fieldNumber, UnknownFieldSet set) {} // 0x000000018A685D94-0x000000018A685E48
		public static void ReadRawMessage(ref ParseContext ctx, IMessage message) {} // 0x000000018419D960-0x000000018419DE90
		public static void CheckReadEndOfStreamTag(ref ParserInternalState state) {} // 0x000000018419D920-0x000000018419D940
		private static void CheckLastTagWas(ref ParserInternalState state, uint expectedTag) {} // 0x000000018A685CB0-0x000000018A685CEC
	}

	internal static class ParsingPrimitivesWrappers // TypeDefIndex: 53347
	{
		// Methods
		internal static float? ReadFloatWrapperLittleEndian(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A686420-0x000000018A6864DC
		internal static float? ReadFloatWrapperSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A6864E8-0x000000018A6865C8
		internal static double? ReadDoubleWrapperLittleEndian(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A68623C-0x000000018A68630C
		internal static double? ReadDoubleWrapperSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A686338-0x000000018A686420
		internal static bool? ReadBoolWrapper(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A686170-0x000000018A686204
		internal static uint? ReadUInt32Wrapper(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A686804-0x000000018A6868E8
		internal static uint? ReadUInt32WrapperSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A68672C-0x000000018A686804
		internal static int? ReadInt32Wrapper(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A6865E0-0x000000018A686660
		internal static ulong? ReadUInt64Wrapper(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A686A04-0x000000018A686AF8
		internal static ulong? ReadUInt64WrapperSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A686920-0x000000018A686A04
		internal static long? ReadInt64Wrapper(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A68668C-0x000000018A68672C
		internal static float? ReadFloatWrapperLittleEndian(ref ParseContext ctx) => default; // 0x000000018A6864DC-0x000000018A6864E8
		internal static float? ReadFloatWrapperSlow(ref ParseContext ctx) => default; // 0x000000018A6865C8-0x000000018A6865D4
		internal static double? ReadDoubleWrapperLittleEndian(ref ParseContext ctx) => default; // 0x000000018A686210-0x000000018A68623C
		internal static double? ReadDoubleWrapperSlow(ref ParseContext ctx) => default; // 0x000000018A68630C-0x000000018A686338
		internal static bool? ReadBoolWrapper(ref ParseContext ctx) => default; // 0x000000018A686204-0x000000018A686210
		internal static uint? ReadUInt32Wrapper(ref ParseContext ctx) => default; // 0x000000018A6868E8-0x000000018A6868F4
		internal static int? ReadInt32Wrapper(ref ParseContext ctx) => default; // 0x000000018A6865D4-0x000000018A6865E0
		internal static ulong? ReadUInt64Wrapper(ref ParseContext ctx) => default; // 0x000000018A686AF8-0x000000018A686B24
		internal static ulong? ReadUInt64WrapperSlow(ref ParseContext ctx) => default; // 0x000000018A6868F4-0x000000018A686920
		internal static long? ReadInt64Wrapper(ref ParseContext ctx) => default; // 0x000000018A686660-0x000000018A68668C
	}

	public static class ProtoPreconditions // TypeDefIndex: 53348
	{
		// Methods
		public static T CheckNotNull<T>(T value, string name)
			where T : class => default;
		internal static T CheckNotNullUnconstrained<T>(T value, string name) => default;
	}

	internal struct SegmentedBufferHelper // TypeDefIndex: 53349
	{
		// Fields
		private int? totalLength; // 0x00
		private ReadOnlySequence<byte> readOnlySequenceEnumerator; // 0x08
		private CodedInputStream codedInputStream; // 0x40
	
		// Properties
		public int? TotalLength { get => default; } // 0x00000001834AFB60-0x00000001834AFB70 
		public CodedInputStream CodedInputStream { get => default; } // 0x00000001813FF010-0x00000001813FF020 
	
		// Methods
		public static void Initialize(CodedInputStream codedInputStream, out SegmentedBufferHelper instance) {
			instance = default;
		} // 0x000000018A687798-0x000000018A687830
		public static void Initialize(ReadOnlySequence<byte> sequence, out SegmentedBufferHelper instance, out ReadOnlySpan<byte> firstSpan) {
			instance = default;
			firstSpan = default;
		} // 0x000000018A687830-0x000000018A687A28
		public bool RefillBuffer(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, bool mustSucceed) => default; // 0x00000001840577E0-0x0000000184057810
		public static int PushLimit(ref ParserInternalState state, int byteLimit) => default; // 0x000000018419D890-0x000000018419D8F0
		public static void PopLimit(ref ParserInternalState state, int oldLimit) {} // 0x000000018646E01C-0x000000018646E028
		public static bool IsReachedLimit(ref ParserInternalState state) => default; // 0x000000018419D940-0x000000018419D960
		public static bool IsAtEnd(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) => default; // 0x000000018A687A28-0x000000018A687A5C
		private bool RefillFromReadOnlySequence(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, bool mustSucceed) => default; // 0x0000000185076570-0x0000000185076660
		private bool RefillFromCodedInputStream(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, bool mustSucceed) => default; // 0x0000000184057A90-0x0000000184057B50
		private static void RecomputeBufferSizeAfterLimit(ref ParserInternalState state) {} // 0x000000018419D8F0-0x000000018419D920
		private static void CheckCurrentBufferIsEmpty(ref ParserInternalState state) {} // 0x0000000184057B50-0x0000000184057B70
	}

	internal sealed class UnknownField // TypeDefIndex: 53350
	{
		// Fields
		private List<ulong> varintList; // 0x10
		private List<uint> fixed32List; // 0x18
		private List<ulong> fixed64List; // 0x20
		private List<ByteString> lengthDelimitedList; // 0x28
		private List<UnknownFieldSet> groupList; // 0x30
	
		// Constructors
		public UnknownField() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool Equals(object other) => default; // 0x000000018A68D2C8-0x000000018A68D3CC
		public override int GetHashCode() => default; // 0x000000018A68D3CC-0x000000018A68D4B4
		internal void WriteTo(int fieldNumber, ref WriteContext output) {} // 0x000000018A68DAC8-0x000000018A68E098
		internal int GetSerializedSize(int fieldNumber) => default; // 0x000000018A68D4B4-0x000000018A68D9B8
		internal UnknownField MergeFrom(UnknownField other) => default; // 0x000000018A68D9B8-0x000000018A68DAC8
		private static List<T> AddAll<T>(List<T> current, IList<T> extras) => default;
		internal UnknownField AddVarint(ulong value) => default; // 0x000000018A68D26C-0x000000018A68D2C8
		internal UnknownField AddFixed32(uint value) => default; // 0x000000018A68D100-0x000000018A68D158
		internal UnknownField AddFixed64(ulong value) => default; // 0x000000018A68D158-0x000000018A68D1B4
		internal UnknownField AddLengthDelimited(ByteString value) => default; // 0x000000018A68D210-0x000000018A68D26C
		internal UnknownField AddGroup(UnknownFieldSet value) => default; // 0x000000018A68D1B4-0x000000018A68D210
		private static List<T> Add<T>(List<T> list, T value) => default;
	}

	public sealed class UnknownFieldSet // TypeDefIndex: 53351
	{
		// Fields
		private readonly IDictionary<int, UnknownField> fields; // 0x10
		private int lastFieldNumber; // 0x18
		private UnknownField lastField; // 0x20
	
		// Constructors
		internal UnknownFieldSet() {} // 0x000000018A68D088-0x000000018A68D100
	
		// Methods
		internal bool HasField(int field) => default; // 0x000000018A68C648-0x000000018A68C6A0
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A68CDEC-0x000000018A68CEB0
		public void WriteTo(ref WriteContext ctx) {} // 0x000000018A68CEB0-0x000000018A68D088
		public int CalculateSize() => default; // 0x000000018A68C00C-0x000000018A68C170
		public override bool Equals(object other) => default; // 0x000000018A68C170-0x000000018A68C3FC
		public override int GetHashCode() => default; // 0x000000018A68C3FC-0x000000018A68C588
		private UnknownField GetOrAddField(int number) => default; // 0x000000018A68C588-0x000000018A68C648
		internal UnknownFieldSet AddOrReplaceField(int number, UnknownField field) => default; // 0x000000018A68BF44-0x000000018A68C00C
		private bool MergeFieldFrom(ref ParseContext ctx) => default; // 0x000000018A68C884-0x000000018A68CA78
		internal void MergeGroupFrom(ref ParseContext ctx) {} // 0x000000018A68CDA0-0x000000018A68CDEC
		public static UnknownFieldSet MergeFieldFrom(UnknownFieldSet unknownFields, CodedInputStream input) => default; // 0x000000018A68C798-0x000000018A68C884
		public static UnknownFieldSet MergeFieldFrom(UnknownFieldSet unknownFields, ref ParseContext ctx) => default; // 0x000000018A68C6A0-0x000000018A68C798
		private UnknownFieldSet MergeFrom(UnknownFieldSet other) => default; // 0x000000018A68CBC0-0x000000018A68CDA0
		public static UnknownFieldSet MergeFrom(UnknownFieldSet unknownFields, UnknownFieldSet other) => default; // 0x000000018A68CB48-0x000000018A68CBC0
		private UnknownFieldSet MergeField(int number, UnknownField field) => default; // 0x000000018A68CA78-0x000000018A68CB48
		public static UnknownFieldSet Clone(UnknownFieldSet other) => default; // 0x0000000185011220-0x0000000185011260
	}

	public static class UnsafeByteOperations // TypeDefIndex: 53352
	{
		// Methods
		public static ByteString UnsafeWrap(ReadOnlyMemory<byte> bytes) => default; // 0x000000018A68E098-0x000000018A68E0EC
	}

	public static class WireFormat // TypeDefIndex: 53354
	{
		// Fields
		private const int TagTypeBits = 3; // Metadata: 0x020780B9
		private const uint TagTypeMask = 7; // Metadata: 0x020780BA
	
		// Nested types
		public enum WireType : uint // TypeDefIndex: 53353
		{
			Varint = 0,
			Fixed64 = 1,
			LengthDelimited = 2,
			StartGroup = 3,
			EndGroup = 4,
			Fixed32 = 5
		}
	
		// Methods
		public static WireType GetTagWireType(uint tag) => default; // 0x0000000185FCC860-0x0000000185FCC870
		public static int GetTagFieldNumber(uint tag) => default; // 0x0000000185FCC850-0x0000000185FCC860
		public static uint MakeTag(int fieldNumber, WireType wireType) => default; // 0x0000000185FCC870-0x0000000185FCC880
	}

	internal struct WriteBufferHelper // TypeDefIndex: 53355
	{
		// Fields
		private IBufferWriter<byte> bufferWriter; // 0x00
		private CodedOutputStream codedOutputStream; // 0x08
	
		// Properties
		public CodedOutputStream CodedOutputStream { get => default; } // 0x000000018357A260-0x000000018357A270 
	
		// Methods
		public static void Initialize(CodedOutputStream codedOutputStream, out WriteBufferHelper instance) {
			instance = default;
		} // 0x00000001843CEE20-0x00000001843CEE50
		public static void Initialize(IBufferWriter<byte> bufferWriter, out WriteBufferHelper instance, out Span<byte> buffer) {
			instance = default;
			buffer = default;
		} // 0x000000018A6676F0-0x000000018A667724
		public static void InitializeNonRefreshable(out WriteBufferHelper instance) {
			instance = default;
		} // 0x000000018A6676CC-0x000000018A6676F0
		public static void CheckNoSpaceLeft(ref WriterInternalState state) {} // 0x000000018A66753C-0x000000018A667650
		public static int GetSpaceLeft(ref WriterInternalState state) => default; // 0x000000018A667650-0x000000018A6676CC
		public static void RefreshBuffer(ref Span<byte> buffer, ref WriterInternalState state) {} // 0x000000018A68F608-0x000000018A68F724
		public static void Flush(ref Span<byte> buffer, ref WriterInternalState state) {} // 0x000000018A68F560-0x000000018A68F608
	}

	public struct WriteContext // TypeDefIndex: 53356
	{
		// Fields
		internal Span<byte> buffer; // 0x00
		internal WriterInternalState state; // 0x10
	
		// Methods
		internal static void Initialize(ref Span<byte> buffer, ref WriterInternalState state, out WriteContext ctx) {
			ctx = default;
		} // 0x0000000185FCC880-0x0000000185FCC8A0
		internal static void Initialize(CodedOutputStream output, out WriteContext ctx) {
			ctx = default;
		} // 0x000000018A68F798-0x000000018A68F814
		internal static void Initialize(IBufferWriter<byte> output, out WriteContext ctx) {
			ctx = default;
		} // 0x000000018A68F814-0x000000018A68F87C
		internal static void Initialize(ref Span<byte> buffer, out WriteContext ctx) {
			ctx = default;
		} // 0x000000018A68F73C-0x000000018A68F798
		public void WriteDouble(double value) {} // 0x0000000184662B00-0x0000000184662B70
		public void WriteFloat(float value) {} // 0x0000000184664D50-0x0000000184664DC0
		public void WriteUInt64(ulong value) {} // 0x0000000184665900-0x00000001846659A0
		public void WriteInt64(long value) {} // 0x0000000184665A10-0x0000000184665AB0
		public void WriteInt32(int value) {} // 0x0000000184664F20-0x0000000184664F90
		public void WriteFixed64(ulong value) {} // 0x000000018A68F8F8-0x000000018A68F94C
		public void WriteFixed32(uint value) {} // 0x000000018A68F8A4-0x000000018A68F8F8
		public void WriteBool(bool value) {} // 0x0000000184662F40-0x0000000184662FB0
		public void WriteString(string value) {} // 0x0000000184666080-0x00000001846660F0
		public void WriteMessage(IMessage value) {} // 0x000000018646FB00-0x000000018646FB08
		public void WriteGroup(IMessage value) {} // 0x000000018A68F94C-0x000000018A68F954
		public void WriteBytes(ByteString value) {} // 0x0000000185590B80-0x0000000185590BF0
		public void WriteUInt32(uint value) {} // 0x0000000184664F90-0x00000001846650E0
		public void WriteEnum(int value) {} // 0x00000001846651F0-0x00000001846653C0
		public void WriteSFixed32(int value) {} // 0x000000018A68FAE0-0x000000018A68FB34
		public void WriteSFixed64(long value) {} // 0x000000018A68FB34-0x000000018A68FB88
		public void WriteSInt32(int value) {} // 0x000000018A68FB88-0x000000018A68FBDC
		public void WriteSInt64(long value) {} // 0x000000018A68FBDC-0x000000018A68FC30
		public void WriteLength(int length) {} // 0x0000000185B3DBF0-0x0000000185B3DC60
		public void WriteTag(int fieldNumber, WireFormat.WireType type) {} // 0x000000018A68FC30-0x000000018A68FC98
		public void WriteTag(uint tag) {} // 0x0000000184663CA0-0x0000000184663D10
		public void WriteRawTag(byte b1) {} // 0x0000000184664B40-0x0000000184664C30
		public void WriteRawTag(byte b1, byte b2) {} // 0x0000000184665770-0x0000000184665850
		public void WriteRawTag(byte b1, byte b2, byte b3) {} // 0x000000018A68F9D8-0x000000018A68FA54
		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4) {} // 0x000000018A68F954-0x000000018A68F9D8
		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5) {} // 0x000000018A68FA54-0x000000018A68FAE0
		internal void Flush() {} // 0x000000018A68F730-0x000000018A68F73C
		internal void CheckNoSpaceLeft() {} // 0x000000018A68F724-0x000000018A68F730
		internal void CopyStateTo(CodedOutputStream output) {} // 0x0000000185142060-0x0000000185142090
		internal void LoadStateFrom(CodedOutputStream output) {} // 0x000000018A68F87C-0x000000018A68F8A4
	}

	internal struct WriterInternalState // TypeDefIndex: 53357
	{
		// Fields
		internal int limit; // 0x00
		internal int position; // 0x04
		internal WriteBufferHelper writeBufferHelper; // 0x08
	
		// Properties
		internal CodedOutputStream CodedOutputStream { get => default; } // 0x000000018346D130-0x000000018346D140 
	}

	internal static class WritingPrimitives // TypeDefIndex: 53358
	{
		// Fields
		internal static readonly Encoding Utf8Encoding; // 0x00
	
		// Constructors
		static WritingPrimitives() {} // 0x0000000185F862D0-0x0000000185F86320
	
		// Methods
		public static void WriteDouble(ref Span<byte> buffer, ref WriterInternalState state, double value) {} // 0x0000000184662B70-0x0000000184662C10
		public static void WriteFloat(ref Span<byte> buffer, ref WriterInternalState state, float value) {} // 0x0000000184664DC0-0x0000000184664F20
		private static void WriteFloatSlowPath(ref Span<byte> buffer, ref WriterInternalState state, float value) {} // 0x000000018A69003C-0x000000018A6901D0
		public static void WriteUInt64(ref Span<byte> buffer, ref WriterInternalState state, ulong value) {} // 0x00000001846659A0-0x0000000184665A10
		public static void WriteInt64(ref Span<byte> buffer, ref WriterInternalState state, long value) {} // 0x0000000184665AB0-0x0000000184665B20
		public static void WriteInt32(ref Span<byte> buffer, ref WriterInternalState state, int value) {} // 0x0000000184665550-0x00000001846656A0
		public static void WriteFixed64(ref Span<byte> buffer, ref WriterInternalState state, ulong value) {} // 0x000000018A68FFDC-0x000000018A69003C
		public static void WriteFixed32(ref Span<byte> buffer, ref WriterInternalState state, uint value) {} // 0x000000018A68FF7C-0x000000018A68FFDC
		public static void WriteBool(ref Span<byte> buffer, ref WriterInternalState state, bool value) {} // 0x0000000184662FB0-0x0000000184663030
		public static void WriteString(ref Span<byte> buffer, ref WriterInternalState state, string value) {} // 0x00000001846660F0-0x0000000184666330
		private static void WriteAsciiStringToBuffer(Span<byte> buffer, ref WriterInternalState state, string value, int length) {} // 0x0000000184ABB680-0x0000000184ABB880
		private static void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(ref byte outputBuffer, ulong value) {} // 0x000000018A68FEF4-0x000000018A68FF7C
		private static int WriteStringToBuffer(Span<byte> buffer, ref WriterInternalState state, string value) => default; // 0x0000000184666330-0x00000001846664C0
		public static void WriteBytes(ref Span<byte> buffer, ref WriterInternalState state, ByteString value) {} // 0x0000000185590BF0-0x0000000185590CC0
		public static void WriteUInt32(ref Span<byte> buffer, ref WriterInternalState state, uint value) {} // 0x00000001846650E0-0x00000001846651F0
		public static void WriteEnum(ref Span<byte> buffer, ref WriterInternalState state, int value) {} // 0x00000001846653C0-0x0000000184665550
		public static void WriteSFixed32(ref Span<byte> buffer, ref WriterInternalState state, int value) {} // 0x000000018A690AE8-0x000000018A690B48
		public static void WriteSFixed64(ref Span<byte> buffer, ref WriterInternalState state, long value) {} // 0x000000018A690B48-0x000000018A690BA8
		public static void WriteSInt32(ref Span<byte> buffer, ref WriterInternalState state, int value) {} // 0x000000018A690BA8-0x000000018A690C14
		public static void WriteSInt64(ref Span<byte> buffer, ref WriterInternalState state, long value) {} // 0x000000018A690C14-0x000000018A690C80
		public static void WriteLength(ref Span<byte> buffer, ref WriterInternalState state, int length) {} // 0x00000001846646E0-0x0000000184664750
		public static void WriteRawVarint32(ref Span<byte> buffer, ref WriterInternalState state, uint value) {} // 0x00000001846656A0-0x0000000184665770
		public static void WriteRawVarint64(ref Span<byte> buffer, ref WriterInternalState state, ulong value) {} // 0x0000000184665B20-0x0000000184665C00
		public static void WriteRawLittleEndian32(ref Span<byte> buffer, ref WriterInternalState state, uint value) {} // 0x000000018A6903B8-0x000000018A690474
		private static void WriteRawLittleEndian32SlowPath(ref Span<byte> buffer, ref WriterInternalState state, uint value) {} // 0x000000018A690318-0x000000018A6903B8
		public static void WriteRawLittleEndian64(ref Span<byte> buffer, ref WriterInternalState state, ulong value) {} // 0x0000000184662C10-0x0000000184662D60
		public static void WriteRawLittleEndian64SlowPath(ref Span<byte> buffer, ref WriterInternalState state, ulong value) {} // 0x000000018A690474-0x000000018A690568
		private static void WriteRawByte(ref Span<byte> buffer, ref WriterInternalState state, byte value) {} // 0x0000000184664CE0-0x0000000184664D50
		public static void WriteRawBytes(ref Span<byte> buffer, ref WriterInternalState state, byte[] value) {} // 0x000000018A6901D0-0x000000018A690274
		public static void WriteRawBytes(ref Span<byte> buffer, ref WriterInternalState state, byte[] value, int offset, int length) {} // 0x000000018A690274-0x000000018A690318
		public static void WriteRawBytes(ref Span<byte> buffer, ref WriterInternalState state, ReadOnlySpan<byte> value) {} // 0x0000000185590DE0-0x0000000185590EB0
		public static void WriteTag(ref Span<byte> buffer, ref WriterInternalState state, int fieldNumber, WireFormat.WireType type) {} // 0x000000018A690C80-0x000000018A691248
		public static void WriteTag(ref Span<byte> buffer, ref WriterInternalState state, uint tag) {} // 0x0000000184663D10-0x0000000184663D80
		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1) {} // 0x0000000184664C30-0x0000000184664CE0
		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2) {} // 0x0000000184665850-0x0000000184665900
		private static void WriteRawTagSlowPath(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2) {} // 0x000000018A690758-0x000000018A6907D8
		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3) {} // 0x000000018A690A08-0x000000018A690AE8
		private static void WriteRawTagSlowPath(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3) {} // 0x000000018A690620-0x000000018A6906B4
		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3, byte b4) {} // 0x000000018A6907D8-0x000000018A6908DC
		private static void WriteRawTagSlowPath(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3, byte b4) {} // 0x000000018A6906B4-0x000000018A690758
		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3, byte b4, byte b5) {} // 0x000000018A6908DC-0x000000018A690A08
		private static void WriteRawTagSlowPath(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3, byte b4, byte b5) {} // 0x000000018A690568-0x000000018A690620
		public static uint EncodeZigZag32(int n) => default; // 0x0000000185FCC8A0-0x0000000185FCC8B0
		public static ulong EncodeZigZag64(long n) => default; // 0x0000000185FCC8B0-0x0000000185FCC8C0
	}

	internal static class WritingPrimitivesMessages // TypeDefIndex: 53359
	{
		// Methods
		public static void WriteMessage(ref WriteContext ctx, IMessage value) {} // 0x000000018A68FC98-0x000000018A68FD30
		public static void WriteGroup(ref WriteContext ctx, IMessage value) {} // 0x000000018A68F94C-0x000000018A68F954
		public static void WriteRawMessage(ref WriteContext ctx, IMessage message) {} // 0x000000018A68FD30-0x000000018A68FEF4
	}
}

namespace Google.Protobuf.Collections
{
	public static class Lists // TypeDefIndex: 53566
	{
		// Methods
		public static bool Equals<T>(List<T> left, List<T> right) => default;
		public static int GetHashCode<T>(List<T> list) => default;
	}

	public sealed class MapField<TKey, TValue> : IDeepCloneable<MapField<TKey, TValue>>, IDictionary<TKey, TValue>, IEquatable<MapField<TKey, TValue>>, IDictionary, IReadOnlyDictionary<TKey, TValue> // TypeDefIndex: 53572
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
		private class DictionaryEnumerator : IDictionaryEnumerator // TypeDefIndex: 53567
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
	
		public sealed class Codec // TypeDefIndex: 53568
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
	
		private class MapView<T> : ICollection<T>, ICollection // TypeDefIndex: 53569
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
	
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 53570
		{
			// Fields
			public TValue value;
	
			// Constructors
			public __c__DisplayClass7_0() {}
	
			// Methods
			internal bool _ContainsValue_b__0(KeyValuePair<TKey, TValue> pair) => default;
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53571
		{
			// Fields
			public static readonly __c<TKey, TValue> __9;
			public static Func<KeyValuePair<TKey, TValue>, TKey> __9__14_0;
			public static Func<KeyValuePair<TKey, TValue>, TValue> __9__16_0;
			public static Func<KeyValuePair<TKey, TValue>, DictionaryEntry> __9__43_0;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal TKey _get_Keys_b__14_0(KeyValuePair<TKey, TValue> pair) => default;
			internal TValue _get_Values_b__16_0(KeyValuePair<TKey, TValue> pair) => default;
			internal DictionaryEntry _System.Collections.ICollection.CopyTo_b__43_0(KeyValuePair<TKey, TValue> pair) => default;
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

	public static class ProtobufEqualityComparers // TypeDefIndex: 53577
	{
		// Fields
		private static readonly EqualityComparer<double> _BitwiseDoubleEqualityComparer_k__BackingField; // 0x00
		private static readonly EqualityComparer<float> _BitwiseSingleEqualityComparer_k__BackingField; // 0x08
		private static readonly EqualityComparer<double?> _BitwiseNullableDoubleEqualityComparer_k__BackingField; // 0x10
		private static readonly EqualityComparer<float?> _BitwiseNullableSingleEqualityComparer_k__BackingField; // 0x18
	
		// Properties
		public static EqualityComparer<double> BitwiseDoubleEqualityComparer { get; } // 0x000000018A6B72BC-0x000000018A6B7354 
		public static EqualityComparer<float> BitwiseSingleEqualityComparer { get; } // 0x0000000185BBF4C0-0x0000000185BBF4F0 
		public static EqualityComparer<double?> BitwiseNullableDoubleEqualityComparer { get; } // 0x000000018A6B7354-0x000000018A6B7424 
		public static EqualityComparer<float?> BitwiseNullableSingleEqualityComparer { get; } // 0x000000018A6B7424-0x000000018A6B74BC 
	
		// Nested types
		private class BitwiseDoubleEqualityComparerImpl : EqualityComparer<double> // TypeDefIndex: 53573
		{
			// Constructors
			public BitwiseDoubleEqualityComparerImpl() {} // 0x000000018A6BE6CC-0x000000018A6BE71C
	
			// Methods
			public override bool Equals(double x, double y) => default;
			public override int GetHashCode(double obj) => default; // 0x000000018A6BE5DC-0x000000018A6BE62C
		}
	
		private class BitwiseSingleEqualityComparerImpl : EqualityComparer<float> // TypeDefIndex: 53574
		{
			// Constructors
			public BitwiseSingleEqualityComparerImpl() {} // 0x0000000185BBF310-0x0000000185BBF490
	
			// Methods
			public override bool Equals(float x, float y) => default; // 0x000000018A6BE62C-0x000000018A6BE67C
			public override int GetHashCode(float obj) => default; // 0x000000018A6BE67C-0x000000018A6BE6CC
		}
	
		private class BitwiseNullableDoubleEqualityComparerImpl : EqualityComparer<double?> // TypeDefIndex: 53575
		{
			// Constructors
			public BitwiseNullableDoubleEqualityComparerImpl() {} // 0x0000000185BBF520-0x0000000185BBF550
	
			// Methods
			public override bool Equals(double? x, double? y) => default; // 0x000000018A6B7140-0x000000018A6B719C
			public override int GetHashCode(double? obj) => default; // 0x000000018A6B719C-0x000000018A6B71F4
		}
	
		private class BitwiseNullableSingleEqualityComparerImpl : EqualityComparer<float?> // TypeDefIndex: 53576
		{
			// Constructors
			public BitwiseNullableSingleEqualityComparerImpl() {} // 0x0000000185BBF4F0-0x0000000185BBF520
	
			// Methods
			public override bool Equals(float? x, float? y) => default; // 0x000000018A6B74BC-0x000000018A6B7528
			public override int GetHashCode(float? obj) => default; // 0x000000018A6B7528-0x000000018A6B757C
		}
	
		// Constructors
		static ProtobufEqualityComparers() {} // 0x0000000185BBF490-0x0000000185BBF4C0
	
		// Methods
		public static EqualityComparer<T> GetEqualityComparer<T>() => default; // 0x000000018A6B71F4-0x000000018A6B72BC
	}

	internal sealed class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue> // TypeDefIndex: 53578
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

	public sealed class RepeatedField<T> : IList<T>, IList, IDeepCloneable<RepeatedField<T>>, IEquatable<RepeatedField<T>>, IReadOnlyList<T> // TypeDefIndex: 53580
	{
		// Fields
		private static readonly EqualityComparer<T> EqualityComparer;
		private static readonly T[] EmptyArray;
		private const int MinArraySize = 8; // Metadata: 0x02078269
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
	
		// Nested types
		private sealed class _GetEnumerator_d__29 : IEnumerator<T> // TypeDefIndex: 53579
		{
			// Fields
			private int __1__state;
			private T __2__current;
			public RepeatedField<T> __4__this;
			private int _i_5__2;
	
			// Properties
			T IEnumerator<T>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _GetEnumerator_d__29() {} // Dummy constructor
			public _GetEnumerator_d__29(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
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
	internal static class PropertyInfoExtensions // TypeDefIndex: 53564
	{
		// Methods
		internal static MethodInfo GetGetMethod(PropertyInfo target) => default; // 0x000000018A6BE53C-0x000000018A6BE58C
		internal static MethodInfo GetSetMethod(PropertyInfo target) => default; // 0x000000018A6BE58C-0x000000018A6BE5DC
	}

	internal static class TypeExtensions // TypeDefIndex: 53565
	{
		// Methods
		internal static bool IsAssignableFrom(System.Type target, System.Type c) => default; // 0x000000018A6C034C-0x000000018A6C03A8
		internal static PropertyInfo GetProperty(System.Type target, string name) => default; // 0x000000018A6C0238-0x000000018A6C034C
		internal static MethodInfo GetMethod(System.Type target, string name) => default; // 0x000000018A6C0180-0x000000018A6C0238
	}
}

namespace Google.Protobuf.Reflection
{
	public sealed class CustomOptions // TypeDefIndex: 53431
	{
		// Fields
		private const string UnreferencedCodeMessage = "CustomOptions is incompatible with trimming."; // Metadata: 0x0207817C
		private static readonly object[] EmptyParameters; // 0x00
		private readonly IDictionary<int, IExtensionValue> values; // 0x10
	
		// Nested types
		[Serializable]
		private sealed class __c__19<T> // TypeDefIndex: 53430
			where T : class, IMessage, new()
		{
			// Fields
			public static readonly __c__19<T> __9;
			public static Func<T, ByteString> __9__19_0;
			public static Func<T, ByteString, T> __9__19_1;
	
			// Constructors
			static __c__19() {} // 0x0000000184096E30-0x0000000184096EF0
			public __c__19() {}
	
			// Methods
			internal ByteString _TryGetMessage_b__19_0(T v) => default; // 0x000000018A691D38-0x000000018A691D90
			internal T _TryGetMessage_b__19_1(T t, ByteString b) => default; // 0x000000018A691D90-0x000000018A691DE8
		}
	
		// Constructors
		public CustomOptions() {} // Dummy constructor
		internal CustomOptions(IDictionary<int, IExtensionValue> values) {} // 0x000000018A691CD0-0x000000018A691CD8
		static CustomOptions() {}
	
		// Methods
		public bool TryGetBool(int field, out bool value) {
			value = default;
			return default;
		} // 0x000000018A691CD8-0x000000018A691CE0
		public bool TryGetInt32(int field, out int value) {
			value = default;
			return default;
		} // 0x000000018A691DE8-0x000000018A691DF0
		public bool TryGetInt64(int field, out long value) {
			value = default;
			return default;
		} // 0x000000018A691DF0-0x000000018A691DF8
		public bool TryGetFixed32(int field, out uint value) {
			value = default;
			return default;
		} // 0x000000018A691DF8-0x000000018A691E50
		public bool TryGetFixed64(int field, out ulong value) {
			value = default;
			return default;
		} // 0x000000018A691E50-0x000000018A691EA8
		public bool TryGetSFixed32(int field, out int value) {
			value = default;
			return default;
		} // 0x000000018A691F00-0x000000018A691F58
		public bool TryGetSFixed64(int field, out long value) {
			value = default;
			return default;
		} // 0x000000018A691F58-0x000000018A691FB0
		public bool TryGetSInt32(int field, out int value) {
			value = default;
			return default;
		} // 0x000000018A691CE0-0x000000018A691D38
		public bool TryGetSInt64(int field, out long value) {
			value = default;
			return default;
		} // 0x000000018A691C78-0x000000018A691CD0
		public bool TryGetUInt32(int field, out uint value) {
			value = default;
			return default;
		} // 0x000000018A691EA8-0x000000018A691F00
		public bool TryGetUInt64(int field, out ulong value) {
			value = default;
			return default;
		} // 0x000000018A691C20-0x000000018A691C78
		public bool TryGetFloat(int field, out float value) {
			value = default;
			return default;
		}
		public bool TryGetDouble(int field, out double value) {
			value = default;
			return default;
		}
		public bool TryGetString(int field, out string value) {
			value = default;
			return default;
		} // 0x000000018A691FB0-0x000000018A692014
		public bool TryGetBytes(int field, out ByteString value) {
			value = default;
			return default;
		}
		public bool TryGetMessage<T>(int field, out ref T value)
			where T : class, IMessage, new() {
			value = default;
			return default;
		}
		private bool TryGetPrimitiveValue<T>(int field, out ref T value) {
			value = default;
			return default;
		}
	}

	public static class DescriptorReflection // TypeDefIndex: 53432
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018A696F28-0x000000018A696F78 
	
		// Constructors
		static DescriptorReflection() {} // 0x000000018A69394C-0x000000018A696F28
	}

	public sealed class FileDescriptorSet : IMessage<FileDescriptorSet>, IBufferMessage // TypeDefIndex: 53434
	{
		// Fields
		private static readonly MessageParser<FileDescriptorSet> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int FileFieldNumber = 1; // Metadata: 0x020781A9
		private static readonly FieldCodec<FileDescriptorProto> _repeated_file_codec; // 0x08
		private readonly RepeatedField<FileDescriptorProto> file_; // 0x18
	
		// Properties
		public static MessageParser<FileDescriptorSet> Parser { get => default; } // 0x000000018A69F388-0x000000018A69F400 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A69F300-0x000000018A69F388 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A69EF8C-0x000000018A69EFEC 
		public RepeatedField<FileDescriptorProto> File { get => default; } // 0x000000018736AA60-0x000000018736AAB0 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53433
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A69F460-0x000000018A69F4B0
			public __c() {} // 0x000000018A69F400-0x000000018A69F460
	
			// Methods
			internal FileDescriptorSet _.cctor_b__27_0() => default; // 0x000000018A69F624-0x000000018A69F664
		}
	
		// Constructors
		public FileDescriptorSet() {} // 0x0000000181377E40-0x0000000181377E50
		public FileDescriptorSet(FileDescriptorSet other) {} // 0x000000018A69EFEC-0x000000018A69F050
		static FileDescriptorSet() {} // 0x000000018A6A2D5C-0x000000018A6A2DAC
	
		// Methods
		public FileDescriptorSet Clone() => default; // 0x000000018A69F050-0x000000018A69F0CC
		public override bool Equals(object other) => default; // 0x000000018A69F144-0x000000018A69F190
		public bool Equals(FileDescriptorSet other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A69F580-0x000000018A69F624
		public override string ToString() => default; // 0x000000018A69EEF8-0x000000018A69EF8C
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A69F0CC-0x000000018A69F144
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A69F4B0-0x000000018A69F580
		public void MergeFrom(FileDescriptorSet other) {} // 0x000000018A69F190-0x000000018A69F300
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A398C-0x000000018A6A39F0
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class FileDescriptorProto : IMessage<FileDescriptorProto>, IBufferMessage // TypeDefIndex: 53436
	{
		// Fields
		private static readonly MessageParser<FileDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x020781AA
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x18
		public const int PackageFieldNumber = 2; // Metadata: 0x020781AB
		private static readonly string PackageDefaultValue; // 0x10
		private string package_; // 0x20
		public const int DependencyFieldNumber = 3; // Metadata: 0x020781AC
		private static readonly FieldCodec<string> _repeated_dependency_codec; // 0x18
		private readonly RepeatedField<string> dependency_; // 0x28
		public const int PublicDependencyFieldNumber = 10; // Metadata: 0x020781AD
		private static readonly FieldCodec<int> _repeated_publicDependency_codec; // 0x20
		private readonly RepeatedField<int> publicDependency_; // 0x30
		public const int WeakDependencyFieldNumber = 11; // Metadata: 0x020781AE
		private static readonly FieldCodec<int> _repeated_weakDependency_codec; // 0x28
		private readonly RepeatedField<int> weakDependency_; // 0x38
		public const int MessageTypeFieldNumber = 4; // Metadata: 0x020781AF
		private static readonly FieldCodec<DescriptorProto> _repeated_messageType_codec; // 0x30
		private readonly RepeatedField<DescriptorProto> messageType_; // 0x40
		public const int EnumTypeFieldNumber = 5; // Metadata: 0x020781B0
		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; // 0x38
		private readonly RepeatedField<EnumDescriptorProto> enumType_; // 0x48
		public const int ServiceFieldNumber = 6; // Metadata: 0x020781B1
		private static readonly FieldCodec<ServiceDescriptorProto> _repeated_service_codec; // 0x40
		private readonly RepeatedField<ServiceDescriptorProto> service_; // 0x50
		public const int ExtensionFieldNumber = 7; // Metadata: 0x020781B2
		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec; // 0x48
		private readonly RepeatedField<FieldDescriptorProto> extension_; // 0x58
		public const int OptionsFieldNumber = 8; // Metadata: 0x020781B3
		private Google.Protobuf.Reflection.FileOptions options_; // 0x60
		public const int SourceCodeInfoFieldNumber = 9; // Metadata: 0x020781B4
		private SourceCodeInfo sourceCodeInfo_; // 0x68
		public const int SyntaxFieldNumber = 12; // Metadata: 0x020781B5
		private static readonly string SyntaxDefaultValue; // 0x50
		private string syntax_; // 0x70
	
		// Properties
		public static MessageParser<FileDescriptorProto> Parser { get => default; } // 0x000000018A69E2F4-0x000000018A69E51C 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A69E0C4-0x000000018A69E2F4 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A69D548-0x000000018A69D5A8 
		public string Name { get => default; set {} } // 0x000000018570A480-0x000000018570A4A0 0x000000018A69E5DC-0x000000018A69E630
		public bool HasName { get => default; } // 0x000000018A69EE28-0x000000018A69EE90 
		public string Package { get => default; set {} } // 0x000000018A69AD8C-0x000000018A69ADA0 0x00000001813B8590-0x00000001813B85A0
		public bool HasPackage { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
		public RepeatedField<string> Dependency { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		public RepeatedField<int> PublicDependency { get => default; } // 0x00000001813ECF20-0x00000001813ECF30 
		public RepeatedField<int> WeakDependency { get => default; } // 0x0000000181460F60-0x0000000181460F70 
		public RepeatedField<DescriptorProto> MessageType { get => default; } // 0x00000001813F1630-0x00000001813F1640 
		public RepeatedField<EnumDescriptorProto> EnumType { get => default; } // 0x0000000185FB0530-0x0000000185FB0540 
		public RepeatedField<ServiceDescriptorProto> Service { get => default; } // 0x0000000185AE8FE0-0x0000000185AE8FF0 
		public RepeatedField<FieldDescriptorProto> Extension { get => default; } // 0x00000001813AC280-0x00000001813AC290 
		public Google.Protobuf.Reflection.FileOptions Options { get => default; set {} } // 0x0000000185A62990-0x0000000185A629A0 0x000000018A69E680-0x000000018A69E6D4
		public SourceCodeInfo SourceCodeInfo { get => default; set {} } // 0x000000018A69EE90-0x000000018A69EEF8 0x000000018A69E57C-0x000000018A69E588
		public string Syntax { get => default; set {} } // 0x000000018A69D534-0x000000018A69D548 0x000000018A69D5A8-0x000000018A69D60C
		public bool HasSyntax { get => default; } // 0x000000018A69D60C-0x000000018A69D860 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53435
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A69E630-0x000000018A69E680
			public __c() {} // 0x000000018A69E51C-0x000000018A69E57C
	
			// Methods
			internal FileDescriptorProto _.cctor_b__94_0() => default; // 0x000000018A69ED80-0x000000018A69EDC0
		}
	
		// Constructors
		public FileDescriptorProto() {} // 0x000000018A69E588-0x000000018A69E5DC
		public FileDescriptorProto(FileDescriptorProto other) {} // 0x000000018A69EDC0-0x000000018A69EE28
		static FileDescriptorProto() {} // 0x000000018A6A31D0-0x000000018A6A3220
	
		// Methods
		public FileDescriptorProto Clone() => default; // 0x00000001847EB9E0-0x00000001847EB9F0
		public void ClearName() {} // 0x000000018A69B84C-0x000000018A69B858
		public void ClearPackage() {} // 0x00000001813ECBC0-0x00000001813ECBD0
		public void ClearSyntax() {} // 0x000000018A69D860-0x000000018A69DA04
		public override bool Equals(object other) => default; // 0x000000018A69DC94-0x000000018A69DCE0
		public bool Equals(FileDescriptorProto other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A69EAB8-0x000000018A69ED80
		public override string ToString() => default; // 0x000000018A69D254-0x000000018A69D534
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A69DA04-0x000000018A69DC94
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A69E6D4-0x000000018A69EAB8
		public void MergeFrom(FileDescriptorProto other) {} // 0x000000018A69DCE0-0x000000018A69E0C4
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A33B0-0x000000018A6A3414
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class DescriptorProto : IMessage<DescriptorProto>, IBufferMessage // TypeDefIndex: 53443
	{
		// Fields
		private static readonly MessageParser<DescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x020781B6
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x18
		public const int FieldFieldNumber = 2; // Metadata: 0x020781B7
		private static readonly FieldCodec<FieldDescriptorProto> _repeated_field_codec; // 0x10
		private readonly RepeatedField<FieldDescriptorProto> field_; // 0x20
		public const int ExtensionFieldNumber = 6; // Metadata: 0x020781B8
		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec; // 0x18
		private readonly RepeatedField<FieldDescriptorProto> extension_; // 0x28
		public const int NestedTypeFieldNumber = 3; // Metadata: 0x020781B9
		private static readonly FieldCodec<DescriptorProto> _repeated_nestedType_codec; // 0x20
		private readonly RepeatedField<DescriptorProto> nestedType_; // 0x30
		public const int EnumTypeFieldNumber = 4; // Metadata: 0x020781BA
		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; // 0x28
		private readonly RepeatedField<EnumDescriptorProto> enumType_; // 0x38
		public const int ExtensionRangeFieldNumber = 5; // Metadata: 0x020781BB
		private static readonly FieldCodec<Types.ExtensionRange> _repeated_extensionRange_codec; // 0x30
		private readonly RepeatedField<Types.ExtensionRange> extensionRange_; // 0x40
		public const int OneofDeclFieldNumber = 8; // Metadata: 0x020781BC
		private static readonly FieldCodec<OneofDescriptorProto> _repeated_oneofDecl_codec; // 0x38
		private readonly RepeatedField<OneofDescriptorProto> oneofDecl_; // 0x48
		public const int OptionsFieldNumber = 7; // Metadata: 0x020781BD
		private MessageOptions options_; // 0x50
		public const int ReservedRangeFieldNumber = 9; // Metadata: 0x020781BE
		private static readonly FieldCodec<Types.ReservedRange> _repeated_reservedRange_codec; // 0x40
		private readonly RepeatedField<Types.ReservedRange> reservedRange_; // 0x58
		public const int ReservedNameFieldNumber = 10; // Metadata: 0x020781BF
		private static readonly FieldCodec<string> _repeated_reservedName_codec; // 0x48
		private readonly RepeatedField<string> reservedName_; // 0x60
	
		// Properties
		public static MessageParser<DescriptorProto> Parser { get => default; } // 0x000000018A6A1554-0x000000018A6A15A4 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6A149C-0x000000018A6A1500 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6A171C-0x000000018A6A175C 
		public string Name { get => default; set {} } // 0x000000018A6A15A4-0x000000018A6A15F8 0x0000000185FCC8E0-0x0000000185FCC8F0
		public bool HasName { get => default; } // 0x00000001841B1DD0-0x00000001841B1DE0 
		public RepeatedField<FieldDescriptorProto> Field { get => default; } // 0x000000018A6A1500-0x000000018A6A1554 
		public RepeatedField<FieldDescriptorProto> Extension { get => default; } // 0x0000000185FCC8D0-0x0000000185FCC8E0 
		public RepeatedField<DescriptorProto> NestedType { get => default; } // 0x00000001817CD360-0x00000001817CD370 
		public RepeatedField<EnumDescriptorProto> EnumType { get => default; } // 0x0000000185FCC8C0-0x0000000185FCC8D0 
		public RepeatedField<Types.ExtensionRange> ExtensionRange { get => default; } // 0x000000018A6A1184-0x000000018A6A11E8 
		public RepeatedField<OneofDescriptorProto> OneofDecl { get => default; } // 0x000000018A6A11E8-0x000000018A6A1260 
		public MessageOptions Options { get => default; set {} } // 0x000000018A6A1260-0x000000018A6A12B8 0x000000018A6A1324-0x000000018A6A1370
		public RepeatedField<Types.ReservedRange> ReservedRange { get => default; } // 0x0000000185FA7B70-0x0000000185FA7BA0 
		public RepeatedField<string> ReservedName { get => default; } // 0x000000018A6A1694-0x000000018A6A171C 
	
		// Nested types
		public static class Types // TypeDefIndex: 53441
		{
			// Nested types
			public sealed class ExtensionRange : IMessage<ExtensionRange>, IBufferMessage // TypeDefIndex: 53438
			{
				// Fields
				private static readonly MessageParser<ExtensionRange> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				private int _hasBits0; // 0x18
				public const int StartFieldNumber = 1; // Metadata: 0x020781C0
				private static readonly int StartDefaultValue; // 0x08
				private int start_; // 0x1C
				public const int EndFieldNumber = 2; // Metadata: 0x020781C1
				private static readonly int EndDefaultValue; // 0x0C
				private int end_; // 0x20
				public const int OptionsFieldNumber = 3; // Metadata: 0x020781C2
				private ExtensionRangeOptions options_; // 0x28
	
				// Properties
				public static MessageParser<ExtensionRange> Parser { get => default; } // 0x000000018A692F48-0x000000018A6931BC 
				public static MessageDescriptor Descriptor { get => default; } // 0x000000018A692D3C-0x000000018A692F48 
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6922B4-0x000000018A692314 
				public int Start { get => default; set {} } // 0x000000018570A480-0x000000018570A4A0 0x00000001813B31A0-0x00000001813B31B0
				public bool HasStart { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
				public int End { get => default; set {} } // 0x00000001813ECBC0-0x00000001813ECBD0 0x00000001813FF010-0x00000001813FF020
				public bool HasEnd { get => default; } // 0x00000001813ECF20-0x00000001813ECF30 
				public ExtensionRangeOptions Options { get => default; set {} } // 0x0000000184A4E570-0x0000000184A4E580 0x00000001813F1630-0x00000001813F1640
	
				// Nested types
				[Serializable]
				private sealed class __c // TypeDefIndex: 53437
				{
					// Fields
					public static readonly __c __9; // 0x00
	
					// Constructors
					static __c() {} // 0x000000018A693270-0x000000018A6932C0
					public __c() {} // 0x000000018A6931BC-0x000000018A69321C
	
					// Methods
					internal ExtensionRange _.cctor_b__46_0() => default; // 0x000000018A6938A4-0x000000018A6938E4
				}
	
				// Constructors
				public ExtensionRange() {} // 0x000000018A69321C-0x000000018A693270
				public ExtensionRange(ExtensionRange other) {} // 0x000000018A6938E4-0x000000018A69394C
				static ExtensionRange() {} // 0x000000018A6932C0-0x000000018A693620
	
				// Methods
				public ExtensionRange Clone() => default; // 0x00000001847EB9E0-0x00000001847EB9F0
				public void ClearStart() {} // 0x00000001813B51D0-0x00000001813B51E0
				public void ClearEnd() {} // 0x0000000181460F60-0x0000000181460F70
				public override bool Equals(object other) => default; // 0x0000000185FB0530-0x0000000185FB0540
				public bool Equals(ExtensionRange other) => default; // 0x000000018A692520-0x000000018A692584
				public override int GetHashCode() => default; // 0x000000018A692314-0x000000018A692520
				public override string ToString() => default; // 0x000000018A692584-0x000000018A6926D0
				public void WriteTo(CodedOutputStream output) {} // 0x000000018A6928E4-0x000000018A692930
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7B70-0x0000000185FA7BA0
				public int CalculateSize() => default; // 0x000000018A693620-0x000000018A6938A4
				public void MergeFrom(ExtensionRange other) {} // 0x000000018A692014-0x000000018A6922B4
				public void MergeFrom(CodedInputStream input) {} // 0x000000018A6926D0-0x000000018A6928E4
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185FA7960-0x0000000185FA7990
			}
	
			public sealed class ReservedRange : IMessage<ReservedRange>, IBufferMessage // TypeDefIndex: 53440
			{
				// Fields
				private static readonly MessageParser<ReservedRange> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				private int _hasBits0; // 0x18
				public const int StartFieldNumber = 1; // Metadata: 0x020781C3
				private static readonly int StartDefaultValue; // 0x08
				private int start_; // 0x1C
				public const int EndFieldNumber = 2; // Metadata: 0x020781C4
				private static readonly int EndDefaultValue; // 0x0C
				private int end_; // 0x20
	
				// Properties
				public static MessageParser<ReservedRange> Parser { get => default; } // 0x000000018A69AB0C-0x000000018A69AB4C 
				public static MessageDescriptor Descriptor { get => default; } // 0x0000000185492010-0x0000000185492020 
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A69A77C-0x000000018A69A7F0 
				public int Start { get => default; set {} } // 0x00000001841B1DD0-0x00000001841B1DE0 0x0000000185FB0C60-0x0000000185FB0C70
				public bool HasStart { get => default; } // 0x000000018A69A850-0x000000018A69A8A4 
				public int End { get => default; set {} } // 0x00000001817CD360-0x00000001817CD370 0x0000000185FCC8C0-0x0000000185FCC8D0
				public bool HasEnd { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
	
				// Nested types
				[Serializable]
				private sealed class __c // TypeDefIndex: 53439
				{
					// Fields
					public static readonly __c __9; // 0x00
	
					// Constructors
					static __c() {} // 0x000000018A692930-0x000000018A692D3C
					public __c() {} // 0x000000018A69A8A4-0x000000018A69A8F4
	
					// Methods
					internal ReservedRange _.cctor_b__41_0() => default; // 0x000000018A69A7F0-0x000000018A69A850
				}
	
				// Constructors
				public ReservedRange() {} // 0x000000018A69A358-0x000000018A69A3B8
				public ReservedRange(ReservedRange other) {} // 0x000000018A69A8F4-0x000000018A69A948
				static ReservedRange() {} // 0x000000018A69A650-0x000000018A69A77C
	
				// Methods
				public ReservedRange Clone() => default; // 0x0000000185FCC8E0-0x0000000185FCC8F0
				public void ClearStart() {} // 0x0000000185FCC8D0-0x0000000185FCC8E0
				public void ClearEnd() {} // 0x0000000184A4EDC0-0x0000000184A4EDD0
				public override bool Equals(object other) => default; // 0x000000018A69A444-0x000000018A69A4A8
				public bool Equals(ReservedRange other) => default; // 0x000000018A69A3B8-0x000000018A69A444
				public override int GetHashCode() => default; // 0x000000018A69A4A8-0x000000018A69A518
				public override string ToString() => default; // 0x000000018A69A604-0x000000018A69A650
				public void WriteTo(CodedOutputStream output) {} // 0x0000000185FA7B70-0x0000000185FA7BA0
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018A69AA64-0x000000018A69AB0C
				public int CalculateSize() => default; // 0x000000018A69A288-0x000000018A69A358
				public void MergeFrom(ReservedRange other) {} // 0x000000018A69A518-0x000000018A69A604
				public void MergeFrom(CodedInputStream input) {} // 0x0000000185FA7960-0x0000000185FA7990
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018A69A948-0x000000018A69AA64
			}
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53442
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6A3540-0x000000018A6A35A4
			public __c() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal DescriptorProto _.cctor_b__77_0() => default; // 0x000000018A6A3054-0x000000018A6A3090
		}
	
		// Constructors
		public DescriptorProto() {} // 0x0000000185492010-0x0000000185492020
		public DescriptorProto(DescriptorProto other) {} // 0x0000000187355704-0x000000018735574C
		static DescriptorProto() {} // 0x000000018A6A3180-0x000000018A6A31D0
	
		// Methods
		public DescriptorProto Clone() => default; // 0x000000018A6A1124-0x000000018A6A1184
		public void ClearName() {} // 0x0000000185FB0C60-0x0000000185FB0C70
		public override bool Equals(object other) => default; // 0x000000018A6A1078-0x000000018A6A1124
		public bool Equals(DescriptorProto other) => default; // 0x000000018A6A12B8-0x000000018A6A1324
		public override int GetHashCode() => default; // 0x0000000185FA7960-0x0000000185FA7990
		public override string ToString() => default; // 0x000000018A6A15F8-0x000000018A6A1694
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6A1370-0x000000018A6A149C
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018A6A3220-0x000000018A6A3284
		public int CalculateSize() => default; // 0x0000000185492010-0x0000000185492020
		public void MergeFrom(DescriptorProto other) {} // 0x000000018A6A3018-0x000000018A6A3054
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A3284-0x000000018A6A32E8
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class ExtensionRangeOptions : IExtendableMessage<ExtensionRangeOptions>, IBufferMessage // TypeDefIndex: 53445
	{
		// Fields
		private static readonly MessageParser<ExtensionRangeOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<ExtensionRangeOptions> _extensions; // 0x18
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x020781C5
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x20
	
		// Properties
		private ExtensionSet<ExtensionRangeOptions> _Extensions { get => default; } // 0x000000018A69A248-0x000000018A69A288 
		public static MessageParser<ExtensionRangeOptions> Parser { get => default; } // 0x000000018A699F58-0x000000018A699FD0 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A699EA8-0x000000018A699F58 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A699A98-0x000000018A699AF8 
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x000000018A699BEC-0x000000018A699C54 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53444
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000181377E40-0x0000000181377E50
			public __c() {} // 0x000000018A69A030-0x000000018A69A080
	
			// Methods
			internal ExtensionRangeOptions _.cctor_b__37_0() => default; // 0x000000018A699FD0-0x000000018A69A030
		}
	
		// Constructors
		public ExtensionRangeOptions() {} // 0x00000001813B31A0-0x00000001813B31B0
		public ExtensionRangeOptions(ExtensionRangeOptions other) {} // 0x000000018A699B88-0x000000018A699BEC
		static ExtensionRangeOptions() {} // 0x000000018A6A2FC8-0x000000018A6A3018
	
		// Methods
		public ExtensionRangeOptions Clone() => default; // 0x000000018A699AF8-0x000000018A699B88
		public override bool Equals(object other) => default; // 0x000000018A699CEC-0x000000018A699D38
		public bool Equals(ExtensionRangeOptions other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A69A180-0x000000018A69A248
		public override string ToString() => default; // 0x000000018A6999DC-0x000000018A699A98
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A699C54-0x000000018A699CEC
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A69A080-0x000000018A69A180
		public void MergeFrom(ExtensionRangeOptions other) {}
		public void MergeFrom(CodedInputStream input) {}
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {}
		public TValue GetExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension) => default; // 0x000000018A699D38-0x000000018A699EA8
		public void ClearExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension) {} // 0x000000018A6A35A4-0x000000018A6A3608
		public void ClearExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class FieldDescriptorProto : IMessage<FieldDescriptorProto>, IBufferMessage // TypeDefIndex: 53450
	{
		// Fields
		private static readonly MessageParser<FieldDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		private int _hasBits0; // 0x18
		public const int NameFieldNumber = 1; // Metadata: 0x020781C7
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x20
		public const int NumberFieldNumber = 3; // Metadata: 0x020781C8
		private static readonly int NumberDefaultValue; // 0x10
		private int number_; // 0x28
		public const int LabelFieldNumber = 4; // Metadata: 0x020781C9
		private static readonly Types.Label LabelDefaultValue; // 0x14
		private Types.Label label_; // 0x2C
		public const int TypeFieldNumber = 5; // Metadata: 0x020781CA
		private static readonly Types.Type TypeDefaultValue; // 0x18
		private Types.Type type_; // 0x30
		public const int TypeNameFieldNumber = 6; // Metadata: 0x020781CB
		private static readonly string TypeNameDefaultValue; // 0x20
		private string typeName_; // 0x38
		public const int ExtendeeFieldNumber = 2; // Metadata: 0x020781CC
		private static readonly string ExtendeeDefaultValue; // 0x28
		private string extendee_; // 0x40
		public const int DefaultValueFieldNumber = 7; // Metadata: 0x020781CD
		private static readonly string DefaultValueDefaultValue; // 0x30
		private string defaultValue_; // 0x48
		public const int OneofIndexFieldNumber = 9; // Metadata: 0x020781CE
		private static readonly int OneofIndexDefaultValue; // 0x38
		private int oneofIndex_; // 0x50
		public const int JsonNameFieldNumber = 10; // Metadata: 0x020781CF
		private static readonly string JsonNameDefaultValue; // 0x40
		private string jsonName_; // 0x58
		public const int OptionsFieldNumber = 8; // Metadata: 0x020781D0
		private Google.Protobuf.Reflection.FieldOptions options_; // 0x60
		public const int Proto3OptionalFieldNumber = 17; // Metadata: 0x020781D1
		private static readonly bool Proto3OptionalDefaultValue; // 0x48
		private bool proto3Optional_; // 0x68
	
		// Properties
		public static MessageParser<FieldDescriptorProto> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A69B660-0x000000018A69B744 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A69ADA0-0x000000018A69AE00 
		public string Name { get => default; set {} } // 0x000000018A69AD8C-0x000000018A69ADA0 0x000000018A69B96C-0x000000018A69B9C0
		public bool HasName { get => default; } // 0x0000000185FCC930-0x0000000185FCC940 
		public int Number { get => default; set {} } // 0x0000000185FB0C60-0x0000000185FB0C70 0x000000018A69B8C4-0x000000018A69B918
		public bool HasNumber { get => default; } // 0x0000000185FCC920-0x0000000185FCC930 
		public Types.Label Label { get => default; set {} } // 0x0000000185FCC8C0-0x0000000185FCC8D0 0x000000018A69BB0C-0x000000018A69BB60
		public bool HasLabel { get => default; } // 0x0000000185FCC960-0x0000000185FCC970 
		public Types.Type Type { get => default; set {} } // 0x0000000185FCC910-0x0000000185FCC920 0x000000018A69BAB8-0x000000018A69BB0C
		public bool HasType { get => default; } // 0x000000018A69C184-0x000000018A69C1EC 
		public string TypeName { get => default; set {} } // 0x0000000187F218C0-0x0000000187F218D4 0x000000018A69B7F8-0x000000018A69B84C
		public bool HasTypeName { get => default; } // 0x000000018A69C04C-0x000000018A69C0B4 
		public string Extendee { get => default; set {} } // 0x000000018A69AD64-0x000000018A69AD78 0x000000018A69B744-0x000000018A69B798
		public bool HasExtendee { get => default; } // 0x000000018A69BFE4-0x000000018A69C04C 
		public string DefaultValue { get => default; set {} } // 0x0000000187F3B9F4-0x0000000187F3BA08 0x000000018A69B9C0-0x000000018A69BA14
		public bool HasDefaultValue { get => default; } // 0x0000000185FCC940-0x0000000185FCC950 
		public int OneofIndex { get => default; set {} } // 0x0000000185FCC8F0-0x0000000185FCC900 0x000000018A69B870-0x000000018A69B8C4
		public bool HasOneofIndex { get => default; } // 0x000000018A69C0B4-0x000000018A69C11C 
		public string JsonName { get => default; set {} } // 0x000000018A69AD78-0x000000018A69AD8C 0x0000000185FB0530-0x0000000185FB0540
		public bool HasJsonName { get => default; } // 0x0000000185AE8FE0-0x0000000185AE8FF0 
		public Google.Protobuf.Reflection.FieldOptions Options { get => default; set {} } // 0x0000000185FCC950-0x0000000185FCC960 0x000000018A69B860-0x000000018A69B868
		public bool Proto3Optional { get => default; set {} } // 0x0000000185FCC900-0x0000000185FCC910 0x000000018A69AE00-0x000000018A69AE64
		public bool HasProto3Optional { get => default; } // 0x000000018A69AE64-0x000000018A69B030 
	
		// Nested types
		public static class Types // TypeDefIndex: 53448
		{
			// Nested types
			public enum Type // TypeDefIndex: 53446
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
	
			public enum Label // TypeDefIndex: 53447
			{
				Optional = 1,
				Required = 2,
				Repeated = 3
			}
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53449
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A69BA14-0x000000018A69BA64
			public __c() {} // 0x000000018A69B798-0x000000018A69B7F8
	
			// Methods
			internal FieldDescriptorProto _.cctor_b__119_0() => default; // 0x000000018A69BFA4-0x000000018A69BFE4
		}
	
		// Constructors
		public FieldDescriptorProto() {} // 0x000000018A69B918-0x000000018A69B96C
		public FieldDescriptorProto(FieldDescriptorProto other) {} // 0x000000018A69C11C-0x000000018A69C184
		static FieldDescriptorProto() {} // 0x000000018A6A2C1C-0x000000018A6A2C58
	
		// Methods
		public FieldDescriptorProto Clone() => default; // 0x000000018A69B84C-0x000000018A69B858
		public void ClearName() {} // 0x00000001841B1DD0-0x00000001841B1DE0
		public void ClearNumber() {} // 0x00000001817CD360-0x00000001817CD370
		public void ClearLabel() {} // 0x000000018A69B868-0x000000018A69B870
		public void ClearType() {} // 0x0000000188251750-0x000000018825175C
		public void ClearTypeName() {} // 0x0000000184A2A780-0x0000000184A2A790
		public void ClearExtendee() {} // 0x000000018805D4CC-0x000000018805D4D8
		public void ClearDefaultValue() {} // 0x000000018A69B858-0x000000018A69B860
		public void ClearOneofIndex() {} // 0x0000000187E45764-0x0000000187E45770
		public void ClearJsonName() {} // 0x000000018A69BA64-0x000000018A69BAB8
		public void ClearProto3Optional() {} // 0x000000018A69B030-0x000000018A69B1E0
		public override bool Equals(object other) => default; // 0x000000018A69B3AC-0x000000018A69B3F8
		public bool Equals(FieldDescriptorProto other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A69BDA0-0x000000018A69BFA4
		public override string ToString() => default; // 0x000000018A69AB4C-0x000000018A69AD64
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A69B1E0-0x000000018A69B3AC
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A69BB60-0x000000018A69BDA0
		public void MergeFrom(FieldDescriptorProto other) {} // 0x000000018A69B3F8-0x000000018A69B660
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A3608-0x000000018A6A366C
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class OneofDescriptorProto : IMessage<OneofDescriptorProto>, IBufferMessage // TypeDefIndex: 53452
	{
		// Fields
		private static readonly MessageParser<OneofDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x020781E7
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x18
		public const int OptionsFieldNumber = 2; // Metadata: 0x020781E8
		private OneofOptions options_; // 0x20
	
		// Properties
		public static MessageParser<OneofDescriptorProto> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6A0640-0x000000018A6A06B4 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6A0218-0x000000018A6A0278 
		public string Name { get => default; set {} } // 0x000000018570A480-0x000000018570A4A0 0x00000001813B31A0-0x00000001813B31B0
		public bool HasName { get => default; } // 0x000000018646EE40-0x000000018646EE50 
		public OneofOptions Options { get => default; set {} } // 0x000000018A6A0278-0x000000018A6A02FC 0x000000018A6A0360-0x000000018A6A03D4
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53451
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6A0768-0x000000018A6A07B8
			public __c() {} // 0x000000018A6A06B4-0x000000018A6A0714
	
			// Methods
			internal OneofDescriptorProto _.cctor_b__36_0() => default; // 0x000000018A6A092C-0x000000018A6A096C
		}
	
		// Constructors
		public OneofDescriptorProto() {} // 0x000000018A6A0714-0x000000018A6A0768
		public OneofDescriptorProto(OneofDescriptorProto other) {} // 0x000000018A6A096C-0x000000018A6A09D4
		static OneofDescriptorProto() {} // 0x000000018A6A2F3C-0x000000018A6A2F78
	
		// Methods
		public OneofDescriptorProto Clone() => default; // 0x00000001847EB9E0-0x00000001847EB9F0
		public void ClearName() {} // 0x000000018A6A02FC-0x000000018A6A0360
		public override bool Equals(object other) => default; // 0x000000018A6A04B0-0x000000018A6A04FC
		public bool Equals(OneofDescriptorProto other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A6A08AC-0x000000018A6A092C
		public override string ToString() => default; // 0x000000018A6A0170-0x000000018A6A0218
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6A03D4-0x000000018A6A04B0
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6A07B8-0x000000018A6A08AC
		public void MergeFrom(OneofDescriptorProto other) {} // 0x000000018A6A04FC-0x000000018A6A0640
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A334C-0x000000018A6A33B0
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class EnumDescriptorProto : IMessage<EnumDescriptorProto>, IBufferMessage // TypeDefIndex: 53457
	{
		// Fields
		private static readonly MessageParser<EnumDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x020781E9
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x18
		public const int ValueFieldNumber = 2; // Metadata: 0x020781EA
		private static readonly FieldCodec<EnumValueDescriptorProto> _repeated_value_codec; // 0x10
		private readonly RepeatedField<EnumValueDescriptorProto> value_; // 0x20
		public const int OptionsFieldNumber = 3; // Metadata: 0x020781EB
		private EnumOptions options_; // 0x28
		public const int ReservedRangeFieldNumber = 4; // Metadata: 0x020781EC
		private static readonly FieldCodec<Types.EnumReservedRange> _repeated_reservedRange_codec; // 0x18
		private readonly RepeatedField<Types.EnumReservedRange> reservedRange_; // 0x30
		public const int ReservedNameFieldNumber = 5; // Metadata: 0x020781ED
		private static readonly FieldCodec<string> _repeated_reservedName_codec; // 0x20
		private readonly RepeatedField<string> reservedName_; // 0x38
	
		// Properties
		public static MessageParser<EnumDescriptorProto> Parser { get => default; } // 0x000000018A6A82E8-0x000000018A6A8348 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6A8764-0x000000018A6A87B8 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000185FCC8E0-0x0000000185FCC8F0 
		public string Name { get => default; set {} } // 0x0000000185FCC8D0-0x0000000185FCC8E0 0x00000001817CD360-0x00000001817CD370
		public bool HasName { get => default; } // 0x0000000185FCC8C0-0x0000000185FCC8D0 
		public RepeatedField<EnumValueDescriptorProto> Value { get => default; } // 0x000000018A6A83AC-0x000000018A6A8424 
		public EnumOptions Options { get => default; set {} } // 0x000000018A6A8424-0x000000018A6A847C 0x000000018A6A84E8-0x000000018A6A8534
		public RepeatedField<Types.EnumReservedRange> ReservedRange { get => default; } // 0x0000000185FA7B70-0x0000000185FA7BA0 
		public RepeatedField<string> ReservedName { get => default; } // 0x000000018A6A87B8-0x000000018A6A8840 
	
		// Nested types
		public static class Types // TypeDefIndex: 53455
		{
			// Nested types
			public sealed class EnumReservedRange : IMessage<EnumReservedRange>, IBufferMessage // TypeDefIndex: 53454
			{
				// Fields
				private static readonly MessageParser<EnumReservedRange> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				private int _hasBits0; // 0x18
				public const int StartFieldNumber = 1; // Metadata: 0x020781EE
				private static readonly int StartDefaultValue; // 0x08
				private int start_; // 0x1C
				public const int EndFieldNumber = 2; // Metadata: 0x020781EF
				private static readonly int EndDefaultValue; // 0x0C
				private int end_; // 0x20
	
				// Properties
				public static MessageParser<EnumReservedRange> Parser { get => default; } // 0x000000018A697BC4-0x000000018A697CD0 
				public static MessageDescriptor Descriptor { get => default; } // 0x000000018A697CD0-0x000000018A697DF0 
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A697524-0x000000018A697584 
				public int Start { get => default; set {} } // 0x000000018570A480-0x000000018570A4A0 0x00000001813B31A0-0x00000001813B31B0
				public bool HasStart { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
				public int End { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001813ECBC0-0x00000001813ECBD0
				public bool HasEnd { get => default; } // 0x000000018A697584-0x000000018A6975E8 
	
				// Nested types
				[Serializable]
				private sealed class __c // TypeDefIndex: 53453
				{
					// Fields
					public static readonly __c __9; // 0x00
	
					// Constructors
					static __c() {} // 0x000000018A697EA4-0x000000018A697EF4
					public __c() {} // 0x000000018A697DF0-0x000000018A697E50
	
					// Methods
					internal EnumReservedRange _.cctor_b__41_0() => default; // 0x000000018A698250-0x000000018A698290
				}
	
				// Constructors
				public EnumReservedRange() {} // 0x000000018A697E50-0x000000018A697EA4
				public EnumReservedRange(EnumReservedRange other) {} // 0x000000018A698290-0x000000018A6982F8
				static EnumReservedRange() {} // 0x000000018A6A8660-0x000000018A6A86C0
	
				// Methods
				public EnumReservedRange Clone() => default; // 0x00000001847EB9E0-0x00000001847EB9F0
				public void ClearStart() {} // 0x0000000184A4EDC0-0x0000000184A4EDD0
				public void ClearEnd() {} // 0x000000018A6975E8-0x000000018A69770C
				public override bool Equals(object other) => default; // 0x000000018A69770C-0x000000018A6977D8
				public bool Equals(EnumReservedRange other) => default; // 0x000000018A69792C-0x000000018A697978
				public override int GetHashCode() => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
				public override string ToString() => default; // 0x000000018A6980E0-0x000000018A698250
				public void WriteTo(CodedOutputStream output) {} // 0x000000018A69739C-0x000000018A697524
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018A6977D8-0x000000018A69792C
				public int CalculateSize() => default; // 0x0000000185FA7960-0x0000000185FA7990
				public void MergeFrom(EnumReservedRange other) {} // 0x000000018A697EF4-0x000000018A6980E0
				public void MergeFrom(CodedInputStream input) {} // 0x000000018A697978-0x000000018A697BC4
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018A6A8714-0x000000018A6A8764
			}
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53456
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6A8840-0x000000018A6A8880
			public __c() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal EnumDescriptorProto _.cctor_b__52_0() => default; // 0x0000000187355704-0x000000018735574C
		}
	
		// Constructors
		public EnumDescriptorProto() {} // 0x00000001841B1DD0-0x00000001841B1DE0
		public EnumDescriptorProto(EnumDescriptorProto other) {} // 0x0000000185FB0C60-0x0000000185FB0C70
		static EnumDescriptorProto() {} // 0x000000018A6B53EC-0x000000018A6B543C
	
		// Methods
		public EnumDescriptorProto Clone() => default; // 0x000000018A6A86C0-0x000000018A6A8714
		public void ClearName() {} // 0x000000018A6A8348-0x000000018A6A83AC
		public override bool Equals(object other) => default; // 0x000000018A6A823C-0x000000018A6A82E8
		public bool Equals(EnumDescriptorProto other) => default; // 0x000000018A6A847C-0x000000018A6A84E8
		public override int GetHashCode() => default; // 0x0000000185FA7960-0x0000000185FA7990
		public override string ToString() => default; // 0x000000018A6A15F8-0x000000018A6A1694
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6A8534-0x000000018A6A8660
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018A6B5C08-0x000000018A6B5C6C
		public int CalculateSize() => default; // 0x0000000185492010-0x0000000185492020
		public void MergeFrom(EnumDescriptorProto other) {} // 0x000000018A6B52D4-0x000000018A6B5310
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6B594C-0x000000018A6B59B0
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class EnumValueDescriptorProto : IMessage<EnumValueDescriptorProto>, IBufferMessage // TypeDefIndex: 53459
	{
		// Fields
		private static readonly MessageParser<EnumValueDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		private int _hasBits0; // 0x18
		public const int NameFieldNumber = 1; // Metadata: 0x020781F0
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x20
		public const int NumberFieldNumber = 2; // Metadata: 0x020781F1
		private static readonly int NumberDefaultValue; // 0x10
		private int number_; // 0x28
		public const int OptionsFieldNumber = 3; // Metadata: 0x020781F2
		private EnumValueOptions options_; // 0x30
	
		// Properties
		public static MessageParser<EnumValueDescriptorProto> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6A8DD8-0x000000018A6A8E58 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6A8954-0x000000018A6A89B4 
		public string Name { get => default; set {} } // 0x000000018A69AD8C-0x000000018A69ADA0 0x000000018A6A8F0C-0x000000018A6A8F60
		public bool HasName { get => default; } // 0x0000000185FCC930-0x0000000185FCC940 
		public int Number { get => default; set {} } // 0x0000000185FB0C60-0x0000000185FB0C70 0x00000001813B51D0-0x00000001813B51E0
		public bool HasNumber { get => default; } // 0x00000001864721F0-0x0000000186472200 
		public EnumValueOptions Options { get => default; set {} } // 0x000000018A6A8A18-0x000000018A6A8AB4 0x000000018A6A8AB4-0x000000018A6A8B3C
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53458
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6A8F60-0x000000018A6A8FB0
			public __c() {} // 0x000000018A6A8E58-0x000000018A6A8EB8
	
			// Methods
			internal EnumValueDescriptorProto _.cctor_b__46_0() => default; // 0x000000018A6A9178-0x000000018A6A91B8
		}
	
		// Constructors
		public EnumValueDescriptorProto() {} // 0x000000018A6A8EB8-0x000000018A6A8F0C
		public EnumValueDescriptorProto(EnumValueDescriptorProto other) {} // 0x000000018A6A91B8-0x000000018A6A9220
		static EnumValueDescriptorProto() {} // 0x000000018A6B5310-0x000000018A6B534C
	
		// Methods
		public EnumValueDescriptorProto Clone() => default; // 0x000000018A69B84C-0x000000018A69B858
		public void ClearName() {} // 0x00000001841B1DD0-0x00000001841B1DE0
		public void ClearNumber() {} // 0x000000018A6A89B4-0x000000018A6A8A18
		public override bool Equals(object other) => default; // 0x000000018A6A8C30-0x000000018A6A8C7C
		public bool Equals(EnumValueDescriptorProto other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A6A90D0-0x000000018A6A9178
		public override string ToString() => default; // 0x000000018A6A8880-0x000000018A6A8954
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6A8B3C-0x000000018A6A8C30
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6A8FB0-0x000000018A6A90D0
		public void MergeFrom(EnumValueDescriptorProto other) {} // 0x000000018A6A8C7C-0x000000018A6A8DD8
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6B5B40-0x000000018A6B5BA4
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class ServiceDescriptorProto : IMessage<ServiceDescriptorProto>, IBufferMessage // TypeDefIndex: 53461
	{
		// Fields
		private static readonly MessageParser<ServiceDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x020781F3
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x18
		public const int MethodFieldNumber = 2; // Metadata: 0x020781F4
		private static readonly FieldCodec<MethodDescriptorProto> _repeated_method_codec; // 0x10
		private readonly RepeatedField<MethodDescriptorProto> method_; // 0x20
		public const int OptionsFieldNumber = 3; // Metadata: 0x020781F5
		private ServiceOptions options_; // 0x28
	
		// Properties
		public static MessageParser<ServiceDescriptorProto> Parser { get => default; } // 0x000000018A6B3A14-0x000000018A6B3A8C 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6B3A8C-0x000000018A6B3B50 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6B3508-0x000000018A6B3568 
		public string Name { get => default; set {} } // 0x000000018570A480-0x000000018570A4A0 0x00000001813B31A0-0x00000001813B31B0
		public bool HasName { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
		public RepeatedField<MethodDescriptorProto> Method { get => default; } // 0x000000018A6B362C-0x000000018A6B3690 
		public ServiceOptions Options { get => default; set {} } // 0x000000018A6B3568-0x000000018A6B362C 0x000000018A6B3690-0x000000018A6B3718
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53460
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6B3C04-0x000000018A6B3C54
			public __c() {} // 0x000000018A6B3B50-0x000000018A6B3BB0
	
			// Methods
			internal ServiceDescriptorProto _.cctor_b__41_0() => default; // 0x000000018A6B3E98-0x000000018A6B3ED8
		}
	
		// Constructors
		public ServiceDescriptorProto() {} // 0x000000018A6B3BB0-0x000000018A6B3C04
		public ServiceDescriptorProto(ServiceDescriptorProto other) {} // 0x000000018A6B3ED8-0x000000018A6B3F40
		static ServiceDescriptorProto() {} // 0x000000018A6B5248-0x000000018A6B5298
	
		// Methods
		public ServiceDescriptorProto Clone() => default; // 0x00000001847EB9E0-0x00000001847EB9F0
		public void ClearName() {} // 0x0000000184A4EDC0-0x0000000184A4EDD0
		public override bool Equals(object other) => default; // 0x000000018A6B381C-0x000000018A6B3868
		public bool Equals(ServiceDescriptorProto other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A6B3DA8-0x000000018A6B3E98
		public override string ToString() => default; // 0x000000018A6B3408-0x000000018A6B3508
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6B3718-0x000000018A6B381C
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6B3C54-0x000000018A6B3DA8
		public void MergeFrom(ServiceDescriptorProto other) {} // 0x000000018A6B3868-0x000000018A6B3A14
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6B5D34-0x000000018A6B5D98
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class MethodDescriptorProto : IMessage<MethodDescriptorProto>, IBufferMessage // TypeDefIndex: 53463
	{
		// Fields
		private static readonly MessageParser<MethodDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		private int _hasBits0; // 0x18
		public const int NameFieldNumber = 1; // Metadata: 0x020781F6
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x20
		public const int InputTypeFieldNumber = 2; // Metadata: 0x020781F7
		private static readonly string InputTypeDefaultValue; // 0x10
		private string inputType_; // 0x28
		public const int OutputTypeFieldNumber = 3; // Metadata: 0x020781F8
		private static readonly string OutputTypeDefaultValue; // 0x18
		private string outputType_; // 0x30
		public const int OptionsFieldNumber = 4; // Metadata: 0x020781F9
		private MethodOptions options_; // 0x38
		public const int ClientStreamingFieldNumber = 5; // Metadata: 0x020781FA
		private static readonly bool ClientStreamingDefaultValue; // 0x20
		private bool clientStreaming_; // 0x40
		public const int ServerStreamingFieldNumber = 6; // Metadata: 0x020781FB
		private static readonly bool ServerStreamingDefaultValue; // 0x21
		private bool serverStreaming_; // 0x41
	
		// Properties
		public static MessageParser<MethodDescriptorProto> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6B1158-0x000000018A6B1204 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6B0AE0-0x000000018A6B0B40 
		public string Name { get => default; set {} } // 0x000000018A69AD8C-0x000000018A69ADA0 0x000000018A6B12B8-0x000000018A6B130C
		public bool HasName { get => default; } // 0x000000018A6B1744-0x000000018A6B17AC 
		public string InputType { get => default; set {} } // 0x000000018A3B9E90-0x000000018A3B9EA4 0x000000018A6B1360-0x000000018A6B13B4
		public bool HasInputType { get => default; } // 0x000000018A6B1814-0x000000018A6B187C 
		public string OutputType { get => default; set {} } // 0x0000000187773EB8-0x0000000187773ECC 0x00000001813ECBC0-0x00000001813ECBD0
		public bool HasOutputType { get => default; } // 0x0000000185A16440-0x0000000185A16450 
		public MethodOptions Options { get => default; set {} } // 0x0000000185FCCB80-0x0000000185FCCB90 0x00000001841B1DD0-0x00000001841B1DE0
		public bool ClientStreaming { get => default; set {} } // 0x0000000185FB0C60-0x0000000185FB0C70 0x000000018A6B1404-0x000000018A6B1458
		public bool HasClientStreaming { get => default; } // 0x0000000185FCCB90-0x0000000185FCCBA0 
		public bool ServerStreaming { get => default; set {} } // 0x0000000185FCC8C0-0x0000000185FCC8D0 0x000000018A6B0C58-0x000000018A6B0CBC
		public bool HasServerStreaming { get => default; } // 0x000000018A6B0B40-0x000000018A6B0C58 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53462
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6B13B4-0x000000018A6B1404
			public __c() {} // 0x000000018A6B1258-0x000000018A6B12B8
	
			// Methods
			internal MethodDescriptorProto _.cctor_b__73_0() => default; // 0x000000018A6B1704-0x000000018A6B1744
		}
	
		// Constructors
		public MethodDescriptorProto() {} // 0x000000018A6B130C-0x000000018A6B1360
		public MethodDescriptorProto(MethodDescriptorProto other) {} // 0x000000018A6B17AC-0x000000018A6B1814
		static MethodDescriptorProto() {} // 0x000000018A6B557C-0x000000018A6B55B8
	
		// Methods
		public MethodDescriptorProto Clone() => default; // 0x000000018A69B84C-0x000000018A69B858
		public void ClearName() {} // 0x00000001878567E4-0x00000001878567F0
		public void ClearInputType() {} // 0x000000018A6AD3DC-0x000000018A6AD3E8
		public void ClearOutputType() {} // 0x000000018A6B1204-0x000000018A6B1258
		public void ClearClientStreaming() {} // 0x00000001817CD360-0x00000001817CD370
		public void ClearServerStreaming() {} // 0x000000018A6B0CBC-0x000000018A6B0DFC
		public override bool Equals(object other) => default; // 0x000000018A6B0F44-0x000000018A6B0F90
		public bool Equals(MethodDescriptorProto other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A6B15D8-0x000000018A6B1704
		public override string ToString() => default; // 0x000000018A6B09C8-0x000000018A6B0AE0
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6B0DFC-0x000000018A6B0F44
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6B1458-0x000000018A6B15D8
		public void MergeFrom(MethodDescriptorProto other) {} // 0x000000018A6B0F90-0x000000018A6B1158
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6B56F4-0x000000018A6B5758
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class FileOptions : IExtendableMessage<Google.Protobuf.Reflection.FileOptions>, IBufferMessage // TypeDefIndex: 53467
	{
		// Fields
		private static readonly MessageParser<FileOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<FileOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int JavaPackageFieldNumber = 1; // Metadata: 0x020781FC
		private static readonly string JavaPackageDefaultValue; // 0x08
		private string javaPackage_; // 0x28
		public const int JavaOuterClassnameFieldNumber = 8; // Metadata: 0x020781FD
		private static readonly string JavaOuterClassnameDefaultValue; // 0x10
		private string javaOuterClassname_; // 0x30
		public const int JavaMultipleFilesFieldNumber = 10; // Metadata: 0x020781FE
		private static readonly bool JavaMultipleFilesDefaultValue; // 0x18
		private bool javaMultipleFiles_; // 0x38
		public const int JavaGenerateEqualsAndHashFieldNumber = 20; // Metadata: 0x020781FF
		private static readonly bool JavaGenerateEqualsAndHashDefaultValue; // 0x19
		private bool javaGenerateEqualsAndHash_; // 0x39
		public const int JavaStringCheckUtf8FieldNumber = 27; // Metadata: 0x02078200
		private static readonly bool JavaStringCheckUtf8DefaultValue; // 0x1A
		private bool javaStringCheckUtf8_; // 0x3A
		public const int OptimizeForFieldNumber = 9; // Metadata: 0x02078201
		private static readonly Types.OptimizeMode OptimizeForDefaultValue; // 0x1C
		private Types.OptimizeMode optimizeFor_; // 0x3C
		public const int GoPackageFieldNumber = 11; // Metadata: 0x02078202
		private static readonly string GoPackageDefaultValue; // 0x20
		private string goPackage_; // 0x40
		public const int CcGenericServicesFieldNumber = 16; // Metadata: 0x02078203
		private static readonly bool CcGenericServicesDefaultValue; // 0x28
		private bool ccGenericServices_; // 0x48
		public const int JavaGenericServicesFieldNumber = 17; // Metadata: 0x02078204
		private static readonly bool JavaGenericServicesDefaultValue; // 0x29
		private bool javaGenericServices_; // 0x49
		public const int PyGenericServicesFieldNumber = 18; // Metadata: 0x02078205
		private static readonly bool PyGenericServicesDefaultValue; // 0x2A
		private bool pyGenericServices_; // 0x4A
		public const int PhpGenericServicesFieldNumber = 42; // Metadata: 0x02078206
		private static readonly bool PhpGenericServicesDefaultValue; // 0x2B
		private bool phpGenericServices_; // 0x4B
		public const int DeprecatedFieldNumber = 23; // Metadata: 0x02078207
		private static readonly bool DeprecatedDefaultValue; // 0x2C
		private bool deprecated_; // 0x4C
		public const int CcEnableArenasFieldNumber = 31; // Metadata: 0x02078208
		private static readonly bool CcEnableArenasDefaultValue; // 0x2D
		private bool ccEnableArenas_; // 0x4D
		public const int ObjcClassPrefixFieldNumber = 36; // Metadata: 0x02078209
		private static readonly string ObjcClassPrefixDefaultValue; // 0x30
		private string objcClassPrefix_; // 0x50
		public const int CsharpNamespaceFieldNumber = 37; // Metadata: 0x0207820A
		private static readonly string CsharpNamespaceDefaultValue; // 0x38
		private string csharpNamespace_; // 0x58
		public const int SwiftPrefixFieldNumber = 39; // Metadata: 0x0207820B
		private static readonly string SwiftPrefixDefaultValue; // 0x40
		private string swiftPrefix_; // 0x60
		public const int PhpClassPrefixFieldNumber = 40; // Metadata: 0x0207820C
		private static readonly string PhpClassPrefixDefaultValue; // 0x48
		private string phpClassPrefix_; // 0x68
		public const int PhpNamespaceFieldNumber = 41; // Metadata: 0x0207820D
		private static readonly string PhpNamespaceDefaultValue; // 0x50
		private string phpNamespace_; // 0x70
		public const int PhpMetadataNamespaceFieldNumber = 44; // Metadata: 0x0207820E
		private static readonly string PhpMetadataNamespaceDefaultValue; // 0x58
		private string phpMetadataNamespace_; // 0x78
		public const int RubyPackageFieldNumber = 45; // Metadata: 0x0207820F
		private static readonly string RubyPackageDefaultValue; // 0x60
		private string rubyPackage_; // 0x80
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x02078210
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x68
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x88
	
		// Properties
		private ExtensionSet<FileOptions> _Extensions { get => default; } // 0x000000018A6AE1A0-0x000000018A6AE1E0 
		public static MessageParser<FileOptions> Parser { get => default; } // 0x000000018A6ACF98-0x000000018A6AD014 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6AD014-0x000000018A6AD1C8 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6AC0AC-0x000000018A6AC10C 
		public string JavaPackage { get => default; set {} } // 0x000000018A3B9E90-0x000000018A3B9EA4 0x000000018A6AD514-0x000000018A6AD568
		public bool HasJavaPackage { get => default; } // 0x000000018A6AE2B0-0x000000018A6AE318 
		public string JavaOuterClassname { get => default; set {} } // 0x0000000187773EB8-0x0000000187773ECC 0x000000018A6AD4C0-0x000000018A6AD514
		public bool HasJavaOuterClassname { get => default; } // 0x0000000185FCCB10-0x0000000185FCCB20 
		public bool JavaMultipleFiles { get => default; set {} } // 0x0000000185FCC9A0-0x0000000185FCC9B0 0x000000018A6AD418-0x000000018A6AD46C
		public bool HasJavaMultipleFiles { get => default; } // 0x0000000185FCCAF0-0x0000000185FCCB00 
		public bool JavaGenerateEqualsAndHash { get => default; set {} } // 0x0000000185FCCA10-0x0000000185FCCA20 0x000000018A6AD5BC-0x000000018A6AD610
		public bool HasJavaGenerateEqualsAndHash { get => default; } // 0x0000000185FCCB20-0x0000000185FCCB30 
		public bool JavaStringCheckUtf8 { get => default; set {} } // 0x0000000185FCCAA0-0x0000000185FCCAB0 0x000000018A6AD664-0x000000018A6AD6B8
		public bool HasJavaStringCheckUtf8 { get => default; } // 0x0000000185FCCB30-0x0000000185FCCB40 
		public Types.OptimizeMode OptimizeFor { get => default; set {} } // 0x0000000185FCC990-0x0000000185FCC9A0 0x000000018A6AD37C-0x000000018A6AD3D0
		public bool HasOptimizeFor { get => default; } // 0x000000018A6AE248-0x000000018A6AE2B0 
		public string GoPackage { get => default; set {} } // 0x000000018A69AD64-0x000000018A69AD78 0x000000018A6AD220-0x000000018A6AD274
		public bool HasGoPackage { get => default; } // 0x0000000185FCCAD0-0x0000000185FCCAE0 
		public bool CcGenericServices { get => default; set {} } // 0x0000000185FCC9D0-0x0000000185FCC9E0 0x000000018A6AD46C-0x000000018A6AD4C0
		public bool HasCcGenericServices { get => default; } // 0x0000000185FCCB00-0x0000000185FCCB10 
		public bool JavaGenericServices { get => default; set {} } // 0x0000000185FCC9F0-0x0000000185FCCA00 0x000000018A6AD85C-0x000000018A6AD8B0
		public bool HasJavaGenericServices { get => default; } // 0x0000000185FCCB50-0x0000000185FCCB60 
		public bool PyGenericServices { get => default; set {} } // 0x0000000185FCC9E0-0x0000000185FCC9F0 0x000000018A6AD75C-0x000000018A6AD7B4
		public bool HasPyGenericServices { get => default; } // 0x0000000185FCCB40-0x0000000185FCCB50 
		public bool PhpGenericServices { get => default; set {} } // 0x0000000185FCCAB0-0x0000000185FCCAC0 0x000000018A6AD2C8-0x000000018A6AD31C
		public bool HasPhpGenericServices { get => default; } // 0x0000000185FCCAE0-0x0000000185FCCAF0 
		public bool Deprecated { get => default; set {} } // 0x0000000185FCCA00-0x0000000185FCCA10 0x000000018A6AD1C8-0x000000018A6AD220
		public bool HasDeprecated { get => default; } // 0x0000000185FCCAC0-0x0000000185FCCAD0 
		public bool CcEnableArenas { get => default; set {} } // 0x0000000185FCCA90-0x0000000185FCCAA0 0x000000018A6AD610-0x000000018A6AD664
		public bool HasCcEnableArenas { get => default; } // 0x000000018A6AE380-0x000000018A6AE3E8 
		public string ObjcClassPrefix { get => default; set {} } // 0x0000000187F218AC-0x0000000187F218C0 0x000000018A6AD274-0x000000018A6AD2C8
		public bool HasObjcClassPrefix { get => default; } // 0x000000018A6AE1E0-0x000000018A6AE248 
		public string CsharpNamespace { get => default; set {} } // 0x000000018A69AD78-0x000000018A69AD8C 0x000000018A6AD908-0x000000018A6AD95C
		public bool HasCsharpNamespace { get => default; } // 0x000000018A6AE58C-0x000000018A6AE5F4 
		public string SwiftPrefix { get => default; set {} } // 0x0000000187908A08-0x0000000187908A1C 0x000000018A6AD708-0x000000018A6AD75C
		public bool HasSwiftPrefix { get => default; } // 0x000000018A6AE3E8-0x000000018A6AE450 
		public string PhpClassPrefix { get => default; set {} } // 0x000000018A6AC070-0x000000018A6AC084 0x000000018A6AD808-0x000000018A6AD85C
		public bool HasPhpClassPrefix { get => default; } // 0x000000018A6AE4B8-0x000000018A6AE520 
		public string PhpNamespace { get => default; set {} } // 0x000000018A69D534-0x000000018A69D548 0x000000018A6AD7B4-0x000000018A6AD808
		public bool HasPhpNamespace { get => default; } // 0x000000018A6AE450-0x000000018A6AE4B8 
		public string PhpMetadataNamespace { get => default; set {} } // 0x000000018A6AC084-0x000000018A6AC098 0x000000018A6AD8B0-0x000000018A6AD908
		public bool HasPhpMetadataNamespace { get => default; } // 0x000000018A6AE520-0x000000018A6AE58C 
		public string RubyPackage { get => default; set {} } // 0x000000018A6AC098-0x000000018A6AC0AC 0x0000000185FB0510-0x0000000185FB0520
		public bool HasRubyPackage { get => default; } // 0x000000018A6AC10C-0x000000018A6AC170 
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x000000018A6AC500-0x000000018A6AC868 
	
		// Nested types
		public static class Types // TypeDefIndex: 53465
		{
			// Nested types
			public enum OptimizeMode // TypeDefIndex: 53464
			{
				Speed = 1,
				CodeSize = 2,
				LiteRuntime = 3
			}
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53466
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000181377E40-0x0000000181377E50
			public __c() {} // 0x000000018A6AD6B8-0x000000018A6AD708
	
			// Methods
			internal FileOptions _.cctor_b__219_0() => default; // 0x000000018A6AD31C-0x000000018A6AD37C
		}
	
		// Constructors
		public FileOptions() {} // 0x000000018A6AD568-0x000000018A6AD5BC
		public FileOptions(FileOptions other) {} // 0x000000018A6AE318-0x000000018A6AE380
		static FileOptions() {} // 0x000000018A6B5108-0x000000018A6B5158
	
		// Methods
		public FileOptions Clone() => default; // 0x00000001878567E4-0x00000001878567F0
		public void ClearJavaPackage() {} // 0x000000018A6AD3DC-0x000000018A6AD3E8
		public void ClearJavaOuterClassname() {} // 0x000000018A6A7F54-0x000000018A6A7F5C
		public void ClearJavaMultipleFiles() {} // 0x000000018A6AB730-0x000000018A6AB738
		public void ClearJavaGenerateEqualsAndHash() {} // 0x000000018A6AD3E8-0x000000018A6AD3F4
		public void ClearJavaStringCheckUtf8() {} // 0x000000018A6A7F4C-0x000000018A6A7F54
		public void ClearOptimizeFor() {} // 0x0000000184A2A780-0x0000000184A2A790
		public void ClearGoPackage() {} // 0x000000018A6AB710-0x000000018A6AB718
		public void ClearCcGenericServices() {} // 0x000000018A6AB720-0x000000018A6AB728
		public void ClearJavaGenericServices() {} // 0x000000018A6AB718-0x000000018A6AB720
		public void ClearPyGenericServices() {} // 0x00000001859F22F0-0x00000001859F2300
		public void ClearPhpGenericServices() {} // 0x000000018A6AB728-0x000000018A6AB730
		public void ClearDeprecated() {} // 0x000000018A6AD3D0-0x000000018A6AD3DC
		public void ClearCcEnableArenas() {} // 0x000000018482D5A0-0x000000018482D5B0
		public void ClearObjcClassPrefix() {} // 0x0000000187E45764-0x0000000187E45770
		public void ClearCsharpNamespace() {} // 0x0000000187CD183C-0x0000000187CD1848
		public void ClearSwiftPrefix() {} // 0x000000018A6AD3F4-0x000000018A6AD400
		public void ClearPhpClassPrefix() {} // 0x000000018A69E57C-0x000000018A69E588
		public void ClearPhpNamespace() {} // 0x000000018A6AD400-0x000000018A6AD40C
		public void ClearPhpMetadataNamespace() {} // 0x000000018A6AD40C-0x000000018A6AD418
		public void ClearRubyPackage() {} // 0x000000018A6AC170-0x000000018A6AC500
		public override bool Equals(object other) => default; // 0x000000018A6ACB38-0x000000018A6ACB84
		public bool Equals(FileOptions other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A6ADD40-0x000000018A6AE1A0
		public override string ToString() => default; // 0x000000018A6ABD38-0x000000018A6AC070
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6AC868-0x000000018A6ACB38
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6AD95C-0x000000018A6ADD40
		public void MergeFrom(FileOptions other) {}
		public void MergeFrom(CodedInputStream input) {}
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {}
		public TValue GetExtension<TValue>(Extension<FileOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<FileOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<FileOptions, TValue> extension) => default; // 0x000000018A6ACB84-0x000000018A6ACF98
		public void ClearExtension<TValue>(Extension<FileOptions, TValue> extension) {} // 0x000000018A6B5C6C-0x000000018A6B5CD0
		public void ClearExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class MessageOptions : IExtendableMessage<MessageOptions>, IBufferMessage // TypeDefIndex: 53469
	{
		// Fields
		private static readonly MessageParser<MessageOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<MessageOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int MessageSetWireFormatFieldNumber = 1; // Metadata: 0x02078215
		private static readonly bool MessageSetWireFormatDefaultValue; // 0x08
		private bool messageSetWireFormat_; // 0x24
		public const int NoStandardDescriptorAccessorFieldNumber = 2; // Metadata: 0x02078216
		private static readonly bool NoStandardDescriptorAccessorDefaultValue; // 0x09
		private bool noStandardDescriptorAccessor_; // 0x25
		public const int DeprecatedFieldNumber = 3; // Metadata: 0x02078217
		private static readonly bool DeprecatedDefaultValue; // 0x0A
		private bool deprecated_; // 0x26
		public const int MapEntryFieldNumber = 7; // Metadata: 0x02078218
		private static readonly bool MapEntryDefaultValue; // 0x0B
		private bool mapEntry_; // 0x27
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x02078219
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x28
	
		// Properties
		private ExtensionSet<MessageOptions> _Extensions { get => default; } // 0x000000018A6B0988-0x000000018A6B09C8 
		public static MessageParser<MessageOptions> Parser { get => default; } // 0x000000018A6B0438-0x000000018A6B04B0 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6B036C-0x000000018A6B0438 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6AFDAC-0x000000018A6AFE0C 
		public bool MessageSetWireFormat { get => default; set {} } // 0x0000000185FCC990-0x0000000185FCC9A0 0x000000018A6B060C-0x000000018A6B0660
		public bool HasMessageSetWireFormat { get => default; } // 0x0000000185FCC9C0-0x0000000185FCC9D0 
		public bool NoStandardDescriptorAccessor { get => default; set {} } // 0x0000000185FCC9A0-0x0000000185FCC9B0 0x000000018A6B04B0-0x000000018A6B0504
		public bool HasNoStandardDescriptorAccessor { get => default; } // 0x0000000185FCCB60-0x0000000185FCCB70 
		public bool Deprecated { get => default; set {} } // 0x0000000185FCC9D0-0x0000000185FCC9E0 0x000000018A6B0564-0x000000018A6B05B8
		public bool HasDeprecated { get => default; } // 0x0000000185FCCB70-0x0000000185FCCB80 
		public bool MapEntry { get => default; set {} } // 0x0000000185FCC9F0-0x0000000185FCCA00 0x00000001813B8590-0x00000001813B85A0
		public bool HasMapEntry { get => default; } // 0x000000018A6AFE0C-0x000000018A6AFE70 
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x000000018A6AFF84-0x000000018A6B0098 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53468
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000181377E40-0x0000000181377E50
			public __c() {} // 0x000000018A6B0660-0x000000018A6B06B0
	
			// Methods
			internal MessageOptions _.cctor_b__74_0() => default; // 0x000000018A6B0504-0x000000018A6B0564
		}
	
		// Constructors
		public MessageOptions() {} // 0x000000018A6B05B8-0x000000018A6B060C
		public MessageOptions(MessageOptions other) {} // 0x0000000185FCC9B0-0x0000000185FCC9C0
		static MessageOptions() {} // 0x000000018A6B55B8-0x000000018A6B5608
	
		// Methods
		public MessageOptions Clone() => default; // 0x000000018A6A7F4C-0x000000018A6A7F54
		public void ClearMessageSetWireFormat() {} // 0x000000018A6A7F54-0x000000018A6A7F5C
		public void ClearNoStandardDescriptorAccessor() {} // 0x000000018A6AB710-0x000000018A6AB718
		public void ClearDeprecated() {} // 0x000000018A6AB720-0x000000018A6AB728
		public void ClearMapEntry() {} // 0x000000018A6AFE70-0x000000018A6AFF84
		public override bool Equals(object other) => default; // 0x000000018A6B0190-0x000000018A6B01DC
		public bool Equals(MessageOptions other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A6B0818-0x000000018A6B0988
		public override string ToString() => default; // 0x000000018A6AFCC4-0x000000018A6AFDAC
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6B0098-0x000000018A6B0190
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6B06B0-0x000000018A6B0818
		public void MergeFrom(MessageOptions other) {}
		public void MergeFrom(CodedInputStream input) {}
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {}
		public TValue GetExtension<TValue>(Extension<MessageOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<MessageOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<MessageOptions, TValue> extension) => default; // 0x000000018A6B01DC-0x000000018A6B036C
		public void ClearExtension<TValue>(Extension<MessageOptions, TValue> extension) {} // 0x000000018A6B5A78-0x000000018A6B5ADC
		public void ClearExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class FieldOptions : IExtendableMessage<Google.Protobuf.Reflection.FieldOptions>, IBufferMessage // TypeDefIndex: 53474
	{
		// Fields
		private static readonly MessageParser<FieldOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<FieldOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int CtypeFieldNumber = 1; // Metadata: 0x0207821B
		private static readonly Types.CType CtypeDefaultValue; // 0x08
		private Types.CType ctype_; // 0x24
		public const int PackedFieldNumber = 2; // Metadata: 0x0207821C
		private static readonly bool PackedDefaultValue; // 0x0C
		private bool packed_; // 0x28
		public const int JstypeFieldNumber = 6; // Metadata: 0x0207821D
		private static readonly Types.JSType JstypeDefaultValue; // 0x10
		private Types.JSType jstype_; // 0x2C
		public const int LazyFieldNumber = 5; // Metadata: 0x0207821E
		private static readonly bool LazyDefaultValue; // 0x14
		private bool lazy_; // 0x30
		public const int UnverifiedLazyFieldNumber = 15; // Metadata: 0x0207821F
		private static readonly bool UnverifiedLazyDefaultValue; // 0x15
		private bool unverifiedLazy_; // 0x31
		public const int DeprecatedFieldNumber = 3; // Metadata: 0x02078220
		private static readonly bool DeprecatedDefaultValue; // 0x16
		private bool deprecated_; // 0x32
		public const int WeakFieldNumber = 10; // Metadata: 0x02078221
		private static readonly bool WeakDefaultValue; // 0x17
		private bool weak_; // 0x33
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x02078222
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x18
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x38
	
		// Properties
		private ExtensionSet<FieldOptions> _Extensions { get => default; } // 0x000000018A6ABCF8-0x000000018A6ABD38 
		public static MessageParser<FieldOptions> Parser { get => default; } // 0x000000018A6AB590-0x000000018A6AB608 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6AB4AC-0x000000018A6AB590 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6AADD4-0x000000018A6AAE34 
		public Types.CType Ctype { get => default; set {} } // 0x0000000185FCC990-0x0000000185FCC9A0 0x000000018A6AB7E0-0x000000018A6AB834
		public bool HasCtype { get => default; } // 0x0000000185FCCA60-0x0000000185FCCA70 
		public bool Packed { get => default; set {} } // 0x0000000185FCC9A0-0x0000000185FCC9B0 0x000000018A6AB738-0x000000018A6AB78C
		public bool HasPacked { get => default; } // 0x0000000185FCCA40-0x0000000185FCCA50 
		public Types.JSType Jstype { get => default; set {} } // 0x0000000185FCC9E0-0x0000000185FCC9F0 0x000000018A6AB78C-0x000000018A6AB7E0
		public bool HasJstype { get => default; } // 0x0000000185FCCA50-0x0000000185FCCA60 
		public bool Lazy { get => default; set {} } // 0x0000000185FCC9F0-0x0000000185FCCA00 0x000000018A6AB884-0x000000018A6AB8D8
		public bool HasLazy { get => default; } // 0x0000000185FCCA70-0x0000000185FCCA80 
		public bool UnverifiedLazy { get => default; set {} } // 0x0000000185FCCA00-0x0000000185FCCA10 0x000000018A6AB65C-0x000000018A6AB6B0
		public bool HasUnverifiedLazy { get => default; } // 0x0000000185FCCA30-0x0000000185FCCA40 
		public bool Deprecated { get => default; set {} } // 0x0000000185FCC9D0-0x0000000185FCC9E0 0x000000018A6AB8D8-0x000000018A6AB92C
		public bool HasDeprecated { get => default; } // 0x0000000185FCCA80-0x0000000185FCCA90 
		public bool Weak { get => default; set {} } // 0x0000000185FCCA10-0x0000000185FCCA20 0x00000001813ECBC0-0x00000001813ECBD0
		public bool HasWeak { get => default; } // 0x000000018A6AAE34-0x000000018A6AAE98 
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x000000018A6AB004-0x000000018A6AB15C 
	
		// Nested types
		public static class Types // TypeDefIndex: 53472
		{
			// Nested types
			public enum CType // TypeDefIndex: 53470
			{
				String = 0,
				Cord = 1,
				StringPiece = 2
			}
	
			public enum JSType // TypeDefIndex: 53471
			{
				JsNormal = 0,
				JsString = 1,
				JsNumber = 2
			}
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53473
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000181377E40-0x0000000181377E50
			public __c() {} // 0x000000018A6AB834-0x000000018A6AB884
	
			// Methods
			internal FieldOptions _.cctor_b__102_0() => default; // 0x000000018A6AB6B0-0x000000018A6AB710
		}
	
		// Constructors
		public FieldOptions() {} // 0x000000018A6AB608-0x000000018A6AB65C
		public FieldOptions(FieldOptions other) {} // 0x0000000185FCCA20-0x0000000185FCCA30
		static FieldOptions() {} // 0x000000018A6B50B8-0x000000018A6B5108
	
		// Methods
		public FieldOptions Clone() => default; // 0x000000018A6A7F4C-0x000000018A6A7F54
		public void ClearCtype() {} // 0x000000018A6A7F54-0x000000018A6A7F5C
		public void ClearPacked() {} // 0x000000018A6AB718-0x000000018A6AB720
		public void ClearJstype() {} // 0x000000018A6AB720-0x000000018A6AB728
		public void ClearLazy() {} // 0x000000018A6AB728-0x000000018A6AB730
		public void ClearUnverifiedLazy() {} // 0x000000018A6AB710-0x000000018A6AB718
		public void ClearDeprecated() {} // 0x000000018A6AB730-0x000000018A6AB738
		public void ClearWeak() {} // 0x000000018A6AAE98-0x000000018A6AB004
		public override bool Equals(object other) => default; // 0x000000018A6AB29C-0x000000018A6AB2E8
		public bool Equals(FieldOptions other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A6ABB08-0x000000018A6ABCF8
		public override string ToString() => default; // 0x000000018A6AAC6C-0x000000018A6AADD4
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6AB15C-0x000000018A6AB29C
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6AB92C-0x000000018A6ABB08
		public void MergeFrom(FieldOptions other) {}
		public void MergeFrom(CodedInputStream input) {}
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {}
		public TValue GetExtension<TValue>(Extension<FieldOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<FieldOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<FieldOptions, TValue> extension) => default; // 0x000000018A6AB2E8-0x000000018A6AB4AC
		public void ClearExtension<TValue>(Extension<FieldOptions, TValue> extension) {} // 0x000000018A6B58E8-0x000000018A6B594C
		public void ClearExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class OneofOptions : IExtendableMessage<OneofOptions>, IBufferMessage // TypeDefIndex: 53476
	{
		// Fields
		private static readonly MessageParser<OneofOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<OneofOptions> _extensions; // 0x18
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x0207822A
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x20
	
		// Properties
		private ExtensionSet<OneofOptions> _Extensions { get => default; } // 0x000000018A6B33C8-0x000000018A6B3408 
		public static MessageParser<OneofOptions> Parser { get => default; } // 0x000000018A6B30D8-0x000000018A6B3150 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6B3028-0x000000018A6B30D8 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6B2C80-0x000000018A6B2CE0 
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x000000018A699BEC-0x000000018A699C54 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53475
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000181377E40-0x0000000181377E50
			public __c() {} // 0x000000018A6B31B0-0x000000018A6B3200
	
			// Methods
			internal OneofOptions _.cctor_b__37_0() => default; // 0x000000018A6B3150-0x000000018A6B31B0
		}
	
		// Constructors
		public OneofOptions() {} // 0x00000001813B31A0-0x00000001813B31B0
		public OneofOptions(OneofOptions other) {} // 0x000000018A6B2D70-0x000000018A6B2DD4
		static OneofOptions() {} // 0x000000018A6B51F8-0x000000018A6B5248
	
		// Methods
		public OneofOptions Clone() => default; // 0x000000018A6B2CE0-0x000000018A6B2D70
		public override bool Equals(object other) => default; // 0x000000018A6B2E6C-0x000000018A6B2EB8
		public bool Equals(OneofOptions other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A6B3300-0x000000018A6B33C8
		public override string ToString() => default; // 0x000000018A6B2BC4-0x000000018A6B2C80
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6B2DD4-0x000000018A6B2E6C
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6B3200-0x000000018A6B3300
		public void MergeFrom(OneofOptions other) {}
		public void MergeFrom(CodedInputStream input) {}
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {}
		public TValue GetExtension<TValue>(Extension<OneofOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<OneofOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<OneofOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<OneofOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<OneofOptions, TValue> extension) => default; // 0x000000018A6B2EB8-0x000000018A6B3028
		public void ClearExtension<TValue>(Extension<OneofOptions, TValue> extension) {} // 0x000000018A6B5CD0-0x000000018A6B5D34
		public void ClearExtension<TValue>(RepeatedExtension<OneofOptions, TValue> extension) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class EnumOptions : IExtendableMessage<EnumOptions>, IBufferMessage // TypeDefIndex: 53478
	{
		// Fields
		private static readonly MessageParser<EnumOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<EnumOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int AllowAliasFieldNumber = 2; // Metadata: 0x0207822C
		private static readonly bool AllowAliasDefaultValue; // 0x08
		private bool allowAlias_; // 0x24
		public const int DeprecatedFieldNumber = 3; // Metadata: 0x0207822D
		private static readonly bool DeprecatedDefaultValue; // 0x09
		private bool deprecated_; // 0x25
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x0207822E
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x28
	
		// Properties
		private ExtensionSet<EnumOptions> _Extensions { get => default; } // 0x000000018A6A81FC-0x000000018A6A823C 
		public static MessageParser<EnumOptions> Parser { get => default; } // 0x000000018A6A7DCC-0x000000018A6A7E44 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6A7D0C-0x000000018A6A7DCC 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6A7800-0x000000018A6A7860 
		public bool AllowAlias { get => default; set {} } // 0x0000000185FCC990-0x0000000185FCC9A0 0x000000018A6A7E98-0x000000018A6A7EEC
		public bool HasAllowAlias { get => default; } // 0x0000000185FCC9C0-0x0000000185FCC9D0 
		public bool Deprecated { get => default; set {} } // 0x0000000185FCC9A0-0x0000000185FCC9B0 0x00000001813B8590-0x00000001813B85A0
		public bool HasDeprecated { get => default; } // 0x000000018A6A7860-0x000000018A6A78C4 
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x000000018A6A7998-0x000000018A6A7A68 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53477
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000181377E40-0x0000000181377E50
			public __c() {} // 0x000000018A6A7F5C-0x000000018A6A7FAC
	
			// Methods
			internal EnumOptions _.cctor_b__56_0() => default; // 0x000000018A6A7EEC-0x000000018A6A7F4C
		}
	
		// Constructors
		public EnumOptions() {} // 0x000000018A6A7E44-0x000000018A6A7E98
		public EnumOptions(EnumOptions other) {} // 0x0000000185FCC9B0-0x0000000185FCC9C0
		static EnumOptions() {} // 0x000000018A6B54DC-0x000000018A6B552C
	
		// Methods
		public EnumOptions Clone() => default; // 0x000000018A6A7F4C-0x000000018A6A7F54
		public void ClearAllowAlias() {} // 0x000000018A6A7F54-0x000000018A6A7F5C
		public void ClearDeprecated() {} // 0x000000018A6A78C4-0x000000018A6A7998
		public override bool Equals(object other) => default; // 0x000000018A6A7B30-0x000000018A6A7B7C
		public bool Equals(EnumOptions other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A6A80E0-0x000000018A6A81FC
		public override string ToString() => default; // 0x000000018A6A7728-0x000000018A6A7800
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6A7A68-0x000000018A6A7B30
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6A7FAC-0x000000018A6A80E0
		public void MergeFrom(EnumOptions other) {}
		public void MergeFrom(CodedInputStream input) {}
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {}
		public TValue GetExtension<TValue>(Extension<EnumOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<EnumOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<EnumOptions, TValue> extension) => default; // 0x000000018A6A7B7C-0x000000018A6A7D0C
		public void ClearExtension<TValue>(Extension<EnumOptions, TValue> extension) {} // 0x000000018A6B57BC-0x000000018A6B5820
		public void ClearExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class EnumValueOptions : IExtendableMessage<EnumValueOptions>, IBufferMessage // TypeDefIndex: 53480
	{
		// Fields
		private static readonly MessageParser<EnumValueOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<EnumValueOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int DeprecatedFieldNumber = 1; // Metadata: 0x02078230
		private static readonly bool DeprecatedDefaultValue; // 0x08
		private bool deprecated_; // 0x24
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x02078231
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x28
	
		// Properties
		private ExtensionSet<EnumValueOptions> _Extensions { get => default; } // 0x000000018A6A9DE8-0x000000018A6A9E28 
		public static MessageParser<EnumValueOptions> Parser { get => default; } // 0x000000018A6A9A60-0x000000018A6A9AD8 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6A99A4-0x000000018A6A9A60 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6A9500-0x000000018A6A9560 
		public bool Deprecated { get => default; set {} } // 0x0000000185FCC990-0x0000000185FCC9A0 0x00000001813B8590-0x00000001813B85A0
		public bool HasDeprecated { get => default; } // 0x000000018A6A9560-0x000000018A6A95C4 
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x000000018A6A9678-0x000000018A6A9724 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53479
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000181377E40-0x0000000181377E50
			public __c() {} // 0x000000018A6A9B8C-0x000000018A6A9BDC
	
			// Methods
			internal EnumValueOptions _.cctor_b__47_0() => default; // 0x000000018A6A9B2C-0x000000018A6A9B8C
		}
	
		// Constructors
		public EnumValueOptions() {} // 0x000000018A6A9AD8-0x000000018A6A9B2C
		public EnumValueOptions(EnumValueOptions other) {} // 0x0000000185FCC9B0-0x0000000185FCC9C0
		static EnumValueOptions() {} // 0x000000018A6B539C-0x000000018A6B53EC
	
		// Methods
		public EnumValueOptions Clone() => default; // 0x000000018A6A7F4C-0x000000018A6A7F54
		public void ClearDeprecated() {} // 0x000000018A6A95C4-0x000000018A6A9678
		public override bool Equals(object other) => default; // 0x000000018A6A97D4-0x000000018A6A9820
		public bool Equals(EnumValueOptions other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A6A9CF4-0x000000018A6A9DE8
		public override string ToString() => default; // 0x000000018A6A9434-0x000000018A6A9500
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6A9724-0x000000018A6A97D4
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6A9BDC-0x000000018A6A9CF4
		public void MergeFrom(EnumValueOptions other) {}
		public void MergeFrom(CodedInputStream input) {}
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {}
		public TValue GetExtension<TValue>(Extension<EnumValueOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<EnumValueOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<EnumValueOptions, TValue> extension) => default; // 0x000000018A6A9820-0x000000018A6A99A4
		public void ClearExtension<TValue>(Extension<EnumValueOptions, TValue> extension) {} // 0x000000018A6B5820-0x000000018A6B5884
		public void ClearExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class ServiceOptions : IExtendableMessage<ServiceOptions>, IBufferMessage // TypeDefIndex: 53482
	{
		// Fields
		private static readonly MessageParser<ServiceOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<ServiceOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int DeprecatedFieldNumber = 33; // Metadata: 0x02078233
		private static readonly bool DeprecatedDefaultValue; // 0x08
		private bool deprecated_; // 0x24
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x02078234
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x28
	
		// Properties
		private ExtensionSet<ServiceOptions> _Extensions { get => default; } // 0x000000018A6B490C-0x000000018A6B494C 
		public static MessageParser<ServiceOptions> Parser { get => default; } // 0x000000018A6B44C0-0x000000018A6B4538 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6B4538-0x000000018A6B45F4 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6B401C-0x000000018A6B407C 
		public bool Deprecated { get => default; set {} } // 0x0000000185FCC990-0x0000000185FCC9A0 0x00000001813B8590-0x00000001813B85A0
		public bool HasDeprecated { get => default; } // 0x000000018A6B4130-0x000000018A6B4194 
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x000000018A6B4194-0x000000018A6B4240 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53481
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000181377E40-0x0000000181377E50
			public __c() {} // 0x000000018A6B46A8-0x000000018A6B46F8
	
			// Methods
			internal ServiceOptions _.cctor_b__47_0() => default; // 0x000000018A6B4648-0x000000018A6B46A8
		}
	
		// Constructors
		public ServiceOptions() {} // 0x000000018A6B45F4-0x000000018A6B4648
		public ServiceOptions(ServiceOptions other) {} // 0x0000000185FCC9B0-0x0000000185FCC9C0
		static ServiceOptions() {} // 0x000000018A6B534C-0x000000018A6B539C
	
		// Methods
		public ServiceOptions Clone() => default; // 0x000000018A6A7F4C-0x000000018A6A7F54
		public void ClearDeprecated() {} // 0x000000018A6B407C-0x000000018A6B4130
		public override bool Equals(object other) => default; // 0x000000018A6B42F0-0x000000018A6B433C
		public bool Equals(ServiceOptions other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A6B4814-0x000000018A6B490C
		public override string ToString() => default; // 0x000000018A6B3F40-0x000000018A6B401C
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6B4240-0x000000018A6B42F0
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6B46F8-0x000000018A6B4814
		public void MergeFrom(ServiceOptions other) {}
		public void MergeFrom(CodedInputStream input) {}
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {}
		public TValue GetExtension<TValue>(Extension<ServiceOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<ServiceOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<ServiceOptions, TValue> extension) => default; // 0x000000018A6B433C-0x000000018A6B44C0
		public void ClearExtension<TValue>(Extension<ServiceOptions, TValue> extension) {} // 0x000000018A6B5884-0x000000018A6B58E8
		public void ClearExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class MethodOptions : IExtendableMessage<MethodOptions>, IBufferMessage // TypeDefIndex: 53486
	{
		// Fields
		private static readonly MessageParser<MethodOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<MethodOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int DeprecatedFieldNumber = 33; // Metadata: 0x02078236
		private static readonly bool DeprecatedDefaultValue; // 0x08
		private bool deprecated_; // 0x24
		public const int IdempotencyLevelFieldNumber = 34; // Metadata: 0x02078237
		private static readonly Types.IdempotencyLevel IdempotencyLevelDefaultValue; // 0x0C
		private Types.IdempotencyLevel idempotencyLevel_; // 0x28
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x02078238
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x30
	
		// Properties
		private ExtensionSet<MethodOptions> _Extensions { get => default; } // 0x000000018A6B237C-0x000000018A6B23BC 
		public static MessageParser<MethodOptions> Parser { get => default; } // 0x000000018A6B1F4C-0x000000018A6B1FC4 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6B1E8C-0x000000018A6B1F4C 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6B1990-0x000000018A6B19F0 
		public bool Deprecated { get => default; set {} } // 0x0000000185FCC990-0x0000000185FCC9A0 0x000000018A6B2078-0x000000018A6B20CC
		public bool HasDeprecated { get => default; } // 0x0000000185FCCBA0-0x0000000185FCCBB0 
		public Types.IdempotencyLevel IdempotencyLevel { get => default; set {} } // 0x0000000185FCC9A0-0x0000000185FCC9B0 0x00000001813B51D0-0x00000001813B51E0
		public bool HasIdempotencyLevel { get => default; } // 0x000000018A6B19F0-0x000000018A6B1A54 
		public RepeatedField<UninterpretedOption> UninterpretedOption { get => default; } // 0x000000018A6B1B28-0x000000018A6B1BE4 
	
		// Nested types
		public static class Types // TypeDefIndex: 53484
		{
			// Nested types
			public enum IdempotencyLevel // TypeDefIndex: 53483
			{
				IdempotencyUnknown = 0,
				NoSideEffects = 1,
				Idempotent = 2
			}
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53485
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000181377E40-0x0000000181377E50
			public __c() {} // 0x000000018A6B20CC-0x000000018A6B211C
	
			// Methods
			internal MethodOptions _.cctor_b__57_0() => default; // 0x000000018A6B2018-0x000000018A6B2078
		}
	
		// Constructors
		public MethodOptions() {} // 0x000000018A6B1FC4-0x000000018A6B2018
		public MethodOptions(MethodOptions other) {} // 0x0000000185FCC9B0-0x0000000185FCC9C0
		static MethodOptions() {} // 0x000000018A6B552C-0x000000018A6B557C
	
		// Methods
		public MethodOptions Clone() => default; // 0x000000018A6A7F4C-0x000000018A6A7F54
		public void ClearDeprecated() {} // 0x000000018A6A7F54-0x000000018A6A7F5C
		public void ClearIdempotencyLevel() {} // 0x000000018A6B1A54-0x000000018A6B1B28
		public override bool Equals(object other) => default; // 0x000000018A6B1CAC-0x000000018A6B1CF8
		public bool Equals(MethodOptions other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A6B2258-0x000000018A6B237C
		public override string ToString() => default; // 0x000000018A6B187C-0x000000018A6B1990
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6B1BE4-0x000000018A6B1CAC
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6B211C-0x000000018A6B2258
		public void MergeFrom(MethodOptions other) {}
		public void MergeFrom(CodedInputStream input) {}
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {}
		public TValue GetExtension<TValue>(Extension<MethodOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension) => default;
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension) => default;
		public void SetExtension<TValue>(Extension<MethodOptions, TValue> extension, TValue value) {}
		public bool HasExtension<TValue>(Extension<MethodOptions, TValue> extension) => default; // 0x000000018A6B1CF8-0x000000018A6B1E8C
		public void ClearExtension<TValue>(Extension<MethodOptions, TValue> extension) {} // 0x000000018A6B5A14-0x000000018A6B5A78
		public void ClearExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class UninterpretedOption : IMessage<UninterpretedOption>, IBufferMessage // TypeDefIndex: 53491
	{
		// Fields
		private static readonly MessageParser<UninterpretedOption> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		private int _hasBits0; // 0x18
		public const int NameFieldNumber = 2; // Metadata: 0x0207823D
		private static readonly FieldCodec<Types.NamePart> _repeated_name_codec; // 0x08
		private readonly RepeatedField<Types.NamePart> name_; // 0x20
		public const int IdentifierValueFieldNumber = 3; // Metadata: 0x0207823E
		private static readonly string IdentifierValueDefaultValue; // 0x10
		private string identifierValue_; // 0x28
		public const int PositiveIntValueFieldNumber = 4; // Metadata: 0x0207823F
		private static readonly ulong PositiveIntValueDefaultValue; // 0x18
		private ulong positiveIntValue_; // 0x30
		public const int NegativeIntValueFieldNumber = 5; // Metadata: 0x02078240
		private static readonly long NegativeIntValueDefaultValue; // 0x20
		private long negativeIntValue_; // 0x38
		public const int DoubleValueFieldNumber = 6; // Metadata: 0x02078241
		private static readonly double DoubleValueDefaultValue; // 0x28
		private double doubleValue_; // 0x40
		public const int StringValueFieldNumber = 7; // Metadata: 0x02078242
		private static readonly ByteString StringValueDefaultValue; // 0x30
		private ByteString stringValue_; // 0x48
		public const int AggregateValueFieldNumber = 8; // Metadata: 0x02078243
		private static readonly string AggregateValueDefaultValue; // 0x38
		private string aggregateValue_; // 0x50
	
		// Properties
		public static MessageParser<UninterpretedOption> Parser { get => default; } // 0x000000018A6B6070-0x000000018A6B60D4 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6B60D4-0x000000018A6B62AC 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6B62AC-0x000000018A6B641C 
		public RepeatedField<Types.NamePart> Name { get => default; } // 0x000000018A6B5E60-0x000000018A6B6010 
		public string IdentifierValue { get => default; set {} } // 0x000000018A6B641C-0x000000018A6B6548 0x0000000185FA7960-0x0000000185FA7990
		public bool HasIdentifierValue { get => default; } // 0x000000018A6B6C4C-0x000000018A6B6E14 
		public ulong PositiveIntValue { get => default; set {} } // 0x000000018A6B29B0-0x000000018A6B2A00 0x000000018A6B28A8-0x000000018A6B2908
		public bool HasPositiveIntValue { get => default; } // 0x000000018A6B2B1C-0x000000018A6B2B5C 
		public long NegativeIntValue { get => default; set {} } // 0x000000018A6B2854-0x000000018A6B28A8 0x000000018A6B2440-0x000000018A6B24A0
		public bool HasNegativeIntValue { get => default; } // 0x000000018A6B295C-0x000000018A6B29B0 
		public double DoubleValue { get => default; set {} } // 0x000000018A69B84C-0x000000018A69B858 0x000000018A69AD8C-0x000000018A69ADA0
		public bool HasDoubleValue { get => default; } // 0x000000018A6B2908-0x000000018A6B295C 
		public ByteString StringValue { get => default; set {} } // 0x00000001841B1DD0-0x00000001841B1DE0 0x0000000185FB0C60-0x0000000185FB0C70
		public bool HasStringValue { get => default; } // 0x000000018A6B24A0-0x000000018A6B2504 
		public string AggregateValue { get => default; set {} } // 0x000000018A6B258C-0x000000018A6B2638 0x000000018A6B26AC-0x000000018A6B26F8
		public bool HasAggregateValue { get => default; } // 0x0000000185FA7B70-0x0000000185FA7BA0 
	
		// Nested types
		public static class Types // TypeDefIndex: 53489
		{
			// Nested types
			public sealed class NamePart : IMessage<NamePart>, IBufferMessage // TypeDefIndex: 53488
			{
				// Fields
				private static readonly MessageParser<NamePart> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				private int _hasBits0; // 0x18
				public const int NamePart_FieldNumber = 1; // Metadata: 0x02078244
				private static readonly string NamePart_DefaultValue; // 0x08
				private string namePart_; // 0x20
				public const int IsExtensionFieldNumber = 2; // Metadata: 0x02078245
				private static readonly bool IsExtensionDefaultValue; // 0x10
				private bool isExtension_; // 0x28
	
				// Properties
				public static MessageParser<NamePart> Parser { get => default; } // 0x000000018A6B68D0-0x000000018A6B6948 
				public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6B67F0-0x000000018A6B68D0 
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6B6010-0x000000018A6B6070 
				public string NamePart_ { get => default; set {} } // 0x00000001878567E4-0x00000001878567F0 0x000000018A3B9E90-0x000000018A3B9EA4
				public bool HasNamePart_ { get => default; } // 0x000000018A6B6BA0-0x000000018A6B6BF8 
				public bool IsExtension { get => default; set {} } // 0x00000001841B1DD0-0x00000001841B1DE0 0x0000000185FB0C60-0x0000000185FB0C70
				public bool HasIsExtension { get => default; } // 0x000000018A6B6AF8-0x000000018A6B6B50 
	
				// Nested types
				[Serializable]
				private sealed class __c // TypeDefIndex: 53487
				{
					// Fields
					public static readonly __c __9; // 0x00
	
					// Constructors
					static __c() {} // 0x000000018A6B6B50-0x000000018A6B6BA0
					public __c() {} // 0x000000018A6B699C-0x000000018A6B69FC
	
					// Methods
					internal NamePart _.cctor_b__41_0() => default; // 0x000000018A6B6FC8-0x000000018A6B7008
				}
	
				// Constructors
				public NamePart() {} // 0x00000001813B31A0-0x00000001813B31B0
				public NamePart(NamePart other) {} // 0x000000018A6B6AA4-0x000000018A6B6AF8
				static NamePart() {} // 0x000000018A6B6948-0x000000018A6B699C
	
				// Methods
				public NamePart Clone() => default; // 0x000000018A6B7070-0x000000018A6B70D8
				public void ClearNamePart_() {} // 0x0000000185FCCBE0-0x0000000185FCCBF0
				public void ClearIsExtension() {} // 0x0000000185FCCBD0-0x0000000185FCCBE0
				public override bool Equals(object other) => default; // 0x00000001817CD360-0x00000001817CD370
				public bool Equals(NamePart other) => default; // 0x0000000185FCC8C0-0x0000000185FCC8D0
				public override int GetHashCode() => default; // 0x000000018A6B69FC-0x000000018A6B6A54
				public override string ToString() => default; // 0x0000000185FCCBC0-0x0000000185FCCBD0
				public void WriteTo(CodedOutputStream output) {} // 0x000000018A69B868-0x000000018A69B870
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FCC910-0x0000000185FCC920
				public int CalculateSize() => default; // 0x000000018A6B6BF8-0x000000018A6B6C4C
				public void MergeFrom(NamePart other) {} // 0x000000018A6B70D8-0x000000018A6B7140
				public void MergeFrom(CodedInputStream input) {} // 0x000000018A6B6A54-0x000000018A6B6AA4
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000187F3B9F4-0x0000000187F3BA08
			}
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53490
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6B7008-0x000000018A6B7070
			public __c() {} // 0x000000018482D5A0-0x000000018482D5B0
	
			// Methods
			internal UninterpretedOption _.cctor_b__83_0() => default; // 0x0000000187F218AC-0x0000000187F218C0
		}
	
		// Constructors
		public UninterpretedOption() {} // 0x000000018A6B6548-0x000000018A6B6594
		public UninterpretedOption(UninterpretedOption other) {} // 0x0000000185FA7B70-0x0000000185FA7BA0
		static UninterpretedOption() {} // 0x000000018A6B5608-0x000000018A6B5658
	
		// Methods
		public UninterpretedOption Clone() => default; // 0x000000018A6B6E14-0x000000018A6B6FC8
		public void ClearIdentifierValue() {} // 0x000000018A6B6594-0x000000018A6B67F0
		public void ClearPositiveIntValue() {} // 0x0000000185492010-0x0000000185492020
		public void ClearNegativeIntValue() {} // 0x000000018A6B2B5C-0x000000018A6B2BC4
		public void ClearDoubleValue() {} // 0x0000000185FCCBB0-0x0000000185FCCBC0
		public void ClearStringValue() {} // 0x000000018A6B2504-0x000000018A6B258C
		public void ClearAggregateValue() {} // 0x000000018A6B2A94-0x000000018A6B2B1C
		public override bool Equals(object other) => default; // 0x000000018A6B23BC-0x000000018A6B2440
		public bool Equals(UninterpretedOption other) => default; // 0x000000018A6B2638-0x000000018A6B26AC
		public override int GetHashCode() => default; // 0x0000000185FA7960-0x0000000185FA7990
		public override string ToString() => default; // 0x000000018A6B2A00-0x000000018A6B2A94
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6B26F8-0x000000018A6B2854
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018A6B5D98-0x000000018A6B5DFC
		public int CalculateSize() => default; // 0x0000000185492010-0x0000000185492020
		public void MergeFrom(UninterpretedOption other) {} // 0x000000018A6B5298-0x000000018A6B52D4
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6B5ADC-0x000000018A6B5B40
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class SourceCodeInfo : IMessage<SourceCodeInfo>, IBufferMessage // TypeDefIndex: 53496
	{
		// Fields
		private static readonly MessageParser<SourceCodeInfo> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int LocationFieldNumber = 1; // Metadata: 0x02078246
		private static readonly FieldCodec<Types.Location> _repeated_location_codec; // 0x08
		private readonly RepeatedField<Types.Location> location_; // 0x18
	
		// Properties
		public static MessageParser<SourceCodeInfo> Parser { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6AEF3C-0x000000018A6AEFA0 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6AEFA0-0x000000018A6AF0D8 
		public RepeatedField<Types.Location> Location { get => default; } // 0x000000018A6AFA40-0x000000018A6AFBB4 
	
		// Nested types
		public static class Types // TypeDefIndex: 53494
		{
			// Nested types
			public sealed class Location : IMessage<Location>, IBufferMessage // TypeDefIndex: 53493
			{
				// Fields
				private static readonly MessageParser<Location> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				public const int PathFieldNumber = 1; // Metadata: 0x02078247
				private static readonly FieldCodec<int> _repeated_path_codec; // 0x08
				private readonly RepeatedField<int> path_; // 0x18
				public const int SpanFieldNumber = 2; // Metadata: 0x02078248
				private static readonly FieldCodec<int> _repeated_span_codec; // 0x10
				private readonly RepeatedField<int> span_; // 0x20
				public const int LeadingCommentsFieldNumber = 3; // Metadata: 0x02078249
				private static readonly string LeadingCommentsDefaultValue; // 0x18
				private string leadingComments_; // 0x28
				public const int TrailingCommentsFieldNumber = 4; // Metadata: 0x0207824A
				private static readonly string TrailingCommentsDefaultValue; // 0x20
				private string trailingComments_; // 0x30
				public const int LeadingDetachedCommentsFieldNumber = 6; // Metadata: 0x0207824B
				private static readonly FieldCodec<string> _repeated_leadingDetachedComments_codec; // 0x28
				private readonly RepeatedField<string> leadingDetachedComments_; // 0x38
	
				// Properties
				public static MessageParser<Location> Parser { get => default; } // 0x000000018A6B4D54-0x000000018A6B4DCC 
				public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6B4DCC-0x000000018A6B4E54 
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6B49E0-0x000000018A6B4A40 
				public RepeatedField<int> Path { get => default; } // 0x000000018736AA60-0x000000018736AAB0 
				public RepeatedField<int> Span { get => default; } // 0x000000018A6B4B98-0x000000018A6B4BE4 
				public string LeadingComments { get => default; set {} } // 0x0000000185FA7B70-0x0000000185FA7BA0 0x000000018A6B4FD4-0x000000018A6B5078
				public bool HasLeadingComments { get => default; } // 0x000000018A6B494C-0x000000018A6B49E0 
				public string TrailingComments { get => default; set {} } // 0x0000000185FA7960-0x0000000185FA7990 0x000000018A6B4F04-0x000000018A6B4FD4
				public bool HasTrailingComments { get => default; } // 0x000000018A6B4BE4-0x000000018A6B4D54 
				public RepeatedField<string> LeadingDetachedComments { get => default; } // 0x000000018A6AF710-0x000000018A6AF770 
	
				// Nested types
				[Serializable]
				private sealed class __c // TypeDefIndex: 53492
				{
					// Fields
					public static readonly __c __9; // 0x00
	
					// Constructors
					static __c() {} // 0x000000018A6B4EB4-0x000000018A6B4F04
					public __c() {} // 0x000000018A6B4E54-0x000000018A6B4EB4
	
					// Methods
					internal Location _.cctor_b__55_0() => default; // 0x000000018A6B5078-0x000000018A6B50B8
				}
	
				// Constructors
				public Location() {} // 0x0000000181377E40-0x0000000181377E50
				public Location(Location other) {} // 0x000000018A6B4ABC-0x000000018A6B4B20
				static Location() {} // 0x000000018A6AF814-0x000000018A6AF868
	
				// Methods
				public Location Clone() => default; // 0x000000018A6B4A40-0x000000018A6B4ABC
				public void ClearLeadingComments() {} // 0x000000018A6B4B20-0x000000018A6B4B98
				public void ClearTrailingComments() {} // 0x000000018A6AF7C4-0x000000018A6AF814
				public override bool Equals(object other) => default; // 0x000000018A6AFBB4-0x000000018A6AFBF4
				public bool Equals(Location other) => default; // 0x000000018A6AF51C-0x000000018A6AF610
				public override int GetHashCode() => default; // 0x000000018A6AF610-0x000000018A6AF710
				public override string ToString() => default; // 0x000000018A6AEEDC-0x000000018A6AEF3C
				public void WriteTo(CodedOutputStream output) {} // 0x0000000181377E40-0x0000000181377E50
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001813B31A0-0x00000001813B31B0
				public int CalculateSize() => default; // 0x000000018A6AF770-0x000000018A6AF7C4
				public void MergeFrom(Location other) {} // 0x000000018A6AFBF4-0x000000018A6AFC5C
				public void MergeFrom(CodedInputStream input) {} // 0x00000001878567E4-0x00000001878567F0
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018A3B9E90-0x000000018A3B9EA4
			}
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53495
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6AFC5C-0x000000018A6AFCC4
			public __c() {} // 0x000000018A6AD3DC-0x000000018A6AD3E8
	
			// Methods
			internal SourceCodeInfo _.cctor_b__28_0() => default; // 0x0000000187773EB8-0x0000000187773ECC
		}
	
		// Constructors
		public SourceCodeInfo() {} // 0x000000018A6AF0D8-0x000000018A6AF1B8
		public SourceCodeInfo(SourceCodeInfo other) {} // 0x000000018A6AF2B8-0x000000018A6AF304
		static SourceCodeInfo() {} // 0x000000018A6B51A8-0x000000018A6B51F8
	
		// Methods
		public SourceCodeInfo Clone() => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override bool Equals(object other) => default; // 0x000000018A6AED60-0x000000018A6AEEDC
		public bool Equals(SourceCodeInfo other) => default; // 0x000000018A6AF1B8-0x000000018A6AF2B8
		public override int GetHashCode() => default; // 0x0000000185FA7960-0x0000000185FA7990
		public override string ToString() => default; // 0x000000018A6AF868-0x000000018A6AFA40
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6AF304-0x000000018A6AF51C
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018A6B5758-0x000000018A6B57BC
		public int CalculateSize() => default; // 0x0000000185492010-0x0000000185492020
		public void MergeFrom(SourceCodeInfo other) {} // 0x000000018A6B543C-0x000000018A6B548C
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6B59B0-0x000000018A6B5A14
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class GeneratedCodeInfo : IMessage<GeneratedCodeInfo>, IBufferMessage // TypeDefIndex: 53501
	{
		// Fields
		private static readonly MessageParser<GeneratedCodeInfo> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int AnnotationFieldNumber = 1; // Metadata: 0x0207824C
		private static readonly FieldCodec<Types.Annotation> _repeated_annotation_codec; // 0x08
		private readonly RepeatedField<Types.Annotation> annotation_; // 0x18
	
		// Properties
		public static MessageParser<GeneratedCodeInfo> Parser { get => default; } // 0x0000000185FCC8C0-0x0000000185FCC8D0 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6A5178-0x000000018A6A51DC 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6A508C-0x000000018A6A5178 
		public RepeatedField<Types.Annotation> Annotation { get => default; } // 0x000000018A6A5950-0x000000018A6A5A78 
	
		// Nested types
		public static class Types // TypeDefIndex: 53499
		{
			// Nested types
			public sealed class Annotation : IMessage<Annotation>, IBufferMessage // TypeDefIndex: 53498
			{
				// Fields
				private static readonly MessageParser<Annotation> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				private int _hasBits0; // 0x18
				public const int PathFieldNumber = 1; // Metadata: 0x0207824D
				private static readonly FieldCodec<int> _repeated_path_codec; // 0x08
				private readonly RepeatedField<int> path_; // 0x20
				public const int SourceFileFieldNumber = 2; // Metadata: 0x0207824E
				private static readonly string SourceFileDefaultValue; // 0x10
				private string sourceFile_; // 0x28
				public const int BeginFieldNumber = 3; // Metadata: 0x0207824F
				private static readonly int BeginDefaultValue; // 0x18
				private int begin_; // 0x30
				public const int EndFieldNumber = 4; // Metadata: 0x02078250
				private static readonly int EndDefaultValue; // 0x1C
				private int end_; // 0x34
	
				// Properties
				public static MessageParser<Annotation> Parser { get => default; } // 0x000000018A6AEA84-0x000000018A6AEAFC 
				public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6AE9FC-0x000000018A6AEA84 
				MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6AE688-0x000000018A6AE6E8 
				public RepeatedField<int> Path { get => default; } // 0x000000018736AA60-0x000000018736AAB0 
				public string SourceFile { get => default; set {} } // 0x000000018A6AE840-0x000000018A6AE88C 0x0000000185FA7B70-0x0000000185FA7BA0
				public bool HasSourceFile { get => default; } // 0x000000018A6AEC7C-0x000000018A6AED20 
				public int Begin { get => default; set {} } // 0x000000018A6AE7C8-0x000000018A6AE840 0x0000000185FA7960-0x0000000185FA7990
				public bool HasBegin { get => default; } // 0x000000018A6AEBAC-0x000000018A6AEC7C 
				public int End { get => default; set {} } // 0x000000018A6A575C-0x000000018A6A57AC 0x000000018A6A56A8-0x000000018A6A5708
				public bool HasEnd { get => default; } // 0x000000018A6A5A78-0x000000018A6A5AB8 
	
				// Nested types
				[Serializable]
				private sealed class __c // TypeDefIndex: 53497
				{
					// Fields
					public static readonly __c __9; // 0x00
	
					// Constructors
					static __c() {} // 0x000000018A6AEB5C-0x000000018A6AEBAC
					public __c() {} // 0x000000018A6AEAFC-0x000000018A6AEB5C
	
					// Methods
					internal Annotation _.cctor_b__55_0() => default; // 0x000000018A6AED20-0x000000018A6AED60
				}
	
				// Constructors
				public Annotation() {} // 0x0000000181377E40-0x0000000181377E50
				public Annotation(Annotation other) {} // 0x000000018A6AE6E8-0x000000018A6AE74C
				static Annotation() {} // 0x0000000185FB0C60-0x0000000185FB0C70
	
				// Methods
				public Annotation Clone() => default; // 0x000000018A6AE74C-0x000000018A6AE7C8
				public void ClearSourceFile() {} // 0x000000018A6AE5F4-0x000000018A6AE688
				public void ClearBegin() {} // 0x000000018A6AE88C-0x000000018A6AE9FC
				public void ClearEnd() {} // 0x000000018A6A55DC-0x000000018A6A5654
				public override bool Equals(object other) => default; // 0x000000018A6A5530-0x000000018A6A55DC
				public bool Equals(Annotation other) => default; // 0x000000018A6A502C-0x000000018A6A508C
				public override int GetHashCode() => default; // 0x00000001813B31A0-0x00000001813B31B0
				public override string ToString() => default; // 0x000000018A6A57AC-0x000000018A6A5800
				public void WriteTo(CodedOutputStream output) {} // 0x000000018A6A5AB8-0x000000018A6A5B20
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001878567E4-0x00000001878567F0
				public int CalculateSize() => default; // 0x000000018A3B9E90-0x000000018A3B9EA4
				public void MergeFrom(Annotation other) {} // 0x000000018A6A5654-0x000000018A6A56A8
				public void MergeFrom(CodedInputStream input) {} // 0x0000000185FCC970-0x0000000185FCC980
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001841B1DD0-0x00000001841B1DE0
			}
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53500
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6A5708-0x000000018A6A575C
			public __c() {} // 0x0000000185FCC980-0x0000000185FCC990
	
			// Methods
			internal GeneratedCodeInfo _.cctor_b__28_0() => default; // 0x00000001817CD360-0x00000001817CD370
		}
	
		// Constructors
		public GeneratedCodeInfo() {} // 0x000000018A6A51DC-0x000000018A6A5274
		public GeneratedCodeInfo(GeneratedCodeInfo other) {} // 0x000000018A6A5340-0x000000018A6A538C
		static GeneratedCodeInfo() {} // 0x000000018A6B5158-0x000000018A6B51A8
	
		// Methods
		public GeneratedCodeInfo Clone() => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override bool Equals(object other) => default; // 0x000000018A6A4EF8-0x000000018A6A502C
		public bool Equals(GeneratedCodeInfo other) => default; // 0x000000018A6A5274-0x000000018A6A5340
		public override int GetHashCode() => default; // 0x0000000185FA7960-0x0000000185FA7990
		public override string ToString() => default; // 0x000000018A6A5800-0x000000018A6A5950
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6A538C-0x000000018A6A5530
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x000000018A6B5DFC-0x000000018A6B5E60
		public int CalculateSize() => default; // 0x0000000185492010-0x0000000185492020
		public void MergeFrom(GeneratedCodeInfo other) {} // 0x000000018A6B548C-0x000000018A6B54DC
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6B5BA4-0x000000018A6B5C08
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class DescriptorBase : IDescriptor // TypeDefIndex: 53502
	{
		// Fields
		private readonly int _Index_k__BackingField; // 0x10
		private readonly string _FullName_k__BackingField; // 0x18
		private readonly FileDescriptor _File_k__BackingField; // 0x20
	
		// Properties
		public int Index { get; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
		public abstract string Name { get; }
		public string FullName { get; } // 0x0000000181377E40-0x0000000181377E50 
		public FileDescriptor File { get; } // 0x00000001813B31A0-0x00000001813B31B0 
		public DescriptorDeclaration Declaration { get; } // 0x000000018A6A5B50-0x000000018A6A5B78 
	
		// Constructors
		protected DescriptorBase() {} // Dummy constructor
		internal DescriptorBase(FileDescriptor file, string fullName, int index) {} // 0x000000018A6A5B20-0x000000018A6A5B50
	
		// Methods
		internal virtual IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) => default; // 0x00000001813AE580-0x00000001813AE590
	}

	public sealed class DescriptorDeclaration // TypeDefIndex: 53503
	{
		// Fields
		private readonly IDescriptor _Descriptor_k__BackingField; // 0x10
		private readonly int _StartLine_k__BackingField; // 0x18
		private readonly int _StartColumn_k__BackingField; // 0x1C
		private readonly int _EndLine_k__BackingField; // 0x20
		private readonly int _EndColumn_k__BackingField; // 0x24
		private readonly string _LeadingComments_k__BackingField; // 0x28
		private readonly string _TrailingComments_k__BackingField; // 0x30
		private readonly IReadOnlyList<string> _LeadingDetachedComments_k__BackingField; // 0x38
	
		// Properties
		public IDescriptor Descriptor { get; } // 0x000000018346D130-0x000000018346D140 
		public int StartLine { get; } // 0x00000001813AE560-0x00000001813AE570 
		public int StartColumn { get; } // 0x00000001813AE570-0x00000001813AE580 
		public int EndLine { get; } // 0x00000001813B88B0-0x00000001813B88C0 
		public int EndColumn { get; } // 0x0000000181424480-0x0000000181424490 
		public string LeadingComments { get; } // 0x00000001813B8590-0x00000001813B85A0 
		public string TrailingComments { get; } // 0x00000001813B51D0-0x00000001813B51E0 
		public IReadOnlyList<string> LeadingDetachedComments { get; } // 0x00000001813ECBC0-0x00000001813ECBD0 
	
		// Constructors
		public DescriptorDeclaration() {} // Dummy constructor
		private DescriptorDeclaration(IDescriptor descriptor, SourceCodeInfo.Types.Location location) {} // 0x000000018A6A5BE8-0x000000018A6A5D88
	
		// Methods
		internal static DescriptorDeclaration FromProto(IDescriptor descriptor, SourceCodeInfo.Types.Location location) => default; // 0x000000018A6A5B78-0x000000018A6A5BE8
	}

	internal sealed class DescriptorPool // TypeDefIndex: 53504
	{
		// Fields
		private readonly IDictionary<string, IDescriptor> descriptorsByName; // 0x10
		private readonly IDictionary<ObjectIntPair<IDescriptor>, FieldDescriptor> fieldsByNumber; // 0x18
		private readonly IDictionary<ObjectIntPair<IDescriptor>, EnumValueDescriptor> enumValuesByNumber; // 0x20
		private readonly HashSet<FileDescriptor> dependencies; // 0x28
		private static readonly Regex ValidationRegex; // 0x00
	
		// Constructors
		public DescriptorPool() {} // Dummy constructor
		internal DescriptorPool(IEnumerable<FileDescriptor> dependencyFiles) {} // 0x000000018A6A6DB8-0x000000018A6A7168
		static DescriptorPool() {} // 0x000000018A6A6CF4-0x000000018A6A6DB8
	
		// Methods
		private void ImportPublicDependencies(FileDescriptor file) {} // 0x000000018A6A6730-0x000000018A6A68A4
		internal T FindSymbol<T>(string fullName)
			where T : class => default;
		internal void AddPackage(string fullName, FileDescriptor file) {} // 0x000000018A6A6084-0x000000018A6A62EC
		internal void AddSymbol(IDescriptor descriptor) {} // 0x000000018A6A62EC-0x000000018A6A65E8
		private static void ValidateSymbolName(IDescriptor descriptor) {} // 0x000000018A6A6B64-0x000000018A6A6CF4
		internal FieldDescriptor FindFieldByNumber(MessageDescriptor messageDescriptor, int number) => default; // 0x000000018A6A668C-0x000000018A6A6730
		internal EnumValueDescriptor FindEnumValueByNumber(EnumDescriptor enumDescriptor, int number) => default; // 0x000000018A6A65E8-0x000000018A6A668C
		internal void AddFieldByNumber(FieldDescriptor field) {} // 0x000000018A6A5E4C-0x000000018A6A6084
		internal void AddEnumValueByNumber(EnumValueDescriptor enumValue) {} // 0x000000018A6A5D88-0x000000018A6A5E4C
		internal IDescriptor LookupSymbol(string name, IDescriptor relativeTo) => default; // 0x000000018A6A68A4-0x000000018A6A6B64
	}

	internal static class DescriptorUtil // TypeDefIndex: 53506
	{
		// Nested types
		internal delegate TOutput IndexedConverter<TInput, TOutput>(TInput element, int index); // TypeDefIndex: 53505; 0x00000000-0x00000000
	
		// Methods
		internal static IList<TOutput> ConvertAndMakeReadOnly<TInput, TOutput>(IList<TInput> input, IndexedConverter<TInput, TOutput> converter) => default;
	}

	public sealed class DescriptorValidationException : Exception // TypeDefIndex: 53507
	{
		// Fields
		private readonly string name; // 0x90
		private readonly string description; // 0x98
	
		// Properties
		public string ProblemSymbolName { get => default; } // 0x0000000181B5FFD0-0x0000000181B5FFE0 
		public string Description { get => default; } // 0x0000000181E336C0-0x0000000181E336D0 
	
		// Constructors
		public DescriptorValidationException() {} // Dummy constructor
		internal DescriptorValidationException(IDescriptor problemDescriptor, string description) {} // 0x000000018A6A7168-0x000000018A6A7234
		internal DescriptorValidationException(IDescriptor problemDescriptor, string description, Exception cause) {} // 0x000000018A6A7234-0x000000018A6A7314
	}

	public sealed class EnumDescriptor : DescriptorBase // TypeDefIndex: 53509
	{
		// Fields
		private readonly EnumDescriptorProto proto; // 0x28
		private readonly MessageDescriptor containingType; // 0x30
		private readonly IList<EnumValueDescriptor> values; // 0x38
		private readonly System.Type clrType; // 0x40
	
		// Properties
		internal EnumDescriptorProto Proto { get => default; } // 0x000000018A6A7708-0x000000018A6A7728 
		public override string Name { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		public System.Type ClrType { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public MessageDescriptor ContainingType { get => default; } // 0x000000018A6A73A0-0x000000018A6A73D0 
		public IList<EnumValueDescriptor> Values { get => default; } // 0x000000018A6A7314-0x000000018A6A73A0 
		public CustomOptions CustomOptions { get => default; }
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 53508
		{
			// Fields
			public FileDescriptor file; // 0x10
			public EnumDescriptor __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x000000018A6A746C-0x000000018A6A7678
	
			// Methods
			internal EnumValueDescriptor _.ctor_b__0(EnumValueDescriptorProto value, int i) => default; // 0x00000001813B8590-0x00000001813B85A0
		}
	
		// Constructors
		public EnumDescriptor() {} // Dummy constructor
		internal EnumDescriptor(EnumDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, System.Type clrType) {} // 0x000000018A6A744C-0x000000018A6A746C
	
		// Methods
		public EnumDescriptorProto ToProto() => default; // 0x000000018A6A73D0-0x000000018A6A7420
		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) => default; // 0x00000001813B51D0-0x00000001813B51E0
		public EnumValueDescriptor FindValueByNumber(int number) => default; // 0x000000018A6A7678-0x000000018A6A7708
		public EnumValueDescriptor FindValueByName(string name) => default; // 0x000000018A6A7420-0x000000018A6A744C
		public EnumOptions GetOptions() => default;
		public T GetOption<T>(Extension<EnumOptions, T> extension) => default; // 0x0000000185492010-0x0000000185492020
		public RepeatedField<T> GetOption<T>(RepeatedExtension<EnumOptions, T> extension) => default; // 0x000000018A6B5658-0x000000018A6B56F4
	}

	public sealed class EnumValueDescriptor : DescriptorBase // TypeDefIndex: 53510
	{
		// Fields
		private readonly EnumDescriptor enumDescriptor; // 0x28
		private readonly EnumValueDescriptorProto proto; // 0x30
	
		// Properties
		internal EnumValueDescriptorProto Proto { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
		public override string Name { get => default; } // 0x000000018A6A93F4-0x000000018A6A9414 
		public int Number { get => default; } // 0x000000018A6A9414-0x000000018A6A9434 
		public EnumDescriptor EnumDescriptor { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
		public CustomOptions CustomOptions { get => default; } // 0x000000018A6A9364-0x000000018A6A93F4 
	
		// Constructors
		public EnumValueDescriptor() {} // Dummy constructor
		internal EnumValueDescriptor(EnumValueDescriptorProto proto, FileDescriptor file, EnumDescriptor parent, int index) {} // 0x000000018A6A926C-0x000000018A6A9364
	
		// Methods
		public EnumValueDescriptorProto ToProto() => default; // 0x000000018A6A924C-0x000000018A6A926C
		public EnumValueOptions GetOptions() => default; // 0x000000018A6A9220-0x000000018A6A924C
		public T GetOption<T>(Extension<EnumValueOptions, T> extension) => default;
		public RepeatedField<T> GetOption<T>(RepeatedExtension<EnumValueOptions, T> extension) => default;
	}

	internal sealed class ExtensionAccessor : IFieldAccessor // TypeDefIndex: 53511
	{
		// Fields
		private readonly Google.Protobuf.Extension extension; // 0x10
		private readonly ReflectionUtil.IExtensionReflectionHelper helper; // 0x18
		private readonly FieldDescriptor _Descriptor_k__BackingField; // 0x20
	
		// Properties
		public FieldDescriptor Descriptor { get; } // 0x00000001813B31A0-0x00000001813B31B0 
	
		// Constructors
		public ExtensionAccessor() {} // Dummy constructor
		internal ExtensionAccessor(FieldDescriptor descriptor) {} // 0x000000018A6A9FDC-0x000000018A6AA064
	
		// Methods
		public void Clear(IMessage message) {} // 0x000000018A6A9E28-0x000000018A6A9EB0
		public bool HasValue(IMessage message) => default; // 0x000000018A6A9F38-0x000000018A6A9FC0
		public object GetValue(IMessage message) => default; // 0x000000018A6A9EB0-0x000000018A6A9F38
		public void SetValue(IMessage message, object value) {} // 0x000000018A6A9FC0-0x000000018A6A9FDC
	}

	public sealed class ExtensionCollection // TypeDefIndex: 53515
	{
		// Fields
		private IDictionary<MessageDescriptor, IList<FieldDescriptor>> extensionsByTypeInDeclarationOrder; // 0x10
		private IDictionary<MessageDescriptor, IList<FieldDescriptor>> extensionsByTypeInNumberOrder; // 0x18
		private readonly IList<FieldDescriptor> _UnorderedExtensions_k__BackingField; // 0x20
	
		// Properties
		public IList<FieldDescriptor> UnorderedExtensions { get; } // 0x000000018A6C08F4-0x000000018A6C0970 
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 53512
		{
			// Fields
			public Google.Protobuf.Extension[] extensions; // 0x10
			public FileDescriptor file; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x000000018A6AAB64-0x000000018A6AAC6C
	
			// Methods
			internal FieldDescriptor _.ctor_b__0(FieldDescriptorProto extension, int i) => default; // 0x000000018A6AAA5C-0x000000018A6AAB64
		}
	
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 53513
		{
			// Fields
			public Google.Protobuf.Extension[] extensions; // 0x10
			public MessageDescriptor message; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x00000001813B31A0-0x00000001813B31B0
	
			// Methods
			internal FieldDescriptor _.ctor_b__0(FieldDescriptorProto extension, int i) => default; // 0x000000018A6AA9BC-0x000000018A6AAA0C
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53514
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KeyValuePair<MessageDescriptor, IList<FieldDescriptor>>, MessageDescriptor> __9__9_0; // 0x08
			public static Func<KeyValuePair<MessageDescriptor, IList<FieldDescriptor>>, IList<FieldDescriptor>> __9__9_1; // 0x10
			public static Func<KeyValuePair<MessageDescriptor, IList<FieldDescriptor>>, MessageDescriptor> __9__9_2; // 0x18
			public static Func<FieldDescriptor, int> __9__9_4; // 0x20
			public static Func<KeyValuePair<MessageDescriptor, IList<FieldDescriptor>>, IList<FieldDescriptor>> __9__9_3; // 0x28
	
			// Constructors
			static __c() {} // 0x000000018A6AAA0C-0x000000018A6AAA5C
			public __c() {} // 0x000000018A6AA064-0x000000018A6AA9BC
	
			// Methods
			internal MessageDescriptor _CrossLink_b__9_0(KeyValuePair<MessageDescriptor, IList<FieldDescriptor>> kvp) => default; // 0x0000000185492010-0x0000000185492020
			internal IList<FieldDescriptor> _CrossLink_b__9_1(KeyValuePair<MessageDescriptor, IList<FieldDescriptor>> kvp) => default; // 0x000000018A6C0BE8-0x000000018A6C0CFC
			internal MessageDescriptor _CrossLink_b__9_2(KeyValuePair<MessageDescriptor, IList<FieldDescriptor>> kvp) => default; // 0x0000000185492010-0x0000000185492020
			internal IList<FieldDescriptor> _CrossLink_b__9_3(KeyValuePair<MessageDescriptor, IList<FieldDescriptor>> kvp) => default; // 0x000000018A6C1000-0x000000018A6C1138
			internal int _CrossLink_b__9_4(FieldDescriptor field) => default; // 0x000000018A6C163C-0x000000018A6C16A0
		}
	
		// Constructors
		public ExtensionCollection() {} // Dummy constructor
		internal ExtensionCollection(FileDescriptor file, Google.Protobuf.Extension[] extensions) {} // 0x0000000185492010-0x0000000185492020
		internal ExtensionCollection(MessageDescriptor message, Google.Protobuf.Extension[] extensions) {} // 0x000000018A6C08C0-0x000000018A6C08F4
	
		// Methods
		public IList<FieldDescriptor> GetExtensionsInDeclarationOrder(MessageDescriptor descriptor) => default; // 0x000000018A6C0970-0x000000018A6C09A4
		public IList<FieldDescriptor> GetExtensionsInNumberOrder(MessageDescriptor descriptor) => default; // 0x000000018A6C09A4-0x000000018A6C0B1C
		internal void CrossLink() {} // 0x000000018A6C0B1C-0x000000018A6C0B3C
	}

	internal abstract class FieldAccessorBase : IFieldAccessor // TypeDefIndex: 53516
	{
		// Fields
		private readonly Func<IMessage, object> getValueDelegate; // 0x10
		private readonly FieldDescriptor descriptor; // 0x18
	
		// Properties
		public FieldDescriptor Descriptor { get; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Constructors
		protected FieldAccessorBase() {} // Dummy constructor
		internal FieldAccessorBase(PropertyInfo property, FieldDescriptor descriptor) {} // 0x000000018A6B7B04-0x000000018A6B7B90
	
		// Methods
		public object GetValue(IMessage message) => default; // 0x000000018A6B7AE4-0x000000018A6B7B04
		public abstract bool HasValue(IMessage message);
		public abstract void Clear(IMessage message);
		public abstract void SetValue(IMessage message, object value);
	}

	public sealed class FieldDescriptor : DescriptorBase, IComparable<FieldDescriptor> // TypeDefIndex: 53517
	{
		// Fields
		private EnumDescriptor enumType; // 0x28
		private MessageDescriptor extendeeType; // 0x30
		private MessageDescriptor messageType; // 0x38
		private Google.Protobuf.Reflection.FieldType fieldType; // 0x40
		private IFieldAccessor accessor; // 0x48
		private readonly MessageDescriptor _ContainingType_k__BackingField; // 0x50
		private readonly OneofDescriptor _ContainingOneof_k__BackingField; // 0x58
		private readonly string _JsonName_k__BackingField; // 0x60
		private readonly string _PropertyName_k__BackingField; // 0x68
		private readonly FieldDescriptorProto _Proto_k__BackingField; // 0x70
		private readonly Google.Protobuf.Extension _Extension_k__BackingField; // 0x78
	
		// Properties
		public MessageDescriptor ContainingType { get; } // 0x0000000181460F60-0x0000000181460F70 
		public OneofDescriptor ContainingOneof { get; } // 0x00000001813F1630-0x00000001813F1640 
		public OneofDescriptor RealContainingOneof { get => default; } // 0x000000018A6B8CF0-0x000000018A6B8D04 
		public string JsonName { get; } // 0x0000000185FB0530-0x0000000185FB0540 
		public string PropertyName { get; } // 0x00000001813AC280-0x00000001813AC290 
		public bool HasPresence { get => default; } // 0x000000018A6B8AE8-0x000000018A6B8B54 
		internal FieldDescriptorProto Proto { get; } // 0x0000000181460F70-0x0000000181460F80 
		public Google.Protobuf.Extension Extension { get; } // 0x0000000183060C50-0x0000000183060C60 
		public override string Name { get => default; } // 0x000000018A6B8CD0-0x000000018A6B8CF0 
		public IFieldAccessor Accessor { get => default; } // 0x00000001813ECF20-0x00000001813ECF30 
		public bool IsRepeated { get => default; } // 0x000000018A6B8C10-0x000000018A6B8C38 
		public bool IsRequired { get => default; } // 0x000000018A6B8C38-0x000000018A6B8C60 
		public bool IsMap { get => default; } // 0x000000018A6B8B74-0x000000018A6B8BB4 
		public bool IsPacked { get => default; } // 0x000000018A6B8BB4-0x000000018A6B8C10 
		public bool IsExtension { get => default; } // 0x000000018A6B8B54-0x000000018A6B8B74 
		public Google.Protobuf.Reflection.FieldType FieldType { get => default; } // 0x00000001813ECF10-0x00000001813ECF20 
		public int FieldNumber { get => default; } // 0x000000018A6B8AC8-0x000000018A6B8AE8 
		public EnumDescriptor EnumType { get => default; } // 0x000000018A6B89E8-0x000000018A6B8A54 
		public MessageDescriptor MessageType { get => default; } // 0x000000018A6B8C60-0x000000018A6B8CD0 
		public MessageDescriptor ExtendeeType { get => default; } // 0x000000018A6B8A54-0x000000018A6B8AC8 
		public CustomOptions CustomOptions { get => default; } // 0x000000018A6B8958-0x000000018A6B89E8 
	
		// Constructors
		public FieldDescriptor() {} // Dummy constructor
		internal FieldDescriptor(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string propertyName, Google.Protobuf.Extension extension) {} // 0x000000018A6B8640-0x000000018A6B8958
	
		// Methods
		public FieldDescriptorProto ToProto() => default; // 0x000000018A6B8620-0x000000018A6B8640
		private static Google.Protobuf.Reflection.FieldType GetFieldTypeFromProtoType(FieldDescriptorProto.Types.Type type) => default; // 0x000000018A6B848C-0x000000018A6B85F4
		public int CompareTo(FieldDescriptor other) => default; // 0x000000018A6B7C80-0x000000018A6B7D14
		public Google.Protobuf.Reflection.FieldOptions GetOptions() => default; // 0x000000018A6B85F4-0x000000018A6B8620
		public T GetOption<T>(Extension<Google.Protobuf.Reflection.FieldOptions, T> extension) => default;
		public RepeatedField<T> GetOption<T>(RepeatedExtension<Google.Protobuf.Reflection.FieldOptions, T> extension) => default;
		internal void CrossLink() {} // 0x000000018A6B7F18-0x000000018A6B848C
		private IFieldAccessor CreateAccessor() => default; // 0x000000018A6B7D14-0x000000018A6B7F18
	}

	public enum FieldType // TypeDefIndex: 53518
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

	public enum Syntax // TypeDefIndex: 53519
	{
		Proto2 = 0,
		Proto3 = 1,
		Unknown = 2
	}

	public sealed class FileDescriptor : IDescriptor // TypeDefIndex: 53522
	{
		// Fields
		private readonly Lazy<Dictionary<IDescriptor, DescriptorDeclaration>> declarations; // 0x10
		private readonly FileDescriptorProto _Proto_k__BackingField; // 0x18
		private readonly Google.Protobuf.Reflection.Syntax _Syntax_k__BackingField; // 0x20
		private readonly IList<MessageDescriptor> _MessageTypes_k__BackingField; // 0x28
		private readonly IList<EnumDescriptor> _EnumTypes_k__BackingField; // 0x30
		private readonly IList<ServiceDescriptor> _Services_k__BackingField; // 0x38
		private readonly ExtensionCollection _Extensions_k__BackingField; // 0x40
		private readonly IList<FileDescriptor> _Dependencies_k__BackingField; // 0x48
		private readonly IList<FileDescriptor> _PublicDependencies_k__BackingField; // 0x50
		private readonly ByteString _SerializedData_k__BackingField; // 0x58
		private readonly DescriptorPool _DescriptorPool_k__BackingField; // 0x60
	
		// Properties
		internal FileDescriptorProto Proto { get; } // 0x000000018A6BAEF0-0x000000018A6BAEF8 
		public Google.Protobuf.Reflection.Syntax Syntax { get; } // 0x0000000185FB0530-0x0000000185FB0540 
		public string Name { get => default; }
		public string Package { get => default; } // 0x000000018A6B9668-0x000000018A6B97F0 
		public IList<MessageDescriptor> MessageTypes { get; } // 0x000000018A6B9A94-0x000000018A6B9CE4 
		public IList<EnumDescriptor> EnumTypes { get; } // 0x000000018A6BA194-0x000000018A6BA4B0 
		public IList<ServiceDescriptor> Services { get; } // 0x000000018A6BAA48-0x000000018A6BAB6C 
		public ExtensionCollection Extensions { get; } // 0x000000018A6BAB6C-0x000000018A6BAD10 
		public IList<FileDescriptor> Dependencies { get; } // 0x000000018A6BA730-0x000000018A6BAA48 
		public IList<FileDescriptor> PublicDependencies { get; } // 0x000000018A6BA4B0-0x000000018A6BA730 
		public ByteString SerializedData { get; } // 0x000000018A6B8D50-0x000000018A6B9668 
		string IDescriptor.FullName { get => default; } // 0x000000018A6B8D04-0x000000018A6B8D50 
		FileDescriptor IDescriptor.File { get => default; } // 0x000000018A6BAF18-0x000000018A6BAF60 
		internal DescriptorPool DescriptorPool { get; } // 0x000000018A6BB4DC-0x000000018A6BB51C 
		public static FileDescriptor DescriptorProtoFileDescriptor { get => default; } // 0x000000018A6C0B3C-0x000000018A6C0B5C 
		public CustomOptions CustomOptions { get => default; } // 0x0000000182F7A4D0-0x0000000182F7A4E0 
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 53520
		{
			// Fields
			public FileDescriptor __4__this; // 0x10
			public GeneratedClrTypeInfo generatedCodeInfo; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x000000018A6BAF60-0x000000018A6BAFF0
	
			// Methods
			internal MessageDescriptor _.ctor_b__0(DescriptorProto message, int index) => default; // 0x000000018A6BAFF0-0x000000018A6BB44C
			internal EnumDescriptor _.ctor_b__1(EnumDescriptorProto enumType, int index) => default; // 0x000000018A6B9880-0x000000018A6B9A94
			internal ServiceDescriptor _.ctor_b__2(ServiceDescriptorProto service, int index) => default; // 0x000000018A6BA038-0x000000018A6BA194
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53521
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<FileDescriptor, string> __9__9_0; // 0x08
			public static Func<GeneratedClrTypeInfo, bool> __9__54_0; // 0x10
			public static Func<FieldDescriptor, Google.Protobuf.Extension> __9__55_0; // 0x18
			public static Func<Google.Protobuf.Extension, bool> __9__55_1; // 0x20
			public static Func<FieldDescriptor, Google.Protobuf.Extension> __9__56_0; // 0x28
			public static Func<Google.Protobuf.Extension, bool> __9__56_1; // 0x30
	
			// Constructors
			static __c() {} // 0x000000018A6BAD98-0x000000018A6BAE5C
			public __c() {} // 0x000000018A6BAE5C-0x000000018A6BAEC4
	
			// Methods
			internal string _DeterminePublicDependencies_b__9_0(FileDescriptor file) => default; // 0x000000018A6BAD10-0x000000018A6BAD98
			internal bool _GetAllGeneratedExtensions_b__54_0(GeneratedClrTypeInfo t) => default; // 0x000000018A6B97F0-0x000000018A6B9880
			internal Google.Protobuf.Extension _GetAllDependedExtensions_b__55_0(FieldDescriptor s) => default; // 0x000000018A6B9CE4-0x000000018A6BA038
			internal bool _GetAllDependedExtensions_b__55_1(Google.Protobuf.Extension e) => default; // 0x0000000181377E40-0x0000000181377E50
			internal Google.Protobuf.Extension _GetAllDependedExtensionsFromMessage_b__56_0(FieldDescriptor s) => default; // 0x000000018A6BAEF8-0x000000018A6BAF18
			internal bool _GetAllDependedExtensionsFromMessage_b__56_1(Google.Protobuf.Extension e) => default; // 0x00000001813B88B0-0x00000001813B88C0
		}
	
		// Constructors
		public FileDescriptor() {} // Dummy constructor
		static FileDescriptor() {} // 0x000000018A6BB51C-0x000000018A6BB53C
		private FileDescriptor(ByteString descriptorData, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, DescriptorPool pool, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo) {} // 0x000000018A6BB53C-0x000000018A6BB55C
	
		// Methods
		private Dictionary<IDescriptor, DescriptorDeclaration> CreateDeclarationMap() => default; // 0x00000001813B8590-0x00000001813B85A0
		private IDescriptor FindDescriptorForPath(IList<int> path) => default; // 0x00000001813B51D0-0x00000001813B51E0
		private DescriptorBase GetDescriptorFromList(IReadOnlyList<DescriptorBase> list, int index) => default; // 0x00000001813ECBC0-0x00000001813ECBD0
		private IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) => default; // 0x00000001813FF010-0x00000001813FF020
		internal DescriptorDeclaration GetDeclaration(IDescriptor descriptor) => default; // 0x00000001813ECF20-0x00000001813ECF30
		internal string ComputeFullName(MessageDescriptor parent, string name) => default; // 0x0000000181460F60-0x0000000181460F70
		private static IList<FileDescriptor> DeterminePublicDependencies(FileDescriptor @this, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, bool allowUnknownDependencies) => default; // 0x00000001813F1630-0x00000001813F1640
		public FileDescriptorProto ToProto() => default; // 0x0000000185779060-0x0000000185779070
		public T FindTypeByName<T>(string name)
			where T : class, IDescriptor => default; // 0x000000018A6BB44C-0x000000018A6BB4DC
		private static FileDescriptor BuildFrom(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo) => default; // 0x000000018A6BAEC4-0x000000018A6BAEF0
		private void CrossLink() {}
		public static FileDescriptor FromGeneratedCode(byte[] descriptorData, FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedCodeInfo) => default;
		private static IEnumerable<Google.Protobuf.Extension> GetAllExtensions(FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedInfo) => default;
		private static IEnumerable<Google.Protobuf.Extension> GetAllGeneratedExtensions(GeneratedClrTypeInfo generated) => default; // 0x0000000185492010-0x0000000185492020
		private static IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensions(FileDescriptor descriptor) => default; // 0x000000018A6C0D98-0x000000018A6C0E58
		private static IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensionsFromMessage(MessageDescriptor descriptor) => default; // 0x000000018A6C0E58-0x000000018A6C0F18
		public static IReadOnlyList<FileDescriptor> BuildFromByteStrings(IEnumerable<ByteString> descriptorData, ExtensionRegistry registry) => default; // 0x000000018A6C0F18-0x000000018A6C0FA0
		public static IReadOnlyList<FileDescriptor> BuildFromByteStrings(IEnumerable<ByteString> descriptorData) => default; // 0x000000018A6C17CC-0x000000018A6C1830
		public override string ToString() => default; // 0x0000000185492010-0x0000000185492020
		public Google.Protobuf.Reflection.FileOptions GetOptions() => default; // 0x000000018A6C0B74-0x000000018A6C0B8C
		public T GetOption<T>(Extension<Google.Protobuf.Reflection.FileOptions, T> extension) => default; // 0x0000000182F7A4D0-0x0000000182F7A4E0
		public RepeatedField<T> GetOption<T>(RepeatedExtension<Google.Protobuf.Reflection.FileOptions, T> extension) => default; // 0x000000018A6C0B74-0x000000018A6C0B8C
		public static void ForceReflectionInitialization<T>() {} // 0x0000000182F7A4D0-0x0000000182F7A4E0
	}

	public sealed class GeneratedClrTypeInfo // TypeDefIndex: 53523
	{
		// Fields
		private static readonly string[] EmptyNames; // 0x00
		private static readonly GeneratedClrTypeInfo[] EmptyCodeInfo; // 0x08
		private static readonly Google.Protobuf.Extension[] EmptyExtensions; // 0x10
		internal const DynamicallyAccessedMemberTypes MessageAccessibility = (DynamicallyAccessedMemberTypes) 1547; // Metadata: 0x02078266
		private System.Type _ClrType_k__BackingField; // 0x10
		private readonly MessageParser _Parser_k__BackingField; // 0x18
		private readonly string[] _PropertyNames_k__BackingField; // 0x20
		private readonly Google.Protobuf.Extension[] _Extensions_k__BackingField; // 0x28
		private readonly string[] _OneofNames_k__BackingField; // 0x30
		private readonly GeneratedClrTypeInfo[] _NestedTypes_k__BackingField; // 0x38
		private readonly System.Type[] _NestedEnums_k__BackingField; // 0x40
	
		// Properties
		public System.Type ClrType { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public MessageParser Parser { get; } // 0x0000000181377E40-0x0000000181377E50 
		public string[] PropertyNames { get; } // 0x00000001813B31A0-0x00000001813B31B0 
		public Google.Protobuf.Extension[] Extensions { get; } // 0x00000001813B8590-0x00000001813B85A0 
		public string[] OneofNames { get; } // 0x00000001813B51D0-0x00000001813B51E0 
		public GeneratedClrTypeInfo[] NestedTypes { get; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public System.Type[] NestedEnums { get; } // 0x00000001813FF010-0x00000001813FF020 
	
		// Constructors
		public GeneratedClrTypeInfo() {} // Dummy constructor
		public GeneratedClrTypeInfo(System.Type clrType, MessageParser parser, string[] propertyNames, string[] oneofNames, System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, GeneratedClrTypeInfo[] nestedTypes) {} // 0x000000018A6BB670-0x000000018A6BB7F4
		public GeneratedClrTypeInfo(System.Type clrType, MessageParser parser, string[] propertyNames, string[] oneofNames, System.Type[] nestedEnums, GeneratedClrTypeInfo[] nestedTypes) {} // 0x000000018A6BB828-0x000000018A6BB86C
		public GeneratedClrTypeInfo(System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, GeneratedClrTypeInfo[] nestedTypes) {} // 0x000000018A6BB7F4-0x000000018A6BB828
		public GeneratedClrTypeInfo(System.Type[] nestedEnums, GeneratedClrTypeInfo[] nestedTypes) {} // 0x000000018A6BB644-0x000000018A6BB670
		static GeneratedClrTypeInfo() {} // 0x000000018A6BB55C-0x000000018A6BB644
	}

	public interface IDescriptor // TypeDefIndex: 53524
	{
		// Properties
		string Name { get; }
		string FullName { get; }
		FileDescriptor File { get; }
	}

	public interface IFieldAccessor // TypeDefIndex: 53525
	{
		// Properties
		FieldDescriptor Descriptor { get; }
	
		// Methods
		void Clear(IMessage message);
		object GetValue(IMessage message);
		bool HasValue(IMessage message);
		void SetValue(IMessage message, object value);
	}

	internal sealed class MapFieldAccessor : FieldAccessorBase // TypeDefIndex: 53526
	{
		// Constructors
		public MapFieldAccessor() {} // Dummy constructor
		internal MapFieldAccessor(PropertyInfo property, FieldDescriptor descriptor) {} // 0x000000018A6BB9A0-0x000000018A6BB9A8
	
		// Methods
		public override void Clear(IMessage message) {} // 0x000000018A6BB86C-0x000000018A6BB8E8
		public override bool HasValue(IMessage message) => default; // 0x000000018A6BB8E8-0x000000018A6BB944
		public override void SetValue(IMessage message, object value) {} // 0x000000018A6BB944-0x000000018A6BB9A0
	}

	public sealed class MessageDescriptor : DescriptorBase // TypeDefIndex: 53530
	{
		// Fields
		private static readonly HashSet<string> WellKnownTypeNames; // 0x00
		private readonly IList<FieldDescriptor> fieldsInDeclarationOrder; // 0x28
		private readonly IList<FieldDescriptor> fieldsInNumberOrder; // 0x30
		private readonly IDictionary<string, FieldDescriptor> jsonFieldMap; // 0x38
		private Func<IMessage, bool> extensionSetIsInitialized; // 0x40
		private readonly DescriptorProto _Proto_k__BackingField; // 0x48
		private readonly System.Type _ClrType_k__BackingField; // 0x50
		private readonly MessageParser _Parser_k__BackingField; // 0x58
		private readonly MessageDescriptor _ContainingType_k__BackingField; // 0x60
		private readonly FieldCollection _Fields_k__BackingField; // 0x68
		private readonly ExtensionCollection _Extensions_k__BackingField; // 0x70
		private readonly IList<MessageDescriptor> _NestedTypes_k__BackingField; // 0x78
		private readonly IList<EnumDescriptor> _EnumTypes_k__BackingField; // 0x80
		private readonly IList<OneofDescriptor> _Oneofs_k__BackingField; // 0x88
		private readonly int _RealOneofCount_k__BackingField; // 0x90
	
		// Properties
		public override string Name { get => default; } // 0x0000000185FB0510-0x0000000185FB0520 
		internal DescriptorProto Proto { get; } // 0x000000018A6BC084-0x000000018A6BC110 
		public System.Type ClrType { get; } // 0x000000018A6BD2E0-0x000000018A6BD370 
		public MessageParser Parser { get; } // 0x000000018A6BC1AC-0x000000018A6BC1D8 
		internal bool IsWellKnownType { get => default; }
		internal bool IsWrapperType { get => default; }
		public MessageDescriptor ContainingType { get; } // 0x000000018A6BBD34-0x000000018A6BC084 
		public FieldCollection Fields { get; } // 0x000000018A6BC2AC-0x000000018A6BC49C 
		public ExtensionCollection Extensions { get; } // 0x0000000184096E30-0x0000000184096EF0 
		public IList<MessageDescriptor> NestedTypes { get; } // 0x00000001877A0E08-0x00000001877A0E24 
		public IList<EnumDescriptor> EnumTypes { get; } // 0x00000001877A0E40-0x00000001877A0E5C 
		public IList<OneofDescriptor> Oneofs { get; } // 0x00000001882FF8D8-0x00000001882FF8F4 
		public int RealOneofCount { get; } // 0x000000018A6B7B90-0x000000018A6B7C08 
		public CustomOptions CustomOptions { get => default; } // 0x000000018A6C13EC-0x000000018A6C14B0 
	
		// Nested types
		public sealed class FieldCollection // TypeDefIndex: 53527
		{
			// Fields
			private readonly MessageDescriptor messageDescriptor; // 0x10
	
			// Properties
			public FieldDescriptor this[int number] { get => default; } // 0x00000001813ECF20-0x00000001813ECF30 
			public FieldDescriptor this[string name] { get => default; } // 0x000000018A6BC28C-0x000000018A6BC2AC 
	
			// Constructors
			public FieldCollection() {} // Dummy constructor
			internal FieldCollection(MessageDescriptor messageDescriptor) {} // 0x000000018A6BC49C-0x000000018A6BD2E0
	
			// Methods
			public IList<FieldDescriptor> InDeclarationOrder() => default; // 0x000000018A6BB9A8-0x000000018A6BBD34
			public IList<FieldDescriptor> InFieldNumberOrder() => default; // 0x000000018A6BD4BC-0x000000018A6BD4DC
			internal IDictionary<string, FieldDescriptor> ByJsonName() => default; // 0x000000018A6BC140-0x000000018A6BC1AC
		}
	
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 53528
		{
			// Fields
			public FileDescriptor file; // 0x10
			public MessageDescriptor __4__this; // 0x18
			public GeneratedClrTypeInfo generatedCodeInfo; // 0x20
	
			// Constructors
			public __c__DisplayClass5_0() {} // 0x000000018A6BC1D8-0x000000018A6BC28C
	
			// Methods
			internal OneofDescriptor _.ctor_b__0(OneofDescriptorProto oneof, int index) => default; // 0x0000000181460F60-0x0000000181460F70
			internal MessageDescriptor _.ctor_b__1(DescriptorProto type, int index) => default; // 0x00000001813F1630-0x00000001813F1640
			internal EnumDescriptor _.ctor_b__2(EnumDescriptorProto type, int index) => default; // 0x000000018A6BD370-0x000000018A6BD430
			internal FieldDescriptor _.ctor_b__3(FieldDescriptorProto field, int index) => default; // 0x000000018A6BD430-0x000000018A6BD4BC
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53529
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<FieldDescriptor, int> __9__5_4; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000185FB0530-0x0000000185FB0540
			public __c() {} // 0x00000001813AC280-0x00000001813AC290
	
			// Methods
			internal int _.ctor_b__5_4(FieldDescriptor field) => default; // 0x0000000181460F70-0x0000000181460F80
		}
	
		// Constructors
		public MessageDescriptor() {} // Dummy constructor
		internal MessageDescriptor(DescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int typeIndex, GeneratedClrTypeInfo generatedCodeInfo) {} // 0x0000000183060C50-0x0000000183060C60
		static MessageDescriptor() {} // 0x000000018A6C0B1C-0x000000018A6C0B3C
	
		// Methods
		private static ReadOnlyDictionary<string, FieldDescriptor> CreateJsonFieldMap(IList<FieldDescriptor> fields) => default; // 0x000000018140CF50-0x000000018140CF60
		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) => default; // 0x00000001834A0D50-0x00000001834A0D60
		public DescriptorProto ToProto() => default; // 0x000000018A6BC110-0x000000018A6BC140
		internal bool IsExtensionsInitialized(IMessage message) => default;
		public FieldDescriptor FindFieldByName(string name) => default; // 0x000000018A6B7C08-0x000000018A6B7C80
		public FieldDescriptor FindFieldByNumber(int number) => default; // 0x0000000185492010-0x0000000185492020
		public T FindDescriptor<T>(string name)
			where T : class, IDescriptor => default; // 0x000000018A6C1328-0x000000018A6C13EC
		public MessageOptions GetOptions() => default; // 0x000000018A6C14B0-0x000000018A6C1574
		public T GetOption<T>(Extension<MessageOptions, T> extension) => default; // 0x000000018A6C1574-0x000000018A6C163C
		public RepeatedField<T> GetOption<T>(RepeatedExtension<MessageOptions, T> extension) => default; // 0x000000018A6C1768-0x000000018A6C17CC
		internal void CrossLink() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class MethodDescriptor : DescriptorBase // TypeDefIndex: 53531
	{
		// Fields
		private readonly MethodDescriptorProto proto; // 0x28
		private readonly ServiceDescriptor service; // 0x30
		private MessageDescriptor inputType; // 0x38
		private MessageDescriptor outputType; // 0x40
	
		// Properties
		public ServiceDescriptor Service { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
		public MessageDescriptor InputType { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public MessageDescriptor OutputType { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		public bool IsClientStreaming { get => default; } // 0x000000018A6BD8E4-0x000000018A6BD904 
		public bool IsServerStreaming { get => default; } // 0x000000018A6BD904-0x000000018A6BD924 
		public CustomOptions CustomOptions { get => default; } // 0x000000018A6BD854-0x000000018A6BD8E4 
		internal MethodDescriptorProto Proto { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
		public override string Name { get => default; } // 0x000000018A6BD924-0x000000018A6BD944 
	
		// Constructors
		public MethodDescriptor() {} // Dummy constructor
		internal MethodDescriptor(MethodDescriptorProto proto, FileDescriptor file, ServiceDescriptor parent, int index) {} // 0x000000018A6BD770-0x000000018A6BD854
	
		// Methods
		public MethodOptions GetOptions() => default; // 0x000000018A6BD724-0x000000018A6BD750
		public T GetOption<T>(Extension<MethodOptions, T> extension) => default;
		public RepeatedField<T> GetOption<T>(RepeatedExtension<MethodOptions, T> extension) => default;
		public MethodDescriptorProto ToProto() => default; // 0x000000018A6BD750-0x000000018A6BD770
		internal void CrossLink() {} // 0x000000018A6BD4DC-0x000000018A6BD724
	}

	public sealed class OneofAccessor // TypeDefIndex: 53533
	{
		// Fields
		private readonly Func<IMessage, int> caseDelegate; // 0x10
		private readonly Action<IMessage> clearDelegate; // 0x18
		private readonly OneofDescriptor _Descriptor_k__BackingField; // 0x20
	
		// Properties
		public OneofDescriptor Descriptor { get; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 53532
		{
			// Fields
			public OneofDescriptor descriptor; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x000000018A6BDBB4-0x000000018A6BDBEC
	
			// Methods
			internal int _ForSyntheticOneof_b__0(IMessage message) => default; // 0x000000018A6BD964-0x000000018A6BDA2C
			internal void _ForSyntheticOneof_b__1(IMessage message) {} // 0x000000018A6BDA2C-0x000000018A6BDB64
		}
	
		// Constructors
		public OneofAccessor() {} // Dummy constructor
		private OneofAccessor(OneofDescriptor descriptor, Func<IMessage, int> caseDelegate, Action<IMessage> clearDelegate) {} // 0x00000001813B31A0-0x00000001813B31B0
	
		// Methods
		internal static OneofAccessor ForRegularOneof(OneofDescriptor descriptor, PropertyInfo caseProperty, MethodInfo clearMethod) => default; // 0x000000018A6BD944-0x000000018A6BD964
		internal static OneofAccessor ForSyntheticOneof(OneofDescriptor descriptor) => default; // 0x000000018A6BDB64-0x000000018A6BDBB4
		public void Clear(IMessage message) {} // 0x000000018A6C1224-0x000000018A6C12BC
		public FieldDescriptor GetCaseFieldDescriptor(IMessage message) => default; // 0x000000018A6C12BC-0x000000018A6C1328
	}

	public sealed class OneofDescriptor : DescriptorBase // TypeDefIndex: 53535
	{
		// Fields
		private MessageDescriptor containingType; // 0x28
		private IList<FieldDescriptor> fields; // 0x30
		private readonly OneofAccessor accessor; // 0x38
		private readonly OneofDescriptorProto _Proto_k__BackingField; // 0x40
		private readonly bool _IsSynthetic_k__BackingField; // 0x48
	
		// Properties
		public override string Name { get => default; } // 0x000000018A6BE290-0x000000018A6BE2B0 
		internal OneofDescriptorProto Proto { get; } // 0x00000001813B8590-0x00000001813B85A0 
		public MessageDescriptor ContainingType { get => default; } // 0x0000000185FB0750-0x0000000185FB0760 
		public IList<FieldDescriptor> Fields { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public bool IsSynthetic { get; } // 0x000000018A6BE450-0x000000018A6BE4E0 
		public OneofAccessor Accessor { get => default; } // 0x000000018A6BE264-0x000000018A6BE290 
		public CustomOptions CustomOptions { get => default; }
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 53534
		{
			// Fields
			public int index; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x000000018A6BE2B0-0x000000018A6BE450
	
			// Methods
			internal bool _.ctor_b__0(FieldDescriptorProto fieldProto) => default; // 0x000000018A6BE4E0-0x000000018A6BE500
		}
	
		// Constructors
		public OneofDescriptor() {} // Dummy constructor
		internal OneofDescriptor(OneofDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string clrName) {} // 0x00000001813FF010-0x00000001813FF020
	
		// Methods
		public OneofDescriptorProto ToProto() => default; // 0x00000001813B51D0-0x00000001813B51E0
		public OneofOptions GetOptions() => default;
		public T GetOption<T>(Extension<OneofOptions, T> extension) => default; // 0x000000018A6BDE90-0x000000018A6BE264
		public RepeatedField<T> GetOption<T>(RepeatedExtension<OneofOptions, T> extension) => default; // 0x000000018A6BDBEC-0x000000018A6BDE90
		internal void CrossLink() {} // 0x0000000185492010-0x0000000185492020
		private OneofAccessor CreateAccessor(string clrName) => default; // 0x000000018A6C0FA0-0x000000018A6C0FD8
	}

	public class OriginalNameAttribute : Attribute // TypeDefIndex: 53536
	{
		// Fields
		private string _Name_k__BackingField; // 0x10
		private bool _PreferredAlias_k__BackingField; // 0x18
	
		// Properties
		public string Name { get; set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public bool PreferredAlias { get; set; } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
	
		// Constructors
		public OriginalNameAttribute() {} // Dummy constructor
		public OriginalNameAttribute(string name) {} // 0x00000001852E0FE0-0x00000001852E1050
	}

	internal sealed class PackageDescriptor : IDescriptor // TypeDefIndex: 53537
	{
		// Fields
		private readonly string name; // 0x10
		private readonly string fullName; // 0x18
		private readonly FileDescriptor file; // 0x20
	
		// Properties
		public string Name { get => default; } // 0x000000018346D130-0x000000018346D140 
		public string FullName { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public FileDescriptor File { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
	
		// Constructors
		public PackageDescriptor() {} // Dummy constructor
		internal PackageDescriptor(string name, string fullName, FileDescriptor file) {} // 0x000000018A6BE500-0x000000018A6BE53C
	}

	public static class ReflectionUtil // TypeDefIndex: 53552
	{
		// Fields
		internal static readonly System.Type[] EmptyTypes; // 0x00
		private static readonly bool _CanConvertEnumFuncToInt32Func_k__BackingField; // 0x08
	
		// Properties
		private static bool CanConvertEnumFuncToInt32Func { get; }
	
		// Nested types
		private interface IReflectionHelper // TypeDefIndex: 53538
		{
			// Methods
			Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method); // 0x000000018A6BF100-0x000000018A6BF300
			Action<IMessage> CreateActionIMessage(MethodInfo method);
			Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method); // 0x000000018A6BEDC0-0x000000018A6BEEA4
			Action<IMessage, object> CreateActionIMessageObject(MethodInfo method); // 0x000000018A6BECDC-0x000000018A6BEDC0
			Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method); // 0x000000018A6BE848-0x000000018A6BE94C
		}
	
		internal interface IExtensionReflectionHelper // TypeDefIndex: 53539
		{
			// Methods
			object GetExtension(IMessage message); // 0x000000018A6BE94C-0x000000018A6BEA58
			void SetExtension(IMessage message, object value); // 0x000000018A6BEBF8-0x000000018A6BECDC
			bool HasExtension(IMessage message); // 0x000000018A6BEEA4-0x000000018A6BEFF4
			void ClearExtension(IMessage message); // 0x000000018A6BEA58-0x000000018A6BEBF8
		}
	
		private interface IExtensionSetReflector // TypeDefIndex: 53540
		{
			// Methods
			Func<IMessage, bool> CreateIsInitializedCaller(); // 0x000000018A6BEFF4-0x000000018A6BF100
		}
	
		private class ReflectionHelper<T1, T2> : IReflectionHelper // TypeDefIndex: 53547
		{
			// Nested types
			private sealed class __c__DisplayClass0_0 // TypeDefIndex: 53541
			{
				// Fields
				public Func<T1, int> del;
	
				// Constructors
				public __c__DisplayClass0_0() {} // 0x000000018A6BF300-0x000000018A6BF350
	
				// Methods
				internal int _CreateFuncIMessageInt32_b__0(IMessage message) => default; // 0x000000018A6BE71C-0x000000018A6BE848
			}
	
			private sealed class __c__DisplayClass0_1 // TypeDefIndex: 53542
			{
				// Fields
				public Func<T1, T2> del;
	
				// Constructors
				public __c__DisplayClass0_1() {} // 0x00000001813AE580-0x00000001813AE590
	
				// Methods
				internal int _CreateFuncIMessageInt32_b__1(IMessage message) => default;
			}
	
			private sealed class __c__DisplayClass1_0 // TypeDefIndex: 53543
			{
				// Fields
				public Action<T1> del;
	
				// Constructors
				public __c__DisplayClass1_0() {}
	
				// Methods
				internal void _CreateActionIMessage_b__0(IMessage message) {}
			}
	
			private sealed class __c__DisplayClass2_0 // TypeDefIndex: 53544
			{
				// Fields
				public Func<T1, T2> del;
	
				// Constructors
				public __c__DisplayClass2_0() {}
	
				// Methods
				internal object _CreateFuncIMessageObject_b__0(IMessage message) => default;
			}
	
			private sealed class __c__DisplayClass3_0 // TypeDefIndex: 53545
			{
				// Fields
				public Action<T1, T2> del;
	
				// Constructors
				public __c__DisplayClass3_0() {}
	
				// Methods
				internal void _CreateActionIMessageObject_b__0(IMessage message, object arg) {}
			}
	
			private sealed class __c__DisplayClass4_0 // TypeDefIndex: 53546
			{
				// Fields
				public Func<T1, bool> del;
	
				// Constructors
				public __c__DisplayClass4_0() {}
	
				// Methods
				internal bool _CreateFuncIMessageBool_b__0(IMessage message) => default;
			}
	
			// Constructors
			public ReflectionHelper() {}
	
			// Methods
			public Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method) => default;
			public Action<IMessage> CreateActionIMessage(MethodInfo method) => default;
			public Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method) => default;
			public Action<IMessage, object> CreateActionIMessageObject(MethodInfo method) => default;
			public Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method) => default;
		}
	
		public class ExtensionReflectionHelper<T1, T3> : IExtensionReflectionHelper // TypeDefIndex: 53548
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
	
		private class ExtensionSetReflector<T1> : IExtensionSetReflector // TypeDefIndex: 53550
			where T1 : IExtendableMessage<T1>
		{
			// Nested types
			private sealed class __c__DisplayClass0_0 // TypeDefIndex: 53549
			{
				// Fields
				public Func<T1, ExtensionSet<T1>> getFunc;
				public Func<ExtensionSet<T1>, bool> initializedFunc;
	
				// Constructors
				public __c__DisplayClass0_0() {}
	
				// Methods
				internal bool _CreateIsInitializedCaller_b__0(IMessage m) => default;
			}
	
			// Constructors
			public ExtensionSetReflector() {}
	
			// Methods
			public Func<IMessage, bool> CreateIsInitializedCaller() => default;
		}
	
		public enum SampleEnum // TypeDefIndex: 53551
		{
			X = 0
		}
	
		// Constructors
		static ReflectionUtil() {}
	
		// Methods
		internal static void ForceInitialize<T>() {}
		internal static Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method) => default;
		internal static Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method) => default;
		internal static Action<IMessage, object> CreateActionIMessageObject(MethodInfo method) => default;
		internal static Action<IMessage> CreateActionIMessage(MethodInfo method) => default;
		internal static Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method) => default;
		internal static Func<IMessage, bool> CreateIsInitializedCaller(System.Type msg) => default;
		internal static IExtensionReflectionHelper CreateExtensionHelper(Google.Protobuf.Extension extension) => default;
		private static IReflectionHelper GetReflectionHelper(System.Type t1, System.Type t2) => default;
		private static bool CheckCanConvertEnumFuncToInt32Func() => default;
		public static SampleEnum SampleEnumMethod() => default;
	}

	internal sealed class RepeatedFieldAccessor : FieldAccessorBase // TypeDefIndex: 53553
	{
		// Constructors
		public RepeatedFieldAccessor() {} // Dummy constructor
		internal RepeatedFieldAccessor(PropertyInfo property, FieldDescriptor descriptor) {} // 0x000000018A6BB9A0-0x000000018A6BB9A8
	
		// Methods
		public override void Clear(IMessage message) {} // 0x000000018A6BF350-0x000000018A6BF3CC
		public override bool HasValue(IMessage message) => default; // 0x000000018A6BF3CC-0x000000018A6BF428
		public override void SetValue(IMessage message, object value) {} // 0x000000018A6BF428-0x000000018A6BF484
	}

	public sealed class ServiceDescriptor : DescriptorBase // TypeDefIndex: 53555
	{
		// Fields
		private readonly ServiceDescriptorProto proto; // 0x28
		private readonly IList<MethodDescriptor> methods; // 0x30
	
		// Properties
		public override string Name { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
		internal ServiceDescriptorProto Proto { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
		public IList<MethodDescriptor> Methods { get => default; } // 0x000000018A6BF840-0x000000018A6BF8D0 
		public CustomOptions CustomOptions { get => default; }
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 53554
		{
			// Fields
			public FileDescriptor file; // 0x10
			public ServiceDescriptor __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x000000018A6BF6CC-0x000000018A6BF840
	
			// Methods
			internal MethodDescriptor _.ctor_b__0(MethodDescriptorProto method, int i) => default; // 0x000000018A6BF8D0-0x000000018A6BF8F0
		}
	
		// Constructors
		public ServiceDescriptor() {} // Dummy constructor
		internal ServiceDescriptor(ServiceDescriptorProto proto, FileDescriptor file, int index) {} // 0x000000018A6BF630-0x000000018A6BF680
	
		// Methods
		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) => default; // 0x000000018A6BF6AC-0x000000018A6BF6CC
		public ServiceDescriptorProto ToProto() => default; // 0x000000018A6BF5A4-0x000000018A6BF630
		public MethodDescriptor FindMethodByName(string name) => default; // 0x000000018A6BF680-0x000000018A6BF6AC
		public ServiceOptions GetOptions() => default;
		public T GetOption<T>(Extension<ServiceOptions, T> extension) => default; // 0x000000018A6BF484-0x000000018A6BF5A4
		public RepeatedField<T> GetOption<T>(RepeatedExtension<ServiceOptions, T> extension) => default; // 0x0000000185492010-0x0000000185492020
		internal void CrossLink() {} // 0x000000018A6C0CFC-0x000000018A6C0D98
	}

	internal sealed class SingleFieldAccessor : FieldAccessorBase // TypeDefIndex: 53560
	{
		// Fields
		private readonly Action<IMessage, object> setValueDelegate; // 0x20
		private readonly Action<IMessage> clearDelegate; // 0x28
		private readonly Func<IMessage, bool> hasDelegate; // 0x30
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 53556
		{
			// Fields
			public SingleFieldAccessor __4__this; // 0x10
			public FieldDescriptor descriptor; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x000000018A6BFB60-0x000000018A6C0180
	
			// Methods
			internal bool _.ctor_b__0(IMessage message) => default; // 0x000000018A6BF8F0-0x000000018A6BFB20
			internal void _.ctor_b__1(IMessage message) {} // 0x000000018792AAF0-0x000000018792AB10
		}
	
		private sealed class __c__DisplayClass3_1 // TypeDefIndex: 53557
		{
			// Fields
			public OneofAccessor oneofAccessor; // 0x10
			public __c__DisplayClass3_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass3_1() {} // 0x000000018A6BFB20-0x000000018A6BFB40
	
			// Methods
			internal bool _.ctor_b__2(IMessage message) => default; // 0x000000018A6BFB40-0x000000018A6BFB60
			internal void _.ctor_b__3(IMessage message) {} // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __c__DisplayClass3_2 // TypeDefIndex: 53558
		{
			// Fields
			public object defaultValue; // 0x10
			public __c__DisplayClass3_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass3_2() {} // 0x000000018A6C0FD8-0x000000018A6C1000
	
			// Methods
			internal void _.ctor_b__5(IMessage message) {} // 0x000000018A6C1138-0x000000018A6C1160
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53559
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<IMessage, bool> __9__3_4; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000185492010-0x0000000185492020
			public __c() {} // 0x000000018A6C1160-0x000000018A6C1198
	
			// Methods
			internal bool _.ctor_b__3_4(IMessage message) => default; // 0x000000018A6C1198-0x000000018A6C11F0
		}
	
		// Constructors
		public SingleFieldAccessor() {} // Dummy constructor
		internal SingleFieldAccessor(System.Type messageType, PropertyInfo property, FieldDescriptor descriptor) {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static object GetDefaultValue(FieldDescriptor descriptor) => default; // 0x000000018A6C11F0-0x000000018A6C1224
		public override void Clear(IMessage message) {} // 0x000000018A6C1704-0x000000018A6C1768
		public override bool HasValue(IMessage message) => default; // 0x0000000185492010-0x0000000185492020
		public override void SetValue(IMessage message, object value) {} // 0x000000018A6C0B8C-0x000000018A6C0BE8
	}

	public sealed class TypeRegistry // TypeDefIndex: 53563
	{
		// Fields
		private static readonly TypeRegistry _Empty_k__BackingField; // 0x00
		private readonly Dictionary<string, MessageDescriptor> fullNameToMessageMap; // 0x10
	
		// Properties
		public static TypeRegistry Empty { get; } // 0x000000018A6C07B8-0x000000018A6C0870 
	
		// Nested types
		private class Builder // TypeDefIndex: 53561
		{
			// Fields
			private readonly Dictionary<string, MessageDescriptor> types; // 0x10
			private readonly HashSet<string> fileDescriptorNames; // 0x18
	
			// Constructors
			internal Builder() {} // 0x000000018A6C0870-0x000000018A6C08C0
	
			// Methods
			internal void AddFile(FileDescriptor fileDescriptor) {} // 0x0000000184096E30-0x0000000184096EF0
			private void AddMessage(MessageDescriptor messageDescriptor) {} // 0x000000018A6C03A8-0x000000018A6C0410
			internal TypeRegistry Build() => default; // 0x000000018A6C0410-0x000000018A6C045C
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53562
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MessageDescriptor, FileDescriptor> __9__9_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018A6C045C-0x000000018A6C0614
			public __c() {} // 0x000000018A6C0614-0x000000018A6C0660
	
			// Methods
			internal FileDescriptor _FromMessages_b__9_0(MessageDescriptor md) => default; // 0x000000018A6C0660-0x000000018A6C07B8
		}
	
		// Constructors
		public TypeRegistry() {} // Dummy constructor
		private TypeRegistry(Dictionary<string, MessageDescriptor> fullNameToMessageMap) {} // 0x000000018A6B7A24-0x000000018A6B7AE4
		static TypeRegistry() {} // 0x000000018A6C0B5C-0x000000018A6C0B74
	
		// Methods
		public MessageDescriptor Find(string fullName) => default; // 0x000000018A6B757C-0x000000018A6B783C
		public static TypeRegistry FromFiles(FileDescriptor[] fileDescriptors) => default; // 0x000000018A6B783C-0x000000018A6B79C0
		public static TypeRegistry FromFiles(IEnumerable<FileDescriptor> fileDescriptors) => default; // 0x000000018A6B79C0-0x000000018A6B7A24
		public static TypeRegistry FromMessages(MessageDescriptor[] messageDescriptors) => default; // 0x000000018A6C16A0-0x000000018A6C1704
		public static TypeRegistry FromMessages(IEnumerable<MessageDescriptor> messageDescriptors) => default; // 0x0000000185492010-0x0000000185492020
	}
}

namespace Google.Protobuf.WellKnownTypes
{
	public static class AnyReflection // TypeDefIndex: 53360
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018A67EC1C-0x000000018A67EC6C 
	
		// Constructors
		static AnyReflection() {} // 0x000000018A67E8C4-0x000000018A67EC1C
	}

	public sealed class Any : IMessage<Any>, IBufferMessage // TypeDefIndex: 53362
	{
		// Fields
		private static readonly MessageParser<Any> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int TypeUrlFieldNumber = 1; // Metadata: 0x020780C1
		private string typeUrl_; // 0x18
		public const int ValueFieldNumber = 2; // Metadata: 0x020780C2
		private ByteString value_; // 0x20
		private const string DefaultPrefix = "type.googleapis.com"; // Metadata: 0x020780C3
	
		// Properties
		public static MessageParser<Any> Parser { get => default; } // 0x000000018A67F490-0x000000018A67F4F8 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A67F428-0x000000018A67F490 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A67ED24-0x000000018A67ED84 
		public string TypeUrl { get => default; set {} } // 0x000000018A67F790-0x000000018A67F7F8 0x000000018A67ED84-0x000000018A67EDE8
		public ByteString Value { get => default; set {} } // 0x000000018A67EDE8-0x000000018A67EE90 0x000000018A67EE90-0x000000018A67EF14
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53361
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A67F558-0x000000018A67F5A8
			public __c() {} // 0x000000018A67F4F8-0x000000018A67F558
	
			// Methods
			internal Any _.cctor_b__40_0() => default; // 0x000000018A67F6E8-0x000000018A67F728
		}
	
		// Constructors
		public Any() {} // 0x0000000181377E40-0x0000000181377E50
		public Any(Any other) {} // 0x000000018A67F728-0x000000018A67F790
		static Any() {} // 0x000000018A68B8A0-0x000000018A68B8F0
	
		// Methods
		public Any Clone() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public override bool Equals(object other) => default; // 0x000000018A67F2D8-0x000000018A67F324
		public bool Equals(Any other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A67F654-0x000000018A67F6E8
		public override string ToString() => default; // 0x000000018A67EC6C-0x000000018A67ED24
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A67F0CC-0x000000018A67F14C
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A67F5A8-0x000000018A67F654
		public void MergeFrom(Any other) {} // 0x000000018A67EFA8-0x000000018A67F034
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A67EF14-0x000000018A67EFA8
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018A67F034-0x000000018A67F0CC
		private static string GetTypeUrl(MessageDescriptor descriptor, string prefix) => default;
		public static string GetTypeName(string typeUrl) => default;
		public bool Is(MessageDescriptor descriptor) => default; // 0x000000018A67F284-0x000000018A67F2D8
		public T Unpack<T>()
			where T : IMessage, new() => default; // 0x000000018A67F14C-0x000000018A67F284
		public bool TryUnpack<T>(out ref T result)
			where T : IMessage, new() {
			result = default;
			return default;
		} // 0x000000018A67F324-0x000000018A67F428
		public static Any Pack(IMessage message) => default; // 0x000000018A68BDB4-0x000000018A68BE18
		public static Any Pack(IMessage message, string typeUrlPrefix) => default; // 0x0000000185492010-0x0000000185492020
	}

	public static class ApiReflection // TypeDefIndex: 53363
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018A67FFF4-0x000000018A680044 
	
		// Constructors
		static ApiReflection() {} // 0x000000018A67F7F8-0x000000018A67FFF4
	}

	public sealed class Api : IMessage<Api>, IBufferMessage // TypeDefIndex: 53365
	{
		// Fields
		private static readonly MessageParser<Api> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x020780D7
		private string name_; // 0x18
		public const int MethodsFieldNumber = 2; // Metadata: 0x020780D8
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Method> _repeated_methods_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Method> methods_; // 0x20
		public const int OptionsFieldNumber = 3; // Metadata: 0x020780D9
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x10
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x28
		public const int VersionFieldNumber = 4; // Metadata: 0x020780DA
		private string version_; // 0x30
		public const int SourceContextFieldNumber = 5; // Metadata: 0x020780DB
		private SourceContext sourceContext_; // 0x38
		public const int MixinsFieldNumber = 6; // Metadata: 0x020780DC
		private static readonly FieldCodec<Mixin> _repeated_mixins_codec; // 0x18
		private readonly RepeatedField<Mixin> mixins_; // 0x40
		public const int SyntaxFieldNumber = 7; // Metadata: 0x020780DD
		private Google.Protobuf.WellKnownTypes.Syntax syntax_; // 0x48
	
		// Properties
		public static MessageParser<Api> Parser { get => default; } // 0x000000018A680910-0x000000018A680A50 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A680A50-0x000000018A680B8C 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A680224-0x000000018A680284 
		public string Name { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x00000001813B51D0-0x00000001813B51E0
		public RepeatedField<Google.Protobuf.WellKnownTypes.Method> Methods { get => default; } // 0x000000018A6810F4-0x000000018A68115C 
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public string Version { get => default; set {} } // 0x0000000185A16440-0x0000000185A16450 0x00000001813FF010-0x00000001813FF020
		public SourceContext SourceContext { get => default; set {} } // 0x0000000185FB0570-0x0000000185FB0580 0x0000000185FB05D0-0x0000000185FB05E0
		public RepeatedField<Mixin> Mixins { get => default; } // 0x000000018A680284-0x000000018A6802E8 
		public Google.Protobuf.WellKnownTypes.Syntax Syntax { get => default; set {} } // 0x000000018A6802E8-0x000000018A680410 0x000000018A680410-0x000000018A680504
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53364
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A680BEC-0x000000018A680C3C
			public __c() {} // 0x000000018A680B8C-0x000000018A680BEC
	
			// Methods
			internal Api _.cctor_b__57_0() => default; // 0x000000018A68104C-0x000000018A68108C
		}
	
		// Constructors
		public Api() {} // 0x0000000181377E40-0x0000000181377E50
		public Api(Api other) {} // 0x000000018A68108C-0x000000018A6810F4
		static Api() {} // 0x000000018A68B9B8-0x000000018A68BA08
	
		// Methods
		public Api Clone() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public override bool Equals(object other) => default; // 0x000000018A680684-0x000000018A6806D0
		public bool Equals(Api other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A680E88-0x000000018A68104C
		public override string ToString() => default; // 0x000000018A680044-0x000000018A680224
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A680504-0x000000018A680684
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A680C3C-0x000000018A680E88
		public void MergeFrom(Api other) {} // 0x000000018A6806D0-0x000000018A680910
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A68BB5C-0x000000018A68BBC0
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class Method : IMessage<Google.Protobuf.WellKnownTypes.Method>, IBufferMessage // TypeDefIndex: 53367
	{
		// Fields
		private static readonly MessageParser<Method> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x020780DE
		private string name_; // 0x18
		public const int RequestTypeUrlFieldNumber = 2; // Metadata: 0x020780DF
		private string requestTypeUrl_; // 0x20
		public const int RequestStreamingFieldNumber = 3; // Metadata: 0x020780E0
		private bool requestStreaming_; // 0x28
		public const int ResponseTypeUrlFieldNumber = 4; // Metadata: 0x020780E1
		private string responseTypeUrl_; // 0x30
		public const int ResponseStreamingFieldNumber = 5; // Metadata: 0x020780E2
		private bool responseStreaming_; // 0x38
		public const int OptionsFieldNumber = 6; // Metadata: 0x020780E3
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x40
		public const int SyntaxFieldNumber = 7; // Metadata: 0x020780E4
		private Google.Protobuf.WellKnownTypes.Syntax syntax_; // 0x48
	
		// Properties
		public static MessageParser<Method> Parser { get => default; } // 0x000000018A685020-0x000000018A6850E0 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A684F4C-0x000000018A685020 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6849E8-0x000000018A684A48 
		public string Name { get => default; set {} } // 0x000000018A685574-0x000000018A6855DC 0x00000001813B31B0-0x00000001813B31C0
		public string RequestTypeUrl { get => default; set {} } // 0x00000001813B4840-0x00000001813B4850 0x00000001813B51D0-0x00000001813B51E0
		public bool RequestStreaming { get => default; set {} } // 0x000000018A6855DC-0x000000018A685644 0x0000000185FB0700-0x0000000185FB0710
		public string ResponseTypeUrl { get => default; set {} } // 0x0000000185FAFE20-0x0000000185FAFE30 0x00000001813FF010-0x00000001813FF020
		public bool ResponseStreaming { get => default; set {} } // 0x0000000185FB0570-0x0000000185FB0580 0x0000000185FB05D0-0x0000000185FB05E0
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get => default; } // 0x000000018A684B20-0x000000018A684B84 
		public Google.Protobuf.WellKnownTypes.Syntax Syntax { get => default; set {} } // 0x000000018A684A48-0x000000018A684B20 0x000000018A684B84-0x000000018A684C90
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53366
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A685140-0x000000018A685190
			public __c() {} // 0x000000018A6850E0-0x000000018A685140
	
			// Methods
			internal Method _.cctor_b__57_0() => default; // 0x000000018A6854CC-0x000000018A68550C
		}
	
		// Constructors
		public Method() {} // 0x0000000181377E40-0x0000000181377E50
		public Method(Method other) {} // 0x000000018A68550C-0x000000018A685574
		static Method() {} // 0x000000018A68BA08-0x000000018A68BA58
	
		// Methods
		public Method Clone() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public override bool Equals(object other) => default; // 0x000000018A684D90-0x000000018A684DDC
		public bool Equals(Method other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A685338-0x000000018A6854CC
		public override string ToString() => default; // 0x000000018A68485C-0x000000018A6849E8
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A684C90-0x000000018A684D90
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A685190-0x000000018A685338
		public void MergeFrom(Method other) {} // 0x000000018A684DDC-0x000000018A684F4C
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A68BE18-0x000000018A68BE7C
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class Mixin : IMessage<Mixin>, IBufferMessage // TypeDefIndex: 53369
	{
		// Fields
		private static readonly MessageParser<Mixin> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x020780E5
		private string name_; // 0x18
		public const int RootFieldNumber = 2; // Metadata: 0x020780E6
		private string root_; // 0x20
	
		// Properties
		public static MessageParser<Mixin> Parser { get => default; } // 0x000000018A6859F0-0x000000018A685A44 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A685988-0x000000018A6859F0 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6856F8-0x000000018A685758 
		public string Name { get => default; set {} } // 0x000000018A685C48-0x000000018A685CB0 0x000000018A685758-0x000000018A6857BC
		public string Root { get => default; set {} } // 0x000000018739FF38-0x000000018739FFA0 0x000000018739FFA0-0x00000001873A0018
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53368
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A685AA4-0x000000018A685AF4
			public __c() {} // 0x000000018A685A44-0x000000018A685AA4
	
			// Methods
			internal Mixin _.cctor_b__32_0() => default; // 0x000000018A685BA0-0x000000018A685BE0
		}
	
		// Constructors
		public Mixin() {} // 0x0000000181377E40-0x0000000181377E50
		public Mixin(Mixin other) {} // 0x000000018A685BE0-0x000000018A685C48
		static Mixin() {} // 0x000000018A68B850-0x000000018A68B8A0
	
		// Methods
		public Mixin Clone() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public override bool Equals(object other) => default; // 0x000000018A685838-0x000000018A685884
		public bool Equals(Mixin other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x00000001873A0350-0x00000001873A03E0
		public override string ToString() => default; // 0x000000018A685644-0x000000018A6856F8
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6857BC-0x000000018A685838
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A685AF4-0x000000018A685BA0
		public void MergeFrom(Mixin other) {} // 0x000000018A685884-0x000000018A685988
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A68BAF8-0x000000018A68BB5C
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public static class DurationReflection // TypeDefIndex: 53370
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018A6814D4-0x000000018A681524 
	
		// Constructors
		static DurationReflection() {} // 0x000000018A68115C-0x000000018A6814D4
	}

	public sealed class Duration : IMessage<Duration>, IBufferMessage, ICustomDiagnosticMessage // TypeDefIndex: 53372
	{
		// Fields
		private static readonly MessageParser<Duration> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int SecondsFieldNumber = 1; // Metadata: 0x020780E7
		private long seconds_; // 0x18
		public const int NanosFieldNumber = 2; // Metadata: 0x020780E8
		private int nanos_; // 0x20
		public const int NanosecondsPerSecond = 1000000000; // Metadata: 0x020780E9
		public const int NanosecondsPerTick = 100; // Metadata: 0x020780EE
		public const long MaxSeconds = 315576000000; // Metadata: 0x020780F0
		public const long MinSeconds = -315576000000; // Metadata: 0x020780F8
		internal const int MaxNanoseconds = 999999999; // Metadata: 0x02078100
		internal const int MinNanoseconds = -999999999; // Metadata: 0x02078105
	
		// Properties
		public static MessageParser<Duration> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187356814-0x0000000187356858 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A681710-0x000000018A681770 
		public long Seconds { get => default; set {} } // 0x00000001813B9430-0x00000001813B9440 0x000000018A681770-0x000000018A6817D4
		public int Nanos { get => default; set {} } // 0x0000000187357130-0x0000000187357164 0x0000000187357164-0x00000001873571B0
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53371
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A682078-0x000000018A6820C8
			public __c() {} // 0x000000018A681FE4-0x000000018A682078
	
			// Methods
			internal Duration _.cctor_b__48_0() => default; // 0x000000018A682450-0x000000018A682490
		}
	
		// Constructors
		public Duration() {} // 0x0000000181377E40-0x0000000181377E50
		public Duration(Duration other) {} // 0x0000000181448AC0-0x0000000181448AD0
		static Duration() {} // 0x000000018A68B940-0x000000018A68B97C
	
		// Methods
		public Duration Clone() => default; // 0x00000001813B88B0-0x00000001813B88C0
		public override bool Equals(object other) => default; // 0x000000018A681D2C-0x000000018A681D78
		public bool Equals(Duration other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x0000000187357390-0x0000000187357408
		public override string ToString() => default; // 0x000000018A681674-0x000000018A681710
		public void WriteTo(CodedOutputStream output) {} // 0x00000001873571B0-0x00000001873571FC
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x00000001873572F8-0x0000000187357390
		public void MergeFrom(Duration other) {} // 0x000000018A681958-0x000000018A6819EC
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A681D78-0x000000018A681EE0
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018A6817D4-0x000000018A681958
		internal static bool IsNormalized(long seconds, int nanoseconds) => default; // 0x000000018A682358-0x000000018A682450
		public TimeSpan ToTimeSpan() => default; // 0x000000018A6820C8-0x000000018A68220C
		public static Duration FromTimeSpan(TimeSpan timeSpan) => default; // 0x000000018A68220C-0x000000018A682358
		public static Duration operator -(Duration value) => default; // 0x000000018A6819EC-0x000000018A681A88
		public static Duration operator +(Duration lhs, Duration rhs) => default; // 0x000000018A681AE0-0x000000018A681D2C
		public static Duration operator -(Duration lhs, Duration rhs) => default; // 0x000000018A681A88-0x000000018A681AE0
		internal static Duration Normalize(long seconds, int nanoseconds) => default; // 0x000000018A681524-0x000000018A681674
		internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly) => default; // 0x000000018A681EE0-0x000000018A681FE4
		public string ToDiagnosticString() => default; // 0x000000018A68BD50-0x000000018A68BDB4
		internal static void AppendNanoseconds(StringBuilder builder, int nanos) {} // 0x0000000185492010-0x0000000185492020
	}

	public static class EmptyReflection // TypeDefIndex: 53373
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018A682788-0x000000018A6827D8 
	
		// Constructors
		static EmptyReflection() {} // 0x000000018A682490-0x000000018A682788
	}

	public sealed class Empty : IMessage<Google.Protobuf.WellKnownTypes.Empty>, IBufferMessage // TypeDefIndex: 53375
	{
		// Fields
		private static readonly MessageParser<Empty> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
	
		// Properties
		public static MessageParser<Empty> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018737AF20-0x000000018737AF54 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6827D8-0x000000018A682838 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53374
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A682A80-0x000000018A682AD0
			public __c() {} // 0x000000018A6829EC-0x000000018A682A80
	
			// Methods
			internal Empty _.cctor_b__22_0() => default; // 0x000000018A682AD0-0x000000018A682B10
		}
	
		// Constructors
		public Empty() {} // 0x000000018A682838-0x000000018A68289C
		public Empty(Empty other) {} // 0x000000018737AD50-0x000000018737AD74
		static Empty() {} // 0x000000018A68B724-0x000000018A68B760
	
		// Methods
		public Empty Clone() => default; // 0x000000018737AD74-0x000000018737ADA0
		public override bool Equals(object other) => default; // 0x000000018A68289C-0x000000018A6828E8
		public bool Equals(Empty other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018140B8D0-0x000000018140B8F0
		public override string ToString() => default; // 0x000000018737AC6C-0x000000018737AC8C
		public void WriteTo(CodedOutputStream output) {} // 0x000000018737ADA0-0x000000018737ADD0
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018737B004-0x000000018737B060
		public void MergeFrom(Empty other) {} // 0x000000018A6828E8-0x000000018A6829EC
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A68BC24-0x000000018A68BC88
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public static class FieldMaskReflection // TypeDefIndex: 53376
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018A682E48-0x000000018A682E98 
	
		// Constructors
		static FieldMaskReflection() {} // 0x000000018A682B10-0x000000018A682E48
	}

	public sealed class FieldMask : IMessage<FieldMask>, IBufferMessage, ICustomDiagnosticMessage // TypeDefIndex: 53379
	{
		// Fields
		private static readonly MessageParser<FieldMask> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int PathsFieldNumber = 1; // Metadata: 0x0207810A
		private static readonly FieldCodec<string> _repeated_paths_codec; // 0x08
		private readonly RepeatedField<string> paths_; // 0x18
		private const char FIELD_PATH_SEPARATOR = ','; // Metadata: 0x0207810B
		private const char FIELD_SEPARATOR_REGEX = '.'; // Metadata: 0x0207810D
	
		// Properties
		public static MessageParser<FieldMask> Parser { get => default; } // 0x0000000185FA7B70-0x0000000185FA7BA0 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A68400C-0x000000018A6840B0 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A682E98-0x000000018A682F2C 
		public RepeatedField<string> Paths { get => default; } // 0x000000018A6837DC-0x000000018A683B28 
	
		// Nested types
		public sealed class MergeOptions // TypeDefIndex: 53377
		{
			// Fields
			private bool _ReplaceMessageFields_k__BackingField; // 0x10
			private bool _ReplaceRepeatedFields_k__BackingField; // 0x11
			private bool _ReplacePrimitiveFields_k__BackingField; // 0x12
	
			// Properties
			public bool ReplaceMessageFields { get; set; } // 0x000000018A683EEC-0x000000018A683F3C 0x000000018A683E58-0x000000018A683EEC
			public bool ReplaceRepeatedFields { get; set; } // 0x000000018A6840B0-0x000000018A6840F0 0x000000018A683DE0-0x000000018A683E58
			public bool ReplacePrimitiveFields { get; set; } // 0x000000018A683D58-0x000000018A683DE0 0x000000018A682F2C-0x000000018A682F8C
	
			// Constructors
			public MergeOptions() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53378
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, bool> __9__29_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018A682F8C-0x000000018A682FF0
			public __c() {} // 0x000000018A682FF0-0x000000018A68306C
	
			// Methods
			internal bool _ToJson_b__29_0(string p) => default; // 0x000000018736AA60-0x000000018736AAB0
			internal FieldMask _.cctor_b__47_0() => default; // 0x000000018A683B28-0x000000018A683B74
		}
	
		// Constructors
		public FieldMask() {} // 0x000000018A68359C-0x000000018A683614
		public FieldMask(FieldMask other) {} // 0x0000000185FA7960-0x0000000185FA7990
		static FieldMask() {} // 0x000000018A68B8F0-0x000000018A68B940
	
		// Methods
		public FieldMask Clone() => default; // 0x000000018A683F3C-0x000000018A68400C
		public override bool Equals(object other) => default; // 0x000000018A68378C-0x000000018A6837DC
		public bool Equals(FieldMask other) => default; // 0x000000018A68306C-0x000000018A683128
		public override int GetHashCode() => default;
		public override string ToString() => default;
		public void WriteTo(CodedOutputStream output) {}
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {}
		public int CalculateSize() => default; // 0x000000018A683304-0x000000018A683378
		public void MergeFrom(FieldMask other) {}
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A683378-0x000000018A6834E8
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {}
		internal static string ToJson(IList<string> paths, bool diagnosticOnly) => default; // 0x000000018A6834E8-0x000000018A68359C
		public string ToDiagnosticString() => default; // 0x000000018A683724-0x000000018A68378C
		public static FieldMask FromString(string value) => default; // 0x000000018A683B74-0x000000018A683C1C
		public static FieldMask FromString<T>(string value)
			where T : IMessage => default; // 0x000000018A683128-0x000000018A683304
		public static FieldMask FromStringEnumerable<T>(IEnumerable<string> paths)
			where T : IMessage => default; // 0x000000018A683614-0x000000018A6836B0
		public static FieldMask FromFieldNumbers<T>(int[] fieldNumbers)
			where T : IMessage => default; // 0x000000018A6836B0-0x000000018A683724
		public static FieldMask FromFieldNumbers<T>(IEnumerable<int> fieldNumbers)
			where T : IMessage => default; // 0x000000018A683C1C-0x000000018A683D58
		private static bool IsPathValid(string input) => default; // 0x0000000181C2FD60-0x0000000181C2FD70
		public static bool IsValid<T>(FieldMask fieldMask)
			where T : IMessage => default; // 0x000000018184FBD0-0x000000018184FBE0
		public static bool IsValid(MessageDescriptor descriptor, FieldMask fieldMask) => default; // 0x0000000185FB22C0-0x0000000185FB22D0
		public static bool IsValid<T>(string path)
			where T : IMessage => default; // 0x0000000185FB2560-0x0000000185FB2570
		public static bool IsValid(MessageDescriptor descriptor, string path) => default; // 0x0000000185FB22D0-0x0000000185FB22E0
		public FieldMask Normalize() => default; // 0x0000000183B7E590-0x0000000183B7E5A0
		public FieldMask Union(FieldMask[] otherMasks) => default; // 0x0000000185492010-0x0000000185492020
		public FieldMask Intersection(FieldMask additionalMask) => default; // 0x000000018A68BE7C-0x000000018A68BEE0
		public void Merge(IMessage source, IMessage destination, MergeOptions options) {} // 0x0000000185492010-0x0000000185492020
		public void Merge(IMessage source, IMessage destination) {} // 0x000000018A68B6E0-0x000000018A68B724
	}

	public static class SourceContextReflection // TypeDefIndex: 53380
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018A687DB4-0x000000018A687E04 
	
		// Constructors
		static SourceContextReflection() {} // 0x000000018A687A5C-0x000000018A687DB4
	}

	public sealed class SourceContext : IMessage<SourceContext>, IBufferMessage // TypeDefIndex: 53382
	{
		// Fields
		private static readonly MessageParser<SourceContext> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int FileNameFieldNumber = 1; // Metadata: 0x0207810F
		private string fileName_; // 0x18
	
		// Properties
		public static MessageParser<SourceContext> Parser { get => default; } // 0x000000018A68814C-0x000000018A68818C 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6880F4-0x000000018A68814C 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A687E80-0x000000018A687EE0 
		public string FileName { get => default; set {} } // 0x0000000187377D74-0x0000000187377DC8 0x0000000187377E2C-0x0000000187377E84
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53381
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6881EC-0x000000018A68823C
			public __c() {} // 0x000000018A68818C-0x000000018A6881EC
	
			// Methods
			internal SourceContext _.cctor_b__27_0() => default; // 0x000000018A6882B8-0x000000018A6882F8
		}
	
		// Constructors
		public SourceContext() {} // 0x0000000181377E40-0x0000000181377E50
		public SourceContext(SourceContext other) {} // 0x000000018A6882F8-0x000000018A688360
		static SourceContext() {} // 0x000000018A68B800-0x000000018A68B850
	
		// Methods
		public SourceContext Clone() => default; // 0x000000018A687EE0-0x000000018A687F44
		public override bool Equals(object other) => default; // 0x000000018A687FA4-0x000000018A687FF0
		public bool Equals(SourceContext other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x00000001873781F8-0x000000018737825C
		public override string ToString() => default; // 0x000000018A687E04-0x000000018A687E80
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A687F44-0x000000018A687FA4
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A68823C-0x000000018A6882B8
		public void MergeFrom(SourceContext other) {} // 0x000000018A687FF0-0x000000018A6880F4
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A68BBC0-0x000000018A68BC24
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public static class StructReflection // TypeDefIndex: 53383
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018A688AD0-0x000000018A688B20 
	
		// Constructors
		static StructReflection() {} // 0x000000018A688360-0x000000018A688AD0
	}

	public enum NullValue // TypeDefIndex: 53384
	{
		NullValue = 0
	}

	public sealed class Struct : IMessage<Struct>, IBufferMessage // TypeDefIndex: 53386
	{
		// Fields
		private static readonly MessageParser<Struct> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int FieldsFieldNumber = 1; // Metadata: 0x02078111
		private static readonly MapField<string, Google.Protobuf.WellKnownTypes.Value> _map_fields_codec; // 0x08
		private readonly MapField<string, Google.Protobuf.WellKnownTypes.Value> fields_; // 0x18
	
		// Properties
		public static MessageParser<Struct> Parser { get => default; } // 0x000000018A689030-0x000000018A6890A8 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A688FA8-0x000000018A689030 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A688BB4-0x000000018A688C14 
		public MapField<string, Google.Protobuf.WellKnownTypes.Value> Fields { get => default; } // 0x000000018736AA60-0x000000018736AAB0 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53385
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A689108-0x000000018A689158
			public __c() {} // 0x000000018A6890A8-0x000000018A689108
	
			// Methods
			internal Struct _.cctor_b__27_0() => default; // 0x000000018A6892CC-0x000000018A68930C
		}
	
		// Constructors
		public Struct() {} // 0x0000000181377E40-0x0000000181377E50
		public Struct(Struct other) {} // 0x000000018A688C14-0x000000018A688C78
		static Struct() {} // 0x000000018A68B760-0x000000018A68B7B0
	
		// Methods
		public Struct Clone() => default; // 0x000000018A688C78-0x000000018A688CF4
		public override bool Equals(object other) => default; // 0x000000018A688D6C-0x000000018A688DB8
		public bool Equals(Struct other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A689228-0x000000018A6892CC
		public override string ToString() => default; // 0x000000018A688B20-0x000000018A688BB4
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A688CF4-0x000000018A688D6C
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A689158-0x000000018A689228
		public void MergeFrom(Struct other) {} // 0x000000018A688DB8-0x000000018A688FA8
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A68BCEC-0x000000018A68BD50
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class Value : IMessage<Google.Protobuf.WellKnownTypes.Value>, IBufferMessage // TypeDefIndex: 53389
	{
		// Fields
		private static readonly MessageParser<Value> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NullValueFieldNumber = 1; // Metadata: 0x02078112
		public const int NumberValueFieldNumber = 2; // Metadata: 0x02078113
		public const int StringValueFieldNumber = 3; // Metadata: 0x02078114
		public const int BoolValueFieldNumber = 4; // Metadata: 0x02078115
		public const int StructValueFieldNumber = 5; // Metadata: 0x02078116
		public const int ListValueFieldNumber = 6; // Metadata: 0x02078117
		private object kind_; // 0x18
		private KindOneofCase kindCase_; // 0x20
	
		// Properties
		public static MessageParser<Value> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A68EBFC-0x000000018A68ED38 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A68E210-0x000000018A68E270 
		public NullValue NullValue { get => default; set {} } // 0x000000018A68F464-0x000000018A68F4C8 0x000000018A68EF18-0x000000018A68EF8C
		public double NumberValue { get => default; set {} } // 0x000000018A68F4C8-0x000000018A68F538 0x000000018A68ED38-0x000000018A68ED80
		public string StringValue { get => default; set {} } // 0x000000018A68F378-0x000000018A68F3DC 0x000000018A68EF8C-0x000000018A68EFE0
		public bool BoolValue { get => default; set {} } // 0x000000018A68F538-0x000000018A68F560 0x000000018A68EDE0-0x000000018A68EE34
		public Struct StructValue { get => default; set {} } // 0x000000018A68F3DC-0x000000018A68F404 0x00000001813B88B0-0x00000001813B88C0
		public ListValue ListValue { get => default; set {} } // 0x00000001873A456C-0x00000001873A4580 0x000000018A68E270-0x000000018A68E2D4
		public KindOneofCase KindCase { get => default; } // 0x000000018A68E2D4-0x000000018A68E454 
	
		// Nested types
		public enum KindOneofCase // TypeDefIndex: 53387
		{
			None = 0,
			NullValue = 1,
			NumberValue = 2,
			StringValue = 3,
			BoolValue = 4,
			StructValue = 5,
			ListValue = 6
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53388
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A68EEC8-0x000000018A68EF18
			public __c() {} // 0x000000018A68ED80-0x000000018A68EDE0
	
			// Methods
			internal Value _.cctor_b__58_0() => default; // 0x000000018A68F338-0x000000018A68F378
		}
	
		// Constructors
		public Value() {} // 0x000000018A68EE34-0x000000018A68EE7C
		public Value(Value other) {} // 0x000000018A68F404-0x000000018A68F464
		static Value() {} // 0x000000018A68BA58-0x000000018A68BA94
	
		// Methods
		public Value Clone() => default; // 0x000000018A68EE7C-0x000000018A68EEC8
		public void ClearKind() {} // 0x000000018A68E770-0x000000018A68E8C4
		public override bool Equals(object other) => default; // 0x000000018A68EAAC-0x000000018A68EAF8
		public bool Equals(Value other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A68F20C-0x000000018A68F338
		public override string ToString() => default; // 0x000000018A68E0EC-0x000000018A68E210
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A68E8C4-0x000000018A68EAAC
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A68EFE0-0x000000018A68F20C
		public void MergeFrom(Value other) {} // 0x000000018A68E650-0x000000018A68E6E0
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A68E5F0-0x000000018A68E650
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018A68E454-0x000000018A68E4B4
		public static Value ForString(string value) => default; // 0x000000018A68E59C-0x000000018A68E5F0
		public static Value ForNumber(double value) => default; // 0x000000018A68E4B4-0x000000018A68E59C
		public static Value ForBool(bool value) => default; // 0x000000018A68E6E0-0x000000018A68E770
		public static Value ForNull() => default; // 0x000000018A68EAF8-0x000000018A68EBFC
		public static Value ForList(Value[] values) => default; // 0x000000018A68BA94-0x000000018A68BAF8
		public static Value ForStruct(Struct value) => default; // 0x0000000185492010-0x0000000185492020
	}

	public sealed class ListValue : IMessage<ListValue>, IBufferMessage // TypeDefIndex: 53391
	{
		// Fields
		private static readonly MessageParser<ListValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValuesFieldNumber = 1; // Metadata: 0x0207811F
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Value> _repeated_values_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Value> values_; // 0x18
	
		// Properties
		public static MessageParser<ListValue> Parser { get => default; } // 0x000000018A684580-0x000000018A6845F8 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6844F8-0x000000018A684580 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A684184-0x000000018A6841E4 
		public RepeatedField<Google.Protobuf.WellKnownTypes.Value> Values { get => default; } // 0x000000018736AA60-0x000000018736AAB0 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53390
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A684658-0x000000018A6846A8
			public __c() {} // 0x000000018A6845F8-0x000000018A684658
	
			// Methods
			internal ListValue _.cctor_b__27_0() => default; // 0x000000018A68481C-0x000000018A68485C
		}
	
		// Constructors
		public ListValue() {} // 0x0000000181377E40-0x0000000181377E50
		public ListValue(ListValue other) {} // 0x000000018A6841E4-0x000000018A684248
		static ListValue() {} // 0x000000018A68B7B0-0x000000018A68B800
	
		// Methods
		public ListValue Clone() => default; // 0x000000018A684248-0x000000018A6842C4
		public override bool Equals(object other) => default; // 0x000000018A68433C-0x000000018A684388
		public bool Equals(ListValue other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A684778-0x000000018A68481C
		public override string ToString() => default; // 0x000000018A6840F0-0x000000018A684184
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6842C4-0x000000018A68433C
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6846A8-0x000000018A684778
		public void MergeFrom(ListValue other) {} // 0x000000018A684388-0x000000018A6844F8
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A68BEE0-0x000000018A68BF44
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public static class TimeExtensions // TypeDefIndex: 53392
	{
		// Methods
		public static Timestamp ToTimestamp(System.DateTime dateTime) => default; // 0x000000018A689358-0x000000018A6893A4
		public static Timestamp ToTimestamp(DateTimeOffset dateTimeOffset) => default; // 0x000000018A6893A4-0x000000018A6893F8
		public static Duration ToDuration(TimeSpan timeSpan) => default; // 0x000000018A68930C-0x000000018A689358
	}

	public static class TimestampReflection // TypeDefIndex: 53393
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018A689770-0x000000018A6897C0 
	
		// Constructors
		static TimestampReflection() {} // 0x000000018A6893F8-0x000000018A689770
	}

	public sealed class Timestamp : IMessage<Timestamp>, IBufferMessage, ICustomDiagnosticMessage, IComparable<Timestamp> // TypeDefIndex: 53395
	{
		// Fields
		private static readonly MessageParser<Timestamp> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int SecondsFieldNumber = 1; // Metadata: 0x02078120
		private long seconds_; // 0x18
		public const int NanosFieldNumber = 2; // Metadata: 0x02078121
		private int nanos_; // 0x20
		private static readonly System.DateTime UnixEpoch; // 0x08
		private const long BclSecondsAtUnixEpoch = 62135596800; // Metadata: 0x02078122
		internal const long UnixSecondsAtBclMaxValue = 253402300799; // Metadata: 0x0207812A
		internal const long UnixSecondsAtBclMinValue = -62135596800; // Metadata: 0x02078132
		internal const int MaxNanos = 999999999; // Metadata: 0x0207813A
	
		// Properties
		public static MessageParser<Timestamp> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187356814-0x0000000187356858 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A68985C-0x000000018A6898BC 
		public long Seconds { get => default; set {} } // 0x00000001813B9430-0x00000001813B9440 0x000000018A689950-0x000000018A6899B4
		public int Nanos { get => default; set {} } // 0x0000000187357130-0x0000000187357164 0x0000000187357164-0x00000001873571B0
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53394
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A68A37C-0x000000018A68A3CC
			public __c() {} // 0x000000018A68A2E8-0x000000018A68A37C
	
			// Methods
			internal Timestamp _.cctor_b__55_0() => default; // 0x000000018A68A8BC-0x000000018A68A8FC
		}
	
		// Constructors
		public Timestamp() {} // 0x0000000181377E40-0x0000000181377E50
		public Timestamp(Timestamp other) {} // 0x0000000181448AC0-0x0000000181448AD0
		static Timestamp() {} // 0x000000018A68B97C-0x000000018A68B9B8
	
		// Methods
		public Timestamp Clone() => default; // 0x00000001813B88B0-0x00000001813B88C0
		public override bool Equals(object other) => default; // 0x000000018A68A13C-0x000000018A68A188
		public bool Equals(Timestamp other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x0000000187357390-0x0000000187357408
		public override string ToString() => default; // 0x000000018A6897C0-0x000000018A68985C
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A689BB0-0x000000018A689C48
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x00000001873572F8-0x0000000187357390
		public void MergeFrom(Timestamp other) {} // 0x000000018A689B84-0x000000018A689BB0
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A68A618-0x000000018A68A764
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018A68A3CC-0x000000018A68A51C
		private static bool IsNormalized(long seconds, int nanoseconds) => default; // 0x000000018A68A764-0x000000018A68A8BC
		public static Duration operator -(Timestamp lhs, Timestamp rhs) => default; // 0x000000018A689D4C-0x000000018A689E74
		public static Timestamp operator +(Timestamp lhs, Duration rhs) => default; // 0x000000018A689CD4-0x000000018A689D4C
		public static Timestamp operator -(Timestamp lhs, Duration rhs) => default; // 0x000000018A689A1C-0x000000018A689B84
		public System.DateTime ToDateTime() => default; // 0x000000018A6899B4-0x000000018A689A1C
		public DateTimeOffset ToDateTimeOffset() => default; // 0x000000018A689C48-0x000000018A689CD4
		public static Timestamp FromDateTime(System.DateTime dateTime) => default; // 0x000000018A689ECC-0x000000018A68A13C
		public static Timestamp FromDateTimeOffset(DateTimeOffset dateTimeOffset) => default; // 0x000000018A6898BC-0x000000018A689950
		internal static Timestamp Normalize(long seconds, int nanoseconds) => default; // 0x000000018A68A5F8-0x000000018A68A618
		internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly) => default; // 0x000000018A68A55C-0x000000018A68A580
		public int CompareTo(Timestamp other) => default; // 0x000000018A68A5D4-0x000000018A68A5F8
		public static bool operator <(Timestamp a, Timestamp b) => default; // 0x000000018A68A538-0x000000018A68A55C
		public static bool operator >(Timestamp a, Timestamp b) => default; // 0x000000018A68A51C-0x000000018A68A538
		public static bool operator <=(Timestamp a, Timestamp b) => default; // 0x000000018A68A580-0x000000018A68A5D4
		public static bool operator >=(Timestamp a, Timestamp b) => default; // 0x000000018A689E74-0x000000018A689ECC
		public static bool operator ==(Timestamp a, Timestamp b) => default; // 0x000000018A68A188-0x000000018A68A2E8
		public static bool operator !=(Timestamp a, Timestamp b) => default; // 0x000000018A68BC88-0x000000018A68BCEC
		public string ToDiagnosticString() => default; // 0x0000000185492010-0x0000000185492020
	}

	public static class TypeReflection // TypeDefIndex: 53396
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018A68B690-0x000000018A68B6E0 
	
		// Constructors
		static TypeReflection() {} // 0x000000018A68A8FC-0x000000018A68B690
	}

	public enum Syntax // TypeDefIndex: 53397
	{
		Proto2 = 0,
		Proto3 = 1
	}

	public sealed class Type : IMessage<Google.Protobuf.WellKnownTypes.Type>, IBufferMessage // TypeDefIndex: 53399
	{
		// Fields
		private static readonly MessageParser<Type> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x02078141
		private string name_; // 0x18
		public const int FieldsFieldNumber = 2; // Metadata: 0x02078142
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Field> _repeated_fields_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Field> fields_; // 0x20
		public const int OneofsFieldNumber = 3; // Metadata: 0x02078143
		private static readonly FieldCodec<string> _repeated_oneofs_codec; // 0x10
		private readonly RepeatedField<string> oneofs_; // 0x28
		public const int OptionsFieldNumber = 4; // Metadata: 0x02078144
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x18
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x30
		public const int SourceContextFieldNumber = 5; // Metadata: 0x02078145
		private SourceContext sourceContext_; // 0x38
		public const int SyntaxFieldNumber = 6; // Metadata: 0x02078146
		private Google.Protobuf.WellKnownTypes.Syntax syntax_; // 0x40
	
		// Properties
		public static MessageParser<Type> Parser { get => default; } // 0x000000018A6A24BC-0x000000018A6A25E8 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6A25E8-0x000000018A6A271C 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6A1E50-0x000000018A6A1EB0 
		public string Name { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x00000001813B51D0-0x00000001813B51E0
		public RepeatedField<Google.Protobuf.WellKnownTypes.Field> Fields { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public RepeatedField<string> Oneofs { get => default; } // 0x0000000185A16440-0x0000000185A16450 
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get => default; } // 0x00000001813ECF10-0x00000001813ECF20 
		public SourceContext SourceContext { get => default; set {} } // 0x00000001813EE9C0-0x00000001813EE9D0 0x000000018A6A1FBC-0x000000018A6A2020
		public Google.Protobuf.WellKnownTypes.Syntax Syntax { get => default; set {} } // 0x000000018A6A1EB0-0x000000018A6A1FBC 0x000000018A6A2020-0x000000018A6A2100
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53398
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6A277C-0x000000018A6A27CC
			public __c() {} // 0x000000018A6A271C-0x000000018A6A277C
	
			// Methods
			internal Type _.cctor_b__52_0() => default; // 0x000000018A6A2B74-0x000000018A6A2BB4
		}
	
		// Constructors
		public Type() {} // 0x0000000181377E40-0x0000000181377E50
		public Type(Type other) {} // 0x000000018A6A2BB4-0x000000018A6A2C1C
		static Type() {} // 0x000000018A6A30E0-0x000000018A6A3130
	
		// Methods
		public Type Clone() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public override bool Equals(object other) => default; // 0x000000018A6A2264-0x000000018A6A22B0
		public bool Equals(Type other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A6A29EC-0x000000018A6A2B74
		public override string ToString() => default; // 0x000000018A6A1CB8-0x000000018A6A1E50
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6A2100-0x000000018A6A2264
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6A27CC-0x000000018A6A29EC
		public void MergeFrom(Type other) {} // 0x000000018A6A22B0-0x000000018A6A24BC
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A32E8-0x000000018A6A334C
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class Field : IMessage<Google.Protobuf.WellKnownTypes.Field>, IBufferMessage // TypeDefIndex: 53404
	{
		// Fields
		private static readonly MessageParser<Field> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int KindFieldNumber = 1; // Metadata: 0x02078147
		private Types.Kind kind_; // 0x18
		public const int CardinalityFieldNumber = 2; // Metadata: 0x02078148
		private Types.Cardinality cardinality_; // 0x1C
		public const int NumberFieldNumber = 3; // Metadata: 0x02078149
		private int number_; // 0x20
		public const int NameFieldNumber = 4; // Metadata: 0x0207814A
		private string name_; // 0x28
		public const int TypeUrlFieldNumber = 6; // Metadata: 0x0207814B
		private string typeUrl_; // 0x30
		public const int OneofIndexFieldNumber = 7; // Metadata: 0x0207814C
		private int oneofIndex_; // 0x38
		public const int PackedFieldNumber = 8; // Metadata: 0x0207814D
		private bool packed_; // 0x3C
		public const int OptionsFieldNumber = 9; // Metadata: 0x0207814E
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x40
		public const int JsonNameFieldNumber = 10; // Metadata: 0x0207814F
		private string jsonName_; // 0x48
		public const int DefaultValueFieldNumber = 11; // Metadata: 0x02078150
		private string defaultValue_; // 0x50
	
		// Properties
		public static MessageParser<Field> Parser { get => default; } // 0x000000018A69CADC-0x000000018A69CBB0 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A69C9EC-0x000000018A69CADC 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A69C404-0x000000018A69C464 
		public Types.Kind Kind { get => default; set {} } // 0x00000001813AE9D0-0x00000001813AE9E0 0x00000001813B88B0-0x00000001813B88C0
		public Types.Cardinality Cardinality { get => default; set {} } // 0x00000001813B9430-0x00000001813B9440 0x00000001813B8590-0x00000001813B85A0
		public int Number { get => default; set {} } // 0x000000018A69D184-0x000000018A69D1EC 0x00000001813B51D0-0x00000001813B51E0
		public string Name { get => default; set {} } // 0x000000018A69D1EC-0x000000018A69D254 0x00000001813E5E30-0x00000001813E5E40
		public string TypeUrl { get => default; set {} } // 0x00000001813E6F50-0x00000001813E6F60 0x0000000185FB0A40-0x0000000185FB0A50
		public int OneofIndex { get => default; set {} } // 0x0000000183AC91F0-0x0000000183AC9200 0x00000001813FF010-0x00000001813FF020
		public bool Packed { get => default; set {} } // 0x00000001813ECF20-0x00000001813ECF30 0x000000018A69D11C-0x000000018A69D184
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get => default; } // 0x0000000181460F60-0x0000000181460F70 
		public string JsonName { get => default; set {} } // 0x000000018A69D0B4-0x000000018A69D11C 0x000000018A69C570-0x000000018A69C5D4
		public string DefaultValue { get => default; set {} } // 0x000000018A69C464-0x000000018A69C570 0x000000018A69C5D4-0x000000018A69C6FC
	
		// Nested types
		public static class Types // TypeDefIndex: 53402
		{
			// Nested types
			public enum Kind // TypeDefIndex: 53400
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
	
			public enum Cardinality // TypeDefIndex: 53401
			{
				Unknown = 0,
				Optional = 1,
				Required = 2,
				Repeated = 3
			}
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 53403
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A69CC10-0x000000018A69CC60
			public __c() {} // 0x000000018A69CBB0-0x000000018A69CC10
	
			// Methods
			internal Field _.cctor_b__73_0() => default; // 0x000000018A69D074-0x000000018A69D0B4
		}
	
		// Constructors
		public Field() {} // 0x00000001813AE560-0x00000001813AE570
		public Field(Field other) {} // 0x00000001813AE9C0-0x00000001813AE9D0
		static Field() {} // 0x000000018A6A3130-0x000000018A6A3180
	
		// Methods
		public Field Clone() => default; // 0x00000001813AE570-0x00000001813AE580
		public override bool Equals(object other) => default; // 0x000000018A69C830-0x000000018A69C87C
		public bool Equals(Field other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A69CE74-0x000000018A69D074
		public override string ToString() => default; // 0x000000018A69C1EC-0x000000018A69C404
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A69C6FC-0x000000018A69C830
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A69CC60-0x000000018A69CE74
		public void MergeFrom(Field other) {} // 0x000000018A69C87C-0x000000018A69C9EC
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A3860-0x000000018A6A38C4
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class Enum : IMessage<Google.Protobuf.WellKnownTypes.Enum>, IBufferMessage // TypeDefIndex: 53406
	{
		// Fields
		private static readonly MessageParser<Enum> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x02078168
		private string name_; // 0x18
		public const int EnumvalueFieldNumber = 2; // Metadata: 0x02078169
		private static readonly FieldCodec<EnumValue> _repeated_enumvalue_codec; // 0x08
		private readonly RepeatedField<EnumValue> enumvalue_; // 0x20
		public const int OptionsFieldNumber = 3; // Metadata: 0x0207816A
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x10
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x28
		public const int SourceContextFieldNumber = 4; // Metadata: 0x0207816B
		private SourceContext sourceContext_; // 0x30
		public const int SyntaxFieldNumber = 5; // Metadata: 0x0207816C
		private Google.Protobuf.WellKnownTypes.Syntax syntax_; // 0x38
	
		// Properties
		public static MessageParser<Enum> Parser { get => default; } // 0x000000018A699384-0x000000018A699464 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A699464-0x000000018A699568 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A698DC4-0x000000018A698E24 
		public string Name { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x00000001813B51D0-0x00000001813B51E0
		public RepeatedField<EnumValue> Enumvalue { get => default; } // 0x00000001864721F0-0x0000000186472200 
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get => default; } // 0x00000001813E5E30-0x00000001813E5E40 
		public SourceContext SourceContext { get => default; set {} } // 0x00000001813E6F50-0x00000001813E6F60 0x000000018A698E24-0x000000018A698E88
		public Google.Protobuf.WellKnownTypes.Syntax Syntax { get => default; set {} } // 0x000000018A698E88-0x000000018A698F68 0x000000018A698F68-0x000000018A699024
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53405
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6995C8-0x000000018A699618
			public __c() {} // 0x000000018A699568-0x000000018A6995C8
	
			// Methods
			internal Enum _.cctor_b__47_0() => default; // 0x000000018A699934-0x000000018A699974
		}
	
		// Constructors
		public Enum() {} // 0x0000000181377E40-0x0000000181377E50
		public Enum(Enum other) {} // 0x000000018A699974-0x000000018A6999DC
		static Enum() {} // 0x000000018A6A3090-0x000000018A6A30E0
	
		// Methods
		public Enum Clone() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public override bool Equals(object other) => default; // 0x000000018A699160-0x000000018A6991AC
		public bool Equals(Enum other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A6997E8-0x000000018A699934
		public override string ToString() => default; // 0x000000018A698C58-0x000000018A698DC4
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A699024-0x000000018A699160
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A699618-0x000000018A6997E8
		public void MergeFrom(Enum other) {} // 0x000000018A6991AC-0x000000018A699384
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A38C4-0x000000018A6A3928
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class EnumValue : IMessage<EnumValue>, IBufferMessage // TypeDefIndex: 53408
	{
		// Fields
		private static readonly MessageParser<EnumValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x0207816D
		private string name_; // 0x18
		public const int NumberFieldNumber = 2; // Metadata: 0x0207816E
		private int number_; // 0x20
		public const int OptionsFieldNumber = 3; // Metadata: 0x0207816F
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x28
	
		// Properties
		public static MessageParser<EnumValue> Parser { get => default; } // 0x000000018A698850-0x000000018A6988E8 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6987B0-0x000000018A698850 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6983F4-0x000000018A698454 
		public string Name { get => default; set {} } // 0x00000001813B9430-0x00000001813B9440 0x00000001813B8590-0x00000001813B85A0
		public int Number { get => default; set {} } // 0x000000018A698454-0x000000018A6984B8 0x000000018A6984B8-0x000000018A698550
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get => default; } // 0x00000001873A81BC-0x00000001873A8234 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53407
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A698948-0x000000018A698998
			public __c() {} // 0x000000018A6988E8-0x000000018A698948
	
			// Methods
			internal EnumValue _.cctor_b__37_0() => default; // 0x000000018A698BB0-0x000000018A698BF0
		}
	
		// Constructors
		public EnumValue() {} // 0x0000000181377E40-0x0000000181377E50
		public EnumValue(EnumValue other) {} // 0x000000018A698BF0-0x000000018A698C58
		static EnumValue() {} // 0x000000018A6A2F78-0x000000018A6A2FC8
	
		// Methods
		public EnumValue Clone() => default; // 0x00000001813B88B0-0x00000001813B88C0
		public override bool Equals(object other) => default; // 0x000000018A6985F4-0x000000018A698640
		public bool Equals(EnumValue other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018A698ABC-0x000000018A698BB0
		public override string ToString() => default; // 0x000000018A6982F8-0x000000018A6983F4
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A698550-0x000000018A6985F4
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A698998-0x000000018A698ABC
		public void MergeFrom(EnumValue other) {} // 0x000000018A698640-0x000000018A6987B0
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A3798-0x000000018A6A37FC
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class Option : IMessage<Google.Protobuf.WellKnownTypes.Option>, IBufferMessage // TypeDefIndex: 53410
	{
		// Fields
		private static readonly MessageParser<Option> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x02078170
		private string name_; // 0x18
		public const int ValueFieldNumber = 2; // Metadata: 0x02078171
		private Any value_; // 0x20
	
		// Properties
		public static MessageParser<Option> Parser { get => default; } // 0x000000018A6A0DEC-0x000000018A6A0E2C 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6A0D70-0x000000018A6A0DEC 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6A0A80-0x000000018A6A0AE0 
		public string Name { get => default; set {} } // 0x000000018646EE40-0x000000018646EE50 0x000000018A6A0AE0-0x000000018A6A0B44
		public Any Value { get => default; set {} } // 0x000000018739F11C-0x000000018739F184 0x000000018739F184-0x000000018739F1F4
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53409
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6A0E8C-0x000000018A6A0EDC
			public __c() {} // 0x000000018A6A0E2C-0x000000018A6A0E8C
	
			// Methods
			internal Option _.cctor_b__32_0() => default; // 0x000000018A6A0FD0-0x000000018A6A1010
		}
	
		// Constructors
		public Option() {} // 0x0000000181377E40-0x0000000181377E50
		public Option(Option other) {} // 0x000000018A6A1010-0x000000018A6A1078
		static Option() {} // 0x000000018A6A2EEC-0x000000018A6A2F3C
	
		// Methods
		public Option Clone() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public override bool Equals(object other) => default; // 0x000000018A6A0C20-0x000000018A6A0C6C
		public bool Equals(Option other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018739F5D4-0x000000018739F658
		public override string ToString() => default; // 0x000000018A6A09D4-0x000000018A6A0A80
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6A0B44-0x000000018A6A0C20
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6A0EDC-0x000000018A6A0FD0
		public void MergeFrom(Option other) {} // 0x000000018A6A0C6C-0x000000018A6A0D70
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A34DC-0x000000018A6A3540
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public static class WrappersReflection // TypeDefIndex: 53411
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
		internal const int WrapperValueFieldNumber = 1; // Metadata: 0x02078172
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018A6A4D00-0x000000018A6A4EF8 
	
		// Constructors
		static WrappersReflection() {} // 0x000000018A6A419C-0x000000018A6A4D00
	}

	public sealed class DoubleValue : IMessage<DoubleValue>, IBufferMessage // TypeDefIndex: 53413
	{
		// Fields
		private static readonly MessageParser<DoubleValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x02078173
		private double value_; // 0x18
	
		// Properties
		public static MessageParser<DoubleValue> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001873694DC-0x0000000187369518 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A696F78-0x000000018A696FD8 
		public double Value { get => default; set {} } // 0x000000018A696FD8-0x000000018A697064 0x000000018A6970C8-0x000000018A69715C
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53412
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A69730C-0x000000018A69735C
			public __c() {} // 0x000000018A6972AC-0x000000018A69730C
	
			// Methods
			internal DoubleValue _.cctor_b__27_0() => default; // 0x000000018A69735C-0x000000018A69739C
		}
	
		// Constructors
		public DoubleValue() {} // 0x0000000181C44EA0-0x0000000181C44EB0
		public DoubleValue(DoubleValue other) {} // 0x0000000181C44EB0-0x0000000181C44EC0
		static DoubleValue() {} // 0x000000018A6A2EB0-0x000000018A6A2EEC
	
		// Methods
		public DoubleValue Clone() => default; // 0x000000018A697064-0x000000018A6970C8
		public override bool Equals(object other) => default; // 0x000000018A69715C-0x000000018A6971A8
		public bool Equals(DoubleValue other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x00000001875C7B7C-0x00000001875C7BDC
		public override string ToString() => default; // 0x00000001875C7748-0x00000001875C7784
		public void WriteTo(CodedOutputStream output) {} // 0x00000001875C7968-0x00000001875C79B4
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x00000001875C7B08-0x00000001875C7B7C
		public void MergeFrom(DoubleValue other) {} // 0x000000018A6971A8-0x000000018A6972AC
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A37FC-0x000000018A6A3860
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class FloatValue : IMessage<FloatValue>, IBufferMessage // TypeDefIndex: 53415
	{
		// Fields
		private static readonly MessageParser<FloatValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x02078174
		private float value_; // 0x18
	
		// Properties
		public static MessageParser<FloatValue> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001873998E0-0x000000018739991C 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A69F664-0x000000018A69F6C4 
		public float Value { get => default; set {} } // 0x000000018A69F728-0x000000018A69F7B8 0x000000018A69F7B8-0x000000018A69F84C
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53414
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A69F9FC-0x000000018A69FA4C
			public __c() {} // 0x000000018A69F99C-0x000000018A69F9FC
	
			// Methods
			internal FloatValue _.cctor_b__27_0() => default; // 0x000000018A69FA4C-0x000000018A69FA8C
		}
	
		// Constructors
		public FloatValue() {} // 0x0000000181C9AC50-0x0000000181C9AC60
		public FloatValue(FloatValue other) {} // 0x0000000181C9A5A0-0x0000000181C9A5B0
		static FloatValue() {} // 0x000000018A6A2E38-0x000000018A6A2E74
	
		// Methods
		public FloatValue Clone() => default; // 0x000000018A69F6C4-0x000000018A69F728
		public override bool Equals(object other) => default; // 0x000000018A69F84C-0x000000018A69F898
		public bool Equals(FloatValue other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018760F0C0-0x000000018760F120
		public override string ToString() => default; // 0x000000018760EC8C-0x000000018760ECC8
		public void WriteTo(CodedOutputStream output) {} // 0x000000018760EEB0-0x000000018760EEF8
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018760F04C-0x000000018760F0C0
		public void MergeFrom(FloatValue other) {} // 0x000000018A69F898-0x000000018A69F99C
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A3734-0x000000018A6A3798
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class Int64Value : IMessage<Int64Value>, IBufferMessage // TypeDefIndex: 53417
	{
		// Fields
		private static readonly MessageParser<Int64Value> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x02078175
		private long value_; // 0x18
	
		// Properties
		public static MessageParser<Int64Value> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001873694DC-0x0000000187369518 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A69FE6C-0x000000018A69FECC 
		public long Value { get => default; set {} } // 0x00000001873692DC-0x0000000187369308 0x0000000187369308-0x000000018736934C
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53416
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6A00E0-0x000000018A6A0130
			public __c() {} // 0x000000018A6A0080-0x000000018A6A00E0
	
			// Methods
			internal Int64Value _.cctor_b__27_0() => default; // 0x000000018A6A0130-0x000000018A6A0170
		}
	
		// Constructors
		public Int64Value() {} // 0x0000000181377E40-0x0000000181377E50
		public Int64Value(Int64Value other) {} // 0x0000000181448AC0-0x0000000181448AD0
		static Int64Value() {} // 0x000000018A6A2E74-0x000000018A6A2EB0
	
		// Methods
		public Int64Value Clone() => default; // 0x000000018A69FECC-0x000000018A69FF30
		public override bool Equals(object other) => default; // 0x000000018A69FF30-0x000000018A69FF7C
		public bool Equals(Int64Value other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018736963C-0x0000000187369690
		public override string ToString() => default; // 0x000000018A69FDFC-0x000000018A69FE6C
		public void WriteTo(CodedOutputStream output) {} // 0x000000018736934C-0x000000018736938C
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x00000001873695C8-0x000000018736963C
		public void MergeFrom(Int64Value other) {} // 0x000000018A69FF7C-0x000000018A6A0080
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A36D0-0x000000018A6A3734
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class UInt64Value : IMessage<UInt64Value>, IBufferMessage // TypeDefIndex: 53419
	{
		// Fields
		private static readonly MessageParser<UInt64Value> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x02078176
		private ulong value_; // 0x18
	
		// Properties
		public static MessageParser<UInt64Value> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001873694DC-0x0000000187369518 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6A3E98-0x000000018A6A3EF8 
		public ulong Value { get => default; set {} } // 0x00000001873692DC-0x0000000187369308 0x000000018737E234-0x000000018737E278
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53418
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6A410C-0x000000018A6A415C
			public __c() {} // 0x000000018A6A40AC-0x000000018A6A410C
	
			// Methods
			internal UInt64Value _.cctor_b__27_0() => default; // 0x000000018A6A415C-0x000000018A6A419C
		}
	
		// Constructors
		public UInt64Value() {} // 0x0000000181377E40-0x0000000181377E50
		public UInt64Value(UInt64Value other) {} // 0x0000000181448AC0-0x0000000181448AD0
		static UInt64Value() {} // 0x000000018A6A2CE4-0x000000018A6A2D20
	
		// Methods
		public UInt64Value Clone() => default; // 0x000000018A6A3EF8-0x000000018A6A3F5C
		public override bool Equals(object other) => default; // 0x000000018A6A3F5C-0x000000018A6A3FA8
		public bool Equals(UInt64Value other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018737E478-0x000000018737E4CC
		public override string ToString() => default; // 0x000000018A6A3E28-0x000000018A6A3E98
		public void WriteTo(CodedOutputStream output) {} // 0x000000018736934C-0x000000018736938C
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x00000001873695C8-0x000000018736963C
		public void MergeFrom(UInt64Value other) {} // 0x000000018A6A3FA8-0x000000018A6A40AC
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A366C-0x000000018A6A36D0
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class Int32Value : IMessage<Int32Value>, IBufferMessage // TypeDefIndex: 53421
	{
		// Fields
		private static readonly MessageParser<Int32Value> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x02078177
		private int value_; // 0x18
	
		// Properties
		public static MessageParser<Int32Value> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001873998E0-0x000000018739991C 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A69FAF8-0x000000018A69FB58 
		public int Value { get => default; set {} } // 0x00000001873996D8-0x0000000187399704 0x0000000187399768-0x00000001873997A0
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53420
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A69FD6C-0x000000018A69FDBC
			public __c() {} // 0x000000018A69FD0C-0x000000018A69FD6C
	
			// Methods
			internal Int32Value _.cctor_b__27_0() => default; // 0x000000018A69FDBC-0x000000018A69FDFC
		}
	
		// Constructors
		public Int32Value() {} // 0x00000001813AE560-0x00000001813AE570
		public Int32Value(Int32Value other) {} // 0x00000001813AE9C0-0x00000001813AE9D0
		static Int32Value() {} // 0x000000018A6A2DFC-0x000000018A6A2E38
	
		// Methods
		public Int32Value Clone() => default; // 0x000000018A69FB58-0x000000018A69FBBC
		public override bool Equals(object other) => default; // 0x000000018A69FBBC-0x000000018A69FC08
		public bool Equals(Int32Value other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x0000000181418230-0x0000000181418290
		public override string ToString() => default; // 0x000000018A69FA8C-0x000000018A69FAF8
		public void WriteTo(CodedOutputStream output) {} // 0x00000001873997A0-0x00000001873997DC
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018739996C-0x00000001873999DC
		public void MergeFrom(Int32Value other) {} // 0x000000018A69FC08-0x000000018A69FD0C
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A3478-0x000000018A6A34DC
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class UInt32Value : IMessage<UInt32Value>, IBufferMessage // TypeDefIndex: 53423
	{
		// Fields
		private static readonly MessageParser<UInt32Value> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x02078178
		private uint value_; // 0x18
	
		// Properties
		public static MessageParser<UInt32Value> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001873998E0-0x000000018739991C 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6A3B24-0x000000018A6A3B84 
		public uint Value { get => default; set {} } // 0x00000001873996D8-0x0000000187399704 0x0000000187399768-0x00000001873997A0
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53422
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6A3D98-0x000000018A6A3DE8
			public __c() {} // 0x000000018A6A3D38-0x000000018A6A3D98
	
			// Methods
			internal UInt32Value _.cctor_b__27_0() => default; // 0x000000018A6A3DE8-0x000000018A6A3E28
		}
	
		// Constructors
		public UInt32Value() {} // 0x00000001813AE560-0x00000001813AE570
		public UInt32Value(UInt32Value other) {} // 0x00000001813AE9C0-0x00000001813AE9D0
		static UInt32Value() {} // 0x000000018A6A2CA8-0x000000018A6A2CE4
	
		// Methods
		public UInt32Value Clone() => default; // 0x000000018A6A3B84-0x000000018A6A3BE8
		public override bool Equals(object other) => default; // 0x000000018A6A3BE8-0x000000018A6A3C34
		public bool Equals(UInt32Value other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x0000000187472BA0-0x0000000187472BF4
		public override string ToString() => default; // 0x000000018A6A3AB8-0x000000018A6A3B24
		public void WriteTo(CodedOutputStream output) {} // 0x00000001873997A0-0x00000001873997DC
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018739996C-0x00000001873999DC
		public void MergeFrom(UInt32Value other) {} // 0x000000018A6A3C34-0x000000018A6A3D38
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A3414-0x000000018A6A3478
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class BoolValue : IMessage<BoolValue>, IBufferMessage // TypeDefIndex: 53425
	{
		// Fields
		private static readonly MessageParser<BoolValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x02078179
		private bool value_; // 0x18
	
		// Properties
		public static MessageParser<BoolValue> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187413764-0x00000001874137A0 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A691248-0x000000018A6912A8 
		public bool Value { get => default; set {} } // 0x0000000187413590-0x00000001874135BC 0x000000018A69130C-0x000000018A691374
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53424
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A691524-0x000000018A691574
			public __c() {} // 0x000000018A6914C4-0x000000018A691524
	
			// Methods
			internal BoolValue _.cctor_b__27_0() => default; // 0x000000018A691574-0x000000018A6915B4
		}
	
		// Constructors
		public BoolValue() {} // 0x00000001813C0430-0x00000001813C0440
		public BoolValue(BoolValue other) {} // 0x00000001813C0520-0x00000001813C0530
		static BoolValue() {} // 0x000000018A6A2D20-0x000000018A6A2D5C
	
		// Methods
		public BoolValue Clone() => default; // 0x000000018A6912A8-0x000000018A69130C
		public override bool Equals(object other) => default; // 0x000000018A691374-0x000000018A6913C0
		public bool Equals(BoolValue other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018741385C-0x00000001874138B0
		public override string ToString() => default; // 0x000000018741349C-0x00000001874134CC
		public void WriteTo(CodedOutputStream output) {} // 0x0000000187413624-0x0000000187413660
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x00000001874137F0-0x000000018741385C
		public void MergeFrom(BoolValue other) {} // 0x000000018A6913C0-0x000000018A6914C4
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A3A54-0x000000018A6A3AB8
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class StringValue : IMessage<StringValue>, IBufferMessage // TypeDefIndex: 53427
	{
		// Fields
		private static readonly MessageParser<StringValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x0207817A
		private string value_; // 0x18
	
		// Properties
		public static MessageParser<StringValue> Parser { get => default; } // 0x000000018A6A1A4C-0x000000018A6A1A8C 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A6A1A8C-0x000000018A6A1AE4 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A6A17D8-0x000000018A6A1838 
		public string Value { get => default; set {} } // 0x0000000187377D74-0x0000000187377DC8 0x0000000187377E2C-0x0000000187377E84
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53426
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A6A1B44-0x000000018A6A1B94
			public __c() {} // 0x000000018A6A1AE4-0x000000018A6A1B44
	
			// Methods
			internal StringValue _.cctor_b__27_0() => default; // 0x000000018A6A1C10-0x000000018A6A1C50
		}
	
		// Constructors
		public StringValue() {} // 0x0000000181377E40-0x0000000181377E50
		public StringValue(StringValue other) {} // 0x000000018A6A1C50-0x000000018A6A1CB8
		static StringValue() {} // 0x000000018A6A2DAC-0x000000018A6A2DFC
	
		// Methods
		public StringValue Clone() => default; // 0x000000018A6A1838-0x000000018A6A189C
		public override bool Equals(object other) => default; // 0x000000018A6A18FC-0x000000018A6A1948
		public bool Equals(StringValue other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x00000001873781F8-0x000000018737825C
		public override string ToString() => default; // 0x000000018A6A175C-0x000000018A6A17D8
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A6A189C-0x000000018A6A18FC
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A6A1B94-0x000000018A6A1C10
		public void MergeFrom(StringValue other) {} // 0x000000018A6A1948-0x000000018A6A1A4C
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A3928-0x000000018A6A398C
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class BytesValue : IMessage<BytesValue>, IBufferMessage // TypeDefIndex: 53429
	{
		// Fields
		private static readonly MessageParser<BytesValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x0207817B
		private ByteString value_; // 0x18
	
		// Properties
		public static MessageParser<BytesValue> Parser { get => default; } // 0x000000018A6919A0-0x000000018A6919F4 
		public static MessageDescriptor Descriptor { get => default; } // 0x000000018A691948-0x000000018A6919A0 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018A691638-0x000000018A691698 
		public ByteString Value { get => default; set {} } // 0x000000018A691698-0x000000018A69172C 0x00000001873B0EC4-0x00000001873B0F28
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 53428
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018A691A54-0x000000018A691AA4
			public __c() {} // 0x000000018A6919F4-0x000000018A691A54
	
			// Methods
			internal BytesValue _.cctor_b__27_0() => default; // 0x000000018A691B20-0x000000018A691B60
		}
	
		// Constructors
		public BytesValue() {} // 0x0000000181377E40-0x0000000181377E50
		public BytesValue(BytesValue other) {} // 0x000000018A691B60-0x000000018A691BC8
		static BytesValue() {} // 0x000000018A6A2C58-0x000000018A6A2CA8
	
		// Methods
		public BytesValue Clone() => default; // 0x000000018A69172C-0x000000018A691790
		public override bool Equals(object other) => default; // 0x000000018A6917F8-0x000000018A691844
		public bool Equals(BytesValue other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x00000001873B120C-0x00000001873B1274
		public override string ToString() => default; // 0x000000018A6915B4-0x000000018A691638
		public void WriteTo(CodedOutputStream output) {} // 0x000000018A691790-0x000000018A6917F8
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x000000018A691AA4-0x000000018A691B20
		public void MergeFrom(BytesValue other) {} // 0x000000018A691844-0x000000018A691948
		public void MergeFrom(CodedInputStream input) {} // 0x000000018A6A39F0-0x000000018A6A3A54
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Diagnostics.CodeAnalysis
{
	internal sealed class DynamicallyAccessedMembersAttribute : Attribute // TypeDefIndex: 53266
	{
		// Fields
		private readonly DynamicallyAccessedMemberTypes _MemberTypes_k__BackingField; // 0x10
	
		// Properties
		public DynamicallyAccessedMemberTypes MemberTypes { get; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
	
		// Constructors
		public DynamicallyAccessedMembersAttribute() {} // Dummy constructor
		public DynamicallyAccessedMembersAttribute(DynamicallyAccessedMemberTypes memberTypes) {} // 0x0000000181378230-0x0000000181378240
	}

	internal enum DynamicallyAccessedMemberTypes // TypeDefIndex: 53267
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

	internal sealed class RequiresUnreferencedCodeAttribute : Attribute // TypeDefIndex: 53268
	{
		// Fields
		private readonly string _Message_k__BackingField; // 0x10
		private string _Url_k__BackingField; // 0x18
	
		// Properties
		public string Message { get; } // 0x000000018346D130-0x000000018346D140 
		public string Url { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public RequiresUnreferencedCodeAttribute() {} // Dummy constructor
		public RequiresUnreferencedCodeAttribute(string message) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	internal sealed class UnconditionalSuppressMessageAttribute : Attribute // TypeDefIndex: 53269
	{
		// Fields
		private readonly string _Category_k__BackingField; // 0x10
		private readonly string _CheckId_k__BackingField; // 0x18
		private string _Scope_k__BackingField; // 0x20
		private string _Target_k__BackingField; // 0x28
		private string _MessageId_k__BackingField; // 0x30
		private string _Justification_k__BackingField; // 0x38
	
		// Properties
		public string Category { get; } // 0x000000018346D130-0x000000018346D140 
		public string CheckId { get; } // 0x0000000181377E40-0x0000000181377E50 
		public string Scope { get; set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public string Target { get; set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public string MessageId { get; set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public string Justification { get; set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
	
		// Constructors
		public UnconditionalSuppressMessageAttribute() {} // Dummy constructor
		public UnconditionalSuppressMessageAttribute(string category, string checkId) {} // 0x00000001841BC230-0x00000001841BC260
	}
}
