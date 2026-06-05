/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;

// Image 153: System.Runtime.CompilerServices.Unsafe.dll - Assembly: System.Runtime.CompilerServices.Unsafe, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61288-61291

namespace System.Runtime.CompilerServices
{
	public static class Unsafe // TypeDefIndex: 61289
	{
		// Methods
		public static T ReadUnaligned<T>(ref byte source) => default;
		public static void WriteUnaligned<T>(ref byte destination, T value) {}
		public static int SizeOf<T>() => default;
		public static void CopyBlockUnaligned(ref byte destination, ref byte source, uint byteCount) {} // 0x0000000185FCFA60-0x0000000185FCFA70
		public static unsafe void InitBlock(void* startAddress, byte value, uint byteCount) {} // 0x0000000185FCFB60-0x0000000185FCFB70
		public static T As<T>(object o)
			where T : class => default;
		public static unsafe ref ref T AsRef<T>(void* source) => ref _refReturnTypeForAsRef;
		private ref T _refReturnTypeForAsRef; // Dummy field
		public static ref ref T AsRef<T>(ref ref T source) => ref _refReturnTypeForAsRef;
		private ref T _refReturnTypeForAsRef; // Dummy field
		public static ref ref TTo As<TFrom, TTo>(ref ref TFrom source) => ref _refReturnTypeForAs;
		private ref TTo _refReturnTypeForAs; // Dummy field
		public static ref ref T Add<T>(ref ref T source, int elementOffset) => ref _refReturnTypeForAdd;
		private ref T _refReturnTypeForAdd; // Dummy field
		public static ref ref T AddByteOffset<T>(ref ref T source, IntPtr byteOffset) => ref _refReturnTypeForAddByteOffset;
		private ref T _refReturnTypeForAddByteOffset; // Dummy field
	}

	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 61291
	{
		// Constructors
		public IsReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.Versioning
{
	internal sealed class NonVersionableAttribute : Attribute // TypeDefIndex: 61290
	{
		// Constructors
		public NonVersionableAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}
