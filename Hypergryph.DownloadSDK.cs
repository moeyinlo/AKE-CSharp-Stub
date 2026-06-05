/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;

// Image 146: Hypergryph.DownloadSDK.dll - Assembly: Hypergryph.DownloadSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61229-61232

namespace Hypergryph.SDK
{
	public interface IHGDownloadSDK // TypeDefIndex: 61230
	{
		// Methods
		int init(string config);
		long download(string versionId, string downloadFiles, string decompressPath, bool useMobileData, bool needCompress, bool usePatch, string rootPath);
		long updateV3(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo, bool useMobileData, int checkType);
		int clearUselessFiles(string rootPath, string allFiles);
		int enableMobileData(long taskId);
		int resume(long taskId);
		int cancel(long taskId);
		int clearAllTasks();
		int finish(long taskId);
		int getSDKState();
		int getTaskState(long taskId);
		string getTaskInfo(long taskId);
		long getDownloadSpeed(long taskId);
		long getDownloadedSize(long taskId);
		long getTotalDownloadSize(long taskId);
		int getDecompressedProgress(long taskId);
		int setLanguageType(int type);
		int setNotificationTitle(string title);
		long getEstimatedDownloadSize(string versionId, string downloadFiles);
		long getEstimatedUpdateSizeV2(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo);
	}

	public static class HGDownloadSDK // TypeDefIndex: 61231
	{
		// Fields
		private static IHGDownloadSDK s_dl; // 0x00
	
		// Properties
		private static IHGDownloadSDK downloadSDK { get; } // 0x0000000184FA91E0-0x0000000184FA9280 
	
		// Methods
		public static int Init(string config) => default; // 0x0000000184FA9170-0x0000000184FA91E0
		public static long Download(string versionId, string downloadFiles, bool useMobileData, string decompressPath, bool needCompress, bool usePatch, string rootPath) => default; // 0x000000018A97CC54-0x000000018A97CCD4
		public static long UpdateV3(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo, bool useMobileData, int checkType) => default; // 0x000000018A97D384-0x000000018A97DE48
		public static int ClearUselessFiles(string rootPath, string allFiles) => default; // 0x000000018A97CBCC-0x000000018A97CC54
		public static int EnableMobileData(long taskId) => default; // 0x000000018A97CCD4-0x000000018A97CD48
		public static int Resume(long taskId) => default; // 0x000000018A97D220-0x000000018A97D29C
		public static int Cancel(long taskId) => default; // 0x000000018A97CAE0-0x000000018A97CB5C
		public static int ClearAllTasks() => default; // 0x000000018A97CB5C-0x000000018A97CBCC
		public static int Finish(long taskId) => default; // 0x000000018A97CD48-0x000000018A97CDC4
		public static int GetSDKState() => default; // 0x000000018A97D044-0x000000018A97D0B4
		public static int GetTaskState(long taskId) => default; // 0x000000018A97D128-0x000000018A97D1A4
		public static string GetTaskInfo(long taskId) => default; // 0x000000018A97D0B4-0x000000018A97D128
		public static long GetDownloadSpeed(long taskId) => default; // 0x000000018A97CE40-0x000000018A97CEBC
		public static long GetDownloadedSize(long taskId) => default; // 0x000000018A97CEBC-0x000000018A97CF38
		public static long GetTotalDownloadSize(long taskId) => default; // 0x000000018A97D1A4-0x000000018A97D220
		public static int GetDecompressedProgress(long taskId) => default; // 0x000000018A97CDC4-0x000000018A97CE40
		public static int SetLanguageType(int type) => default; // 0x000000018A97D29C-0x000000018A97D310
		public static int SetNotificationTitle(string title) => default; // 0x000000018A97D310-0x000000018A97D384
		public static long GetEstimatedDownloadSize(string versionId, string downloadFiles) => default; // 0x000000018A97CF38-0x000000018A97CFC0
		public static long GetEstimatedUpdateSizeV2(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo) => default; // 0x000000018A97CFC0-0x000000018A97D044
	}

	public class HGDownloadSDKPluginWindows : IHGDownloadSDK // TypeDefIndex: 61232
	{
		// Constructors
		public HGDownloadSDKPluginWindows() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static extern int HGDLSDKInit(string config); // 0x00000001844CE360-0x00000001844CE410
		public static extern long HGDLSDKDownloadWithPatch(string version_id, string download_files, string decompress_path, bool need_decompress, bool use_patch, string root_path); // 0x000000018A97C13C-0x000000018A97C254
		public static extern int HGDLSDKClearAllTasks(); // 0x000000018A97C084-0x000000018A97C0B8
		public static extern int HGDLSDKGetSDKState(); // 0x000000018A97C60C-0x000000018A97C640
		public static extern int HGDLSDKGetTaskState(long task_id); // 0x000000018A97C67C-0x000000018A97C6F4
		public static extern int HGDLSDKResume(long task_id); // 0x000000018A97C730-0x000000018A97C764
		public static extern int HGDLSDKCancel(long task_id); // 0x000000018A97C050-0x000000018A97C084
		public static extern int HGDLSDKFinish(long task_id); // 0x000000018A97C254-0x000000018A97C288
		public static extern IntPtr HGDLSDKGetTaskInfo(long task_id); // 0x000000018A97C640-0x000000018A97C67C
		public static extern long HGDLSDKGetDownloadSpeed(long task_id); // 0x000000018A97C378-0x000000018A97C3B4
		public static extern long HGDLSDKGetDownloadedSize(long task_id); // 0x000000018A97C3B4-0x000000018A97C3F0
		public static extern long HGDLSDKGetTotalDownloadSize(long task_id); // 0x000000018A97C6F4-0x000000018A97C730
		public static extern int HGDLSDKGetDecompressedProgress(long task_id); // 0x000000018A97C300-0x000000018A97C378
		public static extern long HGDLSDKGetEstimatedDownloadSize(string version_id, string download_files); // 0x000000018A97C3F0-0x000000018A97C4AC
		public static extern void HGDLSDKFree(IntPtr pointer); // 0x000000018A97C288-0x000000018A97C300
		public static extern int HGDLSDKClearUselessFiles(string root_path, string all_files); // 0x000000018A97C0B8-0x000000018A97C13C
		public static extern long HGDLSDKGetEstimatedUpdateSizeV2(string version_id, string base_paths, string root_path, string file_url_prefix, string patch_url_prefixm, string total_files, string patch_info); // 0x000000018A97C4AC-0x000000018A97C60C
		public static extern long HGDLSDKUpdateV3(string version_id, string base_paths, string root_path, string file_url_prefix, string patch_url_prefix, string total_files, string patch_info, int check_type); // 0x000000018A97C764-0x000000018A97C8D0
		public int init(string config) => default; // 0x0000000186473028-0x0000000186473034
		public long download(string versionId, string downloadFiles, string decompressPath, bool useMobileData, bool needCompress, bool usePatch, string rootPath) => default; // 0x000000018A97C8F8-0x000000018A97C940
		public int enableMobileData(long taskId) => default; // 0x00000001813AE580-0x00000001813AE590
		public int resume(long taskId) => default; // 0x000000018A97CA74-0x000000018A97CA80
		public int cancel(long taskId) => default; // 0x000000018A97C8D0-0x000000018A97C8DC
		public int clearAllTasks() => default; // 0x000000018A97C8DC-0x000000018A97C8E4
		public int finish(long taskId) => default; // 0x000000018A97C940-0x000000018A97C94C
		public int getSDKState() => default; // 0x000000018A97C9D4-0x000000018A97C9DC
		public int getTaskState(long taskId) => default; // 0x000000018A97CA5C-0x000000018A97CA68
		public string getTaskInfo(long taskId) => default; // 0x000000018A97C9DC-0x000000018A97CA5C
		public long getDownloadSpeed(long taskId) => default; // 0x000000018A97C958-0x000000018A97C964
		public long getDownloadedSize(long taskId) => default; // 0x000000018A97C964-0x000000018A97C970
		public long getTotalDownloadSize(long taskId) => default; // 0x000000018A97CA68-0x000000018A97CA74
		public int getDecompressedProgress(long taskId) => default; // 0x000000018A97C94C-0x000000018A97C958
		public int setLanguageType(int type) => default; // 0x00000001813AE580-0x00000001813AE590
		public int setNotificationTitle(string title) => default; // 0x00000001813AE580-0x00000001813AE590
		public long getEstimatedDownloadSize(string versionId, string downloadFiles) => default; // 0x000000018A97C970-0x000000018A97C984
		public int clearUselessFiles(string rootPath, string allFiles) => default; // 0x000000018A97C8E4-0x000000018A97C8F8
		public long getEstimatedUpdateSizeV2(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo) => default; // 0x000000018A97C984-0x000000018A97C9D4
		public long updateV3(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo, bool useMobileData, int checkType) => default; // 0x000000018A97CA80-0x000000018A97CAE0
	}
}
