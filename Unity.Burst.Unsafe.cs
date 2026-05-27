/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

// Image 163: Unity.Burst.Unsafe.dll - Assembly: Unity.Burst.Unsafe, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60255-60257

namespace System.Runtime.Versioning
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	internal sealed class NonVersionableAttribute : Attribute // TypeDefIndex: 60257
	{
		// Constructors
		public NonVersionableAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace Unity.Burst
{
	internal static class Unsafe // TypeDefIndex: 60256
	{
		// Methods
		[NonVersionable]
		public static unsafe ref ref T AsRef<T>(void* source) => ref _refReturnTypeForAsRef;
		private ref T _refReturnTypeForAsRef; // Dummy field
	}
}
