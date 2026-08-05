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

// Image 108: System.IO.Compression.dll - Assembly: System.IO.Compression, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 63337-63354
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

internal static class Interop // TypeDefIndex: 63339
{
	// Nested types
	internal static class Brotli // TypeDefIndex: 63338
	{
		// Methods
		internal static extern SafeBrotliDecoderHandle BrotliDecoderCreateInstance(IntPtr allocFunc, IntPtr freeFunc, IntPtr opaque); // 0x000000018454C8D0-0x000000018454C950
		internal static unsafe extern int BrotliDecoderDecompressStream(SafeBrotliDecoderHandle state, ref IntPtr availableIn, byte** nextIn, ref IntPtr availableOut, byte** nextOut, out IntPtr totalOut); // 0x0000000183078030-0x00000001830780C0
		internal static extern void BrotliDecoderDestroyInstance(IntPtr state); // 0x00000001853982CC-0x00000001853982D4
		internal static extern bool BrotliDecoderIsFinished(SafeBrotliDecoderHandle state); // 0x0000000183077FD0-0x0000000183078030
		internal static extern SafeBrotliEncoderHandle BrotliEncoderCreateInstance(IntPtr allocFunc, IntPtr freeFunc, IntPtr opaque); // 0x000000018AE10054-0x000000018AE100CC
		internal static extern bool BrotliEncoderSetParameter(SafeBrotliEncoderHandle state, BrotliEncoderParameter parameter, uint value); // 0x000000018AE10144-0x000000018AE101C4
		internal static unsafe extern bool BrotliEncoderCompressStream(SafeBrotliEncoderHandle state, BrotliEncoderOperation op, ref IntPtr availableIn, byte** nextIn, ref IntPtr availableOut, byte** nextOut, out IntPtr totalOut); // 0x000000018AE0FFA4-0x000000018AE10054
		internal static extern bool BrotliEncoderHasMoreOutput(SafeBrotliEncoderHandle state); // 0x000000018AE100D4-0x000000018AE10144
		internal static extern void BrotliEncoderDestroyInstance(IntPtr state); // 0x000000018AE100CC-0x000000018AE100D4
	}
}

internal static class SR // TypeDefIndex: 63340
{
	// Methods
	internal static string Format(string resourceFormat, object p1); // 0x000000018AE10244-0x000000018AE102A0
	internal static string Format(string resourceFormat, object p1, object p2, object p3); // 0x000000018AE101C4-0x000000018AE10244
}

namespace Microsoft.Win32.SafeHandles
{
	internal sealed class SafeBrotliEncoderHandle : SafeHandle // TypeDefIndex: 63353
	{
		// Properties
		public override bool IsInvalid { get; } // 0x0000000183BA32C0-0x0000000183BA32D0 
	
		// Constructors
		public SafeBrotliEncoderHandle(); // 0x00000001853948D4-0x00000001853948E4
	
		// Methods
		protected override bool ReleaseHandle(); // 0x000000018AE102A0-0x000000018AE102B4
	}

	internal sealed class SafeBrotliDecoderHandle : SafeHandle // TypeDefIndex: 63354
	{
		// Properties
		public override bool IsInvalid { get; } // 0x0000000183BA32C0-0x0000000183BA32D0 
	
		// Constructors
		public SafeBrotliDecoderHandle(); // 0x00000001853948D4-0x00000001853948E4
	
		// Methods
		protected override bool ReleaseHandle(); // 0x0000000184D7AFF0-0x0000000184D7B010
	}
}

namespace System.IO.Compression
{
	public sealed class BrotliStream : Stream // TypeDefIndex: 63344
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
		public override bool CanRead { get; } // 0x000000018AE0FE44-0x000000018AE0FE70 
		public override bool CanWrite { get; } // 0x000000018AE0FE70-0x000000018AE0FE9C 
		public override bool CanSeek { get; } // 0x00000001812081B0-0x0000000181208610 
		public override long Length { get; } // 0x000000018AE0FE9C-0x000000018AE0FEE8 
		public override long Position { get; set; } // 0x000000018AE0FEE8-0x000000018AE0FF34 0x000000018AE0FF34-0x000000018AE0FF80
		private bool AsyncOperationIsActive { get; } // 0x000000018AE0FE3C-0x000000018AE0FE44 
	
		// Nested types
		[CompilerGenerated]
		private struct _FinishReadAsyncMemory_d__41 : IAsyncStateMachine // TypeDefIndex: 63341
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncValueTaskMethodBuilder<int> __t__builder; // 0x08
			public BrotliStream __4__this; // 0x28
			public CancellationToken cancellationToken; // 0x30
			public Memory<byte> buffer; // 0x38
			private int _totalWritten_5__2; // 0x48
			private ConfiguredValueTaskAwaitable<int> __u__1; // 0x50
	
			// Methods
			private void MoveNext(); // 0x000000018AE10564-0x000000018AE10E5C
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018AE10E5C-0x000000018AE10EA8
		}
	
		[CompilerGenerated]
		private struct _WriteAsyncMemoryCore_d__52 : IAsyncStateMachine // TypeDefIndex: 63342
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public BrotliStream __4__this; // 0x20
			public ReadOnlyMemory<byte> buffer; // 0x28
			public CancellationToken cancellationToken; // 0x38
			private OperationStatus _lastResult_5__2; // 0x40
			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter __u__1; // 0x48
	
			// Methods
			private void MoveNext(); // 0x000000018AE11420-0x000000018AE119C8
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018AE119C8-0x000000018AE11AA4
		}
	
		[CompilerGenerated]
		private struct _FlushAsyncCore_d__55 : IAsyncStateMachine // TypeDefIndex: 63343
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public BrotliStream __4__this; // 0x20
			public CancellationToken cancellationToken; // 0x28
			private OperationStatus _lastResult_5__2; // 0x30
			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter __u__1; // 0x38
	
			// Methods
			private void MoveNext(); // 0x000000018AE10EA8-0x000000018AE113C4
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018AE113C4-0x000000018AE11420
		}
	
		// Constructors
		public BrotliStream(Stream stream, CompressionMode mode, bool leaveOpen); // 0x0000000184A43A50-0x0000000184A43B30
		public BrotliStream(Stream stream, CompressionLevel compressionLevel); // 0x000000018AE0FDC4-0x000000018AE0FDE0
		public BrotliStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen); // 0x000000018AE0FDE0-0x000000018AE0FE3C
	
		// Methods
		private void EnsureNotDisposed(); // 0x00000001830780C0-0x00000001830780E0
		protected override void Dispose(bool disposing); // 0x0000000184B21780-0x0000000184B21870
		private static void ValidateParameters(byte[] array, int offset, int count); // 0x000000018AE0F600-0x000000018AE0F7A4
		public override long Seek(long offset, SeekOrigin origin); // 0x000000018AE0F50C-0x000000018AE0F558
		public override void SetLength(long value); // 0x000000018AE0F558-0x000000018AE0F5A4
		private void EnsureNoActiveAsyncOperation(); // 0x000000018AE0EDD4-0x000000018AE0EDEC
		private void AsyncOperationStarting(); // 0x000000018AE0EC50-0x000000018AE0EC70
		private void AsyncOperationCompleting(); // 0x000000018AE0EC40-0x000000018AE0EC50
		private static void ThrowInvalidBeginCall(); // 0x000000018AE0F5A4-0x000000018AE0F600
		public override int Read(byte[] buffer, int offset, int count); // 0x000000018AE0F46C-0x000000018AE0F50C
		public override int Read(Span<byte> buffer); // 0x0000000183077A60-0x0000000183077CC0
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState); // 0x000000018AE0EC70-0x000000018AE0ED00
		public override int EndRead(IAsyncResult asyncResult); // 0x000000018AE0ED8C-0x000000018AE0EDC8
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken); // 0x000000018AE0F38C-0x000000018AE0F46C
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default); // 0x000000018AE0F220-0x000000018AE0F38C
		private async ValueTask<int> FinishReadAsyncMemory(Memory<byte> buffer, CancellationToken cancellationToken); // 0x000000018AE0EDEC-0x000000018AE0EEF0
		public override void Write(byte[] buffer, int offset, int count); // 0x000000018AE0FD04-0x000000018AE0FDA0
		public override void Write(ReadOnlySpan<byte> buffer); // 0x000000018AE0FDA0-0x000000018AE0FDC4
		internal void WriteCore(ReadOnlySpan<byte> buffer, bool isFinalBlock = false /* Metadata: 0x023527A7 */); // 0x000000018AE0FAC8-0x000000018AE0FD04
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState); // 0x000000018AE0ED00-0x000000018AE0ED8C
		public override void EndWrite(IAsyncResult asyncResult); // 0x000000018AE0EDC8-0x000000018AE0EDD4
		public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken); // 0x000000018AE0F9E0-0x000000018AE0FAC8
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default); // 0x000000018AE0F894-0x000000018AE0F9E0
		private async System.Threading.Tasks.Task WriteAsyncMemoryCore(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken); // 0x000000018AE0F7A4-0x000000018AE0F894
		public override void Flush(); // 0x000000018AE0F07C-0x000000018AE0F220
		public override System.Threading.Tasks.Task FlushAsync(CancellationToken cancellationToken); // 0x000000018AE0EFC4-0x000000018AE0F07C
		private async System.Threading.Tasks.Task FlushAsyncCore(CancellationToken cancellationToken); // 0x000000018AE0EEF0-0x000000018AE0EFC4
	}

	internal static class BrotliUtils // TypeDefIndex: 63345
	{
		// Methods
		internal static int GetQualityFromCompressionLevel(CompressionLevel level); // 0x000000018AE0FF80-0x000000018AE0FFA4
	}

	public struct BrotliDecoder : IDisposable // TypeDefIndex: 63346
	{
		// Fields
		private SafeBrotliDecoderHandle _state; // 0x00
		private bool _disposed; // 0x08
	
		// Methods
		internal void InitializeDecoder(); // 0x000000018454C880-0x000000018454C8D0
		internal void EnsureInitialized(); // 0x0000000183077F80-0x0000000183077FB0
		public void Dispose(); // 0x00000001840F0480-0x00000001840F04A0
		private void EnsureNotDisposed(); // 0x0000000183077FB0-0x0000000183077FD0
		public OperationStatus Decompress(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesConsumed, out int bytesWritten); // 0x0000000183077CC0-0x0000000183077F80
	}

	public struct BrotliEncoder : IDisposable // TypeDefIndex: 63347
	{
		// Fields
		internal SafeBrotliEncoderHandle _state; // 0x00
		private bool _disposed; // 0x08
	
		// Constructors
		public BrotliEncoder(int quality, int window); // 0x000000018AE0EB74-0x000000018AE0EC40
	
		// Methods
		internal void InitializeEncoder(); // 0x000000018AE0E730-0x000000018AE0E7CC
		internal void EnsureInitialized(); // 0x000000018AE0E580-0x000000018AE0E5AC
		public void Dispose(); // 0x0000000184D7F810-0x0000000184D7F830
		private void EnsureNotDisposed(); // 0x000000018AE0E5AC-0x000000018AE0E630
		internal void SetQuality(int quality); // 0x000000018AE0E7CC-0x000000018AE0E99C
		internal void SetWindow(int window); // 0x000000018AE0E99C-0x000000018AE0EB74
		internal OperationStatus Flush(Memory<byte> destination, out int bytesWritten); // 0x000000018AE0E630-0x000000018AE0E6A8
		public OperationStatus Flush(Span<byte> destination, out int bytesWritten); // 0x000000018AE0E6A8-0x000000018AE0E730
		internal OperationStatus Compress(ReadOnlyMemory<byte> source, Memory<byte> destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock); // 0x000000018AE0E464-0x000000018AE0E534
		public OperationStatus Compress(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock); // 0x000000018AE0E534-0x000000018AE0E580
		internal OperationStatus Compress(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesConsumed, out int bytesWritten, BrotliEncoderOperation operation); // 0x000000018AE0E2A8-0x000000018AE0E464
	}

	internal enum BrotliEncoderOperation // TypeDefIndex: 63348
	{
		Process = 0,
		Flush = 1,
		Finish = 2,
		EmitMetadata = 3
	}

	internal enum BrotliEncoderParameter // TypeDefIndex: 63349
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
	internal static class TaskToApm // TypeDefIndex: 63352
	{
		// Nested types
		private sealed class TaskWrapperAsyncResult : IAsyncResult // TypeDefIndex: 63350
		{
			// Fields
			internal readonly System.Threading.Tasks.Task Task; // 0x10
			private readonly object _state; // 0x18
			private readonly bool _completedSynchronously; // 0x20
	
			// Properties
			object IAsyncResult.AsyncState { get; } // 0x000000018385B100-0x000000018385B110 
			bool IAsyncResult.CompletedSynchronously { get; } // 0x0000000184D866B0-0x0000000184D866C0 
			bool IAsyncResult.IsCompleted { get; } // 0x000000018A88881C-0x000000018A88883C 
			WaitHandle IAsyncResult.AsyncWaitHandle { get; } // 0x000000018A8887FC-0x000000018A88881C 
	
			// Constructors
			internal TaskWrapperAsyncResult(System.Threading.Tasks.Task task, object state, bool completedSynchronously); // 0x0000000184D33BE0-0x0000000184D33C10
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 63351
		{
			// Fields
			public AsyncCallback callback; // 0x10
			public IAsyncResult asyncResult; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _InvokeCallbackWhenTaskCompletes_b__0(); // 0x000000018A88CE18-0x000000018A88CE3C
		}
	
		// Methods
		public static IAsyncResult Begin(System.Threading.Tasks.Task task, AsyncCallback callback, object state); // 0x000000018AE102B4-0x000000018AE103B0
		public static void End(IAsyncResult asyncResult); // 0x000000018AE103B0-0x000000018AE1046C
		public static TResult End<TResult>(IAsyncResult asyncResult);
		private static void InvokeCallbackWhenTaskCompletes(System.Threading.Tasks.Task antecedent, AsyncCallback callback, IAsyncResult asyncResult); // 0x000000018AE1046C-0x000000018AE10564
	}
}
