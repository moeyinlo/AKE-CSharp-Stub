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

// Image 138: Unsafe.VFS.dll - Assembly: Unsafe.VFS, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60099-60106
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.VFS
{
	public struct FVFSUntrackedLowIOReadHandle : IDisposable // TypeDefIndex: 60100
	{
		// Fields
		public unsafe ReadCommand* readCommand; // 0x00
		public ReadHandle readHandle; // 0x08
		public bool isEnc; // 0x18
	
		// Constructors
		public unsafe FVFSUntrackedLowIOReadHandle(string path, long offset, long len, bool async, bool isEnc) {
			readCommand = default;
			readHandle = default;
			this.isEnc = default;
		} // 0x0000000182989E20-0x0000000182989FE0
		public unsafe FVFSUntrackedLowIOReadHandle(UnSafeString path, long offset, long len, bool async, bool isEnc) {
			readCommand = default;
			readHandle = default;
			this.isEnc = default;
		} // 0x0000000189FA7790-0x0000000189FA78E0
	
		// Methods
		public void Dispose() {} // 0x0000000182988A80-0x0000000182988B50
		public bool IsValid() => default; // 0x0000000182989D30-0x0000000182989E20
		public bool IsComplete() => default; // 0x0000000182F45680-0x0000000182F456C0
		public ReadStatus GetStatus() => default; // 0x0000000182988F90-0x0000000182988FD0
		public NativeArray<byte> GetData() => default; // 0x0000000182F45950-0x0000000182F459F0
		public NativeArray<byte> GetDataThread() => default; // 0x000000018298AAD0-0x000000018298AB70
	}

	public struct FVFSPathInfo // TypeDefIndex: 60101
	{
		// Fields
		public string fullPathFormat; // 0x00
		public string param0; // 0x08
		public string param1; // 0x10
		public string param2; // 0x18
	
		// Methods
		public string GetResultString() => default; // 0x00000001824C0E70-0x00000001824C1030
		public UnSafeString GetUnsafeString() => default; // 0x00000001824BDD30-0x00000001824BDEE0
	}

	public static class ThreadUnsafeStringUtils // TypeDefIndex: 60102
	{
		// Fields
		private static ConcurrentStack<UnSafeString> s_stack; // 0x00
	
		// Constructors
		static ThreadUnsafeStringUtils() {} // 0x0000000183CF64F0-0x0000000183CF6570
	
		// Methods
		public static UnSafeString ThreadStringAlloc() => default; // 0x0000000182681220-0x0000000182681410
		public static void ThreadStringRelease(UnSafeString value) {} // 0x00000001826824F0-0x0000000182682750
	
		// Extension methods
		public static UnSafeString AppendPathInfo(this UnSafeString str, ref FVFSPathInfo info) => default; // 0x0000000182681410-0x00000001826817A0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60103
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D061A0-0x0000000183D06210
	
		// Methods
		public void __Gen_Wrap_0(ref FVFSUntrackedLowIOReadHandle P0) {} // 0x0000000189FA78E0-0x0000000189FA7A24
		public bool __Gen_Wrap_1(ref FVFSUntrackedLowIOReadHandle P0) => default; // 0x0000000189FA7A24-0x0000000189FA7B78
		public ReadStatus __Gen_Wrap_2(ref FVFSUntrackedLowIOReadHandle P0) => default; // 0x0000000189FA7B78-0x0000000189FA7CCC
		public NativeArray<byte> __Gen_Wrap_3(ref FVFSUntrackedLowIOReadHandle P0) => default; // 0x0000000189FA7CCC-0x0000000189FA7E4C
		public string __Gen_Wrap_4(ref FVFSPathInfo P0) => default; // 0x0000000189FA7E4C-0x0000000189FA7FB8
		public UnSafeString __Gen_Wrap_5(ref FVFSPathInfo P0) => default; // 0x0000000189FA7FB8-0x0000000189FA8124
		public UnSafeString __Gen_Wrap_6() => default; // 0x0000000189FA8124-0x0000000189FA81F0
		public void __Gen_Wrap_7(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public UnSafeString __Gen_Wrap_8(object P0, ref FVFSPathInfo P1) => default; // 0x0000000189FA81F0-0x0000000189FA8378
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 60104
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x0000000189FA8378-0x0000000189FA840C
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 60105
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000189FA85F4-0x0000000189FA8658
		public static bool IsPatched(int id) => default; // 0x00000001824BDEE0-0x00000001824BDF90
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x0000000189FA84B0-0x0000000189FA857C
		public object CreateWrapper(int id) => default; // 0x0000000189FA857C-0x0000000189FA85F4
		public object InitWrapperArray(int len) => default; // 0x0000000189FA8658-0x0000000189FA86E4
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000189FA840C-0x0000000189FA84B0
	}

	public enum IDMAP0 // TypeDefIndex: 60106
	{
		Beyond-VFS-FVFSUntrackedLowIOReadHandle-Dispose0 = 0,
		Beyond-VFS-FVFSUntrackedLowIOReadHandle-IsValid0 = 1,
		Beyond-VFS-FVFSUntrackedLowIOReadHandle-IsComplete0 = 2,
		Beyond-VFS-FVFSUntrackedLowIOReadHandle-GetStatus0 = 3,
		Beyond-VFS-FVFSUntrackedLowIOReadHandle-GetData0 = 4,
		Beyond-VFS-FVFSUntrackedLowIOReadHandle-GetDataThread0 = 5,
		Beyond-VFS-FVFSPathInfo-GetResultString0 = 6,
		Beyond-VFS-FVFSPathInfo-GetUnsafeString0 = 7,
		Beyond-VFS-ThreadUnsafeStringUtils-ThreadStringAlloc0 = 8,
		Beyond-VFS-ThreadUnsafeStringUtils-ThreadStringRelease0 = 9,
		Beyond-VFS-ThreadUnsafeStringUtils-AppendPathInfo0 = 10
	}
}
