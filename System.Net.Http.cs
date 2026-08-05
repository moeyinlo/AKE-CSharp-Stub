/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Image 66: System.Net.Http.dll - Assembly: System.Net.Http, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a - Types 61945-62028
[assembly: AssemblyCompany("Mono development team")]
[assembly: AssemblyCopyright("(c) Various Mono authors")]
[assembly: AssemblyDefaultAlias("System.Net.Http.dll")]
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyDescription("System.Net.Http.dll")]
[assembly: AssemblyFileVersion("4.0.50524.0")]
[assembly: AssemblyInformationalVersion("4.0.50524.0")]
[assembly: AssemblyProduct("Mono Common Language Infrastructure")]
[assembly: AssemblyTitle("System.Net.Http.dll")]
[assembly: CLSCompliant(true)]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("System.Net.Http.WebRequest, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SatelliteContractVersion("4.0.0.0")]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 62028
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_127 _1D59178A3E2B293760F6FE72820F96FEC4071964A5B9E4BB13F7EA51510A4729; // 0x00 // Static value (base64): AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAQABAQEBAQAAAQEAAQEAAQEBAQEBAQEBAQAAAAAAAAABAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQAAAAEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAAEAAQ== - Metadata: 0x0234FFBC

	// Nested types
	private struct __StaticArrayInitTypeSize_127 // TypeDefIndex: 62027
	{
	}

	// Methods
	internal static uint ComputeStringHash(string s); // 0x000000018687A850-0x000000018687A8A4
}

namespace System.Net.Http
{
	public class HttpClientHandler : HttpMessageHandler // TypeDefIndex: 61947
	{
		// Fields
		private readonly IMonoHttpClientHandler _delegatingHandler; // 0x10
		private ClientCertificateOption _clientCertificateOptions; // 0x18
	
		// Properties
		public ClientCertificateOption ClientCertificateOptions { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x000000018AE15E9C-0x000000018AE16084
		public X509CertificateCollection ClientCertificates { get; } // 0x000000018AE15D6C-0x000000018AE15E9C 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 61946
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static LocalCertificateSelectionCallback __9__23_1; // 0x08
	
			// Constructors
			static __c(); // 0x000000018AE27950-0x000000018AE279B4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal X509Certificate _set_ClientCertificateOptions_b__23_1(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers); // 0x000000018AE27948-0x000000018AE27950
		}
	
		// Constructors
		public HttpClientHandler(); // 0x000000018AE15D48-0x000000018AE15D6C
		internal HttpClientHandler(IMonoHttpClientHandler handler); // 0x000000018AE15D20-0x000000018AE15D48
	
		// Methods
		private static IMonoHttpClientHandler CreateDefaultHandler(); // 0x000000018AE15B80-0x000000018AE15BD0
		protected override void Dispose(bool disposing); // 0x000000018AE15BD0-0x000000018AE15C28
		private void ThrowForModifiedManagedSslOptionsIfStarted(); // 0x000000018AE15CB0-0x000000018AE15D04
		internal void SetWebRequestTimeout(TimeSpan timeout); // 0x000000018AE15C70-0x000000018AE15CB0
		protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken); // 0x000000018AE15C28-0x000000018AE15C70
		[CompilerGenerated]
		private X509Certificate _set_ClientCertificateOptions_b__23_0(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers); // 0x000000018AE15D04-0x000000018AE15D20
	}

	internal interface IMonoHttpClientHandler : IDisposable // TypeDefIndex: 61948
	{
		// Properties
		SslClientAuthenticationOptions SslOptions { get; set; }
	
		// Methods
		Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
		void SetWebRequestTimeout(TimeSpan timeout);
	}

	internal class MonoWebRequestHandler : IMonoHttpClientHandler // TypeDefIndex: 61951
	{
		// Fields
		private static long groupCounter; // 0x00
		private bool allowAutoRedirect; // 0x10
		private DecompressionMethods automaticDecompression; // 0x14
		private CookieContainer cookieContainer; // 0x18
		private ICredentials credentials; // 0x20
		private int maxAutomaticRedirections; // 0x28
		private long maxRequestContentBufferSize; // 0x30
		private bool preAuthenticate; // 0x38
		private IWebProxy proxy; // 0x40
		private bool useCookies; // 0x48
		private bool useProxy; // 0x49
		private SslClientAuthenticationOptions sslOptions; // 0x50
		private bool allowPipelining; // 0x58
		private RequestCachePolicy cachePolicy; // 0x60
		private AuthenticationLevel authenticationLevel; // 0x68
		private TimeSpan continueTimeout; // 0x70
		private TokenImpersonationLevel impersonationLevel; // 0x78
		private int maxResponseHeadersLength; // 0x7C
		private int readWriteTimeout; // 0x80
		private RemoteCertificateValidationCallback serverCertificateValidationCallback; // 0x88
		private bool unsafeAuthenticatedConnectionSharing; // 0x90
		private bool sentRequest; // 0x91
		private string connectionGroupName; // 0x98
		private TimeSpan? timeout; // 0xA0
		private bool disposed; // 0xB0
	
		// Properties
		public CookieContainer CookieContainer { get; } // 0x000000018AE1E260-0x000000018AE1E2D4 
		public long MaxRequestContentBufferSize { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public SslClientAuthenticationOptions SslOptions { get; set; } // 0x000000018AE1E2D4-0x000000018AE1E338 0x000000018AE1E338-0x000000018AE1E368
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 61949
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static System.Func<string, bool> __9__95_0; // 0x08
			public static System.Func<string, bool> __9__96_0; // 0x10
			public static Action<object> __9__99_0; // 0x18
	
			// Constructors
			static __c(); // 0x000000018AE27AE0-0x000000018AE27B44
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetConnectionKeepAlive_b__95_0(string l); // 0x000000018AE27680-0x000000018AE276C4
			internal bool _CreateWebRequest_b__96_0(string l); // 0x000000018AE27644-0x000000018AE27680
			internal void _SendAsync_b__99_0(object l); // 0x000000018AE276C4-0x000000018AE27724
		}
	
		[CompilerGenerated]
		private struct _SendAsync_d__99 : IAsyncStateMachine // TypeDefIndex: 61950
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<HttpResponseMessage> __t__builder; // 0x08
			public MonoWebRequestHandler __4__this; // 0x20
			public CancellationToken cancellationToken; // 0x28
			public HttpRequestMessage request; // 0x30
			private HttpWebRequest _wrequest_5__2; // 0x38
			private HttpWebResponse _wresponse_5__3; // 0x40
			private CancellationTokenRegistration __7__wrap3; // 0x48
			private HttpContent _content_5__5; // 0x60
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1; // 0x68
			private Stream _stream_5__6; // 0x78
			private ConfiguredTaskAwaitable<Stream> __u__2; // 0x80
			private ConfiguredTaskAwaitable<WebResponse> __u__3; // 0x90
			private TaskAwaiter<HttpResponseMessage> __u__4; // 0xA0
	
			// Methods
			private void MoveNext(); // 0x000000018AE24438-0x000000018AE26054
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018AE26054-0x000000018AE260B4
		}
	
		// Constructors
		public MonoWebRequestHandler(); // 0x000000018AE1E10C-0x000000018AE1E260
	
		// Methods
		internal void EnsureModifiability(); // 0x000000018AE1DD3C-0x000000018AE1DDA8
		public void Dispose(); // 0x000000018AE1DD30-0x000000018AE1DD3C
		protected virtual void Dispose(bool disposing); // 0x000000018AE1DCC0-0x000000018AE1DD30
		private bool GetConnectionKeepAlive(HttpRequestHeaders headers); // 0x000000018AE1DDA8-0x000000018AE1DEC8
		internal virtual HttpWebRequest CreateWebRequest(HttpRequestMessage request); // 0x000000018AE1D4A0-0x000000018AE1DCC0
		private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken); // 0x000000018AE1D304-0x000000018AE1D4A0
		private static bool MethodHasBody(HttpMethod method); // 0x000000018AE1DEC8-0x000000018AE1DFA8
		public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken); // 0x000000018AE1DFA8-0x000000018AE1E0B4
		void IMonoHttpClientHandler.SetWebRequestTimeout(TimeSpan timeout); // 0x000000018AE1E0B4-0x000000018AE1E10C
	}

	internal static class PlatformHelper // TypeDefIndex: 61952
	{
		// Methods
		internal static bool IsContentHeader(string name); // 0x000000018AE203B8-0x000000018AE203EC
		internal static string GetSingleHeaderString(string name, IEnumerable<string> values); // 0x000000018AE2035C-0x000000018AE203B8
		internal static StreamContent CreateStreamContent(Stream stream, CancellationToken cancellationToken); // 0x000000018AE202EC-0x000000018AE2035C
	}

	public class ByteArrayContent : HttpContent // TypeDefIndex: 61953
	{
		// Fields
		private readonly byte[] content; // 0x28
		private readonly int offset; // 0x30
		private readonly int count; // 0x34
	
		// Constructors
		public ByteArrayContent(byte[] content); // 0x000000018AE11F7C-0x000000018AE11FFC
	
		// Methods
		protected override System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context); // 0x000000018AE11F48-0x000000018AE11F7C
		protected internal override bool TryComputeLength(out long length); // 0x0000000184DAA2D0-0x0000000184DAA2E0
	}

	public enum ClientCertificateOption // TypeDefIndex: 61954
	{
		Manual = 0,
		Automatic = 1
	}

	public class HttpClient : HttpMessageInvoker // TypeDefIndex: 61956
	{
		// Fields
		private static readonly TimeSpan TimeoutDefault; // 0x00
		private System.Uri base_address; // 0x20
		private CancellationTokenSource cts; // 0x28
		private bool disposed; // 0x30
		private HttpRequestHeaders headers; // 0x38
		private long buffer_size; // 0x40
		private TimeSpan timeout; // 0x48
	
		// Properties
		public HttpRequestHeaders DefaultRequestHeaders { get; } // 0x000000018AE16834-0x000000018AE168A8 
		public long MaxResponseContentBufferSize { get; } // 0x0000000184D85A60-0x0000000184D85A70 
	
		// Nested types
		[CompilerGenerated]
		private struct _SendAsyncWorker_d__47 : IAsyncStateMachine // TypeDefIndex: 61955
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<HttpResponseMessage> __t__builder; // 0x08
			public HttpClient __4__this; // 0x20
			public CancellationToken cancellationToken; // 0x28
			public HttpRequestMessage request; // 0x30
			public HttpCompletionOption completionOption; // 0x38
			private CancellationTokenSource _lcts_5__2; // 0x40
			private HttpResponseMessage _response_5__3; // 0x48
			private ConfiguredTaskAwaitable<HttpResponseMessage> __u__1; // 0x50
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2; // 0x60
	
			// Methods
			private void MoveNext(); // 0x000000018AE260B4-0x000000018AE267E4
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018AE267E4-0x000000018AE26844
		}
	
		// Constructors
		public HttpClient(); // 0x000000018AE167CC-0x000000018AE16834
		public HttpClient(HttpMessageHandler handler, bool disposeHandler); // 0x000000018AE16708-0x000000018AE167CC
		static HttpClient(); // 0x000000018AE166A8-0x000000018AE16708
	
		// Methods
		protected override void Dispose(bool disposing); // 0x000000018AE16084-0x000000018AE160E4
		public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content); // 0x000000018AE160E4-0x000000018AE161D4
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request); // 0x000000018AE162EC-0x000000018AE16348
		public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken); // 0x000000018AE16680-0x000000018AE166A0
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken); // 0x000000018AE16348-0x000000018AE16680
		private async Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken); // 0x000000018AE161D4-0x000000018AE162EC
		[CompilerGenerated]
		[DebuggerHidden]
		private Task<HttpResponseMessage> __n__0(HttpRequestMessage request, CancellationToken cancellationToken); // 0x000000018AE166A0-0x000000018AE166A8
	}

	public enum HttpCompletionOption // TypeDefIndex: 61957
	{
		ResponseContentRead = 0,
		ResponseHeadersRead = 1
	}

	public abstract class HttpContent : IDisposable // TypeDefIndex: 61961
	{
		// Fields
		private FixedMemoryStream buffer; // 0x10
		private bool disposed; // 0x18
		private HttpContentHeaders headers; // 0x20
	
		// Properties
		public HttpContentHeaders Headers { get; } // 0x000000018AE17060-0x000000018AE170BC 
		internal long? LoadedBufferLength { get; } // 0x000000018AE170BC-0x000000018AE17138 
	
		// Nested types
		private sealed class FixedMemoryStream : MemoryStream // TypeDefIndex: 61958
		{
			// Fields
			private readonly long maxSize; // 0x50
	
			// Constructors
			public FixedMemoryStream(long maxSize); // 0x000000018AE1594C-0x000000018AE15978
	
			// Methods
			private void CheckOverflow(int count); // 0x000000018AE157F8-0x000000018AE158B8
			public override void WriteByte(byte value); // 0x000000018AE158B8-0x000000018AE158F0
			public override void Write(byte[] buffer, int offset, int count); // 0x000000018AE158F0-0x000000018AE1594C
		}
	
		[CompilerGenerated]
		private struct _LoadIntoBufferAsync_d__17 : IAsyncStateMachine // TypeDefIndex: 61959
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public HttpContent __4__this; // 0x20
			public long maxBufferSize; // 0x28
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x000000018AE23DA0-0x000000018AE24018
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018AE24018-0x000000018AE24074
		}
	
		[CompilerGenerated]
		private struct _ReadAsStringAsync_d__20 : IAsyncStateMachine // TypeDefIndex: 61960
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<string> __t__builder; // 0x08
			public HttpContent __4__this; // 0x20
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x000000018AE24074-0x000000018AE243D8
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018AE243D8-0x000000018AE24438
		}
	
		// Constructors
		protected HttpContent(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public System.Threading.Tasks.Task CopyToAsync(Stream stream); // 0x000000018AE16BE4-0x000000018AE16BF0
		public System.Threading.Tasks.Task CopyToAsync(Stream stream, TransportContext context); // 0x000000018AE16BF0-0x000000018AE16C80
		private static FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize); // 0x000000018AE16C80-0x000000018AE16CE0
		public void Dispose(); // 0x000000018AE16D08-0x000000018AE16D18
		protected virtual void Dispose(bool disposing); // 0x000000018AE16CE0-0x000000018AE16D08
		public System.Threading.Tasks.Task LoadIntoBufferAsync(); // 0x000000018AE16F10-0x000000018AE16F20
		public async System.Threading.Tasks.Task LoadIntoBufferAsync(long maxBufferSize); // 0x000000018AE16E48-0x000000018AE16F10
		public async Task<string> ReadAsStringAsync(); // 0x000000018AE16F20-0x000000018AE16FF4
		private static Encoding GetEncodingFromBuffer(byte[] buffer, int length, ref int preambleLength); // 0x000000018AE16D18-0x000000018AE16E48
		private static int StartsWith(byte[] array, int length, byte[] value); // 0x000000018AE17004-0x000000018AE17060
		internal System.Threading.Tasks.Task SerializeToStreamAsync_internal(Stream stream, TransportContext context); // 0x000000018AE16FF4-0x000000018AE17004
		protected abstract System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context);
		protected internal abstract bool TryComputeLength(out long length);
	}

	public abstract class HttpMessageHandler : IDisposable // TypeDefIndex: 61962
	{
		// Constructors
		protected HttpMessageHandler(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Dispose(); // 0x000000018AE16D08-0x000000018AE16D18
		protected virtual void Dispose(bool disposing); // 0x00000001841E1670-0x00000001841E1680
		protected internal abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
	}

	public class HttpMessageInvoker : IDisposable // TypeDefIndex: 61963
	{
		// Fields
		private protected HttpMessageHandler handler; // 0x10
		private readonly bool disposeHandler; // 0x18
	
		// Constructors
		public HttpMessageInvoker(HttpMessageHandler handler, bool disposeHandler); // 0x000000018AE19DE4-0x000000018AE19E60
	
		// Methods
		public void Dispose(); // 0x000000018AE16D08-0x000000018AE16D18
		protected virtual void Dispose(bool disposing); // 0x000000018AE19D54-0x000000018AE19D8C
		public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken); // 0x000000018AE19D8C-0x000000018AE19DE4
	}

	public class HttpMethod : IEquatable<HttpMethod> // TypeDefIndex: 61964
	{
		// Fields
		private static readonly HttpMethod delete_method; // 0x00
		private static readonly HttpMethod get_method; // 0x08
		private static readonly HttpMethod head_method; // 0x10
		private static readonly HttpMethod options_method; // 0x18
		private static readonly HttpMethod post_method; // 0x20
		private static readonly HttpMethod put_method; // 0x28
		private static readonly HttpMethod trace_method; // 0x30
		private readonly string method; // 0x10
	
		// Properties
		public string Method { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public static HttpMethod Post { get; } // 0x000000018AE1A238-0x000000018AE1A288 
	
		// Constructors
		public HttpMethod(string method); // 0x000000018AE1A1A8-0x000000018AE1A238
		static HttpMethod(); // 0x000000018AE19EE8-0x000000018AE1A1A8
	
		// Methods
		public static bool operator ==(HttpMethod left, HttpMethod right); // 0x000000018AE1A288-0x000000018AE1A2A4
		public bool Equals(HttpMethod other); // 0x000000018AE19E60-0x000000018AE19E8C
		public override bool Equals(object obj); // 0x000000018AE19E8C-0x000000018AE19EE8
		public override int GetHashCode(); // 0x0000000188479504-0x0000000188479528
		public override string ToString(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
	}

	[Serializable]
	public class HttpRequestException : Exception // TypeDefIndex: 61965
	{
		// Constructors
		public HttpRequestException(); // 0x000000018AE1A2A4-0x000000018AE1A2F0
		public HttpRequestException(string message); // 0x000000018AE1A2F0-0x000000018AE1A34C
		public HttpRequestException(string message, Exception inner); // 0x000000018AE1A34C-0x000000018AE1A3AC
	}

	public class HttpRequestMessage : IDisposable // TypeDefIndex: 61966
	{
		// Fields
		private HttpRequestHeaders headers; // 0x10
		private HttpMethod method; // 0x18
		private System.Version version; // 0x20
		private System.Uri uri; // 0x28
		private bool is_used; // 0x30
		private bool disposed; // 0x31
		[CompilerGenerated]
		private HttpContent _Content_k__BackingField; // 0x38
	
		// Properties
		public HttpContent Content { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public HttpRequestHeaders Headers { get; } // 0x000000018AE1B0AC-0x000000018AE1B104 
		public HttpMethod Method { get; set; } // 0x000000018385B100-0x000000018385B110 0x000000018AE1B158-0x000000018AE1B200
		public System.Uri RequestUri { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x000000018AE1B200-0x000000018AE1B2C0
		public System.Version Version { get; } // 0x000000018AE1B104-0x000000018AE1B158 
	
		// Constructors
		public HttpRequestMessage(HttpMethod method, string requestUri); // 0x000000018AE1AFE4-0x000000018AE1B07C
		public HttpRequestMessage(HttpMethod method, System.Uri requestUri); // 0x000000018AE1B07C-0x000000018AE1B0AC
	
		// Methods
		private static bool IsAllowedAbsoluteUri(System.Uri uri); // 0x000000018AE1AC58-0x000000018AE1AD88
		public void Dispose(); // 0x000000018AE1AC20-0x000000018AE1AC2C
		protected virtual void Dispose(bool disposing); // 0x000000018AE1AC2C-0x000000018AE1AC58
		internal bool SetIsUsed(); // 0x000000018AE1AD88-0x000000018AE1AD98
		public override string ToString(); // 0x000000018AE1AD98-0x000000018AE1AFE4
	}

	public class HttpResponseMessage : IDisposable // TypeDefIndex: 61967
	{
		// Fields
		private HttpResponseHeaders headers; // 0x10
		private string reasonPhrase; // 0x18
		private HttpStatusCode statusCode; // 0x20
		private System.Version version; // 0x28
		private bool disposed; // 0x30
		[CompilerGenerated]
		private HttpContent _Content_k__BackingField; // 0x38
		[CompilerGenerated]
		private HttpRequestMessage _RequestMessage_k__BackingField; // 0x40
	
		// Properties
		public HttpContent Content { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public HttpResponseHeaders Headers { get; } // 0x000000018AE1B568-0x000000018AE1B5C0 
		public string ReasonPhrase { get; set; } // 0x000000018AE1B5C0-0x000000018AE1B5D4 0x0000000185392C40-0x0000000185392C50
		public HttpRequestMessage RequestMessage { [CompilerGenerated] set; } // 0x00000001842B4AE0-0x00000001842B4AF0
		public HttpStatusCode StatusCode { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x000000018AE1B628-0x000000018AE1B680
		public System.Version Version { get; } // 0x000000018AE1B5D4-0x000000018AE1B628 
	
		// Constructors
		public HttpResponseMessage(HttpStatusCode statusCode); // 0x000000018AE1B560-0x000000018AE1B568
	
		// Methods
		public void Dispose(); // 0x000000018AE1B314-0x000000018AE1B320
		protected virtual void Dispose(bool disposing); // 0x000000018AE1B320-0x000000018AE1B34C
		public override string ToString(); // 0x000000018AE1B34C-0x000000018AE1B560
	}

	public class MultipartContent : HttpContent, IEnumerable<HttpContent> // TypeDefIndex: 61969
	{
		// Fields
		private List<HttpContent> nested_content; // 0x28
		private readonly string boundary; // 0x30
	
		// Nested types
		[CompilerGenerated]
		private struct _SerializeToStreamAsync_d__8 : IAsyncStateMachine // TypeDefIndex: 61968
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public MultipartContent __4__this; // 0x20
			public Stream stream; // 0x28
			public TransportContext context; // 0x30
			private StringBuilder _sb_5__2; // 0x38
			private int _i_5__3; // 0x40
			private HttpContent _c_5__4; // 0x48
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1; // 0x50
	
			// Methods
			private void MoveNext(); // 0x000000018AE26844-0x000000018AE275E8
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018AE275E8-0x000000018AE27644
		}
	
		// Constructors
		public MultipartContent(string subtype); // 0x000000018AE1EC54-0x000000018AE1ECF0
		public MultipartContent(string subtype, string boundary); // 0x000000018AE1ECF0-0x000000018AE1F050
	
		// Methods
		private static bool IsValidRFC2049(string s); // 0x000000018AE1E690-0x000000018AE1E748
		public virtual void Add(HttpContent content); // 0x000000018AE1E368-0x000000018AE1E468
		protected override void Dispose(bool disposing); // 0x000000018AE1E468-0x000000018AE1E610
		protected override async System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context); // 0x000000018AE1E748-0x000000018AE1E834
		protected internal override bool TryComputeLength(out long length); // 0x000000018AE1E8B4-0x000000018AE1EC54
		public IEnumerator<HttpContent> GetEnumerator(); // 0x000000018AE1E610-0x000000018AE1E690
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018AE1E834-0x000000018AE1E8B4
	}

	public class MultipartFormDataContent : MultipartContent // TypeDefIndex: 61970
	{
		// Constructors
		public MultipartFormDataContent(); // 0x000000018AE1F340-0x000000018AE1F37C
	
		// Methods
		public override void Add(HttpContent content); // 0x000000018AE1F300-0x000000018AE1F340
		public void Add(HttpContent content, string name); // 0x000000018AE1F13C-0x000000018AE1F1E8
		public void Add(HttpContent content, string name, string fileName); // 0x000000018AE1F1E8-0x000000018AE1F300
		private void AddContentDisposition(HttpContent content, string name, string fileName); // 0x000000018AE1F050-0x000000018AE1F13C
	}

	public class StreamContent : HttpContent // TypeDefIndex: 61971
	{
		// Fields
		private readonly Stream content; // 0x28
		private readonly int bufferSize; // 0x30
		private readonly CancellationToken cancellationToken; // 0x38
		private readonly long startPosition; // 0x40
		private bool contentCopied; // 0x48
	
		// Constructors
		public StreamContent(Stream content); // 0x000000018AE2287C-0x000000018AE2288C
		public StreamContent(Stream content, int bufferSize); // 0x000000018AE22778-0x000000018AE2287C
		internal StreamContent(Stream content, CancellationToken cancellationToken); // 0x000000018AE2288C-0x000000018AE228C4
	
		// Methods
		protected override void Dispose(bool disposing); // 0x000000018AE22600-0x000000018AE22648
		protected override System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context); // 0x000000018AE22648-0x000000018AE2271C
		protected internal override bool TryComputeLength(out long length); // 0x000000018AE2271C-0x000000018AE22778
	}

	public class StringContent : ByteArrayContent // TypeDefIndex: 61972
	{
		// Constructors
		public StringContent(string content); // 0x000000018AE228FC-0x000000018AE2291C
		public StringContent(string content, Encoding encoding, string mediaType); // 0x000000018AE2291C-0x000000018AE22A1C
	
		// Methods
		private static byte[] GetByteArray(string content, Encoding encoding); // 0x000000018AE228C4-0x000000018AE228FC
	}
}

namespace System.Net.Http.Headers
{
	public class AuthenticationHeaderValue : ICloneable // TypeDefIndex: 61973
	{
		// Fields
		[CompilerGenerated]
		private string _Parameter_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Scheme_k__BackingField; // 0x18
	
		// Properties
		public string Parameter { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string Scheme { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		public AuthenticationHeaderValue(string scheme, string parameter); // 0x000000018AE11EFC-0x000000018AE11F48
		private AuthenticationHeaderValue(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		object ICloneable.Clone(); // 0x0000000183840500-0x0000000183840510
		public override bool Equals(object obj); // 0x000000018AE11AA4-0x000000018AE11B20
		public override int GetHashCode(); // 0x000000018AE11B20-0x000000018AE11B94
		public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue); // 0x000000018AE11D90-0x000000018AE11E4C
		internal static bool TryParse(string input, int minimalCount, out List<AuthenticationHeaderValue> result); // 0x000000018AE11E4C-0x000000018AE11EFC
		private static bool TryParseElement(Lexer lexer, out AuthenticationHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018AE11BE0-0x000000018AE11D90
		public override string ToString(); // 0x000000018AE11B94-0x000000018AE11BE0
	}

	public class CacheControlHeaderValue : ICloneable // TypeDefIndex: 61974
	{
		// Fields
		private List<NameValueHeaderValue> extensions; // 0x10
		private List<string> no_cache_headers; // 0x18
		private List<string> private_headers; // 0x20
		[CompilerGenerated]
		private TimeSpan? _MaxAge_k__BackingField; // 0x28
		[CompilerGenerated]
		private bool _MaxStale_k__BackingField; // 0x38
		[CompilerGenerated]
		private TimeSpan? _MaxStaleLimit_k__BackingField; // 0x40
		[CompilerGenerated]
		private TimeSpan? _MinFresh_k__BackingField; // 0x50
		[CompilerGenerated]
		private bool _MustRevalidate_k__BackingField; // 0x60
		[CompilerGenerated]
		private bool _NoCache_k__BackingField; // 0x61
		[CompilerGenerated]
		private bool _NoStore_k__BackingField; // 0x62
		[CompilerGenerated]
		private bool _NoTransform_k__BackingField; // 0x63
		[CompilerGenerated]
		private bool _OnlyIfCached_k__BackingField; // 0x64
		[CompilerGenerated]
		private bool _Private_k__BackingField; // 0x65
		[CompilerGenerated]
		private bool _ProxyRevalidate_k__BackingField; // 0x66
		[CompilerGenerated]
		private bool _Public_k__BackingField; // 0x67
		[CompilerGenerated]
		private TimeSpan? _SharedMaxAge_k__BackingField; // 0x68
	
		// Properties
		public ICollection<NameValueHeaderValue> Extensions { get; } // 0x000000018AE137D4-0x000000018AE13858 
		public TimeSpan? MaxAge { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8FAD0-0x0000000184D8FAE0 0x0000000184D8FAE0-0x0000000184D8FAF0
		public bool MaxStale { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F2A70-0x00000001811F2A80 0x00000001811F2A80-0x00000001811F2A90
		public TimeSpan? MaxStaleLimit { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D905C0-0x0000000184D905D0 0x0000000184D926F0-0x0000000184D92700
		public TimeSpan? MinFresh { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8CE10-0x0000000184D8CE20 0x0000000184D906B0-0x0000000184D906C0
		public bool MustRevalidate { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88340-0x0000000184D88350 0x0000000184D88350-0x0000000184D88360
		public bool NoCache { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D892D0-0x0000000184D892E0 0x0000000184D8FF40-0x0000000184D8FF50
		public ICollection<string> NoCacheHeaders { get; } // 0x000000018AE13858-0x000000018AE138DC 
		public bool NoStore { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8FF20-0x0000000184D8FF30 0x0000000184D8FF30-0x0000000184D8FF40
		public bool NoTransform { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAA2E0-0x0000000184DAA2F0 0x0000000184DAA300-0x0000000184DAA310
		public bool OnlyIfCached { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8F050-0x0000000184D8F060 0x0000000184D8F080-0x0000000184D8F090
		public bool Private { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAA1E0-0x0000000184DAA1F0 0x0000000184DAA310-0x0000000184DAA320
		public ICollection<string> PrivateHeaders { get; } // 0x000000018AE138DC-0x000000018AE13960 
		public bool ProxyRevalidate { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAA1D0-0x0000000184DAA1E0 0x0000000184DAA320-0x0000000184DAA330
		public bool Public { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAA2F0-0x0000000184DAA300 0x0000000184DAA330-0x0000000184DAA340
		public TimeSpan? SharedMaxAge { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA63C0-0x0000000184DA63D0 0x0000000184DA63D0-0x0000000184DA63E0
	
		// Constructors
		public CacheControlHeaderValue(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		object ICloneable.Clone(); // 0x000000018AE12464-0x000000018AE12998
		public override bool Equals(object obj); // 0x000000018AE11FFC-0x000000018AE12240
		public override int GetHashCode(); // 0x000000018AE12240-0x000000018AE12464
		public static bool TryParse(string input, out CacheControlHeaderValue parsedValue); // 0x000000018AE12FDC-0x000000018AE137D4
		public override string ToString(); // 0x000000018AE12998-0x000000018AE12FDC
	}

	internal static class CollectionExtensions // TypeDefIndex: 61975
	{
		// Extension methods
		public static bool SequenceEqual<TSource>(this List<TSource> first, List<TSource> second);
		public static void SetValue(this List<NameValueHeaderValue> parameters, string key, string value); // 0x000000018AE13960-0x000000018AE13A5C
		public static string ToString<T>(this List<T> list);
		public static void ToStringBuilder<T>(this List<T> list, StringBuilder sb);
	}

	internal delegate bool ElementTryParser<T>(Lexer lexer, out ref T parsedValue, out System.Net.Http.Headers.Token token); // TypeDefIndex: 61976; 0x00000000-0x00000000

	internal static class CollectionParser // TypeDefIndex: 61977
	{
		// Methods
		public static bool TryParse<T>(string input, int minimalCount, ElementTryParser<T> parser, out List<T> result)
			where T : class;
		public static bool TryParse(string input, int minimalCount, out List<string> result); // 0x000000018AE13B64-0x000000018AE13C14
		private static bool TryParseStringElement(Lexer lexer, out string parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018AE13A5C-0x000000018AE13B64
	}

	public class ContentDispositionHeaderValue : ICloneable // TypeDefIndex: 61978
	{
		// Fields
		private string dispositionType; // 0x10
		private List<NameValueHeaderValue> parameters; // 0x18
	
		// Properties
		public string DispositionType { set; } // 0x000000018AE146C8-0x000000018AE146FC
		public string FileName { set; } // 0x000000018AE1475C-0x000000018AE147BC
		public string FileNameStar { set; } // 0x000000018AE146FC-0x000000018AE1475C
		public string Name { set; } // 0x000000018AE147BC-0x000000018AE1481C
		public ICollection<NameValueHeaderValue> Parameters { get; } // 0x000000018AE14644-0x000000018AE146C8 
	
		// Constructors
		private ContentDispositionHeaderValue(); // 0x00000001841E1670-0x00000001841E1680
		public ContentDispositionHeaderValue(string dispositionType); // 0x000000018AE1463C-0x000000018AE14644
		protected ContentDispositionHeaderValue(ContentDispositionHeaderValue source); // 0x000000018AE14360-0x000000018AE1463C
	
		// Methods
		object ICloneable.Clone(); // 0x000000018AE14144-0x000000018AE141A4
		public override bool Equals(object obj); // 0x000000018AE13FC8-0x000000018AE14054
		private static string EncodeBase64Value(string value); // 0x000000018AE13C14-0x000000018AE13DA0
		private static string EncodeRFC5987(string value); // 0x000000018AE13DA0-0x000000018AE13FC8
		public override int GetHashCode(); // 0x000000018AE14054-0x000000018AE140C4
		private void SetValue(string key, string value); // 0x000000018AE140C4-0x000000018AE14144
		public override string ToString(); // 0x000000018AE141A4-0x000000018AE141D4
		public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue); // 0x000000018AE141D4-0x000000018AE14360
	}

	public class ContentRangeHeaderValue : ICloneable // TypeDefIndex: 61979
	{
		// Fields
		private string unit; // 0x10
		[CompilerGenerated]
		private long? _From_k__BackingField; // 0x18
		[CompilerGenerated]
		private long? _Length_k__BackingField; // 0x28
		[CompilerGenerated]
		private long? _To_k__BackingField; // 0x38
	
		// Properties
		public long? From { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D890C0-0x0000000184D890D0 0x0000000184D890D0-0x0000000184D890E0
		public long? Length { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8FAD0-0x0000000184D8FAE0 0x0000000184D8FAE0-0x0000000184D8FAF0
		public long? To { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8FD20-0x0000000184D8FD30 0x0000000184D91AB0-0x0000000184D91AC0
		public string Unit { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Constructors
		private ContentRangeHeaderValue(); // 0x000000018AE15030-0x000000018AE15070
	
		// Methods
		object ICloneable.Clone(); // 0x0000000183840500-0x0000000183840510
		public override bool Equals(object obj); // 0x000000018AE1481C-0x000000018AE148F8
		public override int GetHashCode(); // 0x000000018AE148F8-0x000000018AE149F0
		public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue); // 0x000000018AE14C00-0x000000018AE15030
		public override string ToString(); // 0x000000018AE149F0-0x000000018AE14C00
	}

	public class EntityTagHeaderValue : ICloneable // TypeDefIndex: 61980
	{
		// Fields
		private static readonly EntityTagHeaderValue any; // 0x00
		[CompilerGenerated]
		private bool _IsWeak_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Tag_k__BackingField; // 0x18
	
		// Properties
		public bool IsWeak { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
		public string Tag { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		internal EntityTagHeaderValue(); // 0x00000001841E1670-0x00000001841E1680
		static EntityTagHeaderValue(); // 0x000000018AE15774-0x000000018AE157F8
	
		// Methods
		object ICloneable.Clone(); // 0x0000000183840500-0x0000000183840510
		public override bool Equals(object obj); // 0x000000018AE15280-0x000000018AE152FC
		public override int GetHashCode(); // 0x000000018AE152FC-0x000000018AE1536C
		public static bool TryParse(string input, out EntityTagHeaderValue parsedValue); // 0x000000018AE155F0-0x000000018AE156C4
		private static bool TryParseElement(Lexer lexer, out EntityTagHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018AE153B4-0x000000018AE155F0
		internal static bool TryParse(string input, int minimalCount, out List<EntityTagHeaderValue> result); // 0x000000018AE156C4-0x000000018AE15774
		public override string ToString(); // 0x000000018AE1536C-0x000000018AE153B4
	}

	internal static class HashCodeCalculator // TypeDefIndex: 61981
	{
		// Methods
		public static int Calculate<T>(ICollection<T> list);
	}

	internal delegate bool TryParseDelegate<T>(string value, out ref T result); // TypeDefIndex: 61982; 0x00000000-0x00000000

	internal delegate bool TryParseListDelegate<T>(string value, int minimalCount, out List<T> result); // TypeDefIndex: 61983; 0x00000000-0x00000000

	internal abstract class HeaderInfo // TypeDefIndex: 61986
	{
		// Fields
		public bool AllowsMany; // 0x10
		public readonly HttpHeaderKind HeaderKind; // 0x14
		public readonly string Name; // 0x18
		[CompilerGenerated]
		private System.Func<object, string> _CustomToString_k__BackingField; // 0x20
	
		// Properties
		public System.Func<object, string> CustomToString { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public virtual string Separator { get; } // 0x000000018AE15A98-0x000000018AE15AE4 
	
		// Nested types
		private class HeaderTypeInfo<T, U> : HeaderInfo // TypeDefIndex: 61984
			where U : class
		{
			// Fields
			private readonly TryParseDelegate<T> parser;
	
			// Constructors
			public HeaderTypeInfo(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind);
	
			// Methods
			public override void AddToCollection(object collection, object value);
			protected override object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo);
			public override List<string> ToStringCollection(object collection);
			public override bool TryParse(string value, out object result);
		}
	
		private class CollectionHeaderTypeInfo<T, U> : HeaderTypeInfo<T, U> // TypeDefIndex: 61985
			where U : class
		{
			// Fields
			private readonly int minimalCount;
			private readonly string separator;
			private readonly TryParseListDelegate<T> parser;
	
			// Properties
			public override string Separator { get; }
	
			// Constructors
			public CollectionHeaderTypeInfo(string name, TryParseListDelegate<T> parser, HttpHeaderKind headerKind, int minimalCount, string separator);
	
			// Methods
			public override bool TryParse(string value, out object result);
		}
	
		// Constructors
		protected HeaderInfo(string name, HttpHeaderKind headerKind); // 0x000000018AE15A78-0x000000018AE15A98
	
		// Methods
		public static HeaderInfo CreateSingle<T>(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind, System.Func<object, string> toString = null);
		public static HeaderInfo CreateMulti<T>(string name, TryParseListDelegate<T> elementParser, HttpHeaderKind headerKind, int minimalCount = 1 /* Metadata: 0x0234FFA8 */, string separator = ", " /* Metadata: 0x0234FFA9 */)
			where T : class;
		public object CreateCollection(HttpHeaders headers); // 0x000000018AE15A38-0x000000018AE15A78
		public abstract void AddToCollection(object collection, object value);
		protected abstract object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo);
		public abstract List<string> ToStringCollection(object collection);
		public abstract bool TryParse(string value, out object result);
	}

	public sealed class HttpContentHeaders : HttpHeaders // TypeDefIndex: 61987
	{
		// Fields
		private readonly HttpContent content; // 0x20
	
		// Properties
		public ContentDispositionHeaderValue ContentDisposition { get; set; } // 0x000000018AE168F8-0x000000018AE16944 0x000000018AE16AB4-0x000000018AE16B18
		public long? ContentLength { get; set; } // 0x000000018AE16944-0x000000018AE16A68 0x000000018AE16B18-0x000000018AE16B80
		public MediaTypeHeaderValue ContentType { get; set; } // 0x000000018AE16A68-0x000000018AE16AB4 0x000000018AE16B80-0x000000018AE16BE4
	
		// Constructors
		internal HttpContentHeaders(HttpContent content); // 0x000000018AE168A8-0x000000018AE168F8
	}

	[Flags]
	internal enum HttpHeaderKind // TypeDefIndex: 61988
	{
		None = 0,
		Request = 1,
		Response = 2,
		Content = 4
	}

	public sealed class HttpHeaderValueCollection<T> : ICollection<T> // TypeDefIndex: 61989
		where T : class
	{
		// Fields
		private readonly List<T> list;
		private readonly HttpHeaders headers;
		private readonly System.Net.Http.Headers.HeaderInfo headerInfo;
		private List<string> invalidValues;
	
		// Properties
		public int Count { get; }
		internal List<string> InvalidValues { get; }
		public bool IsReadOnly { get; }
	
		// Constructors
		internal HttpHeaderValueCollection(HttpHeaders headers, System.Net.Http.Headers.HeaderInfo headerInfo);
	
		// Methods
		public void Add(T item);
		internal void AddRange(List<T> values);
		internal void AddInvalidValue(string invalidValue);
		public void Clear();
		public bool Contains(T item);
		public void CopyTo(T[] array, int arrayIndex);
		public bool Remove(T item);
		public override string ToString();
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		internal T Find(Predicate<T> predicate);
	}

	public abstract class HttpHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>> // TypeDefIndex: 61992
	{
		// Fields
		private static readonly Dictionary<string, System.Net.Http.Headers.HeaderInfo> known_headers; // 0x00
		private readonly Dictionary<string, HeaderBucket> headers; // 0x10
		private readonly HttpHeaderKind HeaderKind; // 0x18
		internal bool? connectionclose; // 0x1C
		internal bool? transferEncodingChunked; // 0x1E
	
		// Nested types
		private class HeaderBucket // TypeDefIndex: 61990
		{
			// Fields
			public object Parsed; // 0x10
			private List<string> values; // 0x18
			public readonly System.Func<object, string> CustomToString; // 0x20
	
			// Properties
			public bool HasStringValues { get; } // 0x000000018AE159C4-0x000000018AE159DC 
			public List<string> Values { get; set; } // 0x000000018AE159DC-0x000000018AE15A38 0x0000000185392C40-0x0000000185392C50
	
			// Constructors
			public HeaderBucket(object parsed, System.Func<object, string> converter); // 0x0000000184D7D160-0x0000000184D7D190
	
			// Methods
			public string ParsedToString(); // 0x000000018AE15978-0x000000018AE159C4
		}
	
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__19 : IEnumerator<KeyValuePair<string, IEnumerable<string>>> // TypeDefIndex: 61991
		{
			// Fields
			private int __1__state; // 0x10
			private KeyValuePair<string, IEnumerable<string>> __2__current; // 0x18
			public HttpHeaders __4__this; // 0x28
			private Dictionary<string, HeaderBucket> __7__wrap1; // 0x30
	
			// Properties
			KeyValuePair<string, IEnumerable<string>> IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.Current { [DebuggerHidden] get; } // 0x0000000184D890C0-0x0000000184D890D0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018AE23CF4-0x000000018AE23D3C 
	
			// Constructors
			[DebuggerHidden]
			public _GetEnumerator_d__19(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018AE23D3C-0x000000018AE23DA0
			private bool MoveNext(); // 0x000000018AE23994-0x000000018AE23CA8
			private void __m__Finally1(); // 0x0000000184D88D80-0x0000000184D88D90
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AE23CA8-0x000000018AE23CF4
		}
	
		// Constructors
		static HttpHeaders(); // 0x000000018AE180B4-0x000000018AE19CC0
		protected HttpHeaders(); // 0x000000018AE19CE4-0x000000018AE19D54
		internal HttpHeaders(HttpHeaderKind headerKind); // 0x000000018AE19CC0-0x000000018AE19CE4
	
		// Methods
		private bool AddInternal(string name, IEnumerable<string> values, System.Net.Http.Headers.HeaderInfo headerInfo, bool ignoreInvalid); // 0x000000018AE17138-0x000000018AE175BC
		public bool TryAddWithoutValidation(string name, IEnumerable<string> values); // 0x000000018AE17F48-0x000000018AE18004
		private System.Net.Http.Headers.HeaderInfo CheckName(string name); // 0x000000018AE175BC-0x000000018AE17724
		private bool TryCheckName(string name, out System.Net.Http.Headers.HeaderInfo headerInfo); // 0x000000018AE18004-0x000000018AE180B4
		[IteratorStateMachine(typeof(_GetEnumerator_d__19))]
		public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator(); // 0x000000018AE17844-0x000000018AE17884
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018AE17D14-0x000000018AE17D1C
		public bool Remove(string name); // 0x000000018AE17CB0-0x000000018AE17D14
		internal static string GetSingleHeaderString(string key, IEnumerable<string> values); // 0x000000018AE17944-0x000000018AE17CB0
		public override string ToString(); // 0x000000018AE17D1C-0x000000018AE17F48
		internal void AddOrRemove<T>(string name, T value, System.Func<object, string> converter = null)
			where T : class;
		internal void AddOrRemove<T>(string name, T? value)
			where T : struct;
		internal void AddOrRemove<T>(string name, T? value, System.Func<object, string> converter)
			where T : struct;
		private List<string> GetAllHeaderValues(HeaderBucket bucket, System.Net.Http.Headers.HeaderInfo headerInfo); // 0x000000018AE17724-0x000000018AE17844
		internal static HttpHeaderKind GetKnownHeaderKind(string name); // 0x000000018AE17884-0x000000018AE17944
		internal T GetValue<T>(string name);
		internal HttpHeaderValueCollection<T> GetValues<T>(string name)
			where T : class;
		internal void SetValue<T>(string name, T value, System.Func<object, string> toStringConverter = null);
	}

	public sealed class HttpRequestHeaders : HttpHeaders // TypeDefIndex: 61994
	{
		// Fields
		private bool? expectContinue; // 0x20
	
		// Properties
		public AuthenticationHeaderValue Authorization { set; } // 0x000000018AE1AAD8-0x000000018AE1AB3C
		public HttpHeaderValueCollection<string> Connection { get; } // 0x000000018AE1A72C-0x000000018AE1A778 
		public bool? ConnectionClose { get; set; } // 0x000000018AE1A5B4-0x000000018AE1A72C 0x000000018AE1AB3C-0x000000018AE1AC20
		public bool? ExpectContinue { get; } // 0x000000018AE1A778-0x000000018AE1A8DC 
		public string Host { get; } // 0x000000018AE1A8DC-0x000000018AE1A928 
		public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding { get; } // 0x000000018AE1AA8C-0x000000018AE1AAD8 
		public bool? TransferEncodingChunked { get; } // 0x000000018AE1A928-0x000000018AE1AA8C 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 61993
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<string> __9__19_0; // 0x08
			public static Predicate<TransferCodingHeaderValue> __9__29_0; // 0x10
			public static Predicate<TransferCodingHeaderValue> __9__71_0; // 0x18
	
			// Constructors
			static __c(); // 0x000000018AE279B4-0x000000018AE27A18
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _get_ConnectionClose_b__19_0(string l); // 0x000000018AE27864-0x000000018AE278A8
			internal bool _get_ExpectContinue_b__29_0(TransferCodingHeaderValue l); // 0x000000018AE278A8-0x000000018AE278F8
			internal bool _get_TransferEncodingChunked_b__71_0(TransferCodingHeaderValue l); // 0x000000018AE278F8-0x000000018AE27948
		}
	
		// Constructors
		internal HttpRequestHeaders(); // 0x000000018AE1A560-0x000000018AE1A5B4
	
		// Methods
		internal void AddHeaders(HttpRequestHeaders headers); // 0x000000018AE1A3AC-0x000000018AE1A560
	}

	public sealed class HttpResponseHeaders : HttpHeaders // TypeDefIndex: 61995
	{
		// Constructors
		internal HttpResponseHeaders(); // 0x000000018AE1B2C0-0x000000018AE1B314
	}

	internal struct Token // TypeDefIndex: 61997
	{
		// Fields
		public static readonly Token Empty; // 0x00
		private readonly Type type; // 0x00
		[CompilerGenerated]
		private int _StartPosition_k__BackingField; // 0x04
		[CompilerGenerated]
		private int _EndPosition_k__BackingField; // 0x08
	
		// Properties
		public int StartPosition { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88B20-0x0000000184D88B30 0x0000000184D88B50-0x0000000184D88B60
		public int EndPosition { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000184D88B10-0x0000000184D88B20 0x0000000184D88B40-0x0000000184D88B50
		public Type Kind { get; } // 0x0000000182B77620-0x0000000182B77630 
	
		// Nested types
		public enum Type // TypeDefIndex: 61996
		{
			Error = 0,
			End = 1,
			Token = 2,
			QuotedString = 3,
			SeparatorEqual = 4,
			SeparatorSemicolon = 5,
			SeparatorSlash = 6,
			SeparatorDash = 7,
			SeparatorComma = 8,
			OpenParens = 9
		}
	
		// Constructors
		public Token(Type type, int startPosition, int endPosition); // 0x000000018AE2324C-0x000000018AE2329C
		static Token(); // 0x000000018AE231E4-0x000000018AE2324C
	
		// Methods
		public static implicit operator Type(Token token); // 0x0000000182B77620-0x0000000182B77630
		public override string ToString(); // 0x000000018AE2315C-0x000000018AE231AC
	}

	internal class Lexer // TypeDefIndex: 61998
	{
		// Fields
		private static readonly bool[] token_chars; // 0x00
		private static readonly int last_token_char; // 0x08
		private static readonly string[] dt_formats; // 0x10
		private readonly string s; // 0x10
		private int pos; // 0x18
	
		// Properties
		public int Position { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
	
		// Constructors
		public Lexer(string stream); // 0x00000001853908C0-0x00000001853908D0
		static Lexer(); // 0x000000018AE1C1C0-0x000000018AE1C368
	
		// Methods
		public string GetStringValue(System.Net.Http.Headers.Token token); // 0x000000018AE1B7F4-0x000000018AE1B848
		public string GetStringValue(System.Net.Http.Headers.Token start, System.Net.Http.Headers.Token end); // 0x000000018AE1B780-0x000000018AE1B7F4
		public string GetQuotedStringValue(System.Net.Http.Headers.Token start); // 0x000000018AE1B6E0-0x000000018AE1B750
		public string GetRemainingStringValue(int position); // 0x000000018AE1B750-0x000000018AE1B780
		public bool IsStarStringValue(System.Net.Http.Headers.Token token); // 0x000000018AE1B848-0x000000018AE1B8CC
		public bool TryGetNumericValue(System.Net.Http.Headers.Token token, out int value); // 0x000000018AE1BFD4-0x000000018AE1C068
		public bool TryGetNumericValue(System.Net.Http.Headers.Token token, out long value); // 0x000000018AE1C068-0x000000018AE1C0FC
		public TimeSpan? TryGetTimeSpanValue(System.Net.Http.Headers.Token token); // 0x000000018AE1C0FC-0x000000018AE1C1C0
		public bool TryGetDateValue(System.Net.Http.Headers.Token token, out DateTimeOffset value); // 0x000000018AE1BDA4-0x000000018AE1BE7C
		public static bool TryGetDateValue(string text, out DateTimeOffset value); // 0x000000018AE1BE7C-0x000000018AE1BF40
		public bool TryGetDoubleValue(System.Net.Http.Headers.Token token, out double value); // 0x000000018AE1BF40-0x000000018AE1BFD4
		public static bool IsValidToken(string input); // 0x000000018AE1B934-0x000000018AE1B9A0
		public static bool IsValidCharacter(char input); // 0x000000018AE1B8CC-0x000000018AE1B934
		public void EatChar(); // 0x0000000184D9CE40-0x0000000184D9CE50
		public int PeekChar(); // 0x000000018AE1B9A0-0x000000018AE1B9D4
		public bool ScanCommentOptional(out string value, out System.Net.Http.Headers.Token readToken); // 0x000000018AE1B9D4-0x000000018AE1BAFC
		public System.Net.Http.Headers.Token Scan(bool recognizeDash = false /* Metadata: 0x0234FFBA */); // 0x000000018AE1BAFC-0x000000018AE1BDA4
	}

	public class MediaTypeHeaderValue : ICloneable // TypeDefIndex: 62000
	{
		// Fields
		internal List<NameValueHeaderValue> parameters; // 0x10
		internal string media_type; // 0x18
	
		// Properties
		public string CharSet { get; set; } // 0x000000018AE1CD00-0x000000018AE1CE24 0x000000018AE1CEA8-0x000000018AE1CF54
		public string MediaType { set; } // 0x000000018AE1CF54-0x000000018AE1D0E0
		public ICollection<NameValueHeaderValue> Parameters { get; } // 0x000000018AE1CE24-0x000000018AE1CEA8 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 61999
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<NameValueHeaderValue> __9__6_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018AE27A7C-0x000000018AE27AE0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _get_CharSet_b__6_0(NameValueHeaderValue l); // 0x000000018AE27814-0x000000018AE27864
		}
	
		// Constructors
		public MediaTypeHeaderValue(string mediaType); // 0x000000018AE1CCF8-0x000000018AE1CD00
		protected MediaTypeHeaderValue(MediaTypeHeaderValue source); // 0x000000018AE1CA1C-0x000000018AE1CCF8
		internal MediaTypeHeaderValue(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		object ICloneable.Clone(); // 0x000000018AE1C66C-0x000000018AE1C6CC
		public override bool Equals(object obj); // 0x000000018AE1C570-0x000000018AE1C5FC
		public override int GetHashCode(); // 0x000000018AE1C5FC-0x000000018AE1C66C
		public override string ToString(); // 0x000000018AE1C6CC-0x000000018AE1C708
		public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue); // 0x000000018AE1C8A0-0x000000018AE1CA1C
		internal static System.Net.Http.Headers.Token? TryParseMediaType(Lexer lexer, out string media); // 0x000000018AE1C708-0x000000018AE1C8A0
	}

	public sealed class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue // TypeDefIndex: 62001
	{
		// Constructors
		private MediaTypeWithQualityHeaderValue(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private static bool TryParseElement(Lexer lexer, out MediaTypeWithQualityHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018AE1D0E0-0x000000018AE1D254
		internal static bool TryParse(string input, int minimalCount, out List<MediaTypeWithQualityHeaderValue> result); // 0x000000018AE1D254-0x000000018AE1D304
	}

	public class NameValueHeaderValue : ICloneable // TypeDefIndex: 62002
	{
		// Fields
		internal string value; // 0x10
		[CompilerGenerated]
		private string _Name_k__BackingField; // 0x18
	
		// Properties
		public string Name { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public string Value { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x000000018AE1FB08-0x000000018AE1FC58
	
		// Constructors
		public NameValueHeaderValue(string name, string value); // 0x000000018AE1FABC-0x000000018AE1FB08
		protected internal NameValueHeaderValue(NameValueHeaderValue source); // 0x000000018AE1FA80-0x000000018AE1FABC
		internal NameValueHeaderValue(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		internal static NameValueHeaderValue Create(string name, string value); // 0x000000018AE1F37C-0x000000018AE1F3EC
		object ICloneable.Clone(); // 0x000000018AE1F498-0x000000018AE1F4F8
		public override int GetHashCode(); // 0x000000018AE11B20-0x000000018AE11B94
		public override bool Equals(object obj); // 0x000000018AE1F3EC-0x000000018AE1F498
		internal static bool TryParsePragma(string input, int minimalCount, out List<NameValueHeaderValue> result); // 0x000000018AE1F9D0-0x000000018AE1FA80
		internal static bool TryParseParameters(Lexer lexer, out List<NameValueHeaderValue> result, out System.Net.Http.Headers.Token t); // 0x000000018AE1F724-0x000000018AE1F9D0
		public override string ToString(); // 0x000000018AE1F4F8-0x000000018AE1F52C
		private static bool TryParseElement(Lexer lexer, out NameValueHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018AE1F52C-0x000000018AE1F724
	}

	public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable // TypeDefIndex: 62003
	{
		// Fields
		private List<NameValueHeaderValue> parameters; // 0x20
	
		// Properties
		public ICollection<NameValueHeaderValue> Parameters { get; } // 0x000000018AE20268-0x000000018AE202EC 
	
		// Constructors
		protected NameValueWithParametersHeaderValue(NameValueWithParametersHeaderValue source); // 0x000000018AE20118-0x000000018AE20268
		private NameValueWithParametersHeaderValue(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		new object ICloneable.Clone(); // 0x000000018AE1FD3C-0x000000018AE1FD9C
		public override bool Equals(object obj); // 0x000000018AE1FC58-0x000000018AE1FCE8
		public override int GetHashCode(); // 0x000000018AE1FCE8-0x000000018AE1FD3C
		public override string ToString(); // 0x000000018AE1FD9C-0x000000018AE1FE24
		internal static bool TryParse(string input, int minimalCount, out List<NameValueWithParametersHeaderValue> result); // 0x000000018AE20068-0x000000018AE20118
		private static bool TryParseElement(Lexer lexer, out NameValueWithParametersHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018AE1FE24-0x000000018AE20068
	}

	internal static class Parser // TypeDefIndex: 62015
	{
		// Nested types
		public static class Token // TypeDefIndex: 62004
		{
			// Methods
			public static void Check(string s); // 0x000000018AE2304C-0x000000018AE2315C
			public static bool TryCheck(string s); // 0x000000018AE231AC-0x000000018AE231E4
		}
	
		public static class DateTime // TypeDefIndex: 62006
		{
			// Fields
			public static readonly System.Func<object, string> ToString; // 0x00
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 62005
			{
				// Fields
				public static readonly __c __9; // 0x00
	
				// Constructors
				static __c(); // 0x000000018AE27B44-0x000000018AE27BA8
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal string _.cctor_b__2_0(object l); // 0x000000018AE27724-0x000000018AE277B8
			}
	
			// Constructors
			static DateTime(); // 0x000000018AE150CC-0x000000018AE15190
	
			// Methods
			public static bool TryParse(string input, out DateTimeOffset result); // 0x000000018AE15070-0x000000018AE150CC
		}
	
		public static class EmailAddress // TypeDefIndex: 62007
		{
			// Methods
			public static bool TryParse(string input, out string result); // 0x000000018AE15190-0x000000018AE15280
		}
	
		public static class Host // TypeDefIndex: 62008
		{
			// Methods
			public static bool TryParse(string input, out string result); // 0x000000018AE15AE4-0x000000018AE15B80
		}
	
		public static class Int // TypeDefIndex: 62009
		{
			// Methods
			public static bool TryParse(string input, out int result); // 0x000000018AE1B680-0x000000018AE1B6E0
		}
	
		public static class Long // TypeDefIndex: 62010
		{
			// Methods
			public static bool TryParse(string input, out long result); // 0x000000018AE1C368-0x000000018AE1C3C8
		}
	
		public static class MD5 // TypeDefIndex: 62012
		{
			// Fields
			public static readonly System.Func<object, string> ToString; // 0x00
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 62011
			{
				// Fields
				public static readonly __c __9; // 0x00
	
				// Constructors
				static __c(); // 0x000000018AE27A18-0x000000018AE27A7C
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal string _.cctor_b__2_0(object l); // 0x000000018AE277B8-0x000000018AE27814
			}
	
			// Constructors
			static MD5(); // 0x000000018AE1C4AC-0x000000018AE1C570
	
			// Methods
			public static bool TryParse(string input, out byte[] result); // 0x000000018AE1C3C8-0x000000018AE1C4AC
		}
	
		public static class TimeSpanSeconds // TypeDefIndex: 62013
		{
			// Methods
			public static bool TryParse(string input, out TimeSpan result); // 0x000000018AE22FB8-0x000000018AE2304C
		}
	
		public static class Uri // TypeDefIndex: 62014
		{
			// Methods
			public static bool TryParse(string input, out System.Uri result); // 0x000000018AE27BA8-0x000000018AE27BFC
		}
	}

	public class ProductHeaderValue : ICloneable // TypeDefIndex: 62016
	{
		// Fields
		[CompilerGenerated]
		private string _Name_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Version_k__BackingField; // 0x18
	
		// Properties
		public string Name { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string Version { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		internal ProductHeaderValue(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		object ICloneable.Clone(); // 0x0000000183840500-0x0000000183840510
		public override bool Equals(object obj); // 0x000000018AE203EC-0x000000018AE2046C
		public override int GetHashCode(); // 0x000000018AE2046C-0x000000018AE204D8
		internal static bool TryParse(string input, int minimalCount, out List<ProductHeaderValue> result); // 0x000000018AE2070C-0x000000018AE207BC
		private static bool TryParseElement(Lexer lexer, out ProductHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018AE2052C-0x000000018AE2070C
		public override string ToString(); // 0x000000018AE204D8-0x000000018AE2052C
	}

	public class ProductInfoHeaderValue : ICloneable // TypeDefIndex: 62017
	{
		// Fields
		[CompilerGenerated]
		private string _Comment_k__BackingField; // 0x10
		[CompilerGenerated]
		private ProductHeaderValue _Product_k__BackingField; // 0x18
	
		// Properties
		public string Comment { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public ProductHeaderValue Product { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		public ProductInfoHeaderValue(ProductHeaderValue product); // 0x000000018AE20BF4-0x000000018AE20C58
		private ProductInfoHeaderValue(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		object ICloneable.Clone(); // 0x0000000183840500-0x0000000183840510
		public override bool Equals(object obj); // 0x000000018AE207BC-0x000000018AE20830
		public override int GetHashCode(); // 0x000000018AE20830-0x000000018AE20860
		internal static bool TryParse(string input, int minimalCount, out List<ProductInfoHeaderValue> result); // 0x000000018AE20AA4-0x000000018AE20BF4
		private static bool TryParseElement(Lexer lexer, out ProductInfoHeaderValue parsedValue); // 0x000000018AE20888-0x000000018AE20AA4
		public override string ToString(); // 0x000000018AE20860-0x000000018AE20888
	}

	public class RangeConditionHeaderValue : ICloneable // TypeDefIndex: 62018
	{
		// Fields
		[CompilerGenerated]
		private DateTimeOffset? _Date_k__BackingField; // 0x10
		[CompilerGenerated]
		private EntityTagHeaderValue _EntityTag_k__BackingField; // 0x28
	
		// Properties
		public DateTimeOffset? Date { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001815AD710-0x00000001815AD730 0x0000000184D99830-0x0000000184D99850
		public EntityTagHeaderValue EntityTag { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
	
		// Constructors
		public RangeConditionHeaderValue(DateTimeOffset date); // 0x000000018AE21140-0x000000018AE211A0
		public RangeConditionHeaderValue(EntityTagHeaderValue entityTag); // 0x000000018AE211A0-0x000000018AE21214
	
		// Methods
		object ICloneable.Clone(); // 0x0000000183840500-0x0000000183840510
		public override bool Equals(object obj); // 0x000000018AE20C58-0x000000018AE20D5C
		public override int GetHashCode(); // 0x000000018AE20D5C-0x000000018AE20DC8
		public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue); // 0x000000018AE20EAC-0x000000018AE21140
		public override string ToString(); // 0x000000018AE20DC8-0x000000018AE20EAC
	}

	public class RangeHeaderValue : ICloneable // TypeDefIndex: 62019
	{
		// Fields
		private List<RangeItemHeaderValue> ranges; // 0x10
		private string unit; // 0x18
	
		// Properties
		public ICollection<RangeItemHeaderValue> Ranges { get; } // 0x000000018AE21AEC-0x000000018AE21B70 
		public string Unit { get; } // 0x000000018385B100-0x000000018385B110 
	
		// Constructors
		public RangeHeaderValue(); // 0x000000018AE21AAC-0x000000018AE21AEC
		private RangeHeaderValue(RangeHeaderValue source); // 0x000000018AE21964-0x000000018AE21AAC
	
		// Methods
		object ICloneable.Clone(); // 0x000000018AE21310-0x000000018AE21370
		public override bool Equals(object obj); // 0x000000018AE21214-0x000000018AE212A0
		public override int GetHashCode(); // 0x000000018AE212A0-0x000000018AE21310
		public static bool TryParse(string input, out RangeHeaderValue parsedValue); // 0x000000018AE21494-0x000000018AE21964
		public override string ToString(); // 0x000000018AE21370-0x000000018AE21494
	}

	public class RangeItemHeaderValue : ICloneable // TypeDefIndex: 62020
	{
		// Fields
		[CompilerGenerated]
		private long? _From_k__BackingField; // 0x10
		[CompilerGenerated]
		private long? _To_k__BackingField; // 0x20
	
		// Properties
		public long? From { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2D510-0x0000000182B2D520 0x0000000184D8C980-0x0000000184D8C990
		public long? To { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8C200-0x0000000184D8C210 0x0000000184D8C210-0x0000000184D8C220
	
		// Constructors
		public RangeItemHeaderValue(long? from, long? to); // 0x000000018AE21DBC-0x000000018AE21FAC
	
		// Methods
		object ICloneable.Clone(); // 0x0000000183840500-0x0000000183840510
		public override bool Equals(object obj); // 0x000000018AE21B70-0x000000018AE21C28
		public override int GetHashCode(); // 0x000000018AE21C28-0x000000018AE21C98
		public override string ToString(); // 0x000000018AE21C98-0x000000018AE21DBC
	}

	public class RetryConditionHeaderValue : ICloneable // TypeDefIndex: 62021
	{
		// Fields
		[CompilerGenerated]
		private DateTimeOffset? _Date_k__BackingField; // 0x10
		[CompilerGenerated]
		private TimeSpan? _Delta_k__BackingField; // 0x28
	
		// Properties
		public DateTimeOffset? Date { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001815AD710-0x00000001815AD730 0x0000000184D99830-0x0000000184D99850
		public TimeSpan? Delta { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8FAD0-0x0000000184D8FAE0 0x0000000184D8FAE0-0x0000000184D8FAF0
	
		// Constructors
		public RetryConditionHeaderValue(DateTimeOffset date); // 0x000000018AE225A0-0x000000018AE22600
		public RetryConditionHeaderValue(TimeSpan delta); // 0x000000018AE224C4-0x000000018AE225A0
	
		// Methods
		object ICloneable.Clone(); // 0x0000000183840500-0x0000000183840510
		public override bool Equals(object obj); // 0x000000018AE21FAC-0x000000018AE220FC
		public override int GetHashCode(); // 0x000000018AE220FC-0x000000018AE22180
		public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue); // 0x000000018AE222CC-0x000000018AE224C4
		public override string ToString(); // 0x000000018AE22180-0x000000018AE222CC
	}

	public class StringWithQualityHeaderValue : ICloneable // TypeDefIndex: 62022
	{
		// Fields
		[CompilerGenerated]
		private double? _Quality_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Value_k__BackingField; // 0x20
	
		// Properties
		public double? Quality { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2D510-0x0000000182B2D520 0x0000000184D8C980-0x0000000184D8C990
		public string Value { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
	
		// Constructors
		private StringWithQualityHeaderValue(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		object ICloneable.Clone(); // 0x0000000183840500-0x0000000183840510
		public override bool Equals(object obj); // 0x000000018AE22A1C-0x000000018AE22AEC
		public override int GetHashCode(); // 0x000000018AE22AEC-0x000000018AE22B68
		internal static bool TryParse(string input, int minimalCount, out List<StringWithQualityHeaderValue> result); // 0x000000018AE22F08-0x000000018AE22FB8
		private static bool TryParseElement(Lexer lexer, out StringWithQualityHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018AE22C40-0x000000018AE22F08
		public override string ToString(); // 0x000000018AE22B68-0x000000018AE22C40
	}

	public class TransferCodingHeaderValue : ICloneable // TypeDefIndex: 62023
	{
		// Fields
		internal string value; // 0x10
		internal List<NameValueHeaderValue> parameters; // 0x18
	
		// Properties
		public ICollection<NameValueHeaderValue> Parameters { get; } // 0x000000018AE23910-0x000000018AE23994 
		public string Value { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Constructors
		protected TransferCodingHeaderValue(TransferCodingHeaderValue source); // 0x000000018AE23684-0x000000018AE23910
		internal TransferCodingHeaderValue(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		object ICloneable.Clone(); // 0x000000018AE233A4-0x000000018AE23404
		public override bool Equals(object obj); // 0x000000018AE2329C-0x000000018AE23328
		public override int GetHashCode(); // 0x000000018AE23328-0x000000018AE233A4
		public override string ToString(); // 0x000000018AE23404-0x000000018AE2345C
		internal static bool TryParse(string input, int minimalCount, out List<TransferCodingHeaderValue> result); // 0x000000018AE235D4-0x000000018AE23684
		private static bool TryParseElement(Lexer lexer, out TransferCodingHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018AE2345C-0x000000018AE235D4
	}

	public sealed class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue // TypeDefIndex: 62024
	{
		// Constructors
		private TransferCodingWithQualityHeaderValue(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		internal static bool TryParse(string input, int minimalCount, out List<TransferCodingWithQualityHeaderValue> result); // 0x000000018AE27D74-0x000000018AE27E24
		private static bool TryParseElement(Lexer lexer, out TransferCodingWithQualityHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018AE27BFC-0x000000018AE27D74
	}

	public class ViaHeaderValue : ICloneable // TypeDefIndex: 62025
	{
		// Fields
		[CompilerGenerated]
		private string _Comment_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _ProtocolName_k__BackingField; // 0x18
		[CompilerGenerated]
		private string _ProtocolVersion_k__BackingField; // 0x20
		[CompilerGenerated]
		private string _ReceivedBy_k__BackingField; // 0x28
	
		// Properties
		public string Comment { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string ProtocolName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public string ProtocolVersion { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public string ReceivedBy { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
	
		// Constructors
		private ViaHeaderValue(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		object ICloneable.Clone(); // 0x0000000183840500-0x0000000183840510
		public override bool Equals(object obj); // 0x000000018AE27E24-0x000000018AE27ED4
		public override int GetHashCode(); // 0x000000018AE27ED4-0x000000018AE27F9C
		internal static bool TryParse(string input, int minimalCount, out List<ViaHeaderValue> result); // 0x000000018AE283AC-0x000000018AE2845C
		private static bool TryParseElement(Lexer lexer, out ViaHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018AE280AC-0x000000018AE283AC
		public override string ToString(); // 0x000000018AE27F9C-0x000000018AE280AC
	}

	public class WarningHeaderValue : ICloneable // TypeDefIndex: 62026
	{
		// Fields
		[CompilerGenerated]
		private string _Agent_k__BackingField; // 0x10
		[CompilerGenerated]
		private int _Code_k__BackingField; // 0x18
		[CompilerGenerated]
		private DateTimeOffset? _Date_k__BackingField; // 0x20
		[CompilerGenerated]
		private string _Text_k__BackingField; // 0x38
	
		// Properties
		public string Agent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public int Code { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public DateTimeOffset? Date { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D9E6A0-0x0000000184D9E6C0 0x0000000184DAA340-0x0000000184DAA360
		public string Text { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
	
		// Constructors
		private WarningHeaderValue(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private static bool IsCodeValid(int code); // 0x000000018AE2863C-0x000000018AE28650
		object ICloneable.Clone(); // 0x0000000183840500-0x0000000183840510
		public override bool Equals(object obj); // 0x000000018AE2845C-0x000000018AE28588
		public override int GetHashCode(); // 0x000000018AE28588-0x000000018AE2863C
		internal static bool TryParse(string input, int minimalCount, out List<WarningHeaderValue> result); // 0x000000018AE28B40-0x000000018AE28E1C
		private static bool TryParseElement(Lexer lexer, out WarningHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018AE28834-0x000000018AE28B40
		public override string ToString(); // 0x000000018AE28650-0x000000018AE28834
	}
}
