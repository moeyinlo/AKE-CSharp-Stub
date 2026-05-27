/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 161: Unity.Collections.LowLevel.ILSupport.dll - Assembly: Unity.Collections.LowLevel.ILSupport, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60250-60253

namespace Unity.Collections.LowLevel.Unsafe
{
	internal static class ILSupport // TypeDefIndex: 60253
	{
		// Methods
		public static unsafe void* AddressOf<T>([IsReadOnly] in ref T thing)
			where T : struct => default;
		public static ref ref T AsRef<T>([IsReadOnly] in ref T thing)
			where T : struct => ref _refReturnTypeForAsRef;
		private ref T _refReturnTypeForAsRef; // Dummy field
	}
}
