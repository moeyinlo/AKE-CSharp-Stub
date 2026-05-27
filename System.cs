/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Microsoft.Win32.SafeHandles;
using Mono.Security.Interface;

// Image 13: System.dll - Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 45318-46226
[assembly: AssemblyCompany("Mono development team")]
[assembly: AssemblyCopyright("(c) Various Mono authors")]
[assembly: AssemblyDefaultAlias("System.dll")]
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyDescription("System.dll")]
[assembly: AssemblyFileVersion("4.0.30319.17020")]
[assembly: AssemblyInformationalVersion("4.0.30319.17020")]
[assembly: AssemblyKeyFile("../silverlight.pub")]
[assembly: AssemblyProduct("Mono Common Language Infrastructure")]
[assembly: AssemblyTitle("System.dll")]
[assembly: CLSCompliant(true)]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Mono.Btls.Interface, PublicKey=002400000480000094000000060200000024000052534131000400000100010079159977d2d03a8e6bea7a2e74e8d1afcc93e8851974952bb480a12c9134474d04062447c37e0e68c080536fcf3c3fbe2ff9c979ce998475e506e8ce82dd5b0f350dc10e93bf2eeecf874b24770c5081dbea7447fddafa277b22de47d6ffea449674a4f9fccf84d15069089380284dbdd35f46cdff12a1bd78e4ef0065d016df")]
[assembly: InternalsVisibleTo("System.Net.Http, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly: InternalsVisibleTo("System.Data, PublicKey=00000000000000000400000000000000")]
[assembly: InternalsVisibleTo("System.ComponentModel.DataAnnotations, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly: InternalsVisibleTo("System.Net.Http.WebRequest, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly: InternalsVisibleTo("Mono.Security, PublicKey=002400000480000094000000060200000024000052534131000400000100010079159977d2d03a8e6bea7a2e74e8d1afcc93e8851974952bb480a12c9134474d04062447c37e0e68c080536fcf3c3fbe2ff9c979ce998475e506e8ce82dd5b0f350dc10e93bf2eeecf874b24770c5081dbea7447fddafa277b22de47d6ffea449674a4f9fccf84d15069089380284dbdd35f46cdff12a1bd78e4ef0065d016df")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SatelliteContractVersion("4.0.0.0")]

namespace Internal.Cryptography
{
	internal static class OidLookup // TypeDefIndex: 45487
	{
		// Fields
		private static readonly ConcurrentDictionary<string, string> s_lateBoundOidToFriendlyName; // 0x00
		private static readonly ConcurrentDictionary<string, string> s_lateBoundFriendlyNameToOid; // 0x08
		private static readonly Dictionary<string, string> s_friendlyNameToOid; // 0x10
		private static readonly Dictionary<string, string> s_oidToFriendlyName; // 0x18
		private static readonly Dictionary<string, string> s_compatOids; // 0x20
	
		// Constructors
		static OidLookup() {} // 0x0000000189A2B3D0-0x0000000189A2CD90
	
		// Methods
		public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) => default; // 0x0000000189A2B00C-0x0000000189A2B208
		public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) => default; // 0x0000000189A2B208-0x0000000189A2B3D0
		private static bool ShouldUseCache(OidGroup oidGroup) => default; // 0x000000018232EB60-0x000000018232EB70
		private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) => default; // 0x0000000189A2ACDC-0x0000000189A2B00C
		private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) => default; // 0x0000000189A2A9AC-0x0000000189A2ACDC
	}
}

namespace Internal.Cryptography.Pal
{
	internal enum GeneralNameType // TypeDefIndex: 45488
	{
		OtherName = 0,
		Rfc822Name = 1,
		Email = 1,
		DnsName = 2,
		X400Address = 3,
		DirectoryName = 4,
		EdiPartyName = 5,
		UniformResourceIdentifier = 6,
		IPAddress = 7,
		RegisteredId = 8
	}

	internal struct CertificateData // TypeDefIndex: 45491
	{
		// Fields
		internal byte[] RawData; // 0x00
		internal byte[] SubjectPublicKeyInfo; // 0x08
		internal int Version; // 0x10
		internal byte[] SerialNumber; // 0x18
		internal AlgorithmIdentifier TbsSignature; // 0x20
		internal X500DistinguishedName Issuer; // 0x30
		internal System.DateTime NotBefore; // 0x38
		internal System.DateTime NotAfter; // 0x40
		internal X500DistinguishedName Subject; // 0x48
		internal AlgorithmIdentifier PublicKeyAlgorithm; // 0x50
		internal byte[] PublicKey; // 0x60
		internal byte[] IssuerUniqueId; // 0x68
		internal byte[] SubjectUniqueId; // 0x70
		internal List<System.Security.Cryptography.X509Certificates.X509Extension> Extensions; // 0x78
		internal AlgorithmIdentifier SignatureAlgorithm; // 0x80
		internal byte[] SignatureValue; // 0x90
	
		// Nested types
		internal struct AlgorithmIdentifier // TypeDefIndex: 45489
		{
			// Fields
			internal string AlgorithmId; // 0x00
			internal byte[] Parameters; // 0x08
		}
	
		// Constructors
		internal CertificateData(byte[] rawData) {
			RawData = default;
			SubjectPublicKeyInfo = default;
			Version = default;
			SerialNumber = default;
			TbsSignature = default;
			Issuer = default;
			NotBefore = default;
			NotAfter = default;
			Subject = default;
			PublicKeyAlgorithm = default;
			PublicKey = default;
			IssuerUniqueId = default;
			SubjectUniqueId = default;
			Extensions = default;
			SignatureAlgorithm = default;
			SignatureValue = default;
		} // 0x0000000189A1F4D0-0x0000000189A1FD9C
	
		// Methods
		public string GetNameInfo(X509NameType nameType, bool forIssuer) => default; // 0x0000000189A1ED50-0x0000000189A1F1A0
		private static string GetSimpleNameInfo(X500DistinguishedName name) => default; // 0x0000000189A1F1A0-0x0000000189A1F460
		private static string FindAltNameMatch(byte[] extensionBytes, GeneralNameType matchType, string otherOid) => default; // 0x0000000189A1EB98-0x0000000189A1ED50
		[IteratorStateMachine(typeof(_ReadReverseRdns_d__21))]
		private static IEnumerable<KeyValuePair<string, string>> ReadReverseRdns(X500DistinguishedName name) => default; // 0x0000000189A1F460-0x0000000189A1F4D0
	}
}

namespace Mono
{
	internal class SystemCertificateProvider : ISystemCertificateProvider // TypeDefIndex: 45319
	{
		// Fields
		private static MonoTlsProvider provider; // 0x00
		private static int initialized; // 0x08
		private static X509PalImpl x509pal; // 0x10
		private static object syncRoot; // 0x18
	
		// Properties
		public X509PalImpl X509Pal { get => default; } // 0x000000018974CB98-0x000000018974CBEC 
	
		// Constructors
		public SystemCertificateProvider() {} // 0x000000018350B670-0x000000018350B680
		static SystemCertificateProvider() {} // 0x000000018974CB24-0x000000018974CB98
	
		// Methods
		private static X509PalImpl GetX509Pal() => default; // 0x000000018974C6E0-0x000000018974C880
		private static void EnsureInitialized() {} // 0x000000018974C4E4-0x000000018974C6E0
		public X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = CertificateImportFlags.None /* Metadata: 0x01FB9CDF */) => default; // 0x000000018974C880-0x000000018974C928
		X509CertificateImpl ISystemCertificateProvider.Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) => default; // 0x000000018974CB0C-0x000000018974CB1C
		public X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = CertificateImportFlags.None /* Metadata: 0x01FB9CE0 */) => default; // 0x000000018974C928-0x000000018974C9F8
		X509CertificateImpl ISystemCertificateProvider.Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, CertificateImportFlags importFlags) => default; // 0x000000018974CB1C-0x000000018974CB24
		public X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, CertificateImportFlags importFlags = CertificateImportFlags.None /* Metadata: 0x01FB9CE1 */) => default; // 0x000000018974C9F8-0x000000018974CB0C
	}

	internal class SystemDependencyProvider : ISystemDependencyProvider // TypeDefIndex: 45320
	{
		// Fields
		private static SystemDependencyProvider instance; // 0x00
		private static object syncRoot; // 0x08
	
		// Properties
		public static SystemDependencyProvider Instance { get => default; } // 0x000000018974CEA8-0x000000018974CEFC 
		ISystemCertificateProvider ISystemDependencyProvider.CertificateProvider { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public SystemCertificateProvider CertificateProvider { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public X509PalImpl X509Pal { get => default; } // 0x000000018974CEFC-0x000000018974CF1C 
	
		// Constructors
		private SystemDependencyProvider() {} // 0x000000018974CE38-0x000000018974CEA8
		static SystemDependencyProvider() {} // 0x000000018974CDC4-0x000000018974CE38
	
		// Methods
		internal static void Initialize() {} // 0x000000018974CC38-0x000000018974CDC4
	}

	internal static class X509Pal // TypeDefIndex: 45321
	{
		// Properties
		public static X509PalImpl Instance { get; } // 0x0000000189754A74-0x0000000189754AC0 
	}

	internal class X509PalImplMono : X509PalImpl // TypeDefIndex: 45322
	{
		// Constructors
		public X509PalImplMono() {} // 0x000000018975413C-0x000000018975417C
	
		// Methods
		public override X509CertificateImpl Import(byte[] data) => default; // 0x0000000189754134-0x000000018975413C
		public override X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) => default; // 0x0000000189754124-0x0000000189754134
		public override X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert) => default; // 0x0000000181002730-0x0000000181002740
	}

	internal abstract class X509PalImpl // TypeDefIndex: 45323
	{
		// Fields
		private static byte[] signedData; // 0x00
	
		// Properties
		public bool SupportsLegacyBasicConstraintsExtension { get; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		protected X509PalImpl() {} // 0x000000018350B670-0x000000018350B680
		static X509PalImpl() {} // 0x00000001897549E8-0x0000000189754A74
	
		// Methods
		public abstract X509CertificateImpl Import(byte[] data);
		public abstract X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags);
		public abstract X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert);
		private static byte[] PEM(string type, byte[] data) => default; // 0x00000001897548E0-0x00000001897549E8
		protected static byte[] ConvertData(byte[] data) => default; // 0x000000018975417C-0x000000018975426C
		internal X509Certificate2Impl ImportFallback(byte[] data) => default; // 0x0000000189754618-0x000000018975485C
		internal X509Certificate2Impl ImportFallback(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) => default; // 0x000000018975485C-0x00000001897548E0
		public X509ContentType GetCertContentType(byte[] rawData) => default; // 0x000000018975426C-0x0000000189754618
	}
}

namespace System
{
	internal static class IPv4AddressHelper // TypeDefIndex: 45492
	{
		// Methods
		internal static int ParseHostNumber(ReadOnlySpan<char> str, int start, int end) => default; // 0x0000000189A201AC-0x0000000189A20214
		internal static unsafe bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) => default; // 0x0000000189A1FEC0-0x0000000189A1FF00
		private static unsafe bool ParseCanonical(ReadOnlySpan<char> name, byte* numbers, int start, int end) => default; // 0x0000000189A20130-0x0000000189A201AC
		internal static unsafe bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile) => default; // 0x0000000189A1FD9C-0x0000000189A1FEC0
		internal static unsafe long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile) => default; // 0x0000000182941620-0x00000001829417B0
		internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback) => default; // 0x0000000189A1FF00-0x0000000189A20130
		private static unsafe bool Parse(string name, byte* numbers, int start, int end) => default; // 0x0000000189A20214-0x0000000189A20278
	}

	internal static class IPv6AddressHelper // TypeDefIndex: 45493
	{
		// Methods
		internal static System.ValueTuple<int, int> FindCompressionRange(ReadOnlySpan<ushort> numbers) => default; // 0x0000000189A20278-0x0000000189A2032C
		internal static bool ShouldHaveIpv4Embedded(ReadOnlySpan<ushort> numbers) => default; // 0x0000000189A20BE0-0x0000000189A20CB4
		internal static unsafe bool IsValidStrict(char* name, int start, ref int end) => default; // 0x0000000182942C40-0x0000000182942DF0
		internal static unsafe void Parse(ReadOnlySpan<char> address, ushort* numbers, int start, ref string scopeId) {} // 0x0000000182942E20-0x00000001829430A0
		internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) => default; // 0x0000000189A20688-0x0000000189A20BE0
		private static bool IsLoopback(ReadOnlySpan<ushort> numbers) => default; // 0x0000000189A20598-0x0000000189A2066C
		private static unsafe bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress) => default; // 0x0000000189A2032C-0x0000000189A20598
		internal static unsafe bool IsValid(char* name, int start, ref int end) => default; // 0x0000000189A2066C-0x0000000189A20688
	}

	internal static class NotImplemented // TypeDefIndex: 45494
	{
		// Methods
		internal static Exception ByDesignWithMessage(string message) => default; // 0x0000000189A2A94C-0x0000000189A2A9AC
	}

	internal static class PasteArguments // TypeDefIndex: 45495
	{
		// Methods
		internal static void AppendArgument(StringBuilder stringBuilder, string argument) {} // 0x0000000189A2CD90-0x0000000189A2CF04
		private static bool ContainsNoWhitespaceOrQuotes(string s) => default; // 0x0000000189A2CF04-0x0000000189A2CF90
	}

	internal static class StringExtensions // TypeDefIndex: 45496
	{
		// Extension methods
		internal static string SubstringTrim(this string value, int startIndex) => default; // 0x0000000189A2D240-0x0000000189A2D264
		internal static string SubstringTrim(this string value, int startIndex, int length) => default; // 0x0000000189A2D264-0x0000000189A2D374
	}

	public class UriBuilder // TypeDefIndex: 45497
	{
		// Fields
		private bool _changed; // 0x10
		private string _fragment; // 0x18
		private string _host; // 0x20
		private string _password; // 0x28
		private string _path; // 0x30
		private int _port; // 0x38
		private string _query; // 0x40
		private string _scheme; // 0x48
		private string _schemeDelimiter; // 0x50
		private System.Uri _uri; // 0x58
		private string _username; // 0x60
	
		// Properties
		public string Path { set {} } // 0x0000000189A2E230-0x0000000189A2E2D0
		public System.Uri Uri { get => default; } // 0x0000000189A2E12C-0x0000000189A2E230 
	
		// Constructors
		public UriBuilder() {} // Dummy constructor
		public UriBuilder(System.Uri uri) {} // 0x0000000189A2DF78-0x0000000189A2E12C
	
		// Methods
		private void Init(System.Uri uri) {} // 0x0000000189A2D864-0x0000000189A2DA0C
		public override bool Equals(object rparam) => default; // 0x0000000189A2D7EC-0x0000000189A2D83C
		public override int GetHashCode() => default; // 0x0000000189A2D83C-0x0000000189A2D864
		private void SetFieldsFromUri(System.Uri uri) {} // 0x0000000189A2DA0C-0x0000000189A2DBA0
		public override string ToString() => default; // 0x0000000189A2DBA0-0x0000000189A2DF78
	}

	internal static class SecurityUtils // TypeDefIndex: 45498
	{
		// Methods
		private static void DemandReflectionAccess(System.Type type) {} // 0x000000018350B670-0x000000018350B680
		private static void DemandGrantSet(Assembly assembly) {} // 0x000000018350B670-0x000000018350B680
		private static bool HasReflectionPermission(System.Type type) => default; // 0x0000000189A2D0D4-0x0000000189A2D144
		internal static object SecureCreateInstance(System.Type type) => default; // 0x000000018427642C-0x000000018427643C
		internal static object SecureCreateInstance(System.Type type, object[] args, bool allowNonPublic) => default; // 0x0000000182F6DD90-0x0000000182F6DE50
		internal static object SecureCreateInstance(System.Type type, object[] args) => default; // 0x0000000189A2D234-0x0000000189A2D240
		internal static object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, object[] args, bool allowNonPublic) => default; // 0x000000018427643C-0x0000000184276458
		internal static object SecureConstructorInvoke(System.Type type, System.Type[] argTypes, object[] args, bool allowNonPublic, System.Reflection.BindingFlags extraFlags) => default; // 0x0000000182F6DC70-0x0000000182F6DD90
		private static bool GenericArgumentsAreVisible(MethodInfo method) => default; // 0x0000000189A2D058-0x0000000189A2D0D4
		internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args) => default; // 0x0000000189A2D144-0x0000000189A2D234
	}

	[Serializable]
	internal class InvariantComparer : System.Collections.IComparer // TypeDefIndex: 45499
	{
		// Fields
		private CompareInfo m_compareInfo; // 0x10
		internal static readonly InvariantComparer Default; // 0x00
	
		// Constructors
		internal InvariantComparer() {} // 0x0000000189A20DEC-0x0000000189A20E4C
		static InvariantComparer() {} // 0x0000000189A20D7C-0x0000000189A20DEC
	
		// Methods
		public int Compare(object a, object b) => default; // 0x0000000189A20CB4-0x0000000189A20D7C
	}

	internal static class IriHelper // TypeDefIndex: 45500
	{
		// Methods
		internal static bool CheckIriUnicodeRange(char unicode, bool isQuery) => default; // 0x0000000189A213A8-0x0000000189A21408
		internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery) => default; // 0x0000000189A20E4C-0x0000000189A213A8
		internal static bool CheckIsReserved(char ch, UriComponents component) => default; // 0x0000000189A21408-0x0000000189A214F4
		internal static unsafe string EscapeUnescapeIri(char* pInput, int start, int end, UriComponents component) => default; // 0x0000000189A214F4-0x0000000189A21C30
	}

	[Serializable]
	[TypeConverter(typeof(UriTypeConverter))]
	public class Uri : ISerializable // TypeDefIndex: 45506
	{
		// Fields
		public static readonly string UriSchemeFile; // 0x00
		public static readonly string UriSchemeFtp; // 0x08
		public static readonly string UriSchemeGopher; // 0x10
		public static readonly string UriSchemeHttp; // 0x18
		public static readonly string UriSchemeHttps; // 0x20
		internal static readonly string UriSchemeWs; // 0x28
		internal static readonly string UriSchemeWss; // 0x30
		public static readonly string UriSchemeMailto; // 0x38
		public static readonly string UriSchemeNews; // 0x40
		public static readonly string UriSchemeNntp; // 0x48
		public static readonly string UriSchemeNetTcp; // 0x50
		public static readonly string UriSchemeNetPipe; // 0x58
		public static readonly string SchemeDelimiter; // 0x60
		private const int c_Max16BitUtf8SequenceLength = 12; // Metadata: 0x01FB9DD8
		internal const int c_MaxUriBufferSize = 65520; // Metadata: 0x01FB9DD9
		private const int c_MaxUriSchemeName = 1024; // Metadata: 0x01FB9DDD
		private string m_String; // 0x10
		private string m_originalUnicodeString; // 0x18
		private UriParser m_Syntax; // 0x20
		private string m_DnsSafeHost; // 0x28
		private Flags m_Flags; // 0x30
		private UriInfo m_Info; // 0x38
		private bool m_iriParsing; // 0x40
		private static bool s_ConfigInitialized; // 0x68
		private static bool s_ConfigInitializing; // 0x69
		private static UriIdnScope s_IdnScope; // 0x6C
		private static bool s_IriParsing; // 0x70
		private static bool useDotNetRelativeOrAbsolute; // 0x71
		private const UriKind DotNetRelativeOrAbsolute = (UriKind) 300; // Metadata: 0x01FB9DDF
		internal static readonly bool IsWindowsFileSystem; // 0x72
		private static object s_initLock; // 0x78
		private const UriFormat V1ToStringUnescape = (UriFormat) 32767; // Metadata: 0x01FB9DE1
		internal const char c_DummyChar = '\xffff'; // Metadata: 0x01FB9DE5
		internal const char c_EOL = '\xfffe'; // Metadata: 0x01FB9DE7
		internal static readonly char[] HexLowerChars; // 0x80
		private static readonly char[] _WSchars; // 0x88
	
		// Properties
		private bool IsImplicitFile { get => default; } // 0x0000000182C43240-0x0000000182C43260 
		private bool IsUncOrDosPath { get => default; } // 0x00000001899DE5B0-0x00000001899DE5C0 
		private bool IsDosPath { get => default; } // 0x0000000182C40BB0-0x0000000182C40BD0 
		private bool IsUncPath { get => default; } // 0x00000001899DE5C0-0x00000001899DE5D0 
		private Flags HostType { get => default; } // 0x0000000183D75DA0-0x0000000183D75DB0 
		private UriParser Syntax { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		private bool IsNotAbsoluteUri { get => default; } // 0x0000000182C40C10-0x0000000182C40C20 
		private bool AllowIdn { get => default; } // 0x0000000182C445D0-0x0000000182C44690 
		internal bool UserDrivenParsing { get => default; } // 0x0000000182C40BD0-0x0000000182C40BF0 
		private ushort SecuredPathIndex { get => default; } // 0x00000001899DE9F8-0x00000001899DEA54 
		public string AbsolutePath { get => default; } // 0x00000001899DDD40-0x00000001899DDE04 
		private string PrivateAbsolutePath { get => default; } // 0x00000001899DE824-0x00000001899DE8D8 
		public string AbsoluteUri { get => default; } // 0x0000000182C402C0-0x0000000182C40390 
		public string LocalPath { get => default; } // 0x00000001899DE658-0x00000001899DE6DC 
		public string Authority { get => default; } // 0x00000001899DDE04-0x00000001899DDE90 
		public UriHostNameType HostNameType { get => default; } // 0x00000001899DE260-0x00000001899DE374 
		public bool IsDefaultPort { get => default; } // 0x00000001899DE468-0x00000001899DE51C 
		public bool IsFile { get => default; } // 0x0000000182C400D0-0x0000000182C40150 
		public bool IsLoopback { get => default; } // 0x00000001899DE51C-0x00000001899DE5B0 
		public string PathAndQuery { get => default; } // 0x00000001899DE758-0x00000001899DE824 
		public string[] Segments { get => default; } // 0x00000001899DEA54-0x00000001899DEC04 
		public bool IsUnc { get => default; } // 0x00000001899DE5D0-0x00000001899DE658 
		public string Host { get => default; } // 0x0000000182C400A0-0x0000000182C400D0 
		private static object InitializeLock { get => default; } // 0x00000001899DE3AC-0x00000001899DE468 
		public int Port { get => default; } // 0x0000000182C3FB10-0x0000000182C3FB70 
		public string Query { get => default; } // 0x00000001899DE8D8-0x00000001899DE9F8 
		public string Fragment { get => default; } // 0x00000001899DE130-0x00000001899DE250 
		public string Scheme { get => default; } // 0x0000000182C402A0-0x0000000182C402C0 
		private bool OriginalStringSwitched { get => default; } // 0x00000001899DE6DC-0x00000001899DE734 
		public string OriginalString { get => default; } // 0x00000001899DE734-0x00000001899DE758 
		public string DnsSafeHost { get => default; } // 0x00000001899DDE90-0x00000001899DE130 
		public string IdnHost { get => default; } // 0x00000001899DE374-0x00000001899DE3AC 
		public bool IsAbsoluteUri { get => default; } // 0x0000000188571E40-0x0000000188571E4C 
		public bool UserEscaped { get => default; } // 0x00000001899DEC04-0x00000001899DEC14 
		public string UserInfo { get => default; } // 0x00000001899DEC14-0x00000001899DED1C 
		internal bool HasAuthority { get => default; } // 0x00000001899DE250-0x00000001899DE260 
	
		// Nested types
		[Flags]
		private enum Flags : ulong // TypeDefIndex: 45501
		{
			Zero = 0,
			HostNotParsed = 0,
			SchemeNotCanonical = 1,
			UserNotCanonical = 2,
			HostNotCanonical = 4,
			PortNotCanonical = 8,
			PathNotCanonical = 16,
			QueryNotCanonical = 32,
			FragmentNotCanonical = 64,
			CannotDisplayCanonical = 127,
			E_UserNotCanonical = 128,
			E_HostNotCanonical = 256,
			E_PortNotCanonical = 512,
			E_PathNotCanonical = 1024,
			E_QueryNotCanonical = 2048,
			E_FragmentNotCanonical = 4096,
			E_CannotDisplayCanonical = 8064,
			ShouldBeCompressed = 8192,
			FirstSlashAbsent = 16384,
			BackslashInPath = 32768,
			IndexMask = 65535,
			IPv6HostType = 65536,
			IPv4HostType = 131072,
			DnsHostType = 196608,
			UncHostType = 262144,
			BasicHostType = 327680,
			UnusedHostType = 393216,
			HostTypeMask = 458752,
			UnknownHostType = 458752,
			UserEscaped = 524288,
			AuthorityFound = 1048576,
			HasUserInfo = 2097152,
			LoopbackHost = 4194304,
			NotDefaultPort = 8388608,
			UserDrivenParsing = 16777216,
			CanonicalDnsHost = 33554432,
			ErrorOrParsingRecursion = 67108864,
			DosPath = 134217728,
			UncPath = 268435456,
			ImplicitFile = 536870912,
			MinimalUriInfoSet = 1073741824,
			AllUriInfoSet = 2147483648,
			IdnHost = 4294967296,
			HasUnicode = 8589934592,
			HostUnicodeNormalized = 17179869184,
			RestUnicodeNormalized = 34359738368,
			UnicodeHost = 68719476736,
			IntranetUri = 137438953472,
			UseOrigUncdStrOffset = 274877906944,
			UserIriCanonical = 549755813888,
			PathIriCanonical = 1099511627776,
			QueryIriCanonical = 2199023255552,
			FragmentIriCanonical = 4398046511104,
			IriCanonical = 8246337208320,
			CompressedSlashes = 17592186044416
		}
	
		private class UriInfo // TypeDefIndex: 45502
		{
			// Fields
			public string Host; // 0x10
			public string ScopeId; // 0x18
			public string String; // 0x20
			public Offset Offset; // 0x28
			public string DnsSafeHost; // 0x38
			public MoreInfo MoreInfo; // 0x40
	
			// Constructors
			public UriInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private struct Offset // TypeDefIndex: 45503
		{
			// Fields
			public ushort Scheme; // 0x00
			public ushort User; // 0x02
			public ushort Host; // 0x04
			public ushort PortValue; // 0x06
			public ushort Path; // 0x08
			public ushort Query; // 0x0A
			public ushort Fragment; // 0x0C
			public ushort End; // 0x0E
		}
	
		private class MoreInfo // TypeDefIndex: 45504
		{
			// Fields
			public string Path; // 0x10
			public string Query; // 0x18
			public string Fragment; // 0x20
			public string AbsoluteUri; // 0x28
			public int Hash; // 0x30
			public string RemoteUrl; // 0x38
	
			// Constructors
			public MoreInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[Flags]
		private enum Check // TypeDefIndex: 45505
		{
			None = 0,
			EscapedCanonical = 1,
			DisplayCanonical = 2,
			DotSlashAttn = 4,
			FoundNonAscii = 8,
			BackslashInPath = 16,
			ReservedFound = 32,
			NotIriCanonical = 64,
			DotSlashEscaped = 128
		}
	
		// Constructors
		public Uri() {} // Dummy constructor
		public Uri(string uriString) {} // 0x0000000182C44E90-0x0000000182C44EC0
		public Uri(string uriString, UriKind uriKind) {} // 0x00000001899DD8BC-0x00000001899DD934
		public Uri(Uri baseUri, string relativeUri) {} // 0x00000001899DDB78-0x00000001899DDC40
		public Uri(Uri baseUri, Uri relativeUri) {} // 0x00000001899DD934-0x00000001899DDB78
		protected Uri(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x00000001899DDC40-0x00000001899DDD40
		private Uri(Flags flags, UriParser uriParser, string uri) {} // 0x00000001838C1FA0-0x00000001838C1FD0
		static Uri() {} // 0x00000001830F0BD0-0x00000001830F11A0
	
		// Methods
		internal static bool IriParsingStatic(UriParser syntax) => default; // 0x0000000182C42300-0x0000000182C42380
		private bool AllowIdnStatic(UriParser syntax, Flags flags) => default; // 0x0000000182C44780-0x0000000182C44840
		private bool IsIntranet(string schemeHost) => default; // 0x000000018115F4C0-0x000000018115F530
		private void SetUserDrivenParsing() {} // 0x0000000183D75D80-0x0000000183D75DA0
		private bool NotAny(Flags flags) => default; // 0x0000000182C45CD0-0x0000000182C45CE0
		private bool InFact(Flags flags) => default; // 0x0000000182C44420-0x0000000182C44430
		private static bool StaticNotAny(Flags allFlags, Flags checkFlags) => default; // 0x0000000182C43BF0-0x0000000182C43C00
		private static bool StaticInFact(Flags allFlags, Flags checkFlags) => default; // 0x0000000182C40BA0-0x0000000182C40BB0
		private UriInfo EnsureUriInfo() => default; // 0x0000000182C40DE0-0x0000000182C40E20
		private void EnsureParseRemaining() {} // 0x0000000182C40BF0-0x0000000182C40C10
		private void EnsureHostString(bool allowDnsOptimization) {} // 0x0000000182C40D80-0x0000000182C40DE0
		private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) {} // 0x00000001899D8D9C-0x00000001899D8F38
		private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) => default; // 0x00000001899D9D80-0x00000001899D9F5C
		private static UriFormatException GetException(ParsingError err) => default; // 0x00000001899D9F5C-0x00000001899DA104
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x00000001899DD270-0x00000001899DD290
		protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x00000001899DAD14-0x00000001899DADE4
		private static bool StaticIsFile(UriParser syntax) => default; // 0x00000001899DD134-0x00000001899DD154
		private static void InitializeUriConfig() {} // 0x00000001899DB1D4-0x00000001899DB348
		private string GetLocalPath() => default; // 0x00000001899DA688-0x00000001899DAD14
		public static string HexEscape(char character) => default; // 0x00000001899DB0F4-0x00000001899DB1D4
		internal static bool IsGenDelim(char ch) => default; // 0x00000001899DB77C-0x00000001899DB7A0
		public static bool IsHexDigit(char character) => default; // 0x0000000182942DF0-0x0000000182942E20
		public static int FromHex(char digit) => default; // 0x00000001829430A0-0x00000001829430F0
		public override int GetHashCode() => default; // 0x00000001899DA104-0x00000001899DA220
		public override string ToString() => default; // 0x00000001899DD290-0x00000001899DD348
		public static bool operator ==(Uri uri1, Uri uri2) => default; // 0x0000000182C44E60-0x0000000182C44E90
		public static bool operator !=(Uri uri1, Uri uri2) => default; // 0x00000001838C1FD0-0x00000001838C2000
		public override bool Equals(object comparand) => default; // 0x00000001899D8F38-0x00000001899D9580
		public Uri MakeRelativeUri(Uri uri) => default; // 0x00000001899DB7A0-0x00000001899DBA38
		private static bool CheckForColonInFirstPathSegment(string uriString) => default; // 0x00000001899D79FC-0x00000001899D7A98
		internal static string InternalEscapeString(string rawString) => default; // 0x00000001899DB348-0x00000001899DB410
		private static ParsingError ParseScheme(string uriString, ref Flags flags, ref UriParser syntax) => default; // 0x0000000182C43C00-0x0000000182C43CD0
		internal UriFormatException ParseMinimal() => default; // 0x00000001899DBA38-0x00000001899DBA9C
		private ParsingError PrivateParseMinimal() => default; // 0x0000000182C43490-0x0000000182C43760
		private void PrivateParseMinimalIri(string newHost, ushort idx) {} // 0x0000000182C444B0-0x0000000182C44530
		private void CreateUriInfo(Flags cF) {} // 0x0000000182C40390-0x0000000182C40BA0
		private void CreateHostString() {} // 0x0000000182C44EC0-0x0000000182C45AD0
		private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Flags flags, ref string scopeId) => default; // 0x0000000182C45AD0-0x0000000182C45B90
		private void GetHostViaCustomSyntax() {} // 0x00000001899DA220-0x00000001899DA688
		internal string GetParts(UriComponents uriParts, UriFormat formatAs) => default; // 0x0000000184272E7C-0x0000000184272E84
		private string GetEscapedParts(UriComponents uriParts) => default; // 0x0000000182C44B60-0x0000000182C44C00
		private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) => default; // 0x00000001899DB024-0x00000001899DB0F4
		private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) => default; // 0x00000001899DBD04-0x00000001899DCC80
		private string GetUriPartsFromUserString(UriComponents uriParts) => default; // 0x0000000182C45CE0-0x0000000182C45D90
		private void ParseRemaining() {} // 0x0000000182C42380-0x0000000182C43240
		private static unsafe ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Flags flags, ref UriParser syntax) => default; // 0x0000000182C43CD0-0x0000000182C43F20
		private static unsafe bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) => default; // 0x00000001899D7A98-0x00000001899D7EF4
		private static unsafe ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) => default; // 0x0000000182C43F20-0x0000000182C43FF0
		private unsafe ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Flags flags, UriParser syntax, ref string newHost) => default; // 0x0000000182C43760-0x0000000182C43BB0
		private unsafe void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) {} // 0x0000000182C44690-0x0000000182C44780
		private unsafe void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Flags flags, ref string newHost, ref ParsingError err) {} // 0x00000001899D76C8-0x00000001899D79FC
		private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) {} // 0x00000001899D9638-0x00000001899D9660
		private unsafe void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) {} // 0x00000001899D95AC-0x00000001899D9638
		private unsafe Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) => default; // 0x0000000182C40E20-0x0000000182C41050
		private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) => default; // 0x00000001899D9660-0x00000001899D9D80
		private static unsafe void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) {} // 0x00000001899DD714-0x00000001899DD8BC
		private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) => default; // 0x00000001899D87B8-0x00000001899D8C28
		internal static int CalculateCaseInsensitiveHashCode(string text) => default; // 0x00000001899D7670-0x00000001899D76C8
		private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) => default; // 0x00000001899D7EF4-0x00000001899D87B8
		private static string PathDifference(string path1, string path2, bool compareCase) => default; // 0x00000001899DBA9C-0x00000001899DBD04
		private static bool IsLWS(char ch) => default; // 0x0000000182C44410-0x0000000182C44420
		private static bool IsAsciiLetter(char character) => default; // 0x00000001899DB46C-0x00000001899DB48C
		internal static bool IsAsciiLetterOrDigit(char character) => default; // 0x00000001899DB410-0x00000001899DB46C
		internal static bool IsBidiControlCharacter(char ch) => default; // 0x00000001899DB74C-0x00000001899DB77C
		internal static unsafe string StripBidiControlCharacter(char* strToClean, int start, int length) => default; // 0x00000001899DD154-0x00000001899DD270
		private void CreateThis(string uri, bool dontEscape, UriKind uriKind) {} // 0x0000000182C44A40-0x0000000182C44B60
		private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) {
			e = default;
		} // 0x0000000182C43260-0x0000000182C43490
		private bool CheckForConfigLoad(string data) => default; // 0x0000000182C44430-0x0000000182C444B0
		private bool CheckForUnicode(string data) => default; // 0x0000000182C41050-0x0000000182C41190
		private bool CheckForEscapedUnreserved(string data) => default; // 0x0000000182C44530-0x0000000182C445D0
		public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) {
			result = default;
			return default;
		} // 0x00000001838C1DB0-0x00000001838C1E70
		public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result) {
			result = default;
			return default;
		} // 0x00000001899DD348-0x00000001899DD40C
		public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result) {
			result = default;
			return default;
		} // 0x00000001899DD40C-0x00000001899DD594
		public string GetComponents(UriComponents components, UriFormat format) => default; // 0x0000000182C40C20-0x0000000182C40C80
		public static string UnescapeDataString(string stringToUnescape) => default; // 0x00000001899DD594-0x00000001899DD714
		internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) => default; // 0x00000001899D9580-0x00000001899D95AC
		internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) => default; // 0x00000001838C1E70-0x00000001838C1FA0
		internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) {
			e = default;
			return default;
		} // 0x00000001899DCC80-0x00000001899DD134
		private string GetRelativeSerializationString(UriFormat format) => default; // 0x00000001899DADE4-0x00000001899DB024
		internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) => default; // 0x0000000182C40C80-0x0000000182C40D80
		public bool IsBaseOf(Uri uri) => default; // 0x00000001899DB694-0x00000001899DB74C
		internal bool IsBaseOfHelper(Uri uriLink) => default; // 0x00000001899DB48C-0x00000001899DB694
		private void CreateThisFromUri(Uri otherUri) {} // 0x00000001899D8C28-0x00000001899D8D9C
	}

	[Serializable]
	public class UriFormatException : FormatException, ISerializable // TypeDefIndex: 45507
	{
		// Constructors
		public UriFormatException() {} // 0x0000000189A2E2F0-0x0000000189A2E2F8
		public UriFormatException(string textString) {} // 0x00000001839B95D0-0x00000001839B95F0
		protected UriFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x00000001891672B8-0x00000001891672D8
	
		// Methods
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A2E2D0-0x0000000189A2E2F0
	}

	public enum UriKind // TypeDefIndex: 45508
	{
		RelativeOrAbsolute = 0,
		Absolute = 1,
		Relative = 2
	}

	[Flags]
	public enum UriComponents // TypeDefIndex: 45509
	{
		Scheme = 1,
		UserInfo = 2,
		Host = 4,
		Port = 8,
		SchemeAndServer = 13,
		Path = 16,
		Query = 32,
		PathAndQuery = 48,
		HttpRequestUrl = 61,
		Fragment = 64,
		AbsoluteUri = 127,
		StrongPort = 128,
		HostAndPort = 132,
		StrongAuthority = 134,
		NormalizedHost = 256,
		KeepDelimiter = 1073741824,
		SerializationInfoString = 2147483647
	}

	public enum UriFormat // TypeDefIndex: 45510
	{
		UriEscaped = 1,
		Unescaped = 2,
		SafeUnescaped = 3
	}

	public enum UriIdnScope // TypeDefIndex: 45511
	{
		None = 0,
		AllExceptIntranet = 1,
		All = 2
	}

	internal enum ParsingError // TypeDefIndex: 45512
	{
		None = 0,
		BadFormat = 1,
		BadScheme = 2,
		BadAuthority = 3,
		EmptyUriString = 4,
		LastRelativeUriOkErrIndex = 4,
		SchemeLimit = 5,
		SizeLimit = 6,
		MustRootedPath = 7,
		BadHostName = 8,
		NonEmptyHost = 9,
		BadPort = 10,
		BadAuthorityTerminator = 11,
		CannotCreateRelative = 12
	}

	[Flags]
	internal enum UnescapeMode // TypeDefIndex: 45513
	{
		CopyOnly = 0,
		Escape = 1,
		Unescape = 2,
		EscapeUnescape = 3,
		V1ToStringFlag = 4,
		UnescapeAll = 8,
		UnescapeAllOrThrow = 24
	}

	internal static class UriHelper // TypeDefIndex: 45514
	{
		// Fields
		private static readonly char[] HexUpperChars; // 0x00
	
		// Constructors
		static UriHelper() {} // 0x0000000183CE2AA0-0x0000000183CE2B30
	
		// Methods
		internal static unsafe bool TestForSubPath(char* pMe, ushort meLength, char* pShe, ushort sheLength, bool ignoreCase) => default; // 0x0000000189A2F168-0x0000000189A2F2E8
		internal static char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd) => default; // 0x0000000189A2E4F8-0x0000000189A2EA5C
		private static unsafe char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos) => default; // 0x0000000189A2E2F8-0x0000000189A2E3F8
		internal static char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) => default; // 0x0000000182C41190-0x0000000182C41270
		internal static unsafe char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) => default; // 0x0000000182C41270-0x0000000182C42300
		internal static unsafe void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing) {} // 0x0000000189A2ED40-0x0000000189A2F168
		internal static void EscapeAsciiChar(char ch, char[] to, ref int pos) {} // 0x0000000189A2E3F8-0x0000000189A2E4F8
		internal static char EscapedAscii(char digit, char next) => default; // 0x0000000189A2EA5C-0x0000000189A2EB00
		internal static bool IsNotSafeForUnescape(char ch) => default; // 0x0000000189A2EB78-0x0000000189A2EBC4
		private static bool IsReservedUnreservedOrHash(char c) => default; // 0x0000000189A2EBC4-0x0000000189A2EC90
		internal static bool IsUnreserved(char c) => default; // 0x0000000189A2EC90-0x0000000189A2ED40
		internal static bool Is3986Unreserved(char c) => default; // 0x0000000189A2EB00-0x0000000189A2EB78
	}

	public enum UriHostNameType // TypeDefIndex: 45515
	{
		Unknown = 0,
		Basic = 1,
		Dns = 2,
		IPv4 = 3,
		IPv6 = 4
	}

	public abstract class UriParser // TypeDefIndex: 45518
	{
		// Fields
		private const UriSyntaxFlags SchemeOnlyFlags = UriSyntaxFlags.None | UriSyntaxFlags.MayHavePath; // Metadata: 0x01FB9FEA
		private static readonly Dictionary<string, UriParser> m_Table; // 0x00
		private static Dictionary<string, UriParser> m_TempTable; // 0x08
		private UriSyntaxFlags m_Flags; // 0x10
		private UriSyntaxFlags m_UpdatableFlags; // 0x14
		private bool m_UpdatableFlagsUsed; // 0x18
		private const UriSyntaxFlags c_UpdatableFlags = UriSyntaxFlags.None | UriSyntaxFlags.UnEscapeDotsAndSlashes; // Metadata: 0x01FB9FEB
		private int m_Port; // 0x1C
		private string m_Scheme; // 0x20
		internal const int NoDefaultPort = -1; // Metadata: 0x01FB9FEF
		private const int c_InitialTableSize = 25; // Metadata: 0x01FB9FF0
		internal static UriParser HttpUri; // 0x10
		internal static UriParser HttpsUri; // 0x18
		internal static UriParser WsUri; // 0x20
		internal static UriParser WssUri; // 0x28
		internal static UriParser FtpUri; // 0x30
		internal static UriParser FileUri; // 0x38
		internal static UriParser GopherUri; // 0x40
		internal static UriParser NntpUri; // 0x48
		internal static UriParser NewsUri; // 0x50
		internal static UriParser MailToUri; // 0x58
		internal static UriParser UuidUri; // 0x60
		internal static UriParser TelnetUri; // 0x68
		internal static UriParser LdapUri; // 0x70
		internal static UriParser NetTcpUri; // 0x78
		internal static UriParser NetPipeUri; // 0x80
		internal static UriParser VsMacrosUri; // 0x88
		private static readonly UriQuirksVersion s_QuirksVersion; // 0x90
		private const int c_MaxCapacity = 512; // Metadata: 0x01FB9FF1
		private const UriSyntaxFlags UnknownV1SyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.OptionalAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.V1_UnknownUri | UriSyntaxFlags.AllowDOSPath | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x01FB9FF3
		private static readonly UriSyntaxFlags HttpSyntaxFlags; // 0x94
		private const UriSyntaxFlags FtpSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x01FB9FF8
		private static readonly UriSyntaxFlags FileSyntaxFlags; // 0x98
		private const UriSyntaxFlags VsmacrosSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.FileLikeUri | UriSyntaxFlags.AllowDOSPath | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x01FB9FFD
		private const UriSyntaxFlags GopherSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x01FBA002
		private const UriSyntaxFlags NewsSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x01FBA007
		private const UriSyntaxFlags NntpSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x01FBA00C
		private const UriSyntaxFlags TelnetSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x01FBA011
		private const UriSyntaxFlags LdapSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x01FBA016
		private const UriSyntaxFlags MailtoSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.MailToLikeUri | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x01FBA01B
		private const UriSyntaxFlags NetPipeSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x01FBA020
		private const UriSyntaxFlags NetTcpSyntaxFlags = UriSyntaxFlags.None | UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.AllowAnInternetHost | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing; // Metadata: 0x01FBA025
	
		// Properties
		internal string SchemeName { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		internal int DefaultPort { get; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 
		internal static bool ShouldUseLegacyV2Quirks { get; } // 0x00000001835F5C50-0x00000001835F5CB0 
		internal UriSyntaxFlags Flags { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		internal bool IsSimple { get; } // 0x0000000184272E84-0x0000000184272E94 
	
		// Nested types
		private enum UriQuirksVersion // TypeDefIndex: 45516
		{
			V2 = 2,
			V3 = 3
		}
	
		private class BuiltInUriParser : UriParser // TypeDefIndex: 45517
		{
			// Constructors
			public BuiltInUriParser() {} // Dummy constructor
			internal BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags) {} // 0x00000001835F5B60-0x00000001835F5BF0
		}
	
		// Constructors
		protected UriParser() {} // Dummy constructor
		static UriParser() {} // 0x00000001835F4EA0-0x00000001835F5B60
		internal UriParser(UriSyntaxFlags flags) {} // 0x00000001835F5BF0-0x00000001835F5C50
	
		// Methods
		protected virtual UriParser OnNewUri() => default; // 0x000000018339AE90-0x000000018339AEA0
		protected virtual void InitializeAndValidate(System.Uri uri, out UriFormatException parsingError) {
			parsingError = default;
		} // 0x0000000189A2F624-0x0000000189A2F658
		protected virtual string Resolve(System.Uri baseUri, System.Uri relativeUri, out UriFormatException parsingError) {
			parsingError = default;
			return default;
		} // 0x0000000189A2F6BC-0x0000000189A2F8AC
		protected virtual bool IsBaseOf(System.Uri baseUri, System.Uri relativeUri) => default; // 0x0000000189A2F688-0x0000000189A2F6B0
		protected virtual string GetComponents(System.Uri uri, UriComponents components, UriFormat format) => default; // 0x0000000189A2F2E8-0x0000000189A2F564
		internal bool NotAny(UriSyntaxFlags flags) => default; // 0x0000000189A2F6B0-0x0000000189A2F6BC
		internal bool InFact(UriSyntaxFlags flags) => default; // 0x0000000182C43BB0-0x0000000182C43BD0
		internal bool IsAllSet(UriSyntaxFlags flags) => default; // 0x0000000184272E94-0x0000000184272EA0
		private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) => default; // 0x0000000182C43BD0-0x0000000182C43BF0
		internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) => default; // 0x0000000182C43FF0-0x0000000182C44410
		internal static UriParser GetSyntax(string lwrCaseScheme) => default; // 0x0000000189A2F564-0x0000000189A2F624
		internal UriParser InternalOnNewUri() => default; // 0x0000000183D86CE0-0x0000000183D86CF0
		internal void InternalValidate(System.Uri thisUri, out UriFormatException parsingError) {
			parsingError = default;
		} // 0x0000000189A2F680-0x0000000189A2F688
		internal string InternalResolve(System.Uri thisBaseUri, System.Uri uriLink, out UriFormatException parsingError) {
			parsingError = default;
			return default;
		} // 0x0000000189A2F670-0x0000000189A2F680
		internal bool InternalIsBaseOf(System.Uri thisBaseUri, System.Uri uriLink) => default; // 0x0000000189A2F668-0x0000000189A2F670
		internal string InternalGetComponents(System.Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) => default; // 0x0000000189A2F658-0x0000000189A2F668
	}

	internal class DomainNameHelper // TypeDefIndex: 45519
	{
		// Constructors
		public DomainNameHelper() {} // Dummy constructor
	
		// Methods
		internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) => default; // 0x0000000182C45B90-0x0000000182C45CD0
		internal static unsafe bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) => default; // 0x0000000189A32568-0x0000000189A32688
		internal static unsafe bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) => default; // 0x0000000182C44840-0x0000000182C449F0
		internal static string IdnEquivalent(string hostname) => default; // 0x0000000189A322A8-0x0000000189A322F0
		internal static unsafe string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) => default; // 0x0000000189A32034-0x0000000189A322A8
		internal static unsafe string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost) => default; // 0x0000000189A322F0-0x0000000189A324C4
		private static bool IsIdnAce(string input, int index) => default; // 0x0000000189A324C4-0x0000000189A32538
		private static unsafe bool IsIdnAce(char* input, int index) => default; // 0x0000000189A32538-0x0000000189A32568
		internal static unsafe string UnicodeEquivalent(string idnHost, char* hostname, int start, int end) => default; // 0x0000000189A32688-0x0000000189A32790
		internal static unsafe string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) => default; // 0x0000000189A32790-0x0000000189A32BF8
		private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical) => default; // 0x0000000182C44A20-0x0000000182C44A40
		private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical) => default; // 0x0000000182C449F0-0x0000000182C44A20
	}

	internal class UncNameHelper // TypeDefIndex: 45520
	{
		// Constructors
		public UncNameHelper() {} // Dummy constructor
	
		// Methods
		internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) => default; // 0x0000000189A3571C-0x0000000189A3572C
		internal static unsafe bool IsValid(char* name, ushort start, ref int returnedEnd, bool notImplicitFile) => default; // 0x0000000189A35500-0x0000000189A3571C
	}

	[Flags]
	internal enum UriSyntaxFlags // TypeDefIndex: 45521
	{
		None = 0,
		MustHaveAuthority = 1,
		OptionalAuthority = 2,
		MayHaveUserInfo = 4,
		MayHavePort = 8,
		MayHavePath = 16,
		MayHaveQuery = 32,
		MayHaveFragment = 64,
		AllowEmptyHost = 128,
		AllowUncHost = 256,
		AllowDnsHost = 512,
		AllowIPv4Host = 1024,
		AllowIPv6Host = 2048,
		AllowAnInternetHost = 3584,
		AllowAnyOtherHost = 4096,
		FileLikeUri = 8192,
		MailToLikeUri = 16384,
		V1_UnknownUri = 65536,
		SimpleUserSyntax = 131072,
		BuiltInSyntax = 262144,
		ParserSchemeOnly = 524288,
		AllowDOSPath = 1048576,
		PathIsRooted = 2097152,
		ConvertPathSlashes = 4194304,
		CompressPath = 8388608,
		CanonicalizeAsFilePath = 16777216,
		UnEscapeDotsAndSlashes = 33554432,
		AllowIdn = 67108864,
		AllowIriParsing = 268435456
	}

	internal static class LocalAppContextSwitches // TypeDefIndex: 45522
	{
		// Fields
		public static readonly bool MemberDescriptorEqualsReturnsFalseIfEquivalent; // 0x00
	}

	internal enum IOOperation // TypeDefIndex: 45523
	{
		Read = 1,
		Write = 2
	}

	internal delegate void IOAsyncCallback(IOAsyncResult ioares); // TypeDefIndex: 45524; 0x0000000182149960-0x0000000182149970

	internal abstract class IOAsyncResult : IAsyncResult // TypeDefIndex: 45525
	{
		// Fields
		private AsyncCallback async_callback; // 0x10
		private object async_state; // 0x18
		private ManualResetEvent wait_handle; // 0x20
		private bool completed_synchronously; // 0x28
		private bool completed; // 0x29
	
		// Properties
		public AsyncCallback AsyncCallback { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public object AsyncState { get; } // 0x0000000181041090-0x00000001810410A0 
		public WaitHandle AsyncWaitHandle { get; } // 0x0000000189A338F8-0x0000000189A33B54 
		public bool CompletedSynchronously { get; protected set; } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
		public bool IsCompleted { get; protected set; } // 0x0000000183D4F2A0-0x0000000183D4F2B0 0x0000000183627130-0x0000000183627290
	
		// Constructors
		protected IOAsyncResult() {} // 0x000000018350B670-0x000000018350B680
		protected IOAsyncResult(AsyncCallback async_callback, object async_state) {} // 0x0000000182676770-0x00000001826767A0
	
		// Methods
		protected void Init(AsyncCallback async_callback, object async_state) {} // 0x0000000189A338B4-0x0000000189A338F8
		internal abstract void CompleteDisposed();
	}

	internal class IOSelectorJob : IThreadPoolWorkItem // TypeDefIndex: 45526
	{
		// Fields
		private IOOperation operation; // 0x10
		private IOAsyncCallback callback; // 0x18
		private IOAsyncResult state; // 0x20
	
		// Constructors
		public IOSelectorJob() {} // Dummy constructor
		public IOSelectorJob(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) {} // 0x0000000182959C60-0x0000000182959C90
	
		// Methods
		void IThreadPoolWorkItem.ExecuteWorkItem() {} // 0x0000000183CDE870-0x0000000183CDEA50
		void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) {} // 0x000000018350B670-0x000000018350B680
		public void MarkDisposed() {} // 0x0000000189A33B54-0x0000000189A33B78
	}

	internal static class IOSelector // TypeDefIndex: 45527
	{
		// Methods
		public static void Add(IntPtr handle, IOSelectorJob job) {} // 0x00000001842720C8-0x00000001842720D0
	}

	public class UriTypeConverter : TypeConverter // TypeDefIndex: 45528
	{
		// Constructors
		public UriTypeConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private bool CanConvert(System.Type type) => default; // 0x0000000189A35834-0x0000000189A358CC
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x0000000189A3572C-0x0000000189A357D8
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x0000000189A357D8-0x0000000189A35834
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x0000000189A358CC-0x0000000189A35A94
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x0000000189A35A94-0x0000000189A35C98
	}
}

namespace Unity
{
	internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 46226
	{
		// Constructors
		public ThrowStub() {} // Dummy constructor
	
		// Methods
		public static void ThrowNotSupportedException() {} // 0x0000000189A1D1EC-0x0000000189A1D238
	}
}
