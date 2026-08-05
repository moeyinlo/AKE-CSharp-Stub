/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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

// Image 51: Mono.Security.dll - Assembly: Mono.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 60432-60535
[assembly: AssemblyCompany("MONO development team")]
[assembly: AssemblyCopyright("(c) 2003-2004 Various Authors")]
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyDescription("Mono.Security.dll")]
[assembly: AssemblyProduct("MONO CLI")]
[assembly: AssemblyTitle("Mono.Security.dll")]
[assembly: CLSCompliant(true)]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("System, PublicKey=00240000048000009400000006020000002400005253413100040000010001008D56C76F9E8649383049F383C44BE0EC204181822A6C31CF5EB7EF486944D032188EA1D3920763712CCB12D75FB77E9811149E6148E5D32FBAAB37611C1878DDC19E20EF135D0CB2CFF2BFEC3D115810C3D9069638FE4BE215DBF795861920E5AB6F7DB2E2CEEF136AC23D5DD2BF031700AEC232F6C6B1C785B4305C123B37AB")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

internal sealed class Locale // TypeDefIndex: 60433
{
	// Methods
	public static string GetText(string msg); // 0x000000018464E630-0x000000018464E640
	public static string GetText(string fmt, params object[] args); // 0x0000000185397134-0x000000018539713C
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 60535
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_64 _001D686DB504E20C792EAA07FE09224A45FF328E24A80072D04D16ABC5C2B5D2; // 0x00 // Static value (base64): z4PhNX7vuL3xVChQ1m2AB9Yg5AULVxXcg/SpIdNs6c5H0NE8XYXysP+DGNKHfuwvY7kxvUdBeoGlODJ6+SfaPg== - Metadata: 0x0234DCB4
	internal static readonly __StaticArrayInitTypeSize_3132 _25E3E48132FBDBE9B7C0C6C54D7C10A5DE12A105AA3E5DE2A0DC808BF245B7A5; // 0x40 // Static value (base64): AgAAAAMAAAAFAAAABwAAAAsAAAANAAAAEQAAABMAAAAXAAAAHQAAAB8AAAAlAAAAKQAAACsAAAAvAAAANQAAADsAAAA9AAAAQwAAAEcAAABJAAAATwAAAFMAAABZAAAAYQAAAGUAAABnAAAAawAAAG0AAABxAAAAfwAAAIMAAACJAAAAiwAAAJUAAACXAAAAnQAAAKMAAACnAAAArQAAALMAAAC1AAAAvwAAAMEAAADFAAAAxwAAANMAAADfAAAA4wAAAOUAAADpAAAA7wAAAPEAAAD7AAAAAQEAAAcBAAANAQAADwEAABUBAAAZAQAAGwEAACUBAAAzAQAANwEAADkBAAA9AQAASwEAAFEBAABbAQAAXQEAAGEBAABnAQAAbwEAAHUBAAB7AQAAfwEAAIUBAACNAQAAkQEAAJkBAACjAQAApQEAAK8BAACxAQAAtwEAALsBAADBAQAAyQEAAM0BAADPAQAA0wEAAN8BAADnAQAA6wEAAPMBAAD3AQAA/QEAAAkCAAALAgAAHQIAACMCAAAtAgAAMwIAADkCAAA7AgAAQQIAAEsCAABRAgAAVwIAAFkCAABfAgAAZQIAAGkCAABrAgAAdwIAAIECAACDAgAAhwIAAI0CAACTAgAAlQIAAKECAAClAgAAqwIAALMCAAC9AgAAxQIAAM8CAADXAgAA3QIAAOMCAADnAgAA7wIAAPUCAAD5AgAAAQMAAAUDAAATAwAAHQMAACkDAAArAwAANQMAADcDAAA7AwAAPQMAAEcDAABVAwAAWQMAAFsDAABfAwAAbQMAAHEDAABzAwAAdwMAAIsDAACPAwAAlwMAAKEDAACpAwAArQMAALMDAAC5AwAAxwMAAMsDAADRAwAA1wMAAN8DAADlAwAA8QMAAPUDAAD7AwAA/QMAAAcEAAAJBAAADwQAABkEAAAbBAAAJQQAACcEAAAtBAAAPwQAAEMEAABFBAAASQQAAE8EAABVBAAAXQQAAGMEAABpBAAAfwQAAIEEAACLBAAAkwQAAJ0EAACjBAAAqQQAALEEAAC9BAAAwQQAAMcEAADNBAAAzwQAANUEAADhBAAA6wQAAP0EAAD/BAAAAwUAAAkFAAALBQAAEQUAABUFAAAXBQAAGwUAACcFAAApBQAALwUAAFEFAABXBQAAXQUAAGUFAAB3BQAAgQUAAI8FAACTBQAAlQUAAJkFAACfBQAApwUAAKsFAACtBQAAswUAAL8FAADJBQAAywUAAM8FAADRBQAA1QUAANsFAADnBQAA8wUAAPsFAAAHBgAADQYAABEGAAAXBgAAHwYAACMGAAArBgAALwYAAD0GAABBBgAARwYAAEkGAABNBgAAUwYAAFUGAABbBgAAZQYAAHkGAAB/BgAAgwYAAIUGAACdBgAAoQYAAKMGAACtBgAAuQYAALsGAADFBgAAzQYAANMGAADZBgAA3wYAAPEGAAD3BgAA+wYAAP0GAAAJBwAAEwcAAB8HAAAnBwAANwcAAEUHAABLBwAATwcAAFEHAABVBwAAVwcAAGEHAABtBwAAcwcAAHkHAACLBwAAjQcAAJ0HAACfBwAAtQcAALsHAADDBwAAyQcAAM0HAADPBwAA0wcAANsHAADhBwAA6wcAAO0HAAD3BwAABQgAAA8IAAAVCAAAIQgAACMIAAAnCAAAKQgAADMIAAA/CAAAQQgAAFEIAABTCAAAWQgAAF0IAABfCAAAaQgAAHEIAACDCAAAmwgAAJ8IAAClCAAArQgAAL0IAAC/CAAAwwgAAMsIAADbCAAA3QgAAOEIAADpCAAA7wgAAPUIAAD5CAAABQkAAAcJAAAdCQAAIwkAACUJAAArCQAALwkAADUJAABDCQAASQkAAE0JAABPCQAAVQkAAFkJAABfCQAAawkAAHEJAAB3CQAAhQkAAIkJAACPCQAAmwkAAKMJAACpCQAArQkAAMcJAADZCQAA4wkAAOsJAADvCQAA9QkAAPcJAAD9CQAAEwoAAB8KAAAhCgAAMQoAADkKAAA9CgAASQoAAFcKAABhCgAAYwoAAGcKAABvCgAAdQoAAHsKAAB/CgAAgQoAAIUKAACLCgAAkwoAAJcKAACZCgAAnwoAAKkKAACrCgAAtQoAAL0KAADBCgAAzwoAANkKAADlCgAA5woAAO0KAADxCgAA8woAAAMLAAARCwAAFQsAABsLAAAjCwAAKQsAAC0LAAA/CwAARwsAAFELAABXCwAAXQsAAGULAABvCwAAewsAAIkLAACNCwAAkwsAAJkLAACbCwAAtwsAALkLAADDCwAAywsAAM8LAADdCwAA4QsAAOkLAAD1CwAA+wsAAAcMAAALDAAAEQwAACUMAAAvDAAAMQwAAEEMAABbDAAAXwwAAGEMAABtDAAAcwwAAHcMAACDDAAAiQwAAJEMAACVDAAAnQwAALMMAAC1DAAAuQwAALsMAADHDAAA4wwAAOUMAADrDAAA8QwAAPcMAAD7DAAAAQ0AAAMNAAAPDQAAEw0AAB8NAAAhDQAAKw0AAC0NAAA9DQAAPw0AAE8NAABVDQAAaQ0AAHkNAACBDQAAhQ0AAIcNAACLDQAAjQ0AAKMNAACrDQAAtw0AAL0NAADHDQAAyQ0AAM0NAADTDQAA1Q0AANsNAADlDQAA5w0AAPMNAAD9DQAA/w0AAAkOAAAXDgAAHQ4AACEOAAAnDgAALw4AADUOAAA7DgAASw4AAFcOAABZDgAAXQ4AAGsOAABxDgAAdQ4AAH0OAACHDgAAjw4AAJUOAACbDgAAsQ4AALcOAAC5DgAAww4AANEOAADVDgAA2w4AAO0OAADvDgAA+Q4AAAcPAAALDwAADQ8AABcPAAAlDwAAKQ8AADEPAABDDwAARw8AAE0PAABPDwAAUw8AAFkPAABbDwAAZw8AAGsPAAB/DwAAlQ8AAKEPAACjDwAApw8AAK0PAACzDwAAtQ8AALsPAADRDwAA0w8AANkPAADpDwAA7w8AAPsPAAD9DwAAAxAAAA8QAAAfEAAAIRAAACUQAAArEAAAORAAAD0QAAA/EAAAURAAAGkQAABzEAAAeRAAAHsQAACFEAAAhxAAAJEQAACTEAAAnRAAAKMQAAClEAAArxAAALEQAAC7EAAAwRAAAMkQAADnEAAA8RAAAPMQAAD9EAAABREAAAsRAAAVEQAAJxEAAC0RAAA5EQAARREAAEcRAABZEQAAXxEAAGMRAABpEQAAbxEAAIERAACDEQAAjREAAJsRAAChEQAApREAAKcRAACrEQAAwxEAAMURAADREQAA1xEAAOcRAADvEQAA9REAAPsRAAANEgAAHRIAAB8SAAAjEgAAKRIAACsSAAAxEgAANxIAAEESAABHEgAAUxIAAF8SAABxEgAAcxIAAHkSAAB9EgAAjxIAAJcSAACvEgAAsxIAALUSAAC5EgAAvxIAAMESAADNEgAA0RIAAN8SAAD9EgAABxMAAA0TAAAZEwAAJxMAAC0TAAA3EwAAQxMAAEUTAABJEwAATxMAAFcTAABdEwAAZxMAAGkTAABtEwAAexMAAIETAACHEwAAixMAAJETAACTEwAAnRMAAJ8TAACvEwAAuxMAAMMTAADVEwAA2RMAAN8TAADrEwAA7RMAAPMTAAD5EwAA/xMAABsUAAAhFAAALxQAADMUAAA7FAAARRQAAE0UAABZFAAAaxQAAG8UAABxFAAAdRQAAI0UAACZFAAAnxQAAKEUAACxFAAAtxQAAL0UAADLFAAA1RQAAOMUAADnFAAABRUAAAsVAAARFQAAFxUAAB8VAAAlFQAAKRUAACsVAAA3FQAAPRUAAEEVAABDFQAASRUAAF8VAABlFQAAZxUAAGsVAAB9FQAAfxUAAIMVAACPFQAAkRUAAJcVAACbFQAAtRUAALsVAADBFQAAxRUAAM0VAADXFQAA9xUAAAcWAAAJFgAADxYAABMWAAAVFgAAGRYAABsWAAAlFgAAMxYAADkWAAA9FgAARRYAAE8WAABVFgAAaRYAAG0WAABvFgAAdRYAAJMWAACXFgAAnxYAAKkWAACvFgAAtRYAAL0WAADDFgAAzxYAANMWAADZFgAA2xYAAOEWAADlFgAA6xYAAO0WAAD3FgAA+RYAAAkXAAAPFwAAIxcAACcXAAAzFwAAQRcAAF0XAABjFwAA - Metadata: 0x0234DCFC
	internal static readonly long _290C4A052C215D096172EB81AEE671FB3286E5C1DB5E73F96021FC09825DDB88; // 0xC80 // Static value (base64): S0dTIUAjJCU= - Metadata: 0x0234E93C
	internal static readonly __StaticArrayInitTypeSize_3 _32D0830B8EE1D49A66F395C8EA80E02BFC07C2A12A8EA8C8B484AF02108A1950; // 0xC88 // Static value (base64): VQQL - Metadata: 0x0234E94C
	internal static readonly __StaticArrayInitTypeSize_3 _35BF50EEF3270FD8CA09E66FC5B0481C5A151B14F6A634854E32F63633D49DCB; // 0xC8B // Static value (base64): VQQE - Metadata: 0x0234E954
	internal static readonly __StaticArrayInitTypeSize_3 _3C0C410618682C4DF0474E034114CC8E562F05A512B521AC367571017BDFA75D; // 0xC8E // Static value (base64): VQQK - Metadata: 0x0234E95C
	internal static readonly __StaticArrayInitTypeSize_3 _44F5B1A2C48314502ACCBF186D1A2F9F7F176825898F32F1A2047B956194F174; // 0xC91 // Static value (base64): VQQq - Metadata: 0x0234E964
	internal static readonly __StaticArrayInitTypeSize_48 _4800FBFC4566EB02D1727A4B1C949CCBC7535C216A0766564C199308631B5DD6; // 0xC94 // Static value (base64): OLBgp1GsljhM2TJ+sbHjaiH9txEUvgdDTAzHv2P24donTt6/529l+9Ua0vFImLlb - Metadata: 0x0234E96C
	internal static readonly __StaticArrayInitTypeSize_20 _533B8C444F951E83EFF7305E3807B66CE0005DE0A2D0A44873C130895A3BE6AA; // 0xCC4 // Static value (base64): 2jmj7l5rSw0yVb/vlWAYkK/YBwk= - Metadata: 0x0234E9A4
	internal static readonly __StaticArrayInitTypeSize_256 _55D0BF716B334D123E0088CFB3F8E2FEA17AF5025BB527F95EEB09BA978EA329; // 0xCD8 // Static value (base64): KS5DyaLYfAE9NlSh7PAGE2KnBfPAx3OMmJMr2bxMgsoem1c8/dTgFmdCbxiKF+USvk7E1tqe3kmg+/WOuy/ueqloeZEVsgc/lMIQiQsiXyGAf12aWpAyJzU+zOe/95cD/xkws0iltdHXXpIqrFaqxk+4ONKWpH22dvxr4px0BPFFnXBZZHGHIIZbz2XmLagCG2Alra6wufYcRmFpNEB+D1VHoyPdUa86w1z5zrrF6iYsUw1uhSiECdPfzfRBgU1Satw3yGzBq/ok4XsIDL2xSniIlYvjY+ht6cvV/jsAHTny77cOZljQ5KZ3cvjrdUsKMURQtI/tHxrbmY0znxGDFA== - Metadata: 0x0234E9BC
	internal static readonly __StaticArrayInitTypeSize_3 _59BE5A634187B8A57216EFF5371A47732C05744B1C1A0A6382A6D5622C9FFDCE; // 0xDD8 // Static value (base64): VQQG - Metadata: 0x0234EAC4
	internal static readonly __StaticArrayInitTypeSize_32 _5DF6E0E2761359D30A8275058E299FCC0381534545F55CF43E41983F5D4C9456; // 0xDDB // Static value (base64): 47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU= - Metadata: 0x0234EACC
	internal static readonly __StaticArrayInitTypeSize_3 _5F8C6B3C66B972606D85E7651F67ADBD02E8316876884674E8328FA710747E5B; // 0xDFB // Static value (base64): VQQM - Metadata: 0x0234EAF4
	internal static readonly __StaticArrayInitTypeSize_10 _60C6ED13AF98DBFEEDA8F8197FFFCC349BB04395CC81DF0D477CBC57BF5B398B; // 0xDFE // Static value (base64): CZImiZPyLGQBGQ== - Metadata: 0x0234EAFC
	internal static readonly __StaticArrayInitTypeSize_10 _64B3E7D737AFF47D4C3BBD81D2D06D697DDD8EB60F29E13E4425D19D8BBCA1F7; // 0xE08 // Static value (base64): CZImiZPyLGQBAQ== - Metadata: 0x0234EB0C
	internal static readonly long _6772A9B8BF207A3CFE6EE68769D6985B69522183F24A2A3D41BC3B4602953426; // 0xE18 // Static value (base64): TlRMTVNTUAA= - Metadata: 0x0234EB1C
	internal static readonly __StaticArrayInitTypeSize_9 _684312AFB7719E57993D2826FFBAF7EA965614F20F91D999FB19B01E21AA62E6; // 0xE20 // Static value (base64): KoZIhvcNAQkB - Metadata: 0x0234EB2C
	internal static readonly __StaticArrayInitTypeSize_64 _6AA56C4BCD208911792AD24C7681FEFB93BED51903AFC54860C9BD37E41E5A31; // 0xE29 // Static value (base64): AwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAw== - Metadata: 0x0234EB3C
	internal static readonly __StaticArrayInitTypeSize_3 _796E63069E193A008CB4E85573AA1FE53C5F4E58B42A7F61FD0EEE1D89B5120B; // 0xE69 // Static value (base64): VQQH - Metadata: 0x0234EB84
	internal static readonly __StaticArrayInitTypeSize_64 _7C8975E1E60A5C8337F28EDF8C33C3B180360B7279644A9BC1AF3C51E6220BF5; // 0xE6C // Static value (base64): AQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQ== - Metadata: 0x0234EB8C
	internal static readonly __StaticArrayInitTypeSize_3 _850D7367E4FB0766E2CBC3ACF5AB42B4E98348E58E5A789845D4FCCDB63D2AEE; // 0xEAC // Static value (base64): VQQJ - Metadata: 0x0234EBD4
	internal static readonly long _992F16C986809AB68C7466CC3EC6F12B2506A962EA539753E5D84A2FB7FF8A24; // 0xEB0 // Static value (base64): qtO0NbUUBO4= - Metadata: 0x0234EBDC
	internal static readonly __StaticArrayInitTypeSize_3 _9A65C09A11757751BFED67A414E00B188DC4C7757FCB6CBD33A916DDE4A3D925; // 0xEB8 // Static value (base64): VQQF - Metadata: 0x0234EBEC
	internal static readonly __StaticArrayInitTypeSize_18 _9ACEFCC0C950280B64AB9E045E38C34ABF71EC70A0DC61B9C621C6BFB4F78047; // 0xEBB // Static value (base64): LAArACIAPQA8AD4AOwAjAAoA - Metadata: 0x0234EBF4
	internal static readonly __StaticArrayInitTypeSize_3 B1E34F4A11EE411B83415EF0B252A0B2BBCFCAC2E592865E09C12E4252C93A75; // 0xECD // Static value (base64): VQQu - Metadata: 0x0234EC0C
	internal static readonly __StaticArrayInitTypeSize_3 C92FAD7F348A682E7D5B7E74C76B5D019174EE7BC87545B25A1FDD49FBCC2D0B; // 0xED0 // Static value (base64): VQQI - Metadata: 0x0234EC14
	internal static readonly __StaticArrayInitTypeSize_3 E17B8359E685992B0DE6242AAA24FCB7404173CBB7FF8646FF7D658139F41B5F; // 0xED3 // Static value (base64): VQQD - Metadata: 0x0234EC1C
	internal static readonly __StaticArrayInitTypeSize_64 F83B332BE4E6A5A4B1C56AAF6DB52657DA495E149870057D8590AB9D7A6167AD; // 0xED6 // Static value (base64): AgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg== - Metadata: 0x0234EC24
	internal static readonly __StaticArrayInitTypeSize_3 FB6D7301FFDCB5FBA5807A19B4F0606947897C1105240B6BBA815352DBBE2064; // 0xF16 // Static value (base64): VQQr - Metadata: 0x0234EC6C

	// Nested types
	private struct __StaticArrayInitTypeSize_3 // TypeDefIndex: 60525
	{
	}

	private struct __StaticArrayInitTypeSize_9 // TypeDefIndex: 60526
	{
	}

	private struct __StaticArrayInitTypeSize_10 // TypeDefIndex: 60527
	{
	}

	private struct __StaticArrayInitTypeSize_18 // TypeDefIndex: 60528
	{
	}

	private struct __StaticArrayInitTypeSize_20 // TypeDefIndex: 60529
	{
	}

	private struct __StaticArrayInitTypeSize_32 // TypeDefIndex: 60530
	{
	}

	private struct __StaticArrayInitTypeSize_48 // TypeDefIndex: 60531
	{
	}

	private struct __StaticArrayInitTypeSize_64 // TypeDefIndex: 60532
	{
	}

	private struct __StaticArrayInitTypeSize_256 // TypeDefIndex: 60533
	{
	}

	private struct __StaticArrayInitTypeSize_3132 // TypeDefIndex: 60534
	{
	}

	// Methods
	internal static uint ComputeStringHash(string s); // 0x000000018687A850-0x000000018687A8A4
}

namespace Mono.Math
{
	public class BigInteger // TypeDefIndex: 60519
	{
		// Fields
		private uint length; // 0x10
		private uint[] data; // 0x18
		internal static readonly uint[] smallPrimes; // 0x00
		private static RandomNumberGenerator rng; // 0x08
	
		// Properties
		private static RandomNumberGenerator Rng { get; } // 0x000000018A723B08-0x000000018A723BB0 
	
		// Nested types
		public enum Sign // TypeDefIndex: 60516
		{
			Negative = -1,
			Zero = 0,
			Positive = 1
		}
	
		public sealed class ModulusRing // TypeDefIndex: 60517
		{
			// Fields
			private BigInteger mod; // 0x10
			private BigInteger constant; // 0x18
	
			// Constructors
			public ModulusRing(BigInteger modulus); // 0x000000018A728DB0-0x000000018A728EA4
	
			// Methods
			public void BarrettReduction(BigInteger x); // 0x000000018A728664-0x000000018A728920
			public BigInteger Multiply(BigInteger a, BigInteger b); // 0x000000018A728ABC-0x000000018A728C18
			public BigInteger Difference(BigInteger a, BigInteger b); // 0x000000018A728920-0x000000018A728ABC
			public BigInteger Pow(BigInteger a, BigInteger k); // 0x000000018A728C9C-0x000000018A728DB0
			[CLSCompliant(false)]
			public BigInteger Pow(uint b, BigInteger exp); // 0x000000018A728C18-0x000000018A728C9C
		}
	
		private sealed class Kernel // TypeDefIndex: 60518
		{
			// Methods
			public static BigInteger AddSameSign(BigInteger bi1, BigInteger bi2); // 0x000000018A724EA0-0x000000018A725070
			public static BigInteger Subtract(BigInteger big, BigInteger small); // 0x000000018A725C64-0x000000018A725E10
			public static void MinusEq(BigInteger big, BigInteger small); // 0x000000018A72553C-0x000000018A725664
			public static void PlusEq(BigInteger bi1, BigInteger bi2); // 0x000000018A7258AC-0x000000018A725A44
			public static Sign Compare(BigInteger bi1, BigInteger bi2); // 0x000000018A725070-0x000000018A7251A4
			public static uint SingleByteDivideInPlace(BigInteger n, uint d); // 0x000000018A725BF8-0x000000018A725C64
			public static uint DwordMod(BigInteger n, uint d); // 0x000000018A72530C-0x000000018A725364
			public static BigInteger[] DwordDivMod(BigInteger n, uint d); // 0x000000018A7251A4-0x000000018A72530C
			public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2); // 0x000000018A72634C-0x000000018A7268C8
			public static BigInteger LeftShift(BigInteger bi, int n); // 0x000000018A725364-0x000000018A72553C
			public static BigInteger RightShift(BigInteger bi, int n); // 0x000000018A725A44-0x000000018A725BF8
			public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset); // 0x000000018A725798-0x000000018A7258AC
			public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod); // 0x000000018A725664-0x000000018A725798
			public static uint modInverse(BigInteger bi, uint modulus); // 0x000000018A725E10-0x000000018A725EBC
			public static BigInteger modInverse(BigInteger bi, BigInteger modulus); // 0x000000018A725EBC-0x000000018A72634C
		}
	
		// Constructors
		[CLSCompliant(false)]
		public BigInteger(Sign sign, uint len); // 0x000000018A723758-0x000000018A7237B8
		public BigInteger(BigInteger bi); // 0x000000018A7236C0-0x000000018A723758
		[CLSCompliant(false)]
		public BigInteger(BigInteger bi, uint len); // 0x000000018A723A54-0x000000018A723B08
		public BigInteger(byte[] inData); // 0x000000018A7237B8-0x000000018A7239E0
		[CLSCompliant(false)]
		public BigInteger(uint ui); // 0x000000018A7239E0-0x000000018A723A54
		static BigInteger(); // 0x000000018A723634-0x000000018A7236C0
	
		// Methods
		[CLSCompliant(false)]
		public static implicit operator BigInteger(uint value); // 0x000000018A723DC0-0x000000018A723E20
		public static implicit operator BigInteger(int value); // 0x000000018A723E20-0x000000018A723ED0
		public static BigInteger operator +(BigInteger bi1, BigInteger bi2); // 0x000000018A723BB0-0x000000018A723C78
		public static BigInteger operator -(BigInteger bi1, BigInteger bi2); // 0x000000018A724240-0x000000018A72440C
		[CLSCompliant(false)]
		public static uint operator %(BigInteger bi, uint ui); // 0x000000018A72401C-0x000000018A724024
		public static BigInteger operator %(BigInteger bi1, BigInteger bi2); // 0x000000018A723FF0-0x000000018A72401C
		public static BigInteger operator /(BigInteger bi1, BigInteger bi2); // 0x000000018A723C78-0x000000018A723CA4
		public static BigInteger operator *(BigInteger bi1, BigInteger bi2); // 0x000000018A724024-0x000000018A724238
		public static BigInteger operator <<(BigInteger bi1, int shiftVal); // 0x000000018A723FBC-0x000000018A723FC4
		public static BigInteger operator >>(BigInteger bi1, int shiftVal); // 0x000000018A724238-0x000000018A724240
		public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng); // 0x000000018A722DA8-0x000000018A722F08
		public static BigInteger GenerateRandom(int bits); // 0x000000018A722F08-0x000000018A722F54
		public int BitCount(); // 0x000000018A722BB4-0x000000018A722C10
		public bool TestBit(int bitNum); // 0x000000018A7232E8-0x000000018A723388
		[CLSCompliant(false)]
		public void SetBit(uint bitNum); // 0x000000018A723288-0x000000018A723294
		[CLSCompliant(false)]
		public void SetBit(uint bitNum, bool value); // 0x000000018A723294-0x000000018A7232E8
		public int LowestSetBit(); // 0x000000018A723138-0x000000018A7231AC
		public byte[] GetBytes(); // 0x000000018A722F54-0x000000018A72306C
		[CLSCompliant(false)]
		public static bool operator ==(BigInteger bi1, uint ui); // 0x000000018A723CA4-0x000000018A723CFC
		[CLSCompliant(false)]
		public static bool operator !=(BigInteger bi1, uint ui); // 0x000000018A723F64-0x000000018A723FBC
		public static bool operator ==(BigInteger bi1, BigInteger bi2); // 0x000000018A723CFC-0x000000018A723D90
		public static bool operator !=(BigInteger bi1, BigInteger bi2); // 0x000000018A723ED0-0x000000018A723F64
		public static bool operator >(BigInteger bi1, BigInteger bi2); // 0x000000018A723DA8-0x000000018A723DC0
		public static bool operator <(BigInteger bi1, BigInteger bi2); // 0x000000018A723FDC-0x000000018A723FF0
		public static bool operator >=(BigInteger bi1, BigInteger bi2); // 0x000000018A723D90-0x000000018A723DA8
		public static bool operator <=(BigInteger bi1, BigInteger bi2); // 0x000000018A723FC4-0x000000018A723FDC
		[CLSCompliant(false)]
		public string ToString(uint radix); // 0x000000018A7235D8-0x000000018A723624
		[CLSCompliant(false)]
		public string ToString(uint radix, string characterSet); // 0x000000018A723388-0x000000018A7235D8
		private void Normalize(); // 0x000000018A72323C-0x000000018A723288
		public void Clear(); // 0x000000018A722C10-0x000000018A722C58
		public override int GetHashCode(); // 0x000000018A72306C-0x000000018A7230B0
		public override string ToString(); // 0x000000018A723624-0x000000018A723634
		public override bool Equals(object o); // 0x000000018A722C58-0x000000018A722D38
		public BigInteger ModInverse(BigInteger modulus); // 0x000000018A7231AC-0x000000018A7231B4
		public BigInteger ModPow(BigInteger exp, BigInteger n); // 0x000000018A7231B4-0x000000018A72323C
		public static BigInteger GeneratePseudoPrime(int bits); // 0x000000018A722D38-0x000000018A722DA8
		public void Incr2(); // 0x000000018A7230B0-0x000000018A723138
	}
}

namespace Mono.Math.Prime
{
	public enum ConfidenceFactor // TypeDefIndex: 60520
	{
		ExtraLow = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		ExtraHigh = 4,
		Provable = 5
	}

	public delegate bool PrimalityTest(BigInteger bi, ConfidenceFactor confidence); // TypeDefIndex: 60521; 0x00000001815802E0-0x00000001815802F0

	public sealed class PrimalityTests // TypeDefIndex: 60522
	{
		// Methods
		private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence); // 0x000000018A72A3C4-0x000000018A72A578
		public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence); // 0x000000018A72A578-0x000000018A72A800
	}
}

namespace Mono.Math.Prime.Generator
{
	public abstract class PrimeGeneratorBase // TypeDefIndex: 60523
	{
		// Properties
		public virtual ConfidenceFactor Confidence { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		public virtual PrimalityTest PrimalityTest { get; } // 0x000000018A72A800-0x000000018A72A868 
		public virtual int TrialDivisionBounds { get; } // 0x0000000184DA3390-0x0000000184DA33A0 
	
		// Constructors
		protected PrimeGeneratorBase(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract BigInteger GenerateNewPrime(int bits);
	}

	public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 60524
	{
		// Constructors
		public SequentialSearchPrimeGeneratorBase(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected virtual BigInteger GenerateSearchBase(int bits, object context); // 0x000000018A72DA54-0x000000018A72DAB4
		public override BigInteger GenerateNewPrime(int bits); // 0x000000018A72DA48-0x000000018A72DA54
		public virtual BigInteger GenerateNewPrime(int bits, object context); // 0x000000018A72D834-0x000000018A72DA48
		protected virtual bool IsPrimeAcceptable(BigInteger bi, object context); // 0x0000000182FFF600-0x0000000182FFF610
	}
}

namespace Mono.Security
{
	public class ASN1 // TypeDefIndex: 60434
	{
		// Fields
		private byte m_nTag; // 0x10
		private byte[] m_aValue; // 0x18
		private ArrayList elist; // 0x20
	
		// Properties
		public int Count { get; } // 0x000000018A70CD60-0x000000018A70CD88 
		public byte Tag { get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
		public int Length { get; } // 0x0000000189EEF220-0x0000000189EEF234 
		public byte[] Value { get; set; } // 0x000000018A70CE5C-0x000000018A70CE9C 0x000000018A70CE9C-0x000000018A70CEF0
		public ASN1 this[int index] { get => default; } // 0x000000018A70CD88-0x000000018A70CE5C 
	
		// Constructors
		public ASN1(byte tag); // 0x0000000185391954-0x0000000185391968
		public ASN1(byte tag, byte[] data); // 0x0000000183219380-0x0000000183219390
		public ASN1(byte[] data); // 0x000000018A70CC0C-0x000000018A70CD60
	
		// Methods
		private bool CompareArray(byte[] array1, byte[] array2); // 0x000000018A70C118-0x000000018A70C17C
		public bool CompareValue(byte[] value); // 0x000000018A70C17C-0x000000018A70C18C
		public ASN1 Add(ASN1 asn1); // 0x000000018A70C09C-0x000000018A70C118
		public virtual byte[] GetBytes(); // 0x000000018A70C468-0x000000018A70C9E4
		protected void Decode(byte[] asn1, ref int anPos, int anLength); // 0x000000018A70C270-0x000000018A70C374
		protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content); // 0x000000018A70C18C-0x000000018A70C270
		public ASN1 Element(int index, byte anTag); // 0x000000018A70C374-0x000000018A70C468
		public override string ToString(); // 0x000000018A70C9E4-0x000000018A70CC0C
	}

	public static class ASN1Convert // TypeDefIndex: 60435
	{
		// Methods
		public static ASN1 FromInt32(int value); // 0x000000018A70B5A4-0x000000018A70B6D4
		public static ASN1 FromOid(string oid); // 0x000000018A70B6D4-0x000000018A70B7AC
		public static ASN1 FromUnsignedBigInteger(byte[] big); // 0x000000018A70B7AC-0x000000018A70B8C8
		public static int ToInt32(ASN1 asn1); // 0x000000018A70BD50-0x000000018A70BE74
		public static string ToOid(ASN1 asn1); // 0x000000018A70BE74-0x000000018A70C09C
		public static System.DateTime ToDateTime(ASN1 time); // 0x000000018A70B8C8-0x000000018A70BD50
	}

	internal sealed class BitConverterLE // TypeDefIndex: 60436
	{
		// Methods
		private static unsafe byte[] GetUIntBytes(byte* bytes); // 0x000000018A70DA14-0x000000018A70DAF0
		private static unsafe byte[] GetULongBytes(byte* bytes); // 0x000000018A70DAF0-0x000000018A70DC4C
		internal static byte[] GetBytes(int value); // 0x000000018A70D9F8-0x000000018A70DA14
		internal static byte[] GetBytes(long value); // 0x000000018A70D9DC-0x000000018A70D9F8
		private static unsafe void UShortFromBytes(byte* dst, byte[] src, int startIndex); // 0x000000018A70DD94-0x000000018A70DE48
		private static unsafe void UIntFromBytes(byte* dst, byte[] src, int startIndex); // 0x000000018A70DC9C-0x000000018A70DD94
		internal static int ToInt32(byte[] value, int startIndex); // 0x000000018A70DC4C-0x000000018A70DC74
		internal static ushort ToUInt16(byte[] value, int startIndex); // 0x000000018A70DC74-0x000000018A70DC9C
		internal static uint ToUInt32(byte[] value, int startIndex); // 0x000000018A70DC4C-0x000000018A70DC74
	}

	public sealed class PKCS7 // TypeDefIndex: 60441
	{
		// Nested types
		public class ContentInfo // TypeDefIndex: 60437
		{
			// Fields
			private string contentType; // 0x10
			private ASN1 content; // 0x18
	
			// Properties
			public ASN1 ASN1 { get; } // 0x000000018A70FFD8-0x000000018A70FFE0 
			public ASN1 Content { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
			public string ContentType { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
			// Constructors
			public ContentInfo(); // 0x000000018A70FCF0-0x000000018A70FD58
			public ContentInfo(string oid); // 0x000000018A70FDD0-0x000000018A70FE00
			public ContentInfo(byte[] data); // 0x000000018A70FD58-0x000000018A70FDD0
			public ContentInfo(ASN1 asn1); // 0x000000018A70FE00-0x000000018A70FFD8
	
			// Methods
			internal ASN1 GetASN1(); // 0x000000018A70FC54-0x000000018A70FCF0
		}
	
		public class EncryptedData // TypeDefIndex: 60438
		{
			// Fields
			private byte _version; // 0x10
			private ContentInfo _content; // 0x18
			private ContentInfo _encryptionAlgorithm; // 0x20
			private byte[] _encrypted; // 0x28
	
			// Properties
			public ContentInfo EncryptionAlgorithm { get; } // 0x0000000184D862C0-0x0000000184D862D0 
			public byte[] EncryptedContent { get; } // 0x000000018A710D68-0x000000018A710DBC 
	
			// Constructors
			public EncryptedData(); // 0x0000000184D8CCB0-0x0000000184D8CCC0
			public EncryptedData(ASN1 asn1); // 0x000000018A710948-0x000000018A710D68
		}
	
		public class SignedData // TypeDefIndex: 60439
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
			public Mono.Security.X509.X509CertificateCollection Certificates { get; } // 0x0000000184D86240-0x0000000184D86250 
			public ContentInfo ContentInfo { get; } // 0x0000000184D862C0-0x0000000184D862D0 
			public string HashName { set; } // 0x000000018A718824-0x000000018A71885C
			public SignerInfo SignerInfo { get; } // 0x0000000184D85A50-0x0000000184D85A60 
	
			// Constructors
			public SignedData(ASN1 asn1); // 0x000000018A71824C-0x000000018A718824
	
			// Methods
			internal string OidToName(string oid); // 0x000000018A7180DC-0x000000018A71824C
		}
	
		public class SignerInfo // TypeDefIndex: 60440
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
			public string IssuerName { get; } // 0x0000000184D85A50-0x0000000184D85A60 
			public byte[] SerialNumber { get; } // 0x000000018A718D20-0x000000018A718D74 
			public ArrayList AuthenticatedAttributes { get; } // 0x0000000184D862C0-0x0000000184D862D0 
			public string HashName { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
			public byte[] Signature { get; } // 0x000000018A718D74-0x000000018A718DC8 
			public ArrayList UnauthenticatedAttributes { get; } // 0x0000000184D86240-0x0000000184D86250 
			public byte Version { get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
	
			// Constructors
			public SignerInfo(); // 0x000000018A71885C-0x000000018A7188F0
			public SignerInfo(ASN1 asn1); // 0x000000018A7188F0-0x000000018A718D20
		}
	}
}

namespace Mono.Security.Authenticode
{
	public class AuthenticodeBase // TypeDefIndex: 60514
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
		internal int PEOffset { get; } // 0x000000018A721478-0x000000018A72149C 
	
		// Constructors
		public AuthenticodeBase(); // 0x000000018A721430-0x000000018A721478
	
		// Methods
		internal void Open(string filename); // 0x000000018A720FD4-0x000000018A721074
		internal void Open(byte[] rawdata); // 0x000000018A721074-0x000000018A721104
		internal void Close(); // 0x000000018A720AC4-0x000000018A720B00
		internal void ReadFirstBlock(); // 0x000000018A72134C-0x000000018A721430
		internal int ProcessFirstBlock(); // 0x000000018A721104-0x000000018A72134C
		internal byte[] GetSecurityEntry(); // 0x000000018A720F24-0x000000018A720FD4
		internal byte[] GetHash(HashAlgorithm hash); // 0x000000018A720B00-0x000000018A720F24
	}

	public class AuthenticodeDeformatter : AuthenticodeBase // TypeDefIndex: 60515
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
		public byte[] RawData { set; } // 0x000000018A722AC8-0x000000018A722BB4
		public Mono.Security.X509.X509Certificate SigningCertificate { get; } // 0x0000000184D862B0-0x0000000184D862C0 
	
		// Constructors
		public AuthenticodeDeformatter(); // 0x000000018A7229EC-0x000000018A722A98
		public AuthenticodeDeformatter(byte[] rawData); // 0x000000018A722A98-0x000000018A722AC8
	
		// Methods
		private bool CheckSignature(); // 0x000000018A72149C-0x000000018A721798
		private bool CompareIssuerSerial(string issuer, byte[] serial, Mono.Security.X509.X509Certificate x509); // 0x000000018A721798-0x000000018A721858
		private bool VerifySignature(PKCS7.SignedData sd, byte[] calculatedMessageDigest, HashAlgorithm ha); // 0x000000018A722144-0x000000018A7229EC
		private bool VerifyCounterSignature(PKCS7.SignerInfo cs, byte[] signature); // 0x000000018A721934-0x000000018A722144
		private void Reset(); // 0x000000018A721858-0x000000018A721934
	}
}

namespace Mono.Security.Cryptography
{
	public sealed class CryptoConvert // TypeDefIndex: 60503
	{
		// Methods
		public static string ToHex(byte[] input); // 0x000000018A7245E4-0x000000018A7246D4
		private static byte FromHexChar(char c); // 0x000000018A72440C-0x000000018A724494
		public static byte[] FromHex(string hex); // 0x000000018A724494-0x000000018A7245E4
	}

	public abstract class MD2 : HashAlgorithm // TypeDefIndex: 60504
	{
		// Constructors
		protected MD2(); // 0x0000000184DA3AD0-0x0000000184DA3AE0
	
		// Methods
		public static MD2 Create(); // 0x000000018A726ECC-0x000000018A726F1C
	}

	public class MD2Managed : MD2 // TypeDefIndex: 60505
	{
		// Fields
		private byte[] state; // 0x28
		private byte[] checksum; // 0x30
		private byte[] buffer; // 0x38
		private int count; // 0x40
		private byte[] x; // 0x48
		private static readonly byte[] PI_SUBST; // 0x00
	
		// Constructors
		public MD2Managed(); // 0x000000018A726E14-0x000000018A726ECC
		static MD2Managed(); // 0x000000018A726D88-0x000000018A726E14
	
		// Methods
		private byte[] Padding(int nLength); // 0x000000018A726D10-0x000000018A726D88
		public override void Initialize(); // 0x000000018A726A74-0x000000018A726AD0
		protected override void HashCore(byte[] array, int ibStart, int cbSize); // 0x000000018A7268C8-0x000000018A7269C4
		protected override byte[] HashFinal(); // 0x000000018A7269C4-0x000000018A726A74
		private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index); // 0x000000018A726AD0-0x000000018A726D10
	}

	public abstract class MD4 : HashAlgorithm // TypeDefIndex: 60506
	{
		// Constructors
		protected MD4(); // 0x0000000184DA3AD0-0x0000000184DA3AE0
	
		// Methods
		public static MD4 Create(); // 0x000000018A72820C-0x000000018A72825C
	}

	public class MD4Managed : MD4 // TypeDefIndex: 60507
	{
		// Fields
		private uint[] state; // 0x28
		private byte[] buffer; // 0x30
		private uint[] count; // 0x38
		private uint[] x; // 0x40
		private byte[] digest; // 0x48
	
		// Constructors
		public MD4Managed(); // 0x000000018A72812C-0x000000018A72820C
	
		// Methods
		public override void Initialize(); // 0x000000018A7272F8-0x000000018A7273C4
		protected override void HashCore(byte[] array, int ibStart, int cbSize); // 0x000000018A727078-0x000000018A7271F8
		protected override byte[] HashFinal(); // 0x000000018A7271F8-0x000000018A7272F8
		private byte[] Padding(int nLength); // 0x000000018A7280D0-0x000000018A72812C
		private uint F(uint x, uint y, uint z); // 0x0000000184DA3B20-0x0000000184DA3B30
		private uint G(uint x, uint y, uint z); // 0x0000000184DA3B80-0x0000000184DA3B90
		private uint H(uint x, uint y, uint z); // 0x0000000184DA3BD0-0x0000000184DA3BE0
		private uint ROL(uint x, byte n); // 0x0000000184DA3BE0-0x0000000184DA3C00
		private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s); // 0x0000000184DA3AE0-0x0000000184DA3B20
		private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s); // 0x0000000184DA3B30-0x0000000184DA3B80
		private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s); // 0x0000000184DA3B90-0x0000000184DA3BD0
		private void Encode(byte[] output, uint[] input); // 0x000000018A726FB4-0x000000018A727078
		private void Decode(uint[] output, byte[] input, int index); // 0x000000018A726F1C-0x000000018A726FB4
		private void MD4Transform(uint[] state, byte[] block, int index); // 0x000000018A7273C4-0x000000018A7280D0
	}

	public sealed class PKCS1 // TypeDefIndex: 60508
	{
		// Fields
		private static byte[] emptySHA1; // 0x00
		private static byte[] emptySHA256; // 0x08
		private static byte[] emptySHA384; // 0x10
		private static byte[] emptySHA512; // 0x18
	
		// Constructors
		static PKCS1(); // 0x000000018A72A100-0x000000018A72A29C
	
		// Methods
		private static bool Compare(byte[] array1, byte[] array2); // 0x000000018A7293F0-0x000000018A729454
		public static byte[] I2OSP(byte[] x, int size); // 0x000000018A729E14-0x000000018A729E94
		public static byte[] OS2IP(byte[] x); // 0x000000018A729E94-0x000000018A729F44
		public static byte[] RSAVP1(RSA rsa, byte[] s); // 0x0000000183219480-0x00000001832194B0
		public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding); // 0x000000018A729F44-0x000000018A72A100
		public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength); // 0x000000018A7297E4-0x000000018A729AFC
		internal static string HashNameFromOid(string oid, bool throwOnError = true /* Metadata: 0x0234DCA3 */); // 0x000000018A729AFC-0x000000018A729E14
		internal static HashAlgorithm CreateFromOid(string oid); // 0x000000018A729794-0x000000018A7297E4
		internal static HashAlgorithm CreateFromName(string name); // 0x000000018A729454-0x000000018A729794
	}

	public sealed class PKCS8 // TypeDefIndex: 60511
	{
		// Nested types
		public class PrivateKeyInfo // TypeDefIndex: 60509
		{
			// Fields
			private int _version; // 0x10
			private string _algorithm; // 0x18
			private byte[] _key; // 0x20
			private ArrayList _list; // 0x28
	
			// Properties
			public string Algorithm { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
			public byte[] PrivateKey { get; set; } // 0x000000018A72BAC0-0x000000018A72BB14 0x000000018A72BB14-0x000000018A72BBDC
	
			// Constructors
			public PrivateKeyInfo(); // 0x000000018A72BA28-0x000000018A72BA90
			public PrivateKeyInfo(byte[] data); // 0x000000018A72BA90-0x000000018A72BAC0
	
			// Methods
			private void Decode(byte[] data); // 0x000000018A72AEB0-0x000000018A72B1B4
			public byte[] GetBytes(); // 0x000000018A72B4FC-0x000000018A72B8EC
			private static byte[] RemoveLeadingZero(byte[] bigInt); // 0x000000018A72B984-0x000000018A72BA28
			private static byte[] Normalize(byte[] bigInt, int length); // 0x000000018A72B8EC-0x000000018A72B984
			public static RSA DecodeRSA(byte[] keypair); // 0x000000018A72A998-0x000000018A72AEB0
			public static byte[] Encode(RSA rsa); // 0x000000018A72B1F8-0x000000018A72B3F4
			public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters); // 0x000000018A72A868-0x000000018A72A998
			public static byte[] Encode(DSA dsa); // 0x000000018A72B1B4-0x000000018A72B1F8
			public static byte[] Encode(AsymmetricAlgorithm aa); // 0x000000018A72B3F4-0x000000018A72B4FC
		}
	
		public class EncryptedPrivateKeyInfo // TypeDefIndex: 60510
		{
			// Fields
			private string _algorithm; // 0x10
			private byte[] _salt; // 0x18
			private int _iterations; // 0x20
			private byte[] _data; // 0x28
	
			// Properties
			public string Algorithm { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
			public byte[] EncryptedData { get; set; } // 0x000000018A724CBC-0x000000018A724D10 0x000000018A724DAC-0x000000018A724E1C
			public byte[] Salt { get; } // 0x000000018A724D10-0x000000018A724DAC 
			public int IterationCount { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x000000018A724E1C-0x000000018A724EA0
	
			// Constructors
			public EncryptedPrivateKeyInfo(); // 0x00000001841E1670-0x00000001841E1680
			public EncryptedPrivateKeyInfo(byte[] data); // 0x000000018A724CB4-0x000000018A724CBC
	
			// Methods
			private void Decode(byte[] data); // 0x000000018A7246D4-0x000000018A724AB4
			public byte[] GetBytes(); // 0x000000018A724AB4-0x000000018A724CB4
		}
	}

	public class RSAManaged : RSA // TypeDefIndex: 60513
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
		[CompilerGenerated]
		private KeyGeneratedEventHandler KeyGenerated; // 0x68
	
		// Properties
		public override int KeySize { get; } // 0x000000018A72D71C-0x000000018A72D7B4 
		public bool PublicOnly { get; } // 0x000000018A72D7B4-0x000000018A72D834 
	
		// Nested types
		public delegate void KeyGeneratedEventHandler(object sender, EventArgs e); // TypeDefIndex: 60512; 0x00000001838E1420-0x00000001838E1430
	
		// Constructors
		public RSAManaged(); // 0x000000018A72D650-0x000000018A72D660
		public RSAManaged(int keySize); // 0x000000018A72D660-0x000000018A72D71C
	
		// Methods
		~RSAManaged(); // 0x000000018A72C6AC-0x000000018A72C724
		private void GenerateKeyPair(); // 0x000000018A72C724-0x000000018A72C9E8
		public override byte[] DecryptValue(byte[] rgb); // 0x000000018A72BBDC-0x000000018A72BF4C
		public override byte[] EncryptValue(byte[] rgb); // 0x000000018A72C1BC-0x000000018A72C2E8
		public override RSAParameters ExportParameters(bool includePrivateParameters); // 0x000000018A72C2E8-0x000000018A72C6AC
		public override void ImportParameters(RSAParameters parameters); // 0x000000018A72CA94-0x000000018A72D0B8
		protected override void Dispose(bool disposing); // 0x000000018A72BF4C-0x000000018A72C1BC
		public override string ToXmlString(bool includePrivateParameters); // 0x000000018A72D0B8-0x000000018A72D650
		private byte[] GetPaddedValue(BigInteger value, int length); // 0x000000018A72C9E8-0x000000018A72CA94
	}
}

namespace Mono.Security.Interface
{
	public enum AlertLevel : byte // TypeDefIndex: 60487
	{
		Warning = 1,
		Fatal = 2
	}

	public enum AlertDescription : byte // TypeDefIndex: 60488
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

	public class Alert // TypeDefIndex: 60489
	{
		// Fields
		private AlertLevel level; // 0x10
		private AlertDescription description; // 0x11
	
		// Properties
		public AlertLevel Level { get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
		public AlertDescription Description { get; } // 0x0000000184D88380-0x0000000184D88390 
	
		// Constructors
		public Alert(AlertDescription description); // 0x000000018A720A4C-0x000000018A720A58
	
		// Methods
		private void inferAlertLevel(); // 0x000000018A720A58-0x000000018A720AC4
		public override string ToString(); // 0x000000018A7209B8-0x000000018A720A4C
	}

	public class ValidationResult // TypeDefIndex: 60490
	{
		// Fields
		private bool trusted; // 0x10
		private bool user_denied; // 0x11
		private int error_code; // 0x14
		private MonoSslPolicyErrors? policy_errors; // 0x18
	
		// Properties
		public bool Trusted { get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
		public bool UserDenied { get; } // 0x0000000184D88380-0x0000000184D88390 
	
		// Constructors
		public ValidationResult(bool trusted, bool user_denied, int error_code, MonoSslPolicyErrors? policy_errors); // 0x0000000184DA3C50-0x0000000184DA3C70
	}

	public interface ICertificateValidator // TypeDefIndex: 60491
	{
	}

	[CLSCompliant(false)]
	public enum CipherSuiteCode : ushort // TypeDefIndex: 60492
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

	public class MonoTlsConnectionInfo // TypeDefIndex: 60493
	{
		// Fields
		[CompilerGenerated]
		private CipherSuiteCode _CipherSuiteCode_k__BackingField; // 0x10
		[CompilerGenerated]
		private TlsProtocols _ProtocolVersion_k__BackingField; // 0x14
		[CompilerGenerated]
		private string _PeerDomainName_k__BackingField; // 0x18
	
		// Properties
		[CLSCompliant(false)]
		public CipherSuiteCode CipherSuiteCode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D96190-0x0000000184D961A0 0x0000000184D94F60-0x0000000184D94F70
		public TlsProtocols ProtocolVersion { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
		public string PeerDomainName { [CompilerGenerated] set; } // 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		public MonoTlsConnectionInfo(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override string ToString(); // 0x000000018A728F78-0x000000018A729010
	}

	[Flags]
	public enum MonoSslPolicyErrors // TypeDefIndex: 60494
	{
		None = 0,
		RemoteCertificateNotAvailable = 1,
		RemoteCertificateNameMismatch = 2,
		RemoteCertificateChainErrors = 4
	}

	public delegate bool MonoRemoteCertificateValidationCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, MonoSslPolicyErrors sslPolicyErrors); // TypeDefIndex: 60495; 0x00000001814D0D00-0x00000001814D0D20

	public delegate System.Security.Cryptography.X509Certificates.X509Certificate MonoLocalCertificateSelectionCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers); // TypeDefIndex: 60496; 0x00000001814D0D00-0x00000001814D0D20

	public abstract class MonoTlsProvider // TypeDefIndex: 60497
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
		internal MonoTlsProvider(); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class MonoTlsProviderFactory // TypeDefIndex: 60498
	{
		// Methods
		public static MonoTlsProvider GetProvider(); // 0x000000018A729010-0x000000018A72904C
	}

	public sealed class MonoTlsSettings // TypeDefIndex: 60499
	{
		// Fields
		[CompilerGenerated]
		private MonoRemoteCertificateValidationCallback _RemoteCertificateValidationCallback_k__BackingField; // 0x10
		[CompilerGenerated]
		private MonoLocalCertificateSelectionCallback _ClientCertificateSelectionCallback_k__BackingField; // 0x18
		[CompilerGenerated]
		private System.DateTime? _CertificateValidationTime_k__BackingField; // 0x20
		[CompilerGenerated]
		private System.Security.Cryptography.X509Certificates.X509CertificateCollection _TrustAnchors_k__BackingField; // 0x30
		[CompilerGenerated]
		private object _UserSettings_k__BackingField; // 0x38
		[CompilerGenerated]
		private string[] _CertificateSearchPaths_k__BackingField; // 0x40
		[CompilerGenerated]
		private bool _SendCloseNotify_k__BackingField; // 0x48
		[CompilerGenerated]
		private string[] _ClientCertificateIssuers_k__BackingField; // 0x50
		[CompilerGenerated]
		private bool _DisallowUnauthenticatedCertificateRequest_k__BackingField; // 0x58
		[CompilerGenerated]
		private TlsProtocols? _EnabledProtocols_k__BackingField; // 0x5C
		[CompilerGenerated]
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
		public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public bool? UseServicePointManagerCallback { get; set; } // 0x0000000184DA3C20-0x0000000184DA3C30 0x0000000184DA3C40-0x0000000184DA3C50
		public bool CallbackNeedsCertificateChain { get; } // 0x0000000184D91610-0x0000000184D91620 
		public System.DateTime? CertificateValidationTime { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8C200-0x0000000184D8C210 0x0000000184D8C210-0x0000000184D8C220
		public System.Security.Cryptography.X509Certificates.X509CertificateCollection TrustAnchors { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public object UserSettings { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		internal string[] CertificateSearchPaths { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		internal bool SendCloseNotify { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D867D0-0x0000000184D867E0 0x0000000184D86810-0x0000000184D86820
		public string[] ClientCertificateIssuers { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public bool DisallowUnauthenticatedCertificateRequest { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86F70-0x0000000184D86F80 0x0000000184D86F80-0x0000000184D86F90
		public TlsProtocols? EnabledProtocols { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA3C10-0x0000000184DA3C20 0x0000000184DA3C30-0x0000000184DA3C40
		[CLSCompliant(false)]
		public CipherSuiteCode[] EnabledCiphers { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
		public static MonoTlsSettings DefaultSettings { get; } // 0x000000018A7292E8-0x000000018A729364 
		[Obsolete("Do not use outside System.dll!")]
		public ICertificateValidator CertificateValidator { get; } // 0x0000000184D862A0-0x0000000184D862B0 
	
		// Constructors
		public MonoTlsSettings(); // 0x0000000184DA3C00-0x0000000184DA3C10
		private MonoTlsSettings(MonoTlsSettings other); // 0x000000018A729164-0x000000018A7292E8
	
		// Methods
		public static MonoTlsSettings CopyDefaultSettings(); // 0x000000018A729140-0x000000018A729164
		[Obsolete("Do not use outside System.dll!")]
		public MonoTlsSettings CloneWithValidator(ICertificateValidator validator); // 0x000000018A72904C-0x000000018A7290E0
		public MonoTlsSettings Clone(); // 0x000000018A7290E0-0x000000018A729140
	}

	public sealed class TlsException : Exception // TypeDefIndex: 60500
	{
		// Fields
		private Alert alert; // 0x90
	
		// Constructors
		public TlsException(Alert alert); // 0x000000018A72DC24-0x000000018A72DC9C
		public TlsException(Alert alert, string message); // 0x000000018A72DAB4-0x000000018A72DB24
		public TlsException(AlertDescription description); // 0x000000018A72DBAC-0x000000018A72DC24
		public TlsException(AlertDescription description, string message); // 0x000000018A72DB24-0x000000018A72DBAC
	}

	public enum TlsProtocolCode : short // TypeDefIndex: 60501
	{
		Tls10 = 769,
		Tls11 = 770,
		Tls12 = 771
	}

	[Flags]
	public enum TlsProtocols // TypeDefIndex: 60502
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
	[Obsolete("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)\' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
	public class ChallengeResponse : IDisposable // TypeDefIndex: 60478
	{
		// Fields
		private static byte[] magic; // 0x00
		private static byte[] nullEncMagic; // 0x08
		private bool _disposed; // 0x10
		private byte[] _challenge; // 0x18
		private byte[] _lmpwd; // 0x20
		private byte[] _ntpwd; // 0x28
	
		// Properties
		public string Password { set; } // 0x000000018A70F8E8-0x000000018A70FC10
		public byte[] Challenge { set; } // 0x000000018A70F7C8-0x000000018A70F8E8
		public byte[] LM { get; } // 0x000000018A70F6E0-0x000000018A70F754 
		public byte[] NT { get; } // 0x000000018A70F754-0x000000018A70F7C8 
	
		// Constructors
		public ChallengeResponse(); // 0x000000018A70F674-0x000000018A70F6E0
		public ChallengeResponse(string password, byte[] challenge); // 0x000000018A70F628-0x000000018A70F674
		static ChallengeResponse(); // 0x000000018A70F544-0x000000018A70F628
	
		// Methods
		~ChallengeResponse(); // 0x000000018A70F01C-0x000000018A70F094
		public void Dispose(); // 0x000000018A70EF58-0x000000018A70EFA8
		private void Dispose(bool disposing); // 0x000000018A70EFA8-0x000000018A70F01C
		private byte[] GetResponse(byte[] pwd); // 0x000000018A70F094-0x000000018A70F240
		private byte[] PrepareDESKey(byte[] key56bits, int position); // 0x000000018A70F364-0x000000018A70F544
		private byte[] PasswordToKey(string password, int position); // 0x000000018A70F240-0x000000018A70F364
	}

	public static class ChallengeResponse2 // TypeDefIndex: 60479
	{
		// Fields
		private static byte[] magic; // 0x00
		private static byte[] nullEncMagic; // 0x08
	
		// Constructors
		static ChallengeResponse2(); // 0x000000018A70EE74-0x000000018A70EF58
	
		// Methods
		private static byte[] Compute_LM(string password, byte[] challenge); // 0x000000018A70DE48-0x000000018A70E084
		private static byte[] Compute_NTLM_Password(string password); // 0x000000018A70E084-0x000000018A70E184
		private static byte[] Compute_NTLM(string password, byte[] challenge); // 0x000000018A70E184-0x000000018A70E1E0
		private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm); // 0x000000018A70E1E0-0x000000018A70E3B4
		private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain); // 0x000000018A70E3B4-0x000000018A70E7DC
		public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm); // 0x000000018A70E7DC-0x000000018A70E9A4
		private static byte[] GetResponse(byte[] challenge, byte[] pwd); // 0x000000018A70E9A4-0x000000018A70EB5C
		private static byte[] PrepareDESKey(byte[] key56bits, int position); // 0x000000018A70EC94-0x000000018A70EE74
		private static byte[] PasswordToKey(string password, int position); // 0x000000018A70EB5C-0x000000018A70EC94
	}

	public abstract class MessageBase // TypeDefIndex: 60480
	{
		// Fields
		private static byte[] header; // 0x00
		private int _type; // 0x10
		private NtlmFlags _flags; // 0x14
	
		// Properties
		public NtlmFlags Flags { get; set; } // 0x0000000184D882A0-0x0000000184D882B0 0x0000000184D8F540-0x0000000184D8F550
		public int Type { get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
	
		// Constructors
		protected MessageBase(int messageType); // 0x00000001814F51F0-0x00000001814F5220
		static MessageBase(); // 0x000000018A7285D8-0x000000018A728664
	
		// Methods
		protected byte[] PrepareMessage(int messageSize); // 0x000000018A7284FC-0x000000018A7285D8
		protected virtual void Decode(byte[] message); // 0x000000018A728340-0x000000018A7284FC
		protected bool CheckHeader(byte[] message); // 0x000000018A72825C-0x000000018A728340
		public abstract byte[] GetBytes();
	}

	public enum NtlmAuthLevel // TypeDefIndex: 60481
	{
		LM_and_NTLM = 0,
		LM_and_NTLM_and_try_NTLMv2_Session = 1,
		NTLM_only = 2,
		NTLMv2_only = 3
	}

	[Flags]
	public enum NtlmFlags // TypeDefIndex: 60482
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

	public static class NtlmSettings // TypeDefIndex: 60483
	{
		// Fields
		private static NtlmAuthLevel defaultAuthLevel; // 0x00
	
		// Properties
		public static NtlmAuthLevel DefaultAuthLevel { get; } // 0x000000018A7293A0-0x000000018A7293F0 
	
		// Constructors
		static NtlmSettings(); // 0x000000018A729364-0x000000018A7293A0
	}

	public class Type1Message : MessageBase // TypeDefIndex: 60484
	{
		// Fields
		private string _host; // 0x18
		private string _domain; // 0x20
	
		// Properties
		public string Domain { set; } // 0x000000018A72E094-0x000000018A72E108
		public string Host { set; } // 0x000000018A72E108-0x000000018A72E17C
	
		// Constructors
		public Type1Message(); // 0x000000018A72E028-0x000000018A72E094
	
		// Methods
		protected override void Decode(byte[] message); // 0x000000018A72DC9C-0x000000018A72DD7C
		public override byte[] GetBytes(); // 0x000000018A72DD7C-0x000000018A72E028
	}

	public class Type2Message : MessageBase // TypeDefIndex: 60485
	{
		// Fields
		private byte[] _nonce; // 0x18
		private string _targetName; // 0x20
		private byte[] _targetInfo; // 0x28
	
		// Properties
		public byte[] Nonce { get; } // 0x000000018A72E4B4-0x000000018A72E504 
		public string TargetName { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public byte[] TargetInfo { get; } // 0x000000018A72E504-0x000000018A72E554 
	
		// Constructors
		public Type2Message(byte[] message); // 0x000000018A72E430-0x000000018A72E4B4
	
		// Methods
		~Type2Message(); // 0x000000018A72E2E8-0x000000018A72E370
		protected override void Decode(byte[] message); // 0x000000018A72E17C-0x000000018A72E2E8
		public override byte[] GetBytes(); // 0x000000018A72E370-0x000000018A72E430
	}

	public class Type3Message : MessageBase // TypeDefIndex: 60486
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
		public string Domain { set; } // 0x000000018A72F138-0x000000018A72F230
		public string Password { set; } // 0x00000001842B4AE0-0x00000001842B4AF0
		public string Username { set; } // 0x00000001846A91B0-0x00000001846A91C0
	
		// Constructors
		public Type3Message(Type2Message type2); // 0x000000018A72EF9C-0x000000018A72F138
	
		// Methods
		~Type3Message(); // 0x000000018A72E844-0x000000018A72E910
		protected override void Decode(byte[] message); // 0x000000018A72E5B0-0x000000018A72E7C8
		private string DecodeString(byte[] buffer, int offset, int len); // 0x000000018A72E554-0x000000018A72E5B0
		private byte[] EncodeString(string text); // 0x000000018A72E7C8-0x000000018A72E844
		public override byte[] GetBytes(); // 0x000000018A72E910-0x000000018A72EF9C
	}
}

namespace Mono.Security.X509
{
	internal class SafeBag // TypeDefIndex: 60442
	{
		// Fields
		private string _bagOID; // 0x10
		private ASN1 _asn1; // 0x18
	
		// Properties
		public string BagOID { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public ASN1 ASN1 { get; } // 0x000000018385B100-0x000000018385B110 
	
		// Constructors
		public SafeBag(string bagOID, ASN1 asn1); // 0x00000001832AF420-0x00000001832AF450
	}

	public class PKCS12 : ICloneable // TypeDefIndex: 60444
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
		public string Password { set; } // 0x000000018A717F34-0x000000018A718090
		public int IterationCount { get; set; } // 0x0000000184D86730-0x0000000184D86740 0x0000000184D86760-0x0000000184D86770
		public ArrayList Keys { get; } // 0x000000018A7178FC-0x000000018A717EB0 
		public Mono.Security.X509.X509CertificateCollection Certificates { get; } // 0x000000018A71752C-0x000000018A7178FC 
		internal RandomNumberGenerator RNG { get; } // 0x000000018A717F00-0x000000018A717F34 
		public static int MaximumPasswordLength { get; } // 0x000000018A717EB0-0x000000018A717F00 
	
		// Nested types
		public class DeriveBytes // TypeDefIndex: 60443
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
			public string HashName { set; } // 0x00000001853908C0-0x00000001853908D0
			public int IterationCount { set; } // 0x00000001811EF9B0-0x00000001811EF9C0
			public byte[] Password { set; } // 0x000000018A71075C-0x000000018A7107E8
			public byte[] Salt { set; } // 0x000000018A7107E8-0x000000018A710864
	
			// Constructors
			public DeriveBytes(); // 0x00000001841E1670-0x00000001841E1680
			static DeriveBytes(); // 0x000000018A710618-0x000000018A71075C
	
			// Methods
			private void Adjust(byte[] a, int aOff, byte[] b); // 0x000000018A71002C-0x000000018A7100F0
			private byte[] Derive(byte[] diversifier, int n); // 0x000000018A710218-0x000000018A710618
			public byte[] DeriveKey(int size); // 0x000000018A710154-0x000000018A7101B4
			public byte[] DeriveIV(int size); // 0x000000018A7100F0-0x000000018A710154
			public byte[] DeriveMAC(int size); // 0x000000018A7101B4-0x000000018A710218
		}
	
		// Constructors
		public PKCS12(); // 0x000000018A717420-0x000000018A71752C
		public PKCS12(byte[] data); // 0x000000018A7173E4-0x000000018A717420
		public PKCS12(byte[] data, string password); // 0x000000018A717398-0x000000018A7173E4
		static PKCS12(); // 0x000000018A71735C-0x000000018A717398
	
		// Methods
		private void Decode(byte[] data); // 0x000000018A71240C-0x000000018A712CFC
		~PKCS12(); // 0x000000018A7132F4-0x000000018A7133C8
		private bool Compare(byte[] expected, byte[] actual); // 0x000000018A7123AC-0x000000018A71240C
		private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount); // 0x000000018A7155AC-0x000000018A715B00
		public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData); // 0x000000018A712DD0-0x000000018A712EB4
		public byte[] Decrypt(PKCS7.EncryptedData ed); // 0x000000018A712CFC-0x000000018A712DD0
		public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data); // 0x000000018A712EB4-0x000000018A712FD4
		private DSAParameters GetExistingParameters(out bool found); // 0x000000018A715380-0x000000018A7155AC
		private void AddPrivateKey(PKCS8.PrivateKeyInfo pki); // 0x000000018A7114EC-0x000000018A711828
		private void ReadSafeBag(ASN1 safeBag); // 0x000000018A716710-0x000000018A716F74
		private ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes); // 0x000000018A715C14-0x000000018A716710
		private ASN1 CertificateSafeBag(Mono.Security.X509.X509Certificate x509, IDictionary attributes); // 0x000000018A711828-0x000000018A712248
		private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data); // 0x000000018A715B00-0x000000018A715C14
		public byte[] GetBytes(); // 0x000000018A7133C8-0x000000018A715380
		private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid); // 0x000000018A712FD4-0x000000018A7132F4
		public void AddCertificate(Mono.Security.X509.X509Certificate cert); // 0x000000018A710F20-0x000000018A710F2C
		public void AddCertificate(Mono.Security.X509.X509Certificate cert, IDictionary attributes); // 0x000000018A710F2C-0x000000018A711164
		public void RemoveCertificate(Mono.Security.X509.X509Certificate cert); // 0x000000018A717350-0x000000018A71735C
		public void RemoveCertificate(Mono.Security.X509.X509Certificate cert, IDictionary attrs); // 0x000000018A716F74-0x000000018A717350
		private bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2); // 0x000000018A712324-0x000000018A7123AC
		public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes); // 0x000000018A711164-0x000000018A7114EC
		public object Clone(); // 0x000000018A712248-0x000000018A712324
	}

	public sealed class X501 // TypeDefIndex: 60445
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
		static X501(); // 0x000000018A71AB18-0x000000018A71B0DC
	
		// Methods
		public static string ToString(ASN1 seq); // 0x000000018A71AA18-0x000000018A71AB18
		public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes); // 0x000000018A71A8AC-0x000000018A71AA18
		private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes); // 0x000000018A718ED8-0x000000018A719624
		private static X520.AttributeTypeAndValue GetAttributeFromOid(string attributeType); // 0x000000018A7197A4-0x000000018A719F74
		private static bool IsOid(string oid); // 0x000000018A71A014-0x000000018A71A0A0
		private static X520.AttributeTypeAndValue ReadAttribute(string value, ref int pos); // 0x000000018A71A0A0-0x000000018A71A214
		private static bool IsHex(char c); // 0x000000018A719F74-0x000000018A71A014
		private static string ReadHex(string value, ref int pos); // 0x000000018A71A39C-0x000000018A71A520
		private static int ReadEscaped(StringBuilder sb, string value, int pos); // 0x000000018A71A214-0x000000018A71A39C
		private static int ReadQuoted(StringBuilder sb, string value, int pos); // 0x000000018A71A520-0x000000018A71A658
		private static string ReadValue(string value, ref int pos); // 0x000000018A71A658-0x000000018A71A8AC
		public static ASN1 FromString(string rdn); // 0x000000018A719624-0x000000018A7197A4
	}

	[DefaultMember("Item")]
	public class X509Crl // TypeDefIndex: 60447
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
		public Mono.Security.X509.X509ExtensionCollection Extensions { get; } // 0x0000000184D86200-0x0000000184D86210 
		public byte[] Hash { get; } // 0x000000018A71ED50-0x000000018A71EEF8 
		public string IssuerName { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public System.DateTime NextUpdate { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Nested types
		public class X509CrlEntry // TypeDefIndex: 60446
		{
			// Fields
			private byte[] sn; // 0x10
			private System.DateTime revocationDate; // 0x18
			private Mono.Security.X509.X509ExtensionCollection extensions; // 0x20
	
			// Properties
			public byte[] SerialNumber { get; } // 0x000000018A71DF6C-0x000000018A71DFBC 
			public System.DateTime RevocationDate { get; } // 0x000000018385B100-0x000000018385B110 
			public Mono.Security.X509.X509ExtensionCollection Extensions { get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
			// Constructors
			internal X509CrlEntry(ASN1 entry); // 0x000000018A71DE74-0x000000018A71DF6C
		}
	
		// Constructors
		public X509Crl(byte[] crl); // 0x000000018A71EC7C-0x000000018A71ED50
	
		// Methods
		private void Parse(byte[] crl); // 0x000000018A71E15C-0x000000018A71E7A0
		private bool Compare(byte[] array1, byte[] array2); // 0x000000018A71B224-0x000000018A71B27C
		public X509CrlEntry GetCrlEntry(Mono.Security.X509.X509Certificate x509); // 0x000000018A71DFBC-0x000000018A71E040
		public X509CrlEntry GetCrlEntry(byte[] serialNumber); // 0x000000018A71E040-0x000000018A71E15C
		internal bool VerifySignature(DSA dsa); // 0x000000018A71E9D8-0x000000018A71EC7C
		internal bool VerifySignature(RSA rsa); // 0x000000018A71E918-0x000000018A71E9D8
		public bool VerifySignature(AsymmetricAlgorithm aa); // 0x000000018A71E7A0-0x000000018A71E918
	}

	public class X509Certificate : ISerializable // TypeDefIndex: 60448
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
		public DSA DSA { get; set; } // 0x000000018A71C6F8-0x000000018A71CA3C 0x000000018A71D45C-0x000000018A71D4A0
		public Mono.Security.X509.X509ExtensionCollection Extensions { get; } // 0x0000000184D85EF0-0x0000000184D85F00 
		public byte[] Hash { get; } // 0x000000018A71CA3C-0x000000018A71CC58 
		public virtual string IssuerName { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public virtual string KeyAlgorithm { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public virtual byte[] KeyAlgorithmParameters { get; set; } // 0x000000018A71CD90-0x000000018A71CDE4 0x00000001835A41A0-0x00000001835A41B0
		public virtual byte[] PublicKey { get; } // 0x000000018A71CDE4-0x000000018A71CE38 
		public virtual RSA RSA { get; set; } // 0x000000018A71CE38-0x000000018A71D018 0x000000018A71D4A0-0x000000018A71D4E0
		public virtual byte[] RawData { get; } // 0x000000018A71D018-0x000000018A71D06C 
		public virtual byte[] SerialNumber { get; } // 0x000000018A71D06C-0x000000018A71D0C4 
		public virtual byte[] Signature { get; } // 0x000000018A71D0C4-0x000000018A71D45C 
		public virtual string SubjectName { get; } // 0x0000000182E56440-0x0000000182E56460 
		public virtual System.DateTime ValidFrom { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public virtual System.DateTime ValidUntil { get; } // 0x0000000184D86240-0x0000000184D86250 
		public int Version { get; } // 0x0000000184D862D0-0x0000000184D862E0 
		public bool IsCurrent { get; } // 0x000000018A71CC58-0x000000018A71CCA4 
		public bool IsSelfSigned { get; } // 0x000000018A71CCA4-0x000000018A71CD90 
	
		// Constructors
		public X509Certificate(byte[] data); // 0x000000018A71C57C-0x000000018A71C6F8
		static X509Certificate(); // 0x000000018A71C520-0x000000018A71C57C
	
		// Methods
		private void Parse(byte[] data); // 0x000000018A71B884-0x000000018A71C178
		private byte[] GetUnsignedBigInteger(byte[] integer); // 0x000000018A71B6E4-0x000000018A71B77C
		public bool WasCurrent(System.DateTime instant); // 0x000000018A71C49C-0x000000018A71C520
		internal bool VerifySignature(DSA dsa); // 0x000000018A71C3E8-0x000000018A71C49C
		internal bool VerifySignature(RSA rsa); // 0x000000018A71C2F0-0x000000018A71C3E8
		public bool VerifySignature(AsymmetricAlgorithm aa); // 0x000000018A71C178-0x000000018A71C2F0
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context); // 0x000000018A71B68C-0x000000018A71B6E4
		private static byte[] PEM(string type, byte[] data); // 0x000000018A71B77C-0x000000018A71B884
	}

	[Serializable]
	public class X509CertificateCollection : CollectionBase, IEnumerable // TypeDefIndex: 60450
	{
		// Properties
		public Mono.Security.X509.X509Certificate this[int index] { get => default; } // 0x000000018A71B43C-0x000000018A71B49C 
	
		// Nested types
		public class X509CertificateEnumerator : IEnumerator // TypeDefIndex: 60449
		{
			// Fields
			private IEnumerator enumerator; // 0x10
	
			// Properties
			public Mono.Security.X509.X509Certificate Current { get; } // 0x000000018A71B624-0x000000018A71B68C 
			object IEnumerator.Current { get; } // 0x000000018A71B578-0x000000018A71B5C4 
	
			// Constructors
			public X509CertificateEnumerator(X509CertificateCollection mappings); // 0x000000018A71B5C4-0x000000018A71B624
	
			// Methods
			bool IEnumerator.MoveNext(); // 0x000000018A71B4E4-0x000000018A71B52C
			void IEnumerator.Reset(); // 0x000000018A71B52C-0x000000018A71B578
			public bool MoveNext(); // 0x000000018A71B49C-0x000000018A71B4E4
		}
	
		// Constructors
		public X509CertificateCollection(); // 0x000000018A71B434-0x000000018A71B43C
	
		// Methods
		public int Add(Mono.Security.X509.X509Certificate value); // 0x000000018A71B1A8-0x000000018A71B224
		public void AddRange(X509CertificateCollection value); // 0x000000018A71B0DC-0x000000018A71B1A8
		public bool Contains(Mono.Security.X509.X509Certificate value); // 0x000000018A71B27C-0x000000018A71B294
		public new X509CertificateEnumerator GetEnumerator(); // 0x000000018A71B294-0x000000018A71B2F4
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018A71B410-0x000000018A71B434
		public override int GetHashCode(); // 0x0000000188479504-0x0000000188479528
		public int IndexOf(Mono.Security.X509.X509Certificate value); // 0x000000018A71B2F4-0x000000018A71B410
		private bool Compare(byte[] array1, byte[] array2); // 0x000000018A71B224-0x000000018A71B27C
	}

	public class X509Chain // TypeDefIndex: 60451
	{
		// Fields
		private Mono.Security.X509.X509CertificateCollection roots; // 0x10
		private Mono.Security.X509.X509CertificateCollection certs; // 0x18
		private Mono.Security.X509.X509Certificate _root; // 0x20
		private Mono.Security.X509.X509CertificateCollection _chain; // 0x28
		private Mono.Security.X509.X509ChainStatusFlags _status; // 0x30
	
		// Properties
		public Mono.Security.X509.X509CertificateCollection TrustAnchors { get; } // 0x000000018A71DDE4-0x000000018A71DE74 
	
		// Constructors
		public X509Chain(); // 0x000000018A71DD80-0x000000018A71DDE4
	
		// Methods
		public void LoadCertificates(Mono.Security.X509.X509CertificateCollection collection); // 0x000000018A71DD14-0x000000018A71DD34
		public bool Build(Mono.Security.X509.X509Certificate leaf); // 0x000000018A71D4E0-0x000000018A71D848
		public void Reset(); // 0x000000018A71DD34-0x000000018A71DD80
		private bool IsValid(Mono.Security.X509.X509Certificate cert); // 0x000000018A71DCA4-0x000000018A71DD14
		private Mono.Security.X509.X509Certificate FindCertificateParent(Mono.Security.X509.X509Certificate child); // 0x000000018A71D848-0x000000018A71D990
		private Mono.Security.X509.X509Certificate FindCertificateRoot(Mono.Security.X509.X509Certificate potentialRoot); // 0x000000018A71D990-0x000000018A71DB44
		private bool IsTrusted(Mono.Security.X509.X509Certificate potentialTrusted); // 0x000000018A71DC74-0x000000018A71DCA4
		private bool IsParent(Mono.Security.X509.X509Certificate child, Mono.Security.X509.X509Certificate parent); // 0x000000018A71DB44-0x000000018A71DC74
	}

	[Serializable]
	[Flags]
	public enum X509ChainStatusFlags // TypeDefIndex: 60452
	{
		NoError = 0,
		NotTimeValid = 1,
		NotTimeNested = 2,
		NotSignatureValid = 8,
		UntrustedRoot = 32,
		InvalidBasicConstraints = 1024,
		PartialChain = 65536
	}

	public class X509Extension // TypeDefIndex: 60453
	{
		// Fields
		protected string extnOid; // 0x10
		protected bool extnCritical; // 0x18
		protected ASN1 extnValue; // 0x20
	
		// Properties
		public string Oid { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public bool Critical { get; } // 0x0000000184D86340-0x0000000184D86350 
		public ASN1 Value { get; } // 0x000000018A71F9E4-0x000000018A71FA14 
	
		// Constructors
		public X509Extension(ASN1 asn1); // 0x000000018A71F5B0-0x000000018A71F890
		public X509Extension(X509Extension extension); // 0x000000018A71F890-0x000000018A71F9E4
	
		// Methods
		protected virtual void Decode(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void Encode(); // 0x00000001841E1670-0x00000001841E1680
		public override bool Equals(object obj); // 0x000000018A71F1C0-0x000000018A71F2CC
		public override int GetHashCode(); // 0x0000000188479504-0x0000000188479528
		private void WriteLine(StringBuilder sb, int n, int pos); // 0x000000018A71F3CC-0x000000018A71F5B0
		public override string ToString(); // 0x000000018A71F2CC-0x000000018A71F3CC
	}

	public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 60454
	{
		// Fields
		private bool readOnly; // 0x18
	
		// Properties
		public Mono.Security.X509.X509Extension this[string oid] { get => default; } // 0x000000018A71F144-0x000000018A71F1C0 
	
		// Constructors
		public X509ExtensionCollection(); // 0x000000018A71B434-0x000000018A71B43C
		public X509ExtensionCollection(ASN1 asn1); // 0x000000018A71F01C-0x000000018A71F144
	
		// Methods
		public int IndexOf(string oid); // 0x000000018A71EEF8-0x000000018A71F01C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018A71B410-0x000000018A71B434
	}

	public class X509Store // TypeDefIndex: 60455
	{
		// Fields
		private string _storePath; // 0x10
		private Mono.Security.X509.X509CertificateCollection _certificates; // 0x18
		private ArrayList _crls; // 0x20
		private bool _crl; // 0x28
		private bool _newFormat; // 0x29
	
		// Properties
		public Mono.Security.X509.X509CertificateCollection Certificates { get; } // 0x000000018A720704-0x000000018A720740 
		public ArrayList Crls { get; } // 0x000000018A720740-0x000000018A7207D4 
	
		// Constructors
		internal X509Store(string path, bool crl, bool newFormat); // 0x000000018A7206DC-0x000000018A720704
	
		// Methods
		private byte[] Load(string filename); // 0x000000018A7205A0-0x000000018A7206DC
		private Mono.Security.X509.X509Certificate LoadCertificate(string filename); // 0x000000018A7204B8-0x000000018A72052C
		private X509Crl LoadCrl(string filename); // 0x000000018A72052C-0x000000018A7205A0
		private bool CheckStore(string path, bool throwException); // 0x000000018A720400-0x000000018A7204B8
		private Mono.Security.X509.X509CertificateCollection BuildCertificatesCollection(string storeName); // 0x000000018A7200A4-0x000000018A72025C
		private ArrayList BuildCrlsCollection(string storeName); // 0x000000018A72025C-0x000000018A720400
	}

	public sealed class X509StoreManager // TypeDefIndex: 60456
	{
		// Fields
		private static string _userPath; // 0x00
		private static string _localMachinePath; // 0x08
		private static string _newUserPath; // 0x10
		private static string _newLocalMachinePath; // 0x18
		private static X509Stores _userStore; // 0x20
		private static X509Stores _machineStore; // 0x28
	
		// Properties
		internal static string CurrentUserPath { get; } // 0x000000018A71FA14-0x000000018A71FB1C 
		internal static string LocalMachinePath { get; } // 0x000000018A71FBE0-0x000000018A71FCF8 
		internal static string NewCurrentUserPath { get; } // 0x000000018A71FDBC-0x000000018A71FED4 
		internal static string NewLocalMachinePath { get; } // 0x000000018A71FED4-0x000000018A71FFEC 
		public static X509Stores CurrentUser { get; } // 0x000000018A71FB1C-0x000000018A71FBE0 
		public static X509Stores LocalMachine { get; } // 0x000000018A71FCF8-0x000000018A71FDBC 
		public static Mono.Security.X509.X509CertificateCollection TrustedRootCertificates { get; } // 0x000000018A71FFEC-0x000000018A7200A4 
	}

	public class X509Stores // TypeDefIndex: 60457
	{
		// Fields
		private string _storePath; // 0x10
		private bool _newFormat; // 0x18
		private Mono.Security.X509.X509Store _trusted; // 0x20
	
		// Properties
		public Mono.Security.X509.X509Store TrustedRoot { get; } // 0x000000018A7208E4-0x000000018A7209B8 
	
		// Constructors
		internal X509Stores(string path, bool newFormat); // 0x00000001832B1EA0-0x00000001832B1ED0
	
		// Methods
		public Mono.Security.X509.X509Store Open(string storeName, bool create); // 0x000000018A7207D4-0x000000018A7208E4
	}

	public class X520 // TypeDefIndex: 60475
	{
		// Nested types
		public abstract class AttributeTypeAndValue // TypeDefIndex: 60458
		{
			// Fields
			private string oid; // 0x10
			private string attrValue; // 0x18
			private int upperBound; // 0x20
			private byte encoding; // 0x24
	
			// Properties
			public string Value { set; } // 0x000000018A70D120-0x000000018A70D1E8
	
			// Constructors
			protected AttributeTypeAndValue(string oid, int upperBound); // 0x000000018A70D0D4-0x000000018A70D0FC
			protected AttributeTypeAndValue(string oid, int upperBound, byte encoding); // 0x000000018A70D0FC-0x000000018A70D120
	
			// Methods
			internal ASN1 GetASN1(byte encoding); // 0x000000018A70CEFC-0x000000018A70D080
			internal ASN1 GetASN1(); // 0x000000018A70CEF0-0x000000018A70CEFC
			private byte SelectBestEncoding(); // 0x000000018A70D080-0x000000018A70D0D4
		}
	
		public class CommonName : AttributeTypeAndValue // TypeDefIndex: 60459
		{
			// Constructors
			public CommonName(); // 0x000000018A70FC10-0x000000018A70FC54
		}
	
		public class SerialNumber : AttributeTypeAndValue // TypeDefIndex: 60460
		{
			// Constructors
			public SerialNumber(); // 0x000000018A718090-0x000000018A7180DC
		}
	
		public class LocalityName : AttributeTypeAndValue // TypeDefIndex: 60461
		{
			// Constructors
			public LocalityName(); // 0x000000018A710E44-0x000000018A710E88
		}
	
		public class StateOrProvinceName : AttributeTypeAndValue // TypeDefIndex: 60462
		{
			// Constructors
			public StateOrProvinceName(); // 0x000000018A718DC8-0x000000018A718E0C
		}
	
		public class OrganizationName : AttributeTypeAndValue // TypeDefIndex: 60463
		{
			// Constructors
			public OrganizationName(); // 0x000000018A710E98-0x000000018A710EDC
		}
	
		public class OrganizationalUnitName : AttributeTypeAndValue // TypeDefIndex: 60464
		{
			// Constructors
			public OrganizationalUnitName(); // 0x000000018A710EDC-0x000000018A710F20
		}
	
		public class EmailAddress : AttributeTypeAndValue // TypeDefIndex: 60465
		{
			// Constructors
			public EmailAddress(); // 0x000000018A7108FC-0x000000018A710948
		}
	
		public class DomainComponent : AttributeTypeAndValue // TypeDefIndex: 60466
		{
			// Constructors
			public DomainComponent(); // 0x000000018A7108B0-0x000000018A7108FC
		}
	
		public class UserId : AttributeTypeAndValue // TypeDefIndex: 60467
		{
			// Constructors
			public UserId(); // 0x000000018A718E94-0x000000018A718ED8
		}
	
		public class Oid : AttributeTypeAndValue // TypeDefIndex: 60468
		{
			// Constructors
			public Oid(string oid); // 0x000000018A710E88-0x000000018A710E98
		}
	
		public class Title : AttributeTypeAndValue // TypeDefIndex: 60469
		{
			// Constructors
			public Title(); // 0x000000018A718E50-0x000000018A718E94
		}
	
		public class CountryName : AttributeTypeAndValue // TypeDefIndex: 60470
		{
			// Constructors
			public CountryName(); // 0x000000018A70FFE0-0x000000018A71002C
		}
	
		public class DnQualifier : AttributeTypeAndValue // TypeDefIndex: 60471
		{
			// Constructors
			public DnQualifier(); // 0x000000018A710864-0x000000018A7108B0
		}
	
		public class Surname : AttributeTypeAndValue // TypeDefIndex: 60472
		{
			// Constructors
			public Surname(); // 0x000000018A718E0C-0x000000018A718E50
		}
	
		public class GivenName : AttributeTypeAndValue // TypeDefIndex: 60473
		{
			// Constructors
			public GivenName(); // 0x000000018A710DBC-0x000000018A710E00
		}
	
		public class Initial : AttributeTypeAndValue // TypeDefIndex: 60474
		{
			// Constructors
			public Initial(); // 0x000000018A710E00-0x000000018A710E44
		}
	}
}

namespace Mono.Security.X509.Extensions
{
	public class AuthorityKeyIdentifierExtension : Mono.Security.X509.X509Extension // TypeDefIndex: 60476
	{
		// Fields
		private byte[] aki; // 0x28
	
		// Properties
		public byte[] Identifier { get; } // 0x000000018A70D5A0-0x000000018A70D5F4 
	
		// Constructors
		public AuthorityKeyIdentifierExtension(Mono.Security.X509.X509Extension extension); // 0x000000018A70D598-0x000000018A70D5A0
	
		// Methods
		protected override void Decode(); // 0x000000018A70D1E8-0x000000018A70D304
		protected override void Encode(); // 0x000000018A70D304-0x000000018A70D448
		public override string ToString(); // 0x000000018A70D448-0x000000018A70D598
	}

	public class BasicConstraintsExtension : Mono.Security.X509.X509Extension // TypeDefIndex: 60477
	{
		// Fields
		private bool cA; // 0x28
		private int pathLenConstraint; // 0x2C
	
		// Properties
		public bool CertificateAuthority { get; } // 0x00000001811F33C0-0x00000001811F33D0 
	
		// Constructors
		public BasicConstraintsExtension(Mono.Security.X509.X509Extension extension); // 0x000000018A70D598-0x000000018A70D5A0
	
		// Methods
		protected override void Decode(); // 0x000000018A70D5F4-0x000000018A70D73C
		protected override void Encode(); // 0x000000018A70D73C-0x000000018A70D884
		public override string ToString(); // 0x000000018A70D884-0x000000018A70D9DC
	}
}
