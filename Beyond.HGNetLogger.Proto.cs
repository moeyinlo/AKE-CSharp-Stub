/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

// Image 75: Beyond.HGNetLogger.Proto.dll - Assembly: Beyond.HGNetLogger.Proto, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62382-62412
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Network.HGNetLogger
{
	public static class MessageReflection // TypeDefIndex: 62383
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018637F41C-0x000000018637F46C 
	
		// Constructors
		static MessageReflection(); // 0x000000018637D8AC-0x000000018637F41C
	}

	public enum MessageType // TypeDefIndex: 62384
	{
		AuthRequest = 0,
		AuthResponse = 1,
		LogMessage = 2,
		LogMessageResponse = 3
	}

	public enum UploadPriority // TypeDefIndex: 62385
	{
		Low = 0,
		Normal = 1,
		High = 2,
		Critical = 3,
		Emergency = 4
	}

	public enum Version // TypeDefIndex: 62386
	{
		V0 = 0,
		V1 = 1,
		V2 = 2
	}

	public enum EncryptType // TypeDefIndex: 62387
	{
		None = 0
	}

	public enum LogLevel // TypeDefIndex: 62388
	{
		Debug = 0,
		Info = 1,
		Warn = 2,
		Error = 3,
		Fatal = 4,
		Important = 5
	}

	public enum NativeLogLevel // TypeDefIndex: 62389
	{
		None = 0,
		Debug = 1,
		Info = 2,
		Warn = 4,
		Error = 8,
		Fatal = 16,
		Important = 32
	}

	public enum ResponseStatus // TypeDefIndex: 62390
	{
		Ok = 0,
		PackageCheckFailed = 400,
		TooManyTemplate = 401,
		TemplateParamCountNotMatch = 402,
		AuthFailed = 403,
		TemplateNotFound = 404,
		InvalidAppId = 405,
		InvalidToken = 406,
		InvalidProtocolVersion = 407,
		UnsupportedMessageType = 408,
		UnexpectedSeqId = 409,
		ChecksumFailed = 410
	}

	public sealed class Header : IMessage<Beyond.Network.HGNetLogger.Header>, IBufferMessage // TypeDefIndex: 62392
	{
		// Fields
		private static readonly MessageParser<Header> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int VersionFieldNumber = 1; // Metadata: 0x023519C7
		private Beyond.Network.HGNetLogger.Version version_; // 0x18
		public const int MessageTypeFieldNumber = 2; // Metadata: 0x023519C8
		private MessageType messageType_; // 0x1C
		public const int SeqIdFieldNumber = 3; // Metadata: 0x023519C9
		private uint seqId_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Header> Parser { get; } // 0x000000018637A434-0x000000018637A484 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x000000018637A3D4-0x000000018637A434 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x000000018637A484-0x000000018637A4C4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Beyond.Network.HGNetLogger.Version Version { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageType MessageType { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SeqId { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62391
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000184D45310-0x0000000184D45370
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Header _.cctor_b__37_0(); // 0x000000018637F660-0x000000018637F69C
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Header(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Header(Header other); // 0x000000018637A38C-0x000000018637A3D4
		static Header(); // 0x0000000184B7D090-0x0000000184B7D1A0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Header Clone(); // 0x000000018637A1A4-0x000000018637A204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x000000018637A240-0x000000018637A2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Header other); // 0x000000018637A204-0x000000018637A240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018637A2A4-0x000000018637A2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x000000018637A340-0x000000018637A38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x00000001830788E0-0x0000000183078910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000183079BE0-0x0000000183079C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000183295DA0-0x0000000183295E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Header other); // 0x000000018637A2EC-0x000000018637A340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x00000001831422F0-0x0000000183142320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x000000018353AFF0-0x000000018353B090
	}

	public sealed class AuthRequest : IMessage<Beyond.Network.HGNetLogger.AuthRequest>, IBufferMessage // TypeDefIndex: 62394
	{
		// Fields
		private static readonly MessageParser<AuthRequest> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int TokenFieldNumber = 1; // Metadata: 0x023519CA
		private string token_; // 0x18
		public const int UidFieldNumber = 2; // Metadata: 0x023519CB
		private string uid_; // 0x20
		public const int DidFieldNumber = 3; // Metadata: 0x023519CC
		private string did_; // 0x28
		public const int AppIdFieldNumber = 4; // Metadata: 0x023519CD
		private string appId_; // 0x30
		public const int OsFieldNumber = 5; // Metadata: 0x023519CE
		private string os_; // 0x38
		public const int OsVersionFieldNumber = 6; // Metadata: 0x023519CF
		private string osVersion_; // 0x40
		public const int AppVersionFieldNumber = 7; // Metadata: 0x023519D0
		private string appVersion_; // 0x48
		public const int LogSdkVersionFieldNumber = 8; // Metadata: 0x023519D1
		private string logSdkVersion_; // 0x50
		public const int DeviceModelFieldNumber = 9; // Metadata: 0x023519D2
		private string deviceModel_; // 0x58
		public const int NetworkTypeFieldNumber = 10; // Metadata: 0x023519D3
		private string networkType_; // 0x60
		public const int DeviceNameFieldNumber = 11; // Metadata: 0x023519D4
		private string deviceName_; // 0x68
		public const int ServerNameFieldNumber = 12; // Metadata: 0x023519D5
		private string serverName_; // 0x70
		public const int ServerChannelFieldNumber = 13; // Metadata: 0x023519D6
		private string serverChannel_; // 0x78
		public const int GameLaunchTimeFieldNumber = 14; // Metadata: 0x023519D7
		private long gameLaunchTime_; // 0x80
		public const int AccountAliasFieldNumber = 15; // Metadata: 0x023519D8
		private string accountAlias_; // 0x88
		public const int DevVersionFieldNumber = 16; // Metadata: 0x023519D9
		private string devVersion_; // 0x90
		public const int UploadPriorityFieldNumber = 18; // Metadata: 0x023519DA
		private UploadPriority uploadPriority_; // 0x98
		public const int CharacterIdFieldNumber = 19; // Metadata: 0x023519DB
		private string characterId_; // 0xA0
		public const int RoleIdFieldNumber = 20; // Metadata: 0x023519DC
		private long roleId_; // 0xA8
		public const int ExtraFieldNumber = 17; // Metadata: 0x023519DD
		private static readonly MapField<string, string> _map_extra_codec; // 0x08
		private readonly MapField<string, string> extra_; // 0xB0
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AuthRequest> Parser { get; } // 0x00000001863794F4-0x0000000186379544 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000186379494-0x00000001863794F4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x000000018637990C-0x000000018637994C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Token { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000183814FB0-0x0000000183815020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Uid { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000183814F40-0x0000000183814FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Did { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000183814ED0-0x0000000183814F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AppId { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000183814E60-0x0000000183814ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Os { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x0000000183814DF0-0x0000000183814E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OsVersion { get; set; } // 0x0000000184D85A60-0x0000000184D85A70 0x0000000183814D80-0x0000000183814DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AppVersion { get; set; } // 0x0000000184D86200-0x0000000184D86210 0x0000000183814D10-0x0000000183814D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LogSdkVersion { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000183814CA0-0x0000000183814D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DeviceModel { get; set; } // 0x0000000182E56440-0x0000000182E56460 0x0000000183814C30-0x0000000183814CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string NetworkType { get; set; } // 0x0000000184D86280-0x0000000184D86290 0x0000000183814BC0-0x0000000183814C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DeviceName { get; set; } // 0x0000000184D86230-0x0000000184D86240 0x0000000183814B50-0x0000000183814BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ServerName { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x0000000183814AE0-0x0000000183814B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ServerChannel { get; set; } // 0x0000000184D862A0-0x0000000184D862B0 0x0000000183814A70-0x0000000183814AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long GameLaunchTime { get; set; } // 0x0000000184D86260-0x0000000184D86270 0x0000000184D862E0-0x0000000184D862F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AccountAlias { get; set; } // 0x0000000184D861F0-0x0000000184D86200 0x0000000183814A00-0x0000000183814A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DevVersion { get; set; } // 0x0000000184D86220-0x0000000184D86230 0x0000000183814990-0x0000000183814A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UploadPriority UploadPriority { get; set; } // 0x0000000184D862D0-0x0000000184D862E0 0x0000000184D86300-0x0000000184D86310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CharacterId { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000183814920-0x0000000183814990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RoleId { get; set; } // 0x0000000184D86290-0x0000000184D862A0 0x0000000184D862F0-0x0000000184D86300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, string> Extra { get; } // 0x0000000184D86250-0x0000000184D86260 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62393
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000184D419B0-0x0000000184D41A10
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal AuthRequest _.cctor_b__122_0(); // 0x000000018637F4BC-0x000000018637F50C
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AuthRequest(); // 0x0000000183815020-0x0000000183815210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AuthRequest(AuthRequest other); // 0x00000001863792AC-0x0000000186379494
		static AuthRequest(); // 0x0000000184A1E0E0-0x0000000184A1E2B0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AuthRequest Clone(); // 0x00000001863789EC-0x0000000186378A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000186378C94-0x0000000186378CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AuthRequest other); // 0x0000000186378A4C-0x0000000186378C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000186378CF8-0x0000000186378F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000186379260-0x00000001863792AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x00000001831420E0-0x0000000183142110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x000000018446A8F0-0x000000018446AD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x000000018446D550-0x000000018446DAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AuthRequest other); // 0x0000000186378F88-0x0000000186379260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000186379544-0x000000018637990C
	}

	public sealed class LogControl : IMessage<Beyond.Network.HGNetLogger.LogControl>, IBufferMessage // TypeDefIndex: 62396
	{
		// Fields
		private static readonly MessageParser<LogControl> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int GlobalEnabledFieldNumber = 1; // Metadata: 0x023519DE
		private bool globalEnabled_; // 0x18
		public const int DefaultLogLevelMaskFieldNumber = 2; // Metadata: 0x023519DF
		private int defaultLogLevelMask_; // 0x1C
		public const int ModuleControlFieldNumber = 3; // Metadata: 0x023519E0
		private static readonly MapField<int, int> _map_moduleControl_codec; // 0x08
		private readonly MapField<int, int> moduleControl_; // 0x20
		public const int PolicyIdFieldNumber = 4; // Metadata: 0x023519E1
		private string policyId_; // 0x28
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogControl> Parser { get; } // 0x000000018637AFD4-0x000000018637B024 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x000000018637AF74-0x000000018637AFD4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x000000018637B134-0x000000018637B174 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GlobalEnabled { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DefaultLogLevelMask { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ModuleControl { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PolicyId { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x00000001845591D0-0x0000000184559240
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62395
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000184D495D0-0x0000000184D49630
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal LogControl _.cctor_b__42_0(); // 0x000000018637F6EC-0x000000018637F73C
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogControl(); // 0x000000018422B3C0-0x000000018422B460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogControl(LogControl other); // 0x000000018637AED0-0x000000018637AF74
		static LogControl(); // 0x000000018410CE40-0x000000018410D000
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogControl Clone(); // 0x000000018637ABC8-0x000000018637AC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x000000018637AC28-0x000000018637AC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogControl other); // 0x000000018637AC8C-0x000000018637AD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018637AD2C-0x000000018637ADD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x000000018637AE84-0x000000018637AED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x000000018637B024-0x000000018637B134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x000000018637AAC4-0x000000018637ABC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogControl other); // 0x000000018637ADD4-0x000000018637AE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x00000001845590E0-0x00000001845591D0
	}

	public sealed class AuthResponse : IMessage<Beyond.Network.HGNetLogger.AuthResponse>, IBufferMessage // TypeDefIndex: 62398
	{
		// Fields
		private static readonly MessageParser<AuthResponse> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int StatusFieldNumber = 1; // Metadata: 0x023519E2
		private ResponseStatus status_; // 0x18
		public const int MessageFieldNumber = 2; // Metadata: 0x023519E3
		private string message_; // 0x20
		public const int EncryptTypeFieldNumber = 3; // Metadata: 0x023519E4
		private EncryptType encryptType_; // 0x28
		public const int KeyFieldNumber = 4; // Metadata: 0x023519E5
		private string key_; // 0x30
		public const int CloudLogControlFieldNumber = 5; // Metadata: 0x023519E6
		private LogControl cloudLogControl_; // 0x38
		public const int LocalLogControlFieldNumber = 6; // Metadata: 0x023519E7
		private LogControl localLogControl_; // 0x40
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AuthResponse> Parser { get; } // 0x0000000186379F94-0x0000000186379FE4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x0000000186379F34-0x0000000186379F94 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x000000018637A0FC-0x000000018637A13C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResponseStatus Status { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Message { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x000000018637A13C-0x000000018637A1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncryptType EncryptType { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Key { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x000000018422B8D0-0x000000018422B940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogControl CloudLogControl { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogControl LocalLogControl { get; set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62397
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000184D403F0-0x0000000184D40450
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal AuthResponse _.cctor_b__52_0(); // 0x000000018637F73C-0x000000018637F78C
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AuthResponse(); // 0x0000000184A1A410-0x0000000184A1A470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AuthResponse(AuthResponse other); // 0x0000000186379E6C-0x0000000186379F34
		static AuthResponse(); // 0x0000000184B81D10-0x0000000184B81E20
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AuthResponse Clone(); // 0x0000000186379A94-0x0000000186379AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x0000000186379B94-0x0000000186379BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AuthResponse other); // 0x0000000186379AF4-0x0000000186379B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x0000000186379BF8-0x0000000186379CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x0000000186379E20-0x0000000186379E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000186379FE4-0x000000018637A0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x000000018637994C-0x0000000186379A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AuthResponse other); // 0x0000000186379CB4-0x0000000186379E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x00000001831420B0-0x00000001831420E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x000000018422B270-0x000000018422B3C0
	}

	public sealed class LogIntParam : IMessage<Beyond.Network.HGNetLogger.LogIntParam>, IBufferMessage // TypeDefIndex: 62400
	{
		// Fields
		private static readonly MessageParser<LogIntParam> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValFieldNumber = 1; // Metadata: 0x023519E8
		private long val_; // 0x18
		public const int IndexFieldNumber = 2; // Metadata: 0x023519E9
		private int index_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogIntParam> Parser { get; } // 0x000000018637BF30-0x000000018637BF80 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x000000018637BED0-0x000000018637BF30 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x000000018637C090-0x000000018637C0D0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Val { get; set; } // 0x000000018385B100-0x000000018385B110 0x00000001811EC9D0-0x00000001811EC9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62399
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000184D48FD0-0x0000000184D49030
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal LogIntParam _.cctor_b__32_0(); // 0x000000018637F598-0x000000018637F5D4
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogIntParam(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogIntParam(LogIntParam other); // 0x000000018637B49C-0x000000018637B4E0
		static LogIntParam(); // 0x0000000184B7C700-0x0000000184B7C810
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogIntParam Clone(); // 0x000000018637BCF4-0x000000018637BD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x000000018637BD54-0x000000018637BDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogIntParam other); // 0x000000018637BDB8-0x000000018637BDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018637BDEC-0x000000018637BE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x000000018637BE84-0x000000018637BED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x000000018637C018-0x000000018637C090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x000000018637BC58-0x000000018637BCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogIntParam other); // 0x000000018637BE38-0x000000018637BE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x000000018637BF80-0x000000018637C018
	}

	public sealed class LogFloatParam : IMessage<Beyond.Network.HGNetLogger.LogFloatParam>, IBufferMessage // TypeDefIndex: 62402
	{
		// Fields
		private static readonly MessageParser<LogFloatParam> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValFieldNumber = 1; // Metadata: 0x023519EA
		private float val_; // 0x18
		public const int IndexFieldNumber = 2; // Metadata: 0x023519EB
		private int index_; // 0x1C
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogFloatParam> Parser { get; } // 0x000000018637BAB0-0x000000018637BB00 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x000000018637BA50-0x000000018637BAB0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x000000018637BC18-0x000000018637BC58 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Val { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62401
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000184D3F070-0x0000000184D3F0D0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal LogFloatParam _.cctor_b__32_0(); // 0x000000018637F50C-0x000000018637F548
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogFloatParam(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogFloatParam(LogFloatParam other); // 0x000000018637BA10-0x000000018637BA50
		static LogFloatParam(); // 0x0000000184B7C810-0x0000000184B7C920
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogFloatParam Clone(); // 0x000000018637B778-0x000000018637B7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x000000018637B7D8-0x000000018637B83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogFloatParam other); // 0x000000018637B83C-0x000000018637B8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018637B8D4-0x000000018637B970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x000000018637B9C4-0x000000018637BA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x000000018637BB98-0x000000018637BC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x000000018637B6E8-0x000000018637B778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogFloatParam other); // 0x000000018637B970-0x000000018637B9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x000000018637BB00-0x000000018637BB98
	}

	public sealed class LogDoubleParam : IMessage<Beyond.Network.HGNetLogger.LogDoubleParam>, IBufferMessage // TypeDefIndex: 62404
	{
		// Fields
		private static readonly MessageParser<LogDoubleParam> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValFieldNumber = 1; // Metadata: 0x023519EC
		private double val_; // 0x18
		public const int IndexFieldNumber = 2; // Metadata: 0x023519ED
		private int index_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogDoubleParam> Parser { get; } // 0x000000018637B540-0x000000018637B590 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x000000018637B4E0-0x000000018637B540 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x000000018637B6A8-0x000000018637B6E8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Val { get; set; } // 0x0000000184D86360-0x0000000184D86370 0x0000000184D86370-0x0000000184D86380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62403
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000184D462D0-0x0000000184D46330
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal LogDoubleParam _.cctor_b__32_0(); // 0x000000018637F624-0x000000018637F660
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogDoubleParam(); // 0x00000001841E1670-0x00000001841E1680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogDoubleParam(LogDoubleParam other); // 0x000000018637B49C-0x000000018637B4E0
		static LogDoubleParam(); // 0x0000000184B7C920-0x0000000184B7CA30
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogDoubleParam Clone(); // 0x000000018637B204-0x000000018637B264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x000000018637B264-0x000000018637B2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogDoubleParam other); // 0x000000018637B2C8-0x000000018637B35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018637B35C-0x000000018637B3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x000000018637B450-0x000000018637B49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x000000018637B628-0x000000018637B6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x000000018637B174-0x000000018637B204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogDoubleParam other); // 0x000000018637B3F8-0x000000018637B450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x000000018637B590-0x000000018637B628
	}

	public sealed class LogBoolParam : IMessage<Beyond.Network.HGNetLogger.LogBoolParam>, IBufferMessage // TypeDefIndex: 62406
	{
		// Fields
		private static readonly MessageParser<LogBoolParam> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValFieldNumber = 1; // Metadata: 0x023519EE
		private string val_; // 0x18
		public const int IndexFieldNumber = 2; // Metadata: 0x023519EF
		private int index_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogBoolParam> Parser { get; } // 0x000000018637A8A8-0x000000018637A8F8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x000000018637A848-0x000000018637A8A8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x000000018637AA1C-0x000000018637AA5C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Val { get; set; } // 0x000000018385B100-0x000000018385B110 0x000000018637AA5C-0x000000018637AAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62405
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000184D3F1F0-0x0000000184D3F250
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal LogBoolParam _.cctor_b__32_0(); // 0x000000018637F548-0x000000018637F598
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogBoolParam(); // 0x000000018637A808-0x000000018637A848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogBoolParam(LogBoolParam other); // 0x000000018637A7A8-0x000000018637A808
		static LogBoolParam(); // 0x0000000184B7CA30-0x0000000184B7CB40
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogBoolParam Clone(); // 0x000000018637A56C-0x000000018637A5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x000000018637A628-0x000000018637A68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogBoolParam other); // 0x000000018637A5CC-0x000000018637A628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018637A68C-0x000000018637A6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x000000018637A75C-0x000000018637A7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x000000018637A998-0x000000018637AA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x000000018637A4C4-0x000000018637A56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogBoolParam other); // 0x000000018637A6F0-0x000000018637A75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x000000018637A8F8-0x000000018637A998
	}

	public sealed class LogStringParam : IMessage<Beyond.Network.HGNetLogger.LogStringParam>, IBufferMessage // TypeDefIndex: 62408
	{
		// Fields
		private static readonly MessageParser<LogStringParam> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValFieldNumber = 1; // Metadata: 0x023519F0
		private string val_; // 0x18
		public const int IndexFieldNumber = 2; // Metadata: 0x023519F1
		private int index_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogStringParam> Parser { get; } // 0x000000018637D714-0x000000018637D764 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x000000018637D6B4-0x000000018637D714 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x000000018637D804-0x000000018637D844 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Val { get; set; } // 0x000000018385B100-0x000000018385B110 0x000000018637D844-0x000000018637D8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62407
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000184D42A30-0x0000000184D42A90
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal LogStringParam _.cctor_b__32_0(); // 0x000000018637F5D4-0x000000018637F624
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogStringParam(); // 0x000000018637D614-0x000000018637D654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogStringParam(LogStringParam other); // 0x000000018637D654-0x000000018637D6B4
		static LogStringParam(); // 0x0000000184B7C4E0-0x0000000184B7C5F0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogStringParam Clone(); // 0x000000018637D498-0x000000018637D4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x000000018637D4F8-0x000000018637D55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogStringParam other); // 0x000000018637A5CC-0x000000018637A628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018637A68C-0x000000018637A6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x000000018637D5C8-0x000000018637D614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x000000018637A998-0x000000018637AA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x000000018637D3F0-0x000000018637D498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogStringParam other); // 0x000000018637D55C-0x000000018637D5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x000000018637D764-0x000000018637D804
	}

	public sealed class LogMessage : IMessage<Beyond.Network.HGNetLogger.LogMessage>, IBufferMessage // TypeDefIndex: 62410
	{
		// Fields
		private static readonly MessageParser<LogMessage> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int LogTemplateFieldNumber = 1; // Metadata: 0x023519F2
		private string logTemplate_; // 0x18
		public const int TemplateHashFieldNumber = 2; // Metadata: 0x023519F3
		private uint templateHash_; // 0x20
		public const int LogLevelFieldNumber = 3; // Metadata: 0x023519F4
		private LogLevel logLevel_; // 0x24
		public const int ChannelFieldNumber = 4; // Metadata: 0x023519F5
		private int channel_; // 0x28
		public const int TimeFieldNumber = 5; // Metadata: 0x023519F6
		private long time_; // 0x30
		public const int FrameCountFieldNumber = 12; // Metadata: 0x023519F7
		private uint frameCount_; // 0x38
		public const int PlayerPosXFieldNumber = 13; // Metadata: 0x023519F8
		private float playerPosX_; // 0x3C
		public const int PlayerPosYFieldNumber = 15; // Metadata: 0x023519F9
		private float playerPosY_; // 0x40
		public const int PlayerPosZFieldNumber = 16; // Metadata: 0x023519FA
		private float playerPosZ_; // 0x44
		public const int PlayerPingFieldNumber = 14; // Metadata: 0x023519FB
		private int playerPing_; // 0x48
		public const int ParamsIntListFieldNumber = 6; // Metadata: 0x023519FC
		private static readonly FieldCodec<LogIntParam> _repeated_paramsIntList_codec; // 0x08
		private readonly RepeatedField<LogIntParam> paramsIntList_; // 0x50
		public const int ParamsFloatListFieldNumber = 7; // Metadata: 0x023519FD
		private static readonly FieldCodec<LogFloatParam> _repeated_paramsFloatList_codec; // 0x10
		private readonly RepeatedField<LogFloatParam> paramsFloatList_; // 0x58
		public const int ParamsDoubleListFieldNumber = 8; // Metadata: 0x023519FE
		private static readonly FieldCodec<LogDoubleParam> _repeated_paramsDoubleList_codec; // 0x18
		private readonly RepeatedField<LogDoubleParam> paramsDoubleList_; // 0x60
		public const int ParamsBoolListFieldNumber = 9; // Metadata: 0x023519FF
		private static readonly FieldCodec<LogBoolParam> _repeated_paramsBoolList_codec; // 0x20
		private readonly RepeatedField<LogBoolParam> paramsBoolList_; // 0x68
		public const int ParamsStringListFieldNumber = 10; // Metadata: 0x02351A00
		private static readonly FieldCodec<LogStringParam> _repeated_paramsStringList_codec; // 0x28
		private readonly RepeatedField<LogStringParam> paramsStringList_; // 0x70
		public const int NativeLogLevelFieldNumber = 17; // Metadata: 0x02351A01
		private NativeLogLevel nativeLogLevel_; // 0x78
		public const int ReturnLoginCountFieldNumber = 21; // Metadata: 0x02351A02
		private int returnLoginCount_; // 0x7C
		public const int AppPauseCountFieldNumber = 22; // Metadata: 0x02351A03
		private int appPauseCount_; // 0x80
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogMessage> Parser { get; } // 0x000000018637CF98-0x000000018637CFE8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x000000018637CF38-0x000000018637CF98 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x000000018637D3B0-0x000000018637D3F0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LogTemplate { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000183535260-0x00000001835352A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TemplateHash { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogLevel LogLevel { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Channel { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Time { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x00000001811F36F0-0x00000001811F3700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FrameCount { get; set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PlayerPosX { get; set; } // 0x0000000184D863E0-0x0000000184D863F0 0x0000000184D86460-0x0000000184D86470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PlayerPosY { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PlayerPosZ { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerPing { get; set; } // 0x0000000184D863D0-0x0000000184D863E0 0x0000000184D86450-0x0000000184D86460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LogIntParam> ParamsIntList { get; } // 0x0000000184D86270-0x0000000184D86280 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LogFloatParam> ParamsFloatList { get; } // 0x0000000182E56440-0x0000000182E56460 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LogDoubleParam> ParamsDoubleList { get; } // 0x0000000184D86280-0x0000000184D86290 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LogBoolParam> ParamsBoolList { get; } // 0x0000000184D86230-0x0000000184D86240 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LogStringParam> ParamsStringList { get; } // 0x0000000184D862B0-0x0000000184D862C0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NativeLogLevel NativeLogLevel { get; set; } // 0x0000000184D863C0-0x0000000184D863D0 0x0000000184D86440-0x0000000184D86450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReturnLoginCount { get; set; } // 0x0000000184D86410-0x0000000184D86420 0x0000000184D86490-0x0000000184D864A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AppPauseCount { get; set; } // 0x0000000184D863A0-0x0000000184D863B0 0x0000000184D86420-0x0000000184D86430
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62409
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000184D43E10-0x0000000184D43E70
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal LogMessage _.cctor_b__112_0(); // 0x000000018637F46C-0x000000018637F4BC
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogMessage(); // 0x0000000183D91E30-0x0000000183D91F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogMessage(LogMessage other); // 0x000000018637CD84-0x000000018637CF38
		static LogMessage(); // 0x0000000184821800-0x0000000184821CD0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogMessage Clone(); // 0x000000018637C5EC-0x000000018637C64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x000000018637C64C-0x000000018637C6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogMessage other); // 0x000000018637C6B0-0x000000018637C920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018637C920-0x000000018637CB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x000000018637CD38-0x000000018637CD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000183078650-0x0000000183078680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x0000000183079C70-0x000000018307A030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x0000000183295A60-0x0000000183295DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogMessage other); // 0x000000018637CB48-0x000000018637CD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x0000000184D51840-0x0000000184D51870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x000000018637CFE8-0x000000018637D3B0
	}

	public sealed class LogMessageResponse : IMessage<Beyond.Network.HGNetLogger.LogMessageResponse>, IBufferMessage // TypeDefIndex: 62412
	{
		// Fields
		private static readonly MessageParser<LogMessageResponse> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int StatusFieldNumber = 1; // Metadata: 0x02351A04
		private ResponseStatus status_; // 0x18
		public const int MessageFieldNumber = 2; // Metadata: 0x02351A05
		private string message_; // 0x20
		public const int TemplateHashFieldNumber = 3; // Metadata: 0x02351A06
		private uint templateHash_; // 0x28
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogMessageResponse> Parser { get; } // 0x000000018637C4B8-0x000000018637C508 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get; } // 0x000000018637C458-0x000000018637C4B8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get; } // 0x000000018637C5AC-0x000000018637C5EC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResponseStatus Status { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Message { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000183536DF0-0x0000000183536E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TemplateHash { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62411
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000184D4B190-0x0000000184D4B1F0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal LogMessageResponse _.cctor_b__37_0(); // 0x000000018637F69C-0x000000018637F6EC
		}
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogMessageResponse(); // 0x00000001842F3E20-0x00000001842F4210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogMessageResponse(LogMessageResponse other); // 0x000000018637C3F4-0x000000018637C458
		static LogMessageResponse(); // 0x0000000184B7C5F0-0x0000000184B7C700
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogMessageResponse Clone(); // 0x000000018637C19C-0x000000018637C1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other); // 0x000000018637C260-0x000000018637C2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogMessageResponse other); // 0x000000018637C1FC-0x000000018637C260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode(); // 0x000000018637C2C4-0x000000018637C330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString(); // 0x000000018637C3A8-0x000000018637C3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output); // 0x0000000184D52400-0x0000000184D52430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output); // 0x000000018637C508-0x000000018637C5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize(); // 0x000000018637C0D0-0x000000018637C19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogMessageResponse other); // 0x000000018637C330-0x000000018637C3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input); // 0x00000001831420B0-0x00000001831420E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input); // 0x0000000183536E60-0x0000000183536EF0
	}
}
