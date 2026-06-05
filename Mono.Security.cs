/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Mono.Math;
using Mono.Math.Prime;
using Mono.Security;
using Mono.Security.Cryptography;
using Mono.Security.X509;

// Image 51: Mono.Security.dll - Assembly: Mono.Security, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57923-58026

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 58026
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_64 _001D686DB504E20C792EAA07FE09224A45FF328E24A80072D04D16ABC5C2B5D2; // 0x00 // Static value (base64): z4PhNX7vuL3xVChQ1m2AB9Yg5AULVxXcg/SpIdNs6c5H0NE8XYXysP+DGNKHfuwvY7kxvUdBeoGlODJ6+SfaPg== - Metadata: 0x0207E40C
	internal static readonly __StaticArrayInitTypeSize_3132 _25E3E48132FBDBE9B7C0C6C54D7C10A5DE12A105AA3E5DE2A0DC808BF245B7A5; // 0x40 // Static value (base64): AgAAAAMAAAAFAAAABwAAAAsAAAANAAAAEQAAABMAAAAXAAAAHQAAAB8AAAAlAAAAKQAAACsAAAAvAAAANQAAADsAAAA9AAAAQwAAAEcAAABJAAAATwAAAFMAAABZAAAAYQAAAGUAAABnAAAAawAAAG0AAABxAAAAfwAAAIMAAACJAAAAiwAAAJUAAACXAAAAnQAAAKMAAACnAAAArQAAALMAAAC1AAAAvwAAAMEAAADFAAAAxwAAANMAAADfAAAA4wAAAOUAAADpAAAA7wAAAPEAAAD7AAAAAQEAAAcBAAANAQAADwEAABUBAAAZAQAAGwEAACUBAAAzAQAANwEAADkBAAA9AQAASwEAAFEBAABbAQAAXQEAAGEBAABnAQAAbwEAAHUBAAB7AQAAfwEAAIUBAACNAQAAkQEAAJkBAACjAQAApQEAAK8BAACxAQAAtwEAALsBAADBAQAAyQEAAM0BAADPAQAA0wEAAN8BAADnAQAA6wEAAPMBAAD3AQAA/QEAAAkCAAALAgAAHQIAACMCAAAtAgAAMwIAADkCAAA7AgAAQQIAAEsCAABRAgAAVwIAAFkCAABfAgAAZQIAAGkCAABrAgAAdwIAAIECAACDAgAAhwIAAI0CAACTAgAAlQIAAKECAAClAgAAqwIAALMCAAC9AgAAxQIAAM8CAADXAgAA3QIAAOMCAADnAgAA7wIAAPUCAAD5AgAAAQMAAAUDAAATAwAAHQMAACkDAAArAwAANQMAADcDAAA7AwAAPQMAAEcDAABVAwAAWQMAAFsDAABfAwAAbQMAAHEDAABzAwAAdwMAAIsDAACPAwAAlwMAAKEDAACpAwAArQMAALMDAAC5AwAAxwMAAMsDAADRAwAA1wMAAN8DAADlAwAA8QMAAPUDAAD7AwAA/QMAAAcEAAAJBAAADwQAABkEAAAbBAAAJQQAACcEAAAtBAAAPwQAAEMEAABFBAAASQQAAE8EAABVBAAAXQQAAGMEAABpBAAAfwQAAIEEAACLBAAAkwQAAJ0EAACjBAAAqQQAALEEAAC9BAAAwQQAAMcEAADNBAAAzwQAANUEAADhBAAA6wQAAP0EAAD/BAAAAwUAAAkFAAALBQAAEQUAABUFAAAXBQAAGwUAACcFAAApBQAALwUAAFEFAABXBQAAXQUAAGUFAAB3BQAAgQUAAI8FAACTBQAAlQUAAJkFAACfBQAApwUAAKsFAACtBQAAswUAAL8FAADJBQAAywUAAM8FAADRBQAA1QUAANsFAADnBQAA8wUAAPsFAAAHBgAADQYAABEGAAAXBgAAHwYAACMGAAArBgAALwYAAD0GAABBBgAARwYAAEkGAABNBgAAUwYAAFUGAABbBgAAZQYAAHkGAAB/BgAAgwYAAIUGAACdBgAAoQYAAKMGAACtBgAAuQYAALsGAADFBgAAzQYAANMGAADZBgAA3wYAAPEGAAD3BgAA+wYAAP0GAAAJBwAAEwcAAB8HAAAnBwAANwcAAEUHAABLBwAATwcAAFEHAABVBwAAVwcAAGEHAABtBwAAcwcAAHkHAACLBwAAjQcAAJ0HAACfBwAAtQcAALsHAADDBwAAyQcAAM0HAADPBwAA0wcAANsHAADhBwAA6wcAAO0HAAD3BwAABQgAAA8IAAAVCAAAIQgAACMIAAAnCAAAKQgAADMIAAA/CAAAQQgAAFEIAABTCAAAWQgAAF0IAABfCAAAaQgAAHEIAACDCAAAmwgAAJ8IAAClCAAArQgAAL0IAAC/CAAAwwgAAMsIAADbCAAA3QgAAOEIAADpCAAA7wgAAPUIAAD5CAAABQkAAAcJAAAdCQAAIwkAACUJAAArCQAALwkAADUJAABDCQAASQkAAE0JAABPCQAAVQkAAFkJAABfCQAAawkAAHEJAAB3CQAAhQkAAIkJAACPCQAAmwkAAKMJAACpCQAArQkAAMcJAADZCQAA4wkAAOsJAADvCQAA9QkAAPcJAAD9CQAAEwoAAB8KAAAhCgAAMQoAADkKAAA9CgAASQoAAFcKAABhCgAAYwoAAGcKAABvCgAAdQoAAHsKAAB/CgAAgQoAAIUKAACLCgAAkwoAAJcKAACZCgAAnwoAAKkKAACrCgAAtQoAAL0KAADBCgAAzwoAANkKAADlCgAA5woAAO0KAADxCgAA8woAAAMLAAARCwAAFQsAABsLAAAjCwAAKQsAAC0LAAA/CwAARwsAAFELAABXCwAAXQsAAGULAABvCwAAewsAAIkLAACNCwAAkwsAAJkLAACbCwAAtwsAALkLAADDCwAAywsAAM8LAADdCwAA4QsAAOkLAAD1CwAA+wsAAAcMAAALDAAAEQwAACUMAAAvDAAAMQwAAEEMAABbDAAAXwwAAGEMAABtDAAAcwwAAHcMAACDDAAAiQwAAJEMAACVDAAAnQwAALMMAAC1DAAAuQwAALsMAADHDAAA4wwAAOUMAADrDAAA8QwAAPcMAAD7DAAAAQ0AAAMNAAAPDQAAEw0AAB8NAAAhDQAAKw0AAC0NAAA9DQAAPw0AAE8NAABVDQAAaQ0AAHkNAACBDQAAhQ0AAIcNAACLDQAAjQ0AAKMNAACrDQAAtw0AAL0NAADHDQAAyQ0AAM0NAADTDQAA1Q0AANsNAADlDQAA5w0AAPMNAAD9DQAA/w0AAAkOAAAXDgAAHQ4AACEOAAAnDgAALw4AADUOAAA7DgAASw4AAFcOAABZDgAAXQ4AAGsOAABxDgAAdQ4AAH0OAACHDgAAjw4AAJUOAACbDgAAsQ4AALcOAAC5DgAAww4AANEOAADVDgAA2w4AAO0OAADvDgAA+Q4AAAcPAAALDwAADQ8AABcPAAAlDwAAKQ8AADEPAABDDwAARw8AAE0PAABPDwAAUw8AAFkPAABbDwAAZw8AAGsPAAB/DwAAlQ8AAKEPAACjDwAApw8AAK0PAACzDwAAtQ8AALsPAADRDwAA0w8AANkPAADpDwAA7w8AAPsPAAD9DwAAAxAAAA8QAAAfEAAAIRAAACUQAAArEAAAORAAAD0QAAA/EAAAURAAAGkQAABzEAAAeRAAAHsQAACFEAAAhxAAAJEQAACTEAAAnRAAAKMQAAClEAAArxAAALEQAAC7EAAAwRAAAMkQAADnEAAA8RAAAPMQAAD9EAAABREAAAsRAAAVEQAAJxEAAC0RAAA5EQAARREAAEcRAABZEQAAXxEAAGMRAABpEQAAbxEAAIERAACDEQAAjREAAJsRAAChEQAApREAAKcRAACrEQAAwxEAAMURAADREQAA1xEAAOcRAADvEQAA9REAAPsRAAANEgAAHRIAAB8SAAAjEgAAKRIAACsSAAAxEgAANxIAAEESAABHEgAAUxIAAF8SAABxEgAAcxIAAHkSAAB9EgAAjxIAAJcSAACvEgAAsxIAALUSAAC5EgAAvxIAAMESAADNEgAA0RIAAN8SAAD9EgAABxMAAA0TAAAZEwAAJxMAAC0TAAA3EwAAQxMAAEUTAABJEwAATxMAAFcTAABdEwAAZxMAAGkTAABtEwAAexMAAIETAACHEwAAixMAAJETAACTEwAAnRMAAJ8TAACvEwAAuxMAAMMTAADVEwAA2RMAAN8TAADrEwAA7RMAAPMTAAD5EwAA/xMAABsUAAAhFAAALxQAADMUAAA7FAAARRQAAE0UAABZFAAAaxQAAG8UAABxFAAAdRQAAI0UAACZFAAAnxQAAKEUAACxFAAAtxQAAL0UAADLFAAA1RQAAOMUAADnFAAABRUAAAsVAAARFQAAFxUAAB8VAAAlFQAAKRUAACsVAAA3FQAAPRUAAEEVAABDFQAASRUAAF8VAABlFQAAZxUAAGsVAAB9FQAAfxUAAIMVAACPFQAAkRUAAJcVAACbFQAAtRUAALsVAADBFQAAxRUAAM0VAADXFQAA9xUAAAcWAAAJFgAADxYAABMWAAAVFgAAGRYAABsWAAAlFgAAMxYAADkWAAA9FgAARRYAAE8WAABVFgAAaRYAAG0WAABvFgAAdRYAAJMWAACXFgAAnxYAAKkWAACvFgAAtRYAAL0WAADDFgAAzxYAANMWAADZFgAA2xYAAOEWAADlFgAA6xYAAO0WAAD3FgAA+RYAAAkXAAAPFwAAIxcAACcXAAAzFwAAQRcAAF0XAABjFwAA - Metadata: 0x0207E454
	internal static readonly long _290C4A052C215D096172EB81AEE671FB3286E5C1DB5E73F96021FC09825DDB88; // 0xC80 // Static value (base64): S0dTIUAjJCU= - Metadata: 0x0207F094
	internal static readonly __StaticArrayInitTypeSize_3 _32D0830B8EE1D49A66F395C8EA80E02BFC07C2A12A8EA8C8B484AF02108A1950; // 0xC88 // Static value (base64): VQQL - Metadata: 0x0207F0A4
	internal static readonly __StaticArrayInitTypeSize_3 _35BF50EEF3270FD8CA09E66FC5B0481C5A151B14F6A634854E32F63633D49DCB; // 0xC8B // Static value (base64): VQQE - Metadata: 0x0207F0AC
	internal static readonly __StaticArrayInitTypeSize_3 _3C0C410618682C4DF0474E034114CC8E562F05A512B521AC367571017BDFA75D; // 0xC8E // Static value (base64): VQQK - Metadata: 0x0207F0B4
	internal static readonly __StaticArrayInitTypeSize_3 _44F5B1A2C48314502ACCBF186D1A2F9F7F176825898F32F1A2047B956194F174; // 0xC91 // Static value (base64): VQQq - Metadata: 0x0207F0BC
	internal static readonly __StaticArrayInitTypeSize_48 _4800FBFC4566EB02D1727A4B1C949CCBC7535C216A0766564C199308631B5DD6; // 0xC94 // Static value (base64): OLBgp1GsljhM2TJ+sbHjaiH9txEUvgdDTAzHv2P24donTt6/529l+9Ua0vFImLlb - Metadata: 0x0207F0C4
	internal static readonly __StaticArrayInitTypeSize_20 _533B8C444F951E83EFF7305E3807B66CE0005DE0A2D0A44873C130895A3BE6AA; // 0xCC4 // Static value (base64): 2jmj7l5rSw0yVb/vlWAYkK/YBwk= - Metadata: 0x0207F0FC
	internal static readonly __StaticArrayInitTypeSize_256 _55D0BF716B334D123E0088CFB3F8E2FEA17AF5025BB527F95EEB09BA978EA329; // 0xCD8 // Static value (base64): KS5DyaLYfAE9NlSh7PAGE2KnBfPAx3OMmJMr2bxMgsoem1c8/dTgFmdCbxiKF+USvk7E1tqe3kmg+/WOuy/ueqloeZEVsgc/lMIQiQsiXyGAf12aWpAyJzU+zOe/95cD/xkws0iltdHXXpIqrFaqxk+4ONKWpH22dvxr4px0BPFFnXBZZHGHIIZbz2XmLagCG2Alra6wufYcRmFpNEB+D1VHoyPdUa86w1z5zrrF6iYsUw1uhSiECdPfzfRBgU1Satw3yGzBq/ok4XsIDL2xSniIlYvjY+ht6cvV/jsAHTny77cOZljQ5KZ3cvjrdUsKMURQtI/tHxrbmY0znxGDFA== - Metadata: 0x0207F114
	internal static readonly __StaticArrayInitTypeSize_3 _59BE5A634187B8A57216EFF5371A47732C05744B1C1A0A6382A6D5622C9FFDCE; // 0xDD8 // Static value (base64): VQQG - Metadata: 0x0207F21C
	internal static readonly __StaticArrayInitTypeSize_32 _5DF6E0E2761359D30A8275058E299FCC0381534545F55CF43E41983F5D4C9456; // 0xDDB // Static value (base64): 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU= - Metadata: 0x0207F224
	internal static readonly __StaticArrayInitTypeSize_3 _5F8C6B3C66B972606D85E7651F67ADBD02E8316876884674E8328FA710747E5B; // 0xDFB // Static value (base64): VQQM - Metadata: 0x0207F24C
	internal static readonly __StaticArrayInitTypeSize_10 _60C6ED13AF98DBFEEDA8F8197FFFCC349BB04395CC81DF0D477CBC57BF5B398B; // 0xDFE // Static value (base64): CZImiZPyLGQBGQ== - Metadata: 0x0207F254
	internal static readonly __StaticArrayInitTypeSize_10 _64B3E7D737AFF47D4C3BBD81D2D06D697DDD8EB60F29E13E4425D19D8BBCA1F7; // 0xE08 // Static value (base64): CZImiZPyLGQBAQ== - Metadata: 0x0207F264
	internal static readonly long _6772A9B8BF207A3CFE6EE68769D6985B69522183F24A2A3D41BC3B4602953426; // 0xE18 // Static value (base64): TlRMTVNTUAA= - Metadata: 0x0207F274
	internal static readonly __StaticArrayInitTypeSize_9 _684312AFB7719E57993D2826FFBAF7EA965614F20F91D999FB19B01E21AA62E6; // 0xE20 // Static value (base64): KoZIhvcNAQkB - Metadata: 0x0207F284
	internal static readonly __StaticArrayInitTypeSize_64 _6AA56C4BCD208911792AD24C7681FEFB93BED51903AFC54860C9BD37E41E5A31; // 0xE29 // Static value (base64): AwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAw== - Metadata: 0x0207F294
	internal static readonly __StaticArrayInitTypeSize_3 _796E63069E193A008CB4E85573AA1FE53C5F4E58B42A7F61FD0EEE1D89B5120B; // 0xE69 // Static value (base64): VQQH - Metadata: 0x0207F2DC
	internal static readonly __StaticArrayInitTypeSize_64 _7C8975E1E60A5C8337F28EDF8C33C3B180360B7279644A9BC1AF3C51E6220BF5; // 0xE6C // Static value (base64): AQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQ== - Metadata: 0x0207F2E4
	internal static readonly __StaticArrayInitTypeSize_3 _850D7367E4FB0766E2CBC3ACF5AB42B4E98348E58E5A789845D4FCCDB63D2AEE; // 0xEAC // Static value (base64): VQQJ - Metadata: 0x0207F32C
	internal static readonly long _992F16C986809AB68C7466CC3EC6F12B2506A962EA539753E5D84A2FB7FF8A24; // 0xEB0 // Static value (base64): qtO0NbUUBO4= - Metadata: 0x0207F334
	internal static readonly __StaticArrayInitTypeSize_3 _9A65C09A11757751BFED67A414E00B188DC4C7757FCB6CBD33A916DDE4A3D925; // 0xEB8 // Static value (base64): VQQF - Metadata: 0x0207F344
	internal static readonly __StaticArrayInitTypeSize_18 _9ACEFCC0C950280B64AB9E045E38C34ABF71EC70A0DC61B9C621C6BFB4F78047; // 0xEBB // Static value (base64): LAArACIAPQA8AD4AOwAjAAoA - Metadata: 0x0207F34C
	internal static readonly __StaticArrayInitTypeSize_3 B1E34F4A11EE411B83415EF0B252A0B2BBCFCAC2E592865E09C12E4252C93A75; // 0xECD // Static value (base64): VQQu - Metadata: 0x0207F364
	internal static readonly __StaticArrayInitTypeSize_3 C92FAD7F348A682E7D5B7E74C76B5D019174EE7BC87545B25A1FDD49FBCC2D0B; // 0xED0 // Static value (base64): VQQI - Metadata: 0x0207F36C
	internal static readonly __StaticArrayInitTypeSize_3 E17B8359E685992B0DE6242AAA24FCB7404173CBB7FF8646FF7D658139F41B5F; // 0xED3 // Static value (base64): VQQD - Metadata: 0x0207F374
	internal static readonly __StaticArrayInitTypeSize_64 F83B332BE4E6A5A4B1C56AAF6DB52657DA495E149870057D8590AB9D7A6167AD; // 0xED6 // Static value (base64): AgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg== - Metadata: 0x0207F37C
	internal static readonly __StaticArrayInitTypeSize_3 FB6D7301FFDCB5FBA5807A19B4F0606947897C1105240B6BBA815352DBBE2064; // 0xF16 // Static value (base64): VQQr - Metadata: 0x0207F3C4

	// Nested types
	private struct __StaticArrayInitTypeSize_3 // TypeDefIndex: 58016
	{
	}

	private struct __StaticArrayInitTypeSize_9 // TypeDefIndex: 58017
	{
	}

	private struct __StaticArrayInitTypeSize_10 // TypeDefIndex: 58018
	{
	}

	private struct __StaticArrayInitTypeSize_18 // TypeDefIndex: 58019
	{
	}

	private struct __StaticArrayInitTypeSize_20 // TypeDefIndex: 58020
	{
	}

	private struct __StaticArrayInitTypeSize_32 // TypeDefIndex: 58021
	{
	}

	private struct __StaticArrayInitTypeSize_48 // TypeDefIndex: 58022
	{
	}

	private struct __StaticArrayInitTypeSize_64 // TypeDefIndex: 58023
	{
	}

	private struct __StaticArrayInitTypeSize_256 // TypeDefIndex: 58024
	{
	}

	private struct __StaticArrayInitTypeSize_3132 // TypeDefIndex: 58025
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor

	// Methods
	internal static uint ComputeStringHash(string s) => default; // 0x0000000187809354-0x00000001878093A8
}

namespace Mono.Math
{
	public class BigInteger // TypeDefIndex: 58010
	{
		// Fields
		private uint length; // 0x10
		private uint[] data; // 0x18
		internal static readonly uint[] smallPrimes; // 0x00
		private static RandomNumberGenerator rng; // 0x08
	
		// Properties
		private static RandomNumberGenerator Rng { get => default; } // 0x000000018B252890-0x000000018B2528D4 
	
		// Nested types
		public enum Sign // TypeDefIndex: 58007
		{
			Negative = -1,
			Zero = 0,
			Positive = 1
		}
	
		public sealed class ModulusRing // TypeDefIndex: 58008
		{
			// Fields
			private BigInteger mod; // 0x10
			private BigInteger constant; // 0x18
	
			// Constructors
			public ModulusRing() {} // Dummy constructor
			public ModulusRing(BigInteger modulus) {} // 0x000000018B252F7C-0x000000018B252FDC
	
			// Methods
			public void BarrettReduction(BigInteger x) {} // 0x000000018B252EE4-0x000000018B252F7C
			public BigInteger Multiply(BigInteger a, BigInteger b) => default; // 0x000000018B253278-0x000000018B25332C
			public BigInteger Difference(BigInteger a, BigInteger b) => default; // 0x000000018B252FDC-0x000000018B253204
			public BigInteger Pow(BigInteger a, BigInteger k) => default; // 0x000000018B253204-0x000000018B253278
			public BigInteger Pow(uint b, BigInteger exp) => default; // 0x000000018B2535E4-0x000000018B253644
		}
	
		private sealed class Kernel // TypeDefIndex: 58009
		{
			// Constructors
			public Kernel() {} // Dummy constructor
	
			// Methods
			public static BigInteger AddSameSign(BigInteger bi1, BigInteger bi2) => default; // 0x000000018B253644-0x000000018B2536F4
			public static BigInteger Subtract(BigInteger big, BigInteger small) => default; // 0x000000018B2533D4-0x000000018B25349C
			public static void MinusEq(BigInteger big, BigInteger small) {} // 0x000000018B253A64-0x000000018B253C30
			public static void PlusEq(BigInteger bi1, BigInteger bi2) {} // 0x000000018B253840-0x000000018B253848
			public static Sign Compare(BigInteger bi1, BigInteger bi2) => default; // 0x000000018B253814-0x000000018B253840
			public static uint SingleByteDivideInPlace(BigInteger n, uint d) => default; // 0x000000018B25349C-0x000000018B2534C8
			public static uint DwordMod(BigInteger n, uint d) => default; // 0x000000018B253848-0x000000018B253A5C
			public static BigInteger[] DwordDivMod(BigInteger n, uint d) => default; // 0x000000018B2537E0-0x000000018B2537E8
			public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) => default; // 0x000000018B253A5C-0x000000018B253A64
			public static BigInteger LeftShift(BigInteger bi, int n) => default; // 0x000000018B25332C-0x000000018B2533D4
			public static BigInteger RightShift(BigInteger bi, int n) => default; // 0x000000018B2525CC-0x000000018B25272C
			public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) {} // 0x000000018B25272C-0x000000018B252778
			public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) {} // 0x000000018B2523D8-0x000000018B252434
			public static uint modInverse(BigInteger bi, uint modulus) => default; // 0x000000018B252B0C-0x000000018B252BAC
			public static BigInteger modInverse(BigInteger bi, BigInteger modulus) => default; // 0x000000018B252AAC-0x000000018B252AB8
		}
	
		// Constructors
		public BigInteger() {} // Dummy constructor
		public BigInteger(Sign sign, uint len) {} // 0x000000018B252AB8-0x000000018B252B0C
		public BigInteger(BigInteger bi) {} // 0x000000018B25295C-0x000000018B2529D0
		public BigInteger(BigInteger bi, uint len) {} // 0x000000018B252778-0x000000018B252890
		public BigInteger(byte[] inData) {} // 0x000000018B2534C8-0x000000018B253520
		public BigInteger(uint ui) {} // 0x000000018B253788-0x000000018B2537E0
		static BigInteger() {} // 0x000000018B2556E0-0x000000018B255B70
	
		// Methods
		public static implicit operator BigInteger(uint value) => default; // 0x000000018B253520-0x000000018B2535B4
		public static implicit operator BigInteger(int value) => default; // 0x000000018B2536F4-0x000000018B253788
		public static BigInteger operator +(BigInteger bi1, BigInteger bi2) => default; // 0x000000018B2535CC-0x000000018B2535E4
		public static BigInteger operator -(BigInteger bi1, BigInteger bi2) => default; // 0x000000018B253800-0x000000018B253814
		public static uint operator %(BigInteger bi, uint ui) => default; // 0x000000018B2535B4-0x000000018B2535CC
		public static BigInteger operator %(BigInteger bi1, BigInteger bi2) => default; // 0x000000018B2537E8-0x000000018B253800
		public static BigInteger operator /(BigInteger bi1, BigInteger bi2) => default; // 0x000000018B252DFC-0x000000018B252E48
		public static BigInteger operator *(BigInteger bi1, BigInteger bi2) => default; // 0x000000018B252BAC-0x000000018B252DFC
		public static BigInteger operator <<(BigInteger bi1, int shiftVal) => default; // 0x000000018B252A60-0x000000018B252AAC
		public static BigInteger operator >>(BigInteger bi1, int shiftVal) => default; // 0x000000018B252434-0x000000018B25247C
		public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) => default; // 0x000000018B252E48-0x000000018B252E58
		public static BigInteger GenerateRandom(int bits) => default; // 0x000000018B25247C-0x000000018B25255C
		public int BitCount() => default; // 0x000000018B2529D0-0x000000018B2529D8
		public bool TestBit(int bitNum) => default; // 0x000000018B2529D8-0x000000018B252A60
		public void SetBit(uint bitNum) {} // 0x000000018B25255C-0x000000018B2525CC
		public void SetBit(uint bitNum, bool value) {} // 0x000000018B2528D4-0x000000018B25295C
		public int LowestSetBit() => default; // 0x000000018B252E58-0x000000018B252EE4
		public byte[] GetBytes() => default; // 0x000000018B2585D4-0x000000018B2586C8
		public static bool operator ==(BigInteger bi1, uint ui) => default; // 0x000000018B257E88-0x000000018B258144
		public static bool operator !=(BigInteger bi1, uint ui) => default; // 0x000000018B2582E0-0x000000018B25843C
		public static bool operator ==(BigInteger bi1, BigInteger bi2) => default; // 0x000000018B258144-0x000000018B2582E0
		public static bool operator !=(BigInteger bi1, BigInteger bi2) => default; // 0x000000018B2584C0-0x000000018B2585D4
		public static bool operator >(BigInteger bi1, BigInteger bi2) => default; // 0x000000018B25843C-0x000000018B2584C0
		public static bool operator <(BigInteger bi1, BigInteger bi2) => default; // 0x000000018B2546C4-0x000000018B254894
		public static bool operator >=(BigInteger bi1, BigInteger bi2) => default; // 0x000000018B255488-0x000000018B255634
		public static bool operator <=(BigInteger bi1, BigInteger bi2) => default; // 0x000000018B254D60-0x000000018B254E88
		public string ToString(uint radix) => default; // 0x000000018B2550D0-0x000000018B255268
		public string ToString(uint radix, string characterSet) => default; // 0x000000018B254894-0x000000018B2549C8
		private void Normalize() {} // 0x000000018B25541C-0x000000018B255488
		public void Clear() {} // 0x000000018B254B30-0x000000018B254B88
		public override int GetHashCode() => default; // 0x000000018B2549C8-0x000000018B254B30
		public override string ToString() => default; // 0x000000018B255B70-0x000000018B2560EC
		public override bool Equals(object o) => default; // 0x000000018B254B88-0x000000018B254D60
		public BigInteger ModInverse(BigInteger modulus) => default; // 0x000000018B255268-0x000000018B25541C
		public BigInteger ModPow(BigInteger exp, BigInteger n) => default; // 0x000000018B254FBC-0x000000018B2550D0
		public static BigInteger GeneratePseudoPrime(int bits) => default; // 0x000000018B254E88-0x000000018B254FBC
		public void Incr2() {} // 0x000000018B255634-0x000000018B2556E0
	}
}

namespace Mono.Math.Prime
{
	public enum ConfidenceFactor // TypeDefIndex: 58011
	{
		ExtraLow = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		ExtraHigh = 4,
		Provable = 5
	}

	public delegate bool PrimalityTest(BigInteger bi, ConfidenceFactor confidence); // TypeDefIndex: 58012; 0x0000000181B59400-0x0000000181B59410

	public sealed class PrimalityTests // TypeDefIndex: 58013
	{
		// Constructors
		public PrimalityTests() {} // Dummy constructor
	
		// Methods
		private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) => default; // 0x000000018B259BE8-0x000000018B259D9C
		public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence) => default; // 0x000000018B259D9C-0x000000018B25A024
	}
}

namespace Mono.Math.Prime.Generator
{
	public abstract class PrimeGeneratorBase // TypeDefIndex: 58014
	{
		// Properties
		public virtual ConfidenceFactor Confidence { get; } // 0x0000000181C6A970-0x0000000181C6A980 
		public virtual PrimalityTest PrimalityTest { get; } // 0x000000018B25A024-0x000000018B25A08C 
		public virtual int TrialDivisionBounds { get; } // 0x0000000185FBE5C0-0x0000000185FBE5D0 
	
		// Constructors
		protected PrimeGeneratorBase() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public abstract BigInteger GenerateNewPrime(int bits);
	}

	public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 58015
	{
		// Constructors
		public SequentialSearchPrimeGeneratorBase() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected virtual BigInteger GenerateSearchBase(int bits, object context) => default; // 0x000000018B25D278-0x000000018B25D2D8
		public override BigInteger GenerateNewPrime(int bits) => default; // 0x000000018B25D26C-0x000000018B25D278
		public virtual BigInteger GenerateNewPrime(int bits, object context) => default; // 0x000000018B25D058-0x000000018B25D26C
		protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) => default; // 0x00000001840A27C0-0x00000001840A27D0
	}
}

namespace Mono.Security
{
	public class ASN1 // TypeDefIndex: 57925
	{
		// Fields
		private byte m_nTag; // 0x10
		private byte[] m_aValue; // 0x18
		private ArrayList elist; // 0x20
	
		// Properties
		public int Count { get => default; } // 0x000000018B23BF54-0x000000018B23BF7C 
		public byte Tag { get => default; } // 0x0000000181C2FD60-0x0000000181C2FD70 
		public int Length { get => default; } // 0x000000018AA85BD8-0x000000018AA85BEC 
		public byte[] Value { get => default; set {} } // 0x000000018B23C06C-0x000000018B23C0CC 0x000000018B23C0CC-0x000000018B23C140
		public ASN1 this[int index] { get => default; } // 0x000000018B23BF7C-0x000000018B23C06C 
	
		// Constructors
		public ASN1() {} // Dummy constructor
		public ASN1(byte tag) {} // 0x0000000186472D90-0x0000000186472DB0
		public ASN1(byte tag, byte[] data) {} // 0x000000018470BFE0-0x000000018470BFF0
		public ASN1(byte[] data) {} // 0x000000018B23BDE4-0x000000018B23BF54
	
		// Methods
		private bool CompareArray(byte[] array1, byte[] array2) => default; // 0x000000018B23B294-0x000000018B23B2F8
		public bool CompareValue(byte[] value) => default; // 0x000000018B23B2F8-0x000000018B23B308
		public ASN1 Add(ASN1 asn1) => default; // 0x000000018B23B1FC-0x000000018B23B294
		public virtual byte[] GetBytes() => default; // 0x000000018B23B640-0x000000018B23BBBC
		protected void Decode(byte[] asn1, ref int anPos, int anLength) {} // 0x000000018B23B408-0x000000018B23B52C
		protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) {
			tag = default;
			length = default;
			content = default;
		} // 0x000000018B23B308-0x000000018B23B408
		public ASN1 Element(int index, byte anTag) => default; // 0x000000018B23B52C-0x000000018B23B640
		public override string ToString() => default; // 0x000000018B23BBBC-0x000000018B23BDE4
	}

	public static class ASN1Convert // TypeDefIndex: 57926
	{
		// Methods
		public static ASN1 FromInt32(int value) => default; // 0x000000018B23A6C8-0x000000018B23A7F8
		public static ASN1 FromOid(string oid) => default; // 0x000000018B23A7F8-0x000000018B23A8D0
		public static ASN1 FromUnsignedBigInteger(byte[] big) => default; // 0x000000018B23A8D0-0x000000018B23A9EC
		public static int ToInt32(ASN1 asn1) => default; // 0x000000018B23AE74-0x000000018B23AF98
		public static string ToOid(ASN1 asn1) => default; // 0x000000018B23AF98-0x000000018B23B1FC
		public static System.DateTime ToDateTime(ASN1 time) => default; // 0x000000018B23A9EC-0x000000018B23AE74
	}

	internal sealed class BitConverterLE // TypeDefIndex: 57927
	{
		// Constructors
		public BitConverterLE() {} // Dummy constructor
	
		// Methods
		private static unsafe byte[] GetUIntBytes(byte* bytes) => default; // 0x000000018B23CC64-0x000000018B23CD40
		private static unsafe byte[] GetULongBytes(byte* bytes) => default; // 0x000000018B23CD40-0x000000018B23CE9C
		internal static byte[] GetBytes(int value) => default; // 0x000000018B23CC48-0x000000018B23CC64
		internal static byte[] GetBytes(long value) => default; // 0x000000018B23CC2C-0x000000018B23CC48
		private static unsafe void UShortFromBytes(byte* dst, byte[] src, int startIndex) {} // 0x000000018B23CFE4-0x000000018B23D098
		private static unsafe void UIntFromBytes(byte* dst, byte[] src, int startIndex) {} // 0x000000018B23CEEC-0x000000018B23CFE4
		internal static int ToInt32(byte[] value, int startIndex) => default; // 0x000000018B23CE9C-0x000000018B23CEC4
		internal static ushort ToUInt16(byte[] value, int startIndex) => default; // 0x000000018B23CEC4-0x000000018B23CEEC
		internal static uint ToUInt32(byte[] value, int startIndex) => default; // 0x000000018B23CE9C-0x000000018B23CEC4
	}

	public sealed class PKCS7 // TypeDefIndex: 57932
	{
		// Nested types
		public class ContentInfo // TypeDefIndex: 57928
		{
			// Fields
			private string contentType; // 0x10
			private ASN1 content; // 0x18
	
			// Properties
			public ASN1 ASN1 { get => default; } // 0x000000018B23F228-0x000000018B23F230 
			public ASN1 Content { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
			public string ContentType { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
	
			// Constructors
			public ContentInfo() {} // 0x000000018B23EF40-0x000000018B23EFA8
			public ContentInfo(string oid) {} // 0x000000018B23F020-0x000000018B23F050
			public ContentInfo(byte[] data) {} // 0x000000018B23EFA8-0x000000018B23F020
			public ContentInfo(ASN1 asn1) {} // 0x000000018B23F050-0x000000018B23F228
	
			// Methods
			internal ASN1 GetASN1() => default; // 0x000000018B23EEA4-0x000000018B23EF40
		}
	
		public class EncryptedData // TypeDefIndex: 57929
		{
			// Fields
			private byte _version; // 0x10
			private ContentInfo _content; // 0x18
			private ContentInfo _encryptionAlgorithm; // 0x20
			private byte[] _encrypted; // 0x28
	
			// Properties
			public ContentInfo EncryptionAlgorithm { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
			public byte[] EncryptedContent { get => default; } // 0x000000018B23FFB8-0x000000018B24000C 
	
			// Constructors
			public EncryptedData() {} // 0x0000000185FB6A70-0x0000000185FB6A80
			public EncryptedData(ASN1 asn1) {} // 0x000000018B23FB98-0x000000018B23FFB8
		}
	
		public class SignedData // TypeDefIndex: 57930
		{
			// Fields
			private byte version; // 0x10
			private string hashAlgorithm; // 0x18
			private ContentInfo contentInfo; // 0x20
			private Mono.Security.X509.X509CertificateCollection certs; // 0x28
			private ArrayList crls; // 0x30
			private SignerInfo signerInfo; // 0x38
			private bool mda; // 0x40
	
			// Properties
			public Mono.Security.X509.X509CertificateCollection Certificates { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
			public ContentInfo ContentInfo { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
			public string HashName { set {} } // 0x000000018B247C5C-0x000000018B247C94
			public SignerInfo SignerInfo { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
	
			// Constructors
			public SignedData() {} // Dummy constructor
			public SignedData(ASN1 asn1) {} // 0x000000018B247684-0x000000018B247C5C
	
			// Methods
			internal string OidToName(string oid) => default; // 0x000000018B247514-0x000000018B247684
		}
	
		public class SignerInfo // TypeDefIndex: 57931
		{
			// Fields
			private byte version; // 0x10
			private string hashAlgorithm; // 0x18
			private ArrayList authenticatedAttributes; // 0x20
			private ArrayList unauthenticatedAttributes; // 0x28
			private byte[] signature; // 0x30
			private string issuer; // 0x38
			private byte[] serial; // 0x40
			private byte[] ski; // 0x48
	
			// Properties
			public string IssuerName { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
			public byte[] SerialNumber { get => default; } // 0x000000018B248158-0x000000018B2481AC 
			public ArrayList AuthenticatedAttributes { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
			public string HashName { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
			public byte[] Signature { get => default; } // 0x000000018B2481AC-0x000000018B248200 
			public ArrayList UnauthenticatedAttributes { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
			public byte Version { get => default; } // 0x0000000181C2FD60-0x0000000181C2FD70 
	
			// Constructors
			public SignerInfo() {} // 0x000000018B247C94-0x000000018B247D28
			public SignerInfo(ASN1 asn1) {} // 0x000000018B247D28-0x000000018B248158
		}
	
		// Constructors
		public PKCS7() {} // Dummy constructor
	}
}

namespace Mono.Security.Authenticode
{
	public class AuthenticodeBase // TypeDefIndex: 58005
	{
		// Fields
		private byte[] fileblock; // 0x10
		private Stream fs; // 0x18
		private int blockNo; // 0x20
		private int blockLength; // 0x24
		private int peOffset; // 0x28
		private int dirSecurityOffset; // 0x2C
		private int dirSecuritySize; // 0x30
		private int coffSymbolTableOffset; // 0x34
		private bool pe64; // 0x38
	
		// Properties
		internal int PEOffset { get => default; } // 0x000000018B250A24-0x000000018B250A48 
	
		// Constructors
		public AuthenticodeBase() {} // 0x000000018B2509DC-0x000000018B250A24
	
		// Methods
		internal void Open(string filename) {} // 0x000000018B250580-0x000000018B250620
		internal void Open(byte[] rawdata) {} // 0x000000018B250620-0x000000018B2506B0
		internal void Close() {} // 0x000000018B250070-0x000000018B2500AC
		internal void ReadFirstBlock() {} // 0x000000018B2508F8-0x000000018B2509DC
		internal int ProcessFirstBlock() => default; // 0x000000018B2506B0-0x000000018B2508F8
		internal byte[] GetSecurityEntry() => default; // 0x000000018B2504D0-0x000000018B250580
		internal byte[] GetHash(HashAlgorithm hash) => default; // 0x000000018B2500AC-0x000000018B2504D0
	}

	public class AuthenticodeDeformatter : AuthenticodeBase // TypeDefIndex: 58006
	{
		// Fields
		private string filename; // 0x40
		private byte[] rawdata; // 0x48
		private byte[] hash; // 0x50
		private Mono.Security.X509.X509CertificateCollection coll; // 0x58
		private ASN1 signedHash; // 0x60
		private System.DateTime timestamp; // 0x68
		private Mono.Security.X509.X509Certificate signingCertificate; // 0x70
		private int reason; // 0x78
		private bool trustedRoot; // 0x7C
		private bool trustedTimestampRoot; // 0x7D
		private byte[] entry; // 0x80
		private Mono.Security.X509.X509Chain signerChain; // 0x88
		private Mono.Security.X509.X509Chain timestampChain; // 0x90
	
		// Properties
		public byte[] RawData { set {} } // 0x000000018B2522EC-0x000000018B2523D8
		public Mono.Security.X509.X509Certificate SigningCertificate { get => default; } // 0x0000000181460F70-0x0000000181460F80 
	
		// Constructors
		public AuthenticodeDeformatter() {} // 0x000000018B252210-0x000000018B2522BC
		public AuthenticodeDeformatter(byte[] rawData) {} // 0x000000018B2522BC-0x000000018B2522EC
	
		// Methods
		private bool CheckSignature() => default; // 0x000000018B250A48-0x000000018B250D44
		private bool CompareIssuerSerial(string issuer, byte[] serial, Mono.Security.X509.X509Certificate x509) => default; // 0x000000018B250D44-0x000000018B250E04
		private bool VerifySignature(PKCS7.SignedData sd, byte[] calculatedMessageDigest, HashAlgorithm ha) => default; // 0x000000018B2517F0-0x000000018B252210
		private bool VerifyCounterSignature(PKCS7.SignerInfo cs, byte[] signature) => default; // 0x000000018B250EE0-0x000000018B2517F0
		private void Reset() {} // 0x000000018B250E04-0x000000018B250EE0
	}
}

namespace Mono.Security.Cryptography
{
	public sealed class CryptoConvert // TypeDefIndex: 57994
	{
		// Constructors
		public CryptoConvert() {} // Dummy constructor
	
		// Methods
		public static string ToHex(byte[] input) => default; // 0x000000018B253E08-0x000000018B253EF8
		private static byte FromHexChar(char c) => default; // 0x000000018B253C30-0x000000018B253CB8
		public static byte[] FromHex(string hex) => default; // 0x000000018B253CB8-0x000000018B253E08
	}

	public abstract class MD2 : HashAlgorithm // TypeDefIndex: 57995
	{
		// Constructors
		protected MD2() {} // 0x0000000185FCF290-0x0000000185FCF2A0
	
		// Methods
		public static MD2 Create() => default; // 0x000000018B2566F0-0x000000018B256740
	}

	public class MD2Managed : MD2 // TypeDefIndex: 57996
	{
		// Fields
		private byte[] state; // 0x28
		private byte[] checksum; // 0x30
		private byte[] buffer; // 0x38
		private int count; // 0x40
		private byte[] x; // 0x48
		private static readonly byte[] PI_SUBST; // 0x00
	
		// Constructors
		public MD2Managed() {} // 0x000000018B256638-0x000000018B2566F0
		static MD2Managed() {} // 0x000000018B2565AC-0x000000018B256638
	
		// Methods
		private byte[] Padding(int nLength) => default; // 0x000000018B256534-0x000000018B2565AC
		public override void Initialize() {} // 0x000000018B256298-0x000000018B2562F4
		protected override void HashCore(byte[] array, int ibStart, int cbSize) {} // 0x000000018B2560EC-0x000000018B2561E8
		protected override byte[] HashFinal() => default; // 0x000000018B2561E8-0x000000018B256298
		private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) {} // 0x000000018B2562F4-0x000000018B256534
	}

	public abstract class MD4 : HashAlgorithm // TypeDefIndex: 57997
	{
		// Constructors
		protected MD4() {} // 0x0000000185FCF290-0x0000000185FCF2A0
	
		// Methods
		public static MD4 Create() => default; // 0x000000018B257A30-0x000000018B257A80
	}

	public class MD4Managed : MD4 // TypeDefIndex: 57998
	{
		// Fields
		private uint[] state; // 0x28
		private byte[] buffer; // 0x30
		private uint[] count; // 0x38
		private uint[] x; // 0x40
		private byte[] digest; // 0x48
	
		// Constructors
		public MD4Managed() {} // 0x000000018B257950-0x000000018B257A30
	
		// Methods
		public override void Initialize() {} // 0x000000018B256B1C-0x000000018B256BE8
		protected override void HashCore(byte[] array, int ibStart, int cbSize) {} // 0x000000018B25689C-0x000000018B256A1C
		protected override byte[] HashFinal() => default; // 0x000000018B256A1C-0x000000018B256B1C
		private byte[] Padding(int nLength) => default; // 0x000000018B2578F4-0x000000018B257950
		private uint F(uint x, uint y, uint z) => default; // 0x0000000185FCF2E0-0x0000000185FCF2F0
		private uint G(uint x, uint y, uint z) => default; // 0x0000000185FCF340-0x0000000185FCF350
		private uint H(uint x, uint y, uint z) => default; // 0x0000000185FCF390-0x0000000185FCF3A0
		private uint ROL(uint x, byte n) => default; // 0x0000000185FCF3A0-0x0000000185FCF3C0
		private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) {} // 0x0000000185FCF2A0-0x0000000185FCF2E0
		private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) {} // 0x0000000185FCF2F0-0x0000000185FCF340
		private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) {} // 0x0000000185FCF350-0x0000000185FCF390
		private void Encode(byte[] output, uint[] input) {} // 0x000000018B2567D8-0x000000018B25689C
		private void Decode(uint[] output, byte[] input, int index) {} // 0x000000018B256740-0x000000018B2567D8
		private void MD4Transform(uint[] state, byte[] block, int index) {} // 0x000000018B256BE8-0x000000018B2578F4
	}

	public sealed class PKCS1 // TypeDefIndex: 57999
	{
		// Fields
		private static byte[] emptySHA1; // 0x00
		private static byte[] emptySHA256; // 0x08
		private static byte[] emptySHA384; // 0x10
		private static byte[] emptySHA512; // 0x18
	
		// Constructors
		public PKCS1() {} // Dummy constructor
		static PKCS1() {} // 0x000000018B259924-0x000000018B259AC0
	
		// Methods
		private static bool Compare(byte[] array1, byte[] array2) => default; // 0x000000018B258C14-0x000000018B258C78
		public static byte[] I2OSP(byte[] x, int size) => default; // 0x000000018B259638-0x000000018B2596B8
		public static byte[] OS2IP(byte[] x) => default; // 0x000000018B2596B8-0x000000018B259768
		public static byte[] RSAVP1(RSA rsa, byte[] s) => default; // 0x0000000184F77FC0-0x0000000184F77FF0
		public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) => default; // 0x000000018B259768-0x000000018B259924
		public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) => default; // 0x000000018B259008-0x000000018B259320
		internal static string HashNameFromOid(string oid, bool throwOnError = true /* Metadata: 0x0207E3FB */) => default; // 0x000000018B259320-0x000000018B259638
		internal static HashAlgorithm CreateFromOid(string oid) => default; // 0x000000018B258FB8-0x000000018B259008
		internal static HashAlgorithm CreateFromName(string name) => default; // 0x000000018B258C78-0x000000018B258FB8
	}

	public sealed class PKCS8 // TypeDefIndex: 58002
	{
		// Nested types
		public class PrivateKeyInfo // TypeDefIndex: 58000
		{
			// Fields
			private int _version; // 0x10
			private string _algorithm; // 0x18
			private byte[] _key; // 0x20
			private ArrayList _list; // 0x28
	
			// Properties
			public string Algorithm { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
			public byte[] PrivateKey { get => default; set {} } // 0x000000018B25B2E4-0x000000018B25B338 0x000000018B25B338-0x000000018B25B400
	
			// Constructors
			public PrivateKeyInfo() {} // 0x000000018B25B24C-0x000000018B25B2B4
			public PrivateKeyInfo(byte[] data) {} // 0x000000018B25B2B4-0x000000018B25B2E4
	
			// Methods
			private void Decode(byte[] data) {} // 0x000000018B25A6D4-0x000000018B25A9D8
			public byte[] GetBytes() => default; // 0x000000018B25AD20-0x000000018B25B110
			private static byte[] RemoveLeadingZero(byte[] bigInt) => default; // 0x000000018B25B1A8-0x000000018B25B24C
			private static byte[] Normalize(byte[] bigInt, int length) => default; // 0x000000018B25B110-0x000000018B25B1A8
			public static RSA DecodeRSA(byte[] keypair) => default; // 0x000000018B25A1BC-0x000000018B25A6D4
			public static byte[] Encode(RSA rsa) => default; // 0x000000018B25AA1C-0x000000018B25AC18
			public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) => default; // 0x000000018B25A08C-0x000000018B25A1BC
			public static byte[] Encode(DSA dsa) => default; // 0x000000018B25A9D8-0x000000018B25AA1C
			public static byte[] Encode(AsymmetricAlgorithm aa) => default; // 0x000000018B25AC18-0x000000018B25AD20
		}
	
		public class EncryptedPrivateKeyInfo // TypeDefIndex: 58001
		{
			// Fields
			private string _algorithm; // 0x10
			private byte[] _salt; // 0x18
			private int _iterations; // 0x20
			private byte[] _data; // 0x28
	
			// Properties
			public string Algorithm { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
			public byte[] EncryptedData { get => default; set {} } // 0x000000018B2544E0-0x000000018B254534 0x000000018B2545D0-0x000000018B254640
			public byte[] Salt { get => default; } // 0x000000018B254534-0x000000018B2545D0 
			public int IterationCount { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x000000018B254640-0x000000018B2546C4
	
			// Constructors
			public EncryptedPrivateKeyInfo() {} // 0x0000000185492010-0x0000000185492020
			public EncryptedPrivateKeyInfo(byte[] data) {} // 0x000000018B2544D8-0x000000018B2544E0
	
			// Methods
			private void Decode(byte[] data) {} // 0x000000018B253EF8-0x000000018B2542D8
			public byte[] GetBytes() => default; // 0x000000018B2542D8-0x000000018B2544D8
		}
	
		// Constructors
		public PKCS8() {} // Dummy constructor
	}

	public class RSAManaged : RSA // TypeDefIndex: 58004
	{
		// Fields
		private bool isCRTpossible; // 0x20
		private bool keyBlinding; // 0x21
		private bool keypairGenerated; // 0x22
		private bool m_disposed; // 0x23
		private BigInteger d; // 0x28
		private BigInteger p; // 0x30
		private BigInteger q; // 0x38
		private BigInteger dp; // 0x40
		private BigInteger dq; // 0x48
		private BigInteger qInv; // 0x50
		private BigInteger n; // 0x58
		private BigInteger e; // 0x60
		private KeyGeneratedEventHandler KeyGenerated; // 0x68
	
		// Properties
		public override int KeySize { get => default; } // 0x000000018B25B400-0x000000018B25B770 
		public bool PublicOnly { get => default; } // 0x000000018B25B9E0-0x000000018B25BB0C 
	
		// Nested types
		public delegate void KeyGeneratedEventHandler(object sender, EventArgs e); // TypeDefIndex: 58003; 0x000000018B25CE84-0x000000018B25CF40
	
		// Constructors
		public RSAManaged() {} // 0x000000018B25BED0-0x000000018B25BF48
		public RSAManaged(int keySize) {} // 0x000000018B25BF48-0x000000018B25C20C
	
		// Methods
		~RSAManaged() {} // 0x000000018B25CF40-0x000000018B25CFD8
		private void GenerateKeyPair() {} // 0x000000018B25CFD8-0x000000018B25D058
		public override byte[] DecryptValue(byte[] rgb) => default; // 0x000000018B25BB0C-0x000000018B25BED0
		public override byte[] EncryptValue(byte[] rgb) => default; // 0x000000018B25C2B8-0x000000018B25C8DC
		public override RSAParameters ExportParameters(bool includePrivateParameters) => default; // 0x000000018B25B770-0x000000018B25B9E0
		public override void ImportParameters(RSAParameters parameters) {} // 0x000000018B25C8DC-0x000000018B25CE74
		protected override void Dispose(bool disposing) {} // 0x000000018B25C20C-0x000000018B25C2B8
		public override string ToXmlString(bool includePrivateParameters) => default; // 0x0000000188FDE568-0x0000000188FDE690
		private byte[] GetPaddedValue(BigInteger value, int length) => default; // 0x00000001831C5680-0x00000001831C5690
	}
}

namespace Mono.Security.Interface
{
	public enum AlertLevel : byte // TypeDefIndex: 57978
	{
		Warning = 1,
		Fatal = 2
	}

	public enum AlertDescription : byte // TypeDefIndex: 57979
	{
		CloseNotify = 0,
		UnexpectedMessage = 10,
		BadRecordMAC = 20,
		DecryptionFailed_RESERVED = 21,
		RecordOverflow = 22,
		DecompressionFailure = 30,
		HandshakeFailure = 40,
		NoCertificate_RESERVED = 41,
		BadCertificate = 42,
		UnsupportedCertificate = 43,
		CertificateRevoked = 44,
		CertificateExpired = 45,
		CertificateUnknown = 46,
		IlegalParameter = 47,
		UnknownCA = 48,
		AccessDenied = 49,
		DecodeError = 50,
		DecryptError = 51,
		ExportRestriction = 60,
		ProtocolVersion = 70,
		InsuficientSecurity = 71,
		InternalError = 80,
		UserCancelled = 90,
		NoRenegotiation = 100,
		UnsupportedExtension = 110
	}

	public class Alert // TypeDefIndex: 57980
	{
		// Fields
		private AlertLevel level; // 0x10
		private AlertDescription description; // 0x11
	
		// Properties
		public AlertLevel Level { get => default; } // 0x0000000181C2FD60-0x0000000181C2FD70 
		public AlertDescription Description { get => default; } // 0x0000000185FB22C0-0x0000000185FB22D0 
	
		// Constructors
		public Alert() {} // Dummy constructor
		public Alert(AlertDescription description) {} // 0x000000018B24FFF8-0x000000018B250004
	
		// Methods
		private void inferAlertLevel() {} // 0x000000018B250004-0x000000018B250070
		public override string ToString() => default; // 0x000000018B24FF64-0x000000018B24FFF8
	}

	public class ValidationResult // TypeDefIndex: 57981
	{
		// Fields
		private bool trusted; // 0x10
		private bool user_denied; // 0x11
		private int error_code; // 0x14
		private MonoSslPolicyErrors? policy_errors; // 0x18
	
		// Properties
		public bool Trusted { get => default; } // 0x0000000181C2FD60-0x0000000181C2FD70 
		public bool UserDenied { get => default; } // 0x0000000185FB22C0-0x0000000185FB22D0 
	
		// Constructors
		public ValidationResult() {} // Dummy constructor
		public ValidationResult(bool trusted, bool user_denied, int error_code, MonoSslPolicyErrors? policy_errors) {} // 0x0000000185FCF410-0x0000000185FCF430
	}

	public interface ICertificateValidator // TypeDefIndex: 57982
	{
	}

	public enum CipherSuiteCode : ushort // TypeDefIndex: 57983
	{
		TLS_NULL_WITH_NULL_NULL = 0,
		TLS_RSA_WITH_NULL_MD5 = 1,
		TLS_RSA_WITH_NULL_SHA = 2,
		TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3,
		TLS_RSA_WITH_RC4_128_MD5 = 4,
		TLS_RSA_WITH_RC4_128_SHA = 5,
		TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6,
		TLS_RSA_WITH_IDEA_CBC_SHA = 7,
		TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8,
		TLS_RSA_WITH_DES_CBC_SHA = 9,
		TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10,
		TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11,
		TLS_DH_DSS_WITH_DES_CBC_SHA = 12,
		TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13,
		TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14,
		TLS_DH_RSA_WITH_DES_CBC_SHA = 15,
		TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16,
		TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17,
		TLS_DHE_DSS_WITH_DES_CBC_SHA = 18,
		TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19,
		TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20,
		TLS_DHE_RSA_WITH_DES_CBC_SHA = 21,
		TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22,
		TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23,
		TLS_DH_anon_WITH_RC4_128_MD5 = 24,
		TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25,
		TLS_DH_anon_WITH_DES_CBC_SHA = 26,
		TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27,
		TLS_PSK_WITH_NULL_SHA = 44,
		TLS_DHE_PSK_WITH_NULL_SHA = 45,
		TLS_RSA_PSK_WITH_NULL_SHA = 46,
		TLS_RSA_WITH_AES_128_CBC_SHA = 47,
		TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48,
		TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49,
		TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50,
		TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51,
		TLS_DH_anon_WITH_AES_128_CBC_SHA = 52,
		TLS_RSA_WITH_AES_256_CBC_SHA = 53,
		TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54,
		TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55,
		TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56,
		TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57,
		TLS_DH_anon_WITH_AES_256_CBC_SHA = 58,
		TLS_RSA_WITH_NULL_SHA256 = 59,
		TLS_RSA_WITH_AES_128_CBC_SHA256 = 60,
		TLS_RSA_WITH_AES_256_CBC_SHA256 = 61,
		TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62,
		TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63,
		TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64,
		TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65,
		TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66,
		TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67,
		TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68,
		TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69,
		TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70,
		TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103,
		TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104,
		TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105,
		TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106,
		TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107,
		TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108,
		TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109,
		TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132,
		TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133,
		TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134,
		TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135,
		TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136,
		TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137,
		TLS_PSK_WITH_RC4_128_SHA = 138,
		TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139,
		TLS_PSK_WITH_AES_128_CBC_SHA = 140,
		TLS_PSK_WITH_AES_256_CBC_SHA = 141,
		TLS_DHE_PSK_WITH_RC4_128_SHA = 142,
		TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143,
		TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144,
		TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145,
		TLS_RSA_PSK_WITH_RC4_128_SHA = 146,
		TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147,
		TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148,
		TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149,
		TLS_RSA_WITH_SEED_CBC_SHA = 150,
		TLS_DH_DSS_WITH_SEED_CBC_SHA = 151,
		TLS_DH_RSA_WITH_SEED_CBC_SHA = 152,
		TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153,
		TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154,
		TLS_DH_anon_WITH_SEED_CBC_SHA = 155,
		TLS_RSA_WITH_AES_128_GCM_SHA256 = 156,
		TLS_RSA_WITH_AES_256_GCM_SHA384 = 157,
		TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158,
		TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159,
		TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160,
		TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161,
		TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162,
		TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163,
		TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164,
		TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165,
		TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166,
		TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167,
		TLS_PSK_WITH_AES_128_GCM_SHA256 = 168,
		TLS_PSK_WITH_AES_256_GCM_SHA384 = 169,
		TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170,
		TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171,
		TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172,
		TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173,
		TLS_PSK_WITH_AES_128_CBC_SHA256 = 174,
		TLS_PSK_WITH_AES_256_CBC_SHA384 = 175,
		TLS_PSK_WITH_NULL_SHA256 = 176,
		TLS_PSK_WITH_NULL_SHA384 = 177,
		TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178,
		TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179,
		TLS_DHE_PSK_WITH_NULL_SHA256 = 180,
		TLS_DHE_PSK_WITH_NULL_SHA384 = 181,
		TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182,
		TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183,
		TLS_RSA_PSK_WITH_NULL_SHA256 = 184,
		TLS_RSA_PSK_WITH_NULL_SHA384 = 185,
		TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186,
		TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187,
		TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188,
		TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189,
		TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190,
		TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191,
		TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192,
		TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193,
		TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194,
		TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195,
		TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196,
		TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197,
		TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255,
		TLS_FALLBACK_SCSV = 22016,
		TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153,
		TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154,
		TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155,
		TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156,
		TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157,
		TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158,
		TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159,
		TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160,
		TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161,
		TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162,
		TLS_ECDH_RSA_WITH_NULL_SHA = 49163,
		TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164,
		TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165,
		TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166,
		TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167,
		TLS_ECDHE_RSA_WITH_NULL_SHA = 49168,
		TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169,
		TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170,
		TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171,
		TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172,
		TLS_ECDH_anon_WITH_NULL_SHA = 49173,
		TLS_ECDH_anon_WITH_RC4_128_SHA = 49174,
		TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175,
		TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176,
		TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177,
		TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178,
		TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179,
		TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180,
		TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181,
		TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182,
		TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183,
		TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184,
		TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185,
		TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186,
		TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187,
		TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188,
		TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189,
		TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190,
		TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191,
		TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192,
		TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193,
		TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194,
		TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195,
		TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196,
		TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197,
		TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198,
		TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199,
		TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200,
		TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201,
		TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202,
		TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203,
		TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204,
		TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205,
		TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206,
		TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207,
		TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208,
		TLS_ECDHE_PSK_WITH_NULL_SHA = 49209,
		TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210,
		TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211,
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266,
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267,
		TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268,
		TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269,
		TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270,
		TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271,
		TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272,
		TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273,
		TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274,
		TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275,
		TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276,
		TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277,
		TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278,
		TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279,
		TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280,
		TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281,
		TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282,
		TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283,
		TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284,
		TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285,
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286,
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287,
		TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288,
		TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289,
		TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290,
		TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291,
		TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292,
		TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293,
		TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294,
		TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295,
		TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296,
		TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297,
		TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298,
		TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299,
		TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300,
		TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301,
		TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302,
		TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303,
		TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304,
		TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305,
		TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306,
		TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307,
		TLS_RSA_WITH_AES_128_CCM = 49308,
		TLS_RSA_WITH_AES_256_CCM = 49309,
		TLS_DHE_RSA_WITH_AES_128_CCM = 49310,
		TLS_DHE_RSA_WITH_AES_256_CCM = 49311,
		TLS_RSA_WITH_AES_128_CCM_8 = 49312,
		TLS_RSA_WITH_AES_256_CCM_8 = 49313,
		TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314,
		TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315,
		TLS_PSK_WITH_AES_128_CCM = 49316,
		TLS_PSK_WITH_AES_256_CCM = 49317,
		TLS_DHE_PSK_WITH_AES_128_CCM = 49318,
		TLS_DHE_PSK_WITH_AES_256_CCM = 49319,
		TLS_PSK_WITH_AES_128_CCM_8 = 49320,
		TLS_PSK_WITH_AES_256_CCM_8 = 49321,
		TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322,
		TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323,
		TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52243,
		TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52244,
		TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52245,
		TLS_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58384,
		TLS_RSA_WITH_SALSA20_SHA1 = 58385,
		TLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58386,
		TLS_ECDHE_RSA_WITH_SALSA20_SHA1 = 58387,
		TLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1 = 58388,
		TLS_ECDHE_ECDSA_WITH_SALSA20_SHA1 = 58389,
		TLS_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58390,
		TLS_PSK_WITH_SALSA20_SHA1 = 58391,
		TLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58392,
		TLS_ECDHE_PSK_WITH_SALSA20_SHA1 = 58393,
		TLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58394,
		TLS_RSA_PSK_WITH_SALSA20_SHA1 = 58395,
		TLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58396,
		TLS_DHE_PSK_WITH_SALSA20_SHA1 = 58397,
		TLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58398,
		TLS_DHE_RSA_WITH_SALSA20_SHA1 = 58399
	}

	public class MonoTlsConnectionInfo // TypeDefIndex: 57984
	{
		// Fields
		private CipherSuiteCode _CipherSuiteCode_k__BackingField; // 0x10
		private TlsProtocols _ProtocolVersion_k__BackingField; // 0x14
		private string _PeerDomainName_k__BackingField; // 0x18
	
		// Properties
		public CipherSuiteCode CipherSuiteCode { get; set; } // 0x0000000185FC2810-0x0000000185FC2820 0x0000000185FC1C30-0x0000000185FC1C40
		public TlsProtocols ProtocolVersion { get; set; } // 0x0000000185FB21A0-0x0000000185FB21B0 0x0000000185FBB0B0-0x0000000185FBB0C0
		public string PeerDomainName { get; set; } // 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public MonoTlsConnectionInfo() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override string ToString() => default; // 0x000000018B25879C-0x000000018B258834
	}

	public enum MonoSslPolicyErrors // TypeDefIndex: 57985
	{
		None = 0,
		RemoteCertificateNotAvailable = 1,
		RemoteCertificateNameMismatch = 2,
		RemoteCertificateChainErrors = 4
	}

	public delegate bool MonoRemoteCertificateValidationCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, MonoSslPolicyErrors sslPolicyErrors); // TypeDefIndex: 57986; 0x00000001817B21C0-0x00000001817B21E0

	public delegate System.Security.Cryptography.X509Certificates.X509Certificate MonoLocalCertificateSelectionCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers); // TypeDefIndex: 57987; 0x00000001817B21C0-0x00000001817B21E0

	public abstract class MonoTlsProvider // TypeDefIndex: 57988
	{
		// Properties
		public abstract Guid ID { get; }
		public abstract string Name { get; }
		public abstract bool SupportsSslStream { get; }
		public abstract bool SupportsConnectionInfo { get; }
		public abstract bool SupportsMonoExtensions { get; }
		public abstract SslProtocols SupportedProtocols { get; }
		internal abstract bool SupportsCleanShutdown { get; }
	
		// Constructors
		internal MonoTlsProvider() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class MonoTlsProviderFactory // TypeDefIndex: 57989
	{
		// Methods
		public static MonoTlsProvider GetProvider() => default; // 0x000000018B258834-0x000000018B258870
	}

	public sealed class MonoTlsSettings // TypeDefIndex: 57990
	{
		// Fields
		private MonoRemoteCertificateValidationCallback _RemoteCertificateValidationCallback_k__BackingField; // 0x10
		private MonoLocalCertificateSelectionCallback _ClientCertificateSelectionCallback_k__BackingField; // 0x18
		private System.DateTime? _CertificateValidationTime_k__BackingField; // 0x20
		private System.Security.Cryptography.X509Certificates.X509CertificateCollection _TrustAnchors_k__BackingField; // 0x30
		private object _UserSettings_k__BackingField; // 0x38
		private string[] _CertificateSearchPaths_k__BackingField; // 0x40
		private bool _SendCloseNotify_k__BackingField; // 0x48
		private string[] _ClientCertificateIssuers_k__BackingField; // 0x50
		private bool _DisallowUnauthenticatedCertificateRequest_k__BackingField; // 0x58
		private TlsProtocols? _EnabledProtocols_k__BackingField; // 0x5C
		private CipherSuiteCode[] _EnabledCiphers_k__BackingField; // 0x68
		private bool cloned; // 0x70
		private bool checkCertName; // 0x71
		private bool checkCertRevocationStatus; // 0x72
		private bool? useServicePointManagerCallback; // 0x73
		private bool skipSystemValidators; // 0x75
		private bool callbackNeedsChain; // 0x76
		private ICertificateValidator certificateValidator; // 0x78
		private static MonoTlsSettings defaultSettings; // 0x00
	
		// Properties
		public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public bool? UseServicePointManagerCallback { get => default; set {} } // 0x0000000185FCF3E0-0x0000000185FCF3F0 0x0000000185FCF400-0x0000000185FCF410
		public bool CallbackNeedsCertificateChain { get => default; } // 0x0000000185FB9F70-0x0000000185FB9F80 
		public System.DateTime? CertificateValidationTime { get; set; } // 0x0000000185FB6120-0x0000000185FB6130 0x0000000185FB6130-0x0000000185FB6140
		public System.Security.Cryptography.X509Certificates.X509CertificateCollection TrustAnchors { get; set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public object UserSettings { get; set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		internal string[] CertificateSearchPaths { get; set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		internal bool SendCloseNotify { get; set; } // 0x0000000185FB0750-0x0000000185FB0760 0x0000000185FB0770-0x0000000185FB0780
		public string[] ClientCertificateIssuers { get; set; } // 0x0000000181460F60-0x0000000181460F70 0x0000000184A4E570-0x0000000184A4E580
		public bool DisallowUnauthenticatedCertificateRequest { get; set; } // 0x0000000181BE64B0-0x0000000181BE64C0 0x0000000181BE64C0-0x0000000181BE64D0
		public TlsProtocols? EnabledProtocols { get; set; } // 0x0000000185FCF3D0-0x0000000185FCF3E0 0x0000000185FCF3F0-0x0000000185FCF400
		public CipherSuiteCode[] EnabledCiphers { get; set; } // 0x00000001813AC280-0x00000001813AC290 0x0000000185A62990-0x0000000185A629A0
		public static MonoTlsSettings DefaultSettings { get => default; } // 0x000000018B258B0C-0x000000018B258B88 
		public ICertificateValidator CertificateValidator { get => default; } // 0x0000000183060C50-0x0000000183060C60 
	
		// Constructors
		public MonoTlsSettings() {} // 0x0000000185FCF3C0-0x0000000185FCF3D0
		private MonoTlsSettings(MonoTlsSettings other) {} // 0x000000018B258988-0x000000018B258B0C
	
		// Methods
		public static MonoTlsSettings CopyDefaultSettings() => default; // 0x000000018B258964-0x000000018B258988
		public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) => default; // 0x000000018B258870-0x000000018B258904
		public MonoTlsSettings Clone() => default; // 0x000000018B258904-0x000000018B258964
	}

	public sealed class TlsException : Exception // TypeDefIndex: 57991
	{
		// Fields
		private Alert alert; // 0x90
	
		// Constructors
		public TlsException() {} // Dummy constructor
		public TlsException(Alert alert) {} // 0x000000018B25D448-0x000000018B25D4C0
		public TlsException(Alert alert, string message) {} // 0x000000018B25D2D8-0x000000018B25D348
		public TlsException(AlertDescription description) {} // 0x000000018B25D3D0-0x000000018B25D448
		public TlsException(AlertDescription description, string message) {} // 0x000000018B25D348-0x000000018B25D3D0
	}

	public enum TlsProtocolCode : short // TypeDefIndex: 57992
	{
		Tls10 = 769,
		Tls11 = 770,
		Tls12 = 771
	}

	public enum TlsProtocols // TypeDefIndex: 57993
	{
		Zero = 0,
		Tls10Server = 64,
		Tls10Client = 128,
		Tls10 = 192,
		Tls11Server = 256,
		Tls11Client = 512,
		Tls11 = 768,
		Tls12Server = 1024,
		ServerMask = 1344,
		Tls12Client = 2048,
		ClientMask = 2688,
		Tls12 = 3072
	}
}

namespace Mono.Security.Protocol.Ntlm
{
	public class ChallengeResponse : IDisposable // TypeDefIndex: 57969
	{
		// Fields
		private static byte[] magic; // 0x00
		private static byte[] nullEncMagic; // 0x08
		private bool _disposed; // 0x10
		private byte[] _challenge; // 0x18
		private byte[] _lmpwd; // 0x20
		private byte[] _ntpwd; // 0x28
	
		// Properties
		public string Password { set {} } // 0x000000018B23EB38-0x000000018B23EE60
		public byte[] Challenge { set {} } // 0x000000018B23EA18-0x000000018B23EB38
		public byte[] LM { get => default; } // 0x000000018B23E930-0x000000018B23E9A4 
		public byte[] NT { get => default; } // 0x000000018B23E9A4-0x000000018B23EA18 
	
		// Constructors
		public ChallengeResponse() {} // 0x000000018B23E8C4-0x000000018B23E930
		public ChallengeResponse(string password, byte[] challenge) {} // 0x000000018B23E878-0x000000018B23E8C4
		static ChallengeResponse() {} // 0x000000018B23E794-0x000000018B23E878
	
		// Methods
		~ChallengeResponse() {} // 0x000000018B23E26C-0x000000018B23E2E4
		public void Dispose() {} // 0x000000018B23E1A8-0x000000018B23E1F8
		private void Dispose(bool disposing) {} // 0x000000018B23E1F8-0x000000018B23E26C
		private byte[] GetResponse(byte[] pwd) => default; // 0x000000018B23E2E4-0x000000018B23E490
		private byte[] PrepareDESKey(byte[] key56bits, int position) => default; // 0x000000018B23E5B4-0x000000018B23E794
		private byte[] PasswordToKey(string password, int position) => default; // 0x000000018B23E490-0x000000018B23E5B4
	}

	public static class ChallengeResponse2 // TypeDefIndex: 57970
	{
		// Fields
		private static byte[] magic; // 0x00
		private static byte[] nullEncMagic; // 0x08
	
		// Constructors
		static ChallengeResponse2() {} // 0x000000018B23E0C4-0x000000018B23E1A8
	
		// Methods
		private static byte[] Compute_LM(string password, byte[] challenge) => default; // 0x000000018B23D098-0x000000018B23D2D4
		private static byte[] Compute_NTLM_Password(string password) => default; // 0x000000018B23D2D4-0x000000018B23D3D4
		private static byte[] Compute_NTLM(string password, byte[] challenge) => default; // 0x000000018B23D3D4-0x000000018B23D430
		private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) {
			lm = default;
			ntlm = default;
		} // 0x000000018B23D430-0x000000018B23D604
		private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) => default; // 0x000000018B23D604-0x000000018B23DA2C
		public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) {
			lm = default;
			ntlm = default;
		} // 0x000000018B23DA2C-0x000000018B23DBF4
		private static byte[] GetResponse(byte[] challenge, byte[] pwd) => default; // 0x000000018B23DBF4-0x000000018B23DDAC
		private static byte[] PrepareDESKey(byte[] key56bits, int position) => default; // 0x000000018B23DEE4-0x000000018B23E0C4
		private static byte[] PasswordToKey(string password, int position) => default; // 0x000000018B23DDAC-0x000000018B23DEE4
	}

	public abstract class MessageBase // TypeDefIndex: 57971
	{
		// Fields
		private static byte[] header; // 0x00
		private int _type; // 0x10
		private NtlmFlags _flags; // 0x14
	
		// Properties
		public NtlmFlags Flags { get; set; } // 0x0000000185FB21A0-0x0000000185FB21B0 0x0000000185FBB0B0-0x0000000185FBB0C0
		public int Type { get; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
	
		// Constructors
		protected MessageBase() {} // Dummy constructor
		protected MessageBase(int messageType) {} // 0x0000000181378230-0x0000000181378240
		static MessageBase() {} // 0x000000018B257DFC-0x000000018B257E88
	
		// Methods
		protected byte[] PrepareMessage(int messageSize) => default; // 0x000000018B257D20-0x000000018B257DFC
		protected virtual void Decode(byte[] message) {} // 0x000000018B257B64-0x000000018B257D20
		protected bool CheckHeader(byte[] message) => default; // 0x000000018B257A80-0x000000018B257B64
		public abstract byte[] GetBytes();
	}

	public enum NtlmAuthLevel // TypeDefIndex: 57972
	{
		LM_and_NTLM = 0,
		LM_and_NTLM_and_try_NTLMv2_Session = 1,
		NTLM_only = 2,
		NTLMv2_only = 3
	}

	public enum NtlmFlags // TypeDefIndex: 57973
	{
		NegotiateUnicode = 1,
		NegotiateOem = 2,
		RequestTarget = 4,
		NegotiateNtlm = 512,
		NegotiateDomainSupplied = 4096,
		NegotiateWorkstationSupplied = 8192,
		NegotiateAlwaysSign = 32768,
		NegotiateNtlm2Key = 524288,
		Negotiate128 = 536870912,
		Negotiate56 = 2147483647
	}

	public static class NtlmSettings // TypeDefIndex: 57974
	{
		// Fields
		private static NtlmAuthLevel defaultAuthLevel; // 0x00
	
		// Properties
		public static NtlmAuthLevel DefaultAuthLevel { get; } // 0x000000018B258BC4-0x000000018B258C14 
	
		// Constructors
		static NtlmSettings() {} // 0x000000018B258B88-0x000000018B258BC4
	}

	public class Type1Message : MessageBase // TypeDefIndex: 57975
	{
		// Fields
		private string _host; // 0x18
		private string _domain; // 0x20
	
		// Properties
		public string Domain { set {} } // 0x000000018B25D8B8-0x000000018B25D92C
		public string Host { set {} } // 0x000000018B25D92C-0x000000018B25D9A0
	
		// Constructors
		public Type1Message() {} // 0x000000018B25D84C-0x000000018B25D8B8
	
		// Methods
		protected override void Decode(byte[] message) {} // 0x000000018B25D4C0-0x000000018B25D5A0
		public override byte[] GetBytes() => default; // 0x000000018B25D5A0-0x000000018B25D84C
	}

	public class Type2Message : MessageBase // TypeDefIndex: 57976
	{
		// Fields
		private byte[] _nonce; // 0x18
		private string _targetName; // 0x20
		private byte[] _targetInfo; // 0x28
	
		// Properties
		public byte[] Nonce { get => default; } // 0x000000018B25DCD8-0x000000018B25DD28 
		public string TargetName { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public byte[] TargetInfo { get => default; } // 0x000000018B25DD28-0x000000018B25DD78 
	
		// Constructors
		public Type2Message() {} // Dummy constructor
		public Type2Message(byte[] message) {} // 0x000000018B25DC54-0x000000018B25DCD8
	
		// Methods
		~Type2Message() {} // 0x000000018B25DB0C-0x000000018B25DB94
		protected override void Decode(byte[] message) {} // 0x000000018B25D9A0-0x000000018B25DB0C
		public override byte[] GetBytes() => default; // 0x000000018B25DB94-0x000000018B25DC54
	}

	public class Type3Message : MessageBase // TypeDefIndex: 57977
	{
		// Fields
		private NtlmAuthLevel _level; // 0x18
		private byte[] _challenge; // 0x20
		private string _host; // 0x28
		private string _domain; // 0x30
		private string _username; // 0x38
		private string _password; // 0x40
		private Type2Message _type2; // 0x48
		private byte[] _lm; // 0x50
		private byte[] _nt; // 0x58
	
		// Properties
		public string Domain { set {} } // 0x000000018B25E95C-0x000000018B25EB64
		public string Password { set {} } // 0x0000000185F05C80-0x0000000185F05C90
		public string Username { set {} } // 0x0000000185A16440-0x0000000185A16450
	
		// Constructors
		public Type3Message() {} // Dummy constructor
		public Type3Message(Type2Message type2) {} // 0x000000018B25E7C0-0x000000018B25E95C
	
		// Methods
		~Type3Message() {} // 0x000000018B25E068-0x000000018B25E134
		protected override void Decode(byte[] message) {} // 0x000000018B25DDD4-0x000000018B25DFEC
		private string DecodeString(byte[] buffer, int offset, int len) => default; // 0x000000018B25DD78-0x000000018B25DDD4
		private byte[] EncodeString(string text) => default; // 0x000000018B25DFEC-0x000000018B25E068
		public override byte[] GetBytes() => default; // 0x000000018B25E134-0x000000018B25E7C0
	}
}

namespace Mono.Security.X509
{
	internal class SafeBag // TypeDefIndex: 57933
	{
		// Fields
		private string _bagOID; // 0x10
		private ASN1 _asn1; // 0x18
	
		// Properties
		public string BagOID { get => default; } // 0x000000018346D130-0x000000018346D140 
		public ASN1 ASN1 { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Constructors
		public SafeBag() {} // Dummy constructor
		public SafeBag(string bagOID, ASN1 asn1) {} // 0x00000001841BC230-0x00000001841BC260
	}

	public class PKCS12 : ICloneable // TypeDefIndex: 57935
	{
		// Fields
		private byte[] _password; // 0x10
		private ArrayList _keyBags; // 0x18
		private ArrayList _secretBags; // 0x20
		private Mono.Security.X509.X509CertificateCollection _certs; // 0x28
		private bool _keyBagsChanged; // 0x30
		private bool _secretBagsChanged; // 0x31
		private bool _certsChanged; // 0x32
		private int _iterations; // 0x34
		private ArrayList _safeBags; // 0x38
		private RandomNumberGenerator _rng; // 0x40
		private static int password_max_length; // 0x00
	
		// Properties
		public string Password { set {} } // 0x000000018B2445D0-0x000000018B2447FC
		public int IterationCount { get => default; set {} } // 0x000000018B24073C-0x000000018B240A78 0x000000018B245B48-0x000000018B2463AC
		public ArrayList Keys { get => default; } // 0x000000018B244E64-0x000000018B245B48 
		public Mono.Security.X509.X509CertificateCollection Certificates { get => default; } // 0x000000018B240A78-0x000000018B241498 
		internal RandomNumberGenerator RNG { get => default; } // 0x000000018B244D50-0x000000018B244E64 
		public static int MaximumPasswordLength { get => default; } // 0x000000018B23F404-0x000000018B23F468 
	
		// Nested types
		public class DeriveBytes // TypeDefIndex: 57934
		{
			// Fields
			private static byte[] keyDiversifier; // 0x00
			private static byte[] ivDiversifier; // 0x08
			private static byte[] macDiversifier; // 0x10
			private string _hashName; // 0x10
			private int _iterations; // 0x18
			private byte[] _password; // 0x20
			private byte[] _salt; // 0x28
	
			// Properties
			public string HashName { set {} } // 0x000000018B24681C-0x000000018B246858
			public int IterationCount { set {} } // 0x000000018B2467D0-0x000000018B24681C
			public byte[] Password { set {} } // 0x000000018B24165C-0x000000018B241F4C
			public byte[] Salt { set {} } // 0x000000018B242544-0x000000018B242618
	
			// Constructors
			public DeriveBytes() {} // 0x000000018B246858-0x000000018B246964
			static DeriveBytes() {} // 0x000000018B247338-0x000000018B24736C
	
			// Methods
			private void Adjust(byte[] a, int aOff, byte[] b) {} // 0x000000018B24736C-0x000000018B2474C8
			private byte[] Derive(byte[] diversifier, int n) => default; // 0x0000000185FB07C0-0x0000000185FB07D0
			public byte[] DeriveKey(int size) => default; // 0x0000000185FB07E0-0x0000000185FB07F0
			public byte[] DeriveIV(int size) => default; // 0x000000018B246D34-0x000000018B2472E8
			public byte[] DeriveMAC(int size) => default; // 0x000000018B246964-0x000000018B246D34
		}
	
		// Constructors
		public PKCS12() {} // 0x000000018B2415FC-0x000000018B24165C
		public PKCS12(byte[] data) {} // 0x000000018B2447FC-0x000000018B244D50
		public PKCS12(byte[] data, string password) {} // 0x000000018B242020-0x000000018B242104
		static PKCS12() {} // 0x000000018B23F868-0x000000018B23F9AC
	
		// Methods
		private void Decode(byte[] data) {} // 0x000000018B241F4C-0x000000018B242020
		~PKCS12() {} // 0x000000018B242104-0x000000018B242224
		private bool Compare(byte[] expected, byte[] actual) => default; // 0x000000018B242618-0x000000018B2445D0
		private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) => default; // 0x000000018B242224-0x000000018B242544
		public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) => default; // 0x000000018B240170-0x000000018B24017C
		public byte[] Decrypt(PKCS7.EncryptedData ed) => default; // 0x000000018B24017C-0x000000018B2403B4
		public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) => default; // 0x000000018B246788-0x000000018B246794
		private DSAParameters GetExistingParameters(out bool found) {
			found = default;
			return default;
		} // 0x000000018B2463AC-0x000000018B246788
		private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) {} // 0x000000018B241574-0x000000018B2415FC
		private void ReadSafeBag(ASN1 safeBag) {} // 0x000000018B2403B4-0x000000018B24073C
		private ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes) => default; // 0x000000018B241498-0x000000018B241574
		private ASN1 CertificateSafeBag(Mono.Security.X509.X509Certificate x509, IDictionary attributes) => default; // 0x000000018B2472E8-0x000000018B247338
		private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) => default; // 0x000000018B246794-0x000000018B2467D0
		public byte[] GetBytes() => default; // 0x0000000185492010-0x0000000185492020
		private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) => default; // 0x0000000184096E30-0x0000000184096EF0
		public void AddCertificate(Mono.Security.X509.X509Certificate cert) {} // 0x00000001813AE9C0-0x00000001813AE9D0
		public void AddCertificate(Mono.Security.X509.X509Certificate cert, IDictionary attributes) {} // 0x000000018B23F9AC-0x000000018B23FA38
		public void RemoveCertificate(Mono.Security.X509.X509Certificate cert) {} // 0x000000018B23FA38-0x000000018B23FAB4
		public void RemoveCertificate(Mono.Security.X509.X509Certificate cert, IDictionary attrs) {} // 0x000000018B23F27C-0x000000018B23F340
		private bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2) => default; // 0x000000018B23F468-0x000000018B23F868
		public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes) {} // 0x000000018B23F3A4-0x000000018B23F404
		public object Clone() => default; // 0x000000018B23F340-0x000000018B23F3A4
	}

	public sealed class X501 // TypeDefIndex: 57936
	{
		// Fields
		private static byte[] countryName; // 0x00
		private static byte[] organizationName; // 0x08
		private static byte[] organizationalUnitName; // 0x10
		private static byte[] commonName; // 0x18
		private static byte[] localityName; // 0x20
		private static byte[] stateOrProvinceName; // 0x28
		private static byte[] streetAddress; // 0x30
		private static byte[] serialNumber; // 0x38
		private static byte[] domainComponent; // 0x40
		private static byte[] userid; // 0x48
		private static byte[] email; // 0x50
		private static byte[] dnQualifier; // 0x58
		private static byte[] title; // 0x60
		private static byte[] surname; // 0x68
		private static byte[] givenName; // 0x70
		private static byte[] initial; // 0x78
	
		// Constructors
		public X501() {} // Dummy constructor
		static X501() {} // 0x000000018B24A09C-0x000000018B24A660
	
		// Methods
		public static string ToString(ASN1 seq) => default; // 0x000000018B249F9C-0x000000018B24A09C
		public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes) => default; // 0x000000018B249E30-0x000000018B249F9C
		private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) {} // 0x000000018B248310-0x000000018B248BA8
		private static X520.AttributeTypeAndValue GetAttributeFromOid(string attributeType) => default; // 0x000000018B248D28-0x000000018B2494F8
		private static bool IsOid(string oid) => default; // 0x000000018B249598-0x000000018B249624
		private static X520.AttributeTypeAndValue ReadAttribute(string value, ref int pos) => default; // 0x000000018B249624-0x000000018B249798
		private static bool IsHex(char c) => default; // 0x000000018B2494F8-0x000000018B249598
		private static string ReadHex(string value, ref int pos) => default; // 0x000000018B249920-0x000000018B249AA4
		private static int ReadEscaped(StringBuilder sb, string value, int pos) => default; // 0x000000018B249798-0x000000018B249920
		private static int ReadQuoted(StringBuilder sb, string value, int pos) => default; // 0x000000018B249AA4-0x000000018B249BDC
		private static string ReadValue(string value, ref int pos) => default; // 0x000000018B249BDC-0x000000018B249E30
		public static ASN1 FromString(string rdn) => default; // 0x000000018B248BA8-0x000000018B248D28
	}

	public class X509Crl // TypeDefIndex: 57938
	{
		// Fields
		private string issuer; // 0x10
		private byte version; // 0x18
		private System.DateTime thisUpdate; // 0x20
		private System.DateTime nextUpdate; // 0x28
		private ArrayList entries; // 0x30
		private string signatureOID; // 0x38
		private byte[] signature; // 0x40
		private Mono.Security.X509.X509ExtensionCollection extensions; // 0x48
		private byte[] encoded; // 0x50
		private byte[] hash_value; // 0x58
	
		// Properties
		public Mono.Security.X509.X509ExtensionCollection Extensions { get => default; } // 0x000000018B24A7A8-0x000000018B24A800 
		public byte[] Hash { get => default; } // 0x000000018B24D540-0x000000018B24D5C4 
		public string IssuerName { get => default; } // 0x000000018B24D5C4-0x000000018B24D6E0 
		public System.DateTime NextUpdate { get => default; } // 0x000000018B24DF5C-0x000000018B24E200 
	
		// Nested types
		public class X509CrlEntry // TypeDefIndex: 57937
		{
			// Fields
			private byte[] sn; // 0x10
			private System.DateTime revocationDate; // 0x18
			private Mono.Security.X509.X509ExtensionCollection extensions; // 0x20
	
			// Properties
			public byte[] SerialNumber { get => default; } // 0x000000018B24D6E0-0x000000018B24DD24 
			public System.DateTime RevocationDate { get => default; } // 0x00000001813ECF20-0x00000001813ECF30 
			public Mono.Security.X509.X509ExtensionCollection Extensions { get => default; } // 0x000000018B24E2D4-0x000000018B24E47C 
	
			// Constructors
			public X509CrlEntry() {} // Dummy constructor
			internal X509CrlEntry(ASN1 entry) {} // 0x000000018B24E200-0x000000018B24E2D4
		}
	
		// Constructors
		public X509Crl() {} // Dummy constructor
		public X509Crl(byte[] crl) {} // 0x000000018346D130-0x000000018346D140
	
		// Methods
		private void Parse(byte[] crl) {} // 0x00000001813B8590-0x00000001813B85A0
		private bool Compare(byte[] array1, byte[] array2) => default; // 0x000000018B24DE9C-0x000000018B24DF5C
		public X509CrlEntry GetCrlEntry(Mono.Security.X509.X509Certificate x509) => default; // 0x000000018B24DD24-0x000000018B24DE9C
		public X509CrlEntry GetCrlEntry(byte[] serialNumber) => default; // 0x000000018B24D3F8-0x000000018B24D4F0
		internal bool VerifySignature(DSA dsa) => default; // 0x000000018B24D4F0-0x000000018B24D540
		internal bool VerifySignature(RSA rsa) => default; // 0x0000000181377E40-0x0000000181377E50
		public bool VerifySignature(AsymmetricAlgorithm aa) => default; // 0x00000001813B31A0-0x00000001813B31B0
	}

	public class X509Certificate : ISerializable // TypeDefIndex: 57939
	{
		// Fields
		private ASN1 decoder; // 0x10
		private byte[] m_encodedcert; // 0x18
		private System.DateTime m_from; // 0x20
		private System.DateTime m_until; // 0x28
		private ASN1 issuer; // 0x30
		private string m_issuername; // 0x38
		private string m_keyalgo; // 0x40
		private byte[] m_keyalgoparams; // 0x48
		private ASN1 subject; // 0x50
		private string m_subject; // 0x58
		private byte[] m_publickey; // 0x60
		private byte[] signature; // 0x68
		private string m_signaturealgo; // 0x70
		private byte[] m_signaturealgoparams; // 0x78
		private byte[] certhash; // 0x80
		private RSA _rsa; // 0x88
		private DSA _dsa; // 0x90
		private int version; // 0x98
		private byte[] serialnumber; // 0xA0
		private byte[] issuerUniqueID; // 0xA8
		private byte[] subjectUniqueID; // 0xB0
		private Mono.Security.X509.X509ExtensionCollection extensions; // 0xB8
		private static string encoding_error; // 0x00
	
		// Properties
		public DSA DSA { get => default; set {} } // 0x000000018B24BC7C-0x000000018B24BFC0 0x000000018B24C9E0-0x000000018B24CA24
		public Mono.Security.X509.X509ExtensionCollection Extensions { get => default; } // 0x000000018349D710-0x000000018349D720 
		public byte[] Hash { get => default; } // 0x000000018B24BFC0-0x000000018B24C1DC 
		public virtual string IssuerName { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public virtual string KeyAlgorithm { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		public virtual byte[] KeyAlgorithmParameters { get => default; set {} } // 0x000000018B24C314-0x000000018B24C368 0x000000018571FEC0-0x000000018571FED0
		public virtual byte[] PublicKey { get => default; } // 0x000000018B24C368-0x000000018B24C3BC 
		public virtual RSA RSA { get => default; set {} } // 0x000000018B24C3BC-0x000000018B24C59C 0x000000018B24CA24-0x000000018B24CA64
		public virtual byte[] RawData { get => default; } // 0x000000018B24C59C-0x000000018B24C5F0 
		public virtual byte[] SerialNumber { get => default; } // 0x000000018B24C5F0-0x000000018B24C648 
		public virtual byte[] Signature { get => default; } // 0x000000018B24C648-0x000000018B24C9E0 
		public virtual string SubjectName { get => default; } // 0x00000001813F1630-0x00000001813F1640 
		public virtual System.DateTime ValidFrom { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public virtual System.DateTime ValidUntil { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
		public int Version { get => default; } // 0x00000001834A0D40-0x00000001834A0D50 
		public bool IsCurrent { get => default; } // 0x000000018B24C1DC-0x000000018B24C228 
		public bool IsSelfSigned { get => default; } // 0x000000018B24C228-0x000000018B24C314 
	
		// Constructors
		public X509Certificate() {} // Dummy constructor
		public X509Certificate(byte[] data) {} // 0x000000018B24BB00-0x000000018B24BC7C
		static X509Certificate() {} // 0x000000018B24BAA4-0x000000018B24BB00
	
		// Methods
		private void Parse(byte[] data) {} // 0x000000018B24AE08-0x000000018B24B6FC
		private byte[] GetUnsignedBigInteger(byte[] integer) => default; // 0x000000018B24AC68-0x000000018B24AD00
		public bool WasCurrent(System.DateTime instant) => default; // 0x000000018B24BA20-0x000000018B24BAA4
		internal bool VerifySignature(DSA dsa) => default; // 0x000000018B24B96C-0x000000018B24BA20
		internal bool VerifySignature(RSA rsa) => default; // 0x000000018B24B874-0x000000018B24B96C
		public bool VerifySignature(AsymmetricAlgorithm aa) => default; // 0x000000018B24B6FC-0x000000018B24B874
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x000000018B24AC10-0x000000018B24AC68
		private static byte[] PEM(string type, byte[] data) => default; // 0x000000018B24AD00-0x000000018B24AE08
	}

	[Serializable]
	public class X509CertificateCollection : CollectionBase, IEnumerable // TypeDefIndex: 57941
	{
		// Properties
		public Mono.Security.X509.X509Certificate this[int index] { get => default; } // 0x00000001891011C8-0x00000001891011EC 
	
		// Nested types
		public class X509CertificateEnumerator : IEnumerator // TypeDefIndex: 57940
		{
			// Fields
			private IEnumerator enumerator; // 0x10
	
			// Properties
			public Mono.Security.X509.X509Certificate Current { get => default; } // 0x000000018B24A9C0-0x000000018B24AA20 
			object IEnumerator.Current { get => default; } // 0x000000018B24A72C-0x000000018B24A7A8 
	
			// Constructors
			public X509CertificateEnumerator() {} // Dummy constructor
			public X509CertificateEnumerator(X509CertificateCollection mappings) {} // 0x000000018B24A9B8-0x000000018B24A9C0
	
			// Methods
			bool IEnumerator.MoveNext() => default; // 0x000000018B24A660-0x000000018B24A72C
			void IEnumerator.Reset() {} // 0x000000018B24A800-0x000000018B24A818
			public bool MoveNext() => default; // 0x000000018B24A818-0x000000018B24A878
		}
	
		// Constructors
		public X509CertificateCollection() {} // 0x000000018B24A994-0x000000018B24A9B8
	
		// Methods
		public int Add(Mono.Security.X509.X509Certificate value) => default; // 0x000000018B24A878-0x000000018B24A994
		public void AddRange(X509CertificateCollection value) {} // 0x000000018B24A7A8-0x000000018B24A800
		public bool Contains(Mono.Security.X509.X509Certificate value) => default; // 0x000000018B24AB48-0x000000018B24ABA8
		public new X509CertificateEnumerator GetEnumerator() => default; // 0x000000018B24ABA8-0x000000018B24AC10
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018B24AAFC-0x000000018B24AB48
		public override int GetHashCode() => default; // 0x000000018B24AA68-0x000000018B24AAB0
		public int IndexOf(Mono.Security.X509.X509Certificate value) => default; // 0x000000018B24AAB0-0x000000018B24AAFC
		private bool Compare(byte[] array1, byte[] array2) => default; // 0x000000018B24AA20-0x000000018B24AA68
	}

	public class X509Chain // TypeDefIndex: 57942
	{
		// Fields
		private Mono.Security.X509.X509CertificateCollection roots; // 0x10
		private Mono.Security.X509.X509CertificateCollection certs; // 0x18
		private Mono.Security.X509.X509Certificate _root; // 0x20
		private Mono.Security.X509.X509CertificateCollection _chain; // 0x28
		private Mono.Security.X509.X509ChainStatusFlags _status; // 0x30
	
		// Properties
		public Mono.Security.X509.X509CertificateCollection TrustAnchors { get => default; } // 0x000000018B24D368-0x000000018B24D3F8 
	
		// Constructors
		public X509Chain() {} // 0x000000018B24D304-0x000000018B24D368
	
		// Methods
		public void LoadCertificates(Mono.Security.X509.X509CertificateCollection collection) {} // 0x000000018B24D298-0x000000018B24D2B8
		public bool Build(Mono.Security.X509.X509Certificate leaf) => default; // 0x000000018B24CA64-0x000000018B24CDCC
		public void Reset() {} // 0x000000018B24D2B8-0x000000018B24D304
		private bool IsValid(Mono.Security.X509.X509Certificate cert) => default; // 0x000000018B24D228-0x000000018B24D298
		private Mono.Security.X509.X509Certificate FindCertificateParent(Mono.Security.X509.X509Certificate child) => default; // 0x000000018B24CDCC-0x000000018B24CF14
		private Mono.Security.X509.X509Certificate FindCertificateRoot(Mono.Security.X509.X509Certificate potentialRoot) => default; // 0x000000018B24CF14-0x000000018B24D0C8
		private bool IsTrusted(Mono.Security.X509.X509Certificate potentialTrusted) => default; // 0x000000018B24D1F8-0x000000018B24D228
		private bool IsParent(Mono.Security.X509.X509Certificate child, Mono.Security.X509.X509Certificate parent) => default; // 0x000000018B24D0C8-0x000000018B24D1F8
	}

	[Serializable]
	public enum X509ChainStatusFlags // TypeDefIndex: 57943
	{
		NoError = 0,
		NotTimeValid = 1,
		NotTimeNested = 2,
		NotSignatureValid = 8,
		UntrustedRoot = 32,
		InvalidBasicConstraints = 1024,
		PartialChain = 65536
	}

	public class X509Extension // TypeDefIndex: 57944
	{
		// Fields
		protected string extnOid; // 0x10
		protected bool extnCritical; // 0x18
		protected ASN1 extnValue; // 0x20
	
		// Properties
		public string Oid { get => default; } // 0x000000018346D130-0x000000018346D140 
		public bool Critical { get => default; } // 0x00000001813C0430-0x00000001813C0440 
		public ASN1 Value { get => default; } // 0x000000018B24EF90-0x000000018B24EFC0 
	
		// Constructors
		public X509Extension() {} // Dummy constructor
		public X509Extension(ASN1 asn1) {} // 0x000000018B24EB34-0x000000018B24EE3C
		public X509Extension(X509Extension extension) {} // 0x000000018B24EE3C-0x000000018B24EF90
	
		// Methods
		protected virtual void Decode() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void Encode() {} // 0x0000000185492010-0x0000000185492020
		public override bool Equals(object obj) => default; // 0x000000018B24E744-0x000000018B24E850
		public override int GetHashCode() => default; // 0x00000001891011C8-0x00000001891011EC
		private void WriteLine(StringBuilder sb, int n, int pos) {} // 0x000000018B24E950-0x000000018B24EB34
		public override string ToString() => default; // 0x000000018B24E850-0x000000018B24E950
	}

	public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 57945
	{
		// Fields
		private bool readOnly; // 0x18
	
		// Properties
		public Mono.Security.X509.X509Extension this[string oid] { get => default; } // 0x000000018B24E6C8-0x000000018B24E744 
	
		// Constructors
		public X509ExtensionCollection() {} // 0x000000018B24A9B8-0x000000018B24A9C0
		public X509ExtensionCollection(ASN1 asn1) {} // 0x000000018B24E5A0-0x000000018B24E6C8
	
		// Methods
		public int IndexOf(string oid) => default; // 0x000000018B24E47C-0x000000018B24E5A0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018B24A994-0x000000018B24A9B8
	}

	public class X509Store // TypeDefIndex: 57946
	{
		// Fields
		private string _storePath; // 0x10
		private Mono.Security.X509.X509CertificateCollection _certificates; // 0x18
		private ArrayList _crls; // 0x20
		private bool _crl; // 0x28
		private bool _newFormat; // 0x29
	
		// Properties
		public Mono.Security.X509.X509CertificateCollection Certificates { get => default; } // 0x000000018B24FCB0-0x000000018B24FCEC 
		public ArrayList Crls { get => default; } // 0x000000018B24FCEC-0x000000018B24FD80 
	
		// Constructors
		public X509Store() {} // Dummy constructor
		internal X509Store(string path, bool crl, bool newFormat) {} // 0x000000018B24FC88-0x000000018B24FCB0
	
		// Methods
		private byte[] Load(string filename) => default; // 0x000000018B24FB4C-0x000000018B24FC88
		private Mono.Security.X509.X509Certificate LoadCertificate(string filename) => default; // 0x000000018B24FA64-0x000000018B24FAD8
		private X509Crl LoadCrl(string filename) => default; // 0x000000018B24FAD8-0x000000018B24FB4C
		private bool CheckStore(string path, bool throwException) => default; // 0x000000018B24F9AC-0x000000018B24FA64
		private Mono.Security.X509.X509CertificateCollection BuildCertificatesCollection(string storeName) => default; // 0x000000018B24F650-0x000000018B24F808
		private ArrayList BuildCrlsCollection(string storeName) => default; // 0x000000018B24F808-0x000000018B24F9AC
	}

	public sealed class X509StoreManager // TypeDefIndex: 57947
	{
		// Fields
		private static string _userPath; // 0x00
		private static string _localMachinePath; // 0x08
		private static string _newUserPath; // 0x10
		private static string _newLocalMachinePath; // 0x18
		private static X509Stores _userStore; // 0x20
		private static X509Stores _machineStore; // 0x28
	
		// Properties
		internal static string CurrentUserPath { get => default; } // 0x000000018B24EFC0-0x000000018B24F0C8 
		internal static string LocalMachinePath { get => default; } // 0x000000018B24F18C-0x000000018B24F2A4 
		internal static string NewCurrentUserPath { get => default; } // 0x000000018B24F368-0x000000018B24F480 
		internal static string NewLocalMachinePath { get => default; } // 0x000000018B24F480-0x000000018B24F598 
		public static X509Stores CurrentUser { get => default; } // 0x000000018B24F0C8-0x000000018B24F18C 
		public static X509Stores LocalMachine { get => default; } // 0x000000018B24F2A4-0x000000018B24F368 
		public static Mono.Security.X509.X509CertificateCollection TrustedRootCertificates { get => default; } // 0x000000018B24F598-0x000000018B24F650 
	
		// Constructors
		public X509StoreManager() {} // Dummy constructor
	}

	public class X509Stores // TypeDefIndex: 57948
	{
		// Fields
		private string _storePath; // 0x10
		private bool _newFormat; // 0x18
		private Mono.Security.X509.X509Store _trusted; // 0x20
	
		// Properties
		public Mono.Security.X509.X509Store TrustedRoot { get => default; } // 0x000000018B24FE90-0x000000018B24FF64 
	
		// Constructors
		public X509Stores() {} // Dummy constructor
		internal X509Stores(string path, bool newFormat) {} // 0x00000001843A39A0-0x00000001843A39D0
	
		// Methods
		public Mono.Security.X509.X509Store Open(string storeName, bool create) => default; // 0x000000018B24FD80-0x000000018B24FE90
	}

	public class X520 // TypeDefIndex: 57966
	{
		// Nested types
		public abstract class AttributeTypeAndValue // TypeDefIndex: 57949
		{
			// Fields
			private string oid; // 0x10
			private string attrValue; // 0x18
			private int upperBound; // 0x20
			private byte encoding; // 0x24
	
			// Properties
			public string Value { get; set; } // 0x000000018B23C370-0x000000018B23C438
	
			// Constructors
			protected AttributeTypeAndValue() {} // Dummy constructor
			protected AttributeTypeAndValue(string oid, int upperBound) {} // 0x000000018B23C324-0x000000018B23C34C
			protected AttributeTypeAndValue(string oid, int upperBound, byte encoding) {} // 0x000000018B23C34C-0x000000018B23C370
	
			// Methods
			internal ASN1 GetASN1(byte encoding) => default; // 0x000000018B23C14C-0x000000018B23C2D0
			internal ASN1 GetASN1() => default; // 0x000000018B23C140-0x000000018B23C14C
			private byte SelectBestEncoding() => default; // 0x000000018B23C2D0-0x000000018B23C324
		}
	
		public class CommonName : AttributeTypeAndValue // TypeDefIndex: 57950
		{
			// Constructors
			public CommonName() {} // 0x000000018B23EE60-0x000000018B23EEA4
		}
	
		public class SerialNumber : AttributeTypeAndValue // TypeDefIndex: 57951
		{
			// Constructors
			public SerialNumber() {} // 0x000000018B2474C8-0x000000018B247514
		}
	
		public class LocalityName : AttributeTypeAndValue // TypeDefIndex: 57952
		{
			// Constructors
			public LocalityName() {} // 0x000000018B240094-0x000000018B2400D8
		}
	
		public class StateOrProvinceName : AttributeTypeAndValue // TypeDefIndex: 57953
		{
			// Constructors
			public StateOrProvinceName() {} // 0x000000018B248200-0x000000018B248244
		}
	
		public class OrganizationName : AttributeTypeAndValue // TypeDefIndex: 57954
		{
			// Constructors
			public OrganizationName() {} // 0x000000018B2400E8-0x000000018B24012C
		}
	
		public class OrganizationalUnitName : AttributeTypeAndValue // TypeDefIndex: 57955
		{
			// Constructors
			public OrganizationalUnitName() {} // 0x000000018B24012C-0x000000018B240170
		}
	
		public class EmailAddress : AttributeTypeAndValue // TypeDefIndex: 57956
		{
			// Constructors
			public EmailAddress() {} // 0x000000018B23FB4C-0x000000018B23FB98
		}
	
		public class DomainComponent : AttributeTypeAndValue // TypeDefIndex: 57957
		{
			// Constructors
			public DomainComponent() {} // 0x000000018B23FB00-0x000000018B23FB4C
		}
	
		public class UserId : AttributeTypeAndValue // TypeDefIndex: 57958
		{
			// Constructors
			public UserId() {} // 0x000000018B2482CC-0x000000018B248310
		}
	
		public class Oid : AttributeTypeAndValue // TypeDefIndex: 57959
		{
			// Constructors
			public Oid() {} // Dummy constructor
			public Oid(string oid) {} // 0x000000018B2400D8-0x000000018B2400E8
		}
	
		public class Title : AttributeTypeAndValue // TypeDefIndex: 57960
		{
			// Constructors
			public Title() {} // 0x000000018B248288-0x000000018B2482CC
		}
	
		public class CountryName : AttributeTypeAndValue // TypeDefIndex: 57961
		{
			// Constructors
			public CountryName() {} // 0x000000018B23F230-0x000000018B23F27C
		}
	
		public class DnQualifier : AttributeTypeAndValue // TypeDefIndex: 57962
		{
			// Constructors
			public DnQualifier() {} // 0x000000018B23FAB4-0x000000018B23FB00
		}
	
		public class Surname : AttributeTypeAndValue // TypeDefIndex: 57963
		{
			// Constructors
			public Surname() {} // 0x000000018B248244-0x000000018B248288
		}
	
		public class GivenName : AttributeTypeAndValue // TypeDefIndex: 57964
		{
			// Constructors
			public GivenName() {} // 0x000000018B24000C-0x000000018B240050
		}
	
		public class Initial : AttributeTypeAndValue // TypeDefIndex: 57965
		{
			// Constructors
			public Initial() {} // 0x000000018B240050-0x000000018B240094
		}
	
		// Constructors
		public X520() {} // Dummy constructor
	}
}

namespace Mono.Security.X509.Extensions
{
	public class AuthorityKeyIdentifierExtension : Mono.Security.X509.X509Extension // TypeDefIndex: 57967
	{
		// Fields
		private byte[] aki; // 0x28
	
		// Properties
		public byte[] Identifier { get => default; } // 0x000000018B23C7F0-0x000000018B23C844 
	
		// Constructors
		public AuthorityKeyIdentifierExtension() {} // Dummy constructor
		public AuthorityKeyIdentifierExtension(Mono.Security.X509.X509Extension extension) {} // 0x000000018B23C7E8-0x000000018B23C7F0
	
		// Methods
		protected override void Decode() {} // 0x000000018B23C438-0x000000018B23C554
		protected override void Encode() {} // 0x000000018B23C554-0x000000018B23C698
		public override string ToString() => default; // 0x000000018B23C698-0x000000018B23C7E8
	}

	public class BasicConstraintsExtension : Mono.Security.X509.X509Extension // TypeDefIndex: 57968
	{
		// Fields
		private bool cA; // 0x28
		private int pathLenConstraint; // 0x2C
	
		// Properties
		public bool CertificateAuthority { get => default; } // 0x00000001813B31B0-0x00000001813B31C0 
	
		// Constructors
		public BasicConstraintsExtension() {} // Dummy constructor
		public BasicConstraintsExtension(Mono.Security.X509.X509Extension extension) {} // 0x000000018B23C7E8-0x000000018B23C7F0
	
		// Methods
		protected override void Decode() {} // 0x000000018B23C844-0x000000018B23C98C
		protected override void Encode() {} // 0x000000018B23C98C-0x000000018B23CAD4
		public override string ToString() => default; // 0x000000018B23CAD4-0x000000018B23CC2C
	}
}
