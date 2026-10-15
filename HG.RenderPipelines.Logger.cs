/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 158: HG.RenderPipelines.Logger.dll - Assembly: HG.RenderPipelines.Logger, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91421-91422

namespace HG.Rendering
{
	public static class HGRPLogger // TypeDefIndex: 91422
	{
		// Methods
		[IDTag(0)]
		public static void LogWarning(string message); // 0x0000000186191AB0-0x0000000186191AE0
		public static void LogWarning<T>(string message, T param1);
		[IDTag(1)]
		public static void LogWarning(UnityEngine.Object context, string message); // 0x000000018BF8C088-0x000000018BF8C0C8
		[IDTag(0)]
		public static void LogError(string message); // 0x000000018BF8BF88-0x000000018BF8C008
		public static void LogError<T>(string message, T param1);
		public static void LogError<T1, T2>(string message, T1 param1, T2 param2);
		public static void LogError<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3);
		public static void LogError<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[IDTag(0)]
		public static void LogCritical(string message); // 0x000000018BF8BF08-0x000000018BF8BF88
		public static void LogCritical<T>(string message, T param1);
		public static void LogCritical<T1, T2>(string message, T1 param1, T2 param2);
		[IDTag(0)]
		public static void LogException(Exception e); // 0x000000018BF8C008-0x000000018BF8C088
		[IDTag(0)]
		public static void LogImportant(string message); // 0x0000000185DBCAB0-0x0000000185DBCC30
	}
}
