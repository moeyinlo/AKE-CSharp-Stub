/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using IFix.Core;
using Unity.Collections;

// Image 152: Beyond.Native.dll - Assembly: Beyond.Native, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61280-61287

namespace Beyond.Native
{
	public static class NativeHelper // TypeDefIndex: 61283
	{
		// Methods
		public static Span<T> CreateSpan<T>(NativeArray<T> arr)
			where T : struct => default;
		public static string ToStringUTF8(NativeArray<byte> arr) => default; // 0x000000018735AFC4-0x000000018735B088
		public static ref ref T GetElementRef<T>(NativeArray<T> array, int idx)
			where T : struct => ref _refReturnTypeForGetElementRef;
		private ref T _refReturnTypeForGetElementRef; // Dummy field
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 61284
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x000000018735AECC-0x000000018735AF30
	
		// Methods
		public string __Gen_Wrap_0(NativeArray<byte> P0) => default; // 0x000000018735ADCC-0x000000018735AECC
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 61285
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018735AF30-0x000000018735AFC4
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 61286
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018735B270-0x000000018735B2D4
		public static bool IsPatched(int id) => default; // 0x000000018735B360-0x000000018735B3F8
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018735B12C-0x000000018735B1F8
		public object CreateWrapper(int id) => default; // 0x000000018735B1F8-0x000000018735B270
		public object InitWrapperArray(int len) => default; // 0x000000018735B2D4-0x000000018735B360
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018735B088-0x000000018735B12C
	}

	public enum IDMAP0 // TypeDefIndex: 61287
	{
		Beyond-Native-NativeHelper-ToStringUTF80 = 0
	}
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 61281
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 61282
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}
