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

// Image 149: VFSEditor.dll - Assembly: VFSEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60184-60194
[assembly: CompilationRelaxations(8)]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.SourceGenerator
{
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 60187
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 60188
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class DataNAttribute : Attribute // TypeDefIndex: 60189
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		[Extension]
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 60190
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace Beyond.VFS.Editor
{
	public class VFSEditorUnsafeUtils // TypeDefIndex: 60191
	{
		// Constructors
		public VFSEditorUnsafeUtils() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void TryGetBundleDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles) {} // 0x000000018A2927B0-0x000000018A2927E0
		public static void TryGetBundleDirectDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles) {} // 0x000000018A2927E0-0x000000018A292954
		public static void TryGetBundleDirectReverseDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles) {} // 0x000000018A292954-0x000000018A292AC8
		private static void _TryGetBundleDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles) {} // 0x000000018A292AC8-0x000000018A292C3C
		public static string GetLogBundleName(RuntimeManifestBinary manifestBinary, ManifestDataBinary.Bundle bundle) => default; // 0x000000018A292734-0x000000018A2927B0
		public static string GetLogAssetPath(RuntimeManifestBinary manifestBinary, ManifestDataBinary.AssetInfo asset) => default; // 0x000000018A2926B8-0x000000018A292734
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60192
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x000000018A2925C0-0x000000018A292624
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 60193
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018A292624-0x000000018A2926B8
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 60194
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018A292E24-0x000000018A292E88
		public static bool IsPatched(int id) => default; // 0x000000018A292F14-0x000000018A292FAC
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018A292CE0-0x000000018A292DAC
		public object CreateWrapper(int id) => default; // 0x000000018A292DAC-0x000000018A292E24
		public object InitWrapperArray(int len) => default; // 0x000000018A292E88-0x000000018A292F14
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018A292C3C-0x000000018A292CE0
	}
}
