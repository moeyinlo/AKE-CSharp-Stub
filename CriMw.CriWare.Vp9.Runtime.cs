/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using IFix.Core;

// Image 148: CriMw.CriWare.Vp9.Runtime.dll - Assembly: CriMw.CriWare.Vp9.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60173-60183
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 60175
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 60176
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 60177
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 60178
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 60179
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace CriWare
{
	public static class CriManaVp9 // TypeDefIndex: 60180
	{
		// Fields
		private const string scriptVersionString = "1.01.05"; // Metadata: 0x01FDE1BB
		public const string cri_mana_vp9_name = "cri_mana_vpx"; // Metadata: 0x01FDE1C3
	
		// Methods
		public static bool SupportCurrentPlatform() => default; // 0x000000018232EB60-0x000000018232EB70
		public static void SetupVp9Decoder() {} // 0x00000001822C8530-0x00000001822C8600
		private static extern IntPtr criWareUnity_GetAllocateFunc(); // 0x00000001822C82F0-0x00000001822C8360
		private static extern IntPtr criWareUnity_GetDeallocateFunc(); // 0x00000001822C8600-0x00000001822C8630
		private static extern IntPtr criManaUnity_GetAllocatorManager(); // 0x00000001822C8400-0x00000001822C8470
		private static extern void criMvPly_AttachCodecInterface(int codec_type, IntPtr codec_if, IntPtr codecalpha_if); // 0x00000001822C8360-0x00000001822C8400
		private static extern void criVvp9_SetUserAllocator(IntPtr alloc_func, IntPtr free_func, IntPtr usr_obj); // 0x00000001822C8140-0x00000001822C81E0
		private static extern IntPtr criVvp9_GetInterface(); // 0x00000001822C7E70-0x00000001822C7EE0
		private static extern IntPtr criVvp9_GetAlphaInterface(); // 0x00000001822C81E0-0x00000001822C8250
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 60174
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60181
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x00000001856ED8D0-0x00000001856ED934
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 60182
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x00000001856ED934-0x00000001856ED9C8
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 60183
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001856EDBB0-0x00000001856EDC14
		public static bool IsPatched(int id) => default; // 0x00000001856EDCA0-0x00000001856EDD38
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001856EDA6C-0x00000001856EDB38
		public object CreateWrapper(int id) => default; // 0x00000001856EDB38-0x00000001856EDBB0
		public object InitWrapperArray(int len) => default; // 0x00000001856EDC14-0x00000001856EDCA0
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x00000001856ED9C8-0x00000001856EDA6C
	}
}
