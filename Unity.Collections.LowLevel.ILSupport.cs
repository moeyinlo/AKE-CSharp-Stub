/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;

// Image 168: Unity.Collections.LowLevel.ILSupport.dll - Assembly: Unity.Collections.LowLevel.ILSupport, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91467-91470

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 91468
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 91469
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Unity.Collections.LowLevel.Unsafe
{
	internal static class ILSupport // TypeDefIndex: 91470
	{
		// Methods
		public static unsafe void* AddressOf<T>([IsReadOnly] in ref T thing)
			where T : struct;
		public static ref ref T AsRef<T>([IsReadOnly] in ref T thing)
			where T : struct;
	}
}
