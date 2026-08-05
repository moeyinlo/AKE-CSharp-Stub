/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

// Image 155: System.Runtime.CompilerServices.Unsafe.dll - Assembly: System.Runtime.CompilerServices.Unsafe, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a - Types 63927-63930
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyCopyright("\u00A9 Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyDescription("System.Runtime.CompilerServices.Unsafe")]
[assembly: AssemblyFileVersion("6.0.21.52210")]
[assembly: AssemblyInformationalVersion("6.0.0")]
[assembly: AssemblyMetadata("IsTrimmable", "True")]
[assembly: AssemblyMetadata("Serviceable", "True")]
[assembly: AssemblyMetadata(".NETFrameworkAssembly", "")]
[assembly: AssemblyProduct("Microsoft\u00AE .NET Framework")]
[assembly: AssemblyTitle("System.Runtime.CompilerServices.Unsafe")]
[assembly: CLSCompliant(false)]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace System.Runtime.CompilerServices
{
	public static class Unsafe // TypeDefIndex: 63928
	{
		// Methods
		[NonVersionable]
		public static T ReadUnaligned<T>(ref byte source);
		[NonVersionable]
		public static void WriteUnaligned<T>(ref byte destination, T value);
		[NonVersionable]
		public static int SizeOf<T>();
		[NonVersionable]
		public static void CopyBlockUnaligned(ref byte destination, ref byte source, uint byteCount); // 0x0000000184DA42B0-0x0000000184DA42C0
		[NonVersionable]
		public static unsafe void InitBlock(void* startAddress, byte value, uint byteCount); // 0x0000000184DA43F0-0x0000000184DA4400
		[NonVersionable]
		public static T As<T>(object o)
			where T : class;
		[NonVersionable]
		public static unsafe ref ref T AsRef<T>(void* source);
		[NonVersionable]
		public static ref ref T AsRef<T>([IsReadOnly] ref ref T source);
		[NonVersionable]
		public static ref ref TTo As<TFrom, TTo>(ref ref TFrom source);
		[NonVersionable]
		public static ref ref T Add<T>(ref ref T source, int elementOffset);
		[NonVersionable]
		public static ref ref T AddByteOffset<T>(ref ref T source, IntPtr byteOffset);
		[NonVersionable]
		public static ref ref T NullRef<T>();
	}

	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 63930
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.Versioning
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	internal sealed class NonVersionableAttribute : Attribute // TypeDefIndex: 63929
	{
		// Constructors
		public NonVersionableAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}
