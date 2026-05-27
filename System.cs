/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Net.Mime;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Xml;
using Internal.Cryptography.Pal;
using Microsoft.Win32.SafeHandles;
using Mono;
using Mono.Net.Security;
using Mono.Security.Interface;
using Mono.Security.Protocol.Ntlm;
using Mono.Security.X509;
using Mono.Util;

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

namespace Microsoft.Win32
{
	internal static class NativeMethods // TypeDefIndex: 45484
	{
		// Methods
		public static bool DuplicateHandle(HandleRef hSourceProcessHandle, SafeHandle hSourceHandle, HandleRef hTargetProcess, out SafeWaitHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) {
			targetHandle = default;
			return default;
		} // 0x0000000189A2A560-0x0000000189A2A884
		public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) {
			targetHandle = default;
			return default;
		} // 0x0000000182C9C260-0x0000000182C9C390
		public static IntPtr GetCurrentProcess() => default; // 0x0000000184273024-0x000000018427302C
		public static bool GetExitCodeProcess(IntPtr processHandle, out int exitCode) {
			exitCode = default;
			return default;
		} // 0x0000000184273034-0x000000018427303C
		public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode) {
			exitCode = default;
			return default;
		} // 0x0000000182C9C520-0x0000000182C9C6C0
		public static int GetCurrentProcessId() => default; // 0x0000000184273000-0x0000000184273008
		public static bool CloseProcess(IntPtr handle) => default; // 0x0000000184277218-0x000000018427722C
	}
}

namespace Microsoft.Win32.SafeHandles
{
	public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 45485
	{
		// Fields
		internal static SafeProcessHandle InvalidHandle; // 0x00
	
		// Constructors
		public SafeProcessHandle() {} // Dummy constructor
		internal SafeProcessHandle(IntPtr handle) {} // 0x0000000183D25F20-0x0000000183D25F50
		public SafeProcessHandle(IntPtr existingHandle, bool ownsHandle) {} // 0x0000000182C9C390-0x0000000182C9C3C0
		static SafeProcessHandle() {} // 0x0000000183D25EA0-0x0000000183D25F20
	
		// Methods
		protected override bool ReleaseHandle() => default; // 0x0000000183D4C320-0x0000000183D4C340
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

namespace Mono.Btls
{
	internal class MonoBtlsBio : MonoBtlsObject // TypeDefIndex: 45422
	{
		// Properties
		protected internal new BoringBioHandle Handle { get => default; } // 0x00000001897453B0-0x00000001897453F4 
	
		// Nested types
		protected internal class BoringBioHandle : MonoBtlsObject.MonoBtlsHandle // TypeDefIndex: 45421
		{
			// Constructors
			public BoringBioHandle() {} // Dummy constructor
			public BoringBioHandle(IntPtr handle) {} // 0x000000018974040C-0x0000000189740418
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x00000001897403E0-0x000000018974040C
		}
	
		// Constructors
		public MonoBtlsBio() {} // Dummy constructor
		internal MonoBtlsBio(BoringBioHandle handle) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		private static extern void mono_btls_bio_free(IntPtr handle); // 0x00000001897453F4-0x0000000189745428
	}

	internal class MonoBtlsBioMemory : MonoBtlsBio // TypeDefIndex: 45423
	{
		// Constructors
		public MonoBtlsBioMemory() {} // 0x00000001897447EC-0x000000018974486C
	
		// Methods
		private static extern IntPtr mono_btls_bio_mem_new(); // 0x00000001897448F0-0x000000018974491C
		private static extern int mono_btls_bio_mem_get_data(IntPtr handle, out IntPtr data); // 0x000000018974486C-0x00000001897448F0
		public byte[] GetData() => default; // 0x0000000189744638-0x00000001897447EC
	}

	internal interface IMonoBtlsBioMono // TypeDefIndex: 45424
	{
		// Methods
		int Read(byte[] buffer, int offset, int size, out bool wantMore);
		bool Write(byte[] buffer, int offset, int size);
		void Flush();
		void Close();
	}

	internal class MonoBtlsBioMono : MonoBtlsBio // TypeDefIndex: 45429
	{
		// Fields
		private GCHandle handle; // 0x20
		private IntPtr instance; // 0x28
		private BioReadFunc readFunc; // 0x30
		private BioWriteFunc writeFunc; // 0x38
		private BioControlFunc controlFunc; // 0x40
		private IntPtr readFuncPtr; // 0x48
		private IntPtr writeFuncPtr; // 0x50
		private IntPtr controlFuncPtr; // 0x58
		private IMonoBtlsBioMono backend; // 0x60
	
		// Nested types
		private enum ControlCommand // TypeDefIndex: 45425
		{
			Flush = 1
		}
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int BioReadFunc(IntPtr bio, IntPtr data, int dataLength, out int wantMore); // TypeDefIndex: 45426; 0x000000018101C850-0x000000018101C870
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int BioWriteFunc(IntPtr bio, IntPtr data, int dataLength); // TypeDefIndex: 45427; 0x0000000181035ED0-0x0000000181035EF0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate long BioControlFunc(IntPtr bio, ControlCommand command, long arg); // TypeDefIndex: 45428; 0x0000000181035ED0-0x0000000181035EF0
	
		// Constructors
		public MonoBtlsBioMono() {} // Dummy constructor
		public MonoBtlsBioMono(IMonoBtlsBioMono backend) {} // 0x0000000189745050-0x00000001897452A8
	
		// Methods
		private static extern IntPtr mono_btls_bio_mono_new(); // 0x0000000189745348-0x00000001897453B0
		private static extern void mono_btls_bio_mono_initialize(IntPtr handle, IntPtr instance, IntPtr readFunc, IntPtr writeFunc, IntPtr controlFunc); // 0x00000001897452A8-0x0000000189745348
		private long Control(ControlCommand command, long arg) => default; // 0x0000000189744B58-0x0000000189744BFC
		private int OnRead(IntPtr data, int dataLength, out int wantMore) {
			wantMore = default;
			return default;
		} // 0x0000000189744D24-0x0000000189744E3C
		[Mono.Util.MonoPInvokeCallback(typeof(BioReadFunc))]
		private static int OnRead(IntPtr instance, IntPtr data, int dataLength, out int wantMore) {
			wantMore = default;
			return default;
		} // 0x0000000189744BFC-0x0000000189744D24
		private int OnWrite(IntPtr data, int dataLength) => default; // 0x0000000189744E3C-0x0000000189744F38
		[Mono.Util.MonoPInvokeCallback(typeof(BioWriteFunc))]
		private static int OnWrite(IntPtr instance, IntPtr data, int dataLength) => default; // 0x0000000189744F38-0x0000000189745050
		[Mono.Util.MonoPInvokeCallback(typeof(BioControlFunc))]
		private static long Control(IntPtr instance, ControlCommand command, long arg) => default; // 0x0000000189744A40-0x0000000189744B58
		protected override void Close() {} // 0x000000018974491C-0x0000000189744A40
	}

	internal class MonoBtlsContext : MobileTlsContext, IMonoBtlsBioMono // TypeDefIndex: 45430
	{
		// Fields
		private X509Certificate2 remoteCertificate; // 0x58
		private System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate; // 0x60
		private X509CertificateImplBtls nativeServerCertificate; // 0x68
		private X509CertificateImplBtls nativeClientCertificate; // 0x70
		private MonoBtlsSslCtx ctx; // 0x78
		private MonoBtlsSsl ssl; // 0x80
		private MonoBtlsBio bio; // 0x88
		private MonoBtlsBio errbio; // 0x90
		private MonoTlsConnectionInfo connectionInfo; // 0x98
		private bool certificateValidated; // 0xA0
		private bool isAuthenticated; // 0xA1
		private bool connected; // 0xA2
	
		// Properties
		public override bool IsAuthenticated { get => default; } // 0x0000000183D50A50-0x0000000183D50A60 
		internal override System.Security.Cryptography.X509Certificates.X509Certificate LocalClientCertificate { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public override X509Certificate2 RemoteCertificate { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
	
		// Constructors
		public MonoBtlsContext() {} // Dummy constructor
		public MonoBtlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) {} // 0x0000000189747020-0x0000000189747064
	
		// Methods
		private static X509CertificateImplBtls GetPrivateCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate) => default; // 0x0000000189745A5C-0x0000000189745D1C
		private int VerifyCallback(MonoBtlsX509StoreCtx storeCtx) => default; // 0x0000000189746C24-0x0000000189746E20
		private int SelectCallback(string[] acceptableIssuers) => default; // 0x000000018974668C-0x0000000189746758
		private int ServerNameCallback() => default; // 0x0000000189746758-0x00000001897467C0
		public override void StartHandshake() {} // 0x0000000189746AD0-0x0000000189746C24
		private void SetPrivateCertificate(X509CertificateImplBtls privateCert) {} // 0x00000001897467C0-0x0000000189746A74
		private static Exception GetException(MonoBtlsSslError status) => default; // 0x000000018974567C-0x0000000189745948
		public override bool ProcessHandshake() => default; // 0x0000000189746358-0x0000000189746408
		private MonoBtlsSslError DoProcessHandshake() => default; // 0x00000001897455BC-0x0000000189745610
		public override void FinishHandshake() {} // 0x0000000189745610-0x0000000189745630
		private void InitializeConnection() {} // 0x0000000189745D94-0x0000000189746188
		private void GetPeerCertificate() {} // 0x0000000189745948-0x0000000189745A5C
		private void InitializeSession() {} // 0x0000000189746188-0x00000001897462E4
		private static TlsProtocols GetProtocol(TlsProtocolCode protocol) => default; // 0x0000000189745D1C-0x0000000189745D94
		public override void Flush() {} // 0x0000000189745630-0x000000018974567C
		public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int size) => default; // 0x0000000189746408-0x0000000189746640
		public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int size) => default; // 0x0000000189746E20-0x0000000189747020
		public override void Renegotiate() {} // 0x0000000189746640-0x000000018974668C
		public override void Shutdown() {} // 0x0000000189746A74-0x0000000189746AD0
		public override bool PendingRenegotiation() => default; // 0x0000000189746334-0x0000000189746358
		private void Dispose<T>(ref ref T disposable)
			where T : class, IDisposable {}
		protected override void Dispose(bool disposing) {} // 0x0000000189745428-0x00000001897455BC
		int IMonoBtlsBioMono.Read(byte[] buffer, int offset, int size, out bool wantMore) {
			wantMore = default;
			return default;
		} // 0x00000001897462E4-0x000000018974630C
		bool IMonoBtlsBioMono.Write(byte[] buffer, int offset, int size) => default; // 0x000000018974630C-0x0000000189746334
		void IMonoBtlsBioMono.Flush() {} // 0x000000018350B670-0x000000018350B680
		void IMonoBtlsBioMono.Close() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class MonoBtlsError // TypeDefIndex: 45431
	{
		// Methods
		private static extern void mono_btls_error_clear_error(); // 0x0000000189747230-0x0000000189747298
		private static extern int mono_btls_error_get_error_line(out IntPtr file, out int line); // 0x0000000189747298-0x000000018974731C
		private static extern void mono_btls_error_get_error_string_n(int error, IntPtr buf, int len); // 0x000000018974731C-0x00000001897473AC
		private static extern int mono_btls_error_get_reason(int error); // 0x00000001897473AC-0x0000000189747424
		public static void ClearError() {} // 0x0000000189747064-0x000000018974706C
		public static string GetErrorString(int error) => default; // 0x0000000189747074-0x00000001897471A4
		public static int GetError(out string file, out int line) {
			file = default;
			line = default;
			return default;
		} // 0x00000001897471A4-0x0000000189747230
		public static int GetErrorReason(int error) => default; // 0x000000018974706C-0x0000000189747074
	}

	internal class MonoBtlsException : Exception // TypeDefIndex: 45432
	{
		// Constructors
		public MonoBtlsException() {} // 0x0000000189747480-0x00000001897474CC
		public MonoBtlsException(MonoBtlsSslError error) {} // 0x000000018974753C-0x00000001897475BC
		public MonoBtlsException(string message) {} // 0x0000000189747424-0x0000000189747480
		public MonoBtlsException(string format, params object[] args) {} // 0x00000001897474CC-0x000000018974753C
	}

	internal class MonoBtlsKey : MonoBtlsObject // TypeDefIndex: 45434
	{
		// Properties
		internal new BoringKeyHandle Handle { get => default; } // 0x00000001897478E0-0x0000000189747924 
	
		// Nested types
		internal class BoringKeyHandle : MonoBtlsObject.MonoBtlsHandle // TypeDefIndex: 45433
		{
			// Constructors
			public BoringKeyHandle() {} // Dummy constructor
			internal BoringKeyHandle(IntPtr handle) {} // 0x000000018974040C-0x0000000189740418
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x0000000189740418-0x0000000189740430
		}
	
		// Constructors
		public MonoBtlsKey() {} // Dummy constructor
		internal MonoBtlsKey(BoringKeyHandle handle) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		private static extern IntPtr mono_btls_key_new(); // 0x0000000189747A94-0x0000000189747AFC
		private static extern void mono_btls_key_free(IntPtr handle); // 0x00000001897479C0-0x00000001897479F4
		private static extern IntPtr mono_btls_key_up_ref(IntPtr handle); // 0x0000000189747AFC-0x0000000189747B74
		private static extern int mono_btls_key_get_bytes(IntPtr handle, out IntPtr data, out int size, int include_private_bits); // 0x00000001897479F4-0x0000000189747A94
		private static extern int mono_btls_key_assign_rsa_private_key(IntPtr handle, byte[] der, int der_length); // 0x0000000189747924-0x00000001897479C0
		public byte[] GetBytes(bool include_private_bits) => default; // 0x00000001897477E4-0x00000001897478E0
		public MonoBtlsKey Copy() => default; // 0x00000001897475C4-0x00000001897476B0
		public static MonoBtlsKey CreateFromRSAPrivateKey(RSA privateKey) => default; // 0x00000001897476B0-0x00000001897477E4
	}

	internal abstract class MonoBtlsObject : IDisposable // TypeDefIndex: 45436
	{
		// Fields
		private MonoBtlsHandle handle; // 0x10
		private Exception lastError; // 0x18
	
		// Properties
		internal MonoBtlsHandle Handle { get; } // 0x00000001897481A8-0x00000001897481C4 
		public bool IsValid { get; } // 0x00000001897481C4-0x00000001897481EC 
	
		// Nested types
		protected internal abstract class MonoBtlsHandle : SafeHandle // TypeDefIndex: 45435
		{
			// Properties
			public override bool IsInvalid { get; } // 0x00000001825EB8A0-0x00000001825EB8B0 
	
			// Constructors
			protected MonoBtlsHandle() {} // Dummy constructor
			internal MonoBtlsHandle(IntPtr handle, bool ownsHandle) {} // 0x00000001897475BC-0x00000001897475C4
		}
	
		// Constructors
		protected MonoBtlsObject() {} // Dummy constructor
		internal MonoBtlsObject(MonoBtlsHandle handle) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		protected void CheckThrow() {} // 0x0000000189747EB4-0x0000000189747F54
		protected Exception SetException(Exception ex) => default; // 0x0000000189748184-0x00000001897481A8
		protected void CheckError(bool ok, [CallerMemberName] string callerName = null) {} // 0x0000000189747B74-0x0000000189747CE4
		protected void CheckError(int ret, [CallerMemberName] string callerName = null) {} // 0x0000000189747CE4-0x0000000189747CF4
		protected internal void CheckLastError([CallerMemberName] string callerName = null) {} // 0x0000000189747CF4-0x0000000189747EB4
		private static extern void mono_btls_free(IntPtr data); // 0x00000001897481EC-0x0000000189748264
		protected void FreeDataPtr(IntPtr data) {} // 0x0000000189748178-0x0000000189748184
		protected virtual void Close() {} // 0x000000018350B670-0x000000018350B680
		protected void Dispose(bool disposing) {} // 0x0000000189747F54-0x00000001897480B4
		public void Dispose() {} // 0x00000001897480B4-0x0000000189748104
		~MonoBtlsObject() {} // 0x0000000189748104-0x0000000189748178
	}

	internal class MonoBtlsPkcs12 : MonoBtlsObject // TypeDefIndex: 45438
	{
		// Fields
		private MonoBtlsKey privateKey; // 0x20
	
		// Properties
		internal new BoringPkcs12Handle Handle { get => default; } // 0x000000018974863C-0x0000000189748680 
		public int Count { get => default; } // 0x0000000189748614-0x000000018974863C 
		public bool HasPrivateKey { get => default; } // 0x0000000189748680-0x00000001897486AC 
	
		// Nested types
		internal class BoringPkcs12Handle : MonoBtlsObject.MonoBtlsHandle // TypeDefIndex: 45437
		{
			// Constructors
			public BoringPkcs12Handle() {} // Dummy constructor
			public BoringPkcs12Handle(IntPtr handle) {} // 0x000000018974040C-0x0000000189740418
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x0000000189740430-0x0000000189740448
		}
	
		// Constructors
		internal MonoBtlsPkcs12() {} // 0x0000000189748594-0x0000000189748614
	
		// Methods
		private static extern void mono_btls_pkcs12_free(IntPtr handle); // 0x00000001897486AC-0x00000001897486E0
		private static extern IntPtr mono_btls_pkcs12_new(); // 0x000000018974892C-0x0000000189748994
		private static extern int mono_btls_pkcs12_get_count(IntPtr handle); // 0x0000000189748720-0x0000000189748798
		private static extern IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index); // 0x00000001897486E0-0x0000000189748720
		private static unsafe extern int mono_btls_pkcs12_import(IntPtr chain, void* data, int len, SafePasswordHandle password); // 0x0000000189748844-0x000000018974892C
		private static extern int mono_btls_pkcs12_has_private_key(IntPtr pkcs12); // 0x00000001897487CC-0x0000000189748844
		private static extern IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12); // 0x0000000189748798-0x00000001897487CC
		public MonoBtlsX509 GetCertificate(int index) => default; // 0x0000000189748264-0x0000000189748398
		public void Import(byte[] buffer, SafePasswordHandle password) {} // 0x00000001897484E0-0x0000000189748594
		public MonoBtlsKey GetPrivateKey() => default; // 0x0000000189748398-0x00000001897484E0
	}

	internal class MonoBtlsProvider : MobileTlsProvider // TypeDefIndex: 45439
	{
		// Properties
		public override Guid ID { get => default; } // 0x000000018974A438-0x000000018974A494 
		public override string Name { get => default; } // 0x000000018974A494-0x000000018974A4C0 
		public override bool SupportsSslStream { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool SupportsMonoExtensions { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool SupportsConnectionInfo { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		internal override bool SupportsCleanShutdown { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override SslProtocols SupportedProtocols { get => default; } // 0x0000000183D753E0-0x0000000183D753F0 
	
		// Constructors
		internal MonoBtlsProvider() {} // 0x000000018974A3B4-0x000000018974A438
	
		// Methods
		internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) => default; // 0x0000000189748D3C-0x0000000189748DDC
		internal X509Certificate2Impl GetNativeCertificate(byte[] data, string password, X509KeyStorageFlags flags) => default; // 0x0000000189748EEC-0x000000018974900C
		internal X509Certificate2Impl GetNativeCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate) => default; // 0x0000000189749090-0x0000000189749140
		internal X509Certificate2Impl GetNativeCertificate(byte[] data, SafePasswordHandle password, X509KeyStorageFlags flags) => default; // 0x000000018974900C-0x0000000189749090
		internal static MonoBtlsX509VerifyParam GetVerifyParam(MonoTlsSettings settings, string targetHost, bool serverMode) => default; // 0x0000000189749410-0x0000000189749598
		internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, ref System.Security.Cryptography.X509Certificates.X509Chain chain, ref SslPolicyErrors errors, ref int status11) => default; // 0x0000000189749C78-0x000000018974A1B0
		internal static bool ValidateCertificate(MonoBtlsX509Chain chain, MonoBtlsX509VerifyParam param) => default; // 0x000000018974A1B0-0x000000018974A3B4
		private void CheckValidationResult(ChainValidationHelper validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, System.Security.Cryptography.X509Certificates.X509Chain chain, MonoBtlsX509StoreCtx storeCtx, bool success, ref SslPolicyErrors errors, ref int status11) {} // 0x0000000189748A6C-0x0000000189748B34
		internal static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags MapVerifyErrorToChainStatus(MonoBtlsX509Error code) => default; // 0x0000000189749598-0x00000001897498F0
		internal static void SetupCertificateStore(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) {} // 0x00000001897498F0-0x0000000189749C58
		private static void SetupDefaultCertificateStore(MonoBtlsX509Store store) {} // 0x0000000189749C58-0x0000000189749C78
		private static void AddUserStore(MonoBtlsX509Store store) {} // 0x0000000189748A1C-0x0000000189748A6C
		private static void AddMachineStore(MonoBtlsX509Store store) {} // 0x0000000189748994-0x00000001897489E4
		private static void AddTrustedRoots(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) {} // 0x00000001897489E4-0x0000000189748A1C
		public static X509Certificate2 CreateCertificate(MonoBtlsX509 x509) => default; // 0x0000000189748B34-0x0000000189748D3C
		public static System.Security.Cryptography.X509Certificates.X509Chain GetManagedChain(MonoBtlsX509Chain chain) => default; // 0x0000000189748E5C-0x0000000189748EEC
		public static MonoBtlsX509 GetBtlsCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate) => default; // 0x0000000189748DDC-0x0000000189748E5C
		public static MonoBtlsX509Chain GetNativeChain(System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates) => default; // 0x0000000189749140-0x0000000189749410
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate int MonoBtlsVerifyCallback(MonoBtlsX509StoreCtx ctx); // TypeDefIndex: 45440; 0x000000018102B410-0x000000018102B420

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate int MonoBtlsSelectCallback(string[] acceptableIssuers); // TypeDefIndex: 45441; 0x000000018102B410-0x000000018102B420

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate int MonoBtlsServerNameCallback(); // TypeDefIndex: 45442; 0x0000000186F0A8DC-0x0000000186F0A8EC

	internal class MonoBtlsSsl : MonoBtlsObject // TypeDefIndex: 45445
	{
		// Fields
		private MonoBtlsBio bio; // 0x20
		private PrintErrorsCallbackFunc printErrorsFunc; // 0x28
		private IntPtr printErrorsFuncPtr; // 0x30
	
		// Properties
		internal new BoringSslHandle Handle { get => default; } // 0x0000000189A24198-0x0000000189A241DC 
	
		// Nested types
		internal class BoringSslHandle : MonoBtlsObject.MonoBtlsHandle // TypeDefIndex: 45443
		{
			// Constructors
			public BoringSslHandle() {} // Dummy constructor
			public BoringSslHandle(IntPtr handle) {} // 0x000000018974040C-0x0000000189740418
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x0000000189A1E9B0-0x0000000189A1E9D4
		}
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int PrintErrorsCallbackFunc(IntPtr str, IntPtr len, IntPtr ctx); // TypeDefIndex: 45444; 0x0000000181035ED0-0x0000000181035EF0
	
		// Constructors
		public MonoBtlsSsl() {} // Dummy constructor
		public MonoBtlsSsl(MonoBtlsSslCtx ctx) {} // 0x0000000189A240C4-0x0000000189A24198
	
		// Methods
		private static extern void mono_btls_ssl_destroy(IntPtr handle); // 0x0000000189A24384-0x0000000189A243B8
		private static extern IntPtr mono_btls_ssl_new(IntPtr handle); // 0x0000000189A2464C-0x0000000189A246C4
		private static extern int mono_btls_ssl_use_certificate(IntPtr handle, IntPtr x509); // 0x0000000189A24A4C-0x0000000189A24A90
		private static extern int mono_btls_ssl_use_private_key(IntPtr handle, IntPtr key); // 0x0000000189A24A90-0x0000000189A24AD4
		private static extern int mono_btls_ssl_add_chain_certificate(IntPtr handle, IntPtr x509); // 0x0000000189A24254-0x0000000189A242D8
		private static extern int mono_btls_ssl_accept(IntPtr handle); // 0x0000000189A241DC-0x0000000189A24254
		private static extern int mono_btls_ssl_connect(IntPtr handle); // 0x0000000189A2430C-0x0000000189A24384
		private static extern int mono_btls_ssl_handshake(IntPtr handle); // 0x0000000189A245D4-0x0000000189A2464C
		private static extern void mono_btls_ssl_close(IntPtr handle); // 0x0000000189A242D8-0x0000000189A2430C
		private static extern int mono_btls_ssl_shutdown(IntPtr handle); // 0x0000000189A24A18-0x0000000189A24A4C
		private static extern void mono_btls_ssl_set_quiet_shutdown(IntPtr handle, int mode); // 0x0000000189A248D4-0x0000000189A24954
		private static extern void mono_btls_ssl_set_bio(IntPtr handle, IntPtr bio); // 0x0000000189A24850-0x0000000189A248D4
		private static extern int mono_btls_ssl_read(IntPtr handle, IntPtr data, int len); // 0x0000000189A24748-0x0000000189A247D8
		private static extern int mono_btls_ssl_write(IntPtr handle, IntPtr data, int len); // 0x0000000189A24AD4-0x0000000189A24B64
		private static extern int mono_btls_ssl_get_error(IntPtr handle, int ret_code); // 0x0000000189A24430-0x0000000189A244B0
		private static extern int mono_btls_ssl_get_version(IntPtr handle); // 0x0000000189A2455C-0x0000000189A245D4
		private static extern int mono_btls_ssl_get_cipher(IntPtr handle); // 0x0000000189A243B8-0x0000000189A24430
		private static extern IntPtr mono_btls_ssl_get_peer_certificate(IntPtr handle); // 0x0000000189A244B0-0x0000000189A244E4
		private static extern void mono_btls_ssl_print_errors_cb(IntPtr func, IntPtr ctx); // 0x0000000189A246C4-0x0000000189A24748
		private static extern int mono_btls_ssl_set_server_name(IntPtr handle, IntPtr name); // 0x0000000189A249D4-0x0000000189A24A18
		private static extern IntPtr mono_btls_ssl_get_server_name(IntPtr handle); // 0x0000000189A244E4-0x0000000189A2455C
		private static extern void mono_btls_ssl_set_renegotiate_mode(IntPtr handle, int mode); // 0x0000000189A24954-0x0000000189A249D4
		private static extern int mono_btls_ssl_renegotiate_pending(IntPtr handle); // 0x0000000189A247D8-0x0000000189A24850
		private static BoringSslHandle Create_internal(MonoBtlsSslCtx ctx) => default; // 0x0000000189A23410-0x0000000189A234E0
		public void SetBio(MonoBtlsBio bio) {} // 0x0000000189A23AE4-0x0000000189A23B50
		private Exception ThrowError([CallerMemberName] string callerName = null) => default; // 0x0000000189A23E44-0x0000000189A24040
		private MonoBtlsSslError GetError(int ret_code) => default; // 0x0000000189A2355C-0x0000000189A235D8
		public void SetCertificate(MonoBtlsX509 x509) {} // 0x0000000189A23B50-0x0000000189A23BD8
		public void SetPrivateKey(MonoBtlsKey key) {} // 0x0000000189A23BD8-0x0000000189A23C60
		public void AddIntermediateCertificate(MonoBtlsX509 x509) {} // 0x0000000189A232F8-0x0000000189A23380
		public MonoBtlsSslError Accept() => default; // 0x0000000189A232B4-0x0000000189A232F8
		public MonoBtlsSslError Connect() => default; // 0x0000000189A233CC-0x0000000189A23410
		public MonoBtlsSslError Handshake() => default; // 0x0000000189A2384C-0x0000000189A23890
		[Mono.Util.MonoPInvokeCallback(typeof(PrintErrorsCallbackFunc))]
		private static int PrintErrorsCallback(IntPtr str, IntPtr len, IntPtr ctx) => default; // 0x0000000189A23890-0x0000000189A239C8
		public string GetErrors() => default; // 0x0000000189A235D8-0x0000000189A236DC
		public void PrintErrors() {} // 0x0000000189A239C8-0x0000000189A23A38
		public MonoBtlsSslError Read(IntPtr data, ref int dataSize) => default; // 0x0000000189A23A38-0x0000000189A23AB8
		public MonoBtlsSslError Write(IntPtr data, ref int dataSize) => default; // 0x0000000189A24040-0x0000000189A240C4
		public int GetVersion() => default; // 0x0000000189A23814-0x0000000189A2384C
		public int GetCipher() => default; // 0x0000000189A234E0-0x0000000189A2355C
		public MonoBtlsX509 GetPeerCertificate() => default; // 0x0000000189A236DC-0x0000000189A2379C
		public void SetServerName(string name) {} // 0x0000000189A23CE0-0x0000000189A23DEC
		public string GetServerName() => default; // 0x0000000189A2379C-0x0000000189A23814
		public void Shutdown() {} // 0x0000000189A23DEC-0x0000000189A23E44
		public void SetQuietShutdown() {} // 0x0000000189A23C60-0x0000000189A23C9C
		protected override void Close() {} // 0x0000000189A23380-0x0000000189A233CC
		public void SetRenegotiateMode(MonoBtlsSslRenegotiateMode mode) {} // 0x0000000189A23C9C-0x0000000189A23CE0
		public bool RenegotiatePending() => default; // 0x0000000189A23AB8-0x0000000189A23AE4
	}

	internal class MonoBtlsSslCtx : MonoBtlsObject // TypeDefIndex: 45450
	{
		// Fields
		private NativeVerifyFunc verifyFunc; // 0x20
		private NativeSelectFunc selectFunc; // 0x28
		private NativeServerNameFunc serverNameFunc; // 0x30
		private IntPtr verifyFuncPtr; // 0x38
		private IntPtr selectFuncPtr; // 0x40
		private IntPtr serverNameFuncPtr; // 0x48
		private MonoBtlsVerifyCallback verifyCallback; // 0x50
		private MonoBtlsSelectCallback selectCallback; // 0x58
		private MonoBtlsServerNameCallback serverNameCallback; // 0x60
		private MonoBtlsX509Store store; // 0x68
		private GCHandle instance; // 0x70
		private IntPtr instancePtr; // 0x78
	
		// Properties
		internal new BoringSslCtxHandle Handle { get => default; } // 0x0000000189A22E70-0x0000000189A22EB4 
		public MonoBtlsX509Store CertificateStore { get => default; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
	
		// Nested types
		internal class BoringSslCtxHandle : MonoBtlsObject.MonoBtlsHandle // TypeDefIndex: 45446
		{
			// Constructors
			public BoringSslCtxHandle() {} // Dummy constructor
			public BoringSslCtxHandle(IntPtr handle) {} // 0x000000018974040C-0x0000000189740418
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x0000000189A1E998-0x0000000189A1E9B0
		}
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int NativeVerifyFunc(IntPtr instance, int preverify_ok, IntPtr ctx); // TypeDefIndex: 45447; 0x0000000181035ED0-0x0000000181035EF0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int NativeSelectFunc(IntPtr instance, int count, IntPtr sizes, IntPtr data); // TypeDefIndex: 45448; 0x000000018101C850-0x000000018101C870
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int NativeServerNameFunc(IntPtr instance); // TypeDefIndex: 45449; 0x000000018102B410-0x000000018102B420
	
		// Constructors
		public MonoBtlsSslCtx() {} // 0x0000000189A22BC4-0x0000000189A22C44
		internal MonoBtlsSslCtx(BoringSslCtxHandle handle) {} // 0x0000000189A22C44-0x0000000189A22E70
	
		// Methods
		private static extern IntPtr mono_btls_ssl_ctx_new(); // 0x0000000189A22F6C-0x0000000189A22F98
		private static extern int mono_btls_ssl_ctx_free(IntPtr handle); // 0x0000000189A22EB4-0x0000000189A22EE8
		private static extern void mono_btls_ssl_ctx_initialize(IntPtr handle, IntPtr instance); // 0x0000000189A22EE8-0x0000000189A22F6C
		private static extern void mono_btls_ssl_ctx_set_cert_verify_callback(IntPtr handle, IntPtr func, int cert_required); // 0x0000000189A22FDC-0x0000000189A2306C
		private static extern void mono_btls_ssl_ctx_set_cert_select_callback(IntPtr handle, IntPtr func); // 0x0000000189A22F98-0x0000000189A22FDC
		private static extern void mono_btls_ssl_ctx_set_min_version(IntPtr handle, int version); // 0x0000000189A231EC-0x0000000189A2322C
		private static extern void mono_btls_ssl_ctx_set_max_version(IntPtr handle, int version); // 0x0000000189A231AC-0x0000000189A231EC
		private static extern int mono_btls_ssl_ctx_set_ciphers(IntPtr handle, int count, IntPtr data, int allow_unsupported); // 0x0000000189A2306C-0x0000000189A2310C
		private static extern int mono_btls_ssl_ctx_set_verify_param(IntPtr handle, IntPtr param); // 0x0000000189A23270-0x0000000189A232B4
		private static extern int mono_btls_ssl_ctx_set_client_ca_list(IntPtr handle, int count, IntPtr sizes, IntPtr data); // 0x0000000189A2310C-0x0000000189A231AC
		private static extern void mono_btls_ssl_ctx_set_server_name_callback(IntPtr handle, IntPtr func); // 0x0000000189A2322C-0x0000000189A23270
		private int VerifyCallback(bool preverify_ok, MonoBtlsX509StoreCtx ctx) => default; // 0x0000000189A22B9C-0x0000000189A22BC4
		[Mono.Util.MonoPInvokeCallback(typeof(NativeVerifyFunc))]
		private static int NativeVerifyCallback(IntPtr instance, int preverify_ok, IntPtr store_ctx) => default; // 0x0000000189A22288-0x0000000189A22464
		[Mono.Util.MonoPInvokeCallback(typeof(NativeSelectFunc))]
		private static int NativeSelectCallback(IntPtr instance, int count, IntPtr sizes, IntPtr data) => default; // 0x0000000189A22024-0x0000000189A22174
		private static string[] CopyIssuers(int count, IntPtr sizesPtr, IntPtr dataPtr) => default; // 0x0000000189A21D48-0x0000000189A22024
		public void SetVerifyCallback(MonoBtlsVerifyCallback callback, bool client_cert_required) {} // 0x0000000189A22A98-0x0000000189A22AFC
		public void SetSelectCallback(MonoBtlsSelectCallback callback) {} // 0x0000000189A229F0-0x0000000189A22A44
		public void SetMinVersion(int version) {} // 0x0000000189A229AC-0x0000000189A229F0
		public void SetMaxVersion(int version) {} // 0x0000000189A22968-0x0000000189A229AC
		public void SetCiphers(short[] ciphers, bool allow_unsupported) {} // 0x0000000189A22464-0x0000000189A225C4
		public void SetVerifyParam(MonoBtlsX509VerifyParam param) {} // 0x0000000189A22AFC-0x0000000189A22B9C
		public void SetClientCertificateIssuers(string[] acceptableIssuers) {} // 0x0000000189A225C4-0x0000000189A22968
		public void SetServerNameCallback(MonoBtlsServerNameCallback callback) {} // 0x0000000189A22A44-0x0000000189A22A98
		[Mono.Util.MonoPInvokeCallback(typeof(NativeServerNameFunc))]
		private static int NativeServerNameCallback(IntPtr instance) => default; // 0x0000000189A22174-0x0000000189A22288
		protected override void Close() {} // 0x0000000189A21D04-0x0000000189A21D48
	}

	internal enum MonoBtlsSslError // TypeDefIndex: 45451
	{
		None = 0,
		Ssl = 1,
		WantRead = 2,
		WantWrite = 3,
		WantX509Lookup = 4,
		Syscall = 5,
		ZeroReturn = 6,
		WantConnect = 7,
		WantAccept = 8,
		WantChannelIdLookup = 9,
		PendingSession = 11,
		PendingCertificate = 12,
		WantPrivateKeyOperation = 13
	}

	[Flags]
	internal enum MonoBtlsSslRenegotiateMode // TypeDefIndex: 45452
	{
		NEVER = 0,
		ONCE = 1,
		FREELY = 2,
		IGNORE = 3
	}

	internal class MonoBtlsStream : MobileAuthenticatedStream // TypeDefIndex: 45453
	{
		// Constructors
		public MonoBtlsStream() {} // Dummy constructor
		public MonoBtlsStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) {} // 0x0000000189A24BD4-0x0000000189A24C5C
	
		// Methods
		protected override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) => default; // 0x0000000189A24B64-0x0000000189A24BD4
	}

	internal static class MonoBtlsUtils // TypeDefIndex: 45454
	{
		// Fields
		private static byte[] emailOid; // 0x00
	
		// Constructors
		static MonoBtlsUtils() {} // 0x0000000189A25244-0x0000000189A252D0
	
		// Methods
		public static bool Compare(byte[] a, byte[] b) => default; // 0x0000000189A250CC-0x0000000189A25128
		private static bool AppendEntry(StringBuilder sb, MonoBtlsX509Name name, int index, string separator, bool quotes) => default; // 0x0000000189A24C5C-0x0000000189A250CC
		public static string FormatName(MonoBtlsX509Name name, bool reversed, string separator, bool quotes) => default; // 0x0000000189A25128-0x0000000189A25244
	}

	internal class MonoBtlsX509 : MonoBtlsObject // TypeDefIndex: 45456
	{
		// Properties
		internal new BoringX509Handle Handle { get => default; } // 0x0000000189A2A218-0x0000000189A2A25C 
	
		// Nested types
		internal class BoringX509Handle : MonoBtlsObject.MonoBtlsHandle // TypeDefIndex: 45455
		{
			// Constructors
			public BoringX509Handle() {} // Dummy constructor
			public BoringX509Handle(IntPtr handle) {} // 0x000000018974040C-0x0000000189740418
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x0000000189A1E9EC-0x0000000189A1EA0C
			public IntPtr StealHandle() => default; // 0x0000000183D75DE0-0x0000000183D75DF0
		}
	
		// Constructors
		public MonoBtlsX509() {} // Dummy constructor
		internal MonoBtlsX509(BoringX509Handle handle) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		private static extern IntPtr mono_btls_x509_up_ref(IntPtr handle); // 0x0000000189A2A4E8-0x0000000189A2A560
		private static extern IntPtr mono_btls_x509_from_data(IntPtr data, int len, MonoBtlsX509Format format); // 0x0000000189A2A394-0x0000000189A2A424
		private static extern IntPtr mono_btls_x509_get_subject_name(IntPtr handle); // 0x0000000189A2A4B4-0x0000000189A2A4E8
		private static extern int mono_btls_x509_get_raw_data(IntPtr handle, IntPtr bio, MonoBtlsX509Format format); // 0x0000000189A2A424-0x0000000189A2A4B4
		private static extern int mono_btls_x509_cmp(IntPtr a, IntPtr b); // 0x0000000189A2A2DC-0x0000000189A2A360
		private static extern void mono_btls_x509_free(IntPtr handle); // 0x0000000189A2A360-0x0000000189A2A394
		private static extern int mono_btls_x509_add_explicit_trust(IntPtr handle, MonoBtlsX509TrustKind kind); // 0x0000000189A2A25C-0x0000000189A2A2DC
		internal MonoBtlsX509 Copy() => default; // 0x0000000189A29A08-0x0000000189A29AE8
		public static MonoBtlsX509 LoadFromData(byte[] buffer, MonoBtlsX509Format format) => default; // 0x0000000189A29E14-0x0000000189A2A218
		public MonoBtlsX509Name GetSubjectName() => default; // 0x0000000189A29D34-0x0000000189A29E14
		public long GetSubjectNameHash() => default; // 0x0000000189A29C64-0x0000000189A29D34
		public byte[] GetRawData(MonoBtlsX509Format format) => default; // 0x0000000189A29AE8-0x0000000189A29C64
		public static int Compare(MonoBtlsX509 a, MonoBtlsX509 b) => default; // 0x0000000189A299B0-0x0000000189A29A08
		public void AddExplicitTrust(MonoBtlsX509TrustKind kind) {} // 0x0000000189A29934-0x0000000189A299B0
	}

	internal class MonoBtlsX509Chain : MonoBtlsObject // TypeDefIndex: 45458
	{
		// Properties
		internal new BoringX509ChainHandle Handle { get => default; } // 0x0000000189A25700-0x0000000189A25744 
		public int Count { get => default; } // 0x0000000189A256D8-0x0000000189A25700 
	
		// Nested types
		internal class BoringX509ChainHandle : MonoBtlsObject.MonoBtlsHandle // TypeDefIndex: 45457
		{
			// Constructors
			public BoringX509ChainHandle() {} // Dummy constructor
			public BoringX509ChainHandle(IntPtr handle) {} // 0x000000018974040C-0x0000000189740418
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x0000000189A1E9D4-0x0000000189A1E9EC
		}
	
		// Constructors
		public MonoBtlsX509Chain() {} // 0x0000000189A25658-0x0000000189A256D8
		internal MonoBtlsX509Chain(BoringX509ChainHandle handle) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		private static extern IntPtr mono_btls_x509_chain_new(); // 0x0000000189A258B4-0x0000000189A258E0
		private static extern int mono_btls_x509_chain_get_count(IntPtr handle); // 0x0000000189A2583C-0x0000000189A258B4
		private static extern IntPtr mono_btls_x509_chain_get_cert(IntPtr Handle, int index); // 0x0000000189A257BC-0x0000000189A2583C
		private static extern int mono_btls_x509_chain_add_cert(IntPtr chain, IntPtr x509); // 0x0000000189A25744-0x0000000189A25788
		private static extern IntPtr mono_btls_x509_chain_up_ref(IntPtr handle); // 0x0000000189A258E0-0x0000000189A25958
		private static extern void mono_btls_x509_chain_free(IntPtr handle); // 0x0000000189A25788-0x0000000189A257BC
		public MonoBtlsX509 GetCertificate(int index) => default; // 0x0000000189A25524-0x0000000189A25658
		public void AddCertificate(MonoBtlsX509 x509) {} // 0x0000000189A253F4-0x0000000189A25444
		internal MonoBtlsX509Chain Copy() => default; // 0x0000000189A25444-0x0000000189A25524
	}

	internal enum MonoBtlsX509Error // TypeDefIndex: 45459
	{
		OK = 0,
		UNABLE_TO_GET_ISSUER_CERT = 2,
		UNABLE_TO_GET_CRL = 3,
		UNABLE_TO_DECRYPT_CERT_SIGNATURE = 4,
		UNABLE_TO_DECRYPT_CRL_SIGNATURE = 5,
		UNABLE_TO_DECODE_ISSUER_PUBLIC_KEY = 6,
		CERT_SIGNATURE_FAILURE = 7,
		CRL_SIGNATURE_FAILURE = 8,
		CERT_NOT_YET_VALID = 9,
		CERT_HAS_EXPIRED = 10,
		CRL_NOT_YET_VALID = 11,
		CRL_HAS_EXPIRED = 12,
		ERROR_IN_CERT_NOT_BEFORE_FIELD = 13,
		ERROR_IN_CERT_NOT_AFTER_FIELD = 14,
		ERROR_IN_CRL_LAST_UPDATE_FIELD = 15,
		ERROR_IN_CRL_NEXT_UPDATE_FIELD = 16,
		OUT_OF_MEM = 17,
		DEPTH_ZERO_SELF_SIGNED_CERT = 18,
		SELF_SIGNED_CERT_IN_CHAIN = 19,
		UNABLE_TO_GET_ISSUER_CERT_LOCALLY = 20,
		UNABLE_TO_VERIFY_LEAF_SIGNATURE = 21,
		CERT_CHAIN_TOO_LONG = 22,
		CERT_REVOKED = 23,
		INVALID_CA = 24,
		PATH_LENGTH_EXCEEDED = 25,
		INVALID_PURPOSE = 26,
		CERT_UNTRUSTED = 27,
		CERT_REJECTED = 28,
		SUBJECT_ISSUER_MISMATCH = 29,
		AKID_SKID_MISMATCH = 30,
		AKID_ISSUER_SERIAL_MISMATCH = 31,
		KEYUSAGE_NO_CERTSIGN = 32,
		UNABLE_TO_GET_CRL_ISSUER = 33,
		UNHANDLED_CRITICAL_EXTENSION = 34,
		KEYUSAGE_NO_CRL_SIGN = 35,
		UNHANDLED_CRITICAL_CRL_EXTENSION = 36,
		INVALID_NON_CA = 37,
		PROXY_PATH_LENGTH_EXCEEDED = 38,
		KEYUSAGE_NO_DIGITAL_SIGNATURE = 39,
		PROXY_CERTIFICATES_NOT_ALLOWED = 40,
		INVALID_EXTENSION = 41,
		INVALID_POLICY_EXTENSION = 42,
		NO_EXPLICIT_POLICY = 43,
		DIFFERENT_CRL_SCOPE = 44,
		UNSUPPORTED_EXTENSION_FEATURE = 45,
		UNNESTED_RESOURCE = 46,
		PERMITTED_VIOLATION = 47,
		EXCLUDED_VIOLATION = 48,
		SUBTREE_MINMAX = 49,
		APPLICATION_VERIFICATION = 50,
		UNSUPPORTED_CONSTRAINT_TYPE = 51,
		UNSUPPORTED_CONSTRAINT_SYNTAX = 52,
		UNSUPPORTED_NAME_SYNTAX = 53,
		CRL_PATH_VALIDATION_ERROR = 54,
		SUITE_B_INVALID_VERSION = 56,
		SUITE_B_INVALID_ALGORITHM = 57,
		SUITE_B_INVALID_CURVE = 58,
		SUITE_B_INVALID_SIGNATURE_ALGORITHM = 59,
		SUITE_B_LOS_NOT_ALLOWED = 60,
		SUITE_B_CANNOT_SIGN_P_384_WITH_P_256 = 61,
		HOSTNAME_MISMATCH = 62,
		EMAIL_MISMATCH = 63,
		IP_ADDRESS_MISMATCH = 64
	}

	internal enum MonoBtlsX509FileType // TypeDefIndex: 45460
	{
		PEM = 1,
		ASN1 = 2,
		DEFAULT = 3
	}

	internal enum MonoBtlsX509Format // TypeDefIndex: 45461
	{
		DER = 1,
		PEM = 2
	}

	internal class MonoBtlsX509Lookup : MonoBtlsObject // TypeDefIndex: 45463
	{
		// Fields
		private MonoBtlsX509Store store; // 0x20
		private MonoBtlsX509LookupType type; // 0x28
		private List<MonoBtlsX509LookupMono> monoLookups; // 0x30
	
		// Properties
		internal new BoringX509LookupHandle Handle { get => default; } // 0x0000000189A26A14-0x0000000189A26A58 
	
		// Nested types
		internal class BoringX509LookupHandle : MonoBtlsObject.MonoBtlsHandle // TypeDefIndex: 45462
		{
			// Constructors
			public BoringX509LookupHandle() {} // Dummy constructor
			public BoringX509LookupHandle(IntPtr handle) {} // 0x000000018974040C-0x0000000189740418
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x0000000189A1EA0C-0x0000000189A1EA24
		}
	
		// Constructors
		public MonoBtlsX509Lookup() {} // Dummy constructor
		internal MonoBtlsX509Lookup(MonoBtlsX509Store store, MonoBtlsX509LookupType type) {} // 0x0000000189A269C0-0x0000000189A26A14
	
		// Methods
		private static extern IntPtr mono_btls_x509_lookup_new(IntPtr store, MonoBtlsX509LookupType type); // 0x0000000189A26BE4-0x0000000189A26C24
		private static extern int mono_btls_x509_lookup_add_dir(IntPtr handle, IntPtr dir, MonoBtlsX509FileType type); // 0x0000000189A26A58-0x0000000189A26AE8
		private static extern int mono_btls_x509_lookup_add_mono(IntPtr handle, IntPtr monoLookup); // 0x0000000189A26AE8-0x0000000189A26B6C
		private static extern void mono_btls_x509_lookup_free(IntPtr handle); // 0x0000000189A26B6C-0x0000000189A26BE4
		private static extern IntPtr mono_btls_x509_lookup_peek_lookup(IntPtr handle); // 0x0000000189A26C24-0x0000000189A26C58
		private static BoringX509LookupHandle Create_internal(MonoBtlsX509Store store, MonoBtlsX509LookupType type) => default; // 0x0000000189A268C4-0x0000000189A26998
		internal IntPtr GetNativeLookup() => default; // 0x0000000189A26998-0x0000000189A269C0
		public void AddDirectory(string dir, MonoBtlsX509FileType type) {} // 0x0000000189A26470-0x0000000189A26584
		internal void AddMono(MonoBtlsX509LookupMono monoLookup) {} // 0x0000000189A26584-0x0000000189A266F0
		internal void AddCertificate(MonoBtlsX509 certificate) {} // 0x0000000189A26450-0x0000000189A26470
		protected override void Close() {} // 0x0000000189A266F0-0x0000000189A268C4
	}

	internal abstract class MonoBtlsX509LookupMono : MonoBtlsObject // TypeDefIndex: 45466
	{
		// Fields
		private GCHandle gch; // 0x20
		private IntPtr instance; // 0x28
		private BySubjectFunc bySubjectFunc; // 0x30
		private IntPtr bySubjectFuncPtr; // 0x38
		private MonoBtlsX509Lookup lookup; // 0x40
	
		// Properties
		internal new BoringX509LookupMonoHandle Handle { get; } // 0x0000000189A2629C-0x0000000189A262E0 
	
		// Nested types
		internal class BoringX509LookupMonoHandle : MonoBtlsObject.MonoBtlsHandle // TypeDefIndex: 45464
		{
			// Constructors
			public BoringX509LookupMonoHandle() {} // Dummy constructor
			public BoringX509LookupMonoHandle(IntPtr handle) {} // 0x000000018974040C-0x0000000189740418
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x0000000189A1EA24-0x0000000189A1EA3C
		}
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int BySubjectFunc(IntPtr instance, IntPtr name, out IntPtr x509_ptr); // TypeDefIndex: 45465; 0x0000000181035ED0-0x0000000181035EF0
	
		// Constructors
		internal MonoBtlsX509LookupMono() {} // 0x0000000189A26158-0x0000000189A2629C
	
		// Methods
		private static extern IntPtr mono_btls_x509_lookup_mono_new(); // 0x0000000189A263E8-0x0000000189A26450
		private static extern void mono_btls_x509_lookup_mono_init(IntPtr handle, IntPtr instance, IntPtr by_subject_func); // 0x0000000189A26358-0x0000000189A263E8
		private static extern int mono_btls_x509_lookup_mono_free(IntPtr handle); // 0x0000000189A262E0-0x0000000189A26358
		internal void Install(MonoBtlsX509Lookup lookup) {} // 0x0000000189A25E5C-0x0000000189A25EC0
		protected void AddCertificate(MonoBtlsX509 certificate) {} // 0x0000000189A25DAC-0x0000000189A25DCC
		protected abstract MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name);
		[Mono.Util.MonoPInvokeCallback(typeof(BySubjectFunc))]
		private static int OnGetBySubject(IntPtr instance, IntPtr name_ptr, out IntPtr x509_ptr) {
			x509_ptr = default;
			return default;
		} // 0x0000000189A25EC0-0x0000000189A26158
		protected override void Close() {} // 0x0000000189A25DCC-0x0000000189A25E5C
	}

	internal class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono // TypeDefIndex: 45467
	{
		// Fields
		private long[] hashes; // 0x48
		private MonoBtlsX509[] certificates; // 0x50
		private System.Security.Cryptography.X509Certificates.X509CertificateCollection collection; // 0x58
		private MonoBtlsX509TrustKind trust; // 0x60
	
		// Constructors
		public MonoBtlsX509LookupMonoCollection() {} // Dummy constructor
		internal MonoBtlsX509LookupMonoCollection(System.Security.Cryptography.X509Certificates.X509CertificateCollection collection, MonoBtlsX509TrustKind trust) {} // 0x0000000189A25D6C-0x0000000189A25DAC
	
		// Methods
		private void Initialize() {} // 0x0000000189A25B18-0x0000000189A25CC8
		protected override MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) => default; // 0x0000000189A25CC8-0x0000000189A25D6C
		protected override void Close() {} // 0x0000000189A25958-0x0000000189A25B18
	}

	internal enum MonoBtlsX509LookupType // TypeDefIndex: 45468
	{
		UNKNOWN = 0,
		FILE = 1,
		HASH_DIR = 2,
		MONO = 3
	}

	internal class MonoBtlsX509Name : MonoBtlsObject // TypeDefIndex: 45470
	{
		// Properties
		internal new BoringX509NameHandle Handle { get => default; } // 0x0000000189A2735C-0x0000000189A273A0 
	
		// Nested types
		internal class BoringX509NameHandle : MonoBtlsObject.MonoBtlsHandle // TypeDefIndex: 45469
		{
			// Fields
			private bool dontFree; // 0x20
	
			// Constructors
			public BoringX509NameHandle() {} // Dummy constructor
			internal BoringX509NameHandle(IntPtr handle, bool ownsHandle) {} // 0x0000000189A1EA58-0x0000000189A1EA84
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x0000000189A1EA3C-0x0000000189A1EA58
		}
	
		// Constructors
		public MonoBtlsX509Name() {} // Dummy constructor
		internal MonoBtlsX509Name(BoringX509NameHandle handle) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		private static extern long mono_btls_x509_name_hash(IntPtr handle); // 0x0000000189A27770-0x0000000189A277E8
		private static extern int mono_btls_x509_name_get_entry_count(IntPtr handle); // 0x0000000189A274A8-0x0000000189A27520
		private static extern MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index); // 0x0000000189A27650-0x0000000189A276D0
		private static extern int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size); // 0x0000000189A275B0-0x0000000189A27650
		private static extern int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, out IntPtr data); // 0x0000000189A27520-0x0000000189A275B0
		private static extern int mono_btls_x509_name_get_entry_value(IntPtr name, int index, out int tag, out IntPtr str); // 0x0000000189A276D0-0x0000000189A27770
		private static unsafe extern IntPtr mono_btls_x509_name_from_data(void* data, int len, int use_canon_enc); // 0x0000000189A27418-0x0000000189A274A8
		private static extern void mono_btls_x509_name_free(IntPtr handle); // 0x0000000189A273A0-0x0000000189A27418
		public long GetHash() => default; // 0x0000000189A27334-0x0000000189A2735C
		public int GetEntryCount() => default; // 0x0000000189A26D78-0x0000000189A26DA0
		public MonoBtlsX509NameEntryType GetEntryType(int index) => default; // 0x0000000189A27008-0x0000000189A27090
		public string GetEntryOid(int index) => default; // 0x0000000189A26E7C-0x0000000189A27008
		public byte[] GetEntryOidData(int index) => default; // 0x0000000189A26DA0-0x0000000189A26E7C
		public string GetEntryValue(int index, out int tag) {
			tag = default;
			return default;
		} // 0x0000000189A27090-0x0000000189A27334
		public static MonoBtlsX509Name CreateFromData(byte[] data, bool use_canon_enc) => default; // 0x0000000189A26C58-0x0000000189A26D78
	}

	internal enum MonoBtlsX509NameEntryType // TypeDefIndex: 45471
	{
		Unknown = 0,
		CountryName = 1,
		OrganizationName = 2,
		OrganizationalUnitName = 3,
		CommonName = 4,
		LocalityName = 5,
		StateOrProvinceName = 6,
		StreetAddress = 7,
		SerialNumber = 8,
		DomainComponent = 9,
		UserId = 10,
		Email = 11,
		DnQualifier = 12,
		Title = 13,
		Surname = 14,
		GivenName = 15,
		Initial = 16
	}

	internal class MonoBtlsX509Store : MonoBtlsObject // TypeDefIndex: 45473
	{
		// Fields
		private Dictionary<IntPtr, MonoBtlsX509Lookup> lookupHash; // 0x20
	
		// Properties
		internal new BoringX509StoreHandle Handle { get => default; } // 0x0000000189A28DF8-0x0000000189A28E3C 
	
		// Nested types
		internal class BoringX509StoreHandle : MonoBtlsObject.MonoBtlsHandle // TypeDefIndex: 45472
		{
			// Constructors
			public BoringX509StoreHandle() {} // Dummy constructor
			public BoringX509StoreHandle(IntPtr handle) {} // 0x000000018974040C-0x0000000189740418
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x0000000189A1EAA0-0x0000000189A1EAB8
		}
	
		// Constructors
		internal MonoBtlsX509Store() {} // 0x0000000189A28DAC-0x0000000189A28DD0
		internal MonoBtlsX509Store(MonoBtlsSslCtx.BoringSslCtxHandle ctx) {} // 0x0000000189A28DD0-0x0000000189A28DF8
	
		// Methods
		private static extern IntPtr mono_btls_x509_store_new(); // 0x0000000189A28EE8-0x0000000189A28F14
		private static extern IntPtr mono_btls_x509_store_from_ssl_ctx(IntPtr handle); // 0x0000000189A28EB4-0x0000000189A28EE8
		private static extern int mono_btls_x509_store_add_cert(IntPtr handle, IntPtr x509); // 0x0000000189A28E3C-0x0000000189A28E80
		private static extern void mono_btls_x509_store_free(IntPtr handle); // 0x0000000189A28E80-0x0000000189A28EB4
		private static BoringX509StoreHandle Create_internal() => default; // 0x0000000189A28D00-0x0000000189A28DAC
		private static BoringX509StoreHandle Create_internal(MonoBtlsSslCtx.BoringSslCtxHandle ctx) => default; // 0x0000000189A28C44-0x0000000189A28D00
		public void AddCertificate(MonoBtlsX509 x509) {} // 0x0000000189A28764-0x0000000189A287F8
		public MonoBtlsX509Lookup AddLookup(MonoBtlsX509LookupType type) => default; // 0x0000000189A288F4-0x0000000189A28A48
		public void AddDirectoryLookup(string dir, MonoBtlsX509FileType type) {} // 0x0000000189A288B0-0x0000000189A288F4
		public void AddCollection(System.Security.Cryptography.X509Certificates.X509CertificateCollection collection, MonoBtlsX509TrustKind trust) {} // 0x0000000189A287F8-0x0000000189A288B0
		protected override void Close() {} // 0x0000000189A28A48-0x0000000189A28C44
	}

	internal class MonoBtlsX509StoreCtx : MonoBtlsObject // TypeDefIndex: 45475
	{
		// Fields
		private int? verifyResult; // 0x20
	
		// Properties
		internal new BoringX509StoreCtxHandle Handle { get => default; } // 0x0000000189A27E60-0x0000000189A27EA4 
		public int VerifyResult { get => default; } // 0x0000000189A27EA4-0x0000000189A27F34 
	
		// Nested types
		internal class BoringX509StoreCtxHandle : MonoBtlsObject.MonoBtlsHandle // TypeDefIndex: 45474
		{
			// Fields
			private bool dontFree; // 0x20
	
			// Constructors
			public BoringX509StoreCtxHandle() {} // Dummy constructor
			internal BoringX509StoreCtxHandle(IntPtr handle, bool ownsHandle = true /* Metadata: 0x01FB9DBC */) {} // 0x0000000189A1EA58-0x0000000189A1EA84
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x0000000189A1EA84-0x0000000189A1EAA0
		}
	
		// Constructors
		internal MonoBtlsX509StoreCtx() {} // 0x0000000189A27DC0-0x0000000189A27E40
		internal MonoBtlsX509StoreCtx(int preverify_ok, IntPtr store_ctx) {} // 0x0000000189A27D4C-0x0000000189A27DC0
		internal MonoBtlsX509StoreCtx(BoringX509StoreCtxHandle ptr, int? verifyResult) {} // 0x0000000189A27E40-0x0000000189A27E60
	
		// Methods
		private static extern IntPtr mono_btls_x509_store_ctx_new(); // 0x0000000189A281A0-0x0000000189A28208
		private static extern IntPtr mono_btls_x509_store_ctx_from_ptr(IntPtr ctx); // 0x0000000189A27FAC-0x0000000189A27FE0
		private static extern MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(IntPtr handle, out IntPtr error_string); // 0x0000000189A28014-0x0000000189A28098
		private static extern IntPtr mono_btls_x509_store_ctx_get_chain(IntPtr handle); // 0x0000000189A27FE0-0x0000000189A28014
		private static extern int mono_btls_x509_store_ctx_init(IntPtr handle, IntPtr store, IntPtr chain); // 0x0000000189A28110-0x0000000189A281A0
		private static extern int mono_btls_x509_store_ctx_set_param(IntPtr handle, IntPtr param); // 0x0000000189A28208-0x0000000189A2824C
		private static extern int mono_btls_x509_store_ctx_verify_cert(IntPtr handle); // 0x0000000189A28280-0x0000000189A282F8
		private static extern IntPtr mono_btls_x509_store_ctx_get_untrusted(IntPtr handle); // 0x0000000189A28098-0x0000000189A28110
		private static extern IntPtr mono_btls_x509_store_ctx_up_ref(IntPtr handle); // 0x0000000189A2824C-0x0000000189A28280
		private static extern void mono_btls_x509_store_ctx_free(IntPtr handle); // 0x0000000189A27F34-0x0000000189A27FAC
		private static BoringX509StoreCtxHandle Create_internal(IntPtr store_ctx) => default; // 0x0000000189A278D0-0x0000000189A27984
		public MonoBtlsX509Error GetError() => default; // 0x0000000189A27A64-0x0000000189A27A9C
		public MonoBtlsX509Chain GetChain() => default; // 0x0000000189A27984-0x0000000189A27A64
		public MonoBtlsX509Chain GetUntrusted() => default; // 0x0000000189A27A9C-0x0000000189A27B7C
		public void Initialize(MonoBtlsX509Store store, MonoBtlsX509Chain chain) {} // 0x0000000189A27B7C-0x0000000189A27C38
		public void SetVerifyParam(MonoBtlsX509VerifyParam param) {} // 0x0000000189A27C38-0x0000000189A27CCC
		public int Verify() => default; // 0x0000000189A27CCC-0x0000000189A27D4C
		public MonoBtlsX509StoreCtx Copy() => default; // 0x0000000189A277E8-0x0000000189A278D0
	}

	internal static class MonoBtlsX509StoreManager // TypeDefIndex: 45476
	{
		// Fields
		private static bool initialized; // 0x00
		private static string machineTrustedRootPath; // 0x08
		private static string machineIntermediateCAPath; // 0x10
		private static string machineUntrustedPath; // 0x18
		private static string userTrustedRootPath; // 0x20
		private static string userIntermediateCAPath; // 0x28
		private static string userUntrustedPath; // 0x30
	
		// Methods
		private static void Initialize() {} // 0x0000000189A285EC-0x0000000189A28764
		private static void DoInitialize() {} // 0x0000000189A282F8-0x0000000189A284D4
		public static string GetStorePath(MonoBtlsX509StoreType type) => default; // 0x0000000189A284D4-0x0000000189A285EC
	}

	internal enum MonoBtlsX509StoreType // TypeDefIndex: 45477
	{
		Custom = 0,
		MachineTrustedRoots = 1,
		MachineIntermediateCA = 2,
		MachineUntrusted = 3,
		UserTrustedRoots = 4,
		UserIntermediateCA = 5,
		UserUntrusted = 6
	}

	[Flags]
	internal enum MonoBtlsX509TrustKind // TypeDefIndex: 45478
	{
		DEFAULT = 0,
		TRUST_CLIENT = 1,
		TRUST_SERVER = 2,
		TRUST_ALL = 4,
		REJECT_CLIENT = 32,
		REJECT_SERVER = 64,
		REJECT_ALL = 128
	}

	internal class MonoBtlsX509VerifyParam : MonoBtlsObject // TypeDefIndex: 45480
	{
		// Properties
		internal new BoringX509VerifyParamHandle Handle { get => default; } // 0x0000000189A29684-0x0000000189A296C8 
		public bool CanModify { get => default; } // 0x0000000189A29658-0x0000000189A29684 
	
		// Nested types
		internal class BoringX509VerifyParamHandle : MonoBtlsObject.MonoBtlsHandle // TypeDefIndex: 45479
		{
			// Constructors
			public BoringX509VerifyParamHandle() {} // Dummy constructor
			public BoringX509VerifyParamHandle(IntPtr handle) {} // 0x000000018974040C-0x0000000189740418
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x0000000189A1EAB8-0x0000000189A1EAD0
		}
	
		// Constructors
		public MonoBtlsX509VerifyParam() {} // Dummy constructor
		internal MonoBtlsX509VerifyParam(BoringX509VerifyParamHandle handle) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		private static extern IntPtr mono_btls_x509_verify_param_copy(IntPtr handle); // 0x0000000189A29740-0x0000000189A29774
		private static extern IntPtr mono_btls_x509_verify_param_lookup(IntPtr name); // 0x0000000189A297EC-0x0000000189A29820
		private static extern int mono_btls_x509_verify_param_can_modify(IntPtr param); // 0x0000000189A296C8-0x0000000189A29740
		private static extern int mono_btls_x509_verify_param_set_host(IntPtr handle, IntPtr name, int namelen); // 0x0000000189A29820-0x0000000189A298B0
		private static extern int mono_btls_x509_verify_param_set_time(IntPtr handle, long time); // 0x0000000189A298B0-0x0000000189A29934
		private static extern void mono_btls_x509_verify_param_free(IntPtr handle); // 0x0000000189A29774-0x0000000189A297EC
		public MonoBtlsX509VerifyParam Copy() => default; // 0x0000000189A28F14-0x0000000189A28FF4
		public static MonoBtlsX509VerifyParam GetSslClient() => default; // 0x0000000189A28FF4-0x0000000189A2902C
		public static MonoBtlsX509VerifyParam GetSslServer() => default; // 0x0000000189A2902C-0x0000000189A29064
		public static MonoBtlsX509VerifyParam Lookup(string name, bool fail = false /* Metadata: 0x01FB9DCD */) => default; // 0x0000000189A29064-0x0000000189A293C4
		private void WantToModify() {} // 0x0000000189A295EC-0x0000000189A29658
		public void SetHost(string name) {} // 0x0000000189A293C4-0x0000000189A294DC
		public void SetTime(System.DateTime time) {} // 0x0000000189A294DC-0x0000000189A295EC
	}

	internal class X509CertificateImplBtls : X509Certificate2ImplUnix // TypeDefIndex: 45481
	{
		// Fields
		private MonoBtlsX509 x509; // 0xB0
		private MonoBtlsKey nativePrivateKey; // 0xB8
		private X509CertificateImplCollection intermediateCerts; // 0xC0
	
		// Properties
		public override bool IsValid { get => default; } // 0x0000000189A30880-0x0000000189A308A0 
		internal MonoBtlsX509 X509 { get => default; } // 0x0000000189A308C0-0x0000000189A308E0 
		internal MonoBtlsKey NativePrivateKey { get => default; } // 0x0000000189A308A0-0x0000000189A308C0 
		internal override X509CertificateImplCollection IntermediateCertificates { get => default; } // 0x0000000183D50E60-0x0000000183D50E70 
		public override bool HasPrivateKey { get => default; } // 0x00000001898CFEDC-0x00000001898CFEE8 
		public override AsymmetricAlgorithm PrivateKey { get => default; set {} } // 0x0000000189A2F9A8-0x0000000189A2F9DC 0x0000000189A308E0-0x0000000189A309E4
	
		// Constructors
		public X509CertificateImplBtls() {} // Dummy constructor
		internal X509CertificateImplBtls(MonoBtlsX509 x509) {} // 0x0000000189A30360-0x0000000189A3039C
		private X509CertificateImplBtls(X509CertificateImplBtls other) {} // 0x0000000189A3039C-0x0000000189A30454
		internal X509CertificateImplBtls(byte[] data, MonoBtlsX509Format format) {} // 0x0000000189A30454-0x0000000189A30488
		internal X509CertificateImplBtls(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) {} // 0x0000000189A30488-0x0000000189A30880
	
		// Methods
		public override X509CertificateImpl Clone() => default; // 0x0000000189A2F8AC-0x0000000189A2F918
		protected override byte[] GetRawCertData() => default; // 0x0000000189A2F9DC-0x0000000189A2FA1C
		protected override void Dispose(bool disposing) {} // 0x0000000189A2F918-0x0000000189A2F95C
		public override RSA GetRSAPrivateKey() => default; // 0x0000000189A2F9A8-0x0000000189A2F9DC
		public override DSA GetDSAPrivateKey() => default; // 0x0000000189A2F95C-0x0000000189A2F9A8
		private void Import(byte[] data) {} // 0x0000000189A3012C-0x0000000189A30184
		private void ImportPkcs12(byte[] data, SafePasswordHandle password) {} // 0x0000000189A2FAA8-0x0000000189A3012C
		private void ImportAuthenticode(byte[] data) {} // 0x0000000189A2FA1C-0x0000000189A2FAA8
		public override bool Verify(X509Certificate2 thisCertificate) => default; // 0x0000000189A30184-0x0000000189A30360
	}

	internal class X509ChainImplBtls : X509ChainImpl // TypeDefIndex: 45482
	{
		// Fields
		private MonoBtlsX509StoreCtx storeCtx; // 0x10
		private MonoBtlsX509Chain chain; // 0x18
		private MonoBtlsX509Chain untrustedChain; // 0x20
		private X509ChainElementCollection elements; // 0x28
		private X509Certificate2Collection untrusted; // 0x30
		private X509Certificate2[] certificates; // 0x38
		private X509ChainPolicy policy; // 0x40
		private List<X509ChainStatus> chainStatusList; // 0x48
	
		// Properties
		public override bool IsValid { get => default; } // 0x0000000189A31280-0x0000000189A31298 
		internal MonoBtlsX509StoreCtx StoreCtx { get => default; } // 0x0000000189A31298-0x0000000189A312B4 
		public override X509ChainElementCollection ChainElements { get => default; } // 0x0000000189A30FBC-0x0000000189A31280 
		public override X509ChainPolicy ChainPolicy { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
	
		// Constructors
		public X509ChainImplBtls() {} // Dummy constructor
		internal X509ChainImplBtls(MonoBtlsX509Chain chain) {} // 0x0000000189A30F38-0x0000000189A30FBC
		internal X509ChainImplBtls(MonoBtlsX509StoreCtx storeCtx) {} // 0x0000000189A30C74-0x0000000189A30F38
	
		// Methods
		public override void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags errorCode) {} // 0x0000000189A309E4-0x0000000189A30AC0
		public override bool Build(X509Certificate2 certificate) => default; // 0x000000018115F4C0-0x000000018115F530
		public override void Reset() {} // 0x0000000189A30BE8-0x0000000189A30C74
		protected override void Dispose(bool disposing) {} // 0x0000000189A30AC0-0x0000000189A30BE8
	}

	internal class X509PalImplBtls : X509PalImpl // TypeDefIndex: 45483
	{
		// Properties
		private MonoBtlsProvider Provider { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public X509PalImplBtls() {} // Dummy constructor
		public X509PalImplBtls(MonoTlsProvider provider) {} // 0x0000000189A31328-0x0000000189A313A4
	
		// Methods
		public override X509CertificateImpl Import(byte[] data) => default; // 0x0000000189A312FC-0x0000000189A31328
		public override X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) => default; // 0x0000000189A312B4-0x0000000189A312DC
		public override X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert) => default; // 0x0000000189A312DC-0x0000000189A312FC
	}
}

namespace Mono.Http
{
	internal class NtlmSession // TypeDefIndex: 45418
	{
		// Fields
		private MessageBase message; // 0x10
	
		// Constructors
		public NtlmSession() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) => default; // 0x000000018974C128-0x000000018974C4E4
	}

	internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 45420
	{
		// Fields
		private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache; // 0x00
	
		// Properties
		public string AuthenticationType { get => default; } // 0x000000018974C0FC-0x000000018974C128 
	
		// Constructors
		public NtlmClient() {} // 0x000000018350B670-0x000000018350B680
		static NtlmClient() {} // 0x000000018974C070-0x000000018974C0FC
	
		// Methods
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) => default; // 0x000000018974BC98-0x000000018974C070
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) => default; // 0x0000000181002730-0x0000000181002740
	}
}

namespace Mono.Net.Security
{
	internal class BufferOffsetSize // TypeDefIndex: 45384
	{
		// Fields
		public byte[] Buffer; // 0x10
		public int Offset; // 0x18
		public int Size; // 0x1C
		public int TotalBytes; // 0x20
		public bool Complete; // 0x24
	
		// Properties
		public int EndOffset { get => default; } // 0x0000000183D753D0-0x0000000183D753E0 
		public int Remaining { get => default; } // 0x00000001897407EC-0x0000000189740810 
	
		// Constructors
		public BufferOffsetSize() {} // Dummy constructor
		public BufferOffsetSize(byte[] buffer, int offset, int size) {} // 0x00000001897406AC-0x00000001897407EC
	
		// Methods
		public override string ToString() => default; // 0x0000000189740624-0x00000001897406AC
	}

	internal class BufferOffsetSize2 : Mono.Net.Security.BufferOffsetSize // TypeDefIndex: 45385
	{
		// Fields
		public readonly int InitialSize; // 0x28
	
		// Constructors
		public BufferOffsetSize2() {} // Dummy constructor
		public BufferOffsetSize2(int size) {} // 0x00000001897405C4-0x0000000189740624
	
		// Methods
		public void Reset() {} // 0x000000018974056C-0x00000001897405C4
		public void MakeRoom(int size) {} // 0x00000001897404B0-0x000000018974056C
		public void AppendData(byte[] buffer, int offset, int size) {} // 0x0000000189740448-0x00000001897404B0
	}

	internal enum AsyncOperationStatus // TypeDefIndex: 45386
	{
		Initialize = 0,
		Continue = 1,
		ReadDone = 2,
		Complete = 3
	}

	internal class AsyncProtocolResult // TypeDefIndex: 45387
	{
		// Properties
		public int UserResult { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public ExceptionDispatchInfo Error { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public AsyncProtocolResult() {} // Dummy constructor
		public AsyncProtocolResult(int result) {} // 0x00000001810410F0-0x0000000181041100
		public AsyncProtocolResult(ExceptionDispatchInfo error) {} // 0x00000001822C3A90-0x00000001822C3AA0
	}

	internal abstract class AsyncProtocolRequest // TypeDefIndex: 45391
	{
		// Fields
		private int Started; // 0x20
		private int RequestedSize; // 0x24
		private int WriteRequested; // 0x28
		private readonly object locker; // 0x30
	
		// Properties
		public MobileAuthenticatedStream Parent { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public bool RunSynchronously { get; } // 0x0000000181002A50-0x0000000181002A60 
		public string Name { get; } // 0x000000018973FF64-0x000000018973FF90 
		public int UserResult { get; protected set; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
	
		// Constructors
		protected AsyncProtocolRequest() {} // Dummy constructor
		public AsyncProtocolRequest(MobileAuthenticatedStream parent, bool sync) {} // 0x000000018973FEE8-0x000000018973FF64
	
		// Methods
		internal void RequestRead(int size) {} // 0x000000018973FD04-0x000000018973FDB0
		internal void RequestWrite() {} // 0x0000000183D5CB10-0x0000000183D5CB20
		internal async Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) => default; // 0x000000018973FDB0-0x000000018973FEA0
		private async System.Threading.Tasks.Task ProcessOperation(CancellationToken cancellationToken) => default; // 0x000000018973FC30-0x000000018973FD04
		private async Task<int?> InnerRead(CancellationToken cancellationToken) => default; // 0x000000018973FB40-0x000000018973FC30
		protected abstract AsyncOperationStatus Run(AsyncOperationStatus status);
		public override string ToString() => default; // 0x000000018973FEA0-0x000000018973FEE8
	}

	internal class AsyncHandshakeRequest : AsyncProtocolRequest // TypeDefIndex: 45392
	{
		// Constructors
		public AsyncHandshakeRequest() {} // Dummy constructor
		public AsyncHandshakeRequest(MobileAuthenticatedStream parent, bool sync) {} // 0x000000018973FB38-0x000000018973FB40
	
		// Methods
		protected override AsyncOperationStatus Run(AsyncOperationStatus status) => default; // 0x000000018973FB14-0x000000018973FB38
	}

	internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest // TypeDefIndex: 45393
	{
		// Properties
		protected Mono.Net.Security.BufferOffsetSize UserBuffer { get; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		protected int CurrentSize { get; set; } // 0x0000000183D4ED80-0x0000000183D4ED90 0x0000000183D4EDB0-0x0000000183D4EDC0
	
		// Constructors
		protected AsyncReadOrWriteRequest() {} // Dummy constructor
		public AsyncReadOrWriteRequest(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) {} // 0x000000018973FFDC-0x0000000189740080
	
		// Methods
		public override string ToString() => default; // 0x000000018973FF90-0x000000018973FFDC
	}

	internal class AsyncReadRequest : AsyncReadOrWriteRequest // TypeDefIndex: 45394
	{
		// Constructors
		public AsyncReadRequest() {} // Dummy constructor
		public AsyncReadRequest(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) {} // 0x00000001897400F4-0x0000000189740104
	
		// Methods
		protected override AsyncOperationStatus Run(AsyncOperationStatus status) => default; // 0x0000000189740080-0x00000001897400F4
	}

	internal class AsyncWriteRequest : AsyncReadOrWriteRequest // TypeDefIndex: 45395
	{
		// Constructors
		public AsyncWriteRequest() {} // Dummy constructor
		public AsyncWriteRequest(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) {} // 0x00000001897400F4-0x0000000189740104
	
		// Methods
		protected override AsyncOperationStatus Run(AsyncOperationStatus status) => default; // 0x0000000189740104-0x0000000189740188
	}

	internal class ChainValidationHelper : ICertificateValidator // TypeDefIndex: 45397
	{
		// Fields
		private readonly WeakReference<SslStream> owner; // 0x10
		private readonly MonoTlsSettings settings; // 0x18
		private readonly MobileTlsProvider provider; // 0x20
		private readonly ServerCertValidationCallback certValidationCallback; // 0x28
		private readonly LocalCertSelectionCallback certSelectionCallback; // 0x30
		private readonly MonoTlsStream tlsStream; // 0x38
		private readonly HttpWebRequest request; // 0x40
	
		// Properties
		public MonoTlsSettings Settings { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public ChainValidationHelper() {} // Dummy constructor
		private ChainValidationHelper(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream) {} // 0x00000001897414D8-0x000000018974176C
	
		// Methods
		internal static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings) => default; // 0x0000000189740CEC-0x0000000189740DD4
		internal static ChainValidationHelper Create(MobileTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) => default; // 0x0000000189740C04-0x0000000189740CAC
		private static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings) => default; // 0x0000000189740DD4-0x0000000189740EB8
		private static System.Security.Cryptography.X509Certificates.X509Certificate DefaultSelectionCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers) => default; // 0x0000000189740CAC-0x0000000189740CEC
		public bool SelectClientCertificate(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers, out System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate) {
			clientCertificate = default;
			return default;
		} // 0x0000000189740F64-0x0000000189740FB8
		public ValidationResult ValidateCertificate(string host, bool serverMode, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain) => default; // 0x0000000189740FB8-0x00000001897410A8
		private ValidationResult ValidateChain(string host, bool server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, SslPolicyErrors errors) => default; // 0x00000001897410A8-0x00000001897411A8
		private ValidationResult ValidateChain(string host, bool server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, ref System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, SslPolicyErrors errors) => default; // 0x00000001897411A8-0x00000001897414D8
		private bool InvokeCallback(System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, SslPolicyErrors errors) => default; // 0x0000000189740EB8-0x0000000189740F64
	}

	internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IDisposable // TypeDefIndex: 45405
	{
		// Fields
		private MobileTlsContext xobileTlsContext; // 0x38
		private ExceptionDispatchInfo lastException; // 0x40
		private AsyncProtocolRequest asyncHandshakeRequest; // 0x48
		private AsyncProtocolRequest asyncReadRequest; // 0x50
		private AsyncProtocolRequest asyncWriteRequest; // 0x58
		private BufferOffsetSize2 readBuffer; // 0x60
		private BufferOffsetSize2 writeBuffer; // 0x68
		private object ioLock; // 0x70
		private int closeRequested; // 0x78
		private bool shutdown; // 0x7C
		private Operation operation; // 0x80
		private static int uniqueNameInteger; // 0x00
		private static int nextId; // 0x04
		internal readonly int ID; // 0xA8
	
		// Properties
		public SslStream SslStream { get; } // 0x0000000183D4EA60-0x0000000183D4EA70 
		public MonoTlsSettings Settings { get; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
		public MobileTlsProvider Provider { get; } // 0x00000001811AC510-0x00000001811AC520 
		internal string TargetHost { get; private set; } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
		public override bool IsAuthenticated { get; } // 0x0000000189743864-0x0000000189743934 
		public System.Security.Cryptography.X509Certificates.X509Certificate LocalCertificate { get; } // 0x0000000189743958-0x0000000189743A24 
		public System.Security.Cryptography.X509Certificates.X509Certificate InternalLocalCertificate { get; } // 0x0000000189743768-0x0000000189743864 
		public override bool CanRead { get; } // 0x00000001897436B0-0x00000001897436F0 
		public override bool CanTimeout { get; } // 0x00000001897436F0-0x0000000189743714 
		public override bool CanWrite { get; } // 0x0000000189743714-0x0000000189743768 
		public override bool CanSeek { get; } // 0x000000018115F4C0-0x000000018115F530 
		public override long Length { get; } // 0x0000000189743934-0x0000000189743958 
		public override long Position { get; set; } // 0x0000000189743A24-0x0000000189743A48 0x0000000189743A90-0x0000000189743ADC
		public override int ReadTimeout { get; set; } // 0x0000000189743A48-0x0000000189743A6C 0x0000000189743ADC-0x0000000189743B00
		public override int WriteTimeout { get; set; } // 0x0000000189743A6C-0x0000000189743A90 0x0000000189743B00-0x0000000189743B24
	
		// Nested types
		private enum Operation // TypeDefIndex: 45398
		{
			None = 0,
			Handshake = 1,
			Authenticated = 2,
			Renegotiate = 3,
			Read = 4,
			Write = 5,
			Close = 6
		}
	
		private enum OperationType // TypeDefIndex: 45399
		{
			Read = 0,
			Write = 1,
			Renegotiate = 2,
			Shutdown = 3
		}
	
		// Constructors
		protected MobileAuthenticatedStream() {} // Dummy constructor
		public MobileAuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) {} // 0x0000000189743538-0x00000001897436B0
		static MobileAuthenticatedStream() {} // 0x00000001897434FC-0x0000000189743538
	
		// Methods
		internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = false /* Metadata: 0x01FB9D44 */) {} // 0x0000000189741BF4-0x0000000189741CF4
		internal static Exception GetSSPIException(Exception e) => default; // 0x00000001897420E8-0x00000001897421F8
		internal static Exception GetIOException(Exception e, string message) => default; // 0x0000000189741F24-0x0000000189742030
		internal static Exception GetInternalError() => default; // 0x0000000189742030-0x000000018974208C
		internal static Exception GetInvalidNestedCallException() => default; // 0x000000018974208C-0x00000001897420E8
		internal ExceptionDispatchInfo SetException(Exception e) => default; // 0x00000001897431CC-0x0000000189743204
		public void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) {} // 0x0000000189741A3C-0x0000000189741BF4
		public System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) => default; // 0x0000000189741940-0x0000000189741A3C
		private async System.Threading.Tasks.Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken) => default; // 0x00000001897428B4-0x00000001897429B0
		protected abstract MobileTlsContext CreateContext(MonoSslAuthenticationOptions options);
		public override int Read(byte[] buffer, int offset, int count) => default; // 0x000000018974309C-0x0000000189743180
		public override void Write(byte[] buffer, int offset, int count) {} // 0x0000000189743428-0x00000001897434FC
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => default; // 0x0000000189742FEC-0x000000018974309C
		public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => default; // 0x0000000189743378-0x0000000189743428
		private async Task<int> StartOperation(OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) => default; // 0x0000000189743228-0x000000018974333C
		internal int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore) {
			outWantMore = default;
			return default;
		} // 0x000000018974252C-0x000000018974262C
		private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size) => default; // 0x00000001897423E8-0x000000018974252C
		internal bool InternalWrite(byte[] buffer, int offset, int size) => default; // 0x0000000189742704-0x00000001897428B4
		private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size) => default; // 0x000000018974262C-0x0000000189742704
		internal async Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) => default; // 0x00000001897421F8-0x0000000189742304
		internal async System.Threading.Tasks.Task InnerWrite(bool sync, CancellationToken cancellationToken) => default; // 0x0000000189742304-0x00000001897423E8
		internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate) => default; // 0x00000001897429B0-0x0000000189742D4C
		internal ValueTuple<int, bool> ProcessRead(Mono.Net.Security.BufferOffsetSize userBuffer) => default; // 0x0000000189742D4C-0x0000000189742E9C
		internal ValueTuple<int, bool> ProcessWrite(Mono.Net.Security.BufferOffsetSize userBuffer) => default; // 0x0000000189742E9C-0x0000000189742FEC
		protected override void Dispose(bool disposing) {} // 0x0000000189741CF4-0x0000000189741F00
		public override void Flush() {} // 0x0000000189741F00-0x0000000189741F24
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x0000000189743180-0x00000001897431CC
		public override void SetLength(long value) {} // 0x0000000189743204-0x0000000189743228
	}

	internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 45406
	{
		// Fields
		private ChainValidationHelper certificateValidator; // 0x10
	
		// Properties
		internal MonoSslAuthenticationOptions Options { get; } // 0x0000000181041090-0x00000001810410A0 
		internal MobileAuthenticatedStream Parent { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public MonoTlsSettings Settings { get; } // 0x0000000189744618-0x0000000189744638 
		public abstract bool IsAuthenticated { get; }
		public bool IsServer { get; } // 0x0000000183D4ED50-0x0000000183D4ED60 
		internal string TargetHost { get; } // 0x0000000181003830-0x0000000181003840 
		protected string ServerName { get; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		protected bool AskForClientCertificate { get; } // 0x0000000183D4EE90-0x0000000183D4EEA0 
		protected SslProtocols EnabledProtocols { get; } // 0x0000000183D4EE80-0x0000000183D4EE90 
		protected System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		internal System.Security.Cryptography.X509Certificates.X509Certificate LocalServerCertificate { get; private set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		internal abstract System.Security.Cryptography.X509Certificates.X509Certificate LocalClientCertificate { get; }
		public abstract X509Certificate2 RemoteCertificate { get; }
	
		// Constructors
		protected MobileTlsContext() {} // Dummy constructor
		protected MobileTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) {} // 0x000000018974448C-0x0000000189744618
	
		// Methods
		protected void GetProtocolVersions(out TlsProtocolCode? min, out TlsProtocolCode? max) {
			min = default;
			max = default;
		} // 0x0000000189743BEC-0x0000000189743CD0
		public abstract void StartHandshake();
		public abstract bool ProcessHandshake();
		public abstract void FinishHandshake();
		public abstract void Flush();
		public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);
		public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);
		public abstract void Shutdown();
		public abstract bool PendingRenegotiation();
		protected bool ValidateCertificate(X509Certificate2 leaf, System.Security.Cryptography.X509Certificates.X509Chain chain) => default; // 0x0000000189744438-0x000000018974448C
		protected System.Security.Cryptography.X509Certificates.X509Certificate SelectServerCertificate(string serverIdentity) => default; // 0x00000001897441E0-0x0000000189744438
		protected System.Security.Cryptography.X509Certificates.X509Certificate SelectClientCertificate(string[] acceptableIssuers) => default; // 0x0000000189743CD0-0x00000001897441E0
		public abstract void Renegotiate();
		public void Dispose() {} // 0x0000000189743B24-0x0000000189743B74
		protected virtual void Dispose(bool disposing) {} // 0x000000018350B670-0x000000018350B680
		~MobileTlsContext() {} // 0x0000000189743B74-0x0000000189743BEC
	}

	internal abstract class MobileTlsProvider : MonoTlsProvider // TypeDefIndex: 45407
	{
		// Constructors
		protected MobileTlsProvider() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal abstract MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);
		internal abstract bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, ref System.Security.Cryptography.X509Certificates.X509Chain chain, ref SslPolicyErrors errors, ref int status11);
	}

	internal abstract class MonoSslAuthenticationOptions // TypeDefIndex: 45408
	{
		// Properties
		public abstract bool ServerMode { get; }
		public abstract bool AllowRenegotiation { get; }
		public abstract SslProtocols EnabledSslProtocols { get; set; }
		public abstract EncryptionPolicy EncryptionPolicy { get; set; }
		public abstract X509RevocationMode CertificateRevocationCheckMode { get; set; }
		public abstract string TargetHost { get; set; }
		public abstract System.Security.Cryptography.X509Certificates.X509Certificate ServerCertificate { get; }
		public abstract System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get; set; }
		public abstract bool ClientCertificateRequired { get; }
		internal ServerCertSelectionCallback ServerCertSelectionDelegate { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		protected MonoSslAuthenticationOptions() {} // 0x000000018350B670-0x000000018350B680
	}

	internal sealed class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions // TypeDefIndex: 45409
	{
		// Properties
		public SslClientAuthenticationOptions Options { get; } // 0x0000000181041090-0x00000001810410A0 
		public override bool ServerMode { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool AllowRenegotiation { get => default; } // 0x0000000185D7C5B0-0x0000000185D7C5CC 
		public override X509RevocationMode CertificateRevocationCheckMode { set {} } // 0x000000018974A5AC-0x000000018974A5CC
		public override EncryptionPolicy EncryptionPolicy { set {} } // 0x000000018974A60C-0x000000018974A62C
		public override SslProtocols EnabledSslProtocols { get => default; set {} } // 0x00000001842709E0-0x00000001842709FC 0x000000018974A5F0-0x000000018974A60C
		public override string TargetHost { get => default; set {} } // 0x0000000185F9871C-0x0000000185F98738 0x000000018974A62C-0x000000018974A650
		public override bool ClientCertificateRequired { get => default; } // 0x000000018974A514-0x000000018974A560 
		public override System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get => default; set {} } // 0x0000000186177C5C-0x0000000186177C78 0x000000018974A5CC-0x000000018974A5F0
		public override System.Security.Cryptography.X509Certificates.X509Certificate ServerCertificate { get => default; } // 0x000000018974A560-0x000000018974A5AC 
	
		// Constructors
		public MonoSslClientAuthenticationOptions() {} // 0x000000018974A4C0-0x000000018974A514
	}

	internal static class MonoTlsProviderFactory // TypeDefIndex: 45410
	{
		// Fields
		private static object locker; // 0x00
		private static bool initialized; // 0x08
		private static MobileTlsProvider defaultProvider; // 0x10
		private static Dictionary<string, Tuple<Guid, string>> providerRegistration; // 0x18
		private static Dictionary<Guid, MobileTlsProvider> providerCache; // 0x20
		internal static readonly Guid UnityTlsId; // 0x28
		internal static readonly Guid AppleTlsId; // 0x38
		internal static readonly Guid BtlsId; // 0x48
	
		// Constructors
		static MonoTlsProviderFactory() {} // 0x000000018974B814-0x000000018974B944
	
		// Methods
		internal static MobileTlsProvider GetProviderInternal() => default; // 0x000000018974A800-0x000000018974A908
		internal static void InitializeInternal() {} // 0x000000018974A948-0x000000018974AD20
		private static MobileTlsProvider LookupProvider(string name, bool throwOnError) => default; // 0x000000018974AFCC-0x000000018974B650
		private static void InitializeProviderRegistration() {} // 0x000000018974AD20-0x000000018974AFCC
		private static void PopulateUnityProviders() {} // 0x000000018974B6E4-0x000000018974B814
		private static void PopulateProviders() {} // 0x000000018974B650-0x000000018974B6E4
		internal static bool IsBtlsSupported() => default; // 0x000000018115F4C0-0x000000018115F530
		private static MobileTlsProvider CreateDefaultProviderImpl() => default; // 0x000000018974A650-0x000000018974A800
		internal static MobileTlsProvider GetProvider() => default; // 0x000000018974A908-0x000000018974A948
	}

	internal class MonoTlsStream : IDisposable // TypeDefIndex: 45412
	{
		// Fields
		private readonly MobileTlsProvider provider; // 0x10
		private readonly NetworkStream networkStream; // 0x18
		private readonly HttpWebRequest request; // 0x20
		private readonly MonoTlsSettings settings; // 0x28
		private SslStream sslStream; // 0x30
		private readonly object sslStreamLock; // 0x38
		private WebExceptionStatus status; // 0x40
	
		// Properties
		internal HttpWebRequest Request { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		internal WebExceptionStatus ExceptionStatus { get => default; } // 0x0000000183D4ED80-0x0000000183D4ED90 
		internal bool CertificateValidationFailed { get; set; } // 0x0000000183D4F170-0x0000000183D4F180 0x0000000183D4F180-0x0000000183D4F190
	
		// Constructors
		public MonoTlsStream() {} // Dummy constructor
		public MonoTlsStream(HttpWebRequest request, NetworkStream networkStream) {} // 0x000000018974BB68-0x000000018974BC58
	
		// Methods
		internal async Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) => default; // 0x000000018974BA58-0x000000018974BB60
		public void Dispose() {} // 0x000000018974BB60-0x000000018974BB68
		private void CloseSslStream() {} // 0x000000018974B944-0x000000018974BA58
	}

	internal static class NoReflectionHelper // TypeDefIndex: 45413
	{
		// Methods
		internal static object GetProvider() => default; // 0x000000018974BC58-0x000000018974BC98
	}

	internal static class SystemCertificateValidator // TypeDefIndex: 45414
	{
		// Fields
		private static bool is_macosx; // 0x00
		private static X509KeyUsageFlags s_flags; // 0x04
	
		// Constructors
		static SystemCertificateValidator() {} // 0x000000018974CBEC-0x000000018974CC38
	
		// Methods
		internal static bool NeedsChain(MonoTlsSettings settings) => default; // 0x000000018115F4C0-0x000000018115F530
	}
}

namespace Mono.Net.Security.Private
{
	internal static class CallbackHelpers // TypeDefIndex: 45417
	{
		// Methods
		internal static MonoRemoteCertificateValidationCallback PublicToMono(RemoteCertificateValidationCallback callback) => default; // 0x00000001897408BC-0x0000000189740968
		internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback) => default; // 0x0000000189740810-0x00000001897408BC
	}
}

namespace Mono.Unity
{
	internal static class CertHelper // TypeDefIndex: 45325
	{
		// Methods
		public static unsafe void AddCertificatesToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, UnityTls.unitytls_errorstate* errorState) {} // 0x0000000189740AD4-0x0000000189740C04
		public static unsafe void AddCertificateToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509Certificate certificate, UnityTls.unitytls_errorstate* errorState) {} // 0x0000000189740968-0x0000000189740AD4
	}

	internal static class Debug // TypeDefIndex: 45326
	{
		// Methods
		public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, string context, AlertDescription defaultAlert = AlertDescription.InternalError /* Metadata: 0x01FB9CE2 */) {} // 0x0000000189741880-0x0000000189741940
		public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, UnityTls.unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = AlertDescription.InternalError /* Metadata: 0x01FB9CE3 */) {} // 0x000000018974176C-0x0000000189741880
	}

	internal static class UnityTls // TypeDefIndex: 45378
	{
		// Fields
		private static unitytls_interface_struct marshalledInterface; // 0x00
	
		// Properties
		public static bool IsSupported { get; } // 0x0000000189753B68-0x0000000189753B80 
		public static unitytls_interface_struct NativeInterface { get; } // 0x0000000189753B80-0x0000000189753C34 
	
		// Nested types
		public enum unitytls_error_code : uint // TypeDefIndex: 45327
		{
			UNITYTLS_SUCCESS = 0,
			UNITYTLS_INVALID_ARGUMENT = 1,
			UNITYTLS_INVALID_FORMAT = 2,
			UNITYTLS_INVALID_PASSWORD = 3,
			UNITYTLS_INVALID_STATE = 4,
			UNITYTLS_BUFFER_OVERFLOW = 5,
			UNITYTLS_OUT_OF_MEMORY = 6,
			UNITYTLS_INTERNAL_ERROR = 7,
			UNITYTLS_NOT_SUPPORTED = 8,
			UNITYTLS_ENTROPY_SOURCE_FAILED = 9,
			UNITYTLS_STREAM_CLOSED = 10,
			UNITYTLS_USER_CUSTOM_ERROR_START = 1048576,
			UNITYTLS_USER_WOULD_BLOCK = 1048577,
			UNITYTLS_USER_READ_FAILED = 1048578,
			UNITYTLS_USER_WRITE_FAILED = 1048579,
			UNITYTLS_USER_UNKNOWN_ERROR = 1048580,
			UNITYTLS_USER_CUSTOM_ERROR_END = 2097152
		}
	
		public struct unitytls_errorstate // TypeDefIndex: 45328
		{
			// Fields
			private uint magic; // 0x00
			public unitytls_error_code code; // 0x04
			private ulong reserved; // 0x08
		}
	
		public struct unitytls_key // TypeDefIndex: 45329
		{
		}
	
		public struct unitytls_key_ref // TypeDefIndex: 45330
		{
			// Fields
			public ulong handle; // 0x00
		}
	
		public struct unitytls_x509_ref // TypeDefIndex: 45331
		{
			// Fields
			public ulong handle; // 0x00
		}
	
		public struct unitytls_x509list // TypeDefIndex: 45332
		{
		}
	
		public struct unitytls_x509list_ref // TypeDefIndex: 45333
		{
			// Fields
			public ulong handle; // 0x00
		}
	
		[Flags]
		public enum unitytls_x509verify_result : uint // TypeDefIndex: 45334
		{
			UNITYTLS_X509VERIFY_SUCCESS = 0,
			UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1,
			UNITYTLS_X509VERIFY_FLAG_REVOKED = 2,
			UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4,
			UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8,
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536,
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072,
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144,
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288,
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576,
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152,
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304,
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608,
			UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728,
			UNITYTLS_X509VERIFY_NOT_DONE = 2147483648,
			UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295
		}
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate unitytls_x509verify_result unitytls_x509verify_callback(void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState); // TypeDefIndex: 45335; 0x000000018101C850-0x000000018101C870
	
		public struct unitytls_tlsctx // TypeDefIndex: 45336
		{
		}
	
		public struct unitytls_x509name // TypeDefIndex: 45337
		{
		}
	
		public enum unitytls_ciphersuite : uint // TypeDefIndex: 45338
		{
			UNITYTLS_CIPHERSUITE_INVALID = 16777215
		}
	
		public enum unitytls_protocol : uint // TypeDefIndex: 45339
		{
			UNITYTLS_PROTOCOL_TLS_1_0 = 0,
			UNITYTLS_PROTOCOL_TLS_1_1 = 1,
			UNITYTLS_PROTOCOL_TLS_1_2 = 2,
			UNITYTLS_PROTOCOL_INVALID = 3
		}
	
		public struct unitytls_tlsctx_protocolrange // TypeDefIndex: 45340
		{
			// Fields
			public unitytls_protocol min; // 0x00
			public unitytls_protocol max; // 0x04
		}
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate IntPtr unitytls_tlsctx_write_callback(void* userData, byte* data, IntPtr bufferLen, unitytls_errorstate* errorState); // TypeDefIndex: 45341; 0x000000018101C850-0x000000018101C870
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate IntPtr unitytls_tlsctx_read_callback(void* userData, byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState); // TypeDefIndex: 45342; 0x000000018101C850-0x000000018101C870
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void unitytls_tlsctx_trace_callback(void* userData, unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen); // TypeDefIndex: 45343; 0x0000000182097E50-0x0000000182097E70
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void unitytls_tlsctx_certificate_callback(void* userData, unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState); // TypeDefIndex: 45344; 0x000000018500A684-0x000000018500A6EC
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate unitytls_x509verify_result unitytls_tlsctx_x509verify_callback(void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState); // TypeDefIndex: 45345; 0x0000000181035ED0-0x0000000181035EF0
	
		public struct unitytls_tlsctx_callbacks // TypeDefIndex: 45346
		{
			// Fields
			public unitytls_tlsctx_read_callback read; // 0x00
			public unitytls_tlsctx_write_callback write; // 0x08
			public unsafe void* data; // 0x10
		}
	
		public class unitytls_interface_struct // TypeDefIndex: 45377
		{
			// Fields
			public readonly ulong UNITYTLS_INVALID_HANDLE; // 0x10
			public readonly unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT; // 0x18
			public unitytls_errorstate_create_t unitytls_errorstate_create; // 0x20
			public unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error; // 0x28
			public unitytls_key_get_ref_t unitytls_key_get_ref; // 0x30
			public unitytls_key_parse_der_t unitytls_key_parse_der; // 0x38
			public unitytls_key_parse_pem_t unitytls_key_parse_pem; // 0x40
			public unitytls_key_free_t unitytls_key_free; // 0x48
			public unitytls_x509_export_der_t unitytls_x509_export_der; // 0x50
			public unitytls_x509list_get_ref_t unitytls_x509list_get_ref; // 0x58
			public unitytls_x509list_get_x509_t unitytls_x509list_get_x509; // 0x60
			public unitytls_x509list_create_t unitytls_x509list_create; // 0x68
			public unitytls_x509list_append_t unitytls_x509list_append; // 0x70
			public unitytls_x509list_append_der_t unitytls_x509list_append_der; // 0x78
			public unitytls_x509list_append_der_t unitytls_x509list_append_pem; // 0x80
			public unitytls_x509list_free_t unitytls_x509list_free; // 0x88
			public unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca; // 0x90
			public unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca; // 0x98
			public unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server; // 0xA0
			public unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client; // 0xA8
			public unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication; // 0xB0
			public unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback; // 0xB8
			public unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback; // 0xC0
			public unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback; // 0xC8
			public unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites; // 0xD0
			public unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite; // 0xD8
			public unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol; // 0xE0
			public unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake; // 0xE8
			public unitytls_tlsctx_read_t unitytls_tlsctx_read; // 0xF0
			public unitytls_tlsctx_write_t unitytls_tlsctx_write; // 0xF8
			public unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close; // 0x100
			public unitytls_tlsctx_free_t unitytls_tlsctx_free; // 0x108
			public unitytls_random_generate_bytes_t unitytls_random_generate_bytes; // 0x110
	
			// Nested types
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public delegate unitytls_errorstate unitytls_errorstate_create_t(); // TypeDefIndex: 45347; 0x00000001836315C0-0x00000001836315F0
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_errorstate_raise_error_t(unitytls_errorstate* errorState, unitytls_error_code errorCode); // TypeDefIndex: 45348; 0x0000000182065C10-0x0000000182065C20
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate unitytls_key_ref unitytls_key_get_ref_t(unitytls_key* key, unitytls_errorstate* errorState); // TypeDefIndex: 45349; 0x0000000181165340-0x0000000181165350
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate unitytls_key* unitytls_key_parse_der_t(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, unitytls_errorstate* errorState); // TypeDefIndex: 45350; 0x000000018101FB20-0x000000018101FB40
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate unitytls_key* unitytls_key_parse_pem_t(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, unitytls_errorstate* errorState); // TypeDefIndex: 45351; 0x000000018101FB20-0x000000018101FB40
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_key_free_t(unitytls_key* key); // TypeDefIndex: 45352; 0x0000000182149960-0x0000000182149970
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate IntPtr unitytls_x509_export_der_t(unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState); // TypeDefIndex: 45353; 0x000000018101C850-0x000000018101C870
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate unitytls_x509list_ref unitytls_x509list_get_ref_t(unitytls_x509list* list, unitytls_errorstate* errorState); // TypeDefIndex: 45354; 0x0000000181165340-0x0000000181165350
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate unitytls_x509_ref unitytls_x509list_get_x509_t(unitytls_x509list_ref list, IntPtr index, unitytls_errorstate* errorState); // TypeDefIndex: 45355; 0x0000000181035ED0-0x0000000181035EF0
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate unitytls_x509list* unitytls_x509list_create_t(unitytls_errorstate* errorState); // TypeDefIndex: 45356; 0x000000018102B410-0x000000018102B420
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_x509list_append_t(unitytls_x509list* list, unitytls_x509_ref cert, unitytls_errorstate* errorState); // TypeDefIndex: 45357; 0x00000001811360D0-0x00000001811360F0
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_x509list_append_der_t(unitytls_x509list* list, byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState); // TypeDefIndex: 45358; 0x0000000182097E50-0x0000000182097E70
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_x509list_free_t(unitytls_x509list* list); // TypeDefIndex: 45359; 0x0000000182149960-0x0000000182149970
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate unitytls_x509verify_result unitytls_x509verify_default_ca_t(unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, void* userData, unitytls_errorstate* errorState); // TypeDefIndex: 45360; 0x00000001810198A0-0x00000001810198C0
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate unitytls_x509verify_result unitytls_x509verify_explicit_ca_t(unitytls_x509list_ref chain, unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, void* userData, unitytls_errorstate* errorState); // TypeDefIndex: 45361; 0x0000000182121030-0x0000000182121050
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate unitytls_tlsctx* unitytls_tlsctx_create_server_t(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, unitytls_errorstate* errorState); // TypeDefIndex: 45362; 0x0000000189754E10-0x0000000189754E64
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate unitytls_tlsctx* unitytls_tlsctx_create_client_t(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, unitytls_errorstate* errorState); // TypeDefIndex: 45363; 0x0000000189754E10-0x0000000189754E64
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_server_require_client_authentication_t(unitytls_tlsctx* ctx, unitytls_x509list_ref clientAuthCAList, unitytls_errorstate* errorState); // TypeDefIndex: 45364; 0x00000001811360D0-0x00000001811360F0
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_set_certificate_callback_t(unitytls_tlsctx* ctx, unitytls_tlsctx_certificate_callback cb, void* userData, unitytls_errorstate* errorState); // TypeDefIndex: 45365; 0x0000000182097E50-0x0000000182097E70
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_set_trace_callback_t(unitytls_tlsctx* ctx, unitytls_tlsctx_trace_callback cb, void* userData, unitytls_errorstate* errorState); // TypeDefIndex: 45366; 0x0000000182097E50-0x0000000182097E70
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_set_x509verify_callback_t(unitytls_tlsctx* ctx, unitytls_tlsctx_x509verify_callback cb, void* userData, unitytls_errorstate* errorState); // TypeDefIndex: 45367; 0x0000000182097E50-0x0000000182097E70
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_set_supported_ciphersuites_t(unitytls_tlsctx* ctx, unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, unitytls_errorstate* errorState); // TypeDefIndex: 45368; 0x0000000182097E50-0x0000000182097E70
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate unitytls_ciphersuite unitytls_tlsctx_get_ciphersuite_t(unitytls_tlsctx* ctx, unitytls_errorstate* errorState); // TypeDefIndex: 45369; 0x0000000181165340-0x0000000181165350
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate unitytls_protocol unitytls_tlsctx_get_protocol_t(unitytls_tlsctx* ctx, unitytls_errorstate* errorState); // TypeDefIndex: 45370; 0x0000000181165340-0x0000000181165350
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate unitytls_x509verify_result unitytls_tlsctx_process_handshake_t(unitytls_tlsctx* ctx, unitytls_errorstate* errorState); // TypeDefIndex: 45371; 0x0000000181165340-0x0000000181165350
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate IntPtr unitytls_tlsctx_read_t(unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState); // TypeDefIndex: 45372; 0x000000018101C850-0x000000018101C870
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate IntPtr unitytls_tlsctx_write_t(unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, unitytls_errorstate* errorState); // TypeDefIndex: 45373; 0x000000018101C850-0x000000018101C870
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_notify_close_t(unitytls_tlsctx* ctx, unitytls_errorstate* errorState); // TypeDefIndex: 45374; 0x0000000182065C10-0x0000000182065C20
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_tlsctx_free_t(unitytls_tlsctx* ctx); // TypeDefIndex: 45375; 0x0000000182149960-0x0000000182149970
	
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			public unsafe delegate void unitytls_random_generate_bytes_t(byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState); // TypeDefIndex: 45376; 0x00000001811360D0-0x00000001811360F0
	
			// Constructors
			public unitytls_interface_struct() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Methods
		private static IntPtr GetUnityTlsInterface() => default; // 0x0000000183D753F0-0x0000000183D75400
	}

	internal class UnityTlsContext : MobileTlsContext // TypeDefIndex: 45379
	{
		// Fields
		private unsafe UnityTls.unitytls_tlsctx* tlsContext; // 0x58
		private unsafe UnityTls.unitytls_x509list* requestedClientCertChain; // 0x60
		private unsafe UnityTls.unitytls_key* requestedClientKey; // 0x68
		private UnityTls.unitytls_tlsctx_read_callback readCallback; // 0x70
		private UnityTls.unitytls_tlsctx_write_callback writeCallback; // 0x78
		private UnityTls.unitytls_tlsctx_certificate_callback certificateCallback; // 0x80
		private UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback; // 0x88
		private System.Security.Cryptography.X509Certificates.X509Certificate localClientCertificate; // 0x90
		private X509Certificate2 remoteCertificate; // 0x98
		private MonoTlsConnectionInfo connectioninfo; // 0xA0
		private bool isAuthenticated; // 0xA8
		private bool hasContext; // 0xA9
		private bool closedGraceful; // 0xAA
		private byte[] writeBuffer; // 0xB0
		private byte[] readBuffer; // 0xB8
		private GCHandle handle; // 0xC0
		private Exception lastException; // 0xC8
	
		// Properties
		public override bool IsAuthenticated { get => default; } // 0x00000001811B9C10-0x00000001811B9C20 
		internal override System.Security.Cryptography.X509Certificates.X509Certificate LocalClientCertificate { get => default; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
		public override X509Certificate2 RemoteCertificate { get => default; } // 0x00000001811AC510-0x00000001811AC520 
	
		// Constructors
		public UnityTlsContext() {} // Dummy constructor
		public UnityTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) {} // 0x0000000189752054-0x0000000189752B6C
	
		// Methods
		private static unsafe void ExtractNativeKeyAndChainFromManagedCertificate(System.Security.Cryptography.X509Certificates.X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey) {
			nativeCertChain = default;
			nativeKey = default;
		} // 0x000000018975097C-0x0000000189750D28
		public override void Flush() {} // 0x000000018350B670-0x000000018350B680
		public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) => default; // 0x000000018975134C-0x00000001897514EC
		public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) => default; // 0x0000000189751EBC-0x0000000189752054
		public override void Renegotiate() {} // 0x00000001897514EC-0x0000000189751538
		public override bool PendingRenegotiation() => default; // 0x000000018115F4C0-0x000000018115F530
		public override void Shutdown() {} // 0x0000000189751538-0x000000018975165C
		protected override void Dispose(bool disposing) {} // 0x00000001897506C4-0x000000018975097C
		public override void StartHandshake() {} // 0x000000018975165C-0x000000018975180C
		public override bool ProcessHandshake() => default; // 0x0000000189750E6C-0x0000000189751028
		public override void FinishHandshake() {} // 0x0000000189750D28-0x0000000189750E6C
		[Mono.Util.MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_write_callback))]
		private static unsafe IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) => default; // 0x0000000189751E0C-0x0000000189751EBC
		private unsafe IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) => default; // 0x0000000189751C14-0x0000000189751E0C
		[Mono.Util.MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_read_callback))]
		private static unsafe IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) => default; // 0x0000000189751028-0x00000001897510D8
		private unsafe IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) => default; // 0x00000001897510D8-0x000000018975134C
		[Mono.Util.MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_x509verify_callback))]
		private static unsafe UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) => default; // 0x0000000189751B78-0x0000000189751C14
		private unsafe UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) => default; // 0x000000018975180C-0x0000000189751B78
		[Mono.Util.MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_certificate_callback))]
		private static unsafe void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) {} // 0x00000001897505D4-0x00000001897506C4
		private unsafe void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) {} // 0x00000001897502B8-0x00000001897505D4
	}

	internal static class UnityTlsConversions // TypeDefIndex: 45380
	{
		// Methods
		public static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols) => default; // 0x0000000189752BC8-0x0000000189752C00
		public static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols) => default; // 0x0000000189752B90-0x0000000189752BC8
		public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol) => default; // 0x0000000189752B6C-0x0000000189752B90
		public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = AlertDescription.InternalError /* Metadata: 0x01FB9D3E */) => default; // 0x0000000189752C00-0x0000000189752C5C
		public static SslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult) => default; // 0x0000000189752C8C-0x0000000189752CB4
		public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags VerifyResultToChainStatus(UnityTls.unitytls_x509verify_result verifyResult) => default; // 0x0000000189752C5C-0x0000000189752C8C
	}

	internal class UnityTlsProvider : MobileTlsProvider // TypeDefIndex: 45381
	{
		// Properties
		public override string Name { get => default; } // 0x00000001897539D0-0x00000001897539FC 
		public override Guid ID { get => default; } // 0x0000000189753974-0x00000001897539D0 
		public override bool SupportsSslStream { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool SupportsMonoExtensions { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool SupportsConnectionInfo { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		internal override bool SupportsCleanShutdown { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override SslProtocols SupportedProtocols { get => default; } // 0x0000000183D753E0-0x0000000183D753F0 
	
		// Constructors
		public UnityTlsProvider() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) => default; // 0x0000000189752CB4-0x0000000189752D54
		[Mono.Util.MonoPInvokeCallback(typeof(UnityTls.unitytls_x509verify_callback))]
		private static unsafe UnityTls.unitytls_x509verify_result x509verify_callback(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState) => default; // 0x00000001897539FC-0x0000000189753A70
		internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, ref System.Security.Cryptography.X509Certificates.X509Chain chain, ref SslPolicyErrors errors, ref int status11) => default; // 0x0000000189752D54-0x0000000189753974
	}

	internal class UnityTlsStream : MobileAuthenticatedStream // TypeDefIndex: 45382
	{
		// Constructors
		public UnityTlsStream() {} // Dummy constructor
		public UnityTlsStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) {} // 0x0000000189753AE0-0x0000000189753B68
	
		// Methods
		protected override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) => default; // 0x0000000189753A70-0x0000000189753AE0
	}

	internal class X509ChainImplUnityTls : X509ChainImpl // TypeDefIndex: 45383
	{
		// Fields
		private X509ChainElementCollection elements; // 0x10
		private UnityTls.unitytls_x509list_ref nativeCertificateChain; // 0x18
		private X509ChainPolicy policy; // 0x20
		private List<X509ChainStatus> chainStatusList; // 0x28
		private bool reverseOrder; // 0x30
	
		// Properties
		public override bool IsValid { get => default; } // 0x00000001897540F8-0x0000000189754124 
		internal UnityTls.unitytls_x509list_ref NativeCertificateChain { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public override X509ChainElementCollection ChainElements { get => default; } // 0x0000000189753DF8-0x00000001897540F8 
		public override X509ChainPolicy ChainPolicy { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public X509ChainImplUnityTls() {} // Dummy constructor
		internal X509ChainImplUnityTls(UnityTls.unitytls_x509list_ref nativeCertificateChain, bool reverseOrder = false /* Metadata: 0x01FB9D3F */) {} // 0x0000000189753D60-0x0000000189753DF8
	
		// Methods
		public override void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error) {} // 0x0000000189753C34-0x0000000189753D10
		public override bool Build(X509Certificate2 certificate) => default; // 0x000000018115F4C0-0x000000018115F530
		public override void Reset() {} // 0x0000000189753D10-0x0000000189753D60
		protected override void Dispose(bool disposing) {} // 0x0000000188250BD4-0x0000000188250BE4
	}
}

namespace Mono.Util
{
	[AttributeUsage(AttributeTargets.Method)]
	[Conditional("UNITY")]
	[Conditional("MONOTOUCH")]
	[Conditional("FULL_AOT_RUNTIME")]
	internal sealed class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 45324
	{
		// Constructors
		public MonoPInvokeCallbackAttribute() {} // Dummy constructor
		public MonoPInvokeCallbackAttribute(System.Type t) {} // 0x000000018350B670-0x000000018350B680
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

namespace System.CodeDom.Compiler
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All, Inherited = false, AllowMultiple = false)]
	public sealed class GeneratedCodeAttribute : Attribute // TypeDefIndex: 45564
	{
		// Fields
		private readonly string tool; // 0x10
		private readonly string version; // 0x18
	
		// Constructors
		public GeneratedCodeAttribute() {} // Dummy constructor
		public GeneratedCodeAttribute(string tool, string version) {} // 0x0000000182676770-0x00000001826767A0
	}
}

namespace System.Collections
{
	internal static class HashtableExtensions // TypeDefIndex: 46115
	{
		// Extension methods
		public static bool TryGetValue<T>(this Hashtable table, object key, out ref T value) {
			value = default;
			return default;
		}
	}
}

namespace System.Collections.Concurrent
{
	[DebuggerDisplay("Count = {Count}, Type = {_collection}")]
	[DebuggerTypeProxy(typeof(BlockingCollectionDebugView<T>))]
	public class BlockingCollection<T> : ICollection, IDisposable, IReadOnlyCollection<T> // TypeDefIndex: 46143
	{
		// Fields
		private IProducerConsumerCollection<T> _collection;
		private int _boundedCapacity;
		private SemaphoreSlim _freeNodes;
		private SemaphoreSlim _occupiedNodes;
		private bool _isDisposed;
		private CancellationTokenSource _consumersCancellationTokenSource;
		private CancellationTokenSource _producersCancellationTokenSource;
		private int _currentAdders;
	
		// Properties
		public bool IsAddingCompleted { get => default; }
		public int Count { get => default; }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
	
		// Constructors
		public BlockingCollection() {}
		public BlockingCollection(IProducerConsumerCollection<T> collection) {}
	
		// Methods
		private void Initialize(IProducerConsumerCollection<T> collection, int boundedCapacity, int collectionCount) {}
		public void Add(T item) {}
		private bool TryAddWithNoTimeValidation(T item, int millisecondsTimeout, CancellationToken cancellationToken) => default;
		public void Dispose() {}
		protected virtual void Dispose(bool disposing) {}
		void ICollection.CopyTo(Array array, int index) {}
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		private void CheckDisposed() {}
	}

	internal sealed class BlockingCollectionDebugView<T> // TypeDefIndex: 46144
	{
		// Constructors
		public BlockingCollectionDebugView() {} // Dummy constructor
	}

	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<T>))]
	public class ConcurrentBag<T> : IProducerConsumerCollection<T>, IReadOnlyCollection<T> // TypeDefIndex: 46147
	{
		// Fields
		private readonly ThreadLocal<WorkStealingQueue> _locals;
		private WorkStealingQueue _workStealingQueues;
		private long _emptyToNonEmptyListTransitionCount;
	
		// Properties
		public int Count { get => default; }
		private int DangerousCount { get => default; }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
		private object GlobalQueuesLock { get => default; }
	
		// Nested types
		private sealed class WorkStealingQueue // TypeDefIndex: 46145
		{
			// Fields
			private int _headIndex;
			private int _tailIndex;
			private T[] _array;
			private int _mask;
			private int _addTakeCount;
			private int _stealCount;
			internal int _currentOp;
			internal bool _frozen;
			internal readonly WorkStealingQueue<T> _nextQueue;
			internal readonly int _ownerThreadId;
	
			// Properties
			internal int DangerousCount { get => default; }
	
			// Constructors
			public WorkStealingQueue() {} // Dummy constructor
			internal WorkStealingQueue(WorkStealingQueue<T> nextQueue) {}
	
			// Methods
			internal void LocalPush(T item, ref long emptyToNonEmptyListTransitionCount) {}
			internal void LocalClear() {}
			internal bool TrySteal(out ref T result, bool take) {
				result = default;
				return default;
			}
			internal int DangerousCopyTo(T[] array, int arrayIndex) => default;
		}
	
		[Serializable]
		private sealed class Enumerator : IEnumerator<T> // TypeDefIndex: 46146
		{
			// Fields
			private readonly T[] _array;
			private T _current;
			private int _index;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator() {} // Dummy constructor
			public Enumerator(T[] array) {}
	
			// Methods
			public bool MoveNext() => default;
			public void Reset() {}
			public void Dispose() {}
		}
	
		// Constructors
		public ConcurrentBag() {}
	
		// Methods
		public void Add(T item) {}
		bool IProducerConsumerCollection<T>.TryAdd(T item) => default;
		private WorkStealingQueue GetCurrentThreadWorkStealingQueue(bool forceCreate) => default;
		private WorkStealingQueue CreateWorkStealingQueueForCurrentThread() => default;
		private WorkStealingQueue GetUnownedWorkStealingQueue() => default;
		public void CopyTo(T[] array, int index) {}
		private int CopyFromEachQueueToArray(T[] array, int index) => default;
		void ICollection.CopyTo(Array array, int index) {}
		public T[] ToArray() => default;
		public void Clear() {}
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		private void FreezeBag(ref bool lockTaken) {}
		private void UnfreezeBag(bool lockTaken) {}
	}
}

namespace System.Collections.Generic
{
	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal struct ValueListBuilder<T> // TypeDefIndex: 46148
	{
		// Fields
		private Span<T> _span;
		private T[] _arrayFromPool;
		private int _pos;
	
		// Properties
		public int Length { get => default; }
		public ref T this[int index] { get => default; }
	
		// Constructors
		public ValueListBuilder(Span<T> initialSpan) : this() {
			_span = default;
			_arrayFromPool = default;
			_pos = default;
		}
	
		// Methods
		public void Append(T item) {}
		public ReadOnlySpan<T> AsSpan() => default;
		public void Dispose() {}
		private void Grow() {}
		public T Pop() => default;
	}

	internal sealed class ICollectionDebugView<T> // TypeDefIndex: 46149
	{
		// Constructors
		public ICollectionDebugView() {} // Dummy constructor
	}

	internal sealed class IDictionaryDebugView<K, V> // TypeDefIndex: 46150
	{
		// Constructors
		public IDictionaryDebugView() {} // Dummy constructor
	}

	internal sealed class DictionaryKeyCollectionDebugView<TKey, TValue> // TypeDefIndex: 46151
	{
		// Constructors
		public DictionaryKeyCollectionDebugView() {} // Dummy constructor
	}

	internal sealed class DictionaryValueCollectionDebugView<TKey, TValue> // TypeDefIndex: 46152
	{
		// Constructors
		public DictionaryValueCollectionDebugView() {} // Dummy constructor
	}

	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
	public class LinkedList<T> : ICollection<T>, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 46154
	{
		// Fields
		internal LinkedListNode<T> head;
		internal int count;
		internal int version;
		private object _syncRoot;
		private SerializationInfo _siInfo;
		private const string VersionName = "Version"; // Metadata: 0x01FBA7D1
		private const string CountName = "Count"; // Metadata: 0x01FBA7D9
		private const string ValuesName = "Data"; // Metadata: 0x01FBA7DF
	
		// Properties
		public int Count { get => default; }
		public LinkedListNode<T> First { get => default; }
		public LinkedListNode<T> Last { get => default; }
		bool ICollection<T>.IsReadOnly { get => default; }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
	
		// Nested types
		[Serializable]
		public struct Enumerator : IEnumerator<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 46153
		{
			// Fields
			private LinkedList<T> _list;
			private LinkedListNode<T> _node;
			private int _version;
			private T _current;
			private int _index;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			internal Enumerator(LinkedList<T> list) : this() {
				_list = default;
				_node = default;
				_version = default;
				_current = default;
				_index = default;
			}
			private Enumerator(SerializationInfo info, StreamingContext context) : this() {
				_list = default;
				_node = default;
				_version = default;
				_current = default;
				_index = default;
			}
	
			// Methods
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
			public void Dispose() {}
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {}
			void IDeserializationCallback.OnDeserialization(object sender) {}
		}
	
		// Constructors
		public LinkedList() {}
		protected LinkedList(SerializationInfo info, StreamingContext context) {}
	
		// Methods
		void ICollection<T>.Add(T value) {}
		public void AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode) {}
		public LinkedListNode<T> AddFirst(T value) => default;
		public void AddFirst(LinkedListNode<T> node) {}
		public LinkedListNode<T> AddLast(T value) => default;
		public void AddLast(LinkedListNode<T> node) {}
		public void Clear() {}
		public bool Contains(T value) => default;
		public void CopyTo(T[] array, int index) {}
		public LinkedListNode<T> Find(T value) => default;
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		public bool Remove(T value) => default;
		public void Remove(LinkedListNode<T> node) {}
		public void RemoveFirst() {}
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {}
		public virtual void OnDeserialization(object sender) {}
		private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode) {}
		private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode) {}
		internal void InternalRemoveNode(LinkedListNode<T> node) {}
		internal void ValidateNewNode(LinkedListNode<T> node) {}
		internal void ValidateNode(LinkedListNode<T> node) {}
		void ICollection.CopyTo(Array array, int index) {}
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	public sealed class LinkedListNode<T> // TypeDefIndex: 46155
	{
		// Fields
		internal LinkedList<T> list;
		internal LinkedListNode<T> next;
		internal LinkedListNode<T> prev;
		internal T item;
	
		// Properties
		public LinkedList<T> List { get => default; }
		public LinkedListNode<T> Next { get => default; }
		public LinkedListNode<T> Previous { get => default; }
		public T Value { get => default; set {} }
	
		// Constructors
		public LinkedListNode() {} // Dummy constructor
		public LinkedListNode(T value) {}
		internal LinkedListNode(LinkedList<T> list, T value) {}
	
		// Methods
		internal void Invalidate() {}
	}

	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(System.Collections.Generic.IDictionaryDebugView<K, V>))]
	public class SortedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary, IReadOnlyDictionary<TKey, TValue> // TypeDefIndex: 46168
	{
		// Fields
		[NonSerialized]
		private KeyCollection _keys;
		[NonSerialized]
		private ValueCollection _values;
		private TreeSet<KeyValuePair<TKey, TValue>> _set;
	
		// Properties
		bool ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get => default; }
		public TValue this[TKey key] { get => default; set {} }
		public int Count { get => default; }
		public KeyCollection Keys { get => default; }
		ICollection<TKey> IDictionary<TKey,TValue>.Keys { get => default; }
		IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get => default; }
		public ValueCollection Values { get => default; }
		ICollection<TValue> IDictionary<TKey,TValue>.Values { get => default; }
		IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get => default; }
		bool IDictionary.IsFixedSize { get => default; }
		bool IDictionary.IsReadOnly { get => default; }
		ICollection IDictionary.Keys { get => default; }
		ICollection IDictionary.Values { get => default; }
		object IDictionary.this[object key] { get => default; set {} }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDictionaryEnumerator // TypeDefIndex: 46156
		{
			// Fields
			private SortedSet<KeyValuePair<TKey, TValue>> _treeEnum;
			private int _getEnumeratorRetType;
	
			// Properties
			public KeyValuePair<TKey, TValue> Current { get => default; }
			internal bool NotStartedOrEnded { get => default; }
			object IEnumerator.Current { get => default; }
			object IDictionaryEnumerator.Key { get => default; }
			object IDictionaryEnumerator.Value { get => default; }
			DictionaryEntry IDictionaryEnumerator.Entry { get => default; }
	
			// Constructors
			internal Enumerator(SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType) : this() {
				_treeEnum = default;
				_getEnumeratorRetType = default;
			}
	
			// Methods
			public bool MoveNext() => default;
			public void Dispose() {}
			internal void Reset() {}
			void IEnumerator.Reset() {}
		}
	
		[Serializable]
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<TKey, TValue>))]
		public sealed class KeyCollection : ICollection<TKey>, ICollection, IReadOnlyCollection<TKey> // TypeDefIndex: 46160
		{
			// Fields
			private SortedDictionary<TKey, TValue> _dictionary;
	
			// Properties
			public int Count { get => default; }
			bool ICollection<TKey>.IsReadOnly { get => default; }
			bool ICollection.IsSynchronized { get => default; }
			object ICollection.SyncRoot { get => default; }
	
			// Nested types
			public struct Enumerator : IEnumerator<TKey> // TypeDefIndex: 46157
			{
				// Fields
				private SortedDictionary<TKey, TValue> _dictEnum;
	
				// Properties
				public TKey Current { get => default; }
				object IEnumerator.Current { get => default; }
	
				// Constructors
				internal Enumerator(SortedDictionary<TKey, TValue> dictionary) : this() {
					_dictEnum = default;
				}
	
				// Methods
				public void Dispose() {}
				public bool MoveNext() => default;
				void IEnumerator.Reset() {}
			}
	
			// Constructors
			public KeyCollection() {} // Dummy constructor
			public KeyCollection(SortedDictionary<TKey, TValue> dictionary) {}
	
			// Methods
			IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
			public void CopyTo(TKey[] array, int index) {}
			void ICollection.CopyTo(Array array, int index) {}
			void ICollection<TKey>.Add(TKey item) {}
			void ICollection<TKey>.Clear() {}
			bool ICollection<TKey>.Contains(TKey item) => default;
			bool ICollection<TKey>.Remove(TKey item) => default;
		}
	
		[Serializable]
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<TKey, TValue>))]
		public sealed class ValueCollection : ICollection<TValue>, ICollection, IReadOnlyCollection<TValue> // TypeDefIndex: 46164
		{
			// Fields
			private SortedDictionary<TKey, TValue> _dictionary;
	
			// Properties
			public int Count { get => default; }
			bool ICollection<TValue>.IsReadOnly { get => default; }
			bool ICollection.IsSynchronized { get => default; }
			object ICollection.SyncRoot { get => default; }
	
			// Nested types
			public struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 46161
			{
				// Fields
				private SortedDictionary<TKey, TValue> _dictEnum;
	
				// Properties
				public TValue Current { get => default; }
				object IEnumerator.Current { get => default; }
	
				// Constructors
				internal Enumerator(SortedDictionary<TKey, TValue> dictionary) : this() {
					_dictEnum = default;
				}
	
				// Methods
				public void Dispose() {}
				public bool MoveNext() => default;
				void IEnumerator.Reset() {}
			}
	
			// Constructors
			public ValueCollection() {} // Dummy constructor
			public ValueCollection(SortedDictionary<TKey, TValue> dictionary) {}
	
			// Methods
			IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
			public void CopyTo(TValue[] array, int index) {}
			void ICollection.CopyTo(Array array, int index) {}
			void ICollection<TValue>.Add(TValue item) {}
			void ICollection<TValue>.Clear() {}
			bool ICollection<TValue>.Contains(TValue item) => default;
			bool ICollection<TValue>.Remove(TValue item) => default;
		}
	
		[Serializable]
		internal sealed class KeyValuePairComparer : Comparer<KeyValuePair<TKey, TValue>> // TypeDefIndex: 46165
		{
			// Fields
			internal IComparer<TKey> keyComparer;
	
			// Constructors
			public KeyValuePairComparer() {} // Dummy constructor
			public KeyValuePairComparer(IComparer<TKey> keyComparer) {}
	
			// Methods
			public override int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y) => default;
		}
	
		// Constructors
		public SortedDictionary() {}
		public SortedDictionary(IComparer<TKey> comparer) {}
	
		// Methods
		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) {}
		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) => default;
		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) => default;
		public void Add(TKey key, TValue value) {}
		public void Clear() {}
		public bool ContainsKey(TKey key) => default;
		public bool ContainsValue(TValue value) => default;
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() => default;
		public bool Remove(TKey key) => default;
		public bool TryGetValue(TKey key, out ref TValue value) {
			value = default;
			return default;
		}
		void ICollection.CopyTo(Array array, int index) {}
		void IDictionary.Add(object key, object value) {}
		bool IDictionary.Contains(object key) => default;
		private static bool IsCompatibleKey(object key) => default;
		IDictionaryEnumerator IDictionary.GetEnumerator() => default;
		void IDictionary.Remove(object key) {}
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	[Serializable]
	internal sealed class TreeSet<T> : SortedSet<T> // TypeDefIndex: 46169
	{
		// Constructors
		public TreeSet() {}
		public TreeSet(IComparer<T> comparer) {}
		public TreeSet(SerializationInfo siInfo, StreamingContext context) {}
	
		// Methods
		internal override bool AddIfNotPresent(T item) => default;
	}

	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(System.Collections.Generic.IDictionaryDebugView<K, V>))]
	public class SortedList<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary, IReadOnlyDictionary<TKey, TValue> // TypeDefIndex: 46175
	{
		// Fields
		private TKey[] keys;
		private TValue[] values;
		private int _size;
		private int version;
		private IComparer<TKey> comparer;
		private KeyList keyList;
		private ValueList valueList;
		[NonSerialized]
		private object _syncRoot;
	
		// Properties
		public int Capacity { set {} }
		public int Count { get => default; }
		public IList<TKey> Keys { get => default; }
		ICollection<TKey> IDictionary<TKey,TValue>.Keys { get => default; }
		ICollection IDictionary.Keys { get => default; }
		IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get => default; }
		public IList<TValue> Values { get => default; }
		ICollection<TValue> IDictionary<TKey,TValue>.Values { get => default; }
		ICollection IDictionary.Values { get => default; }
		IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get => default; }
		bool ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get => default; }
		bool IDictionary.IsReadOnly { get => default; }
		bool IDictionary.IsFixedSize { get => default; }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
		public TValue this[TKey key] { get => default; set {} }
		object IDictionary.this[object key] { get => default; set {} }
	
		// Nested types
		[Serializable]
		private struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDictionaryEnumerator // TypeDefIndex: 46170
		{
			// Fields
			private SortedList<TKey, TValue> _sortedList;
			private TKey _key;
			private TValue _value;
			private int _index;
			private int _version;
			private int _getEnumeratorRetType;
	
			// Properties
			object IDictionaryEnumerator.Key { get => default; }
			DictionaryEntry IDictionaryEnumerator.Entry { get => default; }
			public KeyValuePair<TKey, TValue> Current { get => default; }
			object IEnumerator.Current { get => default; }
			object IDictionaryEnumerator.Value { get => default; }
	
			// Constructors
			internal Enumerator(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType) : this() {
				_sortedList = default;
				_key = default;
				_value = default;
				_index = default;
				_version = default;
				_getEnumeratorRetType = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		[Serializable]
		private sealed class SortedListKeyEnumerator : IEnumerator<TKey> // TypeDefIndex: 46171
		{
			// Fields
			private SortedList<TKey, TValue> _sortedList;
			private int _index;
			private int _version;
			private TKey _currentKey;
	
			// Properties
			public TKey Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public SortedListKeyEnumerator() {} // Dummy constructor
			internal SortedListKeyEnumerator(SortedList<TKey, TValue> sortedList) {}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		[Serializable]
		private sealed class SortedListValueEnumerator : IEnumerator<TValue> // TypeDefIndex: 46172
		{
			// Fields
			private SortedList<TKey, TValue> _sortedList;
			private int _index;
			private int _version;
			private TValue _currentValue;
	
			// Properties
			public TValue Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public SortedListValueEnumerator() {} // Dummy constructor
			internal SortedListValueEnumerator(SortedList<TKey, TValue> sortedList) {}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		[Serializable]
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<TKey, TValue>))]
		private sealed class KeyList : IList<TKey>, ICollection // TypeDefIndex: 46173
		{
			// Fields
			private SortedList<TKey, TValue> _dict;
	
			// Properties
			public int Count { get => default; }
			public bool IsReadOnly { get => default; }
			bool ICollection.IsSynchronized { get => default; }
			object ICollection.SyncRoot { get => default; }
			public TKey this[int index] { get => default; set {} }
	
			// Constructors
			public KeyList() {} // Dummy constructor
			internal KeyList(SortedList<TKey, TValue> dictionary) {}
	
			// Methods
			public void Add(TKey key) {}
			public void Clear() {}
			public bool Contains(TKey key) => default;
			public void CopyTo(TKey[] array, int arrayIndex) {}
			void ICollection.CopyTo(Array array, int arrayIndex) {}
			public void Insert(int index, TKey value) {}
			public IEnumerator<TKey> GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
			public int IndexOf(TKey key) => default;
			public bool Remove(TKey key) => default;
			public void RemoveAt(int index) {}
		}
	
		[Serializable]
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<TKey, TValue>))]
		private sealed class ValueList : IList<TValue>, ICollection // TypeDefIndex: 46174
		{
			// Fields
			private SortedList<TKey, TValue> _dict;
	
			// Properties
			public int Count { get => default; }
			public bool IsReadOnly { get => default; }
			bool ICollection.IsSynchronized { get => default; }
			object ICollection.SyncRoot { get => default; }
			public TValue this[int index] { get => default; set {} }
	
			// Constructors
			public ValueList() {} // Dummy constructor
			internal ValueList(SortedList<TKey, TValue> dictionary) {}
	
			// Methods
			public void Add(TValue key) {}
			public void Clear() {}
			public bool Contains(TValue value) => default;
			public void CopyTo(TValue[] array, int arrayIndex) {}
			void ICollection.CopyTo(Array array, int index) {}
			public void Insert(int index, TValue value) {}
			public IEnumerator<TValue> GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
			public int IndexOf(TValue value) => default;
			public bool Remove(TValue value) => default;
			public void RemoveAt(int index) {}
		}
	
		// Constructors
		public SortedList() {}
		public SortedList(IComparer<TKey> comparer) {}
		public SortedList(int capacity, IComparer<TKey> comparer) {}
	
		// Methods
		public void Add(TKey key, TValue value) {}
		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) {}
		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) => default;
		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) => default;
		void IDictionary.Add(object key, object value) {}
		private KeyList GetKeyListHelper() => default;
		private ValueList GetValueListHelper() => default;
		public void Clear() {}
		bool IDictionary.Contains(object key) => default;
		public bool ContainsKey(TKey key) => default;
		public bool ContainsValue(TValue value) => default;
		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) {}
		void ICollection.CopyTo(Array array, int index) {}
		private void EnsureCapacity(int min) {}
		private TValue GetByIndex(int index) => default;
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => default;
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() => default;
		IDictionaryEnumerator IDictionary.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		private TKey GetKey(int index) => default;
		public int IndexOfKey(TKey key) => default;
		public int IndexOfValue(TValue value) => default;
		private void Insert(int index, TKey key, TValue value) {}
		public bool TryGetValue(TKey key, out ref TValue value) {
			value = default;
			return default;
		}
		public void RemoveAt(int index) {}
		public bool Remove(TKey key) => default;
		void IDictionary.Remove(object key) {}
		private static bool IsCompatibleKey(object key) => default;
	}

	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
	public class SortedSet<T> : ISet<T>, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 46180
	{
		// Fields
		private Node root;
		private IComparer<T> comparer;
		private int count;
		private int version;
		[NonSerialized]
		private object _syncRoot;
		private SerializationInfo siInfo;
		private const string ComparerName = "Comparer"; // Metadata: 0x01FBA7E4
		private const string CountName = "Count"; // Metadata: 0x01FBA7ED
		private const string ItemsName = "Items"; // Metadata: 0x01FBA7F3
		private const string VersionName = "Version"; // Metadata: 0x01FBA7F9
		private const string TreeName = "Tree"; // Metadata: 0x01FBA801
		private const string NodeValueName = "Item"; // Metadata: 0x01FBA806
		private const string EnumStartName = "EnumStarted"; // Metadata: 0x01FBA80B
		private const string ReverseName = "Reverse"; // Metadata: 0x01FBA817
		private const string EnumVersionName = "EnumVersion"; // Metadata: 0x01FBA81F
		private const string MinName = "Min"; // Metadata: 0x01FBA82B
		private const string MaxName = "Max"; // Metadata: 0x01FBA82F
		private const string LowerBoundActiveName = "lBoundActive"; // Metadata: 0x01FBA833
		private const string UpperBoundActiveName = "uBoundActive"; // Metadata: 0x01FBA840
		internal const int StackAllocThreshold = 100; // Metadata: 0x01FBA84D
	
		// Properties
		public int Count { get => default; }
		bool ICollection<T>.IsReadOnly { get => default; }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
	
		// Nested types
		[Serializable]
		internal sealed class Node // TypeDefIndex: 46176
		{
			// Properties
			public T Item { get; set; }
			public Node<T> Left { get; set; }
			public Node<T> Right { get; set; }
			public System.Collections.Generic.NodeColor Color { get; set; }
			public bool IsBlack { get => default; }
			public bool IsRed { get => default; }
			public bool Is2Node { get => default; }
			public bool Is4Node { get => default; }
	
			// Constructors
			public Node() {} // Dummy constructor
			public Node(T item, System.Collections.Generic.NodeColor color) {}
	
			// Methods
			public static bool IsNonNullRed(Node<T> node) => default;
			public static bool IsNullOrBlack(Node<T> node) => default;
			public void ColorBlack() {}
			public void ColorRed() {}
			public TreeRotation GetRotation(Node<T> current, Node<T> sibling) => default;
			public Node<T> GetSibling(Node<T> node) => default;
			public void Split4Node() {}
			public Node<T> Rotate(TreeRotation rotation) => default;
			public Node<T> RotateLeft() => default;
			public Node<T> RotateLeftRight() => default;
			public Node<T> RotateRight() => default;
			public Node<T> RotateRightLeft() => default;
			public void Merge2Nodes() {}
			public void ReplaceChild(Node<T> child, Node<T> newChild) {}
		}
	
		[Serializable]
		public struct Enumerator : IEnumerator<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 46177
		{
			// Fields
			private static readonly Node<T> s_dummyNode;
			private SortedSet<T> _tree;
			private int _version;
			private Stack<Node<T>> _stack;
			private Node<T> _current;
			private bool _reverse;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
			internal bool NotStartedOrEnded { get => default; }
	
			// Constructors
			internal Enumerator(SortedSet<T> set) : this() {
				_tree = default;
				_version = default;
				_stack = default;
				_current = default;
				_reverse = default;
			}
			internal Enumerator(SortedSet<T> set, bool reverse) : this() {
				_tree = default;
				_version = default;
				_stack = default;
				_current = default;
				_reverse = default;
			}
			static Enumerator() {
				s_dummyNode = default;
			}
	
			// Methods
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {}
			void IDeserializationCallback.OnDeserialization(object sender) {}
			private void Initialize() {}
			public bool MoveNext() => default;
			public void Dispose() {}
			internal void Reset() {}
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		public SortedSet() {}
		public SortedSet(IComparer<T> comparer) {}
		protected SortedSet(SerializationInfo info, StreamingContext context) {}
	
		// Methods
		internal virtual bool InOrderTreeWalk(TreeWalkPredicate<T> action) => default;
		internal virtual void VersionCheck() {}
		internal virtual bool IsWithinRange(T item) => default;
		public bool Add(T item) => default;
		void ICollection<T>.Add(T item) {}
		internal virtual bool AddIfNotPresent(T item) => default;
		public bool Remove(T item) => default;
		internal virtual bool DoRemove(T item) => default;
		public virtual void Clear() {}
		public virtual bool Contains(T item) => default;
		public void CopyTo(T[] array, int index) {}
		public void CopyTo(T[] array, int index, int count) {}
		void ICollection.CopyTo(Array array, int index) {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		private void InsertionBalance(Node current, ref Node parent, Node grandParent, Node greatGrandParent) {}
		private void ReplaceChildOrRoot(Node parent, Node child, Node newChild) {}
		private void ReplaceNode(Node match, Node parentOfMatch, Node successor, Node parentOfSuccessor) {}
		internal virtual Node FindNode(T item) => default;
		internal void UpdateVersion() {}
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {}
		protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) {}
		void IDeserializationCallback.OnDeserialization(object sender) {}
		protected virtual void OnDeserialization(object sender) {}
		private static int Log2(int value) => default;
	}

	internal enum NodeColor : byte // TypeDefIndex: 46181
	{
		Black = 0,
		Red = 1
	}

	internal delegate bool TreeWalkPredicate<T>(SortedSet<T> node); // TypeDefIndex: 46182; 0x00000000-0x00000000

	internal enum TreeRotation : byte // TypeDefIndex: 46183
	{
		Left = 0,
		LeftRight = 1,
		Right = 2,
		RightLeft = 3
	}

	internal sealed class CollectionDebugView<T> // TypeDefIndex: 46184
	{
		// Constructors
		public CollectionDebugView() {} // Dummy constructor
	}

	public interface ISet<T> : ICollection<T> // TypeDefIndex: 46185
	{
		// Methods
		bool Add(T item);
	}
}

namespace System.Collections.ObjectModel
{
	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebugView<T>))]
	public class ObservableCollection<T> : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged // TypeDefIndex: 46117
	{
		// Fields
		private SimpleMonitor _monitor;
		[NonSerialized]
		private int _blockReentrancyCount;
	
		// Events
		event PropertyChangedEventHandler System_ComponentModel_INotifyPropertyChanged_PropertyChanged;
		public virtual event NotifyCollectionChangedEventHandler CollectionChanged;
		protected virtual event PropertyChangedEventHandler PropertyChanged;
	
		// Nested types
		[Serializable]
		private sealed class SimpleMonitor : IDisposable // TypeDefIndex: 46116
		{
			// Fields
			internal int _busyCount;
			[NonSerialized]
			internal ObservableCollection<T> _collection;
	
			// Constructors
			public SimpleMonitor() {} // Dummy constructor
			public SimpleMonitor(ObservableCollection<T> collection) {}
	
			// Methods
			public void Dispose() {}
		}
	
		// Constructors
		public ObservableCollection() {}
		public ObservableCollection(IEnumerable<T> collection) {}
	
		// Methods
		private static List<T> CreateCopy(IEnumerable<T> collection, string paramName) => default;
		protected override void ClearItems() {}
		protected override void RemoveItem(int index) {}
		protected override void InsertItem(int index, T item) {}
		protected override void SetItem(int index, T item) {}
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e) {}
		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) {}
		protected void CheckReentrancy() {}
		private void OnCountPropertyChanged() {}
		private void OnIndexerPropertyChanged() {}
		private void OnCollectionChanged(NotifyCollectionChangedAction action, object item, int index) {}
		private void OnCollectionChanged(NotifyCollectionChangedAction action, object oldItem, object newItem, int index) {}
		private void OnCollectionReset() {}
		private SimpleMonitor EnsureMonitorInitialized() => default;
		[OnSerializing]
		private void OnSerializing(StreamingContext context) {}
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context) {}
	}

	internal static class EventArgsCache // TypeDefIndex: 46118
	{
		// Fields
		internal static readonly PropertyChangedEventArgs CountPropertyChanged; // 0x00
		internal static readonly PropertyChangedEventArgs IndexerPropertyChanged; // 0x08
		internal static readonly NotifyCollectionChangedEventArgs ResetCollectionChanged; // 0x10
	
		// Constructors
		static EventArgsCache() {} // 0x0000000189A15DA4-0x0000000189A15EF0
	}

	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebugView<T>))]
	public class ReadOnlyObservableCollection<T> : ReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged // TypeDefIndex: 46119
	{
		// Events
		event NotifyCollectionChangedEventHandler System_Collections_Specialized_INotifyCollectionChanged_CollectionChanged;
		protected virtual event NotifyCollectionChangedEventHandler CollectionChanged;
		event PropertyChangedEventHandler System_ComponentModel_INotifyPropertyChanged_PropertyChanged;
		protected virtual event PropertyChangedEventHandler PropertyChanged;
	
		// Constructors
		public ReadOnlyObservableCollection() {} // Dummy constructor
		public ReadOnlyObservableCollection(ObservableCollection<T> list) {}
	
		// Methods
		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args) {}
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs args) {}
		private void HandleCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {}
		private void HandlePropertyChanged(object sender, PropertyChangedEventArgs e) {}
	}
}

namespace System.Collections.Specialized
{
	public struct BitVector32 // TypeDefIndex: 46120
	{
		// Fields
		private uint _data; // 0x00
	
		// Properties
		public bool this[int bit] { get => default; set {} } // 0x0000000189A115D8-0x0000000189A115EC 0x00000001889A5ACC-0x00000001889A5AE0
	
		// Methods
		public static int CreateMask() => default; // 0x0000000181168950-0x0000000181168960
		public static int CreateMask(int previous) => default; // 0x0000000189A113EC-0x0000000189A11464
		public override bool Equals(object o) => default; // 0x0000000189A11464-0x0000000189A114C0
		public override int GetHashCode() => default; // 0x0000000189A114C0-0x0000000189A1150C
		public static string ToString(BitVector32 value) => default; // 0x0000000189A11518-0x0000000189A115D8
		public override string ToString() => default; // 0x0000000189A1150C-0x0000000189A11518
	}

	[Serializable]
	public class ListDictionary : IDictionary // TypeDefIndex: 46125
	{
		// Fields
		private DictionaryNode head; // 0x10
		private int version; // 0x18
		private int count; // 0x1C
		private readonly System.Collections.IComparer comparer; // 0x20
		[NonSerialized]
		private object _syncRoot; // 0x28
	
		// Properties
		public object this[object key] { get => default; set {} } // 0x0000000189A17E18-0x0000000189A17EF8 0x0000000189A18020-0x0000000189A1818C
		public int Count { get => default; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 
		public ICollection Keys { get => default; } // 0x0000000189A17EF8-0x0000000189A17F5C 
		public bool IsReadOnly { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public bool IsFixedSize { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public bool IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public object SyncRoot { get => default; } // 0x0000000189A17F5C-0x0000000189A17FBC 
		public ICollection Values { get => default; } // 0x0000000189A17FBC-0x0000000189A18020 
	
		// Nested types
		private class NodeEnumerator : IDictionaryEnumerator // TypeDefIndex: 46121
		{
			// Fields
			private ListDictionary _list; // 0x10
			private DictionaryNode _current; // 0x18
			private int _version; // 0x20
			private bool _start; // 0x24
	
			// Properties
			public object Current { get => default; } // 0x0000000189A1A6A4-0x0000000189A1A6FC 
			public DictionaryEntry Entry { get => default; } // 0x0000000189A1A6FC-0x0000000189A1A784 
			public object Key { get => default; } // 0x0000000189A1A784-0x0000000189A1A7F4 
			public object Value { get => default; } // 0x0000000189A1A7F4-0x0000000189A1A864 
	
			// Constructors
			public NodeEnumerator() {} // Dummy constructor
			public NodeEnumerator(ListDictionary list) {} // 0x0000000189210450-0x0000000189210494
	
			// Methods
			public bool MoveNext() => default; // 0x0000000189A1A560-0x0000000189A1A620
			public void Reset() {} // 0x0000000189A1A620-0x0000000189A1A6A4
		}
	
		private class NodeKeyValueCollection : ICollection // TypeDefIndex: 46123
		{
			// Fields
			private ListDictionary _list; // 0x10
			private bool _isKeys; // 0x18
	
			// Properties
			int ICollection.Count { get => default; } // 0x0000000189210860-0x0000000189210890 
			bool ICollection.IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
			object ICollection.SyncRoot { get => default; } // 0x0000000189A1A9C4-0x0000000189A1A9E4 
	
			// Nested types
			private class NodeKeyValueEnumerator : IEnumerator // TypeDefIndex: 46122
			{
				// Fields
				private ListDictionary _list; // 0x10
				private DictionaryNode _current; // 0x18
				private int _version; // 0x20
				private bool _isKeys; // 0x24
				private bool _start; // 0x25
	
				// Properties
				public object Current { get => default; } // 0x0000000189A1AB9C-0x0000000189A1AC18 
	
				// Constructors
				public NodeKeyValueEnumerator() {} // Dummy constructor
				public NodeKeyValueEnumerator(ListDictionary list, bool isKeys) {} // 0x0000000189210A68-0x0000000189210AB0
	
				// Methods
				public bool MoveNext() => default; // 0x0000000189A1AA58-0x0000000189A1AB18
				public void Reset() {} // 0x0000000189A1AB18-0x0000000189A1AB9C
			}
	
			// Constructors
			public NodeKeyValueCollection() {} // Dummy constructor
			public NodeKeyValueCollection(ListDictionary list, bool isKeys) {} // 0x00000001825E7390-0x00000001825E73C0
	
			// Methods
			void ICollection.CopyTo(Array array, int index) {} // 0x0000000189A1A864-0x0000000189A1A9C4
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189A1A9E4-0x0000000189A1AA58
		}
	
		[Serializable]
		public class DictionaryNode // TypeDefIndex: 46124
		{
			// Fields
			public object key; // 0x10
			public object value; // 0x18
			public DictionaryNode next; // 0x20
	
			// Constructors
			public DictionaryNode() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public ListDictionary() {} // 0x000000018350B670-0x000000018350B680
		public ListDictionary(System.Collections.IComparer comparer) {} // 0x0000000184271930-0x0000000184271940
	
		// Methods
		public void Add(object key, object value) {} // 0x0000000189A177B8-0x0000000189A1797C
		public void Clear() {} // 0x000000018920FB0C-0x000000018920FB30
		public bool Contains(object key) => default; // 0x0000000189A1797C-0x0000000189A17A48
		public void CopyTo(Array array, int index) {} // 0x0000000189A17A48-0x0000000189A17C3C
		public IDictionaryEnumerator GetEnumerator() => default; // 0x0000000189A17C3C-0x0000000189A17C9C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189A17DB8-0x0000000189A17E18
		public void Remove(object key) {} // 0x0000000189A17C9C-0x0000000189A17DB8
	}

	[Serializable]
	public class NameValueCollection : NameObjectCollectionBase // TypeDefIndex: 46126
	{
		// Fields
		private string[] _all; // 0x58
		private string[] _allKeys; // 0x60
	
		// Properties
		public string this[string name] { get => default; set {} } // 0x0000000189A1A504-0x0000000189A1A518 0x0000000189A1A518-0x0000000189A1A530
		public virtual string[] AllKeys { get => default; } // 0x0000000189A1A4D0-0x0000000189A1A504 
	
		// Constructors
		public NameValueCollection() {} // 0x0000000189A1A444-0x0000000189A1A490
		public NameValueCollection(int capacity, IEqualityComparer equalityComparer) {} // 0x0000000189A1A394-0x0000000189A1A3F4
		protected NameValueCollection(SerializationInfo info, StreamingContext context) {} // 0x0000000189A1A3F4-0x0000000189A1A444
		internal NameValueCollection(DBNull dummy) {} // 0x0000000189A1A490-0x0000000189A1A4D0
	
		// Methods
		protected void InvalidateCachedArrays() {} // 0x0000000189A1A244-0x0000000189A1A26C
		private static string GetAsOneString(ArrayList list) => default; // 0x0000000189A19EBC-0x0000000189A1A03C
		private static string[] GetAsStringArray(ArrayList list) => default; // 0x0000000189A1A03C-0x0000000189A1A0C4
		public virtual void Add(string name, string value) {} // 0x0000000189A19D84-0x0000000189A19EBC
		public virtual string Get(string name) => default; // 0x0000000189A1A1E4-0x0000000189A1A244
		public virtual string[] GetValues(string name) => default; // 0x0000000189A1A0CC-0x0000000189A1A12C
		public virtual void Set(string name, string value) {} // 0x0000000189A1A29C-0x0000000189A1A394
		public virtual void Remove(string name) {} // 0x0000000189A1A26C-0x0000000189A1A29C
		public virtual string Get(int index) => default; // 0x0000000189A1A188-0x0000000189A1A1E4
		public virtual string[] GetValues(int index) => default; // 0x0000000189A1A12C-0x0000000189A1A188
		public virtual string GetKey(int index) => default; // 0x0000000189A1A0C4-0x0000000189A1A0CC
	}

	[Serializable]
	public class OrderedDictionary : IDictionary, ISerializable, IDeserializationCallback // TypeDefIndex: 46129
	{
		// Fields
		private ArrayList _objectsArray; // 0x10
		private Hashtable _objectsTable; // 0x18
		private int _initialCapacity; // 0x20
		private IEqualityComparer _comparer; // 0x28
		private bool _readOnly; // 0x30
		private object _syncRoot; // 0x38
		private SerializationInfo _siInfo; // 0x40
	
		// Properties
		public int Count { get => default; } // 0x00000001825E73C0-0x00000001825E73F0 
		bool IDictionary.IsFixedSize { get => default; } // 0x0000000183D4EF60-0x0000000183D4EF70 
		public bool IsReadOnly { get => default; } // 0x0000000183D4EF60-0x0000000183D4EF70 
		bool ICollection.IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public ICollection Keys { get => default; } // 0x0000000189A1C3D8-0x0000000189A1C448 
		private ArrayList objectsArray { get => default; } // 0x00000001825E75E0-0x00000001825E7670 
		private Hashtable objectsTable { get => default; } // 0x00000001825E80E0-0x00000001825E8190 
		object ICollection.SyncRoot { get => default; } // 0x0000000189A1C2BC-0x0000000189A1C31C 
		public object this[object key] { get => default; set {} } // 0x0000000189A1C3A8-0x0000000189A1C3D8 0x00000001825E7670-0x00000001825E7700
		public ICollection Values { get => default; } // 0x00000001825E73F0-0x00000001825E7460 
	
		// Nested types
		private class OrderedDictionaryEnumerator : IDictionaryEnumerator // TypeDefIndex: 46127
		{
			// Fields
			private int _objectReturnType; // 0x10
			private IEnumerator _arrayEnumerator; // 0x18
	
			// Properties
			public object Current { get => default; } // 0x0000000189A1B768-0x0000000189A1B838 
			public DictionaryEntry Entry { get => default; } // 0x0000000189A1B838-0x0000000189A1B908 
			public object Key { get => default; } // 0x0000000189A1B908-0x0000000189A1B974 
			public object Value { get => default; } // 0x0000000189A1B974-0x0000000189A1B9E0 
	
			// Constructors
			public OrderedDictionaryEnumerator() {} // Dummy constructor
			internal OrderedDictionaryEnumerator(ArrayList array, int objectReturnType) {} // 0x0000000189A1B728-0x0000000189A1B768
	
			// Methods
			public bool MoveNext() => default; // 0x0000000189A1B694-0x0000000189A1B6DC
			public void Reset() {} // 0x0000000189A1B6DC-0x0000000189A1B728
		}
	
		private class OrderedDictionaryKeyValueCollection : ICollection // TypeDefIndex: 46128
		{
			// Fields
			private ArrayList _objects; // 0x10
			private bool _isKeys; // 0x18
	
			// Properties
			int ICollection.Count { get => default; } // 0x000000018920A6DC-0x000000018920A700 
			bool ICollection.IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
			object ICollection.SyncRoot { get => default; } // 0x0000000189209E70-0x0000000189209E94 
	
			// Constructors
			public OrderedDictionaryKeyValueCollection() {} // Dummy constructor
			public OrderedDictionaryKeyValueCollection(ArrayList array, bool isKeys) {} // 0x00000001825E7390-0x00000001825E73C0
	
			// Methods
			void ICollection.CopyTo(Array array, int index) {} // 0x0000000182FCD510-0x0000000182FDE9E0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189A1B9E0-0x0000000189A1BA5C
		}
	
		// Constructors
		public OrderedDictionary() {} // 0x0000000189A1C394-0x0000000189A1C3A8
		public OrderedDictionary(int capacity) {} // 0x00000001842709A8-0x00000001842709BC
		public OrderedDictionary(int capacity, IEqualityComparer comparer) {} // 0x0000000183559E00-0x0000000183559E10
		protected OrderedDictionary(SerializationInfo info, StreamingContext context) {} // 0x0000000183CB2D80-0x0000000183CB2D90
	
		// Methods
		public void Add(object key, object value) {} // 0x00000001825E7500-0x00000001825E75E0
		public void Clear() {} // 0x0000000189A1BA5C-0x0000000189A1BAFC
		public bool Contains(object key) => default; // 0x00000001825E80B0-0x00000001825E80E0
		public void CopyTo(Array array, int index) {} // 0x0000000189A1BAFC-0x0000000189A1BB3C
		private int IndexOfKey(object key) => default; // 0x0000000189A1BD48-0x0000000189A1BE34
		public void Remove(object key) {} // 0x0000000189A1C190-0x0000000189A1C2BC
		public virtual IDictionaryEnumerator GetEnumerator() => default; // 0x0000000189A1BB3C-0x0000000189A1BBAC
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189A1C31C-0x0000000189A1C38C
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000189A1BBAC-0x0000000189A1BD48
		void IDeserializationCallback.OnDeserialization(object sender) {} // 0x0000000189A1C38C-0x0000000189A1C394
		protected virtual void OnDeserialization(object sender) {} // 0x0000000189A1BE34-0x0000000189A1C190
	}

	[Serializable]
	public class StringCollection : IList // TypeDefIndex: 46130
	{
		// Fields
		private readonly ArrayList data; // 0x10
	
		// Properties
		public string this[int index] { get => default; set {} } // 0x0000000189A1D01C-0x0000000189A1D09C 0x0000000189A1D09C-0x0000000189A1D0C8
		public int Count { get => default; } // 0x000000018920A6DC-0x000000018920A700 
		bool IList.IsReadOnly { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		bool IList.IsFixedSize { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public bool IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public object SyncRoot { get => default; } // 0x0000000189209E70-0x0000000189209E94 
		object IList.this[int index] { get => default; set {} } // 0x0000000189A1CF34-0x0000000189A1CF3C 0x0000000189A1CF3C-0x0000000189A1CFB8
	
		// Constructors
		public StringCollection() {} // 0x0000000189A1CFB8-0x0000000189A1D01C
	
		// Methods
		public int Add(string value) => default; // 0x0000000189A1CC3C-0x0000000189A1CC60
		public void Clear() {} // 0x0000000189A1CC60-0x0000000189A1CC84
		public bool Contains(string value) => default; // 0x0000000189209FE0-0x000000018920A004
		public void CopyTo(string[] array, int index) {} // 0x0000000189209E20-0x0000000189209E4C
		public int IndexOf(string value) => default; // 0x000000018920A004-0x000000018920A028
		public void Insert(int index, string value) {} // 0x0000000189A1CC84-0x0000000189A1CCB0
		public void Remove(string value) {} // 0x0000000189A1CCD4-0x0000000189A1CCF8
		public void RemoveAt(int index) {} // 0x0000000189A1CCB0-0x0000000189A1CCD4
		int IList.Add(object value) => default; // 0x0000000189A1CCF8-0x0000000189A1CD68
		bool IList.Contains(object value) => default; // 0x0000000189A1CD68-0x0000000189A1CDD8
		int IList.IndexOf(object value) => default; // 0x0000000189A1CDD8-0x0000000189A1CE48
		void IList.Insert(int index, object value) {} // 0x0000000189A1CE48-0x0000000189A1CEC4
		void IList.Remove(object value) {} // 0x0000000189A1CEC4-0x0000000189A1CF34
		void ICollection.CopyTo(Array array, int index) {} // 0x0000000189209E20-0x0000000189209E4C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001891207A4-0x00000001891207C8
	}

	[Serializable]
	[DefaultMember("Item")]
	public class StringDictionary : IEnumerable // TypeDefIndex: 46131
	{
		// Fields
		internal Hashtable contents; // 0x10
	
		// Constructors
		public StringDictionary() {} // 0x0000000189A1D188-0x0000000189A1D1EC
	
		// Methods
		public virtual void Add(string key, string value) {} // 0x0000000189A1D0C8-0x0000000189A1D164
		public virtual IEnumerator GetEnumerator() => default; // 0x0000000189A1D164-0x0000000189A1D188
	}

	public interface INotifyCollectionChanged // TypeDefIndex: 46132
	{
		// Events
		event NotifyCollectionChangedEventHandler CollectionChanged;
	}

	public enum NotifyCollectionChangedAction // TypeDefIndex: 46133
	{
		Add = 0,
		Remove = 1,
		Replace = 2,
		Move = 3,
		Reset = 4
	}

	public class NotifyCollectionChangedEventArgs : EventArgs // TypeDefIndex: 46134
	{
		// Fields
		private NotifyCollectionChangedAction _action; // 0x10
		private IList _newItems; // 0x18
		private IList _oldItems; // 0x20
		private int _newStartingIndex; // 0x28
		private int _oldStartingIndex; // 0x2C
	
		// Constructors
		public NotifyCollectionChangedEventArgs() {} // Dummy constructor
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action) {} // 0x0000000189A1B01C-0x0000000189A1B11C
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index) {} // 0x0000000189A1ADEC-0x0000000189A1B01C
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index) {} // 0x0000000189A1B2F4-0x0000000189A1B498
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex) {} // 0x0000000189A1B11C-0x0000000189A1B2F4
	
		// Methods
		private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) {} // 0x0000000189A1AC18-0x0000000189A1AC50
		private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex) {} // 0x0000000189A1AC50-0x0000000189A1ACF4
		private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex) {} // 0x0000000189A1AD48-0x0000000189A1ADEC
		private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex) {} // 0x0000000189A1ACF4-0x0000000189A1AD48
	}

	public delegate void NotifyCollectionChangedEventHandler(object sender, NotifyCollectionChangedEventArgs e); // TypeDefIndex: 46135; 0x0000000182065C10-0x0000000182065C20

	internal sealed class ReadOnlyList : IList // TypeDefIndex: 46136
	{
		// Fields
		private readonly IList _list; // 0x10
	
		// Properties
		public int Count { get => default; } // 0x0000000189A1C7AC-0x0000000189A1C7CC 
		public bool IsReadOnly { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public bool IsFixedSize { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public bool IsSynchronized { get => default; } // 0x0000000187730288-0x00000001877302A8 
		public object this[int index] { get => default; set {} } // 0x0000000189A1C7CC-0x0000000189A1C7EC 0x0000000189A1C7EC-0x0000000189A1C848
		public object SyncRoot { get => default; } // 0x000000018713026C-0x000000018713028C 
	
		// Constructors
		public ReadOnlyList() {} // Dummy constructor
		internal ReadOnlyList(IList list) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public int Add(object value) => default; // 0x0000000189A1C598-0x0000000189A1C5F4
		public void Clear() {} // 0x0000000189A1C5F4-0x0000000189A1C650
		public bool Contains(object value) => default; // 0x00000001877302A8-0x00000001877302C8
		public void CopyTo(Array array, int index) {} // 0x0000000189A0A1DC-0x0000000189A0A1FC
		public IEnumerator GetEnumerator() => default; // 0x0000000189A1C650-0x0000000189A1C698
		public int IndexOf(object value) => default; // 0x00000001877302C8-0x00000001877302E8
		public void Insert(int index, object value) {} // 0x0000000189A1C698-0x0000000189A1C6F4
		public void Remove(object value) {} // 0x0000000189A1C750-0x0000000189A1C7AC
		public void RemoveAt(int index) {} // 0x0000000189A1C6F4-0x0000000189A1C750
	}

	[DefaultMember("Item")]
	internal class CaseSensitiveStringDictionary : StringDictionary // TypeDefIndex: 46137
	{
		// Constructors
		public CaseSensitiveStringDictionary() {} // 0x0000000189A1169C-0x0000000189A116A4
	
		// Methods
		public override void Add(string key, string value) {} // 0x0000000189A1161C-0x0000000189A1169C
	}

	[Serializable]
	public abstract class NameObjectCollectionBase : ICollection, ISerializable, IDeserializationCallback // TypeDefIndex: 46141
	{
		// Fields
		private const string ReadOnlyName = "ReadOnly"; // Metadata: 0x01FBA78C
		private const string CountName = "Count"; // Metadata: 0x01FBA795
		private const string ComparerName = "Comparer"; // Metadata: 0x01FBA79B
		private const string HashCodeProviderName = "HashProvider"; // Metadata: 0x01FBA7A4
		private const string KeysName = "Keys"; // Metadata: 0x01FBA7B1
		private const string ValuesName = "Values"; // Metadata: 0x01FBA7B6
		private const string KeyComparerName = "KeyComparer"; // Metadata: 0x01FBA7BD
		private const string VersionName = "Version"; // Metadata: 0x01FBA7C9
		private bool _readOnly; // 0x10
		private ArrayList _entriesArray; // 0x18
		private IEqualityComparer _keyComparer; // 0x20
		private Hashtable _entriesTable; // 0x28
		private NameObjectEntry _nullKeyEntry; // 0x30
		private KeysCollection _keys; // 0x38
		private SerializationInfo _serializationInfo; // 0x40
		private int _version; // 0x48
		[NonSerialized]
		private object _syncRoot; // 0x50
		private static StringComparer defaultComparer; // 0x00
	
		// Properties
		protected bool IsReadOnly { get; } // 0x00000001811797F0-0x0000000181179800 
		public virtual int Count { get; } // 0x000000018915FBF8-0x000000018915FC1C 
		object ICollection.SyncRoot { get; } // 0x0000000189A1999C-0x0000000189A199FC 
		bool ICollection.IsSynchronized { get; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Nested types
		internal class NameObjectEntry // TypeDefIndex: 46138
		{
			// Fields
			internal string Key; // 0x10
			internal object Value; // 0x18
	
			// Constructors
			public NameObjectEntry() {} // Dummy constructor
			internal NameObjectEntry(string name, object value) {} // 0x0000000182676770-0x00000001826767A0
		}
	
		[Serializable]
		internal class NameObjectKeysEnumerator : IEnumerator // TypeDefIndex: 46139
		{
			// Fields
			private int _pos; // 0x10
			private NameObjectCollectionBase _coll; // 0x18
			private int _version; // 0x20
	
			// Properties
			public object Current { get => default; } // 0x0000000189A19CE0-0x0000000189A19D84 
	
			// Constructors
			public NameObjectKeysEnumerator() {} // Dummy constructor
			internal NameObjectKeysEnumerator(NameObjectCollectionBase coll) {} // 0x0000000189A19CA8-0x0000000189A19CE0
	
			// Methods
			public bool MoveNext() => default; // 0x0000000189A19B68-0x0000000189A19C24
			public void Reset() {} // 0x0000000189A19C24-0x0000000189A19CA8
		}
	
		[Serializable]
		[DefaultMember("Item")]
		public class KeysCollection : ICollection // TypeDefIndex: 46140
		{
			// Fields
			private NameObjectCollectionBase _coll; // 0x10
	
			// Properties
			public int Count { get => default; } // 0x0000000189A17794-0x0000000189A177B8 
			object ICollection.SyncRoot { get => default; } // 0x000000018713026C-0x000000018713028C 
			bool ICollection.IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
			// Constructors
			internal KeysCollection() {} // 0x0000000189A17764-0x0000000189A17794
	
			// Methods
			public IEnumerator GetEnumerator() => default; // 0x0000000189A17434-0x0000000189A17498
			void ICollection.CopyTo(Array array, int index) {} // 0x0000000189A17498-0x0000000189A17764
		}
	
		// Constructors
		protected NameObjectCollectionBase() {} // 0x0000000189A19A98-0x0000000189A19AEC
		protected NameObjectCollectionBase(IEqualityComparer equalityComparer) {} // 0x0000000189A19AEC-0x0000000189A19B68
		protected NameObjectCollectionBase(int capacity, IEqualityComparer equalityComparer) {} // 0x0000000189A19A64-0x0000000189A19A98
		internal NameObjectCollectionBase(DBNull dummy) {} // 0x000000018350B670-0x000000018350B680
		protected NameObjectCollectionBase(SerializationInfo info, StreamingContext context) {} // 0x0000000183CB2D80-0x0000000183CB2D90
		static NameObjectCollectionBase() {} // 0x0000000189A199FC-0x0000000189A19A64
	
		// Methods
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000189A18A34-0x0000000189A18EC4
		public virtual void OnDeserialization(object sender) {} // 0x0000000189A18EC4-0x0000000189A19524
		private void Reset() {} // 0x0000000189A19524-0x0000000189A195F0
		private void Reset(int capacity) {} // 0x0000000189A195F0-0x0000000189A196CC
		private NameObjectEntry FindEntry(string key) => default; // 0x0000000189A1895C-0x0000000189A189D4
		protected void BaseAdd(string name, object value) {} // 0x0000000189A18420-0x0000000189A18574
		protected void BaseRemove(string name) {} // 0x0000000189A1872C-0x0000000189A188A4
		protected object BaseGet(string name) => default; // 0x0000000189A18694-0x0000000189A186B0
		protected void BaseSet(string name, object value) {} // 0x0000000189A188A4-0x0000000189A1895C
		protected object BaseGet(int index) => default; // 0x0000000189A186B0-0x0000000189A1872C
		protected string BaseGetKey(int index) => default; // 0x0000000189A18618-0x0000000189A18694
		public virtual IEnumerator GetEnumerator() => default; // 0x0000000189A189D4-0x0000000189A18A34
		void ICollection.CopyTo(Array array, int index) {} // 0x0000000189A196CC-0x0000000189A1999C
		protected string[] BaseGetAllKeys() => default; // 0x0000000189A18574-0x0000000189A18618
	}

	[Serializable]
	internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 46142
	{
		// Fields
		private System.Collections.IComparer _comparer; // 0x10
		private static System.Collections.IComparer defaultComparer; // 0x00
		private IHashCodeProvider _hcp; // 0x18
		private static IHashCodeProvider defaultHashProvider; // 0x08
	
		// Properties
		public System.Collections.IComparer Comparer { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public IHashCodeProvider HashCodeProvider { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public static System.Collections.IComparer DefaultComparer { get => default; } // 0x0000000189A118E8-0x0000000189A119CC 
		public static IHashCodeProvider DefaultHashCodeProvider { get => default; } // 0x0000000189A119CC-0x0000000189A11AB4 
	
		// Constructors
		public CompatibleComparer() {} // Dummy constructor
		internal CompatibleComparer(System.Collections.IComparer comparer, IHashCodeProvider hashCodeProvider) {} // 0x0000000182676770-0x00000001826767A0
	
		// Methods
		public new bool Equals(object a, object b) => default; // 0x0000000189A11730-0x0000000189A11860
		public int GetHashCode(object obj) => default; // 0x0000000189A11860-0x0000000189A118E8
	}
}

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public class DefaultValueAttribute : Attribute // TypeDefIndex: 45976
	{
		// Fields
		private object _value; // 0x10
	
		// Properties
		public virtual object Value { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public DefaultValueAttribute() {} // Dummy constructor
		public DefaultValueAttribute(int value) {} // 0x00000001833DA2B0-0x00000001833DA310
		public DefaultValueAttribute(long value) {} // 0x00000001899E62D8-0x00000001899E6334
		public DefaultValueAttribute(float value) {} // 0x00000001899E627C-0x00000001899E62D8
		public DefaultValueAttribute(bool value) {} // 0x00000001831349A0-0x0000000183134A00
		public DefaultValueAttribute(string value) {} // 0x000000018426FEE0-0x000000018426FEF0
		public DefaultValueAttribute(object value) {} // 0x000000018426FEE0-0x000000018426FEF0
		[CLSCompliant(false)]
		public DefaultValueAttribute(uint value) {} // 0x00000001899E6334-0x00000001899E638C
	
		// Methods
		public override bool Equals(object obj) => default; // 0x00000001899E61FC-0x00000001899E6274
		public override int GetHashCode() => default; // 0x00000001899E6274-0x00000001899E627C
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public sealed class EditorBrowsableAttribute : Attribute // TypeDefIndex: 45977
	{
		// Fields
		private EditorBrowsableState browsableState; // 0x10
	
		// Constructors
		public EditorBrowsableAttribute() {} // Dummy constructor
		public EditorBrowsableAttribute(EditorBrowsableState state) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public override bool Equals(object obj) => default; // 0x00000001899E73D8-0x00000001899E7438
		public override int GetHashCode() => default; // 0x00000001899E6274-0x00000001899E627C
	}

	public enum EditorBrowsableState // TypeDefIndex: 45978
	{
		Always = 0,
		Never = 1,
		Advanced = 2
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public sealed class BrowsableAttribute : Attribute // TypeDefIndex: 45979
	{
		// Fields
		public static readonly BrowsableAttribute Yes; // 0x00
		public static readonly BrowsableAttribute No; // 0x08
		public static readonly BrowsableAttribute Default; // 0x10
	
		// Properties
		public bool Browsable { get; } // 0x00000001811797F0-0x0000000181179800 
	
		// Constructors
		public BrowsableAttribute() {} // Dummy constructor
		public BrowsableAttribute(bool browsable) {} // 0x0000000183D4E960-0x0000000183D4E970
		static BrowsableAttribute() {} // 0x00000001899E0048-0x00000001899E011C
	
		// Methods
		public override bool Equals(object obj) => default; // 0x00000001899DFF08-0x00000001899DFFA8
		public override int GetHashCode() => default; // 0x00000001899DFFA8-0x00000001899DFFF4
		public override bool IsDefaultAttribute() => default; // 0x00000001899DFFF4-0x00000001899E0048
	}

	public class ComponentCollection : ReadOnlyCollectionBase // TypeDefIndex: 45980
	{
		// Properties
		public virtual IComponent this[string name] { get => default; } // 0x00000001899E1684-0x00000001899E18A0 
	
		// Constructors
		public ComponentCollection() {} // Dummy constructor
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public class DescriptionAttribute : Attribute // TypeDefIndex: 45981
	{
		// Fields
		public static readonly DescriptionAttribute Default; // 0x00
	
		// Properties
		public virtual string Description { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		protected string DescriptionValue { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
		// Constructors
		public DescriptionAttribute() {} // 0x00000001899E669C-0x00000001899E66E4
		public DescriptionAttribute(string description) {} // 0x000000018426FEE0-0x000000018426FEF0
		static DescriptionAttribute() {} // 0x00000001899E662C-0x00000001899E669C
	
		// Methods
		public override bool Equals(object obj) => default; // 0x00000001899E6524-0x00000001899E65A8
		public override int GetHashCode() => default; // 0x00000001899E65A8-0x00000001899E65D8
		public override bool IsDefaultAttribute() => default; // 0x00000001899E65D8-0x00000001899E662C
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public sealed class DesignOnlyAttribute : Attribute // TypeDefIndex: 45982
	{
		// Fields
		public static readonly DesignOnlyAttribute Yes; // 0x00
		public static readonly DesignOnlyAttribute No; // 0x08
		public static readonly DesignOnlyAttribute Default; // 0x10
	
		// Properties
		public bool IsDesignOnly { get; } // 0x00000001811797F0-0x0000000181179800 
	
		// Constructors
		public DesignOnlyAttribute() {} // Dummy constructor
		public DesignOnlyAttribute(bool isDesignOnly) {} // 0x0000000183D4E960-0x0000000183D4E970
		static DesignOnlyAttribute() {} // 0x00000001899E6830-0x00000001899E6908
	
		// Methods
		public override bool Equals(object obj) => default; // 0x00000001899E66E4-0x00000001899E6784
		public override int GetHashCode() => default; // 0x00000001899E6784-0x00000001899E67D0
		public override bool IsDefaultAttribute() => default; // 0x00000001899E67D0-0x00000001899E6830
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class DesignerCategoryAttribute : Attribute // TypeDefIndex: 45983
	{
		// Fields
		public static readonly DesignerCategoryAttribute Component; // 0x00
		public static readonly DesignerCategoryAttribute Default; // 0x08
		public static readonly DesignerCategoryAttribute Form; // 0x10
		public static readonly DesignerCategoryAttribute Generic; // 0x18
	
		// Properties
		public string Category { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public override object TypeId { get => default; } // 0x00000001899E6BB0-0x00000001899E6BF4 
	
		// Constructors
		public DesignerCategoryAttribute() {} // 0x00000001899E6B68-0x00000001899E6BB0
		public DesignerCategoryAttribute(string category) {} // 0x000000018426FEE0-0x000000018426FEF0
		static DesignerCategoryAttribute() {} // 0x00000001899E69DC-0x00000001899E6B68
	
		// Methods
		public override bool Equals(object obj) => default; // 0x00000001899E6908-0x00000001899E6970
		public override int GetHashCode() => default; // 0x0000000186FAB9A8-0x0000000186FAB9CC
		public override bool IsDefaultAttribute() => default; // 0x00000001899E6970-0x00000001899E69DC
	}

	public enum DesignerSerializationVisibility // TypeDefIndex: 45984
	{
		Hidden = 0,
		Visible = 1,
		Content = 2
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
	public sealed class DesignerSerializationVisibilityAttribute : Attribute // TypeDefIndex: 45985
	{
		// Fields
		public static readonly DesignerSerializationVisibilityAttribute Content; // 0x00
		public static readonly DesignerSerializationVisibilityAttribute Hidden; // 0x08
		public static readonly DesignerSerializationVisibilityAttribute Visible; // 0x10
		public static readonly DesignerSerializationVisibilityAttribute Default; // 0x18
	
		// Properties
		public DesignerSerializationVisibility Visibility { get; } // 0x0000000183D4E340-0x0000000183D4E350 
	
		// Constructors
		public DesignerSerializationVisibilityAttribute() {} // Dummy constructor
		public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility) {} // 0x00000001810410F0-0x0000000181041100
		static DesignerSerializationVisibilityAttribute() {} // 0x00000001899E6CF0-0x00000001899E6E10
	
		// Methods
		public override bool Equals(object obj) => default; // 0x00000001899E6BF4-0x00000001899E6C9C
		public override int GetHashCode() => default; // 0x00000001899E6274-0x00000001899E627C
		public override bool IsDefaultAttribute() => default; // 0x00000001899E6C9C-0x00000001899E6CF0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
	public class DisplayNameAttribute : Attribute // TypeDefIndex: 45986
	{
		// Fields
		public static readonly DisplayNameAttribute Default; // 0x00
	
		// Properties
		public virtual string DisplayName { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		protected string DisplayNameValue { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
		// Constructors
		public DisplayNameAttribute() {} // 0x00000001838DDEB0-0x00000001838DDF00
		public DisplayNameAttribute(string displayName) {} // 0x000000018426FEE0-0x000000018426FEF0
		static DisplayNameAttribute() {} // 0x00000001838DDE40-0x00000001838DDEB0
	
		// Methods
		public override bool Equals(object obj) => default; // 0x00000001899E6E10-0x00000001899E6E78
		public override int GetHashCode() => default; // 0x0000000186FAB9A8-0x0000000186FAB9CC
		public override bool IsDefaultAttribute() => default; // 0x00000001899E6E78-0x00000001899E6ECC
	}

	public sealed class EventHandlerList // TypeDefIndex: 45988
	{
		// Fields
		private ListEntry _head; // 0x10
		private Component _parent; // 0x18
	
		// Properties
		public Delegate this[object key] { get => default; } // 0x00000001899E7454-0x00000001899E7470 
	
		// Nested types
		private sealed class ListEntry // TypeDefIndex: 45987
		{
			// Fields
			internal ListEntry _next; // 0x10
			internal object _key; // 0x18
			internal Delegate _handler; // 0x20
	
			// Constructors
			public ListEntry() {} // Dummy constructor
		}
	
		// Constructors
		public EventHandlerList() {} // Dummy constructor
	
		// Methods
		private ListEntry Find(object key) => default; // 0x00000001899E7438-0x00000001899E7454
	}

	public interface IContainer : IDisposable // TypeDefIndex: 45989
	{
		// Properties
		ComponentCollection Components { get; }
	
		// Methods
		void Remove(IComponent component);
	}

	public interface ISite : IServiceProvider // TypeDefIndex: 45990
	{
		// Properties
		System.ComponentModel.IContainer Container { get; }
		bool DesignMode { get; }
		string Name { get; }
	}

	public interface ISynchronizeInvoke // TypeDefIndex: 45991
	{
		// Properties
		bool InvokeRequired { get; }
	
		// Methods
		IAsyncResult BeginInvoke(Delegate method, object[] args);
	}

	[Serializable]
	public class InvalidEnumArgumentException : ArgumentException // TypeDefIndex: 45992
	{
		// Constructors
		public InvalidEnumArgumentException() {} // 0x00000001899E7470-0x00000001899E7490
		public InvalidEnumArgumentException(string message) {} // 0x0000000183D4CD50-0x0000000183D4CD70
		public InvalidEnumArgumentException(string argumentName, int invalidValue, System.Type enumClass) {} // 0x00000001899E7490-0x00000001899E7558
		protected InvalidEnumArgumentException(SerializationInfo info, StreamingContext context) {} // 0x000000018914CBA0-0x000000018914CBC0
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 45993
	{
		// Fields
		public static readonly ReadOnlyAttribute Yes; // 0x00
		public static readonly ReadOnlyAttribute No; // 0x08
		public static readonly ReadOnlyAttribute Default; // 0x10
	
		// Properties
		public bool IsReadOnly { get; } // 0x00000001811797F0-0x0000000181179800 
	
		// Constructors
		public ReadOnlyAttribute() {} // Dummy constructor
		public ReadOnlyAttribute(bool isReadOnly) {} // 0x0000000183D4E960-0x0000000183D4E970
		static ReadOnlyAttribute() {} // 0x00000001899EC65C-0x00000001899EC734
	
		// Methods
		public override bool Equals(object value) => default; // 0x00000001899EC55C-0x00000001899EC5FC
		public override int GetHashCode() => default; // 0x00000001899E6274-0x00000001899E627C
		public override bool IsDefaultAttribute() => default; // 0x00000001899EC5FC-0x00000001899EC65C
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public sealed class AmbientValueAttribute : Attribute // TypeDefIndex: 45994
	{
		// Properties
		public object Value { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public AmbientValueAttribute() {} // Dummy constructor
	}

	public class ArrayConverter : CollectionConverter // TypeDefIndex: 45996
	{
		// Nested types
		private class ArrayPropertyDescriptor : TypeConverter.SimplePropertyDescriptor // TypeDefIndex: 45995
		{
			// Fields
			private readonly int _index; // 0x98
	
			// Constructors
			public ArrayPropertyDescriptor() {} // Dummy constructor
			public ArrayPropertyDescriptor(System.Type arrayType, System.Type elementType, int index) {} // 0x00000001899DF180-0x00000001899DF22C
	
			// Methods
			public override object GetValue(object instance) => default; // 0x00000001899DF02C-0x00000001899DF0A4
			public override void SetValue(object instance, object value) {} // 0x00000001899DF0A4-0x00000001899DF180
		}
	
		// Constructors
		public ArrayConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001899DED1C-0x00000001899DEE94
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) => default; // 0x00000001899DEE94-0x00000001899DF02C
		public override bool GetPropertiesSupported(ITypeDescriptorContext context) => default; // 0x000000018232EB60-0x000000018232EB70
	}

	public class AttributeCollection : ICollection // TypeDefIndex: 45998
	{
		// Fields
		public static readonly AttributeCollection Empty; // 0x00
		private static Hashtable s_defaultAttributes; // 0x08
		private readonly Attribute[] _attributes; // 0x10
		private static readonly object s_internalSyncObject; // 0x10
		private AttributeEntry[] _foundAttributeTypes; // 0x18
		private int _index; // 0x20
	
		// Properties
		protected virtual Attribute[] Attributes { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public int Count { get => default; } // 0x000000018256FE10-0x000000018256FE30 
		public virtual Attribute this[System.Type attributeType] { get => default; } // 0x00000001825E66B0-0x00000001825E6C80 
		bool ICollection.IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		object ICollection.SyncRoot { get => default; } // 0x0000000181002730-0x0000000181002740 
		int ICollection.Count { get => default; } // 0x00000001899DF2A0-0x00000001899DF2A8 
	
		// Nested types
		private struct AttributeEntry // TypeDefIndex: 45997
		{
			// Fields
			public System.Type type; // 0x00
			public int index; // 0x08
		}
	
		// Constructors
		public AttributeCollection() {} // Dummy constructor
		public AttributeCollection(params Attribute[] attributes) {} // 0x00000001825E7260-0x00000001825E7300
		static AttributeCollection() {} // 0x0000000183CA3500-0x0000000183CA3670
	
		// Methods
		public bool Contains(Attribute attribute) => default; // 0x00000001899DF22C-0x00000001899DF280
		protected Attribute GetDefaultAttribute(System.Type attributeType) => default; // 0x00000001825E60B0-0x00000001825E66B0
		public IEnumerator GetEnumerator() => default; // 0x00000001899DF280-0x00000001899DF2A0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001899DF2A8-0x00000001899DF2B0
		public void CopyTo(Array array, int index) {} // 0x0000000183D2AC70-0x0000000183D2ACB0
	}

	[AttributeUsage(AttributeTargets.Property)]
	public class AttributeProviderAttribute : Attribute // TypeDefIndex: 45999
	{
		// Properties
		public string TypeName { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public string PropertyName { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public AttributeProviderAttribute() {} // Dummy constructor
	}

	public abstract class BaseNumberConverter : TypeConverter // TypeDefIndex: 46000
	{
		// Properties
		internal virtual bool AllowHex { get; } // 0x000000018232EB60-0x000000018232EB70 
		internal abstract System.Type TargetType { get; }
	
		// Constructors
		internal BaseNumberConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal abstract object FromString(string value, int radix);
		internal abstract object FromString(string value, NumberFormatInfo formatInfo);
		internal abstract string ToString(object value, NumberFormatInfo formatInfo);
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x00000001899DF4E8-0x00000001899DF57C
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x00000001899DF5B8-0x00000001899DF910
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001899DF910-0x00000001899DFB58
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x00000001899DF57C-0x00000001899DF5B8
	}

	public class BooleanConverter : TypeConverter // TypeDefIndex: 46001
	{
		// Fields
		private static StandardValuesCollection s_values; // 0x00
	
		// Constructors
		public BooleanConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x00000001899DFB58-0x00000001899DFBEC
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x00000001899DFBEC-0x00000001899DFDC0
		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) => default; // 0x00000001899DFDC0-0x00000001899DFF08
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => default; // 0x000000018232EB60-0x000000018232EB70
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => default; // 0x000000018232EB60-0x000000018232EB70
	}

	public class ByteConverter : BaseNumberConverter // TypeDefIndex: 46002
	{
		// Properties
		internal override System.Type TargetType { get => default; } // 0x00000001899E0260-0x00000001899E02B0 
	
		// Constructors
		public ByteConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal override object FromString(string value, int radix) => default; // 0x00000001899E011C-0x00000001899E0190
		internal override object FromString(string value, NumberFormatInfo formatInfo) => default; // 0x00000001899E0190-0x00000001899E01F0
		internal override string ToString(object value, NumberFormatInfo formatInfo) => default; // 0x00000001899E01F0-0x00000001899E0260
	}

	public class CharConverter : TypeConverter // TypeDefIndex: 46003
	{
		// Constructors
		public CharConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x00000001899E05CC-0x00000001899E0660
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001899E07BC-0x00000001899E08A8
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x00000001899E0660-0x00000001899E07BC
	}

	public enum CollectionChangeAction // TypeDefIndex: 46004
	{
		Add = 1,
		Remove = 2,
		Refresh = 3
	}

	public class CollectionChangeEventArgs : EventArgs // TypeDefIndex: 46005
	{
		// Properties
		public virtual CollectionChangeAction Action { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public virtual object Element { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public CollectionChangeEventArgs() {} // Dummy constructor
		public CollectionChangeEventArgs(CollectionChangeAction action, object element) {} // 0x00000001899E1624-0x00000001899E1684
	}

	public delegate void CollectionChangeEventHandler(object sender, CollectionChangeEventArgs e); // TypeDefIndex: 46006; 0x0000000182065C10-0x0000000182065C20

	public class CultureInfoConverter : TypeConverter // TypeDefIndex: 46009
	{
		// Fields
		private StandardValuesCollection _values; // 0x10
		private const string DefaultInvariantCultureString = "(Default)"; // Metadata: 0x01FBA74F
	
		// Properties
		private string DefaultCultureString { get => default; } // 0x00000001899E27CC-0x00000001899E27F8 
	
		// Nested types
		private class CultureComparer : System.Collections.IComparer // TypeDefIndex: 46007
		{
			// Fields
			private CultureInfoConverter _converter; // 0x10
	
			// Constructors
			public CultureComparer() {} // Dummy constructor
			public CultureComparer(CultureInfoConverter cultureConverter) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public int Compare(object item1, object item2) => default; // 0x00000001899E18A0-0x00000001899E198C
		}
	
		private static class CultureInfoMapper // TypeDefIndex: 46008
		{
			// Fields
			private static readonly Dictionary<string, string> s_cultureInfoNameMap; // 0x00
	
			// Constructors
			static CultureInfoMapper() {} // 0x00000001899E61AC-0x00000001899E61FC
	
			// Methods
			private static Dictionary<string, string> CreateMap() => default; // 0x00000001899E27F8-0x00000001899E6128
			public static string GetCultureInfoName(string cultureInfoDisplayName) => default; // 0x00000001899E6128-0x00000001899E61AC
		}
	
		// Constructors
		public CultureInfoConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected virtual string GetCultureName(CultureInfo culture) => default; // 0x00000001899E2608-0x00000001899E2620
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x00000001899E198C-0x00000001899E1A20
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x00000001899E1A20-0x00000001899E1AB4
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x00000001899E1AB4-0x00000001899E22A8
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001899E22A8-0x00000001899E2608
		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) => default; // 0x00000001899E2620-0x00000001899E27CC
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => default; // 0x000000018115F4C0-0x000000018115F530
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => default; // 0x000000018232EB60-0x000000018232EB70
	}

	public abstract class CustomTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 46010
	{
		// Fields
		private readonly ICustomTypeDescriptor _parent; // 0x10
	
		// Constructors
		protected CustomTypeDescriptor() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual AttributeCollection GetAttributes() => default; // 0x00000001899F7F64-0x00000001899F7FD0
		public virtual TypeConverter GetConverter() => default; // 0x00000001899F7FD0-0x00000001899F8030
		public virtual PropertyDescriptorCollection GetProperties() => default; // 0x00000001899F80A8-0x00000001899F8114
		public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) => default; // 0x00000001899F8030-0x00000001899F80A8
		public virtual object GetPropertyOwner(PropertyDescriptor pd) => default; // 0x00000001899F8114-0x00000001899F8134
	}

	public class DateTimeConverter : TypeConverter // TypeDefIndex: 46011
	{
		// Constructors
		public DateTimeConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x00000001899F8134-0x00000001899F81C8
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x00000001899F81C8-0x00000001899F825C
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x00000001899F825C-0x00000001899F851C
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001899F851C-0x00000001899F8864
	}

	public class DecimalConverter : BaseNumberConverter // TypeDefIndex: 46012
	{
		// Properties
		internal override bool AllowHex { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		internal override System.Type TargetType { get => default; } // 0x00000001899F9B78-0x00000001899F9BC8 
	
		// Constructors
		public DecimalConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x00000001899F96AC-0x00000001899F9740
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001899F9740-0x00000001899F99E0
		internal override object FromString(string value, int radix) => default; // 0x00000001899F9A5C-0x00000001899F9AF8
		internal override object FromString(string value, NumberFormatInfo formatInfo) => default; // 0x00000001899F99E0-0x00000001899F9A5C
		internal override string ToString(object value, NumberFormatInfo formatInfo) => default; // 0x00000001899F9AF8-0x00000001899F9B78
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultEventAttribute : Attribute // TypeDefIndex: 46013
	{
		// Fields
		public static readonly DefaultEventAttribute Default; // 0x00
	
		// Properties
		public string Name { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public DefaultEventAttribute() {} // Dummy constructor
		public DefaultEventAttribute(string name) {} // 0x000000018426FEE0-0x000000018426FEF0
		static DefaultEventAttribute() {} // 0x00000001899F9C24-0x00000001899F9C98
	
		// Methods
		public override bool Equals(object obj) => default; // 0x00000001899F9BC8-0x00000001899F9C24
		public override int GetHashCode() => default; // 0x00000001899E6274-0x00000001899E627C
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultPropertyAttribute : Attribute // TypeDefIndex: 46014
	{
		// Fields
		public static readonly DefaultPropertyAttribute Default; // 0x00
	
		// Properties
		public string Name { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public DefaultPropertyAttribute() {} // Dummy constructor
		public DefaultPropertyAttribute(string name) {} // 0x000000018426FEE0-0x000000018426FEF0
		static DefaultPropertyAttribute() {} // 0x00000001899F9CF4-0x00000001899F9D68
	
		// Methods
		public override bool Equals(object obj) => default; // 0x00000001899F9C98-0x00000001899F9CF4
		public override int GetHashCode() => default; // 0x00000001899E6274-0x00000001899E627C
	}

	internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 46015
	{
		// Fields
		private readonly System.Type _type; // 0x20
	
		// Properties
		internal TypeDescriptionProvider Provider { get => default; } // 0x00000001899F9EC8-0x00000001899F9F18 
	
		// Constructors
		public DelegatingTypeDescriptionProvider() {} // Dummy constructor
		internal DelegatingTypeDescriptionProvider(System.Type type) {} // 0x0000000184271930-0x0000000184271940
	
		// Methods
		public override object CreateInstance(IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args) => default; // 0x00000001899F9D68-0x00000001899F9DC0
		public override IDictionary GetCache(object instance) => default; // 0x00000001899F9DC0-0x00000001899F9DF0
		public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) => default; // 0x00000001899F9DF0-0x00000001899F9E20
		protected internal override IExtenderProvider[] GetExtenderProviders(object instance) => default; // 0x00000001899F9E20-0x00000001899F9E4C
		public override System.Type GetReflectionType(System.Type objectType, object instance) => default; // 0x00000001899F9E4C-0x00000001899F9E88
		public override ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance) => default; // 0x00000001899F9E88-0x00000001899F9EC8
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public class ToolboxItemAttribute : Attribute // TypeDefIndex: 46016
	{
		// Fields
		private string _toolboxItemTypeName; // 0x10
		public static readonly ToolboxItemAttribute Default; // 0x00
		public static readonly ToolboxItemAttribute None; // 0x08
	
		// Properties
		public string ToolboxItemTypeName { get => default; } // 0x0000000189A0AD4C-0x0000000189A0AD98 
	
		// Constructors
		public ToolboxItemAttribute() {} // Dummy constructor
		public ToolboxItemAttribute(bool defaultType) {} // 0x0000000189A0ACFC-0x0000000189A0AD4C
		public ToolboxItemAttribute(string toolboxItemTypeName) {} // 0x0000000189A0AC8C-0x0000000189A0ACFC
		static ToolboxItemAttribute() {} // 0x0000000189A0ABB8-0x0000000189A0AC8C
	
		// Methods
		public override bool IsDefaultAttribute() => default; // 0x0000000189A0AB64-0x0000000189A0ABB8
		public override bool Equals(object obj) => default; // 0x0000000189A0AAB0-0x0000000189A0AB2C
		public override int GetHashCode() => default; // 0x0000000189A0AB2C-0x0000000189A0AB64
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
	public sealed class DesignTimeVisibleAttribute : Attribute // TypeDefIndex: 46017
	{
		// Fields
		public static readonly DesignTimeVisibleAttribute Yes; // 0x00
		public static readonly DesignTimeVisibleAttribute No; // 0x08
		public static readonly DesignTimeVisibleAttribute Default; // 0x10
	
		// Properties
		public bool Visible { get; } // 0x00000001811797F0-0x0000000181179800 
	
		// Constructors
		public DesignTimeVisibleAttribute() {} // Dummy constructor
		public DesignTimeVisibleAttribute(bool visible) {} // 0x0000000183D4E960-0x0000000183D4E970
		static DesignTimeVisibleAttribute() {} // 0x00000001899FA058-0x00000001899FA12C
	
		// Methods
		public override bool Equals(object obj) => default; // 0x00000001899F9F18-0x00000001899F9F78
		public override int GetHashCode() => default; // 0x00000001899F9F78-0x00000001899F9FF8
		public override bool IsDefaultAttribute() => default; // 0x00000001899F9FF8-0x00000001899FA058
	}

	public class DoubleConverter : BaseNumberConverter // TypeDefIndex: 46018
	{
		// Properties
		internal override bool AllowHex { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		internal override System.Type TargetType { get => default; } // 0x00000001899FA298-0x00000001899FA2E8 
	
		// Constructors
		public DoubleConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal override object FromString(string value, int radix) => default; // 0x00000001899FA12C-0x00000001899FA1C0
		internal override object FromString(string value, NumberFormatInfo formatInfo) => default; // 0x00000001899FA1C0-0x00000001899FA224
		internal override string ToString(object value, NumberFormatInfo formatInfo) => default; // 0x00000001899FA224-0x00000001899FA298
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public sealed class EditorAttribute : Attribute // TypeDefIndex: 46019
	{
		// Fields
		private string _typeId; // 0x10
	
		// Properties
		public string EditorBaseTypeName { get; } // 0x0000000181041090-0x00000001810410A0 
		public string EditorTypeName { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public override object TypeId { get => default; } // 0x00000001899FA3F0-0x00000001899FA484 
	
		// Constructors
		public EditorAttribute() {} // Dummy constructor
		public EditorAttribute(string typeName, string baseTypeName) {} // 0x00000001899FA364-0x00000001899FA3F0
	
		// Methods
		public override bool Equals(object obj) => default; // 0x00000001899FA2E8-0x00000001899FA364
		public override int GetHashCode() => default; // 0x00000001899E6274-0x00000001899E627C
	}

	public abstract class EventDescriptor : MemberDescriptor // TypeDefIndex: 46020
	{
		// Constructors
		protected EventDescriptor() {} // Dummy constructor
	}

	public class EventDescriptorCollection : IList // TypeDefIndex: 46022
	{
		// Fields
		private EventDescriptor[] _events; // 0x10
		private string[] _namedSort; // 0x18
		private readonly System.Collections.IComparer _comparer; // 0x20
		private bool _eventsOwned; // 0x28
		private bool _needSort; // 0x29
		private readonly bool _readOnly; // 0x2A
		public static readonly EventDescriptorCollection Empty; // 0x00
	
		// Properties
		public int Count { get; private set; } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000183D4EDE0-0x0000000183D4EDF0
		public virtual EventDescriptor this[int index] { get => default; } // 0x00000001899FC518-0x00000001899FC59C 
		bool ICollection.IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		object ICollection.SyncRoot { get => default; } // 0x0000000181002730-0x0000000181002740 
		int ICollection.Count { get => default; } // 0x0000000183D4EDD0-0x0000000183D4EDE0 
		object IList.this[int index] { get => default; set {} } // 0x00000001899FC2D0-0x00000001899FC2D8 0x00000001899FC2D8-0x00000001899FC3FC
		bool IList.IsReadOnly { get => default; } // 0x0000000183D4F4B0-0x0000000183D4F4C0 
		bool IList.IsFixedSize { get => default; } // 0x0000000183D4F4B0-0x0000000183D4F4C0 
	
		// Nested types
		private class ArraySubsetEnumerator : IEnumerator // TypeDefIndex: 46021
		{
			// Fields
			private readonly Array _array; // 0x10
			private readonly int _total; // 0x18
			private int _current; // 0x1C
	
			// Properties
			public object Current { get => default; } // 0x00000001899F7718-0x00000001899F7784 
	
			// Constructors
			public ArraySubsetEnumerator() {} // Dummy constructor
			public ArraySubsetEnumerator(Array array, int count) {} // 0x00000001899F76F0-0x00000001899F7718
	
			// Methods
			public bool MoveNext() => default; // 0x00000001899F76DC-0x00000001899F76F0
			public void Reset() {} // 0x0000000183D75DD0-0x0000000183D75DE0
		}
	
		// Constructors
		public EventDescriptorCollection() {} // Dummy constructor
		public EventDescriptorCollection(EventDescriptor[] events) {} // 0x00000001899FC474-0x00000001899FC4F0
		public EventDescriptorCollection(EventDescriptor[] events, bool readOnly) {} // 0x00000001899FC4F0-0x00000001899FC518
		static EventDescriptorCollection() {} // 0x00000001899FC3FC-0x00000001899FC474
	
		// Methods
		public int Add(EventDescriptor value) => default; // 0x00000001899FB8BC-0x00000001899FB974
		public void Clear() {} // 0x00000001899FB974-0x00000001899FB9D0
		public bool Contains(EventDescriptor value) => default; // 0x00000001899FB9D0-0x00000001899FB9E8
		void ICollection.CopyTo(Array array, int index) {} // 0x00000001899FC0B4-0x00000001899FC104
		private void EnsureEventsOwned() {} // 0x00000001899FB9E8-0x00000001899FBA84
		private void EnsureSize(int sizeNeeded) {} // 0x00000001899FBA84-0x00000001899FBB70
		public int IndexOf(EventDescriptor value) => default; // 0x00000001899FBBFC-0x00000001899FBC54
		public void Insert(int index, EventDescriptor value) {} // 0x00000001899FBC54-0x00000001899FBD28
		public void Remove(EventDescriptor value) {} // 0x00000001899FC040-0x00000001899FC0B4
		public void RemoveAt(int index) {} // 0x00000001899FBFA0-0x00000001899FC040
		public IEnumerator GetEnumerator() => default; // 0x00000001899FBB70-0x00000001899FBBFC
		protected void InternalSort(string[] names) {} // 0x00000001899FBD8C-0x00000001899FBFA0
		protected void InternalSort(System.Collections.IComparer sorter) {} // 0x00000001899FBD28-0x00000001899FBD8C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001899FC104-0x00000001899FC10C
		int IList.Add(object value) => default; // 0x00000001899FC10C-0x00000001899FC160
		bool IList.Contains(object value) => default; // 0x00000001899FC168-0x00000001899FC1BC
		void IList.Clear() {} // 0x00000001899FC160-0x00000001899FC168
		int IList.IndexOf(object value) => default; // 0x00000001899FC1BC-0x00000001899FC210
		void IList.Insert(int index, object value) {} // 0x00000001899FC210-0x00000001899FC274
		void IList.Remove(object value) {} // 0x00000001899FC27C-0x00000001899FC2D0
		void IList.RemoveAt(int index) {} // 0x00000001899FC274-0x00000001899FC27C
	}

	public class ExpandableObjectConverter : TypeConverter // TypeDefIndex: 46023
	{
		// Constructors
		public ExpandableObjectConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) => default; // 0x00000001899FC59C-0x00000001899FC5F8
		public override bool GetPropertiesSupported(ITypeDescriptorContext context) => default; // 0x000000018232EB60-0x000000018232EB70
	}

	internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 46024
	{
		// Fields
		private readonly ReflectPropertyDescriptor _extenderInfo; // 0x88
		private readonly IExtenderProvider _provider; // 0x90
	
		// Properties
		public override System.Type ComponentType { get => default; } // 0x00000001899FC8C4-0x00000001899FC8E8 
		public override bool IsReadOnly { get => default; } // 0x00000001899FCA20-0x00000001899FCADC 
		public override System.Type PropertyType { get => default; } // 0x00000001899FCADC-0x00000001899FCB00 
		public override string DisplayName { get => default; } // 0x00000001899FC8E8-0x00000001899FCA20 
	
		// Constructors
		public ExtendedPropertyDescriptor() {} // Dummy constructor
		public ExtendedPropertyDescriptor(ReflectPropertyDescriptor extenderInfo, System.Type receiverType, IExtenderProvider provider, Attribute[] attributes) {} // 0x00000001899FC710-0x00000001899FC8C4
	
		// Methods
		public override bool CanResetValue(object comp) => default; // 0x00000001899FC5F8-0x00000001899FC62C
		public override object GetValue(object comp) => default; // 0x00000001899FC62C-0x00000001899FC660
		public override void ResetValue(object comp) {} // 0x00000001899FC660-0x00000001899FC69C
		public override void SetValue(object component, object value) {} // 0x00000001899FC69C-0x00000001899FC6DC
		public override bool ShouldSerializeValue(object comp) => default; // 0x00000001899FC6DC-0x00000001899FC710
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public sealed class ExtenderProvidedPropertyAttribute : Attribute // TypeDefIndex: 46025
	{
		// Properties
		public PropertyDescriptor ExtenderProperty { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public IExtenderProvider Provider { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public System.Type ReceiverType { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Constructors
		public ExtenderProvidedPropertyAttribute() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, System.Type receiverType, IExtenderProvider provider) => default; // 0x00000001899FCB00-0x00000001899FCB88
		public override bool Equals(object obj) => default; // 0x00000001899FCB88-0x00000001899FCC28
		public override int GetHashCode() => default; // 0x00000001899E6274-0x00000001899E627C
		public override bool IsDefaultAttribute() => default; // 0x00000001899FCC28-0x00000001899FCC74
	}

	public class GuidConverter : TypeConverter // TypeDefIndex: 46026
	{
		// Constructors
		public GuidConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x00000001899FCC74-0x00000001899FCD08
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x00000001899FCD08-0x00000001899FCD9C
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x00000001899FCD9C-0x00000001899FCE64
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001899FCE64-0x00000001899FD104
	}

	public interface IBindingList : IList // TypeDefIndex: 46027
	{
	}

	public interface ICustomTypeDescriptor // TypeDefIndex: 46028
	{
		// Methods
		AttributeCollection GetAttributes();
		TypeConverter GetConverter();
		PropertyDescriptorCollection GetProperties();
		PropertyDescriptorCollection GetProperties(Attribute[] attributes);
		object GetPropertyOwner(PropertyDescriptor pd);
	}

	public interface IExtenderProvider // TypeDefIndex: 46029
	{
		// Methods
		bool CanExtend(object extendee);
	}

	public interface ITypeDescriptorContext : IServiceProvider // TypeDefIndex: 46030
	{
		// Properties
		System.ComponentModel.IContainer Container { get; }
	}

	public class Int16Converter : BaseNumberConverter // TypeDefIndex: 46031
	{
		// Properties
		internal override System.Type TargetType { get => default; } // 0x00000001899FD24C-0x00000001899FD29C 
	
		// Constructors
		public Int16Converter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal override object FromString(string value, int radix) => default; // 0x00000001899FD164-0x00000001899FD1D8
		internal override object FromString(string value, NumberFormatInfo formatInfo) => default; // 0x00000001899FD104-0x00000001899FD164
		internal override string ToString(object value, NumberFormatInfo formatInfo) => default; // 0x00000001899FD1D8-0x00000001899FD24C
	}

	public class Int32Converter : BaseNumberConverter // TypeDefIndex: 46032
	{
		// Properties
		internal override System.Type TargetType { get => default; } // 0x00000001899FD3E0-0x00000001899FD430 
	
		// Constructors
		public Int32Converter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal override object FromString(string value, int radix) => default; // 0x00000001899FD29C-0x00000001899FD310
		internal override object FromString(string value, NumberFormatInfo formatInfo) => default; // 0x00000001899FD310-0x00000001899FD370
		internal override string ToString(object value, NumberFormatInfo formatInfo) => default; // 0x00000001899FD370-0x00000001899FD3E0
	}

	public class Int64Converter : BaseNumberConverter // TypeDefIndex: 46033
	{
		// Properties
		internal override System.Type TargetType { get => default; } // 0x00000001899FD578-0x00000001899FD5C8 
	
		// Constructors
		public Int64Converter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal override object FromString(string value, int radix) => default; // 0x00000001899FD490-0x00000001899FD504
		internal override object FromString(string value, NumberFormatInfo formatInfo) => default; // 0x00000001899FD430-0x00000001899FD490
		internal override string ToString(object value, NumberFormatInfo formatInfo) => default; // 0x00000001899FD504-0x00000001899FD578
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public sealed class ListBindableAttribute : Attribute // TypeDefIndex: 46034
	{
		// Fields
		public static readonly ListBindableAttribute Yes; // 0x00
		public static readonly ListBindableAttribute No; // 0x08
		public static readonly ListBindableAttribute Default; // 0x10
		private bool _isDefault; // 0x10
	
		// Properties
		public bool ListBindable { get; } // 0x0000000183D510E0-0x0000000183D510F0 
	
		// Constructors
		public ListBindableAttribute() {} // Dummy constructor
		public ListBindableAttribute(bool listBindable) {} // 0x0000000183D510F0-0x0000000183D51100
		static ListBindableAttribute() {} // 0x00000001899FD684-0x00000001899FD758
	
		// Methods
		public override bool Equals(object obj) => default; // 0x00000001899FD5C8-0x00000001899FD628
		public override int GetHashCode() => default; // 0x00000001899E6274-0x00000001899E627C
		public override bool IsDefaultAttribute() => default; // 0x00000001899FD628-0x00000001899FD684
	}

	public class ListChangedEventArgs : EventArgs // TypeDefIndex: 46035
	{
		// Properties
		public ListChangedType ListChangedType { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public int NewIndex { get; } // 0x0000000183D50CC0-0x0000000183D50CD0 
		public int OldIndex { get; } // 0x00000001820D1AC0-0x00000001820D1AD0 
	
		// Constructors
		public ListChangedEventArgs() {} // Dummy constructor
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex) {} // 0x00000001899FD820-0x00000001899FD840
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) {} // 0x00000001899FD840-0x00000001899FD880
		public ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc) {} // 0x00000001899FD758-0x00000001899FD7B8
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex) {} // 0x00000001899FD7B8-0x00000001899FD820
	}

	public delegate void ListChangedEventHandler(object sender, ListChangedEventArgs e); // TypeDefIndex: 46036; 0x0000000182065C10-0x0000000182065C20

	public enum ListChangedType // TypeDefIndex: 46037
	{
		Reset = 0,
		ItemAdded = 1,
		ItemDeleted = 2,
		ItemMoved = 3,
		ItemChanged = 4,
		PropertyDescriptorAdded = 5,
		PropertyDescriptorDeleted = 6,
		PropertyDescriptorChanged = 7
	}

	[DesignerCategory("Component")]
	[TypeConverter(typeof(ComponentConverter))]
	public class MarshalByValueComponent : IComponent, IServiceProvider // TypeDefIndex: 46038
	{
		// Fields
		private static readonly object s_eventDisposed; // 0x00
		private ISite _site; // 0x10
		private EventHandlerList _events; // 0x18
	
		// Properties
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual ISite Site { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public MarshalByValueComponent() {} // 0x000000018350B670-0x000000018350B680
		static MarshalByValueComponent() {} // 0x00000001899FDBE8-0x00000001899FDC58
	
		// Methods
		~MarshalByValueComponent() {} // 0x00000001899FDA88-0x00000001899FDB00
		public void Dispose() {} // 0x00000001899FD880-0x00000001899FD8D0
		protected virtual void Dispose(bool disposing) {} // 0x00000001899FD8D0-0x00000001899FDA88
		public virtual object GetService(System.Type service) => default; // 0x00000001899FDB00-0x00000001899FDB20
		public override string ToString() => default; // 0x00000001899FDB20-0x00000001899FDBE8
	}

	public class MultilineStringConverter : TypeConverter // TypeDefIndex: 46039
	{
		// Constructors
		public MultilineStringConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001899FF2CC-0x00000001899FF40C
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) => default; // 0x0000000181002730-0x0000000181002740
		public override bool GetPropertiesSupported(ITypeDescriptorContext context) => default; // 0x000000018115F4C0-0x000000018115F530
	}

	public class NullableConverter : TypeConverter // TypeDefIndex: 46040
	{
		// Properties
		public System.Type NullableType { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public System.Type UnderlyingType { get; } // 0x0000000181041090-0x00000001810410A0 
		public TypeConverter UnderlyingTypeConverter { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public NullableConverter() {} // Dummy constructor
		public NullableConverter(System.Type type) {} // 0x00000001899FFBB4-0x00000001899FFCBC
	
		// Methods
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x00000001899FF40C-0x00000001899FF4AC
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x00000001899FF54C-0x00000001899FF634
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x00000001899FF4AC-0x00000001899FF54C
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001899FF634-0x00000001899FF7CC
		public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) => default; // 0x00000001899FF7CC-0x00000001899FF7F4
		public override bool GetCreateInstanceSupported(ITypeDescriptorContext context) => default; // 0x00000001899FF7F4-0x00000001899FF814
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) => default; // 0x00000001899FF834-0x00000001899FF854
		public override bool GetPropertiesSupported(ITypeDescriptorContext context) => default; // 0x00000001899FF814-0x00000001899FF834
		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) => default; // 0x00000001899FF894-0x00000001899FFB68
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => default; // 0x00000001899FF854-0x00000001899FF874
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => default; // 0x00000001899FF874-0x00000001899FF894
		public override bool IsValid(ITypeDescriptorContext context, object value) => default; // 0x00000001899FFB68-0x00000001899FFBB4
	}

	public abstract class PropertyDescriptor : MemberDescriptor // TypeDefIndex: 46041
	{
		// Fields
		private TypeConverter _converter; // 0x60
		private Hashtable _valueChangedHandlers; // 0x68
		private object[] _editors; // 0x70
		private System.Type[] _editorTypes; // 0x78
		private int _editorCount; // 0x80
	
		// Properties
		public abstract System.Type ComponentType { get; }
		public virtual TypeConverter Converter { get; } // 0x0000000189A01F14-0x0000000189A020F0 
		public abstract bool IsReadOnly { get; }
		public abstract System.Type PropertyType { get; }
	
		// Constructors
		protected PropertyDescriptor() {} // Dummy constructor
		protected PropertyDescriptor(string name, Attribute[] attrs) {} // 0x0000000189A01F04-0x0000000189A01F0C
		protected PropertyDescriptor(MemberDescriptor descr, Attribute[] attrs) {} // 0x0000000189A01F0C-0x0000000189A01F14
	
		// Methods
		public abstract bool CanResetValue(object component);
		public override bool Equals(object obj) => default; // 0x0000000189A01A2C-0x0000000189A01BB8
		protected object CreateInstance(System.Type type) => default; // 0x0000000189A01894-0x0000000189A01A2C
		protected override void FillAttributes(IList attributeList) {} // 0x0000000189A01BB8-0x0000000189A01C08
		public override int GetHashCode() => default; // 0x0000000189A01C08-0x0000000189A01C58
		protected override object GetInvocationTarget(System.Type type, object instance) => default; // 0x0000000189A01C58-0x0000000189A01CD8
		protected System.Type GetTypeFromName(string typeName) => default; // 0x0000000189A01CD8-0x0000000189A01E78
		public abstract object GetValue(object component);
		protected virtual void OnValueChanged(object component, EventArgs e) {} // 0x0000000189A01E78-0x0000000189A01F04
		public abstract void ResetValue(object component);
		public abstract void SetValue(object component, object value);
		public abstract bool ShouldSerializeValue(object component);
	}

	public class PropertyDescriptorCollection : IList, IDictionary // TypeDefIndex: 46043
	{
		// Fields
		public static readonly PropertyDescriptorCollection Empty; // 0x00
		private IDictionary _cachedFoundProperties; // 0x10
		private bool _cachedIgnoreCase; // 0x18
		private PropertyDescriptor[] _properties; // 0x20
		private readonly string[] _namedSort; // 0x28
		private readonly System.Collections.IComparer _comparer; // 0x30
		private bool _propsOwned; // 0x38
		private bool _needSort; // 0x39
		private bool _readOnly; // 0x3A
		private readonly object _internalSyncObject; // 0x40
	
		// Properties
		public int Count { get; private set; } // 0x0000000183D4EC50-0x0000000183D4EC60 0x0000000183D4ECD0-0x0000000183D4ECE0
		public virtual PropertyDescriptor this[int index] { get => default; } // 0x0000000189A016EC-0x0000000189A01770 
		public virtual PropertyDescriptor this[string name] { get => default; } // 0x0000000189A01770-0x0000000189A0177C 
		bool ICollection.IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		object ICollection.SyncRoot { get => default; } // 0x0000000181002730-0x0000000181002740 
		int ICollection.Count { get => default; } // 0x0000000183D4EC50-0x0000000183D4EC60 
		bool IDictionary.IsFixedSize { get => default; } // 0x0000000183D4F500-0x0000000183D4F510 
		bool IDictionary.IsReadOnly { get => default; } // 0x0000000183D4F500-0x0000000183D4F510 
		object IDictionary.this[object key] { get => default; set {} } // 0x0000000189A00CA0-0x0000000189A00D00 0x0000000189A00E44-0x0000000189A01150
		ICollection IDictionary.Keys { get => default; } // 0x0000000189A00D00-0x0000000189A00DA4 
		ICollection IDictionary.Values { get => default; } // 0x0000000189A00DA4-0x0000000189A00E44 
		bool IList.IsReadOnly { get => default; } // 0x0000000183D4F500-0x0000000183D4F510 
		bool IList.IsFixedSize { get => default; } // 0x0000000183D4F500-0x0000000183D4F510 
		object IList.this[int index] { get => default; set {} } // 0x0000000189A01314-0x0000000189A0131C 0x0000000189A0131C-0x0000000189A014B0
	
		// Nested types
		private class PropertyDescriptorEnumerator : IDictionaryEnumerator // TypeDefIndex: 46042
		{
			// Fields
			private PropertyDescriptorCollection _owner; // 0x10
			private int _index; // 0x18
	
			// Properties
			public object Current { get => default; } // 0x0000000189A017A8-0x0000000189A01800 
			public DictionaryEntry Entry { get => default; } // 0x0000000189A01800-0x0000000189A01860 
			public object Key { get => default; } // 0x0000000189A01860-0x0000000189A01894 
			public object Value { get => default; } // 0x0000000189A01860-0x0000000189A01894 
	
			// Constructors
			public PropertyDescriptorEnumerator() {} // Dummy constructor
			public PropertyDescriptorEnumerator(PropertyDescriptorCollection owner) {} // 0x00000001825CE600-0x00000001825CE620
	
			// Methods
			public bool MoveNext() => default; // 0x0000000189A0177C-0x0000000189A017A8
			public void Reset() {} // 0x0000000183D50330-0x0000000183D50340
		}
	
		// Constructors
		public PropertyDescriptorCollection() {} // Dummy constructor
		public PropertyDescriptorCollection(PropertyDescriptor[] properties) {} // 0x0000000189A01610-0x0000000189A016C4
		public PropertyDescriptorCollection(PropertyDescriptor[] properties, bool readOnly) {} // 0x0000000189A016C4-0x0000000189A016EC
		private PropertyDescriptorCollection(PropertyDescriptor[] properties, int propCount, string[] namedSort, System.Collections.IComparer comparer) {} // 0x0000000189A01528-0x0000000189A01610
		static PropertyDescriptorCollection() {} // 0x0000000189A014B0-0x0000000189A01528
	
		// Methods
		public int Add(PropertyDescriptor value) => default; // 0x00000001899FFD6C-0x00000001899FFE24
		public void Clear() {} // 0x00000001899FFE24-0x00000001899FFE8C
		public bool Contains(PropertyDescriptor value) => default; // 0x00000001899FFE8C-0x00000001899FFEA4
		public void CopyTo(Array array, int index) {} // 0x00000001899FFEA4-0x00000001899FFEF4
		private void EnsurePropsOwned() {} // 0x00000001899FFEF4-0x00000001899FFF90
		private void EnsureSize(int sizeNeeded) {} // 0x00000001899FFF90-0x0000000189A0007C
		public virtual PropertyDescriptor Find(string name, bool ignoreCase) => default; // 0x0000000189A0007C-0x0000000189A004D0
		public int IndexOf(PropertyDescriptor value) => default; // 0x0000000189A00568-0x0000000189A005C0
		public void Insert(int index, PropertyDescriptor value) {} // 0x0000000189A005C0-0x0000000189A00694
		public void Remove(PropertyDescriptor value) {} // 0x0000000189A009AC-0x0000000189A00A20
		public void RemoveAt(int index) {} // 0x0000000189A0090C-0x0000000189A009AC
		public virtual PropertyDescriptorCollection Sort(string[] names) => default; // 0x0000000189A00A20-0x0000000189A00ABC
		protected void InternalSort(string[] names) {} // 0x0000000189A006F8-0x0000000189A0090C
		protected void InternalSort(System.Collections.IComparer sorter) {} // 0x0000000189A00694-0x0000000189A006F8
		public virtual IEnumerator GetEnumerator() => default; // 0x0000000189A004D0-0x0000000189A00568
		void IList.Clear() {} // 0x0000000189A00B68-0x0000000189A00B70
		void IDictionary.Clear() {} // 0x0000000189A00B68-0x0000000189A00B70
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189A01150-0x0000000189A01158
		void IList.RemoveAt(int index) {} // 0x0000000189A012B8-0x0000000189A012C0
		void IDictionary.Add(object key, object value) {} // 0x0000000189A00ABC-0x0000000189A00B68
		bool IDictionary.Contains(object key) => default; // 0x0000000189A00B70-0x0000000189A00BD4
		IDictionaryEnumerator IDictionary.GetEnumerator() => default; // 0x0000000189A00BD4-0x0000000189A00C34
		void IDictionary.Remove(object key) {} // 0x0000000189A00C34-0x0000000189A00CA0
		int IList.Add(object value) => default; // 0x0000000189A01158-0x0000000189A011AC
		bool IList.Contains(object value) => default; // 0x0000000189A011AC-0x0000000189A01200
		int IList.IndexOf(object value) => default; // 0x0000000189A01200-0x0000000189A01254
		void IList.Insert(int index, object value) {} // 0x0000000189A01254-0x0000000189A012B8
		void IList.Remove(object value) {} // 0x0000000189A012C0-0x0000000189A01314
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class ProvidePropertyAttribute : Attribute // TypeDefIndex: 46044
	{
		// Properties
		public string PropertyName { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public string ReceiverTypeName { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public ProvidePropertyAttribute() {} // Dummy constructor
	}

	public class ReferenceConverter : TypeConverter // TypeDefIndex: 46046
	{
		// Fields
		private static readonly string s_none; // 0x00
		private System.Type _type; // 0x10
	
		// Nested types
		private class ReferenceComparer : System.Collections.IComparer // TypeDefIndex: 46045
		{
			// Fields
			private ReferenceConverter _converter; // 0x10
	
			// Constructors
			public ReferenceComparer() {} // Dummy constructor
			public ReferenceComparer(ReferenceConverter converter) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public int Compare(object item1, object item2) => default; // 0x0000000189A020F0-0x0000000189A02194
		}
	
		// Constructors
		public ReferenceConverter() {} // Dummy constructor
		public ReferenceConverter(System.Type type) {} // 0x000000018426FEE0-0x000000018426FEF0
		static ReferenceConverter() {} // 0x0000000189A02D64-0x0000000189A02DC0
	
		// Methods
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x0000000189A02194-0x0000000189A0222C
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x0000000189A0222C-0x0000000189A023D0
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x0000000189A023D0-0x0000000189A02648
		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) => default; // 0x0000000189A02648-0x0000000189A02D64
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => default; // 0x000000018232EB60-0x000000018232EB70
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => default; // 0x000000018232EB60-0x000000018232EB70
		protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value) => default; // 0x000000018232EB60-0x000000018232EB70
	}

	public class RefreshEventArgs : EventArgs // TypeDefIndex: 46047
	{
		// Constructors
		public RefreshEventArgs() {} // Dummy constructor
		public RefreshEventArgs(System.Type typeChanged) {} // 0x0000000189A099F4-0x0000000189A09A4C
	}

	public delegate void RefreshEventHandler(RefreshEventArgs e); // TypeDefIndex: 46048; 0x0000000182149960-0x0000000182149970

	public class SByteConverter : BaseNumberConverter // TypeDefIndex: 46049
	{
		// Properties
		internal override System.Type TargetType { get => default; } // 0x0000000189A09B90-0x0000000189A09BE0 
	
		// Constructors
		public SByteConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal override object FromString(string value, int radix) => default; // 0x0000000189A09A4C-0x0000000189A09AC0
		internal override object FromString(string value, NumberFormatInfo formatInfo) => default; // 0x0000000189A09AC0-0x0000000189A09B20
		internal override string ToString(object value, NumberFormatInfo formatInfo) => default; // 0x0000000189A09B20-0x0000000189A09B90
	}

	[AttributeUsage(AttributeTargets.Property)]
	public sealed class SettingsBindableAttribute : Attribute // TypeDefIndex: 46050
	{
		// Fields
		public static readonly SettingsBindableAttribute Yes; // 0x00
		public static readonly SettingsBindableAttribute No; // 0x08
	
		// Properties
		public bool Bindable { get; } // 0x00000001811797F0-0x0000000181179800 
	
		// Constructors
		public SettingsBindableAttribute() {} // Dummy constructor
		public SettingsBindableAttribute(bool bindable) {} // 0x0000000183D4E960-0x0000000183D4E970
		static SettingsBindableAttribute() {} // 0x0000000189A09C8C-0x0000000189A09D30
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189A09BE0-0x0000000189A09C40
		public override int GetHashCode() => default; // 0x0000000189A09C40-0x0000000189A09C8C
	}

	public class SingleConverter : BaseNumberConverter // TypeDefIndex: 46051
	{
		// Properties
		internal override bool AllowHex { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		internal override System.Type TargetType { get => default; } // 0x0000000189A0A18C-0x0000000189A0A1DC 
	
		// Constructors
		public SingleConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal override object FromString(string value, int radix) => default; // 0x0000000189A0A084-0x0000000189A0A118
		internal override object FromString(string value, NumberFormatInfo formatInfo) => default; // 0x0000000189A0A020-0x0000000189A0A084
		internal override string ToString(object value, NumberFormatInfo formatInfo) => default; // 0x0000000189A0A118-0x0000000189A0A18C
	}

	public class StringConverter : TypeConverter // TypeDefIndex: 46052
	{
		// Constructors
		public StringConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x0000000189A0A3EC-0x0000000189A0A480
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x0000000189A0A480-0x0000000189A0A514
	}

	public class TimeSpanConverter : TypeConverter // TypeDefIndex: 46053
	{
		// Constructors
		public TimeSpanConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x0000000189A0A514-0x0000000189A0A5A8
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x0000000189A0A5A8-0x0000000189A0A63C
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x0000000189A0A63C-0x0000000189A0A818
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x0000000189A0A818-0x0000000189A0AAB0
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public sealed class TypeConverterAttribute : Attribute // TypeDefIndex: 46054
	{
		// Fields
		public static readonly TypeConverterAttribute Default; // 0x00
	
		// Properties
		public string ConverterTypeName { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public TypeConverterAttribute() {} // 0x0000000183CB2260-0x0000000183CB22B0
		public TypeConverterAttribute(System.Type type) {} // 0x0000000189A0ADF4-0x0000000189A0AE24
		public TypeConverterAttribute(string typeName) {} // 0x000000018426FEE0-0x000000018426FEF0
		static TypeConverterAttribute() {} // 0x0000000183CB21F0-0x0000000183CB2260
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189A0AD98-0x0000000189A0ADF4
		public override int GetHashCode() => default; // 0x0000000186FAB9A8-0x0000000186FAB9CC
	}

	public abstract class TypeDescriptionProvider // TypeDefIndex: 46056
	{
		// Fields
		private readonly TypeDescriptionProvider _parent; // 0x10
		private EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18
	
		// Nested types
		private sealed class EmptyCustomTypeDescriptor : CustomTypeDescriptor // TypeDefIndex: 46055
		{
			// Constructors
			public EmptyCustomTypeDescriptor() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		protected TypeDescriptionProvider() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual object CreateInstance(IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args) => default; // 0x0000000189A0BC40-0x0000000189A0BD34
		public virtual IDictionary GetCache(object instance) => default; // 0x0000000189A0BD34-0x0000000189A0BD58
		public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) => default; // 0x0000000189A0BD58-0x0000000189A0BDE4
		protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance) => default; // 0x0000000189A0BDE4-0x0000000189A0BE9C
		public System.Type GetReflectionType(System.Type objectType) => default; // 0x0000000184277044-0x0000000184277054
		public virtual System.Type GetReflectionType(System.Type objectType, object instance) => default; // 0x0000000189A0BE9C-0x0000000189A0BEB8
		public ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType) => default; // 0x00000001842709BC-0x00000001842709D4
		public ICustomTypeDescriptor GetTypeDescriptor(object instance) => default; // 0x0000000189A0BF54-0x0000000189A0BFE4
		public virtual ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance) => default; // 0x0000000189A0BEB8-0x0000000189A0BF54
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public sealed class TypeDescriptionProviderAttribute : Attribute // TypeDefIndex: 46057
	{
		// Properties
		public string TypeName { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public TypeDescriptionProviderAttribute() {} // Dummy constructor
		public TypeDescriptionProviderAttribute(string typeName) {} // 0x0000000189A0BBCC-0x0000000189A0BC40
	}

	public abstract class TypeListConverter : TypeConverter // TypeDefIndex: 46058
	{
		// Fields
		private readonly System.Type[] _types; // 0x10
		private StandardValuesCollection _values; // 0x18
	
		// Constructors
		protected TypeListConverter() {} // Dummy constructor
		protected TypeListConverter(System.Type[] types) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x0000000189A10A94-0x0000000189A10B28
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x0000000189A10B28-0x0000000189A10BBC
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x0000000189A10BBC-0x0000000189A10C9C
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x0000000189A10C9C-0x0000000189A10DFC
		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) => default; // 0x0000000189A10DFC-0x0000000189A10EC4
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => default; // 0x000000018232EB60-0x000000018232EB70
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => default; // 0x000000018232EB60-0x000000018232EB70
	}

	public class UInt16Converter : BaseNumberConverter // TypeDefIndex: 46059
	{
		// Properties
		internal override System.Type TargetType { get => default; } // 0x0000000189A1100C-0x0000000189A1105C 
	
		// Constructors
		public UInt16Converter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal override object FromString(string value, int radix) => default; // 0x0000000189A10EC4-0x0000000189A10F38
		internal override object FromString(string value, NumberFormatInfo formatInfo) => default; // 0x0000000189A10F38-0x0000000189A10F98
		internal override string ToString(object value, NumberFormatInfo formatInfo) => default; // 0x0000000189A10F98-0x0000000189A1100C
	}

	public class UInt32Converter : BaseNumberConverter // TypeDefIndex: 46060
	{
		// Properties
		internal override System.Type TargetType { get => default; } // 0x0000000189A111A0-0x0000000189A111F0 
	
		// Constructors
		public UInt32Converter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal override object FromString(string value, int radix) => default; // 0x0000000189A1105C-0x0000000189A110D0
		internal override object FromString(string value, NumberFormatInfo formatInfo) => default; // 0x0000000189A110D0-0x0000000189A11130
		internal override string ToString(object value, NumberFormatInfo formatInfo) => default; // 0x0000000189A11130-0x0000000189A111A0
	}

	public class UInt64Converter : BaseNumberConverter // TypeDefIndex: 46061
	{
		// Properties
		internal override System.Type TargetType { get => default; } // 0x0000000189A11338-0x0000000189A11388 
	
		// Constructors
		public UInt64Converter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal override object FromString(string value, int radix) => default; // 0x0000000189A11250-0x0000000189A112C4
		internal override object FromString(string value, NumberFormatInfo formatInfo) => default; // 0x0000000189A111F0-0x0000000189A11250
		internal override string ToString(object value, NumberFormatInfo formatInfo) => default; // 0x0000000189A112C4-0x0000000189A11338
	}

	public interface IChangeTracking // TypeDefIndex: 46062
	{
		// Properties
		bool IsChanged { get; }
	
		// Methods
		void AcceptChanges();
	}

	public interface IRevertibleChangeTracking : IChangeTracking // TypeDefIndex: 46063
	{
		// Methods
		void RejectChanges();
	}

	public interface INotifyPropertyChanged // TypeDefIndex: 46064
	{
		// Events
		event PropertyChangedEventHandler PropertyChanged;
	}

	public class PropertyChangedEventArgs : EventArgs // TypeDefIndex: 46065
	{
		// Fields
		private readonly string _propertyName; // 0x10
	
		// Constructors
		public PropertyChangedEventArgs() {} // Dummy constructor
		public PropertyChangedEventArgs(string propertyName) {} // 0x00000001899FFCBC-0x00000001899FFD14
	}

	public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e); // TypeDefIndex: 46066; 0x0000000182065C10-0x0000000182065C20

	public class PropertyChangingEventArgs : EventArgs // TypeDefIndex: 46067
	{
		// Fields
		private readonly string _propertyName; // 0x10
	
		// Constructors
		public PropertyChangingEventArgs() {} // Dummy constructor
		public PropertyChangingEventArgs(string propertyName) {} // 0x00000001899FFD14-0x00000001899FFD6C
	}

	public delegate void PropertyChangingEventHandler(object sender, PropertyChangingEventArgs e); // TypeDefIndex: 46068; 0x0000000182065C10-0x0000000182065C20

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public class CategoryAttribute : Attribute // TypeDefIndex: 46069
	{
		// Fields
		private bool localized; // 0x10
		private string categoryValue; // 0x18
	
		// Properties
		public string Category { get => default; } // 0x00000001899F7B88-0x00000001899F7BCC 
	
		// Constructors
		public CategoryAttribute() {} // Dummy constructor
	
		// Methods
		protected virtual string GetLocalizedString(string value) => default; // 0x00000001899F7784-0x00000001899F7B88
	}

	public class CollectionConverter : TypeConverter // TypeDefIndex: 46070
	{
		// Constructors
		public CollectionConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001899F7BCC-0x00000001899F7D10
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) => default; // 0x0000000181002730-0x0000000181002740
		public override bool GetPropertiesSupported(ITypeDescriptorContext context) => default; // 0x000000018115F4C0-0x000000018115F530
	}

	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[DesignerCategory("Component")]
	public class Component : MarshalByRefObject, IComponent // TypeDefIndex: 46071
	{
		// Fields
		private static readonly object EventDisposed; // 0x00
		private ISite site; // 0x18
		private EventHandlerList events; // 0x20
	
		// Properties
		protected virtual bool CanRaiseEvents { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		internal bool CanRaiseEventsInternal { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual ISite Site { get => default; } // 0x0000000181041090-0x00000001810410A0 
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		protected bool DesignMode { get => default; } // 0x00000001899F7F18-0x00000001899F7F64 
	
		// Constructors
		public Component() {} // 0x000000018350B670-0x000000018350B680
		static Component() {} // 0x0000000183D371B0-0x0000000183D37220
	
		// Methods
		~Component() {} // 0x00000001899F7DC4-0x00000001899F7E3C
		public void Dispose() {} // 0x00000001839A20F0-0x00000001839A2150
		protected virtual void Dispose(bool disposing) {} // 0x0000000182C9BDD0-0x0000000182C9C1F0
		protected virtual object GetService(System.Type service) => default; // 0x00000001899F7E3C-0x00000001899F7E50
		public override string ToString() => default; // 0x00000001899F7E50-0x00000001899F7F18
	}

	public class ComponentConverter : ReferenceConverter // TypeDefIndex: 46072
	{
		// Constructors
		public ComponentConverter() {} // Dummy constructor
		public ComponentConverter(System.Type type) {} // 0x00000001899F7D6C-0x00000001899F7DC4
	
		// Methods
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) => default; // 0x00000001899F7D10-0x00000001899F7D6C
		public override bool GetPropertiesSupported(ITypeDescriptorContext context) => default; // 0x000000018232EB60-0x000000018232EB70
	}

	public class DateTimeOffsetConverter : TypeConverter // TypeDefIndex: 46073
	{
		// Constructors
		public DateTimeOffsetConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x00000001899F8864-0x00000001899F88F8
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x00000001899F88F8-0x00000001899F898C
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x00000001899F898C-0x00000001899F8CE4
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001899F8CE4-0x00000001899F96AC
	}

	public class EnumConverter : TypeConverter // TypeDefIndex: 46074
	{
		// Fields
		private StandardValuesCollection values; // 0x10
		private System.Type type; // 0x18
	
		// Properties
		protected System.Type EnumType { get => default; } // 0x0000000181041090-0x00000001810410A0 
		protected StandardValuesCollection Values { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		protected virtual System.Collections.IComparer Comparer { get => default; } // 0x00000001899FB86C-0x00000001899FB8BC 
	
		// Constructors
		public EnumConverter() {} // Dummy constructor
		public EnumConverter(System.Type type) {} // 0x00000001822C3A90-0x00000001822C3AA0
	
		// Methods
		public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x00000001899FA484-0x00000001899FA544
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x00000001899FA544-0x00000001899FA604
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x00000001899FA604-0x00000001899FAA2C
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x00000001899FAA2C-0x00000001899FB3F4
		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) => default; // 0x00000001899FB478-0x00000001899FB818
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => default; // 0x00000001899FB3F4-0x00000001899FB478
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => default; // 0x000000018232EB60-0x000000018232EB70
		public override bool IsValid(ITypeDescriptorContext context, object value) => default; // 0x00000001899FB818-0x00000001899FB86C
	}

	[ComVisible(true)]
	[RootDesignerSerializer("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true)]
	[TypeConverter(typeof(ComponentConverter))]
	public interface IComponent : IDisposable // TypeDefIndex: 46075
	{
		// Properties
		ISite Site { get; }
	}

	[ComVisible(true)]
	public abstract class MemberDescriptor // TypeDefIndex: 46076
	{
		// Fields
		private string name; // 0x10
		private string displayName; // 0x18
		private int nameHash; // 0x20
		private AttributeCollection attributeCollection; // 0x28
		private Attribute[] attributes; // 0x30
		private Attribute[] originalAttributes; // 0x38
		private bool attributesFiltered; // 0x40
		private bool attributesFilled; // 0x41
		private int metadataVersion; // 0x44
		private string category; // 0x48
		private string description; // 0x50
		private object lockCookie; // 0x58
	
		// Properties
		protected virtual Attribute[] AttributeArray { get; set; } // 0x00000001899FEEF0-0x00000001899FEF14 0x00000001899FF13C-0x00000001899FF2CC
		public virtual AttributeCollection Attributes { get; } // 0x00000001899FEF14-0x00000001899FF030 
		public virtual string Name { get; } // 0x00000001899FF0FC-0x00000001899FF13C 
		protected virtual int NameHashCode { get; } // 0x0000000181003B50-0x0000000181003B60 
		public virtual string DisplayName { get; } // 0x00000001899FF030-0x00000001899FF0FC 
	
		// Constructors
		protected MemberDescriptor() {} // Dummy constructor
		protected MemberDescriptor(string name, Attribute[] attributes) {} // 0x00000001899FED50-0x00000001899FEEF0
		protected MemberDescriptor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) {} // 0x00000001899FE824-0x00000001899FED50
	
		// Methods
		private void CheckAttributesValid() {} // 0x00000001899FDC58-0x00000001899FDCC0
		protected virtual AttributeCollection CreateAttributeCollection() => default; // 0x00000001899FDCC0-0x00000001899FDD2C
		public override bool Equals(object obj) => default; // 0x00000001899FDD2C-0x00000001899FDF74
		protected virtual void FillAttributes(IList attributeList) {} // 0x00000001899FDF74-0x00000001899FDFD4
		private void FilterAttributesIfNeeded() {} // 0x00000001899FDFD4-0x00000001899FE5EC
		protected static MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType) => default; // 0x00000001899FE67C-0x00000001899FE698
		protected static MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType, bool publicOnly) => default; // 0x00000001899FE5EC-0x00000001899FE67C
		public override int GetHashCode() => default; // 0x0000000181003B50-0x0000000181003B60
		protected virtual object GetInvocationTarget(System.Type type, object instance) => default; // 0x00000001899FE698-0x00000001899FE7AC
		protected static ISite GetSite(object component) => default; // 0x00000001899FE7AC-0x00000001899FE824
	}

	internal sealed class ReflectPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 46077
	{
		// Fields
		private static readonly System.Type[] argsNone; // 0x00
		private static readonly object noValue; // 0x08
		private static TraceSwitch PropDescCreateSwitch; // 0x10
		private static TraceSwitch PropDescUsageSwitch; // 0x18
		private static readonly int BitDefaultValueQueried; // 0x20
		private static readonly int BitGetQueried; // 0x24
		private static readonly int BitSetQueried; // 0x28
		private static readonly int BitShouldSerializeQueried; // 0x2C
		private static readonly int BitResetQueried; // 0x30
		private static readonly int BitChangedQueried; // 0x34
		private static readonly int BitIPropChangedQueried; // 0x38
		private static readonly int BitReadOnlyChecked; // 0x3C
		private static readonly int BitAmbientValueQueried; // 0x40
		private static readonly int BitSetOnDemand; // 0x44
		private BitVector32 state; // 0x88
		private System.Type componentClass; // 0x90
		private System.Type type; // 0x98
		private object defaultValue; // 0xA0
		private object ambientValue; // 0xA8
		private PropertyInfo propInfo; // 0xB0
		private MethodInfo getMethod; // 0xB8
		private MethodInfo setMethod; // 0xC0
		private MethodInfo shouldSerializeMethod; // 0xC8
		private MethodInfo resetMethod; // 0xD0
		private EventDescriptor realChangedEvent; // 0xD8
		private System.Type receiverType; // 0xE0
	
		// Properties
		private object AmbientValue { get => default; } // 0x0000000189A058F8-0x0000000189A05A44 
		public override System.Type ComponentType { get => default; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
		private object DefaultValue { get => default; } // 0x0000000189A05A44-0x0000000189A05C7C 
		private MethodInfo GetMethodValue { get => default; } // 0x0000000189A05C7C-0x0000000189A06174 
		private bool IsExtender { get => default; } // 0x0000000189A06174-0x0000000189A061C4 
		public override bool IsReadOnly { get => default; } // 0x0000000189A061C4-0x0000000189A06284 
		public override System.Type PropertyType { get => default; } // 0x00000001811AC510-0x00000001811AC520 
		private MethodInfo ResetMethodValue { get => default; } // 0x0000000189A06284-0x0000000189A06444 
		private MethodInfo SetMethodValue { get => default; } // 0x0000000189A06444-0x0000000189A06A50 
		private MethodInfo ShouldSerializeMethodValue { get => default; } // 0x0000000189A06A50-0x0000000189A06C10 
	
		// Constructors
		public ReflectPropertyDescriptor() {} // Dummy constructor
		public ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, Attribute[] attributes) {} // 0x0000000189A0545C-0x0000000189A056F0
		public ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) {} // 0x0000000189A057D0-0x0000000189A058F8
		public ReflectPropertyDescriptor(System.Type componentClass, string name, System.Type type, System.Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) {} // 0x0000000189A056F0-0x0000000189A057D0
		static ReflectPropertyDescriptor() {} // 0x0000000189A05130-0x0000000189A0545C
	
		// Methods
		internal bool ExtenderCanResetValue(IExtenderProvider provider, object component) => default; // 0x0000000189A02FC4-0x0000000189A031C8
		internal System.Type ExtenderGetReceiverType() => default; // 0x0000000183D51140-0x0000000183D51150
		internal System.Type ExtenderGetType(IExtenderProvider provider) => default; // 0x0000000189A031C8-0x0000000189A031D8
		internal object ExtenderGetValue(IExtenderProvider provider, object component) => default; // 0x0000000189A031D8-0x0000000189A032C4
		internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc) {} // 0x0000000189A032C4-0x0000000189A03620
		internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) {} // 0x0000000189A03620-0x0000000189A038F8
		internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) => default; // 0x0000000189A038F8-0x0000000189A03C3C
		public override bool CanResetValue(object component) => default; // 0x0000000189A02DC0-0x0000000189A02FC4
		protected override void FillAttributes(IList attributes) {} // 0x0000000189A03C3C-0x0000000189A043E4
		public override object GetValue(object component) => default; // 0x0000000189A043E4-0x0000000189A046B4
		protected override void OnValueChanged(object component, EventArgs e) {} // 0x0000000189A046B4-0x0000000189A04744
		public override void ResetValue(object component) {} // 0x0000000189A04744-0x0000000189A04A2C
		public override void SetValue(object component, object value) {} // 0x0000000189A04A2C-0x0000000189A04E9C
		public override bool ShouldSerializeValue(object component) => default; // 0x0000000189A04E9C-0x0000000189A05130
	}

	internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 46079
	{
		// Fields
		private Hashtable _typeData; // 0x20
		private static System.Type[] _typeConstructor; // 0x00
		private static Hashtable _intrinsicTypeConverters; // 0x08
		private static object _intrinsicReferenceKey; // 0x10
		private static object _intrinsicNullableKey; // 0x18
		private static object _dictionaryKey; // 0x20
		private static Hashtable _propertyCache; // 0x28
		private static Hashtable _attributeCache; // 0x30
		private static Hashtable _extendedPropertyCache; // 0x38
		private static readonly Guid _extenderProviderKey; // 0x40
		private static readonly Guid _extenderPropertiesKey; // 0x50
		private static readonly Guid _extenderProviderPropertiesKey; // 0x60
		private static readonly System.Type[] _skipInterfaceAttributeList; // 0x70
		private static object _internalSyncObject; // 0x78
	
		// Properties
		private static Hashtable IntrinsicTypeConverters { get => default; } // 0x00000001825E57E0-0x00000001825E60B0 
	
		// Nested types
		private class ReflectedTypeData // TypeDefIndex: 46078
		{
			// Fields
			private System.Type _type; // 0x10
			private AttributeCollection _attributes; // 0x18
			private EventDescriptorCollection _events; // 0x20
			private PropertyDescriptorCollection _properties; // 0x28
			private TypeConverter _converter; // 0x30
			private object[] _editors; // 0x38
			private System.Type[] _editorTypes; // 0x40
			private int _editorCount; // 0x48
	
			// Properties
			internal bool IsPopulated { get => default; } // 0x0000000189A099D0-0x0000000189A099F4 
	
			// Constructors
			public ReflectedTypeData() {} // Dummy constructor
			internal ReflectedTypeData(System.Type type) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			internal AttributeCollection GetAttributes() => default; // 0x00000001825E7B70-0x00000001825E80B0
			internal TypeConverter GetConverter(object instance) => default; // 0x00000001825E6DC0-0x00000001825E6FD0
			internal PropertyDescriptorCollection GetProperties() => default; // 0x0000000189A096E8-0x0000000189A0996C
			private System.Type GetTypeFromName(string typeName) => default; // 0x00000001825E6C80-0x00000001825E6CF0
			internal void Refresh() {} // 0x0000000189A0996C-0x0000000189A099D0
		}
	
		// Constructors
		internal ReflectTypeDescriptionProvider() {} // 0x000000018350B670-0x000000018350B680
		static ReflectTypeDescriptionProvider() {} // 0x0000000182A6A680-0x0000000182A6AA80
	
		// Methods
		public override object CreateInstance(IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args) => default; // 0x0000000189A06C10-0x0000000189A06D7C
		private static object CreateInstance(System.Type objectType, System.Type callingType) => default; // 0x00000001834D0AF0-0x00000001834D0BF0
		internal AttributeCollection GetAttributes(System.Type type) => default; // 0x00000001825E7780-0x00000001825E77B0
		public override IDictionary GetCache(object instance) => default; // 0x0000000189A06D7C-0x0000000189A06F24
		internal TypeConverter GetConverter(System.Type type, object instance) => default; // 0x00000001825E6D80-0x00000001825E6DC0
		internal AttributeCollection GetExtendedAttributes(object instance) => default; // 0x0000000189A06F24-0x0000000189A06F74
		internal TypeConverter GetExtendedConverter(object instance) => default; // 0x0000000189A06F74-0x0000000189A06FB8
		internal PropertyDescriptorCollection GetExtendedProperties(object instance) => default; // 0x0000000189A06FB8-0x0000000189A07358
		protected internal override IExtenderProvider[] GetExtenderProviders(object instance) => default; // 0x0000000189A073B4-0x0000000189A075BC
		private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) => default; // 0x0000000189A075BC-0x0000000189A07C50
		internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) => default; // 0x0000000189A07358-0x0000000189A073B4
		public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) => default; // 0x0000000181002730-0x0000000181002740
		internal PropertyDescriptorCollection GetProperties(System.Type type) => default; // 0x0000000189A07C50-0x0000000189A07C78
		internal object GetPropertyOwner(System.Type type, object instance, PropertyDescriptor pd) => default; // 0x0000000189A07C78-0x0000000189A07CD4
		public override System.Type GetReflectionType(System.Type objectType, object instance) => default; // 0x0000000183D51810-0x0000000183D51820
		private ReflectedTypeData GetTypeData(System.Type type, bool createIfNeeded) => default; // 0x00000001825E77B0-0x00000001825E7B70
		public override ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance) => default; // 0x0000000181002730-0x0000000181002740
		private static System.Type GetTypeFromName(string typeName) => default; // 0x0000000189A07CD4-0x0000000189A07D98
		internal bool IsPopulated(System.Type type) => default; // 0x0000000189A07D98-0x0000000189A07DD8
		private static Attribute[] ReflectGetAttributes(System.Type type) => default; // 0x00000001825E8190-0x00000001825E88B0
		internal static Attribute[] ReflectGetAttributes(MemberInfo member) => default; // 0x0000000189A07DD8-0x0000000189A0823C
		private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) => default; // 0x0000000189A0823C-0x0000000189A08FD4
		private static PropertyDescriptor[] ReflectGetProperties(System.Type type) => default; // 0x0000000189A08FD4-0x0000000189A096C0
		internal void Refresh(System.Type type) {} // 0x0000000189A096C0-0x0000000189A096E8
		private static object SearchIntrinsicTable(Hashtable table, System.Type callingType) => default; // 0x00000001824DDAF0-0x00000001824DED50
	}

	[ComVisible(true)]
	public class TypeConverter // TypeDefIndex: 46082
	{
		// Fields
		private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior"; // Metadata: 0x01FBA761
		private static bool useCompatibleTypeConversion; // 0x00
	
		// Properties
		private static bool UseCompatibleTypeConversion { get => default; } // 0x0000000189A0BB90-0x0000000189A0BBCC 
	
		// Nested types
		protected abstract class SimplePropertyDescriptor : PropertyDescriptor // TypeDefIndex: 46080
		{
			// Fields
			private System.Type componentType; // 0x88
			private System.Type propertyType; // 0x90
	
			// Properties
			public override System.Type ComponentType { get; } // 0x0000000183D4EA60-0x0000000183D4EA70 
			public override bool IsReadOnly { get; } // 0x0000000189A09FB8-0x0000000189A0A020 
			public override System.Type PropertyType { get; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
	
			// Constructors
			protected SimplePropertyDescriptor() {} // Dummy constructor
			protected SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType) {} // 0x0000000189A09F3C-0x0000000189A09FB8
			protected SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType, Attribute[] attributes) {} // 0x0000000189A09EDC-0x0000000189A09F3C
	
			// Methods
			public override bool CanResetValue(object component) => default; // 0x0000000189A09D30-0x0000000189A09E10
			public override void ResetValue(object component) {} // 0x0000000189A09E10-0x0000000189A09EDC
			public override bool ShouldSerializeValue(object component) => default; // 0x000000018115F4C0-0x000000018115F530
		}
	
		public class StandardValuesCollection : ICollection // TypeDefIndex: 46081
		{
			// Fields
			private ICollection values; // 0x10
			private Array valueArray; // 0x18
	
			// Properties
			public int Count { get => default; } // 0x0000000189A0A2E4-0x0000000189A0A320 
			public object this[int index] { get => default; } // 0x0000000189A0A320-0x0000000189A0A3EC 
			int ICollection.Count { get => default; } // 0x0000000189A0A24C-0x0000000189A0A254 
			bool ICollection.IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
			object ICollection.SyncRoot { get => default; } // 0x0000000181002730-0x0000000181002740 
	
			// Constructors
			public StandardValuesCollection() {} // Dummy constructor
			public StandardValuesCollection(ICollection values) {} // 0x0000000189A0A25C-0x0000000189A0A2E4
	
			// Methods
			public void CopyTo(Array array, int index) {} // 0x0000000189A0A1DC-0x0000000189A0A1FC
			public IEnumerator GetEnumerator() => default; // 0x0000000189A0A1FC-0x0000000189A0A244
			void ICollection.CopyTo(Array array, int index) {} // 0x0000000189A0A244-0x0000000189A0A24C
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189A0A254-0x0000000189A0A25C
		}
	
		// Constructors
		public TypeConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool CanConvertFrom(System.Type sourceType) => default; // 0x0000000189A0AE88-0x0000000189A0AEA0
		public virtual bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) => default; // 0x0000000189A0AE24-0x0000000189A0AE88
		public bool CanConvertTo(System.Type destinationType) => default; // 0x0000000189A0AEA0-0x0000000189A0AEB8
		public virtual bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) => default; // 0x0000000189A0AEB8-0x0000000189A0AF1C
		public object ConvertFrom(object value) => default; // 0x0000000189A0B084-0x0000000189A0B0E4
		public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x0000000189A0B0E4-0x0000000189A0B144
		public object ConvertFromInvariantString(string text) => default; // 0x0000000189A0AF1C-0x0000000189A0AF7C
		public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) => default; // 0x0000000189A0AF7C-0x0000000189A0AFE8
		public object ConvertFromString(string text) => default; // 0x0000000189A0B068-0x0000000189A0B084
		public object ConvertFromString(ITypeDescriptorContext context, string text) => default; // 0x0000000189A0AFE8-0x0000000189A0B054
		public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) => default; // 0x0000000189A0B054-0x0000000189A0B068
		public object ConvertTo(object value, System.Type destinationType) => default; // 0x0000000189A0B4AC-0x0000000189A0B4D0
		public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType) => default; // 0x0000000189A0B4D0-0x0000000189A0B65C
		public string ConvertToInvariantString(object value) => default; // 0x0000000189A0B144-0x0000000189A0B1A4
		public string ConvertToInvariantString(ITypeDescriptorContext context, object value) => default; // 0x0000000189A0B1A4-0x0000000189A0B214
		public string ConvertToString(object value) => default; // 0x0000000189A0B214-0x0000000189A0B2FC
		public string ConvertToString(ITypeDescriptorContext context, object value) => default; // 0x0000000189A0B3C4-0x0000000189A0B4AC
		public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) => default; // 0x0000000189A0B2FC-0x0000000189A0B3C4
		public object CreateInstance(IDictionary propertyValues) => default; // 0x0000000189A0B65C-0x0000000189A0B674
		public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) => default; // 0x0000000181002730-0x0000000181002740
		protected Exception GetConvertFromException(object value) => default; // 0x0000000189A0B674-0x0000000189A0B7A0
		protected Exception GetConvertToException(object value, System.Type destinationType) => default; // 0x0000000189A0B7A0-0x0000000189A0B908
		public bool GetCreateInstanceSupported() => default; // 0x0000000189A0B908-0x0000000189A0B918
		public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) => default; // 0x000000018115F4C0-0x000000018115F530
		public PropertyDescriptorCollection GetProperties(object value) => default; // 0x0000000189A0B928-0x0000000189A0B938
		public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) => default; // 0x0000000189A0B938-0x0000000189A0BA04
		public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) => default; // 0x0000000181002730-0x0000000181002740
		public bool GetPropertiesSupported() => default; // 0x0000000189A0B918-0x0000000189A0B928
		public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) => default; // 0x000000018115F4C0-0x000000018115F530
		public ICollection GetStandardValues() => default; // 0x0000000189A0BA24-0x0000000189A0BA30
		public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) => default; // 0x0000000181002730-0x0000000181002740
		public bool GetStandardValuesExclusive() => default; // 0x0000000189A0BA04-0x0000000189A0BA14
		public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) => default; // 0x000000018115F4C0-0x000000018115F530
		public bool GetStandardValuesSupported() => default; // 0x0000000189A0BA14-0x0000000189A0BA24
		public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) => default; // 0x000000018115F4C0-0x000000018115F530
		public bool IsValid(object value) => default; // 0x0000000189A0BA30-0x0000000189A0BA48
		public virtual bool IsValid(ITypeDescriptorContext context, object value) => default; // 0x0000000189A0BA48-0x0000000189A0BB60
		protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names) => default; // 0x0000000189A0BB60-0x0000000189A0BB90
	}

	public sealed class TypeDescriptor // TypeDefIndex: 46093
	{
		// Fields
		private static WeakHashtable _providerTable; // 0x00
		private static Hashtable _providerTypeTable; // 0x08
		private static Hashtable _defaultProviders; // 0x10
		private static WeakHashtable _associationTable; // 0x18
		private static int _metadataVersion; // 0x20
		private static int _collisionIndex; // 0x24
		private static BooleanSwitch TraceDescriptor; // 0x28
		private static readonly Guid[] _pipelineInitializeKeys; // 0x30
		private static readonly Guid[] _pipelineMergeKeys; // 0x38
		private static readonly Guid[] _pipelineFilterKeys; // 0x40
		private static readonly Guid[] _pipelineAttributeFilterKeys; // 0x48
		private static object _internalSyncObject; // 0x50
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static System.Type ComObjectType { get => default; } // 0x0000000189A109F4-0x0000000189A10A44 
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static System.Type InterfaceType { get => default; } // 0x00000001825E9840-0x00000001825E98A0 
		internal static int MetadataVersion { get => default; } // 0x0000000189A10A44-0x0000000189A10A94 
	
		// Nested types
		private sealed class AttributeFilterCacheItem // TypeDefIndex: 46083
		{
			// Fields
			private Attribute[] _filter; // 0x10
			internal ICollection FilteredMembers; // 0x18
	
			// Constructors
			public AttributeFilterCacheItem() {} // Dummy constructor
			internal AttributeFilterCacheItem(Attribute[] filter, ICollection filteredMembers) {} // 0x0000000182676770-0x00000001826767A0
	
			// Methods
			internal bool IsValid(Attribute[] filter) => default; // 0x0000000189A11388-0x0000000189A113EC
		}
	
		private sealed class FilterCacheItem // TypeDefIndex: 46084
		{
			// Fields
			private ITypeDescriptorFilterService _filterService; // 0x10
			internal ICollection FilteredMembers; // 0x18
	
			// Constructors
			public FilterCacheItem() {} // Dummy constructor
			internal FilterCacheItem(ITypeDescriptorFilterService filterService, ICollection filteredMembers) {} // 0x0000000182676770-0x00000001826767A0
	
			// Methods
			internal bool IsValid(ITypeDescriptorFilterService filterService) => default; // 0x00000001892D211C-0x00000001892D2124
		}
	
		private interface IUnimplemented // TypeDefIndex: 46085
		{
		}
	
		private sealed class MemberDescriptorComparer : System.Collections.IComparer // TypeDefIndex: 46086
		{
			// Fields
			public static readonly MemberDescriptorComparer Instance; // 0x00
	
			// Constructors
			public MemberDescriptorComparer() {} // 0x000000018350B670-0x000000018350B680
			static MemberDescriptorComparer() {} // 0x0000000189A18270-0x0000000189A182D4
	
			// Methods
			public int Compare(object left, object right) => default; // 0x0000000189A1818C-0x0000000189A18270
		}
	
		private sealed class MergedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 46087
		{
			// Fields
			private ICustomTypeDescriptor _primary; // 0x10
			private ICustomTypeDescriptor _secondary; // 0x18
	
			// Constructors
			public MergedTypeDescriptor() {} // Dummy constructor
			internal MergedTypeDescriptor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) {} // 0x0000000182676770-0x00000001826767A0
	
			// Methods
			AttributeCollection ICustomTypeDescriptor.GetAttributes() => default; // 0x0000000189A182D4-0x0000000189A18310
			TypeConverter ICustomTypeDescriptor.GetConverter() => default; // 0x0000000189A18310-0x0000000189A1834C
			PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties() => default; // 0x0000000189A18398-0x0000000189A183D4
			PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes) => default; // 0x0000000189A1834C-0x0000000189A18398
			object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) => default; // 0x0000000189A183D4-0x0000000189A18420
		}
	
		private sealed class TypeDescriptionNode : TypeDescriptionProvider // TypeDefIndex: 46090
		{
			// Fields
			internal TypeDescriptionNode Next; // 0x20
			internal TypeDescriptionProvider Provider; // 0x28
	
			// Nested types
			private struct DefaultExtendedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 46088
			{
				// Fields
				private TypeDescriptionNode _node; // 0x00
				private object _instance; // 0x08
	
				// Constructors
				internal DefaultExtendedTypeDescriptor(TypeDescriptionNode node, object instance) {
					_node = default;
					_instance = default;
				} // 0x00000001832C7BF0-0x00000001832C7C20
	
				// Methods
				AttributeCollection ICustomTypeDescriptor.GetAttributes() => default; // 0x0000000189A11B44-0x0000000189A11E20
				TypeConverter ICustomTypeDescriptor.GetConverter() => default; // 0x0000000189A11E20-0x0000000189A120E8
				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties() => default; // 0x0000000189A123B4-0x0000000189A1267C
				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes) => default; // 0x0000000189A120E8-0x0000000189A123B4
				object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) => default; // 0x0000000189A1267C-0x0000000189A12840
			}
	
			private struct DefaultTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 46089
			{
				// Fields
				private TypeDescriptionNode _node; // 0x00
				private System.Type _objectType; // 0x08
				private object _instance; // 0x10
	
				// Constructors
				internal DefaultTypeDescriptor(TypeDescriptionNode node, System.Type objectType, object instance) {
					_node = default;
					_objectType = default;
					_instance = default;
				} // 0x000000018314F010-0x000000018314F040
	
				// Methods
				AttributeCollection ICustomTypeDescriptor.GetAttributes() => default; // 0x00000001825E7700-0x00000001825E7780
				TypeConverter ICustomTypeDescriptor.GetConverter() => default; // 0x00000001825E6CF0-0x00000001825E6D80
				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties() => default; // 0x0000000189A12BA0-0x0000000189A12E6C
				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes) => default; // 0x0000000189A128D0-0x0000000189A12BA0
				object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) => default; // 0x0000000189A12E6C-0x0000000189A1303C
			}
	
			// Constructors
			public TypeDescriptionNode() {} // Dummy constructor
			internal TypeDescriptionNode(TypeDescriptionProvider provider) {} // 0x0000000182C92F10-0x0000000182C92F20
	
			// Methods
			public override object CreateInstance(IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args) => default; // 0x0000000189A1D238-0x0000000189A1D3D8
			public override IDictionary GetCache(object instance) => default; // 0x0000000189A1D3D8-0x0000000189A1D454
			public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) => default; // 0x0000000189A1D454-0x0000000189A1D51C
			protected internal override IExtenderProvider[] GetExtenderProviders(object instance) => default; // 0x0000000189A1D51C-0x0000000189A1D594
			public override System.Type GetReflectionType(System.Type objectType, object instance) => default; // 0x0000000183C7FED0-0x0000000183C7FF50
			public override ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance) => default; // 0x000000018314EF20-0x000000018314F010
		}
	
		[TypeDescriptionProvider("System.Windows.Forms.ComponentModel.Com2Interop.ComNativeDescriptor, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		private sealed class TypeDescriptorComObject // TypeDefIndex: 46091
		{
			// Constructors
			public TypeDescriptorComObject() {} // Dummy constructor
		}
	
		private sealed class TypeDescriptorInterface // TypeDefIndex: 46092
		{
			// Constructors
			public TypeDescriptorInterface() {} // Dummy constructor
		}
	
		// Constructors
		public TypeDescriptor() {} // Dummy constructor
		static TypeDescriptor() {} // 0x0000000182A6ADC0-0x0000000182A6B530
	
		// Methods
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void AddProvider(TypeDescriptionProvider provider, System.Type type) {} // 0x0000000189A0BFE4-0x0000000189A0C2E8
		private static void CheckDefaultProvider(System.Type type) {} // 0x00000001825E98A0-0x00000001825EA5F0
		public static object CreateInstance(IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args) => default; // 0x0000000189A0C2E8-0x0000000189A0C524
		private static ArrayList FilterMembers(IList members, Attribute[] attributes) => default; // 0x0000000189A0C524-0x0000000189A0C6B4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static object GetAssociation(System.Type type, object primary) => default; // 0x0000000189A0C6B4-0x0000000189A0CAB4
		public static AttributeCollection GetAttributes(System.Type componentType) => default; // 0x00000001825E8E30-0x00000001825E8F50
		public static AttributeCollection GetAttributes(object component) => default; // 0x0000000189A0CCEC-0x0000000189A0CD38
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) => default; // 0x0000000189A0CAB4-0x0000000189A0CCEC
		internal static IDictionary GetCache(object instance) => default; // 0x0000000189A0CD38-0x0000000189A0CD94
		public static TypeConverter GetConverter(System.Type type) => default; // 0x00000001825E7180-0x00000001825E7260
		internal static ICustomTypeDescriptor GetDescriptor(System.Type type, string typeName) => default; // 0x00000001825E8F50-0x00000001825E9000
		internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) => default; // 0x0000000189A0CD94-0x0000000189A0CFB4
		internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) => default; // 0x0000000189A0CFB4-0x0000000189A0D064
		private static string GetExtenderCollisionSuffix(MemberDescriptor member) => default; // 0x0000000189A0D064-0x0000000189A0D248
		private static System.Type GetNodeForBaseType(System.Type searchType) => default; // 0x00000001825E9760-0x00000001825E9840
		public static PropertyDescriptorCollection GetProperties(object component) => default; // 0x0000000189A0D66C-0x0000000189A0D6B8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) => default; // 0x0000000189A0D558-0x0000000189A0D5B0
		public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) => default; // 0x0000000189A0D5B0-0x0000000189A0D604
		public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc) => default; // 0x0000000189A0D604-0x0000000189A0D66C
		private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) => default; // 0x0000000189A0D248-0x0000000189A0D558
		internal static TypeDescriptionProvider GetProviderRecursive(System.Type type) => default; // 0x0000000189A0D6B8-0x0000000189A0D704
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static System.Type GetReflectionType(System.Type type) => default; // 0x0000000183CB4C90-0x0000000183CB4D20
		private static TypeDescriptionNode NodeFor(System.Type type) => default; // 0x00000001825E9000-0x00000001825E9050
		private static TypeDescriptionNode NodeFor(System.Type type, bool createDelegator) => default; // 0x00000001825E9050-0x00000001825E9760
		private static TypeDescriptionNode NodeFor(object instance) => default; // 0x0000000189A0D864-0x0000000189A0D8B0
		private static TypeDescriptionNode NodeFor(object instance, bool createDelegator) => default; // 0x0000000189A0D704-0x0000000189A0D864
		private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) => default; // 0x0000000189A0D8B0-0x0000000189A0DC04
		private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) => default; // 0x0000000189A0DC04-0x0000000189A0F35C
		private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) => default; // 0x0000000189A0F35C-0x0000000189A0F688
		private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) => default; // 0x0000000189A0F688-0x0000000189A10304
		private static void RaiseRefresh(System.Type type) {} // 0x0000000189A10304-0x0000000189A103AC
		public static void Refresh(System.Type type) {} // 0x0000000189A103AC-0x0000000189A108BC
		private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) => default; // 0x0000000189A108BC-0x0000000189A10934
		public static void SortDescriptorArray(IList infos) {} // 0x0000000189A10934-0x0000000189A109F4
	}

	[Serializable]
	public class Win32Exception : ExternalException, ISerializable // TypeDefIndex: 46094
	{
		// Fields
		private readonly int nativeErrorCode; // 0x90
	
		// Properties
		public int NativeErrorCode { get => default; } // 0x0000000183D4FB60-0x0000000183D4FB70 
	
		// Constructors
		public Win32Exception() {} // 0x0000000189A1E538-0x0000000189A1E58C
		public Win32Exception(int error) {} // 0x0000000189A1E6A0-0x0000000189A1E6D4
		public Win32Exception(int error, string message) {} // 0x0000000189A1E668-0x0000000189A1E6A0
		public Win32Exception(string message) {} // 0x0000000189A1E610-0x0000000189A1E668
		public Win32Exception(string message, Exception innerException) {} // 0x0000000189A1E4CC-0x0000000189A1E538
		protected Win32Exception(SerializationInfo info, StreamingContext context) {} // 0x0000000189A1E58C-0x0000000189A1E610
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000189A1E3F8-0x0000000189A1E4CC
		internal static string GetErrorMessage(int error) => default; // 0x0000000189A1D84C-0x0000000189A1E3F8
	}

	[AttributeUsage(AttributeTargets.Property)]
	public sealed class NotifyParentPropertyAttribute : Attribute // TypeDefIndex: 46095
	{
		// Fields
		public static readonly NotifyParentPropertyAttribute Yes; // 0x00
		public static readonly NotifyParentPropertyAttribute No; // 0x08
		public static readonly NotifyParentPropertyAttribute Default; // 0x10
		private bool notifyParent; // 0x10
	
		// Properties
		public bool NotifyParent { get => default; } // 0x00000001811797F0-0x0000000181179800 
	
		// Constructors
		public NotifyParentPropertyAttribute() {} // Dummy constructor
		public NotifyParentPropertyAttribute(bool notifyParent) {} // 0x0000000183D4E960-0x0000000183D4E970
		static NotifyParentPropertyAttribute() {} // 0x0000000189A1B54C-0x0000000189A1B624
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189A1B498-0x0000000189A1B4F8
		public override int GetHashCode() => default; // 0x00000001899E6274-0x00000001899E627C
		public override bool IsDefaultAttribute() => default; // 0x0000000189A1B4F8-0x0000000189A1B54C
	}

	public enum RefreshProperties // TypeDefIndex: 46096
	{
		None = 0,
		All = 1,
		Repaint = 2
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public sealed class RefreshPropertiesAttribute : Attribute // TypeDefIndex: 46097
	{
		// Fields
		public static readonly RefreshPropertiesAttribute All; // 0x00
		public static readonly RefreshPropertiesAttribute Repaint; // 0x08
		public static readonly RefreshPropertiesAttribute Default; // 0x10
		private RefreshProperties refresh; // 0x10
	
		// Properties
		public RefreshProperties RefreshProperties { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
	
		// Constructors
		public RefreshPropertiesAttribute() {} // Dummy constructor
		public RefreshPropertiesAttribute(RefreshProperties refresh) {} // 0x00000001810410F0-0x0000000181041100
		static RefreshPropertiesAttribute() {} // 0x0000000189A1C8F4-0x0000000189A1C9E0
	
		// Methods
		public override bool Equals(object value) => default; // 0x0000000189A1C848-0x0000000189A1C8A0
		public override int GetHashCode() => default; // 0x00000001899E6274-0x00000001899E627C
		public override bool IsDefaultAttribute() => default; // 0x0000000189A1C8A0-0x0000000189A1C8F4
	}

	internal sealed class WeakHashtable : Hashtable // TypeDefIndex: 46099
	{
		// Fields
		private static IEqualityComparer _comparer; // 0x00
	
		// Nested types
		private class WeakKeyComparer : IEqualityComparer // TypeDefIndex: 46098
		{
			// Constructors
			public WeakKeyComparer() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			bool IEqualityComparer.Equals(object x, object y) => default; // 0x0000000189A1D66C-0x0000000189A1D75C
			int IEqualityComparer.GetHashCode(object obj) => default; // 0x0000000182BD0200-0x0000000182BDBD60
		}
	
		// Constructors
		internal WeakHashtable() {} // 0x0000000183D0C8F0-0x0000000183D0C950
		static WeakHashtable() {} // 0x0000000183CFF8C0-0x0000000183CFF930
	
		// Methods
		public override void Clear() {} // 0x0000000189A1D65C-0x0000000189A1D664
		public override void Remove(object key) {} // 0x0000000189A1D664-0x0000000189A1D66C
	}
}

namespace System.ComponentModel.Design
{
	[Serializable]
	public class CheckoutException : ExternalException // TypeDefIndex: 46100
	{
		// Fields
		public static readonly CheckoutException Canceled; // 0x00
	
		// Constructors
		public CheckoutException() {} // 0x00000001891B7E28-0x00000001891B7E30
		public CheckoutException(string message, int errorCode) {} // 0x00000001891B82E4-0x00000001891B830C
		protected CheckoutException(SerializationInfo info, StreamingContext context) {} // 0x00000001891672B8-0x00000001891672D8
		static CheckoutException() {} // 0x0000000189A116A4-0x0000000189A11730
	}

	public interface IComponentChangeService // TypeDefIndex: 46101
	{
		// Methods
		void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue);
		void OnComponentChanging(object component, MemberDescriptor member);
	}

	public interface IDesigner : IDisposable // TypeDefIndex: 46102
	{
	}

	public interface IDesignerHost : IServiceProvider // TypeDefIndex: 46103
	{
		// Properties
		IComponent RootComponent { get; }
	
		// Methods
		IDesigner GetDesigner(IComponent component);
	}

	public interface IDictionaryService // TypeDefIndex: 46104
	{
		// Methods
		object GetValue(object key);
		void SetValue(object key, object value);
	}

	public interface IExtenderListService // TypeDefIndex: 46105
	{
		// Methods
		IExtenderProvider[] GetExtenderProviders();
	}

	public interface IReferenceService // TypeDefIndex: 46106
	{
		// Methods
		object GetReference(string name);
		string GetName(object reference);
		object[] GetReferences(System.Type baseType);
	}

	public interface ITypeDescriptorFilterService // TypeDefIndex: 46107
	{
		// Methods
		bool FilterAttributes(IComponent component, IDictionary attributes);
		bool FilterEvents(IComponent component, IDictionary events);
		bool FilterProperties(IComponent component, IDictionary properties);
	}

	public abstract class DesignerOptionService // TypeDefIndex: 46112
	{
		// Nested types
		[DefaultMember("Item")]
		[Editor("", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[TypeConverter(typeof(DesignerOptionConverter))]
		public sealed class DesignerOptionCollection : ICollection // TypeDefIndex: 46109
		{
			// Fields
			private DesignerOptionService _service; // 0x10
			private string _name; // 0x18
			private object _value; // 0x20
			private ArrayList _children; // 0x28
			private PropertyDescriptorCollection _properties; // 0x30
	
			// Properties
			public int Count { get => default; } // 0x0000000189A15298-0x0000000189A152C8 
			public string Name { get => default; } // 0x0000000181041090-0x00000001810410A0 
			public PropertyDescriptorCollection Properties { get => default; } // 0x0000000189A152C8-0x0000000189A15910 
			bool ICollection.IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
			object ICollection.SyncRoot { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
	
			// Nested types
			private sealed class WrappedPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 46108
			{
				// Fields
				private object target; // 0x88
				private PropertyDescriptor property; // 0x90
	
				// Properties
				public override AttributeCollection Attributes { get => default; } // 0x0000000189A1E82C-0x0000000189A1E84C 
				public override System.Type ComponentType { get => default; } // 0x0000000189A1E84C-0x0000000189A1E870 
				public override bool IsReadOnly { get => default; } // 0x0000000189A1E870-0x0000000189A1E894 
				public override System.Type PropertyType { get => default; } // 0x0000000189A1E894-0x0000000189A1E8B8 
	
				// Constructors
				public WrappedPropertyDescriptor() {} // Dummy constructor
				internal WrappedPropertyDescriptor(PropertyDescriptor property, object target) {} // 0x0000000189A1E7B8-0x0000000189A1E82C
	
				// Methods
				public override bool CanResetValue(object component) => default; // 0x0000000189A1E6D4-0x0000000189A1E700
				public override object GetValue(object component) => default; // 0x0000000189A1E700-0x0000000189A1E72C
				public override void ResetValue(object component) {} // 0x0000000189A1E72C-0x0000000189A1E758
				public override void SetValue(object component, object value) {} // 0x0000000189A1E758-0x0000000189A1E78C
				public override bool ShouldSerializeValue(object component) => default; // 0x0000000189A1E78C-0x0000000189A1E7B8
			}
	
			// Constructors
			public DesignerOptionCollection() {} // Dummy constructor
	
			// Methods
			public void CopyTo(Array array, int index) {} // 0x0000000189A151A0-0x0000000189A151F0
			private void EnsurePopulated() {} // 0x0000000189A151F0-0x0000000189A15268
			public IEnumerator GetEnumerator() => default; // 0x0000000189A15268-0x0000000189A15298
		}
	
		internal sealed class DesignerOptionConverter : TypeConverter // TypeDefIndex: 46111
		{
			// Nested types
			private class OptionPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 46110
			{
				// Fields
				private DesignerOptionCollection _option; // 0x88
	
				// Properties
				public override System.Type ComponentType { get => default; } // 0x0000000189A1B66C-0x0000000189A1B694 
				public override bool IsReadOnly { get => default; } // 0x000000018232EB60-0x000000018232EB70 
				public override System.Type PropertyType { get => default; } // 0x0000000189A1B66C-0x0000000189A1B694 
	
				// Constructors
				public OptionPropertyDescriptor() {} // Dummy constructor
				internal OptionPropertyDescriptor(DesignerOptionCollection option) {} // 0x0000000189A1B624-0x0000000189A1B66C
	
				// Methods
				public override bool CanResetValue(object component) => default; // 0x000000018115F4C0-0x000000018115F530
				public override object GetValue(object component) => default; // 0x0000000183D4EA60-0x0000000183D4EA70
				public override void ResetValue(object component) {} // 0x000000018350B670-0x000000018350B680
				public override void SetValue(object component, object value) {} // 0x000000018350B670-0x000000018350B680
				public override bool ShouldSerializeValue(object component) => default; // 0x000000018115F4C0-0x000000018115F530
			}
	
			// Constructors
			public DesignerOptionConverter() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override bool GetPropertiesSupported(ITypeDescriptorContext cxt) => default; // 0x000000018232EB60-0x000000018232EB70
			public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext cxt, object value, Attribute[] attributes) => default; // 0x0000000189A159D0-0x0000000189A15D44
			public override object ConvertTo(ITypeDescriptorContext cxt, CultureInfo culture, object value, System.Type destinationType) => default; // 0x0000000189A15910-0x0000000189A159D0
		}
	
		// Constructors
		protected DesignerOptionService() {} // Dummy constructor
	
		// Methods
		protected virtual void PopulateOptionCollection(DesignerOptionCollection options) {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace System.ComponentModel.Design.Serialization
{
	public sealed class InstanceDescriptor // TypeDefIndex: 46113
	{
		// Properties
		public ICollection Arguments { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public MemberInfo MemberInfo { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public InstanceDescriptor() {} // Dummy constructor
		public InstanceDescriptor(MemberInfo member, ICollection arguments) {} // 0x0000000189A16DFC-0x0000000189A16E18
		public InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete) {} // 0x0000000189A16E18-0x0000000189A17370
	
		// Methods
		public object Invoke() => default; // 0x0000000189A16B7C-0x0000000189A16DFC
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
	public sealed class RootDesignerSerializerAttribute : Attribute // TypeDefIndex: 46114
	{
		// Fields
		private string _typeId; // 0x10
	
		// Properties
		public string SerializerBaseTypeName { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public override object TypeId { get => default; } // 0x0000000189A1CA10-0x0000000189A1CAA4 
	
		// Constructors
		public RootDesignerSerializerAttribute() {} // Dummy constructor
		public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable) {} // 0x0000000189A1C9E0-0x0000000189A1CA10
	}
}

namespace System.Configuration
{
	public interface IConfigurationSectionHandler // TypeDefIndex: 46206
	{
	}
}

namespace System.Diagnostics
{
	[SwitchLevel(typeof(bool))]
	public class BooleanSwitch : Switch // TypeDefIndex: 45565
	{
		// Constructors
		public BooleanSwitch() {} // Dummy constructor
		public BooleanSwitch(string displayName, string description) {} // 0x00000001837D0730-0x00000001837D07A0
	}

	public abstract class Switch // TypeDefIndex: 45566
	{
		// Fields
		private readonly string description; // 0x10
		private readonly string displayName; // 0x18
		private string switchValueString; // 0x20
		private string defaultValue; // 0x28
		private static List<WeakReference> switches; // 0x00
		private static int s_LastCollectionCount; // 0x08
	
		// Constructors
		protected Switch() {} // Dummy constructor
		protected Switch(string displayName, string description) {} // 0x00000001837D07A0-0x00000001837D0810
		protected Switch(string displayName, string description, string defaultSwitchValue) {} // 0x00000001837D0810-0x00000001837D0B40
		static Switch() {} // 0x0000000183CE2E90-0x0000000183CE2F20
	
		// Methods
		private static void _pruneCachedSwitches() {} // 0x00000001837D0B40-0x00000001837D11D0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class SwitchLevelAttribute : Attribute // TypeDefIndex: 45567
	{
		// Fields
		private System.Type type; // 0x10
	
		// Properties
		public System.Type SwitchLevelType { set {} } // 0x0000000189A3DE00-0x0000000189A3DEA8
	
		// Constructors
		public SwitchLevelAttribute() {} // Dummy constructor
		public SwitchLevelAttribute(System.Type switchLevelType) {} // 0x0000000189A3DDF8-0x0000000189A3DE00
	}

	public enum TraceLevel // TypeDefIndex: 45568
	{
		Off = 0,
		Error = 1,
		Warning = 2,
		Info = 3,
		Verbose = 4
	}

	[SwitchLevel(typeof(TraceLevel))]
	public class TraceSwitch : Switch // TypeDefIndex: 45569
	{
		// Constructors
		public TraceSwitch() {} // Dummy constructor
		public TraceSwitch(string displayName, string description) {} // 0x0000000189A3DEA8-0x0000000189A3DF08
	}

	internal class AsyncStreamReader // TypeDefIndex: 45570
	{
		// Fields
		private Stream stream; // 0x10
		private Encoding encoding; // 0x18
		private System.Text.Decoder decoder; // 0x20
		private byte[] byteBuffer; // 0x28
		private char[] charBuffer; // 0x30
		private bool cancelOperation; // 0x38
		private ManualResetEvent eofEvent; // 0x40
		private object syncObject; // 0x48
		private IAsyncResult asyncReadResult; // 0x50
	
		// Constructors
		public AsyncStreamReader() {} // Dummy constructor
	
		// Methods
		public virtual void Close() {} // 0x0000000189A35C98-0x0000000189A35CA4
		protected virtual void Dispose(bool disposing) {} // 0x0000000189A35CA4-0x0000000189A360AC
		internal void CancelOperation() {} // 0x0000000183D5C330-0x0000000183D5C340
		internal void WaitUtilEOF() {} // 0x0000000189A360AC-0x0000000189A360F4
	}

	[DefaultEvent("Exited")]
	[DefaultProperty("StartInfo")]
	[MonitoringDescription("Provides access to local and remote processes, enabling starting and stopping of local processes.")]
	public class Process : Component // TypeDefIndex: 45574
	{
		// Fields
		private bool haveProcessId; // 0x28
		private int processId; // 0x2C
		private bool haveProcessHandle; // 0x30
		private SafeProcessHandle m_processHandle; // 0x38
		private bool isRemoteMachine; // 0x40
		private string machineName; // 0x48
		private int m_processAccess; // 0x50
		private ProcessThreadCollection threads; // 0x58
		private ProcessModuleCollection modules; // 0x60
		private bool haveWorkingSetLimits; // 0x68
		private bool havePriorityClass; // 0x69
		private ProcessStartInfo startInfo; // 0x70
		private bool watchForExit; // 0x78
		private bool watchingForExit; // 0x79
		private System.EventHandler onExited; // 0x80
		private bool exited; // 0x88
		private int exitCode; // 0x8C
		private bool signaled; // 0x90
		private bool haveExitTime; // 0x91
		private bool raisedOnExited; // 0x92
		private RegisteredWaitHandle registeredWaitHandle; // 0x98
		private WaitHandle waitHandle; // 0xA0
		private ISynchronizeInvoke synchronizingObject; // 0xA8
		private StreamReader standardOutput; // 0xB0
		private StreamWriter standardInput; // 0xB8
		private StreamReader standardError; // 0xC0
		private bool disposed; // 0xC8
		private StreamReadMode outputStreamReadMode; // 0xCC
		private StreamReadMode errorStreamReadMode; // 0xD0
		private StreamReadMode inputStreamReadMode; // 0xD4
		internal AsyncStreamReader output; // 0xD8
		internal AsyncStreamReader error; // 0xE0
		private string process_name; // 0xE8
	
		// Properties
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Indicates if the process component is associated with a real process.")]
		private bool Associated { get => default; } // 0x0000000182C9BD80-0x0000000182C9BD90 
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The value returned from the associated process when it terminated.")]
		public int ExitCode { get => default; } // 0x0000000189A3BE9C-0x0000000189A3BF80 
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Indicates if the associated process has been terminated.")]
		public bool HasExited { get => default; } // 0x0000000189A3BF80-0x0000000189A3C3AC 
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Returns the native handle for this process.   The handle is only available if the process was started using this component.")]
		public IntPtr Handle { get => default; } // 0x0000000182C9ADF0-0x0000000182C9AE30 
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The unique identifier for the process.")]
		public int Id { get => default; } // 0x0000000184270A58-0x0000000184270A78 
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[MonitoringDescription("Specifies information used to start a process.")]
		public ProcessStartInfo StartInfo { get => default; set {} } // 0x0000000189A3C798-0x0000000189A3C80C 0x0000000189A3C928-0x0000000189A3C99C
		[Browsable(false)]
		[DefaultValue(null)]
		[MonitoringDescription("The object used to marshal the event handler calls issued as a result of a Process exit.")]
		public ISynchronizeInvoke SynchronizingObject { get => default; } // 0x0000000189A3C80C-0x0000000189A3C928 
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Standard output stream of the process.")]
		public StreamReader StandardOutput { get => default; } // 0x0000000189A3C6AC-0x0000000189A3C798 
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The name of this process.")]
		public string ProcessName { get => default; } // 0x0000000189A3C3D8-0x0000000189A3C6AC 
		private static bool IsWindows { get => default; } // 0x0000000189A3C3AC-0x0000000189A3C3D8 
	
		// Nested types
		private enum StreamReadMode // TypeDefIndex: 45571
		{
			undefined = 0,
			syncMode = 1,
			asyncMode = 2
		}
	
		private enum State // TypeDefIndex: 45572
		{
			HaveId = 1,
			IsLocal = 2,
			IsNt = 4,
			HaveProcessInfo = 8,
			HaveNtProcessInfo = 12,
			Exited = 16,
			Associated = 32,
			IsWin2k = 64
		}
	
		private struct ProcInfo // TypeDefIndex: 45573
		{
			// Fields
			public IntPtr process_handle; // 0x00
			public int pid; // 0x08
			public string[] envVariables; // 0x10
			public string UserName; // 0x18
			public string Domain; // 0x20
			public IntPtr Password; // 0x28
			public bool LoadUserProfile; // 0x30
		}
	
		// Constructors
		public Process() {} // 0x0000000189A3BDC8-0x0000000189A3BE34
		private Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) {} // 0x0000000182C9AF00-0x0000000182C9AFA0
		private Process(SafeProcessHandle handle, int id) {} // 0x0000000189A3BE34-0x0000000189A3BE9C
	
		// Methods
		private void ReleaseProcessHandle(SafeProcessHandle handle) {} // 0x0000000189A39338-0x0000000189A39358
		private void CompletionCallback(object context, bool wasSignaled) {} // 0x0000000189A387B8-0x0000000189A387D8
		protected override void Dispose(bool disposing) {} // 0x0000000182C9BBA0-0x0000000182C9BBF0
		public void Close() {} // 0x0000000182C9BBF0-0x0000000182C9BD80
		private void EnsureState(State state) {} // 0x0000000182C9BB40-0x0000000182C9BBA0
		private void EnsureWatchingForExit() {} // 0x0000000189A38A2C-0x0000000189A38CE4
		public static Process GetProcessById(int processId) => default; // 0x0000000189A38DA0-0x0000000189A38DDC
		public static Process GetCurrentProcess() => default; // 0x0000000182C9AE70-0x0000000182C9AF00
		protected void OnExited() {} // 0x0000000189A3902C-0x0000000189A3919C
		private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) => default; // 0x0000000182C9AFD0-0x0000000182C9BB40
		private SafeProcessHandle GetProcessHandle(int access) => default; // 0x0000000184272FF4-0x0000000184273000
		private SafeProcessHandle OpenProcessHandle(int access) => default; // 0x0000000182C9AE30-0x0000000182C9AE70
		public void Refresh() {} // 0x0000000182C9BD90-0x0000000182C9BDD0
		private void SetProcessHandle(SafeProcessHandle processHandle) {} // 0x0000000182C9AFA0-0x0000000182C9AFD0
		private void SetProcessId(int processId) {} // 0x0000000183D75E70-0x0000000183D75E80
		public bool Start() => default; // 0x0000000189A3B860-0x0000000189A3B91C
		public static Process Start(string fileName) => default; // 0x0000000189A3B9EC-0x0000000189A3BA54
		public static Process Start(ProcessStartInfo startInfo) => default; // 0x0000000189A3B91C-0x0000000189A3B9EC
		private void StopWatchingForExit() {} // 0x0000000182C9C3C0-0x0000000182C9C520
		public override string ToString() => default; // 0x0000000189A3BA54-0x0000000189A3BBAC
		public bool WaitForExit(int milliseconds) => default; // 0x0000000189A3BBAC-0x0000000189A3BDB8
		public void WaitForExit() {} // 0x0000000189A3BDB8-0x0000000189A3BDC8
		private static string ProcessName_icall(IntPtr handle) => default; // 0x0000000189A3919C-0x0000000189A391A4
		private static string ProcessName_internal(SafeProcessHandle handle) => default; // 0x0000000189A391A4-0x0000000189A39274
		private static IntPtr GetProcess_internal(int pid) => default; // 0x0000000189A38FB0-0x0000000189A38FB8
		[MonoTODO("There is no support for retrieving process information from a remote machine")]
		public static Process GetProcessById(int processId, string machineName) => default; // 0x0000000189A38DDC-0x0000000189A38FB0
		private static bool IsLocalMachine(string machineName) => default; // 0x0000000189A38FB8-0x0000000189A3902C
		private static bool ShellExecuteEx_internal(ProcessStartInfo startInfo, ref ProcInfo procInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		private static bool CreateProcess_internal(ProcessStartInfo startInfo, IntPtr stdin, IntPtr stdout, IntPtr stderr, ref ProcInfo procInfo) => default; // 0x000000018115F4C0-0x000000018115F530
		private bool StartWithShellExecuteEx(ProcessStartInfo startInfo) => default; // 0x0000000189A3B3A8-0x0000000189A3B860
		private static void CreatePipe(out IntPtr read, out IntPtr write, bool writeDirection) {
			read = default;
			write = default;
		} // 0x0000000189A387D8-0x0000000189A38A2C
		private bool StartWithCreateProcess(ProcessStartInfo startInfo) => default; // 0x0000000189A39358-0x0000000189A3B3A8
		private static void FillUserInfo(ProcessStartInfo startInfo, ref ProcInfo procInfo) {} // 0x0000000189A38CE4-0x0000000189A38DA0
		private void RaiseOnExited() {} // 0x0000000189A39274-0x0000000189A39338
	}

	internal class ProcessInfo // TypeDefIndex: 45575
	{
		// Constructors
		public ProcessInfo() {} // Dummy constructor
	}

	[DefaultMember("Item")]
	public class ProcessModuleCollection : ReadOnlyCollectionBase // TypeDefIndex: 45576
	{
		// Constructors
		public ProcessModuleCollection() {} // Dummy constructor
	}

	[TypeConverter(typeof(ExpandableObjectConverter))]
	public sealed class ProcessStartInfo // TypeDefIndex: 45577
	{
		// Fields
		private string fileName; // 0x10
		private string arguments; // 0x18
		private string directory; // 0x20
		private string verb; // 0x28
		private ProcessWindowStyle windowStyle; // 0x30
		private bool errorDialog; // 0x34
		private IntPtr errorDialogParentHandle; // 0x38
		private bool useShellExecute; // 0x40
		private string userName; // 0x48
		private string domain; // 0x50
		private SecureString password; // 0x58
		private string passwordInClearText; // 0x60
		private bool loadUserProfile; // 0x68
		private bool redirectStandardInput; // 0x69
		private bool redirectStandardOutput; // 0x6A
		private bool redirectStandardError; // 0x6B
		private Encoding standardOutputEncoding; // 0x70
		private Encoding standardErrorEncoding; // 0x78
		private bool createNoWindow; // 0x80
		private WeakReference weakParentProcess; // 0x88
		internal StringDictionary environmentVariables; // 0x90
		private static readonly string[] empty; // 0x00
		private Collection<string> _argumentList; // 0x98
		private IDictionary<string, string> environment; // 0xA0
	
		// Properties
		public Collection<string> ArgumentList { get => default; } // 0x0000000189A380FC-0x0000000189A3818C 
		[DefaultValue("")]
		[MonitoringDescription("Command line arguments that will be passed to the application specified by the FileName property.")]
		[NotifyParentProperty(true)]
		[SettingsBindable(true)]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public string Arguments { get => default; set {} } // 0x0000000189A3818C-0x0000000189A381D8 0x00000001822C3A90-0x00000001822C3AA0
		[DefaultValue(false)]
		[MonitoringDescription("Whether to start the process without creating a new window to contain it.")]
		[NotifyParentProperty(true)]
		public bool CreateNoWindow { set {} } // 0x0000000183D4F380-0x0000000183D4F390
		[DefaultValue(null)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Editor("System.Diagnostics.Design.StringDictionaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[MonitoringDescription("Set of environment variables that apply to this process and child processes.")]
		[NotifyParentProperty(true)]
		public StringDictionary EnvironmentVariables { get => default; } // 0x0000000189A38224-0x0000000189A3857C 
		[DefaultValue(false)]
		[MonitoringDescription("Whether the process command input is read from the Process instance\'s StandardInput member.")]
		[NotifyParentProperty(true)]
		public bool RedirectStandardInput { get => default; } // 0x0000000183D4F3C0-0x0000000183D4F3D0 
		[DefaultValue(false)]
		[MonitoringDescription("Whether the process output is written to the Process instance\'s StandardOutput member.")]
		[NotifyParentProperty(true)]
		public bool RedirectStandardOutput { get => default; set {} } // 0x0000000183D75120-0x0000000183D75130 0x0000000183D75B00-0x0000000183D75B10
		[DefaultValue(false)]
		[MonitoringDescription("Whether the process\'s error output is written to the Process instance\'s StandardError member.")]
		[NotifyParentProperty(true)]
		public bool RedirectStandardError { get => default; } // 0x0000000183D75130-0x0000000183D75140 
		public Encoding StandardErrorEncoding { get => default; } // 0x0000000183D4EB20-0x0000000183D4EB30 
		public Encoding StandardOutputEncoding { get => default; } // 0x0000000183D4EB30-0x0000000183D4EB40 
		[DefaultValue(true)]
		[MonitoringDescription("Whether to use the operating system shell to start the process.")]
		[NotifyParentProperty(true)]
		public bool UseShellExecute { get => default; set {} } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000183D4EEB0-0x0000000183D4EEC0
		[NotifyParentProperty(true)]
		public string UserName { get => default; } // 0x0000000189A385C8-0x0000000189A38614 
		public SecureString Password { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		[NotifyParentProperty(true)]
		public string Domain { get => default; } // 0x0000000189A381D8-0x0000000189A38224 
		[NotifyParentProperty(true)]
		public bool LoadUserProfile { get => default; } // 0x0000000183D4F3F0-0x0000000183D4F400 
		[DefaultValue("")]
		[Editor("System.Diagnostics.Design.StartFileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[MonitoringDescription("The name of the application, document or URL to start.")]
		[NotifyParentProperty(true)]
		[SettingsBindable(true)]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public string FileName { get => default; set {} } // 0x0000000189A3857C-0x0000000189A385C8 0x000000018426FEE0-0x000000018426FEF0
		[DefaultValue("")]
		[Editor("System.Diagnostics.Design.WorkingDirectoryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[MonitoringDescription("The initial working directory for the process.")]
		[NotifyParentProperty(true)]
		[SettingsBindable(true)]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public string WorkingDirectory { get => default; } // 0x0000000189A38614-0x0000000189A38660 
		internal bool HaveEnvVars { get => default; } // 0x0000000187B32650-0x0000000187B3265C 
		public Encoding StandardInputEncoding { get; } // 0x0000000183D4EB10-0x0000000183D4EB20 
	
		// Constructors
		public ProcessStartInfo() {} // Dummy constructor
		internal ProcessStartInfo(Process parent) {} // 0x0000000189A38078-0x0000000189A380FC
		public ProcessStartInfo(string fileName) {} // 0x0000000189A38064-0x0000000189A38078
		static ProcessStartInfo() {} // 0x0000000189A38000-0x0000000189A38064
	}

	[DefaultMember("Item")]
	public class ProcessThreadCollection : ReadOnlyCollectionBase // TypeDefIndex: 45578
	{
		// Constructors
		public ProcessThreadCollection() {} // Dummy constructor
	}

	internal class ProcessWaitHandle : WaitHandle // TypeDefIndex: 45579
	{
		// Constructors
		public ProcessWaitHandle() {} // Dummy constructor
		internal ProcessWaitHandle(SafeProcessHandle processHandle) {} // 0x0000000189A38660-0x0000000189A387B8
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All)]
	public class MonitoringDescriptionAttribute : DescriptionAttribute // TypeDefIndex: 45580
	{
		// Properties
		public override string Description { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public MonitoringDescriptionAttribute() {} // Dummy constructor
		public MonitoringDescriptionAttribute(string description) {} // 0x0000000189A3784C-0x0000000189A378A4
	}

	public enum ProcessWindowStyle // TypeDefIndex: 45581
	{
		Normal = 0,
		Hidden = 1,
		Minimized = 2,
		Maximized = 3
	}

	public class Stopwatch // TypeDefIndex: 45582
	{
		// Fields
		public static readonly long Frequency; // 0x00
		public static readonly bool IsHighResolution; // 0x08
		private long elapsed; // 0x10
		private long started; // 0x18
		private bool is_running; // 0x20
	
		// Properties
		public TimeSpan Elapsed { get => default; } // 0x00000001822E7190-0x00000001822E7690 
		public long ElapsedMilliseconds { get => default; } // 0x00000001823E71B0-0x00000001823E74C0 
		public long ElapsedTicks { get => default; } // 0x00000001822E7690-0x00000001822E7870 
		public bool IsRunning { get => default; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
	
		// Constructors
		public Stopwatch() {} // 0x000000018350B670-0x000000018350B680
		static Stopwatch() {} // 0x0000000183D2BAE0-0x0000000183D2BB30
	
		// Methods
		public static long GetTimestamp() => default; // 0x000000018426F618-0x000000018426F620
		public static Stopwatch StartNew() => default; // 0x0000000183640700-0x0000000183640760
		public void Reset() {} // 0x0000000183D75F10-0x0000000183D75F20
		public void Start() {} // 0x000000018233A980-0x000000018233A9E0
		public void Stop() {} // 0x000000018233AE10-0x000000018233AE90
		public void Restart() {} // 0x00000001823E5530-0x00000001823E56F0
	}

	[Obsolete("This class has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public class DiagnosticsConfigurationHandler : IConfigurationSectionHandler // TypeDefIndex: 46225
	{
		// Constructors
		public DiagnosticsConfigurationHandler() {} // 0x0000000189A15D74-0x0000000189A15DA4
	
		// Methods
		public virtual object Create(object parent, object configContext, XmlNode section) => default; // 0x0000000189A15D44-0x0000000189A15D74
	}
}

namespace System.Diagnostics.CodeAnalysis
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event, Inherited = false, AllowMultiple = false)]
	public sealed class ExcludeFromCodeCoverageAttribute : Attribute // TypeDefIndex: 45583
	{
		// Constructors
		public ExcludeFromCodeCoverageAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace System.IO
{
	[Serializable]
	public sealed class InvalidDataException : SystemException // TypeDefIndex: 46186
	{
		// Constructors
		public InvalidDataException() {} // 0x0000000189A17390-0x0000000189A173D4
		public InvalidDataException(string message) {} // 0x0000000189A17370-0x0000000189A17390
		private InvalidDataException(SerializationInfo info, StreamingContext context) {} // 0x0000000189166FDC-0x0000000189166FFC
	}
}

namespace System.IO.Compression
{
	public enum CompressionLevel // TypeDefIndex: 46187
	{
		Optimal = 0,
		Fastest = 1,
		NoCompression = 2
	}

	public enum CompressionMode // TypeDefIndex: 46188
	{
		Decompress = 0,
		Compress = 1
	}

	public class GZipStream : Stream // TypeDefIndex: 46189
	{
		// Fields
		private DeflateStream _deflateStream; // 0x28
	
		// Properties
		public override bool CanRead { get => default; } // 0x0000000189A169A8-0x0000000189A169C8 
		public override bool CanWrite { get => default; } // 0x0000000189A169E8-0x0000000189A16A08 
		public override bool CanSeek { get => default; } // 0x0000000189A169C8-0x0000000189A169E8 
		public override long Length { get => default; } // 0x0000000189A16A08-0x0000000189A16A64 
		public override long Position { get => default; set {} } // 0x0000000189A16A64-0x0000000189A16AC0 0x0000000189A16AC0-0x0000000189A16B1C
	
		// Constructors
		public GZipStream() {} // Dummy constructor
		public GZipStream(Stream stream, CompressionMode mode) {} // 0x0000000189A168D4-0x0000000189A168F0
		public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen) {} // 0x0000000189A168F0-0x0000000189A169A8
	
		// Methods
		public override void Flush() {} // 0x0000000189A1622C-0x0000000189A1625C
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x0000000189A16528-0x0000000189A16584
		public override void SetLength(long value) {} // 0x0000000189A16584-0x0000000189A165E0
		public override int ReadByte() => default; // 0x0000000189A163C8-0x0000000189A163F8
		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) => default; // 0x0000000189A15EF0-0x0000000189A15F80
		public override int EndRead(IAsyncResult asyncResult) => default; // 0x0000000189A161B8-0x0000000189A161F4
		public override int Read(byte[] array, int offset, int count) => default; // 0x0000000189A163F8-0x0000000189A16458
		public override int Read(Span<byte> buffer) => default; // 0x0000000189A16458-0x0000000189A16528
		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) => default; // 0x0000000189A15F80-0x0000000189A1600C
		public override void EndWrite(IAsyncResult asyncResult) {} // 0x0000000189158220-0x000000018915822C
		public override void Write(byte[] array, int offset, int count) {} // 0x0000000189A167A4-0x0000000189A16804
		public override void Write(ReadOnlySpan<byte> buffer) {} // 0x0000000189A16804-0x0000000189A168D4
		public override void CopyTo(Stream destination, int bufferSize) {} // 0x0000000189A16080-0x0000000189A160B4
		protected override void Dispose(bool disposing) {} // 0x0000000189A160B4-0x0000000189A161B8
		public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) => default; // 0x0000000189A1625C-0x0000000189A162C4
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default) => default; // 0x0000000189A162C4-0x0000000189A163C8
		public override System.Threading.Tasks.Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) => default; // 0x0000000189A1663C-0x0000000189A166A0
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default) => default; // 0x0000000189A166A0-0x0000000189A167A4
		public override System.Threading.Tasks.Task FlushAsync(CancellationToken cancellationToken) => default; // 0x0000000189A161F4-0x0000000189A1622C
		public override System.Threading.Tasks.Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) => default; // 0x0000000189A16024-0x0000000189A16080
		private void CheckDeflateStream() {} // 0x0000000189A1600C-0x0000000189A16024
		private static void ThrowStreamClosedException() {} // 0x0000000189A165E0-0x0000000189A1663C
	}

	public class DeflateStream : Stream // TypeDefIndex: 46192
	{
		// Fields
		private Stream base_stream; // 0x28
		private CompressionMode mode; // 0x30
		private bool leaveOpen; // 0x34
		private bool disposed; // 0x35
		private DeflateStreamNative native; // 0x38
	
		// Properties
		public override bool CanRead { get => default; } // 0x0000000189A15054-0x0000000189A15088 
		public override bool CanSeek { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool CanWrite { get => default; } // 0x0000000189A15088-0x0000000189A150BC 
		public override long Length { get => default; } // 0x0000000189A150BC-0x0000000189A15108 
		public override long Position { get => default; set {} } // 0x0000000189A15108-0x0000000189A15154 0x0000000189A15154-0x0000000189A151A0
	
		// Nested types
		private delegate int ReadMethod(byte[] array, int offset, int count); // TypeDefIndex: 46190; 0x0000000181035ED0-0x0000000181035EF0
	
		private delegate void WriteMethod(byte[] array, int offset, int count); // TypeDefIndex: 46191; 0x00000001811360D0-0x00000001811360F0
	
		// Constructors
		public DeflateStream() {} // Dummy constructor
		public DeflateStream(Stream stream, CompressionMode mode) {} // 0x0000000189A14E80-0x0000000189A14EA0
		internal DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) {} // 0x0000000189A15040-0x0000000189A15054
		internal DeflateStream(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) {} // 0x0000000189A14EA0-0x0000000189A15040
	
		// Methods
		~DeflateStream() {} // 0x0000000189190804-0x000000018919087C
		protected override void Dispose(bool disposing) {} // 0x0000000189A141EC-0x0000000189A14288
		private int ReadInternal(byte[] array, int offset, int count) => default; // 0x0000000189A1477C-0x0000000189A147D0
		internal ValueTask<int> ReadAsyncMemory(Memory<byte> destination, CancellationToken cancellationToken) => default; // 0x0000000189A1465C-0x0000000189A14698
		internal int ReadCore(Span<byte> destination) => default; // 0x0000000189A14698-0x0000000189A1477C
		public override int Read(byte[] array, int offset, int count) => default; // 0x0000000189A147D0-0x0000000189A14A64
		private void WriteInternal(byte[] array, int offset, int count) {} // 0x0000000189A14BA4-0x0000000189A14BF0
		internal ValueTask WriteAsyncMemory(ReadOnlyMemory<byte> source, CancellationToken cancellationToken) => default; // 0x0000000189A14AFC-0x0000000189A14B38
		internal void WriteCore(ReadOnlySpan<byte> source) {} // 0x0000000189A14B38-0x0000000189A14BA4
		public override void Write(byte[] array, int offset, int count) {} // 0x0000000189A14BF0-0x0000000189A14E80
		public override void Flush() {} // 0x0000000189A145B8-0x0000000189A1465C
		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) => default; // 0x0000000189A13B9C-0x0000000189A13EC4
		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) => default; // 0x0000000189A13EC4-0x0000000189A141EC
		public override int EndRead(IAsyncResult asyncResult) => default; // 0x0000000189A14288-0x0000000189A14420
		public override void EndWrite(IAsyncResult asyncResult) {} // 0x0000000189A14420-0x0000000189A145B8
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x0000000189A14A64-0x0000000189A14AB0
		public override void SetLength(long value) {} // 0x0000000189A14AB0-0x0000000189A14AFC
	}

	internal class DeflateStreamNative // TypeDefIndex: 46195
	{
		// Fields
		private UnmanagedReadOrWrite feeder; // 0x10
		private Stream base_stream; // 0x18
		private SafeDeflateStreamHandle z_stream; // 0x20
		private GCHandle data; // 0x28
		private bool disposed; // 0x30
		private byte[] io_buffer; // 0x38
		private Exception last_error; // 0x40
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int UnmanagedReadOrWrite(IntPtr buffer, int length, IntPtr data); // TypeDefIndex: 46193; 0x0000000181035ED0-0x0000000181035EF0
	
		private sealed class SafeDeflateStreamHandle : SafeHandle // TypeDefIndex: 46194
		{
			// Properties
			public override bool IsInvalid { get => default; } // 0x00000001825EB8A0-0x00000001825EB8B0 
	
			// Constructors
			private SafeDeflateStreamHandle() {} // 0x0000000184272874-0x0000000184272884
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x0000000189A1CAA4-0x0000000189A1CB1C
		}
	
		// Constructors
		private DeflateStreamNative() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) => default; // 0x0000000189A131FC-0x0000000189A13354
		~DeflateStreamNative() {} // 0x0000000189A13438-0x0000000189A134AC
		public void Dispose(bool disposing) {} // 0x0000000189A13354-0x0000000189A13438
		public void Flush() {} // 0x0000000189A134AC-0x0000000189A134F8
		public int ReadZStream(IntPtr buffer, int length) => default; // 0x0000000189A13560-0x0000000189A135D0
		public void WriteZStream(IntPtr buffer, int length) {} // 0x0000000189A13AB0-0x0000000189A13B1C
		[Mono.Util.MonoPInvokeCallback(typeof(UnmanagedReadOrWrite))]
		private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) => default; // 0x0000000189A13650-0x0000000189A136D8
		private int UnmanagedRead(IntPtr buffer, int length) => default; // 0x0000000189A136D8-0x0000000189A13860
		[Mono.Util.MonoPInvokeCallback(typeof(UnmanagedReadOrWrite))]
		private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) => default; // 0x0000000189A13A28-0x0000000189A13AB0
		private int UnmanagedWrite(IntPtr buffer, int length) => default; // 0x0000000189A13860-0x0000000189A13A28
		private void CheckResult(int result, string where) {} // 0x0000000189A1303C-0x0000000189A13168
		private static extern SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, UnmanagedReadOrWrite feeder, IntPtr data); // 0x0000000189A13170-0x0000000189A131FC
		private static extern int CloseZStream(IntPtr stream); // 0x0000000189A13168-0x0000000189A13170
		private static extern int Flush(SafeDeflateStreamHandle stream); // 0x0000000189A134F8-0x0000000189A13560
		private static extern int ReadZStream(SafeDeflateStreamHandle stream, IntPtr buffer, int length); // 0x0000000189A135D0-0x0000000189A13650
		private static extern int WriteZStream(SafeDeflateStreamHandle stream, IntPtr buffer, int length); // 0x0000000189A13B1C-0x0000000189A13B9C
	}
}

namespace System.Net
{
	internal class ContextAwareResult : LazyAsyncResult // TypeDefIndex: 45637
	{
		// Fields
		private ExecutionContext _context; // 0x40
		private object _lock; // 0x48
		private StateFlags _flags; // 0x50
	
		// Nested types
		[Flags]
		private enum StateFlags : byte // TypeDefIndex: 45635
		{
			None = 0,
			CaptureIdentity = 1,
			CaptureContext = 2,
			ThreadSafeContextCopy = 4,
			PostBlockStarted = 8,
			PostBlockFinished = 16
		}
	
		// Constructors
		public ContextAwareResult() {} // Dummy constructor
		internal ContextAwareResult(object myObject, object myState, AsyncCallback myCallBack) {} // 0x0000000189A3FAF4-0x0000000189A3FB20
		internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) {} // 0x0000000189A3FAC0-0x0000000189A3FAF4
		internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) {} // 0x0000000189A3FA58-0x0000000189A3FAC0
	
		// Methods
		private void SafeCaptureIdentity() {} // 0x000000018350B670-0x000000018350B680
		private void CleanupInternal() {} // 0x000000018350B670-0x000000018350B680
		internal object StartPostingAsyncOp() => default; // 0x0000000189A3FA4C-0x0000000189A3FA58
		internal object StartPostingAsyncOp(bool lockCapture) => default; // 0x0000000189A3F990-0x0000000189A3FA4C
		internal bool FinishPostingAsyncOp() => default; // 0x0000000189A3F95C-0x0000000189A3F990
		protected override void Cleanup() {} // 0x0000000189A3F5D4-0x0000000189A3F644
		private bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext) => default; // 0x0000000189A3F1D0-0x0000000189A3F5D4
		protected override void Complete(IntPtr userToken) {} // 0x0000000189A3F6D0-0x0000000189A3F95C
		private void CompleteCallback() {} // 0x0000000189A3F644-0x0000000189A3F6D0
	}

	internal static class HttpStatusDescription // TypeDefIndex: 45638
	{
		// Methods
		internal static string Get(HttpStatusCode code) => default; // 0x0000000189A3FB20-0x0000000189A3FB28
		internal static string Get(int code) => default; // 0x0000000189A3FB28-0x0000000189A402F0
	}

	internal static class HttpValidationHelpers // TypeDefIndex: 45639
	{
		// Fields
		private static readonly char[] s_httpTrimCharacters; // 0x00
	
		// Constructors
		static HttpValidationHelpers() {} // 0x0000000189A403F4-0x0000000189A40480
	
		// Methods
		public static bool IsInvalidMethodOrHeaderString(string stringValue) => default; // 0x0000000189A402F0-0x0000000189A403F4
	}

	internal sealed class NetEventSource : EventSource // TypeDefIndex: 45641
	{
		// Fields
		public static readonly NetEventSource Log; // 0x00
	
		// Properties
		public static bool IsEnabled { get => default; } // 0x0000000189A42758-0x0000000189A427B4 
	
		// Nested types
		public class Keywords // TypeDefIndex: 45640
		{
			// Fields
			public const EventKeywords Default = EventKeywords.None; // Metadata: 0x01FBA22D
			public const EventKeywords Debug = EventKeywords.None; // Metadata: 0x01FBA235
			public const EventKeywords EnterExit = EventKeywords.None; // Metadata: 0x01FBA23D
	
			// Constructors
			public Keywords() {} // Dummy constructor
		}
	
		// Constructors
		public NetEventSource() {} // 0x0000000184277134-0x000000018427713C
		static NetEventSource() {} // 0x0000000189A426E8-0x0000000189A42758
	
		// Methods
		[NonEvent]
		public static void Enter(object thisOrContextObject, FormattableString formattableString = null, [CallerMemberName] string memberName = null) {} // 0x0000000189A4173C-0x0000000189A41820
		[NonEvent]
		public static void Enter(object thisOrContextObject, object arg0, [CallerMemberName] string memberName = null) {} // 0x0000000189A41660-0x0000000189A4173C
		[NonEvent]
		public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, [CallerMemberName] string memberName = null) {} // 0x0000000189A41820-0x0000000189A41930
		[Event(1, Level = EventLevel.Informational, Keywords = EventKeywords.None)]
		private void Enter(string thisOrContextObject, string memberName, string parameters) {} // 0x0000000189A41930-0x0000000189A419B8
		[NonEvent]
		public static void Exit(object thisOrContextObject, FormattableString formattableString = null, [CallerMemberName] string memberName = null) {} // 0x0000000189A41B98-0x0000000189A41C7C
		[NonEvent]
		public static void Exit(object thisOrContextObject, object arg0, [CallerMemberName] string memberName = null) {} // 0x0000000189A41C7C-0x0000000189A41D4C
		[Event(2, Level = EventLevel.Informational, Keywords = EventKeywords.None)]
		private void Exit(string thisOrContextObject, string memberName, string result) {} // 0x0000000189A41B10-0x0000000189A41B98
		[NonEvent]
		public static void Info(object thisOrContextObject, FormattableString formattableString = null, [CallerMemberName] string memberName = null) {} // 0x0000000189A42478-0x0000000189A4255C
		[NonEvent]
		public static void Info(object thisOrContextObject, object message, [CallerMemberName] string memberName = null) {} // 0x0000000189A425E4-0x0000000189A426B4
		[Event(4, Level = EventLevel.Informational, Keywords = EventKeywords.None)]
		private void Info(string thisOrContextObject, string memberName, string message) {} // 0x0000000189A4255C-0x0000000189A425E4
		[NonEvent]
		public static void Error(object thisOrContextObject, object message, [CallerMemberName] string memberName = null) {} // 0x0000000189A41A40-0x0000000189A41B10
		[Event(5, Level = EventLevel.Warning, Keywords = EventKeywords.None)]
		private void ErrorMessage(string thisOrContextObject, string memberName, string message) {} // 0x0000000189A419B8-0x0000000189A41A40
		[NonEvent]
		public static void Fail(object thisOrContextObject, object message, [CallerMemberName] string memberName = null) {} // 0x0000000189A41D4C-0x0000000189A41E1C
		[Event(6, Level = EventLevel.Critical, Keywords = EventKeywords.None)]
		private void CriticalFailure(string thisOrContextObject, string memberName, string message) {} // 0x0000000189A415D8-0x0000000189A41660
		[NonEvent]
		public static void Associate(object first, object second, [CallerMemberName] string memberName = null) {} // 0x0000000189A41470-0x0000000189A41548
		[Event(3, Level = EventLevel.Informational, Keywords = EventKeywords.None, Message = "[{2}]<-->[{3}]")]
		private void Associate(string thisOrContextObject, string memberName, string first, string second) {} // 0x0000000189A41548-0x0000000189A415D8
		[NonEvent]
		public static string IdOf(object value) => default; // 0x0000000189A423BC-0x0000000189A42478
		[NonEvent]
		public static int GetHashCode(object value) => default; // 0x0000000189A4239C-0x0000000189A423BC
		[NonEvent]
		public static object Format(object value) => default; // 0x0000000189A420A8-0x0000000189A4239C
		[NonEvent]
		private static string Format(FormattableString s) => default; // 0x0000000189A41E1C-0x0000000189A420A8
		[NonEvent]
		private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4) {} // 0x0000000189A426B4-0x0000000189A426E8
	}

	internal static class TcpValidationHelpers // TypeDefIndex: 45642
	{
		// Methods
		public static bool ValidatePortNumber(int port) => default; // 0x000000018293E630-0x000000018293E650
	}

	internal class TlsStream : NetworkStream // TypeDefIndex: 45643
	{
		// Fields
		private SslStream _sslStream; // 0x48
		private string _host; // 0x50
		private System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates; // 0x58
	
		// Constructors
		public TlsStream() {} // Dummy constructor
		public TlsStream(NetworkStream stream, Socket socket, string host, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates) {} // 0x0000000189A43730-0x0000000189A43818
	
		// Methods
		public void AuthenticateAsClient() {} // 0x0000000189A43464-0x0000000189A434F8
		public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state) => default; // 0x0000000189A434F8-0x0000000189A435A4
		public void EndAuthenticateAsClient(IAsyncResult asyncResult) {} // 0x0000000189A43664-0x0000000189A43688
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) => default; // 0x0000000189A435EC-0x0000000189A43634
		public override void EndWrite(IAsyncResult result) {} // 0x0000000189A436AC-0x0000000189A436D0
		public override void Write(byte[] buffer, int offset, int size) {} // 0x0000000189A43700-0x0000000189A43730
		public override int Read(byte[] buffer, int offset, int size) => default; // 0x0000000189A436D0-0x0000000189A43700
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) => default; // 0x0000000189A435A4-0x0000000189A435EC
		public override int EndRead(IAsyncResult asyncResult) => default; // 0x0000000189A43688-0x0000000189A436AC
		public override void Close() {} // 0x0000000189A43634-0x0000000189A43664
	}

	public enum HttpStatusCode // TypeDefIndex: 45644
	{
		Continue = 100,
		SwitchingProtocols = 101,
		Processing = 102,
		EarlyHints = 103,
		OK = 200,
		Created = 201,
		Accepted = 202,
		NonAuthoritativeInformation = 203,
		NoContent = 204,
		ResetContent = 205,
		PartialContent = 206,
		MultiStatus = 207,
		AlreadyReported = 208,
		IMUsed = 226,
		MultipleChoices = 300,
		Ambiguous = 300,
		MovedPermanently = 301,
		Moved = 301,
		Found = 302,
		Redirect = 302,
		SeeOther = 303,
		RedirectMethod = 303,
		NotModified = 304,
		UseProxy = 305,
		Unused = 306,
		TemporaryRedirect = 307,
		RedirectKeepVerb = 307,
		PermanentRedirect = 308,
		BadRequest = 400,
		Unauthorized = 401,
		PaymentRequired = 402,
		Forbidden = 403,
		NotFound = 404,
		MethodNotAllowed = 405,
		NotAcceptable = 406,
		ProxyAuthenticationRequired = 407,
		RequestTimeout = 408,
		Conflict = 409,
		Gone = 410,
		LengthRequired = 411,
		PreconditionFailed = 412,
		RequestEntityTooLarge = 413,
		RequestUriTooLong = 414,
		UnsupportedMediaType = 415,
		RequestedRangeNotSatisfiable = 416,
		ExpectationFailed = 417,
		MisdirectedRequest = 421,
		UnprocessableEntity = 422,
		Locked = 423,
		FailedDependency = 424,
		UpgradeRequired = 426,
		PreconditionRequired = 428,
		TooManyRequests = 429,
		RequestHeaderFieldsTooLarge = 431,
		UnavailableForLegalReasons = 451,
		InternalServerError = 500,
		NotImplemented = 501,
		BadGateway = 502,
		ServiceUnavailable = 503,
		GatewayTimeout = 504,
		HttpVersionNotSupported = 505,
		VariantAlsoNegotiates = 506,
		InsufficientStorage = 507,
		LoopDetected = 508,
		NotExtended = 510,
		NetworkAuthenticationRequired = 511
	}

	public class HttpVersion // TypeDefIndex: 45645
	{
		// Fields
		public static readonly System.Version Unknown; // 0x00
		public static readonly System.Version Version10; // 0x08
		public static readonly System.Version Version11; // 0x10
		public static readonly System.Version Version20; // 0x18
	
		// Constructors
		public HttpVersion() {} // Dummy constructor
		static HttpVersion() {} // 0x0000000189A40480-0x0000000189A405FC
	}

	[Serializable]
	public class IPAddress // TypeDefIndex: 45647
	{
		// Fields
		public static readonly IPAddress Any; // 0x00
		public static readonly IPAddress Loopback; // 0x08
		public static readonly IPAddress Broadcast; // 0x10
		public static readonly IPAddress None; // 0x18
		internal const long LoopbackMask = 255; // Metadata: 0x01FBA2C9
		public static readonly IPAddress IPv6Any; // 0x20
		public static readonly IPAddress IPv6Loopback; // 0x28
		public static readonly IPAddress IPv6None; // 0x30
		private uint _addressOrScopeId; // 0x10
		private readonly ushort[] _numbers; // 0x18
		private string _toString; // 0x20
		private int _hashCode; // 0x28
		internal const int NumberOfLabels = 8; // Metadata: 0x01FBA2D1
	
		// Properties
		private bool IsIPv4 { get => default; } // 0x00000001829412A0-0x00000001829412B0 
		private bool IsIPv6 { get => default; } // 0x0000000182941CB0-0x0000000182941CC0 
		private uint PrivateAddress { get => default; set {} } // 0x0000000183D4E340-0x0000000183D4E350 0x0000000184272010-0x0000000184272038
		private uint PrivateScopeId { get => default; set {} } // 0x0000000183D4E340-0x0000000183D4E350 0x0000000184272010-0x0000000184272038
		public AddressFamily AddressFamily { get => default; } // 0x0000000182941280-0x00000001829412A0 
		public long ScopeId { get => default; } // 0x0000000189A41088-0x0000000189A410E8 
	
		// Nested types
		private sealed class ReadOnlyIPAddress : IPAddress // TypeDefIndex: 45646
		{
			// Constructors
			public ReadOnlyIPAddress() {} // Dummy constructor
			public ReadOnlyIPAddress(long newAddress) {} // 0x0000000182942060-0x00000001829420C0
		}
	
		// Constructors
		public IPAddress() {} // Dummy constructor
		public IPAddress(long newAddress) {} // 0x0000000182941B30-0x0000000182941B50
		public IPAddress(byte[] address, long scopeid) {} // 0x0000000182942380-0x0000000182942420
		public IPAddress(ReadOnlySpan<byte> address, long scopeid) {} // 0x00000001829428C0-0x0000000182942A00
		internal unsafe IPAddress(ushort* numbers, int numbersLength, uint scopeid) {} // 0x0000000182942A00-0x0000000182942B50
		private IPAddress(ushort[] numbers, uint scopeid) {} // 0x0000000189A40ED0-0x0000000189A40EFC
		public IPAddress(byte[] address) {} // 0x0000000189A40E44-0x0000000189A40ED0
		public IPAddress(ReadOnlySpan<byte> address) {} // 0x0000000189A40EFC-0x0000000189A41088
		static IPAddress() {} // 0x00000001829420C0-0x0000000182942380
	
		// Methods
		public static bool TryParse(string ipString, out IPAddress address) {
			address = default;
			return default;
		} // 0x0000000182940D80-0x0000000182940DD0
		public static IPAddress Parse(string ipString) => default; // 0x00000001829412B0-0x00000001829412F0
		public bool TryWriteBytes(Span<byte> destination, out int bytesWritten) {
			bytesWritten = default;
			return default;
		} // 0x0000000182941C30-0x0000000182941CB0
		private void WriteIPv6Bytes(Span<byte> destination) {} // 0x0000000189A3E09C-0x0000000189A3E128
		private void WriteIPv4Bytes(Span<byte> destination) {} // 0x0000000182941CC0-0x0000000182941D10
		public byte[] GetAddressBytes() => default; // 0x0000000182B108E0-0x0000000182B10970
		public override string ToString() => default; // 0x0000000182941DC0-0x0000000182941E10
		public static bool IsLoopback(IPAddress address) => default; // 0x0000000189A40C58-0x0000000189A40D04
		internal bool Equals(object comparandObj, bool compareScopeId) => default; // 0x0000000182940F60-0x0000000182941000
		public override bool Equals(object comparand) => default; // 0x0000000182940D70-0x0000000182940D80
		public override int GetHashCode() => default; // 0x0000000189A40A14-0x0000000189A40C58
		public IPAddress MapToIPv6() => default; // 0x0000000189A40D04-0x0000000189A40DE8
		private static byte[] ThrowAddressNullException() => default; // 0x0000000189A40DE8-0x0000000189A40E44
	}

	internal class IPAddressParser // TypeDefIndex: 45648
	{
		// Constructors
		public IPAddressParser() {} // Dummy constructor
	
		// Methods
		internal static IPAddress Parse(ReadOnlySpan<char> ipSpan, bool tryParse) => default; // 0x00000001829412F0-0x00000001829414B0
		internal static string IPv4AddressToString(uint address) => default; // 0x0000000182941E10-0x0000000182941E70
		internal static void IPv4AddressToString(uint address, StringBuilder destination) {} // 0x0000000189A40870-0x0000000189A408DC
		private static unsafe int IPv4AddressToStringHelper(uint address, char* addressString) => default; // 0x0000000182941E70-0x0000000182941F40
		internal static string IPv6AddressToString(ushort[] address, uint scopeId) => default; // 0x0000000189A409F8-0x0000000189A40A14
		internal static StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId) => default; // 0x0000000189A408DC-0x0000000189A409F8
		private static unsafe void FormatIPv4AddressNumber(int number, char* addressString, ref int offset) {} // 0x0000000182941F40-0x0000000182941FF0
		public static bool Ipv4StringToAddress(ReadOnlySpan<char> ipSpan, out long address) {
			address = default;
			return default;
		} // 0x0000000182941530-0x0000000182941620
		public static unsafe bool Ipv6StringToAddress(ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, out uint scope) {
			scope = default;
			return default;
		} // 0x0000000182942B50-0x0000000182942C40
		private static void AppendSections(ushort[] address, int fromInclusive, int toExclusive, StringBuilder buffer) {} // 0x0000000189A406A4-0x0000000189A40820
		private static void AppendHex(ushort value, StringBuilder buffer) {} // 0x0000000189A405FC-0x0000000189A406A4
		private static uint ExtractIPv4Address(ushort[] address) => default; // 0x0000000189A40820-0x0000000189A40870
		private static ushort Reverse(ushort number) => default; // 0x0000000183D70670-0x0000000183D70680
	}

	[Serializable]
	public class IPEndPoint : EndPoint // TypeDefIndex: 45649
	{
		// Fields
		private IPAddress _address; // 0x10
		private int _port; // 0x18
		internal static IPEndPoint Any; // 0x00
		internal static IPEndPoint IPv6Any; // 0x08
	
		// Properties
		public override AddressFamily AddressFamily { get => default; } // 0x0000000182942030-0x0000000182942060 
		public IPAddress Address { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public int Port { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
	
		// Constructors
		public IPEndPoint() {} // Dummy constructor
		public IPEndPoint(IPAddress address, int port) {} // 0x000000018293E5D0-0x000000018293E630
		static IPEndPoint() {} // 0x0000000183B6E490-0x0000000183B6E5B0
	
		// Methods
		public override string ToString() => default; // 0x0000000189A413B8-0x0000000189A41470
		public override SocketAddress Serialize() => default; // 0x0000000182940990-0x0000000182940A10
		public override EndPoint Create(SocketAddress socketAddress) => default; // 0x0000000189A410E8-0x0000000189A41310
		public override bool Equals(object comparand) => default; // 0x0000000189A41310-0x0000000189A4138C
		public override int GetHashCode() => default; // 0x0000000189A4138C-0x0000000189A413B8
	}

	internal class CommandStream : NetworkStreamWrapper // TypeDefIndex: 45653
	{
		// Fields
		private static readonly AsyncCallback s_writeCallbackDelegate; // 0x00
		private static readonly AsyncCallback s_readCallbackDelegate; // 0x08
		private bool _recoverableFailure; // 0x38
		protected WebRequest _request; // 0x40
		protected bool _isAsync; // 0x48
		private bool _aborted; // 0x49
		protected PipelineEntry[] _commands; // 0x50
		protected int _index; // 0x58
		private bool _doRead; // 0x5C
		private bool _doSend; // 0x5D
		private ResponseDescription _currentResponseDescription; // 0x60
		protected string _abortReason; // 0x68
		private string _buffer; // 0x70
		private Encoding _encoding; // 0x78
		private System.Text.Decoder _decoder; // 0x80
	
		// Properties
		internal bool RecoverableFailure { get => default; } // 0x0000000183D4F190-0x0000000183D4F1A0 
		protected Encoding Encoding { get => default; set {} } // 0x0000000183D4EB20-0x0000000183D4EB30 0x0000000189A543A8-0x0000000189A543EC
	
		// Nested types
		internal enum PipelineInstruction // TypeDefIndex: 45650
		{
			Abort = 0,
			Advance = 1,
			Pause = 2,
			Reread = 3,
			GiveStream = 4
		}
	
		[Flags]
		internal enum PipelineEntryFlags // TypeDefIndex: 45651
		{
			UserCommand = 1,
			GiveDataStream = 2,
			CreateDataConnection = 4,
			DontLogParameter = 8
		}
	
		internal class PipelineEntry // TypeDefIndex: 45652
		{
			// Fields
			internal string Command; // 0x10
			internal PipelineEntryFlags Flags; // 0x18
	
			// Constructors
			public PipelineEntry() {} // Dummy constructor
			internal PipelineEntry(string command) {} // 0x000000018426FEE0-0x000000018426FEF0
			internal PipelineEntry(string command, PipelineEntryFlags flags) {} // 0x0000000182738A30-0x0000000182738A50
	
			// Methods
			internal bool HasFlag(PipelineEntryFlags flags) => default; // 0x0000000185D621AC-0x0000000185D621B4
		}
	
		// Constructors
		public CommandStream() {} // Dummy constructor
		internal CommandStream(TcpClient client) {} // 0x0000000189A54308-0x0000000189A543A8
		static CommandStream() {} // 0x0000000189A54214-0x0000000189A54308
	
		// Methods
		internal virtual void Abort(Exception e) {} // 0x0000000189A52738-0x0000000189A528F4
		protected override void Dispose(bool disposing) {} // 0x0000000189A52DC0-0x0000000189A52E3C
		protected void InvokeRequestCallback(object obj) {} // 0x0000000189A53020-0x0000000189A53080
		protected void MarkAsRecoverableFailure() {} // 0x0000000189A53080-0x0000000189A5308C
		internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect) => default; // 0x0000000189A53F54-0x0000000189A53FE8
		protected virtual void ClearState() {} // 0x0000000189A5298C-0x0000000189A529AC
		protected virtual PipelineEntry[] BuildCommandsList(WebRequest request) => default; // 0x0000000181002730-0x0000000181002740
		protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException) => default; // 0x0000000189A52EEC-0x0000000189A52F74
		protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException) => default; // 0x0000000189A52E3C-0x0000000189A52EEC
		protected void InitCommandPipeline(WebRequest request, PipelineEntry[] commands, bool isAsync) {} // 0x0000000189A52F74-0x0000000189A53020
		internal void CheckContinuePipeline() {} // 0x0000000189A528F4-0x0000000189A5298C
		protected Stream ContinueCommandPipeline() => default; // 0x0000000189A529AC-0x0000000189A52DC0
		private bool PostSendCommandProcessing(ref Stream stream) => default; // 0x0000000189A532AC-0x0000000189A533F4
		private bool PostReadCommandProcessing(ref Stream stream) => default; // 0x0000000189A5308C-0x0000000189A532AC
		protected virtual PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) => default; // 0x0000000181002730-0x0000000181002740
		private static void ReadCallback(IAsyncResult asyncResult) {} // 0x0000000189A533F4-0x0000000189A53644
		private static void WriteCallback(IAsyncResult asyncResult) {} // 0x0000000189A53FE8-0x0000000189A54214
		protected virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) => default; // 0x000000018115F4C0-0x000000018115F530
		private ResponseDescription ReceiveCommandResponse() => default; // 0x0000000189A53C60-0x0000000189A53F54
		private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead) {} // 0x0000000189A53644-0x0000000189A53C60
	}

	internal class ResponseDescription // TypeDefIndex: 45654
	{
		// Fields
		internal bool Multiline; // 0x10
		internal int Status; // 0x14
		internal string StatusDescription; // 0x18
		internal StringBuilder StatusBuffer; // 0x20
		internal string StatusCodeString; // 0x28
	
		// Properties
		internal bool PositiveIntermediate { get => default; } // 0x0000000189A641F4-0x0000000189A64208 
		internal bool PositiveCompletion { get => default; } // 0x0000000189A641DC-0x0000000189A641F4 
		internal bool TransientFailure { get => default; } // 0x0000000189A64208-0x0000000189A64220 
		internal bool PermanentFailure { get => default; } // 0x0000000189A641C4-0x0000000189A641DC 
		internal bool InvalidStatusCode { get => default; } // 0x0000000189A641B0-0x0000000189A641C4 
	
		// Constructors
		public ResponseDescription() {} // 0x0000000189A64148-0x0000000189A641B0
	}

	internal class ReceiveState // TypeDefIndex: 45655
	{
		// Fields
		internal ResponseDescription Resp; // 0x10
		internal int ValidThrough; // 0x18
		internal byte[] Buffer; // 0x20
		internal CommandStream Connection; // 0x28
	
		// Constructors
		public ReceiveState() {} // Dummy constructor
		internal ReceiveState(CommandStream connection) {} // 0x0000000189A640A4-0x0000000189A64148
	}

	internal enum FtpLoginState : byte // TypeDefIndex: 45656
	{
		NotLoggedIn = 0,
		LoggedIn = 1,
		LoggedInButNeedsRelogin = 2,
		ReloginFailed = 3
	}

	internal class FtpControlStream : CommandStream // TypeDefIndex: 45659
	{
		// Fields
		private Socket _dataSocket; // 0x88
		private IPEndPoint _passiveEndPoint; // 0x90
		private TlsStream _tlsStream; // 0x98
		private StringBuilder _bannerMessage; // 0xA0
		private StringBuilder _welcomeMessage; // 0xA8
		private StringBuilder _exitMessage; // 0xB0
		private WeakReference _credentials; // 0xB8
		private string _currentTypeSetting; // 0xC0
		private long _contentLength; // 0xC8
		private System.DateTime _lastModified; // 0xD0
		private bool _dataHandshakeStarted; // 0xD8
		private string _loginDirectory; // 0xE0
		private string _establishedServerDirectory; // 0xE8
		private string _requestedServerDirectory; // 0xF0
		private System.Uri _responseUri; // 0xF8
		private FtpLoginState _loginState; // 0x100
		internal FtpStatusCode StatusCode; // 0x104
		internal string StatusLine; // 0x108
		private static readonly AsyncCallback s_acceptCallbackDelegate; // 0x00
		private static readonly AsyncCallback s_connectCallbackDelegate; // 0x08
		private static readonly AsyncCallback s_SSLHandshakeCallback; // 0x10
	
		// Properties
		internal NetworkCredential Credentials { get => default; set {} } // 0x0000000189A58D6C-0x0000000189A58DE4 0x0000000189A58E3C-0x0000000189A58EDC
		internal long ContentLength { get => default; } // 0x0000000183D4E7C0-0x0000000183D4E7D0 
		internal System.DateTime LastModified { get => default; } // 0x0000000183D50050-0x0000000183D50060 
		internal System.Uri ResponseUri { get => default; } // 0x0000000183D50160-0x0000000183D50170 
		internal string BannerMessage { get => default; } // 0x0000000189A58D40-0x0000000189A58D6C 
		internal string WelcomeMessage { get => default; } // 0x0000000189A58E10-0x0000000189A58E3C 
		internal string ExitMessage { get => default; } // 0x0000000189A58DE4-0x0000000189A58E10 
	
		// Nested types
		private enum GetPathOption // TypeDefIndex: 45657
		{
			Normal = 0,
			AssumeFilename = 1,
			AssumeNoFilename = 2
		}
	
		// Constructors
		public FtpControlStream() {} // Dummy constructor
		internal FtpControlStream(TcpClient client) {} // 0x0000000189A58CB8-0x0000000189A58D40
		static FtpControlStream() {} // 0x0000000189A58B64-0x0000000189A58CB8
	
		// Methods
		internal void AbortConnect() {} // 0x0000000189A547D0-0x0000000189A54850
		private static void AcceptCallback(IAsyncResult asyncResult) {} // 0x0000000189A54850-0x0000000189A54B90
		private static void ConnectCallback(IAsyncResult asyncResult) {} // 0x0000000189A55DD0-0x0000000189A55EF0
		private static void SSLHandshakeCallback(IAsyncResult asyncResult) {} // 0x0000000189A585A8-0x0000000189A586C8
		private PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream) => default; // 0x0000000189A582A0-0x0000000189A585A8
		protected override void ClearState() {} // 0x0000000189A55CFC-0x0000000189A55DD0
		protected override PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) => default; // 0x0000000189A57140-0x0000000189A57B14
		protected override PipelineEntry[] BuildCommandsList(WebRequest req) => default; // 0x0000000189A54B90-0x0000000189A559CC
		private PipelineInstruction QueueOrCreateDataConection(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, out bool isSocketReady) {
			isSocketReady = default;
			return default;
		} // 0x0000000189A57B14-0x0000000189A582A0
		private static void GetPathInfo(GetPathOption pathOption, System.Uri uri, out string path, out string directory, out string filename) {
			path = default;
			directory = default;
			filename = default;
		} // 0x0000000189A5695C-0x0000000189A56B2C
		private string FormatAddress(IPAddress address, int Port) => default; // 0x0000000189A56220-0x0000000189A56330
		private string FormatAddressV6(IPAddress address, int port) => default; // 0x0000000189A56124-0x0000000189A56220
		private long GetContentLengthFrom213Response(string responseString) => default; // 0x0000000189A56430-0x0000000189A5655C
		private System.DateTime GetLastModifiedFrom213Response(string str) => default; // 0x0000000189A5655C-0x0000000189A568C4
		private void TryUpdateResponseUri(string str, FtpWebRequest request) {} // 0x0000000189A587A8-0x0000000189A58B64
		private void TryUpdateContentLength(string str) {} // 0x0000000189A586C8-0x0000000189A587A8
		private string GetLoginDirectory(string str) => default; // 0x0000000189A568C4-0x0000000189A5695C
		private int GetPortV4(string responseString) => default; // 0x0000000189A56D04-0x0000000189A56EC8
		private int GetPortV6(string responseString) => default; // 0x0000000189A56EC8-0x0000000189A570C8
		private void CreateFtpListenerSocket(FtpWebRequest request) {} // 0x0000000189A55F7C-0x0000000189A56124
		private string GetPortCommandLine(FtpWebRequest request) => default; // 0x0000000189A56B2C-0x0000000189A56D04
		private string FormatFtpCommand(string command, string parameter) => default; // 0x0000000189A56330-0x0000000189A56430
		protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket) => default; // 0x0000000189A55EF0-0x0000000189A55F7C
		protected override bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) => default; // 0x0000000189A559CC-0x0000000189A55CFC
		private System.Net.TriState IsFtpDataStreamWriteable() => default; // 0x0000000189A570C8-0x0000000189A57140
	}

	internal class FtpDataStream : Stream, ICloseEx // TypeDefIndex: 45660
	{
		// Fields
		private FtpWebRequest _request; // 0x28
		private NetworkStream _networkStream; // 0x30
		private bool _writeable; // 0x38
		private bool _readable; // 0x39
		private bool _isFullyRead; // 0x3A
		private bool _closing; // 0x3B
	
		// Properties
		public override bool CanRead { get => default; } // 0x0000000183D4F300-0x0000000183D4F310 
		public override bool CanSeek { get => default; } // 0x0000000189A59D94-0x0000000189A59DB8 
		public override bool CanWrite { get => default; } // 0x0000000183D4F190-0x0000000183D4F1A0 
		public override long Length { get => default; } // 0x0000000189A59DDC-0x0000000189A59E00 
		public override long Position { get => default; set {} } // 0x0000000189A59E00-0x0000000189A59E24 0x0000000189A59E6C-0x0000000189A59E90
		public override bool CanTimeout { get => default; } // 0x0000000189A59DB8-0x0000000189A59DDC 
		public override int ReadTimeout { get => default; set {} } // 0x0000000189A59E24-0x0000000189A59E48 0x0000000189A59E90-0x0000000189A59EB4
		public override int WriteTimeout { get => default; set {} } // 0x0000000189A59E48-0x0000000189A59E6C 0x0000000189A59EB4-0x0000000189A59ED8
	
		// Constructors
		public FtpDataStream() {} // Dummy constructor
		internal FtpDataStream(NetworkStream networkStream, FtpWebRequest request, System.Net.TriState writeOnly) {} // 0x0000000189A59CB4-0x0000000189A59D94
	
		// Methods
		protected override void Dispose(bool disposing) {} // 0x0000000189A593A4-0x0000000189A59444
		void ICloseEx.CloseEx(CloseExState closeState) {} // 0x0000000189A5983C-0x0000000189A59BDC
		private void CheckError() {} // 0x0000000189A59358-0x0000000189A593A4
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x0000000189A596FC-0x0000000189A597CC
		public override int Read(byte[] buffer, int offset, int size) => default; // 0x0000000189A59610-0x0000000189A596FC
		public override void Write(byte[] buffer, int offset, int size) {} // 0x0000000189A59BDC-0x0000000189A59CB4
		private void AsyncReadCallback(IAsyncResult ar) {} // 0x0000000189A58EDC-0x0000000189A590B0
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) => default; // 0x0000000189A590B0-0x0000000189A59254
		public override int EndRead(IAsyncResult ar) => default; // 0x0000000189A59444-0x0000000189A59560
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) => default; // 0x0000000189A59254-0x0000000189A59358
		public override void EndWrite(IAsyncResult asyncResult) {} // 0x0000000189A59560-0x0000000189A595EC
		public override void Flush() {} // 0x0000000189A595EC-0x0000000189A59610
		public override void SetLength(long value) {} // 0x0000000189A597CC-0x0000000189A597F0
		internal void SetSocketTimeoutOption(int timeout) {} // 0x0000000189A597F0-0x0000000189A5983C
	}

	internal enum FtpOperation // TypeDefIndex: 45661
	{
		DownloadFile = 0,
		ListDirectory = 1,
		ListDirectoryDetails = 2,
		UploadFile = 3,
		UploadFileUnique = 4,
		AppendFile = 5,
		DeleteFile = 6,
		GetDateTimestamp = 7,
		GetFileSize = 8,
		Rename = 9,
		MakeDirectory = 10,
		RemoveDirectory = 11,
		PrintWorkingDirectory = 12,
		Other = 13
	}

	[Flags]
	internal enum FtpMethodFlags // TypeDefIndex: 45662
	{
		None = 0,
		IsDownload = 1,
		IsUpload = 2,
		TakesParameter = 4,
		MayTakeParameter = 8,
		DoesNotTakeParameter = 16,
		ParameterIsDirectory = 32,
		ShouldParseForResponseUri = 64,
		HasHttpCommand = 128,
		MustChangeWorkingDirectoryToPath = 256
	}

	internal class FtpMethodInfo // TypeDefIndex: 45663
	{
		// Fields
		internal string Method; // 0x10
		internal FtpOperation Operation; // 0x18
		internal FtpMethodFlags Flags; // 0x1C
		internal string HttpCommand; // 0x20
		private static readonly FtpMethodInfo[] s_knownMethodInfo; // 0x00
	
		// Properties
		internal bool IsCommandOnly { get => default; } // 0x0000000189A5A608-0x0000000189A5A610 
		internal bool IsUpload { get => default; } // 0x0000000189A5A610-0x0000000189A5A618 
		internal bool IsDownload { get => default; } // 0x000000018579B658-0x000000018579B660 
		internal bool ShouldParseForResponseUri { get => default; } // 0x0000000189A5A618-0x0000000189A5A620 
	
		// Constructors
		public FtpMethodInfo() {} // Dummy constructor
		internal FtpMethodInfo(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) {} // 0x0000000189A5A5D0-0x0000000189A5A608
		static FtpMethodInfo() {} // 0x0000000189A5A028-0x0000000189A5A5D0
	
		// Methods
		internal bool HasFlag(FtpMethodFlags flags) => default; // 0x0000000189A5A020-0x0000000189A5A028
		internal static FtpMethodInfo GetMethodInfo(string method) => default; // 0x0000000189A59ED8-0x0000000189A5A020
	}

	public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 45667
	{
		// Fields
		private object _syncObject; // 0x38
		private ICredentials _authInfo; // 0x40
		private readonly System.Uri _uri; // 0x48
		private FtpMethodInfo _methodInfo; // 0x50
		private string _renameTo; // 0x58
		private bool _getRequestStreamStarted; // 0x60
		private bool _getResponseStarted; // 0x61
		private System.DateTime _startTime; // 0x68
		private int _timeout; // 0x70
		private int _remainingTimeout; // 0x74
		private long _contentLength; // 0x78
		private long _contentOffset; // 0x80
		private System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates; // 0x88
		private bool _passive; // 0x90
		private bool _binary; // 0x91
		private string _connectionGroupName; // 0x98
		private bool _async; // 0xA0
		private bool _aborted; // 0xA1
		private bool _timedOut; // 0xA2
		private Exception _exception; // 0xA8
		private TimerThread.Queue _timerQueue; // 0xB0
		private TimerThread.Callback _timerCallback; // 0xB8
		private bool _enableSsl; // 0xC0
		private FtpControlStream _connection; // 0xC8
		private Stream _stream; // 0xD0
		private RequestStage _requestStage; // 0xD8
		private bool _onceFailed; // 0xDC
		private WebHeaderCollection _ftpRequestHeaders; // 0xE0
		private FtpWebResponse _ftpWebResponse; // 0xE8
		private int _readWriteTimeout; // 0xF0
		private ContextAwareResult _writeAsyncResult; // 0xF8
		private LazyAsyncResult _readAsyncResult; // 0x100
		private LazyAsyncResult _requestCompleteAsyncResult; // 0x108
		private static readonly NetworkCredential s_defaultFtpNetworkCredential; // 0x00
		private static readonly TimerThread.Queue s_DefaultTimerQueue; // 0x08
	
		// Properties
		internal FtpMethodInfo MethodInfo { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public override string Method { get => default; set {} } // 0x00000001842711AC-0x00000001842711C8 0x0000000189A5FACC-0x0000000189A5FCCC
		public string RenameTo { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		public override ICredentials Credentials { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000189A5F94C-0x0000000189A5FACC
		public override System.Uri RequestUri { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public override int Timeout { get => default; set {} } // 0x0000000183D4F0C0-0x0000000183D4F0D0 0x0000000189A5FD60-0x0000000189A5FE60
		internal int RemainingTimeout { get => default; } // 0x0000000183D4F0D0-0x0000000183D4F0E0 
		public int ReadWriteTimeout { get => default; } // 0x0000000183D50F00-0x0000000183D50F10 
		public long ContentOffset { get => default; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 
		public override long ContentLength { get => default; set {} } // 0x0000000183D4EB20-0x0000000183D4EB30 0x0000000183D4F280-0x0000000183D4F290
		public override IWebProxy Proxy { get => default; set {} } // 0x0000000181002730-0x0000000181002740 0x0000000189A5FCF4-0x0000000189A5FD60
		public override string ConnectionGroupName { set {} } // 0x0000000189A5F8C0-0x0000000189A5F94C
		internal bool Aborted { get => default; } // 0x0000000183D50A50-0x0000000183D50A60 
		private TimerThread.Queue TimerQueue { get => default; } // 0x0000000189A5F7BC-0x0000000189A5F82C 
		public override RequestCachePolicy CachePolicy { set {} } // 0x0000000189A5F854-0x0000000189A5F8C0
		public bool UseBinary { get => default; } // 0x0000000183D50B80-0x0000000183D50B90 
		public bool UsePassive { get => default; } // 0x0000000183D58A70-0x0000000183D58A80 
		public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get => default; } // 0x0000000189A5F620-0x0000000189A5F72C 
		public bool EnableSsl { get => default; } // 0x0000000183D583F0-0x0000000183D58400 
		public override WebHeaderCollection Headers { get => default; } // 0x0000000189A5F72C-0x0000000189A5F7A8 
		public override bool UseDefaultCredentials { get => default; } // 0x0000000189A5F82C-0x0000000189A5F854 
		public override bool PreAuthenticate { set {} } // 0x0000000189A5FCCC-0x0000000189A5FCF4
		private bool InUse { get => default; } // 0x0000000189A5F7A8-0x0000000189A5F7BC 
	
		// Nested types
		private enum RequestStage // TypeDefIndex: 45664
		{
			CheckForError = 0,
			RequestStarted = 1,
			WriteReady = 2,
			ReadReady = 3,
			ReleaseConnection = 4
		}
	
		// Constructors
		public FtpWebRequest() {} // Dummy constructor
		internal FtpWebRequest(System.Uri uri) {} // 0x0000000189A5F25C-0x0000000189A5F620
		static FtpWebRequest() {} // 0x0000000189A5F140-0x0000000189A5F25C
	
		// Methods
		public override WebResponse GetResponse() => default; // 0x0000000189A5D7EC-0x0000000189A5DED8
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) => default; // 0x0000000189A5BC18-0x0000000189A5C27C
		public override WebResponse EndGetResponse(IAsyncResult asyncResult) => default; // 0x0000000189A5C8E8-0x0000000189A5CC34
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) => default; // 0x0000000189A5B6F8-0x0000000189A5BC18
		public override Stream EndGetRequestStream(IAsyncResult asyncResult) => default; // 0x0000000189A5C528-0x0000000189A5C8E8
		private void SubmitRequest(bool isAsync) {} // 0x0000000189A5E218-0x0000000189A5E6E4
		private Exception TranslateConnectException(Exception e) => default; // 0x0000000189A5F080-0x0000000189A5F140
		private async void CreateConnectionAsync() {} // 0x0000000189A5C2A0-0x0000000189A5C334
		private FtpControlStream CreateConnection() => default; // 0x0000000189A5C334-0x0000000189A5C4A0
		private Stream TimedSubmitRequestHelper(bool isAsync) => default; // 0x0000000189A5EA80-0x0000000189A5EFA8
		private void TimerCallback(TimerThread.Timer timer, int timeNoticed, object context) {} // 0x0000000189A5EFA8-0x0000000189A5F080
		private bool AttemptedRecovery(Exception e) => default; // 0x0000000189A5B480-0x0000000189A5B6F8
		private void SetException(Exception exception) {} // 0x0000000189A5DF00-0x0000000189A5E218
		private void CheckError() {} // 0x0000000189A5C27C-0x0000000189A5C2A0
		internal void RequestCallback(object obj) {} // 0x0000000189A5DED8-0x0000000189A5DF00
		private void SyncRequestCallback(object obj) {} // 0x0000000189A5E6E4-0x0000000189A5EA80
		private void AsyncRequestCallback(object obj) {} // 0x0000000189A5AA74-0x0000000189A5B480
		private RequestStage FinishRequestStage(RequestStage stage) => default; // 0x0000000189A5D2F0-0x0000000189A5D7EC
		public override void Abort() {} // 0x0000000189A5A680-0x0000000189A5AA74
		private void EnsureFtpWebResponse(Exception exception) {} // 0x0000000189A5CC34-0x0000000189A5D2F0
		internal void DataStreamClosed(CloseExState closeState) {} // 0x0000000189A5C4A0-0x0000000189A5C528
	}

	internal class FtpWebRequestCreator : IWebRequestCreate // TypeDefIndex: 45668
	{
		// Constructors
		internal FtpWebRequestCreator() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public WebRequest Create(System.Uri uri) => default; // 0x0000000189A5A620-0x0000000189A5A680
	}

	public class FtpWebResponse : WebResponse, IDisposable // TypeDefIndex: 45670
	{
		// Fields
		internal Stream _responseStream; // 0x20
		private long _contentLength; // 0x28
		private System.Uri _responseUri; // 0x30
		private FtpStatusCode _statusCode; // 0x38
		private string _statusLine; // 0x40
		private WebHeaderCollection _ftpRequestHeaders; // 0x48
		private System.DateTime _lastModified; // 0x50
		private string _bannerMessage; // 0x58
		private string _welcomeMessage; // 0x60
		private string _exitMessage; // 0x68
	
		// Properties
		public override WebHeaderCollection Headers { get => default; } // 0x0000000189A60184-0x0000000189A603B4 
		public override System.Uri ResponseUri { get => default; } // 0x0000000181003830-0x0000000181003840 
		public FtpStatusCode StatusCode { get => default; } // 0x0000000183D4EC30-0x0000000183D4EC40 
	
		// Nested types
		internal sealed class EmptyStream : MemoryStream // TypeDefIndex: 45669
		{
			// Constructors
			internal EmptyStream() {} // 0x0000000189A544D8-0x0000000189A54520
		}
	
		// Constructors
		public FtpWebResponse() {} // Dummy constructor
		internal FtpWebResponse(Stream responseStream, long contentLength, System.Uri responseUri, FtpStatusCode statusCode, string statusLine, System.DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) {} // 0x0000000189A60038-0x0000000189A60184
	
		// Methods
		internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) {} // 0x0000000189A60010-0x0000000189A60038
		public override Stream GetResponseStream() => default; // 0x0000000189A5FF18-0x0000000189A5FF90
		internal void SetResponseStream(Stream stream) {} // 0x0000000189A5FF90-0x0000000189A60010
		public override void Close() {} // 0x0000000189A5FE60-0x0000000189A5FF18
	}

	internal class NetworkStreamWrapper : Stream // TypeDefIndex: 45671
	{
		// Fields
		private TcpClient _client; // 0x28
		private NetworkStream _networkStream; // 0x30
	
		// Properties
		protected bool UsingSecureStream { get => default; } // 0x0000000189A64058-0x0000000189A6409C 
		internal IPAddress ServerAddress { get => default; } // 0x0000000189A63FE4-0x0000000189A64058 
		internal Socket Socket { get => default; } // 0x000000018426FC40-0x000000018426FC5C 
		internal NetworkStream NetworkStream { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public override bool CanRead { get => default; } // 0x0000000189A63F9C-0x0000000189A63FC0 
		public override bool CanSeek { get => default; } // 0x0000000189A59D94-0x0000000189A59DB8 
		public override bool CanWrite { get => default; } // 0x0000000189A63FC0-0x0000000189A63FE4 
		public override bool CanTimeout { get => default; } // 0x0000000189A59DB8-0x0000000189A59DDC 
		public override int ReadTimeout { get => default; set {} } // 0x0000000189A59E24-0x0000000189A59E48 0x0000000189A59E90-0x0000000189A59EB4
		public override int WriteTimeout { get => default; set {} } // 0x0000000189A59E48-0x0000000189A59E6C 0x0000000189A59EB4-0x0000000189A59ED8
		public override long Length { get => default; } // 0x0000000189A59DDC-0x0000000189A59E00 
		public override long Position { get => default; set {} } // 0x0000000189A59E00-0x0000000189A59E24 0x0000000189A59E6C-0x0000000189A59E90
	
		// Constructors
		public NetworkStreamWrapper() {} // Dummy constructor
		internal NetworkStreamWrapper(TcpClient client) {} // 0x0000000189A63F28-0x0000000189A63F9C
	
		// Methods
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x0000000189A63E98-0x0000000189A63EC4
		public override int Read(byte[] buffer, int offset, int size) => default; // 0x0000000189A63E68-0x0000000189A63E98
		public override void Write(byte[] buffer, int offset, int size) {} // 0x0000000189A63EF8-0x0000000189A63F28
		protected override void Dispose(bool disposing) {} // 0x0000000189A63D2C-0x0000000189A63DBC
		internal void CloseSocket() {} // 0x0000000189A63CB8-0x0000000189A63CF4
		public void Close(int timeout) {} // 0x0000000189A63CF4-0x0000000189A63D2C
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) => default; // 0x0000000189A63C28-0x0000000189A63C70
		public override int EndRead(IAsyncResult asyncResult) => default; // 0x0000000189A63DBC-0x0000000189A63DE0
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => default; // 0x0000000189A63E2C-0x0000000189A63E68
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) => default; // 0x0000000189A63C70-0x0000000189A63CB8
		public override void EndWrite(IAsyncResult asyncResult) {} // 0x0000000189A63DE0-0x0000000189A63E04
		public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => default; // 0x0000000189A63EC4-0x0000000189A63EF8
		public override void Flush() {} // 0x0000000189A595EC-0x0000000189A59610
		public override System.Threading.Tasks.Task FlushAsync(CancellationToken cancellationToken) => default; // 0x0000000189A63E04-0x0000000189A63E2C
		public override void SetLength(long value) {} // 0x0000000189A597CC-0x0000000189A597F0
		internal void SetSocketTimeoutOption(int timeout) {} // 0x0000000189A597F0-0x0000000189A5983C
	}

	[Flags]
	public enum SecurityProtocolType // TypeDefIndex: 45672
	{
		SystemDefault = 0,
		Ssl3 = 48,
		Tls = 192,
		Tls11 = 768,
		Tls12 = 3072,
		Tls13 = 12288
	}

	public class Authorization // TypeDefIndex: 45673
	{
		// Fields
		private string m_Message; // 0x10
		private bool m_Complete; // 0x18
		internal string ModuleAuthenticationType; // 0x20
	
		// Properties
		public string Message { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public bool Complete { get => default; } // 0x0000000181002A50-0x0000000181002A60 
	
		// Constructors
		public Authorization() {} // Dummy constructor
		public Authorization(string token) {} // 0x0000000189A52018-0x0000000189A5207C
		public Authorization(string token, bool finished) {} // 0x0000000189A5207C-0x0000000189A520EC
	}

	public class CredentialCache // TypeDefIndex: 45674
	{
		// Properties
		public static ICredentials DefaultCredentials { get => default; } // 0x0000000189A543EC-0x0000000189A5443C 
		public static NetworkCredential DefaultNetworkCredentials { get => default; } // 0x0000000189A5443C-0x0000000189A5448C 
	
		// Constructors
		public CredentialCache() {} // Dummy constructor
	}

	internal class SystemNetworkCredential : NetworkCredential // TypeDefIndex: 45675
	{
		// Fields
		internal static readonly SystemNetworkCredential defaultCredential; // 0x00
	
		// Constructors
		private SystemNetworkCredential() {} // 0x0000000189A649A0-0x0000000189A649F0
		static SystemNetworkCredential() {} // 0x0000000189A64930-0x0000000189A649A0
	}

	[Serializable]
	public abstract class EndPoint // TypeDefIndex: 45676
	{
		// Properties
		public virtual AddressFamily AddressFamily { get; } // 0x0000000189A54570-0x0000000189A54598 
	
		// Constructors
		protected EndPoint() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual SocketAddress Serialize() => default; // 0x0000000189A54548-0x0000000189A54570
		public virtual EndPoint Create(SocketAddress socketAddress) => default; // 0x0000000189A54520-0x0000000189A54548
	}

	public enum FtpStatusCode // TypeDefIndex: 45677
	{
		Undefined = 0,
		RestartMarker = 110,
		ServiceTemporarilyNotAvailable = 120,
		DataAlreadyOpen = 125,
		OpeningData = 150,
		CommandOK = 200,
		CommandExtraneous = 202,
		DirectoryStatus = 212,
		FileStatus = 213,
		SystemType = 215,
		SendUserCommand = 220,
		ClosingControl = 221,
		ClosingData = 226,
		EnteringPassive = 227,
		LoggedInProceed = 230,
		ServerWantsSecureSession = 234,
		FileActionOK = 250,
		PathnameCreated = 257,
		SendPasswordCommand = 331,
		NeedLoginAccount = 332,
		FileCommandPending = 350,
		ServiceNotAvailable = 421,
		CantOpenData = 425,
		ConnectionClosed = 426,
		ActionNotTakenFileUnavailableOrBusy = 450,
		ActionAbortedLocalProcessingError = 451,
		ActionNotTakenInsufficientSpace = 452,
		CommandSyntaxError = 500,
		ArgumentSyntaxError = 501,
		CommandNotImplemented = 502,
		BadCommandSequence = 503,
		NotLoggedIn = 530,
		AccountNeeded = 532,
		ActionNotTakenFileUnavailable = 550,
		ActionAbortedUnknownPageType = 551,
		FileActionAborted = 552,
		ActionNotTakenFilenameNotAllowed = 553
	}

	public enum HttpRequestHeader // TypeDefIndex: 45678
	{
		CacheControl = 0,
		Connection = 1,
		Date = 2,
		KeepAlive = 3,
		Pragma = 4,
		Trailer = 5,
		TransferEncoding = 6,
		Upgrade = 7,
		Via = 8,
		Warning = 9,
		Allow = 10,
		ContentLength = 11,
		ContentType = 12,
		ContentEncoding = 13,
		ContentLanguage = 14,
		ContentLocation = 15,
		ContentMd5 = 16,
		ContentRange = 17,
		Expires = 18,
		LastModified = 19,
		Accept = 20,
		AcceptCharset = 21,
		AcceptEncoding = 22,
		AcceptLanguage = 23,
		Authorization = 24,
		Cookie = 25,
		Expect = 26,
		From = 27,
		Host = 28,
		IfMatch = 29,
		IfModifiedSince = 30,
		IfNoneMatch = 31,
		IfRange = 32,
		IfUnmodifiedSince = 33,
		MaxForwards = 34,
		ProxyAuthorization = 35,
		Referer = 36,
		Range = 37,
		Te = 38,
		Translate = 39,
		UserAgent = 40
	}

	public interface IAuthenticationModule // TypeDefIndex: 45679
	{
		// Properties
		string AuthenticationType { get; }
	
		// Methods
		Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);
		Authorization PreAuthenticate(WebRequest request, ICredentials credentials);
	}

	public interface ICertificatePolicy // TypeDefIndex: 45680
	{
		// Methods
		bool CheckValidationResult(ServicePoint srvPoint, System.Security.Cryptography.X509Certificates.X509Certificate certificate, WebRequest request, int certificateProblem);
	}

	public interface ICredentials // TypeDefIndex: 45681
	{
		// Methods
		NetworkCredential GetCredential(System.Uri uri, string authType);
	}

	public class IPHostEntry // TypeDefIndex: 45682
	{
		// Fields
		private string hostName; // 0x10
		private string[] aliases; // 0x18
		private IPAddress[] addressList; // 0x20
		internal bool isTrustedHost; // 0x28
	
		// Properties
		public string HostName { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string[] Aliases { set {} } // 0x00000001822C3A90-0x00000001822C3AA0
		public IPAddress[] AddressList { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Constructors
		public IPHostEntry() {} // 0x0000000183D75F20-0x0000000183D75F30
	}

	public interface IWebRequestCreate // TypeDefIndex: 45683
	{
		// Methods
		WebRequest Create(System.Uri uri);
	}

	internal class InternalException : SystemException // TypeDefIndex: 45684
	{
		// Constructors
		internal InternalException() {} // 0x0000000189166FFC-0x0000000189167094
	}

	internal static class NclUtilities // TypeDefIndex: 45685
	{
		// Fields
		private static IPAddress[] _LocalAddresses; // 0x00
		private static object _LocalAddressesLock; // 0x08
		internal static string _LocalDomainName; // 0x10
	
		// Properties
		internal static IPAddress[] LocalAddresses { get; } // 0x0000000189A6334C-0x0000000189A6381C 
		private static object LocalAddressesLock { get; } // 0x0000000189A632BC-0x0000000189A6334C 
	
		// Methods
		internal static bool IsFatal(Exception exception) => default; // 0x0000000189A63234-0x0000000189A632BC
		internal static bool IsAddressLocal(IPAddress ipAddress) => default; // 0x0000000189A631C4-0x0000000189A63234
		private static IPHostEntry GetLocalHost() => default; // 0x0000000189A631A8-0x0000000189A631C4
	}

	internal static class ValidationHelper // TypeDefIndex: 45686
	{
		// Fields
		public static string[] EmptyArray; // 0x00
		internal static readonly char[] InvalidMethodChars; // 0x08
		internal static readonly char[] InvalidParamChars; // 0x10
	
		// Constructors
		static ValidationHelper() {} // 0x0000000189A66860-0x0000000189A66988
	
		// Methods
		public static string MakeStringNull(string stringValue) => default; // 0x0000000189A6683C-0x0000000189A6684C
		public static bool IsBlankString(string stringValue) => default; // 0x0000000189A6682C-0x0000000189A6683C
		public static bool ValidateTcpPort(int port) => default; // 0x0000000189A6684C-0x0000000189A66860
	}

	internal static class ExceptionHelper // TypeDefIndex: 45687
	{
		// Properties
		internal static NotImplementedException MethodNotImplementedException { get; } // 0x0000000189A54598-0x0000000189A54608 
		internal static NotImplementedException PropertyNotImplementedException { get; } // 0x0000000189A54608-0x0000000189A54678 
		internal static WebException TimeoutException { get; } // 0x0000000189A5476C-0x0000000189A547D0 
		internal static NotSupportedException PropertyNotSupportedException { get; } // 0x0000000189A54678-0x0000000189A546E8 
		internal static WebException RequestAbortedException { get; } // 0x0000000189A546E8-0x0000000189A5476C 
	}

	internal class WebRequestPrefixElement // TypeDefIndex: 45688
	{
		// Fields
		public string Prefix; // 0x10
		internal IWebRequestCreate creator; // 0x18
		internal System.Type creatorType; // 0x20
	
		// Properties
		public IWebRequestCreate Creator { get => default; set {} } // 0x0000000189A695E4-0x0000000189A697C8 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public WebRequestPrefixElement() {} // Dummy constructor
		public WebRequestPrefixElement(string P, IWebRequestCreate C) {} // 0x0000000182676770-0x00000001826767A0
	}

	public delegate void HttpContinueDelegate(int StatusCode, WebHeaderCollection httpHeaders); // TypeDefIndex: 45689; 0x0000000182065C10-0x0000000182065C20

	internal class KnownHttpVerb // TypeDefIndex: 45690
	{
		// Fields
		internal string Name; // 0x10
		internal bool RequireContentBody; // 0x18
		internal bool ContentBodyNotAllowed; // 0x19
		internal bool ConnectRequest; // 0x1A
		internal bool ExpectNoContentResponse; // 0x1B
		private static ListDictionary NamedHeaders; // 0x00
		internal static KnownHttpVerb Get; // 0x08
		internal static KnownHttpVerb Connect; // 0x10
		internal static KnownHttpVerb Head; // 0x18
		internal static KnownHttpVerb Put; // 0x20
		internal static KnownHttpVerb Post; // 0x28
		internal static KnownHttpVerb MkCol; // 0x30
	
		// Constructors
		public KnownHttpVerb() {} // Dummy constructor
		internal KnownHttpVerb(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse) {} // 0x0000000189A62694-0x0000000189A626CC
		static KnownHttpVerb() {} // 0x0000000189A62200-0x0000000189A62694
	
		// Methods
		public static KnownHttpVerb Parse(string name) => default; // 0x0000000189A62148-0x0000000189A62200
	}

	internal enum TriState // TypeDefIndex: 45691
	{
		Unspecified = -1,
		False = 0,
		True = 1
	}

	public class NetworkCredential : ICredentials // TypeDefIndex: 45692
	{
		// Fields
		private string m_domain; // 0x10
		private string m_userName; // 0x18
		private SecureString m_password; // 0x20
	
		// Properties
		public string UserName { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000189A63BCC-0x0000000189A63C28
		public string Password { get => default; set {} } // 0x0000000189A63A84-0x0000000189A63A90 0x0000000189A63BA4-0x0000000189A63BCC
		public string Domain { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x0000000189A63B48-0x0000000189A63BA4
	
		// Constructors
		public NetworkCredential() {} // Dummy constructor
		public NetworkCredential(string userName, string password) {} // 0x0000000189A63ADC-0x0000000189A63B48
		public NetworkCredential(string userName, string password, string domain) {} // 0x0000000189A63A90-0x0000000189A63ADC
	
		// Methods
		internal string InternalGetUserName() => default; // 0x0000000181041090-0x00000001810410A0
		internal string InternalGetPassword() => default; // 0x0000000189A63A84-0x0000000189A63A90
		internal string InternalGetDomain() => default; // 0x00000001820B7B20-0x00000001820B7B30
		public NetworkCredential GetCredential(System.Uri uri, string authType) => default; // 0x000000018339AE90-0x000000018339AEA0
	}

	[Serializable]
	public class ProtocolViolationException : InvalidOperationException, ISerializable // TypeDefIndex: 45693
	{
		// Constructors
		public ProtocolViolationException() {} // 0x0000000189A6409C-0x0000000189A640A4
		public ProtocolViolationException(string message) {} // 0x0000000182944300-0x0000000182944320
		protected ProtocolViolationException(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x00000001891672B8-0x00000001891672D8
	
		// Methods
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A2E2D0-0x0000000189A2E2F0
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A2E2D0-0x0000000189A2E2F0
	}

	public class SocketAddress // TypeDefIndex: 45694
	{
		// Fields
		internal int m_Size; // 0x10
		internal byte[] m_Buffer; // 0x18
		private bool m_changed; // 0x20
		private int m_hash; // 0x24
	
		// Properties
		public AddressFamily Family { get => default; } // 0x0000000189A64884-0x0000000189A648BC 
		public int Size { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
		public byte this[int offset] { get => default; } // 0x0000000189A648BC-0x0000000189A64930 
	
		// Constructors
		public SocketAddress() {} // Dummy constructor
		public SocketAddress(AddressFamily family, int size) {} // 0x0000000182941D10-0x0000000182941DC0
		internal SocketAddress(IPAddress ipAddress) {} // 0x0000000182940DD0-0x0000000182940F60
		internal SocketAddress(IPAddress ipaddress, int port) {} // 0x0000000182940A10-0x0000000182940A70
	
		// Methods
		internal IPAddress GetIPAddress() => default; // 0x0000000189A643D0-0x0000000189A645F0
		internal IPEndPoint GetIPEndPoint() => default; // 0x0000000189A645F0-0x0000000189A64694
		public override bool Equals(object comparand) => default; // 0x0000000189A64220-0x0000000189A642C0
		public override int GetHashCode() => default; // 0x0000000189A642C0-0x0000000189A643D0
		public override string ToString() => default; // 0x0000000189A64694-0x0000000189A64884
	}

	public abstract class TransportContext // TypeDefIndex: 45695
	{
		// Constructors
		protected TransportContext() {} // Dummy constructor
	}

	[Serializable]
	public class WebException : InvalidOperationException, ISerializable // TypeDefIndex: 45696
	{
		// Fields
		private WebExceptionStatus m_Status; // 0x90
		private WebResponse m_Response; // 0x98
		[NonSerialized]
		private WebExceptionInternalStatus m_InternalStatus; // 0xA0
	
		// Properties
		public WebExceptionStatus Status { get => default; } // 0x0000000183D4FB60-0x0000000183D4FB70 
		public WebResponse Response { get => default; } // 0x00000001811AC510-0x00000001811AC520 
	
		// Constructors
		public WebException() {} // 0x0000000189A66BA0-0x0000000189A66BB4
		public WebException(string message) {} // 0x0000000189A66E60-0x0000000189A66E78
		public WebException(string message, Exception innerException) {} // 0x0000000189A66C5C-0x0000000189A66C70
		public WebException(string message, WebExceptionStatus status) {} // 0x0000000189A66BB4-0x0000000189A66BD4
		internal WebException(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) {} // 0x0000000189A66C00-0x0000000189A66C28
		public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response) {} // 0x0000000189A66C70-0x0000000189A66C9C
		internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) {} // 0x0000000189A66C9C-0x0000000189A66D78
		internal WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) {} // 0x0000000189A66C28-0x0000000189A66C5C
		internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) {} // 0x0000000189A66D78-0x0000000189A66E60
		protected WebException(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A66BD4-0x0000000189A66C00
	
		// Methods
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A66B74-0x0000000189A66BA0
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A2E2D0-0x0000000189A2E2F0
	}

	internal enum WebExceptionInternalStatus // TypeDefIndex: 45697
	{
		RequestFatal = 0,
		ServicePointFatal = 1,
		Recoverable = 2,
		Isolated = 3
	}

	public enum WebExceptionStatus // TypeDefIndex: 45698
	{
		Success = 0,
		NameResolutionFailure = 1,
		ConnectFailure = 2,
		ReceiveFailure = 3,
		SendFailure = 4,
		PipelineFailure = 5,
		RequestCanceled = 6,
		ProtocolError = 7,
		ConnectionClosed = 8,
		TrustFailure = 9,
		SecureChannelFailure = 10,
		ServerProtocolViolation = 11,
		KeepAliveFailure = 12,
		Pending = 13,
		Timeout = 14,
		ProxyNameResolutionFailure = 15,
		UnknownError = 16,
		MessageLengthLimitExceeded = 17,
		CacheEntryNotFound = 18,
		RequestProhibitedByCachePolicy = 19,
		RequestProhibitedByProxy = 20
	}

	internal static class WebExceptionMapping // TypeDefIndex: 45699
	{
		// Fields
		private static readonly string[] s_Mapping; // 0x00
	
		// Constructors
		static WebExceptionMapping() {} // 0x0000000189A66B0C-0x0000000189A66B74
	
		// Methods
		internal static string GetWebStatusString(WebExceptionStatus status) => default; // 0x0000000189A66988-0x0000000189A66B0C
	}

	internal enum WebHeaderCollectionType : ushort // TypeDefIndex: 45700
	{
		Unknown = 0,
		WebRequest = 1,
		WebResponse = 2,
		HttpWebRequest = 3,
		HttpWebResponse = 4,
		HttpListenerRequest = 5,
		HttpListenerResponse = 6,
		FtpWebRequest = 7,
		FtpWebResponse = 8,
		FileWebRequest = 9,
		FileWebResponse = 10
	}

	[Serializable]
	[ComVisible(true)]
	[DefaultMember("Item")]
	public class WebHeaderCollection : NameValueCollection, ISerializable // TypeDefIndex: 45702
	{
		// Fields
		private const int ApproxAveHeaderLineSize = 30; // Metadata: 0x01FBA3B2
		private const int ApproxHighAvgNumHeaders = 16; // Metadata: 0x01FBA3B3
		private static readonly HeaderInfoTable HInfo; // 0x00
		private string[] m_CommonHeaders; // 0x68
		private int m_NumCommonHeaders; // 0x70
		private static readonly string[] s_CommonHeaderNames; // 0x08
		private static readonly sbyte[] s_CommonHeaderHints; // 0x10
		private const int c_AcceptRanges = 0; // Metadata: 0x01FBA3B4
		private const int c_ContentLength = 1; // Metadata: 0x01FBA3B5
		private const int c_CacheControl = 2; // Metadata: 0x01FBA3B6
		private const int c_ContentType = 3; // Metadata: 0x01FBA3B7
		private const int c_Date = 4; // Metadata: 0x01FBA3B8
		private const int c_Expires = 5; // Metadata: 0x01FBA3B9
		private const int c_ETag = 6; // Metadata: 0x01FBA3BA
		private const int c_LastModified = 7; // Metadata: 0x01FBA3BB
		private const int c_Location = 8; // Metadata: 0x01FBA3BC
		private const int c_ProxyAuthenticate = 9; // Metadata: 0x01FBA3BD
		private const int c_P3P = 10; // Metadata: 0x01FBA3BE
		private const int c_SetCookie2 = 11; // Metadata: 0x01FBA3BF
		private const int c_SetCookie = 12; // Metadata: 0x01FBA3C0
		private const int c_Server = 13; // Metadata: 0x01FBA3C1
		private const int c_Via = 14; // Metadata: 0x01FBA3C2
		private const int c_WwwAuthenticate = 15; // Metadata: 0x01FBA3C3
		private const int c_XAspNetVersion = 16; // Metadata: 0x01FBA3C4
		private const int c_XPoweredBy = 17; // Metadata: 0x01FBA3C5
		private NameValueCollection m_InnerCollection; // 0x78
		private WebHeaderCollectionType m_Type; // 0x80
		private static readonly char[] HttpTrimCharacters; // 0x18
		private static RfcChar[] RfcCharMap; // 0x20
	
		// Properties
		private NameValueCollection InnerCollection { get => default; } // 0x0000000189A69538-0x0000000189A695E4 
		private bool AllowHttpRequestHeader { get => default; } // 0x0000000189A694D4-0x0000000189A6950C 
		public override int Count { get => default; } // 0x0000000189A6950C-0x0000000189A69538 
		public override string[] AllKeys { get => default; } // 0x0000000189A6949C-0x0000000189A694D4 
	
		// Nested types
		private enum RfcChar : byte // TypeDefIndex: 45701
		{
			High = 0,
			Reg = 1,
			Ctl = 2,
			CR = 3,
			LF = 4,
			WS = 5,
			Colon = 6,
			Delim = 7
		}
	
		// Constructors
		public WebHeaderCollection() {} // 0x0000000189A6937C-0x0000000189A693D0
		internal WebHeaderCollection(WebHeaderCollectionType type) {} // 0x0000000189A693D0-0x0000000189A6949C
		protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A691D0-0x0000000189A6937C
		static WebHeaderCollection() {} // 0x0000000189A68D74-0x0000000189A691D0
	
		// Methods
		private void NormalizeCommonHeaders() {} // 0x0000000189A68340-0x0000000189A6843C
		internal static bool AllowMultiValues(string name) => default; // 0x0000000189A67370-0x0000000189A67400
		public void Remove(HttpRequestHeader header) {} // 0x0000000189A6848C-0x0000000189A6854C
		internal void AddInternal(string name, string value) {} // 0x0000000189A66E78-0x0000000189A66ED8
		internal void ChangeInternal(string name, string value) {} // 0x0000000189A67400-0x0000000189A67460
		internal void RemoveInternal(string name) {} // 0x0000000189A6843C-0x0000000189A6848C
		internal static string CheckBadChars(string name, bool isHeaderValue) => default; // 0x0000000189A67460-0x0000000189A6796C
		internal static bool ContainsNonAsciiChars(string token) => default; // 0x0000000189A6796C-0x0000000189A679C8
		internal void ThrowOnRestrictedHeader(string headerName) {} // 0x0000000189A68AE8-0x0000000189A68D24
		public override void Add(string name, string value) {} // 0x0000000189A66ED8-0x0000000189A67098
		public void Add(string header) {} // 0x0000000189A67098-0x0000000189A67370
		public override void Set(string name, string value) {} // 0x0000000189A68884-0x0000000189A68ABC
		internal void SetInternal(string name, string value) {} // 0x0000000189A68658-0x0000000189A68884
		public override void Remove(string name) {} // 0x0000000189A6854C-0x0000000189A68658
		public override string[] GetValues(string header) => default; // 0x0000000189A67E08-0x0000000189A67FD4
		public override string ToString() => default; // 0x0000000189A68D24-0x0000000189A68D74
		internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) => default; // 0x0000000189A679C8-0x0000000189A67C04
		public override void OnDeserialization(object sender) {} // 0x000000018350B670-0x000000018350B680
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A67CC4-0x0000000189A67E08
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A68ABC-0x0000000189A68AE8
		public override string Get(string name) => default; // 0x0000000189A68014-0x0000000189A682F8
		public override IEnumerator GetEnumerator() => default; // 0x0000000189A67C04-0x0000000189A67C7C
		public override string Get(int index) => default; // 0x0000000189A682F8-0x0000000189A68340
		public override string[] GetValues(int index) => default; // 0x0000000189A67FD4-0x0000000189A68014
		public override string GetKey(int index) => default; // 0x0000000189A67C7C-0x0000000189A67CC4
	}

	internal class CaseInsensitiveAscii : IEqualityComparer, System.Collections.IComparer // TypeDefIndex: 45703
	{
		// Fields
		internal static readonly CaseInsensitiveAscii StaticInstance; // 0x00
		internal static readonly byte[] AsciiToLower; // 0x08
	
		// Constructors
		public CaseInsensitiveAscii() {} // 0x000000018350B670-0x000000018350B680
		static CaseInsensitiveAscii() {} // 0x0000000189A5266C-0x0000000189A52738
	
		// Methods
		public int GetHashCode(object myObject) => default; // 0x0000000189A52568-0x0000000189A5266C
		public int Compare(object firstObject, object secondObject) => default; // 0x0000000189A521C4-0x0000000189A52324
		private int FastGetHashCode(string myString) => default; // 0x0000000189A52484-0x0000000189A52568
		public new bool Equals(object firstObject, object secondObject) => default; // 0x0000000189A52324-0x0000000189A52484
	}

	[Serializable]
	public abstract class WebRequest : MarshalByRefObject, ISerializable // TypeDefIndex: 45707
	{
		// Fields
		private static ArrayList s_PrefixList; // 0x00
		private static object s_InternalSyncObject; // 0x08
		private static TimerThread.Queue s_DefaultTimerQueue; // 0x10
		private AuthenticationLevel m_AuthenticationLevel; // 0x18
		private TokenImpersonationLevel m_ImpersonationLevel; // 0x1C
		private RequestCachePolicy m_CachePolicy; // 0x20
		private RequestCacheProtocol m_CacheProtocol; // 0x28
		private RequestCacheBinding m_CacheBinding; // 0x30
		private static DesignerWebRequestCreate webRequestCreate; // 0x18
		private static IWebProxy s_DefaultWebProxy; // 0x20
		private static bool s_DefaultWebProxyInitialized; // 0x28
	
		// Properties
		private static object InternalSyncObject { get; } // 0x0000000189A6A8F0-0x0000000189A6A9AC 
		internal static ArrayList PrefixList { get; } // 0x0000000189A6A9D4-0x0000000189A6AB88 
		public static RequestCachePolicy DefaultCachePolicy { get; } // 0x0000000189A6A674-0x0000000189A6A6E0 
		public virtual RequestCachePolicy CachePolicy { get; set; } // 0x0000000189A6AC28-0x0000000189A6AC30
		public virtual string Method { get; set; } // 0x0000000189A6A9AC-0x0000000189A6A9D4 0x0000000189A6ACA8-0x0000000189A6ACD0
		public virtual System.Uri RequestUri { get; } // 0x0000000189A6ABB0-0x0000000189A6ABD8 
		public virtual string ConnectionGroupName { get; set; } // 0x0000000189A6AC30-0x0000000189A6AC58
		public virtual WebHeaderCollection Headers { get; } // 0x0000000189A6A6E0-0x0000000189A6A708 
		public virtual long ContentLength { get; set; } // 0x0000000189A6A624-0x0000000189A6A64C 0x0000000189A6AC58-0x0000000189A6AC80
		public virtual ICredentials Credentials { get; set; } // 0x0000000189A6A64C-0x0000000189A6A674 0x0000000189A6AC80-0x0000000189A6ACA8
		public virtual bool UseDefaultCredentials { get; } // 0x0000000189A6AC00-0x0000000189A6AC28 
		public virtual IWebProxy Proxy { get; set; } // 0x0000000189A6AB88-0x0000000189A6ABB0 0x0000000189A6ACF8-0x0000000189A6AD20
		public virtual bool PreAuthenticate { get; set; } // 0x0000000189A6ACD0-0x0000000189A6ACF8
		public virtual int Timeout { get; set; } // 0x0000000189A6ABD8-0x0000000189A6AC00 0x0000000189A6AD20-0x0000000189A6AD48
		internal RequestCacheProtocol CacheProtocol { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		internal static IWebProxy InternalDefaultWebProxy { get; } // 0x0000000189A6A708-0x0000000189A6A8F0 
	
		// Nested types
		internal class DesignerWebRequestCreate : IWebRequestCreate // TypeDefIndex: 45704
		{
			// Constructors
			public DesignerWebRequestCreate() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public WebRequest Create(System.Uri uri) => default; // 0x0000000189A5448C-0x0000000189A544D8
		}
	
		// Constructors
		protected WebRequest() {} // 0x0000000183D75F30-0x0000000183D75F40
		protected WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x000000018350B670-0x000000018350B680
		static WebRequest() {} // 0x0000000189A6A564-0x0000000189A6A624
	
		// Methods
		private static WebRequest Create(System.Uri requestUri, bool useUriBase) => default; // 0x0000000189A69840-0x0000000189A69A00
		public static WebRequest Create(string requestUriString) => default; // 0x0000000189A69AC0-0x0000000189A69BA0
		public static WebRequest Create(System.Uri requestUri) => default; // 0x0000000189A69A00-0x0000000189A69AC0
		private static ArrayList PopulatePrefixList() => default; // 0x0000000189A6A0E4-0x0000000189A6A2E0
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A6A320-0x0000000189A6A34C
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x000000018350B670-0x000000018350B680
		private void InternalSetCachePolicy(RequestCachePolicy policy) {} // 0x0000000189A6A058-0x0000000189A6A0E4
		public virtual WebResponse GetResponse() => default; // 0x0000000189A6A030-0x0000000189A6A058
		public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) => default; // 0x0000000189A69818-0x0000000189A69840
		public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) => default; // 0x0000000189A69BC8-0x0000000189A69BF0
		public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) => default; // 0x0000000189A697F0-0x0000000189A69818
		public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) => default; // 0x0000000189A69BA0-0x0000000189A69BC8
		public virtual Task<Stream> GetRequestStreamAsync() => default; // 0x0000000189A69BF0-0x0000000189A69E10
		public virtual Task<WebResponse> GetResponseAsync() => default; // 0x0000000189A69E10-0x0000000189A6A030
		private WindowsIdentity SafeCaptureIdenity() => default; // 0x0000000189A6A2E0-0x0000000189A6A320
		public virtual void Abort() {} // 0x0000000189A697C8-0x0000000189A697F0
	}

	[Serializable]
	public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable // TypeDefIndex: 45708
	{
		// Fields
		private bool m_IsFromCache; // 0x18
	
		// Properties
		public virtual bool IsFromCache { get; } // 0x0000000181002A50-0x0000000181002A60 
		public virtual System.Uri ResponseUri { get; } // 0x0000000189A6AE98-0x0000000189A6B20C 
		public virtual WebHeaderCollection Headers { get; } // 0x0000000189A6AE70-0x0000000189A6AE98 
	
		// Constructors
		protected WebResponse() {} // 0x000000018350B670-0x000000018350B680
		protected WebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A6AE44-0x0000000189A6AE70
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x000000018350B670-0x000000018350B680
		public virtual void Close() {} // 0x000000018350B670-0x000000018350B680
		public void Dispose() {} // 0x0000000189A6ADCC-0x0000000189A6AE1C
		protected virtual void Dispose(bool disposing) {} // 0x0000000189A6AD48-0x0000000189A6ADCC
		public virtual Stream GetResponseStream() => default; // 0x0000000189A6AE1C-0x0000000189A6AE44
	}

	internal class BufferOffsetSize // TypeDefIndex: 45709
	{
		// Fields
		internal byte[] Buffer; // 0x10
		internal int Offset; // 0x18
		internal int Size; // 0x1C
	
		// Constructors
		public BufferOffsetSize() {} // Dummy constructor
		internal BufferOffsetSize(byte[] buffer, int offset, int size, bool copyBuffer) {} // 0x0000000189A5211C-0x0000000189A521C4
		internal BufferOffsetSize(byte[] buffer, bool copyBuffer) {} // 0x0000000189A520EC-0x0000000189A5211C
	}

	internal delegate string[] HeaderParser(string value); // TypeDefIndex: 45710; 0x000000018102B410-0x000000018102B420

	internal class HeaderInfo // TypeDefIndex: 45711
	{
		// Fields
		internal readonly bool IsRequestRestricted; // 0x10
		internal readonly bool IsResponseRestricted; // 0x11
		internal readonly HeaderParser Parser; // 0x18
		internal readonly string HeaderName; // 0x20
		internal readonly bool AllowMultiValues; // 0x28
	
		// Constructors
		public HeaderInfo() {} // Dummy constructor
		internal HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) {} // 0x0000000189A62104-0x0000000189A62148
	}

	internal class HeaderInfoTable // TypeDefIndex: 45712
	{
		// Fields
		private static Hashtable HeaderHashTable; // 0x00
		private static HeaderInfo UnknownHeaderInfo; // 0x08
		private static HeaderParser SingleParser; // 0x10
		private static HeaderParser MultiParser; // 0x18
	
		// Properties
		internal HeaderInfo this[string name] { get => default; } // 0x0000000189A62064-0x0000000189A62104 
	
		// Constructors
		static HeaderInfoTable() {} // 0x0000000189A605E8-0x0000000189A62064
		public HeaderInfoTable() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private static string[] ParseSingleValue(string value) => default; // 0x0000000189A60584-0x0000000189A605E8
		private static string[] ParseMultiValue(string value) => default; // 0x0000000189A603B4-0x0000000189A60584
	}

	[Flags]
	internal enum CloseExState // TypeDefIndex: 45713
	{
		Normal = 0,
		Abort = 1,
		Silent = 2
	}

	internal interface ICloseEx // TypeDefIndex: 45714
	{
		// Methods
		void CloseEx(CloseExState closeState);
	}

	internal class LazyAsyncResult : IAsyncResult // TypeDefIndex: 45716
	{
		// Fields
		[ThreadStatic]
		private static ThreadContext t_ThreadContext; // 0x80000000
		private object m_AsyncObject; // 0x10
		private object m_AsyncState; // 0x18
		private AsyncCallback m_AsyncCallback; // 0x20
		private object m_Result; // 0x28
		private int m_IntCompleted; // 0x30
		private bool m_EndCalled; // 0x34
		private bool m_UserEvent; // 0x35
		private object m_Event; // 0x38
	
		// Properties
		private static ThreadContext CurrentThreadContext { get => default; } // 0x0000000189A630DC-0x0000000189A63178 
		internal object AsyncObject { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public object AsyncState { get => default; } // 0x0000000181041090-0x00000001810410A0 
		protected AsyncCallback AsyncCallback { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public WaitHandle AsyncWaitHandle { get => default; } // 0x0000000189A6303C-0x0000000189A630BC 
		public bool CompletedSynchronously { get => default; } // 0x0000000189A630BC-0x0000000189A630DC 
		public bool IsCompleted { get => default; } // 0x0000000189A63184-0x0000000189A631A8 
		internal bool InternalPeekCompleted { get => default; } // 0x0000000189A63178-0x0000000189A63184 
		internal bool EndCalled { get => default; set {} } // 0x0000000183D4F570-0x0000000183D4F580 0x0000000183D4F590-0x0000000183D4F5A0
	
		// Nested types
		private class ThreadContext // TypeDefIndex: 45715
		{
			// Fields
			internal int m_NestedIOCount; // 0x10
	
			// Constructors
			public ThreadContext() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public LazyAsyncResult() {} // Dummy constructor
		internal LazyAsyncResult(object myObject, object myState, AsyncCallback myCallBack) {} // 0x0000000189A62F98-0x0000000189A6303C
	
		// Methods
		private bool LazilyCreateEvent(out ManualResetEvent waitHandle) {
			waitHandle = default;
			return default;
		} // 0x0000000189A62958-0x0000000189A62B04
		protected void ProtectedInvokeCallback(object result, IntPtr userToken) {} // 0x0000000189A62B04-0x0000000189A62CC0
		internal void InvokeCallback(object result) {} // 0x0000000189A6294C-0x0000000189A62958
		internal void InvokeCallback() {} // 0x0000000189A6293C-0x0000000189A6294C
		protected virtual void Complete(IntPtr userToken) {} // 0x0000000189A626CC-0x0000000189A62930
		private void WorkerThreadComplete(object state) {} // 0x0000000189A62F14-0x0000000189A62F98
		protected virtual void Cleanup() {} // 0x000000018350B670-0x000000018350B680
		internal object InternalWaitForCompletion() => default; // 0x0000000189A62930-0x0000000189A6293C
		private object WaitForCompletion(bool snap) => default; // 0x0000000189A62CC0-0x0000000189A62F14
	}

	internal class NetRes // TypeDefIndex: 45717
	{
		// Constructors
		public NetRes() {} // Dummy constructor
	
		// Methods
		public static string GetWebStatusString(string Res, WebExceptionStatus Status) => default; // 0x0000000189A63A04-0x0000000189A63A84
		public static string GetWebStatusString(WebExceptionStatus Status) => default; // 0x0000000189A639BC-0x0000000189A63A04
		public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription) => default; // 0x0000000189A6381C-0x0000000189A639BC
	}

	internal static class TimerThread // TypeDefIndex: 45726
	{
		// Fields
		private static LinkedList<WeakReference> s_Queues; // 0x00
		private static LinkedList<WeakReference> s_NewQueues; // 0x08
		private static int s_ThreadState; // 0x10
		private static AutoResetEvent s_ThreadReadyEvent; // 0x18
		private static ManualResetEvent s_ThreadShutdownEvent; // 0x20
		private static WaitHandle[] s_ThreadEvents; // 0x28
		private static int s_CacheScanIteration; // 0x30
		private static Hashtable s_QueuesCache; // 0x38
	
		// Nested types
		internal abstract class Queue // TypeDefIndex: 45718
		{
			// Fields
			private readonly int m_DurationMilliseconds; // 0x10
	
			// Properties
			internal int Duration { get; } // 0x0000000183D4E340-0x0000000183D4E350 
	
			// Constructors
			protected Queue() {} // Dummy constructor
			internal Queue(int durationMilliseconds) {} // 0x00000001810410F0-0x0000000181041100
	
			// Methods
			internal abstract System.Net.TimerThread.Timer CreateTimer(Callback callback, object context);
		}
	
		internal abstract class Timer : IDisposable // TypeDefIndex: 45719
		{
			// Fields
			private readonly int m_StartTimeMilliseconds; // 0x10
			private readonly int m_DurationMilliseconds; // 0x14
	
			// Properties
			internal int StartTime { get; } // 0x0000000183D4E340-0x0000000183D4E350 
			internal int Expiration { get; } // 0x0000000183D75F80-0x0000000183D75F90 
			internal abstract bool HasExpired { get; }
	
			// Constructors
			protected Timer() {} // Dummy constructor
			internal Timer(int durationMilliseconds) {} // 0x0000000189A7FD5C-0x0000000189A7FD78
	
			// Methods
			internal abstract bool Cancel();
			public void Dispose() {} // 0x0000000189A7FD4C-0x0000000189A7FD5C
		}
	
		internal delegate void Callback(System.Net.TimerThread.Timer timer, int timeNoticed, object context); // TypeDefIndex: 45720; 0x00000001811360D0-0x00000001811360F0
	
		private class TimerQueue : System.Net.TimerThread.Queue // TypeDefIndex: 45721
		{
			// Fields
			private IntPtr m_ThisHandle; // 0x18
			private readonly TimerNode m_Timers; // 0x20
	
			// Constructors
			public TimerQueue() {} // Dummy constructor
			internal TimerQueue(int durationMilliseconds) {} // 0x0000000189A7FCB4-0x0000000189A7FD4C
	
			// Methods
			internal override System.Net.TimerThread.Timer CreateTimer(Callback callback, object context) => default; // 0x0000000189A7F7E8-0x0000000189A7FB28
			internal bool Fire(out int nextExpiration) {
				nextExpiration = default;
				return default;
			} // 0x0000000189A7FB28-0x0000000189A7FCB4
		}
	
		private class InfiniteTimerQueue : System.Net.TimerThread.Queue // TypeDefIndex: 45722
		{
			// Constructors
			internal InfiniteTimerQueue() {} // 0x0000000183D51990-0x0000000183D519A0
	
			// Methods
			internal override System.Net.TimerThread.Timer CreateTimer(Callback callback, object context) => default; // 0x0000000189A7E59C-0x0000000189A7E5F0
		}
	
		private class TimerNode : System.Net.TimerThread.Timer // TypeDefIndex: 45724
		{
			// Fields
			private TimerState m_TimerState; // 0x18
			private Callback m_Callback; // 0x20
			private object m_Context; // 0x28
			private object m_QueueLock; // 0x30
			private TimerNode next; // 0x38
			private TimerNode prev; // 0x40
	
			// Properties
			internal override bool HasExpired { get => default; } // 0x00000001886E1564-0x00000001886E156C 
			internal TimerNode Next { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
			internal TimerNode Prev { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
	
			// Nested types
			private enum TimerState // TypeDefIndex: 45723
			{
				Ready = 0,
				Fired = 1,
				Cancelled = 2,
				Sentinel = 3
			}
	
			// Constructors
			internal TimerNode(Callback callback, object context, int durationMilliseconds, object queueLock) {} // 0x0000000189A7F780-0x0000000189A7F7E8
			internal TimerNode() {} // 0x0000000189A7F758-0x0000000189A7F780
	
			// Methods
			internal override bool Cancel() => default; // 0x0000000189A7F060-0x0000000189A7F318
			internal bool Fire() => default; // 0x0000000189A7F318-0x0000000189A7F758
		}
	
		private class InfiniteTimer : System.Net.TimerThread.Timer // TypeDefIndex: 45725
		{
			// Fields
			private int cancelled; // 0x18
	
			// Properties
			internal override bool HasExpired { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
			// Constructors
			internal InfiniteTimer() {} // 0x0000000189A7E600-0x0000000189A7E620
	
			// Methods
			internal override bool Cancel() => default; // 0x0000000189A7E5F0-0x0000000189A7E600
		}
	
		// Constructors
		static TimerThread() {} // 0x0000000189A65EA0-0x0000000189A6618C
	
		// Methods
		internal static Queue CreateQueue(int durationMilliseconds) => default; // 0x0000000189A649F0-0x0000000189A64C28
		internal static Queue GetOrCreateQueue(int durationMilliseconds) => default; // 0x0000000189A64C28-0x0000000189A6538C
		private static void Prod() {} // 0x0000000189A65450-0x0000000189A65728
		private static void ThreadProc() {} // 0x0000000189A65794-0x0000000189A65EA0
		private static void StopTimerThread() {} // 0x0000000189A65728-0x0000000189A65794
		private static bool IsTickBetween(int start, int end, int comparand) => default; // 0x0000000189A6538C-0x0000000189A653B4
		private static void OnDomainUnload(object sender, EventArgs e) {} // 0x0000000189A653B4-0x0000000189A65450
	}

	internal enum CookieVariant // TypeDefIndex: 45727
	{
		Unknown = 0,
		Plain = 1,
		Rfc2109 = 2,
		Default = 2,
		Rfc2965 = 3
	}

	[Serializable]
	public sealed class Cookie // TypeDefIndex: 45728
	{
		// Fields
		internal static readonly char[] PortSplitDelimiters; // 0x00
		internal static readonly char[] Reserved2Name; // 0x08
		internal static readonly char[] Reserved2Value; // 0x10
		private static System.Net.Comparer staticComparer; // 0x18
		private string m_comment; // 0x10
		private System.Uri m_commentUri; // 0x18
		private CookieVariant m_cookieVariant; // 0x20
		private bool m_discard; // 0x24
		private string m_domain; // 0x28
		private bool m_domain_implicit; // 0x30
		private System.DateTime m_expires; // 0x38
		private string m_name; // 0x40
		private string m_path; // 0x48
		private bool m_path_implicit; // 0x50
		private string m_port; // 0x58
		private bool m_port_implicit; // 0x60
		private int[] m_port_list; // 0x68
		private bool m_secure; // 0x70
		[OptionalField]
		private bool m_httpOnly; // 0x71
		private System.DateTime m_timeStamp; // 0x78
		private string m_value; // 0x80
		private int m_version; // 0x88
		private string m_domainKey; // 0x90
		internal bool IsQuotedVersion; // 0x98
		internal bool IsQuotedDomain; // 0x99
	
		// Properties
		public string Comment { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x0000000189A73ADC-0x0000000189A73B38
		public System.Uri CommentUri { set {} } // 0x00000001822C3A90-0x00000001822C3AA0
		public bool HttpOnly { set {} } // 0x0000000183D51D00-0x0000000183D51D10
		public bool Discard { set {} } // 0x0000000183D4F0A0-0x0000000183D4F0B0
		public string Domain { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000189A73B38-0x0000000189A73BC4
		private string _Domain { get => default; } // 0x0000000189A737FC-0x0000000189A738B4 
		public bool Expired { get => default; } // 0x0000000189A73764-0x0000000189A737FC 
		public System.DateTime Expires { set {} } // 0x0000000183D4EE50-0x0000000183D4EE60
		public string Name { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public string Path { get => default; set {} } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000189A73BC4-0x0000000189A73C30
		private string _Path { get => default; } // 0x0000000189A738B4-0x0000000189A73934 
		internal bool Plain { get => default; } // 0x000000018278BF00-0x000000018278BF10 
		public string Port { set {} } // 0x0000000189A73C30-0x0000000189A740C0
		internal int[] PortList { get => default; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
		private string _Port { get => default; } // 0x0000000189A73934-0x0000000189A739EC 
		public bool Secure { get => default; set {} } // 0x0000000183D4F260-0x0000000183D4F270 0x0000000183D4F290-0x0000000183D4F2A0
		public string Value { get => default; set {} } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x0000000189A740C0-0x0000000189A7412C
		internal CookieVariant Variant { get => default; } // 0x0000000181003B50-0x0000000181003B60 
		internal string DomainKey { get => default; } // 0x0000000189A73750-0x0000000189A73764 
		public int Version { get => default; set {} } // 0x0000000183D4F0B0-0x0000000183D4F0C0 0x0000000189A7412C-0x0000000189A741A8
		private string _Version { get => default; } // 0x0000000189A739EC-0x0000000189A73ADC 
	
		// Constructors
		public Cookie() {} // 0x0000000189A735FC-0x0000000189A73750
		static Cookie() {} // 0x0000000189A73468-0x0000000189A735FC
	
		// Methods
		internal bool InternalSetName(string value) => default; // 0x0000000189A721B4-0x0000000189A7228C
		private static bool IsDomainEqualToHost(string domain, string host) => default; // 0x0000000189A7228C-0x0000000189A722E4
		internal bool VerifySetDefaults(CookieVariant variant, System.Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) => default; // 0x0000000189A72530-0x0000000189A73468
		private static bool DomainCharsTest(string name) => default; // 0x0000000189A71EE4-0x0000000189A71F4C
		internal static System.Collections.IComparer GetComparer() => default; // 0x0000000189A72014-0x0000000189A72064
		public override bool Equals(object comparand) => default; // 0x0000000189A71F4C-0x0000000189A72014
		public override int GetHashCode() => default; // 0x0000000189A72064-0x0000000189A721B4
		public override string ToString() => default; // 0x0000000189A722E4-0x0000000189A72530
	}

	internal enum CookieToken // TypeDefIndex: 45729
	{
		Nothing = 0,
		NameValuePair = 1,
		Attribute = 2,
		EndToken = 3,
		EndCookie = 4,
		End = 5,
		Equals = 6,
		Comment = 7,
		CommentUrl = 8,
		CookieName = 9,
		Discard = 10,
		Domain = 11,
		Expires = 12,
		MaxAge = 13,
		Path = 14,
		Port = 15,
		Secure = 16,
		HttpOnly = 17,
		Unknown = 18,
		Version = 19
	}

	internal class CookieTokenizer // TypeDefIndex: 45731
	{
		// Fields
		private bool m_eofCookie; // 0x10
		private int m_index; // 0x14
		private int m_length; // 0x18
		private string m_name; // 0x20
		private bool m_quoted; // 0x28
		private int m_start; // 0x2C
		private CookieToken m_token; // 0x30
		private int m_tokenLength; // 0x34
		private string m_tokenStream; // 0x38
		private string m_value; // 0x40
		private static RecognizedAttribute[] RecognizedAttributes; // 0x00
		private static RecognizedAttribute[] RecognizedServerAttributes; // 0x08
	
		// Properties
		internal bool EndOfCookie { get => default; set {} } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
		internal bool Eof { get => default; } // 0x0000000189A71ED8-0x0000000189A71EE4 
		internal string Name { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		internal bool Quoted { get => default; set {} } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
		internal CookieToken Token { get => default; set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		internal string Value { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
	
		// Nested types
		private struct RecognizedAttribute // TypeDefIndex: 45730
		{
			// Fields
			private string m_name; // 0x00
			private CookieToken m_token; // 0x08
	
			// Properties
			internal CookieToken Token { get => default; } // 0x0000000183D516F0-0x0000000183D51700 
	
			// Constructors
			internal RecognizedAttribute(string name, CookieToken token) : this() {
				m_name = default;
				m_token = default;
			} // 0x0000000184274600-0x000000018427461C
	
			// Methods
			internal bool IsEqualTo(string value) => default; // 0x0000000189A7EC64-0x0000000189A7EC84
		}
	
		// Constructors
		public CookieTokenizer() {} // Dummy constructor
		internal CookieTokenizer(string tokenStream) {} // 0x0000000189A71EB0-0x0000000189A71ED8
		static CookieTokenizer() {} // 0x0000000189A71968-0x0000000189A71EB0
	
		// Methods
		internal string Extract() => default; // 0x0000000189A71384-0x0000000189A713FC
		internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) => default; // 0x0000000189A713FC-0x0000000189A71638
		internal CookieToken Next(bool first, bool parseResponseCookies) => default; // 0x0000000189A71638-0x0000000189A71768
		internal void Reset() {} // 0x0000000189A71768-0x0000000189A717E4
		internal CookieToken TokenFromName(bool parseResponseCookies) => default; // 0x0000000189A717E4-0x0000000189A71968
	}

	internal class CookieParser // TypeDefIndex: 45732
	{
		// Fields
		private CookieTokenizer m_tokenizer; // 0x10
	
		// Constructors
		public CookieParser() {} // Dummy constructor
		internal CookieParser(string cookieString) {} // 0x0000000189A7130C-0x0000000189A71384
	
		// Methods
		internal Cookie Get() => default; // 0x0000000189A70C44-0x0000000189A7130C
		internal static string CheckQuoted(string value) => default; // 0x0000000189A70BA4-0x0000000189A70C44
	}

	internal class Comparer : System.Collections.IComparer // TypeDefIndex: 45733
	{
		// Constructors
		public Comparer() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		int IComparer.Compare(object ol, object or) => default; // 0x0000000189A6C5FC-0x0000000189A6C6B4
	}

	[Serializable]
	public class CookieCollection : ICollection // TypeDefIndex: 45736
	{
		// Fields
		internal int m_version; // 0x10
		private ArrayList m_list; // 0x18
		private System.DateTime m_TimeStamp; // 0x20
		private bool m_has_other_versions; // 0x28
		[OptionalField]
		private bool m_IsReadOnly; // 0x29
	
		// Properties
		public Cookie this[int index] { get => default; } // 0x0000000189A6D484-0x0000000189A6D56C 
		public int Count { get => default; } // 0x000000018915FBF8-0x000000018915FC1C 
		public bool IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public object SyncRoot { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		internal bool IsOtherVersionSeen { get => default; } // 0x0000000183D4ED50-0x0000000183D4ED60 
	
		// Nested types
		internal enum Stamp // TypeDefIndex: 45734
		{
			Check = 0,
			Set = 1,
			SetToUnused = 2,
			SetToMaxUsed = 3
		}
	
		private class CookieCollectionEnumerator : IEnumerator // TypeDefIndex: 45735
		{
			// Fields
			private CookieCollection m_cookies; // 0x10
			private int m_count; // 0x18
			private int m_index; // 0x1C
			private int m_version; // 0x20
	
			// Properties
			object IEnumerator.Current { get => default; } // 0x0000000189A6C8B4-0x0000000189A6C9A8 
	
			// Constructors
			public CookieCollectionEnumerator() {} // Dummy constructor
			internal CookieCollectionEnumerator(CookieCollection cookies) {} // 0x0000000189A6C9A8-0x0000000189A6C9F4
	
			// Methods
			bool IEnumerator.MoveNext() => default; // 0x0000000189A6C81C-0x0000000189A6C8B4
			void IEnumerator.Reset() {} // 0x0000000183D75DD0-0x0000000183D75DE0
		}
	
		// Constructors
		public CookieCollection() {} // 0x0000000189A6D3EC-0x0000000189A6D484
	
		// Methods
		public void Add(Cookie cookie) {} // 0x0000000189A6C9F4-0x0000000189A6CAA8
		public void Add(CookieCollection cookies) {} // 0x0000000189A6CAA8-0x0000000189A6CCF8
		public void CopyTo(Array array, int index) {} // 0x0000000189A6CCF8-0x0000000189A6CD24
		internal System.DateTime TimeStamp(Stamp how) => default; // 0x0000000189A6D348-0x0000000189A6D3EC
		internal int InternalAdd(Cookie cookie, bool isStrict) => default; // 0x0000000189A6CFC8-0x0000000189A6D324
		internal int IndexOf(Cookie cookie) => default; // 0x0000000189A6CD84-0x0000000189A6CFC8
		internal void RemoveAt(int idx) {} // 0x0000000189A6D324-0x0000000189A6D348
		public IEnumerator GetEnumerator() => default; // 0x0000000189A6CD24-0x0000000189A6CD84
	}

	internal struct HeaderVariantInfo // TypeDefIndex: 45737
	{
		// Fields
		private string m_name; // 0x00
		private CookieVariant m_variant; // 0x08
	
		// Properties
		internal string Name { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
		internal CookieVariant Variant { get => default; } // 0x0000000183D516F0-0x0000000183D51700 
	
		// Constructors
		internal HeaderVariantInfo(string name, CookieVariant variant) : this() {
			m_name = default;
			m_variant = default;
		} // 0x0000000184274600-0x000000018427461C
	}

	[Serializable]
	public class CookieContainer // TypeDefIndex: 45738
	{
		// Fields
		public const int DefaultCookieLimit = 300; // Metadata: 0x01FBA3F2
		public const int DefaultPerDomainCookieLimit = 20; // Metadata: 0x01FBA3F4
		public const int DefaultCookieLengthLimit = 4096; // Metadata: 0x01FBA3F5
		private static readonly HeaderVariantInfo[] HeaderInfo; // 0x00
		private Hashtable m_domainTable; // 0x10
		private int m_maxCookieSize; // 0x18
		private int m_maxCookies; // 0x1C
		private int m_maxCookiesPerDomain; // 0x20
		private int m_count; // 0x24
		private string m_fqdnMyDomain; // 0x28
	
		// Constructors
		public CookieContainer() {} // 0x0000000189A70AA4-0x0000000189A70B9C
		static CookieContainer() {} // 0x0000000189A7099C-0x0000000189A70AA4
	
		// Methods
		private void AddRemoveDomain(string key, PathList value) {} // 0x0000000189A6D56C-0x0000000189A6D698
		internal void Add(Cookie cookie, bool throwOnError) {} // 0x0000000189A6D698-0x0000000189A6DF38
		private bool AgeCookies(string domain) => default; // 0x0000000189A6DF38-0x0000000189A6EE08
		private int ExpireCollection(CookieCollection cc) => default; // 0x0000000189A6FBFC-0x0000000189A6FD24
		internal bool IsLocalDomain(string host) => default; // 0x0000000189A7055C-0x0000000189A707F8
		internal CookieCollection CookieCutter(System.Uri uri, string headerName, string setCookieHeader, bool isThrow) => default; // 0x0000000189A6F504-0x0000000189A6FBFC
		internal CookieCollection InternalGetCookies(System.Uri uri) => default; // 0x0000000189A70250-0x0000000189A7055C
		private void BuildCookieCollectionFromDomainMatches(System.Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie) {} // 0x0000000189A6EE08-0x0000000189A6F504
		private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) {} // 0x0000000189A707F8-0x0000000189A7099C
		public string GetCookieHeader(System.Uri uri) => default; // 0x0000000189A6FD24-0x0000000189A6FDE8
		internal string GetCookieHeader(System.Uri uri, out string optCookie2) {
			optCookie2 = default;
			return default;
		} // 0x0000000189A6FDE8-0x0000000189A70250
	}

	[Serializable]
	internal class PathList // TypeDefIndex: 45740
	{
		// Fields
		private SortedList m_list; // 0x10
	
		// Properties
		public int Count { get => default; } // 0x00000001897D4E24-0x00000001897D4E48 
		public ICollection Values { get => default; } // 0x000000018921D674-0x000000018921D698 
		public object this[string s] { get => default; set {} } // 0x0000000189A7EB64-0x0000000189A7EB88 0x0000000189A7EB88-0x0000000189A7EC64
		public object SyncRoot { get => default; } // 0x000000018920F8D8-0x000000018920F8FC 
	
		// Nested types
		[Serializable]
		private class PathListComparer : System.Collections.IComparer // TypeDefIndex: 45739
		{
			// Fields
			internal static readonly PathListComparer StaticInstance; // 0x00
	
			// Constructors
			public PathListComparer() {} // 0x000000018350B670-0x000000018350B680
			static PathListComparer() {} // 0x0000000189A7E77C-0x0000000189A7E7E0
	
			// Methods
			int IComparer.Compare(object ol, object or) => default; // 0x0000000189A7E620-0x0000000189A7E77C
		}
	
		// Constructors
		public PathList() {} // 0x0000000189A7EABC-0x0000000189A7EB64
	
		// Methods
		public int GetCookiesCount() => default; // 0x0000000189A7E7E0-0x0000000189A7EABC
		public IEnumerator GetEnumerator() => default; // 0x00000001891207A4-0x00000001891207C8
	}

	[Serializable]
	public class CookieException : FormatException, ISerializable // TypeDefIndex: 45741
	{
		// Constructors
		public CookieException() {} // 0x0000000189A2E2F0-0x0000000189A2E2F8
		internal CookieException(string message) {} // 0x00000001839B95D0-0x00000001839B95F0
		internal CookieException(string message, Exception inner) {} // 0x0000000189A70B9C-0x0000000189A70BA4
		protected CookieException(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x00000001891672B8-0x00000001891672D8
	
		// Methods
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A2E2D0-0x0000000189A2E2F0
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A2E2D0-0x0000000189A2E2F0
	}

	[Serializable]
	public class FileWebRequest : WebRequest, ISerializable // TypeDefIndex: 45742
	{
		// Fields
		private static WaitCallback s_GetRequestStreamCallback; // 0x00
		private static WaitCallback s_GetResponseCallback; // 0x08
		private string m_connectionGroupName; // 0x38
		private long m_contentLength; // 0x40
		private ICredentials m_credentials; // 0x48
		private FileAccess m_fileAccess; // 0x50
		private WebHeaderCollection m_headers; // 0x58
		private string m_method; // 0x60
		private bool m_preauthenticate; // 0x68
		private IWebProxy m_proxy; // 0x70
		private ManualResetEvent m_readerEvent; // 0x78
		private bool m_readPending; // 0x80
		private WebResponse m_response; // 0x88
		private Stream m_stream; // 0x90
		private bool m_syncHint; // 0x98
		private int m_timeout; // 0x9C
		private System.Uri m_uri; // 0xA0
		private bool m_writePending; // 0xA8
		private bool m_writing; // 0xA9
		private LazyAsyncResult m_WriteAResult; // 0xB0
		private LazyAsyncResult m_ReadAResult; // 0xB8
		private int m_Aborted; // 0xC0
	
		// Properties
		internal bool Aborted { get => default; } // 0x0000000189A784A8-0x0000000189A784B4 
		public override string ConnectionGroupName { set {} } // 0x000000018388FF30-0x000000018388FF40
		public override long ContentLength { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000189A784DC-0x0000000189A78560
		public override ICredentials Credentials { get => default; set {} } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public override WebHeaderCollection Headers { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		public override string Method { get => default; set {} } // 0x0000000183D4EB00-0x0000000183D4EB10 0x0000000189A78560-0x0000000189A78620
		public override bool PreAuthenticate { set {} } // 0x0000000183D75F40-0x0000000183D75F50
		public override IWebProxy Proxy { get => default; set {} } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		public override int Timeout { get => default; set {} } // 0x0000000183D51960-0x0000000183D51970 0x0000000189A78620-0x0000000189A786A8
		public override System.Uri RequestUri { get => default; } // 0x0000000183D4EA80-0x0000000183D4EA90 
		public override bool UseDefaultCredentials { get => default; } // 0x0000000189A784B4-0x0000000189A784DC 
	
		// Constructors
		public FileWebRequest() {} // Dummy constructor
		internal FileWebRequest(System.Uri uri) {} // 0x0000000189A78074-0x0000000189A781E4
		[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
		protected FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A781E4-0x0000000189A784A8
		static FileWebRequest() {} // 0x0000000189A77F80-0x0000000189A78074
	
		// Methods
		new void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A6A320-0x0000000189A6A34C
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A77384-0x0000000189A775B0
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) => default; // 0x0000000189A76748-0x0000000189A76B48
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) => default; // 0x0000000189A76B48-0x0000000189A76E6C
		private bool CanGetRequestStream() => default; // 0x0000000189A76E6C-0x0000000189A76EC4
		public override Stream EndGetRequestStream(IAsyncResult asyncResult) => default; // 0x0000000189A76EC4-0x0000000189A77124
		public override WebResponse EndGetResponse(IAsyncResult asyncResult) => default; // 0x0000000189A77124-0x0000000189A77384
		public override WebResponse GetResponse() => default; // 0x0000000189A77C68-0x0000000189A77EC4
		private static void GetRequestStreamCallback(object state) {} // 0x0000000189A775B0-0x0000000189A777AC
		private static void GetResponseCallback(object state) {} // 0x0000000189A777AC-0x0000000189A77C68
		internal void UnblockReader() {} // 0x0000000189A77EC4-0x0000000189A77F80
		public override void Abort() {} // 0x0000000189A764AC-0x0000000189A76748
	}

	internal class FileWebRequestCreator : IWebRequestCreate // TypeDefIndex: 45743
	{
		// Constructors
		internal FileWebRequestCreator() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public WebRequest Create(System.Uri uri) => default; // 0x0000000189A7644C-0x0000000189A764AC
	}

	internal sealed class FileWebStream : FileStream, ICloseEx // TypeDefIndex: 45744
	{
		// Fields
		private FileWebRequest m_request; // 0x70
	
		// Constructors
		public FileWebStream() {} // Dummy constructor
		public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) {} // 0x0000000189A79664-0x0000000189A796F0
		public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) {} // 0x0000000189A796F0-0x0000000189A79790
	
		// Methods
		protected override void Dispose(bool disposing) {} // 0x0000000189A792C4-0x0000000189A79364
		void ICloseEx.CloseEx(CloseExState closeState) {} // 0x0000000189A79558-0x0000000189A79598
		public override int Read(byte[] buffer, int offset, int size) => default; // 0x0000000189A79490-0x0000000189A79558
		public override void Write(byte[] buffer, int offset, int size) {} // 0x0000000189A79598-0x0000000189A79664
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) => default; // 0x0000000189A79040-0x0000000189A79138
		public override int EndRead(IAsyncResult ar) => default; // 0x0000000189A79364-0x0000000189A793F8
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) => default; // 0x0000000189A79138-0x0000000189A79230
		public override void EndWrite(IAsyncResult ar) {} // 0x0000000189A793F8-0x0000000189A79490
		private void CheckError() {} // 0x0000000189A79230-0x0000000189A792C4
	}

	[Serializable]
	public class FileWebResponse : WebResponse, ISerializable, ICloseEx // TypeDefIndex: 45745
	{
		// Fields
		private bool m_closed; // 0x20
		private long m_contentLength; // 0x28
		private FileAccess m_fileAccess; // 0x30
		private WebHeaderCollection m_headers; // 0x38
		private Stream m_stream; // 0x40
		private System.Uri m_uri; // 0x48
	
		// Properties
		public override WebHeaderCollection Headers { get => default; } // 0x0000000189A79008-0x0000000189A79024 
		public override System.Uri ResponseUri { get => default; } // 0x0000000189A79024-0x0000000189A79040 
	
		// Constructors
		public FileWebResponse() {} // Dummy constructor
		internal FileWebResponse(FileWebRequest request, System.Uri uri, FileAccess access, bool asyncHint) {} // 0x0000000189A78D28-0x0000000189A79008
		[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
		protected FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A78BA0-0x0000000189A78D28
	
		// Methods
		new void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A6AE44-0x0000000189A6AE70
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A78730-0x0000000189A78888
		private void CheckDisposed() {} // 0x0000000189A786A8-0x0000000189A78728
		public override void Close() {} // 0x0000000189A78728-0x0000000189A78730
		void ICloseEx.CloseEx(CloseExState closeState) {} // 0x0000000189A788FC-0x0000000189A78BA0
		public override Stream GetResponseStream() => default; // 0x0000000189A78888-0x0000000189A788FC
	}

	public interface IWebProxy // TypeDefIndex: 45746
	{
		// Properties
		ICredentials Credentials { get; }
	
		// Methods
		System.Uri GetProxy(System.Uri destination);
		bool IsBypassed(System.Uri host);
	}

	[Serializable]
	public class WebProxy : IWebProxy, ISerializable // TypeDefIndex: 45747
	{
		// Fields
		private bool _UseRegistry; // 0x10
		private bool _BypassOnLocal; // 0x11
		private bool m_EnableAutoproxy; // 0x12
		private System.Uri _ProxyAddress; // 0x18
		private ArrayList _BypassList; // 0x20
		private ICredentials _Credentials; // 0x28
		private Regex[] _RegExBypassList; // 0x30
		private Hashtable _ProxyHostAddresses; // 0x38
		private AutoWebProxyScriptEngine m_ScriptEngine; // 0x40
	
		// Properties
		public ICredentials Credentials { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public bool UseDefaultCredentials { get => default; set {} } // 0x0000000189A81568-0x0000000189A815AC 0x0000000189A815AC-0x0000000189A81630
		internal AutoWebProxyScriptEngine ScriptEngine { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
	
		// Constructors
		public WebProxy() {} // 0x0000000189A811D4-0x0000000189A811F8
		public WebProxy(System.Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) {} // 0x0000000189A811F8-0x0000000189A812B8
		protected WebProxy(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A812B8-0x0000000189A81568
		internal WebProxy(bool enableAutoproxy) {} // 0x0000000183D75F90-0x0000000183D75FA0
	
		// Methods
		public System.Uri GetProxy(System.Uri destination) => default; // 0x0000000189A807F4-0x0000000189A8093C
		private void UpdateRegExList(bool canThrow) {} // 0x0000000189A80FD0-0x0000000189A811D4
		private bool IsMatchInBypassList(System.Uri input) => default; // 0x0000000189A80D60-0x0000000189A80EB8
		private bool IsLocal(System.Uri host) => default; // 0x0000000189A80C1C-0x0000000189A80D60
		private bool IsLocalInProxyHash(System.Uri host) => default; // 0x0000000189A80B80-0x0000000189A80C1C
		public bool IsBypassed(System.Uri host) => default; // 0x0000000189A80AA8-0x0000000189A80B80
		private bool IsBypassedManual(System.Uri host) => default; // 0x0000000189A809E8-0x0000000189A80AA8
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A80FB0-0x0000000189A80FD0
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A80608-0x0000000189A806F8
		public static IWebProxy CreateDefaultProxy() => default; // 0x0000000189A805C4-0x0000000189A80608
		internal void UnsafeUpdateFromRegistry() {} // 0x0000000181168960-0x0000000181168970
		private bool GetProxyAuto(System.Uri destination, out System.Uri proxyUri) {
			proxyUri = default;
			return default;
		} // 0x0000000189A806F8-0x0000000189A807F4
		private bool IsBypassedAuto(System.Uri destination, out bool isBypassed) {
			isBypassed = default;
			return default;
		} // 0x0000000189A8093C-0x0000000189A809E8
		private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly) => default; // 0x0000000189A803E4-0x0000000189A805C4
		private static System.Uri ProxyUri(string proxyName) => default; // 0x0000000189A80EB8-0x0000000189A80FB0
	}

	internal class AutoWebProxyScriptEngine // TypeDefIndex: 45748
	{
		// Constructors
		public AutoWebProxyScriptEngine() {} // Dummy constructor
	
		// Methods
		public bool GetProxies(System.Uri destination, out IList<string> proxyList) {
			proxyList = default;
			return default;
		} // 0x000000018882C740-0x000000018882C75C
		public bool GetProxies(System.Uri destination, out IList<string> proxyList, ref int syncStatus) {
			proxyList = default;
			return default;
		} // 0x000000018882C740-0x000000018882C75C
	}

	internal static class UnsafeNclNativeMethods // TypeDefIndex: 45752
	{
		// Nested types
		internal static class HttpApi // TypeDefIndex: 45750
		{
			// Fields
			private static string[] m_Strings; // 0x00
	
			// Nested types
			internal static class HTTP_REQUEST_HEADER_ID // TypeDefIndex: 45749
			{
				// Fields
				private static string[] m_Strings; // 0x00
	
				// Constructors
				static HTTP_REQUEST_HEADER_ID() {} // 0x0000000189A79938-0x0000000189A79ED0
	
				// Methods
				internal static string ToString(int position) => default; // 0x0000000189A798D4-0x0000000189A79938
			}
	
			// Constructors
			static HttpApi() {} // 0x0000000189A79ED0-0x0000000189A7A308
		}
	
		internal static class SecureStringHelper // TypeDefIndex: 45751
		{
			// Methods
			internal static string CreateString(SecureString secureString) => default; // 0x0000000189A7ED24-0x0000000189A7EE2C
			internal static SecureString CreateSecureString(string plainString) => default; // 0x0000000189A7EC84-0x0000000189A7ED24
		}
	}

	internal static class Logging // TypeDefIndex: 45753
	{
		// Properties
		internal static bool On { get; } // 0x000000018115F4C0-0x000000018115F530 
	}

	internal class ServerCertValidationCallback // TypeDefIndex: 45755
	{
		// Fields
		private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
		private readonly ExecutionContext m_Context; // 0x18
	
		// Properties
		internal RemoteCertificateValidationCallback ValidationCallback { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Nested types
		private class CallbackContext // TypeDefIndex: 45754
		{
			// Fields
			internal readonly object request; // 0x10
			internal readonly System.Security.Cryptography.X509Certificates.X509Certificate certificate; // 0x18
			internal readonly System.Security.Cryptography.X509Certificates.X509Chain chain; // 0x20
			internal readonly SslPolicyErrors sslPolicyErrors; // 0x28
			internal bool result; // 0x2C
	
			// Constructors
			public CallbackContext() {} // Dummy constructor
			internal CallbackContext(object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, SslPolicyErrors sslPolicyErrors) {} // 0x0000000189A6C494-0x0000000189A6C4D4
		}
	
		// Constructors
		public ServerCertValidationCallback() {} // Dummy constructor
		internal ServerCertValidationCallback(RemoteCertificateValidationCallback validationCallback) {} // 0x0000000189A7EFFC-0x0000000189A7F060
	
		// Methods
		internal void Callback(object state) {} // 0x0000000189A7EE2C-0x0000000189A7EEB4
		internal bool Invoke(object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, SslPolicyErrors sslPolicyErrors) => default; // 0x0000000189A7EEB4-0x0000000189A7EFFC
	}

	public class AuthenticationManager // TypeDefIndex: 45756
	{
		// Fields
		private static ArrayList modules; // 0x00
		private static object locker; // 0x08
		private static ICredentialPolicy credential_policy; // 0x10
	
		// Constructors
		public AuthenticationManager() {} // Dummy constructor
		static AuthenticationManager() {} // 0x0000000189A6BE50-0x0000000189A6BEF0
	
		// Methods
		private static void EnsureModules() {} // 0x0000000189A6B6E4-0x0000000189A6BA80
		public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) => default; // 0x0000000189A6B20C-0x0000000189A6B378
		private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) => default; // 0x0000000189A6B378-0x0000000189A6B6E4
		public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) => default; // 0x0000000189A6BA80-0x0000000189A6BE50
	}

	internal class BasicClient : IAuthenticationModule // TypeDefIndex: 45757
	{
		// Properties
		public string AuthenticationType { get => default; } // 0x0000000189A6C294-0x0000000189A6C2C0 
	
		// Constructors
		public BasicClient() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) => default; // 0x0000000189A6BEF0-0x0000000189A6BF90
		private static byte[] GetBytes(string str) => default; // 0x0000000189A6BF90-0x0000000189A6C01C
		private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) => default; // 0x0000000189A6C01C-0x0000000189A6C280
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) => default; // 0x0000000189A6C280-0x0000000189A6C294
	}

	public delegate IPEndPoint BindIPEndPoint(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount); // TypeDefIndex: 45758; 0x0000000181035ED0-0x0000000181035EF0

	internal class BufferedReadStream : WebReadStream // TypeDefIndex: 45760
	{
		// Fields
		private readonly System.Net.BufferOffsetSize readBuffer; // 0x40
	
		// Constructors
		public BufferedReadStream() {} // Dummy constructor
		public BufferedReadStream(WebOperation operation, Stream innerStream, System.Net.BufferOffsetSize readBuffer) {} // 0x0000000189A6C464-0x0000000189A6C494
	
		// Methods
		protected override async Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) => default; // 0x0000000189A6C2C0-0x0000000189A6C3DC
		internal bool TryReadFromBuffer(byte[] buffer, int offset, int size, out int result) {
			result = default;
			return default;
		} // 0x0000000189A6C3DC-0x0000000189A6C464
	}

	internal class ContentDecodeStream : WebReadStream // TypeDefIndex: 45762
	{
		// Properties
		private Stream OriginalInnerStream { get; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
	
		// Nested types
		internal enum Mode // TypeDefIndex: 45761
		{
			GZip = 0,
			Deflate = 1
		}
	
		// Constructors
		public ContentDecodeStream() {} // Dummy constructor
		private ContentDecodeStream(WebOperation operation, Stream decodeStream, Stream originalInnerStream) {} // 0x0000000189A6C464-0x0000000189A6C494
	
		// Methods
		public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, Mode mode) => default; // 0x0000000189A6C6B4-0x0000000189A6C7A0
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) => default; // 0x0000000189A63E2C-0x0000000189A63E68
		internal override System.Threading.Tasks.Task FinishReading(CancellationToken cancellationToken) => default; // 0x0000000189A6C7A0-0x0000000189A6C81C
	}

	[Flags]
	public enum DecompressionMethods // TypeDefIndex: 45763
	{
		None = 0,
		GZip = 1,
		Deflate = 2
	}

	internal class DefaultCertificatePolicy // TypeDefIndex: 45764
	{
		// Constructors
		public DefaultCertificatePolicy() {} // Dummy constructor
	}

	internal class DigestHeaderParser // TypeDefIndex: 45765
	{
		// Fields
		private string header; // 0x10
		private int length; // 0x18
		private int pos; // 0x1C
		private static string[] keywords; // 0x00
		private string[] values; // 0x20
	
		// Properties
		public string Realm { get => default; } // 0x00000001891FC0F8-0x00000001891FC120 
		public string Opaque { get => default; } // 0x00000001891FC030-0x00000001891FC058 
		public string Nonce { get => default; } // 0x00000001891FC080-0x00000001891FC0A8 
		public string Algorithm { get => default; } // 0x00000001891FC0A8-0x00000001891FC0D0 
		public string QOP { get => default; } // 0x00000001891FC0D0-0x00000001891FC0F8 
	
		// Constructors
		public DigestHeaderParser() {} // Dummy constructor
		public DigestHeaderParser(string header) {} // 0x0000000189A752B8-0x0000000189A7535C
		static DigestHeaderParser() {} // 0x0000000189A751A4-0x0000000189A752B8
	
		// Methods
		public bool Parse() => default; // 0x0000000189A74F48-0x0000000189A75138
		private void SkipWhitespace() {} // 0x0000000189A75138-0x0000000189A751A4
		private string GetKey() => default; // 0x0000000189A74D20-0x0000000189A74DAC
		private bool GetKeywordAndValue(out string key, out string value) {
			key = default;
			value = default;
			return default;
		} // 0x0000000189A74DAC-0x0000000189A74F48
	}

	internal class DigestSession // TypeDefIndex: 45766
	{
		// Fields
		private static RandomNumberGenerator rng; // 0x00
		private System.DateTime lastUse; // 0x10
		private int _nc; // 0x18
		private HashAlgorithm hash; // 0x20
		private DigestHeaderParser parser; // 0x28
		private string _cnonce; // 0x30
	
		// Properties
		public string Algorithm { get => default; } // 0x0000000189A760C4-0x0000000189A760E4 
		public string Realm { get => default; } // 0x0000000189A76220-0x0000000189A76240 
		public string Nonce { get => default; } // 0x0000000189A761C0-0x0000000189A761E0 
		public string Opaque { get => default; } // 0x0000000189A761E0-0x0000000189A76200 
		public string QOP { get => default; } // 0x0000000189A76200-0x0000000189A76220 
		public string CNonce { get => default; } // 0x0000000189A760E4-0x0000000189A761C0 
		public System.DateTime LastUse { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		static DigestSession() {} // 0x0000000189A76020-0x0000000189A76070
		public DigestSession() {} // 0x0000000189A76070-0x0000000189A760C4
	
		// Methods
		public bool Parse(string challenge) => default; // 0x0000000189A75D70-0x0000000189A75EE4
		private string HashToHexString(string toBeHashed) => default; // 0x0000000189A75C54-0x0000000189A75D70
		private string HA1(string username, string password) => default; // 0x0000000189A75A7C-0x0000000189A75B8C
		private string HA2(HttpWebRequest webRequest) => default; // 0x0000000189A75B8C-0x0000000189A75C54
		private string Response(string username, string password, HttpWebRequest webRequest) => default; // 0x0000000189A75EE4-0x0000000189A76020
		public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) => default; // 0x0000000189A7535C-0x0000000189A75A7C
	}

	internal class DigestClient : IAuthenticationModule // TypeDefIndex: 45767
	{
		// Fields
		private static readonly Hashtable cache; // 0x00
	
		// Properties
		private static Hashtable Cache { get => default; } // 0x0000000189A74BC4-0x0000000189A74D20 
		public string AuthenticationType { get => default; } // 0x0000000189A74B98-0x0000000189A74BC4 
	
		// Constructors
		public DigestClient() {} // 0x000000018350B670-0x000000018350B680
		static DigestClient() {} // 0x0000000189A74B10-0x0000000189A74B98
	
		// Methods
		private static void CheckExpired(int count) {} // 0x0000000189A74404-0x0000000189A749EC
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) => default; // 0x0000000189A741A8-0x0000000189A74404
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) => default; // 0x0000000189A749EC-0x0000000189A74B10
	}

	public static class Dns // TypeDefIndex: 45769
	{
		// Nested types
		private delegate IPAddress[] GetHostAddressesCallback(string hostName); // TypeDefIndex: 45768; 0x000000018102B410-0x000000018102B420
	
		// Methods
		public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) => default; // 0x000000018389C2B0-0x000000018389C3B0
		public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) => default; // 0x0000000183B1E9E0-0x0000000183B1EA70
		private static bool GetHostByName_icall(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) {
			h_name = default;
			h_aliases = default;
			h_addr_list = default;
			return default;
		} // 0x0000000184272038-0x0000000184272040
		private static bool GetHostByAddr_icall(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) {
			h_name = default;
			h_aliases = default;
			h_addr_list = default;
			return default;
		} // 0x0000000189A762B8-0x0000000189A762C0
		private static bool GetHostName_icall(out string h_name) {
			h_name = default;
			return default;
		} // 0x0000000184276D60-0x0000000184276D68
		private static void Error_11001(string hostName) {} // 0x0000000189A76240-0x0000000189A762B8
		private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) => default; // 0x0000000182941000-0x0000000182941280
		private static IPHostEntry GetHostByAddressFromString(string address, bool parse) => default; // 0x0000000189A762C0-0x0000000189A763CC
		public static IPHostEntry GetHostEntry(string hostNameOrAddress) => default; // 0x0000000182940BA0-0x0000000182940CB0
		public static IPHostEntry GetHostEntry(IPAddress address) => default; // 0x0000000189A763CC-0x0000000189A7644C
		public static IPAddress[] GetHostAddresses(string hostNameOrAddress) => default; // 0x0000000182940A70-0x0000000182940BA0
		[Obsolete("Use GetHostEntry instead")]
		public static IPHostEntry GetHostByName(string hostName) => default; // 0x0000000182940CB0-0x0000000182940D70
		public static string GetHostName() => default; // 0x0000000183A61920-0x0000000183A61950
		public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress) => default; // 0x000000018295AA50-0x000000018295AB70
	}

	internal class FixedSizeReadStream : WebReadStream // TypeDefIndex: 45771
	{
		// Fields
		private long position; // 0x48
	
		// Properties
		public long ContentLength { get; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
	
		// Constructors
		public FixedSizeReadStream() {} // Dummy constructor
		public FixedSizeReadStream(WebOperation operation, Stream innerStream, long contentLength) {} // 0x0000000189A798AC-0x0000000189A798D4
	
		// Methods
		protected override async Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) => default; // 0x0000000189A79790-0x0000000189A798AC
	}

	internal class HttpRequestCreator : IWebRequestCreate // TypeDefIndex: 45772
	{
		// Constructors
		internal HttpRequestCreator() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public WebRequest Create(System.Uri uri) => default; // 0x0000000189A7A308-0x0000000189A7A368
	}

	[Serializable]
	public class HttpWebRequest : WebRequest, ISerializable // TypeDefIndex: 45780
	{
		// Fields
		private System.Uri requestUri; // 0x38
		private System.Uri actualUri; // 0x40
		private bool hostChanged; // 0x48
		private bool allowAutoRedirect; // 0x49
		private bool allowBuffering; // 0x4A
		private System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates; // 0x50
		private string connectionGroup; // 0x58
		private bool haveContentLength; // 0x60
		private long contentLength; // 0x68
		private HttpContinueDelegate continueDelegate; // 0x70
		private CookieContainer cookieContainer; // 0x78
		private ICredentials credentials; // 0x80
		private bool haveResponse; // 0x88
		private bool requestSent; // 0x89
		private WebHeaderCollection webHeaders; // 0x90
		private bool keepAlive; // 0x98
		private int maxAutoRedirect; // 0x9C
		private string mediaType; // 0xA0
		private string method; // 0xA8
		private string initialMethod; // 0xB0
		private bool pipelined; // 0xB8
		private bool preAuthenticate; // 0xB9
		private bool usedPreAuth; // 0xBA
		private System.Version version; // 0xC0
		private bool force_version; // 0xC8
		private System.Version actualVersion; // 0xD0
		private IWebProxy proxy; // 0xD8
		private bool sendChunked; // 0xE0
		private ServicePoint servicePoint; // 0xE8
		private int timeout; // 0xF0
		private int continueTimeout; // 0xF4
		private WebRequestStream writeStream; // 0xF8
		private HttpWebResponse webResponse; // 0x100
		private WebCompletionSource responseTask; // 0x108
		private WebOperation currentOperation; // 0x110
		private int aborted; // 0x118
		private bool gotRequestStream; // 0x11C
		private int redirects; // 0x120
		private bool expectContinue; // 0x124
		private bool getResponseCalled; // 0x125
		private object locker; // 0x128
		private bool finished_reading; // 0x130
		private DecompressionMethods auto_decomp; // 0x134
		private static int defaultMaxResponseHeadersLength; // 0x00
		private static int defaultMaximumErrorResponseLength; // 0x04
		private static RequestCachePolicy defaultCachePolicy; // 0x08
		private int readWriteTimeout; // 0x138
		private MobileTlsProvider tlsProvider; // 0x140
		private MonoTlsSettings tlsSettings; // 0x148
		private ServerCertValidationCallback certValidationCallback; // 0x150
		private bool hostHasPort; // 0x158
		private System.Uri hostUri; // 0x160
		private AuthorizationState auth_state; // 0x168
		private AuthorizationState proxy_auth_state; // 0x178
		[NonSerialized]
		internal System.Func<Stream, System.Threading.Tasks.Task> ResendContentFactory; // 0x188
		private bool unsafe_auth_blah; // 0x191
	
		// Properties
		public System.Uri Address { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public virtual bool AllowAutoRedirect { set {} } // 0x0000000183D4F020-0x0000000183D4F030
		public virtual bool AllowWriteStreamBuffering { get => default; set {} } // 0x0000000183D4F780-0x0000000183D4F790 0x0000000183D4F790-0x0000000183D4F7A0
		public DecompressionMethods AutomaticDecompression { get => default; set {} } // 0x0000000183D4FC40-0x0000000183D4FC50 0x0000000189A7DE04-0x0000000189A7DE2C
		internal bool InternalAllowBuffering { get => default; } // 0x0000000189A7DC5C-0x0000000189A7DC70 
		private bool MethodWithBuffer { get => default; } // 0x0000000189A7DC70-0x0000000189A7DD50 
		internal MobileTlsProvider TlsProvider { get => default; } // 0x0000000183D57300-0x0000000183D57310 
		internal MonoTlsSettings TlsSettings { get => default; } // 0x0000000183D571B0-0x0000000183D571C0 
		public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get => default; } // 0x0000000189A7DA58-0x0000000189A7DAC8 
		public override string ConnectionGroupName { set {} } // 0x0000000183081D30-0x0000000183081D40
		public override long ContentLength { get => default; set {} } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x0000000189A7DE2C-0x0000000189A7DEC4
		internal long InternalContentLength { set {} } // 0x0000000183D4F040-0x0000000183D4F050
		internal bool ThrowOnError { get; set; } // 0x0000000183D57C30-0x0000000183D57C40 0x0000000183D5A070-0x0000000183D5A080
		public virtual CookieContainer CookieContainer { set {} } // 0x00000001851DFCA4-0x00000001851DFCB4
		public override ICredentials Credentials { get => default; set {} } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x00000001851DFC94-0x00000001851DFCA4
		[MonoTODO]
		public static int DefaultMaximumErrorResponseLength { get => default; } // 0x0000000189A7DAC8-0x0000000189A7DB18 
		public override WebHeaderCollection Headers { get => default; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
		public string Host { get => default; set {} } // 0x0000000189A7DB68-0x0000000189A7DC5C 0x0000000189A7DEC4-0x0000000189A7E074
		public bool KeepAlive { get => default; set {} } // 0x0000000183D58690-0x0000000183D586A0 0x0000000183D5CE20-0x0000000183D5CE30
		public int MaximumAutomaticRedirections { set {} } // 0x0000000189A7E074-0x0000000189A7E0FC
		[MonoTODO("Use this")]
		public static int DefaultMaximumResponseHeadersLength { get => default; } // 0x0000000189A7DB18-0x0000000189A7DB68 
		public int ReadWriteTimeout { get => default; } // 0x0000000183D59CD0-0x0000000183D59CE0 
		public override string Method { get => default; set {} } // 0x0000000183D4EB10-0x0000000183D4EB20 0x0000000189A7E0FC-0x0000000189A7E398
		public override bool PreAuthenticate { set {} } // 0x0000000183D52000-0x0000000183D52010
		public System.Version ProtocolVersion { get => default; set {} } // 0x0000000183D50E60-0x0000000183D50E70 0x0000000189A7E398-0x0000000189A7E4AC
		public override IWebProxy Proxy { get => default; set {} } // 0x0000000183D4E7B0-0x0000000183D4E7C0 0x0000000189A7E4AC-0x0000000189A7E504
		public override System.Uri RequestUri { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public bool SendChunked { get => default; set {} } // 0x0000000183D58140-0x0000000183D58150 0x0000000189A7E504-0x0000000189A7E530
		public ServicePoint ServicePoint { get => default; } // 0x0000000189A7DD7C-0x0000000189A7DD84 
		internal ServicePoint ServicePointNoLock { get => default; } // 0x0000000183D50EA0-0x0000000183D50EB0 
		public override int Timeout { get => default; set {} } // 0x0000000183D50F00-0x0000000183D50F10 0x0000000189A7E530-0x0000000189A7E59C
		public string TransferEncoding { get => default; } // 0x0000000189A7DD84-0x0000000189A7DDD0 
		public override bool UseDefaultCredentials { get => default; } // 0x0000000189A7DDD0-0x0000000189A7DE04 
		public bool UnsafeAuthenticatedConnectionSharing { get => default; } // 0x0000000183D75F60-0x0000000183D75F70 
		internal bool ExpectContinue { get => default; set {} } // 0x0000000183D75F50-0x0000000183D75F60 0x0000000183D75F70-0x0000000183D75F80
		internal System.Uri AuthUri { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		internal bool ProxyQuery { get => default; } // 0x0000000189A7DD50-0x0000000189A7DD7C 
		internal ServerCertValidationCallback ServerCertValidationCallback { get => default; } // 0x0000000183D57200-0x0000000183D57210 
		internal bool FinishedReading { set {} } // 0x0000000183D5A340-0x0000000183D5A350
		internal bool Aborted { get => default; } // 0x0000000186358540-0x0000000186358558 
	
		// Nested types
		private enum NtlmAuthState // TypeDefIndex: 45773
		{
			None = 0,
			Challenge = 1,
			Response = 2
		}
	
		private struct AuthorizationState // TypeDefIndex: 45774
		{
			// Fields
			private readonly HttpWebRequest request; // 0x00
			private readonly bool isProxy; // 0x08
			private bool isCompleted; // 0x09
			private NtlmAuthState ntlm_auth_state; // 0x0C
	
			// Properties
			public bool IsCompleted { get => default; } // 0x0000000183D55A40-0x0000000183D55A50 
			public NtlmAuthState NtlmAuthState { get => default; } // 0x0000000183D4FBF0-0x0000000183D4FC00 
			public bool IsNtlmAuthenticated { get => default; } // 0x0000000189A81D4C-0x0000000189A81D60 
	
			// Constructors
			public AuthorizationState(HttpWebRequest request, bool isProxy) : this() {
				this.request = default;
				this.isProxy = default;
				isCompleted = default;
				ntlm_auth_state = default;
			} // 0x0000000189A81D20-0x0000000189A81D4C
	
			// Methods
			public bool CheckAuthorization(WebResponse response, HttpStatusCode code) => default; // 0x0000000189A81990-0x0000000189A81BCC
			public void Reset() {} // 0x0000000189A81BCC-0x0000000189A81C40
			public override string ToString() => default; // 0x0000000189A81C40-0x0000000189A81D20
		}
	
		// Constructors
		static HttpWebRequest() {} // 0x0000000189A7D5EC-0x0000000189A7D68C
		public HttpWebRequest(System.Uri uri) {} // 0x0000000189A7D6BC-0x0000000189A7D8BC
		[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
		protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A7D8BC-0x0000000189A7DA58
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		public HttpWebRequest() {} // 0x0000000189A7D68C-0x0000000189A7D6BC
	
		// Methods
		private void ResetAuthorization() {} // 0x0000000189A7D054-0x0000000189A7D0CC
		private bool TryGetHostUri(string hostName, out System.Uri hostUri) {
			hostUri = default;
			return default;
		} // 0x0000000189A7D458-0x0000000189A7D518
		internal ServicePoint GetServicePoint() => default; // 0x0000000189A7BFF0-0x0000000189A7C158
		private WebOperation SendRequest(bool redirecting, System.Net.BufferOffsetSize writeBuffer, CancellationToken cancellationToken) => default; // 0x0000000189A7D148-0x0000000189A7D40C
		private Task<Stream> MyGetRequestStreamAsync(CancellationToken cancellationToken) => default; // 0x0000000189A7C4C0-0x0000000189A7C9EC
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) => default; // 0x0000000189A7A4C0-0x0000000189A7A578
		public override Stream EndGetRequestStream(IAsyncResult asyncResult) => default; // 0x0000000189A7AF50-0x0000000189A7B07C
		public override Task<Stream> GetRequestStreamAsync() => default; // 0x0000000189A7BBC4-0x0000000189A7BC50
		internal static Task<T> RunWithTimeout<T>(System.Func<CancellationToken, Task<T>> func, int timeout, Action abort, Func<bool> aborted, CancellationToken cancellationToken) => default;
		private static async Task<T> RunWithTimeoutWorker<T>(Task<T> workerTask, int timeout, Action abort, Func<bool> aborted, CancellationTokenSource cts) => default;
		private Task<T> RunWithTimeout<T>(System.Func<CancellationToken, Task<T>> func) => default;
		private async Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken) => default; // 0x0000000189A7C9EC-0x0000000189A7CAE0
		private async Task<System.ValueTuple<HttpWebResponse, bool, bool, System.Net.BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) => default; // 0x0000000189A7BC50-0x0000000189A7BD58
		internal static Exception FlattenException(Exception e) => default; // 0x0000000189A7B1A8-0x0000000189A7B23C
		private WebException GetWebException(Exception e) => default; // 0x0000000189A7C2A0-0x0000000189A7C30C
		private static WebException GetWebException(Exception e, bool aborted) => default; // 0x0000000189A7C158-0x0000000189A7C2A0
		internal static WebException CreateRequestAbortedException() => default; // 0x0000000189A7AD50-0x0000000189A7ADF8
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) => default; // 0x0000000189A7A578-0x0000000189A7A814
		public override WebResponse EndGetResponse(IAsyncResult asyncResult) => default; // 0x0000000189A7B07C-0x0000000189A7B1A8
		public override WebResponse GetResponse() => default; // 0x0000000189A7BD58-0x0000000189A7BE40
		public override void Abort() {} // 0x0000000189A7A368-0x0000000189A7A4C0
		new void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A7D40C-0x0000000189A7D458
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A7B8A0-0x0000000189A7B8EC
		private void CheckRequestStarted() {} // 0x0000000189A7ACE4-0x0000000189A7AD50
		internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) {} // 0x0000000189A7ADF8-0x0000000189A7AE10
		private void RewriteRedirectToGet() {} // 0x0000000189A7D0CC-0x0000000189A7D148
		private bool Redirect(HttpStatusCode code, WebResponse response) => default; // 0x0000000189A7CAE0-0x0000000189A7D054
		private string GetHeaders() => default; // 0x0000000189A7B23C-0x0000000189A7B8A0
		private void DoPreAuthenticate() {} // 0x0000000189A7AE10-0x0000000189A7AF50
		internal byte[] GetRequestHeaders() => default; // 0x0000000189A7B8EC-0x0000000189A7BBC4
		private System.ValueTuple<WebOperation, bool> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, System.Net.BufferOffsetSize writeBuffer, CancellationToken cancellationToken) => default; // 0x0000000189A7C30C-0x0000000189A7C4C0
		private bool CheckAuthorization(WebResponse response, HttpStatusCode code) => default; // 0x0000000189A7A814-0x0000000189A7A838
		private System.ValueTuple<Task<System.Net.BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect) => default; // 0x0000000189A7BE40-0x0000000189A7BFF0
		private System.ValueTuple<bool, bool, Task<System.Net.BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response) => default; // 0x0000000189A7A838-0x0000000189A7ACE4
	}

	[Serializable]
	public class HttpWebResponse : WebResponse, ISerializable, IDisposable // TypeDefIndex: 45781
	{
		// Fields
		private System.Uri uri; // 0x20
		private WebHeaderCollection webHeaders; // 0x28
		private CookieCollection cookieCollection; // 0x30
		private string method; // 0x38
		private System.Version version; // 0x40
		private HttpStatusCode statusCode; // 0x48
		private string statusDescription; // 0x50
		private long contentLength; // 0x58
		private string contentType; // 0x60
		private CookieContainer cookie_container; // 0x68
		private bool disposed; // 0x70
		private Stream stream; // 0x78
	
		// Properties
		public override WebHeaderCollection Headers { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public override System.Uri ResponseUri { get => default; } // 0x0000000189A834C4-0x0000000189A834E0 
		public virtual HttpStatusCode StatusCode { get => default; } // 0x0000000183D4EC50-0x0000000183D4EC60 
		public virtual string StatusDescription { get => default; } // 0x0000000189A834E0-0x0000000189A834FC 
	
		// Constructors
		public HttpWebResponse() {} // 0x000000018350B670-0x000000018350B680
		internal HttpWebResponse(System.Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) {} // 0x0000000189A82E20-0x0000000189A82EE8
		internal HttpWebResponse(System.Uri uri, string method, WebResponseStream stream, CookieContainer container) {} // 0x0000000189A831BC-0x0000000189A834C4
		[Obsolete("Serialization is obsoleted for this type", false)]
		protected HttpWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A82EE8-0x0000000189A831BC
	
		// Methods
		public override Stream GetResponseStream() => default; // 0x0000000189A82D88-0x0000000189A82E10
		new void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A6AE44-0x0000000189A6AE70
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189A82C20-0x0000000189A82D88
		public override void Close() {} // 0x0000000189A829C0-0x0000000189A829E8
		void IDisposable.Dispose() {} // 0x0000000189A82E10-0x0000000189A82E20
		protected override void Dispose(bool disposing) {} // 0x0000000189A829E8-0x0000000189A829F8
		private void CheckDisposed() {} // 0x0000000189A82940-0x0000000189A829C0
		private void FillCookies() {} // 0x0000000189A829F8-0x0000000189A82C20
	}

	public interface ICredentialPolicy // TypeDefIndex: 45782
	{
	}

	internal class MonoChunkParser // TypeDefIndex: 45785
	{
		// Fields
		private WebHeaderCollection headers; // 0x10
		private int chunkSize; // 0x18
		private int chunkRead; // 0x1C
		private int totalWritten; // 0x20
		private State state; // 0x24
		private StringBuilder saved; // 0x28
		private bool sawCR; // 0x30
		private bool gotit; // 0x31
		private int trailerState; // 0x34
		private ArrayList chunks; // 0x38
	
		// Properties
		public bool WantMore { get => default; } // 0x0000000189A8421C-0x0000000189A84234 
		public bool DataAvailable { get => default; } // 0x0000000189A84168-0x0000000189A8421C 
		public int ChunkLeft { get => default; } // 0x0000000183D75FA0-0x0000000183D75FB0 
	
		// Nested types
		private enum State // TypeDefIndex: 45783
		{
			None = 0,
			PartialSize = 1,
			Body = 2,
			BodyFinished = 3,
			Trailer = 4
		}
	
		private class Chunk // TypeDefIndex: 45784
		{
			// Fields
			public byte[] Bytes; // 0x10
			public int Offset; // 0x18
	
			// Constructors
			public Chunk() {} // Dummy constructor
			public Chunk(byte[] chunk) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public int Read(byte[] buffer, int offset, int size) => default; // 0x0000000189A81D60-0x0000000189A81DC0
		}
	
		// Constructors
		public MonoChunkParser() {} // Dummy constructor
		public MonoChunkParser(WebHeaderCollection headers) {} // 0x0000000189A840B4-0x0000000189A84168
	
		// Methods
		public int Read(byte[] buffer, int offset, int size) => default; // 0x0000000189A83FD0-0x0000000189A83FE0
		private int ReadFromChunks(byte[] buffer, int offset, int size) => default; // 0x0000000189A83AF0-0x0000000189A83D98
		public void Write(byte[] buffer, int offset, int size) {} // 0x0000000189A8408C-0x0000000189A840B4
		private void InternalWrite(byte[] buffer, ref int offset, int size) {} // 0x0000000189A837E4-0x0000000189A8390C
		private State ReadBody(byte[] buffer, ref int offset, int size) => default; // 0x0000000189A8390C-0x0000000189A83A18
		private State GetChunkSize(byte[] buffer, ref int offset, int size) => default; // 0x0000000189A834FC-0x0000000189A837E4
		private static string RemoveChunkExtension(string input) => default; // 0x0000000189A83FE0-0x0000000189A84024
		private State ReadCRLF(byte[] buffer, ref int offset, int size) => default; // 0x0000000189A83A18-0x0000000189A83AF0
		private State ReadTrailer(byte[] buffer, ref int offset, int size) => default; // 0x0000000189A83D98-0x0000000189A83FD0
		private static void ThrowProtocolViolation(string message) {} // 0x0000000189A84024-0x0000000189A8408C
	}

	internal class MonoChunkStream : WebReadStream // TypeDefIndex: 45788
	{
		// Properties
		protected MonoChunkParser Decoder { get; } // 0x0000000183D4EA70-0x0000000183D4EA80 
	
		// Constructors
		public MonoChunkStream() {} // Dummy constructor
		public MonoChunkStream(WebOperation operation, Stream innerStream, WebHeaderCollection headers) {} // 0x0000000189A84498-0x0000000189A8453C
	
		// Methods
		protected override async Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) => default; // 0x0000000189A84308-0x0000000189A84424
		internal override async System.Threading.Tasks.Task FinishReading(CancellationToken cancellationToken) => default; // 0x0000000189A84234-0x0000000189A84308
		private static void ThrowExpectingChunkTrailer() {} // 0x0000000189A84424-0x0000000189A84490
	}

	internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 45789
	{
		// Fields
		private IAuthenticationModule authObject; // 0x10
	
		// Properties
		public string AuthenticationType { get => default; } // 0x0000000189A845B0-0x0000000189A845DC 
	
		// Constructors
		public NtlmClient() {} // 0x0000000189A84560-0x0000000189A845B0
	
		// Methods
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) => default; // 0x0000000189A8453C-0x0000000189A84560
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) => default; // 0x0000000181002730-0x0000000181002740
	}

	public class ServicePoint // TypeDefIndex: 45790
	{
		// Fields
		private readonly System.Uri uri; // 0x10
		private System.DateTime lastDnsResolve; // 0x18
		private System.Version protocolVersion; // 0x20
		private IPHostEntry host; // 0x28
		private bool usesProxy; // 0x30
		private bool sendContinue; // 0x31
		private bool useConnect; // 0x32
		private object hostE; // 0x38
		private bool useNagle; // 0x40
		private BindIPEndPoint endPointCallback; // 0x48
		private bool tcp_keepalive; // 0x50
		private int tcp_keepalive_time; // 0x54
		private int tcp_keepalive_interval; // 0x58
		private bool disposed; // 0x5C
		private int connectionLeaseTimeout; // 0x60
		private int receiveBufferSize; // 0x64
		private int connectionLimit; // 0x78
		private int maxIdleTime; // 0x7C
		private object m_ServerCertificateOrBytes; // 0x80
		private object m_ClientCertificateOrBytes; // 0x88
	
		// Properties
		internal ServicePointManager.SPKey Key { get; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
		private ServicePointScheduler Scheduler { get; set; } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		public System.Uri Address { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public int ConnectionLimit { get => default; } // 0x0000000183D4EC40-0x0000000183D4EC50 
		public virtual System.Version ProtocolVersion { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public bool Expect100Continue { set {} } // 0x0000000183D4F2D0-0x0000000183D4F2E0
		public bool UseNagleAlgorithm { get => default; set {} } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000183D4EEB0-0x0000000183D4EEC0
		internal bool SendContinue { get => default; set {} } // 0x0000000189A875F0-0x0000000189A87664 0x0000000183D4F2D0-0x0000000183D4F2E0
		internal bool UsesProxy { get => default; set {} } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000183D4EF70-0x0000000183D4EF80
		internal bool UseConnect { get => default; set {} } // 0x0000000183D4F630-0x0000000183D4F640 0x0000000183D4F640-0x0000000183D4F650
		private bool HasTimedOut { get => default; } // 0x0000000189A8711C-0x0000000189A871D8 
		internal IPHostEntry HostEntry { get => default; } // 0x0000000189A871D8-0x0000000189A875F0 
	
		// Constructors
		public ServicePoint() {} // Dummy constructor
		internal ServicePoint(ServicePointManager.SPKey key, System.Uri uri, int connectionLimit, int maxIdleTime) {} // 0x0000000189A8702C-0x0000000189A8711C
	
		// Methods
		public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) {} // 0x0000000189A86EC0-0x0000000189A86FBC
		internal void KeepAliveSetup(Socket socket) {} // 0x0000000189A86B7C-0x0000000189A86C38
		private static void PutBytes(byte[] bytes, uint v, int offset) {} // 0x0000000189A86C38-0x0000000189A86D38
		internal void SetVersion(System.Version version) {} // 0x0000000184271930-0x0000000184271940
		internal void SendRequest(WebOperation operation, string groupName) {} // 0x0000000189A86D38-0x0000000189A86EC0
		public bool CloseConnectionGroup(string connectionGroupName) => default; // 0x0000000189A86A7C-0x0000000189A86B64
		internal void FreeServicePoint() {} // 0x0000000189A86B64-0x0000000189A86B7C
		internal void UpdateServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate) {} // 0x0000000189A86FF4-0x0000000189A8702C
		internal void UpdateClientCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate) {} // 0x0000000189A86FBC-0x0000000189A86FF4
		internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) => default; // 0x0000000189A868F8-0x0000000189A86A7C
	}

	public class ServicePointManager // TypeDefIndex: 45792
	{
		// Fields
		private static ConcurrentDictionary<SPKey, ServicePoint> servicePoints; // 0x00
		private static ICertificatePolicy policy; // 0x08
		private static int defaultConnectionLimit; // 0x10
		private static int maxServicePointIdleTime; // 0x14
		private static int maxServicePoints; // 0x18
		private static int dnsRefreshTimeout; // 0x1C
		private static bool _checkCRL; // 0x20
		private static SecurityProtocolType _securityProtocol; // 0x24
		private static bool expectContinue; // 0x28
		private static bool useNagle; // 0x29
		private static ServerCertValidationCallback server_cert_cb; // 0x30
		private static bool tcp_keepalive; // 0x38
		private static int tcp_keepalive_time; // 0x3C
		private static int tcp_keepalive_interval; // 0x40
	
		// Properties
		[MonoTODO("CRL checks not implemented")]
		public static bool CheckCertificateRevocationList { get => default; } // 0x0000000189A853D0-0x0000000189A85420 
		public static int DnsRefreshTimeout { get => default; } // 0x0000000189A85420-0x0000000189A85470 
		public static SecurityProtocolType SecurityProtocol { get => default; } // 0x0000000189A85470-0x0000000189A854C0 
		internal static ServerCertValidationCallback ServerCertValidationCallback { get => default; } // 0x0000000189A854C0-0x0000000189A85510 
		public static RemoteCertificateValidationCallback ServerCertificateValidationCallback { get => default; } // 0x0000000189A85510-0x0000000189A85580 
	
		// Nested types
		internal class SPKey // TypeDefIndex: 45791
		{
			// Fields
			private System.Uri uri; // 0x10
			private System.Uri proxy; // 0x18
			private bool use_connect; // 0x20
	
			// Properties
			public bool UsesProxy { get => default; } // 0x0000000189A84760-0x0000000189A847AC 
	
			// Constructors
			public SPKey() {} // Dummy constructor
			public SPKey(System.Uri uri, System.Uri proxy, bool use_connect) {} // 0x0000000183D01130-0x0000000183D01160
	
			// Methods
			public override int GetHashCode() => default; // 0x0000000189A846A8-0x0000000189A84760
			public override bool Equals(object obj) => default; // 0x0000000189A845DC-0x0000000189A846A8
		}
	
		// Constructors
		public ServicePointManager() {} // Dummy constructor
		static ServicePointManager() {} // 0x0000000189A852BC-0x0000000189A853D0
	
		// Methods
		internal static ICertificatePolicy GetLegacyCertificatePolicy() => default; // 0x0000000189A851EC-0x0000000189A8523C
		public static ServicePoint FindServicePoint(System.Uri address, IWebProxy proxy) => default; // 0x0000000189A849E4-0x0000000189A851EC
		internal static void CloseConnectionGroup(string connectionGroupName) {} // 0x0000000189A847AC-0x0000000189A849E4
		internal static void RemoveServicePoint(ServicePoint sp) {} // 0x0000000189A8523C-0x0000000189A852BC
	}

	internal class ServicePointScheduler // TypeDefIndex: 45798
	{
		// Fields
		private int running; // 0x18
		private int maxIdleTime; // 0x1C
		private AsyncManualResetEvent schedulerEvent; // 0x20
		private ConnectionGroup defaultGroup; // 0x28
		private Dictionary<string, ConnectionGroup> groups; // 0x30
		private LinkedList<System.ValueTuple<ConnectionGroup, WebOperation>> operations; // 0x38
		private LinkedList<System.ValueTuple<ConnectionGroup, WebConnection, System.Threading.Tasks.Task>> idleConnections; // 0x40
		private int currentConnections; // 0x48
		private int connectionLimit; // 0x4C
		private System.DateTime idleSince; // 0x50
		private static int nextId; // 0x00
		public readonly int ID; // 0x58
	
		// Properties
		private ServicePoint ServicePoint { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public int MaxIdleTime { get => default; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 
	
		// Nested types
		private class ConnectionGroup // TypeDefIndex: 45793
		{
			// Fields
			private static int nextId; // 0x00
			public readonly int ID; // 0x20
			private LinkedList<WebConnection> connections; // 0x28
			private LinkedList<WebOperation> queue; // 0x30
	
			// Properties
			public ServicePointScheduler Scheduler { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
			// Constructors
			public ConnectionGroup() {} // Dummy constructor
			public ConnectionGroup(ServicePointScheduler scheduler, string name) {} // 0x0000000189A82858-0x0000000189A82940
	
			// Methods
			public bool IsEmpty() => default; // 0x0000000189A8277C-0x0000000189A827DC
			public void RemoveConnection(WebConnection connection) {} // 0x0000000189A827DC-0x0000000189A82858
			public void Cleanup() {} // 0x0000000189A81DC0-0x0000000189A81E98
			public void Close() {} // 0x0000000189A81E98-0x0000000189A82194
			public void EnqueueOperation(WebOperation operation) {} // 0x0000000189A82324-0x0000000189A82378
			public WebOperation GetNextOperation() => default; // 0x0000000189A82694-0x0000000189A8277C
			public WebConnection FindIdleConnection(WebOperation operation) => default; // 0x0000000189A82378-0x0000000189A82694
			public System.ValueTuple<WebConnection, bool> CreateOrReuseConnection(WebOperation operation, bool force) => default; // 0x0000000189A82194-0x0000000189A82324
		}
	
		private class AsyncManualResetEvent // TypeDefIndex: 45795
		{
			// Fields
			private TaskCompletionSource<bool> m_tcs; // 0x10
	
			// Constructors
			public AsyncManualResetEvent() {} // Dummy constructor
			public AsyncManualResetEvent(bool state) {} // 0x0000000189A818F8-0x0000000189A81990
	
			// Methods
			public Task<bool> WaitAsync(int millisecondTimeout) => default; // 0x0000000189A818A0-0x0000000189A818F8
			public void Set() {} // 0x0000000189A816EC-0x0000000189A818A0
			public void Reset() {} // 0x0000000189A81630-0x0000000189A816EC
		}
	
		// Constructors
		public ServicePointScheduler() {} // Dummy constructor
		public ServicePointScheduler(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) {} // 0x0000000189A86744-0x0000000189A868F8
	
		// Methods
		public void Run() {} // 0x0000000189A862E0-0x0000000189A8646C
		private async System.Threading.Tasks.Task RunScheduler() => default; // 0x0000000189A86224-0x0000000189A862E0
		private void Cleanup() {} // 0x0000000189A85580-0x0000000189A85718
		private void RunSchedulerIteration() {} // 0x0000000189A86078-0x0000000189A86224
		private bool OperationCompleted(ConnectionGroup group, WebOperation operation) => default; // 0x0000000189A85CA8-0x0000000189A85F00
		private void CloseIdleConnection(ConnectionGroup group, WebConnection connection) {} // 0x0000000189A85810-0x0000000189A85854
		private bool SchedulerIteration(ConnectionGroup group) => default; // 0x0000000189A8646C-0x0000000189A86570
		private void RemoveOperation(WebOperation operation) {} // 0x0000000189A85FBC-0x0000000189A86078
		private void RemoveIdleConnection(WebConnection connection) {} // 0x0000000189A85F00-0x0000000189A85FBC
		private void FinalCleanup() {} // 0x0000000189A85854-0x0000000189A85900
		public void SendRequest(WebOperation operation, string groupName) {} // 0x0000000189A86570-0x0000000189A86658
		public bool CloseConnectionGroup(string groupName) => default; // 0x0000000189A85718-0x0000000189A85810
		private ConnectionGroup GetConnectionGroup(string name) => default; // 0x0000000189A85900-0x0000000189A85C8C
		private void OnConnectionCreated(WebConnection connection) {} // 0x0000000183D75FB0-0x0000000183D75FC0
		private void OnConnectionClosed(WebConnection connection) {} // 0x0000000189A85C8C-0x0000000189A85CA8
		public static async Task<bool> WaitAsync(System.Threading.Tasks.Task workerTask, int millisecondTimeout) => default; // 0x0000000189A86660-0x0000000189A86744
	}

	internal class WebCompletionSource<T> // TypeDefIndex: 45802
	{
		// Fields
		private TaskCompletionSource<Result> completion;
		private Result currentResult;
	
		// Properties
		internal Result CurrentResult { get => default; }
		internal System.Threading.Tasks.Task Task { get => default; }
	
		// Nested types
		internal enum Status // TypeDefIndex: 45799
		{
			Running = 0,
			Completed = 1,
			Canceled = 2,
			Faulted = 3
		}
	
		internal class Result // TypeDefIndex: 45800
		{
			// Properties
			public Status<T> Status { get; }
			public bool Success { get => default; }
			public ExceptionDispatchInfo Error { get; }
			public T Argument { get; }
	
			// Constructors
			public Result() {} // Dummy constructor
			public Result(T argument) {}
			public Result(Status<T> state, ExceptionDispatchInfo error) {}
		}
	
		// Constructors
		public WebCompletionSource() {} // Dummy constructor
		public WebCompletionSource(bool runAsync = true /* Metadata: 0x01FBA404 */) {}
	
		// Methods
		public bool TrySetCompleted(T argument) => default;
		public bool TrySetCompleted() => default;
		public bool TrySetCanceled() => default;
		public bool TrySetCanceled(OperationCanceledException error) => default;
		public bool TrySetException(Exception error) => default;
		public void ThrowOnError() {}
		public async Task<T> WaitForCompletion() => default;
	}

	internal class WebCompletionSource : WebCompletionSource<object> // TypeDefIndex: 45803
	{
		// Constructors
		public WebCompletionSource() {} // 0x0000000189A91794-0x0000000189A917D0
	}

	internal enum ReadState // TypeDefIndex: 45804
	{
		None = 0,
		Status = 1,
		Headers = 2,
		Content = 3,
		Aborted = 4
	}

	internal class WebConnection : IDisposable // TypeDefIndex: 45809
	{
		// Fields
		private NetworkCredential ntlm_credentials; // 0x10
		private bool ntlm_authenticated; // 0x18
		private bool unsafe_sharing; // 0x19
		private Stream networkStream; // 0x20
		private Socket socket; // 0x28
		private MonoTlsStream monoTlsStream; // 0x30
		private WebConnectionTunnel tunnel; // 0x38
		private int disposed; // 0x40
		private System.DateTime idleSince; // 0x50
		private WebOperation currentOperation; // 0x58
	
		// Properties
		public ServicePoint ServicePoint { get; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public bool Closed { get => default; } // 0x000000018982FFFC-0x0000000189830004 
		public System.DateTime IdleSince { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		internal bool NtlmAuthenticated { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		internal NetworkCredential NtlmCredential { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		internal bool UnsafeAuthenticatedConnectionSharing { get => default; set {} } // 0x0000000183D4EF80-0x0000000183D4EF90 0x0000000183D4EFB0-0x0000000183D4EFC0
	
		// Constructors
		public WebConnection() {} // Dummy constructor
		public WebConnection(ServicePoint sPoint) {} // 0x0000000182692290-0x00000001826922A0
	
		// Methods
		private bool CanReuse() => default; // 0x0000000189A92DFC-0x0000000189A92E24
		private bool CheckReusable() => default; // 0x0000000189A92E24-0x0000000189A92EB4
		private async System.Threading.Tasks.Task Connect(WebOperation operation, CancellationToken cancellationToken) => default; // 0x0000000189A9331C-0x0000000189A93408
		private async Task<bool> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) => default; // 0x0000000189A9359C-0x0000000189A936B4
		internal async Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) => default; // 0x0000000189A93834-0x0000000189A9393C
		internal static WebException GetException(WebExceptionStatus status, Exception error) => default; // 0x0000000189A936D8-0x0000000189A93834
		internal static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) => default; // 0x0000000189A93AD0-0x0000000189A93C8C
		internal bool CanReuseConnection(WebOperation operation) => default; // 0x0000000189A92B60-0x0000000189A92DFC
		private bool PrepareSharingNtlm(WebOperation operation) => default; // 0x0000000189A9393C-0x0000000189A93AD0
		private void Reset() {} // 0x0000000189A93CB4-0x0000000189A93DF4
		private void Close(bool reset) {} // 0x0000000189A9325C-0x0000000189A9331C
		private void CloseSocket() {} // 0x0000000189A92EB4-0x0000000189A9325C
		public bool StartOperation(WebOperation operation, bool reused) => default; // 0x0000000189A93DF4-0x0000000189A93FC0
		public bool Continue(WebOperation next) => default; // 0x0000000189A93408-0x0000000189A9359C
		private void Dispose(bool disposing) {} // 0x0000000189A936C0-0x0000000189A936D8
		public void Dispose() {} // 0x0000000189A936B4-0x0000000189A936C0
		private void ResetNtlm() {} // 0x0000000189A93C8C-0x0000000189A93CB4
	}

	internal abstract class WebConnectionStream : Stream // TypeDefIndex: 45810
	{
		// Fields
		protected bool closed; // 0x28
		private bool disposed; // 0x29
		private object locker; // 0x30
		private int read_timeout; // 0x38
		private int write_timeout; // 0x3C
	
		// Properties
		internal HttpWebRequest Request { get; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		internal WebConnection Connection { get; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		internal WebOperation Operation { get; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		internal ServicePoint ServicePoint { get; } // 0x0000000189A927B0-0x0000000189A927CC 
		public override bool CanTimeout { get; } // 0x000000018232EB60-0x000000018232EB70 
		public override int ReadTimeout { get; set; } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000189A92828-0x0000000189A92890
		public override int WriteTimeout { get; set; } // 0x0000000183D4ED90-0x0000000183D4EDA0 0x0000000189A92890-0x0000000189A928F8
		public override bool CanSeek { get; } // 0x000000018115F4C0-0x000000018115F530 
		public override long Length { get; } // 0x0000000189A926F8-0x0000000189A92754 
		public override long Position { get; set; } // 0x0000000189A92754-0x0000000189A927B0 0x0000000189A927CC-0x0000000189A92828
	
		// Constructors
		protected WebConnectionStream() {} // Dummy constructor
		protected WebConnectionStream(WebConnection cnc, WebOperation operation) {} // 0x0000000189A92630-0x0000000189A926F8
	
		// Methods
		protected Exception GetException(Exception e) => default; // 0x0000000189A91EE4-0x0000000189A91FC8
		protected abstract bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result);
		public override int Read(byte[] buffer, int offset, int count) => default; // 0x0000000189A91FC8-0x0000000189A922EC
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cb, object state) => default; // 0x0000000189A917D0-0x0000000189A919F4
		public override int EndRead(IAsyncResult r) => default; // 0x0000000189A91C2C-0x0000000189A91D58
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cb, object state) => default; // 0x0000000189A919F4-0x0000000189A91C18
		public override void EndWrite(IAsyncResult r) {} // 0x0000000189A91D58-0x0000000189A91E68
		public override void Write(byte[] buffer, int offset, int count) {} // 0x0000000189A923A4-0x0000000189A92630
		public override void Flush() {} // 0x000000018350B670-0x000000018350B680
		public override System.Threading.Tasks.Task FlushAsync(CancellationToken cancellationToken) => default; // 0x0000000189A91E68-0x0000000189A91EE4
		internal void InternalClose() {} // 0x0000000183D5CAD0-0x0000000183D5CAE0
		protected abstract void Close_internal(ref bool disposed);
		public override void Close() {} // 0x0000000189A91C18-0x0000000189A91C2C
		public override long Seek(long a, SeekOrigin b) => default; // 0x0000000189A922EC-0x0000000189A92348
		public override void SetLength(long a) {} // 0x0000000189A92348-0x0000000189A923A4
	}

	internal class WebConnectionTunnel // TypeDefIndex: 45814
	{
		// Fields
		private HttpWebRequest connectRequest; // 0x20
		private NtlmAuthState ntlmAuthState; // 0x28
	
		// Properties
		public HttpWebRequest Request { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public System.Uri ConnectUri { get; } // 0x0000000181041090-0x00000001810410A0 
		public bool Success { get; private set; } // 0x0000000183D4F1A0-0x0000000183D4F1B0 0x0000000183D4F1B0-0x0000000183D4F1C0
		public bool CloseConnection { get; private set; } // 0x0000000183D4F4C0-0x0000000183D4F4D0 0x0000000183D4F4F0-0x0000000183D4F500
		public int StatusCode { get; private set; } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		private string StatusDescription { get; set; } // 0x000000018388FF30-0x000000018388FF40
		public string[] Challenge { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public WebHeaderCollection Headers { get; private set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public System.Version ProxyVersion { get; private set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public byte[] Data { get; private set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
	
		// Nested types
		private enum NtlmAuthState // TypeDefIndex: 45811
		{
			None = 0,
			Challenge = 1,
			Response = 2
		}
	
		// Constructors
		public WebConnectionTunnel() {} // Dummy constructor
		public WebConnectionTunnel(HttpWebRequest request, System.Uri connectUri) {} // 0x0000000182676770-0x00000001826767A0
	
		// Methods
		internal async System.Threading.Tasks.Task Initialize(Stream stream, CancellationToken cancellationToken) => default; // 0x0000000189A9296C-0x0000000189A92A58
		private async Task<System.ValueTuple<WebHeaderCollection, byte[], int>> ReadHeaders(Stream stream, CancellationToken cancellationToken) => default; // 0x0000000189A92A58-0x0000000189A92B60
		private void FlushContents(Stream stream, int contentLength) {} // 0x0000000189A928F8-0x0000000189A9296C
	}

	internal class WebOperation // TypeDefIndex: 45817
	{
		// Fields
		private CancellationTokenSource cts; // 0x38
		private WebCompletionSource<WebRequestStream> requestTask; // 0x40
		private WebCompletionSource<WebRequestStream> requestWrittenTask; // 0x48
		private WebCompletionSource<WebResponseStream> responseTask; // 0x50
		private WebCompletionSource<System.ValueTuple<bool, WebOperation>> finishedTask; // 0x58
		private WebRequestStream writeStream; // 0x60
		private WebResponseStream responseStream; // 0x68
		private ExceptionDispatchInfo disposedInfo; // 0x70
		private ExceptionDispatchInfo closedInfo; // 0x78
		private WebOperation priorityRequest; // 0x80
		private int requestSent; // 0x88
		private int finished; // 0x8C
	
		// Properties
		public HttpWebRequest Request { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public WebConnection Connection { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public ServicePoint ServicePoint { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public System.Net.BufferOffsetSize WriteBuffer { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public bool IsNtlmChallenge { get; } // 0x0000000183D4EF60-0x0000000183D4EF70 
		public bool Aborted { get => default; } // 0x0000000189A95374-0x0000000189A953D4 
		public bool Closed { get => default; } // 0x0000000189A953D4-0x0000000189A953FC 
		public WebRequestStream WriteStream { get => default; } // 0x0000000189A953FC-0x0000000189A95418 
		internal WebCompletionSource<System.ValueTuple<bool, WebOperation>> Finished { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
	
		// Constructors
		public WebOperation() {} // Dummy constructor
		public WebOperation(HttpWebRequest request, System.Net.BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) {} // 0x0000000189A951C0-0x0000000189A95374
	
		// Methods
		public void Abort() {} // 0x0000000189A93FC0-0x0000000189A94010
		public void Close() {} // 0x0000000189A940F8-0x0000000189A941A0
		private void SetCanceled() {} // 0x0000000189A94B74-0x0000000189A94C3C
		private void SetError(Exception error) {} // 0x0000000189A94D14-0x0000000189A94DB4
		private System.ValueTuple<ExceptionDispatchInfo, bool> SetDisposed(ref ExceptionDispatchInfo field) => default; // 0x0000000189A94C3C-0x0000000189A94D14
		internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken) => default; // 0x0000000189A94010-0x0000000189A94084
		internal void ThrowIfDisposed() {} // 0x0000000189A95140-0x0000000189A9518C
		internal void ThrowIfDisposed(CancellationToken cancellationToken) {} // 0x0000000189A950D4-0x0000000189A95140
		internal void ThrowIfClosedOrDisposed() {} // 0x0000000189A9501C-0x0000000189A95068
		internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) {} // 0x0000000189A95068-0x0000000189A950D4
		private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field) => default; // 0x0000000189A94084-0x0000000189A940F8
		internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) {} // 0x0000000189A94698-0x0000000189A94AE0
		public void SetPriorityRequest(WebOperation operation) {} // 0x0000000189A94DB4-0x0000000189A9501C
		public async Task<Stream> GetRequestStream() => default; // 0x0000000189A9457C-0x0000000189A94650
		internal Task<WebRequestStream> GetRequestStreamInternal() => default; // 0x0000000189A94534-0x0000000189A9457C
		public Task<WebResponseStream> GetResponseStream() => default; // 0x0000000189A94650-0x0000000189A94698
		internal async void Run() {} // 0x0000000189A94AE0-0x0000000189A94B74
		internal void CompleteRequestWritten(WebRequestStream stream, Exception error = null) {} // 0x0000000189A941A0-0x0000000189A94218
		internal void Finish(bool ok, Exception error = null) {} // 0x0000000189A94218-0x0000000189A94534
	}

	internal abstract class WebReadStream : Stream // TypeDefIndex: 45819
	{
		// Fields
		private bool disposed; // 0x38
	
		// Properties
		public WebOperation Operation { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		protected Stream InnerStream { get; } // 0x0000000181003830-0x0000000181003840 
		public override long Length { get; } // 0x0000000189A95E9C-0x0000000189A95EE8 
		public override long Position { get; set; } // 0x0000000189A95EE8-0x0000000189A95F34 0x0000000189A95F34-0x0000000189A95F80
		public override bool CanSeek { get; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool CanRead { get; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool CanWrite { get; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		protected WebReadStream() {} // Dummy constructor
		public WebReadStream(WebOperation operation, Stream innerStream) {} // 0x0000000189A95E30-0x0000000189A95E9C
	
		// Methods
		public override void SetLength(long value) {} // 0x0000000189A95D98-0x0000000189A95DE4
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x0000000189A95D4C-0x0000000189A95D98
		public override void Write(byte[] buffer, int offset, int count) {} // 0x0000000189A95DE4-0x0000000189A95E30
		public override void Flush() {} // 0x0000000189A95828-0x0000000189A95874
		protected Exception GetException(Exception e) => default; // 0x0000000189A95874-0x0000000189A95958
		public override int Read(byte[] buffer, int offset, int size) => default; // 0x0000000189A95A74-0x0000000189A95D4C
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) => default; // 0x0000000189A95418-0x0000000189A9563C
		public override int EndRead(IAsyncResult r) => default; // 0x0000000189A95664-0x0000000189A95790
		public sealed override async Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) => default; // 0x0000000189A95958-0x0000000189A95A74
		protected abstract Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken);
		internal virtual System.Threading.Tasks.Task FinishReading(CancellationToken cancellationToken) => default; // 0x0000000189A95790-0x0000000189A95828
		protected override void Dispose(bool disposing) {} // 0x0000000189A9563C-0x0000000189A95664
	}

	internal class WebRequestStream : WebConnectionStream // TypeDefIndex: 45828
	{
		// Fields
		private static byte[] crlf; // 0x00
		private MemoryStream writeBuffer; // 0x58
		private bool requestWritten; // 0x60
		private bool allowBuffering; // 0x61
		private bool sendChunked; // 0x62
		private WebCompletionSource pendingWrite; // 0x68
		private long totalWritten; // 0x70
		private byte[] headers; // 0x78
		private bool headersSent; // 0x80
		private int completeRequestWritten; // 0x84
		private int chunkTrailerWritten; // 0x88
	
		// Properties
		internal Stream InnerStream { get; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
		public bool KeepAlive { get; } // 0x0000000183D58690-0x0000000183D586A0 
		public override bool CanRead { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool CanWrite { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		internal bool HasWriteBuffer { get => default; } // 0x0000000189A96F80-0x0000000189A96FAC 
		internal int WriteBufferLength { get => default; } // 0x0000000189A96FAC-0x0000000189A97000 
	
		// Constructors
		public WebRequestStream() {} // Dummy constructor
		public WebRequestStream(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) {} // 0x0000000189A96DFC-0x0000000189A96F80
		static WebRequestStream() {} // 0x0000000189A96D6C-0x0000000189A96DFC
	
		// Methods
		internal System.Net.BufferOffsetSize GetWriteBuffer() => default; // 0x0000000189A96284-0x0000000189A96364
		private async System.Threading.Tasks.Task FinishWriting(CancellationToken cancellationToken) => default; // 0x0000000189A961B4-0x0000000189A96284
		public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => default; // 0x0000000189A9680C-0x0000000189A96B0C
		private async System.Threading.Tasks.Task WriteAsyncInner(byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken) => default; // 0x0000000189A966FC-0x0000000189A9680C
		private async System.Threading.Tasks.Task ProcessWrite(byte[] buffer, int offset, int size, CancellationToken cancellationToken) => default; // 0x0000000189A96438-0x0000000189A96538
		private void CheckWriteOverflow(long contentLength, long totalWritten, long size) {} // 0x0000000189A95F80-0x0000000189A96020
		internal async System.Threading.Tasks.Task Initialize(CancellationToken cancellationToken) => default; // 0x0000000189A96364-0x0000000189A96438
		private async System.Threading.Tasks.Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) => default; // 0x0000000189A965CC-0x0000000189A966B0
		internal async System.Threading.Tasks.Task WriteRequestAsync(CancellationToken cancellationToken) => default; // 0x0000000189A96C98-0x0000000189A96D6C
		private async System.Threading.Tasks.Task WriteChunkTrailer_inner(CancellationToken cancellationToken) => default; // 0x0000000189A96B0C-0x0000000189A96BDC
		private async System.Threading.Tasks.Task WriteChunkTrailer() => default; // 0x0000000189A96BDC-0x0000000189A96C98
		internal void KillBuffer() {} // 0x000000018857136C-0x0000000188571380
		public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) => default; // 0x0000000189A96538-0x0000000189A965CC
		protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result) {
			result = default;
			return default;
		} // 0x0000000189A966B0-0x0000000189A966FC
		protected override void Close_internal(ref bool disposed) {} // 0x0000000189A96020-0x0000000189A961B4
	}

	internal class WebResponseStream : WebConnectionStream // TypeDefIndex: 45834
	{
		// Fields
		private WebReadStream innerStream; // 0x58
		private bool nextReadCalled; // 0x60
		private bool bufferedEntireContent; // 0x61
		private WebCompletionSource pendingRead; // 0x68
		private object locker; // 0x70
		private int nestedRead; // 0x78
		private bool read_eof; // 0x7C
	
		// Properties
		public WebRequestStream RequestStream { get; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 
		public WebHeaderCollection Headers { get; private set; } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000184274DA0-0x0000000184274DB4
		public HttpStatusCode StatusCode { get; private set; } // 0x0000000183D4FB60-0x0000000183D4FB70 0x0000000183D4FB70-0x0000000183D4FB80
		public string StatusDescription { get; private set; } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		public System.Version Version { get; private set; } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
		public bool KeepAlive { get; private set; } // 0x00000001811B9C10-0x00000001811B9C20 0x00000001811B9C20-0x00000001811B9C30
		public override bool CanRead { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override bool CanWrite { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		private bool ChunkedRead { get; set; } // 0x0000000183D5AB90-0x0000000183D5ABA0 0x0000000183D5ABB0-0x0000000183D5ABC0
		private bool ExpectContent { get => default; } // 0x0000000189AAB558-0x0000000189AAB5DC 
	
		// Constructors
		public WebResponseStream() {} // Dummy constructor
		public WebResponseStream(WebRequestStream request) {} // 0x0000000189AAB4D0-0x0000000189AAB558
	
		// Methods
		public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => default; // 0x0000000189AAB294-0x0000000189AAB3B0
		private Task<int> ProcessRead(byte[] buffer, int offset, int size, CancellationToken cancellationToken) => default; // 0x0000000189AAAE60-0x0000000189AAB0C0
		protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result) {
			result = default;
			return default;
		} // 0x0000000189AAB3B0-0x0000000189AAB44C
		private void Initialize(System.Net.BufferOffsetSize buffer) {} // 0x0000000189AAA8B0-0x0000000189AAAE60
		private async Task<byte[]> ReadAllAsyncInner(CancellationToken cancellationToken) => default; // 0x0000000189AAB0C0-0x0000000189AAB1B0
		internal async System.Threading.Tasks.Task ReadAllAsync(bool resending, CancellationToken cancellationToken) => default; // 0x0000000189AAB1B0-0x0000000189AAB294
		public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => default; // 0x0000000189AAB44C-0x0000000189AAB4D0
		protected override void Close_internal(ref bool disposed) {} // 0x0000000189AA9CF8-0x0000000189AA9D74
		private WebException GetReadException(WebExceptionStatus status, Exception error, string where) => default; // 0x0000000189AA9D74-0x0000000189AA9F90
		internal async System.Threading.Tasks.Task InitReadAsync(CancellationToken cancellationToken) => default; // 0x0000000189AAA7DC-0x0000000189AAA8B0
		private bool GetResponse(System.Net.BufferOffsetSize buffer, ref int pos, ref System.Net.ReadState state) => default; // 0x0000000189AA9F90-0x0000000189AAA7DC
	}
}

namespace System.Net.Cache
{
	internal abstract class RequestCache // TypeDefIndex: 45876
	{
		// Fields
		internal static readonly char[] LineSplits; // 0x00
	
		// Constructors
		protected RequestCache() {} // Dummy constructor
		static RequestCache() {} // 0x0000000189A9AEE0-0x0000000189A9AF74
	}

	internal sealed class RequestCacheManager // TypeDefIndex: 45877
	{
		// Fields
		private static RequestCachingSectionInternal s_CacheConfigSettings; // 0x00
		private static readonly RequestCacheBinding s_BypassCacheBinding; // 0x08
		private static RequestCacheBinding s_DefaultGlobalBinding; // 0x10
		private static RequestCacheBinding s_DefaultHttpBinding; // 0x18
		private static RequestCacheBinding s_DefaultFtpBinding; // 0x20
	
		// Constructors
		public RequestCacheManager() {} // Dummy constructor
		static RequestCacheManager() {} // 0x0000000189A9ACB4-0x0000000189A9AD70
	
		// Methods
		internal static RequestCacheBinding GetBinding(string internedScheme) => default; // 0x0000000189A9A938-0x0000000189A9AB1C
		private static void LoadConfigSettings() {} // 0x0000000189A9AB1C-0x0000000189A9ACB4
	}

	internal class RequestCacheValidator // TypeDefIndex: 45878
	{
		// Constructors
		public RequestCacheValidator() {} // Dummy constructor
	
		// Methods
		public object CreateValidator() => default; // 0x0000000189A9AE94-0x0000000189A9AEE0
	}

	internal class RequestCachingSectionInternal // TypeDefIndex: 45879
	{
		// Fields
		public readonly bool DisableAllCaching; // 0x10
	
		// Constructors
		public RequestCachingSectionInternal() {} // 0x0000000181168960-0x0000000181168970
	}

	internal class RequestCacheBinding // TypeDefIndex: 45880
	{
		// Fields
		private RequestCache m_RequestCache; // 0x10
		private RequestCacheValidator m_CacheValidator; // 0x18
		private RequestCachePolicy m_Policy; // 0x20
	
		// Properties
		internal RequestCache Cache { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		internal RequestCacheValidator Validator { get => default; } // 0x0000000181041090-0x00000001810410A0 
		internal RequestCachePolicy Policy { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public RequestCacheBinding() {} // Dummy constructor
		internal RequestCacheBinding(RequestCache requestCache, RequestCacheValidator cacheValidator, RequestCachePolicy policy) {} // 0x000000018285BDC0-0x000000018285BE00
	}

	public enum RequestCacheLevel // TypeDefIndex: 45881
	{
		Default = 0,
		BypassCache = 1,
		CacheOnly = 2,
		CacheIfAvailable = 3,
		Revalidate = 4,
		Reload = 5,
		NoCacheNoStore = 6
	}

	public class RequestCachePolicy // TypeDefIndex: 45882
	{
		// Fields
		private RequestCacheLevel m_Level; // 0x10
	
		// Properties
		public RequestCacheLevel Level { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
	
		// Constructors
		public RequestCachePolicy() {} // Dummy constructor
		public RequestCachePolicy(RequestCacheLevel level) {} // 0x0000000189A9ADE0-0x0000000189A9AE48
	
		// Methods
		public override string ToString() => default; // 0x0000000189A9AD70-0x0000000189A9ADE0
	}

	internal class RequestCacheProtocol // TypeDefIndex: 45883
	{
		// Constructors
		public RequestCacheProtocol() {} // Dummy constructor
		public RequestCacheProtocol(object arg1, object arg2) {} // 0x0000000189A9AE48-0x0000000189A9AE94
	}
}

namespace System.Net.Configuration
{
	internal sealed class DefaultProxySectionInternal // TypeDefIndex: 45874
	{
		// Fields
		private IWebProxy webProxy; // 0x10
		private static object classSyncObject; // 0x00
	
		// Properties
		internal static object ClassSyncObject { get => default; } // 0x0000000189A9803C-0x0000000189A980C8 
		internal IWebProxy WebProxy { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public DefaultProxySectionInternal() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private static IWebProxy GetDefaultProxy_UsingOldMonoCode() => default; // 0x0000000189A97E00-0x0000000189A97E08
		private static IWebProxy GetSystemWebProxy() => default; // 0x0000000189A97E00-0x0000000189A97E08
		internal static DefaultProxySectionInternal GetSection() => default; // 0x0000000189A97E08-0x0000000189A9803C
	}

	internal sealed class SettingsSectionInternal // TypeDefIndex: 45875
	{
		// Fields
		private static readonly SettingsSectionInternal instance; // 0x00
		internal readonly bool HttpListenerUnescapeRequestUrl; // 0x10
		internal readonly IPProtectionLevel IPProtectionLevel; // 0x14
	
		// Properties
		internal static SettingsSectionInternal Section { get => default; } // 0x0000000189A9AF74-0x0000000189A9AFC4 
		internal bool Ipv6Enabled { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		public SettingsSectionInternal() {} // 0x0000000183D73120-0x0000000183D73130
		static SettingsSectionInternal() {} // 0x0000000183D024D0-0x0000000183D02540
	}

	public sealed class BypassElement : ConfigurationElement // TypeDefIndex: 46207
	{
		// Constructors
		public BypassElement() {} // Dummy constructor
	}

	[ConfigurationCollection(typeof(BypassElement))]
	[DefaultMember("Item")]
	public sealed class BypassElementCollection : ConfigurationElementCollection // TypeDefIndex: 46208
	{
		// Constructors
		public BypassElementCollection() {} // 0x0000000189A115EC-0x0000000189A1161C
	}

	public sealed class ConnectionManagementElement : ConfigurationElement // TypeDefIndex: 46209
	{
		// Constructors
		public ConnectionManagementElement() {} // Dummy constructor
	}

	[ConfigurationCollection(typeof(ConnectionManagementElement))]
	[DefaultMember("Item")]
	public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection // TypeDefIndex: 46210
	{
		// Constructors
		public ConnectionManagementElementCollection() {} // 0x0000000189A11AB4-0x0000000189A11AE4
	}

	public sealed class ConnectionManagementSection : ConfigurationSection // TypeDefIndex: 46211
	{
		// Properties
		protected override ConfigurationPropertyCollection Properties { get => default; } // 0x0000000189A11B14-0x0000000189A11B44 
	
		// Constructors
		public ConnectionManagementSection() {} // 0x0000000189A11AE4-0x0000000189A11B14
	}

	public sealed class DefaultProxySection : ConfigurationSection // TypeDefIndex: 46212
	{
		// Properties
		protected override ConfigurationPropertyCollection Properties { get => default; } // 0x0000000189A128A0-0x0000000189A128D0 
	
		// Constructors
		public DefaultProxySection() {} // 0x0000000189A12870-0x0000000189A128A0
	
		// Methods
		protected override void Reset(ConfigurationElement parentElement) {} // 0x0000000189A12840-0x0000000189A12870
	}

	public sealed class ProxyElement : ConfigurationElement // TypeDefIndex: 46213
	{
		// Properties
		protected override ConfigurationPropertyCollection Properties { get => default; } // 0x0000000189A1C4D8-0x0000000189A1C508 
	
		// Constructors
		public ProxyElement() {} // 0x0000000189A1C4A8-0x0000000189A1C4D8
	}

	public sealed class HttpWebRequestElement : ConfigurationElement // TypeDefIndex: 46214
	{
		// Properties
		protected override ConfigurationPropertyCollection Properties { get => default; } // 0x0000000189A16B4C-0x0000000189A16B7C 
	
		// Constructors
		public HttpWebRequestElement() {} // 0x0000000189A16B1C-0x0000000189A16B4C
	}

	public sealed class Ipv6Element : ConfigurationElement // TypeDefIndex: 46215
	{
		// Properties
		protected override ConfigurationPropertyCollection Properties { get => default; } // 0x0000000189A17404-0x0000000189A17434 
	
		// Constructors
		public Ipv6Element() {} // 0x0000000189A173D4-0x0000000189A17404
	}

	public sealed class NetSectionGroup : ConfigurationSectionGroup // TypeDefIndex: 46216
	{
		// Constructors
		public NetSectionGroup() {} // 0x0000000189A1A530-0x0000000189A1A560
	}

	public sealed class SettingsSection : ConfigurationSection // TypeDefIndex: 46217
	{
		// Properties
		protected override ConfigurationPropertyCollection Properties { get => default; } // 0x0000000189A1CBAC-0x0000000189A1CBDC 
	
		// Constructors
		public SettingsSection() {} // 0x0000000189A1CB7C-0x0000000189A1CBAC
	}

	public sealed class PerformanceCountersElement : ConfigurationElement // TypeDefIndex: 46218
	{
		// Properties
		protected override ConfigurationPropertyCollection Properties { get => default; } // 0x0000000189A1C478-0x0000000189A1C4A8 
	
		// Constructors
		public PerformanceCountersElement() {} // 0x0000000189A1C448-0x0000000189A1C478
	}

	public sealed class ServicePointManagerElement : ConfigurationElement // TypeDefIndex: 46219
	{
		// Properties
		protected override ConfigurationPropertyCollection Properties { get => default; } // 0x0000000189A1CB4C-0x0000000189A1CB7C 
	
		// Constructors
		public ServicePointManagerElement() {} // 0x0000000189A1CB1C-0x0000000189A1CB4C
	}

	public sealed class SocketElement : ConfigurationElement // TypeDefIndex: 46220
	{
		// Properties
		protected override ConfigurationPropertyCollection Properties { get => default; } // 0x0000000189A1CC0C-0x0000000189A1CC3C 
	
		// Constructors
		public SocketElement() {} // 0x0000000189A1CBDC-0x0000000189A1CC0C
	}

	public sealed class WebProxyScriptElement : ConfigurationElement // TypeDefIndex: 46221
	{
		// Properties
		protected override ConfigurationPropertyCollection Properties { get => default; } // 0x0000000189A1D78C-0x0000000189A1D7BC 
	
		// Constructors
		public WebProxyScriptElement() {} // 0x0000000189A1D75C-0x0000000189A1D78C
	}

	public sealed class WebRequestModulesSection : ConfigurationSection // TypeDefIndex: 46222
	{
		// Properties
		protected override ConfigurationPropertyCollection Properties { get => default; } // 0x0000000189A1D81C-0x0000000189A1D84C 
	
		// Constructors
		public WebRequestModulesSection() {} // 0x0000000189A1D7EC-0x0000000189A1D81C
	}

	[ConfigurationCollection(typeof(WebRequestModuleElement))]
	[DefaultMember("Item")]
	public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection // TypeDefIndex: 46223
	{
		// Constructors
		public WebRequestModuleElementCollection() {} // 0x0000000189A1D7BC-0x0000000189A1D7EC
	}

	public sealed class WebRequestModuleElement : ConfigurationElement // TypeDefIndex: 46224
	{
		// Constructors
		public WebRequestModuleElement() {} // Dummy constructor
	}
}

namespace System.Net.Mail
{
	internal static class DomainLiteralReader // TypeDefIndex: 45957
	{
		// Methods
		internal static int ReadReverse(string data, int index) => default; // 0x00000001899E6ECC-0x00000001899E714C
	}

	internal static class DotAtomReader // TypeDefIndex: 45958
	{
		// Methods
		internal static int ReadReverse(string data, int index) => default; // 0x00000001899E714C-0x00000001899E73D8
	}

	internal static class MailAddressParser // TypeDefIndex: 45959
	{
		// Methods
		internal static MailAddress ParseAddress(string data) => default; // 0x00000001899E7970-0x00000001899E799C
		private static MailAddress ParseAddress(string data, bool expectMultipleAddresses, ref int index) => default; // 0x00000001899E763C-0x00000001899E7970
		private static int ReadCfwsAndThrowIfIncomplete(string data, int index) => default; // 0x00000001899E7EF8-0x00000001899E7F64
		private static string ParseDomain(string data, ref int index) => default; // 0x00000001899E7B80-0x00000001899E7C60
		private static string ParseLocalPart(string data, ref int index, bool expectAngleBracket, bool expectMultipleAddresses) => default; // 0x00000001899E7C60-0x00000001899E7EF8
		private static string ParseDisplayName(string data, ref int index, bool expectMultipleAddresses) => default; // 0x00000001899E799C-0x00000001899E7B80
		internal static string NormalizeOrThrow(string input) => default; // 0x00000001899E7558-0x00000001899E763C
	}

	internal static class QuotedPairReader // TypeDefIndex: 45960
	{
		// Methods
		internal static int CountQuotedChars(string data, int index, bool permitUnicodeEscaping) => default; // 0x00000001899EBF9C-0x00000001899EC11C
		private static int CountBackslashes(string data, int index) => default; // 0x00000001899EBF0C-0x00000001899EBF9C
	}

	internal static class QuotedStringFormatReader // TypeDefIndex: 45961
	{
		// Methods
		internal static int ReadReverseQuoted(string data, int index, bool permitUnicode) => default; // 0x00000001899EC1AC-0x00000001899EC3DC
		internal static int ReadReverseUnQuoted(string data, int index, bool permitUnicode, bool expectCommaDelimiter) => default; // 0x00000001899EC3DC-0x00000001899EC55C
		private static bool IsValidQtext(bool allowUnicode, char ch) => default; // 0x00000001899EC11C-0x00000001899EC1AC
	}

	internal static class WhitespaceReader // TypeDefIndex: 45962
	{
		// Methods
		internal static int ReadFwsReverse(string data, int index) => default; // 0x00000001899F7258-0x00000001899F76DC
		internal static int ReadCfwsReverse(string data, int index) => default; // 0x00000001899F6ED0-0x00000001899F7258
	}

	public class MailAddress // TypeDefIndex: 45963
	{
		// Fields
		private readonly Encoding _displayNameEncoding; // 0x10
		private readonly string _displayName; // 0x18
		private readonly string _userName; // 0x20
		private readonly string _host; // 0x28
		private static readonly EncodedStreamFactory s_encoderFactory; // 0x00
	
		// Properties
		public string DisplayName { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public string Address { get => default; } // 0x00000001899E844C-0x00000001899E8490 
		private string SmtpAddress { get => default; } // 0x00000001899E8490-0x00000001899E84EC 
	
		// Constructors
		public MailAddress() {} // Dummy constructor
		internal MailAddress(string displayName, string userName, string domain) {} // 0x00000001899E83B8-0x00000001899E844C
		public MailAddress(string address) {} // 0x00000001899E8398-0x00000001899E83B8
		public MailAddress(string address, string displayName, Encoding displayNameEncoding) {} // 0x00000001899E80E8-0x00000001899E8398
		static MailAddress() {} // 0x00000001899E8078-0x00000001899E80E8
	
		// Methods
		public override string ToString() => default; // 0x00000001899E7FF0-0x00000001899E8078
		public override bool Equals(object value) => default; // 0x00000001899E7F64-0x00000001899E7FC0
		public override int GetHashCode() => default; // 0x00000001899E7FC0-0x00000001899E7FF0
	}
}

namespace System.Net.Mime
{
	internal static class MailBnfHelper // TypeDefIndex: 45955
	{
		// Fields
		internal static readonly bool[] Atext; // 0x00
		internal static readonly bool[] Qtext; // 0x08
		internal static readonly bool[] Dtext; // 0x10
		internal static readonly bool[] Ftext; // 0x18
		internal static readonly bool[] Ttext; // 0x20
		internal static readonly bool[] Ctext; // 0x28
		internal static readonly int Ascii7bitMaxValue; // 0x30
		internal static readonly char Quote; // 0x34
		internal static readonly char Space; // 0x36
		internal static readonly char Tab; // 0x38
		internal static readonly char CR; // 0x3A
		internal static readonly char LF; // 0x3C
		internal static readonly char StartComment; // 0x3E
		internal static readonly char EndComment; // 0x40
		internal static readonly char Backslash; // 0x42
		internal static readonly char At; // 0x44
		internal static readonly char EndAngleBracket; // 0x46
		internal static readonly char StartAngleBracket; // 0x48
		internal static readonly char StartSquareBracket; // 0x4A
		internal static readonly char EndSquareBracket; // 0x4C
		internal static readonly char Comma; // 0x4E
		internal static readonly char Dot; // 0x50
		private static readonly char[] s_colonSeparator; // 0x58
		private static string[] s_months; // 0x60
	
		// Constructors
		static MailBnfHelper() {} // 0x00000001899E8B18-0x00000001899E8FF0
	
		// Methods
		private static bool[] CreateCharactersAllowedInAtoms() => default; // 0x00000001899E84EC-0x00000001899E8684
		private static bool[] CreateCharactersAllowedInQuotedStrings() => default; // 0x00000001899E88B8-0x00000001899E8984
		private static bool[] CreateCharactersAllowedInDomainLiterals() => default; // 0x00000001899E876C-0x00000001899E8838
		private static bool[] CreateCharactersAllowedInHeaderNames() => default; // 0x00000001899E8838-0x00000001899E88B8
		private static bool[] CreateCharactersAllowedInTokens() => default; // 0x00000001899E8984-0x00000001899E8A7C
		private static bool[] CreateCharactersAllowedInComments() => default; // 0x00000001899E8684-0x00000001899E876C
		internal static bool IsAllowedWhiteSpace(char c) => default; // 0x00000001899E8A7C-0x00000001899E8B18
	}

	internal class EncodedStreamFactory // TypeDefIndex: 45956
	{
		// Constructors
		public EncodedStreamFactory() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace System.Net.NetworkInformation
{
	public enum DuplicateAddressDetectionState // TypeDefIndex: 45835
	{
		Invalid = 0,
		Tentative = 1,
		Duplicate = 2,
		Deprecated = 3,
		Preferred = 4
	}

	public abstract class IPAddressInformation // TypeDefIndex: 45836
	{
		// Properties
		public abstract IPAddress Address { get; }
	
		// Constructors
		protected IPAddressInformation() {} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class IPGlobalProperties // TypeDefIndex: 45837
	{
		// Properties
		public abstract string DomainName { get; }
	
		// Constructors
		protected IPGlobalProperties() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static IPGlobalProperties GetIPGlobalProperties() => default; // 0x0000000189A98124-0x0000000189A9812C
		internal static IPGlobalProperties InternalGetIPGlobalProperties() => default; // 0x0000000189A98124-0x0000000189A9812C
	}

	public abstract class IPInterfaceProperties // TypeDefIndex: 45838
	{
		// Properties
		public abstract UnicastIPAddressInformationCollection UnicastAddresses { get; }
	
		// Constructors
		protected IPInterfaceProperties() {} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class IPv4InterfaceStatistics // TypeDefIndex: 45839
	{
		// Constructors
		protected IPv4InterfaceStatistics() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class NetworkInformationException : Win32Exception // TypeDefIndex: 45840
	{
		// Constructors
		public NetworkInformationException() {} // 0x0000000189A9812C-0x0000000189A98180
		public NetworkInformationException(int errorCode) {} // 0x0000000189A98180-0x0000000189A98188
		protected NetworkInformationException(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x00000001899F4EC0-0x00000001899F4EE0
	}

	public abstract class NetworkInterface // TypeDefIndex: 45841
	{
		// Properties
		public virtual OperationalStatus OperationalStatus { get; } // 0x0000000189A982C4-0x0000000189A98310 
		public virtual NetworkInterfaceType NetworkInterfaceType { get; } // 0x0000000189A98278-0x0000000189A982C4 
	
		// Constructors
		protected NetworkInterface() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static NetworkInterface[] GetAllNetworkInterfaces() => default; // 0x0000000189A981EC-0x0000000189A9822C
		public virtual IPInterfaceProperties GetIPProperties() => default; // 0x0000000189A9822C-0x0000000189A98278
	}

	public enum NetworkInterfaceComponent // TypeDefIndex: 45842
	{
		IPv4 = 0,
		IPv6 = 1
	}

	public enum OperationalStatus // TypeDefIndex: 45843
	{
		Up = 1,
		Down = 2,
		Testing = 3,
		Unknown = 4,
		Dormant = 5,
		NotPresent = 6,
		LowerLayerDown = 7
	}

	public enum PrefixOrigin // TypeDefIndex: 45844
	{
		Other = 0,
		Manual = 1,
		WellKnown = 2,
		Dhcp = 3,
		RouterAdvertisement = 4
	}

	public enum SuffixOrigin // TypeDefIndex: 45845
	{
		Other = 0,
		Manual = 1,
		WellKnown = 2,
		OriginDhcp = 3,
		LinkLayerAddress = 4,
		Random = 5
	}

	public abstract class UnicastIPAddressInformation : IPAddressInformation // TypeDefIndex: 45846
	{
		// Constructors
		protected UnicastIPAddressInformation() {} // 0x000000018350B670-0x000000018350B680
	}

	[DefaultMember("Item")]
	public class UnicastIPAddressInformationCollection : ICollection<UnicastIPAddressInformation> // TypeDefIndex: 45847
	{
		// Fields
		private Collection<UnicastIPAddressInformation> addresses; // 0x10
	
		// Properties
		public virtual int Count { get => default; } // 0x0000000189AA9CB0-0x0000000189AA9CF8 
		public virtual bool IsReadOnly { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		protected internal UnicastIPAddressInformationCollection() {} // 0x0000000189AA9C38-0x0000000189AA9CB0
	
		// Methods
		public virtual void CopyTo(UnicastIPAddressInformation[] array, int offset) {} // 0x0000000189AA9ACC-0x0000000189AA9B30
		public virtual void Add(UnicastIPAddressInformation address) {} // 0x0000000189AA99B0-0x0000000189AA9A14
		internal void InternalAdd(UnicastIPAddressInformation address) {} // 0x0000000189AA9B78-0x0000000189AA9BCC
		public virtual bool Contains(UnicastIPAddressInformation address) => default; // 0x0000000189AA9A78-0x0000000189AA9ACC
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189AA9C30-0x0000000189AA9C38
		public virtual IEnumerator<UnicastIPAddressInformation> GetEnumerator() => default; // 0x0000000189AA9B30-0x0000000189AA9B78
		public virtual bool Remove(UnicastIPAddressInformation address) => default; // 0x0000000189AA9BCC-0x0000000189AA9C30
		public virtual void Clear() {} // 0x0000000189AA9A14-0x0000000189AA9A78
	}

	public enum NetworkInterfaceType // TypeDefIndex: 45848
	{
		Unknown = 1,
		Ethernet = 6,
		TokenRing = 9,
		Fddi = 15,
		BasicIsdn = 20,
		PrimaryIsdn = 21,
		Ppp = 23,
		Loopback = 24,
		Ethernet3Megabit = 26,
		Slip = 28,
		Atm = 37,
		GenericModem = 48,
		FastEthernetT = 62,
		Isdn = 63,
		FastEthernetFx = 69,
		Wireless80211 = 71,
		AsymmetricDsl = 94,
		RateAdaptDsl = 95,
		SymmetricDsl = 96,
		VeryHighSpeedDsl = 97,
		IPOverAtm = 114,
		GigabitEthernet = 117,
		Tunnel = 131,
		MultiRateSymmetricDsl = 143,
		HighPerformanceSerialBus = 144,
		Wman = 237,
		Wwanpp = 243,
		Wwanpp2 = 244
	}

	public enum NetBiosNodeType // TypeDefIndex: 45849
	{
		Unknown = 0,
		Broadcast = 1,
		Peer2Peer = 2,
		Mixed = 4,
		Hybrid = 8
	}

	internal static class IPGlobalPropertiesFactoryPal // TypeDefIndex: 45850
	{
		// Methods
		public static IPGlobalProperties Create() => default; // 0x0000000189A980C8-0x0000000189A98124
	}

	internal static class SystemNetworkInterface // TypeDefIndex: 45851
	{
		// Fields
		private static readonly NetworkInterfaceFactory nif; // 0x00
	
		// Constructors
		static SystemNetworkInterface() {} // 0x0000000189AA2100-0x0000000189AA2150
	
		// Methods
		public static NetworkInterface[] GetNetworkInterfaces() => default; // 0x0000000189AA2018-0x0000000189AA2100
	}

	internal abstract class NetworkInterfaceFactory // TypeDefIndex: 45852
	{
		// Constructors
		protected NetworkInterfaceFactory() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract NetworkInterface[] GetAllNetworkInterfaces();
		public static NetworkInterfaceFactory Create() => default; // 0x0000000189A981E4-0x0000000189A981EC
	}

	internal static class NetworkInterfaceFactoryPal // TypeDefIndex: 45853
	{
		// Methods
		public static NetworkInterfaceFactory Create() => default; // 0x0000000189A98188-0x0000000189A981E4
	}

	internal class Win32IPGlobalProperties : IPGlobalProperties // TypeDefIndex: 45854
	{
		// Properties
		public override string DomainName { get => default; } // 0x0000000189AAB618-0x0000000189AAB638 
	
		// Constructors
		public Win32IPGlobalProperties() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class Win32IPGlobalPropertiesFactoryPal // TypeDefIndex: 45855
	{
		// Methods
		public static IPGlobalProperties Create() => default; // 0x0000000189AAB5DC-0x0000000189AAB618
	}

	internal class Win32IPInterfaceProperties2 : IPInterfaceProperties // TypeDefIndex: 45856
	{
		// Fields
		private readonly Win32_IP_ADAPTER_ADDRESSES addr; // 0x10
		private readonly Win32_MIB_IFROW mib4; // 0x118
		private readonly Win32_MIB_IFROW mib6; // 0x188
	
		// Properties
		public override UnicastIPAddressInformationCollection UnicastAddresses { get => default; } // 0x0000000189AAB918-0x0000000189AAB9C4 
	
		// Constructors
		public Win32IPInterfaceProperties2() {} // Dummy constructor
		public Win32IPInterfaceProperties2(Win32_IP_ADAPTER_ADDRESSES addr, Win32_MIB_IFROW mib4, Win32_MIB_IFROW mib6) {} // 0x0000000189AAB7D4-0x0000000189AAB918
	
		// Methods
		private static UnicastIPAddressInformationCollection Win32FromUnicast(IntPtr ptr) => default; // 0x0000000189AAB638-0x0000000189AAB7D4
	}

	internal class Win32IPv4InterfaceStatistics : IPv4InterfaceStatistics // TypeDefIndex: 45857
	{
		// Fields
		private Win32_MIB_IFROW info; // 0x10
	
		// Constructors
		public Win32IPv4InterfaceStatistics() {} // Dummy constructor
		public Win32IPv4InterfaceStatistics(Win32_MIB_IFROW info) {} // 0x0000000189AAB9C4-0x0000000189AABA04
	}

	internal class Win32NetworkInterfaceAPI : NetworkInterfaceFactory // TypeDefIndex: 45858
	{
		// Constructors
		public Win32NetworkInterfaceAPI() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private static extern int GetAdaptersAddresses(uint family, uint flags, IntPtr reserved, IntPtr info, ref int size); // 0x0000000189AAC284-0x0000000189AAC338
		private static Win32_IP_ADAPTER_ADDRESSES[] GetAdaptersAddresses() => default; // 0x0000000189AABFC8-0x0000000189AAC284
		public override NetworkInterface[] GetAllNetworkInterfaces() => default; // 0x0000000189AAC338-0x0000000189AAC4AC
	}

	internal sealed class Win32NetworkInterface2 : NetworkInterface // TypeDefIndex: 45859
	{
		// Fields
		private Win32_IP_ADAPTER_ADDRESSES addr; // 0x10
		private Win32_MIB_IFROW mib4; // 0x118
		private Win32_MIB_IFROW mib6; // 0x188
		private Win32IPv4InterfaceStatistics ip4stats; // 0x1F8
		private IPInterfaceProperties ip_if_props; // 0x200
	
		// Properties
		public override NetworkInterfaceType NetworkInterfaceType { get => default; } // 0x0000000183D4F0D0-0x0000000183D4F0E0 
		public override OperationalStatus OperationalStatus { get => default; } // 0x0000000183D4EC40-0x0000000183D4EC50 
	
		// Constructors
		public Win32NetworkInterface2() {} // Dummy constructor
		internal Win32NetworkInterface2(Win32_IP_ADAPTER_ADDRESSES addr) {} // 0x0000000189AABB28-0x0000000189AABFC8
	
		// Methods
		private static extern int GetIfEntry(ref Win32_MIB_IFROW row); // 0x0000000189AABA04-0x0000000189AABB28
		public override IPInterfaceProperties GetIPProperties() => default; // 0x0000000183D56BB0-0x0000000183D56BC0
	}

	internal static class Win32NetworkInterfaceFactoryPal // TypeDefIndex: 45860
	{
		// Methods
		public static NetworkInterfaceFactory Create() => default; // 0x0000000189AAC4AC-0x0000000189AAC540
	}

	internal class Win32NetworkInterface // TypeDefIndex: 45861
	{
		// Fields
		private static Win32_FIXED_INFO fixedInfo; // 0x00
		private static bool initialized; // 0x58
	
		// Properties
		public static Win32_FIXED_INFO FixedInfo { get => default; } // 0x0000000189AAC5C8-0x0000000189AAC740 
	
		// Constructors
		public Win32NetworkInterface() {} // Dummy constructor
	
		// Methods
		private static extern int GetNetworkParams(IntPtr ptr, ref int size); // 0x0000000189AAC540-0x0000000189AAC5C8
	}

	internal struct Win32_FIXED_INFO // TypeDefIndex: 45862
	{
		// Fields
		public string HostName; // 0x00
		public string DomainName; // 0x08
		public IntPtr CurrentDnsServer; // 0x10
		public Win32_IP_ADDR_STRING DnsServerList; // 0x18
		public NetBiosNodeType NodeType; // 0x38
		public string ScopeId; // 0x40
		public uint EnableRouting; // 0x48
		public uint EnableProxy; // 0x4C
		public uint EnableDns; // 0x50
	}

	internal struct AlignmentUnion // TypeDefIndex: 45863
	{
		// Fields
		public ulong Alignment; // 0x00
		public int Length; // 0x00
		public int IfIndex; // 0x04
	}

	internal struct Win32_IP_ADAPTER_ADDRESSES // TypeDefIndex: 45864
	{
		// Fields
		public AlignmentUnion Alignment; // 0x00
		public IntPtr Next; // 0x08
		public string AdapterName; // 0x10
		public IntPtr FirstUnicastAddress; // 0x18
		public IntPtr FirstAnycastAddress; // 0x20
		public IntPtr FirstMulticastAddress; // 0x28
		public IntPtr FirstDnsServerAddress; // 0x30
		public string DnsSuffix; // 0x38
		public string Description; // 0x40
		public string FriendlyName; // 0x48
		public byte[] PhysicalAddress; // 0x50
		public uint PhysicalAddressLength; // 0x58
		public uint Flags; // 0x5C
		public uint Mtu; // 0x60
		public NetworkInterfaceType IfType; // 0x64
		public OperationalStatus OperStatus; // 0x68
		public int Ipv6IfIndex; // 0x6C
		public uint[] ZoneIndices; // 0x70
		public IntPtr FirstPrefix; // 0x78
		public ulong TransmitLinkSpeed; // 0x80
		public ulong ReceiveLinkSpeed; // 0x88
		public IntPtr FirstWinsServerAddress; // 0x90
		public IntPtr FirstGatewayAddress; // 0x98
		public uint Ipv4Metric; // 0xA0
		public uint Ipv6Metric; // 0xA4
		public ulong Luid; // 0xA8
		public Win32_SOCKET_ADDRESS Dhcpv4Server; // 0xB0
		public uint CompartmentId; // 0xC0
		public ulong NetworkGuid; // 0xC8
		public int ConnectionType; // 0xD0
		public int TunnelType; // 0xD4
		public Win32_SOCKET_ADDRESS Dhcpv6Server; // 0xD8
		public byte[] Dhcpv6ClientDuid; // 0xE8
		public ulong Dhcpv6ClientDuidLength; // 0xF0
		public ulong Dhcpv6Iaid; // 0xF8
		public IntPtr FirstDnsSuffix; // 0x100
	}

	internal struct Win32_MIB_IFROW // TypeDefIndex: 45865
	{
		// Fields
		public char[] Name; // 0x00
		public int Index; // 0x08
		public NetworkInterfaceType Type; // 0x0C
		public int Mtu; // 0x10
		public uint Speed; // 0x14
		public int PhysAddrLen; // 0x18
		public byte[] PhysAddr; // 0x20
		public uint AdminStatus; // 0x28
		public uint OperStatus; // 0x2C
		public uint LastChange; // 0x30
		public int InOctets; // 0x34
		public int InUcastPkts; // 0x38
		public int InNUcastPkts; // 0x3C
		public int InDiscards; // 0x40
		public int InErrors; // 0x44
		public int InUnknownProtos; // 0x48
		public int OutOctets; // 0x4C
		public int OutUcastPkts; // 0x50
		public int OutNUcastPkts; // 0x54
		public int OutDiscards; // 0x58
		public int OutErrors; // 0x5C
		public int OutQLen; // 0x60
		public int DescrLen; // 0x64
		public byte[] Descr; // 0x68
	}

	internal struct Win32_IP_ADDR_STRING // TypeDefIndex: 45866
	{
		// Fields
		public IntPtr Next; // 0x00
		public string IpAddress; // 0x08
		public string IpMask; // 0x10
		public uint Context; // 0x18
	}

	internal struct Win32LengthFlagsUnion // TypeDefIndex: 45867
	{
		// Fields
		public uint Length; // 0x00
		public uint Flags; // 0x04
	}

	internal struct Win32_IP_ADAPTER_UNICAST_ADDRESS // TypeDefIndex: 45868
	{
		// Fields
		public Win32LengthFlagsUnion LengthFlags; // 0x00
		public IntPtr Next; // 0x08
		public Win32_SOCKET_ADDRESS Address; // 0x10
		public PrefixOrigin PrefixOrigin; // 0x20
		public SuffixOrigin SuffixOrigin; // 0x24
		public DuplicateAddressDetectionState DadState; // 0x28
		public uint ValidLifetime; // 0x2C
		public uint PreferredLifetime; // 0x30
		public uint LeaseLifetime; // 0x34
		public byte OnLinkPrefixLength; // 0x38
	}

	internal struct Win32_SOCKADDR // TypeDefIndex: 45869
	{
		// Fields
		public ushort AddressFamily; // 0x00
		public byte[] AddressData; // 0x08
	}

	internal struct Win32_SOCKET_ADDRESS // TypeDefIndex: 45870
	{
		// Fields
		public IntPtr Sockaddr; // 0x00
		public int SockaddrLength; // 0x08
	
		// Methods
		public IPAddress GetIPAddress() => default; // 0x0000000189AAC8A4-0x0000000189AACA3C
	}

	internal class Win32UnicastIPAddressInformation : UnicastIPAddressInformation // TypeDefIndex: 45871
	{
		// Fields
		private Win32_IP_ADAPTER_UNICAST_ADDRESS info; // 0x10
		private IPAddress ipv4Mask; // 0x50
	
		// Properties
		public override IPAddress Address { get => default; } // 0x0000000189AAC898-0x0000000189AAC8A4 
	
		// Constructors
		public Win32UnicastIPAddressInformation() {} // Dummy constructor
		public Win32UnicastIPAddressInformation(Win32_IP_ADAPTER_UNICAST_ADDRESS info) {} // 0x0000000189AAC808-0x0000000189AAC898
	
		// Methods
		private static IPAddress PrefixLengthToSubnetMask(byte prefixLength, AddressFamily family) => default; // 0x0000000189AAC740-0x0000000189AAC808
	}

	internal static class UnixNetworkInterfaceFactoryPal // TypeDefIndex: 45872
	{
		// Methods
		public static NetworkInterfaceFactory Create() => default; // 0x0000000181002730-0x0000000181002740
	}

	internal static class UnixIPGlobalPropertiesFactoryPal // TypeDefIndex: 45873
	{
		// Methods
		public static IPGlobalProperties Create() => default; // 0x0000000181002730-0x0000000181002740
	}
}

namespace System.Net.Security
{
	internal static class CertificateHelper // TypeDefIndex: 45964
	{
		// Methods
		internal static X509Certificate2 GetEligibleClientCertificate() => default; // 0x00000001899E04B4-0x00000001899E05CC
		internal static X509Certificate2 GetEligibleClientCertificate(System.Security.Cryptography.X509Certificates.X509CertificateCollection candidateCerts) => default; // 0x00000001899E042C-0x00000001899E04B4
		internal static X509Certificate2 GetEligibleClientCertificate(X509Certificate2Collection candidateCerts) => default; // 0x00000001899E02B0-0x00000001899E042C
	}

	public class SslClientAuthenticationOptions // TypeDefIndex: 45965
	{
		// Fields
		private EncryptionPolicy _encryptionPolicy; // 0x10
		private X509RevocationMode _checkCertificateRevocation; // 0x14
		private SslProtocols _enabledSslProtocols; // 0x18
		private bool _allowRenegotiation; // 0x1C
	
		// Properties
		public bool AllowRenegotiation { get => default; } // 0x0000000183D4E9A0-0x0000000183D4E9B0 
		public LocalCertificateSelectionCallback LocalCertificateSelectionCallback { get; set; } // 0x0000000184271930-0x0000000184271940
		public string TargetHost { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get; set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public X509RevocationMode CertificateRevocationCheckMode { set {} } // 0x00000001899EC85C-0x00000001899EC8FC
		public EncryptionPolicy EncryptionPolicy { set {} } // 0x00000001899EC8FC-0x00000001899EC99C
		public SslProtocols EnabledSslProtocols { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
	
		// Constructors
		public SslClientAuthenticationOptions() {} // 0x0000000183D64D20-0x0000000183D64D30
	}

	public abstract class AuthenticatedStream : Stream // TypeDefIndex: 45966
	{
		// Fields
		private Stream _InnerStream; // 0x28
		private bool _LeaveStreamOpen; // 0x30
	
		// Properties
		protected Stream InnerStream { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public abstract bool IsAuthenticated { get; }
	
		// Constructors
		protected AuthenticatedStream() {} // Dummy constructor
		protected AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen) {} // 0x00000001899DF374-0x00000001899DF4E8
	
		// Methods
		protected override void Dispose(bool disposing) {} // 0x00000001899DF2B0-0x00000001899DF374
	}

	public enum AuthenticationLevel // TypeDefIndex: 45967
	{
		None = 0,
		MutualAuthRequested = 1,
		MutualAuthRequired = 2
	}

	public enum EncryptionPolicy // TypeDefIndex: 45968
	{
		RequireEncryption = 0,
		AllowNoEncryption = 1,
		NoEncryption = 2
	}

	public delegate System.Security.Cryptography.X509Certificates.X509Certificate LocalCertificateSelectionCallback(object sender, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers); // TypeDefIndex: 45969; 0x000000018101FB20-0x000000018101FB40

	public delegate bool RemoteCertificateValidationCallback(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, SslPolicyErrors sslPolicyErrors); // TypeDefIndex: 45970; 0x000000018101C850-0x000000018101C870

	[Flags]
	public enum SslPolicyErrors // TypeDefIndex: 45971
	{
		None = 0,
		RemoteCertificateNotAvailable = 1,
		RemoteCertificateNameMismatch = 2,
		RemoteCertificateChainErrors = 4
	}

	internal delegate System.Security.Cryptography.X509Certificates.X509Certificate LocalCertSelectionCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers); // TypeDefIndex: 45972; 0x000000018101C850-0x000000018101C870

	internal delegate System.Security.Cryptography.X509Certificates.X509Certificate ServerCertSelectionCallback(string hostName); // TypeDefIndex: 45973; 0x000000018102B410-0x000000018102B420

	public class SslStream : AuthenticatedStream // TypeDefIndex: 45975
	{
		// Fields
		private MobileTlsProvider provider; // 0x38
		private MonoTlsSettings settings; // 0x40
		private RemoteCertificateValidationCallback validationCallback; // 0x48
		private LocalCertificateSelectionCallback selectionCallback; // 0x50
		private MobileAuthenticatedStream impl; // 0x58
		private bool explicitSettings; // 0x60
	
		// Properties
		internal MobileAuthenticatedStream Impl { get => default; } // 0x00000001899ED4E4-0x00000001899ED500 
		internal string InternalTargetHost { get => default; } // 0x00000001899ED500-0x00000001899ED52C 
		public override bool IsAuthenticated { get => default; } // 0x00000001899ED52C-0x00000001899ED55C 
		public virtual System.Security.Cryptography.X509Certificates.X509Certificate LocalCertificate { get => default; } // 0x00000001899ED58C-0x00000001899ED5B8 
		public override bool CanSeek { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool CanRead { get => default; } // 0x00000001899ED4A4-0x00000001899ED4C4 
		public override bool CanTimeout { get => default; } // 0x00000001897436F0-0x0000000189743714 
		public override bool CanWrite { get => default; } // 0x00000001899ED4C4-0x00000001899ED4E4 
		public override int ReadTimeout { get => default; set {} } // 0x00000001899ED5E8-0x00000001899ED618 0x00000001899ED6AC-0x00000001899ED6E8
		public override int WriteTimeout { get => default; set {} } // 0x00000001899ED618-0x00000001899ED648 0x00000001899ED6E8-0x00000001899ED724
		public override long Length { get => default; } // 0x00000001899ED55C-0x00000001899ED58C 
		public override long Position { get => default; set {} } // 0x00000001899ED5B8-0x00000001899ED5E8 0x00000001899ED648-0x00000001899ED6AC
	
		// Constructors
		public SslStream() {} // Dummy constructor
		public SslStream(Stream innerStream) {} // 0x00000001899ED338-0x00000001899ED344
		public SslStream(Stream innerStream, bool leaveInnerStreamOpen) {} // 0x00000001899ED360-0x00000001899ED3EC
		public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) {} // 0x00000001899ED344-0x00000001899ED360
		public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) {} // 0x00000001899ED3EC-0x00000001899ED4A4
		internal SslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) {} // 0x00000001899ED254-0x00000001899ED338
	
		// Methods
		private static MobileTlsProvider GetProvider() => default; // 0x00000001899ECD78-0x00000001899ECDB4
		private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) {} // 0x00000001899ED070-0x00000001899ED16C
		private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) {} // 0x00000001899ECEC4-0x00000001899ED070
		public virtual void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) {} // 0x00000001899EC9F8-0x00000001899ECA54
		public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) => default; // 0x00000001899ECA54-0x00000001899ECAC4
		public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult) {} // 0x0000000189158220-0x000000018915822C
		public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) => default; // 0x00000001899EC99C-0x00000001899EC9F8
		public override void SetLength(long value) {} // 0x00000001899ED16C-0x00000001899ED1AC
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x00000001899ECE60-0x00000001899ECEC4
		public override System.Threading.Tasks.Task FlushAsync(CancellationToken cancellationToken) => default; // 0x00000001899ECD50-0x00000001899ECD78
		public override void Flush() {} // 0x0000000189741F00-0x0000000189741F24
		private void CheckDisposed() {} // 0x00000001899ECB94-0x00000001899ECBFC
		protected override void Dispose(bool disposing) {} // 0x00000001899ECBFC-0x00000001899ECD14
		public override int Read(byte[] buffer, int offset, int count) => default; // 0x00000001899ECE10-0x00000001899ECE60
		public override void Write(byte[] buffer, int offset, int count) {} // 0x00000001899ED204-0x00000001899ED254
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => default; // 0x00000001899ECDB4-0x00000001899ECE10
		public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => default; // 0x00000001899ED1AC-0x00000001899ED204
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) => default; // 0x00000001899ECAC4-0x00000001899ECB2C
		public override int EndRead(IAsyncResult asyncResult) => default; // 0x00000001899ECD14-0x00000001899ECD50
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) => default; // 0x00000001899ECB2C-0x00000001899ECB94
		public override void EndWrite(IAsyncResult asyncResult) {} // 0x0000000189158220-0x000000018915822C
	}
}

namespace System.Net.Sockets
{
	public class NetworkStream : Stream // TypeDefIndex: 45884
	{
		// Fields
		private readonly Socket _streamSocket; // 0x28
		private readonly bool _ownsSocket; // 0x30
		private bool _readable; // 0x31
		private bool _writeable; // 0x32
		private int _closeTimeout; // 0x34
		private bool _cleanedUp; // 0x38
		private int _currentReadTimeout; // 0x3C
		private int _currentWriteTimeout; // 0x40
	
		// Properties
		public override bool CanRead { get => default; } // 0x0000000183D4F2C0-0x0000000183D4F2D0 
		public override bool CanSeek { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool CanWrite { get => default; } // 0x0000000183D4F630-0x0000000183D4F640 
		public override bool CanTimeout { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override int ReadTimeout { get => default; set {} } // 0x0000000189A9A6D8-0x0000000189A9A740 0x0000000189A9A804-0x0000000189A9A89C
		public override int WriteTimeout { get => default; set {} } // 0x0000000189A9A740-0x0000000189A9A7A8 0x0000000189A9A89C-0x0000000189A9A938
		public override long Length { get => default; } // 0x0000000189A9A620-0x0000000189A9A67C 
		public override long Position { get => default; set {} } // 0x0000000189A9A67C-0x0000000189A9A6D8 0x0000000189A9A7A8-0x0000000189A9A804
		internal Socket InternalSocket { get => default; } // 0x0000000189A9A590-0x0000000189A9A620 
	
		// Constructors
		public NetworkStream() {} // Dummy constructor
		public NetworkStream(Socket socket) {} // 0x0000000189A9A54C-0x0000000189A9A56C
		public NetworkStream(Socket socket, bool ownsSocket) {} // 0x0000000189A9A56C-0x0000000189A9A590
		public NetworkStream(Socket socket, FileAccess access, bool ownsSocket) {} // 0x000000018376EF40-0x000000018376F0B0
	
		// Methods
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x0000000189A99960-0x0000000189A999BC
		public override int Read(byte[] buffer, int offset, int size) => default; // 0x00000001824D06F0-0x00000001824D0880
		public override int Read(Span<byte> destination) => default; // 0x0000000189A996F8-0x0000000189A99960
		public override int ReadByte() => default; // 0x0000000189A9967C-0x0000000189A996F8
		public override void Write(byte[] buffer, int offset, int size) {} // 0x00000001824CFFE0-0x00000001824D0090
		public override void Write(ReadOnlySpan<byte> source) {} // 0x0000000189A9A2E4-0x0000000189A9A54C
		public override void WriteByte(byte value) {} // 0x0000000189A9A278-0x0000000189A9A2E4
		public void Close(int timeout) {} // 0x0000000189A98A78-0x0000000189A98AE8
		protected override void Dispose(bool disposing) {} // 0x0000000182958930-0x00000001829589B0
		~NetworkStream() {} // 0x0000000189190804-0x000000018919087C
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) => default; // 0x0000000189A98310-0x0000000189A986C4
		public override int EndRead(IAsyncResult asyncResult) => default; // 0x0000000189A98AE8-0x0000000189A98D28
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) => default; // 0x0000000189A986C4-0x0000000189A98A78
		public override void EndWrite(IAsyncResult asyncResult) {} // 0x0000000189A98D28-0x0000000189A98F70
		public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) => default; // 0x0000000189A98FB0-0x0000000189A993E0
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) => default; // 0x0000000189A993E0-0x0000000189A9967C
		public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) => default; // 0x0000000189A99BB4-0x0000000189A99FE0
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) => default; // 0x0000000189A99FE0-0x0000000189A9A278
		public override void Flush() {} // 0x000000018350B670-0x000000018350B680
		public override System.Threading.Tasks.Task FlushAsync(CancellationToken cancellationToken) => default; // 0x0000000189A98F70-0x0000000189A98FB0
		public override void SetLength(long value) {} // 0x0000000189A999BC-0x0000000189A99A18
		internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent) {} // 0x0000000189A99A18-0x0000000189A99BB4
	}

	public class Socket : IDisposable // TypeDefIndex: 45895
	{
		// Fields
		private static readonly EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler; // 0x00
		private static readonly EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler; // 0x08
		private static readonly EventHandler<SocketAsyncEventArgs> SendCompletedHandler; // 0x10
		private static readonly TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel; // 0x18
		private static readonly Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel; // 0x20
		private static readonly Task<int> s_zeroTask; // 0x28
		private CachedEventArgs _cachedTaskEventArgs; // 0x10
		private static object s_InternalSyncObject; // 0x30
		internal static bool s_SupportsIPv4; // 0x38
		internal static bool s_SupportsIPv6; // 0x39
		internal static bool s_OSSupportsIPv6; // 0x3A
		internal static bool s_Initialized; // 0x3B
		private static bool s_LoggingEnabled; // 0x3C
		private bool is_closed; // 0x18
		private bool is_listening; // 0x19
		private int linger_timeout; // 0x1C
		private AddressFamily addressFamily; // 0x20
		private SocketType socketType; // 0x24
		private ProtocolType protocolType; // 0x28
		internal SafeSocketHandle m_Handle; // 0x30
		internal EndPoint seed_endpoint; // 0x38
		internal SemaphoreSlim ReadSem; // 0x40
		internal SemaphoreSlim WriteSem; // 0x48
		internal bool is_blocking; // 0x50
		internal bool is_bound; // 0x51
		internal bool is_connected; // 0x52
		private int m_IntCleanedUp; // 0x54
		internal bool connect_in_progress; // 0x58
		private static AsyncCallback AcceptAsyncCallback; // 0x40
		private static IOAsyncCallback BeginAcceptCallback; // 0x48
		private static IOAsyncCallback BeginAcceptReceiveCallback; // 0x50
		private static AsyncCallback ConnectAsyncCallback; // 0x58
		private static IOAsyncCallback BeginConnectCallback; // 0x60
		private static AsyncCallback DisconnectAsyncCallback; // 0x68
		private static IOAsyncCallback BeginDisconnectCallback; // 0x70
		private static AsyncCallback ReceiveAsyncCallback; // 0x78
		private static IOAsyncCallback BeginReceiveCallback; // 0x80
		private static IOAsyncCallback BeginReceiveGenericCallback; // 0x88
		private static AsyncCallback ReceiveFromAsyncCallback; // 0x90
		private static IOAsyncCallback BeginReceiveFromCallback; // 0x98
		private static AsyncCallback SendAsyncCallback; // 0xA0
		private static IOAsyncCallback BeginSendGenericCallback; // 0xA8
		private static AsyncCallback SendToAsyncCallback; // 0xB0
	
		// Properties
		public static bool OSSupportsIPv4 { get => default; } // 0x00000001829417B0-0x0000000182941810 
		public static bool OSSupportsIPv6 { get => default; } // 0x0000000182941810-0x0000000182941870 
		public IntPtr Handle { get => default; } // 0x0000000182959BA0-0x0000000182959BC0 
		public AddressFamily AddressFamily { get => default; } // 0x0000000181003B50-0x0000000181003B60 
		public SocketType SocketType { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public ProtocolType ProtocolType { get => default; } // 0x0000000183D4EB90-0x0000000183D4EBA0 
		public bool ExclusiveAddressUse { get => default; set {} } // 0x0000000189AA1CD8-0x0000000189AA1D2C 0x0000000189AA1F8C-0x0000000189AA2018
		public bool DontFragment { set {} } // 0x000000018293FF20-0x000000018293FF60
		public bool DualMode { get => default; set {} } // 0x0000000189AA1C1C-0x0000000189AA1CD8 0x0000000189AA1EFC-0x0000000189AA1F8C
		private bool IsDualMode { get => default; } // 0x000000018293E380-0x000000018293E3A0 
		private static object InternalSyncObject { get => default; } // 0x0000000183C9CC00-0x0000000183C9CCF0 
		internal bool CleanedUp { get => default; } // 0x00000001824CBE70-0x00000001824CBF80 
		public int Available { get => default; } // 0x00000001824CB930-0x00000001824CB9B0 
		public bool IsBound { get => default; } // 0x0000000183D518F0-0x0000000183D51900 
		public EndPoint LocalEndPoint { get => default; } // 0x0000000189AA1D2C-0x0000000189AA1E10 
		public bool Blocking { get => default; set {} } // 0x0000000183D4F000-0x0000000183D4F010 0x0000000182958490-0x0000000182958530
		public bool Connected { get => default; } // 0x0000000183D58990-0x0000000183D589A0 
		public bool NoDelay { set {} } // 0x000000018293FF60-0x000000018293FFD0
		public EndPoint RemoteEndPoint { get => default; } // 0x0000000189AA1E10-0x0000000189AA1EFC 
		internal static int FamilyHint { get => default; } // 0x0000000182941B50-0x0000000182941BE0 
	
		// Nested types
		private sealed class CachedEventArgs // TypeDefIndex: 45885
		{
			// Fields
			public TaskSocketAsyncEventArgs<Socket> TaskAccept; // 0x10
			public Int32TaskSocketAsyncEventArgs TaskReceive; // 0x18
			public Int32TaskSocketAsyncEventArgs TaskSend; // 0x20
			public AwaitableSocketAsyncEventArgs ValueTaskReceive; // 0x28
			public AwaitableSocketAsyncEventArgs ValueTaskSend; // 0x30
	
			// Constructors
			public CachedEventArgs() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private class TaskSocketAsyncEventArgs<TResult> : SocketAsyncEventArgs // TypeDefIndex: 45886
		{
			// Fields
			internal AsyncTaskMethodBuilder<TResult> _builder;
			internal bool _accessed;
	
			// Constructors
			internal TaskSocketAsyncEventArgs() {}
	
			// Methods
			internal AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(out bool responsibleForReturningToPool) {
				responsibleForReturningToPool = default;
				return default;
			}
		}
	
		private sealed class Int32TaskSocketAsyncEventArgs : TaskSocketAsyncEventArgs<int> // TypeDefIndex: 45887
		{
			// Fields
			internal bool _wrapExceptionsInIOExceptions; // 0xA0
	
			// Constructors
			public Int32TaskSocketAsyncEventArgs() {} // 0x000000018353D170-0x000000018353D1B0
		}
	
		internal sealed class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs, IValueTaskSource, IValueTaskSource<int> // TypeDefIndex: 45889
		{
			// Fields
			internal static readonly AwaitableSocketAsyncEventArgs Reserved; // 0x00
			private static readonly Action<object> s_completedSentinel; // 0x08
			private static readonly Action<object> s_availableSentinel; // 0x10
			private Action<object> _continuation; // 0x80
			private ExecutionContext _executionContext; // 0x88
			private object _scheduler; // 0x90
			private short _token; // 0x98
	
			// Properties
			public bool WrapExceptionsInIOExceptions { get; set; } // 0x0000000183D6E070-0x0000000183D6E080 0x0000000183D6E0C0-0x0000000183D6E0D0
	
			// Constructors
			public AwaitableSocketAsyncEventArgs() {} // 0x0000000189A97D98-0x0000000189A97E00
			static AwaitableSocketAsyncEventArgs() {} // 0x0000000189A97C00-0x0000000189A97D98
	
			// Methods
			public bool Reserve() => default; // 0x0000000189A97980-0x0000000189A979EC
			private void Release() {} // 0x0000000189A97918-0x0000000189A97980
			protected override void OnCompleted(SocketAsyncEventArgs _) {} // 0x0000000189A975D0-0x0000000189A977E8
			public ValueTask<int> ReceiveAsync(Socket socket) => default; // 0x0000000189A977E8-0x0000000189A97918
			public ValueTask SendAsyncForNetworkStream(Socket socket) => default; // 0x0000000189A979EC-0x0000000189A97AD4
			public ValueTaskSourceStatus GetStatus(short token) => default; // 0x0000000189A9712C-0x0000000189A971B0
			public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) {} // 0x0000000189A973F4-0x0000000189A975D0
			private void InvokeContinuation(Action<object> continuation, object state, bool forceAsync) {} // 0x0000000189A971B0-0x0000000189A973F4
			public int GetResult(short token) => default; // 0x0000000189A970D8-0x0000000189A9712C
			void IValueTaskSource.GetResult(short token) {} // 0x0000000189A97AD4-0x0000000189A97B1C
			private void ThrowIncorrectTokenException() {} // 0x0000000189A97B48-0x0000000189A97BA4
			private void ThrowMultipleContinuationsException() {} // 0x0000000189A97BA4-0x0000000189A97C00
			private void ThrowException(SocketError error) {} // 0x0000000189A97B1C-0x0000000189A97B48
			private Exception CreateException(SocketError error) => default; // 0x0000000189A97000-0x0000000189A970D8
		}
	
		private struct WSABUF // TypeDefIndex: 45890
		{
			// Fields
			public int len; // 0x00
			public IntPtr buf; // 0x08
		}
	
		// Constructors
		public Socket() {} // Dummy constructor
		public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) {} // 0x000000018293FB20-0x000000018293FDD0
		internal Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) {} // 0x0000000189AA1B04-0x0000000189AA1C14
		static Socket() {} // 0x000000018353C790-0x000000018353D170
	
		// Methods
		internal System.Threading.Tasks.Task ConnectAsync(IPAddress address, int port) => default; // 0x0000000189A9CEBC-0x0000000189A9D034
		internal ValueTask<int> ReceiveAsync(Memory<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken) => default; // 0x0000000189A9EA08-0x0000000189A9ED04
		private Task<int> ReceiveAsyncApm(Memory<byte> buffer, SocketFlags socketFlags) => default; // 0x0000000189A9E658-0x0000000189A9EA08
		internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken) => default; // 0x0000000189AA03EC-0x0000000189AA06CC
		private Task<int> SendAsyncApm(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags) => default; // 0x0000000189A9FFF4-0x0000000189AA03EC
		private static void CompleteAccept(Socket s, TaskSocketAsyncEventArgs<Socket> saea) {} // 0x0000000189A9CC1C-0x0000000189A9CD60
		private static void CompleteSendReceive(Socket s, Int32TaskSocketAsyncEventArgs saea, bool isReceive) {} // 0x0000000189A9CD60-0x0000000189A9CEBC
		private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = false /* Metadata: 0x01FBA460 */) => default; // 0x0000000189A9DE10-0x0000000189A9DEE4
		private void ReturnSocketAsyncEventArgs(Int32TaskSocketAsyncEventArgs saea, bool isReceive) {} // 0x0000000189A9FF90-0x0000000189A9FFF4
		private void ReturnSocketAsyncEventArgs(TaskSocketAsyncEventArgs<Socket> saea) {} // 0x0000000189A9FF30-0x0000000189A9FF90
		internal bool CanTryAddressFamily(AddressFamily family) => default; // 0x0000000182959C40-0x0000000182959C60
		public void Connect(IPAddress[] addresses, int port) {} // 0x0000000189A9D034-0x0000000189A9D4B8
		public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) => default; // 0x0000000189AA0B6C-0x0000000189AA0BE0
		public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) => default; // 0x00000001824D0090-0x00000001824D0200
		public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) => default; // 0x00000001824D0880-0x00000001824D09B0
		public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) => default; // 0x0000000189A9FD98-0x0000000189A9FE0C
		public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) => default; // 0x0000000189A9E030-0x0000000189A9E040
		public void SetIPProtectionLevel(IPProtectionLevel level) {} // 0x0000000189AA12A0-0x0000000189AA13A8
		public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state) => default; // 0x0000000189A9BBB8-0x0000000189A9BE4C
		public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) => default; // 0x0000000189A9CB68-0x0000000189A9CC0C
		public int EndSend(IAsyncResult asyncResult) => default; // 0x0000000189A9DD2C-0x0000000189A9DD9C
		public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) => default; // 0x0000000189A9C2EC-0x0000000189A9C390
		public int EndReceive(IAsyncResult asyncResult) => default; // 0x0000000189A9DB34-0x0000000189A9DBA4
		internal static void InitializeSockets() {} // 0x0000000182941870-0x0000000182941B30
		public void Dispose() {} // 0x0000000182959AD0-0x0000000182959B30
		~Socket() {} // 0x0000000189A9DD9C-0x0000000189A9DE10
		internal void InternalShutdown(SocketShutdown how) {} // 0x00000001829589B0-0x0000000182958A30
		internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent) {} // 0x0000000189AA1778-0x0000000189AA18EC
		private void SocketDefaults() {} // 0x000000018293FEC0-0x000000018293FF20
		private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error) {
			error = default;
			return default;
		} // 0x0000000184272000-0x0000000184272008
		private static int Available_internal(SafeSocketHandle safeHandle, out int error) {
			error = default;
			return default;
		} // 0x00000001824CB9B0-0x00000001824CBE50
		private static int Available_icall(IntPtr socket, out int error) {
			error = default;
			return default;
		} // 0x00000001842701CC-0x00000001842701D4
		private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) {
			error = default;
			return default;
		} // 0x0000000189A9E290-0x0000000189A9E3AC
		private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error) {
			error = default;
			return default;
		} // 0x0000000189A9E288-0x0000000189A9E290
		private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) {
			error = default;
		} // 0x0000000182958530-0x0000000182958930
		internal static void Blocking_icall(IntPtr socket, bool block, out int error) {
			error = default;
		} // 0x00000001842720C0-0x00000001842720C8
		private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) {
			error = default;
			return default;
		} // 0x0000000189A9FE14-0x0000000189A9FF30
		private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error) {
			error = default;
			return default;
		} // 0x0000000189A9FE0C-0x0000000189A9FE14
		public bool Poll(int microSeconds, SelectMode mode) => default; // 0x0000000189A9E4DC-0x0000000189A9E658
		private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) {
			error = default;
			return default;
		} // 0x0000000189A9E3B4-0x0000000189A9E4DC
		private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error) {
			error = default;
			return default;
		} // 0x0000000189A9E3AC-0x0000000189A9E3B4
		public Socket Accept() => default; // 0x0000000189A9B7E4-0x0000000189A9B924
		internal void Accept(Socket acceptSocket) {} // 0x0000000189A9B924-0x0000000189A9BA48
		public IAsyncResult BeginAccept(AsyncCallback callback, object state) => default; // 0x000000018295A0D0-0x000000018295A220
		public Socket EndAccept(IAsyncResult asyncResult) => default; // 0x0000000189A9D760-0x0000000189A9D78C
		public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) {
			buffer = default;
			bytesTransferred = default;
			return default;
		} // 0x0000000189A9D78C-0x0000000189A9D884
		private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) {
			error = default;
			return default;
		} // 0x0000000189A9B5C8-0x0000000189A9B7E4
		private static IntPtr Accept_icall(IntPtr sock, out int error, bool blocking) {
			error = default;
			return default;
		} // 0x0000000189A9B5C0-0x0000000189A9B5C8
		public void Bind(EndPoint localEP) {} // 0x00000001839D8E00-0x00000001839D8F00
		private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) {
			error = default;
		} // 0x00000001839D8F00-0x00000001839D9010
		private static void Bind_icall(IntPtr sock, SocketAddress sa, out int error) {
			error = default;
		} // 0x0000000184276CFC-0x0000000184276D04
		public void Listen(int backlog) {} // 0x0000000183A4AD90-0x0000000183A4AE30
		private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) {
			error = default;
		} // 0x0000000183A4AE30-0x0000000183A4B100
		private static void Listen_icall(IntPtr sock, int backlog, out int error) {
			error = default;
		} // 0x0000000184276D58-0x0000000184276D60
		public void Connect(IPAddress address, int port) {} // 0x0000000189A9D4B8-0x0000000189A9D540
		public void Connect(EndPoint remoteEP) {} // 0x000000018293E0F0-0x000000018293E320
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state) => default; // 0x000000018295A890-0x000000018295AA50
		public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) => default; // 0x0000000189A9BA48-0x0000000189A9BBB8
		public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state) => default; // 0x0000000189A9BE4C-0x0000000189A9C0FC
		private static bool BeginMConnect(SocketAsyncResult sockares) => default; // 0x000000018293DE60-0x000000018293DFE0
		private static bool BeginSConnect(SocketAsyncResult sockares) => default; // 0x0000000182958100-0x0000000182958490
		public void EndConnect(IAsyncResult asyncResult) {} // 0x00000001838A6D80-0x00000001838A6E20
		private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) {
			error = default;
		} // 0x000000018293E3A0-0x000000018293E4A0
		private static void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking) {
			error = default;
		} // 0x0000000184271FF0-0x0000000184271FF8
		public void Disconnect(bool reuseSocket) {} // 0x0000000189A9D654-0x0000000189A9D760
		public void EndDisconnect(IAsyncResult asyncResult) {} // 0x0000000189A9D884-0x0000000189A9D928
		private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) {
			error = default;
		} // 0x0000000189A9D548-0x0000000189A9D654
		private static void Disconnect_icall(IntPtr sock, bool reuse, out int error) {
			error = default;
		} // 0x0000000189A9D540-0x0000000189A9D548
		public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) {
			errorCode = default;
			return default;
		} // 0x00000001824D09B0-0x00000001824D0AE0
		private int Receive(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) {
			errorCode = default;
			return default;
		} // 0x0000000189A9F5F4-0x0000000189A9F7D4
		[CLSCompliant(false)]
		public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) {
			errorCode = default;
			return default;
		} // 0x0000000189A9F7D4-0x0000000189A9FD98
		public int Receive(Span<byte> buffer, SocketFlags socketFlags, out SocketError errorCode) {
			errorCode = default;
			return default;
		} // 0x0000000189A9F520-0x0000000189A9F5F4
		public int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, out SocketError errorCode) {
			errorCode = default;
			return default;
		} // 0x0000000189AA0BE0-0x0000000189AA0C6C
		public bool ReceiveAsync(SocketAsyncEventArgs e) => default; // 0x0000000189A9ED04-0x0000000189A9EFAC
		public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) {
			errorCode = default;
			return default;
		} // 0x0000000189A9C0FC-0x0000000189A9C2EC
		public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) {
			errorCode = default;
			return default;
		} // 0x0000000189A9DA58-0x0000000189A9DB34
		private static unsafe int Receive_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) {
			error = default;
			return default;
		} // 0x0000000189A9F3FC-0x0000000189A9F520
		private static unsafe int Receive_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) {
			error = default;
			return default;
		} // 0x0000000189A9F3EC-0x0000000189A9F3FC
		private static unsafe int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) {
			error = default;
			return default;
		} // 0x00000001824D0AE0-0x00000001824D0EA0
		private static unsafe int Receive_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) {
			error = default;
			return default;
		} // 0x0000000184270230-0x0000000184270240
		private int ReceiveFrom(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) {
			errorCode = default;
			return default;
		} // 0x0000000189A9F0F0-0x0000000189A9F3EC
		private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares) => default; // 0x0000000189A9D928-0x0000000189A9DA58
		private static unsafe int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) {
			error = default;
			return default;
		} // 0x0000000189A9EFBC-0x0000000189A9F0F0
		private static unsafe int ReceiveFrom_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) {
			error = default;
			return default;
		} // 0x0000000189A9EFAC-0x0000000189A9EFBC
		public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) {
			errorCode = default;
			return default;
		} // 0x00000001824D0200-0x00000001824D0370
		[CLSCompliant(false)]
		public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) {
			errorCode = default;
			return default;
		} // 0x0000000189AA0C6C-0x0000000189AA12A0
		public bool SendAsync(SocketAsyncEventArgs e) => default; // 0x0000000189AA06CC-0x0000000189AA0A38
		public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) {
			errorCode = default;
			return default;
		} // 0x0000000189A9C8DC-0x0000000189A9CB68
		private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) {} // 0x0000000189A9C390-0x0000000189A9C8DC
		public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) {
			errorCode = default;
			return default;
		} // 0x0000000189A9DC50-0x0000000189A9DD2C
		private static unsafe int Send_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) {
			error = default;
			return default;
		} // 0x0000000189AA0A48-0x0000000189AA0B6C
		private static unsafe int Send_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) {
			error = default;
			return default;
		} // 0x0000000189AA0A38-0x0000000189AA0A48
		private static unsafe int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) {
			error = default;
			return default;
		} // 0x00000001824D0370-0x00000001824D06F0
		private static unsafe int Send_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) {
			error = default;
			return default;
		} // 0x0000000184270220-0x0000000184270230
		public int EndSendTo(IAsyncResult asyncResult) => default; // 0x0000000189A9DBA4-0x0000000189A9DC50
		public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) => default; // 0x000000018293E890-0x000000018293EA20
		private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) {
			obj_val = default;
			error = default;
		} // 0x000000018293EA20-0x000000018293F080
		private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) {
			obj_val = default;
			error = default;
		} // 0x0000000184271FF8-0x0000000184272000
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue) {} // 0x0000000189AA13A8-0x0000000189AA1778
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) {} // 0x00000001829400C0-0x0000000182940180
		private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) {
			error = default;
		} // 0x0000000182940180-0x0000000182940990
		private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) {
			error = default;
		} // 0x0000000184272008-0x0000000184272010
		public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) => default; // 0x0000000189A9E040-0x0000000189A9E1E8
		private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error) {
			error = default;
			return default;
		} // 0x0000000189A9DEEC-0x0000000189A9E030
		private static int IOControl_icall(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error) {
			error = default;
			return default;
		} // 0x0000000189A9DEE4-0x0000000189A9DEEC
		public void Close() {} // 0x0000000189A9CC0C-0x0000000189A9CC1C
		public void Close(int timeout) {} // 0x00000001842720A4-0x00000001842720B0
		internal static void Close_icall(IntPtr socket, out int error) {
			error = default;
		} // 0x00000001842720B8-0x00000001842720C0
		public void Shutdown(SocketShutdown how) {} // 0x0000000189AA18EC-0x0000000189AA19FC
		private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) {
			error = default;
		} // 0x0000000182958A30-0x0000000182958E30
		internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error) {
			error = default;
		} // 0x00000001842720B0-0x00000001842720B8
		protected virtual void Dispose(bool disposing) {} // 0x0000000182959B30-0x0000000182959BA0
		private void Linger(IntPtr handle) {} // 0x0000000182959BD0-0x0000000182959C40
		private void ThrowIfDisposedAndClosed() {} // 0x00000001824CBE50-0x00000001824CBE70
		private void ThrowIfBufferNull(byte[] buffer) {} // 0x00000001824D0EA0-0x00000001824D0EC0
		private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size) {} // 0x00000001824D0EC0-0x00000001824D0F10
		private void ThrowIfUdp() {} // 0x000000018293FFD0-0x000000018293FFF0
		private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) => default; // 0x00000001838A6E20-0x00000001838A70A0
		private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) {} // 0x000000018295A220-0x000000018295A320
		private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation) {} // 0x0000000189A9E1E8-0x0000000189A9E288
		private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op) => default; // 0x0000000189AA19FC-0x0000000189AA1B04
		private IPEndPoint RemapIPEndPoint(IPEndPoint input) => default; // 0x000000018293E320-0x000000018293E380
		internal static void cancel_blocking_socket_operation(Thread thread) {} // 0x0000000189AA1C14-0x0000000189AA1C1C
		private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) => default; // 0x000000018232EB60-0x000000018232EB70
		private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) => default; // 0x0000000183D27510-0x0000000183D27550
	}

	[Serializable]
	public class SocketException : Win32Exception // TypeDefIndex: 45896
	{
		// Fields
		[NonSerialized]
		private EndPoint m_EndPoint; // 0x98
	
		// Properties
		public override string Message { get => default; } // 0x0000000189A9B53C-0x0000000189A9B5C0 
		public SocketError SocketErrorCode { get => default; } // 0x0000000183D4FB60-0x0000000183D4FB70 
	
		// Constructors
		public SocketException() {} // 0x0000000189A9B504-0x0000000189A9B53C
		internal SocketException(int error, string message) {} // 0x0000000189A9B4FC-0x0000000189A9B504
		public SocketException(int errorCode) {} // 0x0000000189A98180-0x0000000189A98188
		internal SocketException(SocketError socketError) {} // 0x0000000189A98180-0x0000000189A98188
		protected SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x00000001899F4EC0-0x00000001899F4EE0
	
		// Methods
		private static int WSAGetLastError_icall() => default; // 0x0000000189A9B4D4-0x0000000189A9B4FC
	}

	public enum AddressFamily // TypeDefIndex: 45897
	{
		Unknown = -1,
		Unspecified = 0,
		Unix = 1,
		InterNetwork = 2,
		ImpLink = 3,
		Pup = 4,
		Chaos = 5,
		NS = 6,
		Ipx = 6,
		Iso = 7,
		Osi = 7,
		Ecma = 8,
		DataKit = 9,
		Ccitt = 10,
		Sna = 11,
		DecNet = 12,
		DataLink = 13,
		Lat = 14,
		HyperChannel = 15,
		AppleTalk = 16,
		NetBios = 17,
		VoiceView = 18,
		FireFox = 19,
		Banyan = 21,
		Atm = 22,
		InterNetworkV6 = 23,
		Cluster = 24,
		Ieee12844 = 25,
		Irda = 26,
		NetworkDesigners = 28,
		Max = 29
	}

	public enum IOControlCode : long // TypeDefIndex: 45898
	{
		EnableCircularQueuing = 671088642,
		Flush = 671088644,
		AddressListChange = 671088663,
		DataToRead = 1074030207,
		OobDataRead = 1074033415,
		GetBroadcastAddress = 1207959557,
		AddressListQuery = 1207959574,
		QueryTargetPnpHandle = 1207959576,
		AsyncIO = 2147772029,
		NonBlockingIO = 2147772030,
		AssociateHandle = 2281701377,
		MultipointLoopback = 2281701385,
		MulticastScope = 2281701386,
		SetQos = 2281701387,
		SetGroupQos = 2281701388,
		RoutingInterfaceChange = 2281701397,
		NamespaceChange = 2281701401,
		ReceiveAll = 2550136833,
		ReceiveAllMulticast = 2550136834,
		ReceiveAllIgmpMulticast = 2550136835,
		KeepAliveValues = 2550136836,
		AbsorbRouterAlert = 2550136837,
		UnicastInterface = 2550136838,
		LimitBroadcasts = 2550136839,
		BindToInterface = 2550136840,
		MulticastInterface = 2550136841,
		AddMulticastGroupOnInterface = 2550136842,
		DeleteMulticastGroupFromInterface = 2550136843,
		GetExtensionFunctionPointer = 3355443206,
		GetQos = 3355443207,
		GetGroupQos = 3355443208,
		TranslateHandle = 3355443213,
		RoutingInterfaceQuery = 3355443220,
		AddressListSort = 3355443225
	}

	public enum IPProtectionLevel // TypeDefIndex: 45899
	{
		Unspecified = -1,
		Unrestricted = 10,
		EdgeRestricted = 20,
		Restricted = 30
	}

	public class LingerOption // TypeDefIndex: 45900
	{
		// Fields
		private bool enabled; // 0x10
		private int lingerTime; // 0x14
	
		// Properties
		public bool Enabled { set {} } // 0x0000000183D4E960-0x0000000183D4E970
		public int LingerTime { set {} } // 0x0000000183D595B0-0x0000000183D595C0
	
		// Constructors
		public LingerOption() {} // Dummy constructor
		public LingerOption(bool enable, int seconds) {} // 0x0000000183D72C10-0x0000000183D72C20
	}

	public class MulticastOption // TypeDefIndex: 45901
	{
		// Constructors
		public MulticastOption() {} // Dummy constructor
	}

	public class IPv6MulticastOption // TypeDefIndex: 45902
	{
		// Constructors
		public IPv6MulticastOption() {} // Dummy constructor
	}

	public enum ProtocolType // TypeDefIndex: 45903
	{
		Unknown = -1,
		IP = 0,
		IPv6HopByHopOptions = 0,
		Unspecified = 0,
		Icmp = 1,
		Igmp = 2,
		Ggp = 3,
		IPv4 = 4,
		Tcp = 6,
		Pup = 12,
		Udp = 17,
		Idp = 22,
		IPv6 = 41,
		IPv6RoutingHeader = 43,
		IPv6FragmentHeader = 44,
		IPSecEncapsulatingSecurityPayload = 50,
		IPSecAuthenticationHeader = 51,
		IcmpV6 = 58,
		IPv6NoNextHeader = 59,
		IPv6DestinationOptions = 60,
		ND = 77,
		Raw = 255,
		Ipx = 1000,
		Spx = 1256,
		SpxII = 1257
	}

	public enum SelectMode // TypeDefIndex: 45904
	{
		SelectRead = 0,
		SelectWrite = 1,
		SelectError = 2
	}

	public enum SocketAsyncOperation // TypeDefIndex: 45905
	{
		None = 0,
		Accept = 1,
		Connect = 2,
		Disconnect = 3,
		Receive = 4,
		ReceiveFrom = 5,
		ReceiveMessageFrom = 6,
		Send = 7,
		SendPackets = 8,
		SendTo = 9
	}

	public enum SocketError // TypeDefIndex: 45906
	{
		SocketError = -1,
		Success = 0,
		OperationAborted = 995,
		IOPending = 997,
		Interrupted = 10004,
		AccessDenied = 10013,
		Fault = 10014,
		InvalidArgument = 10022,
		TooManyOpenSockets = 10024,
		WouldBlock = 10035,
		InProgress = 10036,
		AlreadyInProgress = 10037,
		NotSocket = 10038,
		DestinationAddressRequired = 10039,
		MessageSize = 10040,
		ProtocolType = 10041,
		ProtocolOption = 10042,
		ProtocolNotSupported = 10043,
		SocketNotSupported = 10044,
		OperationNotSupported = 10045,
		ProtocolFamilyNotSupported = 10046,
		AddressFamilyNotSupported = 10047,
		AddressAlreadyInUse = 10048,
		AddressNotAvailable = 10049,
		NetworkDown = 10050,
		NetworkUnreachable = 10051,
		NetworkReset = 10052,
		ConnectionAborted = 10053,
		ConnectionReset = 10054,
		NoBufferSpaceAvailable = 10055,
		IsConnected = 10056,
		NotConnected = 10057,
		Shutdown = 10058,
		TimedOut = 10060,
		ConnectionRefused = 10061,
		HostDown = 10064,
		HostUnreachable = 10065,
		ProcessLimit = 10067,
		SystemNotReady = 10091,
		VersionNotSupported = 10092,
		NotInitialized = 10093,
		Disconnecting = 10101,
		TypeNotFound = 10109,
		HostNotFound = 11001,
		TryAgain = 11002,
		NoRecovery = 11003,
		NoData = 11004
	}

	[Flags]
	public enum SocketFlags // TypeDefIndex: 45907
	{
		None = 0,
		OutOfBand = 1,
		Peek = 2,
		DontRoute = 4,
		MaxIOVectorLength = 16,
		Truncated = 256,
		ControlDataTruncated = 512,
		Broadcast = 1024,
		Multicast = 2048,
		Partial = 32768
	}

	public enum SocketOptionLevel // TypeDefIndex: 45908
	{
		IP = 0,
		Tcp = 6,
		Udp = 17,
		IPv6 = 41,
		Socket = 65535
	}

	public enum SocketOptionName // TypeDefIndex: 45909
	{
		DontLinger = -129,
		ExclusiveAddressUse = -5,
		Debug = 1,
		IPOptions = 1,
		NoDelay = 1,
		NoChecksum = 1,
		AcceptConnection = 2,
		HeaderIncluded = 2,
		BsdUrgent = 2,
		Expedited = 2,
		TypeOfService = 3,
		ReuseAddress = 4,
		IpTimeToLive = 4,
		KeepAlive = 8,
		MulticastInterface = 9,
		MulticastTimeToLive = 10,
		MulticastLoopback = 11,
		AddMembership = 12,
		DropMembership = 13,
		DontFragment = 14,
		AddSourceMembership = 15,
		DontRoute = 16,
		DropSourceMembership = 16,
		BlockSource = 17,
		UnblockSource = 18,
		PacketInformation = 19,
		ChecksumCoverage = 20,
		HopLimit = 21,
		IPProtectionLevel = 23,
		IPv6Only = 27,
		Broadcast = 32,
		UseLoopback = 64,
		Linger = 128,
		OutOfBandInline = 256,
		SendBuffer = 4097,
		ReceiveBuffer = 4098,
		SendLowWater = 4099,
		ReceiveLowWater = 4100,
		SendTimeout = 4101,
		ReceiveTimeout = 4102,
		Error = 4103,
		Type = 4104,
		ReuseUnicastPort = 12295,
		UpdateAcceptContext = 28683,
		UpdateConnectContext = 28688,
		MaxConnections = 2147483647
	}

	public enum SocketShutdown // TypeDefIndex: 45910
	{
		Receive = 0,
		Send = 1,
		Both = 2
	}

	public enum SocketType // TypeDefIndex: 45911
	{
		Unknown = -1,
		Stream = 1,
		Dgram = 2,
		Raw = 3,
		Rdm = 4,
		Seqpacket = 5
	}

	public class TcpClient : IDisposable // TypeDefIndex: 45912
	{
		// Fields
		private Socket m_ClientSocket; // 0x10
		private bool m_Active; // 0x18
		private NetworkStream m_DataStream; // 0x20
		private AddressFamily m_Family; // 0x28
		private bool m_CleanedUp; // 0x2C
	
		// Properties
		public Socket Client { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public bool Connected { get => default; } // 0x0000000189AA3090-0x0000000189AA30AC 
		public int ReceiveTimeout { set {} } // 0x00000001892A29B8-0x00000001892A29EC
		public int SendTimeout { set {} } // 0x0000000189AA316C-0x0000000189AA31A0
		public bool NoDelay { set {} } // 0x0000000189AA3134-0x0000000189AA316C
	
		// Constructors
		public TcpClient() {} // 0x0000000189AA2F80-0x0000000189AA2F90
		public TcpClient(AddressFamily family) {} // 0x0000000189AA2F90-0x0000000189AA3090
	
		// Methods
		public void Connect(string hostname, int port) {} // 0x0000000189AA2400-0x0000000189AA2C40
		public void Connect(IPEndPoint remoteEP) {} // 0x0000000189AA230C-0x0000000189AA2400
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) => default; // 0x0000000189AA2178-0x0000000189AA21A0
		public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state) => default; // 0x0000000189AA2150-0x0000000189AA2178
		public void EndConnect(IAsyncResult asyncResult) {} // 0x0000000189AA2D84-0x0000000189AA2DB0
		public System.Threading.Tasks.Task ConnectAsync(string host, int port) => default; // 0x0000000189AA21DC-0x0000000189AA230C
		public NetworkStream GetStream() => default; // 0x0000000189AA2E24-0x0000000189AA2F80
		public void Close() {} // 0x0000000189AA21A0-0x0000000189AA21DC
		protected virtual void Dispose(bool disposing) {} // 0x0000000189AA2C4C-0x0000000189AA2D84
		public void Dispose() {} // 0x0000000189AA2C40-0x0000000189AA2C4C
		~TcpClient() {} // 0x0000000189AA2DB0-0x0000000189AA2E24
		private void initialize() {} // 0x0000000189AA30AC-0x0000000189AA3134
	}

	internal sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid // TypeDefIndex: 45913
	{
		// Fields
		private List<Thread> blocking_threads; // 0x20
		private Dictionary<Thread, StackTrace> threads_stacktraces; // 0x28
		private bool in_cleanup; // 0x30
		private static bool THROW_ON_ABORT_RETRIES; // 0x00
	
		// Constructors
		public SafeSocketHandle() {} // Dummy constructor
		public SafeSocketHandle(IntPtr preexistingHandle, bool ownsHandle) {} // 0x000000018293FFF0-0x00000001829400A0
		static SafeSocketHandle() {} // 0x00000001830F08A0-0x00000001830F0910
	
		// Methods
		protected override bool ReleaseHandle() => default; // 0x0000000182958E30-0x0000000182959A20
		public void RegisterForBlockingSyscall() {} // 0x00000001824D0F10-0x00000001824D1080
		public void UnRegisterForBlockingSyscall() {} // 0x0000000182EF8040-0x0000000182EF82A0
	}

	public class SocketAsyncEventArgs : EventArgs, IDisposable // TypeDefIndex: 45914
	{
		// Fields
		private bool disposed; // 0x10
		internal int in_progress; // 0x14
		private EndPoint remote_ep; // 0x18
		private Socket current_socket; // 0x20
		internal SocketAsyncResult socket_async_result; // 0x28
		private Memory<byte> _buffer; // 0x58
		private int _offset; // 0x68
		private int _count; // 0x6C
		private bool _bufferIsExplicitArray; // 0x70
		private IList<ArraySegment<byte>> _bufferList; // 0x78
	
		// Properties
		public Socket AcceptSocket { get; set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public int BytesTransferred { get; private set; } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		private SocketAsyncOperation LastOperation { get; set; } // 0x0000000183D4EDC0-0x0000000183D4EDD0
		public EndPoint RemoteEndPoint { set {} } // 0x00000001822C3A90-0x00000001822C3AA0
		public SocketError SocketError { get; set; } // 0x0000000183D4ED80-0x0000000183D4ED90 0x0000000183D4EDB0-0x0000000183D4EDC0
		public SocketFlags SocketFlags { get; set; } // 0x0000000183D4EEA0-0x0000000183D4EEB0
		public object UserToken { get; set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		internal Socket CurrentSocket { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public Memory<byte> MemoryBuffer { get => default; } // 0x0000000183D50820-0x0000000183D50830 
		public int Offset { get => default; } // 0x0000000183D4EEE0-0x0000000183D4EEF0 
		public int Count { get => default; } // 0x0000000183D4F400-0x0000000183D4F410 
		public IList<ArraySegment<byte>> BufferList { get => default; } // 0x0000000183D4EB20-0x0000000183D4EB30 
	
		// Constructors
		public SocketAsyncEventArgs() {} // Dummy constructor
		internal SocketAsyncEventArgs(bool flowExecutionContext) {} // 0x0000000183CB1F70-0x0000000183CB1FF0
	
		// Methods
		~SocketAsyncEventArgs() {} // 0x0000000189A9B05C-0x0000000189A9B0B0
		private void Dispose(bool disposing) {} // 0x0000000189A9B04C-0x0000000189A9B05C
		public void Dispose() {} // 0x0000000189A9B000-0x0000000189A9B04C
		internal void SetBytesTransferred(int value) {} // 0x0000000183D4ECB0-0x0000000183D4ECC0
		internal void SetCurrentSocket(Socket socket) {} // 0x0000000184271930-0x0000000184271940
		internal void SetLastOperation(SocketAsyncOperation op) {} // 0x0000000189A9B1BC-0x0000000189A9B284
		internal void Complete_internal() {} // 0x0000000189A9AFC4-0x0000000189A9B000
		protected virtual void OnCompleted(SocketAsyncEventArgs e) {} // 0x0000000189A9B0B0-0x0000000189A9B0DC
		public void SetBuffer(Memory<byte> buffer) {} // 0x0000000189A9B0DC-0x0000000189A9B1BC
	}

	internal sealed class SocketAsyncResult : IOAsyncResult // TypeDefIndex: 45916
	{
		// Fields
		public Socket socket; // 0x30
		public SocketOperation operation; // 0x38
		private Exception DelayedException; // 0x40
		public EndPoint EndPoint; // 0x48
		public Memory<byte> Buffer; // 0x50
		public int Offset; // 0x60
		public int Size; // 0x64
		public SocketFlags SockFlags; // 0x68
		public Socket AcceptSocket; // 0x70
		public IPAddress[] Addresses; // 0x78
		public int Port; // 0x80
		public IList<ArraySegment<byte>> Buffers; // 0x88
		public bool ReuseSocket; // 0x90
		public int CurrentAddress; // 0x94
		public Socket AcceptedSocket; // 0x98
		public int Total; // 0xA0
		internal int error; // 0xA4
		public int EndCalled; // 0xA8
	
		// Properties
		public IntPtr Handle { get => default; } // 0x0000000182959AB0-0x0000000182959AD0 
		public SocketError ErrorCode { get => default; } // 0x0000000189A9B47C-0x0000000189A9B4D4 
	
		// Constructors
		public SocketAsyncResult() {} // 0x000000018350B670-0x000000018350B680
		public SocketAsyncResult(Socket socket, AsyncCallback callback, object state, SocketOperation operation) {} // 0x000000018295AB70-0x000000018295ABC0
	
		// Methods
		public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) {} // 0x0000000189A9B354-0x0000000189A9B47C
		public void CheckIfThrowDelayedException() {} // 0x00000001838A70A0-0x00000001838A70D0
		internal override void CompleteDisposed() {} // 0x0000000189A9B284-0x0000000189A9B28C
		public void Complete() {} // 0x0000000183626EC0-0x0000000183627050
		public void Complete(bool synch) {} // 0x0000000189A9B28C-0x0000000189A9B298
		public void Complete(int total) {} // 0x0000000189A9B31C-0x0000000189A9B32C
		public void Complete(Exception e, bool synch) {} // 0x0000000189A9B2BC-0x0000000189A9B2E8
		public void Complete(Exception e) {} // 0x0000000189A9B298-0x0000000189A9B2BC
		public void Complete(Socket s) {} // 0x0000000189A9B32C-0x0000000189A9B354
		public void Complete(Socket s, int total) {} // 0x0000000189A9B2E8-0x0000000189A9B31C
	}

	internal enum SocketOperation // TypeDefIndex: 45917
	{
		Accept = 0,
		Connect = 1,
		Receive = 2,
		ReceiveFrom = 3,
		Send = 4,
		SendTo = 5,
		RecvJustCallback = 6,
		SendJustCallback = 7,
		Disconnect = 8,
		AcceptReceive = 9,
		ReceiveGeneric = 10,
		SendGeneric = 11
	}
}

namespace System.Net.WebSockets
{
	internal sealed class ManagedWebSocket : WebSocket // TypeDefIndex: 45934
	{
		// Fields
		private static readonly RandomNumberGenerator s_random; // 0x00
		private static readonly UTF8Encoding s_textEncoding; // 0x08
		private static readonly WebSocketState[] s_validSendStates; // 0x10
		private static readonly WebSocketState[] s_validReceiveStates; // 0x18
		private static readonly WebSocketState[] s_validCloseOutputStates; // 0x20
		private static readonly WebSocketState[] s_validCloseStates; // 0x28
		private static readonly Task<WebSocketReceiveResult> s_cachedCloseTask; // 0x30
		private readonly Stream _stream; // 0x10
		private readonly bool _isServer; // 0x18
		private readonly string _subprotocol; // 0x20
		private readonly System.Threading.Timer _keepAliveTimer; // 0x28
		private readonly CancellationTokenSource _abortSource; // 0x30
		private Memory<byte> _receiveBuffer; // 0x38
		private readonly Utf8MessageState _utf8TextState; // 0x48
		private readonly SemaphoreSlim _sendFrameAsyncLock; // 0x50
		private WebSocketState _state; // 0x58
		private bool _disposed; // 0x5C
		private bool _sentCloseFrame; // 0x5D
		private bool _receivedCloseFrame; // 0x5E
		private WebSocketCloseStatus? _closeStatus; // 0x60
		private string _closeStatusDescription; // 0x68
		private MessageHeader _lastReceiveHeader; // 0x70
		private int _receiveBufferOffset; // 0x88
		private int _receiveBufferCount; // 0x8C
		private int _receivedMaskOffsetOffset; // 0x90
		private byte[] _sendBuffer; // 0x98
		private bool _lastSendWasFragment; // 0xA0
		private System.Threading.Tasks.Task _lastReceiveAsync; // 0xA8
	
		// Properties
		private object StateUpdateLock { get => default; } // 0x0000000181003830-0x0000000181003840 
		private object ReceiveAsyncLock { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public override WebSocketState State { get => default; } // 0x0000000183D4EF00-0x0000000183D4EF10 
	
		// Nested types
		private sealed class Utf8MessageState // TypeDefIndex: 45918
		{
			// Fields
			internal bool SequenceInProgress; // 0x10
			internal int AdditionalBytesExpected; // 0x14
			internal int ExpectedValueMin; // 0x18
			internal int CurrentDecodeBits; // 0x1C
	
			// Constructors
			public Utf8MessageState() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private enum MessageOpcode : byte // TypeDefIndex: 45919
		{
			Continuation = 0,
			Text = 1,
			Binary = 2,
			Close = 8,
			Ping = 9,
			Pong = 10
		}
	
		private struct MessageHeader // TypeDefIndex: 45920
		{
			// Fields
			internal MessageOpcode Opcode; // 0x00
			internal bool Fin; // 0x01
			internal long PayloadLength; // 0x08
			internal int Mask; // 0x10
		}
	
		private interface IWebSocketReceiveResultGetter<TResult> // TypeDefIndex: 45921
		{
			// Methods
			TResult GetResult(int count, WebSocketMessageType messageType, bool endOfMessage, WebSocketCloseStatus? closeStatus, string closeDescription);
		}
	
		[IsReadOnly]
		private struct WebSocketReceiveResultGetter : IWebSocketReceiveResultGetter<WebSocketReceiveResult> // TypeDefIndex: 45922
		{
			// Methods
			public WebSocketReceiveResult GetResult(int count, WebSocketMessageType messageType, bool endOfMessage, WebSocketCloseStatus? closeStatus, string closeDescription) => default; // 0x00000001899F617C-0x00000001899F6210
		}
	
		// Constructors
		public ManagedWebSocket() {} // Dummy constructor
		private ManagedWebSocket(Stream stream, bool isServer, string subprotocol, TimeSpan keepAliveInterval) {} // 0x00000001899EBB0C-0x00000001899EBF0C
		static ManagedWebSocket() {} // 0x00000001899EB834-0x00000001899EBB0C
	
		// Methods
		public static ManagedWebSocket CreateFromConnectedStream(Stream stream, bool isServer, string subprotocol, TimeSpan keepAliveInterval) => default; // 0x00000001899E9534-0x00000001899E95CC
		public override void Dispose() {} // 0x00000001899E96C4-0x00000001899E976C
		private void DisposeCore() {} // 0x00000001899E967C-0x00000001899E96C4
		public override System.Threading.Tasks.Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) => default; // 0x00000001899E9E4C-0x00000001899EA0EC
		private ValueTask SendPrivateAsync(ReadOnlyMemory<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) => default; // 0x00000001899EA9C4-0x00000001899EAD10
		public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken) => default; // 0x00000001899E9A70-0x00000001899E9DBC
		public override System.Threading.Tasks.Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) => default; // 0x00000001899E9250-0x00000001899E9390
		public override void Abort() {} // 0x00000001899E8FF0-0x00000001899E9024
		private ValueTask SendFrameAsync(MessageOpcode opcode, bool endOfMessage, ReadOnlyMemory<byte> payloadBuffer, CancellationToken cancellationToken) => default; // 0x00000001899EA1E4-0x00000001899EA2FC
		private ValueTask SendFrameLockAcquiredNonCancelableAsync(MessageOpcode opcode, bool endOfMessage, ReadOnlyMemory<byte> payloadBuffer) => default; // 0x00000001899EA404-0x00000001899EA784
		private async System.Threading.Tasks.Task WaitForWriteTaskAsync(ValueTask writeTask) => default; // 0x00000001899EB388-0x00000001899EB460
		private async System.Threading.Tasks.Task SendFrameFallbackAsync(MessageOpcode opcode, bool endOfMessage, ReadOnlyMemory<byte> payloadBuffer, CancellationToken cancellationToken) => default; // 0x00000001899EA2FC-0x00000001899EA404
		private int WriteFrameToSendBuffer(MessageOpcode opcode, bool endOfMessage, ReadOnlySpan<byte> payloadBuffer) => default; // 0x00000001899EB460-0x00000001899EB65C
		private void SendKeepAliveFrameAsync() {} // 0x00000001899EA784-0x00000001899EA9C4
		private static int WriteHeader(MessageOpcode opcode, byte[] sendBuffer, ReadOnlySpan<byte> payload, bool endOfMessage, bool useMask) => default; // 0x00000001899EB65C-0x00000001899EB7BC
		private static void WriteRandomMask(byte[] buffer, int offset) {} // 0x00000001899EB7BC-0x00000001899EB834
		private async ValueTask<TWebSocketReceiveResult> ReceiveAsyncPrivate<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>(Memory<byte> payloadBuffer, CancellationToken cancellationToken, TWebSocketReceiveResultGetter resultGetter = default)
			where TWebSocketReceiveResultGetter : struct, IWebSocketReceiveResultGetter<TWebSocketReceiveResult> => default;
		private async System.Threading.Tasks.Task HandleReceivedCloseAsync(MessageHeader header, CancellationToken cancellationToken) => default; // 0x00000001899E985C-0x00000001899E994C
		private async System.Threading.Tasks.Task WaitForServerToCloseConnectionAsync(CancellationToken cancellationToken) => default; // 0x00000001899EB2B4-0x00000001899EB388
		private async System.Threading.Tasks.Task HandleReceivedPingPongAsync(MessageHeader header, CancellationToken cancellationToken) => default; // 0x00000001899E994C-0x00000001899E9A3C
		private static bool IsValidCloseStatus(WebSocketCloseStatus closeStatus) => default; // 0x00000001899E9A3C-0x00000001899E9A70
		private async System.Threading.Tasks.Task CloseWithReceiveErrorAndThrowAsync(WebSocketCloseStatus closeStatus, WebSocketError error, Exception innerException = null) => default; // 0x00000001899E9390-0x00000001899E9480
		private bool TryParseMessageHeaderFromReceiveBuffer(out MessageHeader resultHeader) {
			resultHeader = default;
			return default;
		} // 0x00000001899EAE6C-0x00000001899EB118
		private async System.Threading.Tasks.Task SendCloseFrameAsync(WebSocketCloseStatus closeStatus, string closeStatusDescription, CancellationToken cancellationToken) => default; // 0x00000001899EA0EC-0x00000001899EA1E4
		private void ConsumeFromBuffer(int count) {} // 0x0000000183D75DB0-0x0000000183D75DC0
		private async System.Threading.Tasks.Task EnsureBufferContainsAsync(int minimumRequiredBytes, CancellationToken cancellationToken, bool throwOnPrematureClosure = true /* Metadata: 0x01FBA6E2 */) => default; // 0x00000001899E976C-0x00000001899E985C
		private void ThrowIfEOFUnexpected(bool throwOnPrematureClosure) {} // 0x00000001899EAD10-0x00000001899EADC4
		private void AllocateSendBuffer(int minLength) {} // 0x00000001899E9024-0x00000001899E90A8
		private void ReleaseSendBuffer() {} // 0x00000001899E9DBC-0x00000001899E9E4C
		private static int CombineMaskBytes(Span<byte> buffer, int maskOffset) => default; // 0x00000001899E9480-0x00000001899E9534
		private static int ApplyMask(Span<byte> toMask, byte[] mask, int maskOffset, int maskOffsetIndex) => default; // 0x00000001899E90A8-0x00000001899E915C
		private static int ApplyMask(Span<byte> toMask, int mask, int maskIndex) => default; // 0x00000001899E915C-0x00000001899E9250
		private void ThrowIfOperationInProgress(bool operationCompleted, [CallerMemberName] string methodName = null) {} // 0x00000001899EADC4-0x00000001899EADF8
		private void ThrowOperationInProgress(string methodName) {} // 0x00000001899EADF8-0x00000001899EAE6C
		private static Exception CreateOperationCanceledException(Exception innerException, CancellationToken cancellationToken = default) => default; // 0x00000001899E95CC-0x00000001899E967C
		private static bool TryValidateUtf8(Span<byte> span, bool endOfMessage, Utf8MessageState state) => default; // 0x00000001899EB118-0x00000001899EB2B4
	}

	internal static class WebSocketValidate // TypeDefIndex: 45935
	{
		// Methods
		internal static void ThrowIfInvalidState(WebSocketState currentState, bool isDisposed, WebSocketState[] validStates) {} // 0x00000001899F62BC-0x00000001899F645C
		internal static void ValidateSubprotocol(string subProtocol) {} // 0x00000001899F68C4-0x00000001899F6AF0
		internal static void ValidateCloseStatus(WebSocketCloseStatus closeStatus, string statusDescription) {} // 0x00000001899F6668-0x00000001899F68C4
		internal static void ValidateArraySegment(ArraySegment<byte> arraySegment, string parameterName) {} // 0x00000001899F645C-0x00000001899F6668
	}

	public sealed class ClientWebSocket : WebSocket // TypeDefIndex: 45939
	{
		// Fields
		private readonly ClientWebSocketOptions _options; // 0x10
		private WebSocketHandle _innerWebSocket; // 0x18
		private int _state; // 0x20
	
		// Properties
		public ClientWebSocketOptions Options { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public override WebSocketState State { get => default; } // 0x00000001899E15A0-0x00000001899E1624 
	
		// Nested types
		private enum InternalState // TypeDefIndex: 45936
		{
			Created = 0,
			Connecting = 1,
			Connected = 2,
			Disposed = 3
		}
	
		internal sealed class DefaultWebProxy : IWebProxy // TypeDefIndex: 45937
		{
			// Properties
			public static DefaultWebProxy Instance { get; } // 0x00000001899E64D4-0x00000001899E6524 
			public ICredentials Credentials { get => default; } // 0x00000001899E6488-0x00000001899E64D4 
	
			// Constructors
			public DefaultWebProxy() {} // 0x000000018350B670-0x000000018350B680
			static DefaultWebProxy() {} // 0x00000001899E6424-0x00000001899E6488
	
			// Methods
			public System.Uri GetProxy(System.Uri destination) => default; // 0x00000001899E638C-0x00000001899E63D8
			public bool IsBypassed(System.Uri host) => default; // 0x00000001899E63D8-0x00000001899E6424
		}
	
		// Constructors
		public ClientWebSocket() {} // 0x00000001899E143C-0x00000001899E15A0
	
		// Methods
		public System.Threading.Tasks.Task ConnectAsync(System.Uri uri, CancellationToken cancellationToken) => default; // 0x00000001899E0E28-0x00000001899E1224
		private async System.Threading.Tasks.Task ConnectAsyncCore(System.Uri uri, CancellationToken cancellationToken) => default; // 0x00000001899E0D3C-0x00000001899E0E28
		public override System.Threading.Tasks.Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) => default; // 0x00000001899E12E8-0x00000001899E1360
		public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken) => default; // 0x00000001899E1290-0x00000001899E12E8
		public override System.Threading.Tasks.Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) => default; // 0x00000001899E0CDC-0x00000001899E0D3C
		public override void Abort() {} // 0x00000001899E0C68-0x00000001899E0CDC
		public override void Dispose() {} // 0x00000001899E1224-0x00000001899E1290
		private void ThrowIfNotConnected() {} // 0x00000001899E1360-0x00000001899E143C
	}

	public sealed class ClientWebSocketOptions // TypeDefIndex: 45940
	{
		// Fields
		private bool _isReadOnly; // 0x10
		private readonly List<string> _requestedSubProtocols; // 0x18
		private readonly WebHeaderCollection _requestHeaders; // 0x20
		private TimeSpan _keepAliveInterval; // 0x28
		private bool _useDefaultCredentials; // 0x30
		private ICredentials _credentials; // 0x38
		private IWebProxy _proxy; // 0x40
		private System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates; // 0x48
		private CookieContainer _cookies; // 0x50
		private int _receiveBufferSize; // 0x58
		private int _sendBufferSize; // 0x5C
		private ArraySegment<byte>? _buffer; // 0x60
		private RemoteCertificateValidationCallback _remoteCertificateValidationCallback; // 0x78
	
		// Properties
		internal WebHeaderCollection RequestHeaders { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		internal List<string> RequestedSubProtocols { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public IWebProxy Proxy { set {} } // 0x00000001899E0C38-0x00000001899E0C68
		public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get => default; } // 0x00000001899E0BC8-0x00000001899E0C38 
		public CookieContainer Cookies { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public TimeSpan KeepAliveInterval { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		internal int ReceiveBufferSize { get => default; } // 0x0000000183D4EF00-0x0000000183D4EF10 
		internal int SendBufferSize { get => default; } // 0x0000000183D4EEF0-0x0000000183D4EF00 
		internal ArraySegment<byte>? Buffer { get => default; } // 0x0000000183D5D690-0x0000000183D5D6B0 
	
		// Constructors
		internal ClientWebSocketOptions() {} // 0x00000001899E0B04-0x00000001899E0BC8
	
		// Methods
		public void AddSubProtocol(string subProtocol) {} // 0x00000001899E08A8-0x00000001899E0A9C
		internal void SetToReadOnly() {} // 0x0000000181168960-0x0000000181168970
		private void ThrowIfReadOnly() {} // 0x00000001899E0A9C-0x00000001899E0B04
	}

	internal sealed class WebSocketHandle // TypeDefIndex: 45947
	{
		// Fields
		[ThreadStatic]
		private static StringBuilder t_cachedStringBuilder; // 0x80000000
		private static readonly Encoding s_defaultHttpEncoding; // 0x00
		private const int DefaultReceiveBufferSize = 4096; // Metadata: 0x01FBA6ED
		private const string WSServerGuid = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11"; // Metadata: 0x01FBA6EF
		private readonly CancellationTokenSource _abortSource; // 0x10
		private WebSocketState _state; // 0x18
		private WebSocket _webSocket; // 0x20
	
		// Properties
		public WebSocketState State { get => default; } // 0x00000001899F6158-0x00000001899F617C 
	
		// Constructors
		public WebSocketHandle() {} // 0x00000001899F60EC-0x00000001899F6158
		static WebSocketHandle() {} // 0x00000001899F6098-0x00000001899F60EC
	
		// Methods
		public static WebSocketHandle Create() => default; // 0x00000001899F5C60-0x00000001899F5CB0
		public static bool IsValid(WebSocketHandle handle) => default; // 0x00000001891ED230-0x00000001891ED238
		public static void CheckPlatformSupport() {} // 0x000000018350B670-0x000000018350B680
		public void Dispose() {} // 0x00000001899F5CB0-0x00000001899F5CCC
		public void Abort() {} // 0x00000001899F5008-0x00000001899F5044
		public System.Threading.Tasks.Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken) => default; // 0x00000001899F5F04-0x00000001899F5F44
		public Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken) => default; // 0x00000001899F5ED4-0x00000001899F5F04
		public System.Threading.Tasks.Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) => default; // 0x00000001899F5854-0x00000001899F5880
		public async System.Threading.Tasks.Task ConnectAsyncCore(System.Uri uri, CancellationToken cancellationToken, ClientWebSocketOptions options) => default; // 0x00000001899F5880-0x00000001899F5988
		private async Task<Socket> ConnectSocketAsync(string host, int port, CancellationToken cancellationToken) => default; // 0x00000001899F5988-0x00000001899F5AA4
		private static byte[] BuildRequestHeader(System.Uri uri, ClientWebSocketOptions options, string secKey) => default; // 0x00000001899F5044-0x00000001899F5854
		private static KeyValuePair<string, string> CreateSecKeyAndSecWebSocketAccept() => default; // 0x00000001899F5AA4-0x00000001899F5C60
		private async Task<string> ParseAndValidateConnectResponseAsync(Stream stream, ClientWebSocketOptions options, string expectedSecWebSocketAccept, CancellationToken cancellationToken) => default; // 0x00000001899F5CCC-0x00000001899F5DE4
		private static void ValidateAndTrackHeader(string targetHeaderName, string targetHeaderValue, string foundHeaderName, string foundHeaderValue, ref bool foundHeader) {} // 0x00000001899F5F44-0x00000001899F6098
		private static async Task<string> ReadResponseHeaderLineAsync(Stream stream, CancellationToken cancellationToken) => default; // 0x00000001899F5DE4-0x00000001899F5ED4
	}

	public abstract class WebSocket : IDisposable // TypeDefIndex: 45948
	{
		// Properties
		public abstract WebSocketState State { get; }
		public static TimeSpan DefaultKeepAliveInterval { get; } // 0x00000001899F6E88-0x00000001899F6ED0 
	
		// Constructors
		protected WebSocket() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract void Abort();
		public abstract System.Threading.Tasks.Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken);
		public abstract void Dispose();
		public abstract Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken);
		public abstract System.Threading.Tasks.Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken);
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static WebSocket CreateClientWebSocket(Stream innerStream, string subProtocol, int receiveBufferSize, int sendBufferSize, TimeSpan keepAliveInterval, bool useZeroMaskingKey, ArraySegment<byte> internalBuffer) => default; // 0x00000001899F6AF0-0x00000001899F6E88
	}

	public enum WebSocketCloseStatus // TypeDefIndex: 45949
	{
		NormalClosure = 1000,
		EndpointUnavailable = 1001,
		ProtocolError = 1002,
		InvalidMessageType = 1003,
		Empty = 1005,
		InvalidPayloadData = 1007,
		PolicyViolation = 1008,
		MessageTooBig = 1009,
		MandatoryExtension = 1010,
		InternalServerError = 1011
	}

	public enum WebSocketError // TypeDefIndex: 45950
	{
		Success = 0,
		InvalidMessageType = 1,
		Faulted = 2,
		NativeError = 3,
		NotAWebSocket = 4,
		UnsupportedVersion = 5,
		UnsupportedProtocol = 6,
		HeaderError = 7,
		ConnectionClosedPrematurely = 8,
		InvalidState = 9
	}

	[Serializable]
	public sealed class WebSocketException : Win32Exception // TypeDefIndex: 45951
	{
		// Fields
		private readonly WebSocketError _webSocketErrorCode; // 0x98
	
		// Constructors
		public WebSocketException() {} // 0x00000001899F4F18-0x00000001899F4F6C
		public WebSocketException(WebSocketError error) {} // 0x00000001899F4E88-0x00000001899F4EC0
		public WebSocketException(WebSocketError error, string message) {} // 0x00000001899F4EE8-0x00000001899F4F18
		public WebSocketException(WebSocketError error, Exception innerException) {} // 0x00000001899F4FBC-0x00000001899F5008
		public WebSocketException(WebSocketError error, string message, Exception innerException) {} // 0x00000001899F4E54-0x00000001899F4E88
		public WebSocketException(int nativeError) {} // 0x00000001899F4F6C-0x00000001899F4FB4
		public WebSocketException(string message) {} // 0x00000001899F4FB4-0x00000001899F4FBC
		public WebSocketException(string message, Exception innerException) {} // 0x00000001899F4EE0-0x00000001899F4EE8
		private WebSocketException(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x00000001899F4EC0-0x00000001899F4EE0
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001899F4DA4-0x00000001899F4E4C
		private static string GetErrorMessage(WebSocketError error) => default; // 0x00000001899F4C44-0x00000001899F4DA4
		private void SetErrorCodeOnError(int nativeError) {} // 0x00000001899F4E4C-0x00000001899F4E54
		private static bool Succeeded(int hr) => default; // 0x00000001894A8B04-0x00000001894A8B10
	}

	public enum WebSocketMessageType // TypeDefIndex: 45952
	{
		Text = 0,
		Binary = 1,
		Close = 2
	}

	public class WebSocketReceiveResult // TypeDefIndex: 45953
	{
		// Properties
		public int Count { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public bool EndOfMessage { get; } // 0x0000000183D58C00-0x0000000183D58C10 
		public WebSocketMessageType MessageType { get; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public WebSocketCloseStatus? CloseStatus { get; } // 0x0000000183D75DC0-0x0000000183D75DD0 
		public string CloseStatusDescription { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		public WebSocketReceiveResult() {} // Dummy constructor
		public WebSocketReceiveResult(int count, WebSocketMessageType messageType, bool endOfMessage) {} // 0x00000001899F629C-0x00000001899F62BC
		public WebSocketReceiveResult(int count, WebSocketMessageType messageType, bool endOfMessage, WebSocketCloseStatus? closeStatus, string closeStatusDescription) {} // 0x00000001899F6210-0x00000001899F629C
	}

	public enum WebSocketState // TypeDefIndex: 45954
	{
		None = 0,
		Connecting = 1,
		Open = 2,
		CloseSent = 3,
		CloseReceived = 4,
		Closed = 5,
		Aborted = 6
	}
}

namespace System.Security.Authentication
{
	[Serializable]
	public class AuthenticationException : SystemException // TypeDefIndex: 45584
	{
		// Constructors
		public AuthenticationException() {} // 0x0000000189A360F4-0x0000000189A36130
		public AuthenticationException(string message) {} // 0x00000001891844D4-0x00000001891844DC
		public AuthenticationException(string message, Exception innerException) {} // 0x00000001891A5918-0x00000001891A5920
		protected AuthenticationException(SerializationInfo serializationInfo, StreamingContext streamingContext) {} // 0x0000000189166FDC-0x0000000189166FFC
	}

	[Flags]
	public enum SslProtocols // TypeDefIndex: 45585
	{
		None = 0,
		Ssl2 = 12,
		Ssl3 = 48,
		Tls = 192,
		Default = 240,
		Tls11 = 768,
		Tls12 = 3072,
		Tls13 = 12288
	}
}

namespace System.Security.Cryptography
{
	internal class DerSequenceReader // TypeDefIndex: 45588
	{
		// Fields
		internal static DateTimeFormatInfo s_validityDateTimeFormatInfo; // 0x00
		private static Encoding s_utf8EncodingWithExceptionFallback; // 0x08
		private static Encoding s_latin1Encoding; // 0x10
		private readonly byte[] _data; // 0x10
		private readonly int _end; // 0x18
		private int _position; // 0x1C
	
		// Properties
		private int ContentLength { get; set; } // 0x0000000181003B60-0x0000000181003B70
		internal bool HasData { get => default; } // 0x0000000189A37840-0x0000000189A3784C 
	
		// Nested types
		internal enum DerTag : byte // TypeDefIndex: 45586
		{
			Boolean = 1,
			Integer = 2,
			BitString = 3,
			OctetString = 4,
			Null = 5,
			ObjectIdentifier = 6,
			UTF8String = 12,
			Sequence = 16,
			Set = 17,
			PrintableString = 19,
			T61String = 20,
			IA5String = 22,
			UTCTime = 23,
			GeneralizedTime = 24,
			BMPString = 30
		}
	
		// Constructors
		public DerSequenceReader() {} // Dummy constructor
		internal DerSequenceReader(byte[] data) {} // 0x0000000189A377F0-0x0000000189A3781C
		internal DerSequenceReader(byte[] data, int offset, int length) {} // 0x0000000189A3781C-0x0000000189A37840
		private DerSequenceReader(DerTag tagToEat, byte[] data, int offset, int length) {} // 0x0000000189A37724-0x0000000189A377F0
	
		// Methods
		internal byte PeekTag() => default; // 0x0000000189A36334-0x0000000189A36418
		internal void SkipValue() {} // 0x0000000189A3768C-0x0000000189A376C0
		internal byte[] ReadNextEncodedValue() => default; // 0x0000000189A36924-0x0000000189A369CC
		internal bool ReadBoolean() => default; // 0x0000000189A365D8-0x0000000189A36678
		internal int ReadInteger() => default; // 0x0000000189A36894-0x0000000189A36924
		internal byte[] ReadIntegerBytes() => default; // 0x0000000189A36870-0x0000000189A36894
		internal byte[] ReadBitString() => default; // 0x0000000189A36478-0x0000000189A365D8
		internal byte[] ReadOctetString() => default; // 0x0000000189A369CC-0x0000000189A369F0
		internal string ReadOidAsString() => default; // 0x0000000189A369F0-0x0000000189A36CC4
		internal string ReadUtf8String() => default; // 0x0000000189A37294-0x0000000189A372F4
		private DerSequenceReader ReadCollectionWithTag(DerTag expected) => default; // 0x0000000189A36678-0x0000000189A36750
		internal DerSequenceReader ReadSequence() => default; // 0x0000000189A36D24-0x0000000189A36D30
		internal DerSequenceReader ReadSet() => default; // 0x0000000189A36D30-0x0000000189A36D3C
		internal string ReadPrintableString() => default; // 0x0000000189A36CC4-0x0000000189A36D24
		internal string ReadIA5String() => default; // 0x0000000189A36810-0x0000000189A36870
		internal string ReadT61String() => default; // 0x0000000189A36D3C-0x0000000189A37030
		internal System.DateTime ReadX509Date() => default; // 0x0000000189A372F4-0x0000000189A37380
		internal System.DateTime ReadUtcTime() => default; // 0x0000000189A37254-0x0000000189A37294
		internal System.DateTime ReadGeneralizedTime() => default; // 0x0000000189A367D0-0x0000000189A36810
		internal string ReadBMPString() => default; // 0x0000000189A36418-0x0000000189A36478
		private static string TrimTrailingNulls(string value) => default; // 0x0000000189A376C0-0x0000000189A37724
		private System.DateTime ReadTime(DerTag timeTag, string formatString) => default; // 0x0000000189A37030-0x0000000189A37254
		private byte[] ReadContentAsBytes() => default; // 0x0000000189A36750-0x0000000189A367D0
		private void EatTag(DerTag expected) {} // 0x0000000189A362B0-0x0000000189A36334
		private static void CheckTag(DerTag expected, byte[] data, int position) {} // 0x0000000189A36130-0x0000000189A36278
		private int EatLength() => default; // 0x0000000189A36278-0x0000000189A362B0
		private static int ScanContentLength(byte[] data, int offset, int end, out int bytesConsumed) {
			bytesConsumed = default;
			return default;
		} // 0x0000000189A37380-0x0000000189A3768C
	}

	public sealed class Oid // TypeDefIndex: 45589
	{
		// Fields
		private string _value; // 0x10
		private string _friendlyName; // 0x18
		private OidGroup _group; // 0x20
	
		// Properties
		public string Value { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string FriendlyName { get => default; } // 0x0000000189A37F80-0x0000000189A38000 
	
		// Constructors
		public Oid() {} // 0x000000018350B670-0x000000018350B680
		public Oid(string oid) {} // 0x0000000189A37F14-0x0000000189A37F80
		public Oid(string value, string friendlyName) {} // 0x0000000182676770-0x00000001826767A0
		public Oid(Oid oid) {} // 0x0000000189A37E7C-0x0000000189A37F14
		private Oid(string value, string friendlyName, OidGroup group) {} // 0x0000000183864580-0x00000001838645B0
	
		// Methods
		public static Oid FromOidValue(string oidValue, OidGroup group) => default; // 0x0000000189A37D24-0x0000000189A37E7C
	}

	public sealed class OidCollection : ICollection // TypeDefIndex: 45590
	{
		// Fields
		private readonly List<System.Security.Cryptography.Oid> _list; // 0x10
	
		// Properties
		public System.Security.Cryptography.Oid this[int index] { get => default; } // 0x0000000189A37C60-0x0000000189A37CB4 
		public int Count { get => default; } // 0x0000000189A37C20-0x0000000189A37C60 
		public bool IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public object SyncRoot { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
	
		// Constructors
		public OidCollection() {} // 0x0000000189A37BA8-0x0000000189A37C20
	
		// Methods
		public int Add(System.Security.Cryptography.Oid oid) => default; // 0x0000000189A378A4-0x0000000189A37918
		public OidEnumerator GetEnumerator() => default; // 0x0000000189A37918-0x0000000189A37978
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189A37BA0-0x0000000189A37BA8
		void ICollection.CopyTo(Array array, int index) {} // 0x0000000189A37978-0x0000000189A37BA0
	}

	public sealed class OidEnumerator : IEnumerator // TypeDefIndex: 45591
	{
		// Fields
		private readonly OidCollection _oids; // 0x10
		private int _current; // 0x18
	
		// Properties
		public System.Security.Cryptography.Oid Current { get => default; } // 0x0000000189A37CFC-0x0000000189A37D24 
		object IEnumerator.Current { get => default; } // 0x0000000189A37CF4-0x0000000189A37CFC 
	
		// Constructors
		public OidEnumerator() {} // Dummy constructor
		internal OidEnumerator(OidCollection oids) {} // 0x00000001830840F0-0x0000000183084120
	
		// Methods
		public bool MoveNext() => default; // 0x0000000189A37CB4-0x0000000189A37CF4
		public void Reset() {} // 0x0000000183D50330-0x0000000183D50340
	}

	public enum OidGroup // TypeDefIndex: 45592
	{
		All = 0,
		HashAlgorithm = 1,
		EncryptionAlgorithm = 2,
		PublicKeyAlgorithm = 3,
		SignatureAlgorithm = 4,
		Attribute = 5,
		ExtensionOrAttribute = 6,
		EnhancedKeyUsage = 7,
		Policy = 8,
		Template = 9,
		KeyDerivationFunction = 10
	}

	internal enum AsnDecodeStatus // TypeDefIndex: 45593
	{
		NotDecoded = -1,
		Ok = 0,
		BadAsn = 1,
		BadTag = 2,
		BadLength = 3,
		InformationNotAvailable = 4
	}

	public class AsnEncodedData // TypeDefIndex: 45594
	{
		// Fields
		internal System.Security.Cryptography.Oid _oid; // 0x10
		internal byte[] _raw; // 0x18
	
		// Properties
		public System.Security.Cryptography.Oid Oid { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x0000000189A3F084-0x0000000189A3F108
		public byte[] RawData { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000189A3F108-0x0000000189A3F1D0
	
		// Constructors
		protected AsnEncodedData() {} // 0x000000018350B670-0x000000018350B680
		public AsnEncodedData(string oid, byte[] rawData) {} // 0x0000000189A3EF04-0x0000000189A3EF94
		public AsnEncodedData(System.Security.Cryptography.Oid oid, byte[] rawData) {} // 0x0000000189A3EED4-0x0000000189A3EF04
		public AsnEncodedData(AsnEncodedData asnEncodedData) {} // 0x0000000189A3EF94-0x0000000189A3F084
	
		// Methods
		public virtual void CopyFrom(AsnEncodedData asnEncodedData) {} // 0x0000000189A3E220-0x0000000189A3E314
		public virtual string Format(bool multiLine) => default; // 0x0000000189A3E500-0x0000000189A3E578
		internal virtual string ToString(bool multiLine) => default; // 0x0000000189A3ED64-0x0000000189A3EED4
		internal string Default(bool multiLine) => default; // 0x0000000189A3E314-0x0000000189A3E408
		internal string BasicConstraintsExtension(bool multiLine) => default; // 0x0000000189A3E128-0x0000000189A3E220
		internal string EnhancedKeyUsageExtension(bool multiLine) => default; // 0x0000000189A3E408-0x0000000189A3E500
		internal string KeyUsageExtension(bool multiLine) => default; // 0x0000000189A3E578-0x0000000189A3E670
		internal string SubjectKeyIdentifierExtension(bool multiLine) => default; // 0x0000000189A3EC6C-0x0000000189A3ED64
		internal string SubjectAltName(bool multiLine) => default; // 0x0000000189A3E998-0x0000000189A3EC6C
		internal string NetscapeCertType(bool multiLine) => default; // 0x0000000189A3E670-0x0000000189A3E998
	}
}

namespace System.Security.Cryptography.X509Certificates
{
	[Flags]
	public enum OpenFlags // TypeDefIndex: 45595
	{
		ReadOnly = 0,
		ReadWrite = 1,
		MaxAllowed = 2,
		OpenExistingOnly = 4,
		IncludeArchived = 8
	}

	public enum StoreLocation // TypeDefIndex: 45596
	{
		CurrentUser = 1,
		LocalMachine = 2
	}

	public enum StoreName // TypeDefIndex: 45597
	{
		AddressBook = 1,
		AuthRoot = 2,
		CertificateAuthority = 3,
		Disallowed = 4,
		My = 5,
		Root = 6,
		TrustedPeople = 7,
		TrustedPublisher = 8
	}

	[Flags]
	public enum X500DistinguishedNameFlags // TypeDefIndex: 45598
	{
		None = 0,
		Reversed = 1,
		UseSemicolons = 16,
		DoNotUsePlusSign = 32,
		DoNotUseQuotes = 64,
		UseCommas = 128,
		UseNewLines = 256,
		UseUTF8Encoding = 4096,
		UseT61Encoding = 8192,
		ForceUTF8Encoding = 16384
	}

	[Flags]
	public enum X509ChainStatusFlags // TypeDefIndex: 45599
	{
		NoError = 0,
		NotTimeValid = 1,
		NotTimeNested = 2,
		Revoked = 4,
		NotSignatureValid = 8,
		NotValidForUsage = 16,
		UntrustedRoot = 32,
		RevocationStatusUnknown = 64,
		Cyclic = 128,
		InvalidExtension = 256,
		InvalidPolicyConstraints = 512,
		InvalidBasicConstraints = 1024,
		InvalidNameConstraints = 2048,
		HasNotSupportedNameConstraint = 4096,
		HasNotDefinedNameConstraint = 8192,
		HasNotPermittedNameConstraint = 16384,
		HasExcludedNameConstraint = 32768,
		PartialChain = 65536,
		CtlNotTimeValid = 131072,
		CtlNotSignatureValid = 262144,
		CtlNotValidForUsage = 524288,
		HasWeakSignature = 1048576,
		OfflineRevocation = 16777216,
		NoIssuanceChainPolicy = 33554432,
		ExplicitDistrust = 67108864,
		HasNotSupportedCriticalExtension = 134217728
	}

	public enum X509FindType // TypeDefIndex: 45600
	{
		FindByThumbprint = 0,
		FindBySubjectName = 1,
		FindBySubjectDistinguishedName = 2,
		FindByIssuerName = 3,
		FindByIssuerDistinguishedName = 4,
		FindBySerialNumber = 5,
		FindByTimeValid = 6,
		FindByTimeNotYetValid = 7,
		FindByTimeExpired = 8,
		FindByTemplateName = 9,
		FindByApplicationPolicy = 10,
		FindByCertificatePolicy = 11,
		FindByExtension = 12,
		FindByKeyUsage = 13,
		FindBySubjectKeyIdentifier = 14
	}

	[Flags]
	public enum X509KeyUsageFlags // TypeDefIndex: 45601
	{
		None = 0,
		EncipherOnly = 1,
		CrlSign = 2,
		KeyCertSign = 4,
		KeyAgreement = 8,
		DataEncipherment = 16,
		KeyEncipherment = 32,
		NonRepudiation = 64,
		DigitalSignature = 128,
		DecipherOnly = 32768
	}

	public enum X509NameType // TypeDefIndex: 45602
	{
		SimpleName = 0,
		EmailName = 1,
		UpnName = 2,
		DnsName = 3,
		DnsFromAlternativeName = 4,
		UrlName = 5
	}

	public enum X509RevocationFlag // TypeDefIndex: 45603
	{
		EndCertificateOnly = 0,
		EntireChain = 1,
		ExcludeRoot = 2
	}

	public enum X509RevocationMode // TypeDefIndex: 45604
	{
		NoCheck = 0,
		Online = 1,
		Offline = 2
	}

	public enum X509SubjectKeyIdentifierHashAlgorithm // TypeDefIndex: 45605
	{
		Sha1 = 0,
		ShortSha1 = 1,
		CapiSha1 = 2
	}

	[Flags]
	public enum X509VerificationFlags // TypeDefIndex: 45606
	{
		NoFlag = 0,
		IgnoreNotTimeValid = 1,
		IgnoreCtlNotTimeValid = 2,
		IgnoreNotTimeNested = 4,
		IgnoreInvalidBasicConstraints = 8,
		AllowUnknownCertificateAuthority = 16,
		IgnoreWrongUsage = 32,
		IgnoreInvalidName = 64,
		IgnoreInvalidPolicy = 128,
		IgnoreEndRevocationUnknown = 256,
		IgnoreCtlSignerRevocationUnknown = 512,
		IgnoreCertificateAuthorityRevocationUnknown = 1024,
		IgnoreRootRevocationUnknown = 2048,
		AllFlags = 4095
	}

	public sealed class PublicKey // TypeDefIndex: 45607
	{
		// Fields
		private AsnEncodedData _keyValue; // 0x10
		private AsnEncodedData _params; // 0x18
		private System.Security.Cryptography.Oid _oid; // 0x20
		private static byte[] Empty; // 0x00
	
		// Properties
		public AsnEncodedData EncodedKeyValue { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public AsnEncodedData EncodedParameters { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public AsymmetricAlgorithm Key { get => default; } // 0x0000000189A432C4-0x0000000189A43464 
		public System.Security.Cryptography.Oid Oid { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public PublicKey() {} // Dummy constructor
		public PublicKey(System.Security.Cryptography.Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue) {} // 0x0000000189A430B4-0x0000000189A432C4
		static PublicKey() {} // 0x0000000189A43050-0x0000000189A430B4
	
		// Methods
		private static byte[] GetUnsignedBigInteger(byte[] integer) => default; // 0x0000000189A42FB8-0x0000000189A43050
		internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters) => default; // 0x0000000189A427B4-0x0000000189A42C3C
		internal static RSA DecodeRSA(byte[] rawPublicKey) => default; // 0x0000000189A42C3C-0x0000000189A42FB8
	}

	[MonoTODO("Some X500DistinguishedNameFlags options aren\'t supported, like DoNotUsePlusSign, DoNotUseQuotes and ForceUTF8Encoding")]
	public sealed class X500DistinguishedName : AsnEncodedData // TypeDefIndex: 45608
	{
		// Fields
		private string name; // 0x20
		private byte[] canonEncoding; // 0x28
	
		// Properties
		public string Name { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public X500DistinguishedName() {} // Dummy constructor
		public X500DistinguishedName(byte[] encodedDistinguishedName) {} // 0x0000000189A441AC-0x0000000189A442A8
		public X500DistinguishedName(string distinguishedName) {} // 0x0000000189A43F30-0x0000000189A43F40
		public X500DistinguishedName(string distinguishedName, X500DistinguishedNameFlags flag) {} // 0x0000000189A43F40-0x0000000189A441AC
	
		// Methods
		public string Decode(X500DistinguishedNameFlags flag) => default; // 0x0000000189A43D18-0x0000000189A43E74
		public override string Format(bool multiLine) => default; // 0x0000000189A43E74-0x0000000189A43ECC
		private static string GetSeparator(X500DistinguishedNameFlags flag) => default; // 0x0000000189A43ECC-0x0000000189A43F30
		private void DecodeRawData() {} // 0x0000000189A43C34-0x0000000189A43D18
		private static string Canonize(string s) => default; // 0x0000000189A43A9C-0x0000000189A43C34
		internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) => default; // 0x0000000189A438DC-0x0000000189A43A9C
	}

	public sealed class X509BasicConstraintsExtension : System.Security.Cryptography.X509Certificates.X509Extension // TypeDefIndex: 45609
	{
		// Fields
		internal const string oid = "2.5.29.19"; // Metadata: 0x01FBA1D2
		internal const string friendlyName = "Basic Constraints"; // Metadata: 0x01FBA1DC
		private bool _certificateAuthority; // 0x28
		private bool _hasPathLengthConstraint; // 0x29
		private int _pathLengthConstraint; // 0x2C
		private AsnDecodeStatus _status; // 0x30
	
		// Properties
		public bool CertificateAuthority { get => default; } // 0x0000000189A44C20-0x0000000189A44C90 
		public bool HasPathLengthConstraint { get => default; } // 0x0000000189A44C90-0x0000000189A44D00 
		public int PathLengthConstraint { get => default; } // 0x0000000189A44D00-0x0000000189A44D70 
	
		// Constructors
		public X509BasicConstraintsExtension() {} // 0x0000000189A44AC0-0x0000000189A44B4C
		public X509BasicConstraintsExtension(AsnEncodedData encodedBasicConstraints, bool critical) {} // 0x0000000189A44B4C-0x0000000189A44C20
		public X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) {} // 0x0000000189A44990-0x0000000189A44AC0
	
		// Methods
		public override void CopyFrom(AsnEncodedData asnEncodedData) {} // 0x0000000189A442A8-0x0000000189A44480
		internal AsnDecodeStatus Decode(byte[] extension) => default; // 0x0000000189A44480-0x0000000189A44614
		internal byte[] Encode() => default; // 0x0000000189A44614-0x0000000189A44760
		internal override string ToString(bool multiLine) => default; // 0x0000000189A44760-0x0000000189A44990
	}

	[Serializable]
	public class X509Certificate2 : System.Security.Cryptography.X509Certificates.X509Certificate // TypeDefIndex: 45610
	{
		// Fields
		private byte[] lazyRawData; // 0x60
		private System.Security.Cryptography.Oid lazySignatureAlgorithm; // 0x68
		private int lazyVersion; // 0x70
		private X500DistinguishedName lazySubjectName; // 0x78
		private X500DistinguishedName lazyIssuerName; // 0x80
		private PublicKey lazyPublicKey; // 0x88
		private AsymmetricAlgorithm lazyPrivateKey; // 0x90
		private System.Security.Cryptography.X509Certificates.X509ExtensionCollection lazyExtensions; // 0x98
	
		// Properties
		public System.Security.Cryptography.X509Certificates.X509ExtensionCollection Extensions { get => default; } // 0x0000000189A49AB4-0x0000000189A49D2C 
		public bool HasPrivateKey { get => default; } // 0x0000000189A49D2C-0x0000000189A49D68 
		public AsymmetricAlgorithm PrivateKey { get => default; } // 0x0000000189A49E30-0x0000000189A49FB8 
		public X500DistinguishedName IssuerName { get => default; } // 0x0000000189A49DB4-0x0000000189A49E20 
		public System.DateTime NotAfter { get => default; } // 0x0000000189A49E20-0x0000000189A49E28 
		public System.DateTime NotBefore { get => default; } // 0x0000000189A49E28-0x0000000189A49E30 
		public PublicKey PublicKey { get => default; } // 0x0000000189A49FB8-0x0000000189A4A128 
		public byte[] RawData { get => default; } // 0x0000000189A4A128-0x0000000189A4A190 
		public string SerialNumber { get => default; } // 0x0000000189A4A190-0x0000000189A4A198 
		public System.Security.Cryptography.Oid SignatureAlgorithm { get => default; } // 0x0000000189A4A198-0x0000000189A4A20C 
		public X500DistinguishedName SubjectName { get => default; } // 0x0000000189A4A20C-0x0000000189A4A270 
		public string Thumbprint { get => default; } // 0x0000000189A4A270-0x0000000189A4A28C 
		public int Version { get => default; } // 0x0000000189A4A28C-0x0000000189A4A2DC 
		internal new X509Certificate2Impl Impl { get => default; } // 0x0000000189A49D68-0x0000000189A49DB4 
	
		// Constructors
		public X509Certificate2() {} // 0x0000000189A49A90-0x0000000189A49A98
		public X509Certificate2(byte[] rawData) {} // 0x0000000189A49978-0x0000000189A49A88
		public X509Certificate2(byte[] rawData, string password) {} // 0x0000000189A49968-0x0000000189A49970
		internal X509Certificate2(X509Certificate2Impl impl) {} // 0x0000000189A49A88-0x0000000189A49A90
		public X509Certificate2(System.Security.Cryptography.X509Certificates.X509Certificate certificate) {} // 0x0000000189A49970-0x0000000189A49978
		protected X509Certificate2(SerializationInfo info, StreamingContext context) {} // 0x0000000189A49A98-0x0000000189A49AB4
	
		// Methods
		public override void Reset() {} // 0x0000000189A486BC-0x0000000189A48774
		public static X509ContentType GetCertContentType(byte[] rawData) => default; // 0x0000000189A485B8-0x0000000189A4865C
		public string GetNameInfo(X509NameType nameType, bool forIssuer) => default; // 0x0000000189A4865C-0x0000000189A486BC
		public override string ToString() => default; // 0x0000000189A4992C-0x0000000189A49938
		public override string ToString(bool verbose) => default; // 0x0000000189A48774-0x0000000189A4992C
		public bool Verify() => default; // 0x0000000189A49938-0x0000000189A49968
		private static System.Security.Cryptography.X509Certificates.X509Extension CreateCustomExtensionIfAny(System.Security.Cryptography.Oid oid) => default; // 0x0000000189A4840C-0x0000000189A485B8
	}

	public class X509Certificate2Collection : System.Security.Cryptography.X509Certificates.X509CertificateCollection // TypeDefIndex: 45611
	{
		// Fields
		private static string[] newline_split; // 0x00
	
		// Properties
		public new X509Certificate2 this[int index] { get => default; } // 0x0000000189A463DC-0x0000000189A46500 
	
		// Constructors
		public X509Certificate2Collection() {} // 0x00000001891207C8-0x00000001891207D0
		public X509Certificate2Collection(X509Certificate2Collection certificates) {} // 0x0000000189A463AC-0x0000000189A463DC
		static X509Certificate2Collection() {} // 0x0000000189A46320-0x0000000189A463AC
	
		// Methods
		public int Add(X509Certificate2 certificate) => default; // 0x0000000189A44DEC-0x0000000189A44E68
		[MonoTODO("Method isn\'t transactional (like documented)")]
		public void AddRange(X509Certificate2Collection certificates) {} // 0x0000000189A44D70-0x0000000189A44DEC
		public bool Contains(X509Certificate2 certificate) => default; // 0x0000000189A44E68-0x0000000189A4505C
		private string GetKeyIdentifier(X509Certificate2 x) => default; // 0x0000000189A46258-0x0000000189A46320
		[MonoTODO("Does not support X509FindType.FindByTemplateName, FindByApplicationPolicy and FindByCertificatePolicy")]
		public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) => default; // 0x0000000189A4505C-0x0000000189A461F8
		public new X509Certificate2Enumerator GetEnumerator() => default; // 0x0000000189A461F8-0x0000000189A46258
	}

	public sealed class X509Certificate2Enumerator : IEnumerator // TypeDefIndex: 45612
	{
		// Fields
		private IEnumerator enumerator; // 0x10
	
		// Properties
		public X509Certificate2 Current { get => default; } // 0x0000000189A46688-0x0000000189A466F0 
		object IEnumerator.Current { get => default; } // 0x0000000189A465DC-0x0000000189A46628 
	
		// Constructors
		public X509Certificate2Enumerator() {} // Dummy constructor
		internal X509Certificate2Enumerator(X509Certificate2Collection collection) {} // 0x0000000189A46628-0x0000000189A46688
	
		// Methods
		public bool MoveNext() => default; // 0x0000000189A46500-0x0000000189A46548
		bool IEnumerator.MoveNext() => default; // 0x0000000189A46548-0x0000000189A46590
		void IEnumerator.Reset() {} // 0x0000000189A46590-0x0000000189A465DC
	}

	internal abstract class X509Certificate2Impl : X509CertificateImpl // TypeDefIndex: 45613
	{
		// Properties
		public abstract IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> Extensions { get; }
		public abstract X500DistinguishedName IssuerName { get; }
		public abstract AsymmetricAlgorithm PrivateKey { get; set; }
		public abstract string SignatureAlgorithm { get; }
		public abstract X500DistinguishedName SubjectName { get; }
		public abstract int Version { get; }
		internal abstract X509CertificateImplCollection IntermediateCertificates { get; }
	
		// Constructors
		protected X509Certificate2Impl() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract string GetNameInfo(X509NameType nameType, bool forIssuer);
		public abstract bool Verify(X509Certificate2 thisCertificate);
		public abstract void AppendPrivateKeyInfo(StringBuilder sb);
	}

	internal class X509Certificate2ImplMono : X509Certificate2ImplUnix // TypeDefIndex: 45614
	{
		// Fields
		private X509CertificateImplCollection intermediateCerts; // 0xB0
		private Mono.Security.X509.X509Certificate _cert; // 0xB8
		private static string empty_error; // 0x00
		private static byte[] signedData; // 0x08
	
		// Properties
		public override bool IsValid { get => default; } // 0x00000001898CFEDC-0x00000001898CFEE8 
		private Mono.Security.X509.X509Certificate Cert { get => default; } // 0x0000000189A308A0-0x0000000189A308C0 
		public override bool HasPrivateKey { get => default; } // 0x0000000189A47524-0x0000000189A4753C 
		public override AsymmetricAlgorithm PrivateKey { get => default; set {} } // 0x0000000189A4753C-0x0000000189A478F4 0x0000000189A478F4-0x0000000189A47AB4
		internal override X509CertificateImplCollection IntermediateCertificates { get => default; } // 0x0000000183D4EAD0-0x0000000183D4EAE0 
		internal Mono.Security.X509.X509Certificate MonoCertificate { get => default; } // 0x0000000183D4E750-0x0000000183D4E760 
	
		// Constructors
		public X509Certificate2ImplMono() {} // Dummy constructor
		public X509Certificate2ImplMono(Mono.Security.X509.X509Certificate cert) {} // 0x00000001858AAF64-0x00000001858AAF78
		private X509Certificate2ImplMono(X509Certificate2ImplMono other) {} // 0x0000000189A474C0-0x0000000189A47524
		public X509Certificate2ImplMono(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) {} // 0x0000000189A47348-0x0000000189A474C0
		static X509Certificate2ImplMono() {} // 0x0000000189A47280-0x0000000189A47348
	
		// Methods
		public override X509CertificateImpl Clone() => default; // 0x0000000189A466F0-0x0000000189A4675C
		protected override byte[] GetRawCertData() => default; // 0x0000000189A467E4-0x0000000189A4681C
		public override RSA GetRSAPrivateKey() => default; // 0x0000000189A467A0-0x0000000189A467E4
		public override DSA GetDSAPrivateKey() => default; // 0x0000000189A4675C-0x0000000189A467A0
		private Mono.Security.X509.X509Certificate ImportPkcs12(byte[] rawData, SafePasswordHandle password) => default; // 0x0000000189A4716C-0x0000000189A471CC
		private Mono.Security.X509.X509Certificate ImportPkcs12(byte[] rawData, string password) => default; // 0x0000000189A4681C-0x0000000189A4716C
		[MonoTODO("by default this depends on the incomplete X509Chain")]
		public override bool Verify(X509Certificate2 thisCertificate) => default; // 0x0000000189A471CC-0x0000000189A47280
	}

	internal abstract class X509Certificate2ImplUnix : X509Certificate2Impl // TypeDefIndex: 45615
	{
		// Fields
		private bool readCertData; // 0x10
		private CertificateData certData; // 0x18
	
		// Properties
		public sealed override string KeyAlgorithm { get; } // 0x0000000189A481B4-0x0000000189A481D0 
		public sealed override byte[] KeyAlgorithmParameters { get; } // 0x0000000189A48198-0x0000000189A481B4 
		public sealed override byte[] PublicKeyValue { get; } // 0x0000000189A48268-0x0000000189A48284 
		public sealed override byte[] SerialNumber { get; } // 0x0000000189A482A0-0x0000000189A482BC 
		public sealed override string SignatureAlgorithm { get; } // 0x0000000189A482BC-0x0000000189A482DC 
		public sealed override int Version { get; } // 0x0000000189A483F0-0x0000000189A4840C 
		public sealed override X500DistinguishedName SubjectName { get; } // 0x0000000189A482DC-0x0000000189A482F8 
		public sealed override X500DistinguishedName IssuerName { get; } // 0x0000000189A48154-0x0000000189A48170 
		public sealed override string Subject { get; } // 0x0000000189A482F8-0x0000000189A48320 
		public sealed override string Issuer { get; } // 0x0000000189A48170-0x0000000189A48198 
		public sealed override byte[] RawData { get; } // 0x0000000189A48284-0x0000000189A482A0 
		public sealed override byte[] Thumbprint { get; } // 0x0000000189A48320-0x0000000189A483F0 
		public sealed override IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> Extensions { get; } // 0x0000000189A48134-0x0000000189A48154 
		public sealed override System.DateTime NotAfter { get; } // 0x0000000189A481D0-0x0000000189A4821C 
		public sealed override System.DateTime NotBefore { get; } // 0x0000000189A4821C-0x0000000189A48268 
	
		// Constructors
		protected X509Certificate2ImplUnix() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private void EnsureCertData() {} // 0x0000000189A47B30-0x0000000189A47C00
		protected abstract byte[] GetRawCertData();
		public sealed override string GetNameInfo(X509NameType nameType, bool forIssuer) => default; // 0x0000000189A480F4-0x0000000189A48134
		public sealed override void AppendPrivateKeyInfo(StringBuilder sb) {} // 0x0000000189A47AB4-0x0000000189A47B30
		public sealed override byte[] Export(X509ContentType contentType, SafePasswordHandle password) => default; // 0x0000000189A47FD8-0x0000000189A480F4
		private byte[] ExportPkcs12(SafePasswordHandle password) => default; // 0x0000000189A47C00-0x0000000189A47C4C
		private byte[] ExportPkcs12(string password) => default; // 0x0000000189A47C4C-0x0000000189A47FD8
	}

	[Serializable]
	public class X509CertificateCollection : CollectionBase // TypeDefIndex: 45617
	{
		// Properties
		public System.Security.Cryptography.X509Certificates.X509Certificate this[int index] { get => default; } // 0x0000000189A4A4B4-0x0000000189A4A514 
	
		// Nested types
		public class X509CertificateEnumerator : IEnumerator // TypeDefIndex: 45616
		{
			// Fields
			private IEnumerator enumerator; // 0x10
	
			// Properties
			public System.Security.Cryptography.X509Certificates.X509Certificate Current { get => default; } // 0x0000000189A4A69C-0x0000000189A4A704 
			object IEnumerator.Current { get => default; } // 0x0000000189A4A5F0-0x0000000189A4A63C 
	
			// Constructors
			public X509CertificateEnumerator() {} // Dummy constructor
			public X509CertificateEnumerator(X509CertificateCollection mappings) {} // 0x0000000189A4A63C-0x0000000189A4A69C
	
			// Methods
			bool IEnumerator.MoveNext() => default; // 0x0000000189A4A55C-0x0000000189A4A5A4
			void IEnumerator.Reset() {} // 0x0000000189A4A5A4-0x0000000189A4A5F0
			public bool MoveNext() => default; // 0x0000000189A4A514-0x0000000189A4A55C
		}
	
		// Constructors
		public X509CertificateCollection() {} // 0x00000001891207C8-0x00000001891207D0
		public X509CertificateCollection(X509CertificateCollection value) {} // 0x0000000189A4A484-0x0000000189A4A4B4
	
		// Methods
		public int Add(System.Security.Cryptography.X509Certificates.X509Certificate value) => default; // 0x0000000189A4A3A8-0x0000000189A4A424
		public void AddRange(X509CertificateCollection value) {} // 0x0000000189A4A2DC-0x0000000189A4A3A8
		public new X509CertificateEnumerator GetEnumerator() => default; // 0x0000000189A4A424-0x0000000189A4A484
		public override int GetHashCode() => default; // 0x0000000186FAB9A8-0x0000000186FAB9CC
	}

	internal class X509CertificateImplCollection : IDisposable // TypeDefIndex: 45618
	{
		// Fields
		private List<X509CertificateImpl> list; // 0x10
	
		// Properties
		public int Count { get => default; } // 0x0000000189A4AC8C-0x0000000189A4ACCC 
		public X509CertificateImpl this[int index] { get => default; } // 0x0000000189A4ACCC-0x0000000189A4AD20 
	
		// Constructors
		public X509CertificateImplCollection() {} // 0x0000000189A4AA60-0x0000000189A4AAD8
		private X509CertificateImplCollection(X509CertificateImplCollection other) {} // 0x0000000189A4AAD8-0x0000000189A4AC8C
	
		// Methods
		public void Add(X509CertificateImpl impl, bool takeOwnership) {} // 0x0000000189A4A704-0x0000000189A4A77C
		public X509CertificateImplCollection Clone() => default; // 0x0000000189A4A77C-0x0000000189A4A7DC
		public void Dispose() {} // 0x0000000189A4A99C-0x0000000189A4A9EC
		protected virtual void Dispose(bool disposing) {} // 0x0000000189A4A7DC-0x0000000189A4A99C
		~X509CertificateImplCollection() {} // 0x0000000189A4A9EC-0x0000000189A4AA60
	}

	public class X509Chain : IDisposable // TypeDefIndex: 45619
	{
		// Fields
		private X509ChainImpl impl; // 0x10
	
		// Properties
		internal X509ChainImpl Impl { get => default; } // 0x0000000189A4E6F4-0x0000000189A4E714 
		public X509ChainElementCollection ChainElements { get => default; } // 0x0000000189A4E67C-0x0000000189A4E6C4 
		public X509ChainPolicy ChainPolicy { get => default; } // 0x0000000189A4E6C4-0x0000000189A4E6F4 
	
		// Constructors
		public X509Chain() {} // 0x0000000189A4E648-0x0000000189A4E654
		public X509Chain(bool useMachineContext) {} // 0x0000000189A4E654-0x0000000189A4E67C
		internal X509Chain(X509ChainImpl impl) {} // 0x0000000189A4E614-0x0000000189A4E648
		[MonoTODO("Mono\'s X509Chain is fully managed. All handles are invalid.")]
		public X509Chain(IntPtr chainContext) {} // 0x0000000189A4E5C8-0x0000000189A4E614
	
		// Methods
		[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
		public bool Build(X509Certificate2 certificate) => default; // 0x0000000189A4E400-0x0000000189A4E444
		public void Reset() {} // 0x0000000189A4E594-0x0000000189A4E5C8
		public static X509Chain Create() => default; // 0x0000000189A4E444-0x0000000189A4E498
		public void Dispose() {} // 0x0000000189A4E4D0-0x0000000189A4E520
		protected virtual void Dispose(bool disposing) {} // 0x0000000189A4E498-0x0000000189A4E4D0
		~X509Chain() {} // 0x0000000189A4E520-0x0000000189A4E594
	}

	public class X509ChainElement // TypeDefIndex: 45620
	{
		// Fields
		private X509Certificate2 certificate; // 0x10
		private X509ChainStatus[] status; // 0x18
		private string info; // 0x20
		private System.Security.Cryptography.X509Certificates.X509ChainStatusFlags compressed_status_flags; // 0x28
	
		// Properties
		public X509Certificate2 Certificate { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public X509ChainStatus[] ChainElementStatus { get => default; } // 0x0000000181041090-0x00000001810410A0 
		internal System.Security.Cryptography.X509Certificates.X509ChainStatusFlags StatusFlags { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
	
		// Constructors
		public X509ChainElement() {} // Dummy constructor
		internal X509ChainElement(X509Certificate2 certificate) {} // 0x0000000189A4B5C4-0x0000000189A4B628
	
		// Methods
		private int Count(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags) => default; // 0x0000000189A4B1A4-0x0000000189A4B1D0
		private void Set(X509ChainStatus[] status, ref int position, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags mask) {} // 0x0000000189A4B1D0-0x0000000189A4B24C
		internal void UncompressFlags() {} // 0x0000000189A4B24C-0x0000000189A4B5C4
	}

	public sealed class X509ChainElementCollection : ICollection // TypeDefIndex: 45621
	{
		// Fields
		private ArrayList _list; // 0x10
	
		// Properties
		public int Count { get => default; } // 0x000000018920A6DC-0x000000018920A700 
		public bool IsSynchronized { get => default; } // 0x0000000189209E4C-0x0000000189209E70 
		public X509ChainElement this[int index] { get => default; } // 0x0000000189A4AF9C-0x0000000189A4AFFC 
		public object SyncRoot { get => default; } // 0x0000000189209E70-0x0000000189209E94 
	
		// Constructors
		internal X509ChainElementCollection() {} // 0x0000000189A4AF38-0x0000000189A4AF9C
	
		// Methods
		void ICollection.CopyTo(Array array, int index) {} // 0x0000000189209E20-0x0000000189209E4C
		public X509ChainElementEnumerator GetEnumerator() => default; // 0x0000000189A4AE70-0x0000000189A4AED4
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189A4AED4-0x0000000189A4AF38
		internal void Add(X509Certificate2 certificate) {} // 0x0000000189A4AD20-0x0000000189A4ADA4
		internal void Clear() {} // 0x0000000189A1CC60-0x0000000189A1CC84
		internal bool Contains(X509Certificate2 certificate) => default; // 0x0000000189A4ADA4-0x0000000189A4AE70
	}

	public sealed class X509ChainElementEnumerator : IEnumerator // TypeDefIndex: 45622
	{
		// Fields
		private IEnumerator enumerator; // 0x10
	
		// Properties
		public X509ChainElement Current { get => default; } // 0x0000000189A4B13C-0x0000000189A4B1A4 
		object IEnumerator.Current { get => default; } // 0x0000000189A4B090-0x0000000189A4B0DC 
	
		// Constructors
		public X509ChainElementEnumerator() {} // Dummy constructor
		internal X509ChainElementEnumerator(IEnumerable enumerable) {} // 0x0000000189A4B0DC-0x0000000189A4B13C
	
		// Methods
		public bool MoveNext() => default; // 0x0000000189A4AFFC-0x0000000189A4B044
		public void Reset() {} // 0x0000000189A4B044-0x0000000189A4B090
	}

	internal abstract class X509ChainImpl : IDisposable // TypeDefIndex: 45623
	{
		// Properties
		public abstract bool IsValid { get; }
		public abstract X509ChainElementCollection ChainElements { get; }
		public abstract X509ChainPolicy ChainPolicy { get; }
	
		// Constructors
		protected X509ChainImpl() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected void ThrowIfContextInvalid() {} // 0x0000000189A4DE84-0x0000000189A4DECC
		public abstract bool Build(X509Certificate2 certificate);
		public abstract void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags errorCode);
		public abstract void Reset();
		public void Dispose() {} // 0x0000000189A4DE34-0x0000000189A4DE84
		protected virtual void Dispose(bool disposing) {} // 0x000000018350B670-0x000000018350B680
		~X509ChainImpl() {} // 0x0000000189436EE0-0x0000000189436F58
	}

	internal class X509ChainImplMono : X509ChainImpl // TypeDefIndex: 45624
	{
		// Fields
		private StoreLocation location; // 0x10
		private X509ChainElementCollection elements; // 0x18
		private X509ChainPolicy policy; // 0x20
		private X509ChainStatus[] status; // 0x28
		private static X509ChainStatus[] Empty; // 0x00
		private int max_path_length; // 0x30
		private X500DistinguishedName working_issuer_name; // 0x38
		private AsymmetricAlgorithm working_public_key; // 0x40
		private X509ChainElement bce_restriction; // 0x48
		private X509Certificate2Collection roots; // 0x50
		private X509Certificate2Collection cas; // 0x58
		private System.Security.Cryptography.X509Certificates.X509Store root_store; // 0x60
		private System.Security.Cryptography.X509Certificates.X509Store ca_store; // 0x68
		private System.Security.Cryptography.X509Certificates.X509Store user_root_store; // 0x70
		private System.Security.Cryptography.X509Certificates.X509Store user_ca_store; // 0x78
		private X509Certificate2Collection collection; // 0x80
	
		// Properties
		public override bool IsValid { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override X509ChainElementCollection ChainElements { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public override X509ChainPolicy ChainPolicy { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		private X509Certificate2Collection Roots { get => default; } // 0x0000000189A4DB50-0x0000000189A4DC2C 
		private X509Certificate2Collection CertificateAuthorities { get => default; } // 0x0000000189A4D774-0x0000000189A4D850 
		private System.Security.Cryptography.X509Certificates.X509Store LMRootStore { get => default; } // 0x0000000189A4DA4C-0x0000000189A4DB50 
		private System.Security.Cryptography.X509Certificates.X509Store UserRootStore { get => default; } // 0x0000000189A4DD30-0x0000000189A4DE34 
		private System.Security.Cryptography.X509Certificates.X509Store LMCAStore { get => default; } // 0x0000000189A4D948-0x0000000189A4DA4C 
		private System.Security.Cryptography.X509Certificates.X509Store UserCAStore { get => default; } // 0x0000000189A4DC2C-0x0000000189A4DD30 
		private X509Certificate2Collection CertificateCollection { get => default; } // 0x0000000189A4D850-0x0000000189A4D948 
	
		// Constructors
		public X509ChainImplMono() {} // Dummy constructor
		public X509ChainImplMono(bool useMachineContext) {} // 0x0000000189A4D6CC-0x0000000189A4D774
		static X509ChainImplMono() {} // 0x0000000189A4D668-0x0000000189A4D6CC
	
		// Methods
		public override void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error) {} // 0x000000018350B670-0x000000018350B680
		[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
		public override bool Build(X509Certificate2 certificate) => default; // 0x0000000189A4B714-0x0000000189A4BC40
		public override void Reset() {} // 0x0000000189A4D200-0x0000000189A4D328
		private System.Security.Cryptography.X509Certificates.X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) => default; // 0x0000000189A4B628-0x0000000189A4B714
		private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) => default; // 0x0000000189A4D328-0x0000000189A4D498
		private X509Certificate2 FindParent(X509Certificate2 certificate) => default; // 0x0000000189A4C420-0x0000000189A4C54C
		private bool IsChainComplete(X509Certificate2 certificate) => default; // 0x0000000189A4C808-0x0000000189A4C8C0
		private bool IsSelfIssued(X509Certificate2 certificate) => default; // 0x0000000189A4C8C0-0x0000000189A4C908
		private void ValidateChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag) {} // 0x0000000189A4D498-0x0000000189A4D5D4
		private void Process(int n) {} // 0x0000000189A4CF8C-0x0000000189A4D200
		private void PrepareForNextCertificate(int n) {} // 0x0000000189A4C94C-0x0000000189A4CB4C
		private void WrapUp() {} // 0x0000000189A4D5D4-0x0000000189A4D668
		private void ProcessCertificateExtensions(X509ChainElement element) {} // 0x0000000189A4CB4C-0x0000000189A4CC34
		private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) => default; // 0x0000000189A4C908-0x0000000189A4C94C
		private string GetSubjectKeyIdentifier(X509Certificate2 certificate) => default; // 0x0000000189A4C768-0x0000000189A4C808
		private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) => default; // 0x0000000189A4C54C-0x0000000189A4C5CC
		private static string GetAuthorityKeyIdentifier(X509Crl crl) => default; // 0x0000000189A4C5CC-0x0000000189A4C640
		private static string GetAuthorityKeyIdentifier(Mono.Security.X509.X509Extension ext) => default; // 0x0000000189A4C640-0x0000000189A4C768
		private void CheckRevocationOnChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag) {} // 0x0000000189A4BE40-0x0000000189A4C008
		private System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) => default; // 0x0000000189A4C1D8-0x0000000189A4C2A4
		private System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) => default; // 0x0000000189A4C008-0x0000000189A4C1D8
		private static X509Crl CheckCrls(string subject, string ski, Mono.Security.X509.X509Store store) => default; // 0x0000000189A4BC40-0x0000000189A4BE40
		private X509Crl FindCrl(X509Certificate2 caCertificate) => default; // 0x0000000189A4C2A4-0x0000000189A4C420
		private bool ProcessCrlExtensions(X509Crl crl) => default; // 0x0000000189A4CDCC-0x0000000189A4CF8C
		private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry) => default; // 0x0000000189A4CC34-0x0000000189A4CDCC
	}

	public sealed class X509ChainPolicy // TypeDefIndex: 45625
	{
		// Fields
		private OidCollection apps; // 0x10
		private OidCollection cert; // 0x18
		private System.Security.Cryptography.X509Certificates.X509CertificateCollection store; // 0x20
		private X509Certificate2Collection store2; // 0x28
		private X509RevocationFlag rflag; // 0x30
		private X509RevocationMode mode; // 0x34
		private TimeSpan timeout; // 0x38
		private X509VerificationFlags vflags; // 0x40
		private System.DateTime vtime; // 0x48
	
		// Properties
		public X509Certificate2Collection ExtraStore { get => default; internal set {} } // 0x0000000189A4DFD8-0x0000000189A4E1B0 0x0000000182C92F10-0x0000000182C92F20
		public X509RevocationFlag RevocationFlag { get => default; } // 0x0000000183D4ED20-0x0000000183D4ED30 
		public X509RevocationMode RevocationMode { get => default; set {} } // 0x0000000183D4EE00-0x0000000183D4EE10 0x0000000189A4E1B0-0x0000000189A4E218
		public X509VerificationFlags VerificationFlags { get => default; set {} } // 0x0000000183D4ED80-0x0000000183D4ED90 0x0000000189A4E218-0x0000000189A4E28C
		public System.DateTime VerificationTime { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
	
		// Constructors
		public X509ChainPolicy() {} // 0x0000000189A4DFD0-0x0000000189A4DFD8
	
		// Methods
		public void Reset() {} // 0x0000000189A4DECC-0x0000000189A4DFD0
	}

	public struct X509ChainStatus // TypeDefIndex: 45626
	{
		// Fields
		private System.Security.Cryptography.X509Certificates.X509ChainStatusFlags status; // 0x00
		private string info; // 0x08
	
		// Properties
		public System.Security.Cryptography.X509Certificates.X509ChainStatusFlags Status { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public string StatusInformation { set {} } // 0x000000018558FF08-0x000000018558FF18
	
		// Constructors
		internal X509ChainStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag) : this() {
			status = default;
			info = default;
		} // 0x0000000189A4E3D8-0x0000000189A4E400
	
		// Methods
		internal static string GetInformation(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags) => default; // 0x0000000189A4E28C-0x0000000189A4E3D8
	}

	public sealed class X509EnhancedKeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension // TypeDefIndex: 45627
	{
		// Fields
		private OidCollection _enhKeyUsage; // 0x28
		private AsnDecodeStatus _status; // 0x30
	
		// Constructors
		public X509EnhancedKeyUsageExtension() {} // 0x0000000189A4EE58-0x0000000189A4EEE4
		public X509EnhancedKeyUsageExtension(AsnEncodedData encodedEnhancedKeyUsages, bool critical) {} // 0x0000000189A4EEE4-0x0000000189A4EFB8
		public X509EnhancedKeyUsageExtension(OidCollection enhancedKeyUsages, bool critical) {} // 0x0000000189A4EFB8-0x0000000189A4F150
	
		// Methods
		public override void CopyFrom(AsnEncodedData asnEncodedData) {} // 0x0000000189A4E714-0x0000000189A4E8EC
		internal AsnDecodeStatus Decode(byte[] extension) => default; // 0x0000000189A4E8EC-0x0000000189A4EB24
		internal byte[] Encode() => default; // 0x0000000189A4EB24-0x0000000189A4EBD8
		internal override string ToString(bool multiLine) => default; // 0x0000000189A4EBD8-0x0000000189A4EE58
	}

	public class X509Extension : AsnEncodedData // TypeDefIndex: 45628
	{
		// Fields
		private bool _critical; // 0x20
	
		// Properties
		public bool Critical { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
	
		// Constructors
		protected X509Extension() {} // 0x000000018350B670-0x000000018350B680
		public X509Extension(string oid, byte[] rawData, bool critical) {} // 0x0000000189A4FA74-0x0000000189A4FA9C
	
		// Methods
		public override void CopyFrom(AsnEncodedData asnEncodedData) {} // 0x0000000189A4F878-0x0000000189A4F994
		internal string FormatUnkownData(byte[] data) => default; // 0x0000000189A4F994-0x0000000189A4FA74
	}

	public sealed class X509ExtensionCollection : ICollection // TypeDefIndex: 45629
	{
		// Fields
		private static byte[] Empty; // 0x00
		private ArrayList _list; // 0x10
	
		// Properties
		public int Count { get => default; } // 0x000000018920A6DC-0x000000018920A700 
		public bool IsSynchronized { get => default; } // 0x0000000189209E4C-0x0000000189209E70 
		public object SyncRoot { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		public System.Security.Cryptography.X509Certificates.X509Extension this[string oid] { get => default; } // 0x0000000189A4F4B4-0x0000000189A4F700 
	
		// Constructors
		public X509ExtensionCollection() {} // 0x0000000189A4F450-0x0000000189A4F4B4
		static X509ExtensionCollection() {} // 0x0000000189A4F3EC-0x0000000189A4F450
	
		// Methods
		public int Add(System.Security.Cryptography.X509Certificates.X509Extension extension) => default; // 0x0000000189A4F150-0x0000000189A4F1CC
		void ICollection.CopyTo(Array array, int index) {} // 0x0000000189A4F230-0x0000000189A4F388
		public X509ExtensionEnumerator GetEnumerator() => default; // 0x0000000189A4F1CC-0x0000000189A4F230
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189A4F388-0x0000000189A4F3EC
	}

	public sealed class X509ExtensionEnumerator : IEnumerator // TypeDefIndex: 45630
	{
		// Fields
		private IEnumerator enumerator; // 0x10
	
		// Properties
		public System.Security.Cryptography.X509Certificates.X509Extension Current { get => default; } // 0x0000000189A4F810-0x0000000189A4F878 
		object IEnumerator.Current { get => default; } // 0x0000000189A4F794-0x0000000189A4F7E0 
	
		// Constructors
		public X509ExtensionEnumerator() {} // Dummy constructor
		internal X509ExtensionEnumerator(ArrayList list) {} // 0x0000000189A4F7E0-0x0000000189A4F810
	
		// Methods
		public bool MoveNext() => default; // 0x0000000189A4F700-0x0000000189A4F748
		public void Reset() {} // 0x0000000189A4F748-0x0000000189A4F794
	}

	internal static class X509Helper2 // TypeDefIndex: 45631
	{
		// Methods
		[MonoTODO("Investigate replacement; see comments in source.")]
		internal static Mono.Security.X509.X509Certificate GetMonoCertificate(X509Certificate2 certificate) => default; // 0x0000000189A4FB6C-0x0000000189A4FC10
		internal static X509ChainImpl CreateChainImpl(bool useMachineContext) => default; // 0x0000000189A4FA9C-0x0000000189A4FAFC
		public static bool IsValid(X509ChainImpl impl) => default; // 0x0000000189191FCC-0x0000000189191FE4
		internal static void ThrowIfContextInvalid(X509ChainImpl impl) {} // 0x0000000189A4FC10-0x0000000189A4FC50
		internal static Exception GetInvalidChainContextException() => default; // 0x0000000189A4FAFC-0x0000000189A4FB6C
	}

	public sealed class X509KeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension // TypeDefIndex: 45632
	{
		// Fields
		internal const string oid = "2.5.29.15"; // Metadata: 0x01FBA1EE
		internal const string friendlyName = "Key Usage"; // Metadata: 0x01FBA1F8
		internal const X509KeyUsageFlags all = X509KeyUsageFlags.None | X509KeyUsageFlags.EncipherOnly | X509KeyUsageFlags.CrlSign | X509KeyUsageFlags.KeyCertSign | X509KeyUsageFlags.KeyAgreement | X509KeyUsageFlags.DataEncipherment | X509KeyUsageFlags.KeyEncipherment | X509KeyUsageFlags.NonRepudiation | X509KeyUsageFlags.DigitalSignature | X509KeyUsageFlags.DecipherOnly; // Metadata: 0x01FBA202
		private X509KeyUsageFlags _keyUsages; // 0x28
		private AsnDecodeStatus _status; // 0x2C
	
		// Properties
		public X509KeyUsageFlags KeyUsages { get => default; } // 0x0000000189A507C8-0x0000000189A50838 
	
		// Constructors
		public X509KeyUsageExtension() {} // 0x0000000189A5073C-0x0000000189A507C8
		public X509KeyUsageExtension(AsnEncodedData encodedKeyUsage, bool critical) {} // 0x0000000189A50588-0x0000000189A5065C
		public X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical) {} // 0x0000000189A5065C-0x0000000189A5073C
	
		// Methods
		public override void CopyFrom(AsnEncodedData asnEncodedData) {} // 0x0000000189A4FC50-0x0000000189A4FE28
		internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) => default; // 0x0000000189A50118-0x0000000189A50128
		internal AsnDecodeStatus Decode(byte[] extension) => default; // 0x0000000189A4FE28-0x0000000189A4FFC8
		internal byte[] Encode() => default; // 0x0000000189A4FFC8-0x0000000189A50118
		internal override string ToString(bool multiLine) => default; // 0x0000000189A50128-0x0000000189A50588
	}

	public sealed class X509Store : IDisposable // TypeDefIndex: 45633
	{
		// Fields
		private string _name; // 0x10
		private StoreLocation _location; // 0x18
		private X509Certificate2Collection list; // 0x20
		private OpenFlags _flags; // 0x28
		private Mono.Security.X509.X509Store store; // 0x30
	
		// Properties
		public X509Certificate2Collection Certificates { get => default; } // 0x0000000189A50D88-0x0000000189A50E0C 
		private X509Stores Factory { get => default; } // 0x0000000189A50E0C-0x0000000189A50E30 
		internal Mono.Security.X509.X509Store Store { get => default; } // 0x0000000181003830-0x0000000181003840 
	
		// Constructors
		public X509Store() {} // Dummy constructor
		public X509Store(StoreName storeName, StoreLocation storeLocation) {} // 0x0000000189A50C40-0x0000000189A50D88
	
		// Methods
		public void Close() {} // 0x0000000189A50838-0x0000000189A5086C
		public void Dispose() {} // 0x0000000189A5086C-0x0000000189A50874
		public void Open(OpenFlags flags) {} // 0x0000000189A50874-0x0000000189A50C40
	}

	public sealed class X509SubjectKeyIdentifierExtension : System.Security.Cryptography.X509Certificates.X509Extension // TypeDefIndex: 45634
	{
		// Fields
		internal const string oid = "2.5.29.14"; // Metadata: 0x01FBA206
		internal const string friendlyName = "Subject Key Identifier"; // Metadata: 0x01FBA210
		private byte[] _subjectKeyIdentifier; // 0x28
		private string _ski; // 0x30
		private AsnDecodeStatus _status; // 0x38
	
		// Properties
		public string SubjectKeyIdentifier { get => default; } // 0x0000000189A51DD8-0x0000000189A52018 
	
		// Constructors
		public X509SubjectKeyIdentifierExtension() {} // 0x0000000189A51D4C-0x0000000189A51DD8
		public X509SubjectKeyIdentifierExtension(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) {} // 0x0000000189A51934-0x0000000189A51A08
		public X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical) {} // 0x0000000189A51A08-0x0000000189A51BC0
		public X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical) {} // 0x0000000189A51BC0-0x0000000189A51D4C
		public X509SubjectKeyIdentifierExtension(PublicKey key, bool critical) {} // 0x0000000189A51914-0x0000000189A51934
		public X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) {} // 0x0000000189A514F8-0x0000000189A51914
	
		// Methods
		public override void CopyFrom(AsnEncodedData asnEncodedData) {} // 0x0000000189A50E30-0x0000000189A51008
		internal static byte FromHexChar(char c) => default; // 0x0000000189A511C4-0x0000000189A511F0
		internal static byte FromHexChars(char c1, char c2) => default; // 0x0000000189A511F0-0x0000000189A51228
		internal static byte[] FromHex(string hex) => default; // 0x0000000189A51228-0x0000000189A5130C
		internal AsnDecodeStatus Decode(byte[] extension) => default; // 0x0000000189A51008-0x0000000189A51160
		internal byte[] Encode() => default; // 0x0000000189A51160-0x0000000189A511C4
		internal override string ToString(bool multiLine) => default; // 0x0000000189A5130C-0x0000000189A514F8
	}
}

namespace System.Text.RegularExpressions
{
	public class Capture // TypeDefIndex: 45529
	{
		// Properties
		public int Index { get; private protected set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public int Length { get; private protected set; } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
		internal string Text { get; private protected set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public string Value { get => default; } // 0x00000001825FC670-0x00000001825FC6A0 
	
		// Constructors
		public Capture() {} // Dummy constructor
		internal Capture(string text, int index, int length) {} // 0x00000001825FEAD0-0x00000001825FEB00
	
		// Methods
		public override string ToString() => default; // 0x0000000183D2D7E0-0x0000000183D2D7F0
		internal ReadOnlySpan<char> GetLeftSubstring() => default; // 0x0000000189A31FB8-0x0000000189A31FE8
		internal ReadOnlySpan<char> GetRightSubstring() => default; // 0x0000000189A31FE8-0x0000000189A32034
	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<System.Text.RegularExpressions.Capture>))]
	public class CaptureCollection : IList<System.Text.RegularExpressions.Capture>, IReadOnlyList<System.Text.RegularExpressions.Capture>, IList // TypeDefIndex: 45531
	{
		// Fields
		private readonly System.Text.RegularExpressions.Group _group; // 0x10
		private readonly int _capcount; // 0x18
		private System.Text.RegularExpressions.Capture[] _captures; // 0x20
	
		// Properties
		public bool IsReadOnly { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public int Count { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public System.Text.RegularExpressions.Capture this[int i] { get => default; } // 0x0000000189A31C00-0x0000000189A31C08 
		public bool IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public object SyncRoot { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		System.Text.RegularExpressions.Capture IList<System.Text.RegularExpressions.Capture>.this[int index] { get => default; set {} } // 0x0000000189A31C00-0x0000000189A31C08 0x0000000189A31C08-0x0000000189A31C64
		bool IList.IsFixedSize { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		object IList.this[int index] { get => default; set {} } // 0x0000000189A31C00-0x0000000189A31C08 0x0000000189A31F2C-0x0000000189A31F88
	
		// Nested types
		[Serializable]
		private sealed class Enumerator : IEnumerator<System.Text.RegularExpressions.Capture> // TypeDefIndex: 45530
		{
			// Fields
			private readonly CaptureCollection _collection; // 0x10
			private int _index; // 0x18
	
			// Properties
			public System.Text.RegularExpressions.Capture Current { get => default; } // 0x0000000189A32D98-0x0000000189A32E1C 
			object IEnumerator.Current { get => default; } // 0x0000000189A32C70-0x0000000189A32C78 
	
			// Constructors
			public Enumerator() {} // Dummy constructor
			internal Enumerator(CaptureCollection collection) {} // 0x00000001830840F0-0x0000000183084120
	
			// Methods
			public bool MoveNext() => default; // 0x0000000189A32C34-0x0000000189A32C68
			void IEnumerator.Reset() {} // 0x0000000183D50330-0x0000000183D50340
			void IDisposable.Dispose() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public CaptureCollection() {} // Dummy constructor
		internal CaptureCollection(System.Text.RegularExpressions.Group group) {} // 0x0000000189A31F88-0x0000000189A31FB8
	
		// Methods
		public IEnumerator GetEnumerator() => default; // 0x0000000189A31864-0x0000000189A318C4
		IEnumerator<System.Text.RegularExpressions.Capture> IEnumerable<Capture>.GetEnumerator() => default; // 0x0000000189A31A28-0x0000000189A31A88
		private System.Text.RegularExpressions.Capture GetCapture(int i) => default; // 0x0000000189A317B0-0x0000000189A31864
		internal void ForceInitialized() {} // 0x0000000189A31668-0x0000000189A317B0
		public void CopyTo(Array array, int arrayIndex) {} // 0x0000000189A315B0-0x0000000189A31668
		public void CopyTo(System.Text.RegularExpressions.Capture[] array, int arrayIndex) {} // 0x0000000189A3141C-0x0000000189A315B0
		int IList<Capture>.IndexOf(System.Text.RegularExpressions.Capture item) => default; // 0x0000000189A31A88-0x0000000189A31B48
		void IList<Capture>.Insert(int index, System.Text.RegularExpressions.Capture item) {} // 0x0000000189A31B48-0x0000000189A31BA4
		void IList<Capture>.RemoveAt(int index) {} // 0x0000000189A31BA4-0x0000000189A31C00
		void ICollection<Capture>.Add(System.Text.RegularExpressions.Capture item) {} // 0x0000000189A318C4-0x0000000189A31920
		void ICollection<Capture>.Clear() {} // 0x0000000189A31920-0x0000000189A3197C
		bool ICollection<Capture>.Contains(System.Text.RegularExpressions.Capture item) => default; // 0x0000000189A3197C-0x0000000189A319CC
		bool ICollection<Capture>.Remove(System.Text.RegularExpressions.Capture item) => default; // 0x0000000189A319CC-0x0000000189A31A28
		int IList.Add(object value) => default; // 0x0000000189A31C64-0x0000000189A31CC0
		void IList.Clear() {} // 0x0000000189A31CC0-0x0000000189A31D1C
		bool IList.Contains(object value) => default; // 0x0000000189A31D1C-0x0000000189A31D98
		int IList.IndexOf(object value) => default; // 0x0000000189A31D98-0x0000000189A31E18
		void IList.Insert(int index, object value) {} // 0x0000000189A31E18-0x0000000189A31E74
		void IList.Remove(object value) {} // 0x0000000189A31ED0-0x0000000189A31F2C
		void IList.RemoveAt(int index) {} // 0x0000000189A31E74-0x0000000189A31ED0
	}

	internal sealed class CollectionDebuggerProxy<T> // TypeDefIndex: 45532
	{
		// Constructors
		public CollectionDebuggerProxy() {} // Dummy constructor
	}

	[Serializable]
	public class Group : System.Text.RegularExpressions.Capture // TypeDefIndex: 45533
	{
		// Fields
		internal static readonly Group s_emptyGroup; // 0x00
		internal readonly int[] _caps; // 0x20
		internal int _capcount; // 0x28
		internal CaptureCollection _capcoll; // 0x30
	
		// Properties
		public bool Success { get => default; } // 0x00000001825FB2D0-0x00000001825FB2E0 
		public CaptureCollection Captures { get => default; } // 0x0000000189A33840-0x0000000189A338B4 
	
		// Constructors
		internal Group(string text, int[] caps, int capcount, string name) {} // 0x00000001825FEA30-0x00000001825FEAD0
		static Group() {} // 0x000000018300A7A0-0x000000018300AA90
		internal Group() {} // 0x0000000189A33810-0x0000000189A33840
	}

	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<System.Text.RegularExpressions.Group>))]
	public class GroupCollection : IList<System.Text.RegularExpressions.Group>, IReadOnlyList<System.Text.RegularExpressions.Group>, IList // TypeDefIndex: 45535
	{
		// Fields
		private readonly System.Text.RegularExpressions.Match _match; // 0x10
		private readonly Hashtable _captureMap; // 0x18
		private System.Text.RegularExpressions.Group[] _groups; // 0x20
	
		// Properties
		public bool IsReadOnly { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public int Count { get => default; } // 0x0000000189A337EC-0x0000000189A33810 
		public System.Text.RegularExpressions.Group this[int groupnum] { get => default; } // 0x0000000184270A80-0x0000000184270A88 
		public System.Text.RegularExpressions.Group this[string groupname] { get => default; } // 0x0000000182CDC8F0-0x0000000182CDC970 
		public bool IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public object SyncRoot { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		System.Text.RegularExpressions.Group IList<System.Text.RegularExpressions.Group>.this[int index] { get => default; set {} } // 0x0000000184270A80-0x0000000184270A88 0x0000000189A3343C-0x0000000189A33498
		bool IList.IsFixedSize { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		object IList.this[int index] { get => default; set {} } // 0x0000000184270A80-0x0000000184270A88 0x0000000189A33760-0x0000000189A337BC
	
		// Nested types
		private sealed class Enumerator : IEnumerator<System.Text.RegularExpressions.Group> // TypeDefIndex: 45534
		{
			// Fields
			private readonly GroupCollection _collection; // 0x10
			private int _index; // 0x18
	
			// Properties
			public System.Text.RegularExpressions.Group Current { get => default; } // 0x0000000189A32C80-0x0000000189A32D1C 
			object IEnumerator.Current { get => default; } // 0x0000000189A32C68-0x0000000189A32C70 
	
			// Constructors
			public Enumerator() {} // Dummy constructor
			internal Enumerator(GroupCollection collection) {} // 0x00000001830840F0-0x0000000183084120
	
			// Methods
			public bool MoveNext() => default; // 0x0000000189A32BF8-0x0000000189A32C34
			void IEnumerator.Reset() {} // 0x0000000183D50330-0x0000000183D50340
			void IDisposable.Dispose() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		internal GroupCollection(System.Text.RegularExpressions.Match match, Hashtable caps) {} // 0x0000000182676770-0x00000001826767A0
		internal GroupCollection() {} // 0x0000000189A337BC-0x0000000189A337EC
	
		// Methods
		public IEnumerator GetEnumerator() => default; // 0x0000000189A33090-0x0000000189A330F0
		IEnumerator<System.Text.RegularExpressions.Group> IEnumerable<Group>.GetEnumerator() => default; // 0x0000000189A33254-0x0000000189A332B4
		private System.Text.RegularExpressions.Group GetGroup(int groupnum) => default; // 0x00000001825FEB80-0x00000001825FEC20
		private System.Text.RegularExpressions.Group GetGroupImpl(int groupnum) => default; // 0x00000001825FEC20-0x00000001825FEE20
		public void CopyTo(Array array, int arrayIndex) {} // 0x0000000189A32E1C-0x0000000189A32EE4
		public void CopyTo(System.Text.RegularExpressions.Group[] array, int arrayIndex) {} // 0x0000000189A32EE4-0x0000000189A33090
		int IList<Group>.IndexOf(System.Text.RegularExpressions.Group item) => default; // 0x0000000189A332B4-0x0000000189A33384
		void IList<Group>.Insert(int index, System.Text.RegularExpressions.Group item) {} // 0x0000000189A33384-0x0000000189A333E0
		void IList<Group>.RemoveAt(int index) {} // 0x0000000189A333E0-0x0000000189A3343C
		void ICollection<Group>.Add(System.Text.RegularExpressions.Group item) {} // 0x0000000189A330F0-0x0000000189A3314C
		void ICollection<Group>.Clear() {} // 0x0000000189A3314C-0x0000000189A331A8
		bool ICollection<Group>.Contains(System.Text.RegularExpressions.Group item) => default; // 0x0000000189A331A8-0x0000000189A331F8
		bool ICollection<Group>.Remove(System.Text.RegularExpressions.Group item) => default; // 0x0000000189A331F8-0x0000000189A33254
		int IList.Add(object value) => default; // 0x0000000189A33498-0x0000000189A334F4
		void IList.Clear() {} // 0x0000000189A334F4-0x0000000189A33550
		bool IList.Contains(object value) => default; // 0x0000000189A33550-0x0000000189A335CC
		int IList.IndexOf(object value) => default; // 0x0000000189A335CC-0x0000000189A3364C
		void IList.Insert(int index, object value) {} // 0x0000000189A3364C-0x0000000189A336A8
		void IList.Remove(object value) {} // 0x0000000189A33704-0x0000000189A33760
		void IList.RemoveAt(int index) {} // 0x0000000189A336A8-0x0000000189A33704
	}

	[Serializable]
	public class Match : System.Text.RegularExpressions.Group // TypeDefIndex: 45536
	{
		// Fields
		internal GroupCollection _groupcoll; // 0x40
		internal Regex _regex; // 0x48
		internal int _textbeg; // 0x50
		internal int _textpos; // 0x54
		internal int _textend; // 0x58
		internal int _textstart; // 0x5C
		internal int[][] _matches; // 0x60
		internal int[] _matchcount; // 0x68
		internal bool _balancing; // 0x70
	
		// Properties
		public static Match Empty { get; } // 0x0000000189A34914-0x0000000189A34964 
		public virtual GroupCollection Groups { get => default; } // 0x00000001832E13A0-0x00000001832E1420 
	
		// Constructors
		internal Match(Regex regex, int capcount, string text, int begpos, int len, int startpos) {} // 0x00000001825FE8A0-0x00000001825FEA30
		static Match() {} // 0x0000000183CAC1D0-0x0000000183CAC290
		internal Match() {} // 0x0000000189A348E4-0x0000000189A34914
	
		// Methods
		internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) {} // 0x00000001833E0880-0x00000001833E0900
		public Match NextMatch() => default; // 0x00000001837AE3F0-0x00000001837AE440
		internal virtual ReadOnlySpan<char> GroupToStringImpl(int groupnum) => default; // 0x0000000189A34634-0x0000000189A34724
		internal ReadOnlySpan<char> LastGroupToStringImpl() => default; // 0x0000000189A3479C-0x0000000189A347D8
		internal virtual void AddMatch(int cap, int start, int len) {} // 0x00000001826B2000-0x00000001826B2180
		internal virtual void BalanceMatch(int cap) {} // 0x0000000189A34520-0x0000000189A34634
		internal virtual void RemoveMatch(int cap) {} // 0x00000001838A3620-0x00000001838A3650
		internal virtual bool IsMatched(int cap) => default; // 0x0000000189A34724-0x0000000189A3479C
		internal virtual int MatchIndex(int cap) => default; // 0x0000000189A347D8-0x0000000189A34860
		internal virtual int MatchLength(int cap) => default; // 0x0000000189A34860-0x0000000189A348E4
		internal virtual void Tidy(int textpos) {} // 0x00000001825FEB00-0x00000001825FEB80
	}

	internal class MatchSparse : System.Text.RegularExpressions.Match // TypeDefIndex: 45537
	{
		// Fields
		internal readonly Hashtable _caps; // 0x78
	
		// Properties
		public override GroupCollection Groups { get => default; } // 0x0000000189A34498-0x0000000189A34520 
	
		// Constructors
		public MatchSparse() {} // Dummy constructor
		internal MatchSparse(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos) {} // 0x0000000189A343F8-0x0000000189A34498
	}

	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<System.Text.RegularExpressions.Match>))]
	public class MatchCollection : IList<System.Text.RegularExpressions.Match>, IReadOnlyList<System.Text.RegularExpressions.Match>, IList // TypeDefIndex: 45539
	{
		// Fields
		private readonly Regex _regex; // 0x10
		private readonly List<System.Text.RegularExpressions.Match> _matches; // 0x18
		private bool _done; // 0x20
		private readonly string _input; // 0x28
		private readonly int _beginning; // 0x30
		private readonly int _length; // 0x34
		private int _startat; // 0x38
		private int _prevlen; // 0x3C
	
		// Properties
		public bool IsReadOnly { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public int Count { get => default; } // 0x0000000189A342EC-0x0000000189A34334 
		public virtual System.Text.RegularExpressions.Match this[int i] { get => default; } // 0x0000000189A34334-0x0000000189A343F8 
		public bool IsSynchronized { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public object SyncRoot { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		System.Text.RegularExpressions.Match IList<System.Text.RegularExpressions.Match>.this[int index] { get => default; set {} } // 0x0000000189A33F34-0x0000000189A33F3C 0x0000000189A33F3C-0x0000000189A33F98
		bool IList.IsFixedSize { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		object IList.this[int index] { get => default; set {} } // 0x0000000189A33F34-0x0000000189A33F3C 0x0000000189A34260-0x0000000189A342BC
	
		// Nested types
		[Serializable]
		private sealed class Enumerator : IEnumerator<System.Text.RegularExpressions.Match> // TypeDefIndex: 45538
		{
			// Fields
			private readonly MatchCollection _collection; // 0x10
			private int _index; // 0x18
	
			// Properties
			public System.Text.RegularExpressions.Match Current { get => default; } // 0x0000000189A32D1C-0x0000000189A32D98 
			object IEnumerator.Current { get => default; } // 0x0000000189A32C78-0x0000000189A32C80 
	
			// Constructors
			public Enumerator() {} // Dummy constructor
			internal Enumerator(MatchCollection collection) {} // 0x00000001830840F0-0x0000000183084120
	
			// Methods
			public bool MoveNext() => default; // 0x000000018345A1F0-0x000000018345A240
			void IEnumerator.Reset() {} // 0x0000000183D50330-0x0000000183D50340
			void IDisposable.Dispose() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		internal MatchCollection(Regex regex, string input, int beginning, int length, int startat) {} // 0x0000000183084120-0x0000000183084210
		internal MatchCollection() {} // 0x0000000189A342BC-0x0000000189A342EC
	
		// Methods
		public IEnumerator GetEnumerator() => default; // 0x0000000183083FE0-0x0000000183084040
		IEnumerator<System.Text.RegularExpressions.Match> IEnumerable<Match>.GetEnumerator() => default; // 0x0000000189A33DBC-0x0000000189A33E1C
		private System.Text.RegularExpressions.Match GetMatch(int i) => default; // 0x000000018345A240-0x000000018345A310
		private void EnsureInitialized() {} // 0x0000000189A33C34-0x0000000189A33C48
		public void CopyTo(Array array, int arrayIndex) {} // 0x0000000189A33BE8-0x0000000189A33C34
		public void CopyTo(System.Text.RegularExpressions.Match[] array, int arrayIndex) {} // 0x0000000189A33B78-0x0000000189A33BE8
		int IList<Match>.IndexOf(System.Text.RegularExpressions.Match item) => default; // 0x0000000189A33E1C-0x0000000189A33E7C
		void IList<Match>.Insert(int index, System.Text.RegularExpressions.Match item) {} // 0x0000000189A33E7C-0x0000000189A33ED8
		void IList<Match>.RemoveAt(int index) {} // 0x0000000189A33ED8-0x0000000189A33F34
		void ICollection<Match>.Add(System.Text.RegularExpressions.Match item) {} // 0x0000000189A33C48-0x0000000189A33CA4
		void ICollection<Match>.Clear() {} // 0x0000000189A33CA4-0x0000000189A33D00
		bool ICollection<Match>.Contains(System.Text.RegularExpressions.Match item) => default; // 0x0000000189A33D00-0x0000000189A33D60
		bool ICollection<Match>.Remove(System.Text.RegularExpressions.Match item) => default; // 0x0000000189A33D60-0x0000000189A33DBC
		int IList.Add(object value) => default; // 0x0000000189A33F98-0x0000000189A33FF4
		void IList.Clear() {} // 0x0000000189A33FF4-0x0000000189A34050
		bool IList.Contains(object value) => default; // 0x0000000189A34050-0x0000000189A340CC
		int IList.IndexOf(object value) => default; // 0x0000000189A340CC-0x0000000189A3414C
		void IList.Insert(int index, object value) {} // 0x0000000189A3414C-0x0000000189A341A8
		void IList.Remove(object value) {} // 0x0000000189A34204-0x0000000189A34260
		void IList.RemoveAt(int index) {} // 0x0000000189A341A8-0x0000000189A34204
	}

	internal sealed class ExclusiveReference // TypeDefIndex: 45540
	{
		// Fields
		private RegexRunner _ref; // 0x10
		private RegexRunner _obj; // 0x18
		private int _locked; // 0x20
	
		// Constructors
		public ExclusiveReference() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public RegexRunner Get() => default; // 0x00000001825FE0D0-0x00000001825FE120
		public void Release(RegexRunner obj) {} // 0x000000018318DDD0-0x000000018318DE50
	}

	public class Regex : ISerializable // TypeDefIndex: 45543
	{
		// Fields
		private const int CacheDictionarySwitchLimit = 10; // Metadata: 0x01FBA07E
		private static int s_cacheSize; // 0x00
		private static readonly Dictionary<CachedCodeEntryKey, CachedCodeEntry> s_cache; // 0x08
		private static int s_cacheCount; // 0x10
		private static CachedCodeEntry s_cacheFirst; // 0x18
		private static CachedCodeEntry s_cacheLast; // 0x20
		private static readonly TimeSpan s_maximumMatchTimeout; // 0x28
		private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT"; // Metadata: 0x01FBA07F
		internal static readonly TimeSpan s_defaultMatchTimeout; // 0x30
		public static readonly TimeSpan InfiniteMatchTimeout; // 0x38
		protected internal TimeSpan internalMatchTimeout; // 0x10
		internal const int MaxOptionShift = 10; // Metadata: 0x01FBA09B
		protected internal string pattern; // 0x18
		protected internal RegexOptions roptions; // 0x20
		protected internal RegexRunnerFactory factory; // 0x28
		protected internal Hashtable caps; // 0x30
		protected internal Hashtable capnames; // 0x38
		protected internal string[] capslist; // 0x40
		protected internal int capsize; // 0x48
		internal ExclusiveReference _runnerref; // 0x50
		internal WeakReference<RegexReplacement> _replref; // 0x58
		internal RegexCode _code; // 0x60
		internal bool _refsInitialized; // 0x68
	
		// Properties
		public RegexOptions Options { get => default; } // 0x0000000181003B50-0x0000000181003B60 
		public bool RightToLeft { get => default; } // 0x0000000184270A98-0x0000000184270AA0 
	
		// Nested types
		[IsReadOnly]
		internal struct CachedCodeEntryKey : IEquatable<CachedCodeEntryKey> // TypeDefIndex: 45541
		{
			// Fields
			private readonly RegexOptions _options; // 0x00
			private readonly string _cultureKey; // 0x08
			private readonly string _pattern; // 0x10
	
			// Constructors
			public CachedCodeEntryKey(RegexOptions options, string cultureKey, string pattern) {
				_options = default;
				_cultureKey = default;
				_pattern = default;
			} // 0x00000001825FDC80-0x00000001825FDCB0
	
			// Methods
			public override bool Equals(object obj) => default; // 0x0000000189A313A4-0x0000000189A3141C
			public bool Equals(CachedCodeEntryKey other) => default; // 0x0000000183165020-0x00000001831650E0
			public static bool operator ==(CachedCodeEntryKey left, CachedCodeEntryKey right) => default; // 0x0000000184270AA0-0x0000000184270ACC
			public override int GetHashCode() => default; // 0x00000001832C7570-0x00000001832C75D0
		}
	
		internal sealed class CachedCodeEntry // TypeDefIndex: 45542
		{
			// Fields
			public CachedCodeEntry Next; // 0x10
			public CachedCodeEntry Previous; // 0x18
			public readonly CachedCodeEntryKey Key; // 0x20
			public RegexCode Code; // 0x38
			public readonly Hashtable Caps; // 0x40
			public readonly Hashtable Capnames; // 0x48
			public readonly string[] Capslist; // 0x50
			public readonly int Capsize; // 0x58
			public readonly ExclusiveReference Runnerref; // 0x60
			public readonly WeakReference<RegexReplacement> ReplRef; // 0x68
	
			// Constructors
			public CachedCodeEntry() {} // Dummy constructor
			public CachedCodeEntry(CachedCodeEntryKey key, Hashtable capnames, string[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, WeakReference<RegexReplacement> replref) {} // 0x00000001831DCBF0-0x00000001831DCC90
		}
	
		// Constructors
		public Regex() {} // Dummy constructor
		static Regex() {} // 0x0000000182C98A60-0x0000000182C98BE0
		public Regex(string pattern) {} // 0x0000000183496B10-0x0000000183496BA0
		public Regex(string pattern, RegexOptions options) {} // 0x0000000182F1BBB0-0x0000000182F1BCF0
		private Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache) {} // 0x00000001825FD790-0x00000001825FDC80
	
		// Methods
		private CachedCodeEntry GetCachedCode(CachedCodeEntryKey key, bool isToAdd) => default; // 0x0000000189A35028-0x0000000189A35128
		private CachedCodeEntry GetCachedCodeEntryInternal(CachedCodeEntryKey key, bool isToAdd) => default; // 0x00000001831DB9A0-0x00000001831DC720
		private void FillCacheDictionary() {} // 0x00000001831DCC90-0x00000001831DCDA0
		private static bool TryGetCacheValue(CachedCodeEntryKey key, out CachedCodeEntry entry) {
			entry = default;
			return default;
		} // 0x0000000189A35430-0x0000000189A35500
		private static bool TryGetCacheValueSmall(CachedCodeEntryKey key, out CachedCodeEntry entry) {
			entry = default;
			return default;
		} // 0x00000001831DCAE0-0x00000001831DCBF0
		private static CachedCodeEntry LookupCachedAndPromote(CachedCodeEntryKey key) => default; // 0x00000001831DC720-0x00000001831DCAE0
		public static bool IsMatch(string input, string pattern) => default; // 0x000000018388C170-0x000000018388C1F0
		public static bool IsMatch(string input, string pattern, RegexOptions options) => default; // 0x00000001825FD650-0x00000001825FD6E0
		public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) => default; // 0x00000001825FD6E0-0x00000001825FD790
		public bool IsMatch(string input) => default; // 0x00000001825FDCB0-0x00000001825FDD00
		public bool IsMatch(string input, int startat) => default; // 0x00000001825FDD10-0x00000001825FDD60
		public static System.Text.RegularExpressions.Match Match(string input, string pattern) => default; // 0x00000001825FC6A0-0x00000001825FC720
		public static System.Text.RegularExpressions.Match Match(string input, string pattern, RegexOptions options) => default; // 0x0000000182CDCA10-0x0000000182CDCAA0
		public static System.Text.RegularExpressions.Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) => default; // 0x00000001825FC720-0x00000001825FC7D0
		public System.Text.RegularExpressions.Match Match(string input) => default; // 0x00000001825FC7D0-0x00000001825FC820
		public System.Text.RegularExpressions.Match Match(string input, int startat) => default; // 0x00000001825FC820-0x00000001825FC860
		public static MatchCollection Matches(string input, string pattern) => default; // 0x0000000189A35128-0x0000000189A35194
		public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) => default; // 0x0000000189A35194-0x0000000189A35234
		public MatchCollection Matches(string input) => default; // 0x0000000183083FB0-0x0000000183083FE0
		public MatchCollection Matches(string input, int startat) => default; // 0x0000000183084040-0x00000001830840F0
		public static string Replace(string input, string pattern, string replacement) => default; // 0x00000001826D2F00-0x00000001826D2FA0
		public static string Replace(string input, string pattern, string replacement, RegexOptions options) => default; // 0x0000000189A35358-0x0000000189A353E4
		public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) => default; // 0x00000001826D2FA0-0x00000001826D3050
		public string Replace(string input, string replacement) => default; // 0x00000001826D3050-0x00000001826D3090
		public string Replace(string input, string replacement, int count, int startat) => default; // 0x00000001826D3090-0x00000001826D3130
		public static string Replace(string input, string pattern, MatchEvaluator evaluator) => default; // 0x0000000189A352D8-0x0000000189A35358
		public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) => default; // 0x0000000189A35234-0x0000000189A352D8
		public string Replace(string input, MatchEvaluator evaluator) => default; // 0x0000000183768280-0x00000001837682C0
		public string Replace(string input, MatchEvaluator evaluator, int count, int startat) => default; // 0x00000001837682C0-0x0000000183768350
		private static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat) => default; // 0x0000000183768350-0x0000000183768480
		protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) {} // 0x00000001825FE480-0x00000001825FE520
		private static TimeSpan InitDefaultMatchTimeout() => default; // 0x000000018267B0B0-0x000000018267B150
		void ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) {} // 0x0000000189A353E4-0x0000000189A35430
		public static string Escape(string str) => default; // 0x00000001834FB850-0x00000001834FB8B0
		public override string ToString() => default; // 0x0000000181041090-0x00000001810410A0
		public string GroupNameFromNumber(int i) => default; // 0x00000001825FEE20-0x00000001825FEF20
		public int GroupNumberFromName(string name) => default; // 0x0000000182CDC970-0x0000000182CDCA10
		protected void InitializeReferences() {} // 0x000000018352B730-0x000000018352B7F0
		internal System.Text.RegularExpressions.Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) => default; // 0x00000001825FDD60-0x00000001825FE0D0
		protected internal bool UseOptionR() => default; // 0x00000001825FDD00-0x00000001825FDD10
		internal bool UseOptionInvariant() => default; // 0x0000000183874860-0x0000000183874870
	}

	public delegate string MatchEvaluator(System.Text.RegularExpressions.Match match); // TypeDefIndex: 45544; 0x000000018102B410-0x000000018102B420

	internal sealed class RegexBoyerMoore // TypeDefIndex: 45545
	{
		// Fields
		public readonly int[] Positive; // 0x10
		public readonly int[] NegativeASCII; // 0x18
		public readonly int[][] NegativeUnicode; // 0x20
		public readonly string Pattern; // 0x28
		public readonly int LowASCII; // 0x30
		public readonly int HighASCII; // 0x34
		public readonly bool RightToLeft; // 0x38
		public readonly bool CaseInsensitive; // 0x39
		private readonly CultureInfo _culture; // 0x40
	
		// Constructors
		public RegexBoyerMoore() {} // Dummy constructor
		public RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) {} // 0x00000001830227D0-0x0000000183022C10
	
		// Methods
		private bool MatchPattern(string text, int index) => default; // 0x0000000182E0E5A0-0x0000000182E0E680
		public bool IsMatch(string text, int index, int beglimit, int endlimit) => default; // 0x0000000182E0E330-0x0000000182E0E380
		public int Scan(string text, int index, int beglimit, int endlimit) => default; // 0x0000000182E0E020-0x0000000182E0E330
	}

	internal sealed class RegexCharClass // TypeDefIndex: 45549
	{
		// Fields
		private static readonly string s_internalRegexIgnoreCase; // 0x00
		private static readonly string s_space; // 0x08
		private static readonly string s_notSpace; // 0x10
		private static readonly string s_word; // 0x18
		private static readonly string s_notWord; // 0x20
		public static readonly string SpaceClass; // 0x28
		public static readonly string NotSpaceClass; // 0x30
		public static readonly string WordClass; // 0x38
		public static readonly string NotWordClass; // 0x40
		public static readonly string DigitClass; // 0x48
		public static readonly string NotDigitClass; // 0x50
		private static readonly Dictionary<string, string> s_definedCategories; // 0x58
		private static readonly string[][] s_propTable; // 0x60
		private static readonly LowerCaseMapping[] s_lcTable; // 0x68
		private List<SingleRange> _rangelist; // 0x10
		private StringBuilder _categories; // 0x18
		private bool _canonical; // 0x20
		private bool _negate; // 0x21
		private RegexCharClass _subtractor; // 0x28
	
		// Properties
		public bool CanMerge { get => default; } // 0x00000001833B3AA0-0x00000001833B3AC0 
		public bool Negate { set {} } // 0x0000000183D4F080-0x0000000183D4F090
	
		// Nested types
		[IsReadOnly]
		private struct LowerCaseMapping // TypeDefIndex: 45546
		{
			// Fields
			public readonly char ChMin; // 0x00
			public readonly char ChMax; // 0x02
			public readonly int LcOp; // 0x04
			public readonly int Data; // 0x08
	
			// Constructors
			internal LowerCaseMapping(char chMin, char chMax, int lcOp, int data) {
				ChMin = default;
				ChMax = default;
				LcOp = default;
				Data = default;
			} // 0x0000000183D75DF0-0x0000000183D75E10
		}
	
		private sealed class SingleRangeComparer : IComparer<SingleRange> // TypeDefIndex: 45547
		{
			// Fields
			public static readonly SingleRangeComparer Instance; // 0x00
	
			// Constructors
			private SingleRangeComparer() {} // 0x000000018350B670-0x000000018350B680
			static SingleRangeComparer() {} // 0x0000000183D1AD50-0x0000000183D1ADB0
	
			// Methods
			public int Compare(SingleRange x, SingleRange y) => default; // 0x00000001837923B0-0x0000000183792410
		}
	
		[IsReadOnly]
		private struct SingleRange // TypeDefIndex: 45548
		{
			// Fields
			public readonly char First; // 0x00
			public readonly char Last; // 0x02
	
			// Constructors
			internal SingleRange(char first, char last) {
				First = default;
				Last = default;
			} // 0x0000000183D6EFA0-0x0000000183D6EFB0
		}
	
		// Constructors
		public RegexCharClass() {} // 0x00000001825EE300-0x00000001825EE3F0
		private RegexCharClass(bool negate, List<SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) {} // 0x00000001831CA210-0x00000001831CA260
		static RegexCharClass() {} // 0x00000001833FF5A0-0x0000000183404BD0
	
		// Methods
		public void AddChar(char c) {} // 0x0000000189A34964-0x0000000189A34970
		public void AddCharClass(RegexCharClass cc) {} // 0x00000001833B3AC0-0x00000001833B3BB0
		private void AddSet(string set) {} // 0x0000000189A34970-0x0000000189A34AB8
		public void AddSubtraction(RegexCharClass sub) {} // 0x0000000182C92F10-0x0000000182C92F20
		public void AddRange(char first, char last) {} // 0x00000001825EDFE0-0x00000001825EE0B0
		public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) {} // 0x0000000183A155A0-0x0000000183A15700
		private void AddCategory(string category) {} // 0x00000001838A9180-0x00000001838A91A0
		public void AddLowercase(CultureInfo culture) {} // 0x00000001831BFC60-0x00000001831BFD90
		private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) {} // 0x00000001831BFD90-0x00000001831C0030
		public void AddWord(bool ecma, bool negate) {} // 0x00000001838A8FD0-0x00000001838A9080
		public void AddSpace(bool ecma, bool negate) {} // 0x00000001838A9080-0x00000001838A9180
		public void AddDigit(bool ecma, bool negate, string pattern) {} // 0x0000000183A15500-0x0000000183A155A0
		public static char SingletonChar(string set) => default; // 0x0000000182E0E6F0-0x0000000182E0E710
		public static bool IsMergeable(string charClass) => default; // 0x0000000182E0DA60-0x0000000182E0DAE0
		public static bool IsEmpty(string charClass) => default; // 0x0000000182E0DCB0-0x0000000182E0DD30
		public static bool IsSingleton(string set) => default; // 0x0000000182E0E380-0x0000000182E0E490
		public static bool IsSingletonInverse(string set) => default; // 0x0000000182E0E490-0x0000000182E0E5A0
		private static bool IsSubtraction(string charClass) => default; // 0x0000000182E0E680-0x0000000182E0E6F0
		private static bool IsNegated(string set) => default; // 0x0000000182E0DAE0-0x0000000182E0DB10
		public static bool IsECMAWordChar(char ch) => default; // 0x0000000189A34AB8-0x0000000189A34B0C
		public static bool IsWordChar(char ch) => default; // 0x000000018332CEC0-0x000000018332CF50
		public static bool CharInClass(char ch, string set) => default; // 0x00000001826B0B40-0x00000001826B0BA0
		private static bool CharInClassRecursive(char ch, string set, int start) => default; // 0x00000001826B0BA0-0x00000001826B0ED0
		private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) => default; // 0x00000001826B0ED0-0x00000001826B1150
		private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) => default; // 0x00000001826B1170-0x00000001826B12F0
		private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) => default; // 0x0000000183246B50-0x0000000183246BF0
		private static string NegateCategory(string category) => default; // 0x0000000189A34B0C-0x0000000189A34B84
		public static RegexCharClass Parse(string charClass) => default; // 0x00000001831C9FA0-0x00000001831C9FF0
		private static RegexCharClass ParseRecursive(string charClass, int start) => default; // 0x00000001831C9FF0-0x00000001831CA210
		private int RangeCount() => default; // 0x00000001833B3BB0-0x00000001833B3BF0
		public string ToStringClass() => default; // 0x00000001825EE0B0-0x00000001825EE260
		private SingleRange GetRangeAt(int i) => default; // 0x00000001833B3BF0-0x00000001833B3C50
		private void Canonicalize() {} // 0x00000001825EDDA0-0x00000001825EDFE0
		private static string SetFromProperty(string capname, bool invert, string pattern) => default; // 0x0000000189A34B84-0x0000000189A34DC4
	}

	internal sealed class RegexCode // TypeDefIndex: 45550
	{
		// Fields
		public const int Onerep = 0; // Metadata: 0x01FBA09C
		public const int Notonerep = 1; // Metadata: 0x01FBA09D
		public const int Setrep = 2; // Metadata: 0x01FBA09E
		public const int Oneloop = 3; // Metadata: 0x01FBA09F
		public const int Notoneloop = 4; // Metadata: 0x01FBA0A0
		public const int Setloop = 5; // Metadata: 0x01FBA0A1
		public const int Onelazy = 6; // Metadata: 0x01FBA0A2
		public const int Notonelazy = 7; // Metadata: 0x01FBA0A3
		public const int Setlazy = 8; // Metadata: 0x01FBA0A4
		public const int One = 9; // Metadata: 0x01FBA0A5
		public const int Notone = 10; // Metadata: 0x01FBA0A6
		public const int Set = 11; // Metadata: 0x01FBA0A7
		public const int Multi = 12; // Metadata: 0x01FBA0A8
		public const int Ref = 13; // Metadata: 0x01FBA0A9
		public const int Bol = 14; // Metadata: 0x01FBA0AA
		public const int Eol = 15; // Metadata: 0x01FBA0AB
		public const int Boundary = 16; // Metadata: 0x01FBA0AC
		public const int Nonboundary = 17; // Metadata: 0x01FBA0AD
		public const int Beginning = 18; // Metadata: 0x01FBA0AE
		public const int Start = 19; // Metadata: 0x01FBA0AF
		public const int EndZ = 20; // Metadata: 0x01FBA0B0
		public const int End = 21; // Metadata: 0x01FBA0B1
		public const int Nothing = 22; // Metadata: 0x01FBA0B2
		public const int Lazybranch = 23; // Metadata: 0x01FBA0B3
		public const int Branchmark = 24; // Metadata: 0x01FBA0B4
		public const int Lazybranchmark = 25; // Metadata: 0x01FBA0B5
		public const int Nullcount = 26; // Metadata: 0x01FBA0B6
		public const int Setcount = 27; // Metadata: 0x01FBA0B7
		public const int Branchcount = 28; // Metadata: 0x01FBA0B8
		public const int Lazybranchcount = 29; // Metadata: 0x01FBA0B9
		public const int Nullmark = 30; // Metadata: 0x01FBA0BA
		public const int Setmark = 31; // Metadata: 0x01FBA0BB
		public const int Capturemark = 32; // Metadata: 0x01FBA0BC
		public const int Getmark = 33; // Metadata: 0x01FBA0BD
		public const int Setjump = 34; // Metadata: 0x01FBA0BE
		public const int Backjump = 35; // Metadata: 0x01FBA0BF
		public const int Forejump = 36; // Metadata: 0x01FBA0C0
		public const int Testref = 37; // Metadata: 0x01FBA0C1
		public const int Goto = 38; // Metadata: 0x01FBA0C2
		public const int Prune = 39; // Metadata: 0x01FBA0C3
		public const int Stop = 40; // Metadata: 0x01FBA0C4
		public const int ECMABoundary = 41; // Metadata: 0x01FBA0C5
		public const int NonECMABoundary = 42; // Metadata: 0x01FBA0C6
		public const int Mask = 63; // Metadata: 0x01FBA0C7
		public const int Rtl = 64; // Metadata: 0x01FBA0C8
		public const int Back = 128; // Metadata: 0x01FBA0CA
		public const int Back2 = 256; // Metadata: 0x01FBA0CC
		public const int Ci = 512; // Metadata: 0x01FBA0CE
		public readonly int[] Codes; // 0x10
		public readonly string[] Strings; // 0x18
		public readonly int TrackCount; // 0x20
		public readonly Hashtable Caps; // 0x28
		public readonly int CapSize; // 0x30
		public readonly RegexPrefix? FCPrefix; // 0x38
		public readonly RegexBoyerMoore BMPrefix; // 0x50
		public readonly int Anchors; // 0x58
		public readonly bool RightToLeft; // 0x5C
	
		// Constructors
		public RegexCode() {} // Dummy constructor
		public RegexCode(int[] codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, RegexPrefix? fcPrefix, int anchors, bool rightToLeft) {} // 0x00000001825F7520-0x00000001825F7620
	
		// Methods
		public static bool OpcodeBacktracks(int Op) => default; // 0x00000001825ED680-0x00000001825ED6E0
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal struct RegexFCD // TypeDefIndex: 45551
	{
		// Fields
		private readonly List<RegexFC> _fcStack; // 0x00
		private ValueListBuilder<int> _intStack; // 0x08
		private bool _skipAllChildren; // 0x28
		private bool _skipchild; // 0x29
		private bool _failed; // 0x2A
	
		// Constructors
		private RegexFCD(Span<int> intStack) {
			_fcStack = default;
			_intStack = default;
			_skipAllChildren = default;
			_skipchild = default;
			_failed = default;
		} // 0x00000001831BFA40-0x00000001831BFB00
	
		// Methods
		public static RegexPrefix? FirstChars(RegexTree t) => default; // 0x00000001831BF770-0x00000001831BF9B0
		public static RegexPrefix Prefix(RegexTree tree) => default; // 0x00000001825EB8B0-0x00000001825EBA90
		public static int Anchors(RegexTree tree) => default; // 0x00000001825EDB40-0x00000001825EDC80
		private static int AnchorFromType(int type) => default; // 0x0000000183924B10-0x0000000183924B30
		private void PushInt(int i) {} // 0x00000001825EBEF0-0x00000001825EBF40
		private bool IntIsEmpty() => default; // 0x00000001825EC570-0x00000001825EC5B0
		private int PopInt() => default; // 0x00000001825EBF40-0x00000001825EBF80
		private void PushFC(RegexFC fc) {} // 0x00000001825ED8D0-0x00000001825ED930
		private bool FCIsEmpty() => default; // 0x0000000183678D20-0x0000000183678D70
		private RegexFC PopFC() => default; // 0x00000001825ED850-0x00000001825ED8D0
		private RegexFC TopFC() => default; // 0x00000001825ED7F0-0x00000001825ED850
		public void Dispose() {} // 0x00000001831BF9B0-0x00000001831BF9F0
		private RegexFC RegexFCFromRegexTree(RegexTree tree) => default; // 0x00000001825EBF80-0x00000001825EC0E0
		private void SkipChild() {} // 0x0000000183D5CAD0-0x0000000183D5CAE0
		private void CalculateFC(int NodeType, RegexNode node, int CurIndex) {} // 0x00000001825EC0E0-0x00000001825EC570
	}

	internal sealed class RegexFC // TypeDefIndex: 45552
	{
		// Fields
		private RegexCharClass _cc; // 0x10
		public bool _nullable; // 0x18
	
		// Properties
		public bool CaseInsensitive { get; private set; } // 0x0000000183D4EF80-0x0000000183D4EF90 0x0000000183D4EFB0-0x0000000183D4EFC0
	
		// Constructors
		public RegexFC() {} // Dummy constructor
		public RegexFC(bool nullable) {} // 0x00000001836AD690-0x00000001836AD710
		public RegexFC(char ch, bool not, bool nullable, bool caseInsensitive) {} // 0x00000001825EDCA0-0x00000001825EDDA0
		public RegexFC(string charClass, bool nullable, bool caseInsensitive) {} // 0x00000001831C9F10-0x00000001831C9FA0
	
		// Methods
		public bool AddFC(RegexFC fc, bool concatenate) => default; // 0x00000001833B3A10-0x00000001833B3AA0
		public string GetFirstChars(CultureInfo culture) => default; // 0x00000001831BFC20-0x00000001831BFC60
	}

	internal sealed class RegexInterpreter : RegexRunner // TypeDefIndex: 45553
	{
		// Fields
		private readonly RegexCode _code; // 0x80
		private readonly CultureInfo _culture; // 0x88
		private int _operator; // 0x90
		private int _codepos; // 0x94
		private bool _rightToLeft; // 0x98
		private bool _caseInsensitive; // 0x99
	
		// Constructors
		public RegexInterpreter() {} // Dummy constructor
		public RegexInterpreter(RegexCode code, CultureInfo culture) {} // 0x00000001836E54F0-0x00000001836E5530
	
		// Methods
		protected override void InitTrackCount() {} // 0x0000000183824120-0x0000000183824150
		private void Advance(int i) {} // 0x00000001826B09F0-0x00000001826B0A70
		private void Goto(int newpos) {} // 0x00000001826AF830-0x00000001826AF8D0
		private void Textto(int newpos) {} // 0x0000000183D4EBA0-0x0000000183D4EBB0
		private void Trackto(int newpos) {} // 0x0000000183B5CCD0-0x0000000183B5CD00
		private int Textstart() => default; // 0x00000001820D1AC0-0x00000001820D1AD0
		private int Textpos() => default; // 0x0000000183D4EB90-0x0000000183D4EBA0
		private int Trackpos() => default; // 0x0000000183C94B50-0x0000000183C94B70
		private void TrackPush() {} // 0x00000001826B1600-0x00000001826B1640
		private void TrackPush(int I1) {} // 0x00000001826B1590-0x00000001826B1600
		private void TrackPush(int I1, int I2) {} // 0x00000001826AF910-0x00000001826AF9A0
		private void TrackPush(int I1, int I2, int I3) {} // 0x0000000189A34F78-0x0000000189A35028
		private void TrackPush2(int I1) {} // 0x00000001838E2A10-0x00000001838E2A80
		private void TrackPush2(int I1, int I2) {} // 0x000000018374BEA0-0x000000018374BF30
		private void Backtrack() {} // 0x00000001826AD2D0-0x00000001826AD5F0
		private void SetOperator(int op) {} // 0x00000001826B0A70-0x00000001826B0AA0
		private void TrackPop() {} // 0x0000000183D75E50-0x0000000183D75E60
		private void TrackPop(int framesize) {} // 0x0000000183D75E60-0x0000000183D75E70
		private int TrackPeek() => default; // 0x000000018362B7F0-0x000000018362B820
		private int TrackPeek(int i) => default; // 0x0000000183707680-0x00000001837076C0
		private void StackPush(int I1) {} // 0x00000001826B1640-0x00000001826B1680
		private void StackPush(int I1, int I2) {} // 0x0000000183696C90-0x0000000183696CF0
		private void StackPop() {} // 0x0000000183D75E30-0x0000000183D75E40
		private void StackPop(int framesize) {} // 0x0000000183D75E40-0x0000000183D75E50
		private int StackPeek() => default; // 0x00000001826B1560-0x00000001826B1590
		private int StackPeek(int i) => default; // 0x00000001837AEF30-0x00000001837AEF70
		private int Operator() => default; // 0x0000000183D4FB60-0x0000000183D4FB70
		private int Operand(int i) => default; // 0x00000001826B0980-0x00000001826B09D0
		private int Leftchars() => default; // 0x0000000183D75E10-0x0000000183D75E20
		private int Rightchars() => default; // 0x0000000183D75E20-0x0000000183D75E30
		private int Bump() => default; // 0x00000001826AF8F0-0x00000001826AF910
		private int Forwardchars() => default; // 0x00000001826B1150-0x00000001826B1170
		private char Forwardcharnext() => default; // 0x00000001826B0AA0-0x00000001826B0B40
		private bool Stringmatch(string str) => default; // 0x0000000183052270-0x00000001830523B0
		private bool Refmatch(int index, int len) => default; // 0x0000000189A34DE4-0x0000000189A34F78
		private void Backwardnext() {} // 0x00000001826AF8D0-0x00000001826AF8F0
		private char CharAt(int j) => default; // 0x0000000189A34DC4-0x0000000189A34DE4
		protected override bool FindFirstChar() => default; // 0x0000000182E0DD30-0x0000000182E0E020
		protected override void Go() {} // 0x00000001826AFAF0-0x00000001826B0980
	}

	[Serializable]
	public class RegexMatchTimeoutException : TimeoutException, ISerializable // TypeDefIndex: 45554
	{
		// Properties
		public string Input { get; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
		public string Pattern { get; } // 0x00000001811AC510-0x00000001811AC520 
		public TimeSpan MatchTimeout { get; } // 0x0000000183D4EA80-0x0000000183D4EA90 
	
		// Constructors
		public RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout) {} // 0x0000000189A3CA84-0x0000000189A3CB88
		public RegexMatchTimeoutException() {} // 0x0000000189A3CCE4-0x0000000189A3CD80
		protected RegexMatchTimeoutException(SerializationInfo info, StreamingContext context) {} // 0x0000000189A3CB88-0x0000000189A3CCE4
	
		// Methods
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000189A3C99C-0x0000000189A3CA84
	}

	internal sealed class RegexNode // TypeDefIndex: 45555
	{
		// Fields
		public int NType; // 0x10
		public List<RegexNode> Children; // 0x18
		public string Str; // 0x20
		public char Ch; // 0x28
		public int M; // 0x2C
		public int N; // 0x30
		public readonly RegexOptions Options; // 0x34
		public RegexNode Next; // 0x38
	
		// Constructors
		public RegexNode() {} // Dummy constructor
		public RegexNode(int type, RegexOptions options) {} // 0x0000000183D75EC0-0x0000000183D75ED0
		public RegexNode(int type, RegexOptions options, char ch) {} // 0x0000000183D75ED0-0x0000000183D75EE0
		public RegexNode(int type, RegexOptions options, string str) {} // 0x00000001825EDC80-0x00000001825EDCA0
		public RegexNode(int type, RegexOptions options, int m) {} // 0x0000000183D75E90-0x0000000183D75EA0
		public RegexNode(int type, RegexOptions options, int m, int n) {} // 0x0000000183D75EA0-0x0000000183D75EC0
	
		// Methods
		public bool UseOptionR() => default; // 0x00000001825ED6E0-0x00000001825ED6F0
		public RegexNode ReverseLeft() => default; // 0x00000001825EBA90-0x00000001825EBAE0
		private void MakeRep(int type, int min, int max) {} // 0x0000000183D75E80-0x0000000183D75E90
		private RegexNode Reduce() => default; // 0x00000001825EBC50-0x00000001825EBCF0
		private RegexNode StripEnation(int emptyType) => default; // 0x00000001825EC5B0-0x00000001825EC620
		private RegexNode ReduceGroup() => default; // 0x00000001839C81A0-0x00000001839C81D0
		private RegexNode ReduceRep() => default; // 0x0000000183743C90-0x0000000183743D60
		private RegexNode ReduceSet() => default; // 0x0000000182E0DB10-0x0000000182E0DCB0
		private RegexNode ReduceAlternation() => default; // 0x00000001825EBCF0-0x00000001825EBEF0
		private RegexNode ReduceConcatenation() => default; // 0x00000001825EC6D0-0x00000001825EC9D0
		public RegexNode MakeQuantifier(bool lazy, int min, int max) => default; // 0x00000001834CF630-0x00000001834CF710
		public void AddChild(RegexNode newChild) {} // 0x00000001825EBB70-0x00000001825EBC50
		public RegexNode Child(int i) => default; // 0x00000001825ED4A0-0x00000001825ED500
		public int ChildCount() => default; // 0x00000001825EC620-0x00000001825EC670
		public int Type() => default; // 0x0000000183D4E340-0x0000000183D4E350
	}

	[Flags]
	public enum RegexOptions // TypeDefIndex: 45556
	{
		None = 0,
		IgnoreCase = 1,
		Multiline = 2,
		ExplicitCapture = 4,
		Compiled = 8,
		Singleline = 16,
		IgnorePatternWhitespace = 32,
		RightToLeft = 64,
		ECMAScript = 256,
		CultureInvariant = 512
	}

	internal sealed class RegexParser // TypeDefIndex: 45557
	{
		// Fields
		private RegexNode _stack; // 0x10
		private RegexNode _group; // 0x18
		private RegexNode _alternation; // 0x20
		private RegexNode _concatenation; // 0x28
		private RegexNode _unit; // 0x30
		private string _pattern; // 0x38
		private int _currentPos; // 0x40
		private CultureInfo _culture; // 0x48
		private int _autocap; // 0x50
		private int _capcount; // 0x54
		private int _captop; // 0x58
		private int _capsize; // 0x5C
		private Hashtable _caps; // 0x60
		private Hashtable _capnames; // 0x68
		private int[] _capnumlist; // 0x70
		private List<string> _capnamelist; // 0x78
		private RegexOptions _options; // 0x80
		private List<RegexOptions> _optionsStack; // 0x88
		private bool _ignoreNextParen; // 0x90
		private static readonly byte[] s_category; // 0x00
	
		// Constructors
		public RegexParser() {} // Dummy constructor
		private RegexParser(CultureInfo culture) {} // 0x0000000182671A80-0x0000000182671B60
		static RegexParser() {} // 0x0000000183CE33A0-0x0000000183CE3430
	
		// Methods
		public static RegexTree Parse(string re, RegexOptions op) => default; // 0x0000000182671750-0x0000000182671920
		public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) => default; // 0x000000018359DCE0-0x000000018359DE30
		public static string Escape(string input) => default; // 0x00000001834FB910-0x00000001834FBB20
		private void SetPattern(string Re) {} // 0x0000000182671920-0x0000000182671980
		private void Reset(RegexOptions topopts) {} // 0x00000001826719F0-0x0000000182671A80
		private RegexNode ScanRegex() => default; // 0x00000001825EB040-0x00000001825EB6A0
		private RegexNode ScanReplacement() => default; // 0x000000018359DE30-0x000000018359DF20
		private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) => default; // 0x00000001825EA900-0x00000001825EACD0
		private RegexNode ScanGroupOpen() => default; // 0x000000018332C590-0x000000018332C8B0
		private void ScanBlank() {} // 0x00000001825EACD0-0x00000001825EAD60
		private RegexNode ScanBackslash(bool scanOnly) => default; // 0x000000018332C8C0-0x000000018332CBA0
		private RegexNode ScanBasicBackslash(bool scanOnly) => default; // 0x000000018332CBA0-0x000000018332CCE0
		private RegexNode ScanDollar() => default; // 0x0000000189A3D19C-0x0000000189A3D540
		private string ScanCapname() => default; // 0x000000018332CE10-0x000000018332CEC0
		private char ScanOctal() => default; // 0x0000000189A3D540-0x0000000189A3D5C0
		private int ScanDecimal() => default; // 0x000000018399EFE0-0x000000018399F050
		private char ScanHex(int c) => default; // 0x000000018332CFE0-0x000000018332D090
		private static int HexDigit(char ch) => default; // 0x000000018332D090-0x000000018332D0C0
		private char ScanControl() => default; // 0x0000000189A3D0F0-0x0000000189A3D19C
		private bool IsOnlyTopOption(RegexOptions option) => default; // 0x0000000189A3CD80-0x0000000189A3CD9C
		private void ScanOptions() {} // 0x0000000183821B70-0x0000000183821C20
		private char ScanCharEscape() => default; // 0x000000018332CCE0-0x000000018332CDF0
		private string ParseProperty() => default; // 0x0000000189A3CF04-0x0000000189A3D090
		private int TypeFromCode(char ch) => default; // 0x0000000189A3D5C0-0x0000000189A3D640
		private static RegexOptions OptionFromCode(char ch) => default; // 0x0000000183821C20-0x0000000183821C50
		private void CountCaptures() {} // 0x00000001825EAD60-0x00000001825EB040
		private void NoteCaptureSlot(int i, int pos) {} // 0x00000001825EA5F0-0x00000001825EA6F0
		private void NoteCaptureName(string name, int pos) {} // 0x00000001837F66E0-0x00000001837F6860
		private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) {} // 0x000000018359DF20-0x000000018359DF50
		private void AssignNameSlots() {} // 0x0000000183544480-0x0000000183544840
		private int CaptureSlotFromName(string capname) => default; // 0x000000018332CF50-0x000000018332CFC0
		private bool IsCaptureSlot(int i) => default; // 0x0000000183544840-0x00000001835448B0
		private bool IsCaptureName(string capname) => default; // 0x000000018332CFC0-0x000000018332CFE0
		private bool UseOptionN() => default; // 0x000000018332C8B0-0x000000018332C8C0
		private bool UseOptionI() => default; // 0x00000001825EDB30-0x00000001825EDB40
		private bool UseOptionM() => default; // 0x000000018399D790-0x000000018399D7A0
		private bool UseOptionS() => default; // 0x0000000183C7BDF0-0x0000000183C7BE00
		private bool UseOptionX() => default; // 0x00000001825EB7C0-0x00000001825EB7D0
		private bool UseOptionE() => default; // 0x000000018332CDF0-0x000000018332CE10
		private static bool IsSpecial(char ch) => default; // 0x00000001825EB700-0x00000001825EB780
		private static bool IsStopperX(char ch) => default; // 0x0000000189A3CE0C-0x0000000189A3CE7C
		private static bool IsQuantifier(char ch) => default; // 0x00000001825EB810-0x00000001825EB8A0
		private bool IsTrueQuantifier() => default; // 0x00000001825EA6F0-0x00000001825EA830
		private static bool IsSpace(char ch) => default; // 0x0000000189A3CD9C-0x0000000189A3CE0C
		private static bool IsMetachar(char ch) => default; // 0x00000001834FBB20-0x00000001834FBBA0
		private void AddConcatenate(int pos, int cch, bool isReplacement) {} // 0x00000001825ED930-0x00000001825EDB30
		private void PushGroup() {} // 0x000000018354E790-0x000000018354E800
		private void PopGroup() {} // 0x000000018351C690-0x000000018351C720
		private bool EmptyStack() => default; // 0x00000001825EB8A0-0x00000001825EB8B0
		private void StartGroup(RegexNode openGroup) {} // 0x00000001825EA850-0x00000001825EA900
		private void AddAlternate() {} // 0x000000018364B340-0x000000018364B400
		private void AddConcatenate() {} // 0x000000018358C8D0-0x000000018358C910
		private void AddConcatenate(bool lazy, int min, int max) {} // 0x00000001834CF5D0-0x00000001834CF630
		private RegexNode Unit() => default; // 0x0000000181003830-0x0000000181003840
		private void AddUnitOne(char ch) {} // 0x0000000183CEF0B0-0x0000000183CEF140
		private void AddUnitNotone(char ch) {} // 0x000000018375CD40-0x000000018375CDF0
		private void AddUnitSet(string cc) {} // 0x000000018375D680-0x000000018375D710
		private void AddUnitNode(RegexNode node) {} // 0x0000000184270470-0x0000000184270480
		private void AddUnitType(int type) {} // 0x00000001836B4350-0x00000001836B43D0
		private void AddGroup() {} // 0x00000001825EBAE0-0x00000001825EBB70
		private void PushOptions() {} // 0x0000000183570F60-0x0000000183571170
		private void PopOptions() {} // 0x00000001834A8190-0x00000001834A8230
		private bool EmptyOptionsStack() => default; // 0x000000018368CEC0-0x000000018368CF10
		private void PopKeepOptions() {} // 0x0000000189A3D090-0x0000000189A3D0F0
		private ArgumentException MakeException(string message) => default; // 0x0000000189A3CE7C-0x0000000189A3CF04
		private int Textpos() => default; // 0x0000000183D4ED80-0x0000000183D4ED90
		private void Textto(int pos) {} // 0x0000000183D4EDB0-0x0000000183D4EDC0
		private char RightCharMoveRight() => default; // 0x00000001825EB780-0x00000001825EB7C0
		private void MoveRight() {} // 0x0000000183D75EF0-0x0000000183D75F00
		private void MoveRight(int i) {} // 0x0000000183D75F00-0x0000000183D75F10
		private void MoveLeft() {} // 0x0000000183D75EE0-0x0000000183D75EF0
		private char CharAt(int i) => default; // 0x00000001825EA830-0x00000001825EA850
		internal char RightChar() => default; // 0x00000001825EB6C0-0x00000001825EB700
		private char RightChar(int i) => default; // 0x00000001825EB7D0-0x00000001825EB810
		private int CharsRight() => default; // 0x00000001825EB6A0-0x00000001825EB6C0
	}

	[IsReadOnly]
	internal struct RegexPrefix // TypeDefIndex: 45558
	{
		// Properties
		internal bool CaseInsensitive { get; } // 0x0000000183D51020-0x0000000183D51030 
		internal static RegexPrefix Empty { get; } // 0x0000000189A3D640-0x0000000189A3D69C 
		internal string Prefix { get; } // 0x0000000183D50DE0-0x0000000183D50DF0 
	
		// Constructors
		internal RegexPrefix(string prefix, bool ci) : this() {} // 0x0000000184275DA4-0x0000000184275DC4
		static RegexPrefix() {} // 0x00000001831BF520-0x00000001831BF5B0
	}

	internal sealed class RegexReplacement // TypeDefIndex: 45559
	{
		// Fields
		private const int Specials = 4; // Metadata: 0x01FBA0DD
		public const int LeftPortion = -1; // Metadata: 0x01FBA0DE
		public const int RightPortion = -2; // Metadata: 0x01FBA0DF
		public const int LastGroup = -3; // Metadata: 0x01FBA0E0
		public const int WholeString = -4; // Metadata: 0x01FBA0E1
		private readonly List<string> _strings; // 0x10
		private readonly List<int> _rules; // 0x18
	
		// Properties
		public string Pattern { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public RegexReplacement() {} // Dummy constructor
		public RegexReplacement(string rep, RegexNode concat, Hashtable _caps) {} // 0x000000018359DF50-0x000000018359E160
	
		// Methods
		public static RegexReplacement GetOrCreate(WeakReference<RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions) => default; // 0x00000001826D3130-0x00000001826D3250
		private void ReplacementImpl(StringBuilder sb, System.Text.RegularExpressions.Match match) {} // 0x0000000183867060-0x0000000183867130
		private void ReplacementImplRTL(List<string> al, System.Text.RegularExpressions.Match match) {} // 0x0000000189A3D69C-0x0000000189A3D854
		public string Replace(Regex regex, string input, int count, int startat) => default; // 0x00000001826D3250-0x00000001826D3420
	}

	public abstract class RegexRunner // TypeDefIndex: 45560
	{
		// Fields
		protected internal int runtextbeg; // 0x10
		protected internal int runtextend; // 0x14
		protected internal int runtextstart; // 0x18
		protected internal string runtext; // 0x20
		protected internal int runtextpos; // 0x28
		protected internal int[] runtrack; // 0x30
		protected internal int runtrackpos; // 0x38
		protected internal int[] runstack; // 0x40
		protected internal int runstackpos; // 0x48
		protected internal int[] runcrawl; // 0x50
		protected internal int runcrawlpos; // 0x58
		protected internal int runtrackcount; // 0x5C
		protected internal System.Text.RegularExpressions.Match runmatch; // 0x60
		protected internal Regex runregex; // 0x68
		private int _timeout; // 0x70
		private bool _ignoreTimeout; // 0x74
		private int _timeoutOccursAt; // 0x78
		private const int TimeoutCheckFrequency = 1000; // Metadata: 0x01FBA0E2
		private int _timeoutChecksToSkip; // 0x7C
	
		// Constructors
		protected internal RegexRunner() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected internal System.Text.RegularExpressions.Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) => default; // 0x00000001825FE120-0x00000001825FE480
		private void StartTimeoutWatch() {} // 0x00000001825FE580-0x00000001825FE600
		protected void CheckTimeout() {} // 0x00000001826B09D0-0x00000001826B09F0
		private void DoCheckTimeout() {} // 0x0000000189A3D854-0x0000000189A3D938
		protected abstract void Go();
		protected abstract bool FindFirstChar();
		protected abstract void InitTrackCount();
		private void InitMatch() {} // 0x00000001825FE650-0x00000001825FE8A0
		private System.Text.RegularExpressions.Match TidyMatch(bool quick) => default; // 0x00000001825FE530-0x00000001825FE580
		protected void EnsureStorage() {} // 0x00000001826AD8A0-0x00000001826AD8D0
		protected bool IsBoundary(int index, int startpos, int endpos) => default; // 0x0000000189A3DB0C-0x0000000189A3DBE0
		protected bool IsECMABoundary(int index, int startpos, int endpos) => default; // 0x0000000189A3DBE0-0x0000000189A3DCB4
		protected void DoubleTrack() {} // 0x0000000189A3DA70-0x0000000189A3DB0C
		protected void DoubleStack() {} // 0x0000000189A3D9D4-0x0000000189A3DA70
		protected void DoubleCrawl() {} // 0x0000000189A3D938-0x0000000189A3D9D4
		protected void Crawl(int i) {} // 0x00000001826B16F0-0x00000001826B1750
		protected int Popcrawl() => default; // 0x00000001838A35E0-0x00000001838A3620
		protected int Crawlpos() => default; // 0x0000000183C94B30-0x0000000183C94B50
		protected void Capture(int capnum, int start, int end) {} // 0x00000001826B1680-0x00000001826B16F0
		protected void TransferCapture(int capnum, int uncapnum, int start, int end) {} // 0x0000000189A3DD14-0x0000000189A3DDF8
		protected void Uncapture() {} // 0x00000001838A35B0-0x00000001838A35E0
		protected bool IsMatched(int cap) => default; // 0x0000000189A3DCB4-0x0000000189A3DCD4
		protected int MatchIndex(int cap) => default; // 0x0000000189A3DCD4-0x0000000189A3DCF4
		protected int MatchLength(int cap) => default; // 0x0000000189A3DCF4-0x0000000189A3DD14
	}

	public abstract class RegexRunnerFactory // TypeDefIndex: 45561
	{
		// Constructors
		protected RegexRunnerFactory() {} // Dummy constructor
	
		// Methods
		protected internal abstract RegexRunner CreateInstance();
	}

	internal sealed class RegexTree // TypeDefIndex: 45562
	{
		// Fields
		public readonly RegexNode Root; // 0x10
		public readonly Hashtable Caps; // 0x18
		public readonly int[] CapNumList; // 0x20
		public readonly int CapTop; // 0x28
		public readonly Hashtable CapNames; // 0x30
		public readonly string[] CapsList; // 0x38
		public readonly RegexOptions Options; // 0x40
	
		// Constructors
		public RegexTree() {} // Dummy constructor
		internal RegexTree(RegexNode root, Hashtable caps, int[] capNumList, int capTop, Hashtable capNames, string[] capsList, RegexOptions options) {} // 0x0000000182671980-0x00000001826719F0
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal struct RegexWriter // TypeDefIndex: 45563
	{
		// Fields
		private ValueListBuilder<int> _emitted; // 0x00
		private ValueListBuilder<int> _intStack; // 0x20
		private readonly Dictionary<string, int> _stringHash; // 0x40
		private readonly List<string> _stringTable; // 0x48
		private Hashtable _caps; // 0x50
		private int _trackCount; // 0x58
	
		// Constructors
		private RegexWriter(Span<int> emittedSpan, Span<int> intStackSpan) {
			_emitted = default;
			_intStack = default;
			_stringHash = default;
			_stringTable = default;
			_caps = default;
			_trackCount = default;
		} // 0x00000001831BFB00-0x00000001831BFC20
	
		// Methods
		public static RegexCode Write(RegexTree tree) => default; // 0x00000001831BF5B0-0x00000001831BF770
		public void Dispose() {} // 0x00000001831BF9F0-0x00000001831BFA40
		public RegexCode RegexCodeFromRegexTree(RegexTree tree) => default; // 0x00000001825EC9D0-0x00000001825ECE70
		private void PatchJump(int offset, int jumpDest) {} // 0x00000001835A6790-0x00000001835A67F0
		private void Emit(int op) {} // 0x00000001825EC670-0x00000001825EC6D0
		private void Emit(int op, int opd1) {} // 0x00000001825ED500-0x00000001825ED580
		private void Emit(int op, int opd1, int opd2) {} // 0x00000001825ED580-0x00000001825ED620
		private int StringCode(string str) => default; // 0x00000001825ED6F0-0x00000001825ED7F0
		private int MapCapnum(int capnum) => default; // 0x00000001825ED620-0x00000001825ED680
		private void EmitFragment(int nodetype, RegexNode node, int curIndex) {} // 0x00000001825ECE70-0x00000001825ED4A0
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
