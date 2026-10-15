/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 139: UnityEngine.HGJankMonitorModule.dll - Assembly: UnityEngine.HGJankMonitorModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91303-91305

namespace UnityEngine.HyperGryph
{
	[Flags]
	public enum HGJankBackend // TypeDefIndex: 91304
	{
		None = 0,
		Suspend = 1,
		Etw = 2
	}

	[NativeHeader("Modules/HGJankMonitor/Public/HGJankMonitorAPI.h")]
	public static class HGJankMonitor // TypeDefIndex: 91305
	{
		// Methods
		[FreeFunction("HGJankMonitor::Start")]
		private static int StartNative(uint sampleIntervalMs, uint jankThresholdMs, float stackSimilarity, int backends, string logDir, bool compress); // 0x000000018D526E3C-0x000000018D526E9C
		public static int Start(uint sampleIntervalMs, uint jankThresholdMs, float stackSimilarity, HGJankBackend backends, string logDir, bool compress = true /* Metadata: 0x0264C026 */); // 0x000000018D526E9C-0x000000018D526F24
		[FreeFunction("HGJankMonitor::Stop")]
		public static void Stop(); // 0x000000018D526F24-0x000000018D526F50
		[FreeFunction("HGJankMonitor::Pause")]
		public static void Pause(); // 0x000000018D526DE4-0x000000018D526E10
		[FreeFunction("HGJankMonitor::Resume")]
		public static void Resume(); // 0x000000018D526E10-0x000000018D526E3C
		[FreeFunction("HGJankMonitor::IsPaused")]
		public static bool IsPaused(); // 0x000000018D526BD0-0x000000018D526BFC
		[FreeFunction("HGJankMonitor::IsRunning")]
		public static bool IsRunning(); // 0x0000000185ACA500-0x0000000185ACA540
		private static extern bool OpenProcessToken(IntPtr processHandle, uint desiredAccess, out IntPtr tokenHandle); // 0x000000018D526D44-0x000000018D526DE4
		private static extern bool GetTokenInformation(IntPtr tokenHandle, int tokenInformationClass, out int tokenInformation, int tokenInformationLength, out int returnLength); // 0x000000018D526B14-0x000000018D526BD0
		private static extern IntPtr GetCurrentProcess(); // 0x000000018D526AE8-0x000000018D526B14
		private static extern bool CloseHandle(IntPtr handle); // 0x000000018D526AA0-0x000000018D526AE8
		public static bool IsProcessElevated(); // 0x000000018D526BFC-0x000000018D526D44
	}
}
