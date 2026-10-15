/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 133: IFix.Define.dll - Assembly: IFix.Define, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91251-91271

namespace Beyond.HotFix
{
	[Serializable]
	public class HotfixDownloadPayload // TypeDefIndex: 91252
	{
		// Fields
		public int effectiveVersion; // 0x10
		public string luahotfix; // 0x18
		public string i18nhotfix; // 0x20
		public string ifixhotfix; // 0x28
	
		// Constructors
		public HotfixDownloadPayload(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class PatchClipboardData // TypeDefIndex: 91253
	{
		// Fields
		public int ver; // 0x10
		public int overrideVFSIFixVersionFrom; // 0x14
		public int overrideVFSIFixVersionTo; // 0x18
		public string platform; // 0x20
		public List<PatchItem> patches; // 0x28
	
		// Constructors
		public PatchClipboardData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class LuaPatchClipboardData // TypeDefIndex: 91254
	{
		// Fields
		public int ver; // 0x10
		public int overrideVFSIFixVersionFrom; // 0x14
		public int overrideVFSIFixVersionTo; // 0x18
		public string platform; // 0x20
		public List<PatchItem> luaPatches; // 0x28
	
		// Constructors
		public LuaPatchClipboardData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class PatchItem // TypeDefIndex: 91255
	{
		// Fields
		public string name; // 0x10
		public string md5; // 0x18
		public int size; // 0x20
		public string data; // 0x28
	
		// Constructors
		public PatchItem(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class HotfixDownloadPackage // TypeDefIndex: 91256
	{
		// Fields
		public string alg; // 0x10
		public string data; // 0x18
		public string sign; // 0x20
	
		// Constructors
		public HotfixDownloadPackage(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public static class HotFixPatchDefine // TypeDefIndex: 91257
	{
		// Fields
		public static readonly string hotFixPatchFileExtension; // 0x00
		public const string HOTFIX_DOWNLOAD_ALGORITHM = "HMAC-SHA256"; // Metadata: 0x0264BFC5
		public static readonly string CLIENT_NET_RSA_PUBLIC_KEY; // 0x08
		private static readonly byte[] s_luaPatchAesKey; // 0x10
		private static readonly byte[] s_luaPatchAesIV; // 0x18
		private static readonly byte[] s_hotfixDownloadHmacKey; // 0x20
		private static readonly byte[] s_hotfixDownloadEnvelopeAesKey; // 0x28
		private static readonly byte[] s_hotfixDownloadEnvelopeAesIV; // 0x30
	
		// Constructors
		static HotFixPatchDefine(); // 0x0000000186E00460-0x0000000186E006C0
	
		// Methods
		public static byte[] EncryptLuaPatchPayload(byte[] luaBytes); // 0x000000018C2551CC-0x000000018C255494
		public static byte[] DecryptLuaPatchPayload(byte[] encryptedBytes, int offset, int count); // 0x00000001858DC560-0x00000001858DC900
		public static string PackHotfixDownloadText(string rawJson); // 0x000000018C255494-0x000000018C255654
		public static bool TryDecodeHotfixDownloadText(string downloadText, out string json, out string error); // 0x00000001858DA650-0x00000001858DA940
		public static bool TryExtractLuaHotfix(string json, out string luaHotfix, out string error); // 0x000000018C255654-0x000000018C25582C
		public static bool VerifyMD5(byte[] bytes, string expectMd5); // 0x000000018C25582C-0x000000018C255A14
		public static byte[] EncryptHotfixDownloadEnvelope(byte[] bytes); // 0x000000018C255138-0x000000018C2551CC
		public static byte[] DecryptHotfixDownloadEnvelope(byte[] encryptedBytes, int offset, int count); // 0x0000000186D28E20-0x0000000186D28ED0
		private static bool _VerifyHotfixDownloadHmac(string content, string signatureBase64); // 0x0000000186748390-0x0000000186748450
		private static byte[] _ComputeHotfixDownloadHmac(string content); // 0x0000000186748450-0x00000001867486C0
		private static bool _FixedTimeEquals(byte[] left, byte[] right); // 0x00000001867486C0-0x0000000186748750
		private static byte[] _EncryptAes(byte[] bytes, byte[] key, byte[] iv); // 0x000000018C255A14-0x000000018C255CA8
		private static byte[] _DecryptAes(byte[] encryptedBytes, int offset, int count, byte[] key, byte[] iv); // 0x0000000186D28ED0-0x0000000186D291D0
	}
}

namespace IFix
{
	[AttributeUsage(AttributeTargets.Method)]
	public class HotfixPatchAttribute : Attribute // TypeDefIndex: 91258
	{
		// Constructors
		public HotfixPatchAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public class HotfixInterpretAttribute : Attribute // TypeDefIndex: 91259
	{
		// Constructors
		public HotfixInterpretAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Method)]
	public class IFixIgnoreAttribute : Attribute // TypeDefIndex: 91260
	{
		// Constructors
		public IFixIgnoreAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class ILFixDynamicMethodWrapper // TypeDefIndex: 91261
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018C256344-0x000000018C2563A8
	
		// Methods
		public byte[] __Gen_Wrap_0(object P0); // 0x000000018C255CA8-0x000000018C255D88
		public byte[] __Gen_Wrap_1(object P0, int P1, int P2); // 0x000000018C255D88-0x000000018C255EA0
		public byte[] __Gen_Wrap_2(object P0, object P1, object P2); // 0x000000018C255EA0-0x000000018C255FBC
		public string __Gen_Wrap_3(object P0); // 0x000000018C255FBC-0x000000018C25609C
		public byte[] __Gen_Wrap_4(object P0, int P1, int P2, object P3, object P4); // 0x000000018C25609C-0x000000018C2561D4
		public bool __Gen_Wrap_5(object P0, object P1); // 0x00000001887F2FB4-0x00000001887F3094
		public bool __Gen_Wrap_6(object P0, out string P1, out string P2); // 0x000000018C2561D4-0x000000018C256344
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 91262
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018C2563A8-0x000000018C256440
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 91263
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018C25662C-0x000000018C256690
		public static bool IsPatched(int id); // 0x000000018C25671C-0x000000018C2567B4
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018C2564E4-0x000000018C2565B0
		public object CreateWrapper(int id); // 0x000000018C2565B0-0x000000018C25662C
		public object InitWrapperArray(int len); // 0x000000018C256690-0x000000018C25671C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018C256440-0x000000018C2564E4
	}

	public delegate byte[] __HotPatchDelegate_0(object P0); // TypeDefIndex: 91264; 0x0000000185B78EA0-0x0000000185B78EB0

	public enum HotPatchIDMAP0 // TypeDefIndex: 91265
	{
		Beyond-HotFix-HotFixPatchDefine-EncryptLuaPatchPayload0 = 0,
		Beyond-HotFix-HotFixPatchDefine-_ComputeHotfixDownloadHmac0 = 0,
		Beyond-HotFix-HotFixPatchDefine-EncryptHotfixDownloadEnvelope0 = 0,
		Beyond-HotFix-HotFixPatchDefine-DecryptLuaPatchPayload0 = 1,
		Beyond-HotFix-HotFixPatchDefine-DecryptHotfixDownloadEnvelope0 = 1,
		Beyond-HotFix-HotFixPatchDefine-_EncryptAes0 = 2,
		Beyond-HotFix-HotFixPatchDefine-PackHotfixDownloadText0 = 3,
		Beyond-HotFix-HotFixPatchDefine-_DecryptAes0 = 4,
		Beyond-HotFix-HotFixPatchDefine-_FixedTimeEquals0 = 5,
		Beyond-HotFix-HotFixPatchDefine-_VerifyHotfixDownloadHmac0 = 5,
		Beyond-HotFix-HotFixPatchDefine-VerifyMD50 = 5,
		Beyond-HotFix-HotFixPatchDefine-TryDecodeHotfixDownloadText0 = 6,
		Beyond-HotFix-HotFixPatchDefine-TryExtractLuaHotfix0 = 6
	}

	public delegate byte[] __HotPatchDelegate_1(object P0, int P1, int P2); // TypeDefIndex: 91266; 0x00000001811DF7F0-0x00000001811DF810

	public delegate byte[] __HotPatchDelegate_2(object P0, object P1, object P2); // TypeDefIndex: 91267; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_3(object P0); // TypeDefIndex: 91268; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate byte[] __HotPatchDelegate_4(object P0, int P1, int P2, object P3, object P4); // TypeDefIndex: 91269; 0x00000001812083C0-0x00000001812083E0

	public delegate bool __HotPatchDelegate_5(object P0, object P1); // TypeDefIndex: 91270; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_6(object P0, out string P1, out string P2); // TypeDefIndex: 91271; 0x00000001811DF7F0-0x00000001811DF810
}
