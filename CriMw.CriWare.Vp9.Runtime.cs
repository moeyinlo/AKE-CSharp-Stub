/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using IFix.Core;

// Image 155: CriMw.CriWare.Vp9.Runtime.dll - Assembly: CriMw.CriWare.Vp9.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91399-91411

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 91401
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 91402
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 91403
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 91404
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 91405
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 91406
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 91407
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace CriWare
{
	public static class CriManaVp9 // TypeDefIndex: 91408
	{
		// Fields
		private const string scriptVersionString = "1.01.05"; // Metadata: 0x0264C0CB
		public const string cri_mana_vp9_name = "cri_mana_vpx"; // Metadata: 0x0264C0D3
	
		// Methods
		public static bool SupportCurrentPlatform(); // 0x00000001851A4410-0x00000001851A4420
		public static void SetupVp9Decoder(); // 0x0000000185AFDFD0-0x0000000185AFE0A0
		private static extern IntPtr criWareUnity_GetAllocateFunc(); // 0x0000000185AFDA80-0x0000000185AFDAF0
		private static extern IntPtr criWareUnity_GetDeallocateFunc(); // 0x0000000185AFE0A0-0x0000000185AFE0D0
		private static extern IntPtr criManaUnity_GetAllocatorManager(); // 0x0000000185AFDB90-0x0000000185AFDC00
		private static extern void criMvPly_AttachCodecInterface(int codec_type, IntPtr codec_if, IntPtr codecalpha_if); // 0x0000000185AFDAF0-0x0000000185AFDB90
		private static extern void criVvp9_SetUserAllocator(IntPtr alloc_func, IntPtr free_func, IntPtr usr_obj); // 0x0000000185AFD640-0x0000000185AFD6E0
		private static extern IntPtr criVvp9_GetInterface(); // 0x0000000185AFD3F0-0x0000000185AFD460
		private static extern IntPtr criVvp9_GetAlphaInterface(); // 0x0000000185AFD6E0-0x0000000185AFD750
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 91400
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 91409
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x0000000188C292E4-0x0000000188C29348
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 91410
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x0000000188C29348-0x0000000188C293E0
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 91411
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000188C295CC-0x0000000188C29630
		public static bool IsPatched(int id); // 0x0000000188C296BC-0x0000000188C29754
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x0000000188C29484-0x0000000188C29550
		public object CreateWrapper(int id); // 0x0000000188C29550-0x0000000188C295CC
		public object InitWrapperArray(int len); // 0x0000000188C29630-0x0000000188C296BC
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x0000000188C293E0-0x0000000188C29484
	}
}
