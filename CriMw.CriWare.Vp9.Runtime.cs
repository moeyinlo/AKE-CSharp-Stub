/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using IFix.Core;

// Image 152: CriMw.CriWare.Vp9.Runtime.dll - Assembly: CriMw.CriWare.Vp9.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63897-63907
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 63899
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 63900
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 63901
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 63902
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 63903
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace CriWare
{
	public static class CriManaVp9 // TypeDefIndex: 63904
	{
		// Fields
		private const string scriptVersionString = "1.01.05"; // Metadata: 0x02353740
		public const string cri_mana_vp9_name = "cri_mana_vpx"; // Metadata: 0x02353748
	
		// Methods
		public static bool SupportCurrentPlatform(); // 0x0000000182FFF600-0x0000000182FFF610
		public static void SetupVp9Decoder(); // 0x0000000183827DB0-0x0000000183827E80
		private static extern IntPtr criWareUnity_GetAllocateFunc(); // 0x0000000183827B50-0x0000000183827BC0
		private static extern IntPtr criWareUnity_GetDeallocateFunc(); // 0x0000000183827E80-0x0000000183827EB0
		private static extern IntPtr criManaUnity_GetAllocatorManager(); // 0x0000000183827C60-0x0000000183827CD0
		private static extern void criMvPly_AttachCodecInterface(int codec_type, IntPtr codec_if, IntPtr codecalpha_if); // 0x0000000183827BC0-0x0000000183827C60
		private static extern void criVvp9_SetUserAllocator(IntPtr alloc_func, IntPtr free_func, IntPtr usr_obj); // 0x00000001838279A0-0x0000000183827A40
		private static extern IntPtr criVvp9_GetInterface(); // 0x00000001838276D0-0x0000000183827740
		private static extern IntPtr criVvp9_GetAlphaInterface(); // 0x0000000183827A40-0x0000000183827AB0
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 63898
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63905
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x000000018690A4C4-0x000000018690A528
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 63906
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018690A528-0x000000018690A5BC
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 63907
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018690A7A4-0x000000018690A808
		public static bool IsPatched(int id); // 0x000000018690A894-0x000000018690A92C
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018690A660-0x000000018690A72C
		public object CreateWrapper(int id); // 0x000000018690A72C-0x000000018690A7A4
		public object InitWrapperArray(int len); // 0x000000018690A808-0x000000018690A894
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018690A5BC-0x000000018690A660
	}
}
