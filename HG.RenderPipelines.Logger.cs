/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;

// Image 154: HG.RenderPipelines.Logger.dll - Assembly: HG.RenderPipelines.Logger, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60220-60223
[assembly: AssemblyCompany("Mono development team")]
[assembly: AssemblyCopyright("(c) Various Mono authors")]
[assembly: AssemblyDefaultAlias("System.Configuration.dll")]
[assembly: AssemblyDescription("System.Configuration.dll")]
[assembly: AssemblyFileVersion("4.8.3761.0")]
[assembly: AssemblyInformationalVersion("4.8.3761.0")]
[assembly: AssemblyProduct("Mono Common Language Infrastructure")]
[assembly: AssemblyTitle("System.Configuration.dll")]
[assembly: CLSCompliant(true)]
[assembly: ComCompatibleVersion(1, 0, 3300, 0)]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: DefaultDllImportSearchPaths(DllImportSearchPath.System32 | DllImportSearchPath.AssemblyDirectory | DllImportSearchPath.LegacyBehavior)]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SatelliteContractVersion("4.0.0.0")]

namespace HG.Rendering
{
	[DefaultMember("Item")]
	public static class HGRPLogger // TypeDefIndex: 60221
	{
		// Methods
		public static void LogWarning(string message) {} // 0x00000001828F6E20-0x00000001828F6E50
		public static void LogWarning<T>(string message, T param1) {}
		public static void LogWarning(UnityEngine.Object context, string message) {} // 0x0000000188597F98-0x0000000188597FE8
		public static void LogError(string message) {} // 0x0000000188597EA0-0x0000000188597F1C
		public static void LogError<T>(string message, T param1) {}
		public static void LogError<T1, T2>(string message, T1 param1, T2 param2) {}
		public static void LogError<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogError<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogCritical(string message) {} // 0x0000000188597E24-0x0000000188597EA0
		public static void LogCritical<T>(string message, T param1) {}
		public static void LogCritical<T1, T2>(string message, T1 param1, T2 param2) {}
		public static void LogException(Exception e) {} // 0x0000000188597F1C-0x0000000188597F98
		public static void LogImportant(string message) {} // 0x00000001828F6640-0x00000001828F66B0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60222
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D055D0-0x0000000183D05640
	
		// Methods
		public void __Gen_Wrap_0(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public void __Gen_Wrap_1(object P0, object P1) {} // 0x0000000185163BA0-0x0000000185163C7C
	}

	public class WrappersManagerImpl // TypeDefIndex: 60223
	{
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000188597FE8-0x00000001885980FC
		public static bool IsPatched(int id) => default; // 0x00000001828F6E50-0x00000001828F6EC0
	}
}
