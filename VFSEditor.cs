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

// Image 153: VFSEditor.dll - Assembly: VFSEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63908-63918
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 63910
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 63911
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 63912
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 63913
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 63914
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Beyond.VFS.Editor
{
	public class VFSEditorUnsafeUtils // TypeDefIndex: 63915
	{
		// Constructors
		public VFSEditorUnsafeUtils(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void TryGetBundleDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles); // 0x000000018B8961FC-0x000000018B89622C
		public static void TryGetBundleDirectDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles); // 0x000000018B89622C-0x000000018B8963A0
		public static void TryGetBundleDirectReverseDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles); // 0x000000018B8963A0-0x000000018B896514
		private static void _TryGetBundleDeps(ManifestDataBinary manifestDataBinary, ManifestDataBinary.Bundle bundle, ref List<ManifestDataBinary.Bundle> bundles); // 0x000000018B896514-0x000000018B896688
		public static string GetLogBundleName(RuntimeManifestBinary manifestBinary, ManifestDataBinary.Bundle bundle); // 0x000000018B896178-0x000000018B8961FC
		public static string GetLogAssetPath(RuntimeManifestBinary manifestBinary, ManifestDataBinary.AssetInfo asset); // 0x000000018B8960F4-0x000000018B896178
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 63909
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63916
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x000000018B895FFC-0x000000018B896060
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 63917
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018B896060-0x000000018B8960F4
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 63918
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018B896870-0x000000018B8968D4
		public static bool IsPatched(int id); // 0x000000018B896960-0x000000018B8969F8
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018B89672C-0x000000018B8967F8
		public object CreateWrapper(int id); // 0x000000018B8967F8-0x000000018B896870
		public object InitWrapperArray(int len); // 0x000000018B8968D4-0x000000018B896960
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018B896688-0x000000018B89672C
	}
}
