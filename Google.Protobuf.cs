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

// Image 26: Google.Protobuf.dll - Assembly: Google.Protobuf, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 55750-56067
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 56067
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_44 _1EFF1891409D680B30DE202BD7A16F945ED09F02601C0E7B90FD917BE1162300; // 0x00 // Static value (base64): AAAAAADh9QUA4fUFgJaYAEBCDwCghgEAECcAAOgDAABkAAAACgAAAAEAAAA= - Metadata: 0x0234786C

	// Nested types
	private struct __StaticArrayInitTypeSize_44 // TypeDefIndex: 56066
	{
	}
}

namespace Google.Protobuf
{
	internal static class ByteArray // TypeDefIndex: 55755
	{
		// Fields
		private const int CopyThreshold = 12; // Metadata: 0x02347642
	
		// Methods
		internal static void Copy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count); // 0x00000001832A8AA0-0x00000001832A8AD0
		internal static void Reverse(byte[] bytes); // 0x0000000189ACC204-0x0000000189ACC26C
	}

	public sealed class ByteString : IEnumerable<byte>, IEquatable<ByteString> // TypeDefIndex: 55756
	{
		// Fields
		private static readonly ByteString empty; // 0x00
		private readonly ReadOnlyMemory<byte> bytes; // 0x10
	
		// Properties
		public static ByteString Empty { get; } // 0x0000000189ACCEC4-0x0000000189ACCEF8 
		public int Length { get; } // 0x0000000184DA0CD0-0x0000000184DA0CE0 
		public bool IsEmpty { get; } // 0x0000000189ACCEF8-0x0000000189ACCF04 
		public ReadOnlySpan<byte> Span { get; } // 0x00000001853972F0-0x0000000185397320 
		public ReadOnlyMemory<byte> Memory { get; } // 0x0000000182B2D510-0x0000000182B2D520 
		public byte this[int index] { get => default; } // 0x0000000189ACCF04-0x0000000189ACCF64 
	
		// Constructors
		private ByteString(ReadOnlyMemory<byte> bytes); // 0x00000001832A8A90-0x00000001832A8AA0
		static ByteString(); // 0x0000000184CD7D50-0x0000000184CD7E00
	
		// Methods
		internal static ByteString AttachBytes(ReadOnlyMemory<byte> bytes); // 0x00000001832A6AF0-0x00000001832A6B50
		internal static ByteString AttachBytes(byte[] bytes); // 0x00000001832A6A60-0x00000001832A6AF0
		public byte[] ToByteArray(); // 0x00000001832196A0-0x00000001832196E0
		public string ToBase64(); // 0x0000000189ACCB90-0x0000000189ACCCA4
		public static ByteString FromBase64(string bytes); // 0x0000000189ACC7B4-0x0000000189ACC894
		public static ByteString FromStream(Stream stream); // 0x0000000189ACC8FC-0x0000000189ACCA8C
		public static Task<ByteString> FromStreamAsync(Stream stream, CancellationToken cancellationToken = default); // 0x0000000189ACC894-0x0000000189ACC8FC
		public static ByteString CopyFrom(params byte[] bytes); // 0x0000000184CCA610-0x0000000184CCA6C0
		public static ByteString CopyFrom(byte[] bytes, int offset, int count); // 0x00000001832A89E0-0x00000001832A8A90
		public static ByteString CopyFrom(ReadOnlySpan<byte> bytes); // 0x0000000189ACC458-0x0000000189ACC4F8
		public static ByteString CopyFrom(string text, Encoding encoding); // 0x0000000189ACC3B4-0x0000000189ACC458
		public static ByteString CopyFromUtf8(string text); // 0x0000000189ACC35C-0x0000000189ACC3B4
		public string ToString(Encoding encoding); // 0x0000000189ACCCC8-0x0000000189ACCDC4
		public string ToStringUtf8(); // 0x0000000189ACCCA4-0x0000000189ACCCC8
		public IEnumerator<byte> GetEnumerator(); // 0x0000000189ACCA8C-0x0000000189ACCAFC
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000189ACCB88-0x0000000189ACCB90
		public CodedInputStream CreateCodedInput(); // 0x0000000189ACC580-0x0000000189ACC6E8
		public static bool operator ==(ByteString lhs, ByteString rhs); // 0x0000000183218B90-0x0000000183218BE0
		public static bool operator !=(ByteString lhs, ByteString rhs); // 0x0000000189ACCF64-0x0000000189ACCFB8
		public override bool Equals(object obj); // 0x0000000189ACC6E8-0x0000000189ACC758
		public override int GetHashCode(); // 0x0000000189ACCAFC-0x0000000189ACCB88
		public bool Equals(ByteString other); // 0x0000000189ACC758-0x0000000189ACC7B4
		public void CopyTo(byte[] array, int position); // 0x0000000189ACC4F8-0x0000000189ACC580
		public void WriteTo(Stream outputStream); // 0x0000000189ACCDC4-0x0000000189ACCEC4
	}

	internal static class ByteStringAsync // TypeDefIndex: 55758
	{
		// Nested types
		[CompilerGenerated]
		private struct _FromStreamAsyncCore_d__0 : IAsyncStateMachine // TypeDefIndex: 55757
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<ByteString> __t__builder; // 0x08
			public Stream stream; // 0x20
			public CancellationToken cancellationToken; // 0x28
			private MemoryStream _memoryStream_5__2; // 0x30
			private TaskAwaiter __u__1; // 0x38
	
			// Methods
			private void MoveNext(); // 0x0000000189AE1984-0x0000000189AE1CF0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000189AE1CF0-0x0000000189AE1D50
		}
	
		// Methods
		internal static async Task<ByteString> FromStreamAsyncCore(Stream stream, CancellationToken cancellationToken); // 0x0000000189ACC26C-0x0000000189ACC35C
	}

	public sealed class CodedInputStream : IDisposable // TypeDefIndex: 55759
	{
		// Fields
		private readonly bool leaveOpen; // 0x10
		private readonly byte[] buffer; // 0x18
		private readonly Stream input; // 0x20
		private ParserInternalState state; // 0x28
		internal const int DefaultRecursionLimit = 100; // Metadata: 0x02347643
		internal const int DefaultSizeLimit = 2147483647; // Metadata: 0x02347645
		internal const int BufferSize = 4096; // Metadata: 0x02347646
	
		// Properties
		public long Position { get; } // 0x0000000189ACDD88-0x0000000189ACDDC4 
		internal uint LastTag { get; } // 0x0000000184D86890-0x0000000184D868A0 
		public int SizeLimit { get; } // 0x0000000184D86B20-0x0000000184D86B30 
		public int RecursionLimit { get; } // 0x0000000184D862D0-0x0000000184D862E0 
		internal bool DiscardUnknownFields { get; set; } // 0x0000000184D92ED0-0x0000000184D92EE0 0x0000000184D92F60-0x0000000184D92F70
		internal ExtensionRegistry ExtensionRegistry { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
		internal byte[] InternalBuffer { get; } // 0x000000018385B100-0x000000018385B110 
		internal Stream InternalInputStream { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		internal ref ParserInternalState InternalState { get; } // 0x0000000184DA0CE0-0x0000000184DA0CF0 
		internal bool ReachedLimit { get; } // 0x0000000189ACDDC4-0x0000000189ACDDD0 
		public bool IsAtEnd { get; } // 0x0000000189ACDD24-0x0000000189ACDD88 
	
		// Constructors
		public CodedInputStream(byte[] buffer); // 0x0000000189ACDC9C-0x0000000189ACDD24
		public CodedInputStream(byte[] buffer, int offset, int length); // 0x0000000183143150-0x00000001831432B0
		public CodedInputStream(Stream input); // 0x0000000189ACDAC8-0x0000000189ACDAD4
		public CodedInputStream(Stream input, bool leaveOpen); // 0x0000000189ACDBF4-0x0000000189ACDC9C
		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, bool leaveOpen); // 0x00000001831437F0-0x0000000183143910
		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, int sizeLimit, int recursionLimit, bool leaveOpen); // 0x0000000189ACDAD4-0x0000000189ACDBF4
	
		// Methods
		public static CodedInputStream CreateWithLimits(Stream input, int sizeLimit, int recursionLimit); // 0x0000000189ACCFB8-0x0000000189ACD078
		public void Dispose(); // 0x0000000189ACD078-0x0000000189ACD0A4
		internal void CheckReadEndOfStreamTag(); // 0x00000001831437B0-0x00000001831437F0
		public uint PeekTag(); // 0x0000000189ACD118-0x0000000189ACD180
		public uint ReadTag(); // 0x0000000189ACD8D8-0x0000000189ACD940
		public void SkipLastField(); // 0x0000000189ACDA48-0x0000000189ACDAC8
		internal void SkipGroup(uint startGroupTag); // 0x0000000189ACD9BC-0x0000000189ACDA48
		public double ReadDouble(); // 0x0000000189ACD218-0x0000000189ACD280
		public float ReadFloat(); // 0x0000000189ACD298-0x0000000189ACD300
		public ulong ReadUInt64(); // 0x0000000189ACD3FC-0x0000000189ACD404
		public long ReadInt64(); // 0x0000000189ACD3FC-0x0000000189ACD404
		public int ReadInt32(); // 0x0000000189ACD280-0x0000000189ACD288
		public ulong ReadFixed64(); // 0x0000000189ACD290-0x0000000189ACD298
		public uint ReadFixed32(); // 0x0000000189ACD288-0x0000000189ACD290
		public bool ReadBool(); // 0x0000000189ACD19C-0x0000000189ACD1B4
		public string ReadString(); // 0x0000000189ACD874-0x0000000189ACD8D8
		public void ReadMessage(IMessage builder); // 0x0000000189ACD46C-0x0000000189ACD61C
		public void ReadGroup(IMessage builder); // 0x0000000189ACD300-0x0000000189ACD3FC
		public ByteString ReadBytes(); // 0x0000000189ACD1B4-0x0000000189ACD218
		public uint ReadUInt32(); // 0x0000000189ACD280-0x0000000189ACD288
		public int ReadEnum(); // 0x0000000189ACD280-0x0000000189ACD288
		public int ReadSFixed32(); // 0x0000000189ACD288-0x0000000189ACD290
		public long ReadSFixed64(); // 0x0000000189ACD290-0x0000000189ACD298
		public int ReadSInt32(); // 0x0000000189ACD838-0x0000000189ACD854
		public long ReadSInt64(); // 0x0000000189ACD854-0x0000000189ACD874
		public int ReadLength(); // 0x0000000189ACD404-0x0000000189ACD46C
		public bool MaybeConsumeTag(uint tag); // 0x0000000189ACD0A4-0x0000000189ACD118
		internal uint ReadRawVarint32(); // 0x0000000189ACD768-0x0000000189ACD7D0
		internal static uint ReadRawVarint32(Stream input); // 0x0000000189ACD760-0x0000000189ACD768
		internal ulong ReadRawVarint64(); // 0x0000000189ACD7D0-0x0000000189ACD838
		internal uint ReadRawLittleEndian32(); // 0x0000000189ACD690-0x0000000189ACD6F8
		internal ulong ReadRawLittleEndian64(); // 0x0000000189ACD6F8-0x0000000189ACD760
		internal int PushLimit(int byteLimit); // 0x0000000189ACD190-0x0000000189ACD19C
		internal void PopLimit(int oldLimit); // 0x0000000189ACD180-0x0000000189ACD190
		private bool RefillBuffer(bool mustSucceed); // 0x0000000189ACD940-0x0000000189ACD9BC
		internal byte[] ReadRawBytes(int size); // 0x0000000189ACD61C-0x0000000189ACD690
		public void ReadRawMessage(IMessage message); // 0x0000000183142380-0x0000000183142520
	}

	public sealed class CodedOutputStream : IDisposable // TypeDefIndex: 55761
	{
		// Fields
		private const int LittleEndian64Size = 8; // Metadata: 0x02347648
		private const int LittleEndian32Size = 4; // Metadata: 0x02347649
		internal const int DoubleSize = 8; // Metadata: 0x0234764A
		internal const int FloatSize = 4; // Metadata: 0x0234764B
		internal const int BoolSize = 1; // Metadata: 0x0234764C
		public static readonly int DefaultBufferSize; // 0x00
		private readonly bool leaveOpen; // 0x10
		private readonly byte[] buffer; // 0x18
		private WriterInternalState state; // 0x20
		private readonly Stream output; // 0x38
	
		// Properties
		public long Position { get; } // 0x0000000189ACF430-0x0000000189ACF464 
		public int NonOutputPosition { get; } // 0x00000001811F0020-0x00000001811F0030 
		public int SpaceLeft { get; } // 0x0000000189ACF464-0x0000000189ACF470 
		internal byte[] InternalBuffer { get; } // 0x000000018385B100-0x000000018385B110 
		internal Stream InternalOutputStream { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		internal ref WriterInternalState InternalState { get; } // 0x0000000184D9E550-0x0000000184D9E560 
	
		// Nested types
		public sealed class OutOfSpaceException : IOException // TypeDefIndex: 55760
		{
			// Constructors
			internal OutOfSpaceException(); // 0x0000000189AE0AFC-0x0000000189AE0B40
		}
	
		// Constructors
		public CodedOutputStream(byte[] flatArray); // 0x0000000189ACF204-0x0000000189ACF230
		public CodedOutputStream(byte[] buffer, int offset, int length); // 0x00000001831436C0-0x0000000183143780
		private CodedOutputStream(Stream output, byte[] buffer, bool leaveOpen); // 0x0000000189ACF29C-0x0000000189ACF350
		public CodedOutputStream(Stream output); // 0x0000000189ACF3C8-0x0000000189ACF430
		public CodedOutputStream(Stream output, int bufferSize); // 0x0000000189ACF230-0x0000000189ACF29C
		public CodedOutputStream(Stream output, bool leaveOpen); // 0x0000000189ACF18C-0x0000000189ACF204
		public CodedOutputStream(Stream output, int bufferSize, bool leaveOpen); // 0x0000000189ACF350-0x0000000189ACF3C8
		static CodedOutputStream(); // 0x0000000184D7AB50-0x0000000184D7AB90
	
		// Methods
		public static int ComputeDoubleSize(double value); // 0x0000000184D8D060-0x0000000184D8D070
		public static int ComputeFloatSize(float value); // 0x0000000184D882B0-0x0000000184D882C0
		public static int ComputeUInt64Size(ulong value); // 0x00000001832943D0-0x00000001832944C0
		public static int ComputeInt64Size(long value); // 0x00000001832942E0-0x00000001832943D0
		public static int ComputeInt32Size(int value); // 0x0000000183296190-0x0000000183296220
		public static int ComputeFixed64Size(ulong value); // 0x0000000184D8D060-0x0000000184D8D070
		public static int ComputeFixed32Size(uint value); // 0x0000000184D882B0-0x0000000184D882C0
		public static int ComputeBoolSize(bool value); // 0x0000000184D85B80-0x0000000184D85B90
		public static int ComputeStringSize(string value); // 0x00000001832947A0-0x0000000183294890
		public static int ComputeGroupSize(IMessage value); // 0x0000000189ACDDDC-0x0000000189ACDE28
		public static int ComputeMessageSize(IMessage value); // 0x00000001832960B0-0x0000000183296190
		public static int ComputeBytesSize(ByteString value); // 0x000000018435D040-0x000000018435D0A0
		public static int ComputeUInt32Size(uint value); // 0x0000000183295F90-0x0000000183296010
		public static int ComputeEnumSize(int value); // 0x0000000183296010-0x00000001832960B0
		public static int ComputeSFixed32Size(int value); // 0x0000000184D882B0-0x0000000184D882C0
		public static int ComputeSFixed64Size(long value); // 0x0000000184D8D060-0x0000000184D8D070
		public static int ComputeSInt32Size(int value); // 0x0000000189ACDE28-0x0000000189ACDE88
		public static int ComputeSInt64Size(long value); // 0x0000000189ACDE88-0x0000000189ACDEEC
		public static int ComputeLengthSize(int length); // 0x0000000183295F90-0x0000000183296010
		public static int ComputeRawVarint32Size(uint value); // 0x0000000183296220-0x0000000183296260
		public static int ComputeRawVarint64Size(ulong value); // 0x00000001832944C0-0x0000000183294560
		public static int ComputeTagSize(int fieldNumber); // 0x0000000189ACDEEC-0x0000000189ACDF3C
		public void WriteDouble(double value); // 0x0000000189ACE0D0-0x0000000189ACE154
		public void WriteFloat(float value); // 0x0000000189ACE2D4-0x0000000189ACE358
		public void WriteUInt64(ulong value); // 0x0000000189ACF10C-0x0000000189ACF18C
		public void WriteInt64(long value); // 0x0000000189ACE4EC-0x0000000189ACE56C
		public void WriteInt32(int value); // 0x0000000189ACE46C-0x0000000189ACE4EC
		public void WriteFixed64(ulong value); // 0x0000000189ACE254-0x0000000189ACE2D4
		public void WriteFixed32(uint value); // 0x0000000189ACE1D4-0x0000000189ACE254
		public void WriteBool(bool value); // 0x0000000189ACDFD0-0x0000000189ACE050
		public void WriteString(string value); // 0x0000000189ACEEF8-0x0000000189ACEF78
		public void WriteMessage(IMessage value); // 0x0000000189ACE5EC-0x0000000189ACE700
		public void WriteRawMessage(IMessage value); // 0x0000000183078F90-0x00000001830790F0
		public void WriteGroup(IMessage value); // 0x0000000189ACE358-0x0000000189ACE46C
		public void WriteBytes(ByteString value); // 0x0000000189ACE050-0x0000000189ACE0D0
		public void WriteUInt32(uint value); // 0x0000000189ACF08C-0x0000000189ACF10C
		public void WriteEnum(int value); // 0x0000000189ACE154-0x0000000189ACE1D4
		public void WriteSFixed32(int value); // 0x0000000189ACECF8-0x0000000189ACED78
		public void WriteSFixed64(long value); // 0x0000000189ACED78-0x0000000189ACEDF8
		public void WriteSInt32(int value); // 0x0000000189ACEDF8-0x0000000189ACEE78
		public void WriteSInt64(long value); // 0x0000000189ACEE78-0x0000000189ACEEF8
		public void WriteLength(int length); // 0x0000000189ACE56C-0x0000000189ACE5EC
		public void WriteTag(int fieldNumber, WireFormat.WireType type); // 0x0000000189ACEFF8-0x0000000189ACF08C
		public void WriteTag(uint tag); // 0x0000000189ACEF78-0x0000000189ACEFF8
		public void WriteRawTag(byte b1); // 0x0000000189ACEB78-0x0000000189ACEBF8
		public void WriteRawTag(byte b1, byte b2); // 0x0000000189ACEAE4-0x0000000189ACEB78
		public void WriteRawTag(byte b1, byte b2, byte b3); // 0x0000000189ACE98C-0x0000000189ACEA34
		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4); // 0x0000000189ACEA34-0x0000000189ACEAE4
		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5); // 0x0000000189ACE8D0-0x0000000189ACE98C
		internal void WriteRawVarint32(uint value); // 0x0000000189ACEBF8-0x0000000189ACEC78
		internal void WriteRawVarint64(ulong value); // 0x0000000189ACEC78-0x0000000189ACECF8
		internal void WriteRawLittleEndian32(uint value); // 0x0000000189ACE7D0-0x0000000189ACE850
		internal void WriteRawLittleEndian64(ulong value); // 0x0000000189ACE850-0x0000000189ACE8D0
		internal void WriteRawBytes(byte[] value); // 0x0000000189ACE700-0x0000000189ACE72C
		internal void WriteRawBytes(byte[] value, int offset, int length); // 0x0000000189ACE72C-0x0000000189ACE7D0
		public void Dispose(); // 0x0000000189ACDF3C-0x0000000189ACDF78
		public void Flush(); // 0x0000000189ACDF78-0x0000000189ACDFD0
		public void CheckNoSpaceLeft(); // 0x0000000189ACDDD0-0x0000000189ACDDDC
	}

	public abstract class Extension // TypeDefIndex: 55762
	{
		// Fields
		[CompilerGenerated]
		private readonly int _FieldNumber_k__BackingField; // 0x10
	
		// Properties
		internal abstract System.Type TargetType { get; }
		public int FieldNumber { [CompilerGenerated] get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
		internal abstract bool IsRepeated { get; }
	
		// Constructors
		protected Extension(int fieldNumber); // 0x00000001814F51F0-0x00000001814F5220
	
		// Methods
		internal abstract IExtensionValue CreateValue();
	}

	public sealed class Extension<TTarget, TValue> : Google.Protobuf.Extension // TypeDefIndex: 55763
		where TTarget : IExtendableMessage<TTarget>
	{
		// Fields
		private readonly FieldCodec<TValue> codec;
	
		// Properties
		internal TValue DefaultValue { get; }
		internal override System.Type TargetType { get; }
		internal override bool IsRepeated { get; }
	
		// Constructors
		public Extension(int fieldNumber, FieldCodec<TValue> codec);
	
		// Methods
		internal override IExtensionValue CreateValue();
	}

	public sealed class RepeatedExtension<TTarget, TValue> : Google.Protobuf.Extension // TypeDefIndex: 55764
		where TTarget : IExtendableMessage<TTarget>
	{
		// Fields
		private readonly FieldCodec<TValue> codec;
	
		// Properties
		internal override System.Type TargetType { get; }
		internal override bool IsRepeated { get; }
	
		// Constructors
		public RepeatedExtension(int fieldNumber, FieldCodec<TValue> codec);
	
		// Methods
		internal override IExtensionValue CreateValue();
	}

	public sealed class ExtensionRegistry : ICollection<Google.Protobuf.Extension>, IDeepCloneable<ExtensionRegistry> // TypeDefIndex: 55767
	{
		// Fields
		private IDictionary<ObjectIntPair<System.Type>, Google.Protobuf.Extension> extensions; // 0x10
	
		// Properties
		public int Count { get; } // 0x0000000189ACFFDC-0x0000000189AD0024 
		bool System.Collections.Generic.ICollection<Google.Protobuf.Extension>.IsReadOnly { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Nested types
		internal sealed class ExtensionComparer : IEqualityComparer<Google.Protobuf.Extension> // TypeDefIndex: 55765
		{
			// Fields
			internal static ExtensionComparer Instance; // 0x00
	
			// Constructors
			public ExtensionComparer(); // 0x00000001841E1670-0x00000001841E1680
			static ExtensionComparer(); // 0x0000000189ACF5CC-0x0000000189ACF630
	
			// Methods
			public bool Equals(Google.Protobuf.Extension a, Google.Protobuf.Extension b); // 0x0000000189ACF470-0x0000000189ACF544
			public int GetHashCode(Google.Protobuf.Extension a); // 0x0000000189ACF544-0x0000000189ACF5CC
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55766
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KeyValuePair<ObjectIntPair<System.Type>, Google.Protobuf.Extension>, ObjectIntPair<System.Type>> __9__3_0; // 0x08
			public static Func<KeyValuePair<ObjectIntPair<System.Type>, Google.Protobuf.Extension>, Google.Protobuf.Extension> __9__3_1; // 0x10
	
			// Constructors
			static __c(); // 0x0000000189AE25C4-0x0000000189AE2628
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal ObjectIntPair<System.Type> _.ctor_b__3_0(KeyValuePair<ObjectIntPair<System.Type>, Google.Protobuf.Extension> k); // 0x0000000189AE22A0-0x0000000189AE22E0
			internal Google.Protobuf.Extension _.ctor_b__3_1(KeyValuePair<ObjectIntPair<System.Type>, Google.Protobuf.Extension> v); // 0x0000000189AE22E0-0x0000000189AE2318
		}
	
		// Constructors
		public ExtensionRegistry(); // 0x0000000189ACFD8C-0x0000000189ACFE04
		private ExtensionRegistry(IDictionary<ObjectIntPair<System.Type>, Google.Protobuf.Extension> collection); // 0x0000000189ACFE04-0x0000000189ACFFDC
	
		// Methods
		internal bool ContainsInputField(uint lastTag, System.Type target, out Google.Protobuf.Extension extension); // 0x0000000189ACF900-0x0000000189ACF9A4
		public void Add(Google.Protobuf.Extension extension); // 0x0000000189ACF784-0x0000000189ACF850
		public void AddRange(IEnumerable<Google.Protobuf.Extension> extensions); // 0x0000000189ACF630-0x0000000189ACF784
		public void Clear(); // 0x0000000189ACF850-0x0000000189ACF89C
		public bool Contains(Google.Protobuf.Extension item); // 0x0000000189ACF9A4-0x0000000189ACFA70
		void ICollection<Extension>.CopyTo(Google.Protobuf.Extension[] array, int arrayIndex); // 0x0000000189ACFBA8-0x0000000189ACFD84
		public IEnumerator<Google.Protobuf.Extension> GetEnumerator(); // 0x0000000189ACFA70-0x0000000189ACFADC
		public bool Remove(Google.Protobuf.Extension item); // 0x0000000189ACFADC-0x0000000189ACFBA8
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000189ACFD84-0x0000000189ACFD8C
		public ExtensionRegistry Clone(); // 0x0000000189ACF89C-0x0000000189ACF900
	}

	public static class ExtensionSet // TypeDefIndex: 55768
	{
		// Methods
		private static bool TryGetValue<TTarget>(ref ExtensionSet<TTarget> set, Google.Protobuf.Extension extension, out IExtensionValue value)
			where TTarget : IExtendableMessage<TTarget>;
		public static TValue Get<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension)
			where TTarget : IExtendableMessage<TTarget>;
		public static RepeatedField<TValue> Get<TTarget, TValue>(ref ExtensionSet<TTarget> set, RepeatedExtension<TTarget, TValue> extension)
			where TTarget : IExtendableMessage<TTarget>;
		public static RepeatedField<TValue> GetOrInitialize<TTarget, TValue>(ref ExtensionSet<TTarget> set, RepeatedExtension<TTarget, TValue> extension)
			where TTarget : IExtendableMessage<TTarget>;
		public static void Set<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension, TValue value)
			where TTarget : IExtendableMessage<TTarget>;
		public static bool Has<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension)
			where TTarget : IExtendableMessage<TTarget>;
		public static void Clear<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension)
			where TTarget : IExtendableMessage<TTarget>;
		public static void Clear<TTarget, TValue>(ref ExtensionSet<TTarget> set, RepeatedExtension<TTarget, TValue> extension)
			where TTarget : IExtendableMessage<TTarget>;
		public static bool TryMergeFieldFrom<TTarget>(ref ExtensionSet<TTarget> set, CodedInputStream stream)
			where TTarget : IExtendableMessage<TTarget>;
		public static bool TryMergeFieldFrom<TTarget>(ref ExtensionSet<TTarget> set, ref ParseContext ctx)
			where TTarget : IExtendableMessage<TTarget>;
		public static void MergeFrom<TTarget>(ref ExtensionSet<TTarget> first, ExtensionSet<TTarget> second)
			where TTarget : IExtendableMessage<TTarget>;
		public static ExtensionSet<TTarget> Clone<TTarget>(ExtensionSet<TTarget> set)
			where TTarget : IExtendableMessage<TTarget>;
	}

	public sealed class ExtensionSet<TTarget> // TypeDefIndex: 55770
		where TTarget : IExtendableMessage<TTarget>
	{
		// Fields
		[CompilerGenerated]
		private readonly Dictionary<int, IExtensionValue> _ValuesByNumber_k__BackingField;
	
		// Properties
		internal Dictionary<int, IExtensionValue> ValuesByNumber { [CompilerGenerated] get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55769
		{
			// Fields
			public static readonly __c<TTarget> __9;
			public static Func<IExtensionValue, bool> __9__8_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _IsInitialized_b__8_0(IExtensionValue v);
		}
	
		// Constructors
		public ExtensionSet();
	
		// Methods
		public override int GetHashCode();
		public override bool Equals(object other);
		public int CalculateSize();
		public void WriteTo(CodedOutputStream stream);
		public void WriteTo(ref WriteContext ctx);
		internal bool IsInitialized();
	}

	internal interface IExtensionValue : IEquatable<IExtensionValue>, IDeepCloneable<IExtensionValue> // TypeDefIndex: 55771
	{
		// Methods
		void MergeFrom(ref ParseContext ctx);
		void MergeFrom(IExtensionValue value);
		void WriteTo(ref WriteContext ctx);
		int CalculateSize();
		bool IsInitialized();
		object GetValue();
	}

	internal sealed class ExtensionValue<T> : IExtensionValue // TypeDefIndex: 55772
	{
		// Fields
		private T field;
		private FieldCodec<T> codec;
	
		// Constructors
		internal ExtensionValue(FieldCodec<T> codec);
	
		// Methods
		public int CalculateSize();
		public IExtensionValue Clone();
		public bool Equals(IExtensionValue other);
		public override int GetHashCode();
		public void MergeFrom(ref ParseContext ctx);
		public void MergeFrom(IExtensionValue value);
		public void WriteTo(ref WriteContext ctx);
		public T GetValue();
		object IExtensionValue.GetValue();
		public void SetValue(T value);
		public bool IsInitialized();
	}

	internal sealed class RepeatedExtensionValue<T> : IExtensionValue // TypeDefIndex: 55773
	{
		// Fields
		private RepeatedField<T> field;
		private readonly FieldCodec<T> codec;
	
		// Constructors
		internal RepeatedExtensionValue(FieldCodec<T> codec);
	
		// Methods
		public int CalculateSize();
		public IExtensionValue Clone();
		public bool Equals(IExtensionValue other);
		public override int GetHashCode();
		public void MergeFrom(ref ParseContext ctx);
		public void MergeFrom(IExtensionValue value);
		public void WriteTo(ref WriteContext ctx);
		public RepeatedField<T> GetValue();
		object IExtensionValue.GetValue();
		public bool IsInitialized();
	}

	public static class FieldCodec // TypeDefIndex: 55786
	{
		// Nested types
		private static class WrapperCodecs // TypeDefIndex: 55775
		{
			// Fields
			private static readonly Dictionary<System.Type, object> Codecs; // 0x00
			private static readonly Dictionary<System.Type, object> Readers; // 0x08
	
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass3_0<T> // TypeDefIndex: 55774
				where T : struct
			{
				// Fields
				public FieldCodec<T> nestedCoded;
	
				// Constructors
				public __c__DisplayClass3_0();
	
				// Methods
				internal T? _GetReader_b__0(ref ParseContext ctx);
			}
	
			// Constructors
			static WrapperCodecs(); // 0x0000000189AE268C-0x0000000189AE30E0
	
			// Methods
			internal static FieldCodec<T> GetCodec<T>();
			internal static ValueReader<T?> GetReader<T>()
				where T : struct;
			internal static T Read<T>(ref ParseContext ctx, FieldCodec<T> codec);
			internal static void Write<T>(ref WriteContext ctx, T value, FieldCodec<T> codec);
			internal static int CalculateSize<T>(T value, FieldCodec<T> codec);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55776
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
			static __c(); // 0x0000000184D43B10-0x0000000184D43B70
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _ForString_b__16_0(ref ParseContext ctx); // 0x0000000183537440-0x0000000183537530
			internal void _ForString_b__16_1(ref WriteContext ctx, string value); // 0x0000000184693A60-0x0000000184693A80
			internal ByteString _ForBytes_b__17_0(ref ParseContext ctx); // 0x0000000189AE1D50-0x0000000189AE1D5C
			internal void _ForBytes_b__17_1(ref WriteContext ctx, ByteString value); // 0x0000000189AE1D5C-0x0000000189AE1D70
			internal bool _ForBool_b__18_0(ref ParseContext ctx); // 0x00000001835369C0-0x00000001835369D0
			internal void _ForBool_b__18_1(ref WriteContext ctx, bool value); // 0x0000000183076EF0-0x0000000183076F10
			internal int _ForInt32_b__19_0(ref ParseContext ctx); // 0x0000000183537920-0x0000000183537930
			internal void _ForInt32_b__19_1(ref WriteContext output, int value); // 0x0000000189AE1DF4-0x0000000189AE1E04
			internal int _ForSInt32_b__20_0(ref ParseContext ctx); // 0x0000000189AE1E28-0x0000000189AE1E4C
			internal void _ForSInt32_b__20_1(ref WriteContext output, int value); // 0x0000000189AE1E4C-0x0000000189AE1E5C
			internal uint _ForFixed32_b__21_0(ref ParseContext ctx); // 0x0000000189AE1D90-0x0000000189AE1DA0
			internal void _ForFixed32_b__21_1(ref WriteContext output, uint value); // 0x0000000189AE1DA0-0x0000000189AE1DB0
			internal int _ForSFixed32_b__22_0(ref ParseContext ctx); // 0x0000000189AE1D90-0x0000000189AE1DA0
			internal void _ForSFixed32_b__22_1(ref WriteContext output, int value); // 0x0000000189AE1E04-0x0000000189AE1E14
			internal uint _ForUInt32_b__23_0(ref ParseContext ctx); // 0x0000000183539A40-0x0000000183539A50
			internal void _ForUInt32_b__23_1(ref WriteContext output, uint value); // 0x0000000189AE1E98-0x0000000189AE1EA8
			internal long _ForInt64_b__24_0(ref ParseContext ctx); // 0x00000001835371A0-0x00000001835372C0
			internal void _ForInt64_b__24_1(ref WriteContext output, long value); // 0x0000000184B3A6F0-0x0000000184B3A710
			internal long _ForSInt64_b__25_0(ref ParseContext ctx); // 0x0000000189AE1E5C-0x0000000189AE1E84
			internal void _ForSInt64_b__25_1(ref WriteContext output, long value); // 0x0000000189AE1E84-0x0000000189AE1E98
			internal ulong _ForFixed64_b__26_0(ref ParseContext ctx); // 0x0000000189AE1DB0-0x0000000189AE1DC0
			internal void _ForFixed64_b__26_1(ref WriteContext output, ulong value); // 0x0000000189AE1DC0-0x0000000189AE1DD4
			internal long _ForSFixed64_b__27_0(ref ParseContext ctx); // 0x0000000189AE1DB0-0x0000000189AE1DC0
			internal void _ForSFixed64_b__27_1(ref WriteContext output, long value); // 0x0000000189AE1E14-0x0000000189AE1E28
			internal ulong _ForUInt64_b__28_0(ref ParseContext ctx); // 0x000000018353B690-0x000000018353B6A0
			internal void _ForUInt64_b__28_1(ref WriteContext output, ulong value); // 0x000000018484C110-0x000000018484C130
			internal float _ForFloat_b__29_0(ref ParseContext ctx); // 0x0000000189AE1DD4-0x0000000189AE1DE4
			internal void _ForFloat_b__29_1(ref WriteContext output, float value); // 0x0000000189AE1DE4-0x0000000189AE1DF4
			internal double _ForDouble_b__30_0(ref ParseContext ctx); // 0x0000000189AE1D70-0x0000000189AE1D80
			internal void _ForDouble_b__30_1(ref WriteContext output, double value); // 0x0000000189AE1D80-0x0000000189AE1D90
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0<T> // TypeDefIndex: 55777
		{
			// Fields
			public Func<int, T> fromInt32;
			public Func<T, int> toInt32;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal T _ForEnum_b__0(ref ParseContext ctx);
			internal void _ForEnum_b__1(ref WriteContext output, T value);
			internal int _ForEnum_b__2(T value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0<T> // TypeDefIndex: 55778
			where T : class, IMessage<T>
		{
			// Fields
			public MessageParser<T> parser;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal T _ForMessage_b__0(ref ParseContext ctx);
			internal void _ForMessage_b__2(ref ParseContext ctx, ref ref T v);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__32<T> // TypeDefIndex: 55779
			where T : class, IMessage<T>
		{
			// Fields
			public static readonly __c__32<T> __9;
			public static ValueWriter<T> __9__32_1;
			public static FieldCodec<T> __9__32_3;
			public static Func<T, int> __9__32_4;
	
			// Constructors
			static __c__32();
			public __c__32();
	
			// Methods
			internal void _ForMessage_b__32_1(ref WriteContext output, T value);
			internal bool _ForMessage_b__32_3(ref ref T v, T v2);
			internal int _ForMessage_b__32_4(T message);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0<T> // TypeDefIndex: 55780
			where T : class, IMessage<T>
		{
			// Fields
			public MessageParser<T> parser;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal T _ForGroup_b__0(ref ParseContext ctx);
			internal void _ForGroup_b__2(ref ParseContext ctx, ref ref T v);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__33<T> // TypeDefIndex: 55781
			where T : class, IMessage<T>
		{
			// Fields
			public static readonly __c__33<T> __9;
			public static ValueWriter<T> __9__33_1;
			public static FieldCodec<T> __9__33_3;
			public static Func<T, int> __9__33_4;
	
			// Constructors
			static __c__33();
			public __c__33();
	
			// Methods
			internal void _ForGroup_b__33_1(ref WriteContext output, T value);
			internal bool _ForGroup_b__33_3(ref ref T v, T v2);
			internal int _ForGroup_b__33_4(T message);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0<T> // TypeDefIndex: 55782
			where T : class
		{
			// Fields
			public FieldCodec<T> nestedCodec;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal T _ForClassWrapper_b__0(ref ParseContext ctx);
			internal void _ForClassWrapper_b__1(ref WriteContext output, T value);
			internal void _ForClassWrapper_b__2(ref ParseContext ctx, ref ref T v);
			internal int _ForClassWrapper_b__4(T value);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__34<T> // TypeDefIndex: 55783
			where T : class
		{
			// Fields
			public static readonly __c__34<T> __9;
			public static FieldCodec<T> __9__34_3;
	
			// Constructors
			static __c__34();
			public __c__34();
	
			// Methods
			internal bool _ForClassWrapper_b__34_3(ref ref T v, T v2);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0<T> // TypeDefIndex: 55784
			where T : struct
		{
			// Fields
			public FieldCodec<T> nestedCodec;
	
			// Constructors
			public __c__DisplayClass35_0();
	
			// Methods
			internal void _ForStructWrapper_b__0(ref WriteContext output, T? value);
			internal void _ForStructWrapper_b__1(ref ParseContext ctx, ref T? v);
			internal int _ForStructWrapper_b__3(T? value);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__35<T> // TypeDefIndex: 55785
			where T : struct
		{
			// Fields
			public static readonly __c__35<T> __9;
			public static FieldCodec<T?> __9__35_2;
	
			// Constructors
			static __c__35();
			public __c__35();
	
			// Methods
			internal bool _ForStructWrapper_b__35_2(ref T? v, T? v2);
		}
	
		// Methods
		public static FieldCodec<string> ForString(uint tag); // 0x0000000184109440-0x0000000184109480
		public static FieldCodec<ByteString> ForBytes(uint tag); // 0x0000000189AD0024-0x0000000189AD0074
		public static FieldCodec<bool> ForBool(uint tag); // 0x0000000185396FD4-0x0000000185396FE0
		public static FieldCodec<int> ForInt32(uint tag); // 0x0000000185396FBC-0x0000000185396FC8
		public static FieldCodec<int> ForSInt32(uint tag); // 0x0000000189AD0B1C-0x0000000189AD0B28
		public static FieldCodec<uint> ForFixed32(uint tag); // 0x0000000189AD0278-0x0000000189AD0284
		public static FieldCodec<int> ForSFixed32(uint tag); // 0x0000000189AD06AC-0x0000000189AD06B8
		public static FieldCodec<uint> ForUInt32(uint tag); // 0x0000000185396FB0-0x0000000185396FBC
		public static FieldCodec<long> ForInt64(uint tag); // 0x0000000185396FE0-0x0000000185396FEC
		public static FieldCodec<long> ForSInt64(uint tag); // 0x0000000189AD0D78-0x0000000189AD0D84
		public static FieldCodec<ulong> ForFixed64(uint tag); // 0x0000000189AD0284-0x0000000189AD0290
		public static FieldCodec<long> ForSFixed64(uint tag); // 0x0000000189AD08D0-0x0000000189AD08DC
		public static FieldCodec<ulong> ForUInt64(uint tag); // 0x000000018539778C-0x0000000185397798
		public static FieldCodec<float> ForFloat(uint tag); // 0x0000000185396FC8-0x0000000185396FD4
		public static FieldCodec<double> ForDouble(uint tag); // 0x0000000185398044-0x0000000185398050
		public static FieldCodec<T> ForEnum<T>(uint tag, Func<T, int> toInt32, Func<int, T> fromInt32);
		public static FieldCodec<string> ForString(uint tag, string defaultValue); // 0x0000000184109480-0x00000001841096A0
		public static FieldCodec<ByteString> ForBytes(uint tag, ByteString defaultValue); // 0x0000000183218910-0x0000000183218B90
		public static FieldCodec<bool> ForBool(uint tag, bool defaultValue); // 0x000000018410C790-0x000000018410C9F0
		public static FieldCodec<int> ForInt32(uint tag, int defaultValue); // 0x000000018410B330-0x000000018410B5D0
		public static FieldCodec<int> ForSInt32(uint tag, int defaultValue); // 0x0000000189AD08DC-0x0000000189AD0B1C
		public static FieldCodec<uint> ForFixed32(uint tag, uint defaultValue); // 0x0000000189AD0074-0x0000000189AD0278
		public static FieldCodec<int> ForSFixed32(uint tag, int defaultValue); // 0x0000000189AD04A8-0x0000000189AD06AC
		public static FieldCodec<uint> ForUInt32(uint tag, uint defaultValue); // 0x0000000184110D00-0x0000000184110FA0
		public static FieldCodec<long> ForInt64(uint tag, long defaultValue); // 0x000000018410D000-0x000000018410D300
		public static FieldCodec<long> ForSInt64(uint tag, long defaultValue); // 0x0000000189AD0B28-0x0000000189AD0D78
		public static FieldCodec<ulong> ForFixed64(uint tag, ulong defaultValue); // 0x0000000189AD0290-0x0000000189AD04A8
		public static FieldCodec<long> ForSFixed64(uint tag, long defaultValue); // 0x0000000189AD06B8-0x0000000189AD08D0
		public static FieldCodec<ulong> ForUInt64(uint tag, ulong defaultValue); // 0x00000001844A0EC0-0x00000001844A1170
		public static FieldCodec<float> ForFloat(uint tag, float defaultValue); // 0x00000001849E43F0-0x00000001849E4630
		public static FieldCodec<double> ForDouble(uint tag, double defaultValue); // 0x00000001849E4630-0x00000001849E4870
		public static FieldCodec<T> ForEnum<T>(uint tag, Func<T, int> toInt32, Func<int, T> fromInt32, T defaultValue);
		public static FieldCodec<T> ForMessage<T>(uint tag, MessageParser<T> parser)
			where T : class, IMessage<T>;
		public static FieldCodec<T> ForGroup<T>(uint startTag, uint endTag, MessageParser<T> parser)
			where T : class, IMessage<T>;
		public static FieldCodec<T> ForClassWrapper<T>(uint tag)
			where T : class;
		public static FieldCodec<T?> ForStructWrapper<T>(uint tag)
			where T : struct;
	}

	internal delegate TValue ValueReader<out TValue>(ref ParseContext ctx); // TypeDefIndex: 55787; 0x00000000-0x00000000

	internal delegate void ValueWriter<T>(ref WriteContext ctx, T value); // TypeDefIndex: 55788; 0x00000000-0x00000000

	public sealed class FieldCodec<T> // TypeDefIndex: 55794
	{
		// Fields
		private static readonly EqualityComparer<T> EqualityComparer;
		private static readonly T DefaultDefault;
		private static readonly bool TypeSupportsPacking;
		[CompilerGenerated]
		private readonly bool _PackedRepeatedField_k__BackingField;
		[CompilerGenerated]
		private readonly ValueWriter<T> _ValueWriter_k__BackingField;
		[CompilerGenerated]
		private readonly Func<T, int> _ValueSizeCalculator_k__BackingField;
		[CompilerGenerated]
		private readonly ValueReader<T> _ValueReader_k__BackingField;
		[CompilerGenerated]
		private readonly InputMerger _ValueMerger_k__BackingField;
		[CompilerGenerated]
		private readonly ValuesMerger _FieldMerger_k__BackingField;
		[CompilerGenerated]
		private readonly int _FixedSize_k__BackingField;
		[CompilerGenerated]
		private readonly uint _Tag_k__BackingField;
		[CompilerGenerated]
		private readonly uint _EndTag_k__BackingField;
		[CompilerGenerated]
		private readonly T _DefaultValue_k__BackingField;
		private readonly int tagSize;
	
		// Properties
		internal bool PackedRepeatedField { [CompilerGenerated] get; }
		internal ValueWriter<T> ValueWriter { [CompilerGenerated] get; }
		internal Func<T, int> ValueSizeCalculator { [CompilerGenerated] get; }
		internal ValueReader<T> ValueReader { [CompilerGenerated] get; }
		internal InputMerger ValueMerger { [CompilerGenerated] get; }
		internal ValuesMerger FieldMerger { [CompilerGenerated] get; }
		internal int FixedSize { [CompilerGenerated] get; }
		internal uint Tag { [CompilerGenerated] get; }
		internal uint EndTag { [CompilerGenerated] get; }
		internal T DefaultValue { [CompilerGenerated] get; }
	
		// Nested types
		internal delegate void InputMerger(ref ParseContext ctx, ref ref T value); // TypeDefIndex: 55789; 0x00000000-0x00000000
	
		internal delegate bool ValuesMerger(ref ref T value, T other); // TypeDefIndex: 55790; 0x00000000-0x00000000
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0 // TypeDefIndex: 55791
		{
			// Fields
			public int fixedSize;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal int _.ctor_b__0(T _);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0 // TypeDefIndex: 55792
		{
			// Fields
			public ValueReader<T> reader;
	
			// Constructors
			public __c__DisplayClass39_0();
	
			// Methods
			internal void _.ctor_b__0(ref ParseContext ctx, ref ref T v);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55793
		{
			// Fields
			public static readonly __c<T> __9;
			public static ValuesMerger<T> __9__39_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _.ctor_b__39_1(ref ref T v, T v2);
		}
	
		// Constructors
		static FieldCodec();
		internal FieldCodec(ValueReader<T> reader, ValueWriter<T> writer, int fixedSize, uint tag, T defaultValue);
		internal FieldCodec(ValueReader<T> reader, ValueWriter<T> writer, Func<T, int> sizeCalculator, uint tag, T defaultValue);
		internal FieldCodec(ValueReader<T> reader, ValueWriter<T> writer, InputMerger inputMerger, ValuesMerger valuesMerger, Func<T, int> sizeCalculator, uint tag, uint endTag = 0 /* Metadata: 0x0234764D */);
		internal FieldCodec(ValueReader<T> reader, ValueWriter<T> writer, InputMerger inputMerger, ValuesMerger valuesMerger, Func<T, int> sizeCalculator, uint tag, uint endTag, T defaultValue);
	
		// Methods
		internal static bool IsPackedRepeatedField(uint tag);
		public void WriteTagAndValue(CodedOutputStream output, T value);
		public void WriteTagAndValue(ref WriteContext ctx, T value);
		public T Read(CodedInputStream input);
		public T Read(ref ParseContext ctx);
		public int CalculateSizeWithTag(T value);
		internal int CalculateUnconditionalSizeWithTag(T value);
		private bool IsDefault(T value);
	}

	internal sealed class FieldMaskTree // TypeDefIndex: 55796
	{
		// Fields
		private const char FIELD_PATH_SEPARATOR = '.'; // Metadata: 0x0234764E
		private readonly Node root; // 0x10
	
		// Nested types
		internal sealed class Node // TypeDefIndex: 55795
		{
			// Fields
			[CompilerGenerated]
			private readonly Dictionary<string, Node> _Children_k__BackingField; // 0x10
	
			// Properties
			public Dictionary<string, Node> Children { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
			// Constructors
			public Node(); // 0x0000000189AE0498-0x0000000189AE0510
		}
	
		// Constructors
		public FieldMaskTree(); // 0x0000000189AD20E0-0x0000000189AD2144
		public FieldMaskTree(FieldMask mask); // 0x0000000189AD2144-0x0000000189AD21C4
	
		// Methods
		public override string ToString(); // 0x0000000189AD20B8-0x0000000189AD20E0
		public FieldMaskTree AddFieldPath(string path); // 0x0000000189AD0D84-0x0000000189AD0F30
		public FieldMaskTree MergeFromFieldMask(FieldMask mask); // 0x0000000189AD1454-0x0000000189AD15A0
		public FieldMask ToFieldMask(); // 0x0000000189AD1FA0-0x0000000189AD20B8
		private void GetFieldPaths(Node node, string path, List<string> paths); // 0x0000000189AD0F30-0x0000000189AD114C
		public void IntersectFieldPath(string path, FieldMaskTree output); // 0x0000000189AD114C-0x0000000189AD1454
		public void Merge(IMessage source, IMessage destination, FieldMask.MergeOptions options); // 0x0000000189AD15A0-0x0000000189AD16F4
		private void Merge(Node node, string path, IMessage source, IMessage destination, FieldMask.MergeOptions options); // 0x0000000189AD16F4-0x0000000189AD1FA0
	}

	internal static class FrameworkPortability // TypeDefIndex: 55797
	{
		// Fields
		internal static readonly RegexOptions CompiledRegexWhereAvailable; // 0x00
	
		// Constructors
		static FrameworkPortability(); // 0x0000000189AD21C4-0x0000000189AD2294
	}

	public interface IBufferMessage : IMessage // TypeDefIndex: 55798
	{
		// Methods
		void InternalMergeFrom(ref ParseContext ctx);
		void InternalWriteTo(ref WriteContext ctx);
	}

	public interface ICustomDiagnosticMessage : IMessage // TypeDefIndex: 55799
	{
		// Methods
		string ToDiagnosticString();
	}

	public interface IDeepCloneable<T> // TypeDefIndex: 55800
	{
		// Methods
		T Clone();
	}

	public interface IExtendableMessage<T> : IMessage<T> // TypeDefIndex: 55801
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

	public interface IMessage // TypeDefIndex: 55802
	{
		// Properties
		MessageDescriptor Descriptor { get; }
	
		// Methods
		void MergeFrom(CodedInputStream input);
		void WriteTo(CodedOutputStream output);
		int CalculateSize();
	}

	public interface IMessage<T> : IMessage, IEquatable<T>, IDeepCloneable<T> // TypeDefIndex: 55803
		where T : IMessage<T>
	{
		// Methods
		void MergeFrom(T message);
	}

	public sealed class InvalidJsonException : IOException // TypeDefIndex: 55804
	{
		// Constructors
		internal InvalidJsonException(string message); // 0x0000000189AD2294-0x0000000189AD22B4
	}

	public sealed class InvalidProtocolBufferException : IOException // TypeDefIndex: 55805
	{
		// Constructors
		internal InvalidProtocolBufferException(string message); // 0x0000000189AD2294-0x0000000189AD22B4
		internal InvalidProtocolBufferException(string message, Exception innerException); // 0x0000000189AD27D8-0x0000000189AD27E0
	
		// Methods
		internal static InvalidProtocolBufferException MoreDataAvailable(); // 0x0000000189AD25E4-0x0000000189AD2648
		internal static InvalidProtocolBufferException TruncatedMessage(); // 0x0000000189AD2774-0x0000000189AD27D8
		internal static InvalidProtocolBufferException NegativeSize(); // 0x0000000189AD2648-0x0000000189AD26AC
		internal static InvalidProtocolBufferException MalformedVarint(); // 0x0000000189AD251C-0x0000000189AD2580
		internal static InvalidProtocolBufferException InvalidTag(); // 0x0000000189AD23F0-0x0000000189AD2454
		internal static InvalidProtocolBufferException InvalidWireType(); // 0x0000000189AD2454-0x0000000189AD24B8
		internal static InvalidProtocolBufferException InvalidBase64(Exception innerException); // 0x0000000189AD22B4-0x0000000189AD2328
		internal static InvalidProtocolBufferException InvalidEndTag(); // 0x0000000189AD2328-0x0000000189AD238C
		internal static InvalidProtocolBufferException RecursionLimitExceeded(); // 0x0000000189AD26AC-0x0000000189AD2710
		internal static InvalidProtocolBufferException JsonRecursionLimitExceeded(); // 0x0000000189AD24B8-0x0000000189AD251C
		internal static InvalidProtocolBufferException SizeLimitExceeded(); // 0x0000000189AD2710-0x0000000189AD2774
		internal static InvalidProtocolBufferException InvalidMessageStreamTag(); // 0x0000000189AD238C-0x0000000189AD23F0
		internal static InvalidProtocolBufferException MissingFields(); // 0x0000000189AD2580-0x0000000189AD25E4
	}

	public sealed class JsonFormatter // TypeDefIndex: 55809
	{
		// Fields
		internal const string AnyTypeUrlField = "@type"; // Metadata: 0x02347650
		internal const string AnyDiagnosticValueField = "@value"; // Metadata: 0x02347656
		internal const string AnyWellKnownTypeValueField = "value"; // Metadata: 0x0234765D
		private const string TypeUrlPrefix = "type.googleapis.com"; // Metadata: 0x02347663
		private const string NameValueSeparator = ": "; // Metadata: 0x02347677
		private const string PropertySeparator = ", "; // Metadata: 0x0234767A
		[CompilerGenerated]
		private static readonly JsonFormatter _Default_k__BackingField; // 0x00
		private static readonly JsonFormatter diagnosticFormatter; // 0x08
		private static readonly string[] CommonRepresentations; // 0x10
		private readonly Settings settings; // 0x10
		private const string Hex = "0123456789abcdef"; // Metadata: 0x0234767D
	
		// Properties
		public static JsonFormatter Default { [CompilerGenerated] get; } // 0x0000000189AD79B4-0x0000000189AD7A04 
		private bool DiagnosticOnly { get; } // 0x0000000189AD7A04-0x0000000189AD7A50 
	
		// Nested types
		public sealed class Settings // TypeDefIndex: 55806
		{
			// Fields
			[CompilerGenerated]
			private static readonly Settings _Default_k__BackingField; // 0x00
			[CompilerGenerated]
			private readonly bool _FormatDefaultValues_k__BackingField; // 0x10
			[CompilerGenerated]
			private readonly TypeRegistry _TypeRegistry_k__BackingField; // 0x18
			[CompilerGenerated]
			private readonly bool _FormatEnumsAsIntegers_k__BackingField; // 0x20
			[CompilerGenerated]
			private readonly bool _PreserveProtoFieldNames_k__BackingField; // 0x21
	
			// Properties
			public static Settings Default { [CompilerGenerated] get; } // 0x0000000189AE18E4-0x0000000189AE1934 
			public bool FormatDefaultValues { [CompilerGenerated] get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
			public TypeRegistry TypeRegistry { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
			public bool FormatEnumsAsIntegers { [CompilerGenerated] get; } // 0x0000000184D866B0-0x0000000184D866C0 
			public bool PreserveProtoFieldNames { [CompilerGenerated] get; } // 0x0000000184D86850-0x0000000184D86860 
	
			// Constructors
			static Settings(); // 0x0000000189AE1600-0x0000000189AE1674
			public Settings(bool formatDefaultValues); // 0x0000000189AE16E8-0x0000000189AE1740
			public Settings(bool formatDefaultValues, TypeRegistry typeRegistry); // 0x0000000189AE17B4-0x0000000189AE17D4
			private Settings(bool formatDefaultValues, TypeRegistry typeRegistry, bool formatEnumsAsIntegers, bool preserveProtoFieldNames); // 0x0000000189AE17D4-0x0000000189AE185C
	
			// Methods
			public Settings WithFormatDefaultValues(bool formatDefaultValues); // 0x0000000189AE11C8-0x0000000189AE1264
			public Settings WithTypeRegistry(TypeRegistry typeRegistry); // 0x0000000189AE14AC-0x0000000189AE1548
			public Settings WithFormatEnumsAsIntegers(bool formatEnumsAsIntegers); // 0x0000000189AE1264-0x0000000189AE1300
			public Settings WithPreserveProtoFieldNames(bool preserveProtoFieldNames); // 0x0000000189AE1388-0x0000000189AE1424
		}
	
		private static class OriginalEnumValueHelper // TypeDefIndex: 55808
		{
			// Fields
			private static readonly Dictionary<System.Type, Dictionary<object, string>> dictionaries; // 0x00
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 55807
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Func<System.Reflection.FieldInfo, bool> __9__2_0; // 0x08
				public static Func<System.Reflection.FieldInfo, bool> __9__2_1; // 0x10
				public static Func<System.Reflection.FieldInfo, object> __9__2_2; // 0x18
				public static Func<System.Reflection.FieldInfo, string> __9__2_3; // 0x20
	
				// Constructors
				static __c(); // 0x0000000189AE2628-0x0000000189AE268C
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal bool _GetNameMapping_b__2_0(System.Reflection.FieldInfo f); // 0x0000000189AE1EA8-0x0000000189AE1EC8
				internal bool _GetNameMapping_b__2_1(System.Reflection.FieldInfo f); // 0x0000000189AE1EC8-0x0000000189AE1F2C
				internal object _GetNameMapping_b__2_2(System.Reflection.FieldInfo f); // 0x0000000189AE1F2C-0x0000000189AE1F4C
				internal string _GetNameMapping_b__2_3(System.Reflection.FieldInfo f); // 0x0000000189AE1F4C-0x0000000189AE1FC8
			}
	
			// Constructors
			static OriginalEnumValueHelper(); // 0x0000000189AE0A70-0x0000000189AE0AFC
	
			// Methods
			[UnconditionalSuppressMessage("Trimming", "IL2072", Justification = "The field for the value must still be present. It will be returned by reflection, will be in this collection, and its name can be resolved.")]
			internal static string GetOriginalName(object value); // 0x0000000189AE086C-0x0000000189AE0A70
			private static Dictionary<object, string> GetNameMapping([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields)] System.Type enumType); // 0x0000000189AE0510-0x0000000189AE086C
		}
	
		// Constructors
		static JsonFormatter(); // 0x0000000189AD67A4-0x0000000189AD794C
		public JsonFormatter(Settings settings); // 0x0000000189AD794C-0x0000000189AD79B4
	
		// Methods
		public string Format(IMessage message); // 0x0000000189AD27E0-0x0000000189AD2864
		public void Format(IMessage message, TextWriter writer); // 0x0000000189AD2864-0x0000000189AD2974
		public static string ToDiagnosticString(IMessage message); // 0x0000000189AD2F8C-0x0000000189AD3018
		private void WriteMessage(TextWriter writer, IMessage message); // 0x0000000189AD4FD4-0x0000000189AD5140
		private bool WriteMessageFields(TextWriter writer, IMessage message, bool assumeFirstFieldWritten); // 0x0000000189AD4CB0-0x0000000189AD4FD4
		private bool ShouldFormatFieldValue(IMessage message, FieldDescriptor field, object value); // 0x0000000189AD2EE0-0x0000000189AD2F8C
		internal static string ToJsonName(string name); // 0x0000000189AD3018-0x0000000189AD3124
		internal static string FromJsonName(string name); // 0x0000000189AD2974-0x0000000189AD2A78
		private static void WriteNull(TextWriter writer); // 0x0000000189AD5140-0x0000000189AD518C
		private static bool IsDefaultValue(FieldDescriptor descriptor, object value); // 0x0000000189AD2B94-0x0000000189AD2EE0
		public void WriteValue(TextWriter writer, object value); // 0x0000000189AD5CEC-0x0000000189AD6334
		private void WriteWellKnownTypeValue(TextWriter writer, MessageDescriptor descriptor, object value); // 0x0000000189AD6334-0x0000000189AD67A4
		private void WriteTimestamp(TextWriter writer, IMessage value); // 0x0000000189AD5B60-0x0000000189AD5CEC
		private void WriteDuration(TextWriter writer, IMessage value); // 0x0000000189AD47D4-0x0000000189AD4960
		private void WriteFieldMask(TextWriter writer, IMessage value); // 0x0000000189AD4960-0x0000000189AD4A6C
		private void WriteAny(TextWriter writer, IMessage value); // 0x0000000189AD3124-0x0000000189AD34E0
		private void WriteDiagnosticOnlyAny(TextWriter writer, IMessage value); // 0x0000000189AD34E0-0x0000000189AD376C
		private void WriteStruct(TextWriter writer, IMessage message); // 0x0000000189AD5730-0x0000000189AD5B60
		private void WriteStructFieldValue(TextWriter writer, IMessage message); // 0x0000000189AD54B0-0x0000000189AD5730
		internal void WriteList(TextWriter writer, IList list); // 0x0000000189AD4A6C-0x0000000189AD4CB0
		internal void WriteDictionary(TextWriter writer, IDictionary dictionary); // 0x0000000189AD376C-0x0000000189AD47D4
		internal static void WriteString(TextWriter writer, string text); // 0x0000000189AD518C-0x0000000189AD54B0
		private static void HexEncodeUtf16CodeUnit(TextWriter writer, char c); // 0x0000000189AD2A78-0x0000000189AD2B94
	}

	public sealed class JsonParser // TypeDefIndex: 55812
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
		public static JsonParser Default { get; } // 0x0000000189ADC8B8-0x0000000189ADC908 
	
		// Nested types
		public sealed class Settings // TypeDefIndex: 55810
		{
			// Fields
			[CompilerGenerated]
			private static readonly Settings _Default_k__BackingField; // 0x00
			[CompilerGenerated]
			private readonly int _RecursionLimit_k__BackingField; // 0x10
			[CompilerGenerated]
			private readonly TypeRegistry _TypeRegistry_k__BackingField; // 0x18
			[CompilerGenerated]
			private readonly bool _IgnoreUnknownFields_k__BackingField; // 0x20
	
			// Properties
			public static Settings Default { [CompilerGenerated] get; } // 0x0000000189AE1934-0x0000000189AE1984 
			public int RecursionLimit { [CompilerGenerated] get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
			public TypeRegistry TypeRegistry { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
			public bool IgnoreUnknownFields { [CompilerGenerated] get; } // 0x0000000184D866B0-0x0000000184D866C0 
	
			// Constructors
			static Settings(); // 0x0000000189AE1674-0x0000000189AE16E8
			private Settings(int recursionLimit, TypeRegistry typeRegistry, bool ignoreUnknownFields); // 0x0000000189AE185C-0x0000000189AE18E4
			public Settings(int recursionLimit); // 0x0000000189AE175C-0x0000000189AE17B4
			public Settings(int recursionLimit, TypeRegistry typeRegistry); // 0x0000000189AE1740-0x0000000189AE175C
	
			// Methods
			public Settings WithIgnoreUnknownFields(bool ignoreUnknownFields); // 0x0000000189AE1300-0x0000000189AE1388
			public Settings WithRecursionLimit(int recursionLimit); // 0x0000000189AE1424-0x0000000189AE14AC
			public Settings WithTypeRegistry(TypeRegistry typeRegistry); // 0x0000000189AE1548-0x0000000189AE1600
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55811
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189AE2560-0x0000000189AE25C4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _.cctor_b__41_0(EnumDescriptor ed); // 0x0000000189AE1FC8-0x0000000189AE203C
			internal void _.cctor_b__41_1(JsonParser parser, IMessage message, JsonTokenizer tokenizer); // 0x0000000189AE203C-0x0000000189AE20A4
			internal void _.cctor_b__41_2(JsonParser parser, IMessage message, JsonTokenizer tokenizer); // 0x0000000189AE20A4-0x0000000189AE210C
			internal void _.cctor_b__41_3(JsonParser parser, IMessage message, JsonTokenizer tokenizer); // 0x0000000189AE210C-0x0000000189AE213C
			internal void _.cctor_b__41_4(JsonParser parser, IMessage message, JsonTokenizer tokenizer); // 0x0000000189AE213C-0x0000000189AE21D8
			internal void _.cctor_b__41_5(JsonParser parser, IMessage message, JsonTokenizer tokenizer); // 0x0000000189AE21D8-0x0000000189AE2208
			internal void _.cctor_b__41_6(JsonParser parser, IMessage message, JsonTokenizer tokenizer); // 0x0000000189AE2208-0x0000000189AE2238
			internal void _.cctor_b__41_7(JsonParser parser, IMessage message, JsonTokenizer tokenizer); // 0x0000000189AE2238-0x0000000189AE22A0
		}
	
		// Constructors
		public JsonParser(Settings settings); // 0x0000000189ADC850-0x0000000189ADC8B8
		static JsonParser(); // 0x0000000189ADBC8C-0x0000000189ADC850
	
		// Methods
		private static void MergeWrapperField(JsonParser parser, IMessage message, JsonTokenizer tokenizer); // 0x0000000189AD9C90-0x0000000189AD9D2C
		internal void Merge(IMessage message, string json); // 0x0000000189ADA2CC-0x0000000189ADA354
		internal void Merge(IMessage message, TextReader jsonReader); // 0x0000000189ADA1EC-0x0000000189ADA2CC
		private void Merge(IMessage message, JsonTokenizer tokenizer); // 0x0000000189AD9D2C-0x0000000189ADA1EC
		private void MergeField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer); // 0x0000000189AD88F8-0x0000000189AD8A7C
		private void MergeRepeatedField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer); // 0x0000000189AD8D08-0x0000000189AD8EF0
		private void MergeMapField(IMessage message, FieldDescriptor field, JsonTokenizer tokenizer); // 0x0000000189AD8A7C-0x0000000189AD8D08
		private static bool IsGoogleProtobufValueField(FieldDescriptor field); // 0x0000000189AD7C64-0x0000000189AD7CE4
		private static bool IsGoogleProtobufNullValueField(FieldDescriptor field); // 0x0000000189AD7BDC-0x0000000189AD7C64
		private object ParseSingleValue(FieldDescriptor field, JsonTokenizer tokenizer); // 0x0000000189ADB4A4-0x0000000189ADB810
		public T Parse<T>(string json)
			where T : IMessage, new();
		public T Parse<T>(TextReader jsonReader)
			where T : IMessage, new();
		public IMessage Parse(string json, MessageDescriptor descriptor); // 0x0000000189ADB8D8-0x0000000189ADB9BC
		public IMessage Parse(TextReader jsonReader, MessageDescriptor descriptor); // 0x0000000189ADB810-0x0000000189ADB8D8
		private void MergeStructValue(IMessage message, JsonTokenizer tokenizer); // 0x0000000189AD8EF0-0x0000000189AD9214
		private void MergeStruct(IMessage message, JsonTokenizer tokenizer); // 0x0000000189AD9214-0x0000000189AD9334
		private void MergeAny(IMessage message, JsonTokenizer tokenizer); // 0x0000000189AD7CE4-0x0000000189AD8110
		private void MergeWellKnownTypeAnyBody(IMessage body, JsonTokenizer tokenizer); // 0x0000000189AD9B2C-0x0000000189AD9C90
		private static object ParseMapKey(FieldDescriptor field, string keyText); // 0x0000000189ADA384-0x0000000189ADA7F0
		private static object ParseSingleNumberValue(FieldDescriptor field, JsonToken token); // 0x0000000189ADA7F0-0x0000000189ADADD4
		private static void CheckInteger(double value); // 0x0000000189AD7A50-0x0000000189AD7BDC
		private static object ParseSingleStringValue(FieldDescriptor field, string text); // 0x0000000189ADADD4-0x0000000189ADB4A4
		private static IMessage NewMessageForField(FieldDescriptor field); // 0x0000000189ADA354-0x0000000189ADA384
		private static T ParseNumericString<T>(string text, Func<string, NumberStyles, IFormatProvider, T> parser);
		private static void ValidateInfinityAndNan(string text, bool isPositiveInfinity, bool isNegativeInfinity, bool isNaN); // 0x0000000189ADBB6C-0x0000000189ADBC8C
		private static void MergeTimestamp(IMessage message, JsonToken token); // 0x0000000189AD9334-0x0000000189AD9B2C
		private static void MergeDuration(IMessage message, JsonToken token); // 0x0000000189AD8110-0x0000000189AD8730
		private static void MergeFieldMask(IMessage message, JsonToken token); // 0x0000000189AD8730-0x0000000189AD88F8
		private static string ToSnakeCase(string text); // 0x0000000189ADB9BC-0x0000000189ADBB6C
	}

	internal sealed class JsonToken : IEquatable<JsonToken> // TypeDefIndex: 55814
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
		internal static JsonToken Null { get; } // 0x0000000189ADEB90-0x0000000189ADEBE0 
		internal static JsonToken False { get; } // 0x0000000189ADEB40-0x0000000189ADEB90 
		internal static JsonToken True { get; } // 0x0000000189ADEC80-0x0000000189ADECD0 
		internal static JsonToken StartObject { get; } // 0x0000000189ADEC30-0x0000000189ADEC80 
		internal static JsonToken EndObject { get; } // 0x0000000189ADEAF0-0x0000000189ADEB40 
		internal static JsonToken StartArray { get; } // 0x0000000189ADEBE0-0x0000000189ADEC30 
		internal static JsonToken EndArray { get; } // 0x0000000189ADEA50-0x0000000189ADEAA0 
		internal static JsonToken EndDocument { get; } // 0x0000000189ADEAA0-0x0000000189ADEAF0 
		internal TokenType Type { get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
		internal string StringValue { get; } // 0x000000018385B100-0x000000018385B110 
		internal double NumberValue { get; } // 0x0000000184D86970-0x0000000184D86980 
	
		// Nested types
		internal enum TokenType // TypeDefIndex: 55813
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
		private JsonToken(TokenType type, string stringValue = null, double numberValue = 0 /* Metadata: 0x0234768E */); // 0x0000000189ADEA2C-0x0000000189ADEA50
		static JsonToken(); // 0x0000000189ADE740-0x0000000189ADEA2C
	
		// Methods
		internal static JsonToken Name(string name); // 0x0000000189ADE3C8-0x0000000189ADE434
		internal static JsonToken Value(string value); // 0x0000000189ADE6D4-0x0000000189ADE740
		internal static JsonToken Value(double value); // 0x0000000189ADE668-0x0000000189ADE6D4
		public override bool Equals(object obj); // 0x0000000189ADE2F0-0x0000000189ADE354
		public override int GetHashCode(); // 0x0000000189ADE354-0x0000000189ADE3C8
		public override string ToString(); // 0x0000000189ADE434-0x0000000189ADE668
		public bool Equals(JsonToken other); // 0x0000000189ADE29C-0x0000000189ADE2F0
	}

	internal abstract class JsonTokenizer // TypeDefIndex: 55820
	{
		// Fields
		private JsonToken bufferedToken; // 0x10
		[CompilerGenerated]
		private int _ObjectDepth_k__BackingField; // 0x18
	
		// Properties
		internal int ObjectDepth { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
	
		// Nested types
		private class JsonReplayTokenizer : JsonTokenizer // TypeDefIndex: 55815
		{
			// Fields
			private readonly IList<JsonToken> tokens; // 0x20
			private readonly JsonTokenizer nextTokenizer; // 0x28
			private int nextTokenIndex; // 0x30
	
			// Constructors
			internal JsonReplayTokenizer(IList<JsonToken> tokens, JsonTokenizer nextTokenizer); // 0x0000000189ADC998-0x0000000189ADC9C0
	
			// Methods
			protected override JsonToken NextImpl(); // 0x0000000189ADC908-0x0000000189ADC998
		}
	
		private sealed class JsonTextTokenizer : JsonTokenizer // TypeDefIndex: 55819
		{
			// Fields
			private static readonly State ValueStates; // 0x00
			private readonly Stack<ContainerType> containerStack; // 0x20
			private readonly PushBackReader reader; // 0x28
			private State state; // 0x30
	
			// Nested types
			private enum ContainerType // TypeDefIndex: 55816
			{
				Document = 0,
				Object = 1,
				Array = 2
			}
	
			[Flags]
			private enum State // TypeDefIndex: 55817
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
	
			private class PushBackReader // TypeDefIndex: 55818
			{
				// Fields
				private readonly TextReader reader; // 0x10
				private char? nextChar; // 0x18
	
				// Constructors
				internal PushBackReader(TextReader reader); // 0x00000001853908C0-0x00000001853908D0
	
				// Methods
				internal char? Read(); // 0x0000000189AE114C-0x0000000189AE11C8
				internal char ReadOrFail(string messageOnFailure); // 0x0000000189AE10BC-0x0000000189AE114C
				internal void PushBack(char c); // 0x0000000189AE1008-0x0000000189AE10BC
				internal InvalidJsonException CreateException(string message); // 0x0000000189AE0FA8-0x0000000189AE1008
			}
	
			// Constructors
			internal JsonTextTokenizer(TextReader reader); // 0x0000000189ADE1B4-0x0000000189ADE29C
			static JsonTextTokenizer(); // 0x0000000189ADE178-0x0000000189ADE1B4
	
			// Methods
			protected override JsonToken NextImpl(); // 0x0000000189ADCBEC-0x0000000189ADD2AC
			private void ValidateState(State validStates, string errorPrefix); // 0x0000000189ADE0DC-0x0000000189ADE178
			private string ReadString(); // 0x0000000189ADDC7C-0x0000000189ADDEB4
			private char ReadEscapedCharacter(); // 0x0000000189ADD3E4-0x0000000189ADD550
			private char ReadUnicodeEscape(); // 0x0000000189ADDEB4-0x0000000189ADDFEC
			private void ConsumeLiteral(string text); // 0x0000000189ADCA98-0x0000000189ADCBEC
			private double ReadNumber(char initialCharacter); // 0x0000000189ADD900-0x0000000189ADDC7C
			private char? ReadInt(StringBuilder builder); // 0x0000000189ADD7D0-0x0000000189ADD900
			private char? ReadFrac(StringBuilder builder); // 0x0000000189ADD73C-0x0000000189ADD7D0
			private char? ReadExp(StringBuilder builder); // 0x0000000189ADD550-0x0000000189ADD73C
			private char? ConsumeDigits(StringBuilder builder, out int count); // 0x0000000189ADC9C0-0x0000000189ADCA98
			private void ValidateAndModifyStateForValue(string errorPrefix); // 0x0000000189ADDFEC-0x0000000189ADE0DC
			private void PopContainer(); // 0x0000000189ADD2AC-0x0000000189ADD3E4
		}
	
		// Constructors
		protected JsonTokenizer(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		internal static JsonTokenizer FromTextReader(TextReader reader); // 0x0000000189ADED40-0x0000000189ADEDA0
		internal static JsonTokenizer FromReplayedTokens(IList<JsonToken> tokens, JsonTokenizer continuation); // 0x0000000189ADECD0-0x0000000189ADED40
		internal void PushBack(JsonToken token); // 0x0000000189ADEE10-0x0000000189ADEEA8
		internal JsonToken Next(); // 0x0000000189ADEDA0-0x0000000189ADEE10
		protected abstract JsonToken NextImpl();
		internal void SkipValue(); // 0x0000000189ADEEA8-0x0000000189ADEEF8
	}

	internal sealed class LimitedInputStream : Stream // TypeDefIndex: 55821
	{
		// Fields
		private readonly Stream proxied; // 0x28
		private int bytesLeft; // 0x30
	
		// Properties
		public override bool CanRead { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public override bool CanSeek { get; } // 0x00000001812081B0-0x0000000181208610 
		public override bool CanWrite { get; } // 0x00000001812081B0-0x0000000181208610 
		public override long Length { get; } // 0x0000000189ADF0DC-0x0000000189ADF128 
		public override long Position { get; set; } // 0x0000000189ADF128-0x0000000189ADF174 0x0000000189ADF174-0x0000000189ADF1C0
	
		// Constructors
		internal LimitedInputStream(Stream proxied, int size); // 0x0000000189ADF07C-0x0000000189ADF0DC
	
		// Methods
		public override void Flush(); // 0x00000001841E1670-0x00000001841E1680
		public override int Read(byte[] buffer, int offset, int count); // 0x0000000189ADEEF8-0x0000000189ADEF98
		public override long Seek(long offset, SeekOrigin origin); // 0x0000000189ADEF98-0x0000000189ADEFE4
		public override void SetLength(long value); // 0x0000000189ADEFE4-0x0000000189ADF030
		public override void Write(byte[] buffer, int offset, int count); // 0x0000000189ADF030-0x0000000189ADF07C
	}

	public static class MessageExtensions // TypeDefIndex: 55823
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 55822
		{
			// Fields
			public IMessage message; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _IsInitialized_b__0(FieldDescriptor f); // 0x0000000189AE2318-0x0000000189AE2560
		}
	
		// Extension methods
		public static void MergeFrom(this IMessage message, byte[] data); // 0x0000000189ADF5A0-0x0000000189ADF5C0
		public static void MergeFrom(this IMessage message, byte[] data, int offset, int length); // 0x0000000185394858-0x0000000185394878
		public static void MergeFrom(this IMessage message, ByteString data); // 0x0000000189ADF468-0x0000000189ADF488
		public static void MergeFrom(this IMessage message, Stream input); // 0x0000000189ADF488-0x0000000189ADF4A8
		public static void MergeFrom(this IMessage message, ReadOnlySpan<byte> span); // 0x0000000185394824-0x0000000185394850
		public static void MergeDelimitedFrom(this IMessage message, Stream input); // 0x0000000189ADF448-0x0000000189ADF468
		public static byte[] ToByteArray(this IMessage message); // 0x0000000189ADF8C8-0x0000000189ADF9B8
		public static int WriteToByteArray(this IMessage message, byte[] buffer, int pos); // 0x0000000183143590-0x00000001831436C0
		public static void WriteTo(this IMessage message, Stream output); // 0x0000000189ADFB40-0x0000000189ADFC2C
		public static void WriteDelimitedTo(this IMessage message, Stream output); // 0x0000000189ADFA34-0x0000000189ADFB40
		public static ByteString ToByteString(this IMessage message); // 0x0000000189ADF9B8-0x0000000189ADFA34
		public static void WriteTo(this IMessage message, IBufferWriter<byte> output); // 0x0000000189ADFD00-0x0000000189ADFE08
		public static void WriteTo(this IMessage message, Span<byte> output); // 0x0000000189ADFC2C-0x0000000189ADFD00
		public static bool IsInitialized(this IMessage message); // 0x0000000189ADF1C0-0x0000000189ADF344
		internal static void MergeFrom(this IMessage message, byte[] data, bool discardUnknownFields, ExtensionRegistry registry); // 0x0000000189ADF5C0-0x0000000189ADF6DC
		internal static void MergeFrom(this IMessage message, byte[] data, int offset, int length, bool discardUnknownFields, ExtensionRegistry registry); // 0x0000000183143020-0x0000000183143150
		internal static void MergeFrom(this IMessage message, ByteString data, bool discardUnknownFields, ExtensionRegistry registry); // 0x0000000189ADF4A8-0x0000000189ADF5A0
		internal static void MergeFrom(this IMessage message, Stream input, bool discardUnknownFields, ExtensionRegistry registry); // 0x0000000189ADF6DC-0x0000000189ADF7FC
		internal static void MergeFrom(this IMessage message, ReadOnlySequence<byte> data, bool discardUnknownFields, ExtensionRegistry registry); // 0x0000000189ADF7FC-0x0000000189ADF8C8
		internal static void MergeFrom(this IMessage message, ReadOnlySpan<byte> data, bool discardUnknownFields, ExtensionRegistry registry); // 0x0000000183DF4750-0x0000000183DF48A0
		internal static void MergeDelimitedFrom(this IMessage message, Stream input, bool discardUnknownFields, ExtensionRegistry registry); // 0x0000000189ADF344-0x0000000189ADF448
	}

	public class MessageParser // TypeDefIndex: 55824
	{
		// Fields
		private Func<IMessage> factory; // 0x10
		[CompilerGenerated]
		private readonly bool _DiscardUnknownFields_k__BackingField; // 0x18
		[CompilerGenerated]
		private readonly ExtensionRegistry _Extensions_k__BackingField; // 0x20
	
		// Properties
		internal bool DiscardUnknownFields { [CompilerGenerated] get; } // 0x0000000184D86340-0x0000000184D86350 
		internal ExtensionRegistry Extensions { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Constructors
		internal MessageParser(Func<IMessage> factory, bool discardUnknownFields, ExtensionRegistry extensions); // 0x0000000184044A30-0x0000000184044A60
	
		// Methods
		internal IMessage CreateTemplate(); // 0x0000000189ADFE08-0x0000000189ADFE28
		public IMessage ParseFrom(byte[] data); // 0x0000000189AE0184-0x0000000189AE01E0
		public IMessage ParseFrom(byte[] data, int offset, int length); // 0x0000000189AE0048-0x0000000189AE00CC
		public IMessage ParseFrom(ByteString data); // 0x0000000189AE0128-0x0000000189AE0184
		public IMessage ParseFrom(Stream input); // 0x0000000189AE00CC-0x0000000189AE0128
		public IMessage ParseFrom(ReadOnlySequence<byte> data); // 0x0000000189AE0248-0x0000000189AE02B8
		public IMessage ParseFrom(ReadOnlySpan<byte> data); // 0x0000000189AE01E0-0x0000000189AE0248
		public IMessage ParseDelimitedFrom(Stream input); // 0x0000000189ADFFEC-0x0000000189AE0048
		public IMessage ParseFrom(CodedInputStream input); // 0x0000000189AE02B8-0x0000000189AE030C
		public IMessage ParseJson(string json); // 0x0000000189AE030C-0x0000000189AE0388
		internal void MergeFrom(IMessage message, CodedInputStream codedInput); // 0x0000000189ADFE28-0x0000000189ADFFEC
		public MessageParser WithDiscardUnknownFields(bool discardUnknownFields); // 0x0000000189AE0388-0x0000000189AE0410
		public MessageParser WithExtensionRegistry(ExtensionRegistry registry); // 0x0000000189AE0410-0x0000000189AE0498
	}

	public sealed class MessageParser<T> : MessageParser // TypeDefIndex: 55826
		where T : IMessage<T>
	{
		// Fields
		private readonly Func<T> factory;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 55825
		{
			// Fields
			public Func<T> factory;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal IMessage _.ctor_b__0();
		}
	
		// Constructors
		public MessageParser(Func<T> factory);
		internal MessageParser(Func<T> factory, bool discardUnknownFields, ExtensionRegistry extensions);
	
		// Methods
		internal new T CreateTemplate();
		public new T ParseFrom(byte[] data);
		public new T ParseFrom(byte[] data, int offset, int length);
		public new T ParseFrom(ByteString data);
		public new T ParseFrom(Stream input);
		public new T ParseFrom(ReadOnlySequence<byte> data);
		public new T ParseFrom(ReadOnlySpan<byte> data);
		public new T ParseDelimitedFrom(Stream input);
		public new T ParseFrom(CodedInputStream input);
		public new T ParseJson(string json);
		public new MessageParser<T> WithDiscardUnknownFields(bool discardUnknownFields);
		public new MessageParser<T> WithExtensionRegistry(ExtensionRegistry registry);
	}

	internal struct ObjectIntPair<T> : IEquatable<ObjectIntPair<T>> // TypeDefIndex: 55827
		where T : class
	{
		// Fields
		private readonly int number;
		private readonly T obj;
	
		// Constructors
		internal ObjectIntPair(T obj, int number);
	
		// Methods
		public bool Equals(ObjectIntPair<T> other);
		public override bool Equals(object obj);
		public override int GetHashCode();
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct ParseContext // TypeDefIndex: 55828
	{
		// Fields
		internal const int DefaultRecursionLimit = 100; // Metadata: 0x023476B4
		internal const int DefaultSizeLimit = 2147483647; // Metadata: 0x023476B6
		internal ReadOnlySpan<byte> buffer; // 0x00
		internal ParserInternalState state; // 0x10
	
		// Properties
		internal uint LastTag { get; } // 0x0000000184D868A0-0x0000000184D868B0 
		internal bool DiscardUnknownFields { get; set; } // 0x0000000182A80FA0-0x0000000182A80FB0 0x0000000182A80FB0-0x0000000182A80FC0
		internal ExtensionRegistry ExtensionRegistry { get; set; } // 0x0000000184D861F0-0x0000000184D86200 0x0000000185395D30-0x0000000185395D44
	
		// Methods
		internal static void Initialize(ReadOnlySpan<byte> buffer, out ParseContext ctx); // 0x0000000189AE0CEC-0x0000000189AE0DB0
		internal static void Initialize(ReadOnlySpan<byte> buffer, ref ParserInternalState state, out ParseContext ctx); // 0x0000000184DA0CF0-0x0000000184DA0D60
		internal static void Initialize(CodedInputStream input, out ParseContext ctx); // 0x0000000189AE0C20-0x0000000189AE0CEC
		internal static void Initialize(ReadOnlySequence<byte> input, out ParseContext ctx); // 0x0000000189AE0BF4-0x0000000189AE0C20
		internal static void Initialize(ReadOnlySequence<byte> input, int recursionLimit, out ParseContext ctx); // 0x0000000189AE0B40-0x0000000189AE0BF4
		public uint ReadTag(); // 0x0000000189AE0F9C-0x0000000189AE0FA8
		public double ReadDouble(); // 0x0000000189AE0E4C-0x0000000189AE0E58
		public float ReadFloat(); // 0x0000000189AE0E7C-0x0000000189AE0E88
		public ulong ReadUInt64(); // 0x0000000189AE0EE4-0x0000000189AE0EF0
		public long ReadInt64(); // 0x0000000189AE0EE4-0x0000000189AE0EF0
		public int ReadInt32(); // 0x0000000189AE0E58-0x0000000189AE0E64
		public ulong ReadFixed64(); // 0x0000000189AE0E70-0x0000000189AE0E7C
		public uint ReadFixed32(); // 0x0000000189AE0E64-0x0000000189AE0E70
		public bool ReadBool(); // 0x0000000189AE0E24-0x0000000189AE0E40
		public string ReadString(); // 0x0000000189AE0F90-0x0000000189AE0F9C
		public void ReadMessage(IMessage message); // 0x0000000189AE0EF0-0x0000000189AE0F4C
		public void ReadGroup(IMessage message); // 0x0000000189AE0E88-0x0000000189AE0EE4
		public ByteString ReadBytes(); // 0x0000000189AE0E40-0x0000000189AE0E4C
		public uint ReadUInt32(); // 0x0000000189AE0E58-0x0000000189AE0E64
		public int ReadEnum(); // 0x0000000189AE0E58-0x0000000189AE0E64
		public int ReadSFixed32(); // 0x0000000189AE0E64-0x0000000189AE0E70
		public long ReadSFixed64(); // 0x0000000189AE0E70-0x0000000189AE0E7C
		public int ReadSInt32(); // 0x0000000189AE0F4C-0x0000000189AE0F6C
		public long ReadSInt64(); // 0x0000000189AE0F6C-0x0000000189AE0F90
		public int ReadLength(); // 0x0000000189AE0E58-0x0000000189AE0E64
		internal void CopyStateTo(CodedInputStream input); // 0x0000000183E9EAE0-0x0000000183E9EB60
		internal void LoadStateFrom(CodedInputStream input); // 0x0000000189AE0DB0-0x0000000189AE0E24
	}

	internal struct ParserInternalState // TypeDefIndex: 55829
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
		[CompilerGenerated]
		private bool _DiscardUnknownFields_k__BackingField; // 0x74
		[CompilerGenerated]
		private ExtensionRegistry _ExtensionRegistry_k__BackingField; // 0x78
	
		// Properties
		internal CodedInputStream CodedInputStream { get; } // 0x0000000182E56440-0x0000000182E56460 
		internal bool DiscardUnknownFields { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x000000018157A7D0-0x000000018157A7E0 0x000000018157A810-0x000000018157A820
		internal ExtensionRegistry ExtensionRegistry { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D862A0-0x0000000184D862B0 0x0000000186402320-0x0000000186402330
	}

	internal static class ParsingPrimitives // TypeDefIndex: 55830
	{
		// Fields
		private const int StackallocThreshold = 256; // Metadata: 0x023476B7
	
		// Methods
		public static int ParseLength(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEB504-0x0000000189AEB50C
		public static uint ParseTag(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000182F7EC00-0x0000000182F7ED20
		public static bool MaybeConsumeTag(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, uint tag); // 0x0000000182F7D9A0-0x0000000182F7DA00
		public static uint PeekTag(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000182F7DA00-0x0000000182F7DA40
		public static ulong ParseRawVarint64(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x00000001835372C0-0x00000001835373C0
		private static ulong ParseRawVarint64SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x00000001835373C0-0x0000000183537440
		public static uint ParseRawVarint32(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000182F7ED20-0x0000000182F7EE90
		private static uint ParseRawVarint32SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000182F7DA40-0x0000000182F7DB40
		public static uint ParseRawLittleEndian32(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEB598-0x0000000189AEB624
		private static uint ParseRawLittleEndian32SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEB50C-0x0000000189AEB598
		public static ulong ParseRawLittleEndian64(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEB720-0x0000000189AEB7AC
		private static ulong ParseRawLittleEndian64SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEB624-0x0000000189AEB720
		public static double ParseDouble(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000183D6C820-0x0000000183D6C8E0
		public static float ParseFloat(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000183DB8140-0x0000000183DB8200
		private static float ParseFloatSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEB3E0-0x0000000189AEB504
		public static byte[] ReadRawBytes(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size); // 0x0000000182F84F70-0x0000000182F857F0
		private static byte[] ReadRawBytesSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size); // 0x0000000189AEB984-0x0000000189AEBDD0
		public static void SkipRawBytes(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size); // 0x0000000189AEBEF4-0x0000000189AEBFA8
		public static string ReadString(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEBEC0-0x0000000189AEBEF4
		public static ByteString ReadBytes(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEB7AC-0x0000000189AEB81C
		public static string ReadRawString(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int length); // 0x0000000182F857F0-0x0000000182F858E0
		private static string ReadStringSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int length); // 0x0000000182F862A0-0x0000000182F86360
		private static void ValidateCurrentLimit(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size); // 0x0000000182F86360-0x0000000182F86380
		private static byte ReadRawByte(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000182F7EBC0-0x0000000182F7EC00
		public static uint ReadRawVarint32(Stream input); // 0x0000000189AEBDD0-0x0000000189AEBEC0
		public static int DecodeZigZag32(uint n); // 0x0000000184DA0D60-0x0000000184DA0D70
		public static long DecodeZigZag64(ulong n); // 0x0000000184DA0D70-0x0000000184DA0D80
		public static bool IsDataAvailable(ref ParserInternalState state, int size); // 0x0000000183977980-0x00000001839779A0
		private static bool IsDataAvailableInSource(ref ParserInternalState state, int size); // 0x0000000189AEB334-0x0000000189AEB3E0
		private static void ReadRawBytesIntoSpan(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int length, Span<byte> byteSpan); // 0x0000000189AEB81C-0x0000000189AEB984
	}

	internal static class ParsingPrimitivesMessages // TypeDefIndex: 55831
	{
		// Fields
		private static readonly byte[] ZeroLengthMessageStreamData; // 0x00
	
		// Constructors
		static ParsingPrimitivesMessages(); // 0x0000000184D36760-0x0000000184D367D0
	
		// Methods
		public static void SkipLastField(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEA7E4-0x0000000189AEA980
		public static void SkipGroup(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, uint startGroupTag); // 0x0000000189AEA658-0x0000000189AEA7E4
		public static void ReadMessage(ref ParseContext ctx, IMessage message); // 0x0000000182F85C20-0x0000000182F85D30
		public static KeyValuePair<TKey, TValue> ReadMapEntry<TKey, TValue>(ref ParseContext ctx, MapField<TKey, TValue> codec);
		public static void ReadGroup(ref ParseContext ctx, IMessage message); // 0x0000000189AEA4FC-0x0000000189AEA5A4
		public static void ReadGroup(ref ParseContext ctx, int fieldNumber, UnknownFieldSet set); // 0x0000000189AEA5A4-0x0000000189AEA658
		public static void ReadRawMessage(ref ParseContext ctx, IMessage message); // 0x0000000182F85E00-0x0000000182F862A0
		public static void CheckReadEndOfStreamTag(ref ParserInternalState state); // 0x0000000182F85DC0-0x0000000182F85DE0
		private static void CheckLastTagWas(ref ParserInternalState state, uint expectedTag); // 0x0000000189AEA4C0-0x0000000189AEA4FC
	}

	internal static class ParsingPrimitivesWrappers // TypeDefIndex: 55832
	{
		// Methods
		internal static float? ReadFloatWrapperLittleEndian(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEAC30-0x0000000189AEACEC
		internal static float? ReadFloatWrapperSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEACF8-0x0000000189AEADD8
		internal static double? ReadDoubleWrapperLittleEndian(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEAA4C-0x0000000189AEAB1C
		internal static double? ReadDoubleWrapperSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEAB48-0x0000000189AEAC30
		internal static bool? ReadBoolWrapper(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEA980-0x0000000189AEAA14
		internal static uint? ReadUInt32Wrapper(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEB014-0x0000000189AEB0F8
		internal static uint? ReadUInt32WrapperSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEAF3C-0x0000000189AEB014
		internal static int? ReadInt32Wrapper(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEADF0-0x0000000189AEAE70
		internal static ulong? ReadUInt64Wrapper(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEB214-0x0000000189AEB308
		internal static ulong? ReadUInt64WrapperSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEB130-0x0000000189AEB214
		internal static long? ReadInt64Wrapper(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEAE9C-0x0000000189AEAF3C
		internal static float? ReadFloatWrapperLittleEndian(ref ParseContext ctx); // 0x0000000189AEACEC-0x0000000189AEACF8
		internal static float? ReadFloatWrapperSlow(ref ParseContext ctx); // 0x0000000189AEADD8-0x0000000189AEADE4
		internal static double? ReadDoubleWrapperLittleEndian(ref ParseContext ctx); // 0x0000000189AEAA20-0x0000000189AEAA4C
		internal static double? ReadDoubleWrapperSlow(ref ParseContext ctx); // 0x0000000189AEAB1C-0x0000000189AEAB48
		internal static bool? ReadBoolWrapper(ref ParseContext ctx); // 0x0000000189AEAA14-0x0000000189AEAA20
		internal static uint? ReadUInt32Wrapper(ref ParseContext ctx); // 0x0000000189AEB0F8-0x0000000189AEB104
		internal static int? ReadInt32Wrapper(ref ParseContext ctx); // 0x0000000189AEADE4-0x0000000189AEADF0
		internal static ulong? ReadUInt64Wrapper(ref ParseContext ctx); // 0x0000000189AEB308-0x0000000189AEB334
		internal static ulong? ReadUInt64WrapperSlow(ref ParseContext ctx); // 0x0000000189AEB104-0x0000000189AEB130
		internal static long? ReadInt64Wrapper(ref ParseContext ctx); // 0x0000000189AEAE70-0x0000000189AEAE9C
	}

	public static class ProtoPreconditions // TypeDefIndex: 55833
	{
		// Methods
		public static T CheckNotNull<T>(T value, string name)
			where T : class;
		internal static T CheckNotNullUnconstrained<T>(T value, string name);
	}

	internal struct SegmentedBufferHelper // TypeDefIndex: 55834
	{
		// Fields
		private int? totalLength; // 0x00
		private ReadOnlySequence<byte> readOnlySequenceEnumerator; // 0x08
		private CodedInputStream codedInputStream; // 0x40
	
		// Properties
		public int? TotalLength { get; } // 0x0000000182B76770-0x0000000182B76780 
		public CodedInputStream CodedInputStream { get; } // 0x0000000184D85A60-0x0000000184D85A70 
	
		// Methods
		public static void Initialize(CodedInputStream codedInputStream, out SegmentedBufferHelper instance); // 0x0000000189AEBFA8-0x0000000189AEC040
		public static void Initialize(ReadOnlySequence<byte> sequence, out SegmentedBufferHelper instance, out ReadOnlySpan<byte> firstSpan); // 0x0000000189AEC040-0x0000000189AEC238
		public bool RefillBuffer(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, bool mustSucceed); // 0x0000000182F7DC40-0x0000000182F7DC70
		public static int PushLimit(ref ParserInternalState state, int byteLimit); // 0x0000000182F85D30-0x0000000182F85D90
		public static void PopLimit(ref ParserInternalState state, int oldLimit); // 0x0000000185390AA0-0x0000000185390AAC
		public static bool IsReachedLimit(ref ParserInternalState state); // 0x0000000182F85DE0-0x0000000182F85E00
		public static bool IsAtEnd(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state); // 0x0000000189AEC238-0x0000000189AEC26C
		private bool RefillFromReadOnlySequence(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, bool mustSucceed); // 0x0000000183EE6570-0x0000000183EE6620
		private bool RefillFromCodedInputStream(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, bool mustSucceed); // 0x0000000182F7DB40-0x0000000182F7DBD0
		private static void RecomputeBufferSizeAfterLimit(ref ParserInternalState state); // 0x0000000182F85D90-0x0000000182F85DC0
		private static void CheckCurrentBufferIsEmpty(ref ParserInternalState state); // 0x0000000182F7DBD0-0x0000000182F7DC40
	}

	internal sealed class UnknownField // TypeDefIndex: 55835
	{
		// Fields
		private List<ulong> varintList; // 0x10
		private List<uint> fixed32List; // 0x18
		private List<ulong> fixed64List; // 0x20
		private List<ByteString> lengthDelimitedList; // 0x28
		private List<UnknownFieldSet> groupList; // 0x30
	
		// Constructors
		public UnknownField(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override bool Equals(object other); // 0x0000000189AF1AD8-0x0000000189AF1BDC
		public override int GetHashCode(); // 0x0000000189AF1BDC-0x0000000189AF1CC4
		internal void WriteTo(int fieldNumber, ref WriteContext output); // 0x0000000189AF22D8-0x0000000189AF28A8
		internal int GetSerializedSize(int fieldNumber); // 0x0000000189AF1CC4-0x0000000189AF21C8
		internal UnknownField MergeFrom(UnknownField other); // 0x0000000189AF21C8-0x0000000189AF22D8
		private static List<T> AddAll<T>(List<T> current, IList<T> extras);
		internal UnknownField AddVarint(ulong value); // 0x0000000189AF1A7C-0x0000000189AF1AD8
		internal UnknownField AddFixed32(uint value); // 0x0000000189AF1910-0x0000000189AF1968
		internal UnknownField AddFixed64(ulong value); // 0x0000000189AF1968-0x0000000189AF19C4
		internal UnknownField AddLengthDelimited(ByteString value); // 0x0000000189AF1A20-0x0000000189AF1A7C
		internal UnknownField AddGroup(UnknownFieldSet value); // 0x0000000189AF19C4-0x0000000189AF1A20
		private static List<T> Add<T>(List<T> list, T value);
	}

	public sealed class UnknownFieldSet // TypeDefIndex: 55836
	{
		// Fields
		private readonly IDictionary<int, UnknownField> fields; // 0x10
		private int lastFieldNumber; // 0x18
		private UnknownField lastField; // 0x20
	
		// Constructors
		internal UnknownFieldSet(); // 0x0000000189AF1898-0x0000000189AF1910
	
		// Methods
		internal bool HasField(int field); // 0x0000000189AF0E58-0x0000000189AF0EB0
		public void WriteTo(CodedOutputStream output); // 0x0000000189AF15FC-0x0000000189AF16C0
		public void WriteTo(ref WriteContext ctx); // 0x0000000189AF16C0-0x0000000189AF1898
		public int CalculateSize(); // 0x0000000189AF081C-0x0000000189AF0980
		public override bool Equals(object other); // 0x0000000189AF0980-0x0000000189AF0C0C
		public override int GetHashCode(); // 0x0000000189AF0C0C-0x0000000189AF0D98
		private UnknownField GetOrAddField(int number); // 0x0000000189AF0D98-0x0000000189AF0E58
		internal UnknownFieldSet AddOrReplaceField(int number, UnknownField field); // 0x0000000189AF0754-0x0000000189AF081C
		private bool MergeFieldFrom(ref ParseContext ctx); // 0x0000000189AF1094-0x0000000189AF1288
		internal void MergeGroupFrom(ref ParseContext ctx); // 0x0000000189AF15B0-0x0000000189AF15FC
		public static UnknownFieldSet MergeFieldFrom(UnknownFieldSet unknownFields, CodedInputStream input); // 0x0000000189AF0FA8-0x0000000189AF1094
		public static UnknownFieldSet MergeFieldFrom(UnknownFieldSet unknownFields, ref ParseContext ctx); // 0x0000000189AF0EB0-0x0000000189AF0FA8
		private UnknownFieldSet MergeFrom(UnknownFieldSet other); // 0x0000000189AF13D0-0x0000000189AF15B0
		public static UnknownFieldSet MergeFrom(UnknownFieldSet unknownFields, UnknownFieldSet other); // 0x0000000189AF1358-0x0000000189AF13D0
		private UnknownFieldSet MergeField(int number, UnknownField field); // 0x0000000189AF1288-0x0000000189AF1358
		public static UnknownFieldSet Clone(UnknownFieldSet other); // 0x0000000183218CC0-0x0000000183218D00
	}

	public static class UnsafeByteOperations // TypeDefIndex: 55837
	{
		// Methods
		public static ByteString UnsafeWrap(ReadOnlyMemory<byte> bytes); // 0x0000000189AF28A8-0x0000000189AF28FC
	}

	public static class WireFormat // TypeDefIndex: 55839
	{
		// Fields
		private const int TagTypeBits = 3; // Metadata: 0x023476B9
		private const uint TagTypeMask = 7; // Metadata: 0x023476BA
	
		// Nested types
		public enum WireType : uint // TypeDefIndex: 55838
		{
			Varint = 0,
			Fixed64 = 1,
			LengthDelimited = 2,
			StartGroup = 3,
			EndGroup = 4,
			Fixed32 = 5
		}
	
		// Methods
		public static WireType GetTagWireType(uint tag); // 0x0000000184DA0D90-0x0000000184DA0DA0
		public static int GetTagFieldNumber(uint tag); // 0x0000000184DA0D80-0x0000000184DA0D90
		public static uint MakeTag(int fieldNumber, WireType wireType); // 0x0000000184DA0DA0-0x0000000184DA0DB0
	}

	internal struct WriteBufferHelper // TypeDefIndex: 55840
	{
		// Fields
		private IBufferWriter<byte> bufferWriter; // 0x00
		private CodedOutputStream codedOutputStream; // 0x08
	
		// Properties
		public CodedOutputStream CodedOutputStream { get; } // 0x0000000184D88320-0x0000000184D88330 
	
		// Methods
		public static void Initialize(CodedOutputStream codedOutputStream, out WriteBufferHelper instance); // 0x0000000183143780-0x00000001831437B0
		public static void Initialize(IBufferWriter<byte> bufferWriter, out WriteBufferHelper instance, out Span<byte> buffer); // 0x0000000189ACC1D0-0x0000000189ACC204
		public static void InitializeNonRefreshable(out WriteBufferHelper instance); // 0x0000000189ACC1AC-0x0000000189ACC1D0
		public static void CheckNoSpaceLeft(ref WriterInternalState state); // 0x0000000189ACC01C-0x0000000189ACC130
		public static int GetSpaceLeft(ref WriterInternalState state); // 0x0000000189ACC130-0x0000000189ACC1AC
		public static void RefreshBuffer(ref Span<byte> buffer, ref WriterInternalState state); // 0x0000000189AF3E18-0x0000000189AF3F34
		public static void Flush(ref Span<byte> buffer, ref WriterInternalState state); // 0x0000000189AF3D70-0x0000000189AF3E18
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct WriteContext // TypeDefIndex: 55841
	{
		// Fields
		internal Span<byte> buffer; // 0x00
		internal WriterInternalState state; // 0x10
	
		// Methods
		internal static void Initialize(ref Span<byte> buffer, ref WriterInternalState state, out WriteContext ctx); // 0x0000000184DA0DB0-0x0000000184DA0DD0
		internal static void Initialize(CodedOutputStream output, out WriteContext ctx); // 0x0000000189AF3FA8-0x0000000189AF4024
		internal static void Initialize(IBufferWriter<byte> output, out WriteContext ctx); // 0x0000000189AF4024-0x0000000189AF408C
		internal static void Initialize(ref Span<byte> buffer, out WriteContext ctx); // 0x0000000189AF3F4C-0x0000000189AF3FA8
		public void WriteDouble(double value); // 0x0000000183077670-0x00000001830776C0
		public void WriteFloat(float value); // 0x000000018307AA60-0x000000018307AB70
		public void WriteUInt64(ulong value); // 0x0000000183078680-0x0000000183078770
		public void WriteInt64(long value); // 0x0000000183078680-0x0000000183078770
		public void WriteInt32(int value); // 0x0000000183079380-0x0000000183079490
		public void WriteFixed64(ulong value); // 0x0000000189AF4108-0x0000000189AF415C
		public void WriteFixed32(uint value); // 0x0000000189AF40B4-0x0000000189AF4108
		public void WriteBool(bool value); // 0x0000000183077520-0x0000000183077570
		public void WriteString(string value); // 0x0000000183078230-0x0000000183078280
		public void WriteMessage(IMessage value); // 0x0000000185390FA0-0x0000000185390FA8
		public void WriteGroup(IMessage value); // 0x0000000189AF415C-0x0000000189AF4164
		public void WriteBytes(ByteString value); // 0x0000000184213430-0x0000000184213480
		public void WriteUInt32(uint value); // 0x00000001830792A0-0x0000000183079380
		public void WriteEnum(int value); // 0x0000000183079490-0x00000001830795C0
		public void WriteSFixed32(int value); // 0x0000000189AF42F0-0x0000000189AF4344
		public void WriteSFixed64(long value); // 0x0000000189AF4344-0x0000000189AF4398
		public void WriteSInt32(int value); // 0x0000000189AF4398-0x0000000189AF43EC
		public void WriteSInt64(long value); // 0x0000000189AF43EC-0x0000000189AF4440
		public void WriteLength(int length); // 0x0000000184592CD0-0x0000000184592D40
		public void WriteTag(int fieldNumber, WireFormat.WireType type); // 0x0000000189AF4440-0x0000000189AF44A8
		public void WriteTag(uint tag); // 0x0000000183078910-0x0000000183078960
		public void WriteRawTag(byte b1); // 0x000000018307A030-0x000000018307A0B0
		public void WriteRawTag(byte b1, byte b2); // 0x0000000183078E70-0x0000000183078F10
		public void WriteRawTag(byte b1, byte b2, byte b3); // 0x0000000189AF41E8-0x0000000189AF4264
		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4); // 0x0000000189AF4164-0x0000000189AF41E8
		public void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5); // 0x0000000189AF4264-0x0000000189AF42F0
		internal void Flush(); // 0x0000000189AF3F40-0x0000000189AF3F4C
		internal void CheckNoSpaceLeft(); // 0x0000000189AF3F34-0x0000000189AF3F40
		internal void CopyStateTo(CodedOutputStream output); // 0x0000000183F21110-0x0000000183F21140
		internal void LoadStateFrom(CodedOutputStream output); // 0x0000000189AF408C-0x0000000189AF40B4
	}

	internal struct WriterInternalState // TypeDefIndex: 55842
	{
		// Fields
		internal int limit; // 0x00
		internal int position; // 0x04
		internal WriteBufferHelper writeBufferHelper; // 0x08
	
		// Properties
		internal CodedOutputStream CodedOutputStream { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	}

	internal static class WritingPrimitives // TypeDefIndex: 55843
	{
		// Fields
		internal static readonly Encoding Utf8Encoding; // 0x00
	
		// Constructors
		static WritingPrimitives(); // 0x0000000184D56D70-0x0000000184D56DC0
	
		// Methods
		public static void WriteDouble(ref Span<byte> buffer, ref WriterInternalState state, double value); // 0x00000001830776C0-0x0000000183077730
		public static void WriteFloat(ref Span<byte> buffer, ref WriterInternalState state, float value); // 0x000000018307AB70-0x000000018307AC50
		private static void WriteFloatSlowPath(ref Span<byte> buffer, ref WriterInternalState state, float value); // 0x0000000189AF484C-0x0000000189AF49E0
		public static void WriteUInt64(ref Span<byte> buffer, ref WriterInternalState state, ulong value); // 0x0000000183078770-0x0000000183078840
		public static void WriteInt64(ref Span<byte> buffer, ref WriterInternalState state, long value); // 0x0000000183078770-0x0000000183078840
		public static void WriteInt32(ref Span<byte> buffer, ref WriterInternalState state, int value); // 0x00000001830796D0-0x00000001830797C0
		public static void WriteFixed64(ref Span<byte> buffer, ref WriterInternalState state, ulong value); // 0x0000000189AF47EC-0x0000000189AF484C
		public static void WriteFixed32(ref Span<byte> buffer, ref WriterInternalState state, uint value); // 0x0000000189AF478C-0x0000000189AF47EC
		public static void WriteBool(ref Span<byte> buffer, ref WriterInternalState state, bool value); // 0x0000000183077570-0x0000000183077670
		public static void WriteString(ref Span<byte> buffer, ref WriterInternalState state, string value); // 0x0000000183078280-0x0000000183078440
		private static void WriteAsciiStringToBuffer(Span<byte> buffer, ref WriterInternalState state, string value, int length); // 0x0000000183077890-0x0000000183077A60
		private static void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(ref byte outputBuffer, ulong value); // 0x0000000189AF4704-0x0000000189AF478C
		private static int WriteStringToBuffer(Span<byte> buffer, ref WriterInternalState state, string value); // 0x0000000183078150-0x0000000183078230
		public static void WriteBytes(ref Span<byte> buffer, ref WriterInternalState state, ByteString value); // 0x0000000184213480-0x0000000184213520
		public static void WriteUInt32(ref Span<byte> buffer, ref WriterInternalState state, uint value); // 0x0000000183078960-0x0000000183078A20
		public static void WriteEnum(ref Span<byte> buffer, ref WriterInternalState state, int value); // 0x00000001830795C0-0x00000001830796D0
		public static void WriteSFixed32(ref Span<byte> buffer, ref WriterInternalState state, int value); // 0x0000000189AF52F8-0x0000000189AF5358
		public static void WriteSFixed64(ref Span<byte> buffer, ref WriterInternalState state, long value); // 0x0000000189AF5358-0x0000000189AF53B8
		public static void WriteSInt32(ref Span<byte> buffer, ref WriterInternalState state, int value); // 0x0000000189AF53B8-0x0000000189AF5424
		public static void WriteSInt64(ref Span<byte> buffer, ref WriterInternalState state, long value); // 0x0000000189AF5424-0x0000000189AF5490
		public static void WriteLength(ref Span<byte> buffer, ref WriterInternalState state, int length); // 0x0000000183078960-0x0000000183078A20
		public static void WriteRawVarint32(ref Span<byte> buffer, ref WriterInternalState state, uint value); // 0x00000001830797C0-0x0000000183079B30
		public static void WriteRawVarint64(ref Span<byte> buffer, ref WriterInternalState state, ulong value); // 0x0000000183078840-0x00000001830788E0
		public static void WriteRawLittleEndian32(ref Span<byte> buffer, ref WriterInternalState state, uint value); // 0x0000000189AF4BC8-0x0000000189AF4C84
		private static void WriteRawLittleEndian32SlowPath(ref Span<byte> buffer, ref WriterInternalState state, uint value); // 0x0000000189AF4B28-0x0000000189AF4BC8
		public static void WriteRawLittleEndian64(ref Span<byte> buffer, ref WriterInternalState state, ulong value); // 0x0000000183077730-0x00000001830777A0
		public static void WriteRawLittleEndian64SlowPath(ref Span<byte> buffer, ref WriterInternalState state, ulong value); // 0x0000000189AF4C84-0x0000000189AF4D78
		private static void WriteRawByte(ref Span<byte> buffer, ref WriterInternalState state, byte value); // 0x000000018307A120-0x000000018307A180
		public static void WriteRawBytes(ref Span<byte> buffer, ref WriterInternalState state, byte[] value); // 0x0000000189AF49E0-0x0000000189AF4A84
		public static void WriteRawBytes(ref Span<byte> buffer, ref WriterInternalState state, byte[] value, int offset, int length); // 0x0000000189AF4A84-0x0000000189AF4B28
		public static void WriteRawBytes(ref Span<byte> buffer, ref WriterInternalState state, ReadOnlySpan<byte> value); // 0x0000000184213520-0x00000001842135A0
		public static void WriteTag(ref Span<byte> buffer, ref WriterInternalState state, int fieldNumber, WireFormat.WireType type); // 0x0000000189AF5490-0x0000000189AF5A58
		public static void WriteTag(ref Span<byte> buffer, ref WriterInternalState state, uint tag); // 0x0000000183078960-0x0000000183078A20
		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1); // 0x000000018307A0B0-0x000000018307A120
		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2); // 0x0000000183078F10-0x0000000183078F90
		private static void WriteRawTagSlowPath(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2); // 0x0000000189AF4F68-0x0000000189AF4FE8
		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3); // 0x0000000189AF5218-0x0000000189AF52F8
		private static void WriteRawTagSlowPath(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3); // 0x0000000189AF4E30-0x0000000189AF4EC4
		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3, byte b4); // 0x0000000189AF4FE8-0x0000000189AF50EC
		private static void WriteRawTagSlowPath(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3, byte b4); // 0x0000000189AF4EC4-0x0000000189AF4F68
		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3, byte b4, byte b5); // 0x0000000189AF50EC-0x0000000189AF5218
		private static void WriteRawTagSlowPath(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2, byte b3, byte b4, byte b5); // 0x0000000189AF4D78-0x0000000189AF4E30
		public static uint EncodeZigZag32(int n); // 0x0000000184DA0DD0-0x0000000184DA0DE0
		public static ulong EncodeZigZag64(long n); // 0x0000000184DA0DE0-0x0000000184DA0DF0
	}

	internal static class WritingPrimitivesMessages // TypeDefIndex: 55844
	{
		// Methods
		public static void WriteMessage(ref WriteContext ctx, IMessage value); // 0x0000000189AF44A8-0x0000000189AF4540
		public static void WriteGroup(ref WriteContext ctx, IMessage value); // 0x0000000189AF415C-0x0000000189AF4164
		public static void WriteRawMessage(ref WriteContext ctx, IMessage message); // 0x0000000189AF4540-0x0000000189AF4704
	}
}

namespace Google.Protobuf.Collections
{
	public static class Lists // TypeDefIndex: 56051
	{
		// Methods
		public static bool Equals<T>(List<T> left, List<T> right);
		public static int GetHashCode<T>(List<T> list);
	}

	public sealed class MapField<TKey, TValue> : IDeepCloneable<MapField<TKey, TValue>>, IDictionary<TKey, TValue>, IEquatable<MapField<TKey, TValue>>, IDictionary, IReadOnlyDictionary<TKey, TValue> // TypeDefIndex: 56057
	{
		// Fields
		private static readonly EqualityComparer<TValue> ValueEqualityComparer;
		private static readonly EqualityComparer<TKey> KeyEqualityComparer;
		private readonly Dictionary<TKey, LinkedListNode<KeyValuePair<TKey, TValue>>> map;
		private readonly LinkedList<KeyValuePair<TKey, TValue>> list;
	
		// Properties
		public TValue this[TKey key] { get => default; set {} }
		public ICollection<TKey> Keys { get; }
		public ICollection<TValue> Values { get; }
		public int Count { get; }
		public bool IsReadOnly { get; }
		bool IDictionary.IsFixedSize { get; }
		ICollection IDictionary.Keys { get; }
		ICollection IDictionary.Values { get; }
		bool ICollection.IsSynchronized { get; }
		object ICollection.SyncRoot { get; }
		object IDictionary.this[object key] { get => default; set {} }
		IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
		IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	
		// Nested types
		private class DictionaryEnumerator : IDictionaryEnumerator // TypeDefIndex: 56052
		{
			// Fields
			private readonly IEnumerator<KeyValuePair<TKey, TValue>> enumerator;
	
			// Properties
			public object Current { get; }
			public DictionaryEntry Entry { get; }
			public object Key { get; }
			public object Value { get; }
	
			// Constructors
			internal DictionaryEnumerator(IEnumerator<KeyValuePair<TKey, TValue>> enumerator);
	
			// Methods
			public bool MoveNext();
			public void Reset();
		}
	
		public sealed class Codec // TypeDefIndex: 56053
		{
			// Fields
			private readonly FieldCodec<TKey> keyCodec;
			private readonly FieldCodec<TValue> valueCodec;
			private readonly uint mapTag;
	
			// Properties
			internal FieldCodec<TKey> KeyCodec { get; }
			internal FieldCodec<TValue> ValueCodec { get; }
			internal uint MapTag { get; }
	
			// Constructors
			public Codec(FieldCodec<TKey> keyCodec, FieldCodec<TValue> valueCodec, uint mapTag);
		}
	
		private class MapView<T> : ICollection<T>, ICollection // TypeDefIndex: 56054
		{
			// Fields
			private readonly MapField<TKey, TValue> parent;
			private readonly Func<KeyValuePair<TKey, TValue>, T> projection;
			private readonly Func<T, bool> containsCheck;
	
			// Properties
			public int Count { get; }
			public bool IsReadOnly { get; }
			public bool IsSynchronized { get; }
			public object SyncRoot { get; }
	
			// Constructors
			internal MapView(MapField<TKey, TValue> parent, Func<KeyValuePair<TKey, TValue>, T> projection, Func<T, bool> containsCheck);
	
			// Methods
			public void Add(T item);
			public void Clear();
			public bool Contains(T item);
			public void CopyTo(T[] array, int arrayIndex);
			public IEnumerator<T> GetEnumerator();
			public bool Remove(T item);
			IEnumerator IEnumerable.GetEnumerator();
			public void CopyTo(Array array, int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 56055
		{
			// Fields
			public TValue value;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal bool _ContainsValue_b__0(KeyValuePair<TKey, TValue> pair);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56056
		{
			// Fields
			public static readonly __c<TKey, TValue> __9;
			public static Func<KeyValuePair<TKey, TValue>, TKey> __9__14_0;
			public static Func<KeyValuePair<TKey, TValue>, TValue> __9__16_0;
			public static Func<KeyValuePair<TKey, TValue>, DictionaryEntry> __9__43_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal TKey _get_Keys_b__14_0(KeyValuePair<TKey, TValue> pair);
			internal TValue _get_Values_b__16_0(KeyValuePair<TKey, TValue> pair);
			internal DictionaryEntry _System.Collections.ICollection.CopyTo_b__43_0(KeyValuePair<TKey, TValue> pair);
		}
	
		// Constructors
		public MapField();
		static MapField();
	
		// Methods
		public MapField<TKey, TValue> Clone();
		public void Add(TKey key, TValue value);
		public bool ContainsKey(TKey key);
		private bool ContainsValue(TValue value);
		public bool Remove(TKey key);
		public bool TryGetValue(TKey key, out ref TValue value);
		public void Add(IDictionary<TKey, TValue> entries);
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item);
		public void Clear();
		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item);
		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex);
		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item);
		public override bool Equals(object other);
		public override int GetHashCode();
		public bool Equals(MapField<TKey, TValue> other);
		public void AddEntriesFrom(CodedInputStream input, Codec codec);
		public void AddEntriesFrom(ref ParseContext ctx, Codec codec);
		public void WriteTo(CodedOutputStream output, Codec codec);
		public void WriteTo(ref WriteContext ctx, Codec codec);
		public int CalculateSize(Codec codec);
		private static int CalculateEntrySize(Codec codec, KeyValuePair<TKey, TValue> entry);
		public override string ToString();
		void IDictionary.Add(object key, object value);
		bool IDictionary.Contains(object key);
		IDictionaryEnumerator IDictionary.GetEnumerator();
		void IDictionary.Remove(object key);
		void ICollection.CopyTo(Array array, int index);
	}

	public static class ProtobufEqualityComparers // TypeDefIndex: 56062
	{
		// Fields
		[CompilerGenerated]
		private static readonly EqualityComparer<double> _BitwiseDoubleEqualityComparer_k__BackingField; // 0x00
		[CompilerGenerated]
		private static readonly EqualityComparer<float> _BitwiseSingleEqualityComparer_k__BackingField; // 0x08
		[CompilerGenerated]
		private static readonly EqualityComparer<double?> _BitwiseNullableDoubleEqualityComparer_k__BackingField; // 0x10
		[CompilerGenerated]
		private static readonly EqualityComparer<float?> _BitwiseNullableSingleEqualityComparer_k__BackingField; // 0x18
	
		// Properties
		public static EqualityComparer<double> BitwiseDoubleEqualityComparer { [CompilerGenerated] get; } // 0x0000000189B22184-0x0000000189B221D4 
		public static EqualityComparer<float> BitwiseSingleEqualityComparer { [CompilerGenerated] get; } // 0x0000000189B22274-0x0000000189B222C4 
		public static EqualityComparer<double?> BitwiseNullableDoubleEqualityComparer { [CompilerGenerated] get; } // 0x0000000189B221D4-0x0000000189B22224 
		public static EqualityComparer<float?> BitwiseNullableSingleEqualityComparer { [CompilerGenerated] get; } // 0x0000000189B22224-0x0000000189B22274 
	
		// Nested types
		private class BitwiseDoubleEqualityComparerImpl : EqualityComparer<double> // TypeDefIndex: 56058
		{
			// Constructors
			public BitwiseDoubleEqualityComparerImpl(); // 0x00000001849DEDE0-0x00000001849DEE10
	
			// Methods
			public override bool Equals(double x, double y); // 0x0000000189B1B6B8-0x0000000189B1B714
			public override int GetHashCode(double obj); // 0x0000000189B1B714-0x0000000189B1B76C
		}
	
		private class BitwiseSingleEqualityComparerImpl : EqualityComparer<float> // TypeDefIndex: 56059
		{
			// Constructors
			public BitwiseSingleEqualityComparerImpl(); // 0x00000001849DEDB0-0x00000001849DEDE0
	
			// Methods
			public override bool Equals(float x, float y); // 0x0000000189B1BA34-0x0000000189B1BAA0
			public override int GetHashCode(float obj); // 0x0000000189B1BAA0-0x0000000189B1BAF4
		}
	
		private class BitwiseNullableDoubleEqualityComparerImpl : EqualityComparer<double?> // TypeDefIndex: 56060
		{
			// Constructors
			public BitwiseNullableDoubleEqualityComparerImpl(); // 0x00000001849DED80-0x00000001849DEDB0
	
			// Methods
			public override bool Equals(double? x, double? y); // 0x0000000189B1B76C-0x0000000189B1B834
			public override int GetHashCode(double? obj); // 0x0000000189B1B834-0x0000000189B1B8CC
		}
	
		private class BitwiseNullableSingleEqualityComparerImpl : EqualityComparer<float?> // TypeDefIndex: 56061
		{
			// Constructors
			public BitwiseNullableSingleEqualityComparerImpl(); // 0x00000001849DED50-0x00000001849DED80
	
			// Methods
			public override bool Equals(float? x, float? y); // 0x0000000189B1B8CC-0x0000000189B1B99C
			public override int GetHashCode(float? obj); // 0x0000000189B1B99C-0x0000000189B1BA34
		}
	
		// Constructors
		static ProtobufEqualityComparers(); // 0x00000001849DEBD0-0x00000001849DED50
	
		// Methods
		public static EqualityComparer<T> GetEqualityComparer<T>();
	}

	internal sealed class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue> // TypeDefIndex: 56063
	{
		// Fields
		private readonly IDictionary<TKey, TValue> wrapped;
	
		// Properties
		public ICollection<TKey> Keys { get; }
		public ICollection<TValue> Values { get; }
		public TValue this[TKey key] { get => default; set {} }
		public int Count { get; }
		public bool IsReadOnly { get; }
	
		// Constructors
		public ReadOnlyDictionary(IDictionary<TKey, TValue> wrapped);
	
		// Methods
		public void Add(TKey key, TValue value);
		public bool ContainsKey(TKey key);
		public bool Remove(TKey key);
		public bool TryGetValue(TKey key, out ref TValue value);
		public void Add(KeyValuePair<TKey, TValue> item);
		public void Clear();
		public bool Contains(KeyValuePair<TKey, TValue> item);
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex);
		public bool Remove(KeyValuePair<TKey, TValue> item);
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public override bool Equals(object obj);
		public override int GetHashCode();
		public override string ToString();
	}

	public sealed class RepeatedField<T> : IList<T>, IList, IDeepCloneable<RepeatedField<T>>, IEquatable<RepeatedField<T>>, IReadOnlyList<T> // TypeDefIndex: 56065
	{
		// Fields
		private static readonly EqualityComparer<T> EqualityComparer;
		private static readonly T[] EmptyArray;
		private const int MinArraySize = 8; // Metadata: 0x02347869
		private T[] array;
		private int count;
	
		// Properties
		public int Capacity { get; set; }
		public int Count { get; }
		public bool IsReadOnly { get; }
		public T this[int index] { get => default; set {} }
		bool IList.IsFixedSize { get; }
		bool ICollection.IsSynchronized { get; }
		object ICollection.SyncRoot { get; }
		object IList.this[int index] { get => default; set {} }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__29 : IEnumerator<T> // TypeDefIndex: 56064
		{
			// Fields
			private int __1__state;
			private T __2__current;
			public RepeatedField<T> __4__this;
			private int _i_5__2;
	
			// Properties
			T IEnumerator<T>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetEnumerator_d__29(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public RepeatedField();
		static RepeatedField();
	
		// Methods
		public RepeatedField<T> Clone();
		public void AddEntriesFrom(CodedInputStream input, FieldCodec<T> codec);
		public void AddEntriesFrom(ref ParseContext ctx, FieldCodec<T> codec);
		public int CalculateSize(FieldCodec<T> codec);
		private int CalculatePackedDataSize(FieldCodec<T> codec);
		public void WriteTo(CodedOutputStream output, FieldCodec<T> codec);
		public void WriteTo(ref WriteContext ctx, FieldCodec<T> codec);
		private void EnsureSize(int size);
		private void SetSize(int size);
		public void SetCount(int newCount);
		public void Add(T item);
		public void Clear();
		public bool Contains(T item);
		public void CopyTo(T[] array, int arrayIndex);
		public bool Remove(T item);
		public void AddRange(IEnumerable<T> values);
		public void Add(IEnumerable<T> values);
		[IteratorStateMachine(typeof(_GetEnumerator_d__29))]
		public IEnumerator<T> GetEnumerator();
		public override bool Equals(object obj);
		IEnumerator IEnumerable.GetEnumerator();
		public override int GetHashCode();
		public bool Equals(RepeatedField<T> other);
		public int IndexOf(T item);
		public void Insert(int index, T item);
		public void RemoveAt(int index);
		public override string ToString();
		void ICollection.CopyTo(Array array, int index);
		int IList.Add(object value);
		bool IList.Contains(object value);
		int IList.IndexOf(object value);
		void IList.Insert(int index, object value);
		void IList.Remove(object value);
	}
}

namespace Google.Protobuf.Compatibility
{
	internal static class PropertyInfoExtensions // TypeDefIndex: 56049
	{
		// Extension methods
		internal static MethodInfo GetGetMethod(this PropertyInfo target); // 0x0000000189B220E4-0x0000000189B22134
		internal static MethodInfo GetSetMethod(this PropertyInfo target); // 0x0000000189B22134-0x0000000189B22184
	}

	internal static class TypeExtensions // TypeDefIndex: 56050
	{
		// Extension methods
		internal static bool IsAssignableFrom(this System.Type target, System.Type c); // 0x0000000189B23E44-0x0000000189B23EA0
		[UnconditionalSuppressMessage("Trimming", "IL2072", Justification = "The BaseType of the target will have all properties because of the annotation.")]
		internal static PropertyInfo GetProperty([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] this System.Type target, string name); // 0x0000000189B23D30-0x0000000189B23E44
		[UnconditionalSuppressMessage("Trimming", "IL2072", Justification = "The BaseType of the target will have all properties because of the annotation.")]
		internal static MethodInfo GetMethod([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] this System.Type target, string name); // 0x0000000189B23C78-0x0000000189B23D30
	}
}

namespace Google.Protobuf.Reflection
{
	public sealed class CustomOptions // TypeDefIndex: 55916
	{
		// Fields
		private const string UnreferencedCodeMessage = "CustomOptions is incompatible with trimming."; // Metadata: 0x0234777C
		private static readonly object[] EmptyParameters; // 0x00
		private readonly IDictionary<int, IExtensionValue> values; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__19<T> // TypeDefIndex: 55915
			where T : class, IMessage, new()
		{
			// Fields
			public static readonly __c__19<T> __9;
			public static Func<T, ByteString> __9__19_0;
			public static Func<T, ByteString, T> __9__19_1;
	
			// Constructors
			static __c__19();
			public __c__19();
	
			// Methods
			internal ByteString _TryGetMessage_b__19_0(T v);
			internal T _TryGetMessage_b__19_1(T t, ByteString b);
		}
	
		// Constructors
		internal CustomOptions(IDictionary<int, IExtensionValue> values); // 0x00000001853908C0-0x00000001853908D0
		static CustomOptions(); // 0x0000000189AF67B4-0x0000000189AF6818
	
		// Methods
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetBool(int field, out bool value); // 0x0000000189AF63CC-0x0000000189AF6424
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetInt32(int field, out int value); // 0x0000000189AF653C-0x0000000189AF6594
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetInt64(int field, out long value); // 0x0000000189AF6594-0x0000000189AF65EC
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetFixed32(int field, out uint value); // 0x0000000189AF64D4-0x0000000189AF64DC
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetFixed64(int field, out ulong value); // 0x0000000189AF64DC-0x0000000189AF64E4
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetSFixed32(int field, out int value); // 0x0000000189AF65EC-0x0000000189AF65F4
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetSFixed64(int field, out long value); // 0x0000000189AF65F4-0x0000000189AF65FC
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetSInt32(int field, out int value); // 0x0000000189AF65FC-0x0000000189AF6654
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetSInt64(int field, out long value); // 0x0000000189AF6654-0x0000000189AF66AC
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetUInt32(int field, out uint value); // 0x0000000189AF6704-0x0000000189AF675C
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetUInt64(int field, out ulong value); // 0x0000000189AF675C-0x0000000189AF67B4
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetFloat(int field, out float value); // 0x0000000189AF64E4-0x0000000189AF653C
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetDouble(int field, out double value); // 0x0000000189AF647C-0x0000000189AF64D4
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetString(int field, out string value); // 0x0000000189AF66AC-0x0000000189AF6704
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetBytes(int field, out ByteString value); // 0x0000000189AF6424-0x0000000189AF647C
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		public bool TryGetMessage<T>(int field, out ref T value)
			where T : class, IMessage, new();
		[RequiresUnreferencedCode("CustomOptions is incompatible with trimming.")]
		private bool TryGetPrimitiveValue<T>(int field, out ref T value);
	}

	public static class DescriptorReflection // TypeDefIndex: 55917
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000189AFB72C-0x0000000189AFB77C 
	
		// Constructors
		static DescriptorReflection(); // 0x0000000189AF8150-0x0000000189AFB72C
	}

	public sealed class FileDescriptorSet : IMessage<FileDescriptorSet>, IBufferMessage // TypeDefIndex: 55919
	{
		// Fields
		private static readonly MessageParser<FileDescriptorSet> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int FileFieldNumber = 1; // Metadata: 0x023477A9
		private static readonly FieldCodec<FileDescriptorProto> _repeated_file_codec; // 0x08
		private readonly RepeatedField<FileDescriptorProto> file_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FileDescriptorSet> Parser { get; } // 0x0000000189B03C90-0x0000000189B03CE0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B03C30-0x0000000189B03C90 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B03E54-0x0000000189B03E94 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FileDescriptorProto> File { get; } // 0x000000018385B100-0x000000018385B110 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55918
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B081BC-0x0000000189B08220
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal FileDescriptorSet _.cctor_b__27_0(); // 0x0000000189B0758C-0x0000000189B075DC
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileDescriptorSet(); // 0x0000000189B03BB8-0x0000000189B03C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileDescriptorSet(FileDescriptorSet other); // 0x0000000189B03B30-0x0000000189B03BB8
		static FileDescriptorSet(); // 0x0000000189B039C0-0x0000000189B03B30
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileDescriptorSet Clone(); // 0x0000000189B037BC-0x0000000189B0381C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B0381C-0x0000000189B03880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FileDescriptorSet other); // 0x0000000189B03880-0x0000000189B038FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018638F5B8-0x000000018638F608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B03974-0x0000000189B039C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B03DB0-0x0000000189B03E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B03728-0x0000000189B037BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FileDescriptorSet other); // 0x0000000189B038FC-0x0000000189B03974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B03CE0-0x0000000189B03DB0
	}

	public sealed class FileDescriptorProto : IMessage<FileDescriptorProto>, IBufferMessage // TypeDefIndex: 55921
	{
		// Fields
		private static readonly MessageParser<FileDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x023477AA
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x18
		public const int PackageFieldNumber = 2; // Metadata: 0x023477AB
		private static readonly string PackageDefaultValue; // 0x10
		private string package_; // 0x20
		public const int DependencyFieldNumber = 3; // Metadata: 0x023477AC
		private static readonly FieldCodec<string> _repeated_dependency_codec; // 0x18
		private readonly RepeatedField<string> dependency_; // 0x28
		public const int PublicDependencyFieldNumber = 10; // Metadata: 0x023477AD
		private static readonly FieldCodec<int> _repeated_publicDependency_codec; // 0x20
		private readonly RepeatedField<int> publicDependency_; // 0x30
		public const int WeakDependencyFieldNumber = 11; // Metadata: 0x023477AE
		private static readonly FieldCodec<int> _repeated_weakDependency_codec; // 0x28
		private readonly RepeatedField<int> weakDependency_; // 0x38
		public const int MessageTypeFieldNumber = 4; // Metadata: 0x023477AF
		private static readonly FieldCodec<DescriptorProto> _repeated_messageType_codec; // 0x30
		private readonly RepeatedField<DescriptorProto> messageType_; // 0x40
		public const int EnumTypeFieldNumber = 5; // Metadata: 0x023477B0
		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; // 0x38
		private readonly RepeatedField<EnumDescriptorProto> enumType_; // 0x48
		public const int ServiceFieldNumber = 6; // Metadata: 0x023477B1
		private static readonly FieldCodec<ServiceDescriptorProto> _repeated_service_codec; // 0x40
		private readonly RepeatedField<ServiceDescriptorProto> service_; // 0x50
		public const int ExtensionFieldNumber = 7; // Metadata: 0x023477B2
		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec; // 0x48
		private readonly RepeatedField<FieldDescriptorProto> extension_; // 0x58
		public const int OptionsFieldNumber = 8; // Metadata: 0x023477B3
		private Google.Protobuf.Reflection.FileOptions options_; // 0x60
		public const int SourceCodeInfoFieldNumber = 9; // Metadata: 0x023477B4
		private SourceCodeInfo sourceCodeInfo_; // 0x68
		public const int SyntaxFieldNumber = 12; // Metadata: 0x023477B5
		private static readonly string SyntaxDefaultValue; // 0x50
		private string syntax_; // 0x70
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FileDescriptorProto> Parser { get; } // 0x0000000189B02E60-0x0000000189B02EB0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B02D4C-0x0000000189B02DAC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B035B0-0x0000000189B035F0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x0000000189B02DB8-0x0000000189B02E0C 0x0000000189B035F0-0x0000000189B03658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get; } // 0x00000001867B9E50-0x00000001867B9E5C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Package { get; set; } // 0x0000000189B02E0C-0x0000000189B02E60 0x0000000189B03658-0x0000000189B036C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPackage { get; } // 0x0000000189B00070-0x0000000189B0007C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Dependency { get; } // 0x0000000184D86240-0x0000000184D86250 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PublicDependency { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WeakDependency { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DescriptorProto> MessageType { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnumDescriptorProto> EnumType { get; } // 0x0000000184D86200-0x0000000184D86210 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ServiceDescriptorProto> Service { get; } // 0x0000000184D86270-0x0000000184D86280 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FieldDescriptorProto> Extension { get; } // 0x0000000182E56440-0x0000000182E56460 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Google.Protobuf.Reflection.FileOptions Options { get; set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceCodeInfo SourceCodeInfo { get; set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Syntax { get; set; } // 0x0000000189B02EB0-0x0000000189B02F04 0x0000000189B036C0-0x0000000189B03728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSyntax { get; } // 0x0000000189B02DAC-0x0000000189B02DB8 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55920
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B07BE0-0x0000000189B07C44
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal FileDescriptorProto _.cctor_b__94_0(); // 0x0000000189B07A00-0x0000000189B07A50
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileDescriptorProto(); // 0x0000000189B02B24-0x0000000189B02D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileDescriptorProto(FileDescriptorProto other); // 0x0000000189B028F4-0x0000000189B02B24
		static FileDescriptorProto(); // 0x0000000189B02510-0x0000000189B028F4
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileDescriptorProto Clone(); // 0x0000000189B01D78-0x0000000189B01DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName(); // 0x0000000185390C40-0x0000000185390C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPackage(); // 0x0000000189AFF598-0x0000000189AFF5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSyntax(); // 0x0000000189B01D64-0x0000000189B01D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B01DD8-0x0000000189B01E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FileDescriptorProto other); // 0x0000000189B01E3C-0x0000000189B02090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B02090-0x0000000189B02234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B024C4-0x0000000189B02510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B032E8-0x0000000189B035B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B01A84-0x0000000189B01D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FileDescriptorProto other); // 0x0000000189B02234-0x0000000189B024C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B02F04-0x0000000189B032E8
	}

	public sealed class DescriptorProto : IMessage<DescriptorProto>, IBufferMessage // TypeDefIndex: 55928
	{
		// Fields
		private static readonly MessageParser<DescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x023477B6
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x18
		public const int FieldFieldNumber = 2; // Metadata: 0x023477B7
		private static readonly FieldCodec<FieldDescriptorProto> _repeated_field_codec; // 0x10
		private readonly RepeatedField<FieldDescriptorProto> field_; // 0x20
		public const int ExtensionFieldNumber = 6; // Metadata: 0x023477B8
		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec; // 0x18
		private readonly RepeatedField<FieldDescriptorProto> extension_; // 0x28
		public const int NestedTypeFieldNumber = 3; // Metadata: 0x023477B9
		private static readonly FieldCodec<DescriptorProto> _repeated_nestedType_codec; // 0x20
		private readonly RepeatedField<DescriptorProto> nestedType_; // 0x30
		public const int EnumTypeFieldNumber = 4; // Metadata: 0x023477BA
		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; // 0x28
		private readonly RepeatedField<EnumDescriptorProto> enumType_; // 0x38
		public const int ExtensionRangeFieldNumber = 5; // Metadata: 0x023477BB
		private static readonly FieldCodec<Types.ExtensionRange> _repeated_extensionRange_codec; // 0x30
		private readonly RepeatedField<Types.ExtensionRange> extensionRange_; // 0x40
		public const int OneofDeclFieldNumber = 8; // Metadata: 0x023477BC
		private static readonly FieldCodec<OneofDescriptorProto> _repeated_oneofDecl_codec; // 0x38
		private readonly RepeatedField<OneofDescriptorProto> oneofDecl_; // 0x48
		public const int OptionsFieldNumber = 7; // Metadata: 0x023477BD
		private MessageOptions options_; // 0x50
		public const int ReservedRangeFieldNumber = 9; // Metadata: 0x023477BE
		private static readonly FieldCodec<Types.ReservedRange> _repeated_reservedRange_codec; // 0x40
		private readonly RepeatedField<Types.ReservedRange> reservedRange_; // 0x58
		public const int ReservedNameFieldNumber = 10; // Metadata: 0x023477BF
		private static readonly FieldCodec<string> _repeated_reservedName_codec; // 0x48
		private readonly RepeatedField<string> reservedName_; // 0x60
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DescriptorProto> Parser { get; } // 0x0000000189AF7A74-0x0000000189AF7AC4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AF79C0-0x0000000189AF7A20 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AF80A8-0x0000000189AF80E8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x0000000189AF7A20-0x0000000189AF7A74 0x0000000189AF80E8-0x0000000189AF8150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get; } // 0x00000001867B9E50-0x00000001867B9E5C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FieldDescriptorProto> Field { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FieldDescriptorProto> Extension { get; } // 0x0000000184D86240-0x0000000184D86250 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DescriptorProto> NestedType { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnumDescriptorProto> EnumType { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Types.ExtensionRange> ExtensionRange { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneofDescriptorProto> OneofDecl { get; } // 0x0000000184D86200-0x0000000184D86210 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageOptions Options { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Types.ReservedRange> ReservedRange { get; } // 0x0000000182E56440-0x0000000182E56460 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ReservedName { get; } // 0x0000000184D86280-0x0000000184D86290 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 55926
		{
			// Nested types
			public sealed class ExtensionRange : IMessage<ExtensionRange>, IBufferMessage // TypeDefIndex: 55923
			{
				// Fields
				private static readonly MessageParser<ExtensionRange> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				private int _hasBits0; // 0x18
				public const int StartFieldNumber = 1; // Metadata: 0x023477C0
				private static readonly int StartDefaultValue; // 0x08
				private int start_; // 0x1C
				public const int EndFieldNumber = 2; // Metadata: 0x023477C1
				private static readonly int EndDefaultValue; // 0x0C
				private int end_; // 0x20
				public const int OptionsFieldNumber = 3; // Metadata: 0x023477C2
				private ExtensionRangeOptions options_; // 0x28
	
				// Properties
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ExtensionRange> Parser { get; } // 0x0000000189AFF0B0-0x0000000189AFF100 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor Descriptor { get; } // 0x0000000189AFEFF4-0x0000000189AFF054 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AFF318-0x0000000189AFF358 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Start { get; set; } // 0x0000000189AFF100-0x0000000189AFF154 0x0000000184DA0E10-0x0000000184DA0E20
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasStart { get; } // 0x000000018314ECE0-0x000000018314ECF0 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int End { get; set; } // 0x0000000189AFF054-0x0000000189AFF0A8 0x0000000184DA0E00-0x0000000184DA0E10
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasEnd { get; } // 0x0000000189AFF0A8-0x0000000189AFF0B0 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ExtensionRangeOptions Options { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
	
				// Nested types
				[Serializable]
				[CompilerGenerated]
				private sealed class __c // TypeDefIndex: 55922
				{
					// Fields
					public static readonly __c __9; // 0x00
	
					// Constructors
					static __c(); // 0x0000000189B07D70-0x0000000189B07DD4
					public __c(); // 0x00000001841E1670-0x00000001841E1680
	
					// Methods
					internal ExtensionRange _.cctor_b__46_0(); // 0x0000000189B07884-0x0000000189B078C0
				}
	
				// Constructors
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ExtensionRange(); // 0x00000001841E1670-0x00000001841E1680
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ExtensionRange(ExtensionRange other); // 0x0000000189AFEF80-0x0000000189AFEFF4
				static ExtensionRange(); // 0x0000000189AFEE54-0x0000000189AFEF80
	
				// Methods
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ExtensionRange Clone(); // 0x0000000189AFEB5C-0x0000000189AFEBBC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearStart(); // 0x0000000184D86DE0-0x0000000184D86DF0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearEnd(); // 0x0000000184DA0DF0-0x0000000184DA0E00
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other); // 0x0000000189AFEC48-0x0000000189AFECAC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(ExtensionRange other); // 0x0000000189AFEBBC-0x0000000189AFEC48
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode(); // 0x0000000189AFECAC-0x0000000189AFED1C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString(); // 0x0000000189AFEE08-0x0000000189AFEE54
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189AFF270-0x0000000189AFF318
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize(); // 0x0000000189AFEA8C-0x0000000189AFEB5C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(ExtensionRange other); // 0x0000000189AFED1C-0x0000000189AFEE08
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AFF154-0x0000000189AFF270
			}
	
			public sealed class ReservedRange : IMessage<ReservedRange>, IBufferMessage // TypeDefIndex: 55925
			{
				// Fields
				private static readonly MessageParser<ReservedRange> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				private int _hasBits0; // 0x18
				public const int StartFieldNumber = 1; // Metadata: 0x023477C3
				private static readonly int StartDefaultValue; // 0x08
				private int start_; // 0x1C
				public const int EndFieldNumber = 2; // Metadata: 0x023477C4
				private static readonly int EndDefaultValue; // 0x0C
				private int end_; // 0x20
	
				// Properties
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ReservedRange> Parser { get; } // 0x0000000189B05D84-0x0000000189B05DD4 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor Descriptor { get; } // 0x0000000189B05CCC-0x0000000189B05D30 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B05F4C-0x0000000189B05F8C 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Start { get; set; } // 0x0000000189B05DD4-0x0000000189B05E28 0x0000000184DA0E10-0x0000000184DA0E20
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasStart { get; } // 0x000000018314ECE0-0x000000018314ECF0 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int End { get; set; } // 0x0000000189B05D30-0x0000000189B05D84 0x0000000184DA0E00-0x0000000184DA0E10
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasEnd { get; } // 0x0000000189AFF0A8-0x0000000189AFF0B0 
	
				// Nested types
				[Serializable]
				[CompilerGenerated]
				private sealed class __c // TypeDefIndex: 55924
				{
					// Fields
					public static readonly __c __9; // 0x00
	
					// Constructors
					static __c(); // 0x0000000189B07A50-0x0000000189B07AB4
					public __c(); // 0x00000001841E1670-0x00000001841E1680
	
					// Methods
					internal ReservedRange _.cctor_b__41_0(); // 0x0000000189B07848-0x0000000189B07884
				}
	
				// Constructors
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ReservedRange(); // 0x00000001841E1670-0x00000001841E1680
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ReservedRange(ReservedRange other); // 0x000000018637A38C-0x000000018637A3D4
				static ReservedRange(); // 0x0000000189B05BA0-0x0000000189B05CCC
	
				// Methods
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ReservedRange Clone(); // 0x0000000189B05954-0x0000000189B059B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearStart(); // 0x0000000184D86DE0-0x0000000184D86DF0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearEnd(); // 0x0000000184DA0DF0-0x0000000184DA0E00
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other); // 0x0000000189B059B4-0x0000000189B05A18
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(ReservedRange other); // 0x0000000189B05A18-0x0000000189B05A90
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode(); // 0x0000000189B05A90-0x0000000189B05AE8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString(); // 0x0000000189B05B54-0x0000000189B05BA0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B05EC4-0x0000000189B05F4C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize(); // 0x0000000189B058A8-0x0000000189B05954
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(ReservedRange other); // 0x0000000189B05AE8-0x0000000189B05B54
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B05E28-0x0000000189B05EC4
			}
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55927
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B07AB4-0x0000000189B07B18
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal DescriptorProto _.cctor_b__77_0(); // 0x0000000189B079B0-0x0000000189B07A00
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DescriptorProto(); // 0x0000000189AF774C-0x0000000189AF79C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DescriptorProto(DescriptorProto other); // 0x0000000189AF7540-0x0000000189AF774C
		static DescriptorProto(); // 0x0000000189AF7134-0x0000000189AF7540
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DescriptorProto Clone(); // 0x0000000189AF6AB8-0x0000000189AF6B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName(); // 0x0000000185390C40-0x0000000185390C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AF6D24-0x0000000189AF6D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DescriptorProto other); // 0x0000000189AF6B18-0x0000000189AF6D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189AF6D88-0x0000000189AF6ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AF70E8-0x0000000189AF7134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189AF7E24-0x0000000189AF80A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AF6818-0x0000000189AF6AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DescriptorProto other); // 0x0000000189AF6ED4-0x0000000189AF70E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AF7AC4-0x0000000189AF7E24
	}

	public sealed class ExtensionRangeOptions : IExtendableMessage<ExtensionRangeOptions>, IBufferMessage // TypeDefIndex: 55930
	{
		// Fields
		private static readonly MessageParser<ExtensionRangeOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<ExtensionRangeOptions> _extensions; // 0x18
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x023477C5
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x20
	
		// Properties
		private ExtensionSet<ExtensionRangeOptions> _Extensions { get; } // 0x000000018385B100-0x000000018385B110 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExtensionRangeOptions> Parser { get; } // 0x0000000189AFE834-0x0000000189AFE884 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AFE7D4-0x0000000189AFE834 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AFEA4C-0x0000000189AFEA8C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55929
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B07DD4-0x0000000189B07E38
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal ExtensionRangeOptions _.cctor_b__37_0(); // 0x0000000189B077F8-0x0000000189B07848
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtensionRangeOptions(); // 0x0000000189AFE75C-0x0000000189AFE7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtensionRangeOptions(ExtensionRangeOptions other); // 0x0000000189AFE6AC-0x0000000189AFE75C
		static ExtensionRangeOptions(); // 0x0000000189AFE53C-0x0000000189AFE6AC
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtensionRangeOptions Clone(); // 0x0000000189AFE29C-0x0000000189AFE2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AFE38C-0x0000000189AFE3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExtensionRangeOptions other); // 0x0000000189AFE2FC-0x0000000189AFE38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189AFE3F0-0x0000000189AFE458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AFE4F0-0x0000000189AFE53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189AFE984-0x0000000189AFEA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AFE1E0-0x0000000189AFE29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExtensionRangeOptions other); // 0x0000000189AFE458-0x0000000189AFE4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AFE884-0x0000000189AFE984
		public TValue GetExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension);
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension);
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension);
		public void SetExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension, TValue value);
		public bool HasExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension);
		public void ClearExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension);
		public void ClearExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension);
	}

	public sealed class FieldDescriptorProto : IMessage<FieldDescriptorProto>, IBufferMessage // TypeDefIndex: 55935
	{
		// Fields
		private static readonly MessageParser<FieldDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		private int _hasBits0; // 0x18
		public const int NameFieldNumber = 1; // Metadata: 0x023477C7
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x20
		public const int NumberFieldNumber = 3; // Metadata: 0x023477C8
		private static readonly int NumberDefaultValue; // 0x10
		private int number_; // 0x28
		public const int LabelFieldNumber = 4; // Metadata: 0x023477C9
		private static readonly Types.Label LabelDefaultValue; // 0x14
		private Types.Label label_; // 0x2C
		public const int TypeFieldNumber = 5; // Metadata: 0x023477CA
		private static readonly Types.Type TypeDefaultValue; // 0x18
		private Types.Type type_; // 0x30
		public const int TypeNameFieldNumber = 6; // Metadata: 0x023477CB
		private static readonly string TypeNameDefaultValue; // 0x20
		private string typeName_; // 0x38
		public const int ExtendeeFieldNumber = 2; // Metadata: 0x023477CC
		private static readonly string ExtendeeDefaultValue; // 0x28
		private string extendee_; // 0x40
		public const int DefaultValueFieldNumber = 7; // Metadata: 0x023477CD
		private static readonly string DefaultValueDefaultValue; // 0x30
		private string defaultValue_; // 0x48
		public const int OneofIndexFieldNumber = 9; // Metadata: 0x023477CE
		private static readonly int OneofIndexDefaultValue; // 0x38
		private int oneofIndex_; // 0x50
		public const int JsonNameFieldNumber = 10; // Metadata: 0x023477CF
		private static readonly string JsonNameDefaultValue; // 0x40
		private string jsonName_; // 0x58
		public const int OptionsFieldNumber = 8; // Metadata: 0x023477D0
		private Google.Protobuf.Reflection.FieldOptions options_; // 0x60
		public const int Proto3OptionalFieldNumber = 17; // Metadata: 0x023477D1
		private static readonly bool Proto3OptionalDefaultValue; // 0x48
		private bool proto3Optional_; // 0x68
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FieldDescriptorProto> Parser { get; } // 0x0000000189B00244-0x0000000189B00294 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AFFFA4-0x0000000189B00004 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B007D4-0x0000000189B00814 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x0000000189B00148-0x0000000189B0019C 0x0000000189B0094C-0x0000000189B009B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get; } // 0x0000000189B00070-0x0000000189B0007C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Number { get; set; } // 0x0000000189B0019C-0x0000000189B001F0 0x0000000184DA0E60-0x0000000184DA0E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasNumber { get; } // 0x000000018314ECE0-0x000000018314ECF0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.Label Label { get; set; } // 0x0000000189B000F4-0x0000000189B00148 0x0000000184DA0E50-0x0000000184DA0E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLabel { get; } // 0x0000000189AFF0A8-0x0000000189AFF0B0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.Type Type { get; set; } // 0x0000000189B0033C-0x0000000189B00390 0x0000000184DA0E90-0x0000000184DA0EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasType { get; } // 0x0000000189B00098-0x0000000189B000A0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TypeName { get; set; } // 0x0000000189B002E8-0x0000000189B0033C 0x0000000189B009B4-0x0000000189B00A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTypeName { get; } // 0x0000000189B0008C-0x0000000189B00098 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Extendee { get; set; } // 0x0000000189B00004-0x0000000189B00058 0x0000000189B0087C-0x0000000189B008E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasExtendee { get; } // 0x0000000189B00058-0x0000000189B00064 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DefaultValue { get; set; } // 0x0000000189AFFF50-0x0000000189AFFFA4 0x0000000189B00814-0x0000000189B0087C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDefaultValue { get; } // 0x00000001890BCB14-0x00000001890BCB20 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OneofIndex { get; set; } // 0x0000000189B001F0-0x0000000189B00244 0x0000000184DA0E70-0x0000000184DA0E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasOneofIndex { get; } // 0x0000000189B0007C-0x0000000189B00084 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string JsonName { get; set; } // 0x0000000189B000A0-0x0000000189B000F4 0x0000000189B008E4-0x0000000189B0094C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasJsonName { get; } // 0x0000000189B00064-0x0000000189B00070 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Google.Protobuf.Reflection.FieldOptions Options { get; set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Proto3Optional { get; set; } // 0x0000000189B00294-0x0000000189B002E8 0x0000000184DA0E80-0x0000000184DA0E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasProto3Optional { get; } // 0x0000000189B00084-0x0000000189B0008C 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 55933
		{
			// Nested types
			public enum Type // TypeDefIndex: 55931
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
	
			public enum Label // TypeDefIndex: 55932
			{
				Optional = 1,
				Required = 2,
				Repeated = 3
			}
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55934
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B07E38-0x0000000189B07E9C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal FieldDescriptorProto _.cctor_b__119_0(); // 0x0000000189B0744C-0x0000000189B07488
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldDescriptorProto(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldDescriptorProto(FieldDescriptorProto other); // 0x0000000189AFFE6C-0x0000000189AFFF50
		static FieldDescriptorProto(); // 0x0000000189AFFC04-0x0000000189AFFE6C
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldDescriptorProto Clone(); // 0x0000000189AFF5AC-0x0000000189AFF60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName(); // 0x0000000189AFF598-0x0000000189AFF5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearNumber(); // 0x0000000184D86DE0-0x0000000184D86DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLabel(); // 0x0000000184DA0DF0-0x0000000184DA0E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearType(); // 0x0000000184DA0E40-0x0000000184DA0E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTypeName(); // 0x000000018709F154-0x000000018709F168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearExtendee(); // 0x0000000189AFF570-0x0000000189AFF584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDefaultValue(); // 0x00000001870A7CA8-0x00000001870A7CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearOneofIndex(); // 0x0000000184DA0E20-0x0000000184DA0E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearJsonName(); // 0x0000000189AFF584-0x0000000189AFF598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearProto3Optional(); // 0x0000000184DA0E30-0x0000000184DA0E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AFF60C-0x0000000189AFF670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FieldDescriptorProto other); // 0x0000000189AFF670-0x0000000189AFF83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189AFF83C-0x0000000189AFF9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AFFBB8-0x0000000189AFFC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B005D0-0x0000000189B007D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AFF358-0x0000000189AFF570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FieldDescriptorProto other); // 0x0000000189AFF9EC-0x0000000189AFFBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B00390-0x0000000189B005D0
	}

	public sealed class OneofDescriptorProto : IMessage<OneofDescriptorProto>, IBufferMessage // TypeDefIndex: 55937
	{
		// Fields
		private static readonly MessageParser<OneofDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x023477E7
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x18
		public const int OptionsFieldNumber = 2; // Metadata: 0x023477E8
		private OneofOptions options_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneofDescriptorProto> Parser { get; } // 0x0000000189B04F98-0x0000000189B04FE8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B04EE4-0x0000000189B04F44 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B0515C-0x0000000189B0519C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x0000000189B04F44-0x0000000189B04F98 0x0000000189B0519C-0x0000000189B05204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get; } // 0x00000001867B9E50-0x00000001867B9E5C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneofOptions Options { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55936
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B07B7C-0x0000000189B07BE0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal OneofDescriptorProto _.cctor_b__36_0(); // 0x0000000189B0776C-0x0000000189B077A8
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneofDescriptorProto(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneofDescriptorProto(OneofDescriptorProto other); // 0x0000000189B04E70-0x0000000189B04EE4
		static OneofDescriptorProto(); // 0x0000000189B04D2C-0x0000000189B04E70
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneofDescriptorProto Clone(); // 0x0000000189B04A48-0x0000000189B04AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName(); // 0x0000000185390C40-0x0000000185390C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B04B2C-0x0000000189B04B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneofDescriptorProto other); // 0x0000000189B04AA8-0x0000000189B04B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B04B90-0x0000000189B04C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B04CE0-0x0000000189B04D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B050DC-0x0000000189B0515C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B049A0-0x0000000189B04A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneofDescriptorProto other); // 0x0000000189B04C04-0x0000000189B04CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B04FE8-0x0000000189B050DC
	}

	public sealed class EnumDescriptorProto : IMessage<EnumDescriptorProto>, IBufferMessage // TypeDefIndex: 55942
	{
		// Fields
		private static readonly MessageParser<EnumDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x023477E9
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x18
		public const int ValueFieldNumber = 2; // Metadata: 0x023477EA
		private static readonly FieldCodec<EnumValueDescriptorProto> _repeated_value_codec; // 0x10
		private readonly RepeatedField<EnumValueDescriptorProto> value_; // 0x20
		public const int OptionsFieldNumber = 3; // Metadata: 0x023477EB
		private EnumOptions options_; // 0x28
		public const int ReservedRangeFieldNumber = 4; // Metadata: 0x023477EC
		private static readonly FieldCodec<Types.EnumReservedRange> _repeated_reservedRange_codec; // 0x18
		private readonly RepeatedField<Types.EnumReservedRange> reservedRange_; // 0x30
		public const int ReservedNameFieldNumber = 5; // Metadata: 0x023477ED
		private static readonly FieldCodec<string> _repeated_reservedName_codec; // 0x20
		private readonly RepeatedField<string> reservedName_; // 0x38
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnumDescriptorProto> Parser { get; } // 0x0000000189AFC6A8-0x0000000189AFC6F8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AFC5F4-0x0000000189AFC654 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AFCA54-0x0000000189AFCA94 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x0000000189AFC654-0x0000000189AFC6A8 0x0000000189AFCA94-0x0000000189AFCAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get; } // 0x00000001867B9E50-0x00000001867B9E5C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnumValueDescriptorProto> Value { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumOptions Options { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Types.EnumReservedRange> ReservedRange { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ReservedName { get; } // 0x0000000184D85A50-0x0000000184D85A60 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 55940
		{
			// Nested types
			public sealed class EnumReservedRange : IMessage<EnumReservedRange>, IBufferMessage // TypeDefIndex: 55939
			{
				// Fields
				private static readonly MessageParser<EnumReservedRange> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				private int _hasBits0; // 0x18
				public const int StartFieldNumber = 1; // Metadata: 0x023477EE
				private static readonly int StartDefaultValue; // 0x08
				private int start_; // 0x1C
				public const int EndFieldNumber = 2; // Metadata: 0x023477EF
				private static readonly int EndDefaultValue; // 0x0C
				private int end_; // 0x20
	
				// Properties
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<EnumReservedRange> Parser { get; } // 0x0000000189B0CE94-0x0000000189B0CEE4 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor Descriptor { get; } // 0x0000000189B0CDE0-0x0000000189B0CE40 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B0CFC0-0x0000000189B0D000 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Start { get; set; } // 0x0000000189B0CEE4-0x0000000189B0CF38 0x0000000184DA0E10-0x0000000184DA0E20
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasStart { get; } // 0x000000018314ECE0-0x000000018314ECF0 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int End { get; set; } // 0x0000000189B0CE40-0x0000000189B0CE94 0x0000000184DA0E00-0x0000000184DA0E10
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasEnd { get; } // 0x0000000189AFF0A8-0x0000000189AFF0B0 
	
				// Nested types
				[Serializable]
				[CompilerGenerated]
				private sealed class __c // TypeDefIndex: 55938
				{
					// Fields
					public static readonly __c __9; // 0x00
	
					// Constructors
					static __c(); // 0x0000000189B1A180-0x0000000189B1A1E4
					public __c(); // 0x00000001841E1670-0x00000001841E1680
	
					// Methods
					internal EnumReservedRange _.cctor_b__41_0(); // 0x0000000189B1984C-0x0000000189B19888
				}
	
				// Constructors
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public EnumReservedRange(); // 0x00000001841E1670-0x00000001841E1680
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public EnumReservedRange(EnumReservedRange other); // 0x000000018637A38C-0x000000018637A3D4
				static EnumReservedRange(); // 0x0000000189B0CCB4-0x0000000189B0CDE0
	
				// Methods
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public EnumReservedRange Clone(); // 0x0000000189B0CA68-0x0000000189B0CAC8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearStart(); // 0x0000000184D86DE0-0x0000000184D86DF0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearEnd(); // 0x0000000184DA0DF0-0x0000000184DA0E00
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other); // 0x0000000189B0CAC8-0x0000000189B0CB2C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(EnumReservedRange other); // 0x0000000189B0CB2C-0x0000000189B0CBA4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode(); // 0x0000000189B0CBA4-0x0000000189B0CBFC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString(); // 0x0000000189B0CC68-0x0000000189B0CCB4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B0CF38-0x0000000189B0CFC0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize(); // 0x0000000189B0C9BC-0x0000000189B0CA68
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(EnumReservedRange other); // 0x0000000189B0CBFC-0x0000000189B0CC68
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B05E28-0x0000000189B05EC4
			}
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55941
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B19EC4-0x0000000189B19F28
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal EnumDescriptorProto _.cctor_b__52_0(); // 0x0000000189B19964-0x0000000189B199B4
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumDescriptorProto(); // 0x0000000189AFC3C8-0x0000000189AFC4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumDescriptorProto(EnumDescriptorProto other); // 0x0000000189AFC4D4-0x0000000189AFC5F4
		static EnumDescriptorProto(); // 0x0000000189AFC17C-0x0000000189AFC3C8
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumDescriptorProto Clone(); // 0x0000000189AFBD28-0x0000000189AFBD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName(); // 0x0000000185390C40-0x0000000185390C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AFBD88-0x0000000189AFBDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnumDescriptorProto other); // 0x0000000189AFBDEC-0x0000000189AFBF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189AFBF10-0x0000000189AFBFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AFC130-0x0000000189AFC17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189AFC8E4-0x0000000189AFCA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AFBBA0-0x0000000189AFBD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnumDescriptorProto other); // 0x0000000189AFBFDC-0x0000000189AFC130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AFC6F8-0x0000000189AFC8E4
	}

	public sealed class EnumValueDescriptorProto : IMessage<EnumValueDescriptorProto>, IBufferMessage // TypeDefIndex: 55944
	{
		// Fields
		private static readonly MessageParser<EnumValueDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		private int _hasBits0; // 0x18
		public const int NameFieldNumber = 1; // Metadata: 0x023477F0
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x20
		public const int NumberFieldNumber = 2; // Metadata: 0x023477F1
		private static readonly int NumberDefaultValue; // 0x10
		private int number_; // 0x28
		public const int OptionsFieldNumber = 3; // Metadata: 0x023477F2
		private EnumValueOptions options_; // 0x30
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnumValueDescriptorProto> Parser { get; } // 0x0000000189B0D6E0-0x0000000189B0D730 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B0D5D8-0x0000000189B0D638 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B0D8F8-0x0000000189B0D938 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x0000000189B0D638-0x0000000189B0D68C 0x0000000189B0D938-0x0000000189B0D9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get; } // 0x0000000189B00070-0x0000000189B0007C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Number { get; set; } // 0x0000000189B0D68C-0x0000000189B0D6E0 0x0000000184DA0E60-0x0000000184DA0E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasNumber { get; } // 0x000000018314ECE0-0x000000018314ECF0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValueOptions Options { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55943
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B1A0B8-0x0000000189B1A11C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal EnumValueDescriptorProto _.cctor_b__46_0(); // 0x0000000189B19888-0x0000000189B198C4
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValueDescriptorProto(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValueDescriptorProto(EnumValueDescriptorProto other); // 0x0000000189B0D558-0x0000000189B0D5D8
		static EnumValueDescriptorProto(); // 0x0000000189B0D3FC-0x0000000189B0D558
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValueDescriptorProto Clone(); // 0x0000000189B0D0D4-0x0000000189B0D134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName(); // 0x0000000189AFF598-0x0000000189AFF5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearNumber(); // 0x0000000184D86DE0-0x0000000184D86DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B0D134-0x0000000189B0D198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnumValueDescriptorProto other); // 0x0000000189B0D198-0x0000000189B0D234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B0D234-0x0000000189B0D2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B0D3B0-0x0000000189B0D3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B0D850-0x0000000189B0D8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B0D000-0x0000000189B0D0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnumValueDescriptorProto other); // 0x0000000189B0D2BC-0x0000000189B0D3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B0D730-0x0000000189B0D850
	}

	public sealed class ServiceDescriptorProto : IMessage<ServiceDescriptorProto>, IBufferMessage // TypeDefIndex: 55946
	{
		// Fields
		private static readonly MessageParser<ServiceDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x023477F3
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x18
		public const int MethodFieldNumber = 2; // Metadata: 0x023477F4
		private static readonly FieldCodec<MethodDescriptorProto> _repeated_method_codec; // 0x10
		private readonly RepeatedField<MethodDescriptorProto> method_; // 0x20
		public const int OptionsFieldNumber = 3; // Metadata: 0x023477F5
		private ServiceOptions options_; // 0x28
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ServiceDescriptorProto> Parser { get; } // 0x0000000189B1817C-0x0000000189B181CC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B180C8-0x0000000189B18128 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B18410-0x0000000189B18450 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x0000000189B18128-0x0000000189B1817C 0x0000000189B18450-0x0000000189B184B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get; } // 0x00000001867B9E50-0x00000001867B9E5C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MethodDescriptorProto> Method { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServiceOptions Options { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55945
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B1A2AC-0x0000000189B1A310
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal ServiceDescriptorProto _.cctor_b__41_0(); // 0x0000000189B197C0-0x0000000189B19810
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServiceDescriptorProto(); // 0x0000000189B17F8C-0x0000000189B18004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServiceDescriptorProto(ServiceDescriptorProto other); // 0x0000000189B18004-0x0000000189B180C8
		static ServiceDescriptorProto(); // 0x0000000189B17DE0-0x0000000189B17F8C
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServiceDescriptorProto Clone(); // 0x0000000189B17A80-0x0000000189B17AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName(); // 0x0000000185390C40-0x0000000185390C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B17BA4-0x0000000189B17C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ServiceDescriptorProto other); // 0x0000000189B17AE0-0x0000000189B17BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B17C08-0x0000000189B17C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B17D94-0x0000000189B17DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B18320-0x0000000189B18410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B17980-0x0000000189B17A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ServiceDescriptorProto other); // 0x0000000189B17C90-0x0000000189B17D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B181CC-0x0000000189B18320
	}

	public sealed class MethodDescriptorProto : IMessage<MethodDescriptorProto>, IBufferMessage // TypeDefIndex: 55948
	{
		// Fields
		private static readonly MessageParser<MethodDescriptorProto> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		private int _hasBits0; // 0x18
		public const int NameFieldNumber = 1; // Metadata: 0x023477F6
		private static readonly string NameDefaultValue; // 0x08
		private string name_; // 0x20
		public const int InputTypeFieldNumber = 2; // Metadata: 0x023477F7
		private static readonly string InputTypeDefaultValue; // 0x10
		private string inputType_; // 0x28
		public const int OutputTypeFieldNumber = 3; // Metadata: 0x023477F8
		private static readonly string OutputTypeDefaultValue; // 0x18
		private string outputType_; // 0x30
		public const int OptionsFieldNumber = 4; // Metadata: 0x023477F9
		private MethodOptions options_; // 0x38
		public const int ClientStreamingFieldNumber = 5; // Metadata: 0x023477FA
		private static readonly bool ClientStreamingDefaultValue; // 0x20
		private bool clientStreaming_; // 0x40
		public const int ServerStreamingFieldNumber = 6; // Metadata: 0x023477FB
		private static readonly bool ServerStreamingDefaultValue; // 0x21
		private bool serverStreaming_; // 0x41
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MethodDescriptorProto> Parser { get; } // 0x0000000189B1592C-0x0000000189B1597C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B157D0-0x0000000189B15830 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B15C7C-0x0000000189B15CBC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x0000000189B15884-0x0000000189B158D8 0x0000000189B15D24-0x0000000189B15D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName { get; } // 0x0000000189B00070-0x0000000189B0007C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string InputType { get; set; } // 0x0000000189B15830-0x0000000189B15884 0x0000000189B15CBC-0x0000000189B15D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasInputType { get; } // 0x00000001868C60A8-0x00000001868C60B4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OutputType { get; set; } // 0x0000000189B158D8-0x0000000189B1592C 0x0000000189B15D8C-0x0000000189B15DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasOutputType { get; } // 0x0000000189B11948-0x0000000189B11954 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MethodOptions Options { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ClientStreaming { get; set; } // 0x0000000189B1577C-0x0000000189B157D0 0x0000000184DA10B0-0x0000000184DA10C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasClientStreaming { get; } // 0x000000018314ECE0-0x000000018314ECF0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ServerStreaming { get; set; } // 0x0000000189B1597C-0x0000000189B159D0 0x0000000184DA10C0-0x0000000184DA10D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasServerStreaming { get; } // 0x0000000189AFF0A8-0x0000000189AFF0B0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55947
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B19C6C-0x0000000189B19CD0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal MethodDescriptorProto _.cctor_b__73_0(); // 0x0000000189B19AF4-0x0000000189B19B30
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MethodDescriptorProto(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MethodDescriptorProto(MethodDescriptorProto other); // 0x0000000189B156D0-0x0000000189B1577C
		static MethodDescriptorProto(); // 0x0000000189B15508-0x0000000189B156D0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MethodDescriptorProto Clone(); // 0x0000000189B15058-0x0000000189B150B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearName(); // 0x0000000189AFF598-0x0000000189AFF5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearInputType(); // 0x0000000189849400-0x0000000189849414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearOutputType(); // 0x00000001867B5A00-0x00000001867B5A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearClientStreaming(); // 0x0000000184D86DE0-0x0000000184D86DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearServerStreaming(); // 0x0000000184DA0DF0-0x0000000184DA0E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B151D0-0x0000000189B15234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MethodDescriptorProto other); // 0x0000000189B150B8-0x0000000189B151D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B15234-0x0000000189B15374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B154BC-0x0000000189B15508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B15B50-0x0000000189B15C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B14F40-0x0000000189B15058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MethodDescriptorProto other); // 0x0000000189B15374-0x0000000189B154BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B159D0-0x0000000189B15B50
	}

	public sealed class FileOptions : IExtendableMessage<Google.Protobuf.Reflection.FileOptions>, IBufferMessage // TypeDefIndex: 55952
	{
		// Fields
		private static readonly MessageParser<FileOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<FileOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int JavaPackageFieldNumber = 1; // Metadata: 0x023477FC
		private static readonly string JavaPackageDefaultValue; // 0x08
		private string javaPackage_; // 0x28
		public const int JavaOuterClassnameFieldNumber = 8; // Metadata: 0x023477FD
		private static readonly string JavaOuterClassnameDefaultValue; // 0x10
		private string javaOuterClassname_; // 0x30
		public const int JavaMultipleFilesFieldNumber = 10; // Metadata: 0x023477FE
		private static readonly bool JavaMultipleFilesDefaultValue; // 0x18
		private bool javaMultipleFiles_; // 0x38
		public const int JavaGenerateEqualsAndHashFieldNumber = 20; // Metadata: 0x023477FF
		private static readonly bool JavaGenerateEqualsAndHashDefaultValue; // 0x19
		private bool javaGenerateEqualsAndHash_; // 0x39
		public const int JavaStringCheckUtf8FieldNumber = 27; // Metadata: 0x02347800
		private static readonly bool JavaStringCheckUtf8DefaultValue; // 0x1A
		private bool javaStringCheckUtf8_; // 0x3A
		public const int OptimizeForFieldNumber = 9; // Metadata: 0x02347801
		private static readonly Types.OptimizeMode OptimizeForDefaultValue; // 0x1C
		private Types.OptimizeMode optimizeFor_; // 0x3C
		public const int GoPackageFieldNumber = 11; // Metadata: 0x02347802
		private static readonly string GoPackageDefaultValue; // 0x20
		private string goPackage_; // 0x40
		public const int CcGenericServicesFieldNumber = 16; // Metadata: 0x02347803
		private static readonly bool CcGenericServicesDefaultValue; // 0x28
		private bool ccGenericServices_; // 0x48
		public const int JavaGenericServicesFieldNumber = 17; // Metadata: 0x02347804
		private static readonly bool JavaGenericServicesDefaultValue; // 0x29
		private bool javaGenericServices_; // 0x49
		public const int PyGenericServicesFieldNumber = 18; // Metadata: 0x02347805
		private static readonly bool PyGenericServicesDefaultValue; // 0x2A
		private bool pyGenericServices_; // 0x4A
		public const int PhpGenericServicesFieldNumber = 42; // Metadata: 0x02347806
		private static readonly bool PhpGenericServicesDefaultValue; // 0x2B
		private bool phpGenericServices_; // 0x4B
		public const int DeprecatedFieldNumber = 23; // Metadata: 0x02347807
		private static readonly bool DeprecatedDefaultValue; // 0x2C
		private bool deprecated_; // 0x4C
		public const int CcEnableArenasFieldNumber = 31; // Metadata: 0x02347808
		private static readonly bool CcEnableArenasDefaultValue; // 0x2D
		private bool ccEnableArenas_; // 0x4D
		public const int ObjcClassPrefixFieldNumber = 36; // Metadata: 0x02347809
		private static readonly string ObjcClassPrefixDefaultValue; // 0x30
		private string objcClassPrefix_; // 0x50
		public const int CsharpNamespaceFieldNumber = 37; // Metadata: 0x0234780A
		private static readonly string CsharpNamespaceDefaultValue; // 0x38
		private string csharpNamespace_; // 0x58
		public const int SwiftPrefixFieldNumber = 39; // Metadata: 0x0234780B
		private static readonly string SwiftPrefixDefaultValue; // 0x40
		private string swiftPrefix_; // 0x60
		public const int PhpClassPrefixFieldNumber = 40; // Metadata: 0x0234780C
		private static readonly string PhpClassPrefixDefaultValue; // 0x48
		private string phpClassPrefix_; // 0x68
		public const int PhpNamespaceFieldNumber = 41; // Metadata: 0x0234780D
		private static readonly string PhpNamespaceDefaultValue; // 0x50
		private string phpNamespace_; // 0x70
		public const int PhpMetadataNamespaceFieldNumber = 44; // Metadata: 0x0234780E
		private static readonly string PhpMetadataNamespaceDefaultValue; // 0x58
		private string phpMetadataNamespace_; // 0x78
		public const int RubyPackageFieldNumber = 45; // Metadata: 0x0234780F
		private static readonly string RubyPackageDefaultValue; // 0x60
		private string rubyPackage_; // 0x80
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x02347810
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x68
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x88
	
		// Properties
		private ExtensionSet<FileOptions> _Extensions { get; } // 0x000000018385B100-0x000000018385B110 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FileOptions> Parser { get; } // 0x0000000189B11C30-0x0000000189B11C80 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B11888-0x0000000189B118E8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B12718-0x0000000189B12758 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string JavaPackage { get; set; } // 0x0000000189B11AE0-0x0000000189B11B34 0x0000000189B12890-0x0000000189B128F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasJavaPackage { get; } // 0x00000001868C60A8-0x00000001868C60B4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string JavaOuterClassname { get; set; } // 0x0000000189B11A8C-0x0000000189B11AE0 0x0000000189B12828-0x0000000189B12890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasJavaOuterClassname { get; } // 0x0000000189B11948-0x0000000189B11954 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JavaMultipleFiles { get; set; } // 0x0000000189B11A38-0x0000000189B11A8C 0x0000000184DA1040-0x0000000184DA1050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasJavaMultipleFiles { get; } // 0x0000000189B0C6D4-0x0000000189B0C6DC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[Obsolete]
		public bool JavaGenerateEqualsAndHash { get; set; } // 0x0000000189B11990-0x0000000189B119E4 0x0000000184DA1020-0x0000000184DA1030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[Obsolete]
		public bool HasJavaGenerateEqualsAndHash { get; } // 0x0000000189B0FC9C-0x0000000189B0FCA4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JavaStringCheckUtf8 { get; set; } // 0x0000000189B11B34-0x0000000189B11B88 0x0000000184DA1050-0x0000000184DA1060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasJavaStringCheckUtf8 { get; } // 0x0000000189B11954-0x0000000189B11960 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.OptimizeMode OptimizeFor { get; set; } // 0x0000000189B11BDC-0x0000000189B11C30 0x0000000184DA1060-0x0000000184DA1070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasOptimizeFor { get; } // 0x0000000189B0C6CC-0x0000000189B0C6D4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GoPackage { get; set; } // 0x0000000189B118E8-0x0000000189B1193C 0x0000000189B127C0-0x0000000189B12828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasGoPackage { get; } // 0x0000000189B00058-0x0000000189B00064 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CcGenericServices { get; set; } // 0x0000000189B1178C-0x0000000189B117E0 0x0000000184DA1000-0x0000000184DA1010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasCcGenericServices { get; } // 0x0000000189B0FC7C-0x0000000189B0FC84 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JavaGenericServices { get; set; } // 0x0000000189B119E4-0x0000000189B11A38 0x0000000184DA1030-0x0000000184DA1040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasJavaGenericServices { get; } // 0x0000000189B0FC8C-0x0000000189B0FC94 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PyGenericServices { get; set; } // 0x0000000189B11DD4-0x0000000189B11E28 0x0000000184DA1080-0x0000000184DA1090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPyGenericServices { get; } // 0x0000000189B0FC84-0x0000000189B0FC8C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PhpGenericServices { get; set; } // 0x0000000189B11CD4-0x0000000189B11D2C 0x0000000184DA1070-0x0000000184DA1080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPhpGenericServices { get; } // 0x000000018481D0E0-0x000000018481D0F0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deprecated { get; set; } // 0x0000000189B11834-0x0000000189B11888 0x0000000184DA1010-0x0000000184DA1020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDeprecated { get; } // 0x0000000189B0FC94-0x0000000189B0FC9C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CcEnableArenas { get; set; } // 0x0000000189B11734-0x0000000189B1178C 0x0000000184DA0FF0-0x0000000184DA1000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasCcEnableArenas { get; } // 0x0000000189B1193C-0x0000000189B11948 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ObjcClassPrefix { get; set; } // 0x0000000189B11B88-0x0000000189B11BDC 0x0000000189B128F8-0x0000000189B12960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasObjcClassPrefix { get; } // 0x00000001884774C8-0x00000001884774D4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CsharpNamespace { get; set; } // 0x0000000189B117E0-0x0000000189B11834 0x0000000189B12758-0x0000000189B127C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasCsharpNamespace { get; } // 0x0000000189B00064-0x0000000189B00070 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SwiftPrefix { get; set; } // 0x0000000189B11E80-0x0000000189B11ED4 0x0000000189B12B04-0x0000000189B12B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSwiftPrefix { get; } // 0x0000000189B11984-0x0000000189B11990 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PhpClassPrefix { get; set; } // 0x0000000189B11C80-0x0000000189B11CD4 0x0000000189B12960-0x0000000189B129C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPhpClassPrefix { get; } // 0x0000000189B11960-0x0000000189B1196C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PhpNamespace { get; set; } // 0x0000000189B11D80-0x0000000189B11DD4 0x0000000189B12A30-0x0000000189B12A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPhpNamespace { get; } // 0x0000000189B02DAC-0x0000000189B02DB8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PhpMetadataNamespace { get; set; } // 0x0000000189B11D2C-0x0000000189B11D80 0x0000000189B129C8-0x0000000189B12A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPhpMetadataNamespace { get; } // 0x0000000189B1196C-0x0000000189B11978 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RubyPackage { get; set; } // 0x0000000189B11E28-0x0000000189B11E80 0x0000000189B12A98-0x0000000189B12B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasRubyPackage { get; } // 0x0000000189B11978-0x0000000189B11984 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get; } // 0x0000000184D861F0-0x0000000184D86200 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 55950
		{
			// Nested types
			public enum OptimizeMode // TypeDefIndex: 55949
			{
				Speed = 1,
				CodeSize = 2,
				LiteRuntime = 3
			}
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55951
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B1A1E4-0x0000000189B1A248
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal FileOptions _.cctor_b__219_0(); // 0x0000000189B19680-0x0000000189B196D0
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileOptions(); // 0x0000000189B11504-0x0000000189B11580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileOptions(FileOptions other); // 0x0000000189B11580-0x0000000189B11734
		static FileOptions(); // 0x0000000189B110F0-0x0000000189B11504
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FileOptions Clone(); // 0x0000000189B10618-0x0000000189B10678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearJavaPackage(); // 0x0000000189849400-0x0000000189849414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearJavaOuterClassname(); // 0x00000001867B5A00-0x00000001867B5A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearJavaMultipleFiles(); // 0x0000000184DA0ED0-0x0000000184DA0EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[Obsolete]
		public void ClearJavaGenerateEqualsAndHash(); // 0x0000000184DA0F40-0x0000000184DA0F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearJavaStringCheckUtf8(); // 0x0000000184DA0FD0-0x0000000184DA0FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearOptimizeFor(); // 0x0000000184DA0EC0-0x0000000184DA0ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearGoPackage(); // 0x0000000189AFF570-0x0000000189AFF584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCcGenericServices(); // 0x0000000184DA0F00-0x0000000184DA0F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearJavaGenericServices(); // 0x0000000184DA0F20-0x0000000184DA0F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPyGenericServices(); // 0x0000000184DA0F10-0x0000000184DA0F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPhpGenericServices(); // 0x0000000184DA0FE0-0x0000000184DA0FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDeprecated(); // 0x0000000184DA0F30-0x0000000184DA0F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCcEnableArenas(); // 0x0000000184DA0FC0-0x0000000184DA0FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearObjcClassPrefix(); // 0x000000018709F140-0x000000018709F154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCsharpNamespace(); // 0x0000000189AFF584-0x0000000189AFF598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSwiftPrefix(); // 0x0000000186973C40-0x0000000186973C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPhpClassPrefix(); // 0x0000000189B105DC-0x0000000189B105F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPhpNamespace(); // 0x0000000189B01D64-0x0000000189B01D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPhpMetadataNamespace(); // 0x0000000189B105F0-0x0000000189B10604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearRubyPackage(); // 0x0000000189B10604-0x0000000189B10618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B10678-0x0000000189B106DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FileOptions other); // 0x0000000189B106DC-0x0000000189B10A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B10A6C-0x0000000189B10DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B110A4-0x0000000189B110F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B122B8-0x0000000189B12718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B102A4-0x0000000189B105DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FileOptions other); // 0x0000000189B10DD4-0x0000000189B110A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B11ED4-0x0000000189B122B8
		public TValue GetExtension<TValue>(Extension<FileOptions, TValue> extension);
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension);
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension);
		public void SetExtension<TValue>(Extension<FileOptions, TValue> extension, TValue value);
		public bool HasExtension<TValue>(Extension<FileOptions, TValue> extension);
		public void ClearExtension<TValue>(Extension<FileOptions, TValue> extension);
		public void ClearExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension);
	}

	public sealed class MessageOptions : IExtendableMessage<MessageOptions>, IBufferMessage // TypeDefIndex: 55954
	{
		// Fields
		private static readonly MessageParser<MessageOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<MessageOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int MessageSetWireFormatFieldNumber = 1; // Metadata: 0x02347815
		private static readonly bool MessageSetWireFormatDefaultValue; // 0x08
		private bool messageSetWireFormat_; // 0x24
		public const int NoStandardDescriptorAccessorFieldNumber = 2; // Metadata: 0x02347816
		private static readonly bool NoStandardDescriptorAccessorDefaultValue; // 0x09
		private bool noStandardDescriptorAccessor_; // 0x25
		public const int DeprecatedFieldNumber = 3; // Metadata: 0x02347817
		private static readonly bool DeprecatedDefaultValue; // 0x0A
		private bool deprecated_; // 0x26
		public const int MapEntryFieldNumber = 7; // Metadata: 0x02347818
		private static readonly bool MapEntryDefaultValue; // 0x0B
		private bool mapEntry_; // 0x27
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x02347819
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x28
	
		// Properties
		private ExtensionSet<MessageOptions> _Extensions { get; } // 0x000000018385B100-0x000000018385B110 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MessageOptions> Parser { get; } // 0x0000000189B14BD8-0x0000000189B14C28 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B14A7C-0x0000000189B14ADC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B14F00-0x0000000189B14F40 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MessageSetWireFormat { get; set; } // 0x0000000189B14B30-0x0000000189B14B84 0x0000000184DA0EE0-0x0000000184DA0EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasMessageSetWireFormat { get; } // 0x0000000189B0C6CC-0x0000000189B0C6D4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NoStandardDescriptorAccessor { get; set; } // 0x0000000189B14B84-0x0000000189B14BD8 0x0000000184DA0EF0-0x0000000184DA0F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasNoStandardDescriptorAccessor { get; } // 0x0000000189B0C6D4-0x0000000189B0C6DC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deprecated { get; set; } // 0x0000000189B14A28-0x0000000189B14A7C 0x0000000184DA1090-0x0000000184DA10A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDeprecated { get; } // 0x0000000189B0FC7C-0x0000000189B0FC84 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MapEntry { get; set; } // 0x0000000189B14ADC-0x0000000189B14B30 0x0000000184DA10A0-0x0000000184DA10B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasMapEntry { get; } // 0x0000000189B0FC8C-0x0000000189B0FC94 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55953
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B19FF0-0x0000000189B1A054
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal MessageOptions _.cctor_b__74_0(); // 0x0000000189B19B30-0x0000000189B19B80
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageOptions(); // 0x0000000189B149B0-0x0000000189B14A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageOptions(MessageOptions other); // 0x0000000189B148E4-0x0000000189B149B0
		static MessageOptions(); // 0x0000000189B14754-0x0000000189B148E4
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageOptions Clone(); // 0x0000000189B14324-0x0000000189B14384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessageSetWireFormat(); // 0x0000000184DA0EC0-0x0000000184DA0ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearNoStandardDescriptorAccessor(); // 0x0000000184DA0ED0-0x0000000184DA0EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDeprecated(); // 0x0000000184DA0F00-0x0000000184DA0F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMapEntry(); // 0x0000000184DA0F20-0x0000000184DA0F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B14384-0x0000000189B143E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MessageOptions other); // 0x0000000189B143E8-0x0000000189B144FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B144FC-0x0000000189B14610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B14708-0x0000000189B14754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B14D90-0x0000000189B14F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B1423C-0x0000000189B14324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MessageOptions other); // 0x0000000189B14610-0x0000000189B14708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B14C28-0x0000000189B14D90
		public TValue GetExtension<TValue>(Extension<MessageOptions, TValue> extension);
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension);
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension);
		public void SetExtension<TValue>(Extension<MessageOptions, TValue> extension, TValue value);
		public bool HasExtension<TValue>(Extension<MessageOptions, TValue> extension);
		public void ClearExtension<TValue>(Extension<MessageOptions, TValue> extension);
		public void ClearExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension);
	}

	public sealed class FieldOptions : IExtendableMessage<Google.Protobuf.Reflection.FieldOptions>, IBufferMessage // TypeDefIndex: 55959
	{
		// Fields
		private static readonly MessageParser<FieldOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<FieldOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int CtypeFieldNumber = 1; // Metadata: 0x0234781B
		private static readonly Types.CType CtypeDefaultValue; // 0x08
		private Types.CType ctype_; // 0x24
		public const int PackedFieldNumber = 2; // Metadata: 0x0234781C
		private static readonly bool PackedDefaultValue; // 0x0C
		private bool packed_; // 0x28
		public const int JstypeFieldNumber = 6; // Metadata: 0x0234781D
		private static readonly Types.JSType JstypeDefaultValue; // 0x10
		private Types.JSType jstype_; // 0x2C
		public const int LazyFieldNumber = 5; // Metadata: 0x0234781E
		private static readonly bool LazyDefaultValue; // 0x14
		private bool lazy_; // 0x30
		public const int UnverifiedLazyFieldNumber = 15; // Metadata: 0x0234781F
		private static readonly bool UnverifiedLazyDefaultValue; // 0x15
		private bool unverifiedLazy_; // 0x31
		public const int DeprecatedFieldNumber = 3; // Metadata: 0x02347820
		private static readonly bool DeprecatedDefaultValue; // 0x16
		private bool deprecated_; // 0x32
		public const int WeakFieldNumber = 10; // Metadata: 0x02347821
		private static readonly bool WeakDefaultValue; // 0x17
		private bool weak_; // 0x33
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x02347822
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x18
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x38
	
		// Properties
		private ExtensionSet<FieldOptions> _Extensions { get; } // 0x000000018385B100-0x000000018385B110 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FieldOptions> Parser { get; } // 0x0000000189B0FDA0-0x0000000189B0FDF0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B0FC1C-0x0000000189B0FC7C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B10264-0x0000000189B102A4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.CType Ctype { get; set; } // 0x0000000189B0FB74-0x0000000189B0FBC8 0x0000000184DA0F50-0x0000000184DA0F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasCtype { get; } // 0x0000000189B0C6CC-0x0000000189B0C6D4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Packed { get; set; } // 0x0000000189B0FD4C-0x0000000189B0FDA0 0x0000000184DA0F90-0x0000000184DA0FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPacked { get; } // 0x0000000189B0C6D4-0x0000000189B0C6DC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.JSType Jstype { get; set; } // 0x0000000189B0FCA4-0x0000000189B0FCF8 0x0000000184DA0F70-0x0000000184DA0F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasJstype { get; } // 0x0000000189B0FC84-0x0000000189B0FC8C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Lazy { get; set; } // 0x0000000189B0FCF8-0x0000000189B0FD4C 0x0000000184DA0F80-0x0000000184DA0F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLazy { get; } // 0x0000000189B0FC8C-0x0000000189B0FC94 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UnverifiedLazy { get; set; } // 0x0000000189B0FDF0-0x0000000189B0FE44 0x0000000184DA0FA0-0x0000000184DA0FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnverifiedLazy { get; } // 0x0000000189B0FC94-0x0000000189B0FC9C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deprecated { get; set; } // 0x0000000189B0FBC8-0x0000000189B0FC1C 0x0000000184DA0F60-0x0000000184DA0F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDeprecated { get; } // 0x0000000189B0FC7C-0x0000000189B0FC84 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Weak { get; set; } // 0x0000000189B0FE44-0x0000000189B0FE98 0x0000000184DA0FB0-0x0000000184DA0FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasWeak { get; } // 0x0000000189B0FC9C-0x0000000189B0FCA4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get; } // 0x0000000184D85A50-0x0000000184D85A60 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 55957
		{
			// Nested types
			public enum CType // TypeDefIndex: 55955
			{
				String = 0,
				Cord = 1,
				StringPiece = 2
			}
	
			public enum JSType // TypeDefIndex: 55956
			{
				JsNormal = 0,
				JsString = 1,
				JsNumber = 2
			}
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55958
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B19E60-0x0000000189B19EC4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal FieldOptions _.cctor_b__102_0(); // 0x0000000189B19630-0x0000000189B19680
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldOptions(); // 0x0000000189B0FAFC-0x0000000189B0FB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldOptions(FieldOptions other); // 0x0000000189B0FA18-0x0000000189B0FAFC
		static FieldOptions(); // 0x0000000189B0F854-0x0000000189B0FA18
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldOptions Clone(); // 0x0000000189B0F340-0x0000000189B0F3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCtype(); // 0x0000000184DA0EC0-0x0000000184DA0ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPacked(); // 0x0000000184DA0ED0-0x0000000184DA0EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearJstype(); // 0x0000000184DA0F10-0x0000000184DA0F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLazy(); // 0x0000000184DA0F20-0x0000000184DA0F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnverifiedLazy(); // 0x0000000184DA0F30-0x0000000184DA0F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDeprecated(); // 0x0000000184DA0F00-0x0000000184DA0F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearWeak(); // 0x0000000184DA0F40-0x0000000184DA0F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B0F3A0-0x0000000189B0F404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FieldOptions other); // 0x0000000189B0F404-0x0000000189B0F570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B0F570-0x0000000189B0F6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B0F808-0x0000000189B0F854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B10074-0x0000000189B10264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B0F1D8-0x0000000189B0F340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FieldOptions other); // 0x0000000189B0F6C8-0x0000000189B0F808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B0FE98-0x0000000189B10074
		public TValue GetExtension<TValue>(Extension<FieldOptions, TValue> extension);
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension);
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension);
		public void SetExtension<TValue>(Extension<FieldOptions, TValue> extension, TValue value);
		public bool HasExtension<TValue>(Extension<FieldOptions, TValue> extension);
		public void ClearExtension<TValue>(Extension<FieldOptions, TValue> extension);
		public void ClearExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension);
	}

	public sealed class OneofOptions : IExtendableMessage<OneofOptions>, IBufferMessage // TypeDefIndex: 55961
	{
		// Fields
		private static readonly MessageParser<OneofOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<OneofOptions> _extensions; // 0x18
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x0234782A
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x20
	
		// Properties
		private ExtensionSet<OneofOptions> _Extensions { get; } // 0x000000018385B100-0x000000018385B110 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneofOptions> Parser { get; } // 0x0000000189B17728-0x0000000189B17778 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B176C8-0x0000000189B17728 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B17940-0x0000000189B17980 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55960
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B1A248-0x0000000189B1A2AC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal OneofOptions _.cctor_b__37_0(); // 0x0000000189B19770-0x0000000189B197C0
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneofOptions(); // 0x0000000189B17650-0x0000000189B176C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneofOptions(OneofOptions other); // 0x0000000189B175A0-0x0000000189B17650
		static OneofOptions(); // 0x0000000189B17430-0x0000000189B175A0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneofOptions Clone(); // 0x0000000189B171F8-0x0000000189B17258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B172E8-0x0000000189B1734C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneofOptions other); // 0x0000000189B17258-0x0000000189B172E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189AFE3F0-0x0000000189AFE458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B173E4-0x0000000189B17430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B17878-0x0000000189B17940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B1713C-0x0000000189B171F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneofOptions other); // 0x0000000189B1734C-0x0000000189B173E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B17778-0x0000000189B17878
		public TValue GetExtension<TValue>(Extension<OneofOptions, TValue> extension);
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<OneofOptions, TValue> extension);
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<OneofOptions, TValue> extension);
		public void SetExtension<TValue>(Extension<OneofOptions, TValue> extension, TValue value);
		public bool HasExtension<TValue>(Extension<OneofOptions, TValue> extension);
		public void ClearExtension<TValue>(Extension<OneofOptions, TValue> extension);
		public void ClearExtension<TValue>(RepeatedExtension<OneofOptions, TValue> extension);
	}

	public sealed class EnumOptions : IExtendableMessage<EnumOptions>, IBufferMessage // TypeDefIndex: 55963
	{
		// Fields
		private static readonly MessageParser<EnumOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<EnumOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int AllowAliasFieldNumber = 2; // Metadata: 0x0234782C
		private static readonly bool AllowAliasDefaultValue; // 0x08
		private bool allowAlias_; // 0x24
		public const int DeprecatedFieldNumber = 3; // Metadata: 0x0234782D
		private static readonly bool DeprecatedDefaultValue; // 0x09
		private bool deprecated_; // 0x25
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x0234782E
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x28
	
		// Properties
		private ExtensionSet<EnumOptions> _Extensions { get; } // 0x000000018385B100-0x000000018385B110 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnumOptions> Parser { get; } // 0x0000000189B0C6DC-0x0000000189B0C72C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B0C66C-0x0000000189B0C6CC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B0C97C-0x0000000189B0C9BC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AllowAlias { get; set; } // 0x0000000189B0C5C4-0x0000000189B0C618 0x0000000184DA0EE0-0x0000000184DA0EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasAllowAlias { get; } // 0x0000000189B0C6CC-0x0000000189B0C6D4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deprecated { get; set; } // 0x0000000189B0C618-0x0000000189B0C66C 0x0000000184DA0EF0-0x0000000184DA0F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDeprecated { get; } // 0x0000000189B0C6D4-0x0000000189B0C6DC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55962
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B19D34-0x0000000189B19D98
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal EnumOptions _.cctor_b__56_0(); // 0x0000000189B19A54-0x0000000189B19AA4
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumOptions(); // 0x0000000189B0C54C-0x0000000189B0C5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumOptions(EnumOptions other); // 0x0000000189B0C48C-0x0000000189B0C54C
		static EnumOptions(); // 0x0000000189B0C2FC-0x0000000189B0C48C
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumOptions Clone(); // 0x0000000189B0BF80-0x0000000189B0BFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearAllowAlias(); // 0x0000000184DA0EC0-0x0000000184DA0ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDeprecated(); // 0x0000000184DA0ED0-0x0000000184DA0EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B0BFE0-0x0000000189B0C044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnumOptions other); // 0x0000000189B0C044-0x0000000189B0C118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B0C118-0x0000000189B0C1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B0C2B0-0x0000000189B0C2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B0C860-0x0000000189B0C97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B0BEA8-0x0000000189B0BF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnumOptions other); // 0x0000000189B0C1E8-0x0000000189B0C2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B0C72C-0x0000000189B0C860
		public TValue GetExtension<TValue>(Extension<EnumOptions, TValue> extension);
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension);
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension);
		public void SetExtension<TValue>(Extension<EnumOptions, TValue> extension, TValue value);
		public bool HasExtension<TValue>(Extension<EnumOptions, TValue> extension);
		public void ClearExtension<TValue>(Extension<EnumOptions, TValue> extension);
		public void ClearExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension);
	}

	public sealed class EnumValueOptions : IExtendableMessage<EnumValueOptions>, IBufferMessage // TypeDefIndex: 55965
	{
		// Fields
		private static readonly MessageParser<EnumValueOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<EnumValueOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int DeprecatedFieldNumber = 1; // Metadata: 0x02347830
		private static readonly bool DeprecatedDefaultValue; // 0x08
		private bool deprecated_; // 0x24
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x02347831
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x28
	
		// Properties
		private ExtensionSet<EnumValueOptions> _Extensions { get; } // 0x000000018385B100-0x000000018385B110 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnumValueOptions> Parser { get; } // 0x0000000189B0E30C-0x0000000189B0E35C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B0E2AC-0x0000000189B0E30C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B0E568-0x0000000189B0E5A8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deprecated { get; set; } // 0x0000000189B0E258-0x0000000189B0E2AC 0x0000000184DA0EE0-0x0000000184DA0EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDeprecated { get; } // 0x0000000189B0C6CC-0x0000000189B0C6D4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55964
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B19D98-0x0000000189B19DFC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal EnumValueOptions _.cctor_b__47_0(); // 0x0000000189B19914-0x0000000189B19964
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValueOptions(); // 0x0000000189B0E1E0-0x0000000189B0E258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValueOptions(EnumValueOptions other); // 0x0000000189B0E124-0x0000000189B0E1E0
		static EnumValueOptions(); // 0x0000000189B0DFA0-0x0000000189B0E124
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValueOptions Clone(); // 0x0000000189B0DC80-0x0000000189B0DCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDeprecated(); // 0x0000000184DA0EC0-0x0000000184DA0ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B0DCE0-0x0000000189B0DD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnumValueOptions other); // 0x0000000189B0DD44-0x0000000189B0DDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B0DDF8-0x0000000189B0DEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B0DF54-0x0000000189B0DFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B0E474-0x0000000189B0E568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B0DBB4-0x0000000189B0DC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnumValueOptions other); // 0x0000000189B0DEA4-0x0000000189B0DF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B0E35C-0x0000000189B0E474
		public TValue GetExtension<TValue>(Extension<EnumValueOptions, TValue> extension);
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension);
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension);
		public void SetExtension<TValue>(Extension<EnumValueOptions, TValue> extension, TValue value);
		public bool HasExtension<TValue>(Extension<EnumValueOptions, TValue> extension);
		public void ClearExtension<TValue>(Extension<EnumValueOptions, TValue> extension);
		public void ClearExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension);
	}

	public sealed class ServiceOptions : IExtendableMessage<ServiceOptions>, IBufferMessage // TypeDefIndex: 55967
	{
		// Fields
		private static readonly MessageParser<ServiceOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<ServiceOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int DeprecatedFieldNumber = 33; // Metadata: 0x02347833
		private static readonly bool DeprecatedDefaultValue; // 0x08
		private bool deprecated_; // 0x24
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x02347834
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x28
	
		// Properties
		private ExtensionSet<ServiceOptions> _Extensions { get; } // 0x000000018385B100-0x000000018385B110 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ServiceOptions> Parser { get; } // 0x0000000189B18C20-0x0000000189B18C70 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B18BC0-0x0000000189B18C20 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B18E84-0x0000000189B18EC4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deprecated { get; set; } // 0x0000000189B18B6C-0x0000000189B18BC0 0x0000000184DA0EE0-0x0000000184DA0EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDeprecated { get; } // 0x0000000189B0C6CC-0x0000000189B0C6D4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55966
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B19DFC-0x0000000189B19E60
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal ServiceOptions _.cctor_b__47_0(); // 0x0000000189B198C4-0x0000000189B19914
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServiceOptions(); // 0x0000000189B18A38-0x0000000189B18AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServiceOptions(ServiceOptions other); // 0x0000000189B18AB0-0x0000000189B18B6C
		static ServiceOptions(); // 0x0000000189B188B4-0x0000000189B18A38
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServiceOptions Clone(); // 0x0000000189B18594-0x0000000189B185F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDeprecated(); // 0x0000000184DA0EC0-0x0000000184DA0ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B186A8-0x0000000189B1870C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ServiceOptions other); // 0x0000000189B185F4-0x0000000189B186A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B1870C-0x0000000189B187B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B18868-0x0000000189B188B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B18D8C-0x0000000189B18E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B184B8-0x0000000189B18594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ServiceOptions other); // 0x0000000189B187B8-0x0000000189B18868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B18C70-0x0000000189B18D8C
		public TValue GetExtension<TValue>(Extension<ServiceOptions, TValue> extension);
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension);
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension);
		public void SetExtension<TValue>(Extension<ServiceOptions, TValue> extension, TValue value);
		public bool HasExtension<TValue>(Extension<ServiceOptions, TValue> extension);
		public void ClearExtension<TValue>(Extension<ServiceOptions, TValue> extension);
		public void ClearExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension);
	}

	public sealed class MethodOptions : IExtendableMessage<MethodOptions>, IBufferMessage // TypeDefIndex: 55971
	{
		// Fields
		private static readonly MessageParser<MethodOptions> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		internal ExtensionSet<MethodOptions> _extensions; // 0x18
		private int _hasBits0; // 0x20
		public const int DeprecatedFieldNumber = 33; // Metadata: 0x02347836
		private static readonly bool DeprecatedDefaultValue; // 0x08
		private bool deprecated_; // 0x24
		public const int IdempotencyLevelFieldNumber = 34; // Metadata: 0x02347837
		private static readonly Types.IdempotencyLevel IdempotencyLevelDefaultValue; // 0x0C
		private Types.IdempotencyLevel idempotencyLevel_; // 0x28
		public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x02347838
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x30
	
		// Properties
		private ExtensionSet<MethodOptions> _Extensions { get; } // 0x000000018385B100-0x000000018385B110 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MethodOptions> Parser { get; } // 0x0000000189B16644-0x0000000189B16694 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B16590-0x0000000189B165F0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B168F4-0x0000000189B16934 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Deprecated { get; set; } // 0x0000000189B1653C-0x0000000189B16590 0x0000000184DA0EE0-0x0000000184DA0EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDeprecated { get; } // 0x0000000189B0C6CC-0x0000000189B0C6D4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.IdempotencyLevel IdempotencyLevel { get; set; } // 0x0000000189B165F0-0x0000000189B16644 0x0000000184DA10D0-0x0000000184DA10E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIdempotencyLevel { get; } // 0x0000000189B0C6D4-0x0000000189B0C6DC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UninterpretedOption> UninterpretedOption { get; } // 0x00000001811F36E0-0x00000001811F36F0 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 55969
		{
			// Nested types
			public enum IdempotencyLevel // TypeDefIndex: 55968
			{
				IdempotencyUnknown = 0,
				NoSideEffects = 1,
				Idempotent = 2
			}
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55970
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B19F8C-0x0000000189B19FF0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal MethodOptions _.cctor_b__57_0(); // 0x0000000189B19AA4-0x0000000189B19AF4
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MethodOptions(); // 0x0000000189B164C4-0x0000000189B1653C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MethodOptions(MethodOptions other); // 0x0000000189B16404-0x0000000189B164C4
		static MethodOptions(); // 0x0000000189B16270-0x0000000189B16404
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MethodOptions Clone(); // 0x0000000189B15F08-0x0000000189B15F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDeprecated(); // 0x0000000184DA0EC0-0x0000000184DA0ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIdempotencyLevel(); // 0x0000000184DA0ED0-0x0000000184DA0EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B15F68-0x0000000189B15FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MethodOptions other); // 0x0000000189B15FCC-0x0000000189B160A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B160A0-0x0000000189B1615C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B16224-0x0000000189B16270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B167D0-0x0000000189B168F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B15DF4-0x0000000189B15F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MethodOptions other); // 0x0000000189B1615C-0x0000000189B16224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B16694-0x0000000189B167D0
		public TValue GetExtension<TValue>(Extension<MethodOptions, TValue> extension);
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension);
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension);
		public void SetExtension<TValue>(Extension<MethodOptions, TValue> extension, TValue value);
		public bool HasExtension<TValue>(Extension<MethodOptions, TValue> extension);
		public void ClearExtension<TValue>(Extension<MethodOptions, TValue> extension);
		public void ClearExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension);
	}

	public sealed class UninterpretedOption : IMessage<UninterpretedOption>, IBufferMessage // TypeDefIndex: 55976
	{
		// Fields
		private static readonly MessageParser<UninterpretedOption> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		private int _hasBits0; // 0x18
		public const int NameFieldNumber = 2; // Metadata: 0x0234783D
		private static readonly FieldCodec<Types.NamePart> _repeated_name_codec; // 0x08
		private readonly RepeatedField<Types.NamePart> name_; // 0x20
		public const int IdentifierValueFieldNumber = 3; // Metadata: 0x0234783E
		private static readonly string IdentifierValueDefaultValue; // 0x10
		private string identifierValue_; // 0x28
		public const int PositiveIntValueFieldNumber = 4; // Metadata: 0x0234783F
		private static readonly ulong PositiveIntValueDefaultValue; // 0x18
		private ulong positiveIntValue_; // 0x30
		public const int NegativeIntValueFieldNumber = 5; // Metadata: 0x02347840
		private static readonly long NegativeIntValueDefaultValue; // 0x20
		private long negativeIntValue_; // 0x38
		public const int DoubleValueFieldNumber = 6; // Metadata: 0x02347841
		private static readonly double DoubleValueDefaultValue; // 0x28
		private double doubleValue_; // 0x40
		public const int StringValueFieldNumber = 7; // Metadata: 0x02347842
		private static readonly ByteString StringValueDefaultValue; // 0x30
		private ByteString stringValue_; // 0x48
		public const int AggregateValueFieldNumber = 8; // Metadata: 0x02347843
		private static readonly string AggregateValueDefaultValue; // 0x38
		private string aggregateValue_; // 0x50
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UninterpretedOption> Parser { get; } // 0x0000000189B1B0C8-0x0000000189B1B118 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B1AF14-0x0000000189B1AF74 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B1B540-0x0000000189B1B580 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Types.NamePart> Name { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string IdentifierValue { get; set; } // 0x0000000189B1B01C-0x0000000189B1B070 0x0000000189B1B5E8-0x0000000189B1B650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIdentifierValue { get; } // 0x00000001868C60A8-0x00000001868C60B4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong PositiveIntValue { get; set; } // 0x0000000189B1B118-0x0000000189B1B170 0x0000000184DA1110-0x0000000184DA1120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPositiveIntValue { get; } // 0x000000018314ECE0-0x000000018314ECF0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NegativeIntValue { get; set; } // 0x0000000189B1B070-0x0000000189B1B0C8 0x0000000184DA1100-0x0000000184DA1110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasNegativeIntValue { get; } // 0x0000000189AFF0A8-0x0000000189AFF0B0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double DoubleValue { get; set; } // 0x0000000189B1AF74-0x0000000189B1AFCC 0x0000000184DA10F0-0x0000000184DA1100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDoubleValue { get; } // 0x0000000189B00098-0x0000000189B000A0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString StringValue { get; set; } // 0x0000000189B1B170-0x0000000189B1B1C4 0x0000000189B1B650-0x0000000189B1B6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasStringValue { get; } // 0x0000000189B1AFCC-0x0000000189B1B01C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AggregateValue { get; set; } // 0x0000000189B1AEC0-0x0000000189B1AF14 0x0000000189B1B580-0x0000000189B1B5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasAggregateValue { get; } // 0x00000001884774C8-0x00000001884774D4 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 55974
		{
			// Nested types
			public sealed class NamePart : IMessage<NamePart>, IBufferMessage // TypeDefIndex: 55973
			{
				// Fields
				private static readonly MessageParser<NamePart> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				private int _hasBits0; // 0x18
				public const int NamePart_FieldNumber = 1; // Metadata: 0x02347844
				private static readonly string NamePart_DefaultValue; // 0x08
				private string namePart_; // 0x20
				public const int IsExtensionFieldNumber = 2; // Metadata: 0x02347845
				private static readonly bool IsExtensionDefaultValue; // 0x10
				private bool isExtension_; // 0x28
	
				// Properties
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<NamePart> Parser { get; } // 0x0000000189B16F28-0x0000000189B16F78 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor Descriptor { get; } // 0x0000000189B16E20-0x0000000189B16E80 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B17094-0x0000000189B170D4 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string NamePart_ { get; set; } // 0x0000000189B16ED4-0x0000000189B16F28 0x0000000189B170D4-0x0000000189B1713C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasNamePart_ { get; } // 0x0000000189B00070-0x0000000189B0007C 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool IsExtension { get; set; } // 0x0000000189B16E80-0x0000000189B16ED4 0x0000000184DA10E0-0x0000000184DA10F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasIsExtension { get; } // 0x000000018314ECE0-0x000000018314ECF0 
	
				// Nested types
				[Serializable]
				[CompilerGenerated]
				private sealed class __c // TypeDefIndex: 55972
				{
					// Fields
					public static readonly __c __9; // 0x00
	
					// Constructors
					static __c(); // 0x0000000189B1A310-0x0000000189B1A374
					public __c(); // 0x00000001841E1670-0x00000001841E1680
	
					// Methods
					internal NamePart _.cctor_b__41_0(); // 0x0000000189B19810-0x0000000189B1984C
				}
	
				// Constructors
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NamePart(); // 0x00000001841E1670-0x00000001841E1680
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NamePart(NamePart other); // 0x0000000189B16DCC-0x0000000189B16E20
				static NamePart(); // 0x0000000189B16C70-0x0000000189B16DCC
	
				// Methods
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NamePart Clone(); // 0x0000000189B169B8-0x0000000189B16A18
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearNamePart_(); // 0x0000000189AFF598-0x0000000189AFF5AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearIsExtension(); // 0x0000000184D86DE0-0x0000000184D86DF0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other); // 0x0000000189B16A18-0x0000000189B16A7C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(NamePart other); // 0x0000000189B16A7C-0x0000000189B16B04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode(); // 0x0000000189B16B04-0x0000000189B16BB0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString(); // 0x0000000189B16C24-0x0000000189B16C70
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B1700C-0x0000000189B17094
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize(); // 0x0000000189B16934-0x0000000189B169B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(NamePart other); // 0x0000000189B16BB0-0x0000000189B16C24
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B16F78-0x0000000189B1700C
			}
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55975
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B1A054-0x0000000189B1A0B8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UninterpretedOption _.cctor_b__83_0(); // 0x0000000189B19B80-0x0000000189B19BD0
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UninterpretedOption(); // 0x0000000189B1AE48-0x0000000189B1AEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UninterpretedOption(UninterpretedOption other); // 0x0000000189B1AD68-0x0000000189B1AE48
		static UninterpretedOption(); // 0x0000000189B1AB0C-0x0000000189B1AD68
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UninterpretedOption Clone(); // 0x0000000189B1A588-0x0000000189B1A5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIdentifierValue(); // 0x0000000189849400-0x0000000189849414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPositiveIntValue(); // 0x0000000184D86DE0-0x0000000184D86DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearNegativeIntValue(); // 0x0000000184DA0DF0-0x0000000184DA0E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDoubleValue(); // 0x0000000184DA0E40-0x0000000184DA0E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStringValue(); // 0x00000001870A7CA8-0x00000001870A7CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearAggregateValue(); // 0x000000018709F140-0x000000018709F154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B1A5E8-0x0000000189B1A64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UninterpretedOption other); // 0x0000000189B1A64C-0x0000000189B1A824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B1A824-0x0000000189B1A994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B1AAC0-0x0000000189B1AB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B1B38C-0x0000000189B1B540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B1A3D8-0x0000000189B1A588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UninterpretedOption other); // 0x0000000189B1A994-0x0000000189B1AAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B1B1C4-0x0000000189B1B38C
	}

	public sealed class SourceCodeInfo : IMessage<SourceCodeInfo>, IBufferMessage // TypeDefIndex: 55981
	{
		// Fields
		private static readonly MessageParser<SourceCodeInfo> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int LocationFieldNumber = 1; // Metadata: 0x02347846
		private static readonly FieldCodec<Types.Location> _repeated_location_codec; // 0x08
		private readonly RepeatedField<Types.Location> location_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SourceCodeInfo> Parser { get; } // 0x0000000189B1942C-0x0000000189B1947C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B193CC-0x0000000189B1942C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B195F0-0x0000000189B19630 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Types.Location> Location { get; } // 0x000000018385B100-0x000000018385B110 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 55979
		{
			// Nested types
			public sealed class Location : IMessage<Location>, IBufferMessage // TypeDefIndex: 55978
			{
				// Fields
				private static readonly MessageParser<Location> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				public const int PathFieldNumber = 1; // Metadata: 0x02347847
				private static readonly FieldCodec<int> _repeated_path_codec; // 0x08
				private readonly RepeatedField<int> path_; // 0x18
				public const int SpanFieldNumber = 2; // Metadata: 0x02347848
				private static readonly FieldCodec<int> _repeated_span_codec; // 0x10
				private readonly RepeatedField<int> span_; // 0x20
				public const int LeadingCommentsFieldNumber = 3; // Metadata: 0x02347849
				private static readonly string LeadingCommentsDefaultValue; // 0x18
				private string leadingComments_; // 0x28
				public const int TrailingCommentsFieldNumber = 4; // Metadata: 0x0234784A
				private static readonly string TrailingCommentsDefaultValue; // 0x20
				private string trailingComments_; // 0x30
				public const int LeadingDetachedCommentsFieldNumber = 6; // Metadata: 0x0234784B
				private static readonly FieldCodec<string> _repeated_leadingDetachedComments_codec; // 0x28
				private readonly RepeatedField<string> leadingDetachedComments_; // 0x38
	
				// Properties
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<Location> Parser { get; } // 0x0000000189B13D3C-0x0000000189B13D8C 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor Descriptor { get; } // 0x0000000189B13C88-0x0000000189B13CE8 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B1412C-0x0000000189B1416C 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> Path { get; } // 0x000000018385B100-0x000000018385B110 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> Span { get; } // 0x0000000184D862C0-0x0000000184D862D0 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string LeadingComments { get; set; } // 0x0000000189B13CE8-0x0000000189B13D3C 0x0000000189B1416C-0x0000000189B141D4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasLeadingComments { get; } // 0x00000001868C60A8-0x00000001868C60B4 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string TrailingComments { get; set; } // 0x0000000189B13D8C-0x0000000189B13DE0 0x0000000189B141D4-0x0000000189B1423C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasTrailingComments { get; } // 0x0000000189B11948-0x0000000189B11954 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<string> LeadingDetachedComments { get; } // 0x0000000184D85A50-0x0000000184D85A60 
	
				// Nested types
				[Serializable]
				[CompilerGenerated]
				private sealed class __c // TypeDefIndex: 55977
				{
					// Fields
					public static readonly __c __9; // 0x00
	
					// Constructors
					static __c(); // 0x0000000189B19CD0-0x0000000189B19D34
					public __c(); // 0x00000001841E1670-0x00000001841E1680
	
					// Methods
					internal Location _.cctor_b__55_0(); // 0x0000000189B199B4-0x0000000189B19A04
				}
	
				// Constructors
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Location(); // 0x0000000189B13A94-0x0000000189B13B88
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Location(Location other); // 0x0000000189B13B88-0x0000000189B13C88
				static Location(); // 0x0000000189B1387C-0x0000000189B13A94
	
				// Methods
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Location Clone(); // 0x0000000189B13454-0x0000000189B134B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearLeadingComments(); // 0x0000000189849400-0x0000000189849414
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearTrailingComments(); // 0x00000001867B5A00-0x00000001867B5A14
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other); // 0x0000000189B134B4-0x0000000189B13518
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(Location other); // 0x0000000189B13518-0x0000000189B13650
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode(); // 0x0000000189B13650-0x0000000189B13730
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString(); // 0x0000000189B13830-0x0000000189B1387C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B13FB8-0x0000000189B1412C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize(); // 0x0000000189B132D8-0x0000000189B13454
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(Location other); // 0x0000000189B13730-0x0000000189B13830
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B13DE0-0x0000000189B13FB8
			}
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55980
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B19F28-0x0000000189B19F8C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal SourceCodeInfo _.cctor_b__28_0(); // 0x0000000189B19720-0x0000000189B19770
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceCodeInfo(); // 0x0000000189B192CC-0x0000000189B19344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceCodeInfo(SourceCodeInfo other); // 0x0000000189B19344-0x0000000189B193CC
		static SourceCodeInfo(); // 0x0000000189B1915C-0x0000000189B192CC
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceCodeInfo Clone(); // 0x0000000189B18F58-0x0000000189B18FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B19034-0x0000000189B19098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SourceCodeInfo other); // 0x0000000189B18FB8-0x0000000189B19034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018638F5B8-0x000000018638F608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B19110-0x0000000189B1915C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B1954C-0x0000000189B195F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B18EC4-0x0000000189B18F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SourceCodeInfo other); // 0x0000000189B19098-0x0000000189B19110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B1947C-0x0000000189B1954C
	}

	public sealed class GeneratedCodeInfo : IMessage<GeneratedCodeInfo>, IBufferMessage // TypeDefIndex: 55986
	{
		// Fields
		private static readonly MessageParser<GeneratedCodeInfo> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int AnnotationFieldNumber = 1; // Metadata: 0x0234784C
		private static readonly FieldCodec<Types.Annotation> _repeated_annotation_codec; // 0x08
		private readonly RepeatedField<Types.Annotation> annotation_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GeneratedCodeInfo> Parser { get; } // 0x0000000189B130D4-0x0000000189B13124 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B13074-0x0000000189B130D4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B13298-0x0000000189B132D8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Types.Annotation> Annotation { get; } // 0x000000018385B100-0x000000018385B110 
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 55984
		{
			// Nested types
			public sealed class Annotation : IMessage<Annotation>, IBufferMessage // TypeDefIndex: 55983
			{
				// Fields
				private static readonly MessageParser<Annotation> _parser; // 0x00
				private UnknownFieldSet _unknownFields; // 0x10
				private int _hasBits0; // 0x18
				public const int PathFieldNumber = 1; // Metadata: 0x0234784D
				private static readonly FieldCodec<int> _repeated_path_codec; // 0x08
				private readonly RepeatedField<int> path_; // 0x20
				public const int SourceFileFieldNumber = 2; // Metadata: 0x0234784E
				private static readonly string SourceFileDefaultValue; // 0x10
				private string sourceFile_; // 0x28
				public const int BeginFieldNumber = 3; // Metadata: 0x0234784F
				private static readonly int BeginDefaultValue; // 0x18
				private int begin_; // 0x30
				public const int EndFieldNumber = 4; // Metadata: 0x02347850
				private static readonly int EndDefaultValue; // 0x1C
				private int end_; // 0x34
	
				// Properties
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<Annotation> Parser { get; } // 0x0000000189B09EDC-0x0000000189B09F2C 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor Descriptor { get; } // 0x0000000189B09E28-0x0000000189B09E88 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B0A1F8-0x0000000189B0A238 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> Path { get; } // 0x0000000184D862C0-0x0000000184D862D0 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string SourceFile { get; set; } // 0x0000000189B09F2C-0x0000000189B09F80 0x0000000189B0A238-0x0000000189B0A2A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasSourceFile { get; } // 0x00000001868C60A8-0x00000001868C60B4 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Begin { get; set; } // 0x0000000189B09DD4-0x0000000189B09E28 0x0000000184DA0EA0-0x0000000184DA0EB0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasBegin { get; } // 0x000000018314ECE0-0x000000018314ECF0 
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int End { get; set; } // 0x0000000189B09E88-0x0000000189B09EDC 0x0000000184DA0EB0-0x0000000184DA0EC0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasEnd { get; } // 0x0000000189AFF0A8-0x0000000189AFF0B0 
	
				// Nested types
				[Serializable]
				[CompilerGenerated]
				private sealed class __c // TypeDefIndex: 55982
				{
					// Fields
					public static readonly __c __9; // 0x00
	
					// Constructors
					static __c(); // 0x0000000189B1A374-0x0000000189B1A3D8
					public __c(); // 0x00000001841E1670-0x00000001841E1680
	
					// Methods
					internal Annotation _.cctor_b__55_0(); // 0x0000000189B19A04-0x0000000189B19A54
				}
	
				// Constructors
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Annotation(); // 0x0000000189B09D5C-0x0000000189B09DD4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Annotation(Annotation other); // 0x0000000189B09CB0-0x0000000189B09D5C
				static Annotation(); // 0x0000000189B09B0C-0x0000000189B09CB0
	
				// Methods
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Annotation Clone(); // 0x0000000189B097AC-0x0000000189B0980C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearSourceFile(); // 0x0000000189849400-0x0000000189849414
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearBegin(); // 0x0000000184D86DE0-0x0000000184D86DF0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void ClearEnd(); // 0x0000000184DA0DF0-0x0000000184DA0E00
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other); // 0x0000000189B098F8-0x0000000189B0995C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(Annotation other); // 0x0000000189B0980C-0x0000000189B098F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode(); // 0x0000000189B0995C-0x0000000189B099F4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString(); // 0x0000000189B09AC0-0x0000000189B09B0C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B0A0D0-0x0000000189B0A1F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize(); // 0x0000000189B09678-0x0000000189B097AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(Annotation other); // 0x0000000189B099F4-0x0000000189B09AC0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B09F80-0x0000000189B0A0D0
			}
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55985
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B1A11C-0x0000000189B1A180
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal GeneratedCodeInfo _.cctor_b__28_0(); // 0x0000000189B196D0-0x0000000189B19720
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GeneratedCodeInfo(); // 0x0000000189B12FFC-0x0000000189B13074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GeneratedCodeInfo(GeneratedCodeInfo other); // 0x0000000189B12F74-0x0000000189B12FFC
		static GeneratedCodeInfo(); // 0x0000000189B12E04-0x0000000189B12F74
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GeneratedCodeInfo Clone(); // 0x0000000189B12C00-0x0000000189B12C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B12C60-0x0000000189B12CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GeneratedCodeInfo other); // 0x0000000189B12CC4-0x0000000189B12D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018638F5B8-0x000000018638F608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B12DB8-0x0000000189B12E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B131F4-0x0000000189B13298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B12B6C-0x0000000189B12C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GeneratedCodeInfo other); // 0x0000000189B12D40-0x0000000189B12DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B13124-0x0000000189B131F4
	}

	public abstract class DescriptorBase : IDescriptor // TypeDefIndex: 55987
	{
		// Fields
		[CompilerGenerated]
		private readonly int _Index_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly string _FullName_k__BackingField; // 0x18
		[CompilerGenerated]
		private readonly FileDescriptor _File_k__BackingField; // 0x20
	
		// Properties
		public int Index { [CompilerGenerated] get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
		public abstract string Name { get; }
		public string FullName { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
		public FileDescriptor File { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public DescriptorDeclaration Declaration { get; } // 0x0000000189B0A2D0-0x0000000189B0A2F8 
	
		// Constructors
		internal DescriptorBase(FileDescriptor file, string fullName, int index); // 0x0000000189B0A2A0-0x0000000189B0A2D0
	
		// Methods
		internal virtual IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber); // 0x00000001811EC580-0x00000001811EC590
	}

	public sealed class DescriptorDeclaration // TypeDefIndex: 55988
	{
		// Fields
		[CompilerGenerated]
		private readonly IDescriptor _Descriptor_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly int _StartLine_k__BackingField; // 0x18
		[CompilerGenerated]
		private readonly int _StartColumn_k__BackingField; // 0x1C
		[CompilerGenerated]
		private readonly int _EndLine_k__BackingField; // 0x20
		[CompilerGenerated]
		private readonly int _EndColumn_k__BackingField; // 0x24
		[CompilerGenerated]
		private readonly string _LeadingComments_k__BackingField; // 0x28
		[CompilerGenerated]
		private readonly string _TrailingComments_k__BackingField; // 0x30
		[CompilerGenerated]
		private readonly IReadOnlyList<string> _LeadingDetachedComments_k__BackingField; // 0x38
	
		// Properties
		public IDescriptor Descriptor { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public int StartLine { [CompilerGenerated] get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public int StartColumn { [CompilerGenerated] get; } // 0x0000000184D86310-0x0000000184D86320 
		public int EndLine { [CompilerGenerated] get; } // 0x0000000182B70F90-0x0000000182B70FA0 
		public int EndColumn { [CompilerGenerated] get; } // 0x00000001811F0020-0x00000001811F0030 
		public string LeadingComments { [CompilerGenerated] get; } // 0x0000000184D86240-0x0000000184D86250 
		public string TrailingComments { [CompilerGenerated] get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public IReadOnlyList<string> LeadingDetachedComments { [CompilerGenerated] get; } // 0x0000000184D85A50-0x0000000184D85A60 
	
		// Constructors
		private DescriptorDeclaration(IDescriptor descriptor, SourceCodeInfo.Types.Location location); // 0x0000000189B0A368-0x0000000189B0A508
	
		// Methods
		internal static DescriptorDeclaration FromProto(IDescriptor descriptor, SourceCodeInfo.Types.Location location); // 0x0000000189B0A2F8-0x0000000189B0A368
	}

	internal sealed class DescriptorPool // TypeDefIndex: 55989
	{
		// Fields
		private readonly IDictionary<string, IDescriptor> descriptorsByName; // 0x10
		private readonly IDictionary<ObjectIntPair<IDescriptor>, FieldDescriptor> fieldsByNumber; // 0x18
		private readonly IDictionary<ObjectIntPair<IDescriptor>, EnumValueDescriptor> enumValuesByNumber; // 0x20
		private readonly HashSet<FileDescriptor> dependencies; // 0x28
		private static readonly Regex ValidationRegex; // 0x00
	
		// Constructors
		internal DescriptorPool(IEnumerable<FileDescriptor> dependencyFiles); // 0x0000000189B0B538-0x0000000189B0B8E8
		static DescriptorPool(); // 0x0000000189B0B474-0x0000000189B0B538
	
		// Methods
		private void ImportPublicDependencies(FileDescriptor file); // 0x0000000189B0AEB0-0x0000000189B0B024
		internal T FindSymbol<T>(string fullName)
			where T : class;
		internal void AddPackage(string fullName, FileDescriptor file); // 0x0000000189B0A804-0x0000000189B0AA6C
		internal void AddSymbol(IDescriptor descriptor); // 0x0000000189B0AA6C-0x0000000189B0AD68
		private static void ValidateSymbolName(IDescriptor descriptor); // 0x0000000189B0B2E4-0x0000000189B0B474
		internal FieldDescriptor FindFieldByNumber(MessageDescriptor messageDescriptor, int number); // 0x0000000189B0AE0C-0x0000000189B0AEB0
		internal EnumValueDescriptor FindEnumValueByNumber(EnumDescriptor enumDescriptor, int number); // 0x0000000189B0AD68-0x0000000189B0AE0C
		internal void AddFieldByNumber(FieldDescriptor field); // 0x0000000189B0A5CC-0x0000000189B0A804
		internal void AddEnumValueByNumber(EnumValueDescriptor enumValue); // 0x0000000189B0A508-0x0000000189B0A5CC
		internal IDescriptor LookupSymbol(string name, IDescriptor relativeTo); // 0x0000000189B0B024-0x0000000189B0B2E4
	}

	internal static class DescriptorUtil // TypeDefIndex: 55991
	{
		// Nested types
		internal delegate TOutput IndexedConverter<TInput, TOutput>(TInput element, int index); // TypeDefIndex: 55990; 0x00000000-0x00000000
	
		// Methods
		internal static IList<TOutput> ConvertAndMakeReadOnly<TInput, TOutput>(IList<TInput> input, IndexedConverter<TInput, TOutput> converter);
	}

	public sealed class DescriptorValidationException : Exception // TypeDefIndex: 55992
	{
		// Fields
		private readonly string name; // 0x90
		private readonly string description; // 0x98
	
		// Properties
		public string ProblemSymbolName { get; } // 0x0000000184D86220-0x0000000184D86230 
		public string Description { get; } // 0x0000000184D85EE0-0x0000000184D85EF0 
	
		// Constructors
		internal DescriptorValidationException(IDescriptor problemDescriptor, string description); // 0x0000000189B0B8E8-0x0000000189B0B9B4
		internal DescriptorValidationException(IDescriptor problemDescriptor, string description, Exception cause); // 0x0000000189B0B9B4-0x0000000189B0BA94
	}

	public sealed class EnumDescriptor : DescriptorBase // TypeDefIndex: 55994
	{
		// Fields
		private readonly EnumDescriptorProto proto; // 0x28
		private readonly MessageDescriptor containingType; // 0x30
		private readonly IList<EnumValueDescriptor> values; // 0x38
		private readonly System.Type clrType; // 0x40
	
		// Properties
		internal EnumDescriptorProto Proto { get; } // 0x0000000184D86240-0x0000000184D86250 
		public override string Name { get; } // 0x0000000189B0BE88-0x0000000189B0BEA8 
		public System.Type ClrType { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public MessageDescriptor ContainingType { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public IList<EnumValueDescriptor> Values { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions() method.")]
		public CustomOptions CustomOptions { get; } // 0x0000000189B0BDF8-0x0000000189B0BE88 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 55993
		{
			// Fields
			public FileDescriptor file; // 0x10
			public EnumDescriptor __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal EnumValueDescriptor _.ctor_b__0(EnumValueDescriptorProto value, int i); // 0x0000000189B19BD0-0x0000000189B19C6C
		}
	
		// Constructors
		internal EnumDescriptor(EnumDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, System.Type clrType); // 0x0000000189B0BBEC-0x0000000189B0BDF8
	
		// Methods
		public EnumDescriptorProto ToProto(); // 0x0000000189B0BBCC-0x0000000189B0BBEC
		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber); // 0x0000000189B0BB50-0x0000000189B0BBA0
		public EnumValueDescriptor FindValueByNumber(int number); // 0x0000000189B0BB20-0x0000000189B0BB50
		public EnumValueDescriptor FindValueByName(string name); // 0x0000000189B0BA94-0x0000000189B0BB20
		public EnumOptions GetOptions(); // 0x0000000189B0BBA0-0x0000000189B0BBCC
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<EnumOptions, T> extension);
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<EnumOptions, T> extension);
	}

	public sealed class EnumValueDescriptor : DescriptorBase // TypeDefIndex: 55995
	{
		// Fields
		private readonly EnumDescriptor enumDescriptor; // 0x28
		private readonly EnumValueDescriptorProto proto; // 0x30
	
		// Properties
		internal EnumValueDescriptorProto Proto { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public override string Name { get; } // 0x0000000189B0DB74-0x0000000189B0DB94 
		public int Number { get; } // 0x0000000189B0DB94-0x0000000189B0DBB4 
		public EnumDescriptor EnumDescriptor { get; } // 0x0000000184D86240-0x0000000184D86250 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions() method.")]
		public CustomOptions CustomOptions { get; } // 0x0000000189B0DAE4-0x0000000189B0DB74 
	
		// Constructors
		internal EnumValueDescriptor(EnumValueDescriptorProto proto, FileDescriptor file, EnumDescriptor parent, int index); // 0x0000000189B0D9EC-0x0000000189B0DAE4
	
		// Methods
		public EnumValueDescriptorProto ToProto(); // 0x0000000189B0D9CC-0x0000000189B0D9EC
		public EnumValueOptions GetOptions(); // 0x0000000189B0D9A0-0x0000000189B0D9CC
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<EnumValueOptions, T> extension);
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<EnumValueOptions, T> extension);
	}

	internal sealed class ExtensionAccessor : IFieldAccessor // TypeDefIndex: 55996
	{
		// Fields
		private readonly Google.Protobuf.Extension extension; // 0x10
		private readonly ReflectionUtil.IExtensionReflectionHelper helper; // 0x18
		[CompilerGenerated]
		private readonly FieldDescriptor _Descriptor_k__BackingField; // 0x20
	
		// Properties
		public FieldDescriptor Descriptor { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Constructors
		internal ExtensionAccessor(FieldDescriptor descriptor); // 0x0000000189B0E770-0x0000000189B0E7F8
	
		// Methods
		public void Clear(IMessage message); // 0x0000000189B0E5A8-0x0000000189B0E614
		public bool HasValue(IMessage message); // 0x0000000189B0E680-0x0000000189B0E6EC
		public object GetValue(IMessage message); // 0x0000000189B0E614-0x0000000189B0E680
		public void SetValue(IMessage message, object value); // 0x0000000189B0E6EC-0x0000000189B0E770
	}

	public sealed class ExtensionCollection // TypeDefIndex: 56000
	{
		// Fields
		private IDictionary<MessageDescriptor, IList<FieldDescriptor>> extensionsByTypeInDeclarationOrder; // 0x10
		private IDictionary<MessageDescriptor, IList<FieldDescriptor>> extensionsByTypeInNumberOrder; // 0x18
		[CompilerGenerated]
		private readonly IList<FieldDescriptor> _UnorderedExtensions_k__BackingField; // 0x20
	
		// Properties
		public IList<FieldDescriptor> UnorderedExtensions { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 55997
		{
			// Fields
			public Google.Protobuf.Extension[] extensions; // 0x10
			public FileDescriptor file; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal FieldDescriptor _.ctor_b__0(FieldDescriptorProto extension, int i); // 0x0000000189B246E0-0x0000000189B247F4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 55998
		{
			// Fields
			public Google.Protobuf.Extension[] extensions; // 0x10
			public MessageDescriptor message; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal FieldDescriptor _.ctor_b__0(FieldDescriptorProto extension, int i); // 0x0000000189B24AF8-0x0000000189B24C30
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55999
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KeyValuePair<MessageDescriptor, IList<FieldDescriptor>>, MessageDescriptor> __9__9_0; // 0x08
			public static Func<KeyValuePair<MessageDescriptor, IList<FieldDescriptor>>, IList<FieldDescriptor>> __9__9_1; // 0x10
			public static Func<KeyValuePair<MessageDescriptor, IList<FieldDescriptor>>, MessageDescriptor> __9__9_2; // 0x18
			public static Func<FieldDescriptor, int> __9__9_4; // 0x20
			public static Func<KeyValuePair<MessageDescriptor, IList<FieldDescriptor>>, IList<FieldDescriptor>> __9__9_3; // 0x28
	
			// Constructors
			static __c(); // 0x0000000189B25134-0x0000000189B25198
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal MessageDescriptor _CrossLink_b__9_0(KeyValuePair<MessageDescriptor, IList<FieldDescriptor>> kvp); // 0x0000000189B243B8-0x0000000189B243EC
			internal IList<FieldDescriptor> _CrossLink_b__9_1(KeyValuePair<MessageDescriptor, IList<FieldDescriptor>> kvp); // 0x0000000189B243EC-0x0000000189B24468
			internal MessageDescriptor _CrossLink_b__9_2(KeyValuePair<MessageDescriptor, IList<FieldDescriptor>> kvp); // 0x0000000189B24468-0x0000000189B2449C
			internal IList<FieldDescriptor> _CrossLink_b__9_3(KeyValuePair<MessageDescriptor, IList<FieldDescriptor>> kvp); // 0x0000000189B2449C-0x0000000189B24614
			internal int _CrossLink_b__9_4(FieldDescriptor field); // 0x0000000189B24614-0x0000000189B24634
		}
	
		// Constructors
		internal ExtensionCollection(FileDescriptor file, Google.Protobuf.Extension[] extensions); // 0x0000000189B0F0D0-0x0000000189B0F1D8
		internal ExtensionCollection(MessageDescriptor message, Google.Protobuf.Extension[] extensions); // 0x0000000189B0EFC8-0x0000000189B0F0D0
	
		// Methods
		public IList<FieldDescriptor> GetExtensionsInDeclarationOrder(MessageDescriptor descriptor); // 0x0000000189B0EF28-0x0000000189B0EF78
		public IList<FieldDescriptor> GetExtensionsInNumberOrder(MessageDescriptor descriptor); // 0x0000000189B0EF78-0x0000000189B0EFC8
		internal void CrossLink(); // 0x0000000189B0E7F8-0x0000000189B0EF28
	}

	internal abstract class FieldAccessorBase : IFieldAccessor // TypeDefIndex: 56001
	{
		// Fields
		private readonly Func<IMessage, object> getValueDelegate; // 0x10
		private readonly FieldDescriptor descriptor; // 0x18
	
		// Properties
		public FieldDescriptor Descriptor { get; } // 0x000000018385B100-0x000000018385B110 
	
		// Constructors
		internal FieldAccessorBase(PropertyInfo property, FieldDescriptor descriptor); // 0x0000000189B1C07C-0x0000000189B1C108
	
		// Methods
		public object GetValue(IMessage message); // 0x0000000189B1C05C-0x0000000189B1C07C
		public abstract bool HasValue(IMessage message);
		public abstract void Clear(IMessage message);
		public abstract void SetValue(IMessage message, object value);
	}

	public sealed class FieldDescriptor : DescriptorBase, IComparable<FieldDescriptor> // TypeDefIndex: 56002
	{
		// Fields
		private EnumDescriptor enumType; // 0x28
		private MessageDescriptor extendeeType; // 0x30
		private MessageDescriptor messageType; // 0x38
		private Google.Protobuf.Reflection.FieldType fieldType; // 0x40
		private IFieldAccessor accessor; // 0x48
		[CompilerGenerated]
		private readonly MessageDescriptor _ContainingType_k__BackingField; // 0x50
		[CompilerGenerated]
		private readonly OneofDescriptor _ContainingOneof_k__BackingField; // 0x58
		[CompilerGenerated]
		private readonly string _JsonName_k__BackingField; // 0x60
		[CompilerGenerated]
		private readonly string _PropertyName_k__BackingField; // 0x68
		[CompilerGenerated]
		private readonly FieldDescriptorProto _Proto_k__BackingField; // 0x70
		[CompilerGenerated]
		private readonly Google.Protobuf.Extension _Extension_k__BackingField; // 0x78
	
		// Properties
		public MessageDescriptor ContainingType { [CompilerGenerated] get; } // 0x0000000184D86270-0x0000000184D86280 
		public OneofDescriptor ContainingOneof { [CompilerGenerated] get; } // 0x0000000182E56440-0x0000000182E56460 
		public OneofDescriptor RealContainingOneof { get; } // 0x0000000189B1D2A0-0x0000000189B1D2B4 
		public string JsonName { [CompilerGenerated] get; } // 0x0000000184D86280-0x0000000184D86290 
		public string PropertyName { [CompilerGenerated] get; } // 0x0000000184D86230-0x0000000184D86240 
		public bool HasPresence { get; } // 0x0000000189B1D098-0x0000000189B1D104 
		internal FieldDescriptorProto Proto { [CompilerGenerated] get; } // 0x0000000184D862B0-0x0000000184D862C0 
		public Google.Protobuf.Extension Extension { [CompilerGenerated] get; } // 0x0000000184D862A0-0x0000000184D862B0 
		public override string Name { get; } // 0x0000000189B1D280-0x0000000189B1D2A0 
		public IFieldAccessor Accessor { get; } // 0x0000000184D86200-0x0000000184D86210 
		public bool IsRepeated { get; } // 0x0000000189B1D1C0-0x0000000189B1D1E8 
		public bool IsRequired { get; } // 0x0000000189B1D1E8-0x0000000189B1D210 
		public bool IsMap { get; } // 0x0000000189B1D124-0x0000000189B1D164 
		public bool IsPacked { get; } // 0x0000000189B1D164-0x0000000189B1D1C0 
		public bool IsExtension { get; } // 0x0000000189B1D104-0x0000000189B1D124 
		public Google.Protobuf.Reflection.FieldType FieldType { get; } // 0x0000000184D865E0-0x0000000184D865F0 
		public int FieldNumber { get; } // 0x0000000189B1D078-0x0000000189B1D098 
		public EnumDescriptor EnumType { get; } // 0x0000000189B1CF98-0x0000000189B1D004 
		public MessageDescriptor MessageType { get; } // 0x0000000189B1D210-0x0000000189B1D280 
		public MessageDescriptor ExtendeeType { get; } // 0x0000000189B1D004-0x0000000189B1D078 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions() method.")]
		public CustomOptions CustomOptions { get; } // 0x0000000189B1CF08-0x0000000189B1CF98 
	
		// Constructors
		internal FieldDescriptor(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string propertyName, Google.Protobuf.Extension extension); // 0x0000000189B1CBF0-0x0000000189B1CF08
	
		// Methods
		public FieldDescriptorProto ToProto(); // 0x0000000189B1CBD0-0x0000000189B1CBF0
		private static Google.Protobuf.Reflection.FieldType GetFieldTypeFromProtoType(FieldDescriptorProto.Types.Type type); // 0x0000000189B1CA3C-0x0000000189B1CBA4
		public int CompareTo(FieldDescriptor other); // 0x0000000189B1C230-0x0000000189B1C2C4
		public Google.Protobuf.Reflection.FieldOptions GetOptions(); // 0x0000000189B1CBA4-0x0000000189B1CBD0
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<Google.Protobuf.Reflection.FieldOptions, T> extension);
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<Google.Protobuf.Reflection.FieldOptions, T> extension);
		internal void CrossLink(); // 0x0000000189B1C4C8-0x0000000189B1CA3C
		private IFieldAccessor CreateAccessor(); // 0x0000000189B1C2C4-0x0000000189B1C4C8
	}

	public enum FieldType // TypeDefIndex: 56003
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

	public enum Syntax // TypeDefIndex: 56004
	{
		Proto2 = 0,
		Proto3 = 1,
		Unknown = 2
	}

	public sealed class FileDescriptor : IDescriptor // TypeDefIndex: 56007
	{
		// Fields
		private readonly Lazy<Dictionary<IDescriptor, DescriptorDeclaration>> declarations; // 0x10
		[CompilerGenerated]
		private readonly FileDescriptorProto _Proto_k__BackingField; // 0x18
		[CompilerGenerated]
		private readonly Google.Protobuf.Reflection.Syntax _Syntax_k__BackingField; // 0x20
		[CompilerGenerated]
		private readonly IList<MessageDescriptor> _MessageTypes_k__BackingField; // 0x28
		[CompilerGenerated]
		private readonly IList<EnumDescriptor> _EnumTypes_k__BackingField; // 0x30
		[CompilerGenerated]
		private readonly IList<ServiceDescriptor> _Services_k__BackingField; // 0x38
		[CompilerGenerated]
		private readonly ExtensionCollection _Extensions_k__BackingField; // 0x40
		[CompilerGenerated]
		private readonly IList<FileDescriptor> _Dependencies_k__BackingField; // 0x48
		[CompilerGenerated]
		private readonly IList<FileDescriptor> _PublicDependencies_k__BackingField; // 0x50
		[CompilerGenerated]
		private readonly ByteString _SerializedData_k__BackingField; // 0x58
		[CompilerGenerated]
		private readonly DescriptorPool _DescriptorPool_k__BackingField; // 0x60
	
		// Properties
		internal FileDescriptorProto Proto { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
		public Google.Protobuf.Reflection.Syntax Syntax { [CompilerGenerated] get; } // 0x0000000182B70F90-0x0000000182B70FA0 
		public string Name { get; } // 0x0000000189B1F874-0x0000000189B1F894 
		public string Package { get; } // 0x0000000189B1F894-0x0000000189B1F8B4 
		public IList<MessageDescriptor> MessageTypes { [CompilerGenerated] get; } // 0x0000000184D86240-0x0000000184D86250 
		public IList<EnumDescriptor> EnumTypes { [CompilerGenerated] get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public IList<ServiceDescriptor> Services { [CompilerGenerated] get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public ExtensionCollection Extensions { [CompilerGenerated] get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public IList<FileDescriptor> Dependencies { [CompilerGenerated] get; } // 0x0000000184D86200-0x0000000184D86210 
		public IList<FileDescriptor> PublicDependencies { [CompilerGenerated] get; } // 0x0000000184D86270-0x0000000184D86280 
		public ByteString SerializedData { [CompilerGenerated] get; } // 0x0000000182E56440-0x0000000182E56460 
		string IDescriptor.FullName { get; } // 0x0000000189B1F248-0x0000000189B1F250 
		FileDescriptor IDescriptor.File { get; } // 0x000000018464E630-0x000000018464E640 
		internal DescriptorPool DescriptorPool { [CompilerGenerated] get; } // 0x0000000184D86280-0x0000000184D86290 
		public static FileDescriptor DescriptorProtoFileDescriptor { get; } // 0x0000000189B1F834-0x0000000189B1F874 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions() method.")]
		public CustomOptions CustomOptions { get; } // 0x0000000189B1F7A4-0x0000000189B1F834 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 56005
		{
			// Fields
			public FileDescriptor __4__this; // 0x10
			public GeneratedClrTypeInfo generatedCodeInfo; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal MessageDescriptor _.ctor_b__0(DescriptorProto message, int index); // 0x0000000189B24890-0x0000000189B24950
			internal EnumDescriptor _.ctor_b__1(EnumDescriptorProto enumType, int index); // 0x0000000189B24950-0x0000000189B24A10
			internal ServiceDescriptor _.ctor_b__2(ServiceDescriptorProto service, int index); // 0x0000000189B24A10-0x0000000189B24A98
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56006
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
			static __c(); // 0x0000000189B252C4-0x0000000189B25328
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _DeterminePublicDependencies_b__9_0(FileDescriptor file); // 0x0000000189B24634-0x0000000189B24654
			internal bool _GetAllGeneratedExtensions_b__54_0(GeneratedClrTypeInfo t); // 0x000000018721682C-0x0000000187216834
			internal Google.Protobuf.Extension _GetAllDependedExtensions_b__55_0(FieldDescriptor s); // 0x0000000189B2466C-0x0000000189B24684
			internal bool _GetAllDependedExtensions_b__55_1(Google.Protobuf.Extension e); // 0x000000018721682C-0x0000000187216834
			internal Google.Protobuf.Extension _GetAllDependedExtensionsFromMessage_b__56_0(FieldDescriptor s); // 0x0000000189B2466C-0x0000000189B24684
			internal bool _GetAllDependedExtensionsFromMessage_b__56_1(Google.Protobuf.Extension e); // 0x000000018721682C-0x0000000187216834
		}
	
		// Constructors
		static FileDescriptor(); // 0x0000000189B1F2B8-0x0000000189B1F348
		private FileDescriptor(ByteString descriptorData, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, DescriptorPool pool, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo); // 0x0000000189B1F348-0x0000000189B1F7A4
	
		// Methods
		private Dictionary<IDescriptor, DescriptorDeclaration> CreateDeclarationMap(); // 0x0000000189B1DBD8-0x0000000189B1DDEC
		private IDescriptor FindDescriptorForPath(IList<int> path); // 0x0000000189B1E390-0x0000000189B1E4EC
		private DescriptorBase GetDescriptorFromList(IReadOnlyList<DescriptorBase> list, int index); // 0x0000000189B1F0F0-0x0000000189B1F1B4
		private IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber); // 0x0000000189B1F1B4-0x0000000189B1F21C
		internal DescriptorDeclaration GetDeclaration(IDescriptor descriptor); // 0x0000000189B1F068-0x0000000189B1F0F0
		internal string ComputeFullName(MessageDescriptor parent, string name); // 0x0000000189B1DB48-0x0000000189B1DBD8
		private static IList<FileDescriptor> DeterminePublicDependencies(FileDescriptor @this, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, bool allowUnknownDependencies); // 0x0000000189B1E03C-0x0000000189B1E390
		public FileDescriptorProto ToProto(); // 0x0000000189B1F250-0x0000000189B1F270
		public T FindTypeByName<T>(string name)
			where T : class, IDescriptor;
		private static FileDescriptor BuildFrom(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo); // 0x0000000189B1D9C0-0x0000000189B1DB48
		private void CrossLink(); // 0x0000000189B1DDEC-0x0000000189B1E03C
		public static FileDescriptor FromGeneratedCode(byte[] descriptorData, FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedCodeInfo); // 0x0000000189B1E4EC-0x0000000189B1E808
		private static IEnumerable<Google.Protobuf.Extension> GetAllExtensions(FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedInfo); // 0x0000000189B1EDA0-0x0000000189B1EEC4
		private static IEnumerable<Google.Protobuf.Extension> GetAllGeneratedExtensions(GeneratedClrTypeInfo generated); // 0x0000000189B1EEC4-0x0000000189B1F068
		private static IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensions(FileDescriptor descriptor); // 0x0000000189B1EA88-0x0000000189B1EDA0
		private static IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensionsFromMessage(MessageDescriptor descriptor); // 0x0000000189B1E808-0x0000000189B1EA88
		public static IReadOnlyList<FileDescriptor> BuildFromByteStrings(IEnumerable<ByteString> descriptorData, ExtensionRegistry registry); // 0x0000000189B1D300-0x0000000189B1D9C0
		public static IReadOnlyList<FileDescriptor> BuildFromByteStrings(IEnumerable<ByteString> descriptorData); // 0x0000000189B1D2B4-0x0000000189B1D300
		public override string ToString(); // 0x0000000189B1F270-0x0000000189B1F2B8
		public Google.Protobuf.Reflection.FileOptions GetOptions(); // 0x0000000189B1F21C-0x0000000189B1F248
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<Google.Protobuf.Reflection.FileOptions, T> extension);
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<Google.Protobuf.Reflection.FileOptions, T> extension);
		public static void ForceReflectionInitialization<T>();
	}

	public sealed class GeneratedClrTypeInfo // TypeDefIndex: 56008
	{
		// Fields
		private static readonly string[] EmptyNames; // 0x00
		private static readonly GeneratedClrTypeInfo[] EmptyCodeInfo; // 0x08
		private static readonly Google.Protobuf.Extension[] EmptyExtensions; // 0x10
		internal const DynamicallyAccessedMemberTypes MessageAccessibility = DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties; // Metadata: 0x02347866
		[CompilerGenerated]
		private System.Type _ClrType_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly MessageParser _Parser_k__BackingField; // 0x18
		[CompilerGenerated]
		private readonly string[] _PropertyNames_k__BackingField; // 0x20
		[CompilerGenerated]
		private readonly Google.Protobuf.Extension[] _Extensions_k__BackingField; // 0x28
		[CompilerGenerated]
		private readonly string[] _OneofNames_k__BackingField; // 0x30
		[CompilerGenerated]
		private readonly GeneratedClrTypeInfo[] _NestedTypes_k__BackingField; // 0x38
		[CompilerGenerated]
		private readonly System.Type[] _NestedEnums_k__BackingField; // 0x40
	
		// Properties
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public System.Type ClrType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public MessageParser Parser { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
		public string[] PropertyNames { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public Google.Protobuf.Extension[] Extensions { [CompilerGenerated] get; } // 0x0000000184D86240-0x0000000184D86250 
		public string[] OneofNames { [CompilerGenerated] get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public GeneratedClrTypeInfo[] NestedTypes { [CompilerGenerated] get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public System.Type[] NestedEnums { [CompilerGenerated] get; } // 0x0000000184D85A60-0x0000000184D85A70 
	
		// Constructors
		public GeneratedClrTypeInfo([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type clrType, MessageParser parser, string[] propertyNames, string[] oneofNames, System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, GeneratedClrTypeInfo[] nestedTypes); // 0x0000000189B1F9C8-0x0000000189B1FB4C
		public GeneratedClrTypeInfo([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type clrType, MessageParser parser, string[] propertyNames, string[] oneofNames, System.Type[] nestedEnums, GeneratedClrTypeInfo[] nestedTypes); // 0x0000000189B1FB80-0x0000000189B1FBC4
		public GeneratedClrTypeInfo(System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, GeneratedClrTypeInfo[] nestedTypes); // 0x0000000189B1FB4C-0x0000000189B1FB80
		public GeneratedClrTypeInfo(System.Type[] nestedEnums, GeneratedClrTypeInfo[] nestedTypes); // 0x0000000189B1F99C-0x0000000189B1F9C8
		static GeneratedClrTypeInfo(); // 0x0000000189B1F8B4-0x0000000189B1F99C
	}

	public interface IDescriptor // TypeDefIndex: 56009
	{
		// Properties
		string Name { get; }
		string FullName { get; }
		FileDescriptor File { get; }
	}

	public interface IFieldAccessor // TypeDefIndex: 56010
	{
		// Properties
		FieldDescriptor Descriptor { get; }
	
		// Methods
		void Clear(IMessage message);
		object GetValue(IMessage message);
		bool HasValue(IMessage message);
		void SetValue(IMessage message, object value);
	}

	internal sealed class MapFieldAccessor : FieldAccessorBase // TypeDefIndex: 56011
	{
		// Constructors
		internal MapFieldAccessor(PropertyInfo property, FieldDescriptor descriptor); // 0x0000000189B1FCF8-0x0000000189B1FD00
	
		// Methods
		public override void Clear(IMessage message); // 0x0000000189B1FBC4-0x0000000189B1FC40
		public override bool HasValue(IMessage message); // 0x0000000189B1FC40-0x0000000189B1FC9C
		public override void SetValue(IMessage message, object value); // 0x0000000189B1FC9C-0x0000000189B1FCF8
	}

	public sealed class MessageDescriptor : DescriptorBase // TypeDefIndex: 56015
	{
		// Fields
		private static readonly HashSet<string> WellKnownTypeNames; // 0x00
		private readonly IList<FieldDescriptor> fieldsInDeclarationOrder; // 0x28
		private readonly IList<FieldDescriptor> fieldsInNumberOrder; // 0x30
		private readonly IDictionary<string, FieldDescriptor> jsonFieldMap; // 0x38
		private Func<IMessage, bool> extensionSetIsInitialized; // 0x40
		[CompilerGenerated]
		private readonly DescriptorProto _Proto_k__BackingField; // 0x48
		[CompilerGenerated]
		private readonly System.Type _ClrType_k__BackingField; // 0x50
		[CompilerGenerated]
		private readonly MessageParser _Parser_k__BackingField; // 0x58
		[CompilerGenerated]
		private readonly MessageDescriptor _ContainingType_k__BackingField; // 0x60
		[CompilerGenerated]
		private readonly FieldCollection _Fields_k__BackingField; // 0x68
		[CompilerGenerated]
		private readonly ExtensionCollection _Extensions_k__BackingField; // 0x70
		[CompilerGenerated]
		private readonly IList<MessageDescriptor> _NestedTypes_k__BackingField; // 0x78
		[CompilerGenerated]
		private readonly IList<EnumDescriptor> _EnumTypes_k__BackingField; // 0x80
		[CompilerGenerated]
		private readonly IList<OneofDescriptor> _Oneofs_k__BackingField; // 0x88
		[CompilerGenerated]
		private readonly int _RealOneofCount_k__BackingField; // 0x90
	
		// Properties
		public override string Name { get; } // 0x0000000189B211CC-0x0000000189B211EC 
		internal DescriptorProto Proto { [CompilerGenerated] get; } // 0x0000000184D86200-0x0000000184D86210 
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public System.Type ClrType { [CompilerGenerated] get; } // 0x0000000184D86270-0x0000000184D86280 
		public MessageParser Parser { [CompilerGenerated] get; } // 0x0000000182E56440-0x0000000182E56460 
		internal bool IsWellKnownType { get; } // 0x0000000189B21080-0x0000000189B21140 
		internal bool IsWrapperType { get; } // 0x0000000189B21140-0x0000000189B211CC 
		public MessageDescriptor ContainingType { [CompilerGenerated] get; } // 0x0000000184D86280-0x0000000184D86290 
		public FieldCollection Fields { [CompilerGenerated] get; } // 0x0000000184D86230-0x0000000184D86240 
		public ExtensionCollection Extensions { [CompilerGenerated] get; } // 0x0000000184D862B0-0x0000000184D862C0 
		public IList<MessageDescriptor> NestedTypes { [CompilerGenerated] get; } // 0x0000000184D862A0-0x0000000184D862B0 
		public IList<EnumDescriptor> EnumTypes { [CompilerGenerated] get; } // 0x0000000184D86260-0x0000000184D86270 
		public IList<OneofDescriptor> Oneofs { [CompilerGenerated] get; } // 0x0000000184D861F0-0x0000000184D86200 
		public int RealOneofCount { [CompilerGenerated] get; } // 0x0000000184D86B60-0x0000000184D86B70 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions() method.")]
		public CustomOptions CustomOptions { get; } // 0x0000000189B20FF0-0x0000000189B21080 
	
		// Nested types
		public sealed class FieldCollection // TypeDefIndex: 56012
		{
			// Fields
			private readonly MessageDescriptor messageDescriptor; // 0x10
	
			// Properties
			public FieldDescriptor this[int number] { get => default; } // 0x0000000189B1C140-0x0000000189B1C1B8 
			public FieldDescriptor this[string name] { get => default; } // 0x0000000189B1C1B8-0x0000000189B1C230 
	
			// Constructors
			internal FieldCollection(MessageDescriptor messageDescriptor); // 0x00000001853908C0-0x00000001853908D0
	
			// Methods
			public IList<FieldDescriptor> InDeclarationOrder(); // 0x0000000189B1C124-0x0000000189B1C140
			public IList<FieldDescriptor> InFieldNumberOrder(); // 0x0000000188110B18-0x0000000188110B34
			internal IDictionary<string, FieldDescriptor> ByJsonName(); // 0x0000000189B1C108-0x0000000189B1C124
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 56013
		{
			// Fields
			public FileDescriptor file; // 0x10
			public MessageDescriptor __4__this; // 0x18
			public GeneratedClrTypeInfo generatedCodeInfo; // 0x20
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal OneofDescriptor _.ctor_b__0(OneofDescriptorProto oneof, int index); // 0x0000000189B24E20-0x0000000189B24EE4
			internal MessageDescriptor _.ctor_b__1(DescriptorProto type, int index); // 0x0000000189B24EE4-0x0000000189B24FA8
			internal EnumDescriptor _.ctor_b__2(EnumDescriptorProto type, int index); // 0x0000000189B24FA8-0x0000000189B2506C
			internal FieldDescriptor _.ctor_b__3(FieldDescriptorProto field, int index); // 0x0000000189B2506C-0x0000000189B25134
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56014
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<FieldDescriptor, int> __9__5_4; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189B25260-0x0000000189B252C4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _.ctor_b__5_4(FieldDescriptor field); // 0x0000000189B24614-0x0000000189B24634
		}
	
		// Constructors
		internal MessageDescriptor(DescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int typeIndex, GeneratedClrTypeInfo generatedCodeInfo); // 0x0000000189B20688-0x0000000189B20FF0
		static MessageDescriptor(); // 0x0000000189B20498-0x0000000189B20688
	
		// Methods
		private static ReadOnlyDictionary<string, FieldDescriptor> CreateJsonFieldMap(IList<FieldDescriptor> fields); // 0x0000000189B1FD00-0x0000000189B1FF20
		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber); // 0x0000000189B2032C-0x0000000189B20398
		public DescriptorProto ToProto(); // 0x0000000189B20478-0x0000000189B20498
		internal bool IsExtensionsInitialized(IMessage message); // 0x0000000189B203C4-0x0000000189B20478
		public FieldDescriptor FindFieldByName(string name); // 0x0000000189B20270-0x0000000189B202FC
		public FieldDescriptor FindFieldByNumber(int number); // 0x0000000189B202FC-0x0000000189B2032C
		public T FindDescriptor<T>(string name)
			where T : class, IDescriptor;
		public MessageOptions GetOptions(); // 0x0000000189B20398-0x0000000189B203C4
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<MessageOptions, T> extension);
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<MessageOptions, T> extension);
		internal void CrossLink(); // 0x0000000189B1FF20-0x0000000189B20270
	}

	public sealed class MethodDescriptor : DescriptorBase // TypeDefIndex: 56016
	{
		// Fields
		private readonly MethodDescriptorProto proto; // 0x28
		private readonly ServiceDescriptor service; // 0x30
		private MessageDescriptor inputType; // 0x38
		private MessageDescriptor outputType; // 0x40
	
		// Properties
		public ServiceDescriptor Service { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public MessageDescriptor InputType { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public MessageDescriptor OutputType { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public bool IsClientStreaming { get; } // 0x0000000189B215F4-0x0000000189B21614 
		public bool IsServerStreaming { get; } // 0x0000000189B21614-0x0000000189B21634 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions() method.")]
		public CustomOptions CustomOptions { get; } // 0x0000000189B21564-0x0000000189B215F4 
		internal MethodDescriptorProto Proto { get; } // 0x0000000184D86240-0x0000000184D86250 
		public override string Name { get; } // 0x0000000189B21634-0x0000000189B21654 
	
		// Constructors
		internal MethodDescriptor(MethodDescriptorProto proto, FileDescriptor file, ServiceDescriptor parent, int index); // 0x0000000189B21480-0x0000000189B21564
	
		// Methods
		public MethodOptions GetOptions(); // 0x0000000189B21434-0x0000000189B21460
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<MethodOptions, T> extension);
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<MethodOptions, T> extension);
		public MethodDescriptorProto ToProto(); // 0x0000000189B21460-0x0000000189B21480
		internal void CrossLink(); // 0x0000000189B211EC-0x0000000189B21434
	}

	public sealed class OneofAccessor // TypeDefIndex: 56018
	{
		// Fields
		private readonly Func<IMessage, int> caseDelegate; // 0x10
		private readonly Action<IMessage> clearDelegate; // 0x18
		[CompilerGenerated]
		private readonly OneofDescriptor _Descriptor_k__BackingField; // 0x20
	
		// Properties
		public OneofDescriptor Descriptor { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 56017
		{
			// Fields
			public OneofDescriptor descriptor; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _ForSyntheticOneof_b__0(IMessage message); // 0x0000000189B24D1C-0x0000000189B24DB4
			internal void _ForSyntheticOneof_b__1(IMessage message); // 0x0000000189B24DB4-0x0000000189B24E20
		}
	
		// Constructors
		private OneofAccessor(OneofDescriptor descriptor, Func<IMessage, int> caseDelegate, Action<IMessage> clearDelegate); // 0x0000000189B218C4-0x0000000189B218FC
	
		// Methods
		internal static OneofAccessor ForRegularOneof(OneofDescriptor descriptor, PropertyInfo caseProperty, MethodInfo clearMethod); // 0x0000000189B21674-0x0000000189B2173C
		internal static OneofAccessor ForSyntheticOneof(OneofDescriptor descriptor); // 0x0000000189B2173C-0x0000000189B21874
		public void Clear(IMessage message); // 0x0000000189B21654-0x0000000189B21674
		public FieldDescriptor GetCaseFieldDescriptor(IMessage message); // 0x0000000189B21874-0x0000000189B218C4
	}

	public sealed class OneofDescriptor : DescriptorBase // TypeDefIndex: 56020
	{
		// Fields
		private MessageDescriptor containingType; // 0x28
		private IList<FieldDescriptor> fields; // 0x30
		private readonly OneofAccessor accessor; // 0x38
		[CompilerGenerated]
		private readonly OneofDescriptorProto _Proto_k__BackingField; // 0x40
		[CompilerGenerated]
		private readonly bool _IsSynthetic_k__BackingField; // 0x48
	
		// Properties
		public override string Name { get; } // 0x0000000189B22088-0x0000000189B220A8 
		internal OneofDescriptorProto Proto { [CompilerGenerated] get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public MessageDescriptor ContainingType { get; } // 0x0000000184D86240-0x0000000184D86250 
		public IList<FieldDescriptor> Fields { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public bool IsSynthetic { [CompilerGenerated] get; } // 0x0000000184D867D0-0x0000000184D867E0 
		public OneofAccessor Accessor { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions method.")]
		public CustomOptions CustomOptions { get; } // 0x0000000189B21FF8-0x0000000189B22088 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 56019
		{
			// Fields
			public int index; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _.ctor_b__0(FieldDescriptorProto fieldProto); // 0x0000000189B24A98-0x0000000189B24AD0
		}
	
		// Constructors
		internal OneofDescriptor(OneofDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string clrName); // 0x0000000189B21E58-0x0000000189B21FF8
	
		// Methods
		public OneofDescriptorProto ToProto(); // 0x0000000189B21E38-0x0000000189B21E58
		public OneofOptions GetOptions(); // 0x0000000189B21E0C-0x0000000189B21E38
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<OneofOptions, T> extension);
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<OneofOptions, T> extension);
		internal void CrossLink(); // 0x0000000189B21BA0-0x0000000189B21E0C
		private OneofAccessor CreateAccessor(string clrName); // 0x0000000189B218FC-0x0000000189B21BA0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class OriginalNameAttribute : Attribute // TypeDefIndex: 56021
	{
		// Fields
		[CompilerGenerated]
		private string _Name_k__BackingField; // 0x10
		[CompilerGenerated]
		private bool _PreferredAlias_k__BackingField; // 0x18
	
		// Properties
		public string Name { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public bool PreferredAlias { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
	
		// Constructors
		public OriginalNameAttribute(string name); // 0x0000000183537000-0x0000000183537040
	}

	internal sealed class PackageDescriptor : IDescriptor // TypeDefIndex: 56022
	{
		// Fields
		private readonly string name; // 0x10
		private readonly string fullName; // 0x18
		private readonly FileDescriptor file; // 0x20
	
		// Properties
		public string Name { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public string FullName { get; } // 0x000000018385B100-0x000000018385B110 
		public FileDescriptor File { get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Constructors
		internal PackageDescriptor(string name, string fullName, FileDescriptor file); // 0x0000000189B220A8-0x0000000189B220E4
	}

	public static class ReflectionUtil // TypeDefIndex: 56037
	{
		// Fields
		internal static readonly System.Type[] EmptyTypes; // 0x00
		[CompilerGenerated]
		private static readonly bool _CanConvertEnumFuncToInt32Func_k__BackingField; // 0x08
	
		// Properties
		private static bool CanConvertEnumFuncToInt32Func { [CompilerGenerated] get; } // 0x0000000189B22DF8-0x0000000189B22E48 
	
		// Nested types
		private interface IReflectionHelper // TypeDefIndex: 56023
		{
			// Methods
			Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method);
			Action<IMessage> CreateActionIMessage(MethodInfo method);
			Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method);
			Action<IMessage, object> CreateActionIMessageObject(MethodInfo method);
			Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method);
		}
	
		internal interface IExtensionReflectionHelper // TypeDefIndex: 56024
		{
			// Methods
			object GetExtension(IMessage message);
			void SetExtension(IMessage message, object value);
			bool HasExtension(IMessage message);
			void ClearExtension(IMessage message);
		}
	
		private interface IExtensionSetReflector // TypeDefIndex: 56025
		{
			// Methods
			Func<IMessage, bool> CreateIsInitializedCaller();
		}
	
		private class ReflectionHelper<T1, T2> : IReflectionHelper // TypeDefIndex: 56032
		{
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass0_0 // TypeDefIndex: 56026
			{
				// Fields
				public Func<T1, int> del;
	
				// Constructors
				public __c__DisplayClass0_0();
	
				// Methods
				internal int _CreateFuncIMessageInt32_b__0(IMessage message);
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass0_1 // TypeDefIndex: 56027
			{
				// Fields
				public Func<T1, T2> del;
	
				// Constructors
				public __c__DisplayClass0_1();
	
				// Methods
				internal int _CreateFuncIMessageInt32_b__1(IMessage message);
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass1_0 // TypeDefIndex: 56028
			{
				// Fields
				public Action<T1> del;
	
				// Constructors
				public __c__DisplayClass1_0();
	
				// Methods
				internal void _CreateActionIMessage_b__0(IMessage message);
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass2_0 // TypeDefIndex: 56029
			{
				// Fields
				public Func<T1, T2> del;
	
				// Constructors
				public __c__DisplayClass2_0();
	
				// Methods
				internal object _CreateFuncIMessageObject_b__0(IMessage message);
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass3_0 // TypeDefIndex: 56030
			{
				// Fields
				public Action<T1, T2> del;
	
				// Constructors
				public __c__DisplayClass3_0();
	
				// Methods
				internal void _CreateActionIMessageObject_b__0(IMessage message, object arg);
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass4_0 // TypeDefIndex: 56031
			{
				// Fields
				public Func<T1, bool> del;
	
				// Constructors
				public __c__DisplayClass4_0();
	
				// Methods
				internal bool _CreateFuncIMessageBool_b__0(IMessage message);
			}
	
			// Constructors
			public ReflectionHelper();
	
			// Methods
			public Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method);
			public Action<IMessage> CreateActionIMessage(MethodInfo method);
			public Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method);
			public Action<IMessage, object> CreateActionIMessageObject(MethodInfo method);
			public Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method);
		}
	
		public class ExtensionReflectionHelper<T1, T3> : IExtensionReflectionHelper // TypeDefIndex: 56033
			where T1 : IExtendableMessage<T1>
		{
			// Fields
			private readonly Google.Protobuf.Extension extension;
	
			// Constructors
			public ExtensionReflectionHelper(Google.Protobuf.Extension extension);
	
			// Methods
			public object GetExtension(IMessage message);
			public bool HasExtension(IMessage message);
			public void SetExtension(IMessage message, object value);
			public void ClearExtension(IMessage message);
		}
	
		private class ExtensionSetReflector<T1> : IExtensionSetReflector // TypeDefIndex: 56035
			where T1 : IExtendableMessage<T1>
		{
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass0_0 // TypeDefIndex: 56034
			{
				// Fields
				public Func<T1, ExtensionSet<T1>> getFunc;
				public Func<ExtensionSet<T1>, bool> initializedFunc;
	
				// Constructors
				public __c__DisplayClass0_0();
	
				// Methods
				internal bool _CreateIsInitializedCaller_b__0(IMessage m);
			}
	
			// Constructors
			public ExtensionSetReflector();
	
			// Methods
			public Func<IMessage, bool> CreateIsInitializedCaller();
		}
	
		public enum SampleEnum // TypeDefIndex: 56036
		{
			X = 0
		}
	
		// Constructors
		static ReflectionUtil(); // 0x0000000189B22BF8-0x0000000189B22DF8
	
		// Methods
		internal static void ForceInitialize<T>();
		internal static Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method); // 0x0000000189B228F4-0x0000000189B229BC
		internal static Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method); // 0x0000000189B2282C-0x0000000189B228F4
		internal static Action<IMessage, object> CreateActionIMessageObject(MethodInfo method); // 0x0000000189B223F0-0x0000000189B224D4
		internal static Action<IMessage> CreateActionIMessage(MethodInfo method); // 0x0000000189B224D4-0x0000000189B225C4
		internal static Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method); // 0x0000000189B22764-0x0000000189B2282C
		[UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Type parameter members are preserved with DynamicallyAccessedMembers on GeneratedClrTypeInfo.ctor clrType parameter.")]
		internal static Func<IMessage, bool> CreateIsInitializedCaller([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type msg); // 0x0000000189B229BC-0x0000000189B22AEC
		[UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Type parameter members are preserved with DynamicallyAccessedMembers on GeneratedClrTypeInfo.ctor clrType parameter.")]
		internal static IExtensionReflectionHelper CreateExtensionHelper(Google.Protobuf.Extension extension); // 0x0000000189B225C4-0x0000000189B22764
		[UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Type parameter members are preserved with DynamicallyAccessedMembers on GeneratedClrTypeInfo.ctor clrType parameter.")]
		private static IReflectionHelper GetReflectionHelper(System.Type t1, System.Type t2); // 0x0000000189B22AEC-0x0000000189B22BF8
		private static bool CheckCanConvertEnumFuncToInt32Func(); // 0x0000000189B222C4-0x0000000189B223F0
		public static SampleEnum SampleEnumMethod(); // 0x00000001811EC580-0x00000001811EC590
	}

	internal sealed class RepeatedFieldAccessor : FieldAccessorBase // TypeDefIndex: 56038
	{
		// Constructors
		internal RepeatedFieldAccessor(PropertyInfo property, FieldDescriptor descriptor); // 0x0000000189B1FCF8-0x0000000189B1FD00
	
		// Methods
		public override void Clear(IMessage message); // 0x0000000189B22E48-0x0000000189B22EC4
		public override bool HasValue(IMessage message); // 0x0000000189B22EC4-0x0000000189B22F20
		public override void SetValue(IMessage message, object value); // 0x0000000189B22F20-0x0000000189B22F7C
	}

	public sealed class ServiceDescriptor : DescriptorBase // TypeDefIndex: 56040
	{
		// Fields
		private readonly ServiceDescriptorProto proto; // 0x28
		private readonly IList<MethodDescriptor> methods; // 0x30
	
		// Properties
		public override string Name { get; } // 0x0000000189B233C8-0x0000000189B233E8 
		internal ServiceDescriptorProto Proto { get; } // 0x0000000184D86240-0x0000000184D86250 
		public IList<MethodDescriptor> Methods { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		[Obsolete("CustomOptions are obsolete. Use the GetOptions() method.")]
		public CustomOptions CustomOptions { get; } // 0x0000000189B23338-0x0000000189B233C8 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 56039
		{
			// Fields
			public FileDescriptor file; // 0x10
			public ServiceDescriptor __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal MethodDescriptor _.ctor_b__0(MethodDescriptorProto method, int i); // 0x0000000189B247F4-0x0000000189B24890
		}
	
		// Constructors
		internal ServiceDescriptor(ServiceDescriptorProto proto, FileDescriptor file, int index); // 0x0000000189B231C4-0x0000000189B23338
	
		// Methods
		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber); // 0x0000000189B23128-0x0000000189B23178
		public ServiceDescriptorProto ToProto(); // 0x0000000189B231A4-0x0000000189B231C4
		public MethodDescriptor FindMethodByName(string name); // 0x0000000189B2309C-0x0000000189B23128
		public ServiceOptions GetOptions(); // 0x0000000189B23178-0x0000000189B231A4
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public T GetOption<T>(Extension<ServiceOptions, T> extension);
		[Obsolete("GetOption is obsolete. Use the GetOptions() method.")]
		public RepeatedField<T> GetOption<T>(RepeatedExtension<ServiceOptions, T> extension);
		internal void CrossLink(); // 0x0000000189B22F7C-0x0000000189B2309C
	}

	internal sealed class SingleFieldAccessor : FieldAccessorBase // TypeDefIndex: 56045
	{
		// Fields
		private readonly Action<IMessage, object> setValueDelegate; // 0x20
		private readonly Action<IMessage> clearDelegate; // 0x28
		private readonly Func<IMessage, bool> hasDelegate; // 0x30
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 56041
		{
			// Fields
			public SingleFieldAccessor __4__this; // 0x10
			public FieldDescriptor descriptor; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _.ctor_b__0(IMessage message); // 0x0000000189B24AD0-0x0000000189B24AF8
			internal void _.ctor_b__1(IMessage message); // 0x0000000189B24C30-0x0000000189B24C58
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_1 // TypeDefIndex: 56042
		{
			// Fields
			public OneofAccessor oneofAccessor; // 0x10
			public __c__DisplayClass3_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass3_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _.ctor_b__2(IMessage message); // 0x0000000189B24C58-0x0000000189B24C90
			internal void _.ctor_b__3(IMessage message); // 0x0000000189B24C90-0x0000000189B24CE8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_2 // TypeDefIndex: 56043
		{
			// Fields
			public object defaultValue; // 0x10
			public __c__DisplayClass3_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass3_2(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _.ctor_b__5(IMessage message); // 0x0000000189B24CE8-0x0000000189B24D1C
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56044
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<IMessage, bool> __9__3_4; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189B251FC-0x0000000189B25260
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _.ctor_b__3_4(IMessage message); // 0x0000000189B24684-0x0000000189B246E0
		}
	
		// Constructors
		internal SingleFieldAccessor([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type messageType, PropertyInfo property, FieldDescriptor descriptor); // 0x0000000189B23658-0x0000000189B23C78
	
		// Methods
		private static object GetDefaultValue(FieldDescriptor descriptor); // 0x0000000189B233E8-0x0000000189B23618
		public override void Clear(IMessage message); // 0x000000018699C87C-0x000000018699C89C
		public override bool HasValue(IMessage message); // 0x0000000189B23618-0x0000000189B23638
		public override void SetValue(IMessage message, object value); // 0x0000000189B23638-0x0000000189B23658
	}

	public sealed class TypeRegistry // TypeDefIndex: 56048
	{
		// Fields
		[CompilerGenerated]
		private static readonly TypeRegistry _Empty_k__BackingField; // 0x00
		private readonly Dictionary<string, MessageDescriptor> fullNameToMessageMap; // 0x10
	
		// Properties
		public static TypeRegistry Empty { [CompilerGenerated] get; } // 0x0000000189B24368-0x0000000189B243B8 
	
		// Nested types
		private class Builder // TypeDefIndex: 56046
		{
			// Fields
			private readonly Dictionary<string, MessageDescriptor> types; // 0x10
			private readonly HashSet<string> fileDescriptorNames; // 0x18
	
			// Constructors
			internal Builder(); // 0x0000000189B1BF9C-0x0000000189B1C05C
	
			// Methods
			internal void AddFile(FileDescriptor fileDescriptor); // 0x0000000189B1BAF4-0x0000000189B1BDB4
			private void AddMessage(MessageDescriptor messageDescriptor); // 0x0000000189B1BDB4-0x0000000189B1BF38
			internal TypeRegistry Build(); // 0x0000000189B1BF38-0x0000000189B1BF9C
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 56047
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MessageDescriptor, FileDescriptor> __9__9_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189B25198-0x0000000189B251FC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal FileDescriptor _FromMessages_b__9_0(MessageDescriptor md); // 0x0000000189B24654-0x0000000189B2466C
		}
	
		// Constructors
		private TypeRegistry(Dictionary<string, MessageDescriptor> fullNameToMessageMap); // 0x00000001853908C0-0x00000001853908D0
		static TypeRegistry(); // 0x0000000189B242B0-0x0000000189B24368
	
		// Methods
		public MessageDescriptor Find(string fullName); // 0x0000000189B23EA0-0x0000000189B23F08
		public static TypeRegistry FromFiles(params FileDescriptor[] fileDescriptors); // 0x0000000189B23F08-0x0000000189B23F54
		public static TypeRegistry FromFiles(IEnumerable<FileDescriptor> fileDescriptors); // 0x0000000189B23F54-0x0000000189B2410C
		public static TypeRegistry FromMessages(params MessageDescriptor[] messageDescriptors); // 0x0000000189B2410C-0x0000000189B24158
		public static TypeRegistry FromMessages(IEnumerable<MessageDescriptor> messageDescriptors); // 0x0000000189B24158-0x0000000189B242B0
	}
}

namespace Google.Protobuf.WellKnownTypes
{
	public static class AnyReflection // TypeDefIndex: 55845
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000189AE3438-0x0000000189AE3488 
	
		// Constructors
		static AnyReflection(); // 0x0000000189AE30E0-0x0000000189AE3438
	}

	public sealed class Any : IMessage<Any>, IBufferMessage // TypeDefIndex: 55847
	{
		// Fields
		private static readonly MessageParser<Any> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int TypeUrlFieldNumber = 1; // Metadata: 0x023476C1
		private string typeUrl_; // 0x18
		public const int ValueFieldNumber = 2; // Metadata: 0x023476C2
		private ByteString value_; // 0x20
		private const string DefaultPrefix = "type.googleapis.com"; // Metadata: 0x023476C3
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Any> Parser { get; } // 0x0000000189AE3D6C-0x0000000189AE3DBC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AE3D0C-0x0000000189AE3D6C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AE3EF8-0x0000000189AE3F38 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TypeUrl { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000189AE3F38-0x0000000189AE3FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString Value { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000189AE3FA0-0x0000000189AE4008
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55846
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189AF05C4-0x0000000189AF0628
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Any _.cctor_b__40_0(); // 0x0000000189AF00B0-0x0000000189AF0100
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Any(); // 0x0000000189AE3CA4-0x0000000189AE3D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Any(Any other); // 0x0000000189AE3C3C-0x0000000189AE3CA4
		static Any(); // 0x0000000189AE3B38-0x0000000189AE3C3C
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Any Clone(); // 0x0000000189AE3540-0x0000000189AE35A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AE35A0-0x0000000189AE3604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Any other); // 0x0000000189AE3604-0x0000000189AE36AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189AE36AC-0x0000000189AE3728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AE3AEC-0x0000000189AE3B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189AE3E68-0x0000000189AE3EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AE3488-0x0000000189AE3540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Any other); // 0x0000000189AE38E0-0x0000000189AE3960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AE3DBC-0x0000000189AE3E68
		private static string GetTypeUrl(MessageDescriptor descriptor, string prefix); // 0x0000000189AE37BC-0x0000000189AE3848
		public static string GetTypeName(string typeUrl); // 0x0000000189AE3728-0x0000000189AE37BC
		public bool Is(MessageDescriptor descriptor); // 0x0000000189AE3848-0x0000000189AE38E0
		public T Unpack<T>()
			where T : IMessage, new();
		public bool TryUnpack<T>(out ref T result)
			where T : IMessage, new();
		public static Any Pack(IMessage message); // 0x0000000189AE3A98-0x0000000189AE3AEC
		public static Any Pack(IMessage message, string typeUrlPrefix); // 0x0000000189AE3960-0x0000000189AE3A98
	}

	public static class ApiReflection // TypeDefIndex: 55848
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000189AE4804-0x0000000189AE4854 
	
		// Constructors
		static ApiReflection(); // 0x0000000189AE4008-0x0000000189AE4804
	}

	public sealed class Api : IMessage<Api>, IBufferMessage // TypeDefIndex: 55850
	{
		// Fields
		private static readonly MessageParser<Api> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x023476D7
		private string name_; // 0x18
		public const int MethodsFieldNumber = 2; // Metadata: 0x023476D8
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Method> _repeated_methods_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Method> methods_; // 0x20
		public const int OptionsFieldNumber = 3; // Metadata: 0x023476D9
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x10
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x28
		public const int VersionFieldNumber = 4; // Metadata: 0x023476DA
		private string version_; // 0x30
		public const int SourceContextFieldNumber = 5; // Metadata: 0x023476DB
		private SourceContext sourceContext_; // 0x38
		public const int MixinsFieldNumber = 6; // Metadata: 0x023476DC
		private static readonly FieldCodec<Mixin> _repeated_mixins_codec; // 0x18
		private readonly RepeatedField<Mixin> mixins_; // 0x40
		public const int SyntaxFieldNumber = 7; // Metadata: 0x023476DD
		private Google.Protobuf.WellKnownTypes.Syntax syntax_; // 0x48
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Api> Parser { get; } // 0x0000000189AE53FC-0x0000000189AE544C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AE539C-0x0000000189AE53FC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AE585C-0x0000000189AE589C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000189AE589C-0x0000000189AE5904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Method> Methods { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get; } // 0x0000000184D86240-0x0000000184D86250 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Version { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000189AE5904-0x0000000189AE596C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceContext SourceContext { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Mixin> Mixins { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Google.Protobuf.WellKnownTypes.Syntax Syntax { get; set; } // 0x0000000184D863D0-0x0000000184D863E0 0x0000000184D86450-0x0000000184D86460
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55849
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189AF036C-0x0000000189AF03D0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Api _.cctor_b__57_0(); // 0x0000000189AF01C8-0x0000000189AF0218
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Api(); // 0x0000000189AE5120-0x0000000189AE5260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Api(Api other); // 0x0000000189AE5260-0x0000000189AE539C
		static Api(); // 0x0000000189AE4EE0-0x0000000189AE5120
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Api Clone(); // 0x0000000189AE4A34-0x0000000189AE4A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AE4A94-0x0000000189AE4AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Api other); // 0x0000000189AE4AF8-0x0000000189AE4C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189AE4C20-0x0000000189AE4D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AE4E94-0x0000000189AE4EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189AE5698-0x0000000189AE585C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AE4854-0x0000000189AE4A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Api other); // 0x0000000189AE4D14-0x0000000189AE4E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AE544C-0x0000000189AE5698
	}

	public sealed class Method : IMessage<Google.Protobuf.WellKnownTypes.Method>, IBufferMessage // TypeDefIndex: 55852
	{
		// Fields
		private static readonly MessageParser<Method> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x023476DE
		private string name_; // 0x18
		public const int RequestTypeUrlFieldNumber = 2; // Metadata: 0x023476DF
		private string requestTypeUrl_; // 0x20
		public const int RequestStreamingFieldNumber = 3; // Metadata: 0x023476E0
		private bool requestStreaming_; // 0x28
		public const int ResponseTypeUrlFieldNumber = 4; // Metadata: 0x023476E1
		private string responseTypeUrl_; // 0x30
		public const int ResponseStreamingFieldNumber = 5; // Metadata: 0x023476E2
		private bool responseStreaming_; // 0x38
		public const int OptionsFieldNumber = 6; // Metadata: 0x023476E3
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x40
		public const int SyntaxFieldNumber = 7; // Metadata: 0x023476E4
		private Google.Protobuf.WellKnownTypes.Syntax syntax_; // 0x48
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Method> Parser { get; } // 0x0000000189AE9950-0x0000000189AE99A0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AE98F0-0x0000000189AE9950 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AE9CDC-0x0000000189AE9D1C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000189AE9D1C-0x0000000189AE9D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RequestTypeUrl { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000189AE9D84-0x0000000189AE9DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RequestStreaming { get; set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ResponseTypeUrl { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000189AE9DEC-0x0000000189AE9E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ResponseStreaming { get; set; } // 0x00000001811F2A70-0x00000001811F2A80 0x00000001811F2A80-0x00000001811F2A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Google.Protobuf.WellKnownTypes.Syntax Syntax { get; set; } // 0x0000000184D863D0-0x0000000184D863E0 0x0000000184D86450-0x0000000184D86460
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55851
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189AF0628-0x0000000189AF068C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Method _.cctor_b__57_0(); // 0x0000000189AF0218-0x0000000189AF0268
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Method(); // 0x0000000189AE9830-0x0000000189AE98F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Method(Method other); // 0x0000000189AE975C-0x0000000189AE9830
		static Method(); // 0x0000000189AE95EC-0x0000000189AE975C
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Method Clone(); // 0x0000000189AE91F8-0x0000000189AE9258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AE9330-0x0000000189AE9394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Method other); // 0x0000000189AE9258-0x0000000189AE9330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189AE9394-0x0000000189AE94A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AE95A0-0x0000000189AE95EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189AE9B48-0x0000000189AE9CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AE906C-0x0000000189AE91F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Method other); // 0x0000000189AE94A0-0x0000000189AE95A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AE99A0-0x0000000189AE9B48
	}

	public sealed class Mixin : IMessage<Mixin>, IBufferMessage // TypeDefIndex: 55854
	{
		// Fields
		private static readonly MessageParser<Mixin> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x023476E5
		private string name_; // 0x18
		public const int RootFieldNumber = 2; // Metadata: 0x023476E6
		private string root_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Mixin> Parser { get; } // 0x0000000189AEA2B4-0x0000000189AEA304 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AEA254-0x0000000189AEA2B4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AEA3B0-0x0000000189AEA3F0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000189AEA3F0-0x0000000189AEA458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Root { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000189AEA458-0x0000000189AEA4C0
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55853
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189AF0308-0x0000000189AF036C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Mixin _.cctor_b__32_0(); // 0x0000000189AF0060-0x0000000189AF00B0
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mixin(); // 0x0000000189AEA200-0x0000000189AEA254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mixin(Mixin other); // 0x0000000189AEA198-0x0000000189AEA200
		static Mixin(); // 0x0000000189AEA094-0x0000000189AEA198
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mixin Clone(); // 0x0000000189AE9F08-0x0000000189AE9F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AE9F68-0x0000000189AE9FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Mixin other); // 0x00000001863C4394-0x00000001863C43FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x00000001863C43FC-0x00000001863C4474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AEA048-0x0000000189AEA094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x00000001863C47AC-0x00000001863C483C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AE9E54-0x0000000189AE9F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Mixin other); // 0x0000000189AE9FCC-0x0000000189AEA048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AEA304-0x0000000189AEA3B0
	}

	public static class DurationReflection // TypeDefIndex: 55855
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000189AE5CE4-0x0000000189AE5D34 
	
		// Constructors
		static DurationReflection(); // 0x0000000189AE596C-0x0000000189AE5CE4
	}

	public sealed class Duration : IMessage<Duration>, IBufferMessage, ICustomDiagnosticMessage // TypeDefIndex: 55857
	{
		// Fields
		private static readonly MessageParser<Duration> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int SecondsFieldNumber = 1; // Metadata: 0x023476E7
		private long seconds_; // 0x18
		public const int NanosFieldNumber = 2; // Metadata: 0x023476E8
		private int nanos_; // 0x20
		public const int NanosecondsPerSecond = 1000000000; // Metadata: 0x023476E9
		public const int NanosecondsPerTick = 100; // Metadata: 0x023476EE
		public const long MaxSeconds = 315576000000; // Metadata: 0x023476F0
		public const long MinSeconds = -315576000000; // Metadata: 0x023476F8
		internal const int MaxNanoseconds = 999999999; // Metadata: 0x02347700
		internal const int MinNanoseconds = -999999999; // Metadata: 0x02347705
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Duration> Parser { get; } // 0x0000000189AE6888-0x0000000189AE68D8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AE67F4-0x0000000189AE6888 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AE6C60-0x0000000189AE6CA0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Seconds { get; set; } // 0x000000018385B100-0x000000018385B110 0x00000001811EC9D0-0x00000001811EC9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Nanos { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55856
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189AF0560-0x0000000189AF05C4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Duration _.cctor_b__48_0(); // 0x0000000189AF0150-0x0000000189AF018C
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Duration(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Duration(Duration other); // 0x000000018637B49C-0x000000018637B4E0
		static Duration(); // 0x0000000189AE66F0-0x0000000189AE67F4
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Duration Clone(); // 0x0000000189AE5F20-0x0000000189AE5F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AE5F80-0x0000000189AE5FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Duration other); // 0x000000018637BDB8-0x000000018637BDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018637BDEC-0x000000018637BE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AE653C-0x0000000189AE6588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x000000018637C018-0x000000018637C090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AE5E84-0x0000000189AE5F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Duration other); // 0x000000018637BE38-0x000000018637BE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x000000018637BF80-0x000000018637C018
		internal static bool IsNormalized(long seconds, int nanoseconds); // 0x0000000189AE6168-0x0000000189AE61FC
		public TimeSpan ToTimeSpan(); // 0x0000000189AE6588-0x0000000189AE66F0
		public static Duration FromTimeSpan(TimeSpan timeSpan); // 0x0000000189AE5FE4-0x0000000189AE6168
		public static Duration operator -(Duration value); // 0x0000000189AE6B68-0x0000000189AE6C60
		public static Duration operator +(Duration lhs, Duration rhs); // 0x0000000189AE68D8-0x0000000189AE6A1C
		public static Duration operator -(Duration lhs, Duration rhs); // 0x0000000189AE6A1C-0x0000000189AE6B68
		internal static Duration Normalize(long seconds, int nanoseconds); // 0x0000000189AE61FC-0x0000000189AE6298
		internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly); // 0x0000000189AE62F0-0x0000000189AE653C
		public string ToDiagnosticString(); // 0x0000000189AE6298-0x0000000189AE62F0
		internal static void AppendNanoseconds(StringBuilder builder, int nanos); // 0x0000000189AE5D34-0x0000000189AE5E84
	}

	public static class EmptyReflection // TypeDefIndex: 55858
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000189AE6F98-0x0000000189AE6FE8 
	
		// Constructors
		static EmptyReflection(); // 0x0000000189AE6CA0-0x0000000189AE6F98
	}

	public sealed class Empty : IMessage<Google.Protobuf.WellKnownTypes.Empty>, IBufferMessage // TypeDefIndex: 55860
	{
		// Fields
		private static readonly MessageParser<Empty> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Empty> Parser { get; } // 0x0000000189AE7290-0x0000000189AE72E0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AE71FC-0x0000000189AE7290 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AE72E0-0x0000000189AE7320 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55859
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189AF0434-0x0000000189AF0498
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Empty _.cctor_b__22_0(); // 0x0000000189AEFF34-0x0000000189AEFF70
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Empty(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Empty(Empty other); // 0x000000018639FAEC-0x000000018639FB20
		static Empty(); // 0x0000000189AE70F8-0x0000000189AE71FC
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Empty Clone(); // 0x0000000189AE6FE8-0x0000000189AE7048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AE7048-0x0000000189AE70AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Empty other); // 0x000000018639F91C-0x000000018639F940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018639F940-0x000000018639F96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AE70AC-0x0000000189AE70F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x000000018639FC2C-0x000000018639FC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x000000018639F838-0x000000018639F858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Empty other); // 0x000000018639F96C-0x000000018639F99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x000000018639FBD0-0x000000018639FC2C
	}

	public static class FieldMaskReflection // TypeDefIndex: 55861
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000189AE7658-0x0000000189AE76A8 
	
		// Constructors
		static FieldMaskReflection(); // 0x0000000189AE7320-0x0000000189AE7658
	}

	public sealed class FieldMask : IMessage<FieldMask>, IBufferMessage, ICustomDiagnosticMessage // TypeDefIndex: 55864
	{
		// Fields
		private static readonly MessageParser<FieldMask> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int PathsFieldNumber = 1; // Metadata: 0x0234770A
		private static readonly FieldCodec<string> _repeated_paths_codec; // 0x08
		private readonly RepeatedField<string> paths_; // 0x18
		private const char FIELD_PATH_SEPARATOR = ','; // Metadata: 0x0234770B
		private const char FIELD_SEPARATOR_REGEX = '.'; // Metadata: 0x0234770D
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FieldMask> Parser { get; } // 0x0000000189AE86FC-0x0000000189AE874C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AE8668-0x0000000189AE86FC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AE88C0-0x0000000189AE8900 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Paths { get; } // 0x000000018385B100-0x000000018385B110 
	
		// Nested types
		public sealed class MergeOptions // TypeDefIndex: 55862
		{
			// Fields
			[CompilerGenerated]
			private bool _ReplaceMessageFields_k__BackingField; // 0x10
			[CompilerGenerated]
			private bool _ReplaceRepeatedFields_k__BackingField; // 0x11
			[CompilerGenerated]
			private bool _ReplacePrimitiveFields_k__BackingField; // 0x12
	
			// Properties
			public bool ReplaceMessageFields { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
			public bool ReplaceRepeatedFields { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88380-0x0000000184D88390 0x0000000184D88460-0x0000000184D88470
			public bool ReplacePrimitiveFields { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88390-0x0000000184D883A0 0x0000000184DA0900-0x0000000184DA0910
	
			// Constructors
			public MergeOptions(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55863
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, bool> __9__29_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189AF068C-0x0000000189AF06F0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _ToJson_b__29_0(string p); // 0x0000000189AEFEF0-0x0000000189AEFF34
			internal FieldMask _.cctor_b__47_0(); // 0x0000000189AF0100-0x0000000189AF0150
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldMask(); // 0x0000000189AE85F0-0x0000000189AE8668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldMask(FieldMask other); // 0x0000000189AE8568-0x0000000189AE85F0
		static FieldMask(); // 0x0000000189AE842C-0x0000000189AE8568
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldMask Clone(); // 0x0000000189AE773C-0x0000000189AE779C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AE779C-0x0000000189AE7800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FieldMask other); // 0x0000000189AE7800-0x0000000189AE787C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018638F5B8-0x000000018638F608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AE8338-0x0000000189AE8384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189AE881C-0x0000000189AE88C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AE76A8-0x0000000189AE773C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FieldMask other); // 0x0000000189AE7DAC-0x0000000189AE7E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AE874C-0x0000000189AE881C
		internal static string ToJson(IList<string> paths, bool diagnosticOnly); // 0x0000000189AE7FEC-0x0000000189AE8338
		public string ToDiagnosticString(); // 0x0000000189AE7F9C-0x0000000189AE7FEC
		public static FieldMask FromString(string value); // 0x0000000189AE787C-0x0000000189AE7938
		public static FieldMask FromString<T>(string value)
			where T : IMessage;
		public static FieldMask FromStringEnumerable<T>(IEnumerable<string> paths)
			where T : IMessage;
		public static FieldMask FromFieldNumbers<T>(params int[] fieldNumbers)
			where T : IMessage;
		public static FieldMask FromFieldNumbers<T>(IEnumerable<int> fieldNumbers)
			where T : IMessage;
		private static bool IsPathValid(string input); // 0x0000000189AE7B14-0x0000000189AE7B88
		public static bool IsValid<T>(FieldMask fieldMask)
			where T : IMessage;
		public static bool IsValid(MessageDescriptor descriptor, FieldMask fieldMask); // 0x0000000189AE7B88-0x0000000189AE7CF8
		public static bool IsValid<T>(string path)
			where T : IMessage;
		public static bool IsValid(MessageDescriptor descriptor, string path); // 0x0000000189AE7CF8-0x0000000189AE7DAC
		public FieldMask Normalize(); // 0x0000000189AE7F34-0x0000000189AE7F9C
		public FieldMask Union(params FieldMask[] otherMasks); // 0x0000000189AE8384-0x0000000189AE842C
		public FieldMask Intersection(FieldMask additionalMask); // 0x0000000189AE7938-0x0000000189AE7B14
		public void Merge(IMessage source, IMessage destination, MergeOptions options); // 0x0000000189AE7E24-0x0000000189AE7EC0
		public void Merge(IMessage source, IMessage destination); // 0x0000000189AE7EC0-0x0000000189AE7F34
	}

	public static class SourceContextReflection // TypeDefIndex: 55865
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000189AEC5C4-0x0000000189AEC614 
	
		// Constructors
		static SourceContextReflection(); // 0x0000000189AEC26C-0x0000000189AEC5C4
	}

	public sealed class SourceContext : IMessage<SourceContext>, IBufferMessage // TypeDefIndex: 55867
	{
		// Fields
		private static readonly MessageParser<SourceContext> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int FileNameFieldNumber = 1; // Metadata: 0x0234770F
		private string fileName_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SourceContext> Parser { get; } // 0x0000000189AEC9FC-0x0000000189AECA4C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AEC99C-0x0000000189AEC9FC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AECAC8-0x0000000189AECB08 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FileName { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000189AECB08-0x0000000189AECB70
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55866
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189AF03D0-0x0000000189AF0434
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal SourceContext _.cctor_b__27_0(); // 0x0000000189AF0010-0x0000000189AF0060
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceContext(); // 0x0000000189AEC95C-0x0000000189AEC99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceContext(SourceContext other); // 0x0000000189AEC904-0x0000000189AEC95C
		static SourceContext(); // 0x0000000189AEC800-0x0000000189AEC904
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceContext Clone(); // 0x0000000189AEC690-0x0000000189AEC6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AEC6F0-0x0000000189AEC754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SourceContext other); // 0x000000018639C940-0x000000018639C994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018639C9F8-0x000000018639CA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AEC7B4-0x0000000189AEC800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x000000018639CDC4-0x000000018639CE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AEC614-0x0000000189AEC690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SourceContext other); // 0x0000000189AEC754-0x0000000189AEC7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AECA4C-0x0000000189AECAC8
	}

	public static class StructReflection // TypeDefIndex: 55868
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000189AED2E0-0x0000000189AED330 
	
		// Constructors
		static StructReflection(); // 0x0000000189AECB70-0x0000000189AED2E0
	}

	public enum NullValue // TypeDefIndex: 55869
	{
		NullValue = 0
	}

	public sealed class Struct : IMessage<Struct>, IBufferMessage // TypeDefIndex: 55871
	{
		// Fields
		private static readonly MessageParser<Struct> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int FieldsFieldNumber = 1; // Metadata: 0x02347711
		private static readonly MapField<string, Google.Protobuf.WellKnownTypes.Value> _map_fields_codec; // 0x08
		private readonly MapField<string, Google.Protobuf.WellKnownTypes.Value> fields_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Struct> Parser { get; } // 0x0000000189AED918-0x0000000189AED968 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AED8B8-0x0000000189AED918 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AEDADC-0x0000000189AEDB1C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, Google.Protobuf.WellKnownTypes.Value> Fields { get; } // 0x000000018385B100-0x000000018385B110 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55870
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189AF04FC-0x0000000189AF0560
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Struct _.cctor_b__27_0(); // 0x0000000189AEFF70-0x0000000189AEFFC0
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Struct(); // 0x0000000189AED840-0x0000000189AED8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Struct(Struct other); // 0x0000000189AED7B8-0x0000000189AED840
		static Struct(); // 0x0000000189AED5C8-0x0000000189AED7B8
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Struct Clone(); // 0x0000000189AED3C4-0x0000000189AED424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AED424-0x0000000189AED488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Struct other); // 0x0000000189AED488-0x0000000189AED504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018638F5B8-0x000000018638F608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AED57C-0x0000000189AED5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189AEDA38-0x0000000189AEDADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AED330-0x0000000189AED3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Struct other); // 0x0000000189AED504-0x0000000189AED57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AED968-0x0000000189AEDA38
	}

	public sealed class Value : IMessage<Google.Protobuf.WellKnownTypes.Value>, IBufferMessage // TypeDefIndex: 55874
	{
		// Fields
		private static readonly MessageParser<Value> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NullValueFieldNumber = 1; // Metadata: 0x02347712
		public const int NumberValueFieldNumber = 2; // Metadata: 0x02347713
		public const int StringValueFieldNumber = 3; // Metadata: 0x02347714
		public const int BoolValueFieldNumber = 4; // Metadata: 0x02347715
		public const int StructValueFieldNumber = 5; // Metadata: 0x02347716
		public const int ListValueFieldNumber = 6; // Metadata: 0x02347717
		private object kind_; // 0x18
		private KindOneofCase kindCase_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Value> Parser { get; } // 0x0000000189AF36D8-0x0000000189AF3728 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AF3590-0x0000000189AF35F0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AF3B48-0x0000000189AF3B88 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NullValue NullValue { get; set; } // 0x0000000189AF3644-0x0000000189AF368C 0x0000000189AF3C14-0x0000000189AF3C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double NumberValue { get; set; } // 0x0000000189AF368C-0x0000000189AF36D8 0x0000000189AF3C74-0x0000000189AF3CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string StringValue { get; set; } // 0x0000000189AF3728-0x0000000189AF379C 0x0000000189AF3CD8-0x0000000189AF3D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BoolValue { get; set; } // 0x0000000189AF3548-0x0000000189AF3590 0x0000000189AF3B88-0x0000000189AF3BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Struct StructValue { get; set; } // 0x0000000189AF379C-0x0000000189AF37F0 0x0000000189AF3D48-0x0000000189AF3D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ListValue ListValue { get; set; } // 0x0000000189AF35F0-0x0000000189AF3644 0x0000000189AF3BEC-0x0000000189AF3C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KindOneofCase KindCase { get; } // 0x0000000182B70F90-0x0000000182B70FA0 
	
		// Nested types
		public enum KindOneofCase // TypeDefIndex: 55872
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
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55873
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189AF02A4-0x0000000189AF0308
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Value _.cctor_b__58_0(); // 0x0000000189AF0268-0x0000000189AF02A4
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Value(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Value(Value other); // 0x0000000189AF340C-0x0000000189AF3548
		static Value(); // 0x0000000189AF3308-0x0000000189AF340C
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Value Clone(); // 0x0000000189AF2A20-0x0000000189AF2A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearKind(); // 0x00000001863C8830-0x00000001863C8844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AF2A80-0x0000000189AF2AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Value other); // 0x0000000189AF2AE4-0x0000000189AF2C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189AF2F80-0x0000000189AF30D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AF32BC-0x0000000189AF3308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189AF3A1C-0x0000000189AF3B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AF28FC-0x0000000189AF2A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Value other); // 0x0000000189AF30D4-0x0000000189AF32BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AF37F0-0x0000000189AF3A1C
		public static Value ForString(string value); // 0x0000000189AF2E60-0x0000000189AF2EF0
		public static Value ForNumber(double value); // 0x0000000189AF2E00-0x0000000189AF2E60
		public static Value ForBool(bool value); // 0x0000000189AF2C64-0x0000000189AF2CC4
		public static Value ForNull(); // 0x0000000189AF2DAC-0x0000000189AF2E00
		public static Value ForList(params Value[] values); // 0x0000000189AF2CC4-0x0000000189AF2DAC
		public static Value ForStruct(Struct value); // 0x0000000189AF2EF0-0x0000000189AF2F80
	}

	public sealed class ListValue : IMessage<ListValue>, IBufferMessage // TypeDefIndex: 55876
	{
		// Fields
		private static readonly MessageParser<ListValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValuesFieldNumber = 1; // Metadata: 0x0234771F
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Value> _repeated_values_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Value> values_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ListValue> Parser { get; } // 0x0000000189AE8E68-0x0000000189AE8EB8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AE8E08-0x0000000189AE8E68 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AE902C-0x0000000189AE906C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Value> Values { get; } // 0x000000018385B100-0x000000018385B110 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55875
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189AF06F0-0x0000000189AF0754
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal ListValue _.cctor_b__27_0(); // 0x0000000189AEFFC0-0x0000000189AF0010
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ListValue(); // 0x0000000189AE8D90-0x0000000189AE8E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ListValue(ListValue other); // 0x0000000189AE8D08-0x0000000189AE8D90
		static ListValue(); // 0x0000000189AE8B98-0x0000000189AE8D08
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ListValue Clone(); // 0x0000000189AE8994-0x0000000189AE89F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AE89F4-0x0000000189AE8A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ListValue other); // 0x0000000189AE8A58-0x0000000189AE8AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018638F5B8-0x000000018638F608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AE8B4C-0x0000000189AE8B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189AE8F88-0x0000000189AE902C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AE8900-0x0000000189AE8994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ListValue other); // 0x0000000189AE8AD4-0x0000000189AE8B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AE8EB8-0x0000000189AE8F88
	}

	public static class TimeExtensions // TypeDefIndex: 55877
	{
		// Extension methods
		public static Timestamp ToTimestamp(this System.DateTime dateTime); // 0x0000000189AEDB68-0x0000000189AEDBB4
		public static Timestamp ToTimestamp(this DateTimeOffset dateTimeOffset); // 0x0000000189AEDBB4-0x0000000189AEDC08
		public static Duration ToDuration(this TimeSpan timeSpan); // 0x0000000189AEDB1C-0x0000000189AEDB68
	}

	public static class TimestampReflection // TypeDefIndex: 55878
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000189AEDF80-0x0000000189AEDFD0 
	
		// Constructors
		static TimestampReflection(); // 0x0000000189AEDC08-0x0000000189AEDF80
	}

	public sealed class Timestamp : IMessage<Timestamp>, IBufferMessage, ICustomDiagnosticMessage, IComparable<Timestamp> // TypeDefIndex: 55880
	{
		// Fields
		private static readonly MessageParser<Timestamp> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int SecondsFieldNumber = 1; // Metadata: 0x02347720
		private long seconds_; // 0x18
		public const int NanosFieldNumber = 2; // Metadata: 0x02347721
		private int nanos_; // 0x20
		private static readonly System.DateTime UnixEpoch; // 0x08
		private const long BclSecondsAtUnixEpoch = 62135596800; // Metadata: 0x02347722
		internal const long UnixSecondsAtBclMaxValue = 253402300799; // Metadata: 0x0234772A
		internal const long UnixSecondsAtBclMinValue = -62135596800; // Metadata: 0x02347732
		internal const int MaxNanos = 999999999; // Metadata: 0x0234773A
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Timestamp> Parser { get; } // 0x0000000189AEEB8C-0x0000000189AEEBDC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AEEAF8-0x0000000189AEEB8C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AEF0CC-0x0000000189AEF10C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Seconds { get; set; } // 0x000000018385B100-0x000000018385B110 0x00000001811EC9D0-0x00000001811EC9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Nanos { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55879
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189AF0498-0x0000000189AF04FC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Timestamp _.cctor_b__55_0(); // 0x0000000189AF018C-0x0000000189AF01C8
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Timestamp(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Timestamp(Timestamp other); // 0x000000018637B49C-0x000000018637B4E0
		static Timestamp(); // 0x0000000189AEE998-0x0000000189AEEAF8
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Timestamp Clone(); // 0x0000000189AEE06C-0x0000000189AEE0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AEE160-0x0000000189AEE1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Timestamp other); // 0x000000018637BDB8-0x000000018637BDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018637BDEC-0x000000018637BE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AEE94C-0x0000000189AEE998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x000000018637C018-0x000000018637C090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AEDFD0-0x0000000189AEE06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Timestamp other); // 0x0000000189AEE3C0-0x0000000189AEE458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x000000018637BF80-0x000000018637C018
		private static bool IsNormalized(long seconds, int nanoseconds); // 0x0000000189AEE394-0x0000000189AEE3C0
		public static Duration operator -(Timestamp lhs, Timestamp rhs); // 0x0000000189AEEE28-0x0000000189AEEF74
		public static Timestamp operator +(Timestamp lhs, Duration rhs); // 0x0000000189AEEBDC-0x0000000189AEED2C
		public static Timestamp operator -(Timestamp lhs, Duration rhs); // 0x0000000189AEEF74-0x0000000189AEF0CC
		public System.DateTime ToDateTime(); // 0x0000000189AEE55C-0x0000000189AEE684
		public DateTimeOffset ToDateTimeOffset(); // 0x0000000189AEE4E4-0x0000000189AEE55C
		public static Timestamp FromDateTime(System.DateTime dateTime); // 0x0000000189AEE22C-0x0000000189AEE394
		public static Timestamp FromDateTimeOffset(DateTimeOffset dateTimeOffset); // 0x0000000189AEE1C4-0x0000000189AEE22C
		internal static Timestamp Normalize(long seconds, int nanoseconds); // 0x0000000189AEE458-0x0000000189AEE4E4
		internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly); // 0x0000000189AEE6DC-0x0000000189AEE94C
		public int CompareTo(Timestamp other); // 0x0000000189AEE0CC-0x0000000189AEE160
		public static bool operator <(Timestamp a, Timestamp b); // 0x0000000189AEEE08-0x0000000189AEEE28
		public static bool operator >(Timestamp a, Timestamp b); // 0x0000000189AEED6C-0x0000000189AEED90
		public static bool operator <=(Timestamp a, Timestamp b); // 0x0000000189AEEDE4-0x0000000189AEEE08
		public static bool operator >=(Timestamp a, Timestamp b); // 0x0000000189AEED48-0x0000000189AEED6C
		public static bool operator ==(Timestamp a, Timestamp b); // 0x0000000189AEED2C-0x0000000189AEED48
		public static bool operator !=(Timestamp a, Timestamp b); // 0x0000000189AEED90-0x0000000189AEEDE4
		public string ToDiagnosticString(); // 0x0000000189AEE684-0x0000000189AEE6DC
	}

	public static class TypeReflection // TypeDefIndex: 55881
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000189AEFEA0-0x0000000189AEFEF0 
	
		// Constructors
		static TypeReflection(); // 0x0000000189AEF10C-0x0000000189AEFEA0
	}

	public enum Syntax // TypeDefIndex: 55882
	{
		Proto2 = 0,
		Proto3 = 1
	}

	public sealed class Type : IMessage<Google.Protobuf.WellKnownTypes.Type>, IBufferMessage // TypeDefIndex: 55884
	{
		// Fields
		private static readonly MessageParser<Type> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x02347741
		private string name_; // 0x18
		public const int FieldsFieldNumber = 2; // Metadata: 0x02347742
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Field> _repeated_fields_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Field> fields_; // 0x20
		public const int OneofsFieldNumber = 3; // Metadata: 0x02347743
		private static readonly FieldCodec<string> _repeated_oneofs_codec; // 0x10
		private readonly RepeatedField<string> oneofs_; // 0x28
		public const int OptionsFieldNumber = 4; // Metadata: 0x02347744
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x18
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x30
		public const int SourceContextFieldNumber = 5; // Metadata: 0x02347745
		private SourceContext sourceContext_; // 0x38
		public const int SyntaxFieldNumber = 6; // Metadata: 0x02347746
		private Google.Protobuf.WellKnownTypes.Syntax syntax_; // 0x40
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Type> Parser { get; } // 0x0000000189B06FAC-0x0000000189B06FFC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B06F4C-0x0000000189B06FAC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B073A4-0x0000000189B073E4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000189B073E4-0x0000000189B0744C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Field> Fields { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Oneofs { get; } // 0x0000000184D86240-0x0000000184D86250 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceContext SourceContext { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Google.Protobuf.WellKnownTypes.Syntax Syntax { get; set; } // 0x0000000184D865E0-0x0000000184D865F0 0x0000000184D86610-0x0000000184D86620
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55883
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B07B18-0x0000000189B07B7C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Type _.cctor_b__52_0(); // 0x0000000189B07910-0x0000000189B07960
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Type(); // 0x0000000189B06CEC-0x0000000189B06E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Type(Type other); // 0x0000000189B06E18-0x0000000189B06F4C
		static Type(); // 0x0000000189B06AE0-0x0000000189B06CEC
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Type Clone(); // 0x0000000189B06680-0x0000000189B066E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B067EC-0x0000000189B06850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Type other); // 0x0000000189B066E0-0x0000000189B067EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B06850-0x0000000189B06930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B06A94-0x0000000189B06AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B0721C-0x0000000189B073A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B064E8-0x0000000189B06680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Type other); // 0x0000000189B06930-0x0000000189B06A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B06FFC-0x0000000189B0721C
	}

	public sealed class Field : IMessage<Google.Protobuf.WellKnownTypes.Field>, IBufferMessage // TypeDefIndex: 55889
	{
		// Fields
		private static readonly MessageParser<Field> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int KindFieldNumber = 1; // Metadata: 0x02347747
		private Types.Kind kind_; // 0x18
		public const int CardinalityFieldNumber = 2; // Metadata: 0x02347748
		private Types.Cardinality cardinality_; // 0x1C
		public const int NumberFieldNumber = 3; // Metadata: 0x02347749
		private int number_; // 0x20
		public const int NameFieldNumber = 4; // Metadata: 0x0234774A
		private string name_; // 0x28
		public const int TypeUrlFieldNumber = 6; // Metadata: 0x0234774B
		private string typeUrl_; // 0x30
		public const int OneofIndexFieldNumber = 7; // Metadata: 0x0234774C
		private int oneofIndex_; // 0x38
		public const int PackedFieldNumber = 8; // Metadata: 0x0234774D
		private bool packed_; // 0x3C
		public const int OptionsFieldNumber = 9; // Metadata: 0x0234774E
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x40
		public const int JsonNameFieldNumber = 10; // Metadata: 0x0234774F
		private string jsonName_; // 0x48
		public const int DefaultValueFieldNumber = 11; // Metadata: 0x02347750
		private string defaultValue_; // 0x50
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Field> Parser { get; } // 0x0000000189B01440-0x0000000189B01490 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B013E0-0x0000000189B01440 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B018A4-0x0000000189B018E4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.Kind Kind { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Types.Cardinality Cardinality { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Number { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000189B019B4-0x0000000189B01A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TypeUrl { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000189B01A1C-0x0000000189B01A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OneofIndex { get; set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Packed { get; set; } // 0x0000000184D86BD0-0x0000000184D86BE0 0x0000000184D86BE0-0x0000000184D86BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string JsonName { get; set; } // 0x0000000184D86200-0x0000000184D86210 0x0000000189B0194C-0x0000000189B019B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DefaultValue { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000189B018E4-0x0000000189B0194C
	
		// Nested types
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types // TypeDefIndex: 55887
		{
			// Nested types
			public enum Kind // TypeDefIndex: 55885
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
	
			public enum Cardinality // TypeDefIndex: 55886
			{
				Unknown = 0,
				Optional = 1,
				Required = 2,
				Repeated = 3
			}
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55888
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B08090-0x0000000189B080F4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Field _.cctor_b__73_0(); // 0x0000000189B07960-0x0000000189B079B0
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Field(); // 0x0000000189B0130C-0x0000000189B013E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Field(Field other); // 0x0000000189B0121C-0x0000000189B0130C
		static Field(); // 0x0000000189B010AC-0x0000000189B0121C
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Field Clone(); // 0x0000000189B00C34-0x0000000189B00C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B00DA0-0x0000000189B00E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Field other); // 0x0000000189B00C94-0x0000000189B00DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B00E04-0x0000000189B00F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B01060-0x0000000189B010AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189B016A4-0x0000000189B018A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B00A1C-0x0000000189B00C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Field other); // 0x0000000189B00F2C-0x0000000189B01060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B01490-0x0000000189B016A4
	}

	public sealed class Enum : IMessage<Google.Protobuf.WellKnownTypes.Enum>, IBufferMessage // TypeDefIndex: 55891
	{
		// Fields
		private static readonly MessageParser<Enum> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x02347768
		private string name_; // 0x18
		public const int EnumvalueFieldNumber = 2; // Metadata: 0x02347769
		private static readonly FieldCodec<EnumValue> _repeated_enumvalue_codec; // 0x08
		private readonly RepeatedField<EnumValue> enumvalue_; // 0x20
		public const int OptionsFieldNumber = 3; // Metadata: 0x0234776A
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x10
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x28
		public const int SourceContextFieldNumber = 4; // Metadata: 0x0234776B
		private SourceContext sourceContext_; // 0x30
		public const int SyntaxFieldNumber = 5; // Metadata: 0x0234776C
		private Google.Protobuf.WellKnownTypes.Syntax syntax_; // 0x38
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Enum> Parser { get; } // 0x0000000189AFDDCC-0x0000000189AFDE1C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AFDD6C-0x0000000189AFDDCC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AFE138-0x0000000189AFE178 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000189AFE178-0x0000000189AFE1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnumValue> Enumvalue { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get; } // 0x0000000184D86240-0x0000000184D86250 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceContext SourceContext { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Google.Protobuf.WellKnownTypes.Syntax Syntax { get; set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55890
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B080F4-0x0000000189B08158
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Enum _.cctor_b__47_0(); // 0x0000000189B078C0-0x0000000189B07910
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Enum(); // 0x0000000189AFDB88-0x0000000189AFDC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Enum(Enum other); // 0x0000000189AFDC68-0x0000000189AFDD6C
		static Enum(); // 0x0000000189AFD9B0-0x0000000189AFDB88
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Enum Clone(); // 0x0000000189AFD5C8-0x0000000189AFD628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AFD628-0x0000000189AFD68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Enum other); // 0x0000000189AFD68C-0x0000000189AFD76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189AFD76C-0x0000000189AFD828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AFD964-0x0000000189AFD9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189AFDFEC-0x0000000189AFE138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AFD45C-0x0000000189AFD5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Enum other); // 0x0000000189AFD828-0x0000000189AFD964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AFDE1C-0x0000000189AFDFEC
	}

	public sealed class EnumValue : IMessage<EnumValue>, IBufferMessage // TypeDefIndex: 55893
	{
		// Fields
		private static readonly MessageParser<EnumValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x0234776D
		private string name_; // 0x18
		public const int NumberFieldNumber = 2; // Metadata: 0x0234776E
		private int number_; // 0x20
		public const int OptionsFieldNumber = 3; // Metadata: 0x0234776F
		private static readonly FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec; // 0x08
		private readonly RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_; // 0x28
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnumValue> Parser { get; } // 0x0000000189AFD14C-0x0000000189AFD19C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AFD0EC-0x0000000189AFD14C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AFD3B4-0x0000000189AFD3F4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000189AFD3F4-0x0000000189AFD45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Number { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Google.Protobuf.WellKnownTypes.Option> Options { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55892
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B07FC8-0x0000000189B0802C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal EnumValue _.cctor_b__37_0(); // 0x0000000189B077A8-0x0000000189B077F8
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValue(); // 0x0000000189AFD054-0x0000000189AFD0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValue(EnumValue other); // 0x0000000189AFCFB4-0x0000000189AFD054
		static EnumValue(); // 0x0000000189AFCE44-0x0000000189AFCFB4
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnumValue Clone(); // 0x0000000189AFCBF8-0x0000000189AFCC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AFCC58-0x0000000189AFCCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnumValue other); // 0x0000000189AFCCBC-0x0000000189AFCD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x00000001863CF728-0x00000001863CF7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AFCDF8-0x0000000189AFCE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000189AFD2C0-0x0000000189AFD3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AFCAFC-0x0000000189AFCBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnumValue other); // 0x0000000189AFCD54-0x0000000189AFCDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AFD19C-0x0000000189AFD2C0
	}

	public sealed class Option : IMessage<Google.Protobuf.WellKnownTypes.Option>, IBufferMessage // TypeDefIndex: 55895
	{
		// Fields
		private static readonly MessageParser<Option> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int NameFieldNumber = 1; // Metadata: 0x02347770
		private string name_; // 0x18
		public const int ValueFieldNumber = 2; // Metadata: 0x02347771
		private Any value_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Option> Parser { get; } // 0x0000000189B056BC-0x0000000189B0570C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B0565C-0x0000000189B056BC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B05800-0x0000000189B05840 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000189B05840-0x0000000189B058A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Any Value { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55894
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B07D0C-0x0000000189B07D70
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Option _.cctor_b__32_0(); // 0x0000000189B0771C-0x0000000189B0776C
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Option(); // 0x0000000189B0561C-0x0000000189B0565C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Option(Option other); // 0x0000000189B055A0-0x0000000189B0561C
		static Option(); // 0x0000000189B0549C-0x0000000189B055A0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Option Clone(); // 0x0000000189B052B0-0x0000000189B05310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B05310-0x0000000189B05374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Option other); // 0x00000001863D1E6C-0x00000001863D1ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x00000001863D1ED4-0x00000001863D1F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B05450-0x0000000189B0549C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x00000001863D2324-0x00000001863D23A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B05204-0x0000000189B052B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Option other); // 0x0000000189B05374-0x0000000189B05450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B0570C-0x0000000189B05800
	}

	public static class WrappersReflection // TypeDefIndex: 55896
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
		internal const int WrapperValueFieldNumber = 1; // Metadata: 0x02347772
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x0000000189B09530-0x0000000189B09678 
	
		// Constructors
		static WrappersReflection(); // 0x0000000189B089CC-0x0000000189B09530
	}

	public sealed class DoubleValue : IMessage<DoubleValue>, IBufferMessage // TypeDefIndex: 55898
	{
		// Fields
		private static readonly MessageParser<DoubleValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x02347773
		private double value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DoubleValue> Parser { get; } // 0x0000000189AFBB10-0x0000000189AFBB60 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AFBAB0-0x0000000189AFBB10 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AFBB60-0x0000000189AFBBA0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Value { get; set; } // 0x0000000184D86360-0x0000000184D86370 0x0000000184D86370-0x0000000184D86380
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55897
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B0802C-0x0000000189B08090
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal DoubleValue _.cctor_b__27_0(); // 0x0000000189B076E0-0x0000000189B0771C
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoubleValue(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoubleValue(DoubleValue other); // 0x000000018638E034-0x000000018638E070
		static DoubleValue(); // 0x0000000189AFB9AC-0x0000000189AFBAB0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoubleValue Clone(); // 0x0000000189AFB77C-0x0000000189AFB7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AFB868-0x0000000189AFB8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DoubleValue other); // 0x0000000189AFB7DC-0x0000000189AFB868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189AFB8CC-0x0000000189AFB960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AFB960-0x0000000189AFB9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000186619F80-0x0000000186619FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000186619B4C-0x0000000186619B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DoubleValue other); // 0x0000000186619D6C-0x0000000186619DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000186619F0C-0x0000000186619F80
	}

	public sealed class FloatValue : IMessage<FloatValue>, IBufferMessage // TypeDefIndex: 55900
	{
		// Fields
		private static readonly MessageParser<FloatValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x02347774
		private float value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloatValue> Parser { get; } // 0x0000000189B0422C-0x0000000189B0427C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B041CC-0x0000000189B0422C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B0427C-0x0000000189B042BC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Value { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55899
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B07F64-0x0000000189B07FC8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal FloatValue _.cctor_b__27_0(); // 0x0000000189B07668-0x0000000189B076A4
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloatValue(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloatValue(FloatValue other); // 0x00000001863BE028-0x00000001863BE064
		static FloatValue(); // 0x0000000189B040C8-0x0000000189B041CC
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloatValue Clone(); // 0x0000000189B03E94-0x0000000189B03EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B03EF4-0x0000000189B03F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloatValue other); // 0x0000000189B03F58-0x0000000189B03FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189B03FE8-0x0000000189B0407C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B0407C-0x0000000189B040C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x00000001866536E8-0x0000000186653748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x00000001866532B4-0x00000001866532F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloatValue other); // 0x00000001866534D8-0x0000000186653520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000186653674-0x00000001866536E8
	}

	public sealed class Int64Value : IMessage<Int64Value>, IBufferMessage // TypeDefIndex: 55902
	{
		// Fields
		private static readonly MessageParser<Int64Value> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x02347775
		private long value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Int64Value> Parser { get; } // 0x0000000189B04910-0x0000000189B04960 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B048B0-0x0000000189B04910 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B04960-0x0000000189B049A0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Value { get; set; } // 0x000000018385B100-0x000000018385B110 0x00000001811EC9D0-0x00000001811EC9E0
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55901
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B07F00-0x0000000189B07F64
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Int64Value _.cctor_b__27_0(); // 0x0000000189B076A4-0x0000000189B076E0
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int64Value(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int64Value(Int64Value other); // 0x000000018638E034-0x000000018638E070
		static Int64Value(); // 0x0000000189B047AC-0x0000000189B048B0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int64Value Clone(); // 0x0000000189B0469C-0x0000000189B046FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B046FC-0x0000000189B04760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Int64Value other); // 0x000000018638DE34-0x000000018638DE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018638DE60-0x000000018638DEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B04760-0x0000000189B047AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x000000018638E194-0x000000018638E1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B0462C-0x0000000189B0469C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Int64Value other); // 0x000000018638DEA4-0x000000018638DEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x000000018638E120-0x000000018638E194
	}

	public sealed class UInt64Value : IMessage<UInt64Value>, IBufferMessage // TypeDefIndex: 55904
	{
		// Fields
		private static readonly MessageParser<UInt64Value> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x02347776
		private ulong value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UInt64Value> Parser { get; } // 0x0000000189B0893C-0x0000000189B0898C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B088DC-0x0000000189B0893C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B0898C-0x0000000189B089CC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong Value { get; set; } // 0x000000018385B100-0x000000018385B110 0x00000001811EC9D0-0x00000001811EC9E0
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55903
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B07E9C-0x0000000189B07F00
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UInt64Value _.cctor_b__27_0(); // 0x0000000189B07514-0x0000000189B07550
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UInt64Value(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UInt64Value(UInt64Value other); // 0x000000018638E034-0x000000018638E070
		static UInt64Value(); // 0x0000000189B087D8-0x0000000189B088DC
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UInt64Value Clone(); // 0x0000000189B086C8-0x0000000189B08728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B08728-0x0000000189B0878C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UInt64Value other); // 0x000000018638DE34-0x000000018638DE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x00000001863A2E14-0x00000001863A2E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B0878C-0x0000000189B087D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x000000018638E194-0x000000018638E1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B08658-0x0000000189B086C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UInt64Value other); // 0x000000018638DEA4-0x000000018638DEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x000000018638E120-0x000000018638E194
	}

	public sealed class Int32Value : IMessage<Int32Value>, IBufferMessage // TypeDefIndex: 55906
	{
		// Fields
		private static readonly MessageParser<Int32Value> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x02347777
		private int value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Int32Value> Parser { get; } // 0x0000000189B0459C-0x0000000189B045EC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B0453C-0x0000000189B0459C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B045EC-0x0000000189B0462C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Value { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55905
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B07CA8-0x0000000189B07D0C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Int32Value _.cctor_b__27_0(); // 0x0000000189B0762C-0x0000000189B07668
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int32Value(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int32Value(Int32Value other); // 0x00000001863BE028-0x00000001863BE064
		static Int32Value(); // 0x0000000189B04438-0x0000000189B0453C
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int32Value Clone(); // 0x0000000189B04328-0x0000000189B04388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B04388-0x0000000189B043EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Int32Value other); // 0x00000001863BDE20-0x00000001863BDE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x00000001863BDEB0-0x00000001863BDEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B043EC-0x0000000189B04438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x00000001811EF950-0x00000001811EF9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B042BC-0x0000000189B04328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Int32Value other); // 0x00000001863BDEE8-0x00000001863BDF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x00000001863BE0B4-0x00000001863BE124
	}

	public sealed class UInt32Value : IMessage<UInt32Value>, IBufferMessage // TypeDefIndex: 55908
	{
		// Fields
		private static readonly MessageParser<UInt32Value> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x02347778
		private uint value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UInt32Value> Parser { get; } // 0x0000000189B085C8-0x0000000189B08618 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B08568-0x0000000189B085C8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B08618-0x0000000189B08658 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Value { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55907
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B07C44-0x0000000189B07CA8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UInt32Value _.cctor_b__27_0(); // 0x0000000189B074D8-0x0000000189B07514
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UInt32Value(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UInt32Value(UInt32Value other); // 0x00000001863BE028-0x00000001863BE064
		static UInt32Value(); // 0x0000000189B08464-0x0000000189B08568
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UInt32Value Clone(); // 0x0000000189B08354-0x0000000189B083B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B083B4-0x0000000189B08418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UInt32Value other); // 0x00000001863BDE20-0x00000001863BDE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x00000001863BDEB0-0x00000001863BDEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B08418-0x0000000189B08464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x00000001864B2684-0x00000001864B26D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B082E8-0x0000000189B08354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UInt32Value other); // 0x00000001863BDEE8-0x00000001863BDF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x00000001863BE0B4-0x00000001863BE124
	}

	public sealed class BoolValue : IMessage<BoolValue>, IBufferMessage // TypeDefIndex: 55910
	{
		// Fields
		private static readonly MessageParser<BoolValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x02347779
		private bool value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BoolValue> Parser { get; } // 0x0000000189AF5D34-0x0000000189AF5D84 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AF5CD4-0x0000000189AF5D34 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AF5D84-0x0000000189AF5DC4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Value { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55909
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B08284-0x0000000189B082E8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal BoolValue _.cctor_b__27_0(); // 0x0000000189B07550-0x0000000189B0758C
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoolValue(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoolValue(BoolValue other); // 0x00000001863D6A44-0x00000001863D6A80
		static BoolValue(); // 0x0000000189AF5BD0-0x0000000189AF5CD4
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoolValue Clone(); // 0x0000000189AF5A58-0x0000000189AF5AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AF5AB8-0x0000000189AF5B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoolValue other); // 0x00000001863D6870-0x00000001863D689C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000189AF5B1C-0x0000000189AF5B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AF5B84-0x0000000189AF5BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x00000001863D6B3C-0x00000001863D6B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x00000001863D677C-0x00000001863D67AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoolValue other); // 0x00000001863D6904-0x00000001863D6940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x00000001863D6AD0-0x00000001863D6B3C
	}

	public sealed class StringValue : IMessage<StringValue>, IBufferMessage // TypeDefIndex: 55912
	{
		// Fields
		private static readonly MessageParser<StringValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x0234777A
		private string value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StringValue> Parser { get; } // 0x0000000189B06374-0x0000000189B063C4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189B06314-0x0000000189B06374 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189B06440-0x0000000189B06480 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Value { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000189B06480-0x0000000189B064E8
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55911
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B08158-0x0000000189B081BC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal StringValue _.cctor_b__27_0(); // 0x0000000189B075DC-0x0000000189B0762C
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StringValue(); // 0x0000000189B0627C-0x0000000189B062BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StringValue(StringValue other); // 0x0000000189B062BC-0x0000000189B06314
		static StringValue(); // 0x0000000189B06178-0x0000000189B0627C
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StringValue Clone(); // 0x0000000189B06008-0x0000000189B06068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189B06068-0x0000000189B060CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StringValue other); // 0x000000018639C940-0x000000018639C994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018639C9F8-0x000000018639CA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189B0612C-0x0000000189B06178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x000000018639CDC4-0x000000018639CE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189B05F8C-0x0000000189B06008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StringValue other); // 0x0000000189B060CC-0x0000000189B0612C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189B063C4-0x0000000189B06440
	}

	public sealed class BytesValue : IMessage<BytesValue>, IBufferMessage // TypeDefIndex: 55914
	{
		// Fields
		private static readonly MessageParser<BytesValue> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValueFieldNumber = 1; // Metadata: 0x0234777B
		private ByteString value_; // 0x18
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BytesValue> Parser { get; } // 0x0000000189AF6258-0x0000000189AF62A8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000189AF61F8-0x0000000189AF6258 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x0000000189AF6324-0x0000000189AF6364 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString Value { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000189AF6364-0x0000000189AF63CC
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55913
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000189B08220-0x0000000189B08284
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal BytesValue _.cctor_b__27_0(); // 0x0000000189B07488-0x0000000189B074D8
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BytesValue(); // 0x0000000189AF61A4-0x0000000189AF61F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BytesValue(BytesValue other); // 0x0000000189AF614C-0x0000000189AF61A4
		static BytesValue(); // 0x0000000189AF6048-0x0000000189AF614C
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BytesValue Clone(); // 0x0000000189AF5E44-0x0000000189AF5EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000189AF5F38-0x0000000189AF5F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BytesValue other); // 0x0000000189AF5EA4-0x0000000189AF5F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x00000001863E7124-0x00000001863E7180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000189AF5FFC-0x0000000189AF6048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x00000001863E745C-0x00000001863E74C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000189AF5DC4-0x0000000189AF5E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BytesValue other); // 0x0000000189AF5F9C-0x0000000189AF5FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000189AF62A8-0x0000000189AF6324
	}
}

namespace System.Diagnostics.CodeAnalysis
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, Inherited = false)]
	internal sealed class DynamicallyAccessedMembersAttribute : Attribute // TypeDefIndex: 55751
	{
		// Fields
		[CompilerGenerated]
		private readonly DynamicallyAccessedMemberTypes _MemberTypes_k__BackingField; // 0x10
	
		// Properties
		public DynamicallyAccessedMemberTypes MemberTypes { [CompilerGenerated] get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
	
		// Constructors
		public DynamicallyAccessedMembersAttribute(DynamicallyAccessedMemberTypes memberTypes); // 0x00000001814F51F0-0x00000001814F5220
	}

	[Flags]
	internal enum DynamicallyAccessedMemberTypes // TypeDefIndex: 55752
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
	internal sealed class RequiresUnreferencedCodeAttribute : Attribute // TypeDefIndex: 55753
	{
		// Fields
		[CompilerGenerated]
		private readonly string _Message_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Url_k__BackingField; // 0x18
	
		// Properties
		public string Message { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public string Url { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		public RequiresUnreferencedCodeAttribute(string message); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All, Inherited = false, AllowMultiple = true)]
	internal sealed class UnconditionalSuppressMessageAttribute : Attribute // TypeDefIndex: 55754
	{
		// Fields
		[CompilerGenerated]
		private readonly string _Category_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly string _CheckId_k__BackingField; // 0x18
		[CompilerGenerated]
		private string _Scope_k__BackingField; // 0x20
		[CompilerGenerated]
		private string _Target_k__BackingField; // 0x28
		[CompilerGenerated]
		private string _MessageId_k__BackingField; // 0x30
		[CompilerGenerated]
		private string _Justification_k__BackingField; // 0x38
	
		// Properties
		public string Category { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public string CheckId { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
		public string Scope { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public string Target { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public string MessageId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public string Justification { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
	
		// Constructors
		public UnconditionalSuppressMessageAttribute(string category, string checkId); // 0x00000001832AF420-0x00000001832AF450
	}
}
