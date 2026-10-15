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

// Image 66: System.Net.Http.dll - Assembly: System.Net.Http, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a - Types 89303-89386

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 89386
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_127 _1D59178A3E2B293760F6FE72820F96FEC4071964A5B9E4BB13F7EA51510A4729; // 0x00 // Static value (base64): AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAQABAQEBAQAAAQEAAQEAAQEBAQEBAQEBAQAAAAAAAAABAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQAAAAEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAAEAAQ== - Metadata: 0x02648AF8

	// Nested types
	private struct __StaticArrayInitTypeSize_127 // TypeDefIndex: 89385
	{
	}

	// Methods
	internal static uint ComputeStringHash(string s); // 0x0000000188B56950-0x0000000188B569A4
}

namespace System.Net.Http
{
	public class HttpClientHandler : HttpMessageHandler // TypeDefIndex: 89305
	{
		// Fields
		private readonly IMonoHttpClientHandler _delegatingHandler; // 0x10
		private ClientCertificateOption _clientCertificateOptions; // 0x18
	
		// Properties
		public ClientCertificateOption ClientCertificateOptions { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x0000000185F52E00-0x0000000185F52F00
		public X509CertificateCollection ClientCertificates { get; } // 0x000000018CFD6090-0x000000018CFD61C0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 89304
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static LocalCertificateSelectionCallback __9__23_1; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CFDE9B8-0x000000018CFDEA1C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal X509Certificate _set_ClientCertificateOptions_b__23_1(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers); // 0x000000018CFDE9B0-0x000000018CFDE9B8
		}
	
		// Constructors
		public HttpClientHandler(); // 0x0000000185F52D00-0x0000000185F52D30
		internal HttpClientHandler(IMonoHttpClientHandler handler); // 0x0000000185F52D80-0x0000000185F52DB0
	
		// Methods
		private static IMonoHttpClientHandler CreateDefaultHandler(); // 0x0000000185F52D30-0x0000000185F52D80
		protected override void Dispose(bool disposing); // 0x000000018CFD601C-0x000000018CFD6074
		private void ThrowForModifiedManagedSslOptionsIfStarted(); // 0x0000000185F52DB0-0x0000000185F52E00
		internal void SetWebRequestTimeout(TimeSpan timeout); // 0x0000000186ACDCF0-0x0000000186ACDD30
		protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken); // 0x0000000186CD9900-0x0000000186CD9940
		[CompilerGenerated]
		private X509Certificate _set_ClientCertificateOptions_b__23_0(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers); // 0x000000018CFD6074-0x000000018CFD6090
	}

	internal interface IMonoHttpClientHandler : IDisposable // TypeDefIndex: 89306
	{
		// Properties
		SslClientAuthenticationOptions SslOptions { get; set; }
	
		// Methods
		Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
		void SetWebRequestTimeout(TimeSpan timeout);
	}

	internal class MonoWebRequestHandler : IMonoHttpClientHandler // TypeDefIndex: 89309
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
		public CookieContainer CookieContainer { get; } // 0x000000018537DB40-0x000000018537DBC0 
		public long MaxRequestContentBufferSize { get; } // 0x00000001829600D0-0x00000001829600E0 
		public SslClientAuthenticationOptions SslOptions { get; set; } // 0x0000000185F52F00-0x0000000185F52F70 0x0000000185F52F70-0x0000000185F52FA0
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 89307
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, bool> __9__95_0; // 0x08
			public static Func<string, bool> __9__96_0; // 0x10
			public static Action<object> __9__99_0; // 0x18
	
			// Constructors
			static __c(); // 0x00000001871E5720-0x00000001871E5780
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetConnectionKeepAlive_b__95_0(string l); // 0x000000018CFDE6E8-0x000000018CFDE72C
			internal bool _CreateWebRequest_b__96_0(string l); // 0x000000018CFDE6AC-0x000000018CFDE6E8
			internal void _SendAsync_b__99_0(object l); // 0x000000018CFDE72C-0x000000018CFDE78C
		}
	
		[CompilerGenerated]
		private struct _SendAsync_d__99 : IAsyncStateMachine // TypeDefIndex: 89308
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
			private void MoveNext(); // 0x0000000186030A50-0x00000001860332C0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001870F21C0-0x00000001870F2230
		}
	
		// Constructors
		public MonoWebRequestHandler(); // 0x0000000185F53320-0x0000000185F534A0
	
		// Methods
		internal void EnsureModifiability(); // 0x0000000185F52FA0-0x0000000185F52FC0
		public void Dispose(); // 0x000000018CFD86DC-0x000000018CFD86E8
		protected virtual void Dispose(bool disposing); // 0x000000018CFD866C-0x000000018CFD86DC
		private bool GetConnectionKeepAlive(HttpRequestHeaders headers); // 0x000000018CFD86E8-0x000000018CFD8808
		internal virtual HttpWebRequest CreateWebRequest(HttpRequestMessage request); // 0x000000018537E720-0x000000018537EEA0
		private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken); // 0x00000001853807B0-0x0000000185380960
		private static bool MethodHasBody(HttpMethod method); // 0x000000018CFD8808-0x000000018CFD88E8
		public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken); // 0x0000000186CD9940-0x0000000186CD9A60
		void IMonoHttpClientHandler.SetWebRequestTimeout(TimeSpan timeout); // 0x0000000186ACDD30-0x0000000186ACDD90
	}

	internal static class PlatformHelper // TypeDefIndex: 89310
	{
		// Methods
		internal static bool IsContentHeader(string name); // 0x0000000185380E90-0x0000000185380ED0
		internal static string GetSingleHeaderString(string name, IEnumerable<string> values); // 0x000000018CFDA6DC-0x000000018CFDA738
		internal static StreamContent CreateStreamContent(Stream stream, CancellationToken cancellationToken); // 0x0000000187171D80-0x0000000187171DF0
	}

	public class ByteArrayContent : HttpContent // TypeDefIndex: 89311
	{
		// Fields
		private readonly byte[] content; // 0x28
		private readonly int offset; // 0x30
		private readonly int count; // 0x34
	
		// Constructors
		public ByteArrayContent(byte[] content); // 0x000000018537C140-0x000000018537C170
	
		// Methods
		protected override System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context); // 0x00000001861C8FF0-0x00000001861C9030
		protected internal override bool TryComputeLength(out long length); // 0x00000001872315A0-0x00000001872315B0
	}

	public enum ClientCertificateOption // TypeDefIndex: 89312
	{
		Manual = 0,
		Automatic = 1
	}

	public class HttpClient : HttpMessageInvoker // TypeDefIndex: 89314
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
		public HttpRequestHeaders DefaultRequestHeaders { get; } // 0x000000018CFD6370-0x000000018CFD63E4 
		public long MaxResponseContentBufferSize { get; } // 0x000000018226EEA0-0x000000018226EEB0 
	
		// Nested types
		[CompilerGenerated]
		private struct _SendAsyncWorker_d__47 : IAsyncStateMachine // TypeDefIndex: 89313
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
			private void MoveNext(); // 0x0000000186ACCCC0-0x0000000186ACDB30
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001870F2230-0x00000001870F22A0
		}
	
		// Constructors
		public HttpClient(); // 0x0000000185F52C90-0x0000000185F52D00
		public HttpClient(HttpMessageHandler handler, bool disposeHandler); // 0x0000000185F53040-0x0000000185F53120
		static HttpClient(); // 0x00000001871E0370-0x00000001871E03E0
	
		// Methods
		protected override void Dispose(bool disposing); // 0x000000018CFD61C0-0x000000018CFD6220
		public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content); // 0x000000018CFD6220-0x000000018CFD6310
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request); // 0x000000018CFD6310-0x000000018CFD6370
		public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken); // 0x0000000186CD97B0-0x0000000186CD97D0
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken); // 0x0000000186CD97D0-0x0000000186CD9900
		private async Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken); // 0x0000000186CD9A60-0x0000000186CD9BB0
		[CompilerGenerated]
		[DebuggerHidden]
		private Task<HttpResponseMessage> __n__0(HttpRequestMessage request, CancellationToken cancellationToken); // 0x000000018783CED0-0x000000018783CED8
	}

	public enum HttpCompletionOption // TypeDefIndex: 89315
	{
		ResponseContentRead = 0,
		ResponseHeadersRead = 1
	}

	public abstract class HttpContent : IDisposable // TypeDefIndex: 89319
	{
		// Fields
		private FixedMemoryStream buffer; // 0x10
		private bool disposed; // 0x18
		private HttpContentHeaders headers; // 0x20
	
		// Properties
		public HttpContentHeaders Headers { get; } // 0x000000018537EFE0-0x000000018537F040 
		internal long? LoadedBufferLength { get; } // 0x0000000186EB9190-0x0000000186EB91E0 
	
		// Nested types
		private sealed class FixedMemoryStream : MemoryStream // TypeDefIndex: 89316
		{
			// Fields
			private readonly long maxSize; // 0x50
	
			// Constructors
			public FixedMemoryStream(long maxSize); // 0x000000018783D354-0x000000018783D3C0
	
			// Methods
			private void CheckOverflow(int count); // 0x00000001871C7210-0x00000001871C7250
			public override void WriteByte(byte value); // 0x000000018CFD5EB8-0x000000018CFD5EF0
			public override void Write(byte[] buffer, int offset, int count); // 0x00000001871C71B0-0x00000001871C7210
		}
	
		[CompilerGenerated]
		private struct _LoadIntoBufferAsync_d__17 : IAsyncStateMachine // TypeDefIndex: 89317
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public HttpContent __4__this; // 0x20
			public long maxBufferSize; // 0x28
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x0000000186C42110-0x0000000186C42290
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018CFDD724-0x000000018CFDD780
		}
	
		[CompilerGenerated]
		private struct _ReadAsStringAsync_d__20 : IAsyncStateMachine // TypeDefIndex: 89318
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<string> __t__builder; // 0x08
			public HttpContent __4__this; // 0x20
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x0000000186AE1D20-0x0000000186AE1FA0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018CFDD780-0x000000018CFDD7E0
		}
	
		// Constructors
		protected HttpContent(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public System.Threading.Tasks.Task CopyToAsync(Stream stream); // 0x000000018783B62C-0x000000018783B638
		public System.Threading.Tasks.Task CopyToAsync(Stream stream, TransportContext context); // 0x0000000186C42290-0x0000000186C422D0
		private static FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize); // 0x0000000186C422D0-0x0000000186C423A0
		public void Dispose(); // 0x00000001870D4130-0x00000001870D4140
		protected virtual void Dispose(bool disposing); // 0x00000001870D3C60-0x00000001870D3C90
		public System.Threading.Tasks.Task LoadIntoBufferAsync(); // 0x000000018783CF24-0x000000018783CF34
		public async System.Threading.Tasks.Task LoadIntoBufferAsync(long maxBufferSize); // 0x0000000186ACDC00-0x0000000186ACDCF0
		public async Task<string> ReadAsStringAsync(); // 0x000000018709E610-0x000000018709E700
		private static Encoding GetEncodingFromBuffer(byte[] buffer, int length, ref int preambleLength); // 0x0000000186AE2080-0x0000000186AE21C0
		private static int StartsWith(byte[] array, int length, byte[] value); // 0x0000000186AE21C0-0x0000000186AE2220
		internal System.Threading.Tasks.Task SerializeToStreamAsync_internal(Stream stream, TransportContext context); // 0x000000018CFD64FC-0x000000018CFD650C
		protected abstract System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context);
		protected internal abstract bool TryComputeLength(out long length);
	}

	public abstract class HttpMessageHandler : IDisposable // TypeDefIndex: 89320
	{
		// Constructors
		protected HttpMessageHandler(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Dispose(); // 0x00000001870D4130-0x00000001870D4140
		protected virtual void Dispose(bool disposing); // 0x0000000186805BA0-0x0000000186805BB0
		protected internal abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
	}

	public class HttpMessageInvoker : IDisposable // TypeDefIndex: 89321
	{
		// Fields
		private protected HttpMessageHandler handler; // 0x10
		private readonly bool disposeHandler; // 0x18
	
		// Constructors
		public HttpMessageInvoker(HttpMessageHandler handler, bool disposeHandler); // 0x0000000185F53120-0x0000000185F531A0
	
		// Methods
		public void Dispose(); // 0x00000001870D4130-0x00000001870D4140
		protected virtual void Dispose(bool disposing); // 0x000000018CFD6CA8-0x000000018CFD6CE4
		public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken); // 0x00000001871127E0-0x0000000187112810
	}

	public class HttpMethod : IEquatable<HttpMethod> // TypeDefIndex: 89322
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
		public string Method { get; } // 0x00000001829260F0-0x0000000182926100 
		public static HttpMethod Post { get; } // 0x000000018CFD6D6C-0x000000018CFD6DBC 
	
		// Constructors
		public HttpMethod(string method); // 0x00000001853803B0-0x0000000185380400
		static HttpMethod(); // 0x00000001853800F0-0x00000001853803B0
	
		// Methods
		public static bool operator ==(HttpMethod left, HttpMethod right); // 0x0000000186EE3250-0x0000000186EE3280
		public bool Equals(HttpMethod other); // 0x000000018CFD6CE4-0x000000018CFD6D10
		public override bool Equals(object obj); // 0x000000018CFD6D10-0x000000018CFD6D6C
		public override int GetHashCode(); // 0x000000018A92B598-0x000000018A92B5BC
		public override string ToString(); // 0x00000001829260F0-0x0000000182926100
	}

	[Serializable]
	public class HttpRequestException : Exception // TypeDefIndex: 89323
	{
		// Constructors
		public HttpRequestException(); // 0x000000018CFD6DBC-0x000000018CFD6E08
		public HttpRequestException(string message); // 0x000000018CFD6E08-0x000000018CFD6E64
		public HttpRequestException(string message, Exception inner); // 0x000000018CFD6E64-0x000000018CFD6EC4
	}

	public class HttpRequestMessage : IDisposable // TypeDefIndex: 89324
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
		public HttpContent Content { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public HttpRequestHeaders Headers { get; } // 0x000000018537EEA0-0x000000018537EF00 
		public HttpMethod Method { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000186EE31E0-0x0000000186EE3250
		public System.Uri RequestUri { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185B81F30-0x0000000185B81FB0
		public System.Version Version { get; } // 0x000000018537EF00-0x000000018537EF60 
	
		// Constructors
		public HttpRequestMessage(HttpMethod method, string requestUri); // 0x0000000186EE30D0-0x0000000186EE3180
		public HttpRequestMessage(HttpMethod method, System.Uri requestUri); // 0x0000000186EE3180-0x0000000186EE31B0
	
		// Methods
		private static bool IsAllowedAbsoluteUri(System.Uri uri); // 0x0000000185B81E50-0x0000000185B81F30
		public void Dispose(); // 0x00000001870D40A0-0x00000001870D40D0
		protected virtual void Dispose(bool disposing); // 0x00000001870D40D0-0x00000001870D4100
		internal bool SetIsUsed(); // 0x0000000186CD9BB0-0x0000000186CD9BC0
		public override string ToString(); // 0x000000018CFD7210-0x000000018CFD745C
	}

	public class HttpResponseMessage : IDisposable // TypeDefIndex: 89325
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
		public HttpContent Content { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public HttpResponseHeaders Headers { get; } // 0x0000000185381770-0x00000001853817D0 
		public string ReasonPhrase { get; set; } // 0x000000018CFD7670-0x000000018CFD7684 0x0000000187835500-0x0000000187835510
		public HttpRequestMessage RequestMessage { [CompilerGenerated] set; } // 0x00000001870EAAD0-0x00000001870EAAE0
		public HttpStatusCode StatusCode { get; set; } // 0x000000018226A850-0x000000018226A860 0x000000018722B710-0x000000018722B730
		public System.Version Version { get; } // 0x000000018CFD7684-0x000000018CFD76D8 
	
		// Constructors
		public HttpResponseMessage(HttpStatusCode statusCode); // 0x000000018722B700-0x000000018722B710
	
		// Methods
		public void Dispose(); // 0x00000001870D4070-0x00000001870D40A0
		protected virtual void Dispose(bool disposing); // 0x00000001870D4100-0x00000001870D4130
		public override string ToString(); // 0x000000018CFD745C-0x000000018CFD7670
	}

	public class MultipartContent : HttpContent, IEnumerable<HttpContent> // TypeDefIndex: 89327
	{
		// Fields
		private List<HttpContent> nested_content; // 0x28
		private readonly string boundary; // 0x30
	
		// Nested types
		[CompilerGenerated]
		private struct _SerializeToStreamAsync_d__8 : IAsyncStateMachine // TypeDefIndex: 89326
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
			private void MoveNext(); // 0x000000018CFDD7E0-0x000000018CFDE650
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018CFDE650-0x000000018CFDE6AC
		}
	
		// Constructors
		public MultipartContent(string subtype); // 0x000000018CFD91EC-0x000000018CFD92A0
		public MultipartContent(string subtype, string boundary); // 0x000000018CFD92A0-0x000000018CFD9600
	
		// Methods
		private static bool IsValidRFC2049(string s); // 0x000000018CFD8C14-0x000000018CFD8CCC
		public virtual void Add(HttpContent content); // 0x000000018CFD88E8-0x000000018CFD89E8
		protected override void Dispose(bool disposing); // 0x000000018CFD89E8-0x000000018CFD8B94
		protected override async System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context); // 0x000000018CFD8CCC-0x000000018CFD8DBC
		protected internal override bool TryComputeLength(out long length); // 0x000000018CFD8E3C-0x000000018CFD91EC
		public IEnumerator<HttpContent> GetEnumerator(); // 0x000000018CFD8B94-0x000000018CFD8C14
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018CFD8DBC-0x000000018CFD8E3C
	}

	public class MultipartFormDataContent : MultipartContent // TypeDefIndex: 89328
	{
		// Constructors
		public MultipartFormDataContent(); // 0x000000018CFD98F0-0x000000018CFD992C
	
		// Methods
		public override void Add(HttpContent content); // 0x000000018CFD98B0-0x000000018CFD98F0
		public void Add(HttpContent content, string name); // 0x000000018CFD96EC-0x000000018CFD9798
		public void Add(HttpContent content, string name, string fileName); // 0x000000018CFD9798-0x000000018CFD98B0
		private void AddContentDisposition(HttpContent content, string name, string fileName); // 0x000000018CFD9600-0x000000018CFD96EC
	}

	public class StreamContent : HttpContent // TypeDefIndex: 89329
	{
		// Fields
		private readonly Stream content; // 0x28
		private readonly int bufferSize; // 0x30
		private readonly CancellationToken cancellationToken; // 0x38
		private readonly long startPosition; // 0x40
		private bool contentCopied; // 0x48
	
		// Constructors
		public StreamContent(Stream content); // 0x000000018783D96C-0x000000018783D97C
		public StreamContent(Stream content, int bufferSize); // 0x00000001871DCB90-0x00000001871DCBF0
		internal StreamContent(Stream content, CancellationToken cancellationToken); // 0x0000000187171DF0-0x0000000187171E60
	
		// Methods
		protected override void Dispose(bool disposing); // 0x00000001870D3C10-0x00000001870D3C60
		protected override System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context); // 0x0000000187121D90-0x0000000187121DE0
		protected internal override bool TryComputeLength(out long length); // 0x000000018CFDC974-0x000000018CFDC9D4
	}

	public class StringContent : ByteArrayContent // TypeDefIndex: 89330
	{
		// Constructors
		public StringContent(string content); // 0x000000018CFDC9D4-0x000000018CFDC9F4
		public StringContent(string content, Encoding encoding, string mediaType); // 0x000000018537DC40-0x000000018537DD50
	
		// Methods
		private static byte[] GetByteArray(string content, Encoding encoding); // 0x000000018537DD50-0x000000018537DD90
	}
}

namespace System.Net.Http.Headers
{
	public class AuthenticationHeaderValue : ICloneable // TypeDefIndex: 89331
	{
		// Fields
		[CompilerGenerated]
		private string _Parameter_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Scheme_k__BackingField; // 0x18
	
		// Properties
		public string Parameter { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string Scheme { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		public AuthenticationHeaderValue(string scheme, string parameter); // 0x000000018CFD28E0-0x000000018CFD292C
		private AuthenticationHeaderValue(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		object ICloneable.Clone(); // 0x0000000185A39C10-0x0000000185A39C20
		public override bool Equals(object obj); // 0x000000018CFD2480-0x000000018CFD24FC
		public override int GetHashCode(); // 0x000000018CFD24FC-0x000000018CFD2570
		public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue); // 0x000000018CFD2770-0x000000018CFD2830
		internal static bool TryParse(string input, int minimalCount, out List<AuthenticationHeaderValue> result); // 0x000000018CFD2830-0x000000018CFD28E0
		private static bool TryParseElement(Lexer lexer, out AuthenticationHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018CFD25BC-0x000000018CFD2770
		public override string ToString(); // 0x000000018CFD2570-0x000000018CFD25BC
	}

	public class CacheControlHeaderValue : ICloneable // TypeDefIndex: 89332
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
		public ICollection<NameValueHeaderValue> Extensions { get; } // 0x000000018CFD4108-0x000000018CFD418C 
		public TimeSpan? MaxAge { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723D770-0x000000018723D780 0x000000018723D780-0x000000018723D790
		public bool MaxStale { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E070-0x000000018225E080 0x000000018225E080-0x000000018225E090
		public TimeSpan? MaxStaleLimit { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723E4C0-0x000000018723E4D0 0x0000000187234080-0x0000000187234090
		public TimeSpan? MinFresh { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187239B00-0x0000000187239B10 0x0000000187233F10-0x0000000187233F20
		public bool MustRevalidate { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226ED60-0x000000018226ED70 0x000000018226ED70-0x000000018226ED80
		public bool NoCache { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872361E0-0x00000001872361F0 0x000000018723EB60-0x000000018723EB70
		public ICollection<string> NoCacheHeaders { get; } // 0x000000018CFD418C-0x000000018CFD4210 
		public bool NoStore { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723DD70-0x000000018723DD80 0x000000018723DD90-0x000000018723DDA0
		public bool NoTransform { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723DD60-0x000000018723DD70 0x000000018723DD80-0x000000018723DD90
		public bool OnlyIfCached { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E030-0x000000018225E040 0x000000018225E040-0x000000018225E050
		public bool Private { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723CA30-0x000000018723CA40 0x000000018723CA60-0x000000018723CA70
		public ICollection<string> PrivateHeaders { get; } // 0x000000018CFD4210-0x000000018CFD4294 
		public bool ProxyRevalidate { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187258140-0x0000000187258150 0x0000000187258240-0x0000000187258250
		public bool Public { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187258230-0x0000000187258240 0x0000000187258250-0x0000000187258260
		public TimeSpan? SharedMaxAge { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187253FA0-0x0000000187253FB0 0x0000000187233C70-0x0000000187233C80
	
		// Constructors
		public CacheControlHeaderValue(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		object ICloneable.Clone(); // 0x000000018CFD2D94-0x000000018CFD32C4
		public override bool Equals(object obj); // 0x000000018CFD292C-0x000000018CFD2B70
		public override int GetHashCode(); // 0x000000018CFD2B70-0x000000018CFD2D94
		public static bool TryParse(string input, out CacheControlHeaderValue parsedValue); // 0x000000018CFD3908-0x000000018CFD4108
		public override string ToString(); // 0x000000018CFD32C4-0x000000018CFD3908
	}

	internal static class CollectionExtensions // TypeDefIndex: 89333
	{
		// Extension methods
		public static bool SequenceEqual<TSource>(this List<TSource> first, List<TSource> second);
		public static void SetValue(this List<NameValueHeaderValue> parameters, string key, string value); // 0x0000000186897B90-0x0000000186897C20
		public static string ToString<T>(this List<T> list);
		public static void ToStringBuilder<T>(this List<T> list, StringBuilder sb);
	}

	internal delegate bool ElementTryParser<T>(Lexer lexer, out ref T parsedValue, out System.Net.Http.Headers.Token token); // TypeDefIndex: 89334; 0x00000000-0x00000000

	internal static class CollectionParser // TypeDefIndex: 89335
	{
		// Methods
		public static bool TryParse<T>(string input, int minimalCount, ElementTryParser<T> parser, out List<T> result)
			where T : class;
		public static bool TryParse(string input, int minimalCount, out List<string> result); // 0x000000018CFD43A0-0x000000018CFD4450
		private static bool TryParseStringElement(Lexer lexer, out string parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018CFD4294-0x000000018CFD43A0
	}

	public class ContentDispositionHeaderValue : ICloneable // TypeDefIndex: 89336
	{
		// Fields
		private string dispositionType; // 0x10
		private List<NameValueHeaderValue> parameters; // 0x18
	
		// Properties
		public string DispositionType { set; } // 0x000000018CFD4E30-0x000000018CFD4E64
		public string FileName { set; } // 0x000000018CFD4EC4-0x000000018CFD4F24
		public string FileNameStar { set; } // 0x000000018CFD4E64-0x000000018CFD4EC4
		public string Name { set; } // 0x000000018CFD4F24-0x000000018CFD4F84
		public ICollection<NameValueHeaderValue> Parameters { get; } // 0x000000018CFD4DAC-0x000000018CFD4E30 
	
		// Constructors
		private ContentDispositionHeaderValue(); // 0x0000000186805BA0-0x0000000186805BB0
		public ContentDispositionHeaderValue(string dispositionType); // 0x000000018CFD4DA4-0x000000018CFD4DAC
		protected ContentDispositionHeaderValue(ContentDispositionHeaderValue source); // 0x000000018CFD4BAC-0x000000018CFD4DA4
	
		// Methods
		object ICloneable.Clone(); // 0x000000018CFD4980-0x000000018CFD49E0
		public override bool Equals(object obj); // 0x000000018CFD4804-0x000000018CFD4890
		private static string EncodeBase64Value(string value); // 0x000000018CFD4450-0x000000018CFD45DC
		private static string EncodeRFC5987(string value); // 0x000000018CFD45DC-0x000000018CFD4804
		public override int GetHashCode(); // 0x000000018CFD4890-0x000000018CFD4900
		private void SetValue(string key, string value); // 0x000000018CFD4900-0x000000018CFD4980
		public override string ToString(); // 0x000000018CFD49E0-0x000000018CFD4A10
		public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue); // 0x000000018CFD4A10-0x000000018CFD4BAC
	}

	public class ContentRangeHeaderValue : ICloneable // TypeDefIndex: 89337
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
		public long? From { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001845C28E0-0x00000001845C28F0 0x0000000187235FF0-0x0000000187236000
		public long? Length { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723D770-0x000000018723D780 0x000000018723D780-0x000000018723D790
		public long? To { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723DAB0-0x000000018723DAC0 0x000000018723FA00-0x000000018723FA10
		public string Unit { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		private ContentRangeHeaderValue(); // 0x000000018CFD57A8-0x000000018CFD57E8
	
		// Methods
		object ICloneable.Clone(); // 0x0000000185A39C10-0x0000000185A39C20
		public override bool Equals(object obj); // 0x000000018CFD4F84-0x000000018CFD5060
		public override int GetHashCode(); // 0x000000018CFD5060-0x000000018CFD5158
		public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue); // 0x000000018CFD5368-0x000000018CFD57A8
		public override string ToString(); // 0x000000018CFD5158-0x000000018CFD5368
	}

	public class EntityTagHeaderValue : ICloneable // TypeDefIndex: 89338
	{
		// Fields
		private static readonly EntityTagHeaderValue any; // 0x00
		[CompilerGenerated]
		private bool _IsWeak_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Tag_k__BackingField; // 0x18
	
		// Properties
		public bool IsWeak { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
		public string Tag { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		internal EntityTagHeaderValue(); // 0x0000000186805BA0-0x0000000186805BB0
		static EntityTagHeaderValue(); // 0x000000018CFD5E34-0x000000018CFD5EB8
	
		// Methods
		object ICloneable.Clone(); // 0x0000000185A39C10-0x0000000185A39C20
		public override bool Equals(object obj); // 0x000000018CFD5938-0x000000018CFD59B4
		public override int GetHashCode(); // 0x000000018CFD59B4-0x000000018CFD5A24
		public static bool TryParse(string input, out EntityTagHeaderValue parsedValue); // 0x000000018CFD5CAC-0x000000018CFD5D84
		private static bool TryParseElement(Lexer lexer, out EntityTagHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018CFD5A6C-0x000000018CFD5CAC
		internal static bool TryParse(string input, int minimalCount, out List<EntityTagHeaderValue> result); // 0x000000018CFD5D84-0x000000018CFD5E34
		public override string ToString(); // 0x000000018CFD5A24-0x000000018CFD5A6C
	}

	internal static class HashCodeCalculator // TypeDefIndex: 89339
	{
		// Methods
		public static int Calculate<T>(ICollection<T> list);
	}

	internal delegate bool TryParseDelegate<T>(string value, out ref T result); // TypeDefIndex: 89340; 0x00000000-0x00000000

	internal delegate bool TryParseListDelegate<T>(string value, int minimalCount, out List<T> result); // TypeDefIndex: 89341; 0x00000000-0x00000000

	internal abstract class HeaderInfo // TypeDefIndex: 89344
	{
		// Fields
		public bool AllowsMany; // 0x10
		public readonly HttpHeaderKind HeaderKind; // 0x14
		public readonly string Name; // 0x18
		[CompilerGenerated]
		private Func<object, string> _CustomToString_k__BackingField; // 0x20
	
		// Properties
		public Func<object, string> CustomToString { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public virtual string Separator { get; } // 0x000000018CFD5F30-0x000000018CFD5F7C 
	
		// Nested types
		private class HeaderTypeInfo<T, U> : HeaderInfo // TypeDefIndex: 89342
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
	
		private class CollectionHeaderTypeInfo<T, U> : HeaderTypeInfo<T, U> // TypeDefIndex: 89343
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
		protected HeaderInfo(string name, HttpHeaderKind headerKind); // 0x0000000186AAB930-0x0000000186AAB950
	
		// Methods
		public static HeaderInfo CreateSingle<T>(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind, Func<object, string> toString = null);
		public static HeaderInfo CreateMulti<T>(string name, TryParseListDelegate<T> elementParser, HttpHeaderKind headerKind, int minimalCount = 1 /* Metadata: 0x02648AE0 */, string separator = ", " /* Metadata: 0x02648AE1 */)
			where T : class;
		public object CreateCollection(HttpHeaders headers); // 0x000000018CFD5EF0-0x000000018CFD5F30
		public abstract void AddToCollection(object collection, object value);
		protected abstract object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo);
		public abstract List<string> ToStringCollection(object collection);
		public abstract bool TryParse(string value, out object result);
	}

	public sealed class HttpContentHeaders : HttpHeaders // TypeDefIndex: 89345
	{
		// Fields
		private readonly HttpContent content; // 0x20
	
		// Properties
		public ContentDispositionHeaderValue ContentDisposition { get; set; } // 0x000000018CFD63E4-0x000000018CFD6430 0x000000018CFD6430-0x000000018CFD6494
		public long? ContentLength { get; set; } // 0x0000000186EB9040-0x0000000186EB9190 0x000000018CFD6494-0x000000018CFD64FC
		public MediaTypeHeaderValue ContentType { get; set; } // 0x0000000186AE1FA0-0x0000000186AE1FF0 0x00000001871DB2E0-0x00000001871DB350
	
		// Constructors
		internal HttpContentHeaders(HttpContent content); // 0x000000018537E600-0x000000018537E650
	}

	[Flags]
	internal enum HttpHeaderKind // TypeDefIndex: 89346
	{
		None = 0,
		Request = 1,
		Response = 2,
		Content = 4
	}

	public sealed class HttpHeaderValueCollection<T> : ICollection<T> // TypeDefIndex: 89347
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

	public abstract class HttpHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>> // TypeDefIndex: 89350
	{
		// Fields
		private static readonly Dictionary<string, System.Net.Http.Headers.HeaderInfo> known_headers; // 0x00
		private readonly Dictionary<string, HeaderBucket> headers; // 0x10
		private readonly HttpHeaderKind HeaderKind; // 0x18
		internal bool? connectionclose; // 0x1C
		internal bool? transferEncodingChunked; // 0x1E
	
		// Nested types
		private class HeaderBucket // TypeDefIndex: 89348
		{
			// Fields
			public object Parsed; // 0x10
			private List<string> values; // 0x18
			public readonly Func<object, string> CustomToString; // 0x20
	
			// Properties
			public bool HasStringValues { get; } // 0x0000000186A3B200-0x0000000186A3B220 
			public List<string> Values { get; set; } // 0x00000001853816E0-0x0000000185381740 0x0000000187835500-0x0000000187835510
	
			// Constructors
			public HeaderBucket(object parsed, Func<object, string> converter); // 0x0000000185381740-0x0000000185381770
	
			// Methods
			public string ParsedToString(); // 0x0000000186A3B670-0x0000000186A3B6B0
		}
	
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__19 : IEnumerator<KeyValuePair<string, IEnumerable<string>>> // TypeDefIndex: 89349
		{
			// Fields
			private int __1__state; // 0x10
			private KeyValuePair<string, IEnumerable<string>> __2__current; // 0x18
			public HttpHeaders __4__this; // 0x28
			private Dictionary<string, HeaderBucket> __7__wrap1; // 0x30
	
			// Properties
			KeyValuePair<string, IEnumerable<string>> IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.Current { [DebuggerHidden] get; } // 0x00000001845C28E0-0x00000001845C28F0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018CFDD6DC-0x000000018CFDD724 
	
			// Constructors
			[DebuggerHidden]
			public _GetEnumerator_d__19(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186A51C80-0x0000000186A51CB0
			private bool MoveNext(); // 0x0000000186A3AC70-0x0000000186A3B130
			private void __m__Finally1(); // 0x000000018442FC80-0x000000018442FC90
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CFDD690-0x000000018CFDD6DC
		}
	
		// Constructors
		static HttpHeaders(); // 0x00000001867A7F00-0x00000001867A9C00
		protected HttpHeaders(); // 0x0000000186F8B850-0x0000000186F8B8D0
		internal HttpHeaders(HttpHeaderKind headerKind); // 0x0000000187835C58-0x0000000187835C7C
	
		// Methods
		private bool AddInternal(string name, IEnumerable<string> values, System.Net.Http.Headers.HeaderInfo headerInfo, bool ignoreInvalid); // 0x0000000185381130-0x00000001853816E0
		public bool TryAddWithoutValidation(string name, IEnumerable<string> values); // 0x00000001853810B0-0x0000000185381130
		private System.Net.Http.Headers.HeaderInfo CheckName(string name); // 0x000000018CFD650C-0x000000018CFD6674
		private bool TryCheckName(string name, out System.Net.Http.Headers.HeaderInfo headerInfo); // 0x0000000185380DF0-0x0000000185380E90
		[IteratorStateMachine(typeof(_GetEnumerator_d__19))]
		public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator(); // 0x000000018537DD90-0x000000018537DDD0
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018CFD6A68-0x000000018CFD6A70
		public bool Remove(string name); // 0x000000018CFD6A04-0x000000018CFD6A68
		internal static string GetSingleHeaderString(string key, IEnumerable<string> values); // 0x000000018CFD6674-0x000000018CFD6A04
		public override string ToString(); // 0x000000018CFD6A70-0x000000018CFD6CA8
		internal void AddOrRemove<T>(string name, T value, Func<object, string> converter = null)
			where T : class;
		internal void AddOrRemove<T>(string name, T? value)
			where T : struct;
		internal void AddOrRemove<T>(string name, T? value, Func<object, string> converter)
			where T : struct;
		private List<string> GetAllHeaderValues(HeaderBucket bucket, System.Net.Http.Headers.HeaderInfo headerInfo); // 0x0000000186A3B130-0x0000000186A3B200
		internal static HttpHeaderKind GetKnownHeaderKind(string name); // 0x0000000185380ED0-0x0000000185380F60
		internal T GetValue<T>(string name);
		internal HttpHeaderValueCollection<T> GetValues<T>(string name)
			where T : class;
		internal void SetValue<T>(string name, T value, Func<object, string> toStringConverter = null);
	}

	public sealed class HttpRequestHeaders : HttpHeaders // TypeDefIndex: 89352
	{
		// Fields
		private bool? expectContinue; // 0x20
	
		// Properties
		public AuthenticationHeaderValue Authorization { set; } // 0x000000018CFD70C8-0x000000018CFD712C
		public HttpHeaderValueCollection<string> Connection { get; } // 0x0000000186EA46D0-0x0000000186EA4720 
		public bool? ConnectionClose { get; set; } // 0x0000000186EA4540-0x0000000186EA46D0 0x000000018CFD712C-0x000000018CFD7210
		public bool? ExpectContinue { get; } // 0x0000000186D36840-0x0000000186D369A0 
		public string Host { get; } // 0x000000018CFD707C-0x000000018CFD70C8 
		public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding { get; } // 0x0000000186D36B00-0x0000000186D36B50 
		public bool? TransferEncodingChunked { get; } // 0x0000000186D369A0-0x0000000186D36B00 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 89351
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<string> __9__19_0; // 0x08
			public static Predicate<TransferCodingHeaderValue> __9__29_0; // 0x10
			public static Predicate<TransferCodingHeaderValue> __9__71_0; // 0x18
	
			// Constructors
			static __c(); // 0x00000001871E6D40-0x00000001871E6DA0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _get_ConnectionClose_b__19_0(string l); // 0x000000018CFDE8CC-0x000000018CFDE910
			internal bool _get_ExpectContinue_b__29_0(TransferCodingHeaderValue l); // 0x000000018CFDE910-0x000000018CFDE960
			internal bool _get_TransferEncodingChunked_b__71_0(TransferCodingHeaderValue l); // 0x000000018CFDE960-0x000000018CFDE9B0
		}
	
		// Constructors
		internal HttpRequestHeaders(); // 0x00000001871F9920-0x00000001871F9980
	
		// Methods
		internal void AddHeaders(HttpRequestHeaders headers); // 0x000000018CFD6EC4-0x000000018CFD707C
	}

	public sealed class HttpResponseHeaders : HttpHeaders // TypeDefIndex: 89353
	{
		// Constructors
		internal HttpResponseHeaders(); // 0x00000001871F98C0-0x00000001871F9920
	}

	internal struct Token // TypeDefIndex: 89355
	{
		// Fields
		public static readonly Token Empty; // 0x00
		private readonly Type type; // 0x00
		[CompilerGenerated]
		private int _StartPosition_k__BackingField; // 0x04
		[CompilerGenerated]
		private int _EndPosition_k__BackingField; // 0x08
	
		// Properties
		public int StartPosition { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872342E0-0x00000001872342F0 0x0000000187235AB0-0x0000000187235AC0
		public int EndPosition { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000184431A70-0x0000000184431A80 0x0000000187235AA0-0x0000000187235AB0
		public Type Kind { get; } // 0x00000001844AD290-0x00000001844AD2A0 
	
		// Nested types
		public enum Type // TypeDefIndex: 89354
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
		public Token(Type type, int startPosition, int endPosition); // 0x0000000186898450-0x00000001868984A0
		static Token(); // 0x0000000186897C70-0x0000000186897CE0
	
		// Methods
		public static implicit operator Type(Token token); // 0x00000001844AD290-0x00000001844AD2A0
		public override string ToString(); // 0x000000018CFDD024-0x000000018CFDD078
	}

	internal class Lexer // TypeDefIndex: 89356
	{
		// Fields
		private static readonly bool[] token_chars; // 0x00
		private static readonly int last_token_char; // 0x08
		private static readonly string[] dt_formats; // 0x10
		private readonly string s; // 0x10
		private int pos; // 0x18
	
		// Properties
		public int Position { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
	
		// Constructors
		public Lexer(string stream); // 0x0000000184FD2410-0x0000000184FD2420
		static Lexer(); // 0x0000000186E77490-0x0000000186E77630
	
		// Methods
		public string GetStringValue(System.Net.Http.Headers.Token token); // 0x00000001868984A0-0x0000000186898500
		public string GetStringValue(System.Net.Http.Headers.Token start, System.Net.Http.Headers.Token end); // 0x000000018CFD77DC-0x000000018CFD7850
		public string GetQuotedStringValue(System.Net.Http.Headers.Token start); // 0x000000018CFD773C-0x000000018CFD77AC
		public string GetRemainingStringValue(int position); // 0x000000018CFD77AC-0x000000018CFD77DC
		public bool IsStarStringValue(System.Net.Http.Headers.Token token); // 0x000000018CFD7850-0x000000018CFD78D4
		public bool TryGetNumericValue(System.Net.Http.Headers.Token token, out int value); // 0x000000018CFD7C68-0x000000018CFD7CFC
		public bool TryGetNumericValue(System.Net.Http.Headers.Token token, out long value); // 0x000000018CFD7CFC-0x000000018CFD7D90
		public TimeSpan? TryGetTimeSpanValue(System.Net.Http.Headers.Token token); // 0x000000018CFD7D90-0x000000018CFD7E54
		public bool TryGetDateValue(System.Net.Http.Headers.Token token, out DateTimeOffset value); // 0x000000018CFD7A30-0x000000018CFD7B08
		public static bool TryGetDateValue(string text, out DateTimeOffset value); // 0x000000018CFD7B08-0x000000018CFD7BD0
		public bool TryGetDoubleValue(System.Net.Http.Headers.Token token, out double value); // 0x000000018CFD7BD0-0x000000018CFD7C68
		public static bool IsValidToken(string input); // 0x0000000185380FA0-0x0000000185381020
		public static bool IsValidCharacter(char input); // 0x0000000185381020-0x00000001853810B0
		public void EatChar(); // 0x000000018724B060-0x000000018724B070
		public int PeekChar(); // 0x000000018CFD78D4-0x000000018CFD7908
		public bool ScanCommentOptional(out string value, out System.Net.Http.Headers.Token readToken); // 0x000000018CFD7908-0x000000018CFD7A30
		public System.Net.Http.Headers.Token Scan(bool recognizeDash = false /* Metadata: 0x02648AF2 */); // 0x0000000186898230-0x0000000186898450
	}

	public class MediaTypeHeaderValue : ICloneable // TypeDefIndex: 89358
	{
		// Fields
		internal List<NameValueHeaderValue> parameters; // 0x10
		internal string media_type; // 0x18
	
		// Properties
		public string CharSet { get; set; } // 0x0000000186AE2010-0x0000000186AE2080 0x0000000186897AE0-0x0000000186897B90
		public string MediaType { set; } // 0x0000000186897CE0-0x0000000186897DE0
		public ICollection<NameValueHeaderValue> Parameters { get; } // 0x000000018CFD83B4-0x000000018CFD8438 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 89357
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<NameValueHeaderValue> __9__6_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CFDEA80-0x000000018CFDEAE4
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _get_CharSet_b__6_0(NameValueHeaderValue l); // 0x000000018CFDE87C-0x000000018CFDE8CC
		}
	
		// Constructors
		public MediaTypeHeaderValue(string mediaType); // 0x000000018537C170-0x000000018537C1D0
		protected MediaTypeHeaderValue(MediaTypeHeaderValue source); // 0x000000018CFD81BC-0x000000018CFD83B4
		internal MediaTypeHeaderValue(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		object ICloneable.Clone(); // 0x000000018CFD815C-0x000000018CFD81BC
		public override bool Equals(object obj); // 0x000000018CFD8060-0x000000018CFD80EC
		public override int GetHashCode(); // 0x000000018CFD80EC-0x000000018CFD815C
		public override string ToString(); // 0x0000000187206AE0-0x0000000187206B20
		public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue); // 0x0000000186897DE0-0x0000000186897F40
		internal static System.Net.Http.Headers.Token? TryParseMediaType(Lexer lexer, out string media); // 0x0000000186898070-0x0000000186898230
	}

	public sealed class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue // TypeDefIndex: 89359
	{
		// Constructors
		private MediaTypeWithQualityHeaderValue(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private static bool TryParseElement(Lexer lexer, out MediaTypeWithQualityHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018CFD8438-0x000000018CFD85BC
		internal static bool TryParse(string input, int minimalCount, out List<MediaTypeWithQualityHeaderValue> result); // 0x000000018CFD85BC-0x000000018CFD866C
	}

	public class NameValueHeaderValue : ICloneable // TypeDefIndex: 89360
	{
		// Fields
		internal string value; // 0x10
		[CompilerGenerated]
		private string _Name_k__BackingField; // 0x18
	
		// Properties
		public string Name { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public string Value { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000186897F40-0x0000000186898070
	
		// Constructors
		public NameValueHeaderValue(string name, string value); // 0x0000000186897C20-0x0000000186897C70
		protected internal NameValueHeaderValue(NameValueHeaderValue source); // 0x000000018CFDA000-0x000000018CFDA03C
		internal NameValueHeaderValue(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		internal static NameValueHeaderValue Create(string name, string value); // 0x000000018CFD992C-0x000000018CFD999C
		object ICloneable.Clone(); // 0x000000018CFD9A48-0x000000018CFD9AA8
		public override int GetHashCode(); // 0x000000018CFD24FC-0x000000018CFD2570
		public override bool Equals(object obj); // 0x000000018CFD999C-0x000000018CFD9A48
		internal static bool TryParsePragma(string input, int minimalCount, out List<NameValueHeaderValue> result); // 0x000000018CFD9F50-0x000000018CFDA000
		internal static bool TryParseParameters(Lexer lexer, out List<NameValueHeaderValue> result, out System.Net.Http.Headers.Token t); // 0x000000018CFD9CA4-0x000000018CFD9F50
		public override string ToString(); // 0x00000001871FD890-0x00000001871FD8C0
		private static bool TryParseElement(Lexer lexer, out NameValueHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018CFD9AA8-0x000000018CFD9CA4
	}

	public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable // TypeDefIndex: 89361
	{
		// Fields
		private List<NameValueHeaderValue> parameters; // 0x20
	
		// Properties
		public ICollection<NameValueHeaderValue> Parameters { get; } // 0x000000018CFDA658-0x000000018CFDA6DC 
	
		// Constructors
		protected NameValueWithParametersHeaderValue(NameValueWithParametersHeaderValue source); // 0x000000018CFDA504-0x000000018CFDA658
		private NameValueWithParametersHeaderValue(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		new object ICloneable.Clone(); // 0x000000018CFDA120-0x000000018CFDA180
		public override bool Equals(object obj); // 0x000000018CFDA03C-0x000000018CFDA0CC
		public override int GetHashCode(); // 0x000000018CFDA0CC-0x000000018CFDA120
		public override string ToString(); // 0x000000018CFDA180-0x000000018CFDA208
		internal static bool TryParse(string input, int minimalCount, out List<NameValueWithParametersHeaderValue> result); // 0x000000018CFDA454-0x000000018CFDA504
		private static bool TryParseElement(Lexer lexer, out NameValueWithParametersHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018CFDA208-0x000000018CFDA454
	}

	internal static class Parser // TypeDefIndex: 89373
	{
		// Nested types
		public static class Token // TypeDefIndex: 89362
		{
			// Methods
			public static void Check(string s); // 0x0000000185380500-0x0000000185380550
			public static bool TryCheck(string s); // 0x0000000185380F60-0x0000000185380FA0
		}
	
		public static class DateTime // TypeDefIndex: 89364
		{
			// Fields
			public static readonly Func<object, string> ToString; // 0x00
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 89363
			{
				// Fields
				public static readonly __c __9; // 0x00
	
				// Constructors
				static __c(); // 0x00000001871E4DC0-0x00000001871E4E20
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal string _.cctor_b__2_0(object l); // 0x000000018CFDE78C-0x000000018CFDE820
			}
	
			// Constructors
			static DateTime(); // 0x00000001870E29D0-0x00000001870E2AA0
	
			// Methods
			public static bool TryParse(string input, out DateTimeOffset result); // 0x000000018CFD57E8-0x000000018CFD5844
		}
	
		public static class EmailAddress // TypeDefIndex: 89365
		{
			// Methods
			public static bool TryParse(string input, out string result); // 0x000000018CFD5844-0x000000018CFD5938
		}
	
		public static class Host // TypeDefIndex: 89366
		{
			// Methods
			public static bool TryParse(string input, out string result); // 0x000000018CFD5F7C-0x000000018CFD601C
		}
	
		public static class Int // TypeDefIndex: 89367
		{
			// Methods
			public static bool TryParse(string input, out int result); // 0x000000018CFD76D8-0x000000018CFD773C
		}
	
		public static class Long // TypeDefIndex: 89368
		{
			// Methods
			public static bool TryParse(string input, out long result); // 0x000000018CFD7E54-0x000000018CFD7EB8
		}
	
		public static class MD5 // TypeDefIndex: 89370
		{
			// Fields
			public static readonly Func<object, string> ToString; // 0x00
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 89369
			{
				// Fields
				public static readonly __c __9; // 0x00
	
				// Constructors
				static __c(); // 0x000000018CFDEA1C-0x000000018CFDEA80
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal string _.cctor_b__2_0(object l); // 0x000000018CFDE820-0x000000018CFDE87C
			}
	
			// Constructors
			static MD5(); // 0x000000018CFD7F9C-0x000000018CFD8060
	
			// Methods
			public static bool TryParse(string input, out byte[] result); // 0x000000018CFD7EB8-0x000000018CFD7F9C
		}
	
		public static class TimeSpanSeconds // TypeDefIndex: 89371
		{
			// Methods
			public static bool TryParse(string input, out TimeSpan result); // 0x000000018CFDCF90-0x000000018CFDD024
		}
	
		public static class Uri // TypeDefIndex: 89372
		{
			// Methods
			public static bool TryParse(string input, out System.Uri result); // 0x000000018CFDEAE4-0x000000018CFDEB38
		}
	}

	public class ProductHeaderValue : ICloneable // TypeDefIndex: 89374
	{
		// Fields
		[CompilerGenerated]
		private string _Name_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Version_k__BackingField; // 0x18
	
		// Properties
		public string Name { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string Version { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		internal ProductHeaderValue(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		object ICloneable.Clone(); // 0x0000000185A39C10-0x0000000185A39C20
		public override bool Equals(object obj); // 0x000000018CFDA738-0x000000018CFDA7B8
		public override int GetHashCode(); // 0x000000018CFDA7B8-0x000000018CFDA824
		internal static bool TryParse(string input, int minimalCount, out List<ProductHeaderValue> result); // 0x000000018CFDAA5C-0x000000018CFDAB0C
		private static bool TryParseElement(Lexer lexer, out ProductHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018CFDA878-0x000000018CFDAA5C
		public override string ToString(); // 0x000000018CFDA824-0x000000018CFDA878
	}

	public class ProductInfoHeaderValue : ICloneable // TypeDefIndex: 89375
	{
		// Fields
		[CompilerGenerated]
		private string _Comment_k__BackingField; // 0x10
		[CompilerGenerated]
		private ProductHeaderValue _Product_k__BackingField; // 0x18
	
		// Properties
		public string Comment { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public ProductHeaderValue Product { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		public ProductInfoHeaderValue(ProductHeaderValue product); // 0x000000018CFDAF4C-0x000000018CFDAFB0
		private ProductInfoHeaderValue(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		object ICloneable.Clone(); // 0x0000000185A39C10-0x0000000185A39C20
		public override bool Equals(object obj); // 0x000000018CFDAB0C-0x000000018CFDAB80
		public override int GetHashCode(); // 0x000000018CFDAB80-0x000000018CFDABB0
		internal static bool TryParse(string input, int minimalCount, out List<ProductInfoHeaderValue> result); // 0x000000018CFDADF8-0x000000018CFDAF4C
		private static bool TryParseElement(Lexer lexer, out ProductInfoHeaderValue parsedValue); // 0x000000018CFDABD8-0x000000018CFDADF8
		public override string ToString(); // 0x000000018CFDABB0-0x000000018CFDABD8
	}

	public class RangeConditionHeaderValue : ICloneable // TypeDefIndex: 89376
	{
		// Fields
		[CompilerGenerated]
		private DateTimeOffset? _Date_k__BackingField; // 0x10
		[CompilerGenerated]
		private EntityTagHeaderValue _EntityTag_k__BackingField; // 0x28
	
		// Properties
		public DateTimeOffset? Date { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184430320-0x0000000184430340 0x0000000187247A80-0x0000000187247AA0
		public EntityTagHeaderValue EntityTag { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
	
		// Constructors
		public RangeConditionHeaderValue(DateTimeOffset date); // 0x000000018CFDB498-0x000000018CFDB4F8
		public RangeConditionHeaderValue(EntityTagHeaderValue entityTag); // 0x000000018CFDB4F8-0x000000018CFDB56C
	
		// Methods
		object ICloneable.Clone(); // 0x0000000185A39C10-0x0000000185A39C20
		public override bool Equals(object obj); // 0x000000018CFDAFB0-0x000000018CFDB0B4
		public override int GetHashCode(); // 0x000000018CFDB0B4-0x000000018CFDB120
		public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue); // 0x000000018CFDB204-0x000000018CFDB498
		public override string ToString(); // 0x000000018CFDB120-0x000000018CFDB204
	}

	public class RangeHeaderValue : ICloneable // TypeDefIndex: 89377
	{
		// Fields
		private List<RangeItemHeaderValue> ranges; // 0x10
		private string unit; // 0x18
	
		// Properties
		public ICollection<RangeItemHeaderValue> Ranges { get; } // 0x000000018CFDBE5C-0x000000018CFDBEE0 
		public string Unit { get; } // 0x0000000182234E30-0x0000000182234E40 
	
		// Constructors
		public RangeHeaderValue(); // 0x000000018CFDBE1C-0x000000018CFDBE5C
		private RangeHeaderValue(RangeHeaderValue source); // 0x000000018CFDBCC0-0x000000018CFDBE1C
	
		// Methods
		object ICloneable.Clone(); // 0x000000018CFDB668-0x000000018CFDB6C8
		public override bool Equals(object obj); // 0x000000018CFDB56C-0x000000018CFDB5F8
		public override int GetHashCode(); // 0x000000018CFDB5F8-0x000000018CFDB668
		public static bool TryParse(string input, out RangeHeaderValue parsedValue); // 0x000000018CFDB7EC-0x000000018CFDBCC0
		public override string ToString(); // 0x000000018CFDB6C8-0x000000018CFDB7EC
	}

	public class RangeItemHeaderValue : ICloneable // TypeDefIndex: 89378
	{
		// Fields
		[CompilerGenerated]
		private long? _From_k__BackingField; // 0x10
		[CompilerGenerated]
		private long? _To_k__BackingField; // 0x20
	
		// Properties
		public long? From { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184430480-0x0000000184430490 0x0000000187239680-0x0000000187239690
		public long? To { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187238F60-0x0000000187238F70 0x0000000187238F70-0x0000000187238F80
	
		// Constructors
		public RangeItemHeaderValue(long? from, long? to); // 0x000000018CFDC12C-0x000000018CFDC31C
	
		// Methods
		object ICloneable.Clone(); // 0x0000000185A39C10-0x0000000185A39C20
		public override bool Equals(object obj); // 0x000000018CFDBEE0-0x000000018CFDBF98
		public override int GetHashCode(); // 0x000000018CFDBF98-0x000000018CFDC008
		public override string ToString(); // 0x000000018CFDC008-0x000000018CFDC12C
	}

	public class RetryConditionHeaderValue : ICloneable // TypeDefIndex: 89379
	{
		// Fields
		[CompilerGenerated]
		private DateTimeOffset? _Date_k__BackingField; // 0x10
		[CompilerGenerated]
		private TimeSpan? _Delta_k__BackingField; // 0x28
	
		// Properties
		public DateTimeOffset? Date { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184430320-0x0000000184430340 0x0000000187247A80-0x0000000187247AA0
		public TimeSpan? Delta { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723D770-0x000000018723D780 0x000000018723D780-0x000000018723D790
	
		// Constructors
		public RetryConditionHeaderValue(DateTimeOffset date); // 0x000000018CFDC914-0x000000018CFDC974
		public RetryConditionHeaderValue(TimeSpan delta); // 0x000000018CFDC838-0x000000018CFDC914
	
		// Methods
		object ICloneable.Clone(); // 0x0000000185A39C10-0x0000000185A39C20
		public override bool Equals(object obj); // 0x000000018CFDC31C-0x000000018CFDC46C
		public override int GetHashCode(); // 0x000000018CFDC46C-0x000000018CFDC4F0
		public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue); // 0x000000018CFDC63C-0x000000018CFDC838
		public override string ToString(); // 0x000000018CFDC4F0-0x000000018CFDC63C
	}

	public class StringWithQualityHeaderValue : ICloneable // TypeDefIndex: 89380
	{
		// Fields
		[CompilerGenerated]
		private double? _Quality_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Value_k__BackingField; // 0x20
	
		// Properties
		public double? Quality { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184430480-0x0000000184430490 0x0000000187239680-0x0000000187239690
		public string Value { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
	
		// Constructors
		private StringWithQualityHeaderValue(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		object ICloneable.Clone(); // 0x0000000185A39C10-0x0000000185A39C20
		public override bool Equals(object obj); // 0x000000018CFDC9F4-0x000000018CFDCAC4
		public override int GetHashCode(); // 0x000000018CFDCAC4-0x000000018CFDCB40
		internal static bool TryParse(string input, int minimalCount, out List<StringWithQualityHeaderValue> result); // 0x000000018CFDCEE0-0x000000018CFDCF90
		private static bool TryParseElement(Lexer lexer, out StringWithQualityHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018CFDCC18-0x000000018CFDCEE0
		public override string ToString(); // 0x000000018CFDCB40-0x000000018CFDCC18
	}

	public class TransferCodingHeaderValue : ICloneable // TypeDefIndex: 89381
	{
		// Fields
		internal string value; // 0x10
		internal List<NameValueHeaderValue> parameters; // 0x18
	
		// Properties
		public ICollection<NameValueHeaderValue> Parameters { get; } // 0x000000018CFDD60C-0x000000018CFDD690 
		public string Value { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		protected TransferCodingHeaderValue(TransferCodingHeaderValue source); // 0x000000018CFDD464-0x000000018CFDD60C
		internal TransferCodingHeaderValue(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		object ICloneable.Clone(); // 0x000000018CFDD180-0x000000018CFDD1E0
		public override bool Equals(object obj); // 0x000000018CFDD078-0x000000018CFDD104
		public override int GetHashCode(); // 0x000000018CFDD104-0x000000018CFDD180
		public override string ToString(); // 0x000000018CFDD1E0-0x000000018CFDD238
		internal static bool TryParse(string input, int minimalCount, out List<TransferCodingHeaderValue> result); // 0x000000018CFDD3B4-0x000000018CFDD464
		private static bool TryParseElement(Lexer lexer, out TransferCodingHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018CFDD238-0x000000018CFDD3B4
	}

	public sealed class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue // TypeDefIndex: 89382
	{
		// Constructors
		private TransferCodingWithQualityHeaderValue(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		internal static bool TryParse(string input, int minimalCount, out List<TransferCodingWithQualityHeaderValue> result); // 0x000000018CFDECB4-0x000000018CFDED64
		private static bool TryParseElement(Lexer lexer, out TransferCodingWithQualityHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018CFDEB38-0x000000018CFDECB4
	}

	public class ViaHeaderValue : ICloneable // TypeDefIndex: 89383
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
		public string Comment { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string ProtocolName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public string ProtocolVersion { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public string ReceivedBy { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
	
		// Constructors
		private ViaHeaderValue(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		object ICloneable.Clone(); // 0x0000000185A39C10-0x0000000185A39C20
		public override bool Equals(object obj); // 0x000000018CFDED64-0x000000018CFDEE14
		public override int GetHashCode(); // 0x000000018CFDEE14-0x000000018CFDEEDC
		internal static bool TryParse(string input, int minimalCount, out List<ViaHeaderValue> result); // 0x000000018CFDF2F0-0x000000018CFDF3A0
		private static bool TryParseElement(Lexer lexer, out ViaHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018CFDEFEC-0x000000018CFDF2F0
		public override string ToString(); // 0x000000018CFDEEDC-0x000000018CFDEFEC
	}

	public class WarningHeaderValue : ICloneable // TypeDefIndex: 89384
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
		public string Agent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public int Code { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public DateTimeOffset? Date { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187235350-0x0000000187235370 0x0000000187258260-0x0000000187258280
		public string Text { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
	
		// Constructors
		private WarningHeaderValue(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private static bool IsCodeValid(int code); // 0x000000018CFDF580-0x000000018CFDF594
		object ICloneable.Clone(); // 0x0000000185A39C10-0x0000000185A39C20
		public override bool Equals(object obj); // 0x000000018CFDF3A0-0x000000018CFDF4CC
		public override int GetHashCode(); // 0x000000018CFDF4CC-0x000000018CFDF580
		internal static bool TryParse(string input, int minimalCount, out List<WarningHeaderValue> result); // 0x000000018CFDFA90-0x000000018CFDFD6C
		private static bool TryParseElement(Lexer lexer, out WarningHeaderValue parsedValue, out System.Net.Http.Headers.Token t); // 0x000000018CFDF77C-0x000000018CFDFA90
		public override string ToString(); // 0x000000018CFDF594-0x000000018CFDF77C
	}
}
