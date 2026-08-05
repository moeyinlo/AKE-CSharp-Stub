/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using AceSdk;

// Image 122: ACESDK_WIN.dll - Assembly: ACESDK_WIN, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63627-63656
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 63656
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_33 _069D1FC04DF5D3A97841869D60961B287D2BF035BAE96ED2B8B31CDC3A9084AF; // 0x00 // Static value (base64): 9vbrxN7D6cLPy97v0trP2N729uvp74foy9nPnJ6EzsbG - Metadata: 0x023529B4
	internal static readonly __StaticArrayInitTypeSize_14 A79B64018AA2094EC519F1C00795ED3CD8C3F6B942D7CA802FF2B45B51A55B9C; // 0x21 // Static value (base64): 48TD3uvJz+nGw8/E3p8= - Metadata: 0x023529DC
	internal static readonly __StaticArrayInitTypeSize_38 EF03B53ABC241FB166156A9BAB8EB62CCE1FD43274D0BAF46A38C9FED67CCB00; // 0x2F // Static value (base64): 9vbrxN7D6cLPy97v0trP2N729tKSnPb26+nvh+jL2c+ZmITOxsY= - Metadata: 0x023529EC

	// Nested types
	private struct __StaticArrayInitTypeSize_14 // TypeDefIndex: 63653
	{
	}

	private struct __StaticArrayInitTypeSize_33 // TypeDefIndex: 63654
	{
	}

	private struct __StaticArrayInitTypeSize_38 // TypeDefIndex: 63655
	{
	}
}

namespace AceSdk
{
	public enum AceSdkAccountType : uint // TypeDefIndex: 63629
	{
		ACE_SDK_ACCOUNT_TYPE_QQ = 1,
		ACE_SDK_ACCOUNT_TYPE_WECHAT = 2,
		ACE_SDK_ACCOUNT_TYPE_BAIDU = 3,
		ACE_SDK_ACCOUNT_TYPE_QQ_OPENID = 4,
		ACE_SDK_ACCOUNT_TYPE_VISITOR = 7,
		ACE_SDK_ACCOUNT_TYPE_GOPENID = 8,
		ACE_SDK_ACCOUNT_TYPE_GOOGLE = 101,
		ACE_SDK_ACCOUNT_TYPE_WEGAME_MAIL = 102,
		ACE_SDK_ACCOUNT_TYPE_4399 = 201,
		ACE_SDK_ACCOUNT_TYPE_GARENA = 202,
		ACE_SDK_ACCOUNT_TYPE_GIANT_NETWORK = 203,
		ACE_SDK_ACCOUNT_TYPE_WEGAME = 301,
		ACE_SDK_ACCOUNT_TYPE_STEAM = 302,
		ACE_SDK_ACCOUNT_TYPE_WEGAME_COMMON_ID = 308,
		ACE_SDK_ACCOUNT_TYPE_WOODUAN = 312,
		ACE_SDK_ACCOUNT_TYPE_VK = 314,
		ACE_SDK_ACCOUNT_TYPE_COMMON_ID = 601,
		ACE_SDK_ACCOUNT_TYPE_FACEBOOK = 1001,
		ACE_SDK_ACCOUNT_TYPE_SUPERCELL = 1002,
		ACE_SDK_ACCOUNT_TYPE_TCOMMIC = 1005,
		ACE_SDK_ACCOUNT_TYPE_UPLAY = 1006,
		ACE_SDK_ACCOUNT_TYPE_PHONE_OPENID = 1014,
		ACE_SDK_ACCOUNT_TYPE_LINE = 1019,
		ACE_SDK_ACCOUNT_TYPE_APPLE = 1020
	}

	public enum AceSdkAccountPlatID : uint // TypeDefIndex: 63630
	{
		ACE_SDK_PLAT_ID_IOS = 0,
		ACE_SDK_PLAT_ID_ANDROID = 1,
		ACE_SDK_PLAT_ID_PC_CLIENT = 3,
		ACE_SDK_PLAT_ID_LINUX = 4,
		ACE_SDK_PLAT_ID_SWITCH = 6,
		ACE_SDK_PLAT_ID_MAC = 7,
		ACE_SDK_PLAT_ID_PS_CLIENT = 8,
		ACE_SDK_PLAT_ID_XBOX_CLIENT = 9,
		ACE_SDK_PLAT_ID_PC_EMULATOR_CLIENT = 11,
		ACE_SDK_PLAT_ID_HARMONY_MOBILE = 12,
		ACE_SDK_PLAT_ID_HARMONY_PC = 13,
		ACE_SDK_PLAT_ID_UNKNOWN = 99
	}

	public class AceSdkAccount // TypeDefIndex: 63631
	{
		// Fields
		public const int ACE_SDK_MAX_ACCOUNT_LEN = 65; // Metadata: 0x02352911
		public StringBuilder account_; // 0x10
		public AceSdkAccountType account_type_; // 0x18
		public AceSdkAccountPlatID plat_id_; // 0x1C
		public uint game_id_; // 0x20
		public uint world_id_; // 0x24
	
		// Constructors
		public AceSdkAccount(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class AceSdkClient // TypeDefIndex: 63644
	{
		// Fields
		private AceSdkClientObject client_obj_; // 0x10
		[ThreadStatic]
		private byte[] get_packet_buffer_; // 0x58
		[ThreadStatic]
		private byte[] get_light_feature_packet_buffer_; // 0x60
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult InitAceClient5Routine(uint ver, IntPtr opt, out IntPtr client_obj_ptr); // TypeDefIndex: 63632; 0x00000001814F3120-0x00000001814F3140
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult LogInRoutine(IntPtr handle, string account, uint account_type, uint world_id, string login_ticket); // TypeDefIndex: 63633; 0x00000001814D3FD0-0x00000001814D3FF0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult LogOutRoutine(IntPtr handle); // TypeDefIndex: 63634; 0x00000001814E2060-0x00000001814E2070
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult DeinitRoutine(IntPtr handle); // TypeDefIndex: 63635; 0x00000001814E2060-0x00000001814E2070
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult GetPacketRoutine(IntPtr handle, ref AceSdkClientPacket packet); // TypeDefIndex: 63636; 0x00000001815802E0-0x00000001815802F0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult OnPacketReceivedRoutine(IntPtr handle, byte[] data, uint len); // TypeDefIndex: 63637; 0x00000001814F3120-0x00000001814F3140
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult GetLightFeaturePacketRoutine(IntPtr handle, ref AceSdkClientLightFeaturePacket packet); // TypeDefIndex: 63638; 0x00000001815802E0-0x00000001815802F0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult OnLightFeaturePacketReceivedRoutine(IntPtr handle, ref AceSdkClientLightFeature data); // TypeDefIndex: 63639; 0x00000001815802E0-0x00000001815802F0
	
		private struct AceSdkClientObject // TypeDefIndex: 63640
		{
			// Fields
			public IntPtr handle_; // 0x00
			public IntPtr _deprecated1; // 0x08
			public LogOutRoutine log_out_; // 0x10
			public DeinitRoutine deinit_; // 0x18
			public GetPacketRoutine get_packet_; // 0x20
			public OnPacketReceivedRoutine on_packet_received_; // 0x28
			public LogInRoutine log_in_; // 0x30
			public GetLightFeaturePacketRoutine get_light_feature_packet_; // 0x38
			public OnLightFeaturePacketReceivedRoutine on_light_feature_packet_received_; // 0x40
		}
	
		private struct AceSdkClientPacket // TypeDefIndex: 63641
		{
			// Fields
			public byte[] buffer_; // 0x00
			public uint len_; // 0x08
		}
	
		private struct AceSdkClientLightFeaturePacket // TypeDefIndex: 63642
		{
			// Fields
			public byte[] buffer_; // 0x00
			public uint len_; // 0x08
		}
	
		private struct AceSdkClientLightFeature // TypeDefIndex: 63643
		{
			// Fields
			public string name_; // 0x00
			public IntPtr data_; // 0x08
			public uint data_len_; // 0x10
			public uint crc_; // 0x14
		}
	
		// Constructors
		private AceSdkClient(IntPtr client_obj_ptr); // 0x000000018539A2D0-0x000000018539A3C8
	
		// Methods
		public static AceSdkResult ace_sdk_client_init(out AceSdkClient ace_client); // 0x000000018539A5CC-0x000000018539A844
		public AceSdkResult ace_sdk_client_deinit(); // 0x000000018539A3C8-0x000000018539A3F4
		public AceSdkResult ace_sdk_client_log_in(string account_id, AceSdkAccountType account_type, uint world_id, string login_ticket); // 0x000000018539A844-0x000000018539A88C
		public AceSdkResult ace_sdk_client_log_out(); // 0x000000018539A88C-0x000000018539A8B8
		public AceSdkResult ace_sdk_client_get_packet(out byte[] packet); // 0x000000018539A4E0-0x000000018539A5CC
		public AceSdkResult ace_sdk_client_on_packet_received(byte[] packet); // 0x000000018539A9A4-0x000000018539A9E0
		public AceSdkResult ace_sdk_client_get_light_feature_packet(out byte[] packet); // 0x000000018539A3F4-0x000000018539A4E0
		public AceSdkResult ace_sdk_client_on_light_feature_packet_received(byte[] lf_data, string name, uint crc); // 0x000000018539A8B8-0x000000018539A9A4
		private static int get_exe_module_path(StringBuilder path, int len); // 0x000000018539A9E0-0x000000018539AA60
		private static string DecryptString(byte[] encrypted, byte key); // 0x0000000185399FD4-0x000000018539A068
		private static extern IntPtr LoadLibrary(string lpLibFileName); // 0x000000018539A258-0x000000018539A2D0
		private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName); // 0x000000018539A1AC-0x000000018539A258
		private static extern IntPtr GetProcAddressByOrdinal(IntPtr hModule, int nOrdinal); // 0x000000018539A130-0x000000018539A1AC
		private static extern uint GetModuleFileName(IntPtr hModule, StringBuilder lpFilename, int nSize); // 0x000000018539A068-0x000000018539A130
	}

	public enum AceSdkResult // TypeDefIndex: 63645
	{
		ACE_SDK_RESULT_OK = 0,
		ACE_SDK_RESULT_NOT_SUPPORTED = 1,
		ACE_SDK_RESULT_INVALID_PARAMETER = 2,
		ACE_SDK_RESULT_CALC_PATH_FAILED = 3,
		ACE_SDK_RESULT_LOAD_LIBRARY_FAILED = 4,
		ACE_SDK_RESULT_UNLOAD_LIBRARY_FAILED = 5,
		ACE_SDK_RESULT_SYMBOL_NOT_FOUND = 6,
		ACE_SDK_RESULT_INIT_NOT_CALLED_OR_FAILED = 7,
		ACE_SDK_RESULT_INTERNAL_ERROR = 8,
		ACE_SDK_RESULT_ACCOUNT_TOO_LONG = 9,
		ACE_SDK_RESULT_ACCOUNT_ILLEGAL_CHARACTER = 10,
		ACE_SDK_RESULT_NO_PACKET_NEED_SENDING = 100,
		ACE_SDK_RESULT_ILLEGAL_LOG_IN = 101,
		ACE_SDK_RESULT_COMMON_END = 1000,
		ACE_SDK_RESULT_DEVELOP_LANGUAGE_BEGIN = 10000,
		ACE_SDK_RESULT_PACK_STRUCT_1BYTE_ERROR = 10001,
		ACE_SDK_RESULT_UNPACK_STRUCT_1BYTE_ERROR = 10002,
		ACE_SDK_RESULT_PACK_STRUCT_1BYTE_LEN_ERROR = 10003,
		ACE_SDK_RESLUT_JAVA_JNI_BEGIN = 20001,
		ACE_SDK_RESLUT_JAVA_JNI_ENV_NULL = 20002,
		ACE_SDK_RESLUT_JAVA_JNI_JVM_NULL = 20003,
		ACE_SDK_RESLUT_JAVA_JNI_JOBJECT_NULL = 20004,
		ACE_SDK_RESLUT_JAVA_JNI_CLASS_NULL = 20005,
		ACE_SDK_RESLUT_JAVA_JNI_REFLECT_BS_DATA_FAILED = 20006,
		ACE_SDK_RESLUT_JAVA_JNI_REFLECT_BS_OFFSET_FAILED = 20007,
		ACE_SDK_RESLUT_JAVA_JNI_REFLECT_BS_CAPACITY_FAILED = 20008,
		ACE_SDK_RESLUT_JAVA_JNI_REFLECT_BS_LENGTH_ERROR = 20009,
		ACE_SDK_RESLUT_JAVA_ARRAY_LENTGH_ERROR = 20010,
		ACE_SDK_RESLUT_JAVA_JNI_END = 20100,
		ACE_SDK_RESULT_DEVELOP_LANGUAGE_END = 99999,
		ACE_SDK_RESULT_BUSI_INTERFACE_BEGIN = 100000,
		ACE_SDK_RESLUT_LIGHT_FEATURE_BEGIN = 100001,
		ACE_SDK_RESLUT_LIGHT_FEATURE_NOT_OPENED = 100002,
		ACE_SDK_RESLUT_LIGHT_FEATURE_END = 100100,
		ACE_SDK_RESLUT_UIC_BEGIN = 100101,
		ACE_SDK_RESULT_UIC_TEXT_INTERF_CALL_FAILED = 100102,
		ACE_SDK_RESULT_UIC_TEXT_CALLBACK_HAS_NOT_SET = 100103,
		ACE_SDK_RESULT_UIC_PIC_INTERF_CALL_FAILED = 100104,
		ACE_SDK_RESULT_UIC_PIC_CALLBACK_HAS_NOT_SET = 100105,
		ACE_SDK_RESLUT_UIC_END = 100200,
		ACE_SDK_RESULT_SAFEMODE_BEGIN = 100201,
		ACE_SDK_RESULT_SAFEMODE_CALLBACK_HAS_NOT_SET = 100202,
		ACE_SDK_RESULT_SAFEMODE_INTERF_CALL_FAILED = 100203,
		ACE_SDK_RESULT_SAFEMODE_END = 100300,
		ACE_SDK_RESULT_GAME_SESSION_BEGIN = 100301,
		ACE_SDK_RESULT_GAME_SESSION_INTERF_CALL_FAILED = 100302,
		ACE_SDK_RESULT_GAME_SESSION_END = 100400,
		ACE_SDK_RESULT_BUSI_INTERFACE_END = 999999,
		ACE_SDK_RESULT_MAX_INT32 = 2147483647
	}

	public class AceSdkTool // TypeDefIndex: 63646
	{
		// Constructors
		public AceSdkTool(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static string get_string_from_bytearray_until_zero(byte[] input_bytes); // 0x000000018539AA60-0x000000018539AAEC
	}
}

namespace Beyond.AceSdk
{
	public class AceSDKInterfaceWin // TypeDefIndex: 63652
	{
		// Fields
		private static AceSDKInterfaceWin instance; // 0x00
		public AceSdkClient ace_client; // 0x10
		private Thread m_netThread; // 0x18
		private bool b_stopThread; // 0x20
		private string s_LoginAccount; // 0x28
		private HashSet<string> login_ids; // 0x30
		private bool isGamePaused; // 0x38
	
		// Properties
		public static AceSDKInterfaceWin Instance { get; } // 0x0000000185399F44-0x0000000185399FD4 
	
		// Constructors
		public AceSDKInterfaceWin(); // 0x0000000185399E14-0x0000000185399F44
	
		// Methods
		~AceSDKInterfaceWin(); // 0x00000001853999CC-0x0000000185399A98
		public void InitACESDK(); // 0x0000000185399A98-0x0000000185399B10
		public void DeinitACESDK(); // 0x0000000185399964-0x00000001853999CC
		public void OnApplicationPause(bool pause); // 0x00000001811F2A80-0x00000001811F2A90
		public void AceSdkClientLogIn(string account_id, string ticket, uint world_id = 0 /* Metadata: 0x023529AD */); // 0x00000001853997C0-0x00000001853998E8
		public void AceSdkClientLogOut(); // 0x00000001853998E8-0x0000000185399964
		public void StartNetThread(); // 0x0000000185399CEC-0x0000000185399E08
		private void NetworkThread(AceSdkClient ace_client); // 0x0000000185399B10-0x0000000185399C08
		private static void SendPktToGameServer(byte[] pkg); // 0x0000000185399C1C-0x0000000185399CEC
		public void OnAceSdkPacketReceived(byte[] pkt); // 0x0000000185399C08-0x0000000185399C1C
		[CompilerGenerated]
		private void _StartNetThread_b__16_0(); // 0x0000000185399E08-0x0000000185399E14
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 63647
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 63648
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 63649
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 63650
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 63651
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 63628
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}
