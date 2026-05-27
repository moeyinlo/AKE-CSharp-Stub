/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 131: Common.Beyond.XXEnc.dll - Assembly: Common.Beyond.XXEnc, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60072-60077
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.XXEnc
{
	public sealed class XXE1 : IDisposable // TypeDefIndex: 60076
	{
		// Fields
		public const int allowedKeyLength = 32; // Metadata: 0x01FDE10F
		public const int allowedNonceLength = 12; // Metadata: 0x01FDE110
		public const int processBytesAtTime = 64; // Metadata: 0x01FDE111
		private const int stateLength = 16; // Metadata: 0x01FDE113
		private readonly uint[] state; // 0x10
		private bool isDisposed; // 0x18
		private uint[] x; // 0x20
		private byte[] tmp; // 0x28
		private byte processedIdx; // 0x30
		private static readonly byte[] sigma; // 0x00
		private static readonly byte[] tau; // 0x08
	
		// Properties
		public uint[] State { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public XXE1() {} // Dummy constructor
		public XXE1(ReadOnlySpan<byte> key, ReadOnlySpan<byte> nonce, uint counter) {} // 0x000000018298A460-0x000000018298A560
		static XXE1() {} // 0x000000018242CAC0-0x000000018242CB90
	
		// Methods
		private void KeySetup(ReadOnlySpan<byte> key) {} // 0x00000001823A9240-0x00000001823A9A00
		private void IvSetup(ReadOnlySpan<byte> nonce, uint counter) {} // 0x000000018298A560-0x000000018298A990
		public void EncryptBytes(byte[] output, byte[] input, int numBytes) {} // 0x0000000185588CFC-0x0000000185588D0C
		public void EncryptStream(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x01FDE103 */) {} // 0x0000000185588E04-0x0000000185588E14
		public async System.Threading.Tasks.Task EncryptStreamAsync(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x01FDE105 */) => default; // 0x0000000185588FD0-0x00000001855890C8
		public void EncryptBytes(byte[] output, byte[] input) {} // 0x0000000185588F20-0x0000000185588F54
		public void TransformBytes(byte[] inoutput) {} // 0x000000018316A840-0x000000018316A870
		public void TransformBytes(byte[] inoutput, int inoffset, int len) {} // 0x0000000184270240-0x0000000184270264
		public void TransformBytes(Span<byte> inoutput) {} // 0x00000001842701F8-0x0000000184270220
		public void CreateWorkSpace() {} // 0x000000018350B670-0x000000018350B680
		public byte[] EncryptBytes(byte[] input, int numBytes) => default; // 0x0000000185588F54-0x0000000185588FD0
		public byte[] EncryptBytes(byte[] input) => default; // 0x0000000185588EA4-0x0000000185588F20
		public byte[] EncryptString(string input) => default; // 0x00000001855890C8-0x0000000185589160
		public void DecryptBytes(byte[] output, byte[] input, int numBytes) {} // 0x0000000185588CFC-0x0000000185588D0C
		public void DecryptStream(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x01FDE107 */) {} // 0x0000000185588E04-0x0000000185588E14
		public async System.Threading.Tasks.Task DecryptStreamAsync(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x01FDE109 */) => default; // 0x0000000185588D0C-0x0000000185588E04
		public void DecryptBytes(byte[] output, byte[] input) {} // 0x0000000185588CD8-0x0000000185588CFC
		public byte[] DecryptBytes(byte[] input, int numBytes) => default; // 0x0000000185588C5C-0x0000000185588CD8
		public byte[] DecryptBytes(byte[] input) => default; // 0x0000000185588BE0-0x0000000185588C5C
		public string DecryptUTF8ByteArray(byte[] input) => default; // 0x0000000185588E14-0x0000000185588EA4
		private void WorkStreams(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x01FDE10B */) {} // 0x00000001855892A8-0x00000001855898C8
		private async System.Threading.Tasks.Task WorkStreamsAsync(Stream output, Stream input, int howManyBytesToProcessAtTime = 1024 /* Metadata: 0x01FDE10D */) => default; // 0x00000001855891B0-0x00000001855892A8
		private void WorkBytes(byte[] inoutput) {} // 0x0000000185589160-0x000000018558918C
		private void WorkBytes(byte[] output, byte[] input, int numBytes) {} // 0x000000018558918C-0x00000001855891B0
		private void WorkBytes(byte[] output, int outoffset, byte[] input, int inoffset, int numBytes) {} // 0x00000001822AB510-0x00000001822AB620
		private void WorkBytes(Span<byte> output, Span<byte> input) {} // 0x00000001823A8D40-0x00000001823A8E70
		private void RecalXORStream() {} // 0x00000001822AB230-0x00000001822AB510
		private static void QuarterRound(uint[] x, uint a, uint b, uint c, uint d) {} // 0x00000001822AB970-0x00000001822ABAE0
		~XXE1() {} // 0x000000018298AB70-0x000000018298ABC0
		public void Dispose() {} // 0x000000018298A1A0-0x000000018298A200
		private void Dispose(bool disposing) {} // 0x000000018298ABC0-0x000000018298ACB0
	}

	public static class Util // TypeDefIndex: 60077
	{
		// Methods
		public static uint Rotate(uint v, int c) => default; // 0x0000000183D50D20-0x0000000183D50D40
		public static uint XOr(uint v, uint w) => default; // 0x0000000183D50D40-0x0000000183D50D50
		public static uint Add(uint v, uint w) => default; // 0x0000000183D50D10-0x0000000183D50D20
		public static uint AddOne(uint v) => default; // 0x0000000183D50D00-0x0000000183D50D10
		public static uint U8To32Little(ReadOnlySpan<byte> p, int inputOffset) => default; // 0x0000000185588B70-0x0000000185588BE0
		public static void ToBytes(byte[] output, uint input, int outputOffset) {} // 0x0000000185588B08-0x0000000185588B70
	}
}
