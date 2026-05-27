/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 144: Hypergryph.DownloadSDK.dll - Assembly: Hypergryph.DownloadSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60144-60147
[assembly: CompilationRelaxations(8)]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Hypergryph.SDK
{
	public interface IHGDownloadSDK // TypeDefIndex: 60145
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
}
