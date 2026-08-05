/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 150: SRSA.dll - Assembly: SRSA, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63881-63886
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond
{
	public static class SRSA // TypeDefIndex: 63882
	{
		// Fields
		private const string EncryptionLib = "__Internal"; // Metadata: 0x023536C0
		public const int s_keyLength = 178; // Metadata: 0x023536CB
	
		// Methods
		public static extern IntPtr mono_method_h_get_code(IntPtr message, int message_size); // 0x0000000185397C3C-0x0000000185397C44
		public static extern IntPtr mono_method_h_set_code(IntPtr message); // 0x0000000185397C34-0x0000000185397C3C
		public static extern void mono_method_h_remove_code(IntPtr message); // 0x0000000185397C44-0x0000000185397C4C
		public static void LoadFromFile(Span<byte> message, ref Span<byte> buffer); // 0x00000001847C96C0-0x00000001847C9850
		public static void LoadFromFile2(Span<byte> inputData, ref Span<byte> outputBytes); // 0x00000001847C9530-0x00000001847C96C0
		public static void test(); // 0x000000018AC87AB4-0x000000018AC87AF4
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63883
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37720-0x0000000184D37790
	
		// Methods
		public void __Gen_Wrap_0(Span<byte> P0, ref Span<byte> P1); // 0x000000018AC878B8-0x000000018AC87A20
		public void __Gen_Wrap_1(); // 0x00000001863761FC-0x0000000186376284
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 63884
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018AC87A20-0x000000018AC87AB4
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 63885
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018AC87CDC-0x000000018AC87D40
		public static bool IsPatched(int id); // 0x00000001847C98C0-0x00000001847C9930
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018AC87B98-0x000000018AC87C64
		public object CreateWrapper(int id); // 0x000000018AC87C64-0x000000018AC87CDC
		public object InitWrapperArray(int len); // 0x000000018AC87D40-0x000000018AC884C4
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018AC87AF4-0x000000018AC87B98
	}

	public enum IDMAP0 // TypeDefIndex: 63886
	{
		Beyond-SRSA-LoadFromFile0 = 0,
		Beyond-SRSA-LoadFromFile20 = 1,
		Beyond-SRSA-test0 = 2
	}
}
