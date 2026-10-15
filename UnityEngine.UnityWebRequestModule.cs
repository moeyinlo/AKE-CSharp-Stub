/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 84: UnityEngine.UnityWebRequestModule.dll - Assembly: UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89985-89999

namespace UnityEngine
{
	public class WWWForm // TypeDefIndex: 89987
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
		internal static Encoding DefaultEncoding { get; } // 0x000000018D6B5520-0x000000018D6B552C 
		public Dictionary<string, string> headers { get; } // 0x000000018D6B6224-0x000000018D6B633C 
		public byte[] data { get; } // 0x000000018D6B552C-0x000000018D6B6224 
	
		// Constructors
		static WWWForm(); // 0x000000018D6B5244-0x000000018D6B5520
	}

	[VisibleToOtherModules(new string[1] {"UnityEngine.UnityWebRequestWWWModule" })]
	internal class WWWTranscoder // TypeDefIndex: 89988
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
		static WWWTranscoder(); // 0x000000018D6B6E9C-0x000000018D6B715C
	
		// Methods
		private static byte Hex2Byte(byte[] b, int offset); // 0x000000018D6B6B64-0x000000018D6B6BE4
		private static void Byte2Hex(byte b, byte[] hexChars, out byte byte0, out byte byte1); // 0x000000018D6B633C-0x000000018D6B637C
		public static byte[] URLEncode(byte[] toEncode); // 0x000000018D6B6E34-0x000000018D6B6E9C
		public static string DataEncode(string toEncode); // 0x000000018D6B6454-0x000000018D6B64AC
		public static string DataEncode(string toEncode, Encoding e); // 0x000000018D6B6514-0x000000018D6B65EC
		public static byte[] DataEncode(byte[] toEncode); // 0x000000018D6B64AC-0x000000018D6B6514
		public static string QPEncode(string toEncode, Encoding e); // 0x000000018D6B6BE4-0x000000018D6B6CBC
		public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase); // 0x000000018D6B6830-0x000000018D6B6B64
		private static bool ByteArrayContains(byte[] array, byte b); // 0x000000018D6B637C-0x000000018D6B63C4
		public static byte[] URLDecode(byte[] toEncode); // 0x000000018D6B6DDC-0x000000018D6B6E34
		private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand); // 0x000000018D6B63C4-0x000000018D6B6454
		public static byte[] Decode(byte[] input, byte escapeChar, byte[] space); // 0x000000018D6B65EC-0x000000018D6B6830
		public static bool SevenBitClean(string s, Encoding e); // 0x000000018D6B6CEC-0x000000018D6B6DDC
		public static unsafe bool SevenBitClean(byte* input, int inputLength); // 0x000000018D6B6CBC-0x000000018D6B6CEC
	}
}

namespace UnityEngine.Networking
{
	public interface IMultipartFormSection // TypeDefIndex: 89989
	{
		// Properties
		string sectionName { get; }
		byte[] sectionData { get; }
		string fileName { get; }
		string contentType { get; }
	}

	[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
	[NativeHeader("UnityWebRequestScriptingClasses.h")]
	[UsedByNativeCode]
	public class UnityWebRequestAsyncOperation : AsyncOperation // TypeDefIndex: 89990
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private UnityWebRequest _webRequest_k__BackingField; // 0x20
	
		// Properties
		internal UnityWebRequest webRequest { [CompilerGenerated] set; } // 0x0000000187835950-0x0000000187835960
	
		// Constructors
		public UnityWebRequestAsyncOperation(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
	public class UnityWebRequest : IDisposable // TypeDefIndex: 89994
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
		public const string kHttpVerbGET = "GET"; // Metadata: 0x0264AA50
		public const string kHttpVerbHEAD = "HEAD"; // Metadata: 0x0264AA54
		public const string kHttpVerbPOST = "POST"; // Metadata: 0x0264AA59
		public const string kHttpVerbPUT = "PUT"; // Metadata: 0x0264AA5E
		public const string kHttpVerbCREATE = "CREATE"; // Metadata: 0x0264AA62
		public const string kHttpVerbDELETE = "DELETE"; // Metadata: 0x0264AA69
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposeCertificateHandlerOnDispose_k__BackingField; // 0x38
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposeDownloadHandlerOnDispose_k__BackingField; // 0x39
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposeUploadHandlerOnDispose_k__BackingField; // 0x3A
	
		// Properties
		public bool disposeCertificateHandlerOnDispose { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E070-0x000000018225E080 0x000000018225E080-0x000000018225E090
		public bool disposeDownloadHandlerOnDispose { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226ED20-0x000000018226ED30 0x000000018226ED30-0x000000018226ED40
		public bool disposeUploadHandlerOnDispose { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233610-0x0000000187233620 0x0000000187233640-0x0000000187233650
		public string method { get; set; } // 0x000000018D6B4BD0-0x000000018D6B4C70 0x0000000185A10FE0-0x0000000185A110B0
		public string error { get; } // 0x00000001863A0540-0x00000001863A0600 
		private bool use100Continue { get; set; } // 0x000000018D6B4D98-0x000000018D6B4DCC 0x000000018D6B5178-0x000000018D6B51BC
		public bool useHttpContinue { get; set; } // 0x000000018D6B4DCC-0x000000018D6B4DD8 0x000000018D6B51BC-0x000000018D6B5244
		public string url { get; set; } // 0x000000018D6B4D8C-0x000000018D6B4D98 0x0000000185A10F50-0x0000000185A10FE0
		public System.Uri uri { get; set; } // 0x000000018D6B4D20-0x000000018D6B4D8C 0x000000018D6B5088-0x000000018D6B5178
		public long responseCode { get; } // 0x00000001863A0650-0x00000001863A0690 
		public float uploadProgress { get; } // 0x000000018D6B4CAC-0x000000018D6B4CEC 
		public bool isModifiable { [NativeMethod("IsModifiable")] get; } // 0x0000000185A115B0-0x0000000185A115F0 
		public bool isDone { get; } // 0x00000001863A0520-0x00000001863A0540 
		[Obsolete("UnityWebRequest.isNetworkError is deprecated. Use (UnityWebRequest.result == UnityWebRequest.Result.ConnectionError) instead.", false)]
		public bool isNetworkError { get; } // 0x000000018D6B4BB8-0x000000018D6B4BD0 
		[Obsolete("UnityWebRequest.isHttpError is deprecated. Use (UnityWebRequest.result == UnityWebRequest.Result.ProtocolError) instead.", false)]
		public bool isHttpError { get; } // 0x000000018D6B4BA0-0x000000018D6B4BB8 
		public Result result { [NativeMethod("GetResult")] get; } // 0x00000001863A0600-0x00000001863A0640 
		public float downloadProgress { get; } // 0x000000018D6B4B2C-0x000000018D6B4B6C 
		public ulong uploadedBytes { get; } // 0x000000018D6B4CEC-0x000000018D6B4D20 
		public ulong downloadedBytes { get; } // 0x000000018D6B4B6C-0x000000018D6B4BA0 
		public int redirectLimit { get; set; } // 0x000000018D6B4C70-0x000000018D6B4C7C 0x000000018D6B4FA0-0x000000018D6B4FA8
		[Obsolete("HTTP/2 and many HTTP/1.1 servers don\'t support this; we recommend leaving it set to false (default).", false)]
		public bool chunkedTransfer { get; set; } // 0x000000018D6B4B20-0x000000018D6B4B2C 0x000000018D6B4EC0-0x000000018D6B4FA0
		public UploadHandler uploadHandler { get; set; } // 0x000000018725FED0-0x000000018725FEE0 0x0000000185A115F0-0x0000000185A11640
		public DownloadHandler downloadHandler { get; set; } // 0x0000000187244530-0x0000000187244540 0x0000000185A11690-0x0000000185A116E0
		public CertificateHandler certificateHandler { get; set; } // 0x0000000187261370-0x0000000187261380 0x000000018D6B4DD8-0x000000018D6B4EC0
		public int timeout { get; set; } // 0x000000018D6B4C88-0x000000018D6B4CAC 0x0000000185A12360-0x0000000185A123F0
		internal bool suppressErrorsToConsole { get; set; } // 0x000000018D6B4C7C-0x000000018D6B4C88 0x000000018D6B4FA8-0x000000018D6B5088
	
		// Nested types
		internal enum UnityWebRequestMethod // TypeDefIndex: 89991
		{
			Get = 0,
			Post = 1,
			Put = 2,
			Head = 3,
			Custom = 4
		}
	
		internal enum UnityWebRequestError // TypeDefIndex: 89992
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
	
		public enum Result // TypeDefIndex: 89993
		{
			InProgress = 0,
			Success = 1,
			ConnectionError = 2,
			ProtocolError = 3,
			DataProcessingError = 4
		}
	
		// Constructors
		public UnityWebRequest(); // 0x000000018D6B4A7C-0x000000018D6B4AA0
		public UnityWebRequest(string url); // 0x000000018D6B4AA0-0x000000018D6B4AE0
		public UnityWebRequest(System.Uri uri); // 0x000000018D6B4AE0-0x000000018D6B4B20
		public UnityWebRequest(string url, string method); // 0x00000001863A14C0-0x00000001863A1520
		public UnityWebRequest(System.Uri uri, string method); // 0x000000018D6B49A0-0x000000018D6B49F8
		public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler); // 0x0000000185A12440-0x0000000185A124D0
		public UnityWebRequest(System.Uri uri, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler); // 0x000000018D6B49F8-0x000000018D6B4A7C
	
		// Methods
		[NativeConditional("ENABLE_UNITYWEBREQUEST")]
		[NativeMethod(IsThreadSafe = true)]
		private static string GetWebErrorString(UnityWebRequestError err); // 0x000000018D6B2F14-0x000000018D6B2F48
		[VisibleToOtherModules]
		internal static string GetHTTPStatusString(long responseCode); // 0x00000001863A0C80-0x00000001863A0CC0
		public static void ClearCookieCache(); // 0x000000018D6B2748-0x000000018D6B2754
		public static void ClearCookieCache(System.Uri uri); // 0x000000018D6B2754-0x000000018D6B2810
		private static void ClearCookieCache(string domain, string path); // 0x000000018D6B2704-0x000000018D6B2748
		internal static IntPtr Create(); // 0x0000000185A124D0-0x0000000185A12510
		[NativeMethod(IsThreadSafe = true)]
		private void Release(); // 0x00000001869A3DB0-0x00000001869A3DF0
		internal void InternalDestroy(); // 0x00000001869A3D80-0x00000001869A3DB0
		private void InternalSetDefaults(); // 0x0000000187264230-0x0000000187264240
		~UnityWebRequest(); // 0x00000001869A3BE0-0x00000001869A3D10
		public void Dispose(); // 0x00000001869A3D10-0x00000001869A3D80
		private void DisposeHandlers(); // 0x00000001869A3E30-0x00000001869A3E90
		[NativeThrows]
		internal UnityWebRequestAsyncOperation BeginWebRequest(); // 0x00000001863A0270-0x00000001863A02B0
		[Obsolete("Use SendWebRequest.  It returns a UnityWebRequestAsyncOperation which contains a reference to the WebRequest object.", false)]
		public AsyncOperation Send(); // 0x000000018D6B3A84-0x000000018D6B3A90
		public UnityWebRequestAsyncOperation SendWebRequest(); // 0x00000001863A0240-0x00000001863A0270
		[NativeMethod(IsThreadSafe = true)]
		public void Abort(); // 0x00000001869A3DF0-0x00000001869A3E30
		private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType); // 0x0000000185A114D0-0x0000000185A11520
		internal void InternalSetMethod(UnityWebRequestMethod methodType); // 0x0000000185A11490-0x0000000185A114D0
		private UnityWebRequestError SetCustomMethod(string customMethodName); // 0x000000018D6B4360-0x000000018D6B43A4
		internal void InternalSetCustomMethod(string customMethodName); // 0x000000018D6B30E8-0x000000018D6B31C8
		internal UnityWebRequestMethod GetMethod(); // 0x000000018D6B2B44-0x000000018D6B2B78
		internal string GetCustomMethod(); // 0x000000018D6B2AA8-0x000000018D6B2ADC
		private UnityWebRequestError GetError(); // 0x000000018D6B2B10-0x000000018D6B2B44
		private string GetUrl(); // 0x000000018D6B2EE0-0x000000018D6B2F14
		private UnityWebRequestError SetUrl(string url); // 0x0000000185A11560-0x0000000185A115B0
		private void InternalSetUrl(string url); // 0x0000000185A11520-0x0000000185A11560
		private float GetUploadProgress(); // 0x000000018D6B2EAC-0x000000018D6B2EE0
		private bool IsExecuting(); // 0x000000018D6B31C8-0x000000018D6B31FC
		private float GetDownloadProgress(); // 0x000000018D6B2ADC-0x000000018D6B2B10
		private int GetRedirectLimit(); // 0x000000018D6B2B78-0x000000018D6B2BAC
		[NativeThrows]
		private void SetRedirectLimitFromScripting(int limit); // 0x000000018D6B43A4-0x000000018D6B43E4
		private bool GetChunked(); // 0x000000018D6B2A74-0x000000018D6B2AA8
		private UnityWebRequestError SetChunked(bool chunked); // 0x000000018D6B431C-0x000000018D6B4360
		public string GetRequestHeader(string name); // 0x000000018D6B2BAC-0x000000018D6B2BF0
		[NativeMethod("SetRequestHeader")]
		internal UnityWebRequestError InternalSetRequestHeader(string name, string value); // 0x0000000185A12300-0x0000000185A12360
		public void SetRequestHeader(string name, string value); // 0x0000000185A12290-0x0000000185A12300
		public string GetResponseHeader(string name); // 0x000000018D6B2C24-0x000000018D6B2C68
		internal string[] GetResponseHeaderKeys(); // 0x000000018D6B2BF0-0x000000018D6B2C24
		public Dictionary<string, string> GetResponseHeaders(); // 0x000000018D6B2C68-0x000000018D6B2D8C
		private UnityWebRequestError SetUploadHandler(UploadHandler uh); // 0x0000000185A11640-0x0000000185A11690
		private UnityWebRequestError SetDownloadHandler(DownloadHandler dh); // 0x0000000185A116E0-0x0000000185A11730
		private UnityWebRequestError SetCertificateHandler(CertificateHandler ch); // 0x000000018D6B42D8-0x000000018D6B431C
		private int GetTimeoutMsec(); // 0x000000018D6B2E78-0x000000018D6B2EAC
		private UnityWebRequestError SetTimeoutMsec(int timeout); // 0x0000000185A123F0-0x0000000185A12440
		private bool GetSuppressErrorsToConsole(); // 0x000000018D6B2D8C-0x000000018D6B2DC0
		private UnityWebRequestError SetSuppressErrorsToConsole(bool suppress); // 0x000000018D6B43E4-0x000000018D6B4428
		public static UnityWebRequest Get(string uri); // 0x0000000185A12510-0x0000000185A125D0
		public static UnityWebRequest Get(System.Uri uri); // 0x000000018D6B2F48-0x000000018D6B3000
		public static UnityWebRequest Delete(string uri); // 0x000000018D6B2884-0x000000018D6B28F8
		public static UnityWebRequest Delete(System.Uri uri); // 0x000000018D6B2810-0x000000018D6B2884
		public static UnityWebRequest Head(string uri); // 0x000000018D6B3000-0x000000018D6B3074
		public static UnityWebRequest Head(System.Uri uri); // 0x000000018D6B3074-0x000000018D6B30E8
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("UnityWebRequest.GetTexture is obsolete. Use UnityWebRequestTexture.GetTexture instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestTexture.GetTexture(*)", true)]
		public static UnityWebRequest GetTexture(string uri); // 0x000000018D6B2E1C-0x000000018D6B2E78
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("UnityWebRequest.GetTexture is obsolete. Use UnityWebRequestTexture.GetTexture instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestTexture.GetTexture(*)", true)]
		public static UnityWebRequest GetTexture(string uri, bool nonReadable); // 0x000000018D6B2DC0-0x000000018D6B2E1C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("UnityWebRequest.GetAudioClip is obsolete. Use UnityWebRequestMultimedia.GetAudioClip instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestMultimedia.GetAudioClip(*)", true)]
		public static UnityWebRequest GetAudioClip(string uri, AudioType audioType); // 0x000000018724EFC0-0x000000018724EFD0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("UnityWebRequest.GetAssetBundle is obsolete. Use UnityWebRequestAssetBundle.GetAssetBundle instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestAssetBundle.GetAssetBundle(*)", true)]
		public static UnityWebRequest GetAssetBundle(string uri); // 0x000000018724EFC0-0x000000018724EFD0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("UnityWebRequest.GetAssetBundle is obsolete. Use UnityWebRequestAssetBundle.GetAssetBundle instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestAssetBundle.GetAssetBundle(*)", true)]
		public static UnityWebRequest GetAssetBundle(string uri, uint crc); // 0x000000018724EFC0-0x000000018724EFD0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("UnityWebRequest.GetAssetBundle is obsolete. Use UnityWebRequestAssetBundle.GetAssetBundle instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestAssetBundle.GetAssetBundle(*)", true)]
		public static UnityWebRequest GetAssetBundle(string uri, uint version, uint crc); // 0x000000018724EFC0-0x000000018724EFD0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("UnityWebRequest.GetAssetBundle is obsolete. Use UnityWebRequestAssetBundle.GetAssetBundle instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestAssetBundle.GetAssetBundle(*)", true)]
		public static UnityWebRequest GetAssetBundle(string uri, Hash128 hash, uint crc); // 0x000000018724EFC0-0x000000018724EFD0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("UnityWebRequest.GetAssetBundle is obsolete. Use UnityWebRequestAssetBundle.GetAssetBundle instead (UnityUpgradable) -> [UnityEngine] UnityWebRequestAssetBundle.GetAssetBundle(*)", true)]
		public static UnityWebRequest GetAssetBundle(string uri, CachedAssetBundle cachedAssetBundle, uint crc); // 0x000000018724EFC0-0x000000018724EFD0
		public static UnityWebRequest Put(string uri, byte[] bodyData); // 0x000000018D6B387C-0x000000018D6B396C
		public static UnityWebRequest Put(System.Uri uri, byte[] bodyData); // 0x000000018D6B378C-0x000000018D6B387C
		public static UnityWebRequest Put(string uri, string bodyData); // 0x000000018D6B396C-0x000000018D6B3A84
		public static UnityWebRequest Put(System.Uri uri, string bodyData); // 0x000000018D6B3674-0x000000018D6B378C
		public static UnityWebRequest Post(string uri, string postData); // 0x00000001863A1430-0x00000001863A14C0
		public static UnityWebRequest Post(System.Uri uri, string postData); // 0x000000018D6B3230-0x000000018D6B32C0
		private static void SetupPost(UnityWebRequest request, string postData); // 0x00000001863A1520-0x00000001863A15E0
		public static UnityWebRequest Post(string uri, WWWForm formData); // 0x000000018D6B3384-0x000000018D6B3414
		public static UnityWebRequest Post(System.Uri uri, WWWForm formData); // 0x000000018D6B32C0-0x000000018D6B3350
		private static void SetupPost(UnityWebRequest request, WWWForm formData); // 0x000000018D6B452C-0x000000018D6B477C
		public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections); // 0x000000018D6B31FC-0x000000018D6B3230
		public static UnityWebRequest Post(System.Uri uri, List<IMultipartFormSection> multipartFormSections); // 0x000000018D6B3350-0x000000018D6B3384
		public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections, byte[] boundary); // 0x000000018D6B34B4-0x000000018D6B3554
		public static UnityWebRequest Post(System.Uri uri, List<IMultipartFormSection> multipartFormSections, byte[] boundary); // 0x000000018D6B3414-0x000000018D6B34B4
		private static void SetupPost(UnityWebRequest request, List<IMultipartFormSection> multipartFormSections, byte[] boundary); // 0x000000018D6B477C-0x000000018D6B48CC
		public static UnityWebRequest Post(string uri, Dictionary<string, string> formFields); // 0x000000018D6B35E4-0x000000018D6B3674
		public static UnityWebRequest Post(System.Uri uri, Dictionary<string, string> formFields); // 0x000000018D6B3554-0x000000018D6B35E4
		private static void SetupPost(UnityWebRequest request, Dictionary<string, string> formFields); // 0x000000018D6B4428-0x000000018D6B452C
		public static string EscapeURL(string s); // 0x000000018D6B28F8-0x000000018D6B291C
		public static string EscapeURL(string s, Encoding e); // 0x000000018D6B291C-0x000000018D6B29D0
		public static string UnEscapeURL(string s); // 0x000000018D6B497C-0x000000018D6B49A0
		public static string UnEscapeURL(string s, Encoding e); // 0x000000018D6B48CC-0x000000018D6B497C
		public static byte[] SerializeFormSections(List<IMultipartFormSection> multipartFormSections, byte[] boundary); // 0x000000018D6B3A90-0x000000018D6B4098
		public static byte[] GenerateBoundary(); // 0x000000018D6B29D0-0x000000018D6B2A74
		public static byte[] SerializeSimpleForm(Dictionary<string, string> formFields); // 0x000000018D6B4098-0x000000018D6B42D8
	}

	[NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
	public class CertificateHandler : IDisposable // TypeDefIndex: 89995
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
	
		// Methods
		[NativeMethod(IsThreadSafe = true)]
		private void Release(); // 0x000000018D6B26D0-0x000000018D6B2704
		protected virtual bool ValidateCertificate(byte[] certificateData); // 0x0000000187232850-0x0000000187232860
		[RequiredByNativeCode]
		internal bool ValidateCertificateNative(byte[] certificateData); // 0x0000000187232850-0x0000000187232860
		public void Dispose(); // 0x000000018D6B26A8-0x000000018D6B26D0
	}

	[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
	public class DownloadHandler : IDisposable // TypeDefIndex: 89996
	{
		// Fields
		[NonSerialized]
		[VisibleToOtherModules]
		internal IntPtr m_Ptr; // 0x10
	
		// Properties
		public byte[] data { get; } // 0x00000001863A0640-0x00000001863A0650 
		public string text { get; } // 0x000000018783C004-0x000000018783C010 
	
		// Constructors
		[VisibleToOtherModules]
		internal DownloadHandler(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[NativeMethod(IsThreadSafe = true)]
		private void Release(); // 0x00000001869E56C0-0x00000001869E5700
		~DownloadHandler(); // 0x0000000186B99550-0x0000000186B995A0
		public virtual void Dispose(); // 0x00000001869E5650-0x00000001869E5680
		protected virtual NativeArray<byte> GetNativeData(); // 0x00000001872606B0-0x00000001872606C0
		protected virtual byte[] GetData(); // 0x00000001863A0640-0x00000001863A0650
		protected virtual string GetText(); // 0x000000018537F0D0-0x000000018537F190
		private Encoding GetTextEncoder(); // 0x000000018537F2D0-0x000000018537F430
		private string GetContentType(); // 0x000000018537F430-0x000000018537F470
		[RequiredByNativeCode]
		protected virtual bool ReceiveData(byte[] data, int dataLength); // 0x0000000187249050-0x0000000187249060
		[RequiredByNativeCode]
		protected virtual void ReceiveContentLengthHeader(ulong contentLength); // 0x0000000186805BA0-0x0000000186805BB0
		[Obsolete("Use ReceiveContentLengthHeader")]
		protected virtual void ReceiveContentLength(int contentLength); // 0x0000000186805BA0-0x0000000186805BB0
		[RequiredByNativeCode]
		protected virtual void CompleteContent(); // 0x0000000186805BA0-0x0000000186805BB0
		[RequiredByNativeCode]
		protected virtual float GetProgress(); // 0x0000000187260470-0x0000000187260480
		[NativeThrows]
		[VisibleToOtherModules]
		internal static unsafe byte* InternalGetByteArray(DownloadHandler dh, out int length); // 0x000000018537F280-0x000000018537F2D0
		internal static byte[] InternalGetByteArray(DownloadHandler dh); // 0x000000018537F040-0x000000018537F0D0
		internal static NativeArray<byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<byte> nativeArray); // 0x000000018537F1C0-0x000000018537F280
		internal static void DisposeNativeArray(ref NativeArray<byte> data); // 0x00000001869E5680-0x00000001869E56C0
		internal static unsafe void CreateNativeArrayForNativeData(ref NativeArray<byte> data, byte* bytes, int length); // 0x000000018537F470-0x000000018537F4D0
	}

	[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerBuffer.h")]
	public sealed class DownloadHandlerBuffer : DownloadHandler // TypeDefIndex: 89997
	{
		// Fields
		private NativeArray<byte> m_NativeData; // 0x18
	
		// Constructors
		public DownloadHandlerBuffer(); // 0x0000000185A125D0-0x0000000185A125F0
	
		// Methods
		private static IntPtr Create(DownloadHandlerBuffer obj); // 0x0000000186E25550-0x0000000186E25590
		private void InternalCreateBuffer(); // 0x0000000185A125D0-0x0000000185A125F0
		protected override NativeArray<byte> GetNativeData(); // 0x000000018537F190-0x000000018537F1C0
		public override void Dispose(); // 0x00000001869E5620-0x00000001869E5650
	}

	[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
	public class UploadHandler : IDisposable // TypeDefIndex: 89998
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
	
		// Properties
		public string contentType { set; } // 0x000000018783C010-0x000000018783C018
	
		// Constructors
		internal UploadHandler(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[NativeMethod(IsThreadSafe = true)]
		private void Release(); // 0x0000000186D32B90-0x0000000186D32BD0
		~UploadHandler(); // 0x0000000186B99550-0x0000000186B995A0
		public virtual void Dispose(); // 0x0000000186D32B60-0x0000000186D32B90
		internal virtual void SetContentType(string newContentType); // 0x000000018783C010-0x000000018783C018
		[NativeMethod("SetContentType")]
		private void InternalSetContentType(string newContentType); // 0x000000018716CE10-0x000000018716CE60
	}

	[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandlerRaw.h")]
	public sealed class UploadHandlerRaw : UploadHandler // TypeDefIndex: 89999
	{
		// Fields
		private NativeArray<byte> m_Payload; // 0x18
	
		// Constructors
		public UploadHandlerRaw(byte[] data); // 0x00000001863A15E0-0x00000001863A16E0
		public UploadHandlerRaw(NativeArray<byte> data, bool transferOwnership); // 0x00000001863A16E0-0x00000001863A1770
	
		// Methods
		private static unsafe IntPtr Create(UploadHandlerRaw self, byte* data, int dataLength); // 0x00000001863A1770-0x00000001863A17D0
		public override void Dispose(); // 0x0000000186D32B00-0x0000000186D32B60
	}
}

namespace UnityEngineInternal
{
	internal static class WebRequestUtils // TypeDefIndex: 89986
	{
		// Fields
		private static Regex domainRegex; // 0x00
	
		// Constructors
		static WebRequestUtils(); // 0x0000000187170DE0-0x0000000187170E70
	
		// Methods
		[RequiredByNativeCode]
		internal static string RedirectTo(string baseUri, string redirectUri); // 0x000000018D6B715C-0x000000018D6B72E8
		internal static string MakeInitialUrl(string targetUrl, string localUrl); // 0x0000000185A109F0-0x0000000185A10C30
		internal static string MakeUriString(System.Uri targetUri, string targetUrl, bool prependProtocol); // 0x0000000185A10D60-0x0000000185A10F50
		private static string URLDecode(string encoded); // 0x000000018D6B72E8-0x000000018D6B736C
	}
}
