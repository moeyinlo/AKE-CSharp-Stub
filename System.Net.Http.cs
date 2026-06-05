/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Image 64: System.Net.Http.dll - Assembly: System.Net.Http, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59219-59302

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 59302
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_127 _1D59178A3E2B293760F6FE72820F96FEC4071964A5B9E4BB13F7EA51510A4729; // 0x00 // Static value (base64): AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAQABAQEBAQAAAQEAAQEAAQEBAQEBAQEBAQAAAAAAAAABAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQAAAAEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAAEAAQ== - Metadata: 0x02080564

	// Nested types
	private struct __StaticArrayInitTypeSize_127 // TypeDefIndex: 59301
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor

	// Methods
	internal static uint ComputeStringHash(string s) => default; // 0x0000000187809354-0x00000001878093A8
}

namespace System.Net.Http
{
	public class HttpClientHandler : HttpMessageHandler // TypeDefIndex: 59221
	{
		// Fields
		private readonly IMonoHttpClientHandler _delegatingHandler; // 0x10
		private ClientCertificateOption _clientCertificateOptions; // 0x18
	
		// Properties
		public ClientCertificateOption ClientCertificateOptions { get => default; set {} } // 0x000000018B95C178-0x000000018B95C1E8 0x000000018B95C0F4-0x000000018B95C178
		public X509CertificateCollection ClientCertificates { get => default; } // 0x000000018B95C260-0x000000018B95C27C 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59220
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static LocalCertificateSelectionCallback __9__23_1; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B95C04C-0x000000018B95C09C
			public __c() {} // 0x000000018B95C2A4-0x000000018B95C2C8
	
			// Methods
			internal X509Certificate _set_ClientCertificateOptions_b__23_1(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) => default; // 0x000000018B95C27C-0x000000018B95C2A4
		}
	
		// Constructors
		public HttpClientHandler() {} // 0x000000018B95C1E8-0x000000018B95C260
		internal HttpClientHandler(IMonoHttpClientHandler handler) {} // 0x00000001813AE560-0x00000001813AE570
	
		// Methods
		private static IMonoHttpClientHandler CreateDefaultHandler() => default; // 0x000000018B95C09C-0x000000018B95C0F4
		protected override void Dispose(bool disposing) {} // 0x000000018B95C3F8-0x000000018B95C5E0
		private void ThrowForModifiedManagedSslOptionsIfStarted() {} // 0x000000018B95C2C8-0x000000018B95C3F8
		internal void SetWebRequestTimeout(TimeSpan timeout) {} // 0x000000018B96E978-0x000000018B96E9DC
		protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) => default; // 0x0000000185492010-0x0000000185492020
		private X509Certificate _set_ClientCertificateOptions_b__23_0(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) => default; // 0x000000018B96E970-0x000000018B96E978
	}

	internal interface IMonoHttpClientHandler : IDisposable // TypeDefIndex: 59222
	{
		// Properties
		SslClientAuthenticationOptions SslOptions { get; set; }
	
		// Methods
		Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
		void SetWebRequestTimeout(TimeSpan timeout);
	}

	internal class MonoWebRequestHandler : IMonoHttpClientHandler // TypeDefIndex: 59225
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
		public CookieContainer CookieContainer { get => default; } // 0x000000018B963D6C-0x000000018B96458C 
		public long MaxRequestContentBufferSize { get => default; } // 0x000000018B963BD0-0x000000018B963D6C 
		public SslClientAuthenticationOptions SslOptions { get => default; set {} } // 0x000000018B964794-0x000000018B964874 0x000000018B964874-0x000000018B964980
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59223
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, bool> __9__95_0; // 0x08
			public static Func<string, bool> __9__96_0; // 0x10
			public static Action<object> __9__99_0; // 0x18
	
			// Constructors
			static __c() {} // 0x000000018B9649D8-0x000000018B964B2C
			public __c() {} // 0x000000018B964608-0x000000018B964674
	
			// Methods
			internal bool _GetConnectionKeepAlive_b__95_0(string l) => default; // 0x000000018B964B2C-0x000000018B964BA0
			internal bool _CreateWebRequest_b__96_0(string l) => default; // 0x00000001813B51D0-0x00000001813B51E0
			internal void _SendAsync_b__99_0(object l) {} // 0x000000018B964BA0-0x000000018B964C04
		}
	
		private struct _SendAsync_d__99 : IAsyncStateMachine // TypeDefIndex: 59224
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
			private void MoveNext() {} // 0x000000018B964C04-0x000000018B964C34
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018B9645FC-0x000000018B964608
		}
	
		// Constructors
		public MonoWebRequestHandler() {} // 0x000000018B96458C-0x000000018B9645FC
	
		// Methods
		internal void EnsureModifiability() {} // 0x000000018B964674-0x000000018B964794
		public void Dispose() {} // 0x000000018B964980-0x000000018B9649D8
		protected virtual void Dispose(bool disposing) {} // 0x000000018B96EB08-0x000000018B96EB6C
		private bool GetConnectionKeepAlive(HttpRequestHeaders headers) => default; // 0x0000000185492010-0x0000000185492020
		internal virtual HttpWebRequest CreateWebRequest(HttpRequestMessage request) => default; // 0x000000018B96E6A8-0x000000018B96E6EC
		private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken) => default; // 0x000000018B96E66C-0x000000018B96E6A8
		private static bool MethodHasBody(HttpMethod method) => default; // 0x000000018B96E6EC-0x000000018B96E74C
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) => default; // 0x000000018B96AE98-0x000000018B96CF18
		void IMonoHttpClientHandler.SetWebRequestTimeout(TimeSpan timeout) {} // 0x000000018B96CF18-0x000000018B96CF78
	}

	internal static class PlatformHelper // TypeDefIndex: 59226
	{
		// Methods
		internal static bool IsContentHeader(string name) => default; // 0x000000018B966CDC-0x000000018B966D24
		internal static string GetSingleHeaderString(string name, IEnumerable<string> values) => default; // 0x000000018B966C80-0x000000018B966CDC
		internal static StreamContent CreateStreamContent(Stream stream, CancellationToken cancellationToken) => default; // 0x000000018B966C10-0x000000018B966C80
	}

	public class ByteArrayContent : HttpContent // TypeDefIndex: 59227
	{
		// Fields
		private readonly byte[] content; // 0x28
		private readonly int offset; // 0x30
		private readonly int count; // 0x34
	
		// Constructors
		public ByteArrayContent() {} // Dummy constructor
		public ByteArrayContent(byte[] content) {} // 0x000000018B958358-0x000000018B9583D8
	
		// Methods
		protected override System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context) => default; // 0x000000018B958324-0x000000018B958358
		protected internal override bool TryComputeLength(out long length) {
			length = default;
			return default;
		} // 0x0000000185FD6200-0x0000000185FD6210
	}

	public enum ClientCertificateOption // TypeDefIndex: 59228
	{
		Manual = 0,
		Automatic = 1
	}

	public class HttpClient : HttpMessageInvoker // TypeDefIndex: 59230
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
		public HttpRequestHeaders DefaultRequestHeaders { get => default; } // 0x000000018B95C5E0-0x000000018B95C640 
		public long MaxResponseContentBufferSize { get => default; } // 0x000000018B95C640-0x000000018B95C730 
	
		// Nested types
		private struct _SendAsyncWorker_d__47 : IAsyncStateMachine // TypeDefIndex: 59229
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
			private void MoveNext() {} // 0x000000018B95CD28-0x000000018B95CD90
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018B95CC64-0x000000018B95CD28
		}
	
		// Constructors
		public HttpClient() {} // 0x000000018B95CD90-0x000000018B95CE04
		public HttpClient(HttpMessageHandler handler, bool disposeHandler) {} // 0x00000001813FF010-0x00000001813FF020
		static HttpClient() {} // 0x000000018B96CF78-0x000000018B96D6A8
	
		// Methods
		protected override void Dispose(bool disposing) {} // 0x000000018B95C848-0x000000018B95C8A4
		public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content) => default; // 0x000000018B95CBDC-0x000000018B95CBFC
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) => default; // 0x000000018B95C8A4-0x000000018B95CBDC
		public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) => default; // 0x000000018B95C730-0x000000018B95C848
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) => default; // 0x000000018B95CC04-0x000000018B95CC64
		private Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) => default; // 0x000000018B95CBFC-0x000000018B95CC04
		private Task<HttpResponseMessage> __n__0(HttpRequestMessage request, CancellationToken cancellationToken) => default; // 0x000000018B96D6A8-0x000000018B96D708
	}

	public enum HttpCompletionOption // TypeDefIndex: 59231
	{
		ResponseContentRead = 0,
		ResponseHeadersRead = 1
	}

	public abstract class HttpContent : IDisposable // TypeDefIndex: 59235
	{
		// Fields
		private FixedMemoryStream buffer; // 0x10
		private bool disposed; // 0x18
		private HttpContentHeaders headers; // 0x20
	
		// Properties
		public HttpContentHeaders Headers { get; } // 0x000000018B95D3B4-0x000000018B95D47C 
		internal long? LoadedBufferLength { get; } // 0x000000018B95D48C-0x000000018B95D560 
	
		// Nested types
		private sealed class FixedMemoryStream : MemoryStream // TypeDefIndex: 59232
		{
			// Fields
			private readonly long maxSize; // 0x50
	
			// Constructors
			public FixedMemoryStream() {} // Dummy constructor
			public FixedMemoryStream(long maxSize) {} // 0x000000018B95D5CC-0x000000018B95D644
	
			// Methods
			private void CheckOverflow(int count) {} // 0x000000018B95D644-0x000000018B95D6C0
			public override void WriteByte(byte value) {} // 0x000000018B95D150-0x000000018B95D15C
			public override void Write(byte[] buffer, int offset, int count) {} // 0x000000018B95D15C-0x000000018B95D1EC
		}
	
		private struct _LoadIntoBufferAsync_d__17 : IAsyncStateMachine // TypeDefIndex: 59233
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public HttpContent __4__this; // 0x20
			public long maxBufferSize; // 0x28
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1; // 0x30
	
			// Methods
			private void MoveNext() {} // 0x000000018B95D1EC-0x000000018B95D24C
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018B95D274-0x000000018B95D284
		}
	
		private struct _ReadAsStringAsync_d__20 : IAsyncStateMachine // TypeDefIndex: 59234
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<string> __t__builder; // 0x08
			public HttpContent __4__this; // 0x20
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1; // 0x28
	
			// Methods
			private void MoveNext() {} // 0x000000018B95D24C-0x000000018B95D274
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018B95D47C-0x000000018B95D48C
		}
	
		// Constructors
		protected HttpContent() {} // 0x000000018B96AE38-0x000000018B96AE98
	
		// Methods
		public System.Threading.Tasks.Task CopyToAsync(Stream stream) => default; // 0x000000018B95D284-0x000000018B95D3B4
		public System.Threading.Tasks.Task CopyToAsync(Stream stream, TransportContext context) => default; // 0x000000018B95D570-0x000000018B95D5CC
		private static FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize) => default; // 0x000000018B95D560-0x000000018B95D570
		public void Dispose() {}
		protected virtual void Dispose(bool disposing) {}
		public System.Threading.Tasks.Task LoadIntoBufferAsync() => default; // 0x0000000185492010-0x0000000185492020
		public System.Threading.Tasks.Task LoadIntoBufferAsync(long maxBufferSize) => default; // 0x000000018B95BDC4-0x000000018B95BDF0
		public Task<string> ReadAsStringAsync() => default; // 0x000000018B95BC70-0x000000018B95BD30
		private static Encoding GetEncodingFromBuffer(byte[] buffer, int length, ref int preambleLength) => default; // 0x000000018B95BD30-0x000000018B95BD68
		private static int StartsWith(byte[] array, int length, byte[] value) => default; // 0x000000018B95BD68-0x000000018B95BDC4
		internal System.Threading.Tasks.Task SerializeToStreamAsync_internal(Stream stream, TransportContext context) => default; // 0x000000018B96A800-0x000000018B96AA78
		protected abstract System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context); // 0x000000018B96AA78-0x000000018B96AAD4
		protected internal abstract bool TryComputeLength(out long length); // 0x000000018B96AAD4-0x000000018B96AE38
	}

	public abstract class HttpMessageHandler : IDisposable // TypeDefIndex: 59236
	{
		// Constructors
		protected HttpMessageHandler() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Dispose() {} // 0x000000018B95D274-0x000000018B95D284
		protected virtual void Dispose(bool disposing) {} // 0x0000000185492010-0x0000000185492020
		protected internal abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
	}

	public class HttpMessageInvoker : IDisposable // TypeDefIndex: 59237
	{
		// Fields
		private protected HttpMessageHandler handler; // 0x10
		private readonly bool disposeHandler; // 0x18
	
		// Constructors
		public HttpMessageInvoker() {} // Dummy constructor
		public HttpMessageInvoker(HttpMessageHandler handler, bool disposeHandler) {} // 0x000000018B9605C8-0x000000018B960644
	
		// Methods
		public void Dispose() {} // 0x000000018B95D274-0x000000018B95D284
		protected virtual void Dispose(bool disposing) {} // 0x000000018B960538-0x000000018B960570
		public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) => default; // 0x000000018B960570-0x000000018B9605C8
	}

	public class HttpMethod : IEquatable<HttpMethod> // TypeDefIndex: 59238
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
		public string Method { get => default; } // 0x000000018346D130-0x000000018346D140 
		public static HttpMethod Post { get => default; } // 0x000000018B960A1C-0x000000018B960A6C 
	
		// Constructors
		public HttpMethod() {} // Dummy constructor
		public HttpMethod(string method) {} // 0x000000018B96098C-0x000000018B960A1C
		static HttpMethod() {} // 0x000000018B9606CC-0x000000018B96098C
	
		// Methods
		public static bool operator ==(HttpMethod left, HttpMethod right) => default; // 0x000000018B960A6C-0x000000018B960A88
		public bool Equals(HttpMethod other) => default; // 0x000000018B960644-0x000000018B960670
		public override bool Equals(object obj) => default; // 0x000000018B960670-0x000000018B9606CC
		public override int GetHashCode() => default; // 0x00000001891011C8-0x00000001891011EC
		public override string ToString() => default; // 0x000000018346D130-0x000000018346D140
	}

	[Serializable]
	public class HttpRequestException : Exception // TypeDefIndex: 59239
	{
		// Constructors
		public HttpRequestException() {} // 0x000000018B960A88-0x000000018B960AD4
		public HttpRequestException(string message) {} // 0x000000018B960AD4-0x000000018B960B30
		public HttpRequestException(string message, Exception inner) {} // 0x000000018B960B30-0x000000018B960B90
	}

	public class HttpRequestMessage : IDisposable // TypeDefIndex: 59240
	{
		// Fields
		private HttpRequestHeaders headers; // 0x10
		private HttpMethod method; // 0x18
		private System.Version version; // 0x20
		private System.Uri uri; // 0x28
		private bool is_used; // 0x30
		private bool disposed; // 0x31
		private HttpContent _Content_k__BackingField; // 0x38
	
		// Properties
		public HttpContent Content { get; set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		public HttpRequestHeaders Headers { get => default; } // 0x000000018B961890-0x000000018B961904 
		public HttpMethod Method { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x000000018B961958-0x000000018B961A00
		public System.Uri RequestUri { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x000000018B961A00-0x000000018B961AC0
		public System.Version Version { get => default; } // 0x000000018B961904-0x000000018B961958 
	
		// Constructors
		public HttpRequestMessage() {} // Dummy constructor
		public HttpRequestMessage(HttpMethod method, string requestUri) {} // 0x000000018B9617C8-0x000000018B961860
		public HttpRequestMessage(HttpMethod method, System.Uri requestUri) {} // 0x000000018B961860-0x000000018B961890
	
		// Methods
		private static bool IsAllowedAbsoluteUri(System.Uri uri) => default; // 0x000000018B96143C-0x000000018B96156C
		public void Dispose() {} // 0x000000018B961404-0x000000018B961410
		protected virtual void Dispose(bool disposing) {} // 0x000000018B961410-0x000000018B96143C
		internal bool SetIsUsed() => default; // 0x000000018B96156C-0x000000018B96157C
		public override string ToString() => default; // 0x000000018B96157C-0x000000018B9617C8
	}

	public class HttpResponseMessage : IDisposable // TypeDefIndex: 59241
	{
		// Fields
		private HttpResponseHeaders headers; // 0x10
		private string reasonPhrase; // 0x18
		private HttpStatusCode statusCode; // 0x20
		private System.Version version; // 0x28
		private bool disposed; // 0x30
		private HttpContent _Content_k__BackingField; // 0x38
		private HttpRequestMessage _RequestMessage_k__BackingField; // 0x40
	
		// Properties
		public HttpContent Content { get; set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		public HttpResponseHeaders Headers { get => default; } // 0x000000018B961D68-0x000000018B961DDC 
		public string ReasonPhrase { get => default; set {} } // 0x000000018B961DDC-0x000000018B961DF0 0x0000000184088E70-0x0000000184088E80
		public HttpRequestMessage RequestMessage { get; set; } // 0x0000000185F05C80-0x0000000185F05C90
		public HttpStatusCode StatusCode { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x000000018B961E44-0x000000018B961E9C
		public System.Version Version { get => default; } // 0x000000018B961DF0-0x000000018B961E44 
	
		// Constructors
		public HttpResponseMessage() {} // Dummy constructor
		public HttpResponseMessage(HttpStatusCode statusCode) {} // 0x000000018B961D60-0x000000018B961D68
	
		// Methods
		public void Dispose() {} // 0x000000018B961B14-0x000000018B961B20
		protected virtual void Dispose(bool disposing) {} // 0x000000018B961B20-0x000000018B961B4C
		public override string ToString() => default; // 0x000000018B961B4C-0x000000018B961D60
	}

	public class MultipartContent : HttpContent, IEnumerable<HttpContent> // TypeDefIndex: 59243
	{
		// Fields
		private List<HttpContent> nested_content; // 0x28
		private readonly string boundary; // 0x30
	
		// Nested types
		private struct _SerializeToStreamAsync_d__8 : IAsyncStateMachine // TypeDefIndex: 59242
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
			private void MoveNext() {} // 0x000000018B965520-0x000000018B9655BC
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x000000018B9655BC-0x000000018B96591C
		}
	
		// Constructors
		public MultipartContent() {} // Dummy constructor
		public MultipartContent(string subtype) {} // 0x000000018B964F5C-0x000000018B965014
		public MultipartContent(string subtype, string boundary) {} // 0x000000018B964C34-0x000000018B964D34
	
		// Methods
		private static bool IsValidRFC2049(string s) => default; // 0x000000018B964D34-0x000000018B964EDC
		public virtual void Add(HttpContent content) {} // 0x000000018B965014-0x000000018B965100
		protected override void Dispose(bool disposing) {} // 0x000000018B965180-0x000000018B965520
		protected override System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context) => default; // 0x000000018B964EDC-0x000000018B964F5C
		protected internal override bool TryComputeLength(out long length) {
			length = default;
			return default;
		} // 0x000000018B965100-0x000000018B965180
		public IEnumerator<HttpContent> GetEnumerator() => default; // 0x000000018B96D708-0x000000018B96E610
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018B96E610-0x000000018B96E66C
	}

	public class MultipartFormDataContent : MultipartContent // TypeDefIndex: 59244
	{
		// Constructors
		public MultipartFormDataContent() {} // 0x000000018B965C0C-0x000000018B965C48
	
		// Methods
		public override void Add(HttpContent content) {} // 0x000000018B965BCC-0x000000018B965C0C
		public void Add(HttpContent content, string name) {} // 0x000000018B965A08-0x000000018B965AB4
		public void Add(HttpContent content, string name, string fileName) {} // 0x000000018B965AB4-0x000000018B965BCC
		private void AddContentDisposition(HttpContent content, string name, string fileName) {} // 0x000000018B96591C-0x000000018B965A08
	}

	public class StreamContent : HttpContent // TypeDefIndex: 59245
	{
		// Fields
		private readonly Stream content; // 0x28
		private readonly int bufferSize; // 0x30
		private readonly CancellationToken cancellationToken; // 0x38
		private readonly long startPosition; // 0x40
		private bool contentCopied; // 0x48
	
		// Constructors
		public StreamContent() {} // Dummy constructor
		public StreamContent(Stream content) {} // 0x000000018B9691B4-0x000000018B9691C4
		public StreamContent(Stream content, int bufferSize) {} // 0x000000018B9690B0-0x000000018B9691B4
		internal StreamContent(Stream content, CancellationToken cancellationToken) {} // 0x000000018B9691C4-0x000000018B9691FC
	
		// Methods
		protected override void Dispose(bool disposing) {} // 0x000000018B968F38-0x000000018B968F80
		protected override System.Threading.Tasks.Task SerializeToStreamAsync(Stream stream, TransportContext context) => default; // 0x000000018B968F80-0x000000018B969054
		protected internal override bool TryComputeLength(out long length) {
			length = default;
			return default;
		} // 0x000000018B969054-0x000000018B9690B0
	}

	public class StringContent : ByteArrayContent // TypeDefIndex: 59246
	{
		// Constructors
		public StringContent() {} // Dummy constructor
		public StringContent(string content) {} // 0x000000018B969234-0x000000018B969254
		public StringContent(string content, Encoding encoding, string mediaType) {} // 0x000000018B969254-0x000000018B969354
	
		// Methods
		private static byte[] GetByteArray(string content, Encoding encoding) => default; // 0x000000018B9691FC-0x000000018B969234
	}
}

namespace System.Net.Http.Headers
{
	public class AuthenticationHeaderValue : ICloneable // TypeDefIndex: 59247
	{
		// Fields
		private string _Parameter_k__BackingField; // 0x10
		private string _Scheme_k__BackingField; // 0x18
	
		// Properties
		public string Parameter { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public string Scheme { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public AuthenticationHeaderValue(string scheme, string parameter) {} // 0x000000018B9582D8-0x000000018B958324
		private AuthenticationHeaderValue() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000184690EB0-0x0000000184690EC0
		public override bool Equals(object obj) => default; // 0x000000018B957E80-0x000000018B957EFC
		public override int GetHashCode() => default; // 0x000000018B957EFC-0x000000018B957F70
		public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x000000018B95816C-0x000000018B958228
		internal static bool TryParse(string input, int minimalCount, out List<AuthenticationHeaderValue> result) {
			result = default;
			return default;
		} // 0x000000018B958228-0x000000018B9582D8
		private static bool TryParseElement(Lexer lexer, out AuthenticationHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x000000018B957FBC-0x000000018B95816C
		public override string ToString() => default; // 0x000000018B957F70-0x000000018B957FBC
	}

	public class CacheControlHeaderValue : ICloneable // TypeDefIndex: 59248
	{
		// Fields
		private List<NameValueHeaderValue> extensions; // 0x10
		private List<string> no_cache_headers; // 0x18
		private List<string> private_headers; // 0x20
		private TimeSpan? _MaxAge_k__BackingField; // 0x28
		private bool _MaxStale_k__BackingField; // 0x38
		private TimeSpan? _MaxStaleLimit_k__BackingField; // 0x40
		private TimeSpan? _MinFresh_k__BackingField; // 0x50
		private bool _MustRevalidate_k__BackingField; // 0x60
		private bool _NoCache_k__BackingField; // 0x61
		private bool _NoStore_k__BackingField; // 0x62
		private bool _NoTransform_k__BackingField; // 0x63
		private bool _OnlyIfCached_k__BackingField; // 0x64
		private bool _Private_k__BackingField; // 0x65
		private bool _ProxyRevalidate_k__BackingField; // 0x66
		private bool _Public_k__BackingField; // 0x67
		private TimeSpan? _SharedMaxAge_k__BackingField; // 0x68
	
		// Properties
		public ICollection<NameValueHeaderValue> Extensions { get => default; } // 0x000000018B959BB0-0x000000018B959C34 
		public TimeSpan? MaxAge { get; set; } // 0x0000000185FBB610-0x0000000185FBB620 0x0000000185FBB620-0x0000000185FBB630
		public bool MaxStale { get; set; } // 0x0000000185FB0700-0x0000000185FB0710 0x0000000185FAFE20-0x0000000185FAFE30
		public TimeSpan? MaxStaleLimit { get; set; } // 0x0000000185FBBFF0-0x0000000185FBC000 0x0000000185FBEB30-0x0000000185FBEB40
		public TimeSpan? MinFresh { get; set; } // 0x0000000185FB6BD0-0x0000000185FB6BE0 0x0000000185FBC330-0x0000000185FBC340
		public bool MustRevalidate { get; set; } // 0x000000018386C570-0x000000018386C580 0x000000018386C580-0x000000018386C590
		public bool NoCache { get; set; } // 0x0000000185FB32C0-0x0000000185FB32D0 0x0000000185FBCA60-0x0000000185FBCA70
		public ICollection<string> NoCacheHeaders { get => default; } // 0x000000018B959C34-0x000000018B959CB8 
		public bool NoStore { get; set; } // 0x0000000185FBCA50-0x0000000185FBCA60 0x0000000185FBCA70-0x0000000185FBCA80
		public bool NoTransform { get; set; } // 0x0000000185FBCA40-0x0000000185FBCA50 0x0000000185FD6220-0x0000000185FD6230
		public bool OnlyIfCached { get; set; } // 0x0000000185FBA670-0x0000000185FBA680 0x0000000185FBA680-0x0000000185FBA690
		public bool Private { get; set; } // 0x0000000185FBDF90-0x0000000185FBDFA0 0x0000000185FCDB60-0x0000000185FCDB70
		public ICollection<string> PrivateHeaders { get => default; } // 0x000000018B959CB8-0x000000018B959D3C 
		public bool ProxyRevalidate { get; set; } // 0x0000000185FBDFC0-0x0000000185FBDFD0 0x0000000185FBDFD0-0x0000000185FBDFE0
		public bool Public { get; set; } // 0x0000000185FD6210-0x0000000185FD6220 0x0000000185FD6230-0x0000000185FD6240
		public TimeSpan? SharedMaxAge { get; set; } // 0x0000000185FBECA0-0x0000000185FBECB0 0x0000000185FD2730-0x0000000185FD2740
	
		// Constructors
		public CacheControlHeaderValue() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		object ICloneable.Clone() => default; // 0x000000018B958840-0x000000018B958D74
		public override bool Equals(object obj) => default; // 0x000000018B9583D8-0x000000018B95861C
		public override int GetHashCode() => default; // 0x000000018B95861C-0x000000018B958840
		public static bool TryParse(string input, out CacheControlHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x000000018B9593B8-0x000000018B959BB0
		public override string ToString() => default; // 0x000000018B958D74-0x000000018B9593B8
	}

	internal static class CollectionExtensions // TypeDefIndex: 59249
	{
		// Methods
		public static bool SequenceEqual<TSource>(List<TSource> first, List<TSource> second) => default;
		public static void SetValue(List<NameValueHeaderValue> parameters, string key, string value) {} // 0x000000018B959D3C-0x000000018B959E84
		public static string ToString<T>(List<T> list) => default;
		public static void ToStringBuilder<T>(List<T> list, StringBuilder sb) {}
	}

	internal delegate bool ElementTryParser<T>(Lexer lexer, out ref T parsedValue, out System.Net.Http.Headers.Token token); // TypeDefIndex: 59250; 0x00000000-0x00000000

	internal static class CollectionParser // TypeDefIndex: 59251
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
		} // 0x000000018B959F8C-0x000000018B95A03C
		private static bool TryParseStringElement(Lexer lexer, out string parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x000000018B959E84-0x000000018B959F8C
	}

	public class ContentDispositionHeaderValue : ICloneable // TypeDefIndex: 59252
	{
		// Fields
		private string dispositionType; // 0x10
		private List<NameValueHeaderValue> parameters; // 0x18
	
		// Properties
		public string DispositionType { set {} } // 0x000000018B95AB40-0x000000018B95AB74
		public string FileName { set {} } // 0x000000018B95ABD4-0x000000018B95AC34
		public string FileNameStar { set {} } // 0x000000018B95AB74-0x000000018B95ABD4
		public string Name { set {} } // 0x000000018B95AC34-0x000000018B95AC94
		public ICollection<NameValueHeaderValue> Parameters { get => default; } // 0x000000018B95AABC-0x000000018B95AB40 
	
		// Constructors
		private ContentDispositionHeaderValue() {} // 0x0000000185492010-0x0000000185492020
		public ContentDispositionHeaderValue(string dispositionType) {} // 0x000000018B95AAB4-0x000000018B95AABC
		protected ContentDispositionHeaderValue(ContentDispositionHeaderValue source) {} // 0x000000018B95A7D8-0x000000018B95AAB4
	
		// Methods
		object ICloneable.Clone() => default; // 0x000000018B95A594-0x000000018B95A5F4
		public override bool Equals(object obj) => default; // 0x000000018B95A3F0-0x000000018B95A47C
		private static string EncodeBase64Value(string value) => default; // 0x000000018B95A03C-0x000000018B95A1C8
		private static string EncodeRFC5987(string value) => default; // 0x000000018B95A1C8-0x000000018B95A3F0
		public override int GetHashCode() => default; // 0x000000018B95A47C-0x000000018B95A4EC
		private void SetValue(string key, string value) {} // 0x000000018B95A4EC-0x000000018B95A594
		public override string ToString() => default; // 0x000000018B95A5F4-0x000000018B95A64C
		public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x000000018B95A64C-0x000000018B95A7D8
	}

	public class ContentRangeHeaderValue : ICloneable // TypeDefIndex: 59253
	{
		// Fields
		private string unit; // 0x10
		private long? _From_k__BackingField; // 0x18
		private long? _Length_k__BackingField; // 0x28
		private long? _To_k__BackingField; // 0x38
	
		// Properties
		public long? From { get; private set; } // 0x0000000185FB30D0-0x0000000185FB30E0 0x0000000185FB30E0-0x0000000185FB30F0
		public long? Length { get; private set; } // 0x0000000185FBB610-0x0000000185FBB620 0x0000000185FBB620-0x0000000185FBB630
		public long? To { get; private set; } // 0x0000000185FBB850-0x0000000185FBB860 0x0000000185FBD980-0x0000000185FBD990
		public string Unit { get => default; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		private ContentRangeHeaderValue() {} // 0x000000018B95B4A8-0x000000018B95B4E8
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000184690EB0-0x0000000184690EC0
		public override bool Equals(object obj) => default; // 0x000000018B95AC94-0x000000018B95AD70
		public override int GetHashCode() => default; // 0x000000018B95AD70-0x000000018B95AE68
		public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x000000018B95B078-0x000000018B95B4A8
		public override string ToString() => default; // 0x000000018B95AE68-0x000000018B95B078
	}

	public class EntityTagHeaderValue : ICloneable // TypeDefIndex: 59254
	{
		// Fields
		private static readonly EntityTagHeaderValue any; // 0x00
		private bool _IsWeak_k__BackingField; // 0x10
		private string _Tag_k__BackingField; // 0x18
	
		// Properties
		public bool IsWeak { get; internal set; } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
		public string Tag { get; internal set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		internal EntityTagHeaderValue() {} // 0x0000000185492010-0x0000000185492020
		static EntityTagHeaderValue() {} // 0x000000018B95BBEC-0x000000018B95BC70
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000184690EB0-0x0000000184690EC0
		public override bool Equals(object obj) => default; // 0x000000018B95B6F8-0x000000018B95B774
		public override int GetHashCode() => default; // 0x000000018B95B774-0x000000018B95B7E4
		public static bool TryParse(string input, out EntityTagHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x000000018B95BA68-0x000000018B95BB3C
		private static bool TryParseElement(Lexer lexer, out EntityTagHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x000000018B95B82C-0x000000018B95BA68
		internal static bool TryParse(string input, int minimalCount, out List<EntityTagHeaderValue> result) {
			result = default;
			return default;
		} // 0x000000018B95BB3C-0x000000018B95BBEC
		public override string ToString() => default; // 0x000000018B95B7E4-0x000000018B95B82C
	}

	internal static class HashCodeCalculator // TypeDefIndex: 59255
	{
		// Methods
		public static int Calculate<T>(ICollection<T> list) => default;
	}

	internal delegate bool TryParseDelegate<T>(string value, out ref T result); // TypeDefIndex: 59256; 0x00000000-0x00000000

	internal delegate bool TryParseListDelegate<T>(string value, int minimalCount, out List<T> result); // TypeDefIndex: 59257; 0x00000000-0x00000000

	internal abstract class HeaderInfo // TypeDefIndex: 59260
	{
		// Fields
		public bool AllowsMany; // 0x10
		public readonly HttpHeaderKind HeaderKind; // 0x14
		public readonly string Name; // 0x18
		private Func<object, string> _CustomToString_k__BackingField; // 0x20
	
		// Properties
		public Func<object, string> CustomToString { get; private set; }
		public virtual string Separator { get; }
	
		// Nested types
		private class HeaderTypeInfo<T, U> : HeaderInfo // TypeDefIndex: 59258
			where U : class
		{
			// Fields
			private readonly TryParseDelegate<T> parser;
	
			// Constructors
			public HeaderTypeInfo() {} // Dummy constructor
			public HeaderTypeInfo(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind) {} // 0x000000018B95BF44-0x000000018B95BF64
	
			// Methods
			public override void AddToCollection(object collection, object value) {}
			protected override object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo) => default;
			public override List<string> ToStringCollection(object collection) => default; // 0x000000018B95BF04-0x000000018B95BF44
			public override bool TryParse(string value, out object result) {
				result = default;
				return default;
			} // 0x00000001813B31A0-0x00000001813B31B0
		}
	
		private class CollectionHeaderTypeInfo<T, U> : HeaderTypeInfo<T, U> // TypeDefIndex: 59259
			where U : class
		{
			// Fields
			private readonly int minimalCount;
			private readonly string separator;
			private readonly TryParseListDelegate<T> parser;
	
			// Properties
			public override string Separator { get => default; } // 0x000000018B95BF64-0x000000018B95BFB0 
	
			// Constructors
			public CollectionHeaderTypeInfo() {} // Dummy constructor
			public CollectionHeaderTypeInfo(string name, TryParseListDelegate<T> parser, HttpHeaderKind headerKind, int minimalCount, string separator) {} // 0x000000018646EE40-0x000000018646EE50
	
			// Methods
			public override bool TryParse(string value, out object result) {
				result = default;
				return default;
			}
		}
	
		// Constructors
		protected HeaderInfo() {} // Dummy constructor
		protected HeaderInfo(string name, HttpHeaderKind headerKind) {}
	
		// Methods
		public static HeaderInfo CreateSingle<T>(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind, Func<object, string> toString = null) => default;
		public static HeaderInfo CreateMulti<T>(string name, TryParseListDelegate<T> elementParser, HttpHeaderKind headerKind, int minimalCount = 1 /* Metadata: 0x0208054D */, string separator = ", " /* Metadata: 0x0208054E */)
			where T : class => default;
		public object CreateCollection(HttpHeaders headers) => default;
		public abstract void AddToCollection(object collection, object value);
		protected abstract object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo);
		public abstract List<string> ToStringCollection(object collection);
		public abstract bool TryParse(string value, out object result);
	}

	public sealed class HttpContentHeaders : HttpHeaders // TypeDefIndex: 59261
	{
		// Fields
		private readonly HttpContent content; // 0x20
	
		// Properties
		public ContentDispositionHeaderValue ContentDisposition { get => default; set {} } // 0x000000018B95CE64-0x000000018B95CEB0 0x000000018B95D020-0x000000018B95D084
		public long? ContentLength { get => default; set {} } // 0x000000018B95CEB0-0x000000018B95CFD4 0x000000018B95D084-0x000000018B95D0EC
		public MediaTypeHeaderValue ContentType { get => default; set {} } // 0x000000018B95CFD4-0x000000018B95D020 0x000000018B95D0EC-0x000000018B95D150
	
		// Constructors
		public HttpContentHeaders() {} // Dummy constructor
		internal HttpContentHeaders(HttpContent content) {} // 0x000000018B95CE04-0x000000018B95CE64
	}

	internal enum HttpHeaderKind // TypeDefIndex: 59262
	{
		None = 0,
		Request = 1,
		Response = 2,
		Content = 4
	}

	public sealed class HttpHeaderValueCollection<T> : ICollection<T> // TypeDefIndex: 59263
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

	public abstract class HttpHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>> // TypeDefIndex: 59266
	{
		// Fields
		private static readonly Dictionary<string, System.Net.Http.Headers.HeaderInfo> known_headers; // 0x00
		private readonly Dictionary<string, HeaderBucket> headers; // 0x10
		private readonly HttpHeaderKind HeaderKind; // 0x18
		internal bool? connectionclose; // 0x1C
		internal bool? transferEncodingChunked; // 0x1E
	
		// Nested types
		private class HeaderBucket // TypeDefIndex: 59264
		{
			// Fields
			public object Parsed; // 0x10
			private List<string> values; // 0x18
			public readonly Func<object, string> CustomToString; // 0x20
	
			// Properties
			public bool HasStringValues { get => default; } // 0x000000018B960494-0x000000018B960538 
			public List<string> Values { get => default; set {} } // 0x000000018B960470-0x000000018B960494 0x000000018B95D6C0-0x000000018B95DCC0
	
			// Constructors
			public HeaderBucket() {} // Dummy constructor
			public HeaderBucket(object parsed, Func<object, string> converter) {} // 0x000000018B95E864-0x000000018B960470
	
			// Methods
			public string ParsedToString() => default; // 0x000000018B95E6D0-0x000000018B95E78C
		}
	
		private sealed class _GetEnumerator_d__19 : IEnumerator<KeyValuePair<string, IEnumerable<string>>> // TypeDefIndex: 59265
		{
			// Fields
			private int __1__state; // 0x10
			private KeyValuePair<string, IEnumerable<string>> __2__current; // 0x18
			public HttpHeaders __4__this; // 0x28
			private Dictionary<string, HeaderBucket> __7__wrap1; // 0x30
	
			// Properties
			KeyValuePair<string, IEnumerable<string>> IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.Current { get => default; } // 0x000000018B95E438-0x000000018B95E49C 
			object IEnumerator.Current { get => default; } // 0x000000018B95E4A4-0x000000018B95E6D0 
	
			// Constructors
			public _GetEnumerator_d__19() {} // Dummy constructor
			public _GetEnumerator_d__19(int __1__state) {} // 0x000000018B95DCC0-0x000000018B95DE28
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B95E78C-0x000000018B95E864
			private bool MoveNext() => default; // 0x000000018B95DF88-0x000000018B95DFE4
			private void __m__Finally1() {} // 0x000000018B95E49C-0x000000018B95E4A4
			void IEnumerator.Reset() {} // 0x000000018B95E0CC-0x000000018B95E438
		}
	
		// Constructors
		static HttpHeaders() {}
		protected HttpHeaders() {}
		internal HttpHeaders(HttpHeaderKind headerKind) {}
	
		// Methods
		private bool AddInternal(string name, IEnumerable<string> values, System.Net.Http.Headers.HeaderInfo headerInfo, bool ignoreInvalid) => default; // 0x000000018B95DE28-0x000000018B95DF88
		public bool TryAddWithoutValidation(string name, IEnumerable<string> values) => default; // 0x000000018B95DFE4-0x000000018B95E0CC
		private System.Net.Http.Headers.HeaderInfo CheckName(string name) => default;
		private bool TryCheckName(string name, out System.Net.Http.Headers.HeaderInfo headerInfo) {
			headerInfo = default;
			return default;
		}
		public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000185BB2030-0x0000000185BB2060
		public bool Remove(string name) => default; // 0x000000018B95BE3C-0x000000018B95BE80
		internal static string GetSingleHeaderString(string key, IEnumerable<string> values) => default; // 0x000000018B95BE80-0x000000018B95BF04
		public override string ToString() => default; // 0x0000000184088E70-0x0000000184088E80
		internal void AddOrRemove<T>(string name, T value, Func<object, string> converter = null)
			where T : class {} // 0x000000018B95BDF0-0x000000018B95BE3C
		internal void AddOrRemove<T>(string name, T? value)
			where T : struct {} // 0x0000000181378230-0x0000000181378240
		internal void AddOrRemove<T>(string name, T? value, Func<object, string> converter)
			where T : struct {} // 0x000000018B96A74C-0x000000018B96A7C4
		private List<string> GetAllHeaderValues(HeaderBucket bucket, System.Net.Http.Headers.HeaderInfo headerInfo) => default; // 0x000000018B96A31C-0x000000018B96A6B8
		internal static HttpHeaderKind GetKnownHeaderKind(string name) => default; // 0x000000018B96A7C4-0x000000018B96A800
		internal T GetValue<T>(string name) => default; // 0x0000000185FB30D0-0x0000000185FB30E0
		internal HttpHeaderValueCollection<T> GetValues<T>(string name)
			where T : class => default; // 0x000000018B96A6B8-0x000000018B96A704
		internal void SetValue<T>(string name, T value, Func<object, string> toStringConverter = null) {} // 0x000000018B96A704-0x000000018B96A74C
	}

	public sealed class HttpRequestHeaders : HttpHeaders // TypeDefIndex: 59268
	{
		// Fields
		private bool? expectContinue; // 0x20
	
		// Properties
		public AuthenticationHeaderValue Authorization { set {} } // 0x000000018B9610C0-0x000000018B96110C
		public HttpHeaderValueCollection<string> Connection { get => default; } // 0x000000018B961270-0x000000018B9612BC 
		public bool? ConnectionClose { get => default; set {} } // 0x000000018B96110C-0x000000018B961270 0x000000018B960B90-0x000000018B960D44
		public bool? ExpectContinue { get => default; } // 0x000000018B96E9DC-0x000000018B96EA40 
		public string Host { get => default; } // 0x0000000185492010-0x0000000185492020 
		public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding { get => default; } // 0x000000018B96E88C-0x000000018B96E8D0 
		public bool? TransferEncodingChunked { get => default; } // 0x000000018B96E8D0-0x000000018B96E920 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59267
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<string> __9__19_0; // 0x08
			public static Predicate<TransferCodingHeaderValue> __9__29_0; // 0x10
			public static Predicate<TransferCodingHeaderValue> __9__71_0; // 0x18
	
			// Constructors
			static __c() {} // 0x000000018B960D44-0x000000018B960D98
			public __c() {} // 0x000000018B9612BC-0x000000018B961320
	
			// Methods
			internal bool _get_ConnectionClose_b__19_0(string l) => default; // 0x000000018B960F10-0x000000018B960F5C
			internal bool _get_ExpectContinue_b__29_0(TransferCodingHeaderValue l) => default; // 0x000000018B960D98-0x000000018B960F10
			internal bool _get_TransferEncodingChunked_b__71_0(TransferCodingHeaderValue l) => default; // 0x000000018B961320-0x000000018B961404
		}
	
		// Constructors
		internal HttpRequestHeaders() {} // 0x000000018B960F5C-0x000000018B9610C0
	
		// Methods
		internal void AddHeaders(HttpRequestHeaders headers) {} // 0x000000018B96E920-0x000000018B96E970
	}

	public sealed class HttpResponseHeaders : HttpHeaders // TypeDefIndex: 59269
	{
		// Constructors
		internal HttpResponseHeaders() {} // 0x000000018B961AC0-0x000000018B961B14
	}

	internal struct Token // TypeDefIndex: 59271
	{
		// Fields
		public static readonly Token Empty; // 0x00
		private readonly Type type; // 0x00
		private int _StartPosition_k__BackingField; // 0x04
		private int _EndPosition_k__BackingField; // 0x08
	
		// Properties
		public int StartPosition { get; private set; } // 0x000000018357CBC0-0x000000018357CBD0 0x0000000185FB2BA0-0x0000000185FB2BB0
		public int EndPosition { get; private set; } // 0x0000000181B7E450-0x0000000181B7E460 0x0000000185FB2B90-0x0000000185FB2BA0
		public Type Kind { get => default; } // 0x00000001818226B0-0x00000001818226C0 
	
		// Nested types
		public enum Type // TypeDefIndex: 59270
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
			<StartPosition>k__BackingField = default;
			<EndPosition>k__BackingField = default;
		} // 0x000000018B969BB8-0x000000018B969C24
		static Token() {
			Empty = default;
		} // 0x000000018B969B50-0x000000018B969BB8
	
		// Methods
		public static implicit operator Type(Token token) => default; // 0x00000001818226B0-0x00000001818226C0
		public override string ToString() => default; // 0x000000018B969AB0-0x000000018B969B00
	}

	internal class Lexer // TypeDefIndex: 59272
	{
		// Fields
		private static readonly bool[] token_chars; // 0x00
		private static readonly int last_token_char; // 0x08
		private static readonly string[] dt_formats; // 0x10
		private readonly string s; // 0x10
		private int pos; // 0x18
	
		// Properties
		public int Position { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
	
		// Constructors
		public Lexer() {} // Dummy constructor
		public Lexer(string stream) {} // 0x0000000184096E30-0x0000000184096EF0
		static Lexer() {} // 0x000000018B962A30-0x000000018B962BD8
	
		// Methods
		public string GetStringValue(System.Net.Http.Headers.Token token) => default; // 0x000000018B962010-0x000000018B962078
		public string GetStringValue(System.Net.Http.Headers.Token start, System.Net.Http.Headers.Token end) => default; // 0x000000018B961F9C-0x000000018B962010
		public string GetQuotedStringValue(System.Net.Http.Headers.Token start) => default; // 0x000000018B961EFC-0x000000018B961F6C
		public string GetRemainingStringValue(int position) => default; // 0x000000018B961F6C-0x000000018B961F9C
		public bool IsStarStringValue(System.Net.Http.Headers.Token token) => default; // 0x000000018B962078-0x000000018B9620FC
		public bool TryGetNumericValue(System.Net.Http.Headers.Token token, out int value) {
			value = default;
			return default;
		} // 0x000000018B962844-0x000000018B9628D8
		public bool TryGetNumericValue(System.Net.Http.Headers.Token token, out long value) {
			value = default;
			return default;
		} // 0x000000018B9628D8-0x000000018B96296C
		public TimeSpan? TryGetTimeSpanValue(System.Net.Http.Headers.Token token) => default; // 0x000000018B96296C-0x000000018B962A30
		public bool TryGetDateValue(System.Net.Http.Headers.Token token, out DateTimeOffset value) {
			value = default;
			return default;
		} // 0x000000018B962614-0x000000018B9626EC
		public static bool TryGetDateValue(string text, out DateTimeOffset value) {
			value = default;
			return default;
		} // 0x000000018B9626EC-0x000000018B9627B0
		public bool TryGetDoubleValue(System.Net.Http.Headers.Token token, out double value) {
			value = default;
			return default;
		} // 0x000000018B9627B0-0x000000018B962844
		public static bool IsValidToken(string input) => default; // 0x000000018B962180-0x000000018B962208
		public static bool IsValidCharacter(char input) => default; // 0x000000018B9620FC-0x000000018B962180
		public void EatChar() {} // 0x0000000185FC8DF0-0x0000000185FC8E00
		public int PeekChar() => default; // 0x000000018B962208-0x000000018B96223C
		public bool ScanCommentOptional(out string value, out System.Net.Http.Headers.Token readToken) {
			value = default;
			readToken = default;
			return default;
		} // 0x000000018B96223C-0x000000018B962364
		public System.Net.Http.Headers.Token Scan(bool recognizeDash = false /* Metadata: 0x0208055F */) => default; // 0x000000018B962364-0x000000018B962614
	}

	public class MediaTypeHeaderValue : ICloneable // TypeDefIndex: 59274
	{
		// Fields
		internal List<NameValueHeaderValue> parameters; // 0x10
		internal string media_type; // 0x18
	
		// Properties
		public string CharSet { get => default; set {} } // 0x000000018B9636F0-0x000000018B963774 0x000000018B962EDC-0x000000018B962F3C
		public string MediaType { set {} } // 0x000000018B962DE0-0x000000018B962E6C
		public ICollection<NameValueHeaderValue> Parameters { get => default; } // 0x000000018B962E6C-0x000000018B962EDC 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59273
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<NameValueHeaderValue> __9__6_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B9635C4-0x000000018B9635CC
			public __c() {} // 0x000000018B9632E8-0x000000018B9635C4
	
			// Methods
			internal bool _get_CharSet_b__6_0(NameValueHeaderValue l) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public MediaTypeHeaderValue(string mediaType) {} // 0x000000018B9635CC-0x000000018B9636F0
		protected MediaTypeHeaderValue(MediaTypeHeaderValue source) {} // 0x000000018B963774-0x000000018B963820
		internal MediaTypeHeaderValue() {} // 0x000000018B963820-0x000000018B9639AC
	
		// Methods
		object ICloneable.Clone() => default; // 0x000000018B962F3C-0x000000018B962FA0
		public override bool Equals(object obj) => default; // 0x000000018B96316C-0x000000018B9632E8
		public override int GetHashCode() => default; // 0x000000018B962FA0-0x000000018B96316C
		public override string ToString() => default; // 0x000000018B96EAA4-0x000000018B96EB08
		public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		internal static System.Net.Http.Headers.Token? TryParseMediaType(Lexer lexer, out string media) {
			media = default;
			return default;
		} // 0x000000018B96E83C-0x000000018B96E88C
	}

	public sealed class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue // TypeDefIndex: 59275
	{
		// Constructors
		private MediaTypeWithQualityHeaderValue() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static bool TryParseElement(Lexer lexer, out MediaTypeWithQualityHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x000000018B9639AC-0x000000018B963B20
		internal static bool TryParse(string input, int minimalCount, out List<MediaTypeWithQualityHeaderValue> result) {
			result = default;
			return default;
		} // 0x000000018B963B20-0x000000018B963BD0
	}

	public class NameValueHeaderValue : ICloneable // TypeDefIndex: 59276
	{
		// Fields
		internal string value; // 0x10
		private string _Name_k__BackingField; // 0x18
	
		// Properties
		public string Name { get; internal set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public string Value { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x000000018B966404-0x000000018B96657C
	
		// Constructors
		public NameValueHeaderValue(string name, string value) {} // 0x000000018B9663B8-0x000000018B966404
		protected internal NameValueHeaderValue(NameValueHeaderValue source) {} // 0x000000018B96637C-0x000000018B9663B8
		internal NameValueHeaderValue() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		internal static NameValueHeaderValue Create(string name, string value) => default; // 0x000000018B965C48-0x000000018B965CB8
		object ICloneable.Clone() => default; // 0x000000018B965D64-0x000000018B965DC4
		public override int GetHashCode() => default; // 0x000000018B957EFC-0x000000018B957F70
		public override bool Equals(object obj) => default; // 0x000000018B965CB8-0x000000018B965D64
		internal static bool TryParsePragma(string input, int minimalCount, out List<NameValueHeaderValue> result) {
			result = default;
			return default;
		} // 0x000000018B9662CC-0x000000018B96637C
		internal static bool TryParseParameters(Lexer lexer, out List<NameValueHeaderValue> result, out System.Net.Http.Headers.Token t) {
			result = default;
			t = default;
			return default;
		} // 0x000000018B966020-0x000000018B9662CC
		public override string ToString() => default; // 0x000000018B965DC4-0x000000018B965E28
		private static bool TryParseElement(Lexer lexer, out NameValueHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x000000018B965E28-0x000000018B966020
	}

	public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable // TypeDefIndex: 59277
	{
		// Fields
		private List<NameValueHeaderValue> parameters; // 0x20
	
		// Properties
		public ICollection<NameValueHeaderValue> Parameters { get => default; } // 0x000000018B966B8C-0x000000018B966C10 
	
		// Constructors
		protected NameValueWithParametersHeaderValue(NameValueWithParametersHeaderValue source) {} // 0x000000018B966A3C-0x000000018B966B8C
		private NameValueWithParametersHeaderValue() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		new object ICloneable.Clone() => default; // 0x000000018B966660-0x000000018B9666C0
		public override bool Equals(object obj) => default; // 0x000000018B96657C-0x000000018B96660C
		public override int GetHashCode() => default; // 0x000000018B96660C-0x000000018B966660
		public override string ToString() => default; // 0x000000018B9666C0-0x000000018B966748
		internal static bool TryParse(string input, int minimalCount, out List<NameValueWithParametersHeaderValue> result) {
			result = default;
			return default;
		} // 0x000000018B96698C-0x000000018B966A3C
		private static bool TryParseElement(Lexer lexer, out NameValueWithParametersHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x000000018B966748-0x000000018B96698C
	}

	internal static class Parser // TypeDefIndex: 59289
	{
		// Nested types
		public static class Token // TypeDefIndex: 59278
		{
			// Methods
			public static void Check(string s) {} // 0x000000018B969984-0x000000018B969AB0
			public static bool TryCheck(string s) => default; // 0x000000018B969B00-0x000000018B969B50
		}
	
		public static class DateTime // TypeDefIndex: 59280
		{
			// Fields
			public static readonly Func<object, string> ToString; // 0x00
	
			// Nested types
			[Serializable]
			private sealed class __c // TypeDefIndex: 59279
			{
				// Fields
				public static readonly __c __9; // 0x00
	
				// Constructors
				static __c() {} // 0x000000018B95B4E8-0x000000018B95B544
				public __c() {} // 0x000000018B95B544-0x000000018B95B608
	
				// Methods
				internal string _.cctor_b__2_0(object l) => default; // 0x000000018B96EB6C-0x000000018B96EBD0
			}
	
			// Constructors
			static DateTime() {} // 0x000000018B96E74C-0x000000018B96E7E0
	
			// Methods
			public static bool TryParse(string input, out DateTimeOffset result) {
				result = default;
				return default;
			} // 0x0000000185492010-0x0000000185492020
		}
	
		public static class EmailAddress // TypeDefIndex: 59281
		{
			// Methods
			public static bool TryParse(string input, out string result) {
				result = default;
				return default;
			} // 0x000000018B95B608-0x000000018B95B6F8
		}
	
		public static class Host // TypeDefIndex: 59282
		{
			// Methods
			public static bool TryParse(string input, out string result) {
				result = default;
				return default;
			} // 0x000000018B95BFB0-0x000000018B95C04C
		}
	
		public static class Int // TypeDefIndex: 59283
		{
			// Methods
			public static bool TryParse(string input, out int result) {
				result = default;
				return default;
			} // 0x000000018B961E9C-0x000000018B961EFC
		}
	
		public static class Long // TypeDefIndex: 59284
		{
			// Methods
			public static bool TryParse(string input, out long result) {
				result = default;
				return default;
			} // 0x000000018B962BD8-0x000000018B962C38
		}
	
		public static class MD5 // TypeDefIndex: 59286
		{
			// Fields
			public static readonly Func<object, string> ToString; // 0x00
	
			// Nested types
			[Serializable]
			private sealed class __c // TypeDefIndex: 59285
			{
				// Fields
				public static readonly __c __9; // 0x00
	
				// Constructors
				static __c() {} // 0x000000018B962C38-0x000000018B962D1C
				public __c() {} // 0x000000018B962D1C-0x000000018B962DE0
	
				// Methods
				internal string _.cctor_b__2_0(object l) => default; // 0x000000018B96EA40-0x000000018B96EAA4
			}
	
			// Constructors
			static MD5() {} // 0x000000018B96E7E0-0x000000018B96E83C
	
			// Methods
			public static bool TryParse(string input, out byte[] result) {
				result = default;
				return default;
			} // 0x0000000185492010-0x0000000185492020
		}
	
		public static class TimeSpanSeconds // TypeDefIndex: 59287
		{
			// Methods
			public static bool TryParse(string input, out TimeSpan result) {
				result = default;
				return default;
			} // 0x000000018B9698F0-0x000000018B969984
		}
	
		public static class Uri // TypeDefIndex: 59288
		{
			// Methods
			public static bool TryParse(string input, out System.Uri result) {
				result = default;
				return default;
			} // 0x000000018B96EBD0-0x000000018B96EC24
		}
	}

	public class ProductHeaderValue : ICloneable // TypeDefIndex: 59290
	{
		// Fields
		private string _Name_k__BackingField; // 0x10
		private string _Version_k__BackingField; // 0x18
	
		// Properties
		public string Name { get; internal set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public string Version { get; internal set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		internal ProductHeaderValue() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000184690EB0-0x0000000184690EC0
		public override bool Equals(object obj) => default; // 0x000000018B966D24-0x000000018B966DA4
		public override int GetHashCode() => default; // 0x000000018B966DA4-0x000000018B966E10
		internal static bool TryParse(string input, int minimalCount, out List<ProductHeaderValue> result) {
			result = default;
			return default;
		} // 0x000000018B967044-0x000000018B9670F4
		private static bool TryParseElement(Lexer lexer, out ProductHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x000000018B966E64-0x000000018B967044
		public override string ToString() => default; // 0x000000018B966E10-0x000000018B966E64
	}

	public class ProductInfoHeaderValue : ICloneable // TypeDefIndex: 59291
	{
		// Fields
		private string _Comment_k__BackingField; // 0x10
		private ProductHeaderValue _Product_k__BackingField; // 0x18
	
		// Properties
		public string Comment { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public ProductHeaderValue Product { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public ProductInfoHeaderValue(ProductHeaderValue product) {} // 0x000000018B96752C-0x000000018B967590
		private ProductInfoHeaderValue() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000184690EB0-0x0000000184690EC0
		public override bool Equals(object obj) => default; // 0x000000018B9670F4-0x000000018B967168
		public override int GetHashCode() => default; // 0x000000018B967168-0x000000018B967198
		internal static bool TryParse(string input, int minimalCount, out List<ProductInfoHeaderValue> result) {
			result = default;
			return default;
		} // 0x000000018B9673DC-0x000000018B96752C
		private static bool TryParseElement(Lexer lexer, out ProductInfoHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x000000018B9671C0-0x000000018B9673DC
		public override string ToString() => default; // 0x000000018B967198-0x000000018B9671C0
	}

	public class RangeConditionHeaderValue : ICloneable // TypeDefIndex: 59292
	{
		// Fields
		private DateTimeOffset? _Date_k__BackingField; // 0x10
		private EntityTagHeaderValue _EntityTag_k__BackingField; // 0x28
	
		// Properties
		public DateTimeOffset? Date { get; private set; } // 0x00000001834A4CC0-0x00000001834A4CE0 0x0000000185FC5C90-0x0000000185FC5CB0
		public EntityTagHeaderValue EntityTag { get; private set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
	
		// Constructors
		public RangeConditionHeaderValue() {} // Dummy constructor
		public RangeConditionHeaderValue(DateTimeOffset date) {} // 0x000000018B967A78-0x000000018B967AD8
		public RangeConditionHeaderValue(EntityTagHeaderValue entityTag) {} // 0x000000018B967AD8-0x000000018B967B4C
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000184690EB0-0x0000000184690EC0
		public override bool Equals(object obj) => default; // 0x000000018B967590-0x000000018B967694
		public override int GetHashCode() => default; // 0x000000018B967694-0x000000018B967700
		public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x000000018B9677E4-0x000000018B967A78
		public override string ToString() => default; // 0x000000018B967700-0x000000018B9677E4
	}

	public class RangeHeaderValue : ICloneable // TypeDefIndex: 59293
	{
		// Fields
		private List<RangeItemHeaderValue> ranges; // 0x10
		private string unit; // 0x18
	
		// Properties
		public ICollection<RangeItemHeaderValue> Ranges { get => default; } // 0x000000018B968424-0x000000018B9684A8 
		public string Unit { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Constructors
		public RangeHeaderValue() {} // 0x000000018B9683E4-0x000000018B968424
		private RangeHeaderValue(RangeHeaderValue source) {} // 0x000000018B96829C-0x000000018B9683E4
	
		// Methods
		object ICloneable.Clone() => default; // 0x000000018B967C48-0x000000018B967CA8
		public override bool Equals(object obj) => default; // 0x000000018B967B4C-0x000000018B967BD8
		public override int GetHashCode() => default; // 0x000000018B967BD8-0x000000018B967C48
		public static bool TryParse(string input, out RangeHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x000000018B967DCC-0x000000018B96829C
		public override string ToString() => default; // 0x000000018B967CA8-0x000000018B967DCC
	}

	public class RangeItemHeaderValue : ICloneable // TypeDefIndex: 59294
	{
		// Fields
		private long? _From_k__BackingField; // 0x10
		private long? _To_k__BackingField; // 0x20
	
		// Properties
		public long? From { get; private set; } // 0x00000001834A7540-0x00000001834A7550 0x0000000185FB6860-0x0000000185FB6870
		public long? To { get; private set; } // 0x0000000185FB6120-0x0000000185FB6130 0x0000000185FB6130-0x0000000185FB6140
	
		// Constructors
		public RangeItemHeaderValue() {} // Dummy constructor
		public RangeItemHeaderValue(long? from, long? to) {} // 0x000000018B9686F4-0x000000018B9688E4
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000184690EB0-0x0000000184690EC0
		public override bool Equals(object obj) => default; // 0x000000018B9684A8-0x000000018B968560
		public override int GetHashCode() => default; // 0x000000018B968560-0x000000018B9685D0
		public override string ToString() => default; // 0x000000018B9685D0-0x000000018B9686F4
	}

	public class RetryConditionHeaderValue : ICloneable // TypeDefIndex: 59295
	{
		// Fields
		private DateTimeOffset? _Date_k__BackingField; // 0x10
		private TimeSpan? _Delta_k__BackingField; // 0x28
	
		// Properties
		public DateTimeOffset? Date { get; private set; } // 0x00000001834A4CC0-0x00000001834A4CE0 0x0000000185FC5C90-0x0000000185FC5CB0
		public TimeSpan? Delta { get; private set; } // 0x0000000185FBB610-0x0000000185FBB620 0x0000000185FBB620-0x0000000185FBB630
	
		// Constructors
		public RetryConditionHeaderValue() {} // Dummy constructor
		public RetryConditionHeaderValue(DateTimeOffset date) {} // 0x000000018B968ED8-0x000000018B968F38
		public RetryConditionHeaderValue(TimeSpan delta) {} // 0x000000018B968DFC-0x000000018B968ED8
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000184690EB0-0x0000000184690EC0
		public override bool Equals(object obj) => default; // 0x000000018B9688E4-0x000000018B968A34
		public override int GetHashCode() => default; // 0x000000018B968A34-0x000000018B968AB8
		public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue) {
			parsedValue = default;
			return default;
		} // 0x000000018B968C04-0x000000018B968DFC
		public override string ToString() => default; // 0x000000018B968AB8-0x000000018B968C04
	}

	public class StringWithQualityHeaderValue : ICloneable // TypeDefIndex: 59296
	{
		// Fields
		private double? _Quality_k__BackingField; // 0x10
		private string _Value_k__BackingField; // 0x20
	
		// Properties
		public double? Quality { get; private set; } // 0x00000001834A7540-0x00000001834A7550 0x0000000185FB6860-0x0000000185FB6870
		public string Value { get; private set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
	
		// Constructors
		private StringWithQualityHeaderValue() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000184690EB0-0x0000000184690EC0
		public override bool Equals(object obj) => default; // 0x000000018B969354-0x000000018B969424
		public override int GetHashCode() => default; // 0x000000018B969424-0x000000018B9694A0
		internal static bool TryParse(string input, int minimalCount, out List<StringWithQualityHeaderValue> result) {
			result = default;
			return default;
		} // 0x000000018B969840-0x000000018B9698F0
		private static bool TryParseElement(Lexer lexer, out StringWithQualityHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x000000018B969578-0x000000018B969840
		public override string ToString() => default; // 0x000000018B9694A0-0x000000018B969578
	}

	public class TransferCodingHeaderValue : ICloneable // TypeDefIndex: 59297
	{
		// Fields
		internal string value; // 0x10
		internal List<NameValueHeaderValue> parameters; // 0x18
	
		// Properties
		public ICollection<NameValueHeaderValue> Parameters { get => default; } // 0x000000018B96A298-0x000000018B96A31C 
		public string Value { get => default; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		protected TransferCodingHeaderValue(TransferCodingHeaderValue source) {} // 0x000000018B96A00C-0x000000018B96A298
		internal TransferCodingHeaderValue() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		object ICloneable.Clone() => default; // 0x000000018B969D2C-0x000000018B969D8C
		public override bool Equals(object obj) => default; // 0x000000018B969C24-0x000000018B969CB0
		public override int GetHashCode() => default; // 0x000000018B969CB0-0x000000018B969D2C
		public override string ToString() => default; // 0x000000018B969D8C-0x000000018B969DE4
		internal static bool TryParse(string input, int minimalCount, out List<TransferCodingHeaderValue> result) {
			result = default;
			return default;
		} // 0x000000018B969F5C-0x000000018B96A00C
		private static bool TryParseElement(Lexer lexer, out TransferCodingHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x000000018B969DE4-0x000000018B969F5C
	}

	public sealed class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue // TypeDefIndex: 59298
	{
		// Constructors
		private TransferCodingWithQualityHeaderValue() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		internal static bool TryParse(string input, int minimalCount, out List<TransferCodingWithQualityHeaderValue> result) {
			result = default;
			return default;
		} // 0x000000018B96ED9C-0x000000018B96EE4C
		private static bool TryParseElement(Lexer lexer, out TransferCodingWithQualityHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x000000018B96EC24-0x000000018B96ED9C
	}

	public class ViaHeaderValue : ICloneable // TypeDefIndex: 59299
	{
		// Fields
		private string _Comment_k__BackingField; // 0x10
		private string _ProtocolName_k__BackingField; // 0x18
		private string _ProtocolVersion_k__BackingField; // 0x20
		private string _ReceivedBy_k__BackingField; // 0x28
	
		// Properties
		public string Comment { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public string ProtocolName { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public string ProtocolVersion { get; private set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public string ReceivedBy { get; private set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
	
		// Constructors
		private ViaHeaderValue() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		object ICloneable.Clone() => default; // 0x0000000184690EB0-0x0000000184690EC0
		public override bool Equals(object obj) => default; // 0x000000018B96EE4C-0x000000018B96EEFC
		public override int GetHashCode() => default; // 0x000000018B96EEFC-0x000000018B96EFC4
		internal static bool TryParse(string input, int minimalCount, out List<ViaHeaderValue> result) {
			result = default;
			return default;
		} // 0x000000018B96F3D4-0x000000018B96F484
		private static bool TryParseElement(Lexer lexer, out ViaHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x000000018B96F0D4-0x000000018B96F3D4
		public override string ToString() => default; // 0x000000018B96EFC4-0x000000018B96F0D4
	}

	public class WarningHeaderValue : ICloneable // TypeDefIndex: 59300
	{
		// Fields
		private string _Agent_k__BackingField; // 0x10
		private int _Code_k__BackingField; // 0x18
		private DateTimeOffset? _Date_k__BackingField; // 0x20
		private string _Text_k__BackingField; // 0x38
	
		// Properties
		public string Agent { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public int Code { get; private set; } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public DateTimeOffset? Date { get; private set; } // 0x0000000183636BE0-0x0000000183636C00 0x0000000185FD6240-0x0000000185FD6260
		public string Text { get; private set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
	
		// Constructors
		private WarningHeaderValue() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static bool IsCodeValid(int code) => default; // 0x000000018B96F664-0x000000018B96F678
		object ICloneable.Clone() => default; // 0x0000000184690EB0-0x0000000184690EC0
		public override bool Equals(object obj) => default; // 0x000000018B96F484-0x000000018B96F5B0
		public override int GetHashCode() => default; // 0x000000018B96F5B0-0x000000018B96F664
		internal static bool TryParse(string input, int minimalCount, out List<WarningHeaderValue> result) {
			result = default;
			return default;
		} // 0x000000018B96FB68-0x000000018B96FE44
		private static bool TryParseElement(Lexer lexer, out WarningHeaderValue parsedValue, out System.Net.Http.Headers.Token t) {
			parsedValue = default;
			t = default;
			return default;
		} // 0x000000018B96F85C-0x000000018B96FB68
		public override string ToString() => default; // 0x000000018B96F678-0x000000018B96F85C
	}
}
