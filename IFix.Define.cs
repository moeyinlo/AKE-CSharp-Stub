/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 134: IFix.Define.dll - Assembly: IFix.Define, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63795-63808
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.HotFix
{
	[Serializable]
	public class HotfixDownloadPayload // TypeDefIndex: 63796
	{
		// Fields
		public int effectiveVersion; // 0x10
		public string luahotfix; // 0x18
		public string i18nhotfix; // 0x20
		public string ifixhotfix; // 0x28
	
		// Constructors
		public HotfixDownloadPayload(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class PatchClipboardData // TypeDefIndex: 63797
	{
		// Fields
		public int ver; // 0x10
		public int overrideVFSIFixVersionFrom; // 0x14
		public int overrideVFSIFixVersionTo; // 0x18
		public string platform; // 0x20
		public List<PatchItem> patches; // 0x28
	
		// Constructors
		public PatchClipboardData(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class LuaPatchClipboardData // TypeDefIndex: 63798
	{
		// Fields
		public int ver; // 0x10
		public int overrideVFSIFixVersionFrom; // 0x14
		public int overrideVFSIFixVersionTo; // 0x18
		public string platform; // 0x20
		public List<PatchItem> luaPatches; // 0x28
	
		// Constructors
		public LuaPatchClipboardData(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class PatchItem // TypeDefIndex: 63799
	{
		// Fields
		public string name; // 0x10
		public string md5; // 0x18
		public int size; // 0x20
		public string data; // 0x28
	
		// Constructors
		public PatchItem(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class HotfixDownloadPackage // TypeDefIndex: 63800
	{
		// Fields
		public string alg; // 0x10
		public string data; // 0x18
		public string sign; // 0x20
	
		// Constructors
		public HotfixDownloadPackage(); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class HotFixPatchDefine // TypeDefIndex: 63801
	{
		// Fields
		public static readonly string hotFixPatchFileExtension; // 0x00
		public const string HOTFIX_DOWNLOAD_ALGORITHM = "HMAC-SHA256"; // Metadata: 0x02353641
		public static readonly string CLIENT_NET_RSA_PUBLIC_KEY; // 0x08
		private static readonly byte[] s_luaPatchAesKey; // 0x10
		private static readonly byte[] s_luaPatchAesIV; // 0x18
		private static readonly byte[] s_hotfixDownloadHmacKey; // 0x20
		private static readonly byte[] s_hotfixDownloadEnvelopeAesKey; // 0x28
		private static readonly byte[] s_hotfixDownloadEnvelopeAesIV; // 0x30
	
		// Constructors
		static HotFixPatchDefine(); // 0x0000000184994BE0-0x0000000184994E40
	
		// Methods
		public static byte[] EncryptLuaPatchPayload(byte[] luaBytes); // 0x0000000189E13E40-0x0000000189E140F4
		public static byte[] DecryptLuaPatchPayload(byte[] encryptedBytes, int offset, int count); // 0x0000000183C0D460-0x0000000183C0D7B0
		public static string PackHotfixDownloadText(string rawJson); // 0x0000000189E140F4-0x0000000189E142AC
		public static bool TryDecodeHotfixDownloadText(string downloadText, out string json, out string error); // 0x0000000183C0B760-0x0000000183C0BA40
		public static bool TryExtractLuaHotfix(string json, out string luaHotfix, out string error); // 0x0000000189E142AC-0x0000000189E1446C
		public static bool VerifyMD5(byte[] bytes, string expectMd5); // 0x0000000189E1446C-0x0000000189E14650
		public static byte[] EncryptHotfixDownloadEnvelope(byte[] bytes); // 0x0000000189E13DB0-0x0000000189E13E40
		public static byte[] DecryptHotfixDownloadEnvelope(byte[] encryptedBytes, int offset, int count); // 0x0000000183C0A7A0-0x0000000183C0A840
		private static bool _VerifyHotfixDownloadHmac(string content, string signatureBase64); // 0x0000000183C0B3B0-0x0000000183C0B460
		private static byte[] _ComputeHotfixDownloadHmac(string content); // 0x0000000183C0A530-0x0000000183C0A7A0
		private static bool _FixedTimeEquals(byte[] left, byte[] right); // 0x0000000184593100-0x0000000184593190
		private static byte[] _EncryptAes(byte[] bytes, byte[] key, byte[] iv); // 0x0000000189E14650-0x0000000189E148CC
		private static byte[] _DecryptAes(byte[] encryptedBytes, int offset, int count, byte[] key, byte[] iv); // 0x0000000183C0B460-0x0000000183C0B760
	}
}

namespace IFix
{
	[AttributeUsage(AttributeTargets.Method)]
	public class HotfixPatchAttribute : Attribute // TypeDefIndex: 63802
	{
		// Constructors
		public HotfixPatchAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public class HotfixInterpretAttribute : Attribute // TypeDefIndex: 63803
	{
		// Constructors
		public HotfixInterpretAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Method)]
	public class IFixIgnoreAttribute : Attribute // TypeDefIndex: 63804
	{
		// Constructors
		public IFixIgnoreAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63805
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37870-0x0000000184D378E0
	
		// Methods
		public byte[] __Gen_Wrap_0(object P0); // 0x0000000189E148CC-0x0000000189E149BC
		public byte[] __Gen_Wrap_1(object P0, int P1, int P2); // 0x0000000189E149BC-0x0000000189E14AE0
		public byte[] __Gen_Wrap_2(object P0, object P1, object P2); // 0x0000000189E14AE0-0x0000000189E14BF4
		public string __Gen_Wrap_3(object P0); // 0x0000000189E14BF4-0x0000000189E14CD0
		public byte[] __Gen_Wrap_4(object P0, int P1, int P2, object P3, object P4); // 0x0000000189E14CD0-0x0000000189E14E14
		public bool __Gen_Wrap_5(object P0, object P1); // 0x0000000186366BC4-0x0000000186366CB0
		public bool __Gen_Wrap_6(object P0, out string P1, out string P2); // 0x0000000189E14E14-0x0000000189E14F90
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 63806
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x0000000189E14F90-0x0000000189E15024
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 63807
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000189E1520C-0x0000000189E15270
		public static bool IsPatched(int id); // 0x0000000184593190-0x0000000184593200
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x0000000189E150C8-0x0000000189E15194
		public object CreateWrapper(int id); // 0x0000000189E15194-0x0000000189E1520C
		public object InitWrapperArray(int len); // 0x0000000189E15270-0x0000000189E152FC
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x0000000189E15024-0x0000000189E150C8
	}

	public enum IDMAP0 // TypeDefIndex: 63808
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
