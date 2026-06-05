/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using IFix.Core;

// Image 150: CriMw.CriWare.Vp9.Runtime.dll - Assembly: CriMw.CriWare.Vp9.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61258-61268

namespace Beyond.SourceGenerator
{
	internal class DataNAttribute : Attribute // TypeDefIndex: 61259
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 61260
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 61261
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 61262
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 61263
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace CriWare
{
	public static class CriManaVp9 // TypeDefIndex: 61265
	{
		// Fields
		private const string scriptVersionString = "1.01.05"; // Metadata: 0x02083AC0
		public const string cri_mana_vp9_name = "cri_mana_vpx"; // Metadata: 0x02083AC8
	
		// Methods
		public static bool SupportCurrentPlatform() => default; // 0x00000001840A27C0-0x00000001840A27D0
		public static void SetupVp9Decoder() {} // 0x00000001844CF290-0x00000001844CF360
		private static extern IntPtr criWareUnity_GetAllocateFunc(); // 0x00000001844CF020-0x00000001844CF090
		private static extern IntPtr criWareUnity_GetDeallocateFunc(); // 0x00000001844CF360-0x00000001844CF390
		private static extern IntPtr criManaUnity_GetAllocatorManager(); // 0x00000001844CF130-0x00000001844CF1A0
		private static extern void criMvPly_AttachCodecInterface(int codec_type, IntPtr codec_if, IntPtr codecalpha_if); // 0x00000001844CF090-0x00000001844CF130
		private static extern void criVvp9_SetUserAllocator(IntPtr alloc_func, IntPtr free_func, IntPtr usr_obj); // 0x00000001844CEE70-0x00000001844CEF10
		private static extern IntPtr criVvp9_GetInterface(); // 0x00000001844CEBA0-0x00000001844CEC10
		private static extern IntPtr criVvp9_GetAlphaInterface(); // 0x00000001844CEF10-0x00000001844CEF80
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 61264
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 61266
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x00000001878A036C-0x00000001878A03D0
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 61267
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x00000001878A03D0-0x00000001878A0464
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 61268
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001878A064C-0x00000001878A06B0
		public static bool IsPatched(int id) => default; // 0x00000001878A073C-0x00000001878A07D4
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001878A0508-0x00000001878A05D4
		public object CreateWrapper(int id) => default; // 0x00000001878A05D4-0x00000001878A064C
		public object InitWrapperArray(int len) => default; // 0x00000001878A06B0-0x00000001878A073C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x00000001878A0464-0x00000001878A0508
	}
}
