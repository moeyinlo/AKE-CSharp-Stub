/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using IFix.Core;

// Image 132: Common.Beyond.Cyptor.dll - Assembly: Common.Beyond.Cyptor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63769-63778
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 63774
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_1024 _12F3E0576D447EB37B36D82BA0C1C5481B8F0D12FDC70347CE4A076B229D4C86; // 0x00 // Static value (base64): AAAAAJYwB3csYQ7uulEJmRnEbQeP9GpwNaVj6aOVZJ4yiNsOpLjceR7p1eCI2dKXK0y2Cb18sX4HLbjnkR2/kGQQtx3yILBqSHG5895BvoR91Noa6+TdbVG11PTHhdODVphsE8Coa2R6+WL97Mllik9cARTZbAZjYz0P+vUNCI3IIG47XhBpTORBYNVycWei0eQDPEfUBEv9hQ3Sa7UKpfqotTVsmLJC1sm720D5vKzjbNgydVzfRc8N1txZPdGrrDDZJjoA3lGAUdfIFmHQv7X0tCEjxLNWmZW6zw+lvbieuAIoCIgFX7LZDMYk6Quxh3xvLxFMaFirHWHBPS1mtpBB3HYGcdsBvCDSmCoQ1e+JhbFxH7W2BqXkv58z1LjooskHeDT5AA+OqAmWGJgO4bsNan8tPW0Il2xkkQFcY+b0UWtrYmFsHNgwZYVOAGLy7ZUGbHulARvB9AiCV8QP9cbZsGVQ6bcS6ri+i3yIufzfHd1iSS3aFfN804xlTNT7WGGyTc5RtTp0ALyj4jC71EGl30rXldg9bcTRpPv01tNq6WlD/NluNEaIZ63QuGDacy0EROUdAzNfTAqqyXwN3TxxBVCqQQInEBALvoYgDMkltWhXs4VvIAnUZrmf5GHODvneXpjJ2SkimNCwtKjXxxc9s1mBDbQuO1y9t61susAgg7jttrO/mgzitgOa0rF0OUfV6q930p0VJtsEgxbccxILY+OEO2SUPmptDahaanoLzw7knf8JkyeuAAqxngd9RJMP8NKjCIdo8gEe/sIGaV1XYvfLZ2WAcTZsGecGa252G9T+4CvTiVp62hDMSt1nb9+5+fnvvo5DvrcX1Y6wYOij1tZ+k9GhxMLYOFLy30/xZ7vRZ1e8pt0GtT9LNrJI2isN2EwbCq/2SgM2YHoEQcPvYN9V32eo745uMXm+aUaMs2HLGoNmvKDSbyU24mhSlXcMzANHC7u5FgIiLyYFVb47usUoC72yklq0KwRqs1yn/9fCMc/QtYue2Swdrt5bsMJkmybyY+yco2p1CpNtAqkGCZw/Ng7rhWcHchNXAAWCSr+VFHq44q4rsXs4G7YMm47Skg2+1eW379x8Id/bC9TS04ZC4tTx+LPdaG6D2h/NFr6BWya59uF3sG93R7cY5loIiHBqD//KOwZmXAsBEf+eZY9prmL40/9rYUXPbBZ44gqg7tIN11SDBE7CswM5YSZnp/cWYNBNR2lJ23duPkpq0a7cWtbZZgvfQPA72DdTrrypxZ673n/Pskfp/7UwHPK9vYrCusowk7NTpqO0JAU20LqTBtfNKVfeVL9n2SMuemazuEphxAIbaF2UK28qN74LtKGODMMb3wVaje8CLQ== - Metadata: 0x02353214
	internal static readonly __StaticArrayInitTypeSize_15 _95524C911AFEB934ED10A8D7FA3546CD5EBA4BFD0D0E8A1ABB244985A66F2D3F; // 0x400 // Static value (base64): MA0GCSqGSIb3DQEBAQUA - Metadata: 0x0235361C

	// Nested types
	private struct __StaticArrayInitTypeSize_15 // TypeDefIndex: 63772
	{
	}

	private struct __StaticArrayInitTypeSize_1024 // TypeDefIndex: 63773
	{
	}
}

namespace Beyond.Cryptor
{
	public static class Crc32Utils // TypeDefIndex: 63770
	{
		// Fields
		private static readonly string UNITY_CRC_SALT; // 0x00
		private static readonly int MAX_CACHE_CHAR_NUM; // 0x08
		private static readonly int MAX_CACHE_CHAR_BYTE_NUM; // 0x0C
		private static readonly uint[] crctable; // 0x10
	
		// Constructors
		static Crc32Utils(); // 0x0000000184CA9700-0x0000000184CA9800
	
		// Methods
		private static uint CalculateCrc32(byte[] data, int offset, int length, uint startCRC = 4294967295 /* Metadata: 0x0235320D */); // 0x00000001867CD600-0x00000001867CD6D0
		private static uint CalculateCrc32(ReadOnlySpan<byte> data, int offset, int length, uint startCRC = 4294967295 /* Metadata: 0x0235320E */); // 0x00000001867CD6D0-0x00000001867CD7D4
		public static int CRC32(byte[] input, int offset, int length); // 0x00000001867CD5A0-0x00000001867CD600
		public static int CRC32(string s); // 0x000000018307DF20-0x000000018307E5E0
	
		// Extension methods
		public static int UnityCRC(this string s); // 0x00000001867CD898-0x00000001867CD8E8
		public static long UnityCRC64(this string s); // 0x00000001867CD7D4-0x00000001867CD898
		[IDTag(0)]
		public static long XXHash64(this string input); // 0x0000000182F83150-0x0000000182F83580
		[IDTag(1)]
		public static ulong XXHash64(this byte[] bytes); // 0x00000001867CD8E8-0x00000001867CD978
		public static int XXHash32(this string input); // 0x0000000182F84A90-0x0000000182F84B10
	}

	public class RSACryptoUtils // TypeDefIndex: 63771
	{
		// Fields
		public const int SignLen = 128; // Metadata: 0x0235320F
	
		// Constructors
		public RSACryptoUtils(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static RSACryptoServiceProvider CreateRsaProviderFromPrivateKey(string privateKey); // 0x0000000183FE3E50-0x0000000183FE4A50
		private static int _GetIntegerSize(BinaryReader binr); // 0x0000000183FE4C70-0x0000000183FE4D60
		[IDTag(1)]
		public static RSACryptoServiceProvider CreateRsaProviderFromPublicKey(string publicKeyString); // 0x00000001867CE644-0x00000001867CE6C4
		public static bool VerfyStream(Stream stream, string publicKey); // 0x00000001867CE6C4-0x00000001867CE8DC
		[IDTag(0)]
		public static RSACryptoServiceProvider CreateRsaProviderFromPublicKey(byte[] x509key); // 0x00000001867CDDD0-0x00000001867CE644
		private static bool _CompareBytearrays(byte[] a, byte[] b); // 0x00000001867CE8DC-0x00000001867CE978
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63775
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37250-0x0000000184D372C0
	
		// Methods
		public uint __Gen_Wrap_0(ReadOnlySpan<byte> P0, int P1, int P2, uint P3); // 0x00000001867CD978-0x00000001867CDAC0
		public int __Gen_Wrap_1(object P0); // 0x0000000186360E84-0x0000000186360F54
		public long __Gen_Wrap_2(object P0); // 0x00000001867CDAC0-0x00000001867CDB90
		public ulong __Gen_Wrap_3(object P0); // 0x00000001867CDB90-0x00000001867CDC4C
		public RSACryptoServiceProvider __Gen_Wrap_4(object P0); // 0x00000001867CDC4C-0x00000001867CDD3C
		public bool __Gen_Wrap_5(object P0, object P1); // 0x0000000186366BC4-0x0000000186366CB0
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 63776
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x00000001867CDD3C-0x00000001867CDDD0
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 63777
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x00000001867CEB60-0x00000001867CEBC4
		public static bool IsPatched(int id); // 0x0000000182F83580-0x0000000182F835D0
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x00000001867CEA1C-0x00000001867CEAE8
		public object CreateWrapper(int id); // 0x00000001867CEAE8-0x00000001867CEB60
		public object InitWrapperArray(int len); // 0x00000001867CEBC4-0x00000001867CEC50
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x00000001867CE978-0x00000001867CEA1C
	}

	public enum IDMAP0 // TypeDefIndex: 63778
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
