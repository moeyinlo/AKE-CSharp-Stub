/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using IFix.Core;

// Image 148: SRSA.dll - Assembly: SRSA, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61242-61247

namespace Beyond
{
	public static class SRSA // TypeDefIndex: 61243
	{
		// Fields
		private const string EncryptionLib = "__Internal"; // Metadata: 0x02083A40
		public const int s_keyLength = 178; // Metadata: 0x02083A4B
	
		// Methods
		public static extern IntPtr mono_method_h_get_code(IntPtr message, int message_size); // 0x0000000186474638-0x0000000186474640
		public static extern IntPtr mono_method_h_set_code(IntPtr message); // 0x0000000186474640-0x0000000186474648
		public static extern void mono_method_h_remove_code(IntPtr message); // 0x0000000186474648-0x0000000186474650
		public static void LoadFromFile(Span<byte> message, ref Span<byte> buffer) {} // 0x000000018580F0D0-0x000000018580F260
		public static void LoadFromFile2(Span<byte> inputData, ref Span<byte> outputBytes) {} // 0x000000018580EF40-0x000000018580F0D0
		public static void test() {} // 0x000000018B7CECD4-0x000000018B7CED14
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 61244
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F64630-0x0000000185F646A0
	
		// Methods
		public void __Gen_Wrap_0(Span<byte> P0, ref Span<byte> P1) {} // 0x000000018B7CEAD8-0x000000018B7CEC40
		public void __Gen_Wrap_1() {} // 0x0000000187350FD4-0x000000018735105C
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 61245
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018B7CEC40-0x000000018B7CECD4
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 61246
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018B7CEEFC-0x000000018B7CEF60
		public static bool IsPatched(int id) => default; // 0x000000018580F5E0-0x000000018580F650
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018B7CEDB8-0x000000018B7CEE84
		public object CreateWrapper(int id) => default; // 0x000000018B7CEE84-0x000000018B7CEEFC
		public object InitWrapperArray(int len) => default; // 0x000000018B7CEF60-0x000000018B7CFBC4
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018B7CED14-0x000000018B7CEDB8
	}

	public enum IDMAP0 // TypeDefIndex: 61247
	{
		Beyond-SRSA-LoadFromFile0 = 0,
		Beyond-SRSA-LoadFromFile20 = 1,
		Beyond-SRSA-test0 = 2
	}
}
