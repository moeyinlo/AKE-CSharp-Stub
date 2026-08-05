/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using Microsoft.CodeAnalysis;
using Unity.Collections;

// Image 154: Beyond.Native.dll - Assembly: Beyond.Native, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63919-63926
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Native
{
	public static class NativeHelper // TypeDefIndex: 63922
	{
		// Methods
		public static Span<T> CreateSpan<T>(NativeArray<T> arr)
			where T : struct;
		public static string ToStringUTF8(NativeArray<byte> arr); // 0x000000018637F984-0x000000018637FA48
	
		// Extension methods
		public static ref ref T GetElementRef<T>(this NativeArray<T> array, int idx)
			where T : struct;
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63923
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x000000018637F88C-0x000000018637F8F0
	
		// Methods
		public string __Gen_Wrap_0(NativeArray<byte> P0); // 0x000000018637F78C-0x000000018637F88C
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 63924
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018637F8F0-0x000000018637F984
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 63925
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018637FC30-0x000000018637FC94
		public static bool IsPatched(int id); // 0x000000018637FD20-0x000000018637FDB8
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018637FAEC-0x000000018637FBB8
		public object CreateWrapper(int id); // 0x000000018637FBB8-0x000000018637FC30
		public object InitWrapperArray(int len); // 0x000000018637FC94-0x000000018637FD20
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018637FA48-0x000000018637FAEC
	}

	public enum IDMAP0 // TypeDefIndex: 63926
	{
		Beyond-Native-NativeHelper-ToStringUTF80 = 0
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 63920
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 63921
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}
