/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;

// Image 162: Unity.Collections.LowLevel.ILSupport.dll - Assembly: Unity.Collections.LowLevel.ILSupport, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61327-61330

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 61328
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 61329
	{
		// Constructors
		public IsReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Unity.Collections.LowLevel.Unsafe
{
	internal static class ILSupport // TypeDefIndex: 61330
	{
		// Methods
		public static unsafe void* AddressOf<T>(in ref T thing)
			where T : struct => default;
		public static ref ref T AsRef<T>(in ref T thing)
			where T : struct => ref _refReturnTypeForAsRef;
		private ref T _refReturnTypeForAsRef; // Dummy field
	}
}
