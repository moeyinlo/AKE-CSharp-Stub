/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;

// Image 119: UnityEngine.AssetBundleModule.dll - Assembly: UnityEngine.AssetBundleModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60984-60990

namespace UnityEngine
{
	public class AssetBundle : Object // TypeDefIndex: 60985
	{
		// Fields
		private static Action onMissReferencedScript; // 0x00
		public static Func<long, string> hashToStringPath; // 0x08
		public static Func<long, bool> checkHashValid; // 0x10
		public static Action<string> addPathSting; // 0x18
	
		// Properties
		public static bool enableLazyCloseFile { set {} } // 0x0000000185F61CB0-0x0000000185F61CF0
		public static uint memoryBudgetKB { get => default; set {} } // 0x000000018BEAF980-0x000000018BEAF98C 0x000000018BEAF98C-0x000000018BEAF994
	
		// Constructors
		private AssetBundle() {} // 0x000000018BEAF940-0x000000018BEAF980
	
		// Methods
		public static void UnloadAllAssetBundles(bool unloadAllObjects) {} // 0x000000018BEAF8C8-0x000000018BEAF8FC
		internal static AssetBundle[] GetAllLoadedAssetBundles_Native() => default; // 0x000000018BEAF27C-0x000000018BEAF2A8
		public static IEnumerable<AssetBundle> GetAllLoadedAssetBundles() => default; // 0x000000018BEAF2A8-0x000000018BEAF2B4
		public static void WaitForAllAsyncOperationsToComplete() {} // 0x000000018646F048-0x000000018646F050
		internal static void WaitForAllAsyncOperationsToComplete_Internal() {} // 0x0000000185FA7580-0x0000000185FA75C0
		internal static void InvokeOnMissReferencedScriptOnBehaviour() {} // 0x000000018BEAF318-0x000000018BEAF35C
		internal static bool TryCloseLazyCloseFile_Internal(bool force) => default; // 0x000000018BEAF888-0x000000018BEAF8BC
		public static bool TryCloseLazyCloseFile(bool force) => default; // 0x000000018BEAF8BC-0x000000018BEAF8C8
		internal static string HashToStringPath(long hash) => default; // 0x000000018BEAF2B4-0x000000018BEAF318
		internal static bool CheckHashValid(long hash) => default; // 0x000000018BEAF220-0x000000018BEAF27C
		internal static void AddPathStringToCSharp(string path) {} // 0x000000018BEAF1D0-0x000000018BEAF220
		internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) => default; // 0x0000000184EBAB10-0x0000000184EBAB70
		public static AssetBundleCreateRequest LoadFromFileAsync(string path) => default; // 0x000000018BEAF63C-0x000000018BEAF64C
		public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc, ulong offset) => default; // 0x000000018646E450-0x000000018646E45C
		internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset) => default; // 0x000000018508B390-0x000000018508B490
		public static AssetBundle LoadFromFile(string path) => default; // 0x000000018BEAF64C-0x000000018BEAF65C
		public static AssetBundle LoadFromFile(string path, uint crc, ulong offset) => default; // 0x000000018646F0D8-0x000000018646F0E4
		internal static AssetBundleCreateRequest LoadFromMemoryAsync_Internal(byte[] binary, uint crc) => default; // 0x000000018BEAF65C-0x000000018BEAF69C
		public static AssetBundleCreateRequest LoadFromMemoryAsync(byte[] binary) => default; // 0x000000018BEAF69C-0x000000018BEAF6A8
		public T LoadAsset<T>(string name)
			where T : Object => default;
		public Object LoadAsset(long hash, System.Type type) => default; // 0x000000018646F0CC-0x000000018646F0D8
		public Object LoadAsset(string name, System.Type type) => default; // 0x000000018BEAF520-0x000000018BEAF63C
		private Object LoadAsset_Internal(string name, System.Type type) => default; // 0x000000018BEAF4CC-0x000000018BEAF520
		private Object LoadAssetByHash_Internal(long hash, System.Type type) => default; // 0x00000001844EE290-0x00000001844EE2F0
		public AssetBundleRequest LoadAssetAsync<T>(string name) => default;
		public AssetBundleRequest LoadAssetAsync(string name, System.Type type) => default; // 0x000000018BEAF3B0-0x000000018BEAF4CC
		public AssetBundleRequest LoadAssetAsync(long hash, System.Type type) => default; // 0x00000001844F01F0-0x00000001844F0260
		public AssetBundleRequest LoadSubAssetAsync(string name, long subAssetInstanceID, System.Type type) => default; // 0x000000018BEAF70C-0x000000018BEAF888
		private AssetBundleRequest LoadAssetAsync_Internal(string name, System.Type type) => default; // 0x000000018BEAF35C-0x000000018BEAF3B0
		private AssetBundleRequest LoadAssetAsyncByHash_Internal(long hash, System.Type type) => default; // 0x00000001844F0260-0x00000001844F02C0
		public void Unload(bool unloadAllLoadedObjects) {} // 0x0000000185029570-0x00000001850295C0
		public AsyncOperation UnloadAsync(bool unloadAllLoadedObjects) => default; // 0x000000018BEAF8FC-0x000000018BEAF940
		internal AssetBundleRequest LoadSubAssetAsync_Internal(string name, long instanceID, System.Type type) => default; // 0x000000018BEAF6A8-0x000000018BEAF70C
	}

	public class AssetBundleCreateRequest : AsyncOperation // TypeDefIndex: 60986
	{
		// Properties
		public AssetBundle assetBundle { get => default; } // 0x00000001844EE820-0x00000001844EE860 
	
		// Constructors
		public AssetBundleCreateRequest() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	internal static class AssetBundleLoadingCache // TypeDefIndex: 60987
	{
		// Properties
		internal static uint maxBlocksPerFile { get; set; } // 0x000000018BEAF1A4-0x000000018BEAF1D0 0x0000000185B9E0D0-0x0000000185B9E110
		internal static uint blockCount { get; set; } // 0x0000000185B9E050-0x0000000185B9E090 0x0000000185B9E090-0x0000000185B9E0D0
		internal static uint blockSize { get; } // 0x0000000185B9DF50-0x0000000185B9DF90 
		internal static uint memoryBudgetKB { get; set; } // 0x0000000185B9DF30-0x0000000185B9DF50 0x0000000185B9DF90-0x0000000185B9E050
	}

	public class AssetBundleRecompressOperation : AsyncOperation // TypeDefIndex: 60988
	{
		// Constructors
		public AssetBundleRecompressOperation() {} // Dummy constructor
	}

	public class AssetBundleRequest : ResourceRequest // TypeDefIndex: 60989
	{
		// Properties
		public Object asset { get => default; } // 0x000000018646F050-0x000000018646F0CC 
	
		// Constructors
		public AssetBundleRequest() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override Object GetResult() => default; // 0x00000001844EE2F0-0x00000001844EE330
	}
}

namespace UnityEngine.Experimental.AssetBundlePatching
{
	public static class AssetBundleUtility // TypeDefIndex: 60990
	{
		// Methods
		public static unsafe int LZ4Decompress(void* src, int srcSize, void* dst, int dstSize) => default; // 0x00000001855DA090-0x00000001855DA100
		public static int LZ4Decompress(byte[] src, int srcOffset, int srcSize, byte[] dst, int dstOffset, int dstSize) => default; // 0x00000001855DA010-0x00000001855DA090
	}
}
