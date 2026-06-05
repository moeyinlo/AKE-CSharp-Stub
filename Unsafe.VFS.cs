/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Concurrent;
using Beyond;
using Beyond.VFS;
using IFix.Core;
using Unity.Collections;
using Unity.IO.LowLevel.Unsafe;

// Image 141: Unsafe.VFS.dll - Assembly: Unsafe.VFS, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61208-61215

namespace Beyond.VFS
{
	public struct FVFSUntrackedLowIOReadHandle : IDisposable // TypeDefIndex: 61209
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
		} // 0x0000000184AD0EA0-0x0000000184AD1060
		public unsafe FVFSUntrackedLowIOReadHandle(UnSafeString path, long offset, long len, bool async, bool isEnc) {
			readCommand = default;
			readHandle = default;
			this.isEnc = default;
		} // 0x000000018C0BF860-0x000000018C0BF9B0
	
		// Methods
		public void Dispose() {} // 0x00000001847C5710-0x00000001847C57E0
		public bool IsValid() => default; // 0x0000000184AD1270-0x0000000184AD1360
		public bool IsComplete() => default; // 0x0000000184ACFF30-0x0000000184ACFF70
		public ReadStatus GetStatus() => default; // 0x00000001847C5C20-0x00000001847C5C60
		public NativeArray<byte> GetData() => default; // 0x000000018457B030-0x000000018457B0D0
		public NativeArray<byte> GetDataThread() => default; // 0x000000018457C780-0x000000018457C820
	}

	public struct FVFSPathInfo // TypeDefIndex: 61210
	{
		// Fields
		public string fullPathFormat; // 0x00
		public string param0; // 0x08
		public string param1; // 0x10
		public string param2; // 0x18
	
		// Methods
		public string GetResultString() => default; // 0x0000000184186010-0x00000001841861D0
		public UnSafeString GetUnsafeString() => default; // 0x0000000184256F50-0x0000000184257100
	}

	public static class ThreadUnsafeStringUtils // TypeDefIndex: 61211
	{
		// Fields
		private static ConcurrentStack<UnSafeString> s_stack; // 0x00
	
		// Constructors
		static ThreadUnsafeStringUtils() {} // 0x0000000185F527A0-0x0000000185F52820
	
		// Methods
		public static UnSafeString ThreadStringAlloc() => default; // 0x0000000184258750-0x0000000184258940
		public static void ThreadStringRelease(UnSafeString value) {} // 0x000000018425B050-0x000000018425B2B0
		public static UnSafeString AppendPathInfo(UnSafeString str, ref FVFSPathInfo info) => default; // 0x0000000184258940-0x0000000184259DC0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 61212
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F64A90-0x0000000185F64B00
	
		// Methods
		public void __Gen_Wrap_0(ref FVFSUntrackedLowIOReadHandle P0) {} // 0x000000018C0BF9B0-0x000000018C0BFAF4
		public bool __Gen_Wrap_1(ref FVFSUntrackedLowIOReadHandle P0) => default; // 0x000000018C0BFAF4-0x000000018C0BFC48
		public ReadStatus __Gen_Wrap_2(ref FVFSUntrackedLowIOReadHandle P0) => default; // 0x000000018C0BFC48-0x000000018C0BFD9C
		public NativeArray<byte> __Gen_Wrap_3(ref FVFSUntrackedLowIOReadHandle P0) => default; // 0x000000018C0BFD9C-0x000000018C0BFF1C
		public string __Gen_Wrap_4(ref FVFSPathInfo P0) => default; // 0x000000018C0BFF1C-0x000000018C0C0088
		public UnSafeString __Gen_Wrap_5(ref FVFSPathInfo P0) => default; // 0x000000018C0C0088-0x000000018C0C01F4
		public UnSafeString __Gen_Wrap_6() => default; // 0x000000018C0C01F4-0x000000018C0C02C0
		public void __Gen_Wrap_7(object P0) {} // 0x000000018646FFC0-0x0000000186470080
		public UnSafeString __Gen_Wrap_8(object P0, ref FVFSPathInfo P1) => default; // 0x000000018C0C02C0-0x000000018C0C0448
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 61213
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018C0C0448-0x000000018C0C04DC
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 61214
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018C0C06C4-0x000000018C0C0728
		public static bool IsPatched(int id) => default; // 0x0000000184257100-0x00000001842571B0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018C0C0580-0x000000018C0C064C
		public object CreateWrapper(int id) => default; // 0x000000018C0C064C-0x000000018C0C06C4
		public object InitWrapperArray(int len) => default; // 0x000000018C0C0728-0x000000018C0C07B4
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018C0C04DC-0x000000018C0C0580
	}

	public enum IDMAP0 // TypeDefIndex: 61215
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
