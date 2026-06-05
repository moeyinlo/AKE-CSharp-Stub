/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Buffers;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

// Image 106: System.IO.Compression.dll - Assembly: System.IO.Compression, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60711-60728

internal static class Interop // TypeDefIndex: 60713
{
	// Nested types
	internal static class Brotli // TypeDefIndex: 60712
	{
		// Methods
		internal static extern SafeBrotliDecoderHandle BrotliDecoderCreateInstance(IntPtr allocFunc, IntPtr freeFunc, IntPtr opaque); // 0x00000001858B0D60-0x00000001858B0E00
		internal static unsafe extern int BrotliDecoderDecompressStream(SafeBrotliDecoderHandle state, ref IntPtr availableIn, byte** nextIn, ref IntPtr availableOut, byte** nextOut, out IntPtr totalOut); // 0x00000001841B2CB0-0x00000001841B2D40
		internal static extern void BrotliDecoderDestroyInstance(IntPtr state); // 0x000000018647548C-0x0000000186475494
		internal static extern bool BrotliDecoderIsFinished(SafeBrotliDecoderHandle state); // 0x00000001841B28E0-0x00000001841B2940
		internal static extern SafeBrotliEncoderHandle BrotliEncoderCreateInstance(IntPtr allocFunc, IntPtr freeFunc, IntPtr opaque); // 0x000000018B956394-0x000000018B95640C
		internal static extern bool BrotliEncoderSetParameter(SafeBrotliEncoderHandle state, BrotliEncoderParameter parameter, uint value); // 0x000000018B956484-0x000000018B956504
		internal static unsafe extern bool BrotliEncoderCompressStream(SafeBrotliEncoderHandle state, BrotliEncoderOperation op, ref IntPtr availableIn, byte** nextIn, ref IntPtr availableOut, byte** nextOut, out IntPtr totalOut); // 0x000000018B9562E4-0x000000018B956394
		internal static extern bool BrotliEncoderHasMoreOutput(SafeBrotliEncoderHandle state); // 0x000000018B956414-0x000000018B956484
		internal static extern void BrotliEncoderDestroyInstance(IntPtr state); // 0x000000018B95640C-0x000000018B956414
	}
}

internal static class SR // TypeDefIndex: 60714
{
	// Methods
	internal static string Format(string resourceFormat, object p1) => default; // 0x000000018B956584-0x000000018B9565E0
	internal static string Format(string resourceFormat, object p1, object p2, object p3) => default; // 0x000000018B956504-0x000000018B956584
}

namespace Microsoft.Win32.SafeHandles
{
	internal sealed class SafeBrotliEncoderHandle : SafeHandle // TypeDefIndex: 60727
	{
		// Properties
		public override bool IsInvalid { get => default; } // 0x00000001841C04C0-0x00000001841C04D0 
	
		// Constructors
		public SafeBrotliEncoderHandle() {} // 0x00000001864701C8-0x00000001864701D8
	
		// Methods
		protected override bool ReleaseHandle() => default; // 0x000000018B9565E0-0x000000018B9565F4
	}

	internal sealed class SafeBrotliDecoderHandle : SafeHandle // TypeDefIndex: 60728
	{
		// Properties
		public override bool IsInvalid { get => default; } // 0x00000001841C04C0-0x00000001841C04D0 
	
		// Constructors
		public SafeBrotliDecoderHandle() {} // 0x00000001864701C8-0x00000001864701D8
	
		// Methods
		protected override bool ReleaseHandle() => default; // 0x0000000185FA5520-0x0000000185FA5540
	}
}

namespace System.IO.Compression
{
	public sealed class BrotliStream : Stream // TypeDefIndex: 60718
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
		public override bool CanRead { get => default; } // 0x000000018B956274-0x000000018B9562C0 
		public override bool CanWrite { get => default; } // 0x000000018B955898-0x000000018B9558E4 
		public override bool CanSeek { get => default; } // 0x000000018B95617C-0x000000018B956184 
		public override long Length { get => default; } // 0x000000018B954F90-0x000000018B954FB0 
		public override long Position { get => default; set {} } // 0x000000018B954F80-0x000000018B954F90 0x000000018B9558E4-0x000000018B955940
		private bool AsyncOperationIsActive { get => default; } // 0x000000018466ABF0-0x000000018466AEF0 
	
		// Nested types
		private struct _FinishReadAsyncMemory_d__41 : IAsyncStateMachine // TypeDefIndex: 60715
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
			private void MoveNext() {} // 0x0000000185C6D950-0x0000000185C6DA40
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x00000001852A4160-0x00000001852A4180
		}
	
		private struct _WriteAsyncMemoryCore_d__52 : IAsyncStateMachine // TypeDefIndex: 60716
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
			private void MoveNext() {} // 0x0000000185D4AC40-0x0000000185D4AD30
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018B955940-0x000000018B955AE4
		}
	
		private struct _FlushAsyncCore_d__55 : IAsyncStateMachine // TypeDefIndex: 60717
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public BrotliStream __4__this; // 0x20
			public CancellationToken cancellationToken; // 0x28
			private OperationStatus _lastResult_5__2; // 0x30
			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter __u__1; // 0x38
	
			// Methods
			private void MoveNext() {} // 0x000000018B956184-0x000000018B9561B0
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018B9561B0-0x000000018B9561DC
		}
	
		// Constructors
		public BrotliStream() {} // Dummy constructor
		public BrotliStream(Stream stream, CompressionMode mode, bool leaveOpen) {} // 0x00000001814A81B0-0x00000001814A81C0
		public BrotliStream(Stream stream, CompressionLevel compressionLevel) {} // 0x000000018B955108-0x000000018B955114
		public BrotliStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen) {} // 0x000000018B955D20-0x000000018B955E08
	
		// Methods
		private void EnsureNotDisposed() {} // 0x000000018B95584C-0x000000018B955898
		protected override void Dispose(bool disposing) {} // 0x000000018B9561DC-0x000000018B956228
		private static void ValidateParameters(byte[] array, int offset, int count) {} // 0x000000018B956228-0x000000018B956274
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x000000018B955114-0x000000018B95512C
		public override void SetLength(long value) {} // 0x000000018B9557AC-0x000000018B95584C
		private void EnsureNoActiveAsyncOperation() {} // 0x000000018B954FB0-0x000000018B955040
		private void AsyncOperationStarting() {} // 0x000000018B9550CC-0x000000018B955108
		private void AsyncOperationCompleting() {} // 0x000000018B9556CC-0x000000018B9557AC
		private static void ThrowInvalidBeginCall() {} // 0x000000018B955560-0x000000018B9556CC
		public override int Read(byte[] buffer, int offset, int count) => default; // 0x000000018B95512C-0x000000018B955230
		public override int Read(Span<byte> buffer) => default; // 0x000000018B956104-0x000000018B956120
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) => default; // 0x000000018B956120-0x000000018B95617C
		public override int EndRead(IAsyncResult asyncResult) => default; // 0x000000018B956044-0x000000018B9560E0
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => default; // 0x000000018B9560E0-0x000000018B956104
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default) => default; // 0x000000018B955E08-0x000000018B956044
		private ValueTask<int> FinishReadAsyncMemory(Memory<byte> buffer, CancellationToken cancellationToken) => default; // 0x000000018B955040-0x000000018B9550CC
		public override void Write(byte[] buffer, int offset, int count) {} // 0x000000018B955BD4-0x000000018B955D20
		public override void Write(ReadOnlySpan<byte> buffer) {} // 0x000000018B955AE4-0x000000018B955BD4
		internal void WriteCore(ReadOnlySpan<byte> buffer, bool isFinalBlock = false /* Metadata: 0x02082ADD */) {} // 0x000000018B9553BC-0x000000018B955560
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) => default; // 0x000000018B955304-0x000000018B9553BC
		public override void EndWrite(IAsyncResult asyncResult) {} // 0x000000018B955230-0x000000018B955304
		public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => default; // 0x000000018B9568A4-0x000000018B95719C
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default) => default; // 0x000000018B95719C-0x000000018B9571E8
		private System.Threading.Tasks.Task WriteAsyncMemoryCore(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) => default; // 0x000000018B9577A8-0x000000018B957D84
		public override void Flush() {} // 0x000000018B957D84-0x000000018B957E80
		public override System.Threading.Tasks.Task FlushAsync(CancellationToken cancellationToken) => default; // 0x000000018B9571E8-0x000000018B95774C
		private System.Threading.Tasks.Task FlushAsyncCore(CancellationToken cancellationToken) => default; // 0x000000018B95774C-0x000000018B9577A8
	}

	internal static class BrotliUtils // TypeDefIndex: 60719
	{
		// Methods
		internal static int GetQualityFromCompressionLevel(CompressionLevel level) => default; // 0x000000018B9562C0-0x000000018B9562E4
	}

	public struct BrotliDecoder : IDisposable // TypeDefIndex: 60720
	{
		// Fields
		private SafeBrotliDecoderHandle _state; // 0x00
		private bool _disposed; // 0x08
	
		// Methods
		internal void InitializeDecoder() {} // 0x00000001858B0D10-0x00000001858B0D60
		internal void EnsureInitialized() {} // 0x00000001841B2C60-0x00000001841B2C90
		public void Dispose() {} // 0x0000000184FA68D0-0x0000000184FA68F0
		private void EnsureNotDisposed() {} // 0x00000001841B2C90-0x00000001841B2CB0
		public OperationStatus Decompress(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesConsumed, out int bytesWritten) {
			bytesConsumed = default;
			bytesWritten = default;
			return default;
		} // 0x00000001841B2940-0x00000001841B2C60
	}

	public struct BrotliEncoder : IDisposable // TypeDefIndex: 60721
	{
		// Fields
		internal SafeBrotliEncoderHandle _state; // 0x00
		private bool _disposed; // 0x08
	
		// Constructors
		public BrotliEncoder(int quality, int window) {
			_state = default;
			_disposed = default;
		} // 0x000000018B954EB4-0x000000018B954F80
	
		// Methods
		internal void InitializeEncoder() {} // 0x000000018B954A74-0x000000018B954B10
		internal void EnsureInitialized() {} // 0x000000018B9548C4-0x000000018B9548F0
		public void Dispose() {} // 0x0000000185FA8050-0x0000000185FA8070
		private void EnsureNotDisposed() {} // 0x000000018B9548F0-0x000000018B954974
		internal void SetQuality(int quality) {} // 0x000000018B954B10-0x000000018B954CE0
		internal void SetWindow(int window) {} // 0x000000018B954CE0-0x000000018B954EB4
		internal OperationStatus Flush(Memory<byte> destination, out int bytesWritten) {
			bytesWritten = default;
			return default;
		} // 0x000000018B954974-0x000000018B9549EC
		public OperationStatus Flush(Span<byte> destination, out int bytesWritten) {
			bytesWritten = default;
			return default;
		} // 0x000000018B9549EC-0x000000018B954A74
		internal OperationStatus Compress(ReadOnlyMemory<byte> source, Memory<byte> destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock) {
			bytesConsumed = default;
			bytesWritten = default;
			return default;
		} // 0x000000018B9547A8-0x000000018B954878
		public OperationStatus Compress(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock) {
			bytesConsumed = default;
			bytesWritten = default;
			return default;
		} // 0x000000018B954878-0x000000018B9548C4
		internal OperationStatus Compress(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesConsumed, out int bytesWritten, BrotliEncoderOperation operation) {
			bytesConsumed = default;
			bytesWritten = default;
			return default;
		} // 0x000000018B9545EC-0x000000018B9547A8
	}

	internal enum BrotliEncoderOperation // TypeDefIndex: 60722
	{
		Process = 0,
		Flush = 1,
		Finish = 2,
		EmitMetadata = 3
	}

	internal enum BrotliEncoderParameter // TypeDefIndex: 60723
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
	internal static class TaskToApm // TypeDefIndex: 60726
	{
		// Nested types
		private sealed class TaskWrapperAsyncResult : IAsyncResult // TypeDefIndex: 60724
		{
			// Fields
			internal readonly System.Threading.Tasks.Task Task; // 0x10
			private readonly object _state; // 0x18
			private readonly bool _completedSynchronously; // 0x20
	
			// Properties
			object IAsyncResult.AsyncState { get => default; } // 0x000000018B9566F0-0x000000018B9567AC 
			bool IAsyncResult.CompletedSynchronously { get => default; }
			bool IAsyncResult.IsCompleted { get => default; } // 0x000000018B9567AC-0x000000018B9568A4 
			WaitHandle IAsyncResult.AsyncWaitHandle { get => default; } // 0x0000000185F5FD40-0x0000000185F5FD70 
	
			// Constructors
			public TaskWrapperAsyncResult() {} // Dummy constructor
			internal TaskWrapperAsyncResult(System.Threading.Tasks.Task task, object state, bool completedSynchronously) {} // 0x000000018B9565F4-0x000000018B9566F0
		}
	
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 60725
		{
			// Fields
			public AsyncCallback callback; // 0x10
			public IAsyncResult asyncResult; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			internal void _InvokeCallbackWhenTaskCompletes_b__0() {} // 0x00000001813ECBF0-0x00000001813ECC00
		}
	
		// Methods
		public static IAsyncResult Begin(System.Threading.Tasks.Task task, AsyncCallback callback, object state) => default; // 0x000000018B3BE8E0-0x000000018B3BE900
		public static void End(IAsyncResult asyncResult) {} // 0x000000018B3BE8C0-0x000000018B3BE8E0
		public static TResult End<TResult>(IAsyncResult asyncResult) => default; // 0x0000000185492010-0x0000000185492020
		private static void InvokeCallbackWhenTaskCompletes(System.Threading.Tasks.Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) {} // 0x000000018B3C2F90-0x000000018B3C2FB4
	}
}
