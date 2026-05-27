/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using IFix.Core;

// Image 151: IFix.Define.dll - Assembly: IFix.Define, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60203-60210
[assembly: AssemblyCompany("Mono development team")]
[assembly: AssemblyCopyright("(c) Various Mono authors")]
[assembly: AssemblyDefaultAlias("System.Runtime.Serialization.dll")]
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyDescription("System.Runtime.Serialization.dll")]
[assembly: AssemblyFileVersion("4.0.30319.17020")]
[assembly: AssemblyInformationalVersion("4.0.30319.17020")]
[assembly: AssemblyKeyFile("../silverlight.pub")]
[assembly: AssemblyProduct("Mono Common Language Infrastructure")]
[assembly: AssemblyTitle("System.Runtime.Serialization.dll")]
[assembly: CLSCompliant(true)]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SatelliteContractVersion("4.0.0.0")]

namespace Beyond.HotFix
{
	[Serializable]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
	public class PatchClipboardData // TypeDefIndex: 60204
	{
		// Fields
		public int ver; // 0x10
		public int overrideVFSIFixVersionFrom; // 0x14
		public int overrideVFSIFixVersionTo; // 0x18
		public string platform; // 0x20
		public List<PatchItem> patches; // 0x28
		public List<PatchItem> luaPatches; // 0x30
	
		// Constructors
		public PatchClipboardData() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public class PatchItem // TypeDefIndex: 60205
	{
		// Fields
		public string name; // 0x10
		public string md5; // 0x18
		public int size; // 0x20
		public string data; // 0x28
	
		// Constructors
		public PatchItem() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public static class HotFixPatchDefine // TypeDefIndex: 60206
	{
		// Fields
		public static readonly string hotFixPatchFileExtension; // 0x00
		public static readonly string CLIENT_NET_RSA_PUBLIC_KEY; // 0x08
	
		// Constructors
		static HotFixPatchDefine() {} // 0x0000000188899FE4-0x000000018889A07C
	
		// Methods
		public static bool VerifyMD5(byte[] bytes, string expectMd5) => default; // 0x0000000188899E04-0x0000000188899FE4
	}
}

namespace IFix
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60207
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x000000018889A07C-0x000000018889A0E0
	
		// Methods
		public bool __Gen_Wrap_0(object P0, object P1) => default; // 0x0000000185153920-0x0000000185153A0C
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 60208
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018889A0E0-0x000000018889A174
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 60209
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018889A35C-0x000000018889A3C0
		public static bool IsPatched(int id) => default; // 0x000000018889A44C-0x000000018889A4E4
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018889A218-0x000000018889A2E4
		public object CreateWrapper(int id) => default; // 0x000000018889A2E4-0x000000018889A35C
		public object InitWrapperArray(int len) => default; // 0x000000018889A3C0-0x000000018889A44C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018889A174-0x000000018889A218
	}

	public enum IDMAP0 // TypeDefIndex: 60210
	{
		Beyond-HotFix-HotFixPatchDefine-VerifyMD50 = 0
	}
}
