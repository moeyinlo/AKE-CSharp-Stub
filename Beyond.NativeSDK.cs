/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Scripting;

// Image 119: Beyond.NativeSDK.dll - Assembly: Beyond.NativeSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59945-59960
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.NativeSDK
{
	public static class NativeUtil // TypeDefIndex: 59948
	{
		// Fields
		private static int s_procId; // 0x00
		public static ValueTuple<long, long> s_DedicatedGpuMem; // 0x08
		public static ValueTuple<long, long> s_SharedMemoryGpuMem; // 0x18
		public static ValueTuple<long, long> s_CommittedMemoryGpuMem; // 0x28
		public static string s_gpuMemQuery; // 0x38
		public static int s_frequencyCalcTimes; // 0x40
		private static long _calcResult; // 0x48
		private static readonly Stopwatch SW; // 0x50
	
		// Nested types
		private struct PROCESS_MEMORY_COUNTERS // TypeDefIndex: 59946
		{
			// Fields
			public uint cb; // 0x00
			public uint PageFaultCount; // 0x04
			public ulong PeakWorkingSetSize; // 0x08
			public ulong WorkingSetSize; // 0x10
			public ulong QuotaPeakPagedPoolUsage; // 0x18
			public ulong QuotaPagedPoolUsage; // 0x20
			public ulong QuotaPeakNonPagedPoolUsage; // 0x28
			public ulong QuotaNonPagedPoolUsage; // 0x30
			public ulong PagefileUsage; // 0x38
			public ulong PeakPagefileUsage; // 0x40
		}
	
		private struct PDH_FMT_COUNTERVALUE // TypeDefIndex: 59947
		{
			// Fields
			public int CStatus; // 0x00
			public long largeValue; // 0x08
		}
	
		// Constructors
		static NativeUtil() {} // 0x0000000183B5B510-0x0000000183B5B630
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void _Clear() {} // 0x0000000183D4C360-0x0000000183D4C380
		public static bool IsPromotionSupport() => default; // 0x000000018516CD3C-0x000000018516CD78
		public static long GetAvailableMemory() => default; // 0x000000018516CAF0-0x000000018516CB30
		public static long GetOOMMemory() => default; // 0x0000000183D44F80-0x0000000183D44FB0
		private static extern bool GetProcessMemoryInfo(IntPtr hProcess, out PROCESS_MEMORY_COUNTERS counters, uint size); // 0x0000000182C9C1F0-0x0000000182C9C260
		private static extern int PdhOpenQueryA(IntPtr szDataSource, IntPtr dwUserData, out IntPtr phQuery); // 0x000000018516CF7C-0x000000018516D010
		private static extern int PdhAddEnglishCounterA(IntPtr hQuery, string szFullCounterPath, UIntPtr dwUserData, out IntPtr phCounter); // 0x000000018516CD78-0x000000018516CE30
		private static extern int PdhCollectQueryData(IntPtr hQuery); // 0x000000018516CE68-0x000000018516CEDC
		private static unsafe extern int PdhGetFormattedCounterValue(IntPtr hQuery, int dwFormat, int* lpdwType, out PDH_FMT_COUNTERVALUE pValue); // 0x000000018516CEDC-0x000000018516CF7C
		private static extern int PdhCloseQuery(IntPtr hQuery); // 0x000000018516CE30-0x000000018516CE68
		public static int GetProcId() => default; // 0x000000018516CBAC-0x000000018516CD00
		public static long getRSSMemoryByte() => default; // 0x000000018516D04C-0x000000018516D394
		public static long GetTotalMemory() => default; // 0x0000000182C9A780-0x0000000182C9ADF0
		public static long GetVirtualMemory() => default; // 0x000000018516CD00-0x000000018516CD3C
		public static long GetGpuMemory() => default; // 0x0000000182C9A0E0-0x0000000182C9A1F0
		public static float GetCpuTemperature() => default; // 0x0000000182C9A3A0-0x0000000182C9A3C0
		public static float GetGpuTemperature() => default; // 0x0000000182C9A3C0-0x0000000182C9A3E0
		public static long GetCpuFrequency() => default; // 0x000000018516CB70-0x000000018516CBAC
		public static float GetBatteryLevel() => default; // 0x000000018516CB30-0x000000018516CB70
		public static bool IsLapTop() => default; // 0x0000000183CF0140-0x0000000183CF0170
		public static bool IsCharge() => default; // 0x0000000182C9A090-0x0000000182C9A0C0
		public static int GetThermalState() => default; // 0x0000000182C9A0C0-0x0000000182C9A0E0
		public static bool IsInSsd() => default; // 0x0000000183D47680-0x0000000183D476B0
		public static bool HasSsd() => default; // 0x0000000183D476B0-0x0000000183D476E0
		public static double GetFrequencyCalculateTime() => default; // 0x0000000182C9A560-0x0000000182C9A710
		private static long RunCpuFrequencyCalculate(int times) => default; // 0x000000018516D010-0x000000018516D04C
	}

	[UnityEngine.Scripting.Preserve]
	public static class NativeWindowsDiskChecker // TypeDefIndex: 59952
	{
		// Fields
		private const uint STORAGEDEVICESEEKPENALTYPROPERTY = 7; // Metadata: 0x01FDD52F
		private const uint PROPERTYSTANDARDQUERY = 0; // Metadata: 0x01FDD530
		private const int MAX_PATH = 1024; // Metadata: 0x01FDD531
		private const uint FILE_SHARE_READ = 1; // Metadata: 0x01FDD533
		private const uint FILE_SHARE_WRITE = 2; // Metadata: 0x01FDD534
		private const uint FILE_SHARE_DELETE = 4; // Metadata: 0x01FDD535
		private const uint OPEN_EXISTING = 3; // Metadata: 0x01FDD536
		private const uint FILE_FLAG_BACKUP_SEMANTICS = 33554432; // Metadata: 0x01FDD537
		private const uint IOCTL_STORAGE_QUERY_PROPERTY = 2954240; // Metadata: 0x01FDD53B
		private static object initOnceIsRunningInSSD; // 0x00
		private static object initOnceStandaloneWinHaveSSd; // 0x08
	
		// Nested types
		private struct STORAGE_PROPERTY_QUERY // TypeDefIndex: 59949
		{
			// Fields
			public uint PropertyId; // 0x00
			public uint QueryType; // 0x04
			public byte AdditionalParameters; // 0x08
		}
	
		private struct DEVICE_SEEK_PENALTY_DESCRIPTOR // TypeDefIndex: 59950
		{
			// Fields
			public uint Version; // 0x00
			public uint Size; // 0x04
			public bool IncursSeekPenalty; // 0x08
		}
	
		// Methods
		private static extern bool GetVolumePathName(string lpszFileName, IntPtr lpszVolumePathName, uint cchBufferLength); // 0x0000000182C999B0-0x0000000182C99A30
		private static extern bool GetVolumeNameForVolumeMountPoint(string lpszVolumeMountPoint, IntPtr lpszVolumeName, uint cchBufferLength); // 0x0000000182C99A30-0x0000000182C99AB0
		private static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile); // 0x0000000182C99FF0-0x0000000182C9A090
		private static extern bool CloseHandle(IntPtr hObject); // 0x0000000182C99850-0x0000000182C99900
		public static extern int GetLogicalDriveStrings(uint nBufferLength, char[] lpBuffer); // 0x00000001822C6A80-0x00000001822C6B30
		private static extern bool DeviceIoControl(IntPtr hDevice, uint dwIoControlCode, ref STORAGE_PROPERTY_QUERY lpInBuffer, uint nInBufferSize, ref DEVICE_SEEK_PENALTY_DESCRIPTOR lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped); // 0x0000000182C99900-0x0000000182C999B0
		private static IntPtr GetVolumeHandleForFile(string filePath) => default; // 0x0000000182C99C70-0x0000000182C99E90
		public static bool IsFileOnSsd(string filePath) => default; // 0x0000000182C99AB0-0x0000000182C99C70
		public static bool IsRunningInSSD() => default; // 0x000000018315AA70-0x000000018315AB40
		public static bool StandaloneWinHaveSSd() => default; // 0x00000001822C5860-0x00000001822C5B20
		public static void Test() {} // 0x000000018516D394-0x000000018516D3D4
	}

	public static class NativePower // TypeDefIndex: 59954
	{
		// Nested types
		public struct SYSTEM_POWER_STATUS // TypeDefIndex: 59953
		{
			// Fields
			public byte ACLineStatus; // 0x00
			public byte BatteryFlag; // 0x01
			public byte BatteryLifePercent; // 0x02
			public byte Reserved1; // 0x03
			public uint BatteryLifeTime; // 0x04
			public uint BatteryFullLifeTime; // 0x08
		}
	
		// Methods
		private static extern bool GetSystemPowerStatus(out SYSTEM_POWER_STATUS sps); // 0x00000001822C6B30-0x00000001822C6BE0
		public static bool laptop() => default; // 0x0000000183CF0170-0x0000000183CF01C0
	}

	public static class VideoMemoryStatus // TypeDefIndex: 59958
	{
		// Fields
		private static int PDH_FMT_LARGE; // 0x00
		private static long PDH_MORE_DATA; // 0x08
		private const string Command = "powershell.exe -command \"Get-Counter -Counter \'\\GPU Process Memory(*)\\Dedicated Usage\'\""; // Metadata: 0x01FDD53F
	
		// Nested types
		private struct PROCESS_MEMORY_COUNTERS // TypeDefIndex: 59955
		{
			// Fields
			public uint cb; // 0x00
			public uint PageFaultCount; // 0x04
			public ulong PeakWorkingSetSize; // 0x08
			public ulong WorkingSetSize; // 0x10
			public ulong QuotaPeakPagedPoolUsage; // 0x18
			public ulong QuotaPagedPoolUsage; // 0x20
			public ulong QuotaPeakNonPagedPoolUsage; // 0x28
			public ulong QuotaNonPagedPoolUsage; // 0x30
			public ulong PagefileUsage; // 0x38
			public ulong PeakPagefileUsage; // 0x40
		}
	
		private struct PDH_FMT_COUNTERVALUE // TypeDefIndex: 59956
		{
			// Fields
			public int CStatus; // 0x00
			public long largeValue; // 0x08
		}
	
		private struct PDH_FMT_COUNTERVALUE_ITEM // TypeDefIndex: 59957
		{
			// Fields
			public IntPtr szName; // 0x00
			public PDH_FMT_COUNTERVALUE FmtValue; // 0x08
		}
	
		// Constructors
		static VideoMemoryStatus() {} // 0x0000000183D49110-0x0000000183D49160
	
		// Methods
		private static extern bool GetProcessMemoryInfo(IntPtr hProcess, out PROCESS_MEMORY_COUNTERS counters, uint size); // 0x000000018516D3D4-0x000000018516D470
		private static extern long PdhOpenQuery(IntPtr szDataSource, IntPtr dwUserData, out IntPtr phQuery); // 0x00000001836A0C10-0x00000001836A0C80
		private static extern long PdhAddCounter(IntPtr hQuery, string szFullCounterPath, UIntPtr dwUserData, out IntPtr phCounter); // 0x00000001836A0C80-0x00000001836A0D00
		private static extern long PdhCollectQueryData(IntPtr hQuery); // 0x00000001836A0D00-0x00000001836A0D60
		private static extern long PdhGetFormattedCounterArray(IntPtr hQuery, int dwFormat, ref uint dwBufferSize, ref uint dwItemCount, IntPtr itemBuffer); // 0x00000001836A0D60-0x00000001836A0DE0
		private static extern int PdhCloseQuery(IntPtr hQuery); // 0x00000001836A0DE0-0x00000001836A0E40
		public static ValueTuple<long, long> GetDedicatedMemoryStatus() => default; // 0x0000000182C9A310-0x0000000182C9A3A0
		public static ValueTuple<long, long> GetSharedMemoryStatus() => default; // 0x0000000182C9A280-0x0000000182C9A310
		public static ValueTuple<long, long> GetCommittedMemoryStatus() => default; // 0x0000000182C9A1F0-0x0000000182C9A280
		private static ValueTuple<long, long> GetMemoryStatus(string type) => default; // 0x00000001825FB2E0-0x00000001825FC670
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 59959
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05FE0-0x0000000183D06050
	
		// Methods
		public void __Gen_Wrap_0() {} // 0x00000001851624BC-0x0000000185162544
		public bool __Gen_Wrap_1() => default; // 0x000000018514F380-0x000000018514F42C
		public long __Gen_Wrap_2() => default; // 0x000000018516C778-0x000000018516C824
		public int __Gen_Wrap_3() => default; // 0x00000001850EF068-0x00000001850EF114
		public ValueTuple<long, long> __Gen_Wrap_4(object P0) => default; // 0x000000018516C824-0x000000018516C930
		public ValueTuple<long, long> __Gen_Wrap_5() => default; // 0x000000018516C930-0x000000018516CA20
		public float __Gen_Wrap_6() => default; // 0x00000001850F18D0-0x00000001850F1968
		public IntPtr __Gen_Wrap_7(object P0) => default; // 0x000000018516CA20-0x000000018516CAF0
		public bool __Gen_Wrap_8(object P0) => default; // 0x000000018514EF5C-0x000000018514F02C
		public double __Gen_Wrap_10() => default; // 0x000000018516C6E0-0x000000018516C778
	}

	public class WrappersManagerImpl // TypeDefIndex: 59960
	{
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018516D470-0x000000018516E884
		public static bool IsPatched(int id) => default; // 0x0000000182C9A710-0x0000000182C9A780
	}
}
