/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 148: Hypergryph.DownloadSDK.dll - Assembly: Hypergryph.DownloadSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63868-63871
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Hypergryph.SDK
{
	public interface IHGDownloadSDK // TypeDefIndex: 63869
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

	public static class HGDownloadSDK // TypeDefIndex: 63870
	{
		// Fields
		private static IHGDownloadSDK s_dl; // 0x00
	
		// Properties
		private static IHGDownloadSDK downloadSDK { get; } // 0x000000018480A7A0-0x000000018480A840 
	
		// Methods
		public static int Init(string config); // 0x000000018480A750-0x000000018480A7A0
		public static long Download(string versionId, string downloadFiles, bool useMobileData, string decompressPath, bool needCompress, bool usePatch, string rootPath); // 0x0000000189DDC8B4-0x0000000189DDC980
		public static long UpdateV3(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo, bool useMobileData, int checkType); // 0x0000000189DDCE98-0x0000000189DDD0C0
		public static int ClearUselessFiles(string rootPath, string allFiles); // 0x0000000189DDC858-0x0000000189DDC8B4
		public static int EnableMobileData(long taskId); // 0x0000000189DDC980-0x0000000189DDC9CC
		public static int Resume(long taskId); // 0x0000000189DDCDA8-0x0000000189DDCE00
		public static int Cancel(long taskId); // 0x0000000189DDC7B4-0x0000000189DDC80C
		public static int ClearAllTasks(); // 0x0000000189DDC80C-0x0000000189DDC858
		public static int Finish(long taskId); // 0x0000000189DDC9CC-0x0000000189DDCA24
		public static int GetSDKState(); // 0x0000000189DDCC5C-0x0000000189DDCCA8
		public static int GetTaskState(long taskId); // 0x0000000189DDCCF8-0x0000000189DDCD50
		public static string GetTaskInfo(long taskId); // 0x0000000189DDCCA8-0x0000000189DDCCF8
		public static long GetDownloadSpeed(long taskId); // 0x0000000189DDCA7C-0x0000000189DDCAD4
		public static long GetDownloadedSize(long taskId); // 0x0000000189DDCAD4-0x0000000189DDCB2C
		public static long GetTotalDownloadSize(long taskId); // 0x0000000189DDCD50-0x0000000189DDCDA8
		public static int GetDecompressedProgress(long taskId); // 0x0000000189DDCA24-0x0000000189DDCA7C
		public static int SetLanguageType(int type); // 0x0000000189DDCE00-0x0000000189DDCE4C
		public static int SetNotificationTitle(string title); // 0x0000000189DDCE4C-0x0000000189DDCE98
		public static long GetEstimatedDownloadSize(string versionId, string downloadFiles); // 0x0000000189DDCB2C-0x0000000189DDCB88
		public static long GetEstimatedUpdateSizeV2(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo); // 0x0000000189DDCB88-0x0000000189DDCC5C
	}

	public class HGDownloadSDKPluginWindows : IHGDownloadSDK // TypeDefIndex: 63871
	{
		// Constructors
		public HGDownloadSDKPluginWindows(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static extern int HGDLSDKInit(string config); // 0x0000000183826EB0-0x0000000183826F60
		public static extern long HGDLSDKDownloadWithPatch(string version_id, string download_files, string decompress_path, bool need_decompress, bool use_patch, string root_path); // 0x0000000189DDBE10-0x0000000189DDBF28
		public static extern int HGDLSDKClearAllTasks(); // 0x0000000189DDBD58-0x0000000189DDBD8C
		public static extern int HGDLSDKGetSDKState(); // 0x0000000189DDC2E0-0x0000000189DDC314
		public static extern int HGDLSDKGetTaskState(long task_id); // 0x0000000189DDC350-0x0000000189DDC3C8
		public static extern int HGDLSDKResume(long task_id); // 0x0000000189DDC404-0x0000000189DDC438
		public static extern int HGDLSDKCancel(long task_id); // 0x0000000189DDBD24-0x0000000189DDBD58
		public static extern int HGDLSDKFinish(long task_id); // 0x0000000189DDBF28-0x0000000189DDBF5C
		public static extern IntPtr HGDLSDKGetTaskInfo(long task_id); // 0x0000000189DDC314-0x0000000189DDC350
		public static extern long HGDLSDKGetDownloadSpeed(long task_id); // 0x0000000189DDC04C-0x0000000189DDC088
		public static extern long HGDLSDKGetDownloadedSize(long task_id); // 0x0000000189DDC088-0x0000000189DDC0C4
		public static extern long HGDLSDKGetTotalDownloadSize(long task_id); // 0x0000000189DDC3C8-0x0000000189DDC404
		public static extern int HGDLSDKGetDecompressedProgress(long task_id); // 0x0000000189DDBFD4-0x0000000189DDC04C
		public static extern long HGDLSDKGetEstimatedDownloadSize(string version_id, string download_files); // 0x0000000189DDC0C4-0x0000000189DDC180
		public static extern void HGDLSDKFree(IntPtr pointer); // 0x0000000189DDBF5C-0x0000000189DDBFD4
		public static extern int HGDLSDKClearUselessFiles(string root_path, string all_files); // 0x0000000189DDBD8C-0x0000000189DDBE10
		public static extern long HGDLSDKGetEstimatedUpdateSizeV2(string version_id, string base_paths, string root_path, string file_url_prefix, string patch_url_prefixm, string total_files, string patch_info); // 0x0000000189DDC180-0x0000000189DDC2E0
		public static extern long HGDLSDKUpdateV3(string version_id, string base_paths, string root_path, string file_url_prefix, string patch_url_prefix, string total_files, string patch_info, int check_type); // 0x0000000189DDC438-0x0000000189DDC5A4
		public int init(string config); // 0x0000000185397CA8-0x0000000185397CB4
		public long download(string versionId, string downloadFiles, string decompressPath, bool useMobileData, bool needCompress, bool usePatch, string rootPath); // 0x0000000189DDC5CC-0x0000000189DDC614
		public int enableMobileData(long taskId); // 0x00000001811EC580-0x00000001811EC590
		public int resume(long taskId); // 0x0000000189DDC748-0x0000000189DDC754
		public int cancel(long taskId); // 0x0000000189DDC5A4-0x0000000189DDC5B0
		public int clearAllTasks(); // 0x0000000189DDC5B0-0x0000000189DDC5B8
		public int finish(long taskId); // 0x0000000189DDC614-0x0000000189DDC620
		public int getSDKState(); // 0x0000000189DDC6A8-0x0000000189DDC6B0
		public int getTaskState(long taskId); // 0x0000000189DDC730-0x0000000189DDC73C
		public string getTaskInfo(long taskId); // 0x0000000189DDC6B0-0x0000000189DDC730
		public long getDownloadSpeed(long taskId); // 0x0000000189DDC62C-0x0000000189DDC638
		public long getDownloadedSize(long taskId); // 0x0000000189DDC638-0x0000000189DDC644
		public long getTotalDownloadSize(long taskId); // 0x0000000189DDC73C-0x0000000189DDC748
		public int getDecompressedProgress(long taskId); // 0x0000000189DDC620-0x0000000189DDC62C
		public int setLanguageType(int type); // 0x00000001811EC580-0x00000001811EC590
		public int setNotificationTitle(string title); // 0x00000001811EC580-0x00000001811EC590
		public long getEstimatedDownloadSize(string versionId, string downloadFiles); // 0x0000000189DDC644-0x0000000189DDC658
		public int clearUselessFiles(string rootPath, string allFiles); // 0x0000000189DDC5B8-0x0000000189DDC5CC
		public long getEstimatedUpdateSizeV2(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo); // 0x0000000189DDC658-0x0000000189DDC6A8
		public long updateV3(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo, bool useMobileData, int checkType); // 0x0000000189DDC754-0x0000000189DDC7B4
	}
}
