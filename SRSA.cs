/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 146: SRSA.dll - Assembly: SRSA, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60157-60162
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond
{
	public static class SRSA // TypeDefIndex: 60158
	{
		// Fields
		private const string EncryptionLib = "__Internal"; // Metadata: 0x01FDE13B
		public const int s_keyLength = 178; // Metadata: 0x01FDE146
	
		// Methods
		public static extern IntPtr mono_method_h_get_code([CallerFilePath] IntPtr message, int message_size); // 0x00000001842728F4-0x00000001842728FC
		public static extern IntPtr mono_method_h_set_code(IntPtr message); // 0x00000001842728FC-0x0000000184272904
		public static extern void mono_method_h_remove_code(IntPtr message); // 0x0000000184272904-0x000000018427290C
		public static void LoadFromFile(Span<byte> message, ref Span<byte> buffer) {} // 0x0000000182AB0290-0x0000000182AB0420
		public static void LoadFromFile2(Span<byte> inputData, ref Span<byte> outputBytes) {} // 0x0000000182AB0100-0x0000000182AB0290
		public static void test() {} // 0x00000001896A8BC8-0x00000001896A8C08
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60159
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05D40-0x0000000183D05DB0
	
		// Methods
		public void __Gen_Wrap_0(Span<byte> P0, ref Span<byte> P1) {} // 0x00000001896A89CC-0x00000001896A8B34
		public void __Gen_Wrap_1() {} // 0x00000001851624BC-0x0000000185162544
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 60160
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x00000001896A8B34-0x00000001896A8BC8
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 60161
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001896A8DF0-0x00000001896A8E54
		public static bool IsPatched(int id) => default; // 0x0000000182AB0850-0x0000000182AB08C0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001896A8CAC-0x00000001896A8D78
		public object CreateWrapper(int id) => default; // 0x00000001896A8D78-0x00000001896A8DF0
		public object InitWrapperArray(int len) => default; // 0x00000001896A8E54-0x00000001896A9AB8
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x00000001896A8C08-0x00000001896A8CAC
	}

	public enum IDMAP0 // TypeDefIndex: 60162
	{
		Beyond-SRSA-LoadFromFile0 = 0,
		Beyond-SRSA-LoadFromFile20 = 1,
		Beyond-SRSA-test0 = 2
	}
}
