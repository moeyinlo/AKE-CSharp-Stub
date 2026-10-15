/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 148: Hypergryph.DownloadSDK.dll - Assembly: Hypergryph.DownloadSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91339-91342

namespace Hypergryph.SDK
{
	public interface IHGDownloadSDK // TypeDefIndex: 91340
	{
		// Methods
		int init(string config);
		long download(string versionId, string downloadFiles, string decompressPath, bool useMobileData, bool needCompress, bool usePatch, string rootPath);
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
		long getEstimatedUpdateSizeV3(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo);
		long updateV5(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo, bool useMobileData, int checkType, string allFiles, int preCheckType, bool onlyPatch);
		int getCheckProgress(long taskId);
	}

	public static class HGDownloadSDK // TypeDefIndex: 91341
	{
		// Fields
		private static IHGDownloadSDK s_dl; // 0x00
	
		// Properties
		private static IHGDownloadSDK downloadSDK { get; } // 0x0000000186220C00-0x0000000186220CA0 
	
		// Methods
		public static int Init(string config); // 0x00000001862205F0-0x0000000186220640
		public static long Download(string versionId, string downloadFiles, bool useMobileData, string decompressPath, bool needCompress, bool usePatch, string rootPath); // 0x000000018C223D84-0x000000018C223E54
		public static int ClearUselessFiles(string rootPath, string allFiles); // 0x0000000186220640-0x0000000186220690
		public static int EnableMobileData(long taskId); // 0x000000018C223E54-0x000000018C223EA0
		public static int Resume(long taskId); // 0x000000018C223F68-0x000000018C22414C
		public static int Cancel(long taskId); // 0x000000018C223D2C-0x000000018C223D84
		public static int ClearAllTasks(); // 0x0000000186220690-0x00000001862206D0
		public static int Finish(long taskId); // 0x0000000186220520-0x0000000186220570
		public static int GetSDKState(); // 0x00000001862206D0-0x0000000186220710
		public static int GetTaskState(long taskId); // 0x0000000186220BB0-0x0000000186220C00
		public static string GetTaskInfo(long taskId); // 0x000000018C223F08-0x000000018C223F68
		public static long GetDownloadSpeed(long taskId); // 0x0000000186220A00-0x0000000186220A50
		public static long GetDownloadedSize(long taskId); // 0x0000000186220960-0x00000001862209B0
		public static long GetTotalDownloadSize(long taskId); // 0x00000001862209B0-0x0000000186220A00
		public static int GetDecompressedProgress(long taskId); // 0x00000001862207B0-0x0000000186220800
		public static int SetLanguageType(int type); // 0x0000000186220570-0x00000001862205B0
		public static int SetNotificationTitle(string title); // 0x00000001862205B0-0x00000001862205F0
		public static long GetEstimatedDownloadSize(string versionId, string downloadFiles); // 0x000000018C223EA0-0x000000018C223F08
		public static long GetEstimatedUpdateSizeV3(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo); // 0x000000018491C2B0-0x000000018491C430
		public static long UpdateV5(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo, bool useMobileData, int checkType, string allFiles, int preCheckType, bool onlyPatch); // 0x000000018491C430-0x000000018491C640
		public static int GetCheckProgress(long taskId); // 0x000000018491C1F0-0x000000018491C2B0
	}

	public class HGDownloadSDKPluginWindows : IHGDownloadSDK // TypeDefIndex: 91342
	{
		// Constructors
		public HGDownloadSDKPluginWindows(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static extern int HGDLSDKInit(string config); // 0x0000000185AFCF90-0x0000000185AFD040
		public static extern long HGDLSDKDownloadWithPatch(string version_id, string download_files, string decompress_path, bool need_decompress, bool use_patch, string root_path); // 0x000000018C22397C-0x000000018C223A94
		public static extern int HGDLSDKClearAllTasks(); // 0x0000000185AFDA10-0x0000000185AFDA80
		public static extern int HGDLSDKGetSDKState(); // 0x0000000185AFD9A0-0x0000000185AFDA10
		public static extern int HGDLSDKGetTaskState(long task_id); // 0x0000000185AFDCD0-0x0000000185AFDD00
		public static extern int HGDLSDKResume(long task_id); // 0x000000018C223C04-0x000000018C223C38
		public static extern int HGDLSDKCancel(long task_id); // 0x000000018C223948-0x000000018C22397C
		public static extern int HGDLSDKFinish(long task_id); // 0x0000000185AFDC90-0x0000000185AFDCD0
		public static extern IntPtr HGDLSDKGetTaskInfo(long task_id); // 0x000000018C223BC8-0x000000018C223C04
		public static extern long HGDLSDKGetDownloadSpeed(long task_id); // 0x0000000185AFD920-0x0000000185AFD9A0
		public static extern long HGDLSDKGetDownloadedSize(long task_id); // 0x0000000185AFD8A0-0x0000000185AFD920
		public static extern long HGDLSDKGetTotalDownloadSize(long task_id); // 0x0000000185AFD820-0x0000000185AFD8A0
		public static extern int HGDLSDKGetDecompressedProgress(long task_id); // 0x0000000185AFDC60-0x0000000185AFDC90
		public static extern long HGDLSDKGetEstimatedDownloadSize(string version_id, string download_files); // 0x000000018C223B0C-0x000000018C223BC8
		public static extern void HGDLSDKFree(IntPtr pointer); // 0x000000018C223A94-0x000000018C223B0C
		public static extern int HGDLSDKClearUselessFiles(string root_path, string all_files); // 0x0000000185AFD750-0x0000000185AFD820
		public static extern long HGDLSDKGetEstimatedUpdateSizeV3(string version_id, string base_paths, string root_path, string file_url_prefix, string patch_url_prefixm, string total_files, string patch_info); // 0x000000018491B200-0x000000018491B8B0
		public static extern long HGDLSDKUpdateV5(string version_id, string base_paths, string root_path, string file_url_prefix, string patch_url_prefix, string total_files, string patch_info, bool use_mobile_data, int check_type, int pre_check_type, bool only_patch, string all_files); // 0x000000018491B8B0-0x000000018491C070
		public static extern int HGDLSDKGetCheckProgress(long task_id); // 0x000000018491B180-0x000000018491B200
		public int init(string config); // 0x000000018783BC60-0x000000018783BC6C
		public long download(string versionId, string downloadFiles, string decompressPath, bool useMobileData, bool needCompress, bool usePatch, string rootPath); // 0x000000018C223C44-0x000000018C223C8C
		public int enableMobileData(long taskId); // 0x0000000185829EC0-0x0000000185829ED0
		public int resume(long taskId); // 0x000000018C223D20-0x000000018C223D2C
		public int cancel(long taskId); // 0x000000018C223C38-0x000000018C223C44
		public int clearAllTasks(); // 0x000000018783BC6C-0x000000018783BC74
		public int finish(long taskId); // 0x000000018783BC54-0x000000018783BC60
		public int getSDKState(); // 0x000000018783BC74-0x000000018783BC7C
		public int getTaskState(long taskId); // 0x000000018783BCAC-0x000000018783BCB8
		public string getTaskInfo(long taskId); // 0x000000018C223CA0-0x000000018C223D20
		public long getDownloadSpeed(long taskId); // 0x000000018783BCA0-0x000000018783BCAC
		public long getDownloadedSize(long taskId); // 0x000000018783BC88-0x000000018783BC94
		public long getTotalDownloadSize(long taskId); // 0x000000018783BC94-0x000000018783BCA0
		public int getDecompressedProgress(long taskId); // 0x000000018783BC7C-0x000000018783BC88
		public int setLanguageType(int type); // 0x0000000185829EC0-0x0000000185829ED0
		public int setNotificationTitle(string title); // 0x0000000185829EC0-0x0000000185829ED0
		public long getEstimatedDownloadSize(string versionId, string downloadFiles); // 0x000000018C223C8C-0x000000018C223CA0
		public int clearUselessFiles(string rootPath, string allFiles); // 0x000000018783BC40-0x000000018783BC54
		public long getEstimatedUpdateSizeV3(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo); // 0x000000018491C0F0-0x000000018491C150
		public long updateV5(string versionId, string basePath, string rootPath, string fileUrl, string patchUrl, string totalFiles, string patchInfo, bool useMobileData, int checkType, string allFiles, int preCheckType, bool onlyPatch); // 0x000000018491C150-0x000000018491C1F0
		public int getCheckProgress(long taskId); // 0x000000018491C070-0x000000018491C0F0
	}
}
