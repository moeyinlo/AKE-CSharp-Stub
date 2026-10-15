/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using Microsoft.CodeAnalysis;
using Unity.Collections;

// Image 154: Beyond.Native.dll - Assembly: Beyond.Native, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91390-91398

namespace Beyond.Native
{
	public static class NativeHelper // TypeDefIndex: 91393
	{
		// Methods
		public static Span<T> CreateSpan<T>(NativeArray<T> arr)
			where T : struct;
		public static string ToStringUTF8(NativeArray<byte> arr); // 0x00000001888026A4-0x0000000188802774
	
		// Extension methods
		public static ref ref T GetElementRef<T>(this NativeArray<T> array, int idx)
			where T : struct;
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 91394
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x00000001888025A8-0x000000018880260C
	
		// Methods
		public string __Gen_Wrap_0(NativeArray<byte> P0); // 0x00000001888024A0-0x00000001888025A8
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 91395
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018880260C-0x00000001888026A4
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 91396
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000188802960-0x00000001888029C4
		public static bool IsPatched(int id); // 0x0000000188802A50-0x0000000188802AE8
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x0000000188802818-0x00000001888028E4
		public object CreateWrapper(int id); // 0x00000001888028E4-0x0000000188802960
		public object InitWrapperArray(int len); // 0x00000001888029C4-0x0000000188802A50
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x0000000188802774-0x0000000188802818
	}

	public delegate string __HotPatchDelegate_0(NativeArray<byte> P0); // TypeDefIndex: 91397; 0x0000000186A4F2D0-0x0000000186A4F300

	public enum HotPatchIDMAP0 // TypeDefIndex: 91398
	{
		Beyond-Native-NativeHelper-ToStringUTF80 = 0
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 91391
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 91392
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
