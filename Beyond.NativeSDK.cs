/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using Beyond.NativeSDK;
using IFix.Core;

// Image 115: Beyond.NativeSDK.dll - Assembly: Beyond.NativeSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60929-60945

namespace Beyond.NativeSDK
{
	public struct DiskSpaceInfo // TypeDefIndex: 60930
	{
		// Fields
		public string DriveName; // 0x00
		public ulong TotalBytes; // 0x08
		public ulong FreeBytes; // 0x10
		public ulong FreeBytesAvailable; // 0x18
		public bool IsSSD; // 0x20
	
		// Properties
		public double TotalGB { get => default; } // 0x00000001813A4380-0x00000001813A43C0 
		public double FreeGB { get => default; } // 0x00000001813A4340-0x00000001813A4380 
	}

	public static class NativeUtil // TypeDefIndex: 60933
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
		private struct PROCESS_MEMORY_COUNTERS // TypeDefIndex: 60931
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
	
		private struct PDH_FMT_COUNTERVALUE // TypeDefIndex: 60932
		{
			// Fields
			public int CStatus; // 0x00
			public long largeValue; // 0x08
		}
	
		// Constructors
		static NativeUtil() {} // 0x0000000185D8F940-0x0000000185D8FA60
	
		// Methods
		private static void _Clear() {} // 0x0000000185FADB30-0x0000000185FADB50
		public static bool IsPromotionSupport() => default; // 0x000000018735BC7C-0x000000018735BCB8
		public static long GetAvailableMemory() => default; // 0x000000018735BA30-0x000000018735BA70
		public static long GetOOMMemory() => default; // 0x0000000184E75160-0x0000000184E75190
		private static extern bool GetProcessMemoryInfo(IntPtr hProcess, out PROCESS_MEMORY_COUNTERS counters, uint size); // 0x0000000184882420-0x0000000184882490
		private static extern int PdhOpenQueryA(IntPtr szDataSource, IntPtr dwUserData, out IntPtr phQuery); // 0x000000018735BEBC-0x000000018735BF50
		private static extern int PdhAddEnglishCounterA(IntPtr hQuery, string szFullCounterPath, UIntPtr dwUserData, out IntPtr phCounter); // 0x000000018735BCB8-0x000000018735BD70
		private static extern int PdhCollectQueryData(IntPtr hQuery); // 0x000000018735BDA8-0x000000018735BE1C
		private static unsafe extern int PdhGetFormattedCounterValue(IntPtr hQuery, int dwFormat, int* lpdwType, out PDH_FMT_COUNTERVALUE pValue); // 0x000000018735BE1C-0x000000018735BEBC
		private static extern int PdhCloseQuery(IntPtr hQuery); // 0x000000018735BD70-0x000000018735BDA8
		public static int GetProcId() => default; // 0x000000018735BAEC-0x000000018735BC40
		public static long getRSSMemoryByte() => default; // 0x000000018735BF8C-0x000000018735C2D4
		public static long GetTotalMemory() => default; // 0x00000001848809B0-0x0000000184881020
		public static long GetVirtualMemory() => default; // 0x000000018735BC40-0x000000018735BC7C
		public static long GetGpuMemory() => default; // 0x0000000184880310-0x0000000184880420
		public static float GetCpuTemperature() => default; // 0x00000001848805D0-0x00000001848805F0
		public static float GetGpuTemperature() => default; // 0x00000001848805F0-0x0000000184880610
		public static long GetCpuFrequency() => default; // 0x000000018735BAB0-0x000000018735BAEC
		public static float GetBatteryLevel() => default; // 0x000000018735BA70-0x000000018735BAB0
		public static bool IsLapTop() => default; // 0x0000000184E743A0-0x0000000184E743D0
		public static bool IsCharge() => default; // 0x00000001848802C0-0x00000001848802F0
		public static int GetThermalState() => default; // 0x00000001848802F0-0x0000000184880310
		public static bool IsInSsd() => default; // 0x0000000184E743D0-0x0000000184E74400
		public static DiskSpaceInfo GetRunningDiskInfo() => default; // 0x00000001813A6F20-0x00000001813A75B0
		public static DiskSpaceInfo[] GetAllDiskInfo() => default; // 0x00000001813A68B0-0x00000001813A6F20
		public static bool HasSsd() => default; // 0x0000000184E74400-0x0000000184E74430
		public static double GetFrequencyCalculateTime() => default; // 0x0000000184880790-0x0000000184880940
		private static long RunCpuFrequencyCalculate(int times) => default; // 0x000000018735BF50-0x000000018735BF8C
	}

	public static class NativeWindowsDiskChecker // TypeDefIndex: 60937
	{
		// Fields
		private const uint STORAGEDEVICESEEKPENALTYPROPERTY = 7; // Metadata: 0x02082BDE
		private const uint PROPERTYSTANDARDQUERY = 0; // Metadata: 0x02082BDF
		private const int MAX_PATH = 1024; // Metadata: 0x02082BE0
		private const uint FILE_SHARE_READ = 1; // Metadata: 0x02082BE2
		private const uint FILE_SHARE_WRITE = 2; // Metadata: 0x02082BE3
		private const uint FILE_SHARE_DELETE = 4; // Metadata: 0x02082BE4
		private const uint OPEN_EXISTING = 3; // Metadata: 0x02082BE5
		private const uint FILE_FLAG_BACKUP_SEMANTICS = 33554432; // Metadata: 0x02082BE6
		private const uint IOCTL_STORAGE_QUERY_PROPERTY = 2954240; // Metadata: 0x02082BEA
		private static bool? initOnceIsRunningInSSD; // 0x00
		private static DiskSpaceInfo? initOnceCurrentDiskInfo; // 0x08
		private static object initOnceStandaloneWinHaveSSd; // 0x38
	
		// Nested types
		private struct STORAGE_PROPERTY_QUERY // TypeDefIndex: 60934
		{
			// Fields
			public uint PropertyId; // 0x00
			public uint QueryType; // 0x04
			public byte AdditionalParameters; // 0x08
		}
	
		private struct DEVICE_SEEK_PENALTY_DESCRIPTOR // TypeDefIndex: 60935
		{
			// Fields
			public uint Version; // 0x00
			public uint Size; // 0x04
			public bool IncursSeekPenalty; // 0x08
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 60936
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, bool> __9__24_0; // 0x08
			public static Func<string, bool> __9__28_0; // 0x10
	
			// Constructors
			static __c() {} // 0x00000001844CDA00-0x00000001844CDA80
			public __c() {} // 0x00000001844CD980-0x00000001844CDA00
	
			// Methods
			internal bool _StandaloneWinHaveSSd_b__24_0(string s) => default; // 0x00000001844CD8E0-0x00000001844CD980
			internal bool _GetAllDiskSpaces_b__28_0(string s) => default; // 0x00000001844CDB30-0x00000001844CDBE0
		}
	
		// Methods
		private static extern bool GetVolumePathName(string lpszFileName, IntPtr lpszVolumePathName, uint cchBufferLength); // 0x0000000184E73D30-0x0000000184E73DE0
		private static extern bool GetVolumeNameForVolumeMountPoint(string lpszVolumeMountPoint, IntPtr lpszVolumeName, uint cchBufferLength); // 0x00000001844CDA80-0x00000001844CDB30
		private static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile); // 0x00000001844CD560-0x00000001844CD780
		private static extern bool CloseHandle(IntPtr hObject); // 0x00000001844CBFE0-0x00000001844CD560
		public static extern int GetLogicalDriveStrings(uint nBufferLength, char[] lpBuffer); // 0x00000001850483B0-0x0000000185049380
		private static extern bool DeviceIoControl(IntPtr hDevice, uint dwIoControlCode, ref STORAGE_PROPERTY_QUERY lpInBuffer, uint nInBufferSize, ref DEVICE_SEEK_PENALTY_DESCRIPTOR lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped); // 0x00000001813AAEB0-0x00000001813AC160
		private static IntPtr GetVolumeHandleForFile(string filePath) => default; // 0x0000000184E73A70-0x0000000184E73D30
		public static bool IsFileOnSsd(string filePath) => default; // 0x00000001813A9B80-0x00000001813A9C80
		public static bool IsRunningInSSD() => default; // 0x00000001813A9C80-0x00000001813AAEB0
		public static DiskSpaceInfo GetRunningDiskInfo() => default; // 0x00000001813A94D0-0x00000001813A9B80
		public static bool StandaloneWinHaveSSd() => default; // 0x00000001813A75B0-0x00000001813A94D0
		private static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, out ulong lpFreeBytesAvailableToCaller, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes); // 0x000000018735C2D4-0x000000018735C314
		public static bool GetDiskSpace(string path, out DiskSpaceInfo info) {
			info = default;
			return default;
		} // 0x0000000185F713B0-0x0000000185F71410
		public static bool GetCurrentDiskSpace(out DiskSpaceInfo info) {
			info = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		public static DiskSpaceInfo[] GetAllDiskSpaces() => default; // 0x00000001813AC160-0x00000001813AC180
		public static void Test() {} // 0x00000001813AC160-0x00000001813AC180
	}

	public static class NativePower // TypeDefIndex: 60939
	{
		// Nested types
		public struct SYSTEM_POWER_STATUS // TypeDefIndex: 60938
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
		private static extern bool GetSystemPowerStatus(out SYSTEM_POWER_STATUS sps); // 0x0000000184E73F80-0x0000000184E74030
		public static bool laptop() => default; // 0x0000000184E740E0-0x0000000184E74130
	}

	public static class VideoMemoryStatus // TypeDefIndex: 60943
	{
		// Fields
		private static int PDH_FMT_LARGE; // 0x00
		private static long PDH_MORE_DATA; // 0x08
		private const string Command = "powershell.exe -command \"Get-Counter -Counter \'\\GPU Process Memory(*)\\Dedicated Usage\'\""; // Metadata: 0x02082BEE
	
		// Nested types
		private struct PROCESS_MEMORY_COUNTERS // TypeDefIndex: 60940
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
	
		private struct PDH_FMT_COUNTERVALUE // TypeDefIndex: 60941
		{
			// Fields
			public int CStatus; // 0x00
			public long largeValue; // 0x08
		}
	
		private struct PDH_FMT_COUNTERVALUE_ITEM // TypeDefIndex: 60942
		{
			// Fields
			public IntPtr szName; // 0x00
			public PDH_FMT_COUNTERVALUE FmtValue; // 0x08
		}
	
		// Constructors
		static VideoMemoryStatus() {} // 0x0000000185FA94C0-0x0000000185FA9510
	
		// Methods
		private static extern bool GetProcessMemoryInfo(IntPtr hProcess, out PROCESS_MEMORY_COUNTERS counters, uint size); // 0x000000018735C314-0x000000018735C3B0
		private static extern long PdhOpenQuery(IntPtr szDataSource, IntPtr dwUserData, out IntPtr phQuery); // 0x0000000185783620-0x0000000185783690
		private static extern long PdhAddCounter(IntPtr hQuery, string szFullCounterPath, UIntPtr dwUserData, out IntPtr phCounter); // 0x0000000185783690-0x0000000185783710
		private static extern long PdhAddEnglishCounter(IntPtr hQuery, string szFullCounterPath, UIntPtr dwUserData, out IntPtr phCounter); // 0x00000001813AC180-0x00000001813AC280
		private static extern long PdhCollectQueryData(IntPtr hQuery); // 0x0000000185783710-0x0000000185783770
		private static extern long PdhGetFormattedCounterArray(IntPtr hQuery, int dwFormat, ref uint dwBufferSize, ref uint dwItemCount, IntPtr itemBuffer); // 0x0000000185783770-0x00000001857837F0
		private static extern int PdhCloseQuery(IntPtr hQuery); // 0x00000001857837F0-0x0000000185783850
		public static ValueTuple<long, long> GetDedicatedMemoryStatus() => default; // 0x0000000184880540-0x00000001848805D0
		public static ValueTuple<long, long> GetSharedMemoryStatus() => default; // 0x00000001848804B0-0x0000000184880540
		public static ValueTuple<long, long> GetCommittedMemoryStatus() => default; // 0x0000000184880420-0x00000001848804B0
		private static ValueTuple<long, long> GetMemoryStatus(string type) => default; // 0x0000000184856BC0-0x0000000184858DD0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60944
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F648D0-0x0000000185F64940
	
		// Methods
		public void __Gen_Wrap_0() {} // 0x0000000187350FD4-0x000000018735105C
		public bool __Gen_Wrap_1() => default; // 0x000000018735B3F8-0x000000018735B4A4
		public long __Gen_Wrap_2() => default; // 0x000000018735B4A4-0x000000018735B550
		public int __Gen_Wrap_3() => default; // 0x000000018735B550-0x000000018735B5FC
		public ValueTuple<long, long> __Gen_Wrap_4(object P0) => default; // 0x000000018735B5FC-0x000000018735B708
		public ValueTuple<long, long> __Gen_Wrap_5() => default; // 0x000000018735B708-0x000000018735B7F8
		public float __Gen_Wrap_6() => default; // 0x000000018735B7F8-0x000000018735B890
		public IntPtr __Gen_Wrap_7(object P0) => default; // 0x000000018735B890-0x000000018735B960
		public bool __Gen_Wrap_8(object P0) => default; // 0x000000018735B960-0x000000018735BA30
		public bool __Gen_Wrap_9(object P0, out DiskSpaceInfo P1) {
			P1 = default;
			return default;
		} // 0x00000001813A5ED0-0x00000001813A68B0
		public DiskSpaceInfo __Gen_Wrap_10() => default; // 0x00000001813A43C0-0x00000001813A4BE0
		public DiskSpaceInfo[] __Gen_Wrap_12() => default; // 0x00000001813A4BE0-0x00000001813A5420
		public double __Gen_Wrap_13() => default; // 0x00000001813A5420-0x00000001813A55F0
		public bool __Gen_Wrap_14(out DiskSpaceInfo P0) {
			P0 = default;
			return default;
		} // 0x00000001813A55F0-0x00000001813A5ED0
	}

	public class WrappersManagerImpl // TypeDefIndex: 60945
	{
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018735C3B0-0x000000018735D7C4
		public static bool IsPatched(int id) => default; // 0x0000000184880940-0x00000001848809B0
	}
}
