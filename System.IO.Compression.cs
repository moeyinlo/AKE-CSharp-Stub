/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
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

