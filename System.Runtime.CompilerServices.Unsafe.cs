/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 152: System.Runtime.CompilerServices.Unsafe.dll - Assembly: System.Runtime.CompilerServices.Unsafe, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60211-60214

namespace System.Runtime.CompilerServices
{
	public static class Unsafe // TypeDefIndex: 60212
	{
		// Methods
		[IDTag(0)]
		public static T ReadUnaligned<T>(ref byte source) => default;
		public static void WriteUnaligned<T>(ref byte destination, T value) {}
		[IDTag(1)]
		public static int SizeOf<T>() => default;
		[IDTag(0)]
		public static void CopyBlockUnaligned(ref byte destination, ref byte source, uint byteCount) {} // 0x0000000183D6EE20-0x0000000183D6EE30
		public static unsafe void InitBlock(void* startAddress, byte value, uint byteCount) {} // 0x0000000183D6EF20-0x0000000183D6EF30
		public static T As<T>(object o)
			where T : class => default;
		public static unsafe ref ref T AsRef<T>(void* source) => ref _refReturnTypeForAsRef;
		private ref T _refReturnTypeForAsRef; // Dummy field
		public static ref ref T AsRef<T>(ref ref T source) => ref _refReturnTypeForAsRef;
		private ref T _refReturnTypeForAsRef; // Dummy field
		[IDTag(0)]
		public static ref ref TTo As<TFrom, TTo>(ref ref TFrom source) => ref _refReturnTypeForAs;
		private ref TTo _refReturnTypeForAs; // Dummy field
		public static ref ref T Add<T>(ref ref T source, int elementOffset) => ref _refReturnTypeForAdd;
		private ref T _refReturnTypeForAdd; // Dummy field
		public static ref ref T AddByteOffset<T>(ref ref T source, IntPtr byteOffset) => ref _refReturnTypeForAddByteOffset;
		private ref T _refReturnTypeForAddByteOffset; // Dummy field
	}

	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 60214
	{
		// Constructors
		[IDTag(0)]
		public IsReadOnlyAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace System.Runtime.Versioning
{
	internal sealed class NonVersionableAttribute : Attribute // TypeDefIndex: 60213
	{
		// Constructors
		[IDTag(0)]
		public NonVersionableAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}
