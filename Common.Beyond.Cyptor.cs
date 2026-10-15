/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using IFix.Core;

// Image 130: Common.Beyond.Cyptor.dll - Assembly: Common.Beyond.Cyptor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91196-91211

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 91201
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_1024 _12F3E0576D447EB37B36D82BA0C1C5481B8F0D12FDC70347CE4A076B229D4C86; // 0x00 // Static value (base64): AAAAAJYwB3csYQ7uulEJmRnEbQeP9GpwNaVj6aOVZJ4yiNsOpLjceR7p1eCI2dKXK0y2Cb18sX4HLbjnkR2/kGQQtx3yILBqSHG5895BvoR91Noa6+TdbVG11PTHhdODVphsE8Coa2R6+WL97Mllik9cARTZbAZjYz0P+vUNCI3IIG47XhBpTORBYNVycWei0eQDPEfUBEv9hQ3Sa7UKpfqotTVsmLJC1sm720D5vKzjbNgydVzfRc8N1txZPdGrrDDZJjoA3lGAUdfIFmHQv7X0tCEjxLNWmZW6zw+lvbieuAIoCIgFX7LZDMYk6Quxh3xvLxFMaFirHWHBPS1mtpBB3HYGcdsBvCDSmCoQ1e+JhbFxH7W2BqXkv58z1LjooskHeDT5AA+OqAmWGJgO4bsNan8tPW0Il2xkkQFcY+b0UWtrYmFsHNgwZYVOAGLy7ZUGbHulARvB9AiCV8QP9cbZsGVQ6bcS6ri+i3yIufzfHd1iSS3aFfN804xlTNT7WGGyTc5RtTp0ALyj4jC71EGl30rXldg9bcTRpPv01tNq6WlD/NluNEaIZ63QuGDacy0EROUdAzNfTAqqyXwN3TxxBVCqQQInEBALvoYgDMkltWhXs4VvIAnUZrmf5GHODvneXpjJ2SkimNCwtKjXxxc9s1mBDbQuO1y9t61susAgg7jttrO/mgzitgOa0rF0OUfV6q930p0VJtsEgxbccxILY+OEO2SUPmptDahaanoLzw7knf8JkyeuAAqxngd9RJMP8NKjCIdo8gEe/sIGaV1XYvfLZ2WAcTZsGecGa252G9T+4CvTiVp62hDMSt1nb9+5+fnvvo5DvrcX1Y6wYOij1tZ+k9GhxMLYOFLy30/xZ7vRZ1e8pt0GtT9LNrJI2isN2EwbCq/2SgM2YHoEQcPvYN9V32eo745uMXm+aUaMs2HLGoNmvKDSbyU24mhSlXcMzANHC7u5FgIiLyYFVb47usUoC72yklq0KwRqs1yn/9fCMc/QtYue2Swdrt5bsMJkmybyY+yco2p1CpNtAqkGCZw/Ng7rhWcHchNXAAWCSr+VFHq44q4rsXs4G7YMm47Skg2+1eW379x8Id/bC9TS04ZC4tTx+LPdaG6D2h/NFr6BWya59uF3sG93R7cY5loIiHBqD//KOwZmXAsBEf+eZY9prmL40/9rYUXPbBZ44gqg7tIN11SDBE7CswM5YSZnp/cWYNBNR2lJ23duPkpq0a7cWtbZZgvfQPA72DdTrrypxZ673n/Pskfp/7UwHPK9vYrCusowk7NTpqO0JAU20LqTBtfNKVfeVL9n2SMuemazuEphxAIbaF2UK28qN74LtKGODMMb3wVaje8CLQ== - Metadata: 0x0264BB98
	internal static readonly __StaticArrayInitTypeSize_15 _95524C911AFEB934ED10A8D7FA3546CD5EBA4BFD0D0E8A1ABB244985A66F2D3F; // 0x400 // Static value (base64): MA0GCSqGSIb3DQEBAQUA - Metadata: 0x0264BFA0

	// Nested types
	private struct __StaticArrayInitTypeSize_15 // TypeDefIndex: 91199
	{
	}

	private struct __StaticArrayInitTypeSize_1024 // TypeDefIndex: 91200
	{
	}
}

namespace Beyond.Cryptor
{
	public static class Crc32Utils // TypeDefIndex: 91197
	{
		// Fields
		private static readonly string UNITY_CRC_SALT; // 0x00
		private static readonly int MAX_CACHE_CHAR_NUM; // 0x08
		private static readonly int MAX_CACHE_CHAR_BYTE_NUM; // 0x0C
		private static readonly uint[] crctable; // 0x10
	
		// Constructors
		static Crc32Utils(); // 0x000000018708E3B0-0x000000018708E4B0
	
		// Methods
		private static uint CalculateCrc32(byte[] data, int offset, int length, uint startCRC = 4294967295 /* Metadata: 0x0264BB8F */); // 0x0000000188AB68AC-0x0000000188AB697C
		private static uint CalculateCrc32(ReadOnlySpan<byte> data, int offset, int length, uint startCRC = 4294967295 /* Metadata: 0x0264BB90 */); // 0x0000000188AB697C-0x0000000188AB6A8C
		public static int CRC32(byte[] input, int offset, int length); // 0x0000000188AB684C-0x0000000188AB68AC
		public static int CRC32(string s); // 0x0000000184F8A580-0x0000000184F8AE20
	
		// Extension methods
		public static int UnityCRC(this string s); // 0x0000000188AB6B58-0x0000000188AB6BD8
		public static long UnityCRC64(this string s); // 0x0000000188AB6A8C-0x0000000188AB6B58
		[IDTag(0)]
		public static long XXHash64(this string input); // 0x000000018529A0F0-0x000000018529A440
		[IDTag(1)]
		public static ulong XXHash64(this byte[] bytes); // 0x0000000188AB6BD8-0x0000000188AB6C5C
		public static int XXHash32(this string input); // 0x0000000184F8D070-0x0000000184F8D0C0
	}

	public class RSACryptoUtils // TypeDefIndex: 91198
	{
		// Fields
		public const int SignLen = 128; // Metadata: 0x0264BB91
	
		// Constructors
		public RSACryptoUtils(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static RSACryptoServiceProvider CreateRsaProviderFromPrivateKey(string privateKey); // 0x0000000186026430-0x0000000186026FE0
		private static int _GetIntegerSize(BinaryReader binr); // 0x000000018601FC20-0x000000018601FD20
		[IDTag(1)]
		public static RSACryptoServiceProvider CreateRsaProviderFromPublicKey(string publicKeyString); // 0x0000000186028C50-0x0000000186028CD0
		public static bool VerfyStream(Stream stream, string publicKey); // 0x00000001860283F0-0x0000000186028BF0
		[IDTag(0)]
		public static RSACryptoServiceProvider CreateRsaProviderFromPublicKey(byte[] x509key); // 0x0000000186026FE0-0x00000001860281F0
		private static bool _CompareBytearrays(byte[] a, byte[] b); // 0x0000000186028F10-0x0000000186028F90
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 91202
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x0000000188AB6F3C-0x0000000188AB6FA0
	
		// Methods
		public uint __Gen_Wrap_0(ReadOnlySpan<byte> P0, int P1, int P2, uint P3); // 0x0000000188AB6C5C-0x0000000188AB6D9C
		public int __Gen_Wrap_1(object P0); // 0x00000001887EBA14-0x00000001887EBAD4
		public long __Gen_Wrap_2(object P0); // 0x0000000188AB6D9C-0x0000000188AB6E5C
		public ulong __Gen_Wrap_3(object P0); // 0x0000000188AB6D9C-0x0000000188AB6E5C
		public RSACryptoServiceProvider __Gen_Wrap_4(object P0); // 0x0000000188AB6E5C-0x0000000188AB6F3C
		public bool __Gen_Wrap_5(object P0, object P1); // 0x00000001887F2FB4-0x00000001887F3094
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 91203
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x0000000188AB6FA0-0x0000000188AB7038
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 91204
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000188AB7224-0x0000000188AB7288
		public static bool IsPatched(int id); // 0x0000000188AB7314-0x0000000188AB7390
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x0000000188AB70DC-0x0000000188AB71A8
		public object CreateWrapper(int id); // 0x0000000188AB71A8-0x0000000188AB7224
		public object InitWrapperArray(int len); // 0x0000000188AB7288-0x0000000188AB7314
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x0000000188AB7038-0x0000000188AB70DC
	}

	public delegate uint __HotPatchDelegate_0(ReadOnlySpan<byte> P0, int P1, int P2, uint P3); // TypeDefIndex: 91205; 0x00000001878C64C4-0x00000001878C64F8

	public enum HotPatchIDMAP0 // TypeDefIndex: 91206
	{
		Beyond-Cryptor-Crc32Utils-CalculateCrc320 = 0,
		Beyond-Cryptor-Crc32Utils-UnityCRC0 = 1,
		Beyond-Cryptor-Crc32Utils-XXHash320 = 1,
		Beyond-Cryptor-Crc32Utils-CRC320 = 1,
		Beyond-Cryptor-RSACryptoUtils-_GetIntegerSize0 = 1,
		Beyond-Cryptor-Crc32Utils-UnityCRC640 = 2,
		Beyond-Cryptor-Crc32Utils-XXHash640 = 2,
		Beyond-Cryptor-Crc32Utils-XXHash641 = 3,
		Beyond-Cryptor-RSACryptoUtils-CreateRsaProviderFromPrivateKey0 = 4,
		Beyond-Cryptor-RSACryptoUtils-CreateRsaProviderFromPublicKey0 = 4,
		Beyond-Cryptor-RSACryptoUtils-CreateRsaProviderFromPublicKey1 = 4,
		Beyond-Cryptor-RSACryptoUtils-VerfyStream0 = 5,
		Beyond-Cryptor-RSACryptoUtils-_CompareBytearrays0 = 5
	}

	public delegate int __HotPatchDelegate_1(object P0); // TypeDefIndex: 91207; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate long __HotPatchDelegate_2(object P0); // TypeDefIndex: 91208; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate ulong __HotPatchDelegate_3(object P0); // TypeDefIndex: 91209; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate RSACryptoServiceProvider __HotPatchDelegate_4(object P0); // TypeDefIndex: 91210; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_5(object P0, object P1); // TypeDefIndex: 91211; 0x00000001859B7730-0x00000001859B7740
}
