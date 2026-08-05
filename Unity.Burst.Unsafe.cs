/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

// Image 168: Unity.Burst.Unsafe.dll - Assembly: Unity.Burst.Unsafe, Version=4.0.5.0, Culture=neutral, PublicKeyToken=null - Types 63981-63983
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyCopyright("\u00A9 Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyDescription("System.Runtime.CompilerServices.Unsafe")]
[assembly: AssemblyFileVersion("4.0.0.0")]
[assembly: AssemblyInformationalVersion("4.0.0.0")]
[assembly: AssemblyMetadata(".NETFrameworkAssembly", "")]
[assembly: AssemblyMetadata("Serviceable", "True")]
[assembly: AssemblyProduct("Microsoft\u00AE .NET Framework")]
[assembly: AssemblyTitle("Unity.Burst.Unsafe")]
[assembly: CLSCompliant(false)]
[assembly: CompilationRelaxations(8)]
[assembly: InternalsVisibleTo("Unity.Burst")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace System.Runtime.Versioning
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	internal sealed class NonVersionableAttribute : Attribute // TypeDefIndex: 63983
	{
		// Constructors
		public NonVersionableAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Unity.Burst
{
	internal static class Unsafe // TypeDefIndex: 63982
	{
		// Methods
		[NonVersionable]
		public static unsafe ref ref T AsRef<T>(void* source);
	}
}
