/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Beyond.NativeSDK;
using IFix.Core;
using UnityEngine;
using UnityEngine.Scripting;

// Image 94: Beyond.NativeSDK.dll - Assembly: Beyond.NativeSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63003-63028
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.NativeSDK
{
	public struct DiskSpaceInfo // TypeDefIndex: 63004
	{
		// Fields
		public string DriveName; // 0x00
		public ulong TotalBytes; // 0x08
		public ulong FreeBytes; // 0x10
		public ulong FreeBytesAvailable; // 0x18
		public bool IsSSD; // 0x20
	
		// Properties
		public double TotalGB { get; } // 0x00000001839BADF0-0x00000001839BAE40 
		public double FreeGB { get; } // 0x00000001839BAE40-0x00000001839BAEA0 
	}

	public struct MemoryDimmInfo // TypeDefIndex: 63005
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
		public double SizeGB { get; } // 0x000000018638029C-0x0000000186380314 
	}

	public struct PcPerfInfo // TypeDefIndex: 63006
	{
		// Fields
		public float CpuUsagePercent; // 0x00
		public float GpuUsagePercent; // 0x04
		public int CpuClockMHz; // 0x08
	}

	public struct SystemMemoryInfo // TypeDefIndex: 63007
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
		public double TotalSizeGB { get; } // 0x0000000184D56290-0x0000000184D562F0 
	}

	public static class NativeUtil // TypeDefIndex: 63010
	{
		// Fields
		private static int s_procId; // 0x00
		public static ValueTuple<long, long> s_DedicatedGpuMem; // 0x08
		public static ValueTuple<long, long> s_SharedMemoryGpuMem; // 0x18
		public static ValueTuple<long, long> s_CommittedMemoryGpuMem; // 0x28
		public static string s_gpuMemQuery; // 0x38
		private static StringBuilder s_GetGpuMemoryTopOthersSB; // 0x40
		public static int s_frequencyCalcTimes; // 0x48
		private static long _calcResult; // 0x50
		private static readonly Stopwatch SW; // 0x58
	
		// Nested types
		private struct PROCESS_MEMORY_COUNTERS // TypeDefIndex: 63008
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
	
		private struct PDH_FMT_COUNTERVALUE // TypeDefIndex: 63009
		{
			// Fields
			public int CStatus; // 0x00
			public long largeValue; // 0x08
		}
	
		// Constructors
		static NativeUtil(); // 0x0000000184B682F0-0x0000000184B68FF0
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void _Clear(); // 0x0000000184D83BA0-0x0000000184D83BC0
		public static bool IsPromotionSupport(); // 0x00000001863805A0-0x00000001863805DC
		public static long GetAvailableMemory(); // 0x0000000186380314-0x0000000186380354
		public static long ShrinkApplicationMemory(); // 0x0000000184D80940-0x0000000184D80960
		public static long GetOOMMemory(); // 0x0000000184D7AF70-0x0000000184D7AFA0
		private static extern bool GetProcessMemoryInfo(IntPtr hProcess, out PROCESS_MEMORY_COUNTERS counters, uint size); // 0x00000001839B8610-0x00000001839B8680
		private static extern int PdhOpenQueryA(IntPtr szDataSource, IntPtr dwUserData, out IntPtr phQuery); // 0x00000001863807E0-0x0000000186380874
		private static extern int PdhAddEnglishCounterA(IntPtr hQuery, string szFullCounterPath, UIntPtr dwUserData, out IntPtr phCounter); // 0x00000001863805DC-0x0000000186380694
		private static extern int PdhCollectQueryData(IntPtr hQuery); // 0x00000001863806CC-0x0000000186380740
		private static unsafe extern int PdhGetFormattedCounterValue(IntPtr hQuery, int dwFormat, int* lpdwType, out PDH_FMT_COUNTERVALUE pValue); // 0x0000000186380740-0x00000001863807E0
		private static extern int PdhCloseQuery(IntPtr hQuery); // 0x0000000186380694-0x00000001863806CC
		public static int GetProcId(); // 0x00000001863803D0-0x0000000186380524
		public static long getRSSMemoryByte(); // 0x00000001863808B0-0x0000000186380BF8
		public static long GetTotalMemory(); // 0x00000001839B9400-0x00000001839B98A0
		public static long GetVirtualMemory(); // 0x0000000186380524-0x0000000186380560
		public static long GetGpuMemory(); // 0x00000001839B9A80-0x00000001839B9B90
		public static string GetGpuMemoryTopOthersJson(); // 0x00000001811D9F20-0x00000001811DB180
		private static void AppendGpuTopArray(StringBuilder sb, string key, List<GpuProcMemEntry> list); // 0x00000001811D7C60-0x00000001811D9080
		private static string EscapeJson(string s); // 0x00000001811D9080-0x00000001811D9F20
		public static float GetCpuTemperature(); // 0x00000001839BA960-0x00000001839BA980
		public static float GetGpuTemperature(); // 0x00000001839BA980-0x00000001839BA9A0
		public static long GetCpuFrequency(); // 0x0000000186380394-0x00000001863803D0
		public static float GetBatteryLevel(); // 0x0000000186380354-0x0000000186380394
		public static bool IsLapTop(); // 0x0000000184D1F4C0-0x0000000184D1F4F0
		public static bool IsCharge(); // 0x00000001839B9A30-0x00000001839B9A60
		public static int GetThermalState(); // 0x00000001839B9A60-0x00000001839B9A80
		public static bool IsInSsd(); // 0x0000000186380560-0x00000001863805A0
		public static DiskSpaceInfo GetRunningDiskInfo(); // 0x0000000183DA15C0-0x0000000183DA1610
		public static DiskSpaceInfo[] GetAllDiskInfo(); // 0x0000000184D7CF50-0x0000000184D7CF80
		public static bool HasSsd(); // 0x00000001839B73C0-0x00000001839B73F0
		public static bool TrySamplePcPerf(out PcPerfInfo info); // 0x00000001811DB180-0x00000001811DB800
		public static SystemMemoryInfo GetSystemMemoryInfo(); // 0x0000000183824CC0-0x0000000183824D10
		public static double GetFrequencyCalculateTime(); // 0x00000001839BAB20-0x00000001839BACA0
		private static long RunCpuFrequencyCalculate(int times); // 0x0000000186380874-0x00000001863808B0
	}

	[UnityEngine.Scripting.Preserve]
	public static class NativeWindowsDiskChecker // TypeDefIndex: 63014
	{
		// Fields
		private const uint STORAGEDEVICESEEKPENALTYPROPERTY = 7; // Metadata: 0x02352464
		private const uint PROPERTYSTANDARDQUERY = 0; // Metadata: 0x02352465
		private const int MAX_PATH = 1024; // Metadata: 0x02352466
		private const uint FILE_SHARE_READ = 1; // Metadata: 0x02352468
		private const uint FILE_SHARE_WRITE = 2; // Metadata: 0x02352469
		private const uint FILE_SHARE_DELETE = 4; // Metadata: 0x0235246A
		private const uint OPEN_EXISTING = 3; // Metadata: 0x0235246B
		private const uint FILE_FLAG_BACKUP_SEMANTICS = 33554432; // Metadata: 0x0235246C
		private const uint IOCTL_STORAGE_QUERY_PROPERTY = 2954240; // Metadata: 0x02352470
		private static bool? initOnceIsRunningInSSD; // 0x00
		private static DiskSpaceInfo? initOnceCurrentDiskInfo; // 0x08
		private static object initOnceStandaloneWinHaveSSd; // 0x38
	
		// Nested types
		private struct STORAGE_PROPERTY_QUERY // TypeDefIndex: 63011
		{
			// Fields
			public uint PropertyId; // 0x00
			public uint QueryType; // 0x04
			public byte AdditionalParameters; // 0x08
		}
	
		private struct DEVICE_SEEK_PENALTY_DESCRIPTOR // TypeDefIndex: 63012
		{
			// Fields
			public uint Version; // 0x00
			public uint Size; // 0x04
			public bool IncursSeekPenalty; // 0x08
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 63013
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, bool> __9__24_0; // 0x08
			public static Func<string, bool> __9__28_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000184D44E30-0x0000000184D44E90
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _StandaloneWinHaveSSd_b__24_0(string s); // 0x0000000184B313B0-0x0000000184B313D0
			internal bool _GetAllDiskSpaces_b__28_0(string s); // 0x0000000184B313B0-0x0000000184B313D0
		}
	
		// Methods
		private static extern bool GetVolumePathName(string lpszFileName, IntPtr lpszVolumePathName, uint cchBufferLength); // 0x00000001839BACF0-0x00000001839BAD70
		private static extern bool GetVolumeNameForVolumeMountPoint(string lpszVolumeMountPoint, IntPtr lpszVolumeName, uint cchBufferLength); // 0x00000001839BAD70-0x00000001839BADF0
		private static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile); // 0x00000001839BA360-0x00000001839BA400
		private static extern bool CloseHandle(IntPtr hObject); // 0x00000001839BA200-0x00000001839BA2B0
		public static extern int GetLogicalDriveStrings(uint nBufferLength, char[] lpBuffer); // 0x0000000183824E60-0x0000000183824EC0
		private static extern bool DeviceIoControl(IntPtr hDevice, uint dwIoControlCode, ref STORAGE_PROPERTY_QUERY lpInBuffer, uint nInBufferSize, ref DEVICE_SEEK_PENALTY_DESCRIPTOR lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped); // 0x00000001839BA2B0-0x00000001839BA360
		private static IntPtr GetVolumeHandleForFile(string filePath); // 0x00000001839BA5D0-0x00000001839BA800
		public static bool IsFileOnSsd(string filePath); // 0x00000001839BA400-0x00000001839BA5D0
		public static bool IsRunningInSSD(); // 0x0000000186380C54-0x0000000186380D38
		public static DiskSpaceInfo GetRunningDiskInfo(); // 0x0000000183DA34B0-0x0000000183DA3630
		public static bool StandaloneWinHaveSSd(); // 0x00000001839B7F30-0x00000001839B81F0
		private static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, out ulong lpFreeBytesAvailableToCaller, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes); // 0x00000001839BA170-0x00000001839BA200
		public static bool GetDiskSpace(string path, out DiskSpaceInfo info); // 0x000000018494FFB0-0x00000001849504E0
		public static bool GetCurrentDiskSpace(out DiskSpaceInfo info); // 0x0000000186380BF8-0x0000000186380C54
		public static DiskSpaceInfo[] GetAllDiskSpaces(); // 0x00000001839B9D40-0x00000001839BA170
		public static void Test(); // 0x0000000186380D38-0x0000000186380D78
	}

	public static class NativePower // TypeDefIndex: 63016
	{
		// Nested types
		public struct SYSTEM_POWER_STATUS // TypeDefIndex: 63015
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
		private static extern bool GetSystemPowerStatus(out SYSTEM_POWER_STATUS sps); // 0x0000000183826730-0x00000001838267E0
		public static bool laptop(); // 0x0000000184D1F4F0-0x0000000184D1F540
	}

	public struct GpuProcMemEntry // TypeDefIndex: 63017
	{
		// Fields
		public int Pid; // 0x00
		public string ProcessName; // 0x08
		public long Bytes; // 0x10
	
		// Properties
		public double MB { get; } // 0x00000001811CDA80-0x00000001811CDE50 
	}

	public static class VideoMemoryStatus // TypeDefIndex: 63022
	{
		// Fields
		private static int PDH_FMT_LARGE; // 0x00
		private static long PDH_MORE_DATA; // 0x08
		private const string Command = "powershell.exe -command \"Get-Counter -Counter \'\\GPU Process Memory(*)\\Dedicated Usage\'\""; // Metadata: 0x02352477
		private static int s_currentPid; // 0x10
		private const uint PROCESS_QUERY_LIMITED_INFORMATION = 4096; // Metadata: 0x023524D0
		private static readonly char[] s_pathSep; // 0x18
	
		// Nested types
		private struct PROCESS_MEMORY_COUNTERS // TypeDefIndex: 63018
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
	
		private struct PDH_FMT_COUNTERVALUE // TypeDefIndex: 63019
		{
			// Fields
			public int CStatus; // 0x00
			public long largeValue; // 0x08
		}
	
		private struct PDH_FMT_COUNTERVALUE_ITEM // TypeDefIndex: 63020
		{
			// Fields
			public IntPtr szName; // 0x00
			public PDH_FMT_COUNTERVALUE FmtValue; // 0x08
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 63021
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<KeyValuePair<int, long>> __9__21_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001811DBB20-0x00000001811DBE80
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetTopOtherProcessMemory_b__21_0(KeyValuePair<int, long> a, KeyValuePair<int, long> b); // 0x00000001811DB800-0x00000001811DBB20
		}
	
		// Constructors
		static VideoMemoryStatus(); // 0x0000000184D57860-0x0000000184D57EE0
	
		// Methods
		private static extern bool GetProcessMemoryInfo(IntPtr hProcess, out PROCESS_MEMORY_COUNTERS counters, uint size); // 0x0000000186380D78-0x0000000186380E14
		private static extern long PdhOpenQuery(IntPtr szDataSource, IntPtr dwUserData, out IntPtr phQuery); // 0x000000018449CC20-0x000000018449CC90
		private static extern long PdhAddCounter(IntPtr hQuery, string szFullCounterPath, UIntPtr dwUserData, out IntPtr phCounter); // 0x0000000186380E14-0x0000000186380EC8
		private static extern long PdhAddEnglishCounter(IntPtr hQuery, string szFullCounterPath, UIntPtr dwUserData, out IntPtr phCounter); // 0x000000018449CC90-0x000000018449CD10
		private static extern long PdhCollectQueryData(IntPtr hQuery); // 0x000000018449CD10-0x000000018449CD70
		private static extern long PdhGetFormattedCounterArray(IntPtr hQuery, int dwFormat, ref uint dwBufferSize, ref uint dwItemCount, IntPtr itemBuffer); // 0x000000018449CD70-0x000000018449CDF0
		private static extern int PdhCloseQuery(IntPtr hQuery); // 0x000000018449CDF0-0x000000018449CE50
		public static ValueTuple<long, long> GetDedicatedMemoryStatus(); // 0x00000001839B9CB0-0x00000001839B9D40
		public static ValueTuple<long, long> GetSharedMemoryStatus(); // 0x00000001839B9C20-0x00000001839B9CB0
		public static ValueTuple<long, long> GetCommittedMemoryStatus(); // 0x00000001839B9B90-0x00000001839B9C20
		private static ValueTuple<long, long> GetMemoryStatus(string type); // 0x00000001835CADF0-0x00000001835CC400
		private static Dictionary<int, long> CollectByPid(string type); // 0x00000001811DBF60-0x00000001811DDEF0
		public static List<GpuProcMemEntry> GetDedicatedTopOthers(int topN = 5 /* Metadata: 0x02352474 */); // 0x00000001811DF340-0x00000001811DFC60
		public static List<GpuProcMemEntry> GetSharedTopOthers(int topN = 5 /* Metadata: 0x02352475 */); // 0x00000001811DFC60-0x00000001811E0580
		public static List<GpuProcMemEntry> GetCommittedTopOthers(int topN = 5 /* Metadata: 0x02352476 */); // 0x00000001811DDEF0-0x00000001811DE810
		private static List<GpuProcMemEntry> GetTopOtherProcessMemory(string type, int topN); // 0x00000001811E0580-0x00000001811E3410
		private static int GetCurrentProcessIdCached(); // 0x00000001811DE810-0x00000001811DF340
		private static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId); // 0x00000001811E3410-0x00000001811E34F0
		private static extern bool QueryFullProcessImageNameW(IntPtr hProcess, int dwFlags, IntPtr lpExeName, ref int lpdwSize); // 0x00000001811E34F0-0x00000001811E35E0
		private static extern bool CloseHandle(IntPtr hObject); // 0x00000001811DBE80-0x00000001811DBF60
		private static string ResolveProcessName(int pid); // 0x00000001811E35E0-0x00000001811E4B90
	}

	[UnityEngine.Scripting.Preserve]
	public static class WinMemoryInfo // TypeDefIndex: 63023
	{
		// Fields
		private const uint RSMB = 1381190978; // Metadata: 0x023524D2
		private const byte SMBIOS_TYPE_MEMORY_DEVICE = 17; // Metadata: 0x023524D7
		private const byte SMBIOS_TYPE_END_OF_TABLE = 127; // Metadata: 0x023524D8
		private static SystemMemoryInfo? s_cachedInfo; // 0x00
	
		// Methods
		private static extern uint GetSystemFirmwareTable(uint FirmwareTableProviderSignature, uint FirmwareTableID, IntPtr pFirmwareTableBuffer, uint BufferSize); // 0x0000000183826090-0x0000000183826100
		public static SystemMemoryInfo GetSystemMemoryInfo(); // 0x0000000183824D10-0x0000000183824E60
		private static SystemMemoryInfo ParseSmbiosMemoryInfo(); // 0x0000000183824EC0-0x0000000183825E90
		private static unsafe ushort ReadUInt16(byte* ptr, int offset); // 0x0000000184D864A0-0x0000000184D864C0
		private static unsafe uint ReadUInt32(byte* ptr, int offset); // 0x0000000184D864C0-0x0000000184D864F0
		private static unsafe string GetSmbiosString(byte* stringArea, byte index, byte* tableEnd); // 0x0000000183825E90-0x0000000183825F70
		private static string GetMemoryTypeName(byte code); // 0x0000000183825F70-0x0000000183826090
		public static void Test(); // 0x0000000186380EC8-0x0000000186380F08
	}

	public static class WinPerfMonitor // TypeDefIndex: 63026
	{
		// Fields
		private const int PDH_FMT_DOUBLE = 512; // Metadata: 0x023524D9
		private const long PDH_MORE_DATA = 2147485650; // Metadata: 0x023524DB
		private const int PDH_CSTATUS_NEW_DATA = 1; // Metadata: 0x023524E3
		private const string COUNTER_CPU_UTILITY = "\\Processor Information(_Total)\\% Processor Utility"; // Metadata: 0x023524E4
		private const string COUNTER_CPU_TIME = "\\Processor(_Total)\\% Processor Time"; // Metadata: 0x02352517
		private const string COUNTER_CPU_PERFORMANCE = "\\Processor Information(_Total)\\% Processor Performance"; // Metadata: 0x0235253B
		private const string COUNTER_CPU_FREQUENCY = "\\Processor Information(_Total)\\Processor Frequency"; // Metadata: 0x02352572
		private static IntPtr s_query; // 0x00
		private static IntPtr s_cpuUsageCounter; // 0x08
		private static IntPtr s_cpuPerformanceCounter; // 0x10
		private static IntPtr s_cpuFrequencyCounter; // 0x18
		private static IntPtr s_gpuUsageCounter; // 0x20
		private static bool s_inited; // 0x28
		private static bool s_initFailed; // 0x29
		private static bool s_firstCollectDone; // 0x2A
	
		// Nested types
		private struct PDH_FMT_COUNTERVALUE_DOUBLE // TypeDefIndex: 63024
		{
			// Fields
			public int CStatus; // 0x00
			public double doubleValue; // 0x08
		}
	
		private struct PDH_FMT_COUNTERVALUE_ITEM_DOUBLE // TypeDefIndex: 63025
		{
			// Fields
			public IntPtr szName; // 0x00
			public PDH_FMT_COUNTERVALUE_DOUBLE FmtValue; // 0x08
		}
	
		// Constructors
		static WinPerfMonitor(); // 0x00000001811E9520-0x00000001811E9890
	
		// Methods
		private static extern long PdhOpenQuery(IntPtr szDataSource, IntPtr dwUserData, out IntPtr phQuery); // 0x00000001811E4EF0-0x00000001811E4FD0
		private static extern long PdhAddEnglishCounter(IntPtr hQuery, string szFullCounterPath, UIntPtr dwUserData, out IntPtr phCounter); // 0x00000001811E4B90-0x00000001811E4C40
		private static extern long PdhCollectQueryData(IntPtr hQuery); // 0x00000001811E4CD0-0x00000001811E4D60
		private static extern long PdhGetFormattedCounterValue(IntPtr hCounter, int dwFormat, IntPtr lpdwType, out PDH_FMT_COUNTERVALUE_DOUBLE pValue); // 0x00000001811E4E10-0x00000001811E4EF0
		private static extern long PdhGetFormattedCounterArray(IntPtr hCounter, int dwFormat, ref uint dwBufferSize, ref uint dwItemCount, IntPtr itemBuffer); // 0x00000001811E4D60-0x00000001811E4E10
		private static extern int PdhCloseQuery(IntPtr hQuery); // 0x00000001811E4C40-0x00000001811E4CD0
		public static bool TrySample(out PcPerfInfo info); // 0x00000001811E4FD0-0x00000001811E5C90
		private static bool _EnsureInited(); // 0x00000001811E5C90-0x00000001811E7290
		private static void _Shutdown(); // 0x00000001811E8DC0-0x00000001811E9520
		private static double _ReadCounterValue(IntPtr counter); // 0x00000001811E7290-0x00000001811E7BC0
		private static float _ReadGpuUsage(); // 0x00000001811E7BC0-0x00000001811E8DC0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63027
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37950-0x0000000184D379C0
	
		// Methods
		public double __Gen_Wrap_0(ref DiskSpaceInfo P0); // 0x000000018637FE6C-0x000000018637FFD8
		public double __Gen_Wrap_1(ref MemoryDimmInfo P0); // 0x000000018637FFD8-0x0000000186380130
		public double __Gen_Wrap_2(ref SystemMemoryInfo P0); // 0x0000000186380130-0x000000018638029C
		public void __Gen_Wrap_3(); // 0x00000001863761FC-0x0000000186376284
		public bool __Gen_Wrap_4(); // 0x00000001863623A8-0x0000000186362454
		public long __Gen_Wrap_5(); // 0x000000018635FE78-0x000000018635FF24
		public int __Gen_Wrap_6(); // 0x00000001863621C4-0x0000000186362270
		public Dictionary<int, long> __Gen_Wrap_7(object P0); // 0x00000001811D6230-0x00000001811D6B70
		public ValueTuple<long, long> __Gen_Wrap_8(object P0); // 0x00000001811D6B70-0x00000001811D7450
		public ValueTuple<long, long> __Gen_Wrap_9(); // 0x00000001811D7450-0x00000001811D7C60
		public string __Gen_Wrap_11(int P0); // 0x00000001811CDE50-0x00000001811CE6D0
		public List<GpuProcMemEntry> __Gen_Wrap_12(object P0, int P1); // 0x00000001811CE6D0-0x00000001811CF070
		public List<GpuProcMemEntry> __Gen_Wrap_13(int P0); // 0x00000001811CF070-0x00000001811CF8F0
		public string __Gen_Wrap_14(object P0); // 0x00000001811CF8F0-0x00000001811D0220
		public double __Gen_Wrap_15(ref GpuProcMemEntry P0); // 0x00000001811D0220-0x00000001811D0E30
		public void __Gen_Wrap_16(object P0, object P1, object P2); // 0x00000001811D0E30-0x00000001811D1280
		public string __Gen_Wrap_17(); // 0x00000001811D1280-0x00000001811D1AC0
		public float __Gen_Wrap_18(); // 0x00000001811D1AC0-0x00000001811D1C90
		public IntPtr __Gen_Wrap_19(object P0); // 0x00000001811D1C90-0x00000001811D1F50
		public bool __Gen_Wrap_20(object P0); // 0x00000001811D1F50-0x00000001811D2210
		public bool __Gen_Wrap_21(object P0, out DiskSpaceInfo P1); // 0x00000001811D2210-0x00000001811D2BF0
		public DiskSpaceInfo __Gen_Wrap_22(); // 0x00000001811D2BF0-0x00000001811D3410
		public DiskSpaceInfo[] __Gen_Wrap_24(); // 0x00000001811D3410-0x00000001811D3C50
		public double __Gen_Wrap_25(IntPtr P0); // 0x00000001811D3C50-0x00000001811D3E50
		public bool __Gen_Wrap_26(out PcPerfInfo P0); // 0x00000001811D3E50-0x00000001811D46E0
		public string __Gen_Wrap_27(byte P0); // 0x00000001811D46E0-0x00000001811D4F60
		public SystemMemoryInfo __Gen_Wrap_28(); // 0x00000001811D4F60-0x00000001811D5780
		public double __Gen_Wrap_29(); // 0x00000001811D5780-0x00000001811D5950
		public bool __Gen_Wrap_30(out DiskSpaceInfo P0); // 0x00000001811D5950-0x00000001811D6230
	}

	public class WrappersManagerImpl // TypeDefIndex: 63028
	{
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000186380F08-0x000000018638231C
		public static bool IsPatched(int id); // 0x00000001839BACA0-0x00000001839BACF0
	}
}
