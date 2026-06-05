/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Security.Cryptography;
using IFix.Core;

// Image 130: Common.Beyond.Cyptor.dll - Assembly: Common.Beyond.Cyptor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61133-61142

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 61138
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_1024 _12F3E0576D447EB37B36D82BA0C1C5481B8F0D12FDC70347CE4A076B229D4C86; // 0x00 // Static value (base64): AAAAAJYwB3csYQ7uulEJmRnEbQeP9GpwNaVj6aOVZJ4yiNsOpLjceR7p1eCI2dKXK0y2Cb18sX4HLbjnkR2/kGQQtx3yILBqSHG5895BvoR91Noa6+TdbVG11PTHhdODVphsE8Coa2R6+WL97Mllik9cARTZbAZjYz0P+vUNCI3IIG47XhBpTORBYNVycWei0eQDPEfUBEv9hQ3Sa7UKpfqotTVsmLJC1sm720D5vKzjbNgydVzfRc8N1txZPdGrrDDZJjoA3lGAUdfIFmHQv7X0tCEjxLNWmZW6zw+lvbieuAIoCIgFX7LZDMYk6Quxh3xvLxFMaFirHWHBPS1mtpBB3HYGcdsBvCDSmCoQ1e+JhbFxH7W2BqXkv58z1LjooskHeDT5AA+OqAmWGJgO4bsNan8tPW0Il2xkkQFcY+b0UWtrYmFsHNgwZYVOAGLy7ZUGbHulARvB9AiCV8QP9cbZsGVQ6bcS6ri+i3yIufzfHd1iSS3aFfN804xlTNT7WGGyTc5RtTp0ALyj4jC71EGl30rXldg9bcTRpPv01tNq6WlD/NluNEaIZ63QuGDacy0EROUdAzNfTAqqyXwN3TxxBVCqQQInEBALvoYgDMkltWhXs4VvIAnUZrmf5GHODvneXpjJ2SkimNCwtKjXxxc9s1mBDbQuO1y9t61susAgg7jttrO/mgzitgOa0rF0OUfV6q930p0VJtsEgxbccxILY+OEO2SUPmptDahaanoLzw7knf8JkyeuAAqxngd9RJMP8NKjCIdo8gEe/sIGaV1XYvfLZ2WAcTZsGecGa252G9T+4CvTiVp62hDMSt1nb9+5+fnvvo5DvrcX1Y6wYOij1tZ+k9GhxMLYOFLy30/xZ7vRZ1e8pt0GtT9LNrJI2isN2EwbCq/2SgM2YHoEQcPvYN9V32eo745uMXm+aUaMs2HLGoNmvKDSbyU24mhSlXcMzANHC7u5FgIiLyYFVb47usUoC72yklq0KwRqs1yn/9fCMc/QtYue2Swdrt5bsMJkmybyY+yco2p1CpNtAqkGCZw/Ng7rhWcHchNXAAWCSr+VFHq44q4rsXs4G7YMm47Skg2+1eW379x8Id/bC9TS04ZC4tTx+LPdaG6D2h/NFr6BWya59uF3sG93R7cY5loIiHBqD//KOwZmXAsBEf+eZY9prmL40/9rYUXPbBZ44gqg7tIN11SDBE7CswM5YSZnp/cWYNBNR2lJ23duPkpq0a7cWtbZZgvfQPA72DdTrrypxZ673n/Pskfp/7UwHPK9vYrCusowk7NTpqO0JAU20LqTBtfNKVfeVL9n2SMuemazuEphxAIbaF2UK28qN74LtKGODMMb3wVaje8CLQ== - Metadata: 0x02083594
	internal static readonly __StaticArrayInitTypeSize_15 _95524C911AFEB934ED10A8D7FA3546CD5EBA4BFD0D0E8A1ABB244985A66F2D3F; // 0x400 // Static value (base64): MA0GCSqGSIb3DQEBAQUA - Metadata: 0x0208399C

	// Nested types
	private struct __StaticArrayInitTypeSize_15 // TypeDefIndex: 61136
	{
	}

	private struct __StaticArrayInitTypeSize_1024 // TypeDefIndex: 61137
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Beyond.Cryptor
{
	public static class Crc32Utils // TypeDefIndex: 61134
	{
		// Fields
		private static readonly string UNITY_CRC_SALT; // 0x00
		private static readonly int MAX_CACHE_CHAR_NUM; // 0x08
		private static readonly int MAX_CACHE_CHAR_BYTE_NUM; // 0x0C
		private static readonly uint[] crctable; // 0x10
	
		// Constructors
		static Crc32Utils() {} // 0x0000000185EBBE20-0x0000000185EBBF20
	
		// Methods
		private static uint CalculateCrc32(byte[] data, int offset, int length, uint startCRC = 4294967295 /* Metadata: 0x0208358D */) => default; // 0x000000018778717C-0x000000018778724C
		private static uint CalculateCrc32(ReadOnlySpan<byte> data, int offset, int length, uint startCRC = 4294967295 /* Metadata: 0x0208358E */) => default; // 0x000000018778724C-0x0000000187787350
		public static int UnityCRC(string s) => default; // 0x0000000187787414-0x0000000187787464
		public static long UnityCRC64(string s) => default; // 0x0000000187787350-0x0000000187787414
		public static long XXHash64(string input) => default; // 0x0000000184198180-0x0000000184198600
		public static ulong XXHash64(byte[] bytes) => default; // 0x0000000187787464-0x00000001877874F4
		public static int XXHash32(string input) => default; // 0x000000018419A2E0-0x000000018419A3A0
		public static int CRC32(byte[] input, int offset, int length) => default; // 0x000000018778711C-0x000000018778717C
		public static int CRC32(string s) => default; // 0x0000000184667C70-0x0000000184668400
	}

	public class RSACryptoUtils // TypeDefIndex: 61135
	{
		// Fields
		public const int SignLen = 128; // Metadata: 0x0208358F
	
		// Constructors
		public RSACryptoUtils() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static RSACryptoServiceProvider CreateRsaProviderFromPrivateKey(string privateKey) => default; // 0x000000018418D300-0x000000018418DF00
		private static int _GetIntegerSize(BinaryReader binr) => default; // 0x000000018418E120-0x000000018418E210
		public static RSACryptoServiceProvider CreateRsaProviderFromPublicKey(string publicKeyString) => default; // 0x00000001877880F0-0x0000000187788170
		public static bool VerfyStream(Stream stream, string publicKey) => default; // 0x0000000187788170-0x0000000187788388
		public static RSACryptoServiceProvider CreateRsaProviderFromPublicKey(byte[] x509key) => default; // 0x000000018778787C-0x00000001877880F0
		private static bool _CompareBytearrays(byte[] a, byte[] b) => default; // 0x0000000187788388-0x0000000187788424
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 61139
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F641D0-0x0000000185F64240
	
		// Methods
		public uint __Gen_Wrap_0(ReadOnlySpan<byte> P0, int P1, int P2, uint P3) => default; // 0x00000001877874F4-0x000000018778763C
		public int __Gen_Wrap_1(object P0) => default; // 0x00000001873408C8-0x0000000187340998
		public long __Gen_Wrap_2(object P0) => default; // 0x000000018735B890-0x000000018735B960
		public ulong __Gen_Wrap_3(object P0) => default; // 0x000000018778763C-0x00000001877876F8
		public RSACryptoServiceProvider __Gen_Wrap_4(object P0) => default; // 0x00000001877876F8-0x00000001877877E8
		public bool __Gen_Wrap_5(object P0, object P1) => default; // 0x0000000187342174-0x0000000187342260
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 61140
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x00000001877877E8-0x000000018778787C
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 61141
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018778860C-0x0000000187788670
		public static bool IsPatched(int id) => default; // 0x0000000184198930-0x00000001841989A0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001877884C8-0x0000000187788594
		public object CreateWrapper(int id) => default; // 0x0000000187788594-0x000000018778860C
		public object InitWrapperArray(int len) => default; // 0x0000000187788670-0x00000001877886FC
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000187788424-0x00000001877884C8
	}

	public enum IDMAP0 // TypeDefIndex: 61142
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
