/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 137: Common.Beyond.XXEnc.dll - Assembly: Common.Beyond.XXEnc, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63827-63832
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.XXEnc
{
	public sealed class XXE1 : IDisposable // TypeDefIndex: 63831
	{
		// Fields
		public const int allowedKeyLength = 32; // Metadata: 0x02353694
		public const int allowedNonceLength = 12; // Metadata: 0x02353695
		public const int processBytesAtTime = 64; // Metadata: 0x02353696
		private const int stateLength = 16; // Metadata: 0x02353698
		private readonly uint[] state; // 0x10
		private bool isDisposed; // 0x18
		private uint[] x; // 0x20
		private byte[] tmp; // 0x28
		private byte processedIdx; // 0x30
		private static readonly byte[] sigma; // 0x00
		private static readonly byte[] tau; // 0x08
	
		// Properties
		public uint[] State { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Nested types
		[CompilerGenerated]
		private struct _EncryptStreamAsync_d__18 : IAsyncStateMachine // TypeDefIndex: 63828
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public XXE1 __4__this; // 0x20
			public Stream output; // 0x28
			public Stream input; // 0x30
			public int howManyBytesToProcessAtTime; // 0x38
			private TaskAwaiter __u__1; // 0x40
	
			// Methods
			private void MoveNext(); // 0x00000001867CEE50-0x00000001867CEFF4
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001867CEFF4-0x00000001867CF050
		}
	
		[CompilerGenerated]
		private struct _DecryptStreamAsync_d__29 : IAsyncStateMachine // TypeDefIndex: 63829
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public XXE1 __4__this; // 0x20
			public Stream output; // 0x28
			public Stream input; // 0x30
			public int howManyBytesToProcessAtTime; // 0x38
			private TaskAwaiter __u__1; // 0x40
	
			// Methods
			private void MoveNext(); // 0x00000001867CEC50-0x00000001867CEDF4
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001867CEDF4-0x00000001867CEE50
		}
	
		[CompilerGenerated]
		private struct _WorkStreamsAsync_d__35 : IAsyncStateMachine // TypeDefIndex: 63830
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public int howManyBytesToProcessAtTime; // 0x20
			public Stream input; // 0x28
			public XXE1 __4__this; // 0x30
			public Stream output; // 0x38
			private byte[] _readBytesBuffer_5__2; // 0x40
			private byte[] _writeBytesBuffer_5__3; // 0x48
			private TaskAwaiter<int> __u__1; // 0x50
			private TaskAwaiter __u__2; // 0x58
	
			// Methods
			private void MoveNext(); // 0x00000001867CF050-0x00000001867CF47C
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001867CF47C-0x00000001867CF4D8
		}
	
		// Constructors
		public XXE1(ReadOnlySpan<byte> key, ReadOnlySpan<byte> nonce, uint counter); // 0x0000000182F225D0-0x0000000182F22830
		static XXE1(); // 0x0000000184CAF1A0-0x0000000184CAF270
	
		// Methods
		private void KeySetup(ReadOnlySpan<byte> key); // 0x0000000182F80600-0x0000000182F80D20
		private void IvSetup(ReadOnlySpan<byte> nonce, uint counter); // 0x0000000182F22830-0x0000000182F22C10
		public void EncryptBytes(byte[] output, byte[] input, int numBytes); // 0x00000001867CF6CC-0x00000001867CF6DC
		public void EncryptStream(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x02353688 */); // 0x00000001867CF7D4-0x00000001867CF7E4
		public async System.Threading.Tasks.Task EncryptStreamAsync(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x0235368A */); // 0x00000001867CF9A0-0x00000001867CFA98
		public void EncryptBytes(byte[] output, byte[] input); // 0x00000001867CF8F0-0x00000001867CF924
		public void TransformBytes(byte[] inoutput); // 0x0000000182F22C10-0x0000000182F22C40
		public void TransformBytes(byte[] inoutput, int inoffset, int len); // 0x0000000185391348-0x000000018539136C
		public void TransformBytes(Span<byte> inoutput); // 0x0000000185391394-0x00000001853913BC
		public void CreateWorkSpace(); // 0x00000001841E1670-0x00000001841E1680
		public byte[] EncryptBytes(byte[] input, int numBytes); // 0x00000001867CF924-0x00000001867CF9A0
		public byte[] EncryptBytes(byte[] input); // 0x00000001867CF874-0x00000001867CF8F0
		public byte[] EncryptString(string input); // 0x00000001867CFA98-0x00000001867CFB30
		public void DecryptBytes(byte[] output, byte[] input, int numBytes); // 0x00000001867CF6CC-0x00000001867CF6DC
		public void DecryptStream(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x0235368C */); // 0x00000001867CF7D4-0x00000001867CF7E4
		public async System.Threading.Tasks.Task DecryptStreamAsync(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x0235368E */); // 0x00000001867CF6DC-0x00000001867CF7D4
		public void DecryptBytes(byte[] output, byte[] input); // 0x00000001867CF6A8-0x00000001867CF6CC
		public byte[] DecryptBytes(byte[] input, int numBytes); // 0x00000001867CF62C-0x00000001867CF6A8
		public byte[] DecryptBytes(byte[] input); // 0x00000001867CF5B0-0x00000001867CF62C
		public string DecryptUTF8ByteArray(byte[] input); // 0x00000001867CF7E4-0x00000001867CF874
		private void WorkStreams(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x02353690 */); // 0x00000001867CFC78-0x00000001867CFDA0
		private async System.Threading.Tasks.Task WorkStreamsAsync(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x02353692 */); // 0x00000001867CFB80-0x00000001867CFC78
		private void WorkBytes(byte[] inoutput); // 0x00000001867CFB30-0x00000001867CFB5C
		private void WorkBytes(byte[] output, byte[] input, int numBytes); // 0x00000001867CFB5C-0x00000001867CFB80
		private void WorkBytes(byte[] output, int outoffset, byte[] input, int inoffset, int numBytes); // 0x0000000182EFF3D0-0x0000000182EFF4E0
		private void WorkBytes(Span<byte> output, Span<byte> input); // 0x0000000182F804B0-0x0000000182F805A0
		private void RecalXORStream(); // 0x0000000182EFEEE0-0x0000000182EFF190
		private static void QuarterRound(uint[] x, uint a, uint b, uint c, uint d); // 0x0000000182EFF4E0-0x0000000182EFF640
		~XXE1(); // 0x0000000183128790-0x00000001831287E0
		public void Dispose(); // 0x0000000183352F30-0x0000000183352F90
		private void Dispose(bool disposing); // 0x00000001831286A0-0x0000000183128790
	}

	public static class Util // TypeDefIndex: 63832
	{
		// Methods
		public static uint Rotate(uint v, int c); // 0x0000000184D882E0-0x0000000184D88300
		public static uint XOr(uint v, uint w); // 0x0000000184D88300-0x0000000184D88310
		public static uint Add(uint v, uint w); // 0x0000000184D882D0-0x0000000184D882E0
		public static uint AddOne(uint v); // 0x0000000184D882C0-0x0000000184D882D0
		public static uint U8To32Little(ReadOnlySpan<byte> p, int inputOffset); // 0x00000001867CF540-0x00000001867CF5B0
		public static void ToBytes(byte[] output, uint input, int outputOffset); // 0x00000001867CF4D8-0x00000001867CF540
	}
}
