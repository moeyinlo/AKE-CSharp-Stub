/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Beyond.ManifestBinary;
using IFix.Core;

// Image 153: VFSEditor.dll - Assembly: VFSEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91377-91389

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 91379
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 91380
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 91381
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 91382
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 91383
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 91384
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 91385
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Beyond.VFS.Editor
{
	public class VFSEditorUnsafeUtils // TypeDefIndex: 91386
	{
		// Constructors
		public VFSEditorUnsafeUtils(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void TryGetBundleDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles); // 0x000000018D9C06FC-0x000000018D9C072C
		public static void TryGetBundleDirectDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles); // 0x000000018D9C072C-0x000000018D9C08A4
		public static void TryGetBundleDirectReverseDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles); // 0x000000018D9C08A4-0x000000018D9C0A1C
		private static void _TryGetBundleDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles); // 0x000000018D9C0A1C-0x000000018D9C0B94
		public static string GetLogBundleName(RuntimeManifestBinary manifestBinary, ManifestDataBinary.Bundle bundle); // 0x000000018D9C0680-0x000000018D9C06FC
		public static string GetLogAssetPath(RuntimeManifestBinary manifestBinary, ManifestDataBinary.AssetInfo asset); // 0x000000018D9C0604-0x000000018D9C0680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 91378
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 91387
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018D9C0508-0x000000018D9C056C
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 91388
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018D9C056C-0x000000018D9C0604
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 91389
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018D9C0D80-0x000000018D9C0DE4
		public static bool IsPatched(int id); // 0x000000018D9C0E70-0x000000018D9C0F08
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018D9C0C38-0x000000018D9C0D04
		public object CreateWrapper(int id); // 0x000000018D9C0D04-0x000000018D9C0D80
		public object InitWrapperArray(int len); // 0x000000018D9C0DE4-0x000000018D9C0E70
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018D9C0B94-0x000000018D9C0C38
	}
}
