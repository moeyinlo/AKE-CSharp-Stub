/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using IFix.Core;
using Unity.Collections;

// Image 150: Beyond.Native.dll - Assembly: Beyond.Native, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60195-60202
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyCopyright("\u00A9 Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyDescription("System.Runtime.CompilerServices.Unsafe")]
[assembly: AssemblyFileVersion("6.0.21.52210")]
[assembly: AssemblyInformationalVersion("6.0.0")]
[assembly: AssemblyMetadata("IsTrimmable", "True")]
[assembly: AssemblyMetadata("Serviceable", "True")]
[assembly: AssemblyMetadata(".NETFrameworkAssembly", "")]
[assembly: AssemblyProduct("Microsoft\u00AE .NET Framework")]
[assembly: AssemblyTitle("System.Runtime.CompilerServices.Unsafe")]
[assembly: CLSCompliant(false)]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Native
{
	public static class NativeHelper // TypeDefIndex: 60198
	{
		// Methods
		[NonVersionable]
		public static Span<T> CreateSpan<T>(NativeArray<T> arr)
			where T : struct => default;
		[NonVersionable]
		public static string ToStringUTF8(NativeArray<byte> arr) => default; // 0x000000018516C2AC-0x000000018516C370
		[NonVersionable]
		public static ref ref T GetElementRef<T>(NativeArray<T> array, int idx)
			where T : struct => ref _refReturnTypeForGetElementRef;
		private ref T _refReturnTypeForGetElementRef; // Dummy field
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60199
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		[NonVersionable]
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		[NonVersionable]
		static ILFixDynamicMethodWrapper() {} // 0x000000018516C1B4-0x000000018516C218
	
		// Methods
		[NonVersionable]
		public string __Gen_Wrap_0(NativeArray<byte> P0) => default; // 0x000000018516C0B4-0x000000018516C1B4
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 60200
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		[NonVersionable]
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, [IsReadOnly] int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018516C218-0x000000018516C2AC
	
		// Methods
		[NonVersionable]
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 60201
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		[NonVersionable]
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018516C558-0x000000018516C5BC
		public static bool IsPatched(int id) => default; // 0x000000018516C648-0x000000018516C6E0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018516C414-0x000000018516C4E0
		public object CreateWrapper(int id) => default; // 0x000000018516C4E0-0x000000018516C558
		public object InitWrapperArray(int len) => default; // 0x000000018516C5BC-0x000000018516C648
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018516C370-0x000000018516C414
	}

	public enum IDMAP0 // TypeDefIndex: 60202
	{
		Beyond-Native-NativeHelper-ToStringUTF80 = 0
	}
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 60196
	{
		// Constructors
		[NonVersionable]
		public EmbeddedAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace System.Runtime.CompilerServices
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 60197
	{
		// Constructors
		[NonVersionable]
		public IsUnmanagedAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}
