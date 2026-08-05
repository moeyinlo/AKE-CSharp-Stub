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

// Image 143: Unsafe.VFS.dll - Assembly: Unsafe.VFS, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63847-63854
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.VFS
{
	public struct FVFSUntrackedLowIOReadHandle : IDisposable // TypeDefIndex: 63848
	{
		// Fields
		public unsafe ReadCommand* readCommand; // 0x00
		public ReadHandle readHandle; // 0x08
		public bool isEnc; // 0x18
	
		// Constructors
		public unsafe FVFSUntrackedLowIOReadHandle(string path, long offset, long len, bool async, bool isEnc); // 0x0000000183352250-0x00000001833523E0
		public unsafe FVFSUntrackedLowIOReadHandle(UnSafeString path, long offset, long len, bool async, bool isEnc); // 0x000000018B5AB7EC-0x000000018B5AB93C
	
		// Methods
		public void Dispose(); // 0x00000001833529E0-0x0000000183352AB0
		public bool IsValid(); // 0x00000001833521D0-0x0000000183352250
		public bool IsComplete(); // 0x0000000183350090-0x00000001833500D0
		public ReadStatus GetStatus(); // 0x0000000183352DE0-0x0000000183352E20
		public NativeArray<byte> GetData(); // 0x0000000183585A20-0x0000000183585AC0
		public NativeArray<byte> GetDataThread(); // 0x0000000183352870-0x00000001833528F0
	}

	public struct FVFSPathInfo // TypeDefIndex: 63849
	{
		// Fields
		public string fullPathFormat; // 0x00
		public string param0; // 0x08
		public string param1; // 0x10
		public string param2; // 0x18
	
		// Methods
		public string GetResultString(); // 0x0000000182F766E0-0x0000000182F76830
		public UnSafeString GetUnsafeString(); // 0x0000000182F732A0-0x0000000182F733D0
	}

	public static class ThreadUnsafeStringUtils // TypeDefIndex: 63850
	{
		// Fields
		private static ConcurrentStack<UnSafeString> s_stack; // 0x00
	
		// Constructors
		static ThreadUnsafeStringUtils(); // 0x0000000184D26E80-0x0000000184D26F00
	
		// Methods
		public static UnSafeString ThreadStringAlloc(); // 0x0000000182F24C50-0x0000000182F24DF0
		public static void ThreadStringRelease(UnSafeString value); // 0x0000000182F23CC0-0x0000000182F24140
	
		// Extension methods
		public static UnSafeString AppendPathInfo(this UnSafeString str, ref FVFSPathInfo info); // 0x0000000182F24DF0-0x0000000182F25640
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63851
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37B10-0x0000000184D37B80
	
		// Methods
		public void __Gen_Wrap_0(ref FVFSUntrackedLowIOReadHandle P0); // 0x000000018B5AB93C-0x000000018B5ABA7C
		public bool __Gen_Wrap_1(ref FVFSUntrackedLowIOReadHandle P0); // 0x000000018B5ABA7C-0x000000018B5ABBCC
		public ReadStatus __Gen_Wrap_2(ref FVFSUntrackedLowIOReadHandle P0); // 0x000000018B5ABBCC-0x000000018B5ABD1C
		public NativeArray<byte> __Gen_Wrap_3(ref FVFSUntrackedLowIOReadHandle P0); // 0x000000018B5ABD1C-0x000000018B5ABE98
		public string __Gen_Wrap_4(ref FVFSPathInfo P0); // 0x000000018B5ABE98-0x000000018B5AC000
		public UnSafeString __Gen_Wrap_5(ref FVFSPathInfo P0); // 0x000000018B5AC000-0x000000018B5AC168
		public UnSafeString __Gen_Wrap_6(); // 0x000000018B5AC168-0x000000018B5AC234
		public void __Gen_Wrap_7(object P0); // 0x00000001863633B4-0x0000000186363474
		public UnSafeString __Gen_Wrap_8(object P0, ref FVFSPathInfo P1); // 0x000000018B5AC234-0x000000018B5AC3B8
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 63852
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018B5AC3B8-0x000000018B5AC44C
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 63853
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018B5AC634-0x000000018B5AC698
		public static bool IsPatched(int id); // 0x0000000182F733D0-0x0000000182F73460
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018B5AC4F0-0x000000018B5AC5BC
		public object CreateWrapper(int id); // 0x000000018B5AC5BC-0x000000018B5AC634
		public object InitWrapperArray(int len); // 0x000000018B5AC698-0x000000018B5AC724
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018B5AC44C-0x000000018B5AC4F0
	}

	public enum IDMAP0 // TypeDefIndex: 63854
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
