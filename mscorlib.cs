/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Security.Util;
using System.Text;
using System.Threading;
using Internal.Runtime.Augments;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

// Image 6: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 38519-40359
[assembly: AssemblyCompany("Mono development team")]
[assembly: AssemblyCopyright("(c) Various Mono authors")]
[assembly: AssemblyDefaultAlias("mscorlib.dll")]
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyDescription("mscorlib.dll")]
[assembly: AssemblyFileVersion("4.0.30319.17020")]
[assembly: AssemblyInformationalVersion("4.0.30319.17020")]
[assembly: AssemblyKeyFile("../ecma.pub")]
[assembly: AssemblyProduct("Mono Common Language Infrastructure")]
[assembly: AssemblyTitle("mscorlib.dll")]
[assembly: CLSCompliant(true)]
[assembly: ComCompatibleVersion(1, 0, 3300, 0)]
[assembly: CompilationRelaxations(CompilationRelaxations.NoStringInterning)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: DefaultDependency(LoadHint.Always)]
[assembly: Guid("BED7F4EA-1A96-11D2-8F08-00A0C9A6186D")]
[assembly: InternalsVisibleTo("System, PublicKey=00240000048000009400000006020000002400005253413100040000010001008D56C76F9E8649383049F383C44BE0EC204181822A6C31CF5EB7EF486944D032188EA1D3920763712CCB12D75FB77E9811149E6148E5D32FBAAB37611C1878DDC19E20EF135D0CB2CFF2BFEC3D115810C3D9069638FE4BE215DBF795861920E5AB6F7DB2E2CEEF136AC23D5DD2BF031700AEC232F6C6B1C785B4305C123B37AB")]
[assembly: InternalsVisibleTo("System.Core, PublicKey=00240000048000009400000006020000002400005253413100040000010001008D56C76F9E8649383049F383C44BE0EC204181822A6C31CF5EB7EF486944D032188EA1D3920763712CCB12D75FB77E9811149E6148E5D32FBAAB37611C1878DDC19E20EF135D0CB2CFF2BFEC3D115810C3D9069638FE4BE215DBF795861920E5AB6F7DB2E2CEEF136AC23D5DD2BF031700AEC232F6C6B1C785B4305C123B37AB")]
[assembly: InternalsVisibleTo("System.Security, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly: InternalsVisibleTo("System.Runtime.WindowsRuntime, PublicKey=00000000000000000400000000000000")]
[assembly: InternalsVisibleTo("System.Runtime.WindowsRuntime.UI.Xaml, PublicKey=00000000000000000400000000000000")]
[assembly: InternalsVisibleTo("System.Net.Http, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SatelliteContractVersion("4.0.0.0")]
[assembly: StringFreezing]

internal static class Interop // TypeDefIndex: 38560
{
	// Nested types
	internal static class Kernel32 // TypeDefIndex: 38541
	{
		// Fields
		private static bool useUWPFallback; // 0x00

		// Nested types
		internal struct WIN32_FIND_DATA // TypeDefIndex: 38522
		{
			// Fields
			internal uint dwFileAttributes; // 0x00
			internal FILE_TIME ftCreationTime; // 0x04
			internal FILE_TIME ftLastAccessTime; // 0x0C
			internal FILE_TIME ftLastWriteTime; // 0x14
			internal uint nFileSizeHigh; // 0x1C
			internal uint nFileSizeLow; // 0x20
			internal uint dwReserved0; // 0x24
			internal uint dwReserved1; // 0x28
			private unsafe fixed /* 0x00000000-0x00000000 */ char _cFileName[0]; // 0x2C
			private unsafe fixed /* 0x00000000-0x00000000 */ char _cAlternateFileName[0]; // 0x234

			// Properties
			internal ReadOnlySpan<char> cFileName { get => default; } // 0x000000018913F180-0x000000018913F1DC 

			// Methods
			internal void SetFileName(string fileName) {} // 0x000000018913F0E0-0x000000018913F180
		}

		internal struct REG_TZI_FORMAT // TypeDefIndex: 38523
		{
			// Fields
			internal int Bias; // 0x00
			internal int StandardBias; // 0x04
			internal int DaylightBias; // 0x08
			internal SYSTEMTIME StandardDate; // 0x0C
			internal SYSTEMTIME DaylightDate; // 0x1C

			// Constructors
			internal REG_TZI_FORMAT([IsReadOnly] in TIME_ZONE_INFORMATION tzi) {
				Bias = default;
				StandardBias = default;
				DaylightBias = default;
				StandardDate = default;
				DaylightDate = default;
			} // 0x0000000182C984E0-0x0000000182C98510
		}

		internal struct SYSTEMTIME // TypeDefIndex: 38524
		{
			// Fields
			internal ushort Year; // 0x00
			internal ushort Month; // 0x02
			internal ushort DayOfWeek; // 0x04
			internal ushort Day; // 0x06
			internal ushort Hour; // 0x08
			internal ushort Minute; // 0x0A
			internal ushort Second; // 0x0C
			internal ushort Milliseconds; // 0x0E

			// Methods
			internal bool Equals([IsReadOnly] in SYSTEMTIME other) => default; // 0x000000018913860C-0x0000000189138660
		}

		internal struct TIME_DYNAMIC_ZONE_INFORMATION // TypeDefIndex: 38528
		{
			// Fields
			internal int Bias; // 0x00
			internal unsafe fixed /* 0x00000000-0x00000000 */ char StandardName[0]; // 0x04
			internal SYSTEMTIME StandardDate; // 0x44
			internal int StandardBias; // 0x54
			internal unsafe fixed /* 0x00000000-0x00000000 */ char DaylightName[0]; // 0x58
			internal SYSTEMTIME DaylightDate; // 0x98
			internal int DaylightBias; // 0xA8
			internal unsafe fixed /* 0x00000000-0x00000000 */ char TimeZoneKeyName[0]; // 0xAC
			internal byte DynamicDaylightTimeDisabled; // 0x1AC

			// Methods
			internal string GetTimeZoneKeyName() => default; // 0x000000018426F6CC-0x000000018426F6DC
		}

		internal struct TIME_ZONE_INFORMATION // TypeDefIndex: 38531
		{
			// Fields
			internal int Bias; // 0x00
			internal unsafe fixed /* 0x00000000-0x00000000 */ char StandardName[0]; // 0x04
			internal SYSTEMTIME StandardDate; // 0x44
			internal int StandardBias; // 0x54
			internal unsafe fixed /* 0x00000000-0x00000000 */ char DaylightName[0]; // 0x58
			internal SYSTEMTIME DaylightDate; // 0x98
			internal int DaylightBias; // 0xA8

			// Constructors
			internal unsafe TIME_ZONE_INFORMATION([IsReadOnly] in TIME_DYNAMIC_ZONE_INFORMATION dtzi) {
				Bias = default;
				StandardName = default;
				StandardDate = default;
				StandardBias = default;
				DaylightName = default;
				DaylightDate = default;
				DaylightBias = default;
			} // 0x0000000183D6E8E0-0x0000000183D6EA00

			// Methods
			internal string GetStandardName() => default; // 0x0000000184272FDC-0x0000000184272FE8
			internal string GetDaylightName() => default; // 0x0000000184272FD0-0x0000000184272FDC
		}

		internal struct COPYFILE2_EXTENDED_PARAMETERS // TypeDefIndex: 38532
		{
			// Fields
			internal uint dwSize; // 0x00
			internal uint dwCopyFlags; // 0x04
			internal IntPtr pfCancel; // 0x08
			internal IntPtr pProgressRoutine; // 0x10
			internal IntPtr pvCallbackContext; // 0x18
		}

		internal enum FILE_INFO_BY_HANDLE_CLASS : uint // TypeDefIndex: 38533
		{
			FileBasicInfo = 0,
			FileStandardInfo = 1,
			FileNameInfo = 2,
			FileRenameInfo = 3,
			FileDispositionInfo = 4,
			FileAllocationInfo = 5,
			FileEndOfFileInfo = 6,
			FileStreamInfo = 7,
			FileCompressionInfo = 8,
			FileAttributeTagInfo = 9,
			FileIdBothDirectoryInfo = 10,
			FileIdBothDirectoryRestartInfo = 11,
			FileIoPriorityHintInfo = 12,
			FileRemoteProtocolInfo = 13,
			FileFullDirectoryInfo = 14,
			FileFullDirectoryRestartInfo = 15
		}

		internal struct FILE_TIME // TypeDefIndex: 38534
		{
			// Fields
			internal uint dwLowDateTime; // 0x00
			internal uint dwHighDateTime; // 0x04

			// Methods
			internal long ToTicks() => default; // 0x0000000183D6E820-0x0000000183D6E830
			internal DateTimeOffset ToDateTimeOffset() => default; // 0x0000000189136118-0x000000018913618C
		}

		internal enum FINDEX_INFO_LEVELS : uint // TypeDefIndex: 38535
		{
			FindExInfoStandard = 0,
			FindExInfoBasic = 1,
			FindExInfoMaxInfoLevel = 2
		}

		internal enum FINDEX_SEARCH_OPS : uint // TypeDefIndex: 38536
		{
			FindExSearchNameMatch = 0,
			FindExSearchLimitToDirectories = 1,
			FindExSearchLimitToDevices = 2,
			FindExSearchMaxSearchOp = 3
		}

		internal enum GET_FILEEX_INFO_LEVELS : uint // TypeDefIndex: 38537
		{
			GetFileExInfoStandard = 0,
			GetFileExMaxInfoLevel = 1
		}

		internal struct SECURITY_ATTRIBUTES // TypeDefIndex: 38538
		{
			// Fields
			internal uint nLength; // 0x00
			internal IntPtr lpSecurityDescriptor; // 0x08
			internal BOOL bInheritHandle; // 0x10
		}

		internal struct FILE_BASIC_INFO // TypeDefIndex: 38539
		{
			// Fields
			internal long CreationTime; // 0x00
			internal long LastAccessTime; // 0x08
			internal long LastWriteTime; // 0x10
			internal long ChangeTime; // 0x18
			internal uint FileAttributes; // 0x20
		}

		internal struct WIN32_FILE_ATTRIBUTE_DATA // TypeDefIndex: 38540
		{
			// Fields
			internal int dwFileAttributes; // 0x00
			internal FILE_TIME ftCreationTime; // 0x04
			internal FILE_TIME ftLastAccessTime; // 0x0C
			internal FILE_TIME ftLastWriteTime; // 0x14
			internal uint nFileSizeHigh; // 0x1C
			internal uint nFileSizeLow; // 0x20

			// Methods
			internal void PopulateFrom(ref WIN32_FIND_DATA findData) {} // 0x0000000183D6EA20-0x0000000183D6EA50
		}

		// Methods
		internal static int CopyFileUWP(string src, string dst, bool failIfExists) => default; // 0x00000001891363AC-0x0000000189136470
		internal static int CopyFile(string src, string dst, bool failIfExists) => default; // 0x0000000189136470-0x00000001891365BC
		internal static extern bool DeleteVolumeMountPointPrivate(string mountPoint); // 0x00000001891366E4-0x000000018913676C
		internal static bool DeleteVolumeMountPoint(string mountPoint) => default; // 0x000000018913676C-0x0000000189136860
		internal static extern bool FreeLibrary(IntPtr hModule); // 0x00000001822C6BF0-0x00000001822C6CA0
		internal static extern SafeLibraryHandle LoadLibraryEx(string libFilename, IntPtr reserved, int flags); // 0x0000000182A4DFC0-0x0000000182A4E080
		internal static extern bool GetFileMUIPath(uint flags, string filePath, out StringBuilder language, ref int languageLength, out StringBuilder fileMuiPath, ref int fileMuiPathLength, ref long enumerator); // 0x0000000182A4E190-0x0000000182A4E300
		internal static extern uint GetDynamicTimeZoneInformation(out TIME_DYNAMIC_ZONE_INFORMATION pTimeZoneInformation); // 0x00000001822C6CA0-0x00000001822C6D40
		internal static extern uint GetTimeZoneInformation(out TIME_ZONE_INFORMATION lpTimeZoneInformation); // 0x00000001822C7EE0-0x00000001822C7F80
		internal static extern bool CloseHandle(IntPtr handle); // 0x00000001826CE6E0-0x00000001826CE790
		internal static extern int CopyFile2(string pwszExistingFileName, string pwszNewFileName, ref COPYFILE2_EXTENDED_PARAMETERS pExtendedParameters); // 0x000000018913618C-0x0000000189136230
		private static extern bool CopyFileExPrivate(string src, string dst, IntPtr progressRoutine, IntPtr progressData, ref int cancel, int flags); // 0x0000000189136230-0x000000018913630C
		internal static bool CopyFileEx(string src, string dst, IntPtr progressRoutine, IntPtr progressData, ref int cancel, int flags) => default; // 0x000000018913630C-0x00000001891363AC
		private static extern bool CreateDirectoryPrivate(string path, ref SECURITY_ATTRIBUTES lpSecurityAttributes); // 0x0000000182687CF0-0x0000000182687D60
		internal static bool CreateDirectory(string path, ref SECURITY_ATTRIBUTES lpSecurityAttributes) => default; // 0x0000000182687B70-0x0000000182687BE0
		private static unsafe extern IntPtr CreateFilePrivate(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, SECURITY_ATTRIBUTES* securityAttrs, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile); // 0x00000001836F85B0-0x00000001836F8650
		internal static SafeFileHandle CreateFile(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes) => default; // 0x00000001891365BC-0x00000001891366E4
		internal static IntPtr CreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes) => default; // 0x00000001836F8510-0x00000001836F85B0
		private static extern bool DeleteFilePrivate(string path); // 0x000000018295A070-0x000000018295A0D0
		internal static bool DeleteFile(string path) => default; // 0x000000018295A010-0x000000018295A070
		private static extern SafeFindHandle FindFirstFileExPrivate(string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, ref WIN32_FIND_DATA lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, int dwAdditionalFlags); // 0x0000000189136860-0x000000018913696C
		internal static SafeFindHandle FindFirstFile(string fileName, ref WIN32_FIND_DATA data) => default; // 0x000000018913696C-0x00000001891369DC
		internal static extern bool FindNextFile(SafeFindHandle hndFindFile, ref WIN32_FIND_DATA lpFindFileData); // 0x00000001891369DC-0x0000000189136AB8
		private static unsafe extern int FormatMessage(int dwFlags, IntPtr lpSource, uint dwMessageId, int dwLanguageId, char* lpBuffer, int nSize, IntPtr[] arguments); // 0x0000000189136AB8-0x0000000189136B94
		internal static string GetMessage(int errorCode) => default; // 0x0000000189136D88-0x0000000189136D94
		internal static string GetMessage(IntPtr moduleHandle, int errorCode) => default; // 0x0000000189136C40-0x0000000189136D88
		private static bool TryGetErrorMessage(IntPtr moduleHandle, int errorCode, Span<char> buffer, out string errorMsg) {
			errorMsg = default;
			return default;
		} // 0x0000000189137268-0x0000000189137438
		private static extern bool GetFileAttributesExPrivate(string name, GET_FILEEX_INFO_LEVELS fileInfoLevel, ref WIN32_FILE_ATTRIBUTE_DATA lpFileInformation); // 0x0000000182683BF0-0x0000000182683C90
		internal static bool GetFileAttributesEx(string name, GET_FILEEX_INFO_LEVELS fileInfoLevel, ref WIN32_FILE_ATTRIBUTE_DATA lpFileInformation) => default; // 0x0000000182683170-0x00000001826832F0
		public static extern bool GetFileInformationByHandleEx(IntPtr hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, IntPtr lpFileInformation, uint dwBufferSize); // 0x0000000189136B94-0x0000000189136C40
		private static extern bool MoveFileExPrivate(string src, string dst, uint flags); // 0x0000000189136D94-0x0000000189136E44
		internal static bool MoveFile(string src, string dst) => default; // 0x0000000189136E44-0x0000000189136EB0
		private static extern bool RemoveDirectoryPrivate(string path); // 0x0000000189136EB0-0x0000000189136F38
		internal static bool RemoveDirectory(string path) => default; // 0x0000000189136F38-0x0000000189136F84
		private static extern bool ReplaceFilePrivate(string replacedFileName, string replacementFileName, string backupFileName, int dwReplaceFlags, IntPtr lpExclude, IntPtr lpReserved); // 0x0000000189136F84-0x0000000189137068
		internal static bool ReplaceFile(string replacedFileName, string replacementFileName, string backupFileName, int dwReplaceFlags, IntPtr lpExclude, IntPtr lpReserved) => default; // 0x0000000189137068-0x0000000189137114
		private static extern bool SetFileAttributesPrivate(string name, int attr); // 0x0000000183399F90-0x000000018339A000
		internal static bool SetFileAttributes(string name, int attr) => default; // 0x0000000183399F20-0x0000000183399F90
		internal static extern bool SetFileInformationByHandle(SafeFileHandle hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, ref FILE_BASIC_INFO lpFileInformation, uint dwBufferSize); // 0x0000000189137114-0x0000000189137204
		internal static bool SetFileTime(SafeFileHandle hFile, long creationTime = -1 /* Metadata: 0x01F9DE6A */, long lastAccessTime = -1 /* Metadata: 0x01F9DE72 */, long lastWriteTime = -1 /* Metadata: 0x01F9DE7A */, long changeTime = -1 /* Metadata: 0x01F9DE82 */, uint fileAttributes = 0 /* Metadata: 0x01F9DE8A */) => default; // 0x0000000189137204-0x0000000189137268
		internal static extern bool SetThreadErrorMode(uint dwNewMode, out uint lpOldMode); // 0x0000000182683C90-0x0000000182683D30
	}

	internal class BCrypt // TypeDefIndex: 38543
	{
		// Nested types
		internal enum NTSTATUS : uint // TypeDefIndex: 38542
		{
			STATUS_SUCCESS = 0,
			STATUS_INVALID_PARAMETER = 3221225485,
			STATUS_NO_MEMORY = 3221225495,
			STATUS_NOT_FOUND = 3221226021
		}

		// Constructors
		public BCrypt() {} // Dummy constructor

		// Methods
		internal static unsafe extern NTSTATUS BCryptGenRandom(IntPtr hAlgorithm, byte* pbBuffer, int cbBuffer, int dwFlags); // 0x0000000182A6BB50-0x0000000182A6BBB0
	}

	internal class User32 // TypeDefIndex: 38544
	{
		// Constructors
		public User32() {} // Dummy constructor

		// Methods
		internal static extern int LoadString(SafeLibraryHandle handle, int id, out StringBuilder buffer, int bufferLength); // 0x0000000182A4E080-0x0000000182A4E190
	}

	internal enum BOOL // TypeDefIndex: 38545
	{
		FALSE = 0,
		TRUE = 1
	}

	internal enum BOOLEAN : byte // TypeDefIndex: 38546
	{
		FALSE = 0,
		TRUE = 1
	}

	internal struct LongFileTime // TypeDefIndex: 38547
	{
		// Fields
		internal long TicksSince1601; // 0x00
	}

	internal struct UNICODE_STRING // TypeDefIndex: 38548
	{
		// Fields
		internal ushort Length; // 0x00
		internal ushort MaximumLength; // 0x02
		internal IntPtr Buffer; // 0x08
	}

	internal class NtDll // TypeDefIndex: 38558
	{
		// Nested types
		public struct FILE_FULL_DIR_INFORMATION // TypeDefIndex: 38549
		{
			// Fields
			public uint NextEntryOffset; // 0x00
			public uint FileIndex; // 0x04
			public LongFileTime CreationTime; // 0x08
			public LongFileTime LastAccessTime; // 0x10
			public LongFileTime LastWriteTime; // 0x18
			public LongFileTime ChangeTime; // 0x20
			public long EndOfFile; // 0x28
			public long AllocationSize; // 0x30
			public FileAttributes FileAttributes; // 0x38
			public uint FileNameLength; // 0x3C
			public uint EaSize; // 0x40
			private char _fileName; // 0x44

			// Properties
			public ReadOnlySpan<char> FileName { get => default; } // 0x000000018318AD40-0x000000018318ADA0 

			// Methods
			public static unsafe FILE_FULL_DIR_INFORMATION* GetNextInfo(FILE_FULL_DIR_INFORMATION* info) => default; // 0x0000000183798BC0-0x0000000183798BE0
		}

		public enum FILE_INFORMATION_CLASS : uint // TypeDefIndex: 38550
		{
			FileDirectoryInformation = 1,
			FileFullDirectoryInformation = 2,
			FileBothDirectoryInformation = 3,
			FileBasicInformation = 4,
			FileStandardInformation = 5,
			FileInternalInformation = 6,
			FileEaInformation = 7,
			FileAccessInformation = 8,
			FileNameInformation = 9,
			FileRenameInformation = 10,
			FileLinkInformation = 11,
			FileNamesInformation = 12,
			FileDispositionInformation = 13,
			FilePositionInformation = 14,
			FileFullEaInformation = 15,
			FileModeInformation = 16,
			FileAlignmentInformation = 17,
			FileAllInformation = 18,
			FileAllocationInformation = 19,
			FileEndOfFileInformation = 20,
			FileAlternateNameInformation = 21,
			FileStreamInformation = 22,
			FilePipeInformation = 23,
			FilePipeLocalInformation = 24,
			FilePipeRemoteInformation = 25,
			FileMailslotQueryInformation = 26,
			FileMailslotSetInformation = 27,
			FileCompressionInformation = 28,
			FileObjectIdInformation = 29,
			FileCompletionInformation = 30,
			FileMoveClusterInformation = 31,
			FileQuotaInformation = 32,
			FileReparsePointInformation = 33,
			FileNetworkOpenInformation = 34,
			FileAttributeTagInformation = 35,
			FileTrackingInformation = 36,
			FileIdBothDirectoryInformation = 37,
			FileIdFullDirectoryInformation = 38,
			FileValidDataLengthInformation = 39,
			FileShortNameInformation = 40,
			FileIoCompletionNotificationInformation = 41,
			FileIoStatusBlockRangeInformation = 42,
			FileIoPriorityHintInformation = 43,
			FileSfioReserveInformation = 44,
			FileSfioVolumeInformation = 45,
			FileHardLinkInformation = 46,
			FileProcessIdsUsingFileInformation = 47,
			FileNormalizedNameInformation = 48,
			FileNetworkPhysicalNameInformation = 49,
			FileIdGlobalTxDirectoryInformation = 50,
			FileIsRemoteDeviceInformation = 51,
			FileUnusedInformation = 52,
			FileNumaNodeInformation = 53,
			FileStandardLinkInformation = 54,
			FileRemoteProtocolInformation = 55,
			FileRenameInformationBypassAccessCheck = 56,
			FileLinkInformationBypassAccessCheck = 57,
			FileVolumeNameInformation = 58,
			FileIdInformation = 59,
			FileIdExtdDirectoryInformation = 60,
			FileReplaceCompletionInformation = 61,
			FileHardLinkFullIdInformation = 62,
			FileIdExtdBothDirectoryInformation = 63,
			FileDispositionInformationEx = 64,
			FileRenameInformationEx = 65,
			FileRenameInformationExBypassAccessCheck = 66,
			FileDesiredStorageClassInformation = 67,
			FileStatInformation = 68
		}

		public struct IO_STATUS_BLOCK // TypeDefIndex: 38552
		{
			// Fields
			public IO_STATUS Status; // 0x00
			public IntPtr Information; // 0x08

			// Nested types
			public struct IO_STATUS // TypeDefIndex: 38551
			{
				// Fields
				public uint Status; // 0x00
				public IntPtr Pointer; // 0x00
			}
		}

		public struct OBJECT_ATTRIBUTES // TypeDefIndex: 38553
		{
			// Fields
			public uint Length; // 0x00
			public IntPtr RootDirectory; // 0x08
			public unsafe UNICODE_STRING* ObjectName; // 0x10
			public ObjectAttributes Attributes; // 0x18
			public unsafe void* SecurityDescriptor; // 0x20
			public unsafe void* SecurityQualityOfService; // 0x28

			// Constructors
			public unsafe OBJECT_ATTRIBUTES(UNICODE_STRING* objectName, ObjectAttributes attributes, IntPtr rootDirectory) {
				Length = default;
				RootDirectory = default;
				ObjectName = default;
				Attributes = default;
				SecurityDescriptor = default;
				SecurityQualityOfService = default;
			} // 0x0000000183D6E880-0x0000000183D6E8A0
		}

		[Flags]
		public enum ObjectAttributes : uint // TypeDefIndex: 38554
		{
			OBJ_INHERIT = 2,
			OBJ_PERMANENT = 16,
			OBJ_EXCLUSIVE = 32,
			OBJ_CASE_INSENSITIVE = 64,
			OBJ_OPENIF = 128,
			OBJ_OPENLINK = 256
		}

		public enum CreateDisposition : uint // TypeDefIndex: 38555
		{
			FILE_SUPERSEDE = 0,
			FILE_OPEN = 1,
			FILE_CREATE = 2,
			FILE_OPEN_IF = 3,
			FILE_OVERWRITE = 4,
			FILE_OVERWRITE_IF = 5
		}

		public enum CreateOptions : uint // TypeDefIndex: 38556
		{
			FILE_DIRECTORY_FILE = 1,
			FILE_WRITE_THROUGH = 2,
			FILE_SEQUENTIAL_ONLY = 4,
			FILE_NO_INTERMEDIATE_BUFFERING = 8,
			FILE_SYNCHRONOUS_IO_ALERT = 16,
			FILE_SYNCHRONOUS_IO_NONALERT = 32,
			FILE_NON_DIRECTORY_FILE = 64,
			FILE_CREATE_TREE_CONNECTION = 128,
			FILE_COMPLETE_IF_OPLOCKED = 256,
			FILE_NO_EA_KNOWLEDGE = 512,
			FILE_RANDOM_ACCESS = 2048,
			FILE_DELETE_ON_CLOSE = 4096,
			FILE_OPEN_BY_FILE_ID = 8192,
			FILE_OPEN_FOR_BACKUP_INTENT = 16384,
			FILE_NO_COMPRESSION = 32768,
			FILE_OPEN_REQUIRING_OPLOCK = 65536,
			FILE_DISALLOW_EXCLUSIVE = 131072,
			FILE_SESSION_AWARE = 262144,
			FILE_RESERVE_OPFILTER = 1048576,
			FILE_OPEN_REPARSE_POINT = 2097152,
			FILE_OPEN_NO_RECALL = 4194304
		}

		[Flags]
		public enum DesiredAccess : uint // TypeDefIndex: 38557
		{
			FILE_READ_DATA = 1,
			FILE_LIST_DIRECTORY = 1,
			FILE_WRITE_DATA = 2,
			FILE_ADD_FILE = 2,
			FILE_APPEND_DATA = 4,
			FILE_ADD_SUBDIRECTORY = 4,
			FILE_CREATE_PIPE_INSTANCE = 4,
			FILE_READ_EA = 8,
			FILE_WRITE_EA = 16,
			FILE_EXECUTE = 32,
			FILE_TRAVERSE = 32,
			FILE_DELETE_CHILD = 64,
			FILE_READ_ATTRIBUTES = 128,
			FILE_WRITE_ATTRIBUTES = 256,
			DELETE = 65536,
			READ_CONTROL = 131072,
			STANDARD_RIGHTS_READ = 131072,
			STANDARD_RIGHTS_WRITE = 131072,
			STANDARD_RIGHTS_EXECUTE = 131072,
			WRITE_DAC = 262144,
			WRITE_OWNER = 524288,
			FILE_ALL_ACCESS = 983551,
			SYNCHRONIZE = 1048576,
			FILE_GENERIC_EXECUTE = 536870912,
			FILE_GENERIC_WRITE = 1073741824,
			FILE_GENERIC_READ = 2147483648
		}

		// Constructors
		public NtDll() {} // Dummy constructor

		// Methods
		private static unsafe extern int NtCreateFile(out IntPtr FileHandle, DesiredAccess DesiredAccess, ref OBJECT_ATTRIBUTES ObjectAttributes, out IO_STATUS_BLOCK IoStatusBlock, long* AllocationSize, FileAttributes FileAttributes, FileShare ShareAccess, CreateDisposition CreateDisposition, CreateOptions CreateOptions, void* EaBuffer, uint EaLength); // 0x0000000189137EA4-0x0000000189137F4C
		internal static ValueTuple<int, IntPtr> CreateFile(ReadOnlySpan<char> path, IntPtr rootDirectory, CreateDisposition createDisposition, DesiredAccess desiredAccess = DesiredAccess.SYNCHRONIZE | DesiredAccess.FILE_GENERIC_READ /* Metadata: 0x01F9DEB8 */, FileShare shareAccess = FileShare.None | FileShare.Read | FileShare.Write | FileShare.ReadWrite | FileShare.Delete /* Metadata: 0x01F9DEBD */, FileAttributes fileAttributes =  /* Metadata: 0x01F9DEBE */, CreateOptions createOptions = CreateOptions.FILE_SYNCHRONOUS_IO_NONALERT /* Metadata: 0x01F9DEBF */, ObjectAttributes objectAttributes = ObjectAttributes.OBJ_CASE_INSENSITIVE /* Metadata: 0x01F9DEC0 */) => default; // 0x0000000189137C98-0x0000000189137EA4
		public static unsafe extern int NtQueryDirectoryFile(IntPtr FileHandle, IntPtr Event, IntPtr ApcRoutine, IntPtr ApcContext, out IO_STATUS_BLOCK IoStatusBlock, IntPtr FileInformation, uint Length, FILE_INFORMATION_CLASS FileInformationClass, BOOLEAN ReturnSingleEntry, UNICODE_STRING* FileName, BOOLEAN RestartScan); // 0x000000018364C420-0x000000018364C4A0
		public static extern uint RtlNtStatusToDosError(int Status); // 0x0000000189137F4C-0x0000000189137FC4
	}

	internal class Advapi32 // TypeDefIndex: 38559
	{
		// Constructors
		public Advapi32() {} // Dummy constructor

		// Methods
		internal static extern int RegCloseKey(IntPtr hKey); // 0x0000000183C94AB0-0x0000000183C94B30
		internal static extern int RegEnumKeyEx(Microsoft.Win32.SafeHandles.SafeRegistryHandle hKey, int dwIndex, char[] lpName, ref int lpcbName, int[] lpReserved, out StringBuilder lpClass, int[] lpcbClass, long[] lpftLastWriteTime); // 0x0000000189134E20-0x0000000189134F88
		internal static extern int RegOpenKeyEx(Microsoft.Win32.SafeHandles.SafeRegistryHandle hKey, string lpSubKey, int ulOptions, int samDesired, out Microsoft.Win32.SafeHandles.SafeRegistryHandle hkResult); // 0x00000001831C9CD0-0x00000001831C9DF0
		internal static extern int RegQueryInfoKey(Microsoft.Win32.SafeHandles.SafeRegistryHandle hKey, out StringBuilder lpClass, int[] lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, int[] lpcbMaxSubKeyLen, int[] lpcbMaxClassLen, ref int lpcValues, int[] lpcbMaxValueNameLen, int[] lpcbMaxValueLen, int[] lpcbSecurityDescriptor, int[] lpftLastWriteTime); // 0x0000000189134F88-0x0000000189135150
		internal static extern int RegQueryValueEx(Microsoft.Win32.SafeHandles.SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, out byte[] lpData, ref int lpcbData); // 0x0000000182A4DAB0-0x0000000182A4DC00
		internal static extern int RegQueryValueEx(Microsoft.Win32.SafeHandles.SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, ref int lpData, ref int lpcbData); // 0x0000000189135150-0x0000000189135260
		internal static extern int RegQueryValueEx(Microsoft.Win32.SafeHandles.SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, ref long lpData, ref int lpcbData); // 0x0000000189135260-0x0000000189135370
		internal static extern int RegQueryValueEx(Microsoft.Win32.SafeHandles.SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, out char[] lpData, ref int lpcbData); // 0x0000000182A4E300-0x0000000182A4E450
	}

	// Methods
	internal static unsafe void GetRandomBytes(byte* buffer, int length) {} // 0x0000000182A6BB20-0x0000000182A6BB50
}

internal static class SR // TypeDefIndex: 38562
{
	// Methods
	internal static string GetString(string name, params object[] args) => default; // 0x00000001891385A8-0x0000000189138604
	internal static string GetString(CultureInfo culture, string name, params object[] args) => default; // 0x0000000189138604-0x000000018913860C
	internal static string GetString(string name) => default; // 0x000000018339AE90-0x000000018339AEA0
	internal static string Format(string resourceFormat, params object[] args) => default; // 0x00000001891384E4-0x000000018913854C
	internal static string Format(string resourceFormat, object p1) => default; // 0x000000018913854C-0x00000001891385A8
	internal static string Format(string resourceFormat, object p1, object p2) => default; // 0x0000000189138474-0x00000001891384E4
	internal static string Format(string resourceFormat, object p1, object p2, object p3) => default; // 0x00000001891383F4-0x0000000189138474
	internal static string GetResourceString(string str) => default; // 0x000000018339AE90-0x000000018339AEA0
}

namespace Internal.Cryptography
{
	internal static class Helpers // TypeDefIndex: 38664
	{
		// Methods
		private static char NibbleToHex(byte b) => default; // 0x00000001891421D0-0x00000001891421E8
	
		// Extension methods
		public static byte[] CloneByteArray(this byte[] src) => default; // 0x0000000189142180-0x00000001891421D0
		public static char[] ToHexArrayUpper(this byte[] bytes) => default; // 0x00000001891421E8-0x00000001891422E8
		public static string ToHexStringUpper(this byte[] bytes) => default; // 0x00000001891422E8-0x0000000189142304
	}
}

namespace Internal.Threading.Tasks.Tracing
{
	internal static class TaskTrace // TypeDefIndex: 38658
	{
		// Fields
		private static TaskTraceCallbacks s_callbacks; // 0x00
	
		// Properties
		public static bool Enabled { get; } // 0x00000001822B4690-0x00000001822B46E0 
	
		// Methods
		public static void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) {} // 0x000000018914B1C4-0x000000018914B230
		public static void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) {} // 0x000000018914B230-0x000000018914B29C
		public static void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) {} // 0x000000018914B29C-0x000000018914B308
		public static void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions) {} // 0x000000018914B11C-0x000000018914B1C4
	}
}

namespace Mono
{
	[Flags]
	internal enum CertificateImportFlags // TypeDefIndex: 38563
	{
		None = 0,
		DisableNativeBackend = 1,
		DisableAutomaticFallback = 2
	}

	internal static class DependencyInjector // TypeDefIndex: 38564
	{
		// Fields
		private static object locker; // 0x00
		private static ISystemDependencyProvider systemDependency; // 0x08
	
		// Properties
		internal static ISystemDependencyProvider SystemProvider { get; } // 0x0000000189135EBC-0x0000000189136118 
	
		// Constructors
		static DependencyInjector() {} // 0x0000000189135E4C-0x0000000189135EBC
	
		// Methods
		internal static void Register(ISystemDependencyProvider provider) {} // 0x0000000189135C8C-0x0000000189135E4C
		private static ISystemDependencyProvider ReflectionLoad() => default; // 0x0000000189135BAC-0x0000000189135C8C
	}

	internal interface ISystemCertificateProvider // TypeDefIndex: 38565
	{
		// Methods
		X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = CertificateImportFlags.None /* Metadata: 0x01F9DF8C */);
		X509CertificateImpl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = CertificateImportFlags.None /* Metadata: 0x01F9DF8D */);
		X509CertificateImpl Import(X509Certificate cert, CertificateImportFlags importFlags = CertificateImportFlags.None /* Metadata: 0x01F9DF8E */);
	}

	internal interface ISystemDependencyProvider // TypeDefIndex: 38566
	{
		// Properties
		ISystemCertificateProvider CertificateProvider { get; }
	}

	public static class Runtime // TypeDefIndex: 38567
	{
		// Fields
		private static object dump; // 0x00
	
		// Constructors
		static Runtime() {} // 0x0000000189138384-0x00000001891383F4
	}

	internal struct RuntimeClassHandle // TypeDefIndex: 38568
	{
		// Fields
		private unsafe RuntimeStructs.MonoClass* value; // 0x00
	
		// Properties
		internal unsafe RuntimeStructs.MonoClass* Value { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
	
		// Constructors
		internal unsafe RuntimeClassHandle(RuntimeStructs.MonoClass* value) : this() {
			this.value = default;
		} // 0x0000000183D51730-0x0000000183D51740
		internal unsafe RuntimeClassHandle(IntPtr ptr) : this() {
			value = default;
		} // 0x0000000183D51730-0x0000000183D51740
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189137FC4-0x0000000189138084
		public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
		internal static unsafe IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass) => default; // 0x0000000183D69590-0x0000000183D695A0
		internal RuntimeTypeHandle GetTypeHandle() => default; // 0x0000000183D6E8B0-0x0000000183D6E8C0
	}

	internal struct RuntimeRemoteClassHandle // TypeDefIndex: 38569
	{
		// Fields
		private unsafe RuntimeStructs.RemoteClass* value; // 0x00
	
		// Properties
		internal RuntimeClassHandle ProxyClass { get => default; } // 0x0000000189138368-0x0000000189138384 
	}

	internal struct RuntimeGenericParamInfoHandle // TypeDefIndex: 38570
	{
		// Fields
		private unsafe RuntimeStructs.GenericParamInfo* value; // 0x00
	
		// Properties
		internal System.Type[] Constraints { get => default; } // 0x0000000189138298-0x00000001891382A0 
		internal GenericParameterAttributes Attributes { get => default; } // 0x000000018913827C-0x0000000189138298 
	
		// Constructors
		internal unsafe RuntimeGenericParamInfoHandle(IntPtr ptr) : this() {
			value = default;
		} // 0x0000000183D51730-0x0000000183D51740
	
		// Methods
		private System.Type[] GetConstraints() => default; // 0x000000018913819C-0x000000018913827C
		private int GetConstraintsCount() => default; // 0x000000018913816C-0x000000018913819C
	}

	internal struct RuntimeEventHandle // TypeDefIndex: 38571
	{
		// Fields
		private IntPtr value; // 0x00
	
		// Properties
		public IntPtr Value { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
	
		// Constructors
		internal RuntimeEventHandle(IntPtr v) : this() {
			value = default;
		} // 0x0000000183D51730-0x0000000183D51740
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189138084-0x0000000189138144
		public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
	}

	internal struct RuntimePropertyHandle // TypeDefIndex: 38572
	{
		// Fields
		private IntPtr value; // 0x00
	
		// Properties
		public IntPtr Value { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
	
		// Constructors
		internal RuntimePropertyHandle(IntPtr v) : this() {
			value = default;
		} // 0x0000000183D51730-0x0000000183D51740
	
		// Methods
		public override bool Equals(object obj) => default; // 0x00000001891382A8-0x0000000189138368
		public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
	}

	internal struct RuntimeGPtrArrayHandle // TypeDefIndex: 38573
	{
		// Fields
		private unsafe RuntimeStructs.GPtrArray* value; // 0x00
	
		// Properties
		internal int Length { get => default; } // 0x0000000184272EE8-0x0000000184272F04 
		internal IntPtr this[int i] { get => default; } // 0x00000001842712A4-0x00000001842712AC 
	
		// Constructors
		internal unsafe RuntimeGPtrArrayHandle(IntPtr ptr) : this() {
			value = default;
		} // 0x0000000183D51730-0x0000000183D51740
	
		// Methods
		internal IntPtr Lookup(int i) => default; // 0x0000000182C5A3E0-0x0000000182C5A420
		private static unsafe void GPtrArrayFree(RuntimeStructs.GPtrArray* value) {} // 0x0000000189138164-0x000000018913816C
		internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) {} // 0x0000000189138144-0x0000000189138164
	}

	internal static class RuntimeMarshal // TypeDefIndex: 38574
	{
		// Methods
		internal static string PtrToUtf8String(IntPtr ptr) => default; // 0x0000000182A47890-0x0000000182A47910
		internal static SafeStringMarshal MarshalString(string str) => default; // 0x000000018377AFC0-0x000000018377AFF0
		private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) {
			out_ptr = default;
			return default;
		} // 0x0000000182A479E0-0x0000000182A47A20
		internal static byte[] DecodeBlobArray(IntPtr ptr) => default; // 0x0000000182A47910-0x0000000182A479E0
		internal static int AsciHexDigitValue(int c) => default; // 0x0000000182A47860-0x0000000182A47890
		internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) {} // 0x00000001891382A0-0x00000001891382A8
	}

	internal static class RuntimeStructs // TypeDefIndex: 38579
	{
		// Nested types
		internal struct RemoteClass // TypeDefIndex: 38575
		{
			// Fields
			internal IntPtr default_vtable; // 0x00
			internal IntPtr xdomain_vtable; // 0x08
			internal unsafe MonoClass* proxy_class; // 0x10
			internal IntPtr proxy_class_name; // 0x18
			internal uint interface_count; // 0x20
		}
	
		internal struct MonoClass // TypeDefIndex: 38576
		{
		}
	
		internal struct GenericParamInfo // TypeDefIndex: 38577
		{
			// Fields
			internal unsafe MonoClass* pklass; // 0x00
			internal IntPtr name; // 0x08
			internal ushort flags; // 0x10
			internal uint token; // 0x14
			internal unsafe MonoClass** constraints; // 0x18
		}
	
		internal struct GPtrArray // TypeDefIndex: 38578
		{
			// Fields
			internal unsafe IntPtr* data; // 0x00
			internal int len; // 0x08
		}
	}

	internal struct MonoAssemblyName // TypeDefIndex: 38581
	{
		// Fields
		internal IntPtr name; // 0x00
		internal IntPtr culture; // 0x08
		internal IntPtr hash_value; // 0x10
		internal IntPtr public_key; // 0x18
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte public_key_token[0]; // 0x20
		internal uint hash_alg; // 0x34
		internal uint hash_len; // 0x38
		internal uint flags; // 0x3C
		internal ushort major; // 0x40
		internal ushort minor; // 0x42
		internal ushort build; // 0x44
		internal ushort revision; // 0x46
		internal ushort arch; // 0x48
	}

	internal struct ValueTuple // TypeDefIndex: 38582
	{
	}

	internal struct ValueTuple<T1> // TypeDefIndex: 38583
	{
		// Fields
		public T1 Item1;
	}

	internal struct ValueTuple<T1, T2> // TypeDefIndex: 38584
	{
		// Fields
		public T1 Item1;
		public T2 Item2;
	}

	internal struct ValueTuple<T1, T2, T3> // TypeDefIndex: 38585
	{
		// Fields
		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
	}

	internal struct ValueTuple<T1, T2, T3, T4> // TypeDefIndex: 38586
	{
		// Fields
		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
	}

	internal struct ValueTuple<T1, T2, T3, T4, T5> // TypeDefIndex: 38587
	{
		// Fields
		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
	}

	internal struct SafeGPtrArrayHandle : IDisposable // TypeDefIndex: 38588
	{
		// Fields
		private RuntimeGPtrArrayHandle handle; // 0x00
	
		// Properties
		internal int Length { get => default; } // 0x00000001842712B4-0x00000001842712BC 
		internal IntPtr this[int i] { get => default; } // 0x00000001842712A4-0x00000001842712AC 
	
		// Constructors
		internal SafeGPtrArrayHandle(IntPtr ptr) : this() {
			handle = default;
		} // 0x0000000183D51730-0x0000000183D51740
	
		// Methods
		public void Dispose() {} // 0x0000000189138144-0x0000000189138164
	}

	internal struct SafeStringMarshal : IDisposable // TypeDefIndex: 38589
	{
		// Fields
		private readonly string str; // 0x00
		private IntPtr marshaled_string; // 0x08
	
		// Properties
		public IntPtr Value { get => default; } // 0x00000001826B7F20-0x00000001826B8030 
	
		// Constructors
		public SafeStringMarshal(string str) : this() {
			this.str = default;
			marshaled_string = default;
		} // 0x00000001842712EC-0x0000000184271308
	
		// Methods
		private static IntPtr StringToUtf8_icall(ref string str) => default; // 0x0000000189138660-0x0000000189138668
		public static IntPtr StringToUtf8(string str) => default; // 0x00000001842712D4-0x00000001842712EC
		public static void GFree(IntPtr ptr) {} // 0x0000000184273A80-0x0000000184273A88
		public void Dispose() {} // 0x0000000182DA8300-0x0000000182DA8330
	}
}

namespace System
{
	[Serializable]
	public sealed class String : IComparable, IEnumerable<char>, IComparable<string>, IEquatable<string>, IConvertible, ICloneable // TypeDefIndex: 38667
	{
		// Fields
		private const int StackallocIntBufferSizeLimit = 128; // Metadata: 0x01F9DFD4
		private const int PROBABILISTICMAP_BLOCK_INDEX_MASK = 7; // Metadata: 0x01F9DFD6
		private const int PROBABILISTICMAP_BLOCK_INDEX_SHIFT = 3; // Metadata: 0x01F9DFD7
		private const int PROBABILISTICMAP_SIZE = 8; // Metadata: 0x01F9DFD8
		[NonSerialized]
		private int _stringLength; // 0x10
		[NonSerialized]
		private char _firstChar; // 0x14
		public static readonly string Empty; // 0x00
	
		// Properties
		public int Length { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
		public char this[int index] { [Intrinsic] get => default; } // 0x000000018236DD00-0x000000018236DD30 
	
		// Nested types
		private enum TrimType // TypeDefIndex: 38665
		{
			Head = 0,
			Tail = 1,
			Both = 2
		}
	
		private struct ProbabilisticMap // TypeDefIndex: 38666
		{
		}
	
		// Constructors
		public String() {} // Dummy constructor
		public String(char[] value) {} // 0x000000018914A4F8-0x000000018914A504
		public String(char[] value, int startIndex, int length) {} // 0x000000018914A4F8-0x000000018914A504
		[CLSCompliant(false)]
		public unsafe String(char* value) {} // 0x000000018914A4F8-0x000000018914A504
		[CLSCompliant(false)]
		public unsafe String(char* value, int startIndex, int length) {} // 0x000000018914A4F8-0x000000018914A504
		[CLSCompliant(false)]
		public unsafe String(sbyte* value, int startIndex, int length) {} // 0x000000018914A4F8-0x000000018914A504
		[CLSCompliant(false)]
		public unsafe String(sbyte* value, int startIndex, int length, Encoding enc) {} // 0x000000018914A51C-0x000000018914A530
		public String(char c, int count) {} // 0x000000018914A4F8-0x000000018914A504
		public String(ReadOnlySpan<char> value) {} // 0x000000018914A504-0x000000018914A51C
	
		// Methods
		private static bool EqualsHelper(string strA, string strB) => default; // 0x000000018232CCF0-0x000000018232CD20
		private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB) => default; // 0x0000000189147620-0x0000000189147668
		private static int CompareOrdinalHelper(string strA, string strB) => default; // 0x00000001831FBE60-0x00000001831FBF50
		public static int Compare(string strA, string strB) => default; // 0x0000000182360C20-0x0000000182360C30
		public static int Compare(string strA, string strB, bool ignoreCase) => default; // 0x00000001891479FC-0x0000000189147A0C
		public static int Compare(string strA, string strB, StringComparison comparisonType) => default; // 0x0000000182361CD0-0x0000000182361E40
		public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options) => default; // 0x0000000189147B38-0x0000000189147BE0
		public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) => default; // 0x0000000189147B20-0x0000000189147B38
		public static int Compare(string strA, int indexA, string strB, int indexB, int length) => default; // 0x0000000189147BE0-0x0000000189147C04
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase) => default; // 0x0000000189147A0C-0x0000000189147B20
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) => default; // 0x0000000182476450-0x0000000182476600
		public static int CompareOrdinal(string strA, string strB) => default; // 0x00000001831FCE70-0x00000001831FCEB0
		internal static int CompareOrdinal(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB) => default; // 0x0000000189147668-0x0000000189147704
		public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) => default; // 0x0000000189147704-0x0000000189147948
		public int CompareTo(object value) => default; // 0x0000000189147948-0x00000001891479FC
		public int CompareTo(string strB) => default; // 0x0000000182360C20-0x0000000182360C30
		public bool EndsWith(string value) => default; // 0x0000000184270164-0x0000000184270170
		public bool EndsWith(string value, StringComparison comparisonType) => default; // 0x0000000182373130-0x00000001823732E0
		public override bool Equals(object obj) => default; // 0x0000000182E960A0-0x0000000182E96120
		public bool Equals(string value) => default; // 0x000000018232CCC0-0x000000018232CCF0
		public bool Equals(string value, StringComparison comparisonType) => default; // 0x0000000182476790-0x00000001824768D0
		public static bool Equals(string a, string b) => default; // 0x000000018232CC30-0x000000018232CC70
		public static bool Equals(string a, string b, StringComparison comparisonType) => default; // 0x00000001824E8310-0x00000001824E8590
		public static bool operator ==(string a, string b) => default; // 0x000000018426F844-0x000000018426F84C
		public static bool operator !=(string a, string b) => default; // 0x000000018232CBA0-0x000000018232CBF0
		public override int GetHashCode() => default; // 0x0000000182513E80-0x0000000182513ED0
		internal int GetLegacyNonRandomizedHashCode() => default; // 0x0000000182513ED0-0x0000000182514090
		public bool StartsWith(string value) => default; // 0x0000000182373C50-0x0000000182373C70
		public bool StartsWith(string value, StringComparison comparisonType) => default; // 0x0000000182374FB0-0x0000000182375490
		internal static void CheckStringComparison(StringComparison comparisonType) {} // 0x00000001824768D0-0x00000001824768F0
		private static string Ctor(char[] value) => default; // 0x0000000182D2D820-0x0000000182D2DB90
		private static string Ctor(char[] value, int startIndex, int length) => default; // 0x000000018232FD00-0x00000001823300D0
		private static unsafe string Ctor(char* ptr) => default; // 0x0000000183A62660-0x0000000183A626F0
		private static unsafe string Ctor(char* ptr, int startIndex, int length) => default; // 0x0000000182E56560-0x0000000182E56900
		private static unsafe string Ctor(sbyte* value, int startIndex, int length) => default; // 0x0000000189147FF4-0x00000001891481FC
		private static unsafe string CreateStringForSByteConstructor(byte* pb, int numBytes) => default; // 0x0000000189147F60-0x0000000189147FD0
		private static unsafe string Ctor(sbyte* value, int startIndex, int length, Encoding enc) => default; // 0x00000001830E9F60-0x00000001830EA080
		private static string Ctor(char c, int count) => default; // 0x0000000182BAE580-0x0000000182BAE630
		private static string Ctor(ReadOnlySpan<char> value) => default; // 0x00000001832EE870-0x00000001832EE930
		public static string Create<TState>(int length, TState state, SpanAction<char, TState> action) => default;
		public static implicit operator ReadOnlySpan<char>(string value) => default; // 0x000000018914A628-0x000000018914A68C
		public object Clone() => default; // 0x000000018339AE90-0x000000018339AEA0
		public static string Copy(string str) => default; // 0x0000000189147EC8-0x0000000189147F60
		public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) {} // 0x0000000182B46470-0x0000000182B467C0
		public char[] ToCharArray() => default; // 0x00000001831EE230-0x00000001831EE2C0
		[NonVersionable]
		public static bool IsNullOrEmpty(string value) => default; // 0x00000001823757F0-0x0000000182375800
		public static bool IsNullOrWhiteSpace(string value) => default; // 0x00000001828EF8C0-0x00000001828EF960
		internal ref char GetRawStringData() => ref _refReturnTypeForGetRawStringData; // 0x0000000183D6EA50-0x0000000183D6EA60
		private ref char _refReturnTypeForGetRawStringData; // Dummy field
		internal static unsafe string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) => default; // 0x0000000182330460-0x00000001823306D0
		internal static string CreateFromChar(char c) => default; // 0x0000000183809A40-0x0000000183809A70
		internal static unsafe void wstrcpy(char* dmem, char* smem, int charCount) {} // 0x000000018232F430-0x000000018232F700
		public override string ToString() => default; // 0x000000018339AE90-0x000000018339AEA0
		public string ToString(IFormatProvider provider) => default; // 0x000000018339AE90-0x000000018339AEA0
		IEnumerator<char> IEnumerable<char>.GetEnumerator() => default; // 0x00000001835F6B60-0x00000001835F6BC0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189149DE4-0x0000000189149E44
		internal static unsafe int wcslen(char* ptr) => default; // 0x0000000182379400-0x0000000182379510
		public TypeCode GetTypeCode() => default; // 0x0000000183D56100-0x0000000183D56110
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000189149E44-0x0000000189149EA0
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000189149EFC-0x0000000189149F58
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x000000018914A138-0x000000018914A188
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000189149EA0-0x0000000189149EFC
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x000000018914A080-0x000000018914A0DC
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x000000018914A1E8-0x000000018914A244
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x00000001825FABE0-0x00000001825FAC50
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000182E56D10-0x0000000182E56D80
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x000000018914A0DC-0x000000018914A138
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x00000001824E43A0-0x00000001824E45A0
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000182E3A8B0-0x0000000182E3A920
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x000000018914A024-0x000000018914A080
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000189149FB4-0x000000018914A024
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000189149F58-0x0000000189149FB4
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x000000018914A188-0x000000018914A1E8
		public string Normalize(NormalizationForm normalizationForm) => default; // 0x0000000189149354-0x00000001891493AC
		private static void FillStringChecked(string dest, int destPos, string src) {} // 0x000000018232EB70-0x000000018232EE70
		public static string Concat(object arg0, object arg1) => default; // 0x0000000189147C04-0x0000000189147C9C
		public static string Concat(object arg0, object arg1, object arg2) => default; // 0x00000001828FA680-0x00000001828FA750
		public static string Concat(params object[] args) => default; // 0x0000000189147C9C-0x0000000189147EC8
		public static string Concat(string str0, string str1) => default; // 0x00000001824E4C30-0x00000001824E52C0
		public static string Concat(string str0, string str1, string str2) => default; // 0x00000001828F89B0-0x00000001828F8A70
		public static string Concat(string str0, string str1, string str2, string str3) => default; // 0x00000001825EFF80-0x00000001825F0090
		public static string Concat(params string[] values) => default; // 0x00000001825F3080-0x00000001825F3500
		public static string Format(string format, object arg0) => default; // 0x00000001825F1D30-0x00000001825F1D80
		public static string Format(string format, object arg0, object arg1) => default; // 0x00000001825EE450-0x00000001825EE4A0
		public static string Format(string format, object arg0, object arg1, object arg2) => default; // 0x00000001825EFE70-0x00000001825EFF80
		public static string Format(string format, params object[] args) => default; // 0x00000001825F3B00-0x00000001825F3B60
		public static string Format(IFormatProvider provider, string format, object arg0) => default; // 0x000000018339AE20-0x000000018339AE90
		public static string Format(IFormatProvider provider, string format, object arg0, object arg1) => default; // 0x0000000183A468D0-0x0000000183A46940
		public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) => default; // 0x00000001891481FC-0x0000000189148274
		public static string Format(IFormatProvider provider, string format, params object[] args) => default; // 0x0000000182E3A5E0-0x0000000182E3A650
		private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) => default; // 0x00000001825F1D80-0x00000001825F1FC0
		public string Insert(int startIndex, string value) => default; // 0x0000000183082180-0x0000000183082270
		public static string Join(char separator, params string[] value) => default; // 0x0000000189148560-0x00000001891485D8
		public static string Join(char separator, string[] value, int startIndex, int count) => default; // 0x00000001891489E4-0x0000000189148A18
		public static string Join(string separator, params string[] value) => default; // 0x0000000182D7AFD0-0x0000000182D7B000
		public static string Join(string separator, params object[] values) => default; // 0x00000001891484F4-0x0000000189148560
		public static string Join<T>(string separator, IEnumerable<T> values) => default;
		public static string Join(string separator, IEnumerable<string> values) => default; // 0x00000001891485D8-0x00000001891489E4
		public static string Join(string separator, string[] value, int startIndex, int count) => default; // 0x0000000182D7B000-0x0000000182D7B0A0
		private static unsafe string JoinCore(char* separator, int separatorLength, object[] values) => default; // 0x000000018914835C-0x00000001891484F4
		private static unsafe string JoinCore<T>(char* separator, int separatorLength, IEnumerable<T> values) => default;
		private static unsafe string JoinCore(char* separator, int separatorLength, string[] value, int startIndex, int count) => default; // 0x000000018232D620-0x000000018232DB70
		public string PadLeft(int totalWidth, char paddingChar) => default; // 0x00000001891493AC-0x00000001891494A0
		public string PadRight(int totalWidth, char paddingChar) => default; // 0x00000001891494A0-0x000000018914958C
		public string Remove(int startIndex, int count) => default; // 0x0000000183084390-0x0000000183084480
		public string Remove(int startIndex) => default; // 0x000000018914958C-0x000000018914967C
		public string Replace(string oldValue, string newValue, StringComparison comparisonType) => default; // 0x00000001891498D4-0x0000000189149A70
		private string ReplaceCore(string oldValue, string newValue, CultureInfo culture, CompareOptions options) => default; // 0x000000018914967C-0x00000001891498D4
		public string Replace(char oldChar, char newChar) => default; // 0x0000000182A4B760-0x0000000182A4B7C0
		public string Replace(string oldValue, string newValue) => default; // 0x00000001825DE1D0-0x00000001825DE430
		private string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan<int> indices) => default; // 0x00000001830E6D60-0x00000001830E70E0
		public string[] Split(char separator, StringSplitOptions options = StringSplitOptions.None /* Metadata: 0x01F9DFD1 */) => default; // 0x00000001825DE150-0x00000001825DE1D0
		public string[] Split(char separator, int count, StringSplitOptions options = StringSplitOptions.None /* Metadata: 0x01F9DFD2 */) => default; // 0x0000000182DF1F10-0x0000000182DF1FA0
		public string[] Split(params char[] separator) => default; // 0x00000001825DE430-0x00000001825DE4E0
		public string[] Split(char[] separator, StringSplitOptions options) => default; // 0x000000018268EAA0-0x000000018268EB30
		public string[] Split(char[] separator, int count, StringSplitOptions options) => default; // 0x0000000189149D08-0x0000000189149D94
		private string[] SplitInternal(ReadOnlySpan<char> separators, int count, StringSplitOptions options) => default; // 0x00000001825DE4E0-0x00000001825DEA10
		public string[] Split(string separator, StringSplitOptions options = StringSplitOptions.None /* Metadata: 0x01F9DFD3 */) => default; // 0x00000001828F8D40-0x00000001828F8DC0
		public string[] Split(string[] separator, StringSplitOptions options) => default; // 0x0000000189149CBC-0x0000000189149CE4
		public string[] Split(string[] separator, int count, StringSplitOptions options) => default; // 0x0000000189149CE4-0x0000000189149D08
		private string[] SplitInternal(string separator, string[] separators, int count, StringSplitOptions options) => default; // 0x00000001828F8DC0-0x00000001828F8F20
		private string[] SplitInternal(string separator, int count, StringSplitOptions options) => default; // 0x00000001828F8F20-0x00000001828F9100
		private string[] SplitKeepEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count) => default; // 0x000000018232D260-0x000000018232D620
		private string[] SplitOmitEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count) => default; // 0x0000000189149A70-0x0000000189149CBC
		private void MakeSeparatorList(ReadOnlySpan<char> separators, ref ValueListBuilder<int> sepListBuilder) {} // 0x000000018236DB00-0x000000018236DD00
		private void MakeSeparatorList(string separator, ref ValueListBuilder<int> sepListBuilder) {} // 0x00000001828F9100-0x00000001828F9230
		private void MakeSeparatorList(string[] separators, ref ValueListBuilder<int> sepListBuilder, ref ValueListBuilder<int> lengthListBuilder) {} // 0x00000001891491D4-0x0000000189149354
		public string Substring(int startIndex) => default; // 0x00000001825E08D0-0x00000001825E0C40
		public string Substring(int startIndex, int length) => default; // 0x000000018232EE70-0x000000018232F260
		private string InternalSubString(int startIndex, int length) => default; // 0x000000018232F260-0x000000018232F430
		public string ToLower() => default; // 0x00000001822FEA70-0x00000001822FEAF0
		public string ToLower(CultureInfo culture) => default; // 0x00000001822FD5E0-0x00000001822FD630
		public string ToLowerInvariant() => default; // 0x0000000182493580-0x0000000182493600
		public string ToUpper() => default; // 0x0000000182300E90-0x0000000182300F10
		public string ToUpper(CultureInfo culture) => default; // 0x000000018914A2FC-0x000000018914A3DC
		public string ToUpperInvariant() => default; // 0x000000018914A244-0x000000018914A2FC
		public string Trim() => default; // 0x000000018426F9E0-0x000000018426F9F0
		public string Trim(char trimChar) => default; // 0x000000018914A4C8-0x000000018914A4F8
		public string Trim(params char[] trimChars) => default; // 0x000000018339ADC0-0x000000018339AE20
		public string TrimStart() => default; // 0x000000018914A4BC-0x000000018914A4C8
		public string TrimStart(char trimChar) => default; // 0x0000000184272848-0x0000000184272874
		public string TrimStart(params char[] trimChars) => default; // 0x000000018914A464-0x000000018914A4BC
		public string TrimEnd() => default; // 0x000000018426F84C-0x000000018426F85C
		public string TrimEnd(char trimChar) => default; // 0x000000018914A438-0x000000018914A464
		public string TrimEnd(params char[] trimChars) => default; // 0x000000018914A3DC-0x000000018914A438
		private string TrimWhiteSpaceHelper(TrimType trimType) => default; // 0x000000018236ACD0-0x000000018236B220
		private unsafe string TrimHelper(char* trimChars, int trimCharsLength, TrimType trimType) => default; // 0x000000018339A5F0-0x000000018339A6D0
		private string CreateTrimmedString(int start, int end) => default; // 0x000000018236AC10-0x000000018236AC80
		public bool Contains(string value) => default; // 0x00000001823017E0-0x0000000182301810
		public bool Contains(string value, StringComparison comparisonType) => default; // 0x00000001823014B0-0x00000001823014D0
		public bool Contains(char value) => default; // 0x0000000182815BE0-0x0000000182815C10
		public int IndexOf(char value) => default; // 0x0000000182815C10-0x0000000182815C20
		public int IndexOf(char value, int startIndex) => default; // 0x0000000182815410-0x0000000182815470
		public int IndexOf(char value, int startIndex, int count) => default; // 0x0000000182815470-0x00000001828154D0
		public int IndexOfAny(char[] anyOf) => default; // 0x0000000182365F40-0x0000000182365F60
		public int IndexOfAny(char[] anyOf, int startIndex) => default; // 0x0000000189148274-0x0000000189148294
		public int IndexOfAny(char[] anyOf, int startIndex, int count) => default; // 0x0000000182365F60-0x0000000182366180
		private int IndexOfAny(char value1, char value2, int startIndex, int count) => default; // 0x00000001891482D8-0x0000000189148334
		private int IndexOfAny(char value1, char value2, char value3, int startIndex, int count) => default; // 0x0000000189148294-0x00000001891482D8
		private int IndexOfCharArray(char[] anyOf, int startIndex, int count) => default; // 0x0000000182366360-0x0000000182366510
		private static unsafe void InitializeProbabilisticMap(uint* charMap, ReadOnlySpan<char> anyOf) {} // 0x000000018237B4A0-0x000000018237B550
		private static bool ArrayContains(char searchChar, char[] anyOf) => default; // 0x0000000183021920-0x0000000183021960
		private static unsafe bool IsCharBitSet(uint* charMap, byte value) => default; // 0x0000000182366510-0x0000000182366530
		private static unsafe void SetCharBit(uint* charMap, byte value) {} // 0x0000000183D6EA60-0x0000000183D6EA80
		public int IndexOf(string value) => default; // 0x0000000189148334-0x0000000189148340
		public int IndexOf(string value, int startIndex) => default; // 0x0000000189148340-0x000000018914835C
		public int IndexOf(string value, StringComparison comparisonType) => default; // 0x0000000182301810-0x0000000182301840
		public int IndexOf(string value, int startIndex, StringComparison comparisonType) => default; // 0x00000001831CA340-0x00000001831CA370
		public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) => default; // 0x0000000182301840-0x0000000182301B20
		public int LastIndexOf(char value) => default; // 0x00000001826D1B40-0x00000001826D1B50
		public int LastIndexOf(char value, int startIndex) => default; // 0x000000018914903C-0x0000000189149058
		public int LastIndexOf(char value, int startIndex, int count) => default; // 0x00000001891490A8-0x00000001891491D4
		public int LastIndexOfAny(char[] anyOf) => default; // 0x0000000182685D30-0x0000000182685F20
		public int LastIndexOfAny(char[] anyOf, int startIndex) => default; // 0x0000000189148A18-0x0000000189148A34
		public int LastIndexOfAny(char[] anyOf, int startIndex, int count) => default; // 0x0000000182685F20-0x0000000182686110
		private int LastIndexOfCharArray(char[] anyOf, int startIndex, int count) => default; // 0x0000000182366180-0x0000000182366360
		public int LastIndexOf(string value) => default; // 0x0000000189149084-0x00000001891490A8
		public int LastIndexOf(string value, StringComparison comparisonType) => default; // 0x0000000189149058-0x0000000189149084
		public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) => default; // 0x0000000189148C4C-0x000000018914903C
		internal int IndexOfUnchecked(string value, int startIndex, int count) => default; // 0x0000000182301DA0-0x0000000182301E70
		internal int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count) => default; // 0x00000001823003E0-0x00000001823006A0
		internal int LastIndexOfUnchecked(string value, int startIndex, int count) => default; // 0x0000000189148BA4-0x0000000189148C4C
		internal int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count) => default; // 0x0000000189148A34-0x0000000189148BA4
		internal bool StartsWithOrdinalUnchecked(string value) => default; // 0x0000000189149D94-0x0000000189149DE4
		internal static string FastAllocateString(int length) => default; // 0x000000018426F85C-0x000000018426F864
		private static string InternalIntern(string str) => default; // 0x0000000184270978-0x0000000184270980
		private static unsafe void memset(byte* dest, int val, int len) {} // 0x000000018914A55C-0x000000018914A628
		private static unsafe void memcpy(byte* dest, byte* src, int size) {} // 0x000000018914A540-0x000000018914A55C
		internal static unsafe void bzero(byte* dest, int len) {} // 0x000000018914A530-0x000000018914A540
		internal static unsafe void bzero_aligned_1(byte* dest, int len) {} // 0x0000000183D4F9C0-0x0000000183D4F9D0
		internal static unsafe void bzero_aligned_2(byte* dest, int len) {} // 0x0000000183D6EA80-0x0000000183D6EA90
		internal static unsafe void bzero_aligned_4(byte* dest, int len) {} // 0x0000000183D5BBD0-0x0000000183D5BBE0
		internal static unsafe void bzero_aligned_8(byte* dest, int len) {} // 0x0000000183D6EA90-0x0000000183D6EAA0
		internal static unsafe void memcpy_aligned_1(byte* dest, byte* src, int size) {} // 0x0000000183D6EAA0-0x0000000183D6EAB0
		internal static unsafe void memcpy_aligned_2(byte* dest, byte* src, int size) {} // 0x0000000183D6EAB0-0x0000000183D6EAC0
		internal static unsafe void memcpy_aligned_4(byte* dest, byte* src, int size) {} // 0x0000000183D6EAC0-0x0000000183D6EAD0
		internal static unsafe void memcpy_aligned_8(byte* dest, byte* src, int size) {} // 0x0000000183D6EAD0-0x0000000183D6EAE0
		private unsafe string CreateString(sbyte* value, int startIndex, int length) => default; // 0x0000000189147FDC-0x0000000189147FF4
		private unsafe string CreateString(char* value) => default; // 0x0000000189147FD0-0x0000000189147FDC
		private unsafe string CreateString(char* value, int startIndex, int length) => default; // 0x00000001842717A4-0x00000001842717BC
		private string CreateString(char[] val, int startIndex, int length) => default; // 0x000000018426FB54-0x000000018426FB6C
		private string CreateString(char[] val) => default; // 0x0000000184276480-0x000000018427648C
		private string CreateString(char c, int count) => default; // 0x0000000184270FE8-0x0000000184270FF8
		private unsafe string CreateString(sbyte* value, int startIndex, int length, Encoding enc) => default; // 0x00000001842727F4-0x0000000184272820
		private string CreateString(ReadOnlySpan<char> value) => default; // 0x000000018426F7A0-0x000000018426F7C0
		public static string Intern(string str) => default; // 0x00000001825D9C00-0x00000001825D9C20
	}

	[Serializable]
	[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback // TypeDefIndex: 38677
	{
		// Fields
		private static Lazy<bool> lazyHaveRegistry; // 0x00
		private readonly string _id; // 0x10
		private readonly string _displayName; // 0x18
		private readonly string _standardDisplayName; // 0x20
		private readonly string _daylightDisplayName; // 0x28
		private readonly TimeSpan _baseUtcOffset; // 0x30
		private readonly bool _supportsDaylightSavingTime; // 0x38
		private readonly AdjustmentRule[] _adjustmentRules; // 0x40
		private static readonly TimeZoneInfo s_utcTimeZone; // 0x08
		private static CachedData s_cachedData; // 0x10
		private static readonly System.DateTime s_maxDateOnly; // 0x18
		private static readonly System.DateTime s_minDateOnly; // 0x20
		private static readonly TimeSpan MaxOffset; // 0x28
		private static readonly TimeSpan MinOffset; // 0x30
	
		// Properties
		private static bool HaveRegistry { get => default; } // 0x00000001839D9330-0x00000001839D93B0 
		public string Id { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public string DisplayName { get => default; } // 0x00000001891F88B8-0x00000001891F8900 
		public TimeSpan BaseUtcOffset { get => default; } // 0x0000000181003830-0x0000000181003840 
		public static TimeZoneInfo Local { get => default; } // 0x000000018299C9E0-0x000000018299CA50 
		public static TimeZoneInfo Utc { get => default; } // 0x00000001891F8900-0x00000001891F8950 
	
		// Nested types
		private sealed class CachedData // TypeDefIndex: 38668
		{
			// Fields
			private OffsetAndRule _oneYearLocalFromUtc; // 0x10
			private TimeZoneInfo _localTimeZone; // 0x18
			public Dictionary<string, TimeZoneInfo> _systemTimeZones; // 0x20
			public ReadOnlyCollection<TimeZoneInfo> _readOnlySystemTimeZones; // 0x28
			public bool _allSystemTimeZonesRead; // 0x30
	
			// Properties
			public TimeZoneInfo Local { get => default; } // 0x000000018299CA50-0x000000018299CA70 
	
			// Constructors
			public CachedData() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			private static TimeZoneInfo GetCurrentOneYearLocal() => default; // 0x0000000182C97450-0x0000000182C974E0
			public OffsetAndRule GetOneYearLocalFromUtc(int year) => default; // 0x000000018299C230-0x000000018299C300
			private TimeZoneInfo CreateLocal() => default; // 0x00000001822C5B20-0x00000001822C5DA0
			public DateTimeKind GetCorrespondingKind(TimeZoneInfo timeZone) => default; // 0x000000018299B860-0x000000018299B8F0
		}
	
		private sealed class OffsetAndRule // TypeDefIndex: 38669
		{
			// Fields
			public readonly int Year; // 0x10
			public readonly TimeSpan Offset; // 0x18
			public readonly AdjustmentRule Rule; // 0x20
	
			// Constructors
			public OffsetAndRule() {} // Dummy constructor
			public OffsetAndRule(int year, TimeSpan offset, AdjustmentRule rule) {} // 0x0000000183D4C340-0x0000000183D4C360
		}
	
		internal struct DYNAMIC_TIME_ZONE_INFORMATION // TypeDefIndex: 38670
		{
			// Fields
			internal Interop.Kernel32.TIME_ZONE_INFORMATION TZI; // 0x00
			internal string TimeZoneKeyName; // 0xB0
			internal byte DynamicDaylightTimeDisabled; // 0xB8
		}
	
		private enum TimeZoneInfoResult // TypeDefIndex: 38671
		{
			Success = 0,
			TimeZoneNotFoundException = 1,
			InvalidTimeZoneException = 2,
			SecurityException = 3
		}
	
		[Serializable]
		public sealed class AdjustmentRule : IEquatable<AdjustmentRule>, ISerializable, IDeserializationCallback // TypeDefIndex: 38672
		{
			// Fields
			private readonly System.DateTime _dateStart; // 0x10
			private readonly System.DateTime _dateEnd; // 0x18
			private readonly TimeSpan _daylightDelta; // 0x20
			private readonly TransitionTime _daylightTransitionStart; // 0x28
			private readonly TransitionTime _daylightTransitionEnd; // 0x40
			private readonly TimeSpan _baseUtcOffsetDelta; // 0x58
			private readonly bool _noDaylightTransitions; // 0x60
	
			// Properties
			public System.DateTime DateStart { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
			public System.DateTime DateEnd { get => default; } // 0x0000000181041090-0x00000001810410A0 
			public TimeSpan DaylightDelta { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
			public TransitionTime DaylightTransitionStart { get => default; } // 0x0000000183D67F30-0x0000000183D67F50 
			public TransitionTime DaylightTransitionEnd { get => default; } // 0x0000000183D51090-0x0000000183D510B0 
			internal TimeSpan BaseUtcOffsetDelta { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
			internal bool NoDaylightTransitions { get => default; } // 0x0000000183D519A0-0x0000000183D519B0 
			internal bool HasDaylightSaving { get => default; } // 0x00000001891E6B34-0x00000001891E6CBC 
	
			// Constructors
			private AdjustmentRule(System.DateTime dateStart, System.DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions) {} // 0x00000001891E6A10-0x00000001891E6B04
			private AdjustmentRule(SerializationInfo info, StreamingContext context) {} // 0x00000001891E66F0-0x00000001891E6A10
			internal AdjustmentRule() {} // 0x00000001891E6B04-0x00000001891E6B34
	
			// Methods
			public bool Equals(AdjustmentRule other) => default; // 0x00000001891E59EC-0x00000001891E5B24
			public override int GetHashCode() => default; // 0x00000001891E5B24-0x00000001891E5B70
			internal static AdjustmentRule CreateAdjustmentRule(System.DateTime dateStart, System.DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions) => default; // 0x00000001891E58F4-0x00000001891E59EC
			internal bool IsStartDateMarkerForBeginningOfYear() => default; // 0x00000001891E5C88-0x00000001891E5DA0
			internal bool IsEndDateMarkerForEndOfYear() => default; // 0x00000001891E5B70-0x00000001891E5C88
			private static void ValidateAdjustmentRule(System.DateTime dateStart, System.DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, bool noDaylightTransitions) {} // 0x00000001891E60D4-0x00000001891E66F0
			void IDeserializationCallback.OnDeserialization(object sender) {} // 0x00000001891E5DA0-0x00000001891E5ECC
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001891E5ECC-0x00000001891E60D4
		}
	
		private struct StringSerializer // TypeDefIndex: 38674
		{
			// Fields
			private readonly string _serializedText; // 0x00
			private int _currentTokenStartIndex; // 0x08
			private State _state; // 0x0C
	
			// Nested types
			private enum State // TypeDefIndex: 38673
			{
				Escaped = 0,
				NotEscaped = 1,
				StartOfToken = 2,
				EndOfLine = 3
			}
	
			// Constructors
			private StringSerializer(string str) {
				_serializedText = default;
				_currentTokenStartIndex = default;
				_state = default;
			} // 0x00000001891F1E0C-0x00000001891F1E30
	
			// Methods
			public static TimeZoneInfo GetDeserializedTimeZoneInfo(string source) => default; // 0x00000001891F055C-0x00000001891F07B4
			private static void VerifyIsEscapableCharacter(char c) {} // 0x00000001891F1D58-0x00000001891F1E0C
			private void SkipVersionNextDataFields(int depth) {} // 0x00000001891F1B5C-0x00000001891F1D58
			private string GetNextStringValue() => default; // 0x00000001891F1044-0x00000001891F1430
			private System.DateTime GetNextDateTimeValue(string format) => default; // 0x00000001891F0E7C-0x00000001891F0F7C
			private TimeSpan GetNextTimeSpanValue() => default; // 0x00000001891F1430-0x00000001891F1528
			private int GetNextInt32Value() => default; // 0x00000001891F0F7C-0x00000001891F1044
			private AdjustmentRule[] GetNextAdjustmentRuleArrayValue() => default; // 0x00000001891F07B4-0x00000001891F094C
			private AdjustmentRule GetNextAdjustmentRuleValue() => default; // 0x00000001891F094C-0x00000001891F0E7C
			private TransitionTime GetNextTransitionTimeValue() => default; // 0x00000001891F1528-0x00000001891F1B5C
		}
	
		[Serializable]
		[IsReadOnly]
		public struct TransitionTime : IEquatable<TransitionTime>, ISerializable, IDeserializationCallback // TypeDefIndex: 38675
		{
			// Fields
			private readonly System.DateTime _timeOfDay; // 0x00
			private readonly byte _month; // 0x08
			private readonly byte _week; // 0x09
			private readonly byte _day; // 0x0A
			private readonly DayOfWeek _dayOfWeek; // 0x0C
			private readonly bool _isFixedDateRule; // 0x10
	
			// Properties
			public System.DateTime TimeOfDay { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
			public int Month { get => default; } // 0x0000000183D557D0-0x0000000183D557E0 
			public int Week { get => default; } // 0x0000000183D55A40-0x0000000183D55A50 
			public int Day { get => default; } // 0x0000000183D55A50-0x0000000183D55A60 
			public DayOfWeek DayOfWeek { get => default; } // 0x0000000183D4FBF0-0x0000000183D4FC00 
			public bool IsFixedDateRule { get => default; } // 0x00000001811797F0-0x0000000181179800 
	
			// Constructors
			private TransitionTime(System.DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) : this() {
				_timeOfDay = default;
				_month = default;
				_week = default;
				_day = default;
				_dayOfWeek = default;
				_isFixedDateRule = default;
			} // 0x00000001891F9104-0x00000001891F9180
			private TransitionTime(SerializationInfo info, StreamingContext context) : this() {
				_timeOfDay = default;
				_month = default;
				_week = default;
				_day = default;
				_dayOfWeek = default;
				_isFixedDateRule = default;
			} // 0x00000001891F9180-0x00000001891F9424
	
			// Methods
			public override bool Equals(object obj) => default; // 0x00000001891F89C8-0x00000001891F8A40
			public static bool operator !=(TransitionTime t1, TransitionTime t2) => default; // 0x00000001891F9424-0x00000001891F9450
			public bool Equals(TransitionTime other) => default; // 0x00000001891F8A40-0x00000001891F8B18
			public override int GetHashCode() => default; // 0x0000000183D704C0-0x0000000183D704D0
			public static TransitionTime CreateFixedDateRule(System.DateTime timeOfDay, int month, int day) => default; // 0x00000001891F8950-0x00000001891F898C
			public static TransitionTime CreateFloatingDateRule(System.DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) => default; // 0x00000001891F898C-0x00000001891F89C8
			private static void ValidateTransitionTime(System.DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek) {} // 0x00000001891F8D80-0x00000001891F9104
			void IDeserializationCallback.OnDeserialization(object sender) {} // 0x00000001891F8B18-0x00000001891F8C08
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001891F8C08-0x00000001891F8D80
		}
	
		// Constructors
		private TimeZoneInfo([IsReadOnly] in Interop.Kernel32.TIME_ZONE_INFORMATION zone, bool dstDisabled) {} // 0x0000000182C97710-0x0000000182C97A90
		private TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) {} // 0x0000000182C98FB0-0x0000000182C990D0
		private TimeZoneInfo(SerializationInfo info, StreamingContext context) {} // 0x00000001891F84B0-0x00000001891F8888
		static TimeZoneInfo() {} // 0x0000000182C98770-0x0000000182C98A10
		internal TimeZoneInfo() {} // 0x00000001891F8888-0x00000001891F88B8
	
		// Methods
		private static void PopulateAllSystemTimeZones(CachedData cachedData) {} // 0x00000001891F6578-0x00000001891F65E4
		private static void PopulateAllSystemTimeZonesFromRegistry(CachedData cachedData) {} // 0x00000001891F61A4-0x00000001891F6578
		private static bool CheckDaylightSavingTimeNotSupported([IsReadOnly] in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone) => default; // 0x00000001891F1E30-0x00000001891F1E58
		private static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation([IsReadOnly] in Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, System.DateTime startDate, System.DateTime endDate, int defaultBaseUtcOffset) => default; // 0x0000000182C98410-0x0000000182C984E0
		private static string FindIdFromTimeZoneInformation([IsReadOnly] in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, out bool dstDisabled) {
			dstDisabled = default;
			return default;
		} // 0x00000001891F2B60-0x00000001891F2CF4
		private static TimeZoneInfo GetLocalTimeZone(CachedData cachedData) => default; // 0x00000001822C5DA0-0x00000001822C5F10
		private static TimeZoneInfo GetLocalTimeZoneFromWin32Data([IsReadOnly] in Interop.Kernel32.TIME_ZONE_INFORMATION timeZoneInformation, bool dstDisabled) => default; // 0x0000000182C974E0-0x0000000182C97590
		internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(System.DateTime time, out bool isAmbiguousLocalDst) {
			isAmbiguousLocalDst = default;
			return default;
		} // 0x000000018299C0D0-0x000000018299C230
		private static bool TransitionTimeFromTimeZoneInformation([IsReadOnly] in Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, out TransitionTime transitionTime, bool readStartDate) {
			transitionTime = default;
			return default;
		} // 0x00000001891F75EC-0x00000001891F7738
		private static bool TryCreateAdjustmentRules(string id, [IsReadOnly] in Interop.Kernel32.REG_TZI_FORMAT defaultTimeZoneInformation, out AdjustmentRule[] rules, out Exception e, int defaultBaseUtcOffset) {
			rules = default;
			e = default;
			return default;
		} // 0x0000000182C97A90-0x0000000182C98390
		private static bool TryGetTimeZoneEntryFromRegistry(RegistryKey key, string name, out Interop.Kernel32.REG_TZI_FORMAT dtzi) {
			dtzi = default;
			return default;
		} // 0x0000000182A4E520-0x0000000182A4E5F0
		private static bool TryCompareStandardDate([IsReadOnly] in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, [IsReadOnly] in Interop.Kernel32.REG_TZI_FORMAT registryTimeZoneInfo) => default; // 0x00000001891F7998-0x00000001891F79D0
		private static bool TryCompareTimeZoneInformationToRegistry([IsReadOnly] in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, string id, out bool dstDisabled) {
			dstDisabled = default;
			return default;
		} // 0x00000001891F79D0-0x00000001891F7D58
		private static string TryGetLocalizedNameByMuiNativeResource(string resource) => default; // 0x0000000182A4D060-0x0000000182A4D2D0
		private static string TryGetLocalizedNameByNativeResource(string filePath, int resource) => default; // 0x0000000182A4DC40-0x0000000182A4DFC0
		private static void GetLocalizedNamesByRegistryKey(RegistryKey key, out string displayName, out string standardName, out string daylightName) {
			displayName = default;
			standardName = default;
			daylightName = default;
		} // 0x0000000182A4D470-0x0000000182A4D760
		private static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, out TimeZoneInfo value, out Exception e) {
			value = default;
			e = default;
			return default;
		} // 0x00000001831CBA20-0x00000001831CBAB0
		private static TimeZoneInfoResult TryGetTimeZoneFromLocalRegistry(string id, out TimeZoneInfo value, out Exception e) {
			value = default;
			e = default;
			return default;
		} // 0x00000001831CA9A0-0x00000001831CB910
		internal static extern uint EnumDynamicTimeZoneInformation(uint dwIndex, out DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation); // 0x00000001891F295C-0x00000001891F2AB0
		internal static extern uint GetDynamicTimeZoneInformation(out DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation); // 0x00000001891F3474-0x00000001891F35BC
		internal static extern uint GetDynamicTimeZoneInformationEffectiveYears(ref DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear); // 0x00000001891F3308-0x00000001891F3474
		internal static extern bool GetTimeZoneInformationForYear(ushort wYear, ref DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out Interop.Kernel32.TIME_ZONE_INFORMATION ptzi); // 0x00000001891F5744-0x00000001891F58B4
		internal static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, System.DateTime startDate, System.DateTime endDate, int defaultBaseUtcOffset) => default; // 0x00000001891F24D0-0x00000001891F295C
		private static bool TransitionTimeFromTimeZoneInformation(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TransitionTime transitionTime, bool readStartDate) {
			transitionTime = default;
			return default;
		} // 0x00000001891F69CC-0x00000001891F75EC
		internal static TimeZoneInfo TryCreateTimeZone(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) => default; // 0x00000001891F7D58-0x00000001891F84B0
		internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() => default; // 0x00000001891F4880-0x00000001891F4A8C
		internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) => default; // 0x00000001891F2CF4-0x00000001891F2F9C
		private static void GetSystemTimeZonesWinRTFallback(CachedData cachedData) {} // 0x00000001891F4C18-0x00000001891F52A4
		private AdjustmentRule GetPreviousAdjustmentRule(AdjustmentRule rule, int? ruleIndex) => default; // 0x00000001891F4B1C-0x00000001891F4C18
		public TimeSpan GetUtcOffset(System.DateTime dateTime) => default; // 0x00000001891F5D3C-0x00000001891F5DA8
		internal static TimeSpan GetLocalUtcOffset(System.DateTime dateTime, TimeZoneInfoOptions flags) => default; // 0x00000001891F4A8C-0x00000001891F4B1C
		internal TimeSpan GetUtcOffset(System.DateTime dateTime, TimeZoneInfoOptions flags) => default; // 0x00000001891F5910-0x00000001891F5988
		private TimeSpan GetUtcOffset(System.DateTime dateTime, TimeZoneInfoOptions flags, CachedData cachedData) => default; // 0x00000001891F5A38-0x00000001891F5B94
		internal bool IsDaylightSavingTime(System.DateTime dateTime, TimeZoneInfoOptions flags) => default; // 0x00000001891F5ED0-0x00000001891F5F48
		private bool IsDaylightSavingTime(System.DateTime dateTime, TimeZoneInfoOptions flags, CachedData cachedData) => default; // 0x00000001891F5F48-0x00000001891F6144
		internal static System.DateTime ConvertTime(System.DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags) => default; // 0x00000001891F22B4-0x00000001891F2340
		private static System.DateTime ConvertTime(System.DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, CachedData cachedData) => default; // 0x000000018299AFE0-0x000000018299B410
		public static System.DateTime ConvertTimeFromUtc(System.DateTime dateTime, TimeZoneInfo destinationTimeZone) => default; // 0x000000018299AF50-0x000000018299AFE0
		internal static System.DateTime ConvertTimeToUtc(System.DateTime dateTime, TimeZoneInfoOptions flags) => default; // 0x00000001891F21E0-0x00000001891F22B4
		public static System.DateTime ConvertTimeToUtc(System.DateTime dateTime, TimeZoneInfo sourceTimeZone) => default; // 0x000000018299D620-0x000000018299D6B0
		public bool Equals(TimeZoneInfo other) => default; // 0x00000001891F2AB0-0x00000001891F2AFC
		public override bool Equals(object obj) => default; // 0x00000001891F2AFC-0x00000001891F2B60
		public static TimeZoneInfo FromSerializedString(string source) => default; // 0x00000001891F2F9C-0x00000001891F308C
		public override int GetHashCode() => default; // 0x00000001891F35BC-0x00000001891F3614
		public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() => default; // 0x00000001891F52A4-0x00000001891F5744
		public bool HasSameRules(TimeZoneInfo other) => default; // 0x00000001891F5DA8-0x00000001891F5ED0
		public override string ToString() => default; // 0x00000001891F69C4-0x00000001891F69CC
		public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) => default; // 0x0000000182C98F00-0x0000000182C98FB0
		void IDeserializationCallback.OnDeserialization(object sender) {} // 0x00000001891F65E4-0x00000001891F6828
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001891F6828-0x00000001891F69C4
		private AdjustmentRule GetAdjustmentRuleForTime(System.DateTime dateTime, out int? ruleIndex) {
			ruleIndex = default;
			return default;
		} // 0x0000000184272208-0x0000000184272228
		private AdjustmentRule GetAdjustmentRuleForTime(System.DateTime dateTime, bool dateTimeisUtc, out int? ruleIndex) {
			ruleIndex = default;
			return default;
		} // 0x000000018299BC50-0x000000018299BCE0
		private int CompareAdjustmentRuleToDateTime(AdjustmentRule rule, AdjustmentRule previousRule, System.DateTime dateTime, System.DateTime dateOnly, bool dateTimeisUtc) => default; // 0x00000001891F2044-0x00000001891F21C4
		private System.DateTime ConvertToUtc(System.DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) => default; // 0x00000001891F24B4-0x00000001891F24D0
		private System.DateTime ConvertFromUtc(System.DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) => default; // 0x00000001891F21C4-0x00000001891F21E0
		private System.DateTime ConvertToFromUtc(System.DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta, bool convertToUtc) => default; // 0x00000001891F2340-0x00000001891F24B4
		private static System.DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst) {
			isAmbiguousLocalDst = default;
			return default;
		} // 0x000000018299B490-0x000000018299B800
		private DaylightTimeStruct GetDaylightTime(int year, AdjustmentRule rule, int? ruleIndex) => default; // 0x00000001891F31C4-0x00000001891F3308
		private static bool GetIsDaylightSavings(System.DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags) => default; // 0x00000001891F4160-0x00000001891F44E8
		private TimeSpan GetDaylightSavingsStartOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule, int? ruleIndex) => default; // 0x00000001891F3104-0x00000001891F31C4
		private TimeSpan GetDaylightSavingsEndOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule) => default; // 0x00000001891F308C-0x00000001891F3104
		private static bool GetIsDaylightSavingsFromUtc(System.DateTime time, int year, TimeSpan utc, AdjustmentRule rule, int? ruleIndex, out bool isAmbiguousLocalDst, TimeZoneInfo zone) {
			isAmbiguousLocalDst = default;
			return default;
		} // 0x00000001891F39A8-0x00000001891F4160
		private static bool CheckIsDst(System.DateTime startTime, System.DateTime time, System.DateTime endTime, bool ignoreYearAdjustment, AdjustmentRule rule) => default; // 0x00000001891F1E58-0x00000001891F2044
		private static bool GetIsAmbiguousTime(System.DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime) => default; // 0x00000001891F3614-0x00000001891F39A8
		private static bool GetIsInvalidTime(System.DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime) => default; // 0x00000001891F44E8-0x00000001891F4880
		private static TimeSpan GetUtcOffset(System.DateTime time, TimeZoneInfo zone, TimeZoneInfoOptions flags) => default; // 0x00000001891F5B94-0x00000001891F5D3C
		private static TimeSpan GetUtcOffsetFromUtc(System.DateTime time, TimeZoneInfo zone) => default; // 0x00000001891F58B4-0x00000001891F5910
		private static TimeSpan GetUtcOffsetFromUtc(System.DateTime time, TimeZoneInfo zone, out bool isDaylightSavings) {
			isDaylightSavings = default;
			return default;
		} // 0x000000018299B910-0x000000018299B990
		internal static TimeSpan GetUtcOffsetFromUtc(System.DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) {
			isDaylightSavings = default;
			isAmbiguousLocalDst = default;
			return default;
		} // 0x000000018299B990-0x000000018299BC50
		internal static System.DateTime TransitionTimeToDateTime(int year, TransitionTime transitionTime) => default; // 0x00000001891F7738-0x00000001891F7998
		private static TimeZoneInfoResult TryGetTimeZone(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData, bool alwaysFallbackToLocalMachine = false /* Metadata: 0x01F9DFDC */) {
			value = default;
			e = default;
			return default;
		} // 0x00000001831CB910-0x00000001831CBA20
		private static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData) {
			value = default;
			e = default;
			return default;
		} // 0x00000001831CBBF0-0x00000001831CBE20
		private static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst) {
			adjustmentRulesSupportDst = default;
		} // 0x0000000182C990D0-0x0000000182C991E0
		internal static bool UtcOffsetOutOfRange(TimeSpan offset) => default; // 0x0000000182C991E0-0x0000000182C992D0
		private static TimeSpan GetUtcOffset(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule) => default; // 0x00000001891F5988-0x00000001891F5A38
		private static bool IsValidAdjustmentRuleOffest(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule) => default; // 0x00000001891F6144-0x00000001891F61A4
	}

	[Flags]
	internal enum TimeZoneInfoOptions // TypeDefIndex: 38678
	{
		None = 1,
		NoThrowOnInvalidTime = 2
	}

	[Serializable]
	public class AccessViolationException : SystemException // TypeDefIndex: 38679
	{
		// Constructors
		public AccessViolationException() {} // 0x00000001891E58B0-0x00000001891E58F4
		protected AccessViolationException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	public delegate void Action(); // TypeDefIndex: 38680; 0x00000001842BE03C-0x00000001842BE04C

	public delegate void Action<in T>(T obj); // TypeDefIndex: 38681; 0x00000000-0x00000000

	public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2); // TypeDefIndex: 38682; 0x00000000-0x00000000

	public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3); // TypeDefIndex: 38683; 0x00000000-0x00000000

	public delegate void Action<in T1, in T2, in T3, in T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4); // TypeDefIndex: 38684; 0x00000000-0x00000000

	public delegate void Action<in T1, in T2, in T3, in T4, in T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // TypeDefIndex: 38685; 0x00000000-0x00000000

	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6); // TypeDefIndex: 38686; 0x00000000-0x00000000

	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7); // TypeDefIndex: 38687; 0x00000000-0x00000000

	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8); // TypeDefIndex: 38688; 0x00000000-0x00000000

	public delegate TResult Func<out TResult>(); // TypeDefIndex: 38689; 0x00000000-0x00000000

	public delegate TResult Func<in T, out TResult>(T arg); // TypeDefIndex: 38690; 0x00000000-0x00000000

	public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2); // TypeDefIndex: 38691; 0x00000000-0x00000000

	public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3); // TypeDefIndex: 38692; 0x00000000-0x00000000

	public delegate TResult Func<in T1, in T2, in T3, in T4, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4); // TypeDefIndex: 38693; 0x00000000-0x00000000

	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // TypeDefIndex: 38694; 0x00000000-0x00000000

	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6); // TypeDefIndex: 38695; 0x00000000-0x00000000

	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7); // TypeDefIndex: 38696; 0x00000000-0x00000000

	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8); // TypeDefIndex: 38697; 0x00000000-0x00000000

	public delegate int Comparison<in T>(T x, T y); // TypeDefIndex: 38698; 0x00000000-0x00000000

	public delegate TOutput Converter<in TInput, out TOutput>(TInput input); // TypeDefIndex: 38699; 0x00000000-0x00000000

	public delegate bool Predicate<in T>(T obj); // TypeDefIndex: 38700; 0x00000000-0x00000000

	[Serializable]
	[DebuggerDisplay("Count = {InnerExceptionCount}")]
	public class AggregateException : Exception // TypeDefIndex: 38701
	{
		// Fields
		private ReadOnlyCollection<Exception> m_innerExceptions; // 0x90
	
		// Properties
		public ReadOnlyCollection<Exception> InnerExceptions { get => default; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
		public override string Message { get => default; } // 0x00000001891E7C14-0x00000001891E7D78 
	
		// Constructors
		public AggregateException() {} // 0x00000001891E7B38-0x00000001891E7C14
		public AggregateException(IEnumerable<Exception> innerExceptions) {} // 0x00000001891E74AC-0x00000001891E74F8
		public AggregateException(params Exception[] innerExceptions) {} // 0x00000001891E7AEC-0x00000001891E7B38
		public AggregateException(string message, IEnumerable<Exception> innerExceptions) {} // 0x00000001891E75C0-0x00000001891E7680
		public AggregateException(string message, params Exception[] innerExceptions) {} // 0x00000001891E74F8-0x00000001891E7500
		private AggregateException(string message, IList<Exception> innerExceptions) {} // 0x00000001891E7680-0x00000001891E78BC
		internal AggregateException(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) {} // 0x00000001891E78BC-0x00000001891E7908
		internal AggregateException(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) {} // 0x00000001891E7500-0x00000001891E75C0
		private AggregateException(string message, IList<ExceptionDispatchInfo> innerExceptionInfos) {} // 0x00000001891E7250-0x00000001891E74AC
		protected AggregateException(SerializationInfo info, StreamingContext context) {} // 0x00000001891E7908-0x00000001891E7AEC
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001891E6F54-0x00000001891E7080
		public override Exception GetBaseException() => default; // 0x00000001891E6ED0-0x00000001891E6F54
		public AggregateException Flatten() => default; // 0x00000001891E6CBC-0x00000001891E6ED0
		public override string ToString() => default; // 0x00000001891E7080-0x00000001891E7250
	}

	[Serializable]
	public class ApplicationException : Exception // TypeDefIndex: 38702
	{
		// Constructors
		public ApplicationException() {} // 0x00000001891E7D78-0x00000001891E7DD4
		public ApplicationException(string message) {} // 0x00000001891E7E3C-0x00000001891E7E94
		public ApplicationException(string message, Exception innerException) {} // 0x00000001891E7DD4-0x00000001891E7E3C
		protected ApplicationException(SerializationInfo info, StreamingContext context) {} // 0x00000001891E7E94-0x00000001891E7F00
	}

	[Serializable]
	public class ArgumentException : SystemException // TypeDefIndex: 38703
	{
		// Fields
		private string _paramName; // 0x90
	
		// Properties
		public override string Message { get => default; } // 0x00000001891E80FC-0x00000001891E817C 
	
		// Constructors
		public ArgumentException() {} // 0x00000001891E7FC4-0x00000001891E8008
		public ArgumentException(string message) {} // 0x0000000183D4CD50-0x0000000183D4CD70
		public ArgumentException(string message, Exception innerException) {} // 0x00000001891E80DC-0x00000001891E80FC
		public ArgumentException(string message, string paramName, Exception innerException) {} // 0x00000001891E8008-0x00000001891E804C
		public ArgumentException(string message, string paramName) {} // 0x0000000183D471D0-0x0000000183D47210
		protected ArgumentException(SerializationInfo info, StreamingContext context) {} // 0x00000001891E804C-0x00000001891E80DC
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001891E7F00-0x00000001891E7FC4
	}

	[Serializable]
	public class ArgumentNullException : ArgumentException // TypeDefIndex: 38704
	{
		// Constructors
		public ArgumentNullException() {} // 0x00000001891E81D0-0x00000001891E8214
		public ArgumentNullException(string paramName) {} // 0x00000001891E817C-0x00000001891E81D0
		public ArgumentNullException(string paramName, string message) {} // 0x00000001891E8214-0x00000001891E823C
		protected ArgumentNullException(SerializationInfo info, StreamingContext context) {} // 0x000000018914CBA0-0x000000018914CBC0
	}

	[Serializable]
	public class ArgumentOutOfRangeException : ArgumentException // TypeDefIndex: 38705
	{
		// Fields
		private object _actualValue; // 0x98
	
		// Properties
		public override string Message { get => default; } // 0x00000001891E84A8-0x00000001891E8538 
	
		// Constructors
		public ArgumentOutOfRangeException() {} // 0x00000001891E8410-0x00000001891E8454
		public ArgumentOutOfRangeException(string paramName) {} // 0x00000001891E8454-0x00000001891E84A8
		public ArgumentOutOfRangeException(string paramName, string message) {} // 0x00000001842718F4-0x000000018427191C
		public ArgumentOutOfRangeException(string paramName, object actualValue, string message) {} // 0x00000001891E8300-0x00000001891E8348
		protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context) {} // 0x00000001891E8348-0x00000001891E8410
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001891E823C-0x00000001891E8300
	}

	[Serializable]
	public class ArithmeticException : SystemException // TypeDefIndex: 38706
	{
		// Constructors
		public ArithmeticException() {} // 0x00000001891E8538-0x00000001891E857C
		public ArithmeticException(string message) {} // 0x00000001891E857C-0x00000001891E859C
		public ArithmeticException(string message, Exception innerException) {} // 0x00000001891E859C-0x00000001891E85BC
		protected ArithmeticException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	[IsReadOnly]
	public struct ArraySegment<T> : IList<T>, IReadOnlyList<T> // TypeDefIndex: 38708
	{
		// Fields
		private readonly T[] _array;
		private readonly int _offset;
		private readonly int _count;
	
		// Properties
		public static ArraySegment<T> Empty { get; }
		public T[] Array { get => default; }
		public int Offset { get => default; }
		public int Count { get => default; }
		T IList<T>.this[int index] { get => default; set {} }
		T IReadOnlyList<T>.this[int index] { get => default; }
		bool ICollection<T>.IsReadOnly { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 38707
		{
			// Fields
			private readonly T[] _array;
			private readonly int _start;
			private readonly int _end;
			private int _current;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			internal Enumerator(ArraySegment<T> arraySegment) : this() {
				_array = default;
				_start = default;
				_end = default;
				_current = default;
			}
	
			// Methods
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
			public void Dispose() {}
		}
	
		// Constructors
		public ArraySegment(T[] array) : this() {
			_array = default;
			_offset = default;
			_count = default;
		}
		public ArraySegment(T[] array, int offset, int count) : this() {
			_array = default;
			_offset = default;
			_count = default;
		}
		static ArraySegment() {
	
		}
	
		// Methods
		public Enumerator GetEnumerator() => default;
		public override int GetHashCode() => default;
		public void CopyTo(T[] destination, int destinationIndex) {}
		public override bool Equals(object obj) => default;
		public bool Equals(ArraySegment<T> obj) => default;
		public static bool operator ==(ArraySegment<T> a, ArraySegment<T> b) => default;
		public static implicit operator ArraySegment<T>(T[] array) => default;
		int IList<T>.IndexOf(T item) => default;
		void IList<T>.Insert(int index, T item) {}
		void IList<T>.RemoveAt(int index) {}
		void ICollection<T>.Add(T item) {}
		void ICollection<T>.Clear() {}
		bool ICollection<T>.Contains(T item) => default;
		bool ICollection<T>.Remove(T item) => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		private void ThrowInvalidOperationIfDefault() {}
	}

	[Serializable]
	public class ArrayTypeMismatchException : SystemException // TypeDefIndex: 38709
	{
		// Constructors
		public ArrayTypeMismatchException() {} // 0x00000001891E85BC-0x00000001891E8600
		protected ArrayTypeMismatchException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	public class AssemblyLoadEventArgs : EventArgs // TypeDefIndex: 38710
	{
		// Constructors
		public AssemblyLoadEventArgs() {} // Dummy constructor
		public AssemblyLoadEventArgs(Assembly loadedAssembly) {} // 0x00000001891E8600-0x00000001891E8658
	}

	[Serializable]
	public delegate void AssemblyLoadEventHandler(object sender, AssemblyLoadEventArgs args); // TypeDefIndex: 38711; 0x0000000182065C10-0x0000000182065C20

	[Serializable]
	public delegate void AsyncCallback(IAsyncResult ar); // TypeDefIndex: 38712; 0x0000000183D36ED0-0x0000000183D36F60

	[Flags]
	public enum AttributeTargets // TypeDefIndex: 38713
	{
		Assembly = 1,
		Module = 2,
		Class = 4,
		Struct = 8,
		Enum = 16,
		Constructor = 32,
		Method = 64,
		Property = 128,
		Field = 256,
		Event = 512,
		Interface = 1024,
		Parameter = 2048,
		Delegate = 4096,
		ReturnValue = 8192,
		GenericParameter = 16384,
		All = 32767
	}

	[Serializable]
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public sealed class AttributeUsageAttribute : Attribute // TypeDefIndex: 38714
	{
		// Fields
		private AttributeTargets _attributeTarget; // 0x10
		private bool _allowMultiple; // 0x14
		private bool _inherited; // 0x15
		internal static AttributeUsageAttribute Default; // 0x00
	
		// Properties
		public bool AllowMultiple { get => default; set {} } // 0x0000000183D58C00-0x0000000183D58C10 0x0000000183D58C20-0x0000000183D58C30
		public bool Inherited { get => default; set {} } // 0x0000000183D58C10-0x0000000183D58C20 0x0000000183D58C30-0x0000000183D58C40
	
		// Constructors
		public AttributeUsageAttribute() {} // Dummy constructor
		public AttributeUsageAttribute(AttributeTargets validOn) {} // 0x00000001838A76F0-0x00000001838A7700
		static AttributeUsageAttribute() {} // 0x0000000183D003B0-0x0000000183D00420
	}

	[Serializable]
	public class BadImageFormatException : SystemException // TypeDefIndex: 38715
	{
		// Fields
		private string _fileName; // 0x90
		private string _fusionLog; // 0x98
	
		// Properties
		public override string Message { get => default; } // 0x00000001891E8B10-0x00000001891E8B2C 
	
		// Constructors
		public BadImageFormatException() {} // 0x00000001891E8ACC-0x00000001891E8B10
		public BadImageFormatException(string message) {} // 0x00000001891E8A70-0x00000001891E8A90
		public BadImageFormatException(string message, Exception inner) {} // 0x00000001891E8A50-0x00000001891E8A70
		public BadImageFormatException(string message, string fileName) {} // 0x00000001891E8A90-0x00000001891E8ACC
		protected BadImageFormatException(SerializationInfo info, StreamingContext context) {} // 0x00000001891E8990-0x00000001891E8A50
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001891E8658-0x00000001891E8760
		private void SetMessageField() {} // 0x00000001891E8760-0x00000001891E87D0
		public override string ToString() => default; // 0x00000001891E87D0-0x00000001891E8990
	}

	public static class BitConverter // TypeDefIndex: 38717
	{
		// Fields
		[Intrinsic]
		public static readonly bool IsLittleEndian; // 0x00
	
		// Constructors
		static BitConverter() {} // 0x0000000183D44AE0-0x0000000183D44B20
	
		// Methods
		public static byte[] GetBytes(bool value) => default; // 0x00000001891E8CE4-0x00000001891E8D3C
		public static byte[] GetBytes(char value) => default; // 0x00000001891E8B84-0x00000001891E8BDC
		public static byte[] GetBytes(short value) => default; // 0x00000001891E8B2C-0x00000001891E8B84
		public static byte[] GetBytes(int value) => default; // 0x00000001891E8D9C-0x00000001891E8DF4
		public static bool TryWriteBytes(Span<byte> destination, int value) => default; // 0x00000001891E93D8-0x00000001891E9444
		public static byte[] GetBytes(long value) => default; // 0x00000001891E8C8C-0x00000001891E8CE4
		[CLSCompliant(false)]
		public static byte[] GetBytes(ushort value) => default; // 0x00000001891E8BDC-0x00000001891E8C34
		[CLSCompliant(false)]
		public static byte[] GetBytes(uint value) => default; // 0x000000018338D650-0x000000018338D710
		[CLSCompliant(false)]
		public static bool TryWriteBytes(Span<byte> destination, uint value) => default; // 0x00000001891E936C-0x00000001891E93D8
		[CLSCompliant(false)]
		public static byte[] GetBytes(ulong value) => default; // 0x00000001891E8C34-0x00000001891E8C8C
		public static byte[] GetBytes(float value) => default; // 0x00000001891E8D3C-0x00000001891E8D9C
		public static byte[] GetBytes(double value) => default; // 0x00000001891E8DF4-0x00000001891E8E54
		public static short ToInt16(byte[] value, int startIndex) => default; // 0x00000001891E8E54-0x00000001891E8EAC
		public static short ToInt16(ReadOnlySpan<byte> value) => default; // 0x00000001891E8EAC-0x00000001891E8F14
		public static int ToInt32(byte[] value, int startIndex) => default; // 0x0000000182B12400-0x0000000182B12430
		public static int ToInt32(ReadOnlySpan<byte> value) => default; // 0x0000000182AB0420-0x0000000182AB0490
		public static long ToInt64(byte[] value, int startIndex) => default; // 0x0000000182B10B70-0x0000000182B10BB0
		[CLSCompliant(false)]
		public static ushort ToUInt16(byte[] value, int startIndex) => default; // 0x00000001891E9254-0x00000001891E92AC
		[CLSCompliant(false)]
		public static uint ToUInt32(byte[] value, int startIndex) => default; // 0x0000000182B10970-0x0000000182B109D0
		[CLSCompliant(false)]
		public static ulong ToUInt64(byte[] value, int startIndex) => default; // 0x00000001891E9314-0x00000001891E936C
		[CLSCompliant(false)]
		public static ulong ToUInt64(ReadOnlySpan<byte> value) => default; // 0x00000001891E92AC-0x00000001891E9314
		public static float ToSingle(byte[] value, int startIndex) => default; // 0x0000000182B12380-0x0000000182B12400
		public static string ToString(byte[] value, int startIndex, int length) => default; // 0x00000001891E8F70-0x00000001891E9254
		public static string ToString(byte[] value) => default; // 0x00000001891E8F14-0x00000001891E8F70
		public static long DoubleToInt64Bits(double value) => default; // 0x0000000183D70270-0x0000000183D70280
		public static double Int64BitsToDouble(long value) => default; // 0x0000000183D70280-0x0000000183D70290
		public static int SingleToInt32Bits(float value) => default; // 0x0000000183D70290-0x0000000183D702A0
		public static float Int32BitsToSingle(int value) => default; // 0x0000000183D6BFD0-0x0000000183D6BFE0
	}

	[Serializable]
	[IsReadOnly]
	public struct Boolean : IComparable, IConvertible, IComparable<bool>, IEquatable<bool> // TypeDefIndex: 38718
	{
		// Fields
		private readonly bool m_value; // 0x00
		internal const int True = 1; // Metadata: 0x01F9E007
		internal const int False = 0; // Metadata: 0x01F9E008
		internal const string TrueLiteral = "True"; // Metadata: 0x01F9E009
		internal const string FalseLiteral = "False"; // Metadata: 0x01F9E00E
		public static readonly string TrueString; // 0x00
		public static readonly string FalseString; // 0x08
	
		// Constructors
		static Boolean() {
			TrueString = default;
			FalseString = default;
		} // 0x0000000183CE04A0-0x0000000183CE0540
	
		// Methods
		public override int GetHashCode() => default; // 0x00000001830DD350-0x00000001830DD360
		public override string ToString() => default; // 0x0000000182D7EC30-0x0000000182D7EC80
		public string ToString(IFormatProvider provider) => default; // 0x00000001891E9B5C-0x00000001891E9BA8
		public bool TryFormat(Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x0000000183193870-0x0000000183193980
		public override bool Equals(object obj) => default; // 0x0000000183503B70-0x0000000183503BD0
		[NonVersionable]
		public bool Equals(bool obj) => default; // 0x000000018311BAE0-0x000000018311BAF0
		public int CompareTo(object obj) => default; // 0x00000001891E945C-0x00000001891E9528
		public int CompareTo(bool value) => default; // 0x00000001891E9444-0x00000001891E945C
		public static bool Parse(string value) => default; // 0x00000001891E95DC-0x00000001891E9698
		public static bool Parse(ReadOnlySpan<char> value) => default; // 0x00000001891E9528-0x00000001891E95DC
		public static bool TryParse(string value, out bool result) {
			result = default;
			return default;
		} // 0x00000001891E9E3C-0x00000001891E9EBC
		public static bool TryParse(ReadOnlySpan<char> value, out bool result) {
			result = default;
			return default;
		} // 0x00000001891E9CF0-0x00000001891E9E3C
		private static ReadOnlySpan<char> TrimWhiteSpaceAndNull(ReadOnlySpan<char> value) => default; // 0x00000001891E9BA8-0x00000001891E9CF0
		public TypeCode GetTypeCode() => default; // 0x0000000183D555E0-0x0000000183D555F0
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000183B42400-0x0000000183B42410
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x00000001891E96D8-0x00000001891E9768
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x00000001891E9950-0x00000001891E9990
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x00000001891E9698-0x00000001891E96D8
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x00000001891E98B0-0x00000001891E9900
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x00000001891E9A70-0x00000001891E9AC0
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000183973590-0x00000001839735E0
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x00000001891E9AC0-0x00000001891E9B0C
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x00000001891E9900-0x00000001891E9950
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x00000001891E9B0C-0x00000001891E9B5C
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x00000001891E9990-0x00000001891E99E4
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x00000001891E985C-0x00000001891E98B0
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x00000001891E97F8-0x00000001891E985C
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x00000001891E9768-0x00000001891E97F8
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x00000001891E99E4-0x00000001891E9A70
	}

	[Serializable]
	[IsReadOnly]
	public struct Byte : IComparable, IConvertible, IFormattable, IComparable<byte>, IEquatable<byte>, ISpanFormattable // TypeDefIndex: 38719
	{
		// Fields
		private readonly byte m_value; // 0x00
		public const byte MaxValue = 255; // Metadata: 0x01F9E014
		public const byte MinValue = 0; // Metadata: 0x01F9E015
	
		// Methods
		public int CompareTo(object value) => default; // 0x00000001891E9EBC-0x00000001891E9F74
		public int CompareTo(byte value) => default; // 0x0000000183D702A0-0x0000000183D702B0
		public override bool Equals(object obj) => default; // 0x00000001891E9F74-0x00000001891E9FD0
		[NonVersionable]
		public bool Equals(byte obj) => default; // 0x0000000182E0A450-0x0000000182E0A460
		public override int GetHashCode() => default; // 0x0000000183D51020-0x0000000183D51030
		public static byte Parse(string s, NumberStyles style) => default; // 0x000000018366C8C0-0x000000018366C930
		public static byte Parse(string s, IFormatProvider provider) => default; // 0x000000018366C850-0x000000018366C8C0
		public static byte Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x00000001891E9FD0-0x00000001891EA04C
		private static byte Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info) => default; // 0x000000018366C930-0x000000018366C9C0
		public static bool TryParse(string s, out byte result) {
			result = default;
			return default;
		} // 0x00000001891EA780-0x00000001891EA7E0
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result) {
			result = default;
			return default;
		} // 0x00000001891EA6F4-0x00000001891EA780
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out byte result) {
			result = default;
			return default;
		} // 0x00000001891EA654-0x00000001891EA6F4
		public override string ToString() => default; // 0x00000001891EA5DC-0x00000001891EA654
		public string ToString(string format) => default; // 0x00000001891EA564-0x00000001891EA5DC
		public string ToString(IFormatProvider provider) => default; // 0x00000001891EA458-0x00000001891EA4DC
		public string ToString(string format, IFormatProvider provider) => default; // 0x00000001891EA4DC-0x00000001891EA564
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider provider = null) {
			charsWritten = default;
			return default;
		} // 0x00000001823008D0-0x0000000182300980
		public TypeCode GetTypeCode() => default; // 0x0000000183D51110-0x0000000183D51120
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x00000001891EA04C-0x00000001891EA094
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x00000001891EA094-0x00000001891EA0DC
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x00000001891EA2A8-0x00000001891EA2F4
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000183D51020-0x0000000183D51030
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x00000001891EA218-0x00000001891EA260
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x00000001891EA3C8-0x00000001891EA410
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000183C94720-0x0000000183C94770
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x00000001891EA410-0x00000001891EA458
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x00000001891EA260-0x00000001891EA2A8
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000183626B70-0x0000000183626BC0
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x00000001891EA2F4-0x00000001891EA340
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x00000001891EA1CC-0x00000001891EA218
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x00000001891EA16C-0x00000001891EA1CC
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x00000001891EA0DC-0x00000001891EA16C
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x00000001891EA340-0x00000001891EA3C8
	}

	[Serializable]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	public sealed class CLSCompliantAttribute : Attribute // TypeDefIndex: 38720
	{
		// Fields
		private bool _compliant; // 0x10
	
		// Constructors
		public CLSCompliantAttribute() {} // Dummy constructor
		public CLSCompliantAttribute(bool isCompliant) {} // 0x0000000183D4E960-0x0000000183D4E970
	}

	[Serializable]
	[IsReadOnly]
	public struct Char : IComparable, IComparable<char>, IEquatable<char>, IConvertible // TypeDefIndex: 38721
	{
		// Fields
		private readonly char m_value; // 0x00
		public const char MaxValue = '\xffff'; // Metadata: 0x01F9E016
		public const char MinValue = '\x0000'; // Metadata: 0x01F9E018
		private static readonly byte[] s_categoryForLatin1; // 0x00
		internal const int UNICODE_PLANE00_END = 65535; // Metadata: 0x01F9E01A
		internal const int UNICODE_PLANE01_START = 65536; // Metadata: 0x01F9E01E
		internal const int UNICODE_PLANE16_END = 1114111; // Metadata: 0x01F9E022
		internal const int HIGH_SURROGATE_START = 55296; // Metadata: 0x01F9E026
		internal const int LOW_SURROGATE_END = 57343; // Metadata: 0x01F9E02A
	
		// Constructors
		static Char() {
			s_categoryForLatin1 = default;
		} // 0x0000000183CE5050-0x0000000183CE50E0
	
		// Methods
		private static bool IsLatin1(char ch) => default; // 0x000000018236B930-0x000000018236B940
		private static bool IsAscii(char ch) => default; // 0x0000000182368A80-0x0000000182368A90
		private static UnicodeCategory GetLatin1UnicodeCategory(char ch) => default; // 0x000000018236A1C0-0x000000018236A240
		public override int GetHashCode() => default; // 0x0000000183D702D0-0x0000000183D702E0
		public override bool Equals(object obj) => default; // 0x00000001891EAA68-0x00000001891EAAC8
		[NonVersionable]
		public bool Equals(char obj) => default; // 0x0000000182368630-0x0000000182368640
		public int CompareTo(object value) => default; // 0x00000001891EA870-0x00000001891EA928
		public int CompareTo(char value) => default; // 0x0000000183D702C0-0x0000000183D702D0
		public override string ToString() => default; // 0x0000000183082130-0x0000000183082180
		public string ToString(IFormatProvider provider) => default; // 0x00000001891EB854-0x00000001891EB8A0
		public static string ToString(char c) => default; // 0x0000000184274E14-0x0000000184274E1C
		public static char Parse(string s) => default; // 0x00000001891EB180-0x00000001891EB244
		public static bool TryParse(string s, out char result) {
			result = default;
			return default;
		} // 0x00000001891EB928-0x00000001891EB958
		public static bool IsDigit(char c) => default; // 0x000000018236AB90-0x000000018236AC10
		internal static bool CheckLetter(UnicodeCategory uc) => default; // 0x00000001891EA85C-0x00000001891EA864
		public static bool IsLetter(char c) => default; // 0x0000000182368960-0x00000001823689F0
		private static bool IsWhiteSpaceLatin1(char c) => default; // 0x000000018236B940-0x000000018236B970
		public static bool IsWhiteSpace(char c) => default; // 0x000000018236B620-0x000000018236B930
		public static bool IsUpper(char c) => default; // 0x0000000182697220-0x00000001826972C0
		public static bool IsLower(char c) => default; // 0x000000018353BDB0-0x000000018353BE50
		internal static bool CheckPunctuation(UnicodeCategory uc) => default; // 0x00000001836C62E0-0x00000001836C62F0
		public static bool IsPunctuation(char c) => default; // 0x00000001836C6230-0x00000001836C62E0
		internal static bool CheckLetterOrDigit(UnicodeCategory uc) => default; // 0x00000001826AFAE0-0x00000001826AFAF0
		public static bool IsLetterOrDigit(char c) => default; // 0x00000001826AF9A0-0x00000001826AFAE0
		public static char ToUpper(char c, CultureInfo culture) => default; // 0x00000001891EB8A0-0x00000001891EB928
		public static char ToUpper(char c) => default; // 0x00000001826972C0-0x0000000182697340
		public static char ToUpperInvariant(char c) => default; // 0x00000001835552D0-0x0000000183555350
		public static char ToLower(char c, CultureInfo culture) => default; // 0x00000001822FD4B0-0x00000001822FD4F0
		public static char ToLower(char c) => default; // 0x00000001891EB7EC-0x00000001891EB854
		public static char ToLowerInvariant(char c) => default; // 0x00000001822F9F20-0x00000001822F9FA0
		public TypeCode GetTypeCode() => default; // 0x0000000183D50CD0-0x0000000183D50CE0
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x00000001891EB244-0x00000001891EB2D4
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000183D4F990-0x0000000183D4F9A0
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x00000001891EB5AC-0x00000001891EB5F8
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x00000001891EB2D4-0x00000001891EB320
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x00000001891EB4D0-0x00000001891EB51C
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x00000001891EB714-0x00000001891EB75C
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x00000001891EB51C-0x00000001891EB564
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x00000001891EB75C-0x00000001891EB7A4
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x00000001891EB564-0x00000001891EB5AC
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x00000001891EB7A4-0x00000001891EB7EC
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x00000001891EB5F8-0x00000001891EB688
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x00000001891EB440-0x00000001891EB4D0
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x00000001891EB3B0-0x00000001891EB440
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x00000001891EB320-0x00000001891EB3B0
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x00000001891EB688-0x00000001891EB714
		public static bool IsControl(char c) => default; // 0x0000000183895B20-0x0000000183895B90
		public static bool IsLetterOrDigit(string s, int index) => default; // 0x00000001891EAD1C-0x00000001891EAE70
		internal static bool CheckNumber(UnicodeCategory uc) => default; // 0x00000001891EA864-0x00000001891EA870
		public static bool IsNumber(char c) => default; // 0x00000001823689F0-0x0000000182368A80
		public static bool IsNumber(string s, int index) => default; // 0x00000001891EAE8C-0x00000001891EB010
		internal static bool CheckSeparator(UnicodeCategory uc) => default; // 0x00000001834F4E80-0x00000001834F4F30
		private static bool IsSeparatorLatin1(char c) => default; // 0x00000001834F4E60-0x00000001834F4E80
		public static bool IsSeparator(char c) => default; // 0x00000001834F4DB0-0x00000001834F4E60
		public static bool IsSurrogate(char c) => default; // 0x00000001833979A0-0x00000001833979C0
		public static bool IsSurrogate(string s, int index) => default; // 0x0000000183397920-0x00000001833979A0
		public static bool IsWhiteSpace(string s, int index) => default; // 0x00000001891EB03C-0x00000001891EB180
		public static UnicodeCategory GetUnicodeCategory(char c) => default; // 0x000000018236A810-0x000000018236A8F0
		public static UnicodeCategory GetUnicodeCategory(string s, int index) => default; // 0x00000001891EAAC8-0x00000001891EAC0C
		public static double GetNumericValue(char c) => default; // 0x00000001891D364C-0x00000001891D3658
		public static bool IsHighSurrogate(char c) => default; // 0x0000000182767620-0x0000000182767640
		public static bool IsHighSurrogate(string s, int index) => default; // 0x00000001891EAC0C-0x00000001891EAD1C
		public static bool IsLowSurrogate(char c) => default; // 0x00000001891EAE70-0x00000001891EAE8C
		public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) => default; // 0x00000001891EB010-0x00000001891EB03C
		public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) => default; // 0x00000001891EA928-0x00000001891EAA68
	}

	[Serializable]
	public sealed class CharEnumerator : IEnumerator<char>, ICloneable // TypeDefIndex: 38722
	{
		// Fields
		private string _str; // 0x10
		private int _index; // 0x18
		private char _currentElement; // 0x1C
	
		// Properties
		object IEnumerator.Current { get => default; } // 0x00000001891EA7E0-0x00000001891EA82C 
		public char Current { get => default; } // 0x00000001835713F0-0x0000000183571430 
	
		// Constructors
		internal CharEnumerator(string str) {} // 0x00000001830840F0-0x0000000183084120
		internal CharEnumerator() {} // 0x00000001891EA82C-0x00000001891EA85C
	
		// Methods
		public object Clone() => default; // 0x0000000182A48500-0x0000000182A48510
		public bool MoveNext() => default; // 0x000000018348BD50-0x000000018348BDA0
		public void Dispose() {} // 0x000000018368EA20-0x000000018368EA50
		public void Reset() {} // 0x0000000183D702B0-0x0000000183D702C0
	}

	public static class Convert // TypeDefIndex: 38723
	{
		// Fields
		private static readonly sbyte[] s_decodingMap; // 0x00
		internal static readonly System.Type[] ConvertTypes; // 0x08
		private static readonly System.Type EnumType; // 0x10
		internal static readonly char[] base64Table; // 0x18
		public static readonly object DBNull; // 0x20
	
		// Constructors
		static Convert() {} // 0x00000001837649B0-0x0000000183765490
	
		// Methods
		private static bool TryDecodeFromUtf16(ReadOnlySpan<char> utf16, Span<byte> bytes, out int consumed, out int written) {
			consumed = default;
			written = default;
			return default;
		} // 0x00000001825D8DF0-0x00000001825D91D0
		private static int Decode(ref char encodedChars, ref sbyte decodingMap) => default; // 0x00000001891EBF04-0x00000001891EBF60
		private static void WriteThreeLowOrderBytes(ref byte destination, int value) {} // 0x0000000183D704A0-0x0000000183D704C0
		public static TypeCode GetTypeCode(object value) => default; // 0x00000001824DF450-0x00000001824DF5D0
		public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) => default; // 0x00000001891EB958-0x00000001891EBE1C
		internal static object DefaultToType(IConvertible value, System.Type targetType, IFormatProvider provider) => default; // 0x00000001891EBF60-0x00000001891EC7F8
		public static object ChangeType(object value, System.Type conversionType) => default; // 0x0000000182B1DF20-0x0000000182B1DFC0
		public static object ChangeType(object value, System.Type conversionType, IFormatProvider provider) => default; // 0x00000001824E1EE0-0x00000001824E2400
		private static void ThrowCharOverflowException() {} // 0x00000001891ECA80-0x00000001891ECADC
		private static void ThrowByteOverflowException() {} // 0x00000001891ECA24-0x00000001891ECA80
		private static void ThrowSByteOverflowException() {} // 0x00000001891ECBF0-0x00000001891ECC4C
		private static void ThrowInt16OverflowException() {} // 0x00000001891ECADC-0x00000001891ECB38
		private static void ThrowUInt16OverflowException() {} // 0x00000001891ECC4C-0x00000001891ECCA8
		private static void ThrowInt32OverflowException() {} // 0x00000001891ECB38-0x00000001891ECB94
		private static void ThrowUInt32OverflowException() {} // 0x00000001891ECCA8-0x00000001891ECD04
		private static void ThrowInt64OverflowException() {} // 0x00000001891ECB94-0x00000001891ECBF0
		private static void ThrowUInt64OverflowException() {} // 0x00000001891ECD04-0x00000001891ECD60
		public static bool ToBoolean(object value) => default; // 0x00000001891ED240-0x00000001891ED2AC
		public static bool ToBoolean(object value, IFormatProvider provider) => default; // 0x0000000182697A40-0x0000000182697B20
		[CLSCompliant(false)]
		public static bool ToBoolean(sbyte value) => default; // 0x00000001891ED238-0x00000001891ED240
		public static bool ToBoolean(byte value) => default; // 0x00000001891ED238-0x00000001891ED240
		public static bool ToBoolean(short value) => default; // 0x00000001891ED30C-0x00000001891ED314
		[CLSCompliant(false)]
		public static bool ToBoolean(ushort value) => default; // 0x00000001891ED30C-0x00000001891ED314
		public static bool ToBoolean(int value) => default; // 0x0000000183637400-0x0000000183637410
		[CLSCompliant(false)]
		public static bool ToBoolean(uint value) => default; // 0x0000000183637400-0x0000000183637410
		public static bool ToBoolean(long value) => default; // 0x00000001891ED230-0x00000001891ED238
		[CLSCompliant(false)]
		public static bool ToBoolean(ulong value) => default; // 0x00000001891ED230-0x00000001891ED238
		public static bool ToBoolean(string value) => default; // 0x00000001891ED2AC-0x00000001891ED2FC
		public static bool ToBoolean(string value, IFormatProvider provider) => default; // 0x00000001891ED394-0x00000001891ED3E4
		public static bool ToBoolean(float value) => default; // 0x00000001891ED2FC-0x00000001891ED30C
		public static bool ToBoolean(double value) => default; // 0x00000001891ED314-0x00000001891ED328
		public static bool ToBoolean(decimal value) => default; // 0x00000001891ED328-0x00000001891ED394
		public static char ToChar(object value) => default; // 0x00000001891EDA24-0x00000001891EDA98
		public static char ToChar(object value, IFormatProvider provider) => default; // 0x00000001891EDBD8-0x00000001891EDC5C
		[CLSCompliant(false)]
		public static char ToChar(sbyte value) => default; // 0x00000001891EDB88-0x00000001891EDBD8
		public static char ToChar(byte value) => default; // 0x0000000183D702E0-0x0000000183D702F0
		public static char ToChar(short value) => default; // 0x00000001891EDAE4-0x00000001891EDB34
		[CLSCompliant(false)]
		public static char ToChar(ushort value) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		public static char ToChar(int value) => default; // 0x00000001826952F0-0x0000000182695330
		[CLSCompliant(false)]
		public static char ToChar(uint value) => default; // 0x00000001891EDB34-0x00000001891EDB88
		public static char ToChar(long value) => default; // 0x00000001891ED9D8-0x00000001891EDA24
		[CLSCompliant(false)]
		public static char ToChar(ulong value) => default; // 0x00000001891ED8C0-0x00000001891ED914
		public static char ToChar(string value) => default; // 0x00000001891EDA98-0x00000001891EDAE4
		public static char ToChar(string value, IFormatProvider provider) => default; // 0x00000001891ED914-0x00000001891ED9D8
		[CLSCompliant(false)]
		public static sbyte ToSByte(object value) => default; // 0x00000001891EED4C-0x00000001891EEDB8
		[CLSCompliant(false)]
		public static sbyte ToSByte(object value, IFormatProvider provider) => default; // 0x00000001891EF214-0x00000001891EF28C
		[CLSCompliant(false)]
		public static sbyte ToSByte(bool value) => default; // 0x00000001891ED238-0x00000001891ED240
		[CLSCompliant(false)]
		public static sbyte ToSByte(char value) => default; // 0x00000001891EF11C-0x00000001891EF170
		[CLSCompliant(false)]
		public static sbyte ToSByte(byte value) => default; // 0x00000001891EF1C4-0x00000001891EF214
		[CLSCompliant(false)]
		public static sbyte ToSByte(short value) => default; // 0x00000001891EF078-0x00000001891EF0CC
		[CLSCompliant(false)]
		public static sbyte ToSByte(ushort value) => default; // 0x00000001891EEEBC-0x00000001891EEF10
		[CLSCompliant(false)]
		public static sbyte ToSByte(int value) => default; // 0x00000001891EF0CC-0x00000001891EF11C
		[CLSCompliant(false)]
		public static sbyte ToSByte(uint value) => default; // 0x00000001891EEDB8-0x00000001891EEE08
		[CLSCompliant(false)]
		public static sbyte ToSByte(long value) => default; // 0x00000001891EEE08-0x00000001891EEE58
		[CLSCompliant(false)]
		public static sbyte ToSByte(ulong value) => default; // 0x00000001891EF170-0x00000001891EF1C4
		[CLSCompliant(false)]
		public static sbyte ToSByte(float value) => default; // 0x00000001891EEE58-0x00000001891EEEAC
		[CLSCompliant(false)]
		public static sbyte ToSByte(double value) => default; // 0x00000001891EECFC-0x00000001891EED4C
		[CLSCompliant(false)]
		public static sbyte ToSByte(decimal value) => default; // 0x00000001891EEF10-0x00000001891EEF7C
		[CLSCompliant(false)]
		public static sbyte ToSByte(string value, IFormatProvider provider) => default; // 0x00000001891EEEAC-0x00000001891EEEBC
		public static byte ToByte(object value) => default; // 0x00000001891ED854-0x00000001891ED8C0
		public static byte ToByte(object value, IFormatProvider provider) => default; // 0x00000001891ED4D8-0x00000001891ED550
		public static byte ToByte(bool value) => default; // 0x00000001891ED238-0x00000001891ED240
		public static byte ToByte(char value) => default; // 0x00000001891ED60C-0x00000001891ED658
		[CLSCompliant(false)]
		public static byte ToByte(sbyte value) => default; // 0x00000001891ED7B8-0x00000001891ED808
		public static byte ToByte(short value) => default; // 0x00000001891ED438-0x00000001891ED484
		[CLSCompliant(false)]
		public static byte ToByte(ushort value) => default; // 0x00000001891ED808-0x00000001891ED854
		public static byte ToByte(int value) => default; // 0x0000000183D010F0-0x0000000183D01130
		[CLSCompliant(false)]
		public static byte ToByte(uint value) => default; // 0x00000001891ED67C-0x00000001891ED6D0
		public static byte ToByte(long value) => default; // 0x0000000182696390-0x00000001826963D0
		[CLSCompliant(false)]
		public static byte ToByte(ulong value) => default; // 0x00000001891ED3E4-0x00000001891ED438
		public static byte ToByte(float value) => default; // 0x00000001891ED484-0x00000001891ED4D8
		public static byte ToByte(double value) => default; // 0x00000001891ED5BC-0x00000001891ED60C
		public static byte ToByte(decimal value) => default; // 0x00000001891ED550-0x00000001891ED5BC
		public static byte ToByte(string value) => default; // 0x000000018366C7E0-0x000000018366C850
		public static byte ToByte(string value, IFormatProvider provider) => default; // 0x00000001891ED658-0x00000001891ED67C
		public static short ToInt16(object value) => default; // 0x00000001891EE6C8-0x00000001891EE73C
		public static short ToInt16(object value, IFormatProvider provider) => default; // 0x00000001891EE360-0x00000001891EE3E4
		public static short ToInt16(bool value) => default; // 0x0000000182C9E0C0-0x0000000182C9E0D0
		public static short ToInt16(char value) => default; // 0x00000001891EE604-0x00000001891EE650
		[CLSCompliant(false)]
		public static short ToInt16(sbyte value) => default; // 0x0000000183D703A0-0x0000000183D703B0
		public static short ToInt16(byte value) => default; // 0x0000000183D702E0-0x0000000183D702F0
		[CLSCompliant(false)]
		public static short ToInt16(ushort value) => default; // 0x00000001891EE314-0x00000001891EE360
		public static short ToInt16(int value) => default; // 0x00000001891EE73C-0x00000001891EE78C
		[CLSCompliant(false)]
		public static short ToInt16(uint value) => default; // 0x00000001891EE78C-0x00000001891EE7E0
		public static short ToInt16(long value) => default; // 0x00000001891EE3E4-0x00000001891EE438
		[CLSCompliant(false)]
		public static short ToInt16(ulong value) => default; // 0x00000001891EE438-0x00000001891EE48C
		public static short ToInt16(float value) => default; // 0x00000001891EE674-0x00000001891EE6C8
		public static short ToInt16(double value) => default; // 0x00000001891EE7E0-0x00000001891EE830
		public static short ToInt16(decimal value) => default; // 0x00000001891EE598-0x00000001891EE604
		public static short ToInt16(string value, IFormatProvider provider) => default; // 0x00000001891EE650-0x00000001891EE674
		[CLSCompliant(false)]
		public static ushort ToUInt16(object value) => default; // 0x00000001891EF9B4-0x00000001891EFA28
		[CLSCompliant(false)]
		public static ushort ToUInt16(object value, IFormatProvider provider) => default; // 0x00000001891EF930-0x00000001891EF9B4
		[CLSCompliant(false)]
		public static ushort ToUInt16(bool value) => default; // 0x0000000182C9E0C0-0x0000000182C9E0D0
		[CLSCompliant(false)]
		public static ushort ToUInt16(char value) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		[CLSCompliant(false)]
		public static ushort ToUInt16(sbyte value) => default; // 0x00000001891EF800-0x00000001891EF850
		[CLSCompliant(false)]
		public static ushort ToUInt16(byte value) => default; // 0x0000000183D702E0-0x0000000183D702F0
		[CLSCompliant(false)]
		public static ushort ToUInt16(short value) => default; // 0x00000001891EF8E0-0x00000001891EF930
		[CLSCompliant(false)]
		public static ushort ToUInt16(int value) => default; // 0x00000001891EFA28-0x00000001891EFA74
		[CLSCompliant(false)]
		public static ushort ToUInt16(uint value) => default; // 0x00000001891EFAC8-0x00000001891EFB1C
		[CLSCompliant(false)]
		public static ushort ToUInt16(long value) => default; // 0x00000001838A76B0-0x00000001838A76F0
		[CLSCompliant(false)]
		public static ushort ToUInt16(ulong value) => default; // 0x00000001891EFA74-0x00000001891EFAC8
		[CLSCompliant(false)]
		public static ushort ToUInt16(float value) => default; // 0x00000001891EFB6C-0x00000001891EFBC0
		[CLSCompliant(false)]
		public static ushort ToUInt16(double value) => default; // 0x00000001891EFB1C-0x00000001891EFB6C
		[CLSCompliant(false)]
		public static ushort ToUInt16(decimal value) => default; // 0x00000001891EF850-0x00000001891EF8BC
		[CLSCompliant(false)]
		public static ushort ToUInt16(string value, IFormatProvider provider) => default; // 0x00000001891EF8BC-0x00000001891EF8E0
		public static int ToInt32(object value) => default; // 0x00000001825FA760-0x00000001825FA7D0
		public static int ToInt32(object value, IFormatProvider provider) => default; // 0x00000001825FA650-0x00000001825FA6D0
		public static int ToInt32(bool value) => default; // 0x0000000182C9E0C0-0x0000000182C9E0D0
		public static int ToInt32(char value) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		public static int ToInt32(byte value) => default; // 0x0000000183D702E0-0x0000000183D702F0
		public static int ToInt32(short value) => default; // 0x0000000183D703B0-0x0000000183D703C0
		[CLSCompliant(false)]
		public static int ToInt32(ushort value) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		[CLSCompliant(false)]
		public static int ToInt32(uint value) => default; // 0x00000001891EE8DC-0x00000001891EE930
		public static int ToInt32(int value) => default; // 0x0000000183D517B0-0x0000000183D517C0
		public static int ToInt32(long value) => default; // 0x00000001891EE930-0x00000001891EE984
		[CLSCompliant(false)]
		public static int ToInt32(ulong value) => default; // 0x0000000182552E10-0x0000000182552E50
		public static int ToInt32(float value) => default; // 0x00000001891EE888-0x00000001891EE8DC
		public static int ToInt32(double value) => default; // 0x000000018299CAE0-0x000000018299CB40
		public static int ToInt32(decimal value) => default; // 0x00000001891EE984-0x00000001891EE9F0
		public static int ToInt32(string value) => default; // 0x00000001891EE830-0x00000001891EE888
		public static int ToInt32(string value, IFormatProvider provider) => default; // 0x00000001825FAC50-0x00000001825FAC70
		[CLSCompliant(false)]
		public static uint ToUInt32(object value) => default; // 0x00000001891EFD00-0x00000001891EFD6C
		[CLSCompliant(false)]
		public static uint ToUInt32(object value, IFormatProvider provider) => default; // 0x00000001891EFF10-0x00000001891EFF88
		[CLSCompliant(false)]
		public static uint ToUInt32(bool value) => default; // 0x0000000182C9E0C0-0x0000000182C9E0D0
		[CLSCompliant(false)]
		public static uint ToUInt32(char value) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		[CLSCompliant(false)]
		public static uint ToUInt32(sbyte value) => default; // 0x00000001891EFEC0-0x00000001891EFF10
		[CLSCompliant(false)]
		public static uint ToUInt32(byte value) => default; // 0x0000000183D702E0-0x0000000183D702F0
		[CLSCompliant(false)]
		public static uint ToUInt32(short value) => default; // 0x00000001891EFBC0-0x00000001891EFC10
		[CLSCompliant(false)]
		public static uint ToUInt32(ushort value) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		[CLSCompliant(false)]
		public static uint ToUInt32(int value) => default; // 0x00000001891EFCB0-0x00000001891EFD00
		[CLSCompliant(false)]
		public static uint ToUInt32(long value) => default; // 0x00000001830D8BD0-0x00000001830D8C10
		[CLSCompliant(false)]
		public static uint ToUInt32(ulong value) => default; // 0x00000001891EFC64-0x00000001891EFCB0
		[CLSCompliant(false)]
		public static uint ToUInt32(float value) => default; // 0x00000001891EFC10-0x00000001891EFC64
		[CLSCompliant(false)]
		public static uint ToUInt32(double value) => default; // 0x00000001891EFE14-0x00000001891EFEC0
		[CLSCompliant(false)]
		public static uint ToUInt32(decimal value) => default; // 0x00000001891EFF88-0x00000001891EFFF4
		[CLSCompliant(false)]
		public static uint ToUInt32(string value, IFormatProvider provider) => default; // 0x0000000182E56D80-0x0000000182E56DA0
		public static long ToInt64(object value) => default; // 0x00000001825F9080-0x00000001825F90F0
		public static long ToInt64(object value, IFormatProvider provider) => default; // 0x00000001825FA3D0-0x00000001825FA5D0
		public static long ToInt64(bool value) => default; // 0x00000001891EECF4-0x00000001891EECFC
		public static long ToInt64(char value) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		[CLSCompliant(false)]
		public static long ToInt64(sbyte value) => default; // 0x0000000183D703E0-0x0000000183D703F0
		public static long ToInt64(byte value) => default; // 0x0000000183D702E0-0x0000000183D702F0
		public static long ToInt64(short value) => default; // 0x0000000183D703C0-0x0000000183D703D0
		[CLSCompliant(false)]
		public static long ToInt64(ushort value) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		public static long ToInt64(int value) => default; // 0x0000000183D703D0-0x0000000183D703E0
		[CLSCompliant(false)]
		public static long ToInt64(uint value) => default; // 0x0000000183D517B0-0x0000000183D517C0
		[CLSCompliant(false)]
		public static long ToInt64(ulong value) => default; // 0x00000001891EEC24-0x00000001891EEC78
		public static long ToInt64(float value) => default; // 0x00000001891EEB40-0x00000001891EEB94
		public static long ToInt64(double value) => default; // 0x00000001891EEC78-0x00000001891EECF4
		public static long ToInt64(decimal value) => default; // 0x00000001891EEB94-0x00000001891EEC00
		public static long ToInt64(string value) => default; // 0x0000000182694760-0x00000001826947D0
		public static long ToInt64(string value, IFormatProvider provider) => default; // 0x00000001891EEC00-0x00000001891EEC24
		[CLSCompliant(false)]
		public static ulong ToUInt64(object value) => default; // 0x00000001833897C0-0x0000000183389830
		[CLSCompliant(false)]
		public static ulong ToUInt64(object value, IFormatProvider provider) => default; // 0x00000001825FA5D0-0x00000001825FA650
		[CLSCompliant(false)]
		public static ulong ToUInt64(bool value) => default; // 0x0000000182C9E0C0-0x0000000182C9E0D0
		[CLSCompliant(false)]
		public static ulong ToUInt64(char value) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		[CLSCompliant(false)]
		public static ulong ToUInt64(sbyte value) => default; // 0x00000001891EFFF4-0x00000001891F0044
		[CLSCompliant(false)]
		public static ulong ToUInt64(byte value) => default; // 0x0000000183D702E0-0x0000000183D702F0
		[CLSCompliant(false)]
		public static ulong ToUInt64(short value) => default; // 0x00000001891F01AC-0x00000001891F0200
		[CLSCompliant(false)]
		public static ulong ToUInt64(ushort value) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		[CLSCompliant(false)]
		public static ulong ToUInt64(int value) => default; // 0x00000001831744F0-0x0000000183174530
		[CLSCompliant(false)]
		public static ulong ToUInt64(uint value) => default; // 0x0000000183D517B0-0x0000000183D517C0
		[CLSCompliant(false)]
		public static ulong ToUInt64(long value) => default; // 0x0000000182F5D5C0-0x0000000182F5D600
		[CLSCompliant(false)]
		public static ulong ToUInt64(float value) => default; // 0x00000001891F00EC-0x00000001891F0140
		[CLSCompliant(false)]
		public static ulong ToUInt64(double value) => default; // 0x00000001891F0044-0x00000001891F00EC
		[CLSCompliant(false)]
		public static ulong ToUInt64(decimal value) => default; // 0x00000001891F0140-0x00000001891F01AC
		[CLSCompliant(false)]
		public static ulong ToUInt64(string value) => default; // 0x000000018268C910-0x000000018268C980
		[CLSCompliant(false)]
		public static ulong ToUInt64(string value, IFormatProvider provider) => default; // 0x00000001824E45A0-0x00000001824E4750
		public static float ToSingle(object value) => default; // 0x0000000182E3A700-0x0000000182E3A8B0
		public static float ToSingle(object value, IFormatProvider provider) => default; // 0x00000001891EF34C-0x00000001891EF3C4
		[CLSCompliant(false)]
		public static float ToSingle(sbyte value) => default; // 0x0000000183D70440-0x0000000183D70450
		public static float ToSingle(byte value) => default; // 0x0000000183D70400-0x0000000183D70410
		public static float ToSingle(short value) => default; // 0x0000000183D70410-0x0000000183D70420
		[CLSCompliant(false)]
		public static float ToSingle(ushort value) => default; // 0x0000000183D703F0-0x0000000183D70400
		public static float ToSingle(int value) => default; // 0x0000000183D70480-0x0000000183D70490
		[CLSCompliant(false)]
		public static float ToSingle(uint value) => default; // 0x0000000183D70420-0x0000000183D70430
		public static float ToSingle(long value) => default; // 0x0000000183D70430-0x0000000183D70440
		[CLSCompliant(false)]
		public static float ToSingle(ulong value) => default; // 0x0000000183D70450-0x0000000183D70480
		public static float ToSingle(double value) => default; // 0x0000000183D70490-0x0000000183D704A0
		public static float ToSingle(decimal value) => default; // 0x00000001891EF2E8-0x00000001891EF33C
		public static float ToSingle(string value) => default; // 0x00000001891EF28C-0x00000001891EF2E8
		public static float ToSingle(string value, IFormatProvider provider) => default; // 0x0000000182E3A920-0x0000000182E3A940
		public static float ToSingle(bool value) => default; // 0x00000001891EF33C-0x00000001891EF34C
		public static double ToDouble(object value) => default; // 0x000000018347E1B0-0x000000018347E300
		public static double ToDouble(object value, IFormatProvider provider) => default; // 0x00000001891EE278-0x00000001891EE2F0
		[CLSCompliant(false)]
		public static double ToDouble(sbyte value) => default; // 0x0000000183D702F0-0x0000000183D70300
		public static double ToDouble(byte value) => default; // 0x0000000183D70360-0x0000000183D70370
		public static double ToDouble(short value) => default; // 0x0000000183D70390-0x0000000183D703A0
		[CLSCompliant(false)]
		public static double ToDouble(ushort value) => default; // 0x0000000183D70350-0x0000000183D70360
		public static double ToDouble(int value) => default; // 0x0000000183D70300-0x0000000183D70310
		[CLSCompliant(false)]
		public static double ToDouble(uint value) => default; // 0x0000000183D70370-0x0000000183D70380
		public static double ToDouble(long value) => default; // 0x0000000183D70310-0x0000000183D70320
		[CLSCompliant(false)]
		public static double ToDouble(ulong value) => default; // 0x0000000183D70320-0x0000000183D70350
		public static double ToDouble(float value) => default; // 0x0000000183D70380-0x0000000183D70390
		public static double ToDouble(double value) => default; // 0x000000018350B670-0x000000018350B680
		public static double ToDouble(decimal value) => default; // 0x00000001891EE224-0x00000001891EE278
		public static double ToDouble(string value, IFormatProvider provider) => default; // 0x00000001891EE2F0-0x00000001891EE314
		public static double ToDouble(bool value) => default; // 0x00000001891EE214-0x00000001891EE224
		public static decimal ToDecimal(object value, IFormatProvider provider) => default; // 0x0000000183387810-0x00000001833879E0
		[CLSCompliant(false)]
		public static decimal ToDecimal(sbyte value) => default; // 0x00000001891EDF7C-0x00000001891EDFF4
		public static decimal ToDecimal(byte value) => default; // 0x00000001891EDE30-0x00000001891EDE94
		public static decimal ToDecimal(short value) => default; // 0x00000001891EDEF8-0x00000001891EDF7C
		[CLSCompliant(false)]
		public static decimal ToDecimal(ushort value) => default; // 0x00000001891EDFF4-0x00000001891EE058
		public static decimal ToDecimal(int value) => default; // 0x0000000183585860-0x00000001835858F0
		[CLSCompliant(false)]
		public static decimal ToDecimal(uint value) => default; // 0x00000001891EE120-0x00000001891EE184
		public static decimal ToDecimal(long value) => default; // 0x00000001836E5C70-0x00000001836E5CF0
		[CLSCompliant(false)]
		public static decimal ToDecimal(ulong value) => default; // 0x00000001891EE058-0x00000001891EE0C0
		public static decimal ToDecimal(float value) => default; // 0x00000001891EDDD0-0x00000001891EDE30
		public static decimal ToDecimal(double value) => default; // 0x00000001891EE0C0-0x00000001891EE120
		public static decimal ToDecimal(string value, IFormatProvider provider) => default; // 0x00000001891EE184-0x00000001891EE214
		public static decimal ToDecimal(bool value) => default; // 0x00000001891EDE94-0x00000001891EDEF8
		public static System.DateTime ToDateTime(object value, IFormatProvider provider) => default; // 0x00000001891EDC5C-0x00000001891EDCF8
		public static System.DateTime ToDateTime(string value) => default; // 0x00000001891EDD54-0x00000001891EDDD0
		public static System.DateTime ToDateTime(string value, IFormatProvider provider) => default; // 0x00000001891EDCF8-0x00000001891EDD54
		public static string ToString(object value) => default; // 0x00000001891EF3C4-0x00000001891EF410
		public static string ToString(object value, IFormatProvider provider) => default; // 0x00000001827C0740-0x00000001827C0810
		public static string ToString(bool value) => default; // 0x00000001891EF550-0x00000001891EF59C
		public static string ToString(char value, IFormatProvider provider) => default; // 0x00000001830820E0-0x0000000183082130
		public static string ToString(int value) => default; // 0x00000001891EF468-0x00000001891EF4C0
		public static string ToString(int value, IFormatProvider provider) => default; // 0x0000000184276634-0x0000000184276650
		public static string ToString(long value) => default; // 0x00000001891EF628-0x00000001891EF680
		public static string ToString(float value) => default; // 0x00000001891EF410-0x00000001891EF468
		public static byte ToByte(string value, int fromBase) => default; // 0x00000001891ED6D0-0x00000001891ED7B8
		[CLSCompliant(false)]
		public static sbyte ToSByte(string value, int fromBase) => default; // 0x00000001891EEF7C-0x00000001891EF078
		public static short ToInt16(string value, int fromBase) => default; // 0x00000001891EE48C-0x00000001891EE598
		[CLSCompliant(false)]
		public static ushort ToUInt16(string value, int fromBase) => default; // 0x00000001891EF70C-0x00000001891EF800
		public static int ToInt32(string value, int fromBase) => default; // 0x00000001891EE9F0-0x00000001891EEA98
		[CLSCompliant(false)]
		public static uint ToUInt32(string value, int fromBase) => default; // 0x00000001891EFD6C-0x00000001891EFE14
		public static long ToInt64(string value, int fromBase) => default; // 0x00000001891EEA98-0x00000001891EEB40
		[CLSCompliant(false)]
		public static ulong ToUInt64(string value, int fromBase) => default; // 0x00000001891F0200-0x00000001891F02A8
		public static string ToString(byte value, int toBase) => default; // 0x00000001891EF4C0-0x00000001891EF550
		public static string ToString(int value, int toBase) => default; // 0x00000001891EF59C-0x00000001891EF628
		public static string ToString(long value, int toBase) => default; // 0x00000001891EF680-0x00000001891EF70C
		public static string ToBase64String(byte[] inArray) => default; // 0x0000000183157DD0-0x0000000183157E60
		public static string ToBase64String(byte[] inArray, int offset, int length) => default; // 0x0000000183158080-0x0000000183158100
		public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) => default; // 0x0000000183158100-0x0000000183158320
		public static string ToBase64String(ReadOnlySpan<byte> bytes, Base64FormattingOptions options = Base64FormattingOptions.None /* Metadata: 0x01F9E02E */) => default; // 0x0000000183158320-0x0000000183158450
		public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut) => default; // 0x00000001891ECD60-0x00000001891ECDE0
		public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options) => default; // 0x00000001891ECDE0-0x00000001891ED230
		public static bool TryToBase64Chars(ReadOnlySpan<byte> bytes, Span<char> chars, out int charsWritten, Base64FormattingOptions options = Base64FormattingOptions.None /* Metadata: 0x01F9E02F */) {
			charsWritten = default;
			return default;
		} // 0x00000001891F0390-0x00000001891F055C
		private static unsafe int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) => default; // 0x00000001831584C0-0x00000001831587C0
		private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) => default; // 0x0000000183158450-0x00000001831584C0
		public static byte[] FromBase64String(string s) => default; // 0x0000000183189970-0x00000001831899E0
		public static bool TryFromBase64String(string s, Span<byte> bytes, out int bytesWritten) {
			bytesWritten = default;
			return default;
		} // 0x00000001891F02A8-0x00000001891F0390
		public static bool TryFromBase64Chars(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten) {
			bytesWritten = default;
			return default;
		} // 0x00000001825D8AF0-0x00000001825D8DF0
		private static void CopyToTempBufferWithoutWhiteSpace(ReadOnlySpan<char> chars, Span<char> tempBuffer, out int consumed, out int charsWritten) {
			consumed = default;
			charsWritten = default;
		} // 0x00000001891EBE1C-0x00000001891EBF04
		public static byte[] FromBase64CharArray(char[] inArray, int offset, int length) => default; // 0x00000001891EC7F8-0x00000001891ECA24
		private static unsafe byte[] FromBase64CharPtr(char* inputPtr, int inputLength) => default; // 0x00000001831899E0-0x0000000183189B30
		private static unsafe int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) => default; // 0x0000000183189B30-0x0000000183189BB0
	
		// Extension methods
		private static bool IsSpace(this char c) => default; // 0x00000001836A29B0-0x00000001836A29E0
	}

	[Flags]
	public enum Base64FormattingOptions // TypeDefIndex: 38724
	{
		None = 0,
		InsertLineBreaks = 1
	}

	[Serializable]
	public sealed class DBNull : ISerializable, IConvertible // TypeDefIndex: 38725
	{
		// Fields
		public static readonly DBNull Value; // 0x00
	
		// Constructors
		private DBNull() {} // 0x000000018350B670-0x000000018350B680
		private DBNull(SerializationInfo info, StreamingContext context) {} // 0x0000000189237EF0-0x0000000189237F4C
		static DBNull() {} // 0x0000000183D1B6B0-0x0000000183D1B710
	
		// Methods
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000189237908-0x0000000189237918
		public override string ToString() => default; // 0x0000000189237E80-0x0000000189237EB8
		public string ToString(IFormatProvider provider) => default; // 0x0000000189237EB8-0x0000000189237EF0
		public TypeCode GetTypeCode() => default; // 0x0000000182102C70-0x0000000182102C80
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000189237918-0x0000000189237974
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x00000001892379D0-0x0000000189237A2C
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000189237C54-0x0000000189237CB0
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000189237974-0x00000001892379D0
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000189237B40-0x0000000189237B9C
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000189237D6C-0x0000000189237DC8
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000189237B9C-0x0000000189237BF8
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000189237DC8-0x0000000189237E24
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000189237BF8-0x0000000189237C54
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000189237E24-0x0000000189237E80
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000189237CB0-0x0000000189237D0C
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000189237AE4-0x0000000189237B40
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000189237A88-0x0000000189237AE4
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000189237A2C-0x0000000189237A88
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x0000000189237D0C-0x0000000189237D6C
	}

	[Serializable]
	[IsReadOnly]
	public struct DateTime : IComparable, IFormattable, IConvertible, IComparable<System.DateTime>, IEquatable<System.DateTime>, ISerializable, ISpanFormattable // TypeDefIndex: 38726
	{
		// Fields
		private const long TicksPerMillisecond = 10000; // Metadata: 0x01F9E035
		private const long TicksPerSecond = 10000000; // Metadata: 0x01F9E03D
		private const long TicksPerMinute = 600000000; // Metadata: 0x01F9E045
		private const long TicksPerHour = 36000000000; // Metadata: 0x01F9E04D
		private const long TicksPerDay = 864000000000; // Metadata: 0x01F9E055
		private const int MillisPerSecond = 1000; // Metadata: 0x01F9E05D
		private const int MillisPerMinute = 60000; // Metadata: 0x01F9E05F
		private const int MillisPerHour = 3600000; // Metadata: 0x01F9E063
		private const int MillisPerDay = 86400000; // Metadata: 0x01F9E067
		private const int DaysPerYear = 365; // Metadata: 0x01F9E06B
		private const int DaysPer4Years = 1461; // Metadata: 0x01F9E06D
		private const int DaysPer100Years = 36524; // Metadata: 0x01F9E06F
		private const int DaysPer400Years = 146097; // Metadata: 0x01F9E073
		private const int DaysTo1601 = 584388; // Metadata: 0x01F9E077
		private const int DaysTo1899 = 693593; // Metadata: 0x01F9E07B
		internal const int DaysTo1970 = 719162; // Metadata: 0x01F9E07F
		private const int DaysTo10000 = 3652059; // Metadata: 0x01F9E083
		internal const long MinTicks = 0; // Metadata: 0x01F9E087
		internal const long MaxTicks = 3155378975999999999; // Metadata: 0x01F9E08F
		private const long MaxMillis = 315537897600000; // Metadata: 0x01F9E097
		internal const long UnixEpochTicks = 621355968000000000; // Metadata: 0x01F9E09F
		private const long FileTimeOffset = 504911232000000000; // Metadata: 0x01F9E0A7
		private const long DoubleDateOffset = 599264352000000000; // Metadata: 0x01F9E0AF
		private const long OADateMinAsTicks = 31241376000000000; // Metadata: 0x01F9E0B7
		private const double OADateMinAsDouble = -657435; // Metadata: 0x01F9E0BF
		private const double OADateMaxAsDouble = 2958466; // Metadata: 0x01F9E0C7
		private const int DatePartYear = 0; // Metadata: 0x01F9E0CF
		private const int DatePartDayOfYear = 1; // Metadata: 0x01F9E0D0
		private const int DatePartMonth = 2; // Metadata: 0x01F9E0D1
		private const int DatePartDay = 3; // Metadata: 0x01F9E0D2
		private static readonly int[] s_daysToMonth365; // 0x00
		private static readonly int[] s_daysToMonth366; // 0x08
		public static readonly DateTime MinValue; // 0x10
		public static readonly DateTime MaxValue; // 0x18
		public static readonly DateTime UnixEpoch; // 0x20
		private const ulong TicksMask = 4611686018427387903; // Metadata: 0x01F9E0D3
		private const ulong FlagsMask = 13835058055282163712; // Metadata: 0x01F9E0DB
		private const ulong LocalMask = 9223372036854775808; // Metadata: 0x01F9E0E3
		private const long TicksCeiling = 4611686018427387904; // Metadata: 0x01F9E0EB
		private const ulong KindUnspecified = 0; // Metadata: 0x01F9E0F3
		private const ulong KindUtc = 4611686018427387904; // Metadata: 0x01F9E0FB
		private const ulong KindLocal = 9223372036854775808; // Metadata: 0x01F9E103
		private const ulong KindLocalAmbiguousDst = 13835058055282163712; // Metadata: 0x01F9E10B
		private const int KindShift = 62; // Metadata: 0x01F9E113
		private const string TicksField = "ticks"; // Metadata: 0x01F9E114
		private const string DateDataField = "dateData"; // Metadata: 0x01F9E11A
		private readonly ulong _dateData; // 0x00
	
		// Properties
		internal long InternalTicks { get => default; } // 0x0000000183D707D0-0x0000000183D707F0 
		private ulong InternalKind { get => default; } // 0x0000000183D707B0-0x0000000183D707D0 
		public DateTime Date { get => default; } // 0x0000000182C98390-0x0000000182C98410 
		public int Day { get => default; } // 0x000000018299CB40-0x000000018299CBA0 
		public DayOfWeek DayOfWeek { get => default; } // 0x0000000189248DCC-0x0000000189248E4C 
		public int DayOfYear { get => default; } // 0x0000000189248E4C-0x0000000189248E9C 
		public int Hour { get => default; } // 0x000000018299D7B0-0x000000018299D840 
		public DateTimeKind Kind { get => default; } // 0x000000018299B410-0x000000018299B490 
		public int Millisecond { get => default; } // 0x0000000189248E9C-0x0000000189248F20 
		public int Minute { get => default; } // 0x0000000182CB5340-0x0000000182CB53D0 
		public int Month { get => default; } // 0x000000018299CBA0-0x000000018299CC00 
		public static DateTime Now { get => default; } // 0x000000018299ADF0-0x000000018299AF50 
		public int Second { get => default; } // 0x0000000182CB53D0-0x0000000182CB5460 
		public long Ticks { get => default; } // 0x000000018299B800-0x000000018299B860 
		public TimeSpan TimeOfDay { get => default; } // 0x0000000189248F20-0x0000000189248F7C 
		public static DateTime Today { get => default; } // 0x0000000189248F7C-0x0000000189248FD0 
		public int Year { get => default; } // 0x000000018299BDA0-0x000000018299BDF0 
		public static DateTime UtcNow { get => default; } // 0x00000001824CD910-0x00000001824CD980 
	
		// Constructors
		public DateTime(long ticks) : this() {
			_dateData = default;
		} // 0x000000018299B8F0-0x000000018299B910
		private DateTime(ulong dateData) : this() {
			_dateData = default;
		} // 0x0000000183D51730-0x0000000183D51740
		public DateTime(long ticks, DateTimeKind kind) : this() {
			_dateData = default;
		} // 0x000000018299C090-0x000000018299C0D0
		internal DateTime(long ticks, DateTimeKind kind, bool isAmbiguousDst) : this() {
			_dateData = default;
		} // 0x000000018299C300-0x000000018299C580
		public DateTime(int year, int month, int day) : this() {
			_dateData = default;
		} // 0x00000001825F4E00-0x00000001825F4E80
		public DateTime(int year, int month, int day, Calendar calendar) : this() {
			_dateData = default;
		} // 0x0000000189248804-0x0000000189248894
		public DateTime(int year, int month, int day, int hour, int minute, int second) : this() {
			_dateData = default;
		} // 0x00000001825F62A0-0x00000001825F6340
		public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) : this() {
			_dateData = default;
		} // 0x00000001825F6440-0x00000001825F6500
		public DateTime(int year, int month, int day, int hour, int minute, int second, Calendar calendar) : this() {
			_dateData = default;
		} // 0x0000000189248CB8-0x0000000189248DCC
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) : this() {
			_dateData = default;
		} // 0x0000000189248AF0-0x0000000189248CB8
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind) : this() {
			_dateData = default;
		} // 0x00000001892482FC-0x000000018924853C
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar) : this() {
			_dateData = default;
		} // 0x0000000189248894-0x0000000189248AF0
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, DateTimeKind kind) : this() {
			_dateData = default;
		} // 0x0000000189248020-0x00000001892482FC
		private DateTime(SerializationInfo info, StreamingContext context) : this() {
			_dateData = default;
		} // 0x000000018924853C-0x0000000189248804
		static DateTime() {
			s_daysToMonth365 = default;
			s_daysToMonth366 = default;
			MinValue = default;
			MaxValue = default;
			UnixEpoch = default;
		} // 0x0000000183A52800-0x0000000183A52940
	
		// Methods
		public DateTime Add(TimeSpan value) => default; // 0x0000000189244F04-0x0000000189244F60
		private DateTime Add(double value, int scale) => default; // 0x000000018299C5F0-0x000000018299C6B0
		public DateTime AddDays(double value) => default; // 0x000000018299E040-0x000000018299E0B0
		public DateTime AddHours(double value) => default; // 0x0000000189244B48-0x0000000189244BA0
		public DateTime AddMilliseconds(double value) => default; // 0x000000018299C580-0x000000018299C5F0
		public DateTime AddMinutes(double value) => default; // 0x0000000189244BA0-0x0000000189244BF8
		public DateTime AddMonths(int months) => default; // 0x0000000189244BF8-0x0000000189244E3C
		public DateTime AddSeconds(double value) => default; // 0x000000018299D5B0-0x000000018299D620
		public DateTime AddTicks(long value) => default; // 0x000000018299C6B0-0x000000018299C780
		public DateTime AddYears(int value) => default; // 0x0000000189244E3C-0x0000000189244F04
		public static int Compare(DateTime t1, DateTime t2) => default; // 0x0000000189245080-0x00000001892450E4
		public int CompareTo(object value) => default; // 0x0000000189244F60-0x000000018924502C
		public int CompareTo(DateTime value) => default; // 0x000000018924502C-0x0000000189245080
		private static long DateToTicks(int year, int month, int day) => default; // 0x00000001825F4E80-0x00000001825F5010
		private static long TimeToTicks(int hour, int minute, int second) => default; // 0x00000001825F6340-0x00000001825F63F0
		public static int DaysInMonth(int year, int month) => default; // 0x00000001892450E4-0x00000001892451F8
		internal static long DoubleDateToTicks(double value) => default; // 0x00000001892451F8-0x0000000189245344
		public override bool Equals(object value) => default; // 0x0000000189245344-0x00000001892453BC
		public bool Equals(DateTime value) => default; // 0x00000001892453BC-0x0000000189245414
		public static bool Equals(DateTime t1, DateTime t2) => default; // 0x0000000189245414-0x000000018924546C
		public static DateTime FromBinary(long dateData) => default; // 0x000000018924550C-0x000000018924571C
		internal static DateTime FromBinaryRaw(long dateData) => default; // 0x000000018924546C-0x000000018924550C
		public static DateTime FromFileTime(long fileTime) => default; // 0x00000001892457D0-0x0000000189245824
		public static DateTime FromFileTimeUtc(long fileTime) => default; // 0x000000018924571C-0x00000001892457D0
		public static DateTime FromOADate(double d) => default; // 0x0000000189245824-0x000000018924588C
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000189246E20-0x0000000189246F0C
		public bool IsDaylightSavingTime() => default; // 0x0000000189245CD0-0x0000000189245D5C
		public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) => default; // 0x000000018299CC60-0x000000018299CCF0
		public long ToBinary() => default; // 0x000000018924701C-0x00000001892470F4
		private int GetDatePart(int part) => default; // 0x000000018299BDF0-0x000000018299BFB0
		internal void GetDatePart(out int year, out int month, out int day) {
			year = default;
			month = default;
			day = default;
		} // 0x000000018924588C-0x0000000189245A40
		public override int GetHashCode() => default; // 0x0000000189245C30-0x0000000189245C80
		internal bool IsAmbiguousDaylightSavingTime() => default; // 0x0000000189245C80-0x0000000189245CD0
		public static bool IsLeapYear(int year) => default; // 0x00000001825F5010-0x00000001825F5050
		public static DateTime Parse(string s) => default; // 0x0000000189246210-0x00000001892462AC
		public static DateTime Parse(string s, IFormatProvider provider) => default; // 0x0000000189246390-0x000000018924643C
		public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles) => default; // 0x00000001892462AC-0x0000000189246390
		public static DateTime Parse(ReadOnlySpan<char> s, IFormatProvider provider = null, DateTimeStyles styles = DateTimeStyles.None /* Metadata: 0x01F9E032 */) => default; // 0x000000018924643C-0x00000001892464EC
		public static DateTime ParseExact(string s, string format, IFormatProvider provider) => default; // 0x0000000189246114-0x0000000189246210
		public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) => default; // 0x0000000189245E2C-0x0000000189245F5C
		public static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None /* Metadata: 0x01F9E033 */) => default; // 0x0000000189245D5C-0x0000000189245E2C
		public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style) => default; // 0x0000000189246020-0x0000000189246114
		public static DateTime ParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None /* Metadata: 0x01F9E034 */) => default; // 0x0000000189245F5C-0x0000000189246020
		public TimeSpan Subtract(DateTime value) => default; // 0x00000001892465E8-0x0000000189246644
		public DateTime Subtract(TimeSpan value) => default; // 0x00000001892464EC-0x00000001892465E8
		private static double TicksToOADate(long value) => default; // 0x0000000189246F0C-0x000000018924701C
		public double ToOADate() => default; // 0x0000000189247514-0x000000018924756C
		public long ToFileTime() => default; // 0x00000001892471C4-0x0000000189247218
		public long ToFileTimeUtc() => default; // 0x00000001892470F4-0x00000001892471C4
		public DateTime ToLocalTime() => default; // 0x0000000189247410-0x000000018924745C
		internal DateTime ToLocalTime(bool throwOnOverflow) => default; // 0x0000000189247218-0x0000000189247410
		public string ToLongDateString() => default; // 0x000000018924745C-0x00000001892474B8
		public string ToLongTimeString() => default; // 0x00000001892474B8-0x0000000189247514
		public string ToShortDateString() => default; // 0x000000018924756C-0x00000001892475C8
		public string ToShortTimeString() => default; // 0x00000001892475C8-0x0000000189247624
		public override string ToString() => default; // 0x0000000189247688-0x00000001892476D4
		public string ToString(string format) => default; // 0x000000018267D4F0-0x000000018267D560
		public string ToString(IFormatProvider provider) => default; // 0x00000001892476D4-0x000000018924772C
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000189247624-0x0000000189247688
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider provider = null) {
			charsWritten = default;
			return default;
		} // 0x000000018267D810-0x000000018267D8C0
		public DateTime ToUniversalTime() => default; // 0x000000018924772C-0x0000000189247780
		public static bool TryParse(string s, out DateTime result) {
			result = default;
			return default;
		} // 0x0000000189247E84-0x0000000189247F30
		public static bool TryParse(ReadOnlySpan<char> s, out DateTime result) {
			result = default;
			return default;
		} // 0x0000000189247DF0-0x0000000189247E84
		public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) {
			result = default;
			return default;
		} // 0x0000000189247F30-0x0000000189248020
		public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) {
			result = default;
			return default;
		} // 0x0000000189247D2C-0x0000000189247DF0
		public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result) {
			result = default;
			return default;
		} // 0x0000000189247B1C-0x0000000189247C50
		public static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style, out DateTime result) {
			result = default;
			return default;
		} // 0x0000000189247C50-0x0000000189247D2C
		public static bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result) {
			result = default;
			return default;
		} // 0x0000000189247A14-0x0000000189247B1C
		public static bool TryParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result) {
			result = default;
			return default;
		} // 0x0000000189247948-0x0000000189247A14
		public static DateTime operator +(DateTime d, TimeSpan t) => default; // 0x000000018299BCE0-0x000000018299BDA0
		public static DateTime operator -(DateTime d, TimeSpan t) => default; // 0x00000001892490DC-0x00000001892491D8
		public static TimeSpan operator -(DateTime d1, DateTime d2) => default; // 0x00000001824CD8A0-0x00000001824CD910
		public static bool operator ==(DateTime d1, DateTime d2) => default; // 0x0000000189248FD0-0x0000000189249028
		public static bool operator !=(DateTime d1, DateTime d2) => default; // 0x0000000189249084-0x00000001892490DC
		public static bool operator <(DateTime t1, DateTime t2) => default; // 0x000000018299C020-0x000000018299C090
		public static bool operator <=(DateTime t1, DateTime t2) => default; // 0x000000018299E0B0-0x000000018299E1D0
		public static bool operator >(DateTime t1, DateTime t2) => default; // 0x000000018299BFB0-0x000000018299C020
		public static bool operator >=(DateTime t1, DateTime t2) => default; // 0x0000000189249028-0x0000000189249084
		public string[] GetDateTimeFormats() => default; // 0x0000000189245B38-0x0000000189245BA8
		public string[] GetDateTimeFormats(IFormatProvider provider) => default; // 0x0000000189245A40-0x0000000189245AB8
		public string[] GetDateTimeFormats(char format) => default; // 0x0000000189245AB8-0x0000000189245B38
		public string[] GetDateTimeFormats(char format, IFormatProvider provider) => default; // 0x0000000189245BA8-0x0000000189245C30
		public TypeCode GetTypeCode() => default; // 0x0000000183D55B10-0x0000000183D55B20
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000189246644-0x00000001892466D4
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000189246764-0x00000001892467F4
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000189246AC4-0x0000000189246B54
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x00000001892466D4-0x0000000189246764
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000189246914-0x00000001892469A4
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000189246C70-0x0000000189246D00
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x00000001892469A4-0x0000000189246A34
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000189246D00-0x0000000189246D90
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000189246A34-0x0000000189246AC4
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000189246D90-0x0000000189246E20
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000189246B54-0x0000000189246BE4
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000189246884-0x0000000189246914
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x00000001892467F4-0x0000000189246884
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x00000001820C61B0-0x00000001820C61C0
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x0000000189246BE4-0x0000000189246C70
		internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) {
			result = default;
			return default;
		} // 0x0000000189247780-0x0000000189247948
		internal static long GetSystemTimeAsFileTime() => default; // 0x00000001842701D4-0x00000001842701F0
		internal long ToBinaryRaw() => default; // 0x00000001820C61B0-0x00000001820C61C0
	}

	public enum DateTimeKind // TypeDefIndex: 38727
	{
		Unspecified = 0,
		Utc = 1,
		Local = 2
	}

	[Serializable]
	[IsReadOnly]
	public struct DateTimeOffset : IComparable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanFormattable // TypeDefIndex: 38728
	{
		// Fields
		public static readonly DateTimeOffset MinValue; // 0x00
		public static readonly DateTimeOffset MaxValue; // 0x10
		public static readonly DateTimeOffset UnixEpoch; // 0x20
		private readonly System.DateTime _dateTime; // 0x00
		private readonly short _offsetMinutes; // 0x08
	
		// Properties
		public static DateTimeOffset Now { get => default; } // 0x000000018923B590-0x000000018923B5E8 
		public static DateTimeOffset UtcNow { get => default; } // 0x000000018923B75C-0x000000018923B7B4 
		public System.DateTime DateTime { get => default; } // 0x000000018923B2BC-0x000000018923B308 
		public System.DateTime UtcDateTime { get => default; } // 0x000000018299CC00-0x000000018299CC60 
		public System.DateTime LocalDateTime { get => default; } // 0x000000018923B3E0-0x000000018923B44C 
		private System.DateTime ClockDateTime { get => default; } // 0x000000018923B214-0x000000018923B2BC 
		public int Day { get => default; } // 0x000000018923B308-0x000000018923B374 
		public int Hour { get => default; } // 0x000000018923B374-0x000000018923B3E0 
		public int Millisecond { get => default; } // 0x000000018923B44C-0x000000018923B4B8 
		public int Minute { get => default; } // 0x000000018923B4B8-0x000000018923B524 
		public int Month { get => default; } // 0x000000018923B524-0x000000018923B590 
		public TimeSpan Offset { get => default; } // 0x000000018923B5E8-0x000000018923B618 
		public int Second { get => default; } // 0x000000018923B618-0x000000018923B684 
		public long Ticks { get => default; } // 0x000000018923B684-0x000000018923B6F0 
		public TimeSpan TimeOfDay { get => default; } // 0x000000018923B6F0-0x000000018923B75C 
		public int Year { get => default; } // 0x000000018923B7B4-0x000000018923B820 
	
		// Constructors
		public DateTimeOffset(long ticks, TimeSpan offset) : this() {
			_dateTime = default;
			_offsetMinutes = default;
		} // 0x00000001837D26F0-0x00000001837D27B0
		public DateTimeOffset(System.DateTime dateTime) : this() {
			_dateTime = default;
			_offsetMinutes = default;
		} // 0x000000018299D6B0-0x000000018299D7B0
		public DateTimeOffset(System.DateTime dateTime, TimeSpan offset) : this() {
			_dateTime = default;
			_offsetMinutes = default;
		} // 0x000000018923AD9C-0x000000018923AFA0
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset) : this() {
			_dateTime = default;
			_offsetMinutes = default;
		} // 0x000000018923AFA0-0x000000018923B060
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset) : this() {
			_dateTime = default;
			_offsetMinutes = default;
		} // 0x000000018923B140-0x000000018923B214
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset) : this() {
			_dateTime = default;
			_offsetMinutes = default;
		} // 0x000000018923B060-0x000000018923B140
		private DateTimeOffset(SerializationInfo info, StreamingContext context) : this() {
			_dateTime = default;
			_offsetMinutes = default;
		} // 0x000000018923AC34-0x000000018923AD9C
		static DateTimeOffset() {
			MinValue = default;
			MaxValue = default;
			UnixEpoch = default;
		} // 0x00000001837D23F0-0x00000001837D2640
	
		// Methods
		public DateTimeOffset ToOffset(TimeSpan offset) => default; // 0x000000018923A264-0x000000018923A2F0
		public static int Compare(DateTimeOffset first, DateTimeOffset second) => default; // 0x00000001892398D4-0x0000000189239958
		int IComparable.CompareTo(object obj) => default; // 0x0000000189239ECC-0x0000000189239FF4
		public int CompareTo(DateTimeOffset other) => default; // 0x0000000189239828-0x00000001892398D4
		public override bool Equals(object obj) => default; // 0x0000000189239958-0x0000000189239A08
		public bool Equals(DateTimeOffset other) => default; // 0x0000000189239A08-0x0000000189239A90
		public static DateTimeOffset FromFileTime(long fileTime) => default; // 0x0000000189239A90-0x0000000189239AF4
		public static DateTimeOffset FromUnixTimeSeconds(long seconds) => default; // 0x00000001837D2640-0x00000001837D26F0
		void IDeserializationCallback.OnDeserialization(object sender) {} // 0x0000000189239FF4-0x000000018923A130
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x000000018923A130-0x000000018923A1F8
		public override int GetHashCode() => default; // 0x0000000189239AF4-0x0000000189239B60
		public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) => default; // 0x0000000189239E48-0x0000000189239ECC
		public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) => default; // 0x0000000189239D04-0x0000000189239E48
		public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles) => default; // 0x0000000189239B60-0x0000000189239D04
		public long ToFileTime() => default; // 0x000000018923A1F8-0x000000018923A264
		public long ToUnixTimeSeconds() => default; // 0x000000018299D0B0-0x000000018299D290
		public override string ToString() => default; // 0x000000018923A394-0x000000018923A41C
		public string ToString(string format) => default; // 0x000000018923A41C-0x000000018923A4B4
		public string ToString(IFormatProvider formatProvider) => default; // 0x000000018923A4B4-0x000000018923A54C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018923A2F0-0x000000018923A394
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider formatProvider = null) {
			charsWritten = default;
			return default;
		} // 0x000000018923A5B0-0x000000018923A68C
		public DateTimeOffset ToUniversalTime() => default; // 0x000000018923A54C-0x000000018923A5B0
		public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) {
			result = default;
			return default;
		} // 0x000000018923A99C-0x000000018923AAFC
		public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) {
			result = default;
			return default;
		} // 0x000000018923A68C-0x000000018923A82C
		public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) {
			result = default;
			return default;
		} // 0x000000018923A82C-0x000000018923A99C
		private static short ValidateOffset(TimeSpan offset) => default; // 0x000000018299D840-0x000000018299D9E0
		private static System.DateTime ValidateDate(System.DateTime dateTime, TimeSpan offset) => default; // 0x000000018299C780-0x000000018299C820
		private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) => default; // 0x000000018923AAFC-0x000000018923AC34
		public static implicit operator DateTimeOffset(System.DateTime dateTime) => default; // 0x000000018299D590-0x000000018299D5B0
		public static TimeSpan operator -(DateTimeOffset left, DateTimeOffset right) => default; // 0x000000018923B928-0x000000018923B9AC
		public static bool operator ==(DateTimeOffset left, DateTimeOffset right) => default; // 0x000000018923B820-0x000000018923B8A4
		public static bool operator !=(DateTimeOffset left, DateTimeOffset right) => default; // 0x000000018923B8A4-0x000000018923B928
	}

	public enum DayOfWeek // TypeDefIndex: 38729
	{
		Sunday = 0,
		Monday = 1,
		Tuesday = 2,
		Wednesday = 3,
		Thursday = 4,
		Friday = 5,
		Saturday = 6
	}

	[Serializable]
	public class DivideByZeroException : ArithmeticException // TypeDefIndex: 38730
	{
		// Constructors
		public DivideByZeroException() {} // 0x00000001892491F8-0x000000018924923C
		public DivideByZeroException(string message) {} // 0x00000001892491D8-0x00000001892491F8
		public DivideByZeroException(string message, Exception innerException) {} // 0x000000018924923C-0x000000018924925C
		protected DivideByZeroException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
	}

	[Serializable]
	public class DllNotFoundException : TypeLoadException // TypeDefIndex: 38731
	{
		// Constructors
		public DllNotFoundException() {} // 0x000000018924929C-0x00000001892492E0
		public DllNotFoundException(string message) {} // 0x000000018924927C-0x000000018924929C
		protected DllNotFoundException(SerializationInfo info, StreamingContext context) {} // 0x000000018924925C-0x000000018924927C
	}

	[Serializable]
	[IsReadOnly]
	public struct Double : IComparable, IConvertible, IFormattable, IComparable<double>, IEquatable<double>, ISpanFormattable // TypeDefIndex: 38732
	{
		// Fields
		private readonly double m_value; // 0x00
		public const double MinValue = -1.7976931348623157E+308; // Metadata: 0x01F9E12D
		public const double MaxValue = 1.7976931348623157E+308; // Metadata: 0x01F9E135
		public const double Epsilon = 5E-324; // Metadata: 0x01F9E13D
		public const double NegativeInfinity = -1D / 0D; // Metadata: 0x01F9E145
		public const double PositiveInfinity = 1D / 0D; // Metadata: 0x01F9E14D
		public const double NaN = 0D / 0D; // Metadata: 0x01F9E155
		internal const double NegativeZero = -0; // Metadata: 0x01F9E15D
	
		// Methods
		[NonVersionable]
		public static bool IsFinite(double d) => default; // 0x00000001892494E8-0x0000000189249548
		[NonVersionable]
		public static bool IsInfinity(double d) => default; // 0x0000000189249548-0x00000001892495A8
		[NonVersionable]
		public static bool IsNaN(double d) => default; // 0x00000001892495A8-0x0000000189249608
		[NonVersionable]
		public static bool IsNegative(double d) => default; // 0x000000018924961C-0x0000000189249668
		[NonVersionable]
		public static bool IsNegativeInfinity(double d) => default; // 0x0000000189249608-0x000000018924961C
		[NonVersionable]
		public static bool IsPositiveInfinity(double d) => default; // 0x0000000189249668-0x000000018924967C
		public int CompareTo(object value) => default; // 0x00000001892492E0-0x00000001892493CC
		public int CompareTo(double value) => default; // 0x0000000182A53D80-0x0000000182A53DB0
		public override bool Equals(object obj) => default; // 0x00000001892493CC-0x0000000189249448
		public bool Equals(double obj) => default; // 0x0000000189249448-0x0000000189249470
		public override int GetHashCode() => default; // 0x0000000189249470-0x00000001892494E8
		public override string ToString() => default; // 0x0000000189249D70-0x0000000189249DD0
		public string ToString(string format) => default; // 0x000000018315D160-0x000000018315D1E0
		public string ToString(IFormatProvider provider) => default; // 0x00000001822FC890-0x00000001822FC910
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000189249DD0-0x0000000189249E4C
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider provider = null) {
			charsWritten = default;
			return default;
		} // 0x00000001822FB7D0-0x00000001822FB8A0
		public static double Parse(string s) => default; // 0x00000001892497B8-0x0000000189249840
		public static double Parse(string s, IFormatProvider provider) => default; // 0x000000018924967C-0x0000000189249710
		public static double Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x0000000189249710-0x00000001892497B8
		public static bool TryParse(string s, out double result) {
			result = default;
			return default;
		} // 0x0000000182F1BB50-0x0000000182F1BBB0
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result) {
			result = default;
			return default;
		} // 0x0000000182377F60-0x0000000182378440
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out double result) {
			result = default;
			return default;
		} // 0x0000000182378440-0x00000001823788E0
		public TypeCode GetTypeCode() => default; // 0x0000000183D55AC0-0x0000000183D55AD0
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000189249840-0x0000000189249898
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x00000001892498F0-0x0000000189249980
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000189249B84-0x0000000189249BDC
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000189249898-0x00000001892498F0
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000189249A7C-0x0000000189249AD4
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000189249C68-0x0000000189249CC0
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000189249AD4-0x0000000189249B2C
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000189249CC0-0x0000000189249D18
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000189249B2C-0x0000000189249B84
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000189249D18-0x0000000189249D70
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x000000018303A640-0x000000018303A6A0
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000183D5EC30-0x0000000183D5EC40
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000189249A10-0x0000000189249A7C
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000189249980-0x0000000189249A10
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x0000000189249BDC-0x0000000189249C68
	}

	[Serializable]
	public class EntryPointNotFoundException : TypeLoadException // TypeDefIndex: 38733
	{
		// Constructors
		public EntryPointNotFoundException() {} // 0x0000000189249E4C-0x0000000189249E90
		public EntryPointNotFoundException(string message) {} // 0x0000000189249E90-0x0000000189249EB0
		protected EntryPointNotFoundException(SerializationInfo info, StreamingContext context) {} // 0x000000018924925C-0x000000018924927C
	}

	[Serializable]
	public class EventArgs // TypeDefIndex: 38734
	{
		// Fields
		public static readonly EventArgs Empty; // 0x00
	
		// Constructors
		public EventArgs() {} // 0x000000018350B670-0x000000018350B680
		static EventArgs() {} // 0x0000000183D1B5F0-0x0000000183D1B650
	}

	public delegate void EventHandler(object sender, EventArgs e); // TypeDefIndex: 38735; 0x0000000182065C10-0x0000000182065C20

	public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e); // TypeDefIndex: 38736; 0x00000000-0x00000000

	[Serializable]
	[Obsolete("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
	public sealed class ExecutionEngineException : SystemException // TypeDefIndex: 38737
	{
		// Constructors
		public ExecutionEngineException() {} // 0x0000000182944370-0x00000001829443C0
		public ExecutionEngineException(string message) {} // 0x0000000189249EB0-0x0000000189249ED0
		internal ExecutionEngineException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	public class FieldAccessException : MemberAccessException // TypeDefIndex: 38738
	{
		// Constructors
		public FieldAccessException() {} // 0x0000000189249EF0-0x0000000189249F34
		public FieldAccessException(string message) {} // 0x0000000189249ED0-0x0000000189249EF0
		protected FieldAccessException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
	}

	[Serializable]
	[AttributeUsage(AttributeTargets.Enum, Inherited = false)]
	public class FlagsAttribute : Attribute // TypeDefIndex: 38739
	{
		// Constructors
		public FlagsAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class FormatException : SystemException // TypeDefIndex: 38740
	{
		// Constructors
		public FormatException() {} // 0x0000000189249F54-0x0000000189249F98
		public FormatException(string message) {} // 0x00000001839B95D0-0x00000001839B95F0
		public FormatException(string message, Exception innerException) {} // 0x0000000189249F34-0x0000000189249F54
		protected FormatException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	public abstract class FormattableString : IFormattable // TypeDefIndex: 38741
	{
		// Properties
		public abstract string Format { get; }
		public abstract int ArgumentCount { get; }
	
		// Constructors
		protected FormattableString() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract object[] GetArguments();
		public abstract object GetArgument(int index);
		public abstract string ToString(IFormatProvider formatProvider);
		string IFormattable.ToString(string ignored, IFormatProvider formatProvider) => default; // 0x0000000189249F98-0x0000000189249FA8
		public override string ToString() => default; // 0x0000000189249FA8-0x000000018924A044
	}

	internal sealed class Gen2GcCallback : CriticalFinalizerObject // TypeDefIndex: 38742
	{
		// Fields
		private System.Func<object, bool> _callback; // 0x10
		private GCHandle _weakTargetObj; // 0x18
	
		// Constructors
		private Gen2GcCallback() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void Register(System.Func<object, bool> callback, object targetObj) {} // 0x0000000182D39840-0x0000000182D398A0
		private void Setup(System.Func<object, bool> callback, object targetObj) {} // 0x0000000182D398A0-0x0000000182D398D0
		~Gen2GcCallback() {} // 0x0000000182CB2CD0-0x0000000182CB3230
	}

	internal static class DateTimeFormat // TypeDefIndex: 38743
	{
		// Fields
		internal static readonly TimeSpan NullOffset; // 0x00
		internal static char[] allStandardFormats; // 0x08
		internal static readonly DateTimeFormatInfo InvariantFormatInfo; // 0x10
		internal static readonly string[] InvariantAbbreviatedMonthNames; // 0x18
		internal static readonly string[] InvariantAbbreviatedDayNames; // 0x20
		internal static string[] fixedNumberFormats; // 0x28
	
		// Constructors
		static DateTimeFormat() {} // 0x0000000183615D00-0x0000000183616000
	
		// Methods
		internal static void FormatDigits(StringBuilder outputBuffer, int value, int len) {} // 0x00000001825EF2F0-0x00000001825EF370
		internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit) {} // 0x00000001825EF370-0x00000001825EF470
		private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits) {} // 0x0000000189238B74-0x0000000189238BD8
		internal static int ParseRepeatPattern(ReadOnlySpan<char> format, int pos, char patternChar) => default; // 0x00000001825EF270-0x00000001825EF2F0
		private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi) => default; // 0x0000000189238548-0x0000000189238588
		private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi) => default; // 0x000000018923862C-0x000000018923866C
		private static string FormatHebrewMonthName(System.DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi) => default; // 0x0000000189238588-0x000000018923862C
		internal static int ParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result) => default; // 0x0000000189238D5C-0x0000000189238F5C
		internal static int ParseNextChar(ReadOnlySpan<char> format, int pos) => default; // 0x0000000189238D00-0x0000000189238D5C
		private static bool IsUseGenitiveForm(ReadOnlySpan<char> format, int index, int tokenLen, char patternToMatch) => default; // 0x0000000189238BD8-0x0000000189238D00
		private static StringBuilder FormatCustomized(System.DateTime dateTime, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, TimeSpan offset, StringBuilder result) => default; // 0x00000001825EE9A0-0x00000001825EF270
		private static void FormatCustomizedTimeZone(System.DateTime dateTime, TimeSpan offset, ReadOnlySpan<char> format, int tokenLen, bool timeOnly, StringBuilder result) {} // 0x00000001892381FC-0x0000000189238548
		private static void FormatCustomizedRoundripTimeZone(System.DateTime dateTime, TimeSpan offset, StringBuilder result) {} // 0x0000000189237FC0-0x00000001892381FC
		private static void Append2DigitNumber(StringBuilder result, int val) {} // 0x0000000189237F4C-0x0000000189237FC0
		internal static string GetRealFormat(ReadOnlySpan<char> format, DateTimeFormatInfo dtfi) => default; // 0x000000018267DF60-0x000000018267DFF0
		private static string ExpandPredefinedFormat(ReadOnlySpan<char> format, ref System.DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset) => default; // 0x000000018267DE50-0x000000018267DF60
		internal static string Format(System.DateTime dateTime, string format, IFormatProvider provider) => default; // 0x000000018267D560-0x000000018267D5F0
		internal static string Format(System.DateTime dateTime, string format, IFormatProvider provider, TimeSpan offset) => default; // 0x000000018267D5F0-0x000000018267D730
		internal static bool TryFormat(System.DateTime dateTime, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) {
			charsWritten = default;
			return default;
		} // 0x000000018267D8C0-0x000000018267D990
		internal static bool TryFormat(System.DateTime dateTime, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, TimeSpan offset) {
			charsWritten = default;
			return default;
		} // 0x000000018267D990-0x000000018267DAF0
		private static StringBuilder FormatStringBuilder(System.DateTime dateTime, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, TimeSpan offset) => default; // 0x000000018267DC10-0x000000018267DE50
		private static bool TryFormatO(System.DateTime dateTime, TimeSpan offset, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x0000000189238F5C-0x00000001892393BC
		private static bool TryFormatR(System.DateTime dateTime, TimeSpan offset, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x00000001892393BC-0x000000018923977C
		private static void WriteTwoDecimalDigits(uint value, Span<char> destination, int offset) {} // 0x000000018923766C-0x0000000189237908
		private static void WriteFourDecimalDigits(uint value, Span<char> buffer, int startingIndex = 0 /* Metadata: 0x01F9E165 */) {} // 0x000000018923759C-0x000000018923766C
		private static void WriteDigits(ulong value, Span<char> buffer) {} // 0x000000018923977C-0x0000000189239828
		internal static string[] GetAllDateTimes(System.DateTime dateTime, char format, DateTimeFormatInfo dtfi) => default; // 0x000000018923866C-0x00000001892389C8
		internal static string[] GetAllDateTimes(System.DateTime dateTime, DateTimeFormatInfo dtfi) => default; // 0x00000001892389C8-0x0000000189238B74
		internal static void InvalidFormatForLocal(ReadOnlySpan<char> format, System.DateTime dateTime) {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class DateTimeParse // TypeDefIndex: 38749
	{
		// Fields
		internal static MatchNumberDelegate m_hebrewNumberParser; // 0x00
		private static DS[][] dateParsingStates; // 0x08
	
		// Nested types
		internal delegate bool MatchNumberDelegate(ref __DTString str, int digitLen, out int result); // TypeDefIndex: 38744; 0x0000000181035ED0-0x0000000181035EF0
	
		internal enum DTT // TypeDefIndex: 38745
		{
			End = 0,
			NumEnd = 1,
			NumAmpm = 2,
			NumSpace = 3,
			NumDatesep = 4,
			NumTimesep = 5,
			MonthEnd = 6,
			MonthSpace = 7,
			MonthDatesep = 8,
			NumDatesuff = 9,
			NumTimesuff = 10,
			DayOfWeek = 11,
			YearSpace = 12,
			YearDateSep = 13,
			YearEnd = 14,
			TimeZone = 15,
			Era = 16,
			NumUTCTimeMark = 17,
			Unk = 18,
			NumLocalTimeMark = 19,
			Max = 20
		}
	
		internal enum TM // TypeDefIndex: 38746
		{
			NotSet = -1,
			AM = 0,
			PM = 1
		}
	
		internal enum DS // TypeDefIndex: 38747
		{
			BEGIN = 0,
			N = 1,
			NN = 2,
			D_Nd = 3,
			D_NN = 4,
			D_NNd = 5,
			D_M = 6,
			D_MN = 7,
			D_NM = 8,
			D_MNd = 9,
			D_NDS = 10,
			D_Y = 11,
			D_YN = 12,
			D_YNd = 13,
			D_YM = 14,
			D_YMd = 15,
			D_S = 16,
			T_S = 17,
			T_Nt = 18,
			T_NNt = 19,
			ERROR = 20,
			DX_NN = 21,
			DX_NNN = 22,
			DX_MN = 23,
			DX_NM = 24,
			DX_MNN = 25,
			DX_DS = 26,
			DX_DSN = 27,
			DX_NDS = 28,
			DX_NNDS = 29,
			DX_YNN = 30,
			DX_YMN = 31,
			DX_YN = 32,
			DX_YM = 33,
			TX_N = 34,
			TX_NN = 35,
			TX_NNN = 36,
			TX_TS = 37,
			DX_NNY = 38
		}
	
		// Constructors
		static DateTimeParse() {} // 0x00000001892445A8-0x0000000189244B48
	
		// Methods
		internal static System.DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style) => default; // 0x00000001892417F8-0x0000000189241914
		internal static System.DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out TimeSpan offset) {
			offset = default;
			return default;
		} // 0x00000001892416A0-0x00000001892417F8
		internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out System.DateTime result) {
			result = default;
			return default;
		} // 0x0000000189243720-0x0000000189243838
		internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out System.DateTime result, out TimeSpan offset) {
			result = default;
			offset = default;
			return default;
		} // 0x0000000189243838-0x0000000189243998
		internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) => default; // 0x0000000189243630-0x0000000189243720
		internal static System.DateTime ParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style) => default; // 0x0000000189241590-0x00000001892416A0
		internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out System.DateTime result, out TimeSpan offset) {
			result = default;
			offset = default;
			return default;
		} // 0x0000000189243298-0x00000001892433EC
		internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out System.DateTime result) {
			result = default;
			return default;
		} // 0x0000000189243178-0x0000000189243298
		internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) => default; // 0x00000001892433EC-0x0000000189243630
		private static bool MatchWord(ref __DTString str, string target) => default; // 0x00000001892403C4-0x000000018924051C
		private static bool GetTimeZoneName(ref __DTString str) => default; // 0x000000018923E698-0x000000018923E724
		internal static bool IsDigit(char ch) => default; // 0x000000018923EB8C-0x000000018923EB9C
		private static bool ParseFraction(ref __DTString str, out double result) {
			result = default;
			return default;
		} // 0x0000000189241A30-0x0000000189241AF8
		private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result) => default; // 0x0000000189242284-0x00000001892425B4
		private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result) => default; // 0x000000018923EA34-0x000000018923EB8C
		private static bool Lex(DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles) => default; // 0x000000018923EB9C-0x000000018923F98C
		private static Calendar GetJapaneseCalendarDefaultInstance() => default; // 0x000000018923E358-0x000000018923E3F8
		internal static Calendar GetTaiwanCalendarDefaultInstance() => default; // 0x000000018923E550-0x000000018923E5F0
		private static bool VerifyValidPunctuation(ref __DTString str) => default; // 0x00000001892443BC-0x00000001892445A8
		private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order) {
			order = default;
			return default;
		} // 0x000000018923E724-0x000000018923E8F8
		private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order) {
			order = default;
			return default;
		} // 0x000000018923E8F8-0x000000018923EA34
		private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order) {
			order = default;
			return default;
		} // 0x000000018923E3F8-0x000000018923E550
		private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear) {
			adjustedYear = default;
			return default;
		} // 0x00000001892430CC-0x0000000189243178
		private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day) => default; // 0x0000000189243064-0x00000001892430CC
		private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year) => default; // 0x0000000189242F7C-0x0000000189242FF0
		private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year) => default; // 0x0000000189242F08-0x0000000189242F7C
		private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month) => default; // 0x0000000189242FF0-0x0000000189243064
		private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles) {} // 0x000000018923E1BC-0x000000018923E240
		private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x000000018923DDDC-0x000000018923DF00
		private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x000000018923DA68-0x000000018923DCB4
		private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x000000018923D6F8-0x000000018923D8B0
		private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x000000018923E240-0x000000018923E358
		private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x000000018923D8B0-0x000000018923DA68
		private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x000000018923D41C-0x000000018923D6F8
		private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x000000018923E024-0x000000018923E12C
		private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x000000018923DCB4-0x000000018923DDDC
		private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw) => default; // 0x000000018923DF00-0x000000018923DF98
		private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw) => default; // 0x000000018923E12C-0x000000018923E1BC
		private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw) => default; // 0x000000018923DF98-0x000000018923E024
		private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw) {} // 0x000000018923B9D8-0x000000018923BA88
		private static bool AdjustHour(ref int hour, TM timeMark) => default; // 0x000000018923B9AC-0x000000018923B9D8
		private static bool GetTimeOfN(ref DateTimeResult result, ref DateTimeRawInfo raw) => default; // 0x000000018923E668-0x000000018923E698
		private static bool GetTimeOfNN(ref DateTimeResult result, ref DateTimeRawInfo raw) => default; // 0x000000018923E634-0x000000018923E668
		private static bool GetTimeOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw) => default; // 0x000000018923E5F0-0x000000018923E634
		private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw) => default; // 0x000000018923CF34-0x000000018923CF60
		private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw) => default; // 0x000000018923CF60-0x000000018923CFE0
		private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x000000018923CFE0-0x000000018923D1B8
		private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok) => default; // 0x00000001892427C8-0x0000000189242884
		internal static bool ProcessHebrewTerminalState(DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x0000000189242884-0x0000000189242BF8
		internal static bool ProcessTerminalState(DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x0000000189242BF8-0x0000000189242F08
		internal static System.DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles) => default; // 0x00000001892426C8-0x00000001892427C8
		internal static System.DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset) {
			offset = default;
			return default;
		} // 0x00000001892425B4-0x00000001892426C8
		internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out System.DateTime result) {
			result = default;
			return default;
		} // 0x0000000189243BE4-0x0000000189243CE8
		internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out System.DateTime result, out TimeSpan offset) {
			result = default;
			offset = default;
			return default;
		} // 0x0000000189243AA4-0x0000000189243BE4
		internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result) => default; // 0x0000000189243CE8-0x00000001892443BC
		private static bool DetermineTimeZoneAdjustments(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly) => default; // 0x000000018923C204-0x000000018923C3EC
		private static bool DateTimeOffsetTimeZonePostProcessing(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles) => default; // 0x000000018923C014-0x000000018923C204
		private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result) => default; // 0x000000018923BCBC-0x000000018923BD90
		private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly) => default; // 0x000000018923BA88-0x000000018923BCBC
		private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result) => default; // 0x0000000189241AF8-0x0000000189241F88
		internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number) {
			number = default;
			return default;
		} // 0x000000018923FFDC-0x0000000189240098
		internal static bool ParseDigits(ref __DTString str, int digitLen, out int result) {
			result = default;
			return default;
		} // 0x0000000189241518-0x0000000189241590
		internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result) {
			result = default;
			return default;
		} // 0x0000000189241454-0x0000000189241518
		private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result) => default; // 0x0000000189241914-0x0000000189241A30
		private static bool ParseSign(ref __DTString str, ref bool result) => default; // 0x0000000189242050-0x00000001892420D4
		private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result) => default; // 0x00000001892420D4-0x0000000189242284
		private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) => default; // 0x000000018923FAA0-0x000000018923FC38
		private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) => default; // 0x0000000189240098-0x0000000189240270
		private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) => default; // 0x000000018923F98C-0x000000018923FAA0
		private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) => default; // 0x000000018923FD5C-0x000000018923FE70
		private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) => default; // 0x000000018923FE70-0x000000018923FFDC
		private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref TM result) => default; // 0x0000000189240270-0x00000001892403C4
		private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref TM result) => default; // 0x000000018923FC38-0x000000018923FD5C
		private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result) => default; // 0x000000018923BF78-0x000000018923C014
		private static System.DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles) => default; // 0x000000018923D1B8-0x000000018923D294
		private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles) => default; // 0x000000018923BD90-0x000000018923BF78
		private static string ExpandPredefinedFormat(ReadOnlySpan<char> format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result) => default; // 0x000000018923CC0C-0x000000018923CF34
		private static bool ParseJapaneseEraStart(ref __DTString str, DateTimeFormatInfo dtfi) => default; // 0x0000000189241F88-0x0000000189242050
		private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result) => default; // 0x000000018924051C-0x0000000189241454
		internal static bool TryParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result, out int returnValue) {
			returnValue = default;
			return default;
		} // 0x0000000189243998-0x0000000189243AA4
		private static bool DoStrictParse(ReadOnlySpan<char> s, ReadOnlySpan<char> formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result) => default; // 0x000000018923C3EC-0x000000018923CC0C
		private static Exception GetDateTimeParseException(ref DateTimeResult result) => default; // 0x000000018923D294-0x000000018923D41C
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal struct __DTString // TypeDefIndex: 38750
	{
		// Fields
		internal ReadOnlySpan<char> Value; // 0x00
		internal int Index; // 0x10
		internal char m_current; // 0x14
		private CompareInfo m_info; // 0x18
		private bool m_checkDigitToken; // 0x20
		private static readonly char[] WhiteSpaceChecks; // 0x00
	
		// Properties
		internal int Length { get => default; } // 0x00000001892535F4-0x0000000189253628 
		internal CompareInfo CompareInfo { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		internal __DTString(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi, bool checkDigitToken) : this() {
			Value = default;
			Index = default;
			m_current = default;
			m_info = default;
			m_checkDigitToken = default;
		} // 0x00000001892534BC-0x000000018925353C
		internal __DTString(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi) : this() {
			Value = default;
			Index = default;
			m_current = default;
			m_info = default;
			m_checkDigitToken = default;
		} // 0x000000018925353C-0x00000001892535F4
		static __DTString() {
			WhiteSpaceChecks = default;
		} // 0x000000018925343C-0x00000001892534BC
	
		// Methods
		internal bool GetNext() => default; // 0x0000000189252184-0x00000001892521FC
		internal bool AtEnd() => default; // 0x0000000189251FD8-0x000000018925202C
		internal bool Advance(int count) => default; // 0x0000000189251F60-0x0000000189251FD8
		internal void GetRegularToken(out System.TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi) {
			tokenType = default;
			tokenValue = default;
		} // 0x00000001892521FC-0x000000018925246C
		internal System.TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator) {
			indexBeforeSeparator = default;
			charBeforeSeparator = default;
			return default;
		} // 0x000000018925252C-0x000000018925260C
		internal bool MatchSpecifiedWord(string target) => default; // 0x0000000189252808-0x00000001892528EC
		internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength) => default; // 0x00000001892528EC-0x0000000189252C28
		internal bool Match(string str) => default; // 0x0000000189252C28-0x0000000189252D20
		internal bool Match(char ch) => default; // 0x0000000189252D20-0x0000000189252DA8
		internal int MatchLongestWords(string[] words, ref int maxMatchStrLen) => default; // 0x0000000189252744-0x0000000189252808
		internal int GetRepeatCount() => default; // 0x000000018925246C-0x000000018925252C
		internal bool GetNextDigit() => default; // 0x00000001892520F0-0x0000000189252184
		internal char GetChar() => default; // 0x00000001892520AC-0x00000001892520CC
		internal int GetDigit() => default; // 0x00000001892520CC-0x00000001892520F0
		internal void SkipWhiteSpaces() {} // 0x00000001892532B8-0x0000000189253354
		internal bool SkipWhiteSpaceCurrent() => default; // 0x00000001892531F4-0x00000001892532B8
		internal void TrimTail() {} // 0x0000000189253354-0x000000018925343C
		internal void RemoveTrailingInQuoteSpaces() {} // 0x0000000189252FE8-0x00000001892531F4
		internal void RemoveLeadingInQuoteSpaces() {} // 0x0000000189252DA8-0x0000000189252FE8
		internal DTSubString GetSubString() => default; // 0x000000018925260C-0x0000000189252744
		internal void ConsumeSubString(DTSubString sub) {} // 0x000000018925202C-0x00000001892520AC
	}

	internal enum DTSubStringType // TypeDefIndex: 38751
	{
		Unknown = 0,
		Invalid = 1,
		Number = 2,
		End = 3,
		Other = 4
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal struct DTSubString // TypeDefIndex: 38752
	{
		// Fields
		internal ReadOnlySpan<char> s; // 0x00
		internal int index; // 0x10
		internal int length; // 0x14
		internal DTSubStringType type; // 0x18
		internal int value; // 0x1C
	
		// Properties
		internal char this[int relativeIndex] { get => default; } // 0x000000018924A2E4-0x000000018924A30C 
	}

	internal struct DateTimeToken // TypeDefIndex: 38753
	{
		// Fields
		internal DateTimeParse.DTT dtt; // 0x00
		internal System.TokenType suffix; // 0x04
		internal int num; // 0x08
	}

	internal struct DateTimeRawInfo // TypeDefIndex: 38754
	{
		// Fields
		private unsafe int* num; // 0x00
		internal int numCount; // 0x08
		internal int month; // 0x0C
		internal int year; // 0x10
		internal int dayOfWeek; // 0x14
		internal int era; // 0x18
		internal DateTimeParse.TM timeMark; // 0x1C
		internal double fraction; // 0x20
		internal bool hasSameDateAndTimeSeparators; // 0x28
	
		// Methods
		internal unsafe void Init(int* numberBuffer) {} // 0x0000000183D70810-0x0000000183D70840
		internal void AddNumber(int value) {} // 0x0000000183D707F0-0x0000000183D70810
		internal int GetNumber(int index) => default; // 0x0000000183D6A4C0-0x0000000183D6A4D0
	}

	internal enum ParseFailureKind // TypeDefIndex: 38755
	{
		None = 0,
		ArgumentNull = 1,
		Format = 2,
		FormatWithParameter = 3,
		FormatWithOriginalDateTime = 4,
		FormatWithFormatSpecifier = 5,
		FormatWithOriginalDateTimeAndParameter = 6,
		FormatBadDateTimeCalendar = 7
	}

	[Flags]
	internal enum ParseFlags // TypeDefIndex: 38756
	{
		HaveYear = 1,
		HaveMonth = 2,
		HaveDay = 4,
		HaveHour = 8,
		HaveMinute = 16,
		HaveSecond = 32,
		HaveTime = 64,
		HaveDate = 128,
		TimeZoneUsed = 256,
		TimeZoneUtc = 512,
		ParsedMonthName = 1024,
		CaptureOffset = 2048,
		YearDefault = 4096,
		Rfc1123Pattern = 8192,
		UtcSortPattern = 16384
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal struct DateTimeResult // TypeDefIndex: 38757
	{
		// Fields
		internal int Year; // 0x00
		internal int Month; // 0x04
		internal int Day; // 0x08
		internal int Hour; // 0x0C
		internal int Minute; // 0x10
		internal int Second; // 0x14
		internal double fraction; // 0x18
		internal int era; // 0x20
		internal ParseFlags flags; // 0x24
		internal TimeSpan timeZoneOffset; // 0x28
		internal Calendar calendar; // 0x30
		internal System.DateTime parsedDate; // 0x38
		internal System.ParseFailureKind failure; // 0x40
		internal string failureMessageID; // 0x48
		internal object failureMessageFormatArgument; // 0x50
		internal string failureArgumentName; // 0x58
		internal ReadOnlySpan<char> originalDateTimeString; // 0x60
		internal ReadOnlySpan<char> failedFormatSpecifier; // 0x70
	
		// Methods
		internal void Init(ReadOnlySpan<char> originalDateTimeString) {} // 0x0000000183D70840-0x0000000183D70870
		internal void SetDate(int year, int month, int day) {} // 0x0000000183D4E5D0-0x0000000183D4E5E0
		internal void SetBadFormatSpecifierFailure() {} // 0x000000018924A3A4-0x000000018924A3E8
		internal void SetBadFormatSpecifierFailure(ReadOnlySpan<char> failedFormatSpecifier) {} // 0x000000018924A354-0x000000018924A3A4
		internal void SetBadDateTimeFailure() {} // 0x000000018924A30C-0x000000018924A354
		internal void SetFailure(System.ParseFailureKind failure, string failureMessageID) {} // 0x0000000183D708A0-0x0000000183D708B0
		internal void SetFailure(System.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) {} // 0x0000000183D70870-0x0000000183D70880
		internal void SetFailure(System.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) {} // 0x0000000183D70880-0x0000000183D708A0
	}

	internal struct ParsingInfo // TypeDefIndex: 38758
	{
		// Fields
		internal Calendar calendar; // 0x00
		internal int dayOfWeek; // 0x08
		internal DateTimeParse.TM timeMark; // 0x0C
		internal bool fUseHour12; // 0x10
		internal bool fUseTwoDigitYear; // 0x11
		internal bool fAllowInnerWhite; // 0x12
		internal bool fAllowTrailingWhite; // 0x13
		internal bool fCustomNumberParser; // 0x14
		internal DateTimeParse.MatchNumberDelegate parseNumberDelegate; // 0x18
	
		// Methods
		internal void Init() {} // 0x0000000183D70AC0-0x0000000183D70AD0
	}

	internal enum TokenType // TypeDefIndex: 38759
	{
		NumberToken = 1,
		YearNumberToken = 2,
		Am = 3,
		Pm = 4,
		MonthToken = 5,
		EndOfString = 6,
		DayOfWeekToken = 7,
		TimeZoneToken = 8,
		EraToken = 9,
		DateWordToken = 10,
		UnknownToken = 11,
		HebrewNumber = 12,
		JapaneseEraToken = 13,
		TEraToken = 14,
		IgnorableSymbol = 15,
		RegularTokenMask = 255,
		SEP_Unk = 256,
		SEP_End = 512,
		SEP_Space = 768,
		SEP_Am = 1024,
		SEP_Pm = 1280,
		SEP_Date = 1536,
		SEP_Time = 1792,
		SEP_YearSuff = 2048,
		SEP_MonthSuff = 2304,
		SEP_DaySuff = 2560,
		SEP_HourSuff = 2816,
		SEP_MinuteSuff = 3072,
		SEP_SecondSuff = 3328,
		SEP_LocalTimeMark = 3584,
		SEP_DateOrOffset = 3840,
		SeparatorTokenMask = 65280
	}

	[Serializable]
	[NonVersionable]
	public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>, ISpanFormattable // TypeDefIndex: 38764
	{
		// Fields
		public static readonly Guid Empty; // 0x00
		private int _a; // 0x00
		private short _b; // 0x04
		private short _c; // 0x06
		private byte _d; // 0x08
		private byte _e; // 0x09
		private byte _f; // 0x0A
		private byte _g; // 0x0B
		private byte _h; // 0x0C
		private byte _i; // 0x0D
		private byte _j; // 0x0E
		private byte _k; // 0x0F
	
		// Nested types
		[Flags]
		private enum GuidStyles // TypeDefIndex: 38760
		{
			None = 0,
			NumberFormat = 0,
			AllowParenthesis = 1,
			AllowBraces = 2,
			AllowDashes = 4,
			AllowHexPrefix = 8,
			Any = 15,
			RequireParenthesis = 16,
			RequireBraces = 32,
			RequireDashes = 64,
			DigitFormat = 64,
			ParenthesisFormat = 80,
			BraceFormat = 96,
			RequireHexPrefix = 128,
			HexFormat = 160
		}
	
		private enum GuidParseThrowStyle // TypeDefIndex: 38761
		{
			None = 0,
			All = 1,
			AllButOverflow = 2
		}
	
		private enum ParseFailureKind // TypeDefIndex: 38762
		{
			None = 0,
			ArgumentNull = 1,
			Format = 2,
			FormatWithParameter = 3,
			NativeException = 4,
			FormatWithInnerException = 5
		}
	
		private struct GuidResult // TypeDefIndex: 38763
		{
			// Fields
			internal Guid _parsedGuid; // 0x00
			internal GuidParseThrowStyle _throwStyle; // 0x10
			private System.Guid.ParseFailureKind _failure; // 0x14
			private string _failureMessageID; // 0x18
			private object _failureMessageFormatArgument; // 0x20
			private string _failureArgumentName; // 0x28
			private Exception _innerException; // 0x30
	
			// Methods
			internal void Init(GuidParseThrowStyle canThrow) {} // 0x00000001810410F0-0x0000000181041100
			internal void SetFailure(Exception nativeException) {} // 0x000000018924A408-0x000000018924A41C
			internal void SetFailure(System.Guid.ParseFailureKind failure, string failureMessageID) {} // 0x000000018924A41C-0x000000018924A440
			internal void SetFailure(System.Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) {} // 0x000000018924A3E8-0x000000018924A408
			internal void SetFailure(System.Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) {} // 0x00000001839B94A0-0x00000001839B9530
			internal Exception GetGuidParseException() => default; // 0x00000001839B9530-0x00000001839B95D0
		}
	
		// Constructors
		public Guid(byte[] b) {
			_a = default;
			_b = default;
			_c = default;
			_d = default;
			_e = default;
			_f = default;
			_g = default;
			_h = default;
			_i = default;
			_j = default;
			_k = default;
		} // 0x0000000182942450-0x00000001829424D0
		public Guid(ReadOnlySpan<byte> b) {
			_a = default;
			_b = default;
			_c = default;
			_d = default;
			_e = default;
			_f = default;
			_g = default;
			_h = default;
			_i = default;
			_j = default;
			_k = default;
		} // 0x0000000182942790-0x00000001829428C0
		[CLSCompliant(false)]
		public Guid(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) {
			_a = default;
			_b = default;
			_c = default;
			_d = default;
			_e = default;
			_f = default;
			_g = default;
			_h = default;
			_i = default;
			_j = default;
			_k = default;
		} // 0x0000000183D708C0-0x0000000183D70910
		public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) {
			_a = default;
			_b = default;
			_c = default;
			_d = default;
			_e = default;
			_f = default;
			_g = default;
			_h = default;
			_i = default;
			_j = default;
			_k = default;
		} // 0x0000000183D708C0-0x0000000183D70910
		public Guid(string g) {
			_a = default;
			_b = default;
			_c = default;
			_d = default;
			_e = default;
			_f = default;
			_g = default;
			_h = default;
			_i = default;
			_j = default;
			_k = default;
		} // 0x0000000182EBA670-0x0000000182EBA740
	
		// Methods
		public static Guid NewGuid() => default; // 0x0000000182A6BAD0-0x0000000182A6BB20
		public static Guid Parse(string input) => default; // 0x000000018924AB24-0x000000018924ABBC
		public static Guid Parse(ReadOnlySpan<char> input) => default; // 0x000000018924AA9C-0x000000018924AB24
		public static bool TryParse(string input, out Guid result) {
			result = default;
			return default;
		} // 0x000000018924B464-0x000000018924B4A8
		public static bool TryParse(ReadOnlySpan<char> input, out Guid result) {
			result = default;
			return default;
		} // 0x000000018924B4A8-0x000000018924B508
		public static bool TryParseExact(string input, string format, out Guid result) {
			result = default;
			return default;
		} // 0x000000018924AC6C-0x000000018924ACE4
		public static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, out Guid result) {
			result = default;
			return default;
		} // 0x000000018924ACE4-0x000000018924AE00
		private static bool TryParseGuid(ReadOnlySpan<char> guidString, GuidStyles flags, ref GuidResult result) => default; // 0x0000000182EBA740-0x0000000182EBA8F0
		private static bool TryParseGuidWithHexPrefix(ReadOnlySpan<char> guidString, ref GuidResult result) => default; // 0x000000018924AE00-0x000000018924B464
		private static bool TryParseGuidWithNoStyle(ReadOnlySpan<char> guidString, ref GuidResult result) => default; // 0x0000000183554F70-0x00000001835552D0
		private static bool TryParseGuidWithDashes(ReadOnlySpan<char> guidString, ref GuidResult result) => default; // 0x0000000182EBAD40-0x0000000182EBB000
		private static bool StringToShort(ReadOnlySpan<char> str, int requiredLength, int flags, out short result, ref GuidResult parseResult) {
			result = default;
			return default;
		} // 0x00000001835553A0-0x0000000183555400
		private static bool StringToShort(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out short result, ref GuidResult parseResult) {
			result = default;
			return default;
		} // 0x0000000183555400-0x0000000183555460
		private static bool StringToInt(ReadOnlySpan<char> str, int requiredLength, int flags, out int result, ref GuidResult parseResult) {
			result = default;
			return default;
		} // 0x0000000183555350-0x00000001835553A0
		private static bool StringToInt(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out int result, ref GuidResult parseResult) {
			result = default;
			return default;
		} // 0x0000000182EBB000-0x0000000182EBB0B0
		private static bool StringToLong(ReadOnlySpan<char> str, ref int parsePos, int flags, out long result, ref GuidResult parseResult) {
			result = default;
			return default;
		} // 0x0000000182EBAB30-0x0000000182EBAB70
		private static ReadOnlySpan<char> EatAllWhitespace(ReadOnlySpan<char> str) => default; // 0x000000018924A6BC-0x000000018924A8B0
		private static bool IsHexPrefix(ReadOnlySpan<char> str, int i) => default; // 0x000000018924A9FC-0x000000018924AA9C
		private void WriteByteHelper(Span<byte> destination) {} // 0x000000018924A044-0x000000018924A2E4
		public byte[] ToByteArray() => default; // 0x000000018924ABF0-0x000000018924AC6C
		public override string ToString() => default; // 0x0000000182A6B5F0-0x0000000182A6B640
		public override int GetHashCode() => default; // 0x0000000183D708B0-0x0000000183D708C0
		public override bool Equals(object o) => default; // 0x000000018924A8B0-0x000000018924A934
		public bool Equals(Guid g) => default; // 0x00000001826CE790-0x00000001826CE7C0
		private int GetResult(uint me, uint them) => default; // 0x000000018924A934-0x000000018924A948
		public int CompareTo(object value) => default; // 0x000000018924A440-0x000000018924A604
		public int CompareTo(Guid value) => default; // 0x000000018924A604-0x000000018924A6BC
		public static bool operator ==(Guid a, Guid b) => default; // 0x00000001828EB2A0-0x00000001828EB2D0
		public static bool operator !=(Guid a, Guid b) => default; // 0x000000018924B508-0x000000018924B52C
		public string ToString(string format) => default; // 0x0000000184276B1C-0x0000000184276B28
		private static char HexToChar(int a) => default; // 0x000000018924A948-0x000000018924A960
		private static unsafe int HexsToChars(char* guidChars, int a, int b) => default; // 0x0000000182A6BA50-0x0000000182A6BAD0
		private static unsafe int HexsToCharsHexOutput(char* guidChars, int a, int b) => default; // 0x000000018924A960-0x000000018924A9FC
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000182A6B640-0x0000000182A6B7A0
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default) {
			charsWritten = default;
			return default;
		} // 0x0000000182A6B7A0-0x0000000182A6BA50
		bool ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) {
			charsWritten = default;
			return default;
		} // 0x000000018924ABBC-0x000000018924ABF0
	}

	public struct HashCode // TypeDefIndex: 38765
	{
		// Fields
		private static readonly uint s_seed; // 0x00
		private uint _v1; // 0x00
		private uint _v2; // 0x04
		private uint _v3; // 0x08
		private uint _v4; // 0x0C
		private uint _queue1; // 0x10
		private uint _queue2; // 0x14
		private uint _queue3; // 0x18
		private uint _length; // 0x1C
	
		// Constructors
		static HashCode() {
			s_seed = default;
		} // 0x0000000183D23430-0x0000000183D23470
	
		// Methods
		private static uint GenerateGlobalSeed() => default; // 0x000000018427706C-0x0000000184277094
		public static int Combine<T1>(T1 value1) => default;
		public static int Combine<T1, T2>(T1 value1, T2 value2) => default;
		public static int Combine<T1, T2, T3>(T1 value1, T2 value2, T3 value3) => default;
		public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4) => default;
		public static int Combine<T1, T2, T3, T4, T5>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) => default;
		public static int Combine<T1, T2, T3, T4, T5, T6>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) => default;
		public static int Combine<T1, T2, T3, T4, T5, T6, T7>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) => default;
		public static int Combine<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) => default;
		private static uint Rol(uint value, int count) => default; // 0x0000000183D50D20-0x0000000183D50D40
		private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4) {
			v1 = default;
			v2 = default;
			v3 = default;
			v4 = default;
		} // 0x000000018924B6C8-0x000000018924B780
		private static uint Round(uint hash, uint input) => default; // 0x000000018924B870-0x000000018924B8CC
		private static uint QueueRound(uint hash, uint queuedValue) => default; // 0x000000018924B814-0x000000018924B870
		private static uint MixState(uint v1, uint v2, uint v3, uint v4) => default; // 0x000000018924B780-0x000000018924B814
		private static uint MixEmptyState() => default; // 0x0000000182332140-0x00000001823321A0
		private static uint MixFinal(uint hash) => default; // 0x000000018303AD30-0x000000018303AD60
		public void Add<T>(T value) {}
		private void Add(int value) {} // 0x000000018924B52C-0x000000018924B610
		public int ToHashCode() => default; // 0x000000018924B8CC-0x000000018924B9E8
		[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes. Use ToHashCode to retrieve the computed hash code.", true)]
		public override int GetHashCode() => default; // 0x000000018924B66C-0x000000018924B6C8
		[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes.", true)]
		public override bool Equals(object obj) => default; // 0x000000018924B610-0x000000018924B66C
	}

	public interface IAsyncResult // TypeDefIndex: 38766
	{
		// Properties
		bool IsCompleted { get; }
		WaitHandle AsyncWaitHandle { get; }
		object AsyncState { get; }
		bool CompletedSynchronously { get; }
	}

	public interface ICloneable // TypeDefIndex: 38767
	{
		// Methods
		object Clone();
	}

	public interface IComparable // TypeDefIndex: 38768
	{
		// Methods
		int CompareTo(object obj);
	}

	public interface IComparable<in T> // TypeDefIndex: 38769
	{
		// Methods
		int CompareTo(T other);
	}

	[CLSCompliant(false)]
	public interface IConvertible // TypeDefIndex: 38770
	{
		// Methods
		TypeCode GetTypeCode();
		bool ToBoolean(IFormatProvider provider);
		char ToChar(IFormatProvider provider);
		sbyte ToSByte(IFormatProvider provider);
		byte ToByte(IFormatProvider provider);
		short ToInt16(IFormatProvider provider);
		ushort ToUInt16(IFormatProvider provider);
		int ToInt32(IFormatProvider provider);
		uint ToUInt32(IFormatProvider provider);
		long ToInt64(IFormatProvider provider);
		ulong ToUInt64(IFormatProvider provider);
		float ToSingle(IFormatProvider provider);
		double ToDouble(IFormatProvider provider);
		decimal ToDecimal(IFormatProvider provider);
		System.DateTime ToDateTime(IFormatProvider provider);
		string ToString(IFormatProvider provider);
		object ToType(System.Type conversionType, IFormatProvider provider);
	}

	public interface ICustomFormatter // TypeDefIndex: 38771
	{
		// Methods
		string Format(string format, object arg, IFormatProvider formatProvider);
	}

	public interface IDisposable // TypeDefIndex: 38772
	{
		// Methods
		void Dispose();
	}

	public interface IEquatable<T> // TypeDefIndex: 38773
	{
		// Methods
		bool Equals(T other);
	}

	public interface IFormatProvider // TypeDefIndex: 38774
	{
		// Methods
		object GetFormat(System.Type formatType);
	}

	public interface IFormattable // TypeDefIndex: 38775
	{
		// Methods
		string ToString(string format, IFormatProvider formatProvider);
	}

	public interface IObservable<out T> // TypeDefIndex: 38776
	{
		// Methods
		IDisposable Subscribe(IObserver<T> observer);
	}

	public interface IObserver<in T> // TypeDefIndex: 38777
	{
		// Methods
		void OnNext(T value);
		void OnError(Exception error);
		void OnCompleted();
	}

	public interface IProgress<in T> // TypeDefIndex: 38778
	{
		// Methods
		void Report(T value);
	}

	internal interface ISpanFormattable // TypeDefIndex: 38779
	{
		// Methods
		bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider);
	}

	[Serializable]
	public sealed class IndexOutOfRangeException : SystemException // TypeDefIndex: 38780
	{
		// Constructors
		public IndexOutOfRangeException() {} // 0x0000000183D2C1C0-0x0000000183D2C210
		public IndexOutOfRangeException(string message) {} // 0x000000018924BA08-0x000000018924BA28
		public IndexOutOfRangeException(string message, Exception innerException) {} // 0x000000018924B9E8-0x000000018924BA08
		internal IndexOutOfRangeException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	public sealed class InsufficientExecutionStackException : SystemException // TypeDefIndex: 38781
	{
		// Constructors
		public InsufficientExecutionStackException() {} // 0x000000018924BA28-0x000000018924BA6C
		internal InsufficientExecutionStackException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	[IsReadOnly]
	public struct Int16 : IComparable, IConvertible, IFormattable, IComparable<short>, IEquatable<short>, ISpanFormattable // TypeDefIndex: 38782
	{
		// Fields
		private readonly short m_value; // 0x00
		public const short MaxValue = 32767; // Metadata: 0x01F9E21F
		public const short MinValue = -32768; // Metadata: 0x01F9E221
	
		// Methods
		public int CompareTo(object value) => default; // 0x000000018924BA6C-0x000000018924BB24
		public int CompareTo(short value) => default; // 0x0000000183D70910-0x0000000183D70920
		public override bool Equals(object obj) => default; // 0x000000018924BB24-0x000000018924BB84
		[NonVersionable]
		public bool Equals(short obj) => default; // 0x00000001831DF9C0-0x00000001831DF9D0
		public override int GetHashCode() => default; // 0x0000000183D70920-0x0000000183D70930
		public override string ToString() => default; // 0x000000018924C48C-0x000000018924C504
		public string ToString(IFormatProvider provider) => default; // 0x000000018924C408-0x000000018924C48C
		public string ToString(string format, IFormatProvider provider) => default; // 0x000000018924C308-0x000000018924C408
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider provider = null) {
			charsWritten = default;
			return default;
		} // 0x000000018924C504-0x000000018924C620
		public static short Parse(string s, IFormatProvider provider) => default; // 0x000000018924BB84-0x000000018924BBEC
		public static short Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x000000018924BBEC-0x000000018924BC68
		private static short Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info) => default; // 0x000000018924BC68-0x000000018924BE50
		public static bool TryParse(string s, out short result) {
			result = default;
			return default;
		} // 0x000000018924C6DC-0x000000018924C744
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result) {
			result = default;
			return default;
		} // 0x000000018924C744-0x000000018924C7DC
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out short result) {
			result = default;
			return default;
		} // 0x000000018924C620-0x000000018924C6DC
		public TypeCode GetTypeCode() => default; // 0x0000000183D55AA0-0x0000000183D55AB0
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x000000018924BE50-0x000000018924BE9C
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x000000018924BEE8-0x000000018924BF34
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x000000018924C100-0x000000018924C14C
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x000000018924BE9C-0x000000018924BEE8
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000183D4F990-0x0000000183D4F9A0
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x000000018924C224-0x000000018924C270
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x000000018924C070-0x000000018924C0B8
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x000000018924C270-0x000000018924C2BC
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x000000018924C0B8-0x000000018924C100
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x000000018924C2BC-0x000000018924C308
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x000000018924C14C-0x000000018924C198
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x000000018924C024-0x000000018924C070
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x000000018924BFC4-0x000000018924C024
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x000000018924BF34-0x000000018924BFC4
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x000000018924C198-0x000000018924C224
	}

	[Serializable]
	[IsReadOnly]
	public struct Int32 : IComparable, IConvertible, IFormattable, IComparable<int>, IEquatable<int>, ISpanFormattable // TypeDefIndex: 38783
	{
		// Fields
		private readonly int m_value; // 0x00
		public const int MaxValue = 2147483647; // Metadata: 0x01F9E224
		public const int MinValue = 2147483647; // Metadata: 0x01F9E225
	
		// Methods
		public int CompareTo(object value) => default; // 0x000000018924C7DC-0x000000018924C898
		public int CompareTo(int value) => default; // 0x000000018231A860-0x000000018231A880
		public override bool Equals(object obj) => default; // 0x000000018345D7F0-0x000000018345D850
		[NonVersionable]
		public bool Equals(int obj) => default; // 0x00000001822A9C10-0x00000001822A9C20
		public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
		public override string ToString() => default; // 0x000000018291BD20-0x000000018291BDC0
		public string ToString(string format) => default; // 0x000000018924CE04-0x000000018924CE7C
		public string ToString(IFormatProvider provider) => default; // 0x00000001825FEF20-0x00000001825FEFC0
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000183610DD0-0x0000000183610E70
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider provider = null) {
			charsWritten = default;
			return default;
		} // 0x0000000182300DE0-0x0000000182300E90
		public static int Parse(string s) => default; // 0x00000001828FA500-0x00000001828FA680
		public static int Parse(string s, NumberStyles style) => default; // 0x000000018924C9AC-0x000000018924CA44
		public static int Parse(string s, IFormatProvider provider) => default; // 0x000000018924C918-0x000000018924C9AC
		public static int Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x00000001825FAC70-0x00000001825FAE80
		public static int Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.None | NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.Integer /* Metadata: 0x01F9E223 */, IFormatProvider provider = null) => default; // 0x000000018924C898-0x000000018924C918
		public static bool TryParse(string s, out int result) {
			result = default;
			return default;
		} // 0x00000001825FA7D0-0x00000001825FA950
		public static bool TryParse(ReadOnlySpan<char> s, out int result) {
			result = default;
			return default;
		} // 0x000000018924CF10-0x000000018924CF8C
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result) {
			result = default;
			return default;
		} // 0x0000000182A4E450-0x0000000182A4E520
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out int result) {
			result = default;
			return default;
		} // 0x000000018924CE7C-0x000000018924CF10
		public TypeCode GetTypeCode() => default; // 0x0000000183D55810-0x0000000183D55820
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x000000018924CA44-0x000000018924CA8C
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x000000018924CAD8-0x000000018924CB24
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x000000018924CC4C-0x000000018924CC98
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x000000018924CA8C-0x000000018924CAD8
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x000000018924CC00-0x000000018924CC4C
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x000000018924CD6C-0x000000018924CDB8
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000183D4E980-0x0000000183D4E990
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x000000018924CDB8-0x000000018924CE04
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x00000001832E1CF0-0x00000001832E1D40
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000183174480-0x00000001831744F0
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x000000018924CC98-0x000000018924CCE4
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x000000018924CBB4-0x000000018924CC00
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x00000001835857F0-0x0000000183585860
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x000000018924CB24-0x000000018924CBB4
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x000000018924CCE4-0x000000018924CD6C
	}

	[Serializable]
	[IsReadOnly]
	public struct Int64 : IComparable, IConvertible, IFormattable, IComparable<long>, IEquatable<long>, ISpanFormattable // TypeDefIndex: 38784
	{
		// Fields
		private readonly long m_value; // 0x00
		public const long MaxValue = 9223372036854775807; // Metadata: 0x01F9E226
		public const long MinValue = -9223372036854775808; // Metadata: 0x01F9E22E
	
		// Methods
		public int CompareTo(object value) => default; // 0x000000018924CF8C-0x000000018924D048
		public int CompareTo(long value) => default; // 0x000000018924D048-0x000000018924D05C
		public override bool Equals(object obj) => default; // 0x000000018924D05C-0x000000018924D0BC
		[NonVersionable]
		public bool Equals(long obj) => default; // 0x00000001822A9C20-0x00000001822A9C30
		public override int GetHashCode() => default; // 0x0000000183D70930-0x0000000183D70940
		public override string ToString() => default; // 0x000000018375BCF0-0x000000018375BD90
		public string ToString(IFormatProvider provider) => default; // 0x000000018924D568-0x000000018924D5EC
		public string ToString(string format) => default; // 0x000000018924D674-0x000000018924D6F0
		public string ToString(string format, IFormatProvider provider) => default; // 0x000000018924D5EC-0x000000018924D674
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider provider = null) {
			charsWritten = default;
			return default;
		} // 0x000000018924D6F0-0x000000018924D788
		public static long Parse(string s) => default; // 0x000000018924D164-0x000000018924D1EC
		public static long Parse(string s, IFormatProvider provider) => default; // 0x00000001826947D0-0x0000000182694950
		public static long Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x000000018924D0BC-0x000000018924D164
		public static bool TryParse(string s, out long result) {
			result = default;
			return default;
		} // 0x0000000182695470-0x00000001826955D0
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) {
			result = default;
			return default;
		} // 0x000000018924D788-0x000000018924D840
		public TypeCode GetTypeCode() => default; // 0x0000000183D557B0-0x0000000183D557C0
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x000000018924D1EC-0x000000018924D238
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x000000018924D284-0x000000018924D2D0
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x000000018924D444-0x000000018924D490
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x000000018924D238-0x000000018924D284
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x000000018924D3AC-0x000000018924D3F8
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x00000001838A7660-0x00000001838A76B0
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x000000018924D3F8-0x000000018924D444
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x00000001830D8B50-0x00000001830D8BD0
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x00000001820C61B0-0x00000001820C61C0
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000182F5D540-0x0000000182F5D5C0
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x000000018924D490-0x000000018924D4DC
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x000000018924D360-0x000000018924D3AC
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x00000001836E5C00-0x00000001836E5C70
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x000000018924D2D0-0x000000018924D360
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x000000018924D4DC-0x000000018924D568
	}

	[Serializable]
	public class InvalidCastException : SystemException // TypeDefIndex: 38785
	{
		// Constructors
		public InvalidCastException() {} // 0x000000018924D860-0x000000018924D8A4
		public InvalidCastException(string message) {} // 0x000000018924D8A4-0x000000018924D8C4
		public InvalidCastException(string message, Exception innerException) {} // 0x000000018924D840-0x000000018924D860
		protected InvalidCastException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	public class InvalidOperationException : SystemException // TypeDefIndex: 38786
	{
		// Constructors
		public InvalidOperationException() {} // 0x000000018924D8C4-0x000000018924D908
		public InvalidOperationException(string message) {} // 0x0000000182944300-0x0000000182944320
		public InvalidOperationException(string message, Exception innerException) {} // 0x000000018924D908-0x000000018924D928
		protected InvalidOperationException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	public sealed class InvalidProgramException : SystemException // TypeDefIndex: 38787
	{
		// Constructors
		public InvalidProgramException() {} // 0x000000018924D928-0x000000018924D96C
		public InvalidProgramException(string message) {} // 0x000000018924D96C-0x000000018924D98C
		internal InvalidProgramException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	public class InvalidTimeZoneException : Exception // TypeDefIndex: 38788
	{
		// Constructors
		public InvalidTimeZoneException() {} // 0x000000018924D9E8-0x000000018924DA34
		public InvalidTimeZoneException(string message) {} // 0x000000018924D98C-0x000000018924D9E8
		protected InvalidTimeZoneException(SerializationInfo info, StreamingContext context) {} // 0x000000018924DA34-0x000000018924DAA0
	}

	internal enum LazyState // TypeDefIndex: 38789
	{
		NoneViaConstructor = 0,
		NoneViaFactory = 1,
		NoneException = 2,
		PublicationOnlyViaConstructor = 3,
		PublicationOnlyViaFactory = 4,
		PublicationOnlyWait = 5,
		PublicationOnlyException = 6,
		ExecutionAndPublicationViaConstructor = 7,
		ExecutionAndPublicationViaFactory = 8,
		ExecutionAndPublicationException = 9
	}

	internal class LazyHelper // TypeDefIndex: 38790
	{
		// Fields
		internal static readonly LazyHelper NoneViaConstructor; // 0x00
		internal static readonly LazyHelper NoneViaFactory; // 0x08
		internal static readonly LazyHelper PublicationOnlyViaConstructor; // 0x10
		internal static readonly LazyHelper PublicationOnlyViaFactory; // 0x18
		internal static readonly LazyHelper PublicationOnlyWaitForOtherThreadToPublish; // 0x20
		private readonly ExceptionDispatchInfo _exceptionDispatch; // 0x18
	
		// Properties
		internal LazyState State { get; } // 0x0000000183D4E340-0x0000000183D4E350 
	
		// Constructors
		public LazyHelper() {} // Dummy constructor
		internal LazyHelper(LazyState state) {} // 0x00000001810410F0-0x0000000181041100
		internal LazyHelper(LazyThreadSafetyMode mode, Exception exception) {} // 0x000000018924DB90-0x000000018924DBDC
		static LazyHelper() {} // 0x0000000183B0D680-0x0000000183B0D800
	
		// Methods
		internal void ThrowException() {} // 0x000000018924DB74-0x000000018924DB90
		internal static LazyHelper Create(LazyThreadSafetyMode mode, bool useDefaultConstructor) => default; // 0x0000000183763B90-0x0000000183763C00
		internal static object CreateViaDefaultConstructor(System.Type type) => default; // 0x000000018924DAA0-0x000000018924DB6C
		internal static LazyThreadSafetyMode GetModeFromIsThreadSafe(bool isThreadSafe) => default; // 0x000000018924DB6C-0x000000018924DB74
	}

	[Serializable]
	[DebuggerDisplay("ThreadSafetyMode={Mode}, IsValueCreated={IsValueCreated}, IsValueFaulted={IsValueFaulted}, Value={ValueForDebugDisplay}")]
	[DebuggerTypeProxy(typeof(LazyDebugView<T>))]
	public class Lazy<T> // TypeDefIndex: 38791
	{
		// Fields
		private LazyHelper _state;
		private Func<T> _factory;
		private T _value;
	
		// Properties
		public bool IsValueCreated { get => default; }
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public T Value { get => default; }
	
		// Constructors
		public Lazy() {}
		public Lazy(T value) {}
		public Lazy(Func<T> valueFactory) {}
		public Lazy(Func<T> valueFactory, bool isThreadSafe) {}
		public Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode) {}
		private Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode, bool useDefaultConstructor) {}
	
		// Methods
		private static T CreateViaDefaultConstructor() => default;
		private void ViaConstructor() {}
		private void ViaFactory(LazyThreadSafetyMode mode) {}
		private void ExecutionAndPublication(LazyHelper executionAndPublication, bool useDefaultConstructor) {}
		private void PublicationOnly(LazyHelper publicationOnly, T possibleValue) {}
		private void PublicationOnlyViaConstructor(LazyHelper initializer) {}
		private void PublicationOnlyViaFactory(LazyHelper initializer) {}
		private void PublicationOnlyWaitForOtherThreadToPublish() {}
		private T CreateValue() => default;
		public override string ToString() => default;
	}

	internal sealed class LazyDebugView<T> // TypeDefIndex: 38792
	{
		// Constructors
		public LazyDebugView() {} // Dummy constructor
	}

	internal static class Marvin // TypeDefIndex: 38793
	{
		// Properties
		public static ulong DefaultSeed { get; } // 0x000000018924DD04-0x000000018924DD54 
	
		// Constructors
		static Marvin() {} // 0x0000000183D442A0-0x0000000183D442E0
	
		// Methods
		public static int ComputeHash32(ReadOnlySpan<byte> data, ulong seed) => default; // 0x000000018924DC70-0x000000018924DD04
		public static int ComputeHash32(ref byte data, int count, ulong seed) => default; // 0x00000001822FF6D0-0x00000001822FFC90
		private static void Block(ref uint rp0, ref uint rp1) {} // 0x000000018924DBDC-0x000000018924DC70
		private static uint _rotl(uint value, int shift) => default; // 0x0000000183D50D20-0x0000000183D50D40
		private static ulong GenerateSeed() => default; // 0x0000000183D70940-0x0000000183D70950
	}

	public static class Math // TypeDefIndex: 38794
	{
		// Fields
		private static double doubleRoundLimit; // 0x00
		private static double[] roundPower10Double; // 0x08
	
		// Constructors
		static Math() {} // 0x0000000183CB6B10-0x0000000183CB6BC0
	
		// Methods
		public static int Abs(int value) => default; // 0x000000018924DF34-0x000000018924DF7C
		public static long Abs(long value) => default; // 0x000000018924DEE8-0x000000018924DF34
		public static decimal Abs(decimal value) => default; // 0x000000018924DF7C-0x000000018924DFE0
		[StackTraceHidden]
		private static void ThrowAbsOverflow() {} // 0x000000018924E590-0x000000018924E5EC
		public static int DivRem(int a, int b, out int result) {
			result = default;
			return default;
		} // 0x0000000182941FF0-0x0000000182942030
		public static double Clamp(double value, double min, double max) => default; // 0x000000018924E188-0x000000018924E224
		public static int Clamp(int value, int min, int max) => default; // 0x000000018924E224-0x000000018924E2A4
		public static float Clamp(float value, float min, float max) => default; // 0x000000018924E0EC-0x000000018924E188
		[CLSCompliant(false)]
		public static ushort Clamp(ushort value, ushort min, ushort max) => default; // 0x000000018924DFE0-0x000000018924E06C
		[CLSCompliant(false)]
		public static uint Clamp(uint value, uint min, uint max) => default; // 0x000000018924E06C-0x000000018924E0EC
		public static double Log(double a, double newBase) => default; // 0x0000000182377040-0x0000000182377110
		[NonVersionable]
		public static byte Max(byte val1, byte val2) => default; // 0x000000018924E2A4-0x000000018924E2B0
		public static decimal Max(decimal val1, decimal val2) => default; // 0x0000000183D8A2B0-0x0000000183D8A340
		public static double Max(double val1, double val2) => default; // 0x000000018924E2BC-0x000000018924E2D4
		[NonVersionable]
		public static short Max(short val1, short val2) => default; // 0x000000018924E2D4-0x000000018924E2E0
		[NonVersionable]
		public static int Max(int val1, int val2) => default; // 0x000000018256A550-0x000000018256A560
		[NonVersionable]
		public static long Max(long val1, long val2) => default; // 0x0000000183559DF0-0x0000000183559E00
		[CLSCompliant(false)]
		[NonVersionable]
		public static sbyte Max(sbyte val1, sbyte val2) => default; // 0x000000018924E2E0-0x000000018924E2EC
		public static float Max(float val1, float val2) => default; // 0x0000000182344B30-0x0000000182345130
		[CLSCompliant(false)]
		[NonVersionable]
		public static ushort Max(ushort val1, ushort val2) => default; // 0x000000018924E2B0-0x000000018924E2BC
		[CLSCompliant(false)]
		[NonVersionable]
		public static uint Max(uint val1, uint val2) => default; // 0x00000001822BB400-0x00000001822BB410
		[CLSCompliant(false)]
		[NonVersionable]
		public static ulong Max(ulong val1, ulong val2) => default; // 0x000000018924E2EC-0x000000018924E2F8
		[NonVersionable]
		public static byte Min(byte val1, byte val2) => default; // 0x000000018924E384-0x000000018924E390
		public static decimal Min(decimal val1, decimal val2) => default; // 0x000000018924E310-0x000000018924E378
		public static double Min(double val1, double val2) => default; // 0x000000018924E390-0x000000018924E3A8
		[NonVersionable]
		public static short Min(short val1, short val2) => default; // 0x000000018924E378-0x000000018924E384
		[NonVersionable]
		public static int Min(int val1, int val2) => default; // 0x0000000182379510-0x0000000182379520
		[NonVersionable]
		public static long Min(long val1, long val2) => default; // 0x00000001822B9840-0x00000001822B9900
		[CLSCompliant(false)]
		[NonVersionable]
		public static sbyte Min(sbyte val1, sbyte val2) => default; // 0x000000018924E2F8-0x000000018924E304
		public static float Min(float val1, float val2) => default; // 0x00000001823E9260-0x00000001823E9280
		[CLSCompliant(false)]
		[NonVersionable]
		public static ushort Min(ushort val1, ushort val2) => default; // 0x000000018924E3A8-0x000000018924E3B4
		[CLSCompliant(false)]
		[NonVersionable]
		public static uint Min(uint val1, uint val2) => default; // 0x00000001822BB3F0-0x00000001822BB400
		[CLSCompliant(false)]
		[NonVersionable]
		public static ulong Min(ulong val1, ulong val2) => default; // 0x000000018924E304-0x000000018924E310
		public static decimal Round(decimal d) => default; // 0x000000018924E418-0x000000018924E484
		public static double Round(double a) => default; // 0x000000018924E410-0x000000018924E418
		public static double Round(double value, int digits) => default; // 0x000000018924E3BC-0x000000018924E410
		public static double Round(double value, int digits, MidpointRounding mode) => default; // 0x0000000182997FB0-0x0000000182998100
		public static int Sign(double value) => default; // 0x000000018924E484-0x000000018924E50C
		public static int Sign(int value) => default; // 0x0000000183D70A20-0x0000000183D70A30
		public static int Sign(long value) => default; // 0x0000000183D70A30-0x0000000183D70A50
		public static int Sign(float value) => default; // 0x000000018924E50C-0x000000018924E590
		public static decimal Truncate(decimal d) => default; // 0x000000018924E654-0x000000018924E6BC
		public static double Truncate(double d) => default; // 0x000000018924E5EC-0x000000018924E654
		private static void ThrowMinMaxException<T>(T min, T max) {}
		public static double Abs(double value) => default; // 0x0000000183D70960-0x0000000183D70970
		public static float Abs(float value) => default; // 0x0000000183D5C8B0-0x0000000183D5C8C0
		public static double Acos(double d) => default; // 0x0000000183D70970-0x0000000183D70980
		public static double Asin(double d) => default; // 0x0000000183D70980-0x0000000183D70990
		public static double Atan(double d) => default; // 0x0000000183D709A0-0x0000000183D709B0
		public static double Atan2(double y, double x) => default; // 0x0000000183D70990-0x0000000183D709A0
		public static double Ceiling(double a) => default; // 0x0000000183D709B0-0x0000000183D709C0
		public static double Cos(double d) => default; // 0x0000000183D709C0-0x0000000183D709D0
		public static double Cosh(double value) => default; // 0x0000000183D709D0-0x0000000183D709E0
		public static double Exp(double d) => default; // 0x0000000183D709E0-0x0000000183D709F0
		public static double Floor(double d) => default; // 0x0000000183D709F0-0x0000000183D70A00
		public static double Log(double d) => default; // 0x0000000183D70A10-0x0000000183D70A20
		public static double Log10(double d) => default; // 0x0000000183D70A00-0x0000000183D70A10
		public static double Pow(double x, double y) => default; // 0x0000000184270CC0-0x0000000184270CC8
		public static double Sin(double a) => default; // 0x0000000183D70A50-0x0000000183D70A60
		public static double Sinh(double value) => default; // 0x0000000183D70A60-0x0000000183D70A70
		public static double Sqrt(double d) => default; // 0x0000000183D70A70-0x0000000183D70A90
		public static double Tan(double a) => default; // 0x0000000183D70A90-0x0000000183D70AA0
		public static double Tanh(double value) => default; // 0x0000000183D70AA0-0x0000000183D70AB0
		private static unsafe double ModF(double x, double* intptr) => default; // 0x000000018924E3B4-0x000000018924E3BC
	}

	public static class MathF // TypeDefIndex: 38795
	{
		// Fields
		private static float[] roundPower10Single; // 0x00
		private static float singleRoundLimit; // 0x08
	
		// Constructors
		static MathF() {} // 0x0000000183CBD090-0x0000000183CBD130
	
		// Methods
		public static float Abs(float x) => default; // 0x000000018924DD54-0x000000018924DDA8
		public static float Max(float x, float y) => default; // 0x000000018924DDA8-0x000000018924DE0C
		public static float Min(float x, float y) => default; // 0x000000018924DE0C-0x000000018924DE70
		public static float Truncate(float x) => default; // 0x000000018924DE80-0x000000018924DEE8
		public static float Floor(float x) => default; // 0x0000000183D70950-0x0000000183D70960
		public static float Pow(float x, float y) => default; // 0x000000018924DE78-0x000000018924DE80
		private static unsafe float ModF(float x, float* intptr) => default; // 0x000000018924DE70-0x000000018924DE78
	}

	[Serializable]
	public class MemberAccessException : SystemException // TypeDefIndex: 38796
	{
		// Constructors
		public MemberAccessException() {} // 0x000000018924E6BC-0x000000018924E700
		public MemberAccessException(string message) {} // 0x000000018924E700-0x000000018924E720
		protected MemberAccessException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[DebuggerDisplay("{ToString(),raw}")]
	[DebuggerTypeProxy(typeof(MemoryDebugView<T>))]
	[IsReadOnly]
	public struct Memory<T> : IEquatable<Memory<T>> // TypeDefIndex: 38797
	{
		// Fields
		private readonly object _object;
		private readonly int _index;
		private readonly int _length;
	
		// Properties
		public static Memory<T> Empty { get => default; }
		public int Length { get => default; }
		public Span<T> Span { get => default; }
	
		// Constructors
		public Memory(T[] array) : this() {
			_object = default;
			_index = default;
			_length = default;
		}
		internal Memory(T[] array, int start) : this() {
			_object = default;
			_index = default;
			_length = default;
		}
		public Memory(T[] array, int start, int length) : this() {
			_object = default;
			_index = default;
			_length = default;
		}
		internal Memory(MemoryManager<T> manager, int length) : this() {
			_object = default;
			_index = default;
			_length = default;
		}
		internal Memory(object obj, int start, int length) : this() {
			_object = default;
			_index = default;
			_length = default;
		}
	
		// Methods
		public static implicit operator Memory<T>(T[] array) => default;
		public static implicit operator Memory<T>(ArraySegment<T> segment) => default;
		public static implicit operator ReadOnlyMemory<T>(Memory<T> memory) => default;
		public override string ToString() => default;
		public Memory<T> Slice(int start) => default;
		public Memory<T> Slice(int start, int length) => default;
		public MemoryHandle Pin() => default;
		public T[] ToArray() => default;
		public override bool Equals(object obj) => default;
		public bool Equals(Memory<T> other) => default;
		public override int GetHashCode() => default;
		private static int CombineHashCodes(int left, int right) => default;
		private static int CombineHashCodes(int h1, int h2, int h3) => default;
	}

	internal sealed class MemoryDebugView<T> // TypeDefIndex: 38798
	{
		// Constructors
		public MemoryDebugView() {} // Dummy constructor
	}

	public static class MemoryExtensions // TypeDefIndex: 38799
	{
		// Methods
		private static bool IsTypeComparableAsBytes<T>(out ulong size) {
			size = default;
			return default;
		}
	
		// Extension methods
		public static bool Equals(this ReadOnlySpan<char> span, ReadOnlySpan<char> other, StringComparison comparisonType) => default; // 0x0000000183632520-0x0000000183632650
		internal static bool EqualsOrdinal(this ReadOnlySpan<char> span, ReadOnlySpan<char> value) => default; // 0x000000018924EC90-0x000000018924ED0C
		internal static bool EqualsOrdinalIgnoreCase(this ReadOnlySpan<char> span, ReadOnlySpan<char> value) => default; // 0x000000018924EC00-0x000000018924EC90
		internal static bool Contains(this ReadOnlySpan<char> source, char value) => default; // 0x00000001829414B0-0x0000000182941530
		public static int ToUpperInvariant(this ReadOnlySpan<char> source, Span<char> destination) => default; // 0x00000001822FEF80-0x00000001822FF2A0
		public static bool EndsWith(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType) => default; // 0x000000018924E9C8-0x000000018924EC00
		public static bool StartsWith(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType) => default; // 0x000000018924ED0C-0x000000018924EF44
		public static Span<T> AsSpan<T>(this T[] array, int start) => default;
		public static ReadOnlySpan<char> AsSpan(this string text) => default; // 0x000000018924E838-0x000000018924E89C
		public static ReadOnlySpan<char> AsSpan(this string text, int start) => default; // 0x000000018924E93C-0x000000018924E9C8
		public static ReadOnlySpan<char> AsSpan(this string text, int start, int length) => default; // 0x000000018924E89C-0x000000018924E93C
		public static ReadOnlyMemory<char> AsMemory(this string text) => default; // 0x000000018924E7C8-0x000000018924E838
		public static ReadOnlyMemory<char> AsMemory(this string text, int start, int length) => default; // 0x000000018924E720-0x000000018924E7C8
		public static ReadOnlySpan<char> Trim(this ReadOnlySpan<char> span) => default; // 0x0000000182EBA8F0-0x0000000182EBA940
		public static ReadOnlySpan<char> TrimStart(this ReadOnlySpan<char> span) => default; // 0x0000000182EBA940-0x0000000182EBAA30
		public static ReadOnlySpan<char> TrimEnd(this ReadOnlySpan<char> span) => default; // 0x0000000182EBAA30-0x0000000182EBAB30
		public static int IndexOf<T>(this ReadOnlySpan<T> span, T value)
			where T : IEquatable<T> => default;
		public static int IndexOf<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> value)
			where T : IEquatable<T> => default;
		public static int IndexOfAny<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> values)
			where T : IEquatable<T> => default;
		public static bool SequenceEqual<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> other)
			where T : IEquatable<T> => default;
		public static bool StartsWith<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> value)
			where T : IEquatable<T> => default;
		public static bool EndsWith<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> value)
			where T : IEquatable<T> => default;
		public static void Reverse<T>(this Span<T> span) {}
		public static Span<T> AsSpan<T>(this T[] array) => default;
		public static Span<T> AsSpan<T>(this T[] array, int start, int length) => default;
		public static Span<T> AsSpan<T>(this ArraySegment<T> segment, int start) => default;
		public static Memory<T> AsMemory<T>(this T[] array) => default;
		public static Memory<T> AsMemory<T>(this T[] array, int start) => default;
		public static Memory<T> AsMemory<T>(this T[] array, int start, int length) => default;
		public static void CopyTo<T>(this T[] source, Span<T> destination) {}
	}

	[Serializable]
	public class MethodAccessException : MemberAccessException // TypeDefIndex: 38800
	{
		// Constructors
		public MethodAccessException() {} // 0x000000018924EF44-0x000000018924EF88
		public MethodAccessException(string message) {} // 0x000000018924EF88-0x000000018924EFA8
		protected MethodAccessException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
	}

	public enum MidpointRounding // TypeDefIndex: 38801
	{
		ToEven = 0,
		AwayFromZero = 1
	}

	[Serializable]
	public class MissingMethodException : MissingMemberException // TypeDefIndex: 38802
	{
		// Properties
		public override string Message { get => default; } // 0x000000018924F080-0x000000018924F178 
	
		// Constructors
		public MissingMethodException() {} // 0x000000018924F01C-0x000000018924F060
		public MissingMethodException(string message) {} // 0x000000018924F060-0x000000018924F080
		public MissingMethodException(string className, string methodName) {} // 0x000000018924EFA8-0x000000018924EFFC
		protected MissingMethodException(SerializationInfo info, StreamingContext context) {} // 0x000000018924EFFC-0x000000018924F01C
	}

	[Serializable]
	public sealed class MulticastNotSupportedException : SystemException // TypeDefIndex: 38803
	{
		// Constructors
		public MulticastNotSupportedException() {} // 0x000000018924F178-0x000000018924F1BC
		public MulticastNotSupportedException(string message) {} // 0x000000018924F1BC-0x000000018924F1DC
		internal MulticastNotSupportedException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public sealed class NonSerializedAttribute : Attribute // TypeDefIndex: 38804
	{
		// Constructors
		public NonSerializedAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class NotImplementedException : SystemException // TypeDefIndex: 38805
	{
		// Constructors
		public NotImplementedException() {} // 0x000000018924F1FC-0x000000018924F240
		public NotImplementedException(string message) {} // 0x000000018924F1DC-0x000000018924F1FC
		protected NotImplementedException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	public class NotSupportedException : SystemException // TypeDefIndex: 38806
	{
		// Constructors
		public NotSupportedException() {} // 0x000000018924F240-0x000000018924F284
		public NotSupportedException(string message) {} // 0x000000018924F2A4-0x000000018924F2C4
		public NotSupportedException(string message, Exception innerException) {} // 0x000000018924F284-0x000000018924F2A4
		protected NotSupportedException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	public class NullReferenceException : SystemException // TypeDefIndex: 38807
	{
		// Constructors
		public NullReferenceException() {} // 0x000000018924F304-0x000000018924F348
		public NullReferenceException(string message) {} // 0x000000018924F2C4-0x000000018924F2E4
		public NullReferenceException(string message, Exception innerException) {} // 0x000000018924F2E4-0x000000018924F304
		protected NullReferenceException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	[NonVersionable]
	public struct Nullable<T> // TypeDefIndex: 38808
		where T : struct
	{
		// Fields
		private readonly bool hasValue;
		internal T value;
	
		// Properties
		public bool HasValue { [NonVersionable] get => default; }
		public T Value { get => default; }
	
		// Constructors
		[NonVersionable]
		public Nullable(T value) : this() {
			hasValue = default;
			this.value = default;
		}
	
		// Methods
		[NonVersionable]
		public T GetValueOrDefault() => default;
		[NonVersionable]
		public T GetValueOrDefault(T defaultValue) => default;
		public override bool Equals(object other) => default;
		public override int GetHashCode() => default;
		public override string ToString() => default;
		private static object Box(T? o) => default;
		private static T? Unbox(object o) => default;
		private static T? UnboxExact(object o) => default;
	}

	public static class Nullable // TypeDefIndex: 38809
	{
		// Methods
		public static System.Type GetUnderlyingType(System.Type nullableType) => default; // 0x00000001826147E0-0x0000000182614B80
	}

	internal static class Number // TypeDefIndex: 38812
	{
		// Fields
		private static readonly string[] s_posCurrencyFormats; // 0x00
		private static readonly string[] s_negCurrencyFormats; // 0x08
		private static readonly string[] s_posPercentFormats; // 0x10
		private static readonly string[] s_negPercentFormats; // 0x18
		private static readonly string[] s_negNumberFormats; // 0x20
		private static readonly int[] s_charToHexLookup; // 0x28
		private static readonly ulong[] s_rgval64Power10; // 0x30
		private static readonly sbyte[] s_rgexp64Power10; // 0x38
		private static readonly ulong[] s_rgval64Power10By16; // 0x40
		private static readonly short[] s_rgexp64Power10By16; // 0x48
	
		// Nested types
		[IsByRefLike]
		[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		internal struct NumberBuffer // TypeDefIndex: 38811
		{
			// Fields
			public int precision; // 0x00
			public int scale; // 0x04
			private int _sign; // 0x08
			private DigitsAndNullTerminator _digits; // 0x0C
			private unsafe char* _allDigits; // 0x72
	
			// Properties
			public bool sign { get => default; set {} } // 0x0000000182379570-0x0000000182379580 0x000000018237ACC0-0x000000018237ACD0
			public unsafe char* digits { get => default; } // 0x0000000183D70B10-0x0000000183D70B20 
	
			// Nested types
			private struct DigitsAndNullTerminator // TypeDefIndex: 38810
			{
			}
		}
	
		// Constructors
		static Number() {} // 0x0000000182562730-0x0000000182562FD0
	
		// Methods
		public static string FormatDecimal(decimal value, ReadOnlySpan<char> format, NumberFormatInfo info) => default; // 0x000000018924F66C-0x000000018924F7F4
		public static bool TryFormatDecimal(decimal value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x00000001892508D4-0x0000000189250A6C
		private static void DecimalToNumber(decimal value, ref NumberBuffer number) {} // 0x000000018924F348-0x000000018924F4D4
		public static string FormatDouble(double value, string format, NumberFormatInfo info) => default; // 0x00000001822FC910-0x00000001822FCA60
		public static bool TryFormatDouble(double value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x00000001822FB8A0-0x00000001822FBAA0
		private static string FormatDouble(ref ValueStringBuilder sb, double value, ReadOnlySpan<char> format, NumberFormatInfo info) => default; // 0x00000001822FD010-0x00000001822FD210
		public static string FormatSingle(float value, string format, NumberFormatInfo info) => default; // 0x0000000182E3A410-0x0000000182E3A560
		public static bool TryFormatSingle(float value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x00000001822FDE90-0x00000001822FE080
		private static string FormatSingle(ref ValueStringBuilder sb, float value, ReadOnlySpan<char> format, NumberFormatInfo info) => default; // 0x00000001822FE080-0x00000001822FE320
		private static bool TryCopyTo(string source, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x0000000189250844-0x00000001892508D4
		public static string FormatInt32(int value, ReadOnlySpan<char> format, IFormatProvider provider) => default; // 0x00000001823011D0-0x00000001823014B0
		public static bool TryFormatInt32(int value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x0000000182300980-0x0000000182300C40
		public static string FormatUInt32(uint value, ReadOnlySpan<char> format, IFormatProvider provider) => default; // 0x00000001826D4D50-0x00000001826D4EB0
		public static bool TryFormatUInt32(uint value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x0000000189250D48-0x0000000189250FB0
		public static string FormatInt64(long value, ReadOnlySpan<char> format, IFormatProvider provider) => default; // 0x000000018375BD90-0x000000018375BE60
		public static bool TryFormatInt64(long value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x0000000189250A6C-0x0000000189250D48
		public static string FormatUInt64(ulong value, ReadOnlySpan<char> format, IFormatProvider provider) => default; // 0x0000000182A43160-0x0000000182A43230
		public static bool TryFormatUInt64(ulong value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x0000000189250FB0-0x0000000189251220
		private static void Int32ToNumber(int value, ref NumberBuffer number) {} // 0x000000018924FA7C-0x000000018924FB3C
		private static string NegativeInt32ToDecStr(int value, int digits, string sNegative) => default; // 0x00000001835ADED0-0x00000001835AE000
		private static bool TryNegativeInt32ToDecStr(int value, int digits, string sNegative, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x000000018365EA20-0x000000018365EB90
		private static string Int32ToHexStr(int value, char hexBase, int digits) => default; // 0x00000001826D4EB0-0x00000001826D4FA0
		private static bool TryInt32ToHexStr(int value, char hexBase, int digits, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x0000000189251220-0x0000000189251320
		private static unsafe char* Int32ToHexChars(char* buffer, uint value, int hexBase, int digits) => default; // 0x00000001826D4FA0-0x00000001826D5020
		private static void UInt32ToNumber(uint value, ref NumberBuffer number) {} // 0x0000000189251C90-0x0000000189251D44
		internal static unsafe char* UInt32ToDecChars(char* bufferEnd, uint value, int digits) => default; // 0x0000000182A43420-0x0000000182A43520
		private static string UInt32ToDecStr(uint value, int digits) => default; // 0x00000001823010C0-0x00000001823011D0
		private static bool TryUInt32ToDecStr(uint value, int digits, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x0000000182300C40-0x0000000182300DE0
		private static void Int64ToNumber(long input, ref NumberBuffer number) {} // 0x000000018924FC60-0x000000018924FDC0
		private static string NegativeInt64ToDecStr(long input, int digits, string sNegative) => default; // 0x000000018924FDC0-0x000000018924FF48
		private static bool TryNegativeInt64ToDecStr(long input, int digits, string sNegative, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x000000018925147C-0x000000018925164C
		private static string Int64ToHexStr(long value, char hexBase, int digits) => default; // 0x000000018924FB3C-0x000000018924FC60
		private static bool TryInt64ToHexStr(long value, char hexBase, int digits, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x0000000189251320-0x000000018925147C
		private static void UInt64ToNumber(ulong value, ref NumberBuffer number) {} // 0x0000000189251D44-0x0000000189251E94
		private static string UInt64ToDecStr(ulong value, int digits) => default; // 0x0000000182A43230-0x0000000182A43420
		private static bool TryUInt64ToDecStr(ulong value, int digits, Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x0000000189251B04-0x0000000189251C90
		internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) {
			digits = default;
			return default;
		} // 0x00000001822FE320-0x00000001822FE3F0
		internal static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) {} // 0x00000001822FE4D0-0x00000001822FE840
		internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info) {} // 0x00000001834BB6D0-0x00000001834BBD20
		private static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) {} // 0x000000018924F4D4-0x000000018924F66C
		private static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) {} // 0x00000001822FDA10-0x00000001822FDC40
		private static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) {} // 0x000000018924F7F4-0x000000018924F968
		private static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) {} // 0x000000018924F968-0x000000018924FA7C
		private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) {} // 0x0000000183745870-0x0000000183745990
		private static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) {} // 0x00000001822FD880-0x00000001822FDA10
		private static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) {} // 0x00000001822FD630-0x00000001822FD880
		private static void RoundNumber(ref NumberBuffer number, int pos) {} // 0x00000001822FE840-0x00000001822FE970
		private static int FindSection(ReadOnlySpan<char> format, int section) => default; // 0x00000001834BBD20-0x00000001834BBD70
		private static uint Low32(ulong value) => default; // 0x0000000183D517B0-0x0000000183D517C0
		private static uint High32(ulong value) => default; // 0x0000000183D68B20-0x0000000183D68B30
		private static uint Int64DivMod1E9(ref ulong value) => default; // 0x0000000182A43520-0x0000000182A43570
		private static bool NumberToInt32(ref NumberBuffer number, ref int value) => default; // 0x00000001892501A4-0x000000018925020C
		private static bool NumberToInt64(ref NumberBuffer number, ref long value) => default; // 0x000000018925020C-0x0000000189250278
		private static bool NumberToUInt32(ref NumberBuffer number, ref uint value) => default; // 0x0000000189250278-0x00000001892502E4
		private static bool NumberToUInt64(ref NumberBuffer number, ref ulong value) => default; // 0x00000001892502E4-0x0000000189250348
		internal static int ParseInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) => default; // 0x00000001825FAE80-0x00000001825FAFB0
		internal static long ParseInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) => default; // 0x0000000182694950-0x0000000182694A20
		internal static uint ParseUInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) => default; // 0x0000000182E56F60-0x0000000182E57030
		internal static ulong ParseUInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) => default; // 0x00000001824E4910-0x00000001824E49E0
		private static unsafe bool ParseNumber(ref char* str, char* strEnd, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal) => default; // 0x000000018237A4C0-0x000000018237AC30
		internal static bool TryParseInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out int result) {
			result = default;
			return default;
		} // 0x00000001825FA950-0x00000001825FABE0
		private static bool TryParseInt32IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out int result, ref bool failureIsOverflow) {
			result = default;
			return default;
		} // 0x00000001825FAFB0-0x00000001825FB2D0
		private static bool TryParseInt64IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out long result, ref bool failureIsOverflow) {
			result = default;
			return default;
		} // 0x0000000182695690-0x0000000182695910
		internal static bool TryParseInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out long result) {
			result = default;
			return default;
		} // 0x00000001826955D0-0x0000000182695690
		internal static bool TryParseUInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result) {
			result = default;
			return default;
		} // 0x0000000189251718-0x0000000189251864
		private static bool TryParseUInt32IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow) {
			result = default;
			return default;
		} // 0x0000000182E57030-0x0000000182E572E0
		private static bool TryParseUInt32HexNumberStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow) {
			result = default;
			return default;
		} // 0x00000001835AE5C0-0x00000001835AE7F0
		internal static bool TryParseUInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result) {
			result = default;
			return default;
		} // 0x0000000182AED620-0x0000000182AED740
		private static bool TryParseUInt64IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow) {
			result = default;
			return default;
		} // 0x000000018237AE30-0x000000018237B100
		private static bool TryParseUInt64HexNumberStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow) {
			result = default;
			return default;
		} // 0x0000000189251864-0x0000000189251B04
		internal static decimal ParseDecimal(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) => default; // 0x0000000189250348-0x000000018925042C
		private static bool NumberBufferToDecimal(ref NumberBuffer number, ref decimal value) => default; // 0x000000018924FF48-0x00000001892501A4
		internal static double ParseDouble(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) => default; // 0x000000018925042C-0x0000000189250618
		internal static float ParseSingle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) => default; // 0x0000000182E3A9F0-0x0000000182E3AB40
		internal static bool TryParseDecimal(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out decimal result) {
			result = default;
			return default;
		} // 0x000000018925164C-0x0000000189251718
		internal static bool TryParseDouble(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out double result) {
			result = default;
			return default;
		} // 0x00000001823788E0-0x0000000182378BD0
		internal static bool TryParseSingle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out float result) {
			result = default;
			return default;
		} // 0x0000000182377900-0x0000000182377C10
		private static void StringToNumber(ReadOnlySpan<char> value, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal) {} // 0x0000000189250618-0x000000018925074C
		internal static bool TryStringToNumber(ReadOnlySpan<char> value, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal) => default; // 0x000000018237A3A0-0x000000018237A4C0
		private static bool TrailingZeros(ReadOnlySpan<char> value, int index) => default; // 0x00000001892507E0-0x0000000189250844
		private static unsafe char* MatchChars(char* p, char* pEnd, string value) => default; // 0x000000018237AC40-0x000000018237ACA0
		private static bool IsWhite(int ch) => default; // 0x000000018237ACA0-0x000000018237ACC0
		private static bool IsDigit(int ch) => default; // 0x000000018237AC30-0x000000018237AC40
		private static void ThrowOverflowOrFormatException(bool overflow, string overflowResourceKey) {} // 0x000000018925074C-0x00000001892507E0
		private static bool NumberBufferToDouble(ref NumberBuffer number, ref double value) => default; // 0x0000000182378BD0-0x0000000182378CC0
		private static unsafe uint DigitsToInt(char* p, int count) => default; // 0x0000000182379520-0x0000000182379560
		private static ulong Mul32x32To64(uint a, uint b) => default; // 0x0000000183D70AB0-0x0000000183D70AC0
		private static ulong Mul64Lossy(ulong a, ulong b, ref int pexp) => default; // 0x0000000182376D40-0x0000000182376DD0
		private static int abs(int value) => default; // 0x0000000182379560-0x0000000182379570
		private static double NumberToDouble(ref NumberBuffer number) => default; // 0x0000000182378CC0-0x0000000182379400
		private static void DoubleToNumber(double value, int precision, ref NumberBuffer number) {} // 0x00000001822FE3F0-0x00000001822FE4D0
	}

	[Serializable]
	public class ObjectDisposedException : InvalidOperationException // TypeDefIndex: 38813
	{
		// Fields
		private string _objectName; // 0x90
	
		// Properties
		public override string Message { get => default; } // 0x000000018925738C-0x000000018925741C 
		public string ObjectName { get => default; } // 0x000000018925741C-0x000000018925746C 
	
		// Constructors
		private ObjectDisposedException() {} // 0x00000001892572BC-0x00000001892572FC
		public ObjectDisposedException(string objectName) {} // 0x0000000189257340-0x000000018925738C
		public ObjectDisposedException(string objectName, string message) {} // 0x00000001892572FC-0x0000000189257340
		protected ObjectDisposedException(SerializationInfo info, StreamingContext context) {} // 0x000000018925722C-0x00000001892572BC
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000189257164-0x000000018925722C
	}

	[Serializable]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	public sealed class ObsoleteAttribute : Attribute // TypeDefIndex: 38814
	{
		// Fields
		private string _message; // 0x10
		private bool _error; // 0x18
	
		// Properties
		public string Message { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public ObsoleteAttribute() {} // 0x0000000183D23520-0x0000000183D23550
		public ObsoleteAttribute(string message) {} // 0x0000000183D236E0-0x0000000183D23700
		public ObsoleteAttribute(string message, bool error) {} // 0x00000001825E7390-0x00000001825E73C0
	}

	[Serializable]
	public class OperationCanceledException : SystemException // TypeDefIndex: 38815
	{
		// Fields
		[NonSerialized]
		private CancellationToken _cancellationToken; // 0x90
	
		// Properties
		public CancellationToken CancellationToken { get => default; private set {} } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x00000001851DFCB4-0x00000001851DFCC8
	
		// Constructors
		public OperationCanceledException() {} // 0x0000000182944320-0x0000000182944370
		public OperationCanceledException(string message) {} // 0x0000000189257784-0x00000001892577A4
		public OperationCanceledException(string message, Exception innerException) {} // 0x000000018925772C-0x000000018925774C
		public OperationCanceledException(string message, CancellationToken token) {} // 0x00000001892577A4-0x00000001892577E0
		public OperationCanceledException(string message, Exception innerException, CancellationToken token) {} // 0x000000018925774C-0x0000000189257784
		protected OperationCanceledException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	public class OverflowException : ArithmeticException // TypeDefIndex: 38816
	{
		// Constructors
		public OverflowException() {} // 0x0000000189257B8C-0x0000000189257BD0
		public OverflowException(string message) {} // 0x0000000189257B6C-0x0000000189257B8C
		public OverflowException(string message, Exception innerException) {} // 0x0000000189257BD0-0x0000000189257BF0
		protected OverflowException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
	}

	[AttributeUsage(AttributeTargets.Parameter, Inherited = true, AllowMultiple = false)]
	public sealed class ParamArrayAttribute : Attribute // TypeDefIndex: 38817
	{
		// Constructors
		public ParamArrayAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[IsReadOnly]
	internal struct ParamsArray // TypeDefIndex: 38818
	{
		// Fields
		private static readonly object[] s_oneArgArray; // 0x00
		private static readonly object[] s_twoArgArray; // 0x08
		private static readonly object[] s_threeArgArray; // 0x10
		private readonly object _arg0; // 0x00
		private readonly object _arg1; // 0x08
		private readonly object _arg2; // 0x10
		private readonly object[] _args; // 0x18
	
		// Properties
		public int Length { get => default; } // 0x00000001842709E0-0x00000001842709FC 
		public object this[int index] { get => default; } // 0x0000000182F82380-0x0000000182F82420 
	
		// Constructors
		public ParamsArray(object arg0) : this() {
			_arg0 = default;
			_arg1 = default;
			_arg2 = default;
			_args = default;
		} // 0x00000001825F2BD0-0x00000001825F2FF0
		public ParamsArray(object arg0, object arg1) : this() {
			_arg0 = default;
			_arg1 = default;
			_arg2 = default;
			_args = default;
		} // 0x00000001825EE4A0-0x00000001825EE550
		public ParamsArray(object arg0, object arg1, object arg2) : this() {
			_arg0 = default;
			_arg1 = default;
			_arg2 = default;
			_args = default;
		} // 0x00000001825EFDC0-0x00000001825EFE70
		public ParamsArray(object[] args) : this() {
			_arg0 = default;
			_arg1 = default;
			_arg2 = default;
			_args = default;
		} // 0x00000001825F3B60-0x00000001825F3C10
		static ParamsArray() {
			s_oneArgArray = default;
			s_twoArgArray = default;
			s_threeArgArray = default;
		} // 0x0000000183C95AC0-0x0000000183C95BA0
	
		// Methods
		private object GetAtSlow(int index) => default; // 0x0000000182F82420-0x0000000182F82470
	}

	internal static class ParseNumbers // TypeDefIndex: 38819
	{
		// Methods
		public static long StringToLong(ReadOnlySpan<char> s, int radix, int flags) => default; // 0x0000000189258468-0x0000000189258494
		public static long StringToLong(ReadOnlySpan<char> s, int radix, int flags, ref int currPos) => default; // 0x0000000182EBAB70-0x0000000182EBAD40
		public static int StringToInt(ReadOnlySpan<char> s, int radix, int flags) => default; // 0x000000018925843C-0x0000000189258468
		public static int StringToInt(ReadOnlySpan<char> s, int radix, int flags, ref int currPos) => default; // 0x0000000182EBB0B0-0x0000000182EBB290
		public static string IntToString(int n, int radix, int width, char paddingChar, int flags) => default; // 0x0000000189257C98-0x0000000189257FE8
		public static string LongToString(long n, int radix, int width, char paddingChar, int flags) => default; // 0x0000000189258030-0x000000018925843C
		private static void EatWhiteSpace(ReadOnlySpan<char> s, ref int i) {} // 0x0000000189257BF0-0x0000000189257C98
		private static long GrabLongs(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned) => default; // 0x0000000182EBB290-0x0000000182EBB3A0
		private static int GrabInts(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned) => default; // 0x0000000182EBB3A0-0x0000000182EBB4F0
		private static void ThrowOverflowInt32Exception() {} // 0x0000000189258494-0x00000001892584F0
		private static void ThrowOverflowInt64Exception() {} // 0x00000001892584F0-0x000000018925854C
		private static void ThrowOverflowUInt32Exception() {} // 0x000000018925854C-0x00000001892585A8
		private static void ThrowOverflowUInt64Exception() {} // 0x00000001892585A8-0x0000000189258604
		private static bool IsDigit(char c, int radix, out int result) {
			result = default;
			return default;
		} // 0x0000000189257FE8-0x0000000189258030
	}

	[Serializable]
	public class PlatformNotSupportedException : NotSupportedException // TypeDefIndex: 38820
	{
		// Constructors
		public PlatformNotSupportedException() {} // 0x0000000189258624-0x0000000189258668
		public PlatformNotSupportedException(string message) {} // 0x0000000189258604-0x0000000189258624
		protected PlatformNotSupportedException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
	}

	public class Progress<T> : IProgress<T> // TypeDefIndex: 38821
	{
		// Fields
		private readonly SynchronizationContext _synchronizationContext;
		private readonly Action<T> _handler;
		private readonly SendOrPostCallback _invokeHandlers;
	
		// Constructors
		public Progress() {}
		public Progress(Action<T> handler) {}
	
		// Methods
		protected virtual void OnReport(T value) {}
		void IProgress<T>.Report(T value) {}
		private void InvokeHandlers(object state) {}
	}

	internal static class ProgressStatics // TypeDefIndex: 38822
	{
		// Fields
		internal static readonly SynchronizationContext DefaultContext; // 0x00
	
		// Constructors
		static ProgressStatics() {} // 0x0000000189258668-0x00000001892586D8
	}

	public class Random // TypeDefIndex: 38823
	{
		// Fields
		private int _inext; // 0x10
		private int _inextp; // 0x14
		private int[] _seedArray; // 0x18
		[ThreadStatic]
		private static Random t_threadRandom; // 0x80000000
		private static readonly Random s_globalRandom; // 0x00
	
		// Constructors
		public Random() {} // 0x0000000182936C60-0x0000000182936CC0
		public Random(int Seed) {} // 0x0000000182937130-0x0000000182937330
		static Random() {} // 0x0000000183CE34C0-0x0000000183CE3550
	
		// Methods
		protected virtual double Sample() => default; // 0x000000018297F310-0x000000018297F3C0
		private int InternalSample() => default; // 0x000000018297F3C0-0x000000018297F460
		private static int GenerateSeed() => default; // 0x0000000182936CC0-0x0000000182936FC0
		private static int GenerateGlobalSeed() => default; // 0x000000018427706C-0x0000000184277094
		public virtual int Next() => default; // 0x0000000184271FBC-0x0000000184271FC4
		private double GetSampleForLargeRange() => default; // 0x0000000182C98A10-0x0000000182C98A60
		public virtual int Next(int minValue, int maxValue) => default; // 0x000000018297EA20-0x000000018297EA90
		public virtual int Next(int maxValue) => default; // 0x000000018297E960-0x000000018297E990
		public virtual double NextDouble() => default; // 0x0000000184272180-0x0000000184272188
		public virtual void NextBytes(byte[] buffer) {} // 0x00000001892586D8-0x0000000189258780
	}

	[Serializable]
	public class RankException : SystemException // TypeDefIndex: 38824
	{
		// Constructors
		public RankException() {} // 0x0000000189258780-0x00000001892587C4
		public RankException(string message) {} // 0x00000001892587C4-0x00000001892587E4
		protected RankException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[DebuggerDisplay("{ToString(),raw}")]
	[DebuggerTypeProxy(typeof(MemoryDebugView<T>))]
	[IsReadOnly]
	public struct ReadOnlyMemory<T> : IEquatable<ReadOnlyMemory<T>> // TypeDefIndex: 38825
	{
		// Fields
		private readonly object _object;
		private readonly int _index;
		private readonly int _length;
		internal const int RemoveFlagsBitMask = 2147483647; // Metadata: 0x01F9E242
	
		// Properties
		public static ReadOnlyMemory<T> Empty { get => default; }
		public int Length { get => default; }
		public ReadOnlySpan<T> Span { get => default; }
	
		// Constructors
		public ReadOnlyMemory(T[] array) : this() {
			_object = default;
			_index = default;
			_length = default;
		}
		public ReadOnlyMemory(T[] array, int start, int length) : this() {
			_object = default;
			_index = default;
			_length = default;
		}
		internal ReadOnlyMemory(object obj, int start, int length) : this() {
			_object = default;
			_index = default;
			_length = default;
		}
	
		// Methods
		public static implicit operator ReadOnlyMemory<T>(T[] array) => default;
		public static implicit operator ReadOnlyMemory<T>(ArraySegment<T> segment) => default;
		public override string ToString() => default;
		public ReadOnlyMemory<T> Slice(int start) => default;
		public ReadOnlyMemory<T> Slice(int start, int length) => default;
		public void CopyTo(Memory<T> destination) {}
		public T[] ToArray() => default;
		public override bool Equals(object obj) => default;
		public bool Equals(ReadOnlyMemory<T> other) => default;
		public override int GetHashCode() => default;
		private static int CombineHashCodes(int left, int right) => default;
		private static int CombineHashCodes(int h1, int h2, int h3) => default;
		internal object GetObjectStartLength(out int start, out int length) {
			start = default;
			length = default;
			return default;
		}
	}

	[DebuggerDisplay("{ToString(),raw}")]
	[DebuggerTypeProxy(typeof(SpanDebugView<T>))]
	[IsByRefLike]
	[IsReadOnly]
	[NonVersionable]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct ReadOnlySpan<T> // TypeDefIndex: 38826
	{
		// Fields
		internal readonly ByReference<T> _pointer;
		private readonly int _length;
	
		// Properties
		[IsReadOnly]
		public ref T this[int index] { [NonVersionable] [Intrinsic] get => default; }
		public int Length { [NonVersionable] get => default; }
		public bool IsEmpty { [NonVersionable] get => default; }
		public static ReadOnlySpan<T> Empty { get => default; }
	
		// Constructors
		public ReadOnlySpan(T[] array) : this() {
			_pointer = default;
			_length = default;
		}
		public ReadOnlySpan(T[] array, int start, int length) : this() {
			_pointer = default;
			_length = default;
		}
		[CLSCompliant(false)]
		public unsafe ReadOnlySpan(void* pointer, int length) : this() {
			_pointer = default;
			_length = default;
		}
		internal ReadOnlySpan(ref ref T ptr, int length) : this() {
			_pointer = default;
			_length = default;
		}
	
		// Methods
		public ref ref T GetPinnableReference() => ref _refReturnTypeForGetPinnableReference;
		private ref T _refReturnTypeForGetPinnableReference; // Dummy field
		public void CopyTo(Span<T> destination) {}
		public bool TryCopyTo(Span<T> destination) => default;
		public static bool operator ==(ReadOnlySpan<T> left, ReadOnlySpan<T> right) => default;
		public override string ToString() => default;
		public ReadOnlySpan<T> Slice(int start) => default;
		public ReadOnlySpan<T> Slice(int start, int length) => default;
		public T[] ToArray() => default;
		[Obsolete("Equals() on ReadOnlySpan will always throw an exception. Use == instead.")]
		public override bool Equals(object obj) => default;
		[Obsolete("GetHashCode() on ReadOnlySpan will always throw an exception.")]
		public override int GetHashCode() => default;
		public static implicit operator ReadOnlySpan<T>(T[] array) => default;
	}

	public class ResolveEventArgs : EventArgs // TypeDefIndex: 38827
	{
		// Constructors
		public ResolveEventArgs() {} // Dummy constructor
		public ResolveEventArgs(string name) {} // 0x0000000189258850-0x00000001892588A8
		public ResolveEventArgs(string name, Assembly requestingAssembly) {} // 0x00000001892587E4-0x0000000189258850
	}

	public delegate Assembly ResolveEventHandler(object sender, ResolveEventArgs args); // TypeDefIndex: 38828; 0x0000000181165340-0x0000000181165350

	[Serializable]
	[CLSCompliant(false)]
	[IsReadOnly]
	public struct SByte : IComparable, IConvertible, IFormattable, IComparable<sbyte>, IEquatable<sbyte>, ISpanFormattable // TypeDefIndex: 38829
	{
		// Fields
		private readonly sbyte m_value; // 0x00
		public const sbyte MaxValue = 127; // Metadata: 0x01F9E243
		public const sbyte MinValue = 128; // Metadata: 0x01F9E244
	
		// Methods
		public int CompareTo(object obj) => default; // 0x00000001892588A8-0x0000000189258960
		public int CompareTo(sbyte value) => default; // 0x0000000183D70B40-0x0000000183D70B50
		public override bool Equals(object obj) => default; // 0x0000000189258960-0x00000001892589BC
		[NonVersionable]
		public bool Equals(sbyte obj) => default; // 0x000000018311BAE0-0x000000018311BAF0
		public override int GetHashCode() => default; // 0x0000000183D70B50-0x0000000183D70B60
		public override string ToString() => default; // 0x0000000189259264-0x00000001892592DC
		public string ToString(IFormatProvider provider) => default; // 0x00000001892591E0-0x0000000189259264
		public string ToString(string format, IFormatProvider provider) => default; // 0x00000001892590E8-0x00000001892591E0
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider provider = null) {
			charsWritten = default;
			return default;
		} // 0x00000001892592DC-0x00000001892593EC
		[CLSCompliant(false)]
		public static sbyte Parse(string s, IFormatProvider provider) => default; // 0x00000001892589BC-0x0000000189258A24
		[CLSCompliant(false)]
		public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x0000000189258C08-0x0000000189258C84
		private static sbyte Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info) => default; // 0x0000000189258A24-0x0000000189258C08
		[CLSCompliant(false)]
		public static bool TryParse(string s, out sbyte result) {
			result = default;
			return default;
		} // 0x00000001892593EC-0x000000018925944C
		[CLSCompliant(false)]
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result) {
			result = default;
			return default;
		} // 0x0000000189259508-0x0000000189259594
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out sbyte result) {
			result = default;
			return default;
		} // 0x000000018925944C-0x0000000189259508
		public TypeCode GetTypeCode() => default; // 0x0000000183D51100-0x0000000183D51110
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000189258C84-0x0000000189258CCC
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000189258D18-0x0000000189258D64
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000183D51020-0x0000000183D51030
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000189258CCC-0x0000000189258D18
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000189258EA0-0x0000000189258EE8
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000189259004-0x0000000189259050
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000183D70B60-0x0000000183D70B70
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000189259050-0x000000018925909C
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000189258EE8-0x0000000189258F30
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x000000018925909C-0x00000001892590E8
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000189258F30-0x0000000189258F7C
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000189258E54-0x0000000189258EA0
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000189258DF4-0x0000000189258E54
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000189258D64-0x0000000189258DF4
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x0000000189258F7C-0x0000000189259004
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate, Inherited = false)]
	public sealed class SerializableAttribute : Attribute // TypeDefIndex: 38830
	{
		// Constructors
		public SerializableAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[IsReadOnly]
	public struct Single : IComparable, IConvertible, IFormattable, IComparable<float>, IEquatable<float>, ISpanFormattable // TypeDefIndex: 38831
	{
		// Fields
		private readonly float m_value; // 0x00
		public const float MinValue = -3.4028235E+38f; // Metadata: 0x01F9E245
		public const float Epsilon = 1E-45f; // Metadata: 0x01F9E249
		public const float MaxValue = 3.4028235E+38f; // Metadata: 0x01F9E24D
		public const float PositiveInfinity = 1F / 0F; // Metadata: 0x01F9E251
		public const float NegativeInfinity = -1F / 0F; // Metadata: 0x01F9E255
		public const float NaN = 0F / 0F; // Metadata: 0x01F9E259
		internal const float NegativeZero = -0f; // Metadata: 0x01F9E25D
	
		// Methods
		[NonVersionable]
		public static bool IsFinite(float f) => default; // 0x0000000189259770-0x00000001892597C0
		[NonVersionable]
		public static bool IsInfinity(float f) => default; // 0x00000001892597C0-0x0000000189259810
		[NonVersionable]
		public static bool IsNaN(float f) => default; // 0x0000000189259810-0x0000000189259860
		[NonVersionable]
		public static bool IsNegativeInfinity(float f) => default; // 0x0000000189259860-0x0000000189259874
		[NonVersionable]
		public static bool IsPositiveInfinity(float f) => default; // 0x0000000189259874-0x0000000189259888
		public int CompareTo(object value) => default; // 0x000000018925968C-0x0000000189259770
		public int CompareTo(float value) => default; // 0x000000018231AF60-0x000000018231AF90
		public override bool Equals(object obj) => default; // 0x0000000183CF5890-0x0000000183CF5900
		public bool Equals(float obj) => default; // 0x000000018279A4D0-0x000000018279A4F0
		public override int GetHashCode() => default; // 0x0000000182E89AB0-0x0000000182E89B20
		public override string ToString() => default; // 0x0000000182E3A160-0x0000000182E3A1D0
		public string ToString(IFormatProvider provider) => default; // 0x0000000189259EB8-0x0000000189259F28
		public string ToString(string format) => default; // 0x0000000189259E4C-0x0000000189259EB8
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000182E3A380-0x0000000182E3A410
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider provider = null) {
			charsWritten = default;
			return default;
		} // 0x00000001822FDC40-0x00000001822FDE90
		public static float Parse(string s) => default; // 0x0000000182E39980-0x0000000182E39A10
		public static float Parse(string s, IFormatProvider provider) => default; // 0x0000000189259888-0x000000018925991C
		public static float Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x0000000182E3A940-0x0000000182E3A9F0
		public static bool TryParse(string s, out float result) {
			result = default;
			return default;
		} // 0x0000000182377580-0x0000000182377900
		public static bool TryParse(ReadOnlySpan<char> s, out float result) {
			result = default;
			return default;
		} // 0x0000000189259F28-0x0000000189259F70
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) {
			result = default;
			return default;
		} // 0x0000000189259F70-0x0000000189259FFC
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out float result) {
			result = default;
			return default;
		} // 0x0000000182377C10-0x0000000182377F60
		public TypeCode GetTypeCode() => default; // 0x0000000183D557F0-0x0000000183D55800
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x000000018925991C-0x0000000189259974
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x00000001892599CC-0x0000000189259A5C
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000189259C60-0x0000000189259CB8
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000189259974-0x00000001892599CC
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000189259B58-0x0000000189259BB0
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000189259D44-0x0000000189259D9C
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000189259BB0-0x0000000189259C08
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000189259D9C-0x0000000189259DF4
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000189259C08-0x0000000189259C60
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000189259DF4-0x0000000189259E4C
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000183D4FA00-0x0000000183D4FA10
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000183640A80-0x0000000183640AE0
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000189259AEC-0x0000000189259B58
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000189259A5C-0x0000000189259AEC
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x0000000189259CB8-0x0000000189259D44
	}

	[DebuggerDisplay("{ToString(),raw}")]
	[DebuggerTypeProxy(typeof(SpanDebugView<T>))]
	[IsByRefLike]
	[IsReadOnly]
	[NonVersionable]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct Span<T> // TypeDefIndex: 38832
	{
		// Fields
		internal readonly ByReference<T> _pointer;
		private readonly int _length;
	
		// Properties
		public ref T this[int index] { [Intrinsic] [NonVersionable] get => default; }
		public int Length { [NonVersionable] get => default; }
		public bool IsEmpty { [NonVersionable] get => default; }
	
		// Constructors
		public Span(T[] array) : this() {
			_pointer = default;
			_length = default;
		}
		public Span(T[] array, int start, int length) : this() {
			_pointer = default;
			_length = default;
		}
		[CLSCompliant(false)]
		public unsafe Span(void* pointer, int length) : this() {
			_pointer = default;
			_length = default;
		}
		internal Span(ref ref T ptr, int length) : this() {
			_pointer = default;
			_length = default;
		}
	
		// Methods
		public ref ref T GetPinnableReference() => ref _refReturnTypeForGetPinnableReference;
		private ref T _refReturnTypeForGetPinnableReference; // Dummy field
		public void Clear() {}
		public void Fill(T value) {}
		public void CopyTo(Span<T> destination) {}
		public bool TryCopyTo(Span<T> destination) => default;
		public static bool operator ==(Span<T> left, Span<T> right) => default;
		public static implicit operator ReadOnlySpan<T>(Span<T> span) => default;
		public override string ToString() => default;
		public Span<T> Slice(int start) => default;
		public Span<T> Slice(int start, int length) => default;
		public T[] ToArray() => default;
		[Obsolete("Equals() on Span will always throw an exception. Use == instead.")]
		public override bool Equals(object obj) => default;
		[Obsolete("GetHashCode() on Span will always throw an exception.")]
		public override int GetHashCode() => default;
		public static implicit operator Span<T>(T[] array) => default;
		public static implicit operator Span<T>(ArraySegment<T> segment) => default;
	}

	internal sealed class SpanDebugView<T> // TypeDefIndex: 38833
	{
		// Constructors
		public SpanDebugView() {} // Dummy constructor
	}

	internal static class SpanHelpers // TypeDefIndex: 38834
	{
		// Methods
		public static int IndexOf(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength) => default; // 0x000000018925A350-0x000000018925A410
		public static int IndexOfAny(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength) => default; // 0x000000018925A2D8-0x000000018925A350
		public static int IndexOf(ref byte searchSpace, byte value, int length) => default; // 0x000000018925A410-0x000000018925A4BC
		public static bool SequenceEqual(ref byte first, ref byte second, ulong length) => default; // 0x000000018232CD20-0x000000018232CE30
		public static int SequenceCompareTo(ref char first, int firstLength, ref char second, int secondLength) => default; // 0x0000000182476600-0x0000000182476790
		public static int IndexOf(ref char searchSpace, char value, int length) => default; // 0x0000000182815C20-0x0000000182815D20
		public static int LastIndexOf(ref char searchSpace, char value, int length) => default; // 0x00000001826D1B50-0x00000001826D1CA0
		private static int LocateFirstFoundChar(Vector<ushort> match) => default; // 0x000000018925A4BC-0x000000018925A5C4
		private static int LocateFirstFoundChar(ulong match) => default; // 0x0000000183D70B70-0x0000000183D70B90
		private static int LocateLastFoundChar(Vector<ushort> match) => default; // 0x000000018925A5C4-0x000000018925A6A4
		private static int LocateLastFoundChar(ulong match) => default; // 0x000000018925A6A4-0x000000018925A6BC
		public static int IndexOf<T>(ref ref T searchSpace, int searchSpaceLength, ref ref T value, int valueLength)
			where T : IEquatable<T> => default;
		public static int IndexOf<T>(ref ref T searchSpace, T value, int length)
			where T : IEquatable<T> => default;
		public static int IndexOfAny<T>(ref ref T searchSpace, int searchSpaceLength, ref ref T value, int valueLength)
			where T : IEquatable<T> => default;
		public static bool SequenceEqual<T>(ref ref T first, ref ref T second, int length)
			where T : IEquatable<T> => default;
		public static bool StartsWithCultureHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo) => default; // 0x000000018925A6BC-0x000000018925A794
		public static bool StartsWithCultureIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo) => default; // 0x000000018925A794-0x000000018925A864
		public static bool StartsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value) => default; // 0x000000018925A864-0x000000018925A918
		public static bool EndsWithCultureHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo) => default; // 0x000000018925A080-0x000000018925A158
		public static bool EndsWithCultureIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo) => default; // 0x000000018925A158-0x000000018925A228
		public static bool EndsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value) => default; // 0x000000018925A228-0x000000018925A2D8
		public static void ClearWithoutReferences(ref byte b, ulong byteLength) {} // 0x0000000183B45E80-0x0000000183B45EC0
		public static void ClearWithReferences(ref IntPtr ip, ulong pointerSizeLength) {} // 0x0000000189259FFC-0x000000018925A080
	}

	[Serializable]
	public sealed class StackOverflowException : SystemException // TypeDefIndex: 38835
	{
		// Constructors
		public StackOverflowException() {} // 0x000000018925A918-0x000000018925A95C
		public StackOverflowException(string message) {} // 0x000000018925A95C-0x000000018925A97C
		internal StackOverflowException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	public abstract class StringComparer : System.Collections.IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 38836
	{
		// Fields
		private static readonly CultureAwareComparer s_invariantCulture; // 0x00
		private static readonly CultureAwareComparer s_invariantCultureIgnoreCase; // 0x08
		private static readonly OrdinalCaseSensitiveComparer s_ordinal; // 0x10
		private static readonly OrdinalIgnoreCaseComparer s_ordinalIgnoreCase; // 0x18
	
		// Properties
		public static StringComparer InvariantCultureIgnoreCase { get; } // 0x000000018925ACA8-0x000000018925ACF8 
		public static StringComparer Ordinal { get; } // 0x000000018925AD48-0x000000018925AD98 
		public static StringComparer OrdinalIgnoreCase { get; } // 0x000000018925ACF8-0x000000018925AD48 
	
		// Constructors
		protected StringComparer() {} // 0x000000018350B670-0x000000018350B680
		static StringComparer() {} // 0x00000001838EF780-0x00000001838EF950
	
		// Methods
		public static StringComparer Create(CultureInfo culture, bool ignoreCase) => default; // 0x000000018925AA98-0x000000018925AB5C
		public int Compare(object x, object y) => default; // 0x000000018925A97C-0x000000018925AA98
		public new bool Equals(object x, object y) => default; // 0x000000018925AB5C-0x000000018925ABEC
		public int GetHashCode(object obj) => default; // 0x000000018925ABEC-0x000000018925ACA8
		public abstract int Compare(string x, string y);
		public abstract bool Equals(string x, string y);
		public abstract int GetHashCode(string obj);
	}

	[Serializable]
	public sealed class CultureAwareComparer : StringComparer, ISerializable // TypeDefIndex: 38837
	{
		// Fields
		private const CompareOptions ValidCompareMaskOffFlags = CompareOptions.None | CompareOptions.OrdinalIgnoreCase | CompareOptions.Ordinal; // Metadata: 0x01F9E261
		private readonly CompareInfo _compareInfo; // 0x10
		private CompareOptions _options; // 0x18
	
		// Constructors
		public CultureAwareComparer() {} // Dummy constructor
		internal CultureAwareComparer(CultureInfo culture, CompareOptions options) {} // 0x00000001838EF950-0x00000001838EF9A0
		internal CultureAwareComparer(CompareInfo compareInfo, CompareOptions options) {} // 0x00000001838EF9A0-0x00000001838EFA20
		private CultureAwareComparer(SerializationInfo info, StreamingContext context) {} // 0x000000018925689C-0x0000000189256A08
	
		// Methods
		public override int Compare(string x, string y) => default; // 0x0000000189256624-0x0000000189256670
		public override bool Equals(string x, string y) => default; // 0x0000000189256670-0x00000001892566B8
		public override int GetHashCode(string obj) => default; // 0x000000018925675C-0x00000001892567D8
		public override bool Equals(object obj) => default; // 0x00000001892566B8-0x0000000189256728
		public override int GetHashCode() => default; // 0x0000000189256728-0x000000018925675C
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001892567D8-0x000000018925689C
	}

	[Serializable]
	public class OrdinalComparer : StringComparer // TypeDefIndex: 38838
	{
		// Fields
		private readonly bool _ignoreCase; // 0x10
	
		// Constructors
		public OrdinalComparer() {} // Dummy constructor
		internal OrdinalComparer(bool ignoreCase) {} // 0x0000000183D06E30-0x0000000183D06E90
	
		// Methods
		public override int Compare(string x, string y) => default; // 0x0000000189257878-0x00000001892578BC
		public override bool Equals(string x, string y) => default; // 0x00000001892578BC-0x000000018925791C
		public override int GetHashCode(string obj) => default; // 0x0000000189257970-0x00000001892579E4
		public override bool Equals(object obj) => default; // 0x000000018925791C-0x0000000189257970
		public override int GetHashCode() => default; // 0x00000001892579E4-0x0000000189257A38
	}

	[Serializable]
	internal sealed class OrdinalCaseSensitiveComparer : OrdinalComparer, ISerializable // TypeDefIndex: 38839
	{
		// Constructors
		public OrdinalCaseSensitiveComparer() {} // 0x0000000184276C84-0x0000000184276C90
	
		// Methods
		public override int Compare(string x, string y) => default; // 0x00000001891C25EC-0x00000001891C2600
		public override bool Equals(string x, string y) => default; // 0x000000018232CBF0-0x000000018232CC30
		public override int GetHashCode(string obj) => default; // 0x0000000183D70B20-0x0000000183D70B40
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001892577E0-0x0000000189257878
	}

	[Serializable]
	internal sealed class OrdinalIgnoreCaseComparer : OrdinalComparer, ISerializable // TypeDefIndex: 38840
	{
		// Constructors
		public OrdinalIgnoreCaseComparer() {} // 0x0000000184276C78-0x0000000184276C84
	
		// Methods
		public override int Compare(string x, string y) => default; // 0x0000000189257A38-0x0000000189257A50
		public override bool Equals(string x, string y) => default; // 0x00000001831EB520-0x00000001831EB540
		public override int GetHashCode(string obj) => default; // 0x00000001822FEAF0-0x00000001822FEB50
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000189257A50-0x0000000189257AE8
	}

	public enum StringComparison // TypeDefIndex: 38841
	{
		CurrentCulture = 0,
		CurrentCultureIgnoreCase = 1,
		InvariantCulture = 2,
		InvariantCultureIgnoreCase = 3,
		Ordinal = 4,
		OrdinalIgnoreCase = 5
	}

	[Flags]
	public enum StringSplitOptions // TypeDefIndex: 38842
	{
		None = 0,
		RemoveEmptyEntries = 1
	}

	[Serializable]
	public class SystemException : Exception // TypeDefIndex: 38843
	{
		// Constructors
		public SystemException() {} // 0x000000018925AE6C-0x000000018925AEC8
		public SystemException(string message) {} // 0x00000001829443C0-0x0000000182944430
		public SystemException(string message, Exception innerException) {} // 0x000000018925AD98-0x000000018925AE00
		protected SystemException(SerializationInfo info, StreamingContext context) {} // 0x000000018925AE00-0x000000018925AE6C
	}

	[AttributeUsage(AttributeTargets.Method)]
	public sealed class STAThreadAttribute : Attribute // TypeDefIndex: 38844
	{
		// Constructors
		public STAThreadAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public class ThreadStaticAttribute : Attribute // TypeDefIndex: 38845
	{
		// Constructors
		public ThreadStaticAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[IsReadOnly]
	public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable, ISpanFormattable // TypeDefIndex: 38846
	{
		// Fields
		public const long TicksPerMillisecond = 10000; // Metadata: 0x01F9E26E
		private const double MillisecondsPerTick = 0.0001; // Metadata: 0x01F9E276
		public const long TicksPerSecond = 10000000; // Metadata: 0x01F9E27E
		private const double SecondsPerTick = 1E-07; // Metadata: 0x01F9E286
		public const long TicksPerMinute = 600000000; // Metadata: 0x01F9E28E
		private const double MinutesPerTick = 1.6666666666666667E-09; // Metadata: 0x01F9E296
		public const long TicksPerHour = 36000000000; // Metadata: 0x01F9E29E
		private const double HoursPerTick = 2.7777777777777777E-11; // Metadata: 0x01F9E2A6
		public const long TicksPerDay = 864000000000; // Metadata: 0x01F9E2AE
		private const double DaysPerTick = 1.1574074074074074E-12; // Metadata: 0x01F9E2B6
		private const int MillisPerSecond = 1000; // Metadata: 0x01F9E2BE
		private const int MillisPerMinute = 60000; // Metadata: 0x01F9E2C0
		private const int MillisPerHour = 3600000; // Metadata: 0x01F9E2C4
		private const int MillisPerDay = 86400000; // Metadata: 0x01F9E2C8
		internal const long MaxSeconds = 922337203685; // Metadata: 0x01F9E2CC
		internal const long MinSeconds = -922337203685; // Metadata: 0x01F9E2D4
		internal const long MaxMilliSeconds = 922337203685477; // Metadata: 0x01F9E2DC
		internal const long MinMilliSeconds = -922337203685477; // Metadata: 0x01F9E2E4
		internal const long TicksPerTenthSecond = 1000000; // Metadata: 0x01F9E2EC
		public static readonly TimeSpan Zero; // 0x00
		public static readonly TimeSpan MaxValue; // 0x08
		public static readonly TimeSpan MinValue; // 0x10
		internal readonly long _ticks; // 0x00
	
		// Properties
		public long Ticks { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
		public int Days { get => default; } // 0x000000018925CF14-0x000000018925CF28 
		public int Hours { get => default; } // 0x000000018925CF28-0x000000018925CF68 
		public int Minutes { get => default; } // 0x000000018925CF68-0x000000018925CFB0 
		public int Seconds { get => default; } // 0x000000018925CFB0-0x000000018925CFFC 
		public double TotalDays { get => default; } // 0x0000000183D70B90-0x0000000183D70BB0 
		public double TotalHours { get => default; } // 0x0000000183D70BB0-0x0000000183D70BD0 
		public double TotalMilliseconds { get => default; } // 0x00000001822E7150-0x00000001822E7190 
		public double TotalMinutes { get => default; } // 0x0000000183D70BD0-0x0000000183D70BF0 
		public double TotalSeconds { get => default; } // 0x0000000183D70BF0-0x0000000183D70C10 
	
		// Constructors
		public TimeSpan(long ticks) : this() {
			_ticks = default;
		} // 0x0000000183D51730-0x0000000183D51740
		public TimeSpan(int hours, int minutes, int seconds) : this() {
			_ticks = default;
		} // 0x0000000182C98510-0x0000000182C98590
		public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds) : this() {
			_ticks = default;
		} // 0x0000000183C86480-0x0000000183C864F0
		static TimeSpan() {
			Zero = default;
			MaxValue = default;
			MinValue = default;
		} // 0x0000000183D08580-0x0000000183D08600
	
		// Methods
		public TimeSpan Add(TimeSpan ts) => default; // 0x00000001831D8B10-0x00000001831D8B40
		public static int Compare(TimeSpan t1, TimeSpan t2) => default; // 0x000000018925CA54-0x000000018925CA6C
		public int CompareTo(object value) => default; // 0x000000018925C990-0x000000018925CA54
		public int CompareTo(TimeSpan value) => default; // 0x000000018925C978-0x000000018925C990
		public static TimeSpan FromDays(double value) => default; // 0x000000018925CACC-0x000000018925CB24
		public override bool Equals(object value) => default; // 0x000000018925CA6C-0x000000018925CACC
		public bool Equals(TimeSpan obj) => default; // 0x00000001822A9C20-0x00000001822A9C30
		public override int GetHashCode() => default; // 0x0000000183D70930-0x0000000183D70940
		public static TimeSpan FromHours(double value) => default; // 0x0000000182C98BE0-0x0000000182C98C40
		private static TimeSpan Interval(double value, int scale) => default; // 0x0000000182C98E90-0x0000000182C98F00
		public static TimeSpan FromMilliseconds(double value) => default; // 0x0000000182C98C40-0x0000000182C98CA0
		public static TimeSpan FromMinutes(double value) => default; // 0x000000018925CB24-0x000000018925CB7C
		public TimeSpan Negate() => default; // 0x000000018925CB7C-0x000000018925CC24
		public static TimeSpan FromSeconds(double value) => default; // 0x0000000182C98E30-0x0000000182C98E90
		public TimeSpan Subtract(TimeSpan ts) => default; // 0x000000018925CCB4-0x000000018925CD34
		public static TimeSpan FromTicks(long value) => default; // 0x000000018339AE90-0x000000018339AEA0
		internal static long TimeToTicks(int hour, int minute, int second) => default; // 0x00000001825F63F0-0x00000001825F6440
		public static TimeSpan Parse(string s) => default; // 0x000000018925CC74-0x000000018925CCB4
		public static TimeSpan Parse(string input, IFormatProvider formatProvider) => default; // 0x000000018925CC24-0x000000018925CC74
		public static bool TryParse(string s, out TimeSpan result) {
			result = default;
			return default;
		} // 0x000000018925CED0-0x000000018925CF14
		public static bool TryParse(string input, IFormatProvider formatProvider, out TimeSpan result) {
			result = default;
			return default;
		} // 0x000000018925CE80-0x000000018925CED0
		public override string ToString() => default; // 0x000000018925CD34-0x000000018925CD80
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018925CD80-0x000000018925CDE4
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider formatProvider = null) {
			charsWritten = default;
			return default;
		} // 0x000000018925CDE4-0x000000018925CE80
		public static TimeSpan operator -(TimeSpan t) => default; // 0x0000000182C98590-0x0000000182C98600
		public static TimeSpan operator -(TimeSpan t1, TimeSpan t2) => default; // 0x000000018925D004-0x000000018925D058
		public static TimeSpan operator +(TimeSpan t1, TimeSpan t2) => default; // 0x00000001831D8A90-0x00000001831D8B10
		public static bool operator ==(TimeSpan t1, TimeSpan t2) => default; // 0x00000001825FE520-0x00000001825FE530
		public static bool operator !=(TimeSpan t1, TimeSpan t2) => default; // 0x0000000182C992E0-0x0000000182C992F0
		public static bool operator <(TimeSpan t1, TimeSpan t2) => default; // 0x0000000182C992D0-0x0000000182C992E0
		public static bool operator <=(TimeSpan t1, TimeSpan t2) => default; // 0x000000018925CFFC-0x000000018925D004
		public static bool operator >(TimeSpan t1, TimeSpan t2) => default; // 0x00000001822E54D0-0x00000001822E54E0
		public static bool operator >=(TimeSpan t1, TimeSpan t2) => default; // 0x00000001822E54E0-0x00000001822E54F0
	}

	[Serializable]
	[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	public class TimeZoneNotFoundException : Exception // TypeDefIndex: 38847
	{
		// Constructors
		public TimeZoneNotFoundException() {} // 0x000000018925D0C4-0x000000018925D110
		protected TimeZoneNotFoundException(SerializationInfo info, StreamingContext context) {} // 0x000000018925D058-0x000000018925D0C4
	}

	[Serializable]
	public class TimeoutException : SystemException // TypeDefIndex: 38848
	{
		// Constructors
		public TimeoutException() {} // 0x000000018925D110-0x000000018925D154
		public TimeoutException(string message) {} // 0x000000018925D154-0x000000018925D174
		protected TimeoutException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	internal interface ITupleInternal : ITuple // TypeDefIndex: 38849
	{
		// Methods
		string ToString(StringBuilder sb);
		int GetHashCode(IEqualityComparer comparer);
	}

	public static class Tuple // TypeDefIndex: 38850
	{
		// Methods
		public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2) => default;
		public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3) => default;
		internal static int CombineHashCodes(int h1, int h2) => default; // 0x0000000183D67FA0-0x0000000183D67FB0
		internal static int CombineHashCodes(int h1, int h2, int h3) => default; // 0x0000000183D70CD0-0x0000000183D70CE0
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4) => default; // 0x0000000183D70C50-0x0000000183D70C70
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5) => default; // 0x0000000183D70C30-0x0000000183D70C50
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6) => default; // 0x0000000183D70C10-0x0000000183D70C30
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7) => default; // 0x0000000183D70CA0-0x0000000183D70CD0
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8) => default; // 0x0000000183D70C70-0x0000000183D70CA0
	}

	[Serializable]
	public class Tuple<T1> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal // TypeDefIndex: 38851
	{
		// Fields
		private readonly T1 m_Item1;
	
		// Properties
		int ITuple.Length { get => default; }
	
		// Constructors
		public Tuple() {} // Dummy constructor
		public Tuple(T1 item1) {}
	
		// Methods
		public override bool Equals(object obj) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object obj) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		int ITupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string ITupleInternal.ToString(StringBuilder sb) => default;
	}

	[Serializable]
	public class Tuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal // TypeDefIndex: 38852
	{
		// Fields
		private readonly T1 m_Item1;
		private readonly T2 m_Item2;
	
		// Properties
		public T1 Item1 { get => default; }
		public T2 Item2 { get => default; }
		int ITuple.Length { get => default; }
	
		// Constructors
		public Tuple() {} // Dummy constructor
		public Tuple(T1 item1, T2 item2) {}
	
		// Methods
		public override bool Equals(object obj) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object obj) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		int ITupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string ITupleInternal.ToString(StringBuilder sb) => default;
	}

	[Serializable]
	public class Tuple<T1, T2, T3> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal // TypeDefIndex: 38853
	{
		// Fields
		private readonly T1 m_Item1;
		private readonly T2 m_Item2;
		private readonly T3 m_Item3;
	
		// Properties
		public T1 Item1 { get => default; }
		public T2 Item2 { get => default; }
		public T3 Item3 { get => default; }
		int ITuple.Length { get => default; }
	
		// Constructors
		public Tuple() {} // Dummy constructor
		public Tuple(T1 item1, T2 item2, T3 item3) {}
	
		// Methods
		public override bool Equals(object obj) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object obj) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		int ITupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string ITupleInternal.ToString(StringBuilder sb) => default;
	}

	[Serializable]
	public class Tuple<T1, T2, T3, T4> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal // TypeDefIndex: 38854
	{
		// Fields
		private readonly T1 m_Item1;
		private readonly T2 m_Item2;
		private readonly T3 m_Item3;
		private readonly T4 m_Item4;
	
		// Properties
		public T1 Item1 { get => default; }
		public T2 Item2 { get => default; }
		public T3 Item3 { get => default; }
		public T4 Item4 { get => default; }
		int ITuple.Length { get => default; }
	
		// Constructors
		public Tuple() {} // Dummy constructor
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4) {}
	
		// Methods
		public override bool Equals(object obj) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object obj) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		int ITupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string ITupleInternal.ToString(StringBuilder sb) => default;
	}

	[Serializable]
	public class Tuple<T1, T2, T3, T4, T5> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal // TypeDefIndex: 38855
	{
		// Fields
		private readonly T1 m_Item1;
		private readonly T2 m_Item2;
		private readonly T3 m_Item3;
		private readonly T4 m_Item4;
		private readonly T5 m_Item5;
	
		// Properties
		int ITuple.Length { get => default; }
	
		// Constructors
		public Tuple() {} // Dummy constructor
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) {}
	
		// Methods
		public override bool Equals(object obj) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object obj) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		int ITupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string ITupleInternal.ToString(StringBuilder sb) => default;
	}

	[Serializable]
	public class Tuple<T1, T2, T3, T4, T5, T6> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal // TypeDefIndex: 38856
	{
		// Fields
		private readonly T1 m_Item1;
		private readonly T2 m_Item2;
		private readonly T3 m_Item3;
		private readonly T4 m_Item4;
		private readonly T5 m_Item5;
		private readonly T6 m_Item6;
	
		// Properties
		int ITuple.Length { get => default; }
	
		// Constructors
		public Tuple() {} // Dummy constructor
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) {}
	
		// Methods
		public override bool Equals(object obj) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object obj) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		int ITupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string ITupleInternal.ToString(StringBuilder sb) => default;
	}

	[Serializable]
	public class Tuple<T1, T2, T3, T4, T5, T6, T7> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal // TypeDefIndex: 38857
	{
		// Fields
		private readonly T1 m_Item1;
		private readonly T2 m_Item2;
		private readonly T3 m_Item3;
		private readonly T4 m_Item4;
		private readonly T5 m_Item5;
		private readonly T6 m_Item6;
		private readonly T7 m_Item7;
	
		// Properties
		int ITuple.Length { get => default; }
	
		// Constructors
		public Tuple() {} // Dummy constructor
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) {}
	
		// Methods
		public override bool Equals(object obj) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object obj) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		int ITupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string ITupleInternal.ToString(StringBuilder sb) => default;
	}

	[Serializable]
	public class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal // TypeDefIndex: 38858
	{
		// Fields
		private readonly T1 m_Item1;
		private readonly T2 m_Item2;
		private readonly T3 m_Item3;
		private readonly T4 m_Item4;
		private readonly T5 m_Item5;
		private readonly T6 m_Item6;
		private readonly T7 m_Item7;
		private readonly TRest m_Rest;
	
		// Properties
		public TRest Rest { get => default; }
		int ITuple.Length { get => default; }
	
		// Constructors
		public Tuple() {} // Dummy constructor
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest) {}
	
		// Methods
		public override bool Equals(object obj) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object obj) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		int ITupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string ITupleInternal.ToString(StringBuilder sb) => default;
	}

	public static class TupleExtensions // TypeDefIndex: 38859
	{
		// Extension methods
		public static void Deconstruct<T1, T2>(this Tuple<T1, T2> value, out ref T1 item1, out ref T2 item2) {
			item1 = default;
			item2 = default;
		}
	}

	[Serializable]
	public abstract class Type : MemberInfo, IReflect, _Type // TypeDefIndex: 38860
	{
		// Fields
		private static Binder s_defaultBinder; // 0x00
		public static readonly char Delimiter; // 0x08
		public static readonly Type[] EmptyTypes; // 0x10
		public static readonly object Missing; // 0x18
		public static readonly MemberFilter FilterAttribute; // 0x20
		public static readonly MemberFilter FilterName; // 0x28
		public static readonly MemberFilter FilterNameIgnoreCase; // 0x30
		private const System.Reflection.BindingFlags DefaultLookup = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public; // Metadata: 0x01F9E2F4
		internal RuntimeTypeHandle _impl; // 0x10
		internal const string DefaultTypeNameWhenMissingMetadata = "UnknownType"; // Metadata: 0x01F9E2F5
	
		// Properties
		public virtual bool IsSerializable { get; } // 0x000000018382DB30-0x000000018382DBA0 
		public virtual bool ContainsGenericParameters { get; } // 0x0000000189260B30-0x0000000189260BE4 
		public bool IsVisible { get; } // 0x0000000182F6DE50-0x0000000182F6DEE0 
		public override MemberTypes MemberType { get; } // 0x0000000183D55B70-0x0000000183D55B80 
		public abstract string Namespace { get; }
		public abstract string AssemblyQualifiedName { get; }
		public abstract string FullName { get; }
		public abstract Assembly Assembly { get; }
		public abstract new Module Module { get; }
		public bool IsNested { get; } // 0x0000000182F6DF70-0x0000000182F6DFD0 
		public override Type DeclaringType { get; } // 0x0000000181002730-0x0000000181002740 
		public virtual MethodBase DeclaringMethod { get; } // 0x0000000181002730-0x0000000181002740 
		public override Type ReflectedType { get; } // 0x0000000181002730-0x0000000181002740 
		public abstract Type UnderlyingSystemType { get; }
		public virtual bool IsTypeDefinition { get; } // 0x0000000189261130-0x0000000189261158 
		public bool IsArray { get; } // 0x0000000184270B54-0x0000000184270B64 
		public bool IsByRef { get; } // 0x0000000184270BBC-0x0000000184270BCC 
		public bool IsPointer { get; } // 0x0000000184270B94-0x0000000184270BA4 
		public virtual bool IsConstructedGenericType { get; } // 0x0000000189260E84-0x0000000189260EAC 
		public virtual bool IsGenericParameter { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool IsGenericTypeParameter { get; } // 0x0000000189260F64-0x0000000189260FA0 
		public virtual bool IsGenericMethodParameter { get; } // 0x0000000189260F28-0x0000000189260F64 
		public virtual bool IsGenericType { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool IsGenericTypeDefinition { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool IsSZArray { get; } // 0x0000000189261070-0x0000000189261098 
		public virtual bool IsVariableBoundArray { get; } // 0x000000018926117C-0x00000001892611A8 
		public virtual bool IsByRefLike { get; } // 0x0000000189260E18-0x0000000189260E74 
		public bool HasElementType { get; } // 0x000000018426F538-0x000000018426F548 
		public virtual Type[] GenericTypeArguments { get; } // 0x0000000189260D4C-0x0000000189260DB8 
		public virtual int GenericParameterPosition { get; } // 0x0000000189260CF0-0x0000000189260D4C 
		public virtual GenericParameterAttributes GenericParameterAttributes { get; } // 0x0000000189260CA4-0x0000000189260CF0 
		public TypeAttributes Attributes { get; } // 0x0000000184270290-0x00000001842702A0 
		public bool IsAbstract { get; } // 0x0000000182305930-0x0000000182305950 
		public bool IsImport { get; } // 0x0000000189260FA0-0x0000000189260FC0 
		public bool IsSealed { get; } // 0x0000000182476B30-0x0000000182476B50 
		public bool IsSpecialName { get; } // 0x0000000189261110-0x0000000189261130 
		public bool IsClass { get; } // 0x00000001824D9A90-0x00000001824D9AD0 
		public bool IsNestedAssembly { get; } // 0x0000000182E52690-0x0000000182E526C0 
		public bool IsNestedFamANDAssem { get; } // 0x0000000189260FF0-0x0000000189261010 
		public bool IsNestedFamily { get; } // 0x0000000189261030-0x0000000189261050 
		public bool IsNestedFamORAssem { get; } // 0x0000000189261010-0x0000000189261030 
		public bool IsNestedPrivate { get; } // 0x0000000189261050-0x0000000189261070 
		public bool IsNestedPublic { get; } // 0x0000000182E526C0-0x0000000182E526F0 
		public bool IsNotPublic { get; } // 0x0000000182F6DF50-0x0000000182F6DF70 
		public bool IsPublic { get; } // 0x0000000182F6DF30-0x0000000182F6DF50 
		public bool IsAutoLayout { get; } // 0x0000000189260DFC-0x0000000189260E18 
		public bool IsExplicitLayout { get; } // 0x0000000182D35E80-0x0000000182D35EB0 
		public bool IsLayoutSequential { get; } // 0x0000000189260FC0-0x0000000189260FE0 
		public bool IsAnsiClass { get; } // 0x0000000189260DB8-0x0000000189260DD8 
		public bool IsAutoClass { get; } // 0x0000000189260DD8-0x0000000189260DFC 
		public bool IsUnicodeClass { get; } // 0x0000000189261158-0x000000018926117C 
		public bool IsCOMObject { get; } // 0x0000000189260E74-0x0000000189260E84 
		public bool IsContextful { get; } // 0x0000000189260EAC-0x0000000189260EBC 
		public virtual bool IsCollectible { get; } // 0x000000018232EB60-0x000000018232EB70 
		public virtual bool IsEnum { get; } // 0x0000000189260EBC-0x0000000189260F28 
		public bool IsMarshalByRef { get; } // 0x0000000189260FE0-0x0000000189260FF0 
		public bool IsPrimitive { get; } // 0x000000018426FFC4-0x000000018426FFD4 
		public bool IsValueType { get; } // 0x000000018426FFB4-0x000000018426FFC4 
		public virtual bool IsSignatureType { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool IsSecurityCritical { get; } // 0x0000000189261098-0x00000001892610C0 
		public virtual bool IsSecuritySafeCritical { get; } // 0x00000001892610C0-0x00000001892610E8 
		public virtual bool IsSecurityTransparent { get; } // 0x00000001892610E8-0x0000000189261110 
		public virtual StructLayoutAttribute StructLayoutAttribute { get; } // 0x00000001892611F4-0x0000000189261240 
		public ConstructorInfo TypeInitializer { get; } // 0x000000018926128C-0x00000001892612F8 
		public virtual RuntimeTypeHandle TypeHandle { get; } // 0x0000000189261240-0x000000018926128C 
		public abstract Guid GUID { get; }
		public abstract Type BaseType { get; }
		public static Binder DefaultBinder { get; } // 0x000000018232ADC0-0x000000018232AEC0 
		internal virtual bool IsUserType { get; } // 0x000000018232EB60-0x000000018232EB70 
		internal virtual bool IsSzArray { get; } // 0x000000018115F4C0-0x000000018115F530 
		public bool IsInterface { get; } // 0x00000001824E00E0-0x00000001824E0A80 
		internal string FullNameOrDefault { get; } // 0x0000000189260BE4-0x0000000189260CA4 
		internal string InternalNameIfAvailable { get; } // 0x00000001891CF528-0x00000001891CF538 
		internal string NameOrDefault { get; } // 0x00000001892611A8-0x00000001892611F4 
	
		// Constructors
		protected Type() {} // 0x000000018350B670-0x000000018350B680
		static Type() {} // 0x000000018389DDD0-0x000000018389DFE0
	
		// Methods
		public virtual bool IsEnumDefined(object value) => default; // 0x0000000189260088-0x000000018926044C
		public virtual string GetEnumName(object value) => default; // 0x000000018925E8AC-0x000000018925EABC
		public virtual string[] GetEnumNames() => default; // 0x000000018925EABC-0x000000018925EB74
		private Array GetEnumRawConstantValues() => default; // 0x000000018925EB74-0x000000018925EBA0
		private void GetEnumData(out string[] enumNames, out Array enumValues) {
			enumNames = default;
			enumValues = default;
		} // 0x000000018925E628-0x000000018925E8AC
		private static int BinarySearch(Array array, object value) => default; // 0x000000018925D460-0x000000018925D574
		internal static bool IsIntegerType(Type t) => default; // 0x00000001825FA1D0-0x00000001825FA3D0
		internal Type GetRootElementType() => default; // 0x000000018247BF00-0x000000018247BF40
		public virtual Type[] FindInterfaces(TypeFilter filter, object filterCriteria) => default; // 0x000000018925DCD0-0x000000018925DE70
		public virtual MemberInfo[] FindMembers(MemberTypes memberType, System.Reflection.BindingFlags bindingAttr, MemberFilter filter, object filterCriteria) => default; // 0x000000018925DE70-0x000000018925E4EC
		[ComVisible(true)]
		public virtual bool IsSubclassOf(Type c) => default; // 0x0000000189260550-0x00000001892605D4
		public virtual bool IsAssignableFrom(Type c) => default; // 0x000000018925FED0-0x0000000189260010
		internal bool ImplementInterface(Type ifaceType) => default; // 0x000000018925FD24-0x000000018925FE30
		private static bool FilterAttributeImpl(MemberInfo m, object filterCriteria) => default; // 0x000000018925D5D4-0x000000018925D9C8
		private static bool FilterNameImpl(MemberInfo m, object filterCriteria) => default; // 0x000000018925DB58-0x000000018925DCD0
		private static bool FilterNameIgnoreCaseImpl(MemberInfo m, object filterCriteria) => default; // 0x000000018925D9C8-0x000000018925DB58
		public new Type GetType() => default; // 0x000000018426F82C-0x000000018426F838
		protected abstract bool IsArrayImpl();
		protected abstract bool IsByRefImpl();
		protected abstract bool IsPointerImpl();
		protected abstract bool HasElementTypeImpl();
		public abstract Type GetElementType();
		public virtual int GetArrayRank() => default; // 0x000000018925E548-0x000000018925E5A4
		public virtual Type GetGenericTypeDefinition() => default; // 0x000000018925EEF4-0x000000018925EF50
		public virtual Type[] GetGenericArguments() => default; // 0x000000018925EDF4-0x000000018925EE50
		public virtual Type[] GetGenericParameterConstraints() => default; // 0x000000018925EE50-0x000000018925EEF4
		protected abstract TypeAttributes GetAttributeFlagsImpl();
		protected abstract bool IsCOMObjectImpl();
		protected virtual bool IsContextfulImpl() => default; // 0x0000000189260010-0x0000000189260088
		protected virtual bool IsMarshalByRefImpl() => default; // 0x00000001892604D8-0x0000000189260550
		protected abstract bool IsPrimitiveImpl();
		protected virtual bool IsValueTypeImpl() => default; // 0x00000001892605D4-0x0000000189260640
		[ComVisible(true)]
		public ConstructorInfo GetConstructor(Type[] types) => default; // 0x0000000184274E48-0x0000000184274E70
		[ComVisible(true)]
		public ConstructorInfo GetConstructor(System.Reflection.BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) => default; // 0x0000000184274824-0x0000000184274850
		[ComVisible(true)]
		public ConstructorInfo GetConstructor(System.Reflection.BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) => default; // 0x0000000183162250-0x0000000183162340
		protected abstract ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
		[ComVisible(true)]
		public ConstructorInfo[] GetConstructors() => default; // 0x0000000184270980-0x0000000184270994
		[ComVisible(true)]
		public abstract ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr);
		public EventInfo GetEvent(string name) => default; // 0x000000018925ED74-0x000000018925ED88
		public abstract EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr);
		public virtual EventInfo[] GetEvents() => default; // 0x000000018925ED88-0x000000018925ED98
		public abstract EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr);
		public System.Reflection.FieldInfo GetField(string name) => default; // 0x0000000184271C78-0x0000000184271C8C
		public abstract System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr);
		public System.Reflection.FieldInfo[] GetFields() => default; // 0x0000000184272894-0x00000001842728A4
		public abstract System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr);
		public MemberInfo[] GetMember(string name) => default; // 0x000000018925F024-0x000000018925F038
		public virtual MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr) => default; // 0x000000018925F004-0x000000018925F024
		public virtual MemberInfo[] GetMember(string name, MemberTypes type, System.Reflection.BindingFlags bindingAttr) => default; // 0x000000018925F038-0x000000018925F094
		public MemberInfo[] GetMembers() => default; // 0x000000018925F094-0x000000018925F0A4
		public abstract MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr);
		public MethodInfo GetMethod(string name) => default; // 0x000000018426F7C8-0x000000018426F7D8
		public MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr) => default; // 0x000000018283D6A0-0x000000018283D730
		public MethodInfo GetMethod(string name, Type[] types) => default; // 0x00000001842702B0-0x00000001842702CC
		public MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers) => default; // 0x00000001831B9DE0-0x00000001831B9F10
		public MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) => default; // 0x0000000184275D4C-0x0000000184275D80
		public MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) => default; // 0x000000018283D730-0x000000018283D870
		protected abstract MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
		public MethodInfo GetMethod(string name, int genericParameterCount, Type[] types) => default; // 0x000000018925F3D8-0x000000018925F3F4
		public MethodInfo GetMethod(string name, int genericParameterCount, Type[] types, ParameterModifier[] modifiers) => default; // 0x000000018925F3F4-0x000000018925F424
		public MethodInfo GetMethod(string name, int genericParameterCount, System.Reflection.BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) => default; // 0x000000018925F390-0x000000018925F3D8
		public MethodInfo GetMethod(string name, int genericParameterCount, System.Reflection.BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) => default; // 0x000000018925F14C-0x000000018925F390
		protected virtual MethodInfo GetMethodImpl(string name, int genericParameterCount, System.Reflection.BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) => default; // 0x000000018925F0A4-0x000000018925F0F0
		public MethodInfo[] GetMethods() => default; // 0x000000018925F424-0x000000018925F434
		public abstract MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr);
		public Type GetNestedType(string name) => default; // 0x000000018925F434-0x000000018925F448
		public abstract Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr);
		public Type[] GetNestedTypes() => default; // 0x000000018925F448-0x000000018925F458
		public abstract Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr);
		public PropertyInfo GetProperty(string name) => default; // 0x000000018426FF2C-0x000000018426FF3C
		public PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr) => default; // 0x00000001824E52C0-0x00000001824E5330
		public PropertyInfo GetProperty(string name, Type returnType) => default; // 0x00000001830C9770-0x00000001830C9830
		public PropertyInfo GetProperty(string name, Type[] types) => default; // 0x000000018925F5B0-0x000000018925F5D0
		public PropertyInfo GetProperty(string name, Type returnType, Type[] types) => default; // 0x000000018925F594-0x000000018925F5B0
		public PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers) => default; // 0x000000018925F468-0x000000018925F594
		public PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) => default; // 0x00000001826B98D0-0x00000001826B9960
		protected abstract PropertyInfo GetPropertyImpl(string name, System.Reflection.BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);
		public PropertyInfo[] GetProperties() => default; // 0x000000018925F458-0x000000018925F468
		public abstract PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr);
		public virtual MemberInfo[] GetDefaultMembers() => default; // 0x000000018925E600-0x000000018925E628
		public static RuntimeTypeHandle GetTypeHandle(object o) => default; // 0x000000018925FA68-0x000000018925FAE8
		public static Type[] GetTypeArray(object[] args) => default; // 0x000000018925F5D0-0x000000018925F724
		public static TypeCode GetTypeCode(Type type) => default; // 0x00000001824DAEC0-0x00000001824DAF20
		protected virtual TypeCode GetTypeCodeImpl() => default; // 0x000000018925F724-0x000000018925F7C8
		public static Type GetTypeFromCLSID(Guid clsid) => default; // 0x000000018925F7C8-0x000000018925F818
		public static Type GetTypeFromCLSID(Guid clsid, bool throwOnError) => default; // 0x000000018925F870-0x000000018925F8C4
		public static Type GetTypeFromCLSID(Guid clsid, string server) => default; // 0x000000018925F818-0x000000018925F870
		public static Type GetTypeFromProgID(string progID) => default; // 0x000000018925F9B8-0x000000018925FA04
		public static Type GetTypeFromProgID(string progID, bool throwOnError) => default; // 0x000000018925F970-0x000000018925F9B8
		public static Type GetTypeFromProgID(string progID, string server) => default; // 0x000000018925F924-0x000000018925F970
		[DebuggerHidden]
		[DebuggerStepThrough]
		public object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, Binder binder, object target, object[] args) => default; // 0x000000018925FE8C-0x000000018925FED0
		[DebuggerHidden]
		[DebuggerStepThrough]
		public object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, Binder binder, object target, object[] args, CultureInfo culture) => default; // 0x000000018925FE40-0x000000018925FE8C
		public abstract object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);
		public Type GetInterface(string name) => default; // 0x000000018925EFF4-0x000000018925F004
		public abstract Type GetInterface(string name, bool ignoreCase);
		public abstract Type[] GetInterfaces();
		[ComVisible(true)]
		public virtual InterfaceMapping GetInterfaceMap(Type interfaceType) => default; // 0x000000018925EF98-0x000000018925EFF4
		public virtual bool IsInstanceOfType(object o) => default; // 0x00000001892604A0-0x00000001892604D8
		public virtual bool IsEquivalentTo(Type other) => default; // 0x000000018926044C-0x00000001892604A0
		public virtual Type GetEnumUnderlyingType() => default; // 0x000000018925EBA0-0x000000018925ECD0
		public virtual Array GetEnumValues() => default; // 0x000000018925ECD0-0x000000018925ED74
		public virtual Type MakeArrayType() => default; // 0x0000000189260640-0x000000018926068C
		public virtual Type MakeArrayType(int rank) => default; // 0x000000018926068C-0x00000001892606D8
		public virtual Type MakeByRefType() => default; // 0x00000001892606D8-0x0000000189260724
		public virtual Type MakeGenericType(params Type[] typeArguments) => default; // 0x0000000189260858-0x00000001892608B4
		public virtual Type MakePointerType() => default; // 0x00000001892608B4-0x0000000189260900
		public static Type MakeGenericSignatureType(Type genericTypeDefinition, params Type[] typeArguments) => default; // 0x00000001892607E8-0x0000000189260858
		public static Type MakeGenericMethodParameter(int position) => default; // 0x0000000189260724-0x00000001892607E8
		public override string ToString() => default; // 0x0000000189260AE4-0x0000000189260B30
		public override bool Equals(object o) => default; // 0x000000018925D574-0x000000018925D5D4
		public override int GetHashCode() => default; // 0x000000018925EF50-0x000000018925EF98
		public virtual bool Equals(Type o) => default; // 0x00000001826B7A50-0x00000001826B7AD0
		internal virtual Type InternalResolve() => default; // 0x000000018925FE30-0x000000018925FE40
		internal virtual Type RuntimeResolve() => default; // 0x00000001892609D8-0x0000000189260A24
		internal virtual MethodInfo GetMethod(MethodInfo fromNoninstanciated) => default; // 0x000000018925F0F0-0x000000018925F14C
		internal virtual ConstructorInfo GetConstructor(ConstructorInfo fromNoninstanciated) => default; // 0x000000018925E5A4-0x000000018925E600
		internal virtual System.Reflection.FieldInfo GetField(System.Reflection.FieldInfo fromNoninstanciated) => default; // 0x000000018925ED98-0x000000018925EDF4
		public static Type GetTypeFromHandle(RuntimeTypeHandle handle) => default; // 0x0000000182417340-0x0000000182417710
		private static Type internal_from_handle(IntPtr handle) => default; // 0x000000018426FD68-0x000000018426FD70
		internal virtual RuntimeTypeHandle GetTypeHandleInternal() => default; // 0x000000018925FA58-0x000000018925FA68
		internal virtual bool HasProxyAttributeImpl() => default; // 0x000000018115F4C0-0x000000018115F530
		internal string FormatTypeName() => default; // 0x000000018925E538-0x000000018925E548
		internal virtual string FormatTypeName(bool serialization) => default; // 0x000000018925E4EC-0x000000018925E538
		public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) => default; // 0x000000018925FC1C-0x000000018925FCF4
		public static Type GetType(string typeName, bool throwOnError) => default; // 0x000000018925FB1C-0x000000018925FBE8
		public static Type GetType(string typeName) => default; // 0x00000001835FFDE0-0x00000001835FFE60
		public static Type GetType(string typeName, System.Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver) => default; // 0x000000018925FAE8-0x000000018925FB1C
		public static Type GetType(string typeName, System.Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError) => default; // 0x000000018925FCF4-0x000000018925FD24
		public static Type GetType(string typeName, System.Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase) => default; // 0x000000018925FBE8-0x000000018925FC1C
		public static bool operator ==(Type left, Type right) => default; // 0x000000018232CE30-0x000000018232CE40
		public static bool operator !=(Type left, Type right) => default; // 0x00000001822E54C0-0x00000001822E54D0
		public static Type ReflectionOnlyGetType(string typeName, bool throwIfNotFound, bool ignoreCase) => default; // 0x0000000189260900-0x00000001892609D8
		public static Type GetTypeFromCLSID(Guid clsid, string server, bool throwOnError) => default; // 0x000000018925F8C4-0x000000018925F924
		public static Type GetTypeFromProgID(string progID, string server, bool throwOnError) => default; // 0x000000018925FA04-0x000000018925FA58
		internal bool IsRuntimeImplemented() => default; // 0x00000001831628F0-0x0000000183162950
		internal virtual string InternalGetNameIfAvailable(ref Type rootCauseForFailure) => default; // 0x00000001891CF528-0x00000001891CF538
		void _Type.GetIDsOfNames(in Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId) {} // 0x0000000189260A24-0x0000000189260A54
		void _Type.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo) {} // 0x0000000189260A84-0x0000000189260AB4
		void _Type.GetTypeInfoCount(out uint pcTInfo) {
			pcTInfo = default;
		} // 0x0000000189260A54-0x0000000189260A84
		void _Type.Invoke(uint dispIdMember, in Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr) {} // 0x0000000189260AB4-0x0000000189260AE4
	}

	[Serializable]
	public class TypeAccessException : TypeLoadException // TypeDefIndex: 38861
	{
		// Constructors
		public TypeAccessException() {} // 0x000000018925D174-0x000000018925D1B8
		protected TypeAccessException(SerializationInfo info, StreamingContext context) {} // 0x000000018924925C-0x000000018924927C
	}

	public enum TypeCode // TypeDefIndex: 38862
	{
		Empty = 0,
		Object = 1,
		DBNull = 2,
		Boolean = 3,
		Char = 4,
		SByte = 5,
		Byte = 6,
		Int16 = 7,
		UInt16 = 8,
		Int32 = 9,
		UInt32 = 10,
		Int64 = 11,
		UInt64 = 12,
		Single = 13,
		Double = 14,
		Decimal = 15,
		DateTime = 16,
		String = 18
	}

	[Serializable]
	public sealed class TypeInitializationException : SystemException // TypeDefIndex: 38863
	{
		// Fields
		private string _typeName; // 0x90
	
		// Properties
		public string TypeName { get => default; } // 0x000000018925D410-0x000000018925D460 
	
		// Constructors
		private TypeInitializationException() {} // 0x000000018925D280-0x000000018925D2C4
		public TypeInitializationException(string fullTypeName, Exception innerException) {} // 0x000000018925D2C4-0x000000018925D334
		internal TypeInitializationException(string fullTypeName, string message, Exception innerException) {} // 0x000000018925D3C4-0x000000018925D410
		internal TypeInitializationException(SerializationInfo info, StreamingContext context) {} // 0x000000018925D334-0x000000018925D3C4
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x000000018925D1B8-0x000000018925D280
	}

	[Serializable]
	[CLSCompliant(false)]
	[IsReadOnly]
	public struct UInt16 : IComparable, IConvertible, IFormattable, IComparable<ushort>, IEquatable<ushort>, ISpanFormattable // TypeDefIndex: 38864
	{
		// Fields
		private readonly ushort m_value; // 0x00
		public const ushort MaxValue = 65535; // Metadata: 0x01F9E313
		public const ushort MinValue = 0; // Metadata: 0x01F9E315
	
		// Methods
		public int CompareTo(object value) => default; // 0x00000001892612F8-0x00000001892613B0
		public int CompareTo(ushort value) => default; // 0x0000000183D702C0-0x0000000183D702D0
		public override bool Equals(object obj) => default; // 0x00000001892613B0-0x0000000189261410
		[NonVersionable]
		public bool Equals(ushort obj) => default; // 0x00000001831DF9C0-0x00000001831DF9D0
		public override int GetHashCode() => default; // 0x0000000183D4F990-0x0000000183D4F9A0
		public override string ToString() => default; // 0x0000000189261B90-0x0000000189261C08
		public string ToString(IFormatProvider provider) => default; // 0x0000000189261C90-0x0000000189261D14
		public string ToString(string format) => default; // 0x00000001826D4CC0-0x00000001826D4D50
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000189261C08-0x0000000189261C90
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider provider = null) {
			charsWritten = default;
			return default;
		} // 0x0000000189261D14-0x0000000189261DAC
		[CLSCompliant(false)]
		public static ushort Parse(string s, NumberStyles style) => default; // 0x0000000189261678-0x00000001892616E4
		[CLSCompliant(false)]
		public static ushort Parse(string s, IFormatProvider provider) => default; // 0x0000000189261410-0x0000000189261478
		[CLSCompliant(false)]
		public static ushort Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x0000000189261478-0x00000001892614F4
		private static ushort Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info) => default; // 0x00000001892614F4-0x0000000189261678
		[CLSCompliant(false)]
		public static bool TryParse(string s, out ushort result) {
			result = default;
			return default;
		} // 0x0000000189261DAC-0x0000000189261E14
		[CLSCompliant(false)]
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result) {
			result = default;
			return default;
		} // 0x0000000189261E14-0x0000000189261EAC
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out ushort result) {
			result = default;
			return default;
		} // 0x0000000189261EAC-0x0000000189261F4C
		public TypeCode GetTypeCode() => default; // 0x0000000183D55800-0x0000000183D55810
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x00000001892616E4-0x0000000189261730
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x000000018926177C-0x00000001892617C4
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x00000001892619DC-0x0000000189261A28
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000189261730-0x000000018926177C
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000189261900-0x000000018926194C
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000183D4F990-0x0000000183D4F9A0
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x000000018926194C-0x0000000189261994
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000189261B00-0x0000000189261B48
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000189261994-0x00000001892619DC
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000189261B48-0x0000000189261B90
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000189261A28-0x0000000189261A74
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x00000001892618B4-0x0000000189261900
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000189261854-0x00000001892618B4
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x00000001892617C4-0x0000000189261854
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x0000000189261A74-0x0000000189261B00
	}

	[Serializable]
	[CLSCompliant(false)]
	[IsReadOnly]
	public struct UInt32 : IComparable, IConvertible, IFormattable, IComparable<uint>, IEquatable<uint>, ISpanFormattable // TypeDefIndex: 38865
	{
		// Fields
		private readonly uint m_value; // 0x00
		public const uint MaxValue = 4294967295; // Metadata: 0x01F9E317
		public const uint MinValue = 0; // Metadata: 0x01F9E318
	
		// Methods
		public int CompareTo(object value) => default; // 0x0000000189261F4C-0x0000000189262008
		public int CompareTo(uint value) => default; // 0x0000000189262008-0x000000018926201C
		public override bool Equals(object obj) => default; // 0x000000018926201C-0x0000000189262078
		[NonVersionable]
		public bool Equals(uint obj) => default; // 0x00000001822A9C10-0x00000001822A9C20
		public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
		public override string ToString() => default; // 0x0000000183C805D0-0x0000000183C80660
		public string ToString(IFormatProvider provider) => default; // 0x0000000189262680-0x0000000189262704
		public string ToString(string format) => default; // 0x0000000189262704-0x000000018926277C
		public string ToString(string format, IFormatProvider provider) => default; // 0x00000001892625FC-0x0000000189262680
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider provider = null) {
			charsWritten = default;
			return default;
		} // 0x000000018926277C-0x0000000189262814
		[CLSCompliant(false)]
		public static uint Parse(string s) => default; // 0x0000000189262078-0x00000001892620FC
		[CLSCompliant(false)]
		public static uint Parse(string s, IFormatProvider provider) => default; // 0x00000001892620FC-0x0000000189262190
		[CLSCompliant(false)]
		public static uint Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x0000000182E56DA0-0x0000000182E56F60
		[CLSCompliant(false)]
		public static bool TryParse(string s, out uint result) {
			result = default;
			return default;
		} // 0x00000001892628CC-0x0000000189262960
		[CLSCompliant(false)]
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result) {
			result = default;
			return default;
		} // 0x0000000189262814-0x00000001892628CC
		public TypeCode GetTypeCode() => default; // 0x0000000183D55730-0x0000000183D55740
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000189262190-0x00000001892621D8
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000189262224-0x0000000189262270
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x000000018926248C-0x00000001892624D8
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x00000001892621D8-0x0000000189262224
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x00000001892623AC-0x00000001892623F8
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x00000001892625B0-0x00000001892625FC
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x00000001892623F8-0x0000000189262444
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000183D4E980-0x0000000183D4E990
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000189262444-0x000000018926248C
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000183577710-0x0000000183577760
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x00000001892624D8-0x0000000189262528
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000189262360-0x00000001892623AC
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000189262300-0x0000000189262360
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000189262270-0x0000000189262300
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x0000000189262528-0x00000001892625B0
	}

	[Serializable]
	[CLSCompliant(false)]
	[IsReadOnly]
	public struct UInt64 : IComparable, IConvertible, IFormattable, IComparable<ulong>, IEquatable<ulong>, ISpanFormattable // TypeDefIndex: 38866
	{
		// Fields
		private readonly ulong m_value; // 0x00
		public const ulong MaxValue = 18446744073709551615; // Metadata: 0x01F9E319
		public const ulong MinValue = 0; // Metadata: 0x01F9E321
	
		// Methods
		public int CompareTo(object value) => default; // 0x0000000189262960-0x0000000189262A1C
		public int CompareTo(ulong value) => default; // 0x0000000183045E80-0x0000000183045EA0
		public override bool Equals(object obj) => default; // 0x0000000189262A1C-0x0000000189262A7C
		[NonVersionable]
		public bool Equals(ulong obj) => default; // 0x00000001822A9C20-0x00000001822A9C30
		public override int GetHashCode() => default; // 0x0000000183D70CE0-0x0000000183D70CF0
		public override string ToString() => default; // 0x0000000182A430C0-0x0000000182A43160
		public string ToString(IFormatProvider provider) => default; // 0x00000001892630F4-0x0000000189263178
		public string ToString(string format) => default; // 0x0000000189262FF0-0x000000018926306C
		public string ToString(string format, IFormatProvider provider) => default; // 0x000000018926306C-0x00000001892630F4
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider provider = null) {
			charsWritten = default;
			return default;
		} // 0x0000000189263178-0x0000000189263210
		[CLSCompliant(false)]
		public static ulong Parse(string s) => default; // 0x0000000189262A7C-0x0000000189262B04
		[CLSCompliant(false)]
		public static ulong Parse(string s, IFormatProvider provider) => default; // 0x000000018268C980-0x000000018268CAE0
		[CLSCompliant(false)]
		public static ulong Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x00000001824E4750-0x00000001824E4910
		[CLSCompliant(false)]
		public static bool TryParse(string s, out ulong result) {
			result = default;
			return default;
		} // 0x0000000182AED4C0-0x0000000182AED620
		[CLSCompliant(false)]
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result) {
			result = default;
			return default;
		} // 0x0000000189263210-0x00000001892632C8
		public TypeCode GetTypeCode() => default; // 0x0000000183D557A0-0x0000000183D557B0
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000189262B04-0x0000000189262B50
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000189262B9C-0x0000000189262BE8
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000189262E1C-0x0000000189262E68
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000189262B50-0x0000000189262B9C
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000189262D38-0x0000000189262D84
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000189262F58-0x0000000189262FA4
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000189262D84-0x0000000189262DD0
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000189262FA4-0x0000000189262FF0
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000189262DD0-0x0000000189262E1C
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x00000001820C61B0-0x00000001820C61C0
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000189262E68-0x0000000189262ECC
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000189262CD8-0x0000000189262D38
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000189262C78-0x0000000189262CD8
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000189262BE8-0x0000000189262C78
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x0000000189262ECC-0x0000000189262F58
	}

	[Serializable]
	public class UnauthorizedAccessException : SystemException // TypeDefIndex: 38867
	{
		// Constructors
		public UnauthorizedAccessException() {} // 0x00000001892632C8-0x000000018926330C
		public UnauthorizedAccessException(string message) {} // 0x000000018926330C-0x000000018926332C
		protected UnauthorizedAccessException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	public class UnhandledExceptionEventArgs : EventArgs // TypeDefIndex: 38868
	{
		// Fields
		private object _exception; // 0x10
		private bool _isTerminating; // 0x18
	
		// Properties
		public object ExceptionObject { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public bool IsTerminating { get => default; } // 0x0000000181002A50-0x0000000181002A60 
	
		// Constructors
		public UnhandledExceptionEventArgs() {} // Dummy constructor
		public UnhandledExceptionEventArgs(object exception, bool isTerminating) {} // 0x000000018926332C-0x0000000189263390
	}

	[Serializable]
	public delegate void UnhandledExceptionEventHandler(object sender, UnhandledExceptionEventArgs e); // TypeDefIndex: 38869; 0x0000000182065C10-0x0000000182065C20

	internal interface IValueTupleInternal : ITuple // TypeDefIndex: 38870
	{
		// Methods
		int GetHashCode(IEqualityComparer comparer);
		string ToStringEnd();
	}

	[Serializable]
	public struct ValueTuple : IEquatable<System.ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<System.ValueTuple>, IValueTupleInternal // TypeDefIndex: 38871
	{
		// Properties
		int ITuple.Length { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189263658-0x00000001892636A0
		public bool Equals(ValueTuple other) => default; // 0x000000018232EB60-0x000000018232EB70
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default; // 0x00000001892637AC-0x00000001892637F4
		int IComparable.CompareTo(object other) => default; // 0x00000001892637F4-0x0000000189263900
		public int CompareTo(ValueTuple other) => default; // 0x0000000181002730-0x0000000181002740
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default; // 0x00000001892636A0-0x00000001892637AC
		public override int GetHashCode() => default; // 0x0000000181002730-0x0000000181002740
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default; // 0x0000000181002730-0x0000000181002740
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer) => default; // 0x0000000181002730-0x0000000181002740
		public override string ToString() => default; // 0x000000018926392C-0x0000000189263958
		string IValueTupleInternal.ToStringEnd() => default; // 0x0000000189263900-0x000000018926392C
		internal static int CombineHashCodes(int h1, int h2) => default; // 0x0000000182BAECA0-0x0000000182BAF090
		internal static int CombineHashCodes(int h1, int h2, int h3) => default; // 0x0000000182BAE890-0x0000000182BAE910
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4) => default; // 0x0000000189263538-0x00000001892635B4
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5) => default; // 0x0000000189263390-0x0000000189263414
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6) => default; // 0x0000000189263414-0x00000001892634A0
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7) => default; // 0x00000001892634A0-0x0000000189263538
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8) => default; // 0x00000001892635B4-0x0000000189263658
	}

	[Serializable]
	public struct ValueTuple<T1> : IEquatable<ValueTuple<T1>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1>>, IValueTupleInternal // TypeDefIndex: 38872
	{
		// Fields
		public T1 Item1;
	
		// Properties
		int ITuple.Length { get => default; }
	
		// Constructors
		public ValueTuple(T1 item1) : this() {
			Item1 = default;
		}
	
		// Methods
		public override bool Equals(object obj) => default;
		public bool Equals(ValueTuple<T1> other) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object other) => default;
		public int CompareTo(ValueTuple<T1> other) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string IValueTupleInternal.ToStringEnd() => default;
	}

	[Serializable]
	public struct ValueTuple<T1, T2> : IEquatable<ValueTuple<T1, T2>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2>>, IValueTupleInternal // TypeDefIndex: 38873
	{
		// Fields
		public T1 Item1;
		public T2 Item2;
	
		// Properties
		int ITuple.Length { get => default; }
	
		// Constructors
		public ValueTuple(T1 item1, T2 item2) : this() {
			Item1 = default;
			Item2 = default;
		}
	
		// Methods
		public override bool Equals(object obj) => default;
		public bool Equals(ValueTuple<T1, T2> other) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object other) => default;
		public int CompareTo(ValueTuple<T1, T2> other) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		private int GetHashCodeCore(IEqualityComparer comparer) => default;
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string IValueTupleInternal.ToStringEnd() => default;
	}

	[Serializable]
	public struct ValueTuple<T1, T2, T3> : IEquatable<ValueTuple<T1, T2, T3>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3>>, IValueTupleInternal // TypeDefIndex: 38874
	{
		// Fields
		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
	
		// Properties
		int ITuple.Length { get => default; }
	
		// Constructors
		public ValueTuple(T1 item1, T2 item2, T3 item3) : this() {
			Item1 = default;
			Item2 = default;
			Item3 = default;
		}
	
		// Methods
		public override bool Equals(object obj) => default;
		public bool Equals(ValueTuple<T1, T2, T3> other) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object other) => default;
		public int CompareTo(ValueTuple<T1, T2, T3> other) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		private int GetHashCodeCore(IEqualityComparer comparer) => default;
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string IValueTupleInternal.ToStringEnd() => default;
	}

	[Serializable]
	public struct ValueTuple<T1, T2, T3, T4> : IEquatable<ValueTuple<T1, T2, T3, T4>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4>>, IValueTupleInternal // TypeDefIndex: 38875
	{
		// Fields
		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
	
		// Properties
		int ITuple.Length { get => default; }
	
		// Constructors
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4) : this() {
			Item1 = default;
			Item2 = default;
			Item3 = default;
			Item4 = default;
		}
	
		// Methods
		public override bool Equals(object obj) => default;
		public bool Equals(ValueTuple<T1, T2, T3, T4> other) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object other) => default;
		public int CompareTo(ValueTuple<T1, T2, T3, T4> other) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		private int GetHashCodeCore(IEqualityComparer comparer) => default;
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string IValueTupleInternal.ToStringEnd() => default;
	}

	[Serializable]
	public struct ValueTuple<T1, T2, T3, T4, T5> : IEquatable<ValueTuple<T1, T2, T3, T4, T5>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5>>, IValueTupleInternal // TypeDefIndex: 38876
	{
		// Fields
		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
	
		// Properties
		int ITuple.Length { get => default; }
	
		// Constructors
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) : this() {
			Item1 = default;
			Item2 = default;
			Item3 = default;
			Item4 = default;
			Item5 = default;
		}
	
		// Methods
		public override bool Equals(object obj) => default;
		public bool Equals(ValueTuple<T1, T2, T3, T4, T5> other) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object other) => default;
		public int CompareTo(ValueTuple<T1, T2, T3, T4, T5> other) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		private int GetHashCodeCore(IEqualityComparer comparer) => default;
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string IValueTupleInternal.ToStringEnd() => default;
	}

	[Serializable]
	public struct ValueTuple<T1, T2, T3, T4, T5, T6> : IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IValueTupleInternal // TypeDefIndex: 38877
	{
		// Fields
		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
	
		// Properties
		int ITuple.Length { get => default; }
	
		// Constructors
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) : this() {
			Item1 = default;
			Item2 = default;
			Item3 = default;
			Item4 = default;
			Item5 = default;
			Item6 = default;
		}
	
		// Methods
		public override bool Equals(object obj) => default;
		public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6> other) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object other) => default;
		public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6> other) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		private int GetHashCodeCore(IEqualityComparer comparer) => default;
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string IValueTupleInternal.ToStringEnd() => default;
	}

	[Serializable]
	public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7> : IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IValueTupleInternal // TypeDefIndex: 38878
	{
		// Fields
		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
	
		// Properties
		int ITuple.Length { get => default; }
	
		// Constructors
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) : this() {
			Item1 = default;
			Item2 = default;
			Item3 = default;
			Item4 = default;
			Item5 = default;
			Item6 = default;
			Item7 = default;
		}
	
		// Methods
		public override bool Equals(object obj) => default;
		public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7> other) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object other) => default;
		public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7> other) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		private int GetHashCodeCore(IEqualityComparer comparer) => default;
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string IValueTupleInternal.ToStringEnd() => default;
	}

	[Serializable]
	public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IValueTupleInternal // TypeDefIndex: 38879
		where TRest : struct
	{
		// Fields
		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public TRest Rest;
	
		// Properties
		int ITuple.Length { get => default; }
	
		// Constructors
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest) : this() {
			Item1 = default;
			Item2 = default;
			Item3 = default;
			Item4 = default;
			Item5 = default;
			Item6 = default;
			Item7 = default;
			Rest = default;
		}
	
		// Methods
		public override bool Equals(object obj) => default;
		public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object other) => default;
		public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) => default;
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		private int GetHashCodeCore(IEqualityComparer comparer) => default;
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string IValueTupleInternal.ToStringEnd() => default;
	}

	[Serializable]
	public sealed class Version : ICloneable, IComparable, IComparable<System.Version>, IEquatable<System.Version>, ISpanFormattable // TypeDefIndex: 38880
	{
		// Fields
		private readonly int _Major; // 0x10
		private readonly int _Minor; // 0x14
		private readonly int _Build; // 0x18
		private readonly int _Revision; // 0x1C
	
		// Properties
		public int Major { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
		public int Minor { get => default; } // 0x0000000183D50CC0-0x0000000183D50CD0 
		public int Build { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public int Revision { get => default; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 
		private int DefaultFormatFieldCount { get => default; } // 0x000000018398AE50-0x000000018398AE70 
	
		// Constructors
		public Version(int major, int minor, int build, int revision) {} // 0x0000000182A47A20-0x0000000182A47A80
		public Version(int major, int minor, int build) {} // 0x0000000189264638-0x00000001892647A0
		public Version(int major, int minor) {} // 0x00000001892644F8-0x00000001892645EC
		public Version(string version) {} // 0x00000001892645EC-0x0000000189264638
		public Version() {} // 0x0000000183D70D20-0x0000000183D70D30
		private Version(Version version) {} // 0x00000001892647A0-0x00000001892647D8
	
		// Methods
		public object Clone() => default; // 0x0000000189263958-0x00000001892639B8
		public int CompareTo(object version) => default; // 0x00000001892639B8-0x0000000189263A6C
		public int CompareTo(Version value) => default; // 0x0000000189263A6C-0x0000000189263ABC
		public override bool Equals(object obj) => default; // 0x0000000189263ABC-0x0000000189263B20
		public bool Equals(Version obj) => default; // 0x000000018388D040-0x000000018388D060
		public override int GetHashCode() => default; // 0x0000000183D70CF0-0x0000000183D70D20
		public override string ToString() => default; // 0x000000018398ACA0-0x000000018398ACD0
		public string ToString(int fieldCount) => default; // 0x000000018398ACD0-0x000000018398AD30
		public bool TryFormat(Span<char> destination, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x0000000189264338-0x000000018926438C
		public bool TryFormat(Span<char> destination, int fieldCount, out int charsWritten) {
			charsWritten = default;
			return default;
		} // 0x0000000189264230-0x0000000189264338
		bool ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) {
			charsWritten = default;
			return default;
		} // 0x0000000189264210-0x0000000189264230
		private StringBuilder ToCachedStringBuilder(int fieldCount) => default; // 0x000000018398AD30-0x000000018398AE00
		public static Version Parse(string input) => default; // 0x0000000189264184-0x0000000189264210
		public static bool TryParse(string input, out Version result) {
			result = default;
			return default;
		} // 0x0000000189264490-0x00000001892644F8
		private static Version ParseVersion(ReadOnlySpan<char> input, bool throwOnFailure) => default; // 0x0000000189263B20-0x0000000189264184
		private static bool TryParseComponent(ReadOnlySpan<char> component, string componentName, bool throwOnFailure, out int parsedComponent) {
			parsedComponent = default;
			return default;
		} // 0x000000018926438C-0x0000000189264490
		public static bool operator ==(Version v1, Version v2) => default; // 0x000000018388D020-0x000000018388D040
		public static bool operator !=(Version v1, Version v2) => default; // 0x000000018388CFB0-0x000000018388CFE0
		public static bool operator <(Version v1, Version v2) => default; // 0x0000000189264860-0x000000018926492C
		public static bool operator <=(Version v1, Version v2) => default; // 0x00000001892647EC-0x0000000189264860
		public static bool operator >=(Version v1, Version v2) => default; // 0x00000001892647D8-0x00000001892647EC
	}

	public struct Void // TypeDefIndex: 38881
	{
	}

	internal static class FixedBufferExtensions // TypeDefIndex: 38882
	{
		// Extension methods
		internal static string GetStringFromFixedBuffer(this ReadOnlySpan<char> span) => default; // 0x0000000189256B28-0x0000000189256BA4
		internal static int GetFixedBufferStringLength(this ReadOnlySpan<char> span) => default; // 0x0000000189256AD4-0x0000000189256B28
		internal static bool FixedBufferEqualsString(this ReadOnlySpan<char> span, string value) => default; // 0x0000000189256A08-0x0000000189256AD4
	}

	internal static class NotImplemented // TypeDefIndex: 38883
	{
		// Properties
		internal static Exception ByDesign { get; } // 0x0000000189257114-0x0000000189257164 
	}

	public interface IServiceProvider // TypeDefIndex: 38884
	{
		// Methods
		object GetService(System.Type serviceType);
	}

	public delegate void ConsoleCancelEventHandler(object sender, ConsoleCancelEventArgs e); // TypeDefIndex: 38885; 0x0000000182065C10-0x0000000182065C20

	[Serializable]
	public sealed class ConsoleCancelEventArgs : EventArgs // TypeDefIndex: 38886
	{
		// Fields
		private readonly ConsoleSpecialKey _type; // 0x10
	
		// Properties
		public bool Cancel { get; } // 0x0000000183D58C00-0x0000000183D58C10 
	
		// Constructors
		internal ConsoleCancelEventArgs(ConsoleSpecialKey type) {} // 0x0000000189256458-0x00000001892564A8
		internal ConsoleCancelEventArgs() {} // 0x00000001892564A8-0x00000001892564D8
	}

	public enum ConsoleColor // TypeDefIndex: 38887
	{
		Black = 0,
		DarkBlue = 1,
		DarkGreen = 2,
		DarkCyan = 3,
		DarkRed = 4,
		DarkMagenta = 5,
		DarkYellow = 6,
		Gray = 7,
		DarkGray = 8,
		Blue = 9,
		Green = 10,
		Cyan = 11,
		Red = 12,
		Magenta = 13,
		Yellow = 14,
		White = 15
	}

	public enum ConsoleKey // TypeDefIndex: 38888
	{
		Backspace = 8,
		Tab = 9,
		Clear = 12,
		Enter = 13,
		Pause = 19,
		Escape = 27,
		Spacebar = 32,
		PageUp = 33,
		PageDown = 34,
		End = 35,
		Home = 36,
		LeftArrow = 37,
		UpArrow = 38,
		RightArrow = 39,
		DownArrow = 40,
		Select = 41,
		Print = 42,
		Execute = 43,
		PrintScreen = 44,
		Insert = 45,
		Delete = 46,
		Help = 47,
		D0 = 48,
		D1 = 49,
		D2 = 50,
		D3 = 51,
		D4 = 52,
		D5 = 53,
		D6 = 54,
		D7 = 55,
		D8 = 56,
		D9 = 57,
		A = 65,
		B = 66,
		C = 67,
		D = 68,
		E = 69,
		F = 70,
		G = 71,
		H = 72,
		I = 73,
		J = 74,
		K = 75,
		L = 76,
		M = 77,
		N = 78,
		O = 79,
		P = 80,
		Q = 81,
		R = 82,
		S = 83,
		T = 84,
		U = 85,
		V = 86,
		W = 87,
		X = 88,
		Y = 89,
		Z = 90,
		LeftWindows = 91,
		RightWindows = 92,
		Applications = 93,
		Sleep = 95,
		NumPad0 = 96,
		NumPad1 = 97,
		NumPad2 = 98,
		NumPad3 = 99,
		NumPad4 = 100,
		NumPad5 = 101,
		NumPad6 = 102,
		NumPad7 = 103,
		NumPad8 = 104,
		NumPad9 = 105,
		Multiply = 106,
		Add = 107,
		Separator = 108,
		Subtract = 109,
		Decimal = 110,
		Divide = 111,
		F1 = 112,
		F2 = 113,
		F3 = 114,
		F4 = 115,
		F5 = 116,
		F6 = 117,
		F7 = 118,
		F8 = 119,
		F9 = 120,
		F10 = 121,
		F11 = 122,
		F12 = 123,
		F13 = 124,
		F14 = 125,
		F15 = 126,
		F16 = 127,
		F17 = 128,
		F18 = 129,
		F19 = 130,
		F20 = 131,
		F21 = 132,
		F22 = 133,
		F23 = 134,
		F24 = 135,
		BrowserBack = 166,
		BrowserForward = 167,
		BrowserRefresh = 168,
		BrowserStop = 169,
		BrowserSearch = 170,
		BrowserFavorites = 171,
		BrowserHome = 172,
		VolumeMute = 173,
		VolumeDown = 174,
		VolumeUp = 175,
		MediaNext = 176,
		MediaPrevious = 177,
		MediaStop = 178,
		MediaPlay = 179,
		LaunchMail = 180,
		LaunchMediaSelect = 181,
		LaunchApp1 = 182,
		LaunchApp2 = 183,
		Oem1 = 186,
		OemPlus = 187,
		OemComma = 188,
		OemMinus = 189,
		OemPeriod = 190,
		Oem2 = 191,
		Oem3 = 192,
		Oem4 = 219,
		Oem5 = 220,
		Oem6 = 221,
		Oem7 = 222,
		Oem8 = 223,
		Oem102 = 226,
		Process = 229,
		Packet = 231,
		Attention = 246,
		CrSel = 247,
		ExSel = 248,
		EraseEndOfFile = 249,
		Play = 250,
		Zoom = 251,
		NoName = 252,
		Pa1 = 253,
		OemClear = 254
	}

	[Serializable]
	[IsReadOnly]
	public struct ConsoleKeyInfo // TypeDefIndex: 38889
	{
		// Fields
		private readonly char _keyChar; // 0x00
		private readonly ConsoleKey _key; // 0x04
		private readonly ConsoleModifiers _mods; // 0x08
	
		// Properties
		public char KeyChar { get => default; } // 0x0000000183D4F990-0x0000000183D4F9A0 
		public ConsoleKey Key { get => default; } // 0x0000000183D4E990-0x0000000183D4E9A0 
	
		// Constructors
		public ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) : this() {
			_keyChar = default;
			_key = default;
			_mods = default;
		} // 0x0000000189256570-0x0000000189256624
	
		// Methods
		public override bool Equals(object value) => default; // 0x00000001892564F8-0x0000000189256570
		public bool Equals(ConsoleKeyInfo obj) => default; // 0x00000001892564D8-0x00000001892564F8
		public override int GetHashCode() => default; // 0x0000000183D70AF0-0x0000000183D70B10
	}

	[Flags]
	public enum ConsoleModifiers // TypeDefIndex: 38890
	{
		Alt = 1,
		Shift = 2,
		Control = 4
	}

	public enum ConsoleSpecialKey // TypeDefIndex: 38891
	{
		ControlC = 0,
		ControlBreak = 1
	}

	[IsReadOnly]
	public struct SequencePosition : IEquatable<SequencePosition> // TypeDefIndex: 38892
	{
		// Fields
		private readonly object _object; // 0x00
		private readonly int _integer; // 0x08
	
		// Constructors
		public SequencePosition(object @object, int integer) {
			_object = default;
			_integer = default;
		} // 0x0000000184274600-0x000000018427461C
	
		// Methods
		public object GetObject() => default; // 0x00000001820C61B0-0x00000001820C61C0
		public int GetInteger() => default; // 0x0000000183D516F0-0x0000000183D51700
		public bool Equals(SequencePosition other) => default; // 0x0000000189259594-0x00000001892595B0
		public override bool Equals(object obj) => default; // 0x00000001892595B0-0x0000000189259620
		public override int GetHashCode() => default; // 0x0000000189259620-0x000000018925968C
	}

	[StackTraceHidden]
	internal static class ThrowHelper // TypeDefIndex: 38893
	{
		// Methods
		internal static void ThrowArgumentNullException(ExceptionArgument argument) {} // 0x000000018925C080-0x000000018925C0A8
		private static Exception CreateArgumentNullException(ExceptionArgument argument) => default; // 0x000000018925AF2C-0x000000018925AFBC
		internal static void ThrowArrayTypeMismatchException() {} // 0x000000018925C280-0x000000018925C2A8
		private static Exception CreateArrayTypeMismatchException() => default; // 0x000000018925B100-0x000000018925B150
		internal static void ThrowArgumentException_DestinationTooShort() {} // 0x000000018925BF88-0x000000018925BFB0
		private static Exception CreateArgumentException_DestinationTooShort() => default; // 0x000000018925AEC8-0x000000018925AF2C
		internal static void ThrowIndexOutOfRangeException() {} // 0x000000018925C31C-0x000000018925C344
		private static Exception CreateIndexOutOfRangeException() => default; // 0x000000018925B150-0x000000018925B1A0
		internal static void ThrowArgumentOutOfRangeException() {} // 0x000000018925C1EC-0x000000018925C214
		private static Exception CreateArgumentOutOfRangeException() => default; // 0x000000018925B020-0x000000018925B070
		internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) {} // 0x000000018925C1C4-0x000000018925C1EC
		private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) => default; // 0x000000018925B070-0x000000018925B100
		internal static void ThrowInvalidOperationException() {} // 0x000000018925C570-0x000000018925C598
		private static Exception CreateInvalidOperationException() => default; // 0x000000018925B204-0x000000018925B254
		internal static void ThrowInvalidOperationException_EndPositionNotReached() {} // 0x000000018925C37C-0x000000018925C3A4
		private static Exception CreateInvalidOperationException_EndPositionNotReached() => default; // 0x000000018925B1A0-0x000000018925B204
		internal static void ThrowArgumentOutOfRangeException_PositionOutOfRange() {} // 0x000000018925C0A8-0x000000018925C0D0
		private static Exception CreateArgumentOutOfRangeException_PositionOutOfRange() => default; // 0x000000018925AFBC-0x000000018925B020
		internal static void ThrowNotSupportedException() {} // 0x000000018925C6D0-0x000000018925C6F8
		private static Exception CreateThrowNotSupportedException() => default; // 0x000000018925B26C-0x000000018925B2BC
		public static void ThrowArgumentValidationException<T>(ReadOnlySequenceSegment<T> startSegment, int startIndex, ReadOnlySequenceSegment<T> endSegment) {}
		private static Exception CreateArgumentValidationException<T>(ReadOnlySequenceSegment<T> startSegment, int startIndex, ReadOnlySequenceSegment<T> endSegment) => default;
		public static void ThrowStartOrEndArgumentValidationException(long start) {} // 0x000000018925C788-0x000000018925C7B0
		private static Exception CreateStartOrEndArgumentValidationException(long start) => default; // 0x000000018925B254-0x000000018925B26C
		internal static void ThrowWrongKeyTypeArgumentException(object key, System.Type targetType) {} // 0x000000018925C7B0-0x000000018925C894
		internal static void ThrowWrongValueTypeArgumentException(object value, System.Type targetType) {} // 0x000000018925C894-0x000000018925C978
		internal static void ThrowArgumentException(ExceptionResource resource) {} // 0x000000018925C024-0x000000018925C080
		internal static void ThrowArgumentException(ExceptionResource resource, ExceptionArgument argument) {} // 0x000000018925BFB0-0x000000018925C024
		internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) {} // 0x000000018925C0D0-0x000000018925C1C4
		internal static void ThrowInvalidOperationException(ExceptionResource resource) {} // 0x000000018925C598-0x000000018925C5F4
		internal static void ThrowSerializationException(ExceptionResource resource) {} // 0x000000018925C6F8-0x000000018925C754
		internal static void ThrowNotSupportedException(ExceptionResource resource) {} // 0x000000018925C674-0x000000018925C6D0
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion() {} // 0x000000018925C400-0x000000018925C45C
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen() {} // 0x000000018925C4B8-0x000000018925C514
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumNotStarted() {} // 0x000000018925C45C-0x000000018925C4B8
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumEnded() {} // 0x000000018925C3A4-0x000000018925C400
		internal static void ThrowInvalidOperationException_InvalidOperation_NoValue() {} // 0x000000018925C514-0x000000018925C570
		private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, string resource) => default; // 0x000000018925B728-0x000000018925B7A4
		internal static void ThrowArgumentOutOfRange_IndexException() {} // 0x000000018925C214-0x000000018925C254
		internal static void ThrowIndexArgumentOutOfRange_NeedNonNegNumException() {} // 0x000000018925C2DC-0x000000018925C31C
		internal static void ThrowArgumentException_Argument_InvalidArrayType() {} // 0x000000018925BF2C-0x000000018925BF88
		private static ArgumentException GetAddingDuplicateWithKeyArgumentException(object key) => default; // 0x000000018925B2BC-0x000000018925B33C
		internal static void ThrowAddingDuplicateWithKeyArgumentException(object key) {} // 0x000000018925BF04-0x000000018925BF2C
		private static KeyNotFoundException GetKeyNotFoundException(object key) => default; // 0x000000018925B8EC-0x000000018925B970
		internal static void ThrowKeyNotFoundException(object key) {} // 0x000000018925C668-0x000000018925C674
		internal static void ThrowInvalidTypeWithPointersNotSupported(System.Type targetType) {} // 0x000000018925C5F4-0x000000018925C668
		internal static void ThrowInvalidOperationException_ConcurrentOperationsNotSupported() {} // 0x000000018925C344-0x000000018925C37C
		internal static InvalidOperationException GetInvalidOperationException(string str) => default; // 0x000000018925B88C-0x000000018925B8EC
		internal static void ThrowArraySegmentCtorValidationFailedExceptions(Array array, int offset, int count) {} // 0x000000018925C254-0x000000018925C280
		private static Exception GetArraySegmentCtorValidationFailedException(Array array, int offset, int count) => default; // 0x000000018925B850-0x000000018925B88C
		private static ArgumentException GetArgumentException(ExceptionResource resource) => default; // 0x000000018925B33C-0x000000018925B3CC
		private static ArgumentNullException GetArgumentNullException(ExceptionArgument argument) => default; // 0x000000018925B6BC-0x000000018925B728
		internal static void IfNullAndNullsAreIllegalThenThrow<T>(object value, ExceptionArgument argName) {}
		internal static string GetArgumentName(ExceptionArgument argument) => default; // 0x000000018925B3CC-0x000000018925B6BC
		private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) => default; // 0x000000018925B7A4-0x000000018925B850
		internal static void ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index() {} // 0x000000018925C754-0x000000018925C788
		internal static void ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count() {} // 0x000000018925C2A8-0x000000018925C2DC
		internal static string GetResourceName(ExceptionResource resource) => default; // 0x000000018925B970-0x000000018925BF04
	}

	[Serializable]
	public class AppDomainUnloadedException : SystemException // TypeDefIndex: 38894
	{
		// Constructors
		public AppDomainUnloadedException() {} // 0x0000000189253628-0x000000018925366C
		protected AppDomainUnloadedException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	public class CannotUnloadAppDomainException : SystemException // TypeDefIndex: 38895
	{
		// Constructors
		public CannotUnloadAppDomainException() {} // 0x0000000189256414-0x0000000189256458
		public CannotUnloadAppDomainException(string message) {} // 0x00000001892563F4-0x0000000189256414
		protected CannotUnloadAppDomainException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	public sealed class OperatingSystem : ISerializable, ICloneable // TypeDefIndex: 38896
	{
		// Fields
		private readonly System.Version _version; // 0x10
		private readonly PlatformID _platform; // 0x18
		private readonly string _servicePack; // 0x20
		private string _versionString; // 0x28
	
		// Properties
		public PlatformID Platform { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public System.Version Version { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public string VersionString { get => default; } // 0x0000000189257564-0x000000018925772C 
	
		// Constructors
		public OperatingSystem() {} // Dummy constructor
		public OperatingSystem(PlatformID platform, System.Version version) {} // 0x0000000189257548-0x0000000189257564
		internal OperatingSystem(PlatformID platform, System.Version version, string servicePack) {} // 0x000000018388CFE0-0x000000018388D020
	
		// Methods
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001892574F4-0x0000000189257540
		public object Clone() => default; // 0x000000018925746C-0x00000001892574F4
		public override string ToString() => default; // 0x0000000189257540-0x0000000189257548
	}

	[Serializable]
	public class MissingFieldException : MissingMemberException, ISerializable // TypeDefIndex: 38897
	{
		// Properties
		public override string Message { get => default; } // 0x0000000189256C08-0x0000000189256CD8 
	
		// Constructors
		public MissingFieldException() {} // 0x0000000189256BA4-0x0000000189256BE8
		public MissingFieldException(string message) {} // 0x0000000189256BE8-0x0000000189256C08
		public MissingFieldException(string className, string fieldName) {} // 0x000000018924EFA8-0x000000018924EFFC
		protected MissingFieldException(SerializationInfo info, StreamingContext context) {} // 0x000000018924EFFC-0x000000018924F01C
	}

	[Serializable]
	public class MissingMemberException : MemberAccessException // TypeDefIndex: 38898
	{
		// Fields
		protected string ClassName; // 0x90
		protected string MemberName; // 0x98
		protected byte[] Signature; // 0xA0
	
		// Properties
		public override string Message { get => default; } // 0x000000018925701C-0x0000000189257114 
	
		// Constructors
		public MissingMemberException() {} // 0x0000000189256E60-0x0000000189256EA4
		public MissingMemberException(string message) {} // 0x0000000189256EA4-0x0000000189256EC4
		protected MissingMemberException(SerializationInfo info, StreamingContext context) {} // 0x0000000189256EC4-0x000000018925701C
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000189256D10-0x0000000189256E60
		internal static string FormatSignature(byte[] signature) => default; // 0x0000000189256CD8-0x0000000189256D10
	}

	[Serializable]
	public class OutOfMemoryException : SystemException // TypeDefIndex: 38899
	{
		// Constructors
		public OutOfMemoryException() {} // 0x0000000189257AE8-0x0000000189257B2C
		public OutOfMemoryException(string message) {} // 0x0000000189257B4C-0x0000000189257B6C
		public OutOfMemoryException(string message, Exception innerException) {} // 0x0000000189257B2C-0x0000000189257B4C
		protected OutOfMemoryException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Serializable]
	public abstract class Array : IList, IStructuralComparable, IStructuralEquatable, ICloneable // TypeDefIndex: 38906
	{
		// Properties
		int ICollection.Count { get; } // 0x0000000183D2D800-0x0000000183D2D810 
		bool IList.IsReadOnly { get; } // 0x000000018115F4C0-0x000000018115F530 
		object IList.this[int index] { get => default; set {} } // 0x0000000189256038-0x0000000189256040 0x0000000189256040-0x0000000189256054
		public long LongLength { get; } // 0x0000000189256390-0x00000001892563F4 
		public bool IsFixedSize { get; } // 0x000000018232EB60-0x000000018232EB70 
		public bool IsReadOnly { get; } // 0x000000018115F4C0-0x000000018115F530 
		public bool IsSynchronized { get; } // 0x000000018115F4C0-0x000000018115F530 
		public object SyncRoot { get; } // 0x000000018339AE90-0x000000018339AEA0 
		public int Length { [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)] get; } // 0x00000001823B9C10-0x00000001823B9C80 
		public int Rank { [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)] get; } // 0x0000000183D70AE0-0x0000000183D70AF0 
	
		// Nested types
		private sealed class ArrayEnumerator : IEnumerator, ICloneable // TypeDefIndex: 38900
		{
			// Fields
			private Array _array; // 0x10
			private int _index; // 0x18
			private int _endIndex; // 0x1C
	
			// Properties
			public object Current { get => default; } // 0x0000000182612050-0x0000000182612110 
	
			// Constructors
			public ArrayEnumerator() {} // Dummy constructor
			internal ArrayEnumerator(Array array) {} // 0x00000001825F8F00-0x00000001825F8F80
	
			// Methods
			public bool MoveNext() => default; // 0x0000000183034730-0x0000000183034750
			public void Reset() {} // 0x0000000183D50330-0x0000000183D50340
			public object Clone() => default; // 0x0000000182A48500-0x0000000182A48510
		}
	
		private class RawData // TypeDefIndex: 38901
		{
			// Fields
			public IntPtr Bounds; // 0x10
			public IntPtr Count; // 0x18
			public byte Data; // 0x20
	
			// Constructors
			public RawData() {} // Dummy constructor
		}
	
		internal struct InternalEnumerator<T> : IEnumerator<T> // TypeDefIndex: 38902
		{
			// Fields
			private readonly Array array;
			private int idx;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			internal InternalEnumerator(Array array) : this() {
				this.array = default;
				idx = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		internal class EmptyInternalEnumerator<T> : IEnumerator<T> // TypeDefIndex: 38903
		{
			// Fields
			public static readonly EmptyInternalEnumerator<T> Value;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public EmptyInternalEnumerator() {}
			static EmptyInternalEnumerator() {}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		private struct SorterObjectArray // TypeDefIndex: 38904
		{
			// Fields
			private object[] keys; // 0x00
			private object[] items; // 0x08
			private System.Collections.IComparer comparer; // 0x10
	
			// Constructors
			internal SorterObjectArray(object[] keys, object[] items, System.Collections.IComparer comparer) {
				this.keys = default;
				this.items = default;
				this.comparer = default;
			} // 0x00000001892704CC-0x0000000189270564
	
			// Methods
			internal void SwapIfGreaterWithItems(int a, int b) {} // 0x000000018927026C-0x00000001892703C4
			private void Swap(int i, int j) {} // 0x00000001892703C4-0x00000001892704CC
			internal void Sort(int left, int length) {} // 0x0000000189270264-0x000000018927026C
			private void IntrospectiveSort(int left, int length) {} // 0x000000018926FFA8-0x000000018927010C
			private void IntroSort(int lo, int hi, int depthLimit) {} // 0x000000018926FEC8-0x000000018926FFA8
			private int PickPivotAndPartition(int lo, int hi) => default; // 0x000000018927010C-0x0000000189270264
			private void Heapsort(int lo, int hi) {} // 0x000000018926FC5C-0x000000018926FCFC
			private void DownHeap(int i, int n, int lo) {} // 0x000000018926FA1C-0x000000018926FC5C
			private void InsertionSort(int lo, int hi) {} // 0x000000018926FCFC-0x000000018926FEC8
		}
	
		private struct SorterGenericArray // TypeDefIndex: 38905
		{
			// Fields
			private Array keys; // 0x00
			private Array items; // 0x08
			private System.Collections.IComparer comparer; // 0x10
	
			// Constructors
			internal SorterGenericArray(Array keys, Array items, System.Collections.IComparer comparer) {
				this.keys = default;
				this.items = default;
				this.comparer = default;
			} // 0x00000001826AA280-0x00000001826AA330
	
			// Methods
			internal void SwapIfGreaterWithItems(int a, int b) {} // 0x00000001826AA520-0x00000001826AA5C0
			private void Swap(int i, int j) {} // 0x00000001826A9FC0-0x00000001826AA060
			internal void Sort(int left, int length) {} // 0x000000018427124C-0x0000000184271254
			private void IntrospectiveSort(int left, int length) {} // 0x00000001826AA060-0x00000001826AA0E0
			private void IntroSort(int lo, int hi, int depthLimit) {} // 0x00000001826AA0E0-0x00000001826AA1B0
			private int PickPivotAndPartition(int lo, int hi) => default; // 0x00000001826AA620-0x00000001826AA780
			private void Heapsort(int lo, int hi) {} // 0x000000018926F97C-0x000000018926FA1C
			private void DownHeap(int i, int n, int lo) {} // 0x000000018926F798-0x000000018926F97C
			private void InsertionSort(int lo, int hi) {} // 0x00000001826AAED0-0x00000001826AAFC0
		}
	
		// Constructors
		private Array() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Array CreateInstance(System.Type elementType, params long[] lengths) => default; // 0x0000000189254518-0x00000001892546D4
		public static ReadOnlyCollection<T> AsReadOnly<T>(T[] array) => default;
		public static void Resize<T>(ref ref T[] array, int newSize) {}
		int IList.Add(object value) => default; // 0x0000000189255E6C-0x0000000189255EC8
		bool IList.Contains(object value) => default; // 0x0000000189255F04-0x0000000189255F1C
		void IList.Clear() {} // 0x0000000189255EC8-0x0000000189255F04
		int IList.IndexOf(object value) => default; // 0x0000000189255F1C-0x0000000189255F24
		void IList.Insert(int index, object value) {} // 0x0000000189255F24-0x0000000189255F80
		void IList.Remove(object value) {} // 0x0000000189255FDC-0x0000000189256038
		void IList.RemoveAt(int index) {} // 0x0000000189255F80-0x0000000189255FDC
		public void CopyTo(Array array, int index) {} // 0x00000001825E7460-0x00000001825E7500
		public object Clone() => default; // 0x0000000182A48500-0x0000000182A48510
		int IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) => default; // 0x0000000189256054-0x00000001892561A8
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default; // 0x00000001892561A8-0x000000018925629C
		internal static int CombineHashCodes(int h1, int h2) => default; // 0x0000000183D67FA0-0x0000000183D67FB0
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default; // 0x000000018925629C-0x0000000189256378
		public static int BinarySearch(Array array, object value) => default; // 0x000000018925366C-0x000000018925371C
		public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Converter<TInput, TOutput> converter) => default;
		public static void Copy(Array sourceArray, Array destinationArray, long length) {} // 0x0000000189253DE0-0x0000000189253E78
		public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length) {} // 0x0000000183721AD0-0x0000000183721B40
		public void CopyTo(Array array, long index) {} // 0x0000000189253D48-0x0000000189253DE0
		public static void ForEach<T>(T[] array, Action<T> action) {}
		public long GetLongLength(int dimension) => default; // 0x00000001892546D4-0x00000001892546E4
		public object GetValue(long index) => default; // 0x0000000189254804-0x000000018925489C
		public object GetValue(long index1, long index2) => default; // 0x00000001892546FC-0x00000001892547FC
		public object GetValue(long index1, long index2, long index3) => default; // 0x0000000189254B7C-0x0000000189254CF8
		public object GetValue(params long[] indices) => default; // 0x000000018925489C-0x0000000189254A60
		public static int BinarySearch(Array array, int index, int length, object value) => default; // 0x0000000189253C80-0x0000000189253C9C
		public static int BinarySearch(Array array, object value, System.Collections.IComparer comparer) => default; // 0x000000018925371C-0x00000001892537D8
		public static int BinarySearch(Array array, int index, int length, object value, System.Collections.IComparer comparer) => default; // 0x00000001892537D8-0x0000000189253C80
		private static int GetMedian(int low, int hi) => default; // 0x0000000183D70AD0-0x0000000183D70AE0
		public static int BinarySearch<T>(T[] array, T value) => default;
		public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer) => default;
		public static int BinarySearch<T>(T[] array, int index, int length, T value) => default;
		public static int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer) => default;
		public static int IndexOf(Array array, object value) => default; // 0x00000001826AAD00-0x00000001826AAD90
		public static int IndexOf(Array array, object value, int startIndex) => default; // 0x0000000189254CF8-0x0000000189254DB0
		public static int IndexOf(Array array, object value, int startIndex, int count) => default; // 0x00000001826AAD90-0x00000001826AAED0
		public static int IndexOf<T>(T[] array, T value) => default;
		public static int IndexOf<T>(T[] array, T value, int startIndex) => default;
		public static int IndexOf<T>(T[] array, T value, int startIndex, int count) => default;
		public static int LastIndexOf(Array array, object value) => default; // 0x0000000189254E68-0x0000000189254F14
		public static int LastIndexOf(Array array, object value, int startIndex) => default; // 0x0000000189254F14-0x0000000189254F88
		public static int LastIndexOf(Array array, object value, int startIndex, int count) => default; // 0x0000000189254F88-0x00000001892552AC
		public static int LastIndexOf<T>(T[] array, T value) => default;
		public static int LastIndexOf<T>(T[] array, T value, int startIndex) => default;
		public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count) => default;
		public static void Reverse(Array array) {} // 0x00000001892552AC-0x0000000189255340
		public static void Reverse(Array array, int index, int length) {} // 0x0000000189255340-0x00000001892555C0
		public static void Reverse<T>(T[] array) {}
		public static void Reverse<T>(T[] array, int index, int length) {}
		public void SetValue(object value, long index) {} // 0x00000001892558CC-0x0000000189255964
		public void SetValue(object value, long index1, long index2) {} // 0x0000000189255AEC-0x0000000189255BF0
		public void SetValue(object value, long index1, long index2, long index3) {} // 0x0000000189255964-0x0000000189255AEC
		public void SetValue(object value, params long[] indices) {} // 0x0000000189255660-0x0000000189255830
		public static void Sort(Array array) {} // 0x00000001826AA410-0x00000001826AA470
		public static void Sort(Array array, int index, int length) {} // 0x0000000189255CC8-0x0000000189255CEC
		public static void Sort(Array array, System.Collections.IComparer comparer) {} // 0x0000000189255CEC-0x0000000189255D98
		public static void Sort(Array array, int index, int length, System.Collections.IComparer comparer) {} // 0x0000000189255D98-0x0000000189255DBC
		public static void Sort(Array keys, Array items) {} // 0x0000000189255DBC-0x0000000189255E6C
		public static void Sort(Array keys, Array items, System.Collections.IComparer comparer) {} // 0x0000000189255C0C-0x0000000189255CC8
		public static void Sort(Array keys, Array items, int index, int length) {} // 0x0000000189255BF0-0x0000000189255C0C
		public static void Sort(Array keys, Array items, int index, int length, System.Collections.IComparer comparer) {} // 0x00000001826AA330-0x00000001826AA410
		public static void Sort<T>(T[] array) {}
		public static void Sort<T>(T[] array, int index, int length) {}
		public static void Sort<T>(T[] array, IComparer<T> comparer) {}
		public static void Sort<T>(T[] array, int index, int length, IComparer<T> comparer) {}
		public static void Sort<T>(T[] array, Comparison<T> comparison) {}
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items) {}
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length) {}
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, IComparer<TKey> comparer) {}
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer) {}
		public static bool Exists<T>(T[] array, Predicate<T> match) => default;
		public static void Fill<T>(T[] array, T value) {}
		public static void Fill<T>(T[] array, T value, int startIndex, int count) {}
		public static T Find<T>(T[] array, Predicate<T> match) => default;
		public static T[] FindAll<T>(T[] array, Predicate<T> match) => default;
		public static int FindIndex<T>(T[] array, Predicate<T> match) => default;
		public static int FindIndex<T>(T[] array, int startIndex, Predicate<T> match) => default;
		public static int FindIndex<T>(T[] array, int startIndex, int count, Predicate<T> match) => default;
		public static T FindLast<T>(T[] array, Predicate<T> match) => default;
		public static int FindLastIndex<T>(T[] array, Predicate<T> match) => default;
		public static int FindLastIndex<T>(T[] array, int startIndex, Predicate<T> match) => default;
		public static int FindLastIndex<T>(T[] array, int startIndex, int count, Predicate<T> match) => default;
		public static bool TrueForAll<T>(T[] array, Predicate<T> match) => default;
		public IEnumerator GetEnumerator() => default; // 0x00000001825F8E30-0x00000001825F8F00
		internal int InternalArray__ICollection_get_Count() => default; // 0x00000001823B9870-0x00000001823B98E0
		internal bool InternalArray__ICollection_get_IsReadOnly() => default; // 0x000000018232EB60-0x000000018232EB70
		internal ref byte GetRawSzArrayData() => ref _refReturnTypeForGetRawSzArrayData; // 0x00000001892546E4-0x00000001892546FC
		private ref byte _refReturnTypeForGetRawSzArrayData; // Dummy field
		internal IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>() => default;
		internal void InternalArray__ICollection_Clear() {} // 0x0000000189254DB0-0x0000000189254E0C
		internal void InternalArray__ICollection_Add<T>(T item) {}
		internal bool InternalArray__ICollection_Remove<T>(T item) => default;
		internal bool InternalArray__ICollection_Contains<T>(T item) => default;
		internal void InternalArray__ICollection_CopyTo<T>(T[] array, int arrayIndex) {}
		internal T InternalArray__IReadOnlyList_get_Item<T>(int index) => default;
		internal int InternalArray__IReadOnlyCollection_get_Count() => default; // 0x0000000183D2D800-0x0000000183D2D810
		internal void InternalArray__Insert<T>(int index, T item) {}
		internal void InternalArray__RemoveAt(int index) {} // 0x0000000189254E0C-0x0000000189254E68
		internal int InternalArray__IndexOf<T>(T item) => default;
		internal T InternalArray__get_Item<T>(int index) => default;
		internal void InternalArray__set_Item<T>(int index, T item) {}
		internal void GetGenericValueImpl<T>(int pos, out ref T value) {
			value = default;
		}
		internal void SetGenericValueImpl<T>(int pos, ref ref T value) {}
		private int GetRank() => default; // 0x0000000183D70AE0-0x0000000183D70AF0
		public int GetLength(int dimension) => default; // 0x000000018426FBD4-0x000000018426FBDC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public int GetLowerBound(int dimension) => default; // 0x000000018426FBCC-0x000000018426FBD4
		public object GetValue(params int[] indices) => default; // 0x00000001892547FC-0x0000000189254804
		public void SetValue(object value, params int[] indices) {} // 0x00000001892558C4-0x00000001892558CC
		internal object GetValueImpl(int pos) => default; // 0x0000000184270B7C-0x0000000184270B84
		internal void SetValueImpl(object value, int pos) {} // 0x0000000184270B8C-0x0000000184270B94
		internal static bool FastCopy(Array source, int source_idx, Array dest, int dest_idx, int length) => default; // 0x000000018426FB94-0x000000018426FB9C
		internal static Array CreateInstanceImpl(System.Type elementType, int[] lengths, int[] bounds) => default; // 0x00000001842712C4-0x00000001842712CC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public int GetUpperBound(int dimension) => default; // 0x0000000182612F30-0x0000000182612FB0
		public object GetValue(int index) => default; // 0x00000001826ABDF0-0x00000001826ABEE0
		public object GetValue(int index1, int index2) => default; // 0x0000000189254A60-0x0000000189254AE4
		public object GetValue(int index1, int index2, int index3) => default; // 0x0000000189254AE4-0x0000000189254B7C
		public void SetValue(object value, int index) {} // 0x0000000182612E10-0x0000000182612F30
		public void SetValue(object value, int index1, int index2) {} // 0x0000000189255830-0x00000001892558C4
		public void SetValue(object value, int index1, int index2, int index3) {} // 0x00000001892555C0-0x0000000189255660
		internal static Array UnsafeCreateInstance(System.Type elementType, int[] lengths, int[] lowerBounds) => default; // 0x0000000189256378-0x0000000189256380
		internal static Array UnsafeCreateInstance(System.Type elementType, int length1, int length2) => default; // 0x0000000189256388-0x0000000189256390
		internal static Array UnsafeCreateInstance(System.Type elementType, params int[] lengths) => default; // 0x0000000189256380-0x0000000189256388
		public static Array CreateInstance(System.Type elementType, int length) => default; // 0x00000001826B6F60-0x00000001826B7190
		public static Array CreateInstance(System.Type elementType, int length1, int length2) => default; // 0x0000000189253EC8-0x0000000189253F4C
		public static Array CreateInstance(System.Type elementType, int length1, int length2, int length3) => default; // 0x000000018925447C-0x0000000189254518
		public static Array CreateInstance(System.Type elementType, params int[] lengths) => default; // 0x00000001826B7650-0x00000001826B7A50
		public static Array CreateInstance(System.Type elementType, int[] lengths, int[] lowerBounds) => default; // 0x0000000189253F4C-0x000000018925447C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void Clear(Array array, int index, int length) {} // 0x00000001823B9AC0-0x00000001823B9C10
		private static void ClearInternal(Array a, int index, int count) {} // 0x000000018426FBDC-0x000000018426FC34
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static void Copy(Array sourceArray, Array destinationArray, int length) {} // 0x00000001823B8DD0-0x00000001823B8E60
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) {} // 0x00000001823B74B0-0x00000001823B7660
		private static ArrayTypeMismatchException CreateArrayTypeMismatchException() => default; // 0x0000000189253E78-0x0000000189253EC8
		private static bool CanAssignArrayElement(System.Type source, System.Type target) => default; // 0x0000000189253C9C-0x0000000189253D38
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) {} // 0x0000000189253D38-0x0000000189253D48
		public static T[] Empty<T>() => default;
		public void Initialize() {} // 0x000000018350B670-0x000000018350B680
		private static int IndexOfImpl<T>(T[] array, T value, int startIndex, int count) => default;
		private static int LastIndexOfImpl<T>(T[] array, T value, int startIndex, int count) => default;
		private static void SortImpl(Array keys, Array items, int index, int length, System.Collections.IComparer comparer) {} // 0x00000001826AA1B0-0x00000001826AA280
		internal static T UnsafeLoad<T>(T[] array, int index) => default;
		internal static void UnsafeStore<T>(T[] array, int index, T value) {}
		internal static R UnsafeMov<S, R>(S instance) => default;
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal struct ByReference<T> // TypeDefIndex: 38907
	{
		// Fields
		private IntPtr _value;
	
		// Properties
		public ref T Value { [Intrinsic] get => default; }
	
		// Constructors
		[Intrinsic]
		public ByReference(ref ref T value) : this() {
			_value = default;
		}
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All, AllowMultiple = true)]
	internal class MonoTODOAttribute : Attribute // TypeDefIndex: 38908
	{
		// Fields
		private string comment; // 0x10
	
		// Constructors
		public MonoTODOAttribute() {} // 0x000000018350B670-0x000000018350B680
		public MonoTODOAttribute(string comment) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All, AllowMultiple = true)]
	internal class MonoLimitationAttribute : MonoTODOAttribute // TypeDefIndex: 38909
	{
		// Constructors
		public MonoLimitationAttribute() {} // Dummy constructor
		public MonoLimitationAttribute(string comment) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	internal static class AppContextSwitches // TypeDefIndex: 38910
	{
		// Fields
		public static readonly bool SetActorAsReferenceWhenCopyingClaimsIdentity; // 0x00
		public static readonly bool NoAsyncCurrentCulture; // 0x01
		public static readonly bool EnforceJapaneseEraYearRanges; // 0x02
		public static readonly bool FormatJapaneseFirstYearAsANumber; // 0x03
		public static readonly bool EnforceLegacyJapaneseDateParsing; // 0x04
	}

	internal sealed class LocalDataStoreHolder // TypeDefIndex: 38911
	{
		// Fields
		private LocalDataStore m_Store; // 0x10
	
		// Properties
		public LocalDataStore Store { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public LocalDataStoreHolder() {} // Dummy constructor
		public LocalDataStoreHolder(LocalDataStore store) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		~LocalDataStoreHolder() {} // 0x000000018926B50C-0x000000018926B588
	}

	internal sealed class LocalDataStoreElement // TypeDefIndex: 38912
	{
		// Fields
		private object m_value; // 0x10
		private long m_cookie; // 0x18
	
		// Properties
		public object Value { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public long Cookie { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public LocalDataStoreElement() {} // Dummy constructor
		public LocalDataStoreElement(long cookie) {} // 0x0000000183D4EC10-0x0000000183D4EC20
	}

	internal sealed class LocalDataStore // TypeDefIndex: 38913
	{
		// Fields
		private LocalDataStoreElement[] m_DataTable; // 0x10
		private LocalDataStoreMgr m_Manager; // 0x18
	
		// Constructors
		public LocalDataStore() {} // Dummy constructor
		public LocalDataStore(LocalDataStoreMgr mgr, int InitialCapacity) {} // 0x000000018926C664-0x000000018926C6D0
	
		// Methods
		internal void Dispose() {} // 0x000000018926C090-0x000000018926C0B8
		public object GetData(LocalDataStoreSlot slot) => default; // 0x000000018926C10C-0x000000018926C1DC
		public void SetData(LocalDataStoreSlot slot, object data) {} // 0x000000018926C570-0x000000018926C664
		internal void FreeData(int slot, long cookie) {} // 0x000000018926C0B8-0x000000018926C10C
		private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot) => default; // 0x000000018926C1DC-0x000000018926C570
	}

	[ComVisible(true)]
	public sealed class LocalDataStoreSlot // TypeDefIndex: 38914
	{
		// Fields
		private LocalDataStoreMgr m_mgr; // 0x10
		private int m_slot; // 0x18
		private long m_cookie; // 0x20
	
		// Properties
		internal LocalDataStoreMgr Manager { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		internal int Slot { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		internal long Cookie { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public LocalDataStoreSlot() {} // Dummy constructor
		internal LocalDataStoreSlot(LocalDataStoreMgr mgr, int slot, long cookie) {} // 0x0000000182CF1A80-0x0000000182CF1AB0
	
		// Methods
		~LocalDataStoreSlot() {} // 0x000000018926C004-0x000000018926C090
	}

	internal sealed class LocalDataStoreMgr // TypeDefIndex: 38915
	{
		// Fields
		private const int InitialSlotTableSize = 64; // Metadata: 0x01F9E43E
		private const int SlotTableDoubleThreshold = 512; // Metadata: 0x01F9E440
		private const int LargeSlotTableSizeIncrease = 128; // Metadata: 0x01F9E442
		private bool[] m_SlotInfoTable; // 0x10
		private int m_FirstAvailableSlot; // 0x18
		private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
		private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
		private long m_CookieGenerator; // 0x30
	
		// Constructors
		public LocalDataStoreMgr() {} // 0x0000000183A94110-0x0000000183A94200
	
		// Methods
		public LocalDataStoreHolder CreateLocalDataStore() => default; // 0x000000018926B9E0-0x000000018926BB60
		public void DeleteLocalDataStore(LocalDataStore store) {} // 0x000000018926BB60-0x000000018926BC3C
		public LocalDataStoreSlot AllocateDataSlot() => default; // 0x000000018926B588-0x000000018926B8CC
		public LocalDataStoreSlot AllocateNamedDataSlot(string name) => default; // 0x000000018926B8CC-0x000000018926B9E0
		public LocalDataStoreSlot GetNamedDataSlot(string name) => default; // 0x000000018926BE6C-0x000000018926BF8C
		public void FreeNamedDataSlot(string name) {} // 0x000000018926BD90-0x000000018926BE6C
		internal void FreeDataSlot(int slot, long cookie) {} // 0x000000018926BC3C-0x000000018926BD90
		public void ValidateSlot(LocalDataStoreSlot slot) {} // 0x000000018926BF8C-0x000000018926C004
		internal int GetSlotTableLength() => default; // 0x00000001842746EC-0x0000000184274708
	}

	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(_Activator))]
	[ComVisible(true)]
	public sealed class Activator // TypeDefIndex: 38916
	{
		// Constructors
		public Activator() {} // Dummy constructor
	
		// Methods
		public static object CreateInstance(System.Type type, System.Reflection.BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture) => default; // 0x0000000184274850-0x0000000184274874
		public static object CreateInstance(System.Type type, System.Reflection.BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes) => default; // 0x00000001825E4020-0x00000001825E4120
		public static object CreateInstance(System.Type type, params object[] args) => default; // 0x0000000184271254-0x0000000184271280
		public static object CreateInstance(System.Type type, object[] args, object[] activationAttributes) => default; // 0x000000018926492C-0x0000000189264958
		public static object CreateInstance(System.Type type) => default; // 0x0000000184272658-0x0000000184272668
		public static object CreateInstance(System.Type type, bool nonPublic) => default; // 0x00000001842763E0-0x00000001842763EC
		internal static object CreateInstance(System.Type type, bool nonPublic, bool wrapExceptions) => default; // 0x000000018247A200-0x000000018247A540
		public static T CreateInstance<T>() => default;
	}

	[Serializable]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	public abstract class Attribute // TypeDefIndex: 38917
	{
		// Properties
		public virtual object TypeId { get; } // 0x0000000183D70D30-0x0000000183D70D40 
	
		// Constructors
		protected Attribute() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, System.Type type, bool inherit) => default; // 0x00000001824E42C0-0x00000001824E43A0
		private static Attribute[] InternalGetCustomAttributes(EventInfo element, System.Type type, bool inherit) => default; // 0x0000000183B1EB00-0x0000000183B1EB90
		private static Attribute[] InternalParamGetCustomAttributes(ParameterInfo parameter, System.Type attributeType, bool inherit) => default; // 0x00000001892656B0-0x0000000189265A28
		private static bool InternalIsDefined(PropertyInfo element, System.Type attributeType, bool inherit) => default; // 0x0000000189265650-0x00000001892656B0
		private static bool InternalIsDefined(EventInfo element, System.Type attributeType, bool inherit) => default; // 0x00000001892655F0-0x0000000189265650
		private static bool InternalParamIsDefined(ParameterInfo parameter, System.Type attributeType, bool inherit) => default; // 0x00000001830BA410-0x00000001830BA5F0
		public static Attribute[] GetCustomAttributes(MemberInfo element, System.Type type) => default; // 0x00000001891C0900-0x00000001891C090C
		public static Attribute[] GetCustomAttributes(MemberInfo element, System.Type type, bool inherit) => default; // 0x00000001824E2AD0-0x00000001824E2F30
		public static Attribute[] GetCustomAttributes(MemberInfo element) => default; // 0x0000000184271C8C-0x0000000184271C98
		public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit) => default; // 0x0000000183199B60-0x0000000183199C70
		public static bool IsDefined(MemberInfo element, System.Type attributeType) => default; // 0x0000000184273354-0x0000000184273360
		public static bool IsDefined(MemberInfo element, System.Type attributeType, bool inherit) => default; // 0x000000018377C0F0-0x000000018377C240
		public static Attribute GetCustomAttribute(MemberInfo element, System.Type attributeType) => default; // 0x0000000184273200-0x000000018427320C
		public static Attribute GetCustomAttribute(MemberInfo element, System.Type attributeType, bool inherit) => default; // 0x00000001824E2A90-0x00000001824E2AD0
		public static Attribute[] GetCustomAttributes(ParameterInfo element, System.Type attributeType, bool inherit) => default; // 0x00000001836FA7A0-0x00000001836FA900
		public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit) => default; // 0x0000000189264CF4-0x0000000189264E94
		public static bool IsDefined(ParameterInfo element, System.Type attributeType) => default; // 0x00000001891C0918-0x00000001891C0924
		public static bool IsDefined(ParameterInfo element, System.Type attributeType, bool inherit) => default; // 0x00000001830BA2F0-0x00000001830BA410
		public static Attribute[] GetCustomAttributes(Module element, bool inherit) => default; // 0x0000000189265098-0x00000001892651B4
		public static Attribute[] GetCustomAttributes(Module element, System.Type attributeType, bool inherit) => default; // 0x00000001892651B4-0x00000001892653D0
		public static Attribute[] GetCustomAttributes(Assembly element, System.Type attributeType) => default; // 0x00000001891C090C-0x00000001891C0918
		public static Attribute[] GetCustomAttributes(Assembly element, System.Type attributeType, bool inherit) => default; // 0x0000000189264E94-0x0000000189265098
		public static Attribute[] GetCustomAttributes(Assembly element) => default; // 0x00000001892654D4-0x00000001892654E0
		public static Attribute[] GetCustomAttributes(Assembly element, bool inherit) => default; // 0x00000001892653D0-0x00000001892654D4
		public static Attribute GetCustomAttribute(Assembly element, System.Type attributeType) => default; // 0x00000001891C08E4-0x00000001891C08F0
		public static Attribute GetCustomAttribute(Assembly element, System.Type attributeType, bool inherit) => default; // 0x0000000189264C58-0x0000000189264CF4
		public override bool Equals(object obj) => default; // 0x0000000189264AC0-0x0000000189264C58
		private static bool AreFieldValuesEqual(object thisValue, object thatValue) => default; // 0x0000000189264958-0x0000000189264AC0
		public override int GetHashCode() => default; // 0x00000001892654E0-0x00000001892655F0
		public virtual bool Match(object obj) => default; // 0x0000000189265A28-0x0000000189265A38
		public virtual bool IsDefaultAttribute() => default; // 0x000000018115F4C0-0x000000018115F530
	}

	[ComVisible(true)]
	public static class Buffer // TypeDefIndex: 38918
	{
		// Methods
		internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount) => default; // 0x000000018426FF24-0x000000018426FF2C
		internal static unsafe int IndexOfByte(byte* src, byte value, int index, int count) => default; // 0x0000000189265AF8-0x0000000189265B94
		private static int _ByteLength(Array array) => default; // 0x0000000189265BFC-0x0000000189265C04
		internal static unsafe void ZeroMemory(byte* src, long len) {} // 0x0000000189265BE0-0x0000000189265BFC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal static unsafe void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len) {} // 0x0000000189265B94-0x0000000189265BE0
		internal static unsafe void InternalMemcpy(byte* dest, byte* src, int count) {} // 0x0000000183D70D40-0x0000000183D70D50
		public static int ByteLength(Array array) => default; // 0x0000000189265A38-0x0000000189265AF8
		public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count) {} // 0x0000000182462450-0x0000000182462500
		[CLSCompliant(false)]
		public static unsafe void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy) {} // 0x0000000182639060-0x0000000182639330
		internal static unsafe void memcpy4(byte* dest, byte* src, int size) {} // 0x000000018232FC70-0x000000018232FD00
		internal static unsafe void memcpy2(byte* dest, byte* src, int size) {} // 0x0000000182330FB0-0x0000000182331030
		private static unsafe void memcpy1(byte* dest, byte* src, int size) {} // 0x0000000182DD3240-0x0000000182DD32E0
		internal static unsafe void Memcpy(byte* dest, byte* src, int len, bool useICall = true /* Metadata: 0x01F9E444 */) {} // 0x000000018232F9D0-0x000000018232FC70
		internal static unsafe void Memmove(byte* dest, byte* src, uint len) {} // 0x000000018232F700-0x000000018232F9D0
		internal static void Memmove<T>(ref ref T destination, ref ref T source, ulong elementCount) {}
	}

	[Serializable]
	[ComVisible(true)]
	public abstract class ContextBoundObject : MarshalByRefObject // TypeDefIndex: 38919
	{
		// Constructors
		protected ContextBoundObject() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	[ComVisible(true)]
	public class ContextStaticAttribute : Attribute // TypeDefIndex: 38920
	{
		// Constructors
		public ContextStaticAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	internal class DefaultBinder : Binder // TypeDefIndex: 38924
	{
		// Fields
		private static Primitives[] _primitiveConversions; // 0x00
	
		// Nested types
		internal class BinderState // TypeDefIndex: 38921
		{
			// Fields
			internal int[] m_argsMap; // 0x10
			internal int m_originalSize; // 0x18
			internal bool m_isParamArray; // 0x1C
	
			// Constructors
			public BinderState() {} // Dummy constructor
			internal BinderState(int[] argsMap, int originalSize, bool isParamArray) {} // 0x00000001860833CC-0x00000001860833F0
		}
	
		[Flags]
		private enum Primitives // TypeDefIndex: 38922
		{
			Boolean = 8,
			Char = 16,
			SByte = 32,
			Byte = 64,
			Int16 = 128,
			UInt16 = 256,
			Int32 = 512,
			UInt32 = 1024,
			Int64 = 2048,
			UInt64 = 4096,
			Single = 8192,
			Double = 16384,
			Decimal = 32768,
			DateTime = 65536,
			String = 262144
		}
	
		// Constructors
		public DefaultBinder() {} // 0x000000018350B670-0x000000018350B680
		static DefaultBinder() {} // 0x0000000183CE4B40-0x0000000183CE4BD0
	
		// Methods
		public override MethodBase BindToMethod(System.Reflection.BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, string[] names, out object state) {
			state = default;
			return default;
		} // 0x00000001826B1750-0x00000001826B2000
		public override System.Reflection.FieldInfo BindToField(System.Reflection.BindingFlags bindingAttr, System.Reflection.FieldInfo[] match, object value, CultureInfo cultureInfo) => default; // 0x0000000189265C04-0x0000000189265FC4
		public override PropertyInfo SelectProperty(System.Reflection.BindingFlags bindingAttr, PropertyInfo[] match, System.Type returnType, System.Type[] indexes, ParameterModifier[] modifiers) => default; // 0x0000000189267968-0x00000001892681E0
		public override object ChangeType(object value, System.Type type, CultureInfo cultureInfo) => default; // 0x0000000189266388-0x00000001892663EC
		public override void ReorderArgumentArray(ref object[] args, object state) {} // 0x000000018926761C-0x0000000189267870
		public static MethodBase ExactBinding(MethodBase[] match, System.Type[] types, ParameterModifier[] modifiers) => default; // 0x0000000189266770-0x000000018926696C
		public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, System.Type returnType, System.Type[] types, ParameterModifier[] modifiers) => default; // 0x000000018926696C-0x0000000189266B8C
		private static int FindMostSpecific(ParameterInfo[] p1, int[] paramOrder1, System.Type paramArrayType1, ParameterInfo[] p2, int[] paramOrder2, System.Type paramArrayType2, System.Type[] types, object[] args) => default; // 0x0000000189267264-0x00000001892675B4
		private static int FindMostSpecificType(System.Type c1, System.Type c2, System.Type t) => default; // 0x0000000189266FD8-0x0000000189267264
		private static int FindMostSpecificMethod(MethodBase m1, int[] paramOrder1, System.Type paramArrayType1, MethodBase m2, int[] paramOrder2, System.Type paramArrayType2, System.Type[] types, object[] args) => default; // 0x0000000189266D94-0x0000000189266EF4
		private static int FindMostSpecificField(System.Reflection.FieldInfo cur1, System.Reflection.FieldInfo cur2) => default; // 0x0000000189266CB0-0x0000000189266D94
		private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) => default; // 0x0000000189266EF4-0x0000000189266FD8
		internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) => default; // 0x00000001892663EC-0x00000001892664E4
		internal static int GetHierarchyDepth(System.Type t) => default; // 0x00000001892675B4-0x000000018926761C
		internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) => default; // 0x0000000189266B8C-0x0000000189266CB0
		private static void ReorderParams(int[] paramOrder, object[] vars) {} // 0x0000000189267870-0x0000000189267968
		private static bool CreateParamOrder(int[] paramOrder, ParameterInfo[] pars, string[] names) => default; // 0x00000001892665DC-0x0000000189266770
		private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) => default; // 0x00000001892660C0-0x00000001892662C4
		private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) => default; // 0x0000000189266020-0x00000001892660C0
		internal static bool CompareMethodSig(MethodBase m1, MethodBase m2) => default; // 0x00000001892664E4-0x00000001892665DC
		public sealed override MethodBase SelectMethod(System.Reflection.BindingFlags bindingAttr, MethodBase[] match, System.Type[] types, ParameterModifier[] modifiers) => default; // 0x0000000183162510-0x0000000183162880
		private static bool CanChangePrimitive(System.Type source, System.Type target) => default; // 0x0000000189265FC4-0x0000000189266020
		private static bool CanPrimitiveWiden(System.Type source, System.Type target) => default; // 0x00000001892662C4-0x0000000189266388
	}

	[Serializable]
	internal sealed class Empty : ISerializable // TypeDefIndex: 38925
	{
		// Fields
		public static readonly Empty Value; // 0x00
	
		// Constructors
		private Empty() {} // 0x000000018350B670-0x000000018350B680
		static Empty() {} // 0x0000000189268298-0x00000001892682FC
	
		// Methods
		public override string ToString() => default; // 0x0000000189268260-0x0000000189268298
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001892681E0-0x0000000189268260
	}

	[Serializable]
	[ComVisible(true)]
	public abstract struct Enum : IComparable, IFormattable, IConvertible // TypeDefIndex: 38929
	{
		// Fields
		private static readonly char[] enumSeperatorCharArray; // 0x00
		private const string enumSeperator = ", "; // Metadata: 0x01F9E46A
	
		// Nested types
		private enum ParseFailureKind // TypeDefIndex: 38926
		{
			None = 0,
			Argument = 1,
			ArgumentNull = 2,
			ArgumentWithParameter = 3,
			UnhandledException = 4
		}
	
		private struct EnumResult // TypeDefIndex: 38927
		{
			// Fields
			internal object parsedEnum; // 0x00
			internal bool canThrow; // 0x08
			internal System.Enum.ParseFailureKind m_failure; // 0x0C
			internal string m_failureMessageID; // 0x10
			internal string m_failureParameter; // 0x18
			internal object m_failureMessageFormatArgument; // 0x20
			internal Exception m_innerException; // 0x28
	
			// Methods
			internal void Init(bool canMethodThrow) {} // 0x0000000182610430-0x00000001826104A0
			internal void SetFailure(Exception unhandledException) {} // 0x000000018926843C-0x0000000189268450
			internal void SetFailure(System.Enum.ParseFailureKind failure, string failureParameter) {} // 0x0000000189268450-0x000000018926849C
			internal void SetFailure(System.Enum.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) {} // 0x000000018926849C-0x00000001892684F4
			internal Exception GetEnumParseException() => default; // 0x00000001892682FC-0x000000018926843C
		}
	
		private class ValuesAndNames // TypeDefIndex: 38928
		{
			// Fields
			public ulong[] Values; // 0x10
			public string[] Names; // 0x18
	
			// Constructors
			public ValuesAndNames() {} // Dummy constructor
			public ValuesAndNames(ulong[] values, string[] names) {} // 0x0000000182676770-0x00000001826767A0
		}
	
		// Constructors
		protected Enum() {
	
		} // 0x000000018350B670-0x000000018350B680
		static Enum() {
			enumSeperatorCharArray = default;
		} // 0x0000000183CEF5C0-0x0000000183CEF650
	
		// Methods
		private static ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames) => default; // 0x00000001825F9EF0-0x00000001825FA060
		private static string InternalFormattedHexString(object value) => default; // 0x0000000189268CF4-0x0000000189268FAC
		private static string InternalFormat(RuntimeType eT, object value) => default; // 0x00000001825F9A40-0x00000001825F9BB0
		private static string InternalFlagsFormat(RuntimeType eT, object value) => default; // 0x00000001834B76C0-0x00000001834B7890
		internal static ulong ToUInt64(object value) => default; // 0x00000001825FA060-0x00000001825FA1D0
		private static int InternalCompareTo(object o1, object o2) => default; // 0x0000000184275DFC-0x0000000184275E04
		internal static RuntimeType InternalGetUnderlyingType(RuntimeType enumType) => default; // 0x0000000184273B08-0x0000000184273B10
		private static bool GetEnumValuesAndNames(RuntimeType enumType, out ulong[] values, out string[] names) {
			values = default;
			names = default;
			return default;
		} // 0x0000000189268B5C-0x0000000189268B64
		private static object InternalBoxEnum(RuntimeType enumType, long value) => default; // 0x0000000184270288-0x0000000184270290
		public static bool TryParse<TEnum>(string value, out ref TEnum result)
			where TEnum : struct {
			result = default;
			return default;
		}
		public static bool TryParse<TEnum>(string value, bool ignoreCase, out ref TEnum result)
			where TEnum : struct {
			result = default;
			return default;
		}
		[ComVisible(true)]
		public static object Parse(System.Type enumType, string value) => default; // 0x00000001826102C0-0x0000000182610320
		[ComVisible(true)]
		public static object Parse(System.Type enumType, string value, bool ignoreCase) => default; // 0x0000000182610320-0x0000000182610430
		private static bool TryParseEnum(System.Type enumType, string value, bool ignoreCase, ref EnumResult parseResult) => default; // 0x000000018232CE40-0x000000018232D260
		[ComVisible(true)]
		public static System.Type GetUnderlyingType(System.Type enumType) => default; // 0x0000000182477260-0x00000001824772C0
		[ComVisible(true)]
		public static Array GetValues(System.Type enumType) => default; // 0x00000001825F8F80-0x00000001825F8FE0
		internal static ulong[] InternalGetValues(RuntimeType enumType) => default; // 0x00000001825F9E90-0x00000001825F9EF0
		[ComVisible(true)]
		public static string GetName(System.Type enumType, object value) => default; // 0x00000001825F9BB0-0x00000001825F9C30
		[ComVisible(true)]
		public static string[] GetNames(System.Type enumType) => default; // 0x00000001826AA5C0-0x00000001826AA620
		internal static string[] InternalGetNames(RuntimeType enumType) => default; // 0x00000001825F9E30-0x00000001825F9E90
		[ComVisible(true)]
		public static object ToObject(System.Type enumType, object value) => default; // 0x00000001824DF0A0-0x00000001824DF340
		[ComVisible(true)]
		public static bool IsDefined(System.Type enumType, object value) => default; // 0x0000000182527F40-0x0000000182527FB0
		[ComVisible(true)]
		public static string Format(System.Type enumType, object value, string format) => default; // 0x00000001892684F4-0x0000000189268B5C
		private object get_value() => default; // 0x0000000184270A50-0x0000000184270A58
		internal object GetValue() => default; // 0x0000000184270A50-0x0000000184270A58
		private bool InternalHasFlag(Enum flags) => default; // 0x0000000189268FAC-0x0000000189268FB4
		private int get_hashcode() => default; // 0x00000001833BECE0-0x00000001833BECF0
		public override bool Equals(object obj) => default; // 0x0000000182D52F30-0x0000000182D52F40
		public override int GetHashCode() => default; // 0x00000001833BECE0-0x00000001833BECF0
		public override string ToString() => default; // 0x00000001825F9980-0x00000001825F9A40
		[Obsolete("The provider argument is not used. Please use ToString(String).")]
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000184276418-0x0000000184276420
		public int CompareTo(object target) => default; // 0x00000001831FD810-0x0000000183206E10
		public string ToString(string format) => default; // 0x0000000182360ED0-0x0000000182360F90
		[Obsolete("The provider argument is not used. Please use ToString().")]
		public string ToString(IFormatProvider provider) => default; // 0x00000001892147CC-0x00000001892147DC
		public bool HasFlag(Enum flag) => default; // 0x0000000189268B64-0x0000000189268CF4
		public TypeCode GetTypeCode() => default; // 0x0000000183893AB0-0x0000000183893BF0
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000189268FB4-0x0000000189269030
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x00000001892690AC-0x0000000189269128
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000189269318-0x0000000189269394
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000189269030-0x00000001892690AC
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x000000018926929C-0x0000000189269318
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000189269470-0x00000001892694EC
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x00000001825F8FE0-0x00000001825F9080
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x00000001892694EC-0x0000000189269568
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x00000001839C5150-0x00000001839C51F0
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000189269568-0x00000001892695E4
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000189269394-0x0000000189269410
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000189269220-0x000000018926929C
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x00000001833874D0-0x0000000183387590
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000189269128-0x0000000189269220
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x0000000189269410-0x0000000189269470
		[CLSCompliant(false)]
		[ComVisible(true)]
		public static object ToObject(System.Type enumType, sbyte value) => default; // 0x000000018926A0AC-0x000000018926A278
		[ComVisible(true)]
		public static object ToObject(System.Type enumType, short value) => default; // 0x00000001892695E4-0x00000001892697B0
		[ComVisible(true)]
		public static object ToObject(System.Type enumType, int value) => default; // 0x00000001836C9890-0x00000001836C99B0
		[ComVisible(true)]
		public static object ToObject(System.Type enumType, byte value) => default; // 0x0000000189269B48-0x0000000189269D14
		[CLSCompliant(false)]
		[ComVisible(true)]
		public static object ToObject(System.Type enumType, ushort value) => default; // 0x0000000189269D14-0x0000000189269EE0
		[CLSCompliant(false)]
		[ComVisible(true)]
		public static object ToObject(System.Type enumType, uint value) => default; // 0x0000000189269EE0-0x000000018926A0AC
		[ComVisible(true)]
		public static object ToObject(System.Type enumType, long value) => default; // 0x00000001824DF340-0x00000001824DF450
		[CLSCompliant(false)]
		[ComVisible(true)]
		public static object ToObject(System.Type enumType, ulong value) => default; // 0x0000000182612D00-0x0000000182612E10
		private static object ToObject(System.Type enumType, char value) => default; // 0x000000018926997C-0x0000000189269B48
		private static object ToObject(System.Type enumType, bool value) => default; // 0x00000001892697B0-0x000000018926997C
		public static TEnum Parse<TEnum>(string value)
			where TEnum : struct => default;
		public static TEnum Parse<TEnum>(string value, bool ignoreCase)
			where TEnum : struct => default;
		public static bool TryParse(System.Type enumType, string value, bool ignoreCase, out object result) {
			result = default;
			return default;
		} // 0x000000018926A2E0-0x000000018926A39C
		public static bool TryParse(System.Type enumType, string value, out object result) {
			result = default;
			return default;
		} // 0x000000018926A278-0x000000018926A2E0
	}

	[Serializable]
	[ComVisible(true)]
	public class Exception : ISerializable // TypeDefIndex: 38931
	{
		// Fields
		[OptionalField]
		private static object s_EDILock; // 0x00
		private string _className; // 0x10
		internal string _message; // 0x18
		private IDictionary _data; // 0x20
		private Exception _innerException; // 0x28
		private string _helpURL; // 0x30
		private object _stackTrace; // 0x38
		private string _stackTraceString; // 0x40
		private string _remoteStackTraceString; // 0x48
		private int _remoteStackIndex; // 0x50
		private object _dynamicMethods; // 0x58
		internal int _HResult; // 0x60
		private string _source; // 0x68
		[OptionalField(VersionAdded = 4)]
		private SafeSerializationManager _safeSerializationManager; // 0x70
		internal StackTrace[] captured_traces; // 0x78
		private IntPtr[] native_trace_ips; // 0x80
		private int caught_in_unmanaged; // 0x88
		private const int _COMPlusExceptionCode = -532462766; // Metadata: 0x01F9E472
	
		// Properties
		public virtual string Message { get => default; } // 0x000000018926B150-0x000000018926B208 
		public virtual IDictionary Data { get => default; } // 0x000000018926B0F4-0x000000018926B150 
		public Exception InnerException { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public MethodBase TargetSite { get => default; } // 0x000000018926B304-0x000000018926B38C 
		public virtual string StackTrace { get => default; } // 0x000000018926B2F8-0x000000018926B304 
		public virtual string Source { get => default; } // 0x000000018926B208-0x000000018926B2F8 
		public int HResult { get => default; protected set {} } // 0x0000000183D4F050-0x0000000183D4F060 0x0000000183D4F5A0-0x0000000183D4F5B0
	
		// Nested types
		internal enum ExceptionMessageKind // TypeDefIndex: 38930
		{
			ThreadAbort = 1,
			ThreadInterrupted = 2,
			OutOfMemory = 3
		}
	
		// Constructors
		public Exception() {} // 0x000000018926ACB8-0x000000018926ACC0
		public Exception(string message) {} // 0x00000001829444A0-0x00000001829444D0
		public Exception(string message, Exception innerException) {} // 0x000000018926B0AC-0x000000018926B0F4
		protected Exception(SerializationInfo info, StreamingContext context) {} // 0x000000018926ACC0-0x000000018926B0AC
		static Exception() {} // 0x0000000183D000A0-0x0000000183D00110
	
		// Methods
		private void Init() {} // 0x00000001829444D0-0x0000000182944560
		private string GetClassName() => default; // 0x000000018926A498-0x000000018926A4E0
		public virtual Exception GetBaseException() => default; // 0x000000018926A47C-0x000000018926A498
		private string GetStackTrace(bool needFileInfo) => default; // 0x000000018926A984-0x000000018926A9C8
		internal void SetErrorCode(int hr) {} // 0x0000000183D4F5A0-0x0000000183D4F5B0
		public override string ToString() => default; // 0x000000018926ACA8-0x000000018926ACB8
		private string ToString(bool needFileLineInfo, bool needMessage) => default; // 0x000000018926AAD4-0x000000018926ACA8
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x000000018926A564-0x000000018926A984
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context) {} // 0x000000018926A9C8-0x000000018926AA40
		private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) => default; // 0x0000000183D51810-0x0000000183D51820
		internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) {} // 0x000000018926AA48-0x000000018926AAD4
		public new System.Type GetType() => default; // 0x000000018426F82C-0x000000018426F838
		internal static string GetMessageFromNativeResources(ExceptionMessageKind kind) => default; // 0x000000018926A4E0-0x000000018926A564
		internal Exception FixRemotingException() => default; // 0x000000018926A39C-0x000000018926A47C
		internal static void ReportUnhandledException(Exception exception) {} // 0x000000018926AA40-0x000000018926AA48
	}

	public static class GC // TypeDefIndex: 38932
	{
		// Fields
		internal static readonly object EPHEMERON_TOMBSTONE; // 0x00
	
		// Properties
		public static int MaxGeneration { get; } // 0x00000001832CFB80-0x00000001832CFBC0 
	
		// Constructors
		static GC() {} // 0x0000000183D26CB0-0x0000000183D26D10
	
		// Methods
		private static int GetCollectionCount(int generation) => default; // 0x0000000183D70D50-0x0000000183D70D60
		private static int GetMaxGeneration() => default; // 0x0000000181002730-0x0000000181002740
		private static void InternalCollect(int generation) {} // 0x000000018427602C-0x0000000184276034
		private static void RecordPressure(long bytesAllocated) {} // 0x000000018350B670-0x000000018350B680
		internal static void register_ephemeron_array(Ephemeron[] array) {} // 0x0000000184276350-0x0000000184276358
		private static object get_ephemeron_tombstone() => default; // 0x00000001842771A0-0x00000001842771B4
		internal static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out UIntPtr lastRecordedHeapSize, out UIntPtr lastRecordedFragmentation) {
			highMemLoadThreshold = default;
			totalPhysicalMem = default;
			lastRecordedMemLoad = default;
			lastRecordedHeapSize = default;
			lastRecordedFragmentation = default;
		} // 0x0000000183D70D60-0x0000000183D70D80
		public static void AddMemoryPressure(long bytesAllocated) {} // 0x000000018926B38C-0x000000018926B438
		public static void RemoveMemoryPressure(long bytesAllocated) {} // 0x000000018926B458-0x000000018926B504
		public static void Collect() {} // 0x00000001832CFB30-0x00000001832CFB80
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int CollectionCount(int generation) => default; // 0x00000001837D11D0-0x00000001837D1220
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void KeepAlive(object obj) {} // 0x000000018350B670-0x000000018350B680
		public static void WaitForPendingFinalizers() {} // 0x000000018926B504-0x000000018926B50C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		private static void _SuppressFinalize(object o) {} // 0x000000018426FEF0-0x000000018426FEF8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void SuppressFinalize(object obj) {} // 0x0000000182460AB0-0x0000000182460B10
		private static void _ReRegisterForFinalize(object o) {} // 0x0000000184273098-0x00000001842730A0
		public static void ReRegisterForFinalize(object obj) {} // 0x0000000182CB3230-0x0000000182CB3290
		public static long GetTotalMemory(bool forceFullCollection) => default; // 0x000000018926B438-0x000000018926B458
	}

	internal enum TypeNameFormatFlags // TypeDefIndex: 38933
	{
		FormatBasic = 0,
		FormatNamespace = 1,
		FormatFullInst = 2,
		FormatAssembly = 4,
		FormatSignature = 8,
		FormatNoVersion = 16,
		FormatAngleBrackets = 64,
		FormatStubInfo = 128,
		FormatGenericParam = 256,
		FormatSerialization = 259
	}

	internal enum TypeNameKind // TypeDefIndex: 38934
	{
		Name = 0,
		ToString = 1,
		SerializationName = 2,
		FullName = 3
	}

	[Serializable]
	internal class RuntimeType : System.Reflection.TypeInfo, ISerializable, ICloneable // TypeDefIndex: 38937
	{
		// Fields
		internal static readonly RuntimeType ValueType; // 0x00
		internal static readonly RuntimeType EnumType; // 0x08
		private static readonly RuntimeType ObjectType; // 0x10
		private static readonly RuntimeType StringType; // 0x18
		private static readonly RuntimeType DelegateType; // 0x20
		private static System.Type[] s_SICtorParamTypes; // 0x28
		internal static Func<System.Type, System.Type[], System.Type> MakeTypeBuilderInstantiation; // 0x30
		private const System.Reflection.BindingFlags MemberBindingMask = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.DeclaredOnly | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.FlattenHierarchy; // Metadata: 0x01F9E48C
		private const System.Reflection.BindingFlags InvocationMask = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.CreateInstance | System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.SetField | System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.PutDispProperty | System.Reflection.BindingFlags.PutRefDispProperty; // Metadata: 0x01F9E48E
		private const System.Reflection.BindingFlags BinderNonCreateInstance = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.SetField | System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.SetProperty; // Metadata: 0x01F9E492
		private const System.Reflection.BindingFlags BinderGetSetProperty = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.SetProperty; // Metadata: 0x01F9E496
		private const System.Reflection.BindingFlags BinderSetInvokeProperty = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.SetProperty; // Metadata: 0x01F9E49A
		private const System.Reflection.BindingFlags BinderGetSetField = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.SetField; // Metadata: 0x01F9E49E
		private const System.Reflection.BindingFlags BinderSetInvokeField = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.SetField; // Metadata: 0x01F9E4A0
		private const System.Reflection.BindingFlags BinderNonFieldGetSet = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.CreateInstance | System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.PutDispProperty | System.Reflection.BindingFlags.PutRefDispProperty | System.Reflection.BindingFlags.ExactBinding | System.Reflection.BindingFlags.SuppressChangeType | System.Reflection.BindingFlags.OptionalParamBinding; // Metadata: 0x01F9E4A2
		private const System.Reflection.BindingFlags ClassicBindingMask = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.PutDispProperty | System.Reflection.BindingFlags.PutRefDispProperty; // Metadata: 0x01F9E4A6
		private static RuntimeType s_typedRef; // 0x38
		[NonSerialized]
		private MonoTypeInfo type_info; // 0x18
		internal object GenericCache; // 0x20
		private RuntimeConstructorInfo m_serializationCtor; // 0x28
		private const int GenericParameterCountAny = -1; // Metadata: 0x01F9E4AA
	
		// Properties
		public override Module Module { get => default; } // 0x000000018926D538-0x000000018926D540 
		public override Assembly Assembly { get => default; } // 0x0000000183D70E40-0x0000000183D70FA0 
		public override RuntimeTypeHandle TypeHandle { get => default; } // 0x000000018359AFF0-0x000000018359B010 
		public override System.Type BaseType { get => default; } // 0x00000001824DF5D0-0x00000001824DF670 
		public override System.Type UnderlyingSystemType { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		public override bool IsEnum { get => default; } // 0x00000001824DF670-0x00000001824DFCA0 
		public override GenericParameterAttributes GenericParameterAttributes { get => default; } // 0x000000018926F5B8-0x000000018926F644 
		internal override bool IsSzArray { get => default; } // 0x000000018926F750-0x000000018926F764 
		public override bool IsGenericTypeDefinition { get => default; } // 0x0000000183405760-0x0000000183405770 
		public override bool IsGenericParameter { get => default; } // 0x00000001822A7F50-0x00000001822A7F70 
		public override int GenericParameterPosition { get => default; } // 0x000000018926F644-0x000000018926F6CC 
		public override bool IsGenericType { get => default; } // 0x0000000183D70FA0-0x0000000183D70FE0 
		public override bool IsConstructedGenericType { get => default; } // 0x000000018926F6D4-0x000000018926F708 
		public override MemberTypes MemberType { get => default; } // 0x0000000182F6DEE0-0x0000000182F6DF30 
		public override System.Type ReflectedType { get => default; } // 0x0000000183527600-0x0000000183527610 
		public override int MetadataToken { get => default; } // 0x000000018926F76C-0x000000018926F780 
		public override StructLayoutAttribute StructLayoutAttribute { get => default; } // 0x000000018926F780-0x000000018926F788 
		public override bool ContainsGenericParameters { get => default; } // 0x00000001822A81E0-0x00000001822A8460 
		public override Guid GUID { get => default; } // 0x000000018926F528-0x000000018926F5B8 
		public override MethodBase DeclaringMethod { get => default; } // 0x0000000183D6F710-0x0000000183D6F720 
		public override string AssemblyQualifiedName { get => default; } // 0x0000000182E67980-0x0000000182E67990 
		public override System.Type DeclaringType { get => default; } // 0x00000001833DACC0-0x00000001833DACD0 
		public override string Name { get => default; } // 0x00000001822C5210-0x00000001822C5220 
		public override string Namespace { get => default; } // 0x00000001822C5200-0x00000001822C5210 
		public override string FullName { get => default; } // 0x0000000182E67A20-0x0000000182E67BC0 
		public override bool IsSZArray { get => default; } // 0x000000018926F708-0x000000018926F750 
		internal override bool IsUserType { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool IsByRefLike { get => default; } // 0x000000018926F6CC-0x000000018926F6D4 
		public override bool IsTypeDefinition { get => default; } // 0x000000018926F764-0x000000018926F76C 
	
		// Nested types
		internal enum MemberListType // TypeDefIndex: 38935
		{
			All = 0,
			CaseSensitive = 1,
			CaseInsensitive = 2,
			HandleToInfo = 3
		}
	
		private struct ListBuilder<T> // TypeDefIndex: 38936
			where T : class
		{
			// Fields
			private T[] _items;
			private T _item;
			private int _count;
			private int _capacity;
	
			// Properties
			public T this[int index] { get => default; }
			public int Count { get => default; }
	
			// Constructors
			public ListBuilder(int capacity) : this() {
				_items = default;
				_item = default;
				_count = default;
				_capacity = default;
			}
	
			// Methods
			public T[] ToArray() => default;
			public void CopyTo(object[] array, int index) {}
			public void Add(T item) {}
		}
	
		// Constructors
		internal RuntimeType() {} // 0x000000018926F4D4-0x000000018926F528
		static RuntimeType() {} // 0x000000018398A1C0-0x000000018398A460
	
		// Methods
		internal static RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark) => default; // 0x00000001835FFE60-0x00000001835FFE90
		private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) {} // 0x0000000182612FB0-0x0000000182613110
		internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) {} // 0x0000000182612A00-0x0000000182612B30
		private static void SplitName(string fullname, out string name, out string ns) {
			name = default;
			ns = default;
		} // 0x0000000182E524F0-0x0000000182E52570
		internal static System.Reflection.BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic) => default; // 0x00000001833DD830-0x00000001833DD860
		private static void FilterHelper(System.Reflection.BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out MemberListType listType) {
			prefixLookup = default;
			ignoreCase = default;
			listType = default;
		} // 0x00000001826B59B0-0x00000001826B5AD0
		private static void FilterHelper(System.Reflection.BindingFlags bindingFlags, ref string name, out bool ignoreCase, out MemberListType listType) {
			ignoreCase = default;
			listType = default;
		} // 0x00000001826BB1C0-0x00000001826BB2D0
		private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) => default; // 0x000000018926C6D0-0x000000018926C740
		private static bool FilterApplyBase(MemberInfo memberInfo, System.Reflection.BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) => default; // 0x0000000182E526F0-0x0000000182E52820
		private static bool FilterApplyType(System.Type type, System.Reflection.BindingFlags bindingFlags, string name, bool prefixLookup, string ns) => default; // 0x0000000182E52570-0x0000000182E52690
		private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, System.Reflection.BindingFlags bindingFlags, CallingConventions callConv, System.Type[] argumentTypes) => default; // 0x00000001826B3DD0-0x00000001826B3E70
		private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, System.Reflection.BindingFlags bindingFlags, CallingConventions callConv, System.Type[] argumentTypes) => default; // 0x00000001826B3A40-0x00000001826B3AE0
		private static bool FilterApplyMethodBase(MethodBase methodBase, System.Reflection.BindingFlags methodFlags, System.Reflection.BindingFlags bindingFlags, CallingConventions callConv, System.Type[] argumentTypes) => default; // 0x00000001826B3E70-0x00000001826B3F30
		private ListBuilder<MethodInfo> GetMethodCandidates(string name, System.Reflection.BindingFlags bindingAttr, CallingConventions callConv, System.Type[] types, int genericParamCount, bool allowPrefixLookup) => default; // 0x00000001826B3AE0-0x00000001826B3DD0
		private ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, System.Reflection.BindingFlags bindingAttr, CallingConventions callConv, System.Type[] types, bool allowPrefixLookup) => default; // 0x00000001826B4B20-0x00000001826B59B0
		private ListBuilder<PropertyInfo> GetPropertyCandidates(string name, System.Reflection.BindingFlags bindingAttr, System.Type[] types, bool allowPrefixLookup) => default; // 0x00000001826B8030-0x00000001826B8730
		private ListBuilder<EventInfo> GetEventCandidates(string name, System.Reflection.BindingFlags bindingAttr, bool allowPrefixLookup) => default; // 0x0000000182E51520-0x0000000182E51700
		private ListBuilder<System.Reflection.FieldInfo> GetFieldCandidates(string name, System.Reflection.BindingFlags bindingAttr, bool allowPrefixLookup) => default; // 0x00000001826B9960-0x00000001826BA030
		private ListBuilder<System.Type> GetNestedTypeCandidates(string fullname, System.Reflection.BindingFlags bindingAttr, bool allowPrefixLookup) => default; // 0x0000000182E51EA0-0x0000000182E520F0
		public override MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr) => default; // 0x00000001826B2180-0x00000001826B2230
		[ComVisible(true)]
		public override ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr) => default; // 0x00000001826B47A0-0x00000001826B4B20
		public override PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr) => default; // 0x00000001830CAF20-0x00000001830CB080
		public override EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr) => default; // 0x0000000182E51320-0x0000000182E51520
		public override System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr) => default; // 0x00000001826BB2D0-0x00000001826BB360
		public override System.Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr) => default; // 0x0000000182E51E10-0x0000000182E51EA0
		public override MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) => default; // 0x0000000182E50C10-0x0000000182E50F00
		protected override ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, System.Type[] types, ParameterModifier[] modifiers) => default; // 0x0000000183162340-0x0000000183162510
		protected override PropertyInfo GetPropertyImpl(string name, System.Reflection.BindingFlags bindingAttr, Binder binder, System.Type returnType, System.Type[] types, ParameterModifier[] modifiers) => default; // 0x00000001826B8C40-0x00000001826B9480
		public override EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr) => default; // 0x0000000182E511D0-0x0000000182E51320
		public override System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) => default; // 0x00000001826BAFD0-0x00000001826BB1C0
		public override System.Type GetInterface(string fullname, bool ignoreCase) => default; // 0x000000018926CF70-0x000000018926D250
		public override System.Type GetNestedType(string fullname, System.Reflection.BindingFlags bindingAttr) => default; // 0x000000018926D2C8-0x000000018926D4B0
		public override MemberInfo[] GetMember(string name, MemberTypes type, System.Reflection.BindingFlags bindingAttr) => default; // 0x00000001826BA030-0x00000001826BAC60
		internal RuntimeModule GetRuntimeModule() => default; // 0x000000018926D538-0x000000018926D540
		internal RuntimeAssembly GetRuntimeAssembly() => default; // 0x000000018926D530-0x000000018926D538
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal sealed override RuntimeTypeHandle GetTypeHandleInternal() => default; // 0x00000001842C39D0-0x00000001842C39E8
		public override bool IsInstanceOfType(object o) => default; // 0x0000000183D70DC0-0x0000000183D70E40
		public override bool IsAssignableFrom(System.Reflection.TypeInfo typeInfo) => default; // 0x000000018926EB50-0x000000018926EBAC
		public override bool IsAssignableFrom(System.Type c) => default; // 0x00000001823289D0-0x0000000182329450
		public override bool IsEquivalentTo(System.Type other) => default; // 0x000000018303E880-0x000000018303E900
		private RuntimeType GetBaseType() => default; // 0x00000001824DFCA0-0x00000001824E00E0
		protected override TypeAttributes GetAttributeFlagsImpl() => default; // 0x0000000183D70D90-0x0000000183D70DC0
		protected override bool IsContextfulImpl() => default; // 0x000000018926EBAC-0x000000018926EBB4
		protected override bool IsByRefImpl() => default; // 0x00000001829CA390-0x00000001829CA3B0
		protected override bool IsPrimitiveImpl() => default; // 0x00000001829CA3B0-0x00000001829CA3E0
		protected override bool IsPointerImpl() => default; // 0x00000001829CA370-0x00000001829CA390
		protected override bool IsCOMObjectImpl() => default; // 0x0000000183D4E3A0-0x0000000183D4E3B0
		internal override bool HasProxyAttributeImpl() => default; // 0x000000018926D774-0x000000018926D780
		protected override bool IsValueTypeImpl() => default; // 0x0000000182416660-0x0000000182417340
		protected override bool HasElementTypeImpl() => default; // 0x00000001829CA3E0-0x00000001829CA410
		protected override bool IsArrayImpl() => default; // 0x00000001829CA330-0x00000001829CA350
		public override int GetArrayRank() => default; // 0x0000000183CA47F0-0x0000000183CA4820
		public override System.Type GetElementType() => default; // 0x000000018332E270-0x000000018332E280
		public override string[] GetEnumNames() => default; // 0x000000018352BA50-0x000000018352BB70
		public override Array GetEnumValues() => default; // 0x0000000182612B30-0x0000000182612D00
		public override System.Type GetEnumUnderlyingType() => default; // 0x0000000182DCF6D0-0x0000000182DCFB00
		public override bool IsEnumDefined(object value) => default; // 0x0000000182DCF4B0-0x0000000182DCF6D0
		public override string GetEnumName(object value) => default; // 0x00000001825F9C30-0x00000001825F9E30
		internal RuntimeType[] GetGenericArgumentsInternal() => default; // 0x00000001823020D0-0x0000000182302170
		public override System.Type[] GetGenericArguments() => default; // 0x0000000182302170-0x00000001823024E0
		public override System.Type MakeGenericType(params System.Type[] instantiation) => default; // 0x0000000182301E70-0x00000001823020D0
		public override System.Type GetGenericTypeDefinition() => default; // 0x0000000183181D10-0x0000000183181D40
		public override MemberInfo[] GetDefaultMembers() => default; // 0x000000018926CA68-0x000000018926CAC4
		[DebuggerHidden]
		[DebuggerStepThrough]
		public override object InvokeMember(string name, System.Reflection.BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) => default; // 0x000000018926D780-0x000000018926EB50
		public override bool Equals(object obj) => default; // 0x0000000183D70D80-0x0000000183D70D90
		public static bool operator ==(RuntimeType left, RuntimeType right) => default; // 0x000000018232CE30-0x000000018232CE40
		public static bool operator !=(RuntimeType left, RuntimeType right) => default; // 0x00000001822E54C0-0x00000001822E54D0
		public object Clone() => default; // 0x000000018339AE90-0x000000018339AEA0
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x000000018926D4B0-0x000000018926D528
		public override object[] GetCustomAttributes(bool inherit) => default; // 0x0000000183108DA0-0x0000000183108E50
		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) => default; // 0x0000000182D998A0-0x0000000182D99980
		public override bool IsDefined(System.Type attributeType, bool inherit) => default; // 0x0000000182B2B750-0x0000000182B2B830
		internal override string FormatTypeName(bool serialization) => default; // 0x000000018926C740-0x000000018926C880
		private void CreateInstanceCheckThis() {} // 0x000000018247A540-0x000000018247A700
		internal object CreateInstanceImpl(System.Reflection.BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) => default; // 0x00000001825E4120-0x00000001825E4640
		[DebuggerHidden]
		[DebuggerStepThrough]
		internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, bool wrapExceptions, ref StackCrawlMark stackMark) => default; // 0x000000018247A8D0-0x000000018247AB90
		internal RuntimeConstructorInfo GetDefaultConstructor() => default; // 0x000000018247B920-0x000000018247BE70
		private MethodInfo GetCorrespondingInflatedMethod(MethodInfo generic) => default; // 0x000000018926C99C-0x000000018926C9A8
		private ConstructorInfo GetCorrespondingInflatedConstructor(ConstructorInfo generic) => default; // 0x000000018926C990-0x000000018926C99C
		internal override MethodInfo GetMethod(MethodInfo fromNoninstanciated) => default; // 0x000000018926D260-0x000000018926D2C8
		internal override ConstructorInfo GetConstructor(ConstructorInfo fromNoninstanciated) => default; // 0x000000018926C8E4-0x000000018926C990
		internal override System.Reflection.FieldInfo GetField(System.Reflection.FieldInfo fromNoninstanciated) => default; // 0x000000018926CAC4-0x000000018926CB48
		private string GetDefaultMemberName() => default; // 0x000000018926C9A8-0x000000018926CA68
		internal RuntimeConstructorInfo GetSerializationCtor() => default; // 0x000000018926D540-0x000000018926D6BC
		internal object CreateInstanceSlow(bool publicOnly, bool wrapExceptions, bool skipCheckThis, bool fillCache) => default; // 0x000000018247AB90-0x000000018247AD90
		private object CreateInstanceMono(bool nonPublic, bool wrapExceptions) => default; // 0x000000018247AD90-0x000000018247B920
		internal object CheckValue(object value, Binder binder, CultureInfo culture, System.Reflection.BindingFlags invokeAttr) => default; // 0x000000018232AEC0-0x000000018232AF40
		private object TryConvertToType(object value, ref bool failed) => default; // 0x000000018232AF40-0x000000018232B540
		private static object IsConvertibleToPrimitiveType(object value, System.Type targetType) => default; // 0x000000018926EBB4-0x000000018926F310
		private string GetCachedName(TypeNameKind kind) => default; // 0x000000018926C880-0x000000018926C8E4
		private System.Type make_array_type(int rank) => default; // 0x000000018926F788-0x000000018926F790
		public override System.Type MakeArrayType() => default; // 0x000000018926F310-0x000000018926F318
		public override System.Type MakeArrayType(int rank) => default; // 0x000000018926F318-0x000000018926F378
		private System.Type make_byref_type() => default; // 0x000000018926F790-0x000000018926F798
		public override System.Type MakeByRefType() => default; // 0x000000018926F378-0x000000018926F3F0
		private static System.Type MakePointerType(System.Type type) => default; // 0x000000018926F3F0-0x000000018926F3F8
		public override System.Type MakePointerType() => default; // 0x000000018926F3F8-0x000000018926F4D4
		public override System.Type[] GetGenericParameterConstraints() => default; // 0x000000018926CB70-0x000000018926CC48
		internal static object CreateInstanceForAnotherGenericParameter(System.Type genericType, RuntimeType genericArgument) => default; // 0x00000001830F9000-0x00000001830F9110
		private static System.Type MakeGenericType(System.Type gt, System.Type[] types) => default; // 0x000000018426F7E0-0x000000018426F7E8
		internal IntPtr GetMethodsByName_native(IntPtr namePtr, System.Reflection.BindingFlags bindingAttr, MemberListType listType) => default; // 0x000000018427129C-0x00000001842712A4
		internal RuntimeMethodInfo[] GetMethodsByName(string name, System.Reflection.BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) => default; // 0x00000001826B3F30-0x00000001826B4330
		private IntPtr GetPropertiesByName_native(IntPtr name, System.Reflection.BindingFlags bindingAttr, MemberListType listType) => default; // 0x00000001842712CC-0x00000001842712D4
		private IntPtr GetConstructors_native(System.Reflection.BindingFlags bindingAttr) => default; // 0x00000001842712BC-0x00000001842712C4
		private RuntimeConstructorInfo[] GetConstructors_internal(System.Reflection.BindingFlags bindingAttr, RuntimeType reflectedType) => default; // 0x00000001826B5AF0-0x00000001826B6110
		private RuntimePropertyInfo[] GetPropertiesByName(string name, System.Reflection.BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) => default; // 0x00000001826B7AD0-0x00000001826B7F20
		public override InterfaceMapping GetInterfaceMap(System.Type ifaceType) => default; // 0x000000018926CC58-0x000000018926CF70
		private static void GetInterfaceMapData(System.Type t, System.Type iface, out MethodInfo[] targets, out MethodInfo[] methods) {
			targets = default;
			methods = default;
		} // 0x000000018926CC50-0x000000018926CC58
		private static void GetGUID(System.Type type, byte[] guid) {} // 0x000000018926CB48-0x000000018926CB50
		internal void GetPacking(out int packing, out int size) {
			packing = default;
			size = default;
		} // 0x000000018926D528-0x000000018926D530
		internal static System.Type GetTypeFromCLSIDImpl(Guid clsid, string server, bool throwOnError) => default; // 0x000000018926D6BC-0x000000018926D718
		protected override TypeCode GetTypeCodeImpl() => default; // 0x000000018318DF10-0x000000018318DF60
		private static TypeCode GetTypeCodeImplInternal(System.Type type) => default; // 0x0000000184275AF8-0x0000000184275B00
		internal static System.Type GetTypeFromProgIDImpl(string progID, string server, bool throwOnError) => default; // 0x000000018926D718-0x000000018926D774
		public override string ToString() => default; // 0x0000000182E67990-0x0000000182E67A20
		private bool IsGenericCOMObjectImpl() => default; // 0x000000018115F4C0-0x000000018115F530
		private static object CreateInstanceInternal(System.Type type) => default; // 0x000000018426FFA4-0x000000018426FFAC
		internal string getFullName(bool full_name, bool assembly_qualified) => default; // 0x0000000184274394-0x000000018427439C
		private System.Type[] GetGenericArgumentsInternal(bool runtimeArray) => default; // 0x000000018426F7E8-0x000000018426F7F0
		private GenericParameterAttributes GetGenericParameterAttributes() => default; // 0x000000018926CB50-0x000000018926CB70
		private int GetGenericParameterPosition() => default; // 0x000000018926CC48-0x000000018926CC50
		private IntPtr GetEvents_native(IntPtr name, MemberListType listType) => default; // 0x0000000184274338-0x0000000184274340
		private IntPtr GetFields_native(IntPtr name, System.Reflection.BindingFlags bindingAttr, MemberListType listType) => default; // 0x0000000184271308-0x0000000184271310
		private RuntimeFieldInfo[] GetFields_internal(string name, System.Reflection.BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) => default; // 0x00000001826B9480-0x00000001826B98D0
		private RuntimeEventInfo[] GetEvents_internal(string name, System.Reflection.BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) => default; // 0x0000000182E51700-0x0000000182E51DC0
		public override System.Type[] GetInterfaces() => default; // 0x00000001822C5220-0x00000001822C5230
		private IntPtr GetNestedTypes_native(IntPtr name, System.Reflection.BindingFlags bindingAttr, MemberListType listType) => default; // 0x0000000184274350-0x0000000184274358
		private RuntimeType[] GetNestedTypes_internal(string displayName, System.Reflection.BindingFlags bindingAttr, MemberListType listType) => default; // 0x0000000182E520F0-0x0000000182E524F0
		public override int GetHashCode() => default; // 0x000000018232A0C0-0x000000018232ABB0
		[ComVisible(true)]
		public override bool IsSubclassOf(System.Type type) => default; // 0x00000001824E0AB0-0x00000001824E0CF0
		protected override MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, Binder binder, CallingConventions callConv, System.Type[] types, ParameterModifier[] modifiers) => default; // 0x00000001826B2230-0x00000001826B2280
		protected override MethodInfo GetMethodImpl(string name, int genericParameterCount, System.Reflection.BindingFlags bindingAttr, Binder binder, CallingConventions callConv, System.Type[] types, ParameterModifier[] modifiers) => default; // 0x000000018926D250-0x000000018926D260
		private MethodInfo GetMethodImplCommon(string name, int genericParameterCount, System.Reflection.BindingFlags bindingAttr, Binder binder, CallingConventions callConv, System.Type[] types, ParameterModifier[] modifiers) => default; // 0x00000001826B2280-0x00000001826B2630
		private ListBuilder<MethodInfo> GetMethodCandidates(string name, int genericParameterCount, System.Reflection.BindingFlags bindingAttr, CallingConventions callConv, System.Type[] types, bool allowPrefixLookup) => default; // 0x00000001826B2630-0x00000001826B2900
	}

	[Serializable]
	internal class ReflectionOnlyType : RuntimeType // TypeDefIndex: 38938
	{
		// Properties
		public override RuntimeTypeHandle TypeHandle { get => default; } // 0x0000000189278570-0x00000001892785D4 
	
		// Constructors
		private ReflectionOnlyType() {} // 0x0000000189278528-0x0000000189278570
	}

	internal sealed class SharedStatics // TypeDefIndex: 38939
	{
		// Fields
		private static readonly SharedStatics _sharedStatics; // 0x00
		private Tokenizer.StringMaker _maker; // 0x10
	
		// Constructors
		private SharedStatics() {} // 0x000000018350B670-0x000000018350B680
		static SharedStatics() {} // 0x0000000189279740-0x00000001892797A4
	
		// Methods
		public static Tokenizer.StringMaker GetSharedStringMaker() => default; // 0x00000001892792AC-0x00000001892795B4
		public static void ReleaseSharedStringMaker(ref Tokenizer.StringMaker maker) {} // 0x00000001892795B4-0x0000000189279740
	}

	internal enum ExceptionArgument // TypeDefIndex: 38940
	{
		obj = 0,
		dictionary = 1,
		dictionaryCreationThreshold = 2,
		array = 3,
		info = 4,
		key = 5,
		collection = 6,
		list = 7,
		match = 8,
		converter = 9,
		queue = 10,
		stack = 11,
		capacity = 12,
		index = 13,
		startIndex = 14,
		value = 15,
		count = 16,
		arrayIndex = 17,
		name = 18,
		mode = 19,
		item = 20,
		options = 21,
		view = 22,
		sourceBytesToCopy = 23,
		start = 24,
		pointer = 25,
		ownedMemory = 26,
		text = 27,
		length = 28,
		comparer = 29,
		comparable = 30,
		exceptions = 31,
		exception = 32,
		action = 33,
		comparison = 34,
		startSegment = 35,
		endSegment = 36,
		endIndex = 37,
		task = 38,
		source = 39,
		state = 40,
		culture = 41,
		destination = 42,
		byteOffset = 43,
		minimumBufferSize = 44,
		offset = 45,
		values = 46,
		comparisonType = 47,
		s = 48,
		input = 49,
		format = 50
	}

	internal enum ExceptionResource // TypeDefIndex: 38941
	{
		Argument_ImplementIComparable = 0,
		Argument_InvalidType = 1,
		Argument_InvalidArgumentForComparison = 2,
		Argument_InvalidRegistryKeyPermissionCheck = 3,
		ArgumentOutOfRange_NeedNonNegNum = 4,
		Arg_ArrayPlusOffTooSmall = 5,
		Arg_NonZeroLowerBound = 6,
		Arg_RankMultiDimNotSupported = 7,
		Arg_RegKeyDelHive = 8,
		Arg_RegKeyStrLenBug = 9,
		Arg_RegSetStrArrNull = 10,
		Arg_RegSetMismatchedKind = 11,
		Arg_RegSubKeyAbsent = 12,
		Arg_RegSubKeyValueAbsent = 13,
		Argument_AddingDuplicate = 14,
		Serialization_InvalidOnDeser = 15,
		Serialization_MissingKeys = 16,
		Serialization_NullKey = 17,
		Argument_InvalidArrayType = 18,
		NotSupported_KeyCollectionSet = 19,
		NotSupported_ValueCollectionSet = 20,
		ArgumentOutOfRange_SmallCapacity = 21,
		ArgumentOutOfRange_Index = 22,
		Argument_InvalidOffLen = 23,
		Argument_ItemNotExist = 24,
		ArgumentOutOfRange_Count = 25,
		ArgumentOutOfRange_InvalidThreshold = 26,
		ArgumentOutOfRange_ListInsert = 27,
		NotSupported_ReadOnlyCollection = 28,
		InvalidOperation_CannotRemoveFromStackOrQueue = 29,
		InvalidOperation_EmptyQueue = 30,
		InvalidOperation_EnumOpCantHappen = 31,
		InvalidOperation_EnumFailedVersion = 32,
		InvalidOperation_EmptyStack = 33,
		ArgumentOutOfRange_BiggerThanCollection = 34,
		InvalidOperation_EnumNotStarted = 35,
		InvalidOperation_EnumEnded = 36,
		NotSupported_SortedListNestedWrite = 37,
		InvalidOperation_NoValue = 38,
		InvalidOperation_RegRemoveSubKey = 39,
		Security_RegistryPermission = 40,
		UnauthorizedAccess_RegistryNoWrite = 41,
		ObjectDisposed_RegKeyClosed = 42,
		NotSupported_InComparableType = 43,
		Argument_InvalidRegistryOptionsCheck = 44,
		Argument_InvalidRegistryViewCheck = 45,
		TaskT_TransitionToFinal_AlreadyCompleted = 46,
		TaskCompletionSourceT_TrySetException_NullException = 47,
		TaskCompletionSourceT_TrySetException_NoExceptions = 48,
		NotSupported_StringComparison = 49,
		InvalidOperation_NullArray = 50
	}

	[CLSCompliant(false)]
	[ComVisible(true)]
	[IsByRefLike]
	[NonVersionable]
	public struct TypedReference // TypeDefIndex: 38942
	{
		// Fields
		private RuntimeTypeHandle type; // 0x00
		private IntPtr Value; // 0x08
		private IntPtr Type; // 0x10
	
		// Properties
		internal bool IsNull { get => default; } // 0x000000018927EED0-0x000000018927EEE4 
	
		// Methods
		[CLSCompliant(false)]
		public static TypedReference MakeTypedReference(object target, System.Reflection.FieldInfo[] flds) => default; // 0x000000018927E9B0-0x000000018927EE74
		private static unsafe void InternalMakeTypedReference(void* result, object target, IntPtr[] flds, RuntimeType lastFieldType) {} // 0x000000018927E9A8-0x000000018927E9B0
		public override int GetHashCode() => default; // 0x000000018927E934-0x000000018927E9A8
		public override bool Equals(object o) => default; // 0x000000018927E8D0-0x000000018927E934
		[CLSCompliant(false)]
		public static void SetTypedReference(TypedReference target, object value) {} // 0x000000018927EE74-0x000000018927EED0
	}

	[Serializable]
	[ComVisible(true)]
	public class TypeLoadException : SystemException, ISerializable // TypeDefIndex: 38943
	{
		// Fields
		private string ClassName; // 0x90
		private string AssemblyName; // 0x98
		private string MessageArg; // 0xA0
		internal int ResourceId; // 0xA8
	
		// Properties
		public override string Message { get => default; } // 0x000000018927E850-0x000000018927E86C 
	
		// Constructors
		public TypeLoadException() {} // 0x000000018927E7F0-0x000000018927E834
		public TypeLoadException(string message) {} // 0x000000018927E7D0-0x000000018927E7F0
		private TypeLoadException(string className, string assemblyName) {} // 0x000000018927E834-0x000000018927E850
		private TypeLoadException(string className, string assemblyName, string messageArg, int resourceId) {} // 0x000000018927E5D4-0x000000018927E668
		protected TypeLoadException(SerializationInfo info, StreamingContext context) {} // 0x000000018927E668-0x000000018927E7D0
	
		// Methods
		private void SetMessageField() {} // 0x000000018927E4B8-0x000000018927E5D4
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x000000018927E2FC-0x000000018927E4B8
	}

	[Serializable]
	internal class UnitySerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 38944
	{
		// Fields
		private System.Type[] m_instantiation; // 0x10
		private int[] m_elementTypes; // 0x18
		private int m_genericParameterPosition; // 0x20
		private System.Type m_declaringType; // 0x28
		private MethodBase m_declaringMethod; // 0x30
		private string m_data; // 0x38
		private string m_assemblyName; // 0x40
		private int m_unityType; // 0x48
	
		// Constructors
		public UnitySerializationHolder() {} // Dummy constructor
		internal UnitySerializationHolder(SerializationInfo info, StreamingContext context) {} // 0x000000018927FD58-0x00000001892800E4
	
		// Methods
		internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type) => default; // 0x000000018927EEE4-0x000000018927F0C4
		internal System.Type MakeElementTypes(System.Type type) => default; // 0x000000018927FBE0-0x000000018927FCAC
		internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType) {} // 0x000000018927FAC0-0x000000018927FBE0
		internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type) {} // 0x000000018927F674-0x000000018927F958
		internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly) {} // 0x000000018927F958-0x000000018927FAC0
		private void ThrowInsufficientInformation(string field) {} // 0x000000018927FCAC-0x000000018927FD58
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x000000018927F0C4-0x000000018927F128
		public virtual object GetRealObject(StreamingContext context) => default; // 0x000000018927F128-0x000000018927F674
	}

	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public sealed class AppDomain : MarshalByRefObject // TypeDefIndex: 38945
	{
		// Fields
		private IntPtr _mono_app_domain; // 0x18
		private static string _process_guid; // 0x00
		[ThreadStatic]
		private static Dictionary<string, object> type_resolve_in_progress; // 0x80000000
		[ThreadStatic]
		private static Dictionary<string, object> assembly_resolve_in_progress; // 0x80000008
		[ThreadStatic]
		private static Dictionary<string, object> assembly_resolve_in_progress_refonly; // 0x80000010
		private object _evidence; // 0x20
		private object _granted; // 0x28
		private int _principalPolicy; // 0x30
		private object _domain_manager; // 0x78
		private object _activation; // 0x88
		private object _applicationIdentity; // 0x90
		private List<string> compatibility_switch; // 0x98
	
		// Properties
		public static AppDomain CurrentDomain { get => default; } // 0x0000000184270F78-0x0000000184270F80 
		[MonoTODO]
		public bool IsHomogenous { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		[MonoTODO]
		public bool IsFullyTrusted { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Events
		public event System.EventHandler DomainUnload;
		public event System.EventHandler ProcessExit;
		public event UnhandledExceptionEventHandler UnhandledException;
	
		// Constructors
		private AppDomain() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[Intrinsic]
		internal static bool IsAppXModel() => default; // 0x000000018115F4C0-0x000000018115F530
		private string getFriendlyName() => default; // 0x0000000189271DA4-0x0000000189271DB4
		private static AppDomain getCurDomain() => default; // 0x0000000184270F78-0x0000000184270F80
		private Assembly[] GetAssemblies(bool refOnly) => default; // 0x0000000189271258-0x0000000189271260
		public Assembly[] GetAssemblies() => default; // 0x0000000184270F94-0x0000000184270F9C
		public object GetData(string name) => default; // 0x0000000184270F9C-0x0000000184270FA4
		public override object InitializeLifetimeService() => default; // 0x0000000181002730-0x0000000181002740
		internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark) => default; // 0x0000000189271460-0x0000000189271468
		public Assembly Load(AssemblyName assemblyRef) => default; // 0x00000001892714D8-0x00000001892714E4
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		public Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity) => default; // 0x00000001892716D8-0x0000000189271C7C
		public Assembly Load(string assemblyString) => default; // 0x00000001892716A8-0x00000001892716D8
		internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark) => default; // 0x0000000189271570-0x00000001892716A8
		public Assembly Load(byte[] rawAssembly) => default; // 0x0000000189271554-0x0000000189271570
		internal Assembly LoadAssemblyRaw(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence, bool refonly) => default; // 0x000000018927144C-0x0000000189271460
		[Obsolete("Use an overload that does not take an Evidence parameter")]
		public Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence) => default; // 0x00000001892714E4-0x0000000189271554
		internal Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence, bool refonly) => default; // 0x0000000189271468-0x00000001892714D8
		private static AppDomain InternalSetDomainByID(int domain_id) => default; // 0x0000000189271380-0x000000018927138C
		private static AppDomain InternalSetDomain(AppDomain context) => default; // 0x000000018927138C-0x0000000189271398
		internal static void InternalPushDomainRefByID(int domain_id) {} // 0x0000000189271374-0x0000000189271380
		internal static void InternalPopDomainRef() {} // 0x0000000189271368-0x0000000189271374
		internal static System.Runtime.Remoting.Contexts.Context InternalSetContext(System.Runtime.Remoting.Contexts.Context context) => default; // 0x000000018919CEC0-0x000000018919CECC
		internal static System.Runtime.Remoting.Contexts.Context InternalGetContext() => default; // 0x000000018919D054-0x000000018919D05C
		internal static System.Runtime.Remoting.Contexts.Context InternalGetDefaultContext() => default; // 0x000000018919D054-0x000000018919D05C
		internal static string InternalGetProcessGuid(string newguid) => default; // 0x000000018927135C-0x0000000189271368
		internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) => default; // 0x0000000189271398-0x000000018927144C
		internal static string GetProcessGuid() => default; // 0x00000001892712EC-0x000000018927135C
		private static bool InternalIsFinalizingForUnload(int domain_id) => default; // 0x000000018115F4C0-0x000000018115F530
		public bool IsFinalizingForUnload() => default; // 0x000000018267ADD0-0x000000018267ADE0
		private int getDomainID() => default; // 0x0000000184270F80-0x0000000184270F94
		[Obsolete("AppDomain.GetCurrentThreadId has been deprecated because it does not provide a stable Id when managed threads are running on fibers (aka lightweight threads). To get a stable identifier for a managed thread, use the ManagedThreadId property on Thread.\'")]
		public static int GetCurrentThreadId() => default; // 0x0000000189271260-0x0000000189271268
		public override string ToString() => default; // 0x0000000189271DA4-0x0000000189271DB4
		private void DoAssemblyLoad(Assembly assembly) {} // 0x00000001892709E0-0x0000000189270A70
		private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) => default; // 0x0000000189270A70-0x0000000189270DFC
		internal Assembly DoTypeResolve(string name) => default; // 0x0000000189270F3C-0x0000000189271258
		internal Assembly DoResourceResolve(string name, Assembly requesting) => default; // 0x0000000189270E1C-0x0000000189270F3C
		private void DoDomainUnload() {} // 0x0000000189270DFC-0x0000000189270E1C
		internal byte[] GetMarshalledDomainObjRef() => default; // 0x0000000189271268-0x00000001892712EC
		internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) {
			arrResponse = default;
			cadMrm = default;
		} // 0x0000000189271C7C-0x0000000189271DA4
	}

	internal static class CompatibilitySwitches // TypeDefIndex: 38946
	{
		// Fields
		public static readonly bool IsAppEarlierThanWindowsPhone8; // 0x00
	}

	[ComVisible(true)]
	public static class Environment // TypeDefIndex: 38949
	{
		// Fields
		private const string mono_corlib_version = "1A5E0066-58DC-428A-B21C-0AD6CDAE2789"; // Metadata: 0x01F9E515
		private static string nl; // 0x00
		private static OperatingSystem os; // 0x08
	
		// Properties
		public static string CommandLine { get; } // 0x00000001830F0630-0x00000001830F0820 
		public static string CurrentDirectory { get; set; } // 0x0000000189224E44-0x0000000189224E4C 0x000000018927553C-0x0000000189275544
		public static int CurrentManagedThreadId { get; } // 0x00000001825D6FC0-0x00000001825D70F0 
		public static bool HasShutdownStarted { get; } // 0x0000000183D70FE0-0x0000000183D70FF0 
		public static string MachineName { get; } // 0x00000001842759E4-0x00000001842759EC 
		public static string NewLine { get; } // 0x00000001825F1430-0x00000001825F14C0 
		internal static PlatformID Platform { get; } // 0x0000000182102C70-0x0000000182102C80 
		public static OperatingSystem OSVersion { get; } // 0x00000001826D16E0-0x00000001826D17C0 
		public static string StackTrace { get; } // 0x00000001892754D4-0x0000000189275534 
		public static string SystemDirectory { get; } // 0x0000000184272834-0x0000000184272848 
		public static int TickCount { get; } // 0x00000001842713A8-0x00000001842713B0 
		public static string UserDomainName { get; } // 0x00000001842759E4-0x00000001842759EC 
		public static string UserName { get; } // 0x00000001842759DC-0x00000001842759E4 
		public static bool Is64BitOperatingSystem { get; } // 0x000000018232EB60-0x000000018232EB70 
		public static bool Is64BitProcess { get; } // 0x000000018232EB60-0x000000018232EB70 
		public static int ProcessorCount { get; } // 0x0000000184271FC4-0x0000000184271FDC 
		internal static bool IsRunningOnWindows { get; } // 0x000000018232EB60-0x000000018232EB70 
		internal static bool IsUnix { get; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Nested types
		[ComVisible(true)]
		public enum SpecialFolder // TypeDefIndex: 38947
		{
			Desktop = 0,
			Programs = 2,
			MyDocuments = 5,
			Personal = 5,
			Favorites = 6,
			Startup = 7,
			Recent = 8,
			SendTo = 9,
			StartMenu = 11,
			MyMusic = 13,
			MyVideos = 14,
			DesktopDirectory = 16,
			MyComputer = 17,
			NetworkShortcuts = 19,
			Fonts = 20,
			Templates = 21,
			CommonStartMenu = 22,
			CommonPrograms = 23,
			CommonStartup = 24,
			CommonDesktopDirectory = 25,
			ApplicationData = 26,
			PrinterShortcuts = 27,
			LocalApplicationData = 28,
			InternetCache = 32,
			Cookies = 33,
			History = 34,
			CommonApplicationData = 35,
			Windows = 36,
			System = 37,
			ProgramFiles = 38,
			MyPictures = 39,
			UserProfile = 40,
			SystemX86 = 41,
			ProgramFilesX86 = 42,
			CommonProgramFiles = 43,
			CommonProgramFilesX86 = 44,
			CommonTemplates = 45,
			CommonDocuments = 46,
			CommonAdminTools = 47,
			AdminTools = 48,
			CommonMusic = 53,
			CommonPictures = 54,
			CommonVideos = 55,
			Resources = 56,
			LocalizedResources = 57,
			CommonOemLinks = 58,
			CDBurning = 59
		}
	
		public enum SpecialFolderOption // TypeDefIndex: 38948
		{
			None = 0,
			DoNotVerify = 16384,
			Create = 32768
		}
	
		// Methods
		internal static string GetResourceString(string key) => default; // 0x000000018339AE90-0x000000018339AEA0
		internal static string GetResourceString(string key, params object[] values) => default; // 0x0000000182E3AE40-0x0000000182E3AF40
		internal static string GetResourceStringEncodingName(int codePage) => default; // 0x0000000189274834-0x000000018927495C
		private static string GetNewLine() => default; // 0x0000000189274818-0x000000018927482C
		internal static string GetOSVersionString() => default; // 0x000000018927482C-0x0000000189274834
		internal static System.Version CreateVersionFromString(string info) => default; // 0x000000018376E480-0x000000018376E620
		public static void Exit(int exitCode) {} // 0x0000000189274398-0x00000001892743A4
		public static string ExpandEnvironmentVariables(string name) => default; // 0x00000001892743A4-0x0000000189274654
		public static string[] GetCommandLineArgs() => default; // 0x00000001842751A8-0x00000001842751B0
		internal static string internalGetEnvironmentVariable_native(IntPtr variable) => default; // 0x0000000184276B30-0x0000000184276B38
		internal static string internalGetEnvironmentVariable(string variable) => default; // 0x000000018377ADF0-0x000000018377AFC0
		public static string GetEnvironmentVariable(string variable) => default; // 0x00000001842751A0-0x00000001842751A8
		private static Hashtable GetEnvironmentVariablesNoCase() => default; // 0x0000000189274688-0x0000000189274754
		public static IDictionary GetEnvironmentVariables() => default; // 0x0000000189274754-0x0000000189274808
		public static string GetFolderPath(SpecialFolder folder) => default; // 0x0000000183CF53B0-0x0000000183CF53C0
		private static string GetWindowsFolderPath(int folder) => default; // 0x00000001842770F0-0x00000001842770F8
		public static string GetFolderPath(SpecialFolder folder, SpecialFolderOption option) => default; // 0x0000000183CF53B0-0x0000000183CF53C0
		private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback) => default; // 0x0000000189274A30-0x0000000189274DB8
		internal static string UnixGetFolderPath(SpecialFolder folder, SpecialFolderOption option) => default; // 0x0000000189274FDC-0x00000001892754D4
		public static string[] GetLogicalDrives() => default; // 0x0000000189274808-0x0000000189274810
		public static string GetEnvironmentVariable(string variable, EnvironmentVariableTarget target) => default; // 0x0000000189274678-0x0000000189274688
		public static void SetEnvironmentVariable(string variable, string value) {} // 0x0000000189274DB8-0x0000000189274FDC
		internal static unsafe void InternalSetEnvironmentVariable(char* variable, int variable_length, char* value, int value_length) {} // 0x00000001892749F0-0x00000001892749F8
		internal static void InternalSetEnvironmentVariable(string variable, string value) {} // 0x00000001892749F8-0x0000000189274A30
		public static void FailFast(string message, Exception exception) {} // 0x0000000189274654-0x0000000189274664
		internal static void FailFast(string message, Exception exception, string errorSource) {} // 0x0000000189274664-0x0000000189274670
		private static bool GetIs64BitOperatingSystem() => default; // 0x000000018232EB60-0x000000018232EB70
		internal static string[] GetLogicalDrivesInternal() => default; // 0x0000000189274808-0x0000000189274810
		private static string[] GetEnvironmentVariableNames() => default; // 0x0000000189274670-0x0000000189274678
		internal static string GetMachineConfigPath() => default; // 0x0000000189274810-0x0000000189274818
		internal static string internalGetHome() => default; // 0x0000000189275534-0x000000018927553C
		internal static int GetPageSize() => default; // 0x0000000183D5C940-0x0000000183D5C950
		internal static string GetStackTrace(Exception e, bool needFileInfo) => default; // 0x000000018927495C-0x00000001892749F0
	}

	internal class MonoTypeInfo // TypeDefIndex: 38950
	{
		// Fields
		public string full_name; // 0x10
		public RuntimeConstructorInfo default_ctor; // 0x18
	
		// Constructors
		public MonoTypeInfo() {} // 0x000000018350B670-0x000000018350B680
	}

	internal sealed class TypeNameParser // TypeDefIndex: 38951
	{
		// Constructors
		public TypeNameParser() {} // Dummy constructor
	
		// Methods
		internal static System.Type GetType(string typeName, System.Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, System.Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark) => default; // 0x000000018927E86C-0x000000018927E8D0
	}

	[Serializable]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public sealed class AppDomainSetup // TypeDefIndex: 38952
	{
		// Fields
		private string application_base; // 0x10
		private string application_name; // 0x18
		private string cache_path; // 0x20
		private string configuration_file; // 0x28
		private string dynamic_base; // 0x30
		private string license_file; // 0x38
		private string private_bin_path; // 0x40
		private string private_bin_path_probe; // 0x48
		private string shadow_copy_directories; // 0x50
		private string shadow_copy_files; // 0x58
		private bool publisher_policy; // 0x60
		private bool path_changed; // 0x61
		private int loader_optimization; // 0x64
		private bool disallow_binding_redirects; // 0x68
		private bool disallow_code_downloads; // 0x69
		private object _activationArguments; // 0x70
		private object domain_initializer; // 0x78
		private object application_trust; // 0x80
		private string[] domain_initializer_args; // 0x88
		private bool disallow_appbase_probe; // 0x90
		private byte[] configuration_bytes; // 0x98
		private byte[] serialized_non_primitives; // 0xA0
		private string manager_assembly; // 0xA8
		private string manager_type; // 0xB0
		private string[] partial_visible_assemblies; // 0xB8
	
		// Constructors
		public AppDomainSetup() {} // 0x000000018350B670-0x000000018350B680
	}

	public struct ArgIterator // TypeDefIndex: 38953
	{
		// Fields
		private IntPtr sig; // 0x00
		private IntPtr args; // 0x08
		private int next_arg; // 0x10
		private int num_args; // 0x14
	
		// Methods
		public override bool Equals(object o) => default; // 0x0000000189272004-0x0000000189272060
		public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
	}

	public static class Console // TypeDefIndex: 38956
	{
		// Fields
		internal static TextWriter stdout; // 0x00
		private static TextWriter stderr; // 0x08
		private static TextReader stdin; // 0x10
		internal static bool IsRunningOnAndroid; // 0x18
		private static Encoding inputEncoding; // 0x20
		private static Encoding outputEncoding; // 0x28
		private static ConsoleCancelEventHandler cancel_event; // 0x30
	
		// Properties
		public static TextWriter Error { get; } // 0x000000018927339C-0x00000001892733EC 
		public static Encoding InputEncoding { get; } // 0x00000001892733EC-0x000000018927343C 
		public static Encoding OutputEncoding { get; } // 0x000000018927343C-0x000000018927348C 
	
		// Nested types
		private class WindowsConsole // TypeDefIndex: 38955
		{
			// Fields
			public static bool ctrlHandlerAdded; // 0x00
			private static WindowsCancelHandler cancelHandler; // 0x08
	
			// Nested types
			private delegate bool WindowsCancelHandler(int keyCode); // TypeDefIndex: 38954; 0x000000018102B410-0x000000018102B420
	
			// Constructors
			public WindowsConsole() {} // Dummy constructor
			static WindowsConsole() {} // 0x000000018928027C-0x0000000189280324
	
			// Methods
			private static extern int GetConsoleCP(); // 0x000000018928012C-0x0000000189280194
			private static extern int GetConsoleOutputCP(); // 0x0000000189280194-0x00000001892801FC
			private static bool DoWindowsConsoleCancelEvent(int keyCode) => default; // 0x00000001892800E4-0x000000018928012C
			public static int GetInputCodePage() => default; // 0x00000001892801FC-0x000000018928023C
			public static int GetOutputCodePage() => default; // 0x000000018928023C-0x000000018928027C
		}
	
		// Constructors
		static Console() {} // 0x000000018927319C-0x000000018927339C
	
		// Methods
		private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) {} // 0x0000000189272DE4-0x000000018927306C
		private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) => default; // 0x0000000189272B10-0x0000000189272C50
		public static Stream OpenStandardError(int bufferSize) => default; // 0x00000001892729A8-0x0000000189272A20
		public static Stream OpenStandardInput(int bufferSize) => default; // 0x0000000189272A20-0x0000000189272A98
		public static Stream OpenStandardOutput(int bufferSize) => default; // 0x0000000189272A98-0x0000000189272B10
		public static void SetOut(TextWriter newOut) {} // 0x0000000189272D0C-0x0000000189272DE4
		public static void WriteLine(object value) {} // 0x000000018927306C-0x00000001892730CC
		public static void WriteLine(string value) {} // 0x00000001892730CC-0x000000018927312C
		public static void WriteLine(string format, object arg0) {} // 0x000000018927312C-0x000000018927319C
		public static ConsoleKeyInfo ReadKey() => default; // 0x0000000189272CB4-0x0000000189272D0C
		public static ConsoleKeyInfo ReadKey(bool intercept) => default; // 0x0000000189272C50-0x0000000189272CB4
		private static void DoConsoleCancelEvent() {} // 0x00000001892727F8-0x00000001892729A8
	}

	internal static class ConsoleDriver // TypeDefIndex: 38957
	{
		// Fields
		internal static IConsoleDriver driver; // 0x00
		private static bool is_console; // 0x08
		private static bool called_isatty; // 0x09
	
		// Properties
		public static bool IsConsole { get; } // 0x00000001892726E8-0x00000001892727F8 
	
		// Constructors
		static ConsoleDriver() {} // 0x000000018927266C-0x00000001892726E8
	
		// Methods
		private static IConsoleDriver CreateNullConsoleDriver() => default; // 0x00000001892724F0-0x000000018927252C
		private static IConsoleDriver CreateWindowsConsoleDriver() => default; // 0x000000018927258C-0x00000001892725DC
		private static IConsoleDriver CreateTermInfoDriver(string term) => default; // 0x000000018927252C-0x000000018927258C
		public static ConsoleKeyInfo ReadKey(bool intercept) => default; // 0x00000001892725E4-0x0000000189272664
		private static bool Isatty(IntPtr handle) => default; // 0x00000001892725DC-0x00000001892725E4
		internal static int InternalKeyAvailable(int ms_timeout) => default; // 0x0000000181002730-0x0000000181002740
		internal static unsafe bool TtySetup(string keypadXmit, string teardown, out byte[] control_characters, out int* address) {
			control_characters = default;
			address = default;
			return default;
		} // 0x0000000189272664-0x000000018927266C
		internal static bool SetEcho(bool wantEcho) => default; // 0x000000018115F4C0-0x000000018115F530
	}

	internal sealed class DelegateData // TypeDefIndex: 38958
	{
		// Fields
		public System.Type target_type; // 0x10
		public string method_name; // 0x18
		public bool curried_first_arg; // 0x20
	
		// Constructors
		public DelegateData() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public abstract class Delegate : ICloneable, ISerializable // TypeDefIndex: 38959
	{
		// Fields
		private IntPtr method_ptr; // 0x10
		private IntPtr invoke_impl; // 0x18
		private object m_target; // 0x20
		private IntPtr method; // 0x28
		private IntPtr delegate_trampoline; // 0x30
		private IntPtr extra_arg; // 0x38
		private IntPtr method_code; // 0x40
		private IntPtr interp_method; // 0x48
		private IntPtr interp_invoke_impl; // 0x50
		private MethodInfo method_info; // 0x58
		private MethodInfo original_method_info; // 0x60
		private DelegateData data; // 0x68
		private bool method_is_virtual; // 0x70
	
		// Properties
		public MethodInfo Method { get; } // 0x0000000182304560-0x0000000182304570 
		public object Target { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		protected Delegate() {} // Dummy constructor
	
		// Methods
		private MethodInfo GetVirtualMethod_internal() => default; // 0x0000000189274304-0x000000018927430C
		internal static Delegate CreateDelegate_internal(System.Type type, object target, MethodInfo info, bool throwOnBindFailure) => default; // 0x000000018426F7D8-0x000000018426F7E0
		private static bool arg_type_match(System.Type delArgType, System.Type argType) => default; // 0x00000001823014D0-0x0000000182301550
		private static bool arg_type_match_this(System.Type delArgType, System.Type argType, bool boxedThis) => default; // 0x0000000182301550-0x0000000182301660
		private static bool return_type_match(System.Type delReturnType, System.Type returnType) => default; // 0x0000000182301660-0x00000001823016E0
		private static Delegate CreateDelegate(System.Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) => default; // 0x00000001823024E0-0x00000001823029E0
		public static Delegate CreateDelegate(System.Type type, object firstArgument, MethodInfo method) => default; // 0x000000018426FF74-0x000000018426FF94
		public static Delegate CreateDelegate(System.Type type, MethodInfo method, bool throwOnBindFailure) => default; // 0x0000000189273DA0-0x0000000189273DC8
		public static Delegate CreateDelegate(System.Type type, MethodInfo method) => default; // 0x0000000189273C74-0x0000000189273C80
		public static Delegate CreateDelegate(System.Type type, object target, string method) => default; // 0x0000000189273D64-0x0000000189273D80
		private static MethodInfo GetCandidateMethod(System.Type type, System.Type target, string method, System.Reflection.BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) => default; // 0x0000000189273ECC-0x0000000189274274
		public static Delegate CreateDelegate(System.Type type, System.Type target, string method, bool ignoreCase, bool throwOnBindFailure) => default; // 0x0000000189273DC8-0x0000000189273ECC
		public static Delegate CreateDelegate(System.Type type, System.Type target, string method) => default; // 0x0000000189273D80-0x0000000189273DA0
		public static Delegate CreateDelegate(System.Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) => default; // 0x0000000189273C80-0x0000000189273D64
		public static Delegate CreateDelegate(System.Type type, object target, string method, bool ignoreCase) => default; // 0x0000000189273C58-0x0000000189273C74
		public virtual object Clone() => default; // 0x0000000182A48500-0x0000000182A48510
		public override bool Equals(object obj) => default; // 0x0000000182303E90-0x0000000182304000
		public override int GetHashCode() => default; // 0x000000018328C4C0-0x000000018328C510
		protected virtual MethodInfo GetMethodImpl() => default; // 0x00000001826B3230-0x00000001826B3600
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001892742E4-0x0000000189274304
		public virtual Delegate[] GetInvocationList() => default; // 0x0000000189274274-0x00000001892742E4
		public static Delegate Combine(Delegate a, Delegate b) => default; // 0x0000000182474930-0x00000001824749F0
		[ComVisible(true)]
		public static Delegate Combine(params Delegate[] delegates) => default; // 0x0000000189273C0C-0x0000000189273C58
		protected virtual Delegate CombineImpl(Delegate d) => default; // 0x0000000189273BA4-0x0000000189273C0C
		public static Delegate Remove(Delegate source, Delegate value) => default; // 0x00000001824749F0-0x0000000182474AC0
		protected virtual Delegate RemoveImpl(Delegate d) => default; // 0x000000018927435C-0x0000000189274384
		public static Delegate RemoveAll(Delegate source, Delegate value) => default; // 0x000000018927430C-0x000000018927435C
		public static bool operator ==(Delegate d1, Delegate d2) => default; // 0x0000000182BCB480-0x0000000182BCB5E0
		public static bool operator !=(Delegate d1, Delegate d2) => default; // 0x0000000189274384-0x0000000189274398
		internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) => default; // 0x000000018426FF6C-0x000000018426FF74
	}

	[Serializable]
	internal class DelegateSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 38961
	{
		// Fields
		private Delegate _delegate; // 0x10
	
		// Nested types
		[Serializable]
		private class DelegateEntry // TypeDefIndex: 38960
		{
			// Fields
			private string type; // 0x10
			private string assembly; // 0x18
			private object target; // 0x20
			private string targetTypeAssembly; // 0x28
			private string targetTypeName; // 0x30
			private string methodName; // 0x38
			public DelegateEntry delegateEntry; // 0x40
	
			// Constructors
			public DelegateEntry() {} // Dummy constructor
			public DelegateEntry(Delegate del, string targetLabel) {} // 0x0000000189273660-0x00000001892737D0
	
			// Methods
			public Delegate DeserializeDelegate(SerializationInfo info, int index) => default; // 0x000000018927348C-0x0000000189273660
		}
	
		// Constructors
		public DelegateSerializationHolder() {} // Dummy constructor
		private DelegateSerializationHolder(SerializationInfo info, StreamingContext ctx) {} // 0x0000000189273A28-0x0000000189273BA4
	
		// Methods
		public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx) {} // 0x00000001892737D0-0x00000001892739DC
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001892739DC-0x0000000189273A28
		public object GetRealObject(StreamingContext context) => default; // 0x00000001820B7B20-0x00000001820B7B30
	}

	internal static class EmptyArray<T> // TypeDefIndex: 38962
	{
		// Fields
		public static readonly T[] Value;
	
		// Constructors
		static EmptyArray() {}
	}

	internal enum SByteEnum : sbyte // TypeDefIndex: 38963
	{
	
	}

	internal enum Int16Enum : short // TypeDefIndex: 38964
	{
	
	}

	internal enum Int32Enum // TypeDefIndex: 38965
	{
	
	}

	internal enum Int64Enum : long // TypeDefIndex: 38966
	{
	
	}

	internal enum ByteEnum : byte // TypeDefIndex: 38967
	{
	
	}

	internal enum UInt16Enum : ushort // TypeDefIndex: 38968
	{
	
	}

	internal enum UInt32Enum : uint // TypeDefIndex: 38969
	{
	
	}

	internal enum UInt64Enum : ulong // TypeDefIndex: 38970
	{
	
	}

	[ComVisible(true)]
	public enum EnvironmentVariableTarget // TypeDefIndex: 38971
	{
		Process = 0,
		User = 1,
		Machine = 2
	}

	internal interface IConsoleDriver // TypeDefIndex: 38972
	{
		// Methods
		ConsoleKeyInfo ReadKey(bool intercept);
	}

	[Serializable]
	[ComVisible(true)]
	[IsReadOnly]
	public struct IntPtr : ISerializable, IEquatable<IntPtr> // TypeDefIndex: 38973
	{
		// Fields
		private readonly unsafe void* m_value; // 0x00
		public static readonly IntPtr Zero; // 0x00
	
		// Properties
		public static int Size { [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)] get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public unsafe IntPtr(int value) : this() {
			m_value = default;
		} // 0x0000000183D5CCB0-0x0000000183D5CCC0
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public unsafe IntPtr(long value) : this() {
			m_value = default;
		} // 0x0000000183D51730-0x0000000183D51740
		[CLSCompliant(false)]
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public unsafe IntPtr(void* value) : this() {
			m_value = default;
		} // 0x0000000183D51730-0x0000000183D51740
		private unsafe IntPtr(SerializationInfo info, StreamingContext context) : this() {
			m_value = default;
		} // 0x0000000189275744-0x000000018927579C
	
		// Methods
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000189275670-0x0000000189275714
		public override bool Equals(object obj) => default; // 0x0000000189275610-0x0000000189275670
		public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public int ToInt32() => default; // 0x0000000183D4E980-0x0000000183D4E990
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public long ToInt64() => default; // 0x000000018253BE20-0x000000018253BE30
		[CLSCompliant(false)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public unsafe void* ToPointer() => default; // 0x00000001820C61B0-0x00000001820C61C0
		public override string ToString() => default; // 0x0000000189275738-0x0000000189275744
		public string ToString(string format) => default; // 0x0000000189275714-0x0000000189275738
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static bool operator ==(IntPtr value1, IntPtr value2) => default; // 0x000000018232CE30-0x000000018232CE40
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static bool operator !=(IntPtr value1, IntPtr value2) => default; // 0x00000001822E54C0-0x00000001822E54D0
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static explicit operator IntPtr(int value) => default; // 0x0000000183D703D0-0x0000000183D703E0
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static explicit operator IntPtr(long value) => default; // 0x000000018339AE90-0x000000018339AEA0
		[CLSCompliant(false)]
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static unsafe explicit operator IntPtr(void* value) => default; // 0x000000018339AE90-0x000000018339AEA0
		public static explicit operator int(IntPtr value) => default; // 0x0000000183D517B0-0x0000000183D517C0
		public static explicit operator long(IntPtr value) => default; // 0x0000000183D86CE0-0x0000000183D86CF0
		[CLSCompliant(false)]
		public static unsafe explicit operator void*(IntPtr value) => default; // 0x000000018339AE90-0x000000018339AEA0
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static IntPtr Add(IntPtr pointer, int offset) => default; // 0x0000000183D70FF0-0x0000000183D71000
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static IntPtr operator +(IntPtr pointer, int offset) => default; // 0x0000000183D70FF0-0x0000000183D71000
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static IntPtr operator -(IntPtr pointer, int offset) => default; // 0x0000000183D71000-0x0000000183D71010
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal bool IsNull() => default; // 0x0000000182361C20-0x0000000182361C30
		bool IEquatable<IntPtr>.Equals(IntPtr other) => default; // 0x0000000183D1F440-0x0000000183D1F450
	}

	internal static class KnownTerminals // TypeDefIndex: 38974
	{
		// Properties
		public static byte[] linux { get; } // 0x00000001892757FC-0x000000018927585C 
		public static byte[] xterm { get; } // 0x000000018927585C-0x00000001892758BC 
		public static byte[] ansi { get; } // 0x000000018927579C-0x00000001892757FC 
	}

	[Serializable]
	[ComVisible(true)]
	public abstract class MarshalByRefObject // TypeDefIndex: 38975
	{
		// Fields
		[NonSerialized]
		private object _identity; // 0x10
	
		// Properties
		internal ServerIdentity ObjectIdentity { get; set; } // 0x0000000189275B3C-0x0000000189275B88 0x0000000189275B88-0x0000000189275BD4
	
		// Constructors
		protected MarshalByRefObject() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual ObjRef CreateObjRef(System.Type requestedType) => default; // 0x0000000189275AA4-0x0000000189275AF0
		public virtual object InitializeLifetimeService() => default; // 0x0000000189275AF0-0x0000000189275B3C
	}

	internal class MonoAsyncCall // TypeDefIndex: 38976
	{
		// Fields
		private object msg; // 0x10
		private IntPtr cb_method; // 0x18
		private object cb_target; // 0x20
		private object state; // 0x28
		private object res; // 0x30
		private object out_args; // 0x38
	
		// Constructors
		public MonoAsyncCall() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class MonoCustomAttrs // TypeDefIndex: 38978
	{
		// Fields
		private static Assembly corlib; // 0x00
		[ThreadStatic]
		private static Dictionary<System.Type, AttributeUsageAttribute> usage_cache; // 0x80000000
		private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x08
	
		// Nested types
		private class AttributeInfo // TypeDefIndex: 38977
		{
			// Fields
			private AttributeUsageAttribute _usage; // 0x10
			private int _inheritanceLevel; // 0x18
	
			// Properties
			public AttributeUsageAttribute Usage { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
			public int InheritanceLevel { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
	
			// Constructors
			public AttributeInfo() {} // Dummy constructor
			public AttributeInfo(AttributeUsageAttribute usage, int inheritanceLevel) {} // 0x0000000182738A30-0x0000000182738A50
		}
	
		// Constructors
		static MonoCustomAttrs() {} // 0x0000000183CF25E0-0x0000000183CF2660
	
		// Methods
		private static bool IsUserCattrProvider(object obj) => default; // 0x0000000182327270-0x0000000182327890
		internal static Attribute[] GetCustomAttributesInternal(ICustomAttributeProvider obj, System.Type attributeType, bool pseudoAttrs) => default; // 0x00000001842704BC-0x00000001842704C4
		internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, System.Type attributeType) => default; // 0x000000018232B540-0x000000018232BFA0
		private static object[] GetPseudoCustomAttributes(System.Type type) => default; // 0x0000000182D857A0-0x0000000182D85B80
		internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, System.Type attributeType, bool inheritedOnly) => default; // 0x000000018253D770-0x000000018253E090
		internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, System.Type attributeType, bool inherit) => default; // 0x000000018253BE30-0x000000018253D260
		internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) => default; // 0x0000000189276B54-0x0000000189276C94
		private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) => default; // 0x0000000189275D20-0x0000000189275D28
		internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, bool inherit = false /* Metadata: 0x01F9E575 */) => default; // 0x0000000189276A40-0x0000000189276B54
		internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, System.Type attributeType, bool inherit) => default; // 0x0000000189275D28-0x0000000189276A40
		internal static IList<CustomAttributeData> GetCustomAttributesDataBase(ICustomAttributeProvider obj, System.Type attributeType, bool inheritedOnly) => default; // 0x0000000189275BD4-0x0000000189275D20
		internal static CustomAttributeData[] GetPseudoCustomAttributesData(ICustomAttributeProvider obj, System.Type attributeType) => default; // 0x0000000189276C94-0x0000000189276E6C
		private static CustomAttributeData[] GetPseudoCustomAttributesData(System.Type type) => default; // 0x0000000189276E6C-0x000000018927705C
		internal static bool IsDefined(ICustomAttributeProvider obj, System.Type attributeType, bool inherit) => default; // 0x0000000182B2B970-0x0000000182B2BF80
		internal static bool IsDefinedInternal(ICustomAttributeProvider obj, System.Type AttributeType) => default; // 0x0000000184272A08-0x0000000184272A10
		private static PropertyInfo GetBasePropertyDefinition(RuntimePropertyInfo property) => default; // 0x000000018253F4D0-0x000000018253F8D0
		private static EventInfo GetBaseEventDefinition(RuntimeEventInfo evt) => default; // 0x000000018382FB00-0x000000018382FBE0
		private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) => default; // 0x000000018253D260-0x000000018253D770
		private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(System.Type attributeType) => default; // 0x0000000182B2C2D0-0x0000000182B2C4B0
		private static AttributeUsageAttribute RetrieveAttributeUsage(System.Type attributeType) => default; // 0x0000000182B2BF80-0x0000000182B2C2D0
	}

	internal sealed class MonoListItem // TypeDefIndex: 38979
	{
		// Fields
		private MonoListItem next; // 0x10
		private object data; // 0x18
	
		// Constructors
		public MonoListItem() {} // 0x000000018350B670-0x000000018350B680
	}

	internal sealed class MonoType : RuntimeType // TypeDefIndex: 38980
	{
		// Constructors
		public MonoType() {} // Dummy constructor
	}

	[Serializable]
	[ComVisible(true)]
	public abstract class MulticastDelegate : Delegate // TypeDefIndex: 38981
	{
		// Fields
		private Delegate[] delegates; // 0x78
	
		// Constructors
		protected MulticastDelegate() {} // Dummy constructor
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x000000018927705C-0x000000018927707C
		public sealed override bool Equals(object obj) => default; // 0x0000000182303DF0-0x0000000182303E90
		public sealed override int GetHashCode() => default; // 0x000000018328C4B0-0x000000018328C4C0
		protected override MethodInfo GetMethodImpl() => default; // 0x00000001826B2E20-0x00000001826B3230
		public sealed override Delegate[] GetInvocationList() => default; // 0x0000000183C85D30-0x0000000183C85DB0
		protected sealed override Delegate CombineImpl(Delegate follow) => default; // 0x0000000182474CB0-0x0000000182474E60
		private int LastIndexOf(Delegate[] haystack, Delegate[] needle) => default; // 0x000000018927707C-0x000000018927716C
		protected sealed override Delegate RemoveImpl(Delegate value) => default; // 0x0000000182474AC0-0x0000000182474CB0
	}

	internal class NullConsoleDriver : IConsoleDriver // TypeDefIndex: 38982
	{
		// Fields
		private static readonly ConsoleKeyInfo EmptyConsoleKeyInfo; // 0x00
	
		// Constructors
		public NullConsoleDriver() {} // 0x000000018350B670-0x000000018350B680
		static NullConsoleDriver() {} // 0x00000001892771C4-0x0000000189277210
	
		// Methods
		public ConsoleKeyInfo ReadKey(bool intercept) => default; // 0x000000018927716C-0x00000001892771C4
	}

	[Serializable]
	[ClassInterface(ClassInterfaceType.AutoDual)]
	[ComVisible(true)]
	public class Object // TypeDefIndex: 38983
	{
		// Constructors
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public Object() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual bool Equals(object obj) => default; // 0x0000000183D71010-0x0000000183D71020
		public static bool Equals(object objA, object objB) => default; // 0x0000000182ED3770-0x0000000182ED37A0
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		~Object() {} // 0x000000018350B670-0x000000018350B680
		public virtual int GetHashCode() => default; // 0x0000000183D4F970-0x0000000183D4F980
		public System.Type GetType() => default; // 0x000000018426F82C-0x000000018426F838
		protected object MemberwiseClone() => default; // 0x0000000182A48500-0x0000000182A48510
		public virtual string ToString() => default; // 0x00000001835D7B90-0x00000001835D7BC0
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static bool ReferenceEquals(object objA, object objB) => default; // 0x000000018232CE30-0x000000018232CE40
		internal static int InternalGetHashCode(object o) => default; // 0x0000000183D4F970-0x0000000183D4F980
		private void FieldGetter(string typeName, string fieldName, ref object val) {} // 0x000000018350B670-0x000000018350B680
		private void FieldSetter(string typeName, string fieldName, object val) {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[ComVisible(true)]
	public enum PlatformID // TypeDefIndex: 38984
	{
		Win32S = 0,
		Win32Windows = 1,
		Win32NT = 2,
		WinCE = 3,
		Unix = 4,
		Xbox = 5,
		MacOSX = 6
	}

	[IsByRefLike]
	public struct RuntimeArgumentHandle // TypeDefIndex: 38985
	{
		// Fields
		internal IntPtr args; // 0x00
	}

	[Serializable]
	[ComVisible(true)]
	public struct RuntimeFieldHandle : ISerializable // TypeDefIndex: 38986
	{
		// Fields
		private IntPtr value; // 0x00
	
		// Properties
		public IntPtr Value { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
	
		// Constructors
		internal RuntimeFieldHandle(IntPtr v) : this() {
			value = default;
		} // 0x0000000183D51730-0x0000000183D51740
		private RuntimeFieldHandle(SerializationInfo info, StreamingContext context) : this() {
			value = default;
		} // 0x000000018927880C-0x0000000189278978
	
		// Methods
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000189278694-0x0000000189278804
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public override bool Equals(object obj) => default; // 0x00000001892785D4-0x0000000189278694
		public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
		private static void SetValueInternal(System.Reflection.FieldInfo fi, object obj, object value) {} // 0x000000018426F824-0x000000018426F82C
		internal static void SetValue(RuntimeFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized) {} // 0x000000018426F824-0x000000018426F82C
		internal static unsafe void SetValueDirect(RuntimeFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType) {} // 0x0000000189278804-0x000000018927880C
	}

	[Serializable]
	[ComVisible(true)]
	public struct RuntimeMethodHandle : ISerializable // TypeDefIndex: 38987
	{
		// Fields
		private IntPtr value; // 0x00
	
		// Properties
		public IntPtr Value { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
	
		// Constructors
		internal RuntimeMethodHandle(IntPtr v) : this() {
			value = default;
		} // 0x0000000183D51730-0x0000000183D51740
		private RuntimeMethodHandle(SerializationInfo info, StreamingContext context) : this() {
			value = default;
		} // 0x0000000189278CF0-0x0000000189278E5C
	
		// Methods
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000189278B80-0x0000000189278CF0
		private static IntPtr GetFunctionPointer(IntPtr m) => default; // 0x0000000189278B74-0x0000000189278B80
		public IntPtr GetFunctionPointer() => default; // 0x0000000189278B64-0x0000000189278B74
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public override bool Equals(object obj) => default; // 0x0000000189278AA4-0x0000000189278B64
		public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
		internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format) => default; // 0x0000000189278978-0x0000000189278AA4
		internal bool IsNullHandle() => default; // 0x0000000182361C20-0x0000000182361C30
	}

	[Serializable]
	[ComVisible(true)]
	public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 38988
	{
		// Fields
		private IntPtr value; // 0x00
	
		// Properties
		public IntPtr Value { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
	
		// Constructors
		internal RuntimeTypeHandle(IntPtr val) : this() {
			value = default;
		} // 0x0000000183D51730-0x0000000183D51740
		internal RuntimeTypeHandle(RuntimeType type) : this() {
			value = default;
		} // 0x00000001826B5AD0-0x00000001826B5AF0
		private RuntimeTypeHandle(SerializationInfo info, StreamingContext context) : this() {
			value = default;
		} // 0x0000000189279130-0x00000001892792A4
	
		// Methods
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000189278E78-0x0000000189278FF8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public override bool Equals(object obj) => default; // 0x0000000183302950-0x0000000183302A30
		public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
		internal static TypeAttributes GetAttributes(RuntimeType type) => default; // 0x0000000189278E5C-0x0000000189278E70
		private static int GetMetadataToken(RuntimeType type) => default; // 0x000000018926F76C-0x000000018926F780
		internal static int GetToken(RuntimeType type) => default; // 0x000000018926F76C-0x000000018926F780
		private static System.Type GetGenericTypeDefinition_impl(RuntimeType type) => default; // 0x0000000184275A90-0x0000000184275A98
		internal static System.Type GetGenericTypeDefinition(RuntimeType type) => default; // 0x0000000184275A90-0x0000000184275A98
		internal static bool HasProxyAttribute(RuntimeType type) => default; // 0x0000000189279000-0x000000018927905C
		internal static bool IsPrimitive(RuntimeType type) => default; // 0x00000001829CA3B0-0x00000001829CA3E0
		internal static bool IsByRef(RuntimeType type) => default; // 0x00000001829CA390-0x00000001829CA3B0
		internal static bool IsPointer(RuntimeType type) => default; // 0x00000001829CA370-0x00000001829CA390
		internal static bool IsArray(RuntimeType type) => default; // 0x00000001829CA350-0x00000001829CA370
		internal static bool IsSzArray(RuntimeType type) => default; // 0x000000018926F750-0x000000018926F764
		internal static bool HasElementType(RuntimeType type) => default; // 0x00000001829CA410-0x00000001829CA440
		internal static CorElementType GetCorElementType(RuntimeType type) => default; // 0x00000001842725D4-0x00000001842725DC
		internal static bool HasInstantiation(RuntimeType type) => default; // 0x0000000189278FF8-0x0000000189279000
		internal static bool IsComObject(RuntimeType type) => default; // 0x000000018115F4C0-0x000000018115F530
		internal static bool IsInstanceOfType(RuntimeType type, object o) => default; // 0x00000001892790DC-0x00000001892790E4
		internal static bool HasReferences(RuntimeType type) => default; // 0x000000018927905C-0x0000000189279064
		internal static bool IsComObject(RuntimeType type, bool isGenericCOM) => default; // 0x000000018115F4C0-0x000000018115F530
		internal static bool IsContextful(RuntimeType type) => default; // 0x0000000189279064-0x00000001892790DC
		internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) => default; // 0x000000018115F4C0-0x000000018115F530
		internal static bool IsInterface(RuntimeType type) => default; // 0x00000001824E0A80-0x00000001824E0AB0
		internal static int GetArrayRank(RuntimeType type) => default; // 0x0000000184276FFC-0x0000000184277004
		internal static RuntimeAssembly GetAssembly(RuntimeType type) => default; // 0x000000018926D530-0x000000018926D538
		internal static RuntimeType GetElementType(RuntimeType type) => default; // 0x000000018332E270-0x000000018332E280
		internal static RuntimeModule GetModule(RuntimeType type) => default; // 0x000000018926D538-0x000000018926D540
		internal static bool IsGenericVariable(RuntimeType type) => default; // 0x000000018426F548-0x000000018426F550
		internal static RuntimeType GetBaseType(RuntimeType type) => default; // 0x00000001842702A0-0x00000001842702A8
		internal static bool CanCastTo(RuntimeType type, RuntimeType target) => default; // 0x000000018426F814-0x000000018426F824
		private static bool type_is_assignable_from(System.Type a, System.Type b) => default; // 0x00000001892792A4-0x00000001892792AC
		internal static bool IsGenericTypeDefinition(RuntimeType type) => default; // 0x0000000183405760-0x0000000183405770
		internal static IntPtr GetGenericParameterInfo(RuntimeType type) => default; // 0x0000000189278E70-0x0000000189278E78
		internal static bool IsSubclassOf(RuntimeType childType, RuntimeType baseType) => default; // 0x00000001824E0CF0-0x00000001824E0EA0
		internal static bool is_subclass_of(IntPtr childType, IntPtr baseType) => default; // 0x00000001842702A8-0x00000001842702B0
		internal static bool IsByRefLike(RuntimeType type) => default; // 0x000000018926F6CC-0x000000018926F6D4
		internal static bool IsTypeDefinition(RuntimeType type) => default; // 0x00000001892790E4-0x0000000189279130
		private static RuntimeType internal_from_name(string name, ref StackCrawlMark stackMark, Assembly callerAssembly, bool throwOnError, bool ignoreCase, bool reflectionOnly) => default; // 0x0000000184276798-0x00000001842767B0
		internal static RuntimeType GetTypeByName(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark, bool loadTypeFromPartialName) => default; // 0x00000001835FFE90-0x00000001835FFF60
	}

	internal class TermInfoDriver : IConsoleDriver // TypeDefIndex: 38989
	{
		// Fields
		private static unsafe int* native_terminal_size; // 0x00
		private static int terminal_size; // 0x08
		private static readonly string[] locations; // 0x10
		private TermInfoReader reader; // 0x10
		private int cursorLeft; // 0x18
		private int cursorTop; // 0x1C
		private string title; // 0x20
		private string titleFormat; // 0x28
		private bool cursorVisible; // 0x30
		private string csrVisible; // 0x38
		private string csrInvisible; // 0x40
		private string clear; // 0x48
		private string bell; // 0x50
		private string term; // 0x58
		private StreamReader stdin; // 0x60
		private CStreamWriter stdout; // 0x68
		private int windowWidth; // 0x70
		private int windowHeight; // 0x74
		private int bufferHeight; // 0x78
		private int bufferWidth; // 0x7C
		private char[] buffer; // 0x80
		private int readpos; // 0x88
		private int writepos; // 0x8C
		private string keypadXmit; // 0x90
		private string keypadLocal; // 0x98
		private bool inited; // 0xA0
		private object initLock; // 0xA8
		private bool initKeys; // 0xB0
		private string origPair; // 0xB8
		private string origColors; // 0xC0
		private string cursorAddress; // 0xC8
		private ConsoleColor fgcolor; // 0xD0
		private string setfgcolor; // 0xD8
		private string setbgcolor; // 0xE0
		private int maxColors; // 0xE8
		private bool noGetPosition; // 0xEC
		private Hashtable keymap; // 0xF0
		private ByteMatcher rootmap; // 0xF8
		private int rl_startx; // 0x100
		private int rl_starty; // 0x104
		private byte[] control_characters; // 0x108
		private static readonly int[] _consoleColorToAnsiCode; // 0x18
		private char[] echobuf; // 0x110
		private int echon; // 0x118
	
		// Properties
		public bool Initialized { get => default; } // 0x0000000183D50A40-0x0000000183D50A50 
		public int WindowHeight { get => default; } // 0x000000018927DB30-0x000000018927DB5C 
		public int WindowWidth { get => default; } // 0x000000018927DB5C-0x000000018927DB88 
	
		// Constructors
		public TermInfoDriver() {} // Dummy constructor
		public TermInfoDriver(string term) {} // 0x000000018927D81C-0x000000018927DB30
		static TermInfoDriver() {} // 0x000000018927D6BC-0x000000018927D81C
	
		// Methods
		private static string TryTermInfoDir(string dir, string term) => default; // 0x000000018927D428-0x000000018927D528
		private static string SearchTerminfo(string term) => default; // 0x000000018927D090-0x000000018927D1D4
		private void WriteConsole(string str) {} // 0x000000018927D528-0x000000018927D554
		public void Init() {} // 0x000000018927B92C-0x000000018927C884
		private void IncrementX() {} // 0x000000018927B764-0x000000018927B7BC
		public void WriteSpecialKey(ConsoleKeyInfo key) {} // 0x000000018927D5A0-0x000000018927D6BC
		public void WriteSpecialKey(char c) {} // 0x000000018927D554-0x000000018927D5A0
		public bool IsSpecialKey(ConsoleKeyInfo key) => default; // 0x000000018927C904-0x000000018927C970
		public bool IsSpecialKey(char c) => default; // 0x000000018927C8B8-0x000000018927C904
		private void GetCursorPosition() {} // 0x000000018927B440-0x000000018927B4A8
		private void CheckWindowDimensions() {} // 0x000000018927990C-0x0000000189279A34
		private void AddToBuffer(int b) {} // 0x00000001892797F4-0x00000001892798F4
		private void AdjustBuffer() {} // 0x00000001892798F4-0x000000018927990C
		private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) => default; // 0x0000000189279A34-0x0000000189279B40
		private object GetKeyFromBuffer(bool cooked) => default; // 0x000000018927B4A8-0x000000018927B764
		private ConsoleKeyInfo ReadKeyInternal(out bool fresh) {
			fresh = default;
			return default;
		} // 0x000000018927CA54-0x000000018927CBAC
		private bool InputPending() => default; // 0x000000018927C884-0x000000018927C8B8
		private void QueueEcho(char c) {} // 0x000000018927C970-0x000000018927CA54
		private void Echo(ConsoleKeyInfo key) {} // 0x000000018927B3C8-0x000000018927B440
		private void EchoFlush() {} // 0x000000018927B380-0x000000018927B3C8
		public int Read([In, Out] char[] dest, int index, int count) {
			dest = default;
			return default;
		} // 0x000000018927CE24-0x000000018927D090
		public ConsoleKeyInfo ReadKey(bool intercept) => default; // 0x000000018927CBAC-0x000000018927CC30
		public string ReadLine() => default; // 0x000000018927CC30-0x000000018927CC3C
		public string ReadToEnd() => default; // 0x000000018927CC3C-0x000000018927CC48
		private string ReadUntilConditionInternal(bool haltOnNewLine) => default; // 0x000000018927CC48-0x000000018927CE24
		public void SetCursorPosition(int left, int top) {} // 0x000000018927D1D4-0x000000018927D428
		private void CreateKeyMap() {} // 0x0000000189279B40-0x000000018927B380
		private void InitKeys() {} // 0x000000018927B7BC-0x000000018927B92C
		private void AddStringMapping(TermInfoStrings s) {} // 0x00000001892797A4-0x00000001892797F4
	}

	internal static class ParameterizedStrings // TypeDefIndex: 38992
	{
		// Fields
		[ThreadStatic]
		private static LowLevelStack _cachedStack; // 0x80000000
	
		// Nested types
		public struct FormatParam // TypeDefIndex: 38990
		{
			// Fields
			private readonly int _int32; // 0x00
			private readonly string _string; // 0x08
	
			// Properties
			public int Int32 { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
			public string String { get => default; } // 0x00000001892755A4-0x00000001892755EC 
			public object Object { get => default; } // 0x0000000189275558-0x00000001892755A4 
	
			// Constructors
			public FormatParam(int value) : this() {
				_int32 = default;
				_string = default;
			} // 0x0000000189275544-0x0000000189275558
			private FormatParam(int intValue, string stringValue) : this() {
				_int32 = default;
				_string = default;
			} // 0x00000001871AED58-0x00000001871AED68
	
			// Methods
			public static implicit operator FormatParam(int value) => default; // 0x00000001892755EC-0x0000000189275610
		}
	
		private sealed class LowLevelStack // TypeDefIndex: 38991
		{
			// Fields
			private FormatParam[] _arr; // 0x10
			private int _count; // 0x18
	
			// Constructors
			public LowLevelStack() {} // 0x0000000189275A5C-0x0000000189275AA4
	
			// Methods
			public FormatParam Pop() => default; // 0x00000001892758E4-0x0000000189275990
			public void Push(FormatParam item) {} // 0x0000000189275990-0x0000000189275A5C
			public void Clear() {} // 0x00000001892758BC-0x00000001892758E4
		}
	
		// Methods
		public static string Evaluate(string format, params FormatParam[] args) => default; // 0x0000000189277DD0-0x0000000189277F88
		private static string EvaluateInternal(string format, ref int pos, FormatParam[] args, LowLevelStack stack, ref FormatParam[] dynamicVars, ref FormatParam[] staticVars) => default; // 0x0000000189277210-0x0000000189277DD0
		private static bool AsBool(int i) => default; // 0x0000000183637400-0x0000000183637410
		private static int AsInt(bool b) => default; // 0x0000000182C9E0C0-0x0000000182C9E0D0
		private static string StringFromAsciiBytes(byte[] buffer, int offset, int length) => default; // 0x00000001892782C4-0x0000000189278390
		private static unsafe extern int snprintf(byte* str, IntPtr size, string format, string arg1); // 0x0000000189278390-0x000000018927846C
		private static unsafe extern int snprintf(byte* str, IntPtr size, string format, int arg1); // 0x000000018927846C-0x0000000189278528
		private static string FormatPrintF(string format, object arg) => default; // 0x0000000189277F88-0x00000001892781A0
		private static FormatParam[] GetDynamicOrStaticVariables(char c, ref FormatParam[] dynamicVars, ref FormatParam[] staticVars, out int index) {
			index = default;
			return default;
		} // 0x00000001892781A0-0x00000001892782C4
	}

	internal class ByteMatcher // TypeDefIndex: 38993
	{
		// Fields
		private Hashtable map; // 0x10
		private Hashtable starts; // 0x18
	
		// Constructors
		public ByteMatcher() {} // 0x0000000189272460-0x00000001892724F0
	
		// Methods
		public void AddMapping(TermInfoStrings key, byte[] val) {} // 0x0000000189272060-0x0000000189272170
		public void Sort() {} // 0x000000018350B670-0x000000018350B680
		public bool StartsWith(int c) => default; // 0x00000001892723F0-0x0000000189272460
		public TermInfoStrings Match(char[] buffer, int offset, int length, out int used) {
			used = default;
			return default;
		} // 0x0000000189272170-0x00000001892723F0
	}

	internal enum TermInfoNumbers // TypeDefIndex: 38994
	{
		Columns = 0,
		InitTabs = 1,
		Lines = 2,
		LinesOfMemory = 3,
		MagicCookieGlitch = 4,
		PaddingBaudRate = 5,
		VirtualTerminal = 6,
		WidthStatusLine = 7,
		NumLabels = 8,
		LabelHeight = 9,
		LabelWidth = 10,
		MaxAttributes = 11,
		MaximumWindows = 12,
		MaxColors = 13,
		MaxPairs = 14,
		NoColorVideo = 15,
		BufferCapacity = 16,
		DotVertSpacing = 17,
		DotHorzSpacing = 18,
		MaxMicroAddress = 19,
		MaxMicroJump = 20,
		MicroColSize = 21,
		MicroLineSize = 22,
		NumberOfPins = 23,
		OutputResChar = 24,
		OutputResLine = 25,
		OutputResHorzInch = 26,
		OutputResVertInch = 27,
		PrintRate = 28,
		WideCharSize = 29,
		Buttons = 30,
		BitImageEntwining = 31,
		BitImageType = 32,
		Last = 33
	}

	internal class TermInfoReader // TypeDefIndex: 38995
	{
		// Fields
		private int boolSize; // 0x10
		private int numSize; // 0x14
		private int strOffsets; // 0x18
		private byte[] buffer; // 0x20
		private int booleansOffset; // 0x28
		private int intOffset; // 0x2C
	
		// Constructors
		public TermInfoReader() {} // Dummy constructor
		public TermInfoReader(string term, string filename) {} // 0x000000018927E0AC-0x000000018927E2FC
		public TermInfoReader(string term, byte[] buffer) {} // 0x000000018927E008-0x000000018927E0AC
	
		// Methods
		private void DetermineVersion(short magic) {} // 0x000000018927DB88-0x000000018927DC50
		private void ReadHeader(byte[] buffer, ref int position) {} // 0x000000018927DF1C-0x000000018927DFD8
		private void ReadNames(byte[] buffer, ref int position) {} // 0x000000018927DFD8-0x000000018927E008
		public int Get(TermInfoNumbers number) => default; // 0x000000018927DECC-0x000000018927DF1C
		public string Get(TermInfoStrings tstr) => default; // 0x000000018927DE44-0x000000018927DECC
		public byte[] GetStringBytes(TermInfoStrings tstr) => default; // 0x000000018927DD4C-0x000000018927DDD4
		private short GetInt16(byte[] buffer, int offset) => default; // 0x000000018927DC50-0x000000018927DCAC
		private string GetString(byte[] buffer, int offset) => default; // 0x000000018927DDD4-0x000000018927DE44
		private byte[] GetStringBytes(byte[] buffer, int offset) => default; // 0x000000018927DCAC-0x000000018927DD4C
	}

	internal enum TermInfoStrings // TypeDefIndex: 38996
	{
		BackTab = 0,
		Bell = 1,
		CarriageReturn = 2,
		ChangeScrollRegion = 3,
		ClearAllTabs = 4,
		ClearScreen = 5,
		ClrEol = 6,
		ClrEos = 7,
		ColumnAddress = 8,
		CommandCharacter = 9,
		CursorAddress = 10,
		CursorDown = 11,
		CursorHome = 12,
		CursorInvisible = 13,
		CursorLeft = 14,
		CursorMemAddress = 15,
		CursorNormal = 16,
		CursorRight = 17,
		CursorToLl = 18,
		CursorUp = 19,
		CursorVisible = 20,
		DeleteCharacter = 21,
		DeleteLine = 22,
		DisStatusLine = 23,
		DownHalfLine = 24,
		EnterAltCharsetMode = 25,
		EnterBlinkMode = 26,
		EnterBoldMode = 27,
		EnterCaMode = 28,
		EnterDeleteMode = 29,
		EnterDimMode = 30,
		EnterInsertMode = 31,
		EnterSecureMode = 32,
		EnterProtectedMode = 33,
		EnterReverseMode = 34,
		EnterStandoutMode = 35,
		EnterUnderlineMode = 36,
		EraseChars = 37,
		ExitAltCharsetMode = 38,
		ExitAttributeMode = 39,
		ExitCaMode = 40,
		ExitDeleteMode = 41,
		ExitInsertMode = 42,
		ExitStandoutMode = 43,
		ExitUnderlineMode = 44,
		FlashScreen = 45,
		FormFeed = 46,
		FromStatusLine = 47,
		Init1string = 48,
		Init2string = 49,
		Init3string = 50,
		InitFile = 51,
		InsertCharacter = 52,
		InsertLine = 53,
		InsertPadding = 54,
		KeyBackspace = 55,
		KeyCatab = 56,
		KeyClear = 57,
		KeyCtab = 58,
		KeyDc = 59,
		KeyDl = 60,
		KeyDown = 61,
		KeyEic = 62,
		KeyEol = 63,
		KeyEos = 64,
		KeyF0 = 65,
		KeyF1 = 66,
		KeyF10 = 67,
		KeyF2 = 68,
		KeyF3 = 69,
		KeyF4 = 70,
		KeyF5 = 71,
		KeyF6 = 72,
		KeyF7 = 73,
		KeyF8 = 74,
		KeyF9 = 75,
		KeyHome = 76,
		KeyIc = 77,
		KeyIl = 78,
		KeyLeft = 79,
		KeyLl = 80,
		KeyNpage = 81,
		KeyPpage = 82,
		KeyRight = 83,
		KeySf = 84,
		KeySr = 85,
		KeyStab = 86,
		KeyUp = 87,
		KeypadLocal = 88,
		KeypadXmit = 89,
		LabF0 = 90,
		LabF1 = 91,
		LabF10 = 92,
		LabF2 = 93,
		LabF3 = 94,
		LabF4 = 95,
		LabF5 = 96,
		LabF6 = 97,
		LabF7 = 98,
		LabF8 = 99,
		LabF9 = 100,
		MetaOff = 101,
		MetaOn = 102,
		Newline = 103,
		PadChar = 104,
		ParmDch = 105,
		ParmDeleteLine = 106,
		ParmDownCursor = 107,
		ParmIch = 108,
		ParmIndex = 109,
		ParmInsertLine = 110,
		ParmLeftCursor = 111,
		ParmRightCursor = 112,
		ParmRindex = 113,
		ParmUpCursor = 114,
		PkeyKey = 115,
		PkeyLocal = 116,
		PkeyXmit = 117,
		PrintScreen = 118,
		PrtrOff = 119,
		PrtrOn = 120,
		RepeatChar = 121,
		Reset1string = 122,
		Reset2string = 123,
		Reset3string = 124,
		ResetFile = 125,
		RestoreCursor = 126,
		RowAddress = 127,
		SaveCursor = 128,
		ScrollForward = 129,
		ScrollReverse = 130,
		SetAttributes = 131,
		SetTab = 132,
		SetWindow = 133,
		Tab = 134,
		ToStatusLine = 135,
		UnderlineChar = 136,
		UpHalfLine = 137,
		InitProg = 138,
		KeyA1 = 139,
		KeyA3 = 140,
		KeyB2 = 141,
		KeyC1 = 142,
		KeyC3 = 143,
		PrtrNon = 144,
		CharPadding = 145,
		AcsChars = 146,
		PlabNorm = 147,
		KeyBtab = 148,
		EnterXonMode = 149,
		ExitXonMode = 150,
		EnterAmMode = 151,
		ExitAmMode = 152,
		XonCharacter = 153,
		XoffCharacter = 154,
		EnaAcs = 155,
		LabelOn = 156,
		LabelOff = 157,
		KeyBeg = 158,
		KeyCancel = 159,
		KeyClose = 160,
		KeyCommand = 161,
		KeyCopy = 162,
		KeyCreate = 163,
		KeyEnd = 164,
		KeyEnter = 165,
		KeyExit = 166,
		KeyFind = 167,
		KeyHelp = 168,
		KeyMark = 169,
		KeyMessage = 170,
		KeyMove = 171,
		KeyNext = 172,
		KeyOpen = 173,
		KeyOptions = 174,
		KeyPrevious = 175,
		KeyPrint = 176,
		KeyRedo = 177,
		KeyReference = 178,
		KeyRefresh = 179,
		KeyReplace = 180,
		KeyRestart = 181,
		KeyResume = 182,
		KeySave = 183,
		KeySuspend = 184,
		KeyUndo = 185,
		KeySbeg = 186,
		KeyScancel = 187,
		KeyScommand = 188,
		KeyScopy = 189,
		KeyScreate = 190,
		KeySdc = 191,
		KeySdl = 192,
		KeySelect = 193,
		KeySend = 194,
		KeySeol = 195,
		KeySexit = 196,
		KeySfind = 197,
		KeyShelp = 198,
		KeyShome = 199,
		KeySic = 200,
		KeySleft = 201,
		KeySmessage = 202,
		KeySmove = 203,
		KeySnext = 204,
		KeySoptions = 205,
		KeySprevious = 206,
		KeySprint = 207,
		KeySredo = 208,
		KeySreplace = 209,
		KeySright = 210,
		KeySrsume = 211,
		KeySsave = 212,
		KeySsuspend = 213,
		KeySundo = 214,
		ReqForInput = 215,
		KeyF11 = 216,
		KeyF12 = 217,
		KeyF13 = 218,
		KeyF14 = 219,
		KeyF15 = 220,
		KeyF16 = 221,
		KeyF17 = 222,
		KeyF18 = 223,
		KeyF19 = 224,
		KeyF20 = 225,
		KeyF21 = 226,
		KeyF22 = 227,
		KeyF23 = 228,
		KeyF24 = 229,
		KeyF25 = 230,
		KeyF26 = 231,
		KeyF27 = 232,
		KeyF28 = 233,
		KeyF29 = 234,
		KeyF30 = 235,
		KeyF31 = 236,
		KeyF32 = 237,
		KeyF33 = 238,
		KeyF34 = 239,
		KeyF35 = 240,
		KeyF36 = 241,
		KeyF37 = 242,
		KeyF38 = 243,
		KeyF39 = 244,
		KeyF40 = 245,
		KeyF41 = 246,
		KeyF42 = 247,
		KeyF43 = 248,
		KeyF44 = 249,
		KeyF45 = 250,
		KeyF46 = 251,
		KeyF47 = 252,
		KeyF48 = 253,
		KeyF49 = 254,
		KeyF50 = 255,
		KeyF51 = 256,
		KeyF52 = 257,
		KeyF53 = 258,
		KeyF54 = 259,
		KeyF55 = 260,
		KeyF56 = 261,
		KeyF57 = 262,
		KeyF58 = 263,
		KeyF59 = 264,
		KeyF60 = 265,
		KeyF61 = 266,
		KeyF62 = 267,
		KeyF63 = 268,
		ClrBol = 269,
		ClearMargins = 270,
		SetLeftMargin = 271,
		SetRightMargin = 272,
		LabelFormat = 273,
		SetClock = 274,
		DisplayClock = 275,
		RemoveClock = 276,
		CreateWindow = 277,
		GotoWindow = 278,
		Hangup = 279,
		DialPhone = 280,
		QuickDial = 281,
		Tone = 282,
		Pulse = 283,
		FlashHook = 284,
		FixedPause = 285,
		WaitTone = 286,
		User0 = 287,
		User1 = 288,
		User2 = 289,
		User3 = 290,
		User4 = 291,
		User5 = 292,
		User6 = 293,
		User7 = 294,
		User8 = 295,
		User9 = 296,
		OrigPair = 297,
		OrigColors = 298,
		InitializeColor = 299,
		InitializePair = 300,
		SetColorPair = 301,
		SetForeground = 302,
		SetBackground = 303,
		ChangeCharPitch = 304,
		ChangeLinePitch = 305,
		ChangeResHorz = 306,
		ChangeResVert = 307,
		DefineChar = 308,
		EnterDoublewideMode = 309,
		EnterDraftQuality = 310,
		EnterItalicsMode = 311,
		EnterLeftwardMode = 312,
		EnterMicroMode = 313,
		EnterNearLetterQuality = 314,
		EnterNormalQuality = 315,
		EnterShadowMode = 316,
		EnterSubscriptMode = 317,
		EnterSuperscriptMode = 318,
		EnterUpwardMode = 319,
		ExitDoublewideMode = 320,
		ExitItalicsMode = 321,
		ExitLeftwardMode = 322,
		ExitMicroMode = 323,
		ExitShadowMode = 324,
		ExitSubscriptMode = 325,
		ExitSuperscriptMode = 326,
		ExitUpwardMode = 327,
		MicroColumnAddress = 328,
		MicroDown = 329,
		MicroLeft = 330,
		MicroRight = 331,
		MicroRowAddress = 332,
		MicroUp = 333,
		OrderOfPins = 334,
		ParmDownMicro = 335,
		ParmLeftMicro = 336,
		ParmRightMicro = 337,
		ParmUpMicro = 338,
		SelectCharSet = 339,
		SetBottomMargin = 340,
		SetBottomMarginParm = 341,
		SetLeftMarginParm = 342,
		SetRightMarginParm = 343,
		SetTopMargin = 344,
		SetTopMarginParm = 345,
		StartBitImage = 346,
		StartCharSetDef = 347,
		StopBitImage = 348,
		StopCharSetDef = 349,
		SubscriptCharacters = 350,
		SuperscriptCharacters = 351,
		TheseCauseCr = 352,
		ZeroMotion = 353,
		CharSetNames = 354,
		KeyMouse = 355,
		MouseInfo = 356,
		ReqMousePos = 357,
		GetMouse = 358,
		SetAForeground = 359,
		SetABackground = 360,
		PkeyPlab = 361,
		DeviceType = 362,
		CodeSetInit = 363,
		Set0DesSeq = 364,
		Set1DesSeq = 365,
		Set2DesSeq = 366,
		Set3DesSeq = 367,
		SetLrMargin = 368,
		SetTbMargin = 369,
		BitImageRepeat = 370,
		BitImageNewline = 371,
		BitImageCarriageReturn = 372,
		ColorNames = 373,
		DefineBitImageRegion = 374,
		EndBitImageRegion = 375,
		SetColorBand = 376,
		SetPageLength = 377,
		DisplayPcChar = 378,
		EnterPcCharsetMode = 379,
		ExitPcCharsetMode = 380,
		EnterScancodeMode = 381,
		ExitScancodeMode = 382,
		PcTermOptions = 383,
		ScancodeEscape = 384,
		AltScancodeEsc = 385,
		EnterHorizontalHlMode = 386,
		EnterLeftHlMode = 387,
		EnterLowHlMode = 388,
		EnterRightHlMode = 389,
		EnterTopHlMode = 390,
		EnterVerticalHlMode = 391,
		SetAAttributes = 392,
		SetPglenInch = 393,
		Last = 394
	}

	internal interface TypeName : IEquatable<TypeName> // TypeDefIndex: 38997
	{
		// Properties
		string DisplayName { get; }
	}

	internal interface TypeIdentifier : TypeName // TypeDefIndex: 38998
	{
		// Properties
		string InternalName { get; }
	}

	internal class TypeNames // TypeDefIndex: 39000
	{
		// Nested types
		internal abstract class ATypeName : TypeName // TypeDefIndex: 38999
		{
			// Properties
			public abstract string DisplayName { get; }
	
			// Constructors
			protected ATypeName() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool Equals(TypeName other) => default; // 0x0000000189280610-0x0000000189280658
			public override int GetHashCode() => default; // 0x00000001892806AC-0x00000001892806DC
			public override bool Equals(object other) => default; // 0x0000000189280658-0x00000001892806AC
		}
	
		// Constructors
		public TypeNames() {} // Dummy constructor
	}

	internal class TypeIdentifiers // TypeDefIndex: 39002
	{
		// Nested types
		private class Display : TypeNames.ATypeName, TypeIdentifier // TypeDefIndex: 39001
		{
			// Fields
			private string displayName; // 0x10
			private string internal_name; // 0x18
	
			// Properties
			public override string DisplayName { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
			public string InternalName { get => default; } // 0x0000000189287774-0x00000001892877AC 
	
			// Constructors
			public Display() {} // Dummy constructor
			internal Display(string displayName) {} // 0x0000000182E1A410-0x0000000182E1A440
	
			// Methods
			private string GetInternalName() => default; // 0x0000000189287768-0x0000000189287774
		}
	
		// Constructors
		public TypeIdentifiers() {} // Dummy constructor
	
		// Methods
		internal static TypeIdentifier FromDisplay(string displayName) => default; // 0x000000018928A3DC-0x000000018928A43C
	}

	internal interface ModifierSpec // TypeDefIndex: 39003
	{
		// Methods
		System.Type Resolve(System.Type type);
		StringBuilder Append(StringBuilder sb);
	}

	internal class ArraySpec : ModifierSpec // TypeDefIndex: 39004
	{
		// Fields
		private int dimensions; // 0x10
		private bool bound; // 0x14
	
		// Constructors
		public ArraySpec() {} // Dummy constructor
		internal ArraySpec(int dimensions, bool bound) {} // 0x0000000183D71020-0x0000000183D71030
	
		// Methods
		public System.Type Resolve(System.Type type) => default; // 0x00000001892808EC-0x0000000189280934
		public StringBuilder Append(StringBuilder sb) => default; // 0x0000000189280848-0x00000001892808EC
		public override string ToString() => default; // 0x0000000189280934-0x00000001892809AC
	}

	internal class PointerSpec : ModifierSpec // TypeDefIndex: 39005
	{
		// Fields
		private int pointer_level; // 0x10
	
		// Constructors
		public PointerSpec() {} // Dummy constructor
		internal PointerSpec(int pointer_level) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public System.Type Resolve(System.Type type) => default; // 0x0000000189288C80-0x0000000189288CC4
		public StringBuilder Append(StringBuilder sb) => default; // 0x0000000189288C54-0x0000000189288C80
		public override string ToString() => default; // 0x0000000189288CC4-0x0000000189288D3C
	}

	internal class TypeSpec // TypeDefIndex: 39007
	{
		// Fields
		private TypeIdentifier name; // 0x10
		private string assembly_name; // 0x18
		private List<TypeIdentifier> nested; // 0x20
		private List<TypeSpec> generic_params; // 0x28
		private List<ModifierSpec> modifier_spec; // 0x30
		private bool is_byref; // 0x38
		private string display_fullname; // 0x40
	
		// Properties
		internal bool HasModifiers { get => default; } // 0x00000001885839D0-0x00000001885839DC 
		internal string DisplayFullName { get => default; } // 0x000000018928C714-0x000000018928C74C 
	
		// Nested types
		[Flags]
		internal enum DisplayNameFormat // TypeDefIndex: 39006
		{
			Default = 0,
			WANT_ASSEMBLY = 1,
			NO_MODIFIERS = 2
		}
	
		// Constructors
		public TypeSpec() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private string GetDisplayFullName(DisplayNameFormat flags) => default; // 0x000000018928A650-0x000000018928AB38
		private StringBuilder GetModifierString(StringBuilder sb) => default; // 0x000000018928AB38-0x000000018928AD00
		internal static TypeSpec Parse(string typeName) => default; // 0x000000018928BAC4-0x000000018928BBC0
		internal static string UnescapeInternalName(string displayName) => default; // 0x000000018928C64C-0x000000018928C714
		internal System.Type Resolve(System.Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, System.Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark) => default; // 0x000000018928BBC8-0x000000018928C5B8
		private void AddName(string type_name) {} // 0x000000018928A4EC-0x000000018928A5C8
		private void AddModifier(ModifierSpec md) {} // 0x000000018928A43C-0x000000018928A4EC
		private static void SkipSpace(string name, ref int pos) {} // 0x000000018928C5B8-0x000000018928C64C
		private static void BoundCheck(int idx, string s) {} // 0x000000018928A5C8-0x000000018928A650
		private static TypeIdentifier ParsedTypeIdentifier(string displayName) => default; // 0x000000018928BBC0-0x000000018928BBC8
		private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn) => default; // 0x000000018928AD00-0x000000018928BAC4
	}

	[Serializable]
	[CLSCompliant(false)]
	[ComVisible(true)]
	[IsReadOnly]
	public struct UIntPtr : ISerializable, IEquatable<UIntPtr> // TypeDefIndex: 39008
	{
		// Fields
		public static readonly UIntPtr Zero; // 0x00
		private readonly unsafe void* _pointer; // 0x00
	
		// Properties
		public static int Size { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public unsafe UIntPtr(ulong value) : this() {
			_pointer = default;
		} // 0x0000000182CFF470-0x0000000182CFF4D0
		public unsafe UIntPtr(uint value) : this() {
			_pointer = default;
		} // 0x0000000183D5CCC0-0x0000000183D5CCD0
		[CLSCompliant(false)]
		public unsafe UIntPtr(void* value) : this() {
			_pointer = default;
		} // 0x0000000183D51730-0x0000000183D51740
		static UIntPtr() {
			Zero = default;
		} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018928D26C-0x000000018928D2CC
		public override int GetHashCode() => default; // 0x0000000183D4E980-0x0000000183D4E990
		public uint ToUInt32() => default; // 0x0000000183D4E980-0x0000000183D4E990
		public ulong ToUInt64() => default; // 0x00000001820C61B0-0x00000001820C61C0
		[CLSCompliant(false)]
		public unsafe void* ToPointer() => default; // 0x00000001820C61B0-0x00000001820C61C0
		public override string ToString() => default; // 0x000000018928D370-0x000000018928D3C4
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x000000018928D2CC-0x000000018928D370
		public static bool operator ==(UIntPtr value1, UIntPtr value2) => default; // 0x000000018232CE30-0x000000018232CE40
		public static bool operator !=(UIntPtr value1, UIntPtr value2) => default; // 0x00000001822E54C0-0x00000001822E54D0
		public static explicit operator ulong(UIntPtr value) => default; // 0x000000018339AE90-0x000000018339AEA0
		public static explicit operator UIntPtr(ulong value) => default; // 0x0000000182CFF410-0x0000000182CFF470
		[CLSCompliant(false)]
		public static unsafe explicit operator UIntPtr(void* value) => default; // 0x000000018339AE90-0x000000018339AEA0
		public static explicit operator UIntPtr(uint value) => default; // 0x0000000183D517B0-0x0000000183D517C0
		bool IEquatable<UIntPtr>.Equals(UIntPtr other) => default; // 0x00000001822A9C20-0x00000001822A9C30
	}

	[Serializable]
	[ComVisible(true)]
	public abstract class ValueType // TypeDefIndex: 39010
	{
		// Nested types
		private static class Internal // TypeDefIndex: 39009
		{
			// Fields
			public static int hash_code_of_ptr_seed; // 0x00
		}
	
		// Constructors
		protected ValueType() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private static bool InternalEquals(object o1, object o2, out object[] fields) {
			fields = default;
			return default;
		} // 0x00000001842733D8-0x00000001842733E0
		internal static bool DefaultEquals(object o1, object o2) => default; // 0x0000000182D52F40-0x0000000182D530E0
		public override bool Equals(object obj) => default; // 0x0000000182D52F30-0x0000000182D52F40
		internal static int InternalGetHashCode(object o, out object[] fields) {
			fields = default;
			return default;
		} // 0x00000001842728D0-0x00000001842728D8
		public override int GetHashCode() => default; // 0x0000000182A95140-0x0000000182A951E0
		internal static int GetHashCodeOfPtr(IntPtr ptr) => default; // 0x000000018928D3C4-0x000000018928D420
		public override string ToString() => default; // 0x00000001831EBB10-0x00000001831EBB40
	}

	internal struct Variant // TypeDefIndex: 39011
	{
		// Fields
		public short vt; // 0x00
		public ushort wReserved1; // 0x02
		public ushort wReserved2; // 0x04
		public ushort wReserved3; // 0x06
		public long llVal; // 0x08
		public int lVal; // 0x08
		public byte bVal; // 0x08
		public short iVal; // 0x08
		public float fltVal; // 0x08
		public double dblVal; // 0x08
		public short boolVal; // 0x08
		public IntPtr bstrVal; // 0x08
		public sbyte cVal; // 0x08
		public ushort uiVal; // 0x08
		public uint ulVal; // 0x08
		public ulong ullVal; // 0x08
		public int intVal; // 0x08
		public uint uintVal; // 0x08
		public IntPtr pdispVal; // 0x08
		public BRECORD bRecord; // 0x08
	
		// Methods
		public void Clear() {} // 0x000000018928D420-0x000000018928D49C
	}

	internal struct BRECORD // TypeDefIndex: 39012
	{
		// Fields
		private IntPtr pvRecord; // 0x00
		private IntPtr pRecInfo; // 0x08
	}

	[Serializable]
	[ComVisible(true)]
	public class WeakReference : ISerializable // TypeDefIndex: 39013
	{
		// Fields
		private bool isLongReference; // 0x10
		private GCHandle gcHandle; // 0x18
	
		// Properties
		public virtual bool IsAlive { get => default; } // 0x0000000182CB0F60-0x0000000182CB0F90 
		public virtual object Target { get => default; set {} } // 0x0000000182CB0F90-0x0000000182CB0FB0 0x000000018928D770-0x000000018928D77C
		public virtual bool TrackResurrection { get => default; } // 0x00000001811797F0-0x0000000181179800 
	
		// Constructors
		protected WeakReference() {} // 0x000000018350B670-0x000000018350B680
		public WeakReference(object target) {} // 0x0000000184270B38-0x0000000184270B44
		public WeakReference(object target, bool trackResurrection) {} // 0x0000000182B3F680-0x0000000182B3F6B0
		protected WeakReference(SerializationInfo info, StreamingContext context) {} // 0x000000018928D65C-0x000000018928D770
	
		// Methods
		private void AllocateHandle(object target) {} // 0x0000000182B3F6B0-0x0000000182B3F6E0
		~WeakReference() {} // 0x0000000183748FE0-0x0000000183749030
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x000000018928D500-0x000000018928D65C
	}

	[Serializable]
	public sealed class WeakReference<T> : ISerializable // TypeDefIndex: 39014
		where T : class
	{
		// Fields
		private GCHandle handle;
		private bool trackResurrection;
	
		// Constructors
		public WeakReference() {} // Dummy constructor
		public WeakReference(T target) {}
		public WeakReference(T target, bool trackResurrection) {}
		private WeakReference(SerializationInfo info, StreamingContext context) {}
	
		// Methods
		public void GetObjectData(SerializationInfo info, StreamingContext context) {}
		public void SetTarget(T target) {}
		public bool TryGetTarget(out ref T target) {
			target = default;
			return default;
		}
		~WeakReference() {}
	}

	internal struct InputRecord // TypeDefIndex: 39015
	{
		// Fields
		public short EventType; // 0x00
		public bool KeyDown; // 0x02
		public short RepeatCount; // 0x04
		public short VirtualKeyCode; // 0x06
		public short VirtualScanCode; // 0x08
		public char Character; // 0x0A
		public int ControlKeyState; // 0x0C
		private int pad1; // 0x10
		private bool pad2; // 0x14
	}

	internal struct Coord // TypeDefIndex: 39016
	{
		// Fields
		public short X; // 0x00
		public short Y; // 0x02
	}

	internal struct SmallRect // TypeDefIndex: 39017
	{
		// Fields
		public short Left; // 0x00
		public short Top; // 0x02
		public short Right; // 0x04
		public short Bottom; // 0x06
	}

	internal struct ConsoleScreenBufferInfo // TypeDefIndex: 39018
	{
		// Fields
		public System.Coord Size; // 0x00
		public System.Coord CursorPosition; // 0x04
		public short Attribute; // 0x08
		public SmallRect Window; // 0x0A
		public System.Coord MaxWindowSize; // 0x12
	}

	internal enum Handles // TypeDefIndex: 39019
	{
		STD_ERROR = -12,
		STD_OUTPUT = -11,
		STD_INPUT = -10
	}

	internal class WindowsConsoleDriver : IConsoleDriver // TypeDefIndex: 39020
	{
		// Fields
		private IntPtr inputHandle; // 0x10
		private IntPtr outputHandle; // 0x18
		private short defaultAttribute; // 0x20
	
		// Constructors
		public WindowsConsoleDriver() {} // 0x000000018928DB48-0x000000018928DBA0
	
		// Methods
		public ConsoleKeyInfo ReadKey(bool intercept) => default; // 0x000000018928D9D0-0x000000018928DB48
		private static bool IsModifierKey(short virtualKeyCode) => default; // 0x000000018928D884-0x000000018928D8A8
		private static extern IntPtr GetStdHandle(Handles handle); // 0x000000018928D80C-0x000000018928D884
		private static extern bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info); // 0x000000018928D77C-0x000000018928D80C
		private static extern bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread); // 0x000000018928D8A8-0x000000018928D9D0
	}

	internal class __ComObject // TypeDefIndex: 39021
	{
		// Constructors
		private __ComObject() {} // 0x000000018928DBD8-0x000000018928DC98
	}

	[Serializable]
	[IsReadOnly]
	public struct Decimal : IFormattable, IComparable, IConvertible, IComparable<decimal>, IEquatable<decimal>, IDeserializationCallback, ISpanFormattable // TypeDefIndex: 39028
	{
		// Fields
		private const int SignMask = 2147483647; // Metadata: 0x01F9E87B
		private const int ScaleMask = 16711680; // Metadata: 0x01F9E87C
		private const int ScaleShift = 16; // Metadata: 0x01F9E880
		[DecimalConstant(0, 0, 0, 0, 0)]
		public static readonly decimal Zero; // 0x00
		[DecimalConstant(0, 0, 0, 0, 1)]
		public static readonly decimal One; // 0x10
		[DecimalConstant(0, 128, 0, 0, 1)]
		public static readonly decimal MinusOne; // 0x20
		[DecimalConstant(0, 0, 4294967295, 4294967295, 4294967295)]
		public static readonly decimal MaxValue; // 0x30
		[DecimalConstant(0, 128, 4294967295, 4294967295, 4294967295)]
		public static readonly decimal MinValue; // 0x40
		private readonly int flags; // 0x00
		private readonly int hi; // 0x04
		private readonly int lo; // 0x08
		private readonly int mid; // 0x0C
		[NonSerialized]
		private readonly ulong ulomidLE; // 0x08
	
		// Properties
		internal uint High { get => default; } // 0x0000000183D4E990-0x0000000183D4E9A0 
		internal uint Low { get => default; } // 0x0000000183D516F0-0x0000000183D51700 
		internal uint Mid { get => default; } // 0x0000000183D4FBF0-0x0000000183D4FC00 
		internal bool IsNegative { get => default; } // 0x0000000189284DFC-0x0000000189284E04 
		internal int Scale { get => default; } // 0x0000000183D559C0-0x0000000183D559D0 
		private ulong Low64 { get => default; } // 0x0000000189286E74-0x0000000189286EEC 
	
		// Nested types
		private struct DecCalc // TypeDefIndex: 39027
		{
			// Fields
			private uint uflags; // 0x00
			private uint uhi; // 0x04
			private uint ulo; // 0x08
			private uint umid; // 0x0C
			private ulong ulomidLE; // 0x08
			private static readonly uint[] s_powers10; // 0x00
			private static readonly ulong[] s_ulongPowers10; // 0x08
			private static readonly double[] s_doublePowers10; // 0x10
			private static readonly PowerOvfl[] PowerOvflValues; // 0x18
	
			// Properties
			private uint High { get => default; set {} } // 0x0000000183D4E990-0x0000000183D4E9A0 0x0000000183D51720-0x0000000183D51730
			private uint Low { get => default; set {} } // 0x0000000183D516F0-0x0000000183D51700 0x0000000183D51710-0x0000000183D51720
			private uint Mid { get => default; set {} } // 0x0000000183D4FBF0-0x0000000183D4FC00 0x0000000183D55690-0x0000000183D556A0
			private bool IsNegative { get => default; } // 0x0000000189284DFC-0x0000000189284E04 
			private ulong Low64 { get => default; set {} } // 0x0000000189284E04-0x0000000189284E64 0x0000000189284E64-0x0000000189284ED0
	
			// Nested types
			internal enum RoundingMode // TypeDefIndex: 39022
			{
				ToEven = 0,
				AwayFromZero = 1,
				Truncate = 2,
				Floor = 3,
				Ceiling = 4
			}
	
			private struct PowerOvfl // TypeDefIndex: 39023
			{
				// Fields
				public readonly uint Hi; // 0x00
				public readonly ulong MidLo; // 0x08
	
				// Constructors
				public PowerOvfl(uint hi, uint mid, uint lo) {
					Hi = default;
					MidLo = default;
				} // 0x0000000183D711B0-0x0000000183D711D0
			}
	
			private struct Buf12 // TypeDefIndex: 39024
			{
				// Fields
				public uint U0; // 0x00
				public uint U1; // 0x04
				public uint U2; // 0x08
				private ulong ulo64LE; // 0x00
				private ulong uhigh64LE; // 0x04
	
				// Properties
				public ulong Low64 { get => default; set {} } // 0x0000000189280A0C-0x0000000189280A68 0x0000000189280AD4-0x0000000189280B3C
				public ulong High64 { get => default; set {} } // 0x00000001892809AC-0x0000000189280A0C 0x0000000189280A68-0x0000000189280AD4
			}
	
			private struct Buf16 // TypeDefIndex: 39025
			{
				// Fields
				public uint U0; // 0x00
				public uint U1; // 0x04
				public uint U2; // 0x08
				public uint U3; // 0x0C
				private ulong ulo64LE; // 0x00
				private ulong uhigh64LE; // 0x08
	
				// Properties
				public ulong Low64 { get => default; set {} } // 0x0000000189280B9C-0x0000000189280BF8 0x0000000189280C64-0x0000000189280CCC
				public ulong High64 { get => default; set {} } // 0x0000000189280B3C-0x0000000189280B9C 0x0000000189280BF8-0x0000000189280C64
			}
	
			private struct Buf24 // TypeDefIndex: 39026
			{
				// Fields
				public uint U0; // 0x00
				public uint U1; // 0x04
				public uint U2; // 0x08
				public uint U3; // 0x0C
				public uint U4; // 0x10
				public uint U5; // 0x14
				private ulong ulo64LE; // 0x00
				private ulong umid64LE; // 0x08
				private ulong uhigh64LE; // 0x10
	
				// Properties
				public ulong Low64 { get => default; set {} } // 0x0000000189280CCC-0x0000000189280D28 0x0000000189280D94-0x0000000189280DFC
				public ulong Mid64 { set {} } // 0x0000000189280DFC-0x0000000189280E68
				public ulong High64 { set {} } // 0x0000000189280D28-0x0000000189280D94
			}
	
			// Constructors
			static DecCalc() {
				s_powers10 = default;
				s_ulongPowers10 = default;
				s_doublePowers10 = default;
				PowerOvflValues = default;
			} // 0x000000018382E0B0-0x000000018382E3B0
	
			// Methods
			private static uint GetExponent(float f) => default; // 0x0000000183D71080-0x0000000183D71090
			private static uint GetExponent(double d) => default; // 0x0000000183D71070-0x0000000183D71080
			private static ulong UInt32x32To64(uint a, uint b) => default; // 0x0000000183D70AB0-0x0000000183D70AC0
			private static void UInt64x64To128(ulong a, ulong b, ref DecCalc result) {} // 0x00000001892835D0-0x000000018928372C
			private static uint Div96By32(ref Buf12 bufNum, uint den) => default; // 0x0000000189282984-0x0000000189282A30
			private static bool Div96ByConst(ref ulong high64, ref uint low, uint pow) => default; // 0x0000000189280324-0x0000000189280380
			private static void Unscale(ref uint low, ref ulong high64, ref int scale) {} // 0x000000018928372C-0x000000018928382C
			private static uint Div96By64(ref Buf12 bufNum, ulong den) => default; // 0x0000000189282A30-0x0000000189282B60
			private static uint Div128By96(ref Buf16 bufNum, ref Buf12 bufDen) => default; // 0x000000018928285C-0x0000000189282984
			private static uint IncreaseScale(ref Buf12 bufNum, uint power) => default; // 0x0000000189282CDC-0x0000000189282D58
			private static void IncreaseScale64(ref Buf12 bufNum, uint power) {} // 0x0000000189282C6C-0x0000000189282CDC
			private static unsafe int ScaleResult(Buf24* bufRes, uint hiRes, int scale) => default; // 0x0000000189283164-0x0000000189283404
			private static unsafe uint DivByConst(uint* result, uint hiRes, out uint quotient, out uint remainder, uint power) {
				quotient = default;
				remainder = default;
				return default;
			} // 0x0000000189280380-0x00000001892803EC
			private static int LeadingZeroCount(uint value) => default; // 0x00000001892803EC-0x0000000189280610
			private static int OverflowUnscale(ref Buf12 bufQuo, int scale, bool sticky) => default; // 0x0000000189283040-0x0000000189283164
			private static int SearchScale(ref Buf12 bufQuo, int scale) => default; // 0x0000000189283404-0x00000001892835D0
			private static bool Add32To96(ref Buf12 bufNum, uint value) => default; // 0x00000001892820F4-0x0000000189282144
			internal static void DecAddSub(ref DecCalc d1, ref DecCalc d2, bool sign) {} // 0x0000000189282144-0x00000001892827E0
			internal static int VarDecCmp([IsReadOnly] in decimal d1, [IsReadOnly] in decimal d2) => default; // 0x0000000183387A50-0x0000000183387AF0
			private static int VarDecCmpSub([IsReadOnly] in decimal d1, [IsReadOnly] in decimal d2) => default; // 0x000000018928382C-0x00000001892839B4
			internal static void VarDecMul(ref DecCalc d1, ref DecCalc d2) {} // 0x0000000189284868-0x0000000189284CBC
			internal static void VarDecFromR4(float input, out DecCalc result) {
				result = default;
			} // 0x0000000189284150-0x00000001892844D0
			internal static void VarDecFromR8(double input, out DecCalc result) {
				result = default;
			} // 0x00000001892844D0-0x0000000189284868
			internal static float VarR4FromDec([IsReadOnly] in decimal value) => default; // 0x0000000189284CBC-0x0000000189284D0C
			internal static double VarR8FromDec([IsReadOnly] in decimal value) => default; // 0x0000000189284D0C-0x0000000189284DFC
			internal static int GetHashCode([IsReadOnly] in decimal d) => default; // 0x0000000189282B60-0x0000000189282C6C
			internal static void VarDecDiv(ref DecCalc d1, ref DecCalc d2) {} // 0x00000001892839B4-0x0000000189284150
			internal static void InternalRound(ref DecCalc d, uint scale, RoundingMode mode) {} // 0x0000000189282D58-0x0000000189283040
			internal static uint DecDivMod1E9(ref DecCalc value) => default; // 0x00000001892827E0-0x000000018928285C
		}
	
		// Constructors
		public Decimal(int value) : this() {
			flags = default;
			hi = default;
			lo = default;
			mid = default;
			ulomidLE = default;
		} // 0x0000000183585920-0x0000000183585950
		[CLSCompliant(false)]
		public Decimal(uint value) : this() {
			flags = default;
			hi = default;
			lo = default;
			mid = default;
			ulomidLE = default;
		} // 0x0000000183D710D0-0x0000000183D710E0
		public Decimal(long value) : this() {
			flags = default;
			hi = default;
			lo = default;
			mid = default;
			ulomidLE = default;
		} // 0x00000001836E5D10-0x00000001836E5D30
		[CLSCompliant(false)]
		public Decimal(ulong value) : this() {
			flags = default;
			hi = default;
			lo = default;
			mid = default;
			ulomidLE = default;
		} // 0x0000000183D710E0-0x0000000183D710F0
		public Decimal(float value) : this() {
			flags = default;
			hi = default;
			lo = default;
			mid = default;
			ulomidLE = default;
		} // 0x0000000189286E08-0x0000000189286E74
		public Decimal(double value) : this() {
			flags = default;
			hi = default;
			lo = default;
			mid = default;
			ulomidLE = default;
		} // 0x0000000189286C60-0x0000000189286CCC
		public Decimal(int[] bits) : this() {
			flags = default;
			hi = default;
			lo = default;
			mid = default;
			ulomidLE = default;
		} // 0x0000000189286CCC-0x0000000189286E08
		public Decimal(int lo, int mid, int hi, bool isNegative, byte scale) : this() {
			flags = default;
			this.hi = default;
			this.lo = default;
			this.mid = default;
			ulomidLE = default;
		} // 0x0000000182845CC0-0x0000000182845D70
		private Decimal([IsReadOnly] in decimal d, int flags) : this() {
			this.flags = default;
			hi = default;
			lo = default;
			mid = default;
			ulomidLE = default;
		} // 0x0000000183D710F0-0x0000000183D71100
		static Decimal() {
			Zero = default;
			One = default;
			MinusOne = default;
			MaxValue = default;
			MinValue = default;
		} // 0x0000000183585700-0x00000001835857F0
	
		// Methods
		private static ref DecCalc AsMutable(ref decimal d) => ref _refReturnTypeForAsMutable; // 0x000000018339AE90-0x000000018339AEA0
		private ref DecCalc _refReturnTypeForAsMutable; // Dummy field
		internal static uint DecDivMod1E9(ref decimal value) => default; // 0x00000001892850EC-0x0000000189285144
		private static bool IsValid(int flags) => default; // 0x0000000189285320-0x000000018928533C
		void IDeserializationCallback.OnDeserialization(object sender) {} // 0x0000000189285DF0-0x0000000189285E8C
		internal static decimal Abs(ref decimal d) => default; // 0x0000000183D71090-0x0000000183D710B0
		public static decimal Add(decimal d1, decimal d2) => default; // 0x0000000189284ED0-0x0000000189284F54
		public static int Compare(decimal d1, decimal d2) => default; // 0x0000000189285090-0x00000001892850EC
		public int CompareTo(object value) => default; // 0x0000000189284F54-0x0000000189285034
		public int CompareTo(decimal value) => default; // 0x0000000189285034-0x0000000189285090
		public static decimal Divide(decimal d1, decimal d2) => default; // 0x0000000189285144-0x00000001892851C4
		public override bool Equals(object value) => default; // 0x00000001892851C4-0x0000000189285250
		public bool Equals(decimal value) => default; // 0x00000001833879E0-0x0000000183387A50
		public override int GetHashCode() => default; // 0x00000001892852D4-0x0000000189285320
		public override string ToString() => default; // 0x0000000189286620-0x00000001892866B4
		public string ToString(IFormatProvider provider) => default; // 0x00000001892864D8-0x000000018928657C
		public string ToString(string format, IFormatProvider provider) => default; // 0x000000018928657C-0x0000000189286620
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider provider = null) {
			charsWritten = default;
			return default;
		} // 0x0000000189286A58-0x0000000189286B10
		public static decimal Parse(string s, IFormatProvider provider) => default; // 0x000000018928553C-0x00000001892855F0
		public static decimal Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x0000000189285474-0x000000018928553C
		public static bool TryParse(string s, out decimal result) {
			result = default;
			return default;
		} // 0x0000000189286B10-0x0000000189286BA8
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out decimal result) {
			result = default;
			return default;
		} // 0x0000000189286BA8-0x0000000189286C60
		public static int[] GetBits(decimal d) => default; // 0x0000000189285250-0x00000001892852D4
		internal static ref decimal Max(ref decimal d1, ref decimal d2) => ref _refReturnTypeForMax; // 0x000000018928533C-0x0000000189285398
		private ref decimal _refReturnTypeForMax; // Dummy field
		internal static ref decimal Min(ref decimal d1, ref decimal d2) => ref _refReturnTypeForMin; // 0x0000000189285398-0x00000001892853F4
		private ref decimal _refReturnTypeForMin; // Dummy field
		public static decimal Multiply(decimal d1, decimal d2) => default; // 0x00000001892853F4-0x0000000189285474
		public static decimal Negate(decimal d) => default; // 0x0000000183D710B0-0x0000000183D710D0
		public static decimal Round(decimal d, int decimals) => default; // 0x00000001892855F0-0x0000000189285664
		private static decimal Round(ref decimal d, int decimals, MidpointRounding mode) => default; // 0x0000000189285664-0x0000000189285824
		public static byte ToByte(decimal value) => default; // 0x0000000189285E8C-0x0000000189285FF0
		[CLSCompliant(false)]
		public static sbyte ToSByte(decimal value) => default; // 0x0000000189286328-0x000000018928648C
		public static short ToInt16(decimal value) => default; // 0x000000018928603C-0x00000001892861A0
		public static double ToDouble(decimal d) => default; // 0x0000000189285FF0-0x000000018928603C
		public static int ToInt32(decimal d) => default; // 0x00000001892861A0-0x0000000189286264
		public static long ToInt64(decimal d) => default; // 0x0000000189286264-0x0000000189286328
		[CLSCompliant(false)]
		public static ushort ToUInt16(decimal value) => default; // 0x00000001892866B4-0x0000000189286818
		[CLSCompliant(false)]
		public static uint ToUInt32(decimal d) => default; // 0x0000000189286818-0x00000001892868CC
		[CLSCompliant(false)]
		public static ulong ToUInt64(decimal d) => default; // 0x00000001892868CC-0x0000000189286988
		public static float ToSingle(decimal d) => default; // 0x000000018928648C-0x00000001892864D8
		public static decimal Truncate(decimal d) => default; // 0x0000000189286A00-0x0000000189286A58
		private static void Truncate(ref decimal d) {} // 0x0000000189286988-0x0000000189286A00
		public static implicit operator decimal(byte value) => default; // 0x0000000183D71150-0x0000000183D71170
		[CLSCompliant(false)]
		public static implicit operator decimal(sbyte value) => default; // 0x0000000189287480-0x00000001892874AC
		public static implicit operator decimal(short value) => default; // 0x00000001892874AC-0x00000001892874D8
		[CLSCompliant(false)]
		public static implicit operator decimal(ushort value) => default; // 0x0000000183D71100-0x0000000183D71120
		public static implicit operator decimal(char value) => default; // 0x0000000183D71100-0x0000000183D71120
		public static implicit operator decimal(int value) => default; // 0x00000001835858F0-0x0000000183585920
		[CLSCompliant(false)]
		public static implicit operator decimal(uint value) => default; // 0x0000000183D71140-0x0000000183D71150
		public static implicit operator decimal(long value) => default; // 0x00000001836E5CF0-0x00000001836E5D10
		[CLSCompliant(false)]
		public static implicit operator decimal(ulong value) => default; // 0x0000000183D71120-0x0000000183D71140
		public static explicit operator decimal(float value) => default; // 0x000000018928709C-0x00000001892870BC
		public static explicit operator decimal(double value) => default; // 0x0000000189287308-0x0000000189287328
		public static explicit operator byte(decimal value) => default; // 0x0000000189287164-0x00000001892871B8
		[CLSCompliant(false)]
		public static explicit operator sbyte(decimal value) => default; // 0x00000001892870BC-0x0000000189287110
		public static explicit operator short(decimal value) => default; // 0x0000000189287260-0x00000001892872B4
		[CLSCompliant(false)]
		public static explicit operator ushort(decimal value) => default; // 0x00000001892872B4-0x0000000189287308
		public static explicit operator int(decimal value) => default; // 0x0000000189287328-0x000000018928737C
		[CLSCompliant(false)]
		public static explicit operator uint(decimal value) => default; // 0x0000000189287110-0x0000000189287164
		public static explicit operator long(decimal value) => default; // 0x0000000189287048-0x000000018928709C
		[CLSCompliant(false)]
		public static explicit operator ulong(decimal value) => default; // 0x00000001892871B8-0x000000018928720C
		public static explicit operator float(decimal value) => default; // 0x000000018928737C-0x00000001892873D0
		public static explicit operator double(decimal value) => default; // 0x000000018928720C-0x0000000189287260
		public static decimal operator -(decimal d) => default; // 0x0000000183D710B0-0x0000000183D710D0
		public static decimal operator ++(decimal d) => default; // 0x00000001892874D8-0x0000000189287560
		public static decimal operator +(decimal d1, decimal d2) => default; // 0x0000000189286EEC-0x0000000189286F70
		public static decimal operator -(decimal d1, decimal d2) => default; // 0x00000001892876E4-0x0000000189287768
		public static decimal operator *(decimal d1, decimal d2) => default; // 0x0000000189287664-0x00000001892876E4
		public static decimal operator /(decimal d1, decimal d2) => default; // 0x0000000189286F70-0x0000000189286FF0
		public static bool operator ==(decimal d1, decimal d2) => default; // 0x0000000189286FF0-0x0000000189287048
		public static bool operator !=(decimal d1, decimal d2) => default; // 0x0000000189287560-0x00000001892875B8
		public static bool operator <(decimal d1, decimal d2) => default; // 0x0000000189287610-0x0000000189287664
		public static bool operator <=(decimal d1, decimal d2) => default; // 0x00000001892875B8-0x0000000189287610
		public static bool operator >(decimal d1, decimal d2) => default; // 0x0000000189287428-0x0000000189287480
		public static bool operator >=(decimal d1, decimal d2) => default; // 0x00000001892873D0-0x0000000189287428
		public TypeCode GetTypeCode() => default; // 0x0000000183D55AE0-0x0000000183D55AF0
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000189285824-0x0000000189285884
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x00000001892858E4-0x0000000189285974
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000189285B84-0x0000000189285BE4
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000189285884-0x00000001892858E4
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000189285A64-0x0000000189285AC4
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000189285CD0-0x0000000189285D30
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000189285AC4-0x0000000189285B24
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000189285D30-0x0000000189285D90
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000189285B24-0x0000000189285B84
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000189285D90-0x0000000189285DF0
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000189285BE4-0x0000000189285C44
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000189285A04-0x0000000189285A64
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000183D5B250-0x0000000183D5B260
		System.DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000189285974-0x0000000189285A04
		object IConvertible.ToType(System.Type type, IFormatProvider provider) => default; // 0x0000000189285C44-0x0000000189285CD0
	}
}

namespace Unity
{
	internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 40359
	{
		// Constructors
		public ThrowStub() {} // Dummy constructor
	
		// Methods
		public static void ThrowNotSupportedException() {} // 0x0000000189236674-0x00000001892366C0
	}
}
