/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Buffers;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

// Image 103: System.IO.Compression.dll - Assembly: System.IO.Compression, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 59607-59624
[assembly: AssemblyCompany("Mono development team")]
[assembly: AssemblyCopyright("(c) Various Mono authors")]
[assembly: AssemblyDefaultAlias("System.IO.Compression.dll")]
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyDescription("System.IO.Compression.dll")]
[assembly: AssemblyFileVersion("4.0.30319.17020")]
[assembly: AssemblyInformationalVersion("4.0.30319.17020")]
[assembly: AssemblyProduct("Mono Common Language Infrastructure")]
[assembly: AssemblyTitle("System.IO.Compression.dll")]
[assembly: CLSCompliant(true)]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

internal static class Interop // TypeDefIndex: 59609
{
	// Nested types
	internal static class Brotli // TypeDefIndex: 59608
	{
		// Methods
		internal static extern SafeBrotliDecoderHandle BrotliDecoderCreateInstance(IntPtr allocFunc, IntPtr freeFunc, IntPtr opaque); // 0x0000000183790590-0x0000000183790630
		internal static unsafe extern int BrotliDecoderDecompressStream(SafeBrotliDecoderHandle state, ref IntPtr availableIn, byte** nextIn, ref IntPtr availableOut, byte** nextOut, out IntPtr totalOut); // 0x0000000182462950-0x00000001824629E0
		internal static extern void BrotliDecoderDestroyInstance(IntPtr state); // 0x00000001842771B4-0x00000001842771BC
		internal static extern bool BrotliDecoderIsFinished(SafeBrotliDecoderHandle state); // 0x0000000182462580-0x00000001824625E0
		internal static extern SafeBrotliEncoderHandle BrotliEncoderCreateInstance(IntPtr allocFunc, IntPtr freeFunc, IntPtr opaque); // 0x0000000189830214-0x000000018983028C
		internal static extern bool BrotliEncoderSetParameter(SafeBrotliEncoderHandle state, BrotliEncoderParameter parameter, uint value); // 0x0000000189830304-0x0000000189830384
		internal static unsafe extern bool BrotliEncoderCompressStream(SafeBrotliEncoderHandle state, BrotliEncoderOperation op, ref IntPtr availableIn, byte** nextIn, ref IntPtr availableOut, byte** nextOut, out IntPtr totalOut); // 0x0000000189830164-0x0000000189830214
		internal static extern bool BrotliEncoderHasMoreOutput(SafeBrotliEncoderHandle state); // 0x0000000189830294-0x0000000189830304
		internal static extern void BrotliEncoderDestroyInstance(IntPtr state); // 0x000000018983028C-0x0000000189830294
	}
}

internal static class SR // TypeDefIndex: 59610
{
	// Methods
	internal static string Format(string resourceFormat, object p1) => default; // 0x0000000189830404-0x0000000189830460
	internal static string Format(string resourceFormat, object p1, object p2, object p3) => default; // 0x0000000189830384-0x0000000189830404
}

namespace Microsoft.Win32.SafeHandles
{
	internal sealed class SafeBrotliEncoderHandle : SafeHandle // TypeDefIndex: 59623
	{
		// Properties
		public override bool IsInvalid { get => default; } // 0x00000001825EB8A0-0x00000001825EB8B0 
	
		// Constructors
		public SafeBrotliEncoderHandle() {} // 0x0000000184272874-0x0000000184272884
	
		// Methods
		protected override bool ReleaseHandle() => default; // 0x0000000189830460-0x0000000189830474
	}

	internal sealed class SafeBrotliDecoderHandle : SafeHandle // TypeDefIndex: 59624
	{
		// Properties
		public override bool IsInvalid { get => default; } // 0x00000001825EB8A0-0x00000001825EB8B0 
	
		// Constructors
		public SafeBrotliDecoderHandle() {} // 0x0000000184272874-0x0000000184272884
	
		// Methods
		protected override bool ReleaseHandle() => default; // 0x0000000183D450D0-0x0000000183D450F0
	}
}

namespace System.IO.Compression
{
	public sealed class BrotliStream : Stream // TypeDefIndex: 59614
	{
		// Fields
		private Stream _stream; // 0x28
		private readonly byte[] _buffer; // 0x30
		private readonly bool _leaveOpen; // 0x38
		private readonly CompressionMode _mode; // 0x3C
		private int _activeAsyncOperation; // 0x40
		private BrotliDecoder _decoder; // 0x48
		private int _bufferOffset; // 0x58
		private int _bufferCount; // 0x5C
		private BrotliEncoder _encoder; // 0x60
	
		// Properties
		public override bool CanRead { get => default; } // 0x0000000189830004-0x0000000189830030 
		public override bool CanWrite { get => default; } // 0x0000000189830030-0x000000018983005C 
		public override bool CanSeek { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override long Length { get => default; } // 0x000000018983005C-0x00000001898300A8 
		public override long Position { get => default; set {} } // 0x00000001898300A8-0x00000001898300F4 0x00000001898300F4-0x0000000189830140
		private bool AsyncOperationIsActive { get => default; } // 0x000000018982FFFC-0x0000000189830004 
	
		// Constructors
		public BrotliStream() {} // Dummy constructor
		public BrotliStream(Stream stream, CompressionMode mode, bool leaveOpen) {} // 0x0000000183A61760-0x0000000183A61850
		public BrotliStream(Stream stream, CompressionLevel compressionLevel) {} // 0x000000018982FF84-0x000000018982FFA0
		public BrotliStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen) {} // 0x000000018982FFA0-0x000000018982FFFC
	
		// Methods
		private void EnsureNotDisposed() {} // 0x0000000183334260-0x0000000183334280
		protected override void Dispose(bool disposing) {} // 0x0000000183B216E0-0x0000000183B217D0
		private static void ValidateParameters(byte[] array, int offset, int count) {} // 0x000000018982F7C0-0x000000018982F964
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x000000018982F6CC-0x000000018982F718
		public override void SetLength(long value) {} // 0x000000018982F718-0x000000018982F764
		private void EnsureNoActiveAsyncOperation() {} // 0x000000018982EF94-0x000000018982EFAC
		private void AsyncOperationStarting() {} // 0x000000018982EE10-0x000000018982EE30
		private void AsyncOperationCompleting() {} // 0x000000018982EE00-0x000000018982EE10
		private static void ThrowInvalidBeginCall() {} // 0x000000018982F764-0x000000018982F7C0
		public override int Read(byte[] buffer, int offset, int count) => default; // 0x000000018982F62C-0x000000018982F6CC
		public override int Read(Span<byte> buffer) => default; // 0x00000001825D9CD0-0x00000001825D9FC0
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) => default; // 0x000000018982EE30-0x000000018982EEC0
		public override int EndRead(IAsyncResult asyncResult) => default; // 0x000000018982EF4C-0x000000018982EF88
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => default; // 0x000000018982F54C-0x000000018982F62C
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default) => default; // 0x000000018982F3E0-0x000000018982F54C
		private async ValueTask<int> FinishReadAsyncMemory(Memory<byte> buffer, CancellationToken cancellationToken) => default; // 0x000000018982EFAC-0x000000018982F0B0
		public override void Write(byte[] buffer, int offset, int count) {} // 0x000000018982FEC4-0x000000018982FF60
		public override void Write(ReadOnlySpan<byte> buffer) {} // 0x000000018982FF60-0x000000018982FF84
		internal void WriteCore(ReadOnlySpan<byte> buffer, bool isFinalBlock = false /* Metadata: 0x01FDD1F1 */) {} // 0x000000018982FC88-0x000000018982FEC4
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) => default; // 0x000000018982EEC0-0x000000018982EF4C
		public override void EndWrite(IAsyncResult asyncResult) {} // 0x000000018982EF88-0x000000018982EF94
		public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => default; // 0x000000018982FBA0-0x000000018982FC88
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default) => default; // 0x000000018982FA54-0x000000018982FBA0
		private async System.Threading.Tasks.Task WriteAsyncMemoryCore(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) => default; // 0x000000018982F964-0x000000018982FA54
		public override void Flush() {} // 0x000000018982F23C-0x000000018982F3E0
		public override System.Threading.Tasks.Task FlushAsync(CancellationToken cancellationToken) => default; // 0x000000018982F184-0x000000018982F23C
		private async System.Threading.Tasks.Task FlushAsyncCore(CancellationToken cancellationToken) => default; // 0x000000018982F0B0-0x000000018982F184
	}

	internal static class BrotliUtils // TypeDefIndex: 59615
	{
		// Methods
		internal static int GetQualityFromCompressionLevel(CompressionLevel level) => default; // 0x0000000189830140-0x0000000189830164
	}

	public struct BrotliDecoder : IDisposable // TypeDefIndex: 59616
	{
		// Fields
		private SafeBrotliDecoderHandle _state; // 0x00
		private bool _disposed; // 0x08
	
		// Methods
		internal void InitializeDecoder() {} // 0x0000000183790540-0x0000000183790590
		internal void EnsureInitialized() {} // 0x0000000182462900-0x0000000182462930
		public void Dispose() {} // 0x0000000182959A20-0x0000000182959A40
		private void EnsureNotDisposed() {} // 0x0000000182462930-0x0000000182462950
		public OperationStatus Decompress(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesConsumed, out int bytesWritten) {
			bytesConsumed = default;
			bytesWritten = default;
			return default;
		} // 0x00000001824625E0-0x0000000182462900
	}

	public struct BrotliEncoder : IDisposable // TypeDefIndex: 59617
	{
		// Fields
		internal SafeBrotliEncoderHandle _state; // 0x00
		private bool _disposed; // 0x08
	
		// Constructors
		public BrotliEncoder(int quality, int window) {
			_state = default;
			_disposed = default;
		} // 0x000000018982ED34-0x000000018982EE00
	
		// Methods
		internal void InitializeEncoder() {} // 0x000000018982E8F4-0x000000018982E990
		internal void EnsureInitialized() {} // 0x000000018982E744-0x000000018982E770
		public void Dispose() {} // 0x0000000183D47C60-0x0000000183D47C80
		private void EnsureNotDisposed() {} // 0x000000018982E770-0x000000018982E7F4
		internal void SetQuality(int quality) {} // 0x000000018982E990-0x000000018982EB60
		internal void SetWindow(int window) {} // 0x000000018982EB60-0x000000018982ED34
		internal OperationStatus Flush(Memory<byte> destination, out int bytesWritten) {
			bytesWritten = default;
			return default;
		} // 0x000000018982E7F4-0x000000018982E86C
		public OperationStatus Flush(Span<byte> destination, out int bytesWritten) {
			bytesWritten = default;
			return default;
		} // 0x000000018982E86C-0x000000018982E8F4
		internal OperationStatus Compress(ReadOnlyMemory<byte> source, Memory<byte> destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock) {
			bytesConsumed = default;
			bytesWritten = default;
			return default;
		} // 0x000000018982E628-0x000000018982E6F8
		public OperationStatus Compress(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock) {
			bytesConsumed = default;
			bytesWritten = default;
			return default;
		} // 0x000000018982E6F8-0x000000018982E744
		internal OperationStatus Compress(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesConsumed, out int bytesWritten, BrotliEncoderOperation operation) {
			bytesConsumed = default;
			bytesWritten = default;
			return default;
		} // 0x000000018982E46C-0x000000018982E628
	}

	internal enum BrotliEncoderOperation // TypeDefIndex: 59618
	{
		Process = 0,
		Flush = 1,
		Finish = 2,
		EmitMetadata = 3
	}

	internal enum BrotliEncoderParameter // TypeDefIndex: 59619
	{
		Mode = 0,
		Quality = 1,
		LGWin = 2,
		LGBlock = 3,
		LCModeling = 4,
		SizeHint = 5
	}
}

namespace System.Threading.Tasks
{
	internal static class TaskToApm // TypeDefIndex: 59622
	{
		// Nested types
		private sealed class TaskWrapperAsyncResult : IAsyncResult // TypeDefIndex: 59620
		{
			// Fields
			internal readonly System.Threading.Tasks.Task Task; // 0x10
			private readonly object _state; // 0x18
			private readonly bool _completedSynchronously; // 0x20
	
			// Properties
			object IAsyncResult.AsyncState { get => default; } // 0x0000000181041090-0x00000001810410A0 
			bool IAsyncResult.CompletedSynchronously { get => default; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
			bool IAsyncResult.IsCompleted { get => default; } // 0x00000001892945A0-0x00000001892945C0 
			WaitHandle IAsyncResult.AsyncWaitHandle { get => default; } // 0x0000000189294580-0x00000001892945A0 
	
			// Constructors
			public TaskWrapperAsyncResult() {} // Dummy constructor
			internal TaskWrapperAsyncResult(System.Threading.Tasks.Task task, object state, bool completedSynchronously) {} // 0x0000000183D01130-0x0000000183D01160
		}
	
		// Methods
		public static IAsyncResult Begin(System.Threading.Tasks.Task task, AsyncCallback callback, object state) => default; // 0x0000000189830474-0x0000000189830570
		public static void End(IAsyncResult asyncResult) {} // 0x0000000189830570-0x000000018983062C
		public static TResult End<TResult>(IAsyncResult asyncResult) => default;
		private static void InvokeCallbackWhenTaskCompletes(System.Threading.Tasks.Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) {} // 0x000000018983062C-0x0000000189830724
	}
}
