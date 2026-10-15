/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

// Image 156: System.Runtime.CompilerServices.Unsafe.dll - Assembly: System.Runtime.CompilerServices.Unsafe, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a - Types 91412-91415

namespace System.Runtime.CompilerServices
{
	public static class Unsafe // TypeDefIndex: 91413
	{
		// Methods
		[NonVersionable]
		public static T ReadUnaligned<T>(ref byte source);
		[NonVersionable]
		public static void WriteUnaligned<T>(ref byte destination, T value);
		[NonVersionable]
		public static int SizeOf<T>();
		[NonVersionable]
		public static void CopyBlockUnaligned(ref byte destination, ref byte source, uint byteCount); // 0x0000000187251E20-0x0000000187251E30
		[NonVersionable]
		public static unsafe void InitBlock(void* startAddress, byte value, uint byteCount); // 0x0000000187251F40-0x0000000187251F50
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
		public static ref ref T Unbox<T>(object box)
			where T : struct;
		[NonVersionable]
		public static ref ref T Add<T>(ref ref T source, int elementOffset);
		[NonVersionable]
		public static ref ref T AddByteOffset<T>(ref ref T source, IntPtr byteOffset);
		[NonVersionable]
		public static ref ref T NullRef<T>();
	}

	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 91415
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.Versioning
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	internal sealed class NonVersionableAttribute : Attribute // TypeDefIndex: 91414
	{
		// Constructors
		public NonVersionableAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
