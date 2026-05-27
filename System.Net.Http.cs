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

// Image 63: System.Net.Http.dll - Assembly: System.Net.Http, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a - Types 58071-58154
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

namespace System.Net.Http
{
	public class HttpClientHandler : HttpMessageHandler // TypeDefIndex: 58073
	{
		// Fields
		private readonly IMonoHttpClientHandler _delegatingHandler; // 0x10
		private ClientCertificateOption _clientCertificateOptions; // 0x18
	
		// Properties
		public ClientCertificateOption ClientCertificateOptions { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x00000001898361FC-0x00000001898363E4
		public X509CertificateCollection ClientCertificates { get => default; } // 0x00000001898360CC-0x00000001898361FC 
	
		// Constructors
		public HttpClientHandler() {} // 0x00000001898360A8-0x00000001898360CC
		internal HttpClientHandler(IMonoHttpClientHandler handler) {} // 0x0000000189836080-0x00000001898360A8
	
		// Methods
		private static IMonoHttpClientHandler CreateDefaultHandler() => default; // 0x0000000189835E50-0x0000000189835EA0
		protected override void Dispose(bool disposing) {} // 0x0000000189835EA0-0x0000000189835EF8
		private void ThrowForModifiedManagedSslOptionsIfStarted() {} // 0x0000000189835FEC-0x0000000189836064
		internal void SetWebRequestTimeout(TimeSpan timeout) {} // 0x0000000189835F7C-0x0000000189835FEC
		protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) => default; // 0x0000000189835EF8-0x0000000189835F7C
	}

	internal interface IMonoHttpClientHandler : IDisposable // TypeDefIndex: 58074
	{
		// Properties
		SslClientAuthenticationOptions SslOptions { get; set; }
	
		// Methods
		Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
		void SetWebRequestTimeout(TimeSpan timeout);
	}

	internal class MonoWebRequestHandler : IMonoHttpClientHandler // TypeDefIndex: 58077
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
		public CookieContainer CookieContainer { get => default; } // 0x000000018983E918-0x000000018983E98C 
		public long MaxRequestContentBufferSize { get => default; } // 0x0000000181003830-0x0000000181003840 
		public SslClientAuthenticationOptions SslOptions { get => default; set {} } // 0x000000018983E98C-0x000000018983E9F0 0x000000018983E9F0-0x000000018983EA20
	
		// Constructors
		public MonoWebRequestHandler() {} // 0x000000018983E7C4-0x000000018983E918
	
		// Methods
		internal void EnsureModifiability() {} // 0x000000018983E3F4-0x000000018983E460
		public void Dispose() {} // 0x000000018983E3E8-0x000000018983E3F4
		protected virtual void Dispose(bool disposing) {} // 0x000000018983E378-0x000000018983E3E8
		private bool GetConnectionKeepAlive(HttpRequestHeaders headers) => default; // 0x000000018983E460-0x000000018983E580
		internal virtual HttpWebRequest CreateWebRequest(HttpRequestMessage request) => default; // 0x000000018983DB58-0x000000018983E378
		private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken) => default; // 0x000000018983D9BC-0x000000018983DB58
		private static bool MethodHasBody(HttpMethod method) => default; // 0x000000018983E580-0x000000018983E660
		public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) => default; // 0x000000018983E660-0x000000018983E76C
		void IMonoHttpClientHandler.SetWebRequestTimeout(TimeSpan timeout) {} // 0x000000018983E76C-0x000000018983E7C4
	}

	internal static class PlatformHelper // TypeDefIndex: 58078
	{
		// Methods
		internal static bool IsContentHeader(string name) => default; // 0x0000000189840AC8-0x0000000189840B10
		internal static string GetSingleHeaderString(string name, IEnumerable<string> values) => default; // 0x0000000189840A6C-0x0000000189840AC8
		internal static StreamContent CreateStreamContent(Stream stream, CancellationToken cancellationToken) => default; // 0x00000001898409FC-0x0000000189840A6C
	}

	public class ByteArrayContent : HttpContent // TypeDefIndex: 58079
	{
		// Fields
		private readonly byte[] content; // 0x28
		private readonly int offset; // 0x30
		private readonly int count; // 0x34
	
		// Constructors
		public ByteArrayContent() {} // Dummy constructor
		public ByteArrayContent(byte[] content) {} // 0x000000018983215C-0x00000001898321DC
	
		// Methods
		protected override System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context) => default; // 0x0000000189832128-0x000000018983215C
		protected internal override bool TryComputeLength(out long length) {
			length = default;
			return default;
		} // 0x0000000183D755A0-0x0000000183D755B0
	}

	public enum ClientCertificateOption // TypeDefIndex: 58080
	{
		Manual = 0,
		Automatic = 1
	}

	public class HttpClient : HttpMessageInvoker // TypeDefIndex: 58082
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
		public HttpRequestHeaders DefaultRequestHeaders { get => default; } // 0x0000000189836B94-0x0000000189836C08 
		public long MaxResponseContentBufferSize { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
	
		// Constructors
		public HttpClient() {} // 0x0000000189836B2C-0x0000000189836B94
		public HttpClient(HttpMessageHandler handler, bool disposeHandler) {} // 0x0000000189836A68-0x0000000189836B2C
		static HttpClient() {} // 0x0000000189836A08-0x0000000189836A68
	
		// Methods
		protected override void Dispose(bool disposing) {} // 0x00000001898363E4-0x0000000189836444
		public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content) => default; // 0x0000000189836444-0x0000000189836534
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) => default; // 0x000000018983664C-0x00000001898366A8
		public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) => default; // 0x00000001898369E0-0x0000000189836A00
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) => default; // 0x00000001898366A8-0x00000001898369E0
		private async Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) => default; // 0x0000000189836534-0x000000018983664C
	}

	public enum HttpCompletionOption // TypeDefIndex: 58083
	{
		ResponseContentRead = 0,
		ResponseHeadersRead = 1
	}

	public abstract class HttpContent : IDisposable // TypeDefIndex: 58087
	{
		// Fields
		private FixedMemoryStream buffer; // 0x10
		private bool disposed; // 0x18
		private HttpContentHeaders headers; // 0x20
	
		// Properties
		public HttpContentHeaders Headers { get; } // 0x00000001898373D0-0x0000000189837448 
		internal long? LoadedBufferLength { get; } // 0x0000000189837448-0x00000001898374C4 
	
		// Nested types
		private sealed class FixedMemoryStream : MemoryStream // TypeDefIndex: 58084
		{
			// Fields
			private readonly long maxSize; // 0x50
	
			// Constructors
			public FixedMemoryStream() {} // Dummy constructor
			public FixedMemoryStream(long maxSize) {} // 0x0000000189835BC8-0x0000000189835BF4
	
			// Methods
			private void CheckOverflow(int count) {} // 0x0000000189835A74-0x0000000189835B34
			public override void WriteByte(byte value) {} // 0x0000000189835B34-0x0000000189835B6C
			public override void Write(byte[] buffer, int offset, int count) {} // 0x0000000189835B6C-0x0000000189835BC8
		}
	
		// Constructors
		protected HttpContent() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public System.Threading.Tasks.Task CopyToAsync(Stream stream) => default; // 0x0000000189836F54-0x0000000189836F60
		public System.Threading.Tasks.Task CopyToAsync(Stream stream, TransportContext context) => default; // 0x0000000189836F60-0x0000000189836FF0
		private static FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize) => default; // 0x0000000189836FF0-0x0000000189837050
		public void Dispose() {} // 0x0000000189837078-0x0000000189837088
		protected virtual void Dispose(bool disposing) {} // 0x0000000189837050-0x0000000189837078
		public System.Threading.Tasks.Task LoadIntoBufferAsync() => default; // 0x0000000189837280-0x0000000189837290
		public async System.Threading.Tasks.Task LoadIntoBufferAsync(long maxBufferSize) => default; // 0x00000001898371B8-0x0000000189837280
		public async Task<string> ReadAsStringAsync() => default; // 0x0000000189837290-0x0000000189837364
		private static Encoding GetEncodingFromBuffer(byte[] buffer, int length, ref int preambleLength) => default; // 0x0000000189837088-0x00000001898371B8
		private static int StartsWith(byte[] array, int length, byte[] value) => default; // 0x0000000189837374-0x00000001898373D0
		internal System.Threading.Tasks.Task SerializeToStreamAsync_internal(Stream stream, TransportContext context) => default; // 0x0000000189837364-0x0000000189837374
		protected abstract System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context);
		protected internal abstract bool TryComputeLength(out long length);
	}

	public abstract class HttpMessageHandler : IDisposable // TypeDefIndex: 58088
	{
		// Constructors
		protected HttpMessageHandler() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Dispose() {} // 0x0000000189837078-0x0000000189837088
		protected virtual void Dispose(bool disposing) {} // 0x000000018350B670-0x000000018350B680
		protected internal abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
	}

	public class HttpMessageInvoker : IDisposable // TypeDefIndex: 58089
	{
		// Fields
		private protected HttpMessageHandler handler; // 0x10
		private readonly bool disposeHandler; // 0x18
	
		// Constructors
		public HttpMessageInvoker() {} // Dummy constructor
		public HttpMessageInvoker(HttpMessageHandler handler, bool disposeHandler) {} // 0x000000018983A3B4-0x000000018983A430
	
		// Methods
		public void Dispose() {} // 0x0000000189837078-0x0000000189837088
		protected virtual void Dispose(bool disposing) {} // 0x000000018983A324-0x000000018983A35C
		public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) => default; // 0x000000018983A35C-0x000000018983A3B4
	}

	public class HttpMethod : IEquatable<HttpMethod> // TypeDefIndex: 58090
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
		public string Method { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public static HttpMethod Post { get => default; } // 0x000000018983A808-0x000000018983A858 
	
		// Constructors
		public HttpMethod() {} // Dummy constructor
		public HttpMethod(string method) {} // 0x000000018983A778-0x000000018983A808
		static HttpMethod() {} // 0x000000018983A4B8-0x000000018983A778
	
		// Methods
		public static bool operator ==(HttpMethod left, HttpMethod right) => default; // 0x000000018983A858-0x000000018983A874
		public bool Equals(HttpMethod other) => default; // 0x000000018983A430-0x000000018983A45C
		public override bool Equals(object obj) => default; // 0x000000018983A45C-0x000000018983A4B8
		public override int GetHashCode() => default; // 0x0000000186FAB9A8-0x0000000186FAB9CC
		public override string ToString() => default; // 0x00000001820B7B20-0x00000001820B7B30
	}

	[Serializable]
	public class HttpRequestException : Exception // TypeDefIndex: 58091
	{
		// Constructors
		public HttpRequestException() {} // 0x000000018983A874-0x000000018983A8C0
		public HttpRequestException(string message) {} // 0x000000018983A8C0-0x000000018983A91C
		public HttpRequestException(string message, Exception inner) {} // 0x000000018983A91C-0x000000018983A97C
	}

	public class HttpRequestMessage : IDisposable // TypeDefIndex: 58092
	{
		// Fields
		private HttpRequestHeaders headers; // 0x10
		private HttpMethod method; // 0x18
		private System.Version version; // 0x20
		private System.Uri uri; // 0x28
		private bool is_used; // 0x30
		private bool disposed; // 0x31
	
		// Properties
		public HttpContent Content { get; set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public HttpRequestHeaders Headers { get => default; } // 0x000000018983B67C-0x000000018983B6F0 
		public HttpMethod Method { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x000000018983B744-0x000000018983B7EC
		public System.Uri RequestUri { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x000000018983B7EC-0x000000018983B8AC
		public System.Version Version { get => default; } // 0x000000018983B6F0-0x000000018983B744 
	
		// Constructors
		public HttpRequestMessage() {} // Dummy constructor
		public HttpRequestMessage(HttpMethod method, string requestUri) {} // 0x000000018983B5B4-0x000000018983B64C
		public HttpRequestMessage(HttpMethod method, System.Uri requestUri) {} // 0x000000018983B64C-0x000000018983B67C
	
		// Methods
		private static bool IsAllowedAbsoluteUri(System.Uri uri) => default; // 0x000000018983B228-0x000000018983B358
		public void Dispose() {} // 0x000000018983B1F0-0x000000018983B1FC
		protected virtual void Dispose(bool disposing) {} // 0x000000018983B1FC-0x000000018983B228
		internal bool SetIsUsed() => default; // 0x000000018983B358-0x000000018983B368
		public override string ToString() => default; // 0x000000018983B368-0x000000018983B5B4
	}

	public class HttpResponseMessage : IDisposable // TypeDefIndex: 58093
	{
		// Fields
		private HttpResponseHeaders headers; // 0x10
		private string reasonPhrase; // 0x18
		private HttpStatusCode statusCode; // 0x20
		private System.Version version; // 0x28
		private bool disposed; // 0x30
	
		// Properties
		public HttpContent Content { get; set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public HttpResponseHeaders Headers { get => default; } // 0x000000018983BB54-0x000000018983BBC8 
		public string ReasonPhrase { get => default; set {} } // 0x000000018983BBC8-0x000000018983BBDC 0x00000001822C3A90-0x00000001822C3AA0
		public HttpRequestMessage RequestMessage { get; set; } // 0x0000000183CB2D80-0x0000000183CB2D90
		public HttpStatusCode StatusCode { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x000000018983BC30-0x000000018983BC88
		public System.Version Version { get => default; } // 0x000000018983BBDC-0x000000018983BC30 
	
		// Constructors
		public HttpResponseMessage() {} // Dummy constructor
		public HttpResponseMessage(HttpStatusCode statusCode) {} // 0x000000018983BB4C-0x000000018983BB54
	
		// Methods
		public void Dispose() {} // 0x000000018983B900-0x000000018983B90C
		protected virtual void Dispose(bool disposing) {} // 0x000000018983B90C-0x000000018983B938
		public override string ToString() => default; // 0x000000018983B938-0x000000018983BB4C
	}

	public class MultipartContent : HttpContent, IEnumerable<HttpContent> // TypeDefIndex: 58095
	{
		// Fields
		private List<HttpContent> nested_content; // 0x28
		private readonly string boundary; // 0x30
	
		// Constructors
		public MultipartContent() {} // Dummy constructor
		public MultipartContent(string subtype) {} // 0x000000018983F30C-0x000000018983F3A8
		public MultipartContent(string subtype, string boundary) {} // 0x000000018983F3A8-0x000000018983F708
	
		// Methods
		private static bool IsValidRFC2049(string s) => default; // 0x000000018983ED48-0x000000018983EE00
		public virtual void Add(HttpContent content) {} // 0x000000018983EA20-0x000000018983EB20
		protected override void Dispose(bool disposing) {} // 0x000000018983EB20-0x000000018983ECC8
		protected override async System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context) => default; // 0x000000018983EE00-0x000000018983EEEC
		protected internal override bool TryComputeLength(out long length) {
			length = default;
			return default;
		} // 0x000000018983EF6C-0x000000018983F30C
		public IEnumerator<HttpContent> GetEnumerator() => default; // 0x000000018983ECC8-0x000000018983ED48
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018983EEEC-0x000000018983EF6C
	}

	public class MultipartFormDataContent : MultipartContent // TypeDefIndex: 58096
	{
		// Constructors
		public MultipartFormDataContent() {} // 0x000000018983F9F8-0x000000018983FA34
	
		// Methods
		public override void Add(HttpContent content) {} // 0x000000018983F9B8-0x000000018983F9F8
		public void Add(HttpContent content, string name) {} // 0x000000018983F7F4-0x000000018983F8A0
		public void Add(HttpContent content, string name, string fileName) {} // 0x000000018983F8A0-0x000000018983F9B8
		private void AddContentDisposition(HttpContent content, string name, string fileName) {} // 0x000000018983F708-0x000000018983F7F4
	}

	public class StreamContent : HttpContent // TypeDefIndex: 58097
	{
		// Fields
		private readonly Stream content; // 0x28
		private readonly int bufferSize; // 0x30
		private readonly CancellationToken cancellationToken; // 0x38
		private readonly long startPosition; // 0x40
		private bool contentCopied; // 0x48
	
		// Constructors
		public StreamContent() {} // Dummy constructor
		public StreamContent(Stream content) {} // 0x0000000189842FA0-0x0000000189842FB0
		public StreamContent(Stream content, int bufferSize) {} // 0x0000000189842E9C-0x0000000189842FA0
		internal StreamContent(Stream content, CancellationToken cancellationToken) {} // 0x0000000189842FB0-0x0000000189842FE8
	
		// Methods
		protected override void Dispose(bool disposing) {} // 0x0000000189842D24-0x0000000189842D6C
		protected override System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context) => default; // 0x0000000189842D6C-0x0000000189842E40
		protected internal override bool TryComputeLength(out long length) {
			length = default;
			return default;
		} // 0x0000000189842E40-0x0000000189842E9C
	}

	public class StringContent : ByteArrayContent // TypeDefIndex: 58098
	{
		// Constructors
		public StringContent() {} // Dummy constructor
		public StringContent(string content) {} // 0x0000000189843020-0x0000000189843040
		public StringContent(string content, Encoding encoding, string mediaType) {} // 0x0000000189843040-0x0000000189843140
	
		// Methods
		private static byte[] GetByteArray(string content, Encoding encoding) => default; // 0x0000000189842FE8-0x0000000189843020
	}
}

namespace System.Net.Http.Headers
{
	public class AuthenticationHeaderValue : ICloneable // TypeDefIndex: 58099
	{
		// Properties
		public string Parameter { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string Scheme { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public AuthenticationHeaderValue(string scheme, string parameter) {} // 0x00000001898320DC-0x0000000189832128
		private AuthenticationHeaderValue() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000182A48500-0x0000000182A48510
		public override bool Equals(object obj) => default; // 0x0000000189831C84-0x0000000189831D00
		public override int GetHashCode() => default; // 0x0000000189831D00-0x0000000189831D74
		public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x0000000189831F70-0x000000018983202C
		internal static bool TryParse(string input, int minimalCount, out List<AuthenticationHeaderValue> result) {
			result = default;
			return default;
		} // 0x000000018983202C-0x00000001898320DC
		private static bool TryParseElement(Lexer lexer, out AuthenticationHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x0000000189831DC0-0x0000000189831F70
		public override string ToString() => default; // 0x0000000189831D74-0x0000000189831DC0
	}

	public class CacheControlHeaderValue : ICloneable // TypeDefIndex: 58100
	{
		// Fields
		private List<NameValueHeaderValue> extensions; // 0x10
		private List<string> no_cache_headers; // 0x18
		private List<string> private_headers; // 0x20
	
		// Properties
		public ICollection<NameValueHeaderValue> Extensions { get => default; } // 0x00000001898339B4-0x0000000189833A38 
		public TimeSpan? MaxAge { get; set; } // 0x0000000183D59E20-0x0000000183D59E30 0x0000000183D59E30-0x0000000183D59E40
		public bool MaxStale { get; set; } // 0x0000000183D4F190-0x0000000183D4F1A0 0x0000000183D4E280-0x0000000183D4E290
		public TimeSpan? MaxStaleLimit { get; set; } // 0x0000000183D5A160-0x0000000183D5A170 0x0000000183D5D610-0x0000000183D5D620
		public TimeSpan? MinFresh { get; set; } // 0x0000000183D55950-0x0000000183D55960 0x0000000183D5A610-0x0000000183D5A620
		public bool MustRevalidate { get; set; } // 0x0000000183D519A0-0x0000000183D519B0 0x0000000183D519B0-0x0000000183D519C0
		public bool NoCache { get; set; } // 0x0000000183D51F90-0x0000000183D51FA0 0x0000000183D5B410-0x0000000183D5B420
		public ICollection<string> NoCacheHeaders { get => default; } // 0x0000000189833A38-0x0000000189833ABC 
		public bool NoStore { get; set; } // 0x0000000183D5B400-0x0000000183D5B410 0x0000000183D5B420-0x0000000183D5B430
		public bool NoTransform { get; set; } // 0x0000000183D5B3F0-0x0000000183D5B400 0x0000000183D755C0-0x0000000183D755D0
		public bool OnlyIfCached { get; set; } // 0x0000000183D590F0-0x0000000183D59100 0x0000000183D59100-0x0000000183D59110
		public bool Private { get; set; } // 0x0000000183D5CA70-0x0000000183D5CA80 0x0000000183D6CF00-0x0000000183D6CF10
		public ICollection<string> PrivateHeaders { get => default; } // 0x0000000189833ABC-0x0000000189833B40 
		public bool ProxyRevalidate { get; set; } // 0x0000000183D5CAA0-0x0000000183D5CAB0 0x0000000183D5CAB0-0x0000000183D5CAC0
		public bool Public { get; set; } // 0x0000000183D755B0-0x0000000183D755C0 0x0000000183D755D0-0x0000000183D755E0
		public TimeSpan? SharedMaxAge { get; set; } // 0x0000000183D5D750-0x0000000183D5D760 0x0000000183D71AD0-0x0000000183D71AE0
	
		// Constructors
		public CacheControlHeaderValue() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000189832644-0x0000000189832B78
		public override bool Equals(object obj) => default; // 0x00000001898321DC-0x0000000189832420
		public override int GetHashCode() => default; // 0x0000000189832420-0x0000000189832644
		public static bool TryParse(string input, out CacheControlHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x00000001898331BC-0x00000001898339B4
		public override string ToString() => default; // 0x0000000189832B78-0x00000001898331BC
	}

	internal static class CollectionExtensions // TypeDefIndex: 58101
	{
		// Extension methods
		public static bool SequenceEqual<TSource>(this List<TSource> first, List<TSource> second) => default;
		public static void SetValue(this List<NameValueHeaderValue> parameters, string key, string value) {} // 0x0000000189833B40-0x0000000189833C88
		public static string ToString<T>(this List<T> list) => default;
		public static void ToStringBuilder<T>(this List<T> list, StringBuilder sb) {}
	}

	internal delegate bool ElementTryParser<T>(Lexer lexer, out ref T parsedValue, out System.Net.Http.Headers.Token token); // TypeDefIndex: 58102; 0x00000000-0x00000000

	internal static class CollectionParser // TypeDefIndex: 58103
	{
		// Methods
		public static bool TryParse<T>(string input, int minimalCount, ElementTryParser<T> parser, out List<T> result)
			where T : class {
			result = default;
			return default;
		}
		public static bool TryParse(string input, int minimalCount, out List<string> result) {
			result = default;
			return default;
		} // 0x0000000189833D90-0x0000000189833E40
		private static bool TryParseStringElement(Lexer lexer, out string parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x0000000189833C88-0x0000000189833D90
	}

	public class ContentDispositionHeaderValue : ICloneable // TypeDefIndex: 58104
	{
		// Fields
		private string dispositionType; // 0x10
		private List<NameValueHeaderValue> parameters; // 0x18
	
		// Properties
		public string DispositionType { set {} } // 0x0000000189834944-0x0000000189834978
		public string FileName { set {} } // 0x00000001898349D8-0x0000000189834A38
		public string FileNameStar { set {} } // 0x0000000189834978-0x00000001898349D8
		public string Name { set {} } // 0x0000000189834A38-0x0000000189834A98
		public ICollection<NameValueHeaderValue> Parameters { get => default; } // 0x00000001898348C0-0x0000000189834944 
	
		// Constructors
		private ContentDispositionHeaderValue() {} // 0x000000018350B670-0x000000018350B680
		public ContentDispositionHeaderValue(string dispositionType) {} // 0x00000001898348B8-0x00000001898348C0
		protected ContentDispositionHeaderValue(ContentDispositionHeaderValue source) {} // 0x00000001898345DC-0x00000001898348B8
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000189834398-0x00000001898343F8
		public override bool Equals(object obj) => default; // 0x00000001898341F4-0x0000000189834280
		private static string EncodeBase64Value(string value) => default; // 0x0000000189833E40-0x0000000189833FCC
		private static string EncodeRFC5987(string value) => default; // 0x0000000189833FCC-0x00000001898341F4
		public override int GetHashCode() => default; // 0x0000000189834280-0x00000001898342F0
		private void SetValue(string key, string value) {} // 0x00000001898342F0-0x0000000189834398
		public override string ToString() => default; // 0x00000001898343F8-0x0000000189834450
		public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x0000000189834450-0x00000001898345DC
	}

	public class ContentRangeHeaderValue : ICloneable // TypeDefIndex: 58105
	{
		// Fields
		private string unit; // 0x10
	
		// Properties
		public long? From { get; private set; } // 0x0000000183D51D80-0x0000000183D51D90 0x0000000183D51D90-0x0000000183D51DA0
		public long? Length { get; private set; } // 0x0000000183D59E20-0x0000000183D59E30 0x0000000183D59E30-0x0000000183D59E40
		public long? To { get; private set; } // 0x0000000183D5A120-0x0000000183D5A130 0x0000000183D5C3C0-0x0000000183D5C3D0
		public string Unit { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		private ContentRangeHeaderValue() {} // 0x00000001898352AC-0x00000001898352EC
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000182A48500-0x0000000182A48510
		public override bool Equals(object obj) => default; // 0x0000000189834A98-0x0000000189834B74
		public override int GetHashCode() => default; // 0x0000000189834B74-0x0000000189834C6C
		public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x0000000189834E7C-0x00000001898352AC
		public override string ToString() => default; // 0x0000000189834C6C-0x0000000189834E7C
	}

	public class EntityTagHeaderValue : ICloneable // TypeDefIndex: 58106
	{
		// Fields
		private static readonly EntityTagHeaderValue any; // 0x00
	
		// Properties
		public bool IsWeak { get; internal set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
		public string Tag { get; internal set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		internal EntityTagHeaderValue() {} // 0x000000018350B670-0x000000018350B680
		static EntityTagHeaderValue() {} // 0x00000001898359F0-0x0000000189835A74
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000182A48500-0x0000000182A48510
		public override bool Equals(object obj) => default; // 0x00000001898354FC-0x0000000189835578
		public override int GetHashCode() => default; // 0x0000000189835578-0x00000001898355E8
		public static bool TryParse(string input, out EntityTagHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x000000018983586C-0x0000000189835940
		private static bool TryParseElement(Lexer lexer, out EntityTagHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x0000000189835630-0x000000018983586C
		internal static bool TryParse(string input, int minimalCount, out List<EntityTagHeaderValue> result) {
			result = default;
			return default;
		} // 0x0000000189835940-0x00000001898359F0
		public override string ToString() => default; // 0x00000001898355E8-0x0000000189835630
	}

	internal static class HashCodeCalculator // TypeDefIndex: 58107
	{
		// Methods
		public static int Calculate<T>(ICollection<T> list) => default;
	}

	internal delegate bool TryParseDelegate<T>(string value, out ref T result); // TypeDefIndex: 58108; 0x00000000-0x00000000

	internal delegate bool TryParseListDelegate<T>(string value, int minimalCount, out List<T> result); // TypeDefIndex: 58109; 0x00000000-0x00000000

	internal abstract class HeaderInfo // TypeDefIndex: 58112
	{
		// Fields
		public bool AllowsMany; // 0x10
		public readonly HttpHeaderKind HeaderKind; // 0x14
		public readonly string Name; // 0x18
	
		// Properties
		public System.Func<object, string> CustomToString { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public virtual string Separator { get; } // 0x0000000189835D68-0x0000000189835DB4 
	
		// Nested types
		private class HeaderTypeInfo<T, U> : HeaderInfo // TypeDefIndex: 58110
			where U : class
		{
			// Fields
			private readonly TryParseDelegate<T> parser;
	
			// Constructors
			public HeaderTypeInfo() {} // Dummy constructor
			public HeaderTypeInfo(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind) {}
	
			// Methods
			public override void AddToCollection(object collection, object value) {}
			protected override object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo) => default;
			public override List<string> ToStringCollection(object collection) => default;
			public override bool TryParse(string value, out object result) {
				result = default;
				return default;
			}
		}
	
		private class CollectionHeaderTypeInfo<T, U> : HeaderTypeInfo<T, U> // TypeDefIndex: 58111
			where U : class
		{
			// Fields
			private readonly int minimalCount;
			private readonly string separator;
			private readonly TryParseListDelegate<T> parser;
	
			// Properties
			public override string Separator { get => default; }
	
			// Constructors
			public CollectionHeaderTypeInfo() {} // Dummy constructor
			public CollectionHeaderTypeInfo(string name, TryParseListDelegate<T> parser, HttpHeaderKind headerKind, int minimalCount, string separator) {}
	
			// Methods
			public override bool TryParse(string value, out object result) {
				result = default;
				return default;
			}
		}
	
		// Constructors
		protected HeaderInfo() {} // Dummy constructor
		protected HeaderInfo(string name, HttpHeaderKind headerKind) {} // 0x0000000189835D48-0x0000000189835D68
	
		// Methods
		public static HeaderInfo CreateSingle<T>(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind, System.Func<object, string> toString = null) => default;
		public static HeaderInfo CreateMulti<T>(string name, TryParseListDelegate<T> elementParser, HttpHeaderKind headerKind, int minimalCount = 1 /* Metadata: 0x01FDABB5 */, string separator = ", " /* Metadata: 0x01FDABB6 */)
			where T : class => default;
		public object CreateCollection(HttpHeaders headers) => default; // 0x0000000189835D08-0x0000000189835D48
		public abstract void AddToCollection(object collection, object value);
		protected abstract object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo);
		public abstract List<string> ToStringCollection(object collection);
		public abstract bool TryParse(string value, out object result);
	}

	public sealed class HttpContentHeaders : HttpHeaders // TypeDefIndex: 58113
	{
		// Fields
		private readonly HttpContent content; // 0x20
	
		// Properties
		public ContentDispositionHeaderValue ContentDisposition { get => default; set {} } // 0x0000000189836C68-0x0000000189836CB4 0x0000000189836E24-0x0000000189836E88
		public long? ContentLength { get => default; set {} } // 0x0000000189836CB4-0x0000000189836DD8 0x0000000189836E88-0x0000000189836EF0
		public MediaTypeHeaderValue ContentType { get => default; set {} } // 0x0000000189836DD8-0x0000000189836E24 0x0000000189836EF0-0x0000000189836F54
	
		// Constructors
		public HttpContentHeaders() {} // Dummy constructor
		internal HttpContentHeaders(HttpContent content) {} // 0x0000000189836C08-0x0000000189836C68
	}

	[Flags]
	internal enum HttpHeaderKind // TypeDefIndex: 58114
	{
		None = 0,
		Request = 1,
		Response = 2,
		Content = 4
	}

	public sealed class HttpHeaderValueCollection<T> : ICollection<T> // TypeDefIndex: 58115
		where T : class
	{
		// Fields
		private readonly List<T> list;
		private readonly HttpHeaders headers;
		private readonly System.Net.Http.Headers.HeaderInfo headerInfo;
		private List<string> invalidValues;
	
		// Properties
		public int Count { get => default; }
		internal List<string> InvalidValues { get => default; }
		public bool IsReadOnly { get => default; }
	
		// Constructors
		public HttpHeaderValueCollection() {} // Dummy constructor
		internal HttpHeaderValueCollection(HttpHeaders headers, System.Net.Http.Headers.HeaderInfo headerInfo) {}
	
		// Methods
		public void Add(T item) {}
		internal void AddRange(List<T> values) {}
		internal void AddInvalidValue(string invalidValue) {}
		public void Clear() {}
		public bool Contains(T item) => default;
		public void CopyTo(T[] array, int arrayIndex) {}
		public bool Remove(T item) => default;
		public override string ToString() => default;
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		internal T Find(Predicate<T> predicate) => default;
	}

	public abstract class HttpHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>> // TypeDefIndex: 58118
	{
		// Fields
		private static readonly Dictionary<string, System.Net.Http.Headers.HeaderInfo> known_headers; // 0x00
		private readonly Dictionary<string, HeaderBucket> headers; // 0x10
		private readonly HttpHeaderKind HeaderKind; // 0x18
		internal bool? connectionclose; // 0x1C
		internal bool? transferEncodingChunked; // 0x1E
	
		// Nested types
		private class HeaderBucket // TypeDefIndex: 58116
		{
			// Fields
			public object Parsed; // 0x10
			private List<string> values; // 0x18
			public readonly System.Func<object, string> CustomToString; // 0x20
	
			// Properties
			public bool HasStringValues { get => default; } // 0x0000000189835C40-0x0000000189835C84 
			public List<string> Values { get => default; set {} } // 0x0000000189835C84-0x0000000189835D08 0x00000001822C3A90-0x00000001822C3AA0
	
			// Constructors
			public HeaderBucket() {} // Dummy constructor
			public HeaderBucket(object parsed, System.Func<object, string> converter) {} // 0x0000000182CC1260-0x0000000182CC1290
	
			// Methods
			public string ParsedToString() => default; // 0x0000000189835BF4-0x0000000189835C40
		}
	
		// Constructors
		static HttpHeaders() {} // 0x0000000189838650-0x000000018983A25C
		protected HttpHeaders() {} // 0x000000018983A280-0x000000018983A324
		internal HttpHeaders(HttpHeaderKind headerKind) {} // 0x000000018983A25C-0x000000018983A280
	
		// Methods
		private bool AddInternal(string name, IEnumerable<string> values, System.Net.Http.Headers.HeaderInfo headerInfo, bool ignoreInvalid) => default; // 0x00000001898374C4-0x0000000189837AAC
		public bool TryAddWithoutValidation(string name, IEnumerable<string> values) => default; // 0x00000001898384BC-0x0000000189838578
		private System.Net.Http.Headers.HeaderInfo CheckName(string name) => default; // 0x0000000189837AAC-0x0000000189837C14
		private bool TryCheckName(string name, out System.Net.Http.Headers.HeaderInfo headerInfo) {
			headerInfo = default;
			return default;
		} // 0x0000000189838578-0x0000000189838650
		[IteratorStateMachine(typeof(_GetEnumerator_d__19))]
		public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator() => default; // 0x0000000189837D74-0x0000000189837DD0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189838288-0x0000000189838290
		public bool Remove(string name) => default; // 0x0000000189838224-0x0000000189838288
		internal static string GetSingleHeaderString(string key, IEnumerable<string> values) => default; // 0x0000000189837EB8-0x0000000189838224
		public override string ToString() => default; // 0x0000000189838290-0x00000001898384BC
		internal void AddOrRemove<T>(string name, T value, System.Func<object, string> converter = null)
			where T : class {}
		internal void AddOrRemove<T>(string name, T? value)
			where T : struct {}
		internal void AddOrRemove<T>(string name, T? value, System.Func<object, string> converter)
			where T : struct {}
		private List<string> GetAllHeaderValues(HeaderBucket bucket, System.Net.Http.Headers.HeaderInfo headerInfo) => default; // 0x0000000189837C14-0x0000000189837D74
		internal static HttpHeaderKind GetKnownHeaderKind(string name) => default; // 0x0000000189837DD0-0x0000000189837EB8
		internal T GetValue<T>(string name) => default;
		internal HttpHeaderValueCollection<T> GetValues<T>(string name)
			where T : class => default;
		internal void SetValue<T>(string name, T value, System.Func<object, string> toStringConverter = null) {}
	}

	public sealed class HttpRequestHeaders : HttpHeaders // TypeDefIndex: 58120
	{
		// Fields
		private bool? expectContinue; // 0x20
	
		// Properties
		public AuthenticationHeaderValue Authorization { set {} } // 0x000000018983B0A8-0x000000018983B10C
		public HttpHeaderValueCollection<string> Connection { get => default; } // 0x000000018983ACFC-0x000000018983AD48 
		public bool? ConnectionClose { get => default; set {} } // 0x000000018983AB84-0x000000018983ACFC 0x000000018983B10C-0x000000018983B1F0
		public bool? ExpectContinue { get => default; } // 0x000000018983AD48-0x000000018983AEAC 
		public string Host { get => default; } // 0x000000018983AEAC-0x000000018983AEF8 
		public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding { get => default; } // 0x000000018983B05C-0x000000018983B0A8 
		public bool? TransferEncodingChunked { get => default; } // 0x000000018983AEF8-0x000000018983B05C 
	
		// Constructors
		internal HttpRequestHeaders() {} // 0x000000018983AB30-0x000000018983AB84
	
		// Methods
		internal void AddHeaders(HttpRequestHeaders headers) {} // 0x000000018983A97C-0x000000018983AB30
	}

	public sealed class HttpResponseHeaders : HttpHeaders // TypeDefIndex: 58121
	{
		// Constructors
		internal HttpResponseHeaders() {} // 0x000000018983B8AC-0x000000018983B900
	}

	internal struct Token // TypeDefIndex: 58123
	{
		// Fields
		public static readonly Token Empty; // 0x00
		private readonly Type type; // 0x00
	
		// Properties
		public int StartPosition { [IsReadOnly] get; private set; } // 0x0000000183D4E990-0x0000000183D4E9A0 0x0000000183D51720-0x0000000183D51730
		public int EndPosition { [IsReadOnly] get; private set; } // 0x0000000183D516F0-0x0000000183D51700 0x0000000183D51710-0x0000000183D51720
		public Type Kind { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
	
		// Nested types
		public enum Type // TypeDefIndex: 58122
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
		public Token(Type type, int startPosition, int endPosition) : this() {
			this.type = default;
		} // 0x00000001898439A4-0x0000000189843A10
		static Token() {
			Empty = default;
		} // 0x000000018984393C-0x00000001898439A4
	
		// Methods
		public static implicit operator Type(Token token) => default; // 0x0000000183D4E980-0x0000000183D4E990
		public override string ToString() => default; // 0x000000018984389C-0x00000001898438EC
	}

	internal class Lexer // TypeDefIndex: 58124
	{
		// Fields
		private static readonly bool[] token_chars; // 0x00
		private static readonly int last_token_char; // 0x08
		private static readonly string[] dt_formats; // 0x10
		private readonly string s; // 0x10
		private int pos; // 0x18
	
		// Properties
		public int Position { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
	
		// Constructors
		public Lexer() {} // Dummy constructor
		public Lexer(string stream) {} // 0x000000018426FEE0-0x000000018426FEF0
		static Lexer() {} // 0x000000018983C81C-0x000000018983C9C4
	
		// Methods
		public string GetStringValue(System.Net.Http.Headers.Token token) => default; // 0x000000018983BDFC-0x000000018983BE64
		public string GetStringValue(System.Net.Http.Headers.Token start, System.Net.Http.Headers.Token end) => default; // 0x000000018983BD88-0x000000018983BDFC
		public string GetQuotedStringValue(System.Net.Http.Headers.Token start) => default; // 0x000000018983BCE8-0x000000018983BD58
		public string GetRemainingStringValue(int position) => default; // 0x000000018983BD58-0x000000018983BD88
		public bool IsStarStringValue(System.Net.Http.Headers.Token token) => default; // 0x000000018983BE64-0x000000018983BEE8
		public bool TryGetNumericValue(System.Net.Http.Headers.Token token, out int value) {
			value = default;
			return default;
		} // 0x000000018983C630-0x000000018983C6C4
		public bool TryGetNumericValue(System.Net.Http.Headers.Token token, out long value) {
			value = default;
			return default;
		} // 0x000000018983C6C4-0x000000018983C758
		public TimeSpan? TryGetTimeSpanValue(System.Net.Http.Headers.Token token) => default; // 0x000000018983C758-0x000000018983C81C
		public bool TryGetDateValue(System.Net.Http.Headers.Token token, out DateTimeOffset value) {
			value = default;
			return default;
		} // 0x000000018983C400-0x000000018983C4D8
		public static bool TryGetDateValue(string text, out DateTimeOffset value) {
			value = default;
			return default;
		} // 0x000000018983C4D8-0x000000018983C59C
		public bool TryGetDoubleValue(System.Net.Http.Headers.Token token, out double value) {
			value = default;
			return default;
		} // 0x000000018983C59C-0x000000018983C630
		public static bool IsValidToken(string input) => default; // 0x000000018983BF6C-0x000000018983BFF4
		public static bool IsValidCharacter(char input) => default; // 0x000000018983BEE8-0x000000018983BF6C
		public void EatChar() {} // 0x0000000183D68050-0x0000000183D68060
		public int PeekChar() => default; // 0x000000018983BFF4-0x000000018983C028
		public bool ScanCommentOptional(out string value, out System.Net.Http.Headers.Token readToken) {
			value = default;
			readToken = default;
			return default;
		} // 0x000000018983C028-0x000000018983C150
		public System.Net.Http.Headers.Token Scan(bool recognizeDash = false /* Metadata: 0x01FDABC7 */) => default; // 0x000000018983C150-0x000000018983C400
	}

	public class MediaTypeHeaderValue : ICloneable // TypeDefIndex: 58126
	{
		// Fields
		internal List<NameValueHeaderValue> parameters; // 0x10
		internal string media_type; // 0x18
	
		// Properties
		public string CharSet { get => default; set {} } // 0x000000018983D3B8-0x000000018983D4DC 0x000000018983D560-0x000000018983D60C
		public string MediaType { set {} } // 0x000000018983D60C-0x000000018983D798
		public ICollection<NameValueHeaderValue> Parameters { get => default; } // 0x000000018983D4DC-0x000000018983D560 
	
		// Constructors
		public MediaTypeHeaderValue(string mediaType) {} // 0x000000018983D3B0-0x000000018983D3B8
		protected MediaTypeHeaderValue(MediaTypeHeaderValue source) {} // 0x000000018983D0D4-0x000000018983D3B0
		internal MediaTypeHeaderValue() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		object ICloneable.Clone() => default; // 0x000000018983CCC8-0x000000018983CD28
		public override bool Equals(object obj) => default; // 0x000000018983CBCC-0x000000018983CC58
		public override int GetHashCode() => default; // 0x000000018983CC58-0x000000018983CCC8
		public override string ToString() => default; // 0x000000018983CD28-0x000000018983CD8C
		public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x000000018983CF58-0x000000018983D0D4
		internal static System.Net.Http.Headers.Token? TryParseMediaType(Lexer lexer, out string media) {
			media = default;
			return default;
		} // 0x000000018983CD8C-0x000000018983CF58
	}

	public sealed class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue // TypeDefIndex: 58127
	{
		// Constructors
		private MediaTypeWithQualityHeaderValue() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private static bool TryParseElement(Lexer lexer, out MediaTypeWithQualityHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x000000018983D798-0x000000018983D90C
		internal static bool TryParse(string input, int minimalCount, out List<MediaTypeWithQualityHeaderValue> result) {
			result = default;
			return default;
		} // 0x000000018983D90C-0x000000018983D9BC
	}

	public class NameValueHeaderValue : ICloneable // TypeDefIndex: 58128
	{
		// Fields
		internal string value; // 0x10
	
		// Properties
		public string Name { get; internal set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public string Value { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x00000001898401F0-0x0000000189840368
	
		// Constructors
		public NameValueHeaderValue(string name, string value) {} // 0x00000001898401A4-0x00000001898401F0
		protected internal NameValueHeaderValue(NameValueHeaderValue source) {} // 0x0000000189840168-0x00000001898401A4
		internal NameValueHeaderValue() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal static NameValueHeaderValue Create(string name, string value) => default; // 0x000000018983FA34-0x000000018983FAA4
		object ICloneable.Clone() => default; // 0x000000018983FB50-0x000000018983FBB0
		public override int GetHashCode() => default; // 0x0000000189831D00-0x0000000189831D74
		public override bool Equals(object obj) => default; // 0x000000018983FAA4-0x000000018983FB50
		internal static bool TryParsePragma(string input, int minimalCount, out List<NameValueHeaderValue> result) {
			result = default;
			return default;
		} // 0x00000001898400B8-0x0000000189840168
		internal static bool TryParseParameters(Lexer lexer, out List<NameValueHeaderValue> result, out System.Net.Http.Headers.Token t) {
			result = default;
			t = default;
			return default;
		} // 0x000000018983FE0C-0x00000001898400B8
		public override string ToString() => default; // 0x000000018983FBB0-0x000000018983FC14
		private static bool TryParseElement(Lexer lexer, out NameValueHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x000000018983FC14-0x000000018983FE0C
	}

	public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable // TypeDefIndex: 58129
	{
		// Fields
		private List<NameValueHeaderValue> parameters; // 0x20
	
		// Properties
		public ICollection<NameValueHeaderValue> Parameters { get => default; } // 0x0000000189840978-0x00000001898409FC 
	
		// Constructors
		protected NameValueWithParametersHeaderValue(NameValueWithParametersHeaderValue source) {} // 0x0000000189840828-0x0000000189840978
		private NameValueWithParametersHeaderValue() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		new object ICloneable.Clone() => default; // 0x000000018984044C-0x00000001898404AC
		public override bool Equals(object obj) => default; // 0x0000000189840368-0x00000001898403F8
		public override int GetHashCode() => default; // 0x00000001898403F8-0x000000018984044C
		public override string ToString() => default; // 0x00000001898404AC-0x0000000189840534
		internal static bool TryParse(string input, int minimalCount, out List<NameValueWithParametersHeaderValue> result) {
			result = default;
			return default;
		} // 0x0000000189840778-0x0000000189840828
		private static bool TryParseElement(Lexer lexer, out NameValueWithParametersHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x0000000189840534-0x0000000189840778
	}

	internal static class Parser // TypeDefIndex: 58141
	{
		// Nested types
		public static class Token // TypeDefIndex: 58130
		{
			// Methods
			public static void Check(string s) {} // 0x0000000189843770-0x000000018984389C
			public static bool TryCheck(string s) => default; // 0x00000001898438EC-0x000000018984393C
		}
	
		public static class DateTime // TypeDefIndex: 58132
		{
			// Fields
			public static readonly System.Func<object, string> ToString; // 0x00
	
			// Constructors
			static DateTime() {} // 0x0000000189835348-0x000000018983540C
	
			// Methods
			public static bool TryParse(string input, out DateTimeOffset result) {
				result = default;
				return default;
			} // 0x00000001898352EC-0x0000000189835348
		}
	
		public static class EmailAddress // TypeDefIndex: 58133
		{
			// Methods
			public static bool TryParse(string input, out string result) {
				result = default;
				return default;
			} // 0x000000018983540C-0x00000001898354FC
		}
	
		public static class Host // TypeDefIndex: 58134
		{
			// Methods
			public static bool TryParse(string input, out string result) {
				result = default;
				return default;
			} // 0x0000000189835DB4-0x0000000189835E50
		}
	
		public static class Int // TypeDefIndex: 58135
		{
			// Methods
			public static bool TryParse(string input, out int result) {
				result = default;
				return default;
			} // 0x000000018983BC88-0x000000018983BCE8
		}
	
		public static class Long // TypeDefIndex: 58136
		{
			// Methods
			public static bool TryParse(string input, out long result) {
				result = default;
				return default;
			} // 0x000000018983C9C4-0x000000018983CA24
		}
	
		public static class MD5 // TypeDefIndex: 58138
		{
			// Fields
			public static readonly System.Func<object, string> ToString; // 0x00
	
			// Constructors
			static MD5() {} // 0x000000018983CB08-0x000000018983CBCC
	
			// Methods
			public static bool TryParse(string input, out byte[] result) {
				result = default;
				return default;
			} // 0x000000018983CA24-0x000000018983CB08
		}
	
		public static class TimeSpanSeconds // TypeDefIndex: 58139
		{
			// Methods
			public static bool TryParse(string input, out TimeSpan result) {
				result = default;
				return default;
			} // 0x00000001898436DC-0x0000000189843770
		}
	
		public static class Uri // TypeDefIndex: 58140
		{
			// Methods
			public static bool TryParse(string input, out System.Uri result) {
				result = default;
				return default;
			} // 0x000000018984889C-0x00000001898488F0
		}
	}

	public class ProductHeaderValue : ICloneable // TypeDefIndex: 58142
	{
		// Properties
		public string Name { get; internal set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string Version { get; internal set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		internal ProductHeaderValue() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000182A48500-0x0000000182A48510
		public override bool Equals(object obj) => default; // 0x0000000189840B10-0x0000000189840B90
		public override int GetHashCode() => default; // 0x0000000189840B90-0x0000000189840BFC
		internal static bool TryParse(string input, int minimalCount, out List<ProductHeaderValue> result) {
			result = default;
			return default;
		} // 0x0000000189840E30-0x0000000189840EE0
		private static bool TryParseElement(Lexer lexer, out ProductHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x0000000189840C50-0x0000000189840E30
		public override string ToString() => default; // 0x0000000189840BFC-0x0000000189840C50
	}

	public class ProductInfoHeaderValue : ICloneable // TypeDefIndex: 58143
	{
		// Properties
		public string Comment { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public ProductHeaderValue Product { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public ProductInfoHeaderValue(ProductHeaderValue product) {} // 0x0000000189841318-0x000000018984137C
		private ProductInfoHeaderValue() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000182A48500-0x0000000182A48510
		public override bool Equals(object obj) => default; // 0x0000000189840EE0-0x0000000189840F54
		public override int GetHashCode() => default; // 0x0000000189840F54-0x0000000189840F84
		internal static bool TryParse(string input, int minimalCount, out List<ProductInfoHeaderValue> result) {
			result = default;
			return default;
		} // 0x00000001898411C8-0x0000000189841318
		private static bool TryParseElement(Lexer lexer, out ProductInfoHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x0000000189840FAC-0x00000001898411C8
		public override string ToString() => default; // 0x0000000189840F84-0x0000000189840FAC
	}

	public class RangeConditionHeaderValue : ICloneable // TypeDefIndex: 58144
	{
		// Properties
		public DateTimeOffset? Date { get; private set; } // 0x00000001820B6BB0-0x00000001820B6BD0 0x0000000183D64DD0-0x0000000183D64DF0
		public EntityTagHeaderValue EntityTag { get; private set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
	
		// Constructors
		public RangeConditionHeaderValue() {} // Dummy constructor
		public RangeConditionHeaderValue(DateTimeOffset date) {} // 0x0000000189841864-0x00000001898418C4
		public RangeConditionHeaderValue(EntityTagHeaderValue entityTag) {} // 0x00000001898418C4-0x0000000189841938
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000182A48500-0x0000000182A48510
		public override bool Equals(object obj) => default; // 0x000000018984137C-0x0000000189841480
		public override int GetHashCode() => default; // 0x0000000189841480-0x00000001898414EC
		public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x00000001898415D0-0x0000000189841864
		public override string ToString() => default; // 0x00000001898414EC-0x00000001898415D0
	}

	public class RangeHeaderValue : ICloneable // TypeDefIndex: 58145
	{
		// Fields
		private List<RangeItemHeaderValue> ranges; // 0x10
		private string unit; // 0x18
	
		// Properties
		public ICollection<RangeItemHeaderValue> Ranges { get => default; } // 0x0000000189842210-0x0000000189842294 
		public string Unit { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public RangeHeaderValue() {} // 0x00000001898421D0-0x0000000189842210
		private RangeHeaderValue(RangeHeaderValue source) {} // 0x0000000189842088-0x00000001898421D0
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000189841A34-0x0000000189841A94
		public override bool Equals(object obj) => default; // 0x0000000189841938-0x00000001898419C4
		public override int GetHashCode() => default; // 0x00000001898419C4-0x0000000189841A34
		public static bool TryParse(string input, out RangeHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x0000000189841BB8-0x0000000189842088
		public override string ToString() => default; // 0x0000000189841A94-0x0000000189841BB8
	}

	public class RangeItemHeaderValue : ICloneable // TypeDefIndex: 58146
	{
		// Properties
		public long? From { get; private set; } // 0x00000001820B7B30-0x00000001820B7B40 0x0000000183D55580-0x0000000183D55590
		public long? To { get; private set; } // 0x0000000183D54E00-0x0000000183D54E10 0x0000000183D54E10-0x0000000183D54E20
	
		// Constructors
		public RangeItemHeaderValue() {} // Dummy constructor
		public RangeItemHeaderValue(long? from, long? to) {} // 0x00000001898424E0-0x00000001898426D0
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000182A48500-0x0000000182A48510
		public override bool Equals(object obj) => default; // 0x0000000189842294-0x000000018984234C
		public override int GetHashCode() => default; // 0x000000018984234C-0x00000001898423BC
		public override string ToString() => default; // 0x00000001898423BC-0x00000001898424E0
	}

	public class RetryConditionHeaderValue : ICloneable // TypeDefIndex: 58147
	{
		// Properties
		public DateTimeOffset? Date { get; private set; } // 0x00000001820B6BB0-0x00000001820B6BD0 0x0000000183D64DD0-0x0000000183D64DF0
		public TimeSpan? Delta { get; private set; } // 0x0000000183D59E20-0x0000000183D59E30 0x0000000183D59E30-0x0000000183D59E40
	
		// Constructors
		public RetryConditionHeaderValue() {} // Dummy constructor
		public RetryConditionHeaderValue(DateTimeOffset date) {} // 0x0000000189842CC4-0x0000000189842D24
		public RetryConditionHeaderValue(TimeSpan delta) {} // 0x0000000189842BE8-0x0000000189842CC4
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000182A48500-0x0000000182A48510
		public override bool Equals(object obj) => default; // 0x00000001898426D0-0x0000000189842820
		public override int GetHashCode() => default; // 0x0000000189842820-0x00000001898428A4
		public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x00000001898429F0-0x0000000189842BE8
		public override string ToString() => default; // 0x00000001898428A4-0x00000001898429F0
	}

	public class StringWithQualityHeaderValue : ICloneable // TypeDefIndex: 58148
	{
		// Properties
		public double? Quality { get; private set; } // 0x00000001820B7B30-0x00000001820B7B40 0x0000000183D55580-0x0000000183D55590
		public string Value { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Constructors
		private StringWithQualityHeaderValue() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000182A48500-0x0000000182A48510
		public override bool Equals(object obj) => default; // 0x0000000189843140-0x0000000189843210
		public override int GetHashCode() => default; // 0x0000000189843210-0x000000018984328C
		internal static bool TryParse(string input, int minimalCount, out List<StringWithQualityHeaderValue> result) {
			result = default;
			return default;
		} // 0x000000018984362C-0x00000001898436DC
		private static bool TryParseElement(Lexer lexer, out StringWithQualityHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x0000000189843364-0x000000018984362C
		public override string ToString() => default; // 0x000000018984328C-0x0000000189843364
	}

	public class TransferCodingHeaderValue : ICloneable // TypeDefIndex: 58149
	{
		// Fields
		internal string value; // 0x10
		internal List<NameValueHeaderValue> parameters; // 0x18
	
		// Properties
		public ICollection<NameValueHeaderValue> Parameters { get => default; } // 0x0000000189844084-0x0000000189844108 
		public string Value { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		protected TransferCodingHeaderValue(TransferCodingHeaderValue source) {} // 0x0000000189843DF8-0x0000000189844084
		internal TransferCodingHeaderValue() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000189843B18-0x0000000189843B78
		public override bool Equals(object obj) => default; // 0x0000000189843A10-0x0000000189843A9C
		public override int GetHashCode() => default; // 0x0000000189843A9C-0x0000000189843B18
		public override string ToString() => default; // 0x0000000189843B78-0x0000000189843BD0
		internal static bool TryParse(string input, int minimalCount, out List<TransferCodingHeaderValue> result) {
			result = default;
			return default;
		} // 0x0000000189843D48-0x0000000189843DF8
		private static bool TryParseElement(Lexer lexer, out TransferCodingHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x0000000189843BD0-0x0000000189843D48
	}

	public sealed class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue // TypeDefIndex: 58150
	{
		// Constructors
		private TransferCodingWithQualityHeaderValue() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal static bool TryParse(string input, int minimalCount, out List<TransferCodingWithQualityHeaderValue> result) {
			result = default;
			return default;
		} // 0x0000000189848A68-0x0000000189848B18
		private static bool TryParseElement(Lexer lexer, out TransferCodingWithQualityHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x00000001898488F0-0x0000000189848A68
	}

	public class ViaHeaderValue : ICloneable // TypeDefIndex: 58151
	{
		// Properties
		public string Comment { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string ProtocolName { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public string ProtocolVersion { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public string ReceivedBy { get; private set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
	
		// Constructors
		private ViaHeaderValue() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000182A48500-0x0000000182A48510
		public override bool Equals(object obj) => default; // 0x0000000189848B18-0x0000000189848BC8
		public override int GetHashCode() => default; // 0x0000000189848BC8-0x0000000189848C90
		internal static bool TryParse(string input, int minimalCount, out List<ViaHeaderValue> result) {
			result = default;
			return default;
		} // 0x00000001898490A0-0x0000000189849150
		private static bool TryParseElement(Lexer lexer, out ViaHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x0000000189848DA0-0x00000001898490A0
		public override string ToString() => default; // 0x0000000189848C90-0x0000000189848DA0
	}

	public class WarningHeaderValue : ICloneable // TypeDefIndex: 58152
	{
		// Properties
		public string Agent { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public int Code { get; private set; } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public DateTimeOffset? Date { get; private set; } // 0x0000000183D50E20-0x0000000183D50E40 0x0000000183D755E0-0x0000000183D75600
		public string Text { get; private set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
	
		// Constructors
		private WarningHeaderValue() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private static bool IsCodeValid(int code) => default; // 0x0000000189849330-0x0000000189849344
		object ICloneable.Clone() => default; // 0x0000000182A48500-0x0000000182A48510
		public override bool Equals(object obj) => default; // 0x0000000189849150-0x000000018984927C
		public override int GetHashCode() => default; // 0x000000018984927C-0x0000000189849330
		internal static bool TryParse(string input, int minimalCount, out List<WarningHeaderValue> result) {
			result = default;
			return default;
		} // 0x0000000189849834-0x0000000189849B10
		private static bool TryParseElement(Lexer lexer, out WarningHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x0000000189849528-0x0000000189849834
		public override string ToString() => default; // 0x0000000189849344-0x0000000189849528
	}
}
