/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using Beyond.VFS;
using IFix.Core;
using Unity.Collections;
using Unity.IO.LowLevel.Unsafe;

// Image 144: Unsafe.VFS.dll - Assembly: Unsafe.VFS, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91316-91332

namespace Beyond.VFS
{
	public struct FVFSUntrackedLowIOReadHandle : IDisposable // TypeDefIndex: 91317
	{
		// Fields
		public unsafe ReadCommand* readCommand; // 0x00
		public ReadHandle readHandle; // 0x08
		public bool isEnc; // 0x18
	
		// Constructors
		public unsafe FVFSUntrackedLowIOReadHandle(string path, long offset, long len, bool async, bool isEnc); // 0x00000001858868F0-0x0000000185886A90
		public unsafe FVFSUntrackedLowIOReadHandle(UnSafeString path, long offset, long len, bool async, bool isEnc); // 0x000000018D6D4608-0x000000018D6D4760
	
		// Methods
		public void Dispose(); // 0x0000000185886E70-0x0000000185886F50
		public bool IsValid(); // 0x00000001858868B0-0x00000001858868F0
		public bool IsComplete(); // 0x0000000185BC4330-0x0000000185BC4360
		public ReadStatus GetStatus(); // 0x0000000185887F50-0x0000000185887F80
		public NativeArray<byte> GetData(); // 0x000000018521ACD0-0x000000018521AD80
		public NativeArray<byte> GetDataThread(); // 0x00000001858886F0-0x0000000185888770
	}

	public struct FVFSPathInfo // TypeDefIndex: 91318
	{
		// Fields
		public string fullPathFormat; // 0x00
		public string param0; // 0x08
		public string param1; // 0x10
		public string param2; // 0x18
	
		// Methods
		public string GetResultString(); // 0x000000018510FB10-0x000000018510FBF0
		public UnSafeString GetUnsafeString(); // 0x0000000184F91150-0x0000000184F91220
	}

	public static class ThreadUnsafeStringUtils // TypeDefIndex: 91319
	{
		// Fields
		private static ConcurrentStack<UnSafeString> s_stack; // 0x00
	
		// Constructors
		static ThreadUnsafeStringUtils(); // 0x0000000187187550-0x00000001871875D0
	
		// Methods
		public static UnSafeString ThreadStringAlloc(); // 0x000000018588CCA0-0x000000018588CD90
		public static void ThreadStringRelease(UnSafeString value); // 0x000000018588C580-0x000000018588C6C0
	
		// Extension methods
		public static UnSafeString AppendPathInfo(this UnSafeString str, ref FVFSPathInfo info); // 0x000000018588D080-0x000000018588D250
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 91320
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018D6D5178-0x000000018D6D51DC
	
		// Methods
		public void __Gen_Wrap_0(ref FVFSUntrackedLowIOReadHandle P0); // 0x000000018D6D4760-0x000000018D6D4894
		public bool __Gen_Wrap_1(ref FVFSUntrackedLowIOReadHandle P0); // 0x000000018D6D4894-0x000000018D6D49D8
		public ReadStatus __Gen_Wrap_2(ref FVFSUntrackedLowIOReadHandle P0); // 0x000000018D6D49D8-0x000000018D6D4B1C
		public NativeArray<byte> __Gen_Wrap_3(ref FVFSUntrackedLowIOReadHandle P0); // 0x000000018D6D4B1C-0x000000018D6D4C8C
		public string __Gen_Wrap_4(ref FVFSPathInfo P0); // 0x000000018D6D4C8C-0x000000018D6D4DE8
		public UnSafeString __Gen_Wrap_5(ref FVFSPathInfo P0); // 0x000000018D6D4DE8-0x000000018D6D4F44
		public UnSafeString __Gen_Wrap_6(); // 0x000000018D6D4F44-0x000000018D6D5000
		public void __Gen_Wrap_7(object P0); // 0x00000001887ED758-0x00000001887ED80C
		public UnSafeString __Gen_Wrap_8(object P0, ref FVFSPathInfo P1); // 0x000000018D6D5000-0x000000018D6D5178
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 91321
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018D6D51DC-0x000000018D6D5274
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 91322
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018D6D5460-0x000000018D6D54C4
		public static bool IsPatched(int id); // 0x000000018D6D5550-0x000000018D6D55CC
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018D6D5318-0x000000018D6D53E4
		public object CreateWrapper(int id); // 0x000000018D6D53E4-0x000000018D6D5460
		public object InitWrapperArray(int len); // 0x000000018D6D54C4-0x000000018D6D5550
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018D6D5274-0x000000018D6D5318
	}

	public delegate void __HotPatchDelegate_0(ref FVFSUntrackedLowIOReadHandle P0); // TypeDefIndex: 91323; 0x0000000185B78EA0-0x0000000185B78EB0

	public enum HotPatchIDMAP0 // TypeDefIndex: 91324
	{
		Beyond-VFS-FVFSUntrackedLowIOReadHandle-Dispose0 = 0,
		Beyond-VFS-FVFSUntrackedLowIOReadHandle-IsValid0 = 1,
		Beyond-VFS-FVFSUntrackedLowIOReadHandle-IsComplete0 = 1,
		Beyond-VFS-FVFSUntrackedLowIOReadHandle-GetStatus0 = 2,
		Beyond-VFS-FVFSUntrackedLowIOReadHandle-GetData0 = 3,
		Beyond-VFS-FVFSUntrackedLowIOReadHandle-GetDataThread0 = 3,
		Beyond-VFS-FVFSPathInfo-GetResultString0 = 4,
		Beyond-VFS-FVFSPathInfo-GetUnsafeString0 = 5,
		Beyond-VFS-ThreadUnsafeStringUtils-ThreadStringAlloc0 = 6,
		Beyond-VFS-ThreadUnsafeStringUtils-ThreadStringRelease0 = 7,
		Beyond-VFS-ThreadUnsafeStringUtils-AppendPathInfo0 = 8
	}

	public delegate bool __HotPatchDelegate_1(ref FVFSUntrackedLowIOReadHandle P0); // TypeDefIndex: 91325; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate ReadStatus __HotPatchDelegate_2(ref FVFSUntrackedLowIOReadHandle P0); // TypeDefIndex: 91326; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate NativeArray<byte> __HotPatchDelegate_3(ref FVFSUntrackedLowIOReadHandle P0); // TypeDefIndex: 91327; 0x0000000186464680-0x00000001864646B0

	public delegate string __HotPatchDelegate_4(ref FVFSPathInfo P0); // TypeDefIndex: 91328; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UnSafeString __HotPatchDelegate_5(ref FVFSPathInfo P0); // TypeDefIndex: 91329; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UnSafeString __HotPatchDelegate_6(); // TypeDefIndex: 91330; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_7(object P0); // TypeDefIndex: 91331; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UnSafeString __HotPatchDelegate_8(object P0, ref FVFSPathInfo P1); // TypeDefIndex: 91332; 0x00000001859B7730-0x00000001859B7740
}
