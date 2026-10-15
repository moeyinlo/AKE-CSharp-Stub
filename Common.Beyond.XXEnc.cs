/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 136: Common.Beyond.XXEnc.dll - Assembly: Common.Beyond.XXEnc, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91290-91295

namespace Beyond.XXEnc
{
	public sealed class XXE1 : IDisposable // TypeDefIndex: 91294
	{
		// Fields
		public const int allowedKeyLength = 32; // Metadata: 0x0264C018
		public const int allowedNonceLength = 12; // Metadata: 0x0264C019
		public const int processBytesAtTime = 64; // Metadata: 0x0264C01A
		private const int stateLength = 16; // Metadata: 0x0264C01C
		private readonly uint[] state; // 0x10
		private bool isDisposed; // 0x18
		private uint[] x; // 0x20
		private byte[] tmp; // 0x28
		private byte processedIdx; // 0x30
		private static readonly byte[] sigma; // 0x00
		private static readonly byte[] tau; // 0x08
	
		// Properties
		public uint[] State { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Nested types
		[CompilerGenerated]
		private struct _EncryptStreamAsync_d__18 : IAsyncStateMachine // TypeDefIndex: 91291
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
			private void MoveNext(); // 0x0000000188AB7648-0x0000000188AB77F4
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000188AB77F4-0x0000000188AB7850
		}
	
		[CompilerGenerated]
		private struct _DecryptStreamAsync_d__29 : IAsyncStateMachine // TypeDefIndex: 91292
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
			private void MoveNext(); // 0x0000000188AB7440-0x0000000188AB75EC
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000188AB75EC-0x0000000188AB7648
		}
	
		[CompilerGenerated]
		private struct _WorkStreamsAsync_d__35 : IAsyncStateMachine // TypeDefIndex: 91293
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
			private void MoveNext(); // 0x0000000188AB7850-0x0000000188AB7CCC
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000188AB7CCC-0x0000000188AB7D28
		}
	
		// Constructors
		public XXE1(ReadOnlySpan<byte> key, ReadOnlySpan<byte> nonce, uint counter); // 0x000000018510E820-0x000000018510EA50
		static XXE1(); // 0x000000018709ED40-0x000000018709EE10
	
		// Methods
		private void KeySetup(ReadOnlySpan<byte> key); // 0x000000018510EC00-0x000000018510F520
		private void IvSetup(ReadOnlySpan<byte> nonce, uint counter); // 0x000000018510EA50-0x000000018510EC00
		public void EncryptBytes(byte[] output, byte[] input, int numBytes); // 0x0000000188AB7F24-0x0000000188AB7F34
		public void EncryptStream(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x0264C00C */); // 0x0000000188AB8030-0x0000000188AB8040
		public async System.Threading.Tasks.Task EncryptStreamAsync(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x0264C00E */); // 0x0000000188AB8208-0x0000000188AB8304
		public void EncryptBytes(byte[] output, byte[] input); // 0x0000000188AB8150-0x0000000188AB8188
		public void TransformBytes(byte[] inoutput); // 0x000000018588B430-0x000000018588B460
		public void TransformBytes(byte[] inoutput, int inoffset, int len); // 0x0000000187837578-0x000000018783759C
		public void TransformBytes(Span<byte> inoutput); // 0x0000000187837EE0-0x0000000187837F08
		public void CreateWorkSpace(); // 0x0000000186805BA0-0x0000000186805BB0
		public byte[] EncryptBytes(byte[] input, int numBytes); // 0x0000000188AB8188-0x0000000188AB8208
		public byte[] EncryptBytes(byte[] input); // 0x0000000188AB80D4-0x0000000188AB8150
		public byte[] EncryptString(string input); // 0x0000000188AB8304-0x0000000188AB83A0
		public void DecryptBytes(byte[] output, byte[] input, int numBytes); // 0x0000000188AB7F24-0x0000000188AB7F34
		public void DecryptStream(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x0264C010 */); // 0x0000000188AB8030-0x0000000188AB8040
		public async System.Threading.Tasks.Task DecryptStreamAsync(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x0264C012 */); // 0x0000000188AB7F34-0x0000000188AB8030
		public void DecryptBytes(byte[] output, byte[] input); // 0x0000000188AB7EFC-0x0000000188AB7F24
		public byte[] DecryptBytes(byte[] input, int numBytes); // 0x0000000188AB7E7C-0x0000000188AB7EFC
		public byte[] DecryptBytes(byte[] input); // 0x0000000188AB7E00-0x0000000188AB7E7C
		public string DecryptUTF8ByteArray(byte[] input); // 0x0000000188AB8040-0x0000000188AB80D4
		private void WorkStreams(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x0264C014 */); // 0x0000000188AB84EC-0x0000000188AB86F4
		private async System.Threading.Tasks.Task WorkStreamsAsync(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x0264C016 */); // 0x0000000188AB83F0-0x0000000188AB84EC
		private void WorkBytes(byte[] inoutput); // 0x0000000188AB83A0-0x0000000188AB83CC
		private void WorkBytes(byte[] output, byte[] input, int numBytes); // 0x0000000188AB83CC-0x0000000188AB83F0
		private void WorkBytes(byte[] output, int outoffset, byte[] input, int inoffset, int numBytes); // 0x0000000184FA03D0-0x0000000184FA0510
		private void WorkBytes(Span<byte> output, Span<byte> input); // 0x0000000184F9F220-0x0000000184F9F320
		private void RecalXORStream(); // 0x0000000184FA0130-0x0000000184FA03D0
		private static void QuarterRound(uint[] x, uint a, uint b, uint c, uint d); // 0x0000000184FA0510-0x0000000184FA0680
		~XXE1(); // 0x00000001858887D0-0x0000000185888820
		public void Dispose(); // 0x0000000185888770-0x00000001858887D0
		private void Dispose(bool disposing); // 0x0000000185888820-0x0000000185888910
	}

	public static class Util // TypeDefIndex: 91295
	{
		// Methods
		public static uint Rotate(uint v, int c); // 0x0000000187235270-0x0000000187235290
		public static uint XOr(uint v, uint w); // 0x0000000187235290-0x00000001872352A0
		public static uint Add(uint v, uint w); // 0x0000000187235260-0x0000000187235270
		public static uint AddOne(uint v); // 0x0000000187235250-0x0000000187235260
		public static uint U8To32Little(ReadOnlySpan<byte> p, int inputOffset); // 0x0000000188AB7D90-0x0000000188AB7E00
		public static void ToBytes(byte[] output, uint input, int outputOffset); // 0x0000000188AB7D28-0x0000000188AB7D90
	}
}
