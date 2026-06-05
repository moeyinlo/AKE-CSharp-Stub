/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using IFix.Core;
using UnityEngine;

// Image 155: HG.RenderPipelines.Logger.dll - Assembly: HG.RenderPipelines.Logger, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61297-61300

namespace HG.Rendering
{
	public static class HGRPLogger // TypeDefIndex: 61298
	{
		// Methods
		public static void LogWarning(string message) {} // 0x0000000184616F60-0x0000000184616F90
		public static void LogWarning<T>(string message, T param1) {}
		public static void LogWarning(UnityEngine.Object context, string message) {} // 0x000000018A6C19A4-0x000000018A6C19F4
		public static void LogError(string message) {} // 0x000000018A6C18AC-0x000000018A6C1928
		public static void LogError<T>(string message, T param1) {}
		public static void LogError<T1, T2>(string message, T1 param1, T2 param2) {}
		public static void LogError<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogError<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogCritical(string message) {} // 0x000000018A6C1830-0x000000018A6C18AC
		public static void LogCritical<T>(string message, T param1) {}
		public static void LogCritical<T1, T2>(string message, T1 param1, T2 param2) {}
		public static void LogException(Exception e) {} // 0x000000018A6C1928-0x000000018A6C19A4
		public static void LogImportant(string message) {} // 0x0000000184F68CE0-0x0000000184F68E50
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 61299
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F63EC0-0x0000000185F63F30
	
		// Methods
		public void __Gen_Wrap_0(object P0) {} // 0x000000018646FFC0-0x0000000186470080
		public void __Gen_Wrap_1(object P0, object P1) {} // 0x00000001873527E8-0x00000001873528C4
	}

	public class WrappersManagerImpl // TypeDefIndex: 61300
	{
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018A6C19F4-0x000000018A6C1B08
		public static bool IsPatched(int id) => default; // 0x0000000184616F90-0x0000000184617000
	}
}
