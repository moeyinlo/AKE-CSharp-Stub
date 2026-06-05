/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

// Image 74: Beyond.HGNetLogger.Proto.dll - Assembly: Beyond.HGNetLogger.Proto, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59817-59847

namespace Beyond.Network.HGNetLogger
{
	public static class MessageReflection // TypeDefIndex: 59818
	{
		// Fields
		private static FileDescriptor descriptor; // 0x00
	
		// Properties
		public static FileDescriptor Descriptor { get; } // 0x000000018735A9F8-0x000000018735AA48 
	
		// Constructors
		static MessageReflection() {} // 0x0000000187358E88-0x000000018735A9F8
	}

	public enum MessageType // TypeDefIndex: 59819
	{
		AuthRequest = 0,
		AuthResponse = 1,
		LogMessage = 2,
		LogMessageResponse = 3
	}

	public enum UploadPriority // TypeDefIndex: 59820
	{
		Low = 0,
		Normal = 1,
		High = 2,
		Critical = 3,
		Emergency = 4
	}

	public enum Version // TypeDefIndex: 59821
	{
		V0 = 0,
		V1 = 1,
		V2 = 2
	}

	public enum EncryptType // TypeDefIndex: 59822
	{
		None = 0
	}

	public enum LogLevel // TypeDefIndex: 59823
	{
		Debug = 0,
		Info = 1,
		Warn = 2,
		Error = 3,
		Fatal = 4,
		Important = 5
	}

	public enum NativeLogLevel // TypeDefIndex: 59824
	{
		None = 0,
		Debug = 1,
		Info = 2,
		Warn = 4,
		Error = 8,
		Fatal = 16,
		Important = 32
	}

	public enum ResponseStatus // TypeDefIndex: 59825
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

	public sealed class Header : IMessage<Beyond.Network.HGNetLogger.Header>, IBufferMessage // TypeDefIndex: 59827
	{
		// Fields
		private static readonly MessageParser<Header> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int VersionFieldNumber = 1; // Metadata: 0x02081FA9
		private Beyond.Network.HGNetLogger.Version version_; // 0x18
		public const int MessageTypeFieldNumber = 2; // Metadata: 0x02081FAA
		private MessageType messageType_; // 0x1C
		public const int SeqIdFieldNumber = 3; // Metadata: 0x02081FAB
		private uint seqId_; // 0x20
	
		// Properties
		public static MessageParser<Header> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187355704-0x000000018735574C 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018735551C-0x000000018735557C 
		public Beyond.Network.HGNetLogger.Version Version { get => default; set {} } // 0x00000001813AE9D0-0x00000001813AE9E0 0x00000001813B88B0-0x00000001813B88C0
		public MessageType MessageType { get => default; set {} } // 0x00000001813B9430-0x00000001813B9440 0x00000001873555B8-0x000000018735561C
		public uint SeqId { get => default; set {} } // 0x000000018735557C-0x00000001873555B8 0x000000018735561C-0x0000000187355664
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59826
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x00000001873557AC-0x00000001873557FC
			public __c() {} // 0x000000018735574C-0x00000001873557AC
	
			// Methods
			internal Header _.cctor_b__37_0() => default; // 0x00000001873557FC-0x000000018735583C
		}
	
		// Constructors
		public Header() {} // 0x00000001813AE560-0x00000001813AE570
		public Header(Header other) {} // 0x00000001813AE9C0-0x00000001813AE9D0
		static Header() {} // 0x000000018735AC3C-0x000000018735AC78
	
		// Methods
		public Header Clone() => default; // 0x00000001813AE570-0x00000001813AE580
		public override bool Equals(object other) => default; // 0x00000001873556B8-0x0000000187355704
		public bool Equals(Header other) => default; // 0x00000001846643B0-0x0000000184664440
		public override int GetHashCode() => default; // 0x0000000184664750-0x00000001846647E0
		public override string ToString() => default; // 0x0000000184340B80-0x0000000184340C70
		public void WriteTo(CodedOutputStream output) {} // 0x0000000187355664-0x00000001873556B8
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001843D0A20-0x00000001843D0A50
		public int CalculateSize() => default; // 0x00000001857C9060-0x00000001857C9100
		public void MergeFrom(Header other) {} // 0x0000000185DA56C0-0x0000000185DA57D0
		public void MergeFrom(CodedInputStream input) {} // 0x0000000185F718F0-0x0000000185F71950
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class AuthRequest : IMessage<Beyond.Network.HGNetLogger.AuthRequest>, IBufferMessage // TypeDefIndex: 59829
	{
		// Fields
		private static readonly MessageParser<AuthRequest> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int TokenFieldNumber = 1; // Metadata: 0x02081FAC
		private string token_; // 0x18
		public const int UidFieldNumber = 2; // Metadata: 0x02081FAD
		private string uid_; // 0x20
		public const int DidFieldNumber = 3; // Metadata: 0x02081FAE
		private string did_; // 0x28
		public const int AppIdFieldNumber = 4; // Metadata: 0x02081FAF
		private string appId_; // 0x30
		public const int OsFieldNumber = 5; // Metadata: 0x02081FB0
		private string os_; // 0x38
		public const int OsVersionFieldNumber = 6; // Metadata: 0x02081FB1
		private string osVersion_; // 0x40
		public const int AppVersionFieldNumber = 7; // Metadata: 0x02081FB2
		private string appVersion_; // 0x48
		public const int LogSdkVersionFieldNumber = 8; // Metadata: 0x02081FB3
		private string logSdkVersion_; // 0x50
		public const int DeviceModelFieldNumber = 9; // Metadata: 0x02081FB4
		private string deviceModel_; // 0x58
		public const int NetworkTypeFieldNumber = 10; // Metadata: 0x02081FB5
		private string networkType_; // 0x60
		public const int DeviceNameFieldNumber = 11; // Metadata: 0x02081FB6
		private string deviceName_; // 0x68
		public const int ServerNameFieldNumber = 12; // Metadata: 0x02081FB7
		private string serverName_; // 0x70
		public const int ServerChannelFieldNumber = 13; // Metadata: 0x02081FB8
		private string serverChannel_; // 0x78
		public const int GameLaunchTimeFieldNumber = 14; // Metadata: 0x02081FB9
		private long gameLaunchTime_; // 0x80
		public const int AccountAliasFieldNumber = 15; // Metadata: 0x02081FBA
		private string accountAlias_; // 0x88
		public const int DevVersionFieldNumber = 16; // Metadata: 0x02081FBB
		private string devVersion_; // 0x90
		public const int UploadPriorityFieldNumber = 18; // Metadata: 0x02081FBC
		private UploadPriority uploadPriority_; // 0x98
		public const int CharacterIdFieldNumber = 19; // Metadata: 0x02081FBD
		private string characterId_; // 0xA0
		public const int RoleIdFieldNumber = 20; // Metadata: 0x02081FBE
		private long roleId_; // 0xA8
		public const int ExtraFieldNumber = 17; // Metadata: 0x02081FBF
		private static readonly MapField<string, string> _map_extra_codec; // 0x08
		private readonly MapField<string, string> extra_; // 0xB0
	
		// Properties
		public static MessageParser<AuthRequest> Parser { get => default; } // 0x0000000184260C40-0x0000000184260E30 
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187354624-0x000000018735480C 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187353D64-0x0000000187353DC4 
		public string Token { get => default; set {} } // 0x0000000184260EA0-0x0000000184260F10 0x00000001813B8590-0x00000001813B85A0
		public string Uid { get => default; set {} } // 0x0000000184260F10-0x0000000184260F80 0x00000001813B51D0-0x00000001813B51E0
		public string Did { get => default; set {} } // 0x0000000184260F80-0x0000000184260FF0 0x00000001813ECBC0-0x00000001813ECBD0
		public string AppId { get => default; set {} } // 0x0000000184260FF0-0x0000000184261060 0x00000001813FF010-0x00000001813FF020
		public string Os { get => default; set {} } // 0x0000000184261060-0x00000001842610D0 0x00000001813ECF20-0x00000001813ECF30
		public string OsVersion { get => default; set {} } // 0x00000001842610D0-0x0000000184261140 0x0000000181460F60-0x0000000181460F70
		public string AppVersion { get => default; set {} } // 0x0000000184261140-0x00000001842611B0 0x00000001813F1630-0x00000001813F1640
		public string LogSdkVersion { get => default; set {} } // 0x00000001842611B0-0x0000000184261220 0x0000000185FB0530-0x0000000185FB0540
		public string DeviceModel { get => default; set {} } // 0x0000000184261220-0x0000000184261290 0x00000001813AC280-0x00000001813AC290
		public string NetworkType { get => default; set {} } // 0x0000000184261290-0x0000000184261300 0x0000000181460F70-0x0000000181460F80
		public string DeviceName { get => default; set {} } // 0x0000000184261300-0x0000000184261370 0x0000000183060C50-0x0000000183060C60
		public string ServerName { get => default; set {} } // 0x0000000184261370-0x00000001842613E0 0x000000018140CF50-0x000000018140CF60
		public string ServerChannel { get => default; set {} } // 0x0000000185FB0540-0x0000000185FB0550 0x0000000185FB0510-0x0000000185FB0520
		public long GameLaunchTime { get => default; set {} } // 0x00000001842613E0-0x0000000184261450 0x0000000181B5FFD0-0x0000000181B5FFE0
		public string AccountAlias { get => default; set {} } // 0x0000000184261450-0x00000001842614C0 0x00000001834A0D40-0x00000001834A0D50
		public string DevVersion { get => default; set {} } // 0x00000001834A2250-0x00000001834A2260 0x0000000185FB0520-0x0000000185FB0530
		public UploadPriority UploadPriority { get => default; set {} } // 0x00000001842614C0-0x0000000184261530 0x000000018349D730-0x000000018349D740
		public string CharacterId { get => default; set {} } // 0x0000000185FB0550-0x0000000185FB0560 0x000000018346D8F0-0x000000018346D900
		public long RoleId { get => default; set {} } // 0x000000018735400C-0x0000000187354070 0x0000000187353DC4-0x000000018735400C
		public MapField<string, string> Extra { get => default; } // 0x0000000187354070-0x0000000187354300 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59828
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018735486C-0x00000001873548BC
			public __c() {} // 0x000000018735480C-0x000000018735486C
	
			// Methods
			internal AuthRequest _.cctor_b__122_0() => default; // 0x0000000187354C84-0x0000000187354CC4
		}
	
		// Constructors
		public AuthRequest() {} // 0x0000000181377E40-0x0000000181377E50
		public AuthRequest(AuthRequest other) {} // 0x0000000184260E30-0x0000000184260EA0
		static AuthRequest() {} // 0x000000018735AA98-0x000000018735AAE8
	
		// Methods
		public AuthRequest Clone() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public override bool Equals(object other) => default; // 0x00000001873545D8-0x0000000187354624
		public bool Equals(AuthRequest other) => default; // 0x0000000184662770-0x00000001846627A0
		public override int GetHashCode() => default; // 0x0000000184663630-0x0000000184663A60
		public override string ToString() => default; // 0x0000000185569900-0x0000000185569E80
		public void WriteTo(CodedOutputStream output) {} // 0x0000000187354300-0x00000001873545D8
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x00000001873548BC-0x0000000187354C84
		public void MergeFrom(AuthRequest other) {} // 0x0000000185237290-0x0000000185237460
		public void MergeFrom(CodedInputStream input) {} // 0x0000000185F6E0B0-0x0000000185F6E110
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class LogControl : IMessage<Beyond.Network.HGNetLogger.LogControl>, IBufferMessage // TypeDefIndex: 59831
	{
		// Fields
		private static readonly MessageParser<LogControl> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int GlobalEnabledFieldNumber = 1; // Metadata: 0x02081FC0
		private bool globalEnabled_; // 0x18
		public const int DefaultLogLevelMaskFieldNumber = 2; // Metadata: 0x02081FC1
		private int defaultLogLevelMask_; // 0x1C
		public const int ModuleControlFieldNumber = 3; // Metadata: 0x02081FC2
		private static readonly MapField<int, int> _map_moduleControl_codec; // 0x08
		private readonly MapField<int, int> moduleControl_; // 0x20
		public const int PolicyIdFieldNumber = 4; // Metadata: 0x02081FC3
		private string policyId_; // 0x28
	
		// Properties
		public static MessageParser<LogControl> Parser { get => default; } // 0x0000000185662FB0-0x0000000185663050 
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187356248-0x00000001873562EC 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187355F40-0x0000000187355FA0 
		public bool GlobalEnabled { get => default; set {} } // 0x00000001813AE9D0-0x00000001813AE9E0 0x00000001813B31A0-0x00000001813B31B0
		public int DefaultLogLevelMask { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x00000001856A7260-0x00000001856A72D0
		public MapField<int, int> ModuleControl { get => default; } // 0x0000000187355FA0-0x0000000187356004 
		public string PolicyId { get => default; set {} } // 0x0000000187356004-0x00000001873560A4 0x00000001873560A4-0x000000018735614C
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59830
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018735634C-0x000000018735639C
			public __c() {} // 0x00000001873562EC-0x000000018735634C
	
			// Methods
			internal LogControl _.cctor_b__42_0() => default; // 0x00000001873564AC-0x00000001873564EC
		}
	
		// Constructors
		public LogControl() {} // 0x00000001813C0430-0x00000001813C0440
		public LogControl(LogControl other) {} // 0x00000001813C0520-0x00000001813C0530
		static LogControl() {} // 0x000000018735ACC8-0x000000018735AD18
	
		// Methods
		public LogControl Clone() => default; // 0x00000001813AE570-0x00000001813AE580
		public override bool Equals(object other) => default; // 0x00000001873561FC-0x0000000187356248
		public bool Equals(LogControl other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018735639C-0x00000001873564AC
		public override string ToString() => default; // 0x0000000187355E3C-0x0000000187355F40
		public void WriteTo(CodedOutputStream output) {} // 0x000000018735614C-0x00000001873561FC
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x00000001856A7170-0x00000001856A7260
		public void MergeFrom(LogControl other) {} // 0x0000000185C29E80-0x0000000185C2A040
		public void MergeFrom(CodedInputStream input) {} // 0x0000000185F75910-0x0000000185F75970
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class AuthResponse : IMessage<Beyond.Network.HGNetLogger.AuthResponse>, IBufferMessage // TypeDefIndex: 59833
	{
		// Fields
		private static readonly MessageParser<AuthResponse> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int StatusFieldNumber = 1; // Metadata: 0x02081FC4
		private ResponseStatus status_; // 0x18
		public const int MessageFieldNumber = 2; // Metadata: 0x02081FC5
		private string message_; // 0x20
		public const int EncryptTypeFieldNumber = 3; // Metadata: 0x02081FC6
		private EncryptType encryptType_; // 0x28
		public const int KeyFieldNumber = 4; // Metadata: 0x02081FC7
		private string key_; // 0x30
		public const int CloudLogControlFieldNumber = 5; // Metadata: 0x02081FC8
		private LogControl cloudLogControl_; // 0x38
		public const int LocalLogControlFieldNumber = 6; // Metadata: 0x02081FC9
		private LogControl localLogControl_; // 0x40
	
		// Properties
		public static MessageParser<AuthResponse> Parser { get => default; } // 0x0000000185B9DEB0-0x0000000185B9DF10 
		public static MessageDescriptor Descriptor { get => default; } // 0x00000001873551E4-0x00000001873552AC 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187354E0C-0x0000000187354E6C 
		public ResponseStatus Status { get => default; set {} } // 0x00000001873554B4-0x000000018735551C 0x0000000181C9AC80-0x0000000181C9AC90
		public string Message { get => default; set {} } // 0x0000000181C9A5C0-0x0000000181C9A5D0 0x00000001813B51D0-0x00000001813B51E0
		public EncryptType EncryptType { get => default; set {} } // 0x0000000185663050-0x00000001856630C0 0x00000001813ECBC0-0x00000001813ECBD0
		public string Key { get => default; set {} } // 0x0000000185A16440-0x0000000185A16450 0x00000001813FF010-0x00000001813FF020
		public LogControl CloudLogControl { get => default; set {} } // 0x0000000185F05C80-0x0000000185F05C90 0x0000000187354F0C-0x0000000187354F70
		public LogControl LocalLogControl { get => default; set {} } // 0x0000000187354E6C-0x0000000187354F0C 0x0000000187354F70-0x000000018735502C
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59832
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018735530C-0x000000018735535C
			public __c() {} // 0x00000001873552AC-0x000000018735530C
	
			// Methods
			internal AuthResponse _.cctor_b__52_0() => default; // 0x0000000187355474-0x00000001873554B4
		}
	
		// Constructors
		public AuthResponse() {} // 0x00000001813AE560-0x00000001813AE570
		public AuthResponse(AuthResponse other) {} // 0x00000001813AE9C0-0x00000001813AE9D0
		static AuthResponse() {} // 0x000000018735AD18-0x000000018735AD68
	
		// Methods
		public AuthResponse Clone() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public override bool Equals(object other) => default; // 0x0000000187355198-0x00000001873551E4
		public bool Equals(AuthResponse other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x000000018735535C-0x0000000187355474
		public override string ToString() => default; // 0x0000000187354CC4-0x0000000187354E0C
		public void WriteTo(CodedOutputStream output) {} // 0x000000018735502C-0x0000000187355198
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x00000001843D0A20-0x00000001843D0A50
		public int CalculateSize() => default; // 0x0000000185662E60-0x0000000185662FB0
		public void MergeFrom(AuthResponse other) {} // 0x0000000185DA8690-0x0000000185DA87A0
		public void MergeFrom(CodedInputStream input) {} // 0x0000000185F6CE50-0x0000000185F6CEB0
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class LogIntParam : IMessage<Beyond.Network.HGNetLogger.LogIntParam>, IBufferMessage // TypeDefIndex: 59835
	{
		// Fields
		private static readonly MessageParser<LogIntParam> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValFieldNumber = 1; // Metadata: 0x02081FCA
		private long val_; // 0x18
		public const int IndexFieldNumber = 2; // Metadata: 0x02081FCB
		private int index_; // 0x20
	
		// Properties
		public static MessageParser<LogIntParam> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187356814-0x0000000187356858 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018735706C-0x00000001873570CC 
		public long Val { get => default; set {} } // 0x00000001813B9430-0x00000001813B9440 0x00000001873570CC-0x0000000187357130
		public int Index { get => default; set {} } // 0x0000000187357130-0x0000000187357164 0x0000000187357164-0x00000001873571B0
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59834
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x00000001873572A8-0x00000001873572F8
			public __c() {} // 0x0000000187357248-0x00000001873572A8
	
			// Methods
			internal LogIntParam _.cctor_b__32_0() => default; // 0x0000000187357408-0x0000000187357448
		}
	
		// Constructors
		public LogIntParam() {} // 0x0000000181377E40-0x0000000181377E50
		public LogIntParam(LogIntParam other) {} // 0x0000000181448AC0-0x0000000181448AD0
		static LogIntParam() {} // 0x000000018735AB74-0x000000018735ABB0
	
		// Methods
		public LogIntParam Clone() => default; // 0x00000001813B88B0-0x00000001813B88C0
		public override bool Equals(object other) => default; // 0x00000001873571FC-0x0000000187357248
		public bool Equals(LogIntParam other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x0000000187357390-0x0000000187357408
		public override string ToString() => default; // 0x0000000187356FD0-0x000000018735706C
		public void WriteTo(CodedOutputStream output) {} // 0x00000001873571B0-0x00000001873571FC
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x00000001873572F8-0x0000000187357390
		public void MergeFrom(LogIntParam other) {} // 0x0000000185DA4D30-0x0000000185DA4E40
		public void MergeFrom(CodedInputStream input) {} // 0x0000000185F75370-0x0000000185F753D0
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class LogFloatParam : IMessage<Beyond.Network.HGNetLogger.LogFloatParam>, IBufferMessage // TypeDefIndex: 59837
	{
		// Fields
		private static readonly MessageParser<LogFloatParam> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValFieldNumber = 1; // Metadata: 0x02081FCC
		private float val_; // 0x18
		public const int IndexFieldNumber = 2; // Metadata: 0x02081FCD
		private int index_; // 0x1C
	
		// Properties
		public static MessageParser<LogFloatParam> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187356D88-0x0000000187356DC8 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187356AF0-0x0000000187356B50 
		public float Val { get => default; set {} } // 0x00000001813AE9D0-0x00000001813AE9E0 0x0000000187356B50-0x0000000187356BB4
		public int Index { get => default; set {} } // 0x0000000187356BB4-0x0000000187356C4C 0x0000000187356C4C-0x0000000187356CE8
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59836
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000187356E28-0x0000000187356E78
			public __c() {} // 0x0000000187356DC8-0x0000000187356E28
	
			// Methods
			internal LogFloatParam _.cctor_b__32_0() => default; // 0x0000000187356F90-0x0000000187356FD0
		}
	
		// Constructors
		public LogFloatParam() {} // 0x0000000181C9AC50-0x0000000181C9AC60
		public LogFloatParam(LogFloatParam other) {} // 0x0000000181C9A5A0-0x0000000181C9A5B0
		static LogFloatParam() {} // 0x000000018735AAE8-0x000000018735AB24
	
		// Methods
		public LogFloatParam Clone() => default; // 0x00000001813AE570-0x00000001813AE580
		public override bool Equals(object other) => default; // 0x0000000187356D3C-0x0000000187356D88
		public bool Equals(LogFloatParam other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x0000000187356F10-0x0000000187356F90
		public override string ToString() => default; // 0x0000000187356A60-0x0000000187356AF0
		public void WriteTo(CodedOutputStream output) {} // 0x0000000187356CE8-0x0000000187356D3C
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x0000000187356E78-0x0000000187356F10
		public void MergeFrom(LogFloatParam other) {} // 0x0000000185DA4E40-0x0000000185DA4F50
		public void MergeFrom(CodedInputStream input) {} // 0x0000000185F6BA70-0x0000000185F6BAD0
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class LogDoubleParam : IMessage<Beyond.Network.HGNetLogger.LogDoubleParam>, IBufferMessage // TypeDefIndex: 59839
	{
		// Fields
		private static readonly MessageParser<LogDoubleParam> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValFieldNumber = 1; // Metadata: 0x02081FCE
		private double val_; // 0x18
		public const int IndexFieldNumber = 2; // Metadata: 0x02081FCF
		private int index_; // 0x20
	
		// Properties
		public static MessageParser<LogDoubleParam> Parser { get => default; } // 0x0000000185492010-0x0000000185492020 
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187356814-0x0000000187356858 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x000000018735657C-0x00000001873565DC 
		public double Val { get => default; set {} } // 0x00000001813B9430-0x00000001813B9440 0x00000001873565DC-0x0000000187356640
		public int Index { get => default; set {} } // 0x0000000187356640-0x00000001873566D4 0x00000001873566D4-0x0000000187356770
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59838
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x00000001873568B8-0x0000000187356908
			public __c() {} // 0x0000000187356858-0x00000001873568B8
	
			// Methods
			internal LogDoubleParam _.cctor_b__32_0() => default; // 0x0000000187356A20-0x0000000187356A60
		}
	
		// Constructors
		public LogDoubleParam() {} // 0x0000000181C44EA0-0x0000000181C44EB0
		public LogDoubleParam(LogDoubleParam other) {} // 0x0000000181C44EB0-0x0000000181C44EC0
		static LogDoubleParam() {} // 0x000000018735AC00-0x000000018735AC3C
	
		// Methods
		public LogDoubleParam Clone() => default; // 0x00000001813B88B0-0x00000001813B88C0
		public override bool Equals(object other) => default; // 0x00000001873567C8-0x0000000187356814
		public bool Equals(LogDoubleParam other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x00000001873569A0-0x0000000187356A20
		public override string ToString() => default; // 0x00000001873564EC-0x000000018735657C
		public void WriteTo(CodedOutputStream output) {} // 0x0000000187356770-0x00000001873567C8
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x0000000187356908-0x00000001873569A0
		public void MergeFrom(LogDoubleParam other) {} // 0x0000000185DA4F50-0x0000000185DA5060
		public void MergeFrom(CodedInputStream input) {} // 0x0000000185F72970-0x0000000185F729D0
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class LogBoolParam : IMessage<Beyond.Network.HGNetLogger.LogBoolParam>, IBufferMessage // TypeDefIndex: 59841
	{
		// Fields
		private static readonly MessageParser<LogBoolParam> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValFieldNumber = 1; // Metadata: 0x02081FD0
		private string val_; // 0x18
		public const int IndexFieldNumber = 2; // Metadata: 0x02081FD1
		private int index_; // 0x20
	
		// Properties
		public static MessageParser<LogBoolParam> Parser { get => default; } // 0x0000000187355B80-0x0000000187355BC0 
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187355B20-0x0000000187355B80 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x00000001873558E4-0x0000000187355944 
		public string Val { get => default; set {} } // 0x00000001813B9430-0x00000001813B9440 0x00000001873559A0-0x0000000187355A04
		public int Index { get => default; set {} } // 0x0000000187355944-0x00000001873559A0 0x0000000187355A04-0x0000000187355A68
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59840
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000187355C20-0x0000000187355C70
			public __c() {} // 0x0000000187355BC0-0x0000000187355C20
	
			// Methods
			internal LogBoolParam _.cctor_b__32_0() => default; // 0x0000000187355D94-0x0000000187355DD4
		}
	
		// Constructors
		public LogBoolParam() {} // 0x0000000181377E40-0x0000000181377E50
		public LogBoolParam(LogBoolParam other) {} // 0x0000000187355DD4-0x0000000187355E3C
		static LogBoolParam() {} // 0x000000018735AB24-0x000000018735AB74
	
		// Methods
		public LogBoolParam Clone() => default; // 0x00000001813B88B0-0x00000001813B88C0
		public override bool Equals(object other) => default; // 0x0000000187355AD4-0x0000000187355B20
		public bool Equals(LogBoolParam other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x0000000187355D10-0x0000000187355D94
		public override string ToString() => default; // 0x000000018735583C-0x00000001873558E4
		public void WriteTo(CodedOutputStream output) {} // 0x0000000187355A68-0x0000000187355AD4
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x0000000187355C70-0x0000000187355D10
		public void MergeFrom(LogBoolParam other) {} // 0x0000000185DA5060-0x0000000185DA5170
		public void MergeFrom(CodedInputStream input) {} // 0x0000000185F6BB30-0x0000000185F6BB90
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class LogStringParam : IMessage<Beyond.Network.HGNetLogger.LogStringParam>, IBufferMessage // TypeDefIndex: 59843
	{
		// Fields
		private static readonly MessageParser<LogStringParam> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int ValFieldNumber = 1; // Metadata: 0x02081FD2
		private string val_; // 0x18
		public const int IndexFieldNumber = 2; // Metadata: 0x02081FD3
		private int index_; // 0x20
	
		// Properties
		public static MessageParser<LogStringParam> Parser { get => default; } // 0x0000000187358BF0-0x0000000187358C30 
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187358C30-0x0000000187358C90 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187358A74-0x0000000187358AD4 
		public string Val { get => default; set {} } // 0x00000001813B9430-0x00000001813B9440 0x0000000187358AD4-0x0000000187358B38
		public int Index { get => default; set {} } // 0x0000000187355944-0x00000001873559A0 0x0000000187355A04-0x0000000187355A68
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59842
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000187358CF0-0x0000000187358D40
			public __c() {} // 0x0000000187358C90-0x0000000187358CF0
	
			// Methods
			internal LogStringParam _.cctor_b__32_0() => default; // 0x0000000187358DE0-0x0000000187358E20
		}
	
		// Constructors
		public LogStringParam() {} // 0x0000000181377E40-0x0000000181377E50
		public LogStringParam(LogStringParam other) {} // 0x0000000187358E20-0x0000000187358E88
		static LogStringParam() {} // 0x000000018735ABB0-0x000000018735AC00
	
		// Methods
		public LogStringParam Clone() => default; // 0x00000001813B88B0-0x00000001813B88C0
		public override bool Equals(object other) => default; // 0x0000000187358BA4-0x0000000187358BF0
		public bool Equals(LogStringParam other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x0000000187355D10-0x0000000187355D94
		public override string ToString() => default; // 0x00000001873589CC-0x0000000187358A74
		public void WriteTo(CodedOutputStream output) {} // 0x0000000187358B38-0x0000000187358BA4
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x0000000187358D40-0x0000000187358DE0
		public void MergeFrom(LogStringParam other) {} // 0x0000000185DA4C20-0x0000000185DA4D30
		public void MergeFrom(CodedInputStream input) {} // 0x0000000185F6F130-0x0000000185F6F190
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class LogMessage : IMessage<Beyond.Network.HGNetLogger.LogMessage>, IBufferMessage // TypeDefIndex: 59845
	{
		// Fields
		private static readonly MessageParser<LogMessage> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int LogTemplateFieldNumber = 1; // Metadata: 0x02081FD4
		private string logTemplate_; // 0x18
		public const int TemplateHashFieldNumber = 2; // Metadata: 0x02081FD5
		private uint templateHash_; // 0x20
		public const int LogLevelFieldNumber = 3; // Metadata: 0x02081FD6
		private LogLevel logLevel_; // 0x24
		public const int ChannelFieldNumber = 4; // Metadata: 0x02081FD7
		private int channel_; // 0x28
		public const int TimeFieldNumber = 5; // Metadata: 0x02081FD8
		private long time_; // 0x30
		public const int FrameCountFieldNumber = 12; // Metadata: 0x02081FD9
		private uint frameCount_; // 0x38
		public const int PlayerPosXFieldNumber = 13; // Metadata: 0x02081FDA
		private float playerPosX_; // 0x3C
		public const int PlayerPosYFieldNumber = 15; // Metadata: 0x02081FDB
		private float playerPosY_; // 0x40
		public const int PlayerPosZFieldNumber = 16; // Metadata: 0x02081FDC
		private float playerPosZ_; // 0x44
		public const int PlayerPingFieldNumber = 14; // Metadata: 0x02081FDD
		private int playerPing_; // 0x48
		public const int ParamsIntListFieldNumber = 6; // Metadata: 0x02081FDE
		private static readonly FieldCodec<LogIntParam> _repeated_paramsIntList_codec; // 0x08
		private readonly RepeatedField<LogIntParam> paramsIntList_; // 0x50
		public const int ParamsFloatListFieldNumber = 7; // Metadata: 0x02081FDF
		private static readonly FieldCodec<LogFloatParam> _repeated_paramsFloatList_codec; // 0x10
		private readonly RepeatedField<LogFloatParam> paramsFloatList_; // 0x58
		public const int ParamsDoubleListFieldNumber = 8; // Metadata: 0x02081FE0
		private static readonly FieldCodec<LogDoubleParam> _repeated_paramsDoubleList_codec; // 0x18
		private readonly RepeatedField<LogDoubleParam> paramsDoubleList_; // 0x60
		public const int ParamsBoolListFieldNumber = 9; // Metadata: 0x02081FE1
		private static readonly FieldCodec<LogBoolParam> _repeated_paramsBoolList_codec; // 0x20
		private readonly RepeatedField<LogBoolParam> paramsBoolList_; // 0x68
		public const int ParamsStringListFieldNumber = 10; // Metadata: 0x02081FE2
		private static readonly FieldCodec<LogStringParam> _repeated_paramsStringList_codec; // 0x28
		private readonly RepeatedField<LogStringParam> paramsStringList_; // 0x70
		public const int NativeLogLevelFieldNumber = 17; // Metadata: 0x02081FE3
		private NativeLogLevel nativeLogLevel_; // 0x78
		public const int ReturnLoginCountFieldNumber = 21; // Metadata: 0x02081FE4
		private int returnLoginCount_; // 0x7C
		public const int AppPauseCountFieldNumber = 22; // Metadata: 0x02081FE5
		private int appPauseCount_; // 0x80
	
		// Properties
		public static MessageParser<LogMessage> Parser { get => default; } // 0x0000000184FEA7F0-0x0000000184FEA9C0 
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187358360-0x0000000187358514 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187357BC8-0x0000000187357C28 
		public string LogTemplate { get => default; set {} } // 0x00000001813B9430-0x00000001813B9440 0x0000000181424480-0x0000000181424490
		public uint TemplateHash { get => default; set {} } // 0x0000000181424940-0x0000000181424950 0x0000000181C9AC80-0x0000000181C9AC90
		public LogLevel LogLevel { get => default; set {} } // 0x0000000181C9A5C0-0x0000000181C9A5D0 0x00000001813B51D0-0x00000001813B51E0
		public int Channel { get => default; set {} } // 0x00000001813B51E0-0x00000001813B51F0 0x00000001813E5E30-0x00000001813E5E40
		public long Time { get => default; set {} } // 0x00000001813E6F50-0x00000001813E6F60 0x0000000185FB0580-0x0000000185FB0590
		public uint FrameCount { get => default; set {} } // 0x0000000185FB05E0-0x0000000185FB05F0 0x0000000185FB0590-0x0000000185FB05A0
		public float PlayerPosX { get => default; set {} } // 0x0000000185FB05F0-0x0000000185FB0600 0x0000000185FB05A0-0x0000000185FB05B0
		public float PlayerPosY { get => default; set {} } // 0x0000000185FB0600-0x0000000185FB0610 0x0000000185FB0570-0x0000000185FB0580
		public float PlayerPosZ { get => default; set {} } // 0x0000000185FB05D0-0x0000000185FB05E0 0x0000000181460F60-0x0000000181460F70
		public int PlayerPing { get => default; set {} } // 0x00000001813F1630-0x00000001813F1640 0x0000000185FB0530-0x0000000185FB0540
		public RepeatedField<LogIntParam> ParamsIntList { get => default; } // 0x00000001813AC280-0x00000001813AC290 
		public RepeatedField<LogFloatParam> ParamsFloatList { get => default; } // 0x0000000181460F70-0x0000000181460F80 
		public RepeatedField<LogDoubleParam> ParamsDoubleList { get => default; } // 0x0000000185FB0560-0x0000000185FB0570 
		public RepeatedField<LogBoolParam> ParamsBoolList { get => default; } // 0x0000000185FB05C0-0x0000000185FB05D0 
		public RepeatedField<LogStringParam> ParamsStringList { get => default; } // 0x0000000185FB05B0-0x0000000185FB05C0 
		public NativeLogLevel NativeLogLevel { get => default; set {} } // 0x0000000185FB0610-0x0000000185FB0620 0x000000018140C930-0x000000018140C940
		public int ReturnLoginCount { get => default; set {} } // 0x000000018140C940-0x000000018140C950 0x0000000187357C28-0x0000000187357C8C
		public int AppPauseCount { get => default; set {} } // 0x0000000187357C8C-0x0000000187357EFC 0x0000000187357EFC-0x0000000187358124
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59844
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000187358574-0x00000001873585C4
			public __c() {} // 0x0000000187358514-0x0000000187358574
	
			// Methods
			internal LogMessage _.cctor_b__112_0() => default; // 0x000000018735898C-0x00000001873589CC
		}
	
		// Constructors
		public LogMessage() {} // 0x0000000181377E40-0x0000000181377E50
		public LogMessage(LogMessage other) {} // 0x0000000185284CE0-0x0000000185284D50
		static LogMessage() {} // 0x000000018735AA48-0x000000018735AA98
	
		// Methods
		public LogMessage Clone() => default; // 0x00000001813B88B0-0x00000001813B88C0
		public override bool Equals(object other) => default; // 0x0000000187358314-0x0000000187358360
		public bool Equals(LogMessage other) => default; // 0x0000000184664380-0x00000001846643B0
		public override int GetHashCode() => default; // 0x00000001846647E0-0x0000000184664B40
		public override string ToString() => default; // 0x00000001843407D0-0x0000000184340B80
		public void WriteTo(CodedOutputStream output) {} // 0x0000000187358124-0x0000000187358314
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x00000001873585C4-0x000000018735898C
		public void MergeFrom(LogMessage other) {} // 0x00000001859F07D0-0x00000001859F0CA0
		public void MergeFrom(CodedInputStream input) {} // 0x0000000185F70330-0x0000000185F70390
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class LogMessageResponse : IMessage<Beyond.Network.HGNetLogger.LogMessageResponse>, IBufferMessage // TypeDefIndex: 59847
	{
		// Fields
		private static readonly MessageParser<LogMessageResponse> _parser; // 0x00
		private UnknownFieldSet _unknownFields; // 0x10
		public const int StatusFieldNumber = 1; // Metadata: 0x02081FE6
		private ResponseStatus status_; // 0x18
		public const int MessageFieldNumber = 2; // Metadata: 0x02081FE7
		private string message_; // 0x20
		public const int TemplateHashFieldNumber = 3; // Metadata: 0x02081FE8
		private uint templateHash_; // 0x28
	
		// Properties
		public static MessageParser<LogMessageResponse> Parser { get => default; } // 0x00000001873578D4-0x0000000187357914 
		public static MessageDescriptor Descriptor { get => default; } // 0x0000000187357870-0x00000001873578D4 
		MessageDescriptor IMessage.Descriptor { get => default; } // 0x0000000187357514-0x0000000187357574 
		public ResponseStatus Status { get => default; set {} } // 0x0000000187357B60-0x0000000187357BC8 0x0000000181C9AC80-0x0000000181C9AC90
		public string Message { get => default; set {} } // 0x0000000181C9A5C0-0x0000000181C9A5D0 0x00000001873575D8-0x000000018735763C
		public uint TemplateHash { get => default; set {} } // 0x0000000187357574-0x00000001873575D8 0x000000018735763C-0x00000001873576A8
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59846
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000187357974-0x00000001873579C4
			public __c() {} // 0x0000000187357914-0x0000000187357974
	
			// Methods
			internal LogMessageResponse _.cctor_b__37_0() => default; // 0x0000000187357B20-0x0000000187357B60
		}
	
		// Constructors
		public LogMessageResponse() {} // 0x00000001813AE560-0x00000001813AE570
		public LogMessageResponse(LogMessageResponse other) {} // 0x00000001813AE9C0-0x00000001813AE9D0
		static LogMessageResponse() {} // 0x000000018735AC78-0x000000018735ACC8
	
		// Methods
		public LogMessageResponse Clone() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public override bool Equals(object other) => default; // 0x0000000187357720-0x000000018735776C
		public bool Equals(LogMessageResponse other) => default; // 0x0000000185FA7B70-0x0000000185FA7BA0
		public override int GetHashCode() => default; // 0x0000000187357A7C-0x0000000187357B20
		public override string ToString() => default; // 0x0000000187357448-0x0000000187357514
		public void WriteTo(CodedOutputStream output) {} // 0x00000001873576A8-0x0000000187357720
		void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) {} // 0x0000000185FA7960-0x0000000185FA7990
		public int CalculateSize() => default; // 0x00000001873579C4-0x0000000187357A7C
		public void MergeFrom(LogMessageResponse other) {} // 0x000000018735776C-0x0000000187357870
		public void MergeFrom(CodedInputStream input) {} // 0x000000018735AD68-0x000000018735ADCC
		void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) {} // 0x0000000185492010-0x0000000185492020
	}
}
