/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 135: Common.Beyond.XXEnc.dll - Assembly: Common.Beyond.XXEnc, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61188-61193

namespace Beyond.XXEnc
{
	public sealed class XXE1 : IDisposable // TypeDefIndex: 61192
	{
		// Fields
		public const int allowedKeyLength = 32; // Metadata: 0x02083A14
		public const int allowedNonceLength = 12; // Metadata: 0x02083A15
		public const int processBytesAtTime = 64; // Metadata: 0x02083A16
		private const int stateLength = 16; // Metadata: 0x02083A18
		private readonly uint[] state; // 0x10
		private bool isDisposed; // 0x18
		private uint[] x; // 0x20
		private byte[] tmp; // 0x28
		private byte processedIdx; // 0x30
		private static readonly byte[] sigma; // 0x00
		private static readonly byte[] tau; // 0x08
	
		// Properties
		public uint[] State { get => default; } // 0x000000018778939C-0x00000001877893D0 
	
		// Nested types
		private struct _EncryptStreamAsync_d__18 : IAsyncStateMachine // TypeDefIndex: 61189
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
			private void MoveNext() {} // 0x0000000184666F30-0x0000000184667030
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018346D130-0x000000018346D140
		}
	
		private struct _DecryptStreamAsync_d__29 : IAsyncStateMachine // TypeDefIndex: 61190
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
			private void MoveNext() {} // 0x0000000184057020-0x00000001840577E0
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x0000000184667030-0x0000000184667220
		}
	
		private struct _WorkStreamsAsync_d__35 : IAsyncStateMachine // TypeDefIndex: 61191
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
			private void MoveNext() {} // 0x0000000187789178-0x0000000187789188
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x0000000187789280-0x0000000187789290
		}
	
		// Constructors
		public XXE1() {} // Dummy constructor
		public XXE1(ReadOnlySpan<byte> key, ReadOnlySpan<byte> nonce, uint counter) {} // 0x000000018778944C-0x0000000187789544
		static XXE1() {} // 0x0000000187788F28-0x0000000187788F84
	
		// Methods
		private void KeySetup(ReadOnlySpan<byte> key) {} // 0x00000001850D1290-0x00000001850D12C0
		private void IvSetup(ReadOnlySpan<byte> nonce, uint counter) {} // 0x000000018646EBA8-0x000000018646EBCC
		public void EncryptBytes(byte[] output, byte[] input, int numBytes) {} // 0x00000001864700E4-0x000000018647010C
		public void EncryptStream(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x02083A08 */) {} // 0x0000000185492010-0x0000000185492020
		public System.Threading.Tasks.Task EncryptStreamAsync(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x02083A0A */) => default; // 0x00000001877893D0-0x000000018778944C
		public void EncryptBytes(byte[] output, byte[] input) {} // 0x0000000187789320-0x000000018778939C
		public void TransformBytes(byte[] inoutput) {} // 0x0000000187789544-0x00000001877895DC
		public void TransformBytes(byte[] inoutput, int inoffset, int len) {} // 0x0000000187789178-0x0000000187789188
		public void TransformBytes(Span<byte> inoutput) {} // 0x0000000187789280-0x0000000187789290
		public void CreateWorkSpace() {} // 0x0000000187789188-0x0000000187789280
		public byte[] EncryptBytes(byte[] input, int numBytes) => default; // 0x0000000187789154-0x0000000187789178
		public byte[] EncryptBytes(byte[] input) => default; // 0x00000001877890D8-0x0000000187789154
		public byte[] EncryptString(string input) => default; // 0x000000018778905C-0x00000001877890D8
		public void DecryptBytes(byte[] output, byte[] input, int numBytes) {} // 0x0000000187789290-0x0000000187789320
		public void DecryptStream(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x02083A0C */) {} // 0x0000000187789724-0x0000000187789D44
		public System.Threading.Tasks.Task DecryptStreamAsync(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x02083A0E */) => default; // 0x000000018778962C-0x0000000187789724
		public void DecryptBytes(byte[] output, byte[] input) {} // 0x00000001877895DC-0x0000000187789608
		public byte[] DecryptBytes(byte[] input, int numBytes) => default; // 0x0000000187789608-0x000000018778962C
		public byte[] DecryptBytes(byte[] input) => default; // 0x0000000183FAC0B0-0x0000000183FAC1C0
		public string DecryptUTF8ByteArray(byte[] input) => default; // 0x0000000184056B20-0x0000000184056C50
		private void WorkStreams(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x02083A10 */) {} // 0x0000000183FABDD0-0x0000000183FAC0B0
		private System.Threading.Tasks.Task WorkStreamsAsync(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x02083A12 */) => default; // 0x0000000183FAC510-0x0000000183FAC680
		private void WorkBytes(byte[] inoutput) {} // 0x00000001847C4520-0x00000001847C4570
		private void WorkBytes(byte[] output, byte[] input, int numBytes) {} // 0x00000001847C4E30-0x00000001847C4E90
		private void WorkBytes(byte[] output, int outoffset, byte[] input, int inoffset, int numBytes) {} // 0x00000001847C4570-0x00000001847C4660
		private void WorkBytes(Span<byte> output, Span<byte> input) {} // 0x000000018417D3F0-0x000000018417D4C0
		private void RecalXORStream() {} // 0x00000001877888FC-0x0000000187788AA0
		private static void QuarterRound(uint[] x, uint a, uint b, uint c, uint d) {} // 0x0000000187788AA0-0x0000000187788AFC
		~XXE1() {} // 0x00000001877886FC-0x00000001877888A0
		public void Dispose() {} // 0x00000001877888A0-0x00000001877888FC
		private void Dispose(bool disposing) {} // 0x0000000187788AFC-0x0000000187788F28
	}

	public static class Util // TypeDefIndex: 61193
	{
		// Methods
		public static uint Rotate(uint v, int c) => default; // 0x0000000185FB21D0-0x0000000185FB21F0
		public static uint XOr(uint v, uint w) => default; // 0x0000000185FB21F0-0x0000000185FB2200
		public static uint Add(uint v, uint w) => default; // 0x0000000185FB21C0-0x0000000185FB21D0
		public static uint AddOne(uint v) => default; // 0x0000000185FB21B0-0x0000000185FB21C0
		public static uint U8To32Little(ReadOnlySpan<byte> p, int inputOffset) => default; // 0x0000000187788FEC-0x000000018778905C
		public static void ToBytes(byte[] output, uint input, int outputOffset) {} // 0x0000000187788F84-0x0000000187788FEC
	}
}
