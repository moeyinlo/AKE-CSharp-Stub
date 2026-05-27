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

// Image 74: Beyond.HGNetLogger.Proto.dll - Assembly: Beyond.HGNetLogger.Proto, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58792-58822
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Network.HGNetLogger
{
	public static class MessageReflection // TypeDefIndex: 58793
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018516BCE0-0x000000018516BD30 
	
		// Constructors
		static MessageReflection() {} // 0x000000018516A170-0x000000018516BCE0
	}

	public enum MessageType // TypeDefIndex: 58794
	{
		AuthRequest = 0,
		AuthResponse = 1,
		LogMessage = 2,
		LogMessageResponse = 3
	}

	public enum UploadPriority // TypeDefIndex: 58795
	{
		Low = 0,
		Normal = 1,
		High = 2,
		Critical = 3,
		Emergency = 4
	}

	public enum Version // TypeDefIndex: 58796
	{
		V0 = 0,
		V1 = 1,
		V2 = 2
	}

	public enum EncryptType // TypeDefIndex: 58797
	{
		None = 0
	}

	public enum LogLevel // TypeDefIndex: 58798
	{
		Debug = 0,
		Info = 1,
		Warn = 2,
		Error = 3,
		Fatal = 4,
		Important = 5
	}

	public enum NativeLogLevel // TypeDefIndex: 58799
	{
		None = 0,
		Debug = 1,
		Info = 2,
		Warn = 4,
		Error = 8,
		Fatal = 16,
		Important = 32
	}

	public enum ResponseStatus // TypeDefIndex: 58800
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

	public sealed class Header : IMessage<Beyond.Network.HGNetLogger.Header>, IBufferMessage // TypeDefIndex: 58802
	{
		// Fields
		private static readonly MessageParser<Header> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int VersionFieldNumber = 1; // Metadata: 0x01FDC6C5
		private Beyond.Network.HGNetLogger.Version version_; // 0x18
		public const int MessageTypeFieldNumber = 2; // Metadata: 0x01FDC6C6
		private MessageType messageType_; // 0x1C
		public const int SeqIdFieldNumber = 3; // Metadata: 0x01FDC6C7
		private uint seqId_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Header> Parser { get => default; } // 0x0000000185166A94-0x0000000185166AE4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000185166A34-0x0000000185166A94 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000185166AE4-0x0000000185166B24 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Beyond.Network.HGNetLogger.Version Version { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MessageType MessageType { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SeqId { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Header() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Header(Header other) {} // 0x00000001851669EC-0x0000000185166A34
		static Header() {} // 0x0000000183B689A0-0x0000000183B68AB0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Header Clone() => default; // 0x0000000185166804-0x0000000185166864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x00000001851668A0-0x0000000185166904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Header other) => default; // 0x0000000185166864-0x00000001851668A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000185166904-0x000000018516694C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x00000001851669A0-0x00000001851669EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x00000001824D3AA0-0x00000001824D3B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001824D3E40-0x00000001824D3ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x00000001824D5B80-0x00000001824D5C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Header other) {} // 0x000000018516694C-0x00000001851669A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000182942420-0x0000000182942450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001836D8930-0x00000001836D89D0
	}

	public sealed class AuthRequest : IMessage<Beyond.Network.HGNetLogger.AuthRequest>, IBufferMessage // TypeDefIndex: 58804
	{
		// Fields
		private static readonly MessageParser<AuthRequest> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int TokenFieldNumber = 1; // Metadata: 0x01FDC6C8
		private string token_; // 0x18
		public const int UidFieldNumber = 2; // Metadata: 0x01FDC6C9
		private string uid_; // 0x20
		public const int DidFieldNumber = 3; // Metadata: 0x01FDC6CA
		private string did_; // 0x28
		public const int AppIdFieldNumber = 4; // Metadata: 0x01FDC6CB
		private string appId_; // 0x30
		public const int OsFieldNumber = 5; // Metadata: 0x01FDC6CC
		private string os_; // 0x38
		public const int OsVersionFieldNumber = 6; // Metadata: 0x01FDC6CD
		private string osVersion_; // 0x40
		public const int AppVersionFieldNumber = 7; // Metadata: 0x01FDC6CE
		private string appVersion_; // 0x48
		public const int LogSdkVersionFieldNumber = 8; // Metadata: 0x01FDC6CF
		private string logSdkVersion_; // 0x50
		public const int DeviceModelFieldNumber = 9; // Metadata: 0x01FDC6D0
		private string deviceModel_; // 0x58
		public const int NetworkTypeFieldNumber = 10; // Metadata: 0x01FDC6D1
		private string networkType_; // 0x60
		public const int DeviceNameFieldNumber = 11; // Metadata: 0x01FDC6D2
		private string deviceName_; // 0x68
		public const int ServerNameFieldNumber = 12; // Metadata: 0x01FDC6D3
		private string serverName_; // 0x70
		public const int ServerChannelFieldNumber = 13; // Metadata: 0x01FDC6D4
		private string serverChannel_; // 0x78
		public const int GameLaunchTimeFieldNumber = 14; // Metadata: 0x01FDC6D5
		private long gameLaunchTime_; // 0x80
		public const int AccountAliasFieldNumber = 15; // Metadata: 0x01FDC6D6
		private string accountAlias_; // 0x88
		public const int DevVersionFieldNumber = 16; // Metadata: 0x01FDC6D7
		private string devVersion_; // 0x90
		public const int UploadPriorityFieldNumber = 18; // Metadata: 0x01FDC6D8
		private UploadPriority uploadPriority_; // 0x98
		public const int CharacterIdFieldNumber = 19; // Metadata: 0x01FDC6D9
		private string characterId_; // 0xA0
		public const int RoleIdFieldNumber = 20; // Metadata: 0x01FDC6DA
		private long roleId_; // 0xA8
		public const int ExtraFieldNumber = 17; // Metadata: 0x01FDC6DB
		private static readonly MapField<string, string> _map_extra_codec; // 0x08
		private readonly MapField<string, string> extra_; // 0xB0
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AuthRequest> Parser { get => default; } // 0x0000000185165B54-0x0000000185165BA4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000185165AF4-0x0000000185165B54 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000185165F6C-0x0000000185165FAC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Token { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000182944FA0-0x0000000182945010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Uid { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000182945010-0x0000000182945080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Did { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182945080-0x00000001829450F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AppId { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x00000001829450F0-0x0000000182945160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Os { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x0000000182945160-0x00000001829451D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OsVersion { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x00000001829451D0-0x0000000182945240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AppVersion { get => default; set {} } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182945240-0x00000001829452B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LogSdkVersion { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x00000001829452B0-0x0000000182945320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DeviceModel { get => default; set {} } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000182945320-0x0000000182945390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string NetworkType { get => default; set {} } // 0x0000000183D4EB00-0x0000000183D4EB10 0x0000000182945390-0x0000000182945400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DeviceName { get => default; set {} } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x0000000182945400-0x0000000182945470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ServerName { get => default; set {} } // 0x0000000183D4EB30-0x0000000183D4EB40 0x0000000182945470-0x00000001829454E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ServerChannel { get => default; set {} } // 0x0000000183D4EB20-0x0000000183D4EB30 0x00000001829454E0-0x0000000182945550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long GameLaunchTime { get => default; set {} } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x0000000183D4EB60-0x0000000183D4EB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AccountAlias { get => default; set {} } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000182945550-0x00000001829455C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DevVersion { get => default; set {} } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x00000001829455C0-0x0000000182945630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UploadPriority UploadPriority { get => default; set {} } // 0x0000000183D4EB50-0x0000000183D4EB60 0x0000000183D4EB80-0x0000000183D4EB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CharacterId { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000182945630-0x00000001829456A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RoleId { get => default; set {} } // 0x0000000183D4EB10-0x0000000183D4EB20 0x0000000183D4EB70-0x0000000183D4EB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, string> Extra { get => default; } // 0x0000000183D4EAD0-0x0000000183D4EAE0 
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AuthRequest() {} // 0x0000000182944DB0-0x0000000182944FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AuthRequest(AuthRequest other) {} // 0x000000018516590C-0x0000000185165AF4
		static AuthRequest() {} // 0x00000001832EBC10-0x00000001832EBDE0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AuthRequest Clone() => default; // 0x000000018516504C-0x00000001851650AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x00000001851652F4-0x0000000185165358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AuthRequest other) => default; // 0x00000001851650AC-0x00000001851652F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000185165358-0x00000001851655E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x00000001851658C0-0x000000018516590C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x00000001824D32B0-0x00000001824D32E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000183521C00-0x0000000183522030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x00000001835233E0-0x0000000183523960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AuthRequest other) {} // 0x00000001851655E8-0x00000001851658C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185165BA4-0x0000000185165F6C
	}

	public sealed class LogControl : IMessage<Beyond.Network.HGNetLogger.LogControl>, IBufferMessage // TypeDefIndex: 58806
	{
		// Fields
		private static readonly MessageParser<LogControl> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int GlobalEnabledFieldNumber = 1; // Metadata: 0x01FDC6DC
		private bool globalEnabled_; // 0x18
		public const int DefaultLogLevelMaskFieldNumber = 2; // Metadata: 0x01FDC6DD
		private int defaultLogLevelMask_; // 0x1C
		public const int ModuleControlFieldNumber = 3; // Metadata: 0x01FDC6DE
		private static readonly MapField<int, int> _map_moduleControl_codec; // 0x08
		private readonly MapField<int, int> moduleControl_; // 0x20
		public const int PolicyIdFieldNumber = 4; // Metadata: 0x01FDC6DF
		private string policyId_; // 0x28
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogControl> Parser { get => default; } // 0x0000000185167634-0x0000000185167684 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001851675D4-0x0000000185167634 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000185167794-0x00000001851677D4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GlobalEnabled { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DefaultLogLevelMask { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ModuleControl { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PolicyId { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x00000001836022D0-0x0000000183602340
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogControl() {} // 0x00000001835C4050-0x00000001835C40F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogControl(LogControl other) {} // 0x0000000185167530-0x00000001851675D4
		static LogControl() {} // 0x0000000183A25FA0-0x0000000183A26160
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogControl Clone() => default; // 0x0000000185167228-0x0000000185167288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000185167288-0x00000001851672EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogControl other) => default; // 0x00000001851672EC-0x000000018516738C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018516738C-0x0000000185167434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x00000001851674E4-0x0000000185167530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185167684-0x0000000185167794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000185167124-0x0000000185167228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogControl other) {} // 0x0000000185167434-0x00000001851674E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001836021E0-0x00000001836022D0
	}

	public sealed class AuthResponse : IMessage<Beyond.Network.HGNetLogger.AuthResponse>, IBufferMessage // TypeDefIndex: 58808
	{
		// Fields
		private static readonly MessageParser<AuthResponse> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int StatusFieldNumber = 1; // Metadata: 0x01FDC6E0
		private ResponseStatus status_; // 0x18
		public const int MessageFieldNumber = 2; // Metadata: 0x01FDC6E1
		private string message_; // 0x20
		public const int EncryptTypeFieldNumber = 3; // Metadata: 0x01FDC6E2
		private EncryptType encryptType_; // 0x28
		public const int KeyFieldNumber = 4; // Metadata: 0x01FDC6E3
		private string key_; // 0x30
		public const int CloudLogControlFieldNumber = 5; // Metadata: 0x01FDC6E4
		private LogControl cloudLogControl_; // 0x38
		public const int LocalLogControlFieldNumber = 6; // Metadata: 0x01FDC6E5
		private LogControl localLogControl_; // 0x40
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AuthResponse> Parser { get => default; } // 0x00000001851665F4-0x0000000185166644 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000185166594-0x00000001851665F4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018516675C-0x000000018516679C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResponseStatus Status { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Message { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x000000018516679C-0x0000000185166804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncryptType EncryptType { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Key { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x00000001835C40F0-0x00000001835C4160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogControl CloudLogControl { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogControl LocalLogControl { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AuthResponse() {} // 0x00000001839B9AF0-0x00000001839B9B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AuthResponse(AuthResponse other) {} // 0x00000001851664CC-0x0000000185166594
		static AuthResponse() {} // 0x0000000183B6B860-0x0000000183B6B970
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AuthResponse Clone() => default; // 0x00000001851660F4-0x0000000185166154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x00000001851661F4-0x0000000185166258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AuthResponse other) => default; // 0x0000000185166154-0x00000001851661F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000185166258-0x0000000185166314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000185166480-0x00000001851664CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185166644-0x000000018516675C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000185165FAC-0x00000001851660F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AuthResponse other) {} // 0x0000000185166314-0x0000000185166480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000182942420-0x0000000182942450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001835C3F00-0x00000001835C4050
	}

	public sealed class LogIntParam : IMessage<Beyond.Network.HGNetLogger.LogIntParam>, IBufferMessage // TypeDefIndex: 58810
	{
		// Fields
		private static readonly MessageParser<LogIntParam> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValFieldNumber = 1; // Metadata: 0x01FDC6E6
		private long val_; // 0x18
		public const int IndexFieldNumber = 2; // Metadata: 0x01FDC6E7
		private int index_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogIntParam> Parser { get => default; } // 0x0000000185168590-0x00000001851685E0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000185168530-0x0000000185168590 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001851686F0-0x0000000185168730 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Val { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000183D4EC10-0x0000000183D4EC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogIntParam() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogIntParam(LogIntParam other) {} // 0x0000000185167AFC-0x0000000185167B40
		static LogIntParam() {} // 0x0000000183B68010-0x0000000183B68120
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogIntParam Clone() => default; // 0x0000000185168354-0x00000001851683B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x00000001851683B4-0x0000000185168418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogIntParam other) => default; // 0x0000000185168418-0x000000018516844C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x000000018516844C-0x0000000185168498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x00000001851684E4-0x0000000185168530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185168678-0x00000001851686F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x00000001851682B8-0x0000000185168354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogIntParam other) {} // 0x0000000185168498-0x00000001851684E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001851685E0-0x0000000185168678
	}

	public sealed class LogFloatParam : IMessage<Beyond.Network.HGNetLogger.LogFloatParam>, IBufferMessage // TypeDefIndex: 58812
	{
		// Fields
		private static readonly MessageParser<LogFloatParam> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValFieldNumber = 1; // Metadata: 0x01FDC6E8
		private float val_; // 0x18
		public const int IndexFieldNumber = 2; // Metadata: 0x01FDC6E9
		private int index_; // 0x1C
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogFloatParam> Parser { get => default; } // 0x0000000185168110-0x0000000185168160 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001851680B0-0x0000000185168110 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000185168278-0x00000001851682B8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Val { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogFloatParam() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogFloatParam(LogFloatParam other) {} // 0x0000000185168070-0x00000001851680B0
		static LogFloatParam() {} // 0x0000000183B68120-0x0000000183B68230
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogFloatParam Clone() => default; // 0x0000000185167DD8-0x0000000185167E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000185167E38-0x0000000185167E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogFloatParam other) => default; // 0x0000000185167E9C-0x0000000185167F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000185167F34-0x0000000185167FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000185168024-0x0000000185168070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001851681F8-0x0000000185168278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000185167D48-0x0000000185167DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogFloatParam other) {} // 0x0000000185167FD0-0x0000000185168024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185168160-0x00000001851681F8
	}

	public sealed class LogDoubleParam : IMessage<Beyond.Network.HGNetLogger.LogDoubleParam>, IBufferMessage // TypeDefIndex: 58814
	{
		// Fields
		private static readonly MessageParser<LogDoubleParam> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValFieldNumber = 1; // Metadata: 0x01FDC6EA
		private double val_; // 0x18
		public const int IndexFieldNumber = 2; // Metadata: 0x01FDC6EB
		private int index_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogDoubleParam> Parser { get => default; } // 0x0000000185167BA0-0x0000000185167BF0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000185167B40-0x0000000185167BA0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000185167D08-0x0000000185167D48 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Val { get => default; set {} } // 0x0000000183D4EBD0-0x0000000183D4EBE0 0x0000000183D4EBE0-0x0000000183D4EBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogDoubleParam() {} // 0x000000018350B670-0x000000018350B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogDoubleParam(LogDoubleParam other) {} // 0x0000000185167AFC-0x0000000185167B40
		static LogDoubleParam() {} // 0x0000000183B68230-0x0000000183B68340
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogDoubleParam Clone() => default; // 0x0000000185167864-0x00000001851678C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x00000001851678C4-0x0000000185167928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogDoubleParam other) => default; // 0x0000000185167928-0x00000001851679BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x00000001851679BC-0x0000000185167A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000185167AB0-0x0000000185167AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185167C88-0x0000000185167D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x00000001851677D4-0x0000000185167864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogDoubleParam other) {} // 0x0000000185167A58-0x0000000185167AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185167BF0-0x0000000185167C88
	}

	public sealed class LogBoolParam : IMessage<Beyond.Network.HGNetLogger.LogBoolParam>, IBufferMessage // TypeDefIndex: 58816
	{
		// Fields
		private static readonly MessageParser<LogBoolParam> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValFieldNumber = 1; // Metadata: 0x01FDC6EC
		private string val_; // 0x18
		public const int IndexFieldNumber = 2; // Metadata: 0x01FDC6ED
		private int index_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogBoolParam> Parser { get => default; } // 0x0000000185166F08-0x0000000185166F58 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000185166EA8-0x0000000185166F08 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018516707C-0x00000001851670BC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Val { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001851670BC-0x0000000185167124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogBoolParam() {} // 0x0000000185166E68-0x0000000185166EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogBoolParam(LogBoolParam other) {} // 0x0000000185166E08-0x0000000185166E68
		static LogBoolParam() {} // 0x0000000183B68340-0x0000000183B68450
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogBoolParam Clone() => default; // 0x0000000185166BCC-0x0000000185166C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000185166C88-0x0000000185166CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogBoolParam other) => default; // 0x0000000185166C2C-0x0000000185166C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000185166CEC-0x0000000185166D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000185166DBC-0x0000000185166E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185166FF8-0x000000018516707C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000185166B24-0x0000000185166BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogBoolParam other) {} // 0x0000000185166D50-0x0000000185166DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185166F58-0x0000000185166FF8
	}

	public sealed class LogStringParam : IMessage<Beyond.Network.HGNetLogger.LogStringParam>, IBufferMessage // TypeDefIndex: 58818
	{
		// Fields
		private static readonly MessageParser<LogStringParam> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValFieldNumber = 1; // Metadata: 0x01FDC6EE
		private string val_; // 0x18
		public const int IndexFieldNumber = 2; // Metadata: 0x01FDC6EF
		private int index_; // 0x20
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogStringParam> Parser { get => default; } // 0x0000000185169FD8-0x000000018516A028 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000185169F78-0x0000000185169FD8 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018516A0C8-0x000000018516A108 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Val { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x000000018516A108-0x000000018516A170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogStringParam() {} // 0x0000000185169ED8-0x0000000185169F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogStringParam(LogStringParam other) {} // 0x0000000185169F18-0x0000000185169F78
		static LogStringParam() {} // 0x0000000183B67F00-0x0000000183B68010
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogStringParam Clone() => default; // 0x0000000185169D5C-0x0000000185169DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000185169DBC-0x0000000185169E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogStringParam other) => default; // 0x0000000185166C2C-0x0000000185166C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000185166CEC-0x0000000185166D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000185169E8C-0x0000000185169ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185166FF8-0x000000018516707C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000185169CB4-0x0000000185169D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogStringParam other) {} // 0x0000000185169E20-0x0000000185169E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x000000018516A028-0x000000018516A0C8
	}

	public sealed class LogMessage : IMessage<Beyond.Network.HGNetLogger.LogMessage>, IBufferMessage // TypeDefIndex: 58820
	{
		// Fields
		private static readonly MessageParser<LogMessage> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int LogTemplateFieldNumber = 1; // Metadata: 0x01FDC6F0
		private string logTemplate_; // 0x18
		public const int TemplateHashFieldNumber = 2; // Metadata: 0x01FDC6F1
		private uint templateHash_; // 0x20
		public const int LogLevelFieldNumber = 3; // Metadata: 0x01FDC6F2
		private LogLevel logLevel_; // 0x24
		public const int ChannelFieldNumber = 4; // Metadata: 0x01FDC6F3
		private int channel_; // 0x28
		public const int TimeFieldNumber = 5; // Metadata: 0x01FDC6F4
		private long time_; // 0x30
		public const int FrameCountFieldNumber = 12; // Metadata: 0x01FDC6F5
		private uint frameCount_; // 0x38
		public const int PlayerPosXFieldNumber = 13; // Metadata: 0x01FDC6F6
		private float playerPosX_; // 0x3C
		public const int PlayerPosYFieldNumber = 15; // Metadata: 0x01FDC6F7
		private float playerPosY_; // 0x40
		public const int PlayerPosZFieldNumber = 16; // Metadata: 0x01FDC6F8
		private float playerPosZ_; // 0x44
		public const int PlayerPingFieldNumber = 14; // Metadata: 0x01FDC6F9
		private int playerPing_; // 0x48
		public const int ParamsIntListFieldNumber = 6; // Metadata: 0x01FDC6FA
		private static readonly FieldCodec<LogIntParam> _repeated_paramsIntList_codec; // 0x08
		private readonly RepeatedField<LogIntParam> paramsIntList_; // 0x50
		public const int ParamsFloatListFieldNumber = 7; // Metadata: 0x01FDC6FB
		private static readonly FieldCodec<LogFloatParam> _repeated_paramsFloatList_codec; // 0x10
		private readonly RepeatedField<LogFloatParam> paramsFloatList_; // 0x58
		public const int ParamsDoubleListFieldNumber = 8; // Metadata: 0x01FDC6FC
		private static readonly FieldCodec<LogDoubleParam> _repeated_paramsDoubleList_codec; // 0x18
		private readonly RepeatedField<LogDoubleParam> paramsDoubleList_; // 0x60
		public const int ParamsBoolListFieldNumber = 9; // Metadata: 0x01FDC6FD
		private static readonly FieldCodec<LogBoolParam> _repeated_paramsBoolList_codec; // 0x20
		private readonly RepeatedField<LogBoolParam> paramsBoolList_; // 0x68
		public const int ParamsStringListFieldNumber = 10; // Metadata: 0x01FDC6FE
		private static readonly FieldCodec<LogStringParam> _repeated_paramsStringList_codec; // 0x28
		private readonly RepeatedField<LogStringParam> paramsStringList_; // 0x70
		public const int NativeLogLevelFieldNumber = 17; // Metadata: 0x01FDC6FF
		private NativeLogLevel nativeLogLevel_; // 0x78
		public const int ReturnLoginCountFieldNumber = 21; // Metadata: 0x01FDC700
		private int returnLoginCount_; // 0x7C
		public const int AppPauseCountFieldNumber = 22; // Metadata: 0x01FDC701
		private int appPauseCount_; // 0x80
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogMessage> Parser { get => default; } // 0x000000018516985C-0x00000001851698AC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001851697FC-0x000000018516985C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000185169C74-0x0000000185169CB4 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LogTemplate { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001823C45B0-0x00000001823C4620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TemplateHash { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogLevel LogLevel { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Channel { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Time { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000181003840-0x0000000181003850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FrameCount { get => default; set {} } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PlayerPosX { get => default; set {} } // 0x0000000183D4EC60-0x0000000183D4EC70 0x0000000183D4ECE0-0x0000000183D4ECF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PlayerPosY { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PlayerPosZ { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerPing { get => default; set {} } // 0x0000000183D4EC50-0x0000000183D4EC60 0x0000000183D4ECD0-0x0000000183D4ECE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LogIntParam> ParamsIntList { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LogFloatParam> ParamsFloatList { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LogDoubleParam> ParamsDoubleList { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LogBoolParam> ParamsBoolList { get => default; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LogStringParam> ParamsStringList { get => default; } // 0x0000000183D4EB30-0x0000000183D4EB40 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NativeLogLevel NativeLogLevel { get => default; set {} } // 0x0000000183D4EC40-0x0000000183D4EC50 0x0000000183D4ECC0-0x0000000183D4ECD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReturnLoginCount { get => default; set {} } // 0x0000000183D4EC90-0x0000000183D4ECA0 0x0000000183D4ED10-0x0000000183D4ED20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AppPauseCount { get => default; set {} } // 0x0000000183D4EC20-0x0000000183D4EC30 0x0000000183D4ECA0-0x0000000183D4ECB0
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogMessage() {} // 0x00000001830E87D0-0x00000001830E89A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogMessage(LogMessage other) {} // 0x0000000185169648-0x00000001851697FC
		static LogMessage() {} // 0x0000000183873200-0x00000001838736D0
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogMessage Clone() => default; // 0x0000000185168EB0-0x0000000185168F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x0000000185168F10-0x0000000185168F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogMessage other) => default; // 0x0000000185168F74-0x00000001851691E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x00000001851691E4-0x000000018516940C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x00000001851695FC-0x0000000185169648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x00000001824D3A70-0x00000001824D3AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001824D3ED0-0x00000001824D4230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x00000001824D57D0-0x00000001824D5B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogMessage other) {} // 0x000000018516940C-0x00000001851695FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x00000001851698AC-0x0000000185169C74
	}

	public sealed class LogMessageResponse : IMessage<Beyond.Network.HGNetLogger.LogMessageResponse>, IBufferMessage // TypeDefIndex: 58822
	{
		// Fields
		private static readonly MessageParser<LogMessageResponse> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int StatusFieldNumber = 1; // Metadata: 0x01FDC702
		private ResponseStatus status_; // 0x18
		public const int MessageFieldNumber = 2; // Metadata: 0x01FDC703
		private string message_; // 0x20
		public const int TemplateHashFieldNumber = 3; // Metadata: 0x01FDC704
		private uint templateHash_; // 0x28
	
		// Properties
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogMessageResponse> Parser { get => default; } // 0x0000000185168C5C-0x0000000185168CAC 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000185168BFC-0x0000000185168C5C 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000185168E08-0x0000000185168E48 
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResponseStatus Status { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Message { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000185168E48-0x0000000185168EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TemplateHash { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
	
		// Constructors
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogMessageResponse() {} // 0x0000000185168BBC-0x0000000185168BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogMessageResponse(LogMessageResponse other) {} // 0x0000000185168B58-0x0000000185168BBC
		static LogMessageResponse() {} // 0x0000000185168A54-0x0000000185168B58
	
		// Methods
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogMessageResponse Clone() => default; // 0x00000001851687FC-0x000000018516885C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other) => default; // 0x00000001851688C0-0x0000000185168924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogMessageResponse other) => default; // 0x000000018516885C-0x00000001851688C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode() => default; // 0x0000000185168924-0x0000000185168990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString() => default; // 0x0000000185168A08-0x0000000185168A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output) {} // 0x0000000183D47770-0x0000000183D477A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185168D64-0x0000000185168E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize() => default; // 0x0000000185168730-0x00000001851687FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogMessageResponse other) {} // 0x0000000185168990-0x0000000185168A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input) {} // 0x0000000183D47500-0x0000000183D47530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185168CAC-0x0000000185168D64
	}
}
