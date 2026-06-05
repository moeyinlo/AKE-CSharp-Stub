/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Beyond.ManifestBinary;
using IFix.Core;

// Image 151: VFSEditor.dll - Assembly: VFSEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61269-61279

namespace Beyond.SourceGenerator
{
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 61271
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class DataNAttribute : Attribute // TypeDefIndex: 61272
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 61273
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 61274
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 61275
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Beyond.VFS.Editor
{
	public class VFSEditorUnsafeUtils // TypeDefIndex: 61276
	{
		// Constructors
		public VFSEditorUnsafeUtils() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void TryGetBundleDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles) {} // 0x000000018C3AA884-0x000000018C3AA8B4
		public static void TryGetBundleDirectDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles) {} // 0x000000018C3AA8B4-0x000000018C3AAA28
		public static void TryGetBundleDirectReverseDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles) {} // 0x000000018C3AAA28-0x000000018C3AAB9C
		private static void _TryGetBundleDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles) {} // 0x000000018C3AAB9C-0x000000018C3AAD10
		public static string GetLogBundleName(RuntimeManifestBinary manifestBinary, ManifestDataBinary.Bundle bundle) => default; // 0x000000018C3AA808-0x000000018C3AA884
		public static string GetLogAssetPath(RuntimeManifestBinary manifestBinary, ManifestDataBinary.AssetInfo asset) => default; // 0x000000018C3AA78C-0x000000018C3AA808
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 61270
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 61277
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x000000018C3AA694-0x000000018C3AA6F8
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 61278
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018C3AA6F8-0x000000018C3AA78C
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 61279
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018C3AAEF8-0x000000018C3AAF5C
		public static bool IsPatched(int id) => default; // 0x000000018C3AAFE8-0x000000018C3AB080
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018C3AADB4-0x000000018C3AAE80
		public object CreateWrapper(int id) => default; // 0x000000018C3AAE80-0x000000018C3AAEF8
		public object InitWrapperArray(int len) => default; // 0x000000018C3AAF5C-0x000000018C3AAFE8
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018C3AAD10-0x000000018C3AADB4
	}
}
