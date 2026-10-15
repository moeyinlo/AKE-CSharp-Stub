/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

// Image 170: Unity.Burst.Unsafe.dll - Assembly: Unity.Burst.Unsafe, Version=4.0.5.0, Culture=neutral, PublicKeyToken=null - Types 91472-91474

namespace System.Runtime.Versioning
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	internal sealed class NonVersionableAttribute : Attribute // TypeDefIndex: 91474
	{
		// Constructors
		public NonVersionableAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Unity.Burst
{
	internal static class Unsafe // TypeDefIndex: 91473
	{
		// Methods
		[NonVersionable]
		public static unsafe ref ref T AsRef<T>(void* source);
	}
}
