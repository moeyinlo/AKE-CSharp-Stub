/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using IFix.Core;

// Image 127: Common.Beyond.Cyptor.dll - Assembly: Common.Beyond.Cyptor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60028-60037
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Cryptor
{
	public static class Crc32Utils // TypeDefIndex: 60029
	{
		// Fields
		private static readonly string UNITY_CRC_SALT; // 0x00
		private static readonly int MAX_CACHE_CHAR_NUM; // 0x08
		private static readonly int MAX_CACHE_CHAR_BYTE_NUM; // 0x0C
		private static readonly uint[] crctable; // 0x10
	
		// Constructors
		static Crc32Utils() {} // 0x0000000183C7E310-0x0000000183C7E410
	
		// Methods
		private static uint CalculateCrc32(byte[] data, int offset, int length, uint startCRC = 4294967295 /* Metadata: 0x01FDDCA2 */) => default; // 0x0000000185586D00-0x0000000185586DD0
		private static uint CalculateCrc32(ReadOnlySpan<byte> data, int offset, int length, uint startCRC = 4294967295 /* Metadata: 0x01FDDCA3 */) => default; // 0x0000000185586DD0-0x0000000185586ED4
		public static int CRC32(byte[] input, int offset, int length) => default; // 0x0000000185586CA0-0x0000000185586D00
		public static int CRC32(string s) => default; // 0x00000001825D9240-0x00000001825D99D0
	
		// Extension methods
		public static int UnityCRC(this string s) => default; // 0x0000000185586F98-0x0000000185586FE8
		public static long UnityCRC64(this string s) => default; // 0x0000000185586ED4-0x0000000185586F98
		[IDTag(0)]
		public static long XXHash64(this string input) => default; // 0x00000001823B9EF0-0x00000001823BA370
		[IDTag(1)]
		public static ulong XXHash64(this byte[] bytes) => default; // 0x0000000185586FE8-0x0000000185587078
		public static int XXHash32(this string input) => default; // 0x00000001823BC050-0x00000001823BC110
	}

	public class RSACryptoUtils // TypeDefIndex: 60030
	{
		// Fields
		public const int SignLen = 128; // Metadata: 0x01FDDCA4
	
		// Constructors
		public RSACryptoUtils() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static RSACryptoServiceProvider CreateRsaProviderFromPrivateKey(string privateKey) => default; // 0x00000001831855B0-0x00000001831861B0
		private static int _GetIntegerSize(BinaryReader binr) => default; // 0x00000001831863D0-0x00000001831864C0
		[IDTag(1)]
		public static RSACryptoServiceProvider CreateRsaProviderFromPublicKey(string publicKeyString) => default; // 0x0000000185587C74-0x0000000185587CF4
		public static bool VerfyStream(Stream stream, string publicKey) => default; // 0x0000000185587CF4-0x0000000185587F0C
		[IDTag(0)]
		public static RSACryptoServiceProvider CreateRsaProviderFromPublicKey(byte[] x509key) => default; // 0x0000000185587400-0x0000000185587C74
		private static bool _CompareBytearrays(byte[] a, byte[] b) => default; // 0x0000000185587F0C-0x0000000185587FA8
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60034
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D058E0-0x0000000183D05950
	
		// Methods
		public uint __Gen_Wrap_0(ReadOnlySpan<byte> P0, int P1, int P2, uint P3) => default; // 0x0000000185587078-0x00000001855871C0
		public int __Gen_Wrap_1(object P0) => default; // 0x00000001850EF614-0x00000001850EF6E4
		public long __Gen_Wrap_2(object P0) => default; // 0x000000018516CA20-0x000000018516CAF0
		public ulong __Gen_Wrap_3(object P0) => default; // 0x00000001855871C0-0x000000018558727C
		public RSACryptoServiceProvider __Gen_Wrap_4(object P0) => default; // 0x000000018558727C-0x000000018558736C
		public bool __Gen_Wrap_5(object P0, object P1) => default; // 0x0000000185153920-0x0000000185153A0C
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 60035
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018558736C-0x0000000185587400
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 60036
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000185588190-0x00000001855881F4
		public static bool IsPatched(int id) => default; // 0x00000001823BA6A0-0x00000001823BA710
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018558804C-0x0000000185588118
		public object CreateWrapper(int id) => default; // 0x0000000185588118-0x0000000185588190
		public object InitWrapperArray(int len) => default; // 0x00000001855881F4-0x0000000185588280
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000185587FA8-0x000000018558804C
	}

	public enum IDMAP0 // TypeDefIndex: 60037
	{
		Beyond-Cryptor-Crc32Utils-CalculateCrc320 = 0,
		Beyond-Cryptor-Crc32Utils-UnityCRC0 = 1,
		Beyond-Cryptor-Crc32Utils-UnityCRC640 = 2,
		Beyond-Cryptor-Crc32Utils-XXHash640 = 3,
		Beyond-Cryptor-Crc32Utils-XXHash641 = 4,
		Beyond-Cryptor-Crc32Utils-XXHash320 = 5,
		Beyond-Cryptor-Crc32Utils-CRC320 = 6,
		Beyond-Cryptor-RSACryptoUtils-CreateRsaProviderFromPrivateKey0 = 7,
		Beyond-Cryptor-RSACryptoUtils-_GetIntegerSize0 = 8,
		Beyond-Cryptor-RSACryptoUtils-CreateRsaProviderFromPublicKey1 = 9,
		Beyond-Cryptor-RSACryptoUtils-CreateRsaProviderFromPublicKey0 = 10,
		Beyond-Cryptor-RSACryptoUtils-VerfyStream0 = 11,
		Beyond-Cryptor-RSACryptoUtils-_CompareBytearrays0 = 12
	}
}
