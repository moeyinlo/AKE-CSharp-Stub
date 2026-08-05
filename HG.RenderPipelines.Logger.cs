/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 157: HG.RenderPipelines.Logger.dll - Assembly: HG.RenderPipelines.Logger, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63936-63939
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace HG.Rendering
{
	public static class HGRPLogger // TypeDefIndex: 63937
	{
		// Methods
		[IDTag(0)]
		public static void LogWarning(string message); // 0x000000018383B0E0-0x000000018383B110
		public static void LogWarning<T>(string message, T param1);
		[IDTag(1)]
		public static void LogWarning(UnityEngine.Object context, string message); // 0x0000000189B2549C-0x0000000189B254EC
		[IDTag(0)]
		public static void LogError(string message); // 0x0000000189B253A4-0x0000000189B25420
		public static void LogError<T>(string message, T param1);
		public static void LogError<T1, T2>(string message, T1 param1, T2 param2);
		public static void LogError<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3);
		public static void LogError<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[IDTag(0)]
		public static void LogCritical(string message); // 0x0000000189B25328-0x0000000189B253A4
		public static void LogCritical<T>(string message, T param1);
		public static void LogCritical<T1, T2>(string message, T1 param1, T2 param2);
		[IDTag(0)]
		public static void LogException(Exception e); // 0x0000000189B25420-0x0000000189B2549C
		[IDTag(0)]
		public static void LogImportant(string message); // 0x000000018332D200-0x000000018332D270
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63938
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		static ILFixDynamicMethodWrapper(); // 0x0000000184D36F40-0x0000000184D36FB0
	
		// Methods
		public void __Gen_Wrap_0(object P0); // 0x00000001863633B4-0x0000000186363474
		public void __Gen_Wrap_1(object P0, object P1); // 0x0000000186377B18-0x0000000186377BF4
	}

	public class WrappersManagerImpl // TypeDefIndex: 63939
	{
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000189B254EC-0x0000000189B25550
		public static bool IsPatched(int id); // 0x000000018383B110-0x000000018383B160
	}
}
