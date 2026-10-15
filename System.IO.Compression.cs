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

// Image 108: System.IO.Compression.dll - Assembly: System.IO.Compression, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 90771-90788

internal static class Interop // TypeDefIndex: 90773
{
	// Nested types
	internal static class Brotli // TypeDefIndex: 90772
	{
		// Methods
		internal static extern SafeBrotliDecoderHandle BrotliDecoderCreateInstance(IntPtr allocFunc, IntPtr freeFunc, IntPtr opaque); // 0x00000001868DEDF0-0x00000001868DEE70
		internal static unsafe extern int BrotliDecoderDecompressStream(SafeBrotliDecoderHandle state, ref IntPtr availableIn, byte** nextIn, ref IntPtr availableOut, byte** nextOut, out IntPtr totalOut); // 0x0000000185722F40-0x0000000185722FD0
		internal static extern void BrotliDecoderDestroyInstance(IntPtr state); // 0x000000018783D838-0x000000018783D840
		internal static extern bool BrotliDecoderIsFinished(SafeBrotliDecoderHandle state); // 0x00000001857215A0-0x0000000185721600
		internal static extern SafeBrotliEncoderHandle BrotliEncoderCreateInstance(IntPtr allocFunc, IntPtr freeFunc, IntPtr opaque); // 0x000000018CFD0A94-0x000000018CFD0B0C
		internal static extern bool BrotliEncoderSetParameter(SafeBrotliEncoderHandle state, BrotliEncoderParameter parameter, uint value); // 0x000000018CFD0B7C-0x000000018CFD0BF8
		internal static unsafe extern bool BrotliEncoderCompressStream(SafeBrotliEncoderHandle state, BrotliEncoderOperation op, ref IntPtr availableIn, byte** nextIn, ref IntPtr availableOut, byte** nextOut, out IntPtr totalOut); // 0x000000018CFD09E8-0x000000018CFD0A94
		internal static extern bool BrotliEncoderHasMoreOutput(SafeBrotliEncoderHandle state); // 0x000000018CFD0B14-0x000000018CFD0B7C
		internal static extern void BrotliEncoderDestroyInstance(IntPtr state); // 0x000000018CFD0B0C-0x000000018CFD0B14
	}
}

internal static class SR // TypeDefIndex: 90774
{
	// Methods
	internal static string Format(string resourceFormat, object p1); // 0x000000018CFD0C7C-0x000000018CFD0CD8
	internal static string Format(string resourceFormat, object p1, object p2, object p3); // 0x000000018CFD0BF8-0x000000018CFD0C7C
}

namespace Microsoft.Win32.SafeHandles
{
	internal sealed class SafeBrotliEncoderHandle : SafeHandle // TypeDefIndex: 90787
	{
		// Properties
		public override bool IsInvalid { get; } // 0x0000000185371DA0-0x0000000185371DB0 
	
		// Constructors
		public SafeBrotliEncoderHandle(); // 0x0000000187835F00-0x0000000187835F10
	
		// Methods
		protected override bool ReleaseHandle(); // 0x000000018CFD0CD8-0x000000018CFD0CEC
	}

	internal sealed class SafeBrotliDecoderHandle : SafeHandle // TypeDefIndex: 90788
	{
		// Properties
		public override bool IsInvalid { get; } // 0x0000000185371DA0-0x0000000185371DB0 
	
		// Constructors
		public SafeBrotliDecoderHandle(); // 0x0000000187835F00-0x0000000187835F10
	
		// Methods
		protected override bool ReleaseHandle(); // 0x0000000187031AA0-0x0000000187031AC0
	}
}

namespace System.IO.Compression
{
	public sealed class BrotliStream : Stream // TypeDefIndex: 90778
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
		public override bool CanRead { get; } // 0x000000018CFD0888-0x000000018CFD08B4 
		public override bool CanWrite { get; } // 0x000000018CFD08B4-0x000000018CFD08E0 
		public override bool CanSeek { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override long Length { get; } // 0x000000018CFD08E0-0x000000018CFD092C 
		public override long Position { get; set; } // 0x000000018CFD092C-0x000000018CFD0978 0x000000018CFD0978-0x000000018CFD09C4
		private bool AsyncOperationIsActive { get; } // 0x000000018CFD0880-0x000000018CFD0888 
	
		// Nested types
		[CompilerGenerated]
		private struct _FinishReadAsyncMemory_d__41 : IAsyncStateMachine // TypeDefIndex: 90775
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
			private void MoveNext(); // 0x000000018CFD0FA4-0x000000018CFD17AC
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018CFD17AC-0x000000018CFD17F8
		}
	
		[CompilerGenerated]
		private struct _WriteAsyncMemoryCore_d__52 : IAsyncStateMachine // TypeDefIndex: 90776
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
			private void MoveNext(); // 0x000000018CFD1DE0-0x000000018CFD2424
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018CFD2424-0x000000018CFD2480
		}
	
		[CompilerGenerated]
		private struct _FlushAsyncCore_d__55 : IAsyncStateMachine // TypeDefIndex: 90777
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public BrotliStream __4__this; // 0x20
			public CancellationToken cancellationToken; // 0x28
			private OperationStatus _lastResult_5__2; // 0x30
			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter __u__1; // 0x38
	
			// Methods
			private void MoveNext(); // 0x000000018CFD17F8-0x000000018CFD1D60
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018CFD1D60-0x000000018CFD1DBC
		}
	
		// Constructors
		public BrotliStream(Stream stream, CompressionMode mode, bool leaveOpen); // 0x0000000186EE2A70-0x0000000186EE2B50
		public BrotliStream(Stream stream, CompressionLevel compressionLevel); // 0x000000018CFD0808-0x000000018CFD0824
		public BrotliStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen); // 0x000000018CFD0824-0x000000018CFD0880
	
		// Methods
		private void EnsureNotDisposed(); // 0x00000001857205C0-0x00000001857205E0
		protected override void Dispose(bool disposing); // 0x0000000186F941B0-0x0000000186F942A0
		private static void ValidateParameters(byte[] array, int offset, int count); // 0x000000018CFD0040-0x000000018CFD01E4
		public override long Seek(long offset, SeekOrigin origin); // 0x000000018CFCFF4C-0x000000018CFCFF98
		public override void SetLength(long value); // 0x000000018CFCFF98-0x000000018CFCFFE4
		private void EnsureNoActiveAsyncOperation(); // 0x000000018CFCF7FC-0x000000018CFCF814
		private void AsyncOperationStarting(); // 0x000000018CFCF674-0x000000018CFCF694
		private void AsyncOperationCompleting(); // 0x000000018CFCF664-0x000000018CFCF674
		private static void ThrowInvalidBeginCall(); // 0x000000018CFCFFE4-0x000000018CFD0040
		public override int Read(byte[] buffer, int offset, int count); // 0x000000018CFCFEA4-0x000000018CFCFF4C
		public override int Read(Span<byte> buffer); // 0x0000000185721090-0x00000001857212C0
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState); // 0x000000018CFCF694-0x000000018CFCF728
		public override int EndRead(IAsyncResult asyncResult); // 0x000000018CFCF7B4-0x000000018CFCF7F0
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken); // 0x000000018CFCFDC4-0x000000018CFCFEA4
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default); // 0x000000018CFCFC54-0x000000018CFCFDC4
		private async ValueTask<int> FinishReadAsyncMemory(Memory<byte> buffer, CancellationToken cancellationToken); // 0x000000018CFCF814-0x000000018CFCF918
		public override void Write(byte[] buffer, int offset, int count); // 0x000000018CFD0748-0x000000018CFD07E4
		public override void Write(ReadOnlySpan<byte> buffer); // 0x000000018CFD07E4-0x000000018CFD0808
		internal void WriteCore(ReadOnlySpan<byte> buffer, bool isFinalBlock = false /* Metadata: 0x0264B12D */); // 0x000000018CFD0500-0x000000018CFD0748
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState); // 0x000000018CFCF728-0x000000018CFCF7B4
		public override void EndWrite(IAsyncResult asyncResult); // 0x000000018CFCF7F0-0x000000018CFCF7FC
		public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken); // 0x000000018CFD0424-0x000000018CFD0500
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default); // 0x000000018CFD02D8-0x000000018CFD0424
		private async System.Threading.Tasks.Task WriteAsyncMemoryCore(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken); // 0x000000018CFD01E4-0x000000018CFD02D8
		public override void Flush(); // 0x000000018CFCFAA8-0x000000018CFCFC54
		public override System.Threading.Tasks.Task FlushAsync(CancellationToken cancellationToken); // 0x000000018CFCF9F0-0x000000018CFCFAA8
		private async System.Threading.Tasks.Task FlushAsyncCore(CancellationToken cancellationToken); // 0x000000018CFCF918-0x000000018CFCF9F0
	}

	internal static class BrotliUtils // TypeDefIndex: 90779
	{
		// Methods
		internal static int GetQualityFromCompressionLevel(CompressionLevel level); // 0x000000018CFD09C4-0x000000018CFD09E8
	}

	public struct BrotliDecoder : IDisposable // TypeDefIndex: 90780
	{
		// Fields
		private SafeBrotliDecoderHandle _state; // 0x00
		private bool _disposed; // 0x08
	
		// Methods
		internal void InitializeDecoder(); // 0x00000001868DEDA0-0x00000001868DEDF0
		internal void EnsureInitialized(); // 0x0000000185721550-0x0000000185721580
		public void Dispose(); // 0x0000000186866C80-0x0000000186866CA0
		private void EnsureNotDisposed(); // 0x0000000185721580-0x00000001857215A0
		public OperationStatus Decompress(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesConsumed, out int bytesWritten); // 0x00000001857212C0-0x0000000185721550
	}

	public struct BrotliEncoder : IDisposable // TypeDefIndex: 90781
	{
		// Fields
		internal SafeBrotliEncoderHandle _state; // 0x00
		private bool _disposed; // 0x08
	
		// Constructors
		public BrotliEncoder(int quality, int window); // 0x000000018CFCF598-0x000000018CFCF664
	
		// Methods
		internal void InitializeEncoder(); // 0x000000018CFCF148-0x000000018CFCF1E4
		internal void EnsureInitialized(); // 0x000000018CFCEF90-0x000000018CFCEFBC
		public void Dispose(); // 0x0000000187222F30-0x0000000187222F50
		private void EnsureNotDisposed(); // 0x000000018CFCEFBC-0x000000018CFCF040
		internal void SetQuality(int quality); // 0x000000018CFCF1E4-0x000000018CFCF3BC
		internal void SetWindow(int window); // 0x000000018CFCF3BC-0x000000018CFCF598
		internal OperationStatus Flush(Memory<byte> destination, out int bytesWritten); // 0x000000018CFCF040-0x000000018CFCF0B8
		public OperationStatus Flush(Span<byte> destination, out int bytesWritten); // 0x000000018CFCF0B8-0x000000018CFCF148
		internal OperationStatus Compress(ReadOnlyMemory<byte> source, Memory<byte> destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock); // 0x000000018CFCEE6C-0x000000018CFCEF40
		public OperationStatus Compress(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock); // 0x000000018CFCEF40-0x000000018CFCEF90
		internal OperationStatus Compress(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesConsumed, out int bytesWritten, BrotliEncoderOperation operation); // 0x000000018CFCECA4-0x000000018CFCEE6C
	}

	internal enum BrotliEncoderOperation // TypeDefIndex: 90782
	{
		Process = 0,
		Flush = 1,
		Finish = 2,
		EmitMetadata = 3
	}

	internal enum BrotliEncoderParameter // TypeDefIndex: 90783
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
	internal static class TaskToApm // TypeDefIndex: 90786
	{
		// Nested types
		private sealed class TaskWrapperAsyncResult : IAsyncResult // TypeDefIndex: 90784
		{
			// Fields
			internal readonly System.Threading.Tasks.Task Task; // 0x10
			private readonly object _state; // 0x18
			private readonly bool _completedSynchronously; // 0x20
	
			// Properties
			object IAsyncResult.AsyncState { get; } // 0x0000000182234E30-0x0000000182234E40 
			bool IAsyncResult.CompletedSynchronously { get; } // 0x0000000182246E50-0x0000000182246E60 
			bool IAsyncResult.IsCompleted { get; } // 0x000000018CA433C0-0x000000018CA433E0 
			WaitHandle IAsyncResult.AsyncWaitHandle { get; } // 0x000000018CA433A0-0x000000018CA433C0 
	
			// Constructors
			internal TaskWrapperAsyncResult(System.Threading.Tasks.Task task, object state, bool completedSynchronously); // 0x000000018601CB80-0x000000018601CBB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 90785
		{
			// Fields
			public AsyncCallback callback; // 0x10
			public IAsyncResult asyncResult; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _InvokeCallbackWhenTaskCompletes_b__0(); // 0x000000018CFD1DBC-0x000000018CFD1DE0
		}
	
		// Methods
		public static IAsyncResult Begin(System.Threading.Tasks.Task task, AsyncCallback callback, object state); // 0x000000018CFD0CEC-0x000000018CFD0DF0
		public static void End(IAsyncResult asyncResult); // 0x000000018CFD0DF0-0x000000018CFD0EAC
		public static TResult End<TResult>(IAsyncResult asyncResult);
		private static void InvokeCallbackWhenTaskCompletes(System.Threading.Tasks.Task antecedent, AsyncCallback callback, IAsyncResult asyncResult); // 0x000000018CFD0EAC-0x000000018CFD0FA4
	}
}
