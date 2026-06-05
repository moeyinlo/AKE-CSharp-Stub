/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using IFix.Core;

// Image 132: IFix.Define.dll - Assembly: IFix.Define, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61159-61169

namespace Beyond.HotFix
{
	[Serializable]
	public class PatchClipboardData // TypeDefIndex: 61160
	{
		// Fields
		public int ver; // 0x10
		public int overrideVFSIFixVersionFrom; // 0x14
		public int overrideVFSIFixVersionTo; // 0x18
		public string platform; // 0x20
		public List<PatchItem> patches; // 0x28
	
		// Constructors
		public PatchClipboardData() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class LuaPatchClipboardData // TypeDefIndex: 61161
	{
		// Fields
		public int ver; // 0x10
		public int overrideVFSIFixVersionFrom; // 0x14
		public int overrideVFSIFixVersionTo; // 0x18
		public string platform; // 0x20
		public List<PatchItem> luaPatches; // 0x28
	
		// Constructors
		public LuaPatchClipboardData() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class PatchItem // TypeDefIndex: 61162
	{
		// Fields
		public string name; // 0x10
		public string md5; // 0x18
		public int size; // 0x20
		public string data; // 0x28
	
		// Constructors
		public PatchItem() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class HotfixDownloadPayload // TypeDefIndex: 61163
	{
		// Fields
		public int effectiveVersion; // 0x10
		public string luahotfix; // 0x18
	
		// Constructors
		public HotfixDownloadPayload() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class HotfixDownloadPackage // TypeDefIndex: 61164
	{
		// Fields
		public string alg; // 0x10
		public string data; // 0x18
		public string sign; // 0x20
	
		// Constructors
		public HotfixDownloadPackage() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class HotFixPatchDefine // TypeDefIndex: 61165
	{
		// Fields
		public static readonly string hotFixPatchFileExtension; // 0x00
		public const string HOTFIX_DOWNLOAD_ALGORITHM = "HMAC-SHA256"; // Metadata: 0x020839C1
		public static readonly string CLIENT_NET_RSA_PUBLIC_KEY; // 0x08
		private static readonly byte[] s_luaPatchAesKey; // 0x10
		private static readonly byte[] s_luaPatchAesIV; // 0x18
		private static readonly byte[] s_hotfixDownloadHmacKey; // 0x20
		private static readonly byte[] s_hotfixDownloadEnvelopeAesKey; // 0x28
		private static readonly byte[] s_hotfixDownloadEnvelopeAesIV; // 0x30
	
		// Constructors
		static HotFixPatchDefine() {} // 0x000000018A9ABB74-0x000000018A9ABF78
	
		// Methods
		public static byte[] EncryptLuaPatchPayload(byte[] luaBytes) => default; // 0x00000001839FB4E0-0x00000001839FC5C0
		public static byte[] DecryptLuaPatchPayload(byte[] encryptedBytes, int offset, int count) => default; // 0x00000001839F9D90-0x00000001839FAEB0
		public static string PackHotfixDownloadText(string rawJson) => default; // 0x00000001839FC5C0-0x00000001839FD530
		public static bool TryDecodeHotfixDownloadText(string downloadText, out string json, out string error) {
			json = default;
			error = default;
			return default;
		} // 0x00000001839FD530-0x00000001839FED90
		public static bool TryExtractLuaHotfix(string json, out string luaHotfix, out string error) {
			luaHotfix = default;
			error = default;
			return default;
		} // 0x00000001839FED90-0x00000001839FFB80
		public static bool VerifyMD5(byte[] bytes, string expectMd5) => default; // 0x000000018A9AB990-0x000000018A9ABB74
		public static byte[] EncryptHotfixDownloadEnvelope(byte[] bytes) => default; // 0x00000001839FAEB0-0x00000001839FB4E0
		public static byte[] DecryptHotfixDownloadEnvelope(byte[] encryptedBytes, int offset, int count) => default; // 0x00000001839F9720-0x00000001839F9D90
		private static bool _VerifyHotfixDownloadHmac(string content, string signatureBase64) => default; // 0x0000000183A029D0-0x0000000183A03600
		private static byte[] _ComputeHotfixDownloadHmac(string content) => default; // 0x00000001839FFB80-0x0000000183A00920
		private static bool _FixedTimeEquals(byte[] left, byte[] right) => default; // 0x0000000183A02620-0x0000000183A029D0
		private static byte[] _EncryptAes(byte[] bytes, byte[] key, byte[] iv) => default; // 0x0000000183A017D0-0x0000000183A02620
		private static byte[] _DecryptAes(byte[] encryptedBytes, int offset, int count, byte[] key, byte[] iv) => default; // 0x0000000183A00920-0x0000000183A017D0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 61166
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x000000018A9ABF78-0x000000018A9ABFDC
	
		// Methods
		public byte[] __Gen_Wrap_0(object P0) => default; // 0x0000000183A03600-0x0000000183A03F30
		public byte[] __Gen_Wrap_1(object P0, int P1, int P2) => default; // 0x0000000183A03F30-0x0000000183A048C0
		public byte[] __Gen_Wrap_2(object P0, object P1, object P2) => default; // 0x0000000183A048C0-0x0000000183A053C0
		public string __Gen_Wrap_3(object P0) => default; // 0x0000000183A053C0-0x0000000183A05CF0
		public byte[] __Gen_Wrap_4(object P0, int P1, int P2, object P3, object P4) => default; // 0x0000000183A05CF0-0x0000000183A06810
		public bool __Gen_Wrap_5(object P0, object P1) => default; // 0x00000001815D5950-0x00000001815D5D10
		public bool __Gen_Wrap_6(object P0, out string P1, out string P2) {
			P1 = default;
			P2 = default;
			return default;
		} // 0x0000000183A06810-0x0000000183A0A510
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 61167
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018A9ABFDC-0x000000018A9AC070
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 61168
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018A9AC258-0x000000018A9AC2BC
		public static bool IsPatched(int id) => default; // 0x000000018A9AC348-0x000000018A9AC3E0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018A9AC114-0x000000018A9AC1E0
		public object CreateWrapper(int id) => default; // 0x000000018A9AC1E0-0x000000018A9AC258
		public object InitWrapperArray(int len) => default; // 0x000000018A9AC2BC-0x000000018A9AC348
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018A9AC070-0x000000018A9AC114
	}

	public enum IDMAP0 // TypeDefIndex: 61169
	{
		Beyond-HotFix-HotFixPatchDefine-EncryptLuaPatchPayload0 = 0,
		Beyond-HotFix-HotFixPatchDefine-DecryptLuaPatchPayload0 = 1,
		Beyond-HotFix-HotFixPatchDefine-PackHotfixDownloadText0 = 2,
		Beyond-HotFix-HotFixPatchDefine-_ComputeHotfixDownloadHmac0 = 3,
		Beyond-HotFix-HotFixPatchDefine-EncryptHotfixDownloadEnvelope0 = 4,
		Beyond-HotFix-HotFixPatchDefine-_EncryptAes0 = 5,
		Beyond-HotFix-HotFixPatchDefine-TryDecodeHotfixDownloadText0 = 6,
		Beyond-HotFix-HotFixPatchDefine-DecryptHotfixDownloadEnvelope0 = 7,
		Beyond-HotFix-HotFixPatchDefine-_DecryptAes0 = 8,
		Beyond-HotFix-HotFixPatchDefine-_VerifyHotfixDownloadHmac0 = 9,
		Beyond-HotFix-HotFixPatchDefine-_FixedTimeEquals0 = 10,
		Beyond-HotFix-HotFixPatchDefine-TryExtractLuaHotfix0 = 11,
		Beyond-HotFix-HotFixPatchDefine-VerifyMD50 = 12
	}
}
