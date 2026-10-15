/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngineInternal;

// Image 118: UnityEngine.AssetBundleModule.dll - Assembly: UnityEngine.AssetBundleModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91024-91032

namespace UnityEngine
{
	[ExcludeFromPreset]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromMemoryAsyncOperation.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleUtility.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleUnloadAssetOperation.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleBatchLoadFromFileOperation.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleBatchLoadAssetOperation.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetUtility.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromFileAsyncOperation.h")]
	[NativeHeader("AssetBundleScriptingClasses.h")]
	[NativeHeader("Runtime/VirtualFileSystem/AssetBundleFileSystem/AssetBundleFileSystem.h")]
	[NativeHeader("Runtime/Scripting/ScriptingUtility.h")]
	[NativeHeader("Runtime/Scripting/ScriptingObjectWithIntPtrField.h")]
	[NativeHeader("Runtime/Scripting/ScriptingExportUtility.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromManagedStreamAsyncOperation.h")]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleSaveAndLoadHelper.h")]
	public class AssetBundle : Object // TypeDefIndex: 91025
	{
		// Fields
		public static AssetBundle[] BatchAssetBundleBuffer; // 0x00
		public static long[] BatchHashBuffer; // 0x08
		public static string[] BatchPathBuffer; // 0x10
		public static uint[] BatchCrcBuffer; // 0x18
		public static ulong[] BatchOffsetBuffer; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action onMissReferencedScript; // 0x28
		public static Func<long, string> hashToStringPath; // 0x30
		public static Func<long, bool> checkHashValid; // 0x38
		public static Action<string> addPathSting; // 0x40
	
		// Properties
		public static bool enableLazyCloseFile { [FreeFunction("GetAssetBundleFileSystem().SetEnableLazyCloseFile")] set; } // 0x0000000187179900-0x0000000187179940
		public static uint memoryBudgetKB { get; set; } // 0x000000018D4CBF7C-0x000000018D4CBF88 0x000000018D4CBF88-0x000000018D4CBF90
	
		// Constructors
		private AssetBundle(); // 0x000000018D4CBF3C-0x000000018D4CBF7C
		static AssetBundle(); // 0x0000000186F95170-0x0000000186F952E0
	
		// Methods
		[FreeFunction("UnloadAllAssetBundles")]
		public static void UnloadAllAssetBundles(bool unloadAllObjects); // 0x000000018D4CBD64-0x000000018D4CBD98
		[FreeFunction("GetAllAssetBundles")]
		internal static AssetBundle[] GetAllLoadedAssetBundles_Native(); // 0x000000018D4CB5A8-0x000000018D4CB5D4
		public static IEnumerable<AssetBundle> GetAllLoadedAssetBundles(); // 0x000000018D4CB5D4-0x000000018D4CB614
		public static void WaitForAllAsyncOperationsToComplete(); // 0x0000000185315D30-0x0000000185315D70
		[FreeFunction("WaitForAllAsyncOperationsToComplete")]
		internal static void WaitForAllAsyncOperationsToComplete_Internal(); // 0x0000000185315CF0-0x0000000185315D30
		[FreeFunction("GetAssetBundleBatchLoadFromFileIntegrateMaxCount")]
		private static int GetBatchLoadFromFileIntegrateMaxCount_Internal(); // 0x0000000186DFE1E0-0x0000000186DFE220
		private static T[] CreateBatchLoadFromFileBuffer<T>();
		[RequiredByNativeCode]
		internal static void InvokeOnMissReferencedScriptOnBehaviour(); // 0x000000018D4CB6A4-0x000000018D4CB6F8
		[FreeFunction("GetAssetBundleFileSystem().TryCloseLazyCloseFile")]
		internal static bool TryCloseLazyCloseFile_Internal(bool force); // 0x000000018D4CBCE4-0x000000018D4CBD18
		public static bool TryCloseLazyCloseFile(bool force); // 0x000000018D4CBD18-0x000000018D4CBD64
		[RequiredByNativeCode]
		internal static string HashToStringPath(long hash); // 0x000000018D4CB614-0x000000018D4CB6A4
		[RequiredByNativeCode]
		internal static bool CheckHashValid(long hash); // 0x000000018D4CB51C-0x000000018D4CB5A8
		[RequiredByNativeCode]
		internal static void AddPathStringToCSharp(string path); // 0x000000018D4CB4C0-0x000000018D4CB51C
		[FreeFunction("LoadFromFileAsync")]
		internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset); // 0x0000000184F91350-0x0000000184F913B0
		public static AssetBundleCreateRequest LoadFromFileAsync(string path); // 0x000000018D4CB9D8-0x000000018D4CBA28
		public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc, ulong offset); // 0x0000000184F912D0-0x0000000184F91350
		[FreeFunction("LoadFromFile")]
		internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset); // 0x0000000185E45AD0-0x0000000185E45B30
		public static AssetBundle LoadFromFile(string path); // 0x000000018D4CBA28-0x000000018D4CBA78
		public static AssetBundle LoadFromFile(string path, uint crc, ulong offset); // 0x0000000185E45A50-0x0000000185E45AD0
		[FreeFunction("LoadFromMemoryAsync")]
		internal static AssetBundleCreateRequest LoadFromMemoryAsync_Internal(byte[] binary, uint crc); // 0x000000018D4CBA78-0x000000018D4CBAB8
		public static AssetBundleCreateRequest LoadFromMemoryAsync(byte[] binary); // 0x000000018D4CBAB8-0x000000018D4CBB04
		public T LoadAsset<T>(string name)
			where T : Object;
		public Object LoadAsset(long hash, System.Type type); // 0x0000000187835A64-0x0000000187835A70
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		public Object LoadAsset(string name, System.Type type); // 0x000000018D4CB8BC-0x000000018D4CB9D8
		[NativeMethod("LoadAsset_Internal")]
		[NativeThrows]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		private Object LoadAsset_Internal(string name, System.Type type); // 0x000000018D4CB868-0x000000018D4CB8BC
		[NativeMethod("LoadAssetByHash_Internal")]
		[NativeThrows]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		private Object LoadAssetByHash_Internal(long hash, System.Type type); // 0x0000000185318B30-0x0000000185318B90
		public AssetBundleRequest LoadAssetAsync<T>(string name);
		public AssetBundleRequest LoadAssetAsync(string name, System.Type type); // 0x000000018D4CB74C-0x000000018D4CB868
		public AssetBundleRequest LoadAssetAsync(long hash, System.Type type); // 0x00000001853184B0-0x0000000185318520
		public AssetBundleRequest LoadSubAssetAsync(string name, long subAssetInstanceID, System.Type type); // 0x000000018D4CBB68-0x000000018D4CBCE4
		[NativeMethod("LoadAssetAsync_Internal")]
		[NativeThrows]
		private AssetBundleRequest LoadAssetAsync_Internal(string name, System.Type type); // 0x000000018D4CB6F8-0x000000018D4CB74C
		[NativeMethod("LoadAssetAsyncByHash_Internal")]
		[NativeThrows]
		private AssetBundleRequest LoadAssetAsyncByHash_Internal(long hash, System.Type type); // 0x0000000185318520-0x0000000185318580
		[NativeMethod("Unload")]
		[NativeThrows]
		public void Unload(bool unloadAllLoadedObjects); // 0x0000000185F4C990-0x0000000185F4C9E0
		[NativeMethod("UnloadAsync")]
		[NativeThrows]
		public AsyncOperation UnloadAsync(bool unloadAllLoadedObjects); // 0x000000018D4CBEF8-0x000000018D4CBF3C
		public void UnloadAsset(Object asset); // 0x000000018D4CBE94-0x000000018D4CBEF8
		public AsyncOperation UnloadAssetAsync(Object asset); // 0x000000018D4CBDDC-0x000000018D4CBE50
		[NativeMethod("UnloadAsset_Internal")]
		[NativeThrows]
		private void UnloadAsset_Internal(Object asset); // 0x000000018D4CBE50-0x000000018D4CBE94
		[NativeMethod("UnloadAssetAsync_Internal")]
		[NativeThrows]
		private AsyncOperation UnloadAssetAsync_Internal(Object asset); // 0x000000018D4CBD98-0x000000018D4CBDDC
		[NativeMethod("LoadSubAssetAsync_Internal")]
		[NativeThrows]
		internal AssetBundleRequest LoadSubAssetAsync_Internal(string name, long instanceID, System.Type type); // 0x000000018D4CBB04-0x000000018D4CBB68
	}

	[NativeHeader("Modules/AssetBundle/Public/AssetBundleBatchLoadFromFileOperation.h")]
	[RequiredByNativeCode]
	public class AssetBundleBatchCreateRequest : AsyncOperation // TypeDefIndex: 91026
	{
	}

	[NativeHeader("Modules/AssetBundle/Public/AssetBundleBatchLoadAssetOperation.h")]
	[RequiredByNativeCode]
	public class AssetBundleBatchRequest : AsyncOperation // TypeDefIndex: 91027
	{
	}

	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromAsyncOperation.h")]
	[RequiredByNativeCode]
	public class AssetBundleCreateRequest : AsyncOperation // TypeDefIndex: 91028
	{
		// Properties
		public AssetBundle assetBundle { [NativeMethod("GetAssetBundleBlocking")] get; } // 0x0000000185317720-0x0000000185317760 
	
		// Constructors
		public AssetBundleCreateRequest(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadingCache.h")]
	[UsedByNativeCode]
	public static class AssetBundleLoadingCache // TypeDefIndex: 91029
	{
		// Properties
		internal static uint maxBlocksPerFile { get; set; } // 0x000000018D4CB494-0x000000018D4CB4C0 0x0000000186E1B3F0-0x0000000186E1B430
		internal static uint blockCount { get; set; } // 0x0000000186E1B370-0x0000000186E1B3B0 0x0000000186E1B3B0-0x0000000186E1B3F0
		internal static uint blockSize { get; } // 0x0000000186E1B260-0x0000000186E1B2A0 
		internal static uint memoryBudgetKB { get; set; } // 0x0000000186E1B240-0x0000000186E1B260 0x0000000186E1B2A0-0x0000000186E1B370
	}

	[NativeHeader("Modules/AssetBundle/Public/AssetBundleRecompressOperation.h")]
	[RequiredByNativeCode]
	public class AssetBundleRecompressOperation : AsyncOperation // TypeDefIndex: 91030
	{
	}

	[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
	[RequiredByNativeCode]
	public class AssetBundleRequest : ResourceRequest // TypeDefIndex: 91031
	{
		// Properties
		public Object asset { get; } // 0x0000000187835A70-0x0000000187835A80 
	
		// Constructors
		public AssetBundleRequest(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[NativeMethod("GetLoadedAsset")]
		protected override Object GetResult(); // 0x00000001859E5A40-0x00000001859E5A80
	}
}

namespace UnityEngine.Experimental.AssetBundlePatching
{
	[NativeHeader("Modules/AssetBundle/Public/AssetBundlePatching.h")]
	public static class AssetBundleUtility // TypeDefIndex: 91032
	{
		// Methods
		[StaticAccessor("CompressionExport", StaticAccessorType.DoubleColon)]
		[ThreadSafe]
		public static unsafe int LZ4Decompress(void* src, int srcSize, void* dst, int dstSize); // 0x000000018571A6B0-0x000000018571A720
		public static int LZ4Decompress(byte[] src, int srcOffset, int srcSize, byte[] dst, int dstOffset, int dstSize); // 0x000000018571A630-0x000000018571A6B0
	}
}
