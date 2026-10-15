/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 151: SRSA.dll - Assembly: SRSA, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91359-91366

namespace Beyond
{
	public static class SRSA // TypeDefIndex: 91360
	{
		// Fields
		private const string EncryptionLib = "__Internal"; // Metadata: 0x0264C04A
		public const int s_keyLength = 178; // Metadata: 0x0264C055
	
		// Methods
		public static extern IntPtr mono_method_h_get_code(IntPtr message, int message_size); // 0x000000018783D4DC-0x000000018783D4E4
		public static extern IntPtr mono_method_h_set_code(IntPtr message); // 0x000000018783D4D4-0x000000018783D4DC
		public static extern void mono_method_h_remove_code(IntPtr message); // 0x000000018783D4E4-0x000000018783D4EC
		public static void LoadFromFile(Span<byte> message, ref Span<byte> buffer); // 0x0000000186CE9F70-0x0000000186CEA100
		public static void LoadFromFile2(Span<byte> inputData, ref Span<byte> outputBytes); // 0x0000000186CE9DE0-0x0000000186CE9F70
		public static void test(); // 0x000000018CE79908-0x000000018CE79938
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 91361
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018CE7980C-0x000000018CE79870
	
		// Methods
		public void __Gen_Wrap_0(Span<byte> P0, ref Span<byte> P1); // 0x000000018CE796B4-0x000000018CE7980C
		public void __Gen_Wrap_1(); // 0x00000001887ED074-0x00000001887ED104
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 91362
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018CE79870-0x000000018CE79908
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 91363
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018CE79B24-0x000000018CE79B88
		public static bool IsPatched(int id); // 0x000000018CE79C14-0x000000018CE79CAC
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018CE799DC-0x000000018CE79AA8
		public object CreateWrapper(int id); // 0x000000018CE79AA8-0x000000018CE79B24
		public object InitWrapperArray(int len); // 0x000000018CE79B88-0x000000018CE79C14
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018CE79938-0x000000018CE799DC
	}

	public delegate void __HotPatchDelegate_0(Span<byte> P0, ref Span<byte> P1); // TypeDefIndex: 91364; 0x00000001826DF750-0x00000001826DF780

	public enum HotPatchIDMAP0 // TypeDefIndex: 91365
	{
		Beyond-SRSA-LoadFromFile0 = 0,
		Beyond-SRSA-LoadFromFile20 = 0,
		Beyond-SRSA-test0 = 1
	}

	public delegate void __HotPatchDelegate_1(); // TypeDefIndex: 91366; 0x0000000185B44B70-0x0000000185B44B80
}
