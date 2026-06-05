/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;

// Image 164: Unity.Burst.Unsafe.dll - Assembly: Unity.Burst.Unsafe, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61332-61334

namespace System.Runtime.Versioning
{
	internal sealed class NonVersionableAttribute : Attribute // TypeDefIndex: 61334
	{
		// Constructors
		public NonVersionableAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Unity.Burst
{
	internal static class Unsafe // TypeDefIndex: 61333
	{
		// Methods
		public static unsafe ref ref T AsRef<T>(void* source) => ref _refReturnTypeForAsRef;
		private ref T _refReturnTypeForAsRef; // Dummy field
	}
}
