/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Unity.Collections;
using UnityEngine;

// Image 80: UnityEngine.UnityWebRequestModule.dll - Assembly: UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60032-60046

namespace UnityEngine
{
	public class WWWForm // TypeDefIndex: 60034
	{
		// Fields
		private List<byte[]> formData; // 0x10
		private List<string> fieldNames; // 0x18
		private List<string> fileNames; // 0x20
		private List<string> types; // 0x28
		private byte[] boundary; // 0x30
		private bool containsFiles; // 0x38
		private static byte[] dDash; // 0x00
		private static byte[] crlf; // 0x08
		private static byte[] contentTypeHeader; // 0x10
		private static byte[] dispositionHeader; // 0x18
		private static byte[] endQuote; // 0x20
		private static byte[] fileNameField; // 0x28
		private static byte[] ampersand; // 0x30
		private static byte[] equal; // 0x38
	
		// Properties
		internal static Encoding DefaultEncoding { get => default; } // 0x000000018C09F040-0x000000018C09F04C 
		public Dictionary<string, string> headers { get => default; } // 0x000000018C09FD2C-0x000000018C09FE44 
		public byte[] data { get => default; } // 0x000000018C09F04C-0x000000018C09FD2C 
	
		// Constructors
		public WWWForm() {} // Dummy constructor
		static WWWForm() {} // 0x000000018C09ED64-0x000000018C09F040
	}

	internal class WWWTranscoder // TypeDefIndex: 60035
	{
		// Fields
		private static byte[] ucHexChars; // 0x00
		private static byte[] lcHexChars; // 0x08
		private static byte urlEscapeChar; // 0x10
		private static byte[] urlSpace; // 0x18
		private static byte[] dataSpace; // 0x20
		private static byte[] urlForbidden; // 0x28
		private static byte qpEscapeChar; // 0x30
		private static byte[] qpSpace; // 0x38
		private static byte[] qpForbidden; // 0x40
	
		// Constructors
		public WWWTranscoder() {} // Dummy constructor
		static WWWTranscoder() {} // 0x000000018C0A0968-0x000000018C0A0C28
	
		// Methods
		private static byte Hex2Byte(byte[] b, int offset) => default; // 0x000000018C0A0644-0x000000018C0A06C0
		private static void Byte2Hex(byte b, byte[] hexChars, out byte byte0, out byte byte1) {
			byte0 = default;
			byte1 = default;
		} // 0x000000018C09FE44-0x000000018C09FE84
		public static byte[] URLEncode(byte[] toEncode) => default; // 0x000000018C0A0904-0x000000018C0A0968
		public static string DataEncode(string toEncode) => default; // 0x000000018C09FF38-0x000000018C09FF90
		public static string DataEncode(string toEncode, Encoding e) => default; // 0x000000018C09FFF4-0x000000018C0A00C8
		public static byte[] DataEncode(byte[] toEncode) => default; // 0x000000018C09FF90-0x000000018C09FFF4
		public static string QPEncode(string toEncode, Encoding e) => default; // 0x000000018C0A06C0-0x000000018C0A0794
		public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase) => default; // 0x000000018C0A030C-0x000000018C0A0644
		private static bool ByteArrayContains(byte[] array, byte b) => default; // 0x000000018C09FE84-0x000000018C09FEC4
		public static byte[] URLDecode(byte[] toEncode) => default; // 0x000000018C0A08AC-0x000000018C0A0904
		private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) => default; // 0x000000018C09FEC4-0x000000018C09FF38
		public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) => default; // 0x000000018C0A00C8-0x000000018C0A030C
		public static bool SevenBitClean(string s, Encoding e) => default; // 0x000000018C0A07C4-0x000000018C0A08AC
		public static unsafe bool SevenBitClean(byte* input, int inputLength) => default; // 0x000000018C0A0794-0x000000018C0A07C4
	}
}

namespace UnityEngine.Networking
{
	public interface IMultipartFormSection // TypeDefIndex: 60036
	{
		// Properties
		string sectionName { get; }
		byte[] sectionData { get; }
		string fileName { get; }
		string contentType { get; }
	}

	public class UnityWebRequestAsyncOperation : AsyncOperation // TypeDefIndex: 60037
	{
		// Fields
		private UnityWebRequest _webRequest_k__BackingField; // 0x20
	
		// Properties
		internal UnityWebRequest webRequest { get; set; } // 0x000000018646EE40-0x000000018646EE50
	
		// Constructors
		public UnityWebRequestAsyncOperation() {} // 0x0000000185492010-0x0000000185492020
	}

	public class UnityWebRequest : IDisposable // TypeDefIndex: 60041
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
		[NonSerialized]
		internal DownloadHandler m_DownloadHandler; // 0x18
		[NonSerialized]
		internal UploadHandler m_UploadHandler; // 0x20
		[NonSerialized]
		internal CertificateHandler m_CertificateHandler; // 0x28
		[NonSerialized]
		internal System.Uri m_Uri; // 0x30
		public const string kHttpVerbGET = "GET"; // Metadata: 0x020824FF
		public const string kHttpVerbHEAD = "HEAD"; // Metadata: 0x02082503
		public const string kHttpVerbPOST = "POST"; // Metadata: 0x02082508
		public const string kHttpVerbPUT = "PUT"; // Metadata: 0x0208250D
		public const string kHttpVerbCREATE = "CREATE"; // Metadata: 0x02082511
		public const string kHttpVerbDELETE = "DELETE"; // Metadata: 0x02082518
		private bool _disposeCertificateHandlerOnDispose_k__BackingField; // 0x38
		private bool _disposeDownloadHandlerOnDispose_k__BackingField; // 0x39
		private bool _disposeUploadHandlerOnDispose_k__BackingField; // 0x3A
	
		// Properties
		public bool disposeCertificateHandlerOnDispose { get; set; } // 0x0000000185FB0700-0x0000000185FB0710 0x0000000185FAFE20-0x0000000185FAFE30
		public bool disposeDownloadHandlerOnDispose { get; set; } // 0x0000000185FB0710-0x0000000185FB0720 0x0000000185FB0720-0x0000000185FB0730
		public bool disposeUploadHandlerOnDispose { get; set; } // 0x0000000185FB0B20-0x0000000185FB0B30 0x0000000185FB0B50-0x0000000185FB0B60
		public string method { get => default; set {} } // 0x000000018C09E694-0x000000018C09E734 0x0000000184F37360-0x0000000184F37430
		public string error { get => default; } // 0x0000000184F38490-0x0000000184F384E0 
		private bool use100Continue { get => default; set {} } // 0x000000018C09E8BC-0x000000018C09E8F0 0x000000018C09EC98-0x000000018C09ECDC
		public bool useHttpContinue { get => default; set {} } // 0x000000018C09E8F0-0x000000018C09E8FC 0x000000018C09ECDC-0x000000018C09ED64
		public string url { get => default; set {} } // 0x000000018C09E8B0-0x000000018C09E8BC 0x0000000184F372D0-0x0000000184F37360
		public System.Uri uri { get => default; set {} } // 0x000000018C09E7E4-0x000000018C09E8B0 0x000000018C09EBAC-0x000000018C09EC98
		public long responseCode { get => default; } // 0x0000000184F38450-0x0000000184F38490 
		public float uploadProgress { get => default; } // 0x000000018C09E770-0x000000018C09E7B0 
		public bool isModifiable { get => default; } // 0x0000000184F37620-0x0000000184F37660 
		public bool isDone { get => default; } // 0x0000000184F38310-0x0000000184F38330 
		public bool isNetworkError { get => default; } // 0x000000018C09E67C-0x000000018C09E694 
		public bool isHttpError { get => default; } // 0x000000018C09E664-0x000000018C09E67C 
		public Result result { get => default; } // 0x0000000184F384E0-0x0000000184F38520 
		public float downloadProgress { get => default; } // 0x000000018C09E5F0-0x000000018C09E630 
		public ulong uploadedBytes { get => default; } // 0x000000018C09E7B0-0x000000018C09E7E4 
		public ulong downloadedBytes { get => default; } // 0x000000018C09E630-0x000000018C09E664 
		public int redirectLimit { get => default; set {} } // 0x000000018C09E734-0x000000018C09E740 0x000000018C09EAC4-0x000000018C09EACC
		public bool chunkedTransfer { get => default; set {} } // 0x000000018C09E5E4-0x000000018C09E5F0 0x000000018C09E9E4-0x000000018C09EAC4
		public UploadHandler uploadHandler { get => default; set {} } // 0x0000000185FE66B0-0x0000000185FE66C0 0x0000000184F37660-0x0000000184F376B0
		public DownloadHandler downloadHandler { get => default; set {} } // 0x0000000185FC2A70-0x0000000185FC2A80 0x0000000184F37700-0x0000000184F37750
		public CertificateHandler certificateHandler { get => default; set {} } // 0x0000000185FE7B00-0x0000000185FE7B10 0x000000018C09E8FC-0x000000018C09E9E4
		public int timeout { get => default; set {} } // 0x000000018C09E74C-0x000000018C09E770 0x0000000184F377A0-0x0000000184F37830
		internal bool suppressErrorsToConsole { get => default; set {} } // 0x000000018C09E740-0x000000018C09E74C 0x000000018C09EACC-0x000000018C09EBAC
	
		// Nested types
		internal enum UnityWebRequestMethod // TypeDefIndex: 60038
		{
			Get = 0,
			Post = 1,
			Put = 2,
			Head = 3,
			Custom = 4
		}
	
		internal enum UnityWebRequestError // TypeDefIndex: 60039
		{
			OK = 0,
			Unknown = 1,
			SDKError = 2,
			UnsupportedProtocol = 3,
			MalformattedUrl = 4,
			CannotResolveProxy = 5,
			CannotResolveHost = 6,
			CannotConnectToHost = 7,
			AccessDenied = 8,
			GenericHttpError = 9,
			WriteError = 10,
			ReadError = 11,
			OutOfMemory = 12,
			Timeout = 13,
			HTTPPostError = 14,
			SSLCannotConnect = 15,
			Aborted = 16,
			TooManyRedirects = 17,
			ReceivedNoData = 18,
			SSLNotSupported = 19,
			FailedToSendData = 20,
			FailedToReceiveData = 21,
			SSLCertificateError = 22,
			SSLCipherNotAvailable = 23,
			SSLCACertError = 24,
			UnrecognizedContentEncoding = 25,
			LoginFailed = 26,
			SSLShutdownFailed = 27,
			NoInternetConnection = 28
		}
	
		public enum Result // TypeDefIndex: 60040
		{
			InProgress = 0,
			Success = 1,
			ConnectionError = 2,
			ProtocolError = 3,
			DataProcessingError = 4
		}
	
		// Constructors
		public UnityWebRequest() {} // 0x000000018C09E540-0x000000018C09E564
		public UnityWebRequest(string url) {} // 0x000000018C09E564-0x000000018C09E5A4
		public UnityWebRequest(System.Uri uri) {} // 0x000000018C09E5A4-0x000000018C09E5E4
		public UnityWebRequest(string url, string method) {} // 0x0000000184F38BF0-0x0000000184F38C50
		public UnityWebRequest(System.Uri uri, string method) {} // 0x000000018C09E464-0x000000018C09E4BC
		public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) {} // 0x0000000184F37880-0x0000000184F37910
		public UnityWebRequest(System.Uri uri, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) {} // 0x000000018C09E4BC-0x000000018C09E540
	
		// Methods
		private static string GetWebErrorString(UnityWebRequestError err) => default; // 0x000000018C09C9F8-0x000000018C09CA2C
		internal static string GetHTTPStatusString(long responseCode) => default; // 0x000000018C09C5F4-0x000000018C09C628
		public static void ClearCookieCache() {} // 0x000000018C09C188-0x000000018C09C194
		public static void ClearCookieCache(System.Uri uri) {} // 0x000000018C09C194-0x000000018C09C250
		private static void ClearCookieCache(string domain, string path) {} // 0x000000018C09C144-0x000000018C09C188
		internal static IntPtr Create() => default; // 0x0000000184F37910-0x0000000184F37950
		private void Release() {} // 0x00000001858947F0-0x0000000185894830
		internal void InternalDestroy() {} // 0x00000001858947C0-0x00000001858947F0
		private void InternalSetDefaults() {} // 0x0000000185FEAD40-0x0000000185FEAD50
		~UnityWebRequest() {} // 0x000000018C09C410-0x000000018C09C48C
		public void Dispose() {} // 0x0000000185894750-0x00000001858947C0
		private void DisposeHandlers() {} // 0x0000000185894870-0x00000001858948D0
		internal UnityWebRequestAsyncOperation BeginWebRequest() => default; // 0x0000000184F381A0-0x0000000184F381E0
		public AsyncOperation Send() => default; // 0x000000018C09D554-0x000000018C09D560
		public UnityWebRequestAsyncOperation SendWebRequest() => default; // 0x0000000184F38170-0x0000000184F381A0
		public void Abort() {} // 0x0000000185894830-0x0000000185894870
		private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType) => default; // 0x0000000184F37540-0x0000000184F37590
		internal void InternalSetMethod(UnityWebRequestMethod methodType) {} // 0x0000000184F37500-0x0000000184F37540
		private UnityWebRequestError SetCustomMethod(string customMethodName) => default; // 0x000000018C09DE28-0x000000018C09DE6C
		internal void InternalSetCustomMethod(string customMethodName) {} // 0x000000018C09CBC8-0x000000018C09CCA8
		internal UnityWebRequestMethod GetMethod() => default; // 0x000000018C09C628-0x000000018C09C65C
		internal string GetCustomMethod() => default; // 0x000000018C09C558-0x000000018C09C58C
		private UnityWebRequestError GetError() => default; // 0x000000018C09C5C0-0x000000018C09C5F4
		private string GetUrl() => default; // 0x000000018C09C9C4-0x000000018C09C9F8
		private UnityWebRequestError SetUrl(string url) => default; // 0x0000000184F375D0-0x0000000184F37620
		private void InternalSetUrl(string url) {} // 0x0000000184F37590-0x0000000184F375D0
		private float GetUploadProgress() => default; // 0x000000018C09C990-0x000000018C09C9C4
		private bool IsExecuting() => default; // 0x000000018C09CCA8-0x000000018C09CCDC
		private float GetDownloadProgress() => default; // 0x000000018C09C58C-0x000000018C09C5C0
		private int GetRedirectLimit() => default; // 0x000000018C09C65C-0x000000018C09C690
		private void SetRedirectLimitFromScripting(int limit) {} // 0x000000018C09DE6C-0x000000018C09DEAC
		private bool GetChunked() => default; // 0x000000018C09C524-0x000000018C09C558
		private UnityWebRequestError SetChunked(bool chunked) => default; // 0x000000018C09DDE4-0x000000018C09DE28
		public string GetRequestHeader(string name) => default; // 0x000000018C09C690-0x000000018C09C6D4
		internal UnityWebRequestError InternalSetRequestHeader(string name, string value) => default; // 0x0000000184F374A0-0x0000000184F37500
		public void SetRequestHeader(string name, string value) {} // 0x0000000184F37430-0x0000000184F374A0
		public string GetResponseHeader(string name) => default; // 0x000000018C09C708-0x000000018C09C74C
		internal string[] GetResponseHeaderKeys() => default; // 0x000000018C09C6D4-0x000000018C09C708
		public Dictionary<string, string> GetResponseHeaders() => default; // 0x000000018C09C74C-0x000000018C09C870
		private UnityWebRequestError SetUploadHandler(UploadHandler uh) => default; // 0x0000000184F376B0-0x0000000184F37700
		private UnityWebRequestError SetDownloadHandler(DownloadHandler dh) => default; // 0x0000000184F37750-0x0000000184F377A0
		private UnityWebRequestError SetCertificateHandler(CertificateHandler ch) => default; // 0x000000018C09DDA0-0x000000018C09DDE4
		private int GetTimeoutMsec() => default; // 0x000000018C09C95C-0x000000018C09C990
		private UnityWebRequestError SetTimeoutMsec(int timeout) => default; // 0x0000000184F37830-0x0000000184F37880
		private bool GetSuppressErrorsToConsole() => default; // 0x000000018C09C870-0x000000018C09C8A4
		private UnityWebRequestError SetSuppressErrorsToConsole(bool suppress) => default; // 0x000000018C09DEAC-0x000000018C09DEF0
		public static UnityWebRequest Get(string uri) => default; // 0x0000000184F38B10-0x0000000184F38BD0
		public static UnityWebRequest Get(System.Uri uri) => default; // 0x000000018C09CA2C-0x000000018C09CAE0
		public static UnityWebRequest Delete(string uri) => default; // 0x000000018C09C2C4-0x000000018C09C338
		public static UnityWebRequest Delete(System.Uri uri) => default; // 0x000000018C09C250-0x000000018C09C2C4
		public static UnityWebRequest Head(string uri) => default; // 0x000000018C09CAE0-0x000000018C09CB54
		public static UnityWebRequest Head(System.Uri uri) => default; // 0x000000018C09CB54-0x000000018C09CBC8
		public static UnityWebRequest GetTexture(string uri) => default; // 0x000000018C09C900-0x000000018C09C95C
		public static UnityWebRequest GetTexture(string uri, bool nonReadable) => default; // 0x000000018C09C8A4-0x000000018C09C900
		public static UnityWebRequest GetAudioClip(string uri, AudioType audioType) => default; // 0x0000000185FE67B0-0x0000000185FE67C0
		public static UnityWebRequest GetAssetBundle(string uri) => default; // 0x0000000185FE67B0-0x0000000185FE67C0
		public static UnityWebRequest GetAssetBundle(string uri, uint crc) => default; // 0x0000000185FE67B0-0x0000000185FE67C0
		public static UnityWebRequest GetAssetBundle(string uri, uint version, uint crc) => default; // 0x0000000185FE67B0-0x0000000185FE67C0
		public static UnityWebRequest GetAssetBundle(string uri, Hash128 hash, uint crc) => default; // 0x0000000185FE67B0-0x0000000185FE67C0
		public static UnityWebRequest GetAssetBundle(string uri, CachedAssetBundle cachedAssetBundle, uint crc) => default; // 0x0000000185FE67B0-0x0000000185FE67C0
		public static UnityWebRequest Put(string uri, byte[] bodyData) => default; // 0x000000018C09D354-0x000000018C09D440
		public static UnityWebRequest Put(System.Uri uri, byte[] bodyData) => default; // 0x000000018C09D268-0x000000018C09D354
		public static UnityWebRequest Put(string uri, string bodyData) => default; // 0x000000018C09D440-0x000000018C09D554
		public static UnityWebRequest Put(System.Uri uri, string bodyData) => default; // 0x000000018C09D154-0x000000018C09D268
		public static UnityWebRequest Post(string uri, string postData) => default; // 0x0000000184F39350-0x0000000184F393E0
		public static UnityWebRequest Post(System.Uri uri, string postData) => default; // 0x000000018C09CD10-0x000000018C09CDA0
		private static void SetupPost(UnityWebRequest request, string postData) {} // 0x0000000184F393E0-0x0000000184F39490
		public static UnityWebRequest Post(string uri, WWWForm formData) => default; // 0x000000018C09CE64-0x000000018C09CEF4
		public static UnityWebRequest Post(System.Uri uri, WWWForm formData) => default; // 0x000000018C09CDA0-0x000000018C09CE30
		private static void SetupPost(UnityWebRequest request, WWWForm formData) {} // 0x000000018C09DFF4-0x000000018C09E240
		public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections) => default; // 0x000000018C09CCDC-0x000000018C09CD10
		public static UnityWebRequest Post(System.Uri uri, List<IMultipartFormSection> multipartFormSections) => default; // 0x000000018C09CE30-0x000000018C09CE64
		public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections, byte[] boundary) => default; // 0x000000018C09CF94-0x000000018C09D034
		public static UnityWebRequest Post(System.Uri uri, List<IMultipartFormSection> multipartFormSections, byte[] boundary) => default; // 0x000000018C09CEF4-0x000000018C09CF94
		private static void SetupPost(UnityWebRequest request, List<IMultipartFormSection> multipartFormSections, byte[] boundary) {} // 0x000000018C09E240-0x000000018C09E390
		public static UnityWebRequest Post(string uri, Dictionary<string, string> formFields) => default; // 0x000000018C09D0C4-0x000000018C09D154
		public static UnityWebRequest Post(System.Uri uri, Dictionary<string, string> formFields) => default; // 0x000000018C09D034-0x000000018C09D0C4
		private static void SetupPost(UnityWebRequest request, Dictionary<string, string> formFields) {} // 0x000000018C09DEF0-0x000000018C09DFF4
		public static string EscapeURL(string s) => default; // 0x000000018C09C338-0x000000018C09C35C
		public static string EscapeURL(string s, Encoding e) => default; // 0x000000018C09C35C-0x000000018C09C410
		public static string UnEscapeURL(string s) => default; // 0x000000018C09E440-0x000000018C09E464
		public static string UnEscapeURL(string s, Encoding e) => default; // 0x000000018C09E390-0x000000018C09E440
		public static byte[] SerializeFormSections(List<IMultipartFormSection> multipartFormSections, byte[] boundary) => default; // 0x000000018C09D560-0x000000018C09DB68
		public static byte[] GenerateBoundary() => default; // 0x000000018C09C48C-0x000000018C09C524
		public static byte[] SerializeSimpleForm(Dictionary<string, string> formFields) => default; // 0x000000018C09DB68-0x000000018C09DDA0
	}

	public class CertificateHandler : IDisposable // TypeDefIndex: 60042
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
	
		// Constructors
		public CertificateHandler() {} // Dummy constructor
	
		// Methods
		private void Release() {} // 0x000000018C09C110-0x000000018C09C144
		protected virtual bool ValidateCertificate(byte[] certificateData) => default; // 0x0000000185FAFEF0-0x0000000185FAFF00
		internal bool ValidateCertificateNative(byte[] certificateData) => default; // 0x0000000185FAFEF0-0x0000000185FAFF00
		public void Dispose() {} // 0x000000018C09C0E8-0x000000018C09C110
	}

	public class DownloadHandler : IDisposable // TypeDefIndex: 60043
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
	
		// Properties
		public byte[] data { get => default; } // 0x0000000184F38440-0x0000000184F38450 
		public string text { get => default; } // 0x0000000186472AE0-0x0000000186472AEC 
	
		// Constructors
		internal DownloadHandler() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private void Release() {} // 0x00000001858E9D10-0x00000001858E9D50
		~DownloadHandler() {} // 0x0000000185BA91C0-0x0000000185BA9210
		public virtual void Dispose() {} // 0x00000001858E9CA0-0x00000001858E9CD0
		protected virtual NativeArray<byte> GetNativeData() => default; // 0x0000000185FE6E80-0x0000000185FE6E90
		protected virtual byte[] GetData() => default; // 0x0000000184F38440-0x0000000184F38450
		protected virtual string GetText() => default; // 0x0000000185594360-0x0000000185594420
		private Encoding GetTextEncoder() => default; // 0x00000001855945E0-0x0000000185594740
		private string GetContentType() => default; // 0x0000000185594740-0x0000000185594780
		protected virtual bool ReceiveData(byte[] data, int dataLength) => default; // 0x0000000185FC71B0-0x0000000185FC71C0
		protected virtual void ReceiveContentLengthHeader(ulong contentLength) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void ReceiveContentLength(int contentLength) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void CompleteContent() {} // 0x0000000185492010-0x0000000185492020
		protected virtual float GetProgress() => default; // 0x0000000185FE6C30-0x0000000185FE6C40
		internal static unsafe byte* InternalGetByteArray(DownloadHandler dh, out int length) {
			length = default;
			return default;
		} // 0x0000000185594590-0x00000001855945E0
		internal static byte[] InternalGetByteArray(DownloadHandler dh) => default; // 0x0000000185594420-0x00000001855944A0
		internal static NativeArray<byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<byte> nativeArray) => default; // 0x00000001855944D0-0x0000000185594590
		internal static void DisposeNativeArray(ref NativeArray<byte> data) {} // 0x00000001858E9CD0-0x00000001858E9D10
		internal static unsafe void CreateNativeArrayForNativeData(ref NativeArray<byte> data, byte* bytes, int length) {} // 0x0000000185594780-0x00000001855947E0
	}

	public sealed class DownloadHandlerBuffer : DownloadHandler // TypeDefIndex: 60044
	{
		// Fields
		private NativeArray<byte> m_NativeData; // 0x18
	
		// Constructors
		public DownloadHandlerBuffer() {} // 0x0000000184F38BD0-0x0000000184F38BF0
	
		// Methods
		private static IntPtr Create(DownloadHandlerBuffer obj) => default; // 0x0000000185EFC4A0-0x0000000185EFC4E0
		private void InternalCreateBuffer() {} // 0x0000000184F38BD0-0x0000000184F38BF0
		protected override NativeArray<byte> GetNativeData() => default; // 0x00000001855944A0-0x00000001855944D0
		public override void Dispose() {} // 0x00000001858E9C70-0x00000001858E9CA0
	}

	public class UploadHandler : IDisposable // TypeDefIndex: 60045
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
	
		// Properties
		public string contentType { set {} } // 0x0000000186472AEC-0x0000000186472AF4
	
		// Constructors
		internal UploadHandler() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private void Release() {} // 0x0000000185D6D0C0-0x0000000185D6D100
		~UploadHandler() {} // 0x0000000185BA91C0-0x0000000185BA9210
		public virtual void Dispose() {} // 0x0000000185D6D090-0x0000000185D6D0C0
		internal virtual void SetContentType(string newContentType) {} // 0x0000000186472AEC-0x0000000186472AF4
		private void InternalSetContentType(string newContentType) {} // 0x0000000185F8ACE0-0x0000000185F8AD30
	}

	public sealed class UploadHandlerRaw : UploadHandler // TypeDefIndex: 60046
	{
		// Fields
		private NativeArray<byte> m_Payload; // 0x18
	
		// Constructors
		public UploadHandlerRaw() {} // Dummy constructor
		public UploadHandlerRaw(byte[] data) {} // 0x0000000184F39490-0x0000000184F39530
		public UploadHandlerRaw(NativeArray<byte> data, bool transferOwnership) {} // 0x0000000184F39530-0x0000000184F395A0
	
		// Methods
		private static unsafe IntPtr Create(UploadHandlerRaw self, byte* data, int dataLength) => default; // 0x0000000184F395A0-0x0000000184F39600
		public override void Dispose() {} // 0x0000000185D6D030-0x0000000185D6D090
	}
}

namespace UnityEngineInternal
{
	internal static class WebRequestUtils // TypeDefIndex: 60033
	{
		// Fields
		private static Regex domainRegex; // 0x00
	
		// Constructors
		static WebRequestUtils() {} // 0x000000018549A7E0-0x000000018549A870
	
		// Methods
		internal static string RedirectTo(string baseUri, string redirectUri) => default; // 0x000000018C0A0C28-0x000000018C0A0D38
		internal static string MakeInitialUrl(string targetUrl, string localUrl) => default; // 0x0000000184F36140-0x0000000184F363A0
		internal static string MakeUriString(System.Uri targetUri, string targetUrl, bool prependProtocol) => default; // 0x0000000184F31690-0x0000000184F317E0
		private static string URLDecode(string encoded) => default; // 0x000000018C0A0D38-0x000000018C0A0DBC
	}
}
