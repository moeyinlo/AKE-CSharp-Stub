/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Scripting;

// Image 98: Beyond.NativeSDK.dll - Assembly: Beyond.NativeSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90540-90564

namespace Beyond.NativeSDK
{
	public struct DiskSpaceInfo // TypeDefIndex: 90541
	{
		// Fields
		public string DriveName; // 0x00
		public ulong TotalBytes; // 0x08
		public ulong FreeBytes; // 0x10
		public ulong FreeBytesAvailable; // 0x18
		public bool IsSSD; // 0x20
	
		// Properties
		public double TotalGB { get; } // 0x000000018672DA50-0x000000018672DAA0 
		public double FreeGB { get; } // 0x000000018672DAA0-0x000000018672DAF0 
	}

	public struct MemoryDimmInfo // TypeDefIndex: 90542
	{
		// Fields
		public string DeviceLocator; // 0x00
		public string MemoryType; // 0x08
		public uint SpeedMTs; // 0x10
		public uint ConfiguredSpeedMTs; // 0x14
		public ulong SizeBytes; // 0x18
		public string Manufacturer; // 0x20
		public string PartNumber; // 0x28
	
		// Properties
		public double SizeGB { get; } // 0x0000000188802AE8-0x0000000188802B48 
	}

	public struct PcPerfInfo // TypeDefIndex: 90543
	{
		// Fields
		public float CpuUsagePercent; // 0x00
		public float CpuProcessPercent; // 0x04
		public float GpuUsagePercent; // 0x08
		public float GpuOthersPercent; // 0x0C
		public float SystemGpuUsagePercent; // 0x10
		public int CpuClockMHz; // 0x14
	}

	public struct SystemMemoryInfo // TypeDefIndex: 90544
	{
		// Fields
		public int DimmCount; // 0x00
		public int TotalSlots; // 0x04
		public string MemoryType; // 0x08
		public uint MaxSpeedMTs; // 0x10
		public uint ConfiguredSpeedMTs; // 0x14
		public ulong TotalSizeBytes; // 0x18
		public MemoryDimmInfo[] Dimms; // 0x20
	
		// Properties
		public double TotalSizeGB { get; } // 0x000000018672D990-0x000000018672D9E0 
	}

	public static class NativeUtil // TypeDefIndex: 90548
	{
		// Fields
		private static int s_procId; // 0x00
		public static ValueTuple<long, long> s_DedicatedGpuMem; // 0x08
		public static ValueTuple<long, long> s_SharedMemoryGpuMem; // 0x18
		public static ValueTuple<long, long> s_CommittedMemoryGpuMem; // 0x28
		public static ValueTuple<long, long> s_LocalUsageGpuMem; // 0x38
		public static string s_gpuMemQuery; // 0x48
		private static StringBuilder s_GetGpuMemoryTopOthersSB; // 0x50
		public static int s_frequencyCalcTimes; // 0x58
		private static long _calcResult; // 0x60
		private static readonly Stopwatch SW; // 0x68
	
		// Nested types
		private struct PROCESS_MEMORY_COUNTERS // TypeDefIndex: 90545
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
	
		private struct PDH_FMT_COUNTERVALUE // TypeDefIndex: 90546
		{
			// Fields
			public int CStatus; // 0x00
			public long largeValue; // 0x08
		}
	
		public enum EAndroidProcessMemoryField // TypeDefIndex: 90547
		{
			VmRss = 0,
			RssAnon = 1,
			VmSwap = 2
		}
	
		// Constructors
		static NativeUtil(); // 0x0000000186EDDCA0-0x0000000186EDDE50
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void _Clear(); // 0x000000018722CA40-0x000000018722CA70
		public static bool IsPromotionSupport(); // 0x0000000188802C80-0x0000000188802CB8
		public static long GetAvailableMemory(); // 0x0000000188802B48-0x0000000188802B88
		public static long ShrinkApplicationMemory(); // 0x0000000188802F8C-0x0000000188802FC4
		public static long GetOOMMemory(); // 0x000000018672D8C0-0x000000018672D8F0
		private static extern bool GetProcessMemoryInfo(IntPtr hProcess, out PROCESS_MEMORY_COUNTERS counters, uint size); // 0x00000001862765E0-0x0000000186276650
		private static extern int PdhOpenQueryA(IntPtr szDataSource, IntPtr dwUserData, out IntPtr phQuery); // 0x0000000188802EBC-0x0000000188802F50
		private static extern int PdhAddEnglishCounterA(IntPtr hQuery, string szFullCounterPath, UIntPtr dwUserData, out IntPtr phCounter); // 0x0000000188802CB8-0x0000000188802D70
		private static extern int PdhCollectQueryData(IntPtr hQuery); // 0x0000000188802DA8-0x0000000188802E1C
		private static unsafe extern int PdhGetFormattedCounterValue(IntPtr hQuery, int dwFormat, int* lpdwType, out PDH_FMT_COUNTERVALUE pValue); // 0x0000000188802E1C-0x0000000188802EBC
		private static extern int PdhCloseQuery(IntPtr hQuery); // 0x0000000188802D70-0x0000000188802DA8
		public static int GetProcId(); // 0x0000000185442640-0x0000000185442800
		public static long GetAndroidProcessMemoryByte(EAndroidProcessMemoryField field); // 0x000000018225D850-0x000000018225D890
		public static long getRSSMemoryByte(); // 0x0000000188802FC4-0x0000000188803034
		public static long GetRssAnonMemoryByte(); // 0x000000018225D890-0x000000018225DC00
		public static long GetVmSwapMemoryByte(); // 0x000000018225DC00-0x000000018225DF70
		public static long GetTotalMemory(); // 0x0000000186276090-0x0000000186276530
		public static long GetVirtualMemory(); // 0x0000000188802C04-0x0000000188802C3C
		public static long GetGpuMemory(); // 0x00000001868371A0-0x00000001868372E0
		public static string GetGpuMemoryTopOthersJson(); // 0x000000018674ADF0-0x000000018674B060
		private static void AppendGpuTopArray(StringBuilder sb, string key, List<GpuProcMemEntry> list); // 0x000000018539A850-0x000000018539AB30
		private static string EscapeJson(string s); // 0x000000018539AC10-0x000000018539ACF0
		public static float GetCpuTemperature(); // 0x0000000186BFB8E0-0x0000000186BFB910
		public static float GetGpuTemperature(); // 0x0000000186BFB8B0-0x0000000186BFB8E0
		public static long GetCpuFrequency(); // 0x0000000188802BCC-0x0000000188802C04
		public static float GetBatteryLevel(); // 0x0000000188802B88-0x0000000188802BCC
		public static bool IsLapTop(); // 0x000000018672CD00-0x000000018672CD30
		public static bool IsCharge(); // 0x0000000186C57650-0x0000000186C57690
		public static int GetThermalState(); // 0x0000000186D3C8D0-0x0000000186D3C900
		public static bool IsInSsd(); // 0x0000000188802C3C-0x0000000188802C80
		public static DiskSpaceInfo GetRunningDiskInfo(); // 0x000000018672D580-0x000000018672D5D0
		public static DiskSpaceInfo[] GetAllDiskInfo(); // 0x000000018672D8F0-0x000000018672D920
		public static bool HasSsd(); // 0x000000018672CD30-0x000000018672CD60
		public static bool TrySamplePcPerf(out PcPerfInfo info); // 0x0000000185442800-0x0000000185442880
		public static SystemMemoryInfo GetSystemMemoryInfo(); // 0x000000018672D830-0x000000018672D880
		public static double GetFrequencyCalculateTime(); // 0x0000000185B07A00-0x0000000185B07B90
		private static long RunCpuFrequencyCalculate(int times); // 0x0000000188802F50-0x0000000188802F8C
	}

	[UnityEngine.Scripting.Preserve]
	public static class NativeWindowsDiskChecker // TypeDefIndex: 90552
	{
		// Fields
		private const uint STORAGEDEVICESEEKPENALTYPROPERTY = 7; // Metadata: 0x0264AEC7
		private const uint PROPERTYSTANDARDQUERY = 0; // Metadata: 0x0264AEC8
		private const int MAX_PATH = 1024; // Metadata: 0x0264AEC9
		private const uint FILE_SHARE_READ = 1; // Metadata: 0x0264AECB
		private const uint FILE_SHARE_WRITE = 2; // Metadata: 0x0264AECC
		private const uint FILE_SHARE_DELETE = 4; // Metadata: 0x0264AECD
		private const uint OPEN_EXISTING = 3; // Metadata: 0x0264AECE
		private const uint FILE_FLAG_BACKUP_SEMANTICS = 33554432; // Metadata: 0x0264AECF
		private const uint IOCTL_STORAGE_QUERY_PROPERTY = 2954240; // Metadata: 0x0264AED3
		private static bool? initOnceIsRunningInSSD; // 0x00
		private static DiskSpaceInfo? initOnceCurrentDiskInfo; // 0x08
		private static object initOnceStandaloneWinHaveSSd; // 0x38
	
		// Nested types
		private struct STORAGE_PROPERTY_QUERY // TypeDefIndex: 90549
		{
			// Fields
			public uint PropertyId; // 0x00
			public uint QueryType; // 0x04
			public byte AdditionalParameters; // 0x08
		}
	
		private struct DEVICE_SEEK_PENALTY_DESCRIPTOR // TypeDefIndex: 90550
		{
			// Fields
			public uint Version; // 0x00
			public uint Size; // 0x04
			public bool IncursSeekPenalty; // 0x08
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 90551
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, bool> __9__24_0; // 0x08
			public static Func<string, bool> __9__28_0; // 0x10
	
			// Constructors
			static __c(); // 0x00000001871E5A20-0x00000001871E5A80
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _StandaloneWinHaveSSd_b__24_0(string s); // 0x000000018710D380-0x000000018710D3A0
			internal bool _GetAllDiskSpaces_b__28_0(string s); // 0x000000018710D380-0x000000018710D3A0
		}
	
		// Methods
		private static extern bool GetVolumePathName(string lpszFileName, IntPtr lpszVolumePathName, uint cchBufferLength); // 0x0000000185AFB390-0x0000000185AFB410
		private static extern bool GetVolumeNameForVolumeMountPoint(string lpszVolumeMountPoint, IntPtr lpszVolumeName, uint cchBufferLength); // 0x0000000185AFB310-0x0000000185AFB390
		private static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile); // 0x0000000185AFB270-0x0000000185AFB310
		private static extern bool CloseHandle(IntPtr hObject); // 0x0000000185AFB4C0-0x0000000185AFB570
		public static extern int GetLogicalDriveStrings(uint nBufferLength, char[] lpBuffer); // 0x0000000185AF8EE0-0x0000000185AF8F40
		private static extern bool DeviceIoControl(IntPtr hDevice, uint dwIoControlCode, ref STORAGE_PROPERTY_QUERY lpInBuffer, uint nInBufferSize, ref DEVICE_SEEK_PENALTY_DESCRIPTOR lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped); // 0x0000000185AFB410-0x0000000185AFB4C0
		private static IntPtr GetVolumeHandleForFile(string filePath); // 0x0000000185AFAED0-0x0000000185AFB110
		public static bool IsFileOnSsd(string filePath); // 0x0000000185AFAD00-0x0000000185AFAED0
		public static bool IsRunningInSSD(); // 0x000000018880308C-0x0000000188803174
		public static DiskSpaceInfo GetRunningDiskInfo(); // 0x000000018672D5D0-0x000000018672D770
		public static bool StandaloneWinHaveSSd(); // 0x0000000185AFA580-0x0000000185AFA840
		private static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, out ulong lpFreeBytesAvailableToCaller, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes); // 0x0000000185AFAC70-0x0000000185AFAD00
		public static bool GetDiskSpace(string path, out DiskSpaceInfo info); // 0x000000018672C500-0x000000018672CB30
		public static bool GetCurrentDiskSpace(out DiskSpaceInfo info); // 0x0000000188803034-0x000000018880308C
		public static DiskSpaceInfo[] GetAllDiskSpaces(); // 0x0000000185AFA840-0x0000000185AFAC70
		public static void Test(); // 0x0000000188803174-0x00000001888031A4
	}

	public static class NativePower // TypeDefIndex: 90554
	{
		// Nested types
		public struct SYSTEM_POWER_STATUS // TypeDefIndex: 90553
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
		private static extern bool GetSystemPowerStatus(out SYSTEM_POWER_STATUS sps); // 0x0000000185AFA370-0x0000000185AFA420
		public static bool laptop(); // 0x000000018672CBF0-0x000000018672CC40
	}

	public struct GpuProcMemEntry // TypeDefIndex: 90555
	{
		// Fields
		public int Pid; // 0x00
		public string ProcessName; // 0x08
		public long Bytes; // 0x10
	
		// Properties
		public double MB { get; } // 0x000000018539AB30-0x000000018539AB70 
	}

	public static class VideoMemoryStatus // TypeDefIndex: 90560
	{
		// Fields
		private static int PDH_FMT_LARGE; // 0x00
		private static long PDH_MORE_DATA; // 0x08
		private const string Command = "powershell.exe -command \"Get-Counter -Counter \'\\GPU Process Memory(*)\\Dedicated Usage\'\""; // Metadata: 0x0264AEDA
		private static int s_currentPid; // 0x10
		private const uint PROCESS_QUERY_LIMITED_INFORMATION = 4096; // Metadata: 0x0264AF33
		private static readonly char[] s_pathSep; // 0x18
	
		// Nested types
		private struct PROCESS_MEMORY_COUNTERS // TypeDefIndex: 90556
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
	
		private struct PDH_FMT_COUNTERVALUE // TypeDefIndex: 90557
		{
			// Fields
			public int CStatus; // 0x00
			public long largeValue; // 0x08
		}
	
		private struct PDH_FMT_COUNTERVALUE_ITEM // TypeDefIndex: 90558
		{
			// Fields
			public IntPtr szName; // 0x00
			public PDH_FMT_COUNTERVALUE FmtValue; // 0x08
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 90559
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<KeyValuePair<int, long>> __9__24_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E79A0-0x00000001871E7A00
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetTopOtherProcessMemory_b__24_0(KeyValuePair<int, long> a, KeyValuePair<int, long> b); // 0x00000001861D2A90-0x00000001861D2AF0
		}
	
		// Constructors
		static VideoMemoryStatus(); // 0x00000001870A2550-0x00000001870A2630
	
		// Methods
		private static extern bool GetProcessMemoryInfo(IntPtr hProcess, out PROCESS_MEMORY_COUNTERS counters, uint size); // 0x0000000188803244-0x00000001888032E0
		private static extern long PdhOpenQuery(IntPtr szDataSource, IntPtr dwUserData, out IntPtr phQuery); // 0x0000000186881E10-0x0000000186881E80
		private static extern long PdhAddCounter(IntPtr hQuery, string szFullCounterPath, UIntPtr dwUserData, out IntPtr phCounter); // 0x0000000188803380-0x0000000188803438
		private static extern long PdhAddEnglishCounter(IntPtr hQuery, string szFullCounterPath, UIntPtr dwUserData, out IntPtr phCounter); // 0x00000001867E8290-0x00000001867E8310
		private static extern long PdhCollectQueryData(IntPtr hQuery); // 0x0000000186963860-0x00000001869638C0
		private static extern long PdhGetFormattedCounterArray(IntPtr hQuery, int dwFormat, ref uint dwBufferSize, ref uint dwItemCount, IntPtr itemBuffer); // 0x000000018668D4D0-0x000000018668D550
		private static extern int PdhCloseQuery(IntPtr hQuery); // 0x0000000186962CF0-0x0000000186962D50
		public static ValueTuple<long, long> GetDedicatedMemoryStatus(); // 0x0000000186837490-0x0000000186837520
		public static ValueTuple<long, long> GetSharedMemoryStatus(); // 0x0000000186837400-0x0000000186837490
		public static ValueTuple<long, long> GetDedicatedResidentMemoryStatus(); // 0x0000000186837370-0x0000000186837400
		public static ValueTuple<long, long> GetSharedResidentMemoryStatus(); // 0x00000001888032E0-0x0000000188803380
		public static ValueTuple<long, long> GetCommittedMemoryStatus(); // 0x00000001868372E0-0x0000000186837370
		public static ValueTuple<long, long> GPUAdapterMemory(); // 0x00000001888031A4-0x0000000188803244
		private static ValueTuple<long, long> GetMemoryStatus(string type); // 0x0000000185B5D940-0x0000000185B5DC60
		private static Dictionary<int, long> CollectByPid(string type); // 0x00000001857B7C30-0x00000001857B8870
		public static List<GpuProcMemEntry> GetDedicatedTopOthers(int topN = 5 /* Metadata: 0x0264AED7 */); // 0x000000018674B180-0x000000018674B210
		public static List<GpuProcMemEntry> GetSharedTopOthers(int topN = 5 /* Metadata: 0x0264AED8 */); // 0x000000018674B0F0-0x000000018674B180
		public static List<GpuProcMemEntry> GetCommittedTopOthers(int topN = 5 /* Metadata: 0x0264AED9 */); // 0x000000018674B060-0x000000018674B0F0
		private static List<GpuProcMemEntry> GetTopOtherProcessMemory(string type, int topN); // 0x0000000185B5CE60-0x0000000185B5D940
		private static int GetCurrentProcessIdCached(); // 0x00000001867C3E70-0x00000001867C4040
		private static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId); // 0x0000000185A1B940-0x0000000185A1B9B0
		private static extern bool QueryFullProcessImageNameW(IntPtr hProcess, int dwFlags, IntPtr lpExeName, ref int lpdwSize); // 0x0000000185A1BEC0-0x0000000185A1BF40
		private static extern bool CloseHandle(IntPtr hObject); // 0x0000000185AFB570-0x0000000185AFB620
		private static string ResolveProcessName(int pid); // 0x0000000185A1B2C0-0x0000000185A1B900
	}

	[UnityEngine.Scripting.Preserve]
	public static class WinMemoryInfo // TypeDefIndex: 90561
	{
		// Fields
		private const uint RSMB = 1381190978; // Metadata: 0x0264AF35
		private const byte SMBIOS_TYPE_MEMORY_DEVICE = 17; // Metadata: 0x0264AF3A
		private const byte SMBIOS_TYPE_END_OF_TABLE = 127; // Metadata: 0x0264AF3B
		private static SystemMemoryInfo? s_cachedInfo; // 0x00
	
		// Methods
		private static extern uint GetSystemFirmwareTable(uint FirmwareTableProviderSignature, uint FirmwareTableID, IntPtr pFirmwareTableBuffer, uint BufferSize); // 0x0000000185AFA300-0x0000000185AFA370
		public static SystemMemoryInfo GetSystemMemoryInfo(); // 0x000000018672CE00-0x000000018672CF60
		private static SystemMemoryInfo ParseSmbiosMemoryInfo(); // 0x0000000185AF8F40-0x0000000185AFA0F0
		private static unsafe ushort ReadUInt16(byte* ptr, int offset); // 0x0000000187233150-0x0000000187233170
		private static unsafe uint ReadUInt32(byte* ptr, int offset); // 0x0000000187233170-0x00000001872331A0
		private static unsafe string GetSmbiosString(byte* stringArea, byte index, byte* tableEnd); // 0x0000000185AFA0F0-0x0000000185AFA1D0
		private static string GetMemoryTypeName(byte code); // 0x0000000185AFA1D0-0x0000000185AFA300
		public static void Test(); // 0x0000000188803438-0x0000000188803468
	}

	public static class WinPerfMonitor // TypeDefIndex: 90564
	{
		// Fields
		private const int PDH_FMT_DOUBLE = 512; // Metadata: 0x0264AF3C
		private const long PDH_MORE_DATA = 2147485650; // Metadata: 0x0264AF3E
		private const int PDH_CSTATUS_NEW_DATA = 1; // Metadata: 0x0264AF46
		private const string COUNTER_CPU_UTILITY = "\\Processor Information(_Total)\\% Processor Utility"; // Metadata: 0x0264AF47
		private const string COUNTER_CPU_TIME = "\\Processor(_Total)\\% Processor Time"; // Metadata: 0x0264AF7A
		private const string COUNTER_CPU_PERFORMANCE = "\\Processor Information(_Total)\\% Processor Performance"; // Metadata: 0x0264AF9E
		private const string COUNTER_CPU_FREQUENCY = "\\Processor Information(_Total)\\Processor Frequency"; // Metadata: 0x0264AFD5
		private static IntPtr s_query; // 0x00
		private static IntPtr s_cpuUsageCounter; // 0x08
		private static IntPtr s_cpuPerformanceCounter; // 0x10
		private static IntPtr s_cpuFrequencyCounter; // 0x18
		private static IntPtr s_gpuUsageCounter; // 0x20
		private static bool s_inited; // 0x28
		private static bool s_initFailed; // 0x29
		private static bool s_firstCollectDone; // 0x2A
		private static bool s_procCpuPrimed; // 0x2B
		private static TimeSpan s_lastProcCpuTime; // 0x30
		private static long s_lastProcCpuStamp; // 0x38
		private static readonly object s_lock; // 0x40
		private static readonly ProfilerMarker s_trySampleMarker; // 0x48
		private static readonly ProfilerMarker s_collectQueryMarker; // 0x50
		private static readonly ProfilerMarker s_readGpuUsageMarker; // 0x58
		private static readonly Dictionary<string, double> s_gpuEngineUsages; // 0x60
		private static readonly int s_gpuCounterItemSize; // 0x68
	
		// Nested types
		private struct PDH_FMT_COUNTERVALUE_DOUBLE // TypeDefIndex: 90562
		{
			// Fields
			public int CStatus; // 0x00
			public double doubleValue; // 0x08
		}
	
		private struct PDH_FMT_COUNTERVALUE_ITEM_DOUBLE // TypeDefIndex: 90563
		{
			// Fields
			public IntPtr szName; // 0x00
			public PDH_FMT_COUNTERVALUE_DOUBLE FmtValue; // 0x08
		}
	
		// Constructors
		static WinPerfMonitor(); // 0x0000000185B75680-0x0000000185B75960
	
		// Methods
		private static extern long PdhOpenQuery(IntPtr szDataSource, IntPtr dwUserData, out IntPtr phQuery); // 0x0000000186881E80-0x0000000186881F30
		private static extern long PdhAddEnglishCounter(IntPtr hQuery, string szFullCounterPath, UIntPtr dwUserData, out IntPtr phCounter); // 0x00000001854415A0-0x0000000185441620
		private static extern long PdhCollectQueryData(IntPtr hQuery); // 0x0000000185443470-0x00000001854434D0
		private static extern long PdhGetFormattedCounterValue(IntPtr hCounter, int dwFormat, IntPtr lpdwType, out PDH_FMT_COUNTERVALUE_DOUBLE pValue); // 0x00000001854433F0-0x0000000185443470
		private static extern long PdhGetFormattedCounterArray(IntPtr hCounter, int dwFormat, ref uint dwBufferSize, ref uint dwItemCount, IntPtr itemBuffer); // 0x00000001854425C0-0x0000000185442640
		private static extern int PdhCloseQuery(IntPtr hQuery); // 0x0000000188803468-0x00000001888034A4
		public static bool TrySample(out PcPerfInfo info); // 0x0000000185442BD0-0x0000000185443340
		private static bool _EnsureInited(); // 0x0000000185442880-0x0000000185442AB0
		private static void _Shutdown(); // 0x00000001888034A4-0x0000000188803584
		private static double _ReadCounterValue(IntPtr counter); // 0x0000000185443340-0x00000001854433F0
		private static float _ReadProcessCpuPercent(); // 0x0000000185444190-0x00000001854444C0
		private static bool _ReadGpuUsage(out float processUsage, out float systemUsage, out float otherUsage); // 0x0000000185441890-0x00000001854423D0
		private static int _ParsePidFromInstance(string name); // 0x0000000185442400-0x00000001854425A0
	}
}
