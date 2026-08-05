/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;

// Image 166: Unity.Collections.LowLevel.ILSupport.dll - Assembly: Unity.Collections.LowLevel.ILSupport, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63976-63979
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: InternalsVisibleTo("Unity.Collections")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 63977
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 63978
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Unity.Collections.LowLevel.Unsafe
{
	internal static class ILSupport // TypeDefIndex: 63979
	{
		// Methods
		public static unsafe void* AddressOf<T>([IsReadOnly] in ref T thing)
			where T : struct;
		public static ref ref T AsRef<T>([IsReadOnly] in ref T thing)
			where T : struct;
	}
}
